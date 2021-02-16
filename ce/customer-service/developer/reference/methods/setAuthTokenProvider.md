---
title: "setAuthTokenProvider (Omnichannel for Customer Service JavaScript API reference) | MicrosoftDocs"
description: 
author: v-sailab
ms.author: v-sailab
manager: shujoshi
ms.date: 07/01/2019
ms.topic: article
---
# setAuthTokenProvider

[!INCLUDE[cc-use-with-omnichannel](../../../../includes/cc-use-with-omnichannel.md)]

[!INCLUDE[setAuthTokenProvider-description](../includes/setAuthTokenProvider-description.md)]

The authentication token provider function, when called with a callback function as a parameter, invokes the callback function with a valid JSON Web Token (JWT) string as the argument.<br />This method raises an error if the value of the `authTokenProvider` parameter is not a function.

> [!IMPORTANT]
> In the payload of the JWT token, the value provided for `lwicontexts` key should be the serialized custom context.<br />
> The custom context is a collection of key/value pairs. Only primitive values are allowed for any key.<br />
> The keys of custom context must correspond to context variables that are created for the associated work stream in Omnichannel for Customer Service.<br />
> The authentication token provider would be invoked by live chat widget when starting a new chat.

> [!NOTE]
> Listen to the **lcw:ready** event raised by a live chat before calling the live chat SDK methods. The live chat methods should be invoked after the **lcw:ready** event is raised. You can listen for this event by adding your own event listener on the window object.

This SDK is applicable only if authentication is enabled for the widget. To enable authentication for your widget, see [Create chat authentication settings](../../../create-chat-auth-settings.md).

## Syntax

`Microsoft.Omnichannel.LiveChatWidget.SDK.setAuthTokenProvider(authTokenProvider);`

## Parameters

| Parameter | Type | Description |
| ---- | ---- | ---- |
| authTokenProvider | Function | Function which when invoked with a callback function as an argument, fetches the JWT token and invokes the callback function with the JWT token as its argument  |

## Return Value

None

## Example

### Sample token payload

```json
{
    "sub" : "87b4d06c-abc2-e811-a9b0-000d3a10e09e",
    "lwicontexts" :"{\"msdyn_cartvalue\":\"10000\", \"msdyn_isvip\":\"false\"}",
    "iat" : 1542622071,
    "iss" : "contosohelp.com",
    "exp" : 1542625672,
    "nbf" : 1542622072
}
```
> [!NOTE]
> In the above payload, the value corresponding to `lwicontexts` key should be the serialized custom context.
> The keys `msdyn_cartvalue` and `msdyn_isvip` in the serialized custom context correspond to context variables that are created for the associated work stream in Omnichannel for Customer Service.

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
    // Ideally, you call your service to convert the payload to a valid JWT token
    return Promise.resolve("eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJzdWIiOiI4N2I0ZDA2Yy1hYmMyLWU4MTEtYTliMC0wMDBkM2ExMGUwOWUiLCJsd2ljb250ZXh0cyI6IntcIm1zZHluX2NhcnR2YWx1ZVwiOlwiMTAwMDBcIiwgXCJtc2R5bl9pc3ZpcFwiOlwiZmFsc2VcIn0iLCJpYXQiOjE1NDI2MjIwNzEsImlzcyI6ImNvbnRvc29oZWxwLmNvbSIsImV4cCI6MTU0MjYyNTY3MiwibmJmIjoxNTQyNjIyMDcyfQ.r37z1M5rMyRYMOJ-rhyTRYFOgvl9N7KvTMueSFPkiuM");
}

window.addEventListener("lcw:ready", function handleLivechatReadyEvent(){
// Sets the auth-token provider
// Throws error if authTokenProvider is not a function
    convertToJwtToken(payloadToEncrypt).then(function (jwtToken){
        Microsoft.Omnichannel.LiveChatWidget.SDK.setAuthTokenProvider(function authTokenProvider(callback){
            callback(jwtToken);
        });
    });
});
```
## Error codes

The following error codes can occur with this method.

|Error Code|Error message|
|-----|-----|
|2|Auth token provider method execution failed|
|3|Auth token provider didn't provide any token|
|4|Auth token provider provided invalid token|

## See also

[JavaScript API reference for live chat SDK](../../omnichannel-reference.md)


[!INCLUDE[footer-include](../../../../includes/footer-banner.md)]