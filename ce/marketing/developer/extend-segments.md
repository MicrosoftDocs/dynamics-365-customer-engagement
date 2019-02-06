---
title: "Extend Segments using API| Microsoft Docs" # Intent and product brand in a unique string of 43-59 chars including spaces
description: The Segmentation API enables programmatic interaction with certain segmentation features of Dynamics 365 for Marketing App."" # 115-145 characters including spaces. This abstract displays in the search result.
ms.custom: ""
ms.date: 2/07/2019
ms.reviewer: ""
ms.service: "D365CE"
ms.topic: "article"
author: "nkrb" # GitHub ID
ms.author: "nabuthuk" # MSFT alias of Microsoft employees only
manager: "kvivek" # MSFT alias of manager or PM counterpart
search.audienceType: 
  - developer
search.app: 
  - PowerApps
  - D365CE
---

# Extend Segments using Segmentation API

A market segment is the collection of contacts that you target in a marketing campaign. In some cases, you'll simply target all the contacts you have, but in most cases, you'll choose who you want to target based on demographic or firmographic data and other considerations. More information [Working with segments]().

The Segmentation API enables programmatic interaction with certain segmentation features of Dynamics 365 for Marketing App.
The segmentation API leverages the standard Dynamics 365 API for manipulating entities or messages. More information [Dynamics 365 Web API](https://docs.microsoft.com/en-us/dynamics365/customer-engagement/developer/use-microsoft-dynamics-365-web-api)

When you create a segment, the properties of the segment are stored in `msdyncrm_segment` entity. You can browse the entity metadata for available properties and optionset value mapping. You can get the metadata information by using `@odata.context`in `GET` response. 

> [!NOTE]
> Before you perform operations, you should install Dynamics 365 for Marketing app. 

This topic demonstrates how to perform basic operation on the `msdyncrm_segment` entity. You need to pass the following mandatory fields in order to create a segment.

|Display Name|Schema Name|
|----------|--------------|
|Name|msdyncrm_segmentname|
|Segment Type|msdyncrm_segmenttype|
|Status Reason|statuscode|

> [!NOTE]
> You need to also pass `Segment Query` when creating Dynamic and Compound segments.

To test the operations you can use Postman tool. More information [Use Postman with Web API](https://docs.microsoft.com/en-us/dynamics365/customer-engagement/developer/webapi/use-postman-web-api)

## CRUD operations on static segments

This example shows how to create, update, retrieve and delete static segments.

**Create Request**

In create request, you will create a new static segment which is in draft state.

```HTTP
POST {{OrgUrl}}/api/data/v9.0/msdyncrm_segments
{
  "msdyncrm_segmentname": "StaticSegmentApi1",
  "msdyncrm_segmenttype": 192350001,
  "statuscode": 192350000
}
```
**Update Request**

In update request, you will change the `status` of the created draft static segment to `Live` and add 2 segment members.

```HTTP
PATCH {{OrgUrl}}/api/data/v9.0/msdyncrm_segments({{SegmentId}})
{
  "msdyncrm_segmentmemberid": "[\"crm1405f4ba-1ee9-e811-a99d-000d3a35f12f\",\"crm0604cdd1-1ee9-e811-a99d-000d3a35f12f\"]",
  "statuscode": 192350001
}
```
> [!Important]
> The purpose of the “crm” prefix is to unambiguously indicate the type of the record identifier. This is required when you are using a legacy Segmentation solution (DCI Segmentation) which by default uses another type of identifier.

**Retrieve Request**

In retrieve request, you will retrieve the draft static segment that is created.

```HTTP
GET {{orgUrl}}/api/data/v9.0/msdyncrm_segments(23fa0663-6fe2-e811-a989-000d3a135be0)
```
You can also retrieve all the segments with specific properties.

```HTTP
GET {{orgUrl}}/api/data/v9.0/msdyncrm_segments?$select=msdyncrm_segmentid,msdyncrm_segmentname,msdyncrm_segmentquery,msdyncrm_description
```

**Delete Request**

In the delete request, you will delete the created draft static segment. 

```HTTP
DELETE {{orgUrl}}/api/data/v9.0/msdyncrm_segments(23fa0663-6fe2-e811-a989-000d3a135be0)
```

## CRUD operations on dynamic segments

This example shows how to create, update, retrieve and delete dynamic segments.

**Create Request**

In create request, you will create a dynamic segment and go-live at same time.

```HTTP
POST {{orgUrl}}/api/data/v9.0/msdyncrm_segments
{
    "msdyncrm_segmentname": "MySegment2",
    "msdyncrm_segmentquery": "PROFILE(contact)",
    "msdyncrm_segmenttype": 192350000,
    "statuscode": 192350001
}
```
**Update Request**

In update request, you will change the status of the dynamics segment to `Stop`.

```HTTP
PATCH {{orgUlr}}/api/data/v9.0/msdyncrm_segments(7649566b-79e2-e811-a989-000d3a135be0)
{
    "statuscode": 192350002
}
```
**Retrieve Request**

In retrieve request, you will retrieve the dynamic segment that is created. 

```HTTP
GET {{orgUlr}}/api/data/v9.0/msdyncrm_segments(7649566b-79e2-e811-a989-000d3a135be0)
```

**Delete Request**

In delete request, you will delete the dynamics segment that is created.

```HTTP
DELETE {{orgUlr}}/api/data/v9.0/msdyncrm_segments(7649566b-79e2-e811-a989-000d3a135be0)
```

### CRUD operations on compound segments

This example shows how to create, update, retrieve and delete compound segments.

**Create Request**

In create request, you will create a compound segment and go-live at same time.

```HTTP
POST {{orgUrl}}/api/data/v9.0/msdyncrm_segments
{
    "msdyncrm_segmentname": "my_compound_segment1",
    "msdyncrm_segmenttype": 192350002,
    "msdyncrm_segmentquery":"SEGMENT(segment1) UNION SEGMENT(segment2)",
    "statuscode": 192350001
}
```
**Update Request**

In update request, you will change the status of the compound segment to `Stop`.

```HTTP
PATCH {{orgUlr}}/api/data/v9.0/msdyncrm_segments(fb42b289-c34f-4f5f-8e43-8e38315d49c8)
{
    "statuscode": 192350002
}
```
**Retrieve Request**

In retrieve request, you will retieve the compound segment that is created. 

```HTTP
GET {{orgUlr}}/api/data/v9.0/msdyncrm_segments(fb42b289-c34f-4f5f-8e43-8e38315d49c8)
```

**Delete Request**

In delete request, we will delete the compound segment that is created.

```HTTP
DELETE {{orgUlr}}/api/data/v9.0/msdyncrm_segments(fb42b289-c34f-4f5f-8e43-8e38315d49c8)
```


### Validate segment definition

```
{
    "msdyncrm_segmentname": "MySegment2",
    "msdyncrm_segmentquery": "PROFILE(contact)",
    "msdyncrm_segmenttype": 192350000,
    "statuscode": 192350001
}
```
## Add/remove segment members

Members can be added to or removed from segments, both static and dynamic. As these operations go beyond a simple add/remove for dynamic segment they are referred to as `Include/Exclude`.

Include/exclude operations can be performed through the API by posting messages of the following types:

- `msdyncrm_IncludeMemberInSegment`
- `msdyncrm_IncludeMembersInSegment`
- `msdyncrm_ExcludeMemberFromSegment`
- `msdyncrm_ExcludeMembersFromSegment`

**Include/Exclude endpoints**

```HTTP

POST {{orgUlr}}/api/data/v9.0/msdyncrm_ExcludeMemberFromSegment
POST {{orgUlr}}/api/data/v9.0/msdyncrm_ExcludeMembersFromSegment
POST {{orgUlr}}/api/data/v9.0/msdyncrm_IncludeMemberInSegment
POST {{orgUlr}}/api/data/v9.0/msdyncrm_IncludeMembersInSegment
```

**Add one segment member**

```HTTP
POST {{orgUlr}}/api/data/v9.0/msdyncrm_IncludeMembersInSegment
{
	msdyncrm_segmentid: "59AC8BBF-57E7-E811-A9A9-000D3A35F403",
	msdyncrm_segmentmemberid: "B5672BDB-8899-43CB-9FA1-0AE4DC61DAD3"
}
```

**Add multiple segment members**

```HTTP
POST {{orgUlr}}/api/data/v9.0/msdyncrm_IncludeMembersInSegment
{ 
   msdyncrm_segmentid: "59AC8BBF-57E7-E811-A9A9-000D3A35F403",
   msdyncrm_segmentmemberid: "[\"B5672BDB-8899-43CB-9FA1-0AE4DC61DAD3\", \"694E1C8E-F704-4B23-9B07-E65DB1620E47\", \"A4A31E3D-DFCA-4765-8018-3BA7D5E376C7\"]" 
}
```

**Remove one segment member**

```HTTP
POST {{orgUlr}}/api/data/v9.0/msdyncrm_ExcludeMemberFromSegment 
{ 
    msdyncrm_segmentid: "59AC8BBF-57E7-E811-A9A9-000D3A35F403", 
    msdyncrm_segmentmemberid: "B5672BDB-8899-43CB-9FA1-0AE4DC61DAD3" 
}
```

**Remove multiple segment members**

```HTTP
Remove multiple segment members
POST {{orgUlr}}/api/data/v9.0/msdyncrm_ExcludeMembersFromSegment
{ 
   msdyncrm_segmentid: "59AC8BBF-57E7-E811-A9A9-000D3A35F403",
   msdyncrm_segmentmemberid: "[\"B5672BDB-8899-43CB-9FA1-0AE4DC61DAD3\", \"694E1C8E-F704-4B23-9B07-E65DB1620E47\", \"A4A31E3D-DFCA-4765-8018-3BA7D5E376C7\"]" 
}
```

## Include/exclude dynamic segment members

Dynamic and compound segments are based on a query. Records matching this query becomes segment members. For static segments, the include/exclude operations have a more straight-forward semantics of adding or removing segment members.

Including a record makes it a member of a segment whether it satisfies the segmentation query or not. Including a record which is already a segment member will assure it is not removed when it stops matching the segmentation query. 

Excluding a record effectively removes it from segment members and prevents it from being added again even if the record matches the segmentation query. A record can be excluded from a segment without previously being a member of this segment to prevent it from becoming one.

Once a member has been included this action can be inverted by excluding it, thereby removing it and preventing it from becoming a member in the future. Similarly, excluding a member can be inverted by including it, thereby making it a member unconditionally.

Following are some of the important aspects that needs to be considered while including/excluding segment members:

- Dynamic and compound segments must be in `Live` or `Stopped` state (not draft).
- Only instances of entity type `Contact` can be included/excluded.
- All included/excluded records must exist, otherwise the whole request gets reject.
- Feature is supported only by New Segmentation (not by DCI Segmentation).
- Include/exclude member request is processed asynchronously independent of any recurring segment evaluations.
- Any include/exclude operation resulting in an actual update to segment members is recorded in `Segment Insights`.
- When including or excluding multiple records, preferably use the plural endpoints for faster processing.
-  You can upto 10000 contacts to `msdyncrm_segmentmemberid` field.

