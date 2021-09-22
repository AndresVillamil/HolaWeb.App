//using System.Security.AccessControl;
using System.Collections.Generic;
using HolaWeb.App.Dominio;

namespace HolaWeb.App.Persistencia.AppRepositorios

{
    public class RepositorioSaludosMemoria : IRepositorioSaludos
    {
        //Simula la base de datos
        List<Saludo> saludos;

        //Constructor
        public RepositorioSaludosMemoria()
        {
            saludos= new List<Saludo>()
            {
                new Saludo{Id=1,EnEspanol="Buenos Días", EnIngles="Good Morning",EnItaliano="Bungiorno"},
                new Saludo{Id=2,EnEspanol="Buenas Tardes", EnIngles="Good Afternoon",EnItaliano="Buon pomeriggio"},
                new Saludo{Id=3,EnEspanol="Buenas Noches", EnIngles="Good Evening",EnItaliano="Buona notte"}
            };
        }

        public IEnumerable<Saludo> GetAll()
        {
            //Implementar lista
            return saludos;
        }
    }
}