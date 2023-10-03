namespace wfmAnchor
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            pictureBox1=new PictureBox();
            pictureBox2=new PictureBox();
            pictureBox3=new PictureBox();
            pictureBox4=new PictureBox();
            button1=new Button();
            button2=new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image=(Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location=new Point(31, 32);
            pictureBox1.Name="pictureBox1";
            pictureBox1.Size=new Size(132, 125);
            pictureBox1.SizeMode=PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex=0;
            pictureBox1.TabStop=false;
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor=AnchorStyles.Top|AnchorStyles.Right;
            pictureBox2.Image=(Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location=new Point(507, 32);
            pictureBox2.Name="pictureBox2";
            pictureBox2.Size=new Size(132, 121);
            pictureBox2.SizeMode=PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex=1;
            pictureBox2.TabStop=false;
            // 
            // pictureBox3
            // 
            pictureBox3.Anchor=AnchorStyles.Bottom|AnchorStyles.Left;
            pictureBox3.Image=Properties.Resources.photo_2023_04_05_23_07_04__2_;
            pictureBox3.Location=new Point(12, 297);
            pictureBox3.Name="pictureBox3";
            pictureBox3.Size=new Size(156, 120);
            pictureBox3.SizeMode=PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex=2;
            pictureBox3.TabStop=false;
            // 
            // pictureBox4
            // 
            pictureBox4.Anchor=AnchorStyles.Bottom|AnchorStyles.Right;
            pictureBox4.Image=(Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location=new Point(451, 276);
            pictureBox4.Name="pictureBox4";
            pictureBox4.Size=new Size(170, 141);
            pictureBox4.SizeMode=PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex=3;
            pictureBox4.TabStop=false;
            // 
            // button1
            // 
            button1.Anchor=AnchorStyles.Top|AnchorStyles.Bottom|AnchorStyles.Left|AnchorStyles.Right;
            button1.Location=new Point(280, 173);
            button1.Name="button1";
            button1.Size=new Size(91, 54);
            button1.TabIndex=4;
            button1.Text="button1";
            button1.UseVisualStyleBackColor=true;
            // 
            // button2
            // 
            button2.Dock=DockStyle.Bottom;
            button2.Location=new Point(0, 412);
            button2.Name="button2";
            button2.Size=new Size(672, 33);
            button2.TabIndex=5;
            button2.Text="button2";
            button2.UseVisualStyleBackColor=true;
            // 
            // Form1
            // 
            AutoScaleDimensions=new SizeF(8F, 20F);
            AutoScaleMode=AutoScaleMode.Font;
            BackColor=Color.FromArgb(192, 255, 192);
            ClientSize=new Size(672, 445);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            MinimumSize=new Size(690, 492);
            Name="Form1";
            Text="Form1";
            Load+=Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private Button button1;
        private Button button2;
    }
}