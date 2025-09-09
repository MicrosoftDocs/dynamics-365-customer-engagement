---
title: "Site table/entity reference (Microsoft Dynamics 365 Customer Service)"
description: "Includes schema information and supported messages for the Site table/entity with Microsoft Dynamics 365 Customer Service."
ms.topic: generated-reference
author: gandhamm
ms.author: mgandham
search.audienceType: 
  - developer
---

# Site table/entity reference (Microsoft Dynamics 365 Customer Service)

Location or branch office where an organization does business. An organization can have multiple sites.

> [!NOTE]
> The Microsoft Dynamics 365 Customer Service Site table extends the [Microsoft Dynamics 365 Site table](/dynamics365/developer/reference/entities/site).




## One-to-Many relationships

These relationships are one-to-many. Listed by **SchemaName**.

- [site_msdyn_bookingalerts](#BKMK_site_msdyn_bookingalerts)
- [site_msdyn_ocoutboundmessages](#BKMK_site_msdyn_ocoutboundmessages)
- [site_msdyn_ocvoicemails](#BKMK_site_msdyn_ocvoicemails)

### <a name="BKMK_site_msdyn_bookingalerts"></a> site_msdyn_bookingalerts

Many-To-One Relationship: [msdyn_bookingalert site_msdyn_bookingalerts](msdyn_bookingalert.md#BKMK_site_msdyn_bookingalerts)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_bookingalert`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`site_msdyn_bookingalerts`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_site_msdyn_ocoutboundmessages"></a> site_msdyn_ocoutboundmessages

Many-To-One Relationship: [msdyn_ocoutboundmessage site_msdyn_ocoutboundmessages](msdyn_ocoutboundmessage.md#BKMK_site_msdyn_ocoutboundmessages)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocoutboundmessage`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`site_msdyn_ocoutboundmessages`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_site_msdyn_ocvoicemails"></a> site_msdyn_ocvoicemails

Many-To-One Relationship: [msdyn_ocvoicemail site_msdyn_ocvoicemails](msdyn_ocvoicemail.md#BKMK_site_msdyn_ocvoicemails)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocvoicemail`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`site_msdyn_ocvoicemails`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|



### See also

[Dataverse table/entity reference](/power-apps/developer/data-platform/reference/about-entity-reference)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   

