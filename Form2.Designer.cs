namespace ProjetSDA
{
    partial class Form2
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.EsprBut = new System.Windows.Forms.Button();
            this.MochBut = new System.Windows.Forms.Button();
            this.DoEsBut = new System.Windows.Forms.Button();
            this.CroisBut = new System.Windows.Forms.Button();
            this.ChocoBut = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Image = global::ProjetSDA.Properties.Resources.download__60_;
            this.pictureBox1.Location = new System.Drawing.Point(-466, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1320, 728);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(45, 236);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Espresso 2$";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(45, 289);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "MOCHA 3$";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(45, 340);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(219, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "DOUBLE ESPRESS 4$";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(45, 396);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(157, 25);
            this.label4.TabIndex = 4;
            this.label4.Text = "CROISSANT 2$";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(45, 448);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(186, 25);
            this.label5.TabIndex = 5;
            this.label5.Text = "CHOCOLATINA 2$";
            // 
            // EsprBut
            // 
            this.EsprBut.BackColor = System.Drawing.Color.Lime;
            this.EsprBut.Location = new System.Drawing.Point(313, 228);
            this.EsprBut.Name = "EsprBut";
            this.EsprBut.Size = new System.Drawing.Size(46, 33);
            this.EsprBut.TabIndex = 6;
            this.EsprBut.Text = "+";
            this.EsprBut.UseVisualStyleBackColor = false;
            this.EsprBut.Click += new System.EventHandler(this.EsprBut_Click);
            // 
            // MochBut
            // 
            this.MochBut.BackColor = System.Drawing.Color.Lime;
            this.MochBut.Location = new System.Drawing.Point(313, 284);
            this.MochBut.Name = "MochBut";
            this.MochBut.Size = new System.Drawing.Size(46, 30);
            this.MochBut.TabIndex = 7;
            this.MochBut.Text = "+";
            this.MochBut.UseVisualStyleBackColor = false;
            this.MochBut.Click += new System.EventHandler(this.MochBut_Click);
            // 
            // DoEsBut
            // 
            this.DoEsBut.BackColor = System.Drawing.Color.Lime;
            this.DoEsBut.Location = new System.Drawing.Point(313, 340);
            this.DoEsBut.Name = "DoEsBut";
            this.DoEsBut.Size = new System.Drawing.Size(46, 35);
            this.DoEsBut.TabIndex = 8;
            this.DoEsBut.Text = "+";
            this.DoEsBut.UseVisualStyleBackColor = false;
            this.DoEsBut.Click += new System.EventHandler(this.DoEsBut_Click);
            // 
            // CroisBut
            // 
            this.CroisBut.BackColor = System.Drawing.Color.Lime;
            this.CroisBut.Location = new System.Drawing.Point(313, 392);
            this.CroisBut.Name = "CroisBut";
            this.CroisBut.Size = new System.Drawing.Size(46, 37);
            this.CroisBut.TabIndex = 9;
            this.CroisBut.Text = "+";
            this.CroisBut.UseVisualStyleBackColor = false;
            this.CroisBut.Click += new System.EventHandler(this.CroisBut_Click);
            // 
            // ChocoBut
            // 
            this.ChocoBut.BackColor = System.Drawing.Color.Lime;
            this.ChocoBut.Location = new System.Drawing.Point(313, 448);
            this.ChocoBut.Name = "ChocoBut";
            this.ChocoBut.Size = new System.Drawing.Size(46, 38);
            this.ChocoBut.TabIndex = 10;
            this.ChocoBut.Text = "+";
            this.ChocoBut.UseVisualStyleBackColor = false;
            this.ChocoBut.Click += new System.EventHandler(this.ChocoBut_Click);
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(420, 12);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(361, 398);
            this.listView1.TabIndex = 11;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Lime;
            this.button1.Location = new System.Drawing.Point(849, 130);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(153, 56);
            this.button1.TabIndex = 12;
            this.button1.Text = "PAYEZ";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Red;
            this.button2.Location = new System.Drawing.Point(849, 273);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(153, 56);
            this.button2.TabIndex = 13;
            this.button2.Text = "RESET";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Red;
            this.button3.Location = new System.Drawing.Point(702, 416);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(79, 36);
            this.button3.TabIndex = 14;
            this.button3.Text = "return ";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ProjetSDA.Properties.Resources.Image_De_Fond_Bois_Planche_De_Bois_d_écran_Photo_Téléchargement_Gratuit___Pngtree;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1043, 515);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.ChocoBut);
            this.Controls.Add(this.CroisBut);
            this.Controls.Add(this.DoEsBut);
            this.Controls.Add(this.MochBut);
            this.Controls.Add(this.EsprBut);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form2";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button EsprBut;
        private System.Windows.Forms.Button MochBut;
        private System.Windows.Forms.Button DoEsBut;
        private System.Windows.Forms.Button CroisBut;
        private System.Windows.Forms.Button ChocoBut;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}