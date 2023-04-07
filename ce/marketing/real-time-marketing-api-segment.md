---
title: "Create a real-time marketing segment using the Web API (Dynamics 365 Marketing) | Microsoft Docs"
description: "Learn how to create a real-time marketing segment using the Web API."
ms.date: 01/10/2023
ms.custom: 
  - dyn365-marketing
ms.topic: article
author: alfergus
ms.author: alfergus
search.audienceType: 
  - admin
  - customizer
  - enduser
---

# Create a real-time marketing segment using the Web API

You can create a real-time marketing segment using the Web API following the same approach you would to [create any entity in a Power App](/power-apps/developer/data-platform/webapi/create-entity-web-api#basic-create). When creating a real-time marketing segment, you need to create two entities: **msdynmkt_segmentdefinitions** and **msdynmkt_segments**. The following article shows how to create these entities.

## Create a segment definition entity

`POST <Organization URL>/api/data/v9.0/msdynmkt_segmentdefinitions`

### Payload

```
{
    msdynmkt_segmentquery: string,
    statecode: StateCode,
    statuscode: SegmentDefinitionStatusCode,
    msdynmkt_includedmembers: string,
    msdynmkt_excludedmembers: string,
    msdynmkt_disablesegmentrefresh: boolean,
    msdynmkt_segmentrefreshintervalminutes: number
}
```

### Values

```
statecode { 
    active = 0, 
    inactive = 1 
} 

statuscode {
    live = 723270000,
    draft = 723270001,
    goingLive = 723270002,
    deleted = 723270003
}
```

### Example request

```http

POST <Organization URL>/api/data/v9.0/msdynmkt_segmentdefinitions HTTP/1.1
Content-Type: application/json; charset=utf-8
OData-MaxVersion: 4.0
OData-Version: 4.0
Accept: application/json

{
    "msdynmkt_segmentquery": "PROFILE(contact).FILTER(ISNOTNULL(address1_county))",
    "statecode": 0,
    "statuscode": 723270001,
    // Separate GUIDs by a comma
    "msdynmkt_includedmembers": "<member GUID>",
    // Separate GUIDs by a comma
    "msdynmkt_excludedmembers": "<member GUID>",
    "msdynmkt_disablesegmentrefresh": false,
    "msdynmkt_segmentrefreshintervalminutes": 15
}
```

### Response headers

```http

HTTP/1.1 204 No Content
OData-Version: 4.0
OData-EntityId: <Organization URL>/api/data/v9.0/msdynmkt_segmentdefinitions(<Segment definition ID>)

```

After you create the segment definition, you'll need to create the segment entity which will add details linked to the segment definition.

## Create a segment entity

`POST <Organization URL>/api/data/v9.0/msdynmkt_segments`

### Payload

```
{
    "msdynmkt_displayname": string,
    "msdynmkt_type": number,
    "msdynmkt_source": number,
    "msdynmkt_baseentitylogicalname": string,
    "statecode": number,
    "statuscode": number,
    "msdynmkt_sourcesegmentuid": string,
    "owningbusinessunit@odata.bind": string
}
```

### Values

Values:
```
msdynmkt_type {
    static = 10
    dynamic = 11
}

msdynmkt_source {
    RealTimeMarketing = 12
}

statecode { 
    active = 0, 
    inactive = 1 
} 

statuscode { 
    active = 1, 
    inactive = 2, 
    error = 3, 
    deleted = 4, 
    exporting = 5 
} 

```

### Example request

```http

POST <Organization URL>/api/data/v9.0/msdynmkt_segments HTTP/1.1
Content-Type: application/json; charset=utf-8
OData-MaxVersion: 4.0
OData-Version: 4.0
Accept: application/json

{
    "msdynmkt_displayname": "<display name>",
    "msdynmkt_type": 11,
    "msdynmkt_source": 12,
    // Set to contact, lead, or any custom table that
    // represents the type of member who will be in the segment.
    "msdynmkt_baseentitylogicalname": "contact",
    "statecode": 1,
    // Inactive if segment definition is in Draft state
    // Exporting if segment definition is in Publishing state
    "statuscode": 2,
    "msdynmkt_sourcesegmentuid": "<segment definition ID>",
    // If any (not required)
    "owningbusinessunit@odata.bind": "/businessunits(<BU ID>)",
}
```

> [!NOTE]
> As of the publish date of this article, real-time marketing only supports contacts and leads.

### Response

```http

HTTP/1.1 204 No Content
OData-Version: 4.0
OData-EntityId: <Organization URL>/api/data/v9.0/msdynmkt_segments(<Segment ID>)

```

## Publish

`POST <Organization URL>/api/data/v9.0/msdynmkt_PublishSegmentDefinition`

### Payload:

```
{
    "SegmentId": "<segment definition ID>"
}
```

## View members

`POST: <Organizaiton URL>/api/data/v9.0/msdynmkt_MembersList`

### Payload

```
{
    "SegmentId: "<segment definition ID>"
}
```

### Response

```http
{
    "@odata.context": "<Organizaiton URL>/api/data/v9.0/$metadata#Microsoft.Dynamics.CRM.msdynmkt_MembersListResponse",
    "StatusCode": 200,
    "ResultText": "{\"baseEntityLogicalName\":\"contact\",\"primaryKeyColumnName\":\"contactid\",\"members\":[\"<member GUID>, <member GUID>"],\"additionalProperties\":{}}"
}
```

[!INCLUDE[footer-include](../includes/footer-banner.md)]