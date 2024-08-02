using Microsoft.AspNetCore.Identity;
namespace DomainModels
{
    public class User : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public List<int> Subjects { get; set; }
        public List<int> Grades { get; set; }
    }
}
