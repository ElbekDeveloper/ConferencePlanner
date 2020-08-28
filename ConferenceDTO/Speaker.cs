using System.ComponentModel.DataAnnotations;

namespace ConferenceDTO
{
    public class Speaker
    {
        /// <summary>
        /// Automatically generated speaker id
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Name of the Speaker
        /// </summary>
        [Required]
        [StringLength(200)]
        public string Name { get; set; }
        /// <summary>
        /// Brief biographical information about the speaker
        /// </summary>
        [StringLength(4000)]
        public string Bio { get; set; }
        /// <summary>
        /// The website of the speaker
        /// </summary>
        [StringLength(1000)]
        public virtual string WebSite { get; set; }
    }
}
