---
title: "setContextProvider (JavaScript API reference) for Omni-channel Engagement Hub in Dynamics 365 | MicrosoftDocs"
description: 
keywords: ""
author: susikka
ms.author: susikka
manager: shujoshi
applies_to: 
ms.date: 01/10/2019
ms.service: 
ms.topic: article
ms.assetid: 1C92A31B-70DF-4CE7-9C7A-BE398F34C6F6
ms.custom: 
---

# setContextProvider (Omni-channel Engagement Hub JavaScript API reference)

[!INCLUDE[setContextProvider-description](../includes/setContextProvider-description.md)]

> [!IMPORTANT]
> The context is a collection of key value pairs. Only primitive values are allowed for any key.

## Syntax

`setContextProvider(contextProvider);`

## Parameters

| Parameter | Type | Description |
| ---- | ---- | ---- |
| contextProvider | Function | Function which would act as context provider |

## Return Value

None

## Example

```JavaSript
window.addEventListener("lcw:ready", function handleLivechatReadyEvent(){
               // Set the context provider
               // Throws error if contextProvider is not a function
               Microsoft.Omnichannel.LiveChatWidget.SDK.setContextProvider(function contextProvider(){
                              return {
                                             'contextKey1': 'contextValue1', // string value
                                             'contextKey2': 12.34, // number value
                                             'contextKey3': true // boolean value
                              };
               });
});

```