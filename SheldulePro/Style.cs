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
                    // Применяем стили кнопок
                    button.BackColor = Color.FromArgb(50, 50, 50);
                    button.ForeColor = Color.White;
                    button.FlatStyle = FlatStyle.Flat;
                    button.FlatAppearance.BorderColor = Color.SteelBlue;
                    button.FlatAppearance.BorderSize = 1;
                    button.Font = new Font("Segoe UI", 12, FontStyle.Bold);
                    button.Cursor = Cursors.Hand;

                    // Адаптивность: кнопка растягивается с изменением размеров формы
                    button.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;

                    // Эффекты при наведении
                    button.MouseEnter += (sender, e) => button.BackColor = Color.SteelBlue;
                    button.MouseLeave += (sender, e) => button.BackColor = Color.FromArgb(50, 50, 50);
                }
                else if (ctrl is ListBox listBox)
                {
                    // Применяем стили для ListBox
                    listBox.BackColor = Color.FromArgb(30, 30, 30); // Темный фон
                    listBox.ForeColor = Color.White; // Цвет текста
                    listBox.Font = new Font("Segoe UI", 10, FontStyle.Regular);
                    listBox.BorderStyle = BorderStyle.FixedSingle;

                  
                    listBox.DrawItem += (sender, e) =>
                    {
                        if (e.Index < 0) return;

                        // Рисуем фон
                        e.DrawBackground();

                        // Устанавливаем цвет текста в зависимости от состояния
                        Color textColor = (e.State & DrawItemState.Selected) == DrawItemState.Selected ? Color.White : listBox.ForeColor;
                        Color backgroundColor = (e.State & DrawItemState.Selected) == DrawItemState.Selected ? Color.SteelBlue : listBox.BackColor;

                        // Рисуем прямоугольник фона
                        e.Graphics.FillRectangle(new SolidBrush(backgroundColor), e.Bounds);
                        e.Graphics.DrawString(listBox.Items[e.Index].ToString(), listBox.Font, new SolidBrush(textColor), e.Bounds);

                        e.DrawFocusRectangle();
                    };

                    // Адаптивность для ListBox
                    listBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
                }
                else if (ctrl is TextBox textBox)
                {
                    // Применяем стили текстовых полей
                    textBox.BorderStyle = BorderStyle.FixedSingle;
                    textBox.BackColor = Color.FromArgb(30, 30, 30);
                    textBox.ForeColor = Color.White;
                    textBox.Font = new Font("Consolas", 11, FontStyle.Regular);

                    // Адаптивность для TextBox
                    textBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
                }
                else if (ctrl is ComboBox comboBox)
                {
                    // Применяем стили комбобоксов
                    comboBox.DropDownStyle = ComboBoxStyle.DropDownList;
                    comboBox.BackColor = Color.FromArgb(40, 40, 40);
                    comboBox.ForeColor = Color.White;
                    comboBox.FlatStyle = FlatStyle.Flat;
                    comboBox.Font = new Font("Segoe UI", 10, FontStyle.Bold);

                    // Адаптивность для ComboBox
                    comboBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
                }
                else if (ctrl is DataGridView dataGridView)
                {
                    // Применяем стили для DataGridView
                    dataGridView.BackgroundColor = Color.FromArgb(30, 30, 30); // Темный фон
                    dataGridView.ForeColor = Color.White; // Цвет текста
                    dataGridView.GridColor = Color.Gray; // Цвет сетки
                    dataGridView.BorderStyle = BorderStyle.None;

                    // Устанавливаем одинаковый шрифт для всех ячеек и заголовков
                    var font = new Font("Consolas", 10, FontStyle.Regular); // Шрифт для таблицы
                    dataGridView.DefaultCellStyle.Font = font; // Применяем шрифт к ячейкам
                    dataGridView.ColumnHeadersDefaultCellStyle.Font = font; // Применяем тот же шрифт к заголовкам

                    // Цвет фона и текста для заголовков
                    dataGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(40, 40, 40); // Цвет фона заголовков
                    dataGridView.ColumnHeadersDefaultCellStyle.ForeColor = Color.White; // Цвет текста заголовков

                    // Устанавливаем цвет фона и текста для строк
                    dataGridView.DefaultCellStyle.BackColor = Color.FromArgb(40, 40, 40); // Темный фон строк
                    dataGridView.DefaultCellStyle.ForeColor = Color.White; // Цвет текста в строках
                    dataGridView.DefaultCellStyle.SelectionBackColor = Color.SteelBlue; // Цвет фона выбранных строк
                    dataGridView.DefaultCellStyle.SelectionForeColor = Color.White; // Цвет текста в выбранных строках

                    // Убираем отображение заголовков строк
                    dataGridView.RowHeadersVisible = false;

                    // Устанавливаем стиль для выравнивания текста в ячейках
                    dataGridView.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

                    // Применяем автоматическое заполнение столбцов
                    dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill; // Автоматическое заполнение столбцов
                   
                }
                else if (ctrl is Label label)
                {
                    // Применяем стили для Label
                    label.BackColor = Color.Transparent; // Прозрачный фон
                    label.ForeColor = Color.White; // Цвет текста
                    label.Font = new Font("Segoe UI", 11, FontStyle.Regular); // Шрифт и размер
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
