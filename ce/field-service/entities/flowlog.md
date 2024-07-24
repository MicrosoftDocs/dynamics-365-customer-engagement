---
title: "Flow Log (flowlog) table/entity reference (Microsoft Dynamics 365 Field Service)"
description: "Includes schema information and supported messages for the Flow Log (flowlog) table/entity with Microsoft Dynamics 365 Field Service."
ms.date: 07.24.2024
ms.service: powerapps
ms.topic: reference
author: m-hartmann
ms.author: mhart
search.audienceType: 
  - developer
---

# Flow Log (flowlog) table/entity reference



> [!NOTE]
> The Microsoft Dynamics 365 Field Service Flow Log (flowlog) table extends the [Microsoft Dataverse Flow Log (flowlog) table](/power-apps/developer/data-platform/reference/entities/flowlog).



## Customized columns/attributes

Microsoft Dynamics 365 Field Service modifies the definition of columns/attributes defined in other solutions. Listed by **SchemaName**.

- [parentobjectid](#BKMK_parentobjectid)
- [type](#BKMK_type)

### <a name="BKMK_parentobjectid"></a> parentobjectid

Changes from [parentobjectid (Microsoft Dataverse)](/power-apps/developer/data-platform/reference/entities/flowlog#BKMK_parentobjectid)

|Property|Value|
|---|---|
|IsValidForUpdate|False|


### <a name="BKMK_type"></a> type

Changes from [type (Microsoft Dataverse)](/power-apps/developer/data-platform/reference/entities/flowlog#BKMK_type)

#### type Choices/Options

|Value|Label|
|---|---|
|100000100|**DesktopFlowRunUnattendedRepairUISelectorRequest**|
|100000101|**DesktopFlowRunUnattendedRepairUISelectorResponse**|

## Customized relationships

### Customized Many-to-One relationships

#### <a name="BKMK_flowsession_flowlog_parentobjectid"></a> flowsession_flowlog_parentobjectid

Changes from [flowsession_flowlog_parentobjectid (Microsoft Dataverse)](/power-apps/developer/data-platform/reference/entities/flowlog#BKMK_flowsession_flowlog_parentobjectid)

|Property|Value|
|---|---|
|CascadeConfiguration|Delete: `Cascade`|


### See also

[Dataverse table/entity reference](../about-entity-reference.md)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   
<xref:Microsoft.Dynamics.CRM.flowlog?displayProperty=fullName>
