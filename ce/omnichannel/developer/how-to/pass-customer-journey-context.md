---
title: "Pass portal navigation history as context | Microsoft Docs"
description: ""
keywords: ""
ms.date: 10/21/2019
ms.service: dynamics-365-customerservice
ms.custom:
ms.topic: reference
ms.assetid: CDFE91D3-C12E-4C2E-BF94-8582D49C8D37
author: susikka
ms.author: susikka
manager: shujoshi
---
# Pass portal navigation history as context

[!INCLUDE[cc-use-with-omnichannel](../../../includes/cc-use-with-omnichannel.md)]

Omnichannel for Customer Service provides you the capability to track a customer's actions across your website and pass that as context in a conversation with that customer.

Use the [setContextProvider](../reference/methods/setContextProvider.md) method to pass customer's portal navigation history as context in the conversation.

## Sample code

```javascript
window.addEventListener("lcw:ready", function handleLivechatReadyEvent(){

Microsoft.Omnichannel.LiveChatWidget.SDK.setContextProvider(function contextProvider(){
    return {
            'Navigation': { 'value' : 
                '[ {"msdyn_displaytitle":"PageTitle1", "msdyn_starttime":"yyyy-mm-ddThh:mm:ssZ","msdyn_endtime":"yyyy-mm-ddThh:mm:ssZ","msdyn_type":192350000}, \
                   {"msdyn_displaytitle":"PageTitle2", "msdyn_starttime":"yyyy-mm-ddThh:mm:ssZ","msdyn_endtime":"yyyy-mm-ddThh:mm:ssZ","msdyn_type":192350001} \
                 ]'
             }, // Additional context can be added as shown below
                //Here it is assumed that the corresponding work stream would have context variables with logical name of 'contextKey1', 'contextKey2', 'contextKey3'. If no context variable exists with a matching logical name, items are created assuming Type:string
                'contextKey1': {'value': 'contextValue1', 'isDisplayable': true},
                'contextKey2': {'value': 12.34, 'isDisplayable': false},
                'contextKey3': {'value': true}
         };
    });
});
```

## See also

[Manage custom context](send-context-starting-chat.md)<br />
[Display custom context](display-custom-context.md)<br />
[setContextProvider method](../reference/methods/setContextProvider.md)<br />
[getContextProvider method](../reference/methods/getContextProvider.md)