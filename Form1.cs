using System.Xml.Linq;

namespace WinFS_DZ_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void buttonConfirmOrder_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxName.Text))
            {
                MessageBox.Show("Будь ласка, введіть ім'я.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(textBoxPhone.Text) || !textBoxPhone.Text.All(char.IsDigit))
            {
                MessageBox.Show("Будь ласка, введіть коректний номер телефону (тільки цифри).", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string name = textBoxName.Text;
            string phone = textBoxPhone.Text;
            string orderDate = dateTimePickerOrderDate.Value.ToString("f"); // Формат: повна дата і час

            string mainDish = listBoxMenu.SelectedItem?.ToString() ?? "Не вибрано";
            string extras = string.Join(", ", checkedListBoxAdd.CheckedItems.Cast<string>());
            string orderType = radioButtonOrderByCafe.Checked && radioButtonOrderByPerson.Checked ? "Доставка" : "Самовивіз";

            string message =
                $"Ім'я: {name}\n" +
                $"Телефон: {phone}\n" +
                $"Дата і час отримання: {orderDate}\n" +
                $"Основна страва: {mainDish}\n" +
                $"Додаткові інгредієнти: {extras}\n" +
                $"Спосіб замовлення: {orderType}";
            MessageBox.Show(message, "Підтвердження замовлення", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
