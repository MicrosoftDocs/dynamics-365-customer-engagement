---
title: "Invitation (adx_invitation) table/entity reference (Microsoft Dynamics 365 Field Service)"
description: "Includes schema information and supported messages for the Invitation (adx_invitation) table/entity with Microsoft Dynamics 365 Field Service."
ms.date: 08/21/2024
ms.service: powerapps
ms.topic: reference
author: m-hartmann
ms.author: mhart
search.audienceType: 
  - developer
---

# Invitation (adx_invitation) table/entity reference

Send invitations to existing contacts or email addresses and assign them to web roles upon redemption.

> [!NOTE]
> The Microsoft Dynamics 365 Field Service Invitation (adx_invitation) table extends the [Microsoft Dataverse Invitation (adx_invitation) table](/power-apps/developer/data-platform/reference/entities/adx_invitation).




## One-to-Many relationships

These relationships are one-to-many. Listed by **SchemaName**.

### <a name="BKMK_adx_invitation_msdyn_bookingalerts"></a> adx_invitation_msdyn_bookingalerts

Many-To-One Relationship: [msdyn_bookingalert adx_invitation_msdyn_bookingalerts](msdyn_bookingalert.md#BKMK_adx_invitation_msdyn_bookingalerts)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_bookingalert`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`adx_invitation_msdyn_bookingalerts`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|



### See also

[Dataverse table/entity reference](../about-entity-reference.md)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   
<xref:Microsoft.Dynamics.CRM.adx_invitation?displayProperty=fullName>
