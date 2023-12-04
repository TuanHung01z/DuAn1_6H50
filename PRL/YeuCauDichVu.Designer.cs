namespace PRL
{
    partial class YeuCauDichVu
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
            panel_YeuCauDichVu = new Panel();
            textBox1 = new TextBox();
            button1 = new Button();
            label3 = new Label();
            dataGridView2 = new DataGridView();
            dataGridView1 = new DataGridView();
            panel_YeuCauDichVu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel_YeuCauDichVu
            // 
            panel_YeuCauDichVu.Controls.Add(textBox1);
            panel_YeuCauDichVu.Controls.Add(button1);
            panel_YeuCauDichVu.Controls.Add(label3);
            panel_YeuCauDichVu.Controls.Add(dataGridView2);
            panel_YeuCauDichVu.Controls.Add(dataGridView1);
            panel_YeuCauDichVu.Location = new Point(2, 1);
            panel_YeuCauDichVu.Margin = new Padding(4, 4, 4, 4);
            panel_YeuCauDichVu.Name = "panel_YeuCauDichVu";
            panel_YeuCauDichVu.Size = new Size(1154, 1175);
            panel_YeuCauDichVu.TabIndex = 1;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(255, 188, 18);
            textBox1.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(33, 761);
            textBox1.Margin = new Padding(4, 4, 4, 4);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(1103, 56);
            textBox1.TabIndex = 53;
            textBox1.Text = "Tổng giá tiền:";
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(255, 138, 0);
            button1.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(936, 825);
            button1.Margin = new Padding(4, 4, 4, 4);
            button1.Name = "button1";
            button1.Size = new Size(201, 62);
            button1.TabIndex = 52;
            button1.Text = "Thanh Toán";
            button1.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(11, 17);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(221, 38);
            label3.TabIndex = 51;
            label3.Text = "Yêu Cầu Dịch Vụ";
            // 
            // dataGridView2
            // 
            dataGridView2.BackgroundColor = Color.White;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(24, 486);
            dataGridView2.Margin = new Padding(4, 4, 4, 4);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.RowTemplate.Height = 29;
            dataGridView2.Size = new Size(1112, 250);
            dataGridView2.TabIndex = 0;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(25, 84);
            dataGridView1.Margin = new Padding(4, 4, 4, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(1111, 383);
            dataGridView1.TabIndex = 0;
            // 
            // YeuCauDichVu
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(190, 0, 0);
            ClientSize = new Size(1171, 892);
            Controls.Add(panel_YeuCauDichVu);
            Margin = new Padding(4, 4, 4, 4);
            Name = "YeuCauDichVu";
            Text = "YeuCauDichVu";
            panel_YeuCauDichVu.ResumeLayout(false);
            panel_YeuCauDichVu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel_YeuCauDichVu;
        private TextBox textBox1;
        private Button button1;
        private Label label3;
        private DataGridView dataGridView2;
        private DataGridView dataGridView1;
    }
}