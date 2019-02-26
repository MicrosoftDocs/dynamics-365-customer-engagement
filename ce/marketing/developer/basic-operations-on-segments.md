---
title: "Basic Operations on Segments using API| Microsoft Docs" # Intent and product brand in a unique string of 43-59 chars including spaces
description: The Segmentation API enables programmatic interaction with certain segmentation features of Dynamics 365 for Marketing App."" # 115-145 characters including spaces. This abstract displays in the search result.
ms.custom: ""
ms.date: 03/01/2019
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

# Basic Operations on Segments using Segmentation API

[!INCLUDE[cc-beta-prerelease-disclaimer](../../includes/cc-beta-prerelease-disclaimer.md)]

A market segment is the collection of contacts that you target in a marketing campaign. In some cases, you'll simply target all the contacts you have, but in most cases, you'll choose who you want to target based on demographic or firmographic data and other considerations. More information [Working with segments](https://docs.microsoft.com/en-us/dynamics365/customer-engagement/marketing/segmentation-lists-subscriptions).

The Segmentation API enables programmatic interaction with segment records. The segmentation API leverages the standard Dynamics 365 API for manipulating entities or messages. More information [Dynamics 365 Web API](https://docs.microsoft.com/en-us/dynamics365/customer-engagement/developer/use-microsoft-dynamics-365-web-api)

> [!IMPORTANT]

> - Segmentation API is a preview feature.
> - [!INCLUDE[cc_preview_features_definition](../../includes/cc-preview-features-definition.md)] 
> - [!INCLUDE[cc_preview_features_no_MS_support](../../includes/cc-preview-features-no-ms-support.md)]

When you create a segment, the properties of the segment are stored in `msdyncrm_segment` entity. You can browse the entity metadata information using `@odata.context`in `GET` response.

> [!NOTE]
> Before you perform operations, you should install Dynamics 365 for Marketing app.

This topic demonstrates how to perform basic operation on the `msdyncrm_segment` entity. You need to pass the following mandatory fields in order to create a segment.

|Display Name|Schema Name|Value|Required|
|----------|--------------|------|-------|
|Name|msdyncrm_segmentname|Name of the segment|Yes|
|Segment Type|msdyncrm_segmenttype|Type of segment. There are 3 types of segments:<br /> - static `192350001`<br />- Dynamic `192350000`<br >- Compound `192350002`|Yes|
|Status Reason|statuscode|Current status of the segment. Following are the available statu codes: <br /> - Draft `192350000`<br /> - Live `192350001`<br /> - Stopped `192350002`<br /> - GoingLive `192350006`<br /> - Stopping `192350007`|Yes|
|Segment Query|msdyncrm_segmentquery|Query in segmentation query|Yes (only for dynamic and compounbd segements)|

To test the operations you can use **Postman** tool. More information [Use Postman with Web API](https://docs.microsoft.com/en-us/dynamics365/customer-engagement/developer/webapi/use-postman-perform-operations)

## CRUD operations on static segments

This section shows how to perform basic CRUD (create, update, retrieve and delete) operations on static segments.

1. **Create request**

This request creates a new static segment with two contacts and `statuscode` set to `draft`. The response header contains the `URL` to this newly created record (entity instance), which parenthetically includes the `unique ID (segmentID)` for this record.

> [!IMPORTANT]
> You need to replace the `OrgUrl` with `https://<add your environment name, like ‘myorg.crm’>.dynamics.com`. You can also get the environment name from **Settings** -> **Customizations** -> **Developer Resources**.

```HTTP
POST {{OrgUrl}}/api/data/v9.0/msdyncrm_segments
{
  "msdyncrm_segmentname": "StaticSegmentApi1",
  "msdyncrm_segmenttype": 192350001,
  "msdyncrm_segmentmemberid": "[\"crm1405f4ba-1ee9-e811-a99d-000d3a35f12f\",\"crm0604cdd1-1ee9-e811-a99d-000d3a35f12f\"]",
  "statuscode": 192350000
}
```

> [!Important]
> The purpose of the “crm” prefix is to unambiguously indicate the type of the record identifier. This is required when you are using a legacy Segmentation solution (DCI Segmentation) which by default uses another type of identifier.

2. **Update request**

In the update request, you will update the `statuscode` of the static segment to `Going Live (192350006)`, when the request is executed it updates the `statuscode`to `Live`.

```HTTP
PATCH {{OrgUrl}}/api/data/v9.0/msdyncrm_segments({{SegmentId}})
{
  "statuscode": 192350006
}
```

3. **Retrieve request**

In the retrieve request, you will retrieve all the static segments that are in `Live` state.

```HTTP
GET {{orgUrl}}/api/data/v9.0/msdyncrm_segment?$filter=statuscode eq 192350001
```

You can also retrieve the segments with specific properties.

```HTTP
GET {{orgUrl}}/api/data/v9.0/msdyncrm_segments?$select=msdyncrm_segmentid,msdyncrm_segmentname,msdyncrm_segmentquery,msdyncrm_description
```

4. **Delete request**

In the delete request, you will delete the created static segment. 

```HTTP
DELETE {{orgUrl}}/api/data/v9.0/msdyncrm_segments({{SegmentId}})
```

## CRUD operations on dynamic segments

This section shows how to perform basic CRUD (create, update, retrieve and delete) operations on dynamic segments.

1. **Create request**

This request creates a dynamic segment and set the `statuscode` to `Live`.

```HTTP
POST {{orgUrl}}/api/data/v9.0/msdyncrm_segments
{
    "msdyncrm_segmentname": "MySegment2",
    "msdyncrm_segmentquery": "PROFILE(contact)",
    "msdyncrm_segmenttype": 192350000,
    "statuscode": 192350001
}
```

2. **Update request**

In the update request, you will update the status of the dynamic segment to `Stop`.

```HTTP
PATCH {{orgUlr}}/api/data/v9.0/msdyncrm_segments({{SegmentId}})
{
    "statuscode": 192350002
}
```

3. **Retrieve request**

In the retrieve request, you will retrieve all the dynamic segments that are in `Stop` state. 

```HTTP
GET {{orgUlr}}/api/data/v9.0/msdyncrm_segments?$filter=statuscode eq 192350002
```

4. **Delete request**

In the delete request, you will delete the dynamic segment that is created.

```HTTP
DELETE {{orgUlr}}/api/data/v9.0/msdyncrm_segments({{SegmentId}})
```

### CRUD operations on compound segments

This section shows how to perform basic CRUD (create, update, retrieve and delete) operations on compound segments.

1. **Create request**

This request creates a compound segment and set the `statuscode` to `Live`.

```HTTP
POST {{orgUrl}}/api/data/v9.0/msdyncrm_segments
{
    "msdyncrm_segmentname": "my_compound_segment1",
    "msdyncrm_segmenttype": 192350002,
    "msdyncrm_segmentquery":"SEGMENT(segment1) UNION SEGMENT(segment2)",
    "statuscode": 192350001
}
```

2. **Update request**

In the update request, you will update the status of the compound segment to `Stop`.

```HTTP
PATCH {{orgUlr}}/api/data/v9.0/msdyncrm_segments({{SegmentId}})
{
    "statuscode": 192350002
}
```

3. **Retrieve request**

In the retrieve request, you will retrieve all the compound segments that are in `Stop` state.

```HTTP
GET {{orgUlr}}/api/data/v9.0/msdyncrm_segments?$filter=statuscode eq 192350002
```

4. **Delete request**

In the delete request, you will delete the compound segment that is created.

```HTTP
DELETE {{orgUlr}}/api/data/v9.0/msdyncrm_segments({{SegmentId}})
```

## Include/exclude segment members

Members can be added to or removed from segments. As these operations go beyond a simple add/remove for segment they are referred to as `Include/Exclude`.

Include/exclude operations can be performed through the API by posting messages of the following types:

- `msdyncrm_IncludeMemberInSegment`
- `msdyncrm_IncludeMembersInSegment`
- `msdyncrm_ExcludeMemberFromSegment`
- `msdyncrm_ExcludeMembersFromSegment`

Dynamic and compound segments are based on segment query. Records matching the query become segment members. For static segments, the `Include/Exclude` operations have a more straight-forward semantics of adding or removing segment members.

Including a record makes it a member of the segment whether it satisfies the segmentation query or not. Including a record which is already a segment member will assure that it is not removed when it doesn't match the segmentation query.

Excluding a record removes it from the segment members and prevents it from being added again, even if the record matches the segmentation query. A record can be excluded from a segment without previously being a member of the segment to prevent it from becoming a member.

Once a member is included, action can be reversed by excluding it, thereby removing and preventing it from becoming a member. Similarly, excluding a member can be reversed by including it, thereby making it a member unconditionally.

Following are some of the important aspects that needs to be considered while performing `Include/Exclude`  operations on segment members:

- Dynamic and compound segments must be in `Live` or `Stopped` state (not draft).
- Only instances of entity type `Contact` can be included/excluded as members.
- All included/excluded records should exist, otherwise the request gets rejected.
- `Include/Exclude` feature is supported only by new Segmentation (not by DCI Segmentation).
- `Include/Exclude` member request is processed asynchronously independent of any recurring segment evaluations.
- Any `Include/Exclude` operation resulting in an actual update to segment members is recorded in `Segment Insights`.
- When including or excluding multiple records, use the plural endpoints for faster processing.
- You can add up to 10000 contacts to `msdyncrm_segmentmemberid` field.

**Add a segment member**

```HTTP
POST {{orgUlr}}/api/data/v9.0/msdyncrm_IncludeMemberInSegment
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
   msdyncrm_segmentmemberids: "[\"B5672BDB-8899-43CB-9FA1-0AE4DC61DAD3\", \"694E1C8E-F704-4B23-9B07-E65DB1620E47\", \"A4A31E3D-DFCA-4765-8018-3BA7D5E376C7\"]"
}
```

**Remove a segment member**

```HTTP
POST {{orgUlr}}/api/data/v9.0/msdyncrm_ExcludeMemberFromSegment
{
    msdyncrm_segmentid: "59AC8BBF-57E7-E811-A9A9-000D3A35F403",
    msdyncrm_segmentmemberid: "B5672BDB-8899-43CB-9FA1-0AE4DC61DAD3"
```

**Remove multiple segment members**

```HTTP
Remove multiple segment members
POST {{orgUlr}}/api/data/v9.0/msdyncrm_ExcludeMembersFromSegment
{
   msdyncrm_segmentid: "59AC8BBF-57E7-E811-A9A9-000D3A35F403",
   msdyncrm_segmentmemberids: "[\"B5672BDB-8899-43CB-9FA1-0AE4DC61DAD3\", \"694E1C8E-F704-4B23-9B07-E65DB1620E47\", \"A4A31E3D-DFCA-4765-8018-3BA7D5E376C7\"]" 
}
```
