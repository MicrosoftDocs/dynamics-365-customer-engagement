---
title: "Activity (ActivityPointer) table/entity reference (Microsoft Dynamics 365 Field Service)"
description: "Includes schema information and supported messages for the Activity (ActivityPointer) table/entity with Microsoft Dynamics 365 Field Service."
ms.date: 07.24.2024
ms.service: powerapps
ms.topic: reference
author: m-hartmann
ms.author: mhart
search.audienceType: 
  - developer
---

# Activity (ActivityPointer) table/entity reference

Task performed, or to be performed, by a user. An activity is any action for which an entry can be made on a calendar.

> [!NOTE]
> The Microsoft Dynamics 365 Field Service Activity (ActivityPointer) table extends the [Microsoft Dataverse Activity (ActivityPointer) table](/power-apps/developer/data-platform/reference/entities/activitypointer).



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

Microsoft Dynamics 365 Field Service modifies the definition of columns/attributes defined in other solutions. Listed by **SchemaName**.

- [allparties](#BKMK_allparties)
- [Community](#BKMK_Community)
- [RegardingObjectId](#BKMK_RegardingObjectId)

### <a name="BKMK_allparties"></a> allparties

Changes from [allparties (Microsoft Dataverse)](/power-apps/developer/data-platform/reference/entities/activitypointer#BKMK_allparties)

|Property|Value|
|---|---|
|Targets|equipment|


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
|Targets|adx_ad|


## Many-to-One relationships

These relationships are many-to-one. Listed by **SchemaName**.

- [adx_ad_ActivityPointers](#BKMK_adx_ad_ActivityPointers)
- [adx_adplacement_ActivityPointers](#BKMK_adx_adplacement_ActivityPointers)
- [adx_casedeflection_ActivityPointers](#BKMK_adx_casedeflection_ActivityPointers)
- [adx_communityforumaccesspermission_ActivityPointers](#BKMK_adx_communityforumaccesspermission_ActivityPointers)
- [adx_communityforumalert_ActivityPointers](#BKMK_adx_communityforumalert_ActivityPointers)
- [adx_contentaccesslevel_ActivityPointers](#BKMK_adx_contentaccesslevel_ActivityPointers)
- [adx_poll_ActivityPointers](#BKMK_adx_poll_ActivityPointers)
- [adx_polloption_ActivityPointers](#BKMK_adx_polloption_ActivityPointers)
- [adx_pollplacement_ActivityPointers](#BKMK_adx_pollplacement_ActivityPointers)
- [adx_pollsubmission_ActivityPointers](#BKMK_adx_pollsubmission_ActivityPointers)
- [adx_publishingstatetransitionrule_ActivityPointers](#BKMK_adx_publishingstatetransitionrule_ActivityPointers)
- [adx_redirect_ActivityPointers](#BKMK_adx_redirect_ActivityPointers)
- [adx_shortcut_ActivityPointers](#BKMK_adx_shortcut_ActivityPointers)
- [adx_webpage_ActivityPointers](#BKMK_adx_webpage_ActivityPointers)
- [adx_website_ActivityPointers](#BKMK_adx_website_ActivityPointers)
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
- [msdyn_agreement_ActivityPointers](#BKMK_msdyn_agreement_ActivityPointers)
- [msdyn_agreementbookingdate_ActivityPointers](#BKMK_msdyn_agreementbookingdate_ActivityPointers)
- [msdyn_agreementbookingincident_ActivityPointers](#BKMK_msdyn_agreementbookingincident_ActivityPointers)
- [msdyn_agreementbookingproduct_ActivityPointers](#BKMK_msdyn_agreementbookingproduct_ActivityPointers)
- [msdyn_agreementbookingservice_ActivityPointers](#BKMK_msdyn_agreementbookingservice_ActivityPointers)
- [msdyn_agreementbookingservicetask_ActivityPointers](#BKMK_msdyn_agreementbookingservicetask_ActivityPointers)
- [msdyn_agreementbookingsetup_ActivityPointers](#BKMK_msdyn_agreementbookingsetup_ActivityPointers)
- [msdyn_agreementinvoicedate_ActivityPointers](#BKMK_msdyn_agreementinvoicedate_ActivityPointers)
- [msdyn_agreementinvoiceproduct_ActivityPointers](#BKMK_msdyn_agreementinvoiceproduct_ActivityPointers)
- [msdyn_agreementinvoicesetup_ActivityPointers](#BKMK_msdyn_agreementinvoicesetup_ActivityPointers)
- [msdyn_bookingalertstatus_ActivityPointers](#BKMK_msdyn_bookingalertstatus_ActivityPointers)
- [msdyn_bookingrule_ActivityPointers](#BKMK_msdyn_bookingrule_ActivityPointers)
- [msdyn_bookingtimestamp_ActivityPointers](#BKMK_msdyn_bookingtimestamp_ActivityPointers)
- [msdyn_customerasset_ActivityPointers](#BKMK_msdyn_customerasset_ActivityPointers)
- [msdyn_fieldservicesetting_ActivityPointers](#BKMK_msdyn_fieldservicesetting_ActivityPointers)
- [msdyn_incidenttypecharacteristic_ActivityPointers](#BKMK_msdyn_incidenttypecharacteristic_ActivityPointers)
- [msdyn_incidenttypeproduct_ActivityPointers](#BKMK_msdyn_incidenttypeproduct_ActivityPointers)
- [msdyn_incidenttypeservice_ActivityPointers](#BKMK_msdyn_incidenttypeservice_ActivityPointers)
- [msdyn_inventoryadjustment_ActivityPointers](#BKMK_msdyn_inventoryadjustment_ActivityPointers)
- [msdyn_inventoryadjustmentproduct_ActivityPointers](#BKMK_msdyn_inventoryadjustmentproduct_ActivityPointers)
- [msdyn_inventoryjournal_ActivityPointers](#BKMK_msdyn_inventoryjournal_ActivityPointers)
- [msdyn_inventorytransfer_ActivityPointers](#BKMK_msdyn_inventorytransfer_ActivityPointers)
- [msdyn_payment_ActivityPointers](#BKMK_msdyn_payment_ActivityPointers)
- [msdyn_paymentdetail_ActivityPointers](#BKMK_msdyn_paymentdetail_ActivityPointers)
- [msdyn_paymentmethod_ActivityPointers](#BKMK_msdyn_paymentmethod_ActivityPointers)
- [msdyn_paymentterm_ActivityPointers](#BKMK_msdyn_paymentterm_ActivityPointers)
- [msdyn_playbookinstance_ActivityPointers](#BKMK_msdyn_playbookinstance_ActivityPointers)
- [msdyn_postalbum_ActivityPointers](#BKMK_msdyn_postalbum_ActivityPointers)
- [msdyn_postalcode_ActivityPointers](#BKMK_msdyn_postalcode_ActivityPointers)
- [msdyn_productinventory_ActivityPointers](#BKMK_msdyn_productinventory_ActivityPointers)
- [msdyn_purchaseorder_ActivityPointers](#BKMK_msdyn_purchaseorder_ActivityPointers)
- [msdyn_purchaseorderbill_ActivityPointers](#BKMK_msdyn_purchaseorderbill_ActivityPointers)
- [msdyn_purchaseorderproduct_ActivityPointers](#BKMK_msdyn_purchaseorderproduct_ActivityPointers)
- [msdyn_purchaseorderreceipt_ActivityPointers](#BKMK_msdyn_purchaseorderreceipt_ActivityPointers)
- [msdyn_purchaseorderreceiptproduct_ActivityPointers](#BKMK_msdyn_purchaseorderreceiptproduct_ActivityPointers)
- [msdyn_purchaseordersubstatus_ActivityPointers](#BKMK_msdyn_purchaseordersubstatus_ActivityPointers)
- [msdyn_quotebookingincident_ActivityPointers](#BKMK_msdyn_quotebookingincident_ActivityPointers)
- [msdyn_quotebookingproduct_ActivityPointers](#BKMK_msdyn_quotebookingproduct_ActivityPointers)
- [msdyn_quotebookingservice_ActivityPointers](#BKMK_msdyn_quotebookingservice_ActivityPointers)
- [msdyn_quotebookingservicetask_ActivityPointers](#BKMK_msdyn_quotebookingservicetask_ActivityPointers)
- [msdyn_resourceterritory_ActivityPointers](#BKMK_msdyn_resourceterritory_ActivityPointers)
- [msdyn_rma_ActivityPointers](#BKMK_msdyn_rma_ActivityPointers)
- [msdyn_rmaproduct_ActivityPointers](#BKMK_msdyn_rmaproduct_ActivityPointers)
- [msdyn_rmareceipt_ActivityPointers](#BKMK_msdyn_rmareceipt_ActivityPointers)
- [msdyn_rmareceiptproduct_ActivityPointers](#BKMK_msdyn_rmareceiptproduct_ActivityPointers)
- [msdyn_rmasubstatus_ActivityPointers](#BKMK_msdyn_rmasubstatus_ActivityPointers)
- [msdyn_rtv_ActivityPointers](#BKMK_msdyn_rtv_ActivityPointers)
- [msdyn_rtvproduct_ActivityPointers](#BKMK_msdyn_rtvproduct_ActivityPointers)
- [msdyn_rtvsubstatus_ActivityPointers](#BKMK_msdyn_rtvsubstatus_ActivityPointers)
- [msdyn_salessuggestion_ActivityPointers](#BKMK_msdyn_salessuggestion_ActivityPointers)
- [msdyn_shipvia_ActivityPointers](#BKMK_msdyn_shipvia_ActivityPointers)
- [msdyn_swarm_ActivityPointers](#BKMK_msdyn_swarm_ActivityPointers)
- [msdyn_systemuserschedulersetting_ActivityPointers](#BKMK_msdyn_systemuserschedulersetting_ActivityPointers)
- [msdyn_timegroup_ActivityPointers](#BKMK_msdyn_timegroup_ActivityPointers)
- [msdyn_timegroupdetail_ActivityPointers](#BKMK_msdyn_timegroupdetail_ActivityPointers)
- [msdyn_timeoffrequest_ActivityPointers](#BKMK_msdyn_timeoffrequest_ActivityPointers)
- [msdyn_warehouse_ActivityPointers](#BKMK_msdyn_warehouse_ActivityPointers)
- [msdyn_workorder_ActivityPointers](#BKMK_msdyn_workorder_ActivityPointers)
- [msdyn_workordercharacteristic_ActivityPointers](#BKMK_msdyn_workordercharacteristic_ActivityPointers)
- [msdyn_workorderincident_ActivityPointers](#BKMK_msdyn_workorderincident_ActivityPointers)
- [msdyn_workorderproduct_ActivityPointers](#BKMK_msdyn_workorderproduct_ActivityPointers)
- [msdyn_workorderresourcerestriction_ActivityPointers](#BKMK_msdyn_workorderresourcerestriction_ActivityPointers)
- [msdyn_workorderservice_ActivityPointers](#BKMK_msdyn_workorderservice_ActivityPointers)
- [msdyn_workorderservicetask_ActivityPointers](#BKMK_msdyn_workorderservicetask_ActivityPointers)
- [msdyncrm_contentsettings_ActivityPointers](#BKMK_msdyncrm_contentsettings_ActivityPointers)
- [msdyncrm_customerjourney_ActivityPointers](#BKMK_msdyncrm_customerjourney_ActivityPointers)
- [msdyncrm_leadscoremodel_ActivityPointers](#BKMK_msdyncrm_leadscoremodel_ActivityPointers)
- [msdyncrm_linkedinaccount_ActivityPointers](#BKMK_msdyncrm_linkedinaccount_ActivityPointers)
- [msdyncrm_linkedinactivity_ActivityPointers](#BKMK_msdyncrm_linkedinactivity_ActivityPointers)
- [msdyncrm_linkedinfieldmapping_ActivityPointers](#BKMK_msdyncrm_linkedinfieldmapping_ActivityPointers)
- [msdyncrm_linkedinform_ActivityPointers](#BKMK_msdyncrm_linkedinform_ActivityPointers)
- [msdyncrm_linkedinformanswer_ActivityPointers](#BKMK_msdyncrm_linkedinformanswer_ActivityPointers)
- [msdyncrm_linkedinformquestion_ActivityPointers](#BKMK_msdyncrm_linkedinformquestion_ActivityPointers)
- [msdyncrm_linkedinformsubmission_ActivityPointers](#BKMK_msdyncrm_linkedinformsubmission_ActivityPointers)
- [msdyncrm_linkedinleadmatchingstrategy_ActivityPointers](#BKMK_msdyncrm_linkedinleadmatchingstrategy_ActivityPointers)
- [msdyncrm_linkedinuserprofile_ActivityPointers](#BKMK_msdyncrm_linkedinuserprofile_ActivityPointers)
- [msdyncrm_marketingdynamiccontentmetadata_ActivityPointers](#BKMK_msdyncrm_marketingdynamiccontentmetadata_ActivityPointers)
- [msdyncrm_marketingemaildynamiccontentmetadata_ActivityPointers](#BKMK_msdyncrm_marketingemaildynamiccontentmetadata_ActivityPointers)
- [msdyncrm_marketingemailtestsend_ActivityPointers](#BKMK_msdyncrm_marketingemailtestsend_ActivityPointers)
- [msdyncrm_migration_ActivityPointers](#BKMK_msdyncrm_migration_ActivityPointers)
- [msdyncrm_uicconfig_ActivityPointers](#BKMK_msdyncrm_uicconfig_ActivityPointers)
- [msevtmgt_checkin_ActivityPointers](#BKMK_msevtmgt_checkin_ActivityPointers)
- [msevtmgt_event_ActivityPointers](#BKMK_msevtmgt_event_ActivityPointers)
- [msevtmgt_eventpurchase_ActivityPointers](#BKMK_msevtmgt_eventpurchase_ActivityPointers)
- [msevtmgt_eventpurchaseattendee_ActivityPointers](#BKMK_msevtmgt_eventpurchaseattendee_ActivityPointers)
- [msevtmgt_eventpurchasepass_ActivityPointers](#BKMK_msevtmgt_eventpurchasepass_ActivityPointers)
- [msevtmgt_eventregistration_ActivityPointers](#BKMK_msevtmgt_eventregistration_ActivityPointers)
- [msevtmgt_hotel_ActivityPointers](#BKMK_msevtmgt_hotel_ActivityPointers)
- [msevtmgt_hotelroomallocation_ActivityPointers](#BKMK_msevtmgt_hotelroomallocation_ActivityPointers)
- [msevtmgt_hotelroomreservation_ActivityPointers](#BKMK_msevtmgt_hotelroomreservation_ActivityPointers)
- [msevtmgt_layout_ActivityPointers](#BKMK_msevtmgt_layout_ActivityPointers)
- [msevtmgt_room_ActivityPointers](#BKMK_msevtmgt_room_ActivityPointers)
- [msevtmgt_session_ActivityPointers](#BKMK_msevtmgt_session_ActivityPointers)
- [msevtmgt_sessionregistration_ActivityPointers](#BKMK_msevtmgt_sessionregistration_ActivityPointers)
- [msevtmgt_sessiontrack_ActivityPointers](#BKMK_msevtmgt_sessiontrack_ActivityPointers)
- [msevtmgt_speaker_ActivityPointers](#BKMK_msevtmgt_speaker_ActivityPointers)
- [msevtmgt_speakerengagement_ActivityPointers](#BKMK_msevtmgt_speakerengagement_ActivityPointers)
- [msevtmgt_sponsorablearticle_ActivityPointers](#BKMK_msevtmgt_sponsorablearticle_ActivityPointers)
- [msevtmgt_sponsorship_ActivityPointers](#BKMK_msevtmgt_sponsorship_ActivityPointers)
- [msevtmgt_venue_ActivityPointers](#BKMK_msevtmgt_venue_ActivityPointers)
- [msevtmgt_webinarconfiguration_ActivityPointers](#BKMK_msevtmgt_webinarconfiguration_ActivityPointers)
- [msevtmgt_webinarprovider_ActivityPointers](#BKMK_msevtmgt_webinarprovider_ActivityPointers)
- [Opportunity_ActivityPointers](#BKMK_Opportunity_ActivityPointers)
- [Quote_ActivityPointers](#BKMK_Quote_ActivityPointers)
- [SalesOrder_ActivityPointers](#BKMK_SalesOrder_ActivityPointers)
- [service_activity_pointers](#BKMK_service_activity_pointers)
- [site_ActivityPointers](#BKMK_site_ActivityPointers)

### <a name="BKMK_adx_ad_ActivityPointers"></a> adx_ad_ActivityPointers

One-To-Many Relationship: [adx_ad adx_ad_ActivityPointers](adx_ad.md#BKMK_adx_ad_ActivityPointers)

|Property|Value|
|---|---|
|ReferencedEntity|`adx_ad`|
|ReferencedAttribute|`adx_adid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_adx_ad`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_adx_adplacement_ActivityPointers"></a> adx_adplacement_ActivityPointers

One-To-Many Relationship: [adx_adplacement adx_adplacement_ActivityPointers](adx_adplacement.md#BKMK_adx_adplacement_ActivityPointers)

|Property|Value|
|---|---|
|ReferencedEntity|`adx_adplacement`|
|ReferencedAttribute|`adx_adplacementid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_adx_adplacement`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_adx_casedeflection_ActivityPointers"></a> adx_casedeflection_ActivityPointers

One-To-Many Relationship: [adx_casedeflection adx_casedeflection_ActivityPointers](adx_casedeflection.md#BKMK_adx_casedeflection_ActivityPointers)

|Property|Value|
|---|---|
|ReferencedEntity|`adx_casedeflection`|
|ReferencedAttribute|`adx_casedeflectionid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_adx_casedeflection`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_adx_communityforumaccesspermission_ActivityPointers"></a> adx_communityforumaccesspermission_ActivityPointers

One-To-Many Relationship: [adx_communityforumaccesspermission adx_communityforumaccesspermission_ActivityPointers](adx_communityforumaccesspermission.md#BKMK_adx_communityforumaccesspermission_ActivityPointers)

|Property|Value|
|---|---|
|ReferencedEntity|`adx_communityforumaccesspermission`|
|ReferencedAttribute|`adx_communityforumaccesspermissionid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_adx_communityforumaccesspermission`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_adx_communityforumalert_ActivityPointers"></a> adx_communityforumalert_ActivityPointers

One-To-Many Relationship: [adx_communityforumalert adx_communityforumalert_ActivityPointers](adx_communityforumalert.md#BKMK_adx_communityforumalert_ActivityPointers)

|Property|Value|
|---|---|
|ReferencedEntity|`adx_communityforumalert`|
|ReferencedAttribute|`adx_communityforumalertid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_adx_communityforumalert`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_adx_contentaccesslevel_ActivityPointers"></a> adx_contentaccesslevel_ActivityPointers

One-To-Many Relationship: [adx_contentaccesslevel adx_contentaccesslevel_ActivityPointers](adx_contentaccesslevel.md#BKMK_adx_contentaccesslevel_ActivityPointers)

|Property|Value|
|---|---|
|ReferencedEntity|`adx_contentaccesslevel`|
|ReferencedAttribute|`adx_contentaccesslevelid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_adx_contentaccesslevel`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_adx_poll_ActivityPointers"></a> adx_poll_ActivityPointers

One-To-Many Relationship: [adx_poll adx_poll_ActivityPointers](adx_poll.md#BKMK_adx_poll_ActivityPointers)

|Property|Value|
|---|---|
|ReferencedEntity|`adx_poll`|
|ReferencedAttribute|`adx_pollid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_adx_poll`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_adx_polloption_ActivityPointers"></a> adx_polloption_ActivityPointers

One-To-Many Relationship: [adx_polloption adx_polloption_ActivityPointers](adx_polloption.md#BKMK_adx_polloption_ActivityPointers)

|Property|Value|
|---|---|
|ReferencedEntity|`adx_polloption`|
|ReferencedAttribute|`adx_polloptionid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_adx_polloption`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_adx_pollplacement_ActivityPointers"></a> adx_pollplacement_ActivityPointers

One-To-Many Relationship: [adx_pollplacement adx_pollplacement_ActivityPointers](adx_pollplacement.md#BKMK_adx_pollplacement_ActivityPointers)

|Property|Value|
|---|---|
|ReferencedEntity|`adx_pollplacement`|
|ReferencedAttribute|`adx_pollplacementid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_adx_pollplacement`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_adx_pollsubmission_ActivityPointers"></a> adx_pollsubmission_ActivityPointers

One-To-Many Relationship: [adx_pollsubmission adx_pollsubmission_ActivityPointers](adx_pollsubmission.md#BKMK_adx_pollsubmission_ActivityPointers)

|Property|Value|
|---|---|
|ReferencedEntity|`adx_pollsubmission`|
|ReferencedAttribute|`adx_pollsubmissionid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_adx_pollsubmission`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_adx_publishingstatetransitionrule_ActivityPointers"></a> adx_publishingstatetransitionrule_ActivityPointers

One-To-Many Relationship: [adx_publishingstatetransitionrule adx_publishingstatetransitionrule_ActivityPointers](adx_publishingstatetransitionrule.md#BKMK_adx_publishingstatetransitionrule_ActivityPointers)

|Property|Value|
|---|---|
|ReferencedEntity|`adx_publishingstatetransitionrule`|
|ReferencedAttribute|`adx_publishingstatetransitionruleid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_adx_publishingstatetransitionrule`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_adx_redirect_ActivityPointers"></a> adx_redirect_ActivityPointers

One-To-Many Relationship: [adx_redirect adx_redirect_ActivityPointers](adx_redirect.md#BKMK_adx_redirect_ActivityPointers)

|Property|Value|
|---|---|
|ReferencedEntity|`adx_redirect`|
|ReferencedAttribute|`adx_redirectid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_adx_redirect`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_adx_shortcut_ActivityPointers"></a> adx_shortcut_ActivityPointers

One-To-Many Relationship: [adx_shortcut adx_shortcut_ActivityPointers](adx_shortcut.md#BKMK_adx_shortcut_ActivityPointers)

|Property|Value|
|---|---|
|ReferencedEntity|`adx_shortcut`|
|ReferencedAttribute|`adx_shortcutid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_adx_shortcut`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_adx_webpage_ActivityPointers"></a> adx_webpage_ActivityPointers

One-To-Many Relationship: [adx_webpage adx_webpage_ActivityPointers](adx_webpage.md#BKMK_adx_webpage_ActivityPointers)

|Property|Value|
|---|---|
|ReferencedEntity|`adx_webpage`|
|ReferencedAttribute|`adx_webpageid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_adx_webpage`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_adx_website_ActivityPointers"></a> adx_website_ActivityPointers

One-To-Many Relationship: [adx_website adx_website_ActivityPointers](adx_website.md#BKMK_adx_website_ActivityPointers)

|Property|Value|
|---|---|
|ReferencedEntity|`adx_website`|
|ReferencedAttribute|`adx_websiteid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_adx_website`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

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

### <a name="BKMK_msdyn_agreement_ActivityPointers"></a> msdyn_agreement_ActivityPointers

One-To-Many Relationship: [msdyn_agreement msdyn_agreement_ActivityPointers](msdyn_agreement.md#BKMK_msdyn_agreement_ActivityPointers)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_agreement`|
|ReferencedAttribute|`msdyn_agreementid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_agreement`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_agreementbookingdate_ActivityPointers"></a> msdyn_agreementbookingdate_ActivityPointers

One-To-Many Relationship: [msdyn_agreementbookingdate msdyn_agreementbookingdate_ActivityPointers](msdyn_agreementbookingdate.md#BKMK_msdyn_agreementbookingdate_ActivityPointers)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_agreementbookingdate`|
|ReferencedAttribute|`msdyn_agreementbookingdateid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_agreementbookingdate`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_agreementbookingincident_ActivityPointers"></a> msdyn_agreementbookingincident_ActivityPointers

One-To-Many Relationship: [msdyn_agreementbookingincident msdyn_agreementbookingincident_ActivityPointers](msdyn_agreementbookingincident.md#BKMK_msdyn_agreementbookingincident_ActivityPointers)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_agreementbookingincident`|
|ReferencedAttribute|`msdyn_agreementbookingincidentid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_agreementbookingincident`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_agreementbookingproduct_ActivityPointers"></a> msdyn_agreementbookingproduct_ActivityPointers

One-To-Many Relationship: [msdyn_agreementbookingproduct msdyn_agreementbookingproduct_ActivityPointers](msdyn_agreementbookingproduct.md#BKMK_msdyn_agreementbookingproduct_ActivityPointers)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_agreementbookingproduct`|
|ReferencedAttribute|`msdyn_agreementbookingproductid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_agreementbookingproduct`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_agreementbookingservice_ActivityPointers"></a> msdyn_agreementbookingservice_ActivityPointers

One-To-Many Relationship: [msdyn_agreementbookingservice msdyn_agreementbookingservice_ActivityPointers](msdyn_agreementbookingservice.md#BKMK_msdyn_agreementbookingservice_ActivityPointers)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_agreementbookingservice`|
|ReferencedAttribute|`msdyn_agreementbookingserviceid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_agreementbookingservice`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_agreementbookingservicetask_ActivityPointers"></a> msdyn_agreementbookingservicetask_ActivityPointers

One-To-Many Relationship: [msdyn_agreementbookingservicetask msdyn_agreementbookingservicetask_ActivityPointers](msdyn_agreementbookingservicetask.md#BKMK_msdyn_agreementbookingservicetask_ActivityPointers)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_agreementbookingservicetask`|
|ReferencedAttribute|`msdyn_agreementbookingservicetaskid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_agreementbookingservicetask`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_agreementbookingsetup_ActivityPointers"></a> msdyn_agreementbookingsetup_ActivityPointers

One-To-Many Relationship: [msdyn_agreementbookingsetup msdyn_agreementbookingsetup_ActivityPointers](msdyn_agreementbookingsetup.md#BKMK_msdyn_agreementbookingsetup_ActivityPointers)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_agreementbookingsetup`|
|ReferencedAttribute|`msdyn_agreementbookingsetupid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_agreementbookingsetup`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_agreementinvoicedate_ActivityPointers"></a> msdyn_agreementinvoicedate_ActivityPointers

One-To-Many Relationship: [msdyn_agreementinvoicedate msdyn_agreementinvoicedate_ActivityPointers](msdyn_agreementinvoicedate.md#BKMK_msdyn_agreementinvoicedate_ActivityPointers)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_agreementinvoicedate`|
|ReferencedAttribute|`msdyn_agreementinvoicedateid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_agreementinvoicedate`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_agreementinvoiceproduct_ActivityPointers"></a> msdyn_agreementinvoiceproduct_ActivityPointers

One-To-Many Relationship: [msdyn_agreementinvoiceproduct msdyn_agreementinvoiceproduct_ActivityPointers](msdyn_agreementinvoiceproduct.md#BKMK_msdyn_agreementinvoiceproduct_ActivityPointers)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_agreementinvoiceproduct`|
|ReferencedAttribute|`msdyn_agreementinvoiceproductid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_agreementinvoiceproduct`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_agreementinvoicesetup_ActivityPointers"></a> msdyn_agreementinvoicesetup_ActivityPointers

One-To-Many Relationship: [msdyn_agreementinvoicesetup msdyn_agreementinvoicesetup_ActivityPointers](msdyn_agreementinvoicesetup.md#BKMK_msdyn_agreementinvoicesetup_ActivityPointers)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_agreementinvoicesetup`|
|ReferencedAttribute|`msdyn_agreementinvoicesetupid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_agreementinvoicesetup`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_bookingalertstatus_ActivityPointers"></a> msdyn_bookingalertstatus_ActivityPointers

One-To-Many Relationship: [msdyn_bookingalertstatus msdyn_bookingalertstatus_ActivityPointers](msdyn_bookingalertstatus.md#BKMK_msdyn_bookingalertstatus_ActivityPointers)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_bookingalertstatus`|
|ReferencedAttribute|`msdyn_bookingalertstatusid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_bookingalertstatus`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_bookingrule_ActivityPointers"></a> msdyn_bookingrule_ActivityPointers

One-To-Many Relationship: [msdyn_bookingrule msdyn_bookingrule_ActivityPointers](msdyn_bookingrule.md#BKMK_msdyn_bookingrule_ActivityPointers)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_bookingrule`|
|ReferencedAttribute|`msdyn_bookingruleid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_bookingrule`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_bookingtimestamp_ActivityPointers"></a> msdyn_bookingtimestamp_ActivityPointers

One-To-Many Relationship: [msdyn_bookingtimestamp msdyn_bookingtimestamp_ActivityPointers](msdyn_bookingtimestamp.md#BKMK_msdyn_bookingtimestamp_ActivityPointers)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_bookingtimestamp`|
|ReferencedAttribute|`msdyn_bookingtimestampid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_bookingtimestamp`|
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

### <a name="BKMK_msdyn_fieldservicesetting_ActivityPointers"></a> msdyn_fieldservicesetting_ActivityPointers

One-To-Many Relationship: [msdyn_fieldservicesetting msdyn_fieldservicesetting_ActivityPointers](msdyn_fieldservicesetting.md#BKMK_msdyn_fieldservicesetting_ActivityPointers)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_fieldservicesetting`|
|ReferencedAttribute|`msdyn_fieldservicesettingid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_fieldservicesetting`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_incidenttypecharacteristic_ActivityPointers"></a> msdyn_incidenttypecharacteristic_ActivityPointers

One-To-Many Relationship: [msdyn_incidenttypecharacteristic msdyn_incidenttypecharacteristic_ActivityPointers](msdyn_incidenttypecharacteristic.md#BKMK_msdyn_incidenttypecharacteristic_ActivityPointers)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_incidenttypecharacteristic`|
|ReferencedAttribute|`msdyn_incidenttypecharacteristicid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_incidenttypecharacteristic`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_incidenttypeproduct_ActivityPointers"></a> msdyn_incidenttypeproduct_ActivityPointers

One-To-Many Relationship: [msdyn_incidenttypeproduct msdyn_incidenttypeproduct_ActivityPointers](msdyn_incidenttypeproduct.md#BKMK_msdyn_incidenttypeproduct_ActivityPointers)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_incidenttypeproduct`|
|ReferencedAttribute|`msdyn_incidenttypeproductid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_incidenttypeproduct`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_incidenttypeservice_ActivityPointers"></a> msdyn_incidenttypeservice_ActivityPointers

One-To-Many Relationship: [msdyn_incidenttypeservice msdyn_incidenttypeservice_ActivityPointers](msdyn_incidenttypeservice.md#BKMK_msdyn_incidenttypeservice_ActivityPointers)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_incidenttypeservice`|
|ReferencedAttribute|`msdyn_incidenttypeserviceid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_incidenttypeservice`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_inventoryadjustment_ActivityPointers"></a> msdyn_inventoryadjustment_ActivityPointers

One-To-Many Relationship: [msdyn_inventoryadjustment msdyn_inventoryadjustment_ActivityPointers](msdyn_inventoryadjustment.md#BKMK_msdyn_inventoryadjustment_ActivityPointers)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_inventoryadjustment`|
|ReferencedAttribute|`msdyn_inventoryadjustmentid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_inventoryadjustment`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_inventoryadjustmentproduct_ActivityPointers"></a> msdyn_inventoryadjustmentproduct_ActivityPointers

One-To-Many Relationship: [msdyn_inventoryadjustmentproduct msdyn_inventoryadjustmentproduct_ActivityPointers](msdyn_inventoryadjustmentproduct.md#BKMK_msdyn_inventoryadjustmentproduct_ActivityPointers)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_inventoryadjustmentproduct`|
|ReferencedAttribute|`msdyn_inventoryadjustmentproductid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_inventoryadjustmentproduct`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_inventoryjournal_ActivityPointers"></a> msdyn_inventoryjournal_ActivityPointers

One-To-Many Relationship: [msdyn_inventoryjournal msdyn_inventoryjournal_ActivityPointers](msdyn_inventoryjournal.md#BKMK_msdyn_inventoryjournal_ActivityPointers)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_inventoryjournal`|
|ReferencedAttribute|`msdyn_inventoryjournalid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_inventoryjournal`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_inventorytransfer_ActivityPointers"></a> msdyn_inventorytransfer_ActivityPointers

One-To-Many Relationship: [msdyn_inventorytransfer msdyn_inventorytransfer_ActivityPointers](msdyn_inventorytransfer.md#BKMK_msdyn_inventorytransfer_ActivityPointers)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_inventorytransfer`|
|ReferencedAttribute|`msdyn_inventorytransferid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_inventorytransfer`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_payment_ActivityPointers"></a> msdyn_payment_ActivityPointers

One-To-Many Relationship: [msdyn_payment msdyn_payment_ActivityPointers](msdyn_payment.md#BKMK_msdyn_payment_ActivityPointers)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_payment`|
|ReferencedAttribute|`msdyn_paymentid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_payment`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_paymentdetail_ActivityPointers"></a> msdyn_paymentdetail_ActivityPointers

One-To-Many Relationship: [msdyn_paymentdetail msdyn_paymentdetail_ActivityPointers](msdyn_paymentdetail.md#BKMK_msdyn_paymentdetail_ActivityPointers)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_paymentdetail`|
|ReferencedAttribute|`msdyn_paymentdetailid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_paymentdetail`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_paymentmethod_ActivityPointers"></a> msdyn_paymentmethod_ActivityPointers

One-To-Many Relationship: [msdyn_paymentmethod msdyn_paymentmethod_ActivityPointers](msdyn_paymentmethod.md#BKMK_msdyn_paymentmethod_ActivityPointers)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_paymentmethod`|
|ReferencedAttribute|`msdyn_paymentmethodid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_paymentmethod`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_paymentterm_ActivityPointers"></a> msdyn_paymentterm_ActivityPointers

One-To-Many Relationship: [msdyn_paymentterm msdyn_paymentterm_ActivityPointers](msdyn_paymentterm.md#BKMK_msdyn_paymentterm_ActivityPointers)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_paymentterm`|
|ReferencedAttribute|`msdyn_paymenttermid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_paymentterm`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_playbookinstance_ActivityPointers"></a> msdyn_playbookinstance_ActivityPointers

One-To-Many Relationship: [msdyn_playbookinstance msdyn_playbookinstance_ActivityPointers](msdyn_playbookinstance.md#BKMK_msdyn_playbookinstance_ActivityPointers)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_playbookinstance`|
|ReferencedAttribute|`msdyn_playbookinstanceid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_playbookinstance`|
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

### <a name="BKMK_msdyn_postalcode_ActivityPointers"></a> msdyn_postalcode_ActivityPointers

One-To-Many Relationship: [msdyn_postalcode msdyn_postalcode_ActivityPointers](msdyn_postalcode.md#BKMK_msdyn_postalcode_ActivityPointers)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_postalcode`|
|ReferencedAttribute|`msdyn_postalcodeid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_postalcode`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_productinventory_ActivityPointers"></a> msdyn_productinventory_ActivityPointers

One-To-Many Relationship: [msdyn_productinventory msdyn_productinventory_ActivityPointers](msdyn_productinventory.md#BKMK_msdyn_productinventory_ActivityPointers)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_productinventory`|
|ReferencedAttribute|`msdyn_productinventoryid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_productinventory`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_purchaseorder_ActivityPointers"></a> msdyn_purchaseorder_ActivityPointers

One-To-Many Relationship: [msdyn_purchaseorder msdyn_purchaseorder_ActivityPointers](msdyn_purchaseorder.md#BKMK_msdyn_purchaseorder_ActivityPointers)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_purchaseorder`|
|ReferencedAttribute|`msdyn_purchaseorderid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_purchaseorder`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_purchaseorderbill_ActivityPointers"></a> msdyn_purchaseorderbill_ActivityPointers

One-To-Many Relationship: [msdyn_purchaseorderbill msdyn_purchaseorderbill_ActivityPointers](msdyn_purchaseorderbill.md#BKMK_msdyn_purchaseorderbill_ActivityPointers)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_purchaseorderbill`|
|ReferencedAttribute|`msdyn_purchaseorderbillid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_purchaseorderbill`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_purchaseorderproduct_ActivityPointers"></a> msdyn_purchaseorderproduct_ActivityPointers

One-To-Many Relationship: [msdyn_purchaseorderproduct msdyn_purchaseorderproduct_ActivityPointers](msdyn_purchaseorderproduct.md#BKMK_msdyn_purchaseorderproduct_ActivityPointers)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_purchaseorderproduct`|
|ReferencedAttribute|`msdyn_purchaseorderproductid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_purchaseorderproduct`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_purchaseorderreceipt_ActivityPointers"></a> msdyn_purchaseorderreceipt_ActivityPointers

One-To-Many Relationship: [msdyn_purchaseorderreceipt msdyn_purchaseorderreceipt_ActivityPointers](msdyn_purchaseorderreceipt.md#BKMK_msdyn_purchaseorderreceipt_ActivityPointers)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_purchaseorderreceipt`|
|ReferencedAttribute|`msdyn_purchaseorderreceiptid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_purchaseorderreceipt`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_purchaseorderreceiptproduct_ActivityPointers"></a> msdyn_purchaseorderreceiptproduct_ActivityPointers

One-To-Many Relationship: [msdyn_purchaseorderreceiptproduct msdyn_purchaseorderreceiptproduct_ActivityPointers](msdyn_purchaseorderreceiptproduct.md#BKMK_msdyn_purchaseorderreceiptproduct_ActivityPointers)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_purchaseorderreceiptproduct`|
|ReferencedAttribute|`msdyn_purchaseorderreceiptproductid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_purchaseorderreceiptproduct`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_purchaseordersubstatus_ActivityPointers"></a> msdyn_purchaseordersubstatus_ActivityPointers

One-To-Many Relationship: [msdyn_purchaseordersubstatus msdyn_purchaseordersubstatus_ActivityPointers](msdyn_purchaseordersubstatus.md#BKMK_msdyn_purchaseordersubstatus_ActivityPointers)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_purchaseordersubstatus`|
|ReferencedAttribute|`msdyn_purchaseordersubstatusid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_purchaseordersubstatus`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_quotebookingincident_ActivityPointers"></a> msdyn_quotebookingincident_ActivityPointers

One-To-Many Relationship: [msdyn_quotebookingincident msdyn_quotebookingincident_ActivityPointers](msdyn_quotebookingincident.md#BKMK_msdyn_quotebookingincident_ActivityPointers)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_quotebookingincident`|
|ReferencedAttribute|`msdyn_quotebookingincidentid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_quotebookingincident`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_quotebookingproduct_ActivityPointers"></a> msdyn_quotebookingproduct_ActivityPointers

One-To-Many Relationship: [msdyn_quotebookingproduct msdyn_quotebookingproduct_ActivityPointers](msdyn_quotebookingproduct.md#BKMK_msdyn_quotebookingproduct_ActivityPointers)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_quotebookingproduct`|
|ReferencedAttribute|`msdyn_quotebookingproductid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_quotebookingproduct`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_quotebookingservice_ActivityPointers"></a> msdyn_quotebookingservice_ActivityPointers

One-To-Many Relationship: [msdyn_quotebookingservice msdyn_quotebookingservice_ActivityPointers](msdyn_quotebookingservice.md#BKMK_msdyn_quotebookingservice_ActivityPointers)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_quotebookingservice`|
|ReferencedAttribute|`msdyn_quotebookingserviceid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_quotebookingservice`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_quotebookingservicetask_ActivityPointers"></a> msdyn_quotebookingservicetask_ActivityPointers

One-To-Many Relationship: [msdyn_quotebookingservicetask msdyn_quotebookingservicetask_ActivityPointers](msdyn_quotebookingservicetask.md#BKMK_msdyn_quotebookingservicetask_ActivityPointers)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_quotebookingservicetask`|
|ReferencedAttribute|`msdyn_quotebookingservicetaskid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_quotebookingservicetask`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_resourceterritory_ActivityPointers"></a> msdyn_resourceterritory_ActivityPointers

One-To-Many Relationship: [msdyn_resourceterritory msdyn_resourceterritory_ActivityPointers](msdyn_resourceterritory.md#BKMK_msdyn_resourceterritory_ActivityPointers)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_resourceterritory`|
|ReferencedAttribute|`msdyn_resourceterritoryid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_resourceterritory`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_rma_ActivityPointers"></a> msdyn_rma_ActivityPointers

One-To-Many Relationship: [msdyn_rma msdyn_rma_ActivityPointers](msdyn_rma.md#BKMK_msdyn_rma_ActivityPointers)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_rma`|
|ReferencedAttribute|`msdyn_rmaid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_rma`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_rmaproduct_ActivityPointers"></a> msdyn_rmaproduct_ActivityPointers

One-To-Many Relationship: [msdyn_rmaproduct msdyn_rmaproduct_ActivityPointers](msdyn_rmaproduct.md#BKMK_msdyn_rmaproduct_ActivityPointers)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_rmaproduct`|
|ReferencedAttribute|`msdyn_rmaproductid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_rmaproduct`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_rmareceipt_ActivityPointers"></a> msdyn_rmareceipt_ActivityPointers

One-To-Many Relationship: [msdyn_rmareceipt msdyn_rmareceipt_ActivityPointers](msdyn_rmareceipt.md#BKMK_msdyn_rmareceipt_ActivityPointers)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_rmareceipt`|
|ReferencedAttribute|`msdyn_rmareceiptid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_rmareceipt`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_rmareceiptproduct_ActivityPointers"></a> msdyn_rmareceiptproduct_ActivityPointers

One-To-Many Relationship: [msdyn_rmareceiptproduct msdyn_rmareceiptproduct_ActivityPointers](msdyn_rmareceiptproduct.md#BKMK_msdyn_rmareceiptproduct_ActivityPointers)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_rmareceiptproduct`|
|ReferencedAttribute|`msdyn_rmareceiptproductid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_rmareceiptproduct`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_rmasubstatus_ActivityPointers"></a> msdyn_rmasubstatus_ActivityPointers

One-To-Many Relationship: [msdyn_rmasubstatus msdyn_rmasubstatus_ActivityPointers](msdyn_rmasubstatus.md#BKMK_msdyn_rmasubstatus_ActivityPointers)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_rmasubstatus`|
|ReferencedAttribute|`msdyn_rmasubstatusid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_rmasubstatus`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_rtv_ActivityPointers"></a> msdyn_rtv_ActivityPointers

One-To-Many Relationship: [msdyn_rtv msdyn_rtv_ActivityPointers](msdyn_rtv.md#BKMK_msdyn_rtv_ActivityPointers)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_rtv`|
|ReferencedAttribute|`msdyn_rtvid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_rtv`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_rtvproduct_ActivityPointers"></a> msdyn_rtvproduct_ActivityPointers

One-To-Many Relationship: [msdyn_rtvproduct msdyn_rtvproduct_ActivityPointers](msdyn_rtvproduct.md#BKMK_msdyn_rtvproduct_ActivityPointers)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_rtvproduct`|
|ReferencedAttribute|`msdyn_rtvproductid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_rtvproduct`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_rtvsubstatus_ActivityPointers"></a> msdyn_rtvsubstatus_ActivityPointers

One-To-Many Relationship: [msdyn_rtvsubstatus msdyn_rtvsubstatus_ActivityPointers](msdyn_rtvsubstatus.md#BKMK_msdyn_rtvsubstatus_ActivityPointers)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_rtvsubstatus`|
|ReferencedAttribute|`msdyn_rtvsubstatusid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_rtvsubstatus`|
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

### <a name="BKMK_msdyn_shipvia_ActivityPointers"></a> msdyn_shipvia_ActivityPointers

One-To-Many Relationship: [msdyn_shipvia msdyn_shipvia_ActivityPointers](msdyn_shipvia.md#BKMK_msdyn_shipvia_ActivityPointers)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_shipvia`|
|ReferencedAttribute|`msdyn_shipviaid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_shipvia`|
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

### <a name="BKMK_msdyn_systemuserschedulersetting_ActivityPointers"></a> msdyn_systemuserschedulersetting_ActivityPointers

One-To-Many Relationship: [msdyn_systemuserschedulersetting msdyn_systemuserschedulersetting_ActivityPointers](msdyn_systemuserschedulersetting.md#BKMK_msdyn_systemuserschedulersetting_ActivityPointers)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_systemuserschedulersetting`|
|ReferencedAttribute|`msdyn_systemuserschedulersettingid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_systemuserschedulersetting`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_timegroup_ActivityPointers"></a> msdyn_timegroup_ActivityPointers

One-To-Many Relationship: [msdyn_timegroup msdyn_timegroup_ActivityPointers](msdyn_timegroup.md#BKMK_msdyn_timegroup_ActivityPointers)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_timegroup`|
|ReferencedAttribute|`msdyn_timegroupid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_timegroup`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_timegroupdetail_ActivityPointers"></a> msdyn_timegroupdetail_ActivityPointers

One-To-Many Relationship: [msdyn_timegroupdetail msdyn_timegroupdetail_ActivityPointers](msdyn_timegroupdetail.md#BKMK_msdyn_timegroupdetail_ActivityPointers)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_timegroupdetail`|
|ReferencedAttribute|`msdyn_timegroupdetailid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_timegroupdetail`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_timeoffrequest_ActivityPointers"></a> msdyn_timeoffrequest_ActivityPointers

One-To-Many Relationship: [msdyn_timeoffrequest msdyn_timeoffrequest_ActivityPointers](msdyn_timeoffrequest.md#BKMK_msdyn_timeoffrequest_ActivityPointers)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_timeoffrequest`|
|ReferencedAttribute|`msdyn_timeoffrequestid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_timeoffrequest`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_warehouse_ActivityPointers"></a> msdyn_warehouse_ActivityPointers

One-To-Many Relationship: [msdyn_warehouse msdyn_warehouse_ActivityPointers](msdyn_warehouse.md#BKMK_msdyn_warehouse_ActivityPointers)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_warehouse`|
|ReferencedAttribute|`msdyn_warehouseid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_warehouse`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_workorder_ActivityPointers"></a> msdyn_workorder_ActivityPointers

One-To-Many Relationship: [msdyn_workorder msdyn_workorder_ActivityPointers](msdyn_workorder.md#BKMK_msdyn_workorder_ActivityPointers)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_workorder`|
|ReferencedAttribute|`msdyn_workorderid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_workorder`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_workordercharacteristic_ActivityPointers"></a> msdyn_workordercharacteristic_ActivityPointers

One-To-Many Relationship: [msdyn_workordercharacteristic msdyn_workordercharacteristic_ActivityPointers](msdyn_workordercharacteristic.md#BKMK_msdyn_workordercharacteristic_ActivityPointers)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_workordercharacteristic`|
|ReferencedAttribute|`msdyn_workordercharacteristicid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_workordercharacteristic`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_workorderincident_ActivityPointers"></a> msdyn_workorderincident_ActivityPointers

One-To-Many Relationship: [msdyn_workorderincident msdyn_workorderincident_ActivityPointers](msdyn_workorderincident.md#BKMK_msdyn_workorderincident_ActivityPointers)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_workorderincident`|
|ReferencedAttribute|`msdyn_workorderincidentid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_workorderincident`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_workorderproduct_ActivityPointers"></a> msdyn_workorderproduct_ActivityPointers

One-To-Many Relationship: [msdyn_workorderproduct msdyn_workorderproduct_ActivityPointers](msdyn_workorderproduct.md#BKMK_msdyn_workorderproduct_ActivityPointers)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_workorderproduct`|
|ReferencedAttribute|`msdyn_workorderproductid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_workorderproduct`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_workorderresourcerestriction_ActivityPointers"></a> msdyn_workorderresourcerestriction_ActivityPointers

One-To-Many Relationship: [msdyn_workorderresourcerestriction msdyn_workorderresourcerestriction_ActivityPointers](msdyn_workorderresourcerestriction.md#BKMK_msdyn_workorderresourcerestriction_ActivityPointers)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_workorderresourcerestriction`|
|ReferencedAttribute|`msdyn_workorderresourcerestrictionid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_workorderresourcerestriction`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_workorderservice_ActivityPointers"></a> msdyn_workorderservice_ActivityPointers

One-To-Many Relationship: [msdyn_workorderservice msdyn_workorderservice_ActivityPointers](msdyn_workorderservice.md#BKMK_msdyn_workorderservice_ActivityPointers)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_workorderservice`|
|ReferencedAttribute|`msdyn_workorderserviceid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_workorderservice`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_workorderservicetask_ActivityPointers"></a> msdyn_workorderservicetask_ActivityPointers

One-To-Many Relationship: [msdyn_workorderservicetask msdyn_workorderservicetask_ActivityPointers](msdyn_workorderservicetask.md#BKMK_msdyn_workorderservicetask_ActivityPointers)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_workorderservicetask`|
|ReferencedAttribute|`msdyn_workorderservicetaskid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_workorderservicetask`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyncrm_contentsettings_ActivityPointers"></a> msdyncrm_contentsettings_ActivityPointers

One-To-Many Relationship: [msdyncrm_contentsettings msdyncrm_contentsettings_ActivityPointers](msdyncrm_contentsettings.md#BKMK_msdyncrm_contentsettings_ActivityPointers)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyncrm_contentsettings`|
|ReferencedAttribute|`msdyncrm_contentsettingsid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyncrm_contentsettings`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyncrm_customerjourney_ActivityPointers"></a> msdyncrm_customerjourney_ActivityPointers

One-To-Many Relationship: [msdyncrm_customerjourney msdyncrm_customerjourney_ActivityPointers](msdyncrm_customerjourney.md#BKMK_msdyncrm_customerjourney_ActivityPointers)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyncrm_customerjourney`|
|ReferencedAttribute|`msdyncrm_customerjourneyid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyncrm_customerjourney`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyncrm_leadscoremodel_ActivityPointers"></a> msdyncrm_leadscoremodel_ActivityPointers

One-To-Many Relationship: [msdyncrm_leadscoremodel msdyncrm_leadscoremodel_ActivityPointers](msdyncrm_leadscoremodel.md#BKMK_msdyncrm_leadscoremodel_ActivityPointers)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyncrm_leadscoremodel`|
|ReferencedAttribute|`msdyncrm_leadscoremodelid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyncrm_leadscoremodel`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyncrm_linkedinaccount_ActivityPointers"></a> msdyncrm_linkedinaccount_ActivityPointers

One-To-Many Relationship: [msdyncrm_linkedinaccount msdyncrm_linkedinaccount_ActivityPointers](msdyncrm_linkedinaccount.md#BKMK_msdyncrm_linkedinaccount_ActivityPointers)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyncrm_linkedinaccount`|
|ReferencedAttribute|`msdyncrm_linkedinaccountid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyncrm_linkedinaccount`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyncrm_linkedinactivity_ActivityPointers"></a> msdyncrm_linkedinactivity_ActivityPointers

One-To-Many Relationship: [msdyncrm_linkedinactivity msdyncrm_linkedinactivity_ActivityPointers](msdyncrm_linkedinactivity.md#BKMK_msdyncrm_linkedinactivity_ActivityPointers)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyncrm_linkedinactivity`|
|ReferencedAttribute|`msdyncrm_linkedinactivityid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyncrm_linkedinactivity`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyncrm_linkedinfieldmapping_ActivityPointers"></a> msdyncrm_linkedinfieldmapping_ActivityPointers

One-To-Many Relationship: [msdyncrm_linkedinfieldmapping msdyncrm_linkedinfieldmapping_ActivityPointers](msdyncrm_linkedinfieldmapping.md#BKMK_msdyncrm_linkedinfieldmapping_ActivityPointers)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyncrm_linkedinfieldmapping`|
|ReferencedAttribute|`msdyncrm_linkedinfieldmappingid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyncrm_linkedinfieldmapping`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyncrm_linkedinform_ActivityPointers"></a> msdyncrm_linkedinform_ActivityPointers

One-To-Many Relationship: [msdyncrm_linkedinform msdyncrm_linkedinform_ActivityPointers](msdyncrm_linkedinform.md#BKMK_msdyncrm_linkedinform_ActivityPointers)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyncrm_linkedinform`|
|ReferencedAttribute|`msdyncrm_linkedinformid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyncrm_linkedinform`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyncrm_linkedinformanswer_ActivityPointers"></a> msdyncrm_linkedinformanswer_ActivityPointers

One-To-Many Relationship: [msdyncrm_linkedinformanswer msdyncrm_linkedinformanswer_ActivityPointers](msdyncrm_linkedinformanswer.md#BKMK_msdyncrm_linkedinformanswer_ActivityPointers)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyncrm_linkedinformanswer`|
|ReferencedAttribute|`msdyncrm_linkedinformanswerid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyncrm_linkedinformanswer`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyncrm_linkedinformquestion_ActivityPointers"></a> msdyncrm_linkedinformquestion_ActivityPointers

One-To-Many Relationship: [msdyncrm_linkedinformquestion msdyncrm_linkedinformquestion_ActivityPointers](msdyncrm_linkedinformquestion.md#BKMK_msdyncrm_linkedinformquestion_ActivityPointers)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyncrm_linkedinformquestion`|
|ReferencedAttribute|`msdyncrm_linkedinformquestionid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyncrm_linkedinformquestion`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyncrm_linkedinformsubmission_ActivityPointers"></a> msdyncrm_linkedinformsubmission_ActivityPointers

One-To-Many Relationship: [msdyncrm_linkedinformsubmission msdyncrm_linkedinformsubmission_ActivityPointers](msdyncrm_linkedinformsubmission.md#BKMK_msdyncrm_linkedinformsubmission_ActivityPointers)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyncrm_linkedinformsubmission`|
|ReferencedAttribute|`msdyncrm_linkedinformsubmissionid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyncrm_linkedinformsubmission`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyncrm_linkedinleadmatchingstrategy_ActivityPointers"></a> msdyncrm_linkedinleadmatchingstrategy_ActivityPointers

One-To-Many Relationship: [msdyncrm_linkedinleadmatchingstrategy msdyncrm_linkedinleadmatchingstrategy_ActivityPointers](msdyncrm_linkedinleadmatchingstrategy.md#BKMK_msdyncrm_linkedinleadmatchingstrategy_ActivityPointers)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyncrm_linkedinleadmatchingstrategy`|
|ReferencedAttribute|`msdyncrm_linkedinleadmatchingstrategyid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyncrm_linkedinleadmatchingstrategy`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyncrm_linkedinuserprofile_ActivityPointers"></a> msdyncrm_linkedinuserprofile_ActivityPointers

One-To-Many Relationship: [msdyncrm_linkedinuserprofile msdyncrm_linkedinuserprofile_ActivityPointers](msdyncrm_linkedinuserprofile.md#BKMK_msdyncrm_linkedinuserprofile_ActivityPointers)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyncrm_linkedinuserprofile`|
|ReferencedAttribute|`msdyncrm_linkedinuserprofileid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyncrm_linkedinuserprofile`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyncrm_marketingdynamiccontentmetadata_ActivityPointers"></a> msdyncrm_marketingdynamiccontentmetadata_ActivityPointers

One-To-Many Relationship: [msdyncrm_marketingdynamiccontentmetadata msdyncrm_marketingdynamiccontentmetadata_ActivityPointers](msdyncrm_marketingdynamiccontentmetadata.md#BKMK_msdyncrm_marketingdynamiccontentmetadata_ActivityPointers)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyncrm_marketingdynamiccontentmetadata`|
|ReferencedAttribute|`msdyncrm_marketingdynamiccontentmetadataid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyncrm_marketingdynamiccontentmetadata`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyncrm_marketingemaildynamiccontentmetadata_ActivityPointers"></a> msdyncrm_marketingemaildynamiccontentmetadata_ActivityPointers

One-To-Many Relationship: [msdyncrm_marketingemaildynamiccontentmetadata msdyncrm_marketingemaildynamiccontentmetadata_ActivityPointers](msdyncrm_marketingemaildynamiccontentmetadata.md#BKMK_msdyncrm_marketingemaildynamiccontentmetadata_ActivityPointers)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyncrm_marketingemaildynamiccontentmetadata`|
|ReferencedAttribute|`msdyncrm_marketingemaildynamiccontentmetadataid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyncrm_marketingemaildynamiccontentmetadata`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyncrm_marketingemailtestsend_ActivityPointers"></a> msdyncrm_marketingemailtestsend_ActivityPointers

One-To-Many Relationship: [msdyncrm_marketingemailtestsend msdyncrm_marketingemailtestsend_ActivityPointers](msdyncrm_marketingemailtestsend.md#BKMK_msdyncrm_marketingemailtestsend_ActivityPointers)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyncrm_marketingemailtestsend`|
|ReferencedAttribute|`msdyncrm_marketingemailtestsendid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyncrm_marketingemailtestsend`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyncrm_migration_ActivityPointers"></a> msdyncrm_migration_ActivityPointers

One-To-Many Relationship: [msdyncrm_migration msdyncrm_migration_ActivityPointers](msdyncrm_migration.md#BKMK_msdyncrm_migration_ActivityPointers)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyncrm_migration`|
|ReferencedAttribute|`msdyncrm_migrationid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyncrm_migration`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyncrm_uicconfig_ActivityPointers"></a> msdyncrm_uicconfig_ActivityPointers

One-To-Many Relationship: [msdyncrm_uicconfig msdyncrm_uicconfig_ActivityPointers](msdyncrm_uicconfig.md#BKMK_msdyncrm_uicconfig_ActivityPointers)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyncrm_uicconfig`|
|ReferencedAttribute|`msdyncrm_uicconfigid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyncrm_uicconfig`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msevtmgt_checkin_ActivityPointers"></a> msevtmgt_checkin_ActivityPointers

One-To-Many Relationship: [msevtmgt_checkin msevtmgt_checkin_ActivityPointers](msevtmgt_checkin.md#BKMK_msevtmgt_checkin_ActivityPointers)

|Property|Value|
|---|---|
|ReferencedEntity|`msevtmgt_checkin`|
|ReferencedAttribute|`msevtmgt_checkinid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msevtmgt_checkin`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msevtmgt_event_ActivityPointers"></a> msevtmgt_event_ActivityPointers

One-To-Many Relationship: [msevtmgt_event msevtmgt_event_ActivityPointers](msevtmgt_event.md#BKMK_msevtmgt_event_ActivityPointers)

|Property|Value|
|---|---|
|ReferencedEntity|`msevtmgt_event`|
|ReferencedAttribute|`msevtmgt_eventid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msevtmgt_event`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msevtmgt_eventpurchase_ActivityPointers"></a> msevtmgt_eventpurchase_ActivityPointers

One-To-Many Relationship: [msevtmgt_eventpurchase msevtmgt_eventpurchase_ActivityPointers](msevtmgt_eventpurchase.md#BKMK_msevtmgt_eventpurchase_ActivityPointers)

|Property|Value|
|---|---|
|ReferencedEntity|`msevtmgt_eventpurchase`|
|ReferencedAttribute|`msevtmgt_eventpurchaseid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msevtmgt_eventpurchase`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msevtmgt_eventpurchaseattendee_ActivityPointers"></a> msevtmgt_eventpurchaseattendee_ActivityPointers

One-To-Many Relationship: [msevtmgt_eventpurchaseattendee msevtmgt_eventpurchaseattendee_ActivityPointers](msevtmgt_eventpurchaseattendee.md#BKMK_msevtmgt_eventpurchaseattendee_ActivityPointers)

|Property|Value|
|---|---|
|ReferencedEntity|`msevtmgt_eventpurchaseattendee`|
|ReferencedAttribute|`msevtmgt_eventpurchaseattendeeid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msevtmgt_eventpurchaseattendee`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msevtmgt_eventpurchasepass_ActivityPointers"></a> msevtmgt_eventpurchasepass_ActivityPointers

One-To-Many Relationship: [msevtmgt_eventpurchasepass msevtmgt_eventpurchasepass_ActivityPointers](msevtmgt_eventpurchasepass.md#BKMK_msevtmgt_eventpurchasepass_ActivityPointers)

|Property|Value|
|---|---|
|ReferencedEntity|`msevtmgt_eventpurchasepass`|
|ReferencedAttribute|`msevtmgt_eventpurchasepassid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msevtmgt_eventpurchasepass`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msevtmgt_eventregistration_ActivityPointers"></a> msevtmgt_eventregistration_ActivityPointers

One-To-Many Relationship: [msevtmgt_eventregistration msevtmgt_eventregistration_ActivityPointers](msevtmgt_eventregistration.md#BKMK_msevtmgt_eventregistration_ActivityPointers)

|Property|Value|
|---|---|
|ReferencedEntity|`msevtmgt_eventregistration`|
|ReferencedAttribute|`msevtmgt_eventregistrationid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msevtmgt_eventregistration`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msevtmgt_hotel_ActivityPointers"></a> msevtmgt_hotel_ActivityPointers

One-To-Many Relationship: [msevtmgt_hotel msevtmgt_hotel_ActivityPointers](msevtmgt_hotel.md#BKMK_msevtmgt_hotel_ActivityPointers)

|Property|Value|
|---|---|
|ReferencedEntity|`msevtmgt_hotel`|
|ReferencedAttribute|`msevtmgt_hotelid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msevtmgt_hotel`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msevtmgt_hotelroomallocation_ActivityPointers"></a> msevtmgt_hotelroomallocation_ActivityPointers

One-To-Many Relationship: [msevtmgt_hotelroomallocation msevtmgt_hotelroomallocation_ActivityPointers](msevtmgt_hotelroomallocation.md#BKMK_msevtmgt_hotelroomallocation_ActivityPointers)

|Property|Value|
|---|---|
|ReferencedEntity|`msevtmgt_hotelroomallocation`|
|ReferencedAttribute|`msevtmgt_hotelroomallocationid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msevtmgt_hotelroomallocation`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msevtmgt_hotelroomreservation_ActivityPointers"></a> msevtmgt_hotelroomreservation_ActivityPointers

One-To-Many Relationship: [msevtmgt_hotelroomreservation msevtmgt_hotelroomreservation_ActivityPointers](msevtmgt_hotelroomreservation.md#BKMK_msevtmgt_hotelroomreservation_ActivityPointers)

|Property|Value|
|---|---|
|ReferencedEntity|`msevtmgt_hotelroomreservation`|
|ReferencedAttribute|`msevtmgt_hotelroomreservationid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msevtmgt_hotelroomreservation`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msevtmgt_layout_ActivityPointers"></a> msevtmgt_layout_ActivityPointers

One-To-Many Relationship: [msevtmgt_layout msevtmgt_layout_ActivityPointers](msevtmgt_layout.md#BKMK_msevtmgt_layout_ActivityPointers)

|Property|Value|
|---|---|
|ReferencedEntity|`msevtmgt_layout`|
|ReferencedAttribute|`msevtmgt_layoutid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msevtmgt_layout`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msevtmgt_room_ActivityPointers"></a> msevtmgt_room_ActivityPointers

One-To-Many Relationship: [msevtmgt_room msevtmgt_room_ActivityPointers](msevtmgt_room.md#BKMK_msevtmgt_room_ActivityPointers)

|Property|Value|
|---|---|
|ReferencedEntity|`msevtmgt_room`|
|ReferencedAttribute|`msevtmgt_roomid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msevtmgt_room`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msevtmgt_session_ActivityPointers"></a> msevtmgt_session_ActivityPointers

One-To-Many Relationship: [msevtmgt_session msevtmgt_session_ActivityPointers](msevtmgt_session.md#BKMK_msevtmgt_session_ActivityPointers)

|Property|Value|
|---|---|
|ReferencedEntity|`msevtmgt_session`|
|ReferencedAttribute|`msevtmgt_sessionid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msevtmgt_session`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msevtmgt_sessionregistration_ActivityPointers"></a> msevtmgt_sessionregistration_ActivityPointers

One-To-Many Relationship: [msevtmgt_sessionregistration msevtmgt_sessionregistration_ActivityPointers](msevtmgt_sessionregistration.md#BKMK_msevtmgt_sessionregistration_ActivityPointers)

|Property|Value|
|---|---|
|ReferencedEntity|`msevtmgt_sessionregistration`|
|ReferencedAttribute|`msevtmgt_sessionregistrationid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msevtmgt_sessionregistration`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msevtmgt_sessiontrack_ActivityPointers"></a> msevtmgt_sessiontrack_ActivityPointers

One-To-Many Relationship: [msevtmgt_sessiontrack msevtmgt_sessiontrack_ActivityPointers](msevtmgt_sessiontrack.md#BKMK_msevtmgt_sessiontrack_ActivityPointers)

|Property|Value|
|---|---|
|ReferencedEntity|`msevtmgt_sessiontrack`|
|ReferencedAttribute|`msevtmgt_sessiontrackid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msevtmgt_sessiontrack`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msevtmgt_speaker_ActivityPointers"></a> msevtmgt_speaker_ActivityPointers

One-To-Many Relationship: [msevtmgt_speaker msevtmgt_speaker_ActivityPointers](msevtmgt_speaker.md#BKMK_msevtmgt_speaker_ActivityPointers)

|Property|Value|
|---|---|
|ReferencedEntity|`msevtmgt_speaker`|
|ReferencedAttribute|`msevtmgt_speakerid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msevtmgt_speaker`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msevtmgt_speakerengagement_ActivityPointers"></a> msevtmgt_speakerengagement_ActivityPointers

One-To-Many Relationship: [msevtmgt_speakerengagement msevtmgt_speakerengagement_ActivityPointers](msevtmgt_speakerengagement.md#BKMK_msevtmgt_speakerengagement_ActivityPointers)

|Property|Value|
|---|---|
|ReferencedEntity|`msevtmgt_speakerengagement`|
|ReferencedAttribute|`msevtmgt_speakerengagementid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msevtmgt_speakerengagement`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msevtmgt_sponsorablearticle_ActivityPointers"></a> msevtmgt_sponsorablearticle_ActivityPointers

One-To-Many Relationship: [msevtmgt_sponsorablearticle msevtmgt_sponsorablearticle_ActivityPointers](msevtmgt_sponsorablearticle.md#BKMK_msevtmgt_sponsorablearticle_ActivityPointers)

|Property|Value|
|---|---|
|ReferencedEntity|`msevtmgt_sponsorablearticle`|
|ReferencedAttribute|`msevtmgt_sponsorablearticleid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msevtmgt_sponsorablearticle`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msevtmgt_sponsorship_ActivityPointers"></a> msevtmgt_sponsorship_ActivityPointers

One-To-Many Relationship: [msevtmgt_sponsorship msevtmgt_sponsorship_ActivityPointers](msevtmgt_sponsorship.md#BKMK_msevtmgt_sponsorship_ActivityPointers)

|Property|Value|
|---|---|
|ReferencedEntity|`msevtmgt_sponsorship`|
|ReferencedAttribute|`msevtmgt_sponsorshipid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msevtmgt_sponsorship`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msevtmgt_venue_ActivityPointers"></a> msevtmgt_venue_ActivityPointers

One-To-Many Relationship: [msevtmgt_venue msevtmgt_venue_ActivityPointers](msevtmgt_venue.md#BKMK_msevtmgt_venue_ActivityPointers)

|Property|Value|
|---|---|
|ReferencedEntity|`msevtmgt_venue`|
|ReferencedAttribute|`msevtmgt_venueid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msevtmgt_venue`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msevtmgt_webinarconfiguration_ActivityPointers"></a> msevtmgt_webinarconfiguration_ActivityPointers

One-To-Many Relationship: [msevtmgt_webinarconfiguration msevtmgt_webinarconfiguration_ActivityPointers](msevtmgt_webinarconfiguration.md#BKMK_msevtmgt_webinarconfiguration_ActivityPointers)

|Property|Value|
|---|---|
|ReferencedEntity|`msevtmgt_webinarconfiguration`|
|ReferencedAttribute|`msevtmgt_webinarconfigurationid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msevtmgt_webinarconfiguration`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msevtmgt_webinarprovider_ActivityPointers"></a> msevtmgt_webinarprovider_ActivityPointers

One-To-Many Relationship: [msevtmgt_webinarprovider msevtmgt_webinarprovider_ActivityPointers](msevtmgt_webinarprovider.md#BKMK_msevtmgt_webinarprovider_ActivityPointers)

|Property|Value|
|---|---|
|ReferencedEntity|`msevtmgt_webinarprovider`|
|ReferencedAttribute|`msevtmgt_webinarproviderid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msevtmgt_webinarprovider`|
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
- [activity_pointer_adx_alertsubscription](#BKMK_activity_pointer_adx_alertsubscription)
- [activity_pointer_BulkOperation](#BKMK_activity_pointer_BulkOperation)
- [activity_pointer_BulkOperation_logs](#BKMK_activity_pointer_BulkOperation_logs)
- [activity_pointer_campaignactivity](#BKMK_activity_pointer_campaignactivity)
- [activity_pointer_campaignresponse](#BKMK_activity_pointer_campaignresponse)
- [activity_pointer_incident_resolution](#BKMK_activity_pointer_incident_resolution)
- [activity_pointer_li_inmail](#BKMK_activity_pointer_li_inmail)
- [activity_pointer_li_message](#BKMK_activity_pointer_li_message)
- [activity_pointer_li_pointdrivepresentationviewed](#BKMK_activity_pointer_li_pointdrivepresentationviewed)
- [activity_pointer_msdyn_bookingalert](#BKMK_activity_pointer_msdyn_bookingalert)
- [activity_pointer_msdyn_copilottranscript](#BKMK_activity_pointer_msdyn_copilottranscript)
- [activity_pointer_msdyn_ocliveworkitem](#BKMK_activity_pointer_msdyn_ocliveworkitem)
- [activity_pointer_msdyn_ocoutboundmessage](#BKMK_activity_pointer_msdyn_ocoutboundmessage)
- [activity_pointer_msdyn_ocsession](#BKMK_activity_pointer_msdyn_ocsession)
- [activity_pointer_msdyn_ocvoicemail](#BKMK_activity_pointer_msdyn_ocvoicemail)
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

### <a name="BKMK_activity_pointer_adx_alertsubscription"></a> activity_pointer_adx_alertsubscription

Many-To-One Relationship: [adx_alertsubscription activity_pointer_adx_alertsubscription](adx_alertsubscription.md#BKMK_activity_pointer_adx_alertsubscription)

|Property|Value|
|---|---|
|ReferencingEntity|`adx_alertsubscription`|
|ReferencingAttribute|`activityid`|
|ReferencedEntityNavigationPropertyName|`activity_pointer_adx_alertsubscription`|
|IsCustomizable|`True`|
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

### <a name="BKMK_activity_pointer_li_inmail"></a> activity_pointer_li_inmail

Many-To-One Relationship: [li_inmail activity_pointer_li_inmail](li_inmail.md#BKMK_activity_pointer_li_inmail)

|Property|Value|
|---|---|
|ReferencingEntity|`li_inmail`|
|ReferencingAttribute|`activityid`|
|ReferencedEntityNavigationPropertyName|`activity_pointer_li_inmail`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_activity_pointer_li_message"></a> activity_pointer_li_message

Many-To-One Relationship: [li_message activity_pointer_li_message](li_message.md#BKMK_activity_pointer_li_message)

|Property|Value|
|---|---|
|ReferencingEntity|`li_message`|
|ReferencingAttribute|`activityid`|
|ReferencedEntityNavigationPropertyName|`activity_pointer_li_message`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_activity_pointer_li_pointdrivepresentationviewed"></a> activity_pointer_li_pointdrivepresentationviewed

Many-To-One Relationship: [li_pointdrivepresentationviewed activity_pointer_li_pointdrivepresentationviewed](li_pointdrivepresentationviewed.md#BKMK_activity_pointer_li_pointdrivepresentationviewed)

|Property|Value|
|---|---|
|ReferencingEntity|`li_pointdrivepresentationviewed`|
|ReferencingAttribute|`activityid`|
|ReferencedEntityNavigationPropertyName|`activity_pointer_li_pointdrivepresentationviewed`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_activity_pointer_msdyn_bookingalert"></a> activity_pointer_msdyn_bookingalert

Many-To-One Relationship: [msdyn_bookingalert activity_pointer_msdyn_bookingalert](msdyn_bookingalert.md#BKMK_activity_pointer_msdyn_bookingalert)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_bookingalert`|
|ReferencingAttribute|`activityid`|
|ReferencedEntityNavigationPropertyName|`activity_pointer_msdyn_bookingalert`|
|IsCustomizable|`True`|
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

### <a name="BKMK_activity_pointer_msdyn_ocoutboundmessage"></a> activity_pointer_msdyn_ocoutboundmessage

Many-To-One Relationship: [msdyn_ocoutboundmessage activity_pointer_msdyn_ocoutboundmessage](msdyn_ocoutboundmessage.md#BKMK_activity_pointer_msdyn_ocoutboundmessage)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocoutboundmessage`|
|ReferencingAttribute|`activityid`|
|ReferencedEntityNavigationPropertyName|`activity_pointer_msdyn_ocoutboundmessage`|
|IsCustomizable|`False`|
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

### <a name="BKMK_activity_pointer_msdyn_ocvoicemail"></a> activity_pointer_msdyn_ocvoicemail

Many-To-One Relationship: [msdyn_ocvoicemail activity_pointer_msdyn_ocvoicemail](msdyn_ocvoicemail.md#BKMK_activity_pointer_msdyn_ocvoicemail)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocvoicemail`|
|ReferencingAttribute|`activityid`|
|ReferencedEntityNavigationPropertyName|`activity_pointer_msdyn_ocvoicemail`|
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

[Dataverse table/entity reference](../about-entity-reference.md)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   
<xref:Microsoft.Dynamics.CRM.activitypointer?displayProperty=fullName>
