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
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void btnPayroll_Click(object sender, EventArgs e)
        {
            Payroll payroll = new Payroll();
            payroll.ShowDialog();
        }

        private void btnCrops_Click(object sender, EventArgs e)
        {
            Crop_Management crop_Management = new Crop_Management();
            crop_Management.ShowDialog();
        }

        private void btnAnimals_Click(object sender, EventArgs e)
        {
            LiveStock_Management liveStock_Management = new LiveStock_Management();
            liveStock_Management.ShowDialog();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {

        }

        private void btninventory_Click(object sender, EventArgs e)
        {
            Inventory inventory = new Inventory();
            inventory.ShowDialog();

        }

        private void btnProfitability_Click(object sender, EventArgs e)
        {
            InputsAndOutputs inputsAndOutputs = new InputsAndOutputs();
            inputsAndOutputs.ShowDialog();
        }
    }
}
