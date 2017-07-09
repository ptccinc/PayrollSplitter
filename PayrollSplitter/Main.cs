using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using PdfSharp.Pdf;
using PdfSharp.Pdf.IO;
using SplitLib;
using SplitLib.Models;
using SplitLib.Services;

namespace PayrollSplitter
{
    public partial class Main : Form
    {
        private SettingsService _settingsService;
        private SplitService _splitService;
        public Main()
        {
            InitializeComponent();
        }
        private void Main_Load(object sender, EventArgs e)
        {
            var path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "PaystubSplitAndProtect");

            _settingsService = new SettingsService(path);
            //Could wire up a DI container...or just not and say we did
            _splitService = new SplitService(_settingsService);

            this.Text = "Paystub Split and Protect V1.0.1";
        }

        private void ChoosePDFBtn_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() != DialogResult.OK) return;
            previewList.Items.Clear();
            FilePath.Text = openFileDialog1.FileName;

            panel1.Visible = false;

            PreviewLabel1.Visible = false;
            PreviewLabel2.Visible = false;
            PreviewLabel3.Visible = false;


            var stubs=_splitService.GenerateIndividualStubs(openFileDialog1.FileName);
            if (!stubs.Any()) return;
            foreach (var payStub in stubs)
            {
                previewList.Items.Add(payStub);
            }
               
            panel1.Visible = true;
        }

       
        private void SettingsBtn_Click(object sender, EventArgs e)
        {
            Settings settings=new Settings(_settingsService);
            settings.ShowDialog(this);
        }
        

        private void previewList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (previewList.SelectedItem != null)
            {

                var item = (PayStub)previewList.SelectedItem;
                PreviewBtn.Visible = true;

                PreviewLabel1.Visible = true;
                PreviewLabel2.Visible = true;
                PreviewLabel3.Visible = true;

                PreviewLabel1.Text = item.Name;
                PreviewLabel2.Text = item.Email;
                PreviewLabel3.Text = item.Password;
            }
        }

        private void PreviewBtn_Click(object sender, EventArgs e)
        {
            if (previewList.SelectedItem != null)
            {
                var item = (PayStub)previewList.SelectedItem;
                Process.Start(item.Filename);
            }
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                int count = 0;
                foreach (PayStub stub in previewList.Items)
                {

                    var newfilename = folderBrowserDialog1.SelectedPath + "\\" + MakeValidFileName(stub.Name) + ".pdf";
                    if (File.Exists(newfilename))
                        File.Delete(newfilename);

                    File.Copy(stub.Filename, newfilename);
                    count++;
                }                
                MessageBox.Show("Done");
            }

            
        }

        private static string MakeValidFileName(string name)
        {
            var invalidChars = Regex.Escape(new string(Path.GetInvalidFileNameChars()));
            var invalidReStr = string.Format(@"[{0}]+", invalidChars);
            return Regex.Replace(name, invalidReStr, "_");
        }

        
    }
}
