---
title: "removeAuthTokenProvider (Omnichannel for Customer Service JavaScript API reference) | MicrosoftDocs"
description: "Includes reference information such as syntax and parameters for the removeAuthTokenProvider method in Omnichannel for Customer Service JavaScript API reference. Also included is a sample code for using the method."
ms.date: 04/04/2022
ms.topic: reference
author: gandhamm
ms.author: mgandham
manager: shujoshi
---
# removeAuthTokenProvider

[!INCLUDE[cc-use-with-omnichannel](../../../../includes/cc-use-with-omnichannel.md)]

[!INCLUDE[removeAuthTokenProvider-description](../includes/removeAuthTokenProvider-description.md)]

> [!NOTE]
> The live chat SDK methods should be invoked after the [lcw:ready event](../events/lcw-ready.md) is raised. You can listen for this event by adding your own event listener on the window object.

This SDK is applicable only if authentication is enabled for the widget. To enable authentication for your widget, see [Create chat authentication settings](../../../create-chat-auth-settings.md).

## Syntax

`Microsoft.Omnichannel.LiveChatWidget.SDK.removeAuthTokenProvider();`

## Parameters

None

## Return value

None

## Example

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
    // Ideally, you call your service to convert the payload to a valid JSON Web Token
    return Promise.resolve("eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJzdWIiOiI4N2I0ZDA2Yy1hYmMyLWU4MTEtYTliMC0wMDBkM2ExMGUwOWUiLCJsd2ljb250ZXh0cyI6IntcIm1zZHluX2NhcnR2YWx1ZVwiOlwiMTAwMDBcIiwgXCJtc2R5bl9pc3ZpcFwiOlwiZmFsc2VcIn0iLCJpYXQiOjE1NDI2MjIwNzEsImlzcyI6ImNvbnRvc29oZWxwLmNvbSIsImV4cCI6MTU0MjYyNTY3MiwibmJmIjoxNTQyNjIyMDcyfQ.r37z1M5rMyRYMOJ-rhyTRYFOgvl9N7KvTMueSFPkiuM");
}

window.addEventListener("lcw:ready", function handleLivechatReadyEvent(){
// Sets the auth-token provider
// Throws error if authTokenProvider is not a function
    convertToJwtToken(payloadToEncrypt).then(function (jwtToken){
        Microsoft.Omnichannel.LiveChatWidget.SDK.setAuthTokenProvider(function authTokenProvider(callback){
            callback(jwtToken);
        });

        // Removes the currently set authentication token provider
        Microsoft.Omnichannel.LiveChatWidget.SDK.removeAuthTokenProvider();
    });
});
```

### See also

[JavaScript API reference for Live chat SDK](../../omnichannel-reference.md)


[!INCLUDE[footer-include](../../../../includes/footer-banner.md)]
