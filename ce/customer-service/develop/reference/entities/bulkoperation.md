---
title: "Quick Campaign (BulkOperation) table/entity reference (Microsoft Dynamics 365 Customer Service)"
description: "Includes schema information and supported messages for the Quick Campaign (BulkOperation) table/entity with Microsoft Dynamics 365 Customer Service."
ms.topic: generated-reference
author: gandhamm
ms.author: mgandham
search.audienceType: 
  - developer
---

# Quick Campaign (BulkOperation) table/entity reference (Microsoft Dynamics 365 Customer Service)

System operation used to perform lengthy and asynchronous operations on large data sets, such as distributing a campaign activity or quick campaign.

> [!NOTE]
> The Microsoft Dynamics 365 Customer Service Quick Campaign (BulkOperation) table extends the [Microsoft Dynamics 365 Quick Campaign (BulkOperation) table](/dynamics365/developer/reference/entities/bulkoperation).




## One-to-Many relationships

These relationships are one-to-many. Listed by **SchemaName**.

### <a name="BKMK_bulkoperation_msdyn_bookingalerts"></a> bulkoperation_msdyn_bookingalerts

Many-To-One Relationship: [msdyn_bookingalert bulkoperation_msdyn_bookingalerts](msdyn_bookingalert.md#BKMK_bulkoperation_msdyn_bookingalerts)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_bookingalert`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`bulkoperation_msdyn_bookingalerts`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `7f15e2bb-305a-468f-9af7-be865755a984`|



### See also

[Dataverse table/entity reference](/power-apps/developer/data-platform/reference/about-entity-reference)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   

