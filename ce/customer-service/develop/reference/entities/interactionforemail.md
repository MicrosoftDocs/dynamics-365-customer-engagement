---
title: "Interaction for Email (InteractionForEmail) table/entity reference (Microsoft Dynamics 365 Customer Service)"
description: "Includes schema information and supported messages for the Interaction for Email (InteractionForEmail) table/entity with Microsoft Dynamics 365 Customer Service."
ms.topic: generated-reference
author: gandhamm
ms.author: mgandham
search.audienceType: 
  - developer
---

# Interaction for Email (InteractionForEmail) table/entity reference (Microsoft Dynamics 365 Customer Service)



> [!NOTE]
> The Microsoft Dynamics 365 Customer Service Interaction for Email (InteractionForEmail) table extends the [Microsoft Dynamics 365 Interaction for Email (InteractionForEmail) table](/dynamics365/developer/reference/entities/interactionforemail).




## One-to-Many relationships

These relationships are one-to-many. Listed by **SchemaName**.

- [interactionforemail_msdyn_bookingalerts](#BKMK_interactionforemail_msdyn_bookingalerts)
- [interactionforemail_msdyn_ocoutboundmessages](#BKMK_interactionforemail_msdyn_ocoutboundmessages)
- [interactionforemail_msdyn_ocvoicemails](#BKMK_interactionforemail_msdyn_ocvoicemails)

### <a name="BKMK_interactionforemail_msdyn_bookingalerts"></a> interactionforemail_msdyn_bookingalerts

Many-To-One Relationship: [msdyn_bookingalert interactionforemail_msdyn_bookingalerts](msdyn_bookingalert.md#BKMK_interactionforemail_msdyn_bookingalerts)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_bookingalert`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`interactionforemail_msdyn_bookingalerts`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_interactionforemail_msdyn_ocoutboundmessages"></a> interactionforemail_msdyn_ocoutboundmessages

Many-To-One Relationship: [msdyn_ocoutboundmessage interactionforemail_msdyn_ocoutboundmessages](msdyn_ocoutboundmessage.md#BKMK_interactionforemail_msdyn_ocoutboundmessages)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocoutboundmessage`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`interactionforemail_msdyn_ocoutboundmessages`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_interactionforemail_msdyn_ocvoicemails"></a> interactionforemail_msdyn_ocvoicemails

Many-To-One Relationship: [msdyn_ocvoicemail interactionforemail_msdyn_ocvoicemails](msdyn_ocvoicemail.md#BKMK_interactionforemail_msdyn_ocvoicemails)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocvoicemail`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`interactionforemail_msdyn_ocvoicemails`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|



### See also

[Dataverse table/entity reference](/power-apps/developer/data-platform/reference/about-entity-reference)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   
<xref:Microsoft.Dynamics.CRM.interactionforemail?displayProperty=fullName>
