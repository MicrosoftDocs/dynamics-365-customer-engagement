---
title: "Ad Placement (mspp_adplacement) table/entity reference (Microsoft Dynamics 365 Field Service)"
description: "Includes schema information and supported messages for the Ad Placement (mspp_adplacement) table/entity with Microsoft Dynamics 365 Field Service."
ms.date: 08/26/2024
ms.service: powerapps
ms.topic: reference
author: m-hartmann
ms.author: mhart
search.audienceType: 
  - developer
---

# Ad Placement (mspp_adplacement) table/entity reference (Microsoft Dynamics 365 Field Service)



> [!NOTE]
> The Microsoft Dynamics 365 Field Service Ad Placement (mspp_adplacement) table extends the [Microsoft Dynamics 365 Ad Placement (mspp_adplacement) table](/dynamics365/developer/entities/mspp_adplacement).




## One-to-Many relationships

These relationships are one-to-many. Listed by **SchemaName**.

### <a name="BKMK_mspp_adplacement_msdyn_bookingalerts"></a> mspp_adplacement_msdyn_bookingalerts

Many-To-One Relationship: [msdyn_bookingalert mspp_adplacement_msdyn_bookingalerts](msdyn_bookingalert.md#BKMK_mspp_adplacement_msdyn_bookingalerts)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_bookingalert`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`mspp_adplacement_msdyn_bookingalerts`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|



### See also

[Dataverse table/entity reference](../about-entity-reference.md)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   
<xref:Microsoft.Dynamics.CRM.mspp_adplacement?displayProperty=fullName>
