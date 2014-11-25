using jSkin;

namespace HtmlParser
{
    partial class frmMain
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        
        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다.
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마십시오.
        /// </summary>
        private void InitializeComponent()
        {
            this.tb_htmlText = new System.Windows.Forms.TextBox();
            this.lb_html = new System.Windows.Forms.Label();
            this.lb_result = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.bt_FileOpen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tb_htmlText
            // 
            this.tb_htmlText.Location = new System.Drawing.Point(12, 23);
            this.tb_htmlText.Multiline = true;
            this.tb_htmlText.Name = "tb_htmlText";
            this.tb_htmlText.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tb_htmlText.Size = new System.Drawing.Size(523, 274);
            this.tb_htmlText.TabIndex = 0;
            // 
            // lb_html
            // 
            this.lb_html.AutoSize = true;
            this.lb_html.Location = new System.Drawing.Point(17, 5);
            this.lb_html.Name = "lb_html";
            this.lb_html.Size = new System.Drawing.Size(39, 12);
            this.lb_html.TabIndex = 1;
            this.lb_html.Text = "HTML";
            // 
            // lb_result
            // 
            this.lb_result.AutoSize = true;
            this.lb_result.Location = new System.Drawing.Point(17, 315);
            this.lb_result.Name = "lb_result";
            this.lb_result.Size = new System.Drawing.Size(52, 12);
            this.lb_result.TabIndex = 2;
            this.lb_result.Text = "RESULT";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 330);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox1.Size = new System.Drawing.Size(523, 220);
            this.textBox1.TabIndex = 3;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // bt_FileOpen
            // 
            this.bt_FileOpen.Location = new System.Drawing.Point(561, 23);
            this.bt_FileOpen.Name = "bt_FileOpen";
            this.bt_FileOpen.Size = new System.Drawing.Size(75, 23);
            this.bt_FileOpen.TabIndex = 4;
            this.bt_FileOpen.Text = "FileOpen";
            this.bt_FileOpen.UseVisualStyleBackColor = true;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 562);
            this.Controls.Add(this.bt_FileOpen);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lb_result);
            this.Controls.Add(this.lb_html);
            this.Controls.Add(this.tb_htmlText);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmMain";
            this.Text = "DennisParser";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_htmlText;
        private System.Windows.Forms.Label lb_html;
        private System.Windows.Forms.Label lb_result;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button bt_FileOpen;
    }
}

