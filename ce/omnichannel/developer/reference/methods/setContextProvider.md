---
title: "setContextProvider (Omnichannel for Customer Service JavaScript API reference) | MicrosoftDocs"
description: 
keywords: ""
author: susikka
ms.author: susikka
manager: shujoshi
applies_to: 
ms.date: 08/16/2019
ms.service: 
ms.topic: article
ms.assetid: 1C92A31B-70DF-4CE7-9C7A-BE398F34C6F6
ms.custom: 
---
# setContextProvider

[!INCLUDE[cc-use-with-omnichannel](../../../../includes/cc-use-with-omnichannel.md)]

[!INCLUDE[setContextProvider-description](../includes/setContextProvider-description.md)]

> [!IMPORTANT]
> The custom context is a collection of key/value pairs. Only primitive values are allowed for any key.
> The keys of custom context must correspond to context variables that are created for the associated work stream in Omnichannel for Customer Service.
> The custom context provider would be invoked by live chat widget when starting a new chat.

> [!NOTE]
> Listen to the **lcw:ready** event raised by a live chat before calling the live chat SDK methods. The live chat methods should be invoked after the **lcw:ready** event is raised. You can listen for this event by adding your own event listener on the window object.

## Syntax

`Microsoft.Omnichannel.LiveChatWidget.SDK.setContextProvider(contextProvider);`

## Parameters

| Parameter | Type | Description |
| ---- | ---- | ---- |
| contextProvider | Function | Function which when invoked, returns the custom context |

## Return Value

None

## Example

```JavaScript
window.addEventListener("lcw:ready", function handleLivechatReadyEvent(){
               // Set the custom context provider
               // Throws error if contextProvider is not a function
               Microsoft.Omnichannel.LiveChatWidget.SDK.setContextProvider(function contextProvider(){
                                  // Here it is assumed that the corresponding work stream would have context variables with logical name of 'contextKey1', 'contextKey2', 'contextKey3'.
	                              return {
                                             'contextKey1': 'contextValue1', // string value
                                             'contextKey2': 12.34, // number value
                                             'contextKey3': true // boolean value
                                  };
               });
});

```

> [!NOTE]
> When a new context variable is being passed, the context key values can only be of String type.

![Display context keys](../media/context-variable-display.png "Display context keys")

## Error codes

The following error codes can occur with this method.

|Error Code|Error message|
|-----|-----|
|1|Context provider method execution failed|

## See also

[JavaScript API reference for live chat SDK](../../omnichannel-reference.md)
