namespace WindowsFormsApp1
{
    partial class GenealogyTree
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtName = new System.Windows.Forms.TextBox();
            this.btnAddPerson = new System.Windows.Forms.Button();
            this.mtxtBirthDate = new System.Windows.Forms.MaskedTextBox();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.listPeople = new System.Windows.Forms.ListBox();
            this.btnAddParent = new System.Windows.Forms.Button();
            this.btnShowTree = new System.Windows.Forms.Button();
            this.treevFamily = new System.Windows.Forms.TreeView();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.btnSaveTree = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(42, 51);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(120, 22);
            this.txtName.TabIndex = 0;
            // 
            // btnAddPerson
            // 
            this.btnAddPerson.Location = new System.Drawing.Point(42, 167);
            this.btnAddPerson.Name = "btnAddPerson";
            this.btnAddPerson.Size = new System.Drawing.Size(120, 23);
            this.btnAddPerson.TabIndex = 2;
            this.btnAddPerson.Text = "Add Person";
            this.btnAddPerson.UseVisualStyleBackColor = true;
            this.btnAddPerson.Click += new System.EventHandler(this.btnAddPerson_Click);
            // 
            // mtxtBirthDate
            // 
            this.mtxtBirthDate.Location = new System.Drawing.Point(42, 139);
            this.mtxtBirthDate.Mask = "00/00/0000";
            this.mtxtBirthDate.Name = "mtxtBirthDate";
            this.mtxtBirthDate.Size = new System.Drawing.Size(120, 22);
            this.mtxtBirthDate.TabIndex = 7;
            this.mtxtBirthDate.ValidatingType = typeof(System.DateTime);
            // 
            // txtSurname
            // 
            this.txtSurname.Location = new System.Drawing.Point(42, 95);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(120, 22);
            this.txtSurname.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 16);
            this.label1.TabIndex = 9;
            this.label1.Text = "Ім\'я";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 16);
            this.label2.TabIndex = 10;
            this.label2.Text = "Прізвище";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 16);
            this.label3.TabIndex = 11;
            this.label3.Text = "Дата народження";
            // 
            // listPeople
            // 
            this.listPeople.FormattingEnabled = true;
            this.listPeople.ItemHeight = 16;
            this.listPeople.Location = new System.Drawing.Point(182, 51);
            this.listPeople.Name = "listPeople";
            this.listPeople.Size = new System.Drawing.Size(170, 132);
            this.listPeople.TabIndex = 3;
            // 
            // btnAddParent
            // 
            this.btnAddParent.Location = new System.Drawing.Point(182, 189);
            this.btnAddParent.Name = "btnAddParent";
            this.btnAddParent.Size = new System.Drawing.Size(120, 23);
            this.btnAddParent.TabIndex = 4;
            this.btnAddParent.Text = "Add Parent";
            this.btnAddParent.UseVisualStyleBackColor = true;
            this.btnAddParent.Click += new System.EventHandler(this.btnAddParent_Click);
            // 
            // btnShowTree
            // 
            this.btnShowTree.Location = new System.Drawing.Point(385, 51);
            this.btnShowTree.Name = "btnShowTree";
            this.btnShowTree.Size = new System.Drawing.Size(120, 23);
            this.btnShowTree.TabIndex = 13;
            this.btnShowTree.Text = "Show Tree";
            this.btnShowTree.UseVisualStyleBackColor = true;
            this.btnShowTree.Click += new System.EventHandler(this.btnShowTree_Click);
            // 
            // treevFamily
            // 
            this.treevFamily.Location = new System.Drawing.Point(385, 80);
            this.treevFamily.Name = "treevFamily";
            this.treevFamily.Size = new System.Drawing.Size(365, 198);
            this.treevFamily.TabIndex = 12;
            // 
            // btnSaveTree
            // 
            this.btnSaveTree.Location = new System.Drawing.Point(630, 51);
            this.btnSaveTree.Name = "btnSaveTree";
            this.btnSaveTree.Size = new System.Drawing.Size(120, 23);
            this.btnSaveTree.TabIndex = 14;
            this.btnSaveTree.Text = "Save Tree";
            this.btnSaveTree.UseVisualStyleBackColor = true;
            this.btnSaveTree.Click += new System.EventHandler(this.btnSaveTree_Click);
            // 
            // GenealogyTree
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(820, 398);
            this.Controls.Add(this.btnSaveTree);
            this.Controls.Add(this.btnShowTree);
            this.Controls.Add(this.treevFamily);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSurname);
            this.Controls.Add(this.mtxtBirthDate);
            this.Controls.Add(this.btnAddParent);
            this.Controls.Add(this.listPeople);
            this.Controls.Add(this.btnAddPerson);
            this.Controls.Add(this.txtName);
            this.Name = "GenealogyTree";
            this.Text = "Генеалогічне дерево";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button btnAddPerson;
        private System.Windows.Forms.MaskedTextBox mtxtBirthDate;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox listPeople;
        private System.Windows.Forms.Button btnAddParent;
        private System.Windows.Forms.Button btnShowTree;
        private System.Windows.Forms.TreeView treevFamily;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button btnSaveTree;
    }
}

