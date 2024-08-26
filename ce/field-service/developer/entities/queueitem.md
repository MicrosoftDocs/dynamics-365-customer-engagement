---
title: "Queue Item (QueueItem) table/entity reference (Microsoft Dynamics 365 Field Service)"
description: "Includes schema information and supported messages for the Queue Item (QueueItem) table/entity with Microsoft Dynamics 365 Field Service."
ms.date: 08/26/2024
ms.service: powerapps
ms.topic: reference
author: m-hartmann
ms.author: mhart
search.audienceType: 
  - developer
---

# Queue Item (QueueItem) table/entity reference

A specific item in a queue, such as a case record or an activity record.

> [!NOTE]
> The Microsoft Dynamics 365 Field Service Queue Item (QueueItem) table extends the [Microsoft Dynamics 365 Queue Item (QueueItem) table](/dynamics365/developer/entities/queueitem).



## Customized columns/attributes

Microsoft Dynamics 365 Field Service modifies the definition of columns/attributes defined in other solutions. Listed by **SchemaName**.

- [ObjectId](#BKMK_ObjectId)
- [ObjectTypeCode](#BKMK_ObjectTypeCode)

### <a name="BKMK_ObjectId"></a> ObjectId

Changes from [ObjectId (Microsoft Dataverse)](/power-apps/developer/data-platform/reference/entities/queueitem#BKMK_ObjectId)

|Property|Value|
|---|---|
|Targets|msdyn_agreementbookingdate|


### <a name="BKMK_ObjectTypeCode"></a> ObjectTypeCode

Changes from [ObjectTypeCode (Microsoft Dataverse)](/power-apps/developer/data-platform/reference/entities/queueitem#BKMK_ObjectTypeCode)

#### ObjectTypeCode Choices/Options

|Value|Label|
|---|---|
|10401|**IoT Alert**|
|10599|**Customer Voice alert**|
|10609|**Customer Voice survey invite**|
|10611|**Customer Voice survey response**|
|10654|**Overflow Action Config**|
|10678|**Ongoing conversation (Deprecated)**|
|10690|**Conversation**|
|10707|**Session**|
|10874|**Copilot Transcript**|
|10988|**Booking Alert**|
|11006|**Fulfillment Preference**|
|11007|**Time Group Detail**|
|11031|**Agreement Booking Date**|
|11036|**Agreement Booking Setup**|
|11037|**Agreement Invoice Date**|
|11039|**Agreement Invoice Setup**|
|11059|**Inventory Adjustment**|
|11062|**Inventory Transfer**|
|11093|**Work Order**|
|11096|**Work Order Incident**|
|11099|**Work Order Service**|
|11100|**Work Order Service Task**|

## Many-to-One relationships

These relationships are many-to-one. Listed by **SchemaName**.

- [msdyn_agreementbookingdate_QueueItems](#BKMK_msdyn_agreementbookingdate_QueueItems)
- [msdyn_agreementbookingsetup_QueueItems](#BKMK_msdyn_agreementbookingsetup_QueueItems)
- [msdyn_agreementinvoicedate_QueueItems](#BKMK_msdyn_agreementinvoicedate_QueueItems)
- [msdyn_agreementinvoicesetup_QueueItems](#BKMK_msdyn_agreementinvoicesetup_QueueItems)
- [msdyn_bookingalert_QueueItems](#BKMK_msdyn_bookingalert_QueueItems)
- [msdyn_inventoryadjustment_QueueItems](#BKMK_msdyn_inventoryadjustment_QueueItems)
- [msdyn_inventorytransfer_QueueItems](#BKMK_msdyn_inventorytransfer_QueueItems)
- [msdyn_timegroup_QueueItems](#BKMK_msdyn_timegroup_QueueItems)
- [msdyn_timegroupdetail_QueueItems](#BKMK_msdyn_timegroupdetail_QueueItems)
- [msdyn_workorder_QueueItems](#BKMK_msdyn_workorder_QueueItems)
- [msdyn_workorderincident_QueueItems](#BKMK_msdyn_workorderincident_QueueItems)
- [msdyn_workorderservice_QueueItems](#BKMK_msdyn_workorderservice_QueueItems)
- [msdyn_workorderservicetask_QueueItems](#BKMK_msdyn_workorderservicetask_QueueItems)

### <a name="BKMK_msdyn_agreementbookingdate_QueueItems"></a> msdyn_agreementbookingdate_QueueItems

One-To-Many Relationship: [msdyn_agreementbookingdate msdyn_agreementbookingdate_QueueItems](msdyn_agreementbookingdate.md#BKMK_msdyn_agreementbookingdate_QueueItems)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_agreementbookingdate`|
|ReferencedAttribute|`msdyn_agreementbookingdateid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_agreementbookingdate`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_agreementbookingsetup_QueueItems"></a> msdyn_agreementbookingsetup_QueueItems

One-To-Many Relationship: [msdyn_agreementbookingsetup msdyn_agreementbookingsetup_QueueItems](msdyn_agreementbookingsetup.md#BKMK_msdyn_agreementbookingsetup_QueueItems)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_agreementbookingsetup`|
|ReferencedAttribute|`msdyn_agreementbookingsetupid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_agreementbookingsetup`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_agreementinvoicedate_QueueItems"></a> msdyn_agreementinvoicedate_QueueItems

One-To-Many Relationship: [msdyn_agreementinvoicedate msdyn_agreementinvoicedate_QueueItems](msdyn_agreementinvoicedate.md#BKMK_msdyn_agreementinvoicedate_QueueItems)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_agreementinvoicedate`|
|ReferencedAttribute|`msdyn_agreementinvoicedateid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_agreementinvoicedate`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_agreementinvoicesetup_QueueItems"></a> msdyn_agreementinvoicesetup_QueueItems

One-To-Many Relationship: [msdyn_agreementinvoicesetup msdyn_agreementinvoicesetup_QueueItems](msdyn_agreementinvoicesetup.md#BKMK_msdyn_agreementinvoicesetup_QueueItems)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_agreementinvoicesetup`|
|ReferencedAttribute|`msdyn_agreementinvoicesetupid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_agreementinvoicesetup`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_bookingalert_QueueItems"></a> msdyn_bookingalert_QueueItems

One-To-Many Relationship: [msdyn_bookingalert msdyn_bookingalert_QueueItems](msdyn_bookingalert.md#BKMK_msdyn_bookingalert_QueueItems)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_bookingalert`|
|ReferencedAttribute|`activityid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_bookingalert`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_inventoryadjustment_QueueItems"></a> msdyn_inventoryadjustment_QueueItems

One-To-Many Relationship: [msdyn_inventoryadjustment msdyn_inventoryadjustment_QueueItems](msdyn_inventoryadjustment.md#BKMK_msdyn_inventoryadjustment_QueueItems)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_inventoryadjustment`|
|ReferencedAttribute|`msdyn_inventoryadjustmentid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_inventoryadjustment`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_inventorytransfer_QueueItems"></a> msdyn_inventorytransfer_QueueItems

One-To-Many Relationship: [msdyn_inventorytransfer msdyn_inventorytransfer_QueueItems](msdyn_inventorytransfer.md#BKMK_msdyn_inventorytransfer_QueueItems)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_inventorytransfer`|
|ReferencedAttribute|`msdyn_inventorytransferid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_inventorytransfer`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_timegroup_QueueItems"></a> msdyn_timegroup_QueueItems

One-To-Many Relationship: [msdyn_timegroup msdyn_timegroup_QueueItems](msdyn_timegroup.md#BKMK_msdyn_timegroup_QueueItems)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_timegroup`|
|ReferencedAttribute|`msdyn_timegroupid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_timegroup`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_timegroupdetail_QueueItems"></a> msdyn_timegroupdetail_QueueItems

One-To-Many Relationship: [msdyn_timegroupdetail msdyn_timegroupdetail_QueueItems](msdyn_timegroupdetail.md#BKMK_msdyn_timegroupdetail_QueueItems)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_timegroupdetail`|
|ReferencedAttribute|`msdyn_timegroupdetailid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_timegroupdetail`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_workorder_QueueItems"></a> msdyn_workorder_QueueItems

One-To-Many Relationship: [msdyn_workorder msdyn_workorder_QueueItems](msdyn_workorder.md#BKMK_msdyn_workorder_QueueItems)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_workorder`|
|ReferencedAttribute|`msdyn_workorderid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_workorder`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_workorderincident_QueueItems"></a> msdyn_workorderincident_QueueItems

One-To-Many Relationship: [msdyn_workorderincident msdyn_workorderincident_QueueItems](msdyn_workorderincident.md#BKMK_msdyn_workorderincident_QueueItems)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_workorderincident`|
|ReferencedAttribute|`msdyn_workorderincidentid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_workorderincident`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_workorderservice_QueueItems"></a> msdyn_workorderservice_QueueItems

One-To-Many Relationship: [msdyn_workorderservice msdyn_workorderservice_QueueItems](msdyn_workorderservice.md#BKMK_msdyn_workorderservice_QueueItems)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_workorderservice`|
|ReferencedAttribute|`msdyn_workorderserviceid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_workorderservice`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_workorderservicetask_QueueItems"></a> msdyn_workorderservicetask_QueueItems

One-To-Many Relationship: [msdyn_workorderservicetask msdyn_workorderservicetask_QueueItems](msdyn_workorderservicetask.md#BKMK_msdyn_workorderservicetask_QueueItems)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_workorderservicetask`|
|ReferencedAttribute|`msdyn_workorderservicetaskid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_workorderservicetask`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|



### See also

[Dataverse table/entity reference](../about-entity-reference.md)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   
<xref:Microsoft.Dynamics.CRM.queueitem?displayProperty=fullName>
