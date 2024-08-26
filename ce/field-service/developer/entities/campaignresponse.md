---
title: "Campaign Response (CampaignResponse) table/entity reference (Microsoft Dynamics 365 Field Service)"
description: "Includes schema information and supported messages for the Campaign Response (CampaignResponse) table/entity with Microsoft Dynamics 365 Field Service."
ms.date: 08/26/2024
ms.service: powerapps
ms.topic: reference
author: m-hartmann
ms.author: mhart
search.audienceType: 
  - developer
---

# Campaign Response (CampaignResponse) table/entity reference (Microsoft Dynamics 365 Field Service)

Response from an existing or a potential new customer for a campaign.

> [!NOTE]
> The Microsoft Dynamics 365 Field Service Campaign Response (CampaignResponse) table extends the [Microsoft Dynamics 365 Campaign Response (CampaignResponse) table](/dynamics365/developer/entities/campaignresponse).




## Many-to-One relationships

These relationships are many-to-one. Listed by **SchemaName**.

- [CampaignResponse_msdyn_bookingalerts](#BKMK_CampaignResponse_msdyn_bookingalerts)
- [TransactionCurrency_CampaignResponse](#BKMK_TransactionCurrency_CampaignResponse)

### <a name="BKMK_CampaignResponse_msdyn_bookingalerts"></a> CampaignResponse_msdyn_bookingalerts

One-To-Many Relationship: [msdyn_bookingalert CampaignResponse_msdyn_bookingalerts](msdyn_bookingalert.md#BKMK_CampaignResponse_msdyn_bookingalerts)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_bookingalert`|
|ReferencedAttribute|`activityid`|
|ReferencingAttribute|`originatingactivityid`|
|ReferencingEntityNavigationPropertyName|`originatingactivityid_msdyn_bookingalert_campaignresponse`|
|IsHierarchical||
|CascadeConfiguration|Archive: `Cascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_TransactionCurrency_CampaignResponse"></a> TransactionCurrency_CampaignResponse

One-To-Many Relationship: [transactioncurrency TransactionCurrency_CampaignResponse](transactioncurrency.md#BKMK_TransactionCurrency_CampaignResponse)

|Property|Value|
|---|---|
|ReferencedEntity|`transactioncurrency`|
|ReferencedAttribute|`transactioncurrencyid`|
|ReferencingAttribute|`transactioncurrencyid`|
|ReferencingEntityNavigationPropertyName|`transactioncurrencyid_campaignresponse`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Restrict`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|



### See also

[Dataverse table/entity reference](../about-entity-reference.md)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   

