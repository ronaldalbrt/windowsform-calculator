﻿namespace CalculadoraWindowsForms
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Calculadora = new System.Windows.Forms.TabPage();
            this.button15 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.Tela = new System.Windows.Forms.TextBox();
            this.Proporcão = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button16 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.prop4 = new System.Windows.Forms.TextBox();
            this.prop3 = new System.Windows.Forms.TextBox();
            this.prop2 = new System.Windows.Forms.TextBox();
            this.prop1 = new System.Windows.Forms.TextBox();
            this.Estapara = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.Calculadora.SuspendLayout();
            this.Proporcão.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Calculadora);
            this.tabControl1.Controls.Add(this.Proporcão);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(-1, -1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(600, 363);
            this.tabControl1.TabIndex = 0;
            // 
            // Calculadora
            // 
            this.Calculadora.Controls.Add(this.button15);
            this.Calculadora.Controls.Add(this.button14);
            this.Calculadora.Controls.Add(this.button13);
            this.Calculadora.Controls.Add(this.button12);
            this.Calculadora.Controls.Add(this.button11);
            this.Calculadora.Controls.Add(this.button10);
            this.Calculadora.Controls.Add(this.button9);
            this.Calculadora.Controls.Add(this.button8);
            this.Calculadora.Controls.Add(this.button7);
            this.Calculadora.Controls.Add(this.button6);
            this.Calculadora.Controls.Add(this.button5);
            this.Calculadora.Controls.Add(this.button4);
            this.Calculadora.Controls.Add(this.button3);
            this.Calculadora.Controls.Add(this.button2);
            this.Calculadora.Controls.Add(this.button1);
            this.Calculadora.Controls.Add(this.Tela);
            this.Calculadora.Location = new System.Drawing.Point(4, 22);
            this.Calculadora.Name = "Calculadora";
            this.Calculadora.Padding = new System.Windows.Forms.Padding(3);
            this.Calculadora.Size = new System.Drawing.Size(592, 337);
            this.Calculadora.TabIndex = 0;
            this.Calculadora.Text = "Calculadora";
            this.Calculadora.UseVisualStyleBackColor = true;
            this.Calculadora.Click += new System.EventHandler(this.Calculadora_Click);
            // 
            // button15
            // 
            this.button15.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button15.Location = new System.Drawing.Point(339, 58);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(244, 57);
            this.button15.TabIndex = 15;
            this.button15.Text = "=";
            this.button15.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button15.UseVisualStyleBackColor = true;
            this.button15.Click += new System.EventHandler(this.button15_Click);
            // 
            // button14
            // 
            this.button14.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button14.Location = new System.Drawing.Point(464, 221);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(119, 94);
            this.button14.TabIndex = 14;
            this.button14.Text = "/";
            this.button14.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button14.UseVisualStyleBackColor = true;
            this.button14.Click += new System.EventHandler(this.button14_Click);
            // 
            // button13
            // 
            this.button13.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button13.Location = new System.Drawing.Point(339, 221);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(119, 94);
            this.button13.TabIndex = 13;
            this.button13.Text = "*";
            this.button13.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Click += new System.EventHandler(this.button13_Click);
            // 
            // button12
            // 
            this.button12.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button12.Location = new System.Drawing.Point(464, 121);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(119, 94);
            this.button12.TabIndex = 12;
            this.button12.Text = "-";
            this.button12.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.button12_Click);
            // 
            // button11
            // 
            this.button11.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button11.Location = new System.Drawing.Point(339, 121);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(119, 94);
            this.button11.TabIndex = 11;
            this.button11.Text = "+";
            this.button11.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // button10
            // 
            this.button10.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button10.Location = new System.Drawing.Point(250, 246);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(83, 45);
            this.button10.TabIndex = 10;
            this.button10.Text = "1";
            this.button10.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // button9
            // 
            this.button9.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button9.Location = new System.Drawing.Point(250, 185);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(83, 45);
            this.button9.TabIndex = 9;
            this.button9.Text = "4";
            this.button9.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button8
            // 
            this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.Location = new System.Drawing.Point(250, 121);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(83, 45);
            this.button8.TabIndex = 8;
            this.button8.Text = "7";
            this.button8.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button7
            // 
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.Location = new System.Drawing.Point(134, 246);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(83, 45);
            this.button7.TabIndex = 7;
            this.button7.Text = "2";
            this.button7.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Location = new System.Drawing.Point(134, 185);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(83, 45);
            this.button6.TabIndex = 6;
            this.button6.Text = "5";
            this.button6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(134, 121);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(83, 45);
            this.button5.TabIndex = 5;
            this.button5.Text = "8";
            this.button5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(20, 246);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(83, 45);
            this.button4.TabIndex = 4;
            this.button4.Text = "3";
            this.button4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(20, 185);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(83, 45);
            this.button3.TabIndex = 3;
            this.button3.Text = "6";
            this.button3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(20, 121);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(83, 45);
            this.button2.TabIndex = 2;
            this.button2.Text = "9";
            this.button2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(9, 58);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(106, 57);
            this.button1.TabIndex = 1;
            this.button1.Text = "AC";
            this.button1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Tela
            // 
            this.Tela.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Tela.Enabled = false;
            this.Tela.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tela.ForeColor = System.Drawing.SystemColors.WindowText;
            this.Tela.Location = new System.Drawing.Point(9, 6);
            this.Tela.Name = "Tela";
            this.Tela.Size = new System.Drawing.Size(574, 46);
            this.Tela.TabIndex = 0;
            this.Tela.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Proporcão
            // 
            this.Proporcão.Controls.Add(this.panel1);
            this.Proporcão.Location = new System.Drawing.Point(4, 22);
            this.Proporcão.Name = "Proporcão";
            this.Proporcão.Padding = new System.Windows.Forms.Padding(3);
            this.Proporcão.Size = new System.Drawing.Size(592, 337);
            this.Proporcão.TabIndex = 1;
            this.Proporcão.Text = "Proporcão";
            this.Proporcão.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.button16);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.Estapara);
            this.panel1.Controls.Add(this.prop4);
            this.panel1.Controls.Add(this.prop3);
            this.panel1.Controls.Add(this.prop2);
            this.panel1.Controls.Add(this.prop1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(596, 337);
            this.panel1.TabIndex = 0;
            // 
            // button16
            // 
            this.button16.Location = new System.Drawing.Point(138, 3);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(314, 69);
            this.button16.TabIndex = 6;
            this.button16.Text = "Proporcão";
            this.button16.UseVisualStyleBackColor = true;
            this.button16.Click += new System.EventHandler(this.button16_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(262, 216);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 37);
            this.label1.TabIndex = 5;
            this.label1.Text = "/";
            // 
            // prop4
            // 
            this.prop4.Cursor = System.Windows.Forms.Cursors.Default;
            this.prop4.Enabled = false;
            this.prop4.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prop4.Location = new System.Drawing.Point(386, 200);
            this.prop4.Multiline = true;
            this.prop4.Name = "prop4";
            this.prop4.Size = new System.Drawing.Size(159, 66);
            this.prop4.TabIndex = 3;
            // 
            // prop3
            // 
            this.prop3.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prop3.Location = new System.Drawing.Point(359, 82);
            this.prop3.Multiline = true;
            this.prop3.Name = "prop3";
            this.prop3.Size = new System.Drawing.Size(159, 66);
            this.prop3.TabIndex = 2;
            // 
            // prop2
            // 
            this.prop2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prop2.Location = new System.Drawing.Point(22, 200);
            this.prop2.Multiline = true;
            this.prop2.Name = "prop2";
            this.prop2.Size = new System.Drawing.Size(159, 66);
            this.prop2.TabIndex = 1;
            // 
            // prop1
            // 
            this.prop1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prop1.Location = new System.Drawing.Point(22, 82);
            this.prop1.Multiline = true;
            this.prop1.Name = "prop1";
            this.prop1.Size = new System.Drawing.Size(159, 66);
            this.prop1.TabIndex = 0;
            // 
            // Estapara
            // 
            this.Estapara.AutoSize = true;
            this.Estapara.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Estapara.Location = new System.Drawing.Point(262, 102);
            this.Estapara.Name = "Estapara";
            this.Estapara.Size = new System.Drawing.Size(26, 37);
            this.Estapara.TabIndex = 4;
            this.Estapara.Text = "/";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(262, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 37);
            this.label2.TabIndex = 7;
            this.label2.Text = "||";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(598, 357);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.Calculadora.ResumeLayout(false);
            this.Calculadora.PerformLayout();
            this.Proporcão.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Calculadora;
        private System.Windows.Forms.TabPage Proporcão;
        private System.Windows.Forms.TextBox Tela;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox prop1;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox prop4;
        private System.Windows.Forms.TextBox prop3;
        private System.Windows.Forms.TextBox prop2;
        private System.Windows.Forms.Label Estapara;
        private System.Windows.Forms.Label label2;
    }
}

