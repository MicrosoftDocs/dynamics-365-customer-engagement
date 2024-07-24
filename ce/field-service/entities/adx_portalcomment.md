---
title: "Portal Comment (adx_portalcomment) table/entity reference (Microsoft Dynamics 365 Field Service)"
description: "Includes schema information and supported messages for the Portal Comment (adx_portalcomment) table/entity with Microsoft Dynamics 365 Field Service."
ms.date: 07.24.2024
ms.service: powerapps
ms.topic: reference
author: m-hartmann
ms.author: mhart
search.audienceType: 
  - developer
---

# Portal Comment (adx_portalcomment) table/entity reference

An activity which is used to share information between the user and the customer on the portal.

> [!NOTE]
> The Microsoft Dynamics 365 Field Service Portal Comment (adx_portalcomment) table extends the [Microsoft Dataverse Portal Comment (adx_portalcomment) table](/power-apps/developer/data-platform/reference/entities/adx_portalcomment).



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

- [adx_PortalCommentDirectionCode](#BKMK_adx_PortalCommentDirectionCode)
- [Community](#BKMK_Community)
- [OptionalAttendees](#BKMK_OptionalAttendees)
- [RegardingObjectId](#BKMK_RegardingObjectId)
- [RequiredAttendees](#BKMK_RequiredAttendees)

### <a name="BKMK_adx_PortalCommentDirectionCode"></a> adx_PortalCommentDirectionCode

Changes from [adx_PortalCommentDirectionCode (Microsoft Dataverse)](/power-apps/developer/data-platform/reference/entities/adx_portalcomment#BKMK_adx_PortalCommentDirectionCode)

|Property|Value|
|---|---|
|Description|Specifies whether the WebActivity created by Portal User or internal User.|


### <a name="BKMK_Community"></a> Community

Changes from [Community (Microsoft Dataverse)](/power-apps/developer/data-platform/reference/entities/adx_portalcomment#BKMK_Community)

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

### <a name="BKMK_OptionalAttendees"></a> OptionalAttendees

Changes from [OptionalAttendees (Microsoft Dataverse)](/power-apps/developer/data-platform/reference/entities/adx_portalcomment#BKMK_OptionalAttendees)

|Property|Value|
|---|---|
|Targets|entitlement|


### <a name="BKMK_RegardingObjectId"></a> RegardingObjectId

Changes from [RegardingObjectId (Microsoft Dataverse)](/power-apps/developer/data-platform/reference/entities/adx_portalcomment#BKMK_RegardingObjectId)

|Property|Value|
|---|---|
|Targets|adx_ad|


### <a name="BKMK_RequiredAttendees"></a> RequiredAttendees

Changes from [RequiredAttendees (Microsoft Dataverse)](/power-apps/developer/data-platform/reference/entities/adx_portalcomment#BKMK_RequiredAttendees)

|Property|Value|
|---|---|
|Targets|entitlement|


## Many-to-One relationships

These relationships are many-to-one. Listed by **SchemaName**.

- [adx_ad_adx_portalcomments](#BKMK_adx_ad_adx_portalcomments)
- [adx_adplacement_adx_portalcomments](#BKMK_adx_adplacement_adx_portalcomments)
- [adx_casedeflection_adx_portalcomments](#BKMK_adx_casedeflection_adx_portalcomments)
- [adx_communityforumaccesspermission_adx_portalcomments](#BKMK_adx_communityforumaccesspermission_adx_portalcomments)
- [adx_communityforumalert_adx_portalcomments](#BKMK_adx_communityforumalert_adx_portalcomments)
- [adx_contentaccesslevel_adx_portalcomments](#BKMK_adx_contentaccesslevel_adx_portalcomments)
- [adx_poll_adx_portalcomments](#BKMK_adx_poll_adx_portalcomments)
- [adx_polloption_adx_portalcomments](#BKMK_adx_polloption_adx_portalcomments)
- [adx_pollplacement_adx_portalcomments](#BKMK_adx_pollplacement_adx_portalcomments)
- [adx_pollsubmission_adx_portalcomments](#BKMK_adx_pollsubmission_adx_portalcomments)
- [adx_portalcomment_service_serviceid](#BKMK_adx_portalcomment_service_serviceid)
- [adx_publishingstatetransitionrule_adx_portalcomments](#BKMK_adx_publishingstatetransitionrule_adx_portalcomments)
- [adx_redirect_adx_portalcomments](#BKMK_adx_redirect_adx_portalcomments)
- [adx_shortcut_adx_portalcomments](#BKMK_adx_shortcut_adx_portalcomments)
- [adx_webpage_adx_portalcomments](#BKMK_adx_webpage_adx_portalcomments)
- [adx_website_adx_portalcomments](#BKMK_adx_website_adx_portalcomments)
- [bookableresourcebooking_adx_portalcomments](#BKMK_bookableresourcebooking_adx_portalcomments)
- [bookableresourcebookingheader_adx_portalcomments](#BKMK_bookableresourcebookingheader_adx_portalcomments)
- [bulkoperation_adx_portalcomments](#BKMK_bulkoperation_adx_portalcomments)
- [campaign_adx_portalcomments](#BKMK_campaign_adx_portalcomments)
- [campaignactivity_adx_portalcomments](#BKMK_campaignactivity_adx_portalcomments)
- [contract_adx_portalcomments](#BKMK_contract_adx_portalcomments)
- [entitlement_adx_portalcomments](#BKMK_entitlement_adx_portalcomments)
- [entitlementtemplate_adx_portalcomments](#BKMK_entitlementtemplate_adx_portalcomments)
- [incident_adx_portalcomments](#BKMK_incident_adx_portalcomments)
- [invoice_adx_portalcomments](#BKMK_invoice_adx_portalcomments)
- [lead_adx_portalcomments](#BKMK_lead_adx_portalcomments)
- [msdyn_agreement_adx_portalcomments](#BKMK_msdyn_agreement_adx_portalcomments)
- [msdyn_agreementbookingdate_adx_portalcomments](#BKMK_msdyn_agreementbookingdate_adx_portalcomments)
- [msdyn_agreementbookingincident_adx_portalcomments](#BKMK_msdyn_agreementbookingincident_adx_portalcomments)
- [msdyn_agreementbookingproduct_adx_portalcomments](#BKMK_msdyn_agreementbookingproduct_adx_portalcomments)
- [msdyn_agreementbookingservice_adx_portalcomments](#BKMK_msdyn_agreementbookingservice_adx_portalcomments)
- [msdyn_agreementbookingservicetask_adx_portalcomments](#BKMK_msdyn_agreementbookingservicetask_adx_portalcomments)
- [msdyn_agreementbookingsetup_adx_portalcomments](#BKMK_msdyn_agreementbookingsetup_adx_portalcomments)
- [msdyn_agreementinvoicedate_adx_portalcomments](#BKMK_msdyn_agreementinvoicedate_adx_portalcomments)
- [msdyn_agreementinvoiceproduct_adx_portalcomments](#BKMK_msdyn_agreementinvoiceproduct_adx_portalcomments)
- [msdyn_agreementinvoicesetup_adx_portalcomments](#BKMK_msdyn_agreementinvoicesetup_adx_portalcomments)
- [msdyn_bookingalertstatus_adx_portalcomments](#BKMK_msdyn_bookingalertstatus_adx_portalcomments)
- [msdyn_bookingrule_adx_portalcomments](#BKMK_msdyn_bookingrule_adx_portalcomments)
- [msdyn_bookingtimestamp_adx_portalcomments](#BKMK_msdyn_bookingtimestamp_adx_portalcomments)
- [msdyn_customerasset_adx_portalcomments](#BKMK_msdyn_customerasset_adx_portalcomments)
- [msdyn_fieldservicesetting_adx_portalcomments](#BKMK_msdyn_fieldservicesetting_adx_portalcomments)
- [msdyn_incidenttypecharacteristic_adx_portalcomments](#BKMK_msdyn_incidenttypecharacteristic_adx_portalcomments)
- [msdyn_incidenttypeproduct_adx_portalcomments](#BKMK_msdyn_incidenttypeproduct_adx_portalcomments)
- [msdyn_incidenttypeservice_adx_portalcomments](#BKMK_msdyn_incidenttypeservice_adx_portalcomments)
- [msdyn_inventoryadjustment_adx_portalcomments](#BKMK_msdyn_inventoryadjustment_adx_portalcomments)
- [msdyn_inventoryadjustmentproduct_adx_portalcomments](#BKMK_msdyn_inventoryadjustmentproduct_adx_portalcomments)
- [msdyn_inventoryjournal_adx_portalcomments](#BKMK_msdyn_inventoryjournal_adx_portalcomments)
- [msdyn_inventorytransfer_adx_portalcomments](#BKMK_msdyn_inventorytransfer_adx_portalcomments)
- [msdyn_payment_adx_portalcomments](#BKMK_msdyn_payment_adx_portalcomments)
- [msdyn_paymentdetail_adx_portalcomments](#BKMK_msdyn_paymentdetail_adx_portalcomments)
- [msdyn_paymentmethod_adx_portalcomments](#BKMK_msdyn_paymentmethod_adx_portalcomments)
- [msdyn_paymentterm_adx_portalcomments](#BKMK_msdyn_paymentterm_adx_portalcomments)
- [msdyn_playbookinstance_adx_portalcomments](#BKMK_msdyn_playbookinstance_adx_portalcomments)
- [msdyn_postalbum_adx_portalcomments](#BKMK_msdyn_postalbum_adx_portalcomments)
- [msdyn_postalcode_adx_portalcomments](#BKMK_msdyn_postalcode_adx_portalcomments)
- [msdyn_productinventory_adx_portalcomments](#BKMK_msdyn_productinventory_adx_portalcomments)
- [msdyn_purchaseorder_adx_portalcomments](#BKMK_msdyn_purchaseorder_adx_portalcomments)
- [msdyn_purchaseorderbill_adx_portalcomments](#BKMK_msdyn_purchaseorderbill_adx_portalcomments)
- [msdyn_purchaseorderproduct_adx_portalcomments](#BKMK_msdyn_purchaseorderproduct_adx_portalcomments)
- [msdyn_purchaseorderreceipt_adx_portalcomments](#BKMK_msdyn_purchaseorderreceipt_adx_portalcomments)
- [msdyn_purchaseorderreceiptproduct_adx_portalcomments](#BKMK_msdyn_purchaseorderreceiptproduct_adx_portalcomments)
- [msdyn_purchaseordersubstatus_adx_portalcomments](#BKMK_msdyn_purchaseordersubstatus_adx_portalcomments)
- [msdyn_quotebookingincident_adx_portalcomments](#BKMK_msdyn_quotebookingincident_adx_portalcomments)
- [msdyn_quotebookingproduct_adx_portalcomments](#BKMK_msdyn_quotebookingproduct_adx_portalcomments)
- [msdyn_quotebookingservice_adx_portalcomments](#BKMK_msdyn_quotebookingservice_adx_portalcomments)
- [msdyn_quotebookingservicetask_adx_portalcomments](#BKMK_msdyn_quotebookingservicetask_adx_portalcomments)
- [msdyn_resourceterritory_adx_portalcomments](#BKMK_msdyn_resourceterritory_adx_portalcomments)
- [msdyn_rma_adx_portalcomments](#BKMK_msdyn_rma_adx_portalcomments)
- [msdyn_rmaproduct_adx_portalcomments](#BKMK_msdyn_rmaproduct_adx_portalcomments)
- [msdyn_rmareceipt_adx_portalcomments](#BKMK_msdyn_rmareceipt_adx_portalcomments)
- [msdyn_rmareceiptproduct_adx_portalcomments](#BKMK_msdyn_rmareceiptproduct_adx_portalcomments)
- [msdyn_rmasubstatus_adx_portalcomments](#BKMK_msdyn_rmasubstatus_adx_portalcomments)
- [msdyn_rtv_adx_portalcomments](#BKMK_msdyn_rtv_adx_portalcomments)
- [msdyn_rtvproduct_adx_portalcomments](#BKMK_msdyn_rtvproduct_adx_portalcomments)
- [msdyn_rtvsubstatus_adx_portalcomments](#BKMK_msdyn_rtvsubstatus_adx_portalcomments)
- [msdyn_salessuggestion_adx_portalcomments](#BKMK_msdyn_salessuggestion_adx_portalcomments)
- [msdyn_shipvia_adx_portalcomments](#BKMK_msdyn_shipvia_adx_portalcomments)
- [msdyn_swarm_adx_portalcomments](#BKMK_msdyn_swarm_adx_portalcomments)
- [msdyn_systemuserschedulersetting_adx_portalcomments](#BKMK_msdyn_systemuserschedulersetting_adx_portalcomments)
- [msdyn_timegroup_adx_portalcomments](#BKMK_msdyn_timegroup_adx_portalcomments)
- [msdyn_timegroupdetail_adx_portalcomments](#BKMK_msdyn_timegroupdetail_adx_portalcomments)
- [msdyn_timeoffrequest_adx_portalcomments](#BKMK_msdyn_timeoffrequest_adx_portalcomments)
- [msdyn_warehouse_adx_portalcomments](#BKMK_msdyn_warehouse_adx_portalcomments)
- [msdyn_workorder_adx_portalcomments](#BKMK_msdyn_workorder_adx_portalcomments)
- [msdyn_workordercharacteristic_adx_portalcomments](#BKMK_msdyn_workordercharacteristic_adx_portalcomments)
- [msdyn_workorderincident_adx_portalcomments](#BKMK_msdyn_workorderincident_adx_portalcomments)
- [msdyn_workorderproduct_adx_portalcomments](#BKMK_msdyn_workorderproduct_adx_portalcomments)
- [msdyn_workorderresourcerestriction_adx_portalcomments](#BKMK_msdyn_workorderresourcerestriction_adx_portalcomments)
- [msdyn_workorderservice_adx_portalcomments](#BKMK_msdyn_workorderservice_adx_portalcomments)
- [msdyn_workorderservicetask_adx_portalcomments](#BKMK_msdyn_workorderservicetask_adx_portalcomments)
- [msdyncrm_contentsettings_adx_portalcomments](#BKMK_msdyncrm_contentsettings_adx_portalcomments)
- [msdyncrm_customerjourney_adx_portalcomments](#BKMK_msdyncrm_customerjourney_adx_portalcomments)
- [msdyncrm_leadscoremodel_adx_portalcomments](#BKMK_msdyncrm_leadscoremodel_adx_portalcomments)
- [msdyncrm_linkedinaccount_adx_portalcomments](#BKMK_msdyncrm_linkedinaccount_adx_portalcomments)
- [msdyncrm_linkedinactivity_adx_portalcomments](#BKMK_msdyncrm_linkedinactivity_adx_portalcomments)
- [msdyncrm_linkedinfieldmapping_adx_portalcomments](#BKMK_msdyncrm_linkedinfieldmapping_adx_portalcomments)
- [msdyncrm_linkedinform_adx_portalcomments](#BKMK_msdyncrm_linkedinform_adx_portalcomments)
- [msdyncrm_linkedinformanswer_adx_portalcomments](#BKMK_msdyncrm_linkedinformanswer_adx_portalcomments)
- [msdyncrm_linkedinformquestion_adx_portalcomments](#BKMK_msdyncrm_linkedinformquestion_adx_portalcomments)
- [msdyncrm_linkedinformsubmission_adx_portalcomments](#BKMK_msdyncrm_linkedinformsubmission_adx_portalcomments)
- [msdyncrm_linkedinleadmatchingstrategy_adx_portalcomments](#BKMK_msdyncrm_linkedinleadmatchingstrategy_adx_portalcomments)
- [msdyncrm_linkedinuserprofile_adx_portalcomments](#BKMK_msdyncrm_linkedinuserprofile_adx_portalcomments)
- [msdyncrm_marketingdynamiccontentmetadata_adx_portalcomments](#BKMK_msdyncrm_marketingdynamiccontentmetadata_adx_portalcomments)
- [msdyncrm_marketingemaildynamiccontentmetadata_adx_portalcomments](#BKMK_msdyncrm_marketingemaildynamiccontentmetadata_adx_portalcomments)
- [msdyncrm_marketingemailtestsend_adx_portalcomments](#BKMK_msdyncrm_marketingemailtestsend_adx_portalcomments)
- [msdyncrm_migration_adx_portalcomments](#BKMK_msdyncrm_migration_adx_portalcomments)
- [msdyncrm_uicconfig_adx_portalcomments](#BKMK_msdyncrm_uicconfig_adx_portalcomments)
- [msevtmgt_checkin_adx_portalcomments](#BKMK_msevtmgt_checkin_adx_portalcomments)
- [msevtmgt_event_adx_portalcomments](#BKMK_msevtmgt_event_adx_portalcomments)
- [msevtmgt_eventpurchase_adx_portalcomments](#BKMK_msevtmgt_eventpurchase_adx_portalcomments)
- [msevtmgt_eventpurchaseattendee_adx_portalcomments](#BKMK_msevtmgt_eventpurchaseattendee_adx_portalcomments)
- [msevtmgt_eventpurchasepass_adx_portalcomments](#BKMK_msevtmgt_eventpurchasepass_adx_portalcomments)
- [msevtmgt_eventregistration_adx_portalcomments](#BKMK_msevtmgt_eventregistration_adx_portalcomments)
- [msevtmgt_hotel_adx_portalcomments](#BKMK_msevtmgt_hotel_adx_portalcomments)
- [msevtmgt_hotelroomallocation_adx_portalcomments](#BKMK_msevtmgt_hotelroomallocation_adx_portalcomments)
- [msevtmgt_hotelroomreservation_adx_portalcomments](#BKMK_msevtmgt_hotelroomreservation_adx_portalcomments)
- [msevtmgt_layout_adx_portalcomments](#BKMK_msevtmgt_layout_adx_portalcomments)
- [msevtmgt_room_adx_portalcomments](#BKMK_msevtmgt_room_adx_portalcomments)
- [msevtmgt_session_adx_portalcomments](#BKMK_msevtmgt_session_adx_portalcomments)
- [msevtmgt_sessionregistration_adx_portalcomments](#BKMK_msevtmgt_sessionregistration_adx_portalcomments)
- [msevtmgt_sessiontrack_adx_portalcomments](#BKMK_msevtmgt_sessiontrack_adx_portalcomments)
- [msevtmgt_speaker_adx_portalcomments](#BKMK_msevtmgt_speaker_adx_portalcomments)
- [msevtmgt_speakerengagement_adx_portalcomments](#BKMK_msevtmgt_speakerengagement_adx_portalcomments)
- [msevtmgt_sponsorablearticle_adx_portalcomments](#BKMK_msevtmgt_sponsorablearticle_adx_portalcomments)
- [msevtmgt_sponsorship_adx_portalcomments](#BKMK_msevtmgt_sponsorship_adx_portalcomments)
- [msevtmgt_venue_adx_portalcomments](#BKMK_msevtmgt_venue_adx_portalcomments)
- [msevtmgt_webinarconfiguration_adx_portalcomments](#BKMK_msevtmgt_webinarconfiguration_adx_portalcomments)
- [msevtmgt_webinarprovider_adx_portalcomments](#BKMK_msevtmgt_webinarprovider_adx_portalcomments)
- [opportunity_adx_portalcomments](#BKMK_opportunity_adx_portalcomments)
- [quote_adx_portalcomments](#BKMK_quote_adx_portalcomments)
- [salesorder_adx_portalcomments](#BKMK_salesorder_adx_portalcomments)
- [service_adx_portalcomments](#BKMK_service_adx_portalcomments)
- [site_adx_portalcomments](#BKMK_site_adx_portalcomments)

### <a name="BKMK_adx_ad_adx_portalcomments"></a> adx_ad_adx_portalcomments

One-To-Many Relationship: [adx_ad adx_ad_adx_portalcomments](adx_ad.md#BKMK_adx_ad_adx_portalcomments)

|Property|Value|
|---|---|
|ReferencedEntity|`adx_ad`|
|ReferencedAttribute|`adx_adid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_adx_ad_adx_portalcomment`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_adx_adplacement_adx_portalcomments"></a> adx_adplacement_adx_portalcomments

One-To-Many Relationship: [adx_adplacement adx_adplacement_adx_portalcomments](adx_adplacement.md#BKMK_adx_adplacement_adx_portalcomments)

|Property|Value|
|---|---|
|ReferencedEntity|`adx_adplacement`|
|ReferencedAttribute|`adx_adplacementid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_adx_adplacement_adx_portalcomment`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_adx_casedeflection_adx_portalcomments"></a> adx_casedeflection_adx_portalcomments

One-To-Many Relationship: [adx_casedeflection adx_casedeflection_adx_portalcomments](adx_casedeflection.md#BKMK_adx_casedeflection_adx_portalcomments)

|Property|Value|
|---|---|
|ReferencedEntity|`adx_casedeflection`|
|ReferencedAttribute|`adx_casedeflectionid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_adx_casedeflection_adx_portalcomment`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_adx_communityforumaccesspermission_adx_portalcomments"></a> adx_communityforumaccesspermission_adx_portalcomments

One-To-Many Relationship: [adx_communityforumaccesspermission adx_communityforumaccesspermission_adx_portalcomments](adx_communityforumaccesspermission.md#BKMK_adx_communityforumaccesspermission_adx_portalcomments)

|Property|Value|
|---|---|
|ReferencedEntity|`adx_communityforumaccesspermission`|
|ReferencedAttribute|`adx_communityforumaccesspermissionid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_adx_communityforumaccesspermission_adx_portalcomment`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_adx_communityforumalert_adx_portalcomments"></a> adx_communityforumalert_adx_portalcomments

One-To-Many Relationship: [adx_communityforumalert adx_communityforumalert_adx_portalcomments](adx_communityforumalert.md#BKMK_adx_communityforumalert_adx_portalcomments)

|Property|Value|
|---|---|
|ReferencedEntity|`adx_communityforumalert`|
|ReferencedAttribute|`adx_communityforumalertid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_adx_communityforumalert_adx_portalcomment`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_adx_contentaccesslevel_adx_portalcomments"></a> adx_contentaccesslevel_adx_portalcomments

One-To-Many Relationship: [adx_contentaccesslevel adx_contentaccesslevel_adx_portalcomments](adx_contentaccesslevel.md#BKMK_adx_contentaccesslevel_adx_portalcomments)

|Property|Value|
|---|---|
|ReferencedEntity|`adx_contentaccesslevel`|
|ReferencedAttribute|`adx_contentaccesslevelid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_adx_contentaccesslevel_adx_portalcomment`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_adx_poll_adx_portalcomments"></a> adx_poll_adx_portalcomments

One-To-Many Relationship: [adx_poll adx_poll_adx_portalcomments](adx_poll.md#BKMK_adx_poll_adx_portalcomments)

|Property|Value|
|---|---|
|ReferencedEntity|`adx_poll`|
|ReferencedAttribute|`adx_pollid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_adx_poll_adx_portalcomment`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_adx_polloption_adx_portalcomments"></a> adx_polloption_adx_portalcomments

One-To-Many Relationship: [adx_polloption adx_polloption_adx_portalcomments](adx_polloption.md#BKMK_adx_polloption_adx_portalcomments)

|Property|Value|
|---|---|
|ReferencedEntity|`adx_polloption`|
|ReferencedAttribute|`adx_polloptionid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_adx_polloption_adx_portalcomment`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_adx_pollplacement_adx_portalcomments"></a> adx_pollplacement_adx_portalcomments

One-To-Many Relationship: [adx_pollplacement adx_pollplacement_adx_portalcomments](adx_pollplacement.md#BKMK_adx_pollplacement_adx_portalcomments)

|Property|Value|
|---|---|
|ReferencedEntity|`adx_pollplacement`|
|ReferencedAttribute|`adx_pollplacementid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_adx_pollplacement_adx_portalcomment`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_adx_pollsubmission_adx_portalcomments"></a> adx_pollsubmission_adx_portalcomments

One-To-Many Relationship: [adx_pollsubmission adx_pollsubmission_adx_portalcomments](adx_pollsubmission.md#BKMK_adx_pollsubmission_adx_portalcomments)

|Property|Value|
|---|---|
|ReferencedEntity|`adx_pollsubmission`|
|ReferencedAttribute|`adx_pollsubmissionid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_adx_pollsubmission_adx_portalcomment`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_adx_portalcomment_service_serviceid"></a> adx_portalcomment_service_serviceid

One-To-Many Relationship: [service adx_portalcomment_service_serviceid](service.md#BKMK_adx_portalcomment_service_serviceid)

|Property|Value|
|---|---|
|ReferencedEntity|`service`|
|ReferencedAttribute|`serviceid`|
|ReferencingAttribute|`serviceid`|
|ReferencingEntityNavigationPropertyName|`serviceid_adx_portalcomment`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Restrict`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_adx_publishingstatetransitionrule_adx_portalcomments"></a> adx_publishingstatetransitionrule_adx_portalcomments

One-To-Many Relationship: [adx_publishingstatetransitionrule adx_publishingstatetransitionrule_adx_portalcomments](adx_publishingstatetransitionrule.md#BKMK_adx_publishingstatetransitionrule_adx_portalcomments)

|Property|Value|
|---|---|
|ReferencedEntity|`adx_publishingstatetransitionrule`|
|ReferencedAttribute|`adx_publishingstatetransitionruleid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_adx_publishingstatetransitionrule_adx_portalcomment`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_adx_redirect_adx_portalcomments"></a> adx_redirect_adx_portalcomments

One-To-Many Relationship: [adx_redirect adx_redirect_adx_portalcomments](adx_redirect.md#BKMK_adx_redirect_adx_portalcomments)

|Property|Value|
|---|---|
|ReferencedEntity|`adx_redirect`|
|ReferencedAttribute|`adx_redirectid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_adx_redirect_adx_portalcomment`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_adx_shortcut_adx_portalcomments"></a> adx_shortcut_adx_portalcomments

One-To-Many Relationship: [adx_shortcut adx_shortcut_adx_portalcomments](adx_shortcut.md#BKMK_adx_shortcut_adx_portalcomments)

|Property|Value|
|---|---|
|ReferencedEntity|`adx_shortcut`|
|ReferencedAttribute|`adx_shortcutid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_adx_shortcut_adx_portalcomment`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_adx_webpage_adx_portalcomments"></a> adx_webpage_adx_portalcomments

One-To-Many Relationship: [adx_webpage adx_webpage_adx_portalcomments](adx_webpage.md#BKMK_adx_webpage_adx_portalcomments)

|Property|Value|
|---|---|
|ReferencedEntity|`adx_webpage`|
|ReferencedAttribute|`adx_webpageid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_adx_webpage_adx_portalcomment`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_adx_website_adx_portalcomments"></a> adx_website_adx_portalcomments

One-To-Many Relationship: [adx_website adx_website_adx_portalcomments](adx_website.md#BKMK_adx_website_adx_portalcomments)

|Property|Value|
|---|---|
|ReferencedEntity|`adx_website`|
|ReferencedAttribute|`adx_websiteid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_adx_website_adx_portalcomment`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_bookableresourcebooking_adx_portalcomments"></a> bookableresourcebooking_adx_portalcomments

One-To-Many Relationship: [bookableresourcebooking bookableresourcebooking_adx_portalcomments](bookableresourcebooking.md#BKMK_bookableresourcebooking_adx_portalcomments)

|Property|Value|
|---|---|
|ReferencedEntity|`bookableresourcebooking`|
|ReferencedAttribute|`bookableresourcebookingid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_bookableresourcebooking_adx_portalcomment`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_bookableresourcebookingheader_adx_portalcomments"></a> bookableresourcebookingheader_adx_portalcomments

One-To-Many Relationship: [bookableresourcebookingheader bookableresourcebookingheader_adx_portalcomments](bookableresourcebookingheader.md#BKMK_bookableresourcebookingheader_adx_portalcomments)

|Property|Value|
|---|---|
|ReferencedEntity|`bookableresourcebookingheader`|
|ReferencedAttribute|`bookableresourcebookingheaderid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_bookableresourcebookingheader_adx_portalcomment`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_bulkoperation_adx_portalcomments"></a> bulkoperation_adx_portalcomments

One-To-Many Relationship: [bulkoperation bulkoperation_adx_portalcomments](bulkoperation.md#BKMK_bulkoperation_adx_portalcomments)

|Property|Value|
|---|---|
|ReferencedEntity|`bulkoperation`|
|ReferencedAttribute|`activityid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_bulkoperation_adx_portalcomment`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_campaign_adx_portalcomments"></a> campaign_adx_portalcomments

One-To-Many Relationship: [campaign campaign_adx_portalcomments](campaign.md#BKMK_campaign_adx_portalcomments)

|Property|Value|
|---|---|
|ReferencedEntity|`campaign`|
|ReferencedAttribute|`campaignid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_campaign_adx_portalcomment`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_campaignactivity_adx_portalcomments"></a> campaignactivity_adx_portalcomments

One-To-Many Relationship: [campaignactivity campaignactivity_adx_portalcomments](campaignactivity.md#BKMK_campaignactivity_adx_portalcomments)

|Property|Value|
|---|---|
|ReferencedEntity|`campaignactivity`|
|ReferencedAttribute|`activityid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_campaignactivity_adx_portalcomment`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_contract_adx_portalcomments"></a> contract_adx_portalcomments

One-To-Many Relationship: [contract contract_adx_portalcomments](contract.md#BKMK_contract_adx_portalcomments)

|Property|Value|
|---|---|
|ReferencedEntity|`contract`|
|ReferencedAttribute|`contractid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_contract_adx_portalcomment`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_entitlement_adx_portalcomments"></a> entitlement_adx_portalcomments

One-To-Many Relationship: [entitlement entitlement_adx_portalcomments](entitlement.md#BKMK_entitlement_adx_portalcomments)

|Property|Value|
|---|---|
|ReferencedEntity|`entitlement`|
|ReferencedAttribute|`entitlementid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_entitlement_adx_portalcomment`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_entitlementtemplate_adx_portalcomments"></a> entitlementtemplate_adx_portalcomments

One-To-Many Relationship: [entitlementtemplate entitlementtemplate_adx_portalcomments](entitlementtemplate.md#BKMK_entitlementtemplate_adx_portalcomments)

|Property|Value|
|---|---|
|ReferencedEntity|`entitlementtemplate`|
|ReferencedAttribute|`entitlementtemplateid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_entitlementtemplate_adx_portalcomment`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_incident_adx_portalcomments"></a> incident_adx_portalcomments

One-To-Many Relationship: [incident incident_adx_portalcomments](incident.md#BKMK_incident_adx_portalcomments)

|Property|Value|
|---|---|
|ReferencedEntity|`incident`|
|ReferencedAttribute|`incidentid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_incident_adx_portalcomment`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_invoice_adx_portalcomments"></a> invoice_adx_portalcomments

One-To-Many Relationship: [invoice invoice_adx_portalcomments](invoice.md#BKMK_invoice_adx_portalcomments)

|Property|Value|
|---|---|
|ReferencedEntity|`invoice`|
|ReferencedAttribute|`invoiceid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_invoice_adx_portalcomment`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_lead_adx_portalcomments"></a> lead_adx_portalcomments

One-To-Many Relationship: [lead lead_adx_portalcomments](lead.md#BKMK_lead_adx_portalcomments)

|Property|Value|
|---|---|
|ReferencedEntity|`lead`|
|ReferencedAttribute|`leadid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_lead_adx_portalcomment`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_agreement_adx_portalcomments"></a> msdyn_agreement_adx_portalcomments

One-To-Many Relationship: [msdyn_agreement msdyn_agreement_adx_portalcomments](msdyn_agreement.md#BKMK_msdyn_agreement_adx_portalcomments)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_agreement`|
|ReferencedAttribute|`msdyn_agreementid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_agreement_adx_portalcomment`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_agreementbookingdate_adx_portalcomments"></a> msdyn_agreementbookingdate_adx_portalcomments

One-To-Many Relationship: [msdyn_agreementbookingdate msdyn_agreementbookingdate_adx_portalcomments](msdyn_agreementbookingdate.md#BKMK_msdyn_agreementbookingdate_adx_portalcomments)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_agreementbookingdate`|
|ReferencedAttribute|`msdyn_agreementbookingdateid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_agreementbookingdate_adx_portalcomment`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_agreementbookingincident_adx_portalcomments"></a> msdyn_agreementbookingincident_adx_portalcomments

One-To-Many Relationship: [msdyn_agreementbookingincident msdyn_agreementbookingincident_adx_portalcomments](msdyn_agreementbookingincident.md#BKMK_msdyn_agreementbookingincident_adx_portalcomments)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_agreementbookingincident`|
|ReferencedAttribute|`msdyn_agreementbookingincidentid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_agreementbookingincident_adx_portalcomment`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_agreementbookingproduct_adx_portalcomments"></a> msdyn_agreementbookingproduct_adx_portalcomments

One-To-Many Relationship: [msdyn_agreementbookingproduct msdyn_agreementbookingproduct_adx_portalcomments](msdyn_agreementbookingproduct.md#BKMK_msdyn_agreementbookingproduct_adx_portalcomments)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_agreementbookingproduct`|
|ReferencedAttribute|`msdyn_agreementbookingproductid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_agreementbookingproduct_adx_portalcomment`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_agreementbookingservice_adx_portalcomments"></a> msdyn_agreementbookingservice_adx_portalcomments

One-To-Many Relationship: [msdyn_agreementbookingservice msdyn_agreementbookingservice_adx_portalcomments](msdyn_agreementbookingservice.md#BKMK_msdyn_agreementbookingservice_adx_portalcomments)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_agreementbookingservice`|
|ReferencedAttribute|`msdyn_agreementbookingserviceid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_agreementbookingservice_adx_portalcomment`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_agreementbookingservicetask_adx_portalcomments"></a> msdyn_agreementbookingservicetask_adx_portalcomments

One-To-Many Relationship: [msdyn_agreementbookingservicetask msdyn_agreementbookingservicetask_adx_portalcomments](msdyn_agreementbookingservicetask.md#BKMK_msdyn_agreementbookingservicetask_adx_portalcomments)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_agreementbookingservicetask`|
|ReferencedAttribute|`msdyn_agreementbookingservicetaskid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_agreementbookingservicetask_adx_portalcomment`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_agreementbookingsetup_adx_portalcomments"></a> msdyn_agreementbookingsetup_adx_portalcomments

One-To-Many Relationship: [msdyn_agreementbookingsetup msdyn_agreementbookingsetup_adx_portalcomments](msdyn_agreementbookingsetup.md#BKMK_msdyn_agreementbookingsetup_adx_portalcomments)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_agreementbookingsetup`|
|ReferencedAttribute|`msdyn_agreementbookingsetupid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_agreementbookingsetup_adx_portalcomment`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_agreementinvoicedate_adx_portalcomments"></a> msdyn_agreementinvoicedate_adx_portalcomments

One-To-Many Relationship: [msdyn_agreementinvoicedate msdyn_agreementinvoicedate_adx_portalcomments](msdyn_agreementinvoicedate.md#BKMK_msdyn_agreementinvoicedate_adx_portalcomments)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_agreementinvoicedate`|
|ReferencedAttribute|`msdyn_agreementinvoicedateid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_agreementinvoicedate_adx_portalcomment`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_agreementinvoiceproduct_adx_portalcomments"></a> msdyn_agreementinvoiceproduct_adx_portalcomments

One-To-Many Relationship: [msdyn_agreementinvoiceproduct msdyn_agreementinvoiceproduct_adx_portalcomments](msdyn_agreementinvoiceproduct.md#BKMK_msdyn_agreementinvoiceproduct_adx_portalcomments)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_agreementinvoiceproduct`|
|ReferencedAttribute|`msdyn_agreementinvoiceproductid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_agreementinvoiceproduct_adx_portalcomment`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_agreementinvoicesetup_adx_portalcomments"></a> msdyn_agreementinvoicesetup_adx_portalcomments

One-To-Many Relationship: [msdyn_agreementinvoicesetup msdyn_agreementinvoicesetup_adx_portalcomments](msdyn_agreementinvoicesetup.md#BKMK_msdyn_agreementinvoicesetup_adx_portalcomments)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_agreementinvoicesetup`|
|ReferencedAttribute|`msdyn_agreementinvoicesetupid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_agreementinvoicesetup_adx_portalcomment`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_bookingalertstatus_adx_portalcomments"></a> msdyn_bookingalertstatus_adx_portalcomments

One-To-Many Relationship: [msdyn_bookingalertstatus msdyn_bookingalertstatus_adx_portalcomments](msdyn_bookingalertstatus.md#BKMK_msdyn_bookingalertstatus_adx_portalcomments)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_bookingalertstatus`|
|ReferencedAttribute|`msdyn_bookingalertstatusid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_bookingalertstatus_adx_portalcomment`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_bookingrule_adx_portalcomments"></a> msdyn_bookingrule_adx_portalcomments

One-To-Many Relationship: [msdyn_bookingrule msdyn_bookingrule_adx_portalcomments](msdyn_bookingrule.md#BKMK_msdyn_bookingrule_adx_portalcomments)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_bookingrule`|
|ReferencedAttribute|`msdyn_bookingruleid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_bookingrule_adx_portalcomment`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_bookingtimestamp_adx_portalcomments"></a> msdyn_bookingtimestamp_adx_portalcomments

One-To-Many Relationship: [msdyn_bookingtimestamp msdyn_bookingtimestamp_adx_portalcomments](msdyn_bookingtimestamp.md#BKMK_msdyn_bookingtimestamp_adx_portalcomments)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_bookingtimestamp`|
|ReferencedAttribute|`msdyn_bookingtimestampid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_bookingtimestamp_adx_portalcomment`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_customerasset_adx_portalcomments"></a> msdyn_customerasset_adx_portalcomments

One-To-Many Relationship: [msdyn_customerasset msdyn_customerasset_adx_portalcomments](msdyn_customerasset.md#BKMK_msdyn_customerasset_adx_portalcomments)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_customerasset`|
|ReferencedAttribute|`msdyn_customerassetid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_customerasset_adx_portalcomment`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_fieldservicesetting_adx_portalcomments"></a> msdyn_fieldservicesetting_adx_portalcomments

One-To-Many Relationship: [msdyn_fieldservicesetting msdyn_fieldservicesetting_adx_portalcomments](msdyn_fieldservicesetting.md#BKMK_msdyn_fieldservicesetting_adx_portalcomments)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_fieldservicesetting`|
|ReferencedAttribute|`msdyn_fieldservicesettingid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_fieldservicesetting_adx_portalcomment`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_incidenttypecharacteristic_adx_portalcomments"></a> msdyn_incidenttypecharacteristic_adx_portalcomments

One-To-Many Relationship: [msdyn_incidenttypecharacteristic msdyn_incidenttypecharacteristic_adx_portalcomments](msdyn_incidenttypecharacteristic.md#BKMK_msdyn_incidenttypecharacteristic_adx_portalcomments)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_incidenttypecharacteristic`|
|ReferencedAttribute|`msdyn_incidenttypecharacteristicid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_incidenttypecharacteristic_adx_portalcomment`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_incidenttypeproduct_adx_portalcomments"></a> msdyn_incidenttypeproduct_adx_portalcomments

One-To-Many Relationship: [msdyn_incidenttypeproduct msdyn_incidenttypeproduct_adx_portalcomments](msdyn_incidenttypeproduct.md#BKMK_msdyn_incidenttypeproduct_adx_portalcomments)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_incidenttypeproduct`|
|ReferencedAttribute|`msdyn_incidenttypeproductid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_incidenttypeproduct_adx_portalcomment`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_incidenttypeservice_adx_portalcomments"></a> msdyn_incidenttypeservice_adx_portalcomments

One-To-Many Relationship: [msdyn_incidenttypeservice msdyn_incidenttypeservice_adx_portalcomments](msdyn_incidenttypeservice.md#BKMK_msdyn_incidenttypeservice_adx_portalcomments)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_incidenttypeservice`|
|ReferencedAttribute|`msdyn_incidenttypeserviceid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_incidenttypeservice_adx_portalcomment`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_inventoryadjustment_adx_portalcomments"></a> msdyn_inventoryadjustment_adx_portalcomments

One-To-Many Relationship: [msdyn_inventoryadjustment msdyn_inventoryadjustment_adx_portalcomments](msdyn_inventoryadjustment.md#BKMK_msdyn_inventoryadjustment_adx_portalcomments)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_inventoryadjustment`|
|ReferencedAttribute|`msdyn_inventoryadjustmentid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_inventoryadjustment_adx_portalcomment`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_inventoryadjustmentproduct_adx_portalcomments"></a> msdyn_inventoryadjustmentproduct_adx_portalcomments

One-To-Many Relationship: [msdyn_inventoryadjustmentproduct msdyn_inventoryadjustmentproduct_adx_portalcomments](msdyn_inventoryadjustmentproduct.md#BKMK_msdyn_inventoryadjustmentproduct_adx_portalcomments)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_inventoryadjustmentproduct`|
|ReferencedAttribute|`msdyn_inventoryadjustmentproductid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_inventoryadjustmentproduct_adx_portalcomment`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_inventoryjournal_adx_portalcomments"></a> msdyn_inventoryjournal_adx_portalcomments

One-To-Many Relationship: [msdyn_inventoryjournal msdyn_inventoryjournal_adx_portalcomments](msdyn_inventoryjournal.md#BKMK_msdyn_inventoryjournal_adx_portalcomments)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_inventoryjournal`|
|ReferencedAttribute|`msdyn_inventoryjournalid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_inventoryjournal_adx_portalcomment`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_inventorytransfer_adx_portalcomments"></a> msdyn_inventorytransfer_adx_portalcomments

One-To-Many Relationship: [msdyn_inventorytransfer msdyn_inventorytransfer_adx_portalcomments](msdyn_inventorytransfer.md#BKMK_msdyn_inventorytransfer_adx_portalcomments)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_inventorytransfer`|
|ReferencedAttribute|`msdyn_inventorytransferid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_inventorytransfer_adx_portalcomment`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_payment_adx_portalcomments"></a> msdyn_payment_adx_portalcomments

One-To-Many Relationship: [msdyn_payment msdyn_payment_adx_portalcomments](msdyn_payment.md#BKMK_msdyn_payment_adx_portalcomments)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_payment`|
|ReferencedAttribute|`msdyn_paymentid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_payment_adx_portalcomment`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_paymentdetail_adx_portalcomments"></a> msdyn_paymentdetail_adx_portalcomments

One-To-Many Relationship: [msdyn_paymentdetail msdyn_paymentdetail_adx_portalcomments](msdyn_paymentdetail.md#BKMK_msdyn_paymentdetail_adx_portalcomments)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_paymentdetail`|
|ReferencedAttribute|`msdyn_paymentdetailid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_paymentdetail_adx_portalcomment`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_paymentmethod_adx_portalcomments"></a> msdyn_paymentmethod_adx_portalcomments

One-To-Many Relationship: [msdyn_paymentmethod msdyn_paymentmethod_adx_portalcomments](msdyn_paymentmethod.md#BKMK_msdyn_paymentmethod_adx_portalcomments)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_paymentmethod`|
|ReferencedAttribute|`msdyn_paymentmethodid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_paymentmethod_adx_portalcomment`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_paymentterm_adx_portalcomments"></a> msdyn_paymentterm_adx_portalcomments

One-To-Many Relationship: [msdyn_paymentterm msdyn_paymentterm_adx_portalcomments](msdyn_paymentterm.md#BKMK_msdyn_paymentterm_adx_portalcomments)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_paymentterm`|
|ReferencedAttribute|`msdyn_paymenttermid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_paymentterm_adx_portalcomment`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_playbookinstance_adx_portalcomments"></a> msdyn_playbookinstance_adx_portalcomments

One-To-Many Relationship: [msdyn_playbookinstance msdyn_playbookinstance_adx_portalcomments](msdyn_playbookinstance.md#BKMK_msdyn_playbookinstance_adx_portalcomments)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_playbookinstance`|
|ReferencedAttribute|`msdyn_playbookinstanceid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_playbookinstance_adx_portalcomment`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_postalbum_adx_portalcomments"></a> msdyn_postalbum_adx_portalcomments

One-To-Many Relationship: [msdyn_postalbum msdyn_postalbum_adx_portalcomments](msdyn_postalbum.md#BKMK_msdyn_postalbum_adx_portalcomments)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_postalbum`|
|ReferencedAttribute|`msdyn_postalbumid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_postalbum_adx_portalcomment`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_postalcode_adx_portalcomments"></a> msdyn_postalcode_adx_portalcomments

One-To-Many Relationship: [msdyn_postalcode msdyn_postalcode_adx_portalcomments](msdyn_postalcode.md#BKMK_msdyn_postalcode_adx_portalcomments)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_postalcode`|
|ReferencedAttribute|`msdyn_postalcodeid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_postalcode_adx_portalcomment`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_productinventory_adx_portalcomments"></a> msdyn_productinventory_adx_portalcomments

One-To-Many Relationship: [msdyn_productinventory msdyn_productinventory_adx_portalcomments](msdyn_productinventory.md#BKMK_msdyn_productinventory_adx_portalcomments)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_productinventory`|
|ReferencedAttribute|`msdyn_productinventoryid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_productinventory_adx_portalcomment`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_purchaseorder_adx_portalcomments"></a> msdyn_purchaseorder_adx_portalcomments

One-To-Many Relationship: [msdyn_purchaseorder msdyn_purchaseorder_adx_portalcomments](msdyn_purchaseorder.md#BKMK_msdyn_purchaseorder_adx_portalcomments)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_purchaseorder`|
|ReferencedAttribute|`msdyn_purchaseorderid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_purchaseorder_adx_portalcomment`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_purchaseorderbill_adx_portalcomments"></a> msdyn_purchaseorderbill_adx_portalcomments

One-To-Many Relationship: [msdyn_purchaseorderbill msdyn_purchaseorderbill_adx_portalcomments](msdyn_purchaseorderbill.md#BKMK_msdyn_purchaseorderbill_adx_portalcomments)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_purchaseorderbill`|
|ReferencedAttribute|`msdyn_purchaseorderbillid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_purchaseorderbill_adx_portalcomment`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_purchaseorderproduct_adx_portalcomments"></a> msdyn_purchaseorderproduct_adx_portalcomments

One-To-Many Relationship: [msdyn_purchaseorderproduct msdyn_purchaseorderproduct_adx_portalcomments](msdyn_purchaseorderproduct.md#BKMK_msdyn_purchaseorderproduct_adx_portalcomments)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_purchaseorderproduct`|
|ReferencedAttribute|`msdyn_purchaseorderproductid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_purchaseorderproduct_adx_portalcomment`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_purchaseorderreceipt_adx_portalcomments"></a> msdyn_purchaseorderreceipt_adx_portalcomments

One-To-Many Relationship: [msdyn_purchaseorderreceipt msdyn_purchaseorderreceipt_adx_portalcomments](msdyn_purchaseorderreceipt.md#BKMK_msdyn_purchaseorderreceipt_adx_portalcomments)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_purchaseorderreceipt`|
|ReferencedAttribute|`msdyn_purchaseorderreceiptid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_purchaseorderreceipt_adx_portalcomment`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_purchaseorderreceiptproduct_adx_portalcomments"></a> msdyn_purchaseorderreceiptproduct_adx_portalcomments

One-To-Many Relationship: [msdyn_purchaseorderreceiptproduct msdyn_purchaseorderreceiptproduct_adx_portalcomments](msdyn_purchaseorderreceiptproduct.md#BKMK_msdyn_purchaseorderreceiptproduct_adx_portalcomments)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_purchaseorderreceiptproduct`|
|ReferencedAttribute|`msdyn_purchaseorderreceiptproductid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_purchaseorderreceiptproduct_adx_portalcomment`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_purchaseordersubstatus_adx_portalcomments"></a> msdyn_purchaseordersubstatus_adx_portalcomments

One-To-Many Relationship: [msdyn_purchaseordersubstatus msdyn_purchaseordersubstatus_adx_portalcomments](msdyn_purchaseordersubstatus.md#BKMK_msdyn_purchaseordersubstatus_adx_portalcomments)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_purchaseordersubstatus`|
|ReferencedAttribute|`msdyn_purchaseordersubstatusid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_purchaseordersubstatus_adx_portalcomment`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_quotebookingincident_adx_portalcomments"></a> msdyn_quotebookingincident_adx_portalcomments

One-To-Many Relationship: [msdyn_quotebookingincident msdyn_quotebookingincident_adx_portalcomments](msdyn_quotebookingincident.md#BKMK_msdyn_quotebookingincident_adx_portalcomments)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_quotebookingincident`|
|ReferencedAttribute|`msdyn_quotebookingincidentid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_quotebookingincident_adx_portalcomment`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_quotebookingproduct_adx_portalcomments"></a> msdyn_quotebookingproduct_adx_portalcomments

One-To-Many Relationship: [msdyn_quotebookingproduct msdyn_quotebookingproduct_adx_portalcomments](msdyn_quotebookingproduct.md#BKMK_msdyn_quotebookingproduct_adx_portalcomments)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_quotebookingproduct`|
|ReferencedAttribute|`msdyn_quotebookingproductid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_quotebookingproduct_adx_portalcomment`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_quotebookingservice_adx_portalcomments"></a> msdyn_quotebookingservice_adx_portalcomments

One-To-Many Relationship: [msdyn_quotebookingservice msdyn_quotebookingservice_adx_portalcomments](msdyn_quotebookingservice.md#BKMK_msdyn_quotebookingservice_adx_portalcomments)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_quotebookingservice`|
|ReferencedAttribute|`msdyn_quotebookingserviceid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_quotebookingservice_adx_portalcomment`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_quotebookingservicetask_adx_portalcomments"></a> msdyn_quotebookingservicetask_adx_portalcomments

One-To-Many Relationship: [msdyn_quotebookingservicetask msdyn_quotebookingservicetask_adx_portalcomments](msdyn_quotebookingservicetask.md#BKMK_msdyn_quotebookingservicetask_adx_portalcomments)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_quotebookingservicetask`|
|ReferencedAttribute|`msdyn_quotebookingservicetaskid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_quotebookingservicetask_adx_portalcomment`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_resourceterritory_adx_portalcomments"></a> msdyn_resourceterritory_adx_portalcomments

One-To-Many Relationship: [msdyn_resourceterritory msdyn_resourceterritory_adx_portalcomments](msdyn_resourceterritory.md#BKMK_msdyn_resourceterritory_adx_portalcomments)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_resourceterritory`|
|ReferencedAttribute|`msdyn_resourceterritoryid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_resourceterritory_adx_portalcomment`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_rma_adx_portalcomments"></a> msdyn_rma_adx_portalcomments

One-To-Many Relationship: [msdyn_rma msdyn_rma_adx_portalcomments](msdyn_rma.md#BKMK_msdyn_rma_adx_portalcomments)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_rma`|
|ReferencedAttribute|`msdyn_rmaid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_rma_adx_portalcomment`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_rmaproduct_adx_portalcomments"></a> msdyn_rmaproduct_adx_portalcomments

One-To-Many Relationship: [msdyn_rmaproduct msdyn_rmaproduct_adx_portalcomments](msdyn_rmaproduct.md#BKMK_msdyn_rmaproduct_adx_portalcomments)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_rmaproduct`|
|ReferencedAttribute|`msdyn_rmaproductid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_rmaproduct_adx_portalcomment`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_rmareceipt_adx_portalcomments"></a> msdyn_rmareceipt_adx_portalcomments

One-To-Many Relationship: [msdyn_rmareceipt msdyn_rmareceipt_adx_portalcomments](msdyn_rmareceipt.md#BKMK_msdyn_rmareceipt_adx_portalcomments)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_rmareceipt`|
|ReferencedAttribute|`msdyn_rmareceiptid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_rmareceipt_adx_portalcomment`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_rmareceiptproduct_adx_portalcomments"></a> msdyn_rmareceiptproduct_adx_portalcomments

One-To-Many Relationship: [msdyn_rmareceiptproduct msdyn_rmareceiptproduct_adx_portalcomments](msdyn_rmareceiptproduct.md#BKMK_msdyn_rmareceiptproduct_adx_portalcomments)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_rmareceiptproduct`|
|ReferencedAttribute|`msdyn_rmareceiptproductid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_rmareceiptproduct_adx_portalcomment`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_rmasubstatus_adx_portalcomments"></a> msdyn_rmasubstatus_adx_portalcomments

One-To-Many Relationship: [msdyn_rmasubstatus msdyn_rmasubstatus_adx_portalcomments](msdyn_rmasubstatus.md#BKMK_msdyn_rmasubstatus_adx_portalcomments)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_rmasubstatus`|
|ReferencedAttribute|`msdyn_rmasubstatusid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_rmasubstatus_adx_portalcomment`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_rtv_adx_portalcomments"></a> msdyn_rtv_adx_portalcomments

One-To-Many Relationship: [msdyn_rtv msdyn_rtv_adx_portalcomments](msdyn_rtv.md#BKMK_msdyn_rtv_adx_portalcomments)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_rtv`|
|ReferencedAttribute|`msdyn_rtvid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_rtv_adx_portalcomment`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_rtvproduct_adx_portalcomments"></a> msdyn_rtvproduct_adx_portalcomments

One-To-Many Relationship: [msdyn_rtvproduct msdyn_rtvproduct_adx_portalcomments](msdyn_rtvproduct.md#BKMK_msdyn_rtvproduct_adx_portalcomments)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_rtvproduct`|
|ReferencedAttribute|`msdyn_rtvproductid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_rtvproduct_adx_portalcomment`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_rtvsubstatus_adx_portalcomments"></a> msdyn_rtvsubstatus_adx_portalcomments

One-To-Many Relationship: [msdyn_rtvsubstatus msdyn_rtvsubstatus_adx_portalcomments](msdyn_rtvsubstatus.md#BKMK_msdyn_rtvsubstatus_adx_portalcomments)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_rtvsubstatus`|
|ReferencedAttribute|`msdyn_rtvsubstatusid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_rtvsubstatus_adx_portalcomment`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_salessuggestion_adx_portalcomments"></a> msdyn_salessuggestion_adx_portalcomments

One-To-Many Relationship: [msdyn_salessuggestion msdyn_salessuggestion_adx_portalcomments](msdyn_salessuggestion.md#BKMK_msdyn_salessuggestion_adx_portalcomments)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_salessuggestion`|
|ReferencedAttribute|`msdyn_salessuggestionid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_salessuggestion_adx_portalcomment`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_shipvia_adx_portalcomments"></a> msdyn_shipvia_adx_portalcomments

One-To-Many Relationship: [msdyn_shipvia msdyn_shipvia_adx_portalcomments](msdyn_shipvia.md#BKMK_msdyn_shipvia_adx_portalcomments)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_shipvia`|
|ReferencedAttribute|`msdyn_shipviaid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_shipvia_adx_portalcomment`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_swarm_adx_portalcomments"></a> msdyn_swarm_adx_portalcomments

One-To-Many Relationship: [msdyn_swarm msdyn_swarm_adx_portalcomments](msdyn_swarm.md#BKMK_msdyn_swarm_adx_portalcomments)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_swarm`|
|ReferencedAttribute|`msdyn_swarmid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_swarm_adx_portalcomment`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_systemuserschedulersetting_adx_portalcomments"></a> msdyn_systemuserschedulersetting_adx_portalcomments

One-To-Many Relationship: [msdyn_systemuserschedulersetting msdyn_systemuserschedulersetting_adx_portalcomments](msdyn_systemuserschedulersetting.md#BKMK_msdyn_systemuserschedulersetting_adx_portalcomments)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_systemuserschedulersetting`|
|ReferencedAttribute|`msdyn_systemuserschedulersettingid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_systemuserschedulersetting_adx_portalcomment`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_timegroup_adx_portalcomments"></a> msdyn_timegroup_adx_portalcomments

One-To-Many Relationship: [msdyn_timegroup msdyn_timegroup_adx_portalcomments](msdyn_timegroup.md#BKMK_msdyn_timegroup_adx_portalcomments)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_timegroup`|
|ReferencedAttribute|`msdyn_timegroupid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_timegroup_adx_portalcomment`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_timegroupdetail_adx_portalcomments"></a> msdyn_timegroupdetail_adx_portalcomments

One-To-Many Relationship: [msdyn_timegroupdetail msdyn_timegroupdetail_adx_portalcomments](msdyn_timegroupdetail.md#BKMK_msdyn_timegroupdetail_adx_portalcomments)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_timegroupdetail`|
|ReferencedAttribute|`msdyn_timegroupdetailid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_timegroupdetail_adx_portalcomment`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_timeoffrequest_adx_portalcomments"></a> msdyn_timeoffrequest_adx_portalcomments

One-To-Many Relationship: [msdyn_timeoffrequest msdyn_timeoffrequest_adx_portalcomments](msdyn_timeoffrequest.md#BKMK_msdyn_timeoffrequest_adx_portalcomments)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_timeoffrequest`|
|ReferencedAttribute|`msdyn_timeoffrequestid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_timeoffrequest_adx_portalcomment`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_warehouse_adx_portalcomments"></a> msdyn_warehouse_adx_portalcomments

One-To-Many Relationship: [msdyn_warehouse msdyn_warehouse_adx_portalcomments](msdyn_warehouse.md#BKMK_msdyn_warehouse_adx_portalcomments)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_warehouse`|
|ReferencedAttribute|`msdyn_warehouseid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_warehouse_adx_portalcomment`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_workorder_adx_portalcomments"></a> msdyn_workorder_adx_portalcomments

One-To-Many Relationship: [msdyn_workorder msdyn_workorder_adx_portalcomments](msdyn_workorder.md#BKMK_msdyn_workorder_adx_portalcomments)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_workorder`|
|ReferencedAttribute|`msdyn_workorderid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_workorder_adx_portalcomment`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_workordercharacteristic_adx_portalcomments"></a> msdyn_workordercharacteristic_adx_portalcomments

One-To-Many Relationship: [msdyn_workordercharacteristic msdyn_workordercharacteristic_adx_portalcomments](msdyn_workordercharacteristic.md#BKMK_msdyn_workordercharacteristic_adx_portalcomments)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_workordercharacteristic`|
|ReferencedAttribute|`msdyn_workordercharacteristicid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_workordercharacteristic_adx_portalcomment`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_workorderincident_adx_portalcomments"></a> msdyn_workorderincident_adx_portalcomments

One-To-Many Relationship: [msdyn_workorderincident msdyn_workorderincident_adx_portalcomments](msdyn_workorderincident.md#BKMK_msdyn_workorderincident_adx_portalcomments)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_workorderincident`|
|ReferencedAttribute|`msdyn_workorderincidentid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_workorderincident_adx_portalcomment`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_workorderproduct_adx_portalcomments"></a> msdyn_workorderproduct_adx_portalcomments

One-To-Many Relationship: [msdyn_workorderproduct msdyn_workorderproduct_adx_portalcomments](msdyn_workorderproduct.md#BKMK_msdyn_workorderproduct_adx_portalcomments)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_workorderproduct`|
|ReferencedAttribute|`msdyn_workorderproductid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_workorderproduct_adx_portalcomment`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_workorderresourcerestriction_adx_portalcomments"></a> msdyn_workorderresourcerestriction_adx_portalcomments

One-To-Many Relationship: [msdyn_workorderresourcerestriction msdyn_workorderresourcerestriction_adx_portalcomments](msdyn_workorderresourcerestriction.md#BKMK_msdyn_workorderresourcerestriction_adx_portalcomments)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_workorderresourcerestriction`|
|ReferencedAttribute|`msdyn_workorderresourcerestrictionid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_workorderresourcerestriction_adx_portalcomment`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_workorderservice_adx_portalcomments"></a> msdyn_workorderservice_adx_portalcomments

One-To-Many Relationship: [msdyn_workorderservice msdyn_workorderservice_adx_portalcomments](msdyn_workorderservice.md#BKMK_msdyn_workorderservice_adx_portalcomments)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_workorderservice`|
|ReferencedAttribute|`msdyn_workorderserviceid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_workorderservice_adx_portalcomment`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_workorderservicetask_adx_portalcomments"></a> msdyn_workorderservicetask_adx_portalcomments

One-To-Many Relationship: [msdyn_workorderservicetask msdyn_workorderservicetask_adx_portalcomments](msdyn_workorderservicetask.md#BKMK_msdyn_workorderservicetask_adx_portalcomments)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_workorderservicetask`|
|ReferencedAttribute|`msdyn_workorderservicetaskid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_workorderservicetask_adx_portalcomment`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyncrm_contentsettings_adx_portalcomments"></a> msdyncrm_contentsettings_adx_portalcomments

One-To-Many Relationship: [msdyncrm_contentsettings msdyncrm_contentsettings_adx_portalcomments](msdyncrm_contentsettings.md#BKMK_msdyncrm_contentsettings_adx_portalcomments)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyncrm_contentsettings`|
|ReferencedAttribute|`msdyncrm_contentsettingsid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyncrm_contentsettings_adx_portalcomment`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyncrm_customerjourney_adx_portalcomments"></a> msdyncrm_customerjourney_adx_portalcomments

One-To-Many Relationship: [msdyncrm_customerjourney msdyncrm_customerjourney_adx_portalcomments](msdyncrm_customerjourney.md#BKMK_msdyncrm_customerjourney_adx_portalcomments)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyncrm_customerjourney`|
|ReferencedAttribute|`msdyncrm_customerjourneyid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyncrm_customerjourney_adx_portalcomment`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyncrm_leadscoremodel_adx_portalcomments"></a> msdyncrm_leadscoremodel_adx_portalcomments

One-To-Many Relationship: [msdyncrm_leadscoremodel msdyncrm_leadscoremodel_adx_portalcomments](msdyncrm_leadscoremodel.md#BKMK_msdyncrm_leadscoremodel_adx_portalcomments)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyncrm_leadscoremodel`|
|ReferencedAttribute|`msdyncrm_leadscoremodelid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyncrm_leadscoremodel_adx_portalcomment`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyncrm_linkedinaccount_adx_portalcomments"></a> msdyncrm_linkedinaccount_adx_portalcomments

One-To-Many Relationship: [msdyncrm_linkedinaccount msdyncrm_linkedinaccount_adx_portalcomments](msdyncrm_linkedinaccount.md#BKMK_msdyncrm_linkedinaccount_adx_portalcomments)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyncrm_linkedinaccount`|
|ReferencedAttribute|`msdyncrm_linkedinaccountid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyncrm_linkedinaccount_adx_portalcomment`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyncrm_linkedinactivity_adx_portalcomments"></a> msdyncrm_linkedinactivity_adx_portalcomments

One-To-Many Relationship: [msdyncrm_linkedinactivity msdyncrm_linkedinactivity_adx_portalcomments](msdyncrm_linkedinactivity.md#BKMK_msdyncrm_linkedinactivity_adx_portalcomments)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyncrm_linkedinactivity`|
|ReferencedAttribute|`msdyncrm_linkedinactivityid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyncrm_linkedinactivity_adx_portalcomment`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyncrm_linkedinfieldmapping_adx_portalcomments"></a> msdyncrm_linkedinfieldmapping_adx_portalcomments

One-To-Many Relationship: [msdyncrm_linkedinfieldmapping msdyncrm_linkedinfieldmapping_adx_portalcomments](msdyncrm_linkedinfieldmapping.md#BKMK_msdyncrm_linkedinfieldmapping_adx_portalcomments)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyncrm_linkedinfieldmapping`|
|ReferencedAttribute|`msdyncrm_linkedinfieldmappingid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyncrm_linkedinfieldmapping_adx_portalcomment`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyncrm_linkedinform_adx_portalcomments"></a> msdyncrm_linkedinform_adx_portalcomments

One-To-Many Relationship: [msdyncrm_linkedinform msdyncrm_linkedinform_adx_portalcomments](msdyncrm_linkedinform.md#BKMK_msdyncrm_linkedinform_adx_portalcomments)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyncrm_linkedinform`|
|ReferencedAttribute|`msdyncrm_linkedinformid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyncrm_linkedinform_adx_portalcomment`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyncrm_linkedinformanswer_adx_portalcomments"></a> msdyncrm_linkedinformanswer_adx_portalcomments

One-To-Many Relationship: [msdyncrm_linkedinformanswer msdyncrm_linkedinformanswer_adx_portalcomments](msdyncrm_linkedinformanswer.md#BKMK_msdyncrm_linkedinformanswer_adx_portalcomments)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyncrm_linkedinformanswer`|
|ReferencedAttribute|`msdyncrm_linkedinformanswerid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyncrm_linkedinformanswer_adx_portalcomment`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyncrm_linkedinformquestion_adx_portalcomments"></a> msdyncrm_linkedinformquestion_adx_portalcomments

One-To-Many Relationship: [msdyncrm_linkedinformquestion msdyncrm_linkedinformquestion_adx_portalcomments](msdyncrm_linkedinformquestion.md#BKMK_msdyncrm_linkedinformquestion_adx_portalcomments)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyncrm_linkedinformquestion`|
|ReferencedAttribute|`msdyncrm_linkedinformquestionid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyncrm_linkedinformquestion_adx_portalcomment`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyncrm_linkedinformsubmission_adx_portalcomments"></a> msdyncrm_linkedinformsubmission_adx_portalcomments

One-To-Many Relationship: [msdyncrm_linkedinformsubmission msdyncrm_linkedinformsubmission_adx_portalcomments](msdyncrm_linkedinformsubmission.md#BKMK_msdyncrm_linkedinformsubmission_adx_portalcomments)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyncrm_linkedinformsubmission`|
|ReferencedAttribute|`msdyncrm_linkedinformsubmissionid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyncrm_linkedinformsubmission_adx_portalcomment`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyncrm_linkedinleadmatchingstrategy_adx_portalcomments"></a> msdyncrm_linkedinleadmatchingstrategy_adx_portalcomments

One-To-Many Relationship: [msdyncrm_linkedinleadmatchingstrategy msdyncrm_linkedinleadmatchingstrategy_adx_portalcomments](msdyncrm_linkedinleadmatchingstrategy.md#BKMK_msdyncrm_linkedinleadmatchingstrategy_adx_portalcomments)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyncrm_linkedinleadmatchingstrategy`|
|ReferencedAttribute|`msdyncrm_linkedinleadmatchingstrategyid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyncrm_linkedinleadmatchingstrategy_adx_portalcomment`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyncrm_linkedinuserprofile_adx_portalcomments"></a> msdyncrm_linkedinuserprofile_adx_portalcomments

One-To-Many Relationship: [msdyncrm_linkedinuserprofile msdyncrm_linkedinuserprofile_adx_portalcomments](msdyncrm_linkedinuserprofile.md#BKMK_msdyncrm_linkedinuserprofile_adx_portalcomments)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyncrm_linkedinuserprofile`|
|ReferencedAttribute|`msdyncrm_linkedinuserprofileid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyncrm_linkedinuserprofile_adx_portalcomment`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyncrm_marketingdynamiccontentmetadata_adx_portalcomments"></a> msdyncrm_marketingdynamiccontentmetadata_adx_portalcomments

One-To-Many Relationship: [msdyncrm_marketingdynamiccontentmetadata msdyncrm_marketingdynamiccontentmetadata_adx_portalcomments](msdyncrm_marketingdynamiccontentmetadata.md#BKMK_msdyncrm_marketingdynamiccontentmetadata_adx_portalcomments)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyncrm_marketingdynamiccontentmetadata`|
|ReferencedAttribute|`msdyncrm_marketingdynamiccontentmetadataid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyncrm_marketingdynamiccontentmetadata_adx_portalcomment`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyncrm_marketingemaildynamiccontentmetadata_adx_portalcomments"></a> msdyncrm_marketingemaildynamiccontentmetadata_adx_portalcomments

One-To-Many Relationship: [msdyncrm_marketingemaildynamiccontentmetadata msdyncrm_marketingemaildynamiccontentmetadata_adx_portalcomments](msdyncrm_marketingemaildynamiccontentmetadata.md#BKMK_msdyncrm_marketingemaildynamiccontentmetadata_adx_portalcomments)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyncrm_marketingemaildynamiccontentmetadata`|
|ReferencedAttribute|`msdyncrm_marketingemaildynamiccontentmetadataid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyncrm_marketingemaildynamiccontentmetadata_adx_portalcomment`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyncrm_marketingemailtestsend_adx_portalcomments"></a> msdyncrm_marketingemailtestsend_adx_portalcomments

One-To-Many Relationship: [msdyncrm_marketingemailtestsend msdyncrm_marketingemailtestsend_adx_portalcomments](msdyncrm_marketingemailtestsend.md#BKMK_msdyncrm_marketingemailtestsend_adx_portalcomments)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyncrm_marketingemailtestsend`|
|ReferencedAttribute|`msdyncrm_marketingemailtestsendid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyncrm_marketingemailtestsend_adx_portalcomment`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyncrm_migration_adx_portalcomments"></a> msdyncrm_migration_adx_portalcomments

One-To-Many Relationship: [msdyncrm_migration msdyncrm_migration_adx_portalcomments](msdyncrm_migration.md#BKMK_msdyncrm_migration_adx_portalcomments)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyncrm_migration`|
|ReferencedAttribute|`msdyncrm_migrationid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyncrm_migration_adx_portalcomment`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyncrm_uicconfig_adx_portalcomments"></a> msdyncrm_uicconfig_adx_portalcomments

One-To-Many Relationship: [msdyncrm_uicconfig msdyncrm_uicconfig_adx_portalcomments](msdyncrm_uicconfig.md#BKMK_msdyncrm_uicconfig_adx_portalcomments)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyncrm_uicconfig`|
|ReferencedAttribute|`msdyncrm_uicconfigid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyncrm_uicconfig_adx_portalcomment`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msevtmgt_checkin_adx_portalcomments"></a> msevtmgt_checkin_adx_portalcomments

One-To-Many Relationship: [msevtmgt_checkin msevtmgt_checkin_adx_portalcomments](msevtmgt_checkin.md#BKMK_msevtmgt_checkin_adx_portalcomments)

|Property|Value|
|---|---|
|ReferencedEntity|`msevtmgt_checkin`|
|ReferencedAttribute|`msevtmgt_checkinid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msevtmgt_checkin_adx_portalcomment`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msevtmgt_event_adx_portalcomments"></a> msevtmgt_event_adx_portalcomments

One-To-Many Relationship: [msevtmgt_event msevtmgt_event_adx_portalcomments](msevtmgt_event.md#BKMK_msevtmgt_event_adx_portalcomments)

|Property|Value|
|---|---|
|ReferencedEntity|`msevtmgt_event`|
|ReferencedAttribute|`msevtmgt_eventid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msevtmgt_event_adx_portalcomment`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msevtmgt_eventpurchase_adx_portalcomments"></a> msevtmgt_eventpurchase_adx_portalcomments

One-To-Many Relationship: [msevtmgt_eventpurchase msevtmgt_eventpurchase_adx_portalcomments](msevtmgt_eventpurchase.md#BKMK_msevtmgt_eventpurchase_adx_portalcomments)

|Property|Value|
|---|---|
|ReferencedEntity|`msevtmgt_eventpurchase`|
|ReferencedAttribute|`msevtmgt_eventpurchaseid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msevtmgt_eventpurchase_adx_portalcomment`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msevtmgt_eventpurchaseattendee_adx_portalcomments"></a> msevtmgt_eventpurchaseattendee_adx_portalcomments

One-To-Many Relationship: [msevtmgt_eventpurchaseattendee msevtmgt_eventpurchaseattendee_adx_portalcomments](msevtmgt_eventpurchaseattendee.md#BKMK_msevtmgt_eventpurchaseattendee_adx_portalcomments)

|Property|Value|
|---|---|
|ReferencedEntity|`msevtmgt_eventpurchaseattendee`|
|ReferencedAttribute|`msevtmgt_eventpurchaseattendeeid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msevtmgt_eventpurchaseattendee_adx_portalcomment`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msevtmgt_eventpurchasepass_adx_portalcomments"></a> msevtmgt_eventpurchasepass_adx_portalcomments

One-To-Many Relationship: [msevtmgt_eventpurchasepass msevtmgt_eventpurchasepass_adx_portalcomments](msevtmgt_eventpurchasepass.md#BKMK_msevtmgt_eventpurchasepass_adx_portalcomments)

|Property|Value|
|---|---|
|ReferencedEntity|`msevtmgt_eventpurchasepass`|
|ReferencedAttribute|`msevtmgt_eventpurchasepassid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msevtmgt_eventpurchasepass_adx_portalcomment`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msevtmgt_eventregistration_adx_portalcomments"></a> msevtmgt_eventregistration_adx_portalcomments

One-To-Many Relationship: [msevtmgt_eventregistration msevtmgt_eventregistration_adx_portalcomments](msevtmgt_eventregistration.md#BKMK_msevtmgt_eventregistration_adx_portalcomments)

|Property|Value|
|---|---|
|ReferencedEntity|`msevtmgt_eventregistration`|
|ReferencedAttribute|`msevtmgt_eventregistrationid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msevtmgt_eventregistration_adx_portalcomment`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msevtmgt_hotel_adx_portalcomments"></a> msevtmgt_hotel_adx_portalcomments

One-To-Many Relationship: [msevtmgt_hotel msevtmgt_hotel_adx_portalcomments](msevtmgt_hotel.md#BKMK_msevtmgt_hotel_adx_portalcomments)

|Property|Value|
|---|---|
|ReferencedEntity|`msevtmgt_hotel`|
|ReferencedAttribute|`msevtmgt_hotelid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msevtmgt_hotel_adx_portalcomment`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msevtmgt_hotelroomallocation_adx_portalcomments"></a> msevtmgt_hotelroomallocation_adx_portalcomments

One-To-Many Relationship: [msevtmgt_hotelroomallocation msevtmgt_hotelroomallocation_adx_portalcomments](msevtmgt_hotelroomallocation.md#BKMK_msevtmgt_hotelroomallocation_adx_portalcomments)

|Property|Value|
|---|---|
|ReferencedEntity|`msevtmgt_hotelroomallocation`|
|ReferencedAttribute|`msevtmgt_hotelroomallocationid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msevtmgt_hotelroomallocation_adx_portalcomment`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msevtmgt_hotelroomreservation_adx_portalcomments"></a> msevtmgt_hotelroomreservation_adx_portalcomments

One-To-Many Relationship: [msevtmgt_hotelroomreservation msevtmgt_hotelroomreservation_adx_portalcomments](msevtmgt_hotelroomreservation.md#BKMK_msevtmgt_hotelroomreservation_adx_portalcomments)

|Property|Value|
|---|---|
|ReferencedEntity|`msevtmgt_hotelroomreservation`|
|ReferencedAttribute|`msevtmgt_hotelroomreservationid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msevtmgt_hotelroomreservation_adx_portalcomment`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msevtmgt_layout_adx_portalcomments"></a> msevtmgt_layout_adx_portalcomments

One-To-Many Relationship: [msevtmgt_layout msevtmgt_layout_adx_portalcomments](msevtmgt_layout.md#BKMK_msevtmgt_layout_adx_portalcomments)

|Property|Value|
|---|---|
|ReferencedEntity|`msevtmgt_layout`|
|ReferencedAttribute|`msevtmgt_layoutid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msevtmgt_layout_adx_portalcomment`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msevtmgt_room_adx_portalcomments"></a> msevtmgt_room_adx_portalcomments

One-To-Many Relationship: [msevtmgt_room msevtmgt_room_adx_portalcomments](msevtmgt_room.md#BKMK_msevtmgt_room_adx_portalcomments)

|Property|Value|
|---|---|
|ReferencedEntity|`msevtmgt_room`|
|ReferencedAttribute|`msevtmgt_roomid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msevtmgt_room_adx_portalcomment`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msevtmgt_session_adx_portalcomments"></a> msevtmgt_session_adx_portalcomments

One-To-Many Relationship: [msevtmgt_session msevtmgt_session_adx_portalcomments](msevtmgt_session.md#BKMK_msevtmgt_session_adx_portalcomments)

|Property|Value|
|---|---|
|ReferencedEntity|`msevtmgt_session`|
|ReferencedAttribute|`msevtmgt_sessionid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msevtmgt_session_adx_portalcomment`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msevtmgt_sessionregistration_adx_portalcomments"></a> msevtmgt_sessionregistration_adx_portalcomments

One-To-Many Relationship: [msevtmgt_sessionregistration msevtmgt_sessionregistration_adx_portalcomments](msevtmgt_sessionregistration.md#BKMK_msevtmgt_sessionregistration_adx_portalcomments)

|Property|Value|
|---|---|
|ReferencedEntity|`msevtmgt_sessionregistration`|
|ReferencedAttribute|`msevtmgt_sessionregistrationid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msevtmgt_sessionregistration_adx_portalcomment`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msevtmgt_sessiontrack_adx_portalcomments"></a> msevtmgt_sessiontrack_adx_portalcomments

One-To-Many Relationship: [msevtmgt_sessiontrack msevtmgt_sessiontrack_adx_portalcomments](msevtmgt_sessiontrack.md#BKMK_msevtmgt_sessiontrack_adx_portalcomments)

|Property|Value|
|---|---|
|ReferencedEntity|`msevtmgt_sessiontrack`|
|ReferencedAttribute|`msevtmgt_sessiontrackid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msevtmgt_sessiontrack_adx_portalcomment`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msevtmgt_speaker_adx_portalcomments"></a> msevtmgt_speaker_adx_portalcomments

One-To-Many Relationship: [msevtmgt_speaker msevtmgt_speaker_adx_portalcomments](msevtmgt_speaker.md#BKMK_msevtmgt_speaker_adx_portalcomments)

|Property|Value|
|---|---|
|ReferencedEntity|`msevtmgt_speaker`|
|ReferencedAttribute|`msevtmgt_speakerid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msevtmgt_speaker_adx_portalcomment`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msevtmgt_speakerengagement_adx_portalcomments"></a> msevtmgt_speakerengagement_adx_portalcomments

One-To-Many Relationship: [msevtmgt_speakerengagement msevtmgt_speakerengagement_adx_portalcomments](msevtmgt_speakerengagement.md#BKMK_msevtmgt_speakerengagement_adx_portalcomments)

|Property|Value|
|---|---|
|ReferencedEntity|`msevtmgt_speakerengagement`|
|ReferencedAttribute|`msevtmgt_speakerengagementid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msevtmgt_speakerengagement_adx_portalcomment`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msevtmgt_sponsorablearticle_adx_portalcomments"></a> msevtmgt_sponsorablearticle_adx_portalcomments

One-To-Many Relationship: [msevtmgt_sponsorablearticle msevtmgt_sponsorablearticle_adx_portalcomments](msevtmgt_sponsorablearticle.md#BKMK_msevtmgt_sponsorablearticle_adx_portalcomments)

|Property|Value|
|---|---|
|ReferencedEntity|`msevtmgt_sponsorablearticle`|
|ReferencedAttribute|`msevtmgt_sponsorablearticleid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msevtmgt_sponsorablearticle_adx_portalcomment`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msevtmgt_sponsorship_adx_portalcomments"></a> msevtmgt_sponsorship_adx_portalcomments

One-To-Many Relationship: [msevtmgt_sponsorship msevtmgt_sponsorship_adx_portalcomments](msevtmgt_sponsorship.md#BKMK_msevtmgt_sponsorship_adx_portalcomments)

|Property|Value|
|---|---|
|ReferencedEntity|`msevtmgt_sponsorship`|
|ReferencedAttribute|`msevtmgt_sponsorshipid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msevtmgt_sponsorship_adx_portalcomment`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msevtmgt_venue_adx_portalcomments"></a> msevtmgt_venue_adx_portalcomments

One-To-Many Relationship: [msevtmgt_venue msevtmgt_venue_adx_portalcomments](msevtmgt_venue.md#BKMK_msevtmgt_venue_adx_portalcomments)

|Property|Value|
|---|---|
|ReferencedEntity|`msevtmgt_venue`|
|ReferencedAttribute|`msevtmgt_venueid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msevtmgt_venue_adx_portalcomment`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msevtmgt_webinarconfiguration_adx_portalcomments"></a> msevtmgt_webinarconfiguration_adx_portalcomments

One-To-Many Relationship: [msevtmgt_webinarconfiguration msevtmgt_webinarconfiguration_adx_portalcomments](msevtmgt_webinarconfiguration.md#BKMK_msevtmgt_webinarconfiguration_adx_portalcomments)

|Property|Value|
|---|---|
|ReferencedEntity|`msevtmgt_webinarconfiguration`|
|ReferencedAttribute|`msevtmgt_webinarconfigurationid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msevtmgt_webinarconfiguration_adx_portalcomment`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msevtmgt_webinarprovider_adx_portalcomments"></a> msevtmgt_webinarprovider_adx_portalcomments

One-To-Many Relationship: [msevtmgt_webinarprovider msevtmgt_webinarprovider_adx_portalcomments](msevtmgt_webinarprovider.md#BKMK_msevtmgt_webinarprovider_adx_portalcomments)

|Property|Value|
|---|---|
|ReferencedEntity|`msevtmgt_webinarprovider`|
|ReferencedAttribute|`msevtmgt_webinarproviderid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msevtmgt_webinarprovider_adx_portalcomment`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_opportunity_adx_portalcomments"></a> opportunity_adx_portalcomments

One-To-Many Relationship: [opportunity opportunity_adx_portalcomments](opportunity.md#BKMK_opportunity_adx_portalcomments)

|Property|Value|
|---|---|
|ReferencedEntity|`opportunity`|
|ReferencedAttribute|`opportunityid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_opportunity_adx_portalcomment`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_quote_adx_portalcomments"></a> quote_adx_portalcomments

One-To-Many Relationship: [quote quote_adx_portalcomments](quote.md#BKMK_quote_adx_portalcomments)

|Property|Value|
|---|---|
|ReferencedEntity|`quote`|
|ReferencedAttribute|`quoteid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_quote_adx_portalcomment`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_salesorder_adx_portalcomments"></a> salesorder_adx_portalcomments

One-To-Many Relationship: [salesorder salesorder_adx_portalcomments](salesorder.md#BKMK_salesorder_adx_portalcomments)

|Property|Value|
|---|---|
|ReferencedEntity|`salesorder`|
|ReferencedAttribute|`salesorderid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_salesorder_adx_portalcomment`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_service_adx_portalcomments"></a> service_adx_portalcomments

One-To-Many Relationship: [service service_adx_portalcomments](service.md#BKMK_service_adx_portalcomments)

|Property|Value|
|---|---|
|ReferencedEntity|`service`|
|ReferencedAttribute|`serviceid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_service_adx_portalcomment`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_site_adx_portalcomments"></a> site_adx_portalcomments

One-To-Many Relationship: [site site_adx_portalcomments](site.md#BKMK_site_adx_portalcomments)

|Property|Value|
|---|---|
|ReferencedEntity|`site`|
|ReferencedAttribute|`siteid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_site_adx_portalcomment`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|


## One-to-Many relationships

These relationships are one-to-many. Listed by **SchemaName**.

### <a name="BKMK_CampaignResponse_adx_portalcomments"></a> CampaignResponse_adx_portalcomments

Many-To-One Relationship: [campaignresponse CampaignResponse_adx_portalcomments](campaignresponse.md#BKMK_CampaignResponse_adx_portalcomments)

|Property|Value|
|---|---|
|ReferencingEntity|`campaignresponse`|
|ReferencingAttribute|`originatingactivityid`|
|ReferencedEntityNavigationPropertyName|`CampaignResponse_adx_portalcomments`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|



### See also

[Dataverse table/entity reference](../about-entity-reference.md)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   
<xref:Microsoft.Dynamics.CRM.adx_portalcomment?displayProperty=fullName>
