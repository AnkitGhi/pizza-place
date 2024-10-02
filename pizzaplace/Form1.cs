using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pizzaplace
{
    public partial class Form1 : Form
    {
        public static double total_order = 0.0;
        public static string one = "";
        public static string two = "";
        public static string three = "";
        public static string four = "";
        public static string five = "";
        double total = 0.0;
        bool smallRadioAdd = false;
        bool mediumRadioAdd = false;
        bool largeRadioAdd = false;
        bool xlRadioAdd = false;
        string selectedOption = "";
        

        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void groupBox5_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if(Medium.Checked && !mediumRadioAdd) {
                total += 10.00;
                smallRadioAdd = true;
                label11.Text = "Pizza size: Medium";
            }

            else if (!Medium.Checked && mediumRadioAdd)
            {
                total -= 10.00;
                smallRadioAdd = false;
                label11.Text = "Pizza size:";
            }
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton4.Checked && !xlRadioAdd)
            {
                total += 14.00;
                xlRadioAdd = true;
                label11.Text = "Pizza size: XL";
            }

            else if (!radioButton4.Checked && xlRadioAdd)
            {
                total -= 14.00;
                xlRadioAdd = false;
                label11.Text = "Pizza size:";
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked)
            {
                if (!label12.Text.Contains("Onions"))
                {
                    label12.Text += " Onions";
                }
                else
                {
                    label12.Text = label12.Text.Replace(" Onions", "");
                }

            }
            else
            {
                label12.Text = label12.Text.Replace(" Onions", "");
            }
        }

        private void checkBox8_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox8.Checked)
            {
                total += 10.99;
                label14.Text += " Caesar Salad";
            }
            else
            {
                total -= 10.99; //price for breadsticks goes here
                label14.Text = label14.Text.Replace(" Caesar Salad", "");
            }

            UpdateTotalLabel();
        }

        private void checkBox11_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox11.Checked)
            {
                total += 14.99;
                label14.Text += " Ovenbaked Pasta";
            }
            else
            {
                total -= 14.99; //price for breadsticks goes here
                label14.Text = label14.Text.Replace(" Ovenbaked Pasta", "");
            }

            UpdateTotalLabel();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void Cheese_SelectedIndexChanged(object sender, EventArgs e)
        {
            label13.Text = "Cheese:" + Cheese.Text;
        }

        private void Sauce(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            label16.Text = "Sauce: " + comboBox1.Text;
        }

        private void groupBox7_Enter(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked && !smallRadioAdd) {
                total += 7.00;
                smallRadioAdd = true;
                label11.Text = "Pizza size: Small";
        }

            else if (!radioButton1.Checked && smallRadioAdd)
            {
                total -= 7.00;
                smallRadioAdd = false;
                label11.Text = "Pizza size";
            }
}

        private void groupBox6_Enter(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

           
    }
        private void UpdateTotalLabel()
        {
            totalLabel.Text = "Total: $" + total.ToString("F2");
            
        }
        private void button1_Click(object sender, EventArgs e)
        {
            UpdateTotalLabel();
            if (label12.Text == "Toppings: ")
            {
                label12.Text += " None";
            }
            if (label14.Text == "Sides: ")
            {
                label14.Text += " None";
            }
            total_order = total;
            one = label11.Text;
            two = label12.Text;
            three = label16.Text;
            four = label13.Text;
            five = label14.Text;
            new Form2().ShowDialog();
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked && !largeRadioAdd)
            {
                total += 12.00;
                largeRadioAdd = true;
                label11.Text = "Pizza size: Large";
            }

            else if (!radioButton3.Checked && largeRadioAdd)
            {
                total -= 12.00;
                largeRadioAdd = false;
                label11.Text = "Pizza size:";
            }
        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void checkBox10_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void checkBox10_CheckedChanged_1(object sender, EventArgs e)
        {
            if (checkBox10.Checked)
            {
                total += 6.99;
                label14.Text += " Bread Sticks";
            }
            else
            {
                total -= 6.99; //price for breadsticks goes here
                label14.Text=label14.Text.Replace(" Bread Sticks", "");
            }

            UpdateTotalLabel();
        }

        private void checkBox9_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox9.Checked)
            {
                total += 12.00;
                label14.Text += " Wings";
            }
            else
            {
                total -= 12.00;
                label14.Text = label14.Text.Replace(" Wings", "");
            }

            UpdateTotalLabel();
        }

        private void groupBox4_Enter_1(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                if (!label12.Text.Contains("Pepperoni"))
                {
                    label12.Text += " Pepperoni";
                }
                else
                {
                    label12.Text = label12.Text.Replace(" Pepperoni", "");
                }

            }
            else
            {
                label12.Text = label12.Text.Replace(" Pepperoni", "");
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                if (!label12.Text.Contains("Mushrooms"))
                {
                    label12.Text += " Mushrooms";
                }
                else
                {
                    label12.Text = label12.Text.Replace(" Mushrooms", "");
                }
            }
            else
            {
                label12.Text = label12.Text.Replace(" Mushrooms", "");
            }
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox4.Checked)
            {
                if (!label12.Text.Contains("Sausage"))
                {
                    label12.Text += " Sausage";
                }
                else
                {
                    label12.Text = label12.Text.Replace(" Sausage", "");
                }
    
            }
            else
            {
                label12.Text = label12.Text.Replace(" Sausage", "");
            }
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox5.Checked)
            {
                if (!label12.Text.Contains("Bacon"))
                {
                    label12.Text += " Bacon";
                }
                else
                {
                    label12.Text = label12.Text.Replace(" Bacon", "");
                }

            }
            else
            {
                label12.Text = label12.Text.Replace(" Bacon", "");
            }
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox6.Checked)
            {
                if (!label12.Text.Contains("Black Olives"))
                {
                    label12.Text += " Black Olives";
                }
                else
                {
                    label12.Text = label12.Text.Replace(" Black Olives", "");
                }

            }
            else
            {
                label12.Text = label12.Text.Replace(" Black Olives", "");
            }
        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox7.Checked)
            {
                if (!label12.Text.Contains("Green Peppers"))
                {
                    label12.Text += " ,Green Peppers";
                }
                else
                {
                    label12.Text = label12.Text.Replace(" ,Green Peppers", "");
                }

            }
            else
            {
                label12.Text = label12.Text.Replace(" ,Green Peppers", "");
            }
        }

        private void label12_Click(object sender, EventArgs e)
        {
           
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }
    }
}
