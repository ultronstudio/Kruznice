using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Kruznice
{
    public partial class Form1 : Form
    {
        private int circleCount;
        private int minRadius;
        private Timer animationTimer;
        private int animationStep = 0;
        private bool isGrowing = true;

        public Form1()
        {
            InitializeComponent();

            // Inicializace časovače
            animationTimer = new Timer();
            animationTimer.Interval = 50; // Nastavení intervalu v milisekundách (rychlost animace)
            animationTimer.Tick += AnimationTimer_Tick;
        }

        private void btnDraw_Click(object sender, EventArgs e)
        {
            // Načtěte hodnoty z textových polí
            if (int.TryParse(txtCircleCount.Text, out circleCount) && int.TryParse(txtMinRadius.Text, out minRadius))
            {
                this.Invalidate(); // Překreslí okno
            }
            else
            {
                MessageBox.Show("Zadejte platná čísla.");
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            animationStep = 0; // Resetuje animaci
            isGrowing = true;
            animationTimer.Start(); // Spustí časovač
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            animationTimer.Stop(); // Zastaví časovač
            this.Invalidate(); // Překreslí okno, aby se animace zastavila
        }

        private void AnimationTimer_Tick(object sender, EventArgs e)
        {
            // Zvětšení nebo zmenšení radiusu
            if (isGrowing)
            {
                animationStep += 2; // Přidá k radiusu
                if (animationStep > 50) isGrowing = false; // Když dosáhne určité velikosti, začne se zmenšovat
            }
            else
            {
                animationStep -= 2; // Zmenší radius
                if (animationStep < -50) isGrowing = true; // Když je moc malý, začne se zvětšovat
            }

            this.Invalidate(); // Překreslí formulář s novým nastavením
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            if (circleCount > 0 && minRadius > 0)
            {
                Graphics g = e.Graphics;
                int width = this.ClientSize.Width;
                int height = this.ClientSize.Height;

                // Určíme střed
                Point center = new Point(width / 2, height / 2);
                int radiusStep = 10; // Krok mezi kružnicemi

                for (int i = 0; i < circleCount; i++)
                {
                    // Zvýšení/zmenšení velikosti podle animationStep
                    int radius = minRadius + i * radiusStep + animationStep;
                    g.DrawEllipse(Pens.Black, center.X - radius, center.Y - radius, radius * 2, radius * 2);
                }
            }
        }

        private void Form1_HelpButtonClicked(object sender, CancelEventArgs e)
        {
            MessageBox.Show($"Aplikace Kruznice\n2024 © Petr Vurm\n\nVytvořeno jako práce v hodině z předmětu PROGRAMOVÁNÍ na SPŠ Hradební.", "O aplikaci", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}