---
title: "Process Stage (ProcessStage) table/entity reference (Microsoft Dynamics 365 Customer Service)"
description: "Includes schema information and supported messages for the Process Stage (ProcessStage) table/entity with Microsoft Dynamics 365 Customer Service."
ms.topic: generated-reference
author: gandhamm
ms.author: mgandham
search.audienceType: 
  - developer
---

# Process Stage (ProcessStage) table/entity reference (Microsoft Dynamics 365 Customer Service)

Stage associated with a process.

> [!NOTE]
> The Microsoft Dynamics 365 Customer Service Process Stage (ProcessStage) table extends the [Microsoft Dynamics 365 Process Stage (ProcessStage) table](/dynamics365/developer/reference/entities/processstage).




## One-to-Many relationships

These relationships are one-to-many. Listed by **SchemaName**.

- [processstage_msdyn_timegroup](#BKMK_processstage_msdyn_timegroup)
- [processstage_msdyn_timegroupdetail](#BKMK_processstage_msdyn_timegroupdetail)

### <a name="BKMK_processstage_msdyn_timegroup"></a> processstage_msdyn_timegroup

Many-To-One Relationship: [msdyn_timegroup processstage_msdyn_timegroup](msdyn_timegroup.md#BKMK_processstage_msdyn_timegroup)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_timegroup`|
|ReferencingAttribute|`stageid`|
|ReferencedEntityNavigationPropertyName|`processstage_msdyn_timegroup`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_processstage_msdyn_timegroupdetail"></a> processstage_msdyn_timegroupdetail

Many-To-One Relationship: [msdyn_timegroupdetail processstage_msdyn_timegroupdetail](msdyn_timegroupdetail.md#BKMK_processstage_msdyn_timegroupdetail)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_timegroupdetail`|
|ReferencingAttribute|`stageid`|
|ReferencedEntityNavigationPropertyName|`processstage_msdyn_timegroupdetail`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|



### See also

[Dataverse table/entity reference](/power-apps/developer/data-platform/reference/about-entity-reference)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   
<xref:Microsoft.Dynamics.CRM.processstage?displayProperty=fullName>
