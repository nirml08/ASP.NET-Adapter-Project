using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace adapter.Model.classmodel
{
    public class ChatModules
    {
    }
    public class chatmessage
    {
        public string MESSAGE_ID { get; set; }
        public string SENDER_ID { get; set; }
        public string RECEIVER_ID { get; set; }
        public string TEXT_MESSAGE { get; set; }
        public string SEND_DATE { get; set; }
        public string ATTACHMENTS { get; set; }
        public string DELIVERED_DATE { get; set; }
        public string READ_DATE { get; set; }
        public string IS_ACTIVE { get; set; }
        public string IS_DELETED { get; set; }
        public string IS_READ { get; set; }
        public string REPLY_ID { get; set; }
        public string MESSAGE_UID { get; set; }

        public string CREATE_DATE { get; set; }
        public string MESSAGE_TYPE { get; set; }
        public string ATTACHMENT_URL { get; set; }
        public string STATUS { get; set; }
        public string GROUP_CHAT_ID { get; set; }
        public string ENCRYPTION_ALGORITHM { get; set; }
        public string ENCRYPTION_KEY { get; set; }
        public string EXPIRATION_TIME { get; set; }
        public string IS_EDITED { get; set; }
        public string DELETION_DATE { get; set; }
        public string LOCALID { get; set; }
        public string IS_DELIVERED { get; set; }

    }
    public class UsersViewModel
    {
        public string USER_ID { get; set; }
        public string USER_NAME { get; set; }
        public string MAIL_ID { get; set; }
        public string PASSWORDHASH { get; set; }

        public string PHOTO_PATH { get; set; }
        public string IS_ACTIVE { get; set; }
        public string CREATEDAT { get; set; }
        public string UPDATEDAT { get; set; }
        public string RECENTTEXT { get; set; }
        public string RECENTTEXTTIME { get; set; }
        public string MESSAGE_ID { get; set; }
        public string TEXTMESSAGE { get; set; }
        public string ATTACHMENTS { get; set; }
        public string SEND_DATE { get; set; }
        public string? DELIVERY_DATE { get; set; }
        public string? READ_DATE { get; set; }
        public string? ISREAD { get; set; }
        public string? IS_DELIVERED { get; set; }
        public string? REPLY_ID { get; set; }

        public string DATE { get; set; }
        public string SENDER_ID { get; set; }
        public string RECEIVER_ID { get; set; }
        public string LOCALID { get; set; }
        public string IS_EDITED { get; set; }

        public string CHATUID { get; set; }
        public string CHATNAME { get; set; }
        public string LASTSEEN { get; set; }
        public string STATUS { get; set; }
        public string ISAVAILABLE { get; set; }
        public string CREATED_DATE { get; set; }
        public string GROUP_ID { get; set; }
        public string MESSAGE_UID { get; set; }
        public MessageData recentMessage { get; set; }
    }
    public class Users
    {
        public string USER_ID { get; set; }
        public string USER_NAME { get; set; }
        public string MAIL_ID { get; set; }
        public string PHOTO_PATH { get; set; }
        public string IS_ACTIVE { get; set; }
        public string RECENTTEXT { get; set; }
        public string RECENTTEXTTIME { get; set; }
        public string ISREAD { get; set; }
        public ReturnMessageData recentMessage { get; set; }
        public string IS_EDITED { get; set; }
        public string LAST_SEEN { get; set; }
        public string STATUS { get; set; }
        public string ISAVAILABLE { get; set; }
        public string CHATUID { get; set; }
        public string GROUPNAME { get; set; }
        public string LOCALID { get; set; }
        public string LASTSEEN { get; set; }
        public string GROUP_ID { get; set; }

    }
    public class ReturnMessageData
    {
        public string MESSAGE_ID { get; set; }
        public string TEXTMESSAGE { get; set; }
        public List<Attachment> ATTACHMENTS { get; set; }
        public string SEND_DATE { get; set; }
        public string? DELIVERY_DATE { get; set; }
        public string? ISREAD { get; set; }
        public string? REPLY_ID { get; set; }
        public string SENDER_ID { get; set; }
        public string RECEIVER_ID { get; set; }
        public string USER_NAME { get; set; }
        public string LOCALID { get; set; }
        public string LASTSEEN { get; set; }
        public string STATUS { get; set; }
        public string ISAVAILABLE { get; set; }

    }
    public class LoadMessageModel
    {
        public string MESSAGE_ID { get; set; }
        public string TEXT_MESSAGE { get; set; }
        public string ATTACHMENTS { get; set; }
        public string SEND_DATE { get; set; }
        public string DELIVERY_DATE { get; set; }
        public string READ_DATE { get; set; }
        public string ISREAD { get; set; }
        public string IS_DELIVERED { get; set; }
        public string REPLY_ID { get; set; }
        public string MESSAGE_UID { get; set; }
        public string IS_ACTIVE { get; set; }
        public string IS_DELETED { get; set; }
        public string SENDER_ID { get; set; }
        public string RECEIVER_ID { get; set; }
        public string DATE { get; set; }
        public string LOCALID { get; set; }
        public string USER_NAME { get; set; }
        public string IS_EDITED { get; set; }
    }

    public class attachment
    {
        public string ACTUAL_FILE_NAME { get; set; }
        public string BUCKET_FILE_NAME { get; set; }
    }
    public class ReceiveMessageData
    {
        public string DATE { get; set; }

        public List<MessageData> DATA { get; set; }
    }
    public class MessageData
    {
        public string MESSAGE_UID { get; set; }
        public string TEXTMESSAGE { get; set; }
        public List<Attachment> ATTACHMENTS { get; set; }
        public string SEND_DATE { get; set; }
        public string? DELIVERY_DATE { get; set; }
        public string? READ_DATE { get; set; }
        public string? ISREAD { get; set; }
        public string? IS_DELIVERED { get; set; }
        public string? REPLY_ID { get; set; }
        public MessageData replyMessage { get; set; }
        public string DATE { get; set; }
        public string SENDER_ID { get; set; }
        public string RECEIVER_ID { get; set; }
        public string LOCALID { get; set; }
        public string USER_NAME { get; set; }
        public string IS_EDITED { get; set; }
    }
    public class SendMessage
    {
        public string TEXTMESSAGE { get; set; }
        public List<Attachment> ATTACHMENTS { get; set; }
        public string REPLY_ID { get; set; }
        public string MESSAGE_UID { get; set; }
        public string LOCALID { get; set; }

    }
    public class ReceiveMessageModel
    {
        public List<ReceiveMessageData> data { get; set; }
    }
    public class GroupInfo
    {
        public string GROUP_ID { get; set; }
        public string GROUP_NAME { get; set; }
        public string GROUP_ICON { get; set; }
        public string CREATED_DATE { get; set; }
        public string CREATED_BY { get; set; }
        public string CAMPUS_ID { get; set; }
        public string IS_ACTIVE { get; set; }
        public string IS_DELETED { get; set; }
    }
    public class GroupMembersInfo
    {
        public string GRP_MENMBER_ID { get; set; }
        public string GROUP_ID { get; set; }
        public string USER_ID { get; set; }
        public string EMAIL_ID { get; set; }
        public string ADDED_BY { get; set; }
        public string ADDED_DATE { get; set; }
        public string CAMPUS_ID { get; set; }
        public string IS_ACTIVE { get; set; }
        public string IS_LEFT { get; set; }
        public string IS_DELETED { get; set; }
    }
    public class SaveorUpdateGroupandMemberInfo
    {
        public string GROUP_ID { get; set; }
        public string GROUP_NAME { get; set; }
        public string GROUP_ICON { get; set; }
        public string CREATED_DATE { get; set; }
        public string CREATED_BY { get; set; }
        public string CAMPUS_ID { get; set; }
        public List<GroupMembersInfo> Members { get; set; }
    }
}
