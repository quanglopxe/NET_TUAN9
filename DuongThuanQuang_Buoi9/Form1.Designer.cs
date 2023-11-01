namespace DuongThuanQuang_Buoi9
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_Id = new System.Windows.Forms.TextBox();
            this.btn_Add = new System.Windows.Forms.Button();
            this.txt_Name = new System.Windows.Forms.TextBox();
            this.btn_Del = new System.Windows.Forms.Button();
            this.btn_Update = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.dtgv = new System.Windows.Forms.DataGridView();
            this.MAKHOA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TENKHOA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(62, 58);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã khoa";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(62, 96);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tên Khoa";
            // 
            // txt_Id
            // 
            this.txt_Id.Location = new System.Drawing.Point(165, 55);
            this.txt_Id.Name = "txt_Id";
            this.txt_Id.Size = new System.Drawing.Size(151, 25);
            this.txt_Id.TabIndex = 1;
            this.txt_Id.Leave += new System.EventHandler(this.txt_Id_Leave);
            // 
            // btn_Add
            // 
            this.btn_Add.Location = new System.Drawing.Point(60, 183);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(75, 37);
            this.btn_Add.TabIndex = 2;
            this.btn_Add.Text = "Thêm";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // txt_Name
            // 
            this.txt_Name.Location = new System.Drawing.Point(165, 93);
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.Size = new System.Drawing.Size(151, 25);
            this.txt_Name.TabIndex = 1;
            this.txt_Name.Leave += new System.EventHandler(this.txt_Name_Leave);
            // 
            // btn_Del
            // 
            this.btn_Del.Location = new System.Drawing.Point(150, 183);
            this.btn_Del.Name = "btn_Del";
            this.btn_Del.Size = new System.Drawing.Size(75, 37);
            this.btn_Del.TabIndex = 2;
            this.btn_Del.Text = "Xóa";
            this.btn_Del.UseVisualStyleBackColor = true;
            // 
            // btn_Update
            // 
            this.btn_Update.Location = new System.Drawing.Point(241, 183);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(75, 37);
            this.btn_Update.TabIndex = 2;
            this.btn_Update.Text = "Sửa";
            this.btn_Update.UseVisualStyleBackColor = true;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // dtgv
            // 
            this.dtgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MAKHOA,
            this.TENKHOA});
            this.dtgv.Location = new System.Drawing.Point(370, 31);
            this.dtgv.Name = "dtgv";
            this.dtgv.Size = new System.Drawing.Size(392, 209);
            this.dtgv.TabIndex = 3;
            // 
            // MAKHOA
            // 
            this.MAKHOA.HeaderText = "MAKHOA";
            this.MAKHOA.Name = "MAKHOA";
            // 
            // TENKHOA
            // 
            this.TENKHOA.HeaderText = "TENKHOA";
            this.TENKHOA.Name = "TENKHOA";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(805, 420);
            this.Controls.Add(this.dtgv);
            this.Controls.Add(this.btn_Update);
            this.Controls.Add(this.btn_Del);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.txt_Name);
            this.Controls.Add(this.txt_Id);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_Id;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.TextBox txt_Name;
        private System.Windows.Forms.Button btn_Del;
        private System.Windows.Forms.Button btn_Update;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.DataGridView dtgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn MAKHOA;
        private System.Windows.Forms.DataGridViewTextBoxColumn TENKHOA;
    }
}

