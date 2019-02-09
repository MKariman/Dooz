using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsDooz
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int PlayerOne = 0, Pc = 0;
        Int32 Check()
        {
            if(btn1.Text==btn2.Text && btn2.Text==btn3.Text)
            {
                if (btn1.Text == "X")
                    return 1;
                if (btn1.Text == "O")
                    return 2;
            }
            if (btn1.Text == btn4.Text && btn4.Text == btn7.Text)
            {
                if (btn1.Text == "X")
                    return 1;
                if (btn1.Text == "O")
                    return 2;
            }
            if (btn1.Text == btn5.Text && btn5.Text == btn9.Text)
            {
                if (btn1.Text == "X")
                    return 1;
                if (btn1.Text == "O")
                    return 2;
            }
            if (btn2.Text == btn5.Text && btn5.Text == btn8.Text)
            {
                if (btn2.Text == "X")
                    return 1;
                if (btn2.Text == "O")
                    return 2;
            }
            if (btn3.Text == btn6.Text && btn6.Text == btn9.Text)
            {
                if (btn3.Text == "X")
                    return 1;
                if (btn3.Text == "O")
                    return 2;
            }
            if (btn3.Text == btn5.Text && btn5.Text == btn7.Text)
            {
                if (btn3.Text == "X")
                    return 1;
                if (btn3.Text == "O")
                    return 2;
            }
            if (btn4.Text == btn5.Text && btn5.Text == btn6.Text)
            {
                if (btn4.Text == "X")
                    return 1;
                if (btn4.Text == "O")
                    return 2;
            }
            if (btn7.Text == btn8.Text && btn8.Text == btn9.Text)
            {
                if (btn7.Text == "X")
                    return 1;
                if (btn7.Text == "O")
                    return 2;
            }
            return 0;
        }
        void NewGame()
        {
            btn1.Text = " ";
            btn1.Enabled = true;
            btn2.Text = " ";
            btn2.Enabled = true;
            btn3.Text = " ";
            btn3.Enabled = true;
            btn4.Text = " ";
            btn4.Enabled = true;
            btn5.Text = " ";
            btn5.Enabled = true;
            btn6.Text = " ";
            btn6.Enabled = true;
            btn7.Text = " ";
            btn7.Enabled = true;
            btn8.Text = " ";
            btn8.Enabled = true;
            btn9.Text = " ";
            btn9.Enabled = true;
            
        }
        void PcSelect(Button btn)
        {
            btn.Text = "O";
            btn.Enabled = false;
        }
        void PcPlay()
        {

            if (btn1.Text=="O" && btn2.Text=="O" && btn3.Enabled)
            {
                PcSelect(btn3);
            }
            else if (btn2.Text == "O" && btn3.Text == "O" && btn1.Enabled)
            {
                PcSelect(btn1);
            }
            else if (btn1.Text == "O" && btn3.Text == "O" && btn1.Enabled)
            {
                PcSelect(btn2);
            }
            else if (btn4.Text == "O" && btn5.Text == "O" && btn6.Enabled)
            {
                PcSelect(btn6);
            }
            else if (btn4.Text == "O" && btn6.Text == "O" && btn5.Enabled)
            {
                PcSelect(btn5);
            }
            else if (btn5.Text == "O" && btn6.Text == "O" && btn4.Enabled)
            {
                PcSelect(btn4);
            }
            else if (btn7.Text == "O" && btn8.Text == "O" && btn9.Enabled)
            {
                PcSelect(btn9);
            }
            else if (btn7.Text == "O" && btn9.Text == "O" && btn8.Enabled)
            {
                PcSelect(btn8);
            }
            else if (btn8.Text == "O" && btn9.Text == "O" && btn7.Enabled)
            {
                PcSelect(btn7);
            }
            else if (btn1.Text == "O" && btn4.Text == "O" && btn7.Enabled)
            {
                PcSelect(btn7);
            }
            else if (btn1.Text == "O" && btn7.Text == "O" && btn4.Enabled)
            {
                PcSelect(btn4);
            }
            else if (btn4.Text == "O" && btn7.Text == "O" && btn1.Enabled)
            {
                PcSelect(btn1);
            }
            else if (btn2.Text == "O" && btn5.Text == "O" && btn8.Enabled)
            {
                PcSelect(btn8);
            }
            else if (btn2.Text == "O" && btn8.Text == "O" && btn5.Enabled)
            {
                PcSelect(btn5);
            }
            else if (btn8.Text == "O" && btn5.Text == "O" && btn2.Enabled)
            {
                PcSelect(btn2);
            }
            else if (btn3.Text == "O" && btn6.Text == "O" && btn9.Enabled)
            {
                PcSelect(btn9);
            }
            else if (btn3.Text == "O" && btn9.Text == "O" && btn6.Enabled)
            {
                PcSelect(btn6);
            }
            else if (btn6.Text == "O" && btn9.Text == "O" && btn3.Enabled)
            {
                PcSelect(btn3);
            }
            else if (btn1.Text == "O" && btn5.Text == "O" && btn9.Enabled)
            {
                PcSelect(btn9);
            }
            else if (btn5.Text == "O" && btn9.Text == "O" && btn1.Enabled)
            {
                PcSelect(btn1);
            }
            else if (btn1.Text == "O" && btn9.Text == "O" && btn5.Enabled)
            {
                PcSelect(btn5);
            }
            else if (btn3.Text == "O" && btn5.Text == "O" && btn7.Enabled)
            {
                PcSelect(btn7);
            }
            else if (btn5.Text == "O" && btn7.Text == "O" && btn3.Enabled)
            {
                PcSelect(btn3);
            }
            else if (btn3.Text == "O" && btn7.Text == "O" && btn5.Enabled)
            {
                PcSelect(btn5);
            }
            else if (btn1.Text == "X" && btn2.Text == "X" && btn3.Enabled)
            {
                PcSelect(btn3);
            }
            else if (btn2.Text == "X" && btn3.Text == "X" && btn1.Enabled)
            {
                PcSelect(btn1);
            }
            else if (btn1.Text == "X" && btn3.Text == "X" && btn1.Enabled)
            {
                PcSelect(btn2);
            }
            else if (btn4.Text == "X" && btn5.Text == "X" && btn6.Enabled)
            {
                PcSelect(btn6);
            }
            else if (btn4.Text == "X" && btn6.Text == "X" && btn5.Enabled)
            {
                PcSelect(btn5);
            }
            else if (btn5.Text == "X" && btn6.Text == "X" && btn4.Enabled)
            {
                PcSelect(btn4);
            }
            else if (btn7.Text == "X" && btn8.Text == "X" && btn9.Enabled)
            {
                PcSelect(btn9);
            }
            else if (btn7.Text == "X" && btn9.Text == "X" && btn8.Enabled)
            {
                PcSelect(btn8);
            }
            else if (btn8.Text == "X" && btn9.Text == "X" && btn7.Enabled)
            {
                PcSelect(btn7);
            }
            else if (btn1.Text == "X" && btn4.Text == "X" && btn7.Enabled)
            {
                PcSelect(btn7);
            }
            else if (btn1.Text == "X" && btn7.Text == "X" && btn4.Enabled)
            {
                PcSelect(btn4);
            }
            else if (btn4.Text == "X" && btn7.Text == "X" && btn1.Enabled)
            {
                PcSelect(btn1);
            }
            else if (btn2.Text == "X" && btn5.Text == "X" && btn8.Enabled)
            {
                PcSelect(btn8);
            }
            else if (btn2.Text == "X" && btn8.Text == "X" && btn5.Enabled)
            {
                PcSelect(btn5);
            }
            else if (btn8.Text == "X" && btn5.Text == "X" && btn2.Enabled)
            {
                PcSelect(btn2);
            }
            else if (btn3.Text == "X" && btn6.Text == "X" && btn9.Enabled)
            {
                PcSelect(btn9);
            }
            else if (btn3.Text == "X" && btn9.Text == "X" && btn6.Enabled)
            {
                PcSelect(btn6);
            }
            else if (btn6.Text == "X" && btn9.Text == "X" && btn3.Enabled)
            {
                PcSelect(btn3);
            }
            else if (btn1.Text == "X" && btn5.Text == "X" && btn9.Enabled)
            {
                PcSelect(btn9);
            }
            else if (btn5.Text == "X" && btn9.Text == "X" && btn1.Enabled)
            {
                PcSelect(btn1);
            }
            else if (btn1.Text == "X" && btn9.Text == "X" && btn5.Enabled)
            {
                PcSelect(btn5);
            }
            else if (btn3.Text == "X" && btn5.Text == "X" && btn7.Enabled)
            {
                PcSelect(btn7);
            }
            else if (btn5.Text == "X" && btn7.Text == "X" && btn3.Enabled)
            {
                PcSelect(btn3);
            }
            else if (btn3.Text == "X" && btn7.Text == "X" && btn5.Enabled)
            {
                PcSelect(btn5);
            }
            else
            {
                bool Go = true;
                if (!Equalaize())
                {
                    do
                    {
                        Random rnd = new Random();
                        int num = (rnd.Next(1, 9));
                        switch (num)
                        {
                            case 1:
                                if (btn1.Enabled)
                                {
                                    PcSelect(btn1);
                                    Go = false;
                                }
                                break;
                            case 2:
                                if (btn2.Enabled)
                                {
                                    PcSelect(btn2);
                                    Go = false;
                                }
                                break;
                            case 3:
                                if (btn3.Enabled)
                                {
                                    PcSelect(btn3);
                                    Go = false;
                                }
                                break;
                            case 4:
                                if (btn4.Enabled)
                                {
                                    PcSelect(btn4);
                                    Go = false;
                                }
                                break;
                            case 5:
                                if (btn5.Enabled)
                                {
                                    PcSelect(btn5);
                                    Go = false;
                                }
                                break;
                            case 6:
                                if (btn6.Enabled)
                                {
                                    PcSelect(btn6);
                                    Go = false;
                                }
                                break;
                            case 7:
                                if (btn7.Enabled)
                                {
                                    PcSelect(btn7);
                                    Go = false;
                                }
                                break;
                            case 8:
                                if (btn8.Enabled)
                                {
                                    PcSelect(btn8);
                                    Go = false;
                                }
                                break;
                            case 9:
                                if (btn9.Enabled)
                                {
                                    PcSelect(btn9);
                                    Go = false;
                                }
                                break;
                        }
                    } while (Go);
                }
            }
        }

        bool Equalaize()
        {
            if(btn1.Enabled || btn2.Enabled || btn3.Enabled || btn4.Enabled || btn5.Enabled || btn6.Enabled || btn7.Enabled || btn8.Enabled || btn9.Enabled)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private void Click(object sender, EventArgs e)
        {



            Button button = (Button)sender;
            button.Text = "X";
            button.Enabled = false;


            if(Check()!=0)
            {
                if(Check()==1)
                {
                    MessageBox.Show("YOU WIN :)","FINISH",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    PlayerOne++;
                }
                    
                NewGame();
            }


            PcPlay();

            if (Check() != 0)
            {
                if (Check() == 2)
                {
                    MessageBox.Show("YOU LOSE :(", "FINISH", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Pc++;
                }

                NewGame();
            }


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Pc Point : " + Pc +"\nPlayer Point : " + PlayerOne , "RESULT",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            NewGame();
        }
    }
}
