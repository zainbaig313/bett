namespace bett
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.label1 = new System.Windows.Forms.Label();
            this.lblBetForm3 = new System.Windows.Forms.Label();
            this.CbBettingAmountForm3 = new System.Windows.Forms.ComboBox();
            this.radioButtonSix = new System.Windows.Forms.RadioButton();
            this.radioButtonFour = new System.Windows.Forms.RadioButton();
            this.radioButtonOut = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.wmpForm3 = new AxWMPLib.AxWindowsMediaPlayer();
            this.labelCoinsForm3 = new System.Windows.Forms.Label();
            this.btnStartForm3 = new System.Windows.Forms.Button();
            this.btnPlayForm3 = new System.Windows.Forms.Button();
            this.resultForm3 = new System.Windows.Forms.Label();
            this.cricketTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.wmpForm3)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe Script", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(256, 413);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 44);
            this.label1.TabIndex = 1;
            this.label1.Text = "Select :";
            // 
            // lblBetForm3
            // 
            this.lblBetForm3.AutoSize = true;
            this.lblBetForm3.BackColor = System.Drawing.SystemColors.Control;
            this.lblBetForm3.Font = new System.Drawing.Font("Segoe Script", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBetForm3.Location = new System.Drawing.Point(9, 306);
            this.lblBetForm3.Name = "lblBetForm3";
            this.lblBetForm3.Size = new System.Drawing.Size(154, 34);
            this.lblBetForm3.TabIndex = 2;
            this.lblBetForm3.Text = "Bet amount:";
            // 
            // CbBettingAmountForm3
            // 
            this.CbBettingAmountForm3.Font = new System.Drawing.Font("Segoe Script", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CbBettingAmountForm3.FormattingEnabled = true;
            this.CbBettingAmountForm3.Items.AddRange(new object[] {
            "50",
            "100",
            "150"});
            this.CbBettingAmountForm3.Location = new System.Drawing.Point(178, 308);
            this.CbBettingAmountForm3.Name = "CbBettingAmountForm3";
            this.CbBettingAmountForm3.Size = new System.Drawing.Size(64, 35);
            this.CbBettingAmountForm3.TabIndex = 3;
            // 
            // radioButtonSix
            // 
            this.radioButtonSix.AutoSize = true;
            this.radioButtonSix.BackColor = System.Drawing.Color.Transparent;
            this.radioButtonSix.Font = new System.Drawing.Font("Segoe Script", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonSix.Location = new System.Drawing.Point(403, 411);
            this.radioButtonSix.Name = "radioButtonSix";
            this.radioButtonSix.Size = new System.Drawing.Size(86, 48);
            this.radioButtonSix.TabIndex = 4;
            this.radioButtonSix.TabStop = true;
            this.radioButtonSix.Text = "Six";
            this.radioButtonSix.UseVisualStyleBackColor = false;
            // 
            // radioButtonFour
            // 
            this.radioButtonFour.AutoSize = true;
            this.radioButtonFour.BackColor = System.Drawing.Color.Transparent;
            this.radioButtonFour.Font = new System.Drawing.Font("Segoe Script", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonFour.Location = new System.Drawing.Point(495, 415);
            this.radioButtonFour.Name = "radioButtonFour";
            this.radioButtonFour.Size = new System.Drawing.Size(104, 48);
            this.radioButtonFour.TabIndex = 5;
            this.radioButtonFour.TabStop = true;
            this.radioButtonFour.Text = "Four";
            this.radioButtonFour.UseVisualStyleBackColor = false;
            // 
            // radioButtonOut
            // 
            this.radioButtonOut.AutoSize = true;
            this.radioButtonOut.BackColor = System.Drawing.Color.Transparent;
            this.radioButtonOut.Font = new System.Drawing.Font("Segoe Script", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonOut.Location = new System.Drawing.Point(605, 413);
            this.radioButtonOut.Name = "radioButtonOut";
            this.radioButtonOut.Size = new System.Drawing.Size(92, 48);
            this.radioButtonOut.TabIndex = 6;
            this.radioButtonOut.TabStop = true;
            this.radioButtonOut.Text = "Out";
            this.radioButtonOut.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe Script", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(41)))), ((int)(((byte)(43)))));
            this.label3.Location = new System.Drawing.Point(371, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 44);
            this.label3.TabIndex = 7;
            this.label3.Text = "COINS";
            // 
            // wmpForm3
            // 
            this.wmpForm3.Enabled = true;
            this.wmpForm3.Location = new System.Drawing.Point(264, 56);
            this.wmpForm3.Name = "wmpForm3";
            this.wmpForm3.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("wmpForm3.OcxState")));
            this.wmpForm3.Size = new System.Drawing.Size(445, 336);
            this.wmpForm3.TabIndex = 0;
            // 
            // labelCoinsForm3
            // 
            this.labelCoinsForm3.AutoSize = true;
            this.labelCoinsForm3.BackColor = System.Drawing.Color.Transparent;
            this.labelCoinsForm3.Font = new System.Drawing.Font("Segoe Script", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCoinsForm3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(41)))), ((int)(((byte)(43)))));
            this.labelCoinsForm3.Location = new System.Drawing.Point(496, 9);
            this.labelCoinsForm3.Name = "labelCoinsForm3";
            this.labelCoinsForm3.Size = new System.Drawing.Size(119, 44);
            this.labelCoinsForm3.TabIndex = 8;
            this.labelCoinsForm3.Text = "00000";
            // 
            // btnStartForm3
            // 
            this.btnStartForm3.BackColor = System.Drawing.Color.PapayaWhip;
            this.btnStartForm3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStartForm3.Font = new System.Drawing.Font("Segoe Script", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStartForm3.ForeColor = System.Drawing.Color.Black;
            this.btnStartForm3.Location = new System.Drawing.Point(286, 486);
            this.btnStartForm3.Name = "btnStartForm3";
            this.btnStartForm3.Size = new System.Drawing.Size(172, 50);
            this.btnStartForm3.TabIndex = 11;
            this.btnStartForm3.Text = "Start";
            this.btnStartForm3.UseVisualStyleBackColor = false;
            this.btnStartForm3.Click += new System.EventHandler(this.btnStartForm3_Click);
            // 
            // btnPlayForm3
            // 
            this.btnPlayForm3.BackColor = System.Drawing.Color.PapayaWhip;
            this.btnPlayForm3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlayForm3.Font = new System.Drawing.Font("Segoe Script", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlayForm3.ForeColor = System.Drawing.Color.Black;
            this.btnPlayForm3.Location = new System.Drawing.Point(486, 486);
            this.btnPlayForm3.Name = "btnPlayForm3";
            this.btnPlayForm3.Size = new System.Drawing.Size(172, 50);
            this.btnPlayForm3.TabIndex = 12;
            this.btnPlayForm3.Text = "Play";
            this.btnPlayForm3.UseVisualStyleBackColor = false;
            this.btnPlayForm3.Click += new System.EventHandler(this.btnPlayForm3_Click);
            // 
            // resultForm3
            // 
            this.resultForm3.AutoSize = true;
            this.resultForm3.BackColor = System.Drawing.Color.Transparent;
            this.resultForm3.Font = new System.Drawing.Font("Segoe Script", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultForm3.Location = new System.Drawing.Point(48, 587);
            this.resultForm3.Name = "resultForm3";
            this.resultForm3.Size = new System.Drawing.Size(120, 44);
            this.resultForm3.TabIndex = 13;
            this.resultForm3.Text = "Result:";
            // 
            // cricketTimer
            // 
            this.cricketTimer.Tick += new System.EventHandler(this.cricketTimer_Tick);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(934, 661);
            this.Controls.Add(this.resultForm3);
            this.Controls.Add(this.btnPlayForm3);
            this.Controls.Add(this.btnStartForm3);
            this.Controls.Add(this.labelCoinsForm3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.radioButtonOut);
            this.Controls.Add(this.radioButtonFour);
            this.Controls.Add(this.radioButtonSix);
            this.Controls.Add(this.CbBettingAmountForm3);
            this.Controls.Add(this.lblBetForm3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.wmpForm3);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MinimizeBox = false;
            this.Name = "Form3";
            this.Text = "Cricket";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.wmpForm3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AxWMPLib.AxWindowsMediaPlayer wmpForm3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblBetForm3;
        private System.Windows.Forms.ComboBox CbBettingAmountForm3;
        private System.Windows.Forms.RadioButton radioButtonSix;
        private System.Windows.Forms.RadioButton radioButtonFour;
        private System.Windows.Forms.RadioButton radioButtonOut;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelCoinsForm3;
        private System.Windows.Forms.Button btnStartForm3;
        private System.Windows.Forms.Button btnPlayForm3;
        private System.Windows.Forms.Label resultForm3;
        private System.Windows.Forms.Timer cricketTimer;
    }
}