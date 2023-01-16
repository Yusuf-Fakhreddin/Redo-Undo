using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
namespace Redo_Undo
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

        //LIFO (Stack)
        Stack st = new Stack();
        private void btn_undo_Click(object sender, EventArgs e)
        {
            // push last char to stack 
            // remove last char from text output
            if (textOutput.Text.Length > 0)
            {
                int LastIndex = textOutput.Text.Length - 1;
                string LastChar = textOutput.Text.Substring(LastIndex, 1);
                textOutput.Text = textOutput.Text.Substring(0, LastIndex);
                st.Push(LastChar);
            }
        }

        private void btn_redo_Click(object sender, EventArgs e)
        {
            if (st.Count > 0)
            {
                textOutput.Text += st.Pop();
            }
        }
    }
}
