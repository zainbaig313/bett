namespace bett
{
    partial class Football
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Football));
            this.label1 = new System.Windows.Forms.Label();
            this.radioButtonGoal = new System.Windows.Forms.RadioButton();
            this.radioButtonMiss = new System.Windows.Forms.RadioButton();
            this.lblBetFootball = new System.Windows.Forms.Label();
            this.CbBettingAmountFootball = new System.Windows.Forms.ComboBox();
            this.btnPlayFootball = new System.Windows.Forms.Button();
            this.resultFootball = new System.Windows.Forms.Label();
            this.wmpFootball = new AxWMPLib.AxWindowsMediaPlayer();
            this.label4 = new System.Windows.Forms.Label();
            this.labelCoinsFootball = new System.Windows.Forms.Label();
            this.footballTimer = new System.Windows.Forms.Timer(this.components);
            this.btnStartFootball = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.wmpFootball)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe Script", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(263, 422);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 44);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select:";
            // 
            // radioButtonGoal
            // 
            this.radioButtonGoal.AutoSize = true;
            this.radioButtonGoal.BackColor = System.Drawing.Color.Transparent;
            this.radioButtonGoal.Font = new System.Drawing.Font("Segoe Script", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonGoal.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.radioButtonGoal.Location = new System.Drawing.Point(390, 420);
            this.radioButtonGoal.Name = "radioButtonGoal";
            this.radioButtonGoal.Size = new System.Drawing.Size(102, 48);
            this.radioButtonGoal.TabIndex = 1;
            this.radioButtonGoal.TabStop = true;
            this.radioButtonGoal.Text = "Goal";
            this.radioButtonGoal.UseVisualStyleBackColor = false;
            // 
            // radioButtonMiss
            // 
            this.radioButtonMiss.AutoSize = true;
            this.radioButtonMiss.BackColor = System.Drawing.Color.Transparent;
            this.radioButtonMiss.Font = new System.Drawing.Font("Segoe Script", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonMiss.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.radioButtonMiss.Location = new System.Drawing.Point(525, 422);
            this.radioButtonMiss.Name = "radioButtonMiss";
            this.radioButtonMiss.Size = new System.Drawing.Size(98, 48);
            this.radioButtonMiss.TabIndex = 2;
            this.radioButtonMiss.Text = "Miss";
            this.radioButtonMiss.UseVisualStyleBackColor = false;
            // 
            // lblBetFootball
            // 
            this.lblBetFootball.AutoSize = true;
            this.lblBetFootball.BackColor = System.Drawing.Color.Transparent;
            this.lblBetFootball.Font = new System.Drawing.Font("Segoe Script", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBetFootball.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblBetFootball.Location = new System.Drawing.Point(12, 275);
            this.lblBetFootball.Name = "lblBetFootball";
            this.lblBetFootball.Size = new System.Drawing.Size(154, 34);
            this.lblBetFootball.TabIndex = 3;
            this.lblBetFootball.Text = "Bet amount:";
            // 
            // CbBettingAmountFootball
            // 
            this.CbBettingAmountFootball.Font = new System.Drawing.Font("Segoe Print", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CbBettingAmountFootball.FormattingEnabled = true;
            this.CbBettingAmountFootball.Items.AddRange(new object[] {
            "50",
            "100",
            "150"});
            this.CbBettingAmountFootball.Location = new System.Drawing.Point(172, 276);
            this.CbBettingAmountFootball.Name = "CbBettingAmountFootball";
            this.CbBettingAmountFootball.Size = new System.Drawing.Size(76, 36);
            this.CbBettingAmountFootball.TabIndex = 4;
            // 
            // btnPlayFootball
            // 
            this.btnPlayFootball.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(129)))), ((int)(((byte)(55)))));
            this.btnPlayFootball.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlayFootball.Font = new System.Drawing.Font("Segoe Print", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlayFootball.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnPlayFootball.Location = new System.Drawing.Point(510, 508);
            this.btnPlayFootball.Name = "btnPlayFootball";
            this.btnPlayFootball.Size = new System.Drawing.Size(132, 54);
            this.btnPlayFootball.TabIndex = 5;
            this.btnPlayFootball.Text = "Play";
            this.btnPlayFootball.UseVisualStyleBackColor = false;
            this.btnPlayFootball.Click += new System.EventHandler(this.btnPlayFootball_Click);
            // 
            // resultFootball
            // 
            this.resultFootball.AutoSize = true;
            this.resultFootball.BackColor = System.Drawing.Color.Transparent;
            this.resultFootball.Font = new System.Drawing.Font("Segoe Script", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultFootball.ForeColor = System.Drawing.Color.White;
            this.resultFootball.Location = new System.Drawing.Point(73, 631);
            this.resultFootball.Name = "resultFootball";
            this.resultFootball.Size = new System.Drawing.Size(120, 44);
            this.resultFootball.TabIndex = 6;
            this.resultFootball.Text = "Result:";
            // 
            // wmpFootball
            // 
            this.wmpFootball.Enabled = true;
            this.wmpFootball.Location = new System.Drawing.Point(271, 83);
            this.wmpFootball.Name = "wmpFootball";
            this.wmpFootball.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("wmpFootball.OcxState")));
            this.wmpFootball.Size = new System.Drawing.Size(453, 314);
            this.wmpFootball.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe Script", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(232, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 44);
            this.label4.TabIndex = 8;
            this.label4.Text = "COINS";
            // 
            // labelCoinsFootball
            // 
            this.labelCoinsFootball.AutoSize = true;
            this.labelCoinsFootball.BackColor = System.Drawing.Color.Transparent;
            this.labelCoinsFootball.Font = new System.Drawing.Font("Segoe Script", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCoinsFootball.ForeColor = System.Drawing.Color.White;
            this.labelCoinsFootball.Location = new System.Drawing.Point(346, 9);
            this.labelCoinsFootball.Name = "labelCoinsFootball";
            this.labelCoinsFootball.Size = new System.Drawing.Size(119, 44);
            this.labelCoinsFootball.TabIndex = 9;
            this.labelCoinsFootball.Text = "00000";
            // 
            // footballTimer
            // 
            this.footballTimer.Tick += new System.EventHandler(this.footballTimer_Tick);
            // 
            // btnStartFootball
            // 
            this.btnStartFootball.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(129)))), ((int)(((byte)(55)))));
            this.btnStartFootball.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStartFootball.Font = new System.Drawing.Font("Segoe Script", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStartFootball.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnStartFootball.Location = new System.Drawing.Point(289, 508);
            this.btnStartFootball.Name = "btnStartFootball";
            this.btnStartFootball.Size = new System.Drawing.Size(132, 54);
            this.btnStartFootball.TabIndex = 10;
            this.btnStartFootball.Text = "Start";
            this.btnStartFootball.UseVisualStyleBackColor = false;
            this.btnStartFootball.Click += new System.EventHandler(this.btnStartFootball_Click);
            // 
            // Football
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::bett.Properties.Resources.It_s_Game_Time_Instagram_Story__700_x_500_px_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(934, 711);
            this.Controls.Add(this.btnStartFootball);
            this.Controls.Add(this.labelCoinsFootball);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.wmpFootball);
            this.Controls.Add(this.resultFootball);
            this.Controls.Add(this.btnPlayFootball);
            this.Controls.Add(this.CbBettingAmountFootball);
            this.Controls.Add(this.lblBetFootball);
            this.Controls.Add(this.radioButtonMiss);
            this.Controls.Add(this.radioButtonGoal);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Football";
            this.Text = "Football";
            this.Load += new System.EventHandler(this.Football_Load);
            ((System.ComponentModel.ISupportInitialize)(this.wmpFootball)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radioButtonGoal;
        private System.Windows.Forms.RadioButton radioButtonMiss;
        private System.Windows.Forms.Label lblBetFootball;
        private System.Windows.Forms.ComboBox CbBettingAmountFootball;
        private System.Windows.Forms.Button btnPlayFootball;
        private System.Windows.Forms.Label resultFootball;
        private AxWMPLib.AxWindowsMediaPlayer wmpFootball;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelCoinsFootball;
        private System.Windows.Forms.Timer footballTimer;
        private System.Windows.Forms.Button btnStartFootball;
    }
}