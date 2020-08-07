---
title: "getTranslationProvider (Omnichannel for Customer Service JavaScript API reference) | MicrosoftDocs"
description: 
author: susikka
ms.author: susikka
manager: shujoshi
ms.date: 08/07/2020
ms.topic: article
---
# Preview: getTranslationProvider

[!INCLUDE[cc-use-with-omnichannel](../../../../includes/cc-use-with-omnichannel.md)]

[!include[cc-beta-prerelease-disclaimer](../../../../includes/cc-beta-prerelease-disclaimer.md)]

Use this method to register your own functions corresponding to the methods [initializeNewConversation](initializeNewConversation.md) and [translateMessage](translateMessage.md).

## Example

```javascript
window.Microsoft.Omnichannel.TranslationFramework.getTranslationProvider = function(){       
    return {
                initializeNewConversation : C1WebResourceNamespace.initializeNewConversationInWebResource,
                translateMessage: C1WebResourceNamespace.translateMessageInWebResource
           }
    };
```
In the above example, `C1WebResourceNamespace.initializeNewConversationInWebResource` and `C1WebResourceNamespace.translateMessageInWebResource` are functions created by you in your web resource.

### See also

[translateMessage method](translateMessage.md)<br />
[initializeNewConversation method](initializeNewConversation.md)<br />
[Add a web resource for real time translation](../how-to/add-web-resource-real-time-translation.md)