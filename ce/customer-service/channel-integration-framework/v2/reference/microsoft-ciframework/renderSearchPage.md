---
title: "renderSearchPage (JavaScript API Reference) for Dynamics 365 Channel Integration Framework 2.0| MicrosoftDocs"
description: "Includes description, syntax, and parameter information for the renderSearchPage method in JavaScript API Reference for Channel Integration Framework 2.0."
ms.date: 09/17/2021
ms.topic: reference
author: mh-jaya
ms.author: v-jmh
manager: shujoshi
applies_to: 
  - Dynamics 365 for Customer Engagement (online)
ms.custom: 
  - dyn365-a11y
  - dyn365-developer
---

# renderSearchPage (JavaScript API Reference) for Dynamics 365 Channel Integration Framework 2.0

[!INCLUDE[renderSearchPage-description](includes/renderSearchPage-description.md)] 

## Syntax

`Microsoft.CIFramework.renderSearchPage(entityLogicalName, searchString, correlationId, searchType).then(successCallback, errorCallback);`

## Parameters


| Name               | Type       | Required | Description                                       |
|-----------------   |----------  |----------|---------------------------------------------------|
| entityLogicalName  | String     | Yes      | The entity logical name of the record you want to be queried, such as "account".  |
| searchString       | String     | No       | String to search among the attributes of the entity records. |
| correlationId      | GUID     | No       | The unique identifier for the RenderSearchPage event that was raised. |
| searchType         | Boolean    | Yes      | Type of search page to open (value 1 for categorized search, 0 for relevance search)|
| successCallback    | Function   | No       | A function to call when some records are retrieved. |
| errorCallback      | Function   | No       | A function to call when the operation fails.        |


<!--
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
<td>The entity logical name of the record you want to be queried. For example: &quot;account&quot;.</td>
</tr>
<tr>
<td>searchString</td>
<td>String</td>
<td>Yes</td>
<td>String to search among the attributes of the entity records.</td>
</tr>
<tr>
<td>successCallback</td>
<td>Function</td>
<td>No</td>
<td><p>A function to call when some records are retrieved.</p>
</td>
</tr>
<tr>
<td>errorCallback</td>
<td>Function</td>
<td>No</td>
<td>A function to call when the operation fails.</td>
</tr>
</table>
-->
## Return value

<!--Editor note: "On success, returns a promise ..." What returns the promise? Need a noun.-->


On success, returns a promise object containing the attributes specified earlier in the description of the **successCallback** parameter.

## Example

The following example shows how to query for the term "Contoso" among the records of an Account entity.

```JavaScript
var entityname = "account"
var searchterm = "Contoso"

Microsoft.CIFramework.renderSearchPage(entityname, searchterm).then(
      function (success) {
        console.log(success);
    },
    function (error) {
        console.log(error);
    }
  );
```

<!--
[!INCLUDE[token-renderSearchPage](../../../shared/token-renderSearchPage.md)]
-->

[!INCLUDE[footer-include](../../../../../includes/footer-banner.md)]
