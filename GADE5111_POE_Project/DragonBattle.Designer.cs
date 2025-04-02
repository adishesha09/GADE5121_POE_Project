namespace GADE5121_POE_Project
{
    partial class frmBattle
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBattle));
            grpPlayer1 = new GroupBox();
            btnSave1 = new Button();
            grpPlayer1DragonType = new GroupBox();
            rbEarth1 = new RadioButton();
            rbWind1 = new RadioButton();
            rbIce1 = new RadioButton();
            rbFire1 = new RadioButton();
            txtPlayer1Dragon = new TextBox();
            txtPlayer1Name = new TextBox();
            lblDragon1Name = new Label();
            lblPlayer1Name = new Label();
            grpPlayer2 = new GroupBox();
            btnSave2 = new Button();
            grpPlayer2DragonType = new GroupBox();
            rbEarth2 = new RadioButton();
            rbWind2 = new RadioButton();
            rbIce2 = new RadioButton();
            rbFire2 = new RadioButton();
            txtPlayer2Dragon = new TextBox();
            txtPlayer2Name = new TextBox();
            lblDragon2Name = new Label();
            lblPlayer2Name = new Label();
            lblDragonStats = new Label();
            btnStart = new Button();
            grpPlayer1.SuspendLayout();
            grpPlayer1DragonType.SuspendLayout();
            grpPlayer2.SuspendLayout();
            grpPlayer2DragonType.SuspendLayout();
            SuspendLayout();
            // 
            // grpPlayer1
            // 
            grpPlayer1.Controls.Add(btnSave1);
            grpPlayer1.Controls.Add(grpPlayer1DragonType);
            grpPlayer1.Controls.Add(txtPlayer1Dragon);
            grpPlayer1.Controls.Add(txtPlayer1Name);
            grpPlayer1.Controls.Add(lblDragon1Name);
            grpPlayer1.Controls.Add(lblPlayer1Name);
            grpPlayer1.Location = new Point(43, 41);
            grpPlayer1.Margin = new Padding(2, 2, 2, 2);
            grpPlayer1.Name = "grpPlayer1";
            grpPlayer1.Padding = new Padding(2, 2, 2, 2);
            grpPlayer1.Size = new Size(381, 403);
            grpPlayer1.TabIndex = 1;
            grpPlayer1.TabStop = false;
            grpPlayer1.Text = "Player 1";
            // 
            // btnSave1
            // 
            btnSave1.Location = new Point(19, 326);
            btnSave1.Margin = new Padding(2, 2, 2, 2);
            btnSave1.Name = "btnSave1";
            btnSave1.Size = new Size(332, 34);
            btnSave1.TabIndex = 5;
            btnSave1.Text = "Save";
            btnSave1.UseVisualStyleBackColor = true;
            // 
            // grpPlayer1DragonType
            // 
            grpPlayer1DragonType.Controls.Add(rbEarth1);
            grpPlayer1DragonType.Controls.Add(rbWind1);
            grpPlayer1DragonType.Controls.Add(rbIce1);
            grpPlayer1DragonType.Controls.Add(rbFire1);
            grpPlayer1DragonType.Location = new Point(18, 112);
            grpPlayer1DragonType.Margin = new Padding(2, 2, 2, 2);
            grpPlayer1DragonType.Name = "grpPlayer1DragonType";
            grpPlayer1DragonType.Padding = new Padding(2, 2, 2, 2);
            grpPlayer1DragonType.Size = new Size(334, 198);
            grpPlayer1DragonType.TabIndex = 4;
            grpPlayer1DragonType.TabStop = false;
            grpPlayer1DragonType.Text = "Dragon Type";
            // 
            // rbEarth1
            // 
            rbEarth1.AutoSize = true;
            rbEarth1.Location = new Point(17, 119);
            rbEarth1.Margin = new Padding(2, 2, 2, 2);
            rbEarth1.Name = "rbEarth1";
            rbEarth1.Size = new Size(118, 24);
            rbEarth1.TabIndex = 3;
            rbEarth1.TabStop = true;
            rbEarth1.Text = "Earth Dragon";
            rbEarth1.UseVisualStyleBackColor = true;
            // 
            // rbWind1
            // 
            rbWind1.AutoSize = true;
            rbWind1.Location = new Point(17, 91);
            rbWind1.Margin = new Padding(2, 2, 2, 2);
            rbWind1.Name = "rbWind1";
            rbWind1.Size = new Size(119, 24);
            rbWind1.TabIndex = 2;
            rbWind1.TabStop = true;
            rbWind1.Text = "Wind Dragon";
            rbWind1.UseVisualStyleBackColor = true;
            // 
            // rbIce1
            // 
            rbIce1.AutoSize = true;
            rbIce1.Location = new Point(17, 63);
            rbIce1.Margin = new Padding(2, 2, 2, 2);
            rbIce1.Name = "rbIce1";
            rbIce1.Size = new Size(103, 24);
            rbIce1.TabIndex = 1;
            rbIce1.TabStop = true;
            rbIce1.Text = "Ice Dragon";
            rbIce1.UseVisualStyleBackColor = true;
            // 
            // rbFire1
            // 
            rbFire1.AutoSize = true;
            rbFire1.Location = new Point(17, 35);
            rbFire1.Margin = new Padding(2, 2, 2, 2);
            rbFire1.Name = "rbFire1";
            rbFire1.Size = new Size(108, 24);
            rbFire1.TabIndex = 0;
            rbFire1.TabStop = true;
            rbFire1.Text = "Fire Dragon";
            rbFire1.UseVisualStyleBackColor = true;
            // 
            // txtPlayer1Dragon
            // 
            txtPlayer1Dragon.Location = new Point(135, 64);
            txtPlayer1Dragon.Margin = new Padding(2, 2, 2, 2);
            txtPlayer1Dragon.MaxLength = 15;
            txtPlayer1Dragon.Name = "txtPlayer1Dragon";
            txtPlayer1Dragon.Size = new Size(217, 27);
            txtPlayer1Dragon.TabIndex = 3;
            // 
            // txtPlayer1Name
            // 
            txtPlayer1Name.Location = new Point(135, 25);
            txtPlayer1Name.Margin = new Padding(2, 2, 2, 2);
            txtPlayer1Name.MaxLength = 25;
            txtPlayer1Name.Name = "txtPlayer1Name";
            txtPlayer1Name.Size = new Size(217, 27);
            txtPlayer1Name.TabIndex = 2;
            // 
            // lblDragon1Name
            // 
            lblDragon1Name.AutoSize = true;
            lblDragon1Name.Location = new Point(10, 62);
            lblDragon1Name.Margin = new Padding(2, 0, 2, 0);
            lblDragon1Name.Name = "lblDragon1Name";
            lblDragon1Name.Size = new Size(106, 20);
            lblDragon1Name.TabIndex = 1;
            lblDragon1Name.Text = "Dragon Name:";
            // 
            // lblPlayer1Name
            // 
            lblPlayer1Name.AutoSize = true;
            lblPlayer1Name.Location = new Point(10, 27);
            lblPlayer1Name.Margin = new Padding(2, 0, 2, 0);
            lblPlayer1Name.Name = "lblPlayer1Name";
            lblPlayer1Name.Size = new Size(96, 20);
            lblPlayer1Name.TabIndex = 0;
            lblPlayer1Name.Text = "Player Name:";
            // 
            // grpPlayer2
            // 
            grpPlayer2.Controls.Add(btnSave2);
            grpPlayer2.Controls.Add(grpPlayer2DragonType);
            grpPlayer2.Controls.Add(txtPlayer2Dragon);
            grpPlayer2.Controls.Add(txtPlayer2Name);
            grpPlayer2.Controls.Add(lblDragon2Name);
            grpPlayer2.Controls.Add(lblPlayer2Name);
            grpPlayer2.Location = new Point(454, 41);
            grpPlayer2.Margin = new Padding(2, 2, 2, 2);
            grpPlayer2.Name = "grpPlayer2";
            grpPlayer2.Padding = new Padding(2, 2, 2, 2);
            grpPlayer2.Size = new Size(381, 403);
            grpPlayer2.TabIndex = 2;
            grpPlayer2.TabStop = false;
            grpPlayer2.Text = "Player 2";
            // 
            // btnSave2
            // 
            btnSave2.Location = new Point(16, 326);
            btnSave2.Margin = new Padding(2, 2, 2, 2);
            btnSave2.Name = "btnSave2";
            btnSave2.Size = new Size(336, 34);
            btnSave2.TabIndex = 4;
            btnSave2.Text = "Save";
            btnSave2.UseVisualStyleBackColor = true;
            // 
            // grpPlayer2DragonType
            // 
            grpPlayer2DragonType.Controls.Add(rbEarth2);
            grpPlayer2DragonType.Controls.Add(rbWind2);
            grpPlayer2DragonType.Controls.Add(rbIce2);
            grpPlayer2DragonType.Controls.Add(rbFire2);
            grpPlayer2DragonType.Location = new Point(16, 111);
            grpPlayer2DragonType.Margin = new Padding(2, 2, 2, 2);
            grpPlayer2DragonType.Name = "grpPlayer2DragonType";
            grpPlayer2DragonType.Padding = new Padding(2, 2, 2, 2);
            grpPlayer2DragonType.Size = new Size(336, 198);
            grpPlayer2DragonType.TabIndex = 3;
            grpPlayer2DragonType.TabStop = false;
            grpPlayer2DragonType.Text = "Dragon Type";
            // 
            // rbEarth2
            // 
            rbEarth2.AutoSize = true;
            rbEarth2.Location = new Point(18, 120);
            rbEarth2.Margin = new Padding(2, 2, 2, 2);
            rbEarth2.Name = "rbEarth2";
            rbEarth2.Size = new Size(118, 24);
            rbEarth2.TabIndex = 3;
            rbEarth2.TabStop = true;
            rbEarth2.Text = "Earth Dragon";
            rbEarth2.UseVisualStyleBackColor = true;
            // 
            // rbWind2
            // 
            rbWind2.AutoSize = true;
            rbWind2.Location = new Point(18, 92);
            rbWind2.Margin = new Padding(2, 2, 2, 2);
            rbWind2.Name = "rbWind2";
            rbWind2.Size = new Size(119, 24);
            rbWind2.TabIndex = 2;
            rbWind2.TabStop = true;
            rbWind2.Text = "Wind Dragon";
            rbWind2.UseVisualStyleBackColor = true;
            // 
            // rbIce2
            // 
            rbIce2.AutoSize = true;
            rbIce2.Location = new Point(18, 64);
            rbIce2.Margin = new Padding(2, 2, 2, 2);
            rbIce2.Name = "rbIce2";
            rbIce2.Size = new Size(103, 24);
            rbIce2.TabIndex = 1;
            rbIce2.TabStop = true;
            rbIce2.Text = "Ice Dragon";
            rbIce2.UseVisualStyleBackColor = true;
            // 
            // rbFire2
            // 
            rbFire2.AutoSize = true;
            rbFire2.Location = new Point(18, 36);
            rbFire2.Margin = new Padding(2, 2, 2, 2);
            rbFire2.Name = "rbFire2";
            rbFire2.Size = new Size(108, 24);
            rbFire2.TabIndex = 0;
            rbFire2.TabStop = true;
            rbFire2.Text = "Fire Dragon";
            rbFire2.UseVisualStyleBackColor = true;
            // 
            // txtPlayer2Dragon
            // 
            txtPlayer2Dragon.Location = new Point(136, 62);
            txtPlayer2Dragon.Margin = new Padding(2, 2, 2, 2);
            txtPlayer2Dragon.MaxLength = 15;
            txtPlayer2Dragon.Name = "txtPlayer2Dragon";
            txtPlayer2Dragon.Size = new Size(217, 27);
            txtPlayer2Dragon.TabIndex = 2;
            // 
            // txtPlayer2Name
            // 
            txtPlayer2Name.Location = new Point(136, 27);
            txtPlayer2Name.Margin = new Padding(2, 2, 2, 2);
            txtPlayer2Name.MaxLength = 25;
            txtPlayer2Name.Name = "txtPlayer2Name";
            txtPlayer2Name.Size = new Size(217, 27);
            txtPlayer2Name.TabIndex = 1;
            // 
            // lblDragon2Name
            // 
            lblDragon2Name.AutoSize = true;
            lblDragon2Name.Location = new Point(12, 62);
            lblDragon2Name.Margin = new Padding(2, 0, 2, 0);
            lblDragon2Name.Name = "lblDragon2Name";
            lblDragon2Name.Size = new Size(106, 20);
            lblDragon2Name.TabIndex = 0;
            lblDragon2Name.Text = "Dragon Name:";
            // 
            // lblPlayer2Name
            // 
            lblPlayer2Name.AutoSize = true;
            lblPlayer2Name.Location = new Point(12, 25);
            lblPlayer2Name.Margin = new Padding(2, 0, 2, 0);
            lblPlayer2Name.Name = "lblPlayer2Name";
            lblPlayer2Name.Size = new Size(96, 20);
            lblPlayer2Name.TabIndex = 0;
            lblPlayer2Name.Text = "Player Name:";
            // 
            // lblDragonStats
            // 
            lblDragonStats.Font = new Font("Georgia", 12F, FontStyle.Bold);
            lblDragonStats.ForeColor = Color.Gold;
            lblDragonStats.Location = new Point(845, 41);
            lblDragonStats.Margin = new Padding(2, 0, 2, 0);
            lblDragonStats.Name = "lblDragonStats";
            lblDragonStats.Size = new Size(221, 462);
            lblDragonStats.TabIndex = 3;
            // 
            // btnStart
            // 
            btnStart.BackgroundImageLayout = ImageLayout.Stretch;
            btnStart.Location = new Point(45, 456);
            btnStart.Margin = new Padding(2, 2, 2, 2);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(790, 46);
            btnStart.TabIndex = 4;
            btnStart.Text = "Start Game";
            btnStart.UseVisualStyleBackColor = true;
            btnStart.Click += btnStart_Click_1;
            // 
            // frmBattle
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1075, 531);
            Controls.Add(btnStart);
            Controls.Add(lblDragonStats);
            Controls.Add(grpPlayer2);
            Controls.Add(grpPlayer1);
            Margin = new Padding(2, 2, 2, 2);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmBattle";
            Text = "Dragon Battle!";
            FormClosed += frmBattle_FormClosed;
            Load += frmBattle_Load;
            grpPlayer1.ResumeLayout(false);
            grpPlayer1.PerformLayout();
            grpPlayer1DragonType.ResumeLayout(false);
            grpPlayer1DragonType.PerformLayout();
            grpPlayer2.ResumeLayout(false);
            grpPlayer2.PerformLayout();
            grpPlayer2DragonType.ResumeLayout(false);
            grpPlayer2DragonType.PerformLayout();
            ResumeLayout(false);
        }

        #endregion;
        private GroupBox grpPlayer1;
        private GroupBox grpPlayer2;
        private TextBox txtPlayer1Dragon;
        private TextBox txtPlayer1Name;
        private Label lblDragon1Name;
        private Label lblPlayer1Name;
        private GroupBox grpPlayer1DragonType;
        private RadioButton rbWind1;
        private RadioButton rbIce1;
        private RadioButton rbFire1;
        private Button btnSave1;
        private RadioButton rbEarth1;
        private Label lblPlayer2Name;
        private Label lblDragon2Name;
        private TextBox txtPlayer2Name;
        private Button btnSave2;
        private GroupBox grpPlayer2DragonType;
        private TextBox txtPlayer2Dragon;
        private RadioButton rbWind2;
        private RadioButton rbIce2;
        private RadioButton rbFire2;
        private RadioButton rbEarth2;
        private Label lblDragonStats;
        private Button btnStart;
    }
}
