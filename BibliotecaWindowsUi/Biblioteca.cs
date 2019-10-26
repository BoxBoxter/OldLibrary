using Dapper;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BibliotecaWindowsUi
{
    public partial class Biblioteca : Form
    {
        private static string connectionString = "Server=127.0.0.2;Database=biblioteca;Uid=lector;Pwd=seCret_16;";
        bool existsAuthorsForm = false;
        AuthorForm authorsForm = null;

        public Biblioteca()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(560, 0);
        }
        
        private void FindButton_Click(object sender, EventArgs e)
        {
            List<Book> books = new List<Book>();
            MySqlConnection connection = new MySqlConnection(connectionString);
            string sql = $"SELECT ID_LLIB, TITOL FROM LLIBRES" +
                            $" WHERE TITOL LIKE '%{SearchBook.Text}%'";
            books = connection.Query<Book>(sql).ToList(); books = connection.Query<Book>(sql).ToList();

            BookSearch.DataSource = books;
            BookSearch.DisplayMember = "FullInfo";
            /*
            foreach(var book in books)
            {
                BookSearch.Items.Add(book.ID_LLIB + ":\t "+ book.TITOL );
            }
            for (int i = 0; i < books.Count; i++)
            {
                booksListBox.Items.Add(books[i].TITOL);
            }*/

            connection.Close();
        }

        private void ChangeAuthor_Click(object sender, EventArgs e)
        {
            this.Hide(); //  Or Close()?
            // create new only if not exists
            if (!existsAuthorsForm)
            {
                authorsForm = new AuthorForm();
                authorsForm.Show();
                //position right to this
                authorsForm.Location = new Point(this.Location.X + this.Size.Width + 10,
                    this.Location.Y);
                existsAuthorsForm = true;
            }

            authorsForm?.Show();
        }

        private void Biblioteca_FormClosed(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void BookSearch_DoubleClick(object sender, EventArgs e)
        {
            Book selectedBook = BookSearch.SelectedItem as Book;
            BookDetailsFormDialog bookDetailsForm =
                new BookDetailsFormDialog(selectedBook);

            //Button prop DialogResult

            DialogResult result = bookDetailsForm.ShowDialog(this);

            if (result == DialogResult.OK)
            {
                // Read the contents of testDialog's TextBox.
                //this.txtResult.Text = testDialog.TextBox1.Text;
            }
            else if (result == DialogResult.Cancel)
            {
                //this.txtResult.Text = "Cancelled";

            }
            bookDetailsForm.Dispose();
        }
    }
}
