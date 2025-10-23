---
title: "Campaign table/entity reference (Microsoft Dynamics 365 Customer Service)"
description: "Includes schema information and supported messages for the Campaign table/entity with Microsoft Dynamics 365 Customer Service."
ms.topic: generated-reference
author: gandhamm
ms.author: mgandham
search.audienceType: 
  - developer
---

# Campaign table/entity reference (Microsoft Dynamics 365 Customer Service)

Container for campaign activities and responses, sales literature, products, and lists to create, plan, execute, and track the results of a specific marketing campaign through its life.

> [!NOTE]
> The Microsoft Dynamics 365 Customer Service Campaign table extends the [Microsoft Dynamics 365 Campaign table](/dynamics365/developer/reference/entities/campaign).




## One-to-Many relationships

These relationships are one-to-many. Listed by **SchemaName**.

- [campaign_msdyn_bookingalerts](#BKMK_campaign_msdyn_bookingalerts)
- [campaign_msdyn_ocoutboundmessages](#BKMK_campaign_msdyn_ocoutboundmessages)
- [campaign_msdyn_ocvoicemails](#BKMK_campaign_msdyn_ocvoicemails)

### <a name="BKMK_campaign_msdyn_bookingalerts"></a> campaign_msdyn_bookingalerts

Many-To-One Relationship: [msdyn_bookingalert campaign_msdyn_bookingalerts](msdyn_bookingalert.md#BKMK_campaign_msdyn_bookingalerts)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_bookingalert`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`campaign_msdyn_bookingalerts`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_campaign_msdyn_ocoutboundmessages"></a> campaign_msdyn_ocoutboundmessages

Many-To-One Relationship: [msdyn_ocoutboundmessage campaign_msdyn_ocoutboundmessages](msdyn_ocoutboundmessage.md#BKMK_campaign_msdyn_ocoutboundmessages)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocoutboundmessage`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`campaign_msdyn_ocoutboundmessages`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_campaign_msdyn_ocvoicemails"></a> campaign_msdyn_ocvoicemails

Many-To-One Relationship: [msdyn_ocvoicemail campaign_msdyn_ocvoicemails](msdyn_ocvoicemail.md#BKMK_campaign_msdyn_ocvoicemails)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocvoicemail`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`campaign_msdyn_ocvoicemails`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|



### See also

[Dataverse table/entity reference](/power-apps/developer/data-platform/reference/about-entity-reference)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   

