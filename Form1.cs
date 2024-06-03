using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace decision
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Boolean IsMatch = true;
        Boolean inputCheck(string s)
        {
            if (!((new Regex(@"^100$|^[0-9]{1,2}[.][0-9]+$|^[0-9]{1,2}$")).IsMatch(s)))
            {
                MessageBox.Show("Please input the number from 0 to 100.");
                return false;
            }
            return true;
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if (IsMatch == false)
            {
                lb1.Text = "wrong number\n";
                return;
            }

            if (Convert.ToDouble(tbox.Text) >= 90 && Convert.ToDouble(tbox.Text) <= 100)
                {
                    lb1.Text = "A級";
                    tbox.BackColor = Color.Gold;
                }
                else if (Convert.ToDouble(tbox.Text) >= 80 && Convert.ToDouble(tbox.Text) < 90)
                {
                    lb1.Text = "B級";
                    tbox.BackColor = Color.Silver;
                }
                else if (Convert.ToDouble(tbox.Text) >= 70 && Convert.ToDouble(tbox.Text) < 80)
                {
                    lb1.Text = "C級";
                    tbox.BackColor = Color.Blue;
            }
                else if (Convert.ToDouble(tbox.Text) >= 60 && Convert.ToDouble(tbox.Text) < 70)
                {
                    lb1.Text = "D級";
                    tbox.BackColor = Color.Green;
            }
                else if ( Convert.ToDouble(tbox.Text) < 60)
                {
                    lb1.Text = "E級";
                    tbox.BackColor = Color.Pink;
            }

        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (IsMatch == false)
            {
                lb2.Text = "wrong number\n";
                return;
            }

            switch (Convert.ToInt32(tbox.Text)/10)
            {
                case 10:
                case  9:
                        lb2.Text = "A級";
                        tbox.BackColor = Color.Gold;
                    break;
                case 8:
                        lb2.Text = "B級";
                        tbox.BackColor = Color.Silver;
                    break;
                case 7:
                        lb2.Text = "C級";
                        tbox.BackColor = Color.Blue;
                    break;
                case 6:
                        lb2.Text = "D級";
                        tbox.BackColor = Color.Green;
                    break;
                case 5:
                        lb2.Text = "E級";
                        tbox.BackColor = Color.Pink;
                    break;

            }

        }


        private void btnEnd_Click(object sender, EventArgs e)
        {
            this.Dispose();   //只有Form1 程式結束
            //Application.Exit(); 整個Mmenu程式結束
        }

        private void lb1_Click(object sender, EventArgs e)
        {

        }
        
        private void tbox_TextChanged(object sender, EventArgs e)
        {
            tbox.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            tbox.ForeColor = System.Drawing.Color.Black;
            if ((IsMatch = inputCheck(tbox.Text)) == false)
            {
                tbox.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
                tbox.ForeColor = System.Drawing.Color.Red;
                return;
            }
        }
    }
}
