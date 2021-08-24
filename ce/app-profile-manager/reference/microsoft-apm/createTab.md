---
title: "createTab (JavaScript API Reference) for multi-session apps | MicrosoftDocs"
description: "Learn about the createTab API for the multi-session apps such as Customer Service workspace."
author: mh-jaya
ms.author: v-jmh
manager: shujoshi
ms.date: 08/25/2021
ms.topic: reference
---

# createTab

Creates an app tab in a focused session and returns the unique identifier of the created tab.

## Syntax

<!--`Microsoft.Apm.createTab(tabInput).then(successCallback, errorCallback);` -->
`Microsoft.Apm.createTab(tabInput);`

## Parameters

| **Name**         | **Type**      | **Required** | **Description**   |
|------------------|----------     |--------------|-------------------|
| AppTabInput      |   String    | Yes          | JSON input properties of the tab to be created.     |
<!--| successCallback  | Function | No           | A function to call when the tab is created. Unique identifier(TabId) of the created tab is returned in the response. |
| errorCallback    | Function | No           | A function to call when the operation fails. An object with the following properties will be passed:<br />**errorCode**: Number. The error code.<br />**message**: String. An error message describing the issue.|-->

The structure of the JSON `AppTabInput` parameter is shown below.

```json
{
    //Unique Name of the Application Tab Template
    // type = string
    templateName: <unique name of the application tab template>;
    //additional context for tab creation and tab slugs
    // type  Map<string, string>
    appContext?:  Map<string, string>;
    //should this tab be focused after creation
    // type=boolean
    isFocused?: <true or false>;
}
```

## Return value

Tab identifier as String.

## Examples

These examples use the `createTab` method to launch a new tab.

### Basic tab creation

Launches a new tab in the focused session passing entity name, recordId and app tab template.

```JavaScript
var tabInput = {templateName: "msdyn_entityrecord",  appContext: new Map().set("entityName", "account").set("entityId", "09e68a6e-b7ef-eb11-bacb-000d3a373d11"),  isFocused: true};
Microsoft.Apm.createTab(tabInput);
```

### Tab creation passing values to an entity form

Launches a new tab in the focused session passing entity name and app tab template. It also populates the target entity form with additional values.

```JavaScript
var formParams = {};
 formParams["lastname"] = "Cannon";
 formParams["firstname"] = "Paul";

var tabInput = { 
templateName: "msdyn_entityrecord", 
appContext: new Map().set("entityName", "contact") .set("formId", "e06af4d1-2812-45c7-a9c2-9fb73fee7bec") .set("data", JSON.stringify(formParams)), 
isFocused: true 
};

Microsoft.Apm.createTab(tabInput);
```

[!INCLUDE[footer-include](../../../includes/footer-banner.md)]
