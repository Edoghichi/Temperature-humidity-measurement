namespace WindowsFormsApp2
{
    partial class SetChuan
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
            this.txbA1 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.BtnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lbNhietDoTB = new System.Windows.Forms.Label();
            this.lbDoAmTB = new System.Windows.Forms.Label();
            this.txbB1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txbC1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txbC2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txbB2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txbA2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txbA1
            // 
            this.txbA1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbA1.Location = new System.Drawing.Point(59, 140);
            this.txbA1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbA1.Name = "txbA1";
            this.txbA1.Size = new System.Drawing.Size(135, 30);
            this.txbA1.TabIndex = 50;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(12, 143);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 25);
            this.label7.TabIndex = 47;
            this.label7.Text = "a1:";
            // 
            // BtnOk
            // 
            this.BtnOk.BackColor = System.Drawing.Color.Lime;
            this.BtnOk.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnOk.Location = new System.Drawing.Point(179, 294);
            this.BtnOk.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnOk.Name = "BtnOk";
            this.BtnOk.Size = new System.Drawing.Size(98, 46);
            this.BtnOk.TabIndex = 52;
            this.BtnOk.Text = "OK";
            this.BtnOk.UseVisualStyleBackColor = false;
            this.BtnOk.Click += new System.EventHandler(this.BtnOk_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Red;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(336, 294);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(99, 46);
            this.btnCancel.TabIndex = 53;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lbNhietDoTB
            // 
            this.lbNhietDoTB.AutoSize = true;
            this.lbNhietDoTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNhietDoTB.ForeColor = System.Drawing.Color.Red;
            this.lbNhietDoTB.Location = new System.Drawing.Point(107, 18);
            this.lbNhietDoTB.Name = "lbNhietDoTB";
            this.lbNhietDoTB.Size = new System.Drawing.Size(358, 25);
            this.lbNhietDoTB.TabIndex = 55;
            this.lbNhietDoTB.Text = "Offset nhiệt độ:           y=a1.x^2+b1.x+c2";
            // 
            // lbDoAmTB
            // 
            this.lbDoAmTB.AutoSize = true;
            this.lbDoAmTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDoAmTB.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lbDoAmTB.Location = new System.Drawing.Point(107, 75);
            this.lbDoAmTB.Name = "lbDoAmTB";
            this.lbDoAmTB.Size = new System.Drawing.Size(356, 25);
            this.lbDoAmTB.TabIndex = 54;
            this.lbDoAmTB.Text = "Offset Độ ẩm:             y=a2.x^2+b2.x+c2";
            // 
            // txbB1
            // 
            this.txbB1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbB1.Location = new System.Drawing.Point(283, 138);
            this.txbB1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbB1.Name = "txbB1";
            this.txbB1.Size = new System.Drawing.Size(135, 30);
            this.txbB1.TabIndex = 57;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(237, 141);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 25);
            this.label1.TabIndex = 56;
            this.label1.Text = "b1:";
            // 
            // txbC1
            // 
            this.txbC1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbC1.Location = new System.Drawing.Point(507, 138);
            this.txbC1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbC1.Name = "txbC1";
            this.txbC1.Size = new System.Drawing.Size(135, 30);
            this.txbC1.TabIndex = 59;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(460, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 25);
            this.label2.TabIndex = 58;
            this.label2.Text = "c1:";
            // 
            // txbC2
            // 
            this.txbC2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbC2.Location = new System.Drawing.Point(507, 218);
            this.txbC2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbC2.Name = "txbC2";
            this.txbC2.Size = new System.Drawing.Size(135, 30);
            this.txbC2.TabIndex = 65;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(460, 221);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 25);
            this.label3.TabIndex = 64;
            this.label3.Text = "c2:";
            // 
            // txbB2
            // 
            this.txbB2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbB2.Location = new System.Drawing.Point(283, 218);
            this.txbB2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbB2.Name = "txbB2";
            this.txbB2.Size = new System.Drawing.Size(135, 30);
            this.txbB2.TabIndex = 63;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(237, 221);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 25);
            this.label4.TabIndex = 62;
            this.label4.Text = "b2:";
            // 
            // txbA2
            // 
            this.txbA2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbA2.Location = new System.Drawing.Point(59, 220);
            this.txbA2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbA2.Name = "txbA2";
            this.txbA2.Size = new System.Drawing.Size(135, 30);
            this.txbA2.TabIndex = 61;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 223);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 25);
            this.label5.TabIndex = 60;
            this.label5.Text = "a2:";
            // 
            // SetChuan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(671, 351);
            this.ControlBox = false;
            this.Controls.Add(this.txbC2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txbB2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txbA2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txbC1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txbB1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbNhietDoTB);
            this.Controls.Add(this.lbDoAmTB);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.BtnOk);
            this.Controls.Add(this.txbA1);
            this.Controls.Add(this.label7);
            this.Location = new System.Drawing.Point(500, 0);
            this.Name = "SetChuan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Set Chuẩn";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txbA1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button BtnOk;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lbNhietDoTB;
        private System.Windows.Forms.Label lbDoAmTB;
        private System.Windows.Forms.TextBox txbB1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbC1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbC2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txbB2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txbA2;
        private System.Windows.Forms.Label label5;
    }
}