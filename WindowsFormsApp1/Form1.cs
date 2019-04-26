using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            button1.Click += Button_Click;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;

            label1.Text = $"Нажали кнопку {b.Name}";
                       
        }


        private void Button_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Click!");


        }

        private void MonthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            


        }
    }
}
