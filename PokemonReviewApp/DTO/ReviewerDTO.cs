﻿using PokemonReviewApp.Models;

namespace PokemonReviewApp.DTO
{
    public class ReviewerDTO
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public ICollection<ReviewDTO> Reviews { get; set; }
    }
}
