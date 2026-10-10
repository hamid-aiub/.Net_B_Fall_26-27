namespace IntroToMVC_W2_Th_Sec_B.Models
{
    public class Student
    {
        public int? id { get; set; }
        public required string name { get; set; }
        public required string dept { get; set; }
        public float? cgpa { get; set; }
    }
}
