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

You can use the following code as sample to pass an authentication token to an Azure or Power Virtual Agents bot during single sign-on (SSO).

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