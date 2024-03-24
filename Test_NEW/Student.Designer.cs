namespace EducationForm
{
    partial class Student
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
            this.button_answer = new System.Windows.Forms.Button();
            this.txt_question = new System.Windows.Forms.TextBox();
            this.txt_answer = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button_answer
            // 
            this.button_answer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_answer.Location = new System.Drawing.Point(35, 247);
            this.button_answer.Name = "button_answer";
            this.button_answer.Size = new System.Drawing.Size(162, 47);
            this.button_answer.TabIndex = 0;
            this.button_answer.Text = "Ответить";
            this.button_answer.UseVisualStyleBackColor = true;
            // 
            // txt_question
            // 
            this.txt_question.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txt_question.Location = new System.Drawing.Point(35, 56);
            this.txt_question.Multiline = true;
            this.txt_question.Name = "txt_question";
            this.txt_question.ReadOnly = true;
            this.txt_question.Size = new System.Drawing.Size(622, 103);
            this.txt_question.TabIndex = 1;
            this.txt_question.Text = "В современных СУБД обычно поддерживается один из двух широко распространенных мет" +
    "одов организации защиты данных: избирательный или";
            // 
            // txt_answer
            // 
            this.txt_answer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txt_answer.Location = new System.Drawing.Point(35, 196);
            this.txt_answer.Name = "txt_answer";
            this.txt_answer.Size = new System.Drawing.Size(430, 30);
            this.txt_answer.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(30, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(274, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Продолжите предложение:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(30, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Ответ:";
            // 
            // Student
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 327);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_answer);
            this.Controls.Add(this.txt_question);
            this.Controls.Add(this.button_answer);
            this.Name = "Student";
            this.Text = "Интерактивное пособие";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_answer;
        private System.Windows.Forms.TextBox txt_answer;
        private System.Windows.Forms.TextBox txt_question;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}