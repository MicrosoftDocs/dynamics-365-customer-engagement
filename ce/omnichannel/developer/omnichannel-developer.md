---
title: "Omnichannel for Customer Service for developers | MicrosoftDocs"
description: "Developer guide for Omnichannel for Customer Service provides developers the information they need to get started with using the extensibility features"
author: susikka
ms.author: susikka
manager: shujoshi
ms.date: 04/06/2020
ms.service: 
  - "dynamics-365-customerservice"
ms.topic: article
---
# Omnichannel for Customer Service for developers

[!INCLUDE[cc-use-with-omnichannel](../../includes/cc-use-with-omnichannel.md)]

<table>
<tr>
<td>
<h3> Live chat widget SDK </h3>

Omnichannel for Customer Service live chat widget SDK provides methods that allow you to:
- Set, retrieve, and remove custom context provider for a live chat session.
- Open an existing chat or initiate a new one.
- Set, retrieve, and remove authentication-token providers for a live chat session.

[Initiate a chat](how-to/initiate-chat-wait-time.md)<br />
[JavaScript API reference for live chat SDK](omnichannel-reference.md)

</td>
<td>

<h3> Start proactive chat </h3>

Anticipating areas where customers need help and then engaging them through chat when they have been browsing your website for some time helps improve customer experience. Omnichannel for Customer Service allows you to offer proactive chat request to your customers when you think they can use some help.

[Start chat proactively](how-to/start-proactive-chat.md)

</td>
</tr>
<tr>
<td>

<h3> Manage custom context </h3>

When a customer initiates a chat, you can pass custom context to Omnichannel for Customer Service.

[Manage custom context](how-to/send-context-starting-chat.md)

</td>
<td>

<h3> Display custom context </h3>

Learn how you can display the context variables in the Conversation Summary Control for a conversation on the UI.

[Display custom context](how-to/display-custom-context.md)

</td>
</tr>
<tr>
<td>

<h3> Send authentication token </h3>

Learn how you can pass an authentication token to Omnichannel for Customer Service to authenticate a customer when they initiate a chat.

[Send authentication token](how-to/send-auth-token-starting-chat.md)

</td>
<td>

<h3> Enable a bot to escalate and end conversation </h3>

Omnichannel for Customer Service allows you to route a conversation to a human agent when you think human intervention is required to successfully help the customer.

[Enable a bot to escalate and end conversation](bot-escalate-end-conversation.md)<br />

</td>
</tr>
<tr>
<td>

<h3> Auto-close a conversation </h3>

Learn how you can automatically close a conversation using Web API.

[Auto-close a conversation](auto-close-conversation.md)

</td>
<td>

<h3> runMacro API </h3>

`runMacro` API allows you to execute a macro whose name was passed as a parameter in the API call.

[runMacro method](reference/methods/runMacro.md)

</td>
</tr>
<tr>
<td>
<h3>Build a smart assist bot</h3>

Read how you can build a smart assist bot to help agents resolve customer queries faster and more effectively.

[Build a smart assist bot](how-to/smart-assist-bot.md)

</td>
<td>

<h3>Bring your own channel</h3>

Read how you can implement a connector to integrate custom messaging channels using Direct Line Bot.

[Bring your own channel](how-to/bring-your-own-channel.md)

</td>
</tr>
</table>

### See also

[Introduction to Omnichannel for Customer Service](../introduction-omnichannel.md)<br />
[Omnichannel for Customer Service for administrators](../administrator/omnichannel-administrator.md)<br />
[Omnichannel for Customer Service for system customizers](../customizer/omnichannel-customizer.md)<br />
[Omnichannel for Customer Service for agents](../agent/omnichannel-agent-overview.md)<br />
[Dynamics 365 Channel Integration Framework guide](../../customer-service/channel-integration-framework/channel-integration-framework.md)