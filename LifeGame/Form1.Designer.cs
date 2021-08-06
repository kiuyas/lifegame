namespace LifeGame
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnRandom = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnPat1 = new System.Windows.Forms.Button();
            this.btnPat9 = new System.Windows.Forms.Button();
            this.btnPat2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Black;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(528, 440);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnPat2);
            this.panel1.Controls.Add(this.btnPat9);
            this.panel1.Controls.Add(this.btnPat1);
            this.panel1.Controls.Add(this.btnRandom);
            this.panel1.Controls.Add(this.btnStart);
            this.panel1.Location = new System.Drawing.Point(528, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(96, 440);
            this.panel1.TabIndex = 1;
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(8, 8);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "開始";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnRandom
            // 
            this.btnRandom.Location = new System.Drawing.Point(8, 40);
            this.btnRandom.Name = "btnRandom";
            this.btnRandom.Size = new System.Drawing.Size(75, 23);
            this.btnRandom.TabIndex = 1;
            this.btnRandom.Text = "ランダム";
            this.btnRandom.UseVisualStyleBackColor = true;
            this.btnRandom.Click += new System.EventHandler(this.btnRandom_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnPat1
            // 
            this.btnPat1.Location = new System.Drawing.Point(8, 72);
            this.btnPat1.Name = "btnPat1";
            this.btnPat1.Size = new System.Drawing.Size(75, 23);
            this.btnPat1.TabIndex = 2;
            this.btnPat1.Text = "縦線";
            this.btnPat1.UseVisualStyleBackColor = true;
            this.btnPat1.Click += new System.EventHandler(this.btnPat1_Click);
            // 
            // btnPat9
            // 
            this.btnPat9.Location = new System.Drawing.Point(8, 136);
            this.btnPat9.Name = "btnPat9";
            this.btnPat9.Size = new System.Drawing.Size(75, 23);
            this.btnPat9.TabIndex = 3;
            this.btnPat9.Text = "グライダー";
            this.btnPat9.UseVisualStyleBackColor = true;
            this.btnPat9.Click += new System.EventHandler(this.btnPat9_Click);
            // 
            // btnPat2
            // 
            this.btnPat2.Location = new System.Drawing.Point(8, 104);
            this.btnPat2.Name = "btnPat2";
            this.btnPat2.Size = new System.Drawing.Size(75, 23);
            this.btnPat2.TabIndex = 4;
            this.btnPat2.Text = "縦線2";
            this.btnPat2.UseVisualStyleBackColor = true;
            this.btnPat2.Click += new System.EventHandler(this.btnPat2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 441);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Life Game";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnRandom;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnPat1;
        private System.Windows.Forms.Button btnPat9;
        private System.Windows.Forms.Button btnPat2;
    }
}

