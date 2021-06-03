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
    public partial class Inventory : Form
    {
        public Inventory()
        {
            InitializeComponent();
        }

        private void stockTypesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.stockTypesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.farmDBDataSet);

        }

        private void Inventory_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'farmDBDataSet.Stock' table. You can move, or remove it, as needed.
            this.stockTableAdapter.Fill(this.farmDBDataSet.Stock);
            // TODO: This line of code loads data into the 'farmDBDataSet.StockTypes' table. You can move, or remove it, as needed.
            this.stockTypesTableAdapter.Fill(this.farmDBDataSet.StockTypes);

        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            UpdateDetails();
        }

        private void UpdateDetails()
        {
            try
            {
                this.Validate();
                this.stockTypesBindingSource.EndEdit();
                int a = this.stockTypesTableAdapter.Update(this.farmDBDataSet.StockTypes);
                this.stockBindingSource.EndEdit();
                int b = this.stockTableAdapter.Update(this.farmDBDataSet.Stock);


                if (a >= 1 || b>=1)
                {
                    MessageBox.Show("Successfully updated", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void stockTypesBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
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

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {

        }
    }
}
