using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dictionary_WF_
{
    public partial class Main : Form
    {
        List<String> listitem;
        static String searchtext = "Пошук", textedit = "Редагувати", textsave = "Зберегти", textadd = "Додати", textdel ="Видалити", textcancel = "Скасувати";
        
        public Main()
        {
            
            InitializeComponent();
            Directory.CreateDirectory("Image");
            sql();
            updatetree("");
            
        }
        private void updatetree(string str)
        {
            listitem = sqllist("SELECT [Title] FROM [Table]");
            list.Items.Clear();
            foreach (string str2 in listitem)
            {
                if (str2.Contains(str))
                    list.Items.Add(str2);
            }
        }
        private List<string> sqllist(String str)
        {  /// Повернення списку 
            List<string> sql = new List<string>();
            using (SQLiteConnection Connect = new SQLiteConnection(@"Data Source=Dictionary.db; Version=3;"))
            {
                string commandText = str;
                SQLiteCommand Command = new SQLiteCommand(commandText, Connect);
                Connect.Open();
                SQLiteDataReader read = Command.ExecuteReader();
                int i = 0;
                string st = str.Remove(str.IndexOf("]")).Substring(str.IndexOf("[") + 1);
                while (read.Read())
                {
                    sql.Add(read[st].ToString());
                    i++;
                }
                Command.Dispose();
                Connect.Close();
            }
            return sql;
        }
        private String sqlCont(String str)
        {  /// Повернення списку 
            List<string> sql = new List<string>();
            using (SQLiteConnection Connect = new SQLiteConnection(@"Data Source=Dictionary.db; Version=3;"))
            {
                string commandText = str;
                SQLiteCommand Command = new SQLiteCommand(commandText, Connect);
                Connect.Open();
                SQLiteDataReader read = Command.ExecuteReader();
                while (read.Read())
                {
                    str = read["Content"].ToString();
                }
                Connect.Close();
            }
            return str;
        }
        private void sql()
        {  //// Перевірка наявності бази данних
            if (!File.Exists("Dictionary.db"))
            {
                SQLiteConnection.CreateFile("Dictionary.db"); // Створення бази данних
                sqlcmd("CREATE TABLE IF NOT EXISTS [Table] ( " +    //// Шаблонна таблиця
                        "[id] INTEGER PRIMARY KEY AUTOINCREMENT NOT NULL, " +
                        "[Title] TEXT NOT NULL , " +
                        "[Content] TEXT, " +
                        "UNIQUE (Title));");
            }
        }
        public void sqlcmd(String str)   //// Команди SQLite
        {
            using (SQLiteConnection Connect = new SQLiteConnection(@"Data Source=Dictionary.db; Version=3;"))
            {
                string commandText = str;
                SQLiteCommand Command = new SQLiteCommand(commandText, Connect);
                Connect.Open();
                Command.ExecuteNonQuery();
                Connect.Close();
            }
        }
        private void search_TextChanged(object sender, EventArgs e)
        {
            
            if (search.Text != searchtext)
            {
                list.Items.Clear();
                updatetree(search.Text);
            }
        }

        private void editpic_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
                {
                    openFileDialog.InitialDirectory = "c:\\";
                    openFileDialog.Filter = "Image files (*.jpg)|*.jpg";
                    openFileDialog.FilterIndex = 2;
                    openFileDialog.RestoreDirectory = true;

                    if (openFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        try
                        {
                         File.Copy(openFileDialog.FileName, $"Image\\temp.jpg", true);
                            FileStream fs = new System.IO.FileStream($"Image\\temp.jpg", FileMode.Open, FileAccess.Read);
                            editpictures.BackgroundImage = Image.FromStream(fs);
                            fs.Close();
                        }
                        catch { }
                    }

                }

        }

        private void search_Leave(object sender, EventArgs e)
        {
            if (search.Text == "")
            {
                search.Text = searchtext;
                search.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            }
        }

        private void picturebox_Click(object sender, EventArgs e)
        {
            if (File.Exists($"Image\\{title.Text}.jpg"))
            {
                new FullPic().Show(title.Text);
            }
            else
            {
                MessageBox.Show("Відсутнє зображення.");
            }
        }

        private void editb_Click(object sender, EventArgs e)
        {
            if(editb.Text == textedit)
            {
                tabControl1.SelectedTab = edit;
                list.Enabled = false;
                addb.Text = textdel;
                editb.Text = textsave;
                edittext.Text = title.Text;
                editContent.Text = Contenctext.Text;
                editpictures.BackgroundImage = picturebox.BackgroundImage;
                if (File.Exists($"Image\\temp.jpg")) File.Delete($"Image\\temp.jpg");
                if (File.Exists($"Image\\{title.Text}.jpg")) File.Move($"Image\\{title.Text}.jpg", $"Image\\temp.jpg");
            }
            else
            {
                savemode();
                list_SelectedIndexChanged(sender, e);
            }
        }
        private void addb_Click(object sender, EventArgs e)
        {
            if (addb.Text == textdel)
            {
                sqlcmd($"DELETE FROM [Table] WHERE [Title] = '{title.Text}'");
                if (File.Exists($"Image\\{title.Text}.jpg")) File.Delete($"Image\\{title.Text}.jpg");
                if (File.Exists($"Image\\temp.jpg")) File.Delete($"Image\\temp.jpg");
                updatetree("");
                try
                {
                list.SelectedIndex = list.TopIndex;
                }
                catch { }
                if (list.TopIndex == 0) title.Text = "Словник"; Contenctext.Text = ""; picturebox.BackgroundImage = null;

            } else if(addb.Text == textcancel)
            {
                list_SelectedIndexChanged(sender, e);
                if (title.Text == "") title.Text = "Словник"; editb.Enabled = false;
                updatetree("");
            } else if (addb.Text == textadd)
            {
                tabControl1.SelectedTab = edit;
                editb.Enabled = true;
                list.Enabled = false;
                addb.Text = textcancel;
                editb.Text = textsave;
                edittext.Text = "Заголовок";
                title.Text = "";
                editContent.Text = "Вміст";
                Contenctext.Text = "";
                editpictures.BackgroundImage = global::Dictionary_WF_.Properties.Resources.none;
                return;
            }
            tabControl1.SelectedTab = view;
            list.Enabled = true;
            editb.Text = textedit;
            addb.Text = textadd;
        }

        private void list_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            try
            {
                title.Text = list.SelectedItem.ToString();
                editb.Enabled = true;
                try
                    {
                    FileStream fs = new System.IO.FileStream($"Image\\{title.Text}.jpg", FileMode.Open, FileAccess.Read);
                        picturebox.BackgroundImage = Image.FromStream(fs);
                    fs.Close();
                    ////picturebox.BackgroundImage = Image.FromFile($"Image\\{title.Text}.jpg");
                    }
                    catch
                    {
                        picturebox.BackgroundImage = global::Dictionary_WF_.Properties.Resources.none;
                }
                Contenctext.Text = sqlCont($"SELECT * FROM [Table] WHERE Title = '{list.SelectedItem.ToString().Replace("'", "''")}'");
            }
            catch { }
            
        }

        private void search_MouseDown(object sender, MouseEventArgs e)
        {
            if(search.Text == searchtext)search.Text = "";
            search.ForeColor = Color.Black;
        }
        private void savemode()
        {
            string editConText = editContent.Text.Replace("'","''");
            string edittextmain = edittext.Text.Replace("'", "''");
            ///editConText = "Вміст ''";
            if (title.Text != edittext.Text && !sqllist("SELECT [Title] FROM [Table]").Contains(edittext.Text))
            {
                int id = list.SelectedIndex;
                if (addb.Text == textcancel) sqlcmd($"INSERT INTO [Table] ( [Title], [Content]) VALUES ('{edittextmain}', '" + editConText + "');");
                else sqlcmd($"UPDATE [Table] SET [Title] = '{edittextmain}' WHERE [Title]= '{title.Text.Replace("'", "''")}'");

                updatetree("");
                list.SelectedIndex = list.Items.IndexOf(edittext.Text);
            }
            else if (title.Text != edittext.Text && sqllist("SELECT [Title] FROM [Table]").Contains(edittext.Text))
            {
                MessageBox.Show("Такий заголовок вже існує");
                return;
            }
            if (editConText != Contenctext.Text && addb.Text != textcancel) sqlcmd($"UPDATE [Table] SET [Content] = '{editConText}' WHERE [Title]='{title.Text.Replace("'", "''")}'");
            try
            {
                if (File.Exists($"Image\\{edittext.Text}.jpg")) File.Delete($"Image\\{edittext.Text}.jpg");
                File.Move($"Image\\temp.jpg", $"Image\\{edittext.Text}.jpg");
            }
            catch { }
            tabControl1.SelectedTab = view;
            list.Enabled = true;
            addb.Text = textadd;
            editb.Text = textedit;
        }
    }
}
