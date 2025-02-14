namespace MyWinFormsApp;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent(); // Calls UI setup from Form1.Designer.cs
    }

    // 🔹 Button Click Event Handler for Student Info Submission
    private void SubmitButton_Click(object sender, EventArgs e)
    {
        string studentData = $"Student Details:\n" +
                             $"Name: {textBoxes[0].Text}\n" +
                             $"Father Name: {textBoxes[1].Text}\n" +
                             $"Roll No: {textBoxes[2].Text}\n" +
                             $"Class: {textBoxes[3].Text}\n" +
                             $"Email: {textBoxes[4].Text}\n" +
                             $"Phone: {textBoxes[5].Text}";

        // Display student information
        MessageBox.Show(studentData, "Student Info");
    }
}
