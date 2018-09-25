---
title: "createRecord (JavaScript API Reference) for Channel Integration Framework (CIF) in Dynamics 365 | MicrosoftDocs"
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
ms.assetid: 7CB95F79-33F4-48B1-A4A0-09A377355B07
author: kabala123
ms.author: kabala
manager: shujoshi
---

# createRecord (CIF JavaScript API Reference)

[!INCLUDE[createRecord](includes/createRecord-description.md)] 

## Syntax

`Microsoft.CIFramework.createRecord(entityLogicalName, data).then(successCallback, errorCallback);`

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
<td>Logical name of the entity you want to create. For example: &quot;account&quot;.</td>
</tr>
<tr>
<td>data</td>
<td>Object</td>
<td>Yes</td>
<td><p>A JSON object defining the attributes and values for the new entity record.</p>
</td>
</tr>
<tr>
<td>successCallback</td>
<td>Function</td>
<td>No</td>
<td><p>A function to call when a record is created. An object with the following properties will be passed to identify the new record:</p>
<ul>
<li><b>entityType</b>: String. The entity logical name of the new record.</li>
<li><b>id</b>: String. GUID of the new record.</li>
</ul></td>
</tr>
<tr>
<td>errorCallback</td>
<td>Function</td>
<td>No</td>
<td>A function to call when the operation fails. An object with the following properties will be passed:
<ul>
<li><b>errorCode</b>: Number. The error code.</li>
<li><b>message</b>: String. An error message describing the issue.</li>
</ul></td>
</tr>
</table>

## Return Value

On success, returns a promise object containing the attributes specified earlier in the description of the **successCallback** parameter.

## Examples

The sample code demonstrates to create a sample contact record.

```JavaScript
var entityLogicalName = "contact";
var data = {
    "firstname": "Sample",
    "lastname": "Contact",
    "fullname": "Sample Contact",
    "emailaddress1": "contact@contoso.com",
    "jobtitle": "Sr. Marketing Manager",
    "phonenumber": "555-0109",
    "description": "Default values for this record were set programmatically."
}
// create contact record
Microsoft.CIFramework.createRecord(entityLogicalName,data).then(
    function success (result) {
          console.log("Contact created with ID: " + result.id);
          //perform operations on record creation
      },
      function (error) {
          console.log(error);
          //handle error conditions
      }
  );
```