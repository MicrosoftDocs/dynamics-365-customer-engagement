---
title: "Quote table/entity reference (Microsoft Dynamics 365 Customer Service)"
description: "Includes schema information and supported messages for the Quote table/entity with Microsoft Dynamics 365 Customer Service."
ms.topic: generated-reference
author: gandhamm
ms.author: mgandham
search.audienceType: 
  - developer
---

# Quote table/entity reference (Microsoft Dynamics 365 Customer Service)

Formal offer for products and/or services, proposed at specific prices and related payment terms, which is sent to a prospective customer.

> [!NOTE]
> The Microsoft Dynamics 365 Customer Service Quote table extends the [Microsoft Dynamics 365 Quote table](/dynamics365/developer/reference/entities/quote).




## One-to-Many relationships

These relationships are one-to-many. Listed by **SchemaName**.

- [quote_msdyn_bookingalerts](#BKMK_quote_msdyn_bookingalerts)
- [quote_msdyn_ocoutboundmessages](#BKMK_quote_msdyn_ocoutboundmessages)
- [quote_msdyn_ocvoicemails](#BKMK_quote_msdyn_ocvoicemails)

### <a name="BKMK_quote_msdyn_bookingalerts"></a> quote_msdyn_bookingalerts

Many-To-One Relationship: [msdyn_bookingalert quote_msdyn_bookingalerts](msdyn_bookingalert.md#BKMK_quote_msdyn_bookingalerts)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_bookingalert`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`quote_msdyn_bookingalerts`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_quote_msdyn_ocoutboundmessages"></a> quote_msdyn_ocoutboundmessages

Many-To-One Relationship: [msdyn_ocoutboundmessage quote_msdyn_ocoutboundmessages](msdyn_ocoutboundmessage.md#BKMK_quote_msdyn_ocoutboundmessages)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocoutboundmessage`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`quote_msdyn_ocoutboundmessages`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_quote_msdyn_ocvoicemails"></a> quote_msdyn_ocvoicemails

Many-To-One Relationship: [msdyn_ocvoicemail quote_msdyn_ocvoicemails](msdyn_ocvoicemail.md#BKMK_quote_msdyn_ocvoicemails)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocvoicemail`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`quote_msdyn_ocvoicemails`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|



### See also

[Dataverse table/entity reference](/power-apps/developer/data-platform/reference/about-entity-reference)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   

