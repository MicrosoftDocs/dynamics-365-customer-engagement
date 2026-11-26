---
title: "Website (mspp_website) table/entity reference (Microsoft Dynamics 365 Customer Service)"
description: "Includes schema information and supported messages for the Website (mspp_website) table/entity with Microsoft Dynamics 365 Customer Service."
ms.topic: generated-reference
author: gandhamm
ms.author: mgandham
search.audienceType: 
  - developer
---

# Website (mspp_website) table/entity reference (Microsoft Dynamics 365 Customer Service)

Web Portal

> [!NOTE]
> The Microsoft Dynamics 365 Customer Service Website (mspp_website) table extends the [Microsoft Dynamics 365 Website (mspp_website) table](/dynamics365/developer/reference/entities/mspp_website).




## One-to-Many relationships

These relationships are one-to-many. Listed by **SchemaName**.

- [mspp_website_msdyn_bookingalerts](#BKMK_mspp_website_msdyn_bookingalerts)
- [mspp_website_msdyn_ocoutboundmessages](#BKMK_mspp_website_msdyn_ocoutboundmessages)
- [mspp_website_msdyn_ocvoicemails](#BKMK_mspp_website_msdyn_ocvoicemails)

### <a name="BKMK_mspp_website_msdyn_bookingalerts"></a> mspp_website_msdyn_bookingalerts

Many-To-One Relationship: [msdyn_bookingalert mspp_website_msdyn_bookingalerts](msdyn_bookingalert.md#BKMK_mspp_website_msdyn_bookingalerts)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_bookingalert`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`mspp_website_msdyn_bookingalerts`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_mspp_website_msdyn_ocoutboundmessages"></a> mspp_website_msdyn_ocoutboundmessages

Many-To-One Relationship: [msdyn_ocoutboundmessage mspp_website_msdyn_ocoutboundmessages](msdyn_ocoutboundmessage.md#BKMK_mspp_website_msdyn_ocoutboundmessages)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocoutboundmessage`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`mspp_website_msdyn_ocoutboundmessages`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_mspp_website_msdyn_ocvoicemails"></a> mspp_website_msdyn_ocvoicemails

Many-To-One Relationship: [msdyn_ocvoicemail mspp_website_msdyn_ocvoicemails](msdyn_ocvoicemail.md#BKMK_mspp_website_msdyn_ocvoicemails)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocvoicemail`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`mspp_website_msdyn_ocvoicemails`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|



### See also

[Dataverse table/entity reference](/power-apps/developer/data-platform/reference/about-entity-reference)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   
<xref:Microsoft.Dynamics.CRM.mspp_website?displayProperty=fullName>
