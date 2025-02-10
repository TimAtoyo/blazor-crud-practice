using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;
using BookCatalogue.Domain.Enums;

namespace BookCalalogue.Domain;
    public class Book {
        public int Id { get; set; }
        [Required]
        [StringLength(100)]
        public string? Title { get; set; }
        [Required]
        [StringLength(100)]
        public string? Author { get; set; }
        public DateTime? PublicationDate { get; set; }
        public Category Category { get; set; }

    }

