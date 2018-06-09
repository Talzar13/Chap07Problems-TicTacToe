using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chap07Problems_TicTacToe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnNewGame_Click(object sender, EventArgs e)
        {
            ClearSquares();
            // RandomCharacter();
            FillSquare(0);

        }

        private void RandomCharacter()
        {
            Random rand = new Random();

            foreach (Control gbx in this.Controls)
            {
                if (gbx is GroupBox)
                {
                    foreach (Control lbl in gbx.Controls)
                    {
                        lbl.Text = rand.Next(2) == 0 ? "O" : "X";
                    }
                }

            }
        }

        private void FillSquare(int square)
        {
            var lbl = gbxSquares.Controls.OfType<Label>();
            int squares = gbxSquares.Controls.Count;

            // gbxSquares.Controls[square].Text = square.ToString();


            ////foreach (Control gbx in this.Controls)
            ////{
            ////    if (gbx is GroupBox)
            ////    {
            ////        foreach (Control lbl in gbx.Controls)
            ////        {
            ////            lbl.Text = gbxSquares.Controls[lbl.TabIndex].ToString; // squares.ToString(); // lbl.TabIndex.ToString();
            ////        }
            ////    }
            ////}


            //foreach (var lbl in collection)
            //{

            //}


            ////// Numbers based on internal order of controls. 
            ////gbxSquares.Controls.OfType<GroupBox>().OrderBy(c => c.Name);
            ////for (int i = 0; i < gbxSquares.Controls.Count; i++)
            ////{
            ////    gbxSquares.Controls[i].Text = i.ToString();
            ////}






        }
        private void ClearSquares()
        {
            var labels = gbxSquares.Controls.OfType<Label>();
            foreach (var lbl in labels.OrderBy(c => c.Name))
            {
                lbl.Text = null;
            }
            /* Old version of Code, KEEP FOR REVIEW AND STUDY. 
            foreach (Control gbx in this.Controls)
            {
                if (gbx is GroupBox)
                {
                    foreach (Control lbl in gbx.Controls)
                    {
                        if (lbl is Label)
                        {
                            lbl.Text = null;
                        }
                    }
                }
            }
            */
            lblResult.Text = null;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearSquares();
        }
    }
}
