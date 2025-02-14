namespace MyWinFormsApp;

partial class Form1
{
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    // UI Elements (Declared at Class Level)
    private System.Windows.Forms.Label[] labels;
    private System.Windows.Forms.TextBox[] textBoxes;
    private System.Windows.Forms.Button submitButton;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
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
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        this.components = new System.ComponentModel.Container();
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(500, 400);
        this.Text = "Student Information";

        // 🔹 Labels and TextBoxes for Student Details
        string[] labelTexts = { "Name:", "Father Name:", "Roll No:", "Class:", "Email:", "Phone:" };
        labels = new System.Windows.Forms.Label[labelTexts.Length];
        textBoxes = new System.Windows.Forms.TextBox[labelTexts.Length];

        for (int i = 0; i < labelTexts.Length; i++)
        {
            // Create and position labels
            labels[i] = new System.Windows.Forms.Label();
            labels[i].Text = labelTexts[i];
            labels[i].Location = new System.Drawing.Point(20, 30 + i * 40);
            labels[i].AutoSize = true;
            this.Controls.Add(labels[i]);

            // Create and position textboxes
            textBoxes[i] = new System.Windows.Forms.TextBox();
            textBoxes[i].Location = new System.Drawing.Point(150, 30 + i * 40);
            textBoxes[i].Size = new System.Drawing.Size(200, 30);
            this.Controls.Add(textBoxes[i]);
        }

        // 🔹 Submit Button
        submitButton = new System.Windows.Forms.Button();
        submitButton.Text = "Submit";
        submitButton.Size = new System.Drawing.Size(100, 40);
        submitButton.Location = new System.Drawing.Point(150, 280);
        submitButton.BackColor = System.Drawing.Color.LightGray;

        // 🔹 Assign Event Handler (Defined in Form1.cs)
        submitButton.Click += new System.EventHandler(this.SubmitButton_Click);

        // 🔹 Add Button to Form
        this.Controls.Add(submitButton);
    }

    #endregion
}
