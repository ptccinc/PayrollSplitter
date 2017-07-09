using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CsvHelper;
using CsvHelper.Configuration;
using SplitLib.Models;

namespace SplitLib
{
    /// <summary>
    /// Read and write employee configuration to a local CSV file. Just something very simple. Originally I was using SQLite, but it was overkill for what we need to do here.
    /// </summary>
    public class SettingsService
    {
        public List<EmployeeConfig> Employees { get; set; }
        private string path;
        public SettingsService(string path)
        {
            Employees=new List<EmployeeConfig>();
            
            if (!Directory.Exists(path))
                Directory.CreateDirectory(path);
            this.path = Path.Combine(path,"Employees.csv");

            LoadSettings();
        }

        public void LoadSettings()
        {
            if (!File.Exists(path))
            {
                File.Create(path).Close();
            }
            Employees.Clear();

            StreamReader s = null;
            try
            {
                s = File.OpenText(path);

                var csv = new CsvReader(s,
                    new CsvConfiguration()
                    {
                        TrimFields = true,
                        SkipEmptyRecords = true,
                        Delimiter = ","
                    });
                var lines = csv.GetRecords<EmployeeConfig>();
                Employees.AddRange(lines);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                s?.Close();               
            }
            
            
                
        }

        public void SaveSettings()
        {
            using (var s = File.CreateText(path))
            {                 
                var csv = new CsvWriter(s);
                csv.WriteRecords(Employees);
            }
                
        }

    }
}
