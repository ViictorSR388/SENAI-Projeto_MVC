using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace mvc_seuNome.Controllers
{
    public class ProductController : Controller
    {
        public string Index(){
            return "Escola SENAI Suíço-Brasileira Paulo Ernesto Tolle";
        }

        public string Welcome(){
            return "Seja bem vindo(a)!";
        }

        public string Contact(){
            return "Telefone: (11) 5642-3400 | Email: secretaria115@sp.senai.br";
        }
    }
}