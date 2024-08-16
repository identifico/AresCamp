namespace AresCampsWinForms.Forms
{
    partial class AddPersonsForm
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
            this.TrainerBox = new System.Windows.Forms.ListBox();
            this.SavePerson = new System.Windows.Forms.Button();
            this.NamePerson = new System.Windows.Forms.TextBox();
            this.NameTrainer = new System.Windows.Forms.TextBox();
            this.HowMuchDay = new System.Windows.Forms.TextBox();
            this.DeleteTrainer = new System.Windows.Forms.Button();
            this.PersonsBox = new System.Windows.Forms.ListBox();
            this.ChangePersons = new System.Windows.Forms.Button();
            this.ChangePerson = new System.Windows.Forms.Button();
            this.ChangeNamePerson = new System.Windows.Forms.TextBox();
            this.ChangeSumPerson = new System.Windows.Forms.TextBox();
            this.ChangeDaysPerson = new System.Windows.Forms.TextBox();
            this.GoToSettings = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TrainerBox
            // 
            this.TrainerBox.FormattingEnabled = true;
            this.TrainerBox.Location = new System.Drawing.Point(1, 3);
            this.TrainerBox.Name = "TrainerBox";
            this.TrainerBox.Size = new System.Drawing.Size(376, 160);
            this.TrainerBox.TabIndex = 7;
            this.TrainerBox.SelectedIndexChanged += new System.EventHandler(this.TrainerBox_SelectedIndexChanged);
            // 
            // SavePerson
            // 
            this.SavePerson.Location = new System.Drawing.Point(12, 195);
            this.SavePerson.Name = "SavePerson";
            this.SavePerson.Size = new System.Drawing.Size(75, 23);
            this.SavePerson.TabIndex = 3;
            this.SavePerson.Text = "Сохранить";
            this.SavePerson.UseVisualStyleBackColor = true;
            this.SavePerson.Click += new System.EventHandler(this.SavePerson_Click);
            // 
            // NamePerson
            // 
            this.NamePerson.Location = new System.Drawing.Point(107, 169);
            this.NamePerson.Name = "NamePerson";
            this.NamePerson.Size = new System.Drawing.Size(100, 20);
            this.NamePerson.TabIndex = 1;
            this.NamePerson.Text = "Имя спортсмена...";
            this.NamePerson.Enter += new System.EventHandler(this.NamePerson_Enter);
            // 
            // NameTrainer
            // 
            this.NameTrainer.Location = new System.Drawing.Point(1, 169);
            this.NameTrainer.Name = "NameTrainer";
            this.NameTrainer.Size = new System.Drawing.Size(100, 20);
            this.NameTrainer.TabIndex = 0;
            this.NameTrainer.Text = "Имя тренера...";
            this.NameTrainer.Enter += new System.EventHandler(this.NameTrainer_Enter);
            // 
            // HowMuchDay
            // 
            this.HowMuchDay.Location = new System.Drawing.Point(213, 169);
            this.HowMuchDay.Name = "HowMuchDay";
            this.HowMuchDay.Size = new System.Drawing.Size(100, 20);
            this.HowMuchDay.TabIndex = 2;
            this.HowMuchDay.Text = "Кол-во дней...";
            this.HowMuchDay.Enter += new System.EventHandler(this.HowMuchDay_Enter);
            // 
            // DeleteTrainer
            // 
            this.DeleteTrainer.Location = new System.Drawing.Point(118, 195);
            this.DeleteTrainer.Name = "DeleteTrainer";
            this.DeleteTrainer.Size = new System.Drawing.Size(75, 23);
            this.DeleteTrainer.TabIndex = 4;
            this.DeleteTrainer.Text = "Удалить";
            this.DeleteTrainer.UseVisualStyleBackColor = true;
            this.DeleteTrainer.Click += new System.EventHandler(this.DeleteTrainer_Click);
            // 
            // PersonsBox
            // 
            this.PersonsBox.FormattingEnabled = true;
            this.PersonsBox.Location = new System.Drawing.Point(383, 3);
            this.PersonsBox.Name = "PersonsBox";
            this.PersonsBox.Size = new System.Drawing.Size(487, 160);
            this.PersonsBox.TabIndex = 8;
            this.PersonsBox.SelectedIndexChanged += new System.EventHandler(this.PersonsBox_SelectedIndexChanged);
            // 
            // ChangePersons
            // 
            this.ChangePersons.Location = new System.Drawing.Point(220, 195);
            this.ChangePersons.Name = "ChangePersons";
            this.ChangePersons.Size = new System.Drawing.Size(83, 23);
            this.ChangePersons.TabIndex = 5;
            this.ChangePersons.Text = "Изменение спортсменов";
            this.ChangePersons.UseVisualStyleBackColor = true;
            this.ChangePersons.Click += new System.EventHandler(this.ChangePersons_Click);
            // 
            // ChangePerson
            // 
            this.ChangePerson.Location = new System.Drawing.Point(676, 195);
            this.ChangePerson.Name = "ChangePerson";
            this.ChangePerson.Size = new System.Drawing.Size(75, 23);
            this.ChangePerson.TabIndex = 9;
            this.ChangePerson.Text = "Сохранить";
            this.ChangePerson.UseVisualStyleBackColor = true;
            this.ChangePerson.Click += new System.EventHandler(this.ChangePerson_Click);
            // 
            // ChangeNamePerson
            // 
            this.ChangeNamePerson.Location = new System.Drawing.Point(558, 169);
            this.ChangeNamePerson.Name = "ChangeNamePerson";
            this.ChangeNamePerson.Size = new System.Drawing.Size(100, 20);
            this.ChangeNamePerson.TabIndex = 10;
            this.ChangeNamePerson.Text = "Новое Имя...";
            this.ChangeNamePerson.Enter += new System.EventHandler(this.ChangeNamePerson_Enter);
            // 
            // ChangeSumPerson
            // 
            this.ChangeSumPerson.Location = new System.Drawing.Point(770, 169);
            this.ChangeSumPerson.Name = "ChangeSumPerson";
            this.ChangeSumPerson.Size = new System.Drawing.Size(100, 20);
            this.ChangeSumPerson.TabIndex = 11;
            this.ChangeSumPerson.Text = "Новая сумма...";
            this.ChangeSumPerson.Enter += new System.EventHandler(this.ChangeSumPerson_Enter);
            // 
            // ChangeDaysPerson
            // 
            this.ChangeDaysPerson.Location = new System.Drawing.Point(664, 169);
            this.ChangeDaysPerson.Name = "ChangeDaysPerson";
            this.ChangeDaysPerson.Size = new System.Drawing.Size(100, 20);
            this.ChangeDaysPerson.TabIndex = 12;
            this.ChangeDaysPerson.Text = "Кол-во дней...";
            this.ChangeDaysPerson.Enter += new System.EventHandler(this.ChangeDaysPerson_Enter);
            // 
            // GoToSettings
            // 
            this.GoToSettings.Location = new System.Drawing.Point(358, 166);
            this.GoToSettings.Name = "GoToSettings";
            this.GoToSettings.Size = new System.Drawing.Size(75, 23);
            this.GoToSettings.TabIndex = 13;
            this.GoToSettings.Text = "Настройки";
            this.GoToSettings.UseVisualStyleBackColor = true;
            this.GoToSettings.Click += new System.EventHandler(this.GoToSettings_Click);
            // 
            // AddPersonsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 450);
            this.Controls.Add(this.GoToSettings);
            this.Controls.Add(this.ChangeDaysPerson);
            this.Controls.Add(this.ChangeSumPerson);
            this.Controls.Add(this.ChangeNamePerson);
            this.Controls.Add(this.ChangePerson);
            this.Controls.Add(this.ChangePersons);
            this.Controls.Add(this.PersonsBox);
            this.Controls.Add(this.DeleteTrainer);
            this.Controls.Add(this.HowMuchDay);
            this.Controls.Add(this.NameTrainer);
            this.Controls.Add(this.NamePerson);
            this.Controls.Add(this.SavePerson);
            this.Controls.Add(this.TrainerBox);
            this.Name = "AddPersonsForm";
            this.Text = "AddPersonsForm";
            this.Load += new System.EventHandler(this.AddPersonsForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox TrainerBox;
        private System.Windows.Forms.Button SavePerson;
        private System.Windows.Forms.TextBox NamePerson;
        private System.Windows.Forms.TextBox NameTrainer;
        private System.Windows.Forms.TextBox HowMuchDay;
        private System.Windows.Forms.Button DeleteTrainer;
        private System.Windows.Forms.ListBox PersonsBox;
        private System.Windows.Forms.Button ChangePersons;
        private System.Windows.Forms.Button ChangePerson;
        private System.Windows.Forms.TextBox ChangeNamePerson;
        private System.Windows.Forms.TextBox ChangeSumPerson;
        private System.Windows.Forms.TextBox ChangeDaysPerson;
        private System.Windows.Forms.Button GoToSettings;
    }
}