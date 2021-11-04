
namespace Task2
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
            this.lblMap = new System.Windows.Forms.Label();
            this.lblCharacterStats = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblMap
            // 
            this.lblMap.AutoSize = true;
            this.lblMap.Location = new System.Drawing.Point(227, 142);
            this.lblMap.Name = "lblMap";
            this.lblMap.Size = new System.Drawing.Size(38, 15);
            this.lblMap.TabIndex = 0;
            this.lblMap.Text = "label1";
            // 
            // lblCharacterStats
            // 
            this.lblCharacterStats.AutoSize = true;
            this.lblCharacterStats.Location = new System.Drawing.Point(603, 89);
            this.lblCharacterStats.Name = "lblCharacterStats";
            this.lblCharacterStats.Size = new System.Drawing.Size(38, 15);
            this.lblCharacterStats.TabIndex = 1;
            this.lblCharacterStats.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblCharacterStats);
            this.Controls.Add(this.lblMap);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMap;
        private System.Windows.Forms.Label lblCharacterStats;
    }
}

