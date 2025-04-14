---
title: "Task table/entity reference (Microsoft Dynamics 365)"
description: "Includes schema information and supported messages for the Task table/entity with Microsoft Dynamics 365."
ms.topic: generated-reference
author: JimDaly
ms.author: jdaly
search.audienceType: 
  - developer
---

# Task table/entity reference (Microsoft Dynamics 365)

Generic activity representing work needed to be done.

> [!NOTE]
> The Microsoft Dynamics 365 Task table extends the [Microsoft Dataverse Task table](/power-apps/developer/data-platform/reference/entities/task).



## Writable columns/attributes

These columns/attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

### <a name="BKMK_ServiceId"></a> ServiceId

|Property|Value|
|---|---|
|Description|**Choose the service that is associated with this activity.**|
|DisplayName|**Service**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`serviceid`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|service|


## Customized columns/attributes

Microsoft Dynamics 365 modifies the definition of columns/attributes defined in other solutions. Listed by **SchemaName**.

### <a name="BKMK_RegardingObjectId"></a> RegardingObjectId

Changes from [RegardingObjectId (Microsoft Dataverse)](/power-apps/developer/data-platform/reference/entities/task#BKMK_RegardingObjectId)

|Property|Value|
|---|---|
|Targets|bookableresourcebooking, bookableresourcebookingheader, bulkoperation, campaign, campaignactivity, contract, entitlement, entitlementtemplate, incident, invoice, lead, msdyn_customerasset, msdyn_playbookinstance, msdyn_postalbum, msdyn_salessuggestion, msdyn_swarm, opportunity, quote, salesorder, site|


## Many-to-One relationships

These relationships are many-to-one. Listed by **SchemaName**.

- [bookableresourcebooking_Tasks](#BKMK_bookableresourcebooking_Tasks)
- [bookableresourcebookingheader_Tasks](#BKMK_bookableresourcebookingheader_Tasks)
- [bulkoperation_Tasks](#BKMK_bulkoperation_Tasks)
- [Campaign_Tasks](#BKMK_Campaign_Tasks)
- [CampaignActivity_Tasks](#BKMK_CampaignActivity_Tasks)
- [Contract_Tasks](#BKMK_Contract_Tasks)
- [entitlement_Tasks](#BKMK_entitlement_Tasks)
- [entitlementtemplate_Tasks](#BKMK_entitlementtemplate_Tasks)
- [Incident_Tasks](#BKMK_Incident_Tasks)
- [Invoice_Tasks](#BKMK_Invoice_Tasks)
- [Lead_Tasks](#BKMK_Lead_Tasks)
- [msdyn_customerasset_Tasks](#BKMK_msdyn_customerasset_Tasks)
- [msdyn_postalbum_Tasks](#BKMK_msdyn_postalbum_Tasks)
- [msdyn_salessuggestion_Tasks](#BKMK_msdyn_salessuggestion_Tasks)
- [msdyn_swarm_Tasks](#BKMK_msdyn_swarm_Tasks)
- [Opportunity_Tasks](#BKMK_Opportunity_Tasks)
- [Quote_Tasks](#BKMK_Quote_Tasks)
- [SalesOrder_Tasks](#BKMK_SalesOrder_Tasks)
- [service_tasks](#BKMK_service_tasks)
- [site_Tasks](#BKMK_site_Tasks)

### <a name="BKMK_bookableresourcebooking_Tasks"></a> bookableresourcebooking_Tasks

One-To-Many Relationship: [bookableresourcebooking bookableresourcebooking_Tasks](bookableresourcebooking.md#BKMK_bookableresourcebooking_Tasks)

|Property|Value|
|---|---|
|ReferencedEntity|`bookableresourcebooking`|
|ReferencedAttribute|`bookableresourcebookingid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_bookableresourcebooking_task`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_bookableresourcebookingheader_Tasks"></a> bookableresourcebookingheader_Tasks

One-To-Many Relationship: [bookableresourcebookingheader bookableresourcebookingheader_Tasks](bookableresourcebookingheader.md#BKMK_bookableresourcebookingheader_Tasks)

|Property|Value|
|---|---|
|ReferencedEntity|`bookableresourcebookingheader`|
|ReferencedAttribute|`bookableresourcebookingheaderid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_bookableresourcebookingheader_task`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_bulkoperation_Tasks"></a> bulkoperation_Tasks

One-To-Many Relationship: [bulkoperation bulkoperation_Tasks](bulkoperation.md#BKMK_bulkoperation_Tasks)

|Property|Value|
|---|---|
|ReferencedEntity|`bulkoperation`|
|ReferencedAttribute|`activityid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_bulkoperation_task`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_Campaign_Tasks"></a> Campaign_Tasks

One-To-Many Relationship: [campaign Campaign_Tasks](campaign.md#BKMK_Campaign_Tasks)

|Property|Value|
|---|---|
|ReferencedEntity|`campaign`|
|ReferencedAttribute|`campaignid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_campaign_task`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_CampaignActivity_Tasks"></a> CampaignActivity_Tasks

One-To-Many Relationship: [campaignactivity CampaignActivity_Tasks](campaignactivity.md#BKMK_CampaignActivity_Tasks)

|Property|Value|
|---|---|
|ReferencedEntity|`campaignactivity`|
|ReferencedAttribute|`activityid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_campaignactivity_task`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_Contract_Tasks"></a> Contract_Tasks

One-To-Many Relationship: [contract Contract_Tasks](contract.md#BKMK_Contract_Tasks)

|Property|Value|
|---|---|
|ReferencedEntity|`contract`|
|ReferencedAttribute|`contractid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_contract_task`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_entitlement_Tasks"></a> entitlement_Tasks

One-To-Many Relationship: [entitlement entitlement_Tasks](entitlement.md#BKMK_entitlement_Tasks)

|Property|Value|
|---|---|
|ReferencedEntity|`entitlement`|
|ReferencedAttribute|`entitlementid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_entitlement_task`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_entitlementtemplate_Tasks"></a> entitlementtemplate_Tasks

One-To-Many Relationship: [entitlementtemplate entitlementtemplate_Tasks](entitlementtemplate.md#BKMK_entitlementtemplate_Tasks)

|Property|Value|
|---|---|
|ReferencedEntity|`entitlementtemplate`|
|ReferencedAttribute|`entitlementtemplateid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_entitlementtemplate_task`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_Incident_Tasks"></a> Incident_Tasks

One-To-Many Relationship: [incident Incident_Tasks](incident.md#BKMK_Incident_Tasks)

|Property|Value|
|---|---|
|ReferencedEntity|`incident`|
|ReferencedAttribute|`incidentid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_incident_task`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `Cascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_Invoice_Tasks"></a> Invoice_Tasks

One-To-Many Relationship: [invoice Invoice_Tasks](invoice.md#BKMK_Invoice_Tasks)

|Property|Value|
|---|---|
|ReferencedEntity|`invoice`|
|ReferencedAttribute|`invoiceid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_invoice_task`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_Lead_Tasks"></a> Lead_Tasks

One-To-Many Relationship: [lead Lead_Tasks](lead.md#BKMK_Lead_Tasks)

|Property|Value|
|---|---|
|ReferencedEntity|`lead`|
|ReferencedAttribute|`leadid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_lead_task`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `Cascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_customerasset_Tasks"></a> msdyn_customerasset_Tasks

One-To-Many Relationship: [msdyn_customerasset msdyn_customerasset_Tasks](msdyn_customerasset.md#BKMK_msdyn_customerasset_Tasks)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_customerasset`|
|ReferencedAttribute|`msdyn_customerassetid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_customerasset_task`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_postalbum_Tasks"></a> msdyn_postalbum_Tasks

One-To-Many Relationship: [msdyn_postalbum msdyn_postalbum_Tasks](msdyn_postalbum.md#BKMK_msdyn_postalbum_Tasks)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_postalbum`|
|ReferencedAttribute|`msdyn_postalbumid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_postalbum_task`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_salessuggestion_Tasks"></a> msdyn_salessuggestion_Tasks

One-To-Many Relationship: [msdyn_salessuggestion msdyn_salessuggestion_Tasks](msdyn_salessuggestion.md#BKMK_msdyn_salessuggestion_Tasks)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_salessuggestion`|
|ReferencedAttribute|`msdyn_salessuggestionid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_salessuggestion_task`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_swarm_Tasks"></a> msdyn_swarm_Tasks

One-To-Many Relationship: [msdyn_swarm msdyn_swarm_Tasks](msdyn_swarm.md#BKMK_msdyn_swarm_Tasks)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_swarm`|
|ReferencedAttribute|`msdyn_swarmid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_swarm_task`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_Opportunity_Tasks"></a> Opportunity_Tasks

One-To-Many Relationship: [opportunity Opportunity_Tasks](opportunity.md#BKMK_Opportunity_Tasks)

|Property|Value|
|---|---|
|ReferencedEntity|`opportunity`|
|ReferencedAttribute|`opportunityid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_opportunity_task`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_Quote_Tasks"></a> Quote_Tasks

One-To-Many Relationship: [quote Quote_Tasks](quote.md#BKMK_Quote_Tasks)

|Property|Value|
|---|---|
|ReferencedEntity|`quote`|
|ReferencedAttribute|`quoteid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_quote_task`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_SalesOrder_Tasks"></a> SalesOrder_Tasks

One-To-Many Relationship: [salesorder SalesOrder_Tasks](salesorder.md#BKMK_SalesOrder_Tasks)

|Property|Value|
|---|---|
|ReferencedEntity|`salesorder`|
|ReferencedAttribute|`salesorderid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_salesorder_task`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_service_tasks"></a> service_tasks

One-To-Many Relationship: [service service_tasks](service.md#BKMK_service_tasks)

|Property|Value|
|---|---|
|ReferencedEntity|`service`|
|ReferencedAttribute|`serviceid`|
|ReferencingAttribute|`serviceid`|
|ReferencingEntityNavigationPropertyName|`serviceid_task`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Restrict`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_site_Tasks"></a> site_Tasks

One-To-Many Relationship: [site site_Tasks](site.md#BKMK_site_Tasks)

|Property|Value|
|---|---|
|ReferencedEntity|`site`|
|ReferencedAttribute|`siteid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_site_task`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|


## One-to-Many relationships

These relationships are one-to-many. Listed by **SchemaName**.

- [msdyn_msdyn_conversationactionitem_task_msdyn_CreatedActivity](#BKMK_msdyn_msdyn_conversationactionitem_task_msdyn_CreatedActivity)
- [msdyn_msdyn_ocliveworkitem_task_msdyn_routableobjectid](#BKMK_msdyn_msdyn_ocliveworkitem_task_msdyn_routableobjectid)
- [msdyn_msdyn_salescopilotinsight_task_msdyn_activityid](#BKMK_msdyn_msdyn_salescopilotinsight_task_msdyn_activityid)
- [msdyn_readtracker_poly_task](#BKMK_msdyn_readtracker_poly_task)
- [task_activitymonitor](#BKMK_task_activitymonitor)

### <a name="BKMK_msdyn_msdyn_conversationactionitem_task_msdyn_CreatedActivity"></a> msdyn_msdyn_conversationactionitem_task_msdyn_CreatedActivity

Many-To-One Relationship: [msdyn_conversationactionitem msdyn_msdyn_conversationactionitem_task_msdyn_CreatedActivity](msdyn_conversationactionitem.md#BKMK_msdyn_msdyn_conversationactionitem_task_msdyn_CreatedActivity)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_conversationactionitem`|
|ReferencingAttribute|`msdyn_createdactivity`|
|ReferencedEntityNavigationPropertyName|`msdyn_msdyn_conversationactionitem_task_msdyn_createdactivity`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_msdyn_ocliveworkitem_task_msdyn_routableobjectid"></a> msdyn_msdyn_ocliveworkitem_task_msdyn_routableobjectid

Many-To-One Relationship: [msdyn_ocliveworkitem msdyn_msdyn_ocliveworkitem_task_msdyn_routableobjectid](msdyn_ocliveworkitem.md#BKMK_msdyn_msdyn_ocliveworkitem_task_msdyn_routableobjectid)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocliveworkitem`|
|ReferencingAttribute|`msdyn_routableobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_task_msdyn_ocliveworkitem_msdyn_msdyn_routableobjectid`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_msdyn_salescopilotinsight_task_msdyn_activityid"></a> msdyn_msdyn_salescopilotinsight_task_msdyn_activityid

Many-To-One Relationship: [msdyn_salescopilotinsight msdyn_msdyn_salescopilotinsight_task_msdyn_activityid](msdyn_salescopilotinsight.md#BKMK_msdyn_msdyn_salescopilotinsight_task_msdyn_activityid)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_salescopilotinsight`|
|ReferencingAttribute|`msdyn_activityid`|
|ReferencedEntityNavigationPropertyName|`msdyn_msdyn_salescopilotinsight_task_msdyn_activityid`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_readtracker_poly_task"></a> msdyn_readtracker_poly_task

Many-To-One Relationship: [msdyn_readtracker msdyn_readtracker_poly_task](msdyn_readtracker.md#BKMK_msdyn_readtracker_poly_task)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_readtracker`|
|ReferencingAttribute|`msdyn_regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_readtracker_poly_task`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_task_activitymonitor"></a> task_activitymonitor

Many-To-One Relationship: [activitymonitor task_activitymonitor](activitymonitor.md#BKMK_task_activitymonitor)

|Property|Value|
|---|---|
|ReferencingEntity|`activitymonitor`|
|ReferencingAttribute|`monitoredactivityitemid`|
|ReferencedEntityNavigationPropertyName|`task_activitymonitor`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Service`<br />Label: <br />MenuId: null<br />Order: 10<br />QueryApi: `CRMIncident.RollupRelatedByObject`<br />ViewId: `00000000-0000-0000-00aa-000010003501`|



### See also

[Dataverse table/entity reference](/power-apps/developer/data-platform/reference/about-entity-reference)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   
<xref:Microsoft.Dynamics.CRM.task?displayProperty=fullName>
