---
title: "Appointment table/entity reference (Microsoft Dynamics 365)"
description: "Includes schema information and supported messages for the Appointment table/entity with Microsoft Dynamics 365."
ms.topic: generated-reference
author: JimDaly
ms.author: jdaly
search.audienceType: 
  - developer
---

# Appointment table/entity reference (Microsoft Dynamics 365)

Commitment representing a time interval with start/end times and duration.

> [!NOTE]
> The Microsoft Dynamics 365 Appointment table extends the [Microsoft Dataverse Appointment table](/power-apps/developer/data-platform/reference/entities/appointment).



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
- [requiredattendees](#BKMK_requiredattendees)

### <a name="BKMK_OptionalAttendees"></a> OptionalAttendees

Changes from [OptionalAttendees (Microsoft Dataverse)](/power-apps/developer/data-platform/reference/entities/appointment#BKMK_OptionalAttendees)

|Property|Value|
|---|---|
|Targets|entitlement, equipment, lead, msdyn_salessuggestion|


### <a name="BKMK_RegardingObjectId"></a> RegardingObjectId

Changes from [RegardingObjectId (Microsoft Dataverse)](/power-apps/developer/data-platform/reference/entities/appointment#BKMK_RegardingObjectId)

|Property|Value|
|---|---|
|Targets|bookableresourcebooking, bookableresourcebookingheader, bulkoperation, campaign, campaignactivity, contract, entitlement, entitlementtemplate, incident, invoice, lead, msdyn_customerasset, msdyn_playbookinstance, msdyn_postalbum, msdyn_salessuggestion, msdyn_swarm, opportunity, quote, salesorder, site|


### <a name="BKMK_requiredattendees"></a> requiredattendees

Changes from [requiredattendees (Microsoft Dataverse)](/power-apps/developer/data-platform/reference/entities/appointment#BKMK_requiredattendees)

|Property|Value|
|---|---|
|Targets|entitlement, equipment, lead, msdyn_salessuggestion|


## Many-to-One relationships

These relationships are many-to-one. Listed by **SchemaName**.

- [bookableresourcebooking_Appointments](#BKMK_bookableresourcebooking_Appointments)
- [bookableresourcebookingheader_Appointments](#BKMK_bookableresourcebookingheader_Appointments)
- [BulkOperation_Appointment](#BKMK_BulkOperation_Appointment)
- [Campaign_Appointments](#BKMK_Campaign_Appointments)
- [CampaignActivity_Appointments](#BKMK_CampaignActivity_Appointments)
- [Contract_Appointments](#BKMK_Contract_Appointments)
- [entitlement_Appointments](#BKMK_entitlement_Appointments)
- [entitlementtemplate_Appointments](#BKMK_entitlementtemplate_Appointments)
- [Incident_Appointments](#BKMK_Incident_Appointments)
- [Invoice_Appointments](#BKMK_Invoice_Appointments)
- [Lead_Appointments](#BKMK_Lead_Appointments)
- [msdyn_customerasset_Appointments](#BKMK_msdyn_customerasset_Appointments)
- [msdyn_postalbum_Appointments](#BKMK_msdyn_postalbum_Appointments)
- [msdyn_salessuggestion_Appointments](#BKMK_msdyn_salessuggestion_Appointments)
- [msdyn_swarm_Appointments](#BKMK_msdyn_swarm_Appointments)
- [Opportunity_Appointments](#BKMK_Opportunity_Appointments)
- [Quote_Appointments](#BKMK_Quote_Appointments)
- [SalesOrder_Appointments](#BKMK_SalesOrder_Appointments)
- [service_appointments](#BKMK_service_appointments)
- [site_Appointments](#BKMK_site_Appointments)

### <a name="BKMK_bookableresourcebooking_Appointments"></a> bookableresourcebooking_Appointments

One-To-Many Relationship: [bookableresourcebooking bookableresourcebooking_Appointments](bookableresourcebooking.md#BKMK_bookableresourcebooking_Appointments)

|Property|Value|
|---|---|
|ReferencedEntity|`bookableresourcebooking`|
|ReferencedAttribute|`bookableresourcebookingid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_bookableresourcebooking_appointment`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_bookableresourcebookingheader_Appointments"></a> bookableresourcebookingheader_Appointments

One-To-Many Relationship: [bookableresourcebookingheader bookableresourcebookingheader_Appointments](bookableresourcebookingheader.md#BKMK_bookableresourcebookingheader_Appointments)

|Property|Value|
|---|---|
|ReferencedEntity|`bookableresourcebookingheader`|
|ReferencedAttribute|`bookableresourcebookingheaderid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_bookableresourcebookingheader_appointment`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_BulkOperation_Appointment"></a> BulkOperation_Appointment

One-To-Many Relationship: [bulkoperation BulkOperation_Appointment](bulkoperation.md#BKMK_BulkOperation_Appointment)

|Property|Value|
|---|---|
|ReferencedEntity|`bulkoperation`|
|ReferencedAttribute|`activityid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_bulkoperation_appointment`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_Campaign_Appointments"></a> Campaign_Appointments

One-To-Many Relationship: [campaign Campaign_Appointments](campaign.md#BKMK_Campaign_Appointments)

|Property|Value|
|---|---|
|ReferencedEntity|`campaign`|
|ReferencedAttribute|`campaignid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_campaign_appointment`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `Cascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_CampaignActivity_Appointments"></a> CampaignActivity_Appointments

One-To-Many Relationship: [campaignactivity CampaignActivity_Appointments](campaignactivity.md#BKMK_CampaignActivity_Appointments)

|Property|Value|
|---|---|
|ReferencedEntity|`campaignactivity`|
|ReferencedAttribute|`activityid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_campaignactivity_appointment`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_Contract_Appointments"></a> Contract_Appointments

One-To-Many Relationship: [contract Contract_Appointments](contract.md#BKMK_Contract_Appointments)

|Property|Value|
|---|---|
|ReferencedEntity|`contract`|
|ReferencedAttribute|`contractid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_contract_appointment`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_entitlement_Appointments"></a> entitlement_Appointments

One-To-Many Relationship: [entitlement entitlement_Appointments](entitlement.md#BKMK_entitlement_Appointments)

|Property|Value|
|---|---|
|ReferencedEntity|`entitlement`|
|ReferencedAttribute|`entitlementid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_entitlement_appointment`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_entitlementtemplate_Appointments"></a> entitlementtemplate_Appointments

One-To-Many Relationship: [entitlementtemplate entitlementtemplate_Appointments](entitlementtemplate.md#BKMK_entitlementtemplate_Appointments)

|Property|Value|
|---|---|
|ReferencedEntity|`entitlementtemplate`|
|ReferencedAttribute|`entitlementtemplateid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_entitlementtemplate_appointment`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_Incident_Appointments"></a> Incident_Appointments

One-To-Many Relationship: [incident Incident_Appointments](incident.md#BKMK_Incident_Appointments)

|Property|Value|
|---|---|
|ReferencedEntity|`incident`|
|ReferencedAttribute|`incidentid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_incident_appointment`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `Cascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_Invoice_Appointments"></a> Invoice_Appointments

One-To-Many Relationship: [invoice Invoice_Appointments](invoice.md#BKMK_Invoice_Appointments)

|Property|Value|
|---|---|
|ReferencedEntity|`invoice`|
|ReferencedAttribute|`invoiceid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_invoice_appointment`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_Lead_Appointments"></a> Lead_Appointments

One-To-Many Relationship: [lead Lead_Appointments](lead.md#BKMK_Lead_Appointments)

|Property|Value|
|---|---|
|ReferencedEntity|`lead`|
|ReferencedAttribute|`leadid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_lead_appointment`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `Cascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_customerasset_Appointments"></a> msdyn_customerasset_Appointments

One-To-Many Relationship: [msdyn_customerasset msdyn_customerasset_Appointments](msdyn_customerasset.md#BKMK_msdyn_customerasset_Appointments)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_customerasset`|
|ReferencedAttribute|`msdyn_customerassetid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_customerasset_appointment`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_postalbum_Appointments"></a> msdyn_postalbum_Appointments

One-To-Many Relationship: [msdyn_postalbum msdyn_postalbum_Appointments](msdyn_postalbum.md#BKMK_msdyn_postalbum_Appointments)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_postalbum`|
|ReferencedAttribute|`msdyn_postalbumid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_postalbum_appointment`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_salessuggestion_Appointments"></a> msdyn_salessuggestion_Appointments

One-To-Many Relationship: [msdyn_salessuggestion msdyn_salessuggestion_Appointments](msdyn_salessuggestion.md#BKMK_msdyn_salessuggestion_Appointments)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_salessuggestion`|
|ReferencedAttribute|`msdyn_salessuggestionid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_salessuggestion_appointment`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_swarm_Appointments"></a> msdyn_swarm_Appointments

One-To-Many Relationship: [msdyn_swarm msdyn_swarm_Appointments](msdyn_swarm.md#BKMK_msdyn_swarm_Appointments)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_swarm`|
|ReferencedAttribute|`msdyn_swarmid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_swarm_appointment`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_Opportunity_Appointments"></a> Opportunity_Appointments

One-To-Many Relationship: [opportunity Opportunity_Appointments](opportunity.md#BKMK_Opportunity_Appointments)

|Property|Value|
|---|---|
|ReferencedEntity|`opportunity`|
|ReferencedAttribute|`opportunityid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_opportunity_appointment`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_Quote_Appointments"></a> Quote_Appointments

One-To-Many Relationship: [quote Quote_Appointments](quote.md#BKMK_Quote_Appointments)

|Property|Value|
|---|---|
|ReferencedEntity|`quote`|
|ReferencedAttribute|`quoteid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_quote_appointment`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_SalesOrder_Appointments"></a> SalesOrder_Appointments

One-To-Many Relationship: [salesorder SalesOrder_Appointments](salesorder.md#BKMK_SalesOrder_Appointments)

|Property|Value|
|---|---|
|ReferencedEntity|`salesorder`|
|ReferencedAttribute|`salesorderid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_salesorder_appointment`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_service_appointments"></a> service_appointments

One-To-Many Relationship: [service service_appointments](service.md#BKMK_service_appointments)

|Property|Value|
|---|---|
|ReferencedEntity|`service`|
|ReferencedAttribute|`serviceid`|
|ReferencingAttribute|`serviceid`|
|ReferencingEntityNavigationPropertyName|`serviceid_appointment`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Restrict`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_site_Appointments"></a> site_Appointments

One-To-Many Relationship: [site site_Appointments](site.md#BKMK_site_Appointments)

|Property|Value|
|---|---|
|ReferencedEntity|`site`|
|ReferencedAttribute|`siteid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_site_appointment`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|


## One-to-Many relationships

These relationships are one-to-many. Listed by **SchemaName**.

- [appointment_campaignresponse](#BKMK_appointment_campaignresponse)
- [msdyn_appointment_msdyn_conversationinsight_conversationinsighttarget](#BKMK_msdyn_appointment_msdyn_conversationinsight_conversationinsighttarget)
- [msdyn_appointment_msdyn_externalrecord](#BKMK_msdyn_appointment_msdyn_externalrecord)
- [msdyn_appointment_msdyn_ocrecording_recordingtarget](#BKMK_msdyn_appointment_msdyn_ocrecording_recordingtarget)
- [msdyn_appointment_msdyn_transcript_transcripttarget](#BKMK_msdyn_appointment_msdyn_transcript_transcripttarget)
- [msdyn_msdyn_conversationactionitem_appointment_msdyn_CreatedActivity](#BKMK_msdyn_msdyn_conversationactionitem_appointment_msdyn_CreatedActivity)
- [msdyn_msdyn_salescopilotinsight_appointment_msdyn_activityid](#BKMK_msdyn_msdyn_salescopilotinsight_appointment_msdyn_activityid)
- [msdyn_msdyn_sciconversation_appointment_msdyn_RelatedActivity](#BKMK_msdyn_msdyn_sciconversation_appointment_msdyn_RelatedActivity)

### <a name="BKMK_appointment_campaignresponse"></a> appointment_campaignresponse

Many-To-One Relationship: [campaignresponse appointment_campaignresponse](campaignresponse.md#BKMK_appointment_campaignresponse)

|Property|Value|
|---|---|
|ReferencingEntity|`campaignresponse`|
|ReferencingAttribute|`originatingactivityid`|
|ReferencedEntityNavigationPropertyName|`appointment_campaignresponse`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_appointment_msdyn_conversationinsight_conversationinsighttarget"></a> msdyn_appointment_msdyn_conversationinsight_conversationinsighttarget

Many-To-One Relationship: [msdyn_conversationinsight msdyn_appointment_msdyn_conversationinsight_conversationinsighttarget](msdyn_conversationinsight.md#BKMK_msdyn_appointment_msdyn_conversationinsight_conversationinsighttarget)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_conversationinsight`|
|ReferencingAttribute|`msdyn_conversationinsighttarget`|
|ReferencedEntityNavigationPropertyName|`msdyn_appointment_msdyn_conversationinsight_conversationinsighttarget`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_appointment_msdyn_externalrecord"></a> msdyn_appointment_msdyn_externalrecord

Many-To-One Relationship: [msdyn_externalrecord msdyn_appointment_msdyn_externalrecord](msdyn_externalrecord.md#BKMK_msdyn_appointment_msdyn_externalrecord)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_externalrecord`|
|ReferencingAttribute|`msdyn_referencerecord`|
|ReferencedEntityNavigationPropertyName|`msdyn_appointment_msdyn_externalrecord`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_appointment_msdyn_ocrecording_recordingtarget"></a> msdyn_appointment_msdyn_ocrecording_recordingtarget

Many-To-One Relationship: [msdyn_ocrecording msdyn_appointment_msdyn_ocrecording_recordingtarget](msdyn_ocrecording.md#BKMK_msdyn_appointment_msdyn_ocrecording_recordingtarget)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocrecording`|
|ReferencingAttribute|`msdyn_recordingtarget`|
|ReferencedEntityNavigationPropertyName|`msdyn_appointment_msdyn_ocrecording_recordingtarget`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_appointment_msdyn_transcript_transcripttarget"></a> msdyn_appointment_msdyn_transcript_transcripttarget

Many-To-One Relationship: [msdyn_transcript msdyn_appointment_msdyn_transcript_transcripttarget](msdyn_transcript.md#BKMK_msdyn_appointment_msdyn_transcript_transcripttarget)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_transcript`|
|ReferencingAttribute|`msdyn_transcripttarget`|
|ReferencedEntityNavigationPropertyName|`msdyn_appointment_msdyn_transcript_transcripttarget`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_msdyn_conversationactionitem_appointment_msdyn_CreatedActivity"></a> msdyn_msdyn_conversationactionitem_appointment_msdyn_CreatedActivity

Many-To-One Relationship: [msdyn_conversationactionitem msdyn_msdyn_conversationactionitem_appointment_msdyn_CreatedActivity](msdyn_conversationactionitem.md#BKMK_msdyn_msdyn_conversationactionitem_appointment_msdyn_CreatedActivity)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_conversationactionitem`|
|ReferencingAttribute|`msdyn_createdactivity`|
|ReferencedEntityNavigationPropertyName|`msdyn_msdyn_conversationactionitem_appointment_msdyn_createdactivity`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_msdyn_salescopilotinsight_appointment_msdyn_activityid"></a> msdyn_msdyn_salescopilotinsight_appointment_msdyn_activityid

Many-To-One Relationship: [msdyn_salescopilotinsight msdyn_msdyn_salescopilotinsight_appointment_msdyn_activityid](msdyn_salescopilotinsight.md#BKMK_msdyn_msdyn_salescopilotinsight_appointment_msdyn_activityid)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_salescopilotinsight`|
|ReferencingAttribute|`msdyn_activityid`|
|ReferencedEntityNavigationPropertyName|`msdyn_msdyn_salescopilotinsight_appointment_msdyn_activityid`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_msdyn_sciconversation_appointment_msdyn_RelatedActivity"></a> msdyn_msdyn_sciconversation_appointment_msdyn_RelatedActivity

Many-To-One Relationship: [msdyn_sciconversation msdyn_msdyn_sciconversation_appointment_msdyn_RelatedActivity](msdyn_sciconversation.md#BKMK_msdyn_msdyn_sciconversation_appointment_msdyn_RelatedActivity)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_sciconversation`|
|ReferencingAttribute|`msdyn_relatedactivity`|
|ReferencedEntityNavigationPropertyName|`msdyn_msdyn_sciconversation_appointment_msdyn_relatedactivity`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|



### See also

[Dataverse table/entity reference](/power-apps/developer/data-platform/reference/about-entity-reference)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   
<xref:Microsoft.Dynamics.CRM.appointment?displayProperty=fullName>
