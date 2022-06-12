using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

public delegate void DataHandle(DataTable table);

namespace Praktika
{
    public partial class MainForm : Form
    {
        private Dictionary<string, TabPage> Pages;
        private bool UseTestFunc = true;
        private bool UseDB = true;

        private AuthForm authForm;
        private RegisterForm registerForm;

        DataBaseHandler dbHandler;
        internal DataBaseHandler DBHandler { get { return dbHandler; } }
        public MainForm()
        {            
            InitializeComponent();
            
            Pages = GetPages();
            tabControl1.TabPages.Clear();
            if (UseDB)
            {
                dbHandler = new DataBaseHandler();
                if (dbHandler.Connect())
                {
                    authForm = new AuthForm(this);
                    this.Hide();
                    authForm.ShowDialog();
                }
            }
            else
            {

            }
        }
        private Dictionary<string, TabPage> GetPages()
        {
            Dictionary<string, TabPage> pages = new Dictionary<string, TabPage>();
            foreach (var page in tabControl1.TabPages)
            {
                TabPage tabPage = page as TabPage;
                pages.Add(tabPage.Name, (TabPage)page);
            }
            if (UseTestFunc) toolStripTextBox1.Text = pages.Count.ToString();
            return pages;
        }
        internal void OpenAuthForm()
        {
            authForm = new AuthForm(this);
            authForm.Show();
        }
        internal void OpenRegisterForm()
        {
            registerForm = new RegisterForm();
            registerForm.Show();    
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            //GetPages();
            //DBHandler = new DataBaseHandler();
            //if (DBHandler.Connect())
            //{
            //    OpenAuthForm();   
            //}
        }
        public void GetClientData(DataTable table)
        {
            foreach(DataColumn column in table.Columns)
            {
                if(column.ColumnName == "UserType")
                {
                    var cells = table.Rows[0].ItemArray;
                    if (cells[8] is int)
                    {
                        int index = (int)cells[8];
                        if(UseTestFunc)
                        MessageBox.Show(index == 1? "Админ":"Пользователь");
                        string[] pageName;
                        if (index == 1)
                        {
                            foreach (var item in Pages)
                            {
                                pageName = item.Key.Split('_');
                                if(pageName[0] == "Admin" || pageName[0] == "General")
                                {
                                    tabControl1.TabPages.Add(item.Value);
                                }
                            }
                        }
                        else
                        {
                            foreach (var item in Pages)
                            {
                                pageName = item.Key.Split('_');
                                if (pageName[0] == "Client" || pageName[0] == "General")
                                {
                                    tabControl1.TabPages.Add(item.Value);
                                }
                            }
                        }
                    }
                    else MessageBox.Show("Это не тип");
                }
            }
            SetWellcomePage();
        }
        private void SetWellcomePage()
        {
            DateTime Current = DateTime.Now;
            string welcomeString = String.Empty;
            string userName = User.Instance != null ? User.Instance.Name : "Пользователь";
            if (Current.Hour >= 23 && Current.Hour < 4)
            {
                welcomeString = "Доброй ночи";
            }
            else if(Current.Hour >= 4 && Current.Hour < 12)
            {
                welcomeString = "Доброе утро";
            }
            else if (Current.Hour >= 12 && Current.Hour < 17)
            {
                welcomeString = "Добрый день";
            }
            else if (Current.Hour >= 17 && Current.Hour < 23)
            {
                welcomeString = "Добрый вечер";
            }
            WellcomeLabel.Text = $"{welcomeString}, {userName}";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int index = tabControl1.TabPages.IndexOfKey("General_WellcomePage");
            tabControl1.SelectedTab = tabControl1.TabPages[index + 1];
            tabControl1.TabPages.RemoveAt(index);
        }

        private void tabControl1_Selecting(object sender, TabControlCancelEventArgs e)
        {
            if (tabControl1.TabPages.Contains(Pages["General_WellcomePage"]))
            {
                int index = tabControl1.TabPages.IndexOfKey("General_WellcomePage");
                tabControl1.TabPages.RemoveAt(index);
            }
        }
    }
}
