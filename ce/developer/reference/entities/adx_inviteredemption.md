---
title: "Invite Redemption (adx_inviteredemption) table/entity reference (Microsoft Dynamics 365)"
description: "Includes schema information and supported messages for the Invite Redemption (adx_inviteredemption) table/entity with Microsoft Dynamics 365."
ms.topic: generated-reference
author: JimDaly
ms.author: jdaly
search.audienceType: 
  - developer
---

# Invite Redemption (adx_inviteredemption) table/entity reference (Microsoft Dynamics 365)

Holds information about the redemption of an invite.

> [!NOTE]
> The Microsoft Dynamics 365 Invite Redemption (adx_inviteredemption) table extends the [Microsoft Dataverse Invite Redemption (adx_inviteredemption) table](/power-apps/developer/data-platform/reference/entities/adx_inviteredemption).



## Writable columns/attributes

These columns/attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

### <a name="BKMK_ServiceId"></a> ServiceId

|Property|Value|
|---|---|
|Description|**Unique identifier of an associated service.**|
|DisplayName|**Service**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`serviceid`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|service|


## Customized columns/attributes

Microsoft Dynamics 365 modifies the definition of columns/attributes defined in other solutions. Listed by **SchemaName**.

- [Community](#BKMK_Community)
- [OptionalAttendees](#BKMK_OptionalAttendees)
- [RegardingObjectId](#BKMK_RegardingObjectId)
- [RequiredAttendees](#BKMK_RequiredAttendees)

### <a name="BKMK_Community"></a> Community

Changes from [Community (Microsoft Dataverse)](/power-apps/developer/data-platform/reference/entities/adx_inviteredemption#BKMK_Community)

#### Community Choices/Options

|Value|Label|
|---|---|
|3|**Line**|
|4|**Wechat**|
|5|**Cortana**|
|6|**Direct Line**|
|7|**Microsoft Teams**|
|8|**Direct Line Speech**|
|9|**Email**|
|10|**GroupMe**|
|11|**Kik**|
|12|**Telegram**|
|13|**Skype**|
|14|**Slack**|
|15|**WhatsApp**|
|16|**Apple Messages For Business**|
|17|**Google's Business Messages**|

### <a name="BKMK_OptionalAttendees"></a> OptionalAttendees

Changes from [OptionalAttendees (Microsoft Dataverse)](/power-apps/developer/data-platform/reference/entities/adx_inviteredemption#BKMK_OptionalAttendees)

|Property|Value|
|---|---|
|Targets|entitlement, equipment, lead, msdyn_salessuggestion|


### <a name="BKMK_RegardingObjectId"></a> RegardingObjectId

Changes from [RegardingObjectId (Microsoft Dataverse)](/power-apps/developer/data-platform/reference/entities/adx_inviteredemption#BKMK_RegardingObjectId)

|Property|Value|
|---|---|
|Targets|bookableresourcebooking, bookableresourcebookingheader, bulkoperation, campaign, campaignactivity, contract, entitlement, entitlementtemplate, incident, invoice, lead, msdyn_customerasset, msdyn_playbookinstance, msdyn_postalbum, msdyn_salessuggestion, msdyn_swarm, opportunity, quote, salesorder, service, site|


### <a name="BKMK_RequiredAttendees"></a> RequiredAttendees

Changes from [RequiredAttendees (Microsoft Dataverse)](/power-apps/developer/data-platform/reference/entities/adx_inviteredemption#BKMK_RequiredAttendees)

|Property|Value|
|---|---|
|Targets|entitlement, equipment, lead, msdyn_salessuggestion|


## Many-to-One relationships

These relationships are many-to-one. Listed by **SchemaName**.

- [adx_inviteredemption_service_serviceid](#BKMK_adx_inviteredemption_service_serviceid)
- [bookableresourcebooking_adx_inviteredemptions](#BKMK_bookableresourcebooking_adx_inviteredemptions)
- [bookableresourcebookingheader_adx_inviteredemptions](#BKMK_bookableresourcebookingheader_adx_inviteredemptions)
- [bulkoperation_adx_inviteredemptions](#BKMK_bulkoperation_adx_inviteredemptions)
- [campaign_adx_inviteredemptions](#BKMK_campaign_adx_inviteredemptions)
- [campaignactivity_adx_inviteredemptions](#BKMK_campaignactivity_adx_inviteredemptions)
- [contract_adx_inviteredemptions](#BKMK_contract_adx_inviteredemptions)
- [entitlement_adx_inviteredemptions](#BKMK_entitlement_adx_inviteredemptions)
- [entitlementtemplate_adx_inviteredemptions](#BKMK_entitlementtemplate_adx_inviteredemptions)
- [incident_adx_inviteredemptions](#BKMK_incident_adx_inviteredemptions)
- [invoice_adx_inviteredemptions](#BKMK_invoice_adx_inviteredemptions)
- [lead_adx_inviteredemptions](#BKMK_lead_adx_inviteredemptions)
- [msdyn_customerasset_adx_inviteredemptions](#BKMK_msdyn_customerasset_adx_inviteredemptions)
- [msdyn_postalbum_adx_inviteredemptions](#BKMK_msdyn_postalbum_adx_inviteredemptions)
- [msdyn_salessuggestion_adx_inviteredemptions](#BKMK_msdyn_salessuggestion_adx_inviteredemptions)
- [msdyn_swarm_adx_inviteredemptions](#BKMK_msdyn_swarm_adx_inviteredemptions)
- [opportunity_adx_inviteredemptions](#BKMK_opportunity_adx_inviteredemptions)
- [quote_adx_inviteredemptions](#BKMK_quote_adx_inviteredemptions)
- [salesorder_adx_inviteredemptions](#BKMK_salesorder_adx_inviteredemptions)
- [service_adx_inviteredemptions](#BKMK_service_adx_inviteredemptions)
- [site_adx_inviteredemptions](#BKMK_site_adx_inviteredemptions)

### <a name="BKMK_adx_inviteredemption_service_serviceid"></a> adx_inviteredemption_service_serviceid

One-To-Many Relationship: [service adx_inviteredemption_service_serviceid](service.md#BKMK_adx_inviteredemption_service_serviceid)

|Property|Value|
|---|---|
|ReferencedEntity|`service`|
|ReferencedAttribute|`serviceid`|
|ReferencingAttribute|`serviceid`|
|ReferencingEntityNavigationPropertyName|`serviceid_adx_inviteredemption`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Restrict`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_bookableresourcebooking_adx_inviteredemptions"></a> bookableresourcebooking_adx_inviteredemptions

One-To-Many Relationship: [bookableresourcebooking bookableresourcebooking_adx_inviteredemptions](bookableresourcebooking.md#BKMK_bookableresourcebooking_adx_inviteredemptions)

|Property|Value|
|---|---|
|ReferencedEntity|`bookableresourcebooking`|
|ReferencedAttribute|`bookableresourcebookingid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_bookableresourcebooking_adx_inviteredemption`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_bookableresourcebookingheader_adx_inviteredemptions"></a> bookableresourcebookingheader_adx_inviteredemptions

One-To-Many Relationship: [bookableresourcebookingheader bookableresourcebookingheader_adx_inviteredemptions](bookableresourcebookingheader.md#BKMK_bookableresourcebookingheader_adx_inviteredemptions)

|Property|Value|
|---|---|
|ReferencedEntity|`bookableresourcebookingheader`|
|ReferencedAttribute|`bookableresourcebookingheaderid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_bookableresourcebookingheader_adx_inviteredemption`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_bulkoperation_adx_inviteredemptions"></a> bulkoperation_adx_inviteredemptions

One-To-Many Relationship: [bulkoperation bulkoperation_adx_inviteredemptions](bulkoperation.md#BKMK_bulkoperation_adx_inviteredemptions)

|Property|Value|
|---|---|
|ReferencedEntity|`bulkoperation`|
|ReferencedAttribute|`activityid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_bulkoperation_adx_inviteredemption`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_campaign_adx_inviteredemptions"></a> campaign_adx_inviteredemptions

One-To-Many Relationship: [campaign campaign_adx_inviteredemptions](campaign.md#BKMK_campaign_adx_inviteredemptions)

|Property|Value|
|---|---|
|ReferencedEntity|`campaign`|
|ReferencedAttribute|`campaignid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_campaign_adx_inviteredemption`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_campaignactivity_adx_inviteredemptions"></a> campaignactivity_adx_inviteredemptions

One-To-Many Relationship: [campaignactivity campaignactivity_adx_inviteredemptions](campaignactivity.md#BKMK_campaignactivity_adx_inviteredemptions)

|Property|Value|
|---|---|
|ReferencedEntity|`campaignactivity`|
|ReferencedAttribute|`activityid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_campaignactivity_adx_inviteredemption`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_contract_adx_inviteredemptions"></a> contract_adx_inviteredemptions

One-To-Many Relationship: [contract contract_adx_inviteredemptions](contract.md#BKMK_contract_adx_inviteredemptions)

|Property|Value|
|---|---|
|ReferencedEntity|`contract`|
|ReferencedAttribute|`contractid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_contract_adx_inviteredemption`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_entitlement_adx_inviteredemptions"></a> entitlement_adx_inviteredemptions

One-To-Many Relationship: [entitlement entitlement_adx_inviteredemptions](entitlement.md#BKMK_entitlement_adx_inviteredemptions)

|Property|Value|
|---|---|
|ReferencedEntity|`entitlement`|
|ReferencedAttribute|`entitlementid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_entitlement_adx_inviteredemption`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_entitlementtemplate_adx_inviteredemptions"></a> entitlementtemplate_adx_inviteredemptions

One-To-Many Relationship: [entitlementtemplate entitlementtemplate_adx_inviteredemptions](entitlementtemplate.md#BKMK_entitlementtemplate_adx_inviteredemptions)

|Property|Value|
|---|---|
|ReferencedEntity|`entitlementtemplate`|
|ReferencedAttribute|`entitlementtemplateid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_entitlementtemplate_adx_inviteredemption`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_incident_adx_inviteredemptions"></a> incident_adx_inviteredemptions

One-To-Many Relationship: [incident incident_adx_inviteredemptions](incident.md#BKMK_incident_adx_inviteredemptions)

|Property|Value|
|---|---|
|ReferencedEntity|`incident`|
|ReferencedAttribute|`incidentid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_incident_adx_inviteredemption`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_invoice_adx_inviteredemptions"></a> invoice_adx_inviteredemptions

One-To-Many Relationship: [invoice invoice_adx_inviteredemptions](invoice.md#BKMK_invoice_adx_inviteredemptions)

|Property|Value|
|---|---|
|ReferencedEntity|`invoice`|
|ReferencedAttribute|`invoiceid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_invoice_adx_inviteredemption`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_lead_adx_inviteredemptions"></a> lead_adx_inviteredemptions

One-To-Many Relationship: [lead lead_adx_inviteredemptions](lead.md#BKMK_lead_adx_inviteredemptions)

|Property|Value|
|---|---|
|ReferencedEntity|`lead`|
|ReferencedAttribute|`leadid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_lead_adx_inviteredemption`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_customerasset_adx_inviteredemptions"></a> msdyn_customerasset_adx_inviteredemptions

One-To-Many Relationship: [msdyn_customerasset msdyn_customerasset_adx_inviteredemptions](msdyn_customerasset.md#BKMK_msdyn_customerasset_adx_inviteredemptions)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_customerasset`|
|ReferencedAttribute|`msdyn_customerassetid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_customerasset_adx_inviteredemption`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_postalbum_adx_inviteredemptions"></a> msdyn_postalbum_adx_inviteredemptions

One-To-Many Relationship: [msdyn_postalbum msdyn_postalbum_adx_inviteredemptions](msdyn_postalbum.md#BKMK_msdyn_postalbum_adx_inviteredemptions)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_postalbum`|
|ReferencedAttribute|`msdyn_postalbumid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_postalbum_adx_inviteredemption`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_salessuggestion_adx_inviteredemptions"></a> msdyn_salessuggestion_adx_inviteredemptions

One-To-Many Relationship: [msdyn_salessuggestion msdyn_salessuggestion_adx_inviteredemptions](msdyn_salessuggestion.md#BKMK_msdyn_salessuggestion_adx_inviteredemptions)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_salessuggestion`|
|ReferencedAttribute|`msdyn_salessuggestionid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_salessuggestion_adx_inviteredemption`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_swarm_adx_inviteredemptions"></a> msdyn_swarm_adx_inviteredemptions

One-To-Many Relationship: [msdyn_swarm msdyn_swarm_adx_inviteredemptions](msdyn_swarm.md#BKMK_msdyn_swarm_adx_inviteredemptions)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_swarm`|
|ReferencedAttribute|`msdyn_swarmid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_swarm_adx_inviteredemption`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_opportunity_adx_inviteredemptions"></a> opportunity_adx_inviteredemptions

One-To-Many Relationship: [opportunity opportunity_adx_inviteredemptions](opportunity.md#BKMK_opportunity_adx_inviteredemptions)

|Property|Value|
|---|---|
|ReferencedEntity|`opportunity`|
|ReferencedAttribute|`opportunityid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_opportunity_adx_inviteredemption`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_quote_adx_inviteredemptions"></a> quote_adx_inviteredemptions

One-To-Many Relationship: [quote quote_adx_inviteredemptions](quote.md#BKMK_quote_adx_inviteredemptions)

|Property|Value|
|---|---|
|ReferencedEntity|`quote`|
|ReferencedAttribute|`quoteid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_quote_adx_inviteredemption`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_salesorder_adx_inviteredemptions"></a> salesorder_adx_inviteredemptions

One-To-Many Relationship: [salesorder salesorder_adx_inviteredemptions](salesorder.md#BKMK_salesorder_adx_inviteredemptions)

|Property|Value|
|---|---|
|ReferencedEntity|`salesorder`|
|ReferencedAttribute|`salesorderid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_salesorder_adx_inviteredemption`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_service_adx_inviteredemptions"></a> service_adx_inviteredemptions

One-To-Many Relationship: [service service_adx_inviteredemptions](service.md#BKMK_service_adx_inviteredemptions)

|Property|Value|
|---|---|
|ReferencedEntity|`service`|
|ReferencedAttribute|`serviceid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_service_adx_inviteredemption`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_site_adx_inviteredemptions"></a> site_adx_inviteredemptions

One-To-Many Relationship: [site site_adx_inviteredemptions](site.md#BKMK_site_adx_inviteredemptions)

|Property|Value|
|---|---|
|ReferencedEntity|`site`|
|ReferencedAttribute|`siteid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_site_adx_inviteredemption`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|


## One-to-Many relationships

These relationships are one-to-many. Listed by **SchemaName**.

### <a name="BKMK_CampaignResponse_adx_inviteredemptions"></a> CampaignResponse_adx_inviteredemptions

Many-To-One Relationship: [campaignresponse CampaignResponse_adx_inviteredemptions](campaignresponse.md#BKMK_CampaignResponse_adx_inviteredemptions)

|Property|Value|
|---|---|
|ReferencingEntity|`campaignresponse`|
|ReferencingAttribute|`originatingactivityid`|
|ReferencedEntityNavigationPropertyName|`CampaignResponse_adx_inviteredemptions`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|



### See also

[Dataverse table/entity reference](/power-apps/developer/data-platform/reference/about-entity-reference)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   
<xref:Microsoft.Dynamics.CRM.adx_inviteredemption?displayProperty=fullName>
