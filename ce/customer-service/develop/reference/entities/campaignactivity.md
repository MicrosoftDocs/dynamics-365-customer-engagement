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

### <a name="BKMK_campaignactivity_msdyn_bookingalerts"></a> campaignactivity_msdyn_bookingalerts

Many-To-One Relationship: [msdyn_bookingalert campaignactivity_msdyn_bookingalerts](msdyn_bookingalert.md#BKMK_campaignactivity_msdyn_bookingalerts)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_bookingalert`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`campaignactivity_msdyn_bookingalerts`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `7f15e2bb-305a-468f-9af7-be865755a984`|



### See also

[Dataverse table/entity reference](/power-apps/developer/data-platform/reference/about-entity-reference)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   

