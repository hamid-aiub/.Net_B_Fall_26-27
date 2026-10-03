namespace IntroToMVC_B.Models
{
    public class StudentModel
    {
        public int? id { get; set; }
        public required string name { get; set; }
        public required string  dept { get; set; }
        public required float cgpa { get; set; }
    }
}
