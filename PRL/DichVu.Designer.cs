﻿namespace PRL
{
    partial class DichVu
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
            panel_DichVu = new Panel();
            Txt_SvcName = new TextBox();
            pictureBox2 = new PictureBox();
            BTN_Delete = new Button();
            BTN_CreateSvc = new Button();
            Txt_Details = new TextBox();
            BTN_Update = new Button();
            Txt_SvcPrice = new TextBox();
            label2 = new Label();
            Txt_ServiceID = new TextBox();
            label1 = new Label();
            label13 = new Label();
            pictureBox4 = new PictureBox();
            label7 = new Label();
            pictureBox3 = new PictureBox();
            label3 = new Label();
            pictureBox1 = new PictureBox();
            Screen_Svc = new DataGridView();
            panel_DichVu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Screen_Svc).BeginInit();
            SuspendLayout();
            // 
            // panel_DichVu
            // 
            panel_DichVu.Controls.Add(Txt_SvcName);
            panel_DichVu.Controls.Add(pictureBox2);
            panel_DichVu.Controls.Add(BTN_Delete);
            panel_DichVu.Controls.Add(BTN_CreateSvc);
            panel_DichVu.Controls.Add(Txt_Details);
            panel_DichVu.Controls.Add(BTN_Update);
            panel_DichVu.Controls.Add(Txt_SvcPrice);
            panel_DichVu.Controls.Add(label2);
            panel_DichVu.Controls.Add(Txt_ServiceID);
            panel_DichVu.Controls.Add(label1);
            panel_DichVu.Controls.Add(label13);
            panel_DichVu.Controls.Add(pictureBox4);
            panel_DichVu.Controls.Add(label7);
            panel_DichVu.Controls.Add(pictureBox3);
            panel_DichVu.Controls.Add(label3);
            panel_DichVu.Controls.Add(pictureBox1);
            panel_DichVu.Controls.Add(Screen_Svc);
            panel_DichVu.Location = new Point(-1, -1);
            panel_DichVu.Name = "panel_DichVu";
            panel_DichVu.Size = new Size(821, 572);
            panel_DichVu.TabIndex = 0;
            // 
            // Txt_SvcName
            // 
            Txt_SvcName.BackColor = Color.FromArgb(255, 138, 0);
            Txt_SvcName.BorderStyle = BorderStyle.None;
            Txt_SvcName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Txt_SvcName.ForeColor = Color.Black;
            Txt_SvcName.Location = new Point(297, 457);
            Txt_SvcName.Margin = new Padding(3, 2, 3, 2);
            Txt_SvcName.MaxLength = 50;
            Txt_SvcName.Name = "Txt_SvcName";
            Txt_SvcName.Size = new Size(239, 22);
            Txt_SvcName.TabIndex = 125;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.Rectangle_481;
            pictureBox2.Location = new Point(293, 455);
            pictureBox2.Margin = new Padding(3, 2, 3, 2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(247, 26);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 126;
            pictureBox2.TabStop = false;
            // 
            // BTN_Delete
            // 
            BTN_Delete.BackColor = Color.FromArgb(112, 88, 61);
            BTN_Delete.FlatStyle = FlatStyle.System;
            BTN_Delete.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            BTN_Delete.ForeColor = Color.White;
            BTN_Delete.Location = new Point(558, 506);
            BTN_Delete.Margin = new Padding(3, 2, 3, 2);
            BTN_Delete.Name = "BTN_Delete";
            BTN_Delete.Size = new Size(152, 34);
            BTN_Delete.TabIndex = 124;
            BTN_Delete.Text = "Xóa";
            BTN_Delete.UseVisualStyleBackColor = false;
            // 
            // BTN_CreateSvc
            // 
            BTN_CreateSvc.BackColor = Color.FromArgb(112, 88, 61);
            BTN_CreateSvc.FlatStyle = FlatStyle.System;
            BTN_CreateSvc.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            BTN_CreateSvc.ForeColor = Color.White;
            BTN_CreateSvc.Location = new Point(558, 430);
            BTN_CreateSvc.Margin = new Padding(3, 2, 3, 2);
            BTN_CreateSvc.Name = "BTN_CreateSvc";
            BTN_CreateSvc.Size = new Size(152, 34);
            BTN_CreateSvc.TabIndex = 116;
            BTN_CreateSvc.Text = "Tạo Dịch Vụ";
            BTN_CreateSvc.UseVisualStyleBackColor = false;
            BTN_CreateSvc.Click += BTN_CreateSvc_Click;
            // 
            // Txt_Details
            // 
            Txt_Details.BackColor = Color.FromArgb(255, 138, 0);
            Txt_Details.BorderStyle = BorderStyle.None;
            Txt_Details.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Txt_Details.ForeColor = Color.Black;
            Txt_Details.Location = new Point(297, 539);
            Txt_Details.Margin = new Padding(3, 2, 3, 2);
            Txt_Details.MaxLength = 50;
            Txt_Details.Name = "Txt_Details";
            Txt_Details.Size = new Size(239, 22);
            Txt_Details.TabIndex = 115;
            // 
            // BTN_Update
            // 
            BTN_Update.BackColor = Color.FromArgb(112, 88, 61);
            BTN_Update.FlatStyle = FlatStyle.System;
            BTN_Update.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            BTN_Update.ForeColor = Color.White;
            BTN_Update.Location = new Point(558, 468);
            BTN_Update.Margin = new Padding(3, 2, 3, 2);
            BTN_Update.Name = "BTN_Update";
            BTN_Update.Size = new Size(152, 34);
            BTN_Update.TabIndex = 118;
            BTN_Update.Text = "Cập Nhật";
            BTN_Update.UseVisualStyleBackColor = false;
            // 
            // Txt_SvcPrice
            // 
            Txt_SvcPrice.BackColor = Color.FromArgb(255, 138, 0);
            Txt_SvcPrice.BorderStyle = BorderStyle.None;
            Txt_SvcPrice.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Txt_SvcPrice.ForeColor = Color.Black;
            Txt_SvcPrice.Location = new Point(297, 500);
            Txt_SvcPrice.Margin = new Padding(3, 2, 3, 2);
            Txt_SvcPrice.Name = "Txt_SvcPrice";
            Txt_SvcPrice.Size = new Size(239, 22);
            Txt_SvcPrice.TabIndex = 117;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(116, 538);
            label2.Name = "label2";
            label2.Size = new Size(175, 25);
            label2.TabIndex = 111;
            label2.Text = "Trạng Thái Dịch Vụ:";
            // 
            // Txt_ServiceID
            // 
            Txt_ServiceID.BackColor = Color.FromArgb(255, 138, 0);
            Txt_ServiceID.BorderStyle = BorderStyle.None;
            Txt_ServiceID.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Txt_ServiceID.ForeColor = Color.Black;
            Txt_ServiceID.Location = new Point(297, 417);
            Txt_ServiceID.Margin = new Padding(3, 2, 3, 2);
            Txt_ServiceID.MaxLength = 10;
            Txt_ServiceID.Name = "Txt_ServiceID";
            Txt_ServiceID.Size = new Size(239, 22);
            Txt_ServiceID.TabIndex = 119;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(176, 499);
            label1.Name = "label1";
            label1.Size = new Size(115, 25);
            label1.TabIndex = 112;
            label1.Text = "Giá Dịch Vụ:";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label13.ForeColor = Color.White;
            label13.Location = new Point(151, 456);
            label13.Name = "label13";
            label13.Size = new Size(140, 25);
            label13.TabIndex = 113;
            label13.Text = "Mô Tả Dịch Vụ:";
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.Rectangle_481;
            pictureBox4.Location = new Point(293, 415);
            pictureBox4.Margin = new Padding(3, 2, 3, 2);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(247, 26);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 123;
            pictureBox4.TabStop = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = Color.White;
            label7.Location = new Point(177, 416);
            label7.Name = "label7";
            label7.Size = new Size(114, 25);
            label7.TabIndex = 114;
            label7.Text = "Mã Dịch Vụ:";
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.Rectangle_481;
            pictureBox3.Location = new Point(293, 498);
            pictureBox3.Margin = new Padding(3, 2, 3, 2);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(247, 26);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 122;
            pictureBox3.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Black", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(9, 9);
            label3.Name = "label3";
            label3.Size = new Size(119, 37);
            label3.TabIndex = 110;
            label3.Text = "Dịch Vụ";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Rectangle_481;
            pictureBox1.Location = new Point(293, 537);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(247, 26);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 121;
            pictureBox1.TabStop = false;
            // 
            // Screen_Svc
            // 
            Screen_Svc.BackgroundColor = Color.White;
            Screen_Svc.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Screen_Svc.Location = new Point(6, 52);
            Screen_Svc.Margin = new Padding(3, 2, 3, 2);
            Screen_Svc.Name = "Screen_Svc";
            Screen_Svc.RowHeadersWidth = 51;
            Screen_Svc.RowTemplate.Height = 29;
            Screen_Svc.Size = new Size(808, 348);
            Screen_Svc.TabIndex = 109;
            // 
            // DichVu
            // 
            AutoScaleDimensions = new SizeF(7F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(190, 0, 0);
            ClientSize = new Size(820, 571);
            Controls.Add(panel_DichVu);
            Margin = new Padding(3, 2, 3, 2);
            Name = "DichVu";
            Text = "DichVu";
            panel_DichVu.ResumeLayout(false);
            panel_DichVu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)Screen_Svc).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel_DichVu;
        private Button BTN_CreateSvc;
        private TextBox Txt_Details;
        private Button BTN_Update;
        private TextBox Txt_SvcPrice;
        private Label label2;
        private TextBox Txt_ServiceID;
        private Label label1;
        private Label label13;
        private PictureBox pictureBox4;
        private Label label7;
        private PictureBox pictureBox3;
        private Label label3;
        private PictureBox pictureBox1;
        private DataGridView Screen_Svc;
        private Button BTN_Delete;
        private TextBox Txt_SvcName;
        private PictureBox pictureBox2;
    }
}