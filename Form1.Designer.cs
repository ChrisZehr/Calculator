
using System;

namespace Calculator {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.n7 = new System.Windows.Forms.Button();
            this.n8 = new System.Windows.Forms.Button();
            this.n9 = new System.Windows.Forms.Button();
            this.n6 = new System.Windows.Forms.Button();
            this.n5 = new System.Windows.Forms.Button();
            this.n4 = new System.Windows.Forms.Button();
            this.n1 = new System.Windows.Forms.Button();
            this.n2 = new System.Windows.Forms.Button();
            this.n3 = new System.Windows.Forms.Button();
            this.ndot = new System.Windows.Forms.Button();
            this.n0 = new System.Windows.Forms.Button();
            this.opadd = new System.Windows.Forms.Button();
            this.opsub = new System.Windows.Forms.Button();
            this.opmul = new System.Windows.Forms.Button();
            this.opdiv = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.opequals = new System.Windows.Forms.Button();
            this.opclear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("DejaVu Sans Condensed", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(52, 12);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(239, 36);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "0";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // n7
            // 
            this.n7.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.n7.Location = new System.Drawing.Point(72, 171);
            this.n7.Name = "n7";
            this.n7.Size = new System.Drawing.Size(50, 50);
            this.n7.TabIndex = 1;
            this.n7.Text = "7";
            this.n7.UseVisualStyleBackColor = true;
            this.n7.Click += new System.EventHandler(this.number_Click);
            // 
            // n8
            // 
            this.n8.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.n8.Location = new System.Drawing.Point(128, 171);
            this.n8.Name = "n8";
            this.n8.Size = new System.Drawing.Size(50, 50);
            this.n8.TabIndex = 1;
            this.n8.Text = "8";
            this.n8.UseVisualStyleBackColor = true;
            this.n8.Click += new System.EventHandler(this.number_Click);
            // 
            // n9
            // 
            this.n9.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.n9.Location = new System.Drawing.Point(184, 171);
            this.n9.Name = "n9";
            this.n9.Size = new System.Drawing.Size(50, 50);
            this.n9.TabIndex = 1;
            this.n9.Text = "9";
            this.n9.UseVisualStyleBackColor = true;
            this.n9.Click += new System.EventHandler(this.number_Click);
            // 
            // n6
            // 
            this.n6.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.n6.Location = new System.Drawing.Point(184, 227);
            this.n6.Name = "n6";
            this.n6.Size = new System.Drawing.Size(50, 50);
            this.n6.TabIndex = 1;
            this.n6.Text = "6";
            this.n6.UseVisualStyleBackColor = true;
            this.n6.Click += new System.EventHandler(this.number_Click);
            // 
            // n5
            // 
            this.n5.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.n5.Location = new System.Drawing.Point(128, 227);
            this.n5.Name = "n5";
            this.n5.Size = new System.Drawing.Size(50, 50);
            this.n5.TabIndex = 1;
            this.n5.Text = "5";
            this.n5.UseVisualStyleBackColor = true;
            this.n5.Click += new System.EventHandler(this.number_Click);
            // 
            // n4
            // 
            this.n4.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.n4.Location = new System.Drawing.Point(72, 227);
            this.n4.Name = "n4";
            this.n4.Size = new System.Drawing.Size(50, 50);
            this.n4.TabIndex = 1;
            this.n4.Text = "4";
            this.n4.UseVisualStyleBackColor = true;
            this.n4.Click += new System.EventHandler(this.number_Click);
            // 
            // n1
            // 
            this.n1.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.n1.Location = new System.Drawing.Point(72, 283);
            this.n1.Name = "n1";
            this.n1.Size = new System.Drawing.Size(50, 50);
            this.n1.TabIndex = 1;
            this.n1.Text = "1";
            this.n1.UseVisualStyleBackColor = true;
            this.n1.Click += new System.EventHandler(this.number_Click);
            // 
            // n2
            // 
            this.n2.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.n2.Location = new System.Drawing.Point(128, 283);
            this.n2.Name = "n2";
            this.n2.Size = new System.Drawing.Size(50, 50);
            this.n2.TabIndex = 1;
            this.n2.Text = "2";
            this.n2.UseVisualStyleBackColor = true;
            this.n2.Click += new System.EventHandler(this.number_Click);
            // 
            // n3
            // 
            this.n3.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.n3.Location = new System.Drawing.Point(184, 283);
            this.n3.Name = "n3";
            this.n3.Size = new System.Drawing.Size(50, 50);
            this.n3.TabIndex = 1;
            this.n3.Text = "3";
            this.n3.UseVisualStyleBackColor = true;
            this.n3.Click += new System.EventHandler(this.number_Click);
            // 
            // ndot
            // 
            this.ndot.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ndot.Location = new System.Drawing.Point(184, 339);
            this.ndot.Name = "ndot";
            this.ndot.Size = new System.Drawing.Size(50, 50);
            this.ndot.TabIndex = 1;
            this.ndot.Text = ".";
            this.ndot.UseVisualStyleBackColor = true;
            this.ndot.Click += new System.EventHandler(this.number_Click);
            // 
            // n0
            // 
            this.n0.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.n0.Location = new System.Drawing.Point(72, 339);
            this.n0.Name = "n0";
            this.n0.Size = new System.Drawing.Size(106, 50);
            this.n0.TabIndex = 1;
            this.n0.Text = "0";
            this.n0.UseVisualStyleBackColor = true;
            this.n0.Click += new System.EventHandler(this.number_Click);
            // 
            // opadd
            // 
            this.opadd.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.opadd.Location = new System.Drawing.Point(241, 171);
            this.opadd.Name = "opadd";
            this.opadd.Size = new System.Drawing.Size(50, 50);
            this.opadd.TabIndex = 2;
            this.opadd.Text = "+";
            this.opadd.UseVisualStyleBackColor = true;
            this.opadd.Click += new System.EventHandler(this.operator_Click);
            // 
            // opsub
            // 
            this.opsub.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.opsub.Location = new System.Drawing.Point(241, 227);
            this.opsub.Name = "opsub";
            this.opsub.Size = new System.Drawing.Size(50, 50);
            this.opsub.TabIndex = 2;
            this.opsub.Text = "-";
            this.opsub.UseVisualStyleBackColor = true;
            this.opsub.Click += new System.EventHandler(this.operator_Click);
            // 
            // opmul
            // 
            this.opmul.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.opmul.Location = new System.Drawing.Point(240, 283);
            this.opmul.Name = "opmul";
            this.opmul.Size = new System.Drawing.Size(50, 50);
            this.opmul.TabIndex = 2;
            this.opmul.Text = "*";
            this.opmul.UseVisualStyleBackColor = true;
            this.opmul.Click += new System.EventHandler(this.operator_Click);
            // 
            // opdiv
            // 
            this.opdiv.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.opdiv.Location = new System.Drawing.Point(240, 339);
            this.opdiv.Name = "opdiv";
            this.opdiv.Size = new System.Drawing.Size(50, 50);
            this.opdiv.TabIndex = 2;
            this.opdiv.Text = "/";
            this.opdiv.UseVisualStyleBackColor = true;
            this.opdiv.Click += new System.EventHandler(this.operator_Click);
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("DejaVu Sans Condensed", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(52, 54);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(239, 36);
            this.textBox2.TabIndex = 0;
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("DejaVu Sans Condensed", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(7, 54);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(39, 36);
            this.textBox3.TabIndex = 0;
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBox4
            // 
            this.textBox4.Font = new System.Drawing.Font("DejaVu Sans Condensed", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.Location = new System.Drawing.Point(52, 129);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(239, 36);
            this.textBox4.TabIndex = 0;
            this.textBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // opequals
            // 
            this.opequals.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.opequals.Location = new System.Drawing.Point(72, 395);
            this.opequals.Name = "opequals";
            this.opequals.Size = new System.Drawing.Size(218, 50);
            this.opequals.TabIndex = 1;
            this.opequals.Text = "=";
            this.opequals.UseVisualStyleBackColor = true;
            this.opequals.Click += new System.EventHandler(this.equals_Click);
            // 
            // opclear
            // 
            this.opclear.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.opclear.Location = new System.Drawing.Point(297, 12);
            this.opclear.Name = "opclear";
            this.opclear.Size = new System.Drawing.Size(50, 78);
            this.opclear.TabIndex = 1;
            this.opclear.Text = "C";
            this.opclear.UseVisualStyleBackColor = true;
            this.opclear.Click += new System.EventHandler(this.clear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(864, 450);
            this.Controls.Add(this.opdiv);
            this.Controls.Add(this.opmul);
            this.Controls.Add(this.opsub);
            this.Controls.Add(this.opadd);
            this.Controls.Add(this.ndot);
            this.Controls.Add(this.n3);
            this.Controls.Add(this.n2);
            this.Controls.Add(this.opequals);
            this.Controls.Add(this.n0);
            this.Controls.Add(this.opclear);
            this.Controls.Add(this.n1);
            this.Controls.Add(this.n4);
            this.Controls.Add(this.n5);
            this.Controls.Add(this.n6);
            this.Controls.Add(this.n9);
            this.Controls.Add(this.n8);
            this.Controls.Add(this.n7);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button n7;
        private System.Windows.Forms.Button n8;
        private System.Windows.Forms.Button n9;
        private System.Windows.Forms.Button n6;
        private System.Windows.Forms.Button n5;
        private System.Windows.Forms.Button n4;
        private System.Windows.Forms.Button n1;
        private System.Windows.Forms.Button n2;
        private System.Windows.Forms.Button n3;
        private System.Windows.Forms.Button ndot;
        private System.Windows.Forms.Button n0;
        private System.Windows.Forms.Button opadd;
        private System.Windows.Forms.Button opsub;
        private System.Windows.Forms.Button opmul;
        private System.Windows.Forms.Button opdiv;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button opequals;
        private System.Windows.Forms.Button opclear;
    }
}

