---
title: "createTab method (app profile manager) JavaScript API Reference | MicrosoftDocs"
description: "Learn about the createTab API of app profile manager in Customer Service workspace."
author: mh-jaya
ms.author: v-jmh
manager: shujoshi
ms.date: 08/25/2021
ms.topic: reference
---

# createTab (app profile manager)

Creates an app tab in a focused session and returns the unique identifier of the tab.

## Syntax

`Microsoft.Apm.createTab(AppTabInput);`

## Parameters

| **Name**         | **Type**      | **Required** | **Description**   |
|------------------|----------     |--------------|-------------------|
| AppTabInput      |   String    | Yes          | JSON input properties of the tab to be created.     |

The structure of the JSON `AppTabInput` parameter is as follows:

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

### Create a basic tab

Creates a new tab in the focused session, passing the entity name, recordId, and app tab template name as parameters.

```JavaScript
var tabInput = {templateName: "msdyn_entityrecord",  appContext: new Map().set("entityName", "account").set("entityId", "09e68a6e-b7ef-eb11-bacb-000d3a373d11"),  isFocused: true};
Microsoft.Apm.createTab(tabInput);
```

### Create a tab passing values to an entity form

Creates a new tab in the focused session passing the entity name and app tab template name as parameters. It also populates the target entity form with additional values.

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
