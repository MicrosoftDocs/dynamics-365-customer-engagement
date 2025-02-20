---
title: "Phone Call (PhoneCall) table/entity reference (Microsoft Dynamics 365)"
description: "Includes schema information and supported messages for the Phone Call (PhoneCall) table/entity with Microsoft Dynamics 365."
ms.topic: generated-reference
author: JimDaly
ms.author: jdaly
search.audienceType: 
  - developer
---

# Phone Call (PhoneCall) table/entity reference (Microsoft Dynamics 365)

Activity to track a telephone call.

> [!NOTE]
> The Microsoft Dynamics 365 Phone Call (PhoneCall) table extends the [Microsoft Dataverse Phone Call (PhoneCall) table](/power-apps/developer/data-platform/reference/entities/phonecall).



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

Changes from [from (Microsoft Dataverse)](/power-apps/developer/data-platform/reference/entities/phonecall#BKMK_from)

|Property|Value|
|---|---|
|Targets|lead|


### <a name="BKMK_RegardingObjectId"></a> RegardingObjectId

Changes from [RegardingObjectId (Microsoft Dataverse)](/power-apps/developer/data-platform/reference/entities/phonecall#BKMK_RegardingObjectId)

|Property|Value|
|---|---|
|Targets|bookableresourcebooking, bookableresourcebookingheader, bulkoperation, campaign, campaignactivity, contract, entitlement, entitlementtemplate, incident, invoice, lead, msdyn_customerasset, msdyn_playbookinstance, msdyn_postalbum, msdyn_salessuggestion, msdyn_swarm, opportunity, quote, salesorder, site|


### <a name="BKMK_to"></a> to

Changes from [to (Microsoft Dataverse)](/power-apps/developer/data-platform/reference/entities/phonecall#BKMK_to)

|Property|Value|
|---|---|
|Targets|lead|


## Many-to-One relationships

These relationships are many-to-one. Listed by **SchemaName**.

- [bookableresourcebooking_PhoneCalls](#BKMK_bookableresourcebooking_PhoneCalls)
- [bookableresourcebookingheader_PhoneCalls](#BKMK_bookableresourcebookingheader_PhoneCalls)
- [BulkOperation_Phonecall](#BKMK_BulkOperation_Phonecall)
- [Campaign_Phonecalls](#BKMK_Campaign_Phonecalls)
- [CampaignActivity_Phonecalls](#BKMK_CampaignActivity_Phonecalls)
- [Contract_Phonecalls](#BKMK_Contract_Phonecalls)
- [entitlement_PhoneCalls](#BKMK_entitlement_PhoneCalls)
- [entitlementtemplate_PhoneCalls](#BKMK_entitlementtemplate_PhoneCalls)
- [Incident_Phonecalls](#BKMK_Incident_Phonecalls)
- [Invoice_Phonecalls](#BKMK_Invoice_Phonecalls)
- [Lead_Phonecalls](#BKMK_Lead_Phonecalls)
- [msdyn_customerasset_PhoneCalls](#BKMK_msdyn_customerasset_PhoneCalls)
- [msdyn_postalbum_PhoneCalls](#BKMK_msdyn_postalbum_PhoneCalls)
- [msdyn_salessuggestion_PhoneCalls](#BKMK_msdyn_salessuggestion_PhoneCalls)
- [msdyn_swarm_PhoneCalls](#BKMK_msdyn_swarm_PhoneCalls)
- [Opportunity_Phonecalls](#BKMK_Opportunity_Phonecalls)
- [Quote_Phonecalls](#BKMK_Quote_Phonecalls)
- [SalesOrder_Phonecalls](#BKMK_SalesOrder_Phonecalls)
- [service_phonecalls](#BKMK_service_phonecalls)
- [site_PhoneCalls](#BKMK_site_PhoneCalls)

### <a name="BKMK_bookableresourcebooking_PhoneCalls"></a> bookableresourcebooking_PhoneCalls

One-To-Many Relationship: [bookableresourcebooking bookableresourcebooking_PhoneCalls](bookableresourcebooking.md#BKMK_bookableresourcebooking_PhoneCalls)

|Property|Value|
|---|---|
|ReferencedEntity|`bookableresourcebooking`|
|ReferencedAttribute|`bookableresourcebookingid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_bookableresourcebooking_phonecall`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_bookableresourcebookingheader_PhoneCalls"></a> bookableresourcebookingheader_PhoneCalls

One-To-Many Relationship: [bookableresourcebookingheader bookableresourcebookingheader_PhoneCalls](bookableresourcebookingheader.md#BKMK_bookableresourcebookingheader_PhoneCalls)

|Property|Value|
|---|---|
|ReferencedEntity|`bookableresourcebookingheader`|
|ReferencedAttribute|`bookableresourcebookingheaderid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_bookableresourcebookingheader_phonecall`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_BulkOperation_Phonecall"></a> BulkOperation_Phonecall

One-To-Many Relationship: [bulkoperation BulkOperation_Phonecall](bulkoperation.md#BKMK_BulkOperation_Phonecall)

|Property|Value|
|---|---|
|ReferencedEntity|`bulkoperation`|
|ReferencedAttribute|`activityid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_bulkoperation_phonecall`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_Campaign_Phonecalls"></a> Campaign_Phonecalls

One-To-Many Relationship: [campaign Campaign_Phonecalls](campaign.md#BKMK_Campaign_Phonecalls)

|Property|Value|
|---|---|
|ReferencedEntity|`campaign`|
|ReferencedAttribute|`campaignid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_campaign_phonecall`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `Cascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_CampaignActivity_Phonecalls"></a> CampaignActivity_Phonecalls

One-To-Many Relationship: [campaignactivity CampaignActivity_Phonecalls](campaignactivity.md#BKMK_CampaignActivity_Phonecalls)

|Property|Value|
|---|---|
|ReferencedEntity|`campaignactivity`|
|ReferencedAttribute|`activityid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_campaignactivity_phonecall`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_Contract_Phonecalls"></a> Contract_Phonecalls

One-To-Many Relationship: [contract Contract_Phonecalls](contract.md#BKMK_Contract_Phonecalls)

|Property|Value|
|---|---|
|ReferencedEntity|`contract`|
|ReferencedAttribute|`contractid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_contract_phonecall`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_entitlement_PhoneCalls"></a> entitlement_PhoneCalls

One-To-Many Relationship: [entitlement entitlement_PhoneCalls](entitlement.md#BKMK_entitlement_PhoneCalls)

|Property|Value|
|---|---|
|ReferencedEntity|`entitlement`|
|ReferencedAttribute|`entitlementid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_entitlement_phonecall`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_entitlementtemplate_PhoneCalls"></a> entitlementtemplate_PhoneCalls

One-To-Many Relationship: [entitlementtemplate entitlementtemplate_PhoneCalls](entitlementtemplate.md#BKMK_entitlementtemplate_PhoneCalls)

|Property|Value|
|---|---|
|ReferencedEntity|`entitlementtemplate`|
|ReferencedAttribute|`entitlementtemplateid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_entitlementtemplate_phonecall`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_Incident_Phonecalls"></a> Incident_Phonecalls

One-To-Many Relationship: [incident Incident_Phonecalls](incident.md#BKMK_Incident_Phonecalls)

|Property|Value|
|---|---|
|ReferencedEntity|`incident`|
|ReferencedAttribute|`incidentid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_incident_phonecall`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `Cascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_Invoice_Phonecalls"></a> Invoice_Phonecalls

One-To-Many Relationship: [invoice Invoice_Phonecalls](invoice.md#BKMK_Invoice_Phonecalls)

|Property|Value|
|---|---|
|ReferencedEntity|`invoice`|
|ReferencedAttribute|`invoiceid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_invoice_phonecall`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_Lead_Phonecalls"></a> Lead_Phonecalls

One-To-Many Relationship: [lead Lead_Phonecalls](lead.md#BKMK_Lead_Phonecalls)

|Property|Value|
|---|---|
|ReferencedEntity|`lead`|
|ReferencedAttribute|`leadid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_lead_phonecall`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `Cascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_customerasset_PhoneCalls"></a> msdyn_customerasset_PhoneCalls

One-To-Many Relationship: [msdyn_customerasset msdyn_customerasset_PhoneCalls](msdyn_customerasset.md#BKMK_msdyn_customerasset_PhoneCalls)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_customerasset`|
|ReferencedAttribute|`msdyn_customerassetid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_customerasset_phonecall`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_postalbum_PhoneCalls"></a> msdyn_postalbum_PhoneCalls

One-To-Many Relationship: [msdyn_postalbum msdyn_postalbum_PhoneCalls](msdyn_postalbum.md#BKMK_msdyn_postalbum_PhoneCalls)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_postalbum`|
|ReferencedAttribute|`msdyn_postalbumid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_postalbum_phonecall`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_salessuggestion_PhoneCalls"></a> msdyn_salessuggestion_PhoneCalls

One-To-Many Relationship: [msdyn_salessuggestion msdyn_salessuggestion_PhoneCalls](msdyn_salessuggestion.md#BKMK_msdyn_salessuggestion_PhoneCalls)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_salessuggestion`|
|ReferencedAttribute|`msdyn_salessuggestionid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_salessuggestion_phonecall`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_swarm_PhoneCalls"></a> msdyn_swarm_PhoneCalls

One-To-Many Relationship: [msdyn_swarm msdyn_swarm_PhoneCalls](msdyn_swarm.md#BKMK_msdyn_swarm_PhoneCalls)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_swarm`|
|ReferencedAttribute|`msdyn_swarmid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_swarm_phonecall`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_Opportunity_Phonecalls"></a> Opportunity_Phonecalls

One-To-Many Relationship: [opportunity Opportunity_Phonecalls](opportunity.md#BKMK_Opportunity_Phonecalls)

|Property|Value|
|---|---|
|ReferencedEntity|`opportunity`|
|ReferencedAttribute|`opportunityid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_opportunity_phonecall`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_Quote_Phonecalls"></a> Quote_Phonecalls

One-To-Many Relationship: [quote Quote_Phonecalls](quote.md#BKMK_Quote_Phonecalls)

|Property|Value|
|---|---|
|ReferencedEntity|`quote`|
|ReferencedAttribute|`quoteid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_quote_phonecall`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_SalesOrder_Phonecalls"></a> SalesOrder_Phonecalls

One-To-Many Relationship: [salesorder SalesOrder_Phonecalls](salesorder.md#BKMK_SalesOrder_Phonecalls)

|Property|Value|
|---|---|
|ReferencedEntity|`salesorder`|
|ReferencedAttribute|`salesorderid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_salesorder_phonecall`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_service_phonecalls"></a> service_phonecalls

One-To-Many Relationship: [service service_phonecalls](service.md#BKMK_service_phonecalls)

|Property|Value|
|---|---|
|ReferencedEntity|`service`|
|ReferencedAttribute|`serviceid`|
|ReferencingAttribute|`serviceid`|
|ReferencingEntityNavigationPropertyName|`serviceid_phonecall`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Restrict`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_site_PhoneCalls"></a> site_PhoneCalls

One-To-Many Relationship: [site site_PhoneCalls](site.md#BKMK_site_PhoneCalls)

|Property|Value|
|---|---|
|ReferencedEntity|`site`|
|ReferencedAttribute|`siteid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_site_phonecall`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|


## One-to-Many relationships

These relationships are one-to-many. Listed by **SchemaName**.

- [msdyn_msdyn_conversationactionitem_phonecall_msdyn_CreatedActivity](#BKMK_msdyn_msdyn_conversationactionitem_phonecall_msdyn_CreatedActivity)
- [msdyn_msdyn_salescopilotinsight_phonecall_msdyn_activityid](#BKMK_msdyn_msdyn_salescopilotinsight_phonecall_msdyn_activityid)
- [msdyn_msdyn_sciconversation_phonecall_msdyn_RelatedActivity](#BKMK_msdyn_msdyn_sciconversation_phonecall_msdyn_RelatedActivity)
- [msdyn_phonecall_msdyn_conversationinsight_conversationinsighttarget](#BKMK_msdyn_phonecall_msdyn_conversationinsight_conversationinsighttarget)
- [msdyn_phonecall_msdyn_ocrecording_recordingtarget](#BKMK_msdyn_phonecall_msdyn_ocrecording_recordingtarget)
- [msdyn_phonecall_msdyn_transcript_transcripttarget](#BKMK_msdyn_phonecall_msdyn_transcript_transcripttarget)
- [phonecall_campaignresponse](#BKMK_phonecall_campaignresponse)

### <a name="BKMK_msdyn_msdyn_conversationactionitem_phonecall_msdyn_CreatedActivity"></a> msdyn_msdyn_conversationactionitem_phonecall_msdyn_CreatedActivity

Many-To-One Relationship: [msdyn_conversationactionitem msdyn_msdyn_conversationactionitem_phonecall_msdyn_CreatedActivity](msdyn_conversationactionitem.md#BKMK_msdyn_msdyn_conversationactionitem_phonecall_msdyn_CreatedActivity)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_conversationactionitem`|
|ReferencingAttribute|`msdyn_createdactivity`|
|ReferencedEntityNavigationPropertyName|`msdyn_msdyn_conversationactionitem_phonecall_msdyn_createdactivity`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_msdyn_salescopilotinsight_phonecall_msdyn_activityid"></a> msdyn_msdyn_salescopilotinsight_phonecall_msdyn_activityid

Many-To-One Relationship: [msdyn_salescopilotinsight msdyn_msdyn_salescopilotinsight_phonecall_msdyn_activityid](msdyn_salescopilotinsight.md#BKMK_msdyn_msdyn_salescopilotinsight_phonecall_msdyn_activityid)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_salescopilotinsight`|
|ReferencingAttribute|`msdyn_activityid`|
|ReferencedEntityNavigationPropertyName|`msdyn_msdyn_salescopilotinsight_phonecall_msdyn_activityid`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_msdyn_sciconversation_phonecall_msdyn_RelatedActivity"></a> msdyn_msdyn_sciconversation_phonecall_msdyn_RelatedActivity

Many-To-One Relationship: [msdyn_sciconversation msdyn_msdyn_sciconversation_phonecall_msdyn_RelatedActivity](msdyn_sciconversation.md#BKMK_msdyn_msdyn_sciconversation_phonecall_msdyn_RelatedActivity)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_sciconversation`|
|ReferencingAttribute|`msdyn_relatedactivity`|
|ReferencedEntityNavigationPropertyName|`msdyn_msdyn_sciconversation_phonecall_msdyn_relatedactivity`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_phonecall_msdyn_conversationinsight_conversationinsighttarget"></a> msdyn_phonecall_msdyn_conversationinsight_conversationinsighttarget

Many-To-One Relationship: [msdyn_conversationinsight msdyn_phonecall_msdyn_conversationinsight_conversationinsighttarget](msdyn_conversationinsight.md#BKMK_msdyn_phonecall_msdyn_conversationinsight_conversationinsighttarget)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_conversationinsight`|
|ReferencingAttribute|`msdyn_conversationinsighttarget`|
|ReferencedEntityNavigationPropertyName|`msdyn_phonecall_msdyn_conversationinsight_conversationinsighttarget`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_phonecall_msdyn_ocrecording_recordingtarget"></a> msdyn_phonecall_msdyn_ocrecording_recordingtarget

Many-To-One Relationship: [msdyn_ocrecording msdyn_phonecall_msdyn_ocrecording_recordingtarget](msdyn_ocrecording.md#BKMK_msdyn_phonecall_msdyn_ocrecording_recordingtarget)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocrecording`|
|ReferencingAttribute|`msdyn_recordingtarget`|
|ReferencedEntityNavigationPropertyName|`msdyn_phonecall_msdyn_ocrecording_recordingtarget`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_phonecall_msdyn_transcript_transcripttarget"></a> msdyn_phonecall_msdyn_transcript_transcripttarget

Many-To-One Relationship: [msdyn_transcript msdyn_phonecall_msdyn_transcript_transcripttarget](msdyn_transcript.md#BKMK_msdyn_phonecall_msdyn_transcript_transcripttarget)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_transcript`|
|ReferencingAttribute|`msdyn_transcripttarget`|
|ReferencedEntityNavigationPropertyName|`msdyn_phonecall_msdyn_transcript_transcripttarget`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_phonecall_campaignresponse"></a> phonecall_campaignresponse

Many-To-One Relationship: [campaignresponse phonecall_campaignresponse](campaignresponse.md#BKMK_phonecall_campaignresponse)

|Property|Value|
|---|---|
|ReferencingEntity|`campaignresponse`|
|ReferencingAttribute|`originatingactivityid`|
|ReferencedEntityNavigationPropertyName|`phonecall_campaignresponse`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|



### See also

[Dataverse table/entity reference](/power-apps/developer/data-platform/reference/about-entity-reference)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   
<xref:Microsoft.Dynamics.CRM.phonecall?displayProperty=fullName>
