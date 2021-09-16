---
title: "renderSearchPage (JavaScript API Reference) for Dynamics 365 Channel Integration Framework 1.0 | MicrosoftDocs"
description: "Includes description, syntax, and parameter information for the renderSearchPage method in JavaScript API Reference for Channel Integration Framework 1.0."
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

# renderSearchPage (JavaScript API Reference) for Dynamics 365 Channel Integration Framework 1.0

[!INCLUDE[renderSearchPage-description](includes/renderSearchPage-description.md)] 

## Syntax

`Microsoft.CIFramework.renderSearchPage(entityLogicalName, searchString, searchType).then(successCallback, errorCallback);`

## Parameters

| Name               | Type       | Required | Description                                       |
|-----------------   |----------  |----------|---------------------------------------------------|
| entityLogicalName  | String     | Yes      | The entity logical name of the record you want to be queried, such as "account".  |
| searchString       | String     | Yes      | String to search among the attributes of the entity records. |
| searchType         | Boolean    | No       | Type of search page to open (value 1 for categorized search, 0 for relevance search)|
| successCallback    | Function   | No       | A function to call when some records are retrieved. |
| errorCallback      | Function   | No       | A function to call when the operation fails.        |

## Return value


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


[!INCLUDE[footer-include](../../../../includes/footer-banner.md)]
