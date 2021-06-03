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
    public partial class InputsAndOutputs : Form
    {
        public InputsAndOutputs()
        {
            InitializeComponent();
        }

        private void input_typeBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.input_typeBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.farmDBDataSet);

        }

        private void InputsAndOutputs_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'farmDBDataSet.inputs' table. You can move, or remove it, as needed.
            this.inputsTableAdapter.Fill(this.farmDBDataSet.inputs);
            // TODO: This line of code loads data into the 'farmDBDataSet.input_type' table. You can move, or remove it, as needed.
            this.input_typeTableAdapter.Fill(this.farmDBDataSet.input_type);

        }
        public void UpdateDetails()
        {

            try
            {
                this.Validate();
                input_typeBindingSource.EndEdit();
                inputsBindingSource.EndEdit(); 
                int b = inputsTableAdapter.Update(this.farmDBDataSet.inputs);
                int a = this.input_typeTableAdapter.Update(this.farmDBDataSet.input_type);
                if (a >= 1 || b>=1)
                {
                    MessageBox.Show("Saved Successfully");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            UpdateDetails();


        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            
        }

        private void input_typeBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            UpdateDetails();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            UpdateDetails();
        }

        private void toolStripButton7_Click(object sender, EventArgs e)
        {
            UpdateDetails();

        }
    }
}
