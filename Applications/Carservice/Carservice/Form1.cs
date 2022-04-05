using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace HF
{
    public partial class Form1 : Form
    {
        struct Kocsik
        {
            public string nev, tipus, motor, uzemanyag, gyariszam;
            public int le, nm;

            public Kocsik(string file)
            {
                string[] db = file.Split(';');
                nev = db[0];
                tipus = db[1];
                motor = db[2];
                le = int.Parse(db[3]);
                nm = int.Parse(db[4]);
                uzemanyag = db[5];
                gyariszam = db[6];
            }

            public Kocsik(string n, string t, string m, int l, int nmm, string u, string gy)
            {
                nev = n;
                tipus = t;
                motor = m;
                le = l;
                nm = nmm;
                uzemanyag = u;
                gyariszam = gy;
            }
        }

        List<Kocsik> kocsi;
        public Form1()
        {
            InitializeComponent();
            StreamReader sr = new StreamReader("Autok.txt");
            sr.ReadLine();
            kocsi = new List<Kocsik>();
            while (!sr.EndOfStream)
            {
                kocsi.Add(new Kocsik(sr.ReadLine()));
            }
            sr.Close();

            HashSet<string> tipusok = new HashSet<string>();
            HashSet<string> nevek = new HashSet<string>();
            HashSet<string> motorok = new HashSet<string>();
            HashSet<int> loero = new HashSet<int>();
            HashSet<int> nyomatek = new HashSet<int>();

            foreach (var item in kocsi)
            {
                cb_gyarisz.Items.Add(item.gyariszam);
                tipusok.Add(item.tipus);
                nevek.Add(item.nev);
                motorok.Add(item.motor);
                loero.Add(item.le);
                nyomatek.Add(item.nm);
            }

            foreach (var item in tipusok) cb_tipus.Items.Add(item);
            foreach (var item in nevek) cb_auto.Items.Add(item);
            foreach (var item in motorok) cb_motor.Items.Add(item);
            foreach (var item in loero) cb_loero.Items.Add(item);
            foreach (var item in nyomatek) cb_nyomatek.Items.Add(item);

            cb_uzemanyag.Items.Add("Diesel");
            cb_uzemanyag.Items.Add("Benzin");
        }

        private void btn_mentes_Click(object sender, EventArgs e)
        {
            bool van = false;
            StreamWriter sw = new StreamWriter("Autok.txt");
            sw.WriteLine("Név;Típus;Motor;LE;Nm;Üzemanyag;Gyáriszám");
            foreach (var item in kocsi)
            {
                if (item.gyariszam == cb_gyarisz.Text)
                {
                    van = true;
                    break;
                } else van = false;
            }

            if(!van)
            {
                if (cb_gyarisz.Text.Length == 17 && cb_auto.Text.Length > 0 && cb_loero.Text.Length > 0 && cb_motor.Text.Length > 0 && cb_nyomatek.Text.Length > 0 && cb_tipus.Text.Length > 0 && cb_uzemanyag.Text.Length > 0)
                {
                    kocsi.Add(new Kocsik(cb_auto.Text, cb_tipus.Text, cb_motor.Text, int.Parse(cb_loero.Text), int.Parse(cb_nyomatek.Text), cb_uzemanyag.Text, cb_gyarisz.Text));
                    MessageBox.Show("Autó rögzítve!", "Sikeres rögzítés", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("A gyáriszámnak 17 karakter hosszúnak kell lennie, illetve ne hagyjon semmit üresen!", "Sikertelen rögzítés", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Már létezik ilyen gyáriszámú autó!", "Sikertelen rögzítés", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            foreach (var item in kocsi)
            {
                sw.WriteLine($"{item.nev};{item.tipus};{item.motor};{item.le};{item.nm};{item.uzemanyag};{item.gyariszam}");
            }
            sw.Close();
        }

        private void Auto_adatok(object sender, EventArgs e)
        {
            foreach (var item in kocsi)
            {
                if (item.gyariszam == cb_gyarisz.Text)
                {
                    cb_auto.Text = item.nev;
                    cb_tipus.Text = item.tipus;
                    cb_loero.Text = item.le.ToString();
                    cb_nyomatek.Text = item.nm.ToString();
                    cb_motor.Text = item.motor;
                    cb_uzemanyag.Text = item.uzemanyag;
                }
            }
        }

        private void Bezar(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
