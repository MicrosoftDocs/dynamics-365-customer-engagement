---
title: "removeContextProvider (Omnichannel for Customer Service JavaScript API reference)| MicrosoftDocs"
description: "Includes reference information such as syntax and parameters for the removeContextProvider method in Omnichannel for Customer Service JavaScript API reference. Also included is a sample code for using the method."
ms.date: 04/04/2022
ms.topic: reference
author: gandhamm
ms.author: mgandham
ms.reviewer: mgandham
---
# removeContextProvider

[!INCLUDE[cc-use-with-omnichannel](../../../../includes/cc-use-with-omnichannel.md)]

[!INCLUDE[removeContextProvider-description](../includes/removeContextProvider-description.md)]

> [!NOTE]
> The live chat SDK methods should be invoked after the [lcw:ready event](../events/lcw-ready.md) is raised. You can listen for this event by adding your own event listener on the window object.

## Syntax

`Microsoft.Omnichannel.LiveChatWidget.SDK.removeContextProvider();`

## Parameters

None

## Return value

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

   // Removes the currently set custom context provider, if any
   Microsoft.Omnichannel.LiveChatWidget.SDK.removeContextProvider();
});
```

### Related information

[JavaScript API reference for live chat SDK](../../omnichannel-reference.md)


[!INCLUDE[footer-include](../../../../includes/footer-banner.md)]
