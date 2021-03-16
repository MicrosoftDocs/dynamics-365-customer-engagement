---
title: "Basic operations on segments using API (Dynamics 365 Marketing Developer Guide) | Microsoft Docs"
description: "Learn how to use the segmentation API in Dynamics 365 Marketing."
ms.date: 06/12/2019
ms.service: dynamics-365-marketing
ms.custom: 
  - dyn365-marketing
ms.topic: article
author: alfergus
ms.author: alfergus
manager: shellyha
search.audienceType: 
  - developer
search.app: 
  - D365CE
  - D365Mktg
---

# Basic operations on segments using the segmentation API

A market segment is the collection of contacts that you target in a marketing campaign. In some cases, you'll target all the contacts you have, but in most cases, you'll choose whom you want to target based on demographic or firmographic data and other considerations. More information: [Working with segments](https://docs.microsoft.com/dynamics365/customer-engagement/marketing/segmentation-lists-subscriptions).

The Segmentation API enables programmatic interaction with segment records. The Segmentation API leverages the standard Microsoft Dataverse Web API for manipulating entities or messages. More information: [Use the Microsoft Dataverse Web API](/powerapps/developer/common-data-service/webapi/overview). When you create a segment, the properties of the segment are stored in the **msdyncrm_segment** entity. You can browse the entity metadata information using `@odata.context` in the **GET** response.

> [!NOTE]
> Before you perform operations, you should install the [Dynamics 365 Marketing](https://docs.microsoft.com/dynamics365/customer-engagement/marketing/trial-signup).

This topic demonstrates how to perform basic operations on **msdyncrm_segment** entity. Pass the following mandatory fields to create a segment.

|Display name|Schema name|Value|Required|
|----------|--------------|------|-------|
|Name|msdyncrm_segmentname|Name of the segment.|Yes.|
|Segment Type|msdyncrm_segmenttype|Type of segment. There are 3 types of segments:<br /> - Static `192350001`<br />- Dynamic `192350000`<br >- Compound `192350002`|Yes.|
|Status Reason|statuscode|Current status of the segment. Following are the available status codes: <br /> - Draft `192350000`<br /> - Live `192350001`<br /> - Stopped `192350002`<br /> - GoingLive `192350006`<br /> - Stopping `192350007`|Yes.|
|Segment Query|msdyncrm_query|Query in the segmentation query.|Yes (only for dynamic and compound segments).|

To test the operations, you can use the Postman tool. More information: [Use Postman with Web API](/powerapps/developer/common-data-service/webapi/use-postman-web-api).

## CRUD operations on static segments

This section shows how to perform basic CRUD (create, update, retrieve, and delete) operations on static segments.

**Create request**

This request creates a new static segment with two contacts and `statuscode` set to `Draft`. The response header contains the URL to this newly created record (entity instance), which parenthetically includes the unique ID (**segmentID**) for this record.

> [!IMPORTANT]
> You need to replace `OrgUrl` with `https://<add your environment name, like ‘myorg.crm’>.dynamics.com`. You can also get the environment name from **Settings** -> **Customizations** -> **Developer Resources**.

```HTTP
POST {{OrgUrl}}/api/data/v9.0/msdyncrm_segments
{
  "msdyncrm_segmentname": "StaticSegmentApi1",
  "msdyncrm_segmenttype": 192350001,
  "msdyncrm_segmentmemberids": "[\"crm1405f4ba-1ee9-e811-a99d-000d3a35f12f\",\"crm0604cdd1-1ee9-e811-a99d-000d3a35f12f\"]",
  "statuscode": 192350000
}
```

> [!IMPORTANT]
> The purpose of the **crm** prefix is to indicate the record identifier type unambiguously. This is required when you are using a legacy segmentation solution, which, by default, uses a different type of identifier.

**Update request**

With the update request, you update the `statuscode` of the static segment to `Going Live (192350006)`. When the request is executed, it updates `statuscode` to `Live`.

```HTTP
PATCH {{OrgUrl}}/api/data/v9.0/msdyncrm_segments({{SegmentId}})
{
  "statuscode": 192350006
}
```

**Retrieve request**

With the retrieve request, you retrieve all the static segments that are in the `Live` state.  

```HTTP
GET {{OrgUrl}}/api/data/v9.0/msdyncrm_segments?$filter=statuscode eq 192350001
```

You can also retrieve segments with specific properties.

```HTTP
GET {{OrgUrl}}/api/data/v9.0/msdyncrm_segments?$select=msdyncrm_segmentid,msdyncrm_segmentname,msdyncrm_segmentquery,msdyncrm_description
```

**Delete request**

With the delete request, you delete the created static segment. 

```HTTP
DELETE {{OrgUrl}}/api/data/v9.0/msdyncrm_segments({{SegmentId}})
```

## CRUD operations on dynamic segments

This section shows how to perform basic CRUD (create, update, retrieve, and delete) operations on dynamic segments. Dynamic segments are based on the segment query (**msdyncrm_segmentquery**). More information: [Segment query definition](segment-query-definition.md).

**Create request**

This request creates a dynamic segment and sets `statuscode` to `Draft`.

```HTTP
POST {{OrgUrl}}/api/data/v9.0/msdyncrm_segments
{
    "msdyncrm_segmentname": "Customers with name and email",
    "msdyncrm_segmentquery": "PROFILE(contact, contact_1).FILTER(ISNOTNULL(contact_1.emailaddress1) && ISNOTNULL(contact_1.fullname))",
    "msdyncrm_segmenttype": 192350000,
    "statuscode": 192350000
}
```
The following request creates a dynamic segment with a conditional segment query to retrieve only contacts that have the `address1_city` field set to `NewYork` or `NewJersey`.

```HTTP
POST {{OrgUrl}}/api/data/v9.0/msdyncrm_segments
{
    "msdyncrm_segmentname": "MySegment2",
    "msdyncrm_segmentquery": "PROFILE(contact).FILTER((address1_city == 'NewYork' || address1_city == 'NewJersey'))",
    "msdyncrm_segmenttype": 192350000,
    "statuscode": 192350006
}
```
The following request creates a new dynamic segment and sets `statuscode` to `Going Live`.

```HTTP
POST api/data/v9.0/msdyncrm_segments
{

  "msdyncrm_segmentname": "Customers with name and email",
  "msdyncrm_segmenttype": 192350000,
  "msdyncrm_segmentquery": "PROFILE(contact, contact_1).FILTER(ISNOTNULL(contact_1.emailaddress1) && ISNOTNULL(contact_1.fullname))",
  "statuscode": 192350006
}
```

**Update request**

With the update request, you update the status of the dynamic segment to `Going Live`.

```HTTP
PATCH {{OrgUrl}}/api/data/v9.0/msdyncrm_segments({{SegmentId}})
{
    "statuscode": 192350006
}
```
> [!NOTE]
> It is recommended not to move the segments directly to `Live` state.

**Retrieve request**

With the retrieve request, you retrieve all the dynamic segments that are in the `Stop` state. 

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

This request creates a compound segment and sets `statuscode` to `Going Live`.

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

With the update request, you update the status of the compound segment to `Stopping`.

```HTTP
PATCH {{OrgUrl}}/api/data/v9.0/msdyncrm_segments({{SegmentId}})
{
    "statuscode": 192350007
}
```

> [!NOTE]
> It is recommended not to move the segments directly to `Stopped` state.

**Retrieve request**

With the retrieve request, you retrieve all the compound segments that are in the `Stop` state.

```HTTP
GET {{OrgUrl}}/api/data/v9.0/msdyncrm_segments?$filter=statuscode eq 192350002
```

**Delete request**

With the delete request, you delete the compound segment that is created.

```HTTP
DELETE {{OrgUrl}}/api/data/v9.0/msdyncrm_segments({{SegmentId}})
```

## Add/Remove contacts to static segments

Segment members can be added to or removed from static segments of contacts. You can add/remove contacts either by providing a query definition, or by providing specific contact IDs. 

Some of the important aspects that need to be considered while performing add/remove operations on segment members:

- Only instances of entity type **Contact** can be added/removed as members.
- If provided contact IDs do not exist, they are ignored.
- Add/remove member requests are processed asynchronously.
- You can add/remove contacts by invoking the endpoint multiple times, usually in batches of up to 20.000 contacts each time.

**Add segment members by providing IDs**

```HTTP
POST {{OrgUrl}}/api/data/v9.0/msdyncrm_SegmentMembersUpdate
{
   "msdyncrm_segmentid": "59AC8BBF-57E7-E811-A9A9-000D3A35F403",
   "msdyncrm_operation": "addByIds",
   "msdyncrm_memberids": "[\"B5672BDB-8899-43CB-9FA1-0AE4DC61DAD3\", \"694E1C8E-F704-4B23-9B07-E65DB1620E47\", \"A4A31E3D-DFCA-4765-8018-3BA7D5E376C7\"]"
}
```

**Remove segment members by providing IDs**

```HTTP
POST {{OrgUrl}}/api/data/v9.0/msdyncrm_SegmentMembersUpdate
{
   "msdyncrm_segmentid": "59AC8BBF-57E7-E811-A9A9-000D3A35F403",
   "msdyncrm_operation": "removeByIds",
   "msdyncrm_memberids": "[\"B5672BDB-8899-43CB-9FA1-0AE4DC61DAD3\", \"694E1C8E-F704-4B23-9B07-E65DB1620E47\", \"A4A31E3D-DFCA-4765-8018-3BA7D5E376C7\"]"
}
```

**Add segment members by providing a query**

```HTTP
POST {{OrgUrl}}/api/data/v9.0/msdyncrm_SegmentMembersUpdate
{
    "msdyncrm_segmentid": "b5466fbb-2cef-e911-a81d-000d3a6d200c",
    "msdyncrm_operation": "addByQuery",
    "msdyncrm_query": "PROFILE(account, account_1).FILTER(account_1.accountid == '1cc00a15-37ef-e911-a81d-000d3a6d200c').TRAVERSE(contact_account_parentcustomerid, contact_1).FILTER(ISNOTNULL(contact_1.emailaddress1))"
}
```

**Remove segment members by providing a query**

```HTTP
POST {{OrgUrl}}/api/data/v9.0/msdyncrm_SegmentMembersUpdate
{
    "msdyncrm_segmentid": "b5466fbb-2cef-e911-a81d-000d3a6d200c",
    "msdyncrm_operation": "removeByQuery",
    "msdyncrm_query": "PROFILE(account, account_1).FILTER(account_1.accountid == '1cc00a15-37ef-e911-a81d-000d3a6d200c').TRAVERSE(contact_account_parentcustomerid, contact_1).FILTER(ISNOTNULL(contact_1.emailaddress1))"
}
```

**Get status of pending operations**

```HTTP
POST {{OrgUrl}}/api/data/v9.0/msdyncrm_SegmentMembersUpdate
{
    "msdyncrm_segmentid":"b5466fbb-2cef-e911-a81d-000d3a6d200c",
    "msdyncrm_operation":"getState"
}
```

**Retrieve segment members (recommended)**

```HTTP
POST {{OrgUrl}}/api/data/v9.0/msdyncrm_FetchContactsByQuery
{
    "Query":"(SEGMENT(SEGMENT_CRM_ID_e1fa7fdc5c78ea11a811000d3a8e8fcc)).ORDERBY(fullname ASC).SKIP(0).TAKE(15).SELECT(contactid)",
    "FetchXml":"<fetch version=\"1.0\" output-format=\"xml-platform\" mapping=\"logical\" count=\"15\" page=\"1\" returntotalrecordcount=\"true\"><entity name=\"contact\"><attribute name=\"fullname\"/><attribute name=\"emailaddress1\"/><attribute name=\"company\"/><attribute name=\"parentcustomerid\"/><attribute name=\"contactid\"/><order attribute=\"fullname\" descending=\"false\"/></entity></fetch>","OwningBusinessUnit":"0b4b85cc-7f6c-ea11-a811-000d3a54d359",
    "Scope":270100000,
    "TimeZone":null
}
```

> [!IMPORTANT]
> On the example above, replace SEGMENT_CRM_ID_ce97cb9dbd75ea11a811000d3a8e8fcc with the name of your segment in the backend, as it is in the msdyncrm_segmentqueryname field of your segment. If your segment has id `ce97cb9d-bd75-ea11-a811-000d3a8e8fcc`, that value will be `SEGMENT_CRM_ID_ce97cb9dbd75ea11a811000d3a8e8fcc`.

**Retrieve segment members (deprecated)**

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

## Validating segments

Before you create or modify a segment, you can verify the new definition using a dedicated validation endpoint.
The endpoint always returns an HTTP status OK message and an object with a property `ValidationResult` holding an array of errors.

If there is a valid definition, the result array shows empty. Otherwise, it contains records for the identified issues.
Segment definition is validated on the creation of the record, and the status code set to **Going Live**.

Validation is intentionally skipped when a segment is created in **Draft** state. Also failed validation results in HTTP 400 with an error message in the response body.

**Validating a valid segment definition**

```HTTP
POST {{OrgUrl}}/api/data/v9.0/msdyncrm_ValidateSegment
{
       "msdyncrm_segmentname":"NewSegment",
       "msdyncrm_segmentquery":"PROFILE(contact)",
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

**Validating an invalid segment definition**

```HTTP
POST {{OrgUrl}}/api/data/v9.0/msdyncrm_ValidateSegment
{
       "msdyncrm_segmentname":"NewSegment",
       "msdyncrm_segmentquery":"PROFILE(UnknownEntity)",
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


[!INCLUDE[footer-include](../../includes/footer-banner.md)]