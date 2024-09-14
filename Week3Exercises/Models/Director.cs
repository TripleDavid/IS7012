namespace Week3Exercises.Models
{
    public class Director
    {
        public int DirectorId { get; set; }
        public string Name { get; set; }
        public DateTime DateOfBirth { get; set; }
        public List<Movie>? Movies { get; set; }
    }
}
