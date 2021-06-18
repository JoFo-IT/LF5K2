using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JohannesFortmann
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private double ErrechneBmiWert(double groesse, double gewicht)
        {
            double _bmi = gewicht / (groesse * groesse);
            return _bmi;
        }

        private void btn_berechnen_Click(object sender, EventArgs e)
        {
            bool _gewichtPars = double.TryParse(txt_gewicht.Text, out double _gewicht);
            bool _groessePars = double.TryParse(txt_gewicht.Text, out double _groesse);
            double _bmi;

            if (_groessePars && _gewichtPars)
            {
                if ((_groesse >= 1 && _groesse <= 2.5) && (_gewicht >= 30 && _gewicht <= 200))
                {
                    _bmi = ErrechneBmiWert(_groesse, _gewicht);
                    txt_bmi.Text = txt_bmi.ToString();
                    lab_bewertung.Text = BmiAuswertung(_bmi);
                }
                else
                    MessageBox.Show("BMI kann nicht erechnet weden, da Größe nicht zwischen (1m - 2,5m) oder Gewicht nicht zwischen (30kg - 200kg) liegt.");
            }
            else
                MessageBox.Show("Eingabe nicht nur Zahlen");
        }
        private string BmiAuswertung(double bmi)
        {
            if (bmi < 19)
                return "Untergewicht";
            if (bmi < 25)
                return "Normalgewicht";
            if (bmi < 30)
                return "Übergewicht";
            return "Stark Übergewicht";
        }
    }
}
