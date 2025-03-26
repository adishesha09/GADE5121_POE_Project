using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using GADE5121_POE_Project;

namespace GADE5121_POE_Project
{
    public partial class frmPlayerTurn : Form
    {
        public frmPlayerTurn()
        {
            InitializeComponent();

        }
        private void btnBlock_Click(object sender, EventArgs e)
        {

        }

        private void grpOpponent_Enter(object sender, EventArgs e)
        {

        }

        private void frmPlayerTurn_Load(object sender, EventArgs e)
        {

        }

        private void btnAttack_Click(object sender, EventArgs e)
        {

        }

        private void frmPlayerTurn_FormClosing(object sender, FormClosingEventArgs e)
        {
            MusicManager.StopBackgroundMusic();
        }
    }
}
