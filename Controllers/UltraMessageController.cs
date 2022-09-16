using Microsoft.AspNetCore.Mvc;
using System.Text.Json;

namespace WhatsappChatbot.Properties
{
    [Route("api/")]
    [ApiController]
    public class UltraMessageController : ControllerBase
    {
        private readonly ChatService _chatService;
        public UltraMessageController(ChatService chatService)
        {
            _chatService = chatService;
        }
        [HttpPost]
        public IActionResult Post([FromBody] HookData data)
        {
            var result = _chatService.OnChat(data.Data.From, data.Data.Body);
            Console.WriteLine(JsonSerializer.Serialize(data));
            return Ok(data);
        }
    }
}
