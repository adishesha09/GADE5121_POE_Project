namespace GADE5121_POE_Project
{
    partial class frmMainMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMainMenu));
            btnStartGame = new Button();
            SuspendLayout();
            // 
            // btnStartGame
            // 
            btnStartGame.BackgroundImage = (Image)resources.GetObject("btnStartGame.BackgroundImage");
            btnStartGame.BackgroundImageLayout = ImageLayout.Stretch;
            btnStartGame.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold);
            btnStartGame.Location = new Point(517, 521);
            btnStartGame.Name = "btnStartGame";
            btnStartGame.Size = new Size(359, 80);
            btnStartGame.TabIndex = 0;
            btnStartGame.Text = "Start Game";
            btnStartGame.UseVisualStyleBackColor = true;
            btnStartGame.Click += btnStartGame_Click;
            // 
            // frmMainMenu
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1344, 664);
            Controls.Add(btnStartGame);
            MaximizeBox = false;
            Name = "frmMainMenu";
            Text = "Main Menu";
            FormClosing += frmMainMenu_FormClosing;
            Load += frmMainMenu_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button btnStartGame;
    }
}