// Creamos la clase
using System.ComponentModel.DataAnnotations;

public class Form{
    //Las Data Annotations: Nos dan funciones adicionales a las propiedades
    [Required]
    [Display(Name = "Correo electronico")]
    public string Mail{get;set;}

    [Required]
    [Display(Name ="Contraseña")]
    public string Password{get;set;}
}