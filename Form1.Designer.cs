
namespace Grapecity_assessment
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1bill = new System.Windows.Forms.Label();
            this.textBox1bill = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.labeltipamount = new System.Windows.Forms.Label();
            this.labeltotal = new System.Windows.Forms.Label();
            this.numericUpDowntip = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.labeltipperperson = new System.Windows.Forms.Label();
            this.labeltotalperperson = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDowntip)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1bill
            // 
            this.label1bill.AutoSize = true;
            this.label1bill.BackColor = System.Drawing.Color.YellowGreen;
            this.label1bill.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1bill.Location = new System.Drawing.Point(45, 21);
            this.label1bill.Name = "label1bill";
            this.label1bill.Size = new System.Drawing.Size(29, 18);
            this.label1bill.TabIndex = 0;
            this.label1bill.Text = "Bill";
            // 
            // textBox1bill
            // 
            this.textBox1bill.Location = new System.Drawing.Point(145, 13);
            this.textBox1bill.Name = "textBox1bill";
            this.textBox1bill.Size = new System.Drawing.Size(197, 23);
            this.textBox1bill.TabIndex = 1;
            this.textBox1bill.TextChanged += new System.EventHandler(this.textBox1bill_TextChanged);
            this.textBox1bill.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(145, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 15);
            this.label2.TabIndex = 2;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(45, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 18);
            this.label3.TabIndex = 3;
            this.label3.Text = "Tip %";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(45, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 18);
            this.label4.TabIndex = 4;
            this.label4.Text = "Tip amount";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(45, 130);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 18);
            this.label5.TabIndex = 5;
            this.label5.Text = "Total";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // labeltipamount
            // 
            this.labeltipamount.BackColor = System.Drawing.Color.BurlyWood;
            this.labeltipamount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labeltipamount.Location = new System.Drawing.Point(145, 97);
            this.labeltipamount.Name = "labeltipamount";
            this.labeltipamount.Size = new System.Drawing.Size(197, 23);
            this.labeltipamount.TabIndex = 6;
            this.labeltipamount.Text = "$";
            this.labeltipamount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labeltotal
            // 
            this.labeltotal.BackColor = System.Drawing.Color.BurlyWood;
            this.labeltotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labeltotal.Location = new System.Drawing.Point(145, 129);
            this.labeltotal.Name = "labeltotal";
            this.labeltotal.Size = new System.Drawing.Size(197, 23);
            this.labeltotal.TabIndex = 7;
            this.labeltotal.Text = "$";
            this.labeltotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // numericUpDowntip
            // 
            this.numericUpDowntip.Location = new System.Drawing.Point(145, 61);
            this.numericUpDowntip.Name = "numericUpDowntip";
            this.numericUpDowntip.Size = new System.Drawing.Size(197, 23);
            this.numericUpDowntip.TabIndex = 8;
            this.numericUpDowntip.ValueChanged += new System.EventHandler(this.numericUpDowntip_ValueChanged);
            this.numericUpDowntip.Validated += new System.EventHandler(this.numericUpDowntip_Validated);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Orange;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(-9, 166);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(474, 23);
            this.label1.TabIndex = 9;
            this.label1.Text = "Are you splitting the bill ?";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(19, 208);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(120, 18);
            this.label6.TabIndex = 10;
            this.label6.Text = "Number of Person";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(42, 250);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(97, 18);
            this.label7.TabIndex = 11;
            this.label7.Text = "Tip per person";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(31, 288);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(108, 18);
            this.label8.TabIndex = 12;
            this.label8.Text = "Total per person";
            // 
            // labeltipperperson
            // 
            this.labeltipperperson.BackColor = System.Drawing.Color.BurlyWood;
            this.labeltipperperson.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labeltipperperson.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labeltipperperson.Location = new System.Drawing.Point(145, 253);
            this.labeltipperperson.Name = "labeltipperperson";
            this.labeltipperperson.Size = new System.Drawing.Size(197, 23);
            this.labeltipperperson.TabIndex = 13;
            this.labeltipperperson.Text = "$";
            this.labeltipperperson.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labeltipperperson.Validated += new System.EventHandler(this.labeltipperperson_Validated);
            // 
            // labeltotalperperson
            // 
            this.labeltotalperperson.BackColor = System.Drawing.Color.BurlyWood;
            this.labeltotalperperson.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labeltotalperperson.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labeltotalperperson.Location = new System.Drawing.Point(145, 288);
            this.labeltotalperperson.Name = "labeltotalperperson";
            this.labeltotalperperson.Size = new System.Drawing.Size(197, 23);
            this.labeltotalperperson.TabIndex = 14;
            this.labeltotalperperson.Text = "$";
            this.labeltotalperperson.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labeltotalperperson.Validated += new System.EventHandler(this.labeltotalperperson_Validated);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(145, 203);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(197, 23);
            this.numericUpDown1.TabIndex = 15;
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            this.numericUpDown1.Validated += new System.EventHandler(this.numericUpDown1_Validated);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.MediumTurquoise;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(177, 323);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(118, 43);
            this.button1.TabIndex = 16;
            this.button1.Text = "Calculate";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.YellowGreen;
            this.ClientSize = new System.Drawing.Size(459, 366);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.labeltotalperperson);
            this.Controls.Add(this.labeltipperperson);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numericUpDowntip);
            this.Controls.Add(this.labeltotal);
            this.Controls.Add(this.labeltipamount);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1bill);
            this.Controls.Add(this.label1bill);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Tip Calculator";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDowntip)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1bill;
        private System.Windows.Forms.TextBox textBox1bill;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.NumericUpDown numericUpDowntip;
        private System.Windows.Forms.Label labeltotal;
        private System.Windows.Forms.Label labeltipamount;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label labeltotalperperson;
        private System.Windows.Forms.Label labeltipperperson;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
    }
}

