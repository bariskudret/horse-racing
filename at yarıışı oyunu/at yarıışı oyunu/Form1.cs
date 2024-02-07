using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace at_yarıışı_oyunu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //label'ların "otosize" larını false yaptıkki kendi boyutumuzu ayarlayabilelim.
        private void Form1_Load(object sender, EventArgs e)
        {
            int birinciatuzaklık = atBir.Left; // pixselin sayfanın "sola" uzaklığnı verir.
            int ikinciatuzaklık = atİki.Left;
            int ucuncuatuzaklık = atuc.Left;

        }

        private void start_Click(object sender, EventArgs e)
        {
            timer1.Enabled=true; // tuşa basınca timer aktif hale gelip çalışmaya başlar
            // timer bi tür void loop gibidir sonsuz dökü içerir .
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Random random = new Random();
            atBir.Left = atBir.Left + random.Next(3,15);// 3 ve 15 arasnda rast gele sayı üretik ve bunu yürütmek için kullandık
            atİki.Left = atİki.Left + random.Next(3,15);
            atuc.Left = atuc.Left + random.Next(3,15);

            if(atBir.Left +atBir.Width >=bitis.Left) // names.width bize resmin genişliğini verir.
            {
                timer1.Enabled = false; // timer'i durdurmak için false kullanık demeseydik  messagbox kısmı ard arda çıkıp pc i çökertirdi.

                MessageBox.Show(" yarışı birinci at kazanmıştır!!");
            }
            if(atİki.Left + atİki.Width >=bitis.Left)
            {
                timer1.Enabled = false;
                MessageBox.Show("yarışı ikinci at kazanmıştır!!");
            }
            if(atuc.Left + atuc.Width >=bitis.Left)
            {
                timer1.Enabled = false;
                MessageBox.Show("yarışı üçüncü at kazanmıştır!!");


            }











        }




    }
}
