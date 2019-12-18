---
title: "deleteRecord (JavaScript API Reference) for Channel Integration Framework (CIF) | MicrosoftDocs"
description: ""
author: susikka
ms.author: susikka
manager: shujoshi
ms.date: 12/10/2018
ms.topic: reference
ms.service: 
  - dynamics-365-cross-app
ms.custom: 
  - "dyn365-a11y"
  - "dyn365-developer"
applies_to: 
  - "Dynamics 365 for Customer Engagement (online)"
---

# deleteRecord (CIF JavaScript API Reference)

[!INCLUDE[deleteRecord](includes/deleteRecord-description.md)] 

[!include[applies-to-v1-and-v2](../../includes/applies-to-v1-and-v2.md)]

## Syntax

`Microsoft.CIFramework.deleteRecord(entityLogicalName, id).then(successCallback, errorCallback);`

## Parameters

<table style="width:100%">
<tr>
<th>Name</th>
<th>Type</th>
<th>Required</th>
<th>Description</th>
</tr>
<tr>
<td>entityLogicalName</td>
<td>String</td>
<td>Yes</td>
<td>The entity logical name of the record you want to delete. For example: &quot;account&quot;. </td>
</tr>
<tr>
<td>id</td>
<td>String</td>
<td>Yes</td>
<td>GUID of the entity record you want to delete.</td>
</tr>
<tr>
<td>successCallback</td>
<td>Function</td>
<td>No</td>
<td><p>A function to call when a record is deleted.</td>
</tr>
<tr>
<td>errorCallback</td>
<td>Function</td>
<td>No</td>
<td>A function to call when the operation fails.</td>
</tr>
</table>

## Return Value

On success, returns a promise containing a string with the attributes and their values.

## Examples

This sample code deletes an existing contact record with record ID = a8a19cdd-88df-e311-b8e5-6c3be5a8b200

```JavaScript
// delete contact record  with the id=b44d31ac-5fd1-e811-8158-000d3af97055d
var id = "b44d31ac-5fd1-e811-8158-000d3af97055";
var entityLogicalName = "contact";
Microsoft.CIFramework.deleteRecord(entityLogicalName, id).then(
    function success(result) {
      res=JSON.parse(result);
      console.log("Contact deleted with ID: " + res.contactid);
      // the record is deleted
    },
    function (error) {
        console.log(error.message);
        // handle error conditions
    }
);
```
5af02e2a-d0d1-e811-8158-000d3af97055
