---
title: "getContextProvider (Omni-channel Engagement Hub JavaScript API reference) | MicrosoftDocs"
description: 
keywords: ""
author: susikka
ms.author: susikka
manager: shujoshi
applies_to: 
ms.date: 03/19/2019
ms.service: 
ms.topic: article
ms.assetid: 1C92A31B-70DF-4CE7-9C7A-BE398F34C6F6
ms.custom: 
---

# getContextProvider

Applies to Dynamics 365 for Customer Engagement apps version 9.1.0.

[!include[cc-beta-prerelease-disclaimer](../../../../includes/cc-beta-prerelease-disclaimer.md)]

[!INCLUDE[getContextProvider-description](../includes/getContextProvider-description.md)]

## Syntax

`Microsoft.Omnichannel.LiveChatWidget.SDK.getContextProvider();`

## Parameters

None

## Return Value

Should return the currently set custom context provider, if any.

<!--## Example

```JavaScript
window.addEventListener("lcw:ready", function handleLivechatReadyEvent(){
               // Gets the currently set context provider, if any.
               let contextProvider = Microsoft.Omnichannel.LiveChatWidget.SDK.getContextProvider();
});
```

-->

## See also

[JavaScript API reference for Live chat SDK](../../omni-channel-reference.md)