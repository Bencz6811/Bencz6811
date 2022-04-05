namespace HF
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
            this.btn_mentes = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cb_gyarisz = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cb_auto = new System.Windows.Forms.ComboBox();
            this.cb_tipus = new System.Windows.Forms.ComboBox();
            this.cb_motor = new System.Windows.Forms.ComboBox();
            this.cb_loero = new System.Windows.Forms.ComboBox();
            this.cb_nyomatek = new System.Windows.Forms.ComboBox();
            this.cb_uzemanyag = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_mentes
            // 
            this.btn_mentes.Location = new System.Drawing.Point(6, 226);
            this.btn_mentes.Name = "btn_mentes";
            this.btn_mentes.Size = new System.Drawing.Size(75, 23);
            this.btn_mentes.TabIndex = 0;
            this.btn_mentes.Text = "Mentés";
            this.btn_mentes.UseVisualStyleBackColor = true;
            this.btn_mentes.Click += new System.EventHandler(this.btn_mentes_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Gyáriszám:";
            // 
            // cb_gyarisz
            // 
            this.cb_gyarisz.FormattingEnabled = true;
            this.cb_gyarisz.Location = new System.Drawing.Point(106, 8);
            this.cb_gyarisz.Name = "cb_gyarisz";
            this.cb_gyarisz.Size = new System.Drawing.Size(121, 21);
            this.cb_gyarisz.TabIndex = 2;
            this.cb_gyarisz.SelectedIndexChanged += new System.EventHandler(this.Auto_adatok);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(53, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Autó:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(49, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Típus:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(46, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Motor:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(46, 127);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "Lóerő:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(16, 156);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 20);
            this.label6.TabIndex = 7;
            this.label6.Text = "Nyomaték:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.Location = new System.Drawing.Point(2, 184);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 20);
            this.label7.TabIndex = 8;
            this.label7.Text = "Üzemanyag:";
            // 
            // cb_auto
            // 
            this.cb_auto.FormattingEnabled = true;
            this.cb_auto.Location = new System.Drawing.Point(106, 40);
            this.cb_auto.Name = "cb_auto";
            this.cb_auto.Size = new System.Drawing.Size(121, 21);
            this.cb_auto.TabIndex = 9;
            this.cb_auto.SelectedIndexChanged += new System.EventHandler(this.Auto_adatok);
            // 
            // cb_tipus
            // 
            this.cb_tipus.FormattingEnabled = true;
            this.cb_tipus.Location = new System.Drawing.Point(106, 70);
            this.cb_tipus.Name = "cb_tipus";
            this.cb_tipus.Size = new System.Drawing.Size(121, 21);
            this.cb_tipus.TabIndex = 10;
            this.cb_tipus.SelectedIndexChanged += new System.EventHandler(this.Auto_adatok);
            // 
            // cb_motor
            // 
            this.cb_motor.FormattingEnabled = true;
            this.cb_motor.Location = new System.Drawing.Point(106, 99);
            this.cb_motor.Name = "cb_motor";
            this.cb_motor.Size = new System.Drawing.Size(121, 21);
            this.cb_motor.TabIndex = 11;
            this.cb_motor.SelectedIndexChanged += new System.EventHandler(this.Auto_adatok);
            // 
            // cb_loero
            // 
            this.cb_loero.FormattingEnabled = true;
            this.cb_loero.Location = new System.Drawing.Point(106, 129);
            this.cb_loero.Name = "cb_loero";
            this.cb_loero.Size = new System.Drawing.Size(121, 21);
            this.cb_loero.TabIndex = 12;
            this.cb_loero.SelectedIndexChanged += new System.EventHandler(this.Auto_adatok);
            // 
            // cb_nyomatek
            // 
            this.cb_nyomatek.FormattingEnabled = true;
            this.cb_nyomatek.Location = new System.Drawing.Point(106, 158);
            this.cb_nyomatek.Name = "cb_nyomatek";
            this.cb_nyomatek.Size = new System.Drawing.Size(121, 21);
            this.cb_nyomatek.TabIndex = 13;
            this.cb_nyomatek.SelectedIndexChanged += new System.EventHandler(this.Auto_adatok);
            // 
            // cb_uzemanyag
            // 
            this.cb_uzemanyag.FormattingEnabled = true;
            this.cb_uzemanyag.Location = new System.Drawing.Point(106, 186);
            this.cb_uzemanyag.Name = "cb_uzemanyag";
            this.cb_uzemanyag.Size = new System.Drawing.Size(121, 21);
            this.cb_uzemanyag.TabIndex = 14;
            this.cb_uzemanyag.SelectedIndexChanged += new System.EventHandler(this.Auto_adatok);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(184, 226);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 15;
            this.button2.Text = "Kilépés";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Bezar);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(271, 290);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.cb_uzemanyag);
            this.Controls.Add(this.cb_nyomatek);
            this.Controls.Add(this.cb_loero);
            this.Controls.Add(this.cb_motor);
            this.Controls.Add(this.cb_tipus);
            this.Controls.Add(this.cb_auto);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cb_gyarisz);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_mentes);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Autószervíz";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_mentes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cb_gyarisz;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cb_auto;
        private System.Windows.Forms.ComboBox cb_tipus;
        private System.Windows.Forms.ComboBox cb_motor;
        private System.Windows.Forms.ComboBox cb_loero;
        private System.Windows.Forms.ComboBox cb_nyomatek;
        private System.Windows.Forms.ComboBox cb_uzemanyag;
        private System.Windows.Forms.Button button2;
    }
}

