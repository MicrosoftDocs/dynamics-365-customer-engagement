---
title: "Opportunity table/entity reference (Microsoft Dynamics 365 Field Service)"
description: "Includes schema information and supported messages for the Opportunity table/entity with Microsoft Dynamics 365 Field Service."
ms.topic: generated-reference
author: m-hartmann
ms.author: mhart
search.audienceType: 
  - developer
---

# Opportunity table/entity reference (Microsoft Dynamics 365 Field Service)

Potential revenue-generating event, or sale to an account, which needs to be tracked through a sales process to completion.

> [!NOTE]
> The Microsoft Dynamics 365 Field Service Opportunity table extends the [Microsoft Dynamics 365 Opportunity table](/dynamics365/developer/reference/entities/opportunity).



## Writable columns/attributes

These columns/attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [msdyn_OrderType](#BKMK_msdyn_OrderType)
- [msdyn_WorkOrderType](#BKMK_msdyn_WorkOrderType)

### <a name="BKMK_msdyn_OrderType"></a> msdyn_OrderType

|Property|Value|
|---|---|
|Description|**Internal use only.**|
|DisplayName|**Order Type**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_ordertype`|
|RequiredLevel|Recommended|
|Type|Picklist|
|DefaultFormValue|192350000|
|GlobalChoiceName|`msdyn_opportunity_msdyn_ordertype`|

#### msdyn_OrderType Choices/Options

|Value|Label|
|---|---|
|192350000|**Item based**|
|690970002|**Service\-Maintenance Based**|

### <a name="BKMK_msdyn_WorkOrderType"></a> msdyn_WorkOrderType

|Property|Value|
|---|---|
|Description|**Unique identifier for Work Order Type associated with Opportunity.**|
|DisplayName|**Work Order Type**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_workordertype`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|msdyn_workordertype|


## Many-to-One relationships

These relationships are many-to-one. Listed by **SchemaName**.

### <a name="BKMK_msdyn_msdyn_workordertype_opportunity_WorkOrderType"></a> msdyn_msdyn_workordertype_opportunity_WorkOrderType

One-To-Many Relationship: [msdyn_workordertype msdyn_msdyn_workordertype_opportunity_WorkOrderType](msdyn_workordertype.md#BKMK_msdyn_msdyn_workordertype_opportunity_WorkOrderType)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_workordertype`|
|ReferencedAttribute|`msdyn_workordertypeid`|
|ReferencingAttribute|`msdyn_workordertype`|
|ReferencingEntityNavigationPropertyName|`msdyn_workordertype`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|


## One-to-Many relationships

These relationships are one-to-many. Listed by **SchemaName**.

- [msdyn_opportunity_msdyn_workorder](#BKMK_msdyn_opportunity_msdyn_workorder)
- [opportunity_msdyn_bookingalerts](#BKMK_opportunity_msdyn_bookingalerts)

### <a name="BKMK_msdyn_opportunity_msdyn_workorder"></a> msdyn_opportunity_msdyn_workorder

Many-To-One Relationship: [msdyn_workorder msdyn_opportunity_msdyn_workorder](msdyn_workorder.md#BKMK_msdyn_opportunity_msdyn_workorder)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_workorder`|
|ReferencingAttribute|`msdyn_opportunityid`|
|ReferencedEntityNavigationPropertyName|`msdyn_opportunity_msdyn_workorder`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Sales`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_opportunity_msdyn_bookingalerts"></a> opportunity_msdyn_bookingalerts

Many-To-One Relationship: [msdyn_bookingalert opportunity_msdyn_bookingalerts](msdyn_bookingalert.md#BKMK_opportunity_msdyn_bookingalerts)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_bookingalert`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`opportunity_msdyn_bookingalerts`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: `CRMActivity.RollupByParty`<br />ViewId: `00000000-0000-0000-00aa-000010001903`|



### See also

[Dataverse table/entity reference](/power-apps/developer/data-platform/reference/about-entity-reference)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   

