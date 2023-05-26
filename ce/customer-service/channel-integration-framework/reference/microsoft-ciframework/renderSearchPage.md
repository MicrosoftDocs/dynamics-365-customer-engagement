---
title: "renderSearchPage (JavaScript API Reference) for Dynamics 365 Channel Integration Framework 1.0 | MicrosoftDocs"
description: "Includes description, syntax, and parameter information for the renderSearchPage method in JavaScript API Reference for Channel Integration Framework 1.0."
ms.date: 11/17/2022
ms.topic: reference
author: gandhamm
ms.author: mgandham
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
| entityLogicalName  | String     | Yes      | The entity logical name of the record you want to query such as "account".  |
| searchString       | String     | Yes      | String to search among the attributes of the entity records. |
| searchType         | Boolean    | No       | Type of search page to open&mdash;0 for relevance search and 1 for categorized search. If no parameter is provided, the records are searched by category. For information on relevance search, see [Configure Dataverse search](/power-platform/admin/configure-relevance-search-organization). |
| successCallback    | Function   | No       | A function to call when some records are retrieved. |
| errorCallback      | Function   | No       | A function to call when the operation fails.        |

## Return value
On success, returns a promise object containing the attributes specified earlier in the description of the **successCallback** parameter.

## Examples
The following example shows how to query for the term "Contoso" among the records of an account entity by specifying the relevance search type.

```JavaScript
var entityname = "account"
var searchterm = "Contoso"
var searchtype = 0 // relevance search

Microsoft.CIFramework.renderSearchPage(entityname, searchterm, searchtype).then(
      function (success) {
        console.log(success);
    },
    function (error) {
        console.log(error);
    }
  );
```

The following example shows how to query for the term "Contoso" among the records of an account entity, without specifying the search type.

```JavaScript
var entityname = "account"
var searchterm = "Contoso"

Microsoft.CIFramework.renderSearchPage(entityname, searchterm).then( // if search type is not passed, it defaults to categorized search
        function (success) {​​
            console.log(success);
    }​​,
    function (error) {​​
        console.log(error);
    }​​
);
```

[!INCLUDE[footer-include](../../../../includes/footer-banner.md)]
