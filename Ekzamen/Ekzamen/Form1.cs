using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Label = System.Windows.Forms.Label;

namespace Ekzamen
{

    public partial class Form1 : Form
    {
        private Label label = new Label();
        private int score = 0;
        private int level = 1;
        private Timer timer;
        private Random random = new Random();
        private Label[,] labels = new Label[3, 4];
        private int[,] num = new int[3, 4];
        private int _heigth = 3;
        private int _width = 4;
        private int box_size = 80;
        private int CountChoise = 0;
        private bool flag = true;
        public Form1()
        {
            InitializeComponent();

            timer = new Timer();
            generateMap();
            timer.Interval = 1000; // Интервал таймера в миллисекундах (1 секунда)
            timer.Tick += Timer_Tick;
            timer.Start();
            UpdateTimeLabel();
            UpdateScoreLabel();
            UpdateLevelLabel();
        }

        private void generateMap()
        {
            int y = 0;

            for (int i = 0; i< _heigth * box_size; i+=box_size)
            {
                int x = 0;
                for (int j = 0; j < _width*box_size; j+=box_size)
                {
                    Label pic = new Label();
                    pic.BackColor = Color.Green;
                    pic.Text = "";
                    pic.Location = new Point(100+j, 100 + i);
                    pic.Size = new Size(50, 30);
                    pic.MouseClick += label_Click;
                    num[y, x] = 0;
                    labels[y, x] = pic;
                    this.Controls.Add(pic);

                    x++;
                }
                y++;
            }
            DoNumber(labels);
        }


        private void label_Click(object sender, EventArgs e)
        {

            // Получаем ссылку на Label, на которую был сделан клик
            Label clickedLabel = (Label)sender;

            clickedLabel.BackColor = Color.Red;
            CountChoise +=1;
            clickedLabel.Text = CountChoise.ToString();
            for (int i = 0; i<3; i++)
            {
                for (int j = 0; j< 4; j++)
                {
                    if (clickedLabel.Name == labels[i, j].Name)
                    {
                        // if (labels[i,j].Text== )
                    }
                }
            }
            // Вызываем функцию для изменения цвета Label
        }
        private void DoNumber(Label[,] labels)
        {
            random = new Random();
            //int n = random.Next(1, 9);

            int n = 5;
            for (int i = 1; i <= n; i++)
            {
                int col = random.Next(0, 3);
                int row = random.Next(0, 2);

                MessageBox.Show($"{col}, {row}");
                if (labels[col, row].Text != "")
                {
                    i -= 1;
                }
                else
                {
                    labels[col, row].Text = i.ToString();
                    num[col, row] = i;
                }

            }
        }


        //private void CreateLabelManager()
        //{
        //    labelArray = new Label[,]
        //{
        //    { label1, label2, label3, label4 },
        //    { label5, label6, label7, label8 },
        //    { label9, label10, label11, label12 }
        //};

        //    // Создаем экземпляр LabelManager с массивом labelArray
        //    labelManager = new LabelManager(labelArray);
        //}


        private void UpdateLevelLabel()
        {
            labelLevel.Text = "Level: " + level.ToString();
        }

        private void UpdateScoreLabel()
        {
            labelScore.Text = "Score: " + score.ToString();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            UpdateTimeLabel();

        }


        private void UpdateTimeLabel()
        {
            labelTime.Text = "Time: " + DateTime.Now.ToString("HH:mm:ss");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    labels[i, j].Text = "";
                }
            }
        }
    }

}
