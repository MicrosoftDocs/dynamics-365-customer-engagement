---
title: "Process Log (WorkflowLog) table/entity reference (Microsoft Dynamics 365)"
description: "Includes schema information and supported messages for the Process Log (WorkflowLog) table/entity with Microsoft Dynamics 365."
ms.topic: generated-reference
author: JimDaly
ms.author: jdaly
search.audienceType: 
  - developer
---

# Process Log (WorkflowLog) table/entity reference (Microsoft Dynamics 365)

Log used to track process execution.

> [!NOTE]
> The Microsoft Dynamics 365 Process Log (WorkflowLog) table extends the [Microsoft Dataverse Process Log (WorkflowLog) table](/power-apps/developer/data-platform/reference/entities/workflowlog).




## Many-to-One relationships

These relationships are many-to-one. Listed by **SchemaName**.

- [lk_leadtoopportunitysalesprocess_workflowlogs](#BKMK_lk_leadtoopportunitysalesprocess_workflowlogs)
- [lk_opportunitysalesprocess_workflowlogs](#BKMK_lk_opportunitysalesprocess_workflowlogs)
- [lk_phonetocaseprocess_workflowlogs](#BKMK_lk_phonetocaseprocess_workflowlogs)
- [msdyn_iottocaseprocess_WorkflowLogs](#BKMK_msdyn_iottocaseprocess_WorkflowLogs)

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



### See also

[Dataverse table/entity reference](/power-apps/developer/data-platform/reference/about-entity-reference)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   
<xref:Microsoft.Dynamics.CRM.workflowlog?displayProperty=fullName>
