using System;
using System.Drawing;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace MyWinFormsApp
{
    public partial class Form1 : Form
    {
        private readonly Color primaryColor = Color.FromArgb(63, 81, 181);
        private readonly Color secondaryColor = Color.FromArgb(255, 193, 7);
        private readonly Color backgroundColor = Color.FromArgb(33, 33, 33);
        private readonly Color textColor = Color.White;
        private readonly Color errorColor = Color.FromArgb(244, 67, 54);

        private TextBox[] inputFields;
        private Label[] floatingLabels;
        private Button submitButton;

        public Form1()
        {
            InitializeComponent();
            InitializeCustomComponents();
        }

        private void InitializeCustomComponents()
        {
            this.Text = "Student Registration";
            this.Size = new Size(600, 800);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.BackColor = backgroundColor;

            Panel titlePanel = new Panel
            {
                BackColor = primaryColor,
                Dock = DockStyle.Top,
                Height = 80
            };

            Label titleLabel = new Label
            {
                Text = "Student Registration",
                Font = new Font("Segoe UI", 24, FontStyle.Bold),
                ForeColor = textColor,
                Dock = DockStyle.Fill,
                TextAlign = ContentAlignment.MiddleCenter
            };

            string[] placeholders = { "Student Name", "Father's Name", "Class", "CNIC", "Phone", "Roll No", "Email" };

            inputFields = new TextBox[placeholders.Length];
            floatingLabels = new Label[placeholders.Length];

            for (int i = 0; i < placeholders.Length; i++)
            {
                CreateInputField(placeholders[i], 120 + (i * 80), i);
            }

            submitButton = new Button
            {
                Text = "SUBMIT",
                Font = new Font("Segoe UI", 14, FontStyle.Bold),
                ForeColor = textColor,
                BackColor = secondaryColor,
                FlatStyle = FlatStyle.Flat,
                Size = new Size(400, 50),
                Location = new Point(100, 650)
            };
            submitButton.FlatAppearance.BorderSize = 0;
            submitButton.Click += SubmitButton_Click;

            titlePanel.Controls.Add(titleLabel);
            this.Controls.Add(titlePanel);
            this.Controls.Add(submitButton);
        }

        private void CreateInputField(string placeholder, int y, int index)
        {
            Panel container = new Panel
            {
                Size = new Size(400, 60),
                Location = new Point(100, y),
                BackColor = Color.FromArgb(66, 66, 66)
            };

            TextBox textBox = new TextBox
            {
                Font = new Font("Segoe UI", 12),
                ForeColor = textColor,
                BackColor = Color.FromArgb(66, 66, 66),
                BorderStyle = BorderStyle.None,
                Size = new Size(380, 30),
                Location = new Point(10, 25),
                Tag = index
            };

            Label label = new Label
            {
                Text = placeholder,
                Font = new Font("Segoe UI", 12),
                ForeColor = Color.FromArgb(150, 150, 150),
                Location = new Point(10, 5),
                AutoSize = true
            };

            textBox.GotFocus += (s, e) => AnimateLabelUp(label, textBox);
            textBox.LostFocus += (s, e) => AnimateLabelDown(label, textBox);
            textBox.TextChanged += (s, e) => ValidateInput(textBox, index);

            container.Controls.Add(textBox);
            container.Controls.Add(label);
            this.Controls.Add(container);

            inputFields[index] = textBox;
            floatingLabels[index] = label;
        }

        private void AnimateLabelUp(Label label, TextBox textBox)
        {
            label.ForeColor = secondaryColor;
            label.Location = new Point(label.Location.X, -5);
            label.Font = new Font(label.Font.FontFamily, 10);
        }

        private void AnimateLabelDown(Label label, TextBox textBox)
        {
            if (string.IsNullOrEmpty(textBox.Text))
            {
                label.ForeColor = Color.FromArgb(150, 150, 150);
                label.Location = new Point(label.Location.X, 5);
                label.Font = new Font(label.Font.FontFamily, 12);
            }
        }

        private void ValidateInput(TextBox textBox, int index)
        {
            bool isValid = true;
            string text = textBox.Text;

            switch (index)
            {
                case 3:
                    isValid = Regex.IsMatch(text, @"^\d{5}-\d{7}-\d$");
                    break;
                case 4:
                    isValid = Regex.IsMatch(text, @"^\d{11}$");
                    break;
                case 6:
                    isValid = Regex.IsMatch(text, @"^[^@\s]+@[^@\s]+\.[^@\s]+$");
                    break;
            }

            textBox.ForeColor = isValid ? textColor : errorColor;
            floatingLabels[index].ForeColor = isValid ? secondaryColor : errorColor;
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            string result = "";
            for (int i = 0; i < inputFields.Length; i++)
            {
                result += floatingLabels[i].Text + ": " + inputFields[i].Text + "\n";
            }
            MessageBox.Show(result, "Registration Details", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
