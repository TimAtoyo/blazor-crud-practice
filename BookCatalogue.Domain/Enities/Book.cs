using BookCatalogue.Domain.Enums;

namespace BookCalalogue.Domain;
    public class Book {
        public int Id { get; set; }
        public string? Title { get; set; }
        public string? Author { get; set; }
        public DateTime? PublicationDate { get; set; }
        public Category Category { get; set; }

    }

