---
title: "QualityIndicatorVersion (msdyn_QualityIndicatorVersion) table/entity reference (Microsoft Dynamics 365 Field Service)"
description: "Includes schema information and supported messages for the QualityIndicatorVersion (msdyn_QualityIndicatorVersion) table/entity with Microsoft Dynamics 365 Field Service."
ms.topic: generated-reference
author: puneet-singh1
ms.author: puneetsingh
search.audienceType: 
  - developer
---

# QualityIndicatorVersion (msdyn_QualityIndicatorVersion) table/entity reference (Microsoft Dynamics 365 Field Service)

This table contains records of quality indicator versions

> [!NOTE]
> The Microsoft Dynamics 365 Field Service QualityIndicatorVersion (msdyn_QualityIndicatorVersion) table extends the [Microsoft Dynamics 365 QualityIndicatorVersion (msdyn_QualityIndicatorVersion) table](/dynamics365/developer/reference/entities/msdyn_qualityindicatorversion).




## One-to-Many relationships

These relationships are one-to-many. Listed by **SchemaName**.

### <a name="BKMK_msdyn_qualityindicator_ActiveVersion_msdyn_qualityindicatorversion"></a> msdyn_qualityindicator_ActiveVersion_msdyn_qualityindicatorversion

Many-To-One Relationship: [msdyn_qualityindicator msdyn_qualityindicator_ActiveVersion_msdyn_qualityindicatorversion](msdyn_qualityindicator.md#BKMK_msdyn_qualityindicator_ActiveVersion_msdyn_qualityindicatorversion)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_qualityindicator`|
|ReferencingAttribute|`msdyn_activeversion`|
|ReferencedEntityNavigationPropertyName|`msdyn_qualityindicator_ActiveVersion_msdyn_qualityindicatorversion`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|



### See also

[Dataverse table/entity reference](/power-apps/developer/data-platform/reference/about-entity-reference)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   

