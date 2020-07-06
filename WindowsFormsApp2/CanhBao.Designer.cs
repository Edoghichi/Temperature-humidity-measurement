namespace WindowsFormsApp2
{
    partial class CanhBao
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
            this.txbCanhBao = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txbCanhBao
            // 
            this.txbCanhBao.AutoSize = true;
            this.txbCanhBao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbCanhBao.ForeColor = System.Drawing.Color.Red;
            this.txbCanhBao.Location = new System.Drawing.Point(82, 29);
            this.txbCanhBao.Name = "txbCanhBao";
            this.txbCanhBao.Size = new System.Drawing.Size(666, 50);
            this.txbCanhBao.TabIndex = 48;
            this.txbCanhBao.Text = "NHIỆT ĐỘ QUÁ CAO\r\nCảnh báo này sẽ mất đi khi nhiệt độ, độ ẩm đo được trong khoảng" +
    " cho phép";
            this.txbCanhBao.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CanhBao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(822, 114);
            this.ControlBox = false;
            this.Controls.Add(this.txbCanhBao);
            this.Name = "CanhBao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cảnh báo";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.CanhBao_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txbCanhBao;
    }
}