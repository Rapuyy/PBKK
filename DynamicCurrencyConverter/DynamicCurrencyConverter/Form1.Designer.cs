
namespace DynamicCurrencyConverter
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
            this.convertResult = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.convertTo = new System.Windows.Forms.ComboBox();
            this.convertFrom = new System.Windows.Forms.ComboBox();
            this.convertButton = new System.Windows.Forms.Button();
            this.numInput = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // convertResult
            // 
            this.convertResult.AutoSize = true;
            this.convertResult.Location = new System.Drawing.Point(28, 278);
            this.convertResult.Name = "convertResult";
            this.convertResult.Size = new System.Drawing.Size(141, 20);
            this.convertResult.TabIndex = 17;
            this.convertResult.Text = "Converted Amount: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(387, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 20);
            this.label4.TabIndex = 16;
            this.label4.Text = "To";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(248, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 20);
            this.label3.TabIndex = 15;
            this.label3.Text = "From";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 20);
            this.label2.TabIndex = 14;
            this.label2.Text = "Enter Amount:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(188, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(310, 46);
            this.label1.TabIndex = 13;
            this.label1.Text = "Currency Converter";
            // 
            // convertTo
            // 
            this.convertTo.FormattingEnabled = true;
            this.convertTo.Items.AddRange(new object[] {
            "IDR",
            "JPY",
            "USD"});
            this.convertTo.Location = new System.Drawing.Point(387, 164);
            this.convertTo.Name = "convertTo";
            this.convertTo.Size = new System.Drawing.Size(70, 28);
            this.convertTo.TabIndex = 12;
            // 
            // convertFrom
            // 
            this.convertFrom.FormattingEnabled = true;
            this.convertFrom.Items.AddRange(new object[] {
            "IDR",
            "JPY",
            "USD"});
            this.convertFrom.Location = new System.Drawing.Point(248, 163);
            this.convertFrom.Name = "convertFrom";
            this.convertFrom.Size = new System.Drawing.Size(70, 28);
            this.convertFrom.TabIndex = 11;
            // 
            // convertButton
            // 
            this.convertButton.Location = new System.Drawing.Point(538, 163);
            this.convertButton.Name = "convertButton";
            this.convertButton.Size = new System.Drawing.Size(94, 29);
            this.convertButton.TabIndex = 10;
            this.convertButton.Text = "Convert";
            this.convertButton.UseVisualStyleBackColor = true;
            this.convertButton.Click += new System.EventHandler(this.convertButton_Click);
            // 
            // numInput
            // 
            this.numInput.Location = new System.Drawing.Point(28, 164);
            this.numInput.Name = "numInput";
            this.numInput.Size = new System.Drawing.Size(125, 27);
            this.numInput.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(649, 450);
            this.Controls.Add(this.convertResult);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.convertTo);
            this.Controls.Add(this.convertFrom);
            this.Controls.Add(this.convertButton);
            this.Controls.Add(this.numInput);
            this.Name = "Form1";
            this.Text = "Dynamic Currency Converter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label convertResult;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox convertTo;
        private System.Windows.Forms.ComboBox convertFrom;
        private System.Windows.Forms.Button convertButton;
        private System.Windows.Forms.TextBox numInput;
    }
}

