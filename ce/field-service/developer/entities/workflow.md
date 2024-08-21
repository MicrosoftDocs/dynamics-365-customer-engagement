---
title: "Process (Workflow) table/entity reference (Microsoft Dynamics 365 Field Service)"
description: "Includes schema information and supported messages for the Process (Workflow) table/entity with Microsoft Dynamics 365 Field Service."
ms.date: 08/21/2024
ms.service: powerapps
ms.topic: reference
author: m-hartmann
ms.author: mhart
search.audienceType: 
  - developer
---

# Process (Workflow) table/entity reference

Set of logical rules that define the steps necessary to automate a specific business process, task, or set of actions to be performed.

> [!NOTE]
> The Microsoft Dynamics 365 Field Service Process (Workflow) table extends the [Microsoft Dataverse Process (Workflow) table](/power-apps/developer/data-platform/reference/entities/workflow).



## Customized columns/attributes

Microsoft Dynamics 365 Field Service modifies the definition of columns/attributes defined in other solutions. Listed by **SchemaName**.

### <a name="BKMK_UIFlowType"></a> UIFlowType

Changes from [UIFlowType (Microsoft Dataverse)](/power-apps/developer/data-platform/reference/entities/workflow#BKMK_UIFlowType)

|Property|Value|
|---|---|
|DisplayName|**UI Flow Type**|


## One-to-Many relationships

These relationships are one-to-many. Listed by **SchemaName**.

- [lk_msdyn_bpf_2c5fe86acc8b414b8322ae571000c799_processid](#BKMK_lk_msdyn_bpf_2c5fe86acc8b414b8322ae571000c799_processid)
- [lk_msdyn_bpf_477c16f59170487b8b4dc895c5dcd09b_processid](#BKMK_lk_msdyn_bpf_477c16f59170487b8b4dc895c5dcd09b_processid)
- [lk_msdyn_bpf_989e9b1857e24af18787d5143b67523b_processid](#BKMK_lk_msdyn_bpf_989e9b1857e24af18787d5143b67523b_processid)
- [lk_msdyn_bpf_baa0a411a239410cb8bded8b5fdd88e3_processid](#BKMK_lk_msdyn_bpf_baa0a411a239410cb8bded8b5fdd88e3_processid)
- [lk_msdyn_bpf_d3d97bac8c294105840e99e37a9d1c39_processid](#BKMK_lk_msdyn_bpf_d3d97bac8c294105840e99e37a9d1c39_processid)

### <a name="BKMK_lk_msdyn_bpf_2c5fe86acc8b414b8322ae571000c799_processid"></a> lk_msdyn_bpf_2c5fe86acc8b414b8322ae571000c799_processid

Many-To-One Relationship: [msdyn_bpf_2c5fe86acc8b414b8322ae571000c799 lk_msdyn_bpf_2c5fe86acc8b414b8322ae571000c799_processid](msdyn_bpf_2c5fe86acc8b414b8322ae571000c799.md#BKMK_lk_msdyn_bpf_2c5fe86acc8b414b8322ae571000c799_processid)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_bpf_2c5fe86acc8b414b8322ae571000c799`|
|ReferencingAttribute|`processid`|
|ReferencedEntityNavigationPropertyName|`lk_msdyn_bpf_2c5fe86acc8b414b8322ae571000c799_processid`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_lk_msdyn_bpf_477c16f59170487b8b4dc895c5dcd09b_processid"></a> lk_msdyn_bpf_477c16f59170487b8b4dc895c5dcd09b_processid

Many-To-One Relationship: [msdyn_bpf_477c16f59170487b8b4dc895c5dcd09b lk_msdyn_bpf_477c16f59170487b8b4dc895c5dcd09b_processid](msdyn_bpf_477c16f59170487b8b4dc895c5dcd09b.md#BKMK_lk_msdyn_bpf_477c16f59170487b8b4dc895c5dcd09b_processid)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_bpf_477c16f59170487b8b4dc895c5dcd09b`|
|ReferencingAttribute|`processid`|
|ReferencedEntityNavigationPropertyName|`lk_msdyn_bpf_477c16f59170487b8b4dc895c5dcd09b_processid`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_lk_msdyn_bpf_989e9b1857e24af18787d5143b67523b_processid"></a> lk_msdyn_bpf_989e9b1857e24af18787d5143b67523b_processid

Many-To-One Relationship: [msdyn_bpf_989e9b1857e24af18787d5143b67523b lk_msdyn_bpf_989e9b1857e24af18787d5143b67523b_processid](msdyn_bpf_989e9b1857e24af18787d5143b67523b.md#BKMK_lk_msdyn_bpf_989e9b1857e24af18787d5143b67523b_processid)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_bpf_989e9b1857e24af18787d5143b67523b`|
|ReferencingAttribute|`processid`|
|ReferencedEntityNavigationPropertyName|`lk_msdyn_bpf_989e9b1857e24af18787d5143b67523b_processid`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_lk_msdyn_bpf_baa0a411a239410cb8bded8b5fdd88e3_processid"></a> lk_msdyn_bpf_baa0a411a239410cb8bded8b5fdd88e3_processid

Many-To-One Relationship: [msdyn_bpf_baa0a411a239410cb8bded8b5fdd88e3 lk_msdyn_bpf_baa0a411a239410cb8bded8b5fdd88e3_processid](msdyn_bpf_baa0a411a239410cb8bded8b5fdd88e3.md#BKMK_lk_msdyn_bpf_baa0a411a239410cb8bded8b5fdd88e3_processid)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_bpf_baa0a411a239410cb8bded8b5fdd88e3`|
|ReferencingAttribute|`processid`|
|ReferencedEntityNavigationPropertyName|`lk_msdyn_bpf_baa0a411a239410cb8bded8b5fdd88e3_processid`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_lk_msdyn_bpf_d3d97bac8c294105840e99e37a9d1c39_processid"></a> lk_msdyn_bpf_d3d97bac8c294105840e99e37a9d1c39_processid

Many-To-One Relationship: [msdyn_bpf_d3d97bac8c294105840e99e37a9d1c39 lk_msdyn_bpf_d3d97bac8c294105840e99e37a9d1c39_processid](msdyn_bpf_d3d97bac8c294105840e99e37a9d1c39.md#BKMK_lk_msdyn_bpf_d3d97bac8c294105840e99e37a9d1c39_processid)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_bpf_d3d97bac8c294105840e99e37a9d1c39`|
|ReferencingAttribute|`processid`|
|ReferencedEntityNavigationPropertyName|`lk_msdyn_bpf_d3d97bac8c294105840e99e37a9d1c39_processid`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|



### See also

[Dataverse table/entity reference](../about-entity-reference.md)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   
<xref:Microsoft.Dynamics.CRM.workflow?displayProperty=fullName>
