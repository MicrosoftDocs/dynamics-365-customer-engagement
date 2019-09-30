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

#  createTab

Creates a tab in a focused Session and returns the unique identifier of the created tab.

## Syntax

Microsoft.CIFramework.createTab(input, correlationId).then(successCallback, errorCallback);

## Parameters

| **Name**                                                                                                                                   | **Type** | **Required** | **Description**                                                                                                       |
|--------------------------------------------------------------------------------------------------------------------------------------------|----------|--------------|-----------------------------------------------------------------------------------------------------------------------|
| Input: {                                                                                                                                   
                                                                                                                                             
   "templateName":"&lt;name\_of\_tab\_template&gt;",                                                                                         
                                                                                                                                             
   "templateTag":"&lt;template\_tag&gt;",                                                                                                    
                                                                                                                                             
   "templateParameters":  {  "global\_param\_1": "number\_value OR boolean\_value OR json\_string\_value OR parameterized\_string\_value",   
                                                                                                                                             
     "global\_param\_2": "….",                                                                                                               
                                                                                                                                             
      "app\_template\_1": {                                                                                                                  
                                                                                                                                             
      "param\_1": "number\_value OR boolean\_value OR json\_string\_value OR parameterized\_string\_value",                                  
                                                                                                                                             
   "param\_2": "..."                                                                                                                         
                                                                                                                                             
      },                                                                                                                                     
                                                                                                                                             
 "app\_template\_2": { ….},                                                                                                                  
                                                                                                                                             
   },                                                                                                                                        
                                                                                                                                             
 }                                                                                                                                           | String   | Yes          | JSON input                                                                                                            |
| successCallback                                                                                                                            | Function | No           | A function to call when a record is created. Unique identifier(TabId) of the created tab is returned in the response. |
| errorCallback                                                                                                                              | Function | No           | A function to call when the operation fails. An object with the following properties will be passed:                  
                                                                                                                           
    - **errorCode**: Number. The error code.                                                                             
                                                                                                                           
    - **message**: String. An error message describing the issue.                                                        |

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
Microsoft.CIFramework.createRecord(entityLogicalName,jsonData).then((result) =&gt; {
var recordResult = JSON.parse(result);
var input = {
templateName: "entityrecord",
templateParameters: {
entityName: entityLogicalName,
entityId: recordResult.id,
},
isFocused: true
}
Microsoft.CIFramework.createTab(input).then((result) =&gt; {
console.log("created tab with id " + result);
});
// We created a contact record in the background by calling createRecord API, and then open the same in the new tab by passing the contact’s id that was returned from createRecord API, as template parameter
});
```