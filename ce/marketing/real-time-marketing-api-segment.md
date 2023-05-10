---
title: "Create a real-time marketing segment using the Web API (Dynamics 365 Marketing) | Microsoft Docs"
description: "Learn how to create a real-time marketing segment using the Web API."
ms.date: 05/10/2023
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

The segment definition represents a marketing segment or list of target customers. To create a segment definition entity, you need to send a POST request to the API endpoint:

`POST <Organization URL>/api/data/v9.0/msdynmkt_segmentdefinitions`

The <**Organization URL**> part should be replaced with the actual URL of the organization's API endpoint and <**SegmentDefinitionID**> should be replaced with the unique identifier of the segment definition that you want to update.

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

#### Description

The payload contains the following properties:

- **msdynmkt_segmentquery**: A string that defines the query used to define the segment.
- **statecode**: An integer value that indicates the state of the segment definition. The value can be one of the following:
    - 0 = Active
    - 1 = Inactive
- **statuscode**: An integer value that indicates the status of the segment definition. The value can be one of the following:
    - 723270000 = Live
    - 723270001 = Draft
    - 723270002 = Going live
    - 723270003 = Deleted
- **msdynmkt_includedmembers**: A string that contains a list of GUIDs of members that should be included in the segment.
- **msdynmkt_excludedmembers**: A string that contains a list of GUIDs of members that should be excluded from the segment.
- **msdynmkt_disablesegmentrefresh**: A boolean value that indicates whether automatic segment refreshing should be disabled.
- **msdynmkt_segmentrefreshintervalminutes**: An integer value that specifies the refresh interval in minutes.

#### Example request

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

Next, you need to create a new segment entity record. When you send the segment entity POST request to the Dynamics 365 Marketing API, it will create a new segment entity record in the specified organization, with the specified properties. The newly created segment can then be used for targeting and personalizing marketing activities based on the defined criteria.

`POST <Organization URL>/api/data/v9.0/msdynmkt_segments`

The URL for the POST request is <Organization URL>/api/data/v9.0/msdynmkt_segments. The <Organization URL> is the base URL for the Dynamics 365 Marketing organization where the segment entity will be created.

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

### Description

The properties included in the payload are:

- **msdynmkt_displayname**: A string that represents the name of the segment.
- **msdynmkt_type**: An integer that represents the type of the segment. The value can be one of the following:
    - 10 = Static segment
    - 11 = Dynamic segment
- **msdynmkt_source**: An integer that represents the source of the segment. For real-time marketing, the value should be the follow:
    - 12: Real-time marketing
- **msdynmkt_baseentitylogicalname**: A string that represents the type of member who will be in the segment.
- **statecode**: An integer that indicates the current status of the segment. The value can be one of the following:
    - 0 = Active
    - 1 = Inactive
- **statuscode**: An integer that indicates the reason why the segment is in its current state. The value can be one of the following:
    - 1 = Active
    - 2 = Inactive (if the segment definition is in Draft state)
    - 3 = Error
    - 4 = Deleted
    - 5 = Exporting (if the segment definition is in Publishing state)
- **msdynmkt_sourcesegmentuid**: A string that represents the unique identifier of the segment that the current segment is based on.
- **owningbusinessunit@odata.bind**: (Optional) A string that represents the reference to the business unit that owns the segment.

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
> As of the publish date of this article, real-time marketing only supports Contacts and Leads.

### Response

```http

HTTP/1.1 204 No Content
OData-Version: 4.0
OData-EntityId: <Organization URL>/api/data/v9.0/msdynmkt_segments(<Segment ID>)

```

## Publish

This is an API request to publish a marketing segment definition in Microsoft Dynamics 365 Marketing.

`POST <Organization URL>/api/data/v9.0/msdynmkt_PublishSegmentDefinition`

The API request is sent via HTTP POST to the API endpoint and the API method (msdynmkt_PublishSegmentDefinition) specified in the URL.

### Payload:

```
{
    "SegmentId": "<Segment ID>"
}
```

### Description

The request payload contains a JSON object that includes the "SegmentId" field. You need to replace "<Segment ID>" with the actual ID of the marketing segment that you want to publish.

When this request is sent to the Dynamics 365 Marketing server, it will validate the payload and publish the specified segment definition if it is valid. This will make the segment available for use in marketing activities such as customer journeys, email campaigns, and events. This API helps in automating and streamlining your marketing processes.

## View members

This API request is used to view the members of a marketing segment in Dynamics 365 Marketing.

`POST: <Organizaiton URL>/api/data/v9.0/msdynmkt_MembersList`

The API request is sent via HTTP POST to the API endpoint and the API method (msdynmkt_MembersList) specified in the URL.

### Payload

```
{
    "SegmentId: "<segment definition ID>"
}
```

### Description

The request payload contains a JSON object with the ID of the segment definition that you want to view the members for. You need to replace <Organization URL> with the actual URL of your Dynamics 365 Marketing organization, and <segment definition ID> with the ID of the segment that you want to view members for.

When the API request is received, it validates the payload and return a response containing the list of members for the specified segment definition. This API is useful to get insights into the composition of a segment and to troubleshoot any issues related to the segment membership.

The response to the API request will include a JSON object containing the list of members along with their details.

### Response

```http
{
    "@odata.context": "<Organizaiton URL>/api/data/v9.0/$metadata#Microsoft.Dynamics.CRM.msdynmkt_MembersListResponse",
    "StatusCode": 200,
    "ResultText": "{\"baseEntityLogicalName\":\"contact\",\"primaryKeyColumnName\":\"contactid\",\"members\":[\"<member GUID>, <member GUID>"],\"additionalProperties\":{}}"
}
```

[!INCLUDE[footer-include](../includes/footer-banner.md)]