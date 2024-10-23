using HungManGame.Properties;
using System.IO;
namespace HungManGame
{
    public partial class Form1 : Form
    {

        //random world for user
        String[] World = {
        "b,a,l,a,n,c,e",  
        "d,e,c,i,s,i,o,n", 
        "f,r,e,e,d,o,m",   
        "r,e,s,p,o,n,s,e", 
        "p,r,o,b,l,e,m",   
        "s,o,l,u,t,i,o,n", 
        "p,a,t,i,e,n,c,e", 
        "c,h,a,n,g,e",     
        "p,r,o,g,r,e,s,s", 
        "f,a,m,i,l,y",     
        "f,r,i,e,n,d,s",   
        "s,t,r,e,n,g,t,h", 
        "t,r,u,t,h",       
         "v,i,c,t,o,r,y",   
        "h,o,p,e"          
        };
        //create the value and the arrays
        Random rand = new Random();
        int randNum;
        String randWorld;
        String[] array;
        String[] copyCatArray;
        int health = 10;

        //chek of the user guess
        private void checkOfLetter(char userGuess)
        {
            // Eğer sağlık 0'a eşitse, oyun sona erer ve "Game Over" mesajı gösterilir
            if (health == 0) {
                MessageBox.Show("Game Over");
                return;
            }
                // Kullanıcının girdiği harfin bulunup bulunmadığını takip eden değişken
            bool found = false; 
                // Orijinal kelimede her harfi kontrol etmek için döngü
            for (int e = 0; e < array.Length; e++)
            {
                //girilen harf  orijinal kelimedeki harfe eşitse
                if (Convert.ToString(userGuess) == array[e])
                {
                    //şifrelenmiş dizide uygun yere koy
                    copyCatArray[e] = Convert.ToString(userGuess);
                    found = true;
                }
            }
            // // Şifrelenmiş harflerin ilerleyişini göstermek için labeli güncelle
            labelUncoded.Text = String.Join(" ", copyCatArray);

            // if user checked wrong letter 
            if (found == false && health != 0)
            {
                --health; // can sayisi azaltir 
                labelHealth.Text = String.Join(" ", health);// Sağlık durumunu göster

                // can sayisina gore resimleri degistir
                switch (health)
                {
                    case 9:
                        pic0.Image = Properties.Resources._1;
                        break;
                    case 8:
                        pic0.Image = Properties.Resources._2;
                        break;
                    case 7:
                        pic0.Image = Properties.Resources._3;
                        break;
                    case 6:
                        pic0.Image = Properties.Resources._4;
                        break;
                    case 5:
                        pic0.Image = Properties.Resources._5;
                        break;
                    case 4:
                        pic0.Image = Properties.Resources._6;
                        break;
                    case 3:
                        pic0.Image = Properties.Resources._7;
                        break;
                    case 2:
                        pic0.Image = Properties.Resources._8;
                        break;
                    case 1:
                        pic0.Image = Properties.Resources._9;
                        break;
                    case 0:
                        pic0.Image = Properties.Resources._10;//she dead
                        break;

                }
            }
            // health sifir oldugunda alttaki cumleyi goster
            if (health == 0)
            {
                labelOyunBitti.Text = "OYUN BITTI TEKRAR DENEYINIZ";
            }
        }


        //this is constractur
        public Form1()
        {
            InitializeComponent();
            
            randNum = rand.Next(0, 4);//0'dan 3'e random sayi olusturmak
            randWorld = World[randNum];//random bir kelime saklamak 

            //this array for storage the split world
            array = randWorld.Split(',');

            //this copyCatArray for storage the split encoded world
            copyCatArray = randWorld.Split(',');
            for (int c = 0; c < copyCatArray.Length; c++)
            {
                copyCatArray[c] = "_";

            }
     
            //kullanciya sifrelenmis kelimeyi goster,,,  for Strig join  _ _ _ _ _
            labelUncoded.Text = String.Join(" ", copyCatArray);

        }
        //kullanici "ok" bastiginda buraya goturur
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBoxHarf.Text.Length > 0)  //للتاكد من وجود حرف داخل التكست بوكس
                checkOfLetter(Convert.ToChar(textBoxHarf.Text)); //استدعاء الميتود للتاكد من الحرف اذا موجود في الكلمة

            textBoxHarf.Clear();
        }

        private void textBoxHarf_KeyPress(object sender, KeyPressEventArgs e)
        {
            // السماح بالحروف فقط وحذف الحرف الأخير (Backspace)
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true; // يمنع الأحرف غير المسموح بها
            }

            // السماح بإدخال حرف واحد فقط
            if (textBoxHarf.Text.Length >= 1 && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true; // يمنع إدخال أكثر من حرف
            }
        }
        //*****/ a b c ... طريقة الكيبورد على الشاشة
        
        private void labelAHarf_Click(object sender, EventArgs e)
        {
            checkOfLetter(Convert.ToChar(labelAHarf.Text));
            labelAHarf.Visible = false;

        }
        private void labelB_Click(object sender, EventArgs e)
        {
            checkOfLetter(Convert.ToChar(labelB.Text));
            labelB.Visible = false;
        }
        private void labelC_Click(object sender, EventArgs e)
        {
            checkOfLetter(Convert.ToChar(labelC.Text));
            labelC.Visible = false;
        }

        private void labelC1_Click(object sender, EventArgs e)
        {
            checkOfLetter(Convert.ToChar(labelC1.Text));
            labelC1.Visible = false;
        }

        private void labelD_Click(object sender, EventArgs e)
        {
            checkOfLetter(Convert.ToChar(labelD.Text));
            labelD.Visible = false;
        }

        private void labelE_Click(object sender, EventArgs e)
        {
            checkOfLetter(Convert.ToChar(labelE.Text));
            labelE.Visible = false;
        }

        private void labelF_Click(object sender, EventArgs e)
        {
            checkOfLetter(Convert.ToChar(labelF.Text));
            labelF.Visible = false;
        }

        private void labelG_Click(object sender, EventArgs e)
        {
            checkOfLetter(Convert.ToChar(labelG.Text));
            labelG.Visible = false;
        }

        private void labelg2_Click(object sender, EventArgs e)
        {
            checkOfLetter(Convert.ToChar(labelg2.Text));
            labelg2.Visible = false;
        }

        private void labelH_Click(object sender, EventArgs e)
        {
            checkOfLetter(Convert.ToChar(labelH.Text));
            labelH.Visible = false;
        }

        private void labelI_Click(object sender, EventArgs e)
        {
            checkOfLetter(Convert.ToChar(labelI.Text));
            labelI.Visible = false;
        }

        private void label1I2_Click(object sender, EventArgs e)
        {
            checkOfLetter(Convert.ToChar(label1I2.Text));
            label1I2.Visible = false;
        }

        private void labelJ_Click(object sender, EventArgs e)
        {
            checkOfLetter(Convert.ToChar(labelJ.Text));
            labelJ.Visible = false;
        }

        private void labelK_Click(object sender, EventArgs e)
        {
            checkOfLetter(Convert.ToChar(labelK.Text));
            labelK.Visible = false;
        }

        private void labelL_Click(object sender, EventArgs e)
        {
            checkOfLetter(Convert.ToChar(labelL.Text));
            labelL.Visible = false;
        }

        private void labelM_Click(object sender, EventArgs e)
        {
            checkOfLetter(Convert.ToChar(labelM.Text));
            labelM.Visible = false;
        }

        private void labelN_Click(object sender, EventArgs e)
        {
            checkOfLetter(Convert.ToChar(labelN.Text));
            labelN.Visible = false;
        }

        private void labelO_Click(object sender, EventArgs e)
        {
            checkOfLetter(Convert.ToChar(labelO.Text));
            labelO.Visible = false;
        }

        private void labelO2_Click(object sender, EventArgs e)
        {
            checkOfLetter(Convert.ToChar(labelO2.Text));
            labelO2.Visible = false;
        }

        private void labelP_Click(object sender, EventArgs e)
        {
            checkOfLetter(Convert.ToChar(labelP.Text));
            labelP.Visible = false;
        }

        private void labelR_Click(object sender, EventArgs e)
        {
            checkOfLetter(Convert.ToChar(labelR.Text));
            labelR.Visible = false;
        }

        private void labelS_Click(object sender, EventArgs e)
        {
            checkOfLetter(Convert.ToChar(labelS.Text));
            labelS.Visible = false;
        }

        private void labelS2_Click(object sender, EventArgs e)
        {
            checkOfLetter(Convert.ToChar(labelS2.Text));
            labelS2.Visible = false;
        }

        private void labelT_Click(object sender, EventArgs e)
        {
            checkOfLetter(Convert.ToChar(labelT.Text));
            labelT.Visible = false;
        }

        private void labelU_Click(object sender, EventArgs e)
        {
            checkOfLetter(Convert.ToChar(labelU.Text));
            labelU.Visible = false;
        }

        private void labelU2_Click(object sender, EventArgs e)
        {
            checkOfLetter(Convert.ToChar(labelU2.Text));
            labelU2.Visible = false;
        }

        private void labelV_Click(object sender, EventArgs e)
        {
            checkOfLetter(Convert.ToChar(labelV.Text));
            labelV.Visible = false;
        }

        private void labelY_Click(object sender, EventArgs e)
        {
            checkOfLetter(Convert.ToChar(labelY.Text));
            labelY.Visible = false;
        }

        private void labelZ_Click(object sender, EventArgs e)
        {
            checkOfLetter(Convert.ToChar(labelZ.Text));
            labelZ.Visible = false;
        }
    }
}
