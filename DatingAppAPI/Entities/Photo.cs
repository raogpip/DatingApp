using System.ComponentModel.DataAnnotations.Schema;

namespace DatingAppAPI.Entities
{
    [Table("Photos")]
    public class Photo
    {
        public int Id { get; set; }
        public string Url { get; set; }
        public bool IsMain { get; set; }
        public string PublicId { get; set; }

        // NAVIGATION PROPERTIES
        public int AppUserId { get; set; }
        public AppUser User { get; set; }
    }
}