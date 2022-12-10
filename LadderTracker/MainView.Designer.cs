
namespace LadderTracker
{
    partial class MainView
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.seasonView = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SeasonName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StartDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EndDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sessionView = new System.Windows.Forms.DataGridView();
            this.addNewSeasonButton = new System.Windows.Forms.Button();
            this.editSeasonButton = new System.Windows.Forms.Button();
            this.deleteSeasonButton = new System.Windows.Forms.Button();
            this.addNewSessionButton = new System.Windows.Forms.Button();
            this.editSessionButton = new System.Windows.Forms.Button();
            this.deleteSessionButton = new System.Windows.Forms.Button();
            this.saveSeasonButton = new System.Windows.Forms.Button();
            this.saveSessionButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.supportGroupBox = new System.Windows.Forms.GroupBox();
            this.supportLossButton = new System.Windows.Forms.Button();
            this.supportWinButton = new System.Windows.Forms.Button();
            this.damageGroupBox = new System.Windows.Forms.GroupBox();
            this.dmgWinButton = new System.Windows.Forms.Button();
            this.dmgLossButton = new System.Windows.Forms.Button();
            this.tankGroupBox = new System.Windows.Forms.GroupBox();
            this.tankWinButton = new System.Windows.Forms.Button();
            this.tankLossButton = new System.Windows.Forms.Button();
            this.IDSession = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StartTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EndTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TankWin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TankLoss = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DamageWin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DamageLoss = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SupportWin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SupportLoss = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.seasonView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sessionView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.supportGroupBox.SuspendLayout();
            this.damageGroupBox.SuspendLayout();
            this.tankGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // seasonView
            // 
            this.seasonView.AllowUserToAddRows = false;
            this.seasonView.AllowUserToDeleteRows = false;
            this.seasonView.AllowUserToResizeColumns = false;
            this.seasonView.AllowUserToResizeRows = false;
            this.seasonView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.seasonView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.SeasonName,
            this.StartDate,
            this.EndDate});
            this.seasonView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.seasonView.Location = new System.Drawing.Point(-2, 1);
            this.seasonView.MultiSelect = false;
            this.seasonView.Name = "seasonView";
            this.seasonView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.seasonView.Size = new System.Drawing.Size(1000, 380);
            this.seasonView.TabIndex = 0;
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.Visible = false;
            // 
            // SeasonName
            // 
            this.SeasonName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.SeasonName.HeaderText = "Season";
            this.SeasonName.Name = "SeasonName";
            this.SeasonName.Width = 68;
            // 
            // StartDate
            // 
            this.StartDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle1.Format = "d";
            dataGridViewCellStyle1.NullValue = null;
            this.StartDate.DefaultCellStyle = dataGridViewCellStyle1;
            this.StartDate.HeaderText = "Start Date";
            this.StartDate.Name = "StartDate";
            this.StartDate.Width = 80;
            // 
            // EndDate
            // 
            this.EndDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.EndDate.HeaderText = "End Date";
            this.EndDate.Name = "EndDate";
            this.EndDate.Width = 77;
            // 
            // sessionView
            // 
            this.sessionView.AllowUserToAddRows = false;
            this.sessionView.AllowUserToDeleteRows = false;
            this.sessionView.AllowUserToResizeColumns = false;
            this.sessionView.AllowUserToResizeRows = false;
            this.sessionView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.sessionView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDSession,
            this.StartTime,
            this.EndTime,
            this.TankWin,
            this.TankLoss,
            this.DamageWin,
            this.DamageLoss,
            this.SupportWin,
            this.SupportLoss});
            this.sessionView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.sessionView.Location = new System.Drawing.Point(-2, 387);
            this.sessionView.Name = "sessionView";
            this.sessionView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.sessionView.Size = new System.Drawing.Size(1000, 380);
            this.sessionView.TabIndex = 1;
            // 
            // addNewSeasonButton
            // 
            this.addNewSeasonButton.Location = new System.Drawing.Point(7, 19);
            this.addNewSeasonButton.Name = "addNewSeasonButton";
            this.addNewSeasonButton.Size = new System.Drawing.Size(160, 65);
            this.addNewSeasonButton.TabIndex = 2;
            this.addNewSeasonButton.Text = "Add New Season";
            this.addNewSeasonButton.UseVisualStyleBackColor = true;
            this.addNewSeasonButton.Click += new System.EventHandler(this.addNewSeasonButton_Click);
            // 
            // editSeasonButton
            // 
            this.editSeasonButton.Location = new System.Drawing.Point(6, 90);
            this.editSeasonButton.Name = "editSeasonButton";
            this.editSeasonButton.Size = new System.Drawing.Size(160, 65);
            this.editSeasonButton.TabIndex = 3;
            this.editSeasonButton.Text = "Edit Season";
            this.editSeasonButton.UseVisualStyleBackColor = true;
            this.editSeasonButton.Click += new System.EventHandler(this.editSeasonButton_Click);
            // 
            // deleteSeasonButton
            // 
            this.deleteSeasonButton.Location = new System.Drawing.Point(6, 227);
            this.deleteSeasonButton.Name = "deleteSeasonButton";
            this.deleteSeasonButton.Size = new System.Drawing.Size(160, 65);
            this.deleteSeasonButton.TabIndex = 4;
            this.deleteSeasonButton.Text = "Delete Season";
            this.deleteSeasonButton.UseVisualStyleBackColor = true;
            this.deleteSeasonButton.Visible = false;
            this.deleteSeasonButton.Click += new System.EventHandler(this.deleteSeasonButton_Click);
            // 
            // addNewSessionButton
            // 
            this.addNewSessionButton.Location = new System.Drawing.Point(9, 19);
            this.addNewSessionButton.Name = "addNewSessionButton";
            this.addNewSessionButton.Size = new System.Drawing.Size(160, 65);
            this.addNewSessionButton.TabIndex = 5;
            this.addNewSessionButton.Text = "Add New Session";
            this.addNewSessionButton.UseVisualStyleBackColor = true;
            this.addNewSessionButton.Click += new System.EventHandler(this.addNewSessionButton_Click);
            // 
            // editSessionButton
            // 
            this.editSessionButton.Location = new System.Drawing.Point(9, 90);
            this.editSessionButton.Name = "editSessionButton";
            this.editSessionButton.Size = new System.Drawing.Size(160, 65);
            this.editSessionButton.TabIndex = 6;
            this.editSessionButton.Text = "Edit Session";
            this.editSessionButton.UseVisualStyleBackColor = true;
            this.editSessionButton.Click += new System.EventHandler(this.editSessionButton_Click);
            // 
            // deleteSessionButton
            // 
            this.deleteSessionButton.Location = new System.Drawing.Point(94, 329);
            this.deleteSessionButton.Name = "deleteSessionButton";
            this.deleteSessionButton.Size = new System.Drawing.Size(75, 45);
            this.deleteSessionButton.TabIndex = 7;
            this.deleteSessionButton.Text = "Delete Session";
            this.deleteSessionButton.UseVisualStyleBackColor = true;
            this.deleteSessionButton.Visible = false;
            this.deleteSessionButton.Click += new System.EventHandler(this.deleteSessionButton_Click);
            // 
            // saveSeasonButton
            // 
            this.saveSeasonButton.Location = new System.Drawing.Point(6, 298);
            this.saveSeasonButton.Name = "saveSeasonButton";
            this.saveSeasonButton.Size = new System.Drawing.Size(160, 65);
            this.saveSeasonButton.TabIndex = 8;
            this.saveSeasonButton.Text = "Save Season";
            this.saveSeasonButton.UseVisualStyleBackColor = true;
            this.saveSeasonButton.Visible = false;
            this.saveSeasonButton.Click += new System.EventHandler(this.saveSeasonButton_Click);
            // 
            // saveSessionButton
            // 
            this.saveSessionButton.Location = new System.Drawing.Point(6, 329);
            this.saveSessionButton.Name = "saveSessionButton";
            this.saveSessionButton.Size = new System.Drawing.Size(75, 45);
            this.saveSessionButton.TabIndex = 9;
            this.saveSessionButton.Text = "Save Session";
            this.saveSessionButton.UseVisualStyleBackColor = true;
            this.saveSessionButton.Visible = false;
            this.saveSessionButton.Click += new System.EventHandler(this.saveSessionButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.addNewSeasonButton);
            this.groupBox1.Controls.Add(this.deleteSeasonButton);
            this.groupBox1.Controls.Add(this.saveSeasonButton);
            this.groupBox1.Controls.Add(this.editSeasonButton);
            this.groupBox1.Location = new System.Drawing.Point(1005, 1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(175, 380);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Seasons";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.addNewSessionButton);
            this.groupBox2.Controls.Add(this.deleteSessionButton);
            this.groupBox2.Controls.Add(this.supportGroupBox);
            this.groupBox2.Controls.Add(this.saveSessionButton);
            this.groupBox2.Controls.Add(this.damageGroupBox);
            this.groupBox2.Controls.Add(this.editSessionButton);
            this.groupBox2.Controls.Add(this.tankGroupBox);
            this.groupBox2.Location = new System.Drawing.Point(1005, 387);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(175, 380);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Sessions";
            // 
            // supportGroupBox
            // 
            this.supportGroupBox.Controls.Add(this.supportLossButton);
            this.supportGroupBox.Controls.Add(this.supportWinButton);
            this.supportGroupBox.Location = new System.Drawing.Point(9, 278);
            this.supportGroupBox.Name = "supportGroupBox";
            this.supportGroupBox.Size = new System.Drawing.Size(160, 45);
            this.supportGroupBox.TabIndex = 18;
            this.supportGroupBox.TabStop = false;
            this.supportGroupBox.Text = "Support";
            this.supportGroupBox.Visible = false;
            // 
            // supportLossButton
            // 
            this.supportLossButton.Location = new System.Drawing.Point(85, 17);
            this.supportLossButton.Name = "supportLossButton";
            this.supportLossButton.Size = new System.Drawing.Size(55, 22);
            this.supportLossButton.TabIndex = 15;
            this.supportLossButton.Text = "Loss";
            this.supportLossButton.UseVisualStyleBackColor = true;
            // 
            // supportWinButton
            // 
            this.supportWinButton.Location = new System.Drawing.Point(17, 17);
            this.supportWinButton.Name = "supportWinButton";
            this.supportWinButton.Size = new System.Drawing.Size(55, 22);
            this.supportWinButton.TabIndex = 14;
            this.supportWinButton.Text = "Win";
            this.supportWinButton.UseVisualStyleBackColor = true;
            // 
            // damageGroupBox
            // 
            this.damageGroupBox.Controls.Add(this.dmgWinButton);
            this.damageGroupBox.Controls.Add(this.dmgLossButton);
            this.damageGroupBox.Location = new System.Drawing.Point(9, 220);
            this.damageGroupBox.Name = "damageGroupBox";
            this.damageGroupBox.Size = new System.Drawing.Size(160, 45);
            this.damageGroupBox.TabIndex = 17;
            this.damageGroupBox.TabStop = false;
            this.damageGroupBox.Text = "Damage";
            this.damageGroupBox.Visible = false;
            // 
            // dmgWinButton
            // 
            this.dmgWinButton.Location = new System.Drawing.Point(17, 17);
            this.dmgWinButton.Name = "dmgWinButton";
            this.dmgWinButton.Size = new System.Drawing.Size(55, 22);
            this.dmgWinButton.TabIndex = 11;
            this.dmgWinButton.Text = "Win";
            this.dmgWinButton.UseVisualStyleBackColor = true;
            // 
            // dmgLossButton
            // 
            this.dmgLossButton.Location = new System.Drawing.Point(85, 17);
            this.dmgLossButton.Name = "dmgLossButton";
            this.dmgLossButton.Size = new System.Drawing.Size(55, 22);
            this.dmgLossButton.TabIndex = 10;
            this.dmgLossButton.Text = "Loss";
            this.dmgLossButton.UseVisualStyleBackColor = true;
            // 
            // tankGroupBox
            // 
            this.tankGroupBox.Controls.Add(this.tankWinButton);
            this.tankGroupBox.Controls.Add(this.tankLossButton);
            this.tankGroupBox.Location = new System.Drawing.Point(9, 159);
            this.tankGroupBox.Name = "tankGroupBox";
            this.tankGroupBox.Size = new System.Drawing.Size(160, 45);
            this.tankGroupBox.TabIndex = 16;
            this.tankGroupBox.TabStop = false;
            this.tankGroupBox.Text = "Tank";
            this.tankGroupBox.Visible = false;
            // 
            // tankWinButton
            // 
            this.tankWinButton.Location = new System.Drawing.Point(17, 17);
            this.tankWinButton.Name = "tankWinButton";
            this.tankWinButton.Size = new System.Drawing.Size(55, 22);
            this.tankWinButton.TabIndex = 12;
            this.tankWinButton.Text = "Win";
            this.tankWinButton.UseVisualStyleBackColor = true;
            // 
            // tankLossButton
            // 
            this.tankLossButton.Location = new System.Drawing.Point(85, 17);
            this.tankLossButton.Name = "tankLossButton";
            this.tankLossButton.Size = new System.Drawing.Size(55, 22);
            this.tankLossButton.TabIndex = 13;
            this.tankLossButton.Text = "Loss";
            this.tankLossButton.UseVisualStyleBackColor = true;
            // 
            // IDSession
            // 
            this.IDSession.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.IDSession.HeaderText = "Session #";
            this.IDSession.Name = "IDSession";
            this.IDSession.Width = 79;
            // 
            // StartTime
            // 
            this.StartTime.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle2.Format = "g";
            dataGridViewCellStyle2.NullValue = null;
            this.StartTime.DefaultCellStyle = dataGridViewCellStyle2;
            this.StartTime.HeaderText = "Start Time";
            this.StartTime.Name = "StartTime";
            this.StartTime.Width = 80;
            // 
            // EndTime
            // 
            this.EndTime.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle3.Format = "g";
            dataGridViewCellStyle3.NullValue = null;
            this.EndTime.DefaultCellStyle = dataGridViewCellStyle3;
            this.EndTime.HeaderText = "End Time";
            this.EndTime.Name = "EndTime";
            this.EndTime.Width = 77;
            // 
            // TankWin
            // 
            this.TankWin.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.TankWin.HeaderText = "Tank Wins";
            this.TankWin.Name = "TankWin";
            this.TankWin.Width = 84;
            // 
            // TankLoss
            // 
            this.TankLoss.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.TankLoss.HeaderText = "Tank Losses";
            this.TankLoss.Name = "TankLoss";
            this.TankLoss.Width = 93;
            // 
            // DamageWin
            // 
            this.DamageWin.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.DamageWin.HeaderText = "Damage Wins";
            this.DamageWin.Name = "DamageWin";
            this.DamageWin.Width = 99;
            // 
            // DamageLoss
            // 
            this.DamageLoss.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.DamageLoss.HeaderText = "Damage Losses";
            this.DamageLoss.Name = "DamageLoss";
            this.DamageLoss.Width = 99;
            // 
            // SupportWin
            // 
            this.SupportWin.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.SupportWin.HeaderText = "Support Wins";
            this.SupportWin.Name = "SupportWin";
            this.SupportWin.Width = 88;
            // 
            // SupportLoss
            // 
            this.SupportLoss.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.SupportLoss.HeaderText = "Support Losses";
            this.SupportLoss.Name = "SupportLoss";
            this.SupportLoss.Width = 96;
            // 
            // MainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 769);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.sessionView);
            this.Controls.Add(this.seasonView);
            this.Name = "MainView";
            this.Text = "Ladder Tracker";
            ((System.ComponentModel.ISupportInitialize)(this.seasonView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sessionView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.supportGroupBox.ResumeLayout(false);
            this.damageGroupBox.ResumeLayout(false);
            this.tankGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView seasonView;
        private System.Windows.Forms.DataGridView sessionView;
        private System.Windows.Forms.Button addNewSeasonButton;
        private System.Windows.Forms.Button editSeasonButton;
        private System.Windows.Forms.Button deleteSeasonButton;
        private System.Windows.Forms.Button addNewSessionButton;
        private System.Windows.Forms.Button editSessionButton;
        private System.Windows.Forms.Button deleteSessionButton;
        private System.Windows.Forms.Button saveSeasonButton;
        private System.Windows.Forms.Button saveSessionButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn SeasonName;
        private System.Windows.Forms.DataGridViewTextBoxColumn StartDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn EndDate;
        private System.Windows.Forms.Button tankWinButton;
        private System.Windows.Forms.Button tankLossButton;
        private System.Windows.Forms.Button dmgWinButton;
        private System.Windows.Forms.Button dmgLossButton;
        private System.Windows.Forms.Button supportWinButton;
        private System.Windows.Forms.Button supportLossButton;
        private System.Windows.Forms.GroupBox tankGroupBox;
        private System.Windows.Forms.GroupBox damageGroupBox;
        private System.Windows.Forms.GroupBox supportGroupBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDSession;
        private System.Windows.Forms.DataGridViewTextBoxColumn StartTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn EndTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn TankWin;
        private System.Windows.Forms.DataGridViewTextBoxColumn TankLoss;
        private System.Windows.Forms.DataGridViewTextBoxColumn DamageWin;
        private System.Windows.Forms.DataGridViewTextBoxColumn DamageLoss;
        private System.Windows.Forms.DataGridViewTextBoxColumn SupportWin;
        private System.Windows.Forms.DataGridViewTextBoxColumn SupportLoss;
    }
}

