namespace IntroToMVC_W2_Lab_B.Models
{
    public class Employee
    {
        public int? id { get; set; }
        public required string email { get; set; }
        public required string name { get; set; }
        public required string designation { get; set; }
        public int? age { get; set; }
        public required int salary { get; set; }

    }
}
