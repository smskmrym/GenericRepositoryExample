using System.Collections.Generic;

namespace GenericRepositoryExample.Core.Models
{
    public class Artist
    {
        public Artist()
        {
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Music> Musics { get; set; }
    }
}
