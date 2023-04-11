---
title: "getTranslationProvider (Omnichannel for Customer Service JavaScript property reference) | MicrosoftDocs"
description: "Includes reference information about getTranslationProvider property in Omnichannel JavaScript API reference."
ms.date: 04/04/2022
ms.topic: reference
author: gandhamm
ms.author: mgandham
---

# getTranslationProvider

[!INCLUDE[cc-use-with-omnichannel](../../../../includes/cc-use-with-omnichannel.md)]

This property is required to be set in web resource. It is called once, after the agent has logged in to Omnichannel for Customer Service. It helps Omnichannel for Customer Service to know the functions to be called for initializing a conversation and translating a message.

> [!IMPORTANT]
> See this [sample web resource](https://github.com/microsoft/Dynamics365-Apps-Samples/blob/06e9c84263bac81e7411f95365c5e792aca15122/customer-service/omnichannel/real-time-translation/webResourceV2.js#L452) for more information on how to set the `getTranslationProvider` property.

## Syntax

`window.Microsoft.Omnichannel.TranslationFramework.getTranslationProvider`

## Type of object to be assigned

A function is required to be assigned to the property. The function should have no input parameters and should return a JavaScript object implementing following interface:

```json
interface { 
        initializeNewConversation: function,  // Required field, Function to be called to initialize a conversation
        translateMessage: function;      // Required field, Function to be called to translate a message
}
```

The `initializeNewConversation` parameter in above interface represents a function which will be called to initialize a conversation. More information: [initializeNewConversation](/dynamics365/customer-service/developer/reference/methods/initializeNewConversation)

The `translateMessage` parameter in above interface represents a function which will be called to translate a message. More information: [translateMessage](/dynamics365/customer-service/developer/reference/methods/translateMessage).

A sample of setting the `getTranslationProvider` property is as follows.

```json
/* 
The following code has been copied from the link: 
https://github.com/microsoft/Dynamics365-Apps-Samples/blob/06e9c84263bac81e7411f95365c5e792aca15122/customer-service/omnichannel/real-time-translation/webResourceV2.js#L452

Read and understand the following code in the context of the javacript file that is mentioned in the preceding line. 
*/
window.Microsoft.Omnichannel.TranslationFramework.getTranslationProvider = function () {
	return {
		initializeNewConversation: C1WebResourceNamespace.initializeNewConversationInWebResource,
		translateMessage: C1WebResourceNamespace.translateMessageInWebResource
	}
};
```

> [!Note]
>
> - On exception in the assigned function or invalid return values from the assigned function, Omnichannel for Customer Service will keep translation off for the conversation and might behave abnormally.
> - If this property is not set, the following error will be displayed to the agent.
> ![initializeNewConversation error message.](../../../media/initializeconversation-api-error.png "initializeNewConversation error message")

### See also

[Add a web resource for real-time translation](../../../add-web-resource-real-time-translation.md)  


[!INCLUDE[footer-include](../../../../includes/footer-banner.md)]
