namespace WarThunderAssistant
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tasLabel = new System.Windows.Forms.Label();
            this.debugLabel1 = new System.Windows.Forms.Label();
            this.debugLabel2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tasLabel
            // 
            this.tasLabel.AutoSize = true;
            this.tasLabel.Location = new System.Drawing.Point(12, 9);
            this.tasLabel.Name = "tasLabel";
            this.tasLabel.Size = new System.Drawing.Size(38, 15);
            this.tasLabel.TabIndex = 0;
            this.tasLabel.Text = "label1";
            this.tasLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // debugLabel1
            // 
            this.debugLabel1.AutoSize = true;
            this.debugLabel1.Location = new System.Drawing.Point(12, 33);
            this.debugLabel1.Name = "debugLabel1";
            this.debugLabel1.Size = new System.Drawing.Size(38, 15);
            this.debugLabel1.TabIndex = 1;
            this.debugLabel1.Text = "label2";
            // 
            // debugLabel2
            // 
            this.debugLabel2.AutoSize = true;
            this.debugLabel2.Location = new System.Drawing.Point(12, 63);
            this.debugLabel2.Name = "debugLabel2";
            this.debugLabel2.Size = new System.Drawing.Size(38, 15);
            this.debugLabel2.TabIndex = 2;
            this.debugLabel2.Text = "label3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "label4";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.debugLabel2);
            this.Controls.Add(this.debugLabel1);
            this.Controls.Add(this.tasLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label tasLabel;
        private Label debugLabel1;
        private Label debugLabel2;
        private Label label4;
    }
}