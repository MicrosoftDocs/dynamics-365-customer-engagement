---
title: "deleteRecord (JavaScript API Reference) for Channel Integration Framework (CIF) in Dynamics 365 | MicrosoftDocs"
description: ""
keywords: ""
ms.date: 10/01/2018
ms.service:
  - "dynamics-365-cross-app"
ms.custom:
  - "dyn365-a11y"
  - "dyn365-developer"
ms.topic: reference
applies_to:
  - "Dynamics 365 (online)"
  - "Dynamics 365 Version 9.x"
ms.assetid: 8CB273BE-BB42-4F13-AFA8-0059A4B1D2BC
author: kabala123
ms.author: kabala
manager: shujoshi
---

# deleteRecord (CIF JavaScript API Reference)

> [!Important]
> [!INCLUDE[cc-beta-prerelease-disclaimer](../../../../includes/cc-beta-prerelease-disclaimer.md)] 

[!INCLUDE[deleteRecord](includes/deleteRecord-description.md)] 

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
<td><p>A function to call when a record is deleted. An object with the following properties will be passed to identify the deleted record:</p>
<ul>
<li><b>entityType</b>: String. The entity type of the record.</li>
<li><b>id</b>: String. GUID of the record.</li>
<li><b>name</b>: String. Name of the record.</li>
</ul></td>
</tr>
<tr>
<td>errorCallback</td>
<td>Function</td>
<td>No</td>
<td>A function to call when the operation fails.</td>
</tr>
</table>

## Return Value

On success, returns a promise object containing the attributes specified earlier in the description of the **successCallback** parameter.

## Examples

This sample code deletes an existing contact record with record ID = a8a19cdd-88df-e311-b8e5-6c3be5a8b200

```JavaScript
// delete contact record
Microsoft.CIFramework.retrieveRecord("contact", "a8a19cdd-88df-e311-b8e5-6c3be5a8b200").then(
    function success(result) {
        console.log("Contact deleted with ID: " + result.id);
        // the record is deleted
    },
    function (error) {
        console.log(error.message);
        // handle error conditions
    }
);
```