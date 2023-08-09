---
title: "createTab method (app profile manager) JavaScript API Reference | MicrosoftDocs"
description: "Learn about the createTab API of app profile manager in Customer Service workspace."
author: gandhamm
ms.author: mgandham
ms.date: 02/08/2023
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
formParams["subject"] = "Collaboration task";
formParams["actualdurationminutes"] = 60;
formParams["prioritycode"] = 2;
formParams["scheduledend"] = "12/12/2030 10:00"
formParams["regardingobjectid"] = "a333a119-d573-ec11-8942-000d3a840a75";
formParams["regardingobjectidname"] = "How do I measure my tamp pressure?";
formParams["regardingobjectidtype"] = "incident";

var tabInput = {
templateName: "msdyn_entityrecord",
appContext: new Map().set("entityName", "task").set("formId", "d5b4a1b2-de4f-4f86-8768-b0730001e7d1").set("data", JSON.stringify(formParams)),
isFocused: true
};
Microsoft.Apm.createTab(tabInput);
```

### Create a tab with a web resource

Creates a new tab in the focused session passing a web resource as parameter for app tab template.

```JavaScript
var tabInput = {templateName: "msdyn_omnichannel_kbsearch", isFocused: true};
Microsoft.Apm.createTab(tabInput);
```

### Create a tab with Power Apps component framework control page

Creates a new tab in the focused session passing a framework control as a parameter for the app tab template. The control is passed from the API call.

```JavaScript
var controlDataParams = {};
controlDataParams["<parameter>"] = "<Value>";

x = new Map();
x.set("<custom_session_context_params_key>", "<Value>");
x.set("parametersStr", '[["controlName", "<Control_Name>"], ["data",'+JSON.stringify(controlDataParams)+']]');

Microsoft.Apm.createSession(
    {
        templateName: "<template_name>",
        sessionContext: x
    });

```

You can also pass the following additional parameters:

```JavaScript
var controlDataParams = {};
controlDataParams["<parameter>"] = "<Value>";

x = new Map();
x.set("<custom_session_context_params_key>", JSON.stringify(controlDataParams));
x.set("<additional_custom_session_params>", "<Value>");

Microsoft.Apm.createSession(
    {
        templateName: "<template_name>",
        sessionContext: x
    });

```

[!INCLUDE[footer-include](../../../includes/footer-banner.md)]
