---
title: "Shortcut (mspp_shortcut) table/entity reference (Microsoft Dynamics 365 Customer Service)"
description: "Includes schema information and supported messages for the Shortcut (mspp_shortcut) table/entity with Microsoft Dynamics 365 Customer Service."
ms.topic: generated-reference
author: gandhamm
ms.author: mgandham
search.audienceType: 
  - developer
---

# Shortcut (mspp_shortcut) table/entity reference (Microsoft Dynamics 365 Customer Service)



> [!NOTE]
> The Microsoft Dynamics 365 Customer Service Shortcut (mspp_shortcut) table extends the [Microsoft Dynamics 365 Shortcut (mspp_shortcut) table](/dynamics365/developer/reference/entities/mspp_shortcut).




## One-to-Many relationships

These relationships are one-to-many. Listed by **SchemaName**.

- [mspp_shortcut_msdyn_bookingalerts](#BKMK_mspp_shortcut_msdyn_bookingalerts)
- [mspp_shortcut_msdyn_ocoutboundmessages](#BKMK_mspp_shortcut_msdyn_ocoutboundmessages)
- [mspp_shortcut_msdyn_ocvoicemails](#BKMK_mspp_shortcut_msdyn_ocvoicemails)

### <a name="BKMK_mspp_shortcut_msdyn_bookingalerts"></a> mspp_shortcut_msdyn_bookingalerts

Many-To-One Relationship: [msdyn_bookingalert mspp_shortcut_msdyn_bookingalerts](msdyn_bookingalert.md#BKMK_mspp_shortcut_msdyn_bookingalerts)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_bookingalert`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`mspp_shortcut_msdyn_bookingalerts`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_mspp_shortcut_msdyn_ocoutboundmessages"></a> mspp_shortcut_msdyn_ocoutboundmessages

Many-To-One Relationship: [msdyn_ocoutboundmessage mspp_shortcut_msdyn_ocoutboundmessages](msdyn_ocoutboundmessage.md#BKMK_mspp_shortcut_msdyn_ocoutboundmessages)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocoutboundmessage`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`mspp_shortcut_msdyn_ocoutboundmessages`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_mspp_shortcut_msdyn_ocvoicemails"></a> mspp_shortcut_msdyn_ocvoicemails

Many-To-One Relationship: [msdyn_ocvoicemail mspp_shortcut_msdyn_ocvoicemails](msdyn_ocvoicemail.md#BKMK_mspp_shortcut_msdyn_ocvoicemails)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocvoicemail`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`mspp_shortcut_msdyn_ocvoicemails`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|



### See also

[Dataverse table/entity reference](/power-apps/developer/data-platform/reference/about-entity-reference)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   
<xref:Microsoft.Dynamics.CRM.mspp_shortcut?displayProperty=fullName>
