using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;
using BookCatalogue.Domain.Enums;

namespace BookCalalogue.Domain;
    public class Book {
        public int Id { get; set; }
        [Required(ErrorMessage ="Please Provide a Title")]
        [StringLength(100)]
        public string? Title { get; set; }
    [Required(ErrorMessage = "Please Provide a Authors Name")]
    [StringLength(100)]
        public string? Author { get; set; }
        public DateTime? PublicationDate { get; set; }
        [EnumDataType(typeof(Category), ErrorMessage = "Please Select a Category")]
        public Category Category { get; set; }

    }

