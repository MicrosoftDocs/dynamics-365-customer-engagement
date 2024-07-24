---
title: "Flow Session (flowsession) table/entity reference (Microsoft Dynamics 365 Field Service)"
description: "Includes schema information and supported messages for the Flow Session (flowsession) table/entity with Microsoft Dynamics 365 Field Service."
ms.date: 07.24.2024
ms.service: powerapps
ms.topic: reference
author: m-hartmann
ms.author: mhart
search.audienceType: 
  - developer
---

# Flow Session (flowsession) table/entity reference

Entity to store the information that is generated when a Power Automate Desktop flow runs.

> [!NOTE]
> The Microsoft Dynamics 365 Field Service Flow Session (flowsession) table extends the [Microsoft Dataverse Flow Session (flowsession) table](/power-apps/developer/data-platform/reference/entities/flowsession).



## Writable columns/attributes

These columns/attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

### <a name="BKMK_ParentWorkflowId"></a> ParentWorkflowId

|Property|Value|
|---|---|
|Description|**Id of the parent workflow, cloud flow or desktop flow.**|
|DisplayName|**ParentWorkflowId**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`parentworkflowid`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|


## Customized columns/attributes

Microsoft Dynamics 365 Field Service modifies the definition of columns/attributes defined in other solutions. Listed by **SchemaName**.

- [RunMode](#BKMK_RunMode)
- [TriggerType](#BKMK_TriggerType)

### <a name="BKMK_RunMode"></a> RunMode

Changes from [RunMode (Microsoft Dataverse)](/power-apps/developer/data-platform/reference/entities/flowsession#BKMK_RunMode)

|Property|Value|
|---|---|
|DefaultFormValue||


### <a name="BKMK_TriggerType"></a> TriggerType

Changes from [TriggerType (Microsoft Dataverse)](/power-apps/developer/data-platform/reference/entities/flowsession#BKMK_TriggerType)

|Property|Value|
|---|---|
|DefaultFormValue||


## Customized relationships

### Customized One-to-Many relationships

#### <a name="BKMK_flowsession_flowlog_parentobjectid"></a> flowsession_flowlog_parentobjectid

Changes from [flowsession_flowlog_parentobjectid (Microsoft Dataverse)](/power-apps/developer/data-platform/reference/entities/flowsession#BKMK_flowsession_flowlog_parentobjectid)

|Property|Value|
|---|---|
|IsCustomizable|True|


### See also

[Dataverse table/entity reference](../about-entity-reference.md)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   
<xref:Microsoft.Dynamics.CRM.flowsession?displayProperty=fullName>
