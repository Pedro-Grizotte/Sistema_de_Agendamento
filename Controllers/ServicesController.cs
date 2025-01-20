using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Sistema_de_Agendamento.Models;

namespace Sistema_de_Agendamento.Controllers
{
    public class ServicesController : Controller
    {
        public IActionResult Index() {
            List<Service> list = new List<Service>();
            list.Add(new Service { IdName = 1, Name_Service = "Clínico Geral"});
            list.Add(new Service { IdName = 2, Name_Service = "Odontopediatra" });
            list.Add(new Service { IdName = 3, Name_Service = "Ortodontista" });
            list.Add(new Service { IdName = 4, Name_Service = "Endodontista" });
            list.Add(new Service { IdName = 5, Name_Service = "Periodontista" });
            list.Add(new Service { IdName = 6, Name_Service = "Estomatologista" });
            list.Add(new Service { IdName = 7, Name_Service = "Especialista em Dentística Restauradora" });
            list.Add(new Service { IdName = 8, Name_Service = "Proteista" });
            list.Add(new Service { IdName = 9, Name_Service = "Cirurgião bucomaxilofacial" });
            list.Add(new Service { IdName = 10, Name_Service = "Especialista em Disfunção e dor orofacial" });
            return View(list);
        }
    }
}