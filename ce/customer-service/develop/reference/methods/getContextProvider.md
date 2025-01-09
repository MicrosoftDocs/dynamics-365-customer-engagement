---
title: "getContextProvider (Omnichannel for Customer Service JavaScript API reference) | MicrosoftDocs"
description: "Includes syntax and parameter information for the getContextProvider method in Omnichannel for Customer Service JavaScript API reference. Also included is a sample code for using the method."
ms.date: 07/09/2019
ms.topic: reference
author: gandhamm
ms.author: mgandham
ms.reviewer: mgandham
---

# getContextProvider

[!INCLUDE[cc-use-with-omnichannel](../../../../includes/cc-use-with-omnichannel.md)]

[!INCLUDE[getContextProvider-description](../includes/getContextProvider-description.md)]

> [!NOTE]
> The live chat SDK methods should be invoked after the [lcw:ready event](../events/lcw-ready.md) is raised. You can listen for this event by adding your own event listener on the window object.

## Syntax

`Microsoft.Omnichannel.LiveChatWidget.SDK.getContextProvider();`

## Parameters

None

## Return Value

Returns the currently set custom context provider, if any. If there is no registered custom context provider, then it returns null.

## Example

```JavaScript
window.addEventListener("lcw:ready", function handleLivechatReadyEvent(){
   // Setting the custom context provider
   // Throws error if contextProvider is not a function
   Microsoft.Omnichannel.LiveChatWidget.SDK.setContextProvider(function contextProvider(){
      // Here it is assumed that the corresponding work stream would have context variables with logical name of 'contextKey1', 'contextKey2', 'contextKey3'.
      return {
                 'contextKey1': 'contextValue1', // string value
                 'contextKey2': 12.34, // number value
                 'contextKey3': true // boolean value
      };
   });

   // Retrieves the currently set custom context provider
   // If there is no registered custom context provider, then it returns null
   let registeredContextProvider = Microsoft.Omnichannel.LiveChatWidget.SDK.getContextProvider();
});
```

-->

## Related information

[JavaScript API reference for Live chat SDK](../../omnichannel-reference.md)


[!INCLUDE[footer-include](../../../../includes/footer-banner.md)]
