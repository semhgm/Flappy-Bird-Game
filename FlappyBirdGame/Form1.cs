using System;
using System.Drawing;
using System.Windows.Forms;

namespace FlappyBirdGame
{
    public partial class Form1 : Form
    {
        float pipeSpeed = 3f;      // Boruların hızı (düşük hız)
        float gravity = 0.5f;      // Yerçekimi etkisi (daha düşük)
        float birdVelocity = 0f;    // Kuşun anlık hızı
        int score = 0;              // Skor takibi
        bool gameStarted = false;   // Oyun başladı mı kontrolü

        public Form1()
        {
            InitializeComponent();
            this.KeyPreview = true; // Tuş olaylarını yakalamak için
            this.KeyDown += new KeyEventHandler(Form1_KeyDown);
            this.KeyUp += new KeyEventHandler(Form1_KeyUp);

            // Zamanlayıcı ayarları
            timerControl.Interval = 20;  // 20 ms aralık
            timerControl.Tick += new EventHandler(GameTimer);
            timerControl.Stop(); // Oyun başta durdurulmuş olacak
        }

        private void GameTimer(object sender, EventArgs e)
        {
            // Kuşun hareketi
            birdVelocity += gravity; // Yerçekimi etkisi
            pBoxBird.Top += (int)birdVelocity; // Kuşun yukarı hareketi (type casting)

            // Boruların sola hareketi
            pBoxDown.Left -= (int)pipeSpeed; // Alt boru
            pBoxTop.Left -= (int)pipeSpeed; // Üst boru

            // Skoru güncelle
            lblScore.Text = "SCORE: " + score;

            // Boruların ekran dışına çıkma kontrolü
            if (pBoxDown.Left < -150) // Alt boru ekran dışına çıkarsa
            {
                pBoxDown.Left = 800; // Sağdan tekrar getir
                score++; // Skoru artır
            }

            if (pBoxTop.Left < -150) // Üst boru ekran dışına çıkarsa
            {
                pBoxTop.Left = 800; // Sağdan tekrar getir
                score++; // Skoru artır
            }

            // Çarpışma kontrolü
            if (pBoxBird.Top < -50 || // Tavana çarpma kontrolü için yeni değer
                pBoxBird.Bounds.IntersectsWith(pBoxDown.Bounds) ||
                pBoxBird.Bounds.IntersectsWith(pBoxGround.Bounds) ||
                pBoxBird.Bounds.IntersectsWith(pBoxTop.Bounds))
            {
                EndGame();
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                if (!gameStarted)
                {
                    StartGame(); // Oyunu başlat
                }
                birdVelocity = -10f; // Kuş yukarı zıplar (type casting)
            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            // Tuş bırakıldığında işlem yapılmaz
        }

        private void StartGame()
        {
            gameStarted = true; // Oyun başladı olarak işaretle
            timerControl.Start(); // Zamanlayıcıyı başlat
            lblScore.Text = "SCORE: 0"; // Skor sıfırlanır
            birdVelocity = 0f; // Kuşun başlangıç hızı sıfır
        }

        public void EndGame()
        {
            timerControl.Stop(); // Zamanlayıcıyı durdur
            lblScore.Text = "GAME OVER! SCORE: " + score; // Oyun bitti mesajı
            gameStarted = false; // Oyun yeniden başlatılabilir
        }
    }
}
