using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace HP2.Pages;

public class PrivacyModel : PageModel
{
    private readonly ILogger<PrivacyModel> _logger;

    //Con este DA hacemos que matcheamos las propiedades con el OnPost 
    [BindProperty]
    public Form Data{get;set;}

    public PrivacyModel(ILogger<PrivacyModel> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {
       var parametro = Request.Query["parametro"];

       //Instanciamos el Form, y cuando llamamos a la pagina, le asignamos estos valores al objeto que creamos
        Data = new Form();
        Data.Mail = parametro;
        Data.Password = "12345";
    }

    public IActionResult OnPost(){
       if(!ModelState.IsValid){
        return Page();
       }
       //guardar en base datos, procesar informacion
       var formValues = Data;

       //redireccionamos a get, o index, etc
       return RedirectToPage("Index");
    }
}

