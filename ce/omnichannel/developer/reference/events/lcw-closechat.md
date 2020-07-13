---
title: "lcw closeChat | MicrosoftDocs"
description: 
author: susikka
ms.author: susikka
manager: shujoshi
ms.topic: article
---
# lcw:closeChat (Omnichannel for Customer Service JavaScript API reference)

[!INCLUDE[cc-use-with-omnichannel](../../../../includes/cc-use-with-omnichannel.md)]

This event is triggered when a chat is closed.

## Example

```javascript
chatWebView.evaluateJavascript(
    "window.addEventListener(\"lcw:closeChat\",function handleCloseChatEvent(){postChatClosureSteps();})",
    null            
)
```
### See also

[lcw:ready](lcw-ready.md)<br />
[lcw:error](lcw-error.md)<br />
[JavaScript API reference for Live chat SDK](../../omnichannel-reference.md)