using System;
namespace GenericRepositoryExample.Models.Dto
{
    public class SaveMusicDto
    {
        public SaveMusicDto()
        {
        }

        public string Name { get; set; }
        public int ArtistId { get; set; }
    }
}
