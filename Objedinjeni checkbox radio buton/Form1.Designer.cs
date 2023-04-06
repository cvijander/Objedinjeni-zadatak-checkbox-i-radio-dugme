namespace Objedinjeni_checkbox_radio_buton
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbtSiva = new System.Windows.Forms.RadioButton();
            this.rbtCrvena = new System.Windows.Forms.RadioButton();
            this.rbtZuta = new System.Windows.Forms.RadioButton();
            this.rbtPlava = new System.Windows.Forms.RadioButton();
            this.rbtZelena = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.chbDeljiviSaSedam = new System.Windows.Forms.CheckBox();
            this.chbDeljiviSaPet = new System.Windows.Forms.CheckBox();
            this.chbDeljiviSaTri = new System.Windows.Forms.CheckBox();
            this.chbDeljiviSaDva = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbtSiva);
            this.groupBox1.Controls.Add(this.rbtCrvena);
            this.groupBox1.Controls.Add(this.rbtZuta);
            this.groupBox1.Controls.Add(this.rbtPlava);
            this.groupBox1.Controls.Add(this.rbtZelena);
            this.groupBox1.Location = new System.Drawing.Point(20, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(159, 286);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Odaberi boju pozadine";
            // 
            // rbtSiva
            // 
            this.rbtSiva.AutoSize = true;
            this.rbtSiva.Location = new System.Drawing.Point(26, 247);
            this.rbtSiva.Name = "rbtSiva";
            this.rbtSiva.Size = new System.Drawing.Size(45, 19);
            this.rbtSiva.TabIndex = 4;
            this.rbtSiva.TabStop = true;
            this.rbtSiva.Text = "siva";
            this.rbtSiva.UseVisualStyleBackColor = true;
            this.rbtSiva.CheckedChanged += new System.EventHandler(this.rbtSiva_CheckedChanged);
            // 
            // rbtCrvena
            // 
            this.rbtCrvena.AutoSize = true;
            this.rbtCrvena.Location = new System.Drawing.Point(26, 195);
            this.rbtCrvena.Name = "rbtCrvena";
            this.rbtCrvena.Size = new System.Drawing.Size(60, 19);
            this.rbtCrvena.TabIndex = 3;
            this.rbtCrvena.TabStop = true;
            this.rbtCrvena.Text = "crvena";
            this.rbtCrvena.UseVisualStyleBackColor = true;
            this.rbtCrvena.CheckedChanged += new System.EventHandler(this.rbtCrvena_CheckedChanged);
            // 
            // rbtZuta
            // 
            this.rbtZuta.AutoSize = true;
            this.rbtZuta.Location = new System.Drawing.Point(26, 142);
            this.rbtZuta.Name = "rbtZuta";
            this.rbtZuta.Size = new System.Drawing.Size(47, 19);
            this.rbtZuta.TabIndex = 2;
            this.rbtZuta.TabStop = true;
            this.rbtZuta.Text = "zuta";
            this.rbtZuta.UseVisualStyleBackColor = true;
            this.rbtZuta.CheckedChanged += new System.EventHandler(this.rbtZuta_CheckedChanged);
            // 
            // rbtPlava
            // 
            this.rbtPlava.AutoSize = true;
            this.rbtPlava.Location = new System.Drawing.Point(26, 93);
            this.rbtPlava.Name = "rbtPlava";
            this.rbtPlava.Size = new System.Drawing.Size(53, 19);
            this.rbtPlava.TabIndex = 1;
            this.rbtPlava.TabStop = true;
            this.rbtPlava.Text = "plava";
            this.rbtPlava.UseVisualStyleBackColor = true;
            this.rbtPlava.CheckedChanged += new System.EventHandler(this.rbtPlava_CheckedChanged);
            // 
            // rbtZelena
            // 
            this.rbtZelena.AutoSize = true;
            this.rbtZelena.Location = new System.Drawing.Point(26, 48);
            this.rbtZelena.Name = "rbtZelena";
            this.rbtZelena.Size = new System.Drawing.Size(58, 19);
            this.rbtZelena.TabIndex = 0;
            this.rbtZelena.TabStop = true;
            this.rbtZelena.Text = "zelena";
            this.rbtZelena.UseVisualStyleBackColor = true;
            this.rbtZelena.CheckedChanged += new System.EventHandler(this.rbtZelena_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.chbDeljiviSaSedam);
            this.groupBox2.Controls.Add(this.chbDeljiviSaPet);
            this.groupBox2.Controls.Add(this.chbDeljiviSaTri);
            this.groupBox2.Controls.Add(this.chbDeljiviSaDva);
            this.groupBox2.Location = new System.Drawing.Point(197, 22);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(390, 286);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Odaberi delioca /delioce ";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(27, 217);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(343, 23);
            this.textBox1.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(30, 160);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(232, 38);
            this.button1.TabIndex = 4;
            this.button1.Text = "Primeni";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // chbDeljiviSaSedam
            // 
            this.chbDeljiviSaSedam.AutoSize = true;
            this.chbDeljiviSaSedam.Location = new System.Drawing.Point(29, 128);
            this.chbDeljiviSaSedam.Name = "chbDeljiviSaSedam";
            this.chbDeljiviSaSedam.Size = new System.Drawing.Size(80, 19);
            this.chbDeljiviSaSedam.TabIndex = 3;
            this.chbDeljiviSaSedam.Text = "deljivi sa 7";
            this.chbDeljiviSaSedam.UseVisualStyleBackColor = true;
            // 
            // chbDeljiviSaPet
            // 
            this.chbDeljiviSaPet.AutoSize = true;
            this.chbDeljiviSaPet.Location = new System.Drawing.Point(29, 103);
            this.chbDeljiviSaPet.Name = "chbDeljiviSaPet";
            this.chbDeljiviSaPet.Size = new System.Drawing.Size(80, 19);
            this.chbDeljiviSaPet.TabIndex = 2;
            this.chbDeljiviSaPet.Text = "deljivi sa 5";
            this.chbDeljiviSaPet.UseVisualStyleBackColor = true;
            // 
            // chbDeljiviSaTri
            // 
            this.chbDeljiviSaTri.AutoSize = true;
            this.chbDeljiviSaTri.Location = new System.Drawing.Point(29, 78);
            this.chbDeljiviSaTri.Name = "chbDeljiviSaTri";
            this.chbDeljiviSaTri.Size = new System.Drawing.Size(80, 19);
            this.chbDeljiviSaTri.TabIndex = 1;
            this.chbDeljiviSaTri.Text = "deljivi sa 3";
            this.chbDeljiviSaTri.UseVisualStyleBackColor = true;
            // 
            // chbDeljiviSaDva
            // 
            this.chbDeljiviSaDva.AutoSize = true;
            this.chbDeljiviSaDva.Location = new System.Drawing.Point(29, 53);
            this.chbDeljiviSaDva.Name = "chbDeljiviSaDva";
            this.chbDeljiviSaDva.Size = new System.Drawing.Size(80, 19);
            this.chbDeljiviSaDva.TabIndex = 0;
            this.chbDeljiviSaDva.Text = "deljivi sa 2";
            this.chbDeljiviSaDva.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 323);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Boja pozadine i deljivost";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
        private RadioButton rbtSiva;
        private RadioButton rbtCrvena;
        private RadioButton rbtZuta;
        private RadioButton rbtPlava;
        private RadioButton rbtZelena;
        private GroupBox groupBox2;
        private TextBox textBox1;
        private Button button1;
        private CheckBox chbDeljiviSaSedam;
        private CheckBox chbDeljiviSaPet;
        public CheckBox chbDeljiviSaTri;
        private CheckBox chbDeljiviSaDva;
    }
}