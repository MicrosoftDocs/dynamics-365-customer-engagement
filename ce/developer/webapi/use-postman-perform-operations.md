---
title: "Use Postman to perform operations with Web API(Developer Guide for Dynamics 365 Customer Engagement)| MicrosoftDocs"
description: "Learn how to compose and send Web API requests using Postman."
ms.custom: ""
ms.date: 07/23/2018
ms.reviewer: ""
ms.service: "crm-online"
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: AB50128B-D8E3-47A3-A0F8-9594EF6B7022
caps.latest.revision: 7
author: "SushantSikka"
ms.author: "susikka"
manager: "sakudes"
---

# Use Postman to perform operations with Web API

Use Postman to compose and send Web API requests and view responses. This topic describes how to create Web API requests that perform CRUD operations and use functions and actions using Postman.

> [!IMPORTANT]
> You will need to have an environment created using the steps described in   [Setup a Postman environment](setup-postman-environment.md)

The environment created using the instructions in [Setup a Postman environment](setup-postman-environment.md), creates a `{{webapiurl}}`  Postman variable that provides the base URL for requests. Append to this variable to define the URL for your requests.

> [!IMPORTANT]
> Use the correct instructions to create your environment depending on your deployment type.
>
>    |Online|On-premises|
>    |--|--|
>    |[Connect with an Online environment](setup-postman-environment.md#bkmk_connectonline)|[Connect with an On-premise environment](setup-postman-environment.md#bkmk_connectonpremise)|


Depending on the type of operation you want to perform, you will use different HTTP methods and values. The following sections demonstrate common operations.

## Retrieve multiple records

Use a `GET` request to retrieve a set of records. The following example will retrieve the first three account records.

> [!NOTE]
> Web API requests should include certain HTTP headers. Every request should include the Accept header value of `application/json`, even when no response body is expected. The current OData version is `4.0`, so include header `OData-Version: 4.0`. Include the `OData-MaxVersion` header so that there is no ambiguity about version with new releases of OData. [!INCLUDE[](../../includes/proc-more-information.md)] [HTTP headers](compose-http-requests-handle-errors.md#http-headers).

**Example**


`GET` `{{webapiurl}}accounts?$select=name,accountnumber&$top=3`

![Retrieve multiple records using Postman](../media/postman-retrieve-multiple.png "Retrieve multiple records using Postman")

The body of the response will look like this:

```json
{
    "@odata.context": "https://yourorg.crm.dynamics.com/api/data/v9.0/$metadata#accounts(name,accountnumber)",
    "value": [
        {
            "@odata.etag": "W/\"2291741\"",
            "name": "Contoso Ltd",
            "accountnumber": null,
            "accountid": "9c706dc8-d2f5-e711-a956-000d3a328903"
        },
        {
            "@odata.etag": "W/\"2291742\"",
            "name": "Fourth Coffee",
            "accountnumber": null,
            "accountid": "a2706dc8-d2f5-e711-a956-000d3a328903"
        },
        {
            "@odata.etag": "W/\"2291743\"",
            "name": "Contoso Ltd",
            "accountnumber": null,
            "accountid": "9c3216b8-3efb-e711-a957-000d3a328903"
        }
    ]
}
```

More information: [Query data using the Web API](query-data-web-api.md).

## Retrieve a particular record

Use a `GET` request to retrieve a record. The following example will retrieve two properties from a specific account and expand information about the related primary contact to include their full name.


`GET` `{{webapiurl}}accounts(`*&lt;accountid&gt;*`)?$select=name,accountnumber&$expand=primarycontactid($select=fullname)`

![Retrieve a record using Postman](../media/postman-retrieve-record.png "Retrieve a record using Postman")

The body of the response will look like this:

```json
{
    "@odata.context": "https://yourorg.crm.dynamics.com/api/data/v9.0/$metadata#accounts(name,accountnumber,primarycontactid(fullname))/$entity",
    "@odata.etag": "W/\"2291742\"",
    "name": "Fourth Coffee",
    "accountnumber": null,
    "accountid": "a2706dc8-d2f5-e711-a956-000d3a328903",
    "primarycontactid": {
        "@odata.etag": "W/\"1697263\"",
        "fullname": "Susie Curtis",
        "contactid": "a3706dc8-d2f5-e711-a956-000d3a328903"
    }
}
```
More information: [Retrieve an entity using the Web API](retrieve-entity-using-web-api.md).

## Create a record

Use a `POST` request to send data to create a record. Set the URL to the entity set name for an entity, in this case, the account entity, and set the headers as shown below.

`POST` `{{webapiurl}}accounts`

![Create a new record using Web API](../media/postman-create-records.png "Create a new record using Web API")

Set the Body of the request with information about the account to create.

![Body of the request to create a record using Web API](../media/postman-create-record-body.png "Body of the request to create a record using Web API")

When you send this request, the body will be empty, but the ID of the created account will be in the **OData-EntityId** header value.

More information: [Create an entity using the Web API](create-entity-web-api.md).

## Update a record

Use `PATCH` method to update an entity record, as shown in the example below.

`PATCH` `{{webapiurl}}accounts(`*&lt;accountid&gt;*`)`

![Update a record using Web API](../media/postman-update-record.png "Update a record using Web API")

When you send this request, the response body will be empty, but the ID of the updated account will be in the **OData-EntityId** header value.

More information: [Update and delete entities using the Web API](update-delete-entities-using-web-api.md).

## Delete a record

Use `DELETE` method to delete an existing record.

`DELETE` `{{webapiurl}}accounts(`*&lt;accountid&gt;*`)`

![Delete a record using Web API](../media/postman-delete-record.png "Delete a record using Web API")

When you send this request, the account record with the given `accountid` gets deleted.

More information: [Update and delete entities using the Web API](update-delete-entities-using-web-api.md).

## Use a function

Use a `GET` request with functions listed in [Web API Function Reference](https://docs.microsoft.com/dynamics365/customer-engagement/web-api/functions?view=dynamics-ce-odata-9) to perform re-usable operations with the Web API. The below example shows how to send a Web API request that uses <xref href="Microsoft.Dynamics.CRM.RetrieveDuplicates?text=RetrieveDuplicates function" /> to detect and retrieve duplicates of a specified record.

|||
|----|----|
|`GET`|`{{webapiurl}}RetrieveDuplicates(BusinessEntity=@p1,MatchingEntityName=@p2,PagingInfo=@p3)?@p1={'@odata.type':'Microsoft.Dynamics.CRM.account','accountid':'`*&lt;accountid&gt;*`'}&@p2='account'&@p3={'PageNumber':1,'Count':50}`|

![Create a Web API request that uses functions](../media/postman-use-function.png "Create a Web API request that uses functions")

Functions return either a collection or a complex type. The response from the above <xref href="Microsoft.Dynamics.CRM.RetrieveDuplicates?text=RetrieveDuplicates function" /> should look like the following.

```json
{
        {
    "@odata.context": "https://yourorgname.crm.dynamics.com/api/data/v9.0/$metadata#accounts",
    "value": [
        <Omitted for brevity: JSON data for any matching accounts including all properties>
    ]
}
}
```

More information: [Use Web API functions](use-web-api-functions.md).

## Use an action

Use a `POST` request with actions listed in [Web API Action Reference](https://docs.microsoft.com/dynamics365/customer-engagement/web-api/actions?view=dynamics-ce-odata-9) to perform operations that have side-effects.

The below example shows how to use <xref href="Microsoft.Dynamics.CRM.BulkDetectDuplicates?text=BulkDetectDuplicates action" />.

`POST` `{{webapiurl}}BulkDetectDuplicates`

![Create a Web API request that uses actions](../media/postman-use-action.png "Create a Web API request that uses actions")

The above request submits an asynchronous duplicate detection job that runs in the background. The duplicates are detected according to the published duplicate rules for the entity type. <xref href="Microsoft.Dynamics.CRM.BulkDetectDuplicatesResponse?text=BulkDetectDuplicatesResponse ComplexType" /> is returned as a response from <xref href="Microsoft.Dynamics.CRM.BulkDetectDuplicates?text=BulkDetectDuplicates action" />. The response includes `JobId` property which contains the GUID of the asynchronous duplicate detection job that detects and logs duplicate records.

More information: [Use Web API actions](use-web-api-actions.md).

## See Also

[Use Postman with Web API](use-postman-web-api.md)<br>
[Perform operations with Web API](perform-operations-web-api.md)