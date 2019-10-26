namespace BibliotecaWindowsUi
{
    partial class Biblioteca
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
            this.label3 = new System.Windows.Forms.Label();
            this.SearchBook = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.FindButton = new System.Windows.Forms.Button();
            this.BookSearch = new System.Windows.Forms.ListBox();
            this.ChangeAuthor = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label3.Location = new System.Drawing.Point(12, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(663, 52);
            this.label3.TabIndex = 0;
            this.label3.Text = "CIFP Pau Casesnoves";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // SearchBook
            // 
            this.SearchBook.Location = new System.Drawing.Point(115, 116);
            this.SearchBook.Name = "SearchBook";
            this.SearchBook.Size = new System.Drawing.Size(457, 20);
            this.SearchBook.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(19, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 16);
            this.label4.TabIndex = 2;
            this.label4.Text = "Search Book:";
            // 
            // FindButton
            // 
            this.FindButton.Location = new System.Drawing.Point(589, 116);
            this.FindButton.Name = "FindButton";
            this.FindButton.Size = new System.Drawing.Size(75, 20);
            this.FindButton.TabIndex = 3;
            this.FindButton.Text = "Find";
            this.FindButton.UseVisualStyleBackColor = true;
            this.FindButton.Click += new System.EventHandler(this.FindButton_Click);
            // 
            // BookSearch
            // 
            this.BookSearch.FormattingEnabled = true;
            this.BookSearch.Location = new System.Drawing.Point(115, 173);
            this.BookSearch.Name = "BookSearch";
            this.BookSearch.Size = new System.Drawing.Size(457, 238);
            this.BookSearch.TabIndex = 4;
            // 
            // ChangeAuthor
            // 
            this.ChangeAuthor.Location = new System.Drawing.Point(589, 359);
            this.ChangeAuthor.Name = "ChangeAuthor";
            this.ChangeAuthor.Size = new System.Drawing.Size(75, 52);
            this.ChangeAuthor.TabIndex = 5;
            this.ChangeAuthor.Text = "Change Author Form";
            this.ChangeAuthor.UseVisualStyleBackColor = true;
            this.ChangeAuthor.Click += new System.EventHandler(this.ChangeAuthor_Click);
            // 
            // Biblioteca
            // 
            this.ClientSize = new System.Drawing.Size(687, 450);
            this.Controls.Add(this.ChangeAuthor);
            this.Controls.Add(this.BookSearch);
            this.Controls.Add(this.FindButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.SearchBook);
            this.Controls.Add(this.label3);
            this.Name = "Biblioteca";
            this.Text = "Biblioteca";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox BooksListBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox SearchBook;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button FindButton;
        private System.Windows.Forms.ListBox BookSearch;
        private System.Windows.Forms.Button ChangeAuthor;
    }
}

