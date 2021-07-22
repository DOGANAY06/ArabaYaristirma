using Polymorphism_Yarıs.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Polymorphism_Yarıs
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnstart_Click(object sender, EventArgs e)
        {
            tm.Start(); //timer zamanlayıcı başlıcak
        }

        Mercedes mercedes = new Mercedes();  //her araba model class dan bir nesne ürettik
        BMW bmw = new BMW();
        Tofas tofas = new Tofas(); 
        private void tm_Tick(object sender, EventArgs e)
        { //bu nesneler location artması lazım sola doğru her hız birimi location eklenecek 
            lblmercedes.Left += mercedes.GetSpeed();
            lblbmw.Left += bmw.GetSpeed();
            lbltofas.Left += tofas.GetSpeed(); 
            if (lblmercedes.Right >= lblfinis.Left) //aracın  sağ tarafı finisin sol tarafına eşit olmalı ya da büyük
            {
                MessageBox.Show("Mercedes kazandı");
                tm.Stop(); //timer durur
                Application.Exit(); //uygulamayı kapatır
            }
            else if (lblbmw.Right >= lblfinis.Left)
            {
                MessageBox.Show("BMW kazandı");
                tm.Stop();
                Application.Exit();
            }
            else if (lbltofas.Right >= lblfinis.Left)
            {
                MessageBox.Show("TOFAŞ kazandı");
                tm.Stop();
                Application.Exit();
            }
          
        }

       
    }
}
