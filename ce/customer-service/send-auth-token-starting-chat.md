---
title: "Send authentication token | MicrosoftDocs"
description: "Understand how to pass authentication token to Omnichannel for Customer Service. Also included is a code snippet to send an authentication token to start a chat."
ms.date: 12/03/2020
ms.topic: reference
author: neeranelli
ms.author: nenellim
---
# Send authentication token

[!INCLUDE[cc-use-with-omnichannel](../includes/cc-use-with-omnichannel.md)]

To authenticate a customer when they start a chat, pass an authentication token to Omnichannel for Customer Service. This token is used to validate a signed-in customer from a domain, and to extract information based on the context variables that are defined. Custom authentication is optional and is relevant only when the chat widget is hosted outside Power Apps portals.

> [!IMPORTANT]
> - In the payload of the JSON Web Token (JWT), the value provided for the `lwicontexts` key should be the serialized custom context.
> - The custom context is a collection of key/value pairs. Only primitive values are allowed for any key.
> - The keys of custom context must correspond to context variables that are created for the associated workstream in Omnichannel for Customer Service.
> - The authentication token provider would be invoked by live chat widget when starting a new chat.

The SDKs related to authentication token provider are applicable only if authentication is enabled for the widget. To enable authentication for your widget, see [Create chat authentication settings](create-chat-auth-settings.md).

Follow these steps to send an authentication token when you start a chat:

1. Generate a valid JWT from the JSON payload. More information: [setAuthTokenProvider](developer/reference/methods/setAuthTokenProvider.md)

2. The live chat methods should be invoked after the [lcw:ready event](developer/reference/events/lcw-ready.md) is raised. You can listen for this event by adding your own event listener on the window object.

3. After the `lcw:ready` event is raised, register an authentication token provider with live chat by using the [setAuthTokenProvider](developer/reference/methods/setAuthTokenProvider.md) method.
    > [!NOTE]
    > 
    > To avoid timeout, the [authTokenProvider](developer/reference/methods/setAuthTokenProvider.md#parameters) function in the [setAuthTokenProvider](developer/reference/methods/setAuthTokenProvider.md) method must respond within 10 seconds.

4. Use the [startChat](developer/reference/methods/startChat.md) method to start the chat.

## Sample code

```JavaScript
let payloadToEncrypt = {
    "sub" : "87b4d06c-abc2-e811-a9b0-000d3a10e09e",
    "lwicontexts" :"{\"msdyn_cartvalue\":\"10000\", \"msdyn_isvip\":\"false\"}",
    "iat" : 1542622071,
    "iss" : "contosohelp.com",
    "exp" : 1542625672,
    "nbf" : 1542622072
};

function convertToJwtToken(payloadToEncrypt){
  // Ideally, you should call your service to convert the payload to a valid JWT token
  return Promise.resolve("eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJzdWIiOiI4N2I0ZDA2Yy1hYmMyLWU4MTEtYTliMC0wMDBkM2ExMGUwOWUiLCJsd2ljb250ZXh0cyI6IntcIm1zZHluX2NhcnR2YWx1ZVwiOlwiMTAwMDBcIiwgXCJtc2R5bl9pc3ZpcFwiOlwiZmFsc2VcIn0iLCJpYXQiOjE1NDI2MjIwNzEsImlzcyI6ImNvbnRvc29oZWxwLmNvbSIsImV4cCI6MTU0MjYyNTY3MiwibmJmIjoxNTQyNjIyMDcyfQ.r37z1M5rMyRYMOJ-rhyTRYFOgvl9N7KvTMueSFPkiuM");
}

function authTokenProvider(callback){
    convertToJwtToken(payloadToEncrypt).then(function (jwtToken){
    // Calling the callback with the valid JWT token
   callback(jwtToken);
   });
}

window.addEventListener("lcw:ready", function handleLivechatReadyEvent(){
    // Handle live chat ready event
    // Can use the SDK methods now
    // Setting authentication token provider to be used for the chat
    Microsoft.Omnichannel.LiveChatWidget.SDK.setAuthTokenProvider(authTokenProvider);

   // Starting a new chat
   Microsoft.Omnichannel.LiveChatWidget.SDK.startChat();
});

window.addEventListener("lcw:error", function handleLivechatErrorEvent(errorEvent){
  // Handle livechat error event
   console.log(errorEvent);
});
```

### See also

[setAuthTokenProvider](developer/reference/methods/setAuthTokenProvider.md)<br />
[getAuthTokenProvider](developer/reference/methods/getAuthTokenProvider.md)<br />
[removeAuthTokenProvider](developer/reference/methods/removeAuthTokenProvider.md)<br />
[Live chat SDK JavaScript API reference](developer/omnichannel-reference.md)<br />
[Send custom context](send-context-starting-chat.md)

[!INCLUDE[footer-include](../includes/footer-banner.md)]
