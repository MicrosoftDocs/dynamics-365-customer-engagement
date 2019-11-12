---
title: "Basic Operations on segments using API| Microsoft Docs" # Intent and product brand in a unique string of 43-59 chars including spaces
description: The Segmentation API enables programmatic interaction with certain segmentation features of Dynamics 365 Marketing app."" # 115-145 characters including spaces. This abstract displays in the search result.
ms.custom: ""
ms.date: 11/11/2019
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

A market segment is the collection of contacts that you target in a marketing campaign. In some cases, you'll simply target all the contacts you have, but in most cases, you'll choose whom you want to target based on demographic or firmographic data and other considerations. More information: [Working with segments](https://docs.microsoft.com/dynamics365/customer-engagement/marketing/segmentation-lists-subscriptions).

The Segmentation API enables programmatic interaction with segment records. The Segmentation API leverages the standard Common Data Service Web API for manipulating entities or messages. More information: [Common Data Service Web API](/powerapps/developer/common-data-service/webapi/overview). When you create a segment, the properties of the segment are stored in the **msdyncrm_segment** entity. You can browse the entity metadata information using `@odata.context` in the **GET** response.

> [!NOTE]
> Before you perform operations, you should install the [Dynamics 365 Marketing](https://docs.microsoft.com/dynamics365/customer-engagement/marketing/trial-signup).

This topic demonstrates how to perform a basic operation on the **msdyncrm_segment** entity. You need to pass the following mandatory fields to create a segment.

|Display name|Schema name|Value|Required|
|----------|--------------|------|-------|
|Name|msdyncrm_segmentname|Name of the segment.|Yes.|
|Segment Type|msdyncrm_segmenttype|Type of segment. There are 3 types of segments:<br /> - Static `192350001`<br />- Dynamic `192350000`<br >- Compound `192350002`|Yes.|
|Status Reason|statuscode|Current status of the segment. These are the available status codes: <br /> - Draft `192350000`<br /> - Live `192350001`<br /> - Stopped `192350002`<br /> - GoingLive `192350006`<br /> - Stopping `192350007`|Yes.|
|Segment Query|msdyncrm_query|Query in the segmentation query.|Yes (only for dynamic and compound segments).|

To test the operations, you can use the Postman tool. More information: [Use Postman with Web API](/powerapps/developer/common-data-service/webapi/use-postman-web-api).

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
  "msdyncrm_memberids": "[\"crm1405f4ba-1ee9-e811-a99d-000d3a35f12f\",\"crm0604cdd1-1ee9-e811-a99d-000d3a35f12f\"]",
  "statuscode": 192350000
}
```

> [!IMPORTANT]
> The purpose of the **crm** prefix is to indicate the record identifier type unambiguously. This is required when you are using a legacy segmentation solution, which, by default, uses a different type of identifier.

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
GET {{OrgUrl}}/api/data/v9.0/msdyncrm_segments?$filter=statuscode eq 192350001
```

You can also retrieve segments with specific properties.

```HTTP
GET {{OrgUrl}}/api/data/v9.0/msdyncrm_segments?$select=msdyncrm_segmentid,msdyncrm_segmentname,msdyncrm_query,msdyncrm_description
```

**Delete request**

With the delete request, you delete the created static segment. 

```HTTP
DELETE {{OrgUrl}}/api/data/v9.0/msdyncrm_segments({{SegmentId}})
```

## CRUD operations on dynamic segments

This section shows how to perform basic CRUD (create, update, retrieve, and delete) operations on dynamic segments. Dynamic segments are based on the segment query (**msdyncrm_query**). More information: [Segment query definition](segment-query-definition.md).

**Create request**

This request creates a dynamic segment and sets `statuscode` to Going live.

```HTTP
POST {{OrgUrl}}/api/data/v9.0/msdyncrm_segments
{
    "msdyncrm_segmentname": "MySegment2",
    "msdyncrm_query": "PROFILE(contact)",
    "msdyncrm_segmenttype": 192350000,
    "statuscode": 192350006
}
```
The following request creates a dynamic segment with a conditional segment query to retrieve only contacts that have the `address1_city` field set to `NewYork` or `NewJersey`.

```HTTP
POST {{OrgUrl}}/api/data/v9.0/msdyncrm_segments
{
    "msdyncrm_segmentname": "MySegment2",
    "msdyncrm_query": "PROFILE(contact).FILTER((address1_city == 'NewYork' || address1_city == 'NewJersey'))",
    "msdyncrm_segmenttype": 192350000,
    "statuscode": 192350006
}
```

**Update request**

With the update request, you update the status of the dynamic segment to Stop.

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

This request creates a compound segment and sets `statuscode` to Going live.

```HTTP
POST {{OrgUrl}}/api/data/v9.0/msdyncrm_segments
{
    "msdyncrm_segmentname": "my_compound_segment1",
    "msdyncrm_segmenttype": 192350002,
    "msdyncrm_query":"SEGMENT(segment1) UNION SEGMENT(segment2)",
    "statuscode": 192350006
}
```

 **Update request**

With the update request, you update the status of the compound segment to Stopping.

```HTTP
PATCH {{OrgUrl}}/api/data/v9.0/msdyncrm_segments({{SegmentId}})
{
    "statuscode": 192350007
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

## Add/Remove segment members

Segment members can be added to or removed from the segments. Adding a contact record makes it a member of the segment whether it satisfies the segment query definition (**msdyncrm_query**) or not. Adding a contact record that is already a member of the segment ensures that it doesn't get removed when it doesn't match the segment query.

Removing a contact record removes it from the segment and prevents it from being added again even if the record matches the segment query. A record can be removed from a segment without previously being a member of the segment to prevent it from becoming a member.

Once a member is added to a segment, the action can be reversed by removing it from the segment, thereby preventing it from becoming a member. Similarly, removing a member can be reversed by adding it, thereby making it a member unconditionally.

Following are some of the important aspects that need to be considered while performing add/remove operations on segment members:

> [!NOTE]
> For this release, add/remove operations are not supported for dynamic segments.

- Compound segments must be in Live or Stopped state (not Draft state).
- Only instances of entity type **Contact** can be added/removed as members.
- All add/remove records should exist. Otherwise, the request gets rejected.
- The add/remove feature is supported only by new segmentation.
- Adding/Removing member requests are processed asynchronously, independent of any recurring segment evaluations.
- Any add/remove operation resulting in an actual update to segment members is recorded in **Segment Insights**.
- When adding or removing multiple records, use the plural endpoints for faster processing.
- You can add up to 10,000 contacts to the **msdyncrm_segmentmemberid** field.

**Add a segment member**

```HTTP
POST {{OrgUrl}}/api/data/v9.0/msdyncrm_SegmentMembersUpdate
{
  "msdyncrm_segmentid": "59AC8BBF-57E7-E811-A9A9-000D3A35F403",
  "msdyncrm_operation": "addByIds",
  "msdyncrm_memberids": "[\"B5672BDB-8899-43CB-9FA1-0AE4DC61DAD3\"]",
  "msdyncrm_query": null
}
```

**Add multiple segment members**

```HTTP
POST {{OrgUrl}}/api/data/v9.0/msdyncrm_SegmentMembersUpdate
{
   "msdyncrm_segmentid": "59AC8BBF-57E7-E811-A9A9-000D3A35F403",
   "msdyncrm_operation": "addByIds",
   "msdyncrm_memberids": "[\"B5672BDB-8899-43CB-9FA1-0AE4DC61DAD3\", \"694E1C8E-F704-4B23-9B07-E65DB1620E47\", \"A4A31E3D-DFCA-4765-8018-3BA7D5E376C7\"]",
   "msdyncrm_query": null
}
```

**Remove a segment member**

```HTTP
POST {{OrgUrl}}/api/data/v9.0/msdyncrm_SegmentMembersUpdate
{
    "msdyncrm_segmentid": "59AC8BBF-57E7-E811-A9A9-000D3A35F403",
    "msdyncrm_operation": "removeByIds",
    "msdyncrm_memberids": "[\"B5672BDB-8899-43CB-9FA1-0AE4DC61DAD3\"]",
    "msdyncrm_query": null
```

**Remove multiple segment members**

```HTTP
POST {{OrgUrl}}/api/data/v9.0/msdyncrm_SegmentMembersUpdate
{
   "msdyncrm_segmentid": "59AC8BBF-57E7-E811-A9A9-000D3A35F403",
   "msdyncrm_operation": "removeByIds",
   "msdyncrm_memberids": "[\"B5672BDB-8899-43CB-9FA1-0AE4DC61DAD3\", \"694E1C8E-F704-4B23-9B07-E65DB1620E47\", \"A4A31E3D-DFCA-4765-8018-3BA7D5E376C7\"]",
   "msdyncrm_query": null
}
```

**Add segment members by query**

```HTTP
POST {{OrgUrl}}/api/data/v9.0/msdyncrm_SegmentMembersUpdate
{
    "msdyncrm_segmentid": "b5466fbb-2cef-e911-a81d-000d3a6d200c",
    "msdyncrm_operation": "addByQuery",
    "msdyncrm_memberids": null,
    "msdyncrm_query": "PROFILE(account, account_1).FILTER(account_1.accountid == '1cc00a15-37ef-e911-a81d-000d3a6d200c').TRAVERSE(contact_account_parentcustomerid, contact_1).FILTER(ISNOTNULL(contact_1.emailaddress1))"
}
```

**Remove segment members by query**

```HTTP
POST {{OrgUrl}}/api/data/v9.0/msdyncrm_SegmentMembersUpdate
{
    "msdyncrm_segmentid": "b5466fbb-2cef-e911-a81d-000d3a6d200c",
    "msdyncrm_operation": "removeByQuery",
    "msdyncrm_memberids": null,
    "msdyncrm_query": "PROFILE(account, account_1).FILTER(account_1.accountid == '1cc00a15-37ef-e911-a81d-000d3a6d200c').TRAVERSE(contact_account_parentcustomerid, contact_1).FILTER(ISNOTNULL(contact_1.emailaddress1))"
}
```

**Retrieve segment members**

```HTTP
GET {{OrgUrl}}/api/data/v9.0/contacts?fetchXml=fetch version="1.0" output-format="xml-platform" mapping="logical" returntotalrecordcount="true" page="1" count="5" no-lock="false">
    <entity name="contact">
        <attribute name="fullname"/>
        <attribute name="contactid"/>
        <order attribute="fullname" descending="false"/>
        <link-entity name="msdyncrm_segment" from="msdyncrm_segmentid" to="msdyncrm_segmentmemberid" alias="bb">
            <filter type="and">
                <condition attribute="msdyncrm_segmentid" operator="eq" uitype="msdyncrm_segment" value="bfc9d5d6-d6aa-e911-a859-000d3a3159df"/>
            </filter>
        </link-entity>
    </entity>
</fetch>
```

**Get status of pending operations**

```HTTP
POST {{OrgUrl}}/api/data/v9.0/msdyncrm_SegmentMembersUpdate
{
    "msdyncrm_segmentid":"b5466fbb-2cef-e911-a81d-000d3a6d200c",
    "msdyncrm_operation":"getState",
}
```

## Validating segments

Prior to creating or modifying a segment, you can verify the new definition using a dedicated validation endpoint.
The endpoint always returns an HTTP status OK message and an object with a property `ValidationResult` holding an array of errors.

In the case of a valid definition, the result array is empty. Otherwise, it contains records for the identified issues.
Segment definition is validated on the creation of the record, and the status code set to **Going Live**.

Validation is intentionally skipped when a segment is created in **Draft** state. Also failed validation results in HTTP 400 with an error message in the response body.

**Validating a valid segment definition**

```HTTP
POST {{OrgUrl}}/api/data/v9.0/msdyncrm_ValidateSegment
{
       "msdyncrm_segmentname":"NewSegment",
       "msdyncrm_query":"PROFILE(contact)",
       "msdyncrm_segmenttype":192350000,
       "statuscode":192350000
}
```
**Response**
```HTTP
{
…
    "ValidationResult": "[]"
}
```

**Validating a invalid segment definition**

```HTTP
POST {{OrgUrl}}/api/data/v9.0/msdyncrm_ValidateSegment
{
       "msdyncrm_segmentname":"NewSegment",
       "msdyncrm_query":"PROFILE(UnknownEntity)",
       "msdyncrm_segmenttype":192350000,
       "statuscode":192350006
}
```

**Response**

```HTTP
{
…
    "ValidationResult": "[{\"ErrorCode\":\"SegmentDciValidator_SegmentInvalid\",\"FieldName\":\"msdyncrm_query\"}]"
}
```
