namespace BlackJackGame
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnNewGame = new System.Windows.Forms.Button();
            this.btnDeal = new System.Windows.Forms.Button();
            this.btnStand = new System.Windows.Forms.Button();
            this.btnHit = new System.Windows.Forms.Button();
            this.pbPlayer1 = new System.Windows.Forms.PictureBox();
            this.pbPlayer5 = new System.Windows.Forms.PictureBox();
            this.pbPlayer4 = new System.Windows.Forms.PictureBox();
            this.pbPlayer3 = new System.Windows.Forms.PictureBox();
            this.pbPlayer2 = new System.Windows.Forms.PictureBox();
            this.pbDealer5 = new System.Windows.Forms.PictureBox();
            this.pbDealer4 = new System.Windows.Forms.PictureBox();
            this.pbDealer3 = new System.Windows.Forms.PictureBox();
            this.pbDealer2 = new System.Windows.Forms.PictureBox();
            this.pbDealer1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPlayerScore = new System.Windows.Forms.TextBox();
            this.txtDealerScore = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPlayer1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPlayer5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPlayer4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPlayer3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPlayer2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDealer5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDealer4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDealer3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDealer2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDealer1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnNewGame);
            this.panel1.Controls.Add(this.btnDeal);
            this.panel1.Controls.Add(this.btnStand);
            this.panel1.Controls.Add(this.btnHit);
            this.panel1.Location = new System.Drawing.Point(41, 438);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(404, 138);
            this.panel1.TabIndex = 0;
            // 
            // btnNewGame
            // 
            this.btnNewGame.Location = new System.Drawing.Point(245, 81);
            this.btnNewGame.Margin = new System.Windows.Forms.Padding(4);
            this.btnNewGame.Name = "btnNewGame";
            this.btnNewGame.Size = new System.Drawing.Size(76, 42);
            this.btnNewGame.TabIndex = 3;
            this.btnNewGame.Text = "New Game";
            this.btnNewGame.UseVisualStyleBackColor = true;
            this.btnNewGame.Click += new System.EventHandler(this.btnNewGame_Click);
            // 
            // btnDeal
            // 
            this.btnDeal.Location = new System.Drawing.Point(104, 81);
            this.btnDeal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDeal.Name = "btnDeal";
            this.btnDeal.Size = new System.Drawing.Size(75, 42);
            this.btnDeal.TabIndex = 2;
            this.btnDeal.Text = "Deal!";
            this.btnDeal.UseVisualStyleBackColor = true;
            this.btnDeal.Click += new System.EventHandler(this.btnDeal_Click);
            // 
            // btnStand
            // 
            this.btnStand.Enabled = false;
            this.btnStand.Location = new System.Drawing.Point(245, 25);
            this.btnStand.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnStand.Name = "btnStand";
            this.btnStand.Size = new System.Drawing.Size(75, 34);
            this.btnStand.TabIndex = 1;
            this.btnStand.Text = "Stand!";
            this.btnStand.UseVisualStyleBackColor = true;
            this.btnStand.Click += new System.EventHandler(this.btnStand_Click);
            // 
            // btnHit
            // 
            this.btnHit.Enabled = false;
            this.btnHit.Location = new System.Drawing.Point(104, 25);
            this.btnHit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnHit.Name = "btnHit";
            this.btnHit.Size = new System.Drawing.Size(75, 34);
            this.btnHit.TabIndex = 0;
            this.btnHit.Text = "Hit!";
            this.btnHit.UseVisualStyleBackColor = true;
            this.btnHit.Click += new System.EventHandler(this.btnHit_Click);
            // 
            // pbPlayer1
            // 
            this.pbPlayer1.Location = new System.Drawing.Point(41, 286);
            this.pbPlayer1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbPlayer1.Name = "pbPlayer1";
            this.pbPlayer1.Size = new System.Drawing.Size(76, 114);
            this.pbPlayer1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPlayer1.TabIndex = 1;
            this.pbPlayer1.TabStop = false;
            // 
            // pbPlayer5
            // 
            this.pbPlayer5.Location = new System.Drawing.Point(369, 286);
            this.pbPlayer5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbPlayer5.Name = "pbPlayer5";
            this.pbPlayer5.Size = new System.Drawing.Size(76, 114);
            this.pbPlayer5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPlayer5.TabIndex = 2;
            this.pbPlayer5.TabStop = false;
            this.pbPlayer5.Visible = false;
            // 
            // pbPlayer4
            // 
            this.pbPlayer4.Location = new System.Drawing.Point(287, 286);
            this.pbPlayer4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbPlayer4.Name = "pbPlayer4";
            this.pbPlayer4.Size = new System.Drawing.Size(76, 114);
            this.pbPlayer4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPlayer4.TabIndex = 3;
            this.pbPlayer4.TabStop = false;
            this.pbPlayer4.Visible = false;
            // 
            // pbPlayer3
            // 
            this.pbPlayer3.Location = new System.Drawing.Point(205, 286);
            this.pbPlayer3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbPlayer3.Name = "pbPlayer3";
            this.pbPlayer3.Size = new System.Drawing.Size(76, 114);
            this.pbPlayer3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPlayer3.TabIndex = 4;
            this.pbPlayer3.TabStop = false;
            this.pbPlayer3.Visible = false;
            // 
            // pbPlayer2
            // 
            this.pbPlayer2.Location = new System.Drawing.Point(123, 286);
            this.pbPlayer2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbPlayer2.Name = "pbPlayer2";
            this.pbPlayer2.Size = new System.Drawing.Size(76, 114);
            this.pbPlayer2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPlayer2.TabIndex = 5;
            this.pbPlayer2.TabStop = false;
            // 
            // pbDealer5
            // 
            this.pbDealer5.Location = new System.Drawing.Point(369, 69);
            this.pbDealer5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbDealer5.Name = "pbDealer5";
            this.pbDealer5.Size = new System.Drawing.Size(76, 114);
            this.pbDealer5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbDealer5.TabIndex = 6;
            this.pbDealer5.TabStop = false;
            this.pbDealer5.Visible = false;
            // 
            // pbDealer4
            // 
            this.pbDealer4.Location = new System.Drawing.Point(287, 69);
            this.pbDealer4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbDealer4.Name = "pbDealer4";
            this.pbDealer4.Size = new System.Drawing.Size(76, 114);
            this.pbDealer4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbDealer4.TabIndex = 7;
            this.pbDealer4.TabStop = false;
            this.pbDealer4.Visible = false;
            // 
            // pbDealer3
            // 
            this.pbDealer3.Location = new System.Drawing.Point(205, 69);
            this.pbDealer3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbDealer3.Name = "pbDealer3";
            this.pbDealer3.Size = new System.Drawing.Size(76, 114);
            this.pbDealer3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbDealer3.TabIndex = 8;
            this.pbDealer3.TabStop = false;
            this.pbDealer3.Visible = false;
            // 
            // pbDealer2
            // 
            this.pbDealer2.Location = new System.Drawing.Point(123, 69);
            this.pbDealer2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbDealer2.Name = "pbDealer2";
            this.pbDealer2.Size = new System.Drawing.Size(76, 114);
            this.pbDealer2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbDealer2.TabIndex = 9;
            this.pbDealer2.TabStop = false;
            // 
            // pbDealer1
            // 
            this.pbDealer1.Location = new System.Drawing.Point(41, 69);
            this.pbDealer1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbDealer1.Name = "pbDealer1";
            this.pbDealer1.Size = new System.Drawing.Size(76, 114);
            this.pbDealer1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbDealer1.TabIndex = 10;
            this.pbDealer1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(586, 131);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 17);
            this.label1.TabIndex = 11;
            this.label1.Text = "Dealer Score";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(586, 321);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 17);
            this.label2.TabIndex = 12;
            this.label2.Text = "Player Score";
            // 
            // txtPlayerScore
            // 
            this.txtPlayerScore.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPlayerScore.Location = new System.Drawing.Point(588, 286);
            this.txtPlayerScore.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPlayerScore.Name = "txtPlayerScore";
            this.txtPlayerScore.ReadOnly = true;
            this.txtPlayerScore.Size = new System.Drawing.Size(87, 33);
            this.txtPlayerScore.TabIndex = 13;
            this.txtPlayerScore.Text = "0";
            this.txtPlayerScore.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtDealerScore
            // 
            this.txtDealerScore.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDealerScore.Location = new System.Drawing.Point(587, 150);
            this.txtDealerScore.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDealerScore.Name = "txtDealerScore";
            this.txtDealerScore.ReadOnly = true;
            this.txtDealerScore.Size = new System.Drawing.Size(87, 33);
            this.txtDealerScore.TabIndex = 14;
            this.txtDealerScore.Text = "0";
            this.txtDealerScore.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Monotype Corsiva", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(103, 187);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(294, 22);
            this.label3.TabIndex = 15;
            this.label3.Text = "\"Dealer must hit up to 16 and stand on 17\"";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OliveDrab;
            this.ClientSize = new System.Drawing.Size(771, 590);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtDealerScore);
            this.Controls.Add(this.txtPlayerScore);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pbDealer1);
            this.Controls.Add(this.pbDealer2);
            this.Controls.Add(this.pbDealer3);
            this.Controls.Add(this.pbDealer4);
            this.Controls.Add(this.pbDealer5);
            this.Controls.Add(this.pbPlayer2);
            this.Controls.Add(this.pbPlayer3);
            this.Controls.Add(this.pbPlayer4);
            this.Controls.Add(this.pbPlayer5);
            this.Controls.Add(this.pbPlayer1);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Blackjack";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbPlayer1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPlayer5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPlayer4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPlayer3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPlayer2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDealer5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDealer4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDealer3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDealer2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDealer1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnDeal;
        private System.Windows.Forms.Button btnStand;
        private System.Windows.Forms.Button btnHit;
        private System.Windows.Forms.PictureBox pbPlayer1;
        private System.Windows.Forms.PictureBox pbPlayer5;
        private System.Windows.Forms.PictureBox pbPlayer4;
        private System.Windows.Forms.PictureBox pbPlayer3;
        private System.Windows.Forms.PictureBox pbPlayer2;
        private System.Windows.Forms.PictureBox pbDealer5;
        private System.Windows.Forms.PictureBox pbDealer4;
        private System.Windows.Forms.PictureBox pbDealer3;
        private System.Windows.Forms.PictureBox pbDealer2;
        private System.Windows.Forms.PictureBox pbDealer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPlayerScore;
        private System.Windows.Forms.TextBox txtDealerScore;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnNewGame;
    }
}

