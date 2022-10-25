using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_Report
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void Create_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do You Want to Create Report ?", "Warning!!!", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                //converting variables
                int m1 = Convert.ToInt32(M1.Text);
                int m2 = Convert.ToInt32(M2.Text);
                int m3 = Convert.ToInt32(M3.Text);

                //total
                int total = m1 + m2 + m3;
                string TOTAL = Convert.ToString(total);
                Total1.Text = TOTAL;

                //average
                double average = total / 3;
                string AVERAGE = Convert.ToString(average);
                Average1.Text = AVERAGE + "%";

                //highest marks
                string s1 = S1.Text;
                string s2 = S2.Text;
                string s3 = S3.Text;
                int high = 0;


                if (m1 > m2)
                    if (m1 > m3)
                        high = m1;
                    else
                        high = m3;
                else
                    if (m2 > m3)
                        high = m2;
                    else
                        high = m3;

                if (high == m1)
                    textBox10.Text = s1;
                if (high == m2)
                    textBox10.Text = s2;
                if (high == m3)
                    textBox10.Text = s3;

                string HIGH = Convert.ToString(high);
                textBox11.Text = HIGH;
            }
            else
            {
                M1.Clear();
                M2.Clear();
                M3.Clear();
                S1.Clear();
                S2.Clear();
                S3.Clear();
                Name1.Clear();
                Stream1.Clear();
            }
            label7.Text = "Highest Marks   :";
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are You Sure Clear Data ?", "Attention!!!", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation) == DialogResult.OK)
            {
                M1.Clear();
                M2.Clear();
                M3.Clear();
                S1.Clear();
                S2.Clear();
                S3.Clear();
                Name1.Clear();
                Stream1.Clear();
                Average1.Clear();
                textBox10.Clear();
                textBox11.Clear();
                Total1.Clear();
                label7.Text = "Highest Marks   :";
            }
            
        }

        private void Minimum_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do You Want Show Minimum Marks ?", "Minimum Marks!!!", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation) == DialogResult.OK)
            {
                label7.Text = "Lowest Marks    :";
                //converting variables
                int m1 = Convert.ToInt32(M1.Text);
                int m2 = Convert.ToInt32(M2.Text);
                int m3 = Convert.ToInt32(M3.Text);
                //lowest marks
                string s1 = S1.Text;
                string s2 = S2.Text;
                string s3 = S3.Text;
                int low = 0;


                if (m1 < m2)
                    if (m1 < m3)
                        low = m1;
                    else
                        low = m3;
                else
                    if (m2 < m3)
                        low = m2;
                    else
                        low = m3;

                if (low == m1)
                    textBox10.Text = s1;
                if (low == m2)
                    textBox10.Text = s2;
                if (low == m3)
                    textBox10.Text = s3;

                string LOW = Convert.ToString(low);
                textBox11.Text = LOW;
            }
            
        }

        private void Print_Click(object sender, EventArgs e)
        {
            string A = Name1.Text;
            string B=Stream1.Text;
            string s1 = S1.Text;
            string s2 = S2.Text;
            string s3 = S3.Text;
            int m1 = Convert.ToInt32(M1.Text);
            int m2 = Convert.ToInt32(M2.Text);
            int m3 = Convert.ToInt32(M3.Text);
            int total = m1 + m2 + m3;
            double average = total / 3;

            if (MessageBox.Show("Do You Want to Print This Form ?", "Print!!!", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation) == DialogResult.OK)
            {
                MessageBox.Show("............STUDENT REPORT............\n\n\nStudent Name : " + A + ",\n\nSubject Stream : "
                    + B + ",\n\nSubjects\t\tMarks\n" + s1 + "\t\t" + m1 + "\n\n" + s2 + "\t\t" + m2 + "\n\n" + s3 + "\t\t"
                    + m3 + "\n\nTotal Marks : " + total + ",\n\n" + label7.Text + " " + textBox10.Text + ", " + textBox11.Text
                    + ",\n\nAverage Marks : " + average + "%.\n\n\n......................................................");
            }
        }
    }
}
