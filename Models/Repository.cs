namespace basics.Models
{
    public class Repository
    {
        private static readonly List<Course> _courses = new();
        static Repository() {
            _courses = new List<Course>()
            {
                new Course() {Id=1, Title="aspnet kursu", Description="guzel bir kurs", Image="1.jpg"},
                new Course() {Id=2, Title="php kursu", Description="guzel bir kurs", Image="2.jpg"},
                new Course() {Id=3, Title="django kursu", Description="guzel bir kurs", Image="3.jpg"},
                new Course() {Id=4, Title="javascript kursu", Description="guzel bir kurs", Image="4.jpg"}
            };
        }
        

        public static List<Course> Courses
        {
            get {
                return _courses;
            }   
        }

        public static Course? GetById(int? id)
        {
            return _courses.FirstOrDefault(c => c.Id == id);
        }
    }
}