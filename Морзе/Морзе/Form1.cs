using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Морзе
{
    public partial class Form1 : Form
    {
        bool drag = false;
        Point StartPoint = new Point(0, 0);

        public Form1()
        {
            InitializeComponent();
        }

        void Translate()
        {
            try
            {
                morze_translate.Text = "";
                char[] translate_latter = writebox.Text.ToUpper().ToCharArray();
                for (int i = 0; i < translate_latter.Length; i++)
                {
                    string text = translate_latter[i].ToString();

                    if (text.Contains("A"))
                    {
                        morze_translate.Text += ".- ";
                    }

                    else if (text.Contains(' '))
                    {
                        morze_translate.Text += " / " ;
                    }

                    else if (text.Contains('B'))
                    {
                        morze_translate.Text += "-... ";
                    }

                    else if (text.Contains('C'))
                    {
                        morze_translate.Text += "-.-. ";
                    }

                    else if (text.Contains('D'))
                    {
                        morze_translate.Text += "-.. ";
                    }

                    else if (text.Contains('E'))
                    {
                        morze_translate.Text += ". ";
                    }

                    else if (text.Contains('F'))
                    {
                        morze_translate.Text += "..-. ";
                    }

                    else if (text.Contains('G'))
                    {
                        morze_translate.Text += "--. ";
                    }

                    else if (text.Contains('H'))
                    {
                        morze_translate.Text += "....";
                    }

                    else if (text.Contains('I'))
                    {
                        morze_translate.Text += ".. ";
                    }

                    else if (text.Contains('J'))
                    {
                        morze_translate.Text += ".--- ";
                    }

                    else if (text.Contains('K'))
                    {
                        morze_translate.Text += "-.- ";
                    }

                    else if (text.Contains('L'))
                    {
                        morze_translate.Text += ".-.. ";
                    }

                    else if (text.Contains('M'))
                    {
                        morze_translate.Text += "-- ";
                    }

                    else if (text.Contains('N'))
                    {
                        morze_translate.Text += "-. ";
                    }

                    else if (text.Contains('O'))
                    {
                        morze_translate.Text += "--- ";
                    }

                    else if (text.Contains('P'))
                    {
                        morze_translate.Text += ".--. ";
                    }

                    else if (text.Contains('Q'))
                    {
                        morze_translate.Text += "--.- ";
                    }

                    else if (text.Contains('R'))
                    {
                        morze_translate.Text += ".-. ";
                    }

                    else if (text.Contains('S'))
                    {
                        morze_translate.Text += "... ";
                    }

                    else if (text.Contains('T'))
                    {
                        morze_translate.Text += "- ";
                    }

                    else if (text.Contains('U'))
                    {
                        morze_translate.Text += "..- ";
                    }

                    else if (text.Contains('V'))
                    {
                        morze_translate.Text += "...- ";
                    }

                    else if (text.Contains('W'))
                    {
                        morze_translate.Text += ".-- ";
                    }

                    else if (text.Contains('X'))
                    {
                        morze_translate.Text += "-..- ";
                    }

                    else if (text.Contains('Y'))
                    {
                        morze_translate.Text += "-.-- ";
                    }

                    else if (text.Contains('Z'))
                    {
                        morze_translate.Text += "--.. ";
                    }

                    else if (text.Contains('1'))
                    {
                        morze_translate.Text += ".---- ";
                    }

                    else if (text.Contains('2'))
                    {
                        morze_translate.Text += "..--- ";
                    }

                    else if (text.Contains('3'))
                    {
                        morze_translate.Text += "...-- ";
                    }

                    else if (text.Contains('4'))
                    {
                        morze_translate.Text += "....-  ";
                    }

                    else if (text.Contains('5'))
                    {
                        morze_translate.Text += "..... ";
                    }

                    else if (text.Contains('6'))
                    {
                        morze_translate.Text += "-.... ";
                    }

                    else if (text.Contains('7'))
                    {
                        morze_translate.Text += "--... ";
                    }

                    else if (text.Contains('8'))
                    {
                        morze_translate.Text += "---.. ";
                    }

                    else if (text.Contains('9'))
                    {
                        morze_translate.Text += "----. ";
                    }

                    else if (text.Contains('0'))
                    {
                        morze_translate.Text += "----- ";
                    }


                }

                
            }
            catch (Exception)
            {
                MessageBox.Show("Извините за ошибку, мы уже уже спешим её решить. Но возможно её виновник вы!", "ОШИБКА ._.");
            }
        }

        private void exit_btn_MouseEnter(object sender, EventArgs e)
        {
            exit_btn.BackColor = Color.Salmon;
        }

        private void exit_btn_MouseLeave(object sender, EventArgs e)
        {
            exit_btn.BackColor = Color.Black;
        }

        private void minimize_btn_MouseEnter(object sender, EventArgs e)
        {
            minimize_btn.BackColor = Color.SteelBlue;
        }

        private void minimize_btn_MouseLeave(object sender, EventArgs e)
        {
            minimize_btn.BackColor = Color.Black;
        }

        private void exit_btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void minimize_btn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void ControlBox_MouseDown(object sender, MouseEventArgs e)
        {
            drag = true;
            StartPoint = new Point(e.X, e.Y);
        }

        private void ControlBox_MouseUp(object sender, MouseEventArgs e)
        {
            drag = false;
        }

        private void ControlBox_MouseMove(object sender, MouseEventArgs e)
        {
            if (drag)
            {
                Point p = PointToScreen(e.Location);
                this.Location = new Point(p.X - StartPoint.X, p.Y - StartPoint.Y);
            }
        }

        private void maximize_btn_Click(object sender, EventArgs e)
        {
            if(this.WindowState != FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Maximized;
            }

            else
            {
                this.WindowState = FormWindowState.Normal;
            }
        }

        private void maximize_btn_MouseEnter(object sender, EventArgs e)
        {
            maximize_btn.BackColor = Color.OliveDrab;
        }

        private void maximize_btn_MouseLeave(object sender, EventArgs e)
        {
            maximize_btn.BackColor = Color.Black;
        }

        private void translate_btn_Click(object sender, EventArgs e)
        {
            Translate();
        }
    }
}
