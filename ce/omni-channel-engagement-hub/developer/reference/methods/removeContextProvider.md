---
title: "removeContextProvider (JavaScript API reference) for Omni-channel Engagement Hub in Dynamics 365 | MicrosoftDocs"
description: 
keywords: ""
author: susikka
ms.author: susikka
manager: shujoshi
applies_to: 
ms.date: 01/10/2019
ms.service: 
ms.topic: article
ms.assetid: C1EBAEC6-42D4-4D8F-9FFC-89DA2AD50B2B
ms.custom: 
---

# removeContextProvider (Omni-channel Engagement Hub JavaScript API reference)

[!INCLUDE[removeContextProvider-description](../includes/removeContextProvider-description.md)]

## Syntax

`removeContextProvider();`

## Parameters

None

## Return Value

None

## Example

```JavaScript
window.addEventListener("lcw:ready", function handleLivechatReadyEvent(){
               // Removes the currently set context provider if any
               Microsoft.Omnichannel.LiveChatWidget.SDK.removeContextProvider();
});

```