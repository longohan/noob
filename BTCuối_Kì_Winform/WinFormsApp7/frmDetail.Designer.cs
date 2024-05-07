namespace WinFormsApp7
{
    partial class frmDetail
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
            txtManhac = new TextBox();
            txtTennhac = new TextBox();
            txtTacgia = new TextBox();
            dtpNPH = new DateTimePicker();
            txtView = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // txtManhac
            // 
            txtManhac.Location = new Point(161, 54);
            txtManhac.Name = "txtManhac";
            txtManhac.Size = new Size(264, 23);
            txtManhac.TabIndex = 0;
            // 
            // txtTennhac
            // 
            txtTennhac.Location = new Point(161, 111);
            txtTennhac.Name = "txtTennhac";
            txtTennhac.Size = new Size(264, 23);
            txtTennhac.TabIndex = 1;
            // 
            // txtTacgia
            // 
            txtTacgia.Location = new Point(161, 233);
            txtTacgia.Name = "txtTacgia";
            txtTacgia.Size = new Size(264, 23);
            txtTacgia.TabIndex = 2;
            // 
            // dtpNPH
            // 
            dtpNPH.Location = new Point(161, 172);
            dtpNPH.Name = "dtpNPH";
            dtpNPH.Size = new Size(264, 23);
            dtpNPH.TabIndex = 3;
            // 
            // txtView
            // 
            txtView.Location = new Point(161, 290);
            txtView.Name = "txtView";
            txtView.Size = new Size(264, 23);
            txtView.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(62, 57);
            label1.Name = "label1";
            label1.Size = new Size(55, 15);
            label1.TabIndex = 5;
            label1.Text = "Mã Nhạc";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(62, 114);
            label2.Name = "label2";
            label2.Size = new Size(56, 15);
            label2.TabIndex = 6;
            label2.Text = "Tên Nhạc";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(62, 178);
            label3.Name = "label3";
            label3.Size = new Size(94, 15);
            label3.TabIndex = 7;
            label3.Text = "Ngày Phát Hành";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(62, 236);
            label4.Name = "label4";
            label4.Size = new Size(65, 15);
            label4.TabIndex = 8;
            label4.Text = "Tên Tác Giả";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(62, 293);
            label5.Name = "label5";
            label5.Size = new Size(58, 15);
            label5.TabIndex = 9;
            label5.Text = "Lượt Xem";
            // 
            // button1
            // 
            button1.Location = new Point(223, 363);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 10;
            button1.Text = "Lưu";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // frmDetail
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(534, 450);
            Controls.Add(button1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtView);
            Controls.Add(dtpNPH);
            Controls.Add(txtTacgia);
            Controls.Add(txtTennhac);
            Controls.Add(txtManhac);
            Name = "frmDetail";
            Text = "frmDetail";
            Load += frmDetail_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtManhac;
        private TextBox txtTennhac;
        private TextBox txtTacgia;
        private DateTimePicker dtpNPH;
        private TextBox txtView;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button button1;
    }
}