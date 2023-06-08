namespace HashTable_Dictionary_Viewer
{
    partial class Form1
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
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblPick4 = new System.Windows.Forms.Label();
            this.lblPick3 = new System.Windows.Forms.Label();
            this.lblPick2 = new System.Windows.Forms.Label();
            this.lblPick1 = new System.Windows.Forms.Label();
            this.pBox4 = new System.Windows.Forms.PictureBox();
            this.pBox3 = new System.Windows.Forms.PictureBox();
            this.pBox2 = new System.Windows.Forms.PictureBox();
            this.pBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgListView = new System.Windows.Forms.DataGridView();
            this.lblTotalCount = new System.Windows.Forms.Label();
            this.lblPlayerName = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgListView)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label6, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblPick4, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblPick3, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblPick2, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblPick1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.pBox4, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.pBox3, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.pBox2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.pBox1, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 37);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(432, 157);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(111, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 25);
            this.label3.TabIndex = 12;
            this.label3.Text = "신혜";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(3, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 25);
            this.label4.TabIndex = 11;
            this.label4.Text = "보검";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label5.Location = new System.Drawing.Point(327, 132);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 25);
            this.label5.TabIndex = 10;
            this.label5.Text = "보영";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label6.Location = new System.Drawing.Point(219, 132);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 25);
            this.label6.TabIndex = 9;
            this.label6.Text = "혜성";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPick4
            // 
            this.lblPick4.AutoSize = true;
            this.lblPick4.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblPick4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPick4.ForeColor = System.Drawing.SystemColors.Control;
            this.lblPick4.Location = new System.Drawing.Point(327, 107);
            this.lblPick4.Name = "lblPick4";
            this.lblPick4.Size = new System.Drawing.Size(102, 25);
            this.lblPick4.TabIndex = 8;
            this.lblPick4.Text = "0";
            this.lblPick4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPick3
            // 
            this.lblPick3.AutoSize = true;
            this.lblPick3.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblPick3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPick3.ForeColor = System.Drawing.SystemColors.Control;
            this.lblPick3.Location = new System.Drawing.Point(219, 107);
            this.lblPick3.Name = "lblPick3";
            this.lblPick3.Size = new System.Drawing.Size(102, 25);
            this.lblPick3.TabIndex = 7;
            this.lblPick3.Text = "0";
            this.lblPick3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPick2
            // 
            this.lblPick2.AutoSize = true;
            this.lblPick2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblPick2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPick2.ForeColor = System.Drawing.SystemColors.Control;
            this.lblPick2.Location = new System.Drawing.Point(111, 107);
            this.lblPick2.Name = "lblPick2";
            this.lblPick2.Size = new System.Drawing.Size(102, 25);
            this.lblPick2.TabIndex = 6;
            this.lblPick2.Text = "0";
            this.lblPick2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPick1
            // 
            this.lblPick1.AutoSize = true;
            this.lblPick1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblPick1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPick1.ForeColor = System.Drawing.SystemColors.Control;
            this.lblPick1.Location = new System.Drawing.Point(3, 107);
            this.lblPick1.Name = "lblPick1";
            this.lblPick1.Size = new System.Drawing.Size(102, 25);
            this.lblPick1.TabIndex = 5;
            this.lblPick1.Text = "0";
            this.lblPick1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pBox4
            // 
            this.pBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pBox4.Image = global::HashTable_Dictionary_Viewer.Properties.Resources._14;
            this.pBox4.Location = new System.Drawing.Point(327, 3);
            this.pBox4.Name = "pBox4";
            this.pBox4.Size = new System.Drawing.Size(102, 101);
            this.pBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBox4.TabIndex = 3;
            this.pBox4.TabStop = false;
            this.pBox4.Click += new System.EventHandler(this.pBox_Click);
            // 
            // pBox3
            // 
            this.pBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pBox3.Image = global::HashTable_Dictionary_Viewer.Properties.Resources._13;
            this.pBox3.Location = new System.Drawing.Point(219, 3);
            this.pBox3.Name = "pBox3";
            this.pBox3.Size = new System.Drawing.Size(102, 101);
            this.pBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBox3.TabIndex = 2;
            this.pBox3.TabStop = false;
            this.pBox3.Click += new System.EventHandler(this.pBox_Click);
            // 
            // pBox2
            // 
            this.pBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pBox2.Image = global::HashTable_Dictionary_Viewer.Properties.Resources._12;
            this.pBox2.Location = new System.Drawing.Point(111, 3);
            this.pBox2.Name = "pBox2";
            this.pBox2.Size = new System.Drawing.Size(102, 101);
            this.pBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBox2.TabIndex = 1;
            this.pBox2.TabStop = false;
            this.pBox2.Click += new System.EventHandler(this.pBox_Click);
            // 
            // pBox1
            // 
            this.pBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pBox1.Image = global::HashTable_Dictionary_Viewer.Properties.Resources._11;
            this.pBox1.Location = new System.Drawing.Point(3, 3);
            this.pBox1.Name = "pBox1";
            this.pBox1.Size = new System.Drawing.Size(102, 101);
            this.pBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBox1.TabIndex = 0;
            this.pBox1.TabStop = false;
            this.pBox1.Click += new System.EventHandler(this.pBox_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "※ 선호하는 항목을 선택해주세요";
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(10, 236);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(93, 12);
            this.label.TabIndex = 4;
            this.label.Text = "투표 진행 현황 :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 270);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(238, 12);
            this.label2.TabIndex = 5;
            this.label2.Text = "※ Dictionary의 Data를 화면에 보여줍니다.";
            // 
            // dgListView
            // 
            this.dgListView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgListView.Location = new System.Drawing.Point(82, 299);
            this.dgListView.Name = "dgListView";
            this.dgListView.RowTemplate.Height = 23;
            this.dgListView.Size = new System.Drawing.Size(300, 202);
            this.dgListView.TabIndex = 6;
            // 
            // lblTotalCount
            // 
            this.lblTotalCount.AutoSize = true;
            this.lblTotalCount.Location = new System.Drawing.Point(109, 236);
            this.lblTotalCount.Name = "lblTotalCount";
            this.lblTotalCount.Size = new System.Drawing.Size(31, 12);
            this.lblTotalCount.TabIndex = 7;
            this.lblTotalCount.Text = "0 / 0";
            // 
            // lblPlayerName
            // 
            this.lblPlayerName.AutoSize = true;
            this.lblPlayerName.Location = new System.Drawing.Point(80, 210);
            this.lblPlayerName.Name = "lblPlayerName";
            this.lblPlayerName.Size = new System.Drawing.Size(11, 12);
            this.lblPlayerName.TabIndex = 9;
            this.lblPlayerName.Text = "-";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(10, 210);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 12);
            this.label9.TabIndex = 8;
            this.label9.Text = "투표자 :";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(458, 513);
            this.Controls.Add(this.lblPlayerName);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lblTotalCount);
            this.Controls.Add(this.dgListView);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgListView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblPick4;
        private System.Windows.Forms.Label lblPick3;
        private System.Windows.Forms.Label lblPick2;
        private System.Windows.Forms.Label lblPick1;
        private System.Windows.Forms.PictureBox pBox4;
        private System.Windows.Forms.PictureBox pBox3;
        private System.Windows.Forms.PictureBox pBox2;
        private System.Windows.Forms.PictureBox pBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgListView;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblTotalCount;
        private System.Windows.Forms.Label lblPlayerName;
        private System.Windows.Forms.Label label9;
    }
}

