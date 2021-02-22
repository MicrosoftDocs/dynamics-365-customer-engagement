---
title: "Omnichannel JavaScript API Reference | Microsoft Docs"
description: "Omnichannel JavaScript API Reference"
author: platkat
ms.author: ktaylor
manager: shujoshi
ms.date: 10/20/2020
ms.topic: reference
ms.service: dynamics-365-customerservice
ms.reviewer: nenellim
---
# Omnichannel JavaScript API Reference

[!INCLUDE[cc-use-with-omnichannel](../../includes/cc-use-with-omnichannel.md)]

The following JavaScript methods can be used to perform various operations with the Omnichannel for Customer Service SDK.

## Methods

| Method | Description |
|---------|-------------|
| [getConversationId](reference/methods/getConversationId.md) | This function can be called to fetch the unique GUID of the current ongoing conversation in a session. The conversation id stays the same post conversation close as well. This id can be used to fetch the conversation record programmatically. |
| [linkToConversation](reference/methods/linkToConversation.md) | This function can be used to link account, contact or incident records to the conversation in the focused session. This API will only link the records in the backend. The link is reflected once the page is refreshed. The caller is responsible for the UI refresh. Only one account or contact and one case can be linked to a conversation at a time. If a new customer or case record is linked, it will override the previous record link for the conversation. Omnichannel supports linking only to active conversations. |
| [unlinkFromConversation](reference/methods/unlinkFromConversation.md) | This function can be used to unlink an already linked entity record of type customer (account or contact) or case from a conversation. |



### See also

[Omnichannel for Customer Service for developers](omnichannel-developer.md)


[!INCLUDE[footer-include](../../includes/footer-banner.md)]