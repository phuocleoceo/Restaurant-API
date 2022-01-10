using LuxuryRestaurantAPI.Email;
using Microsoft.AspNetCore.Mvc;

namespace LuxuryRestaurantAPI.Controllers;

[ApiController]
[Route("api/[controller]")]
public class EmailController : ControllerBase
{
    private readonly IMailService _mailService;
    public EmailController(IMailService mailService)
    {
        _mailService = mailService;
    }

    [HttpPost("Send")]
    public async Task<IActionResult> Send([FromForm] MailContent mailContent)
    {
        await _mailService.SendEmailAsync(mailContent);
        return Ok();
    }
}
