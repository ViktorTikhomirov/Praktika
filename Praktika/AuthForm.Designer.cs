namespace Praktika
{
    partial class AuthForm
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
            this.LoginTextBox = new System.Windows.Forms.TextBox();
            this.PassTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.ErrorLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Capcha = new System.Windows.Forms.PictureBox();
            this.CapchaTextCheckButton = new System.Windows.Forms.Button();
            this.CapchaTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.Capcha)).BeginInit();
            this.SuspendLayout();
            // 
            // LoginTextBox
            // 
            this.LoginTextBox.Location = new System.Drawing.Point(19, 103);
            this.LoginTextBox.Margin = new System.Windows.Forms.Padding(6);
            this.LoginTextBox.Multiline = true;
            this.LoginTextBox.Name = "LoginTextBox";
            this.LoginTextBox.Size = new System.Drawing.Size(308, 34);
            this.LoginTextBox.TabIndex = 0;
            // 
            // PassTextBox
            // 
            this.PassTextBox.Location = new System.Drawing.Point(19, 182);
            this.PassTextBox.Margin = new System.Windows.Forms.Padding(6);
            this.PassTextBox.Multiline = true;
            this.PassTextBox.Name = "PassTextBox";
            this.PassTextBox.Size = new System.Drawing.Size(258, 34);
            this.PassTextBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 152);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Пароль";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 73);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "Логин";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(286, 182);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(41, 34);
            this.button1.TabIndex = 4;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.LightGreen;
            this.button2.Location = new System.Drawing.Point(19, 329);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(308, 39);
            this.button2.TabIndex = 5;
            this.button2.Text = "Войти";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(75, 9);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(178, 31);
            this.label3.TabIndex = 6;
            this.label3.Text = "Авторизация";
            // 
            // ErrorLabel
            // 
            this.ErrorLabel.AutoSize = true;
            this.ErrorLabel.ForeColor = System.Drawing.Color.DarkRed;
            this.ErrorLabel.Location = new System.Drawing.Point(15, 49);
            this.ErrorLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.ErrorLabel.Name = "ErrorLabel";
            this.ErrorLabel.Size = new System.Drawing.Size(80, 24);
            this.ErrorLabel.TabIndex = 7;
            this.ErrorLabel.Text = "Ошибка";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(6, 371);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(333, 24);
            this.label5.TabIndex = 8;
            this.label5.Text = "Нет аккаунта? Зарегистрироваться";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            this.label5.MouseEnter += new System.EventHandler(this.label5_MouseEnter);
            this.label5.MouseLeave += new System.EventHandler(this.label5_MouseLeave);
            // 
            // Capcha
            // 
            this.Capcha.Location = new System.Drawing.Point(19, 225);
            this.Capcha.Name = "Capcha";
            this.Capcha.Size = new System.Drawing.Size(308, 53);
            this.Capcha.TabIndex = 10;
            this.Capcha.TabStop = false;
            // 
            // CapchaTextCheckButton
            // 
            this.CapchaTextCheckButton.BackColor = System.Drawing.Color.LightSeaGreen;
            this.CapchaTextCheckButton.Location = new System.Drawing.Point(207, 284);
            this.CapchaTextCheckButton.Name = "CapchaTextCheckButton";
            this.CapchaTextCheckButton.Size = new System.Drawing.Size(120, 39);
            this.CapchaTextCheckButton.TabIndex = 11;
            this.CapchaTextCheckButton.Text = "Проверить";
            this.CapchaTextCheckButton.UseVisualStyleBackColor = false;
            this.CapchaTextCheckButton.Click += new System.EventHandler(this.CapchaTextCheckButton_Click);
            // 
            // CapchaTextBox
            // 
            this.CapchaTextBox.Location = new System.Drawing.Point(19, 288);
            this.CapchaTextBox.Name = "CapchaTextBox";
            this.CapchaTextBox.Size = new System.Drawing.Size(182, 29);
            this.CapchaTextBox.TabIndex = 12;
            // 
            // AuthForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(342, 406);
            this.Controls.Add(this.CapchaTextBox);
            this.Controls.Add(this.CapchaTextCheckButton);
            this.Controls.Add(this.Capcha);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ErrorLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PassTextBox);
            this.Controls.Add(this.LoginTextBox);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "AuthForm";
            this.Text = "AuthForm";
            ((System.ComponentModel.ISupportInitialize)(this.Capcha)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox LoginTextBox;
        private System.Windows.Forms.TextBox PassTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label ErrorLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox Capcha;
        private System.Windows.Forms.Button CapchaTextCheckButton;
        private System.Windows.Forms.TextBox CapchaTextBox;
    }
}