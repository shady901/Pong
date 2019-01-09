namespace Pong
{
    partial class Frm_Pong
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
            this.pb_player1 = new System.Windows.Forms.PictureBox();
            this.pb_player2 = new System.Windows.Forms.PictureBox();
            this.Update = new System.Windows.Forms.Timer(this.components);
            this.lbl_player1 = new System.Windows.Forms.Label();
            this.lbl_player2 = new System.Windows.Forms.Label();
            this.lbl_Round = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pb_player1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_player2)).BeginInit();
            this.SuspendLayout();
            // 
            // pb_player1
            // 
            this.pb_player1.BackColor = System.Drawing.SystemColors.Control;
            this.pb_player1.Location = new System.Drawing.Point(12, 227);
            this.pb_player1.Name = "pb_player1";
            this.pb_player1.Size = new System.Drawing.Size(15, 180);
            this.pb_player1.TabIndex = 0;
            this.pb_player1.TabStop = false;
            // 
            // pb_player2
            // 
            this.pb_player2.BackColor = System.Drawing.SystemColors.Control;
            this.pb_player2.Location = new System.Drawing.Point(757, 227);
            this.pb_player2.Name = "pb_player2";
            this.pb_player2.Size = new System.Drawing.Size(15, 180);
            this.pb_player2.TabIndex = 1;
            this.pb_player2.TabStop = false;
            // 
            // Update
            // 
            this.Update.Enabled = true;
            this.Update.Interval = 50;
            this.Update.Tick += new System.EventHandler(this.Update_Tick);
            // 
            // lbl_player1
            // 
            this.lbl_player1.AutoSize = true;
            this.lbl_player1.ForeColor = System.Drawing.SystemColors.Control;
            this.lbl_player1.Location = new System.Drawing.Point(31, 13);
            this.lbl_player1.Name = "lbl_player1";
            this.lbl_player1.Size = new System.Drawing.Size(35, 13);
            this.lbl_player1.TabIndex = 2;
            this.lbl_player1.Text = "label1";
            // 
            // lbl_player2
            // 
            this.lbl_player2.AutoSize = true;
            this.lbl_player2.ForeColor = System.Drawing.SystemColors.Control;
            this.lbl_player2.Location = new System.Drawing.Point(698, 13);
            this.lbl_player2.Name = "lbl_player2";
            this.lbl_player2.Size = new System.Drawing.Size(35, 13);
            this.lbl_player2.TabIndex = 3;
            this.lbl_player2.Text = "label2";
            // 
            // lbl_Round
            // 
            this.lbl_Round.AutoSize = true;
            this.lbl_Round.ForeColor = System.Drawing.SystemColors.Control;
            this.lbl_Round.Location = new System.Drawing.Point(359, 13);
            this.lbl_Round.Name = "lbl_Round";
            this.lbl_Round.Size = new System.Drawing.Size(35, 13);
            this.lbl_Round.TabIndex = 4;
            this.lbl_Round.Text = "label1";
            // 
            // Frm_Pong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(784, 661);
            this.Controls.Add(this.lbl_Round);
            this.Controls.Add(this.lbl_player2);
            this.Controls.Add(this.lbl_player1);
            this.Controls.Add(this.pb_player2);
            this.Controls.Add(this.pb_player1);
            this.MaximizeBox = false;
            this.Name = "Frm_Pong";
            this.Text = "Pong";
            this.Load += new System.EventHandler(this.Frm_Pong_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Frm_Pong_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pb_player1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_player2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pb_player1;
        private System.Windows.Forms.PictureBox pb_player2;
        private new System.Windows.Forms.Timer Update;
        private System.Windows.Forms.Label lbl_player1;
        private System.Windows.Forms.Label lbl_player2;
        private System.Windows.Forms.Label lbl_Round;
    }
}

