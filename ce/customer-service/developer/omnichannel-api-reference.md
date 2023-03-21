---
title: "Omnichannel JavaScript API Reference | MicrosoftDocs"
description: "Get an overview of the JavaScript API methods that can be used to perform various operations with the Omnichannel for Customer Service SDK."
ms.date: 05/24/2022
ms.topic: reference
author: gandhamm
ms.author: mgandham
manager: shujoshi
ms.reviewer: nenellim
---
# Omnichannel JavaScript API Reference

[!INCLUDE[cc-use-with-omnichannel](../../includes/cc-use-with-omnichannel.md)]

The following JavaScript methods can be used to perform various operations with the Omnichannel for Customer Service SDK.

## Methods

| Method | Description |
|---------|-------------|
| [getConversationId](reference/methods/getConversationId.md) | Gets the unique GUID of the current ongoing conversation in a session.  |
| [getConversations](reference/methods/getConversations.md) | Gets a list of conversation (`msdyn_ocliveworkitem`) records for an agent.  |
| [openConversation](reference/methods/openConversation.md) | Opens a conversation as a session programmatically.  |
| [linkToConversation](reference/methods/linkToConversation.md) | Links the account, contact, or incident records to the conversation in the focused session. |
| [unlinkFromConversation](reference/methods/unlinkFromConversation.md) | Unlinks an already linked entity record of type customer (account or contact) or case from a conversation. |
| [sendMessageToConversation](reference/methods/sendMessageToConversation.md)   | Sends messages to a conversation programmatically.   |

### See also

[Omnichannel for Customer Service for developers](omnichannel-developer.md)  
[Live chat SDK reference](omnichannel-reference.md)  

[!INCLUDE[footer-include](../../includes/footer-banner.md)]
