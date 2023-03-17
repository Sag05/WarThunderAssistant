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
            this.iasLabel = new System.Windows.Forms.Label();
            this.fuelLeftLabel = new System.Windows.Forms.Label();
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
            // 
            // iasLabel
            // 
            this.iasLabel.AutoSize = true;
            this.iasLabel.Location = new System.Drawing.Point(12, 33);
            this.iasLabel.Name = "iasLabel";
            this.iasLabel.Size = new System.Drawing.Size(38, 15);
            this.iasLabel.TabIndex = 1;
            this.iasLabel.Text = "label2";
            // 
            // fuelLeftLabel
            // 
            this.fuelLeftLabel.AutoSize = true;
            this.fuelLeftLabel.Location = new System.Drawing.Point(12, 63);
            this.fuelLeftLabel.Name = "fuelLeftLabel";
            this.fuelLeftLabel.Size = new System.Drawing.Size(38, 15);
            this.fuelLeftLabel.TabIndex = 2;
            this.fuelLeftLabel.Text = "label3";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.iasLabel);
            this.Controls.Add(this.fuelLeftLabel);
            this.Controls.Add(this.tasLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label tasLabel;
        private Label iasLabel;
        private Label fuelLeftLabel;
    }
}