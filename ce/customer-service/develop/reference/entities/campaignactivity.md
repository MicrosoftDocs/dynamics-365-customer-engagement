---
title: "Campaign Activity (CampaignActivity) table/entity reference (Microsoft Dynamics 365 Customer Service)"
description: "Includes schema information and supported messages for the Campaign Activity (CampaignActivity) table/entity with Microsoft Dynamics 365 Customer Service."
ms.topic: generated-reference
author: gandhamm
ms.author: mgandham
search.audienceType: 
  - developer
---

# Campaign Activity (CampaignActivity) table/entity reference (Microsoft Dynamics 365 Customer Service)

Task performed, or to be performed, by a user for planning or running a campaign.

> [!NOTE]
> The Microsoft Dynamics 365 Customer Service Campaign Activity (CampaignActivity) table extends the [Microsoft Dynamics 365 Campaign Activity (CampaignActivity) table](/dynamics365/developer/reference/entities/campaignactivity).




## One-to-Many relationships

These relationships are one-to-many. Listed by **SchemaName**.

- [campaignactivity_msdyn_bookingalerts](#BKMK_campaignactivity_msdyn_bookingalerts)
- [campaignactivity_msdyn_ocoutboundmessages](#BKMK_campaignactivity_msdyn_ocoutboundmessages)
- [campaignactivity_msdyn_ocvoicemails](#BKMK_campaignactivity_msdyn_ocvoicemails)

### <a name="BKMK_campaignactivity_msdyn_bookingalerts"></a> campaignactivity_msdyn_bookingalerts

Many-To-One Relationship: [msdyn_bookingalert campaignactivity_msdyn_bookingalerts](msdyn_bookingalert.md#BKMK_campaignactivity_msdyn_bookingalerts)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_bookingalert`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`campaignactivity_msdyn_bookingalerts`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `7f15e2bb-305a-468f-9af7-be865755a984`|

### <a name="BKMK_campaignactivity_msdyn_ocoutboundmessages"></a> campaignactivity_msdyn_ocoutboundmessages

Many-To-One Relationship: [msdyn_ocoutboundmessage campaignactivity_msdyn_ocoutboundmessages](msdyn_ocoutboundmessage.md#BKMK_campaignactivity_msdyn_ocoutboundmessages)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocoutboundmessage`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`campaignactivity_msdyn_ocoutboundmessages`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `7f15e2bb-305a-468f-9af7-be865755a984`|

### <a name="BKMK_campaignactivity_msdyn_ocvoicemails"></a> campaignactivity_msdyn_ocvoicemails

Many-To-One Relationship: [msdyn_ocvoicemail campaignactivity_msdyn_ocvoicemails](msdyn_ocvoicemail.md#BKMK_campaignactivity_msdyn_ocvoicemails)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocvoicemail`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`campaignactivity_msdyn_ocvoicemails`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `7f15e2bb-305a-468f-9af7-be865755a984`|



### See also

[Dataverse table/entity reference](/power-apps/developer/data-platform/reference/about-entity-reference)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   

