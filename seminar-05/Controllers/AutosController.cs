using Microsoft.AspNetCore.Mvc;
using Seminar.Models;
using System.Collections.Generic;

namespace Seminar.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AutosController : ControllerBase
    {
        private readonly List<Auto> autos = new List<Auto>()
        {
            new Auto {
                Id = 1,
                Make = "Subaru",
                Model = "CrossTrek",
                Year = 2014
            },
            new Auto {
                Id = 2,
                Make = "Subaru",
                Model = "Outback",
                Year = 2017
            },
            new Auto {
                Id = 3,
                Make = "Subaru",
                Model = "Forester",
                Year = 2008
            },
            new Auto {
                Id = 4,
                Make = "Subaru",
                Model = "Imprezza",
                Year = 2003
            },
            new Auto {
                Id = 5,
                Make = "Ford",
                Model = "F150",
                Year = 2012
            },
            new Auto {
                Id = 5,
                Make = "Ford",
                Model = "Festiva",
                Year = 2001
            },
            new Auto {
                Id = 6,
                Make = "Ford",
                Model = "Pinto",
                Year = 1982
            },
            new Auto {
                Id = 7,
                Make = "Ford",
                Model = "F10",
                Year = 2011
            },
            new Auto {
                Id = 8,
                Make = "Ford",
                Model = "Mustang",
                Year = 2014
            },
            new Auto {
                Id = 9,
                Make = "Chevrolet",
                Model = "Volt",
                Year = 2014
            },
            new Auto {
                Id = 10,
                Make = "Chevrolet",
                Model = "Blazer",
                Year = 2001
            },
            new Auto {
                Id = 11,
                Make = "Chevrolet",
                Model = "Suburban",
                Year = 2009
            },
            new Auto {
                Id = 12,
                Make = "Chevrolet",
                Model = "Leaf",
                Year = 2016
            },
            new Auto {
                Id = 13,
                Make = "Dodge",
                Model = "Charger",
                Year = 2018
            },
            new Auto {
                Id = 14,
                Make = "Dodge",
                Model = "Caravan",
                Year = 1998
            },
            new Auto {
                Id = 15,
                Make = "Dodge",
                Model = "Caravan",
                Year = 2018
            },
            new Auto {
                Id = 16,
                Make = "Dodge",
                Model = "Charger",
                Year = 1987
            }
        };

        [HttpGet]
        public object GetAutos()
        {
            return autos;
        }
    }
}