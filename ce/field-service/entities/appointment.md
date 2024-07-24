---
title: "Appointment table/entity reference (Microsoft Dynamics 365 Field Service)"
description: "Includes schema information and supported messages for the Appointment table/entity with Microsoft Dynamics 365 Field Service."
ms.date: 07.24.2024
ms.service: powerapps
ms.topic: reference
author: m-hartmann
ms.author: mhart
search.audienceType: 
  - developer
---

# Appointment table/entity reference

Commitment representing a time interval with start/end times and duration.

> [!NOTE]
> The Microsoft Dynamics 365 Field Service Appointment table extends the [Microsoft Dataverse Appointment table](/power-apps/developer/data-platform/reference/entities/appointment).



## Writable columns/attributes

These columns/attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [msdyncrm_ActivityId](#BKMK_msdyncrm_ActivityId)
- [msdyncrm_associatedcustomerjourneyiteration](#BKMK_msdyncrm_associatedcustomerjourneyiteration)
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

Microsoft Dynamics 365 Field Service modifies the definition of columns/attributes defined in other solutions. Listed by **SchemaName**.

- [OptionalAttendees](#BKMK_OptionalAttendees)
- [RegardingObjectId](#BKMK_RegardingObjectId)
- [requiredattendees](#BKMK_requiredattendees)

### <a name="BKMK_OptionalAttendees"></a> OptionalAttendees

Changes from [OptionalAttendees (Microsoft Dataverse)](/power-apps/developer/data-platform/reference/entities/appointment#BKMK_OptionalAttendees)

|Property|Value|
|---|---|
|Targets|entitlement|


### <a name="BKMK_RegardingObjectId"></a> RegardingObjectId

Changes from [RegardingObjectId (Microsoft Dataverse)](/power-apps/developer/data-platform/reference/entities/appointment#BKMK_RegardingObjectId)

|Property|Value|
|---|---|
|Targets|adx_ad|


### <a name="BKMK_requiredattendees"></a> requiredattendees

Changes from [requiredattendees (Microsoft Dataverse)](/power-apps/developer/data-platform/reference/entities/appointment#BKMK_requiredattendees)

|Property|Value|
|---|---|
|Targets|entitlement|


## Many-to-One relationships

These relationships are many-to-one. Listed by **SchemaName**.

- [adx_ad_Appointments](#BKMK_adx_ad_Appointments)
- [adx_adplacement_Appointments](#BKMK_adx_adplacement_Appointments)
- [adx_casedeflection_Appointments](#BKMK_adx_casedeflection_Appointments)
- [adx_communityforumaccesspermission_Appointments](#BKMK_adx_communityforumaccesspermission_Appointments)
- [adx_communityforumalert_Appointments](#BKMK_adx_communityforumalert_Appointments)
- [adx_contentaccesslevel_Appointments](#BKMK_adx_contentaccesslevel_Appointments)
- [adx_poll_Appointments](#BKMK_adx_poll_Appointments)
- [adx_polloption_Appointments](#BKMK_adx_polloption_Appointments)
- [adx_pollplacement_Appointments](#BKMK_adx_pollplacement_Appointments)
- [adx_pollsubmission_Appointments](#BKMK_adx_pollsubmission_Appointments)
- [adx_publishingstatetransitionrule_Appointments](#BKMK_adx_publishingstatetransitionrule_Appointments)
- [adx_redirect_Appointments](#BKMK_adx_redirect_Appointments)
- [adx_shortcut_Appointments](#BKMK_adx_shortcut_Appointments)
- [adx_webpage_Appointments](#BKMK_adx_webpage_Appointments)
- [adx_website_Appointments](#BKMK_adx_website_Appointments)
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
- [msdyn_agreement_Appointments](#BKMK_msdyn_agreement_Appointments)
- [msdyn_agreementbookingdate_Appointments](#BKMK_msdyn_agreementbookingdate_Appointments)
- [msdyn_agreementbookingincident_Appointments](#BKMK_msdyn_agreementbookingincident_Appointments)
- [msdyn_agreementbookingproduct_Appointments](#BKMK_msdyn_agreementbookingproduct_Appointments)
- [msdyn_agreementbookingservice_Appointments](#BKMK_msdyn_agreementbookingservice_Appointments)
- [msdyn_agreementbookingservicetask_Appointments](#BKMK_msdyn_agreementbookingservicetask_Appointments)
- [msdyn_agreementbookingsetup_Appointments](#BKMK_msdyn_agreementbookingsetup_Appointments)
- [msdyn_agreementinvoicedate_Appointments](#BKMK_msdyn_agreementinvoicedate_Appointments)
- [msdyn_agreementinvoiceproduct_Appointments](#BKMK_msdyn_agreementinvoiceproduct_Appointments)
- [msdyn_agreementinvoicesetup_Appointments](#BKMK_msdyn_agreementinvoicesetup_Appointments)
- [msdyn_bookingalertstatus_Appointments](#BKMK_msdyn_bookingalertstatus_Appointments)
- [msdyn_bookingrule_Appointments](#BKMK_msdyn_bookingrule_Appointments)
- [msdyn_bookingtimestamp_Appointments](#BKMK_msdyn_bookingtimestamp_Appointments)
- [msdyn_customerasset_Appointments](#BKMK_msdyn_customerasset_Appointments)
- [msdyn_fieldservicesetting_Appointments](#BKMK_msdyn_fieldservicesetting_Appointments)
- [msdyn_incidenttypecharacteristic_Appointments](#BKMK_msdyn_incidenttypecharacteristic_Appointments)
- [msdyn_incidenttypeproduct_Appointments](#BKMK_msdyn_incidenttypeproduct_Appointments)
- [msdyn_incidenttypeservice_Appointments](#BKMK_msdyn_incidenttypeservice_Appointments)
- [msdyn_inventoryadjustment_Appointments](#BKMK_msdyn_inventoryadjustment_Appointments)
- [msdyn_inventoryadjustmentproduct_Appointments](#BKMK_msdyn_inventoryadjustmentproduct_Appointments)
- [msdyn_inventoryjournal_Appointments](#BKMK_msdyn_inventoryjournal_Appointments)
- [msdyn_inventorytransfer_Appointments](#BKMK_msdyn_inventorytransfer_Appointments)
- [msdyn_payment_Appointments](#BKMK_msdyn_payment_Appointments)
- [msdyn_paymentdetail_Appointments](#BKMK_msdyn_paymentdetail_Appointments)
- [msdyn_paymentmethod_Appointments](#BKMK_msdyn_paymentmethod_Appointments)
- [msdyn_paymentterm_Appointments](#BKMK_msdyn_paymentterm_Appointments)
- [msdyn_playbookinstance_Appointments](#BKMK_msdyn_playbookinstance_Appointments)
- [msdyn_postalbum_Appointments](#BKMK_msdyn_postalbum_Appointments)
- [msdyn_postalcode_Appointments](#BKMK_msdyn_postalcode_Appointments)
- [msdyn_productinventory_Appointments](#BKMK_msdyn_productinventory_Appointments)
- [msdyn_purchaseorder_Appointments](#BKMK_msdyn_purchaseorder_Appointments)
- [msdyn_purchaseorderbill_Appointments](#BKMK_msdyn_purchaseorderbill_Appointments)
- [msdyn_purchaseorderproduct_Appointments](#BKMK_msdyn_purchaseorderproduct_Appointments)
- [msdyn_purchaseorderreceipt_Appointments](#BKMK_msdyn_purchaseorderreceipt_Appointments)
- [msdyn_purchaseorderreceiptproduct_Appointments](#BKMK_msdyn_purchaseorderreceiptproduct_Appointments)
- [msdyn_purchaseordersubstatus_Appointments](#BKMK_msdyn_purchaseordersubstatus_Appointments)
- [msdyn_quotebookingincident_Appointments](#BKMK_msdyn_quotebookingincident_Appointments)
- [msdyn_quotebookingproduct_Appointments](#BKMK_msdyn_quotebookingproduct_Appointments)
- [msdyn_quotebookingservice_Appointments](#BKMK_msdyn_quotebookingservice_Appointments)
- [msdyn_quotebookingservicetask_Appointments](#BKMK_msdyn_quotebookingservicetask_Appointments)
- [msdyn_resourceterritory_Appointments](#BKMK_msdyn_resourceterritory_Appointments)
- [msdyn_rma_Appointments](#BKMK_msdyn_rma_Appointments)
- [msdyn_rmaproduct_Appointments](#BKMK_msdyn_rmaproduct_Appointments)
- [msdyn_rmareceipt_Appointments](#BKMK_msdyn_rmareceipt_Appointments)
- [msdyn_rmareceiptproduct_Appointments](#BKMK_msdyn_rmareceiptproduct_Appointments)
- [msdyn_rmasubstatus_Appointments](#BKMK_msdyn_rmasubstatus_Appointments)
- [msdyn_rtv_Appointments](#BKMK_msdyn_rtv_Appointments)
- [msdyn_rtvproduct_Appointments](#BKMK_msdyn_rtvproduct_Appointments)
- [msdyn_rtvsubstatus_Appointments](#BKMK_msdyn_rtvsubstatus_Appointments)
- [msdyn_salessuggestion_Appointments](#BKMK_msdyn_salessuggestion_Appointments)
- [msdyn_shipvia_Appointments](#BKMK_msdyn_shipvia_Appointments)
- [msdyn_swarm_Appointments](#BKMK_msdyn_swarm_Appointments)
- [msdyn_systemuserschedulersetting_Appointments](#BKMK_msdyn_systemuserschedulersetting_Appointments)
- [msdyn_timegroup_Appointments](#BKMK_msdyn_timegroup_Appointments)
- [msdyn_timegroupdetail_Appointments](#BKMK_msdyn_timegroupdetail_Appointments)
- [msdyn_timeoffrequest_Appointments](#BKMK_msdyn_timeoffrequest_Appointments)
- [msdyn_warehouse_Appointments](#BKMK_msdyn_warehouse_Appointments)
- [msdyn_workorder_Appointments](#BKMK_msdyn_workorder_Appointments)
- [msdyn_workordercharacteristic_Appointments](#BKMK_msdyn_workordercharacteristic_Appointments)
- [msdyn_workorderincident_Appointments](#BKMK_msdyn_workorderincident_Appointments)
- [msdyn_workorderproduct_Appointments](#BKMK_msdyn_workorderproduct_Appointments)
- [msdyn_workorderresourcerestriction_Appointments](#BKMK_msdyn_workorderresourcerestriction_Appointments)
- [msdyn_workorderservice_Appointments](#BKMK_msdyn_workorderservice_Appointments)
- [msdyn_workorderservicetask_Appointments](#BKMK_msdyn_workorderservicetask_Appointments)
- [msdyncrm_contentsettings_Appointments](#BKMK_msdyncrm_contentsettings_Appointments)
- [msdyncrm_customerjourney_Appointments](#BKMK_msdyncrm_customerjourney_Appointments)
- [msdyncrm_leadscoremodel_Appointments](#BKMK_msdyncrm_leadscoremodel_Appointments)
- [msdyncrm_linkedinaccount_Appointments](#BKMK_msdyncrm_linkedinaccount_Appointments)
- [msdyncrm_linkedinactivity_Appointments](#BKMK_msdyncrm_linkedinactivity_Appointments)
- [msdyncrm_linkedinfieldmapping_Appointments](#BKMK_msdyncrm_linkedinfieldmapping_Appointments)
- [msdyncrm_linkedinform_Appointments](#BKMK_msdyncrm_linkedinform_Appointments)
- [msdyncrm_linkedinformanswer_Appointments](#BKMK_msdyncrm_linkedinformanswer_Appointments)
- [msdyncrm_linkedinformquestion_Appointments](#BKMK_msdyncrm_linkedinformquestion_Appointments)
- [msdyncrm_linkedinformsubmission_Appointments](#BKMK_msdyncrm_linkedinformsubmission_Appointments)
- [msdyncrm_linkedinleadmatchingstrategy_Appointments](#BKMK_msdyncrm_linkedinleadmatchingstrategy_Appointments)
- [msdyncrm_linkedinuserprofile_Appointments](#BKMK_msdyncrm_linkedinuserprofile_Appointments)
- [msdyncrm_marketingdynamiccontentmetadata_Appointments](#BKMK_msdyncrm_marketingdynamiccontentmetadata_Appointments)
- [msdyncrm_marketingemaildynamiccontentmetadata_Appointments](#BKMK_msdyncrm_marketingemaildynamiccontentmetadata_Appointments)
- [msdyncrm_marketingemailtestsend_Appointments](#BKMK_msdyncrm_marketingemailtestsend_Appointments)
- [msdyncrm_migration_Appointments](#BKMK_msdyncrm_migration_Appointments)
- [msdyncrm_msdyncrm_customerjourneyiteration_appointment](#BKMK_msdyncrm_msdyncrm_customerjourneyiteration_appointment)
- [msdyncrm_uicconfig_Appointments](#BKMK_msdyncrm_uicconfig_Appointments)
- [msevtmgt_checkin_Appointments](#BKMK_msevtmgt_checkin_Appointments)
- [msevtmgt_event_Appointments](#BKMK_msevtmgt_event_Appointments)
- [msevtmgt_eventpurchase_Appointments](#BKMK_msevtmgt_eventpurchase_Appointments)
- [msevtmgt_eventpurchaseattendee_Appointments](#BKMK_msevtmgt_eventpurchaseattendee_Appointments)
- [msevtmgt_eventpurchasepass_Appointments](#BKMK_msevtmgt_eventpurchasepass_Appointments)
- [msevtmgt_eventregistration_Appointments](#BKMK_msevtmgt_eventregistration_Appointments)
- [msevtmgt_hotel_Appointments](#BKMK_msevtmgt_hotel_Appointments)
- [msevtmgt_hotelroomallocation_Appointments](#BKMK_msevtmgt_hotelroomallocation_Appointments)
- [msevtmgt_hotelroomreservation_Appointments](#BKMK_msevtmgt_hotelroomreservation_Appointments)
- [msevtmgt_layout_Appointments](#BKMK_msevtmgt_layout_Appointments)
- [msevtmgt_room_Appointments](#BKMK_msevtmgt_room_Appointments)
- [msevtmgt_session_Appointments](#BKMK_msevtmgt_session_Appointments)
- [msevtmgt_sessionregistration_Appointments](#BKMK_msevtmgt_sessionregistration_Appointments)
- [msevtmgt_sessiontrack_Appointments](#BKMK_msevtmgt_sessiontrack_Appointments)
- [msevtmgt_speaker_Appointments](#BKMK_msevtmgt_speaker_Appointments)
- [msevtmgt_speakerengagement_Appointments](#BKMK_msevtmgt_speakerengagement_Appointments)
- [msevtmgt_sponsorablearticle_Appointments](#BKMK_msevtmgt_sponsorablearticle_Appointments)
- [msevtmgt_sponsorship_Appointments](#BKMK_msevtmgt_sponsorship_Appointments)
- [msevtmgt_venue_Appointments](#BKMK_msevtmgt_venue_Appointments)
- [msevtmgt_webinarconfiguration_Appointments](#BKMK_msevtmgt_webinarconfiguration_Appointments)
- [msevtmgt_webinarprovider_Appointments](#BKMK_msevtmgt_webinarprovider_Appointments)
- [Opportunity_Appointments](#BKMK_Opportunity_Appointments)
- [Quote_Appointments](#BKMK_Quote_Appointments)
- [SalesOrder_Appointments](#BKMK_SalesOrder_Appointments)
- [service_appointments](#BKMK_service_appointments)
- [site_Appointments](#BKMK_site_Appointments)

### <a name="BKMK_adx_ad_Appointments"></a> adx_ad_Appointments

One-To-Many Relationship: [adx_ad adx_ad_Appointments](adx_ad.md#BKMK_adx_ad_Appointments)

|Property|Value|
|---|---|
|ReferencedEntity|`adx_ad`|
|ReferencedAttribute|`adx_adid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_adx_ad_appointment`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_adx_adplacement_Appointments"></a> adx_adplacement_Appointments

One-To-Many Relationship: [adx_adplacement adx_adplacement_Appointments](adx_adplacement.md#BKMK_adx_adplacement_Appointments)

|Property|Value|
|---|---|
|ReferencedEntity|`adx_adplacement`|
|ReferencedAttribute|`adx_adplacementid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_adx_adplacement_appointment`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_adx_casedeflection_Appointments"></a> adx_casedeflection_Appointments

One-To-Many Relationship: [adx_casedeflection adx_casedeflection_Appointments](adx_casedeflection.md#BKMK_adx_casedeflection_Appointments)

|Property|Value|
|---|---|
|ReferencedEntity|`adx_casedeflection`|
|ReferencedAttribute|`adx_casedeflectionid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_adx_casedeflection_appointment`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_adx_communityforumaccesspermission_Appointments"></a> adx_communityforumaccesspermission_Appointments

One-To-Many Relationship: [adx_communityforumaccesspermission adx_communityforumaccesspermission_Appointments](adx_communityforumaccesspermission.md#BKMK_adx_communityforumaccesspermission_Appointments)

|Property|Value|
|---|---|
|ReferencedEntity|`adx_communityforumaccesspermission`|
|ReferencedAttribute|`adx_communityforumaccesspermissionid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_adx_communityforumaccesspermission_appointment`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_adx_communityforumalert_Appointments"></a> adx_communityforumalert_Appointments

One-To-Many Relationship: [adx_communityforumalert adx_communityforumalert_Appointments](adx_communityforumalert.md#BKMK_adx_communityforumalert_Appointments)

|Property|Value|
|---|---|
|ReferencedEntity|`adx_communityforumalert`|
|ReferencedAttribute|`adx_communityforumalertid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_adx_communityforumalert_appointment`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_adx_contentaccesslevel_Appointments"></a> adx_contentaccesslevel_Appointments

One-To-Many Relationship: [adx_contentaccesslevel adx_contentaccesslevel_Appointments](adx_contentaccesslevel.md#BKMK_adx_contentaccesslevel_Appointments)

|Property|Value|
|---|---|
|ReferencedEntity|`adx_contentaccesslevel`|
|ReferencedAttribute|`adx_contentaccesslevelid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_adx_contentaccesslevel_appointment`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_adx_poll_Appointments"></a> adx_poll_Appointments

One-To-Many Relationship: [adx_poll adx_poll_Appointments](adx_poll.md#BKMK_adx_poll_Appointments)

|Property|Value|
|---|---|
|ReferencedEntity|`adx_poll`|
|ReferencedAttribute|`adx_pollid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_adx_poll_appointment`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_adx_polloption_Appointments"></a> adx_polloption_Appointments

One-To-Many Relationship: [adx_polloption adx_polloption_Appointments](adx_polloption.md#BKMK_adx_polloption_Appointments)

|Property|Value|
|---|---|
|ReferencedEntity|`adx_polloption`|
|ReferencedAttribute|`adx_polloptionid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_adx_polloption_appointment`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_adx_pollplacement_Appointments"></a> adx_pollplacement_Appointments

One-To-Many Relationship: [adx_pollplacement adx_pollplacement_Appointments](adx_pollplacement.md#BKMK_adx_pollplacement_Appointments)

|Property|Value|
|---|---|
|ReferencedEntity|`adx_pollplacement`|
|ReferencedAttribute|`adx_pollplacementid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_adx_pollplacement_appointment`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_adx_pollsubmission_Appointments"></a> adx_pollsubmission_Appointments

One-To-Many Relationship: [adx_pollsubmission adx_pollsubmission_Appointments](adx_pollsubmission.md#BKMK_adx_pollsubmission_Appointments)

|Property|Value|
|---|---|
|ReferencedEntity|`adx_pollsubmission`|
|ReferencedAttribute|`adx_pollsubmissionid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_adx_pollsubmission_appointment`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_adx_publishingstatetransitionrule_Appointments"></a> adx_publishingstatetransitionrule_Appointments

One-To-Many Relationship: [adx_publishingstatetransitionrule adx_publishingstatetransitionrule_Appointments](adx_publishingstatetransitionrule.md#BKMK_adx_publishingstatetransitionrule_Appointments)

|Property|Value|
|---|---|
|ReferencedEntity|`adx_publishingstatetransitionrule`|
|ReferencedAttribute|`adx_publishingstatetransitionruleid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_adx_publishingstatetransitionrule_appointment`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_adx_redirect_Appointments"></a> adx_redirect_Appointments

One-To-Many Relationship: [adx_redirect adx_redirect_Appointments](adx_redirect.md#BKMK_adx_redirect_Appointments)

|Property|Value|
|---|---|
|ReferencedEntity|`adx_redirect`|
|ReferencedAttribute|`adx_redirectid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_adx_redirect_appointment`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_adx_shortcut_Appointments"></a> adx_shortcut_Appointments

One-To-Many Relationship: [adx_shortcut adx_shortcut_Appointments](adx_shortcut.md#BKMK_adx_shortcut_Appointments)

|Property|Value|
|---|---|
|ReferencedEntity|`adx_shortcut`|
|ReferencedAttribute|`adx_shortcutid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_adx_shortcut_appointment`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_adx_webpage_Appointments"></a> adx_webpage_Appointments

One-To-Many Relationship: [adx_webpage adx_webpage_Appointments](adx_webpage.md#BKMK_adx_webpage_Appointments)

|Property|Value|
|---|---|
|ReferencedEntity|`adx_webpage`|
|ReferencedAttribute|`adx_webpageid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_adx_webpage_appointment`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_adx_website_Appointments"></a> adx_website_Appointments

One-To-Many Relationship: [adx_website adx_website_Appointments](adx_website.md#BKMK_adx_website_Appointments)

|Property|Value|
|---|---|
|ReferencedEntity|`adx_website`|
|ReferencedAttribute|`adx_websiteid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_adx_website_appointment`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

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

### <a name="BKMK_msdyn_agreement_Appointments"></a> msdyn_agreement_Appointments

One-To-Many Relationship: [msdyn_agreement msdyn_agreement_Appointments](msdyn_agreement.md#BKMK_msdyn_agreement_Appointments)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_agreement`|
|ReferencedAttribute|`msdyn_agreementid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_agreement_appointment`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_agreementbookingdate_Appointments"></a> msdyn_agreementbookingdate_Appointments

One-To-Many Relationship: [msdyn_agreementbookingdate msdyn_agreementbookingdate_Appointments](msdyn_agreementbookingdate.md#BKMK_msdyn_agreementbookingdate_Appointments)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_agreementbookingdate`|
|ReferencedAttribute|`msdyn_agreementbookingdateid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_agreementbookingdate_appointment`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_agreementbookingincident_Appointments"></a> msdyn_agreementbookingincident_Appointments

One-To-Many Relationship: [msdyn_agreementbookingincident msdyn_agreementbookingincident_Appointments](msdyn_agreementbookingincident.md#BKMK_msdyn_agreementbookingincident_Appointments)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_agreementbookingincident`|
|ReferencedAttribute|`msdyn_agreementbookingincidentid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_agreementbookingincident_appointment`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_agreementbookingproduct_Appointments"></a> msdyn_agreementbookingproduct_Appointments

One-To-Many Relationship: [msdyn_agreementbookingproduct msdyn_agreementbookingproduct_Appointments](msdyn_agreementbookingproduct.md#BKMK_msdyn_agreementbookingproduct_Appointments)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_agreementbookingproduct`|
|ReferencedAttribute|`msdyn_agreementbookingproductid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_agreementbookingproduct_appointment`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_agreementbookingservice_Appointments"></a> msdyn_agreementbookingservice_Appointments

One-To-Many Relationship: [msdyn_agreementbookingservice msdyn_agreementbookingservice_Appointments](msdyn_agreementbookingservice.md#BKMK_msdyn_agreementbookingservice_Appointments)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_agreementbookingservice`|
|ReferencedAttribute|`msdyn_agreementbookingserviceid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_agreementbookingservice_appointment`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_agreementbookingservicetask_Appointments"></a> msdyn_agreementbookingservicetask_Appointments

One-To-Many Relationship: [msdyn_agreementbookingservicetask msdyn_agreementbookingservicetask_Appointments](msdyn_agreementbookingservicetask.md#BKMK_msdyn_agreementbookingservicetask_Appointments)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_agreementbookingservicetask`|
|ReferencedAttribute|`msdyn_agreementbookingservicetaskid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_agreementbookingservicetask_appointment`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_agreementbookingsetup_Appointments"></a> msdyn_agreementbookingsetup_Appointments

One-To-Many Relationship: [msdyn_agreementbookingsetup msdyn_agreementbookingsetup_Appointments](msdyn_agreementbookingsetup.md#BKMK_msdyn_agreementbookingsetup_Appointments)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_agreementbookingsetup`|
|ReferencedAttribute|`msdyn_agreementbookingsetupid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_agreementbookingsetup_appointment`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_agreementinvoicedate_Appointments"></a> msdyn_agreementinvoicedate_Appointments

One-To-Many Relationship: [msdyn_agreementinvoicedate msdyn_agreementinvoicedate_Appointments](msdyn_agreementinvoicedate.md#BKMK_msdyn_agreementinvoicedate_Appointments)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_agreementinvoicedate`|
|ReferencedAttribute|`msdyn_agreementinvoicedateid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_agreementinvoicedate_appointment`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_agreementinvoiceproduct_Appointments"></a> msdyn_agreementinvoiceproduct_Appointments

One-To-Many Relationship: [msdyn_agreementinvoiceproduct msdyn_agreementinvoiceproduct_Appointments](msdyn_agreementinvoiceproduct.md#BKMK_msdyn_agreementinvoiceproduct_Appointments)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_agreementinvoiceproduct`|
|ReferencedAttribute|`msdyn_agreementinvoiceproductid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_agreementinvoiceproduct_appointment`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_agreementinvoicesetup_Appointments"></a> msdyn_agreementinvoicesetup_Appointments

One-To-Many Relationship: [msdyn_agreementinvoicesetup msdyn_agreementinvoicesetup_Appointments](msdyn_agreementinvoicesetup.md#BKMK_msdyn_agreementinvoicesetup_Appointments)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_agreementinvoicesetup`|
|ReferencedAttribute|`msdyn_agreementinvoicesetupid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_agreementinvoicesetup_appointment`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_bookingalertstatus_Appointments"></a> msdyn_bookingalertstatus_Appointments

One-To-Many Relationship: [msdyn_bookingalertstatus msdyn_bookingalertstatus_Appointments](msdyn_bookingalertstatus.md#BKMK_msdyn_bookingalertstatus_Appointments)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_bookingalertstatus`|
|ReferencedAttribute|`msdyn_bookingalertstatusid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_bookingalertstatus_appointment`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_bookingrule_Appointments"></a> msdyn_bookingrule_Appointments

One-To-Many Relationship: [msdyn_bookingrule msdyn_bookingrule_Appointments](msdyn_bookingrule.md#BKMK_msdyn_bookingrule_Appointments)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_bookingrule`|
|ReferencedAttribute|`msdyn_bookingruleid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_bookingrule_appointment`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_bookingtimestamp_Appointments"></a> msdyn_bookingtimestamp_Appointments

One-To-Many Relationship: [msdyn_bookingtimestamp msdyn_bookingtimestamp_Appointments](msdyn_bookingtimestamp.md#BKMK_msdyn_bookingtimestamp_Appointments)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_bookingtimestamp`|
|ReferencedAttribute|`msdyn_bookingtimestampid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_bookingtimestamp_appointment`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

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

### <a name="BKMK_msdyn_fieldservicesetting_Appointments"></a> msdyn_fieldservicesetting_Appointments

One-To-Many Relationship: [msdyn_fieldservicesetting msdyn_fieldservicesetting_Appointments](msdyn_fieldservicesetting.md#BKMK_msdyn_fieldservicesetting_Appointments)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_fieldservicesetting`|
|ReferencedAttribute|`msdyn_fieldservicesettingid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_fieldservicesetting_appointment`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_incidenttypecharacteristic_Appointments"></a> msdyn_incidenttypecharacteristic_Appointments

One-To-Many Relationship: [msdyn_incidenttypecharacteristic msdyn_incidenttypecharacteristic_Appointments](msdyn_incidenttypecharacteristic.md#BKMK_msdyn_incidenttypecharacteristic_Appointments)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_incidenttypecharacteristic`|
|ReferencedAttribute|`msdyn_incidenttypecharacteristicid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_incidenttypecharacteristic_appointment`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_incidenttypeproduct_Appointments"></a> msdyn_incidenttypeproduct_Appointments

One-To-Many Relationship: [msdyn_incidenttypeproduct msdyn_incidenttypeproduct_Appointments](msdyn_incidenttypeproduct.md#BKMK_msdyn_incidenttypeproduct_Appointments)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_incidenttypeproduct`|
|ReferencedAttribute|`msdyn_incidenttypeproductid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_incidenttypeproduct_appointment`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_incidenttypeservice_Appointments"></a> msdyn_incidenttypeservice_Appointments

One-To-Many Relationship: [msdyn_incidenttypeservice msdyn_incidenttypeservice_Appointments](msdyn_incidenttypeservice.md#BKMK_msdyn_incidenttypeservice_Appointments)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_incidenttypeservice`|
|ReferencedAttribute|`msdyn_incidenttypeserviceid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_incidenttypeservice_appointment`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_inventoryadjustment_Appointments"></a> msdyn_inventoryadjustment_Appointments

One-To-Many Relationship: [msdyn_inventoryadjustment msdyn_inventoryadjustment_Appointments](msdyn_inventoryadjustment.md#BKMK_msdyn_inventoryadjustment_Appointments)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_inventoryadjustment`|
|ReferencedAttribute|`msdyn_inventoryadjustmentid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_inventoryadjustment_appointment`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_inventoryadjustmentproduct_Appointments"></a> msdyn_inventoryadjustmentproduct_Appointments

One-To-Many Relationship: [msdyn_inventoryadjustmentproduct msdyn_inventoryadjustmentproduct_Appointments](msdyn_inventoryadjustmentproduct.md#BKMK_msdyn_inventoryadjustmentproduct_Appointments)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_inventoryadjustmentproduct`|
|ReferencedAttribute|`msdyn_inventoryadjustmentproductid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_inventoryadjustmentproduct_appointment`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_inventoryjournal_Appointments"></a> msdyn_inventoryjournal_Appointments

One-To-Many Relationship: [msdyn_inventoryjournal msdyn_inventoryjournal_Appointments](msdyn_inventoryjournal.md#BKMK_msdyn_inventoryjournal_Appointments)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_inventoryjournal`|
|ReferencedAttribute|`msdyn_inventoryjournalid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_inventoryjournal_appointment`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_inventorytransfer_Appointments"></a> msdyn_inventorytransfer_Appointments

One-To-Many Relationship: [msdyn_inventorytransfer msdyn_inventorytransfer_Appointments](msdyn_inventorytransfer.md#BKMK_msdyn_inventorytransfer_Appointments)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_inventorytransfer`|
|ReferencedAttribute|`msdyn_inventorytransferid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_inventorytransfer_appointment`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_payment_Appointments"></a> msdyn_payment_Appointments

One-To-Many Relationship: [msdyn_payment msdyn_payment_Appointments](msdyn_payment.md#BKMK_msdyn_payment_Appointments)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_payment`|
|ReferencedAttribute|`msdyn_paymentid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_payment_appointment`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_paymentdetail_Appointments"></a> msdyn_paymentdetail_Appointments

One-To-Many Relationship: [msdyn_paymentdetail msdyn_paymentdetail_Appointments](msdyn_paymentdetail.md#BKMK_msdyn_paymentdetail_Appointments)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_paymentdetail`|
|ReferencedAttribute|`msdyn_paymentdetailid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_paymentdetail_appointment`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_paymentmethod_Appointments"></a> msdyn_paymentmethod_Appointments

One-To-Many Relationship: [msdyn_paymentmethod msdyn_paymentmethod_Appointments](msdyn_paymentmethod.md#BKMK_msdyn_paymentmethod_Appointments)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_paymentmethod`|
|ReferencedAttribute|`msdyn_paymentmethodid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_paymentmethod_appointment`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_paymentterm_Appointments"></a> msdyn_paymentterm_Appointments

One-To-Many Relationship: [msdyn_paymentterm msdyn_paymentterm_Appointments](msdyn_paymentterm.md#BKMK_msdyn_paymentterm_Appointments)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_paymentterm`|
|ReferencedAttribute|`msdyn_paymenttermid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_paymentterm_appointment`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_playbookinstance_Appointments"></a> msdyn_playbookinstance_Appointments

One-To-Many Relationship: [msdyn_playbookinstance msdyn_playbookinstance_Appointments](msdyn_playbookinstance.md#BKMK_msdyn_playbookinstance_Appointments)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_playbookinstance`|
|ReferencedAttribute|`msdyn_playbookinstanceid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_playbookinstance_appointment`|
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

### <a name="BKMK_msdyn_postalcode_Appointments"></a> msdyn_postalcode_Appointments

One-To-Many Relationship: [msdyn_postalcode msdyn_postalcode_Appointments](msdyn_postalcode.md#BKMK_msdyn_postalcode_Appointments)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_postalcode`|
|ReferencedAttribute|`msdyn_postalcodeid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_postalcode_appointment`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_productinventory_Appointments"></a> msdyn_productinventory_Appointments

One-To-Many Relationship: [msdyn_productinventory msdyn_productinventory_Appointments](msdyn_productinventory.md#BKMK_msdyn_productinventory_Appointments)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_productinventory`|
|ReferencedAttribute|`msdyn_productinventoryid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_productinventory_appointment`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_purchaseorder_Appointments"></a> msdyn_purchaseorder_Appointments

One-To-Many Relationship: [msdyn_purchaseorder msdyn_purchaseorder_Appointments](msdyn_purchaseorder.md#BKMK_msdyn_purchaseorder_Appointments)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_purchaseorder`|
|ReferencedAttribute|`msdyn_purchaseorderid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_purchaseorder_appointment`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_purchaseorderbill_Appointments"></a> msdyn_purchaseorderbill_Appointments

One-To-Many Relationship: [msdyn_purchaseorderbill msdyn_purchaseorderbill_Appointments](msdyn_purchaseorderbill.md#BKMK_msdyn_purchaseorderbill_Appointments)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_purchaseorderbill`|
|ReferencedAttribute|`msdyn_purchaseorderbillid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_purchaseorderbill_appointment`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_purchaseorderproduct_Appointments"></a> msdyn_purchaseorderproduct_Appointments

One-To-Many Relationship: [msdyn_purchaseorderproduct msdyn_purchaseorderproduct_Appointments](msdyn_purchaseorderproduct.md#BKMK_msdyn_purchaseorderproduct_Appointments)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_purchaseorderproduct`|
|ReferencedAttribute|`msdyn_purchaseorderproductid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_purchaseorderproduct_appointment`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_purchaseorderreceipt_Appointments"></a> msdyn_purchaseorderreceipt_Appointments

One-To-Many Relationship: [msdyn_purchaseorderreceipt msdyn_purchaseorderreceipt_Appointments](msdyn_purchaseorderreceipt.md#BKMK_msdyn_purchaseorderreceipt_Appointments)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_purchaseorderreceipt`|
|ReferencedAttribute|`msdyn_purchaseorderreceiptid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_purchaseorderreceipt_appointment`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_purchaseorderreceiptproduct_Appointments"></a> msdyn_purchaseorderreceiptproduct_Appointments

One-To-Many Relationship: [msdyn_purchaseorderreceiptproduct msdyn_purchaseorderreceiptproduct_Appointments](msdyn_purchaseorderreceiptproduct.md#BKMK_msdyn_purchaseorderreceiptproduct_Appointments)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_purchaseorderreceiptproduct`|
|ReferencedAttribute|`msdyn_purchaseorderreceiptproductid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_purchaseorderreceiptproduct_appointment`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_purchaseordersubstatus_Appointments"></a> msdyn_purchaseordersubstatus_Appointments

One-To-Many Relationship: [msdyn_purchaseordersubstatus msdyn_purchaseordersubstatus_Appointments](msdyn_purchaseordersubstatus.md#BKMK_msdyn_purchaseordersubstatus_Appointments)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_purchaseordersubstatus`|
|ReferencedAttribute|`msdyn_purchaseordersubstatusid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_purchaseordersubstatus_appointment`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_quotebookingincident_Appointments"></a> msdyn_quotebookingincident_Appointments

One-To-Many Relationship: [msdyn_quotebookingincident msdyn_quotebookingincident_Appointments](msdyn_quotebookingincident.md#BKMK_msdyn_quotebookingincident_Appointments)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_quotebookingincident`|
|ReferencedAttribute|`msdyn_quotebookingincidentid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_quotebookingincident_appointment`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_quotebookingproduct_Appointments"></a> msdyn_quotebookingproduct_Appointments

One-To-Many Relationship: [msdyn_quotebookingproduct msdyn_quotebookingproduct_Appointments](msdyn_quotebookingproduct.md#BKMK_msdyn_quotebookingproduct_Appointments)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_quotebookingproduct`|
|ReferencedAttribute|`msdyn_quotebookingproductid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_quotebookingproduct_appointment`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_quotebookingservice_Appointments"></a> msdyn_quotebookingservice_Appointments

One-To-Many Relationship: [msdyn_quotebookingservice msdyn_quotebookingservice_Appointments](msdyn_quotebookingservice.md#BKMK_msdyn_quotebookingservice_Appointments)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_quotebookingservice`|
|ReferencedAttribute|`msdyn_quotebookingserviceid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_quotebookingservice_appointment`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_quotebookingservicetask_Appointments"></a> msdyn_quotebookingservicetask_Appointments

One-To-Many Relationship: [msdyn_quotebookingservicetask msdyn_quotebookingservicetask_Appointments](msdyn_quotebookingservicetask.md#BKMK_msdyn_quotebookingservicetask_Appointments)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_quotebookingservicetask`|
|ReferencedAttribute|`msdyn_quotebookingservicetaskid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_quotebookingservicetask_appointment`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_resourceterritory_Appointments"></a> msdyn_resourceterritory_Appointments

One-To-Many Relationship: [msdyn_resourceterritory msdyn_resourceterritory_Appointments](msdyn_resourceterritory.md#BKMK_msdyn_resourceterritory_Appointments)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_resourceterritory`|
|ReferencedAttribute|`msdyn_resourceterritoryid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_resourceterritory_appointment`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_rma_Appointments"></a> msdyn_rma_Appointments

One-To-Many Relationship: [msdyn_rma msdyn_rma_Appointments](msdyn_rma.md#BKMK_msdyn_rma_Appointments)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_rma`|
|ReferencedAttribute|`msdyn_rmaid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_rma_appointment`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_rmaproduct_Appointments"></a> msdyn_rmaproduct_Appointments

One-To-Many Relationship: [msdyn_rmaproduct msdyn_rmaproduct_Appointments](msdyn_rmaproduct.md#BKMK_msdyn_rmaproduct_Appointments)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_rmaproduct`|
|ReferencedAttribute|`msdyn_rmaproductid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_rmaproduct_appointment`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_rmareceipt_Appointments"></a> msdyn_rmareceipt_Appointments

One-To-Many Relationship: [msdyn_rmareceipt msdyn_rmareceipt_Appointments](msdyn_rmareceipt.md#BKMK_msdyn_rmareceipt_Appointments)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_rmareceipt`|
|ReferencedAttribute|`msdyn_rmareceiptid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_rmareceipt_appointment`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_rmareceiptproduct_Appointments"></a> msdyn_rmareceiptproduct_Appointments

One-To-Many Relationship: [msdyn_rmareceiptproduct msdyn_rmareceiptproduct_Appointments](msdyn_rmareceiptproduct.md#BKMK_msdyn_rmareceiptproduct_Appointments)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_rmareceiptproduct`|
|ReferencedAttribute|`msdyn_rmareceiptproductid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_rmareceiptproduct_appointment`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_rmasubstatus_Appointments"></a> msdyn_rmasubstatus_Appointments

One-To-Many Relationship: [msdyn_rmasubstatus msdyn_rmasubstatus_Appointments](msdyn_rmasubstatus.md#BKMK_msdyn_rmasubstatus_Appointments)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_rmasubstatus`|
|ReferencedAttribute|`msdyn_rmasubstatusid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_rmasubstatus_appointment`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_rtv_Appointments"></a> msdyn_rtv_Appointments

One-To-Many Relationship: [msdyn_rtv msdyn_rtv_Appointments](msdyn_rtv.md#BKMK_msdyn_rtv_Appointments)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_rtv`|
|ReferencedAttribute|`msdyn_rtvid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_rtv_appointment`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_rtvproduct_Appointments"></a> msdyn_rtvproduct_Appointments

One-To-Many Relationship: [msdyn_rtvproduct msdyn_rtvproduct_Appointments](msdyn_rtvproduct.md#BKMK_msdyn_rtvproduct_Appointments)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_rtvproduct`|
|ReferencedAttribute|`msdyn_rtvproductid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_rtvproduct_appointment`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_rtvsubstatus_Appointments"></a> msdyn_rtvsubstatus_Appointments

One-To-Many Relationship: [msdyn_rtvsubstatus msdyn_rtvsubstatus_Appointments](msdyn_rtvsubstatus.md#BKMK_msdyn_rtvsubstatus_Appointments)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_rtvsubstatus`|
|ReferencedAttribute|`msdyn_rtvsubstatusid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_rtvsubstatus_appointment`|
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

### <a name="BKMK_msdyn_shipvia_Appointments"></a> msdyn_shipvia_Appointments

One-To-Many Relationship: [msdyn_shipvia msdyn_shipvia_Appointments](msdyn_shipvia.md#BKMK_msdyn_shipvia_Appointments)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_shipvia`|
|ReferencedAttribute|`msdyn_shipviaid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_shipvia_appointment`|
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

### <a name="BKMK_msdyn_systemuserschedulersetting_Appointments"></a> msdyn_systemuserschedulersetting_Appointments

One-To-Many Relationship: [msdyn_systemuserschedulersetting msdyn_systemuserschedulersetting_Appointments](msdyn_systemuserschedulersetting.md#BKMK_msdyn_systemuserschedulersetting_Appointments)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_systemuserschedulersetting`|
|ReferencedAttribute|`msdyn_systemuserschedulersettingid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_systemuserschedulersetting_appointment`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_timegroup_Appointments"></a> msdyn_timegroup_Appointments

One-To-Many Relationship: [msdyn_timegroup msdyn_timegroup_Appointments](msdyn_timegroup.md#BKMK_msdyn_timegroup_Appointments)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_timegroup`|
|ReferencedAttribute|`msdyn_timegroupid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_timegroup_appointment`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_timegroupdetail_Appointments"></a> msdyn_timegroupdetail_Appointments

One-To-Many Relationship: [msdyn_timegroupdetail msdyn_timegroupdetail_Appointments](msdyn_timegroupdetail.md#BKMK_msdyn_timegroupdetail_Appointments)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_timegroupdetail`|
|ReferencedAttribute|`msdyn_timegroupdetailid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_timegroupdetail_appointment`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_timeoffrequest_Appointments"></a> msdyn_timeoffrequest_Appointments

One-To-Many Relationship: [msdyn_timeoffrequest msdyn_timeoffrequest_Appointments](msdyn_timeoffrequest.md#BKMK_msdyn_timeoffrequest_Appointments)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_timeoffrequest`|
|ReferencedAttribute|`msdyn_timeoffrequestid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_timeoffrequest_appointment`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_warehouse_Appointments"></a> msdyn_warehouse_Appointments

One-To-Many Relationship: [msdyn_warehouse msdyn_warehouse_Appointments](msdyn_warehouse.md#BKMK_msdyn_warehouse_Appointments)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_warehouse`|
|ReferencedAttribute|`msdyn_warehouseid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_warehouse_appointment`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_workorder_Appointments"></a> msdyn_workorder_Appointments

One-To-Many Relationship: [msdyn_workorder msdyn_workorder_Appointments](msdyn_workorder.md#BKMK_msdyn_workorder_Appointments)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_workorder`|
|ReferencedAttribute|`msdyn_workorderid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_workorder_appointment`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_workordercharacteristic_Appointments"></a> msdyn_workordercharacteristic_Appointments

One-To-Many Relationship: [msdyn_workordercharacteristic msdyn_workordercharacteristic_Appointments](msdyn_workordercharacteristic.md#BKMK_msdyn_workordercharacteristic_Appointments)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_workordercharacteristic`|
|ReferencedAttribute|`msdyn_workordercharacteristicid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_workordercharacteristic_appointment`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_workorderincident_Appointments"></a> msdyn_workorderincident_Appointments

One-To-Many Relationship: [msdyn_workorderincident msdyn_workorderincident_Appointments](msdyn_workorderincident.md#BKMK_msdyn_workorderincident_Appointments)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_workorderincident`|
|ReferencedAttribute|`msdyn_workorderincidentid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_workorderincident_appointment`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_workorderproduct_Appointments"></a> msdyn_workorderproduct_Appointments

One-To-Many Relationship: [msdyn_workorderproduct msdyn_workorderproduct_Appointments](msdyn_workorderproduct.md#BKMK_msdyn_workorderproduct_Appointments)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_workorderproduct`|
|ReferencedAttribute|`msdyn_workorderproductid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_workorderproduct_appointment`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_workorderresourcerestriction_Appointments"></a> msdyn_workorderresourcerestriction_Appointments

One-To-Many Relationship: [msdyn_workorderresourcerestriction msdyn_workorderresourcerestriction_Appointments](msdyn_workorderresourcerestriction.md#BKMK_msdyn_workorderresourcerestriction_Appointments)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_workorderresourcerestriction`|
|ReferencedAttribute|`msdyn_workorderresourcerestrictionid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_workorderresourcerestriction_appointment`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_workorderservice_Appointments"></a> msdyn_workorderservice_Appointments

One-To-Many Relationship: [msdyn_workorderservice msdyn_workorderservice_Appointments](msdyn_workorderservice.md#BKMK_msdyn_workorderservice_Appointments)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_workorderservice`|
|ReferencedAttribute|`msdyn_workorderserviceid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_workorderservice_appointment`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_workorderservicetask_Appointments"></a> msdyn_workorderservicetask_Appointments

One-To-Many Relationship: [msdyn_workorderservicetask msdyn_workorderservicetask_Appointments](msdyn_workorderservicetask.md#BKMK_msdyn_workorderservicetask_Appointments)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_workorderservicetask`|
|ReferencedAttribute|`msdyn_workorderservicetaskid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_workorderservicetask_appointment`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyncrm_contentsettings_Appointments"></a> msdyncrm_contentsettings_Appointments

One-To-Many Relationship: [msdyncrm_contentsettings msdyncrm_contentsettings_Appointments](msdyncrm_contentsettings.md#BKMK_msdyncrm_contentsettings_Appointments)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyncrm_contentsettings`|
|ReferencedAttribute|`msdyncrm_contentsettingsid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyncrm_contentsettings_appointment`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyncrm_customerjourney_Appointments"></a> msdyncrm_customerjourney_Appointments

One-To-Many Relationship: [msdyncrm_customerjourney msdyncrm_customerjourney_Appointments](msdyncrm_customerjourney.md#BKMK_msdyncrm_customerjourney_Appointments)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyncrm_customerjourney`|
|ReferencedAttribute|`msdyncrm_customerjourneyid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyncrm_customerjourney_appointment`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyncrm_leadscoremodel_Appointments"></a> msdyncrm_leadscoremodel_Appointments

One-To-Many Relationship: [msdyncrm_leadscoremodel msdyncrm_leadscoremodel_Appointments](msdyncrm_leadscoremodel.md#BKMK_msdyncrm_leadscoremodel_Appointments)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyncrm_leadscoremodel`|
|ReferencedAttribute|`msdyncrm_leadscoremodelid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyncrm_leadscoremodel_appointment`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyncrm_linkedinaccount_Appointments"></a> msdyncrm_linkedinaccount_Appointments

One-To-Many Relationship: [msdyncrm_linkedinaccount msdyncrm_linkedinaccount_Appointments](msdyncrm_linkedinaccount.md#BKMK_msdyncrm_linkedinaccount_Appointments)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyncrm_linkedinaccount`|
|ReferencedAttribute|`msdyncrm_linkedinaccountid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyncrm_linkedinaccount_appointment`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyncrm_linkedinactivity_Appointments"></a> msdyncrm_linkedinactivity_Appointments

One-To-Many Relationship: [msdyncrm_linkedinactivity msdyncrm_linkedinactivity_Appointments](msdyncrm_linkedinactivity.md#BKMK_msdyncrm_linkedinactivity_Appointments)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyncrm_linkedinactivity`|
|ReferencedAttribute|`msdyncrm_linkedinactivityid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyncrm_linkedinactivity_appointment`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyncrm_linkedinfieldmapping_Appointments"></a> msdyncrm_linkedinfieldmapping_Appointments

One-To-Many Relationship: [msdyncrm_linkedinfieldmapping msdyncrm_linkedinfieldmapping_Appointments](msdyncrm_linkedinfieldmapping.md#BKMK_msdyncrm_linkedinfieldmapping_Appointments)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyncrm_linkedinfieldmapping`|
|ReferencedAttribute|`msdyncrm_linkedinfieldmappingid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyncrm_linkedinfieldmapping_appointment`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyncrm_linkedinform_Appointments"></a> msdyncrm_linkedinform_Appointments

One-To-Many Relationship: [msdyncrm_linkedinform msdyncrm_linkedinform_Appointments](msdyncrm_linkedinform.md#BKMK_msdyncrm_linkedinform_Appointments)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyncrm_linkedinform`|
|ReferencedAttribute|`msdyncrm_linkedinformid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyncrm_linkedinform_appointment`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyncrm_linkedinformanswer_Appointments"></a> msdyncrm_linkedinformanswer_Appointments

One-To-Many Relationship: [msdyncrm_linkedinformanswer msdyncrm_linkedinformanswer_Appointments](msdyncrm_linkedinformanswer.md#BKMK_msdyncrm_linkedinformanswer_Appointments)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyncrm_linkedinformanswer`|
|ReferencedAttribute|`msdyncrm_linkedinformanswerid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyncrm_linkedinformanswer_appointment`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyncrm_linkedinformquestion_Appointments"></a> msdyncrm_linkedinformquestion_Appointments

One-To-Many Relationship: [msdyncrm_linkedinformquestion msdyncrm_linkedinformquestion_Appointments](msdyncrm_linkedinformquestion.md#BKMK_msdyncrm_linkedinformquestion_Appointments)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyncrm_linkedinformquestion`|
|ReferencedAttribute|`msdyncrm_linkedinformquestionid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyncrm_linkedinformquestion_appointment`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyncrm_linkedinformsubmission_Appointments"></a> msdyncrm_linkedinformsubmission_Appointments

One-To-Many Relationship: [msdyncrm_linkedinformsubmission msdyncrm_linkedinformsubmission_Appointments](msdyncrm_linkedinformsubmission.md#BKMK_msdyncrm_linkedinformsubmission_Appointments)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyncrm_linkedinformsubmission`|
|ReferencedAttribute|`msdyncrm_linkedinformsubmissionid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyncrm_linkedinformsubmission_appointment`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyncrm_linkedinleadmatchingstrategy_Appointments"></a> msdyncrm_linkedinleadmatchingstrategy_Appointments

One-To-Many Relationship: [msdyncrm_linkedinleadmatchingstrategy msdyncrm_linkedinleadmatchingstrategy_Appointments](msdyncrm_linkedinleadmatchingstrategy.md#BKMK_msdyncrm_linkedinleadmatchingstrategy_Appointments)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyncrm_linkedinleadmatchingstrategy`|
|ReferencedAttribute|`msdyncrm_linkedinleadmatchingstrategyid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyncrm_linkedinleadmatchingstrategy_appointment`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyncrm_linkedinuserprofile_Appointments"></a> msdyncrm_linkedinuserprofile_Appointments

One-To-Many Relationship: [msdyncrm_linkedinuserprofile msdyncrm_linkedinuserprofile_Appointments](msdyncrm_linkedinuserprofile.md#BKMK_msdyncrm_linkedinuserprofile_Appointments)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyncrm_linkedinuserprofile`|
|ReferencedAttribute|`msdyncrm_linkedinuserprofileid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyncrm_linkedinuserprofile_appointment`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyncrm_marketingdynamiccontentmetadata_Appointments"></a> msdyncrm_marketingdynamiccontentmetadata_Appointments

One-To-Many Relationship: [msdyncrm_marketingdynamiccontentmetadata msdyncrm_marketingdynamiccontentmetadata_Appointments](msdyncrm_marketingdynamiccontentmetadata.md#BKMK_msdyncrm_marketingdynamiccontentmetadata_Appointments)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyncrm_marketingdynamiccontentmetadata`|
|ReferencedAttribute|`msdyncrm_marketingdynamiccontentmetadataid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyncrm_marketingdynamiccontentmetadata_appointment`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyncrm_marketingemaildynamiccontentmetadata_Appointments"></a> msdyncrm_marketingemaildynamiccontentmetadata_Appointments

One-To-Many Relationship: [msdyncrm_marketingemaildynamiccontentmetadata msdyncrm_marketingemaildynamiccontentmetadata_Appointments](msdyncrm_marketingemaildynamiccontentmetadata.md#BKMK_msdyncrm_marketingemaildynamiccontentmetadata_Appointments)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyncrm_marketingemaildynamiccontentmetadata`|
|ReferencedAttribute|`msdyncrm_marketingemaildynamiccontentmetadataid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyncrm_marketingemaildynamiccontentmetadata_appointment`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyncrm_marketingemailtestsend_Appointments"></a> msdyncrm_marketingemailtestsend_Appointments

One-To-Many Relationship: [msdyncrm_marketingemailtestsend msdyncrm_marketingemailtestsend_Appointments](msdyncrm_marketingemailtestsend.md#BKMK_msdyncrm_marketingemailtestsend_Appointments)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyncrm_marketingemailtestsend`|
|ReferencedAttribute|`msdyncrm_marketingemailtestsendid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyncrm_marketingemailtestsend_appointment`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyncrm_migration_Appointments"></a> msdyncrm_migration_Appointments

One-To-Many Relationship: [msdyncrm_migration msdyncrm_migration_Appointments](msdyncrm_migration.md#BKMK_msdyncrm_migration_Appointments)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyncrm_migration`|
|ReferencedAttribute|`msdyncrm_migrationid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyncrm_migration_appointment`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyncrm_msdyncrm_customerjourneyiteration_appointment"></a> msdyncrm_msdyncrm_customerjourneyiteration_appointment

One-To-Many Relationship: [msdyncrm_customerjourneyiteration msdyncrm_msdyncrm_customerjourneyiteration_appointment](msdyncrm_customerjourneyiteration.md#BKMK_msdyncrm_msdyncrm_customerjourneyiteration_appointment)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyncrm_customerjourneyiteration`|
|ReferencedAttribute|`msdyncrm_customerjourneyiterationid`|
|ReferencingAttribute|`msdyncrm_associatedcustomerjourneyiteration`|
|ReferencingEntityNavigationPropertyName|`msdyncrm_associatedcustomerjourneyiteration_Appointment`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyncrm_uicconfig_Appointments"></a> msdyncrm_uicconfig_Appointments

One-To-Many Relationship: [msdyncrm_uicconfig msdyncrm_uicconfig_Appointments](msdyncrm_uicconfig.md#BKMK_msdyncrm_uicconfig_Appointments)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyncrm_uicconfig`|
|ReferencedAttribute|`msdyncrm_uicconfigid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyncrm_uicconfig_appointment`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msevtmgt_checkin_Appointments"></a> msevtmgt_checkin_Appointments

One-To-Many Relationship: [msevtmgt_checkin msevtmgt_checkin_Appointments](msevtmgt_checkin.md#BKMK_msevtmgt_checkin_Appointments)

|Property|Value|
|---|---|
|ReferencedEntity|`msevtmgt_checkin`|
|ReferencedAttribute|`msevtmgt_checkinid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msevtmgt_checkin_appointment`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msevtmgt_event_Appointments"></a> msevtmgt_event_Appointments

One-To-Many Relationship: [msevtmgt_event msevtmgt_event_Appointments](msevtmgt_event.md#BKMK_msevtmgt_event_Appointments)

|Property|Value|
|---|---|
|ReferencedEntity|`msevtmgt_event`|
|ReferencedAttribute|`msevtmgt_eventid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msevtmgt_event_appointment`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msevtmgt_eventpurchase_Appointments"></a> msevtmgt_eventpurchase_Appointments

One-To-Many Relationship: [msevtmgt_eventpurchase msevtmgt_eventpurchase_Appointments](msevtmgt_eventpurchase.md#BKMK_msevtmgt_eventpurchase_Appointments)

|Property|Value|
|---|---|
|ReferencedEntity|`msevtmgt_eventpurchase`|
|ReferencedAttribute|`msevtmgt_eventpurchaseid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msevtmgt_eventpurchase_appointment`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msevtmgt_eventpurchaseattendee_Appointments"></a> msevtmgt_eventpurchaseattendee_Appointments

One-To-Many Relationship: [msevtmgt_eventpurchaseattendee msevtmgt_eventpurchaseattendee_Appointments](msevtmgt_eventpurchaseattendee.md#BKMK_msevtmgt_eventpurchaseattendee_Appointments)

|Property|Value|
|---|---|
|ReferencedEntity|`msevtmgt_eventpurchaseattendee`|
|ReferencedAttribute|`msevtmgt_eventpurchaseattendeeid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msevtmgt_eventpurchaseattendee_appointment`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msevtmgt_eventpurchasepass_Appointments"></a> msevtmgt_eventpurchasepass_Appointments

One-To-Many Relationship: [msevtmgt_eventpurchasepass msevtmgt_eventpurchasepass_Appointments](msevtmgt_eventpurchasepass.md#BKMK_msevtmgt_eventpurchasepass_Appointments)

|Property|Value|
|---|---|
|ReferencedEntity|`msevtmgt_eventpurchasepass`|
|ReferencedAttribute|`msevtmgt_eventpurchasepassid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msevtmgt_eventpurchasepass_appointment`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msevtmgt_eventregistration_Appointments"></a> msevtmgt_eventregistration_Appointments

One-To-Many Relationship: [msevtmgt_eventregistration msevtmgt_eventregistration_Appointments](msevtmgt_eventregistration.md#BKMK_msevtmgt_eventregistration_Appointments)

|Property|Value|
|---|---|
|ReferencedEntity|`msevtmgt_eventregistration`|
|ReferencedAttribute|`msevtmgt_eventregistrationid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msevtmgt_eventregistration_appointment`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msevtmgt_hotel_Appointments"></a> msevtmgt_hotel_Appointments

One-To-Many Relationship: [msevtmgt_hotel msevtmgt_hotel_Appointments](msevtmgt_hotel.md#BKMK_msevtmgt_hotel_Appointments)

|Property|Value|
|---|---|
|ReferencedEntity|`msevtmgt_hotel`|
|ReferencedAttribute|`msevtmgt_hotelid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msevtmgt_hotel_appointment`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msevtmgt_hotelroomallocation_Appointments"></a> msevtmgt_hotelroomallocation_Appointments

One-To-Many Relationship: [msevtmgt_hotelroomallocation msevtmgt_hotelroomallocation_Appointments](msevtmgt_hotelroomallocation.md#BKMK_msevtmgt_hotelroomallocation_Appointments)

|Property|Value|
|---|---|
|ReferencedEntity|`msevtmgt_hotelroomallocation`|
|ReferencedAttribute|`msevtmgt_hotelroomallocationid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msevtmgt_hotelroomallocation_appointment`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msevtmgt_hotelroomreservation_Appointments"></a> msevtmgt_hotelroomreservation_Appointments

One-To-Many Relationship: [msevtmgt_hotelroomreservation msevtmgt_hotelroomreservation_Appointments](msevtmgt_hotelroomreservation.md#BKMK_msevtmgt_hotelroomreservation_Appointments)

|Property|Value|
|---|---|
|ReferencedEntity|`msevtmgt_hotelroomreservation`|
|ReferencedAttribute|`msevtmgt_hotelroomreservationid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msevtmgt_hotelroomreservation_appointment`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msevtmgt_layout_Appointments"></a> msevtmgt_layout_Appointments

One-To-Many Relationship: [msevtmgt_layout msevtmgt_layout_Appointments](msevtmgt_layout.md#BKMK_msevtmgt_layout_Appointments)

|Property|Value|
|---|---|
|ReferencedEntity|`msevtmgt_layout`|
|ReferencedAttribute|`msevtmgt_layoutid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msevtmgt_layout_appointment`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msevtmgt_room_Appointments"></a> msevtmgt_room_Appointments

One-To-Many Relationship: [msevtmgt_room msevtmgt_room_Appointments](msevtmgt_room.md#BKMK_msevtmgt_room_Appointments)

|Property|Value|
|---|---|
|ReferencedEntity|`msevtmgt_room`|
|ReferencedAttribute|`msevtmgt_roomid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msevtmgt_room_appointment`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msevtmgt_session_Appointments"></a> msevtmgt_session_Appointments

One-To-Many Relationship: [msevtmgt_session msevtmgt_session_Appointments](msevtmgt_session.md#BKMK_msevtmgt_session_Appointments)

|Property|Value|
|---|---|
|ReferencedEntity|`msevtmgt_session`|
|ReferencedAttribute|`msevtmgt_sessionid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msevtmgt_session_appointment`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msevtmgt_sessionregistration_Appointments"></a> msevtmgt_sessionregistration_Appointments

One-To-Many Relationship: [msevtmgt_sessionregistration msevtmgt_sessionregistration_Appointments](msevtmgt_sessionregistration.md#BKMK_msevtmgt_sessionregistration_Appointments)

|Property|Value|
|---|---|
|ReferencedEntity|`msevtmgt_sessionregistration`|
|ReferencedAttribute|`msevtmgt_sessionregistrationid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msevtmgt_sessionregistration_appointment`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msevtmgt_sessiontrack_Appointments"></a> msevtmgt_sessiontrack_Appointments

One-To-Many Relationship: [msevtmgt_sessiontrack msevtmgt_sessiontrack_Appointments](msevtmgt_sessiontrack.md#BKMK_msevtmgt_sessiontrack_Appointments)

|Property|Value|
|---|---|
|ReferencedEntity|`msevtmgt_sessiontrack`|
|ReferencedAttribute|`msevtmgt_sessiontrackid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msevtmgt_sessiontrack_appointment`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msevtmgt_speaker_Appointments"></a> msevtmgt_speaker_Appointments

One-To-Many Relationship: [msevtmgt_speaker msevtmgt_speaker_Appointments](msevtmgt_speaker.md#BKMK_msevtmgt_speaker_Appointments)

|Property|Value|
|---|---|
|ReferencedEntity|`msevtmgt_speaker`|
|ReferencedAttribute|`msevtmgt_speakerid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msevtmgt_speaker_appointment`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msevtmgt_speakerengagement_Appointments"></a> msevtmgt_speakerengagement_Appointments

One-To-Many Relationship: [msevtmgt_speakerengagement msevtmgt_speakerengagement_Appointments](msevtmgt_speakerengagement.md#BKMK_msevtmgt_speakerengagement_Appointments)

|Property|Value|
|---|---|
|ReferencedEntity|`msevtmgt_speakerengagement`|
|ReferencedAttribute|`msevtmgt_speakerengagementid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msevtmgt_speakerengagement_appointment`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msevtmgt_sponsorablearticle_Appointments"></a> msevtmgt_sponsorablearticle_Appointments

One-To-Many Relationship: [msevtmgt_sponsorablearticle msevtmgt_sponsorablearticle_Appointments](msevtmgt_sponsorablearticle.md#BKMK_msevtmgt_sponsorablearticle_Appointments)

|Property|Value|
|---|---|
|ReferencedEntity|`msevtmgt_sponsorablearticle`|
|ReferencedAttribute|`msevtmgt_sponsorablearticleid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msevtmgt_sponsorablearticle_appointment`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msevtmgt_sponsorship_Appointments"></a> msevtmgt_sponsorship_Appointments

One-To-Many Relationship: [msevtmgt_sponsorship msevtmgt_sponsorship_Appointments](msevtmgt_sponsorship.md#BKMK_msevtmgt_sponsorship_Appointments)

|Property|Value|
|---|---|
|ReferencedEntity|`msevtmgt_sponsorship`|
|ReferencedAttribute|`msevtmgt_sponsorshipid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msevtmgt_sponsorship_appointment`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msevtmgt_venue_Appointments"></a> msevtmgt_venue_Appointments

One-To-Many Relationship: [msevtmgt_venue msevtmgt_venue_Appointments](msevtmgt_venue.md#BKMK_msevtmgt_venue_Appointments)

|Property|Value|
|---|---|
|ReferencedEntity|`msevtmgt_venue`|
|ReferencedAttribute|`msevtmgt_venueid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msevtmgt_venue_appointment`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msevtmgt_webinarconfiguration_Appointments"></a> msevtmgt_webinarconfiguration_Appointments

One-To-Many Relationship: [msevtmgt_webinarconfiguration msevtmgt_webinarconfiguration_Appointments](msevtmgt_webinarconfiguration.md#BKMK_msevtmgt_webinarconfiguration_Appointments)

|Property|Value|
|---|---|
|ReferencedEntity|`msevtmgt_webinarconfiguration`|
|ReferencedAttribute|`msevtmgt_webinarconfigurationid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msevtmgt_webinarconfiguration_appointment`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msevtmgt_webinarprovider_Appointments"></a> msevtmgt_webinarprovider_Appointments

One-To-Many Relationship: [msevtmgt_webinarprovider msevtmgt_webinarprovider_Appointments](msevtmgt_webinarprovider.md#BKMK_msevtmgt_webinarprovider_Appointments)

|Property|Value|
|---|---|
|ReferencedEntity|`msevtmgt_webinarprovider`|
|ReferencedAttribute|`msevtmgt_webinarproviderid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msevtmgt_webinarprovider_appointment`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

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
- [msdyn_appointment_bookableresourcebooking](#BKMK_msdyn_appointment_bookableresourcebooking)
- [msdyn_appointment_msdyn_conversationinsight_conversationinsighttarget](#BKMK_msdyn_appointment_msdyn_conversationinsight_conversationinsighttarget)
- [msdyn_appointment_msdyn_ocrecording_recordingtarget](#BKMK_msdyn_appointment_msdyn_ocrecording_recordingtarget)
- [msdyn_appointment_msdyn_recording_appointment_activity](#BKMK_msdyn_appointment_msdyn_recording_appointment_activity)
- [msdyn_appointment_msdyn_resourcerequirement](#BKMK_msdyn_appointment_msdyn_resourcerequirement)
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

### <a name="BKMK_msdyn_appointment_bookableresourcebooking"></a> msdyn_appointment_bookableresourcebooking

Many-To-One Relationship: [bookableresourcebooking msdyn_appointment_bookableresourcebooking](bookableresourcebooking.md#BKMK_msdyn_appointment_bookableresourcebooking)

|Property|Value|
|---|---|
|ReferencingEntity|`bookableresourcebooking`|
|ReferencingAttribute|`msdyn_appointmentbookingid`|
|ReferencedEntityNavigationPropertyName|`msdyn_appointment_bookableresourcebooking`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_appointment_msdyn_conversationinsight_conversationinsighttarget"></a> msdyn_appointment_msdyn_conversationinsight_conversationinsighttarget

Many-To-One Relationship: [msdyn_conversationinsight msdyn_appointment_msdyn_conversationinsight_conversationinsighttarget](msdyn_conversationinsight.md#BKMK_msdyn_appointment_msdyn_conversationinsight_conversationinsighttarget)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_conversationinsight`|
|ReferencingAttribute|`msdyn_conversationinsighttarget`|
|ReferencedEntityNavigationPropertyName|`msdyn_appointment_msdyn_conversationinsight_conversationinsighttarget`|
|IsCustomizable|`False`|
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

### <a name="BKMK_msdyn_appointment_msdyn_recording_appointment_activity"></a> msdyn_appointment_msdyn_recording_appointment_activity

Many-To-One Relationship: [msdyn_recording msdyn_appointment_msdyn_recording_appointment_activity](msdyn_recording.md#BKMK_msdyn_appointment_msdyn_recording_appointment_activity)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_recording`|
|ReferencingAttribute|`msdyn_appointment_activity`|
|ReferencedEntityNavigationPropertyName|`msdyn_appointment_msdyn_recording_appointment_activity`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_appointment_msdyn_resourcerequirement"></a> msdyn_appointment_msdyn_resourcerequirement

Many-To-One Relationship: [msdyn_resourcerequirement msdyn_appointment_msdyn_resourcerequirement](msdyn_resourcerequirement.md#BKMK_msdyn_appointment_msdyn_resourcerequirement)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_resourcerequirement`|
|ReferencingAttribute|`msdyn_appointmentrequirementid`|
|ReferencedEntityNavigationPropertyName|`msdyn_appointment_msdyn_resourcerequirement`|
|IsCustomizable|`True`|
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

[Dataverse table/entity reference](../about-entity-reference.md)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   
<xref:Microsoft.Dynamics.CRM.appointment?displayProperty=fullName>
