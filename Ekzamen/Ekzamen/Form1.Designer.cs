namespace Ekzamen
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Panel panelTimeScoreLevel;
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.Label labelScore;
        private System.Windows.Forms.Label labelLevel;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }


        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelTimeScoreLevel = new System.Windows.Forms.Panel();
            this.labelLevel = new System.Windows.Forms.Label();
            this.labelScore = new System.Windows.Forms.Label();
            this.labelTime = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panelTimeScoreLevel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTimeScoreLevel
            // 
            this.panelTimeScoreLevel.Controls.Add(this.labelLevel);
            this.panelTimeScoreLevel.Controls.Add(this.labelScore);
            this.panelTimeScoreLevel.Controls.Add(this.labelTime);
            this.panelTimeScoreLevel.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTimeScoreLevel.Location = new System.Drawing.Point(0, 0);
            this.panelTimeScoreLevel.Name = "panelTimeScoreLevel";
            this.panelTimeScoreLevel.Size = new System.Drawing.Size(782, 50);
            this.panelTimeScoreLevel.TabIndex = 0;
            // 
            // labelLevel
            // 
            this.labelLevel.AutoSize = true;
            this.labelLevel.Location = new System.Drawing.Point(250, 18);
            this.labelLevel.Name = "labelLevel";
            this.labelLevel.Size = new System.Drawing.Size(46, 16);
            this.labelLevel.TabIndex = 2;
            this.labelLevel.Text = "Level: ";
            // 
            // labelScore
            // 
            this.labelScore.AutoSize = true;
            this.labelScore.Location = new System.Drawing.Point(120, 18);
            this.labelScore.Name = "labelScore";
            this.labelScore.Size = new System.Drawing.Size(49, 16);
            this.labelScore.TabIndex = 1;
            this.labelScore.Text = "Score: ";
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.Location = new System.Drawing.Point(12, 18);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(44, 16);
            this.labelTime.TabIndex = 0;
            this.labelTime.Text = "Time: ";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(696, 395);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "скрыть";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 453);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panelTimeScoreLevel);
            this.Name = "Form1";
            this.Text = "Scoreboard";
            this.panelTimeScoreLevel.ResumeLayout(false);
            this.panelTimeScoreLevel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
    }
}

