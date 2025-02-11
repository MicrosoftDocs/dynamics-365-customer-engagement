---
title: "Activity (ActivityPointer) table/entity reference (Microsoft Dynamics 365)"
description: "Includes schema information and supported messages for the Activity (ActivityPointer) table/entity with Microsoft Dynamics 365."
ms.topic: generated-reference
author: JimDaly
ms.author: jdaly
search.audienceType: 
  - developer
---

# Activity (ActivityPointer) table/entity reference (Microsoft Dynamics 365)

Task performed, or to be performed, by a user. An activity is any action for which an entry can be made on a calendar.

> [!NOTE]
> The Microsoft Dynamics 365 Activity (ActivityPointer) table extends the [Microsoft Dataverse Activity (ActivityPointer) table](/power-apps/developer/data-platform/reference/entities/activitypointer).



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

- [allparties](#BKMK_allparties)
- [Community](#BKMK_Community)
- [RegardingObjectId](#BKMK_RegardingObjectId)

### <a name="BKMK_allparties"></a> allparties

Changes from [allparties (Microsoft Dataverse)](/power-apps/developer/data-platform/reference/entities/activitypointer#BKMK_allparties)

|Property|Value|
|---|---|
|Targets|equipment, lead|


### <a name="BKMK_Community"></a> Community

Changes from [Community (Microsoft Dataverse)](/power-apps/developer/data-platform/reference/entities/activitypointer#BKMK_Community)

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

### <a name="BKMK_RegardingObjectId"></a> RegardingObjectId

Changes from [RegardingObjectId (Microsoft Dataverse)](/power-apps/developer/data-platform/reference/entities/activitypointer#BKMK_RegardingObjectId)

|Property|Value|
|---|---|
|Targets|bookableresourcebooking, bookableresourcebookingheader, bulkoperation, campaign, campaignactivity, contract, entitlement, entitlementtemplate, incident, invoice, lead, msdyn_customerasset, msdyn_playbookinstance, msdyn_postalbum, msdyn_salessuggestion, msdyn_swarm, opportunity, quote, salesorder, site|


## Many-to-One relationships

These relationships are many-to-one. Listed by **SchemaName**.

- [bookableresourcebooking_ActivityPointers](#BKMK_bookableresourcebooking_ActivityPointers)
- [bookableresourcebookingheader_ActivityPointers](#BKMK_bookableresourcebookingheader_ActivityPointers)
- [BulkOperation_ActivityPointers](#BKMK_BulkOperation_ActivityPointers)
- [Campaign_ActivityPointers](#BKMK_Campaign_ActivityPointers)
- [CampaignActivity_ActivityPointers](#BKMK_CampaignActivity_ActivityPointers)
- [Contract_ActivityPointers](#BKMK_Contract_ActivityPointers)
- [entitlement_ActivityPointers](#BKMK_entitlement_ActivityPointers)
- [entitlementtemplate_ActivityPointers](#BKMK_entitlementtemplate_ActivityPointers)
- [Incident_ActivityPointers](#BKMK_Incident_ActivityPointers)
- [Invoice_ActivityPointers](#BKMK_Invoice_ActivityPointers)
- [Lead_ActivityPointers](#BKMK_Lead_ActivityPointers)
- [msdyn_customerasset_ActivityPointers](#BKMK_msdyn_customerasset_ActivityPointers)
- [msdyn_postalbum_ActivityPointers](#BKMK_msdyn_postalbum_ActivityPointers)
- [msdyn_salessuggestion_ActivityPointers](#BKMK_msdyn_salessuggestion_ActivityPointers)
- [msdyn_swarm_ActivityPointers](#BKMK_msdyn_swarm_ActivityPointers)
- [Opportunity_ActivityPointers](#BKMK_Opportunity_ActivityPointers)
- [Quote_ActivityPointers](#BKMK_Quote_ActivityPointers)
- [SalesOrder_ActivityPointers](#BKMK_SalesOrder_ActivityPointers)
- [service_activity_pointers](#BKMK_service_activity_pointers)
- [site_ActivityPointers](#BKMK_site_ActivityPointers)

### <a name="BKMK_bookableresourcebooking_ActivityPointers"></a> bookableresourcebooking_ActivityPointers

One-To-Many Relationship: [bookableresourcebooking bookableresourcebooking_ActivityPointers](bookableresourcebooking.md#BKMK_bookableresourcebooking_ActivityPointers)

|Property|Value|
|---|---|
|ReferencedEntity|`bookableresourcebooking`|
|ReferencedAttribute|`bookableresourcebookingid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_bookableresourcebooking`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_bookableresourcebookingheader_ActivityPointers"></a> bookableresourcebookingheader_ActivityPointers

One-To-Many Relationship: [bookableresourcebookingheader bookableresourcebookingheader_ActivityPointers](bookableresourcebookingheader.md#BKMK_bookableresourcebookingheader_ActivityPointers)

|Property|Value|
|---|---|
|ReferencedEntity|`bookableresourcebookingheader`|
|ReferencedAttribute|`bookableresourcebookingheaderid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_bookableresourcebookingheader`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_BulkOperation_ActivityPointers"></a> BulkOperation_ActivityPointers

One-To-Many Relationship: [bulkoperation BulkOperation_ActivityPointers](bulkoperation.md#BKMK_BulkOperation_ActivityPointers)

|Property|Value|
|---|---|
|ReferencedEntity|`bulkoperation`|
|ReferencedAttribute|`activityid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_bulkoperation`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_Campaign_ActivityPointers"></a> Campaign_ActivityPointers

One-To-Many Relationship: [campaign Campaign_ActivityPointers](campaign.md#BKMK_Campaign_ActivityPointers)

|Property|Value|
|---|---|
|ReferencedEntity|`campaign`|
|ReferencedAttribute|`campaignid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_campaign`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_CampaignActivity_ActivityPointers"></a> CampaignActivity_ActivityPointers

One-To-Many Relationship: [campaignactivity CampaignActivity_ActivityPointers](campaignactivity.md#BKMK_CampaignActivity_ActivityPointers)

|Property|Value|
|---|---|
|ReferencedEntity|`campaignactivity`|
|ReferencedAttribute|`activityid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_campaignactivity`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_Contract_ActivityPointers"></a> Contract_ActivityPointers

One-To-Many Relationship: [contract Contract_ActivityPointers](contract.md#BKMK_Contract_ActivityPointers)

|Property|Value|
|---|---|
|ReferencedEntity|`contract`|
|ReferencedAttribute|`contractid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_contract`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_entitlement_ActivityPointers"></a> entitlement_ActivityPointers

One-To-Many Relationship: [entitlement entitlement_ActivityPointers](entitlement.md#BKMK_entitlement_ActivityPointers)

|Property|Value|
|---|---|
|ReferencedEntity|`entitlement`|
|ReferencedAttribute|`entitlementid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_entitlement`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_entitlementtemplate_ActivityPointers"></a> entitlementtemplate_ActivityPointers

One-To-Many Relationship: [entitlementtemplate entitlementtemplate_ActivityPointers](entitlementtemplate.md#BKMK_entitlementtemplate_ActivityPointers)

|Property|Value|
|---|---|
|ReferencedEntity|`entitlementtemplate`|
|ReferencedAttribute|`entitlementtemplateid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_entitlementtemplate`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_Incident_ActivityPointers"></a> Incident_ActivityPointers

One-To-Many Relationship: [incident Incident_ActivityPointers](incident.md#BKMK_Incident_ActivityPointers)

|Property|Value|
|---|---|
|ReferencedEntity|`incident`|
|ReferencedAttribute|`incidentid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_incident`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_Invoice_ActivityPointers"></a> Invoice_ActivityPointers

One-To-Many Relationship: [invoice Invoice_ActivityPointers](invoice.md#BKMK_Invoice_ActivityPointers)

|Property|Value|
|---|---|
|ReferencedEntity|`invoice`|
|ReferencedAttribute|`invoiceid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_invoice`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_Lead_ActivityPointers"></a> Lead_ActivityPointers

One-To-Many Relationship: [lead Lead_ActivityPointers](lead.md#BKMK_Lead_ActivityPointers)

|Property|Value|
|---|---|
|ReferencedEntity|`lead`|
|ReferencedAttribute|`leadid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_lead`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_customerasset_ActivityPointers"></a> msdyn_customerasset_ActivityPointers

One-To-Many Relationship: [msdyn_customerasset msdyn_customerasset_ActivityPointers](msdyn_customerasset.md#BKMK_msdyn_customerasset_ActivityPointers)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_customerasset`|
|ReferencedAttribute|`msdyn_customerassetid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_customerasset`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_postalbum_ActivityPointers"></a> msdyn_postalbum_ActivityPointers

One-To-Many Relationship: [msdyn_postalbum msdyn_postalbum_ActivityPointers](msdyn_postalbum.md#BKMK_msdyn_postalbum_ActivityPointers)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_postalbum`|
|ReferencedAttribute|`msdyn_postalbumid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_postalbum`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_salessuggestion_ActivityPointers"></a> msdyn_salessuggestion_ActivityPointers

One-To-Many Relationship: [msdyn_salessuggestion msdyn_salessuggestion_ActivityPointers](msdyn_salessuggestion.md#BKMK_msdyn_salessuggestion_ActivityPointers)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_salessuggestion`|
|ReferencedAttribute|`msdyn_salessuggestionid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_salessuggestion`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_swarm_ActivityPointers"></a> msdyn_swarm_ActivityPointers

One-To-Many Relationship: [msdyn_swarm msdyn_swarm_ActivityPointers](msdyn_swarm.md#BKMK_msdyn_swarm_ActivityPointers)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_swarm`|
|ReferencedAttribute|`msdyn_swarmid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_swarm`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_Opportunity_ActivityPointers"></a> Opportunity_ActivityPointers

One-To-Many Relationship: [opportunity Opportunity_ActivityPointers](opportunity.md#BKMK_Opportunity_ActivityPointers)

|Property|Value|
|---|---|
|ReferencedEntity|`opportunity`|
|ReferencedAttribute|`opportunityid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_opportunity`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_Quote_ActivityPointers"></a> Quote_ActivityPointers

One-To-Many Relationship: [quote Quote_ActivityPointers](quote.md#BKMK_Quote_ActivityPointers)

|Property|Value|
|---|---|
|ReferencedEntity|`quote`|
|ReferencedAttribute|`quoteid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_quote`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_SalesOrder_ActivityPointers"></a> SalesOrder_ActivityPointers

One-To-Many Relationship: [salesorder SalesOrder_ActivityPointers](salesorder.md#BKMK_SalesOrder_ActivityPointers)

|Property|Value|
|---|---|
|ReferencedEntity|`salesorder`|
|ReferencedAttribute|`salesorderid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_salesorder`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_service_activity_pointers"></a> service_activity_pointers

One-To-Many Relationship: [service service_activity_pointers](service.md#BKMK_service_activity_pointers)

|Property|Value|
|---|---|
|ReferencedEntity|`service`|
|ReferencedAttribute|`serviceid`|
|ReferencingAttribute|`serviceid`|
|ReferencingEntityNavigationPropertyName|`serviceid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_site_ActivityPointers"></a> site_ActivityPointers

One-To-Many Relationship: [site site_ActivityPointers](site.md#BKMK_site_ActivityPointers)

|Property|Value|
|---|---|
|ReferencedEntity|`site`|
|ReferencedAttribute|`siteid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_site`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|


## One-to-Many relationships

These relationships are one-to-many. Listed by **SchemaName**.

- [activity_campaignresponse](#BKMK_activity_campaignresponse)
- [activity_pointer_BulkOperation](#BKMK_activity_pointer_BulkOperation)
- [activity_pointer_BulkOperation_logs](#BKMK_activity_pointer_BulkOperation_logs)
- [activity_pointer_campaignactivity](#BKMK_activity_pointer_campaignactivity)
- [activity_pointer_campaignresponse](#BKMK_activity_pointer_campaignresponse)
- [activity_pointer_incident_resolution](#BKMK_activity_pointer_incident_resolution)
- [activity_pointer_msdyn_copilottranscript](#BKMK_activity_pointer_msdyn_copilottranscript)
- [activity_pointer_msdyn_ocliveworkitem](#BKMK_activity_pointer_msdyn_ocliveworkitem)
- [activity_pointer_msdyn_ocsession](#BKMK_activity_pointer_msdyn_ocsession)
- [activity_pointer_msfp_alert](#BKMK_activity_pointer_msfp_alert)
- [activity_pointer_msfp_surveyinvite](#BKMK_activity_pointer_msfp_surveyinvite)
- [activity_pointer_msfp_surveyresponse](#BKMK_activity_pointer_msfp_surveyresponse)
- [activity_pointer_opportunity_close](#BKMK_activity_pointer_opportunity_close)
- [activity_pointer_order_close](#BKMK_activity_pointer_order_close)
- [activity_pointer_quote_close](#BKMK_activity_pointer_quote_close)
- [activity_pointer_service_appointment](#BKMK_activity_pointer_service_appointment)
- [ActivityPointer_CampaignActivityItems](#BKMK_ActivityPointer_CampaignActivityItems)
- [CreatedActivity_BulkOperationLogs](#BKMK_CreatedActivity_BulkOperationLogs)
- [msdyn_readtracker_poly_activitypointer](#BKMK_msdyn_readtracker_poly_activitypointer)

### <a name="BKMK_activity_campaignresponse"></a> activity_campaignresponse

Many-To-One Relationship: [campaignresponse activity_campaignresponse](campaignresponse.md#BKMK_activity_campaignresponse)

|Property|Value|
|---|---|
|ReferencingEntity|`campaignresponse`|
|ReferencingAttribute|`originatingactivityid`|
|ReferencedEntityNavigationPropertyName|`activity_campaignresponse`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_activity_pointer_BulkOperation"></a> activity_pointer_BulkOperation

Many-To-One Relationship: [bulkoperation activity_pointer_BulkOperation](bulkoperation.md#BKMK_activity_pointer_BulkOperation)

|Property|Value|
|---|---|
|ReferencingEntity|`bulkoperation`|
|ReferencingAttribute|`activityid`|
|ReferencedEntityNavigationPropertyName|`activity_pointer_BulkOperation`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_activity_pointer_BulkOperation_logs"></a> activity_pointer_BulkOperation_logs

Many-To-One Relationship: [bulkoperationlog activity_pointer_BulkOperation_logs](bulkoperationlog.md#BKMK_activity_pointer_BulkOperation_logs)

|Property|Value|
|---|---|
|ReferencingEntity|`bulkoperationlog`|
|ReferencingAttribute|`bulkoperationid`|
|ReferencedEntityNavigationPropertyName|`activity_pointer_BulkOperation_logs`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_activity_pointer_campaignactivity"></a> activity_pointer_campaignactivity

Many-To-One Relationship: [campaignactivity activity_pointer_campaignactivity](campaignactivity.md#BKMK_activity_pointer_campaignactivity)

|Property|Value|
|---|---|
|ReferencingEntity|`campaignactivity`|
|ReferencingAttribute|`activityid`|
|ReferencedEntityNavigationPropertyName|`activity_pointer_campaignactivity`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_activity_pointer_campaignresponse"></a> activity_pointer_campaignresponse

Many-To-One Relationship: [campaignresponse activity_pointer_campaignresponse](campaignresponse.md#BKMK_activity_pointer_campaignresponse)

|Property|Value|
|---|---|
|ReferencingEntity|`campaignresponse`|
|ReferencingAttribute|`activityid`|
|ReferencedEntityNavigationPropertyName|`activity_pointer_campaignresponse`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_activity_pointer_incident_resolution"></a> activity_pointer_incident_resolution

Many-To-One Relationship: [incidentresolution activity_pointer_incident_resolution](incidentresolution.md#BKMK_activity_pointer_incident_resolution)

|Property|Value|
|---|---|
|ReferencingEntity|`incidentresolution`|
|ReferencingAttribute|`activityid`|
|ReferencedEntityNavigationPropertyName|`activity_pointer_incident_resolution`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_activity_pointer_msdyn_copilottranscript"></a> activity_pointer_msdyn_copilottranscript

Many-To-One Relationship: [msdyn_copilottranscript activity_pointer_msdyn_copilottranscript](msdyn_copilottranscript.md#BKMK_activity_pointer_msdyn_copilottranscript)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_copilottranscript`|
|ReferencingAttribute|`activityid`|
|ReferencedEntityNavigationPropertyName|`activity_pointer_msdyn_copilottranscript`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_activity_pointer_msdyn_ocliveworkitem"></a> activity_pointer_msdyn_ocliveworkitem

Many-To-One Relationship: [msdyn_ocliveworkitem activity_pointer_msdyn_ocliveworkitem](msdyn_ocliveworkitem.md#BKMK_activity_pointer_msdyn_ocliveworkitem)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocliveworkitem`|
|ReferencingAttribute|`activityid`|
|ReferencedEntityNavigationPropertyName|`activity_pointer_msdyn_ocliveworkitem`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_activity_pointer_msdyn_ocsession"></a> activity_pointer_msdyn_ocsession

Many-To-One Relationship: [msdyn_ocsession activity_pointer_msdyn_ocsession](msdyn_ocsession.md#BKMK_activity_pointer_msdyn_ocsession)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocsession`|
|ReferencingAttribute|`activityid`|
|ReferencedEntityNavigationPropertyName|`activity_pointer_msdyn_ocsession`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_activity_pointer_msfp_alert"></a> activity_pointer_msfp_alert

Many-To-One Relationship: [msfp_alert activity_pointer_msfp_alert](msfp_alert.md#BKMK_activity_pointer_msfp_alert)

|Property|Value|
|---|---|
|ReferencingEntity|`msfp_alert`|
|ReferencingAttribute|`activityid`|
|ReferencedEntityNavigationPropertyName|`activity_pointer_msfp_alert`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_activity_pointer_msfp_surveyinvite"></a> activity_pointer_msfp_surveyinvite

Many-To-One Relationship: [msfp_surveyinvite activity_pointer_msfp_surveyinvite](msfp_surveyinvite.md#BKMK_activity_pointer_msfp_surveyinvite)

|Property|Value|
|---|---|
|ReferencingEntity|`msfp_surveyinvite`|
|ReferencingAttribute|`activityid`|
|ReferencedEntityNavigationPropertyName|`activity_pointer_msfp_surveyinvite`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_activity_pointer_msfp_surveyresponse"></a> activity_pointer_msfp_surveyresponse

Many-To-One Relationship: [msfp_surveyresponse activity_pointer_msfp_surveyresponse](msfp_surveyresponse.md#BKMK_activity_pointer_msfp_surveyresponse)

|Property|Value|
|---|---|
|ReferencingEntity|`msfp_surveyresponse`|
|ReferencingAttribute|`activityid`|
|ReferencedEntityNavigationPropertyName|`activity_pointer_msfp_surveyresponse`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_activity_pointer_opportunity_close"></a> activity_pointer_opportunity_close

Many-To-One Relationship: [opportunityclose activity_pointer_opportunity_close](opportunityclose.md#BKMK_activity_pointer_opportunity_close)

|Property|Value|
|---|---|
|ReferencingEntity|`opportunityclose`|
|ReferencingAttribute|`activityid`|
|ReferencedEntityNavigationPropertyName|`activity_pointer_opportunity_close`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_activity_pointer_order_close"></a> activity_pointer_order_close

Many-To-One Relationship: [orderclose activity_pointer_order_close](orderclose.md#BKMK_activity_pointer_order_close)

|Property|Value|
|---|---|
|ReferencingEntity|`orderclose`|
|ReferencingAttribute|`activityid`|
|ReferencedEntityNavigationPropertyName|`activity_pointer_order_close`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_activity_pointer_quote_close"></a> activity_pointer_quote_close

Many-To-One Relationship: [quoteclose activity_pointer_quote_close](quoteclose.md#BKMK_activity_pointer_quote_close)

|Property|Value|
|---|---|
|ReferencingEntity|`quoteclose`|
|ReferencingAttribute|`activityid`|
|ReferencedEntityNavigationPropertyName|`activity_pointer_quote_close`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_activity_pointer_service_appointment"></a> activity_pointer_service_appointment

Many-To-One Relationship: [serviceappointment activity_pointer_service_appointment](serviceappointment.md#BKMK_activity_pointer_service_appointment)

|Property|Value|
|---|---|
|ReferencingEntity|`serviceappointment`|
|ReferencingAttribute|`activityid`|
|ReferencedEntityNavigationPropertyName|`activity_pointer_service_appointment`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_ActivityPointer_CampaignActivityItems"></a> ActivityPointer_CampaignActivityItems

Many-To-One Relationship: [campaignactivityitem ActivityPointer_CampaignActivityItems](campaignactivityitem.md#BKMK_ActivityPointer_CampaignActivityItems)

|Property|Value|
|---|---|
|ReferencingEntity|`campaignactivityitem`|
|ReferencingAttribute|`campaignactivityid`|
|ReferencedEntityNavigationPropertyName|`ActivityPointer_CampaignActivityItems`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_CreatedActivity_BulkOperationLogs"></a> CreatedActivity_BulkOperationLogs

Many-To-One Relationship: [bulkoperationlog CreatedActivity_BulkOperationLogs](bulkoperationlog.md#BKMK_CreatedActivity_BulkOperationLogs)

|Property|Value|
|---|---|
|ReferencingEntity|`bulkoperationlog`|
|ReferencingAttribute|`createdobjectid`|
|ReferencedEntityNavigationPropertyName|`CreatedActivity_BulkOperationLogs`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_readtracker_poly_activitypointer"></a> msdyn_readtracker_poly_activitypointer

Many-To-One Relationship: [msdyn_readtracker msdyn_readtracker_poly_activitypointer](msdyn_readtracker.md#BKMK_msdyn_readtracker_poly_activitypointer)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_readtracker`|
|ReferencingAttribute|`msdyn_regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_readtracker_poly_activitypointer`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|



### See also

[Dataverse table/entity reference](/power-apps/developer/data-platform/reference/about-entity-reference)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   
<xref:Microsoft.Dynamics.CRM.activitypointer?displayProperty=fullName>
