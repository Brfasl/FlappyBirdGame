using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;    //Gerekli Kütühaneler

namespace FlappyBirdGame
{
    public partial class Form1 : Form
    {
        int pipeSpeed = 8;  // Boruların hareket hızını belirleyen değişken.

        int gravity = 15;   // Kuşun yer çekimi hızını belirleyen değişken.

        int highScore = 0;  // Rekoru saklayan değişken.

        int score = 0;      //  Skoru tutan değişken.

        public Form1()
        {
            InitializeComponent();  // Formun bileşenlerini başlatıyoruz.Tüm bileşenlerin düzgün çalışması için gerekli olan başlangıç ayarlarını yapar.
        }

        private void gameTimerEvent(object sender, EventArgs e)
        {
            theBird.Top += gravity;  // Kuşun düşme hızını kontrol ediyoruz.
            pipeBottom.Left -= pipeSpeed;   // Alt borunun sola doğru hareket etmesini sağlıyoruz.
            pipeTop.Left -= pipeSpeed;      // Üst borunun sola doğru hareket etmesini sağlıyoruz.
            scoreText.Text = "Score: " + score + "\n";    // Skoru ekranda güncelliyoruz.

            if (pipeBottom.Left < -150)    // Alt boru ekranın solundan çıktığında.
            {
                pipeBottom.Left = 800;    // Alt boruyu başlangıç noktasına geri getiriyoruz.
                score++;  //Skoru 1 artırıyoruz.
            }
            if (pipeTop.Left < -180)   // Üst boru ekranın solundan çıktığında.
            {
                pipeTop.Left = 950;    // Üst boruyu başlangıç noktasına geri getiriyoruz.
                score++;

            }
            if (theBird.Bounds.IntersectsWith(pipeBottom.Bounds) || // Kuş alt boruya çarptıysa,
                theBird.Bounds.IntersectsWith(pipeTop.Bounds) ||    // Kuş üst boruya çarptıysa,
                theBird.Bounds.IntersectsWith(theGround.Bounds) ||   // Kuş yere çarptıysa,
                theBird.Top < -25)                                  // Kuş ekranın üstünden çıktıysa,
            {
                endGame();   // Oyunu bitir.

            }
            // Skor 10'un katlarına ulaştıkça hızı artır
            if (score > 0 && score % 10 == 0)
            {
                pipeSpeed += 2;  // Boruların hızını artırıyoruz (örneğin her 10 puanda 2 birim artır).
                score++;  // Bu durumda skoru bir kez daha artırma; bu, hız artışı tetiklemek için.
            }

        }

        private void gamekeyisdown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)    // Eğer basılan tuş 'Space' ise,
            {
                if (gameTimer.Enabled == false) // Eğer oyun durduysa (timer çalışmıyorsa)
                {
                    resetGame();   // Oyunu yeniden başlatıyoruz.
                }
                else
                {
                    gravity = -15;    // Oyun aktifse, kuşun yukarı hareket etmesini sağlıyoruz.
                }
            }


        }

        private void gamekeyisup(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                gravity = 15;      // Kuşun tekrar aşağı doğru düşmesini sağlıyoruz.

            }


        }
        private void endGame()   // Oyun bittiğinde çalışan metot.
        {
            gameTimer.Stop();    // Oyun zamanlayıcısını durduruyoruz.

            if (score > highScore)
            {
                highScore = score; // Eğer mevcut skor rekoru geçtiyse, rekoru güncelliyoruz.

                scoreText.Text += "Tebrikler rekor kırdınız.\nGame Over!!! \nHigh Score: " + highScore;  // Ekrana skoru,'Tebrikler rekor kırdınız.Game Over!!!' ve rekoru yazdırıyoruz.

            }
            else

                // Ekrana 'Game Over' ve rekoru yazdırıyoruz.
                scoreText.Text += "Rekoru Geçemediniz.\nGame Over!!! \nHigh Score: " + highScore;
        }
        private void resetGame()
        {
            // Oyun başlama ayarlarını sıfırlıyoruz.
            gravity = 15; // Kuşun yerçekimini varsayılana getiriyoruz.
            pipeSpeed = 8; // Boru hızını varsayılana getiriyoruz.
            score = 0; // Skoru sıfırlıyoruz.
            scoreText.Text = "Score: " + score; // Skoru ekrana yazdırıyoruz.

            // Kuşun ve boruların başlangıç pozisyonlarını ayarlıyoruz.
            theBird.Top = 100; // Kuşun pozisyonunu başlangıç noktasına getiriyoruz.
            pipeBottom.Left = 800; // Alt boruyu başlangıç pozisyonuna getiriyoruz.
            pipeTop.Left = 950; // Üst boruyu başlangıç pozisyonuna getiriyoruz.

            // Oyun zamanlayıcısını yeniden başlatıyoruz.
            gameTimer.Start();
        }


    }
}
