using System;
using System.Windows.Forms;

namespace JohannesFortmann
{
    public partial class Form1 : Form
    {
        private double[,] bmiSave = new double[100, 2];

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void btn_berechnen_Click(object sender, EventArgs e)
        {
            bool _gewichtPars = double.TryParse(txt_gewicht.Text, out double _gewicht);
            bool _groessePars = double.TryParse(txt_goesse.Text, out double _groesse);
            double _bmi;

            if (_groessePars && _gewichtPars)
            {
                if ((_groesse >= 1 && _groesse <= 2.5) && (_gewicht >= 30 && _gewicht <= 200))
                {
                    _bmi = ErrechneBmiWert(_groesse, _gewicht);
                    txt_bmi.Text = _bmi.ToString();
                    lab_bewertung.Text = BmiAuswertung(_bmi);
                    ArrayAddBmi(_gewicht, _groesse);
                    lab_durchnitGrosse.Text = BerechneDurchscnitsgroesse(bmiSave).ToString();
                }
                else
                    MessageBox.Show("BMI kann nicht erechnet weden, da Größe nicht zwischen (1m - 2,5m) oder Gewicht nicht zwischen (30kg - 200kg) liegt.");
            }
            else
                MessageBox.Show("Eingabe nicht nur Zahlen");
        }

        private double ErrechneBmiWert(double groesse, double gewicht)
        {
            double _bmi = gewicht / (groesse * groesse);
            return Math.Round(_bmi, 2);
        }
        private double BerechneDurchscnitsgroesse(double[,] bmiDaten)
        {
            double _summe = 0;
            for (int i = 0; i < bmiDaten.Length / 2; i++)
            {
                if (bmiDaten[i, 0] == 0)
                    return Math.Round((_summe / i), 2);
                _summe = _summe + bmiDaten[i, 0];
            }
            return Math.Round((_summe / 100), 2);
        }

        private void ArrayAddBmi(double gewicht, double goesse)
        {
            for (int i = 0; i < bmiSave.Length / 2; i++)
            {
                if (bmiSave[i, 0] == 0)
                {
                    bmiSave[i, 0] = goesse;
                    bmiSave[i, 1] = gewicht;
                    return;
                }
            }
            MessageBox.Show("Mehr als 100 Werte");
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