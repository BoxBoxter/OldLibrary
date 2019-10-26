namespace BibliotecaWindowsUi
{
    partial class AuthorForm
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
            this.Title = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SearchAuthorsBox = new System.Windows.Forms.TextBox();
            this.FindAuthors = new System.Windows.Forms.Button();
            this.ShowBox = new System.Windows.Forms.ListBox();
            this.BookChange = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Title
            // 
            this.Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.Title.Location = new System.Drawing.Point(12, 9);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(663, 52);
            this.Title.TabIndex = 0;
            this.Title.Text = "CIFP Pau Casesnoves";
            this.Title.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Search Authors:";
            // 
            // SearchAuthorsBox
            // 
            this.SearchAuthorsBox.Location = new System.Drawing.Point(115, 116);
            this.SearchAuthorsBox.Name = "SearchAuthorsBox";
            this.SearchAuthorsBox.Size = new System.Drawing.Size(457, 20);
            this.SearchAuthorsBox.TabIndex = 2;
            // 
            // FindAuthors
            // 
            this.FindAuthors.Location = new System.Drawing.Point(589, 116);
            this.FindAuthors.Name = "FindAuthors";
            this.FindAuthors.Size = new System.Drawing.Size(75, 20);
            this.FindAuthors.TabIndex = 3;
            this.FindAuthors.Text = "Find";
            this.FindAuthors.UseVisualStyleBackColor = true;
            this.FindAuthors.Click += new System.EventHandler(this.FindAuthors_Click);
            // 
            // ShowBox
            // 
            this.ShowBox.FormattingEnabled = true;
            this.ShowBox.Location = new System.Drawing.Point(115, 173);
            this.ShowBox.Name = "ShowBox";
            this.ShowBox.Size = new System.Drawing.Size(457, 238);
            this.ShowBox.TabIndex = 4;
            // 
            // BookChange
            // 
            this.BookChange.Location = new System.Drawing.Point(589, 359);
            this.BookChange.Name = "BookChange";
            this.BookChange.Size = new System.Drawing.Size(75, 52);
            this.BookChange.TabIndex = 5;
            this.BookChange.Text = "Change BookForm";
            this.BookChange.UseVisualStyleBackColor = true;
            this.BookChange.Click += new System.EventHandler(this.BookChange_Click);
            // 
            // AuthorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(687, 450);
            this.Controls.Add(this.BookChange);
            this.Controls.Add(this.ShowBox);
            this.Controls.Add(this.FindAuthors);
            this.Controls.Add(this.SearchAuthorsBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Title);
            this.Name = "AuthorForm";
            this.Text = "AuthorForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox SearchAuthorsBox;
        private System.Windows.Forms.Button FindAuthors;
        private System.Windows.Forms.ListBox ShowBox;
        private System.Windows.Forms.Button BookChange;
    }
}