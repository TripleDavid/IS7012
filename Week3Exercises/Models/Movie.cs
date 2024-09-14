namespace Week3Exercises.Models
{
    public class Movie
    {
        public int MovieId { get; set; }
        public string Title { get; set; }
        public int ReleaseYear { get; set; }
        public decimal BoxOfficeReceipts { get; set; }
        public Director? Director { get; set; }
        public int? DirectorId { get; set; }
    }
}
