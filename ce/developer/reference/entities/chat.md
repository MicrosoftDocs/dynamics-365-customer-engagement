---
title: "Teams chat (chat) table/entity reference (Microsoft Dynamics 365)"
description: "Includes schema information and supported messages for the Teams chat (chat) table/entity with Microsoft Dynamics 365."
ms.topic: generated-reference
author: JimDaly
ms.author: jdaly
search.audienceType: 
  - developer
---

# Teams chat (chat) table/entity reference (Microsoft Dynamics 365)

For internal use only. Entity which stores association data of Dynamics 365 records with Microsoft Teams chat

> [!NOTE]
> The Microsoft Dynamics 365 Teams chat (chat) table extends the [Microsoft Dataverse Teams chat (chat) table](/power-apps/developer/data-platform/reference/entities/chat).



## Customized columns/attributes

Microsoft Dynamics 365 modifies the definition of columns/attributes defined in other solutions. Listed by **SchemaName**.

- [Community](#BKMK_Community)
- [OptionalAttendees](#BKMK_OptionalAttendees)
- [RegardingObjectId](#BKMK_RegardingObjectId)
- [RequiredAttendees](#BKMK_RequiredAttendees)

### <a name="BKMK_Community"></a> Community

Changes from [Community (Microsoft Dataverse)](/power-apps/developer/data-platform/reference/entities/chat#BKMK_Community)

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

Changes from [OptionalAttendees (Microsoft Dataverse)](/power-apps/developer/data-platform/reference/entities/chat#BKMK_OptionalAttendees)

|Property|Value|
|---|---|
|Targets|entitlement, equipment, lead, msdyn_salessuggestion|


### <a name="BKMK_RegardingObjectId"></a> RegardingObjectId

Changes from [RegardingObjectId (Microsoft Dataverse)](/power-apps/developer/data-platform/reference/entities/chat#BKMK_RegardingObjectId)

|Property|Value|
|---|---|
|Targets|bookableresourcebooking, bookableresourcebookingheader, bulkoperation, campaign, campaignactivity, contract, entitlement, entitlementtemplate, incident, invoice, lead, msdyn_customerasset, msdyn_playbookinstance, msdyn_postalbum, msdyn_salessuggestion, msdyn_swarm, opportunity, quote, salesorder, service, site|


### <a name="BKMK_RequiredAttendees"></a> RequiredAttendees

Changes from [RequiredAttendees (Microsoft Dataverse)](/power-apps/developer/data-platform/reference/entities/chat#BKMK_RequiredAttendees)

|Property|Value|
|---|---|
|Targets|entitlement, equipment, lead, msdyn_salessuggestion|


## Many-to-One relationships

These relationships are many-to-one. Listed by **SchemaName**.

- [bookableresourcebooking_chats](#BKMK_bookableresourcebooking_chats)
- [bookableresourcebookingheader_chats](#BKMK_bookableresourcebookingheader_chats)
- [bulkoperation_chats](#BKMK_bulkoperation_chats)
- [campaign_chats](#BKMK_campaign_chats)
- [campaignactivity_chats](#BKMK_campaignactivity_chats)
- [contract_chats](#BKMK_contract_chats)
- [entitlement_chats](#BKMK_entitlement_chats)
- [entitlementtemplate_chats](#BKMK_entitlementtemplate_chats)
- [incident_chats](#BKMK_incident_chats)
- [invoice_chats](#BKMK_invoice_chats)
- [lead_chats](#BKMK_lead_chats)
- [msdyn_customerasset_chats](#BKMK_msdyn_customerasset_chats)
- [msdyn_postalbum_chats](#BKMK_msdyn_postalbum_chats)
- [msdyn_salessuggestion_chats](#BKMK_msdyn_salessuggestion_chats)
- [msdyn_swarm_chats](#BKMK_msdyn_swarm_chats)
- [opportunity_chats](#BKMK_opportunity_chats)
- [quote_chats](#BKMK_quote_chats)
- [salesorder_chats](#BKMK_salesorder_chats)
- [service_chats](#BKMK_service_chats)
- [site_chats](#BKMK_site_chats)

### <a name="BKMK_bookableresourcebooking_chats"></a> bookableresourcebooking_chats

One-To-Many Relationship: [bookableresourcebooking bookableresourcebooking_chats](bookableresourcebooking.md#BKMK_bookableresourcebooking_chats)

|Property|Value|
|---|---|
|ReferencedEntity|`bookableresourcebooking`|
|ReferencedAttribute|`bookableresourcebookingid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_bookableresourcebooking_chat`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_bookableresourcebookingheader_chats"></a> bookableresourcebookingheader_chats

One-To-Many Relationship: [bookableresourcebookingheader bookableresourcebookingheader_chats](bookableresourcebookingheader.md#BKMK_bookableresourcebookingheader_chats)

|Property|Value|
|---|---|
|ReferencedEntity|`bookableresourcebookingheader`|
|ReferencedAttribute|`bookableresourcebookingheaderid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_bookableresourcebookingheader_chat`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_bulkoperation_chats"></a> bulkoperation_chats

One-To-Many Relationship: [bulkoperation bulkoperation_chats](bulkoperation.md#BKMK_bulkoperation_chats)

|Property|Value|
|---|---|
|ReferencedEntity|`bulkoperation`|
|ReferencedAttribute|`activityid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_bulkoperation_chat`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_campaign_chats"></a> campaign_chats

One-To-Many Relationship: [campaign campaign_chats](campaign.md#BKMK_campaign_chats)

|Property|Value|
|---|---|
|ReferencedEntity|`campaign`|
|ReferencedAttribute|`campaignid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_campaign_chat`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_campaignactivity_chats"></a> campaignactivity_chats

One-To-Many Relationship: [campaignactivity campaignactivity_chats](campaignactivity.md#BKMK_campaignactivity_chats)

|Property|Value|
|---|---|
|ReferencedEntity|`campaignactivity`|
|ReferencedAttribute|`activityid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_campaignactivity_chat`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_contract_chats"></a> contract_chats

One-To-Many Relationship: [contract contract_chats](contract.md#BKMK_contract_chats)

|Property|Value|
|---|---|
|ReferencedEntity|`contract`|
|ReferencedAttribute|`contractid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_contract_chat`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_entitlement_chats"></a> entitlement_chats

One-To-Many Relationship: [entitlement entitlement_chats](entitlement.md#BKMK_entitlement_chats)

|Property|Value|
|---|---|
|ReferencedEntity|`entitlement`|
|ReferencedAttribute|`entitlementid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_entitlement_chat`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_entitlementtemplate_chats"></a> entitlementtemplate_chats

One-To-Many Relationship: [entitlementtemplate entitlementtemplate_chats](entitlementtemplate.md#BKMK_entitlementtemplate_chats)

|Property|Value|
|---|---|
|ReferencedEntity|`entitlementtemplate`|
|ReferencedAttribute|`entitlementtemplateid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_entitlementtemplate_chat`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_incident_chats"></a> incident_chats

One-To-Many Relationship: [incident incident_chats](incident.md#BKMK_incident_chats)

|Property|Value|
|---|---|
|ReferencedEntity|`incident`|
|ReferencedAttribute|`incidentid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_incident_chat`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_invoice_chats"></a> invoice_chats

One-To-Many Relationship: [invoice invoice_chats](invoice.md#BKMK_invoice_chats)

|Property|Value|
|---|---|
|ReferencedEntity|`invoice`|
|ReferencedAttribute|`invoiceid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_invoice_chat`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_lead_chats"></a> lead_chats

One-To-Many Relationship: [lead lead_chats](lead.md#BKMK_lead_chats)

|Property|Value|
|---|---|
|ReferencedEntity|`lead`|
|ReferencedAttribute|`leadid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_lead_chat`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_customerasset_chats"></a> msdyn_customerasset_chats

One-To-Many Relationship: [msdyn_customerasset msdyn_customerasset_chats](msdyn_customerasset.md#BKMK_msdyn_customerasset_chats)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_customerasset`|
|ReferencedAttribute|`msdyn_customerassetid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_customerasset_chat`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_postalbum_chats"></a> msdyn_postalbum_chats

One-To-Many Relationship: [msdyn_postalbum msdyn_postalbum_chats](msdyn_postalbum.md#BKMK_msdyn_postalbum_chats)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_postalbum`|
|ReferencedAttribute|`msdyn_postalbumid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_postalbum_chat`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_salessuggestion_chats"></a> msdyn_salessuggestion_chats

One-To-Many Relationship: [msdyn_salessuggestion msdyn_salessuggestion_chats](msdyn_salessuggestion.md#BKMK_msdyn_salessuggestion_chats)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_salessuggestion`|
|ReferencedAttribute|`msdyn_salessuggestionid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_salessuggestion_chat`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_swarm_chats"></a> msdyn_swarm_chats

One-To-Many Relationship: [msdyn_swarm msdyn_swarm_chats](msdyn_swarm.md#BKMK_msdyn_swarm_chats)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_swarm`|
|ReferencedAttribute|`msdyn_swarmid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_swarm_chat`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_opportunity_chats"></a> opportunity_chats

One-To-Many Relationship: [opportunity opportunity_chats](opportunity.md#BKMK_opportunity_chats)

|Property|Value|
|---|---|
|ReferencedEntity|`opportunity`|
|ReferencedAttribute|`opportunityid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_opportunity_chat`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_quote_chats"></a> quote_chats

One-To-Many Relationship: [quote quote_chats](quote.md#BKMK_quote_chats)

|Property|Value|
|---|---|
|ReferencedEntity|`quote`|
|ReferencedAttribute|`quoteid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_quote_chat`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_salesorder_chats"></a> salesorder_chats

One-To-Many Relationship: [salesorder salesorder_chats](salesorder.md#BKMK_salesorder_chats)

|Property|Value|
|---|---|
|ReferencedEntity|`salesorder`|
|ReferencedAttribute|`salesorderid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_salesorder_chat`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_service_chats"></a> service_chats

One-To-Many Relationship: [service service_chats](service.md#BKMK_service_chats)

|Property|Value|
|---|---|
|ReferencedEntity|`service`|
|ReferencedAttribute|`serviceid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_service_chat`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_site_chats"></a> site_chats

One-To-Many Relationship: [site site_chats](site.md#BKMK_site_chats)

|Property|Value|
|---|---|
|ReferencedEntity|`site`|
|ReferencedAttribute|`siteid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_site_chat`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|



### See also

[Dataverse table/entity reference](/power-apps/developer/data-platform/reference/about-entity-reference)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   
<xref:Microsoft.Dynamics.CRM.chat?displayProperty=fullName>
