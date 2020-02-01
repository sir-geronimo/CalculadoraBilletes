namespace CalculadoraBilletes
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.BillsInput = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Bills100 = new System.Windows.Forms.TextBox();
            this.Bills200 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Bills500 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Bills1000 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Bills2000 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Calculate = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.Bills2000);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.Bills1000);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.Bills500);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.Bills200);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.Bills100);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.BillsInput);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(10, 20);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(396, 311);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(3, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Billetes";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // BillsInput
            // 
            this.BillsInput.Location = new System.Drawing.Point(123, 9);
            this.BillsInput.Name = "BillsInput";
            this.BillsInput.Size = new System.Drawing.Size(149, 23);
            this.BillsInput.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(8, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Billetes de 100";
            // 
            // Bills100
            // 
            this.Bills100.Location = new System.Drawing.Point(123, 94);
            this.Bills100.Name = "Bills100";
            this.Bills100.ReadOnly = true;
            this.Bills100.Size = new System.Drawing.Size(149, 23);
            this.Bills100.TabIndex = 3;
            // 
            // Bills200
            // 
            this.Bills200.Location = new System.Drawing.Point(123, 133);
            this.Bills200.Name = "Bills200";
            this.Bills200.ReadOnly = true;
            this.Bills200.Size = new System.Drawing.Size(149, 23);
            this.Bills200.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(8, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 23);
            this.label3.TabIndex = 4;
            this.label3.Text = "Billetes de 200";
            // 
            // Bills500
            // 
            this.Bills500.Location = new System.Drawing.Point(123, 174);
            this.Bills500.Name = "Bills500";
            this.Bills500.ReadOnly = true;
            this.Bills500.Size = new System.Drawing.Size(149, 23);
            this.Bills500.TabIndex = 7;
            this.Bills500.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(8, 177);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 23);
            this.label4.TabIndex = 6;
            this.label4.Text = "Billetes de 500";
            // 
            // Bills1000
            // 
            this.Bills1000.Location = new System.Drawing.Point(123, 215);
            this.Bills1000.Name = "Bills1000";
            this.Bills1000.ReadOnly = true;
            this.Bills1000.Size = new System.Drawing.Size(149, 23);
            this.Bills1000.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(8, 218);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 23);
            this.label5.TabIndex = 8;
            this.label5.Text = "Billetes de 1000";
            // 
            // Bills2000
            // 
            this.Bills2000.Location = new System.Drawing.Point(123, 255);
            this.Bills2000.Name = "Bills2000";
            this.Bills2000.ReadOnly = true;
            this.Bills2000.Size = new System.Drawing.Size(149, 23);
            this.Bills2000.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(8, 258);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 23);
            this.label6.TabIndex = 10;
            this.label6.Text = "Billetes de 2000";
            // 
            // Calculate
            // 
            this.Calculate.Location = new System.Drawing.Point(134, 360);
            this.Calculate.Name = "Calculate";
            this.Calculate.Size = new System.Drawing.Size(149, 44);
            this.Calculate.TabIndex = 1;
            this.Calculate.Text = "Calcular";
            this.Calculate.UseVisualStyleBackColor = true;
            this.Calculate.Click += new System.EventHandler(this.CalculateBills);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(417, 445);
            this.Controls.Add(this.Calculate);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Calculadora";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Bills1000;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Bills2000;
        private System.Windows.Forms.Button Calculate;
        private System.Windows.Forms.TextBox Bills100;
        private System.Windows.Forms.TextBox Bills200;
        private System.Windows.Forms.TextBox Bills500;
        private System.Windows.Forms.TextBox BillsInput;
    }
}