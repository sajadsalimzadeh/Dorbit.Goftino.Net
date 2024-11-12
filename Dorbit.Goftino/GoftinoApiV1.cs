using System;
using System.Threading;
using System.Threading.Tasks;
using Dorbit.Goftino.Contracts;
using Dorbit.Goftino.Contracts.V1.Chats;
using Dorbit.Goftino.Contracts.V1.Messages;
using Dorbit.Goftino.Contracts.V1.Operators;
using Dorbit.Goftino.Contracts.V1.Poll;
using Dorbit.Goftino.Contracts.V1.Users;
using Dorbit.Goftino.Utils;

namespace Dorbit.Goftino
{
    public class GoftinoApiV1
    {
        private readonly string _apiKey;

        public GoftinoApiV1(string apiKey)
        {
            _apiKey = apiKey;
        }

        private HttpHelper GetHttpHelper()
        {
            return new HttpHelper("https://api.goftino.com/v1/", _apiKey);
        }

        public Task<GoftinoQueryResult<GoftinoChatListResponse>> GetAllChatAsync(GoftinoChatListRequest request, CancellationToken cancellationToken = default)
        {
            return GetHttpHelper().GetAsync<GoftinoQueryResult<GoftinoChatListResponse>>("chats", request, cancellationToken);
        }

        public Task<GoftinoQueryResult<GoftinoChatDataResponse>> GetAllChatDataAsync(GoftinoChatDataRequest request, CancellationToken cancellationToken = default)
        {
            return GetHttpHelper().GetAsync<GoftinoQueryResult<GoftinoChatDataResponse>>("chat_data", request, cancellationToken);
        }

        public Task<GoftinoQueryResult<GoftinoMessageSendResponse>> SendMessageAsync(GoftinoMessageSendRequest request, CancellationToken cancellationToken = default)
        {
            return GetHttpHelper().PostAsync<GoftinoQueryResult<GoftinoMessageSendResponse>>("send_message", request, cancellationToken);
        }

        public Task<GoftinoQueryResult<GoftinoMessageSendFromUserResponse>> SendMessageFromUserAsync(GoftinoMessageSendFromUserRequest request, CancellationToken cancellationToken = default)
        {
            return GetHttpHelper().PostAsync<GoftinoQueryResult<GoftinoMessageSendFromUserResponse>>("send_message_from_user", request, cancellationToken);
        }

        public Task<GoftinoCommandResult> OperatorTypingAsync(GoftinoChatTypeingRequest request, CancellationToken cancellationToken = default)
        {
            return GetHttpHelper().PostAsync<GoftinoCommandResult>("operator_typing", request, cancellationToken);
        }

        public Task<GoftinoCommandResult> CloseChatAsync(GoftinoChatCloseRequest request, CancellationToken cancellationToken = default)
        {
            return GetHttpHelper().PostAsync<GoftinoCommandResult>("close_chat", request, cancellationToken);
        }

        public Task<GoftinoCommandResult> TransferChatAsync(GoftinoChatTransferRequest request, CancellationToken cancellationToken = default)
        {
            return GetHttpHelper().PostAsync<GoftinoCommandResult>("transfer_chat", request, cancellationToken);
        }

        public Task<GoftinoCommandResult> UnAssignChatAsync(GoftinoChatUnAssignRequest request, CancellationToken cancellationToken = default)
        {
            return GetHttpHelper().PostAsync<GoftinoCommandResult>("unassign_chat", request, cancellationToken);
        }

        public Task<GoftinoQueryResult<GoftinoChatUnreadMessageResponse>> GetAllUnreadMessageAsync(GoftinoChatUnreadMessageRequest request, CancellationToken cancellationToken = default)
        {
            return GetHttpHelper().GetAsync<GoftinoQueryResult<GoftinoChatUnreadMessageResponse>>("user_unread_messages", request, cancellationToken);
        }

        public Task<GoftinoCommandResult> EditMessageAsync(GoftinoMessageEditRequest request, CancellationToken cancellationToken = default)
        {
            return GetHttpHelper().PostAsync<GoftinoCommandResult>("edit_message", request, cancellationToken);
        }

        public Task<GoftinoQueryResult<GoftinoMessageHistoryResponse>> GetMessageHistoryAsync(GoftinoMessageHistoryRequest request, CancellationToken cancellationToken = default)
        {
            return GetHttpHelper().GetAsync<GoftinoQueryResult<GoftinoMessageHistoryResponse>>("edit_message", request, cancellationToken);
        }

        public Task<GoftinoCommandResult> SendPollAsync(GoftinoPollSendRequest request, CancellationToken cancellationToken = default)
        {
            return GetHttpHelper().PostAsync<GoftinoCommandResult>("send_poll", request, cancellationToken);
        }

        public Task<GoftinoQueryResult<GoftinoChatCreateResponse>> CreateChatAsync(GoftinoChatCreateRequest request, CancellationToken cancellationToken = default)
        {
            return GetHttpHelper().PostAsync<GoftinoQueryResult<GoftinoChatCreateResponse>>("create_chat", request, cancellationToken);
        }

        public Task<GoftinoCommandResult> RemoveChatAsync(GoftinoChatRemoveRequest request, CancellationToken cancellationToken = default)
        {
            return GetHttpHelper().PostAsync<GoftinoCommandResult>("remove_chat", request, cancellationToken);
        }

        public Task<GoftinoQueryResult<GoftinoUserDto>> GetUserAsync(GoftinoUserGetRequest request, CancellationToken cancellationToken = default)
        {
            return GetHttpHelper().GetAsync<GoftinoQueryResult<GoftinoUserDto>>("user_data", request, cancellationToken);
        }

        public Task<GoftinoCommandResult> EditUserAsync(GoftinoUserEditRequest request, CancellationToken cancellationToken = default)
        {
            return GetHttpHelper().PostAsync<GoftinoCommandResult>("user_data", request, cancellationToken);
        }

        public Task<GoftinoCommandResult> BanUserAsync(GoftinoUserBanRequest request, CancellationToken cancellationToken = default)
        {
            return GetHttpHelper().PostAsync<GoftinoCommandResult>("ban_user", request, cancellationToken);
        }

        public Task<GoftinoQueryResult<GoftinoUserGetVisitedPageResponse>> GetUserVisitedPagesAsync(GoftinoUserGetVisitedPageRequest request, CancellationToken cancellationToken = default)
        {
            return GetHttpHelper().GetAsync<GoftinoQueryResult<GoftinoUserGetVisitedPageResponse>>("user_visited_pages", request, cancellationToken);
        }

        public Task<GoftinoQueryResult<GoftinoOperatorGetResponse>> GetAllOperatorAsync(CancellationToken cancellationToken = default)
        {
            return GetHttpHelper().GetAsync<GoftinoQueryResult<GoftinoOperatorGetResponse>>("operators", cancellationToken);
        }

        public Task<GoftinoQueryResult<GoftinoOperatorDto>> GetOperatorAsync(GoftinoOperatorGetRequest request, CancellationToken cancellationToken = default)
        {
            return GetHttpHelper().GetAsync<GoftinoQueryResult<GoftinoOperatorDto>>("operator_data", request, cancellationToken);
        }
    }
}