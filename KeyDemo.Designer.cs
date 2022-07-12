
namespace KeyDemo
{
    partial class KeyDemo
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
            this.charLabel = new System.Windows.Forms.Label();
            this.keyInfoLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // charLabel
            // 
            this.charLabel.AutoSize = true;
            this.charLabel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.charLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.charLabel.Location = new System.Drawing.Point(70, 42);
            this.charLabel.MaximumSize = new System.Drawing.Size(150, 20);
            this.charLabel.MinimumSize = new System.Drawing.Size(150, 20);
            this.charLabel.Name = "charLabel";
            this.charLabel.Size = new System.Drawing.Size(150, 20);
            this.charLabel.TabIndex = 0;
            //this.charLabel.Click += new System.EventHandler(this.charLabel_Click);
            // 
            // keyInfoLabel
            // 
            this.keyInfoLabel.AutoSize = true;
            this.keyInfoLabel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.keyInfoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.keyInfoLabel.Location = new System.Drawing.Point(70, 144);
            this.keyInfoLabel.MaximumSize = new System.Drawing.Size(150, 150);
            this.keyInfoLabel.MinimumSize = new System.Drawing.Size(150, 150);
            this.keyInfoLabel.Name = "keyInfoLabel";
            this.keyInfoLabel.Size = new System.Drawing.Size(150, 150);
            this.keyInfoLabel.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.keyInfoLabel);
            this.Controls.Add(this.charLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label charLabel;
        private System.Windows.Forms.Label keyInfoLabel;
    }
}

