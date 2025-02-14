namespace MyWinFormsApp;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent(); // Calls UI setup from Form1.Designer.cs
    }

    // 🔹 Button Click Event Handler
    private void MyButton_Click(object sender, EventArgs e)
    {
        MessageBox.Show("Hello, " + this.myTextBox.Text + "!");
    }
}
