using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SheldulePro
{
    public static class Style
    {
        public static void ApplyGlobalStyles(Control.ControlCollection controls)
        {
            foreach (Control ctrl in controls)
            {
                if (ctrl is Button button)
                {
                    // Цвет кнопки: градиент тёмно-серый с синим
                    button.BackColor = Color.FromArgb(50, 50, 50); // Тёмный фон
                    button.ForeColor = Color.White;
                    button.FlatStyle = FlatStyle.Flat;
                    button.FlatAppearance.BorderColor = Color.SteelBlue;
                    button.FlatAppearance.BorderSize = 1;
                    button.Font = new Font("Segoe UI", 12, FontStyle.Bold);
                    button.Cursor = Cursors.Hand;

                    // Эффекты при наведении
                    button.MouseEnter += (sender, e) => button.BackColor = Color.SteelBlue;
                    button.MouseLeave += (sender, e) => button.BackColor = Color.FromArgb(50, 50, 50);
                }
                else if (ctrl is TextBox textBox)
                {
                    // Тёмный фон, светлый текст
                    textBox.BorderStyle = BorderStyle.FixedSingle;
                    textBox.BackColor = Color.FromArgb(30, 30, 30); // Тёмный фон
                    textBox.ForeColor = Color.White;
                    textBox.Font = new Font("Consolas", 11, FontStyle.Regular);
                }
                else if (ctrl is MaskedTextBox maskedTextBox)
                {
                    // МаскТекстбокс с тем же стилем
                    maskedTextBox.BorderStyle = BorderStyle.FixedSingle;
                    maskedTextBox.BackColor = Color.FromArgb(30, 30, 30);
                    maskedTextBox.ForeColor = Color.White;
                    maskedTextBox.Font = new Font("Consolas", 11, FontStyle.Regular);
                }
                else if (ctrl is ComboBox comboBox)
                {
                    // Комбобокс с тёмным стилем
                    comboBox.DropDownStyle = ComboBoxStyle.DropDownList;
                    comboBox.BackColor = Color.FromArgb(40, 40, 40);
                    comboBox.ForeColor = Color.White;
                    comboBox.FlatStyle = FlatStyle.Flat;
                    comboBox.Font = new Font("Segoe UI", 10, FontStyle.Bold);
                }
                else if (ctrl is ToolStrip toolStrip)
                {
                    // ToolStrip с тёмным фоном и яркими элементами
                    toolStrip.BackColor = Color.FromArgb(40, 40, 40); // Темно-серый фон
                    toolStrip.ForeColor = Color.White;

                    foreach (ToolStripItem item in toolStrip.Items)
                    {
                        item.ForeColor = Color.White;
                        item.BackColor = Color.FromArgb(40, 40, 40);
                        item.Font = new Font("Segoe UI", 10, FontStyle.Regular);
                    }
                }
                else if (ctrl is DataGridView dataGridView)
                {
                    // Основной стиль таблицы (DataGridView)
                    dataGridView.BackgroundColor = Color.FromArgb(40, 40, 40); // Тёмный фон
                    dataGridView.ForeColor = Color.White; // Цвет текста
                    dataGridView.GridColor = Color.Gray;  // Цвет сетки
                    dataGridView.BorderStyle = BorderStyle.None;
                    dataGridView.EnableHeadersVisualStyles = false; // Для изменения стиля заголовков

                    // Стиль заголовков столбцов
                    dataGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.SteelBlue; // Цвет фона заголовков
                    dataGridView.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;      // Цвет текста заголовков
                    dataGridView.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 11, FontStyle.Bold); // Шрифт заголовков
                    dataGridView.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter; // Выравнивание текста в заголовках

                    // Стиль строк
                    dataGridView.DefaultCellStyle.BackColor = Color.FromArgb(50, 50, 50);  // Тёмный фон строк
                    dataGridView.DefaultCellStyle.ForeColor = Color.White;                 // Цвет текста в строках
                    dataGridView.DefaultCellStyle.SelectionBackColor = Color.SteelBlue;    // Цвет фона выбранных строк
                    dataGridView.DefaultCellStyle.SelectionForeColor = Color.White;        // Цвет текста в выбранных строках
                    dataGridView.DefaultCellStyle.Font = new Font("Consolas", 10, FontStyle.Regular); // Общий стиль текста строк

                    // Выравнивание текста в ячейках
                    dataGridView.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

                    // Убираем отображение заголовков строк
                    dataGridView.RowHeadersVisible = false;

                    // Стиль выделенной секции для всех колонок
                    foreach (DataGridViewColumn column in dataGridView.Columns)
                    {
                        column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;  // Выравнивание текста в колонках
                        column.DefaultCellStyle.SelectionBackColor = Color.DarkSlateGray;                // Цвет фона выбранных колонок
                        column.DefaultCellStyle.SelectionForeColor = Color.White;                        // Цвет текста в выбранных колонках
                        column.HeaderCell.Style.SelectionBackColor = Color.DarkSlateGray;                // Цвет фона выделенных заголовков колонок
                        column.HeaderCell.Style.SelectionForeColor = Color.White;                        // Цвет текста выделенных заголовков колонок
                    }
                }

                else if (ctrl is Label label)
                {
                    // Стиль для меток
                    label.ForeColor = Color.White;
                    label.Font = new Font("Segoe UI", 10, FontStyle.Regular);
                }

                // Эффекты для всех TextBox и MaskedTextBox при фокусе
                if (ctrl is TextBox || ctrl is MaskedTextBox)
                {
                    ctrl.GotFocus += (sender, e) => (sender as Control).BackColor = Color.SteelBlue;
                    ctrl.LostFocus += (sender, e) => (sender as Control).BackColor = Color.FromArgb(30, 30, 30);
                }

                // Применяем стили рекурсивно для вложенных элементов
                if (ctrl.Controls.Count > 0)
                {
                    ApplyGlobalStyles(ctrl.Controls);
                }
            }
        }
        public static void ApplyFormBackground(Form form)
        {
            // Применение градиентного фона (опционально)
            form.BackColor = Color.FromArgb(20, 20, 20); // Тёмный однотонный фон
            form.BackgroundImageLayout = ImageLayout.Stretch;
            form.StartPosition = FormStartPosition.CenterScreen;
        }

    }
}
