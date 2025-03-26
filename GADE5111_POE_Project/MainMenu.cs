using GADE5121_POE_Project;

namespace GADE5121_POE_Project
{
    public partial class frmMainMenu : Form
    {
        public frmMainMenu()
        {
            InitializeComponent();

        }

        private void btnStartGame_Click(object sender, EventArgs e)
        {
            Form dragon_battle = new frmBattle();
            dragon_battle.Show();
            this.Hide();
        }

        private void frmMainMenu_Load(object sender, EventArgs e)
        {
            MusicManager.PlayBackgroundMusic("Assets/main_menu.wav");
        }

        private void frmMainMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            MusicManager.StopBackgroundMusic();
        }
    }
}
