using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Commands.Models;
using Microsoft.AspNetCore.Mvc;

namespace Commands.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CommandsController : ControllerBase
    {
        public CommandsController(CommandsContext context)
        {
            _context = context;
        }

        private readonly CommandsContext _context;

        [HttpGet]
        public ActionResult<IEnumerable<Models.Commands>> Get()
        {
            return _context.CommandsItems;
        }
    }
}
