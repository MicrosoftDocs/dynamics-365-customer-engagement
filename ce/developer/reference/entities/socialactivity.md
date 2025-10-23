---
title: "Social Activity (SocialActivity) table/entity reference (Microsoft Dynamics 365)"
description: "Includes schema information and supported messages for the Social Activity (SocialActivity) table/entity with Microsoft Dynamics 365."
ms.topic: generated-reference
author: JimDaly
ms.author: jdaly
search.audienceType: 
  - developer
---

# Social Activity (SocialActivity) table/entity reference (Microsoft Dynamics 365)

For internal use only.

> [!NOTE]
> The Microsoft Dynamics 365 Social Activity (SocialActivity) table extends the [Microsoft Dataverse Social Activity (SocialActivity) table](/power-apps/developer/data-platform/reference/entities/socialactivity).



## Writable columns/attributes

These columns/attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

### <a name="BKMK_ServiceId"></a> ServiceId

|Property|Value|
|---|---|
|Description|**Unique identifier for the associated service.**|
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
- [From](#BKMK_From)
- [RegardingObjectId](#BKMK_RegardingObjectId)
- [Resources](#BKMK_Resources)
- [To](#BKMK_To)

### <a name="BKMK_Community"></a> Community

Changes from [Community (Microsoft Dataverse)](/power-apps/developer/data-platform/reference/entities/socialactivity#BKMK_Community)

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

### <a name="BKMK_From"></a> From

Changes from [From (Microsoft Dataverse)](/power-apps/developer/data-platform/reference/entities/socialactivity#BKMK_From)

|Property|Value|
|---|---|
|Targets|lead|


### <a name="BKMK_RegardingObjectId"></a> RegardingObjectId

Changes from [RegardingObjectId (Microsoft Dataverse)](/power-apps/developer/data-platform/reference/entities/socialactivity#BKMK_RegardingObjectId)

|Property|Value|
|---|---|
|Targets|bookableresourcebooking, bookableresourcebookingheader, bulkoperation, campaign, campaignactivity, contract, entitlement, entitlementtemplate, incident, invoice, lead, msdyn_customerasset, msdyn_playbookinstance, msdyn_postalbum, msdyn_salessuggestion, msdyn_swarm, opportunity, quote, salesorder, site|


### <a name="BKMK_Resources"></a> Resources

Changes from [Resources (Microsoft Dataverse)](/power-apps/developer/data-platform/reference/entities/socialactivity#BKMK_Resources)

|Property|Value|
|---|---|
|Targets|equipment|


### <a name="BKMK_To"></a> To

Changes from [To (Microsoft Dataverse)](/power-apps/developer/data-platform/reference/entities/socialactivity#BKMK_To)

|Property|Value|
|---|---|
|Targets|lead|


## Many-to-One relationships

These relationships are many-to-one. Listed by **SchemaName**.

- [bookableresourcebooking_SocialActivities](#BKMK_bookableresourcebooking_SocialActivities)
- [bookableresourcebookingheader_SocialActivities](#BKMK_bookableresourcebookingheader_SocialActivities)
- [BulkOperation_SocialActivity](#BKMK_BulkOperation_SocialActivity)
- [campaign_SocialActivities](#BKMK_campaign_SocialActivities)
- [campaignactivity_SocialActivities](#BKMK_campaignactivity_SocialActivities)
- [Contract_SocialActivities](#BKMK_Contract_SocialActivities)
- [entitlement_SocialActivities](#BKMK_entitlement_SocialActivities)
- [entitlementtemplate_SocialActivities](#BKMK_entitlementtemplate_SocialActivities)
- [Incident_SocialActivities](#BKMK_Incident_SocialActivities)
- [Invoice_SocialActivities](#BKMK_Invoice_SocialActivities)
- [Lead_SocialActivities](#BKMK_Lead_SocialActivities)
- [msdyn_customerasset_SocialActivities](#BKMK_msdyn_customerasset_SocialActivities)
- [msdyn_postalbum_SocialActivities](#BKMK_msdyn_postalbum_SocialActivities)
- [msdyn_salessuggestion_SocialActivities](#BKMK_msdyn_salessuggestion_SocialActivities)
- [msdyn_swarm_SocialActivities](#BKMK_msdyn_swarm_SocialActivities)
- [Opportunity_SocialActivities](#BKMK_Opportunity_SocialActivities)
- [Quote_SocialActivities](#BKMK_Quote_SocialActivities)
- [SalesOrder_SocialActivities](#BKMK_SalesOrder_SocialActivities)
- [service_socialactivities](#BKMK_service_socialactivities)
- [site_SocialActivities](#BKMK_site_SocialActivities)

### <a name="BKMK_bookableresourcebooking_SocialActivities"></a> bookableresourcebooking_SocialActivities

One-To-Many Relationship: [bookableresourcebooking bookableresourcebooking_SocialActivities](bookableresourcebooking.md#BKMK_bookableresourcebooking_SocialActivities)

|Property|Value|
|---|---|
|ReferencedEntity|`bookableresourcebooking`|
|ReferencedAttribute|`bookableresourcebookingid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_bookableresourcebooking_socialactivity`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_bookableresourcebookingheader_SocialActivities"></a> bookableresourcebookingheader_SocialActivities

One-To-Many Relationship: [bookableresourcebookingheader bookableresourcebookingheader_SocialActivities](bookableresourcebookingheader.md#BKMK_bookableresourcebookingheader_SocialActivities)

|Property|Value|
|---|---|
|ReferencedEntity|`bookableresourcebookingheader`|
|ReferencedAttribute|`bookableresourcebookingheaderid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_bookableresourcebookingheader_socialactivity`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_BulkOperation_SocialActivity"></a> BulkOperation_SocialActivity

One-To-Many Relationship: [bulkoperation BulkOperation_SocialActivity](bulkoperation.md#BKMK_BulkOperation_SocialActivity)

|Property|Value|
|---|---|
|ReferencedEntity|`bulkoperation`|
|ReferencedAttribute|`activityid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_bulkoperation_socialactivity`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_campaign_SocialActivities"></a> campaign_SocialActivities

One-To-Many Relationship: [campaign campaign_SocialActivities](campaign.md#BKMK_campaign_SocialActivities)

|Property|Value|
|---|---|
|ReferencedEntity|`campaign`|
|ReferencedAttribute|`campaignid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_campaign_socialactivity`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_campaignactivity_SocialActivities"></a> campaignactivity_SocialActivities

One-To-Many Relationship: [campaignactivity campaignactivity_SocialActivities](campaignactivity.md#BKMK_campaignactivity_SocialActivities)

|Property|Value|
|---|---|
|ReferencedEntity|`campaignactivity`|
|ReferencedAttribute|`activityid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_campaignactivity_socialactivity`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_Contract_SocialActivities"></a> Contract_SocialActivities

One-To-Many Relationship: [contract Contract_SocialActivities](contract.md#BKMK_Contract_SocialActivities)

|Property|Value|
|---|---|
|ReferencedEntity|`contract`|
|ReferencedAttribute|`contractid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_contract_socialactivity`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_entitlement_SocialActivities"></a> entitlement_SocialActivities

One-To-Many Relationship: [entitlement entitlement_SocialActivities](entitlement.md#BKMK_entitlement_SocialActivities)

|Property|Value|
|---|---|
|ReferencedEntity|`entitlement`|
|ReferencedAttribute|`entitlementid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_entitlement_socialactivity`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_entitlementtemplate_SocialActivities"></a> entitlementtemplate_SocialActivities

One-To-Many Relationship: [entitlementtemplate entitlementtemplate_SocialActivities](entitlementtemplate.md#BKMK_entitlementtemplate_SocialActivities)

|Property|Value|
|---|---|
|ReferencedEntity|`entitlementtemplate`|
|ReferencedAttribute|`entitlementtemplateid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_entitlementtemplate_socialactivity`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_Incident_SocialActivities"></a> Incident_SocialActivities

One-To-Many Relationship: [incident Incident_SocialActivities](incident.md#BKMK_Incident_SocialActivities)

|Property|Value|
|---|---|
|ReferencedEntity|`incident`|
|ReferencedAttribute|`incidentid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_incident_socialactivity`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_Invoice_SocialActivities"></a> Invoice_SocialActivities

One-To-Many Relationship: [invoice Invoice_SocialActivities](invoice.md#BKMK_Invoice_SocialActivities)

|Property|Value|
|---|---|
|ReferencedEntity|`invoice`|
|ReferencedAttribute|`invoiceid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_invoice_socialactivity`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_Lead_SocialActivities"></a> Lead_SocialActivities

One-To-Many Relationship: [lead Lead_SocialActivities](lead.md#BKMK_Lead_SocialActivities)

|Property|Value|
|---|---|
|ReferencedEntity|`lead`|
|ReferencedAttribute|`leadid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_lead_socialactivity`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `Cascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_customerasset_SocialActivities"></a> msdyn_customerasset_SocialActivities

One-To-Many Relationship: [msdyn_customerasset msdyn_customerasset_SocialActivities](msdyn_customerasset.md#BKMK_msdyn_customerasset_SocialActivities)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_customerasset`|
|ReferencedAttribute|`msdyn_customerassetid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_customerasset_socialactivity`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_postalbum_SocialActivities"></a> msdyn_postalbum_SocialActivities

One-To-Many Relationship: [msdyn_postalbum msdyn_postalbum_SocialActivities](msdyn_postalbum.md#BKMK_msdyn_postalbum_SocialActivities)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_postalbum`|
|ReferencedAttribute|`msdyn_postalbumid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_postalbum_socialactivity`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_salessuggestion_SocialActivities"></a> msdyn_salessuggestion_SocialActivities

One-To-Many Relationship: [msdyn_salessuggestion msdyn_salessuggestion_SocialActivities](msdyn_salessuggestion.md#BKMK_msdyn_salessuggestion_SocialActivities)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_salessuggestion`|
|ReferencedAttribute|`msdyn_salessuggestionid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_salessuggestion_socialactivity`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_swarm_SocialActivities"></a> msdyn_swarm_SocialActivities

One-To-Many Relationship: [msdyn_swarm msdyn_swarm_SocialActivities](msdyn_swarm.md#BKMK_msdyn_swarm_SocialActivities)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_swarm`|
|ReferencedAttribute|`msdyn_swarmid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_swarm_socialactivity`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_Opportunity_SocialActivities"></a> Opportunity_SocialActivities

One-To-Many Relationship: [opportunity Opportunity_SocialActivities](opportunity.md#BKMK_Opportunity_SocialActivities)

|Property|Value|
|---|---|
|ReferencedEntity|`opportunity`|
|ReferencedAttribute|`opportunityid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_opportunity_socialactivity`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_Quote_SocialActivities"></a> Quote_SocialActivities

One-To-Many Relationship: [quote Quote_SocialActivities](quote.md#BKMK_Quote_SocialActivities)

|Property|Value|
|---|---|
|ReferencedEntity|`quote`|
|ReferencedAttribute|`quoteid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_quote_socialactivity`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_SalesOrder_SocialActivities"></a> SalesOrder_SocialActivities

One-To-Many Relationship: [salesorder SalesOrder_SocialActivities](salesorder.md#BKMK_SalesOrder_SocialActivities)

|Property|Value|
|---|---|
|ReferencedEntity|`salesorder`|
|ReferencedAttribute|`salesorderid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_salesorder_socialactivity`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_service_socialactivities"></a> service_socialactivities

One-To-Many Relationship: [service service_socialactivities](service.md#BKMK_service_socialactivities)

|Property|Value|
|---|---|
|ReferencedEntity|`service`|
|ReferencedAttribute|`serviceid`|
|ReferencingAttribute|`serviceid`|
|ReferencingEntityNavigationPropertyName|`serviceid_socialactivity`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Restrict`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_site_SocialActivities"></a> site_SocialActivities

One-To-Many Relationship: [site site_SocialActivities](site.md#BKMK_site_SocialActivities)

|Property|Value|
|---|---|
|ReferencedEntity|`site`|
|ReferencedAttribute|`siteid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_site_socialactivity`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|



### See also

[Dataverse table/entity reference](/power-apps/developer/data-platform/reference/about-entity-reference)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   
<xref:Microsoft.Dynamics.CRM.socialactivity?displayProperty=fullName>
