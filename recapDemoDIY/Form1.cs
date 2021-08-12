using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace recapDemoDIY
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Button[,] buttons = new Button[8,8];
            int left = 0;
            int top = 0;

            for (int i = 0; i < buttons.GetUpperBound(0); i++)
            {
                for (int x = 0; x < buttons.GetUpperBound(1); x++)
                {
                    buttons[i, x] = new Button();
                    buttons[i, x].Height = 50;
                    buttons[i, x].Width = 50;
                    buttons[i, x].Left = left;
                    buttons[i, x].Top = top;
                    left += 50;

                    if ((i+x)%2==0)
                    {
                        buttons[i, x].BackColor = Color.Black;
                    }
                    else
                    {
                        buttons[i, x].BackColor = Color.Gray;
                    }

                    this.Controls.Add(buttons[i, x]);
                }
                top += 50;
                left = 0;
            }
        }
    }
}
