using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/[controller]")]
public class BaseActivityController : ControllerBase {
    private static readonly List<BaseActivity> Activities = new();

    [HttpPost]
    public IActionResult Post([FromBody] BaseActivity dto) {
        Activities.Add(dto);
        return Ok();
    }

    [HttpGet]
    public IActionResult Get() {
        return Ok(Activities);
    }
}

public class BaseActivity {
    public DateTime DateCreate { get; set; }
    public DateTime DateStartActivity { get; set; }
    public DateTime? DateEndActivity { get; set; }
    public string Activity { get; set; }
    public string? Description { get; set; }
    public string? Place { get; set; }
    public string? MapLink { get; set; }
    public User Creator { get; set; }
    public List<User> Participants { get; set; }
    public int messageId { get; set; }
}

public class User {
    public long Id { get; set; }
    public string Name { get; set; }
    public string? TelegramUsername { get; set; }
    public string lastMessage { get; set; }
    public DateTime? lastMessageDate { get; set; }
    public DateTime firstMessageDate { get; set; }
    
    public User(long id, string name, string? telegramUsername, DateTime firstMessageDate, string lastMessage = default, DateTime? lastMessageDate = default) {
        Id = id;
        Name = name;
        TelegramUsername = telegramUsername;
        this.lastMessage = lastMessage;
        this.lastMessageDate = lastMessageDate;
        this.firstMessageDate = firstMessageDate;
    }
}

