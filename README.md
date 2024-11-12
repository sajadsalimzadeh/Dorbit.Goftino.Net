# آموزش استفاده از API پکیج گفتینو

گفتینو یک پلتفرم ارتباطی برای سایت‌ها و اپلیکیشن‌ها است که امکان چت آنلاین با کاربران را فراهم می‌کند. API پکیج گفتینو به توسعه‌دهندگان این امکان را می‌دهد که پیام‌ها، کاربران و دیگر ویژگی‌های چت را از طریق برنامه‌های خود مدیریت کنند.

## مقدمه

این پکیج جهت ساده سازی استفاده از API گفتینو توسعه یافته است

برای استفاده از این پکیج کافیتس با استفاده از Nuget Package Manager یا از طریق Command آن را نصب کرده و با استفاده از API_KEY از آن استفاده نمایید.



```bash
dotnet add package Dorbit.Goftino
```

## Full example with webhook
```C#
public class GoftinoService
{
    private readonly GoftinoApiV1WebhookHandler _webhookHandler = new();
    private const string OperatorId = "<OperatorId>";
    private GoftinoApiV1 Api => new("<API_KEY>");

    public GoftinoService()
    {
        _webhookHandler.OnNewMessage += async (sender, dto) => await NewMessageHandler(dto);
    }

    public void Handle(GoftinoWebhookRequest request)
    {
        _webhookHandler.Handle(request);
    }

    public async Task NewMessageHandler(GoftinoWebhookNewMessageDto dto)
    {
        await Api.SendMessageAsync(new GoftinoMessageSendRequest(dto.ChatId, OperatorId, "Hi"));
    }
}
```

### Controller
```C#
public class GoftinoController(GoftinoService goftinoService) : BaseApiController
{
    [HttpPost]
    public IActionResult Webhook([FromBody] GoftinoWebhookRequest request)
    {
        goftinoService.Handle(request);
        return Ok();
    }
}
```