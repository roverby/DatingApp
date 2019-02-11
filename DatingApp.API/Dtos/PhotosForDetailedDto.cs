using System;

namespace DatingApp.API.Dtos
{
    public class PhotosForDetailedDto
    {
        public PhotosForDetailedDto(int id, string url, string description, DateTime dateAdded, bool isMain)
        {
            this.Id = id;
            this.Url = url;
            this.Description = description;
            this.DateAdded = dateAdded;
            this.IsMain = isMain;

        }
        public int Id { get; set; }
        public string Url { get; set; }
        public string Description { get; set; }
        public DateTime DateAdded { get; set; }
        public bool IsMain { get; set; }
    }
}