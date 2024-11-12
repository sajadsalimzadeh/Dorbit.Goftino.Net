using Dorbit.Goftino.Contracts.V1.Chats;
using Dorbit.Goftino.Contracts.V1.Messages;
using Dorbit.Goftino.Contracts.V1.Operators;
using Dorbit.Goftino.Contracts.V1.Users;

namespace Dorbit.Goftino.Test;

public class GoftinoApiV1Test
{
    private const string OperatorId = "<OperatorId>";
    private const string ApiKey = "<ApiKey>";
    
    private string chatId;
    private string userId;
    private string lastMessageId;
    private GoftinoApiV1 api = new GoftinoApiV1(ApiKey);

    [SetUp]
    public async Task Setup()
    {
        var getChatAllResponse = await api.GetAllChatAsync(new GoftinoChatListRequest());
        var chat = getChatAllResponse.Data.Chats.FirstOrDefault(x => x.LastMessage.Content == "api test");
        if (chat is null)
        {
            var createChatResponse = await api.CreateChatAsync(new GoftinoChatCreateRequest("api test"));
            if (createChatResponse.Data is not null)
            {
                getChatAllResponse = await api.GetAllChatAsync(new GoftinoChatListRequest());
                chat = getChatAllResponse.Data.Chats.FirstOrDefault(x => x.LastMessage.Content == "api test");
            }
        }
        
        if(chat is null)
        {
            throw new Exception("Error creating chat");
        }

        chatId = chat.ChatId;
        userId = chat.UserId;
        lastMessageId = chat.LastMessage.MessageId;
    }

    [Test, Order(20)]
    public async Task GetAllChatAsync()
    {
        var response = await api.GetAllChatAsync(new GoftinoChatListRequest());
        Assert.IsTrue(response.Success);
    }

    [Test, Order(30)]
    public async Task GetAllChatDataAsync()
    {
        var response = await api.GetAllChatDataAsync(new GoftinoChatDataRequest(chatId));
        Assert.IsTrue(response.Success);
    }

    [Test, Order(40)]
    public async Task SendMessageFromUserAsync()
    {
        var response = await api.SendMessageFromUserAsync(new GoftinoMessageSendFromUserRequest(chatId, "api test"));
        Assert.IsTrue(response.Success);
    }

    [Test, Order(50)]
    public async Task OperatorTypingAsync()
    {
        var response = await api.OperatorTypingAsync(new GoftinoChatTypeingRequest(chatId, OperatorId, true));
        Assert.IsTrue(response.Success);
        await api.OperatorTypingAsync(new GoftinoChatTypeingRequest(chatId, OperatorId, false));
    }

    [Test, Order(60)]
    public async Task UnAssignChatAsync()
    {
        var response = await api.UnAssignChatAsync(new GoftinoChatUnAssignRequest(chatId, OperatorId));
        Assert.IsTrue(response.Success);
    }
    
    [Test, Order(70)]
    public async Task SendMessageAsync()
    {
        var response = await api.SendMessageAsync(new GoftinoMessageSendRequest(chatId, OperatorId, "api test"));
        Assert.IsTrue(response.Success);
    }

    [Test, Order(80)]
    public async Task CloseChatAsync()
    {
        var response = await api.CloseChatAsync(new GoftinoChatCloseRequest(chatId, OperatorId));
        Assert.IsTrue(response.Success);
    }

    [Test, Order(90)]
    public async Task GetAllUnreadMessageAsync()
    {
        var response = await api.GetAllUnreadMessageAsync(new GoftinoChatUnreadMessageRequest(GoftinoChatUnreadMessageRequest.RequestType.ChatId, chatId));
        Assert.IsTrue(response.Success);
    }

    // [Test, Order(100)]
    // public async Task EditMessageAsync()
    // {
    //     var response = await api.EditMessageAsync(new GoftinoMessageEditRequest("api test", lastMessageId));
    //     Assert.IsTrue(response.Success);
    // }

    [Test, Order(110)]
    public async Task GetMessageHistoryAsync()
    {
        var response = await api.GetMessageHistoryAsync(new GoftinoMessageHistoryRequest(lastMessageId));
        Assert.IsTrue(response.Success);
    }
    
    // [Test, Order(120)]
    // public async Task SendPollAsync()
    // {
    //     var response = await api.SendPollAsync(new GoftinoPollSendRequest(chatId));
    //     Assert.IsTrue(response.Success);
    // }
    
    [Test, Order(130)]
    public async Task RemoveChatAsync()
    {
        var createChatResponse = await api.CreateChatAsync(new GoftinoChatCreateRequest("api test"));
        var response = await api.RemoveChatAsync(new GoftinoChatRemoveRequest(createChatResponse.Data.ChatId));
        Assert.IsTrue(response.Success);
    }
    
    [Test, Order(140)]
    public async Task GetUserAsync()
    {
        var response = await api.GetUserAsync(new GoftinoUserGetRequest(GoftinoUserGetRequest.RequestType.UserId, userId));
        Assert.IsTrue(response.Success);
    }
    
    [Test, Order(150)]
    public async Task EditUserAsync()
    {
        var response = await api.EditUserAsync(new GoftinoUserEditRequest(userId)
        {
            Name = "Dorbit Goftino Test"
        });
        Assert.IsTrue(response.Success);
    }
    
    [Test, Order(160)]
    public async Task GetUserVisitedPagesAsync()
    {
        var response = await api.GetUserVisitedPagesAsync(new GoftinoUserGetVisitedPageRequest(userId));
        Assert.IsTrue(response.Success);
    }
    
    [Test, Order(170)]
    public async Task GetAllOperatorAsync()
    {
        var response = await api.GetAllOperatorAsync();
        Assert.IsTrue(response.Success);
    }
    
    [Test, Order(180)]
    public async Task GetOperatorAsync()
    {
        var response = await api.GetOperatorAsync(new GoftinoOperatorGetRequest(GoftinoOperatorGetRequest.RequestType.OperatorId, OperatorId));
        Assert.IsTrue(response.Success);
    }
}