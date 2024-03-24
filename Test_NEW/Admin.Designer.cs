namespace Test_NEW
{
    partial class Admin
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.tab_control = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_version = new System.Windows.Forms.TextBox();
            this.Insert = new System.Windows.Forms.Button();
            this.txt_prompt = new System.Windows.Forms.TextBox();
            this.txt_answer = new System.Windows.Forms.TextBox();
            this.txt_question = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.list_view = new System.Windows.Forms.ListView();
            this.column_question = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.column_answer = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.column_prompt = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.column_version = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.column_id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.box_filter = new System.Windows.Forms.ComboBox();
            this.user = new System.Windows.Forms.TabPage();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.password = new System.Windows.Forms.Label();
            this.login = new System.Windows.Forms.Label();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.insert_user = new System.Windows.Forms.Button();
            this.txt_role = new System.Windows.Forms.TextBox();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.txt_login = new System.Windows.Forms.TextBox();
            this.tab_control.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.user.SuspendLayout();
            this.SuspendLayout();
            // 
            // tab_control
            // 
            this.tab_control.Controls.Add(this.tabPage1);
            this.tab_control.Controls.Add(this.tabPage2);
            this.tab_control.Controls.Add(this.user);
            this.tab_control.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tab_control.Location = new System.Drawing.Point(0, 0);
            this.tab_control.Name = "tab_control";
            this.tab_control.SelectedIndex = 0;
            this.tab_control.Size = new System.Drawing.Size(800, 462);
            this.tab_control.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.txt_version);
            this.tabPage1.Controls.Add(this.Insert);
            this.tabPage1.Controls.Add(this.txt_prompt);
            this.tabPage1.Controls.Add(this.txt_answer);
            this.tabPage1.Controls.Add(this.txt_question);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(792, 433);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Добавить вопрос";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(24, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(627, 29);
            this.label5.TabIndex = 10;
            this.label5.Text = "Введите обязательные поля для добавления вопроса:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(24, 213);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 25);
            this.label4.TabIndex = 9;
            this.label4.Text = "Вариант";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(24, 171);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 25);
            this.label3.TabIndex = 8;
            this.label3.Text = "Подсказка";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(24, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 25);
            this.label2.TabIndex = 7;
            this.label2.Text = "Ответ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(24, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "Вопрос";
            // 
            // txt_version
            // 
            this.txt_version.Location = new System.Drawing.Point(163, 213);
            this.txt_version.Name = "txt_version";
            this.txt_version.Size = new System.Drawing.Size(596, 22);
            this.txt_version.TabIndex = 5;
            // 
            // Insert
            // 
            this.Insert.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Insert.Location = new System.Drawing.Point(29, 288);
            this.Insert.Name = "Insert";
            this.Insert.Size = new System.Drawing.Size(117, 41);
            this.Insert.TabIndex = 4;
            this.Insert.Text = "Добавить";
            this.Insert.UseVisualStyleBackColor = true;
            this.Insert.Click += new System.EventHandler(this.Insert_Click);
            // 
            // txt_prompt
            // 
            this.txt_prompt.Location = new System.Drawing.Point(163, 171);
            this.txt_prompt.Name = "txt_prompt";
            this.txt_prompt.Size = new System.Drawing.Size(596, 22);
            this.txt_prompt.TabIndex = 2;
            // 
            // txt_answer
            // 
            this.txt_answer.Location = new System.Drawing.Point(163, 131);
            this.txt_answer.Name = "txt_answer";
            this.txt_answer.Size = new System.Drawing.Size(596, 22);
            this.txt_answer.TabIndex = 1;
            // 
            // txt_question
            // 
            this.txt_question.Location = new System.Drawing.Point(163, 89);
            this.txt_question.Name = "txt_question";
            this.txt_question.Size = new System.Drawing.Size(596, 22);
            this.txt_question.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.tableLayoutPanel1);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(792, 433);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Посмотреть вопросы";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.list_view, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.box_filter, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(786, 427);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // list_view
            // 
            this.list_view.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.column_question,
            this.column_answer,
            this.column_prompt,
            this.column_version,
            this.column_id});
            this.list_view.Dock = System.Windows.Forms.DockStyle.Fill;
            this.list_view.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.list_view.GridLines = true;
            this.list_view.HideSelection = false;
            this.list_view.Location = new System.Drawing.Point(3, 3);
            this.list_view.Name = "list_view";
            this.list_view.Size = new System.Drawing.Size(780, 335);
            this.list_view.TabIndex = 1;
            this.list_view.UseCompatibleStateImageBehavior = false;
            this.list_view.View = System.Windows.Forms.View.Details;
            // 
            // column_question
            // 
            this.column_question.Text = "Вопрос";
            this.column_question.Width = 95;
            // 
            // column_answer
            // 
            this.column_answer.Text = "Ответ";
            this.column_answer.Width = 132;
            // 
            // column_prompt
            // 
            this.column_prompt.Text = "Подсказка";
            this.column_prompt.Width = 130;
            // 
            // column_version
            // 
            this.column_version.Text = "Вариант";
            this.column_version.Width = 123;
            // 
            // column_id
            // 
            this.column_id.Text = "ID";
            // 
            // box_filter
            // 
            this.box_filter.Dock = System.Windows.Forms.DockStyle.Left;
            this.box_filter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.box_filter.FormattingEnabled = true;
            this.box_filter.Items.AddRange(new object[] {
            "Вариант 1",
            "Вариант 2",
            "Все варианты"});
            this.box_filter.Location = new System.Drawing.Point(3, 344);
            this.box_filter.Name = "box_filter";
            this.box_filter.Size = new System.Drawing.Size(274, 33);
            this.box_filter.TabIndex = 3;
            this.box_filter.SelectedIndexChanged += new System.EventHandler(this.box_filter_SelectedIndexChanged);
            // 
            // user
            // 
            this.user.Controls.Add(this.label6);
            this.user.Controls.Add(this.label7);
            this.user.Controls.Add(this.label8);
            this.user.Controls.Add(this.password);
            this.user.Controls.Add(this.login);
            this.user.Controls.Add(this.txt_name);
            this.user.Controls.Add(this.insert_user);
            this.user.Controls.Add(this.txt_role);
            this.user.Controls.Add(this.txt_password);
            this.user.Controls.Add(this.txt_login);
            this.user.Location = new System.Drawing.Point(4, 25);
            this.user.Name = "user";
            this.user.Size = new System.Drawing.Size(792, 433);
            this.user.TabIndex = 2;
            this.user.Text = "Добавить пользователя";
            this.user.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(23, 31);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(690, 29);
            this.label6.TabIndex = 20;
            this.label6.Text = "Введите обязательные поля для добавления пользователя:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(23, 211);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 25);
            this.label7.TabIndex = 19;
            this.label7.Text = "Имя";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(23, 169);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 25);
            this.label8.TabIndex = 18;
            this.label8.Text = "Роль";
            // 
            // password
            // 
            this.password.AutoSize = true;
            this.password.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.password.Location = new System.Drawing.Point(23, 129);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(80, 25);
            this.password.TabIndex = 17;
            this.password.Text = "Пароль";
            // 
            // login
            // 
            this.login.AutoSize = true;
            this.login.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.login.Location = new System.Drawing.Point(23, 87);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(68, 25);
            this.login.TabIndex = 16;
            this.login.Text = "Логин";
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(162, 211);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(596, 22);
            this.txt_name.TabIndex = 15;
            // 
            // insert_user
            // 
            this.insert_user.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.insert_user.Location = new System.Drawing.Point(28, 286);
            this.insert_user.Name = "insert_user";
            this.insert_user.Size = new System.Drawing.Size(117, 41);
            this.insert_user.TabIndex = 14;
            this.insert_user.Text = "Добавить";
            this.insert_user.UseVisualStyleBackColor = true;
            // 
            // txt_role
            // 
            this.txt_role.Location = new System.Drawing.Point(162, 169);
            this.txt_role.Name = "txt_role";
            this.txt_role.Size = new System.Drawing.Size(596, 22);
            this.txt_role.TabIndex = 13;
            // 
            // txt_password
            // 
            this.txt_password.Location = new System.Drawing.Point(162, 129);
            this.txt_password.Name = "txt_password";
            this.txt_password.Size = new System.Drawing.Size(596, 22);
            this.txt_password.TabIndex = 12;
            // 
            // txt_login
            // 
            this.txt_login.Location = new System.Drawing.Point(162, 87);
            this.txt_login.Name = "txt_login";
            this.txt_login.Size = new System.Drawing.Size(596, 22);
            this.txt_login.TabIndex = 11;
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 462);
            this.Controls.Add(this.tab_control);
            this.Name = "Admin";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tab_control.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.user.ResumeLayout(false);
            this.user.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tab_control;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button Insert;
        private System.Windows.Forms.TextBox txt_prompt;
        private System.Windows.Forms.TextBox txt_answer;
        private System.Windows.Forms.TextBox txt_question;
        private System.Windows.Forms.TextBox txt_version;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ListView list_view;
        private System.Windows.Forms.ColumnHeader column_question;
        private System.Windows.Forms.ColumnHeader column_answer;
        private System.Windows.Forms.ColumnHeader column_prompt;
        private System.Windows.Forms.ColumnHeader column_version;
        private System.Windows.Forms.ComboBox box_filter;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ColumnHeader column_id;
        private System.Windows.Forms.TabPage user;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label password;
        private System.Windows.Forms.Label login;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.Button insert_user;
        private System.Windows.Forms.TextBox txt_role;
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.TextBox txt_login;
    }
}

