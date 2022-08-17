
namespace quake_sample
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
            this.title_lbl = new System.Windows.Forms.Label();
            this.epicenter_lbl = new System.Windows.Forms.Label();
            this.depth_lbl = new System.Windows.Forms.Label();
            this.magunitude_lbl = new System.Windows.Forms.Label();
            this.maxintensity_lbl = new System.Windows.Forms.Label();
            this.int_box = new System.Windows.Forms.RichTextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // title_lbl
            // 
            this.title_lbl.AutoSize = true;
            this.title_lbl.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.title_lbl.Location = new System.Drawing.Point(12, 9);
            this.title_lbl.Name = "title_lbl";
            this.title_lbl.Size = new System.Drawing.Size(96, 27);
            this.title_lbl.TabIndex = 0;
            this.title_lbl.Text = "タイトル";
            // 
            // epicenter_lbl
            // 
            this.epicenter_lbl.AutoSize = true;
            this.epicenter_lbl.Font = new System.Drawing.Font("MS UI Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.epicenter_lbl.Location = new System.Drawing.Point(12, 45);
            this.epicenter_lbl.Name = "epicenter_lbl";
            this.epicenter_lbl.Size = new System.Drawing.Size(93, 20);
            this.epicenter_lbl.TabIndex = 1;
            this.epicenter_lbl.Text = "震源地名";
            // 
            // depth_lbl
            // 
            this.depth_lbl.AutoSize = true;
            this.depth_lbl.Font = new System.Drawing.Font("MS UI Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.depth_lbl.Location = new System.Drawing.Point(12, 74);
            this.depth_lbl.Name = "depth_lbl";
            this.depth_lbl.Size = new System.Drawing.Size(45, 20);
            this.depth_lbl.TabIndex = 2;
            this.depth_lbl.Text = "深さ";
            // 
            // magunitude_lbl
            // 
            this.magunitude_lbl.AutoSize = true;
            this.magunitude_lbl.Font = new System.Drawing.Font("MS UI Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.magunitude_lbl.Location = new System.Drawing.Point(12, 101);
            this.magunitude_lbl.Name = "magunitude_lbl";
            this.magunitude_lbl.Size = new System.Drawing.Size(51, 20);
            this.magunitude_lbl.TabIndex = 3;
            this.magunitude_lbl.Text = "規模";
            // 
            // maxintensity_lbl
            // 
            this.maxintensity_lbl.AutoSize = true;
            this.maxintensity_lbl.Font = new System.Drawing.Font("MS UI Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.maxintensity_lbl.Location = new System.Drawing.Point(13, 128);
            this.maxintensity_lbl.Name = "maxintensity_lbl";
            this.maxintensity_lbl.Size = new System.Drawing.Size(93, 20);
            this.maxintensity_lbl.TabIndex = 4;
            this.maxintensity_lbl.Text = "最大震度";
            // 
            // int_box
            // 
            this.int_box.Location = new System.Drawing.Point(16, 162);
            this.int_box.Name = "int_box";
            this.int_box.Size = new System.Drawing.Size(509, 258);
            this.int_box.TabIndex = 5;
            this.int_box.Text = "";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 5000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 439);
            this.Controls.Add(this.int_box);
            this.Controls.Add(this.maxintensity_lbl);
            this.Controls.Add(this.magunitude_lbl);
            this.Controls.Add(this.depth_lbl);
            this.Controls.Add(this.epicenter_lbl);
            this.Controls.Add(this.title_lbl);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label title_lbl;
        private System.Windows.Forms.Label epicenter_lbl;
        private System.Windows.Forms.Label depth_lbl;
        private System.Windows.Forms.Label magunitude_lbl;
        private System.Windows.Forms.Label maxintensity_lbl;
        private System.Windows.Forms.RichTextBox int_box;
        private System.Windows.Forms.Timer timer1;
    }
}

