namespace Snake
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.myPicBox = new System.Windows.Forms.PictureBox();
            this.myLabel = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.myLabel2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.myPicBox)).BeginInit();
            this.SuspendLayout();
            // 
            // myPicBox
            // 
            this.myPicBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("myPicBox.BackgroundImage")));
            this.myPicBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.myPicBox.Location = new System.Drawing.Point(12, 12);
            this.myPicBox.Name = "myPicBox";
            this.myPicBox.Size = new System.Drawing.Size(928, 485);
            this.myPicBox.TabIndex = 0;
            this.myPicBox.TabStop = false;
            // 
            // myLabel
            // 
            this.myLabel.AutoSize = true;
            this.myLabel.BackColor = System.Drawing.SystemColors.Menu;
            this.myLabel.Cursor = System.Windows.Forms.Cursors.Default;
            this.myLabel.Font = new System.Drawing.Font("Algerian", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myLabel.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.myLabel.Location = new System.Drawing.Point(993, 53);
            this.myLabel.Name = "myLabel";
            this.myLabel.Size = new System.Drawing.Size(112, 35);
            this.myLabel.TabIndex = 1;
            this.myLabel.Text = "SCORE";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // myLabel2
            // 
            this.myLabel2.AllowDrop = true;
            this.myLabel2.AutoSize = true;
            this.myLabel2.BackColor = System.Drawing.SystemColors.Control;
            this.myLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.myLabel2.Location = new System.Drawing.Point(1030, 98);
            this.myLabel2.Name = "myLabel2";
            this.myLabel2.Size = new System.Drawing.Size(35, 37);
            this.myLabel2.TabIndex = 2;
            this.myLabel2.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1155, 507);
            this.Controls.Add(this.myLabel2);
            this.Controls.Add(this.myLabel);
            this.Controls.Add(this.myPicBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.myPicBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox myPicBox;
        private System.Windows.Forms.Label myLabel;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label myLabel2;
    }
}

