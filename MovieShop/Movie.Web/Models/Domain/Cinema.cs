namespace Movie.Web.Models.Domain
{
    public class Cinema
    {
        public Guid Id { get; set; }

        public string Logo { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        //Relationships

        public List<Movie> Movies { get; set; }
    }
}
