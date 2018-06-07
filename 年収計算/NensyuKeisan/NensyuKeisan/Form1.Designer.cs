namespace NensyuKeisan
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
        /// <param name="disposing">マネージ リソースが破棄される場合 true、破棄されない場合は false です。</param>
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
            this.Nensyu = new System.Windows.Forms.Label();
            this.Gessyu = new System.Windows.Forms.Label();
            this.Syouyo = new System.Windows.Forms.Label();
            this.Teate = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Nensyu
            // 
            this.Nensyu.AutoSize = true;
            this.Nensyu.Font = new System.Drawing.Font("MS UI Gothic", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Nensyu.Location = new System.Drawing.Point(55, 32);
            this.Nensyu.Name = "Nensyu";
            this.Nensyu.Size = new System.Drawing.Size(174, 72);
            this.Nensyu.TabIndex = 0;
            this.Nensyu.Text = "年収";
            // 
            // Gessyu
            // 
            this.Gessyu.AutoSize = true;
            this.Gessyu.Font = new System.Drawing.Font("MS UI Gothic", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Gessyu.Location = new System.Drawing.Point(60, 182);
            this.Gessyu.Name = "Gessyu";
            this.Gessyu.Size = new System.Drawing.Size(97, 40);
            this.Gessyu.TabIndex = 1;
            this.Gessyu.Text = "月収";
            // 
            // Syouyo
            // 
            this.Syouyo.AutoSize = true;
            this.Syouyo.Font = new System.Drawing.Font("MS UI Gothic", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Syouyo.Location = new System.Drawing.Point(60, 311);
            this.Syouyo.Name = "Syouyo";
            this.Syouyo.Size = new System.Drawing.Size(97, 40);
            this.Syouyo.TabIndex = 2;
            this.Syouyo.Text = "賞与";
            // 
            // Teate
            // 
            this.Teate.AutoSize = true;
            this.Teate.Font = new System.Drawing.Font("MS UI Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Teate.Location = new System.Drawing.Point(61, 450);
            this.Teate.Name = "Teate";
            this.Teate.Size = new System.Drawing.Size(79, 33);
            this.Teate.TabIndex = 3;
            this.Teate.Text = "手当";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(248, 48);
            this.label1.MaximumSize = new System.Drawing.Size(356, 56);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(356, 56);
            this.label1.TabIndex = 4;
            this.label1.Text = "0円";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(330, 198);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 25);
            this.textBox1.TabIndex = 5;
            this.textBox1.Text = "0";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(330, 326);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 25);
            this.textBox2.TabIndex = 6;
            this.textBox2.Text = "0";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(330, 460);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 25);
            this.textBox3.TabIndex = 7;
            this.textBox3.Text = "0";
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(488, 506);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(116, 51);
            this.button1.TabIndex = 8;
            this.button1.Text = "計算";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(436, 205);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 18);
            this.label2.TabIndex = 9;
            this.label2.Text = "円 × 12";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(436, 333);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 18);
            this.label3.TabIndex = 10;
            this.label3.Text = "円 × 2";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(436, 465);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 18);
            this.label4.TabIndex = 11;
            this.label4.Text = "円 × 12";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(633, 579);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Teate);
            this.Controls.Add(this.Syouyo);
            this.Controls.Add(this.Gessyu);
            this.Controls.Add(this.Nensyu);
            this.Name = "Form1";
            this.Text = "年収計算";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Nensyu;
        private System.Windows.Forms.Label Gessyu;
        private System.Windows.Forms.Label Syouyo;
        private System.Windows.Forms.Label Teate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

