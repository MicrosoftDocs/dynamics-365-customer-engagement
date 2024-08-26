---
title: "Customer Voice survey (msfp_survey) table/entity reference (Microsoft Dynamics 365 Field Service)"
description: "Includes schema information and supported messages for the Customer Voice survey (msfp_survey) table/entity with Microsoft Dynamics 365 Field Service."
ms.date: 08/26/2024
ms.service: powerapps
ms.topic: reference
author: m-hartmann
ms.author: mhart
search.audienceType: 
  - developer
---

# Customer Voice survey (msfp_survey) table/entity reference

Set of questions to collect feedback.

> [!NOTE]
> The Microsoft Dynamics 365 Field Service Customer Voice survey (msfp_survey) table extends the [Microsoft Dynamics 365 Customer Voice survey (msfp_survey) table](/dynamics365/developer/entities/msfp_survey).



## Writable columns/attributes

These columns/attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

### <a name="BKMK_msdyn_Inspection"></a> msdyn_Inspection

|Property|Value|
|---|---|
|Description|**Unique identifier for Inspection Template associated with Survey.**|
|DisplayName|**Inspection Template**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_inspection`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|msdyn_inspection|


## Many-to-One relationships

These relationships are many-to-one. Listed by **SchemaName**.

### <a name="BKMK_msdyn_msdyn_inspection_msfp_survey_Inspection"></a> msdyn_msdyn_inspection_msfp_survey_Inspection

One-To-Many Relationship: [msdyn_inspection msdyn_msdyn_inspection_msfp_survey_Inspection](msdyn_inspection.md#BKMK_msdyn_msdyn_inspection_msfp_survey_Inspection)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_inspection`|
|ReferencedAttribute|`msdyn_inspectionid`|
|ReferencingAttribute|`msdyn_inspection`|
|ReferencingEntityNavigationPropertyName|`msdyn_Inspection`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|



### See also

[Dataverse table/entity reference](../about-entity-reference.md)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   

