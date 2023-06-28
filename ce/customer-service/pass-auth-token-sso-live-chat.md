---
title: "Pass authentication token to bot during single sign-on in live chat | Microsoft Docs"
description: "Use this article to understand how you can pass an authentication token to an Azure or Power Virtual Agents bot during single sign-on (SSO) in live chat."
ms.date: 11/02/2022
ms.topic: reference
author: gandhamm
ms.author: mgandham
ms.reviewer: nenellim
---

# Pass authentication token to bot during single sign-on in live chat

[!INCLUDE[cc-use-with-omnichannel](../includes/cc-use-with-omnichannel.md)]

With single sign-on (SSO) in Omnichannel for Customer Service, your bots can perform secure actions on behalf of the customer during an ongoing customer conversation.​ This provides a seamless, personalized, and secure experience for the customer, thereby improving customer satisfaction.

In the live chat channel, you can set up authentication in Azure or Power Virtual Agents bots. You can request authentication during a customer conversation before seeking or processing any confidential information such as bill payment, order returns, and any other sensitive data. As a bot author or developer, you can choose to show the OAuth card if the customer hasn't signed in or if the customer sign-in couldn't be validated. You can choose to hide the card if the customer has already signed in.

Here's how this works:

- During the live chat, your bot requests the customer for authentication before processing any sensitive or confidential information.
 
- You intercept the OAuth card and call your function to send the authentication token directly to the bot. 

- Your function will then pass an authentication token (if found) and tell Omnichannel for Customer Service whether the OAuth or sign-in card should be displayed or not, based on the customer's sign-in status.

## Prerequisites

If you're using Azure bots, ensure that you've installed the latest versions of the following two library packages:
- **Microsoft.Bot.Builder.Dialogs** This library implements the .NET Simple Dialog classes.
- **Microsoft.Bot.Builder.Integration.AspNet.Core** This library integrates the Bot Builder SDK with ASP.NET Core.

If you're using a Power Virtual Agents bot, ensure that you manually set up end user authentication for Power Virtual Agents. More information: [Configure manual user authentication](/power-virtual-agents/configuration-end-user-authentication#manual-for-any-channel-including-teams)

## Sample code

[!INCLUDE[setBotAuthTokenProvider-code-sample](developer/reference/includes/setBotAuthTokenProvider-code-sample.md)]

### See also

[Integrate an Azure bot](configure-bot-azure.md)  
[Integrate Power Virtual Agents bot](configure-bot-virtual-agent.md)  
[setBotAuthTokenProvider method](developer/reference/methods/setBotAuthTokenProvider.md)  

[!INCLUDE[footer-include](../includes/footer-banner.md)]
