namespace Coin_Counter
{
    partial class MoneyCreditCounterV5
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MoneyCreditCounterV5));
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.btn_TwoPound = new System.Windows.Forms.PictureBox();
            this.label_TwoPoundTotal = new System.Windows.Forms.Label();
            this.label_TwoPoundSymbol = new System.Windows.Forms.Label();
            this.groupBox_Coins = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_TwoPound)).BeginInit();
            this.groupBox_Coins.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox7
            // 
            this.pictureBox7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox7.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox7.Image")));
            this.pictureBox7.Location = new System.Drawing.Point(493, 396);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(0, 0);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox7.TabIndex = 19;
            this.pictureBox7.TabStop = false;
            // 
            // btn_TwoPound
            // 
            this.btn_TwoPound.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_TwoPound.Image = ((System.Drawing.Image)(resources.GetObject("btn_TwoPound.Image")));
            this.btn_TwoPound.Location = new System.Drawing.Point(28, 19);
            this.btn_TwoPound.Name = "btn_TwoPound";
            this.btn_TwoPound.Size = new System.Drawing.Size(109, 105);
            this.btn_TwoPound.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btn_TwoPound.TabIndex = 2;
            this.btn_TwoPound.TabStop = false;
            this.btn_TwoPound.Click += new System.EventHandler(this.btn_TwoPound_Click);
            // 
            // label_TwoPoundTotal
            // 
            this.label_TwoPoundTotal.AutoSize = true;
            this.label_TwoPoundTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label_TwoPoundTotal.Location = new System.Drawing.Point(161, 60);
            this.label_TwoPoundTotal.Name = "label_TwoPoundTotal";
            this.label_TwoPoundTotal.Size = new System.Drawing.Size(24, 26);
            this.label_TwoPoundTotal.TabIndex = 39;
            this.label_TwoPoundTotal.Text = "0";
            // 
            // label_TwoPoundSymbol
            // 
            this.label_TwoPoundSymbol.AutoSize = true;
            this.label_TwoPoundSymbol.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label_TwoPoundSymbol.Location = new System.Drawing.Point(143, 60);
            this.label_TwoPoundSymbol.Name = "label_TwoPoundSymbol";
            this.label_TwoPoundSymbol.Size = new System.Drawing.Size(24, 26);
            this.label_TwoPoundSymbol.TabIndex = 40;
            this.label_TwoPoundSymbol.Text = "£";
            // 
            // groupBox_Coins
            // 
            this.groupBox_Coins.Controls.Add(this.label_TwoPoundSymbol);
            this.groupBox_Coins.Controls.Add(this.label_TwoPoundTotal);
            this.groupBox_Coins.Controls.Add(this.btn_TwoPound);
            this.groupBox_Coins.Location = new System.Drawing.Point(7, 21);
            this.groupBox_Coins.Name = "groupBox_Coins";
            this.groupBox_Coins.Size = new System.Drawing.Size(447, 534);
            this.groupBox_Coins.TabIndex = 70;
            this.groupBox_Coins.TabStop = false;
            this.groupBox_Coins.Text = "Coins";
            // 
            // MoneyCreditCounterV5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(654, 659);
            this.Controls.Add(this.groupBox_Coins);
            this.Controls.Add(this.pictureBox7);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MoneyCreditCounterV5";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MoneyCreditCounter V5";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_TwoPound)).EndInit();
            this.groupBox_Coins.ResumeLayout(false);
            this.groupBox_Coins.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox btn_TwoPound;
        private System.Windows.Forms.Label label_TwoPoundTotal;
        private System.Windows.Forms.Label label_TwoPoundSymbol;
        private System.Windows.Forms.GroupBox groupBox_Coins;
    }
}

