namespace GADE5121_POE_Project
{
    partial class frmPlayerTurn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPlayerTurn));
            grpPlayerTurn = new GroupBox();
            btnBlock = new Button();
            btnSpecialAttack = new Button();
            btnAttack = new Button();
            lblPlayerHP = new Label();
            grpOpponent = new GroupBox();
            lblOpponentHP = new Label();
            lblOpponentName = new Label();
            grpBattleLog = new GroupBox();
            txtBattleLog = new RichTextBox();
            grpPlayerTurn.SuspendLayout();
            grpOpponent.SuspendLayout();
            grpBattleLog.SuspendLayout();
            SuspendLayout();
            // 
            // grpPlayerTurn
            // 
            grpPlayerTurn.Controls.Add(btnBlock);
            grpPlayerTurn.Controls.Add(btnSpecialAttack);
            grpPlayerTurn.Controls.Add(btnAttack);
            grpPlayerTurn.Controls.Add(lblPlayerHP);
            grpPlayerTurn.Font = new Font("Segoe UI", 9F);
            grpPlayerTurn.Location = new Point(36, 14);
            grpPlayerTurn.Margin = new Padding(4, 5, 4, 5);
            grpPlayerTurn.Name = "grpPlayerTurn";
            grpPlayerTurn.Padding = new Padding(4, 5, 4, 5);
            grpPlayerTurn.Size = new Size(390, 345);
            grpPlayerTurn.TabIndex = 0;
            grpPlayerTurn.TabStop = false;
            grpPlayerTurn.Text = "Player's Turn";
            // 
            // btnBlock
            // 
            btnBlock.Location = new Point(26, 243);
            btnBlock.Name = "btnBlock";
            btnBlock.Size = new Size(330, 58);
            btnBlock.TabIndex = 3;
            btnBlock.Text = "Block";
            btnBlock.UseVisualStyleBackColor = true;
            btnBlock.Click += btnBlock_Click;
            // 
            // btnSpecialAttack
            // 
            btnSpecialAttack.Location = new Point(26, 164);
            btnSpecialAttack.Name = "btnSpecialAttack";
            btnSpecialAttack.Size = new Size(330, 58);
            btnSpecialAttack.TabIndex = 2;
            btnSpecialAttack.Text = "Special Attack";
            btnSpecialAttack.UseVisualStyleBackColor = true;
            // 
            // btnAttack
            // 
            btnAttack.Location = new Point(26, 88);
            btnAttack.Name = "btnAttack";
            btnAttack.Size = new Size(330, 58);
            btnAttack.TabIndex = 1;
            btnAttack.Text = "Attack";
            btnAttack.UseVisualStyleBackColor = true;
            btnAttack.Click += btnAttack_Click;
            // 
            // lblPlayerHP
            // 
            lblPlayerHP.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPlayerHP.Location = new Point(0, 39);
            lblPlayerHP.Margin = new Padding(4, 0, 4, 0);
            lblPlayerHP.Name = "lblPlayerHP";
            lblPlayerHP.Size = new Size(356, 46);
            lblPlayerHP.TabIndex = 0;
            lblPlayerHP.Text = "HP: ";
            lblPlayerHP.TextAlign = ContentAlignment.TopCenter;
            // 
            // grpOpponent
            // 
            grpOpponent.Controls.Add(lblOpponentHP);
            grpOpponent.Controls.Add(lblOpponentName);
            grpOpponent.Font = new Font("Segoe UI", 9F);
            grpOpponent.Location = new Point(433, 102);
            grpOpponent.Name = "grpOpponent";
            grpOpponent.Size = new Size(309, 134);
            grpOpponent.TabIndex = 1;
            grpOpponent.TabStop = false;
            grpOpponent.Text = "Opponent's Turn";
            grpOpponent.Enter += grpOpponent_Enter;
            // 
            // lblOpponentHP
            // 
            lblOpponentHP.AutoSize = true;
            lblOpponentHP.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblOpponentHP.Location = new Point(113, 82);
            lblOpponentHP.Name = "lblOpponentHP";
            lblOpponentHP.Size = new Size(71, 38);
            lblOpponentHP.TabIndex = 1;
            lblOpponentHP.Text = "HP: ";
            lblOpponentHP.TextAlign = ContentAlignment.TopCenter;
            // 
            // lblOpponentName
            // 
            lblOpponentName.AutoSize = true;
            lblOpponentName.Font = new Font("Sitka Banner", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblOpponentName.Location = new Point(59, 36);
            lblOpponentName.Name = "lblOpponentName";
            lblOpponentName.Size = new Size(178, 35);
            lblOpponentName.TabIndex = 0;
            lblOpponentName.Text = "Opponent's Name";
            // 
            // grpBattleLog
            // 
            grpBattleLog.Controls.Add(txtBattleLog);
            grpBattleLog.Font = new Font("Segoe UI", 9F);
            grpBattleLog.ForeColor = SystemColors.ControlText;
            grpBattleLog.Location = new Point(36, 377);
            grpBattleLog.Name = "grpBattleLog";
            grpBattleLog.Size = new Size(684, 196);
            grpBattleLog.TabIndex = 2;
            grpBattleLog.TabStop = false;
            grpBattleLog.Text = "Battle Log";
            // 
            // txtBattleLog
            // 
            txtBattleLog.Location = new Point(26, 36);
            txtBattleLog.Name = "txtBattleLog";
            txtBattleLog.Size = new Size(627, 139);
            txtBattleLog.TabIndex = 0;
            txtBattleLog.Text = "";
            // 
            // frmPlayerTurn
            // 
            AutoScaleDimensions = new SizeF(15F, 38F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(754, 600);
            Controls.Add(grpBattleLog);
            Controls.Add(grpOpponent);
            Controls.Add(grpPlayerTurn);
            Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 5, 4, 5);
            MaximizeBox = false;
            Name = "frmPlayerTurn";
            Text = "Player Turn";
            FormClosing += frmPlayerTurn_FormClosing;
            Load += frmPlayerTurn_Load;
            grpPlayerTurn.ResumeLayout(false);
            grpOpponent.ResumeLayout(false);
            grpOpponent.PerformLayout();
            grpBattleLog.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grpPlayerTurn;
        private Label lblPlayerHP;
        private GroupBox grpOpponent;
        private Button btnBlock;
        private Button btnSpecialAttack;
        private Button btnAttack;
        private Label lblOpponentHP;
        private Label lblOpponentName;
        private GroupBox grpBattleLog;
        private RichTextBox txtBattleLog;
    }
}