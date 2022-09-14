---
title: "Pass authentication token to bot during single sign-on in live chat | Microsoft Docs"
description: "Use this article to understand how you can pass an authentication token to an Azure or Power Virtual Agents bot during single sign-on (SSO) in live chat."
ms.date: 10/01/2022
ms.topic: reference
author: mh-jaya
ms.author: v-jmh
manager: shujoshi
ms.reviewer: nenellim
---

# Pass authentication token to bot during single sign-on in live chat

[!INCLUDE[cc-use-with-omnichannel](../includes/cc-use-with-omnichannel.md)]

Using the single sign-on (SSO) feature in Omnichannel for Customer Service, your bots can perform secure actions on behalf of the customer via  an authentication token that you provide, during an ongoing customer conversation.​ This provides a seamless, personalized, and secure experience between your customers and the bot, thereby improving customer satisfaction and reducing costs.​

For example, as a bot author, you can set up authentication in Azure or Power Virtual Agents bots. You can pass an authentication token in the middle of a customer conversation before you request for account information such bills, order returns, and any other sensitive data.

Here's how this works:

- Your bot sends an OAuth card when it asks for a sign in.​

- Omnichannel for Customer Service will intercept this OAuth card, and call your function.​

- Your function will then pass a token (if found) and tell Omnichannel for Customer Service whether the OAuth or sign-in card should be displayed. 

## Prerequisites

If you're using Azure bots, ensure that you're using Bot Framework SDK v4.14 or higher. More information: [Bot Framework SDK](/azure/bot-service/bot-service-overview?view=azure-bot-service-4.0)

If you're using a Power Virtual Agents bot, ensure that you manually set up end user authentication for Power Virtual Agents. More information: [Configure manual user authentication](/power-virtual-agents/configuration-end-user-authentication#manual-for-any-channel-including-teams)

## Sample code

Here's a code sample that illustrates how you can pass an authentication token to an Azure or Power Virtual Agents bot during single sign-on.

```JavaScript
Microsoft.Omnichannel.LiveChatWidget.SDK.setBotAuthTokenProvider(async (botTokenUrl, callback) => {
    const authUrl = ""; // Customer's Authentication API
    const authResponse = await fetch(authUrl, {method: "POST"});
    const { token } = authResponse;  // Customer's Auth Token
 
    const payload = {
       method: "POST",
       headers: {
         "Content-Type": "application/json"
       },
       token: token
    }
 
    const botAuthResponse = await fetch(botTokenUrl, payload); // Posts Auth Token to Bot directly
   
    // Sign in through Bot is successful
    if (botAuthResponse.status === 200) {
        // Hide sign in card
        callback({
           show: false
        });
    } else {
      // Other condition handling
    }
   
    // Show sign in card by default
    callback({
         show: true
    });
});
```

### See also

[Integrate an Azure bot](configure-bot-azure.md)  
[Integrate Power Virtual Agents bot](configure-bot-virtual-agent.md)  