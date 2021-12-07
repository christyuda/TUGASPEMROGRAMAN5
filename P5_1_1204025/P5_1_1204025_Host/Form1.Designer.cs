namespace P5_1_1204025_Host
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
            this.label1 = new System.Windows.Forms.Label();
            this.numericTextBox1 = new P5_1_1204025.NumericTextBox();
            this.verticalLabel1 = new P5_1_1204025.VerticalLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Extended Control : Numeric TextBox";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // numericTextBox1
            // 
            this.numericTextBox1.Location = new System.Drawing.Point(49, 25);
            this.numericTextBox1.Name = "numericTextBox1";
            this.numericTextBox1.Size = new System.Drawing.Size(100, 20);
            this.numericTextBox1.TabIndex = 1;
            // 
            // verticalLabel1
            // 
            this.verticalLabel1.Location = new System.Drawing.Point(49, 87);
            this.verticalLabel1.Name = "verticalLabel1";
            this.verticalLabel1.Size = new System.Drawing.Size(26, 77);
            this.verticalLabel1.TabIndex = 7;
            this.verticalLabel1.Text = "verticalLabel1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Custom Control : Vertical Label";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.verticalLabel1);
            this.Controls.Add(this.numericTextBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private P5_1_1204025.NumericTextBox numericTextBox1;
        private P5_1_1204025.VerticalLabel verticalLabel1;
        private System.Windows.Forms.Label label2;
    }
}

