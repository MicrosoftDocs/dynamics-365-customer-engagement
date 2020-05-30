## Syntax

`Microsoft.CIFramework.searchAndOpenRecords(entityLogicalName, queryParameters, searchOnly).then(successCallback, errorCallback);`

## Parameters

| Name | Type | Required | Description |
|------|------|----------|-------------|
| entityLogicalName | String | Yes | Name of the entity to search and open. |
| queryParmeters | String | Yes | OData system query options, **$select** and **$expand**, to retrieve your data.<br><br> - Use the **$select** system query option to limit the properties returned by including a comma-separated list of property names. This is an important performance best practice. If properties aren’t specified using **$select**, all properties will be returned.<br><br> -  	Use the **$expand** system query option to control what data from related entities is returned. If you just include the name of the navigation property, you’ll receive all the properties for related records. You can limit the properties returned for related records using the **$select** system query option in parentheses after the navigation property name. Use this for both single-valued and collection-valued navigation properties.<br><br> You specify the query options starting with `?`. You can also specify multiple query options by using `&` to separate the query options.<br> For example: `?$select=name&$expand=primarycontactid($select=contactid,fullname) `|
| searchOnly | Boolean | Yes | Set false to open the record in the Unified Interface page if the search record is a single record. Set false to open search page if the search result has multiple records and auto populate the search page with the tag value mentioned when search field is used in queryParmeters.<br><br>Set true only to get results of the search as a promise result and not open the record or search page.|
| successCallback	| Function	| No	| A function to call when the request is successful. |
| errorCallback |	Function	| No	| A function to call when the request fails. |


## Return value

**Type:** String

**Description:** Returns Promise object containing string values. On success, returns the search results as per the search query.

## Remarks

When you set `searchOnly` as `true`, the contact entity records are searched to the get results as a promise object, and the record is not opened. Set `searchOnly` as `true` when the search displays a list of records based on the search context.

When you set `searchOnly` as `false`, the contact entity records are searched and the record is opened. Set the `searchOnly` as `false` when you want the search to display a single record based on the search context. If `searchOnly` parameter is set to `false`, it will open search page if the search result has multiple records and pre-populate the search page with the tag value mentioned when search field is used in queryParmeters.

## Examples

### Example 1: Search and open the contact record

This sample code searches the name and phone number of a contact record. It opens an empty search results page.

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

This sample code searches and displays the name and phone number of Contact entity records whose first name is **Contoso**. Using `$search` we can make sure that the search results page is pre-populated with the search term **Contoso**.

> [!NOTE]
> If you are using `$search` in the query and the `searchOnly` parameter is set to `false`, it will always open the search results page and not the retrieved record. If you want to open the retrieved record, do not use `$search` parameter in the query.

```JavaScript

// Retrieve Contact entity record
// Change searchonly parameter to true, if you do not want to open the search results page
Microsoft.CIFramework.searchAndOpenRecords("contact", "?$select=fullname,telephone1&$filter=firstname eq 'Contoso'&$search=Contoso", false ).then(
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