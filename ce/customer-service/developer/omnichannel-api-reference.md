---
title: "Omnichannel JavaScript API Reference | Microsoft Docs"
description: "Omnichannel JavaScript API Reference"
ms.date: 02/18/2022
ms.topic: reference
author: mh-jaya
ms.author: v-jmh
manager: shujoshi
ms.reviewer: nenellim
---
# Omnichannel JavaScript API Reference

[!INCLUDE[cc-use-with-omnichannel](../../includes/cc-use-with-omnichannel.md)]

The following JavaScript methods can be used to perform various operations with the Omnichannel for Customer Service SDK.

## Methods

| Method | Description |
|---------|-------------|
| [getConversationId](reference/methods/getConversationId.md) | This function can be called to fetch the unique GUID of the current ongoing conversation in a session.  |
| [linkToConversation](reference/methods/linkToConversation.md) | This function can be used to link account, contact, or incident records to the conversation in the focused session. |
| [unlinkFromConversation](reference/methods/unlinkFromConversation.md) | This function can be used to unlink an already linked entity record of type customer (account or contact) or case from a conversation. |
| [getConversations](reference/methods/getConversations.md) |This function can be used to fetch a list of conversation (`msdyn_ocliveworkitem`) records for an agent.  |
| [openConversation](reference/methods/openConversation.md) | This function can be used to open a conversation as a session programmatically.  |

### See also

[Omnichannel for Customer Service for developers](omnichannel-developer.md)  
[JavaScript API reference for live chat SDK](../../omnichannel-reference.md)  

[!INCLUDE[footer-include](../../includes/footer-banner.md)]
