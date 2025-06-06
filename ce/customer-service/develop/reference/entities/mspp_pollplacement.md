---
title: "Poll Placement (mspp_pollplacement) table/entity reference (Microsoft Dynamics 365 Customer Service)"
description: "Includes schema information and supported messages for the Poll Placement (mspp_pollplacement) table/entity with Microsoft Dynamics 365 Customer Service."
ms.topic: generated-reference
author: gandhamm
ms.author: mgandham
search.audienceType: 
  - developer
---

# Poll Placement (mspp_pollplacement) table/entity reference (Microsoft Dynamics 365 Customer Service)



> [!NOTE]
> The Microsoft Dynamics 365 Customer Service Poll Placement (mspp_pollplacement) table extends the [Microsoft Dynamics 365 Poll Placement (mspp_pollplacement) table](/dynamics365/developer/reference/entities/mspp_pollplacement).




## One-to-Many relationships

These relationships are one-to-many. Listed by **SchemaName**.

- [mspp_pollplacement_msdyn_bookingalerts](#BKMK_mspp_pollplacement_msdyn_bookingalerts)
- [mspp_pollplacement_msdyn_ocoutboundmessages](#BKMK_mspp_pollplacement_msdyn_ocoutboundmessages)

### <a name="BKMK_mspp_pollplacement_msdyn_bookingalerts"></a> mspp_pollplacement_msdyn_bookingalerts

Many-To-One Relationship: [msdyn_bookingalert mspp_pollplacement_msdyn_bookingalerts](msdyn_bookingalert.md#BKMK_mspp_pollplacement_msdyn_bookingalerts)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_bookingalert`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`mspp_pollplacement_msdyn_bookingalerts`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_mspp_pollplacement_msdyn_ocoutboundmessages"></a> mspp_pollplacement_msdyn_ocoutboundmessages

Many-To-One Relationship: [msdyn_ocoutboundmessage mspp_pollplacement_msdyn_ocoutboundmessages](msdyn_ocoutboundmessage.md#BKMK_mspp_pollplacement_msdyn_ocoutboundmessages)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocoutboundmessage`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`mspp_pollplacement_msdyn_ocoutboundmessages`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|



### See also

[Dataverse table/entity reference](/power-apps/developer/data-platform/reference/about-entity-reference)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   
<xref:Microsoft.Dynamics.CRM.mspp_pollplacement?displayProperty=fullName>
