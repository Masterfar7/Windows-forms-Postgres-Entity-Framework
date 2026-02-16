namespace entity2
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.ClientSize = new System.Drawing.Size(816, 489);
            this.Text = "Employee Manager (Entity Framework)";

            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Size = new System.Drawing.Size(450, 450);
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();

            this.lblAddName = new System.Windows.Forms.Label();
            this.lblAddName.Text = "Name";
            this.lblAddName.Location = new System.Drawing.Point(460, 10);
            this.lblAddName.AutoSize = true;

            this.txtAddName = new System.Windows.Forms.TextBox();
            this.txtAddName.Name = "txtAddName";
            this.txtAddName.Location = new System.Drawing.Point(520, 7);
            this.txtAddName.Size = new System.Drawing.Size(270, 23);

            this.lblAddPosition = new System.Windows.Forms.Label();
            this.lblAddPosition.Text = "Position";
            this.lblAddPosition.Location = new System.Drawing.Point(460, 40);
            this.lblAddPosition.AutoSize = true;

            this.txtAddPosition = new System.Windows.Forms.TextBox();
            this.txtAddPosition.Name = "txtAddPosition";
            this.txtAddPosition.Location = new System.Drawing.Point(520, 37);
            this.txtAddPosition.Size = new System.Drawing.Size(270, 23);

            this.lblAddSalary = new System.Windows.Forms.Label();
            this.lblAddSalary.Text = "Salary";
            this.lblAddSalary.Location = new System.Drawing.Point(460, 70);
            this.lblAddSalary.AutoSize = true;

            this.txtAddSalary = new System.Windows.Forms.TextBox();
            this.txtAddSalary.Name = "txtAddSalary";
            this.txtAddSalary.Location = new System.Drawing.Point(520, 67);
            this.txtAddSalary.Size = new System.Drawing.Size(270, 23);

            this.btnAdd = new System.Windows.Forms.Button();
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Text = "Добавить";
            this.btnAdd.Location = new System.Drawing.Point(460, 97);
            this.btnAdd.Size = new System.Drawing.Size(330, 40);
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);

            this.lblUpdName = new System.Windows.Forms.Label();
            this.lblUpdName.Text = "Name";
            this.lblUpdName.Location = new System.Drawing.Point(460, 160);
            this.lblUpdName.AutoSize = true;

            this.txtUpdName = new System.Windows.Forms.TextBox();
            this.txtUpdName.Name = "txtUpdName";
            this.txtUpdName.Location = new System.Drawing.Point(520, 157);
            this.txtUpdName.Size = new System.Drawing.Size(270, 23);

            this.lblUpdPosition = new System.Windows.Forms.Label();
            this.lblUpdPosition.Text = "Position";
            this.lblUpdPosition.Location = new System.Drawing.Point(460, 190);
            this.lblUpdPosition.AutoSize = true;

            this.txtUpdPosition = new System.Windows.Forms.TextBox();
            this.txtUpdPosition.Name = "txtUpdPosition";
            this.txtUpdPosition.Location = new System.Drawing.Point(520, 187);
            this.txtUpdPosition.Size = new System.Drawing.Size(270, 23);

            this.lblUpdSalary = new System.Windows.Forms.Label();
            this.lblUpdSalary.Text = "Salary";
            this.lblUpdSalary.Location = new System.Drawing.Point(460, 220);
            this.lblUpdSalary.AutoSize = true;

            this.txtUpdSalary = new System.Windows.Forms.TextBox();
            this.txtUpdSalary.Name = "txtUpdSalary";
            this.txtUpdSalary.Location = new System.Drawing.Point(520, 217);
            this.txtUpdSalary.Size = new System.Drawing.Size(270, 23);

            this.lblUpdId = new System.Windows.Forms.Label();
            this.lblUpdId.Text = "ID";
            this.lblUpdId.Location = new System.Drawing.Point(460, 250);
            this.lblUpdId.AutoSize = true;

            this.txtUpdId = new System.Windows.Forms.TextBox();
            this.txtUpdId.Name = "txtUpdId";
            this.txtUpdId.Location = new System.Drawing.Point(520, 247);
            this.txtUpdId.Size = new System.Drawing.Size(270, 23);

            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Text = "Обновить";
            this.btnUpdate.Location = new System.Drawing.Point(460, 277);
            this.btnUpdate.Size = new System.Drawing.Size(330, 40);
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);

            this.lblDelId = new System.Windows.Forms.Label();
            this.lblDelId.Text = "ID";
            this.lblDelId.Location = new System.Drawing.Point(460, 340);
            this.lblDelId.AutoSize = true;

            this.txtDelId = new System.Windows.Forms.TextBox();
            this.txtDelId.Name = "txtDelId";
            this.txtDelId.Location = new System.Drawing.Point(485, 337);
            this.txtDelId.Size = new System.Drawing.Size(130, 23);

            this.btnDelete = new System.Windows.Forms.Button();
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Text = "Удалить";
            this.btnDelete.Location = new System.Drawing.Point(620, 335);
            this.btnDelete.Size = new System.Drawing.Size(90, 29);
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);

            this.lblFindId = new System.Windows.Forms.Label();
            this.lblFindId.Text = "ID";
            this.lblFindId.Location = new System.Drawing.Point(460, 375);
            this.lblFindId.AutoSize = true;

            this.txtFindId = new System.Windows.Forms.TextBox();
            this.txtFindId.Name = "txtFindId";
            this.txtFindId.Location = new System.Drawing.Point(485, 372);
            this.txtFindId.Size = new System.Drawing.Size(130, 23);

            this.btnFind = new System.Windows.Forms.Button();
            this.btnFind.Name = "btnFind";
            this.btnFind.Text = "Найти";
            this.btnFind.Location = new System.Drawing.Point(620, 370);
            this.btnFind.Size = new System.Drawing.Size(90, 29);
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);

            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Text = "Обновить всю таблицу";
            this.btnRefresh.Location = new System.Drawing.Point(460, 410);
            this.btnRefresh.Size = new System.Drawing.Size(330, 30);
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);

            this.Controls.Add(this.dataGridView1);

            this.Controls.Add(this.lblAddName);
            this.Controls.Add(this.txtAddName);
            this.Controls.Add(this.lblAddPosition);
            this.Controls.Add(this.txtAddPosition);
            this.Controls.Add(this.lblAddSalary);
            this.Controls.Add(this.txtAddSalary);
            this.Controls.Add(this.btnAdd);

            this.Controls.Add(this.lblUpdName);
            this.Controls.Add(this.txtUpdName);
            this.Controls.Add(this.lblUpdPosition);
            this.Controls.Add(this.txtUpdPosition);
            this.Controls.Add(this.lblUpdSalary);
            this.Controls.Add(this.txtUpdSalary);
            this.Controls.Add(this.lblUpdId);
            this.Controls.Add(this.txtUpdId);
            this.Controls.Add(this.btnUpdate);

            this.Controls.Add(this.lblDelId);
            this.Controls.Add(this.txtDelId);
            this.Controls.Add(this.btnDelete);

            this.Controls.Add(this.lblFindId);
            this.Controls.Add(this.txtFindId);
            this.Controls.Add(this.btnFind);

            this.Controls.Add(this.btnRefresh);

            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;

        private System.Windows.Forms.Label lblAddName;
        private System.Windows.Forms.TextBox txtAddName;
        private System.Windows.Forms.Label lblAddPosition;
        private System.Windows.Forms.TextBox txtAddPosition;
        private System.Windows.Forms.Label lblAddSalary;
        private System.Windows.Forms.TextBox txtAddSalary;
        private System.Windows.Forms.Button btnAdd;

        private System.Windows.Forms.Label lblUpdName;
        private System.Windows.Forms.TextBox txtUpdName;
        private System.Windows.Forms.Label lblUpdPosition;
        private System.Windows.Forms.TextBox txtUpdPosition;
        private System.Windows.Forms.Label lblUpdSalary;
        private System.Windows.Forms.TextBox txtUpdSalary;
        private System.Windows.Forms.Label lblUpdId;
        private System.Windows.Forms.TextBox txtUpdId;
        private System.Windows.Forms.Button btnUpdate;

        private System.Windows.Forms.Label lblDelId;
        private System.Windows.Forms.TextBox txtDelId;
        private System.Windows.Forms.Button btnDelete;

        private System.Windows.Forms.Label lblFindId;
        private System.Windows.Forms.TextBox txtFindId;
        private System.Windows.Forms.Button btnFind;

        private System.Windows.Forms.Button btnRefresh;
    }
}