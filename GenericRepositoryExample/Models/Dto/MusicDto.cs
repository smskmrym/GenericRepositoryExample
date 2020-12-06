namespace GenericRepositoryExample.Models.Dto
{
    public class MusicDto
    {
        public MusicDto()
        {
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public ArtistDto Artist { get; set; }
    }
}
