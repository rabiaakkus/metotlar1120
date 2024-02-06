using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace metotlar_1120
{
    internal class sekil
    {
        public int uzunKenar { get; set; }
        public int kısaKenar { get; set; }

        //parametre almayıp deger döndurmeyen 
        public void KareYaz()
        {
            int sonuc = this.kısaKenar * this.uzunKenar;
            MessageBox.Show($"seklin karesi:{sonuc}");


            //parametre alan deger döndürmeyen
        }
        public void SekilCiz(Button btn, Color renk)
        {
            btn.Width = this.uzunKenar;
            btn.Height = this.kısaKenar;
            btn.BackColor = renk;

        }
        public void mesajDegistir(Button btn, string mesaj)
        {
            btn.Text = mesaj;
        }

    }
}
