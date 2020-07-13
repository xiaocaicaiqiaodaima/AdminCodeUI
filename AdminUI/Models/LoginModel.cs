using System.ComponentModel.DataAnnotations;

namespace AdminUI.Models
{
    public class LoginModel
    {
        public string userName { get; set; }
        [DataType(DataType.Password)]
        public string password { get; set; }
    }
}
