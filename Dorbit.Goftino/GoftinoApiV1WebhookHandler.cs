using System;
using System.Text.Json;
using Dorbit.Goftino.Contracts.V1.Webhook;

namespace Dorbit.Goftino
{
    public class GoftinoApiV1WebhookHandler
    {
        public event EventHandler<GoftinoWebhookNewMessageDto> OnNewMessage;
        public event EventHandler<GoftinoWebhookCloseChatDto> OnCloseChat;
        public event EventHandler<GoftinoWebhookTransferChatDto> OnTransferChat;
        public event EventHandler<GoftinoWebhookRatingDto> OnRating;

        private T ConvertDataToObject<T>(JsonElement data)
        {
            return data.Deserialize<T>();
        }
        
        public object Handle(GoftinoWebhookRequest request)
        {
            switch (request.Event)
            {
                case "new_message":
                    var newMessageDto = ConvertDataToObject<GoftinoWebhookNewMessageDto>(request.Data);
                    OnNewMessage?.Invoke(this, newMessageDto);
                    return newMessageDto;
                case "close_chat":
                    var closeChatDto = ConvertDataToObject<GoftinoWebhookCloseChatDto>(request.Data);
                    OnCloseChat?.Invoke(this, closeChatDto);
                    return closeChatDto;
                case "transfer_chat":
                    var transferChatDto = ConvertDataToObject<GoftinoWebhookTransferChatDto>(request.Data);
                    OnTransferChat?.Invoke(this, transferChatDto);
                    return transferChatDto;
                case "rating":
                    var ratingDto = ConvertDataToObject<GoftinoWebhookRatingDto>(request.Data);
                    OnRating?.Invoke(this, ratingDto);
                    return ratingDto;
            }

            return default;
        }
    }
}