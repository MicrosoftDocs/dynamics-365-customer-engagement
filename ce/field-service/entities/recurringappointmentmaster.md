---
title: "Recurring Appointment (RecurringAppointmentMaster) table/entity reference (Microsoft Dynamics 365 Field Service)"
description: "Includes schema information and supported messages for the Recurring Appointment (RecurringAppointmentMaster) table/entity with Microsoft Dynamics 365 Field Service."
ms.date: 07.24.2024
ms.service: powerapps
ms.topic: reference
author: m-hartmann
ms.author: mhart
search.audienceType: 
  - developer
---

# Recurring Appointment (RecurringAppointmentMaster) table/entity reference

The Master appointment of a recurring appointment series.

> [!NOTE]
> The Microsoft Dynamics 365 Field Service Recurring Appointment (RecurringAppointmentMaster) table extends the [Microsoft Dataverse Recurring Appointment (RecurringAppointmentMaster) table](/power-apps/developer/data-platform/reference/entities/recurringappointmentmaster).



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

Microsoft Dynamics 365 Field Service modifies the definition of columns/attributes defined in other solutions. Listed by **SchemaName**.

- [OptionalAttendees](#BKMK_OptionalAttendees)
- [RegardingObjectId](#BKMK_RegardingObjectId)
- [RequiredAttendees](#BKMK_RequiredAttendees)

### <a name="BKMK_OptionalAttendees"></a> OptionalAttendees

Changes from [OptionalAttendees (Microsoft Dataverse)](/power-apps/developer/data-platform/reference/entities/recurringappointmentmaster#BKMK_OptionalAttendees)

|Property|Value|
|---|---|
|Targets|equipment|


### <a name="BKMK_RegardingObjectId"></a> RegardingObjectId

Changes from [RegardingObjectId (Microsoft Dataverse)](/power-apps/developer/data-platform/reference/entities/recurringappointmentmaster#BKMK_RegardingObjectId)

|Property|Value|
|---|---|
|Targets|adx_ad|


### <a name="BKMK_RequiredAttendees"></a> RequiredAttendees

Changes from [RequiredAttendees (Microsoft Dataverse)](/power-apps/developer/data-platform/reference/entities/recurringappointmentmaster#BKMK_RequiredAttendees)

|Property|Value|
|---|---|
|Targets|equipment|


## Many-to-One relationships

These relationships are many-to-one. Listed by **SchemaName**.

- [adx_ad_RecurringAppointmentMasters](#BKMK_adx_ad_RecurringAppointmentMasters)
- [adx_adplacement_RecurringAppointmentMasters](#BKMK_adx_adplacement_RecurringAppointmentMasters)
- [adx_casedeflection_RecurringAppointmentMasters](#BKMK_adx_casedeflection_RecurringAppointmentMasters)
- [adx_communityforumaccesspermission_RecurringAppointmentMasters](#BKMK_adx_communityforumaccesspermission_RecurringAppointmentMasters)
- [adx_communityforumalert_RecurringAppointmentMasters](#BKMK_adx_communityforumalert_RecurringAppointmentMasters)
- [adx_contentaccesslevel_RecurringAppointmentMasters](#BKMK_adx_contentaccesslevel_RecurringAppointmentMasters)
- [adx_poll_RecurringAppointmentMasters](#BKMK_adx_poll_RecurringAppointmentMasters)
- [adx_polloption_RecurringAppointmentMasters](#BKMK_adx_polloption_RecurringAppointmentMasters)
- [adx_pollplacement_RecurringAppointmentMasters](#BKMK_adx_pollplacement_RecurringAppointmentMasters)
- [adx_pollsubmission_RecurringAppointmentMasters](#BKMK_adx_pollsubmission_RecurringAppointmentMasters)
- [adx_publishingstatetransitionrule_RecurringAppointmentMasters](#BKMK_adx_publishingstatetransitionrule_RecurringAppointmentMasters)
- [adx_redirect_RecurringAppointmentMasters](#BKMK_adx_redirect_RecurringAppointmentMasters)
- [adx_shortcut_RecurringAppointmentMasters](#BKMK_adx_shortcut_RecurringAppointmentMasters)
- [adx_webpage_RecurringAppointmentMasters](#BKMK_adx_webpage_RecurringAppointmentMasters)
- [adx_website_RecurringAppointmentMasters](#BKMK_adx_website_RecurringAppointmentMasters)
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
- [msdyn_agreement_RecurringAppointmentMasters](#BKMK_msdyn_agreement_RecurringAppointmentMasters)
- [msdyn_agreementbookingdate_RecurringAppointmentMasters](#BKMK_msdyn_agreementbookingdate_RecurringAppointmentMasters)
- [msdyn_agreementbookingincident_RecurringAppointmentMasters](#BKMK_msdyn_agreementbookingincident_RecurringAppointmentMasters)
- [msdyn_agreementbookingproduct_RecurringAppointmentMasters](#BKMK_msdyn_agreementbookingproduct_RecurringAppointmentMasters)
- [msdyn_agreementbookingservice_RecurringAppointmentMasters](#BKMK_msdyn_agreementbookingservice_RecurringAppointmentMasters)
- [msdyn_agreementbookingservicetask_RecurringAppointmentMasters](#BKMK_msdyn_agreementbookingservicetask_RecurringAppointmentMasters)
- [msdyn_agreementbookingsetup_RecurringAppointmentMasters](#BKMK_msdyn_agreementbookingsetup_RecurringAppointmentMasters)
- [msdyn_agreementinvoicedate_RecurringAppointmentMasters](#BKMK_msdyn_agreementinvoicedate_RecurringAppointmentMasters)
- [msdyn_agreementinvoiceproduct_RecurringAppointmentMasters](#BKMK_msdyn_agreementinvoiceproduct_RecurringAppointmentMasters)
- [msdyn_agreementinvoicesetup_RecurringAppointmentMasters](#BKMK_msdyn_agreementinvoicesetup_RecurringAppointmentMasters)
- [msdyn_bookingalertstatus_RecurringAppointmentMasters](#BKMK_msdyn_bookingalertstatus_RecurringAppointmentMasters)
- [msdyn_bookingrule_RecurringAppointmentMasters](#BKMK_msdyn_bookingrule_RecurringAppointmentMasters)
- [msdyn_bookingtimestamp_RecurringAppointmentMasters](#BKMK_msdyn_bookingtimestamp_RecurringAppointmentMasters)
- [msdyn_customerasset_RecurringAppointmentMasters](#BKMK_msdyn_customerasset_RecurringAppointmentMasters)
- [msdyn_fieldservicesetting_RecurringAppointmentMasters](#BKMK_msdyn_fieldservicesetting_RecurringAppointmentMasters)
- [msdyn_incidenttypecharacteristic_RecurringAppointmentMasters](#BKMK_msdyn_incidenttypecharacteristic_RecurringAppointmentMasters)
- [msdyn_incidenttypeproduct_RecurringAppointmentMasters](#BKMK_msdyn_incidenttypeproduct_RecurringAppointmentMasters)
- [msdyn_incidenttypeservice_RecurringAppointmentMasters](#BKMK_msdyn_incidenttypeservice_RecurringAppointmentMasters)
- [msdyn_inventoryadjustment_RecurringAppointmentMasters](#BKMK_msdyn_inventoryadjustment_RecurringAppointmentMasters)
- [msdyn_inventoryadjustmentproduct_RecurringAppointmentMasters](#BKMK_msdyn_inventoryadjustmentproduct_RecurringAppointmentMasters)
- [msdyn_inventoryjournal_RecurringAppointmentMasters](#BKMK_msdyn_inventoryjournal_RecurringAppointmentMasters)
- [msdyn_inventorytransfer_RecurringAppointmentMasters](#BKMK_msdyn_inventorytransfer_RecurringAppointmentMasters)
- [msdyn_payment_RecurringAppointmentMasters](#BKMK_msdyn_payment_RecurringAppointmentMasters)
- [msdyn_paymentdetail_RecurringAppointmentMasters](#BKMK_msdyn_paymentdetail_RecurringAppointmentMasters)
- [msdyn_paymentmethod_RecurringAppointmentMasters](#BKMK_msdyn_paymentmethod_RecurringAppointmentMasters)
- [msdyn_paymentterm_RecurringAppointmentMasters](#BKMK_msdyn_paymentterm_RecurringAppointmentMasters)
- [msdyn_playbookinstance_RecurringAppointmentMasters](#BKMK_msdyn_playbookinstance_RecurringAppointmentMasters)
- [msdyn_postalbum_RecurringAppointmentMasters](#BKMK_msdyn_postalbum_RecurringAppointmentMasters)
- [msdyn_postalcode_RecurringAppointmentMasters](#BKMK_msdyn_postalcode_RecurringAppointmentMasters)
- [msdyn_productinventory_RecurringAppointmentMasters](#BKMK_msdyn_productinventory_RecurringAppointmentMasters)
- [msdyn_purchaseorder_RecurringAppointmentMasters](#BKMK_msdyn_purchaseorder_RecurringAppointmentMasters)
- [msdyn_purchaseorderbill_RecurringAppointmentMasters](#BKMK_msdyn_purchaseorderbill_RecurringAppointmentMasters)
- [msdyn_purchaseorderproduct_RecurringAppointmentMasters](#BKMK_msdyn_purchaseorderproduct_RecurringAppointmentMasters)
- [msdyn_purchaseorderreceipt_RecurringAppointmentMasters](#BKMK_msdyn_purchaseorderreceipt_RecurringAppointmentMasters)
- [msdyn_purchaseorderreceiptproduct_RecurringAppointmentMasters](#BKMK_msdyn_purchaseorderreceiptproduct_RecurringAppointmentMasters)
- [msdyn_purchaseordersubstatus_RecurringAppointmentMasters](#BKMK_msdyn_purchaseordersubstatus_RecurringAppointmentMasters)
- [msdyn_quotebookingincident_RecurringAppointmentMasters](#BKMK_msdyn_quotebookingincident_RecurringAppointmentMasters)
- [msdyn_quotebookingproduct_RecurringAppointmentMasters](#BKMK_msdyn_quotebookingproduct_RecurringAppointmentMasters)
- [msdyn_quotebookingservice_RecurringAppointmentMasters](#BKMK_msdyn_quotebookingservice_RecurringAppointmentMasters)
- [msdyn_quotebookingservicetask_RecurringAppointmentMasters](#BKMK_msdyn_quotebookingservicetask_RecurringAppointmentMasters)
- [msdyn_resourceterritory_RecurringAppointmentMasters](#BKMK_msdyn_resourceterritory_RecurringAppointmentMasters)
- [msdyn_rma_RecurringAppointmentMasters](#BKMK_msdyn_rma_RecurringAppointmentMasters)
- [msdyn_rmaproduct_RecurringAppointmentMasters](#BKMK_msdyn_rmaproduct_RecurringAppointmentMasters)
- [msdyn_rmareceipt_RecurringAppointmentMasters](#BKMK_msdyn_rmareceipt_RecurringAppointmentMasters)
- [msdyn_rmareceiptproduct_RecurringAppointmentMasters](#BKMK_msdyn_rmareceiptproduct_RecurringAppointmentMasters)
- [msdyn_rmasubstatus_RecurringAppointmentMasters](#BKMK_msdyn_rmasubstatus_RecurringAppointmentMasters)
- [msdyn_rtv_RecurringAppointmentMasters](#BKMK_msdyn_rtv_RecurringAppointmentMasters)
- [msdyn_rtvproduct_RecurringAppointmentMasters](#BKMK_msdyn_rtvproduct_RecurringAppointmentMasters)
- [msdyn_rtvsubstatus_RecurringAppointmentMasters](#BKMK_msdyn_rtvsubstatus_RecurringAppointmentMasters)
- [msdyn_salessuggestion_RecurringAppointmentMasters](#BKMK_msdyn_salessuggestion_RecurringAppointmentMasters)
- [msdyn_shipvia_RecurringAppointmentMasters](#BKMK_msdyn_shipvia_RecurringAppointmentMasters)
- [msdyn_swarm_RecurringAppointmentMasters](#BKMK_msdyn_swarm_RecurringAppointmentMasters)
- [msdyn_systemuserschedulersetting_RecurringAppointmentMasters](#BKMK_msdyn_systemuserschedulersetting_RecurringAppointmentMasters)
- [msdyn_timegroup_RecurringAppointmentMasters](#BKMK_msdyn_timegroup_RecurringAppointmentMasters)
- [msdyn_timegroupdetail_RecurringAppointmentMasters](#BKMK_msdyn_timegroupdetail_RecurringAppointmentMasters)
- [msdyn_timeoffrequest_RecurringAppointmentMasters](#BKMK_msdyn_timeoffrequest_RecurringAppointmentMasters)
- [msdyn_warehouse_RecurringAppointmentMasters](#BKMK_msdyn_warehouse_RecurringAppointmentMasters)
- [msdyn_workorder_RecurringAppointmentMasters](#BKMK_msdyn_workorder_RecurringAppointmentMasters)
- [msdyn_workordercharacteristic_RecurringAppointmentMasters](#BKMK_msdyn_workordercharacteristic_RecurringAppointmentMasters)
- [msdyn_workorderincident_RecurringAppointmentMasters](#BKMK_msdyn_workorderincident_RecurringAppointmentMasters)
- [msdyn_workorderproduct_RecurringAppointmentMasters](#BKMK_msdyn_workorderproduct_RecurringAppointmentMasters)
- [msdyn_workorderresourcerestriction_RecurringAppointmentMasters](#BKMK_msdyn_workorderresourcerestriction_RecurringAppointmentMasters)
- [msdyn_workorderservice_RecurringAppointmentMasters](#BKMK_msdyn_workorderservice_RecurringAppointmentMasters)
- [msdyn_workorderservicetask_RecurringAppointmentMasters](#BKMK_msdyn_workorderservicetask_RecurringAppointmentMasters)
- [msdyncrm_contentsettings_RecurringAppointmentMasters](#BKMK_msdyncrm_contentsettings_RecurringAppointmentMasters)
- [msdyncrm_customerjourney_RecurringAppointmentMasters](#BKMK_msdyncrm_customerjourney_RecurringAppointmentMasters)
- [msdyncrm_leadscoremodel_RecurringAppointmentMasters](#BKMK_msdyncrm_leadscoremodel_RecurringAppointmentMasters)
- [msdyncrm_linkedinaccount_RecurringAppointmentMasters](#BKMK_msdyncrm_linkedinaccount_RecurringAppointmentMasters)
- [msdyncrm_linkedinactivity_RecurringAppointmentMasters](#BKMK_msdyncrm_linkedinactivity_RecurringAppointmentMasters)
- [msdyncrm_linkedinfieldmapping_RecurringAppointmentMasters](#BKMK_msdyncrm_linkedinfieldmapping_RecurringAppointmentMasters)
- [msdyncrm_linkedinform_RecurringAppointmentMasters](#BKMK_msdyncrm_linkedinform_RecurringAppointmentMasters)
- [msdyncrm_linkedinformanswer_RecurringAppointmentMasters](#BKMK_msdyncrm_linkedinformanswer_RecurringAppointmentMasters)
- [msdyncrm_linkedinformquestion_RecurringAppointmentMasters](#BKMK_msdyncrm_linkedinformquestion_RecurringAppointmentMasters)
- [msdyncrm_linkedinformsubmission_RecurringAppointmentMasters](#BKMK_msdyncrm_linkedinformsubmission_RecurringAppointmentMasters)
- [msdyncrm_linkedinleadmatchingstrategy_RecurringAppointmentMasters](#BKMK_msdyncrm_linkedinleadmatchingstrategy_RecurringAppointmentMasters)
- [msdyncrm_linkedinuserprofile_RecurringAppointmentMasters](#BKMK_msdyncrm_linkedinuserprofile_RecurringAppointmentMasters)
- [msdyncrm_marketingdynamiccontentmetadata_RecurringAppointmentMasters](#BKMK_msdyncrm_marketingdynamiccontentmetadata_RecurringAppointmentMasters)
- [msdyncrm_marketingemaildynamiccontentmetadata_RecurringAppointmentMasters](#BKMK_msdyncrm_marketingemaildynamiccontentmetadata_RecurringAppointmentMasters)
- [msdyncrm_marketingemailtestsend_RecurringAppointmentMasters](#BKMK_msdyncrm_marketingemailtestsend_RecurringAppointmentMasters)
- [msdyncrm_migration_RecurringAppointmentMasters](#BKMK_msdyncrm_migration_RecurringAppointmentMasters)
- [msdyncrm_uicconfig_RecurringAppointmentMasters](#BKMK_msdyncrm_uicconfig_RecurringAppointmentMasters)
- [msevtmgt_checkin_RecurringAppointmentMasters](#BKMK_msevtmgt_checkin_RecurringAppointmentMasters)
- [msevtmgt_event_RecurringAppointmentMasters](#BKMK_msevtmgt_event_RecurringAppointmentMasters)
- [msevtmgt_eventpurchase_RecurringAppointmentMasters](#BKMK_msevtmgt_eventpurchase_RecurringAppointmentMasters)
- [msevtmgt_eventpurchaseattendee_RecurringAppointmentMasters](#BKMK_msevtmgt_eventpurchaseattendee_RecurringAppointmentMasters)
- [msevtmgt_eventpurchasepass_RecurringAppointmentMasters](#BKMK_msevtmgt_eventpurchasepass_RecurringAppointmentMasters)
- [msevtmgt_eventregistration_RecurringAppointmentMasters](#BKMK_msevtmgt_eventregistration_RecurringAppointmentMasters)
- [msevtmgt_hotel_RecurringAppointmentMasters](#BKMK_msevtmgt_hotel_RecurringAppointmentMasters)
- [msevtmgt_hotelroomallocation_RecurringAppointmentMasters](#BKMK_msevtmgt_hotelroomallocation_RecurringAppointmentMasters)
- [msevtmgt_hotelroomreservation_RecurringAppointmentMasters](#BKMK_msevtmgt_hotelroomreservation_RecurringAppointmentMasters)
- [msevtmgt_layout_RecurringAppointmentMasters](#BKMK_msevtmgt_layout_RecurringAppointmentMasters)
- [msevtmgt_room_RecurringAppointmentMasters](#BKMK_msevtmgt_room_RecurringAppointmentMasters)
- [msevtmgt_session_RecurringAppointmentMasters](#BKMK_msevtmgt_session_RecurringAppointmentMasters)
- [msevtmgt_sessionregistration_RecurringAppointmentMasters](#BKMK_msevtmgt_sessionregistration_RecurringAppointmentMasters)
- [msevtmgt_sessiontrack_RecurringAppointmentMasters](#BKMK_msevtmgt_sessiontrack_RecurringAppointmentMasters)
- [msevtmgt_speaker_RecurringAppointmentMasters](#BKMK_msevtmgt_speaker_RecurringAppointmentMasters)
- [msevtmgt_speakerengagement_RecurringAppointmentMasters](#BKMK_msevtmgt_speakerengagement_RecurringAppointmentMasters)
- [msevtmgt_sponsorablearticle_RecurringAppointmentMasters](#BKMK_msevtmgt_sponsorablearticle_RecurringAppointmentMasters)
- [msevtmgt_sponsorship_RecurringAppointmentMasters](#BKMK_msevtmgt_sponsorship_RecurringAppointmentMasters)
- [msevtmgt_venue_RecurringAppointmentMasters](#BKMK_msevtmgt_venue_RecurringAppointmentMasters)
- [msevtmgt_webinarconfiguration_RecurringAppointmentMasters](#BKMK_msevtmgt_webinarconfiguration_RecurringAppointmentMasters)
- [msevtmgt_webinarprovider_RecurringAppointmentMasters](#BKMK_msevtmgt_webinarprovider_RecurringAppointmentMasters)
- [Opportunity_RecurringAppointmentMasters](#BKMK_Opportunity_RecurringAppointmentMasters)
- [Quote_RecurringAppointmentMasters](#BKMK_Quote_RecurringAppointmentMasters)
- [SalesOrder_RecurringAppointmentMasters](#BKMK_SalesOrder_RecurringAppointmentMasters)
- [service_recurringappointmentmasters](#BKMK_service_recurringappointmentmasters)
- [site_RecurringAppointmentMasters](#BKMK_site_RecurringAppointmentMasters)

### <a name="BKMK_adx_ad_RecurringAppointmentMasters"></a> adx_ad_RecurringAppointmentMasters

One-To-Many Relationship: [adx_ad adx_ad_RecurringAppointmentMasters](adx_ad.md#BKMK_adx_ad_RecurringAppointmentMasters)

|Property|Value|
|---|---|
|ReferencedEntity|`adx_ad`|
|ReferencedAttribute|`adx_adid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_adx_ad_recurringappointmentmaster`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_adx_adplacement_RecurringAppointmentMasters"></a> adx_adplacement_RecurringAppointmentMasters

One-To-Many Relationship: [adx_adplacement adx_adplacement_RecurringAppointmentMasters](adx_adplacement.md#BKMK_adx_adplacement_RecurringAppointmentMasters)

|Property|Value|
|---|---|
|ReferencedEntity|`adx_adplacement`|
|ReferencedAttribute|`adx_adplacementid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_adx_adplacement_recurringappointmentmaster`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_adx_casedeflection_RecurringAppointmentMasters"></a> adx_casedeflection_RecurringAppointmentMasters

One-To-Many Relationship: [adx_casedeflection adx_casedeflection_RecurringAppointmentMasters](adx_casedeflection.md#BKMK_adx_casedeflection_RecurringAppointmentMasters)

|Property|Value|
|---|---|
|ReferencedEntity|`adx_casedeflection`|
|ReferencedAttribute|`adx_casedeflectionid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_adx_casedeflection_recurringappointmentmaster`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_adx_communityforumaccesspermission_RecurringAppointmentMasters"></a> adx_communityforumaccesspermission_RecurringAppointmentMasters

One-To-Many Relationship: [adx_communityforumaccesspermission adx_communityforumaccesspermission_RecurringAppointmentMasters](adx_communityforumaccesspermission.md#BKMK_adx_communityforumaccesspermission_RecurringAppointmentMasters)

|Property|Value|
|---|---|
|ReferencedEntity|`adx_communityforumaccesspermission`|
|ReferencedAttribute|`adx_communityforumaccesspermissionid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_adx_communityforumaccesspermission_recurringappointmentmaster`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_adx_communityforumalert_RecurringAppointmentMasters"></a> adx_communityforumalert_RecurringAppointmentMasters

One-To-Many Relationship: [adx_communityforumalert adx_communityforumalert_RecurringAppointmentMasters](adx_communityforumalert.md#BKMK_adx_communityforumalert_RecurringAppointmentMasters)

|Property|Value|
|---|---|
|ReferencedEntity|`adx_communityforumalert`|
|ReferencedAttribute|`adx_communityforumalertid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_adx_communityforumalert_recurringappointmentmaster`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_adx_contentaccesslevel_RecurringAppointmentMasters"></a> adx_contentaccesslevel_RecurringAppointmentMasters

One-To-Many Relationship: [adx_contentaccesslevel adx_contentaccesslevel_RecurringAppointmentMasters](adx_contentaccesslevel.md#BKMK_adx_contentaccesslevel_RecurringAppointmentMasters)

|Property|Value|
|---|---|
|ReferencedEntity|`adx_contentaccesslevel`|
|ReferencedAttribute|`adx_contentaccesslevelid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_adx_contentaccesslevel_recurringappointmentmaster`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_adx_poll_RecurringAppointmentMasters"></a> adx_poll_RecurringAppointmentMasters

One-To-Many Relationship: [adx_poll adx_poll_RecurringAppointmentMasters](adx_poll.md#BKMK_adx_poll_RecurringAppointmentMasters)

|Property|Value|
|---|---|
|ReferencedEntity|`adx_poll`|
|ReferencedAttribute|`adx_pollid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_adx_poll_recurringappointmentmaster`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_adx_polloption_RecurringAppointmentMasters"></a> adx_polloption_RecurringAppointmentMasters

One-To-Many Relationship: [adx_polloption adx_polloption_RecurringAppointmentMasters](adx_polloption.md#BKMK_adx_polloption_RecurringAppointmentMasters)

|Property|Value|
|---|---|
|ReferencedEntity|`adx_polloption`|
|ReferencedAttribute|`adx_polloptionid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_adx_polloption_recurringappointmentmaster`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_adx_pollplacement_RecurringAppointmentMasters"></a> adx_pollplacement_RecurringAppointmentMasters

One-To-Many Relationship: [adx_pollplacement adx_pollplacement_RecurringAppointmentMasters](adx_pollplacement.md#BKMK_adx_pollplacement_RecurringAppointmentMasters)

|Property|Value|
|---|---|
|ReferencedEntity|`adx_pollplacement`|
|ReferencedAttribute|`adx_pollplacementid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_adx_pollplacement_recurringappointmentmaster`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_adx_pollsubmission_RecurringAppointmentMasters"></a> adx_pollsubmission_RecurringAppointmentMasters

One-To-Many Relationship: [adx_pollsubmission adx_pollsubmission_RecurringAppointmentMasters](adx_pollsubmission.md#BKMK_adx_pollsubmission_RecurringAppointmentMasters)

|Property|Value|
|---|---|
|ReferencedEntity|`adx_pollsubmission`|
|ReferencedAttribute|`adx_pollsubmissionid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_adx_pollsubmission_recurringappointmentmaster`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_adx_publishingstatetransitionrule_RecurringAppointmentMasters"></a> adx_publishingstatetransitionrule_RecurringAppointmentMasters

One-To-Many Relationship: [adx_publishingstatetransitionrule adx_publishingstatetransitionrule_RecurringAppointmentMasters](adx_publishingstatetransitionrule.md#BKMK_adx_publishingstatetransitionrule_RecurringAppointmentMasters)

|Property|Value|
|---|---|
|ReferencedEntity|`adx_publishingstatetransitionrule`|
|ReferencedAttribute|`adx_publishingstatetransitionruleid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_adx_publishingstatetransitionrule_recurringappointmentmaster`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_adx_redirect_RecurringAppointmentMasters"></a> adx_redirect_RecurringAppointmentMasters

One-To-Many Relationship: [adx_redirect adx_redirect_RecurringAppointmentMasters](adx_redirect.md#BKMK_adx_redirect_RecurringAppointmentMasters)

|Property|Value|
|---|---|
|ReferencedEntity|`adx_redirect`|
|ReferencedAttribute|`adx_redirectid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_adx_redirect_recurringappointmentmaster`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_adx_shortcut_RecurringAppointmentMasters"></a> adx_shortcut_RecurringAppointmentMasters

One-To-Many Relationship: [adx_shortcut adx_shortcut_RecurringAppointmentMasters](adx_shortcut.md#BKMK_adx_shortcut_RecurringAppointmentMasters)

|Property|Value|
|---|---|
|ReferencedEntity|`adx_shortcut`|
|ReferencedAttribute|`adx_shortcutid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_adx_shortcut_recurringappointmentmaster`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_adx_webpage_RecurringAppointmentMasters"></a> adx_webpage_RecurringAppointmentMasters

One-To-Many Relationship: [adx_webpage adx_webpage_RecurringAppointmentMasters](adx_webpage.md#BKMK_adx_webpage_RecurringAppointmentMasters)

|Property|Value|
|---|---|
|ReferencedEntity|`adx_webpage`|
|ReferencedAttribute|`adx_webpageid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_adx_webpage_recurringappointmentmaster`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_adx_website_RecurringAppointmentMasters"></a> adx_website_RecurringAppointmentMasters

One-To-Many Relationship: [adx_website adx_website_RecurringAppointmentMasters](adx_website.md#BKMK_adx_website_RecurringAppointmentMasters)

|Property|Value|
|---|---|
|ReferencedEntity|`adx_website`|
|ReferencedAttribute|`adx_websiteid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_adx_website_recurringappointmentmaster`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

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

### <a name="BKMK_msdyn_agreement_RecurringAppointmentMasters"></a> msdyn_agreement_RecurringAppointmentMasters

One-To-Many Relationship: [msdyn_agreement msdyn_agreement_RecurringAppointmentMasters](msdyn_agreement.md#BKMK_msdyn_agreement_RecurringAppointmentMasters)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_agreement`|
|ReferencedAttribute|`msdyn_agreementid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_agreement_recurringappointmentmaster`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_agreementbookingdate_RecurringAppointmentMasters"></a> msdyn_agreementbookingdate_RecurringAppointmentMasters

One-To-Many Relationship: [msdyn_agreementbookingdate msdyn_agreementbookingdate_RecurringAppointmentMasters](msdyn_agreementbookingdate.md#BKMK_msdyn_agreementbookingdate_RecurringAppointmentMasters)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_agreementbookingdate`|
|ReferencedAttribute|`msdyn_agreementbookingdateid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_agreementbookingdate_recurringappointmentmaster`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_agreementbookingincident_RecurringAppointmentMasters"></a> msdyn_agreementbookingincident_RecurringAppointmentMasters

One-To-Many Relationship: [msdyn_agreementbookingincident msdyn_agreementbookingincident_RecurringAppointmentMasters](msdyn_agreementbookingincident.md#BKMK_msdyn_agreementbookingincident_RecurringAppointmentMasters)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_agreementbookingincident`|
|ReferencedAttribute|`msdyn_agreementbookingincidentid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_agreementbookingincident_recurringappointmentmaster`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_agreementbookingproduct_RecurringAppointmentMasters"></a> msdyn_agreementbookingproduct_RecurringAppointmentMasters

One-To-Many Relationship: [msdyn_agreementbookingproduct msdyn_agreementbookingproduct_RecurringAppointmentMasters](msdyn_agreementbookingproduct.md#BKMK_msdyn_agreementbookingproduct_RecurringAppointmentMasters)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_agreementbookingproduct`|
|ReferencedAttribute|`msdyn_agreementbookingproductid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_agreementbookingproduct_recurringappointmentmaster`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_agreementbookingservice_RecurringAppointmentMasters"></a> msdyn_agreementbookingservice_RecurringAppointmentMasters

One-To-Many Relationship: [msdyn_agreementbookingservice msdyn_agreementbookingservice_RecurringAppointmentMasters](msdyn_agreementbookingservice.md#BKMK_msdyn_agreementbookingservice_RecurringAppointmentMasters)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_agreementbookingservice`|
|ReferencedAttribute|`msdyn_agreementbookingserviceid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_agreementbookingservice_recurringappointmentmaster`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_agreementbookingservicetask_RecurringAppointmentMasters"></a> msdyn_agreementbookingservicetask_RecurringAppointmentMasters

One-To-Many Relationship: [msdyn_agreementbookingservicetask msdyn_agreementbookingservicetask_RecurringAppointmentMasters](msdyn_agreementbookingservicetask.md#BKMK_msdyn_agreementbookingservicetask_RecurringAppointmentMasters)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_agreementbookingservicetask`|
|ReferencedAttribute|`msdyn_agreementbookingservicetaskid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_agreementbookingservicetask_recurringappointmentmaster`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_agreementbookingsetup_RecurringAppointmentMasters"></a> msdyn_agreementbookingsetup_RecurringAppointmentMasters

One-To-Many Relationship: [msdyn_agreementbookingsetup msdyn_agreementbookingsetup_RecurringAppointmentMasters](msdyn_agreementbookingsetup.md#BKMK_msdyn_agreementbookingsetup_RecurringAppointmentMasters)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_agreementbookingsetup`|
|ReferencedAttribute|`msdyn_agreementbookingsetupid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_agreementbookingsetup_recurringappointmentmaster`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_agreementinvoicedate_RecurringAppointmentMasters"></a> msdyn_agreementinvoicedate_RecurringAppointmentMasters

One-To-Many Relationship: [msdyn_agreementinvoicedate msdyn_agreementinvoicedate_RecurringAppointmentMasters](msdyn_agreementinvoicedate.md#BKMK_msdyn_agreementinvoicedate_RecurringAppointmentMasters)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_agreementinvoicedate`|
|ReferencedAttribute|`msdyn_agreementinvoicedateid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_agreementinvoicedate_recurringappointmentmaster`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_agreementinvoiceproduct_RecurringAppointmentMasters"></a> msdyn_agreementinvoiceproduct_RecurringAppointmentMasters

One-To-Many Relationship: [msdyn_agreementinvoiceproduct msdyn_agreementinvoiceproduct_RecurringAppointmentMasters](msdyn_agreementinvoiceproduct.md#BKMK_msdyn_agreementinvoiceproduct_RecurringAppointmentMasters)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_agreementinvoiceproduct`|
|ReferencedAttribute|`msdyn_agreementinvoiceproductid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_agreementinvoiceproduct_recurringappointmentmaster`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_agreementinvoicesetup_RecurringAppointmentMasters"></a> msdyn_agreementinvoicesetup_RecurringAppointmentMasters

One-To-Many Relationship: [msdyn_agreementinvoicesetup msdyn_agreementinvoicesetup_RecurringAppointmentMasters](msdyn_agreementinvoicesetup.md#BKMK_msdyn_agreementinvoicesetup_RecurringAppointmentMasters)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_agreementinvoicesetup`|
|ReferencedAttribute|`msdyn_agreementinvoicesetupid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_agreementinvoicesetup_recurringappointmentmaster`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_bookingalertstatus_RecurringAppointmentMasters"></a> msdyn_bookingalertstatus_RecurringAppointmentMasters

One-To-Many Relationship: [msdyn_bookingalertstatus msdyn_bookingalertstatus_RecurringAppointmentMasters](msdyn_bookingalertstatus.md#BKMK_msdyn_bookingalertstatus_RecurringAppointmentMasters)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_bookingalertstatus`|
|ReferencedAttribute|`msdyn_bookingalertstatusid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_bookingalertstatus_recurringappointmentmaster`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_bookingrule_RecurringAppointmentMasters"></a> msdyn_bookingrule_RecurringAppointmentMasters

One-To-Many Relationship: [msdyn_bookingrule msdyn_bookingrule_RecurringAppointmentMasters](msdyn_bookingrule.md#BKMK_msdyn_bookingrule_RecurringAppointmentMasters)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_bookingrule`|
|ReferencedAttribute|`msdyn_bookingruleid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_bookingrule_recurringappointmentmaster`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_bookingtimestamp_RecurringAppointmentMasters"></a> msdyn_bookingtimestamp_RecurringAppointmentMasters

One-To-Many Relationship: [msdyn_bookingtimestamp msdyn_bookingtimestamp_RecurringAppointmentMasters](msdyn_bookingtimestamp.md#BKMK_msdyn_bookingtimestamp_RecurringAppointmentMasters)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_bookingtimestamp`|
|ReferencedAttribute|`msdyn_bookingtimestampid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_bookingtimestamp_recurringappointmentmaster`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

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

### <a name="BKMK_msdyn_fieldservicesetting_RecurringAppointmentMasters"></a> msdyn_fieldservicesetting_RecurringAppointmentMasters

One-To-Many Relationship: [msdyn_fieldservicesetting msdyn_fieldservicesetting_RecurringAppointmentMasters](msdyn_fieldservicesetting.md#BKMK_msdyn_fieldservicesetting_RecurringAppointmentMasters)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_fieldservicesetting`|
|ReferencedAttribute|`msdyn_fieldservicesettingid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_fieldservicesetting_recurringappointmentmaster`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_incidenttypecharacteristic_RecurringAppointmentMasters"></a> msdyn_incidenttypecharacteristic_RecurringAppointmentMasters

One-To-Many Relationship: [msdyn_incidenttypecharacteristic msdyn_incidenttypecharacteristic_RecurringAppointmentMasters](msdyn_incidenttypecharacteristic.md#BKMK_msdyn_incidenttypecharacteristic_RecurringAppointmentMasters)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_incidenttypecharacteristic`|
|ReferencedAttribute|`msdyn_incidenttypecharacteristicid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_incidenttypecharacteristic_recurringappointmentmaster`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_incidenttypeproduct_RecurringAppointmentMasters"></a> msdyn_incidenttypeproduct_RecurringAppointmentMasters

One-To-Many Relationship: [msdyn_incidenttypeproduct msdyn_incidenttypeproduct_RecurringAppointmentMasters](msdyn_incidenttypeproduct.md#BKMK_msdyn_incidenttypeproduct_RecurringAppointmentMasters)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_incidenttypeproduct`|
|ReferencedAttribute|`msdyn_incidenttypeproductid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_incidenttypeproduct_recurringappointmentmaster`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_incidenttypeservice_RecurringAppointmentMasters"></a> msdyn_incidenttypeservice_RecurringAppointmentMasters

One-To-Many Relationship: [msdyn_incidenttypeservice msdyn_incidenttypeservice_RecurringAppointmentMasters](msdyn_incidenttypeservice.md#BKMK_msdyn_incidenttypeservice_RecurringAppointmentMasters)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_incidenttypeservice`|
|ReferencedAttribute|`msdyn_incidenttypeserviceid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_incidenttypeservice_recurringappointmentmaster`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_inventoryadjustment_RecurringAppointmentMasters"></a> msdyn_inventoryadjustment_RecurringAppointmentMasters

One-To-Many Relationship: [msdyn_inventoryadjustment msdyn_inventoryadjustment_RecurringAppointmentMasters](msdyn_inventoryadjustment.md#BKMK_msdyn_inventoryadjustment_RecurringAppointmentMasters)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_inventoryadjustment`|
|ReferencedAttribute|`msdyn_inventoryadjustmentid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_inventoryadjustment_recurringappointmentmaster`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_inventoryadjustmentproduct_RecurringAppointmentMasters"></a> msdyn_inventoryadjustmentproduct_RecurringAppointmentMasters

One-To-Many Relationship: [msdyn_inventoryadjustmentproduct msdyn_inventoryadjustmentproduct_RecurringAppointmentMasters](msdyn_inventoryadjustmentproduct.md#BKMK_msdyn_inventoryadjustmentproduct_RecurringAppointmentMasters)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_inventoryadjustmentproduct`|
|ReferencedAttribute|`msdyn_inventoryadjustmentproductid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_inventoryadjustmentproduct_recurringappointmentmaster`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_inventoryjournal_RecurringAppointmentMasters"></a> msdyn_inventoryjournal_RecurringAppointmentMasters

One-To-Many Relationship: [msdyn_inventoryjournal msdyn_inventoryjournal_RecurringAppointmentMasters](msdyn_inventoryjournal.md#BKMK_msdyn_inventoryjournal_RecurringAppointmentMasters)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_inventoryjournal`|
|ReferencedAttribute|`msdyn_inventoryjournalid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_inventoryjournal_recurringappointmentmaster`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_inventorytransfer_RecurringAppointmentMasters"></a> msdyn_inventorytransfer_RecurringAppointmentMasters

One-To-Many Relationship: [msdyn_inventorytransfer msdyn_inventorytransfer_RecurringAppointmentMasters](msdyn_inventorytransfer.md#BKMK_msdyn_inventorytransfer_RecurringAppointmentMasters)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_inventorytransfer`|
|ReferencedAttribute|`msdyn_inventorytransferid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_inventorytransfer_recurringappointmentmaster`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_payment_RecurringAppointmentMasters"></a> msdyn_payment_RecurringAppointmentMasters

One-To-Many Relationship: [msdyn_payment msdyn_payment_RecurringAppointmentMasters](msdyn_payment.md#BKMK_msdyn_payment_RecurringAppointmentMasters)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_payment`|
|ReferencedAttribute|`msdyn_paymentid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_payment_recurringappointmentmaster`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_paymentdetail_RecurringAppointmentMasters"></a> msdyn_paymentdetail_RecurringAppointmentMasters

One-To-Many Relationship: [msdyn_paymentdetail msdyn_paymentdetail_RecurringAppointmentMasters](msdyn_paymentdetail.md#BKMK_msdyn_paymentdetail_RecurringAppointmentMasters)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_paymentdetail`|
|ReferencedAttribute|`msdyn_paymentdetailid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_paymentdetail_recurringappointmentmaster`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_paymentmethod_RecurringAppointmentMasters"></a> msdyn_paymentmethod_RecurringAppointmentMasters

One-To-Many Relationship: [msdyn_paymentmethod msdyn_paymentmethod_RecurringAppointmentMasters](msdyn_paymentmethod.md#BKMK_msdyn_paymentmethod_RecurringAppointmentMasters)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_paymentmethod`|
|ReferencedAttribute|`msdyn_paymentmethodid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_paymentmethod_recurringappointmentmaster`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_paymentterm_RecurringAppointmentMasters"></a> msdyn_paymentterm_RecurringAppointmentMasters

One-To-Many Relationship: [msdyn_paymentterm msdyn_paymentterm_RecurringAppointmentMasters](msdyn_paymentterm.md#BKMK_msdyn_paymentterm_RecurringAppointmentMasters)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_paymentterm`|
|ReferencedAttribute|`msdyn_paymenttermid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_paymentterm_recurringappointmentmaster`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_playbookinstance_RecurringAppointmentMasters"></a> msdyn_playbookinstance_RecurringAppointmentMasters

One-To-Many Relationship: [msdyn_playbookinstance msdyn_playbookinstance_RecurringAppointmentMasters](msdyn_playbookinstance.md#BKMK_msdyn_playbookinstance_RecurringAppointmentMasters)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_playbookinstance`|
|ReferencedAttribute|`msdyn_playbookinstanceid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_playbookinstance_recurringappointmentmaster`|
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

### <a name="BKMK_msdyn_postalcode_RecurringAppointmentMasters"></a> msdyn_postalcode_RecurringAppointmentMasters

One-To-Many Relationship: [msdyn_postalcode msdyn_postalcode_RecurringAppointmentMasters](msdyn_postalcode.md#BKMK_msdyn_postalcode_RecurringAppointmentMasters)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_postalcode`|
|ReferencedAttribute|`msdyn_postalcodeid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_postalcode_recurringappointmentmaster`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_productinventory_RecurringAppointmentMasters"></a> msdyn_productinventory_RecurringAppointmentMasters

One-To-Many Relationship: [msdyn_productinventory msdyn_productinventory_RecurringAppointmentMasters](msdyn_productinventory.md#BKMK_msdyn_productinventory_RecurringAppointmentMasters)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_productinventory`|
|ReferencedAttribute|`msdyn_productinventoryid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_productinventory_recurringappointmentmaster`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_purchaseorder_RecurringAppointmentMasters"></a> msdyn_purchaseorder_RecurringAppointmentMasters

One-To-Many Relationship: [msdyn_purchaseorder msdyn_purchaseorder_RecurringAppointmentMasters](msdyn_purchaseorder.md#BKMK_msdyn_purchaseorder_RecurringAppointmentMasters)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_purchaseorder`|
|ReferencedAttribute|`msdyn_purchaseorderid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_purchaseorder_recurringappointmentmaster`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_purchaseorderbill_RecurringAppointmentMasters"></a> msdyn_purchaseorderbill_RecurringAppointmentMasters

One-To-Many Relationship: [msdyn_purchaseorderbill msdyn_purchaseorderbill_RecurringAppointmentMasters](msdyn_purchaseorderbill.md#BKMK_msdyn_purchaseorderbill_RecurringAppointmentMasters)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_purchaseorderbill`|
|ReferencedAttribute|`msdyn_purchaseorderbillid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_purchaseorderbill_recurringappointmentmaster`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_purchaseorderproduct_RecurringAppointmentMasters"></a> msdyn_purchaseorderproduct_RecurringAppointmentMasters

One-To-Many Relationship: [msdyn_purchaseorderproduct msdyn_purchaseorderproduct_RecurringAppointmentMasters](msdyn_purchaseorderproduct.md#BKMK_msdyn_purchaseorderproduct_RecurringAppointmentMasters)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_purchaseorderproduct`|
|ReferencedAttribute|`msdyn_purchaseorderproductid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_purchaseorderproduct_recurringappointmentmaster`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_purchaseorderreceipt_RecurringAppointmentMasters"></a> msdyn_purchaseorderreceipt_RecurringAppointmentMasters

One-To-Many Relationship: [msdyn_purchaseorderreceipt msdyn_purchaseorderreceipt_RecurringAppointmentMasters](msdyn_purchaseorderreceipt.md#BKMK_msdyn_purchaseorderreceipt_RecurringAppointmentMasters)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_purchaseorderreceipt`|
|ReferencedAttribute|`msdyn_purchaseorderreceiptid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_purchaseorderreceipt_recurringappointmentmaster`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_purchaseorderreceiptproduct_RecurringAppointmentMasters"></a> msdyn_purchaseorderreceiptproduct_RecurringAppointmentMasters

One-To-Many Relationship: [msdyn_purchaseorderreceiptproduct msdyn_purchaseorderreceiptproduct_RecurringAppointmentMasters](msdyn_purchaseorderreceiptproduct.md#BKMK_msdyn_purchaseorderreceiptproduct_RecurringAppointmentMasters)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_purchaseorderreceiptproduct`|
|ReferencedAttribute|`msdyn_purchaseorderreceiptproductid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_purchaseorderreceiptproduct_recurringappointmentmaster`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_purchaseordersubstatus_RecurringAppointmentMasters"></a> msdyn_purchaseordersubstatus_RecurringAppointmentMasters

One-To-Many Relationship: [msdyn_purchaseordersubstatus msdyn_purchaseordersubstatus_RecurringAppointmentMasters](msdyn_purchaseordersubstatus.md#BKMK_msdyn_purchaseordersubstatus_RecurringAppointmentMasters)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_purchaseordersubstatus`|
|ReferencedAttribute|`msdyn_purchaseordersubstatusid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_purchaseordersubstatus_recurringappointmentmaster`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_quotebookingincident_RecurringAppointmentMasters"></a> msdyn_quotebookingincident_RecurringAppointmentMasters

One-To-Many Relationship: [msdyn_quotebookingincident msdyn_quotebookingincident_RecurringAppointmentMasters](msdyn_quotebookingincident.md#BKMK_msdyn_quotebookingincident_RecurringAppointmentMasters)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_quotebookingincident`|
|ReferencedAttribute|`msdyn_quotebookingincidentid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_quotebookingincident_recurringappointmentmaster`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_quotebookingproduct_RecurringAppointmentMasters"></a> msdyn_quotebookingproduct_RecurringAppointmentMasters

One-To-Many Relationship: [msdyn_quotebookingproduct msdyn_quotebookingproduct_RecurringAppointmentMasters](msdyn_quotebookingproduct.md#BKMK_msdyn_quotebookingproduct_RecurringAppointmentMasters)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_quotebookingproduct`|
|ReferencedAttribute|`msdyn_quotebookingproductid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_quotebookingproduct_recurringappointmentmaster`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_quotebookingservice_RecurringAppointmentMasters"></a> msdyn_quotebookingservice_RecurringAppointmentMasters

One-To-Many Relationship: [msdyn_quotebookingservice msdyn_quotebookingservice_RecurringAppointmentMasters](msdyn_quotebookingservice.md#BKMK_msdyn_quotebookingservice_RecurringAppointmentMasters)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_quotebookingservice`|
|ReferencedAttribute|`msdyn_quotebookingserviceid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_quotebookingservice_recurringappointmentmaster`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_quotebookingservicetask_RecurringAppointmentMasters"></a> msdyn_quotebookingservicetask_RecurringAppointmentMasters

One-To-Many Relationship: [msdyn_quotebookingservicetask msdyn_quotebookingservicetask_RecurringAppointmentMasters](msdyn_quotebookingservicetask.md#BKMK_msdyn_quotebookingservicetask_RecurringAppointmentMasters)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_quotebookingservicetask`|
|ReferencedAttribute|`msdyn_quotebookingservicetaskid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_quotebookingservicetask_recurringappointmentmaster`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_resourceterritory_RecurringAppointmentMasters"></a> msdyn_resourceterritory_RecurringAppointmentMasters

One-To-Many Relationship: [msdyn_resourceterritory msdyn_resourceterritory_RecurringAppointmentMasters](msdyn_resourceterritory.md#BKMK_msdyn_resourceterritory_RecurringAppointmentMasters)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_resourceterritory`|
|ReferencedAttribute|`msdyn_resourceterritoryid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_resourceterritory_recurringappointmentmaster`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_rma_RecurringAppointmentMasters"></a> msdyn_rma_RecurringAppointmentMasters

One-To-Many Relationship: [msdyn_rma msdyn_rma_RecurringAppointmentMasters](msdyn_rma.md#BKMK_msdyn_rma_RecurringAppointmentMasters)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_rma`|
|ReferencedAttribute|`msdyn_rmaid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_rma_recurringappointmentmaster`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_rmaproduct_RecurringAppointmentMasters"></a> msdyn_rmaproduct_RecurringAppointmentMasters

One-To-Many Relationship: [msdyn_rmaproduct msdyn_rmaproduct_RecurringAppointmentMasters](msdyn_rmaproduct.md#BKMK_msdyn_rmaproduct_RecurringAppointmentMasters)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_rmaproduct`|
|ReferencedAttribute|`msdyn_rmaproductid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_rmaproduct_recurringappointmentmaster`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_rmareceipt_RecurringAppointmentMasters"></a> msdyn_rmareceipt_RecurringAppointmentMasters

One-To-Many Relationship: [msdyn_rmareceipt msdyn_rmareceipt_RecurringAppointmentMasters](msdyn_rmareceipt.md#BKMK_msdyn_rmareceipt_RecurringAppointmentMasters)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_rmareceipt`|
|ReferencedAttribute|`msdyn_rmareceiptid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_rmareceipt_recurringappointmentmaster`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_rmareceiptproduct_RecurringAppointmentMasters"></a> msdyn_rmareceiptproduct_RecurringAppointmentMasters

One-To-Many Relationship: [msdyn_rmareceiptproduct msdyn_rmareceiptproduct_RecurringAppointmentMasters](msdyn_rmareceiptproduct.md#BKMK_msdyn_rmareceiptproduct_RecurringAppointmentMasters)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_rmareceiptproduct`|
|ReferencedAttribute|`msdyn_rmareceiptproductid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_rmareceiptproduct_recurringappointmentmaster`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_rmasubstatus_RecurringAppointmentMasters"></a> msdyn_rmasubstatus_RecurringAppointmentMasters

One-To-Many Relationship: [msdyn_rmasubstatus msdyn_rmasubstatus_RecurringAppointmentMasters](msdyn_rmasubstatus.md#BKMK_msdyn_rmasubstatus_RecurringAppointmentMasters)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_rmasubstatus`|
|ReferencedAttribute|`msdyn_rmasubstatusid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_rmasubstatus_recurringappointmentmaster`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_rtv_RecurringAppointmentMasters"></a> msdyn_rtv_RecurringAppointmentMasters

One-To-Many Relationship: [msdyn_rtv msdyn_rtv_RecurringAppointmentMasters](msdyn_rtv.md#BKMK_msdyn_rtv_RecurringAppointmentMasters)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_rtv`|
|ReferencedAttribute|`msdyn_rtvid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_rtv_recurringappointmentmaster`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_rtvproduct_RecurringAppointmentMasters"></a> msdyn_rtvproduct_RecurringAppointmentMasters

One-To-Many Relationship: [msdyn_rtvproduct msdyn_rtvproduct_RecurringAppointmentMasters](msdyn_rtvproduct.md#BKMK_msdyn_rtvproduct_RecurringAppointmentMasters)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_rtvproduct`|
|ReferencedAttribute|`msdyn_rtvproductid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_rtvproduct_recurringappointmentmaster`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_rtvsubstatus_RecurringAppointmentMasters"></a> msdyn_rtvsubstatus_RecurringAppointmentMasters

One-To-Many Relationship: [msdyn_rtvsubstatus msdyn_rtvsubstatus_RecurringAppointmentMasters](msdyn_rtvsubstatus.md#BKMK_msdyn_rtvsubstatus_RecurringAppointmentMasters)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_rtvsubstatus`|
|ReferencedAttribute|`msdyn_rtvsubstatusid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_rtvsubstatus_recurringappointmentmaster`|
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

### <a name="BKMK_msdyn_shipvia_RecurringAppointmentMasters"></a> msdyn_shipvia_RecurringAppointmentMasters

One-To-Many Relationship: [msdyn_shipvia msdyn_shipvia_RecurringAppointmentMasters](msdyn_shipvia.md#BKMK_msdyn_shipvia_RecurringAppointmentMasters)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_shipvia`|
|ReferencedAttribute|`msdyn_shipviaid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_shipvia_recurringappointmentmaster`|
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

### <a name="BKMK_msdyn_systemuserschedulersetting_RecurringAppointmentMasters"></a> msdyn_systemuserschedulersetting_RecurringAppointmentMasters

One-To-Many Relationship: [msdyn_systemuserschedulersetting msdyn_systemuserschedulersetting_RecurringAppointmentMasters](msdyn_systemuserschedulersetting.md#BKMK_msdyn_systemuserschedulersetting_RecurringAppointmentMasters)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_systemuserschedulersetting`|
|ReferencedAttribute|`msdyn_systemuserschedulersettingid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_systemuserschedulersetting_recurringappointmentmaster`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_timegroup_RecurringAppointmentMasters"></a> msdyn_timegroup_RecurringAppointmentMasters

One-To-Many Relationship: [msdyn_timegroup msdyn_timegroup_RecurringAppointmentMasters](msdyn_timegroup.md#BKMK_msdyn_timegroup_RecurringAppointmentMasters)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_timegroup`|
|ReferencedAttribute|`msdyn_timegroupid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_timegroup_recurringappointmentmaster`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_timegroupdetail_RecurringAppointmentMasters"></a> msdyn_timegroupdetail_RecurringAppointmentMasters

One-To-Many Relationship: [msdyn_timegroupdetail msdyn_timegroupdetail_RecurringAppointmentMasters](msdyn_timegroupdetail.md#BKMK_msdyn_timegroupdetail_RecurringAppointmentMasters)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_timegroupdetail`|
|ReferencedAttribute|`msdyn_timegroupdetailid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_timegroupdetail_recurringappointmentmaster`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_timeoffrequest_RecurringAppointmentMasters"></a> msdyn_timeoffrequest_RecurringAppointmentMasters

One-To-Many Relationship: [msdyn_timeoffrequest msdyn_timeoffrequest_RecurringAppointmentMasters](msdyn_timeoffrequest.md#BKMK_msdyn_timeoffrequest_RecurringAppointmentMasters)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_timeoffrequest`|
|ReferencedAttribute|`msdyn_timeoffrequestid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_timeoffrequest_recurringappointmentmaster`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_warehouse_RecurringAppointmentMasters"></a> msdyn_warehouse_RecurringAppointmentMasters

One-To-Many Relationship: [msdyn_warehouse msdyn_warehouse_RecurringAppointmentMasters](msdyn_warehouse.md#BKMK_msdyn_warehouse_RecurringAppointmentMasters)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_warehouse`|
|ReferencedAttribute|`msdyn_warehouseid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_warehouse_recurringappointmentmaster`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_workorder_RecurringAppointmentMasters"></a> msdyn_workorder_RecurringAppointmentMasters

One-To-Many Relationship: [msdyn_workorder msdyn_workorder_RecurringAppointmentMasters](msdyn_workorder.md#BKMK_msdyn_workorder_RecurringAppointmentMasters)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_workorder`|
|ReferencedAttribute|`msdyn_workorderid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_workorder_recurringappointmentmaster`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_workordercharacteristic_RecurringAppointmentMasters"></a> msdyn_workordercharacteristic_RecurringAppointmentMasters

One-To-Many Relationship: [msdyn_workordercharacteristic msdyn_workordercharacteristic_RecurringAppointmentMasters](msdyn_workordercharacteristic.md#BKMK_msdyn_workordercharacteristic_RecurringAppointmentMasters)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_workordercharacteristic`|
|ReferencedAttribute|`msdyn_workordercharacteristicid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_workordercharacteristic_recurringappointmentmaster`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_workorderincident_RecurringAppointmentMasters"></a> msdyn_workorderincident_RecurringAppointmentMasters

One-To-Many Relationship: [msdyn_workorderincident msdyn_workorderincident_RecurringAppointmentMasters](msdyn_workorderincident.md#BKMK_msdyn_workorderincident_RecurringAppointmentMasters)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_workorderincident`|
|ReferencedAttribute|`msdyn_workorderincidentid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_workorderincident_recurringappointmentmaster`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_workorderproduct_RecurringAppointmentMasters"></a> msdyn_workorderproduct_RecurringAppointmentMasters

One-To-Many Relationship: [msdyn_workorderproduct msdyn_workorderproduct_RecurringAppointmentMasters](msdyn_workorderproduct.md#BKMK_msdyn_workorderproduct_RecurringAppointmentMasters)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_workorderproduct`|
|ReferencedAttribute|`msdyn_workorderproductid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_workorderproduct_recurringappointmentmaster`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_workorderresourcerestriction_RecurringAppointmentMasters"></a> msdyn_workorderresourcerestriction_RecurringAppointmentMasters

One-To-Many Relationship: [msdyn_workorderresourcerestriction msdyn_workorderresourcerestriction_RecurringAppointmentMasters](msdyn_workorderresourcerestriction.md#BKMK_msdyn_workorderresourcerestriction_RecurringAppointmentMasters)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_workorderresourcerestriction`|
|ReferencedAttribute|`msdyn_workorderresourcerestrictionid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_workorderresourcerestriction_recurringappointmentmaster`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_workorderservice_RecurringAppointmentMasters"></a> msdyn_workorderservice_RecurringAppointmentMasters

One-To-Many Relationship: [msdyn_workorderservice msdyn_workorderservice_RecurringAppointmentMasters](msdyn_workorderservice.md#BKMK_msdyn_workorderservice_RecurringAppointmentMasters)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_workorderservice`|
|ReferencedAttribute|`msdyn_workorderserviceid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_workorderservice_recurringappointmentmaster`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_workorderservicetask_RecurringAppointmentMasters"></a> msdyn_workorderservicetask_RecurringAppointmentMasters

One-To-Many Relationship: [msdyn_workorderservicetask msdyn_workorderservicetask_RecurringAppointmentMasters](msdyn_workorderservicetask.md#BKMK_msdyn_workorderservicetask_RecurringAppointmentMasters)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_workorderservicetask`|
|ReferencedAttribute|`msdyn_workorderservicetaskid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_workorderservicetask_recurringappointmentmaster`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyncrm_contentsettings_RecurringAppointmentMasters"></a> msdyncrm_contentsettings_RecurringAppointmentMasters

One-To-Many Relationship: [msdyncrm_contentsettings msdyncrm_contentsettings_RecurringAppointmentMasters](msdyncrm_contentsettings.md#BKMK_msdyncrm_contentsettings_RecurringAppointmentMasters)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyncrm_contentsettings`|
|ReferencedAttribute|`msdyncrm_contentsettingsid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyncrm_contentsettings_recurringappointmentmaster`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyncrm_customerjourney_RecurringAppointmentMasters"></a> msdyncrm_customerjourney_RecurringAppointmentMasters

One-To-Many Relationship: [msdyncrm_customerjourney msdyncrm_customerjourney_RecurringAppointmentMasters](msdyncrm_customerjourney.md#BKMK_msdyncrm_customerjourney_RecurringAppointmentMasters)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyncrm_customerjourney`|
|ReferencedAttribute|`msdyncrm_customerjourneyid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyncrm_customerjourney_recurringappointmentmaster`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyncrm_leadscoremodel_RecurringAppointmentMasters"></a> msdyncrm_leadscoremodel_RecurringAppointmentMasters

One-To-Many Relationship: [msdyncrm_leadscoremodel msdyncrm_leadscoremodel_RecurringAppointmentMasters](msdyncrm_leadscoremodel.md#BKMK_msdyncrm_leadscoremodel_RecurringAppointmentMasters)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyncrm_leadscoremodel`|
|ReferencedAttribute|`msdyncrm_leadscoremodelid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyncrm_leadscoremodel_recurringappointmentmaster`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyncrm_linkedinaccount_RecurringAppointmentMasters"></a> msdyncrm_linkedinaccount_RecurringAppointmentMasters

One-To-Many Relationship: [msdyncrm_linkedinaccount msdyncrm_linkedinaccount_RecurringAppointmentMasters](msdyncrm_linkedinaccount.md#BKMK_msdyncrm_linkedinaccount_RecurringAppointmentMasters)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyncrm_linkedinaccount`|
|ReferencedAttribute|`msdyncrm_linkedinaccountid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyncrm_linkedinaccount_recurringappointmentmaster`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyncrm_linkedinactivity_RecurringAppointmentMasters"></a> msdyncrm_linkedinactivity_RecurringAppointmentMasters

One-To-Many Relationship: [msdyncrm_linkedinactivity msdyncrm_linkedinactivity_RecurringAppointmentMasters](msdyncrm_linkedinactivity.md#BKMK_msdyncrm_linkedinactivity_RecurringAppointmentMasters)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyncrm_linkedinactivity`|
|ReferencedAttribute|`msdyncrm_linkedinactivityid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyncrm_linkedinactivity_recurringappointmentmaster`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyncrm_linkedinfieldmapping_RecurringAppointmentMasters"></a> msdyncrm_linkedinfieldmapping_RecurringAppointmentMasters

One-To-Many Relationship: [msdyncrm_linkedinfieldmapping msdyncrm_linkedinfieldmapping_RecurringAppointmentMasters](msdyncrm_linkedinfieldmapping.md#BKMK_msdyncrm_linkedinfieldmapping_RecurringAppointmentMasters)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyncrm_linkedinfieldmapping`|
|ReferencedAttribute|`msdyncrm_linkedinfieldmappingid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyncrm_linkedinfieldmapping_recurringappointmentmaster`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyncrm_linkedinform_RecurringAppointmentMasters"></a> msdyncrm_linkedinform_RecurringAppointmentMasters

One-To-Many Relationship: [msdyncrm_linkedinform msdyncrm_linkedinform_RecurringAppointmentMasters](msdyncrm_linkedinform.md#BKMK_msdyncrm_linkedinform_RecurringAppointmentMasters)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyncrm_linkedinform`|
|ReferencedAttribute|`msdyncrm_linkedinformid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyncrm_linkedinform_recurringappointmentmaster`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyncrm_linkedinformanswer_RecurringAppointmentMasters"></a> msdyncrm_linkedinformanswer_RecurringAppointmentMasters

One-To-Many Relationship: [msdyncrm_linkedinformanswer msdyncrm_linkedinformanswer_RecurringAppointmentMasters](msdyncrm_linkedinformanswer.md#BKMK_msdyncrm_linkedinformanswer_RecurringAppointmentMasters)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyncrm_linkedinformanswer`|
|ReferencedAttribute|`msdyncrm_linkedinformanswerid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyncrm_linkedinformanswer_recurringappointmentmaster`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyncrm_linkedinformquestion_RecurringAppointmentMasters"></a> msdyncrm_linkedinformquestion_RecurringAppointmentMasters

One-To-Many Relationship: [msdyncrm_linkedinformquestion msdyncrm_linkedinformquestion_RecurringAppointmentMasters](msdyncrm_linkedinformquestion.md#BKMK_msdyncrm_linkedinformquestion_RecurringAppointmentMasters)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyncrm_linkedinformquestion`|
|ReferencedAttribute|`msdyncrm_linkedinformquestionid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyncrm_linkedinformquestion_recurringappointmentmaster`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyncrm_linkedinformsubmission_RecurringAppointmentMasters"></a> msdyncrm_linkedinformsubmission_RecurringAppointmentMasters

One-To-Many Relationship: [msdyncrm_linkedinformsubmission msdyncrm_linkedinformsubmission_RecurringAppointmentMasters](msdyncrm_linkedinformsubmission.md#BKMK_msdyncrm_linkedinformsubmission_RecurringAppointmentMasters)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyncrm_linkedinformsubmission`|
|ReferencedAttribute|`msdyncrm_linkedinformsubmissionid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyncrm_linkedinformsubmission_recurringappointmentmaster`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyncrm_linkedinleadmatchingstrategy_RecurringAppointmentMasters"></a> msdyncrm_linkedinleadmatchingstrategy_RecurringAppointmentMasters

One-To-Many Relationship: [msdyncrm_linkedinleadmatchingstrategy msdyncrm_linkedinleadmatchingstrategy_RecurringAppointmentMasters](msdyncrm_linkedinleadmatchingstrategy.md#BKMK_msdyncrm_linkedinleadmatchingstrategy_RecurringAppointmentMasters)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyncrm_linkedinleadmatchingstrategy`|
|ReferencedAttribute|`msdyncrm_linkedinleadmatchingstrategyid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyncrm_linkedinleadmatchingstrategy_recurringappointmentmaster`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyncrm_linkedinuserprofile_RecurringAppointmentMasters"></a> msdyncrm_linkedinuserprofile_RecurringAppointmentMasters

One-To-Many Relationship: [msdyncrm_linkedinuserprofile msdyncrm_linkedinuserprofile_RecurringAppointmentMasters](msdyncrm_linkedinuserprofile.md#BKMK_msdyncrm_linkedinuserprofile_RecurringAppointmentMasters)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyncrm_linkedinuserprofile`|
|ReferencedAttribute|`msdyncrm_linkedinuserprofileid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyncrm_linkedinuserprofile_recurringappointmentmaster`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyncrm_marketingdynamiccontentmetadata_RecurringAppointmentMasters"></a> msdyncrm_marketingdynamiccontentmetadata_RecurringAppointmentMasters

One-To-Many Relationship: [msdyncrm_marketingdynamiccontentmetadata msdyncrm_marketingdynamiccontentmetadata_RecurringAppointmentMasters](msdyncrm_marketingdynamiccontentmetadata.md#BKMK_msdyncrm_marketingdynamiccontentmetadata_RecurringAppointmentMasters)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyncrm_marketingdynamiccontentmetadata`|
|ReferencedAttribute|`msdyncrm_marketingdynamiccontentmetadataid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyncrm_marketingdynamiccontentmetadata_recurringappointmentmaster`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyncrm_marketingemaildynamiccontentmetadata_RecurringAppointmentMasters"></a> msdyncrm_marketingemaildynamiccontentmetadata_RecurringAppointmentMasters

One-To-Many Relationship: [msdyncrm_marketingemaildynamiccontentmetadata msdyncrm_marketingemaildynamiccontentmetadata_RecurringAppointmentMasters](msdyncrm_marketingemaildynamiccontentmetadata.md#BKMK_msdyncrm_marketingemaildynamiccontentmetadata_RecurringAppointmentMasters)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyncrm_marketingemaildynamiccontentmetadata`|
|ReferencedAttribute|`msdyncrm_marketingemaildynamiccontentmetadataid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyncrm_marketingemaildynamiccontentmetadata_recurringappointmentmaster`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyncrm_marketingemailtestsend_RecurringAppointmentMasters"></a> msdyncrm_marketingemailtestsend_RecurringAppointmentMasters

One-To-Many Relationship: [msdyncrm_marketingemailtestsend msdyncrm_marketingemailtestsend_RecurringAppointmentMasters](msdyncrm_marketingemailtestsend.md#BKMK_msdyncrm_marketingemailtestsend_RecurringAppointmentMasters)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyncrm_marketingemailtestsend`|
|ReferencedAttribute|`msdyncrm_marketingemailtestsendid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyncrm_marketingemailtestsend_recurringappointmentmaster`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyncrm_migration_RecurringAppointmentMasters"></a> msdyncrm_migration_RecurringAppointmentMasters

One-To-Many Relationship: [msdyncrm_migration msdyncrm_migration_RecurringAppointmentMasters](msdyncrm_migration.md#BKMK_msdyncrm_migration_RecurringAppointmentMasters)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyncrm_migration`|
|ReferencedAttribute|`msdyncrm_migrationid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyncrm_migration_recurringappointmentmaster`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyncrm_uicconfig_RecurringAppointmentMasters"></a> msdyncrm_uicconfig_RecurringAppointmentMasters

One-To-Many Relationship: [msdyncrm_uicconfig msdyncrm_uicconfig_RecurringAppointmentMasters](msdyncrm_uicconfig.md#BKMK_msdyncrm_uicconfig_RecurringAppointmentMasters)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyncrm_uicconfig`|
|ReferencedAttribute|`msdyncrm_uicconfigid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyncrm_uicconfig_recurringappointmentmaster`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msevtmgt_checkin_RecurringAppointmentMasters"></a> msevtmgt_checkin_RecurringAppointmentMasters

One-To-Many Relationship: [msevtmgt_checkin msevtmgt_checkin_RecurringAppointmentMasters](msevtmgt_checkin.md#BKMK_msevtmgt_checkin_RecurringAppointmentMasters)

|Property|Value|
|---|---|
|ReferencedEntity|`msevtmgt_checkin`|
|ReferencedAttribute|`msevtmgt_checkinid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msevtmgt_checkin_recurringappointmentmaster`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msevtmgt_event_RecurringAppointmentMasters"></a> msevtmgt_event_RecurringAppointmentMasters

One-To-Many Relationship: [msevtmgt_event msevtmgt_event_RecurringAppointmentMasters](msevtmgt_event.md#BKMK_msevtmgt_event_RecurringAppointmentMasters)

|Property|Value|
|---|---|
|ReferencedEntity|`msevtmgt_event`|
|ReferencedAttribute|`msevtmgt_eventid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msevtmgt_event_recurringappointmentmaster`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msevtmgt_eventpurchase_RecurringAppointmentMasters"></a> msevtmgt_eventpurchase_RecurringAppointmentMasters

One-To-Many Relationship: [msevtmgt_eventpurchase msevtmgt_eventpurchase_RecurringAppointmentMasters](msevtmgt_eventpurchase.md#BKMK_msevtmgt_eventpurchase_RecurringAppointmentMasters)

|Property|Value|
|---|---|
|ReferencedEntity|`msevtmgt_eventpurchase`|
|ReferencedAttribute|`msevtmgt_eventpurchaseid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msevtmgt_eventpurchase_recurringappointmentmaster`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msevtmgt_eventpurchaseattendee_RecurringAppointmentMasters"></a> msevtmgt_eventpurchaseattendee_RecurringAppointmentMasters

One-To-Many Relationship: [msevtmgt_eventpurchaseattendee msevtmgt_eventpurchaseattendee_RecurringAppointmentMasters](msevtmgt_eventpurchaseattendee.md#BKMK_msevtmgt_eventpurchaseattendee_RecurringAppointmentMasters)

|Property|Value|
|---|---|
|ReferencedEntity|`msevtmgt_eventpurchaseattendee`|
|ReferencedAttribute|`msevtmgt_eventpurchaseattendeeid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msevtmgt_eventpurchaseattendee_recurringappointmentmaster`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msevtmgt_eventpurchasepass_RecurringAppointmentMasters"></a> msevtmgt_eventpurchasepass_RecurringAppointmentMasters

One-To-Many Relationship: [msevtmgt_eventpurchasepass msevtmgt_eventpurchasepass_RecurringAppointmentMasters](msevtmgt_eventpurchasepass.md#BKMK_msevtmgt_eventpurchasepass_RecurringAppointmentMasters)

|Property|Value|
|---|---|
|ReferencedEntity|`msevtmgt_eventpurchasepass`|
|ReferencedAttribute|`msevtmgt_eventpurchasepassid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msevtmgt_eventpurchasepass_recurringappointmentmaster`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msevtmgt_eventregistration_RecurringAppointmentMasters"></a> msevtmgt_eventregistration_RecurringAppointmentMasters

One-To-Many Relationship: [msevtmgt_eventregistration msevtmgt_eventregistration_RecurringAppointmentMasters](msevtmgt_eventregistration.md#BKMK_msevtmgt_eventregistration_RecurringAppointmentMasters)

|Property|Value|
|---|---|
|ReferencedEntity|`msevtmgt_eventregistration`|
|ReferencedAttribute|`msevtmgt_eventregistrationid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msevtmgt_eventregistration_recurringappointmentmaster`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msevtmgt_hotel_RecurringAppointmentMasters"></a> msevtmgt_hotel_RecurringAppointmentMasters

One-To-Many Relationship: [msevtmgt_hotel msevtmgt_hotel_RecurringAppointmentMasters](msevtmgt_hotel.md#BKMK_msevtmgt_hotel_RecurringAppointmentMasters)

|Property|Value|
|---|---|
|ReferencedEntity|`msevtmgt_hotel`|
|ReferencedAttribute|`msevtmgt_hotelid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msevtmgt_hotel_recurringappointmentmaster`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msevtmgt_hotelroomallocation_RecurringAppointmentMasters"></a> msevtmgt_hotelroomallocation_RecurringAppointmentMasters

One-To-Many Relationship: [msevtmgt_hotelroomallocation msevtmgt_hotelroomallocation_RecurringAppointmentMasters](msevtmgt_hotelroomallocation.md#BKMK_msevtmgt_hotelroomallocation_RecurringAppointmentMasters)

|Property|Value|
|---|---|
|ReferencedEntity|`msevtmgt_hotelroomallocation`|
|ReferencedAttribute|`msevtmgt_hotelroomallocationid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msevtmgt_hotelroomallocation_recurringappointmentmaster`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msevtmgt_hotelroomreservation_RecurringAppointmentMasters"></a> msevtmgt_hotelroomreservation_RecurringAppointmentMasters

One-To-Many Relationship: [msevtmgt_hotelroomreservation msevtmgt_hotelroomreservation_RecurringAppointmentMasters](msevtmgt_hotelroomreservation.md#BKMK_msevtmgt_hotelroomreservation_RecurringAppointmentMasters)

|Property|Value|
|---|---|
|ReferencedEntity|`msevtmgt_hotelroomreservation`|
|ReferencedAttribute|`msevtmgt_hotelroomreservationid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msevtmgt_hotelroomreservation_recurringappointmentmaster`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msevtmgt_layout_RecurringAppointmentMasters"></a> msevtmgt_layout_RecurringAppointmentMasters

One-To-Many Relationship: [msevtmgt_layout msevtmgt_layout_RecurringAppointmentMasters](msevtmgt_layout.md#BKMK_msevtmgt_layout_RecurringAppointmentMasters)

|Property|Value|
|---|---|
|ReferencedEntity|`msevtmgt_layout`|
|ReferencedAttribute|`msevtmgt_layoutid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msevtmgt_layout_recurringappointmentmaster`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msevtmgt_room_RecurringAppointmentMasters"></a> msevtmgt_room_RecurringAppointmentMasters

One-To-Many Relationship: [msevtmgt_room msevtmgt_room_RecurringAppointmentMasters](msevtmgt_room.md#BKMK_msevtmgt_room_RecurringAppointmentMasters)

|Property|Value|
|---|---|
|ReferencedEntity|`msevtmgt_room`|
|ReferencedAttribute|`msevtmgt_roomid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msevtmgt_room_recurringappointmentmaster`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msevtmgt_session_RecurringAppointmentMasters"></a> msevtmgt_session_RecurringAppointmentMasters

One-To-Many Relationship: [msevtmgt_session msevtmgt_session_RecurringAppointmentMasters](msevtmgt_session.md#BKMK_msevtmgt_session_RecurringAppointmentMasters)

|Property|Value|
|---|---|
|ReferencedEntity|`msevtmgt_session`|
|ReferencedAttribute|`msevtmgt_sessionid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msevtmgt_session_recurringappointmentmaster`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msevtmgt_sessionregistration_RecurringAppointmentMasters"></a> msevtmgt_sessionregistration_RecurringAppointmentMasters

One-To-Many Relationship: [msevtmgt_sessionregistration msevtmgt_sessionregistration_RecurringAppointmentMasters](msevtmgt_sessionregistration.md#BKMK_msevtmgt_sessionregistration_RecurringAppointmentMasters)

|Property|Value|
|---|---|
|ReferencedEntity|`msevtmgt_sessionregistration`|
|ReferencedAttribute|`msevtmgt_sessionregistrationid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msevtmgt_sessionregistration_recurringappointmentmaster`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msevtmgt_sessiontrack_RecurringAppointmentMasters"></a> msevtmgt_sessiontrack_RecurringAppointmentMasters

One-To-Many Relationship: [msevtmgt_sessiontrack msevtmgt_sessiontrack_RecurringAppointmentMasters](msevtmgt_sessiontrack.md#BKMK_msevtmgt_sessiontrack_RecurringAppointmentMasters)

|Property|Value|
|---|---|
|ReferencedEntity|`msevtmgt_sessiontrack`|
|ReferencedAttribute|`msevtmgt_sessiontrackid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msevtmgt_sessiontrack_recurringappointmentmaster`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msevtmgt_speaker_RecurringAppointmentMasters"></a> msevtmgt_speaker_RecurringAppointmentMasters

One-To-Many Relationship: [msevtmgt_speaker msevtmgt_speaker_RecurringAppointmentMasters](msevtmgt_speaker.md#BKMK_msevtmgt_speaker_RecurringAppointmentMasters)

|Property|Value|
|---|---|
|ReferencedEntity|`msevtmgt_speaker`|
|ReferencedAttribute|`msevtmgt_speakerid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msevtmgt_speaker_recurringappointmentmaster`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msevtmgt_speakerengagement_RecurringAppointmentMasters"></a> msevtmgt_speakerengagement_RecurringAppointmentMasters

One-To-Many Relationship: [msevtmgt_speakerengagement msevtmgt_speakerengagement_RecurringAppointmentMasters](msevtmgt_speakerengagement.md#BKMK_msevtmgt_speakerengagement_RecurringAppointmentMasters)

|Property|Value|
|---|---|
|ReferencedEntity|`msevtmgt_speakerengagement`|
|ReferencedAttribute|`msevtmgt_speakerengagementid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msevtmgt_speakerengagement_recurringappointmentmaster`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msevtmgt_sponsorablearticle_RecurringAppointmentMasters"></a> msevtmgt_sponsorablearticle_RecurringAppointmentMasters

One-To-Many Relationship: [msevtmgt_sponsorablearticle msevtmgt_sponsorablearticle_RecurringAppointmentMasters](msevtmgt_sponsorablearticle.md#BKMK_msevtmgt_sponsorablearticle_RecurringAppointmentMasters)

|Property|Value|
|---|---|
|ReferencedEntity|`msevtmgt_sponsorablearticle`|
|ReferencedAttribute|`msevtmgt_sponsorablearticleid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msevtmgt_sponsorablearticle_recurringappointmentmaster`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msevtmgt_sponsorship_RecurringAppointmentMasters"></a> msevtmgt_sponsorship_RecurringAppointmentMasters

One-To-Many Relationship: [msevtmgt_sponsorship msevtmgt_sponsorship_RecurringAppointmentMasters](msevtmgt_sponsorship.md#BKMK_msevtmgt_sponsorship_RecurringAppointmentMasters)

|Property|Value|
|---|---|
|ReferencedEntity|`msevtmgt_sponsorship`|
|ReferencedAttribute|`msevtmgt_sponsorshipid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msevtmgt_sponsorship_recurringappointmentmaster`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msevtmgt_venue_RecurringAppointmentMasters"></a> msevtmgt_venue_RecurringAppointmentMasters

One-To-Many Relationship: [msevtmgt_venue msevtmgt_venue_RecurringAppointmentMasters](msevtmgt_venue.md#BKMK_msevtmgt_venue_RecurringAppointmentMasters)

|Property|Value|
|---|---|
|ReferencedEntity|`msevtmgt_venue`|
|ReferencedAttribute|`msevtmgt_venueid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msevtmgt_venue_recurringappointmentmaster`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msevtmgt_webinarconfiguration_RecurringAppointmentMasters"></a> msevtmgt_webinarconfiguration_RecurringAppointmentMasters

One-To-Many Relationship: [msevtmgt_webinarconfiguration msevtmgt_webinarconfiguration_RecurringAppointmentMasters](msevtmgt_webinarconfiguration.md#BKMK_msevtmgt_webinarconfiguration_RecurringAppointmentMasters)

|Property|Value|
|---|---|
|ReferencedEntity|`msevtmgt_webinarconfiguration`|
|ReferencedAttribute|`msevtmgt_webinarconfigurationid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msevtmgt_webinarconfiguration_recurringappointmentmaster`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msevtmgt_webinarprovider_RecurringAppointmentMasters"></a> msevtmgt_webinarprovider_RecurringAppointmentMasters

One-To-Many Relationship: [msevtmgt_webinarprovider msevtmgt_webinarprovider_RecurringAppointmentMasters](msevtmgt_webinarprovider.md#BKMK_msevtmgt_webinarprovider_RecurringAppointmentMasters)

|Property|Value|
|---|---|
|ReferencedEntity|`msevtmgt_webinarprovider`|
|ReferencedAttribute|`msevtmgt_webinarproviderid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msevtmgt_webinarprovider_recurringappointmentmaster`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

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

[Dataverse table/entity reference](../about-entity-reference.md)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   
<xref:Microsoft.Dynamics.CRM.recurringappointmentmaster?displayProperty=fullName>
