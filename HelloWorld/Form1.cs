using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HelloWorld
{
    public partial class Form1 : Form
    {
        public string helloworld = "Hello World!!";
        public int open_close = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void ShowWords_Click(object sender, EventArgs e)
        {
            if (open_close == 0)
            {
                this.Text_HelloWorld.Text = helloworld;
                Console.WriteLine("[Jacky Debug] : Show Text and the Switch number is " + open_close);
                open_close = 1;
            }
            else {
                this.Text_HelloWorld.Text = "";
                Console.WriteLine("[Jacky Debug] : Close Text and the Switch number is " + open_close);
                open_close = 0;
            }
        }
    }
}
