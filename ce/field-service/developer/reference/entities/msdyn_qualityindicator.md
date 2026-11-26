---
title: "QualityIndicator (msdyn_QualityIndicator) table/entity reference (Microsoft Dynamics 365 Field Service)"
description: "Includes schema information and supported messages for the QualityIndicator (msdyn_QualityIndicator) table/entity with Microsoft Dynamics 365 Field Service."
ms.topic: generated-reference
author: puneet-singh1
ms.author: puneetsingh
search.audienceType: 
  - developer
---

# QualityIndicator (msdyn_QualityIndicator) table/entity reference (Microsoft Dynamics 365 Field Service)

This table contains records of quality indicators

> [!NOTE]
> The Microsoft Dynamics 365 Field Service QualityIndicator (msdyn_QualityIndicator) table extends the [Microsoft Dynamics 365 QualityIndicator (msdyn_QualityIndicator) table](/dynamics365/developer/reference/entities/msdyn_qualityindicator).



## Writable columns/attributes

These columns/attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

### <a name="BKMK_msdyn_ActiveVersion"></a> msdyn_ActiveVersion

|Property|Value|
|---|---|
|Description||
|DisplayName|**ActiveVersion**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_activeversion`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|msdyn_qualityindicatorversion|


## Many-to-One relationships

These relationships are many-to-one. Listed by **SchemaName**.

### <a name="BKMK_msdyn_qualityindicator_ActiveVersion_msdyn_qualityindicatorversion"></a> msdyn_qualityindicator_ActiveVersion_msdyn_qualityindicatorversion

One-To-Many Relationship: [msdyn_qualityindicatorversion msdyn_qualityindicator_ActiveVersion_msdyn_qualityindicatorversion](msdyn_qualityindicatorversion.md#BKMK_msdyn_qualityindicator_ActiveVersion_msdyn_qualityindicatorversion)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_qualityindicatorversion`|
|ReferencedAttribute|`msdyn_qualityindicatorversionid`|
|ReferencingAttribute|`msdyn_activeversion`|
|ReferencingEntityNavigationPropertyName|`msdyn_ActiveVersion`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|



### See also

[Dataverse table/entity reference](/power-apps/developer/data-platform/reference/about-entity-reference)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   

