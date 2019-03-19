---
title: "setContextProvider (Omni-channel Engagement Hub JavaScript API reference) | MicrosoftDocs"
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
# setContextProvider

Applies to Dynamics 365 for Customer Engagement apps version 9.1.0.

[!include[cc-beta-prerelease-disclaimer](../../../../includes/cc-beta-prerelease-disclaimer.md)]

[!INCLUDE[setContextProvider-description](../includes/setContextProvider-description.md)]

> [!IMPORTANT]
> The custom context is a collection of key/value pairs. Only primitive values are allowed for any key.

## Syntax

`Microsoft.Omnichannel.LiveChatWidget.SDK.setContextProvider(contextProvider);`

## Parameters

| Parameter | Type | Description |
| ---- | ---- | ---- |
| contextProvider | Function | Function that acts as a custom context provider |

## Return Value

None

## Example

```JavaScript
window.addEventListener("lcw:ready", function handleLivechatReadyEvent(){
               // Set the custom context provider
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

## Error codes

The following error codes can occur with this method.

|Error Code|Error message|
|-----|-----|
|1|Context provider method execution failed|

## See also

[JavaScript API reference for live chat SDK](../../omni-channel-reference.md)