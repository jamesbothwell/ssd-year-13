using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AS2_BiologyQuiz
{
    public partial class frmSplash : Form
    {
        public frmSplash()
        {
            InitializeComponent();
        }

        private void frmSplash_Load(object sender, EventArgs e)
        {
            //start timer for 6 seconds which is how long the GIF last
            timerSplash.Start();
        }

        private void timerSplash_Tick(object sender, EventArgs e)
        {
            //change over to the login after 6 seconds
            timerSplash.Stop();
            this.Hide();
            Form frmLogin = new frmLogin();
            frmLogin.Show();
        }

    }
}
