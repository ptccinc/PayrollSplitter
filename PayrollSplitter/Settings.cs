using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SplitLib;
using SplitLib.Models;

namespace PayrollSplitter
{
    public partial class Settings : Form
    {
        private SettingsService _manager;
        private bool _adding = false;
        public Settings(SettingsService manager)
        {
            InitializeComponent();
            this._manager = manager;
        }

        private void Settings_Load(object sender, EventArgs e)
        {
            foreach (var managerEmployee in _manager.Employees.OrderBy(x=>x.Name))
            {
                EmployeeList.Items.Add(managerEmployee);
            }
        }

     
        private void EmployeeList_SelectedIndexChanged(object sender, EventArgs e)
        {
            _adding = false;
            NameTxt.BackColor = Color.White;
            UniqueIdTxt.BackColor = Color.White;
            EmployeeConfig emp = GetSelected();

            if (emp != null)
            {
                EditGroup.Visible = true;
                NameTxt.Text = emp.Name;
                PasswordTxt.Text = emp.Password;
                EmailTxt.Text = emp.Email;
                UniqueIdTxt.Text = emp.UniqueIdentifier;
                Save.Visible = true;
                Delete.Visible = true;
                
            }
            else
            {
                EditGroup.Visible = false;
            }
        }

        EmployeeConfig GetSelected()
        {
            var e=EmployeeList.SelectedItem as EmployeeConfig;
            return e;

        }

        private void Save_Click(object sender, EventArgs e)
        {

            //Field validation
            var error = false;
            if (NameTxt.Text.Trim() == "")
            {
                NameTxt.BackColor = Color.Yellow;
                error = true;
            }
            else
            {
                NameTxt.BackColor = Color.White;
            }

            if (UniqueIdTxt.Text.Trim() == "")
            {
                UniqueIdTxt.BackColor = Color.Yellow;
                error = true;
            }
            else
            {
                UniqueIdTxt.BackColor = Color.White;
            }

            if (error)
                return;

            if (!_adding)
            {
                EmployeeConfig emp = GetSelected();

                if (emp == null) return;
                emp.Name = NameTxt.Text;
                emp.Email = EmailTxt.Text;
                emp.Password = PasswordTxt.Text;
                emp.UniqueIdentifier = UniqueIdTxt.Text;
                var index = EmployeeList.SelectedIndex;
                EmployeeList.Items.RemoveAt(index);
                EmployeeList.Items.Insert(index, emp);
            }
            else
            {
                EmployeeConfig emp=new EmployeeConfig();
                emp.Name = NameTxt.Text;
                emp.Email = EmailTxt.Text;
                emp.Password = PasswordTxt.Text;
                emp.UniqueIdentifier = UniqueIdTxt.Text;

                _manager.Employees.Add(emp);
                EmployeeList.Items.Add(emp);
            }
            _adding = false;
            EditGroup.Visible = false;
            _manager.SaveSettings();
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            EmployeeConfig emp = GetSelected();

            if (emp == null) return;
            if (_adding) return;

            var index=EmployeeList.Items.IndexOf(emp);
            EmployeeList.Items.RemoveAt(index);
            _manager.Employees.Remove(emp);
            _manager.SaveSettings();
            
            EditGroup.Visible = false;
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            EmployeeList.SelectedItem = null;
            NameTxt.BackColor = Color.White;
            UniqueIdTxt.BackColor = Color.White;
            _adding = true;
            EditGroup.Visible = true;
            NameTxt.Text = "";
            PasswordTxt.Text = "";
            EmailTxt.Text = "";
            UniqueIdTxt.Text = "";
            Save.Visible = true;
            Delete.Visible = false;
            NameTxt.Focus();
        }
    }
}
