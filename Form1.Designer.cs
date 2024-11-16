namespace WinFS_DZ_5
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textBoxName = new TextBox();
            labelName = new Label();
            labelPhonenumber = new Label();
            textBoxPhone = new TextBox();
            dateTimePickerOrderDate = new DateTimePicker();
            labelOrderTimeDate = new Label();
            listBoxMenu = new ListBox();
            radioButtonOrderByCafe = new RadioButton();
            checkedListBoxAdd = new CheckedListBox();
            labelMainFood = new Label();
            labelSecondary = new Label();
            radioButtonOrderByPerson = new RadioButton();
            labelChooseOrder = new Label();
            buttonConfirmOrder = new Button();
            SuspendLayout();
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(93, 50);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(100, 23);
            textBoxName.TabIndex = 0;
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Location = new Point(56, 53);
            labelName.Name = "labelName";
            labelName.Size = new Size(31, 15);
            labelName.TabIndex = 1;
            labelName.Text = "Ім'я:";
            // 
            // labelPhonenumber
            // 
            labelPhonenumber.AutoSize = true;
            labelPhonenumber.Location = new Point(26, 104);
            labelPhonenumber.Name = "labelPhonenumber";
            labelPhonenumber.Size = new Size(58, 15);
            labelPhonenumber.TabIndex = 2;
            labelPhonenumber.Text = "Телефон:";
            // 
            // textBoxPhone
            // 
            textBoxPhone.Location = new Point(93, 101);
            textBoxPhone.Name = "textBoxPhone";
            textBoxPhone.Size = new Size(188, 23);
            textBoxPhone.TabIndex = 3;
            // 
            // dateTimePickerOrderDate
            // 
            dateTimePickerOrderDate.Location = new Point(142, 154);
            dateTimePickerOrderDate.Name = "dateTimePickerOrderDate";
            dateTimePickerOrderDate.Size = new Size(200, 23);
            dateTimePickerOrderDate.TabIndex = 4;
            // 
            // labelOrderTimeDate
            // 
            labelOrderTimeDate.AutoSize = true;
            labelOrderTimeDate.Location = new Point(12, 160);
            labelOrderTimeDate.Name = "labelOrderTimeDate";
            labelOrderTimeDate.Size = new Size(127, 15);
            labelOrderTimeDate.TabIndex = 5;
            labelOrderTimeDate.Text = "Дата і час отримання:";
            // 
            // listBoxMenu
            // 
            listBoxMenu.FormattingEnabled = true;
            listBoxMenu.ItemHeight = 15;
            listBoxMenu.Items.AddRange(new object[] { "Піца", "Паста", "Кола", "Швепс", "Холодний мохіто" });
            listBoxMenu.Location = new Point(466, 53);
            listBoxMenu.Name = "listBoxMenu";
            listBoxMenu.Size = new Size(120, 94);
            listBoxMenu.TabIndex = 6;
            // 
            // radioButtonOrderByCafe
            // 
            radioButtonOrderByCafe.AutoSize = true;
            radioButtonOrderByCafe.Location = new Point(466, 280);
            radioButtonOrderByCafe.Name = "radioButtonOrderByCafe";
            radioButtonOrderByCafe.Size = new Size(75, 19);
            radioButtonOrderByCafe.TabIndex = 7;
            radioButtonOrderByCafe.TabStop = true;
            radioButtonOrderByCafe.Text = "Доставка";
            radioButtonOrderByCafe.UseVisualStyleBackColor = true;
            // 
            // checkedListBoxAdd
            // 
            checkedListBoxAdd.FormattingEnabled = true;
            checkedListBoxAdd.Items.AddRange(new object[] { "Бекон", "Жаркое", "Шашлик зі свинини", "Шашлик з курятини", "Люля-кебаб" });
            checkedListBoxAdd.Location = new Point(466, 166);
            checkedListBoxAdd.Name = "checkedListBoxAdd";
            checkedListBoxAdd.Size = new Size(120, 94);
            checkedListBoxAdd.TabIndex = 8;
            // 
            // labelMainFood
            // 
            labelMainFood.AutoSize = true;
            labelMainFood.Location = new Point(368, 90);
            labelMainFood.Name = "labelMainFood";
            labelMainFood.Size = new Size(92, 15);
            labelMainFood.TabIndex = 9;
            labelMainFood.Text = "Основні страви";
            // 
            // labelSecondary
            // 
            labelSecondary.AutoSize = true;
            labelSecondary.Location = new Point(359, 203);
            labelSecondary.Name = "labelSecondary";
            labelSecondary.Size = new Size(101, 15);
            labelSecondary.TabIndex = 10;
            labelSecondary.Text = "Додаткові страви";
            // 
            // radioButtonOrderByPerson
            // 
            radioButtonOrderByPerson.AutoSize = true;
            radioButtonOrderByPerson.Location = new Point(466, 305);
            radioButtonOrderByPerson.Name = "radioButtonOrderByPerson";
            radioButtonOrderByPerson.Size = new Size(82, 19);
            radioButtonOrderByPerson.TabIndex = 11;
            radioButtonOrderByPerson.TabStop = true;
            radioButtonOrderByPerson.Text = "Самовивіз";
            radioButtonOrderByPerson.UseVisualStyleBackColor = true;
            // 
            // labelChooseOrder
            // 
            labelChooseOrder.AutoSize = true;
            labelChooseOrder.Location = new Point(363, 294);
            labelChooseOrder.Name = "labelChooseOrder";
            labelChooseOrder.Size = new Size(97, 15);
            labelChooseOrder.TabIndex = 12;
            labelChooseOrder.Text = "Спосіб доставки";
            // 
            // buttonConfirmOrder
            // 
            buttonConfirmOrder.Location = new Point(56, 294);
            buttonConfirmOrder.Name = "buttonConfirmOrder";
            buttonConfirmOrder.Size = new Size(161, 23);
            buttonConfirmOrder.TabIndex = 13;
            buttonConfirmOrder.Text = "Підтвердити замовлення";
            buttonConfirmOrder.UseVisualStyleBackColor = true;
            buttonConfirmOrder.Click += buttonConfirmOrder_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonConfirmOrder);
            Controls.Add(labelChooseOrder);
            Controls.Add(radioButtonOrderByPerson);
            Controls.Add(labelSecondary);
            Controls.Add(labelMainFood);
            Controls.Add(checkedListBoxAdd);
            Controls.Add(radioButtonOrderByCafe);
            Controls.Add(listBoxMenu);
            Controls.Add(labelOrderTimeDate);
            Controls.Add(dateTimePickerOrderDate);
            Controls.Add(textBoxPhone);
            Controls.Add(labelPhonenumber);
            Controls.Add(labelName);
            Controls.Add(textBoxName);
            Name = "Form1";
            Text = "Замовлення онлайн";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxName;
        private Label labelName;
        private Label labelPhonenumber;
        private TextBox textBoxPhone;
        private DateTimePicker dateTimePickerOrderDate;
        private Label labelOrderTimeDate;
        private ListBox listBoxMenu;
        private RadioButton radioButtonOrderByCafe;
        private CheckedListBox checkedListBoxAdd;
        private Label labelMainFood;
        private Label labelSecondary;
        private RadioButton radioButtonOrderByPerson;
        private Label labelChooseOrder;
        private Button buttonConfirmOrder;
    }
}
