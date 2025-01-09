---
title: Code samples for parsing activity JSON
description: Learn how to parse the activity JSON object to retrieve the bot context for Azure or Copilot Studio bots.
ms.date: 07/21/2023
ms.topic: how-to
author: neeranelli
ms.author: nenellim
ms.reviewer: nenellim
ms.custom: bap-template
---
# Code samples for parsing activity JSON

[!INCLUDE[pva-rebrand](../../includes/cc-pva-rebrand.md)]

This article includes some samples for parsing the activity JSON object in various channels. The following sample code retrieves the context sent from Omnichannel for Customer Service so that it can be passed on to an Azure or Copilot Studio bot.

## Live Chat

```json
{
         "id":"1654211880034",
         "type":"event",
         "timestamp":1654211880,
         "from":{
            "id":"965ee9c9-a809-b56c-5498-b116ae3b9e16",
            "role":1
         },
         "name":"startConversation",
         "channelId":"lcw",
         "textFormat":"Text",
         "text":"{\"msdyn_inbox_threadids\":\"{\\\"t1ChatId\\\":\\\"19:Mmy0P4lmPkVqRSSf0btCLjr-mU2vzEpZ-B5fXoxoMq81@thread.v2\\\",\\\"t2ChatId\\\":\\\"19:_7UGOckTtmK5v9-ePY4HtVvOIG8kAGuNXOxtu7Z4TKQ1@thread.v2\\\",\\\"platformtype\\\":\\\"ACS\\\"}\",\"msdyn_msdyn_ocliveworkitem_msdyn_livechatengagementctx_liveworkitemid\":[{\"RecordId\":\"5d6dfef2-11b4-4eb7-a51f-c76b27279fc3\",\"PrimaryDisplayValue\":\"\"}],\"EventName\":\"startConversation\",\"msdyn_liveworkitemid\":\"5ba69c2c-40b5-4af2-bd76-a94c10bd4f43\"}",
         "attachments":[
         ],
         "value":{
            "msdyn_inbox_threadids":"{\"t1ChatId\":\"19:Mmy0P4lmPkVqRSSf0btCLjr-mU2vzEpZ-B5fXoxoMq81@thread.v2\",\"t2ChatId\":\"19:7UGOckTtmK5v9-ePY4HtVvOIG8kAGuNXOxtu7Z4TKQ1@thread.v2\",\"platformtype\":\"ACS\"}",
            "msdyn_msdyn_ocliveworkitem_msdyn_livechatengagementctx_liveworkitemid":[
               {
                  "RecordId":"5d6dfef2-11b4-4eb7-a51f-c76b27279fc3",
                  "PrimaryDisplayValue":""
               }
            ],
            "msdyn_liveworkitemid":"5ba69c2c-40b5-4af2-bd76-a94c10bd4f43"
         },
         "channeldata":{
            "Microsoft.azure.communication.chat.bot.contenttype":null,
            "tags":"ChannelId-lcw,OmnichannelContextMessage,Hidden",
            "sourceChannelId":"omnichannel"
         }
}
```

## Voice channel

```json
{
        "id":"7b5123f2-0562-4d04-b464-648d8f3ca887",
        "type":"conversationUpdate",
        "timestamp":1653669440,
        "from":{
            "id":"77adeae1-5d97-dabf-d9ce-a823f17c3bdb",
            "role":1
        },
        "channelId":"telephony",
        "attachments":[
        ],
        "replyToId":"b196ebf7-47a9-4f34-9d2e-63a73295255a",
        "channeldata":{
            "vnd.microsoft.msdyn.oc.data":{
               "voices":{
                  "en-US":{
                     "voiceName":"en-US-JennyNeural",
                     "voiceStyle":"assistant",
                     "pitch":0,
                     "speakingSpeed":0
                  }
               },
               "customerPhoneNumber":"+15092924729",
               "organizationPhoneNumber":"+18336321583",
               "msdyn_ocliveworkitemid":"9389a2a1-ec10-48da-a793-6c079568e47b"
            }
         }
}
```

## Apple Messages for Business channel

```json
{
         "id":"1654048788512",
         "type":"event",
         "timestamp":1654048788,
         "from":{
            "id":"965ee9c9-a809-b56c-5498-b116ae3b9e16",
            "role":1
         },
         "name":"startConversation",
         "channelId":"applemessagesforbusiness",
         "textFormat":"Text",
         "text":"{\"msdyn_inbox_threadids\":\"{\\\"t1ChatId\\\":\\\"\\\",\\\"t2ChatId\\\":\\\"19:kTDDWx7UQhjJ44eyDDQD5-SUWBIncL6ae_TXyWWPyz81@thread.v2\\\",\\\"platformtype\\\":\\\"ACS\\\"}\",\"msdyn_msdyn_ocliveworkitem_msdyn_ocapplemessagesforbusinessengagementctx_liveworkitemid\":[{\"RecordId\":\"e7b96ab8-914b-4563-a371-5fe73724f1a5\",\"PrimaryDisplayValue\":null}],\"msdyn_capabilitylist\":\"AUTH,LIST,TIME,FORM,QUICK\",\"msdyn_socialprofile_msdyn_ocliveworkitem_socialprofileid\":[{\"RecordId\":\"667a3856-b2a9-4a36-8627-b725e4698645\",\"PrimaryDisplayValue\":null}],\"EventName\":\"startConversation\",\"msdyn_liveworkitemid\":\"88b32c66-61f2-4c46-95ce-72a263113686\"}",
         "attachments":[
         ],
         "value":{
            "msdyn_inbox_threadids":"{\"t1ChatId\":\"\",\"t2ChatId\":\"19:kTDDWx7UQhjJ44eyDDQD5-SUWBIncL6ae_TXyWWPyz81@thread.v2\",\"platformtype\":\"ACS\"}",
            "msdyn_msdyn_ocliveworkitem_msdyn_ocapplemessagesforbusinessengagementctx_liveworkitemid":[
               {
                  "RecordId":"e7b96ab8-914b-4563-a371-5fe73724f1a5",
                  "PrimaryDisplayValue":null
               }
            ],
            "msdyn_capabilitylist":"AUTH,LIST,TIME,FORM,QUICK",
            "msdyn_socialprofile_msdyn_ocliveworkitem_socialprofileid":[
               {
                  "RecordId":"667a3856-b2a9-4a36-8627-b725e4698645",
                  "PrimaryDisplayValue":null
               }
            ],
            "msdyn_liveworkitemid":"88b32c66-61f2-4c46-95ce-72a263113686"
         },
         "channeldata":{
            "microsoft.azure.communication.chat.bot.contenttype":null,
            "tags":"ChannelId-applemessagesforbusiness,OmnichannelContextMessage,Hidden",
            "sourceChannelId":"omnichannel"
         }
}
```


### Related information

[Send custom context](../develop/send-context-starting-chat.md)  
[setContextProvider](../develop/reference/methods/setContextProvider.md)  
[Integrate an Azure bot](../administer/configure-bot-azure.md)  
[Integrate Copilot Studio bot](../administer/configure-bot-virtual-agent.md)  