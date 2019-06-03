using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SavingsTracker_V1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            int temp;
            //tosave.Text = Convert.ToString("0%");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            //var item = this.comboBox1.GetItemText(this.comboBox1.SelectedItem);
            //MessageBox.Show(item);  //message box will pop-up kung ano pinili from the list
        }

        private void rent_TextChanged(object sender, EventArgs e)
        {

            if (!string.IsNullOrEmpty(rent.Text) && !string.IsNullOrEmpty(laundry.Text))
            {
                totalExp.Text = (Convert.ToDecimal(laundry.Text) + Convert.ToDecimal(rent.Text)).ToString();
            }

        }
        private void laundry_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(rent.Text) && !string.IsNullOrEmpty(laundry.Text))
            {
                totalExp.Text = (Convert.ToDecimal(laundry.Text) + Convert.ToDecimal(rent.Text)).ToString();
            }

        }

        private void salary_TextChanged(object sender, EventArgs e)
        {

            if (!string.IsNullOrEmpty(tosave.Text) && !string.IsNullOrEmpty(salary.Text))
            {
                //float temp = ((Convert.ToInt32(tosave.Text)/100) * Convert.ToInt32(salary.Text));
                //decimal temp = (Convert.ToInt32(salary.Text) * (Convert.ToDecimal(tosave.Text) / 100));
                //savings.Text = temp.ToString();

                savings.Text = (Convert.ToDecimal(salary.Text) * (Convert.ToDecimal(tosave.Text) / 100)).ToString();
            }
        }

        private void tosave_TextChanged(object sender, EventArgs e)
        {

            if (!string.IsNullOrEmpty(tosave.Text) && !string.IsNullOrEmpty(salary.Text))
            {
                //float temp = ((Convert.ToInt32(tosave.Text)/100) * Convert.ToInt32(salary.Text));
                //decimal temp = (Convert.ToInt32(salary.Text) * (Convert.ToDecimal(tosave.Text) / 100));
                // savings.Text = temp.ToString();

                
                savings.Text = (Convert.ToDecimal(salary.Text) * (Convert.ToDecimal(tosave.Text) / 100)).ToString(); //total savings from salary*tosave%

                textBox1.Text = savings.Text;
                textBox2.Text = salary.Text;

                decimal temp = (Convert.ToDecimal(textBox2.Text) - (Convert.ToDecimal(textBox1.Text))); //total money to be spsent
                tospend.Text = temp.ToString();
            }

        }
    }
}
    

