---
title: "createTab (Omnichannel for Customer Service JavaScript API reference) | MicrosoftDocs"
description: 
author: platkat
ms.author: ktaylor
manager: shujoshi
ms.date: 10/05/2020
ms.topic: article
---
# createTab

[!INCLUDE[cc-use-with-omnichannel](../../../../includes/cc-use-with-omnichannel.md)]

Provides the functionality to create a tab in the focused session.

## Syntax

`Microsoft.Apm.createTab(tabInput);`

## Parameters

| Parameter | Type | Description |
| ---- | ---- | ---- |
| tabInput | AppTabInput | - Unique name of the Application Tab Template<br>- Additional context for tab creation and tab slugs<br>- Should this tab be focused after creation | 

```AppTabInput {
        //Unique Name of the Application Tab Template
        templateName: string;
	//additional context for tab creation and tab slugs
        appContext: Map<string, string>;
	//should this tab be focused after creation
        isFocused?: boolean;
}
``` 

## Return Value

String resolved with created tab id.

## Example

```javascript
var tabInput = {
    templateName: "msdyn_test_entity",
    appContext: new Map().set("etn", "incident").set("recordId", "768a786f-59e0-ea11-a813-000d3a8b1f3b"),
    isFocused: true
};
Microsoft.Apm.createTab(tabInput).then((tabId)=>{
    console.log(tabId);
}, (error)=>{
    console.log(error);
});
```

## See also

[JavaScript API reference for live chat SDK](../../omnichannel-reference.md)
