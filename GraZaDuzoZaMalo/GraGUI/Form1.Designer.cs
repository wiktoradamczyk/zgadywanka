namespace GraGUI
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
            this.btnNowaGra = new System.Windows.Forms.Button();
            this.grpBoxLosowanie = new System.Windows.Forms.GroupBox();
            this.btnLosuj = new System.Windows.Forms.Button();
            this.textBoxDo = new System.Windows.Forms.TextBox();
            this.textBoxOd = new System.Windows.Forms.TextBox();
            this.lblZakresDo = new System.Windows.Forms.Label();
            this.lblZakresOd = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.grpBoxLosowanie.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnNowaGra
            // 
            this.btnNowaGra.Location = new System.Drawing.Point(13, 13);
            this.btnNowaGra.Name = "btnNowaGra";
            this.btnNowaGra.Size = new System.Drawing.Size(75, 23);
            this.btnNowaGra.TabIndex = 0;
            this.btnNowaGra.Text = "Nowa gra";
            this.btnNowaGra.UseVisualStyleBackColor = true;
            this.btnNowaGra.Click += new System.EventHandler(this.btnNowaGra_Click);
            // 
            // grpBoxLosowanie
            // 
            this.grpBoxLosowanie.Controls.Add(this.btnLosuj);
            this.grpBoxLosowanie.Controls.Add(this.textBoxDo);
            this.grpBoxLosowanie.Controls.Add(this.textBoxOd);
            this.grpBoxLosowanie.Controls.Add(this.lblZakresDo);
            this.grpBoxLosowanie.Controls.Add(this.lblZakresOd);
            this.grpBoxLosowanie.Location = new System.Drawing.Point(13, 52);
            this.grpBoxLosowanie.Name = "grpBoxLosowanie";
            this.grpBoxLosowanie.Size = new System.Drawing.Size(287, 121);
            this.grpBoxLosowanie.TabIndex = 1;
            this.grpBoxLosowanie.TabStop = false;
            this.grpBoxLosowanie.Text = "Losowanie";
            this.grpBoxLosowanie.Visible = false;
            // 
            // btnLosuj
            // 
            this.btnLosuj.Location = new System.Drawing.Point(206, 46);
            this.btnLosuj.Name = "btnLosuj";
            this.btnLosuj.Size = new System.Drawing.Size(75, 23);
            this.btnLosuj.TabIndex = 2;
            this.btnLosuj.Text = "Wylosuj";
            this.btnLosuj.UseVisualStyleBackColor = true;
            this.btnLosuj.Click += new System.EventHandler(this.btnLosuj_Click);
            // 
            // textBoxDo
            // 
            this.textBoxDo.Location = new System.Drawing.Point(87, 74);
            this.textBoxDo.Name = "textBoxDo";
            this.textBoxDo.Size = new System.Drawing.Size(100, 20);
            this.textBoxDo.TabIndex = 3;
            this.textBoxDo.Text = "100";
            // 
            // textBoxOd
            // 
            this.textBoxOd.Location = new System.Drawing.Point(87, 25);
            this.textBoxOd.Name = "textBoxOd";
            this.textBoxOd.Size = new System.Drawing.Size(100, 20);
            this.textBoxOd.TabIndex = 2;
            this.textBoxOd.Text = "1";
            // 
            // lblZakresDo
            // 
            this.lblZakresDo.AutoSize = true;
            this.lblZakresDo.Location = new System.Drawing.Point(23, 77);
            this.lblZakresDo.Name = "lblZakresDo";
            this.lblZakresDo.Size = new System.Drawing.Size(58, 13);
            this.lblZakresDo.TabIndex = 1;
            this.lblZakresDo.Text = "Zakres do:";
            // 
            // lblZakresOd
            // 
            this.lblZakresOd.AutoSize = true;
            this.lblZakresOd.Location = new System.Drawing.Point(23, 28);
            this.lblZakresOd.Name = "lblZakresOd";
            this.lblZakresOd.Size = new System.Drawing.Size(58, 13);
            this.lblZakresOd.TabIndex = 0;
            this.lblZakresOd.Text = "Zakres od:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(200, 51);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Sprawdź";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(40, 51);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(87, 20);
            this.textBox1.TabIndex = 3;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(267, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Liczba została wylosowana teraz spróbuij ją odgadnąć!";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(41, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Jak myślisz?";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Location = new System.Drawing.Point(19, 189);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(281, 131);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Wynik";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(219, 327);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "Zakończ";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(200, 95);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 6;
            this.button3.Text = "Poddaj się";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(322, 362);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grpBoxLosowanie);
            this.Controls.Add(this.btnNowaGra);
            this.Name = "Form1";
            this.Text = "Zgadywanka";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpBoxLosowanie.ResumeLayout(false);
            this.grpBoxLosowanie.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnNowaGra;
        private System.Windows.Forms.GroupBox grpBoxLosowanie;
        private System.Windows.Forms.Button btnLosuj;
        private System.Windows.Forms.TextBox textBoxDo;
        private System.Windows.Forms.TextBox textBoxOd;
        private System.Windows.Forms.Label lblZakresDo;
        private System.Windows.Forms.Label lblZakresOd;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}

