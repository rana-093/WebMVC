using System.ComponentModel.DataAnnotations;

namespace Demo_MVC.ViewModels;

public class LoginViewModel
{
    [Required]
    public String Username { get; set; }
    
    [Required]
    [DataType(DataType.Password)]
    public String Password { get; set; }
}