---
title: "SLA Item (SLAItem) table/entity reference (Microsoft Dynamics 365)"
description: "Includes schema information and supported messages for the SLA Item (SLAItem) table/entity with Microsoft Dynamics 365."
ms.topic: generated-reference
author: JimDaly
ms.author: jdaly
search.audienceType: 
  - developer
---

# SLA Item (SLAItem) table/entity reference (Microsoft Dynamics 365)

Contains information about a tracked support KPI for a specific customer.

> [!NOTE]
> The Microsoft Dynamics 365 SLA Item (SLAItem) table extends the [Microsoft Dataverse SLA Item (SLAItem) table](/power-apps/developer/data-platform/reference/entities/slaitem).




## One-to-Many relationships

These relationships are one-to-many. Listed by **SchemaName**.

- [msdyn_migrationtracker_LegacySLAItem_slaitem](#BKMK_msdyn_migrationtracker_LegacySLAItem_slaitem)
- [msdyn_migrationtracker_ModernSLAItem_slaitem](#BKMK_msdyn_migrationtracker_ModernSLAItem_slaitem)

### <a name="BKMK_msdyn_migrationtracker_LegacySLAItem_slaitem"></a> msdyn_migrationtracker_LegacySLAItem_slaitem

Many-To-One Relationship: [msdyn_migrationtracker msdyn_migrationtracker_LegacySLAItem_slaitem](msdyn_migrationtracker.md#BKMK_msdyn_migrationtracker_LegacySLAItem_slaitem)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_migrationtracker`|
|ReferencingAttribute|`msdyn_legacyslaitemid`|
|ReferencedEntityNavigationPropertyName|`msdyn_migrationtracker_LegacySLAItem_slaitem`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_migrationtracker_ModernSLAItem_slaitem"></a> msdyn_migrationtracker_ModernSLAItem_slaitem

Many-To-One Relationship: [msdyn_migrationtracker msdyn_migrationtracker_ModernSLAItem_slaitem](msdyn_migrationtracker.md#BKMK_msdyn_migrationtracker_ModernSLAItem_slaitem)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_migrationtracker`|
|ReferencingAttribute|`msdyn_modernslaitemid`|
|ReferencedEntityNavigationPropertyName|`msdyn_migrationtracker_ModernSLAItem_slaitem`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|



### See also

[Dataverse table/entity reference](/power-apps/developer/data-platform/reference/about-entity-reference)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   
<xref:Microsoft.Dynamics.CRM.slaitem?displayProperty=fullName>
