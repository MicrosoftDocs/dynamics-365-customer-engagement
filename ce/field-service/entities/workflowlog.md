---
title: "Process Log (WorkflowLog) table/entity reference (Microsoft Dynamics 365 Field Service)"
description: "Includes schema information and supported messages for the Process Log (WorkflowLog) table/entity with Microsoft Dynamics 365 Field Service."
ms.date: 07.24.2024
ms.service: powerapps
ms.topic: reference
author: m-hartmann
ms.author: mhart
search.audienceType: 
  - developer
---

# Process Log (WorkflowLog) table/entity reference

Log used to track process execution.

> [!NOTE]
> The Microsoft Dynamics 365 Field Service Process Log (WorkflowLog) table extends the [Microsoft Dataverse Process Log (WorkflowLog) table](/power-apps/developer/data-platform/reference/entities/workflowlog).




## Many-to-One relationships

These relationships are many-to-one. Listed by **SchemaName**.

- [adx_bpf_c2857b638fa7473d8e2f112c232cebd8_WorkflowLogs](#BKMK_adx_bpf_c2857b638fa7473d8e2f112c232cebd8_WorkflowLogs)
- [lk_leadtoopportunitysalesprocess_workflowlogs](#BKMK_lk_leadtoopportunitysalesprocess_workflowlogs)
- [lk_opportunitysalesprocess_workflowlogs](#BKMK_lk_opportunitysalesprocess_workflowlogs)
- [lk_phonetocaseprocess_workflowlogs](#BKMK_lk_phonetocaseprocess_workflowlogs)
- [msdyn_bpf_2c5fe86acc8b414b8322ae571000c799_WorkflowLogs](#BKMK_msdyn_bpf_2c5fe86acc8b414b8322ae571000c799_WorkflowLogs)
- [msdyn_bpf_477c16f59170487b8b4dc895c5dcd09b_WorkflowLogs](#BKMK_msdyn_bpf_477c16f59170487b8b4dc895c5dcd09b_WorkflowLogs)
- [msdyn_bpf_989e9b1857e24af18787d5143b67523b_WorkflowLogs](#BKMK_msdyn_bpf_989e9b1857e24af18787d5143b67523b_WorkflowLogs)
- [msdyn_bpf_baa0a411a239410cb8bded8b5fdd88e3_WorkflowLogs](#BKMK_msdyn_bpf_baa0a411a239410cb8bded8b5fdd88e3_WorkflowLogs)
- [msdyn_bpf_d3d97bac8c294105840e99e37a9d1c39_WorkflowLogs](#BKMK_msdyn_bpf_d3d97bac8c294105840e99e37a9d1c39_WorkflowLogs)
- [msdyn_iottocaseprocess_WorkflowLogs](#BKMK_msdyn_iottocaseprocess_WorkflowLogs)
- [msdyncrm_leadtoopportunity_WorkflowLogs](#BKMK_msdyncrm_leadtoopportunity_WorkflowLogs)
- [msevtmgt_bpf_9623d46752ae497989f62ac0d11dad99_WorkflowLogs](#BKMK_msevtmgt_bpf_9623d46752ae497989f62ac0d11dad99_WorkflowLogs)

### <a name="BKMK_adx_bpf_c2857b638fa7473d8e2f112c232cebd8_WorkflowLogs"></a> adx_bpf_c2857b638fa7473d8e2f112c232cebd8_WorkflowLogs

One-To-Many Relationship: [adx_bpf_c2857b638fa7473d8e2f112c232cebd8 adx_bpf_c2857b638fa7473d8e2f112c232cebd8_WorkflowLogs](adx_bpf_c2857b638fa7473d8e2f112c232cebd8.md#BKMK_adx_bpf_c2857b638fa7473d8e2f112c232cebd8_WorkflowLogs)

|Property|Value|
|---|---|
|ReferencedEntity|`adx_bpf_c2857b638fa7473d8e2f112c232cebd8`|
|ReferencedAttribute|`businessprocessflowinstanceid`|
|ReferencingAttribute|`asyncoperationid`|
|ReferencingEntityNavigationPropertyName|`asyncoperationid_adx_bpf_c2857b638fa7473d8e2f112c232cebd8`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_leadtoopportunitysalesprocess_workflowlogs"></a> lk_leadtoopportunitysalesprocess_workflowlogs

One-To-Many Relationship: [leadtoopportunitysalesprocess lk_leadtoopportunitysalesprocess_workflowlogs](leadtoopportunitysalesprocess.md#BKMK_lk_leadtoopportunitysalesprocess_workflowlogs)

|Property|Value|
|---|---|
|ReferencedEntity|`leadtoopportunitysalesprocess`|
|ReferencedAttribute|`businessprocessflowinstanceid`|
|ReferencingAttribute|`asyncoperationid`|
|ReferencingEntityNavigationPropertyName|`LeadToOpportunitySalesProcess_asyncoperationid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `Cascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_lk_opportunitysalesprocess_workflowlogs"></a> lk_opportunitysalesprocess_workflowlogs

One-To-Many Relationship: [opportunitysalesprocess lk_opportunitysalesprocess_workflowlogs](opportunitysalesprocess.md#BKMK_lk_opportunitysalesprocess_workflowlogs)

|Property|Value|
|---|---|
|ReferencedEntity|`opportunitysalesprocess`|
|ReferencedAttribute|`businessprocessflowinstanceid`|
|ReferencingAttribute|`asyncoperationid`|
|ReferencingEntityNavigationPropertyName|`OpportunitySalesProcess_asyncoperationid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `Cascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_lk_phonetocaseprocess_workflowlogs"></a> lk_phonetocaseprocess_workflowlogs

One-To-Many Relationship: [phonetocaseprocess lk_phonetocaseprocess_workflowlogs](phonetocaseprocess.md#BKMK_lk_phonetocaseprocess_workflowlogs)

|Property|Value|
|---|---|
|ReferencedEntity|`phonetocaseprocess`|
|ReferencedAttribute|`businessprocessflowinstanceid`|
|ReferencingAttribute|`asyncoperationid`|
|ReferencingEntityNavigationPropertyName|`PhoneToCaseProcess_asyncoperationid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `Cascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_bpf_2c5fe86acc8b414b8322ae571000c799_WorkflowLogs"></a> msdyn_bpf_2c5fe86acc8b414b8322ae571000c799_WorkflowLogs

One-To-Many Relationship: [msdyn_bpf_2c5fe86acc8b414b8322ae571000c799 msdyn_bpf_2c5fe86acc8b414b8322ae571000c799_WorkflowLogs](msdyn_bpf_2c5fe86acc8b414b8322ae571000c799.md#BKMK_msdyn_bpf_2c5fe86acc8b414b8322ae571000c799_WorkflowLogs)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_bpf_2c5fe86acc8b414b8322ae571000c799`|
|ReferencedAttribute|`businessprocessflowinstanceid`|
|ReferencingAttribute|`asyncoperationid`|
|ReferencingEntityNavigationPropertyName|`asyncoperationid_msdyn_bpf_2c5fe86acc8b414b8322ae571000c799`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_bpf_477c16f59170487b8b4dc895c5dcd09b_WorkflowLogs"></a> msdyn_bpf_477c16f59170487b8b4dc895c5dcd09b_WorkflowLogs

One-To-Many Relationship: [msdyn_bpf_477c16f59170487b8b4dc895c5dcd09b msdyn_bpf_477c16f59170487b8b4dc895c5dcd09b_WorkflowLogs](msdyn_bpf_477c16f59170487b8b4dc895c5dcd09b.md#BKMK_msdyn_bpf_477c16f59170487b8b4dc895c5dcd09b_WorkflowLogs)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_bpf_477c16f59170487b8b4dc895c5dcd09b`|
|ReferencedAttribute|`businessprocessflowinstanceid`|
|ReferencingAttribute|`asyncoperationid`|
|ReferencingEntityNavigationPropertyName|`asyncoperationid_msdyn_bpf_477c16f59170487b8b4dc895c5dcd09b`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_bpf_989e9b1857e24af18787d5143b67523b_WorkflowLogs"></a> msdyn_bpf_989e9b1857e24af18787d5143b67523b_WorkflowLogs

One-To-Many Relationship: [msdyn_bpf_989e9b1857e24af18787d5143b67523b msdyn_bpf_989e9b1857e24af18787d5143b67523b_WorkflowLogs](msdyn_bpf_989e9b1857e24af18787d5143b67523b.md#BKMK_msdyn_bpf_989e9b1857e24af18787d5143b67523b_WorkflowLogs)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_bpf_989e9b1857e24af18787d5143b67523b`|
|ReferencedAttribute|`businessprocessflowinstanceid`|
|ReferencingAttribute|`asyncoperationid`|
|ReferencingEntityNavigationPropertyName|`asyncoperationid_msdyn_bpf_989e9b1857e24af18787d5143b67523b`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_bpf_baa0a411a239410cb8bded8b5fdd88e3_WorkflowLogs"></a> msdyn_bpf_baa0a411a239410cb8bded8b5fdd88e3_WorkflowLogs

One-To-Many Relationship: [msdyn_bpf_baa0a411a239410cb8bded8b5fdd88e3 msdyn_bpf_baa0a411a239410cb8bded8b5fdd88e3_WorkflowLogs](msdyn_bpf_baa0a411a239410cb8bded8b5fdd88e3.md#BKMK_msdyn_bpf_baa0a411a239410cb8bded8b5fdd88e3_WorkflowLogs)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_bpf_baa0a411a239410cb8bded8b5fdd88e3`|
|ReferencedAttribute|`businessprocessflowinstanceid`|
|ReferencingAttribute|`asyncoperationid`|
|ReferencingEntityNavigationPropertyName|`asyncoperationid_msdyn_bpf_baa0a411a239410cb8bded8b5fdd88e3`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_bpf_d3d97bac8c294105840e99e37a9d1c39_WorkflowLogs"></a> msdyn_bpf_d3d97bac8c294105840e99e37a9d1c39_WorkflowLogs

One-To-Many Relationship: [msdyn_bpf_d3d97bac8c294105840e99e37a9d1c39 msdyn_bpf_d3d97bac8c294105840e99e37a9d1c39_WorkflowLogs](msdyn_bpf_d3d97bac8c294105840e99e37a9d1c39.md#BKMK_msdyn_bpf_d3d97bac8c294105840e99e37a9d1c39_WorkflowLogs)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_bpf_d3d97bac8c294105840e99e37a9d1c39`|
|ReferencedAttribute|`businessprocessflowinstanceid`|
|ReferencingAttribute|`asyncoperationid`|
|ReferencingEntityNavigationPropertyName|`asyncoperationid_msdyn_bpf_d3d97bac8c294105840e99e37a9d1c39`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_iottocaseprocess_WorkflowLogs"></a> msdyn_iottocaseprocess_WorkflowLogs

One-To-Many Relationship: [msdyn_iottocaseprocess msdyn_iottocaseprocess_WorkflowLogs](msdyn_iottocaseprocess.md#BKMK_msdyn_iottocaseprocess_WorkflowLogs)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_iottocaseprocess`|
|ReferencedAttribute|`businessprocessflowinstanceid`|
|ReferencingAttribute|`asyncoperationid`|
|ReferencingEntityNavigationPropertyName|`asyncoperationid_msdyn_iottocaseprocess`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyncrm_leadtoopportunity_WorkflowLogs"></a> msdyncrm_leadtoopportunity_WorkflowLogs

One-To-Many Relationship: [msdyncrm_leadtoopportunity msdyncrm_leadtoopportunity_WorkflowLogs](msdyncrm_leadtoopportunity.md#BKMK_msdyncrm_leadtoopportunity_WorkflowLogs)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyncrm_leadtoopportunity`|
|ReferencedAttribute|`businessprocessflowinstanceid`|
|ReferencingAttribute|`asyncoperationid`|
|ReferencingEntityNavigationPropertyName|`asyncoperationid_msdyncrm_leadtoopportunity`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msevtmgt_bpf_9623d46752ae497989f62ac0d11dad99_WorkflowLogs"></a> msevtmgt_bpf_9623d46752ae497989f62ac0d11dad99_WorkflowLogs

One-To-Many Relationship: [msevtmgt_bpf_9623d46752ae497989f62ac0d11dad99 msevtmgt_bpf_9623d46752ae497989f62ac0d11dad99_WorkflowLogs](msevtmgt_bpf_9623d46752ae497989f62ac0d11dad99.md#BKMK_msevtmgt_bpf_9623d46752ae497989f62ac0d11dad99_WorkflowLogs)

|Property|Value|
|---|---|
|ReferencedEntity|`msevtmgt_bpf_9623d46752ae497989f62ac0d11dad99`|
|ReferencedAttribute|`businessprocessflowinstanceid`|
|ReferencingAttribute|`asyncoperationid`|
|ReferencingEntityNavigationPropertyName|`asyncoperationid_msevtmgt_bpf_9623d46752ae497989f62ac0d11dad99`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|



### See also

[Dataverse table/entity reference](../about-entity-reference.md)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   
<xref:Microsoft.Dynamics.CRM.workflowlog?displayProperty=fullName>
