
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AresCampsWinForms.src
{
    internal class Admin
    {
        List<Trainer> trainers = new List<Trainer>();
        public List<Trainer> Trainers { get { return trainers; } set { trainers = value; } }
        public double ProcentClub { get; private set; }
        public double AllSum { get; private set; }
        public double Days { get; private set; }
        public double EvryDaysSum { get; private set; }
        public double MaxSalary { get; private set; }
        public double MinPersonsFreeCamp { get; private set; }
        public double PriceBus { get; private set; }
        public double PriceCamp { get; private set; }
        public double PriceMore { get; private set; }

        public void ChangeProcentClub(double procentClub) => ProcentClub = procentClub / 100;
        public void ChangeAllSum(double allSum) => AllSum = allSum;
        public void ChangeDaysAndSumEvryDay(double days)
        {
            Days = days;
            EvryDaysSum = AllSum / Days;
        }

        public void ChangeMaxSalary(double maxSalary) => MaxSalary = maxSalary;
        public void ChangeMinPersonsFreeCamp(double minPersonsFreeCamp) => MinPersonsFreeCamp = minPersonsFreeCamp;
        public void ChangePriceBus(double priceBus) => PriceBus = priceBus;
        public void ChangePriceCamp(double priceCamp) => PriceCamp = priceCamp;
        public void ChangePriceMore(double priceMore) => PriceMore = priceMore;
        
        public string TextStatsForLabels(string labelName)
        {
            if (labelName == "LProcentClub") return $"Процент Клубу: {ProcentClub * 100}%";


            else if (labelName == "LAllSum") return $"Сумма за сборы: {AllSum}";


            else if (labelName == "LDays") return $"Количество дней: {Days}";


            else if (labelName == "LMaxSalary") return $"Макс Зарплата: {MaxSalary}";


            else if (labelName == "LMinPersonsFreeCamp") return $"Free Camp: {MinPersonsFreeCamp}";


            else if (labelName == "LPriceBus") return $"Оплата автобуса: {PriceBus}";


            else if (labelName == "LPriceCamp") return $"Оплата Сборов: {PriceCamp}";


            else if (labelName == "LPriceMore") return $"Оплата(Другое): {PriceMore}";


            else return $"Сумма за каждый день: {Math.Round(EvryDaysSum,2)}";
        }

        public void AddPerson(string nameTrainer, string namePerson, double days)
        {
            if (trainers.Count == 0)
            {
                Trainer trainer = new Trainer();
                trainer.Name = nameTrainer;
                trainers.Add(trainer);
                trainers[0].Persons = ReturnListPersons(trainers[0].Persons, namePerson, days);
                trainers[0].Salary = TrainerSalary(trainers[0], days);
            }

            else
            {

                string name = nameTrainer;
                if (trainers.Any(x => x.Name == name))
                {
                    foreach (Trainer trainer in trainers)
                    {
                        if (trainer.Name == name)
                        {
                            trainer.Persons = ReturnListPersons(trainer.Persons, namePerson, days);
                            trainer.Salary = TrainerSalary(trainer, days);
                        }
                    }
                }

                else
                {
                    Trainer trainer = new Trainer();
                    trainer.Name = nameTrainer;
                    trainer.Persons = ReturnListPersons(trainer.Persons, namePerson, days);
                    trainer.Salary = TrainerSalary(trainer, days);
                    trainers.Add(trainer);
                }
            }
        }

        private List<Person> ReturnListPersons(List<Person> persons, string namePerson, double days)
        {
            Person person = new Person();
            person.Name = namePerson;
            person.Days = days;
            person.AmountMoney = Program.admin.EvryDaysSum * days;
            persons.Add(person);
            return persons;
        }

        private double TrainerSalary(Trainer trainer, double days)
        {
            double salary = 0;
            if (trainer.Persons.Count <= Program.admin.MinPersonsFreeCamp)
            {
                return 0;
            }

            else
            {
                trainer.Salary += MaxSalary / Days * days;
                return trainer.Salary;
            }
        }

        public void UptPersonsDay(double days, int indexTrainer, int indexPerson)
        {
            Trainers[indexTrainer].Persons[indexPerson].Days = days;
            Trainers[indexTrainer].Persons[indexPerson].AmountMoney = Program.admin.EvryDaysSum * Trainers[indexTrainer].Persons[indexPerson].Days;
        }
    }
}
