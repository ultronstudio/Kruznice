namespace Kruznice
{
    partial class Form1
    {
        /// <summary>
        /// Vyžaduje se proměnná návrháře.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Uvolněte všechny používané prostředky.
        /// </summary>
        /// <param name="disposing">hodnota true, když by se měl spravovaný prostředek odstranit; jinak false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kód generovaný Návrhářem Windows Form

        /// <summary>
        /// Metoda vyžadovaná pro podporu Návrháře - neupravovat
        /// obsah této metody v editoru kódu.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtCircleCount = new System.Windows.Forms.TextBox();
            this.lblCircleCount = new System.Windows.Forms.Label();
            this.txtMinRadius = new System.Windows.Forms.TextBox();
            this.lblMinRadius = new System.Windows.Forms.Label();
            this.btnDraw = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtCircleCount
            // 
            this.txtCircleCount.Location = new System.Drawing.Point(12, 26);
            this.txtCircleCount.Name = "txtCircleCount";
            this.txtCircleCount.Size = new System.Drawing.Size(100, 20);
            this.txtCircleCount.TabIndex = 0;
            // 
            // lblCircleCount
            // 
            this.lblCircleCount.AutoSize = true;
            this.lblCircleCount.Location = new System.Drawing.Point(12, 9);
            this.lblCircleCount.Name = "lblCircleCount";
            this.lblCircleCount.Size = new System.Drawing.Size(72, 13);
            this.lblCircleCount.TabIndex = 1;
            this.lblCircleCount.Text = "Počet kružnic";
            // 
            // txtMinRadius
            // 
            this.txtMinRadius.Location = new System.Drawing.Point(118, 26);
            this.txtMinRadius.Name = "txtMinRadius";
            this.txtMinRadius.Size = new System.Drawing.Size(100, 20);
            this.txtMinRadius.TabIndex = 2;
            // 
            // lblMinRadius
            // 
            this.lblMinRadius.AutoSize = true;
            this.lblMinRadius.Location = new System.Drawing.Point(118, 10);
            this.lblMinRadius.Name = "lblMinRadius";
            this.lblMinRadius.Size = new System.Drawing.Size(92, 13);
            this.lblMinRadius.TabIndex = 3;
            this.lblMinRadius.Text = "Minimální poloměr";
            // 
            // btnDraw
            // 
            this.btnDraw.Location = new System.Drawing.Point(12, 52);
            this.btnDraw.Name = "btnDraw";
            this.btnDraw.Size = new System.Drawing.Size(75, 23);
            this.btnDraw.TabIndex = 4;
            this.btnDraw.Text = "Vykreslit";
            this.btnDraw.UseVisualStyleBackColor = true;
            this.btnDraw.Click += new System.EventHandler(this.btnDraw_Click);
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(713, 12);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(75, 23);
            this.btnStop.TabIndex = 5;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(632, 12);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 6;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOrange;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnDraw);
            this.Controls.Add(this.lblMinRadius);
            this.Controls.Add(this.txtMinRadius);
            this.Controls.Add(this.lblCircleCount);
            this.Controls.Add(this.txtCircleCount);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.HelpButton = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kruznice";
            this.HelpButtonClicked += new System.ComponentModel.CancelEventHandler(this.Form1_HelpButtonClicked);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCircleCount;
        private System.Windows.Forms.Label lblCircleCount;
        private System.Windows.Forms.TextBox txtMinRadius;
        private System.Windows.Forms.Label lblMinRadius;
        private System.Windows.Forms.Button btnDraw;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnStart;
    }
}

