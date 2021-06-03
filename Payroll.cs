using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FarmSystem
{
    public partial class Payroll : Form
    {
        public Payroll()
        {
            InitializeComponent();
        }

        private void employee_typeBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.employee_typeBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.farmDBDataSet);

        }

        private void Payroll_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'farmDBDataSet.payroll' table. You can move, or remove it, as needed.
            this.payrollTableAdapter.Fill(this.farmDBDataSet.payroll);
            // TODO: This line of code loads data into the 'farmDBDataSet.attendance' table. You can move, or remove it, as needed.
            this.attendanceTableAdapter.Fill(this.farmDBDataSet.attendance);
            // TODO: This line of code loads data into the 'farmDBDataSet.employees' table. You can move, or remove it, as needed.
            this.employeesTableAdapter.Fill(this.farmDBDataSet.employees);
            // TODO: This line of code loads data into the 'farmDBDataSet.employee_type' table. You can move, or remove it, as needed.
            this.employee_typeTableAdapter.Fill(this.farmDBDataSet.employee_type);

        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
           // employee_typeBindingSource.AddNew();
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            try
            {
                employee_typeBindingSource.RemoveCurrent();
                int a = employee_typeTableAdapter.Update(farmDBDataSet.employee_type);
                if (a >= 1)
                {
                    MessageBox.Show("Deleted Successfully");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void employee_typeBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                employee_typeBindingSource.EndEdit();
                int a = employee_typeTableAdapter.Update(farmDBDataSet.employee_type);
                if (a >= 1)
                {
                    MessageBox.Show("Saved Successfully");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
          //  employeesBindingSource.AddNew();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            try
            {
                employeesBindingSource.RemoveCurrent();
                int a = employeesTableAdapter.Update(farmDBDataSet.employees);
                if (a >= 1)
                {
                    MessageBox.Show("Deleted Successfully");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void toolStripButton7_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                employeesBindingSource.EndEdit();
                int a = employeesTableAdapter.Update(farmDBDataSet.employees);
                if (a >= 1)
                {
                    MessageBox.Show("Saved Successfully");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void addAttendance_Click(object sender, EventArgs e)
        {
          //  attendanceBindingSource.AddNew();
            date_DateTimePicker.Value = DateTime.Now;
        }

        private void deleteAttendance_Click(object sender, EventArgs e)
        {
            try
            {
                attendanceBindingSource.RemoveCurrent();
                int a = attendanceTableAdapter.Update(farmDBDataSet.attendance);
                if (a >= 1)
                {
                    MessageBox.Show("Deleted Successfully");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void saveAttendance_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                attendanceBindingSource.EndEdit();
                int a = attendanceTableAdapter.Update(farmDBDataSet.attendance);
                if (a >= 1)
                {
                    MessageBox.Show("Saved Successfully");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void toolStripButton8_Click(object sender, EventArgs e)
        {
          //  payrollBindingSource.AddNew();
        }

        private void toolStripButton9_Click(object sender, EventArgs e)
        {
            try
            {
                payrollBindingSource.RemoveCurrent();
                int a = payrollTableAdapter.Update(farmDBDataSet.payroll);
                if (a >= 1)
                {
                    MessageBox.Show("Deleted Successfully");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void toolStripButton18_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                payrollBindingSource.EndEdit();
                int a = payrollTableAdapter.Update(farmDBDataSet.payroll);
                if (a >= 1)
                {
                    MessageBox.Show("Saved Successfully");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
