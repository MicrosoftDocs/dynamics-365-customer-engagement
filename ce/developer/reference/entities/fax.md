---
title: "Fax table/entity reference (Microsoft Dynamics 365)"
description: "Includes schema information and supported messages for the Fax table/entity with Microsoft Dynamics 365."
ms.topic: generated-reference
author: JimDaly
ms.author: jdaly
search.audienceType: 
  - developer
---

# Fax table/entity reference (Microsoft Dynamics 365)

Activity that tracks call outcome and number of pages for a fax and optionally stores an electronic copy of the document.

> [!NOTE]
> The Microsoft Dynamics 365 Fax table extends the [Microsoft Dataverse Fax table](/power-apps/developer/data-platform/reference/entities/fax).



## Writable columns/attributes

These columns/attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

### <a name="BKMK_ServiceId"></a> ServiceId

|Property|Value|
|---|---|
|Description|**Unique identifier for an associated service.**|
|DisplayName|**Service**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`serviceid`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|service|


## Customized columns/attributes

Microsoft Dynamics 365 modifies the definition of columns/attributes defined in other solutions. Listed by **SchemaName**.

- [from](#BKMK_from)
- [RegardingObjectId](#BKMK_RegardingObjectId)
- [to](#BKMK_to)

### <a name="BKMK_from"></a> from

Changes from [from (Microsoft Dataverse)](/power-apps/developer/data-platform/reference/entities/fax#BKMK_from)

|Property|Value|
|---|---|
|Targets|lead|


### <a name="BKMK_RegardingObjectId"></a> RegardingObjectId

Changes from [RegardingObjectId (Microsoft Dataverse)](/power-apps/developer/data-platform/reference/entities/fax#BKMK_RegardingObjectId)

|Property|Value|
|---|---|
|Targets|bookableresourcebooking, bookableresourcebookingheader, bulkoperation, campaign, campaignactivity, contract, entitlement, entitlementtemplate, incident, invoice, lead, msdyn_customerasset, msdyn_playbookinstance, msdyn_postalbum, msdyn_salessuggestion, msdyn_swarm, opportunity, quote, salesorder, site|


### <a name="BKMK_to"></a> to

Changes from [to (Microsoft Dataverse)](/power-apps/developer/data-platform/reference/entities/fax#BKMK_to)

|Property|Value|
|---|---|
|Targets|lead|


## Many-to-One relationships

These relationships are many-to-one. Listed by **SchemaName**.

- [bookableresourcebooking_Faxes](#BKMK_bookableresourcebooking_Faxes)
- [bookableresourcebookingheader_Faxes](#BKMK_bookableresourcebookingheader_Faxes)
- [BulkOperation_Faxes](#BKMK_BulkOperation_Faxes)
- [Campaign_Faxes](#BKMK_Campaign_Faxes)
- [CampaignActivity_Faxes](#BKMK_CampaignActivity_Faxes)
- [Contract_Faxes](#BKMK_Contract_Faxes)
- [entitlement_Faxes](#BKMK_entitlement_Faxes)
- [entitlementtemplate_Faxes](#BKMK_entitlementtemplate_Faxes)
- [Incident_Faxes](#BKMK_Incident_Faxes)
- [Invoice_Faxes](#BKMK_Invoice_Faxes)
- [Lead_Faxes](#BKMK_Lead_Faxes)
- [msdyn_customerasset_Faxes](#BKMK_msdyn_customerasset_Faxes)
- [msdyn_postalbum_Faxes](#BKMK_msdyn_postalbum_Faxes)
- [msdyn_salessuggestion_Faxes](#BKMK_msdyn_salessuggestion_Faxes)
- [msdyn_swarm_Faxes](#BKMK_msdyn_swarm_Faxes)
- [Opportunity_Faxes](#BKMK_Opportunity_Faxes)
- [Quote_Faxes](#BKMK_Quote_Faxes)
- [SalesOrder_Faxes](#BKMK_SalesOrder_Faxes)
- [service_faxes](#BKMK_service_faxes)
- [site_Faxes](#BKMK_site_Faxes)

### <a name="BKMK_bookableresourcebooking_Faxes"></a> bookableresourcebooking_Faxes

One-To-Many Relationship: [bookableresourcebooking bookableresourcebooking_Faxes](bookableresourcebooking.md#BKMK_bookableresourcebooking_Faxes)

|Property|Value|
|---|---|
|ReferencedEntity|`bookableresourcebooking`|
|ReferencedAttribute|`bookableresourcebookingid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_bookableresourcebooking_fax`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_bookableresourcebookingheader_Faxes"></a> bookableresourcebookingheader_Faxes

One-To-Many Relationship: [bookableresourcebookingheader bookableresourcebookingheader_Faxes](bookableresourcebookingheader.md#BKMK_bookableresourcebookingheader_Faxes)

|Property|Value|
|---|---|
|ReferencedEntity|`bookableresourcebookingheader`|
|ReferencedAttribute|`bookableresourcebookingheaderid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_bookableresourcebookingheader_fax`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_BulkOperation_Faxes"></a> BulkOperation_Faxes

One-To-Many Relationship: [bulkoperation BulkOperation_Faxes](bulkoperation.md#BKMK_BulkOperation_Faxes)

|Property|Value|
|---|---|
|ReferencedEntity|`bulkoperation`|
|ReferencedAttribute|`activityid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_bulkoperation_fax`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_Campaign_Faxes"></a> Campaign_Faxes

One-To-Many Relationship: [campaign Campaign_Faxes](campaign.md#BKMK_Campaign_Faxes)

|Property|Value|
|---|---|
|ReferencedEntity|`campaign`|
|ReferencedAttribute|`campaignid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_campaign_fax`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `Cascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_CampaignActivity_Faxes"></a> CampaignActivity_Faxes

One-To-Many Relationship: [campaignactivity CampaignActivity_Faxes](campaignactivity.md#BKMK_CampaignActivity_Faxes)

|Property|Value|
|---|---|
|ReferencedEntity|`campaignactivity`|
|ReferencedAttribute|`activityid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_campaignactivity_fax`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_Contract_Faxes"></a> Contract_Faxes

One-To-Many Relationship: [contract Contract_Faxes](contract.md#BKMK_Contract_Faxes)

|Property|Value|
|---|---|
|ReferencedEntity|`contract`|
|ReferencedAttribute|`contractid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_contract_fax`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_entitlement_Faxes"></a> entitlement_Faxes

One-To-Many Relationship: [entitlement entitlement_Faxes](entitlement.md#BKMK_entitlement_Faxes)

|Property|Value|
|---|---|
|ReferencedEntity|`entitlement`|
|ReferencedAttribute|`entitlementid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_entitlement_fax`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_entitlementtemplate_Faxes"></a> entitlementtemplate_Faxes

One-To-Many Relationship: [entitlementtemplate entitlementtemplate_Faxes](entitlementtemplate.md#BKMK_entitlementtemplate_Faxes)

|Property|Value|
|---|---|
|ReferencedEntity|`entitlementtemplate`|
|ReferencedAttribute|`entitlementtemplateid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_entitlementtemplate_fax`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_Incident_Faxes"></a> Incident_Faxes

One-To-Many Relationship: [incident Incident_Faxes](incident.md#BKMK_Incident_Faxes)

|Property|Value|
|---|---|
|ReferencedEntity|`incident`|
|ReferencedAttribute|`incidentid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_incident_fax`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `Cascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_Invoice_Faxes"></a> Invoice_Faxes

One-To-Many Relationship: [invoice Invoice_Faxes](invoice.md#BKMK_Invoice_Faxes)

|Property|Value|
|---|---|
|ReferencedEntity|`invoice`|
|ReferencedAttribute|`invoiceid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_invoice_fax`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_Lead_Faxes"></a> Lead_Faxes

One-To-Many Relationship: [lead Lead_Faxes](lead.md#BKMK_Lead_Faxes)

|Property|Value|
|---|---|
|ReferencedEntity|`lead`|
|ReferencedAttribute|`leadid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_lead_fax`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `Cascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_customerasset_Faxes"></a> msdyn_customerasset_Faxes

One-To-Many Relationship: [msdyn_customerasset msdyn_customerasset_Faxes](msdyn_customerasset.md#BKMK_msdyn_customerasset_Faxes)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_customerasset`|
|ReferencedAttribute|`msdyn_customerassetid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_customerasset_fax`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_postalbum_Faxes"></a> msdyn_postalbum_Faxes

One-To-Many Relationship: [msdyn_postalbum msdyn_postalbum_Faxes](msdyn_postalbum.md#BKMK_msdyn_postalbum_Faxes)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_postalbum`|
|ReferencedAttribute|`msdyn_postalbumid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_postalbum_fax`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_salessuggestion_Faxes"></a> msdyn_salessuggestion_Faxes

One-To-Many Relationship: [msdyn_salessuggestion msdyn_salessuggestion_Faxes](msdyn_salessuggestion.md#BKMK_msdyn_salessuggestion_Faxes)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_salessuggestion`|
|ReferencedAttribute|`msdyn_salessuggestionid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_salessuggestion_fax`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_swarm_Faxes"></a> msdyn_swarm_Faxes

One-To-Many Relationship: [msdyn_swarm msdyn_swarm_Faxes](msdyn_swarm.md#BKMK_msdyn_swarm_Faxes)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_swarm`|
|ReferencedAttribute|`msdyn_swarmid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_swarm_fax`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_Opportunity_Faxes"></a> Opportunity_Faxes

One-To-Many Relationship: [opportunity Opportunity_Faxes](opportunity.md#BKMK_Opportunity_Faxes)

|Property|Value|
|---|---|
|ReferencedEntity|`opportunity`|
|ReferencedAttribute|`opportunityid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_opportunity_fax`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_Quote_Faxes"></a> Quote_Faxes

One-To-Many Relationship: [quote Quote_Faxes](quote.md#BKMK_Quote_Faxes)

|Property|Value|
|---|---|
|ReferencedEntity|`quote`|
|ReferencedAttribute|`quoteid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_quote_fax`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_SalesOrder_Faxes"></a> SalesOrder_Faxes

One-To-Many Relationship: [salesorder SalesOrder_Faxes](salesorder.md#BKMK_SalesOrder_Faxes)

|Property|Value|
|---|---|
|ReferencedEntity|`salesorder`|
|ReferencedAttribute|`salesorderid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_salesorder_fax`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_service_faxes"></a> service_faxes

One-To-Many Relationship: [service service_faxes](service.md#BKMK_service_faxes)

|Property|Value|
|---|---|
|ReferencedEntity|`service`|
|ReferencedAttribute|`serviceid`|
|ReferencingAttribute|`serviceid`|
|ReferencingEntityNavigationPropertyName|`serviceid_fax`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Restrict`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_site_Faxes"></a> site_Faxes

One-To-Many Relationship: [site site_Faxes](site.md#BKMK_site_Faxes)

|Property|Value|
|---|---|
|ReferencedEntity|`site`|
|ReferencedAttribute|`siteid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_site_fax`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|


## One-to-Many relationships

These relationships are one-to-many. Listed by **SchemaName**.

### <a name="BKMK_fax_campaignresponse"></a> fax_campaignresponse

Many-To-One Relationship: [campaignresponse fax_campaignresponse](campaignresponse.md#BKMK_fax_campaignresponse)

|Property|Value|
|---|---|
|ReferencingEntity|`campaignresponse`|
|ReferencingAttribute|`originatingactivityid`|
|ReferencedEntityNavigationPropertyName|`fax_campaignresponse`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|



### See also

[Dataverse table/entity reference](/power-apps/developer/data-platform/reference/about-entity-reference)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   
<xref:Microsoft.Dynamics.CRM.fax?displayProperty=fullName>
