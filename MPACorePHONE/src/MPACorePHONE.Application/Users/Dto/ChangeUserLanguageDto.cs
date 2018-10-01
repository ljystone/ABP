using System.ComponentModel.DataAnnotations;

namespace MPACorePHONE.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}