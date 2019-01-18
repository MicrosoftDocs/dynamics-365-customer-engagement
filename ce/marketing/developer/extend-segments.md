---
title: "Extent Segments using API| Microsoft Docs" # Intent and product brand in a unique string of 43-59 chars including spaces
description: The Segmentation API enables programmatic interaction with certain segmentation features of Dynamics 365 for Marketing App."" # 115-145 characters including spaces. This abstract displays in the search result.
ms.custom: ""
ms.date: 1/17/2019
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
The segmentation API leverages the standard Dynamics 365 API for manipulating entities / messages. More information [Dynamics 365 Web API](https://docs.microsoft.com/en-us/dynamics365/customer-engagement/developer/use-microsoft-dynamics-365-web-api)

When you create a segment, the properties of the segment are stored in `msdyncrm_segment` entity. You can browse the entity metadata for available properties and optionset value mapping. You can get the metadata information by using `@odata.context`in `GET` response. 

This topic demonstrates how to perform basic operation on the `msdyncrm_segment` entity. 
 
## CRUD Operations

### CRUD operations static segment
This example shows how to create, update, retrieve and delete a static segment with 2 contacts

**Create Request**

In create request, we will create a new draft static segment with 2 contacts.

```HTTP
POST {{OrgUrl}}/api/data/v9.0/msdyncrm_segments
{
	"msdyncrm_segmentname": "StaticSegmentApi1",
	"msdyncrm_segmenttype": 192350001,
	"msdyncrm_segmentmemberids": "[\"crm1405f4ba-1ee9-e811-a99d-000d3a35f12f\",\"crm0604cdd1-1ee9-e811-a99d-000d3a35f12f\"]",
	"statuscode": 192350000
}
```
**Update Request**

In update request, we will change the `status` of the created draft segment to `Go live`.

```HTTP
PATCH {{OrgUrl}}/api/data/v9.0/msdyncrm_segments({{SegmentId}})
{
	"statuscode": 192350001
}
```

**Retrieve Request**
In retrieve rquest, we will retrieve the draft segment that is created.

```HTTP
GET {{orgUrl}}/api/data/v9.0/msdyncrm_segments(23fa0663-6fe2-e811-a989-000d3a135be0)
```

**Delete Request**

In the delete request, we will delete the created draft segment. 

```HTTP
DELETE {{orgUrl}}/api/data/v9.0/msdyncrm_segments(23fa0663-6fe2-e811-a989-000d3a135be0)
```

### CRUD operations dynamic segment

**Create Request**

In create request, we will create a dynamic segment and go-live at same time.

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

In update request, we will change the status of the dynamics segment to `Stop`.

```HTTP
PATCH {{orgUlr}}/api/data/v9.0/msdyncrm_segments(7649566b-79e2-e811-a989-000d3a135be0)
{
    "statuscode": 192350002
}
```
**Retrieve Request**

In retrieve request, we will get the dynamic segment that is created. 

```HTTP
GET {{orgUlr}}/api/data/v9.0/msdyncrm_segments(7649566b-79e2-e811-a989-000d3a135be0)
```

**Delete Request**

In delete request, we will delete the dynamics segment that is created.

```HTTP
DELETE {{orgUlr}}/api/data/v9.0/msdyncrm_segments(7649566b-79e2-e811-a989-000d3a135be0)
```


### Validate segment definition

{
    "msdyncrm_segmentname": "MySegment2",
    "msdyncrm_segmentquery": "PROFILE(contact)",
    "msdyncrm_segmenttype": 192350000,
    "statuscode": 192350001
}
```
### Add/remove segment members

Members can be added to or removed from segments, both static and dynamic. As these operations go beyond a simple add/remove for dynamic segment they are referred to as `Include/Exclude`.

Include/exclude operations can be performed through the Dynamics 365 API by posting messages of the following types:

- `msdyncrm_IncludeMemberInSegment`
- `msdyncrm_IncludeMembersInSegment`
- `msdyncrm_ExcludeMemberFromSegment`
- `msdyncrm_ExcludeMembersFromSegment`

**Include/Exclude endpoints**

```HTTP

POST /api/data/v9.0/msdyncrm_ExcludeMemberFromSegment
POST /api/data/v9.0/msdyncrm_ExcludeMembersFromSegment
POST /api/data/v9.0/msdyncrm_IncludeMemberInSegment
POST /api/data/v9.0/msdyncrm_IncludeMembersInSegment
```

**Add one segment member**

```HTTP
POST /api/data/v9.0/msdyncrm_IncludeMembersInSegment
{
	msdyncrm_segmentid: "59AC8BBF-57E7-E811-A9A9-000D3A35F403",
	msdyncrm_memberids: "[\"B5672BDB-8899-43CB-9FA1-0AE4DC61DAD3\",\"694E1C8E-F704-4B23-9B07-E65DB1620E47\",\"A4A31E3D-DFCA-4765-8018-3BA7D5E376C7\"]"
}
```

**Add multiple segment members**

```HTTP
POST /api/data/v9.0/msdyncrm_IncludeMembersInSegment
{ 
   msdyncrm_segmentid: "59AC8BBF-57E7-E811-A9A9-000D3A35F403",
   msdyncrm_memberids: "[\"B5672BDB-8899-43CB-9FA1-0AE4DC61DAD3\", \"694E1C8E-F704-4B23-9B07-E65DB1620E47\", \"A4A31E3D-DFCA-4765-8018-3BA7D5E376C7\"]" 
}
```

**Remove one segment member**

```HTTP
POST /api/data/v9.0/msdyncrm_ExcludeMemberFromSegment 
{ 
    msdyncrm_segmentid: "59AC8BBF-57E7-E811-A9A9-000D3A35F403", 
    msdyncrm_memberid: "B5672BDB-8899-43CB-9FA1-0AE4DC61DAD3" 
}
```

**Remove multiple segment members**

```HTTP
Remove multiple segment members
POST /api/data/v9.0/msdyncrm_ExcludeMembersFromSegment
{ 
   msdyncrm_segmentid: "59AC8BBF-57E7-E811-A9A9-000D3A35F403",
   msdyncrm_memberids: "[\"B5672BDB-8899-43CB-9FA1-0AE4DC61DAD3\", \"694E1C8E-F704-4B23-9B07-E65DB1620E47\", \"A4A31E3D-DFCA-4765-8018-3BA7D5E376C7\"]" 
}
```

### Include/exclude segment members

Dynamic segments are based on a query. Records matching this query becomes segment members. Additionally, the segment members can be manually fine-tuned using include/exclude functionality.

Including a record makes it a member of a segment whether it satisfies the segmentation query or not. Including a record which already is a segment member will assure it is not removed even when it stops matching the segmentation query. Excluding a record effectively removes it from segment members and prevents it from being added again even if the record matches the segmentation query. A record can be excluded from a segment without previously being a member of this segment to prevent it from becoming one.

Once a member has been included this action can be inverted by excluding it and thereby removing it and preventing it from becoming a member in the future. Similarly, excluding a member can be inverted by including it and thereby making it a member unconditionally.

Following are some of the important aspects that needs to be considered while including/excluding dynamic segment members:

- Dynamic segment must be in `live` or `stopped` states (not draft).
- Only instances of entity type `Contact` can be included/excluded.
- All included/excluded records must exist, otherwise the whole request gets reject.
- Feature is supported only by New Segmentation (not by DCI Segmentation).
- Include/exclude member request is processed asynchronously independent of any recurring segment evaluations.
- Any include/exclude operation resulting in an actual update to segment members is recorded in `Segment Insights`.
- When including or excluding multiple records, preferably use the plural endpoints for faster processing.
- Include/exclude request size is controlled by limiting the `msdyncrm_memberids` request field length to 10000 characters.

### Include/exclude static segment members

For static segments, the include/exclude operations have a more straight-forward semantics of adding or removing segment members.

Following are some of the important aspects that needs to be considered while including/excluding dynamic segment members:

- Only instances of entity type "Contact" can be included/excluded.
- `sdyncrm_segmentid`input parameter checks.
  - valid GUID.
  - valid ID of an existing segment.
- `sdyncrm_memberids`input parameter checks.
  - format: single member GUID ID as string.
  - valid ID of an existing contact, ID may optionally be prefixed by "crm" (prefix is stripped during processing).
-`msdyncrm_memberid`input parameter checks.
  - format: serialized JSON array of member GUID IDs.
  - valid IDs of existing contacts. My be prefixed by “crm”.
- Feature is supported only by New Segmentation only.
- `sdyncrm_memberid(s)`parameter value is limited to 10000 characters.

