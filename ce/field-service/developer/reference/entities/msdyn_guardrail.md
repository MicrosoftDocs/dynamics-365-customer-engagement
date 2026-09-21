---
title: "Guardrail (msdyn_Guardrail) table/entity reference (Microsoft Dynamics 365 Field Service)"
description: "Includes schema information and supported messages for the Guardrail (msdyn_Guardrail) table/entity with Microsoft Dynamics 365 Field Service."
ms.topic: generated-reference
author: puneet-singh1
ms.author: puneetsingh
search.audienceType: 
  - developer
---

# Guardrail (msdyn_Guardrail) table/entity reference (Microsoft Dynamics 365 Field Service)

This table contains records of guardrails

> [!NOTE]
> The Microsoft Dynamics 365 Field Service Guardrail (msdyn_Guardrail) table extends the [Microsoft Dynamics 365 Guardrail (msdyn_Guardrail) table](/dynamics365/developer/reference/entities/msdyn_guardrail).



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
|Targets|msdyn_guardrailversion|


## Many-to-One relationships

These relationships are many-to-one. Listed by **SchemaName**.

### <a name="BKMK_msdyn_guardrail_ActiveVersion_msdyn_guardrailversion"></a> msdyn_guardrail_ActiveVersion_msdyn_guardrailversion

One-To-Many Relationship: [msdyn_guardrailversion msdyn_guardrail_ActiveVersion_msdyn_guardrailversion](msdyn_guardrailversion.md#BKMK_msdyn_guardrail_ActiveVersion_msdyn_guardrailversion)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_guardrailversion`|
|ReferencedAttribute|`msdyn_guardrailversionid`|
|ReferencingAttribute|`msdyn_activeversion`|
|ReferencingEntityNavigationPropertyName|`msdyn_ActiveVersion`|
|IsHierarchical||
|CascadeConfiguration|Archive: `RemoveLink`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|



### See also

[Dataverse table/entity reference](/power-apps/developer/data-platform/reference/about-entity-reference)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   

