namespace MyWinFormsApp;

public class Student
{
    // Properties
    public string Name { get; set; }
    public string FatherName { get; set; }
    public string RollNo { get; set; }
    public string Class { get; set; }
    public string Email { get; set; }
    public string Phone { get; set; }

    // Constructor
    public Student(string name, string fatherName, string rollNo, string className, string email, string phone)
    {
        Name = name;
        FatherName = fatherName;
        RollNo = rollNo;
        Class = className;
        Email = email;
        Phone = phone;
    }

    // Method to display student info
    public string GetInfo()
    {
        return $"Student Name: {Name}\nFather's Name: {FatherName}\nRoll No: {RollNo}\nClass: {Class}\nEmail: {Email}\nPhone: {Phone}";
    }
}
