using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace UnityTelegramServer.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MessagesController : ControllerBase
    {
        private static readonly List<string> Messages = new();

        [HttpPost]
        public IActionResult Post([FromBody] MessageDto dto)
        {
            Messages.Add(dto.Text);
            return Ok();
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(Messages);
        }
    }

    public class MessageDto
    {
        public string Text { get; set; }
    }
}

