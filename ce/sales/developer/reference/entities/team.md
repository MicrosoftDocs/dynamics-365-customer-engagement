---
title: "Team table/entity reference (Microsoft Dynamics 365 Sales) | Microsoft Docs"
description: "Includes schema information and supported messages for the Team table/entity with Microsoft Dynamics 365 Sales."
ms.date: 05/19/2024
ms.service: powerapps
ms.topic: reference
author: JimDaly
ms.author: jdaly
search.audienceType: 
  - developer
---

# Team table/entity reference

Collection of system users that routinely collaborate. Teams can be used to simplify record sharing and provide team members with common access to organization data when team members belong to different Business Units.

> [!NOTE]
> The Microsoft Dynamics 365 Sales Team table extends the [Microsoft Dataverse Team table](/power-apps/developer/data-platform/reference/entities/team).




## One-to-Many relationships

These relationships are one-to-many. Listed by **SchemaName**.

### <a name="BKMK_team_sample_bankaccount"></a> team_sample_bankaccount

Many-To-One Relationship: [sample_bankaccount team_sample_bankaccount](sample_bankaccount.md#BKMK_team_sample_bankaccount)

|Property|Value|
|--------|-----|
|ReferencingEntity|`sample_bankaccount`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_sample_bankaccount`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|



### See also

[Dataverse table/entity reference](../about-entity-reference.md)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   
<xref:Microsoft.Dynamics.CRM.team?displayProperty=fullName>
