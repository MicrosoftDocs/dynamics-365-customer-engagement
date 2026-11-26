---
title: "GuardrailVersion (msdyn_GuardrailVersion) table/entity reference (Microsoft Dynamics 365 Field Service)"
description: "Includes schema information and supported messages for the GuardrailVersion (msdyn_GuardrailVersion) table/entity with Microsoft Dynamics 365 Field Service."
ms.topic: generated-reference
author: puneet-singh1
ms.author: puneetsingh
search.audienceType: 
  - developer
---

# GuardrailVersion (msdyn_GuardrailVersion) table/entity reference (Microsoft Dynamics 365 Field Service)

This table contains records of guardrail versions

> [!NOTE]
> The Microsoft Dynamics 365 Field Service GuardrailVersion (msdyn_GuardrailVersion) table extends the [Microsoft Dynamics 365 GuardrailVersion (msdyn_GuardrailVersion) table](/dynamics365/developer/reference/entities/msdyn_guardrailversion).




## One-to-Many relationships

These relationships are one-to-many. Listed by **SchemaName**.

### <a name="BKMK_msdyn_guardrail_ActiveVersion_msdyn_guardrailversion"></a> msdyn_guardrail_ActiveVersion_msdyn_guardrailversion

Many-To-One Relationship: [msdyn_guardrail msdyn_guardrail_ActiveVersion_msdyn_guardrailversion](msdyn_guardrail.md#BKMK_msdyn_guardrail_ActiveVersion_msdyn_guardrailversion)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_guardrail`|
|ReferencingAttribute|`msdyn_activeversion`|
|ReferencedEntityNavigationPropertyName|`msdyn_guardrail_ActiveVersion_msdyn_guardrailversion`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|



### See also

[Dataverse table/entity reference](/power-apps/developer/data-platform/reference/about-entity-reference)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   

