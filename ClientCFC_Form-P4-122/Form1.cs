using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ServiceModel;
using ServiceMtk_P2_20180140122;

namespace ClientCFC_Form_P4_122
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            BasicHttpBinding bind = new BasicHttpBinding();
            ChannelFactory<IMatematika> objChannel = new ChannelFactory<IMatematika>(bind, "http://localhost:1919");
            IMatematika obj = objChannel.CreateChannel();
            double hasilTambah = obj.Tambah(1, 2);
            textBox1.Text = hasilTambah.ToString();
            textBox1.ReadOnly = true;

            double hasilKurang = obj.Kurang(3, 2);
            textBox2.Text = hasilKurang.ToString();
            textBox2.ReadOnly = true;

            double hasilKali = obj.Kali(2, 2);
            textBox3.Text = hasilKali.ToString();
            textBox3.ReadOnly = true;

            double hasilBagi = obj.Bagi(2, 2);
            textBox4.Text = hasilBagi.ToString();
            textBox4.ReadOnly = true;

            Koordinat objk = new Koordinat();

        }
    }
}
