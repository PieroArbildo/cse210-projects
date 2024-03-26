public class WritingAssignment  : Assignment
{
    private string _tittle;

    public WritingAssignment (String tittle,string studentName, string topic):base(studentName,topic)
    {
        _tittle = tittle; 
    }

    public string GetWritingInformation()
    {
        return $"{_tittle} by {GetstudentName()}";
    } 
}