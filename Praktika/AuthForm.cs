using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Praktika
{
    public partial class AuthForm : Form
    {
        MainForm Main;
        bool capchaConfimed;
        bool CapchaIsActive;
        int capchaText = 0;
        int AttemptsCount = 0;

        Color checkButtonColor;
        string checkButtonText = "Проверить";
        public AuthForm(MainForm main)
        {
            InitializeComponent();
            //this.FormClosing += (s, e) => { Environment.Exit(0); };
            Main = main;
            ErrorLabel.Text = String.Empty;
            capchaConfimed = false;
            CapchaIsActive = false;
            CapchaTextBox.Visible = false;
            checkButtonColor = CapchaTextCheckButton.BackColor;
            CapchaTextCheckButton.BackColor = Color.Gray;
            CapchaTextCheckButton.Text = String.Empty;
        }
        private void label5_Click(object sender, EventArgs e)
        {
            Main.OpenRegisterForm();
            this.Close();
        }

        private void label5_MouseEnter(object sender, EventArgs e)
        {
            label5.Font = new Font(label1.Font, FontStyle.Underline);
        }

        private void label5_MouseLeave(object sender, EventArgs e)
        {
            label5.Font = new Font(label1.Font, FontStyle.Regular);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(AttemptsCount < 3)
            {
                if ((LoginTextBox.Text != null || LoginTextBox.Text != null) && (PassTextBox.Text != null || PassTextBox.Text != null))
                {
                    if (capchaConfimed)
                    {
                        string userLogin = LoginTextBox.Text;
                        string userPass = PassTextBox.Text;
                        DataBaseHandler db = Main.DBHandler;
                        MySqlDataAdapter adapter = new MySqlDataAdapter();
                        DataTable table = new DataTable();
                        MySqlCommand cmd = new MySqlCommand("SELECT * FROM `client` WHERE `ULogin` = @UL AND `UPass` = @UP", db.GetConnection());
                        cmd.Parameters.Add("@UL", MySqlDbType.VarChar).Value = userLogin;
                        cmd.Parameters.Add("@UP", MySqlDbType.VarChar).Value = userPass;
                        adapter.SelectCommand = cmd;
                        adapter.Fill(table);
                        if (table.Rows.Count > 0)
                        {
                            Main.GetClientData(table);
                            this.Close();
                        }
                        else
                        {
                            ErrorLabel.Text = "Неправильный пароль/логин";
                            AttemptsCount++;
                        }
                    }
                    else if (!capchaConfimed && CapchaIsActive)
                    {
                        ErrorLabel.Text = "Пройдите капчу";
                    }
                    else
                    {
                        SetActiveCapcha();
                    }
                }
                else ErrorLabel.Text = "Некорректные данные";
            }
            else
            {
                ErrorLabel.Text = "Доступ заблокирован";
            }
            
        }
        private void SetActiveCapcha(bool NeedShowComponents = true)
        {
            Random r1 = new Random(); capchaText = r1.Next(10000, 99999);
            var image = new Bitmap(this.Capcha.Width, this.Capcha.Height);
            var font = new Font("Georgia", 45, FontStyle.Bold, GraphicsUnit.Pixel);
            var graphics = Graphics.FromImage(image); 
            graphics.SmoothingMode = SmoothingMode.AntiAlias;
            Rectangle rect = new Rectangle(0, 0, this.Capcha.Width, this.Capcha.Height);
            HatchBrush hatchBrush = new HatchBrush(HatchStyle.SmallConfetti, Color.White, Color.LightBlue);
            graphics.FillRectangle(hatchBrush, rect); 
            graphics.DrawString(capchaText.ToString(), font, Brushes.Black, new Point(0, 0));
            Capcha.Image = image;
            if (NeedShowComponents)
            {
                CapchaTextBox.Visible = true;
                CapchaTextCheckButton.BackColor = checkButtonColor;
                CapchaTextCheckButton.Text = checkButtonText;
            }
            CapchaIsActive = true;
        }

        private void CapchaTextCheckButton_Click(object sender, EventArgs e)
        {
            if (CapchaIsActive)
            {
                if (int.TryParse(CapchaTextBox.Text, out int value))
                {
                    if (value == capchaText)
                    {
                        capchaConfimed = true;
                        CapchaIsActive = false;
                        CapchaTextBox.Visible = false;
                        CapchaTextCheckButton.BackColor = Color.Gray;
                        CapchaTextCheckButton.Text = String.Empty;
                    }
                    else
                    {
                        SetActiveCapcha(false);
                        CapchaTextBox.Text = String.Empty;  
                    }
                }
                else 
                {
                    SetActiveCapcha(false);
                    CapchaTextBox.Text = String.Empty;
                }
            }         
        }
    }
}
