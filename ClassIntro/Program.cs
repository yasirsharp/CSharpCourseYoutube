using System;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Yasir";
            int age = 17;

            Course course1 = new Course();
            course1.CourseName = "C#";
            course1.Instructor = "Yasir Demirci";
            course1.TrackingRate = 24;

            Course course2 = new Course();
            course2.CourseName = "C++";
            course2.Instructor = "Engin Demiroğ";
            course2.TrackingRate = 25;

            Course course3 = new Course();
            course3.CourseName = "Python";
            course3.Instructor = "Kasım Adalan";
            course3.TrackingRate = 21;

            Course course4 = new Course();
            course4.CourseName = "Java";
            course4.Instructor = "Kerem Varış";
            course4.TrackingRate = 21;

            Course course5 = new Course();
            course5.CourseName = "C";
            course5.Instructor = "Murat Kurtboğan";
            course5.TrackingRate = 21;

            /*Console.WriteLine("Kurs Adı : " + course1.CourseName + ", Kurs Eğitmeni :  " + course1.Instructor +
                ", Kursun İzlenme Oranı : " + course1.TrackingRate
            );*/

            Course[] courses = new Course[] {
                course1,
                course2,
                course3,
                course4,
                course5
            };

            foreach (var course in courses)
            {
                Console.WriteLine(course.Instructor +" : "+ course.CourseName);
            }
        }
    }
    class Course
    {
        public string CourseName { get; set; }
        public string Instructor { get; set; }
        public int TrackingRate { get; set; }

    }
}
