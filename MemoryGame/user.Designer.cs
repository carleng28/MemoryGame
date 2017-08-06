namespace MemoryGame
{
    partial class user
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
            this.tabUsers = new System.Windows.Forms.TabControl();
            this.newPlayer = new System.Windows.Forms.TabPage();
            this.btn_new_start = new System.Windows.Forms.Button();
            this.txt_user_name = new System.Windows.Forms.TextBox();
            this.lbl_new_user_name = new System.Windows.Forms.Label();
            this.registeredPlayer = new System.Windows.Forms.TabPage();
            this.btn_reg_player_start = new System.Windows.Forms.Button();
            this.cb_select_player = new System.Windows.Forms.ComboBox();
            this.lbl_select_player = new System.Windows.Forms.Label();
            this.tabUsers.SuspendLayout();
            this.newPlayer.SuspendLayout();
            this.registeredPlayer.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabUsers
            // 
            this.tabUsers.Controls.Add(this.newPlayer);
            this.tabUsers.Controls.Add(this.registeredPlayer);
            this.tabUsers.Location = new System.Drawing.Point(12, 28);
            this.tabUsers.Name = "tabUsers";
            this.tabUsers.SelectedIndex = 0;
            this.tabUsers.Size = new System.Drawing.Size(394, 234);
            this.tabUsers.TabIndex = 0;
            // 
            // newPlayer
            // 
            this.newPlayer.BackColor = System.Drawing.SystemColors.Control;
            this.newPlayer.Controls.Add(this.btn_new_start);
            this.newPlayer.Controls.Add(this.txt_user_name);
            this.newPlayer.Controls.Add(this.lbl_new_user_name);
            this.newPlayer.Location = new System.Drawing.Point(4, 22);
            this.newPlayer.Name = "newPlayer";
            this.newPlayer.Padding = new System.Windows.Forms.Padding(3);
            this.newPlayer.Size = new System.Drawing.Size(386, 208);
            this.newPlayer.TabIndex = 0;
            this.newPlayer.Text = "New Player";
            // 
            // btn_new_start
            // 
            this.btn_new_start.Location = new System.Drawing.Point(153, 139);
            this.btn_new_start.Name = "btn_new_start";
            this.btn_new_start.Size = new System.Drawing.Size(75, 23);
            this.btn_new_start.TabIndex = 2;
            this.btn_new_start.Text = "Start!";
            this.btn_new_start.UseVisualStyleBackColor = true;
            this.btn_new_start.Click += new System.EventHandler(this.btn_new_start_Click);
            // 
            // txt_user_name
            // 
            this.txt_user_name.Location = new System.Drawing.Point(132, 66);
            this.txt_user_name.Name = "txt_user_name";
            this.txt_user_name.Size = new System.Drawing.Size(221, 20);
            this.txt_user_name.TabIndex = 1;
            // 
            // lbl_new_user_name
            // 
            this.lbl_new_user_name.AutoSize = true;
            this.lbl_new_user_name.Location = new System.Drawing.Point(45, 69);
            this.lbl_new_user_name.Name = "lbl_new_user_name";
            this.lbl_new_user_name.Size = new System.Drawing.Size(63, 13);
            this.lbl_new_user_name.TabIndex = 0;
            this.lbl_new_user_name.Text = "User Name:";
            // 
            // registeredPlayer
            // 
            this.registeredPlayer.BackColor = System.Drawing.SystemColors.Control;
            this.registeredPlayer.Controls.Add(this.btn_reg_player_start);
            this.registeredPlayer.Controls.Add(this.cb_select_player);
            this.registeredPlayer.Controls.Add(this.lbl_select_player);
            this.registeredPlayer.Location = new System.Drawing.Point(4, 22);
            this.registeredPlayer.Name = "registeredPlayer";
            this.registeredPlayer.Padding = new System.Windows.Forms.Padding(3);
            this.registeredPlayer.Size = new System.Drawing.Size(386, 208);
            this.registeredPlayer.TabIndex = 1;
            this.registeredPlayer.Text = "Registered Player";
            // 
            // btn_reg_player_start
            // 
            this.btn_reg_player_start.Location = new System.Drawing.Point(153, 139);
            this.btn_reg_player_start.Name = "btn_reg_player_start";
            this.btn_reg_player_start.Size = new System.Drawing.Size(75, 23);
            this.btn_reg_player_start.TabIndex = 2;
            this.btn_reg_player_start.Text = "Start!";
            this.btn_reg_player_start.UseVisualStyleBackColor = true;
            this.btn_reg_player_start.Click += new System.EventHandler(this.btn_reg_player_start_Click);
            // 
            // cb_select_player
            // 
            this.cb_select_player.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_select_player.FormattingEnabled = true;
            this.cb_select_player.Location = new System.Drawing.Point(136, 66);
            this.cb_select_player.Name = "cb_select_player";
            this.cb_select_player.Size = new System.Drawing.Size(196, 21);
            this.cb_select_player.TabIndex = 1;
            // 
            // lbl_select_player
            // 
            this.lbl_select_player.AutoSize = true;
            this.lbl_select_player.Location = new System.Drawing.Point(47, 69);
            this.lbl_select_player.Name = "lbl_select_player";
            this.lbl_select_player.Size = new System.Drawing.Size(72, 13);
            this.lbl_select_player.TabIndex = 0;
            this.lbl_select_player.Text = "Select Player:";
            // 
            // user
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumTurquoise;
            this.ClientSize = new System.Drawing.Size(425, 285);
            this.Controls.Add(this.tabUsers);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "user";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Memory Game - User Select";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.closeEvent);
            this.Load += new System.EventHandler(this.userOnLoadEvent);
            this.tabUsers.ResumeLayout(false);
            this.newPlayer.ResumeLayout(false);
            this.newPlayer.PerformLayout();
            this.registeredPlayer.ResumeLayout(false);
            this.registeredPlayer.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabUsers;
        private System.Windows.Forms.TabPage newPlayer;
        private System.Windows.Forms.TabPage registeredPlayer;
        private System.Windows.Forms.Button btn_new_start;
        private System.Windows.Forms.TextBox txt_user_name;
        private System.Windows.Forms.Label lbl_new_user_name;
        private System.Windows.Forms.ComboBox cb_select_player;
        private System.Windows.Forms.Label lbl_select_player;
        private System.Windows.Forms.Button btn_reg_player_start;
    }
}