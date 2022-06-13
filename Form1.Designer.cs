namespace Modin
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SecureLevel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addPharmacyButton = new System.Windows.Forms.Button();
            this.removePharmacyButton = new System.Windows.Forms.Button();
            this.removeMedicineButton = new System.Windows.Forms.Button();
            this.changeMedicineButton = new System.Windows.Forms.Button();
            this.addMedicineButton = new System.Windows.Forms.Button();
            this.removeMedicineFromPharmacy = new System.Windows.Forms.Button();
            this.addMedicineToPharmacyButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Title,
            this.SecureLevel});
            this.dataGridView1.Location = new System.Drawing.Point(22, 41);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(493, 258);
            this.dataGridView1.TabIndex = 0;
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.MinimumWidth = 6;
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            // 
            // Title
            // 
            this.Title.DataPropertyName = "Title";
            this.Title.HeaderText = "Название";
            this.Title.MinimumWidth = 6;
            this.Title.Name = "Title";
            this.Title.ReadOnly = true;
            // 
            // SecureLevel
            // 
            this.SecureLevel.DataPropertyName = "Address";
            this.SecureLevel.HeaderText = "Адрес";
            this.SecureLevel.MinimumWidth = 6;
            this.SecureLevel.Name = "SecureLevel";
            this.SecureLevel.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "аптеки";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(547, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "лекарства";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.dataGridView2.Location = new System.Drawing.Point(547, 41);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 29;
            this.dataGridView2.Size = new System.Drawing.Size(493, 258);
            this.dataGridView2.TabIndex = 2;
            this.dataGridView2.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_RowEnter);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Title";
            this.dataGridViewTextBoxColumn2.HeaderText = "Название";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Package";
            this.dataGridViewTextBoxColumn3.HeaderText = "Упаковка";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Dosage";
            this.dataGridViewTextBoxColumn4.HeaderText = "Дозировка";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 353);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "лекарства в аптеке";
            // 
            // dataGridView3
            // 
            this.dataGridView3.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.Column1,
            this.Column2});
            this.dataGridView3.Location = new System.Drawing.Point(22, 376);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.RowHeadersWidth = 51;
            this.dataGridView3.RowTemplate.Height = 29;
            this.dataGridView3.Size = new System.Drawing.Size(1018, 258);
            this.dataGridView3.TabIndex = 4;
            this.dataGridView3.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView3_RowEnter);
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn5.HeaderText = "Id";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "PharmacyId";
            this.dataGridViewTextBoxColumn6.HeaderText = "Id аптеки";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "MedicineId";
            this.dataGridViewTextBoxColumn7.HeaderText = "Id лекарства";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Price";
            this.dataGridViewTextBoxColumn8.HeaderText = "Цена";
            this.dataGridViewTextBoxColumn8.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "Amount";
            this.Column1.HeaderText = "Количество";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "Date";
            this.Column2.HeaderText = "Дата поступления";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // addPharmacyButton
            // 
            this.addPharmacyButton.Location = new System.Drawing.Point(22, 305);
            this.addPharmacyButton.Name = "addPharmacyButton";
            this.addPharmacyButton.Size = new System.Drawing.Size(125, 33);
            this.addPharmacyButton.TabIndex = 6;
            this.addPharmacyButton.Text = "Добавить";
            this.addPharmacyButton.UseVisualStyleBackColor = true;
            this.addPharmacyButton.Click += new System.EventHandler(this.addPharmacyButton_Click);
            // 
            // removePharmacyButton
            // 
            this.removePharmacyButton.Location = new System.Drawing.Point(390, 305);
            this.removePharmacyButton.Name = "removePharmacyButton";
            this.removePharmacyButton.Size = new System.Drawing.Size(125, 33);
            this.removePharmacyButton.TabIndex = 8;
            this.removePharmacyButton.Text = "Удалить";
            this.removePharmacyButton.UseVisualStyleBackColor = true;
            this.removePharmacyButton.Click += new System.EventHandler(this.deleteBookButton_Click);
            // 
            // removeMedicineButton
            // 
            this.removeMedicineButton.Location = new System.Drawing.Point(915, 305);
            this.removeMedicineButton.Name = "removeMedicineButton";
            this.removeMedicineButton.Size = new System.Drawing.Size(125, 33);
            this.removeMedicineButton.TabIndex = 11;
            this.removeMedicineButton.Text = "Удалить";
            this.removeMedicineButton.UseVisualStyleBackColor = true;
            this.removeMedicineButton.Click += new System.EventHandler(this.deleteReaderButton_Click);
            // 
            // changeMedicineButton
            // 
            this.changeMedicineButton.Location = new System.Drawing.Point(730, 305);
            this.changeMedicineButton.Name = "changeMedicineButton";
            this.changeMedicineButton.Size = new System.Drawing.Size(125, 33);
            this.changeMedicineButton.TabIndex = 10;
            this.changeMedicineButton.Text = "Изменить";
            this.changeMedicineButton.UseVisualStyleBackColor = true;
            this.changeMedicineButton.Click += new System.EventHandler(this.changeReaderButton_Click);
            // 
            // addMedicineButton
            // 
            this.addMedicineButton.Location = new System.Drawing.Point(547, 305);
            this.addMedicineButton.Name = "addMedicineButton";
            this.addMedicineButton.Size = new System.Drawing.Size(125, 33);
            this.addMedicineButton.TabIndex = 9;
            this.addMedicineButton.Text = "Добавить";
            this.addMedicineButton.UseVisualStyleBackColor = true;
            this.addMedicineButton.Click += new System.EventHandler(this.addMedicineButton_Click);
            // 
            // removeMedicineFromPharmacy
            // 
            this.removeMedicineFromPharmacy.Location = new System.Drawing.Point(915, 650);
            this.removeMedicineFromPharmacy.Name = "removeMedicineFromPharmacy";
            this.removeMedicineFromPharmacy.Size = new System.Drawing.Size(125, 33);
            this.removeMedicineFromPharmacy.TabIndex = 14;
            this.removeMedicineFromPharmacy.Text = "Удалить";
            this.removeMedicineFromPharmacy.UseVisualStyleBackColor = true;
            this.removeMedicineFromPharmacy.Click += new System.EventHandler(this.removeMedicineFromPharmacyButton_Click);
            // 
            // addMedicineToPharmacyButton
            // 
            this.addMedicineToPharmacyButton.Location = new System.Drawing.Point(22, 650);
            this.addMedicineToPharmacyButton.Name = "addMedicineToPharmacyButton";
            this.addMedicineToPharmacyButton.Size = new System.Drawing.Size(125, 33);
            this.addMedicineToPharmacyButton.TabIndex = 12;
            this.addMedicineToPharmacyButton.Text = "Добавить";
            this.addMedicineToPharmacyButton.UseVisualStyleBackColor = true;
            this.addMedicineToPharmacyButton.Click += new System.EventHandler(this.addMedicineToPharmacyButton_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(480, 652);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(145, 29);
            this.button1.TabIndex = 15;
            this.button1.Text = "Изменить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1103, 724);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.removeMedicineFromPharmacy);
            this.Controls.Add(this.addMedicineToPharmacyButton);
            this.Controls.Add(this.removeMedicineButton);
            this.Controls.Add(this.changeMedicineButton);
            this.Controls.Add(this.addMedicineButton);
            this.Controls.Add(this.removePharmacyButton);
            this.Controls.Add(this.addPharmacyButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Модин";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dataGridView1;
        private Label label1;
        private Label label2;
        private DataGridView dataGridView2;
        private Label label3;
        private DataGridView dataGridView3;
        private Button addPharmacyButton;
        private Button removePharmacyButton;
        private Button removeMedicineButton;
        private Button changeMedicineButton;
        private Button addMedicineButton;
        private Button removeMedicineFromPharmacy;
        private Button addMedicineToPharmacyButton;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Title;
        private DataGridViewTextBoxColumn SecureLevel;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private Button button1;
    }
}