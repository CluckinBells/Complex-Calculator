namespace ComplexCalculator
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.TextBox real1TextBox;
        private System.Windows.Forms.TextBox imaginary1TextBox;
        private System.Windows.Forms.TextBox real2TextBox;
        private System.Windows.Forms.TextBox imaginary2TextBox;
        private System.Windows.Forms.ComboBox operationComboBox;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Label resultLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.real1TextBox = new System.Windows.Forms.TextBox();
            this.imaginary1TextBox = new System.Windows.Forms.TextBox();
            this.real2TextBox = new System.Windows.Forms.TextBox();
            this.imaginary2TextBox = new System.Windows.Forms.TextBox();
            this.operationComboBox = new System.Windows.Forms.ComboBox();
            this.calculateButton = new System.Windows.Forms.Button();
            this.resultLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();

            // 
            // real1TextBox
            // 
            this.real1TextBox.Location = new System.Drawing.Point(50, 30);
            this.real1TextBox.Name = "real1TextBox";
            this.real1TextBox.Size = new System.Drawing.Size(100, 20);
            this.real1TextBox.TabIndex = 0;

            // 
            // imaginary1TextBox
            // 
            this.imaginary1TextBox.Location = new System.Drawing.Point(200, 30);
            this.imaginary1TextBox.Name = "imaginary1TextBox";
            this.imaginary1TextBox.Size = new System.Drawing.Size(100, 20);
            this.imaginary1TextBox.TabIndex = 1;

            // 
            // real2TextBox
            // 
            this.real2TextBox.Location = new System.Drawing.Point(50, 80);
            this.real2TextBox.Name = "real2TextBox";
            this.real2TextBox.Size = new System.Drawing.Size(100, 20);
            this.real2TextBox.TabIndex = 2;

            // 
            // imaginary2TextBox
            // 
            this.imaginary2TextBox.Location = new System.Drawing.Point(200, 80);
            this.imaginary2TextBox.Name = "imaginary2TextBox";
            this.imaginary2TextBox.Size = new System.Drawing.Size(100, 20);
            this.imaginary2TextBox.TabIndex = 3;

            // 
            // operationComboBox
            // 
            this.operationComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.operationComboBox.FormattingEnabled = true;
            this.operationComboBox.Items.AddRange(new object[] { "+", "-", "*", "/" });
            this.operationComboBox.Location = new System.Drawing.Point(125, 130);
            this.operationComboBox.Name = "operationComboBox";
            this.operationComboBox.Size = new System.Drawing.Size(50, 21);
            this.operationComboBox.TabIndex = 4;

            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(125, 170);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(75, 23);
            this.calculateButton.TabIndex = 5;
            this.calculateButton.Text = "Calculate";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);

            // 
            // resultLabel
            // 
            this.resultLabel.AutoSize = true;
            this.resultLabel.Location = new System.Drawing.Point(125, 220);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(0, 13);
            this.resultLabel.TabIndex = 6;

            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Real 1";

            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(200, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Imaginary 1";

            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(50, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Real 2";

            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(200, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Imaginary 2";

            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 300);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.resultLabel);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.operationComboBox);
            this.Controls.Add(this.imaginary2TextBox);
            this.Controls.Add(this.real2TextBox);
            this.Controls.Add(this.imaginary1TextBox);
            this.Controls.Add(this.real1TextBox);
            this.Name = "Form1";
            this.Text = "Complex Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}