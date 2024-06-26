﻿namespace Starls.Assets.DTO
{
    public class Character
    {
        public string Name { get; set; } = string.Empty;

        public decimal Height { get; set; }

        public decimal Mass { get; set; }

        public string HairColor { get; set; } = string.Empty;

        public string SkinColor { get; set; } = string.Empty;

        public string EyeColor { get; set; } = string.Empty;

        public string BirthYear { get; set; } = string.Empty;

        public string Gender { get; set; } = string.Empty;

        public string ImageUrl { get; set; } = string.Empty;

        public List<Planet> Planets { get; set; } = new();

        public List<Film> Movies { get; set; } = new();


        //  public List<Starship> Starships { get; set; } = new();
    }
}