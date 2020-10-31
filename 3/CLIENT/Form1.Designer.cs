namespace CLIENT
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
            this.UpdateButton = new System.Windows.Forms.Button();
            this.recordGrid = new System.Windows.Forms.DataGridView();
            this.Check = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Computers = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateInput = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.removeButton = new System.Windows.Forms.Button();
            this.searchButton = new System.Windows.Forms.Button();
            this.clearSearchButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.recordGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // UpdateButton
            // 
            this.UpdateButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(225)))), ((int)(((byte)(86)))));
            this.UpdateButton.Location = new System.Drawing.Point(41, 225);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(224, 39);
            this.UpdateButton.TabIndex = 0;
            this.UpdateButton.Text = "Сохранить";
            this.UpdateButton.UseVisualStyleBackColor = false;
            this.UpdateButton.Click += new System.EventHandler(this.UpdateButton_Click);
            // 
            // recordGrid
            // 
            this.recordGrid.AllowUserToOrderColumns = true;
            this.recordGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.recordGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Check,
            this.Date,
            this.Computers});
            this.recordGrid.Location = new System.Drawing.Point(327, 12);
            this.recordGrid.Name = "recordGrid";
            this.recordGrid.RowTemplate.Height = 24;
            this.recordGrid.Size = new System.Drawing.Size(565, 436);
            this.recordGrid.TabIndex = 1;
            // 
            // Check
            // 
            this.Check.FillWeight = 80F;
            this.Check.HeaderText = "";
            this.Check.MinimumWidth = 3;
            this.Check.Name = "Check";
            this.Check.Width = 80;
            // 
            // Date
            // 
            this.Date.FillWeight = 150F;
            this.Date.HeaderText = "Дата";
            this.Date.MinimumWidth = 8;
            this.Date.Name = "Date";
            this.Date.Width = 150;
            // 
            // Computers
            // 
            this.Computers.FillWeight = 150F;
            this.Computers.HeaderText = "Компьютеры";
            this.Computers.MinimumWidth = 8;
            this.Computers.Name = "Computers";
            this.Computers.Width = 150;
            // 
            // dateInput
            // 
            this.dateInput.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateInput.Location = new System.Drawing.Point(41, 93);
            this.dateInput.Name = "dateInput";
            this.dateInput.Size = new System.Drawing.Size(224, 27);
            this.dateInput.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(37, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 23);
            this.label1.TabIndex = 4;
            this.label1.Text = "Дата";
            // 
            // removeButton
            // 
            this.removeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(73)))), ((int)(((byte)(64)))));
            this.removeButton.Location = new System.Drawing.Point(41, 284);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(224, 39);
            this.removeButton.TabIndex = 6;
            this.removeButton.Text = "Удалить выделенное";
            this.removeButton.UseVisualStyleBackColor = false;
            this.removeButton.Click += new System.EventHandler(this.removeButton_Click);
            // 
            // searchButton
            // 
            this.searchButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(208)))), ((int)(((byte)(64)))));
            this.searchButton.Location = new System.Drawing.Point(41, 157);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(192, 39);
            this.searchButton.TabIndex = 7;
            this.searchButton.Text = "Поиск";
            this.searchButton.UseVisualStyleBackColor = false;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // clearSearchButton
            // 
            this.clearSearchButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(158)))), ((int)(((byte)(0)))));
            this.clearSearchButton.Location = new System.Drawing.Point(234, 157);
            this.clearSearchButton.Name = "clearSearchButton";
            this.clearSearchButton.Size = new System.Drawing.Size(31, 39);
            this.clearSearchButton.TabIndex = 8;
            this.clearSearchButton.Text = "X";
            this.clearSearchButton.UseVisualStyleBackColor = false;
            this.clearSearchButton.Click += new System.EventHandler(this.clearSearchButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(192)))), ((int)(((byte)(206)))));
            this.ClientSize = new System.Drawing.Size(930, 460);
            this.Controls.Add(this.clearSearchButton);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.removeButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateInput);
            this.Controls.Add(this.recordGrid);
            this.Controls.Add(this.UpdateButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.recordGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button UpdateButton;
        private System.Windows.Forms.DataGridView recordGrid;
        private System.Windows.Forms.DateTimePicker dateInput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button removeButton;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Check;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Computers;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Button clearSearchButton;
    }
}

