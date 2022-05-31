using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TelefonUygulamasıDersteYapılan
{
    public partial class Form1 : Form
    {

        telefonrehberi _tr;
        public Form1()
        {
            InitializeComponent();
            _tr = new telefonrehberi();
            TestVeri();
            LıstGuncelle();
        }
        private void LıstGuncelle()
        {
            listBox1.Items.Clear();
            foreach (Kayıt k in _tr._tellist)
            {
                listBox1.Items.Add(k.ToString());
            }
        }

        private void TestVeri()
        {
            _tr.Ekle(new Kayıt("Aykan Sarıdoğan", "05459692615"));
            _tr.Ekle(new Kayıt("Mahir Ölmez", "05422565896"));
            _tr.Ekle(new Kayıt("Tayyar Calışkan", "05421568962"));
        }

        private void Form1_Load(object sender, EventArgs e)
        {
         
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Kayıt k = new Kayıt(textBox1.Text, textBox2.Text);
            _tr.Ekle(k);
            LıstGuncelle();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int pos = listBox1.SelectedIndex;
            _tr.Sil(pos);
            LıstGuncelle();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Kayıt k = new Kayıt(textBox1.Text, textBox2.Text);
            _tr.Duzelt(listBox1.SelectedIndex, k);
            LıstGuncelle();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Kayıt k = _tr.getKayıt(listBox1.SelectedIndex);
            textBox1.Text = k.adisoyadi;
            textBox2.Text = k.telno;
        }
    }
}
