---
title: "Basic Operations on segments using API| Microsoft Docs" # Intent and product brand in a unique string of 43-59 chars including spaces
description: The Segmentation API enables programmatic interaction with certain segmentation features of Dynamics 365 for Marketing app."" # 115-145 characters including spaces. This abstract displays in the search result.
ms.custom: ""
ms.date: 03/20/2019
ms.reviewer: ""
ms.service: D365CE
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

# Basic operations on segments using the Segmentation API

[!INCLUDE[cc-beta-prerelease-disclaimer](../../includes/cc-beta-prerelease-disclaimer.md)]

A market segment is the collection of contacts that you target in a marketing campaign. In some cases, you'll simply target all the contacts you have, but in most cases, you'll choose who you want to target based on demographic or firmographic data and other considerations. More information: [Working with segments](https://docs.microsoft.com/en-us/dynamics365/customer-engagement/marketing/segmentation-lists-subscriptions).

The Segmentation API enables programmatic interaction with segment records. The Segmentation API leverages the standard Dynamics 365 API for manipulating entities or messages. More information: [Dynamics 365 Web API](https://docs.microsoft.com/en-us/dynamics365/customer-engagement/developer/use-microsoft-dynamics-365-web-api).

> [!IMPORTANT]
> - The Segmentation API is a preview feature.
> - [!INCLUDE[cc_preview_features_definition](../../includes/cc-preview-features-definition.md)] 
> - [!INCLUDE[cc_preview_features_no_MS_support](../../includes/cc-preview-features-no-ms-support.md)]

When you create a segment, the properties of the segment are stored in the **msdyncrm_segment** entity. You can browse the entity metadata information using `@odata.context` in the **GET** response.

> [!NOTE]
> Before you perform operations, you should install the [Dynamics 365 for Marketing app](https://docs.microsoft.com/en-us/dynamics365/customer-engagement/marketing/trial-signup).

This topic demonstrates how to perform basic operation on the **msdyncrm_segment** entity. You need to pass the following mandatory fields in order to create a segment.

|Display name|Schema name|Value|Required|
|----------|--------------|------|-------|
|Name|msdyncrm_segmentname|Name of the segment.|Yes.|
|Segment Type|msdyncrm_segmenttype|Type of segment. There are 3 types of segments:<br /> - Static `192350001`<br />- Dynamic `192350000`<br >- Compound `192350002`|Yes.|
|Status Reason|statuscode|Current status of the segment. These are the available status codes: <br /> - Draft `192350000`<br /> - Live `192350001`<br /> - Stopped `192350002`<br /> - GoingLive `192350006`<br /> - Stopping `192350007`|Yes.|
|Segment Query|msdyncrm_segmentquery|Query in the segmentation query.|Yes (only for dynamic and compound segments).|

To test the operations, you can use the Postman tool. More information: [Use Postman with Web API](https://docs.microsoft.com/en-us/dynamics365/customer-engagement/developer/webapi/use-postman-perform-operations).

## CRUD operations on static segments

This section shows how to perform basic CRUD (create, update, retrieve, and delete) operations on static segments.

**Create request**

This request creates a new static segment with two contacts and `statuscode` set to “Draft”. The response header contains the URL to this newly created record (entity instance), which parenthetically includes the unique ID (**segmentID**) for this record.

> [!IMPORTANT]
> You need to replace `OrgUrl` with `https://<add your environment name, like ‘myorg.crm’>.dynamics.com`. You can also get the environment name from **Settings** -> **Customizations** -> **Developer Resources**.

```HTTP
POST {{OrgUrl}}/api/data/v9.0/msdyncrm_segments
{
  "msdyncrm_segmentname": "StaticSegmentApi1",
  "msdyncrm_segmenttype": 192350001,
  "msdyncrm_segmentmemberid": "[\"crm1405f4ba-1ee9-e811-a99d-000d3a35f12f\",\"crm0604cdd1-1ee9-e811-a99d-000d3a35f12f\"]",
  "statuscode": 192350000
}
```

> [!IMPORTANT]
> The purpose of the **crm** prefix is to unambiguously indicate the record identifier type. This is required when you are using a legacy segmentation solution, which, by default, uses a different type of identifier.

**Update request**

With the update request, you update the `statuscode` of the static segment to `Going Live (192350006)`. When the request is executed, it updates `statuscode` to “Live”.

```HTTP
PATCH {{OrgUrl}}/api/data/v9.0/msdyncrm_segments({{SegmentId}})
{
  "statuscode": 192350006
}
```

**Retrieve request**

With the retrieve request, you retrieve all the static segments that are in the Live state.  

```HTTP
GET {{orgUrl}}/api/data/v9.0/msdyncrm_segment?$filter=statuscode eq 192350001
```

You can also retrieve segments with specific properties.

```HTTP
GET {{orgUrl}}/api/data/v9.0/msdyncrm_segments?$select=msdyncrm_segmentid,msdyncrm_segmentname,msdyncrm_segmentquery,msdyncrm_description
```

**Delete request**

With the delete request, you delete the created static segment. 

```HTTP
DELETE {{orgUrl}}/api/data/v9.0/msdyncrm_segments({{SegmentId}})
```

## CRUD operations on dynamic segments

This section shows how to perform basic CRUD (create, update, retrieve, and delete) operations on dynamic segments. Dynamic segments are based on the segment query (**msdyncrm_segmentquery**). More information: [Segment query definition](segment-query-definition.md).

**Create request**

This request creates a dynamic segment and sets `statuscode` to Live.

```HTTP
POST {{orgUrl}}/api/data/v9.0/msdyncrm_segments
{
    "msdyncrm_segmentname": "MySegment2",
    "msdyncrm_segmentquery": "PROFILE(contact)",
    "msdyncrm_segmenttype": 192350000,
    "statuscode": 192350001
}
```
The following request creates a dynamic segment with a conditional segment query to retrieve only contacts that have the `address1_city` field set to `NewYork` or `NewJersey`.

```HTTP
POST {{orgUrl}}/api/data/v9.0/msdyncrm_segments
{
    "msdyncrm_segmentname": "MySegment2",
    "msdyncrm_segmentquery": "PROFILE(contact).FILTER((address1_city == 'NewYork' || address1_city == 'NewJersey'))",
    "msdyncrm_segmenttype": 192350000,
    "statuscode": 192350001
}
```

**Update request**

With the update request, you update the status of the dynamic segment to “Stop”.

```HTTP
PATCH {{OrgUrl}}/api/data/v9.0/msdyncrm_segments({{SegmentId}})
{
    "statuscode": 192350002
}
```

 **Retrieve request**

With the retrieve request, you retrieve all the dynamic segments that are in the Stop state. 

```HTTP
GET {{OrgUrl}}/api/data/v9.0/msdyncrm_segments?$filter=statuscode eq 192350002
```

**Delete request**

With the delete request, you delete the dynamic segment that is created.

```HTTP
DELETE {{OrgUrl}}/api/data/v9.0/msdyncrm_segments({{SegmentId}})
```

### CRUD operations on compound segments

This section shows how to perform basic CRUD (create, update, retrieve, and delete) operations on compound segments.

**Create request**

This request creates a compound segment and sets `statuscode` to “Live”.

```HTTP
POST {{orgUrl}}/api/data/v9.0/msdyncrm_segments
{
    "msdyncrm_segmentname": "my_compound_segment1",
    "msdyncrm_segmenttype": 192350002,
    "msdyncrm_segmentquery":"SEGMENT(segment1) UNION SEGMENT(segment2)",
    "statuscode": 192350001
}
```

 **Update request**

With the update request, you update the status of the compound segment to “Stop”.

```HTTP
PATCH {{OrgUrl}}/api/data/v9.0/msdyncrm_segments({{SegmentId}})
{
    "statuscode": 192350002
}
```

 **Retrieve request**

With the retrieve request, you retrieve all the compound segments that are in the Stop state.

```HTTP
GET {{OrgUrl}}/api/data/v9.0/msdyncrm_segments?$filter=statuscode eq 192350002
```

 **Delete request**

With the delete request, you delete the compound segment that is created.

```HTTP
DELETE {{OrgUrl}}/api/data/v9.0/msdyncrm_segments({{SegmentId}})
```

## Include/exclude segment members

Members can be added to or removed from segments. Because these operations go beyond a simple add or remove, they are referred to as include/exclude operations.

Include/exclude operations can be performed through the Segmentation API by posting messages of the following types:

- **msdyncrm_IncludeMemberInSegment**
- **msdyncrm_IncludeMembersInSegment**
- **msdyncrm_ExcludeMemberFromSegment**
- **msdyncrm_ExcludeMembersFromSegment**

Including a record makes it a member of the segment whether it satisfies the segment query (**msdyncrm_segmentquery**) or not. Including a record that is already a member will ensure that it is not removed when it doesn't match the segment query.

Excluding a record removes it from the segment members and prevents it from being added again, even if the record matches the segment query. A record can be excluded from a segment without previously being a member of the segment to prevent it from becoming a member.

Once a member is included, the action can be reversed by excluding it, thereby removing and preventing it from becoming a member. Similarly, excluding a member can be reversed by including it, thereby making it a member unconditionally.

Following are some of the important aspects that need to be considered while performing include/exclude operations on segment members:

> [!NOTE]
> For this release, include/exclude operations are not supported for dynamic segments.

- Compound segments must be in Live or Stopped state (not Draft state).
- Only instances of entity type **Contact** can be included/excluded as members.
- All included/excluded records should exist; otherwise, the request gets rejected.
- The include/exclude feature is supported only by new segmentation.
- Include/exclude member requests are processed asynchronously, independent of any recurring segment evaluations.
- Any include/exclude operation resulting in an actual update to segment members is recorded in **Segment Insights**.
- When including or excluding multiple records, use the plural endpoints for faster processing.
- You can add up to 10,000 contacts to the **msdyncrm_segmentmemberid** field.

**Add a segment member**

```HTTP
POST {{OrgUrl}}/api/data/v9.0/msdyncrm_IncludeMemberInSegment
{
  msdyncrm_segmentid: "59AC8BBF-57E7-E811-A9A9-000D3A35F403",
  msdyncrm_segmentmemberid: "B5672BDB-8899-43CB-9FA1-0AE4DC61DAD3"
}
```

**Add multiple segment members**

```HTTP
POST {{OrgUrl}}/api/data/v9.0/msdyncrm_IncludeMembersInSegment
{
   msdyncrm_segmentid: "59AC8BBF-57E7-E811-A9A9-000D3A35F403",
   msdyncrm_segmentmemberids: "[\"B5672BDB-8899-43CB-9FA1-0AE4DC61DAD3\", \"694E1C8E-F704-4B23-9B07-E65DB1620E47\", \"A4A31E3D-DFCA-4765-8018-3BA7D5E376C7\"]"
}
```

**Remove a segment member**

```HTTP
POST {{OrgUrl}}/api/data/v9.0/msdyncrm_ExcludeMemberFromSegment
{
    msdyncrm_segmentid: "59AC8BBF-57E7-E811-A9A9-000D3A35F403",
    msdyncrm_segmentmemberid: "B5672BDB-8899-43CB-9FA1-0AE4DC61DAD3"
```

**Remove multiple segment members**

```HTTP
Remove multiple segment members
POST {{OrgUrl}}/api/data/v9.0/msdyncrm_ExcludeMembersFromSegment
{
   msdyncrm_segmentid: "59AC8BBF-57E7-E811-A9A9-000D3A35F403",
   msdyncrm_segmentmemberids: "[\"B5672BDB-8899-43CB-9FA1-0AE4DC61DAD3\", \"694E1C8E-F704-4B23-9B07-E65DB1620E47\", \"A4A31E3D-DFCA-4765-8018-3BA7D5E376C7\"]" 
}
```
