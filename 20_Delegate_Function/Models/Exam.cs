namespace _20_Delegate_Function.Models
{
    internal class Exam
    {
        public string Subject { get; set; }
        public int ExamDuration { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime {  get; set; }

        public Exam(string subjetc, int examDuration)
        {
            Subject = subjetc;
            ExamDuration = examDuration;
        }

        public void Start ()
        {
            StartTime = DateTime.Now;
            EndTime = StartTime.AddHours(ExamDuration);
        }
    }
}
