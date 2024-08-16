using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using AresCampsWinForms.src;

namespace AresCampsWinForms.Forms
{
    public partial class AddPersonsForm : Form
    {
        int trainerIndex = 0;
        int PersonIndex = 0;
        public AddPersonsForm()
        {
            InitializeComponent();
        }


        private void AddPersonsForm_Load(object sender, EventArgs e)
        {
            TrainerBox.ScrollAlwaysVisible = true;
            PersonsBox.ScrollAlwaysVisible = true;
            Upt();
        }

        private void SavePerson_Click(object sender, EventArgs e)
        {
            if(double.TryParse(HowMuchDay.Text, out double resultMuchDays))
            {
                if (NameTrainer.Text != "" && NamePerson.Text != "" && HowMuchDay.Text != "")
                {
                    if (resultMuchDays > Program.admin.Days) MessageBox.Show($"Максимальное количество дней на сборах: {Program.admin.Days}");
                    else
                    {
                        Program.admin.AddPerson(NameTrainer.Text, NamePerson.Text, resultMuchDays);
                        Upt();
                    }
                }

                else if (NameTrainer.Text == "") MessageBox.Show("Вы не указали имя тренера");
                else if (NamePerson.Text == "") MessageBox.Show("Вы не указали имя Спортсмена");
                else if (HowMuchDay.Text == "") MessageBox.Show("Вы не указали Количество дней");
            }

            else
            {
                string error = "Не правильный формат дней.";
                MessageBox.Show(error);
                Upt();
            }
        }

        private void Upt()
        {
            string[] names = GetNamesTrainers(Program.admin.Trainers);
            ChangeNamePerson.Text = "Новое Имя...";
            ChangeDaysPerson.Text = "Кол-во дней...";
            ChangeSumPerson.Text = "Новая Сумма...";
            NamePerson.Text = "";
            ListboxAdd(names);

        }

        private string[] GetNamesTrainers(List<Trainer> trainers)
        {
            string[] names = new string[trainers.Count];

            for(int i = 0; i < trainers.Count; i++)
            {
                names[i] = $"Тренер: {trainers[i].Name} |  Количество детей: {trainers[i].Persons.Count} | Зарплата: {trainers[i].Salary}";
            }

            return names;
        }


        private void ListboxAdd(string[] names)
        {
            TrainerBox.Items.Clear();
            TrainerBox.Items.AddRange(names);
 
        }


        private void DeleteTrainer_Click(object sender, EventArgs e)
        {
            try
            {
                Program.admin.Trainers.RemoveAt(TrainerBox.SelectedIndex);
                TrainerBox.SelectedIndex = -1;
                PersonsBox.SelectedIndex = -1;
                Upt();
            }

            catch 
            {
                MessageBox.Show("Выберите тренера для удаления");
            }

        }

        private void ChangePersons_Click(object sender, EventArgs e)
        {
            PersonsBox.Items.Clear();
            try
            {
                PersonsBox.Items.AddRange(namesPerson(Program.admin.Trainers[TrainerBox.SelectedIndex]));
                Upt();
            }

            catch 
            {
                MessageBox.Show("Выберите тренера для изменения");
            }
        }

        private string[] namesPerson(Trainer trainer)
        {
            string[] names = new string[trainer.Persons.Count];

            for (int i = 0; i < trainer.Persons.Count; i++)
            {
                names[i] = $"Имя спортсмена: {trainer.Persons[i].Name} | Едет на кол-во дней: {trainer.Persons[i].Days} | Заплатил за сборы: {trainer.Persons[i].AmountMoney}";
            }

            return names;
        }

        private void ChangePerson_Click(object sender, EventArgs e)
        {
            ChangeNamePerson.Text = Program.admin.Trainers[trainerIndex].Persons[PersonIndex].Name;

            if (ChangeNamePerson.Text == "Новое Имя...")
            {
                MessageBox.Show("Вы забыли поменять имя");
                return;
            }

            if (double.TryParse(ChangeDaysPerson.Text, out double d))
            { 
                Program.admin.Trainers[trainerIndex].Persons[PersonIndex].Days = d;
                Program.admin.UptPersonsDay(d, trainerIndex, PersonIndex);
            }


            if (double.TryParse(ChangeSumPerson.Text, out double s))
            {
                Program.admin.Trainers[trainerIndex].Persons[PersonIndex].AmountMoney = s;
            }


            if (ChangeNamePerson.Text != "Новое имя...") Program.admin.Trainers[trainerIndex].Persons[PersonIndex].Name = ChangeNamePerson.Text;

            UptChangePersons(Program.admin.Trainers[trainerIndex]);
            Upt();
        }

        private void UptChangePersons(Trainer trainer)
        {
            PersonsBox.Items.Clear();
            PersonsBox.Items.AddRange(namesPerson(trainer));

        }

        private void ChangeNamePerson_Enter(object sender, EventArgs e)
        {
            ChangeNamePerson.Clear();
        }

        private void TrainerBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (TrainerBox.SelectedIndex != -1) trainerIndex = TrainerBox.SelectedIndex;
        }

        private void PersonsBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(PersonsBox.SelectedIndex != -1) PersonIndex = PersonsBox.SelectedIndex;
        }

        private void ChangeDaysPerson_Enter(object sender, EventArgs e)
        {
            ChangeDaysPerson.Clear();
        }

        private void ChangeSumPerson_Enter(object sender, EventArgs e)
        {
            ChangeSumPerson.Clear();
        }

        private void NameTrainer_Enter(object sender, EventArgs e)
        {
            if(NameTrainer.Text == "Имя тренера...") NameTrainer.Clear();
        }

        private void NamePerson_Enter(Object sender, EventArgs e)
        {
            if(NamePerson.Text == "Имя спортсмена...") NamePerson.Clear();
        }

        private void HowMuchDay_Enter(object sender, EventArgs e)
        {
           if(HowMuchDay.Text == "Кол-во дней...") HowMuchDay.Clear();
        }

        private void GoToSettings_Click(object sender, EventArgs e)
        {
            SettingsCamps settingsCamps = new SettingsCamps();
            this.Dispose();
            settingsCamps.ShowDialog();
        }

    }   
}
