using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kalkul
{
    public partial class main : Form
    {
        public bool flag;
        public string tempParametr;
        public string act;


        public main()
        {
            InitializeComponent();
        }

        private void main_Load(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            TextBox.Text = "0";
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
            Button numButton = (Button)sender;
            int tempNumber;
            bool isNum = int.TryParse(numButton.Text, out tempNumber);

            if (flag)
            {
                flag = false;
                TextBox.Text = "0";
            }
            
            
            if( TextBox.Text == "0" && isNum)
            {
                TextBox.Text = numButton.Text;
            }
            else
            {

                if ( numButton.Text.Contains(","))
                {
                    TextBox.Text = TextBox.Text + numButton.Text;
                }
                else
                {
                    TextBox.Text = TextBox.Text + numButton.Text;
                }
            }
        }

        private void ButtonErase_Click(object sender, EventArgs e)
        {
            if (TextBox.Text != "")
            {
               TextBox.Text = TextBox.Text.Substring(0, TextBox.Text.Length - 1);
            }

            else
            {
                TextBox.Text = "0";
            }
        }

        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            Button buttonAct = (Button)sender;
            act = buttonAct.Text;
            tempParametr = TextBox.Text;
            flag = true;
        }

        private void ButtonEquals_Click(object sender, EventArgs e)
        {
            double firstVar, secondVar, result = 0;
            Double.TryParse(tempParametr, out firstVar);
            Double.TryParse(TextBox.Text, out secondVar);

            if(act =="+")
            {
                result = firstVar + secondVar;
            }
            
            if (act == "-")
            {
                result = firstVar - secondVar;
            }

            if (act == "*")
            {
                result = firstVar * secondVar;
            }
            if (act == "/")
            {
                result = firstVar / secondVar;
            }
            if (act == "%")
            {
                result = (firstVar % secondVar)*100;
            }
            TextBox.Text = result.ToString();
            flag = true;
        }

        Point lastPoint;
        private void TopPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                this.Left += e.X - lastPoint.X;
            this.Top += e.Y - lastPoint.Y;
        }

        private void TopPanel_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (TopPanel.BackColor == Color.White)
            {
                TopPanel.BackColor = Color.FromArgb(39, 39, 39);
                TextBox.BackColor = Color.FromArgb(39, 39, 39);
            }
            else
            {
                TopPanel.BackColor = Color.White;
            }

        }
    }
}
