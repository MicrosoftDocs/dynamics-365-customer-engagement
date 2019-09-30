---
title: "createTab (JavaScript API Reference) for Channel Integration Framework (CIF) | MicrosoftDocs"
description: ""
keywords: ""
ms.date: 09/30/2019
ms.service:
  - dynamics-365-cross-app
ms.custom:
  - "dyn365-a11y"
  - "dyn365-developer"
ms.topic: reference
ms.assetid: 16D188B8-E3CD-4B1B-A65A-B48537E6C77A
author: susikka
ms.author: susikka
manager: shujoshi
---

# createTab

[!include[cc-beta-prerelease-disclaimer](../../../../includes/cc-beta-prerelease-disclaimer.md)]

Creates a tab in a focused Session and returns the unique identifier of the created tab.

## Syntax

`Microsoft.CIFramework.createTab(input, correlationId).then(successCallback, errorCallback);`

## Parameters

| **Name**         | **Type** | **Required** | **Description**   |
|------------------|----------|--------------|-----------------------------------------------------------------------------------------------------------------------|
| Input            | String   | Yes          | JSON input                                                                                                            |
| successCallback  | Function | No           | A function to call when a record is created. Unique identifier(TabId) of the created tab is returned in the response. |
| errorCallback    | Function | No           | A function to call when the operation fails. An object with the following properties will be passed:<br />**errorCode**: Number. The error code.<br />**message**: String. An error message describing the issue.   |

The structure of the `Input` parameter JSON is shown below.

```json
{ 
   "templateName":"<name of session template>",
   "templateTag":"<template tag>",
   "templateParameters":{ 
      "globalparam":"number value OR boolean value OR json string value OR parameterized string value",
      "app template 1":{ 
         "param 1":"number value OR boolean value OR json string value OR parameterized string value",
         "param 2":"..."
      },
      "app template 2":"…."
   }
}
```

## Returns

Promise with the value as String

## Example

```javascript
var entityLogicalName = "contact";
var data = {
	"firstname": "Sample",
	"lastname": "Contact",
	"fullname": "Sample Contact",
	"emailaddress1": "<contact@contoso.com>",
	"jobtitle": "Sr. Marketing Manager",
	"telephone1": "555-0109",
	"description": "Default values for this record were set programmatically."
}
// create contact record
var jsonData = JSON.stringify(data);
Microsoft.CIFramework.createRecord(entityLogicalName, jsonData).then((result) => {
	var recordResult = JSON.parse(result);
	var input = {
		templateName: "entityrecord",
		templateParameters: {
			entityName: entityLogicalName,
			entityId: recordResult.id,
		},
		isFocused: true
	}
	Microsoft.CIFramework.createTab(input).then((result) => {
		console.log("created tab with id " + result);
	});
	// We created a contact record in the background by calling createRecord API, and then open the same in the new tab by passing the contact’s id that was returned from createRecord API, as template parameter
});
```