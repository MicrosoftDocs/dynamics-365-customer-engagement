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

In the update request, we will change the `status` of the created draft segment to `Go live`.

```HTTP
PATCH {{OrgUrl}}/api/data/v9.0/msdyncrm_segments({{SegmentId}})
{
	"statuscode": 192350001
}

**Retrieve Request**



**Delete Request**

In the delete request, we will delete the created draft segment. 

```HTTP
DELETE {{orgUrl}}/api/data/v9.0/msdyncrm_segments(23fa0663-6fe2-e811-a989-000d3a135be0)

 
