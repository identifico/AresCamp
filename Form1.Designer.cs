namespace AresCampsWinForms
{
    partial class SettingsCamps
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
            this.SaveSettings = new System.Windows.Forms.Button();
            this.ProcentClub = new System.Windows.Forms.TextBox();
            this.AllSum = new System.Windows.Forms.TextBox();
            this.Days = new System.Windows.Forms.TextBox();
            this.MaxSalary = new System.Windows.Forms.TextBox();
            this.MinPersonsFreeCamp = new System.Windows.Forms.TextBox();
            this.PriceBus = new System.Windows.Forms.TextBox();
            this.PriceCamp = new System.Windows.Forms.TextBox();
            this.PriceMore = new System.Windows.Forms.TextBox();
            this.LProcentClub = new System.Windows.Forms.Label();
            this.LAllSum = new System.Windows.Forms.Label();
            this.LDays = new System.Windows.Forms.Label();
            this.LMaxSalary = new System.Windows.Forms.Label();
            this.LMinPersonsFreeCamp = new System.Windows.Forms.Label();
            this.LPriceBus = new System.Windows.Forms.Label();
            this.LPriceCamp = new System.Windows.Forms.Label();
            this.LPriceMore = new System.Windows.Forms.Label();
            this.LEvryDaySum = new System.Windows.Forms.Label();
            this.BGoToAddPersons = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SaveSettings
            // 
            this.SaveSettings.BackColor = System.Drawing.Color.Black;
            this.SaveSettings.FlatAppearance.BorderSize = 0;
            this.SaveSettings.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.SaveSettings.Font = new System.Drawing.Font("Cascadia Code", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SaveSettings.ForeColor = System.Drawing.Color.OrangeRed;
            this.SaveSettings.Location = new System.Drawing.Point(313, 95);
            this.SaveSettings.Name = "SaveSettings";
            this.SaveSettings.Size = new System.Drawing.Size(100, 32);
            this.SaveSettings.TabIndex = 0;
            this.SaveSettings.Text = "Сохранить";
            this.SaveSettings.UseVisualStyleBackColor = false;
            this.SaveSettings.Click += new System.EventHandler(this.SaveSettings_Click);
            // 
            // ProcentClub
            // 
            this.ProcentClub.BackColor = System.Drawing.Color.Black;
            this.ProcentClub.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ProcentClub.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.ProcentClub.Location = new System.Drawing.Point(12, 19);
            this.ProcentClub.Name = "ProcentClub";
            this.ProcentClub.Size = new System.Drawing.Size(100, 13);
            this.ProcentClub.TabIndex = 1;
            this.ProcentClub.Text = "Процент клубу...";
            this.ProcentClub.Enter += new System.EventHandler(this.ProcentClub_Enter);
            this.ProcentClub.Leave += new System.EventHandler(this.ProcentClub_Leave);
            // 
            // AllSum
            // 
            this.AllSum.BackColor = System.Drawing.Color.Black;
            this.AllSum.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.AllSum.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.AllSum.Location = new System.Drawing.Point(12, 38);
            this.AllSum.Name = "AllSum";
            this.AllSum.Size = new System.Drawing.Size(100, 13);
            this.AllSum.TabIndex = 6;
            this.AllSum.Text = "Сумма за все дни...";
            this.AllSum.Enter += new System.EventHandler(this.AllSum_Enter);
            this.AllSum.Leave += new System.EventHandler(this.AllSum_Leave);
            // 
            // Days
            // 
            this.Days.BackColor = System.Drawing.Color.Black;
            this.Days.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Days.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.Days.Location = new System.Drawing.Point(12, 57);
            this.Days.Name = "Days";
            this.Days.Size = new System.Drawing.Size(100, 13);
            this.Days.TabIndex = 7;
            this.Days.Text = "Всего дней...";
            this.Days.Enter += new System.EventHandler(this.Days_Enter);
            this.Days.Leave += new System.EventHandler(this.Days_Leave);
            // 
            // MaxSalary
            // 
            this.MaxSalary.BackColor = System.Drawing.Color.Black;
            this.MaxSalary.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MaxSalary.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.MaxSalary.Location = new System.Drawing.Point(313, 19);
            this.MaxSalary.Name = "MaxSalary";
            this.MaxSalary.Size = new System.Drawing.Size(100, 13);
            this.MaxSalary.TabIndex = 9;
            this.MaxSalary.Text = "Макс зарплата...";
            this.MaxSalary.Enter += new System.EventHandler(this.MaxSalary_Enter);
            this.MaxSalary.Leave += new System.EventHandler(this.MaxSalary_Leave);
            // 
            // MinPersonsFreeCamp
            // 
            this.MinPersonsFreeCamp.BackColor = System.Drawing.Color.Black;
            this.MinPersonsFreeCamp.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MinPersonsFreeCamp.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.MinPersonsFreeCamp.Location = new System.Drawing.Point(313, 38);
            this.MinPersonsFreeCamp.Name = "MinPersonsFreeCamp";
            this.MinPersonsFreeCamp.Size = new System.Drawing.Size(100, 13);
            this.MinPersonsFreeCamp.TabIndex = 10;
            this.MinPersonsFreeCamp.Text = "Free Camp...";
            this.MinPersonsFreeCamp.Enter += new System.EventHandler(this.MinPersonsFreeCamp_Enter);
            this.MinPersonsFreeCamp.Leave += new System.EventHandler(this.MinPersonsFreeCamp_Leave);
            // 
            // PriceBus
            // 
            this.PriceBus.BackColor = System.Drawing.Color.Black;
            this.PriceBus.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PriceBus.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.PriceBus.Location = new System.Drawing.Point(313, 57);
            this.PriceBus.Name = "PriceBus";
            this.PriceBus.Size = new System.Drawing.Size(114, 13);
            this.PriceBus.TabIndex = 11;
            this.PriceBus.Text = "Сумма на Автобусы...";
            this.PriceBus.Enter += new System.EventHandler(this.PriceBus_Enter);
            this.PriceBus.Leave += new System.EventHandler(this.PriceBus_Leave);
            // 
            // PriceCamp
            // 
            this.PriceCamp.BackColor = System.Drawing.Color.Black;
            this.PriceCamp.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PriceCamp.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.PriceCamp.Location = new System.Drawing.Point(12, 76);
            this.PriceCamp.Name = "PriceCamp";
            this.PriceCamp.Size = new System.Drawing.Size(100, 13);
            this.PriceCamp.TabIndex = 8;
            this.PriceCamp.Text = "Цена за базу...";
            this.PriceCamp.Enter += new System.EventHandler(this.PriceCamp_Enter);
            this.PriceCamp.Leave += new System.EventHandler(this.PriceCamp_Leave);
            // 
            // PriceMore
            // 
            this.PriceMore.BackColor = System.Drawing.Color.Black;
            this.PriceMore.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PriceMore.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.PriceMore.Location = new System.Drawing.Point(313, 76);
            this.PriceMore.Name = "PriceMore";
            this.PriceMore.Size = new System.Drawing.Size(100, 13);
            this.PriceMore.TabIndex = 12;
            this.PriceMore.Text = "Другие расходы...";
            this.PriceMore.Enter += new System.EventHandler(this.PriceMore_Enter);
            this.PriceMore.Leave += new System.EventHandler(this.PriceMore_Leave);
            // 
            // LProcentClub
            // 
            this.LProcentClub.AutoSize = true;
            this.LProcentClub.BackColor = System.Drawing.Color.Transparent;
            this.LProcentClub.Font = new System.Drawing.Font("Cascadia Code", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LProcentClub.ForeColor = System.Drawing.Color.OrangeRed;
            this.LProcentClub.Location = new System.Drawing.Point(156, 441);
            this.LProcentClub.Name = "LProcentClub";
            this.LProcentClub.Size = new System.Drawing.Size(73, 15);
            this.LProcentClub.TabIndex = 17;
            this.LProcentClub.Text = "ProcentClub";
            // 
            // LAllSum
            // 
            this.LAllSum.AutoSize = true;
            this.LAllSum.BackColor = System.Drawing.Color.Transparent;
            this.LAllSum.Font = new System.Drawing.Font("Cascadia Code", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LAllSum.ForeColor = System.Drawing.Color.OrangeRed;
            this.LAllSum.Location = new System.Drawing.Point(12, 486);
            this.LAllSum.Name = "LAllSum";
            this.LAllSum.Size = new System.Drawing.Size(73, 15);
            this.LAllSum.TabIndex = 18;
            this.LAllSum.Text = "ProcentClub";
            // 
            // LDays
            // 
            this.LDays.AutoSize = true;
            this.LDays.BackColor = System.Drawing.Color.Transparent;
            this.LDays.Font = new System.Drawing.Font("Cascadia Code", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LDays.ForeColor = System.Drawing.Color.OrangeRed;
            this.LDays.Location = new System.Drawing.Point(12, 441);
            this.LDays.Name = "LDays";
            this.LDays.Size = new System.Drawing.Size(73, 15);
            this.LDays.TabIndex = 19;
            this.LDays.Text = "ProcentClub";
            // 
            // LMaxSalary
            // 
            this.LMaxSalary.AutoSize = true;
            this.LMaxSalary.BackColor = System.Drawing.Color.Transparent;
            this.LMaxSalary.Font = new System.Drawing.Font("Cascadia Code", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LMaxSalary.ForeColor = System.Drawing.Color.OrangeRed;
            this.LMaxSalary.Location = new System.Drawing.Point(12, 463);
            this.LMaxSalary.Name = "LMaxSalary";
            this.LMaxSalary.Size = new System.Drawing.Size(73, 15);
            this.LMaxSalary.TabIndex = 20;
            this.LMaxSalary.Text = "ProcentClub";
            // 
            // LMinPersonsFreeCamp
            // 
            this.LMinPersonsFreeCamp.AutoSize = true;
            this.LMinPersonsFreeCamp.BackColor = System.Drawing.Color.Transparent;
            this.LMinPersonsFreeCamp.Font = new System.Drawing.Font("Cascadia Code", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LMinPersonsFreeCamp.ForeColor = System.Drawing.Color.OrangeRed;
            this.LMinPersonsFreeCamp.Location = new System.Drawing.Point(12, 509);
            this.LMinPersonsFreeCamp.Name = "LMinPersonsFreeCamp";
            this.LMinPersonsFreeCamp.Size = new System.Drawing.Size(73, 15);
            this.LMinPersonsFreeCamp.TabIndex = 21;
            this.LMinPersonsFreeCamp.Text = "ProcentClub";
            // 
            // LPriceBus
            // 
            this.LPriceBus.AutoSize = true;
            this.LPriceBus.BackColor = System.Drawing.Color.Transparent;
            this.LPriceBus.Font = new System.Drawing.Font("Cascadia Code", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LPriceBus.ForeColor = System.Drawing.Color.OrangeRed;
            this.LPriceBus.Location = new System.Drawing.Point(286, 441);
            this.LPriceBus.Name = "LPriceBus";
            this.LPriceBus.Size = new System.Drawing.Size(73, 15);
            this.LPriceBus.TabIndex = 22;
            this.LPriceBus.Text = "ProcentClub";
            // 
            // LPriceCamp
            // 
            this.LPriceCamp.AutoSize = true;
            this.LPriceCamp.BackColor = System.Drawing.Color.Transparent;
            this.LPriceCamp.Font = new System.Drawing.Font("Cascadia Code", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LPriceCamp.ForeColor = System.Drawing.Color.OrangeRed;
            this.LPriceCamp.Location = new System.Drawing.Point(286, 463);
            this.LPriceCamp.Name = "LPriceCamp";
            this.LPriceCamp.Size = new System.Drawing.Size(73, 15);
            this.LPriceCamp.TabIndex = 23;
            this.LPriceCamp.Text = "ProcentClub";
            // 
            // LPriceMore
            // 
            this.LPriceMore.AutoSize = true;
            this.LPriceMore.BackColor = System.Drawing.Color.Transparent;
            this.LPriceMore.Font = new System.Drawing.Font("Cascadia Code", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LPriceMore.ForeColor = System.Drawing.Color.OrangeRed;
            this.LPriceMore.Location = new System.Drawing.Point(286, 486);
            this.LPriceMore.Name = "LPriceMore";
            this.LPriceMore.Size = new System.Drawing.Size(73, 15);
            this.LPriceMore.TabIndex = 24;
            this.LPriceMore.Text = "ProcentClub";
            // 
            // LEvryDaySum
            // 
            this.LEvryDaySum.AutoSize = true;
            this.LEvryDaySum.BackColor = System.Drawing.Color.Transparent;
            this.LEvryDaySum.Font = new System.Drawing.Font("Cascadia Code", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LEvryDaySum.ForeColor = System.Drawing.Color.OrangeRed;
            this.LEvryDaySum.Location = new System.Drawing.Point(145, 509);
            this.LEvryDaySum.Name = "LEvryDaySum";
            this.LEvryDaySum.Size = new System.Drawing.Size(73, 15);
            this.LEvryDaySum.TabIndex = 25;
            this.LEvryDaySum.Text = "ProcentClub";
            // 
            // BGoToAddPersons
            // 
            this.BGoToAddPersons.BackColor = System.Drawing.Color.Black;
            this.BGoToAddPersons.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BGoToAddPersons.Font = new System.Drawing.Font("Cascadia Code", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BGoToAddPersons.ForeColor = System.Drawing.Color.OrangeRed;
            this.BGoToAddPersons.Location = new System.Drawing.Point(3, 95);
            this.BGoToAddPersons.Name = "BGoToAddPersons";
            this.BGoToAddPersons.Size = new System.Drawing.Size(100, 23);
            this.BGoToAddPersons.TabIndex = 26;
            this.BGoToAddPersons.Text = "Участники";
            this.BGoToAddPersons.UseVisualStyleBackColor = false;
            this.BGoToAddPersons.Click += new System.EventHandler(this.BGoToAddPersons_Click);
            // 
            // SettingsCamps
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::AresCampsWinForms.Properties.Resources.profile;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(439, 557);
            this.Controls.Add(this.BGoToAddPersons);
            this.Controls.Add(this.LEvryDaySum);
            this.Controls.Add(this.LPriceMore);
            this.Controls.Add(this.LPriceCamp);
            this.Controls.Add(this.LPriceBus);
            this.Controls.Add(this.LMinPersonsFreeCamp);
            this.Controls.Add(this.LMaxSalary);
            this.Controls.Add(this.LDays);
            this.Controls.Add(this.LAllSum);
            this.Controls.Add(this.LProcentClub);
            this.Controls.Add(this.PriceMore);
            this.Controls.Add(this.PriceCamp);
            this.Controls.Add(this.PriceBus);
            this.Controls.Add(this.MinPersonsFreeCamp);
            this.Controls.Add(this.MaxSalary);
            this.Controls.Add(this.Days);
            this.Controls.Add(this.AllSum);
            this.Controls.Add(this.ProcentClub);
            this.Controls.Add(this.SaveSettings);
            this.Name = "SettingsCamps";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Настройка сборов";
            this.Load += new System.EventHandler(this.SettingsCamps_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SaveSettings;
        private System.Windows.Forms.TextBox ProcentClub;
        private System.Windows.Forms.TextBox AllSum;
        private System.Windows.Forms.TextBox Days;
        private System.Windows.Forms.TextBox MaxSalary;
        private System.Windows.Forms.TextBox MinPersonsFreeCamp;
        private System.Windows.Forms.TextBox PriceBus;
        private System.Windows.Forms.TextBox PriceCamp;
        private System.Windows.Forms.TextBox PriceMore;
        private System.Windows.Forms.Label LProcentClub;
        private System.Windows.Forms.Label LAllSum;
        private System.Windows.Forms.Label LDays;
        private System.Windows.Forms.Label LMaxSalary;
        private System.Windows.Forms.Label LMinPersonsFreeCamp;
        private System.Windows.Forms.Label LPriceBus;
        private System.Windows.Forms.Label LPriceCamp;
        private System.Windows.Forms.Label LPriceMore;
        private System.Windows.Forms.Label LEvryDaySum;
        private System.Windows.Forms.Button BGoToAddPersons;
    }
}

