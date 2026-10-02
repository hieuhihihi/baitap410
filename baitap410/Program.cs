using baitap410;

SubjectStudent subject = new SubjectStudent();

subject.id = 1;
subject.name = "Lap trinh C#";
subject.semes = 1;
subject.teacher = "Nguyen Van A";

subject.students.Add(new Student
{
    stID = 1,
    name = "Nguyen Van B",
    midPart = 8.5,
    finalPart = 9.0
});

subject.students.Add(new Student
{
    stID = 2,
    name = "Nguyen Van C",
    midPart = 7.5,
    finalPart = 8.0
});

Console.WriteLine("Mon hoc: " + subject.name);
Console.WriteLine("Giang vien: " + subject.teacher);
Console.WriteLine("Hoc ky: " + subject.semes);

Console.WriteLine("\nDanh sach sinh vien:");

foreach (Student student in subject.students)
{
    Console.WriteLine(
        $"Ma SV: {student.stID} - " +
        $"Ten: {student.name} - " +
        $"Giua ky: {student.midPart} - " +
        $"Cuoi ky: {student.finalPart}"
    );
}