---
title: "createTab (JavaScript API Reference) for multi-session apps | MicrosoftDocs"
description: "Learn about the createTab API for the multi-session apps such as Omnichannel for Customer Service and Customer Service workspace."
author: kabala123
ms.author: kabala
manager: shujoshi
ms.date: 10/12/2020
ms.service: "dynamics-365-customerservice"
ms.topic: reference
---

# createTab

Creates an app tab in a focused Session and returns the unique identifier of the created tab.

## Syntax

`Microsoft.Apm.createTab(tabInput).then(successCallback, errorCallback);`

## Parameters

| **Name**         | **Type** | **Required** | **Description**   |
|------------------|----------|--------------|-----------------------------------------------------------------------------------------------------------------------|
| tabInput            | AppTabInput   | Yes     | JSON input |
| successCallback  | Function | No           | A function to call when the tab is created. Unique identifier(TabId) of the created tab is returned in the response. |
| errorCallback    | Function | No           | A function to call when the operation fails. An object with the following properties will be passed:<br />**errorCode**: Number. The error code.<br />**message**: String. An error message describing the issue.|

The structure of the JSON `Input` parameter is shown below.

```json
{
    //Unique Name of the Application Tab Template
    // type = string
    templateName: <unique name of the application tab template>;
    //additional context for tab creation and tab slugs
    // type string
    appContext: Map<etn, recordId>;
    //should this tab be focused after creation
    // type=boolean
    isFocused?: <true or false>;
}
```

## Returns

Promise string with the value as created tab ID.

## Example

```JavaScript
var tabInput = {
    //Unique Name of the Application Tab Template
    // type = string
    templateName: "msdyn_test_entity",
    appContext: new Map().set("etn", "incident").set("recordId", "768a786f-59e0-ea11-a813-000d3a8b1f3b"),
    isFocused: true
};
Microsoft.Apm.createTab(tabInput).then((tabId)=>{
    console.log("created tab with id " + tabId);
}, (error)=>{
    console.log(error);
});
```

[!INCLUDE[footer-include](../../../includes/footer-banner.md)]