using System.Text.Json;
using Dorbit.Goftino.Contracts.V1.Webhook;

namespace Dorbit.Goftino.Test;

public class GoftinoApiV1WebhookTest
{
    [SetUp]
    public void Setup()
    {
        
    }

    [Test]
    public void NewMessage()
    {
        var webhookRequest = JsonSerializer.Deserialize<GoftinoWebhookRequest>(@"{
            ""event"": ""new_message"",
            ""data"": {
                ""chat_id"": ""61225d8fc0925903200fbc74"",
                ""user_id"": ""61225d87c0925903200fbc73b0423a29b1330017ea8498167e9a7c024d05c3c8"",
                ""sender"": {
                    ""from"": ""operator"",
                    ""name"": ""ali"",
                    ""id"": ""61031e563060c5ffe08f2525""
                },
                ""date"": ""2021-09-05 21:38:03"",
                ""content"": ""How can I help you?"",
                ""type"": ""text"",
                ""message_id"": ""5d225d8fc0925903200fb5e1"",
                ""current_owner"": [""61031e563060c5ffe08f2525""]
            }
        }");

        var isRaised = false;
        var handler = new GoftinoApiV1WebhookHandler();
        handler.OnNewMessage += (sender, dto) =>
        {
            isRaised = true;
        };
        handler.Handle(webhookRequest);
        Assert.IsTrue(isRaised);
    }
    
    
    [Test]
    public void CloseChat()
    {
        var webhookRequest = JsonSerializer.Deserialize<GoftinoWebhookRequest>(@"{
            ""event"": ""close_chat"",
            ""data"": {
                ""chat_id"": ""61225d8fc0925903200fbc74"",
                ""user_id"": ""61225d87c0925903200fbc73b0423a29b1330017ea8498167e9a7c024d05c3c8"",
                ""date"": ""2021-09-05 21:38:03"",
                ""action_by"": ""61225d8fc0925903200fba32""
            }
        }");
        
        var isRaised = false;
        var handler = new GoftinoApiV1WebhookHandler();
        handler.OnCloseChat += (sender, dto) =>
        {
            isRaised = true;
        };
        handler.Handle(webhookRequest);
        Assert.IsTrue(isRaised);
    }
    
    
    [Test]
    public void TransferChat()
    {
        var webhookRequest = JsonSerializer.Deserialize<GoftinoWebhookRequest>(@"{
            ""event"": ""transfer_chat"",
            ""data"": {
                ""chat_id"": ""61225d8fc0925903200fbc74"",
                ""user_id"": ""61225d87c0925903200fbc73b0423a29b1330017ea8498167e9a7c024d05c3c8"",
                ""date"": ""2021-09-05 21:38:03"",
                ""action_by"": ""61225d8fc0925903200fba32"",
                ""to_operator"": ""5d225d8fc0925903200fb5e1""
            }
        }");
        
        var isRaised = false;
        var handler = new GoftinoApiV1WebhookHandler();
        handler.OnTransferChat += (sender, dto) =>
        {
            isRaised = true;
        };
        handler.Handle(webhookRequest);
        Assert.IsTrue(isRaised);
    }
    
    
    [Test]
    public void Rating()
    {
        var webhookRequest = JsonSerializer.Deserialize<GoftinoWebhookRequest>(@"{
            ""event"": ""rating"",
            ""data"": {
                ""chat_id"": ""61225d8fc0925903200fbc74"",
                ""user_id"": ""61225d87c0925903200fbc73b0423a29b1330017ea8498167e9a7c024d05c3c8"",
                ""date"": ""2021-09-05 21:38:03"",
                ""rate"": ""3"",
                ""to_operator"": ""5d225d8fc0925903200fb5e1""
            }
        }");
        
        var isRaised = false;
        var handler = new GoftinoApiV1WebhookHandler();
        handler.OnRating += (sender, dto) =>
        {
            isRaised = true;
        };
        handler.Handle(webhookRequest);
        Assert.IsTrue(isRaised);
    }
}