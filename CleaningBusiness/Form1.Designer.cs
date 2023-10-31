namespace CleaningBusiness
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
            this.resultGridView = new System.Windows.Forms.DataGridView();
            this.txtCompanyName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCompanySearch = new System.Windows.Forms.Button();
            this.btnSpecializationSearch = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSpecialization = new System.Windows.Forms.TextBox();
            this.btnHighestRate = new System.Windows.Forms.Button();
            this.btnLowestRate = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.resultGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // resultGridView
            // 
            this.resultGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.resultGridView.Location = new System.Drawing.Point(12, 12);
            this.resultGridView.Name = "resultGridView";
            this.resultGridView.Size = new System.Drawing.Size(537, 426);
            this.resultGridView.TabIndex = 0;
            // 
            // txtCompanyName
            // 
            this.txtCompanyName.Location = new System.Drawing.Point(646, 12);
            this.txtCompanyName.Name = "txtCompanyName";
            this.txtCompanyName.Size = new System.Drawing.Size(100, 20);
            this.txtCompanyName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(555, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Company Name:";
            // 
            // btnCompanySearch
            // 
            this.btnCompanySearch.Location = new System.Drawing.Point(752, 10);
            this.btnCompanySearch.Name = "btnCompanySearch";
            this.btnCompanySearch.Size = new System.Drawing.Size(173, 23);
            this.btnCompanySearch.TabIndex = 3;
            this.btnCompanySearch.Text = "Search";
            this.btnCompanySearch.UseVisualStyleBackColor = true;
            this.btnCompanySearch.Click += new System.EventHandler(this.btnCompanySearch_Click);
            // 
            // btnSpecializationSearch
            // 
            this.btnSpecializationSearch.Location = new System.Drawing.Point(752, 39);
            this.btnSpecializationSearch.Name = "btnSpecializationSearch";
            this.btnSpecializationSearch.Size = new System.Drawing.Size(173, 23);
            this.btnSpecializationSearch.TabIndex = 6;
            this.btnSpecializationSearch.Text = "Search";
            this.btnSpecializationSearch.UseVisualStyleBackColor = true;
            this.btnSpecializationSearch.Click += new System.EventHandler(this.btnSpecializationSearch_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(555, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Specialization:";
            // 
            // txtSpecialization
            // 
            this.txtSpecialization.Location = new System.Drawing.Point(646, 41);
            this.txtSpecialization.Name = "txtSpecialization";
            this.txtSpecialization.Size = new System.Drawing.Size(100, 20);
            this.txtSpecialization.TabIndex = 4;
            // 
            // btnHighestRate
            // 
            this.btnHighestRate.Location = new System.Drawing.Point(558, 77);
            this.btnHighestRate.Name = "btnHighestRate";
            this.btnHighestRate.Size = new System.Drawing.Size(188, 23);
            this.btnHighestRate.TabIndex = 7;
            this.btnHighestRate.Text = "Highest Hourly Rate";
            this.btnHighestRate.UseVisualStyleBackColor = true;
            this.btnHighestRate.Click += new System.EventHandler(this.btnHighestRate_Click);
            // 
            // btnLowestRate
            // 
            this.btnLowestRate.Location = new System.Drawing.Point(752, 77);
            this.btnLowestRate.Name = "btnLowestRate";
            this.btnLowestRate.Size = new System.Drawing.Size(173, 23);
            this.btnLowestRate.TabIndex = 8;
            this.btnLowestRate.Text = "Lowest Hourly Rate";
            this.btnLowestRate.UseVisualStyleBackColor = true;
            this.btnLowestRate.Click += new System.EventHandler(this.btnLowestRate_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.Location = new System.Drawing.Point(558, 107);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(367, 68);
            this.btnEdit.TabIndex = 9;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(937, 450);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnLowestRate);
            this.Controls.Add(this.btnHighestRate);
            this.Controls.Add(this.btnSpecializationSearch);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSpecialization);
            this.Controls.Add(this.btnCompanySearch);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCompanyName);
            this.Controls.Add(this.resultGridView);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.resultGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView resultGridView;
        private System.Windows.Forms.TextBox txtCompanyName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCompanySearch;
        private System.Windows.Forms.Button btnSpecializationSearch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSpecialization;
        private System.Windows.Forms.Button btnHighestRate;
        private System.Windows.Forms.Button btnLowestRate;
        private System.Windows.Forms.Button btnEdit;
    }
}

