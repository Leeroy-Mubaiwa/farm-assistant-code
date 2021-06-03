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
    public partial class LiveStock_Management : Form
    {
        public LiveStock_Management()
        {
            InitializeComponent();
        }

        private void animal_typeBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.animal_typeBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.farmDBDataSet);

        }

        private void LiveStock_Management_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'farmDBDataSet.animal_processes' table. You can move, or remove it, as needed.
            this.animal_processesTableAdapter.Fill(this.farmDBDataSet.animal_processes);
            // TODO: This line of code loads data into the 'farmDBDataSet.animals' table. You can move, or remove it, as needed.
            this.animalsTableAdapter.Fill(this.farmDBDataSet.animals);
            // TODO: This line of code loads data into the 'farmDBDataSet.animal_type' table. You can move, or remove it, as needed.
            this.animal_typeTableAdapter.Fill(this.farmDBDataSet.animal_type);

        }

        private void animal_typeBindingNavigator_RefreshItems(object sender, EventArgs e)
        {
           // animal_typeBindingSource.AddNew();
        }

        
        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            try
            {
                animal_typeBindingSource.RemoveCurrent();
                int a = animal_typeTableAdapter.Update(farmDBDataSet.animal_type);
                if (a >= 1)
                {
                    MessageBox.Show("Deleted Successfully");
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void animal_typeBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                animal_typeBindingSource.EndEdit();
                int a = animal_typeTableAdapter.Update(farmDBDataSet.animal_type);
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

        private void addAnimal_Click(object sender, EventArgs e)
        {
            //animalsBindingSource.AddNew();
            date_of_birthDateTimePicker.Value = DateTime.Now;

        }

        private void deleteanimal_Click(object sender, EventArgs e)
        {
            try
            {
                animalsBindingSource.RemoveCurrent();
                int a = animalsTableAdapter.Update(farmDBDataSet.animals);
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

        private void saveAnimal_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                animalsBindingSource.EndEdit();
                int a = animalsTableAdapter.Update(farmDBDataSet.animals);
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

        private void addprocesses_Click(object sender, EventArgs e)
        {
          //  animal_processesBindingSource.AddNew();
            date_of_processDateTimePicker.Value = DateTime.Now;

        }

        private void deleteprocesses_Click(object sender, EventArgs e)
        {
            try
            {
                animal_processesBindingSource.RemoveCurrent();
                int a = animal_processesTableAdapter.Update(farmDBDataSet.animal_processes);
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

        private void saveprocesses_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                animal_processesBindingSource.EndEdit();
                int a = animal_processesTableAdapter.Update(farmDBDataSet.animal_processes);
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
