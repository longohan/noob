namespace WinFormsApp7
{
    partial class dgv
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
            components = new System.ComponentModel.Container();
            dgv1 = new DataGridView();
            btnDetail = new Button();
            bs = new BindingSource(components);
            btnLuu = new Button();
            coreBindingNavigator1 = new CoreBindingNavigator();
            ((System.ComponentModel.ISupportInitialize)dgv1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bs).BeginInit();
            ((System.ComponentModel.ISupportInitialize)coreBindingNavigator1).BeginInit();
            SuspendLayout();
            // 
            // dgv1
            // 
            dgv1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv1.Location = new Point(69, 36);
            dgv1.Name = "dgv1";
            dgv1.RowTemplate.Height = 25;
            dgv1.Size = new Size(654, 239);
            dgv1.TabIndex = 0;
            // 
            // btnDetail
            // 
            btnDetail.Location = new Point(69, 306);
            btnDetail.Name = "btnDetail";
            btnDetail.Size = new Size(95, 37);
            btnDetail.TabIndex = 1;
            btnDetail.Text = "Chi Tiết";
            btnDetail.UseVisualStyleBackColor = true;
            btnDetail.Click += btnDetail_Click;
            // 
            // bs
            // 
            bs.BindingComplete += bs_BindingComplete;
            // 
            // btnLuu
            // 
            btnLuu.Location = new Point(184, 306);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(73, 37);
            btnLuu.TabIndex = 2;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = true;
            btnLuu.Click += btnLuu_Click;
            // 
            // coreBindingNavigator1
            // 
            coreBindingNavigator1.BindingSource = bs;
            coreBindingNavigator1.Dock = DockStyle.Bottom;
            coreBindingNavigator1.Location = new Point(0, 425);
            coreBindingNavigator1.Name = "coreBindingNavigator1";
            coreBindingNavigator1.Size = new Size(800, 25);
            coreBindingNavigator1.TabIndex = 3;
            coreBindingNavigator1.Text = "coreBindingNavigator1";
            // 
            // dgv
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(coreBindingNavigator1);
            Controls.Add(btnLuu);
            Controls.Add(btnDetail);
            Controls.Add(dgv1);
            Name = "dgv";
            Text = "dgv";
            Load += dgv_Load;
            ((System.ComponentModel.ISupportInitialize)dgv1).EndInit();
            ((System.ComponentModel.ISupportInitialize)bs).EndInit();
            ((System.ComponentModel.ISupportInitialize)coreBindingNavigator1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgv1;
        private Button btnDetail;
        private BindingSource bs;
        private Button btnLuu;
        private CoreBindingNavigator coreBindingNavigator1;
    }
}