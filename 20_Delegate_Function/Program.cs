using _20_Delegate_Function.Models;

namespace _20_Delegate_Function
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Task1
            //Person person1 = new Person("Ibrahim", "Xusmandi", 20);
            //Person person2= new Person("Qarib", "Qaribzade", 24);
            //Person person3= new Person("Shahin", "Alizade", 17);
            //Person person4= new Person("Elmir", "Qenberov", 22);


            //List<Person> list = new List<Person> { person1, person2, person3, person4};




            //List<Person> name = list.FindAll(a => a.Name == "Ibrahim");
            //List<Person> end = list.FindAll(a => a.Surname.EndsWith("ov") || a.Surname.EndsWith("ova"));
            //List<Person> age = list.FindAll(a => a.Age > 20);


            //name.ForEach(a => { Console.WriteLine(a.Name); });
            //Console.WriteLine("__");
            //end.ForEach(a => { Console.WriteLine(a.Name); });
            //Console.WriteLine("__");
            //age.ForEach(a => { Console.WriteLine(a.Name); });
            #endregion

            #region Task2
            //DateTime dateTime = DateTime.Now;

            //Exam exam1 = new Exam("Ibrahim",3);
            //Exam exam2 = new Exam("Qarib", 2);
            //Exam exam3 = new Exam("Shahin", 5);
            //exam1.Start();

            //List<Exam> exams = new List<Exam> {exam1, exam2, exam3};

            //List<Exam> LastAnyWeek = exams.FindAll(a => a.StartTime.AddDays(7) > DateTime.Now);
            //List<Exam> MoreThenOur = exams.FindAll(a => a.ExamDuration > 2);
            //List<Exam> ContinueExam = exams.FindAll(a => a.EndTime.Hour - a.StartTime.Hour > 0);

            //LastAnyWeek.ForEach(a => { Console.WriteLine(a.Subject + " " + a.ExamDuration); });
            //Console.WriteLine("__");
            //MoreThenOur.ForEach(a => { Console.WriteLine(a.Subject + " " + a.ExamDuration); });
            //Console.WriteLine("__");
            //ContinueExam.ForEach(a => { Console.WriteLine(a.Subject + " " + a.ExamDuration); });
            #endregion
        }
    }
}
