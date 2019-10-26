using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dapper;
using MySql.Data.MySqlClient;


namespace BibliotecaWindowsUi
{

    public partial class AuthorForm : Form
    {
        private static string connectionString = "Server=127.0.0.1;Database=biblioteca;Uid=lector;Pwd=seCret_16;";

        public AuthorForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(0, 0);
        }

        private void FindAuthors_Click(object sender, EventArgs e)
        {
            List<BooksAuthor> booksAuthors = new List<BooksAuthor>();
            MySqlConnection connection = new MySqlConnection(connectionString);
            string sql = $"SELECT ID_AUT, NOM_AUT FROM AUTORS WHERE NOM_AUT LIKE '%{SearchAuthorsBox.Text}%'";
            booksAuthors = connection.Query<BooksAuthor>(sql).ToList();

            ShowBox.DataSource = booksAuthors;
            ShowBox.DisplayMember = "FullInfo";
        }

        private void BookChange_Click(object sender, EventArgs e)
        {
            Biblioteca biblioteca = new Biblioteca();

            biblioteca.Show();
            this.Hide();
        }
        private void AuthorForm_FormClosed(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}
