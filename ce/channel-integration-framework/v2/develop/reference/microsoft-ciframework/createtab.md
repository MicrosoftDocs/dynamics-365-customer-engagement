---
title: "createTab (JavaScript API Reference) for Dynamics Channel Integration Framework 2.0 | MicrosoftDocs"
description: "Includes description, syntax, and parameter information for the createTab method in JavaScript API Reference for Channel Integration Framework 2.0."
ms.date: 10/23/2023
ms.topic: reference
author: gandhamm
ms.author: mgandham
ms.reviewer: mgandham
ms.custom: 
  - "dyn365-a11y"
  - "dyn365-developer"
---

# createTab (JavaScript API Reference) for Dynamics 365 Channel Integration Framework 2.0

 >[!NOTE]  
 > Use this API only when the focused session belongs to the provider or if it is the home or default session.

Creates a tab in a focused session and returns the unique identifier of the created tab.

## Syntax

`Microsoft.CIFramework.createTab(input, correlationId).then(successCallback, errorCallback);`

## Parameters

| **Name**         | **Type** | **Required** | **Description**   |
|------------------|----------|--------------|-----------------------------------------------------------------------------------------------------------------------|
| input            | String   | Yes          | JSON input                                                                                                            |
| successCallback  | Function | No           | A function to call when a record is created. Unique identifier (tab ID) of the created tab is returned in the response. |
| errorCallback    | Function | No           | A function to call when the operation fails. An object with the following properties will be passed:<br />**errorCode**: Number. The error code.<br />**message**: String. An error message describing the issue.   |

The structure of the `input` parameter JSON is as follows:

```json
{
    //Unique name of the tab 
    // type = string
    templateName: <unique name of the tab template>;

    //additional context for tab creation and tab slugs
    // type = JSON Object
    templateParameters?:<>
    
    //should this tab be focused after the creation
    // type=boolean
    isFocused?: <true or false>;
}
```


## Return value

Promise with the value of tab ID as String

## Example

```javascript
var tabInput = {
    //Unique Name of the Application Tab Template
    // type = string
    templateName: "msdyn_test_entity",
    templateParameters: {
    entityName: "incident",
    data: "{}",
    },
    isFocused: true
};
Microsoft.CIFramework.createTab(tabInput).then((tabId)=>{
    console.log("created tab with id" + tabId);
}, (error)=>{
    console.log(error);
});
```


[!INCLUDE[footer-include](../../../../../includes/footer-banner.md)]
