---
title: "Service table/entity reference (Microsoft Dynamics 365 Customer Service)"
description: "Includes schema information and supported messages for the Service table/entity with Microsoft Dynamics 365 Customer Service."
ms.topic: generated-reference
author: gandhamm
ms.author: mgandham
search.audienceType: 
  - developer
---

# Service table/entity reference (Microsoft Dynamics 365 Customer Service)

Activity that represents work done to satisfy a customer's need.

> [!NOTE]
> The Microsoft Dynamics 365 Customer Service Service table extends the [Microsoft Dynamics 365 Service table](/dynamics365/developer/reference/entities/service).



## Writable columns/attributes

These columns/attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [msdyn_RequirementGroupId](#BKMK_msdyn_RequirementGroupId)
- [msdyn_SchedulingEngine](#BKMK_msdyn_SchedulingEngine)

### <a name="BKMK_msdyn_RequirementGroupId"></a> msdyn_RequirementGroupId

|Property|Value|
|---|---|
|Description|**Unique identifier for Requirement Group associated with Service.**|
|DisplayName|**Requirement Group**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_requirementgroupid`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|msdyn_requirementgroup|

### <a name="BKMK_msdyn_SchedulingEngine"></a> msdyn_SchedulingEngine

|Property|Value|
|---|---|
|Description||
|DisplayName|**Scheduling Engine**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_SchedulingEngine`|
|RequiredLevel|None|
|Type|Picklist|
|DefaultFormValue|-1|
|GlobalChoiceName|`msdyn_service_schedulingengine`|

#### msdyn_SchedulingEngine Choices/Options

|Value|Label|
|---|---|
|0|**Legacy Scheduling**|
|1|**Universal Resource Scheduling**|


## Many-to-One relationships

These relationships are many-to-one. Listed by **SchemaName**.

### <a name="BKMK_msdyn_requirementgroup_service"></a> msdyn_requirementgroup_service

One-To-Many Relationship: [msdyn_requirementgroup msdyn_requirementgroup_service](msdyn_requirementgroup.md#BKMK_msdyn_requirementgroup_service)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_requirementgroup`|
|ReferencedAttribute|`msdyn_requirementgroupid`|
|ReferencingAttribute|`msdyn_requirementgroupid`|
|ReferencingEntityNavigationPropertyName|`msdyn_requirementgroupid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Restrict`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|


## One-to-Many relationships

These relationships are one-to-many. Listed by **SchemaName**.

### <a name="BKMK_msdyn_bookingalert_service_serviceid"></a> msdyn_bookingalert_service_serviceid

Many-To-One Relationship: [msdyn_bookingalert msdyn_bookingalert_service_serviceid](msdyn_bookingalert.md#BKMK_msdyn_bookingalert_service_serviceid)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_bookingalert`|
|ReferencingAttribute|`serviceid`|
|ReferencedEntityNavigationPropertyName|`msdyn_bookingalert_service_serviceid`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: `CRMActivity.RetrieveByObject`<br />ViewId: `00000000-0000-0000-00aa-000010001903`|



### See also

[Dataverse table/entity reference](/power-apps/developer/data-platform/reference/about-entity-reference)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   

