---
title: "Pass authentication token to bot during single sign-on | Microsoft Docs"
description: "Use this article to understand how you can pass an authentication token to an Azure or Power Virtual Agents bot during single sign-on (SSO)."
ms.date: 10/01/2022
ms.topic: reference
author: mh-jaya
ms.author: v-jmh
manager: shujoshi
ms.reviewer: nenellim
---

# Pass authentication token to bot during single sign-on

[!INCLUDE[cc-use-with-omnichannel](../includes/cc-use-with-omnichannel.md)]

Using the single sign-on (SSO) feature in Omnichannel for Customer Service, your bots can perform secure actions on behalf of the customer via  an authentication token that you provide, during an ongoing customer conversation.​ This provides a seamless, personalized, and secure experience between your customers and the bot, thereby improving customer satisfaction and reducing costs.​

For example, as a bot author, you can set up authentication in Azure or Power Virtual Agents bots. You can pass an authentication token in the middle of a customer conversation for account information such bills, order returns, or other sensitive data.

Here's how this works:

- Your bot sends an OAuth card when it asks for a sign in.​

- Omnichannel for Customer Service will intercept this OAuth card, and call your function.​

- Your function will then pass a token (if found) and tell Omnichannel for Customer Service whether the OAuth or sign-in card should be shown. 

## Prerequisites

If you're using Azure bots, ensure you're using Bot Framework SDK 1.1.1.0 or higher.

If you're using a Power Virtual Agent bot, ensure that you've set up end user authentication for Power Virtual Agents. More information: [Configure user authentication](/power-virtual-agents/configuration-end-user-authentication)

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
      // Other condition handlings
    }
   
    // Show sign in card by default
    callback({
         show: true
    });
});
```