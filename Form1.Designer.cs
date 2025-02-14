namespace MyWinFormsApp;

partial class Form1
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;
    
    // UI Elements
    private System.Windows.Forms.Label myLabel;
    private System.Windows.Forms.TextBox myTextBox;
    private System.Windows.Forms.Button myButton;

    /// <summary>
    ///  Clean up any resources being used.
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
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        this.components = new System.ComponentModel.Container();
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(800, 450);
        this.Text = "My First Windows Form";

        // 🔹 Label
        this.myLabel = new System.Windows.Forms.Label();
        this.myLabel.Text = "Enter Your Name:";
        this.myLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
        this.myLabel.ForeColor = System.Drawing.Color.DarkBlue;
        this.myLabel.AutoSize = true;
        this.myLabel.Location = new System.Drawing.Point(50, 50);

        // 🔹 TextBox
        this.myTextBox = new System.Windows.Forms.TextBox();
        this.myTextBox.Location = new System.Drawing.Point(200, 50);
        this.myTextBox.Size = new System.Drawing.Size(200, 30);

        // 🔹 Button
        this.myButton = new System.Windows.Forms.Button();
        this.myButton.Text = "Click Me";
        this.myButton.Size = new System.Drawing.Size(100, 40);
        this.myButton.Location = new System.Drawing.Point(200, 100);
        this.myButton.BackColor = System.Drawing.Color.White;

        // 🔹 Button Click Event (Calls the function in Form1.cs)
        this.myButton.Click += new System.EventHandler(this.MyButton_Click);

        // 🔹 Add Controls to Form
        this.Controls.Add(this.myLabel);
        this.Controls.Add(this.myTextBox);
        this.Controls.Add(this.myButton);
    }

    #endregion
}
