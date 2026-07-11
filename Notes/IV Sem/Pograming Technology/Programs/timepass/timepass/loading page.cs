using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace timepass
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int startpos = 10;
        private void timer1_Tick(object sender, EventArgs e)
        {
            startpos += 1;
            Myprogress.Value = startpos;
            percentage.Text = startpos+"%";  
            if(Myprogress.Value ==100)
            
            {
                Myprogress.Value = 0;
                timer1.Stop();
                login log = new login ();
                log.Show();
                this.Hide();
            }

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }


    }
}
