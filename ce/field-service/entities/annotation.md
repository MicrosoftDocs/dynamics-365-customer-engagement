---
title: "Note (Annotation) table/entity reference (Microsoft Dynamics 365 Field Service)"
description: "Includes schema information and supported messages for the Note (Annotation) table/entity with Microsoft Dynamics 365 Field Service."
ms.date: 07.24.2024
ms.service: powerapps
ms.topic: reference
author: m-hartmann
ms.author: mhart
search.audienceType: 
  - developer
---

# Note (Annotation) table/entity reference

Note that is attached to one or more objects, including other notes.

> [!NOTE]
> The Microsoft Dynamics 365 Field Service Note (Annotation) table extends the [Microsoft Dataverse Note (Annotation) table](/power-apps/developer/data-platform/reference/entities/annotation).



## Customized columns/attributes

Microsoft Dynamics 365 Field Service modifies the definition of columns/attributes defined in other solutions. Listed by **SchemaName**.

### <a name="BKMK_ObjectId"></a> ObjectId

Changes from [ObjectId (Microsoft Dataverse)](/power-apps/developer/data-platform/reference/entities/annotation#BKMK_ObjectId)

|Property|Value|
|---|---|
|Targets|adx_ad|


## Many-to-One relationships

These relationships are many-to-one. Listed by **SchemaName**.

- [adx_ad_Annotations](#BKMK_adx_ad_Annotations)
- [adx_adplacement_Annotations](#BKMK_adx_adplacement_Annotations)
- [adx_alertsubscription_Annotations](#BKMK_adx_alertsubscription_Annotations)
- [adx_casedeflection_Annotations](#BKMK_adx_casedeflection_Annotations)
- [adx_communityforum_Annotations](#BKMK_adx_communityforum_Annotations)
- [adx_communityforumaccesspermission_Annotations](#BKMK_adx_communityforumaccesspermission_Annotations)
- [adx_communityforumannouncement_Annotations](#BKMK_adx_communityforumannouncement_Annotations)
- [adx_communityforumpost_Annotations](#BKMK_adx_communityforumpost_Annotations)
- [adx_communityforumthread_Annotations](#BKMK_adx_communityforumthread_Annotations)
- [adx_contentaccesslevel_Annotations](#BKMK_adx_contentaccesslevel_Annotations)
- [adx_entitypermission_Annotations](#BKMK_adx_entitypermission_Annotations)
- [adx_poll_Annotations](#BKMK_adx_poll_Annotations)
- [adx_polloption_Annotations](#BKMK_adx_polloption_Annotations)
- [adx_pollplacement_Annotations](#BKMK_adx_pollplacement_Annotations)
- [adx_pollsubmission_Annotations](#BKMK_adx_pollsubmission_Annotations)
- [adx_publishingstatetransitionrule_Annotations](#BKMK_adx_publishingstatetransitionrule_Annotations)
- [adx_redirect_Annotations](#BKMK_adx_redirect_Annotations)
- [adx_shortcut_Annotations](#BKMK_adx_shortcut_Annotations)
- [adx_sitesetting_Annotations](#BKMK_adx_sitesetting_Annotations)
- [adx_webfile_Annotations](#BKMK_adx_webfile_Annotations)
- [adx_weblink_Annotations](#BKMK_adx_weblink_Annotations)
- [adx_webnotificationurl_Annotations](#BKMK_adx_webnotificationurl_Annotations)
- [adx_webpage_Annotations](#BKMK_adx_webpage_Annotations)
- [adx_webrole_Annotations](#BKMK_adx_webrole_Annotations)
- [adx_website_Annotations](#BKMK_adx_website_Annotations)
- [adx_websitebinding_Annotations](#BKMK_adx_websitebinding_Annotations)
- [bookableresource_Annotations](#BKMK_bookableresource_Annotations)
- [bookableresourcebooking_Annotations](#BKMK_bookableresourcebooking_Annotations)
- [bookableresourcebookingheader_Annotations](#BKMK_bookableresourcebookingheader_Annotations)
- [bookableresourcecategoryassn_Annotations](#BKMK_bookableresourcecategoryassn_Annotations)
- [bookableresourcecharacteristic_Annotations](#BKMK_bookableresourcecharacteristic_Annotations)
- [bookableresourcegroup_Annotations](#BKMK_bookableresourcegroup_Annotations)
- [bulkoperation_Annotations](#BKMK_bulkoperation_Annotations)
- [Campaign_Annotation](#BKMK_Campaign_Annotation)
- [CampaignActivity_Annotation](#BKMK_CampaignActivity_Annotation)
- [CampaignResponse_Annotation](#BKMK_CampaignResponse_Annotation)
- [Competitor_Annotation](#BKMK_Competitor_Annotation)
- [Contract_Annotation](#BKMK_Contract_Annotation)
- [ContractDetail_Annotation](#BKMK_ContractDetail_Annotation)
- [entitlement_Annotations](#BKMK_entitlement_Annotations)
- [entitlementchannel_Annotations](#BKMK_entitlementchannel_Annotations)
- [entitlementtemplate_Annotations](#BKMK_entitlementtemplate_Annotations)
- [Equipment_Annotation](#BKMK_Equipment_Annotation)
- [Incident_Annotation](#BKMK_Incident_Annotation)
- [IncidentResolution_Annotation](#BKMK_IncidentResolution_Annotation)
- [Invoice_Annotation](#BKMK_Invoice_Annotation)
- [Lead_Annotation](#BKMK_Lead_Annotation)
- [li_inmail_Annotations](#BKMK_li_inmail_Annotations)
- [li_message_Annotations](#BKMK_li_message_Annotations)
- [li_pointdrivepresentationviewed_Annotations](#BKMK_li_pointdrivepresentationviewed_Annotations)
- [List_Annotation](#BKMK_List_Annotation)
- [msdyn_3dmodel_Annotations](#BKMK_msdyn_3dmodel_Annotations)
- [msdyn_actual_Annotations](#BKMK_msdyn_actual_Annotations)
- [msdyn_agreement_Annotations](#BKMK_msdyn_agreement_Annotations)
- [msdyn_agreementbookingdate_Annotations](#BKMK_msdyn_agreementbookingdate_Annotations)
- [msdyn_agreementbookingincident_Annotations](#BKMK_msdyn_agreementbookingincident_Annotations)
- [msdyn_agreementbookingproduct_Annotations](#BKMK_msdyn_agreementbookingproduct_Annotations)
- [msdyn_agreementbookingservice_Annotations](#BKMK_msdyn_agreementbookingservice_Annotations)
- [msdyn_agreementbookingservicetask_Annotations](#BKMK_msdyn_agreementbookingservicetask_Annotations)
- [msdyn_agreementbookingsetup_Annotations](#BKMK_msdyn_agreementbookingsetup_Annotations)
- [msdyn_agreementinvoicedate_Annotations](#BKMK_msdyn_agreementinvoicedate_Annotations)
- [msdyn_agreementinvoiceproduct_Annotations](#BKMK_msdyn_agreementinvoiceproduct_Annotations)
- [msdyn_agreementinvoicesetup_Annotations](#BKMK_msdyn_agreementinvoicesetup_Annotations)
- [msdyn_agreementsubstatus_Annotations](#BKMK_msdyn_agreementsubstatus_Annotations)
- [msdyn_bookingalert_Annotations](#BKMK_msdyn_bookingalert_Annotations)
- [msdyn_bookingalertstatus_Annotations](#BKMK_msdyn_bookingalertstatus_Annotations)
- [msdyn_bookingjournal_Annotations](#BKMK_msdyn_bookingjournal_Annotations)
- [msdyn_bookingrule_Annotations](#BKMK_msdyn_bookingrule_Annotations)
- [msdyn_bookingtimestamp_Annotations](#BKMK_msdyn_bookingtimestamp_Annotations)
- [msdyn_copilottranscript_Annotations](#BKMK_msdyn_copilottranscript_Annotations)
- [msdyn_customerasset_Annotations](#BKMK_msdyn_customerasset_Annotations)
- [msdyn_fieldservicesetting_Annotations](#BKMK_msdyn_fieldservicesetting_Annotations)
- [msdyn_forecastconfiguration_Annotations](#BKMK_msdyn_forecastconfiguration_Annotations)
- [msdyn_forecastpredictionstatus_Annotations](#BKMK_msdyn_forecastpredictionstatus_Annotations)
- [msdyn_functionallocation_Annotations](#BKMK_msdyn_functionallocation_Annotations)
- [msdyn_incidenttype_Annotations](#BKMK_msdyn_incidenttype_Annotations)
- [msdyn_incidenttypecharacteristic_Annotations](#BKMK_msdyn_incidenttypecharacteristic_Annotations)
- [msdyn_incidenttypeproduct_Annotations](#BKMK_msdyn_incidenttypeproduct_Annotations)
- [msdyn_incidenttypeservice_Annotations](#BKMK_msdyn_incidenttypeservice_Annotations)
- [msdyn_incidenttypessetup_Annotations](#BKMK_msdyn_incidenttypessetup_Annotations)
- [msdyn_inspectionattachment_Annotations](#BKMK_msdyn_inspectionattachment_Annotations)
- [msdyn_insurance_Annotations](#BKMK_msdyn_insurance_Annotations)
- [msdyn_inventoryadjustment_Annotations](#BKMK_msdyn_inventoryadjustment_Annotations)
- [msdyn_inventoryadjustmentproduct_Annotations](#BKMK_msdyn_inventoryadjustmentproduct_Annotations)
- [msdyn_inventoryjournal_Annotations](#BKMK_msdyn_inventoryjournal_Annotations)
- [msdyn_inventorytransfer_Annotations](#BKMK_msdyn_inventorytransfer_Annotations)
- [msdyn_iotalert_Annotations](#BKMK_msdyn_iotalert_Annotations)
- [msdyn_iotdevice_Annotations](#BKMK_msdyn_iotdevice_Annotations)
- [msdyn_iotdevicecategory_Annotations](#BKMK_msdyn_iotdevicecategory_Annotations)
- [msdyn_iotdevicecommand_Annotations](#BKMK_msdyn_iotdevicecommand_Annotations)
- [msdyn_iotdeviceregistrationhistory_Annotations](#BKMK_msdyn_iotdeviceregistrationhistory_Annotations)
- [msdyn_liveconversation_Annotations](#BKMK_msdyn_liveconversation_Annotations)
- [msdyn_objectanchor_Annotations](#BKMK_msdyn_objectanchor_Annotations)
- [msdyn_ocflaggedspam_Annotations](#BKMK_msdyn_ocflaggedspam_Annotations)
- [msdyn_ocliveworkitem_Annotations](#BKMK_msdyn_ocliveworkitem_Annotations)
- [msdyn_ocoutboundmessage_Annotations](#BKMK_msdyn_ocoutboundmessage_Annotations)
- [msdyn_ocsession_Annotations](#BKMK_msdyn_ocsession_Annotations)
- [msdyn_ocvoicemail_Annotations](#BKMK_msdyn_ocvoicemail_Annotations)
- [msdyn_organizationalunit_Annotations](#BKMK_msdyn_organizationalunit_Annotations)
- [msdyn_overflowactionconfig_Annotations](#BKMK_msdyn_overflowactionconfig_Annotations)
- [msdyn_payment_Annotations](#BKMK_msdyn_payment_Annotations)
- [msdyn_paymentdetail_Annotations](#BKMK_msdyn_paymentdetail_Annotations)
- [msdyn_paymentmethod_Annotations](#BKMK_msdyn_paymentmethod_Annotations)
- [msdyn_paymentterm_Annotations](#BKMK_msdyn_paymentterm_Annotations)
- [msdyn_personalsoundsetting_Annotations](#BKMK_msdyn_personalsoundsetting_Annotations)
- [msdyn_playbookinstance_Annotations](#BKMK_msdyn_playbookinstance_Annotations)
- [msdyn_playbooktemplate_Annotations](#BKMK_msdyn_playbooktemplate_Annotations)
- [msdyn_postalbum_Annotations](#BKMK_msdyn_postalbum_Annotations)
- [msdyn_postalcode_Annotations](#BKMK_msdyn_postalcode_Annotations)
- [msdyn_priority_Annotations](#BKMK_msdyn_priority_Annotations)
- [msdyn_productinventory_Annotations](#BKMK_msdyn_productinventory_Annotations)
- [msdyn_purchaseorder_Annotations](#BKMK_msdyn_purchaseorder_Annotations)
- [msdyn_purchaseorderbill_Annotations](#BKMK_msdyn_purchaseorderbill_Annotations)
- [msdyn_purchaseorderproduct_Annotations](#BKMK_msdyn_purchaseorderproduct_Annotations)
- [msdyn_purchaseorderreceipt_Annotations](#BKMK_msdyn_purchaseorderreceipt_Annotations)
- [msdyn_purchaseorderreceiptproduct_Annotations](#BKMK_msdyn_purchaseorderreceiptproduct_Annotations)
- [msdyn_purchaseordersubstatus_Annotations](#BKMK_msdyn_purchaseordersubstatus_Annotations)
- [msdyn_quotebookingincident_Annotations](#BKMK_msdyn_quotebookingincident_Annotations)
- [msdyn_quotebookingproduct_Annotations](#BKMK_msdyn_quotebookingproduct_Annotations)
- [msdyn_quotebookingservice_Annotations](#BKMK_msdyn_quotebookingservice_Annotations)
- [msdyn_quotebookingservicetask_Annotations](#BKMK_msdyn_quotebookingservicetask_Annotations)
- [msdyn_requirementcharacteristic_Annotations](#BKMK_msdyn_requirementcharacteristic_Annotations)
- [msdyn_requirementresourcecategory_Annotations](#BKMK_msdyn_requirementresourcecategory_Annotations)
- [msdyn_requirementresourcepreference_Annotations](#BKMK_msdyn_requirementresourcepreference_Annotations)
- [msdyn_requirementstatus_Annotations](#BKMK_msdyn_requirementstatus_Annotations)
- [msdyn_resourcepaytype_Annotations](#BKMK_msdyn_resourcepaytype_Annotations)
- [msdyn_resourcerequirement_Annotations](#BKMK_msdyn_resourcerequirement_Annotations)
- [msdyn_resourcerequirementdetail_Annotations](#BKMK_msdyn_resourcerequirementdetail_Annotations)
- [msdyn_resourceterritory_Annotations](#BKMK_msdyn_resourceterritory_Annotations)
- [msdyn_rma_Annotations](#BKMK_msdyn_rma_Annotations)
- [msdyn_rmaproduct_Annotations](#BKMK_msdyn_rmaproduct_Annotations)
- [msdyn_rmareceipt_Annotations](#BKMK_msdyn_rmareceipt_Annotations)
- [msdyn_rmareceiptproduct_Annotations](#BKMK_msdyn_rmareceiptproduct_Annotations)
- [msdyn_rmasubstatus_Annotations](#BKMK_msdyn_rmasubstatus_Annotations)
- [msdyn_rtv_Annotations](#BKMK_msdyn_rtv_Annotations)
- [msdyn_rtvproduct_Annotations](#BKMK_msdyn_rtvproduct_Annotations)
- [msdyn_rtvsubstatus_Annotations](#BKMK_msdyn_rtvsubstatus_Annotations)
- [msdyn_salessuggestion_Annotations](#BKMK_msdyn_salessuggestion_Annotations)
- [msdyn_servicetasktype_Annotations](#BKMK_msdyn_servicetasktype_Annotations)
- [msdyn_shipvia_Annotations](#BKMK_msdyn_shipvia_Annotations)
- [msdyn_soundfile_Annotations](#BKMK_msdyn_soundfile_Annotations)
- [msdyn_soundnotificationsetting_Annotations](#BKMK_msdyn_soundnotificationsetting_Annotations)
- [msdyn_swarm_Annotations](#BKMK_msdyn_swarm_Annotations)
- [msdyn_systemuserschedulersetting_Annotations](#BKMK_msdyn_systemuserschedulersetting_Annotations)
- [msdyn_taggedrecord_Annotations](#BKMK_msdyn_taggedrecord_Annotations)
- [msdyn_taxcode_Annotations](#BKMK_msdyn_taxcode_Annotations)
- [msdyn_taxcodedetail_Annotations](#BKMK_msdyn_taxcodedetail_Annotations)
- [msdyn_timeentry_Annotations](#BKMK_msdyn_timeentry_Annotations)
- [msdyn_timegroup_Annotations](#BKMK_msdyn_timegroup_Annotations)
- [msdyn_timegroupdetail_Annotations](#BKMK_msdyn_timegroupdetail_Annotations)
- [msdyn_timeoffrequest_Annotations](#BKMK_msdyn_timeoffrequest_Annotations)
- [msdyn_transactionorigin_Annotations](#BKMK_msdyn_transactionorigin_Annotations)
- [msdyn_transcript_Annotations](#BKMK_msdyn_transcript_Annotations)
- [msdyn_warehouse_Annotations](#BKMK_msdyn_warehouse_Annotations)
- [msdyn_workorder_Annotations](#BKMK_msdyn_workorder_Annotations)
- [msdyn_workordercharacteristic_Annotations](#BKMK_msdyn_workordercharacteristic_Annotations)
- [msdyn_workorderincident_Annotations](#BKMK_msdyn_workorderincident_Annotations)
- [msdyn_workorderproduct_Annotations](#BKMK_msdyn_workorderproduct_Annotations)
- [msdyn_workorderresourcerestriction_Annotations](#BKMK_msdyn_workorderresourcerestriction_Annotations)
- [msdyn_workorderservice_Annotations](#BKMK_msdyn_workorderservice_Annotations)
- [msdyn_workorderservicetask_Annotations](#BKMK_msdyn_workorderservicetask_Annotations)
- [msdyn_workordersubstatus_Annotations](#BKMK_msdyn_workordersubstatus_Annotations)
- [msdyncrm_appointmentactivitymarketingtemplate_Annotations](#BKMK_msdyncrm_appointmentactivitymarketingtemplate_Annotations)
- [msdyncrm_contentsettings_Annotations](#BKMK_msdyncrm_contentsettings_Annotations)
- [msdyncrm_customerjourney_Annotations](#BKMK_msdyncrm_customerjourney_Annotations)
- [msdyncrm_leadscoremodel_Annotations](#BKMK_msdyncrm_leadscoremodel_Annotations)
- [msdyncrm_linkedinaccount_Annotations](#BKMK_msdyncrm_linkedinaccount_Annotations)
- [msdyncrm_linkedinactivity_Annotations](#BKMK_msdyncrm_linkedinactivity_Annotations)
- [msdyncrm_linkedinfieldmapping_Annotations](#BKMK_msdyncrm_linkedinfieldmapping_Annotations)
- [msdyncrm_linkedinform_Annotations](#BKMK_msdyncrm_linkedinform_Annotations)
- [msdyncrm_linkedinformanswer_Annotations](#BKMK_msdyncrm_linkedinformanswer_Annotations)
- [msdyncrm_linkedinformquestion_Annotations](#BKMK_msdyncrm_linkedinformquestion_Annotations)
- [msdyncrm_linkedinformsubmission_Annotations](#BKMK_msdyncrm_linkedinformsubmission_Annotations)
- [msdyncrm_linkedinleadmatchingstrategy_Annotations](#BKMK_msdyncrm_linkedinleadmatchingstrategy_Annotations)
- [msdyncrm_linkedinuserprofile_Annotations](#BKMK_msdyncrm_linkedinuserprofile_Annotations)
- [msdyncrm_marketingdynamiccontentmetadata_Annotations](#BKMK_msdyncrm_marketingdynamiccontentmetadata_Annotations)
- [msdyncrm_marketingemaildynamiccontentmetadata_Annotations](#BKMK_msdyncrm_marketingemaildynamiccontentmetadata_Annotations)
- [msdyncrm_marketingemailtestsend_Annotations](#BKMK_msdyncrm_marketingemailtestsend_Annotations)
- [msdyncrm_marketingform_Annotations](#BKMK_msdyncrm_marketingform_Annotations)
- [msdyncrm_marketingformtemplate_Annotations](#BKMK_msdyncrm_marketingformtemplate_Annotations)
- [msdyncrm_marketingpage_Annotations](#BKMK_msdyncrm_marketingpage_Annotations)
- [msdyncrm_marketingpagetemplate_Annotations](#BKMK_msdyncrm_marketingpagetemplate_Annotations)
- [msdyncrm_migration_Annotations](#BKMK_msdyncrm_migration_Annotations)
- [msdyncrm_mktactivity_Annotations](#BKMK_msdyncrm_mktactivity_Annotations)
- [msdyncrm_phonecallactivitymarketingtemplate_Annotations](#BKMK_msdyncrm_phonecallactivitymarketingtemplate_Annotations)
- [msdyncrm_taskactivitymarketingtemplate_Annotations](#BKMK_msdyncrm_taskactivitymarketingtemplate_Annotations)
- [msdyncrm_uicconfig_Annotations](#BKMK_msdyncrm_uicconfig_Annotations)
- [msevtmgt_checkin_Annotations](#BKMK_msevtmgt_checkin_Annotations)
- [msevtmgt_event_Annotations](#BKMK_msevtmgt_event_Annotations)
- [msevtmgt_eventpurchase_Annotations](#BKMK_msevtmgt_eventpurchase_Annotations)
- [msevtmgt_eventpurchaseattendee_Annotations](#BKMK_msevtmgt_eventpurchaseattendee_Annotations)
- [msevtmgt_eventpurchasepass_Annotations](#BKMK_msevtmgt_eventpurchasepass_Annotations)
- [msevtmgt_eventregistration_Annotations](#BKMK_msevtmgt_eventregistration_Annotations)
- [msevtmgt_hotel_Annotations](#BKMK_msevtmgt_hotel_Annotations)
- [msevtmgt_hotelroomallocation_Annotations](#BKMK_msevtmgt_hotelroomallocation_Annotations)
- [msevtmgt_hotelroomreservation_Annotations](#BKMK_msevtmgt_hotelroomreservation_Annotations)
- [msevtmgt_layout_Annotations](#BKMK_msevtmgt_layout_Annotations)
- [msevtmgt_room_Annotations](#BKMK_msevtmgt_room_Annotations)
- [msevtmgt_session_Annotations](#BKMK_msevtmgt_session_Annotations)
- [msevtmgt_sessionregistration_Annotations](#BKMK_msevtmgt_sessionregistration_Annotations)
- [msevtmgt_sessiontrack_Annotations](#BKMK_msevtmgt_sessiontrack_Annotations)
- [msevtmgt_speaker_Annotations](#BKMK_msevtmgt_speaker_Annotations)
- [msevtmgt_speakerengagement_Annotations](#BKMK_msevtmgt_speakerengagement_Annotations)
- [msevtmgt_sponsorablearticle_Annotations](#BKMK_msevtmgt_sponsorablearticle_Annotations)
- [msevtmgt_sponsorship_Annotations](#BKMK_msevtmgt_sponsorship_Annotations)
- [msevtmgt_venue_Annotations](#BKMK_msevtmgt_venue_Annotations)
- [msevtmgt_webinarconfiguration_Annotations](#BKMK_msevtmgt_webinarconfiguration_Annotations)
- [msevtmgt_webinarprovider_Annotations](#BKMK_msevtmgt_webinarprovider_Annotations)
- [msfp_alert_Annotations](#BKMK_msfp_alert_Annotations)
- [msfp_question_Annotations](#BKMK_msfp_question_Annotations)
- [msfp_surveyinvite_Annotations](#BKMK_msfp_surveyinvite_Annotations)
- [msfp_surveyresponse_Annotations](#BKMK_msfp_surveyresponse_Annotations)
- [msmrw_3dasset_Annotations](#BKMK_msmrw_3dasset_Annotations)
- [msmrw_audioasset_Annotations](#BKMK_msmrw_audioasset_Annotations)
- [msmrw_guide_Annotations](#BKMK_msmrw_guide_Annotations)
- [msmrw_imageasset_Annotations](#BKMK_msmrw_imageasset_Annotations)
- [msmrw_videoasset_Annotations](#BKMK_msmrw_videoasset_Annotations)
- [Opportunity_Annotation](#BKMK_Opportunity_Annotation)
- [OpportunityClose_Annotation](#BKMK_OpportunityClose_Annotation)
- [OrderClose_Annotation](#BKMK_OrderClose_Annotation)
- [Product_Annotation](#BKMK_Product_Annotation)
- [Quote_Annotation](#BKMK_Quote_Annotation)
- [QuoteClose_Annotation](#BKMK_QuoteClose_Annotation)
- [ResourceSpec_Annotation](#BKMK_ResourceSpec_Annotation)
- [SalesOrder_Annotation](#BKMK_SalesOrder_Annotation)
- [Service_Annotation](#BKMK_Service_Annotation)
- [ServiceAppointment_Annotation](#BKMK_ServiceAppointment_Annotation)

### <a name="BKMK_adx_ad_Annotations"></a> adx_ad_Annotations

One-To-Many Relationship: [adx_ad adx_ad_Annotations](adx_ad.md#BKMK_adx_ad_Annotations)

|Property|Value|
|---|---|
|ReferencedEntity|`adx_ad`|
|ReferencedAttribute|`adx_adid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_adx_ad`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_adx_adplacement_Annotations"></a> adx_adplacement_Annotations

One-To-Many Relationship: [adx_adplacement adx_adplacement_Annotations](adx_adplacement.md#BKMK_adx_adplacement_Annotations)

|Property|Value|
|---|---|
|ReferencedEntity|`adx_adplacement`|
|ReferencedAttribute|`adx_adplacementid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_adx_adplacement`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_adx_alertsubscription_Annotations"></a> adx_alertsubscription_Annotations

One-To-Many Relationship: [adx_alertsubscription adx_alertsubscription_Annotations](adx_alertsubscription.md#BKMK_adx_alertsubscription_Annotations)

|Property|Value|
|---|---|
|ReferencedEntity|`adx_alertsubscription`|
|ReferencedAttribute|`activityid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_adx_alertsubscription`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_adx_casedeflection_Annotations"></a> adx_casedeflection_Annotations

One-To-Many Relationship: [adx_casedeflection adx_casedeflection_Annotations](adx_casedeflection.md#BKMK_adx_casedeflection_Annotations)

|Property|Value|
|---|---|
|ReferencedEntity|`adx_casedeflection`|
|ReferencedAttribute|`adx_casedeflectionid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_adx_casedeflection`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_adx_communityforum_Annotations"></a> adx_communityforum_Annotations

One-To-Many Relationship: [adx_communityforum adx_communityforum_Annotations](adx_communityforum.md#BKMK_adx_communityforum_Annotations)

|Property|Value|
|---|---|
|ReferencedEntity|`adx_communityforum`|
|ReferencedAttribute|`adx_communityforumid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_adx_communityforum`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_adx_communityforumaccesspermission_Annotations"></a> adx_communityforumaccesspermission_Annotations

One-To-Many Relationship: [adx_communityforumaccesspermission adx_communityforumaccesspermission_Annotations](adx_communityforumaccesspermission.md#BKMK_adx_communityforumaccesspermission_Annotations)

|Property|Value|
|---|---|
|ReferencedEntity|`adx_communityforumaccesspermission`|
|ReferencedAttribute|`adx_communityforumaccesspermissionid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_adx_communityforumaccesspermission`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_adx_communityforumannouncement_Annotations"></a> adx_communityforumannouncement_Annotations

One-To-Many Relationship: [adx_communityforumannouncement adx_communityforumannouncement_Annotations](adx_communityforumannouncement.md#BKMK_adx_communityforumannouncement_Annotations)

|Property|Value|
|---|---|
|ReferencedEntity|`adx_communityforumannouncement`|
|ReferencedAttribute|`adx_communityforumannouncementid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_adx_communityforumannouncement`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_adx_communityforumpost_Annotations"></a> adx_communityforumpost_Annotations

One-To-Many Relationship: [adx_communityforumpost adx_communityforumpost_Annotations](adx_communityforumpost.md#BKMK_adx_communityforumpost_Annotations)

|Property|Value|
|---|---|
|ReferencedEntity|`adx_communityforumpost`|
|ReferencedAttribute|`adx_communityforumpostid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_adx_communityforumpost`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_adx_communityforumthread_Annotations"></a> adx_communityforumthread_Annotations

One-To-Many Relationship: [adx_communityforumthread adx_communityforumthread_Annotations](adx_communityforumthread.md#BKMK_adx_communityforumthread_Annotations)

|Property|Value|
|---|---|
|ReferencedEntity|`adx_communityforumthread`|
|ReferencedAttribute|`adx_communityforumthreadid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_adx_communityforumthread`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_adx_contentaccesslevel_Annotations"></a> adx_contentaccesslevel_Annotations

One-To-Many Relationship: [adx_contentaccesslevel adx_contentaccesslevel_Annotations](adx_contentaccesslevel.md#BKMK_adx_contentaccesslevel_Annotations)

|Property|Value|
|---|---|
|ReferencedEntity|`adx_contentaccesslevel`|
|ReferencedAttribute|`adx_contentaccesslevelid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_adx_contentaccesslevel`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_adx_entitypermission_Annotations"></a> adx_entitypermission_Annotations

One-To-Many Relationship: [adx_entitypermission adx_entitypermission_Annotations](adx_entitypermission.md#BKMK_adx_entitypermission_Annotations)

|Property|Value|
|---|---|
|ReferencedEntity|`adx_entitypermission`|
|ReferencedAttribute|`adx_entitypermissionid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_adx_entitypermission`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_adx_poll_Annotations"></a> adx_poll_Annotations

One-To-Many Relationship: [adx_poll adx_poll_Annotations](adx_poll.md#BKMK_adx_poll_Annotations)

|Property|Value|
|---|---|
|ReferencedEntity|`adx_poll`|
|ReferencedAttribute|`adx_pollid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_adx_poll`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_adx_polloption_Annotations"></a> adx_polloption_Annotations

One-To-Many Relationship: [adx_polloption adx_polloption_Annotations](adx_polloption.md#BKMK_adx_polloption_Annotations)

|Property|Value|
|---|---|
|ReferencedEntity|`adx_polloption`|
|ReferencedAttribute|`adx_polloptionid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_adx_polloption`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_adx_pollplacement_Annotations"></a> adx_pollplacement_Annotations

One-To-Many Relationship: [adx_pollplacement adx_pollplacement_Annotations](adx_pollplacement.md#BKMK_adx_pollplacement_Annotations)

|Property|Value|
|---|---|
|ReferencedEntity|`adx_pollplacement`|
|ReferencedAttribute|`adx_pollplacementid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_adx_pollplacement`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_adx_pollsubmission_Annotations"></a> adx_pollsubmission_Annotations

One-To-Many Relationship: [adx_pollsubmission adx_pollsubmission_Annotations](adx_pollsubmission.md#BKMK_adx_pollsubmission_Annotations)

|Property|Value|
|---|---|
|ReferencedEntity|`adx_pollsubmission`|
|ReferencedAttribute|`adx_pollsubmissionid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_adx_pollsubmission`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_adx_publishingstatetransitionrule_Annotations"></a> adx_publishingstatetransitionrule_Annotations

One-To-Many Relationship: [adx_publishingstatetransitionrule adx_publishingstatetransitionrule_Annotations](adx_publishingstatetransitionrule.md#BKMK_adx_publishingstatetransitionrule_Annotations)

|Property|Value|
|---|---|
|ReferencedEntity|`adx_publishingstatetransitionrule`|
|ReferencedAttribute|`adx_publishingstatetransitionruleid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_adx_publishingstatetransitionrule`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_adx_redirect_Annotations"></a> adx_redirect_Annotations

One-To-Many Relationship: [adx_redirect adx_redirect_Annotations](adx_redirect.md#BKMK_adx_redirect_Annotations)

|Property|Value|
|---|---|
|ReferencedEntity|`adx_redirect`|
|ReferencedAttribute|`adx_redirectid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_adx_redirect`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_adx_shortcut_Annotations"></a> adx_shortcut_Annotations

One-To-Many Relationship: [adx_shortcut adx_shortcut_Annotations](adx_shortcut.md#BKMK_adx_shortcut_Annotations)

|Property|Value|
|---|---|
|ReferencedEntity|`adx_shortcut`|
|ReferencedAttribute|`adx_shortcutid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_adx_shortcut`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_adx_sitesetting_Annotations"></a> adx_sitesetting_Annotations

One-To-Many Relationship: [adx_sitesetting adx_sitesetting_Annotations](adx_sitesetting.md#BKMK_adx_sitesetting_Annotations)

|Property|Value|
|---|---|
|ReferencedEntity|`adx_sitesetting`|
|ReferencedAttribute|`adx_sitesettingid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_adx_sitesetting`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_adx_webfile_Annotations"></a> adx_webfile_Annotations

One-To-Many Relationship: [adx_webfile adx_webfile_Annotations](adx_webfile.md#BKMK_adx_webfile_Annotations)

|Property|Value|
|---|---|
|ReferencedEntity|`adx_webfile`|
|ReferencedAttribute|`adx_webfileid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_adx_webfile`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_adx_weblink_Annotations"></a> adx_weblink_Annotations

One-To-Many Relationship: [adx_weblink adx_weblink_Annotations](adx_weblink.md#BKMK_adx_weblink_Annotations)

|Property|Value|
|---|---|
|ReferencedEntity|`adx_weblink`|
|ReferencedAttribute|`adx_weblinkid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_adx_weblink`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_adx_webnotificationurl_Annotations"></a> adx_webnotificationurl_Annotations

One-To-Many Relationship: [adx_webnotificationurl adx_webnotificationurl_Annotations](adx_webnotificationurl.md#BKMK_adx_webnotificationurl_Annotations)

|Property|Value|
|---|---|
|ReferencedEntity|`adx_webnotificationurl`|
|ReferencedAttribute|`adx_webnotificationurlid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_adx_webnotificationurl`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_adx_webpage_Annotations"></a> adx_webpage_Annotations

One-To-Many Relationship: [adx_webpage adx_webpage_Annotations](adx_webpage.md#BKMK_adx_webpage_Annotations)

|Property|Value|
|---|---|
|ReferencedEntity|`adx_webpage`|
|ReferencedAttribute|`adx_webpageid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_adx_webpage`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_adx_webrole_Annotations"></a> adx_webrole_Annotations

One-To-Many Relationship: [adx_webrole adx_webrole_Annotations](adx_webrole.md#BKMK_adx_webrole_Annotations)

|Property|Value|
|---|---|
|ReferencedEntity|`adx_webrole`|
|ReferencedAttribute|`adx_webroleid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_adx_webrole`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_adx_website_Annotations"></a> adx_website_Annotations

One-To-Many Relationship: [adx_website adx_website_Annotations](adx_website.md#BKMK_adx_website_Annotations)

|Property|Value|
|---|---|
|ReferencedEntity|`adx_website`|
|ReferencedAttribute|`adx_websiteid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_adx_website`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_adx_websitebinding_Annotations"></a> adx_websitebinding_Annotations

One-To-Many Relationship: [adx_websitebinding adx_websitebinding_Annotations](adx_websitebinding.md#BKMK_adx_websitebinding_Annotations)

|Property|Value|
|---|---|
|ReferencedEntity|`adx_websitebinding`|
|ReferencedAttribute|`adx_websitebindingid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_adx_websitebinding`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_bookableresource_Annotations"></a> bookableresource_Annotations

One-To-Many Relationship: [bookableresource bookableresource_Annotations](bookableresource.md#BKMK_bookableresource_Annotations)

|Property|Value|
|---|---|
|ReferencedEntity|`bookableresource`|
|ReferencedAttribute|`bookableresourceid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_bookableresource`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_bookableresourcebooking_Annotations"></a> bookableresourcebooking_Annotations

One-To-Many Relationship: [bookableresourcebooking bookableresourcebooking_Annotations](bookableresourcebooking.md#BKMK_bookableresourcebooking_Annotations)

|Property|Value|
|---|---|
|ReferencedEntity|`bookableresourcebooking`|
|ReferencedAttribute|`bookableresourcebookingid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_bookableresourcebooking`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_bookableresourcebookingheader_Annotations"></a> bookableresourcebookingheader_Annotations

One-To-Many Relationship: [bookableresourcebookingheader bookableresourcebookingheader_Annotations](bookableresourcebookingheader.md#BKMK_bookableresourcebookingheader_Annotations)

|Property|Value|
|---|---|
|ReferencedEntity|`bookableresourcebookingheader`|
|ReferencedAttribute|`bookableresourcebookingheaderid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_bookableresourcebookingheader`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_bookableresourcecategoryassn_Annotations"></a> bookableresourcecategoryassn_Annotations

One-To-Many Relationship: [bookableresourcecategoryassn bookableresourcecategoryassn_Annotations](bookableresourcecategoryassn.md#BKMK_bookableresourcecategoryassn_Annotations)

|Property|Value|
|---|---|
|ReferencedEntity|`bookableresourcecategoryassn`|
|ReferencedAttribute|`bookableresourcecategoryassnid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_bookableresourcecategoryassn`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_bookableresourcecharacteristic_Annotations"></a> bookableresourcecharacteristic_Annotations

One-To-Many Relationship: [bookableresourcecharacteristic bookableresourcecharacteristic_Annotations](bookableresourcecharacteristic.md#BKMK_bookableresourcecharacteristic_Annotations)

|Property|Value|
|---|---|
|ReferencedEntity|`bookableresourcecharacteristic`|
|ReferencedAttribute|`bookableresourcecharacteristicid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_bookableresourcecharacteristic`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_bookableresourcegroup_Annotations"></a> bookableresourcegroup_Annotations

One-To-Many Relationship: [bookableresourcegroup bookableresourcegroup_Annotations](bookableresourcegroup.md#BKMK_bookableresourcegroup_Annotations)

|Property|Value|
|---|---|
|ReferencedEntity|`bookableresourcegroup`|
|ReferencedAttribute|`bookableresourcegroupid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_bookableresourcegroup`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_bulkoperation_Annotations"></a> bulkoperation_Annotations

One-To-Many Relationship: [bulkoperation bulkoperation_Annotations](bulkoperation.md#BKMK_bulkoperation_Annotations)

|Property|Value|
|---|---|
|ReferencedEntity|`bulkoperation`|
|ReferencedAttribute|`activityid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_bulkoperation`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_Campaign_Annotation"></a> Campaign_Annotation

One-To-Many Relationship: [campaign Campaign_Annotation](campaign.md#BKMK_Campaign_Annotation)

|Property|Value|
|---|---|
|ReferencedEntity|`campaign`|
|ReferencedAttribute|`campaignid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_campaign`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_CampaignActivity_Annotation"></a> CampaignActivity_Annotation

One-To-Many Relationship: [campaignactivity CampaignActivity_Annotation](campaignactivity.md#BKMK_CampaignActivity_Annotation)

|Property|Value|
|---|---|
|ReferencedEntity|`campaignactivity`|
|ReferencedAttribute|`activityid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_campaignactivity`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_CampaignResponse_Annotation"></a> CampaignResponse_Annotation

One-To-Many Relationship: [campaignresponse CampaignResponse_Annotation](campaignresponse.md#BKMK_CampaignResponse_Annotation)

|Property|Value|
|---|---|
|ReferencedEntity|`campaignresponse`|
|ReferencedAttribute|`activityid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_campaignresponse`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_Competitor_Annotation"></a> Competitor_Annotation

One-To-Many Relationship: [competitor Competitor_Annotation](competitor.md#BKMK_Competitor_Annotation)

|Property|Value|
|---|---|
|ReferencedEntity|`competitor`|
|ReferencedAttribute|`competitorid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_competitor`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_Contract_Annotation"></a> Contract_Annotation

One-To-Many Relationship: [contract Contract_Annotation](contract.md#BKMK_Contract_Annotation)

|Property|Value|
|---|---|
|ReferencedEntity|`contract`|
|ReferencedAttribute|`contractid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_contract`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_ContractDetail_Annotation"></a> ContractDetail_Annotation

One-To-Many Relationship: [contractdetail ContractDetail_Annotation](contractdetail.md#BKMK_ContractDetail_Annotation)

|Property|Value|
|---|---|
|ReferencedEntity|`contractdetail`|
|ReferencedAttribute|`contractdetailid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_contractdetail`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_entitlement_Annotations"></a> entitlement_Annotations

One-To-Many Relationship: [entitlement entitlement_Annotations](entitlement.md#BKMK_entitlement_Annotations)

|Property|Value|
|---|---|
|ReferencedEntity|`entitlement`|
|ReferencedAttribute|`entitlementid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_entitlement`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_entitlementchannel_Annotations"></a> entitlementchannel_Annotations

One-To-Many Relationship: [entitlementchannel entitlementchannel_Annotations](entitlementchannel.md#BKMK_entitlementchannel_Annotations)

|Property|Value|
|---|---|
|ReferencedEntity|`entitlementchannel`|
|ReferencedAttribute|`entitlementchannelid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_entitlementchannel`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_entitlementtemplate_Annotations"></a> entitlementtemplate_Annotations

One-To-Many Relationship: [entitlementtemplate entitlementtemplate_Annotations](entitlementtemplate.md#BKMK_entitlementtemplate_Annotations)

|Property|Value|
|---|---|
|ReferencedEntity|`entitlementtemplate`|
|ReferencedAttribute|`entitlementtemplateid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_entitlementtemplate`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_Equipment_Annotation"></a> Equipment_Annotation

One-To-Many Relationship: [equipment Equipment_Annotation](equipment.md#BKMK_Equipment_Annotation)

|Property|Value|
|---|---|
|ReferencedEntity|`equipment`|
|ReferencedAttribute|`equipmentid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_equipment`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_Incident_Annotation"></a> Incident_Annotation

One-To-Many Relationship: [incident Incident_Annotation](incident.md#BKMK_Incident_Annotation)

|Property|Value|
|---|---|
|ReferencedEntity|`incident`|
|ReferencedAttribute|`incidentid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_incident`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `Cascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_IncidentResolution_Annotation"></a> IncidentResolution_Annotation

One-To-Many Relationship: [incidentresolution IncidentResolution_Annotation](incidentresolution.md#BKMK_IncidentResolution_Annotation)

|Property|Value|
|---|---|
|ReferencedEntity|`incidentresolution`|
|ReferencedAttribute|`activityid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_incidentresolution`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_Invoice_Annotation"></a> Invoice_Annotation

One-To-Many Relationship: [invoice Invoice_Annotation](invoice.md#BKMK_Invoice_Annotation)

|Property|Value|
|---|---|
|ReferencedEntity|`invoice`|
|ReferencedAttribute|`invoiceid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_invoice`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_Lead_Annotation"></a> Lead_Annotation

One-To-Many Relationship: [lead Lead_Annotation](lead.md#BKMK_Lead_Annotation)

|Property|Value|
|---|---|
|ReferencedEntity|`lead`|
|ReferencedAttribute|`leadid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_lead`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `Cascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_li_inmail_Annotations"></a> li_inmail_Annotations

One-To-Many Relationship: [li_inmail li_inmail_Annotations](li_inmail.md#BKMK_li_inmail_Annotations)

|Property|Value|
|---|---|
|ReferencedEntity|`li_inmail`|
|ReferencedAttribute|`activityid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_li_inmail`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_li_message_Annotations"></a> li_message_Annotations

One-To-Many Relationship: [li_message li_message_Annotations](li_message.md#BKMK_li_message_Annotations)

|Property|Value|
|---|---|
|ReferencedEntity|`li_message`|
|ReferencedAttribute|`activityid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_li_message`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_li_pointdrivepresentationviewed_Annotations"></a> li_pointdrivepresentationviewed_Annotations

One-To-Many Relationship: [li_pointdrivepresentationviewed li_pointdrivepresentationviewed_Annotations](li_pointdrivepresentationviewed.md#BKMK_li_pointdrivepresentationviewed_Annotations)

|Property|Value|
|---|---|
|ReferencedEntity|`li_pointdrivepresentationviewed`|
|ReferencedAttribute|`activityid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_li_pointdrivepresentationviewed`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_List_Annotation"></a> List_Annotation

One-To-Many Relationship: [list List_Annotation](list.md#BKMK_List_Annotation)

|Property|Value|
|---|---|
|ReferencedEntity|`list`|
|ReferencedAttribute|`listid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_list`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_3dmodel_Annotations"></a> msdyn_3dmodel_Annotations

One-To-Many Relationship: [msdyn_3dmodel msdyn_3dmodel_Annotations](msdyn_3dmodel.md#BKMK_msdyn_3dmodel_Annotations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_3dmodel`|
|ReferencedAttribute|`msdyn_3dmodelid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_3dmodel`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_actual_Annotations"></a> msdyn_actual_Annotations

One-To-Many Relationship: [msdyn_actual msdyn_actual_Annotations](msdyn_actual.md#BKMK_msdyn_actual_Annotations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_actual`|
|ReferencedAttribute|`msdyn_actualid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_actual`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_agreement_Annotations"></a> msdyn_agreement_Annotations

One-To-Many Relationship: [msdyn_agreement msdyn_agreement_Annotations](msdyn_agreement.md#BKMK_msdyn_agreement_Annotations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_agreement`|
|ReferencedAttribute|`msdyn_agreementid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_agreement`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_agreementbookingdate_Annotations"></a> msdyn_agreementbookingdate_Annotations

One-To-Many Relationship: [msdyn_agreementbookingdate msdyn_agreementbookingdate_Annotations](msdyn_agreementbookingdate.md#BKMK_msdyn_agreementbookingdate_Annotations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_agreementbookingdate`|
|ReferencedAttribute|`msdyn_agreementbookingdateid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_agreementbookingdate`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_agreementbookingincident_Annotations"></a> msdyn_agreementbookingincident_Annotations

One-To-Many Relationship: [msdyn_agreementbookingincident msdyn_agreementbookingincident_Annotations](msdyn_agreementbookingincident.md#BKMK_msdyn_agreementbookingincident_Annotations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_agreementbookingincident`|
|ReferencedAttribute|`msdyn_agreementbookingincidentid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_agreementbookingincident`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_agreementbookingproduct_Annotations"></a> msdyn_agreementbookingproduct_Annotations

One-To-Many Relationship: [msdyn_agreementbookingproduct msdyn_agreementbookingproduct_Annotations](msdyn_agreementbookingproduct.md#BKMK_msdyn_agreementbookingproduct_Annotations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_agreementbookingproduct`|
|ReferencedAttribute|`msdyn_agreementbookingproductid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_agreementbookingproduct`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_agreementbookingservice_Annotations"></a> msdyn_agreementbookingservice_Annotations

One-To-Many Relationship: [msdyn_agreementbookingservice msdyn_agreementbookingservice_Annotations](msdyn_agreementbookingservice.md#BKMK_msdyn_agreementbookingservice_Annotations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_agreementbookingservice`|
|ReferencedAttribute|`msdyn_agreementbookingserviceid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_agreementbookingservice`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_agreementbookingservicetask_Annotations"></a> msdyn_agreementbookingservicetask_Annotations

One-To-Many Relationship: [msdyn_agreementbookingservicetask msdyn_agreementbookingservicetask_Annotations](msdyn_agreementbookingservicetask.md#BKMK_msdyn_agreementbookingservicetask_Annotations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_agreementbookingservicetask`|
|ReferencedAttribute|`msdyn_agreementbookingservicetaskid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_agreementbookingservicetask`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_agreementbookingsetup_Annotations"></a> msdyn_agreementbookingsetup_Annotations

One-To-Many Relationship: [msdyn_agreementbookingsetup msdyn_agreementbookingsetup_Annotations](msdyn_agreementbookingsetup.md#BKMK_msdyn_agreementbookingsetup_Annotations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_agreementbookingsetup`|
|ReferencedAttribute|`msdyn_agreementbookingsetupid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_agreementbookingsetup`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_agreementinvoicedate_Annotations"></a> msdyn_agreementinvoicedate_Annotations

One-To-Many Relationship: [msdyn_agreementinvoicedate msdyn_agreementinvoicedate_Annotations](msdyn_agreementinvoicedate.md#BKMK_msdyn_agreementinvoicedate_Annotations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_agreementinvoicedate`|
|ReferencedAttribute|`msdyn_agreementinvoicedateid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_agreementinvoicedate`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_agreementinvoiceproduct_Annotations"></a> msdyn_agreementinvoiceproduct_Annotations

One-To-Many Relationship: [msdyn_agreementinvoiceproduct msdyn_agreementinvoiceproduct_Annotations](msdyn_agreementinvoiceproduct.md#BKMK_msdyn_agreementinvoiceproduct_Annotations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_agreementinvoiceproduct`|
|ReferencedAttribute|`msdyn_agreementinvoiceproductid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_agreementinvoiceproduct`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_agreementinvoicesetup_Annotations"></a> msdyn_agreementinvoicesetup_Annotations

One-To-Many Relationship: [msdyn_agreementinvoicesetup msdyn_agreementinvoicesetup_Annotations](msdyn_agreementinvoicesetup.md#BKMK_msdyn_agreementinvoicesetup_Annotations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_agreementinvoicesetup`|
|ReferencedAttribute|`msdyn_agreementinvoicesetupid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_agreementinvoicesetup`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_agreementsubstatus_Annotations"></a> msdyn_agreementsubstatus_Annotations

One-To-Many Relationship: [msdyn_agreementsubstatus msdyn_agreementsubstatus_Annotations](msdyn_agreementsubstatus.md#BKMK_msdyn_agreementsubstatus_Annotations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_agreementsubstatus`|
|ReferencedAttribute|`msdyn_agreementsubstatusid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_agreementsubstatus`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_bookingalert_Annotations"></a> msdyn_bookingalert_Annotations

One-To-Many Relationship: [msdyn_bookingalert msdyn_bookingalert_Annotations](msdyn_bookingalert.md#BKMK_msdyn_bookingalert_Annotations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_bookingalert`|
|ReferencedAttribute|`activityid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_bookingalert`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_bookingalertstatus_Annotations"></a> msdyn_bookingalertstatus_Annotations

One-To-Many Relationship: [msdyn_bookingalertstatus msdyn_bookingalertstatus_Annotations](msdyn_bookingalertstatus.md#BKMK_msdyn_bookingalertstatus_Annotations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_bookingalertstatus`|
|ReferencedAttribute|`msdyn_bookingalertstatusid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_bookingalertstatus`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_bookingjournal_Annotations"></a> msdyn_bookingjournal_Annotations

One-To-Many Relationship: [msdyn_bookingjournal msdyn_bookingjournal_Annotations](msdyn_bookingjournal.md#BKMK_msdyn_bookingjournal_Annotations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_bookingjournal`|
|ReferencedAttribute|`msdyn_bookingjournalid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_bookingjournal`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_bookingrule_Annotations"></a> msdyn_bookingrule_Annotations

One-To-Many Relationship: [msdyn_bookingrule msdyn_bookingrule_Annotations](msdyn_bookingrule.md#BKMK_msdyn_bookingrule_Annotations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_bookingrule`|
|ReferencedAttribute|`msdyn_bookingruleid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_bookingrule`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_bookingtimestamp_Annotations"></a> msdyn_bookingtimestamp_Annotations

One-To-Many Relationship: [msdyn_bookingtimestamp msdyn_bookingtimestamp_Annotations](msdyn_bookingtimestamp.md#BKMK_msdyn_bookingtimestamp_Annotations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_bookingtimestamp`|
|ReferencedAttribute|`msdyn_bookingtimestampid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_bookingtimestamp`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_copilottranscript_Annotations"></a> msdyn_copilottranscript_Annotations

One-To-Many Relationship: [msdyn_copilottranscript msdyn_copilottranscript_Annotations](msdyn_copilottranscript.md#BKMK_msdyn_copilottranscript_Annotations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_copilottranscript`|
|ReferencedAttribute|`activityid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_copilottranscript`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_customerasset_Annotations"></a> msdyn_customerasset_Annotations

One-To-Many Relationship: [msdyn_customerasset msdyn_customerasset_Annotations](msdyn_customerasset.md#BKMK_msdyn_customerasset_Annotations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_customerasset`|
|ReferencedAttribute|`msdyn_customerassetid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_customerasset`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_fieldservicesetting_Annotations"></a> msdyn_fieldservicesetting_Annotations

One-To-Many Relationship: [msdyn_fieldservicesetting msdyn_fieldservicesetting_Annotations](msdyn_fieldservicesetting.md#BKMK_msdyn_fieldservicesetting_Annotations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_fieldservicesetting`|
|ReferencedAttribute|`msdyn_fieldservicesettingid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_fieldservicesetting`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_forecastconfiguration_Annotations"></a> msdyn_forecastconfiguration_Annotations

One-To-Many Relationship: [msdyn_forecastconfiguration msdyn_forecastconfiguration_Annotations](msdyn_forecastconfiguration.md#BKMK_msdyn_forecastconfiguration_Annotations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_forecastconfiguration`|
|ReferencedAttribute|`msdyn_forecastconfigurationid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_forecastconfiguration`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_forecastpredictionstatus_Annotations"></a> msdyn_forecastpredictionstatus_Annotations

One-To-Many Relationship: [msdyn_forecastpredictionstatus msdyn_forecastpredictionstatus_Annotations](msdyn_forecastpredictionstatus.md#BKMK_msdyn_forecastpredictionstatus_Annotations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_forecastpredictionstatus`|
|ReferencedAttribute|`msdyn_forecastpredictionstatusid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_forecastpredictionstatus`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_functionallocation_Annotations"></a> msdyn_functionallocation_Annotations

One-To-Many Relationship: [msdyn_functionallocation msdyn_functionallocation_Annotations](msdyn_functionallocation.md#BKMK_msdyn_functionallocation_Annotations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_functionallocation`|
|ReferencedAttribute|`msdyn_functionallocationid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_functionallocation`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_incidenttype_Annotations"></a> msdyn_incidenttype_Annotations

One-To-Many Relationship: [msdyn_incidenttype msdyn_incidenttype_Annotations](msdyn_incidenttype.md#BKMK_msdyn_incidenttype_Annotations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_incidenttype`|
|ReferencedAttribute|`msdyn_incidenttypeid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_incidenttype`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_incidenttypecharacteristic_Annotations"></a> msdyn_incidenttypecharacteristic_Annotations

One-To-Many Relationship: [msdyn_incidenttypecharacteristic msdyn_incidenttypecharacteristic_Annotations](msdyn_incidenttypecharacteristic.md#BKMK_msdyn_incidenttypecharacteristic_Annotations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_incidenttypecharacteristic`|
|ReferencedAttribute|`msdyn_incidenttypecharacteristicid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_incidenttypecharacteristic`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_incidenttypeproduct_Annotations"></a> msdyn_incidenttypeproduct_Annotations

One-To-Many Relationship: [msdyn_incidenttypeproduct msdyn_incidenttypeproduct_Annotations](msdyn_incidenttypeproduct.md#BKMK_msdyn_incidenttypeproduct_Annotations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_incidenttypeproduct`|
|ReferencedAttribute|`msdyn_incidenttypeproductid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_incidenttypeproduct`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_incidenttypeservice_Annotations"></a> msdyn_incidenttypeservice_Annotations

One-To-Many Relationship: [msdyn_incidenttypeservice msdyn_incidenttypeservice_Annotations](msdyn_incidenttypeservice.md#BKMK_msdyn_incidenttypeservice_Annotations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_incidenttypeservice`|
|ReferencedAttribute|`msdyn_incidenttypeserviceid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_incidenttypeservice`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_incidenttypessetup_Annotations"></a> msdyn_incidenttypessetup_Annotations

One-To-Many Relationship: [msdyn_incidenttypessetup msdyn_incidenttypessetup_Annotations](msdyn_incidenttypessetup.md#BKMK_msdyn_incidenttypessetup_Annotations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_incidenttypessetup`|
|ReferencedAttribute|`msdyn_incidenttypessetupid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_incidenttypessetup`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_inspectionattachment_Annotations"></a> msdyn_inspectionattachment_Annotations

One-To-Many Relationship: [msdyn_inspectionattachment msdyn_inspectionattachment_Annotations](msdyn_inspectionattachment.md#BKMK_msdyn_inspectionattachment_Annotations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_inspectionattachment`|
|ReferencedAttribute|`msdyn_inspectionattachmentid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_inspectionattachment`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_insurance_Annotations"></a> msdyn_insurance_Annotations

One-To-Many Relationship: [msdyn_insurance msdyn_insurance_Annotations](msdyn_insurance.md#BKMK_msdyn_insurance_Annotations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_insurance`|
|ReferencedAttribute|`msdyn_insuranceid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_insurance`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_inventoryadjustment_Annotations"></a> msdyn_inventoryadjustment_Annotations

One-To-Many Relationship: [msdyn_inventoryadjustment msdyn_inventoryadjustment_Annotations](msdyn_inventoryadjustment.md#BKMK_msdyn_inventoryadjustment_Annotations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_inventoryadjustment`|
|ReferencedAttribute|`msdyn_inventoryadjustmentid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_inventoryadjustment`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_inventoryadjustmentproduct_Annotations"></a> msdyn_inventoryadjustmentproduct_Annotations

One-To-Many Relationship: [msdyn_inventoryadjustmentproduct msdyn_inventoryadjustmentproduct_Annotations](msdyn_inventoryadjustmentproduct.md#BKMK_msdyn_inventoryadjustmentproduct_Annotations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_inventoryadjustmentproduct`|
|ReferencedAttribute|`msdyn_inventoryadjustmentproductid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_inventoryadjustmentproduct`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_inventoryjournal_Annotations"></a> msdyn_inventoryjournal_Annotations

One-To-Many Relationship: [msdyn_inventoryjournal msdyn_inventoryjournal_Annotations](msdyn_inventoryjournal.md#BKMK_msdyn_inventoryjournal_Annotations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_inventoryjournal`|
|ReferencedAttribute|`msdyn_inventoryjournalid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_inventoryjournal`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_inventorytransfer_Annotations"></a> msdyn_inventorytransfer_Annotations

One-To-Many Relationship: [msdyn_inventorytransfer msdyn_inventorytransfer_Annotations](msdyn_inventorytransfer.md#BKMK_msdyn_inventorytransfer_Annotations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_inventorytransfer`|
|ReferencedAttribute|`msdyn_inventorytransferid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_inventorytransfer`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_iotalert_Annotations"></a> msdyn_iotalert_Annotations

One-To-Many Relationship: [msdyn_iotalert msdyn_iotalert_Annotations](msdyn_iotalert.md#BKMK_msdyn_iotalert_Annotations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_iotalert`|
|ReferencedAttribute|`msdyn_iotalertid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_iotalert`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_iotdevice_Annotations"></a> msdyn_iotdevice_Annotations

One-To-Many Relationship: [msdyn_iotdevice msdyn_iotdevice_Annotations](msdyn_iotdevice.md#BKMK_msdyn_iotdevice_Annotations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_iotdevice`|
|ReferencedAttribute|`msdyn_iotdeviceid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_iotdevice`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_iotdevicecategory_Annotations"></a> msdyn_iotdevicecategory_Annotations

One-To-Many Relationship: [msdyn_iotdevicecategory msdyn_iotdevicecategory_Annotations](msdyn_iotdevicecategory.md#BKMK_msdyn_iotdevicecategory_Annotations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_iotdevicecategory`|
|ReferencedAttribute|`msdyn_iotdevicecategoryid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_iotdevicecategory`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_iotdevicecommand_Annotations"></a> msdyn_iotdevicecommand_Annotations

One-To-Many Relationship: [msdyn_iotdevicecommand msdyn_iotdevicecommand_Annotations](msdyn_iotdevicecommand.md#BKMK_msdyn_iotdevicecommand_Annotations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_iotdevicecommand`|
|ReferencedAttribute|`msdyn_iotdevicecommandid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_iotdevicecommand`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_iotdeviceregistrationhistory_Annotations"></a> msdyn_iotdeviceregistrationhistory_Annotations

One-To-Many Relationship: [msdyn_iotdeviceregistrationhistory msdyn_iotdeviceregistrationhistory_Annotations](msdyn_iotdeviceregistrationhistory.md#BKMK_msdyn_iotdeviceregistrationhistory_Annotations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_iotdeviceregistrationhistory`|
|ReferencedAttribute|`msdyn_iotdeviceregistrationhistoryid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_iotdeviceregistrationhistory`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_liveconversation_Annotations"></a> msdyn_liveconversation_Annotations

One-To-Many Relationship: [msdyn_liveconversation msdyn_liveconversation_Annotations](msdyn_liveconversation.md#BKMK_msdyn_liveconversation_Annotations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_liveconversation`|
|ReferencedAttribute|`msdyn_liveconversationid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_liveconversation`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_objectanchor_Annotations"></a> msdyn_objectanchor_Annotations

One-To-Many Relationship: [msdyn_objectanchor msdyn_objectanchor_Annotations](msdyn_objectanchor.md#BKMK_msdyn_objectanchor_Annotations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_objectanchor`|
|ReferencedAttribute|`msdyn_objectanchorid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_objectanchor`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_ocflaggedspam_Annotations"></a> msdyn_ocflaggedspam_Annotations

One-To-Many Relationship: [msdyn_ocflaggedspam msdyn_ocflaggedspam_Annotations](msdyn_ocflaggedspam.md#BKMK_msdyn_ocflaggedspam_Annotations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_ocflaggedspam`|
|ReferencedAttribute|`msdyn_ocflaggedspamid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_ocflaggedspam`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_ocliveworkitem_Annotations"></a> msdyn_ocliveworkitem_Annotations

One-To-Many Relationship: [msdyn_ocliveworkitem msdyn_ocliveworkitem_Annotations](msdyn_ocliveworkitem.md#BKMK_msdyn_ocliveworkitem_Annotations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_ocliveworkitem`|
|ReferencedAttribute|`activityid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_ocliveworkitem`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_ocoutboundmessage_Annotations"></a> msdyn_ocoutboundmessage_Annotations

One-To-Many Relationship: [msdyn_ocoutboundmessage msdyn_ocoutboundmessage_Annotations](msdyn_ocoutboundmessage.md#BKMK_msdyn_ocoutboundmessage_Annotations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_ocoutboundmessage`|
|ReferencedAttribute|`activityid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_ocoutboundmessage`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_ocsession_Annotations"></a> msdyn_ocsession_Annotations

One-To-Many Relationship: [msdyn_ocsession msdyn_ocsession_Annotations](msdyn_ocsession.md#BKMK_msdyn_ocsession_Annotations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_ocsession`|
|ReferencedAttribute|`activityid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_ocsession`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_ocvoicemail_Annotations"></a> msdyn_ocvoicemail_Annotations

One-To-Many Relationship: [msdyn_ocvoicemail msdyn_ocvoicemail_Annotations](msdyn_ocvoicemail.md#BKMK_msdyn_ocvoicemail_Annotations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_ocvoicemail`|
|ReferencedAttribute|`activityid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_ocvoicemail`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_organizationalunit_Annotations"></a> msdyn_organizationalunit_Annotations

One-To-Many Relationship: [msdyn_organizationalunit msdyn_organizationalunit_Annotations](msdyn_organizationalunit.md#BKMK_msdyn_organizationalunit_Annotations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_organizationalunit`|
|ReferencedAttribute|`msdyn_organizationalunitid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_organizationalunit`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_overflowactionconfig_Annotations"></a> msdyn_overflowactionconfig_Annotations

One-To-Many Relationship: [msdyn_overflowactionconfig msdyn_overflowactionconfig_Annotations](msdyn_overflowactionconfig.md#BKMK_msdyn_overflowactionconfig_Annotations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_overflowactionconfig`|
|ReferencedAttribute|`msdyn_overflowactionconfigid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_overflowactionconfig`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_payment_Annotations"></a> msdyn_payment_Annotations

One-To-Many Relationship: [msdyn_payment msdyn_payment_Annotations](msdyn_payment.md#BKMK_msdyn_payment_Annotations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_payment`|
|ReferencedAttribute|`msdyn_paymentid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_payment`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_paymentdetail_Annotations"></a> msdyn_paymentdetail_Annotations

One-To-Many Relationship: [msdyn_paymentdetail msdyn_paymentdetail_Annotations](msdyn_paymentdetail.md#BKMK_msdyn_paymentdetail_Annotations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_paymentdetail`|
|ReferencedAttribute|`msdyn_paymentdetailid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_paymentdetail`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_paymentmethod_Annotations"></a> msdyn_paymentmethod_Annotations

One-To-Many Relationship: [msdyn_paymentmethod msdyn_paymentmethod_Annotations](msdyn_paymentmethod.md#BKMK_msdyn_paymentmethod_Annotations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_paymentmethod`|
|ReferencedAttribute|`msdyn_paymentmethodid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_paymentmethod`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_paymentterm_Annotations"></a> msdyn_paymentterm_Annotations

One-To-Many Relationship: [msdyn_paymentterm msdyn_paymentterm_Annotations](msdyn_paymentterm.md#BKMK_msdyn_paymentterm_Annotations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_paymentterm`|
|ReferencedAttribute|`msdyn_paymenttermid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_paymentterm`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_personalsoundsetting_Annotations"></a> msdyn_personalsoundsetting_Annotations

One-To-Many Relationship: [msdyn_personalsoundsetting msdyn_personalsoundsetting_Annotations](msdyn_personalsoundsetting.md#BKMK_msdyn_personalsoundsetting_Annotations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_personalsoundsetting`|
|ReferencedAttribute|`msdyn_personalsoundsettingid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_personalsoundsetting`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_playbookinstance_Annotations"></a> msdyn_playbookinstance_Annotations

One-To-Many Relationship: [msdyn_playbookinstance msdyn_playbookinstance_Annotations](msdyn_playbookinstance.md#BKMK_msdyn_playbookinstance_Annotations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_playbookinstance`|
|ReferencedAttribute|`msdyn_playbookinstanceid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_playbookinstance`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_playbooktemplate_Annotations"></a> msdyn_playbooktemplate_Annotations

One-To-Many Relationship: [msdyn_playbooktemplate msdyn_playbooktemplate_Annotations](msdyn_playbooktemplate.md#BKMK_msdyn_playbooktemplate_Annotations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_playbooktemplate`|
|ReferencedAttribute|`msdyn_playbooktemplateid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_playbooktemplate`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_postalbum_Annotations"></a> msdyn_postalbum_Annotations

One-To-Many Relationship: [msdyn_postalbum msdyn_postalbum_Annotations](msdyn_postalbum.md#BKMK_msdyn_postalbum_Annotations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_postalbum`|
|ReferencedAttribute|`msdyn_postalbumid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_postalbum`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_postalcode_Annotations"></a> msdyn_postalcode_Annotations

One-To-Many Relationship: [msdyn_postalcode msdyn_postalcode_Annotations](msdyn_postalcode.md#BKMK_msdyn_postalcode_Annotations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_postalcode`|
|ReferencedAttribute|`msdyn_postalcodeid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_postalcode`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_priority_Annotations"></a> msdyn_priority_Annotations

One-To-Many Relationship: [msdyn_priority msdyn_priority_Annotations](msdyn_priority.md#BKMK_msdyn_priority_Annotations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_priority`|
|ReferencedAttribute|`msdyn_priorityid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_priority`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_productinventory_Annotations"></a> msdyn_productinventory_Annotations

One-To-Many Relationship: [msdyn_productinventory msdyn_productinventory_Annotations](msdyn_productinventory.md#BKMK_msdyn_productinventory_Annotations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_productinventory`|
|ReferencedAttribute|`msdyn_productinventoryid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_productinventory`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_purchaseorder_Annotations"></a> msdyn_purchaseorder_Annotations

One-To-Many Relationship: [msdyn_purchaseorder msdyn_purchaseorder_Annotations](msdyn_purchaseorder.md#BKMK_msdyn_purchaseorder_Annotations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_purchaseorder`|
|ReferencedAttribute|`msdyn_purchaseorderid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_purchaseorder`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_purchaseorderbill_Annotations"></a> msdyn_purchaseorderbill_Annotations

One-To-Many Relationship: [msdyn_purchaseorderbill msdyn_purchaseorderbill_Annotations](msdyn_purchaseorderbill.md#BKMK_msdyn_purchaseorderbill_Annotations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_purchaseorderbill`|
|ReferencedAttribute|`msdyn_purchaseorderbillid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_purchaseorderbill`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_purchaseorderproduct_Annotations"></a> msdyn_purchaseorderproduct_Annotations

One-To-Many Relationship: [msdyn_purchaseorderproduct msdyn_purchaseorderproduct_Annotations](msdyn_purchaseorderproduct.md#BKMK_msdyn_purchaseorderproduct_Annotations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_purchaseorderproduct`|
|ReferencedAttribute|`msdyn_purchaseorderproductid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_purchaseorderproduct`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_purchaseorderreceipt_Annotations"></a> msdyn_purchaseorderreceipt_Annotations

One-To-Many Relationship: [msdyn_purchaseorderreceipt msdyn_purchaseorderreceipt_Annotations](msdyn_purchaseorderreceipt.md#BKMK_msdyn_purchaseorderreceipt_Annotations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_purchaseorderreceipt`|
|ReferencedAttribute|`msdyn_purchaseorderreceiptid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_purchaseorderreceipt`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_purchaseorderreceiptproduct_Annotations"></a> msdyn_purchaseorderreceiptproduct_Annotations

One-To-Many Relationship: [msdyn_purchaseorderreceiptproduct msdyn_purchaseorderreceiptproduct_Annotations](msdyn_purchaseorderreceiptproduct.md#BKMK_msdyn_purchaseorderreceiptproduct_Annotations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_purchaseorderreceiptproduct`|
|ReferencedAttribute|`msdyn_purchaseorderreceiptproductid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_purchaseorderreceiptproduct`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_purchaseordersubstatus_Annotations"></a> msdyn_purchaseordersubstatus_Annotations

One-To-Many Relationship: [msdyn_purchaseordersubstatus msdyn_purchaseordersubstatus_Annotations](msdyn_purchaseordersubstatus.md#BKMK_msdyn_purchaseordersubstatus_Annotations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_purchaseordersubstatus`|
|ReferencedAttribute|`msdyn_purchaseordersubstatusid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_purchaseordersubstatus`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_quotebookingincident_Annotations"></a> msdyn_quotebookingincident_Annotations

One-To-Many Relationship: [msdyn_quotebookingincident msdyn_quotebookingincident_Annotations](msdyn_quotebookingincident.md#BKMK_msdyn_quotebookingincident_Annotations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_quotebookingincident`|
|ReferencedAttribute|`msdyn_quotebookingincidentid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_quotebookingincident`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_quotebookingproduct_Annotations"></a> msdyn_quotebookingproduct_Annotations

One-To-Many Relationship: [msdyn_quotebookingproduct msdyn_quotebookingproduct_Annotations](msdyn_quotebookingproduct.md#BKMK_msdyn_quotebookingproduct_Annotations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_quotebookingproduct`|
|ReferencedAttribute|`msdyn_quotebookingproductid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_quotebookingproduct`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_quotebookingservice_Annotations"></a> msdyn_quotebookingservice_Annotations

One-To-Many Relationship: [msdyn_quotebookingservice msdyn_quotebookingservice_Annotations](msdyn_quotebookingservice.md#BKMK_msdyn_quotebookingservice_Annotations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_quotebookingservice`|
|ReferencedAttribute|`msdyn_quotebookingserviceid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_quotebookingservice`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_quotebookingservicetask_Annotations"></a> msdyn_quotebookingservicetask_Annotations

One-To-Many Relationship: [msdyn_quotebookingservicetask msdyn_quotebookingservicetask_Annotations](msdyn_quotebookingservicetask.md#BKMK_msdyn_quotebookingservicetask_Annotations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_quotebookingservicetask`|
|ReferencedAttribute|`msdyn_quotebookingservicetaskid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_quotebookingservicetask`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_requirementcharacteristic_Annotations"></a> msdyn_requirementcharacteristic_Annotations

One-To-Many Relationship: [msdyn_requirementcharacteristic msdyn_requirementcharacteristic_Annotations](msdyn_requirementcharacteristic.md#BKMK_msdyn_requirementcharacteristic_Annotations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_requirementcharacteristic`|
|ReferencedAttribute|`msdyn_requirementcharacteristicid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_requirementcharacteristic`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_requirementresourcecategory_Annotations"></a> msdyn_requirementresourcecategory_Annotations

One-To-Many Relationship: [msdyn_requirementresourcecategory msdyn_requirementresourcecategory_Annotations](msdyn_requirementresourcecategory.md#BKMK_msdyn_requirementresourcecategory_Annotations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_requirementresourcecategory`|
|ReferencedAttribute|`msdyn_requirementresourcecategoryid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_requirementresourcecategory`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_requirementresourcepreference_Annotations"></a> msdyn_requirementresourcepreference_Annotations

One-To-Many Relationship: [msdyn_requirementresourcepreference msdyn_requirementresourcepreference_Annotations](msdyn_requirementresourcepreference.md#BKMK_msdyn_requirementresourcepreference_Annotations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_requirementresourcepreference`|
|ReferencedAttribute|`msdyn_requirementresourcepreferenceid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_requirementresourcepreference`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_requirementstatus_Annotations"></a> msdyn_requirementstatus_Annotations

One-To-Many Relationship: [msdyn_requirementstatus msdyn_requirementstatus_Annotations](msdyn_requirementstatus.md#BKMK_msdyn_requirementstatus_Annotations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_requirementstatus`|
|ReferencedAttribute|`msdyn_requirementstatusid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_requirementstatus`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_resourcepaytype_Annotations"></a> msdyn_resourcepaytype_Annotations

One-To-Many Relationship: [msdyn_resourcepaytype msdyn_resourcepaytype_Annotations](msdyn_resourcepaytype.md#BKMK_msdyn_resourcepaytype_Annotations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_resourcepaytype`|
|ReferencedAttribute|`msdyn_resourcepaytypeid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_resourcepaytype`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_resourcerequirement_Annotations"></a> msdyn_resourcerequirement_Annotations

One-To-Many Relationship: [msdyn_resourcerequirement msdyn_resourcerequirement_Annotations](msdyn_resourcerequirement.md#BKMK_msdyn_resourcerequirement_Annotations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_resourcerequirement`|
|ReferencedAttribute|`msdyn_resourcerequirementid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_resourcerequirement`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_resourcerequirementdetail_Annotations"></a> msdyn_resourcerequirementdetail_Annotations

One-To-Many Relationship: [msdyn_resourcerequirementdetail msdyn_resourcerequirementdetail_Annotations](msdyn_resourcerequirementdetail.md#BKMK_msdyn_resourcerequirementdetail_Annotations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_resourcerequirementdetail`|
|ReferencedAttribute|`msdyn_resourcerequirementdetailid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_resourcerequirementdetail`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_resourceterritory_Annotations"></a> msdyn_resourceterritory_Annotations

One-To-Many Relationship: [msdyn_resourceterritory msdyn_resourceterritory_Annotations](msdyn_resourceterritory.md#BKMK_msdyn_resourceterritory_Annotations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_resourceterritory`|
|ReferencedAttribute|`msdyn_resourceterritoryid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_resourceterritory`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_rma_Annotations"></a> msdyn_rma_Annotations

One-To-Many Relationship: [msdyn_rma msdyn_rma_Annotations](msdyn_rma.md#BKMK_msdyn_rma_Annotations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_rma`|
|ReferencedAttribute|`msdyn_rmaid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_rma`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_rmaproduct_Annotations"></a> msdyn_rmaproduct_Annotations

One-To-Many Relationship: [msdyn_rmaproduct msdyn_rmaproduct_Annotations](msdyn_rmaproduct.md#BKMK_msdyn_rmaproduct_Annotations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_rmaproduct`|
|ReferencedAttribute|`msdyn_rmaproductid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_rmaproduct`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_rmareceipt_Annotations"></a> msdyn_rmareceipt_Annotations

One-To-Many Relationship: [msdyn_rmareceipt msdyn_rmareceipt_Annotations](msdyn_rmareceipt.md#BKMK_msdyn_rmareceipt_Annotations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_rmareceipt`|
|ReferencedAttribute|`msdyn_rmareceiptid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_rmareceipt`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_rmareceiptproduct_Annotations"></a> msdyn_rmareceiptproduct_Annotations

One-To-Many Relationship: [msdyn_rmareceiptproduct msdyn_rmareceiptproduct_Annotations](msdyn_rmareceiptproduct.md#BKMK_msdyn_rmareceiptproduct_Annotations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_rmareceiptproduct`|
|ReferencedAttribute|`msdyn_rmareceiptproductid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_rmareceiptproduct`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_rmasubstatus_Annotations"></a> msdyn_rmasubstatus_Annotations

One-To-Many Relationship: [msdyn_rmasubstatus msdyn_rmasubstatus_Annotations](msdyn_rmasubstatus.md#BKMK_msdyn_rmasubstatus_Annotations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_rmasubstatus`|
|ReferencedAttribute|`msdyn_rmasubstatusid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_rmasubstatus`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_rtv_Annotations"></a> msdyn_rtv_Annotations

One-To-Many Relationship: [msdyn_rtv msdyn_rtv_Annotations](msdyn_rtv.md#BKMK_msdyn_rtv_Annotations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_rtv`|
|ReferencedAttribute|`msdyn_rtvid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_rtv`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_rtvproduct_Annotations"></a> msdyn_rtvproduct_Annotations

One-To-Many Relationship: [msdyn_rtvproduct msdyn_rtvproduct_Annotations](msdyn_rtvproduct.md#BKMK_msdyn_rtvproduct_Annotations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_rtvproduct`|
|ReferencedAttribute|`msdyn_rtvproductid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_rtvproduct`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_rtvsubstatus_Annotations"></a> msdyn_rtvsubstatus_Annotations

One-To-Many Relationship: [msdyn_rtvsubstatus msdyn_rtvsubstatus_Annotations](msdyn_rtvsubstatus.md#BKMK_msdyn_rtvsubstatus_Annotations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_rtvsubstatus`|
|ReferencedAttribute|`msdyn_rtvsubstatusid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_rtvsubstatus`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_salessuggestion_Annotations"></a> msdyn_salessuggestion_Annotations

One-To-Many Relationship: [msdyn_salessuggestion msdyn_salessuggestion_Annotations](msdyn_salessuggestion.md#BKMK_msdyn_salessuggestion_Annotations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_salessuggestion`|
|ReferencedAttribute|`msdyn_salessuggestionid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_salessuggestion`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_servicetasktype_Annotations"></a> msdyn_servicetasktype_Annotations

One-To-Many Relationship: [msdyn_servicetasktype msdyn_servicetasktype_Annotations](msdyn_servicetasktype.md#BKMK_msdyn_servicetasktype_Annotations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_servicetasktype`|
|ReferencedAttribute|`msdyn_servicetasktypeid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_servicetasktype`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_shipvia_Annotations"></a> msdyn_shipvia_Annotations

One-To-Many Relationship: [msdyn_shipvia msdyn_shipvia_Annotations](msdyn_shipvia.md#BKMK_msdyn_shipvia_Annotations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_shipvia`|
|ReferencedAttribute|`msdyn_shipviaid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_shipvia`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_soundfile_Annotations"></a> msdyn_soundfile_Annotations

One-To-Many Relationship: [msdyn_soundfile msdyn_soundfile_Annotations](msdyn_soundfile.md#BKMK_msdyn_soundfile_Annotations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_soundfile`|
|ReferencedAttribute|`msdyn_soundfileid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_soundfile`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_soundnotificationsetting_Annotations"></a> msdyn_soundnotificationsetting_Annotations

One-To-Many Relationship: [msdyn_soundnotificationsetting msdyn_soundnotificationsetting_Annotations](msdyn_soundnotificationsetting.md#BKMK_msdyn_soundnotificationsetting_Annotations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_soundnotificationsetting`|
|ReferencedAttribute|`msdyn_soundnotificationsettingid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_soundnotificationsetting`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_swarm_Annotations"></a> msdyn_swarm_Annotations

One-To-Many Relationship: [msdyn_swarm msdyn_swarm_Annotations](msdyn_swarm.md#BKMK_msdyn_swarm_Annotations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_swarm`|
|ReferencedAttribute|`msdyn_swarmid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_swarm`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_systemuserschedulersetting_Annotations"></a> msdyn_systemuserschedulersetting_Annotations

One-To-Many Relationship: [msdyn_systemuserschedulersetting msdyn_systemuserschedulersetting_Annotations](msdyn_systemuserschedulersetting.md#BKMK_msdyn_systemuserschedulersetting_Annotations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_systemuserschedulersetting`|
|ReferencedAttribute|`msdyn_systemuserschedulersettingid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_systemuserschedulersetting`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_taggedrecord_Annotations"></a> msdyn_taggedrecord_Annotations

One-To-Many Relationship: [msdyn_taggedrecord msdyn_taggedrecord_Annotations](msdyn_taggedrecord.md#BKMK_msdyn_taggedrecord_Annotations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_taggedrecord`|
|ReferencedAttribute|`msdyn_taggedrecordid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_taggedrecord`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_taxcode_Annotations"></a> msdyn_taxcode_Annotations

One-To-Many Relationship: [msdyn_taxcode msdyn_taxcode_Annotations](msdyn_taxcode.md#BKMK_msdyn_taxcode_Annotations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_taxcode`|
|ReferencedAttribute|`msdyn_taxcodeid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_taxcode`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_taxcodedetail_Annotations"></a> msdyn_taxcodedetail_Annotations

One-To-Many Relationship: [msdyn_taxcodedetail msdyn_taxcodedetail_Annotations](msdyn_taxcodedetail.md#BKMK_msdyn_taxcodedetail_Annotations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_taxcodedetail`|
|ReferencedAttribute|`msdyn_taxcodedetailid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_taxcodedetail`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_timeentry_Annotations"></a> msdyn_timeentry_Annotations

One-To-Many Relationship: [msdyn_timeentry msdyn_timeentry_Annotations](msdyn_timeentry.md#BKMK_msdyn_timeentry_Annotations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_timeentry`|
|ReferencedAttribute|`msdyn_timeentryid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_timeentry`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_timegroup_Annotations"></a> msdyn_timegroup_Annotations

One-To-Many Relationship: [msdyn_timegroup msdyn_timegroup_Annotations](msdyn_timegroup.md#BKMK_msdyn_timegroup_Annotations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_timegroup`|
|ReferencedAttribute|`msdyn_timegroupid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_timegroup`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_timegroupdetail_Annotations"></a> msdyn_timegroupdetail_Annotations

One-To-Many Relationship: [msdyn_timegroupdetail msdyn_timegroupdetail_Annotations](msdyn_timegroupdetail.md#BKMK_msdyn_timegroupdetail_Annotations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_timegroupdetail`|
|ReferencedAttribute|`msdyn_timegroupdetailid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_timegroupdetail`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_timeoffrequest_Annotations"></a> msdyn_timeoffrequest_Annotations

One-To-Many Relationship: [msdyn_timeoffrequest msdyn_timeoffrequest_Annotations](msdyn_timeoffrequest.md#BKMK_msdyn_timeoffrequest_Annotations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_timeoffrequest`|
|ReferencedAttribute|`msdyn_timeoffrequestid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_timeoffrequest`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_transactionorigin_Annotations"></a> msdyn_transactionorigin_Annotations

One-To-Many Relationship: [msdyn_transactionorigin msdyn_transactionorigin_Annotations](msdyn_transactionorigin.md#BKMK_msdyn_transactionorigin_Annotations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_transactionorigin`|
|ReferencedAttribute|`msdyn_transactionoriginid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_transactionorigin`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_transcript_Annotations"></a> msdyn_transcript_Annotations

One-To-Many Relationship: [msdyn_transcript msdyn_transcript_Annotations](msdyn_transcript.md#BKMK_msdyn_transcript_Annotations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_transcript`|
|ReferencedAttribute|`msdyn_transcriptid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_transcript`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_warehouse_Annotations"></a> msdyn_warehouse_Annotations

One-To-Many Relationship: [msdyn_warehouse msdyn_warehouse_Annotations](msdyn_warehouse.md#BKMK_msdyn_warehouse_Annotations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_warehouse`|
|ReferencedAttribute|`msdyn_warehouseid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_warehouse`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_workorder_Annotations"></a> msdyn_workorder_Annotations

One-To-Many Relationship: [msdyn_workorder msdyn_workorder_Annotations](msdyn_workorder.md#BKMK_msdyn_workorder_Annotations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_workorder`|
|ReferencedAttribute|`msdyn_workorderid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_workorder`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_workordercharacteristic_Annotations"></a> msdyn_workordercharacteristic_Annotations

One-To-Many Relationship: [msdyn_workordercharacteristic msdyn_workordercharacteristic_Annotations](msdyn_workordercharacteristic.md#BKMK_msdyn_workordercharacteristic_Annotations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_workordercharacteristic`|
|ReferencedAttribute|`msdyn_workordercharacteristicid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_workordercharacteristic`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_workorderincident_Annotations"></a> msdyn_workorderincident_Annotations

One-To-Many Relationship: [msdyn_workorderincident msdyn_workorderincident_Annotations](msdyn_workorderincident.md#BKMK_msdyn_workorderincident_Annotations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_workorderincident`|
|ReferencedAttribute|`msdyn_workorderincidentid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_workorderincident`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_workorderproduct_Annotations"></a> msdyn_workorderproduct_Annotations

One-To-Many Relationship: [msdyn_workorderproduct msdyn_workorderproduct_Annotations](msdyn_workorderproduct.md#BKMK_msdyn_workorderproduct_Annotations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_workorderproduct`|
|ReferencedAttribute|`msdyn_workorderproductid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_workorderproduct`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_workorderresourcerestriction_Annotations"></a> msdyn_workorderresourcerestriction_Annotations

One-To-Many Relationship: [msdyn_workorderresourcerestriction msdyn_workorderresourcerestriction_Annotations](msdyn_workorderresourcerestriction.md#BKMK_msdyn_workorderresourcerestriction_Annotations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_workorderresourcerestriction`|
|ReferencedAttribute|`msdyn_workorderresourcerestrictionid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_workorderresourcerestriction`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_workorderservice_Annotations"></a> msdyn_workorderservice_Annotations

One-To-Many Relationship: [msdyn_workorderservice msdyn_workorderservice_Annotations](msdyn_workorderservice.md#BKMK_msdyn_workorderservice_Annotations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_workorderservice`|
|ReferencedAttribute|`msdyn_workorderserviceid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_workorderservice`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_workorderservicetask_Annotations"></a> msdyn_workorderservicetask_Annotations

One-To-Many Relationship: [msdyn_workorderservicetask msdyn_workorderservicetask_Annotations](msdyn_workorderservicetask.md#BKMK_msdyn_workorderservicetask_Annotations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_workorderservicetask`|
|ReferencedAttribute|`msdyn_workorderservicetaskid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_workorderservicetask`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_workordersubstatus_Annotations"></a> msdyn_workordersubstatus_Annotations

One-To-Many Relationship: [msdyn_workordersubstatus msdyn_workordersubstatus_Annotations](msdyn_workordersubstatus.md#BKMK_msdyn_workordersubstatus_Annotations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_workordersubstatus`|
|ReferencedAttribute|`msdyn_workordersubstatusid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_workordersubstatus`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyncrm_appointmentactivitymarketingtemplate_Annotations"></a> msdyncrm_appointmentactivitymarketingtemplate_Annotations

One-To-Many Relationship: [msdyncrm_appointmentactivitymarketingtemplate msdyncrm_appointmentactivitymarketingtemplate_Annotations](msdyncrm_appointmentactivitymarketingtemplate.md#BKMK_msdyncrm_appointmentactivitymarketingtemplate_Annotations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyncrm_appointmentactivitymarketingtemplate`|
|ReferencedAttribute|`msdyncrm_appointmentactivitymarketingtemplateid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyncrm_appointmentactivitymarketingtemplate`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyncrm_contentsettings_Annotations"></a> msdyncrm_contentsettings_Annotations

One-To-Many Relationship: [msdyncrm_contentsettings msdyncrm_contentsettings_Annotations](msdyncrm_contentsettings.md#BKMK_msdyncrm_contentsettings_Annotations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyncrm_contentsettings`|
|ReferencedAttribute|`msdyncrm_contentsettingsid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyncrm_contentsettings`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyncrm_customerjourney_Annotations"></a> msdyncrm_customerjourney_Annotations

One-To-Many Relationship: [msdyncrm_customerjourney msdyncrm_customerjourney_Annotations](msdyncrm_customerjourney.md#BKMK_msdyncrm_customerjourney_Annotations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyncrm_customerjourney`|
|ReferencedAttribute|`msdyncrm_customerjourneyid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyncrm_customerjourney`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyncrm_leadscoremodel_Annotations"></a> msdyncrm_leadscoremodel_Annotations

One-To-Many Relationship: [msdyncrm_leadscoremodel msdyncrm_leadscoremodel_Annotations](msdyncrm_leadscoremodel.md#BKMK_msdyncrm_leadscoremodel_Annotations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyncrm_leadscoremodel`|
|ReferencedAttribute|`msdyncrm_leadscoremodelid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyncrm_leadscoremodel`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyncrm_linkedinaccount_Annotations"></a> msdyncrm_linkedinaccount_Annotations

One-To-Many Relationship: [msdyncrm_linkedinaccount msdyncrm_linkedinaccount_Annotations](msdyncrm_linkedinaccount.md#BKMK_msdyncrm_linkedinaccount_Annotations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyncrm_linkedinaccount`|
|ReferencedAttribute|`msdyncrm_linkedinaccountid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyncrm_linkedinaccount`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyncrm_linkedinactivity_Annotations"></a> msdyncrm_linkedinactivity_Annotations

One-To-Many Relationship: [msdyncrm_linkedinactivity msdyncrm_linkedinactivity_Annotations](msdyncrm_linkedinactivity.md#BKMK_msdyncrm_linkedinactivity_Annotations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyncrm_linkedinactivity`|
|ReferencedAttribute|`msdyncrm_linkedinactivityid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyncrm_linkedinactivity`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyncrm_linkedinfieldmapping_Annotations"></a> msdyncrm_linkedinfieldmapping_Annotations

One-To-Many Relationship: [msdyncrm_linkedinfieldmapping msdyncrm_linkedinfieldmapping_Annotations](msdyncrm_linkedinfieldmapping.md#BKMK_msdyncrm_linkedinfieldmapping_Annotations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyncrm_linkedinfieldmapping`|
|ReferencedAttribute|`msdyncrm_linkedinfieldmappingid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyncrm_linkedinfieldmapping`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyncrm_linkedinform_Annotations"></a> msdyncrm_linkedinform_Annotations

One-To-Many Relationship: [msdyncrm_linkedinform msdyncrm_linkedinform_Annotations](msdyncrm_linkedinform.md#BKMK_msdyncrm_linkedinform_Annotations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyncrm_linkedinform`|
|ReferencedAttribute|`msdyncrm_linkedinformid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyncrm_linkedinform`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyncrm_linkedinformanswer_Annotations"></a> msdyncrm_linkedinformanswer_Annotations

One-To-Many Relationship: [msdyncrm_linkedinformanswer msdyncrm_linkedinformanswer_Annotations](msdyncrm_linkedinformanswer.md#BKMK_msdyncrm_linkedinformanswer_Annotations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyncrm_linkedinformanswer`|
|ReferencedAttribute|`msdyncrm_linkedinformanswerid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyncrm_linkedinformanswer`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyncrm_linkedinformquestion_Annotations"></a> msdyncrm_linkedinformquestion_Annotations

One-To-Many Relationship: [msdyncrm_linkedinformquestion msdyncrm_linkedinformquestion_Annotations](msdyncrm_linkedinformquestion.md#BKMK_msdyncrm_linkedinformquestion_Annotations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyncrm_linkedinformquestion`|
|ReferencedAttribute|`msdyncrm_linkedinformquestionid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyncrm_linkedinformquestion`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyncrm_linkedinformsubmission_Annotations"></a> msdyncrm_linkedinformsubmission_Annotations

One-To-Many Relationship: [msdyncrm_linkedinformsubmission msdyncrm_linkedinformsubmission_Annotations](msdyncrm_linkedinformsubmission.md#BKMK_msdyncrm_linkedinformsubmission_Annotations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyncrm_linkedinformsubmission`|
|ReferencedAttribute|`msdyncrm_linkedinformsubmissionid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyncrm_linkedinformsubmission`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyncrm_linkedinleadmatchingstrategy_Annotations"></a> msdyncrm_linkedinleadmatchingstrategy_Annotations

One-To-Many Relationship: [msdyncrm_linkedinleadmatchingstrategy msdyncrm_linkedinleadmatchingstrategy_Annotations](msdyncrm_linkedinleadmatchingstrategy.md#BKMK_msdyncrm_linkedinleadmatchingstrategy_Annotations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyncrm_linkedinleadmatchingstrategy`|
|ReferencedAttribute|`msdyncrm_linkedinleadmatchingstrategyid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyncrm_linkedinleadmatchingstrategy`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyncrm_linkedinuserprofile_Annotations"></a> msdyncrm_linkedinuserprofile_Annotations

One-To-Many Relationship: [msdyncrm_linkedinuserprofile msdyncrm_linkedinuserprofile_Annotations](msdyncrm_linkedinuserprofile.md#BKMK_msdyncrm_linkedinuserprofile_Annotations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyncrm_linkedinuserprofile`|
|ReferencedAttribute|`msdyncrm_linkedinuserprofileid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyncrm_linkedinuserprofile`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyncrm_marketingdynamiccontentmetadata_Annotations"></a> msdyncrm_marketingdynamiccontentmetadata_Annotations

One-To-Many Relationship: [msdyncrm_marketingdynamiccontentmetadata msdyncrm_marketingdynamiccontentmetadata_Annotations](msdyncrm_marketingdynamiccontentmetadata.md#BKMK_msdyncrm_marketingdynamiccontentmetadata_Annotations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyncrm_marketingdynamiccontentmetadata`|
|ReferencedAttribute|`msdyncrm_marketingdynamiccontentmetadataid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyncrm_marketingdynamiccontentmetadata`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyncrm_marketingemaildynamiccontentmetadata_Annotations"></a> msdyncrm_marketingemaildynamiccontentmetadata_Annotations

One-To-Many Relationship: [msdyncrm_marketingemaildynamiccontentmetadata msdyncrm_marketingemaildynamiccontentmetadata_Annotations](msdyncrm_marketingemaildynamiccontentmetadata.md#BKMK_msdyncrm_marketingemaildynamiccontentmetadata_Annotations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyncrm_marketingemaildynamiccontentmetadata`|
|ReferencedAttribute|`msdyncrm_marketingemaildynamiccontentmetadataid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyncrm_marketingemaildynamiccontentmetadata`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyncrm_marketingemailtestsend_Annotations"></a> msdyncrm_marketingemailtestsend_Annotations

One-To-Many Relationship: [msdyncrm_marketingemailtestsend msdyncrm_marketingemailtestsend_Annotations](msdyncrm_marketingemailtestsend.md#BKMK_msdyncrm_marketingemailtestsend_Annotations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyncrm_marketingemailtestsend`|
|ReferencedAttribute|`msdyncrm_marketingemailtestsendid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyncrm_marketingemailtestsend`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyncrm_marketingform_Annotations"></a> msdyncrm_marketingform_Annotations

One-To-Many Relationship: [msdyncrm_marketingform msdyncrm_marketingform_Annotations](msdyncrm_marketingform.md#BKMK_msdyncrm_marketingform_Annotations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyncrm_marketingform`|
|ReferencedAttribute|`msdyncrm_marketingformid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyncrm_marketingform`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyncrm_marketingformtemplate_Annotations"></a> msdyncrm_marketingformtemplate_Annotations

One-To-Many Relationship: [msdyncrm_marketingformtemplate msdyncrm_marketingformtemplate_Annotations](msdyncrm_marketingformtemplate.md#BKMK_msdyncrm_marketingformtemplate_Annotations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyncrm_marketingformtemplate`|
|ReferencedAttribute|`msdyncrm_marketingformtemplateid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyncrm_marketingformtemplate`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyncrm_marketingpage_Annotations"></a> msdyncrm_marketingpage_Annotations

One-To-Many Relationship: [msdyncrm_marketingpage msdyncrm_marketingpage_Annotations](msdyncrm_marketingpage.md#BKMK_msdyncrm_marketingpage_Annotations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyncrm_marketingpage`|
|ReferencedAttribute|`msdyncrm_marketingpageid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyncrm_marketingpage`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyncrm_marketingpagetemplate_Annotations"></a> msdyncrm_marketingpagetemplate_Annotations

One-To-Many Relationship: [msdyncrm_marketingpagetemplate msdyncrm_marketingpagetemplate_Annotations](msdyncrm_marketingpagetemplate.md#BKMK_msdyncrm_marketingpagetemplate_Annotations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyncrm_marketingpagetemplate`|
|ReferencedAttribute|`msdyncrm_marketingpagetemplateid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyncrm_marketingpagetemplate`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyncrm_migration_Annotations"></a> msdyncrm_migration_Annotations

One-To-Many Relationship: [msdyncrm_migration msdyncrm_migration_Annotations](msdyncrm_migration.md#BKMK_msdyncrm_migration_Annotations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyncrm_migration`|
|ReferencedAttribute|`msdyncrm_migrationid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyncrm_migration`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyncrm_mktactivity_Annotations"></a> msdyncrm_mktactivity_Annotations

One-To-Many Relationship: [msdyncrm_mktactivity msdyncrm_mktactivity_Annotations](msdyncrm_mktactivity.md#BKMK_msdyncrm_mktactivity_Annotations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyncrm_mktactivity`|
|ReferencedAttribute|`msdyncrm_mktactivityid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyncrm_mktactivity`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyncrm_phonecallactivitymarketingtemplate_Annotations"></a> msdyncrm_phonecallactivitymarketingtemplate_Annotations

One-To-Many Relationship: [msdyncrm_phonecallactivitymarketingtemplate msdyncrm_phonecallactivitymarketingtemplate_Annotations](msdyncrm_phonecallactivitymarketingtemplate.md#BKMK_msdyncrm_phonecallactivitymarketingtemplate_Annotations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyncrm_phonecallactivitymarketingtemplate`|
|ReferencedAttribute|`msdyncrm_phonecallactivitymarketingtemplateid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyncrm_phonecallactivitymarketingtemplate`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyncrm_taskactivitymarketingtemplate_Annotations"></a> msdyncrm_taskactivitymarketingtemplate_Annotations

One-To-Many Relationship: [msdyncrm_taskactivitymarketingtemplate msdyncrm_taskactivitymarketingtemplate_Annotations](msdyncrm_taskactivitymarketingtemplate.md#BKMK_msdyncrm_taskactivitymarketingtemplate_Annotations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyncrm_taskactivitymarketingtemplate`|
|ReferencedAttribute|`msdyncrm_taskactivitymarketingtemplateid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyncrm_taskactivitymarketingtemplate`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyncrm_uicconfig_Annotations"></a> msdyncrm_uicconfig_Annotations

One-To-Many Relationship: [msdyncrm_uicconfig msdyncrm_uicconfig_Annotations](msdyncrm_uicconfig.md#BKMK_msdyncrm_uicconfig_Annotations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyncrm_uicconfig`|
|ReferencedAttribute|`msdyncrm_uicconfigid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyncrm_uicconfig`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msevtmgt_checkin_Annotations"></a> msevtmgt_checkin_Annotations

One-To-Many Relationship: [msevtmgt_checkin msevtmgt_checkin_Annotations](msevtmgt_checkin.md#BKMK_msevtmgt_checkin_Annotations)

|Property|Value|
|---|---|
|ReferencedEntity|`msevtmgt_checkin`|
|ReferencedAttribute|`msevtmgt_checkinid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msevtmgt_checkin`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msevtmgt_event_Annotations"></a> msevtmgt_event_Annotations

One-To-Many Relationship: [msevtmgt_event msevtmgt_event_Annotations](msevtmgt_event.md#BKMK_msevtmgt_event_Annotations)

|Property|Value|
|---|---|
|ReferencedEntity|`msevtmgt_event`|
|ReferencedAttribute|`msevtmgt_eventid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msevtmgt_event`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msevtmgt_eventpurchase_Annotations"></a> msevtmgt_eventpurchase_Annotations

One-To-Many Relationship: [msevtmgt_eventpurchase msevtmgt_eventpurchase_Annotations](msevtmgt_eventpurchase.md#BKMK_msevtmgt_eventpurchase_Annotations)

|Property|Value|
|---|---|
|ReferencedEntity|`msevtmgt_eventpurchase`|
|ReferencedAttribute|`msevtmgt_eventpurchaseid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msevtmgt_eventpurchase`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msevtmgt_eventpurchaseattendee_Annotations"></a> msevtmgt_eventpurchaseattendee_Annotations

One-To-Many Relationship: [msevtmgt_eventpurchaseattendee msevtmgt_eventpurchaseattendee_Annotations](msevtmgt_eventpurchaseattendee.md#BKMK_msevtmgt_eventpurchaseattendee_Annotations)

|Property|Value|
|---|---|
|ReferencedEntity|`msevtmgt_eventpurchaseattendee`|
|ReferencedAttribute|`msevtmgt_eventpurchaseattendeeid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msevtmgt_eventpurchaseattendee`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msevtmgt_eventpurchasepass_Annotations"></a> msevtmgt_eventpurchasepass_Annotations

One-To-Many Relationship: [msevtmgt_eventpurchasepass msevtmgt_eventpurchasepass_Annotations](msevtmgt_eventpurchasepass.md#BKMK_msevtmgt_eventpurchasepass_Annotations)

|Property|Value|
|---|---|
|ReferencedEntity|`msevtmgt_eventpurchasepass`|
|ReferencedAttribute|`msevtmgt_eventpurchasepassid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msevtmgt_eventpurchasepass`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msevtmgt_eventregistration_Annotations"></a> msevtmgt_eventregistration_Annotations

One-To-Many Relationship: [msevtmgt_eventregistration msevtmgt_eventregistration_Annotations](msevtmgt_eventregistration.md#BKMK_msevtmgt_eventregistration_Annotations)

|Property|Value|
|---|---|
|ReferencedEntity|`msevtmgt_eventregistration`|
|ReferencedAttribute|`msevtmgt_eventregistrationid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msevtmgt_eventregistration`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msevtmgt_hotel_Annotations"></a> msevtmgt_hotel_Annotations

One-To-Many Relationship: [msevtmgt_hotel msevtmgt_hotel_Annotations](msevtmgt_hotel.md#BKMK_msevtmgt_hotel_Annotations)

|Property|Value|
|---|---|
|ReferencedEntity|`msevtmgt_hotel`|
|ReferencedAttribute|`msevtmgt_hotelid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msevtmgt_hotel`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msevtmgt_hotelroomallocation_Annotations"></a> msevtmgt_hotelroomallocation_Annotations

One-To-Many Relationship: [msevtmgt_hotelroomallocation msevtmgt_hotelroomallocation_Annotations](msevtmgt_hotelroomallocation.md#BKMK_msevtmgt_hotelroomallocation_Annotations)

|Property|Value|
|---|---|
|ReferencedEntity|`msevtmgt_hotelroomallocation`|
|ReferencedAttribute|`msevtmgt_hotelroomallocationid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msevtmgt_hotelroomallocation`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msevtmgt_hotelroomreservation_Annotations"></a> msevtmgt_hotelroomreservation_Annotations

One-To-Many Relationship: [msevtmgt_hotelroomreservation msevtmgt_hotelroomreservation_Annotations](msevtmgt_hotelroomreservation.md#BKMK_msevtmgt_hotelroomreservation_Annotations)

|Property|Value|
|---|---|
|ReferencedEntity|`msevtmgt_hotelroomreservation`|
|ReferencedAttribute|`msevtmgt_hotelroomreservationid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msevtmgt_hotelroomreservation`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msevtmgt_layout_Annotations"></a> msevtmgt_layout_Annotations

One-To-Many Relationship: [msevtmgt_layout msevtmgt_layout_Annotations](msevtmgt_layout.md#BKMK_msevtmgt_layout_Annotations)

|Property|Value|
|---|---|
|ReferencedEntity|`msevtmgt_layout`|
|ReferencedAttribute|`msevtmgt_layoutid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msevtmgt_layout`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msevtmgt_room_Annotations"></a> msevtmgt_room_Annotations

One-To-Many Relationship: [msevtmgt_room msevtmgt_room_Annotations](msevtmgt_room.md#BKMK_msevtmgt_room_Annotations)

|Property|Value|
|---|---|
|ReferencedEntity|`msevtmgt_room`|
|ReferencedAttribute|`msevtmgt_roomid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msevtmgt_room`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msevtmgt_session_Annotations"></a> msevtmgt_session_Annotations

One-To-Many Relationship: [msevtmgt_session msevtmgt_session_Annotations](msevtmgt_session.md#BKMK_msevtmgt_session_Annotations)

|Property|Value|
|---|---|
|ReferencedEntity|`msevtmgt_session`|
|ReferencedAttribute|`msevtmgt_sessionid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msevtmgt_session`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msevtmgt_sessionregistration_Annotations"></a> msevtmgt_sessionregistration_Annotations

One-To-Many Relationship: [msevtmgt_sessionregistration msevtmgt_sessionregistration_Annotations](msevtmgt_sessionregistration.md#BKMK_msevtmgt_sessionregistration_Annotations)

|Property|Value|
|---|---|
|ReferencedEntity|`msevtmgt_sessionregistration`|
|ReferencedAttribute|`msevtmgt_sessionregistrationid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msevtmgt_sessionregistration`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msevtmgt_sessiontrack_Annotations"></a> msevtmgt_sessiontrack_Annotations

One-To-Many Relationship: [msevtmgt_sessiontrack msevtmgt_sessiontrack_Annotations](msevtmgt_sessiontrack.md#BKMK_msevtmgt_sessiontrack_Annotations)

|Property|Value|
|---|---|
|ReferencedEntity|`msevtmgt_sessiontrack`|
|ReferencedAttribute|`msevtmgt_sessiontrackid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msevtmgt_sessiontrack`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msevtmgt_speaker_Annotations"></a> msevtmgt_speaker_Annotations

One-To-Many Relationship: [msevtmgt_speaker msevtmgt_speaker_Annotations](msevtmgt_speaker.md#BKMK_msevtmgt_speaker_Annotations)

|Property|Value|
|---|---|
|ReferencedEntity|`msevtmgt_speaker`|
|ReferencedAttribute|`msevtmgt_speakerid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msevtmgt_speaker`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msevtmgt_speakerengagement_Annotations"></a> msevtmgt_speakerengagement_Annotations

One-To-Many Relationship: [msevtmgt_speakerengagement msevtmgt_speakerengagement_Annotations](msevtmgt_speakerengagement.md#BKMK_msevtmgt_speakerengagement_Annotations)

|Property|Value|
|---|---|
|ReferencedEntity|`msevtmgt_speakerengagement`|
|ReferencedAttribute|`msevtmgt_speakerengagementid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msevtmgt_speakerengagement`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msevtmgt_sponsorablearticle_Annotations"></a> msevtmgt_sponsorablearticle_Annotations

One-To-Many Relationship: [msevtmgt_sponsorablearticle msevtmgt_sponsorablearticle_Annotations](msevtmgt_sponsorablearticle.md#BKMK_msevtmgt_sponsorablearticle_Annotations)

|Property|Value|
|---|---|
|ReferencedEntity|`msevtmgt_sponsorablearticle`|
|ReferencedAttribute|`msevtmgt_sponsorablearticleid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msevtmgt_sponsorablearticle`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msevtmgt_sponsorship_Annotations"></a> msevtmgt_sponsorship_Annotations

One-To-Many Relationship: [msevtmgt_sponsorship msevtmgt_sponsorship_Annotations](msevtmgt_sponsorship.md#BKMK_msevtmgt_sponsorship_Annotations)

|Property|Value|
|---|---|
|ReferencedEntity|`msevtmgt_sponsorship`|
|ReferencedAttribute|`msevtmgt_sponsorshipid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msevtmgt_sponsorship`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msevtmgt_venue_Annotations"></a> msevtmgt_venue_Annotations

One-To-Many Relationship: [msevtmgt_venue msevtmgt_venue_Annotations](msevtmgt_venue.md#BKMK_msevtmgt_venue_Annotations)

|Property|Value|
|---|---|
|ReferencedEntity|`msevtmgt_venue`|
|ReferencedAttribute|`msevtmgt_venueid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msevtmgt_venue`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msevtmgt_webinarconfiguration_Annotations"></a> msevtmgt_webinarconfiguration_Annotations

One-To-Many Relationship: [msevtmgt_webinarconfiguration msevtmgt_webinarconfiguration_Annotations](msevtmgt_webinarconfiguration.md#BKMK_msevtmgt_webinarconfiguration_Annotations)

|Property|Value|
|---|---|
|ReferencedEntity|`msevtmgt_webinarconfiguration`|
|ReferencedAttribute|`msevtmgt_webinarconfigurationid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msevtmgt_webinarconfiguration`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msevtmgt_webinarprovider_Annotations"></a> msevtmgt_webinarprovider_Annotations

One-To-Many Relationship: [msevtmgt_webinarprovider msevtmgt_webinarprovider_Annotations](msevtmgt_webinarprovider.md#BKMK_msevtmgt_webinarprovider_Annotations)

|Property|Value|
|---|---|
|ReferencedEntity|`msevtmgt_webinarprovider`|
|ReferencedAttribute|`msevtmgt_webinarproviderid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msevtmgt_webinarprovider`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msfp_alert_Annotations"></a> msfp_alert_Annotations

One-To-Many Relationship: [msfp_alert msfp_alert_Annotations](msfp_alert.md#BKMK_msfp_alert_Annotations)

|Property|Value|
|---|---|
|ReferencedEntity|`msfp_alert`|
|ReferencedAttribute|`activityid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msfp_alert`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msfp_question_Annotations"></a> msfp_question_Annotations

One-To-Many Relationship: [msfp_question msfp_question_Annotations](msfp_question.md#BKMK_msfp_question_Annotations)

|Property|Value|
|---|---|
|ReferencedEntity|`msfp_question`|
|ReferencedAttribute|`msfp_questionid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msfp_question`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msfp_surveyinvite_Annotations"></a> msfp_surveyinvite_Annotations

One-To-Many Relationship: [msfp_surveyinvite msfp_surveyinvite_Annotations](msfp_surveyinvite.md#BKMK_msfp_surveyinvite_Annotations)

|Property|Value|
|---|---|
|ReferencedEntity|`msfp_surveyinvite`|
|ReferencedAttribute|`activityid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msfp_surveyinvite`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msfp_surveyresponse_Annotations"></a> msfp_surveyresponse_Annotations

One-To-Many Relationship: [msfp_surveyresponse msfp_surveyresponse_Annotations](msfp_surveyresponse.md#BKMK_msfp_surveyresponse_Annotations)

|Property|Value|
|---|---|
|ReferencedEntity|`msfp_surveyresponse`|
|ReferencedAttribute|`activityid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msfp_surveyresponse`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msmrw_3dasset_Annotations"></a> msmrw_3dasset_Annotations

One-To-Many Relationship: [msmrw_3dasset msmrw_3dasset_Annotations](msmrw_3dasset.md#BKMK_msmrw_3dasset_Annotations)

|Property|Value|
|---|---|
|ReferencedEntity|`msmrw_3dasset`|
|ReferencedAttribute|`msmrw_3dassetid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msmrw_3dasset`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msmrw_audioasset_Annotations"></a> msmrw_audioasset_Annotations

One-To-Many Relationship: [msmrw_audioasset msmrw_audioasset_Annotations](msmrw_audioasset.md#BKMK_msmrw_audioasset_Annotations)

|Property|Value|
|---|---|
|ReferencedEntity|`msmrw_audioasset`|
|ReferencedAttribute|`msmrw_audioassetid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msmrw_audioasset`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msmrw_guide_Annotations"></a> msmrw_guide_Annotations

One-To-Many Relationship: [msmrw_guide msmrw_guide_Annotations](msmrw_guide.md#BKMK_msmrw_guide_Annotations)

|Property|Value|
|---|---|
|ReferencedEntity|`msmrw_guide`|
|ReferencedAttribute|`msmrw_guideid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msmrw_guide`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msmrw_imageasset_Annotations"></a> msmrw_imageasset_Annotations

One-To-Many Relationship: [msmrw_imageasset msmrw_imageasset_Annotations](msmrw_imageasset.md#BKMK_msmrw_imageasset_Annotations)

|Property|Value|
|---|---|
|ReferencedEntity|`msmrw_imageasset`|
|ReferencedAttribute|`msmrw_imageassetid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msmrw_imageasset`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msmrw_videoasset_Annotations"></a> msmrw_videoasset_Annotations

One-To-Many Relationship: [msmrw_videoasset msmrw_videoasset_Annotations](msmrw_videoasset.md#BKMK_msmrw_videoasset_Annotations)

|Property|Value|
|---|---|
|ReferencedEntity|`msmrw_videoasset`|
|ReferencedAttribute|`msmrw_videoassetid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msmrw_videoasset`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_Opportunity_Annotation"></a> Opportunity_Annotation

One-To-Many Relationship: [opportunity Opportunity_Annotation](opportunity.md#BKMK_Opportunity_Annotation)

|Property|Value|
|---|---|
|ReferencedEntity|`opportunity`|
|ReferencedAttribute|`opportunityid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_opportunity`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_OpportunityClose_Annotation"></a> OpportunityClose_Annotation

One-To-Many Relationship: [opportunityclose OpportunityClose_Annotation](opportunityclose.md#BKMK_OpportunityClose_Annotation)

|Property|Value|
|---|---|
|ReferencedEntity|`opportunityclose`|
|ReferencedAttribute|`activityid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_opportunityclose`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_OrderClose_Annotation"></a> OrderClose_Annotation

One-To-Many Relationship: [orderclose OrderClose_Annotation](orderclose.md#BKMK_OrderClose_Annotation)

|Property|Value|
|---|---|
|ReferencedEntity|`orderclose`|
|ReferencedAttribute|`activityid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_orderclose`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_Product_Annotation"></a> Product_Annotation

One-To-Many Relationship: [product Product_Annotation](product.md#BKMK_Product_Annotation)

|Property|Value|
|---|---|
|ReferencedEntity|`product`|
|ReferencedAttribute|`productid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_product`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_Quote_Annotation"></a> Quote_Annotation

One-To-Many Relationship: [quote Quote_Annotation](quote.md#BKMK_Quote_Annotation)

|Property|Value|
|---|---|
|ReferencedEntity|`quote`|
|ReferencedAttribute|`quoteid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_quote`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_QuoteClose_Annotation"></a> QuoteClose_Annotation

One-To-Many Relationship: [quoteclose QuoteClose_Annotation](quoteclose.md#BKMK_QuoteClose_Annotation)

|Property|Value|
|---|---|
|ReferencedEntity|`quoteclose`|
|ReferencedAttribute|`activityid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_quoteclose`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_ResourceSpec_Annotation"></a> ResourceSpec_Annotation

One-To-Many Relationship: [resourcespec ResourceSpec_Annotation](resourcespec.md#BKMK_ResourceSpec_Annotation)

|Property|Value|
|---|---|
|ReferencedEntity|`resourcespec`|
|ReferencedAttribute|`resourcespecid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_resourcespec`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_SalesOrder_Annotation"></a> SalesOrder_Annotation

One-To-Many Relationship: [salesorder SalesOrder_Annotation](salesorder.md#BKMK_SalesOrder_Annotation)

|Property|Value|
|---|---|
|ReferencedEntity|`salesorder`|
|ReferencedAttribute|`salesorderid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_salesorder`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_Service_Annotation"></a> Service_Annotation

One-To-Many Relationship: [service Service_Annotation](service.md#BKMK_Service_Annotation)

|Property|Value|
|---|---|
|ReferencedEntity|`service`|
|ReferencedAttribute|`serviceid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_service`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_ServiceAppointment_Annotation"></a> ServiceAppointment_Annotation

One-To-Many Relationship: [serviceappointment ServiceAppointment_Annotation](serviceappointment.md#BKMK_ServiceAppointment_Annotation)

|Property|Value|
|---|---|
|ReferencedEntity|`serviceappointment`|
|ReferencedAttribute|`activityid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_serviceappointment`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|



### See also

[Dataverse table/entity reference](../about-entity-reference.md)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   
<xref:Microsoft.Dynamics.CRM.annotation?displayProperty=fullName>
