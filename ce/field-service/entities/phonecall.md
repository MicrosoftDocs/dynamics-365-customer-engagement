---
title: "Phone Call (PhoneCall) table/entity reference (Microsoft Dynamics 365 Field Service)"
description: "Includes schema information and supported messages for the Phone Call (PhoneCall) table/entity with Microsoft Dynamics 365 Field Service."
ms.date: 07.24.2024
ms.service: powerapps
ms.topic: reference
author: m-hartmann
ms.author: mhart
search.audienceType: 
  - developer
---

# Phone Call (PhoneCall) table/entity reference

Activity to track a telephone call.

> [!NOTE]
> The Microsoft Dynamics 365 Field Service Phone Call (PhoneCall) table extends the [Microsoft Dataverse Phone Call (PhoneCall) table](/power-apps/developer/data-platform/reference/entities/phonecall).



## Writable columns/attributes

These columns/attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [msdyn_ActualDurationSeconds](#BKMK_msdyn_ActualDurationSeconds)
- [msdyn_City](#BKMK_msdyn_City)
- [msdyn_ClientType](#BKMK_msdyn_ClientType)
- [msdyn_Country](#BKMK_msdyn_Country)
- [msdyn_Latitude](#BKMK_msdyn_Latitude)
- [msdyn_Longitude](#BKMK_msdyn_Longitude)
- [msdyn_RemoteAssistCallId](#BKMK_msdyn_RemoteAssistCallId)
- [msdyn_StateOrProvince](#BKMK_msdyn_StateOrProvince)
- [msdyncrm_ActivityId](#BKMK_msdyncrm_ActivityId)
- [msdyncrm_associatedcustomerjourneyiteration](#BKMK_msdyncrm_associatedcustomerjourneyiteration)
- [msdynmkt_JourneyActionId](#BKMK_msdynmkt_JourneyActionId)
- [msdynmkt_JourneyId](#BKMK_msdynmkt_JourneyId)
- [ServiceId](#BKMK_ServiceId)

### <a name="BKMK_msdyn_ActualDurationSeconds"></a> msdyn_ActualDurationSeconds

|Property|Value|
|---|---|
|Description|**Number of seconds spent on the call**|
|DisplayName|**Actual Duration Seconds**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_actualdurationseconds`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|0|

### <a name="BKMK_msdyn_City"></a> msdyn_City

|Property|Value|
|---|---|
|Description|**Client location (city)**|
|DisplayName|**City**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_city`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|250|

### <a name="BKMK_msdyn_ClientType"></a> msdyn_ClientType

|Property|Value|
|---|---|
|Description|**Type of Guides client**|
|DisplayName|**Client Type**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_clienttype`|
|RequiredLevel|None|
|Type|Picklist|
|DefaultFormValue|-1|
|GlobalChoiceName|`msdyn_clienttype`|

#### msdyn_ClientType Choices/Options

|Value|Label|
|---|---|
|700610000|**HoloLens 1**|
|700610001|**HoloLens 2**|
|700610002|**Android**|
|700610003|**iOS**|

### <a name="BKMK_msdyn_Country"></a> msdyn_Country

|Property|Value|
|---|---|
|Description|**Client location (country/region)**|
|DisplayName|**Country/Region**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_country`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|250|

### <a name="BKMK_msdyn_Latitude"></a> msdyn_Latitude

|Property|Value|
|---|---|
|Description|**Client location (latitude)**|
|DisplayName|**Latitude**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_latitude`|
|RequiredLevel|None|
|Type|Double|
|ImeMode|Disabled|
|MaxValue|90|
|MinValue|-90|
|Precision|5|

### <a name="BKMK_msdyn_Longitude"></a> msdyn_Longitude

|Property|Value|
|---|---|
|Description|**Client location (longitude)**|
|DisplayName|**Longitude**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_longitude`|
|RequiredLevel|None|
|Type|Double|
|ImeMode|Disabled|
|MaxValue|180|
|MinValue|-180|
|Precision|5|

### <a name="BKMK_msdyn_RemoteAssistCallId"></a> msdyn_RemoteAssistCallId

|Property|Value|
|---|---|
|Description|**Guides Call Id associated with the unique call**|
|DisplayName|**Call Id**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_remoteassistcallid`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdyn_StateOrProvince"></a> msdyn_StateOrProvince

|Property|Value|
|---|---|
|Description|**Client location (state or province)**|
|DisplayName|**StateOrProvince**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_stateorprovince`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|250|

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
|Description|**The Journey action id in which the phonecall is created.**|
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
|Description|**The journey id in which the phonecall is created**|
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

- [ActualDurationMinutes](#BKMK_ActualDurationMinutes)
- [from](#BKMK_from)
- [RegardingObjectId](#BKMK_RegardingObjectId)
- [to](#BKMK_to)

### <a name="BKMK_ActualDurationMinutes"></a> ActualDurationMinutes

Changes from [ActualDurationMinutes (Microsoft Dataverse)](/power-apps/developer/data-platform/reference/entities/phonecall#BKMK_ActualDurationMinutes)

|Property|Value|
|---|---|
|DisplayName|**Actual Duration Minutes**|


### <a name="BKMK_from"></a> from

Changes from [from (Microsoft Dataverse)](/power-apps/developer/data-platform/reference/entities/phonecall#BKMK_from)

|Property|Value|
|---|---|
|Targets|lead|


### <a name="BKMK_RegardingObjectId"></a> RegardingObjectId

Changes from [RegardingObjectId (Microsoft Dataverse)](/power-apps/developer/data-platform/reference/entities/phonecall#BKMK_RegardingObjectId)

|Property|Value|
|---|---|
|Targets|adx_ad|


### <a name="BKMK_to"></a> to

Changes from [to (Microsoft Dataverse)](/power-apps/developer/data-platform/reference/entities/phonecall#BKMK_to)

|Property|Value|
|---|---|
|Targets|lead|


## Many-to-One relationships

These relationships are many-to-one. Listed by **SchemaName**.

- [adx_ad_PhoneCalls](#BKMK_adx_ad_PhoneCalls)
- [adx_adplacement_PhoneCalls](#BKMK_adx_adplacement_PhoneCalls)
- [adx_casedeflection_PhoneCalls](#BKMK_adx_casedeflection_PhoneCalls)
- [adx_communityforumaccesspermission_PhoneCalls](#BKMK_adx_communityforumaccesspermission_PhoneCalls)
- [adx_communityforumalert_PhoneCalls](#BKMK_adx_communityforumalert_PhoneCalls)
- [adx_contentaccesslevel_PhoneCalls](#BKMK_adx_contentaccesslevel_PhoneCalls)
- [adx_poll_PhoneCalls](#BKMK_adx_poll_PhoneCalls)
- [adx_polloption_PhoneCalls](#BKMK_adx_polloption_PhoneCalls)
- [adx_pollplacement_PhoneCalls](#BKMK_adx_pollplacement_PhoneCalls)
- [adx_pollsubmission_PhoneCalls](#BKMK_adx_pollsubmission_PhoneCalls)
- [adx_publishingstatetransitionrule_PhoneCalls](#BKMK_adx_publishingstatetransitionrule_PhoneCalls)
- [adx_redirect_PhoneCalls](#BKMK_adx_redirect_PhoneCalls)
- [adx_shortcut_PhoneCalls](#BKMK_adx_shortcut_PhoneCalls)
- [adx_webpage_PhoneCalls](#BKMK_adx_webpage_PhoneCalls)
- [adx_website_PhoneCalls](#BKMK_adx_website_PhoneCalls)
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
- [msdyn_agreement_PhoneCalls](#BKMK_msdyn_agreement_PhoneCalls)
- [msdyn_agreementbookingdate_PhoneCalls](#BKMK_msdyn_agreementbookingdate_PhoneCalls)
- [msdyn_agreementbookingincident_PhoneCalls](#BKMK_msdyn_agreementbookingincident_PhoneCalls)
- [msdyn_agreementbookingproduct_PhoneCalls](#BKMK_msdyn_agreementbookingproduct_PhoneCalls)
- [msdyn_agreementbookingservice_PhoneCalls](#BKMK_msdyn_agreementbookingservice_PhoneCalls)
- [msdyn_agreementbookingservicetask_PhoneCalls](#BKMK_msdyn_agreementbookingservicetask_PhoneCalls)
- [msdyn_agreementbookingsetup_PhoneCalls](#BKMK_msdyn_agreementbookingsetup_PhoneCalls)
- [msdyn_agreementinvoicedate_PhoneCalls](#BKMK_msdyn_agreementinvoicedate_PhoneCalls)
- [msdyn_agreementinvoiceproduct_PhoneCalls](#BKMK_msdyn_agreementinvoiceproduct_PhoneCalls)
- [msdyn_agreementinvoicesetup_PhoneCalls](#BKMK_msdyn_agreementinvoicesetup_PhoneCalls)
- [msdyn_bookingalertstatus_PhoneCalls](#BKMK_msdyn_bookingalertstatus_PhoneCalls)
- [msdyn_bookingrule_PhoneCalls](#BKMK_msdyn_bookingrule_PhoneCalls)
- [msdyn_bookingtimestamp_PhoneCalls](#BKMK_msdyn_bookingtimestamp_PhoneCalls)
- [msdyn_customerasset_PhoneCalls](#BKMK_msdyn_customerasset_PhoneCalls)
- [msdyn_fieldservicesetting_PhoneCalls](#BKMK_msdyn_fieldservicesetting_PhoneCalls)
- [msdyn_incidenttypecharacteristic_PhoneCalls](#BKMK_msdyn_incidenttypecharacteristic_PhoneCalls)
- [msdyn_incidenttypeproduct_PhoneCalls](#BKMK_msdyn_incidenttypeproduct_PhoneCalls)
- [msdyn_incidenttypeservice_PhoneCalls](#BKMK_msdyn_incidenttypeservice_PhoneCalls)
- [msdyn_inventoryadjustment_PhoneCalls](#BKMK_msdyn_inventoryadjustment_PhoneCalls)
- [msdyn_inventoryadjustmentproduct_PhoneCalls](#BKMK_msdyn_inventoryadjustmentproduct_PhoneCalls)
- [msdyn_inventoryjournal_PhoneCalls](#BKMK_msdyn_inventoryjournal_PhoneCalls)
- [msdyn_inventorytransfer_PhoneCalls](#BKMK_msdyn_inventorytransfer_PhoneCalls)
- [msdyn_payment_PhoneCalls](#BKMK_msdyn_payment_PhoneCalls)
- [msdyn_paymentdetail_PhoneCalls](#BKMK_msdyn_paymentdetail_PhoneCalls)
- [msdyn_paymentmethod_PhoneCalls](#BKMK_msdyn_paymentmethod_PhoneCalls)
- [msdyn_paymentterm_PhoneCalls](#BKMK_msdyn_paymentterm_PhoneCalls)
- [msdyn_playbookinstance_PhoneCalls](#BKMK_msdyn_playbookinstance_PhoneCalls)
- [msdyn_postalbum_PhoneCalls](#BKMK_msdyn_postalbum_PhoneCalls)
- [msdyn_postalcode_PhoneCalls](#BKMK_msdyn_postalcode_PhoneCalls)
- [msdyn_productinventory_PhoneCalls](#BKMK_msdyn_productinventory_PhoneCalls)
- [msdyn_purchaseorder_PhoneCalls](#BKMK_msdyn_purchaseorder_PhoneCalls)
- [msdyn_purchaseorderbill_PhoneCalls](#BKMK_msdyn_purchaseorderbill_PhoneCalls)
- [msdyn_purchaseorderproduct_PhoneCalls](#BKMK_msdyn_purchaseorderproduct_PhoneCalls)
- [msdyn_purchaseorderreceipt_PhoneCalls](#BKMK_msdyn_purchaseorderreceipt_PhoneCalls)
- [msdyn_purchaseorderreceiptproduct_PhoneCalls](#BKMK_msdyn_purchaseorderreceiptproduct_PhoneCalls)
- [msdyn_purchaseordersubstatus_PhoneCalls](#BKMK_msdyn_purchaseordersubstatus_PhoneCalls)
- [msdyn_quotebookingincident_PhoneCalls](#BKMK_msdyn_quotebookingincident_PhoneCalls)
- [msdyn_quotebookingproduct_PhoneCalls](#BKMK_msdyn_quotebookingproduct_PhoneCalls)
- [msdyn_quotebookingservice_PhoneCalls](#BKMK_msdyn_quotebookingservice_PhoneCalls)
- [msdyn_quotebookingservicetask_PhoneCalls](#BKMK_msdyn_quotebookingservicetask_PhoneCalls)
- [msdyn_resourceterritory_PhoneCalls](#BKMK_msdyn_resourceterritory_PhoneCalls)
- [msdyn_rma_PhoneCalls](#BKMK_msdyn_rma_PhoneCalls)
- [msdyn_rmaproduct_PhoneCalls](#BKMK_msdyn_rmaproduct_PhoneCalls)
- [msdyn_rmareceipt_PhoneCalls](#BKMK_msdyn_rmareceipt_PhoneCalls)
- [msdyn_rmareceiptproduct_PhoneCalls](#BKMK_msdyn_rmareceiptproduct_PhoneCalls)
- [msdyn_rmasubstatus_PhoneCalls](#BKMK_msdyn_rmasubstatus_PhoneCalls)
- [msdyn_rtv_PhoneCalls](#BKMK_msdyn_rtv_PhoneCalls)
- [msdyn_rtvproduct_PhoneCalls](#BKMK_msdyn_rtvproduct_PhoneCalls)
- [msdyn_rtvsubstatus_PhoneCalls](#BKMK_msdyn_rtvsubstatus_PhoneCalls)
- [msdyn_salessuggestion_PhoneCalls](#BKMK_msdyn_salessuggestion_PhoneCalls)
- [msdyn_shipvia_PhoneCalls](#BKMK_msdyn_shipvia_PhoneCalls)
- [msdyn_swarm_PhoneCalls](#BKMK_msdyn_swarm_PhoneCalls)
- [msdyn_systemuserschedulersetting_PhoneCalls](#BKMK_msdyn_systemuserschedulersetting_PhoneCalls)
- [msdyn_timegroup_PhoneCalls](#BKMK_msdyn_timegroup_PhoneCalls)
- [msdyn_timegroupdetail_PhoneCalls](#BKMK_msdyn_timegroupdetail_PhoneCalls)
- [msdyn_timeoffrequest_PhoneCalls](#BKMK_msdyn_timeoffrequest_PhoneCalls)
- [msdyn_warehouse_PhoneCalls](#BKMK_msdyn_warehouse_PhoneCalls)
- [msdyn_workorder_PhoneCalls](#BKMK_msdyn_workorder_PhoneCalls)
- [msdyn_workordercharacteristic_PhoneCalls](#BKMK_msdyn_workordercharacteristic_PhoneCalls)
- [msdyn_workorderincident_PhoneCalls](#BKMK_msdyn_workorderincident_PhoneCalls)
- [msdyn_workorderproduct_PhoneCalls](#BKMK_msdyn_workorderproduct_PhoneCalls)
- [msdyn_workorderresourcerestriction_PhoneCalls](#BKMK_msdyn_workorderresourcerestriction_PhoneCalls)
- [msdyn_workorderservice_PhoneCalls](#BKMK_msdyn_workorderservice_PhoneCalls)
- [msdyn_workorderservicetask_PhoneCalls](#BKMK_msdyn_workorderservicetask_PhoneCalls)
- [msdyncrm_contentsettings_PhoneCalls](#BKMK_msdyncrm_contentsettings_PhoneCalls)
- [msdyncrm_customerjourney_PhoneCalls](#BKMK_msdyncrm_customerjourney_PhoneCalls)
- [msdyncrm_leadscoremodel_PhoneCalls](#BKMK_msdyncrm_leadscoremodel_PhoneCalls)
- [msdyncrm_linkedinaccount_PhoneCalls](#BKMK_msdyncrm_linkedinaccount_PhoneCalls)
- [msdyncrm_linkedinactivity_PhoneCalls](#BKMK_msdyncrm_linkedinactivity_PhoneCalls)
- [msdyncrm_linkedinfieldmapping_PhoneCalls](#BKMK_msdyncrm_linkedinfieldmapping_PhoneCalls)
- [msdyncrm_linkedinform_PhoneCalls](#BKMK_msdyncrm_linkedinform_PhoneCalls)
- [msdyncrm_linkedinformanswer_PhoneCalls](#BKMK_msdyncrm_linkedinformanswer_PhoneCalls)
- [msdyncrm_linkedinformquestion_PhoneCalls](#BKMK_msdyncrm_linkedinformquestion_PhoneCalls)
- [msdyncrm_linkedinformsubmission_PhoneCalls](#BKMK_msdyncrm_linkedinformsubmission_PhoneCalls)
- [msdyncrm_linkedinleadmatchingstrategy_PhoneCalls](#BKMK_msdyncrm_linkedinleadmatchingstrategy_PhoneCalls)
- [msdyncrm_linkedinuserprofile_PhoneCalls](#BKMK_msdyncrm_linkedinuserprofile_PhoneCalls)
- [msdyncrm_marketingdynamiccontentmetadata_PhoneCalls](#BKMK_msdyncrm_marketingdynamiccontentmetadata_PhoneCalls)
- [msdyncrm_marketingemaildynamiccontentmetadata_PhoneCalls](#BKMK_msdyncrm_marketingemaildynamiccontentmetadata_PhoneCalls)
- [msdyncrm_marketingemailtestsend_PhoneCalls](#BKMK_msdyncrm_marketingemailtestsend_PhoneCalls)
- [msdyncrm_migration_PhoneCalls](#BKMK_msdyncrm_migration_PhoneCalls)
- [msdyncrm_msdyncrm_customerjourneyiteration_phonecall](#BKMK_msdyncrm_msdyncrm_customerjourneyiteration_phonecall)
- [msdyncrm_uicconfig_PhoneCalls](#BKMK_msdyncrm_uicconfig_PhoneCalls)
- [msdynmkt_phonecall_JourneyId_msdynmkt_journey](#BKMK_msdynmkt_phonecall_JourneyId_msdynmkt_journey)
- [msevtmgt_checkin_PhoneCalls](#BKMK_msevtmgt_checkin_PhoneCalls)
- [msevtmgt_event_PhoneCalls](#BKMK_msevtmgt_event_PhoneCalls)
- [msevtmgt_eventpurchase_PhoneCalls](#BKMK_msevtmgt_eventpurchase_PhoneCalls)
- [msevtmgt_eventpurchaseattendee_PhoneCalls](#BKMK_msevtmgt_eventpurchaseattendee_PhoneCalls)
- [msevtmgt_eventpurchasepass_PhoneCalls](#BKMK_msevtmgt_eventpurchasepass_PhoneCalls)
- [msevtmgt_eventregistration_PhoneCalls](#BKMK_msevtmgt_eventregistration_PhoneCalls)
- [msevtmgt_hotel_PhoneCalls](#BKMK_msevtmgt_hotel_PhoneCalls)
- [msevtmgt_hotelroomallocation_PhoneCalls](#BKMK_msevtmgt_hotelroomallocation_PhoneCalls)
- [msevtmgt_hotelroomreservation_PhoneCalls](#BKMK_msevtmgt_hotelroomreservation_PhoneCalls)
- [msevtmgt_layout_PhoneCalls](#BKMK_msevtmgt_layout_PhoneCalls)
- [msevtmgt_room_PhoneCalls](#BKMK_msevtmgt_room_PhoneCalls)
- [msevtmgt_session_PhoneCalls](#BKMK_msevtmgt_session_PhoneCalls)
- [msevtmgt_sessionregistration_PhoneCalls](#BKMK_msevtmgt_sessionregistration_PhoneCalls)
- [msevtmgt_sessiontrack_PhoneCalls](#BKMK_msevtmgt_sessiontrack_PhoneCalls)
- [msevtmgt_speaker_PhoneCalls](#BKMK_msevtmgt_speaker_PhoneCalls)
- [msevtmgt_speakerengagement_PhoneCalls](#BKMK_msevtmgt_speakerengagement_PhoneCalls)
- [msevtmgt_sponsorablearticle_PhoneCalls](#BKMK_msevtmgt_sponsorablearticle_PhoneCalls)
- [msevtmgt_sponsorship_PhoneCalls](#BKMK_msevtmgt_sponsorship_PhoneCalls)
- [msevtmgt_venue_PhoneCalls](#BKMK_msevtmgt_venue_PhoneCalls)
- [msevtmgt_webinarconfiguration_PhoneCalls](#BKMK_msevtmgt_webinarconfiguration_PhoneCalls)
- [msevtmgt_webinarprovider_PhoneCalls](#BKMK_msevtmgt_webinarprovider_PhoneCalls)
- [Opportunity_Phonecalls](#BKMK_Opportunity_Phonecalls)
- [Quote_Phonecalls](#BKMK_Quote_Phonecalls)
- [SalesOrder_Phonecalls](#BKMK_SalesOrder_Phonecalls)
- [service_phonecalls](#BKMK_service_phonecalls)
- [site_PhoneCalls](#BKMK_site_PhoneCalls)

### <a name="BKMK_adx_ad_PhoneCalls"></a> adx_ad_PhoneCalls

One-To-Many Relationship: [adx_ad adx_ad_PhoneCalls](adx_ad.md#BKMK_adx_ad_PhoneCalls)

|Property|Value|
|---|---|
|ReferencedEntity|`adx_ad`|
|ReferencedAttribute|`adx_adid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_adx_ad_phonecall`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_adx_adplacement_PhoneCalls"></a> adx_adplacement_PhoneCalls

One-To-Many Relationship: [adx_adplacement adx_adplacement_PhoneCalls](adx_adplacement.md#BKMK_adx_adplacement_PhoneCalls)

|Property|Value|
|---|---|
|ReferencedEntity|`adx_adplacement`|
|ReferencedAttribute|`adx_adplacementid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_adx_adplacement_phonecall`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_adx_casedeflection_PhoneCalls"></a> adx_casedeflection_PhoneCalls

One-To-Many Relationship: [adx_casedeflection adx_casedeflection_PhoneCalls](adx_casedeflection.md#BKMK_adx_casedeflection_PhoneCalls)

|Property|Value|
|---|---|
|ReferencedEntity|`adx_casedeflection`|
|ReferencedAttribute|`adx_casedeflectionid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_adx_casedeflection_phonecall`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_adx_communityforumaccesspermission_PhoneCalls"></a> adx_communityforumaccesspermission_PhoneCalls

One-To-Many Relationship: [adx_communityforumaccesspermission adx_communityforumaccesspermission_PhoneCalls](adx_communityforumaccesspermission.md#BKMK_adx_communityforumaccesspermission_PhoneCalls)

|Property|Value|
|---|---|
|ReferencedEntity|`adx_communityforumaccesspermission`|
|ReferencedAttribute|`adx_communityforumaccesspermissionid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_adx_communityforumaccesspermission_phonecall`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_adx_communityforumalert_PhoneCalls"></a> adx_communityforumalert_PhoneCalls

One-To-Many Relationship: [adx_communityforumalert adx_communityforumalert_PhoneCalls](adx_communityforumalert.md#BKMK_adx_communityforumalert_PhoneCalls)

|Property|Value|
|---|---|
|ReferencedEntity|`adx_communityforumalert`|
|ReferencedAttribute|`adx_communityforumalertid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_adx_communityforumalert_phonecall`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_adx_contentaccesslevel_PhoneCalls"></a> adx_contentaccesslevel_PhoneCalls

One-To-Many Relationship: [adx_contentaccesslevel adx_contentaccesslevel_PhoneCalls](adx_contentaccesslevel.md#BKMK_adx_contentaccesslevel_PhoneCalls)

|Property|Value|
|---|---|
|ReferencedEntity|`adx_contentaccesslevel`|
|ReferencedAttribute|`adx_contentaccesslevelid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_adx_contentaccesslevel_phonecall`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_adx_poll_PhoneCalls"></a> adx_poll_PhoneCalls

One-To-Many Relationship: [adx_poll adx_poll_PhoneCalls](adx_poll.md#BKMK_adx_poll_PhoneCalls)

|Property|Value|
|---|---|
|ReferencedEntity|`adx_poll`|
|ReferencedAttribute|`adx_pollid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_adx_poll_phonecall`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_adx_polloption_PhoneCalls"></a> adx_polloption_PhoneCalls

One-To-Many Relationship: [adx_polloption adx_polloption_PhoneCalls](adx_polloption.md#BKMK_adx_polloption_PhoneCalls)

|Property|Value|
|---|---|
|ReferencedEntity|`adx_polloption`|
|ReferencedAttribute|`adx_polloptionid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_adx_polloption_phonecall`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_adx_pollplacement_PhoneCalls"></a> adx_pollplacement_PhoneCalls

One-To-Many Relationship: [adx_pollplacement adx_pollplacement_PhoneCalls](adx_pollplacement.md#BKMK_adx_pollplacement_PhoneCalls)

|Property|Value|
|---|---|
|ReferencedEntity|`adx_pollplacement`|
|ReferencedAttribute|`adx_pollplacementid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_adx_pollplacement_phonecall`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_adx_pollsubmission_PhoneCalls"></a> adx_pollsubmission_PhoneCalls

One-To-Many Relationship: [adx_pollsubmission adx_pollsubmission_PhoneCalls](adx_pollsubmission.md#BKMK_adx_pollsubmission_PhoneCalls)

|Property|Value|
|---|---|
|ReferencedEntity|`adx_pollsubmission`|
|ReferencedAttribute|`adx_pollsubmissionid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_adx_pollsubmission_phonecall`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_adx_publishingstatetransitionrule_PhoneCalls"></a> adx_publishingstatetransitionrule_PhoneCalls

One-To-Many Relationship: [adx_publishingstatetransitionrule adx_publishingstatetransitionrule_PhoneCalls](adx_publishingstatetransitionrule.md#BKMK_adx_publishingstatetransitionrule_PhoneCalls)

|Property|Value|
|---|---|
|ReferencedEntity|`adx_publishingstatetransitionrule`|
|ReferencedAttribute|`adx_publishingstatetransitionruleid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_adx_publishingstatetransitionrule_phonecall`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_adx_redirect_PhoneCalls"></a> adx_redirect_PhoneCalls

One-To-Many Relationship: [adx_redirect adx_redirect_PhoneCalls](adx_redirect.md#BKMK_adx_redirect_PhoneCalls)

|Property|Value|
|---|---|
|ReferencedEntity|`adx_redirect`|
|ReferencedAttribute|`adx_redirectid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_adx_redirect_phonecall`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_adx_shortcut_PhoneCalls"></a> adx_shortcut_PhoneCalls

One-To-Many Relationship: [adx_shortcut adx_shortcut_PhoneCalls](adx_shortcut.md#BKMK_adx_shortcut_PhoneCalls)

|Property|Value|
|---|---|
|ReferencedEntity|`adx_shortcut`|
|ReferencedAttribute|`adx_shortcutid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_adx_shortcut_phonecall`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_adx_webpage_PhoneCalls"></a> adx_webpage_PhoneCalls

One-To-Many Relationship: [adx_webpage adx_webpage_PhoneCalls](adx_webpage.md#BKMK_adx_webpage_PhoneCalls)

|Property|Value|
|---|---|
|ReferencedEntity|`adx_webpage`|
|ReferencedAttribute|`adx_webpageid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_adx_webpage_phonecall`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_adx_website_PhoneCalls"></a> adx_website_PhoneCalls

One-To-Many Relationship: [adx_website adx_website_PhoneCalls](adx_website.md#BKMK_adx_website_PhoneCalls)

|Property|Value|
|---|---|
|ReferencedEntity|`adx_website`|
|ReferencedAttribute|`adx_websiteid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_adx_website_phonecall`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

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

### <a name="BKMK_msdyn_agreement_PhoneCalls"></a> msdyn_agreement_PhoneCalls

One-To-Many Relationship: [msdyn_agreement msdyn_agreement_PhoneCalls](msdyn_agreement.md#BKMK_msdyn_agreement_PhoneCalls)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_agreement`|
|ReferencedAttribute|`msdyn_agreementid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_agreement_phonecall`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_agreementbookingdate_PhoneCalls"></a> msdyn_agreementbookingdate_PhoneCalls

One-To-Many Relationship: [msdyn_agreementbookingdate msdyn_agreementbookingdate_PhoneCalls](msdyn_agreementbookingdate.md#BKMK_msdyn_agreementbookingdate_PhoneCalls)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_agreementbookingdate`|
|ReferencedAttribute|`msdyn_agreementbookingdateid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_agreementbookingdate_phonecall`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_agreementbookingincident_PhoneCalls"></a> msdyn_agreementbookingincident_PhoneCalls

One-To-Many Relationship: [msdyn_agreementbookingincident msdyn_agreementbookingincident_PhoneCalls](msdyn_agreementbookingincident.md#BKMK_msdyn_agreementbookingincident_PhoneCalls)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_agreementbookingincident`|
|ReferencedAttribute|`msdyn_agreementbookingincidentid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_agreementbookingincident_phonecall`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_agreementbookingproduct_PhoneCalls"></a> msdyn_agreementbookingproduct_PhoneCalls

One-To-Many Relationship: [msdyn_agreementbookingproduct msdyn_agreementbookingproduct_PhoneCalls](msdyn_agreementbookingproduct.md#BKMK_msdyn_agreementbookingproduct_PhoneCalls)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_agreementbookingproduct`|
|ReferencedAttribute|`msdyn_agreementbookingproductid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_agreementbookingproduct_phonecall`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_agreementbookingservice_PhoneCalls"></a> msdyn_agreementbookingservice_PhoneCalls

One-To-Many Relationship: [msdyn_agreementbookingservice msdyn_agreementbookingservice_PhoneCalls](msdyn_agreementbookingservice.md#BKMK_msdyn_agreementbookingservice_PhoneCalls)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_agreementbookingservice`|
|ReferencedAttribute|`msdyn_agreementbookingserviceid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_agreementbookingservice_phonecall`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_agreementbookingservicetask_PhoneCalls"></a> msdyn_agreementbookingservicetask_PhoneCalls

One-To-Many Relationship: [msdyn_agreementbookingservicetask msdyn_agreementbookingservicetask_PhoneCalls](msdyn_agreementbookingservicetask.md#BKMK_msdyn_agreementbookingservicetask_PhoneCalls)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_agreementbookingservicetask`|
|ReferencedAttribute|`msdyn_agreementbookingservicetaskid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_agreementbookingservicetask_phonecall`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_agreementbookingsetup_PhoneCalls"></a> msdyn_agreementbookingsetup_PhoneCalls

One-To-Many Relationship: [msdyn_agreementbookingsetup msdyn_agreementbookingsetup_PhoneCalls](msdyn_agreementbookingsetup.md#BKMK_msdyn_agreementbookingsetup_PhoneCalls)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_agreementbookingsetup`|
|ReferencedAttribute|`msdyn_agreementbookingsetupid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_agreementbookingsetup_phonecall`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_agreementinvoicedate_PhoneCalls"></a> msdyn_agreementinvoicedate_PhoneCalls

One-To-Many Relationship: [msdyn_agreementinvoicedate msdyn_agreementinvoicedate_PhoneCalls](msdyn_agreementinvoicedate.md#BKMK_msdyn_agreementinvoicedate_PhoneCalls)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_agreementinvoicedate`|
|ReferencedAttribute|`msdyn_agreementinvoicedateid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_agreementinvoicedate_phonecall`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_agreementinvoiceproduct_PhoneCalls"></a> msdyn_agreementinvoiceproduct_PhoneCalls

One-To-Many Relationship: [msdyn_agreementinvoiceproduct msdyn_agreementinvoiceproduct_PhoneCalls](msdyn_agreementinvoiceproduct.md#BKMK_msdyn_agreementinvoiceproduct_PhoneCalls)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_agreementinvoiceproduct`|
|ReferencedAttribute|`msdyn_agreementinvoiceproductid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_agreementinvoiceproduct_phonecall`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_agreementinvoicesetup_PhoneCalls"></a> msdyn_agreementinvoicesetup_PhoneCalls

One-To-Many Relationship: [msdyn_agreementinvoicesetup msdyn_agreementinvoicesetup_PhoneCalls](msdyn_agreementinvoicesetup.md#BKMK_msdyn_agreementinvoicesetup_PhoneCalls)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_agreementinvoicesetup`|
|ReferencedAttribute|`msdyn_agreementinvoicesetupid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_agreementinvoicesetup_phonecall`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_bookingalertstatus_PhoneCalls"></a> msdyn_bookingalertstatus_PhoneCalls

One-To-Many Relationship: [msdyn_bookingalertstatus msdyn_bookingalertstatus_PhoneCalls](msdyn_bookingalertstatus.md#BKMK_msdyn_bookingalertstatus_PhoneCalls)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_bookingalertstatus`|
|ReferencedAttribute|`msdyn_bookingalertstatusid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_bookingalertstatus_phonecall`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_bookingrule_PhoneCalls"></a> msdyn_bookingrule_PhoneCalls

One-To-Many Relationship: [msdyn_bookingrule msdyn_bookingrule_PhoneCalls](msdyn_bookingrule.md#BKMK_msdyn_bookingrule_PhoneCalls)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_bookingrule`|
|ReferencedAttribute|`msdyn_bookingruleid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_bookingrule_phonecall`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_bookingtimestamp_PhoneCalls"></a> msdyn_bookingtimestamp_PhoneCalls

One-To-Many Relationship: [msdyn_bookingtimestamp msdyn_bookingtimestamp_PhoneCalls](msdyn_bookingtimestamp.md#BKMK_msdyn_bookingtimestamp_PhoneCalls)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_bookingtimestamp`|
|ReferencedAttribute|`msdyn_bookingtimestampid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_bookingtimestamp_phonecall`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

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

### <a name="BKMK_msdyn_fieldservicesetting_PhoneCalls"></a> msdyn_fieldservicesetting_PhoneCalls

One-To-Many Relationship: [msdyn_fieldservicesetting msdyn_fieldservicesetting_PhoneCalls](msdyn_fieldservicesetting.md#BKMK_msdyn_fieldservicesetting_PhoneCalls)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_fieldservicesetting`|
|ReferencedAttribute|`msdyn_fieldservicesettingid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_fieldservicesetting_phonecall`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_incidenttypecharacteristic_PhoneCalls"></a> msdyn_incidenttypecharacteristic_PhoneCalls

One-To-Many Relationship: [msdyn_incidenttypecharacteristic msdyn_incidenttypecharacteristic_PhoneCalls](msdyn_incidenttypecharacteristic.md#BKMK_msdyn_incidenttypecharacteristic_PhoneCalls)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_incidenttypecharacteristic`|
|ReferencedAttribute|`msdyn_incidenttypecharacteristicid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_incidenttypecharacteristic_phonecall`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_incidenttypeproduct_PhoneCalls"></a> msdyn_incidenttypeproduct_PhoneCalls

One-To-Many Relationship: [msdyn_incidenttypeproduct msdyn_incidenttypeproduct_PhoneCalls](msdyn_incidenttypeproduct.md#BKMK_msdyn_incidenttypeproduct_PhoneCalls)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_incidenttypeproduct`|
|ReferencedAttribute|`msdyn_incidenttypeproductid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_incidenttypeproduct_phonecall`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_incidenttypeservice_PhoneCalls"></a> msdyn_incidenttypeservice_PhoneCalls

One-To-Many Relationship: [msdyn_incidenttypeservice msdyn_incidenttypeservice_PhoneCalls](msdyn_incidenttypeservice.md#BKMK_msdyn_incidenttypeservice_PhoneCalls)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_incidenttypeservice`|
|ReferencedAttribute|`msdyn_incidenttypeserviceid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_incidenttypeservice_phonecall`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_inventoryadjustment_PhoneCalls"></a> msdyn_inventoryadjustment_PhoneCalls

One-To-Many Relationship: [msdyn_inventoryadjustment msdyn_inventoryadjustment_PhoneCalls](msdyn_inventoryadjustment.md#BKMK_msdyn_inventoryadjustment_PhoneCalls)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_inventoryadjustment`|
|ReferencedAttribute|`msdyn_inventoryadjustmentid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_inventoryadjustment_phonecall`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_inventoryadjustmentproduct_PhoneCalls"></a> msdyn_inventoryadjustmentproduct_PhoneCalls

One-To-Many Relationship: [msdyn_inventoryadjustmentproduct msdyn_inventoryadjustmentproduct_PhoneCalls](msdyn_inventoryadjustmentproduct.md#BKMK_msdyn_inventoryadjustmentproduct_PhoneCalls)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_inventoryadjustmentproduct`|
|ReferencedAttribute|`msdyn_inventoryadjustmentproductid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_inventoryadjustmentproduct_phonecall`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_inventoryjournal_PhoneCalls"></a> msdyn_inventoryjournal_PhoneCalls

One-To-Many Relationship: [msdyn_inventoryjournal msdyn_inventoryjournal_PhoneCalls](msdyn_inventoryjournal.md#BKMK_msdyn_inventoryjournal_PhoneCalls)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_inventoryjournal`|
|ReferencedAttribute|`msdyn_inventoryjournalid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_inventoryjournal_phonecall`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_inventorytransfer_PhoneCalls"></a> msdyn_inventorytransfer_PhoneCalls

One-To-Many Relationship: [msdyn_inventorytransfer msdyn_inventorytransfer_PhoneCalls](msdyn_inventorytransfer.md#BKMK_msdyn_inventorytransfer_PhoneCalls)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_inventorytransfer`|
|ReferencedAttribute|`msdyn_inventorytransferid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_inventorytransfer_phonecall`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_payment_PhoneCalls"></a> msdyn_payment_PhoneCalls

One-To-Many Relationship: [msdyn_payment msdyn_payment_PhoneCalls](msdyn_payment.md#BKMK_msdyn_payment_PhoneCalls)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_payment`|
|ReferencedAttribute|`msdyn_paymentid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_payment_phonecall`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_paymentdetail_PhoneCalls"></a> msdyn_paymentdetail_PhoneCalls

One-To-Many Relationship: [msdyn_paymentdetail msdyn_paymentdetail_PhoneCalls](msdyn_paymentdetail.md#BKMK_msdyn_paymentdetail_PhoneCalls)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_paymentdetail`|
|ReferencedAttribute|`msdyn_paymentdetailid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_paymentdetail_phonecall`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_paymentmethod_PhoneCalls"></a> msdyn_paymentmethod_PhoneCalls

One-To-Many Relationship: [msdyn_paymentmethod msdyn_paymentmethod_PhoneCalls](msdyn_paymentmethod.md#BKMK_msdyn_paymentmethod_PhoneCalls)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_paymentmethod`|
|ReferencedAttribute|`msdyn_paymentmethodid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_paymentmethod_phonecall`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_paymentterm_PhoneCalls"></a> msdyn_paymentterm_PhoneCalls

One-To-Many Relationship: [msdyn_paymentterm msdyn_paymentterm_PhoneCalls](msdyn_paymentterm.md#BKMK_msdyn_paymentterm_PhoneCalls)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_paymentterm`|
|ReferencedAttribute|`msdyn_paymenttermid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_paymentterm_phonecall`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_playbookinstance_PhoneCalls"></a> msdyn_playbookinstance_PhoneCalls

One-To-Many Relationship: [msdyn_playbookinstance msdyn_playbookinstance_PhoneCalls](msdyn_playbookinstance.md#BKMK_msdyn_playbookinstance_PhoneCalls)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_playbookinstance`|
|ReferencedAttribute|`msdyn_playbookinstanceid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_playbookinstance_phonecall`|
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

### <a name="BKMK_msdyn_postalcode_PhoneCalls"></a> msdyn_postalcode_PhoneCalls

One-To-Many Relationship: [msdyn_postalcode msdyn_postalcode_PhoneCalls](msdyn_postalcode.md#BKMK_msdyn_postalcode_PhoneCalls)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_postalcode`|
|ReferencedAttribute|`msdyn_postalcodeid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_postalcode_phonecall`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_productinventory_PhoneCalls"></a> msdyn_productinventory_PhoneCalls

One-To-Many Relationship: [msdyn_productinventory msdyn_productinventory_PhoneCalls](msdyn_productinventory.md#BKMK_msdyn_productinventory_PhoneCalls)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_productinventory`|
|ReferencedAttribute|`msdyn_productinventoryid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_productinventory_phonecall`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_purchaseorder_PhoneCalls"></a> msdyn_purchaseorder_PhoneCalls

One-To-Many Relationship: [msdyn_purchaseorder msdyn_purchaseorder_PhoneCalls](msdyn_purchaseorder.md#BKMK_msdyn_purchaseorder_PhoneCalls)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_purchaseorder`|
|ReferencedAttribute|`msdyn_purchaseorderid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_purchaseorder_phonecall`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_purchaseorderbill_PhoneCalls"></a> msdyn_purchaseorderbill_PhoneCalls

One-To-Many Relationship: [msdyn_purchaseorderbill msdyn_purchaseorderbill_PhoneCalls](msdyn_purchaseorderbill.md#BKMK_msdyn_purchaseorderbill_PhoneCalls)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_purchaseorderbill`|
|ReferencedAttribute|`msdyn_purchaseorderbillid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_purchaseorderbill_phonecall`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_purchaseorderproduct_PhoneCalls"></a> msdyn_purchaseorderproduct_PhoneCalls

One-To-Many Relationship: [msdyn_purchaseorderproduct msdyn_purchaseorderproduct_PhoneCalls](msdyn_purchaseorderproduct.md#BKMK_msdyn_purchaseorderproduct_PhoneCalls)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_purchaseorderproduct`|
|ReferencedAttribute|`msdyn_purchaseorderproductid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_purchaseorderproduct_phonecall`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_purchaseorderreceipt_PhoneCalls"></a> msdyn_purchaseorderreceipt_PhoneCalls

One-To-Many Relationship: [msdyn_purchaseorderreceipt msdyn_purchaseorderreceipt_PhoneCalls](msdyn_purchaseorderreceipt.md#BKMK_msdyn_purchaseorderreceipt_PhoneCalls)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_purchaseorderreceipt`|
|ReferencedAttribute|`msdyn_purchaseorderreceiptid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_purchaseorderreceipt_phonecall`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_purchaseorderreceiptproduct_PhoneCalls"></a> msdyn_purchaseorderreceiptproduct_PhoneCalls

One-To-Many Relationship: [msdyn_purchaseorderreceiptproduct msdyn_purchaseorderreceiptproduct_PhoneCalls](msdyn_purchaseorderreceiptproduct.md#BKMK_msdyn_purchaseorderreceiptproduct_PhoneCalls)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_purchaseorderreceiptproduct`|
|ReferencedAttribute|`msdyn_purchaseorderreceiptproductid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_purchaseorderreceiptproduct_phonecall`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_purchaseordersubstatus_PhoneCalls"></a> msdyn_purchaseordersubstatus_PhoneCalls

One-To-Many Relationship: [msdyn_purchaseordersubstatus msdyn_purchaseordersubstatus_PhoneCalls](msdyn_purchaseordersubstatus.md#BKMK_msdyn_purchaseordersubstatus_PhoneCalls)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_purchaseordersubstatus`|
|ReferencedAttribute|`msdyn_purchaseordersubstatusid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_purchaseordersubstatus_phonecall`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_quotebookingincident_PhoneCalls"></a> msdyn_quotebookingincident_PhoneCalls

One-To-Many Relationship: [msdyn_quotebookingincident msdyn_quotebookingincident_PhoneCalls](msdyn_quotebookingincident.md#BKMK_msdyn_quotebookingincident_PhoneCalls)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_quotebookingincident`|
|ReferencedAttribute|`msdyn_quotebookingincidentid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_quotebookingincident_phonecall`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_quotebookingproduct_PhoneCalls"></a> msdyn_quotebookingproduct_PhoneCalls

One-To-Many Relationship: [msdyn_quotebookingproduct msdyn_quotebookingproduct_PhoneCalls](msdyn_quotebookingproduct.md#BKMK_msdyn_quotebookingproduct_PhoneCalls)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_quotebookingproduct`|
|ReferencedAttribute|`msdyn_quotebookingproductid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_quotebookingproduct_phonecall`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_quotebookingservice_PhoneCalls"></a> msdyn_quotebookingservice_PhoneCalls

One-To-Many Relationship: [msdyn_quotebookingservice msdyn_quotebookingservice_PhoneCalls](msdyn_quotebookingservice.md#BKMK_msdyn_quotebookingservice_PhoneCalls)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_quotebookingservice`|
|ReferencedAttribute|`msdyn_quotebookingserviceid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_quotebookingservice_phonecall`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_quotebookingservicetask_PhoneCalls"></a> msdyn_quotebookingservicetask_PhoneCalls

One-To-Many Relationship: [msdyn_quotebookingservicetask msdyn_quotebookingservicetask_PhoneCalls](msdyn_quotebookingservicetask.md#BKMK_msdyn_quotebookingservicetask_PhoneCalls)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_quotebookingservicetask`|
|ReferencedAttribute|`msdyn_quotebookingservicetaskid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_quotebookingservicetask_phonecall`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_resourceterritory_PhoneCalls"></a> msdyn_resourceterritory_PhoneCalls

One-To-Many Relationship: [msdyn_resourceterritory msdyn_resourceterritory_PhoneCalls](msdyn_resourceterritory.md#BKMK_msdyn_resourceterritory_PhoneCalls)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_resourceterritory`|
|ReferencedAttribute|`msdyn_resourceterritoryid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_resourceterritory_phonecall`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_rma_PhoneCalls"></a> msdyn_rma_PhoneCalls

One-To-Many Relationship: [msdyn_rma msdyn_rma_PhoneCalls](msdyn_rma.md#BKMK_msdyn_rma_PhoneCalls)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_rma`|
|ReferencedAttribute|`msdyn_rmaid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_rma_phonecall`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_rmaproduct_PhoneCalls"></a> msdyn_rmaproduct_PhoneCalls

One-To-Many Relationship: [msdyn_rmaproduct msdyn_rmaproduct_PhoneCalls](msdyn_rmaproduct.md#BKMK_msdyn_rmaproduct_PhoneCalls)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_rmaproduct`|
|ReferencedAttribute|`msdyn_rmaproductid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_rmaproduct_phonecall`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_rmareceipt_PhoneCalls"></a> msdyn_rmareceipt_PhoneCalls

One-To-Many Relationship: [msdyn_rmareceipt msdyn_rmareceipt_PhoneCalls](msdyn_rmareceipt.md#BKMK_msdyn_rmareceipt_PhoneCalls)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_rmareceipt`|
|ReferencedAttribute|`msdyn_rmareceiptid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_rmareceipt_phonecall`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_rmareceiptproduct_PhoneCalls"></a> msdyn_rmareceiptproduct_PhoneCalls

One-To-Many Relationship: [msdyn_rmareceiptproduct msdyn_rmareceiptproduct_PhoneCalls](msdyn_rmareceiptproduct.md#BKMK_msdyn_rmareceiptproduct_PhoneCalls)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_rmareceiptproduct`|
|ReferencedAttribute|`msdyn_rmareceiptproductid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_rmareceiptproduct_phonecall`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_rmasubstatus_PhoneCalls"></a> msdyn_rmasubstatus_PhoneCalls

One-To-Many Relationship: [msdyn_rmasubstatus msdyn_rmasubstatus_PhoneCalls](msdyn_rmasubstatus.md#BKMK_msdyn_rmasubstatus_PhoneCalls)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_rmasubstatus`|
|ReferencedAttribute|`msdyn_rmasubstatusid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_rmasubstatus_phonecall`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_rtv_PhoneCalls"></a> msdyn_rtv_PhoneCalls

One-To-Many Relationship: [msdyn_rtv msdyn_rtv_PhoneCalls](msdyn_rtv.md#BKMK_msdyn_rtv_PhoneCalls)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_rtv`|
|ReferencedAttribute|`msdyn_rtvid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_rtv_phonecall`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_rtvproduct_PhoneCalls"></a> msdyn_rtvproduct_PhoneCalls

One-To-Many Relationship: [msdyn_rtvproduct msdyn_rtvproduct_PhoneCalls](msdyn_rtvproduct.md#BKMK_msdyn_rtvproduct_PhoneCalls)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_rtvproduct`|
|ReferencedAttribute|`msdyn_rtvproductid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_rtvproduct_phonecall`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_rtvsubstatus_PhoneCalls"></a> msdyn_rtvsubstatus_PhoneCalls

One-To-Many Relationship: [msdyn_rtvsubstatus msdyn_rtvsubstatus_PhoneCalls](msdyn_rtvsubstatus.md#BKMK_msdyn_rtvsubstatus_PhoneCalls)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_rtvsubstatus`|
|ReferencedAttribute|`msdyn_rtvsubstatusid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_rtvsubstatus_phonecall`|
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

### <a name="BKMK_msdyn_shipvia_PhoneCalls"></a> msdyn_shipvia_PhoneCalls

One-To-Many Relationship: [msdyn_shipvia msdyn_shipvia_PhoneCalls](msdyn_shipvia.md#BKMK_msdyn_shipvia_PhoneCalls)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_shipvia`|
|ReferencedAttribute|`msdyn_shipviaid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_shipvia_phonecall`|
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

### <a name="BKMK_msdyn_systemuserschedulersetting_PhoneCalls"></a> msdyn_systemuserschedulersetting_PhoneCalls

One-To-Many Relationship: [msdyn_systemuserschedulersetting msdyn_systemuserschedulersetting_PhoneCalls](msdyn_systemuserschedulersetting.md#BKMK_msdyn_systemuserschedulersetting_PhoneCalls)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_systemuserschedulersetting`|
|ReferencedAttribute|`msdyn_systemuserschedulersettingid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_systemuserschedulersetting_phonecall`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_timegroup_PhoneCalls"></a> msdyn_timegroup_PhoneCalls

One-To-Many Relationship: [msdyn_timegroup msdyn_timegroup_PhoneCalls](msdyn_timegroup.md#BKMK_msdyn_timegroup_PhoneCalls)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_timegroup`|
|ReferencedAttribute|`msdyn_timegroupid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_timegroup_phonecall`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_timegroupdetail_PhoneCalls"></a> msdyn_timegroupdetail_PhoneCalls

One-To-Many Relationship: [msdyn_timegroupdetail msdyn_timegroupdetail_PhoneCalls](msdyn_timegroupdetail.md#BKMK_msdyn_timegroupdetail_PhoneCalls)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_timegroupdetail`|
|ReferencedAttribute|`msdyn_timegroupdetailid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_timegroupdetail_phonecall`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_timeoffrequest_PhoneCalls"></a> msdyn_timeoffrequest_PhoneCalls

One-To-Many Relationship: [msdyn_timeoffrequest msdyn_timeoffrequest_PhoneCalls](msdyn_timeoffrequest.md#BKMK_msdyn_timeoffrequest_PhoneCalls)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_timeoffrequest`|
|ReferencedAttribute|`msdyn_timeoffrequestid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_timeoffrequest_phonecall`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_warehouse_PhoneCalls"></a> msdyn_warehouse_PhoneCalls

One-To-Many Relationship: [msdyn_warehouse msdyn_warehouse_PhoneCalls](msdyn_warehouse.md#BKMK_msdyn_warehouse_PhoneCalls)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_warehouse`|
|ReferencedAttribute|`msdyn_warehouseid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_warehouse_phonecall`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_workorder_PhoneCalls"></a> msdyn_workorder_PhoneCalls

One-To-Many Relationship: [msdyn_workorder msdyn_workorder_PhoneCalls](msdyn_workorder.md#BKMK_msdyn_workorder_PhoneCalls)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_workorder`|
|ReferencedAttribute|`msdyn_workorderid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_workorder_phonecall`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_workordercharacteristic_PhoneCalls"></a> msdyn_workordercharacteristic_PhoneCalls

One-To-Many Relationship: [msdyn_workordercharacteristic msdyn_workordercharacteristic_PhoneCalls](msdyn_workordercharacteristic.md#BKMK_msdyn_workordercharacteristic_PhoneCalls)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_workordercharacteristic`|
|ReferencedAttribute|`msdyn_workordercharacteristicid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_workordercharacteristic_phonecall`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_workorderincident_PhoneCalls"></a> msdyn_workorderincident_PhoneCalls

One-To-Many Relationship: [msdyn_workorderincident msdyn_workorderincident_PhoneCalls](msdyn_workorderincident.md#BKMK_msdyn_workorderincident_PhoneCalls)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_workorderincident`|
|ReferencedAttribute|`msdyn_workorderincidentid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_workorderincident_phonecall`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_workorderproduct_PhoneCalls"></a> msdyn_workorderproduct_PhoneCalls

One-To-Many Relationship: [msdyn_workorderproduct msdyn_workorderproduct_PhoneCalls](msdyn_workorderproduct.md#BKMK_msdyn_workorderproduct_PhoneCalls)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_workorderproduct`|
|ReferencedAttribute|`msdyn_workorderproductid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_workorderproduct_phonecall`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_workorderresourcerestriction_PhoneCalls"></a> msdyn_workorderresourcerestriction_PhoneCalls

One-To-Many Relationship: [msdyn_workorderresourcerestriction msdyn_workorderresourcerestriction_PhoneCalls](msdyn_workorderresourcerestriction.md#BKMK_msdyn_workorderresourcerestriction_PhoneCalls)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_workorderresourcerestriction`|
|ReferencedAttribute|`msdyn_workorderresourcerestrictionid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_workorderresourcerestriction_phonecall`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_workorderservice_PhoneCalls"></a> msdyn_workorderservice_PhoneCalls

One-To-Many Relationship: [msdyn_workorderservice msdyn_workorderservice_PhoneCalls](msdyn_workorderservice.md#BKMK_msdyn_workorderservice_PhoneCalls)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_workorderservice`|
|ReferencedAttribute|`msdyn_workorderserviceid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_workorderservice_phonecall`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_workorderservicetask_PhoneCalls"></a> msdyn_workorderservicetask_PhoneCalls

One-To-Many Relationship: [msdyn_workorderservicetask msdyn_workorderservicetask_PhoneCalls](msdyn_workorderservicetask.md#BKMK_msdyn_workorderservicetask_PhoneCalls)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_workorderservicetask`|
|ReferencedAttribute|`msdyn_workorderservicetaskid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_workorderservicetask_phonecall`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyncrm_contentsettings_PhoneCalls"></a> msdyncrm_contentsettings_PhoneCalls

One-To-Many Relationship: [msdyncrm_contentsettings msdyncrm_contentsettings_PhoneCalls](msdyncrm_contentsettings.md#BKMK_msdyncrm_contentsettings_PhoneCalls)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyncrm_contentsettings`|
|ReferencedAttribute|`msdyncrm_contentsettingsid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyncrm_contentsettings_phonecall`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyncrm_customerjourney_PhoneCalls"></a> msdyncrm_customerjourney_PhoneCalls

One-To-Many Relationship: [msdyncrm_customerjourney msdyncrm_customerjourney_PhoneCalls](msdyncrm_customerjourney.md#BKMK_msdyncrm_customerjourney_PhoneCalls)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyncrm_customerjourney`|
|ReferencedAttribute|`msdyncrm_customerjourneyid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyncrm_customerjourney_phonecall`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyncrm_leadscoremodel_PhoneCalls"></a> msdyncrm_leadscoremodel_PhoneCalls

One-To-Many Relationship: [msdyncrm_leadscoremodel msdyncrm_leadscoremodel_PhoneCalls](msdyncrm_leadscoremodel.md#BKMK_msdyncrm_leadscoremodel_PhoneCalls)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyncrm_leadscoremodel`|
|ReferencedAttribute|`msdyncrm_leadscoremodelid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyncrm_leadscoremodel_phonecall`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyncrm_linkedinaccount_PhoneCalls"></a> msdyncrm_linkedinaccount_PhoneCalls

One-To-Many Relationship: [msdyncrm_linkedinaccount msdyncrm_linkedinaccount_PhoneCalls](msdyncrm_linkedinaccount.md#BKMK_msdyncrm_linkedinaccount_PhoneCalls)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyncrm_linkedinaccount`|
|ReferencedAttribute|`msdyncrm_linkedinaccountid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyncrm_linkedinaccount_phonecall`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyncrm_linkedinactivity_PhoneCalls"></a> msdyncrm_linkedinactivity_PhoneCalls

One-To-Many Relationship: [msdyncrm_linkedinactivity msdyncrm_linkedinactivity_PhoneCalls](msdyncrm_linkedinactivity.md#BKMK_msdyncrm_linkedinactivity_PhoneCalls)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyncrm_linkedinactivity`|
|ReferencedAttribute|`msdyncrm_linkedinactivityid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyncrm_linkedinactivity_phonecall`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyncrm_linkedinfieldmapping_PhoneCalls"></a> msdyncrm_linkedinfieldmapping_PhoneCalls

One-To-Many Relationship: [msdyncrm_linkedinfieldmapping msdyncrm_linkedinfieldmapping_PhoneCalls](msdyncrm_linkedinfieldmapping.md#BKMK_msdyncrm_linkedinfieldmapping_PhoneCalls)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyncrm_linkedinfieldmapping`|
|ReferencedAttribute|`msdyncrm_linkedinfieldmappingid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyncrm_linkedinfieldmapping_phonecall`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyncrm_linkedinform_PhoneCalls"></a> msdyncrm_linkedinform_PhoneCalls

One-To-Many Relationship: [msdyncrm_linkedinform msdyncrm_linkedinform_PhoneCalls](msdyncrm_linkedinform.md#BKMK_msdyncrm_linkedinform_PhoneCalls)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyncrm_linkedinform`|
|ReferencedAttribute|`msdyncrm_linkedinformid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyncrm_linkedinform_phonecall`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyncrm_linkedinformanswer_PhoneCalls"></a> msdyncrm_linkedinformanswer_PhoneCalls

One-To-Many Relationship: [msdyncrm_linkedinformanswer msdyncrm_linkedinformanswer_PhoneCalls](msdyncrm_linkedinformanswer.md#BKMK_msdyncrm_linkedinformanswer_PhoneCalls)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyncrm_linkedinformanswer`|
|ReferencedAttribute|`msdyncrm_linkedinformanswerid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyncrm_linkedinformanswer_phonecall`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyncrm_linkedinformquestion_PhoneCalls"></a> msdyncrm_linkedinformquestion_PhoneCalls

One-To-Many Relationship: [msdyncrm_linkedinformquestion msdyncrm_linkedinformquestion_PhoneCalls](msdyncrm_linkedinformquestion.md#BKMK_msdyncrm_linkedinformquestion_PhoneCalls)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyncrm_linkedinformquestion`|
|ReferencedAttribute|`msdyncrm_linkedinformquestionid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyncrm_linkedinformquestion_phonecall`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyncrm_linkedinformsubmission_PhoneCalls"></a> msdyncrm_linkedinformsubmission_PhoneCalls

One-To-Many Relationship: [msdyncrm_linkedinformsubmission msdyncrm_linkedinformsubmission_PhoneCalls](msdyncrm_linkedinformsubmission.md#BKMK_msdyncrm_linkedinformsubmission_PhoneCalls)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyncrm_linkedinformsubmission`|
|ReferencedAttribute|`msdyncrm_linkedinformsubmissionid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyncrm_linkedinformsubmission_phonecall`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyncrm_linkedinleadmatchingstrategy_PhoneCalls"></a> msdyncrm_linkedinleadmatchingstrategy_PhoneCalls

One-To-Many Relationship: [msdyncrm_linkedinleadmatchingstrategy msdyncrm_linkedinleadmatchingstrategy_PhoneCalls](msdyncrm_linkedinleadmatchingstrategy.md#BKMK_msdyncrm_linkedinleadmatchingstrategy_PhoneCalls)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyncrm_linkedinleadmatchingstrategy`|
|ReferencedAttribute|`msdyncrm_linkedinleadmatchingstrategyid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyncrm_linkedinleadmatchingstrategy_phonecall`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyncrm_linkedinuserprofile_PhoneCalls"></a> msdyncrm_linkedinuserprofile_PhoneCalls

One-To-Many Relationship: [msdyncrm_linkedinuserprofile msdyncrm_linkedinuserprofile_PhoneCalls](msdyncrm_linkedinuserprofile.md#BKMK_msdyncrm_linkedinuserprofile_PhoneCalls)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyncrm_linkedinuserprofile`|
|ReferencedAttribute|`msdyncrm_linkedinuserprofileid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyncrm_linkedinuserprofile_phonecall`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyncrm_marketingdynamiccontentmetadata_PhoneCalls"></a> msdyncrm_marketingdynamiccontentmetadata_PhoneCalls

One-To-Many Relationship: [msdyncrm_marketingdynamiccontentmetadata msdyncrm_marketingdynamiccontentmetadata_PhoneCalls](msdyncrm_marketingdynamiccontentmetadata.md#BKMK_msdyncrm_marketingdynamiccontentmetadata_PhoneCalls)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyncrm_marketingdynamiccontentmetadata`|
|ReferencedAttribute|`msdyncrm_marketingdynamiccontentmetadataid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyncrm_marketingdynamiccontentmetadata_phonecall`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyncrm_marketingemaildynamiccontentmetadata_PhoneCalls"></a> msdyncrm_marketingemaildynamiccontentmetadata_PhoneCalls

One-To-Many Relationship: [msdyncrm_marketingemaildynamiccontentmetadata msdyncrm_marketingemaildynamiccontentmetadata_PhoneCalls](msdyncrm_marketingemaildynamiccontentmetadata.md#BKMK_msdyncrm_marketingemaildynamiccontentmetadata_PhoneCalls)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyncrm_marketingemaildynamiccontentmetadata`|
|ReferencedAttribute|`msdyncrm_marketingemaildynamiccontentmetadataid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyncrm_marketingemaildynamiccontentmetadata_phonecall`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyncrm_marketingemailtestsend_PhoneCalls"></a> msdyncrm_marketingemailtestsend_PhoneCalls

One-To-Many Relationship: [msdyncrm_marketingemailtestsend msdyncrm_marketingemailtestsend_PhoneCalls](msdyncrm_marketingemailtestsend.md#BKMK_msdyncrm_marketingemailtestsend_PhoneCalls)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyncrm_marketingemailtestsend`|
|ReferencedAttribute|`msdyncrm_marketingemailtestsendid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyncrm_marketingemailtestsend_phonecall`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyncrm_migration_PhoneCalls"></a> msdyncrm_migration_PhoneCalls

One-To-Many Relationship: [msdyncrm_migration msdyncrm_migration_PhoneCalls](msdyncrm_migration.md#BKMK_msdyncrm_migration_PhoneCalls)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyncrm_migration`|
|ReferencedAttribute|`msdyncrm_migrationid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyncrm_migration_phonecall`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyncrm_msdyncrm_customerjourneyiteration_phonecall"></a> msdyncrm_msdyncrm_customerjourneyiteration_phonecall

One-To-Many Relationship: [msdyncrm_customerjourneyiteration msdyncrm_msdyncrm_customerjourneyiteration_phonecall](msdyncrm_customerjourneyiteration.md#BKMK_msdyncrm_msdyncrm_customerjourneyiteration_phonecall)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyncrm_customerjourneyiteration`|
|ReferencedAttribute|`msdyncrm_customerjourneyiterationid`|
|ReferencingAttribute|`msdyncrm_associatedcustomerjourneyiteration`|
|ReferencingEntityNavigationPropertyName|`msdyncrm_associatedcustomerjourneyiteration_PhoneCall`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyncrm_uicconfig_PhoneCalls"></a> msdyncrm_uicconfig_PhoneCalls

One-To-Many Relationship: [msdyncrm_uicconfig msdyncrm_uicconfig_PhoneCalls](msdyncrm_uicconfig.md#BKMK_msdyncrm_uicconfig_PhoneCalls)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyncrm_uicconfig`|
|ReferencedAttribute|`msdyncrm_uicconfigid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyncrm_uicconfig_phonecall`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdynmkt_phonecall_JourneyId_msdynmkt_journey"></a> msdynmkt_phonecall_JourneyId_msdynmkt_journey

One-To-Many Relationship: [msdynmkt_journey msdynmkt_phonecall_JourneyId_msdynmkt_journey](msdynmkt_journey.md#BKMK_msdynmkt_phonecall_JourneyId_msdynmkt_journey)

|Property|Value|
|---|---|
|ReferencedEntity|`msdynmkt_journey`|
|ReferencedAttribute|`msdynmkt_journeyid`|
|ReferencingAttribute|`msdynmkt_journeyid`|
|ReferencingEntityNavigationPropertyName|`msdynmkt_JourneyId_PhoneCall`|
|IsHierarchical||
|CascadeConfiguration|Archive: `RemoveLink`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msevtmgt_checkin_PhoneCalls"></a> msevtmgt_checkin_PhoneCalls

One-To-Many Relationship: [msevtmgt_checkin msevtmgt_checkin_PhoneCalls](msevtmgt_checkin.md#BKMK_msevtmgt_checkin_PhoneCalls)

|Property|Value|
|---|---|
|ReferencedEntity|`msevtmgt_checkin`|
|ReferencedAttribute|`msevtmgt_checkinid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msevtmgt_checkin_phonecall`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msevtmgt_event_PhoneCalls"></a> msevtmgt_event_PhoneCalls

One-To-Many Relationship: [msevtmgt_event msevtmgt_event_PhoneCalls](msevtmgt_event.md#BKMK_msevtmgt_event_PhoneCalls)

|Property|Value|
|---|---|
|ReferencedEntity|`msevtmgt_event`|
|ReferencedAttribute|`msevtmgt_eventid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msevtmgt_event_phonecall`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msevtmgt_eventpurchase_PhoneCalls"></a> msevtmgt_eventpurchase_PhoneCalls

One-To-Many Relationship: [msevtmgt_eventpurchase msevtmgt_eventpurchase_PhoneCalls](msevtmgt_eventpurchase.md#BKMK_msevtmgt_eventpurchase_PhoneCalls)

|Property|Value|
|---|---|
|ReferencedEntity|`msevtmgt_eventpurchase`|
|ReferencedAttribute|`msevtmgt_eventpurchaseid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msevtmgt_eventpurchase_phonecall`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msevtmgt_eventpurchaseattendee_PhoneCalls"></a> msevtmgt_eventpurchaseattendee_PhoneCalls

One-To-Many Relationship: [msevtmgt_eventpurchaseattendee msevtmgt_eventpurchaseattendee_PhoneCalls](msevtmgt_eventpurchaseattendee.md#BKMK_msevtmgt_eventpurchaseattendee_PhoneCalls)

|Property|Value|
|---|---|
|ReferencedEntity|`msevtmgt_eventpurchaseattendee`|
|ReferencedAttribute|`msevtmgt_eventpurchaseattendeeid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msevtmgt_eventpurchaseattendee_phonecall`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msevtmgt_eventpurchasepass_PhoneCalls"></a> msevtmgt_eventpurchasepass_PhoneCalls

One-To-Many Relationship: [msevtmgt_eventpurchasepass msevtmgt_eventpurchasepass_PhoneCalls](msevtmgt_eventpurchasepass.md#BKMK_msevtmgt_eventpurchasepass_PhoneCalls)

|Property|Value|
|---|---|
|ReferencedEntity|`msevtmgt_eventpurchasepass`|
|ReferencedAttribute|`msevtmgt_eventpurchasepassid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msevtmgt_eventpurchasepass_phonecall`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msevtmgt_eventregistration_PhoneCalls"></a> msevtmgt_eventregistration_PhoneCalls

One-To-Many Relationship: [msevtmgt_eventregistration msevtmgt_eventregistration_PhoneCalls](msevtmgt_eventregistration.md#BKMK_msevtmgt_eventregistration_PhoneCalls)

|Property|Value|
|---|---|
|ReferencedEntity|`msevtmgt_eventregistration`|
|ReferencedAttribute|`msevtmgt_eventregistrationid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msevtmgt_eventregistration_phonecall`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msevtmgt_hotel_PhoneCalls"></a> msevtmgt_hotel_PhoneCalls

One-To-Many Relationship: [msevtmgt_hotel msevtmgt_hotel_PhoneCalls](msevtmgt_hotel.md#BKMK_msevtmgt_hotel_PhoneCalls)

|Property|Value|
|---|---|
|ReferencedEntity|`msevtmgt_hotel`|
|ReferencedAttribute|`msevtmgt_hotelid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msevtmgt_hotel_phonecall`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msevtmgt_hotelroomallocation_PhoneCalls"></a> msevtmgt_hotelroomallocation_PhoneCalls

One-To-Many Relationship: [msevtmgt_hotelroomallocation msevtmgt_hotelroomallocation_PhoneCalls](msevtmgt_hotelroomallocation.md#BKMK_msevtmgt_hotelroomallocation_PhoneCalls)

|Property|Value|
|---|---|
|ReferencedEntity|`msevtmgt_hotelroomallocation`|
|ReferencedAttribute|`msevtmgt_hotelroomallocationid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msevtmgt_hotelroomallocation_phonecall`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msevtmgt_hotelroomreservation_PhoneCalls"></a> msevtmgt_hotelroomreservation_PhoneCalls

One-To-Many Relationship: [msevtmgt_hotelroomreservation msevtmgt_hotelroomreservation_PhoneCalls](msevtmgt_hotelroomreservation.md#BKMK_msevtmgt_hotelroomreservation_PhoneCalls)

|Property|Value|
|---|---|
|ReferencedEntity|`msevtmgt_hotelroomreservation`|
|ReferencedAttribute|`msevtmgt_hotelroomreservationid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msevtmgt_hotelroomreservation_phonecall`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msevtmgt_layout_PhoneCalls"></a> msevtmgt_layout_PhoneCalls

One-To-Many Relationship: [msevtmgt_layout msevtmgt_layout_PhoneCalls](msevtmgt_layout.md#BKMK_msevtmgt_layout_PhoneCalls)

|Property|Value|
|---|---|
|ReferencedEntity|`msevtmgt_layout`|
|ReferencedAttribute|`msevtmgt_layoutid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msevtmgt_layout_phonecall`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msevtmgt_room_PhoneCalls"></a> msevtmgt_room_PhoneCalls

One-To-Many Relationship: [msevtmgt_room msevtmgt_room_PhoneCalls](msevtmgt_room.md#BKMK_msevtmgt_room_PhoneCalls)

|Property|Value|
|---|---|
|ReferencedEntity|`msevtmgt_room`|
|ReferencedAttribute|`msevtmgt_roomid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msevtmgt_room_phonecall`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msevtmgt_session_PhoneCalls"></a> msevtmgt_session_PhoneCalls

One-To-Many Relationship: [msevtmgt_session msevtmgt_session_PhoneCalls](msevtmgt_session.md#BKMK_msevtmgt_session_PhoneCalls)

|Property|Value|
|---|---|
|ReferencedEntity|`msevtmgt_session`|
|ReferencedAttribute|`msevtmgt_sessionid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msevtmgt_session_phonecall`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msevtmgt_sessionregistration_PhoneCalls"></a> msevtmgt_sessionregistration_PhoneCalls

One-To-Many Relationship: [msevtmgt_sessionregistration msevtmgt_sessionregistration_PhoneCalls](msevtmgt_sessionregistration.md#BKMK_msevtmgt_sessionregistration_PhoneCalls)

|Property|Value|
|---|---|
|ReferencedEntity|`msevtmgt_sessionregistration`|
|ReferencedAttribute|`msevtmgt_sessionregistrationid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msevtmgt_sessionregistration_phonecall`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msevtmgt_sessiontrack_PhoneCalls"></a> msevtmgt_sessiontrack_PhoneCalls

One-To-Many Relationship: [msevtmgt_sessiontrack msevtmgt_sessiontrack_PhoneCalls](msevtmgt_sessiontrack.md#BKMK_msevtmgt_sessiontrack_PhoneCalls)

|Property|Value|
|---|---|
|ReferencedEntity|`msevtmgt_sessiontrack`|
|ReferencedAttribute|`msevtmgt_sessiontrackid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msevtmgt_sessiontrack_phonecall`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msevtmgt_speaker_PhoneCalls"></a> msevtmgt_speaker_PhoneCalls

One-To-Many Relationship: [msevtmgt_speaker msevtmgt_speaker_PhoneCalls](msevtmgt_speaker.md#BKMK_msevtmgt_speaker_PhoneCalls)

|Property|Value|
|---|---|
|ReferencedEntity|`msevtmgt_speaker`|
|ReferencedAttribute|`msevtmgt_speakerid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msevtmgt_speaker_phonecall`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msevtmgt_speakerengagement_PhoneCalls"></a> msevtmgt_speakerengagement_PhoneCalls

One-To-Many Relationship: [msevtmgt_speakerengagement msevtmgt_speakerengagement_PhoneCalls](msevtmgt_speakerengagement.md#BKMK_msevtmgt_speakerengagement_PhoneCalls)

|Property|Value|
|---|---|
|ReferencedEntity|`msevtmgt_speakerengagement`|
|ReferencedAttribute|`msevtmgt_speakerengagementid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msevtmgt_speakerengagement_phonecall`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msevtmgt_sponsorablearticle_PhoneCalls"></a> msevtmgt_sponsorablearticle_PhoneCalls

One-To-Many Relationship: [msevtmgt_sponsorablearticle msevtmgt_sponsorablearticle_PhoneCalls](msevtmgt_sponsorablearticle.md#BKMK_msevtmgt_sponsorablearticle_PhoneCalls)

|Property|Value|
|---|---|
|ReferencedEntity|`msevtmgt_sponsorablearticle`|
|ReferencedAttribute|`msevtmgt_sponsorablearticleid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msevtmgt_sponsorablearticle_phonecall`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msevtmgt_sponsorship_PhoneCalls"></a> msevtmgt_sponsorship_PhoneCalls

One-To-Many Relationship: [msevtmgt_sponsorship msevtmgt_sponsorship_PhoneCalls](msevtmgt_sponsorship.md#BKMK_msevtmgt_sponsorship_PhoneCalls)

|Property|Value|
|---|---|
|ReferencedEntity|`msevtmgt_sponsorship`|
|ReferencedAttribute|`msevtmgt_sponsorshipid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msevtmgt_sponsorship_phonecall`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msevtmgt_venue_PhoneCalls"></a> msevtmgt_venue_PhoneCalls

One-To-Many Relationship: [msevtmgt_venue msevtmgt_venue_PhoneCalls](msevtmgt_venue.md#BKMK_msevtmgt_venue_PhoneCalls)

|Property|Value|
|---|---|
|ReferencedEntity|`msevtmgt_venue`|
|ReferencedAttribute|`msevtmgt_venueid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msevtmgt_venue_phonecall`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msevtmgt_webinarconfiguration_PhoneCalls"></a> msevtmgt_webinarconfiguration_PhoneCalls

One-To-Many Relationship: [msevtmgt_webinarconfiguration msevtmgt_webinarconfiguration_PhoneCalls](msevtmgt_webinarconfiguration.md#BKMK_msevtmgt_webinarconfiguration_PhoneCalls)

|Property|Value|
|---|---|
|ReferencedEntity|`msevtmgt_webinarconfiguration`|
|ReferencedAttribute|`msevtmgt_webinarconfigurationid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msevtmgt_webinarconfiguration_phonecall`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msevtmgt_webinarprovider_PhoneCalls"></a> msevtmgt_webinarprovider_PhoneCalls

One-To-Many Relationship: [msevtmgt_webinarprovider msevtmgt_webinarprovider_PhoneCalls](msevtmgt_webinarprovider.md#BKMK_msevtmgt_webinarprovider_PhoneCalls)

|Property|Value|
|---|---|
|ReferencedEntity|`msevtmgt_webinarprovider`|
|ReferencedAttribute|`msevtmgt_webinarproviderid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msevtmgt_webinarprovider_phonecall`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

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
- [msdyn_phonecall_msdyn_recording_phone_call_activity](#BKMK_msdyn_phonecall_msdyn_recording_phone_call_activity)
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

### <a name="BKMK_msdyn_phonecall_msdyn_recording_phone_call_activity"></a> msdyn_phonecall_msdyn_recording_phone_call_activity

Many-To-One Relationship: [msdyn_recording msdyn_phonecall_msdyn_recording_phone_call_activity](msdyn_recording.md#BKMK_msdyn_phonecall_msdyn_recording_phone_call_activity)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_recording`|
|ReferencingAttribute|`msdyn_phone_call_activity`|
|ReferencedEntityNavigationPropertyName|`msdyn_phonecall_msdyn_recording_phone_call_activity`|
|IsCustomizable|`True`|
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

[Dataverse table/entity reference](../about-entity-reference.md)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   
<xref:Microsoft.Dynamics.CRM.phonecall?displayProperty=fullName>
