---
title: "setContextProvider (Omnichannel for Customer Service JavaScript API reference) | MicrosoftDocs"
description: 
author: v-sailab
ms.author: v-sailab
manager: shujoshi
ms.date: 02/04/2021
ms.topic: article
ms.service: dynamics-365-customerservice
---
# setContextProvider

[!INCLUDE[cc-use-with-omnichannel](../../../../includes/cc-use-with-omnichannel.md)]

[!INCLUDE[setContextProvider-description](../includes/setContextProvider-description.md)]

> [!IMPORTANT]
> - The custom context is a collection of key/value pairs. Only primitive values are allowed for any key.
> - The keys of custom context must correspond to context variables that are created for the associated work stream in Omnichannel for Customer Service.
> - The custom context provider would be invoked by live chat widget when starting a new chat.

> [!NOTE]
> Listen to the **lcw:ready** event raised by a live chat before calling the live chat SDK methods. The live chat methods should be invoked after the **lcw:ready** event is raised. You can listen for this event by adding your own event listener on the window object.

## Syntax

`Microsoft.Omnichannel.LiveChatWidget.SDK.setContextProvider(contextProvider);`

## Parameters

| Parameter | Type | Description |
| ---- | ---- | ---- |
| contextProvider | Function | Function that when invoked, returns the custom context |

## Return Value

None

## Example

```javascript
window.addEventListener("lcw:ready", function handleLivechatReadyEvent(){
        // Set the custom context provider
        // Throws error if contextProvider is not a function
        Microsoft.Omnichannel.LiveChatWidget.SDK.setContextProvider(function contextProvider(){
                   //Here it is assumed that the corresponding work stream would have context variables with logical name of 'contextKey1', 'contextKey2', 'contextKey3'. If no context variable exists with a matching logical name, items are created assuming Type:string               
	               return {
                             'contextKey1': {'value': 'contextValue1', 'isDisplayable': true},
                             'contextKey2': {'value': 12.34, 'isDisplayable': false},
                             'contextKey3': {'value': true}
                   };
        });
});
```
In the sample code given above, the `value` attribute contains the value of the context variables.

The `isDisplayable` attribute, if set to `true`, will display the passed items within a third tab on the Conversation Summary Control for a given Conversation. This is an optional parameter and its default value is `false`.

> [!NOTE]
> If no context variables have been created under live work stream with a matching logical name, variables are created at runtime assuming the type as String. More information: [Context variables](../../../context-variables-for-bot.md#context-variables)

![Display context keys](../../../media/context-variable-display.png "Display context keys")

<a name="bkmk_navigationhistory"></a>

### Pass customer's self service as context

You can pass a customer's self service as context at the start of a conversation with that customer. The `setContextProvider` method passes the recent customer actions as part of context with self service type, for a new conversation between the customer and agent. A visitor journey record is created for each self service action.

Given below is the sample code that shows how to use the `setContextProvider` method for this.

```javascript
window.addEventListener("lcw:ready", function handleLivechatReadyEvent(){

Microsoft.Omnichannel.LiveChatWidget.SDK.setContextProvider(function contextProvider(){
    return {
            'SelfService': { 'value' : 
                '[ {"msdyn_displaytitle":"Page visited", "msdyn_starttime":"yyyy-mm-ddThh:mm:ssZ","msdyn_type":192350000}, \
                   {"msdyn_displaytitle":"Phrase searched", "msdyn_starttime":"yyyy-mm-ddThh:mm:ssZ","msdyn_type":192350001}, \
                   {"msdyn_displaytitle":"Knowledge article viewed", "msdyn_starttime":"yyyy-mm-ddThh:mm:ssZ","msdyn_type":192350002}, \
                   {"msdyn_displaytitle":"Custom action performed", "msdyn_starttime":"yyyy-mm-ddThh:mm:ssZ","msdyn_type":192350003} \
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

For the sample script to track self service actions that can be included in the Self Service Portal, see [Self Service sample code](https://github.com/susikka/Dynamics365-Apps-Samples/tree/master/customer-service/omnichannel/self-service).

## Error codes

The following error codes can occur with this method.

|Error Code|Error message|
|-----|-----|
|1|Context provider method execution failed|

## See also

[JavaScript API reference for live chat SDK](../../omnichannel-reference.md)
