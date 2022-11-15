---
title: "searchAndOpenRecords (JavaScript API Reference) for Dynamics 365 Channel Integration Framework 2.0 | MicrosoftDocs"
description: "Includes reference information such as description, syntax, and parameters for the searchAndOpenRecords method in JavaScript API Reference for Dynamics 365 Channel Integration Framework 2.0. "
ms.date: 04/22/2022
ms.topic: reference
author: mh-jaya
ms.author: v-jmh
manager: shujoshi
applies_to: 
  - "Dynamics 365 (online)"
  - "Dynamics 365 Version 9.x"
ms.custom: 
  - "dyn365-a11y"
  - "dyn365-developer"
---

# searchAndOpenRecords (JavaScript API Reference) for Dynamics 365 Channel Integration Framework 2.0

[!INCLUDE[searchAndOpenRecords](includes/searchAndOpenRecords-description.md)]

## Syntax

`Microsoft.CIFramework.searchAndOpenRecords(entityLogicalName, queryParmeters, searchOnly, correlationid, searchType).then(successCallback, errorCallback);`

## Parameters

| Name | Type | Required | Description |
|------|------|----------|-------------|
| entityLogicalName | String | Yes | Name of the entity to search and open. |
| queryParmeters | String | Yes | OData system query options, **$select** and **$expand**, to retrieve your data.<br><br> - Use the **$select** system query option to limit the properties returned by including a comma-separated list of property names. This is an important performance best practice. If properties aren’t specified using **$select**, all properties will be returned.<br><br> - Use the **$expand** system query option to control the data returned by related entities. If you just include the name of the navigation property, you’ll receive all the properties for related records. You can limit the properties returned for related records using the **$select** system query option in parentheses after the navigation property name. Use this for both single-valued and collection-valued navigation properties.<br><br> You can specify the query options starting with `?`. You can also specify multiple query options by using `&` to separate the query options.<br> For example: `?$select=name&$expand=primarycontactid($select=contactid,fullname) `|
| searchOnly | Boolean | Yes | Set to `false` to open the record in the Unified Interface page if the search record is a single record. Set to `false` to open a search page if the search result has multiple records and to automatically populate the search page with the tag value mentioned when the search field is used in `queryParmeters`.<br><br>Set to `true` only to get results of the search as a promise result and not open the record or search page.|
| correlationid | String| No | Is used to group all related API calls together for diagnostic telemetry.   |
| searchType         | Number    | No       | Type of search page to open&mdash;0 for relevance search and 1 for categorized search. If no parameter is provided, the records are searched by category.|
| successCallback	| Function	| No	| A function to call when the request is successful. |
| errorCallback |	Function	| No	| A function to call when the request fails. |

When you set the `searchOnly` parameter to `true`, the contact entity records are searched to get the results as a Promise object, and the record is not opened. Set `searchOnly` to `true` when the search displays a list of records based on the search context.

When you set `searchOnly` to `false`, the contact entity records are searched and the record is opened. Set the `searchOnly` to `false` when you want the search to display a single record based on the search context. If `searchOnly` parameter is set to `false`, it will open the search page if the search result has multiple records and populate the search page with the tag value mentioned when the search field is used in `queryParmeters`.

> [!Note]
> You must enable relevance search to be able to use it. If relevance search is not enabled, then the search will be performed based on category. More information: [Configure Dataverse search](/power-platform/admin/configure-relevance-search-organization.md)

## Return value

Returns a Promise object of type String. On success, the method returns the search results as per the search query. 

> [!Note]
> You can fetch a maximum of 5000 records at once (if more than 5000 records exist). You can narrow down the results by using query options such as $filter, $select, and $top in the method parameters as shown in the [Examples](#examples) section. More information: [Query options overview](/odata/concepts/queryoptions-overview)




## Examples

### Search and open the contact record

This sample code searches the name and phone number of a contact record. It opens an empty search results page.

```JavaScript

// retrieve contact record
Microsoft.CIFramework.searchAndOpenRecords("contact", "?$select=fullname,telephone1", false ).
then(
    function success(result) { 
    res=JSON.parse(result);
        console.log(`Record values: Full Name: ${res[0].fullname}, Telephone Number: ${res[0].telephone1}`);
        // perform operations on record retrieval and opening
    },
    function (error) {
        console.log(error.message);
        // handle error conditions
    }
);
```

### Search and display on the list of contact records

This sample code searches and displays the name and phone number of Contact entity records whose first name is **Contoso**. Using `$search` we can make sure that the search results page is populated with the search term **Contoso**.

> [!NOTE]
> If you are using `$search` in the query and the `searchOnly` parameter is set to `false`, it will always open the search results page and not the retrieved record. If you want to open the retrieved record, do not use `$search` parameter in the query.

```JavaScript

// Retrieve Contact entity record
// Change searchOnly parameter to true, if you do not want to open the search results page
Microsoft.CIFramework.searchAndOpenRecords("contact", "?$select=fullname,telephone1&$filter=firstname eq 'Contoso'&$search=Contoso", false ).
then(
    function success(result) {
    res=JSON.parse(result);
        console.log(`The caller name is: ${res[0].fullname}, Telephone Number: ${res[0].telephone1}`);
        // perform operations on record retrieval and opening
    },
    function (error) {
        console.log(error.message);
        // handle error conditions
    }
);
```

### Search and display top 10 active contact records

This sample code searches and displays the top 10 active contact records.

```JavaScript
Microsoft.CIFramework.searchAndOpenRecords("contact", "$filter=statecode eq 0&$select=description&$top=10", false ).
then(
    function success(result) { 
    res=JSON.parse(result);
        // perform operations on record retrieval and opening
    },
    function (error) {
        console.log(error.message);
        // handle error conditions
    }
);
```

### Search and display name and phone number by specifying the relevance search type

This sample code searches and displays the name and phone number of Contact entity records by specifying the relevance search type.

```JavaScript
Microsoft.CIFramework.searchAndOpenRecords("contact", "?$select=fullname,telephone1", false, 0 ).
then(     
    function success(result) {     
    res=JSON.parse(result);         
    console.log(`Record values: Full Name: ${res[0].fullname}, Telephone Number: ${res[0].telephone1}`);         
       // perform operations on record retrieval and opening 
    },     
    function (error) {         
        console.log(error.message);         
        // handle error conditions     
    } 
);
```


[!INCLUDE[footer-include](../../../../../includes/footer-banner.md)]
