using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace BuraizinPizza.Server.Controllers
{
    [Route("pizzas")]
    [ApiController]
    public class PizzasController : Controller
    {
        private readonly PizzaStoreContext _db;

        public PizzasController(PizzaStoreContext db)
        {
            _db = db;
        }
    }
}
