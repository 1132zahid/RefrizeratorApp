using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RefrizeratorApp
{
    public partial class Form1 : Form
    {

        Refrizerator aRefrizerator = new Refrizerator();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            aRefrizerator.MaxWeight = Convert.ToDouble(maxWeightTextBox.Text);
            MessageBox.Show("Max weight has been set");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int noOfItems = Convert.ToInt32(noOfItemsTextBox.Text);
            double weightPerUnit = Convert.ToDouble(weightPerUnitTextBox.Text);
            try
            {
                aRefrizerator.AddItems(noOfItems, weightPerUnit);
            }
            catch (Exception exObj)
            {
                MessageBox.Show(exObj.Message);
            }
            

            currentWeightTextBox.Text = aRefrizerator.CurrentWeight.ToString();
            remainingWeightTextBox.Text = aRefrizerator.RemainingWeight.ToString();

        }
    }
}
