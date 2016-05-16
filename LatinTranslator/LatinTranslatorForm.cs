// Program: Latin Translator
// Developer: Mikael Taylor
// Date: January 21, 2016
// Description: This program displays translation results from Latin to English for the words Sinister, Dexter, and Center.
//              It does so with the use of 3 buttons that translate the latin words that are displayed on the button into
//              their respective English translations.
//
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace LatinTranslator
{
    public partial class Form1 : Form
    {
        public Form1()
        {//begin Form1
            InitializeComponent();//Default constructor.
        }//end Form1
     
        private void Form1_Load(object sender, EventArgs e)
        {//load the form
            lblResult.Text = "Press one of the buttons.";//Default lblResult value when no button has been clicked.
        }//end load form

        private void btnSinisterLeft_Click(object sender, EventArgs e)//btnSinisterLeft's method.
        {//begin btnSinisterLeft click
            lblResult.Text = "Left";//When the Sinister button is clicked, change the label's text to Left.
        }//end btnSinisterLeft click

        private void btnDexterRight_Click(object sender, EventArgs e)
        {//begin btnDexterRight click
            lblResult.Text = "Right";//When the Dexter button is clicked, change the label's text to Right.
        }//end btnDexterRight click

        private void btnMediumCenter_Click(object sender, EventArgs e)
        {//begin btnMediumCenter click
            lblResult.Text = "Center";//When the Medium button is clicked, change the label's text to Center.
        }//end btnMediumCenter click
    }//close Form1
}//end class
