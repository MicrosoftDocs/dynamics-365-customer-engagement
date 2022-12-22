---
title: "Create a real-time marketing segment using the Web API (Dynamics 365 Marketing) | Microsoft Docs"
description: "Learn how to create a real-time marketing segment using the Web API."
ms.date: 12/21/2022
ms.custom: 
  - dyn365-marketing
ms.topic: article
author: alfergus
ms.author: alfergus
manager: shellyha
search.audienceType: 
  - admin
  - customizer
  - enduser
search.app: 
  - D365CE
  - D365Mktg
---

# Create a real-time marketing segment using the Web API

You can create a real-time marketing segment using the Web API by following the same approach you would to [create any entity in a Power App](/power-apps/developer/data-platform/webapi/create-entity-web-api#basic-create). You need to create two entities when creating a real-time marketing segment: **msdynmkt_segmentdefinitions** and **msdynmkt_segments**. The following article shows how to create these entities.

## Create msdynmkt_segmentdefinitions

**Request**

```http

POST [Organization URI]/api/data/v9.0/msdynmkt_segmentdefinitions HTTP/1.1
Content-Type: application/json; charset=utf-8
OData-MaxVersion: 4.0
OData-Version: 4.0
Accept: application/json

{
    "msdynmkt_disablesegmentrefresh": true, 
    "msdynmkt_segmentquery": "<the segment filter query>",
    // Separate GUIDs by a comma
    "msdynmkt_includedmembers": "<member GUID>", 
    "msdynmkt_excludedmembers": "<member GUID>",
    // Draft 723270001, GoingLive 723270002, Live 723270000
    "statuscode": 723270001,
    // Active
    "statecode": 0,

}
```

 **Response**

```http

HTTP/1.1 204 No Content
OData-Version: 4.0
OData-EntityId: [Organization URI]/api/data/v9.0/msdynmkt_segmentdefinitions(<segment definition ID>)

```

After you create the segment definition, you'll need to create the segment entity which will add details linked to the segment definition.

## Create msdynmkt_segments

**Request**

```http

POST [Organization URI]/api/data/v9.0/msdynmkt_segments  HTTP/1.1 
Content-Type: application/json; charset=utf-8
OData-MaxVersion: 4.0
OData-Version: 4.0
Accept: application/json

{
    "msdynmkt_displayname": "<display name>", 
    // SegmentType: 10: static; 11: dynamic
    "msdynmkt_type": 10,  
    // RealTimeMarketingSource 12
    "msdynmkt_source": 12,
    "msdynmkt_baseentitylogicalname": "contact", 
    // StateCode below 
    "statecode": 1,
    // SegmentStatusCode below: Inactive if segment definition is in *Draft* state; exporting if segment definition is in *Publishing* state
    "statuscode": 2,
    "msdynmkt_sourcesegmentuid": "<segment definition ID>", 
    // If any
    "owningbusinessunit@odata.bind": "/businessunits(<BU ID>)",
}
```

 **Response**

```http

HTTP/1.1 204 No Content
OData-Version: 4.0
OData-EntityId: [Organization URI]/api/data/v9.0/msdynmkt_segments(<segment ID>)

```

```
StateCode {
    active = 0,
    inactive = 1
}

SegmentStatusCode {
    active = 1,
    inactive = 2,
    error = 3,
    deleted = 4,
    exporting = 5
}
```