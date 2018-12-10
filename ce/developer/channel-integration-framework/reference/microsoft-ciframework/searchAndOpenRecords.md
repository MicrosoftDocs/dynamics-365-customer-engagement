---
title: "searchAndOpenRecords (JavaScript API Reference) for Channel Integration Framework (CIF) in Dynamics 365 | Microsoft Docs"
description: ""
keywords: ""
ms.date: 10/12/2018
ms.service:
  - "dynamics-365-cross-app"
ms.custom:
  - "dyn365-a11y"
  - "dyn365-developer"
ms.topic: reference
applies_to:
  - "Dynamics 365 (online)"
  - "Dynamics 365 Version 9.x"
ms.assetid: 74ADE5B8-3EA0-4100-BC2C-52FFBB7956EE
author: kabala123
ms.author: kabala
manager: shujoshi
---

# searchAndOpenRecords (CIF JavaScript API Reference)

[!INCLUDE[searchAndOpenRecords](includes/searchAndOpenRecords-description.md)]

## Syntax

`Microsoft.CIFramework.searchAndOpenRecords(entityName, queryParameters, searchOnly).then(successCallback, errorCallback);`

## Parameters

| Name | Type | Required | Description |
|------|------|----------|-------------|
| entityName | String | Yes | Name of the entity to search and open. |
| queryParmeters | String | Yes | OData system query options, **$select** and **$expand**, to retrieve your data.<br><br> - Use the **$select** system query option to limit the properties returned by including a comma-separated list of property names. This is an important performance best practice. If properties aren’t specified using **$select**, all properties will be returned.<br><br> -  	Use the **$expand** system query option to control what data from related entities is returned. If you just include the name of the navigation property, you’ll receive all the properties for related records. You can limit the properties returned for related records using the **$select** system query option in parentheses after the navigation property name. Use this for both single-valued and collection-valued navigation properties.<br><br> You specify the query options starting with `?`. You can also specify multiple query options by using `&` to separate the query options.<br> For example: `?$select=name&$expand=primarycontactid($select=contactid,fullname) `|
| searchOnly | Boolean | Yes | Set false to open the record in the Unified Interface page if the search record is a single record. <br><br>Set true only to display the search and not open the record.|
| successCallback	| Function	| No	| A function to call when the request is successful. |
| errorCallback |	Function	| No	| A function to call when the request fails. |


## Return value

**Type:** String

**Description:** Returns Promise object containing string values. On success, returns the search results as per the search query.

## Remarks

When you set the query value as true, the contact is only searched but not opened. Set the query as true when the search displays a list of records based on the search context.

When you set the query value as false, the contact is searched and opened. Set the query as false when the search displays a single record based on the search context.

## Examples

### Example 1: Search and open the contact record

This sample code searches the name and telephone number of a contact and opens the contact record.

```JavaScript

// retrieve contact record
Microsoft.CIFramework.searchAndOpenRecords("contact", "?$select=fullname,telephone1", false ).then(
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

### Example 2: Search and display on the list of contact records

This sample code searches the name and phone number of a contact and opens the contact record.

```JavaScript

// retrieve contact record
// query = true, searches but do not open the record
Microsoft.CIFramework.searchAndOpenRecords("contact", "?$select=fullname,telephone1", true ).then(
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