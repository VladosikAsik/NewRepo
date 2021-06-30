using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestGitHub
{
    public partial class Form1 : Form
    {
        System.Windows.Forms.Timer timer;
        public Form1()
        {
            InitializeComponent();

            this.timer = new System.Windows.Forms.Timer();
            this.timer.Tick += Timer_Tick;
            this.timer.Start();



        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            string clock = $"{DateTime.Now.Hour} : {DateTime.Now.Minute} : {DateTime.Now.Second}";
            this.label.Text = clock;
        }






    }
}
