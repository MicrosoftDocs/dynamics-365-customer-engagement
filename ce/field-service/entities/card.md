---
title: "card table/entity reference (Microsoft Dynamics 365 Field Service)"
description: "Includes schema information and supported messages for the card table/entity with Microsoft Dynamics 365 Field Service."
ms.date: 07.24.2024
ms.service: powerapps
ms.topic: reference
author: m-hartmann
ms.author: mhart
search.audienceType: 
  - developer
---

# card table/entity reference

Card

> [!NOTE]
> The Microsoft Dynamics 365 Field Service card table extends the [Microsoft Dataverse card table](/power-apps/developer/data-platform/reference/entities/card).




## One-to-Many relationships

These relationships are one-to-many. Listed by **SchemaName**.

### <a name="BKMK_msdyn_formmapping_cardid"></a> msdyn_formmapping_cardid

Many-To-One Relationship: [msdyn_formmapping msdyn_formmapping_cardid](msdyn_formmapping.md#BKMK_msdyn_formmapping_cardid)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_formmapping`|
|ReferencingAttribute|`cardid`|
|ReferencedEntityNavigationPropertyName|`msdyn_formmapping_cardid`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|



### See also

[Dataverse table/entity reference](../about-entity-reference.md)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   
<xref:Microsoft.Dynamics.CRM.card?displayProperty=fullName>
