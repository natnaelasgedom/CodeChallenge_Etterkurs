namespace CodeChallengeSept20_2.Models
{
    public class ContactInfo
    {
        public int Id { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string ClosestRelativeName { get; set; }
        public string ClosestRelativePhone { get; set; }
        public string ClosestRelativeEmail { get; set; }
        public int StudentId { get; set; }
        public Student Student { get; set; }
    }
}