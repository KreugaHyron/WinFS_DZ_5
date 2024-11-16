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
                MessageBox.Show("���� �����, ������ ��'�.", "�������", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(textBoxPhone.Text) || !textBoxPhone.Text.All(char.IsDigit))
            {
                MessageBox.Show("���� �����, ������ ��������� ����� �������� (����� �����).", "�������", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string name = textBoxName.Text;
            string phone = textBoxPhone.Text;
            string orderDate = dateTimePickerOrderDate.Value.ToString("f"); // ������: ����� ���� � ���

            string mainDish = listBoxMenu.SelectedItem?.ToString() ?? "�� �������";
            string extras = string.Join(", ", checkedListBoxAdd.CheckedItems.Cast<string>());
            string orderType = radioButtonOrderByCafe.Checked && radioButtonOrderByPerson.Checked ? "��������" : "��������";

            string message =
                $"��'�: {name}\n" +
                $"�������: {phone}\n" +
                $"���� � ��� ���������: {orderDate}\n" +
                $"������� ������: {mainDish}\n" +
                $"�������� �����䳺���: {extras}\n" +
                $"����� ����������: {orderType}";
            MessageBox.Show(message, "ϳ����������� ����������", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
