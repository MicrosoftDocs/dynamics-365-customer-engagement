---
title: "Redirect (mspp_redirect) table/entity reference (Microsoft Dynamics 365 Field Service)"
description: "Includes schema information and supported messages for the Redirect (mspp_redirect) table/entity with Microsoft Dynamics 365 Field Service."
ms.date: 08/21/2024
ms.service: powerapps
ms.topic: reference
author: m-hartmann
ms.author: mhart
search.audienceType: 
  - developer
---

# Redirect (mspp_redirect) table/entity reference



> [!NOTE]
> The Microsoft Dynamics 365 Field Service Redirect (mspp_redirect) table extends the [Microsoft Dynamics 365 Redirect (mspp_redirect) table](/dynamics365/developer/entities/mspp_redirect).




## One-to-Many relationships

These relationships are one-to-many. Listed by **SchemaName**.

### <a name="BKMK_mspp_redirect_msdyn_bookingalerts"></a> mspp_redirect_msdyn_bookingalerts

Many-To-One Relationship: [msdyn_bookingalert mspp_redirect_msdyn_bookingalerts](msdyn_bookingalert.md#BKMK_mspp_redirect_msdyn_bookingalerts)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_bookingalert`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`mspp_redirect_msdyn_bookingalerts`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|



### See also

[Dataverse table/entity reference](../about-entity-reference.md)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   
<xref:Microsoft.Dynamics.CRM.mspp_redirect?displayProperty=fullName>
