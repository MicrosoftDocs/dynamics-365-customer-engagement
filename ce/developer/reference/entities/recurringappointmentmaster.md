---
title: "Recurring Appointment (RecurringAppointmentMaster) table/entity reference (Microsoft Dynamics 365)"
description: "Includes schema information and supported messages for the Recurring Appointment (RecurringAppointmentMaster) table/entity with Microsoft Dynamics 365."
ms.topic: generated-reference
author: JimDaly
ms.author: jdaly
search.audienceType: 
  - developer
---

# Recurring Appointment (RecurringAppointmentMaster) table/entity reference (Microsoft Dynamics 365)

The Master appointment of a recurring appointment series.

> [!NOTE]
> The Microsoft Dynamics 365 Recurring Appointment (RecurringAppointmentMaster) table extends the [Microsoft Dataverse Recurring Appointment (RecurringAppointmentMaster) table](/power-apps/developer/data-platform/reference/entities/recurringappointmentmaster).



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

- [OptionalAttendees](#BKMK_OptionalAttendees)
- [RegardingObjectId](#BKMK_RegardingObjectId)
- [RequiredAttendees](#BKMK_RequiredAttendees)

### <a name="BKMK_OptionalAttendees"></a> OptionalAttendees

Changes from [OptionalAttendees (Microsoft Dataverse)](/power-apps/developer/data-platform/reference/entities/recurringappointmentmaster#BKMK_OptionalAttendees)

|Property|Value|
|---|---|
|Targets|equipment, lead|


### <a name="BKMK_RegardingObjectId"></a> RegardingObjectId

Changes from [RegardingObjectId (Microsoft Dataverse)](/power-apps/developer/data-platform/reference/entities/recurringappointmentmaster#BKMK_RegardingObjectId)

|Property|Value|
|---|---|
|Targets|bookableresourcebooking, bookableresourcebookingheader, bulkoperation, campaign, campaignactivity, contract, entitlement, entitlementtemplate, incident, invoice, lead, msdyn_customerasset, msdyn_playbookinstance, msdyn_postalbum, msdyn_salessuggestion, msdyn_swarm, opportunity, quote, salesorder, site|


### <a name="BKMK_RequiredAttendees"></a> RequiredAttendees

Changes from [RequiredAttendees (Microsoft Dataverse)](/power-apps/developer/data-platform/reference/entities/recurringappointmentmaster#BKMK_RequiredAttendees)

|Property|Value|
|---|---|
|Targets|equipment, lead|


## Many-to-One relationships

These relationships are many-to-one. Listed by **SchemaName**.

- [bookableresourcebooking_RecurringAppointmentMasters](#BKMK_bookableresourcebooking_RecurringAppointmentMasters)
- [bookableresourcebookingheader_RecurringAppointmentMasters](#BKMK_bookableresourcebookingheader_RecurringAppointmentMasters)
- [BulkOperation_RecurringAppointmentMaster](#BKMK_BulkOperation_RecurringAppointmentMaster)
- [Campaign_RecurringAppointmentMasters](#BKMK_Campaign_RecurringAppointmentMasters)
- [CampaignActivity_RecurringAppointmentMasters](#BKMK_CampaignActivity_RecurringAppointmentMasters)
- [Contract_RecurringAppointmentMasters](#BKMK_Contract_RecurringAppointmentMasters)
- [entitlement_RecurringAppointmentMasters](#BKMK_entitlement_RecurringAppointmentMasters)
- [entitlementtemplate_RecurringAppointmentMasters](#BKMK_entitlementtemplate_RecurringAppointmentMasters)
- [Incident_RecurringAppointmentMasters](#BKMK_Incident_RecurringAppointmentMasters)
- [Invoice_RecurringAppointmentMasters](#BKMK_Invoice_RecurringAppointmentMasters)
- [Lead_RecurringAppointmentMasters](#BKMK_Lead_RecurringAppointmentMasters)
- [msdyn_customerasset_RecurringAppointmentMasters](#BKMK_msdyn_customerasset_RecurringAppointmentMasters)
- [msdyn_postalbum_RecurringAppointmentMasters](#BKMK_msdyn_postalbum_RecurringAppointmentMasters)
- [msdyn_salessuggestion_RecurringAppointmentMasters](#BKMK_msdyn_salessuggestion_RecurringAppointmentMasters)
- [msdyn_swarm_RecurringAppointmentMasters](#BKMK_msdyn_swarm_RecurringAppointmentMasters)
- [Opportunity_RecurringAppointmentMasters](#BKMK_Opportunity_RecurringAppointmentMasters)
- [Quote_RecurringAppointmentMasters](#BKMK_Quote_RecurringAppointmentMasters)
- [SalesOrder_RecurringAppointmentMasters](#BKMK_SalesOrder_RecurringAppointmentMasters)
- [service_recurringappointmentmasters](#BKMK_service_recurringappointmentmasters)
- [site_RecurringAppointmentMasters](#BKMK_site_RecurringAppointmentMasters)

### <a name="BKMK_bookableresourcebooking_RecurringAppointmentMasters"></a> bookableresourcebooking_RecurringAppointmentMasters

One-To-Many Relationship: [bookableresourcebooking bookableresourcebooking_RecurringAppointmentMasters](bookableresourcebooking.md#BKMK_bookableresourcebooking_RecurringAppointmentMasters)

|Property|Value|
|---|---|
|ReferencedEntity|`bookableresourcebooking`|
|ReferencedAttribute|`bookableresourcebookingid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_bookableresourcebooking_recurringappointmentmaster`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_bookableresourcebookingheader_RecurringAppointmentMasters"></a> bookableresourcebookingheader_RecurringAppointmentMasters

One-To-Many Relationship: [bookableresourcebookingheader bookableresourcebookingheader_RecurringAppointmentMasters](bookableresourcebookingheader.md#BKMK_bookableresourcebookingheader_RecurringAppointmentMasters)

|Property|Value|
|---|---|
|ReferencedEntity|`bookableresourcebookingheader`|
|ReferencedAttribute|`bookableresourcebookingheaderid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_bookableresourcebookingheader_recurringappointmentmaster`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_BulkOperation_RecurringAppointmentMaster"></a> BulkOperation_RecurringAppointmentMaster

One-To-Many Relationship: [bulkoperation BulkOperation_RecurringAppointmentMaster](bulkoperation.md#BKMK_BulkOperation_RecurringAppointmentMaster)

|Property|Value|
|---|---|
|ReferencedEntity|`bulkoperation`|
|ReferencedAttribute|`activityid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_bulkoperation_recurringappointmentmaster`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_Campaign_RecurringAppointmentMasters"></a> Campaign_RecurringAppointmentMasters

One-To-Many Relationship: [campaign Campaign_RecurringAppointmentMasters](campaign.md#BKMK_Campaign_RecurringAppointmentMasters)

|Property|Value|
|---|---|
|ReferencedEntity|`campaign`|
|ReferencedAttribute|`campaignid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_campaign_recurringappointmentmaster`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `Cascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_CampaignActivity_RecurringAppointmentMasters"></a> CampaignActivity_RecurringAppointmentMasters

One-To-Many Relationship: [campaignactivity CampaignActivity_RecurringAppointmentMasters](campaignactivity.md#BKMK_CampaignActivity_RecurringAppointmentMasters)

|Property|Value|
|---|---|
|ReferencedEntity|`campaignactivity`|
|ReferencedAttribute|`activityid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_campaignactivity_recurringappointmentmaster`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_Contract_RecurringAppointmentMasters"></a> Contract_RecurringAppointmentMasters

One-To-Many Relationship: [contract Contract_RecurringAppointmentMasters](contract.md#BKMK_Contract_RecurringAppointmentMasters)

|Property|Value|
|---|---|
|ReferencedEntity|`contract`|
|ReferencedAttribute|`contractid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_contract_recurringappointmentmaster`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_entitlement_RecurringAppointmentMasters"></a> entitlement_RecurringAppointmentMasters

One-To-Many Relationship: [entitlement entitlement_RecurringAppointmentMasters](entitlement.md#BKMK_entitlement_RecurringAppointmentMasters)

|Property|Value|
|---|---|
|ReferencedEntity|`entitlement`|
|ReferencedAttribute|`entitlementid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_entitlement_recurringappointmentmaster`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_entitlementtemplate_RecurringAppointmentMasters"></a> entitlementtemplate_RecurringAppointmentMasters

One-To-Many Relationship: [entitlementtemplate entitlementtemplate_RecurringAppointmentMasters](entitlementtemplate.md#BKMK_entitlementtemplate_RecurringAppointmentMasters)

|Property|Value|
|---|---|
|ReferencedEntity|`entitlementtemplate`|
|ReferencedAttribute|`entitlementtemplateid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_entitlementtemplate_recurringappointmentmaster`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_Incident_RecurringAppointmentMasters"></a> Incident_RecurringAppointmentMasters

One-To-Many Relationship: [incident Incident_RecurringAppointmentMasters](incident.md#BKMK_Incident_RecurringAppointmentMasters)

|Property|Value|
|---|---|
|ReferencedEntity|`incident`|
|ReferencedAttribute|`incidentid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_incident_recurringappointmentmaster`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `Cascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_Invoice_RecurringAppointmentMasters"></a> Invoice_RecurringAppointmentMasters

One-To-Many Relationship: [invoice Invoice_RecurringAppointmentMasters](invoice.md#BKMK_Invoice_RecurringAppointmentMasters)

|Property|Value|
|---|---|
|ReferencedEntity|`invoice`|
|ReferencedAttribute|`invoiceid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_invoice_recurringappointmentmaster`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_Lead_RecurringAppointmentMasters"></a> Lead_RecurringAppointmentMasters

One-To-Many Relationship: [lead Lead_RecurringAppointmentMasters](lead.md#BKMK_Lead_RecurringAppointmentMasters)

|Property|Value|
|---|---|
|ReferencedEntity|`lead`|
|ReferencedAttribute|`leadid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_lead_recurringappointmentmaster`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `Cascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_customerasset_RecurringAppointmentMasters"></a> msdyn_customerasset_RecurringAppointmentMasters

One-To-Many Relationship: [msdyn_customerasset msdyn_customerasset_RecurringAppointmentMasters](msdyn_customerasset.md#BKMK_msdyn_customerasset_RecurringAppointmentMasters)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_customerasset`|
|ReferencedAttribute|`msdyn_customerassetid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_customerasset_recurringappointmentmaster`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_postalbum_RecurringAppointmentMasters"></a> msdyn_postalbum_RecurringAppointmentMasters

One-To-Many Relationship: [msdyn_postalbum msdyn_postalbum_RecurringAppointmentMasters](msdyn_postalbum.md#BKMK_msdyn_postalbum_RecurringAppointmentMasters)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_postalbum`|
|ReferencedAttribute|`msdyn_postalbumid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_postalbum_recurringappointmentmaster`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_salessuggestion_RecurringAppointmentMasters"></a> msdyn_salessuggestion_RecurringAppointmentMasters

One-To-Many Relationship: [msdyn_salessuggestion msdyn_salessuggestion_RecurringAppointmentMasters](msdyn_salessuggestion.md#BKMK_msdyn_salessuggestion_RecurringAppointmentMasters)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_salessuggestion`|
|ReferencedAttribute|`msdyn_salessuggestionid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_salessuggestion_recurringappointmentmaster`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_swarm_RecurringAppointmentMasters"></a> msdyn_swarm_RecurringAppointmentMasters

One-To-Many Relationship: [msdyn_swarm msdyn_swarm_RecurringAppointmentMasters](msdyn_swarm.md#BKMK_msdyn_swarm_RecurringAppointmentMasters)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_swarm`|
|ReferencedAttribute|`msdyn_swarmid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_swarm_recurringappointmentmaster`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_Opportunity_RecurringAppointmentMasters"></a> Opportunity_RecurringAppointmentMasters

One-To-Many Relationship: [opportunity Opportunity_RecurringAppointmentMasters](opportunity.md#BKMK_Opportunity_RecurringAppointmentMasters)

|Property|Value|
|---|---|
|ReferencedEntity|`opportunity`|
|ReferencedAttribute|`opportunityid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_opportunity_recurringappointmentmaster`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_Quote_RecurringAppointmentMasters"></a> Quote_RecurringAppointmentMasters

One-To-Many Relationship: [quote Quote_RecurringAppointmentMasters](quote.md#BKMK_Quote_RecurringAppointmentMasters)

|Property|Value|
|---|---|
|ReferencedEntity|`quote`|
|ReferencedAttribute|`quoteid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_quote_recurringappointmentmaster`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_SalesOrder_RecurringAppointmentMasters"></a> SalesOrder_RecurringAppointmentMasters

One-To-Many Relationship: [salesorder SalesOrder_RecurringAppointmentMasters](salesorder.md#BKMK_SalesOrder_RecurringAppointmentMasters)

|Property|Value|
|---|---|
|ReferencedEntity|`salesorder`|
|ReferencedAttribute|`salesorderid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_salesorder_recurringappointmentmaster`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_service_recurringappointmentmasters"></a> service_recurringappointmentmasters

One-To-Many Relationship: [service service_recurringappointmentmasters](service.md#BKMK_service_recurringappointmentmasters)

|Property|Value|
|---|---|
|ReferencedEntity|`service`|
|ReferencedAttribute|`serviceid`|
|ReferencingAttribute|`serviceid`|
|ReferencingEntityNavigationPropertyName|`serviceid_recurringappointmentmaster`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Restrict`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_site_RecurringAppointmentMasters"></a> site_RecurringAppointmentMasters

One-To-Many Relationship: [site site_RecurringAppointmentMasters](site.md#BKMK_site_RecurringAppointmentMasters)

|Property|Value|
|---|---|
|ReferencedEntity|`site`|
|ReferencedAttribute|`siteid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_site_recurringappointmentmaster`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|


## One-to-Many relationships

These relationships are one-to-many. Listed by **SchemaName**.

### <a name="BKMK_recurringappointmentmaster_campaignresponse"></a> recurringappointmentmaster_campaignresponse

Many-To-One Relationship: [campaignresponse recurringappointmentmaster_campaignresponse](campaignresponse.md#BKMK_recurringappointmentmaster_campaignresponse)

|Property|Value|
|---|---|
|ReferencingEntity|`campaignresponse`|
|ReferencingAttribute|`originatingactivityid`|
|ReferencedEntityNavigationPropertyName|`recurringappointmentmaster_campaignresponse`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|



### See also

[Dataverse table/entity reference](/power-apps/developer/data-platform/reference/about-entity-reference)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   
<xref:Microsoft.Dynamics.CRM.recurringappointmentmaster?displayProperty=fullName>
