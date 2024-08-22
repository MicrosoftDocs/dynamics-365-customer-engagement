---
title: "Lead table/entity reference (Microsoft Dynamics 365 Field Service)"
description: "Includes schema information and supported messages for the Lead table/entity with Microsoft Dynamics 365 Field Service."
ms.date: 08/21/2024
ms.service: powerapps
ms.topic: reference
author: m-hartmann
ms.author: mhart
search.audienceType: 
  - developer
---

# Lead table/entity reference

Prospect or potential sales opportunity. Leads are converted into accounts, contacts, or opportunities when they are qualified. Otherwise, they are deleted or archived.

> [!NOTE]
> The Microsoft Dynamics 365 Field Service Lead table extends the [Microsoft Dynamics 365 Lead table](/dynamics365/developer/entities/lead).



## Writable columns/attributes

These columns/attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

### <a name="BKMK_msdyn_ordertype"></a> msdyn_ordertype

|Property|Value|
|---|---|
|Description|**Whether the Opportunity created when qualifying this Lead is for an Item- based or a Work-based sale**|
|DisplayName|**Type**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_ordertype`|
|RequiredLevel|Recommended|
|Type|Picklist|
|DefaultFormValue|192350000|
|GlobalChoiceName|`msdyn_lead_msdyn_ordertype`|

#### msdyn_ordertype Choices/Options

|Value|Label|
|---|---|
|192350000|**Item based**|
|690970002|**Service-Maintenance Based**|


## Many-to-One relationships

These relationships are many-to-one. Listed by **SchemaName**.

### <a name="BKMK_transactioncurrency_lead"></a> transactioncurrency_lead

One-To-Many Relationship: [transactioncurrency transactioncurrency_lead](transactioncurrency.md#BKMK_transactioncurrency_lead)

|Property|Value|
|---|---|
|ReferencedEntity|`transactioncurrency`|
|ReferencedAttribute|`transactioncurrencyid`|
|ReferencingAttribute|`transactioncurrencyid`|
|ReferencingEntityNavigationPropertyName|`transactioncurrencyid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `Restrict`<br />Assign: `NoCascade`<br />Delete: `Restrict`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|


## One-to-Many relationships

These relationships are one-to-many. Listed by **SchemaName**.

### <a name="BKMK_lead_msdyn_bookingalerts"></a> lead_msdyn_bookingalerts

Many-To-One Relationship: [msdyn_bookingalert lead_msdyn_bookingalerts](msdyn_bookingalert.md#BKMK_lead_msdyn_bookingalerts)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_bookingalert`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`lead_msdyn_bookingalerts`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: `CRMActivity.RetrieveByParty`<br />ViewId: `00000000-0000-0000-00aa-000010001903`|



### See also

[Dataverse table/entity reference](../about-entity-reference.md)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   

