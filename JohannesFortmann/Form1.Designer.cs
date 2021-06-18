
namespace JohannesFortmann
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lab_bewertung = new System.Windows.Forms.Label();
            this.lab_durchnitGrosse = new System.Windows.Forms.Label();
            this.btn_berechnen = new System.Windows.Forms.Button();
            this.txt_gewicht = new System.Windows.Forms.TextBox();
            this.txt_goesse = new System.Windows.Forms.TextBox();
            this.txt_bmi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(101, 224);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(198, 41);
            this.label2.TabIndex = 1;
            this.label2.Text = "Gewicht in kg";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(101, 296);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(165, 41);
            this.label3.TabIndex = 2;
            this.label3.Text = "Größe in m";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(101, 450);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(155, 41);
            this.label4.TabIndex = 3;
            this.label4.Text = "BMI-Index";
            // 
            // lab_bewertung
            // 
            this.lab_bewertung.AutoSize = true;
            this.lab_bewertung.Location = new System.Drawing.Point(561, 390);
            this.lab_bewertung.Name = "lab_bewertung";
            this.lab_bewertung.Size = new System.Drawing.Size(0, 41);
            this.lab_bewertung.TabIndex = 4;
            // 
            // lab_durchnitGrosse
            // 
            this.lab_durchnitGrosse.AutoSize = true;
            this.lab_durchnitGrosse.Location = new System.Drawing.Point(561, 447);
            this.lab_durchnitGrosse.Name = "lab_durchnitGrosse";
            this.lab_durchnitGrosse.Size = new System.Drawing.Size(0, 41);
            this.lab_durchnitGrosse.TabIndex = 5;
            // 
            // btn_berechnen
            // 
            this.btn_berechnen.Location = new System.Drawing.Point(561, 224);
            this.btn_berechnen.Name = "btn_berechnen";
            this.btn_berechnen.Size = new System.Drawing.Size(188, 113);
            this.btn_berechnen.TabIndex = 6;
            this.btn_berechnen.Text = "Berechnen";
            this.btn_berechnen.UseVisualStyleBackColor = true;
            this.btn_berechnen.Click += new System.EventHandler(this.btn_berechnen_Click);
            // 
            // txt_gewicht
            // 
            this.txt_gewicht.Location = new System.Drawing.Point(305, 224);
            this.txt_gewicht.Name = "txt_gewicht";
            this.txt_gewicht.Size = new System.Drawing.Size(250, 47);
            this.txt_gewicht.TabIndex = 7;
            this.txt_gewicht.Text = "80";
            // 
            // txt_goesse
            // 
            this.txt_goesse.Location = new System.Drawing.Point(305, 290);
            this.txt_goesse.Name = "txt_goesse";
            this.txt_goesse.Size = new System.Drawing.Size(250, 47);
            this.txt_goesse.TabIndex = 8;
            this.txt_goesse.Text = "1.80";
            // 
            // txt_bmi
            // 
            this.txt_bmi.Location = new System.Drawing.Point(305, 444);
            this.txt_bmi.Name = "txt_bmi";
            this.txt_bmi.Size = new System.Drawing.Size(250, 47);
            this.txt_bmi.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("SimSun-ExtB", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(359, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(485, 80);
            this.label1.TabIndex = 10;
            this.label1.Text = "BMI-RECHNER";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 41F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1198, 821);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_bmi);
            this.Controls.Add(this.txt_goesse);
            this.Controls.Add(this.txt_gewicht);
            this.Controls.Add(this.btn_berechnen);
            this.Controls.Add(this.lab_durchnitGrosse);
            this.Controls.Add(this.lab_bewertung);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "Form1";
            this.Text = "BMI-Rechner";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lab_bewertung;
        private System.Windows.Forms.Label lab_durchnitGrosse;
        private System.Windows.Forms.Button btn_berechnen;
        private System.Windows.Forms.TextBox txt_gewicht;
        private System.Windows.Forms.TextBox txt_goesse;
        private System.Windows.Forms.TextBox txt_bmi;
        private System.Windows.Forms.Label label1;
    }
}

