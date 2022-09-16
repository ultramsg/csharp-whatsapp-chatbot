using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using RestSharp;

namespace WhatsappChatbot.Controllers
{
    [Route("api/")]
    [ApiController]
    public class ChatController : ControllerBase
    {
        private readonly ChatService _chatService;
      
        public ChatController(ChatService chatService)
        {
            _chatService = chatService;
        }
        [HttpGet("{number}/{id}")]
        public IActionResult OnChat(string number, string? id)
        {
            var result = _chatService.OnChat(number, id);
            return Ok(result);
        }


    }
}
