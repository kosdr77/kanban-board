﻿using kanbanboard.Classes;
using kanbanboard.Controls;
using System.Windows.Forms;

namespace kanbanboard.Forms
{
    public partial class ChangeForm : Form
    {
        public new MainForm Owner { get; }
        private readonly TitlePanel _titlePanel;

        public ChangeForm(MainForm owner, TitlePanel titlePanel)
        {
            Owner = owner;
            _titlePanel = titlePanel;
            InitializeComponent();

            Text = "Изменение заголовка";

            KeyDown += (_, a) =>
            {
                if (a.KeyValue is ((int)Keys.Enter) or ((int)Keys.Escape))
                {
                    Close();
                }
            };

            // Начальный текст
            Load += (_, _) =>
            {
                ChangingTextBox.Text = _titlePanel.TitleColumnLabel.Text;
                ChangingTextBox.Focus();
            };

            // Сохранение
            FormClosing += (_, _) =>
            {
                _titlePanel.TitleColumnLabel.Text = ChangingTextBox.Text;
            };
        }

        public ChangeForm(MainForm owner, User user)
        {
            Owner = owner;
            InitializeComponent();

            Text = "Создать новый проект";

            KeyDown += (_, a) =>
            {
                if (a.KeyValue is ((int)Keys.Enter) or ((int)Keys.Escape))
                {
                    Close();
                }
            };

            // Сохранение
            FormClosing += async (_, _) =>
            {
                if (!string.IsNullOrEmpty(ChangingTextBox.Text))
                    await user.CreateProject(ChangingTextBox.Text);
            };
        }
    }
}
