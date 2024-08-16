using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AresCampsWinForms.Forms;
using AresCampsWinForms.src;

namespace AresCampsWinForms
{
    public partial class SettingsCamps : Form
    {

        public SettingsCamps()
        {
            InitializeComponent();
        }

        private void SaveSettings_Click(object sender, EventArgs e)
        {
            if(double.TryParse(ProcentClub.Text, out double resultProcentClub))
            {
                Program.admin.ChangeProcentClub(resultProcentClub);
            }

            if(double.TryParse(AllSum.Text, out double resultAllSum))
            {
                Program.admin.ChangeAllSum(resultAllSum);
            }

            if (double.TryParse(Days.Text, out double resultDays))
            {
                Program.admin.ChangeDaysAndSumEvryDay(resultDays);
            }

            if (double.TryParse(MaxSalary.Text, out double resultMaxSalary))
            {
                Program.admin.ChangeMaxSalary(resultMaxSalary);
            }

            if(double.TryParse(MinPersonsFreeCamp.Text, out double resultMinPersonsFreeCamp))
            {
                Program.admin.ChangeMinPersonsFreeCamp(resultMinPersonsFreeCamp);
            }

            if (double.TryParse(PriceBus.Text, out double resultPriceBus))
            {
                Program.admin.ChangePriceBus(resultPriceBus);
            }

            if (double.TryParse(PriceCamp.Text, out double resultPriceCamp))
            {
                Program.admin.ChangePriceCamp(resultPriceCamp);
            }

            if(double.TryParse(PriceMore.Text, out double resultPriceMore))
            {
                Program.admin.ChangePriceMore(resultPriceMore);
            }

            Upd();
        }

        private void SettingsCamps_Load(object sender, EventArgs e)
        {
            Upd();
            
        }

        private void Upd()
        {
            LProcentClub.Text = Program.admin.TextStatsForLabels(LProcentClub.Name);
            LAllSum.Text = Program.admin.TextStatsForLabels(LAllSum.Name);
            LDays.Text = Program.admin.TextStatsForLabels(LDays.Name);
            LMaxSalary.Text = Program.admin.TextStatsForLabels(LMaxSalary.Name);
            LMinPersonsFreeCamp.Text = Program.admin.TextStatsForLabels(LMinPersonsFreeCamp.Name);
            LPriceBus.Text = Program.admin.TextStatsForLabels(LPriceBus.Name);
            LPriceCamp.Text = Program.admin.TextStatsForLabels(LPriceCamp.Name);
            LPriceMore.Text = Program.admin.TextStatsForLabels(LPriceMore.Name);
            LEvryDaySum.Text = Program.admin.TextStatsForLabels(LEvryDaySum.Name);
            ProcentClub.Text = "Процент клубу...";
            AllSum.Text = "Сумма за все дни...";
            Days.Text = "Всего дней...";
            PriceCamp.Text = "Цена за базу...";
            MaxSalary.Text = "Макс зарплата...";
            MinPersonsFreeCamp.Text = "Free Camp...";
            PriceBus.Text = "Сумма на Автобусы...";
            PriceMore.Text = "Другие расходы...";
        }

        private void BGoToAddPersons_Click(object sender, EventArgs e)
        {
            AddPersonsForm addPersons = new AddPersonsForm();
            this.Visible = false;
            addPersons.ShowDialog();
        }

        private void ProcentClub_Enter(object sender, EventArgs e)
        {
            ProcentClub.Clear();
        }

        private void AllSum_Enter(object sender, EventArgs e)
        {
            AllSum.Clear();
        }

        private void Days_Enter(object sender, EventArgs e)
        {
            Days.Clear();
        }

        private void PriceCamp_Enter(object sender, EventArgs e)
        {
            PriceCamp.Clear();
        }

        private void MaxSalary_Enter(object sender, EventArgs e)
        {
            MaxSalary.Clear();
        }

        private void MinPersonsFreeCamp_Enter(object sender, EventArgs e)
        {
            MinPersonsFreeCamp.Clear();
        }

        private void PriceBus_Enter(object sender, EventArgs e)
        {
            PriceBus.Clear();
        }

        private void PriceMore_Enter(object sender, EventArgs e)
        {
            PriceMore.Clear();
        }

        private void ProcentClub_Leave(object sender, EventArgs e)
        {
            if(ProcentClub.Text == "")
            {
                ProcentClub.Text = "Процент клубу...";
            }
        }

        private void AllSum_Leave(object sender, EventArgs e)
        {
            if(AllSum.Text == "")
            {
                AllSum.Text = "Сумма за все дни...";
            }
        }

        private void Days_Leave(object sender, EventArgs e)
        {
            if (Days.Text == "")
            {
                Days.Text = "Всего дней...";
            }
        }

        private void PriceCamp_Leave(object sender, EventArgs e)
        {
            if(PriceCamp.Text == "")
            {
                PriceCamp.Text = "Цена за базу...";
            }
        }

        private void MaxSalary_Leave(object sender, EventArgs e)
        {
            if(MaxSalary.Text == "")
            {
                MaxSalary.Text = "Макс зарплата...";
            }
        }

        private void MinPersonsFreeCamp_Leave(object sender, EventArgs e)
        {
            if(MinPersonsFreeCamp.Text == "")
            {
                MinPersonsFreeCamp.Text = "Free Camp...";
            }
        }

        private void PriceBus_Leave(object sender, EventArgs e)
        {
            if(PriceBus.Text == "")
            {
                PriceBus.Text = "Сумма на Автобусы...";
            }
        }

        private void PriceMore_Leave(object sender, EventArgs e)
        {
            if(PriceMore.Text == "")
            {
                PriceMore.Text = "Другие расходы...";
            }
        }
    }
}
