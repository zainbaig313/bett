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
            this.lnlBet = new System.Windows.Forms.Label();
            this.CbBettingAmountFootball = new System.Windows.Forms.ComboBox();
            this.btnPlayFootball = new System.Windows.Forms.Button();
            this.result = new System.Windows.Forms.Label();
            this.wmpFootball = new AxWMPLib.AxWindowsMediaPlayer();
            this.label4 = new System.Windows.Forms.Label();
            this.labelCoinsFootball = new System.Windows.Forms.Label();
            this.footballTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.wmpFootball)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(252, 263);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select:";
            // 
            // radioButtonGoal
            // 
            this.radioButtonGoal.AutoSize = true;
            this.radioButtonGoal.BackColor = System.Drawing.Color.Transparent;
            this.radioButtonGoal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonGoal.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.radioButtonGoal.Location = new System.Drawing.Point(341, 261);
            this.radioButtonGoal.Name = "radioButtonGoal";
            this.radioButtonGoal.Size = new System.Drawing.Size(54, 20);
            this.radioButtonGoal.TabIndex = 1;
            this.radioButtonGoal.TabStop = true;
            this.radioButtonGoal.Text = "Goal";
            this.radioButtonGoal.UseVisualStyleBackColor = false;
            // 
            // radioButtonMiss
            // 
            this.radioButtonMiss.AutoSize = true;
            this.radioButtonMiss.BackColor = System.Drawing.Color.Transparent;
            this.radioButtonMiss.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonMiss.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.radioButtonMiss.Location = new System.Drawing.Point(412, 261);
            this.radioButtonMiss.Name = "radioButtonMiss";
            this.radioButtonMiss.Size = new System.Drawing.Size(53, 20);
            this.radioButtonMiss.TabIndex = 2;
            this.radioButtonMiss.TabStop = true;
            this.radioButtonMiss.Text = "Miss";
            this.radioButtonMiss.UseVisualStyleBackColor = false;
            // 
            // lnlBet
            // 
            this.lnlBet.AutoSize = true;
            this.lnlBet.BackColor = System.Drawing.Color.Transparent;
            this.lnlBet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnlBet.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lnlBet.Location = new System.Drawing.Point(35, 204);
            this.lnlBet.Name = "lnlBet";
            this.lnlBet.Size = new System.Drawing.Size(77, 16);
            this.lnlBet.TabIndex = 3;
            this.lnlBet.Text = "Bet amount:";
            // 
            // CbBettingAmountFootball
            // 
            this.CbBettingAmountFootball.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CbBettingAmountFootball.FormattingEnabled = true;
            this.CbBettingAmountFootball.Items.AddRange(new object[] {
            "50",
            "100",
            "150"});
            this.CbBettingAmountFootball.Location = new System.Drawing.Point(131, 201);
            this.CbBettingAmountFootball.Name = "CbBettingAmountFootball";
            this.CbBettingAmountFootball.Size = new System.Drawing.Size(62, 24);
            this.CbBettingAmountFootball.TabIndex = 4;
            // 
            // btnPlayFootball
            // 
            this.btnPlayFootball.BackColor = System.Drawing.Color.Black;
            this.btnPlayFootball.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlayFootball.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlayFootball.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnPlayFootball.Location = new System.Drawing.Point(39, 294);
            this.btnPlayFootball.Name = "btnPlayFootball";
            this.btnPlayFootball.Size = new System.Drawing.Size(108, 31);
            this.btnPlayFootball.TabIndex = 5;
            this.btnPlayFootball.Text = "Play";
            this.btnPlayFootball.UseVisualStyleBackColor = false;
            this.btnPlayFootball.Click += new System.EventHandler(this.btnPlayFootball_Click);
            // 
            // result
            // 
            this.result.AutoSize = true;
            this.result.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.result.Location = new System.Drawing.Point(45, 358);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(67, 24);
            this.result.TabIndex = 6;
            this.result.Text = "Result:";
            // 
            // wmpFootball
            // 
            this.wmpFootball.Enabled = true;
            this.wmpFootball.Location = new System.Drawing.Point(230, 47);
            this.wmpFootball.Name = "wmpFootball";
            this.wmpFootball.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("wmpFootball.OcxState")));
            this.wmpFootball.Size = new System.Drawing.Size(248, 208);
            this.wmpFootball.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(150, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 27);
            this.label4.TabIndex = 8;
            this.label4.Text = "COINS";
            // 
            // labelCoinsFootball
            // 
            this.labelCoinsFootball.AutoSize = true;
            this.labelCoinsFootball.BackColor = System.Drawing.Color.Transparent;
            this.labelCoinsFootball.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCoinsFootball.ForeColor = System.Drawing.Color.White;
            this.labelCoinsFootball.Location = new System.Drawing.Point(250, 9);
            this.labelCoinsFootball.Name = "labelCoinsFootball";
            this.labelCoinsFootball.Size = new System.Drawing.Size(77, 27);
            this.labelCoinsFootball.TabIndex = 9;
            this.labelCoinsFootball.Text = "00000";
            // 
            // footballTimer
            // 
            this.footballTimer.Tick += new System.EventHandler(this.footballTimer_Tick);
            // 
            // Football
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::bett.Properties.Resources.It_s_Game_Time_Instagram_Story__700_x_500_px_;
            this.ClientSize = new System.Drawing.Size(703, 496);
            this.Controls.Add(this.labelCoinsFootball);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.wmpFootball);
            this.Controls.Add(this.result);
            this.Controls.Add(this.btnPlayFootball);
            this.Controls.Add(this.CbBettingAmountFootball);
            this.Controls.Add(this.lnlBet);
            this.Controls.Add(this.radioButtonMiss);
            this.Controls.Add(this.radioButtonGoal);
            this.Controls.Add(this.label1);
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
        private System.Windows.Forms.Label lnlBet;
        private System.Windows.Forms.ComboBox CbBettingAmountFootball;
        private System.Windows.Forms.Button btnPlayFootball;
        private System.Windows.Forms.Label result;
        private AxWMPLib.AxWindowsMediaPlayer wmpFootball;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelCoinsFootball;
        private System.Windows.Forms.Timer footballTimer;
    }
}