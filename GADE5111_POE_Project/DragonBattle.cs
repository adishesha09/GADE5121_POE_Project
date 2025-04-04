using System.Media;
using System.Drawing.Text;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using GADE5121_POE_Project;

namespace GADE5121_POE_Project
{
    public partial class frmBattle : Form
    {

        public frmBattle()
        {
            InitializeComponent();

            // Add Elemental Icons for Player Dragon Types
            AddDragonIcons();
            AddDragonIcons1();
        }
        private void AddDragonIcons()
        {
            string[] imagePaths = { "Assets/fire.png", "Assets/ice.png", "Assets/wind.png", "Assets/earth.png" };
            RadioButton[] radioButtons = { rbFire1, rbIce1, rbWind1, rbEarth1 };
            for (int i = 0; i < radioButtons.Length; i++)
            {
                if (File.Exists(imagePaths[i])) // Check if file exists
                {
                    PictureBox pbIcon = new PictureBox();
                    pbIcon.Image = Image.FromFile(imagePaths[i]); // Load image
                    pbIcon.SizeMode = PictureBoxSizeMode.StretchImage;
                    pbIcon.Size = new Size(30, 30);
                    pbIcon.Location = new Point(170, radioButtons[i].Location.Y); // Align with radio button
                    pbIcon.BackColor = Color.Transparent;
                    grpPlayer1DragonType.Controls.Add(pbIcon); // Add PictureBox to the same group box
                }
            }
        }

        private void AddDragonIcons1()
        {
            string[] imagePaths1 = { "Assets/fire.png", "Assets/ice.png", "Assets/wind.png", "Assets/earth.png" };
            RadioButton[] radioButtons1 = { rbFire2, rbIce2, rbWind2, rbEarth2 };
            for (int i = 0; i < radioButtons1.Length; i++)
            {
                if (File.Exists(imagePaths1[i])) // Check if file exists
                {
                    PictureBox pbIcon = new PictureBox();
                    pbIcon.Image = Image.FromFile(imagePaths1[i]); // Load image
                    pbIcon.SizeMode = PictureBoxSizeMode.StretchImage;
                    pbIcon.Size = new Size(30, 30);
                    pbIcon.Location = new Point(170, radioButtons1[i].Location.Y); // Align with radio button
                    pbIcon.BackColor = Color.Transparent;
                    grpPlayer2DragonType.Controls.Add(pbIcon); // Add PictureBox to the same group box
                }
            }
        }

  
        private void lblPlayerName_Click(object sender, EventArgs e)
        {

        }

        private void btnStart_Click_1(object sender, EventArgs e)
        {
            Form player_turn = new frmPlayerTurn();
            player_turn.Show();
            this.Hide();
        }

        private void frmBattle_Load(object sender, EventArgs e)
        {
            MusicManager.PlayBackgroundMusic("Assets/battle_music.wav");
        }

        private void frmBattle_FormClosed(object sender, FormClosedEventArgs e)
        {
            MusicManager.StopBackgroundMusic();
        }
    }
}
