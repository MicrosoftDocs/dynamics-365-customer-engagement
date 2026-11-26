---
title: "Environment Variable Definition (EnvironmentVariableDefinition) table/entity reference (Microsoft Dynamics 365 Field Service)"
description: "Includes schema information and supported messages for the Environment Variable Definition (EnvironmentVariableDefinition) table/entity with Microsoft Dynamics 365 Field Service."
ms.topic: generated-reference
author: puneet-singh1
ms.author: puneetsingh
search.audienceType: 
  - developer
---

# Environment Variable Definition (EnvironmentVariableDefinition) table/entity reference (Microsoft Dynamics 365 Field Service)

Contains information about the settable variable: its type, default value, and etc.

> [!NOTE]
> The Microsoft Dynamics 365 Field Service Environment Variable Definition (EnvironmentVariableDefinition) table extends the [Microsoft Dataverse Environment Variable Definition (EnvironmentVariableDefinition) table](/power-apps/developer/data-platform/reference/entities/environmentvariabledefinition).




## One-to-Many relationships

These relationships are one-to-many. Listed by **SchemaName**.

### <a name="BKMK_envvardefinition_powerbimashupparameter"></a> envvardefinition_powerbimashupparameter

Many-To-One Relationship: [powerbimashupparameter envvardefinition_powerbimashupparameter](powerbimashupparameter.md#BKMK_envvardefinition_powerbimashupparameter)

|Property|Value|
|---|---|
|ReferencingEntity|`powerbimashupparameter`|
|ReferencingAttribute|`environmentvariableid`|
|ReferencedEntityNavigationPropertyName|`envvardefinition_powerbimashupparameter`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|



### See also

[Dataverse table/entity reference](/power-apps/developer/data-platform/reference/about-entity-reference)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   
<xref:Microsoft.Dynamics.CRM.environmentvariabledefinition?displayProperty=fullName>
