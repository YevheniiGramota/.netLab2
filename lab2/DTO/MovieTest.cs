using lab2.Models;

namespace lab2.DTO
{
    public class MovieTest
    {
        public string Name { get; set; }
        public DateTime? Release { get; set; }
        public List<Character> Characters { get; set; } = new List<Character>();

        public MovieTest(string name, DateTime release, List<Character> characters)
        {
            Name = name;
            Release = release;
            Characters = characters;
        }
    }
}
