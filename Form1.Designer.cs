namespace Beetle_Game
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.imageList2 = new System.Windows.Forms.ImageList(this.components);
            this.picBoxBody = new System.Windows.Forms.PictureBox();
            this.picBoxHead = new System.Windows.Forms.PictureBox();
            this.picBoxAntL = new System.Windows.Forms.PictureBox();
            this.picBoxAntR = new System.Windows.Forms.PictureBox();
            this.picBoxLegL = new System.Windows.Forms.PictureBox();
            this.picBoxLegR = new System.Windows.Forms.PictureBox();
            this.picBoxLegL2 = new System.Windows.Forms.PictureBox();
            this.picBoxLegR2 = new System.Windows.Forms.PictureBox();
            this.picBoxArmL = new System.Windows.Forms.PictureBox();
            this.picBoxArmR = new System.Windows.Forms.PictureBox();
            this.picBoxEyeL = new System.Windows.Forms.PictureBox();
            this.picBoxEyeR = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.picBoxBeetle = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxBody)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxHead)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxAntL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxAntR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxLegL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxLegR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxLegL2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxLegR2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxArmL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxArmR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxEyeL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxEyeR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxBeetle)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 327);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(94, 94);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(23, 424);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(72, 47);
            this.button1.TabIndex = 1;
            this.button1.Text = "Roll";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(158, 417);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(103, 60);
            this.button2.TabIndex = 2;
            this.button2.Text = "Start Over";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(328, 421);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(76, 52);
            this.button3.TabIndex = 3;
            this.button3.Text = "Quit";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "Die 01.jpg");
            this.imageList1.Images.SetKeyName(1, "Die 02.jpg");
            this.imageList1.Images.SetKeyName(2, "Die 03.jpg");
            this.imageList1.Images.SetKeyName(3, "Die 04.jpg");
            this.imageList1.Images.SetKeyName(4, "Die 05.jpg");
            this.imageList1.Images.SetKeyName(5, "Die 06.jpg");
            // 
            // imageList2
            // 
            this.imageList2.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList2.ImageStream")));
            this.imageList2.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList2.Images.SetKeyName(0, "Beetle Body.jpg");
            this.imageList2.Images.SetKeyName(1, "Beetle Head.jpg");
            this.imageList2.Images.SetKeyName(2, "Beetle Leg Lower Left.jpg");
            this.imageList2.Images.SetKeyName(3, "Beetle Leg Lower Right.jpg");
            this.imageList2.Images.SetKeyName(4, "Beetle Leg Upper Left.jpg");
            this.imageList2.Images.SetKeyName(5, "Beetle Leg Upper Right.jpg");
            this.imageList2.Images.SetKeyName(6, "Beetle Arm Left.jpg");
            this.imageList2.Images.SetKeyName(7, "Beetle Arm Right.jpg");
            this.imageList2.Images.SetKeyName(8, "Beetle Antenna Left.jpg");
            this.imageList2.Images.SetKeyName(9, "Beetle Antenna Right.jpg");
            this.imageList2.Images.SetKeyName(10, "Beetle Eye Left.jpg");
            this.imageList2.Images.SetKeyName(11, "Beetle Eye Right.jpg");
            // 
            // picBoxBody
            // 
            this.picBoxBody.Image = global::Beetle_Game.Properties.Resources.Beetle_Body;
            this.picBoxBody.Location = new System.Drawing.Point(131, 137);
            this.picBoxBody.Name = "picBoxBody";
            this.picBoxBody.Size = new System.Drawing.Size(140, 152);
            this.picBoxBody.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxBody.TabIndex = 4;
            this.picBoxBody.TabStop = false;
            this.picBoxBody.Visible = false;
            this.picBoxBody.Click += new System.EventHandler(this.picBoxBody_Click);
            // 
            // picBoxHead
            // 
            this.picBoxHead.Image = global::Beetle_Game.Properties.Resources.Beetle_Head;
            this.picBoxHead.Location = new System.Drawing.Point(141, 12);
            this.picBoxHead.Name = "picBoxHead";
            this.picBoxHead.Size = new System.Drawing.Size(120, 123);
            this.picBoxHead.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxHead.TabIndex = 5;
            this.picBoxHead.TabStop = false;
            this.picBoxHead.Visible = false;
            // 
            // picBoxAntL
            // 
            this.picBoxAntL.Image = global::Beetle_Game.Properties.Resources.Beetle_Antenna_Left;
            this.picBoxAntL.Location = new System.Drawing.Point(160, 55);
            this.picBoxAntL.Name = "picBoxAntL";
            this.picBoxAntL.Size = new System.Drawing.Size(31, 23);
            this.picBoxAntL.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxAntL.TabIndex = 6;
            this.picBoxAntL.TabStop = false;
            this.picBoxAntL.Visible = false;
            // 
            // picBoxAntR
            // 
            this.picBoxAntR.Image = global::Beetle_Game.Properties.Resources.Beetle_Antenna_Right;
            this.picBoxAntR.Location = new System.Drawing.Point(215, 55);
            this.picBoxAntR.Name = "picBoxAntR";
            this.picBoxAntR.Size = new System.Drawing.Size(31, 23);
            this.picBoxAntR.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxAntR.TabIndex = 7;
            this.picBoxAntR.TabStop = false;
            this.picBoxAntR.Visible = false;
            // 
            // picBoxLegL
            // 
            this.picBoxLegL.Image = global::Beetle_Game.Properties.Resources.Beetle_Leg_Upper_Left;
            this.picBoxLegL.Location = new System.Drawing.Point(59, 171);
            this.picBoxLegL.Name = "picBoxLegL";
            this.picBoxLegL.Size = new System.Drawing.Size(76, 78);
            this.picBoxLegL.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxLegL.TabIndex = 8;
            this.picBoxLegL.TabStop = false;
            this.picBoxLegL.Visible = false;
            // 
            // picBoxLegR
            // 
            this.picBoxLegR.Image = global::Beetle_Game.Properties.Resources.Beetle_Leg_Upper_Right;
            this.picBoxLegR.Location = new System.Drawing.Point(267, 171);
            this.picBoxLegR.Name = "picBoxLegR";
            this.picBoxLegR.Size = new System.Drawing.Size(76, 78);
            this.picBoxLegR.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxLegR.TabIndex = 9;
            this.picBoxLegR.TabStop = false;
            this.picBoxLegR.Visible = false;
            // 
            // picBoxLegL2
            // 
            this.picBoxLegL2.Image = global::Beetle_Game.Properties.Resources.Beetle_Leg_Lower_Left;
            this.picBoxLegL2.Location = new System.Drawing.Point(85, 229);
            this.picBoxLegL2.Name = "picBoxLegL2";
            this.picBoxLegL2.Size = new System.Drawing.Size(50, 92);
            this.picBoxLegL2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxLegL2.TabIndex = 10;
            this.picBoxLegL2.TabStop = false;
            this.picBoxLegL2.Visible = false;
            // 
            // picBoxLegR2
            // 
            this.picBoxLegR2.Image = global::Beetle_Game.Properties.Resources.Beetle_Leg_Lower_Right;
            this.picBoxLegR2.Location = new System.Drawing.Point(267, 229);
            this.picBoxLegR2.Name = "picBoxLegR2";
            this.picBoxLegR2.Size = new System.Drawing.Size(50, 92);
            this.picBoxLegR2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxLegR2.TabIndex = 11;
            this.picBoxLegR2.TabStop = false;
            this.picBoxLegR2.Visible = false;
            // 
            // picBoxArmL
            // 
            this.picBoxArmL.Image = global::Beetle_Game.Properties.Resources.Beetle_Arm_Left;
            this.picBoxArmL.Location = new System.Drawing.Point(71, 39);
            this.picBoxArmL.Name = "picBoxArmL";
            this.picBoxArmL.Size = new System.Drawing.Size(73, 92);
            this.picBoxArmL.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxArmL.TabIndex = 12;
            this.picBoxArmL.TabStop = false;
            this.picBoxArmL.Visible = false;
            // 
            // picBoxArmR
            // 
            this.picBoxArmR.Image = global::Beetle_Game.Properties.Resources.Beetle_Arm_Right;
            this.picBoxArmR.Location = new System.Drawing.Point(258, 39);
            this.picBoxArmR.Name = "picBoxArmR";
            this.picBoxArmR.Size = new System.Drawing.Size(73, 92);
            this.picBoxArmR.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxArmR.TabIndex = 13;
            this.picBoxArmR.TabStop = false;
            this.picBoxArmR.Visible = false;
            // 
            // picBoxEyeL
            // 
            this.picBoxEyeL.Image = global::Beetle_Game.Properties.Resources.Beetle_Eye_Left;
            this.picBoxEyeL.Location = new System.Drawing.Point(170, 75);
            this.picBoxEyeL.Name = "picBoxEyeL";
            this.picBoxEyeL.Size = new System.Drawing.Size(21, 23);
            this.picBoxEyeL.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxEyeL.TabIndex = 14;
            this.picBoxEyeL.TabStop = false;
            this.picBoxEyeL.Visible = false;
            // 
            // picBoxEyeR
            // 
            this.picBoxEyeR.Image = global::Beetle_Game.Properties.Resources.Beetle_Eye_Right;
            this.picBoxEyeR.Location = new System.Drawing.Point(215, 75);
            this.picBoxEyeR.Name = "picBoxEyeR";
            this.picBoxEyeR.Size = new System.Drawing.Size(21, 23);
            this.picBoxEyeR.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxEyeR.TabIndex = 15;
            this.picBoxEyeR.TabStop = false;
            this.picBoxEyeR.Visible = false;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(112, 340);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(219, 53);
            this.label1.TabIndex = 16;
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // picBoxBeetle
            // 
            this.picBoxBeetle.Image = ((System.Drawing.Image)(resources.GetObject("picBoxBeetle.Image")));
            this.picBoxBeetle.Location = new System.Drawing.Point(56, 9);
            this.picBoxBeetle.Name = "picBoxBeetle";
            this.picBoxBeetle.Size = new System.Drawing.Size(286, 318);
            this.picBoxBeetle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxBeetle.TabIndex = 17;
            this.picBoxBeetle.TabStop = false;
            this.picBoxBeetle.Visible = false;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(349, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(167, 311);
            this.label2.TabIndex = 18;
            this.label2.Text = resources.GetString("label2.Text");
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(380, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 30);
            this.label3.TabIndex = 19;
            this.label3.Text = "RULES";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(515, 478);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.picBoxBeetle);
            this.Controls.Add(this.picBoxLegR2);
            this.Controls.Add(this.picBoxLegL2);
            this.Controls.Add(this.picBoxAntR);
            this.Controls.Add(this.picBoxAntL);
            this.Controls.Add(this.picBoxEyeR);
            this.Controls.Add(this.picBoxEyeL);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.picBoxArmR);
            this.Controls.Add(this.picBoxArmL);
            this.Controls.Add(this.picBoxLegR);
            this.Controls.Add(this.picBoxLegL);
            this.Controls.Add(this.picBoxHead);
            this.Controls.Add(this.picBoxBody);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Beetle Game";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxBody)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxHead)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxAntL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxAntR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxLegL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxLegR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxLegL2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxLegR2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxArmL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxArmR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxEyeL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxEyeR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxBeetle)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ImageList imageList2;
        private System.Windows.Forms.PictureBox picBoxBody;
        private System.Windows.Forms.PictureBox picBoxHead;
        private System.Windows.Forms.PictureBox picBoxAntL;
        private System.Windows.Forms.PictureBox picBoxAntR;
        private System.Windows.Forms.PictureBox picBoxLegL;
        private System.Windows.Forms.PictureBox picBoxLegR;
        private System.Windows.Forms.PictureBox picBoxLegL2;
        private System.Windows.Forms.PictureBox picBoxLegR2;
        private System.Windows.Forms.PictureBox picBoxArmL;
        private System.Windows.Forms.PictureBox picBoxArmR;
        private System.Windows.Forms.PictureBox picBoxEyeL;
        private System.Windows.Forms.PictureBox picBoxEyeR;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox picBoxBeetle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

