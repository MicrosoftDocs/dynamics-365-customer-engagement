---
title: "Campaign Response (CampaignResponse) table/entity reference (Microsoft Dynamics 365 Customer Service)"
description: "Includes schema information and supported messages for the Campaign Response (CampaignResponse) table/entity with Microsoft Dynamics 365 Customer Service."
ms.topic: generated-reference
author: gandhamm
ms.author: mgandham
search.audienceType: 
  - developer
---

# Campaign Response (CampaignResponse) table/entity reference (Microsoft Dynamics 365 Customer Service)

Response from an existing or a potential new customer for a campaign.

> [!NOTE]
> The Microsoft Dynamics 365 Customer Service Campaign Response (CampaignResponse) table extends the [Microsoft Dynamics 365 Campaign Response (CampaignResponse) table](/dynamics365/developer/reference/entities/campaignresponse).




## Many-to-One relationships

These relationships are many-to-one. Listed by **SchemaName**.

- [CampaignResponse_msdyn_bookingalerts](#BKMK_CampaignResponse_msdyn_bookingalerts)
- [CampaignResponse_msdyn_ocoutboundmessages](#BKMK_CampaignResponse_msdyn_ocoutboundmessages)
- [CampaignResponse_msdyn_ocvoicemails](#BKMK_CampaignResponse_msdyn_ocvoicemails)

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

### <a name="BKMK_CampaignResponse_msdyn_ocoutboundmessages"></a> CampaignResponse_msdyn_ocoutboundmessages

One-To-Many Relationship: [msdyn_ocoutboundmessage CampaignResponse_msdyn_ocoutboundmessages](msdyn_ocoutboundmessage.md#BKMK_CampaignResponse_msdyn_ocoutboundmessages)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_ocoutboundmessage`|
|ReferencedAttribute|`activityid`|
|ReferencingAttribute|`originatingactivityid`|
|ReferencingEntityNavigationPropertyName|`originatingactivityid_msdyn_ocoutboundmessage_campaignresponse`|
|IsHierarchical||
|CascadeConfiguration|Archive: `Cascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_CampaignResponse_msdyn_ocvoicemails"></a> CampaignResponse_msdyn_ocvoicemails

One-To-Many Relationship: [msdyn_ocvoicemail CampaignResponse_msdyn_ocvoicemails](msdyn_ocvoicemail.md#BKMK_CampaignResponse_msdyn_ocvoicemails)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_ocvoicemail`|
|ReferencedAttribute|`activityid`|
|ReferencingAttribute|`originatingactivityid`|
|ReferencingEntityNavigationPropertyName|`originatingactivityid_msdyn_ocvoicemail_campaignresponse`|
|IsHierarchical||
|CascadeConfiguration|Archive: `Cascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|



### See also

[Dataverse table/entity reference](/power-apps/developer/data-platform/reference/about-entity-reference)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   

