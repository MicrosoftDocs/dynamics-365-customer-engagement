---
title: "Task table/entity reference (Microsoft Dynamics 365 Field Service)"
description: "Includes schema information and supported messages for the Task table/entity with Microsoft Dynamics 365 Field Service."
ms.date: 07.24.2024
ms.service: powerapps
ms.topic: reference
author: m-hartmann
ms.author: mhart
search.audienceType: 
  - developer
---

# Task table/entity reference

Generic activity representing work needed to be done.

> [!NOTE]
> The Microsoft Dynamics 365 Field Service Task table extends the [Microsoft Dataverse Task table](/power-apps/developer/data-platform/reference/entities/task).



## Writable columns/attributes

These columns/attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [msdyncrm_ActivityId](#BKMK_msdyncrm_ActivityId)
- [msdyncrm_associatedcustomerjourneyiteration](#BKMK_msdyncrm_associatedcustomerjourneyiteration)
- [msdynmkt_JourneyActionId](#BKMK_msdynmkt_JourneyActionId)
- [msdynmkt_JourneyId](#BKMK_msdynmkt_JourneyId)
- [ServiceId](#BKMK_ServiceId)

### <a name="BKMK_msdyncrm_ActivityId"></a> msdyncrm_ActivityId

|Property|Value|
|---|---|
|Description||
|DisplayName|**ActivityId**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_activityid`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdyncrm_associatedcustomerjourneyiteration"></a> msdyncrm_associatedcustomerjourneyiteration

|Property|Value|
|---|---|
|Description|**Customer journey iteration**|
|DisplayName|**Customer journey iteration**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_associatedcustomerjourneyiteration`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|msdyncrm_customerjourneyiteration|

### <a name="BKMK_msdynmkt_JourneyActionId"></a> msdynmkt_JourneyActionId

|Property|Value|
|---|---|
|Description|**The Journey action id in which the task is created.**|
|DisplayName|**Journey Action Id**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdynmkt_journeyactionid`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdynmkt_JourneyId"></a> msdynmkt_JourneyId

|Property|Value|
|---|---|
|Description|**The journey id in which the task is created**|
|DisplayName|**Journey Id**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdynmkt_journeyid`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|msdynmkt_journey|

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

Microsoft Dynamics 365 Field Service modifies the definition of columns/attributes defined in other solutions. Listed by **SchemaName**.

### <a name="BKMK_RegardingObjectId"></a> RegardingObjectId

Changes from [RegardingObjectId (Microsoft Dataverse)](/power-apps/developer/data-platform/reference/entities/task#BKMK_RegardingObjectId)

|Property|Value|
|---|---|
|Targets|adx_ad|


## Many-to-One relationships

These relationships are many-to-one. Listed by **SchemaName**.

- [adx_ad_Tasks](#BKMK_adx_ad_Tasks)
- [adx_adplacement_Tasks](#BKMK_adx_adplacement_Tasks)
- [adx_casedeflection_Tasks](#BKMK_adx_casedeflection_Tasks)
- [adx_communityforumaccesspermission_Tasks](#BKMK_adx_communityforumaccesspermission_Tasks)
- [adx_communityforumalert_Tasks](#BKMK_adx_communityforumalert_Tasks)
- [adx_contentaccesslevel_Tasks](#BKMK_adx_contentaccesslevel_Tasks)
- [adx_poll_Tasks](#BKMK_adx_poll_Tasks)
- [adx_polloption_Tasks](#BKMK_adx_polloption_Tasks)
- [adx_pollplacement_Tasks](#BKMK_adx_pollplacement_Tasks)
- [adx_pollsubmission_Tasks](#BKMK_adx_pollsubmission_Tasks)
- [adx_publishingstatetransitionrule_Tasks](#BKMK_adx_publishingstatetransitionrule_Tasks)
- [adx_redirect_Tasks](#BKMK_adx_redirect_Tasks)
- [adx_shortcut_Tasks](#BKMK_adx_shortcut_Tasks)
- [adx_webpage_Tasks](#BKMK_adx_webpage_Tasks)
- [adx_website_Tasks](#BKMK_adx_website_Tasks)
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
- [msdyn_agreement_Tasks](#BKMK_msdyn_agreement_Tasks)
- [msdyn_agreementbookingdate_Tasks](#BKMK_msdyn_agreementbookingdate_Tasks)
- [msdyn_agreementbookingincident_Tasks](#BKMK_msdyn_agreementbookingincident_Tasks)
- [msdyn_agreementbookingproduct_Tasks](#BKMK_msdyn_agreementbookingproduct_Tasks)
- [msdyn_agreementbookingservice_Tasks](#BKMK_msdyn_agreementbookingservice_Tasks)
- [msdyn_agreementbookingservicetask_Tasks](#BKMK_msdyn_agreementbookingservicetask_Tasks)
- [msdyn_agreementbookingsetup_Tasks](#BKMK_msdyn_agreementbookingsetup_Tasks)
- [msdyn_agreementinvoicedate_Tasks](#BKMK_msdyn_agreementinvoicedate_Tasks)
- [msdyn_agreementinvoiceproduct_Tasks](#BKMK_msdyn_agreementinvoiceproduct_Tasks)
- [msdyn_agreementinvoicesetup_Tasks](#BKMK_msdyn_agreementinvoicesetup_Tasks)
- [msdyn_bookingalertstatus_Tasks](#BKMK_msdyn_bookingalertstatus_Tasks)
- [msdyn_bookingrule_Tasks](#BKMK_msdyn_bookingrule_Tasks)
- [msdyn_bookingtimestamp_Tasks](#BKMK_msdyn_bookingtimestamp_Tasks)
- [msdyn_customerasset_Tasks](#BKMK_msdyn_customerasset_Tasks)
- [msdyn_fieldservicesetting_Tasks](#BKMK_msdyn_fieldservicesetting_Tasks)
- [msdyn_incidenttypecharacteristic_Tasks](#BKMK_msdyn_incidenttypecharacteristic_Tasks)
- [msdyn_incidenttypeproduct_Tasks](#BKMK_msdyn_incidenttypeproduct_Tasks)
- [msdyn_incidenttypeservice_Tasks](#BKMK_msdyn_incidenttypeservice_Tasks)
- [msdyn_inventoryadjustment_Tasks](#BKMK_msdyn_inventoryadjustment_Tasks)
- [msdyn_inventoryadjustmentproduct_Tasks](#BKMK_msdyn_inventoryadjustmentproduct_Tasks)
- [msdyn_inventoryjournal_Tasks](#BKMK_msdyn_inventoryjournal_Tasks)
- [msdyn_inventorytransfer_Tasks](#BKMK_msdyn_inventorytransfer_Tasks)
- [msdyn_payment_Tasks](#BKMK_msdyn_payment_Tasks)
- [msdyn_paymentdetail_Tasks](#BKMK_msdyn_paymentdetail_Tasks)
- [msdyn_paymentmethod_Tasks](#BKMK_msdyn_paymentmethod_Tasks)
- [msdyn_paymentterm_Tasks](#BKMK_msdyn_paymentterm_Tasks)
- [msdyn_playbookinstance_Tasks](#BKMK_msdyn_playbookinstance_Tasks)
- [msdyn_postalbum_Tasks](#BKMK_msdyn_postalbum_Tasks)
- [msdyn_postalcode_Tasks](#BKMK_msdyn_postalcode_Tasks)
- [msdyn_productinventory_Tasks](#BKMK_msdyn_productinventory_Tasks)
- [msdyn_purchaseorder_Tasks](#BKMK_msdyn_purchaseorder_Tasks)
- [msdyn_purchaseorderbill_Tasks](#BKMK_msdyn_purchaseorderbill_Tasks)
- [msdyn_purchaseorderproduct_Tasks](#BKMK_msdyn_purchaseorderproduct_Tasks)
- [msdyn_purchaseorderreceipt_Tasks](#BKMK_msdyn_purchaseorderreceipt_Tasks)
- [msdyn_purchaseorderreceiptproduct_Tasks](#BKMK_msdyn_purchaseorderreceiptproduct_Tasks)
- [msdyn_purchaseordersubstatus_Tasks](#BKMK_msdyn_purchaseordersubstatus_Tasks)
- [msdyn_quotebookingincident_Tasks](#BKMK_msdyn_quotebookingincident_Tasks)
- [msdyn_quotebookingproduct_Tasks](#BKMK_msdyn_quotebookingproduct_Tasks)
- [msdyn_quotebookingservice_Tasks](#BKMK_msdyn_quotebookingservice_Tasks)
- [msdyn_quotebookingservicetask_Tasks](#BKMK_msdyn_quotebookingservicetask_Tasks)
- [msdyn_resourceterritory_Tasks](#BKMK_msdyn_resourceterritory_Tasks)
- [msdyn_rma_Tasks](#BKMK_msdyn_rma_Tasks)
- [msdyn_rmaproduct_Tasks](#BKMK_msdyn_rmaproduct_Tasks)
- [msdyn_rmareceipt_Tasks](#BKMK_msdyn_rmareceipt_Tasks)
- [msdyn_rmareceiptproduct_Tasks](#BKMK_msdyn_rmareceiptproduct_Tasks)
- [msdyn_rmasubstatus_Tasks](#BKMK_msdyn_rmasubstatus_Tasks)
- [msdyn_rtv_Tasks](#BKMK_msdyn_rtv_Tasks)
- [msdyn_rtvproduct_Tasks](#BKMK_msdyn_rtvproduct_Tasks)
- [msdyn_rtvsubstatus_Tasks](#BKMK_msdyn_rtvsubstatus_Tasks)
- [msdyn_salessuggestion_Tasks](#BKMK_msdyn_salessuggestion_Tasks)
- [msdyn_shipvia_Tasks](#BKMK_msdyn_shipvia_Tasks)
- [msdyn_swarm_Tasks](#BKMK_msdyn_swarm_Tasks)
- [msdyn_systemuserschedulersetting_Tasks](#BKMK_msdyn_systemuserschedulersetting_Tasks)
- [msdyn_timegroup_Tasks](#BKMK_msdyn_timegroup_Tasks)
- [msdyn_timegroupdetail_Tasks](#BKMK_msdyn_timegroupdetail_Tasks)
- [msdyn_timeoffrequest_Tasks](#BKMK_msdyn_timeoffrequest_Tasks)
- [msdyn_warehouse_Tasks](#BKMK_msdyn_warehouse_Tasks)
- [msdyn_workorder_Tasks](#BKMK_msdyn_workorder_Tasks)
- [msdyn_workordercharacteristic_Tasks](#BKMK_msdyn_workordercharacteristic_Tasks)
- [msdyn_workorderincident_Tasks](#BKMK_msdyn_workorderincident_Tasks)
- [msdyn_workorderproduct_Tasks](#BKMK_msdyn_workorderproduct_Tasks)
- [msdyn_workorderresourcerestriction_Tasks](#BKMK_msdyn_workorderresourcerestriction_Tasks)
- [msdyn_workorderservice_Tasks](#BKMK_msdyn_workorderservice_Tasks)
- [msdyn_workorderservicetask_Tasks](#BKMK_msdyn_workorderservicetask_Tasks)
- [msdyncrm_contentsettings_Tasks](#BKMK_msdyncrm_contentsettings_Tasks)
- [msdyncrm_customerjourney_Tasks](#BKMK_msdyncrm_customerjourney_Tasks)
- [msdyncrm_leadscoremodel_Tasks](#BKMK_msdyncrm_leadscoremodel_Tasks)
- [msdyncrm_linkedinaccount_Tasks](#BKMK_msdyncrm_linkedinaccount_Tasks)
- [msdyncrm_linkedinactivity_Tasks](#BKMK_msdyncrm_linkedinactivity_Tasks)
- [msdyncrm_linkedinfieldmapping_Tasks](#BKMK_msdyncrm_linkedinfieldmapping_Tasks)
- [msdyncrm_linkedinform_Tasks](#BKMK_msdyncrm_linkedinform_Tasks)
- [msdyncrm_linkedinformanswer_Tasks](#BKMK_msdyncrm_linkedinformanswer_Tasks)
- [msdyncrm_linkedinformquestion_Tasks](#BKMK_msdyncrm_linkedinformquestion_Tasks)
- [msdyncrm_linkedinformsubmission_Tasks](#BKMK_msdyncrm_linkedinformsubmission_Tasks)
- [msdyncrm_linkedinleadmatchingstrategy_Tasks](#BKMK_msdyncrm_linkedinleadmatchingstrategy_Tasks)
- [msdyncrm_linkedinuserprofile_Tasks](#BKMK_msdyncrm_linkedinuserprofile_Tasks)
- [msdyncrm_marketingdynamiccontentmetadata_Tasks](#BKMK_msdyncrm_marketingdynamiccontentmetadata_Tasks)
- [msdyncrm_marketingemaildynamiccontentmetadata_Tasks](#BKMK_msdyncrm_marketingemaildynamiccontentmetadata_Tasks)
- [msdyncrm_marketingemailtestsend_Tasks](#BKMK_msdyncrm_marketingemailtestsend_Tasks)
- [msdyncrm_migration_Tasks](#BKMK_msdyncrm_migration_Tasks)
- [msdyncrm_msdyncrm_customerjourneyiteration_task](#BKMK_msdyncrm_msdyncrm_customerjourneyiteration_task)
- [msdyncrm_uicconfig_Tasks](#BKMK_msdyncrm_uicconfig_Tasks)
- [msdynmkt_task_JourneyId_msdynmkt_journey](#BKMK_msdynmkt_task_JourneyId_msdynmkt_journey)
- [msevtmgt_checkin_Tasks](#BKMK_msevtmgt_checkin_Tasks)
- [msevtmgt_event_Tasks](#BKMK_msevtmgt_event_Tasks)
- [msevtmgt_eventpurchase_Tasks](#BKMK_msevtmgt_eventpurchase_Tasks)
- [msevtmgt_eventpurchaseattendee_Tasks](#BKMK_msevtmgt_eventpurchaseattendee_Tasks)
- [msevtmgt_eventpurchasepass_Tasks](#BKMK_msevtmgt_eventpurchasepass_Tasks)
- [msevtmgt_eventregistration_Tasks](#BKMK_msevtmgt_eventregistration_Tasks)
- [msevtmgt_hotel_Tasks](#BKMK_msevtmgt_hotel_Tasks)
- [msevtmgt_hotelroomallocation_Tasks](#BKMK_msevtmgt_hotelroomallocation_Tasks)
- [msevtmgt_hotelroomreservation_Tasks](#BKMK_msevtmgt_hotelroomreservation_Tasks)
- [msevtmgt_layout_Tasks](#BKMK_msevtmgt_layout_Tasks)
- [msevtmgt_room_Tasks](#BKMK_msevtmgt_room_Tasks)
- [msevtmgt_session_Tasks](#BKMK_msevtmgt_session_Tasks)
- [msevtmgt_sessionregistration_Tasks](#BKMK_msevtmgt_sessionregistration_Tasks)
- [msevtmgt_sessiontrack_Tasks](#BKMK_msevtmgt_sessiontrack_Tasks)
- [msevtmgt_speaker_Tasks](#BKMK_msevtmgt_speaker_Tasks)
- [msevtmgt_speakerengagement_Tasks](#BKMK_msevtmgt_speakerengagement_Tasks)
- [msevtmgt_sponsorablearticle_Tasks](#BKMK_msevtmgt_sponsorablearticle_Tasks)
- [msevtmgt_sponsorship_Tasks](#BKMK_msevtmgt_sponsorship_Tasks)
- [msevtmgt_venue_Tasks](#BKMK_msevtmgt_venue_Tasks)
- [msevtmgt_webinarconfiguration_Tasks](#BKMK_msevtmgt_webinarconfiguration_Tasks)
- [msevtmgt_webinarprovider_Tasks](#BKMK_msevtmgt_webinarprovider_Tasks)
- [Opportunity_Tasks](#BKMK_Opportunity_Tasks)
- [Quote_Tasks](#BKMK_Quote_Tasks)
- [SalesOrder_Tasks](#BKMK_SalesOrder_Tasks)
- [service_tasks](#BKMK_service_tasks)
- [site_Tasks](#BKMK_site_Tasks)

### <a name="BKMK_adx_ad_Tasks"></a> adx_ad_Tasks

One-To-Many Relationship: [adx_ad adx_ad_Tasks](adx_ad.md#BKMK_adx_ad_Tasks)

|Property|Value|
|---|---|
|ReferencedEntity|`adx_ad`|
|ReferencedAttribute|`adx_adid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_adx_ad_task`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_adx_adplacement_Tasks"></a> adx_adplacement_Tasks

One-To-Many Relationship: [adx_adplacement adx_adplacement_Tasks](adx_adplacement.md#BKMK_adx_adplacement_Tasks)

|Property|Value|
|---|---|
|ReferencedEntity|`adx_adplacement`|
|ReferencedAttribute|`adx_adplacementid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_adx_adplacement_task`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_adx_casedeflection_Tasks"></a> adx_casedeflection_Tasks

One-To-Many Relationship: [adx_casedeflection adx_casedeflection_Tasks](adx_casedeflection.md#BKMK_adx_casedeflection_Tasks)

|Property|Value|
|---|---|
|ReferencedEntity|`adx_casedeflection`|
|ReferencedAttribute|`adx_casedeflectionid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_adx_casedeflection_task`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_adx_communityforumaccesspermission_Tasks"></a> adx_communityforumaccesspermission_Tasks

One-To-Many Relationship: [adx_communityforumaccesspermission adx_communityforumaccesspermission_Tasks](adx_communityforumaccesspermission.md#BKMK_adx_communityforumaccesspermission_Tasks)

|Property|Value|
|---|---|
|ReferencedEntity|`adx_communityforumaccesspermission`|
|ReferencedAttribute|`adx_communityforumaccesspermissionid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_adx_communityforumaccesspermission_task`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_adx_communityforumalert_Tasks"></a> adx_communityforumalert_Tasks

One-To-Many Relationship: [adx_communityforumalert adx_communityforumalert_Tasks](adx_communityforumalert.md#BKMK_adx_communityforumalert_Tasks)

|Property|Value|
|---|---|
|ReferencedEntity|`adx_communityforumalert`|
|ReferencedAttribute|`adx_communityforumalertid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_adx_communityforumalert_task`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_adx_contentaccesslevel_Tasks"></a> adx_contentaccesslevel_Tasks

One-To-Many Relationship: [adx_contentaccesslevel adx_contentaccesslevel_Tasks](adx_contentaccesslevel.md#BKMK_adx_contentaccesslevel_Tasks)

|Property|Value|
|---|---|
|ReferencedEntity|`adx_contentaccesslevel`|
|ReferencedAttribute|`adx_contentaccesslevelid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_adx_contentaccesslevel_task`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_adx_poll_Tasks"></a> adx_poll_Tasks

One-To-Many Relationship: [adx_poll adx_poll_Tasks](adx_poll.md#BKMK_adx_poll_Tasks)

|Property|Value|
|---|---|
|ReferencedEntity|`adx_poll`|
|ReferencedAttribute|`adx_pollid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_adx_poll_task`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_adx_polloption_Tasks"></a> adx_polloption_Tasks

One-To-Many Relationship: [adx_polloption adx_polloption_Tasks](adx_polloption.md#BKMK_adx_polloption_Tasks)

|Property|Value|
|---|---|
|ReferencedEntity|`adx_polloption`|
|ReferencedAttribute|`adx_polloptionid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_adx_polloption_task`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_adx_pollplacement_Tasks"></a> adx_pollplacement_Tasks

One-To-Many Relationship: [adx_pollplacement adx_pollplacement_Tasks](adx_pollplacement.md#BKMK_adx_pollplacement_Tasks)

|Property|Value|
|---|---|
|ReferencedEntity|`adx_pollplacement`|
|ReferencedAttribute|`adx_pollplacementid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_adx_pollplacement_task`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_adx_pollsubmission_Tasks"></a> adx_pollsubmission_Tasks

One-To-Many Relationship: [adx_pollsubmission adx_pollsubmission_Tasks](adx_pollsubmission.md#BKMK_adx_pollsubmission_Tasks)

|Property|Value|
|---|---|
|ReferencedEntity|`adx_pollsubmission`|
|ReferencedAttribute|`adx_pollsubmissionid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_adx_pollsubmission_task`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_adx_publishingstatetransitionrule_Tasks"></a> adx_publishingstatetransitionrule_Tasks

One-To-Many Relationship: [adx_publishingstatetransitionrule adx_publishingstatetransitionrule_Tasks](adx_publishingstatetransitionrule.md#BKMK_adx_publishingstatetransitionrule_Tasks)

|Property|Value|
|---|---|
|ReferencedEntity|`adx_publishingstatetransitionrule`|
|ReferencedAttribute|`adx_publishingstatetransitionruleid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_adx_publishingstatetransitionrule_task`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_adx_redirect_Tasks"></a> adx_redirect_Tasks

One-To-Many Relationship: [adx_redirect adx_redirect_Tasks](adx_redirect.md#BKMK_adx_redirect_Tasks)

|Property|Value|
|---|---|
|ReferencedEntity|`adx_redirect`|
|ReferencedAttribute|`adx_redirectid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_adx_redirect_task`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_adx_shortcut_Tasks"></a> adx_shortcut_Tasks

One-To-Many Relationship: [adx_shortcut adx_shortcut_Tasks](adx_shortcut.md#BKMK_adx_shortcut_Tasks)

|Property|Value|
|---|---|
|ReferencedEntity|`adx_shortcut`|
|ReferencedAttribute|`adx_shortcutid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_adx_shortcut_task`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_adx_webpage_Tasks"></a> adx_webpage_Tasks

One-To-Many Relationship: [adx_webpage adx_webpage_Tasks](adx_webpage.md#BKMK_adx_webpage_Tasks)

|Property|Value|
|---|---|
|ReferencedEntity|`adx_webpage`|
|ReferencedAttribute|`adx_webpageid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_adx_webpage_task`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_adx_website_Tasks"></a> adx_website_Tasks

One-To-Many Relationship: [adx_website adx_website_Tasks](adx_website.md#BKMK_adx_website_Tasks)

|Property|Value|
|---|---|
|ReferencedEntity|`adx_website`|
|ReferencedAttribute|`adx_websiteid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_adx_website_task`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

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

### <a name="BKMK_msdyn_agreement_Tasks"></a> msdyn_agreement_Tasks

One-To-Many Relationship: [msdyn_agreement msdyn_agreement_Tasks](msdyn_agreement.md#BKMK_msdyn_agreement_Tasks)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_agreement`|
|ReferencedAttribute|`msdyn_agreementid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_agreement_task`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_agreementbookingdate_Tasks"></a> msdyn_agreementbookingdate_Tasks

One-To-Many Relationship: [msdyn_agreementbookingdate msdyn_agreementbookingdate_Tasks](msdyn_agreementbookingdate.md#BKMK_msdyn_agreementbookingdate_Tasks)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_agreementbookingdate`|
|ReferencedAttribute|`msdyn_agreementbookingdateid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_agreementbookingdate_task`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_agreementbookingincident_Tasks"></a> msdyn_agreementbookingincident_Tasks

One-To-Many Relationship: [msdyn_agreementbookingincident msdyn_agreementbookingincident_Tasks](msdyn_agreementbookingincident.md#BKMK_msdyn_agreementbookingincident_Tasks)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_agreementbookingincident`|
|ReferencedAttribute|`msdyn_agreementbookingincidentid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_agreementbookingincident_task`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_agreementbookingproduct_Tasks"></a> msdyn_agreementbookingproduct_Tasks

One-To-Many Relationship: [msdyn_agreementbookingproduct msdyn_agreementbookingproduct_Tasks](msdyn_agreementbookingproduct.md#BKMK_msdyn_agreementbookingproduct_Tasks)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_agreementbookingproduct`|
|ReferencedAttribute|`msdyn_agreementbookingproductid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_agreementbookingproduct_task`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_agreementbookingservice_Tasks"></a> msdyn_agreementbookingservice_Tasks

One-To-Many Relationship: [msdyn_agreementbookingservice msdyn_agreementbookingservice_Tasks](msdyn_agreementbookingservice.md#BKMK_msdyn_agreementbookingservice_Tasks)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_agreementbookingservice`|
|ReferencedAttribute|`msdyn_agreementbookingserviceid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_agreementbookingservice_task`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_agreementbookingservicetask_Tasks"></a> msdyn_agreementbookingservicetask_Tasks

One-To-Many Relationship: [msdyn_agreementbookingservicetask msdyn_agreementbookingservicetask_Tasks](msdyn_agreementbookingservicetask.md#BKMK_msdyn_agreementbookingservicetask_Tasks)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_agreementbookingservicetask`|
|ReferencedAttribute|`msdyn_agreementbookingservicetaskid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_agreementbookingservicetask_task`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_agreementbookingsetup_Tasks"></a> msdyn_agreementbookingsetup_Tasks

One-To-Many Relationship: [msdyn_agreementbookingsetup msdyn_agreementbookingsetup_Tasks](msdyn_agreementbookingsetup.md#BKMK_msdyn_agreementbookingsetup_Tasks)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_agreementbookingsetup`|
|ReferencedAttribute|`msdyn_agreementbookingsetupid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_agreementbookingsetup_task`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_agreementinvoicedate_Tasks"></a> msdyn_agreementinvoicedate_Tasks

One-To-Many Relationship: [msdyn_agreementinvoicedate msdyn_agreementinvoicedate_Tasks](msdyn_agreementinvoicedate.md#BKMK_msdyn_agreementinvoicedate_Tasks)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_agreementinvoicedate`|
|ReferencedAttribute|`msdyn_agreementinvoicedateid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_agreementinvoicedate_task`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_agreementinvoiceproduct_Tasks"></a> msdyn_agreementinvoiceproduct_Tasks

One-To-Many Relationship: [msdyn_agreementinvoiceproduct msdyn_agreementinvoiceproduct_Tasks](msdyn_agreementinvoiceproduct.md#BKMK_msdyn_agreementinvoiceproduct_Tasks)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_agreementinvoiceproduct`|
|ReferencedAttribute|`msdyn_agreementinvoiceproductid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_agreementinvoiceproduct_task`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_agreementinvoicesetup_Tasks"></a> msdyn_agreementinvoicesetup_Tasks

One-To-Many Relationship: [msdyn_agreementinvoicesetup msdyn_agreementinvoicesetup_Tasks](msdyn_agreementinvoicesetup.md#BKMK_msdyn_agreementinvoicesetup_Tasks)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_agreementinvoicesetup`|
|ReferencedAttribute|`msdyn_agreementinvoicesetupid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_agreementinvoicesetup_task`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_bookingalertstatus_Tasks"></a> msdyn_bookingalertstatus_Tasks

One-To-Many Relationship: [msdyn_bookingalertstatus msdyn_bookingalertstatus_Tasks](msdyn_bookingalertstatus.md#BKMK_msdyn_bookingalertstatus_Tasks)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_bookingalertstatus`|
|ReferencedAttribute|`msdyn_bookingalertstatusid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_bookingalertstatus_task`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_bookingrule_Tasks"></a> msdyn_bookingrule_Tasks

One-To-Many Relationship: [msdyn_bookingrule msdyn_bookingrule_Tasks](msdyn_bookingrule.md#BKMK_msdyn_bookingrule_Tasks)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_bookingrule`|
|ReferencedAttribute|`msdyn_bookingruleid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_bookingrule_task`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_bookingtimestamp_Tasks"></a> msdyn_bookingtimestamp_Tasks

One-To-Many Relationship: [msdyn_bookingtimestamp msdyn_bookingtimestamp_Tasks](msdyn_bookingtimestamp.md#BKMK_msdyn_bookingtimestamp_Tasks)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_bookingtimestamp`|
|ReferencedAttribute|`msdyn_bookingtimestampid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_bookingtimestamp_task`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

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

### <a name="BKMK_msdyn_fieldservicesetting_Tasks"></a> msdyn_fieldservicesetting_Tasks

One-To-Many Relationship: [msdyn_fieldservicesetting msdyn_fieldservicesetting_Tasks](msdyn_fieldservicesetting.md#BKMK_msdyn_fieldservicesetting_Tasks)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_fieldservicesetting`|
|ReferencedAttribute|`msdyn_fieldservicesettingid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_fieldservicesetting_task`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_incidenttypecharacteristic_Tasks"></a> msdyn_incidenttypecharacteristic_Tasks

One-To-Many Relationship: [msdyn_incidenttypecharacteristic msdyn_incidenttypecharacteristic_Tasks](msdyn_incidenttypecharacteristic.md#BKMK_msdyn_incidenttypecharacteristic_Tasks)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_incidenttypecharacteristic`|
|ReferencedAttribute|`msdyn_incidenttypecharacteristicid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_incidenttypecharacteristic_task`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_incidenttypeproduct_Tasks"></a> msdyn_incidenttypeproduct_Tasks

One-To-Many Relationship: [msdyn_incidenttypeproduct msdyn_incidenttypeproduct_Tasks](msdyn_incidenttypeproduct.md#BKMK_msdyn_incidenttypeproduct_Tasks)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_incidenttypeproduct`|
|ReferencedAttribute|`msdyn_incidenttypeproductid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_incidenttypeproduct_task`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_incidenttypeservice_Tasks"></a> msdyn_incidenttypeservice_Tasks

One-To-Many Relationship: [msdyn_incidenttypeservice msdyn_incidenttypeservice_Tasks](msdyn_incidenttypeservice.md#BKMK_msdyn_incidenttypeservice_Tasks)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_incidenttypeservice`|
|ReferencedAttribute|`msdyn_incidenttypeserviceid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_incidenttypeservice_task`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_inventoryadjustment_Tasks"></a> msdyn_inventoryadjustment_Tasks

One-To-Many Relationship: [msdyn_inventoryadjustment msdyn_inventoryadjustment_Tasks](msdyn_inventoryadjustment.md#BKMK_msdyn_inventoryadjustment_Tasks)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_inventoryadjustment`|
|ReferencedAttribute|`msdyn_inventoryadjustmentid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_inventoryadjustment_task`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_inventoryadjustmentproduct_Tasks"></a> msdyn_inventoryadjustmentproduct_Tasks

One-To-Many Relationship: [msdyn_inventoryadjustmentproduct msdyn_inventoryadjustmentproduct_Tasks](msdyn_inventoryadjustmentproduct.md#BKMK_msdyn_inventoryadjustmentproduct_Tasks)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_inventoryadjustmentproduct`|
|ReferencedAttribute|`msdyn_inventoryadjustmentproductid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_inventoryadjustmentproduct_task`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_inventoryjournal_Tasks"></a> msdyn_inventoryjournal_Tasks

One-To-Many Relationship: [msdyn_inventoryjournal msdyn_inventoryjournal_Tasks](msdyn_inventoryjournal.md#BKMK_msdyn_inventoryjournal_Tasks)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_inventoryjournal`|
|ReferencedAttribute|`msdyn_inventoryjournalid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_inventoryjournal_task`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_inventorytransfer_Tasks"></a> msdyn_inventorytransfer_Tasks

One-To-Many Relationship: [msdyn_inventorytransfer msdyn_inventorytransfer_Tasks](msdyn_inventorytransfer.md#BKMK_msdyn_inventorytransfer_Tasks)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_inventorytransfer`|
|ReferencedAttribute|`msdyn_inventorytransferid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_inventorytransfer_task`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_payment_Tasks"></a> msdyn_payment_Tasks

One-To-Many Relationship: [msdyn_payment msdyn_payment_Tasks](msdyn_payment.md#BKMK_msdyn_payment_Tasks)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_payment`|
|ReferencedAttribute|`msdyn_paymentid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_payment_task`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_paymentdetail_Tasks"></a> msdyn_paymentdetail_Tasks

One-To-Many Relationship: [msdyn_paymentdetail msdyn_paymentdetail_Tasks](msdyn_paymentdetail.md#BKMK_msdyn_paymentdetail_Tasks)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_paymentdetail`|
|ReferencedAttribute|`msdyn_paymentdetailid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_paymentdetail_task`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_paymentmethod_Tasks"></a> msdyn_paymentmethod_Tasks

One-To-Many Relationship: [msdyn_paymentmethod msdyn_paymentmethod_Tasks](msdyn_paymentmethod.md#BKMK_msdyn_paymentmethod_Tasks)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_paymentmethod`|
|ReferencedAttribute|`msdyn_paymentmethodid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_paymentmethod_task`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_paymentterm_Tasks"></a> msdyn_paymentterm_Tasks

One-To-Many Relationship: [msdyn_paymentterm msdyn_paymentterm_Tasks](msdyn_paymentterm.md#BKMK_msdyn_paymentterm_Tasks)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_paymentterm`|
|ReferencedAttribute|`msdyn_paymenttermid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_paymentterm_task`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_playbookinstance_Tasks"></a> msdyn_playbookinstance_Tasks

One-To-Many Relationship: [msdyn_playbookinstance msdyn_playbookinstance_Tasks](msdyn_playbookinstance.md#BKMK_msdyn_playbookinstance_Tasks)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_playbookinstance`|
|ReferencedAttribute|`msdyn_playbookinstanceid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_playbookinstance_task`|
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

### <a name="BKMK_msdyn_postalcode_Tasks"></a> msdyn_postalcode_Tasks

One-To-Many Relationship: [msdyn_postalcode msdyn_postalcode_Tasks](msdyn_postalcode.md#BKMK_msdyn_postalcode_Tasks)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_postalcode`|
|ReferencedAttribute|`msdyn_postalcodeid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_postalcode_task`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_productinventory_Tasks"></a> msdyn_productinventory_Tasks

One-To-Many Relationship: [msdyn_productinventory msdyn_productinventory_Tasks](msdyn_productinventory.md#BKMK_msdyn_productinventory_Tasks)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_productinventory`|
|ReferencedAttribute|`msdyn_productinventoryid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_productinventory_task`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_purchaseorder_Tasks"></a> msdyn_purchaseorder_Tasks

One-To-Many Relationship: [msdyn_purchaseorder msdyn_purchaseorder_Tasks](msdyn_purchaseorder.md#BKMK_msdyn_purchaseorder_Tasks)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_purchaseorder`|
|ReferencedAttribute|`msdyn_purchaseorderid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_purchaseorder_task`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_purchaseorderbill_Tasks"></a> msdyn_purchaseorderbill_Tasks

One-To-Many Relationship: [msdyn_purchaseorderbill msdyn_purchaseorderbill_Tasks](msdyn_purchaseorderbill.md#BKMK_msdyn_purchaseorderbill_Tasks)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_purchaseorderbill`|
|ReferencedAttribute|`msdyn_purchaseorderbillid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_purchaseorderbill_task`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_purchaseorderproduct_Tasks"></a> msdyn_purchaseorderproduct_Tasks

One-To-Many Relationship: [msdyn_purchaseorderproduct msdyn_purchaseorderproduct_Tasks](msdyn_purchaseorderproduct.md#BKMK_msdyn_purchaseorderproduct_Tasks)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_purchaseorderproduct`|
|ReferencedAttribute|`msdyn_purchaseorderproductid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_purchaseorderproduct_task`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_purchaseorderreceipt_Tasks"></a> msdyn_purchaseorderreceipt_Tasks

One-To-Many Relationship: [msdyn_purchaseorderreceipt msdyn_purchaseorderreceipt_Tasks](msdyn_purchaseorderreceipt.md#BKMK_msdyn_purchaseorderreceipt_Tasks)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_purchaseorderreceipt`|
|ReferencedAttribute|`msdyn_purchaseorderreceiptid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_purchaseorderreceipt_task`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_purchaseorderreceiptproduct_Tasks"></a> msdyn_purchaseorderreceiptproduct_Tasks

One-To-Many Relationship: [msdyn_purchaseorderreceiptproduct msdyn_purchaseorderreceiptproduct_Tasks](msdyn_purchaseorderreceiptproduct.md#BKMK_msdyn_purchaseorderreceiptproduct_Tasks)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_purchaseorderreceiptproduct`|
|ReferencedAttribute|`msdyn_purchaseorderreceiptproductid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_purchaseorderreceiptproduct_task`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_purchaseordersubstatus_Tasks"></a> msdyn_purchaseordersubstatus_Tasks

One-To-Many Relationship: [msdyn_purchaseordersubstatus msdyn_purchaseordersubstatus_Tasks](msdyn_purchaseordersubstatus.md#BKMK_msdyn_purchaseordersubstatus_Tasks)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_purchaseordersubstatus`|
|ReferencedAttribute|`msdyn_purchaseordersubstatusid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_purchaseordersubstatus_task`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_quotebookingincident_Tasks"></a> msdyn_quotebookingincident_Tasks

One-To-Many Relationship: [msdyn_quotebookingincident msdyn_quotebookingincident_Tasks](msdyn_quotebookingincident.md#BKMK_msdyn_quotebookingincident_Tasks)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_quotebookingincident`|
|ReferencedAttribute|`msdyn_quotebookingincidentid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_quotebookingincident_task`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_quotebookingproduct_Tasks"></a> msdyn_quotebookingproduct_Tasks

One-To-Many Relationship: [msdyn_quotebookingproduct msdyn_quotebookingproduct_Tasks](msdyn_quotebookingproduct.md#BKMK_msdyn_quotebookingproduct_Tasks)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_quotebookingproduct`|
|ReferencedAttribute|`msdyn_quotebookingproductid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_quotebookingproduct_task`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_quotebookingservice_Tasks"></a> msdyn_quotebookingservice_Tasks

One-To-Many Relationship: [msdyn_quotebookingservice msdyn_quotebookingservice_Tasks](msdyn_quotebookingservice.md#BKMK_msdyn_quotebookingservice_Tasks)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_quotebookingservice`|
|ReferencedAttribute|`msdyn_quotebookingserviceid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_quotebookingservice_task`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_quotebookingservicetask_Tasks"></a> msdyn_quotebookingservicetask_Tasks

One-To-Many Relationship: [msdyn_quotebookingservicetask msdyn_quotebookingservicetask_Tasks](msdyn_quotebookingservicetask.md#BKMK_msdyn_quotebookingservicetask_Tasks)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_quotebookingservicetask`|
|ReferencedAttribute|`msdyn_quotebookingservicetaskid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_quotebookingservicetask_task`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_resourceterritory_Tasks"></a> msdyn_resourceterritory_Tasks

One-To-Many Relationship: [msdyn_resourceterritory msdyn_resourceterritory_Tasks](msdyn_resourceterritory.md#BKMK_msdyn_resourceterritory_Tasks)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_resourceterritory`|
|ReferencedAttribute|`msdyn_resourceterritoryid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_resourceterritory_task`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_rma_Tasks"></a> msdyn_rma_Tasks

One-To-Many Relationship: [msdyn_rma msdyn_rma_Tasks](msdyn_rma.md#BKMK_msdyn_rma_Tasks)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_rma`|
|ReferencedAttribute|`msdyn_rmaid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_rma_task`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_rmaproduct_Tasks"></a> msdyn_rmaproduct_Tasks

One-To-Many Relationship: [msdyn_rmaproduct msdyn_rmaproduct_Tasks](msdyn_rmaproduct.md#BKMK_msdyn_rmaproduct_Tasks)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_rmaproduct`|
|ReferencedAttribute|`msdyn_rmaproductid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_rmaproduct_task`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_rmareceipt_Tasks"></a> msdyn_rmareceipt_Tasks

One-To-Many Relationship: [msdyn_rmareceipt msdyn_rmareceipt_Tasks](msdyn_rmareceipt.md#BKMK_msdyn_rmareceipt_Tasks)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_rmareceipt`|
|ReferencedAttribute|`msdyn_rmareceiptid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_rmareceipt_task`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_rmareceiptproduct_Tasks"></a> msdyn_rmareceiptproduct_Tasks

One-To-Many Relationship: [msdyn_rmareceiptproduct msdyn_rmareceiptproduct_Tasks](msdyn_rmareceiptproduct.md#BKMK_msdyn_rmareceiptproduct_Tasks)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_rmareceiptproduct`|
|ReferencedAttribute|`msdyn_rmareceiptproductid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_rmareceiptproduct_task`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_rmasubstatus_Tasks"></a> msdyn_rmasubstatus_Tasks

One-To-Many Relationship: [msdyn_rmasubstatus msdyn_rmasubstatus_Tasks](msdyn_rmasubstatus.md#BKMK_msdyn_rmasubstatus_Tasks)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_rmasubstatus`|
|ReferencedAttribute|`msdyn_rmasubstatusid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_rmasubstatus_task`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_rtv_Tasks"></a> msdyn_rtv_Tasks

One-To-Many Relationship: [msdyn_rtv msdyn_rtv_Tasks](msdyn_rtv.md#BKMK_msdyn_rtv_Tasks)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_rtv`|
|ReferencedAttribute|`msdyn_rtvid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_rtv_task`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_rtvproduct_Tasks"></a> msdyn_rtvproduct_Tasks

One-To-Many Relationship: [msdyn_rtvproduct msdyn_rtvproduct_Tasks](msdyn_rtvproduct.md#BKMK_msdyn_rtvproduct_Tasks)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_rtvproduct`|
|ReferencedAttribute|`msdyn_rtvproductid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_rtvproduct_task`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_rtvsubstatus_Tasks"></a> msdyn_rtvsubstatus_Tasks

One-To-Many Relationship: [msdyn_rtvsubstatus msdyn_rtvsubstatus_Tasks](msdyn_rtvsubstatus.md#BKMK_msdyn_rtvsubstatus_Tasks)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_rtvsubstatus`|
|ReferencedAttribute|`msdyn_rtvsubstatusid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_rtvsubstatus_task`|
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

### <a name="BKMK_msdyn_shipvia_Tasks"></a> msdyn_shipvia_Tasks

One-To-Many Relationship: [msdyn_shipvia msdyn_shipvia_Tasks](msdyn_shipvia.md#BKMK_msdyn_shipvia_Tasks)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_shipvia`|
|ReferencedAttribute|`msdyn_shipviaid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_shipvia_task`|
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

### <a name="BKMK_msdyn_systemuserschedulersetting_Tasks"></a> msdyn_systemuserschedulersetting_Tasks

One-To-Many Relationship: [msdyn_systemuserschedulersetting msdyn_systemuserschedulersetting_Tasks](msdyn_systemuserschedulersetting.md#BKMK_msdyn_systemuserschedulersetting_Tasks)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_systemuserschedulersetting`|
|ReferencedAttribute|`msdyn_systemuserschedulersettingid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_systemuserschedulersetting_task`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_timegroup_Tasks"></a> msdyn_timegroup_Tasks

One-To-Many Relationship: [msdyn_timegroup msdyn_timegroup_Tasks](msdyn_timegroup.md#BKMK_msdyn_timegroup_Tasks)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_timegroup`|
|ReferencedAttribute|`msdyn_timegroupid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_timegroup_task`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_timegroupdetail_Tasks"></a> msdyn_timegroupdetail_Tasks

One-To-Many Relationship: [msdyn_timegroupdetail msdyn_timegroupdetail_Tasks](msdyn_timegroupdetail.md#BKMK_msdyn_timegroupdetail_Tasks)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_timegroupdetail`|
|ReferencedAttribute|`msdyn_timegroupdetailid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_timegroupdetail_task`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_timeoffrequest_Tasks"></a> msdyn_timeoffrequest_Tasks

One-To-Many Relationship: [msdyn_timeoffrequest msdyn_timeoffrequest_Tasks](msdyn_timeoffrequest.md#BKMK_msdyn_timeoffrequest_Tasks)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_timeoffrequest`|
|ReferencedAttribute|`msdyn_timeoffrequestid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_timeoffrequest_task`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_warehouse_Tasks"></a> msdyn_warehouse_Tasks

One-To-Many Relationship: [msdyn_warehouse msdyn_warehouse_Tasks](msdyn_warehouse.md#BKMK_msdyn_warehouse_Tasks)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_warehouse`|
|ReferencedAttribute|`msdyn_warehouseid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_warehouse_task`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_workorder_Tasks"></a> msdyn_workorder_Tasks

One-To-Many Relationship: [msdyn_workorder msdyn_workorder_Tasks](msdyn_workorder.md#BKMK_msdyn_workorder_Tasks)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_workorder`|
|ReferencedAttribute|`msdyn_workorderid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_workorder_task`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_workordercharacteristic_Tasks"></a> msdyn_workordercharacteristic_Tasks

One-To-Many Relationship: [msdyn_workordercharacteristic msdyn_workordercharacteristic_Tasks](msdyn_workordercharacteristic.md#BKMK_msdyn_workordercharacteristic_Tasks)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_workordercharacteristic`|
|ReferencedAttribute|`msdyn_workordercharacteristicid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_workordercharacteristic_task`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_workorderincident_Tasks"></a> msdyn_workorderincident_Tasks

One-To-Many Relationship: [msdyn_workorderincident msdyn_workorderincident_Tasks](msdyn_workorderincident.md#BKMK_msdyn_workorderincident_Tasks)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_workorderincident`|
|ReferencedAttribute|`msdyn_workorderincidentid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_workorderincident_task`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_workorderproduct_Tasks"></a> msdyn_workorderproduct_Tasks

One-To-Many Relationship: [msdyn_workorderproduct msdyn_workorderproduct_Tasks](msdyn_workorderproduct.md#BKMK_msdyn_workorderproduct_Tasks)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_workorderproduct`|
|ReferencedAttribute|`msdyn_workorderproductid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_workorderproduct_task`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_workorderresourcerestriction_Tasks"></a> msdyn_workorderresourcerestriction_Tasks

One-To-Many Relationship: [msdyn_workorderresourcerestriction msdyn_workorderresourcerestriction_Tasks](msdyn_workorderresourcerestriction.md#BKMK_msdyn_workorderresourcerestriction_Tasks)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_workorderresourcerestriction`|
|ReferencedAttribute|`msdyn_workorderresourcerestrictionid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_workorderresourcerestriction_task`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_workorderservice_Tasks"></a> msdyn_workorderservice_Tasks

One-To-Many Relationship: [msdyn_workorderservice msdyn_workorderservice_Tasks](msdyn_workorderservice.md#BKMK_msdyn_workorderservice_Tasks)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_workorderservice`|
|ReferencedAttribute|`msdyn_workorderserviceid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_workorderservice_task`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_workorderservicetask_Tasks"></a> msdyn_workorderservicetask_Tasks

One-To-Many Relationship: [msdyn_workorderservicetask msdyn_workorderservicetask_Tasks](msdyn_workorderservicetask.md#BKMK_msdyn_workorderservicetask_Tasks)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_workorderservicetask`|
|ReferencedAttribute|`msdyn_workorderservicetaskid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_workorderservicetask_task`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyncrm_contentsettings_Tasks"></a> msdyncrm_contentsettings_Tasks

One-To-Many Relationship: [msdyncrm_contentsettings msdyncrm_contentsettings_Tasks](msdyncrm_contentsettings.md#BKMK_msdyncrm_contentsettings_Tasks)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyncrm_contentsettings`|
|ReferencedAttribute|`msdyncrm_contentsettingsid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyncrm_contentsettings_task`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyncrm_customerjourney_Tasks"></a> msdyncrm_customerjourney_Tasks

One-To-Many Relationship: [msdyncrm_customerjourney msdyncrm_customerjourney_Tasks](msdyncrm_customerjourney.md#BKMK_msdyncrm_customerjourney_Tasks)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyncrm_customerjourney`|
|ReferencedAttribute|`msdyncrm_customerjourneyid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyncrm_customerjourney_task`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyncrm_leadscoremodel_Tasks"></a> msdyncrm_leadscoremodel_Tasks

One-To-Many Relationship: [msdyncrm_leadscoremodel msdyncrm_leadscoremodel_Tasks](msdyncrm_leadscoremodel.md#BKMK_msdyncrm_leadscoremodel_Tasks)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyncrm_leadscoremodel`|
|ReferencedAttribute|`msdyncrm_leadscoremodelid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyncrm_leadscoremodel_task`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyncrm_linkedinaccount_Tasks"></a> msdyncrm_linkedinaccount_Tasks

One-To-Many Relationship: [msdyncrm_linkedinaccount msdyncrm_linkedinaccount_Tasks](msdyncrm_linkedinaccount.md#BKMK_msdyncrm_linkedinaccount_Tasks)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyncrm_linkedinaccount`|
|ReferencedAttribute|`msdyncrm_linkedinaccountid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyncrm_linkedinaccount_task`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyncrm_linkedinactivity_Tasks"></a> msdyncrm_linkedinactivity_Tasks

One-To-Many Relationship: [msdyncrm_linkedinactivity msdyncrm_linkedinactivity_Tasks](msdyncrm_linkedinactivity.md#BKMK_msdyncrm_linkedinactivity_Tasks)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyncrm_linkedinactivity`|
|ReferencedAttribute|`msdyncrm_linkedinactivityid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyncrm_linkedinactivity_task`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyncrm_linkedinfieldmapping_Tasks"></a> msdyncrm_linkedinfieldmapping_Tasks

One-To-Many Relationship: [msdyncrm_linkedinfieldmapping msdyncrm_linkedinfieldmapping_Tasks](msdyncrm_linkedinfieldmapping.md#BKMK_msdyncrm_linkedinfieldmapping_Tasks)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyncrm_linkedinfieldmapping`|
|ReferencedAttribute|`msdyncrm_linkedinfieldmappingid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyncrm_linkedinfieldmapping_task`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyncrm_linkedinform_Tasks"></a> msdyncrm_linkedinform_Tasks

One-To-Many Relationship: [msdyncrm_linkedinform msdyncrm_linkedinform_Tasks](msdyncrm_linkedinform.md#BKMK_msdyncrm_linkedinform_Tasks)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyncrm_linkedinform`|
|ReferencedAttribute|`msdyncrm_linkedinformid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyncrm_linkedinform_task`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyncrm_linkedinformanswer_Tasks"></a> msdyncrm_linkedinformanswer_Tasks

One-To-Many Relationship: [msdyncrm_linkedinformanswer msdyncrm_linkedinformanswer_Tasks](msdyncrm_linkedinformanswer.md#BKMK_msdyncrm_linkedinformanswer_Tasks)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyncrm_linkedinformanswer`|
|ReferencedAttribute|`msdyncrm_linkedinformanswerid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyncrm_linkedinformanswer_task`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyncrm_linkedinformquestion_Tasks"></a> msdyncrm_linkedinformquestion_Tasks

One-To-Many Relationship: [msdyncrm_linkedinformquestion msdyncrm_linkedinformquestion_Tasks](msdyncrm_linkedinformquestion.md#BKMK_msdyncrm_linkedinformquestion_Tasks)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyncrm_linkedinformquestion`|
|ReferencedAttribute|`msdyncrm_linkedinformquestionid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyncrm_linkedinformquestion_task`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyncrm_linkedinformsubmission_Tasks"></a> msdyncrm_linkedinformsubmission_Tasks

One-To-Many Relationship: [msdyncrm_linkedinformsubmission msdyncrm_linkedinformsubmission_Tasks](msdyncrm_linkedinformsubmission.md#BKMK_msdyncrm_linkedinformsubmission_Tasks)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyncrm_linkedinformsubmission`|
|ReferencedAttribute|`msdyncrm_linkedinformsubmissionid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyncrm_linkedinformsubmission_task`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyncrm_linkedinleadmatchingstrategy_Tasks"></a> msdyncrm_linkedinleadmatchingstrategy_Tasks

One-To-Many Relationship: [msdyncrm_linkedinleadmatchingstrategy msdyncrm_linkedinleadmatchingstrategy_Tasks](msdyncrm_linkedinleadmatchingstrategy.md#BKMK_msdyncrm_linkedinleadmatchingstrategy_Tasks)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyncrm_linkedinleadmatchingstrategy`|
|ReferencedAttribute|`msdyncrm_linkedinleadmatchingstrategyid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyncrm_linkedinleadmatchingstrategy_task`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyncrm_linkedinuserprofile_Tasks"></a> msdyncrm_linkedinuserprofile_Tasks

One-To-Many Relationship: [msdyncrm_linkedinuserprofile msdyncrm_linkedinuserprofile_Tasks](msdyncrm_linkedinuserprofile.md#BKMK_msdyncrm_linkedinuserprofile_Tasks)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyncrm_linkedinuserprofile`|
|ReferencedAttribute|`msdyncrm_linkedinuserprofileid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyncrm_linkedinuserprofile_task`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyncrm_marketingdynamiccontentmetadata_Tasks"></a> msdyncrm_marketingdynamiccontentmetadata_Tasks

One-To-Many Relationship: [msdyncrm_marketingdynamiccontentmetadata msdyncrm_marketingdynamiccontentmetadata_Tasks](msdyncrm_marketingdynamiccontentmetadata.md#BKMK_msdyncrm_marketingdynamiccontentmetadata_Tasks)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyncrm_marketingdynamiccontentmetadata`|
|ReferencedAttribute|`msdyncrm_marketingdynamiccontentmetadataid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyncrm_marketingdynamiccontentmetadata_task`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyncrm_marketingemaildynamiccontentmetadata_Tasks"></a> msdyncrm_marketingemaildynamiccontentmetadata_Tasks

One-To-Many Relationship: [msdyncrm_marketingemaildynamiccontentmetadata msdyncrm_marketingemaildynamiccontentmetadata_Tasks](msdyncrm_marketingemaildynamiccontentmetadata.md#BKMK_msdyncrm_marketingemaildynamiccontentmetadata_Tasks)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyncrm_marketingemaildynamiccontentmetadata`|
|ReferencedAttribute|`msdyncrm_marketingemaildynamiccontentmetadataid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyncrm_marketingemaildynamiccontentmetadata_task`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyncrm_marketingemailtestsend_Tasks"></a> msdyncrm_marketingemailtestsend_Tasks

One-To-Many Relationship: [msdyncrm_marketingemailtestsend msdyncrm_marketingemailtestsend_Tasks](msdyncrm_marketingemailtestsend.md#BKMK_msdyncrm_marketingemailtestsend_Tasks)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyncrm_marketingemailtestsend`|
|ReferencedAttribute|`msdyncrm_marketingemailtestsendid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyncrm_marketingemailtestsend_task`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyncrm_migration_Tasks"></a> msdyncrm_migration_Tasks

One-To-Many Relationship: [msdyncrm_migration msdyncrm_migration_Tasks](msdyncrm_migration.md#BKMK_msdyncrm_migration_Tasks)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyncrm_migration`|
|ReferencedAttribute|`msdyncrm_migrationid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyncrm_migration_task`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyncrm_msdyncrm_customerjourneyiteration_task"></a> msdyncrm_msdyncrm_customerjourneyiteration_task

One-To-Many Relationship: [msdyncrm_customerjourneyiteration msdyncrm_msdyncrm_customerjourneyiteration_task](msdyncrm_customerjourneyiteration.md#BKMK_msdyncrm_msdyncrm_customerjourneyiteration_task)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyncrm_customerjourneyiteration`|
|ReferencedAttribute|`msdyncrm_customerjourneyiterationid`|
|ReferencingAttribute|`msdyncrm_associatedcustomerjourneyiteration`|
|ReferencingEntityNavigationPropertyName|`msdyncrm_associatedcustomerjourneyiteration_Task`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyncrm_uicconfig_Tasks"></a> msdyncrm_uicconfig_Tasks

One-To-Many Relationship: [msdyncrm_uicconfig msdyncrm_uicconfig_Tasks](msdyncrm_uicconfig.md#BKMK_msdyncrm_uicconfig_Tasks)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyncrm_uicconfig`|
|ReferencedAttribute|`msdyncrm_uicconfigid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyncrm_uicconfig_task`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdynmkt_task_JourneyId_msdynmkt_journey"></a> msdynmkt_task_JourneyId_msdynmkt_journey

One-To-Many Relationship: [msdynmkt_journey msdynmkt_task_JourneyId_msdynmkt_journey](msdynmkt_journey.md#BKMK_msdynmkt_task_JourneyId_msdynmkt_journey)

|Property|Value|
|---|---|
|ReferencedEntity|`msdynmkt_journey`|
|ReferencedAttribute|`msdynmkt_journeyid`|
|ReferencingAttribute|`msdynmkt_journeyid`|
|ReferencingEntityNavigationPropertyName|`msdynmkt_JourneyId_Task`|
|IsHierarchical||
|CascadeConfiguration|Archive: `RemoveLink`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msevtmgt_checkin_Tasks"></a> msevtmgt_checkin_Tasks

One-To-Many Relationship: [msevtmgt_checkin msevtmgt_checkin_Tasks](msevtmgt_checkin.md#BKMK_msevtmgt_checkin_Tasks)

|Property|Value|
|---|---|
|ReferencedEntity|`msevtmgt_checkin`|
|ReferencedAttribute|`msevtmgt_checkinid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msevtmgt_checkin_task`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msevtmgt_event_Tasks"></a> msevtmgt_event_Tasks

One-To-Many Relationship: [msevtmgt_event msevtmgt_event_Tasks](msevtmgt_event.md#BKMK_msevtmgt_event_Tasks)

|Property|Value|
|---|---|
|ReferencedEntity|`msevtmgt_event`|
|ReferencedAttribute|`msevtmgt_eventid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msevtmgt_event_task`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msevtmgt_eventpurchase_Tasks"></a> msevtmgt_eventpurchase_Tasks

One-To-Many Relationship: [msevtmgt_eventpurchase msevtmgt_eventpurchase_Tasks](msevtmgt_eventpurchase.md#BKMK_msevtmgt_eventpurchase_Tasks)

|Property|Value|
|---|---|
|ReferencedEntity|`msevtmgt_eventpurchase`|
|ReferencedAttribute|`msevtmgt_eventpurchaseid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msevtmgt_eventpurchase_task`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msevtmgt_eventpurchaseattendee_Tasks"></a> msevtmgt_eventpurchaseattendee_Tasks

One-To-Many Relationship: [msevtmgt_eventpurchaseattendee msevtmgt_eventpurchaseattendee_Tasks](msevtmgt_eventpurchaseattendee.md#BKMK_msevtmgt_eventpurchaseattendee_Tasks)

|Property|Value|
|---|---|
|ReferencedEntity|`msevtmgt_eventpurchaseattendee`|
|ReferencedAttribute|`msevtmgt_eventpurchaseattendeeid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msevtmgt_eventpurchaseattendee_task`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msevtmgt_eventpurchasepass_Tasks"></a> msevtmgt_eventpurchasepass_Tasks

One-To-Many Relationship: [msevtmgt_eventpurchasepass msevtmgt_eventpurchasepass_Tasks](msevtmgt_eventpurchasepass.md#BKMK_msevtmgt_eventpurchasepass_Tasks)

|Property|Value|
|---|---|
|ReferencedEntity|`msevtmgt_eventpurchasepass`|
|ReferencedAttribute|`msevtmgt_eventpurchasepassid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msevtmgt_eventpurchasepass_task`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msevtmgt_eventregistration_Tasks"></a> msevtmgt_eventregistration_Tasks

One-To-Many Relationship: [msevtmgt_eventregistration msevtmgt_eventregistration_Tasks](msevtmgt_eventregistration.md#BKMK_msevtmgt_eventregistration_Tasks)

|Property|Value|
|---|---|
|ReferencedEntity|`msevtmgt_eventregistration`|
|ReferencedAttribute|`msevtmgt_eventregistrationid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msevtmgt_eventregistration_task`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msevtmgt_hotel_Tasks"></a> msevtmgt_hotel_Tasks

One-To-Many Relationship: [msevtmgt_hotel msevtmgt_hotel_Tasks](msevtmgt_hotel.md#BKMK_msevtmgt_hotel_Tasks)

|Property|Value|
|---|---|
|ReferencedEntity|`msevtmgt_hotel`|
|ReferencedAttribute|`msevtmgt_hotelid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msevtmgt_hotel_task`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msevtmgt_hotelroomallocation_Tasks"></a> msevtmgt_hotelroomallocation_Tasks

One-To-Many Relationship: [msevtmgt_hotelroomallocation msevtmgt_hotelroomallocation_Tasks](msevtmgt_hotelroomallocation.md#BKMK_msevtmgt_hotelroomallocation_Tasks)

|Property|Value|
|---|---|
|ReferencedEntity|`msevtmgt_hotelroomallocation`|
|ReferencedAttribute|`msevtmgt_hotelroomallocationid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msevtmgt_hotelroomallocation_task`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msevtmgt_hotelroomreservation_Tasks"></a> msevtmgt_hotelroomreservation_Tasks

One-To-Many Relationship: [msevtmgt_hotelroomreservation msevtmgt_hotelroomreservation_Tasks](msevtmgt_hotelroomreservation.md#BKMK_msevtmgt_hotelroomreservation_Tasks)

|Property|Value|
|---|---|
|ReferencedEntity|`msevtmgt_hotelroomreservation`|
|ReferencedAttribute|`msevtmgt_hotelroomreservationid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msevtmgt_hotelroomreservation_task`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msevtmgt_layout_Tasks"></a> msevtmgt_layout_Tasks

One-To-Many Relationship: [msevtmgt_layout msevtmgt_layout_Tasks](msevtmgt_layout.md#BKMK_msevtmgt_layout_Tasks)

|Property|Value|
|---|---|
|ReferencedEntity|`msevtmgt_layout`|
|ReferencedAttribute|`msevtmgt_layoutid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msevtmgt_layout_task`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msevtmgt_room_Tasks"></a> msevtmgt_room_Tasks

One-To-Many Relationship: [msevtmgt_room msevtmgt_room_Tasks](msevtmgt_room.md#BKMK_msevtmgt_room_Tasks)

|Property|Value|
|---|---|
|ReferencedEntity|`msevtmgt_room`|
|ReferencedAttribute|`msevtmgt_roomid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msevtmgt_room_task`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msevtmgt_session_Tasks"></a> msevtmgt_session_Tasks

One-To-Many Relationship: [msevtmgt_session msevtmgt_session_Tasks](msevtmgt_session.md#BKMK_msevtmgt_session_Tasks)

|Property|Value|
|---|---|
|ReferencedEntity|`msevtmgt_session`|
|ReferencedAttribute|`msevtmgt_sessionid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msevtmgt_session_task`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msevtmgt_sessionregistration_Tasks"></a> msevtmgt_sessionregistration_Tasks

One-To-Many Relationship: [msevtmgt_sessionregistration msevtmgt_sessionregistration_Tasks](msevtmgt_sessionregistration.md#BKMK_msevtmgt_sessionregistration_Tasks)

|Property|Value|
|---|---|
|ReferencedEntity|`msevtmgt_sessionregistration`|
|ReferencedAttribute|`msevtmgt_sessionregistrationid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msevtmgt_sessionregistration_task`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msevtmgt_sessiontrack_Tasks"></a> msevtmgt_sessiontrack_Tasks

One-To-Many Relationship: [msevtmgt_sessiontrack msevtmgt_sessiontrack_Tasks](msevtmgt_sessiontrack.md#BKMK_msevtmgt_sessiontrack_Tasks)

|Property|Value|
|---|---|
|ReferencedEntity|`msevtmgt_sessiontrack`|
|ReferencedAttribute|`msevtmgt_sessiontrackid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msevtmgt_sessiontrack_task`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msevtmgt_speaker_Tasks"></a> msevtmgt_speaker_Tasks

One-To-Many Relationship: [msevtmgt_speaker msevtmgt_speaker_Tasks](msevtmgt_speaker.md#BKMK_msevtmgt_speaker_Tasks)

|Property|Value|
|---|---|
|ReferencedEntity|`msevtmgt_speaker`|
|ReferencedAttribute|`msevtmgt_speakerid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msevtmgt_speaker_task`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msevtmgt_speakerengagement_Tasks"></a> msevtmgt_speakerengagement_Tasks

One-To-Many Relationship: [msevtmgt_speakerengagement msevtmgt_speakerengagement_Tasks](msevtmgt_speakerengagement.md#BKMK_msevtmgt_speakerengagement_Tasks)

|Property|Value|
|---|---|
|ReferencedEntity|`msevtmgt_speakerengagement`|
|ReferencedAttribute|`msevtmgt_speakerengagementid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msevtmgt_speakerengagement_task`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msevtmgt_sponsorablearticle_Tasks"></a> msevtmgt_sponsorablearticle_Tasks

One-To-Many Relationship: [msevtmgt_sponsorablearticle msevtmgt_sponsorablearticle_Tasks](msevtmgt_sponsorablearticle.md#BKMK_msevtmgt_sponsorablearticle_Tasks)

|Property|Value|
|---|---|
|ReferencedEntity|`msevtmgt_sponsorablearticle`|
|ReferencedAttribute|`msevtmgt_sponsorablearticleid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msevtmgt_sponsorablearticle_task`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msevtmgt_sponsorship_Tasks"></a> msevtmgt_sponsorship_Tasks

One-To-Many Relationship: [msevtmgt_sponsorship msevtmgt_sponsorship_Tasks](msevtmgt_sponsorship.md#BKMK_msevtmgt_sponsorship_Tasks)

|Property|Value|
|---|---|
|ReferencedEntity|`msevtmgt_sponsorship`|
|ReferencedAttribute|`msevtmgt_sponsorshipid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msevtmgt_sponsorship_task`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msevtmgt_venue_Tasks"></a> msevtmgt_venue_Tasks

One-To-Many Relationship: [msevtmgt_venue msevtmgt_venue_Tasks](msevtmgt_venue.md#BKMK_msevtmgt_venue_Tasks)

|Property|Value|
|---|---|
|ReferencedEntity|`msevtmgt_venue`|
|ReferencedAttribute|`msevtmgt_venueid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msevtmgt_venue_task`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msevtmgt_webinarconfiguration_Tasks"></a> msevtmgt_webinarconfiguration_Tasks

One-To-Many Relationship: [msevtmgt_webinarconfiguration msevtmgt_webinarconfiguration_Tasks](msevtmgt_webinarconfiguration.md#BKMK_msevtmgt_webinarconfiguration_Tasks)

|Property|Value|
|---|---|
|ReferencedEntity|`msevtmgt_webinarconfiguration`|
|ReferencedAttribute|`msevtmgt_webinarconfigurationid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msevtmgt_webinarconfiguration_task`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msevtmgt_webinarprovider_Tasks"></a> msevtmgt_webinarprovider_Tasks

One-To-Many Relationship: [msevtmgt_webinarprovider msevtmgt_webinarprovider_Tasks](msevtmgt_webinarprovider.md#BKMK_msevtmgt_webinarprovider_Tasks)

|Property|Value|
|---|---|
|ReferencedEntity|`msevtmgt_webinarprovider`|
|ReferencedAttribute|`msevtmgt_webinarproviderid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msevtmgt_webinarprovider_task`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

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

[Dataverse table/entity reference](../about-entity-reference.md)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   
<xref:Microsoft.Dynamics.CRM.task?displayProperty=fullName>
