---
title: "Send authentication token | Microsoft Docs"
description: ""
keywords: ""
ms.date: 03/19/2019
ms.service: dynamics-365-customerservice
ms.custom:
ms.topic: reference
applies_to:
ms.assetid: 51737308-BFD6-4C66-96D6-F11EDCB71E33
author: susikka
ms.author: susikka
manager: shujoshi

---
# Walkthrough: Send authentication token

Applies to Dynamics 365 for Customer Engagement apps version 9.1.0.

[!include[cc-beta-prerelease-disclaimer](../../../includes/cc-beta-prerelease-disclaimer.md)]

<!--note from editor:  Suggest changing the sentence 
"When a user initiates a chat, you can pass an authentication token to Omni-channel Engagement Hub, which helps in authenticating the user." 
to this:
"To authenticate a user when they initiate a chat, pass an authentication token to Omni-channel Engagement Hub." -->

When a user initiates a chat, you can pass an authentication token to Omni-channel Engagement Hub, which helps authenticate the user. Custom authentication is optional and is relevant only when hosting the chat widget outside Dynamics 365 for Customer Engagement Portal. It is used to send verified information about the current logged-in user. This information will be used to identify the account or contact entity record by Omni-channel Engagement Hub.

<!--note from editor:Should the below sentence say "Follow these steps to pass an authentication token:"?    -->


Follow these steps to send context when starting a chat:

<!--note from editor: In Step 1, are the "live chat SDK methods" the same thing as the methods under "JavaScript API Reference" in this developer guide? If so, make that connection clear.   -->


1. Listen to the **lcw:ready** event raised by a live chat before calling the live chat SDK methods. The live chat methods should be invoked only after the widget loads fully and the **lcw:ready** event is fired. You can listen for this event by adding your own event listener on the window object.
2. Once the **lcw:ready** event is raised, register an authentication token provider with live chat by using the [setAuthTokenProvider](../reference/methods/setAuthTokenProvider.md) method.

## Sample code

```JavaScript
function authTokenProvider(callback){
	// Calling the callback with a valid JWT token
	callback("eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJzdWIiOiIxMjM0NTY3ODkwIiwibmFtZSI6IkpvaG4gRG9lIiwiaWF0IjoxNTE2MjM5MDIyfQ.SflKxwRJSMeKKF2QT4fwpMeJf36POk6yJV_adQssw5c");
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

> [!div class="nextstepaction"]
> [Next topic: Initiate chat when user has been waiting](initiate-chat-wait-time.md)

### See also

[JavaScript API reference](../omni-channel-reference.md)<br />
[Manage custom context](send-context-starting-chat.md)
