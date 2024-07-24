---
title: "Connection table/entity reference (Microsoft Dynamics 365 Field Service)"
description: "Includes schema information and supported messages for the Connection table/entity with Microsoft Dynamics 365 Field Service."
ms.date: 07.24.2024
ms.service: powerapps
ms.topic: reference
author: m-hartmann
ms.author: mhart
search.audienceType: 
  - developer
---

# Connection table/entity reference

Relationship between two entities.

> [!NOTE]
> The Microsoft Dynamics 365 Field Service Connection table extends the [Microsoft Dataverse Connection table](/power-apps/developer/data-platform/reference/entities/connection).



## Customized columns/attributes

Microsoft Dynamics 365 Field Service modifies the definition of columns/attributes defined in other solutions. Listed by **SchemaName**.

- [Record1Id](#BKMK_Record1Id)
- [Record1ObjectTypeCode](#BKMK_Record1ObjectTypeCode)
- [Record2Id](#BKMK_Record2Id)
- [Record2ObjectTypeCode](#BKMK_Record2ObjectTypeCode)

### <a name="BKMK_Record1Id"></a> Record1Id

Changes from [Record1Id (Microsoft Dataverse)](/power-apps/developer/data-platform/reference/entities/connection#BKMK_Record1Id)

|Property|Value|
|---|---|
|Description|Unique identifier of the source record.|
|Targets|adx_alertsubscription|


### <a name="BKMK_Record1ObjectTypeCode"></a> Record1ObjectTypeCode

Changes from [Record1ObjectTypeCode (Microsoft Dataverse)](/power-apps/developer/data-platform/reference/entities/connection#BKMK_Record1ObjectTypeCode)

#### Record1ObjectTypeCode Choices/Options

|Value|Label|
|---|---|
|3|**Opportunity**|
|4|**Lead**|
|112|**Case**|
|123|**Competitor**|
|1010|**Contract**|
|1022|**Price List**|
|1024|**Product**|
|1084|**Quote**|
|1088|**Order**|
|1090|**Invoice**|
|4000|**Facility/Equipment**|
|4005|**Scheduling Group**|
|4007|**Resource Group**|
|4214|**Service Activity**|
|4300|**Marketing List**|
|4400|**Campaign**|
|4402|**Campaign Activity**|
|9700|**Entitlement**|
|9701|**Entitlement Channel**|
|9703|**Entitlement Template Channel**|
|10286|**Invitation**|
|10287|**Invite Redemption**|
|10306|**Publishing State Transition Rule**|
|10308|**Shortcut**|
|10320|**Website**|
|10356|**Customer Asset**|
|10370|**IoT Alert**|
|10371|**IoT Device**|
|10372|**IoT Device Category**|
|10373|**IoT Device Command**|
|10377|**IoT Device Registration History**|
|10563|**Profile Album**|
|10568|**Customer Voice alert**|
|10578|**Customer Voice survey invite**|
|10580|**Customer Voice survey response**|
|10616|**Copilot Transcript**|
|10664|**Ongoing conversation (Deprecated)**|
|10676|**Conversation**|
|10693|**Session**|
|10800|**Sequence**|
|10802|**Sequence Target**|
|10814|**Assignment Rule**|
|10817|**Assignment Map**|
|10824|**Insight**|
|10833|**Suggestion Principal Object Access**|
|10972|**Booking Alert**|
|10973|**Booking Alert Status**|
|10975|**Booking Rule**|
|10985|**Resource Territory**|
|10988|**System User Scheduler Setting**|
|10989|**Fulfillment Preference**|
|10990|**Time Group Detail**|
|11011|**Payment Term**|
|11012|**Purchase Order**|
|11013|**Purchase Order Product**|
|11014|**Purchase Order Receipt**|
|11015|**Purchase Order Receipt Product**|
|11016|**Ship Via**|
|11017|**Tax Code**|
|11019|**Warehouse**|
|11020|**Agreement**|
|11021|**Agreement Booking Date**|
|11022|**Agreement Booking Incident**|
|11023|**Agreement Booking Product**|
|11024|**Agreement Booking Service**|
|11025|**Agreement Booking Service Task**|
|11026|**Agreement Booking Setup**|
|11027|**Agreement Invoice Date**|
|11028|**Agreement Invoice Product**|
|11029|**Agreement Invoice Setup**|
|11032|**Booking Timestamp**|
|11043|**Incident Type Characteristic**|
|11044|**Incident Type Product**|
|11045|**Incident Type Service**|
|11049|**Inventory Adjustment**|
|11050|**Inventory Adjustment Product**|
|11051|**Inventory Journal**|
|11052|**Inventory Transfer**|
|11057|**Payment**|
|11058|**Payment Detail**|
|11059|**Payment Method**|
|11060|**Postal Code**|
|11061|**Product Inventory**|
|11062|**Purchase Order Bill**|
|11063|**Purchase Order SubStatus**|
|11064|**Quote Booking Incident**|
|11065|**Quote Booking Product**|
|11066|**Quote Booking Service**|
|11067|**Quote Booking Service Task**|
|11072|**RMA**|
|11073|**RMA Product**|
|11074|**RMA Receipt**|
|11075|**RMA Receipt Product**|
|11076|**RMA SubStatus**|
|11077|**RTV**|
|11078|**RTV Product**|
|11079|**RTV Substatus**|
|11081|**Time Off Request**|
|11083|**Work Order**|
|11084|**Work Order Characteristic (Deprecated)**|
|11086|**Work Order Incident**|
|11087|**Work Order Product**|
|11088|**Resource Restriction (Deprecated)**|
|11089|**Work Order Service**|
|11090|**Work Order Service Task**|
|11133|**Web Notification URL**|
|11134|**Web Page**|
|11136|**Website**|
|11141|**Alert Subscription**|
|11154|**Publishing State Transition Rule**|
|11156|**Shortcut**|
|11208|**Case Deflection**|
|11209|**Content Access Level**|
|11251|**Scheduling Optimization Request**|
|11301|**Outbound message**|
|11308|**Voicemail**|
|11377|**Appointment activity marketing template**|
|11380|**Content settings**|
|11396|**Dynamic-content metadata**|
|11398|**Marketing email dynamic-content metadata**|
|11402|**Marketing email test send**|
|11414|**Marketing activity**|
|11415|**Phone-call activity marketing template**|
|11421|**Task activity marketing template**|
|11422|**UIC config**|
|11434|**Lead Scoring Model**|
|11439|**LinkedIn Account**|
|11440|**LinkedIn Activity**|
|11443|**Field mapping**|
|11444|**LinkedIn Lead Gen Form**|
|11445|**LinkedIn Form Submission Answer**|
|11446|**LinkedIn Form Question**|
|11447|**LinkedIn Lead Gen Form Submission**|
|11448|**LinkedIn matching**|
|11449|**LinkedIn User Profile**|
|11603|**inMail**|
|11604|**Message**|
|11605|**Smart Links Content Viewed**|

### <a name="BKMK_Record2Id"></a> Record2Id

Changes from [Record2Id (Microsoft Dataverse)](/power-apps/developer/data-platform/reference/entities/connection#BKMK_Record2Id)

|Property|Value|
|---|---|
|Description|Unique identifier of the target record.|
|Targets|adx_alertsubscription|


### <a name="BKMK_Record2ObjectTypeCode"></a> Record2ObjectTypeCode

Changes from [Record2ObjectTypeCode (Microsoft Dataverse)](/power-apps/developer/data-platform/reference/entities/connection#BKMK_Record2ObjectTypeCode)

#### Record2ObjectTypeCode Choices/Options

|Value|Label|
|---|---|
|3|**Opportunity**|
|4|**Lead**|
|112|**Case**|
|123|**Competitor**|
|1010|**Contract**|
|1022|**Price List**|
|1024|**Product**|
|1084|**Quote**|
|1088|**Order**|
|1090|**Invoice**|
|4000|**Facility/Equipment**|
|4005|**Scheduling Group**|
|4007|**Resource Group**|
|4214|**Service Activity**|
|4300|**Marketing List**|
|4400|**Campaign**|
|4402|**Campaign Activity**|
|9700|**Entitlement**|
|9701|**Entitlement Channel**|
|9703|**Entitlement Template Channel**|
|10286|**Invitation**|
|10287|**Invite Redemption**|
|10306|**Publishing State Transition Rule**|
|10308|**Shortcut**|
|10320|**Website**|
|10356|**Customer Asset**|
|10370|**IoT Alert**|
|10371|**IoT Device**|
|10372|**IoT Device Category**|
|10373|**IoT Device Command**|
|10377|**IoT Device Registration History**|
|10563|**Profile Album**|
|10568|**Customer Voice alert**|
|10578|**Customer Voice survey invite**|
|10580|**Customer Voice survey response**|
|10616|**Copilot Transcript**|
|10664|**Ongoing conversation (Deprecated)**|
|10676|**Conversation**|
|10693|**Session**|
|10800|**Sequence**|
|10802|**Sequence Target**|
|10814|**Assignment Rule**|
|10817|**Assignment Map**|
|10824|**Insight**|
|10833|**Suggestion Principal Object Access**|
|10972|**Booking Alert**|
|10973|**Booking Alert Status**|
|10975|**Booking Rule**|
|10985|**Resource Territory**|
|10988|**System User Scheduler Setting**|
|10989|**Fulfillment Preference**|
|10990|**Time Group Detail**|
|11011|**Payment Term**|
|11012|**Purchase Order**|
|11013|**Purchase Order Product**|
|11014|**Purchase Order Receipt**|
|11015|**Purchase Order Receipt Product**|
|11016|**Ship Via**|
|11017|**Tax Code**|
|11019|**Warehouse**|
|11020|**Agreement**|
|11021|**Agreement Booking Date**|
|11022|**Agreement Booking Incident**|
|11023|**Agreement Booking Product**|
|11024|**Agreement Booking Service**|
|11025|**Agreement Booking Service Task**|
|11026|**Agreement Booking Setup**|
|11027|**Agreement Invoice Date**|
|11028|**Agreement Invoice Product**|
|11029|**Agreement Invoice Setup**|
|11032|**Booking Timestamp**|
|11043|**Incident Type Characteristic**|
|11044|**Incident Type Product**|
|11045|**Incident Type Service**|
|11049|**Inventory Adjustment**|
|11050|**Inventory Adjustment Product**|
|11051|**Inventory Journal**|
|11052|**Inventory Transfer**|
|11057|**Payment**|
|11058|**Payment Detail**|
|11059|**Payment Method**|
|11060|**Postal Code**|
|11061|**Product Inventory**|
|11062|**Purchase Order Bill**|
|11063|**Purchase Order SubStatus**|
|11064|**Quote Booking Incident**|
|11065|**Quote Booking Product**|
|11066|**Quote Booking Service**|
|11067|**Quote Booking Service Task**|
|11072|**RMA**|
|11073|**RMA Product**|
|11074|**RMA Receipt**|
|11075|**RMA Receipt Product**|
|11076|**RMA SubStatus**|
|11077|**RTV**|
|11078|**RTV Product**|
|11079|**RTV Substatus**|
|11081|**Time Off Request**|
|11083|**Work Order**|
|11084|**Work Order Characteristic (Deprecated)**|
|11086|**Work Order Incident**|
|11087|**Work Order Product**|
|11088|**Resource Restriction (Deprecated)**|
|11089|**Work Order Service**|
|11090|**Work Order Service Task**|
|11133|**Web Notification URL**|
|11134|**Web Page**|
|11136|**Website**|
|11141|**Alert Subscription**|
|11154|**Publishing State Transition Rule**|
|11156|**Shortcut**|
|11208|**Case Deflection**|
|11209|**Content Access Level**|
|11251|**Scheduling Optimization Request**|
|11301|**Outbound message**|
|11308|**Voicemail**|
|11377|**Appointment activity marketing template**|
|11380|**Content settings**|
|11396|**Dynamic-content metadata**|
|11398|**Marketing email dynamic-content metadata**|
|11402|**Marketing email test send**|
|11414|**Marketing activity**|
|11415|**Phone-call activity marketing template**|
|11421|**Task activity marketing template**|
|11422|**UIC config**|
|11434|**Lead Scoring Model**|
|11439|**LinkedIn Account**|
|11440|**LinkedIn Activity**|
|11443|**Field mapping**|
|11444|**LinkedIn Lead Gen Form**|
|11445|**LinkedIn Form Submission Answer**|
|11446|**LinkedIn Form Question**|
|11447|**LinkedIn Lead Gen Form Submission**|
|11448|**LinkedIn matching**|
|11449|**LinkedIn User Profile**|
|11603|**inMail**|
|11604|**Message**|
|11605|**Smart Links Content Viewed**|

## Many-to-One relationships

These relationships are many-to-one. Listed by **SchemaName**.

- [adx_alertsubscription_connections1](#BKMK_adx_alertsubscription_connections1)
- [adx_alertsubscription_connections2](#BKMK_adx_alertsubscription_connections2)
- [adx_casedeflection_connections1](#BKMK_adx_casedeflection_connections1)
- [adx_casedeflection_connections2](#BKMK_adx_casedeflection_connections2)
- [adx_contentaccesslevel_connections1](#BKMK_adx_contentaccesslevel_connections1)
- [adx_contentaccesslevel_connections2](#BKMK_adx_contentaccesslevel_connections2)
- [adx_publishingstatetransitionrule_connections1](#BKMK_adx_publishingstatetransitionrule_connections1)
- [adx_publishingstatetransitionrule_connections2](#BKMK_adx_publishingstatetransitionrule_connections2)
- [adx_shortcut_connections1](#BKMK_adx_shortcut_connections1)
- [adx_shortcut_connections2](#BKMK_adx_shortcut_connections2)
- [adx_webnotificationurl_connections1](#BKMK_adx_webnotificationurl_connections1)
- [adx_webnotificationurl_connections2](#BKMK_adx_webnotificationurl_connections2)
- [adx_webpage_connections1](#BKMK_adx_webpage_connections1)
- [adx_webpage_connections2](#BKMK_adx_webpage_connections2)
- [adx_website_connections1](#BKMK_adx_website_connections1)
- [adx_website_connections2](#BKMK_adx_website_connections2)
- [campaign_connections1](#BKMK_campaign_connections1)
- [campaign_connections2](#BKMK_campaign_connections2)
- [campaignactivity_connections1](#BKMK_campaignactivity_connections1)
- [campaignactivity_connections2](#BKMK_campaignactivity_connections2)
- [competitor_connections1](#BKMK_competitor_connections1)
- [competitor_connections2](#BKMK_competitor_connections2)
- [constraintbasedgroup_connections1](#BKMK_constraintbasedgroup_connections1)
- [constraintbasedgroup_connections2](#BKMK_constraintbasedgroup_connections2)
- [contract_connections1](#BKMK_contract_connections1)
- [contract_connections2](#BKMK_contract_connections2)
- [entitlement_connections1](#BKMK_entitlement_connections1)
- [entitlement_connections2](#BKMK_entitlement_connections2)
- [entitlementchannel_connections1](#BKMK_entitlementchannel_connections1)
- [entitlementchannel_connections2](#BKMK_entitlementchannel_connections2)
- [entitlementtemplatechannel_connections1](#BKMK_entitlementtemplatechannel_connections1)
- [entitlementtemplatechannel_connections2](#BKMK_entitlementtemplatechannel_connections2)
- [equipment_connections1](#BKMK_equipment_connections1)
- [equipment_connections2](#BKMK_equipment_connections2)
- [incident_connections1](#BKMK_incident_connections1)
- [incident_connections2](#BKMK_incident_connections2)
- [invoice_connections1](#BKMK_invoice_connections1)
- [invoice_connections2](#BKMK_invoice_connections2)
- [lead_connections1](#BKMK_lead_connections1)
- [lead_connections2](#BKMK_lead_connections2)
- [li_inmail_connections1](#BKMK_li_inmail_connections1)
- [li_inmail_connections2](#BKMK_li_inmail_connections2)
- [li_message_connections1](#BKMK_li_message_connections1)
- [li_message_connections2](#BKMK_li_message_connections2)
- [li_pointdrivepresentationviewed_connections1](#BKMK_li_pointdrivepresentationviewed_connections1)
- [li_pointdrivepresentationviewed_connections2](#BKMK_li_pointdrivepresentationviewed_connections2)
- [list_connections1](#BKMK_list_connections1)
- [list_connections2](#BKMK_list_connections2)
- [msdyn_agreement_connections1](#BKMK_msdyn_agreement_connections1)
- [msdyn_agreement_connections2](#BKMK_msdyn_agreement_connections2)
- [msdyn_agreementbookingdate_connections1](#BKMK_msdyn_agreementbookingdate_connections1)
- [msdyn_agreementbookingdate_connections2](#BKMK_msdyn_agreementbookingdate_connections2)
- [msdyn_agreementbookingincident_connections1](#BKMK_msdyn_agreementbookingincident_connections1)
- [msdyn_agreementbookingincident_connections2](#BKMK_msdyn_agreementbookingincident_connections2)
- [msdyn_agreementbookingproduct_connections1](#BKMK_msdyn_agreementbookingproduct_connections1)
- [msdyn_agreementbookingproduct_connections2](#BKMK_msdyn_agreementbookingproduct_connections2)
- [msdyn_agreementbookingservice_connections1](#BKMK_msdyn_agreementbookingservice_connections1)
- [msdyn_agreementbookingservice_connections2](#BKMK_msdyn_agreementbookingservice_connections2)
- [msdyn_agreementbookingservicetask_connections1](#BKMK_msdyn_agreementbookingservicetask_connections1)
- [msdyn_agreementbookingservicetask_connections2](#BKMK_msdyn_agreementbookingservicetask_connections2)
- [msdyn_agreementbookingsetup_connections1](#BKMK_msdyn_agreementbookingsetup_connections1)
- [msdyn_agreementbookingsetup_connections2](#BKMK_msdyn_agreementbookingsetup_connections2)
- [msdyn_agreementinvoicedate_connections1](#BKMK_msdyn_agreementinvoicedate_connections1)
- [msdyn_agreementinvoicedate_connections2](#BKMK_msdyn_agreementinvoicedate_connections2)
- [msdyn_agreementinvoiceproduct_connections1](#BKMK_msdyn_agreementinvoiceproduct_connections1)
- [msdyn_agreementinvoiceproduct_connections2](#BKMK_msdyn_agreementinvoiceproduct_connections2)
- [msdyn_agreementinvoicesetup_connections1](#BKMK_msdyn_agreementinvoicesetup_connections1)
- [msdyn_agreementinvoicesetup_connections2](#BKMK_msdyn_agreementinvoicesetup_connections2)
- [msdyn_assignmentmap_connections1](#BKMK_msdyn_assignmentmap_connections1)
- [msdyn_assignmentmap_connections2](#BKMK_msdyn_assignmentmap_connections2)
- [msdyn_assignmentrule_connections1](#BKMK_msdyn_assignmentrule_connections1)
- [msdyn_assignmentrule_connections2](#BKMK_msdyn_assignmentrule_connections2)
- [msdyn_bookingalert_connections1](#BKMK_msdyn_bookingalert_connections1)
- [msdyn_bookingalert_connections2](#BKMK_msdyn_bookingalert_connections2)
- [msdyn_bookingalertstatus_connections1](#BKMK_msdyn_bookingalertstatus_connections1)
- [msdyn_bookingalertstatus_connections2](#BKMK_msdyn_bookingalertstatus_connections2)
- [msdyn_bookingrule_connections1](#BKMK_msdyn_bookingrule_connections1)
- [msdyn_bookingrule_connections2](#BKMK_msdyn_bookingrule_connections2)
- [msdyn_bookingtimestamp_connections1](#BKMK_msdyn_bookingtimestamp_connections1)
- [msdyn_bookingtimestamp_connections2](#BKMK_msdyn_bookingtimestamp_connections2)
- [msdyn_copilottranscript_connections1](#BKMK_msdyn_copilottranscript_connections1)
- [msdyn_copilottranscript_connections2](#BKMK_msdyn_copilottranscript_connections2)
- [msdyn_customerasset_connections1](#BKMK_msdyn_customerasset_connections1)
- [msdyn_customerasset_connections2](#BKMK_msdyn_customerasset_connections2)
- [msdyn_incidenttypecharacteristic_connections1](#BKMK_msdyn_incidenttypecharacteristic_connections1)
- [msdyn_incidenttypecharacteristic_connections2](#BKMK_msdyn_incidenttypecharacteristic_connections2)
- [msdyn_incidenttypeproduct_connections1](#BKMK_msdyn_incidenttypeproduct_connections1)
- [msdyn_incidenttypeproduct_connections2](#BKMK_msdyn_incidenttypeproduct_connections2)
- [msdyn_incidenttypeservice_connections1](#BKMK_msdyn_incidenttypeservice_connections1)
- [msdyn_incidenttypeservice_connections2](#BKMK_msdyn_incidenttypeservice_connections2)
- [msdyn_inventoryadjustment_connections1](#BKMK_msdyn_inventoryadjustment_connections1)
- [msdyn_inventoryadjustment_connections2](#BKMK_msdyn_inventoryadjustment_connections2)
- [msdyn_inventoryadjustmentproduct_connections1](#BKMK_msdyn_inventoryadjustmentproduct_connections1)
- [msdyn_inventoryadjustmentproduct_connections2](#BKMK_msdyn_inventoryadjustmentproduct_connections2)
- [msdyn_inventoryjournal_connections1](#BKMK_msdyn_inventoryjournal_connections1)
- [msdyn_inventoryjournal_connections2](#BKMK_msdyn_inventoryjournal_connections2)
- [msdyn_inventorytransfer_connections1](#BKMK_msdyn_inventorytransfer_connections1)
- [msdyn_inventorytransfer_connections2](#BKMK_msdyn_inventorytransfer_connections2)
- [msdyn_iotalert_connections1](#BKMK_msdyn_iotalert_connections1)
- [msdyn_iotalert_connections2](#BKMK_msdyn_iotalert_connections2)
- [msdyn_iotdevice_connections1](#BKMK_msdyn_iotdevice_connections1)
- [msdyn_iotdevice_connections2](#BKMK_msdyn_iotdevice_connections2)
- [msdyn_iotdevicecategory_connections1](#BKMK_msdyn_iotdevicecategory_connections1)
- [msdyn_iotdevicecategory_connections2](#BKMK_msdyn_iotdevicecategory_connections2)
- [msdyn_iotdevicecommand_connections1](#BKMK_msdyn_iotdevicecommand_connections1)
- [msdyn_iotdevicecommand_connections2](#BKMK_msdyn_iotdevicecommand_connections2)
- [msdyn_iotdeviceregistrationhistory_connections1](#BKMK_msdyn_iotdeviceregistrationhistory_connections1)
- [msdyn_iotdeviceregistrationhistory_connections2](#BKMK_msdyn_iotdeviceregistrationhistory_connections2)
- [msdyn_liveconversation_connections1](#BKMK_msdyn_liveconversation_connections1)
- [msdyn_liveconversation_connections2](#BKMK_msdyn_liveconversation_connections2)
- [msdyn_ocliveworkitem_connections1](#BKMK_msdyn_ocliveworkitem_connections1)
- [msdyn_ocliveworkitem_connections2](#BKMK_msdyn_ocliveworkitem_connections2)
- [msdyn_ocoutboundmessage_connections1](#BKMK_msdyn_ocoutboundmessage_connections1)
- [msdyn_ocoutboundmessage_connections2](#BKMK_msdyn_ocoutboundmessage_connections2)
- [msdyn_ocsession_connections1](#BKMK_msdyn_ocsession_connections1)
- [msdyn_ocsession_connections2](#BKMK_msdyn_ocsession_connections2)
- [msdyn_ocvoicemail_connections1](#BKMK_msdyn_ocvoicemail_connections1)
- [msdyn_ocvoicemail_connections2](#BKMK_msdyn_ocvoicemail_connections2)
- [msdyn_payment_connections1](#BKMK_msdyn_payment_connections1)
- [msdyn_payment_connections2](#BKMK_msdyn_payment_connections2)
- [msdyn_paymentdetail_connections1](#BKMK_msdyn_paymentdetail_connections1)
- [msdyn_paymentdetail_connections2](#BKMK_msdyn_paymentdetail_connections2)
- [msdyn_paymentmethod_connections1](#BKMK_msdyn_paymentmethod_connections1)
- [msdyn_paymentmethod_connections2](#BKMK_msdyn_paymentmethod_connections2)
- [msdyn_paymentterm_connections1](#BKMK_msdyn_paymentterm_connections1)
- [msdyn_paymentterm_connections2](#BKMK_msdyn_paymentterm_connections2)
- [msdyn_postalbum_connections1](#BKMK_msdyn_postalbum_connections1)
- [msdyn_postalbum_connections2](#BKMK_msdyn_postalbum_connections2)
- [msdyn_postalcode_connections1](#BKMK_msdyn_postalcode_connections1)
- [msdyn_postalcode_connections2](#BKMK_msdyn_postalcode_connections2)
- [msdyn_productinventory_connections1](#BKMK_msdyn_productinventory_connections1)
- [msdyn_productinventory_connections2](#BKMK_msdyn_productinventory_connections2)
- [msdyn_purchaseorder_connections1](#BKMK_msdyn_purchaseorder_connections1)
- [msdyn_purchaseorder_connections2](#BKMK_msdyn_purchaseorder_connections2)
- [msdyn_purchaseorderbill_connections1](#BKMK_msdyn_purchaseorderbill_connections1)
- [msdyn_purchaseorderbill_connections2](#BKMK_msdyn_purchaseorderbill_connections2)
- [msdyn_purchaseorderproduct_connections1](#BKMK_msdyn_purchaseorderproduct_connections1)
- [msdyn_purchaseorderproduct_connections2](#BKMK_msdyn_purchaseorderproduct_connections2)
- [msdyn_purchaseorderreceipt_connections1](#BKMK_msdyn_purchaseorderreceipt_connections1)
- [msdyn_purchaseorderreceipt_connections2](#BKMK_msdyn_purchaseorderreceipt_connections2)
- [msdyn_purchaseorderreceiptproduct_connections1](#BKMK_msdyn_purchaseorderreceiptproduct_connections1)
- [msdyn_purchaseorderreceiptproduct_connections2](#BKMK_msdyn_purchaseorderreceiptproduct_connections2)
- [msdyn_purchaseordersubstatus_connections1](#BKMK_msdyn_purchaseordersubstatus_connections1)
- [msdyn_purchaseordersubstatus_connections2](#BKMK_msdyn_purchaseordersubstatus_connections2)
- [msdyn_quotebookingincident_connections1](#BKMK_msdyn_quotebookingincident_connections1)
- [msdyn_quotebookingincident_connections2](#BKMK_msdyn_quotebookingincident_connections2)
- [msdyn_quotebookingproduct_connections1](#BKMK_msdyn_quotebookingproduct_connections1)
- [msdyn_quotebookingproduct_connections2](#BKMK_msdyn_quotebookingproduct_connections2)
- [msdyn_quotebookingservice_connections1](#BKMK_msdyn_quotebookingservice_connections1)
- [msdyn_quotebookingservice_connections2](#BKMK_msdyn_quotebookingservice_connections2)
- [msdyn_quotebookingservicetask_connections1](#BKMK_msdyn_quotebookingservicetask_connections1)
- [msdyn_quotebookingservicetask_connections2](#BKMK_msdyn_quotebookingservicetask_connections2)
- [msdyn_resourceterritory_connections1](#BKMK_msdyn_resourceterritory_connections1)
- [msdyn_resourceterritory_connections2](#BKMK_msdyn_resourceterritory_connections2)
- [msdyn_rma_connections1](#BKMK_msdyn_rma_connections1)
- [msdyn_rma_connections2](#BKMK_msdyn_rma_connections2)
- [msdyn_rmaproduct_connections1](#BKMK_msdyn_rmaproduct_connections1)
- [msdyn_rmaproduct_connections2](#BKMK_msdyn_rmaproduct_connections2)
- [msdyn_rmareceipt_connections1](#BKMK_msdyn_rmareceipt_connections1)
- [msdyn_rmareceipt_connections2](#BKMK_msdyn_rmareceipt_connections2)
- [msdyn_rmareceiptproduct_connections1](#BKMK_msdyn_rmareceiptproduct_connections1)
- [msdyn_rmareceiptproduct_connections2](#BKMK_msdyn_rmareceiptproduct_connections2)
- [msdyn_rmasubstatus_connections1](#BKMK_msdyn_rmasubstatus_connections1)
- [msdyn_rmasubstatus_connections2](#BKMK_msdyn_rmasubstatus_connections2)
- [msdyn_routingoptimizationrequest_connections1](#BKMK_msdyn_routingoptimizationrequest_connections1)
- [msdyn_routingoptimizationrequest_connections2](#BKMK_msdyn_routingoptimizationrequest_connections2)
- [msdyn_rtv_connections1](#BKMK_msdyn_rtv_connections1)
- [msdyn_rtv_connections2](#BKMK_msdyn_rtv_connections2)
- [msdyn_rtvproduct_connections1](#BKMK_msdyn_rtvproduct_connections1)
- [msdyn_rtvproduct_connections2](#BKMK_msdyn_rtvproduct_connections2)
- [msdyn_rtvsubstatus_connections1](#BKMK_msdyn_rtvsubstatus_connections1)
- [msdyn_rtvsubstatus_connections2](#BKMK_msdyn_rtvsubstatus_connections2)
- [msdyn_salessuggestion_connections1](#BKMK_msdyn_salessuggestion_connections1)
- [msdyn_salessuggestion_connections2](#BKMK_msdyn_salessuggestion_connections2)
- [msdyn_sequence_connections1](#BKMK_msdyn_sequence_connections1)
- [msdyn_sequence_connections2](#BKMK_msdyn_sequence_connections2)
- [msdyn_sequencetarget_connections1](#BKMK_msdyn_sequencetarget_connections1)
- [msdyn_sequencetarget_connections2](#BKMK_msdyn_sequencetarget_connections2)
- [msdyn_shipvia_connections1](#BKMK_msdyn_shipvia_connections1)
- [msdyn_shipvia_connections2](#BKMK_msdyn_shipvia_connections2)
- [msdyn_suggestionprincipalobjectaccess_connections1](#BKMK_msdyn_suggestionprincipalobjectaccess_connections1)
- [msdyn_suggestionprincipalobjectaccess_connections2](#BKMK_msdyn_suggestionprincipalobjectaccess_connections2)
- [msdyn_systemuserschedulersetting_connections1](#BKMK_msdyn_systemuserschedulersetting_connections1)
- [msdyn_systemuserschedulersetting_connections2](#BKMK_msdyn_systemuserschedulersetting_connections2)
- [msdyn_taxcode_connections1](#BKMK_msdyn_taxcode_connections1)
- [msdyn_taxcode_connections2](#BKMK_msdyn_taxcode_connections2)
- [msdyn_timegroup_connections1](#BKMK_msdyn_timegroup_connections1)
- [msdyn_timegroup_connections2](#BKMK_msdyn_timegroup_connections2)
- [msdyn_timegroupdetail_connections1](#BKMK_msdyn_timegroupdetail_connections1)
- [msdyn_timegroupdetail_connections2](#BKMK_msdyn_timegroupdetail_connections2)
- [msdyn_timeoffrequest_connections1](#BKMK_msdyn_timeoffrequest_connections1)
- [msdyn_timeoffrequest_connections2](#BKMK_msdyn_timeoffrequest_connections2)
- [msdyn_warehouse_connections1](#BKMK_msdyn_warehouse_connections1)
- [msdyn_warehouse_connections2](#BKMK_msdyn_warehouse_connections2)
- [msdyn_workorder_connections1](#BKMK_msdyn_workorder_connections1)
- [msdyn_workorder_connections2](#BKMK_msdyn_workorder_connections2)
- [msdyn_workordercharacteristic_connections1](#BKMK_msdyn_workordercharacteristic_connections1)
- [msdyn_workordercharacteristic_connections2](#BKMK_msdyn_workordercharacteristic_connections2)
- [msdyn_workorderincident_connections1](#BKMK_msdyn_workorderincident_connections1)
- [msdyn_workorderincident_connections2](#BKMK_msdyn_workorderincident_connections2)
- [msdyn_workorderproduct_connections1](#BKMK_msdyn_workorderproduct_connections1)
- [msdyn_workorderproduct_connections2](#BKMK_msdyn_workorderproduct_connections2)
- [msdyn_workorderresourcerestriction_connections1](#BKMK_msdyn_workorderresourcerestriction_connections1)
- [msdyn_workorderresourcerestriction_connections2](#BKMK_msdyn_workorderresourcerestriction_connections2)
- [msdyn_workorderservice_connections1](#BKMK_msdyn_workorderservice_connections1)
- [msdyn_workorderservice_connections2](#BKMK_msdyn_workorderservice_connections2)
- [msdyn_workorderservicetask_connections1](#BKMK_msdyn_workorderservicetask_connections1)
- [msdyn_workorderservicetask_connections2](#BKMK_msdyn_workorderservicetask_connections2)
- [msdyncrm_appointmentactivitymarketingtemplate_connections1](#BKMK_msdyncrm_appointmentactivitymarketingtemplate_connections1)
- [msdyncrm_appointmentactivitymarketingtemplate_connections2](#BKMK_msdyncrm_appointmentactivitymarketingtemplate_connections2)
- [msdyncrm_contentsettings_connections1](#BKMK_msdyncrm_contentsettings_connections1)
- [msdyncrm_contentsettings_connections2](#BKMK_msdyncrm_contentsettings_connections2)
- [msdyncrm_leadscoremodel_connections1](#BKMK_msdyncrm_leadscoremodel_connections1)
- [msdyncrm_leadscoremodel_connections2](#BKMK_msdyncrm_leadscoremodel_connections2)
- [msdyncrm_linkedinaccount_connections1](#BKMK_msdyncrm_linkedinaccount_connections1)
- [msdyncrm_linkedinaccount_connections2](#BKMK_msdyncrm_linkedinaccount_connections2)
- [msdyncrm_linkedinactivity_connections1](#BKMK_msdyncrm_linkedinactivity_connections1)
- [msdyncrm_linkedinactivity_connections2](#BKMK_msdyncrm_linkedinactivity_connections2)
- [msdyncrm_linkedinfieldmapping_connections1](#BKMK_msdyncrm_linkedinfieldmapping_connections1)
- [msdyncrm_linkedinfieldmapping_connections2](#BKMK_msdyncrm_linkedinfieldmapping_connections2)
- [msdyncrm_linkedinform_connections1](#BKMK_msdyncrm_linkedinform_connections1)
- [msdyncrm_linkedinform_connections2](#BKMK_msdyncrm_linkedinform_connections2)
- [msdyncrm_linkedinformanswer_connections1](#BKMK_msdyncrm_linkedinformanswer_connections1)
- [msdyncrm_linkedinformanswer_connections2](#BKMK_msdyncrm_linkedinformanswer_connections2)
- [msdyncrm_linkedinformquestion_connections1](#BKMK_msdyncrm_linkedinformquestion_connections1)
- [msdyncrm_linkedinformquestion_connections2](#BKMK_msdyncrm_linkedinformquestion_connections2)
- [msdyncrm_linkedinformsubmission_connections1](#BKMK_msdyncrm_linkedinformsubmission_connections1)
- [msdyncrm_linkedinformsubmission_connections2](#BKMK_msdyncrm_linkedinformsubmission_connections2)
- [msdyncrm_linkedinleadmatchingstrategy_connections1](#BKMK_msdyncrm_linkedinleadmatchingstrategy_connections1)
- [msdyncrm_linkedinleadmatchingstrategy_connections2](#BKMK_msdyncrm_linkedinleadmatchingstrategy_connections2)
- [msdyncrm_linkedinuserprofile_connections1](#BKMK_msdyncrm_linkedinuserprofile_connections1)
- [msdyncrm_linkedinuserprofile_connections2](#BKMK_msdyncrm_linkedinuserprofile_connections2)
- [msdyncrm_marketingdynamiccontentmetadata_connections1](#BKMK_msdyncrm_marketingdynamiccontentmetadata_connections1)
- [msdyncrm_marketingdynamiccontentmetadata_connections2](#BKMK_msdyncrm_marketingdynamiccontentmetadata_connections2)
- [msdyncrm_marketingemaildynamiccontentmetadata_connections1](#BKMK_msdyncrm_marketingemaildynamiccontentmetadata_connections1)
- [msdyncrm_marketingemaildynamiccontentmetadata_connections2](#BKMK_msdyncrm_marketingemaildynamiccontentmetadata_connections2)
- [msdyncrm_marketingemailtestsend_connections1](#BKMK_msdyncrm_marketingemailtestsend_connections1)
- [msdyncrm_marketingemailtestsend_connections2](#BKMK_msdyncrm_marketingemailtestsend_connections2)
- [msdyncrm_mktactivity_connections1](#BKMK_msdyncrm_mktactivity_connections1)
- [msdyncrm_mktactivity_connections2](#BKMK_msdyncrm_mktactivity_connections2)
- [msdyncrm_phonecallactivitymarketingtemplate_connections1](#BKMK_msdyncrm_phonecallactivitymarketingtemplate_connections1)
- [msdyncrm_phonecallactivitymarketingtemplate_connections2](#BKMK_msdyncrm_phonecallactivitymarketingtemplate_connections2)
- [msdyncrm_taskactivitymarketingtemplate_connections1](#BKMK_msdyncrm_taskactivitymarketingtemplate_connections1)
- [msdyncrm_taskactivitymarketingtemplate_connections2](#BKMK_msdyncrm_taskactivitymarketingtemplate_connections2)
- [msdyncrm_uicconfig_connections1](#BKMK_msdyncrm_uicconfig_connections1)
- [msdyncrm_uicconfig_connections2](#BKMK_msdyncrm_uicconfig_connections2)
- [msfp_alert_connections1](#BKMK_msfp_alert_connections1)
- [msfp_alert_connections2](#BKMK_msfp_alert_connections2)
- [msfp_surveyinvite_connections1](#BKMK_msfp_surveyinvite_connections1)
- [msfp_surveyinvite_connections2](#BKMK_msfp_surveyinvite_connections2)
- [msfp_surveyresponse_connections1](#BKMK_msfp_surveyresponse_connections1)
- [msfp_surveyresponse_connections2](#BKMK_msfp_surveyresponse_connections2)
- [opportunity_connections1](#BKMK_opportunity_connections1)
- [opportunity_connections2](#BKMK_opportunity_connections2)
- [pricelevel_connections1](#BKMK_pricelevel_connections1)
- [pricelevel_connections2](#BKMK_pricelevel_connections2)
- [product_connections1](#BKMK_product_connections1)
- [product_connections2](#BKMK_product_connections2)
- [quote_connections1](#BKMK_quote_connections1)
- [quote_connections2](#BKMK_quote_connections2)
- [resourcegroup_connections1](#BKMK_resourcegroup_connections1)
- [resourcegroup_connections2](#BKMK_resourcegroup_connections2)
- [salesorder_connections1](#BKMK_salesorder_connections1)
- [salesorder_connections2](#BKMK_salesorder_connections2)
- [serviceappointment_connections1](#BKMK_serviceappointment_connections1)
- [serviceappointment_connections2](#BKMK_serviceappointment_connections2)

### <a name="BKMK_adx_alertsubscription_connections1"></a> adx_alertsubscription_connections1

One-To-Many Relationship: [adx_alertsubscription adx_alertsubscription_connections1](adx_alertsubscription.md#BKMK_adx_alertsubscription_connections1)

|Property|Value|
|---|---|
|ReferencedEntity|`adx_alertsubscription`|
|ReferencedAttribute|`activityid`|
|ReferencingAttribute|`record1id`|
|ReferencingEntityNavigationPropertyName|`record1id_adx_alertsubscription`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_adx_alertsubscription_connections2"></a> adx_alertsubscription_connections2

One-To-Many Relationship: [adx_alertsubscription adx_alertsubscription_connections2](adx_alertsubscription.md#BKMK_adx_alertsubscription_connections2)

|Property|Value|
|---|---|
|ReferencedEntity|`adx_alertsubscription`|
|ReferencedAttribute|`activityid`|
|ReferencingAttribute|`record2id`|
|ReferencingEntityNavigationPropertyName|`record2id_adx_alertsubscription`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_adx_casedeflection_connections1"></a> adx_casedeflection_connections1

One-To-Many Relationship: [adx_casedeflection adx_casedeflection_connections1](adx_casedeflection.md#BKMK_adx_casedeflection_connections1)

|Property|Value|
|---|---|
|ReferencedEntity|`adx_casedeflection`|
|ReferencedAttribute|`adx_casedeflectionid`|
|ReferencingAttribute|`record1id`|
|ReferencingEntityNavigationPropertyName|`record1id_adx_casedeflection`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_adx_casedeflection_connections2"></a> adx_casedeflection_connections2

One-To-Many Relationship: [adx_casedeflection adx_casedeflection_connections2](adx_casedeflection.md#BKMK_adx_casedeflection_connections2)

|Property|Value|
|---|---|
|ReferencedEntity|`adx_casedeflection`|
|ReferencedAttribute|`adx_casedeflectionid`|
|ReferencingAttribute|`record2id`|
|ReferencingEntityNavigationPropertyName|`record2id_adx_casedeflection`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_adx_contentaccesslevel_connections1"></a> adx_contentaccesslevel_connections1

One-To-Many Relationship: [adx_contentaccesslevel adx_contentaccesslevel_connections1](adx_contentaccesslevel.md#BKMK_adx_contentaccesslevel_connections1)

|Property|Value|
|---|---|
|ReferencedEntity|`adx_contentaccesslevel`|
|ReferencedAttribute|`adx_contentaccesslevelid`|
|ReferencingAttribute|`record1id`|
|ReferencingEntityNavigationPropertyName|`record1id_adx_contentaccesslevel`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_adx_contentaccesslevel_connections2"></a> adx_contentaccesslevel_connections2

One-To-Many Relationship: [adx_contentaccesslevel adx_contentaccesslevel_connections2](adx_contentaccesslevel.md#BKMK_adx_contentaccesslevel_connections2)

|Property|Value|
|---|---|
|ReferencedEntity|`adx_contentaccesslevel`|
|ReferencedAttribute|`adx_contentaccesslevelid`|
|ReferencingAttribute|`record2id`|
|ReferencingEntityNavigationPropertyName|`record2id_adx_contentaccesslevel`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_adx_publishingstatetransitionrule_connections1"></a> adx_publishingstatetransitionrule_connections1

One-To-Many Relationship: [adx_publishingstatetransitionrule adx_publishingstatetransitionrule_connections1](adx_publishingstatetransitionrule.md#BKMK_adx_publishingstatetransitionrule_connections1)

|Property|Value|
|---|---|
|ReferencedEntity|`adx_publishingstatetransitionrule`|
|ReferencedAttribute|`adx_publishingstatetransitionruleid`|
|ReferencingAttribute|`record1id`|
|ReferencingEntityNavigationPropertyName|`record1id_adx_publishingstatetransitionrule`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_adx_publishingstatetransitionrule_connections2"></a> adx_publishingstatetransitionrule_connections2

One-To-Many Relationship: [adx_publishingstatetransitionrule adx_publishingstatetransitionrule_connections2](adx_publishingstatetransitionrule.md#BKMK_adx_publishingstatetransitionrule_connections2)

|Property|Value|
|---|---|
|ReferencedEntity|`adx_publishingstatetransitionrule`|
|ReferencedAttribute|`adx_publishingstatetransitionruleid`|
|ReferencingAttribute|`record2id`|
|ReferencingEntityNavigationPropertyName|`record2id_adx_publishingstatetransitionrule`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_adx_shortcut_connections1"></a> adx_shortcut_connections1

One-To-Many Relationship: [adx_shortcut adx_shortcut_connections1](adx_shortcut.md#BKMK_adx_shortcut_connections1)

|Property|Value|
|---|---|
|ReferencedEntity|`adx_shortcut`|
|ReferencedAttribute|`adx_shortcutid`|
|ReferencingAttribute|`record1id`|
|ReferencingEntityNavigationPropertyName|`record1id_adx_shortcut`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_adx_shortcut_connections2"></a> adx_shortcut_connections2

One-To-Many Relationship: [adx_shortcut adx_shortcut_connections2](adx_shortcut.md#BKMK_adx_shortcut_connections2)

|Property|Value|
|---|---|
|ReferencedEntity|`adx_shortcut`|
|ReferencedAttribute|`adx_shortcutid`|
|ReferencingAttribute|`record2id`|
|ReferencingEntityNavigationPropertyName|`record2id_adx_shortcut`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_adx_webnotificationurl_connections1"></a> adx_webnotificationurl_connections1

One-To-Many Relationship: [adx_webnotificationurl adx_webnotificationurl_connections1](adx_webnotificationurl.md#BKMK_adx_webnotificationurl_connections1)

|Property|Value|
|---|---|
|ReferencedEntity|`adx_webnotificationurl`|
|ReferencedAttribute|`adx_webnotificationurlid`|
|ReferencingAttribute|`record1id`|
|ReferencingEntityNavigationPropertyName|`record1id_adx_webnotificationurl`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_adx_webnotificationurl_connections2"></a> adx_webnotificationurl_connections2

One-To-Many Relationship: [adx_webnotificationurl adx_webnotificationurl_connections2](adx_webnotificationurl.md#BKMK_adx_webnotificationurl_connections2)

|Property|Value|
|---|---|
|ReferencedEntity|`adx_webnotificationurl`|
|ReferencedAttribute|`adx_webnotificationurlid`|
|ReferencingAttribute|`record2id`|
|ReferencingEntityNavigationPropertyName|`record2id_adx_webnotificationurl`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_adx_webpage_connections1"></a> adx_webpage_connections1

One-To-Many Relationship: [adx_webpage adx_webpage_connections1](adx_webpage.md#BKMK_adx_webpage_connections1)

|Property|Value|
|---|---|
|ReferencedEntity|`adx_webpage`|
|ReferencedAttribute|`adx_webpageid`|
|ReferencingAttribute|`record1id`|
|ReferencingEntityNavigationPropertyName|`record1id_adx_webpage`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_adx_webpage_connections2"></a> adx_webpage_connections2

One-To-Many Relationship: [adx_webpage adx_webpage_connections2](adx_webpage.md#BKMK_adx_webpage_connections2)

|Property|Value|
|---|---|
|ReferencedEntity|`adx_webpage`|
|ReferencedAttribute|`adx_webpageid`|
|ReferencingAttribute|`record2id`|
|ReferencingEntityNavigationPropertyName|`record2id_adx_webpage`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_adx_website_connections1"></a> adx_website_connections1

One-To-Many Relationship: [adx_website adx_website_connections1](adx_website.md#BKMK_adx_website_connections1)

|Property|Value|
|---|---|
|ReferencedEntity|`adx_website`|
|ReferencedAttribute|`adx_websiteid`|
|ReferencingAttribute|`record1id`|
|ReferencingEntityNavigationPropertyName|`record1id_adx_website`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_adx_website_connections2"></a> adx_website_connections2

One-To-Many Relationship: [adx_website adx_website_connections2](adx_website.md#BKMK_adx_website_connections2)

|Property|Value|
|---|---|
|ReferencedEntity|`adx_website`|
|ReferencedAttribute|`adx_websiteid`|
|ReferencingAttribute|`record2id`|
|ReferencingEntityNavigationPropertyName|`record2id_adx_website`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_campaign_connections1"></a> campaign_connections1

One-To-Many Relationship: [campaign campaign_connections1](campaign.md#BKMK_campaign_connections1)

|Property|Value|
|---|---|
|ReferencedEntity|`campaign`|
|ReferencedAttribute|`campaignid`|
|ReferencingAttribute|`record1id`|
|ReferencingEntityNavigationPropertyName|`record1id_campaign`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_campaign_connections2"></a> campaign_connections2

One-To-Many Relationship: [campaign campaign_connections2](campaign.md#BKMK_campaign_connections2)

|Property|Value|
|---|---|
|ReferencedEntity|`campaign`|
|ReferencedAttribute|`campaignid`|
|ReferencingAttribute|`record2id`|
|ReferencingEntityNavigationPropertyName|`record2id_campaign`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_campaignactivity_connections1"></a> campaignactivity_connections1

One-To-Many Relationship: [campaignactivity campaignactivity_connections1](campaignactivity.md#BKMK_campaignactivity_connections1)

|Property|Value|
|---|---|
|ReferencedEntity|`campaignactivity`|
|ReferencedAttribute|`activityid`|
|ReferencingAttribute|`record1id`|
|ReferencingEntityNavigationPropertyName|`record1id_campaignactivity`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_campaignactivity_connections2"></a> campaignactivity_connections2

One-To-Many Relationship: [campaignactivity campaignactivity_connections2](campaignactivity.md#BKMK_campaignactivity_connections2)

|Property|Value|
|---|---|
|ReferencedEntity|`campaignactivity`|
|ReferencedAttribute|`activityid`|
|ReferencingAttribute|`record2id`|
|ReferencingEntityNavigationPropertyName|`record2id_campaignactivity`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_competitor_connections1"></a> competitor_connections1

One-To-Many Relationship: [competitor competitor_connections1](competitor.md#BKMK_competitor_connections1)

|Property|Value|
|---|---|
|ReferencedEntity|`competitor`|
|ReferencedAttribute|`competitorid`|
|ReferencingAttribute|`record1id`|
|ReferencingEntityNavigationPropertyName|`record1id_competitor`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_competitor_connections2"></a> competitor_connections2

One-To-Many Relationship: [competitor competitor_connections2](competitor.md#BKMK_competitor_connections2)

|Property|Value|
|---|---|
|ReferencedEntity|`competitor`|
|ReferencedAttribute|`competitorid`|
|ReferencingAttribute|`record2id`|
|ReferencingEntityNavigationPropertyName|`record2id_competitor`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_constraintbasedgroup_connections1"></a> constraintbasedgroup_connections1

One-To-Many Relationship: [constraintbasedgroup constraintbasedgroup_connections1](constraintbasedgroup.md#BKMK_constraintbasedgroup_connections1)

|Property|Value|
|---|---|
|ReferencedEntity|`constraintbasedgroup`|
|ReferencedAttribute|`constraintbasedgroupid`|
|ReferencingAttribute|`record1id`|
|ReferencingEntityNavigationPropertyName|`record1id_constraintbasedgroup`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_constraintbasedgroup_connections2"></a> constraintbasedgroup_connections2

One-To-Many Relationship: [constraintbasedgroup constraintbasedgroup_connections2](constraintbasedgroup.md#BKMK_constraintbasedgroup_connections2)

|Property|Value|
|---|---|
|ReferencedEntity|`constraintbasedgroup`|
|ReferencedAttribute|`constraintbasedgroupid`|
|ReferencingAttribute|`record2id`|
|ReferencingEntityNavigationPropertyName|`record2id_constraintbasedgroup`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_contract_connections1"></a> contract_connections1

One-To-Many Relationship: [contract contract_connections1](contract.md#BKMK_contract_connections1)

|Property|Value|
|---|---|
|ReferencedEntity|`contract`|
|ReferencedAttribute|`contractid`|
|ReferencingAttribute|`record1id`|
|ReferencingEntityNavigationPropertyName|`record1id_contract`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_contract_connections2"></a> contract_connections2

One-To-Many Relationship: [contract contract_connections2](contract.md#BKMK_contract_connections2)

|Property|Value|
|---|---|
|ReferencedEntity|`contract`|
|ReferencedAttribute|`contractid`|
|ReferencingAttribute|`record2id`|
|ReferencingEntityNavigationPropertyName|`record2id_contract`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_entitlement_connections1"></a> entitlement_connections1

One-To-Many Relationship: [entitlement entitlement_connections1](entitlement.md#BKMK_entitlement_connections1)

|Property|Value|
|---|---|
|ReferencedEntity|`entitlement`|
|ReferencedAttribute|`entitlementid`|
|ReferencingAttribute|`record1id`|
|ReferencingEntityNavigationPropertyName|`record1id_entitlement`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_entitlement_connections2"></a> entitlement_connections2

One-To-Many Relationship: [entitlement entitlement_connections2](entitlement.md#BKMK_entitlement_connections2)

|Property|Value|
|---|---|
|ReferencedEntity|`entitlement`|
|ReferencedAttribute|`entitlementid`|
|ReferencingAttribute|`record2id`|
|ReferencingEntityNavigationPropertyName|`record2id_entitlement`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_entitlementchannel_connections1"></a> entitlementchannel_connections1

One-To-Many Relationship: [entitlementchannel entitlementchannel_connections1](entitlementchannel.md#BKMK_entitlementchannel_connections1)

|Property|Value|
|---|---|
|ReferencedEntity|`entitlementchannel`|
|ReferencedAttribute|`entitlementchannelid`|
|ReferencingAttribute|`record1id`|
|ReferencingEntityNavigationPropertyName|`record1id_entitlementchannel`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_entitlementchannel_connections2"></a> entitlementchannel_connections2

One-To-Many Relationship: [entitlementchannel entitlementchannel_connections2](entitlementchannel.md#BKMK_entitlementchannel_connections2)

|Property|Value|
|---|---|
|ReferencedEntity|`entitlementchannel`|
|ReferencedAttribute|`entitlementchannelid`|
|ReferencingAttribute|`record2id`|
|ReferencingEntityNavigationPropertyName|`record2id_entitlementchannel`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_entitlementtemplatechannel_connections1"></a> entitlementtemplatechannel_connections1

One-To-Many Relationship: [entitlementtemplatechannel entitlementtemplatechannel_connections1](entitlementtemplatechannel.md#BKMK_entitlementtemplatechannel_connections1)

|Property|Value|
|---|---|
|ReferencedEntity|`entitlementtemplatechannel`|
|ReferencedAttribute|`entitlementtemplatechannelid`|
|ReferencingAttribute|`record1id`|
|ReferencingEntityNavigationPropertyName|`record1id_entitlementtemplatechannel`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_entitlementtemplatechannel_connections2"></a> entitlementtemplatechannel_connections2

One-To-Many Relationship: [entitlementtemplatechannel entitlementtemplatechannel_connections2](entitlementtemplatechannel.md#BKMK_entitlementtemplatechannel_connections2)

|Property|Value|
|---|---|
|ReferencedEntity|`entitlementtemplatechannel`|
|ReferencedAttribute|`entitlementtemplatechannelid`|
|ReferencingAttribute|`record2id`|
|ReferencingEntityNavigationPropertyName|`record2id_entitlementtemplatechannel`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_equipment_connections1"></a> equipment_connections1

One-To-Many Relationship: [equipment equipment_connections1](equipment.md#BKMK_equipment_connections1)

|Property|Value|
|---|---|
|ReferencedEntity|`equipment`|
|ReferencedAttribute|`equipmentid`|
|ReferencingAttribute|`record1id`|
|ReferencingEntityNavigationPropertyName|`record1id_equipment`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_equipment_connections2"></a> equipment_connections2

One-To-Many Relationship: [equipment equipment_connections2](equipment.md#BKMK_equipment_connections2)

|Property|Value|
|---|---|
|ReferencedEntity|`equipment`|
|ReferencedAttribute|`equipmentid`|
|ReferencingAttribute|`record2id`|
|ReferencingEntityNavigationPropertyName|`record2id_equipment`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_incident_connections1"></a> incident_connections1

One-To-Many Relationship: [incident incident_connections1](incident.md#BKMK_incident_connections1)

|Property|Value|
|---|---|
|ReferencedEntity|`incident`|
|ReferencedAttribute|`incidentid`|
|ReferencingAttribute|`record1id`|
|ReferencingEntityNavigationPropertyName|`record1id_incident`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_incident_connections2"></a> incident_connections2

One-To-Many Relationship: [incident incident_connections2](incident.md#BKMK_incident_connections2)

|Property|Value|
|---|---|
|ReferencedEntity|`incident`|
|ReferencedAttribute|`incidentid`|
|ReferencingAttribute|`record2id`|
|ReferencingEntityNavigationPropertyName|`record2id_incident`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_invoice_connections1"></a> invoice_connections1

One-To-Many Relationship: [invoice invoice_connections1](invoice.md#BKMK_invoice_connections1)

|Property|Value|
|---|---|
|ReferencedEntity|`invoice`|
|ReferencedAttribute|`invoiceid`|
|ReferencingAttribute|`record1id`|
|ReferencingEntityNavigationPropertyName|`record1id_invoice`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_invoice_connections2"></a> invoice_connections2

One-To-Many Relationship: [invoice invoice_connections2](invoice.md#BKMK_invoice_connections2)

|Property|Value|
|---|---|
|ReferencedEntity|`invoice`|
|ReferencedAttribute|`invoiceid`|
|ReferencingAttribute|`record2id`|
|ReferencingEntityNavigationPropertyName|`record2id_invoice`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lead_connections1"></a> lead_connections1

One-To-Many Relationship: [lead lead_connections1](lead.md#BKMK_lead_connections1)

|Property|Value|
|---|---|
|ReferencedEntity|`lead`|
|ReferencedAttribute|`leadid`|
|ReferencingAttribute|`record1id`|
|ReferencingEntityNavigationPropertyName|`record1id_lead`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `Cascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lead_connections2"></a> lead_connections2

One-To-Many Relationship: [lead lead_connections2](lead.md#BKMK_lead_connections2)

|Property|Value|
|---|---|
|ReferencedEntity|`lead`|
|ReferencedAttribute|`leadid`|
|ReferencingAttribute|`record2id`|
|ReferencingEntityNavigationPropertyName|`record2id_lead`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `Cascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_li_inmail_connections1"></a> li_inmail_connections1

One-To-Many Relationship: [li_inmail li_inmail_connections1](li_inmail.md#BKMK_li_inmail_connections1)

|Property|Value|
|---|---|
|ReferencedEntity|`li_inmail`|
|ReferencedAttribute|`activityid`|
|ReferencingAttribute|`record1id`|
|ReferencingEntityNavigationPropertyName|`record1id_li_inmail`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_li_inmail_connections2"></a> li_inmail_connections2

One-To-Many Relationship: [li_inmail li_inmail_connections2](li_inmail.md#BKMK_li_inmail_connections2)

|Property|Value|
|---|---|
|ReferencedEntity|`li_inmail`|
|ReferencedAttribute|`activityid`|
|ReferencingAttribute|`record2id`|
|ReferencingEntityNavigationPropertyName|`record2id_li_inmail`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_li_message_connections1"></a> li_message_connections1

One-To-Many Relationship: [li_message li_message_connections1](li_message.md#BKMK_li_message_connections1)

|Property|Value|
|---|---|
|ReferencedEntity|`li_message`|
|ReferencedAttribute|`activityid`|
|ReferencingAttribute|`record1id`|
|ReferencingEntityNavigationPropertyName|`record1id_li_message`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_li_message_connections2"></a> li_message_connections2

One-To-Many Relationship: [li_message li_message_connections2](li_message.md#BKMK_li_message_connections2)

|Property|Value|
|---|---|
|ReferencedEntity|`li_message`|
|ReferencedAttribute|`activityid`|
|ReferencingAttribute|`record2id`|
|ReferencingEntityNavigationPropertyName|`record2id_li_message`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_li_pointdrivepresentationviewed_connections1"></a> li_pointdrivepresentationviewed_connections1

One-To-Many Relationship: [li_pointdrivepresentationviewed li_pointdrivepresentationviewed_connections1](li_pointdrivepresentationviewed.md#BKMK_li_pointdrivepresentationviewed_connections1)

|Property|Value|
|---|---|
|ReferencedEntity|`li_pointdrivepresentationviewed`|
|ReferencedAttribute|`activityid`|
|ReferencingAttribute|`record1id`|
|ReferencingEntityNavigationPropertyName|`record1id_li_pointdrivepresentationviewed`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_li_pointdrivepresentationviewed_connections2"></a> li_pointdrivepresentationviewed_connections2

One-To-Many Relationship: [li_pointdrivepresentationviewed li_pointdrivepresentationviewed_connections2](li_pointdrivepresentationviewed.md#BKMK_li_pointdrivepresentationviewed_connections2)

|Property|Value|
|---|---|
|ReferencedEntity|`li_pointdrivepresentationviewed`|
|ReferencedAttribute|`activityid`|
|ReferencingAttribute|`record2id`|
|ReferencingEntityNavigationPropertyName|`record2id_li_pointdrivepresentationviewed`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_list_connections1"></a> list_connections1

One-To-Many Relationship: [list list_connections1](list.md#BKMK_list_connections1)

|Property|Value|
|---|---|
|ReferencedEntity|`list`|
|ReferencedAttribute|`listid`|
|ReferencingAttribute|`record1id`|
|ReferencingEntityNavigationPropertyName|`record1id_list`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_list_connections2"></a> list_connections2

One-To-Many Relationship: [list list_connections2](list.md#BKMK_list_connections2)

|Property|Value|
|---|---|
|ReferencedEntity|`list`|
|ReferencedAttribute|`listid`|
|ReferencingAttribute|`record2id`|
|ReferencingEntityNavigationPropertyName|`record2id_list`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_agreement_connections1"></a> msdyn_agreement_connections1

One-To-Many Relationship: [msdyn_agreement msdyn_agreement_connections1](msdyn_agreement.md#BKMK_msdyn_agreement_connections1)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_agreement`|
|ReferencedAttribute|`msdyn_agreementid`|
|ReferencingAttribute|`record1id`|
|ReferencingEntityNavigationPropertyName|`record1id_msdyn_agreement`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_agreement_connections2"></a> msdyn_agreement_connections2

One-To-Many Relationship: [msdyn_agreement msdyn_agreement_connections2](msdyn_agreement.md#BKMK_msdyn_agreement_connections2)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_agreement`|
|ReferencedAttribute|`msdyn_agreementid`|
|ReferencingAttribute|`record2id`|
|ReferencingEntityNavigationPropertyName|`record2id_msdyn_agreement`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_agreementbookingdate_connections1"></a> msdyn_agreementbookingdate_connections1

One-To-Many Relationship: [msdyn_agreementbookingdate msdyn_agreementbookingdate_connections1](msdyn_agreementbookingdate.md#BKMK_msdyn_agreementbookingdate_connections1)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_agreementbookingdate`|
|ReferencedAttribute|`msdyn_agreementbookingdateid`|
|ReferencingAttribute|`record1id`|
|ReferencingEntityNavigationPropertyName|`record1id_msdyn_agreementbookingdate`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_agreementbookingdate_connections2"></a> msdyn_agreementbookingdate_connections2

One-To-Many Relationship: [msdyn_agreementbookingdate msdyn_agreementbookingdate_connections2](msdyn_agreementbookingdate.md#BKMK_msdyn_agreementbookingdate_connections2)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_agreementbookingdate`|
|ReferencedAttribute|`msdyn_agreementbookingdateid`|
|ReferencingAttribute|`record2id`|
|ReferencingEntityNavigationPropertyName|`record2id_msdyn_agreementbookingdate`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_agreementbookingincident_connections1"></a> msdyn_agreementbookingincident_connections1

One-To-Many Relationship: [msdyn_agreementbookingincident msdyn_agreementbookingincident_connections1](msdyn_agreementbookingincident.md#BKMK_msdyn_agreementbookingincident_connections1)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_agreementbookingincident`|
|ReferencedAttribute|`msdyn_agreementbookingincidentid`|
|ReferencingAttribute|`record1id`|
|ReferencingEntityNavigationPropertyName|`record1id_msdyn_agreementbookingincident`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_agreementbookingincident_connections2"></a> msdyn_agreementbookingincident_connections2

One-To-Many Relationship: [msdyn_agreementbookingincident msdyn_agreementbookingincident_connections2](msdyn_agreementbookingincident.md#BKMK_msdyn_agreementbookingincident_connections2)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_agreementbookingincident`|
|ReferencedAttribute|`msdyn_agreementbookingincidentid`|
|ReferencingAttribute|`record2id`|
|ReferencingEntityNavigationPropertyName|`record2id_msdyn_agreementbookingincident`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_agreementbookingproduct_connections1"></a> msdyn_agreementbookingproduct_connections1

One-To-Many Relationship: [msdyn_agreementbookingproduct msdyn_agreementbookingproduct_connections1](msdyn_agreementbookingproduct.md#BKMK_msdyn_agreementbookingproduct_connections1)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_agreementbookingproduct`|
|ReferencedAttribute|`msdyn_agreementbookingproductid`|
|ReferencingAttribute|`record1id`|
|ReferencingEntityNavigationPropertyName|`record1id_msdyn_agreementbookingproduct`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_agreementbookingproduct_connections2"></a> msdyn_agreementbookingproduct_connections2

One-To-Many Relationship: [msdyn_agreementbookingproduct msdyn_agreementbookingproduct_connections2](msdyn_agreementbookingproduct.md#BKMK_msdyn_agreementbookingproduct_connections2)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_agreementbookingproduct`|
|ReferencedAttribute|`msdyn_agreementbookingproductid`|
|ReferencingAttribute|`record2id`|
|ReferencingEntityNavigationPropertyName|`record2id_msdyn_agreementbookingproduct`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_agreementbookingservice_connections1"></a> msdyn_agreementbookingservice_connections1

One-To-Many Relationship: [msdyn_agreementbookingservice msdyn_agreementbookingservice_connections1](msdyn_agreementbookingservice.md#BKMK_msdyn_agreementbookingservice_connections1)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_agreementbookingservice`|
|ReferencedAttribute|`msdyn_agreementbookingserviceid`|
|ReferencingAttribute|`record1id`|
|ReferencingEntityNavigationPropertyName|`record1id_msdyn_agreementbookingservice`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_agreementbookingservice_connections2"></a> msdyn_agreementbookingservice_connections2

One-To-Many Relationship: [msdyn_agreementbookingservice msdyn_agreementbookingservice_connections2](msdyn_agreementbookingservice.md#BKMK_msdyn_agreementbookingservice_connections2)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_agreementbookingservice`|
|ReferencedAttribute|`msdyn_agreementbookingserviceid`|
|ReferencingAttribute|`record2id`|
|ReferencingEntityNavigationPropertyName|`record2id_msdyn_agreementbookingservice`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_agreementbookingservicetask_connections1"></a> msdyn_agreementbookingservicetask_connections1

One-To-Many Relationship: [msdyn_agreementbookingservicetask msdyn_agreementbookingservicetask_connections1](msdyn_agreementbookingservicetask.md#BKMK_msdyn_agreementbookingservicetask_connections1)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_agreementbookingservicetask`|
|ReferencedAttribute|`msdyn_agreementbookingservicetaskid`|
|ReferencingAttribute|`record1id`|
|ReferencingEntityNavigationPropertyName|`record1id_msdyn_agreementbookingservicetask`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_agreementbookingservicetask_connections2"></a> msdyn_agreementbookingservicetask_connections2

One-To-Many Relationship: [msdyn_agreementbookingservicetask msdyn_agreementbookingservicetask_connections2](msdyn_agreementbookingservicetask.md#BKMK_msdyn_agreementbookingservicetask_connections2)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_agreementbookingservicetask`|
|ReferencedAttribute|`msdyn_agreementbookingservicetaskid`|
|ReferencingAttribute|`record2id`|
|ReferencingEntityNavigationPropertyName|`record2id_msdyn_agreementbookingservicetask`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_agreementbookingsetup_connections1"></a> msdyn_agreementbookingsetup_connections1

One-To-Many Relationship: [msdyn_agreementbookingsetup msdyn_agreementbookingsetup_connections1](msdyn_agreementbookingsetup.md#BKMK_msdyn_agreementbookingsetup_connections1)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_agreementbookingsetup`|
|ReferencedAttribute|`msdyn_agreementbookingsetupid`|
|ReferencingAttribute|`record1id`|
|ReferencingEntityNavigationPropertyName|`record1id_msdyn_agreementbookingsetup`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_agreementbookingsetup_connections2"></a> msdyn_agreementbookingsetup_connections2

One-To-Many Relationship: [msdyn_agreementbookingsetup msdyn_agreementbookingsetup_connections2](msdyn_agreementbookingsetup.md#BKMK_msdyn_agreementbookingsetup_connections2)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_agreementbookingsetup`|
|ReferencedAttribute|`msdyn_agreementbookingsetupid`|
|ReferencingAttribute|`record2id`|
|ReferencingEntityNavigationPropertyName|`record2id_msdyn_agreementbookingsetup`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_agreementinvoicedate_connections1"></a> msdyn_agreementinvoicedate_connections1

One-To-Many Relationship: [msdyn_agreementinvoicedate msdyn_agreementinvoicedate_connections1](msdyn_agreementinvoicedate.md#BKMK_msdyn_agreementinvoicedate_connections1)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_agreementinvoicedate`|
|ReferencedAttribute|`msdyn_agreementinvoicedateid`|
|ReferencingAttribute|`record1id`|
|ReferencingEntityNavigationPropertyName|`record1id_msdyn_agreementinvoicedate`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_agreementinvoicedate_connections2"></a> msdyn_agreementinvoicedate_connections2

One-To-Many Relationship: [msdyn_agreementinvoicedate msdyn_agreementinvoicedate_connections2](msdyn_agreementinvoicedate.md#BKMK_msdyn_agreementinvoicedate_connections2)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_agreementinvoicedate`|
|ReferencedAttribute|`msdyn_agreementinvoicedateid`|
|ReferencingAttribute|`record2id`|
|ReferencingEntityNavigationPropertyName|`record2id_msdyn_agreementinvoicedate`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_agreementinvoiceproduct_connections1"></a> msdyn_agreementinvoiceproduct_connections1

One-To-Many Relationship: [msdyn_agreementinvoiceproduct msdyn_agreementinvoiceproduct_connections1](msdyn_agreementinvoiceproduct.md#BKMK_msdyn_agreementinvoiceproduct_connections1)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_agreementinvoiceproduct`|
|ReferencedAttribute|`msdyn_agreementinvoiceproductid`|
|ReferencingAttribute|`record1id`|
|ReferencingEntityNavigationPropertyName|`record1id_msdyn_agreementinvoiceproduct`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_agreementinvoiceproduct_connections2"></a> msdyn_agreementinvoiceproduct_connections2

One-To-Many Relationship: [msdyn_agreementinvoiceproduct msdyn_agreementinvoiceproduct_connections2](msdyn_agreementinvoiceproduct.md#BKMK_msdyn_agreementinvoiceproduct_connections2)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_agreementinvoiceproduct`|
|ReferencedAttribute|`msdyn_agreementinvoiceproductid`|
|ReferencingAttribute|`record2id`|
|ReferencingEntityNavigationPropertyName|`record2id_msdyn_agreementinvoiceproduct`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_agreementinvoicesetup_connections1"></a> msdyn_agreementinvoicesetup_connections1

One-To-Many Relationship: [msdyn_agreementinvoicesetup msdyn_agreementinvoicesetup_connections1](msdyn_agreementinvoicesetup.md#BKMK_msdyn_agreementinvoicesetup_connections1)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_agreementinvoicesetup`|
|ReferencedAttribute|`msdyn_agreementinvoicesetupid`|
|ReferencingAttribute|`record1id`|
|ReferencingEntityNavigationPropertyName|`record1id_msdyn_agreementinvoicesetup`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_agreementinvoicesetup_connections2"></a> msdyn_agreementinvoicesetup_connections2

One-To-Many Relationship: [msdyn_agreementinvoicesetup msdyn_agreementinvoicesetup_connections2](msdyn_agreementinvoicesetup.md#BKMK_msdyn_agreementinvoicesetup_connections2)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_agreementinvoicesetup`|
|ReferencedAttribute|`msdyn_agreementinvoicesetupid`|
|ReferencingAttribute|`record2id`|
|ReferencingEntityNavigationPropertyName|`record2id_msdyn_agreementinvoicesetup`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_assignmentmap_connections1"></a> msdyn_assignmentmap_connections1

One-To-Many Relationship: [msdyn_assignmentmap msdyn_assignmentmap_connections1](msdyn_assignmentmap.md#BKMK_msdyn_assignmentmap_connections1)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_assignmentmap`|
|ReferencedAttribute|`msdyn_assignmentmapid`|
|ReferencingAttribute|`record1id`|
|ReferencingEntityNavigationPropertyName|`record1id_msdyn_assignmentmap`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_assignmentmap_connections2"></a> msdyn_assignmentmap_connections2

One-To-Many Relationship: [msdyn_assignmentmap msdyn_assignmentmap_connections2](msdyn_assignmentmap.md#BKMK_msdyn_assignmentmap_connections2)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_assignmentmap`|
|ReferencedAttribute|`msdyn_assignmentmapid`|
|ReferencingAttribute|`record2id`|
|ReferencingEntityNavigationPropertyName|`record2id_msdyn_assignmentmap`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_assignmentrule_connections1"></a> msdyn_assignmentrule_connections1

One-To-Many Relationship: [msdyn_assignmentrule msdyn_assignmentrule_connections1](msdyn_assignmentrule.md#BKMK_msdyn_assignmentrule_connections1)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_assignmentrule`|
|ReferencedAttribute|`msdyn_assignmentruleid`|
|ReferencingAttribute|`record1id`|
|ReferencingEntityNavigationPropertyName|`record1id_msdyn_assignmentrule`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_assignmentrule_connections2"></a> msdyn_assignmentrule_connections2

One-To-Many Relationship: [msdyn_assignmentrule msdyn_assignmentrule_connections2](msdyn_assignmentrule.md#BKMK_msdyn_assignmentrule_connections2)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_assignmentrule`|
|ReferencedAttribute|`msdyn_assignmentruleid`|
|ReferencingAttribute|`record2id`|
|ReferencingEntityNavigationPropertyName|`record2id_msdyn_assignmentrule`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_bookingalert_connections1"></a> msdyn_bookingalert_connections1

One-To-Many Relationship: [msdyn_bookingalert msdyn_bookingalert_connections1](msdyn_bookingalert.md#BKMK_msdyn_bookingalert_connections1)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_bookingalert`|
|ReferencedAttribute|`activityid`|
|ReferencingAttribute|`record1id`|
|ReferencingEntityNavigationPropertyName|`record1id_msdyn_bookingalert`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_bookingalert_connections2"></a> msdyn_bookingalert_connections2

One-To-Many Relationship: [msdyn_bookingalert msdyn_bookingalert_connections2](msdyn_bookingalert.md#BKMK_msdyn_bookingalert_connections2)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_bookingalert`|
|ReferencedAttribute|`activityid`|
|ReferencingAttribute|`record2id`|
|ReferencingEntityNavigationPropertyName|`record2id_msdyn_bookingalert`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_bookingalertstatus_connections1"></a> msdyn_bookingalertstatus_connections1

One-To-Many Relationship: [msdyn_bookingalertstatus msdyn_bookingalertstatus_connections1](msdyn_bookingalertstatus.md#BKMK_msdyn_bookingalertstatus_connections1)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_bookingalertstatus`|
|ReferencedAttribute|`msdyn_bookingalertstatusid`|
|ReferencingAttribute|`record1id`|
|ReferencingEntityNavigationPropertyName|`record1id_msdyn_bookingalertstatus`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_bookingalertstatus_connections2"></a> msdyn_bookingalertstatus_connections2

One-To-Many Relationship: [msdyn_bookingalertstatus msdyn_bookingalertstatus_connections2](msdyn_bookingalertstatus.md#BKMK_msdyn_bookingalertstatus_connections2)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_bookingalertstatus`|
|ReferencedAttribute|`msdyn_bookingalertstatusid`|
|ReferencingAttribute|`record2id`|
|ReferencingEntityNavigationPropertyName|`record2id_msdyn_bookingalertstatus`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_bookingrule_connections1"></a> msdyn_bookingrule_connections1

One-To-Many Relationship: [msdyn_bookingrule msdyn_bookingrule_connections1](msdyn_bookingrule.md#BKMK_msdyn_bookingrule_connections1)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_bookingrule`|
|ReferencedAttribute|`msdyn_bookingruleid`|
|ReferencingAttribute|`record1id`|
|ReferencingEntityNavigationPropertyName|`record1id_msdyn_bookingrule`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_bookingrule_connections2"></a> msdyn_bookingrule_connections2

One-To-Many Relationship: [msdyn_bookingrule msdyn_bookingrule_connections2](msdyn_bookingrule.md#BKMK_msdyn_bookingrule_connections2)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_bookingrule`|
|ReferencedAttribute|`msdyn_bookingruleid`|
|ReferencingAttribute|`record2id`|
|ReferencingEntityNavigationPropertyName|`record2id_msdyn_bookingrule`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_bookingtimestamp_connections1"></a> msdyn_bookingtimestamp_connections1

One-To-Many Relationship: [msdyn_bookingtimestamp msdyn_bookingtimestamp_connections1](msdyn_bookingtimestamp.md#BKMK_msdyn_bookingtimestamp_connections1)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_bookingtimestamp`|
|ReferencedAttribute|`msdyn_bookingtimestampid`|
|ReferencingAttribute|`record1id`|
|ReferencingEntityNavigationPropertyName|`record1id_msdyn_bookingtimestamp`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_bookingtimestamp_connections2"></a> msdyn_bookingtimestamp_connections2

One-To-Many Relationship: [msdyn_bookingtimestamp msdyn_bookingtimestamp_connections2](msdyn_bookingtimestamp.md#BKMK_msdyn_bookingtimestamp_connections2)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_bookingtimestamp`|
|ReferencedAttribute|`msdyn_bookingtimestampid`|
|ReferencingAttribute|`record2id`|
|ReferencingEntityNavigationPropertyName|`record2id_msdyn_bookingtimestamp`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_copilottranscript_connections1"></a> msdyn_copilottranscript_connections1

One-To-Many Relationship: [msdyn_copilottranscript msdyn_copilottranscript_connections1](msdyn_copilottranscript.md#BKMK_msdyn_copilottranscript_connections1)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_copilottranscript`|
|ReferencedAttribute|`activityid`|
|ReferencingAttribute|`record1id`|
|ReferencingEntityNavigationPropertyName|`record1id_msdyn_copilottranscript`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_copilottranscript_connections2"></a> msdyn_copilottranscript_connections2

One-To-Many Relationship: [msdyn_copilottranscript msdyn_copilottranscript_connections2](msdyn_copilottranscript.md#BKMK_msdyn_copilottranscript_connections2)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_copilottranscript`|
|ReferencedAttribute|`activityid`|
|ReferencingAttribute|`record2id`|
|ReferencingEntityNavigationPropertyName|`record2id_msdyn_copilottranscript`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_customerasset_connections1"></a> msdyn_customerasset_connections1

One-To-Many Relationship: [msdyn_customerasset msdyn_customerasset_connections1](msdyn_customerasset.md#BKMK_msdyn_customerasset_connections1)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_customerasset`|
|ReferencedAttribute|`msdyn_customerassetid`|
|ReferencingAttribute|`record1id`|
|ReferencingEntityNavigationPropertyName|`record1id_msdyn_customerasset`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_customerasset_connections2"></a> msdyn_customerasset_connections2

One-To-Many Relationship: [msdyn_customerasset msdyn_customerasset_connections2](msdyn_customerasset.md#BKMK_msdyn_customerasset_connections2)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_customerasset`|
|ReferencedAttribute|`msdyn_customerassetid`|
|ReferencingAttribute|`record2id`|
|ReferencingEntityNavigationPropertyName|`record2id_msdyn_customerasset`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_incidenttypecharacteristic_connections1"></a> msdyn_incidenttypecharacteristic_connections1

One-To-Many Relationship: [msdyn_incidenttypecharacteristic msdyn_incidenttypecharacteristic_connections1](msdyn_incidenttypecharacteristic.md#BKMK_msdyn_incidenttypecharacteristic_connections1)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_incidenttypecharacteristic`|
|ReferencedAttribute|`msdyn_incidenttypecharacteristicid`|
|ReferencingAttribute|`record1id`|
|ReferencingEntityNavigationPropertyName|`record1id_msdyn_incidenttypecharacteristic`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_incidenttypecharacteristic_connections2"></a> msdyn_incidenttypecharacteristic_connections2

One-To-Many Relationship: [msdyn_incidenttypecharacteristic msdyn_incidenttypecharacteristic_connections2](msdyn_incidenttypecharacteristic.md#BKMK_msdyn_incidenttypecharacteristic_connections2)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_incidenttypecharacteristic`|
|ReferencedAttribute|`msdyn_incidenttypecharacteristicid`|
|ReferencingAttribute|`record2id`|
|ReferencingEntityNavigationPropertyName|`record2id_msdyn_incidenttypecharacteristic`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_incidenttypeproduct_connections1"></a> msdyn_incidenttypeproduct_connections1

One-To-Many Relationship: [msdyn_incidenttypeproduct msdyn_incidenttypeproduct_connections1](msdyn_incidenttypeproduct.md#BKMK_msdyn_incidenttypeproduct_connections1)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_incidenttypeproduct`|
|ReferencedAttribute|`msdyn_incidenttypeproductid`|
|ReferencingAttribute|`record1id`|
|ReferencingEntityNavigationPropertyName|`record1id_msdyn_incidenttypeproduct`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_incidenttypeproduct_connections2"></a> msdyn_incidenttypeproduct_connections2

One-To-Many Relationship: [msdyn_incidenttypeproduct msdyn_incidenttypeproduct_connections2](msdyn_incidenttypeproduct.md#BKMK_msdyn_incidenttypeproduct_connections2)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_incidenttypeproduct`|
|ReferencedAttribute|`msdyn_incidenttypeproductid`|
|ReferencingAttribute|`record2id`|
|ReferencingEntityNavigationPropertyName|`record2id_msdyn_incidenttypeproduct`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_incidenttypeservice_connections1"></a> msdyn_incidenttypeservice_connections1

One-To-Many Relationship: [msdyn_incidenttypeservice msdyn_incidenttypeservice_connections1](msdyn_incidenttypeservice.md#BKMK_msdyn_incidenttypeservice_connections1)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_incidenttypeservice`|
|ReferencedAttribute|`msdyn_incidenttypeserviceid`|
|ReferencingAttribute|`record1id`|
|ReferencingEntityNavigationPropertyName|`record1id_msdyn_incidenttypeservice`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_incidenttypeservice_connections2"></a> msdyn_incidenttypeservice_connections2

One-To-Many Relationship: [msdyn_incidenttypeservice msdyn_incidenttypeservice_connections2](msdyn_incidenttypeservice.md#BKMK_msdyn_incidenttypeservice_connections2)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_incidenttypeservice`|
|ReferencedAttribute|`msdyn_incidenttypeserviceid`|
|ReferencingAttribute|`record2id`|
|ReferencingEntityNavigationPropertyName|`record2id_msdyn_incidenttypeservice`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_inventoryadjustment_connections1"></a> msdyn_inventoryadjustment_connections1

One-To-Many Relationship: [msdyn_inventoryadjustment msdyn_inventoryadjustment_connections1](msdyn_inventoryadjustment.md#BKMK_msdyn_inventoryadjustment_connections1)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_inventoryadjustment`|
|ReferencedAttribute|`msdyn_inventoryadjustmentid`|
|ReferencingAttribute|`record1id`|
|ReferencingEntityNavigationPropertyName|`record1id_msdyn_inventoryadjustment`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_inventoryadjustment_connections2"></a> msdyn_inventoryadjustment_connections2

One-To-Many Relationship: [msdyn_inventoryadjustment msdyn_inventoryadjustment_connections2](msdyn_inventoryadjustment.md#BKMK_msdyn_inventoryadjustment_connections2)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_inventoryadjustment`|
|ReferencedAttribute|`msdyn_inventoryadjustmentid`|
|ReferencingAttribute|`record2id`|
|ReferencingEntityNavigationPropertyName|`record2id_msdyn_inventoryadjustment`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_inventoryadjustmentproduct_connections1"></a> msdyn_inventoryadjustmentproduct_connections1

One-To-Many Relationship: [msdyn_inventoryadjustmentproduct msdyn_inventoryadjustmentproduct_connections1](msdyn_inventoryadjustmentproduct.md#BKMK_msdyn_inventoryadjustmentproduct_connections1)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_inventoryadjustmentproduct`|
|ReferencedAttribute|`msdyn_inventoryadjustmentproductid`|
|ReferencingAttribute|`record1id`|
|ReferencingEntityNavigationPropertyName|`record1id_msdyn_inventoryadjustmentproduct`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_inventoryadjustmentproduct_connections2"></a> msdyn_inventoryadjustmentproduct_connections2

One-To-Many Relationship: [msdyn_inventoryadjustmentproduct msdyn_inventoryadjustmentproduct_connections2](msdyn_inventoryadjustmentproduct.md#BKMK_msdyn_inventoryadjustmentproduct_connections2)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_inventoryadjustmentproduct`|
|ReferencedAttribute|`msdyn_inventoryadjustmentproductid`|
|ReferencingAttribute|`record2id`|
|ReferencingEntityNavigationPropertyName|`record2id_msdyn_inventoryadjustmentproduct`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_inventoryjournal_connections1"></a> msdyn_inventoryjournal_connections1

One-To-Many Relationship: [msdyn_inventoryjournal msdyn_inventoryjournal_connections1](msdyn_inventoryjournal.md#BKMK_msdyn_inventoryjournal_connections1)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_inventoryjournal`|
|ReferencedAttribute|`msdyn_inventoryjournalid`|
|ReferencingAttribute|`record1id`|
|ReferencingEntityNavigationPropertyName|`record1id_msdyn_inventoryjournal`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_inventoryjournal_connections2"></a> msdyn_inventoryjournal_connections2

One-To-Many Relationship: [msdyn_inventoryjournal msdyn_inventoryjournal_connections2](msdyn_inventoryjournal.md#BKMK_msdyn_inventoryjournal_connections2)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_inventoryjournal`|
|ReferencedAttribute|`msdyn_inventoryjournalid`|
|ReferencingAttribute|`record2id`|
|ReferencingEntityNavigationPropertyName|`record2id_msdyn_inventoryjournal`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_inventorytransfer_connections1"></a> msdyn_inventorytransfer_connections1

One-To-Many Relationship: [msdyn_inventorytransfer msdyn_inventorytransfer_connections1](msdyn_inventorytransfer.md#BKMK_msdyn_inventorytransfer_connections1)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_inventorytransfer`|
|ReferencedAttribute|`msdyn_inventorytransferid`|
|ReferencingAttribute|`record1id`|
|ReferencingEntityNavigationPropertyName|`record1id_msdyn_inventorytransfer`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_inventorytransfer_connections2"></a> msdyn_inventorytransfer_connections2

One-To-Many Relationship: [msdyn_inventorytransfer msdyn_inventorytransfer_connections2](msdyn_inventorytransfer.md#BKMK_msdyn_inventorytransfer_connections2)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_inventorytransfer`|
|ReferencedAttribute|`msdyn_inventorytransferid`|
|ReferencingAttribute|`record2id`|
|ReferencingEntityNavigationPropertyName|`record2id_msdyn_inventorytransfer`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_iotalert_connections1"></a> msdyn_iotalert_connections1

One-To-Many Relationship: [msdyn_iotalert msdyn_iotalert_connections1](msdyn_iotalert.md#BKMK_msdyn_iotalert_connections1)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_iotalert`|
|ReferencedAttribute|`msdyn_iotalertid`|
|ReferencingAttribute|`record1id`|
|ReferencingEntityNavigationPropertyName|`record1id_msdyn_iotalert`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_iotalert_connections2"></a> msdyn_iotalert_connections2

One-To-Many Relationship: [msdyn_iotalert msdyn_iotalert_connections2](msdyn_iotalert.md#BKMK_msdyn_iotalert_connections2)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_iotalert`|
|ReferencedAttribute|`msdyn_iotalertid`|
|ReferencingAttribute|`record2id`|
|ReferencingEntityNavigationPropertyName|`record2id_msdyn_iotalert`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_iotdevice_connections1"></a> msdyn_iotdevice_connections1

One-To-Many Relationship: [msdyn_iotdevice msdyn_iotdevice_connections1](msdyn_iotdevice.md#BKMK_msdyn_iotdevice_connections1)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_iotdevice`|
|ReferencedAttribute|`msdyn_iotdeviceid`|
|ReferencingAttribute|`record1id`|
|ReferencingEntityNavigationPropertyName|`record1id_msdyn_iotdevice`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_iotdevice_connections2"></a> msdyn_iotdevice_connections2

One-To-Many Relationship: [msdyn_iotdevice msdyn_iotdevice_connections2](msdyn_iotdevice.md#BKMK_msdyn_iotdevice_connections2)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_iotdevice`|
|ReferencedAttribute|`msdyn_iotdeviceid`|
|ReferencingAttribute|`record2id`|
|ReferencingEntityNavigationPropertyName|`record2id_msdyn_iotdevice`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_iotdevicecategory_connections1"></a> msdyn_iotdevicecategory_connections1

One-To-Many Relationship: [msdyn_iotdevicecategory msdyn_iotdevicecategory_connections1](msdyn_iotdevicecategory.md#BKMK_msdyn_iotdevicecategory_connections1)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_iotdevicecategory`|
|ReferencedAttribute|`msdyn_iotdevicecategoryid`|
|ReferencingAttribute|`record1id`|
|ReferencingEntityNavigationPropertyName|`record1id_msdyn_iotdevicecategory`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_iotdevicecategory_connections2"></a> msdyn_iotdevicecategory_connections2

One-To-Many Relationship: [msdyn_iotdevicecategory msdyn_iotdevicecategory_connections2](msdyn_iotdevicecategory.md#BKMK_msdyn_iotdevicecategory_connections2)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_iotdevicecategory`|
|ReferencedAttribute|`msdyn_iotdevicecategoryid`|
|ReferencingAttribute|`record2id`|
|ReferencingEntityNavigationPropertyName|`record2id_msdyn_iotdevicecategory`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_iotdevicecommand_connections1"></a> msdyn_iotdevicecommand_connections1

One-To-Many Relationship: [msdyn_iotdevicecommand msdyn_iotdevicecommand_connections1](msdyn_iotdevicecommand.md#BKMK_msdyn_iotdevicecommand_connections1)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_iotdevicecommand`|
|ReferencedAttribute|`msdyn_iotdevicecommandid`|
|ReferencingAttribute|`record1id`|
|ReferencingEntityNavigationPropertyName|`record1id_msdyn_iotdevicecommand`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_iotdevicecommand_connections2"></a> msdyn_iotdevicecommand_connections2

One-To-Many Relationship: [msdyn_iotdevicecommand msdyn_iotdevicecommand_connections2](msdyn_iotdevicecommand.md#BKMK_msdyn_iotdevicecommand_connections2)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_iotdevicecommand`|
|ReferencedAttribute|`msdyn_iotdevicecommandid`|
|ReferencingAttribute|`record2id`|
|ReferencingEntityNavigationPropertyName|`record2id_msdyn_iotdevicecommand`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_iotdeviceregistrationhistory_connections1"></a> msdyn_iotdeviceregistrationhistory_connections1

One-To-Many Relationship: [msdyn_iotdeviceregistrationhistory msdyn_iotdeviceregistrationhistory_connections1](msdyn_iotdeviceregistrationhistory.md#BKMK_msdyn_iotdeviceregistrationhistory_connections1)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_iotdeviceregistrationhistory`|
|ReferencedAttribute|`msdyn_iotdeviceregistrationhistoryid`|
|ReferencingAttribute|`record1id`|
|ReferencingEntityNavigationPropertyName|`record1id_msdyn_iotdeviceregistrationhistory`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_iotdeviceregistrationhistory_connections2"></a> msdyn_iotdeviceregistrationhistory_connections2

One-To-Many Relationship: [msdyn_iotdeviceregistrationhistory msdyn_iotdeviceregistrationhistory_connections2](msdyn_iotdeviceregistrationhistory.md#BKMK_msdyn_iotdeviceregistrationhistory_connections2)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_iotdeviceregistrationhistory`|
|ReferencedAttribute|`msdyn_iotdeviceregistrationhistoryid`|
|ReferencingAttribute|`record2id`|
|ReferencingEntityNavigationPropertyName|`record2id_msdyn_iotdeviceregistrationhistory`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_liveconversation_connections1"></a> msdyn_liveconversation_connections1

One-To-Many Relationship: [msdyn_liveconversation msdyn_liveconversation_connections1](msdyn_liveconversation.md#BKMK_msdyn_liveconversation_connections1)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_liveconversation`|
|ReferencedAttribute|`msdyn_liveconversationid`|
|ReferencingAttribute|`record1id`|
|ReferencingEntityNavigationPropertyName|`record1id_msdyn_liveconversation`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_liveconversation_connections2"></a> msdyn_liveconversation_connections2

One-To-Many Relationship: [msdyn_liveconversation msdyn_liveconversation_connections2](msdyn_liveconversation.md#BKMK_msdyn_liveconversation_connections2)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_liveconversation`|
|ReferencedAttribute|`msdyn_liveconversationid`|
|ReferencingAttribute|`record2id`|
|ReferencingEntityNavigationPropertyName|`record2id_msdyn_liveconversation`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_ocliveworkitem_connections1"></a> msdyn_ocliveworkitem_connections1

One-To-Many Relationship: [msdyn_ocliveworkitem msdyn_ocliveworkitem_connections1](msdyn_ocliveworkitem.md#BKMK_msdyn_ocliveworkitem_connections1)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_ocliveworkitem`|
|ReferencedAttribute|`activityid`|
|ReferencingAttribute|`record1id`|
|ReferencingEntityNavigationPropertyName|`record1id_msdyn_ocliveworkitem`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_ocliveworkitem_connections2"></a> msdyn_ocliveworkitem_connections2

One-To-Many Relationship: [msdyn_ocliveworkitem msdyn_ocliveworkitem_connections2](msdyn_ocliveworkitem.md#BKMK_msdyn_ocliveworkitem_connections2)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_ocliveworkitem`|
|ReferencedAttribute|`activityid`|
|ReferencingAttribute|`record2id`|
|ReferencingEntityNavigationPropertyName|`record2id_msdyn_ocliveworkitem`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_ocoutboundmessage_connections1"></a> msdyn_ocoutboundmessage_connections1

One-To-Many Relationship: [msdyn_ocoutboundmessage msdyn_ocoutboundmessage_connections1](msdyn_ocoutboundmessage.md#BKMK_msdyn_ocoutboundmessage_connections1)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_ocoutboundmessage`|
|ReferencedAttribute|`activityid`|
|ReferencingAttribute|`record1id`|
|ReferencingEntityNavigationPropertyName|`record1id_msdyn_ocoutboundmessage`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_ocoutboundmessage_connections2"></a> msdyn_ocoutboundmessage_connections2

One-To-Many Relationship: [msdyn_ocoutboundmessage msdyn_ocoutboundmessage_connections2](msdyn_ocoutboundmessage.md#BKMK_msdyn_ocoutboundmessage_connections2)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_ocoutboundmessage`|
|ReferencedAttribute|`activityid`|
|ReferencingAttribute|`record2id`|
|ReferencingEntityNavigationPropertyName|`record2id_msdyn_ocoutboundmessage`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_ocsession_connections1"></a> msdyn_ocsession_connections1

One-To-Many Relationship: [msdyn_ocsession msdyn_ocsession_connections1](msdyn_ocsession.md#BKMK_msdyn_ocsession_connections1)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_ocsession`|
|ReferencedAttribute|`activityid`|
|ReferencingAttribute|`record1id`|
|ReferencingEntityNavigationPropertyName|`record1id_msdyn_ocsession`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_ocsession_connections2"></a> msdyn_ocsession_connections2

One-To-Many Relationship: [msdyn_ocsession msdyn_ocsession_connections2](msdyn_ocsession.md#BKMK_msdyn_ocsession_connections2)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_ocsession`|
|ReferencedAttribute|`activityid`|
|ReferencingAttribute|`record2id`|
|ReferencingEntityNavigationPropertyName|`record2id_msdyn_ocsession`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_ocvoicemail_connections1"></a> msdyn_ocvoicemail_connections1

One-To-Many Relationship: [msdyn_ocvoicemail msdyn_ocvoicemail_connections1](msdyn_ocvoicemail.md#BKMK_msdyn_ocvoicemail_connections1)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_ocvoicemail`|
|ReferencedAttribute|`activityid`|
|ReferencingAttribute|`record1id`|
|ReferencingEntityNavigationPropertyName|`record1id_msdyn_ocvoicemail`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_ocvoicemail_connections2"></a> msdyn_ocvoicemail_connections2

One-To-Many Relationship: [msdyn_ocvoicemail msdyn_ocvoicemail_connections2](msdyn_ocvoicemail.md#BKMK_msdyn_ocvoicemail_connections2)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_ocvoicemail`|
|ReferencedAttribute|`activityid`|
|ReferencingAttribute|`record2id`|
|ReferencingEntityNavigationPropertyName|`record2id_msdyn_ocvoicemail`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_payment_connections1"></a> msdyn_payment_connections1

One-To-Many Relationship: [msdyn_payment msdyn_payment_connections1](msdyn_payment.md#BKMK_msdyn_payment_connections1)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_payment`|
|ReferencedAttribute|`msdyn_paymentid`|
|ReferencingAttribute|`record1id`|
|ReferencingEntityNavigationPropertyName|`record1id_msdyn_payment`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_payment_connections2"></a> msdyn_payment_connections2

One-To-Many Relationship: [msdyn_payment msdyn_payment_connections2](msdyn_payment.md#BKMK_msdyn_payment_connections2)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_payment`|
|ReferencedAttribute|`msdyn_paymentid`|
|ReferencingAttribute|`record2id`|
|ReferencingEntityNavigationPropertyName|`record2id_msdyn_payment`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_paymentdetail_connections1"></a> msdyn_paymentdetail_connections1

One-To-Many Relationship: [msdyn_paymentdetail msdyn_paymentdetail_connections1](msdyn_paymentdetail.md#BKMK_msdyn_paymentdetail_connections1)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_paymentdetail`|
|ReferencedAttribute|`msdyn_paymentdetailid`|
|ReferencingAttribute|`record1id`|
|ReferencingEntityNavigationPropertyName|`record1id_msdyn_paymentdetail`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_paymentdetail_connections2"></a> msdyn_paymentdetail_connections2

One-To-Many Relationship: [msdyn_paymentdetail msdyn_paymentdetail_connections2](msdyn_paymentdetail.md#BKMK_msdyn_paymentdetail_connections2)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_paymentdetail`|
|ReferencedAttribute|`msdyn_paymentdetailid`|
|ReferencingAttribute|`record2id`|
|ReferencingEntityNavigationPropertyName|`record2id_msdyn_paymentdetail`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_paymentmethod_connections1"></a> msdyn_paymentmethod_connections1

One-To-Many Relationship: [msdyn_paymentmethod msdyn_paymentmethod_connections1](msdyn_paymentmethod.md#BKMK_msdyn_paymentmethod_connections1)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_paymentmethod`|
|ReferencedAttribute|`msdyn_paymentmethodid`|
|ReferencingAttribute|`record1id`|
|ReferencingEntityNavigationPropertyName|`record1id_msdyn_paymentmethod`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_paymentmethod_connections2"></a> msdyn_paymentmethod_connections2

One-To-Many Relationship: [msdyn_paymentmethod msdyn_paymentmethod_connections2](msdyn_paymentmethod.md#BKMK_msdyn_paymentmethod_connections2)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_paymentmethod`|
|ReferencedAttribute|`msdyn_paymentmethodid`|
|ReferencingAttribute|`record2id`|
|ReferencingEntityNavigationPropertyName|`record2id_msdyn_paymentmethod`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_paymentterm_connections1"></a> msdyn_paymentterm_connections1

One-To-Many Relationship: [msdyn_paymentterm msdyn_paymentterm_connections1](msdyn_paymentterm.md#BKMK_msdyn_paymentterm_connections1)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_paymentterm`|
|ReferencedAttribute|`msdyn_paymenttermid`|
|ReferencingAttribute|`record1id`|
|ReferencingEntityNavigationPropertyName|`record1id_msdyn_paymentterm`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_paymentterm_connections2"></a> msdyn_paymentterm_connections2

One-To-Many Relationship: [msdyn_paymentterm msdyn_paymentterm_connections2](msdyn_paymentterm.md#BKMK_msdyn_paymentterm_connections2)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_paymentterm`|
|ReferencedAttribute|`msdyn_paymenttermid`|
|ReferencingAttribute|`record2id`|
|ReferencingEntityNavigationPropertyName|`record2id_msdyn_paymentterm`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_postalbum_connections1"></a> msdyn_postalbum_connections1

One-To-Many Relationship: [msdyn_postalbum msdyn_postalbum_connections1](msdyn_postalbum.md#BKMK_msdyn_postalbum_connections1)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_postalbum`|
|ReferencedAttribute|`msdyn_postalbumid`|
|ReferencingAttribute|`record1id`|
|ReferencingEntityNavigationPropertyName|`record1id_msdyn_postalbum`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_postalbum_connections2"></a> msdyn_postalbum_connections2

One-To-Many Relationship: [msdyn_postalbum msdyn_postalbum_connections2](msdyn_postalbum.md#BKMK_msdyn_postalbum_connections2)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_postalbum`|
|ReferencedAttribute|`msdyn_postalbumid`|
|ReferencingAttribute|`record2id`|
|ReferencingEntityNavigationPropertyName|`record2id_msdyn_postalbum`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_postalcode_connections1"></a> msdyn_postalcode_connections1

One-To-Many Relationship: [msdyn_postalcode msdyn_postalcode_connections1](msdyn_postalcode.md#BKMK_msdyn_postalcode_connections1)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_postalcode`|
|ReferencedAttribute|`msdyn_postalcodeid`|
|ReferencingAttribute|`record1id`|
|ReferencingEntityNavigationPropertyName|`record1id_msdyn_postalcode`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_postalcode_connections2"></a> msdyn_postalcode_connections2

One-To-Many Relationship: [msdyn_postalcode msdyn_postalcode_connections2](msdyn_postalcode.md#BKMK_msdyn_postalcode_connections2)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_postalcode`|
|ReferencedAttribute|`msdyn_postalcodeid`|
|ReferencingAttribute|`record2id`|
|ReferencingEntityNavigationPropertyName|`record2id_msdyn_postalcode`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_productinventory_connections1"></a> msdyn_productinventory_connections1

One-To-Many Relationship: [msdyn_productinventory msdyn_productinventory_connections1](msdyn_productinventory.md#BKMK_msdyn_productinventory_connections1)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_productinventory`|
|ReferencedAttribute|`msdyn_productinventoryid`|
|ReferencingAttribute|`record1id`|
|ReferencingEntityNavigationPropertyName|`record1id_msdyn_productinventory`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_productinventory_connections2"></a> msdyn_productinventory_connections2

One-To-Many Relationship: [msdyn_productinventory msdyn_productinventory_connections2](msdyn_productinventory.md#BKMK_msdyn_productinventory_connections2)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_productinventory`|
|ReferencedAttribute|`msdyn_productinventoryid`|
|ReferencingAttribute|`record2id`|
|ReferencingEntityNavigationPropertyName|`record2id_msdyn_productinventory`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_purchaseorder_connections1"></a> msdyn_purchaseorder_connections1

One-To-Many Relationship: [msdyn_purchaseorder msdyn_purchaseorder_connections1](msdyn_purchaseorder.md#BKMK_msdyn_purchaseorder_connections1)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_purchaseorder`|
|ReferencedAttribute|`msdyn_purchaseorderid`|
|ReferencingAttribute|`record1id`|
|ReferencingEntityNavigationPropertyName|`record1id_msdyn_purchaseorder`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_purchaseorder_connections2"></a> msdyn_purchaseorder_connections2

One-To-Many Relationship: [msdyn_purchaseorder msdyn_purchaseorder_connections2](msdyn_purchaseorder.md#BKMK_msdyn_purchaseorder_connections2)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_purchaseorder`|
|ReferencedAttribute|`msdyn_purchaseorderid`|
|ReferencingAttribute|`record2id`|
|ReferencingEntityNavigationPropertyName|`record2id_msdyn_purchaseorder`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_purchaseorderbill_connections1"></a> msdyn_purchaseorderbill_connections1

One-To-Many Relationship: [msdyn_purchaseorderbill msdyn_purchaseorderbill_connections1](msdyn_purchaseorderbill.md#BKMK_msdyn_purchaseorderbill_connections1)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_purchaseorderbill`|
|ReferencedAttribute|`msdyn_purchaseorderbillid`|
|ReferencingAttribute|`record1id`|
|ReferencingEntityNavigationPropertyName|`record1id_msdyn_purchaseorderbill`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_purchaseorderbill_connections2"></a> msdyn_purchaseorderbill_connections2

One-To-Many Relationship: [msdyn_purchaseorderbill msdyn_purchaseorderbill_connections2](msdyn_purchaseorderbill.md#BKMK_msdyn_purchaseorderbill_connections2)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_purchaseorderbill`|
|ReferencedAttribute|`msdyn_purchaseorderbillid`|
|ReferencingAttribute|`record2id`|
|ReferencingEntityNavigationPropertyName|`record2id_msdyn_purchaseorderbill`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_purchaseorderproduct_connections1"></a> msdyn_purchaseorderproduct_connections1

One-To-Many Relationship: [msdyn_purchaseorderproduct msdyn_purchaseorderproduct_connections1](msdyn_purchaseorderproduct.md#BKMK_msdyn_purchaseorderproduct_connections1)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_purchaseorderproduct`|
|ReferencedAttribute|`msdyn_purchaseorderproductid`|
|ReferencingAttribute|`record1id`|
|ReferencingEntityNavigationPropertyName|`record1id_msdyn_purchaseorderproduct`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_purchaseorderproduct_connections2"></a> msdyn_purchaseorderproduct_connections2

One-To-Many Relationship: [msdyn_purchaseorderproduct msdyn_purchaseorderproduct_connections2](msdyn_purchaseorderproduct.md#BKMK_msdyn_purchaseorderproduct_connections2)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_purchaseorderproduct`|
|ReferencedAttribute|`msdyn_purchaseorderproductid`|
|ReferencingAttribute|`record2id`|
|ReferencingEntityNavigationPropertyName|`record2id_msdyn_purchaseorderproduct`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_purchaseorderreceipt_connections1"></a> msdyn_purchaseorderreceipt_connections1

One-To-Many Relationship: [msdyn_purchaseorderreceipt msdyn_purchaseorderreceipt_connections1](msdyn_purchaseorderreceipt.md#BKMK_msdyn_purchaseorderreceipt_connections1)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_purchaseorderreceipt`|
|ReferencedAttribute|`msdyn_purchaseorderreceiptid`|
|ReferencingAttribute|`record1id`|
|ReferencingEntityNavigationPropertyName|`record1id_msdyn_purchaseorderreceipt`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_purchaseorderreceipt_connections2"></a> msdyn_purchaseorderreceipt_connections2

One-To-Many Relationship: [msdyn_purchaseorderreceipt msdyn_purchaseorderreceipt_connections2](msdyn_purchaseorderreceipt.md#BKMK_msdyn_purchaseorderreceipt_connections2)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_purchaseorderreceipt`|
|ReferencedAttribute|`msdyn_purchaseorderreceiptid`|
|ReferencingAttribute|`record2id`|
|ReferencingEntityNavigationPropertyName|`record2id_msdyn_purchaseorderreceipt`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_purchaseorderreceiptproduct_connections1"></a> msdyn_purchaseorderreceiptproduct_connections1

One-To-Many Relationship: [msdyn_purchaseorderreceiptproduct msdyn_purchaseorderreceiptproduct_connections1](msdyn_purchaseorderreceiptproduct.md#BKMK_msdyn_purchaseorderreceiptproduct_connections1)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_purchaseorderreceiptproduct`|
|ReferencedAttribute|`msdyn_purchaseorderreceiptproductid`|
|ReferencingAttribute|`record1id`|
|ReferencingEntityNavigationPropertyName|`record1id_msdyn_purchaseorderreceiptproduct`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_purchaseorderreceiptproduct_connections2"></a> msdyn_purchaseorderreceiptproduct_connections2

One-To-Many Relationship: [msdyn_purchaseorderreceiptproduct msdyn_purchaseorderreceiptproduct_connections2](msdyn_purchaseorderreceiptproduct.md#BKMK_msdyn_purchaseorderreceiptproduct_connections2)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_purchaseorderreceiptproduct`|
|ReferencedAttribute|`msdyn_purchaseorderreceiptproductid`|
|ReferencingAttribute|`record2id`|
|ReferencingEntityNavigationPropertyName|`record2id_msdyn_purchaseorderreceiptproduct`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_purchaseordersubstatus_connections1"></a> msdyn_purchaseordersubstatus_connections1

One-To-Many Relationship: [msdyn_purchaseordersubstatus msdyn_purchaseordersubstatus_connections1](msdyn_purchaseordersubstatus.md#BKMK_msdyn_purchaseordersubstatus_connections1)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_purchaseordersubstatus`|
|ReferencedAttribute|`msdyn_purchaseordersubstatusid`|
|ReferencingAttribute|`record1id`|
|ReferencingEntityNavigationPropertyName|`record1id_msdyn_purchaseordersubstatus`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_purchaseordersubstatus_connections2"></a> msdyn_purchaseordersubstatus_connections2

One-To-Many Relationship: [msdyn_purchaseordersubstatus msdyn_purchaseordersubstatus_connections2](msdyn_purchaseordersubstatus.md#BKMK_msdyn_purchaseordersubstatus_connections2)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_purchaseordersubstatus`|
|ReferencedAttribute|`msdyn_purchaseordersubstatusid`|
|ReferencingAttribute|`record2id`|
|ReferencingEntityNavigationPropertyName|`record2id_msdyn_purchaseordersubstatus`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_quotebookingincident_connections1"></a> msdyn_quotebookingincident_connections1

One-To-Many Relationship: [msdyn_quotebookingincident msdyn_quotebookingincident_connections1](msdyn_quotebookingincident.md#BKMK_msdyn_quotebookingincident_connections1)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_quotebookingincident`|
|ReferencedAttribute|`msdyn_quotebookingincidentid`|
|ReferencingAttribute|`record1id`|
|ReferencingEntityNavigationPropertyName|`record1id_msdyn_quotebookingincident`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_quotebookingincident_connections2"></a> msdyn_quotebookingincident_connections2

One-To-Many Relationship: [msdyn_quotebookingincident msdyn_quotebookingincident_connections2](msdyn_quotebookingincident.md#BKMK_msdyn_quotebookingincident_connections2)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_quotebookingincident`|
|ReferencedAttribute|`msdyn_quotebookingincidentid`|
|ReferencingAttribute|`record2id`|
|ReferencingEntityNavigationPropertyName|`record2id_msdyn_quotebookingincident`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_quotebookingproduct_connections1"></a> msdyn_quotebookingproduct_connections1

One-To-Many Relationship: [msdyn_quotebookingproduct msdyn_quotebookingproduct_connections1](msdyn_quotebookingproduct.md#BKMK_msdyn_quotebookingproduct_connections1)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_quotebookingproduct`|
|ReferencedAttribute|`msdyn_quotebookingproductid`|
|ReferencingAttribute|`record1id`|
|ReferencingEntityNavigationPropertyName|`record1id_msdyn_quotebookingproduct`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_quotebookingproduct_connections2"></a> msdyn_quotebookingproduct_connections2

One-To-Many Relationship: [msdyn_quotebookingproduct msdyn_quotebookingproduct_connections2](msdyn_quotebookingproduct.md#BKMK_msdyn_quotebookingproduct_connections2)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_quotebookingproduct`|
|ReferencedAttribute|`msdyn_quotebookingproductid`|
|ReferencingAttribute|`record2id`|
|ReferencingEntityNavigationPropertyName|`record2id_msdyn_quotebookingproduct`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_quotebookingservice_connections1"></a> msdyn_quotebookingservice_connections1

One-To-Many Relationship: [msdyn_quotebookingservice msdyn_quotebookingservice_connections1](msdyn_quotebookingservice.md#BKMK_msdyn_quotebookingservice_connections1)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_quotebookingservice`|
|ReferencedAttribute|`msdyn_quotebookingserviceid`|
|ReferencingAttribute|`record1id`|
|ReferencingEntityNavigationPropertyName|`record1id_msdyn_quotebookingservice`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_quotebookingservice_connections2"></a> msdyn_quotebookingservice_connections2

One-To-Many Relationship: [msdyn_quotebookingservice msdyn_quotebookingservice_connections2](msdyn_quotebookingservice.md#BKMK_msdyn_quotebookingservice_connections2)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_quotebookingservice`|
|ReferencedAttribute|`msdyn_quotebookingserviceid`|
|ReferencingAttribute|`record2id`|
|ReferencingEntityNavigationPropertyName|`record2id_msdyn_quotebookingservice`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_quotebookingservicetask_connections1"></a> msdyn_quotebookingservicetask_connections1

One-To-Many Relationship: [msdyn_quotebookingservicetask msdyn_quotebookingservicetask_connections1](msdyn_quotebookingservicetask.md#BKMK_msdyn_quotebookingservicetask_connections1)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_quotebookingservicetask`|
|ReferencedAttribute|`msdyn_quotebookingservicetaskid`|
|ReferencingAttribute|`record1id`|
|ReferencingEntityNavigationPropertyName|`record1id_msdyn_quotebookingservicetask`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_quotebookingservicetask_connections2"></a> msdyn_quotebookingservicetask_connections2

One-To-Many Relationship: [msdyn_quotebookingservicetask msdyn_quotebookingservicetask_connections2](msdyn_quotebookingservicetask.md#BKMK_msdyn_quotebookingservicetask_connections2)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_quotebookingservicetask`|
|ReferencedAttribute|`msdyn_quotebookingservicetaskid`|
|ReferencingAttribute|`record2id`|
|ReferencingEntityNavigationPropertyName|`record2id_msdyn_quotebookingservicetask`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_resourceterritory_connections1"></a> msdyn_resourceterritory_connections1

One-To-Many Relationship: [msdyn_resourceterritory msdyn_resourceterritory_connections1](msdyn_resourceterritory.md#BKMK_msdyn_resourceterritory_connections1)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_resourceterritory`|
|ReferencedAttribute|`msdyn_resourceterritoryid`|
|ReferencingAttribute|`record1id`|
|ReferencingEntityNavigationPropertyName|`record1id_msdyn_resourceterritory`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_resourceterritory_connections2"></a> msdyn_resourceterritory_connections2

One-To-Many Relationship: [msdyn_resourceterritory msdyn_resourceterritory_connections2](msdyn_resourceterritory.md#BKMK_msdyn_resourceterritory_connections2)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_resourceterritory`|
|ReferencedAttribute|`msdyn_resourceterritoryid`|
|ReferencingAttribute|`record2id`|
|ReferencingEntityNavigationPropertyName|`record2id_msdyn_resourceterritory`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_rma_connections1"></a> msdyn_rma_connections1

One-To-Many Relationship: [msdyn_rma msdyn_rma_connections1](msdyn_rma.md#BKMK_msdyn_rma_connections1)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_rma`|
|ReferencedAttribute|`msdyn_rmaid`|
|ReferencingAttribute|`record1id`|
|ReferencingEntityNavigationPropertyName|`record1id_msdyn_rma`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_rma_connections2"></a> msdyn_rma_connections2

One-To-Many Relationship: [msdyn_rma msdyn_rma_connections2](msdyn_rma.md#BKMK_msdyn_rma_connections2)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_rma`|
|ReferencedAttribute|`msdyn_rmaid`|
|ReferencingAttribute|`record2id`|
|ReferencingEntityNavigationPropertyName|`record2id_msdyn_rma`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_rmaproduct_connections1"></a> msdyn_rmaproduct_connections1

One-To-Many Relationship: [msdyn_rmaproduct msdyn_rmaproduct_connections1](msdyn_rmaproduct.md#BKMK_msdyn_rmaproduct_connections1)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_rmaproduct`|
|ReferencedAttribute|`msdyn_rmaproductid`|
|ReferencingAttribute|`record1id`|
|ReferencingEntityNavigationPropertyName|`record1id_msdyn_rmaproduct`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_rmaproduct_connections2"></a> msdyn_rmaproduct_connections2

One-To-Many Relationship: [msdyn_rmaproduct msdyn_rmaproduct_connections2](msdyn_rmaproduct.md#BKMK_msdyn_rmaproduct_connections2)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_rmaproduct`|
|ReferencedAttribute|`msdyn_rmaproductid`|
|ReferencingAttribute|`record2id`|
|ReferencingEntityNavigationPropertyName|`record2id_msdyn_rmaproduct`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_rmareceipt_connections1"></a> msdyn_rmareceipt_connections1

One-To-Many Relationship: [msdyn_rmareceipt msdyn_rmareceipt_connections1](msdyn_rmareceipt.md#BKMK_msdyn_rmareceipt_connections1)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_rmareceipt`|
|ReferencedAttribute|`msdyn_rmareceiptid`|
|ReferencingAttribute|`record1id`|
|ReferencingEntityNavigationPropertyName|`record1id_msdyn_rmareceipt`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_rmareceipt_connections2"></a> msdyn_rmareceipt_connections2

One-To-Many Relationship: [msdyn_rmareceipt msdyn_rmareceipt_connections2](msdyn_rmareceipt.md#BKMK_msdyn_rmareceipt_connections2)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_rmareceipt`|
|ReferencedAttribute|`msdyn_rmareceiptid`|
|ReferencingAttribute|`record2id`|
|ReferencingEntityNavigationPropertyName|`record2id_msdyn_rmareceipt`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_rmareceiptproduct_connections1"></a> msdyn_rmareceiptproduct_connections1

One-To-Many Relationship: [msdyn_rmareceiptproduct msdyn_rmareceiptproduct_connections1](msdyn_rmareceiptproduct.md#BKMK_msdyn_rmareceiptproduct_connections1)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_rmareceiptproduct`|
|ReferencedAttribute|`msdyn_rmareceiptproductid`|
|ReferencingAttribute|`record1id`|
|ReferencingEntityNavigationPropertyName|`record1id_msdyn_rmareceiptproduct`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_rmareceiptproduct_connections2"></a> msdyn_rmareceiptproduct_connections2

One-To-Many Relationship: [msdyn_rmareceiptproduct msdyn_rmareceiptproduct_connections2](msdyn_rmareceiptproduct.md#BKMK_msdyn_rmareceiptproduct_connections2)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_rmareceiptproduct`|
|ReferencedAttribute|`msdyn_rmareceiptproductid`|
|ReferencingAttribute|`record2id`|
|ReferencingEntityNavigationPropertyName|`record2id_msdyn_rmareceiptproduct`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_rmasubstatus_connections1"></a> msdyn_rmasubstatus_connections1

One-To-Many Relationship: [msdyn_rmasubstatus msdyn_rmasubstatus_connections1](msdyn_rmasubstatus.md#BKMK_msdyn_rmasubstatus_connections1)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_rmasubstatus`|
|ReferencedAttribute|`msdyn_rmasubstatusid`|
|ReferencingAttribute|`record1id`|
|ReferencingEntityNavigationPropertyName|`record1id_msdyn_rmasubstatus`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_rmasubstatus_connections2"></a> msdyn_rmasubstatus_connections2

One-To-Many Relationship: [msdyn_rmasubstatus msdyn_rmasubstatus_connections2](msdyn_rmasubstatus.md#BKMK_msdyn_rmasubstatus_connections2)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_rmasubstatus`|
|ReferencedAttribute|`msdyn_rmasubstatusid`|
|ReferencingAttribute|`record2id`|
|ReferencingEntityNavigationPropertyName|`record2id_msdyn_rmasubstatus`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_routingoptimizationrequest_connections1"></a> msdyn_routingoptimizationrequest_connections1

One-To-Many Relationship: [msdyn_routingoptimizationrequest msdyn_routingoptimizationrequest_connections1](msdyn_routingoptimizationrequest.md#BKMK_msdyn_routingoptimizationrequest_connections1)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_routingoptimizationrequest`|
|ReferencedAttribute|`msdyn_routingoptimizationrequestid`|
|ReferencingAttribute|`record1id`|
|ReferencingEntityNavigationPropertyName|`record1id_msdyn_routingoptimizationrequest`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_routingoptimizationrequest_connections2"></a> msdyn_routingoptimizationrequest_connections2

One-To-Many Relationship: [msdyn_routingoptimizationrequest msdyn_routingoptimizationrequest_connections2](msdyn_routingoptimizationrequest.md#BKMK_msdyn_routingoptimizationrequest_connections2)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_routingoptimizationrequest`|
|ReferencedAttribute|`msdyn_routingoptimizationrequestid`|
|ReferencingAttribute|`record2id`|
|ReferencingEntityNavigationPropertyName|`record2id_msdyn_routingoptimizationrequest`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_rtv_connections1"></a> msdyn_rtv_connections1

One-To-Many Relationship: [msdyn_rtv msdyn_rtv_connections1](msdyn_rtv.md#BKMK_msdyn_rtv_connections1)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_rtv`|
|ReferencedAttribute|`msdyn_rtvid`|
|ReferencingAttribute|`record1id`|
|ReferencingEntityNavigationPropertyName|`record1id_msdyn_rtv`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_rtv_connections2"></a> msdyn_rtv_connections2

One-To-Many Relationship: [msdyn_rtv msdyn_rtv_connections2](msdyn_rtv.md#BKMK_msdyn_rtv_connections2)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_rtv`|
|ReferencedAttribute|`msdyn_rtvid`|
|ReferencingAttribute|`record2id`|
|ReferencingEntityNavigationPropertyName|`record2id_msdyn_rtv`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_rtvproduct_connections1"></a> msdyn_rtvproduct_connections1

One-To-Many Relationship: [msdyn_rtvproduct msdyn_rtvproduct_connections1](msdyn_rtvproduct.md#BKMK_msdyn_rtvproduct_connections1)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_rtvproduct`|
|ReferencedAttribute|`msdyn_rtvproductid`|
|ReferencingAttribute|`record1id`|
|ReferencingEntityNavigationPropertyName|`record1id_msdyn_rtvproduct`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_rtvproduct_connections2"></a> msdyn_rtvproduct_connections2

One-To-Many Relationship: [msdyn_rtvproduct msdyn_rtvproduct_connections2](msdyn_rtvproduct.md#BKMK_msdyn_rtvproduct_connections2)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_rtvproduct`|
|ReferencedAttribute|`msdyn_rtvproductid`|
|ReferencingAttribute|`record2id`|
|ReferencingEntityNavigationPropertyName|`record2id_msdyn_rtvproduct`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_rtvsubstatus_connections1"></a> msdyn_rtvsubstatus_connections1

One-To-Many Relationship: [msdyn_rtvsubstatus msdyn_rtvsubstatus_connections1](msdyn_rtvsubstatus.md#BKMK_msdyn_rtvsubstatus_connections1)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_rtvsubstatus`|
|ReferencedAttribute|`msdyn_rtvsubstatusid`|
|ReferencingAttribute|`record1id`|
|ReferencingEntityNavigationPropertyName|`record1id_msdyn_rtvsubstatus`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_rtvsubstatus_connections2"></a> msdyn_rtvsubstatus_connections2

One-To-Many Relationship: [msdyn_rtvsubstatus msdyn_rtvsubstatus_connections2](msdyn_rtvsubstatus.md#BKMK_msdyn_rtvsubstatus_connections2)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_rtvsubstatus`|
|ReferencedAttribute|`msdyn_rtvsubstatusid`|
|ReferencingAttribute|`record2id`|
|ReferencingEntityNavigationPropertyName|`record2id_msdyn_rtvsubstatus`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_salessuggestion_connections1"></a> msdyn_salessuggestion_connections1

One-To-Many Relationship: [msdyn_salessuggestion msdyn_salessuggestion_connections1](msdyn_salessuggestion.md#BKMK_msdyn_salessuggestion_connections1)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_salessuggestion`|
|ReferencedAttribute|`msdyn_salessuggestionid`|
|ReferencingAttribute|`record1id`|
|ReferencingEntityNavigationPropertyName|`record1id_msdyn_salessuggestion`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_salessuggestion_connections2"></a> msdyn_salessuggestion_connections2

One-To-Many Relationship: [msdyn_salessuggestion msdyn_salessuggestion_connections2](msdyn_salessuggestion.md#BKMK_msdyn_salessuggestion_connections2)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_salessuggestion`|
|ReferencedAttribute|`msdyn_salessuggestionid`|
|ReferencingAttribute|`record2id`|
|ReferencingEntityNavigationPropertyName|`record2id_msdyn_salessuggestion`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_sequence_connections1"></a> msdyn_sequence_connections1

One-To-Many Relationship: [msdyn_sequence msdyn_sequence_connections1](msdyn_sequence.md#BKMK_msdyn_sequence_connections1)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_sequence`|
|ReferencedAttribute|`msdyn_sequenceid`|
|ReferencingAttribute|`record1id`|
|ReferencingEntityNavigationPropertyName|`record1id_msdyn_sequence`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_sequence_connections2"></a> msdyn_sequence_connections2

One-To-Many Relationship: [msdyn_sequence msdyn_sequence_connections2](msdyn_sequence.md#BKMK_msdyn_sequence_connections2)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_sequence`|
|ReferencedAttribute|`msdyn_sequenceid`|
|ReferencingAttribute|`record2id`|
|ReferencingEntityNavigationPropertyName|`record2id_msdyn_sequence`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_sequencetarget_connections1"></a> msdyn_sequencetarget_connections1

One-To-Many Relationship: [msdyn_sequencetarget msdyn_sequencetarget_connections1](msdyn_sequencetarget.md#BKMK_msdyn_sequencetarget_connections1)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_sequencetarget`|
|ReferencedAttribute|`msdyn_sequencetargetid`|
|ReferencingAttribute|`record1id`|
|ReferencingEntityNavigationPropertyName|`record1id_msdyn_sequencetarget`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_sequencetarget_connections2"></a> msdyn_sequencetarget_connections2

One-To-Many Relationship: [msdyn_sequencetarget msdyn_sequencetarget_connections2](msdyn_sequencetarget.md#BKMK_msdyn_sequencetarget_connections2)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_sequencetarget`|
|ReferencedAttribute|`msdyn_sequencetargetid`|
|ReferencingAttribute|`record2id`|
|ReferencingEntityNavigationPropertyName|`record2id_msdyn_sequencetarget`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_shipvia_connections1"></a> msdyn_shipvia_connections1

One-To-Many Relationship: [msdyn_shipvia msdyn_shipvia_connections1](msdyn_shipvia.md#BKMK_msdyn_shipvia_connections1)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_shipvia`|
|ReferencedAttribute|`msdyn_shipviaid`|
|ReferencingAttribute|`record1id`|
|ReferencingEntityNavigationPropertyName|`record1id_msdyn_shipvia`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_shipvia_connections2"></a> msdyn_shipvia_connections2

One-To-Many Relationship: [msdyn_shipvia msdyn_shipvia_connections2](msdyn_shipvia.md#BKMK_msdyn_shipvia_connections2)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_shipvia`|
|ReferencedAttribute|`msdyn_shipviaid`|
|ReferencingAttribute|`record2id`|
|ReferencingEntityNavigationPropertyName|`record2id_msdyn_shipvia`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_suggestionprincipalobjectaccess_connections1"></a> msdyn_suggestionprincipalobjectaccess_connections1

One-To-Many Relationship: [msdyn_suggestionprincipalobjectaccess msdyn_suggestionprincipalobjectaccess_connections1](msdyn_suggestionprincipalobjectaccess.md#BKMK_msdyn_suggestionprincipalobjectaccess_connections1)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_suggestionprincipalobjectaccess`|
|ReferencedAttribute|`msdyn_suggestionprincipalobjectaccessid`|
|ReferencingAttribute|`record1id`|
|ReferencingEntityNavigationPropertyName|`record1id_msdyn_suggestionprincipalobjectaccess`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_suggestionprincipalobjectaccess_connections2"></a> msdyn_suggestionprincipalobjectaccess_connections2

One-To-Many Relationship: [msdyn_suggestionprincipalobjectaccess msdyn_suggestionprincipalobjectaccess_connections2](msdyn_suggestionprincipalobjectaccess.md#BKMK_msdyn_suggestionprincipalobjectaccess_connections2)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_suggestionprincipalobjectaccess`|
|ReferencedAttribute|`msdyn_suggestionprincipalobjectaccessid`|
|ReferencingAttribute|`record2id`|
|ReferencingEntityNavigationPropertyName|`record2id_msdyn_suggestionprincipalobjectaccess`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_systemuserschedulersetting_connections1"></a> msdyn_systemuserschedulersetting_connections1

One-To-Many Relationship: [msdyn_systemuserschedulersetting msdyn_systemuserschedulersetting_connections1](msdyn_systemuserschedulersetting.md#BKMK_msdyn_systemuserschedulersetting_connections1)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_systemuserschedulersetting`|
|ReferencedAttribute|`msdyn_systemuserschedulersettingid`|
|ReferencingAttribute|`record1id`|
|ReferencingEntityNavigationPropertyName|`record1id_msdyn_systemuserschedulersetting`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_systemuserschedulersetting_connections2"></a> msdyn_systemuserschedulersetting_connections2

One-To-Many Relationship: [msdyn_systemuserschedulersetting msdyn_systemuserschedulersetting_connections2](msdyn_systemuserschedulersetting.md#BKMK_msdyn_systemuserschedulersetting_connections2)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_systemuserschedulersetting`|
|ReferencedAttribute|`msdyn_systemuserschedulersettingid`|
|ReferencingAttribute|`record2id`|
|ReferencingEntityNavigationPropertyName|`record2id_msdyn_systemuserschedulersetting`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_taxcode_connections1"></a> msdyn_taxcode_connections1

One-To-Many Relationship: [msdyn_taxcode msdyn_taxcode_connections1](msdyn_taxcode.md#BKMK_msdyn_taxcode_connections1)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_taxcode`|
|ReferencedAttribute|`msdyn_taxcodeid`|
|ReferencingAttribute|`record1id`|
|ReferencingEntityNavigationPropertyName|`record1id_msdyn_taxcode`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_taxcode_connections2"></a> msdyn_taxcode_connections2

One-To-Many Relationship: [msdyn_taxcode msdyn_taxcode_connections2](msdyn_taxcode.md#BKMK_msdyn_taxcode_connections2)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_taxcode`|
|ReferencedAttribute|`msdyn_taxcodeid`|
|ReferencingAttribute|`record2id`|
|ReferencingEntityNavigationPropertyName|`record2id_msdyn_taxcode`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_timegroup_connections1"></a> msdyn_timegroup_connections1

One-To-Many Relationship: [msdyn_timegroup msdyn_timegroup_connections1](msdyn_timegroup.md#BKMK_msdyn_timegroup_connections1)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_timegroup`|
|ReferencedAttribute|`msdyn_timegroupid`|
|ReferencingAttribute|`record1id`|
|ReferencingEntityNavigationPropertyName|`record1id_msdyn_timegroup`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_timegroup_connections2"></a> msdyn_timegroup_connections2

One-To-Many Relationship: [msdyn_timegroup msdyn_timegroup_connections2](msdyn_timegroup.md#BKMK_msdyn_timegroup_connections2)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_timegroup`|
|ReferencedAttribute|`msdyn_timegroupid`|
|ReferencingAttribute|`record2id`|
|ReferencingEntityNavigationPropertyName|`record2id_msdyn_timegroup`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_timegroupdetail_connections1"></a> msdyn_timegroupdetail_connections1

One-To-Many Relationship: [msdyn_timegroupdetail msdyn_timegroupdetail_connections1](msdyn_timegroupdetail.md#BKMK_msdyn_timegroupdetail_connections1)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_timegroupdetail`|
|ReferencedAttribute|`msdyn_timegroupdetailid`|
|ReferencingAttribute|`record1id`|
|ReferencingEntityNavigationPropertyName|`record1id_msdyn_timegroupdetail`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_timegroupdetail_connections2"></a> msdyn_timegroupdetail_connections2

One-To-Many Relationship: [msdyn_timegroupdetail msdyn_timegroupdetail_connections2](msdyn_timegroupdetail.md#BKMK_msdyn_timegroupdetail_connections2)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_timegroupdetail`|
|ReferencedAttribute|`msdyn_timegroupdetailid`|
|ReferencingAttribute|`record2id`|
|ReferencingEntityNavigationPropertyName|`record2id_msdyn_timegroupdetail`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_timeoffrequest_connections1"></a> msdyn_timeoffrequest_connections1

One-To-Many Relationship: [msdyn_timeoffrequest msdyn_timeoffrequest_connections1](msdyn_timeoffrequest.md#BKMK_msdyn_timeoffrequest_connections1)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_timeoffrequest`|
|ReferencedAttribute|`msdyn_timeoffrequestid`|
|ReferencingAttribute|`record1id`|
|ReferencingEntityNavigationPropertyName|`record1id_msdyn_timeoffrequest`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_timeoffrequest_connections2"></a> msdyn_timeoffrequest_connections2

One-To-Many Relationship: [msdyn_timeoffrequest msdyn_timeoffrequest_connections2](msdyn_timeoffrequest.md#BKMK_msdyn_timeoffrequest_connections2)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_timeoffrequest`|
|ReferencedAttribute|`msdyn_timeoffrequestid`|
|ReferencingAttribute|`record2id`|
|ReferencingEntityNavigationPropertyName|`record2id_msdyn_timeoffrequest`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_warehouse_connections1"></a> msdyn_warehouse_connections1

One-To-Many Relationship: [msdyn_warehouse msdyn_warehouse_connections1](msdyn_warehouse.md#BKMK_msdyn_warehouse_connections1)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_warehouse`|
|ReferencedAttribute|`msdyn_warehouseid`|
|ReferencingAttribute|`record1id`|
|ReferencingEntityNavigationPropertyName|`record1id_msdyn_warehouse`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_warehouse_connections2"></a> msdyn_warehouse_connections2

One-To-Many Relationship: [msdyn_warehouse msdyn_warehouse_connections2](msdyn_warehouse.md#BKMK_msdyn_warehouse_connections2)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_warehouse`|
|ReferencedAttribute|`msdyn_warehouseid`|
|ReferencingAttribute|`record2id`|
|ReferencingEntityNavigationPropertyName|`record2id_msdyn_warehouse`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_workorder_connections1"></a> msdyn_workorder_connections1

One-To-Many Relationship: [msdyn_workorder msdyn_workorder_connections1](msdyn_workorder.md#BKMK_msdyn_workorder_connections1)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_workorder`|
|ReferencedAttribute|`msdyn_workorderid`|
|ReferencingAttribute|`record1id`|
|ReferencingEntityNavigationPropertyName|`record1id_msdyn_workorder`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_workorder_connections2"></a> msdyn_workorder_connections2

One-To-Many Relationship: [msdyn_workorder msdyn_workorder_connections2](msdyn_workorder.md#BKMK_msdyn_workorder_connections2)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_workorder`|
|ReferencedAttribute|`msdyn_workorderid`|
|ReferencingAttribute|`record2id`|
|ReferencingEntityNavigationPropertyName|`record2id_msdyn_workorder`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_workordercharacteristic_connections1"></a> msdyn_workordercharacteristic_connections1

One-To-Many Relationship: [msdyn_workordercharacteristic msdyn_workordercharacteristic_connections1](msdyn_workordercharacteristic.md#BKMK_msdyn_workordercharacteristic_connections1)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_workordercharacteristic`|
|ReferencedAttribute|`msdyn_workordercharacteristicid`|
|ReferencingAttribute|`record1id`|
|ReferencingEntityNavigationPropertyName|`record1id_msdyn_workordercharacteristic`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_workordercharacteristic_connections2"></a> msdyn_workordercharacteristic_connections2

One-To-Many Relationship: [msdyn_workordercharacteristic msdyn_workordercharacteristic_connections2](msdyn_workordercharacteristic.md#BKMK_msdyn_workordercharacteristic_connections2)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_workordercharacteristic`|
|ReferencedAttribute|`msdyn_workordercharacteristicid`|
|ReferencingAttribute|`record2id`|
|ReferencingEntityNavigationPropertyName|`record2id_msdyn_workordercharacteristic`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_workorderincident_connections1"></a> msdyn_workorderincident_connections1

One-To-Many Relationship: [msdyn_workorderincident msdyn_workorderincident_connections1](msdyn_workorderincident.md#BKMK_msdyn_workorderincident_connections1)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_workorderincident`|
|ReferencedAttribute|`msdyn_workorderincidentid`|
|ReferencingAttribute|`record1id`|
|ReferencingEntityNavigationPropertyName|`record1id_msdyn_workorderincident`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_workorderincident_connections2"></a> msdyn_workorderincident_connections2

One-To-Many Relationship: [msdyn_workorderincident msdyn_workorderincident_connections2](msdyn_workorderincident.md#BKMK_msdyn_workorderincident_connections2)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_workorderincident`|
|ReferencedAttribute|`msdyn_workorderincidentid`|
|ReferencingAttribute|`record2id`|
|ReferencingEntityNavigationPropertyName|`record2id_msdyn_workorderincident`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_workorderproduct_connections1"></a> msdyn_workorderproduct_connections1

One-To-Many Relationship: [msdyn_workorderproduct msdyn_workorderproduct_connections1](msdyn_workorderproduct.md#BKMK_msdyn_workorderproduct_connections1)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_workorderproduct`|
|ReferencedAttribute|`msdyn_workorderproductid`|
|ReferencingAttribute|`record1id`|
|ReferencingEntityNavigationPropertyName|`record1id_msdyn_workorderproduct`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_workorderproduct_connections2"></a> msdyn_workorderproduct_connections2

One-To-Many Relationship: [msdyn_workorderproduct msdyn_workorderproduct_connections2](msdyn_workorderproduct.md#BKMK_msdyn_workorderproduct_connections2)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_workorderproduct`|
|ReferencedAttribute|`msdyn_workorderproductid`|
|ReferencingAttribute|`record2id`|
|ReferencingEntityNavigationPropertyName|`record2id_msdyn_workorderproduct`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_workorderresourcerestriction_connections1"></a> msdyn_workorderresourcerestriction_connections1

One-To-Many Relationship: [msdyn_workorderresourcerestriction msdyn_workorderresourcerestriction_connections1](msdyn_workorderresourcerestriction.md#BKMK_msdyn_workorderresourcerestriction_connections1)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_workorderresourcerestriction`|
|ReferencedAttribute|`msdyn_workorderresourcerestrictionid`|
|ReferencingAttribute|`record1id`|
|ReferencingEntityNavigationPropertyName|`record1id_msdyn_workorderresourcerestriction`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_workorderresourcerestriction_connections2"></a> msdyn_workorderresourcerestriction_connections2

One-To-Many Relationship: [msdyn_workorderresourcerestriction msdyn_workorderresourcerestriction_connections2](msdyn_workorderresourcerestriction.md#BKMK_msdyn_workorderresourcerestriction_connections2)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_workorderresourcerestriction`|
|ReferencedAttribute|`msdyn_workorderresourcerestrictionid`|
|ReferencingAttribute|`record2id`|
|ReferencingEntityNavigationPropertyName|`record2id_msdyn_workorderresourcerestriction`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_workorderservice_connections1"></a> msdyn_workorderservice_connections1

One-To-Many Relationship: [msdyn_workorderservice msdyn_workorderservice_connections1](msdyn_workorderservice.md#BKMK_msdyn_workorderservice_connections1)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_workorderservice`|
|ReferencedAttribute|`msdyn_workorderserviceid`|
|ReferencingAttribute|`record1id`|
|ReferencingEntityNavigationPropertyName|`record1id_msdyn_workorderservice`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_workorderservice_connections2"></a> msdyn_workorderservice_connections2

One-To-Many Relationship: [msdyn_workorderservice msdyn_workorderservice_connections2](msdyn_workorderservice.md#BKMK_msdyn_workorderservice_connections2)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_workorderservice`|
|ReferencedAttribute|`msdyn_workorderserviceid`|
|ReferencingAttribute|`record2id`|
|ReferencingEntityNavigationPropertyName|`record2id_msdyn_workorderservice`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_workorderservicetask_connections1"></a> msdyn_workorderservicetask_connections1

One-To-Many Relationship: [msdyn_workorderservicetask msdyn_workorderservicetask_connections1](msdyn_workorderservicetask.md#BKMK_msdyn_workorderservicetask_connections1)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_workorderservicetask`|
|ReferencedAttribute|`msdyn_workorderservicetaskid`|
|ReferencingAttribute|`record1id`|
|ReferencingEntityNavigationPropertyName|`record1id_msdyn_workorderservicetask`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_workorderservicetask_connections2"></a> msdyn_workorderservicetask_connections2

One-To-Many Relationship: [msdyn_workorderservicetask msdyn_workorderservicetask_connections2](msdyn_workorderservicetask.md#BKMK_msdyn_workorderservicetask_connections2)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_workorderservicetask`|
|ReferencedAttribute|`msdyn_workorderservicetaskid`|
|ReferencingAttribute|`record2id`|
|ReferencingEntityNavigationPropertyName|`record2id_msdyn_workorderservicetask`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyncrm_appointmentactivitymarketingtemplate_connections1"></a> msdyncrm_appointmentactivitymarketingtemplate_connections1

One-To-Many Relationship: [msdyncrm_appointmentactivitymarketingtemplate msdyncrm_appointmentactivitymarketingtemplate_connections1](msdyncrm_appointmentactivitymarketingtemplate.md#BKMK_msdyncrm_appointmentactivitymarketingtemplate_connections1)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyncrm_appointmentactivitymarketingtemplate`|
|ReferencedAttribute|`msdyncrm_appointmentactivitymarketingtemplateid`|
|ReferencingAttribute|`record1id`|
|ReferencingEntityNavigationPropertyName|`record1id_msdyncrm_appointmentactivitymarketingtemplate`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyncrm_appointmentactivitymarketingtemplate_connections2"></a> msdyncrm_appointmentactivitymarketingtemplate_connections2

One-To-Many Relationship: [msdyncrm_appointmentactivitymarketingtemplate msdyncrm_appointmentactivitymarketingtemplate_connections2](msdyncrm_appointmentactivitymarketingtemplate.md#BKMK_msdyncrm_appointmentactivitymarketingtemplate_connections2)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyncrm_appointmentactivitymarketingtemplate`|
|ReferencedAttribute|`msdyncrm_appointmentactivitymarketingtemplateid`|
|ReferencingAttribute|`record2id`|
|ReferencingEntityNavigationPropertyName|`record2id_msdyncrm_appointmentactivitymarketingtemplate`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyncrm_contentsettings_connections1"></a> msdyncrm_contentsettings_connections1

One-To-Many Relationship: [msdyncrm_contentsettings msdyncrm_contentsettings_connections1](msdyncrm_contentsettings.md#BKMK_msdyncrm_contentsettings_connections1)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyncrm_contentsettings`|
|ReferencedAttribute|`msdyncrm_contentsettingsid`|
|ReferencingAttribute|`record1id`|
|ReferencingEntityNavigationPropertyName|`record1id_msdyncrm_contentsettings`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyncrm_contentsettings_connections2"></a> msdyncrm_contentsettings_connections2

One-To-Many Relationship: [msdyncrm_contentsettings msdyncrm_contentsettings_connections2](msdyncrm_contentsettings.md#BKMK_msdyncrm_contentsettings_connections2)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyncrm_contentsettings`|
|ReferencedAttribute|`msdyncrm_contentsettingsid`|
|ReferencingAttribute|`record2id`|
|ReferencingEntityNavigationPropertyName|`record2id_msdyncrm_contentsettings`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyncrm_leadscoremodel_connections1"></a> msdyncrm_leadscoremodel_connections1

One-To-Many Relationship: [msdyncrm_leadscoremodel msdyncrm_leadscoremodel_connections1](msdyncrm_leadscoremodel.md#BKMK_msdyncrm_leadscoremodel_connections1)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyncrm_leadscoremodel`|
|ReferencedAttribute|`msdyncrm_leadscoremodelid`|
|ReferencingAttribute|`record1id`|
|ReferencingEntityNavigationPropertyName|`record1id_msdyncrm_leadscoremodel`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyncrm_leadscoremodel_connections2"></a> msdyncrm_leadscoremodel_connections2

One-To-Many Relationship: [msdyncrm_leadscoremodel msdyncrm_leadscoremodel_connections2](msdyncrm_leadscoremodel.md#BKMK_msdyncrm_leadscoremodel_connections2)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyncrm_leadscoremodel`|
|ReferencedAttribute|`msdyncrm_leadscoremodelid`|
|ReferencingAttribute|`record2id`|
|ReferencingEntityNavigationPropertyName|`record2id_msdyncrm_leadscoremodel`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyncrm_linkedinaccount_connections1"></a> msdyncrm_linkedinaccount_connections1

One-To-Many Relationship: [msdyncrm_linkedinaccount msdyncrm_linkedinaccount_connections1](msdyncrm_linkedinaccount.md#BKMK_msdyncrm_linkedinaccount_connections1)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyncrm_linkedinaccount`|
|ReferencedAttribute|`msdyncrm_linkedinaccountid`|
|ReferencingAttribute|`record1id`|
|ReferencingEntityNavigationPropertyName|`record1id_msdyncrm_linkedinaccount`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyncrm_linkedinaccount_connections2"></a> msdyncrm_linkedinaccount_connections2

One-To-Many Relationship: [msdyncrm_linkedinaccount msdyncrm_linkedinaccount_connections2](msdyncrm_linkedinaccount.md#BKMK_msdyncrm_linkedinaccount_connections2)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyncrm_linkedinaccount`|
|ReferencedAttribute|`msdyncrm_linkedinaccountid`|
|ReferencingAttribute|`record2id`|
|ReferencingEntityNavigationPropertyName|`record2id_msdyncrm_linkedinaccount`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyncrm_linkedinactivity_connections1"></a> msdyncrm_linkedinactivity_connections1

One-To-Many Relationship: [msdyncrm_linkedinactivity msdyncrm_linkedinactivity_connections1](msdyncrm_linkedinactivity.md#BKMK_msdyncrm_linkedinactivity_connections1)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyncrm_linkedinactivity`|
|ReferencedAttribute|`msdyncrm_linkedinactivityid`|
|ReferencingAttribute|`record1id`|
|ReferencingEntityNavigationPropertyName|`record1id_msdyncrm_linkedinactivity`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyncrm_linkedinactivity_connections2"></a> msdyncrm_linkedinactivity_connections2

One-To-Many Relationship: [msdyncrm_linkedinactivity msdyncrm_linkedinactivity_connections2](msdyncrm_linkedinactivity.md#BKMK_msdyncrm_linkedinactivity_connections2)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyncrm_linkedinactivity`|
|ReferencedAttribute|`msdyncrm_linkedinactivityid`|
|ReferencingAttribute|`record2id`|
|ReferencingEntityNavigationPropertyName|`record2id_msdyncrm_linkedinactivity`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyncrm_linkedinfieldmapping_connections1"></a> msdyncrm_linkedinfieldmapping_connections1

One-To-Many Relationship: [msdyncrm_linkedinfieldmapping msdyncrm_linkedinfieldmapping_connections1](msdyncrm_linkedinfieldmapping.md#BKMK_msdyncrm_linkedinfieldmapping_connections1)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyncrm_linkedinfieldmapping`|
|ReferencedAttribute|`msdyncrm_linkedinfieldmappingid`|
|ReferencingAttribute|`record1id`|
|ReferencingEntityNavigationPropertyName|`record1id_msdyncrm_linkedinfieldmapping`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyncrm_linkedinfieldmapping_connections2"></a> msdyncrm_linkedinfieldmapping_connections2

One-To-Many Relationship: [msdyncrm_linkedinfieldmapping msdyncrm_linkedinfieldmapping_connections2](msdyncrm_linkedinfieldmapping.md#BKMK_msdyncrm_linkedinfieldmapping_connections2)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyncrm_linkedinfieldmapping`|
|ReferencedAttribute|`msdyncrm_linkedinfieldmappingid`|
|ReferencingAttribute|`record2id`|
|ReferencingEntityNavigationPropertyName|`record2id_msdyncrm_linkedinfieldmapping`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyncrm_linkedinform_connections1"></a> msdyncrm_linkedinform_connections1

One-To-Many Relationship: [msdyncrm_linkedinform msdyncrm_linkedinform_connections1](msdyncrm_linkedinform.md#BKMK_msdyncrm_linkedinform_connections1)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyncrm_linkedinform`|
|ReferencedAttribute|`msdyncrm_linkedinformid`|
|ReferencingAttribute|`record1id`|
|ReferencingEntityNavigationPropertyName|`record1id_msdyncrm_linkedinform`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyncrm_linkedinform_connections2"></a> msdyncrm_linkedinform_connections2

One-To-Many Relationship: [msdyncrm_linkedinform msdyncrm_linkedinform_connections2](msdyncrm_linkedinform.md#BKMK_msdyncrm_linkedinform_connections2)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyncrm_linkedinform`|
|ReferencedAttribute|`msdyncrm_linkedinformid`|
|ReferencingAttribute|`record2id`|
|ReferencingEntityNavigationPropertyName|`record2id_msdyncrm_linkedinform`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyncrm_linkedinformanswer_connections1"></a> msdyncrm_linkedinformanswer_connections1

One-To-Many Relationship: [msdyncrm_linkedinformanswer msdyncrm_linkedinformanswer_connections1](msdyncrm_linkedinformanswer.md#BKMK_msdyncrm_linkedinformanswer_connections1)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyncrm_linkedinformanswer`|
|ReferencedAttribute|`msdyncrm_linkedinformanswerid`|
|ReferencingAttribute|`record1id`|
|ReferencingEntityNavigationPropertyName|`record1id_msdyncrm_linkedinformanswer`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyncrm_linkedinformanswer_connections2"></a> msdyncrm_linkedinformanswer_connections2

One-To-Many Relationship: [msdyncrm_linkedinformanswer msdyncrm_linkedinformanswer_connections2](msdyncrm_linkedinformanswer.md#BKMK_msdyncrm_linkedinformanswer_connections2)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyncrm_linkedinformanswer`|
|ReferencedAttribute|`msdyncrm_linkedinformanswerid`|
|ReferencingAttribute|`record2id`|
|ReferencingEntityNavigationPropertyName|`record2id_msdyncrm_linkedinformanswer`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyncrm_linkedinformquestion_connections1"></a> msdyncrm_linkedinformquestion_connections1

One-To-Many Relationship: [msdyncrm_linkedinformquestion msdyncrm_linkedinformquestion_connections1](msdyncrm_linkedinformquestion.md#BKMK_msdyncrm_linkedinformquestion_connections1)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyncrm_linkedinformquestion`|
|ReferencedAttribute|`msdyncrm_linkedinformquestionid`|
|ReferencingAttribute|`record1id`|
|ReferencingEntityNavigationPropertyName|`record1id_msdyncrm_linkedinformquestion`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyncrm_linkedinformquestion_connections2"></a> msdyncrm_linkedinformquestion_connections2

One-To-Many Relationship: [msdyncrm_linkedinformquestion msdyncrm_linkedinformquestion_connections2](msdyncrm_linkedinformquestion.md#BKMK_msdyncrm_linkedinformquestion_connections2)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyncrm_linkedinformquestion`|
|ReferencedAttribute|`msdyncrm_linkedinformquestionid`|
|ReferencingAttribute|`record2id`|
|ReferencingEntityNavigationPropertyName|`record2id_msdyncrm_linkedinformquestion`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyncrm_linkedinformsubmission_connections1"></a> msdyncrm_linkedinformsubmission_connections1

One-To-Many Relationship: [msdyncrm_linkedinformsubmission msdyncrm_linkedinformsubmission_connections1](msdyncrm_linkedinformsubmission.md#BKMK_msdyncrm_linkedinformsubmission_connections1)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyncrm_linkedinformsubmission`|
|ReferencedAttribute|`msdyncrm_linkedinformsubmissionid`|
|ReferencingAttribute|`record1id`|
|ReferencingEntityNavigationPropertyName|`record1id_msdyncrm_linkedinformsubmission`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyncrm_linkedinformsubmission_connections2"></a> msdyncrm_linkedinformsubmission_connections2

One-To-Many Relationship: [msdyncrm_linkedinformsubmission msdyncrm_linkedinformsubmission_connections2](msdyncrm_linkedinformsubmission.md#BKMK_msdyncrm_linkedinformsubmission_connections2)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyncrm_linkedinformsubmission`|
|ReferencedAttribute|`msdyncrm_linkedinformsubmissionid`|
|ReferencingAttribute|`record2id`|
|ReferencingEntityNavigationPropertyName|`record2id_msdyncrm_linkedinformsubmission`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyncrm_linkedinleadmatchingstrategy_connections1"></a> msdyncrm_linkedinleadmatchingstrategy_connections1

One-To-Many Relationship: [msdyncrm_linkedinleadmatchingstrategy msdyncrm_linkedinleadmatchingstrategy_connections1](msdyncrm_linkedinleadmatchingstrategy.md#BKMK_msdyncrm_linkedinleadmatchingstrategy_connections1)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyncrm_linkedinleadmatchingstrategy`|
|ReferencedAttribute|`msdyncrm_linkedinleadmatchingstrategyid`|
|ReferencingAttribute|`record1id`|
|ReferencingEntityNavigationPropertyName|`record1id_msdyncrm_linkedinleadmatchingstrategy`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyncrm_linkedinleadmatchingstrategy_connections2"></a> msdyncrm_linkedinleadmatchingstrategy_connections2

One-To-Many Relationship: [msdyncrm_linkedinleadmatchingstrategy msdyncrm_linkedinleadmatchingstrategy_connections2](msdyncrm_linkedinleadmatchingstrategy.md#BKMK_msdyncrm_linkedinleadmatchingstrategy_connections2)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyncrm_linkedinleadmatchingstrategy`|
|ReferencedAttribute|`msdyncrm_linkedinleadmatchingstrategyid`|
|ReferencingAttribute|`record2id`|
|ReferencingEntityNavigationPropertyName|`record2id_msdyncrm_linkedinleadmatchingstrategy`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyncrm_linkedinuserprofile_connections1"></a> msdyncrm_linkedinuserprofile_connections1

One-To-Many Relationship: [msdyncrm_linkedinuserprofile msdyncrm_linkedinuserprofile_connections1](msdyncrm_linkedinuserprofile.md#BKMK_msdyncrm_linkedinuserprofile_connections1)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyncrm_linkedinuserprofile`|
|ReferencedAttribute|`msdyncrm_linkedinuserprofileid`|
|ReferencingAttribute|`record1id`|
|ReferencingEntityNavigationPropertyName|`record1id_msdyncrm_linkedinuserprofile`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyncrm_linkedinuserprofile_connections2"></a> msdyncrm_linkedinuserprofile_connections2

One-To-Many Relationship: [msdyncrm_linkedinuserprofile msdyncrm_linkedinuserprofile_connections2](msdyncrm_linkedinuserprofile.md#BKMK_msdyncrm_linkedinuserprofile_connections2)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyncrm_linkedinuserprofile`|
|ReferencedAttribute|`msdyncrm_linkedinuserprofileid`|
|ReferencingAttribute|`record2id`|
|ReferencingEntityNavigationPropertyName|`record2id_msdyncrm_linkedinuserprofile`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyncrm_marketingdynamiccontentmetadata_connections1"></a> msdyncrm_marketingdynamiccontentmetadata_connections1

One-To-Many Relationship: [msdyncrm_marketingdynamiccontentmetadata msdyncrm_marketingdynamiccontentmetadata_connections1](msdyncrm_marketingdynamiccontentmetadata.md#BKMK_msdyncrm_marketingdynamiccontentmetadata_connections1)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyncrm_marketingdynamiccontentmetadata`|
|ReferencedAttribute|`msdyncrm_marketingdynamiccontentmetadataid`|
|ReferencingAttribute|`record1id`|
|ReferencingEntityNavigationPropertyName|`record1id_msdyncrm_marketingdynamiccontentmetadata`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyncrm_marketingdynamiccontentmetadata_connections2"></a> msdyncrm_marketingdynamiccontentmetadata_connections2

One-To-Many Relationship: [msdyncrm_marketingdynamiccontentmetadata msdyncrm_marketingdynamiccontentmetadata_connections2](msdyncrm_marketingdynamiccontentmetadata.md#BKMK_msdyncrm_marketingdynamiccontentmetadata_connections2)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyncrm_marketingdynamiccontentmetadata`|
|ReferencedAttribute|`msdyncrm_marketingdynamiccontentmetadataid`|
|ReferencingAttribute|`record2id`|
|ReferencingEntityNavigationPropertyName|`record2id_msdyncrm_marketingdynamiccontentmetadata`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyncrm_marketingemaildynamiccontentmetadata_connections1"></a> msdyncrm_marketingemaildynamiccontentmetadata_connections1

One-To-Many Relationship: [msdyncrm_marketingemaildynamiccontentmetadata msdyncrm_marketingemaildynamiccontentmetadata_connections1](msdyncrm_marketingemaildynamiccontentmetadata.md#BKMK_msdyncrm_marketingemaildynamiccontentmetadata_connections1)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyncrm_marketingemaildynamiccontentmetadata`|
|ReferencedAttribute|`msdyncrm_marketingemaildynamiccontentmetadataid`|
|ReferencingAttribute|`record1id`|
|ReferencingEntityNavigationPropertyName|`record1id_msdyncrm_marketingemaildynamiccontentmetadata`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyncrm_marketingemaildynamiccontentmetadata_connections2"></a> msdyncrm_marketingemaildynamiccontentmetadata_connections2

One-To-Many Relationship: [msdyncrm_marketingemaildynamiccontentmetadata msdyncrm_marketingemaildynamiccontentmetadata_connections2](msdyncrm_marketingemaildynamiccontentmetadata.md#BKMK_msdyncrm_marketingemaildynamiccontentmetadata_connections2)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyncrm_marketingemaildynamiccontentmetadata`|
|ReferencedAttribute|`msdyncrm_marketingemaildynamiccontentmetadataid`|
|ReferencingAttribute|`record2id`|
|ReferencingEntityNavigationPropertyName|`record2id_msdyncrm_marketingemaildynamiccontentmetadata`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyncrm_marketingemailtestsend_connections1"></a> msdyncrm_marketingemailtestsend_connections1

One-To-Many Relationship: [msdyncrm_marketingemailtestsend msdyncrm_marketingemailtestsend_connections1](msdyncrm_marketingemailtestsend.md#BKMK_msdyncrm_marketingemailtestsend_connections1)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyncrm_marketingemailtestsend`|
|ReferencedAttribute|`msdyncrm_marketingemailtestsendid`|
|ReferencingAttribute|`record1id`|
|ReferencingEntityNavigationPropertyName|`record1id_msdyncrm_marketingemailtestsend`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyncrm_marketingemailtestsend_connections2"></a> msdyncrm_marketingemailtestsend_connections2

One-To-Many Relationship: [msdyncrm_marketingemailtestsend msdyncrm_marketingemailtestsend_connections2](msdyncrm_marketingemailtestsend.md#BKMK_msdyncrm_marketingemailtestsend_connections2)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyncrm_marketingemailtestsend`|
|ReferencedAttribute|`msdyncrm_marketingemailtestsendid`|
|ReferencingAttribute|`record2id`|
|ReferencingEntityNavigationPropertyName|`record2id_msdyncrm_marketingemailtestsend`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyncrm_mktactivity_connections1"></a> msdyncrm_mktactivity_connections1

One-To-Many Relationship: [msdyncrm_mktactivity msdyncrm_mktactivity_connections1](msdyncrm_mktactivity.md#BKMK_msdyncrm_mktactivity_connections1)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyncrm_mktactivity`|
|ReferencedAttribute|`msdyncrm_mktactivityid`|
|ReferencingAttribute|`record1id`|
|ReferencingEntityNavigationPropertyName|`record1id_msdyncrm_mktactivity`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyncrm_mktactivity_connections2"></a> msdyncrm_mktactivity_connections2

One-To-Many Relationship: [msdyncrm_mktactivity msdyncrm_mktactivity_connections2](msdyncrm_mktactivity.md#BKMK_msdyncrm_mktactivity_connections2)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyncrm_mktactivity`|
|ReferencedAttribute|`msdyncrm_mktactivityid`|
|ReferencingAttribute|`record2id`|
|ReferencingEntityNavigationPropertyName|`record2id_msdyncrm_mktactivity`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyncrm_phonecallactivitymarketingtemplate_connections1"></a> msdyncrm_phonecallactivitymarketingtemplate_connections1

One-To-Many Relationship: [msdyncrm_phonecallactivitymarketingtemplate msdyncrm_phonecallactivitymarketingtemplate_connections1](msdyncrm_phonecallactivitymarketingtemplate.md#BKMK_msdyncrm_phonecallactivitymarketingtemplate_connections1)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyncrm_phonecallactivitymarketingtemplate`|
|ReferencedAttribute|`msdyncrm_phonecallactivitymarketingtemplateid`|
|ReferencingAttribute|`record1id`|
|ReferencingEntityNavigationPropertyName|`record1id_msdyncrm_phonecallactivitymarketingtemplate`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyncrm_phonecallactivitymarketingtemplate_connections2"></a> msdyncrm_phonecallactivitymarketingtemplate_connections2

One-To-Many Relationship: [msdyncrm_phonecallactivitymarketingtemplate msdyncrm_phonecallactivitymarketingtemplate_connections2](msdyncrm_phonecallactivitymarketingtemplate.md#BKMK_msdyncrm_phonecallactivitymarketingtemplate_connections2)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyncrm_phonecallactivitymarketingtemplate`|
|ReferencedAttribute|`msdyncrm_phonecallactivitymarketingtemplateid`|
|ReferencingAttribute|`record2id`|
|ReferencingEntityNavigationPropertyName|`record2id_msdyncrm_phonecallactivitymarketingtemplate`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyncrm_taskactivitymarketingtemplate_connections1"></a> msdyncrm_taskactivitymarketingtemplate_connections1

One-To-Many Relationship: [msdyncrm_taskactivitymarketingtemplate msdyncrm_taskactivitymarketingtemplate_connections1](msdyncrm_taskactivitymarketingtemplate.md#BKMK_msdyncrm_taskactivitymarketingtemplate_connections1)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyncrm_taskactivitymarketingtemplate`|
|ReferencedAttribute|`msdyncrm_taskactivitymarketingtemplateid`|
|ReferencingAttribute|`record1id`|
|ReferencingEntityNavigationPropertyName|`record1id_msdyncrm_taskactivitymarketingtemplate`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyncrm_taskactivitymarketingtemplate_connections2"></a> msdyncrm_taskactivitymarketingtemplate_connections2

One-To-Many Relationship: [msdyncrm_taskactivitymarketingtemplate msdyncrm_taskactivitymarketingtemplate_connections2](msdyncrm_taskactivitymarketingtemplate.md#BKMK_msdyncrm_taskactivitymarketingtemplate_connections2)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyncrm_taskactivitymarketingtemplate`|
|ReferencedAttribute|`msdyncrm_taskactivitymarketingtemplateid`|
|ReferencingAttribute|`record2id`|
|ReferencingEntityNavigationPropertyName|`record2id_msdyncrm_taskactivitymarketingtemplate`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyncrm_uicconfig_connections1"></a> msdyncrm_uicconfig_connections1

One-To-Many Relationship: [msdyncrm_uicconfig msdyncrm_uicconfig_connections1](msdyncrm_uicconfig.md#BKMK_msdyncrm_uicconfig_connections1)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyncrm_uicconfig`|
|ReferencedAttribute|`msdyncrm_uicconfigid`|
|ReferencingAttribute|`record1id`|
|ReferencingEntityNavigationPropertyName|`record1id_msdyncrm_uicconfig`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyncrm_uicconfig_connections2"></a> msdyncrm_uicconfig_connections2

One-To-Many Relationship: [msdyncrm_uicconfig msdyncrm_uicconfig_connections2](msdyncrm_uicconfig.md#BKMK_msdyncrm_uicconfig_connections2)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyncrm_uicconfig`|
|ReferencedAttribute|`msdyncrm_uicconfigid`|
|ReferencingAttribute|`record2id`|
|ReferencingEntityNavigationPropertyName|`record2id_msdyncrm_uicconfig`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msfp_alert_connections1"></a> msfp_alert_connections1

One-To-Many Relationship: [msfp_alert msfp_alert_connections1](msfp_alert.md#BKMK_msfp_alert_connections1)

|Property|Value|
|---|---|
|ReferencedEntity|`msfp_alert`|
|ReferencedAttribute|`activityid`|
|ReferencingAttribute|`record1id`|
|ReferencingEntityNavigationPropertyName|`record1id_msfp_alert`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msfp_alert_connections2"></a> msfp_alert_connections2

One-To-Many Relationship: [msfp_alert msfp_alert_connections2](msfp_alert.md#BKMK_msfp_alert_connections2)

|Property|Value|
|---|---|
|ReferencedEntity|`msfp_alert`|
|ReferencedAttribute|`activityid`|
|ReferencingAttribute|`record2id`|
|ReferencingEntityNavigationPropertyName|`record2id_msfp_alert`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msfp_surveyinvite_connections1"></a> msfp_surveyinvite_connections1

One-To-Many Relationship: [msfp_surveyinvite msfp_surveyinvite_connections1](msfp_surveyinvite.md#BKMK_msfp_surveyinvite_connections1)

|Property|Value|
|---|---|
|ReferencedEntity|`msfp_surveyinvite`|
|ReferencedAttribute|`activityid`|
|ReferencingAttribute|`record1id`|
|ReferencingEntityNavigationPropertyName|`record1id_msfp_surveyinvite`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msfp_surveyinvite_connections2"></a> msfp_surveyinvite_connections2

One-To-Many Relationship: [msfp_surveyinvite msfp_surveyinvite_connections2](msfp_surveyinvite.md#BKMK_msfp_surveyinvite_connections2)

|Property|Value|
|---|---|
|ReferencedEntity|`msfp_surveyinvite`|
|ReferencedAttribute|`activityid`|
|ReferencingAttribute|`record2id`|
|ReferencingEntityNavigationPropertyName|`record2id_msfp_surveyinvite`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msfp_surveyresponse_connections1"></a> msfp_surveyresponse_connections1

One-To-Many Relationship: [msfp_surveyresponse msfp_surveyresponse_connections1](msfp_surveyresponse.md#BKMK_msfp_surveyresponse_connections1)

|Property|Value|
|---|---|
|ReferencedEntity|`msfp_surveyresponse`|
|ReferencedAttribute|`activityid`|
|ReferencingAttribute|`record1id`|
|ReferencingEntityNavigationPropertyName|`record1id_msfp_surveyresponse`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msfp_surveyresponse_connections2"></a> msfp_surveyresponse_connections2

One-To-Many Relationship: [msfp_surveyresponse msfp_surveyresponse_connections2](msfp_surveyresponse.md#BKMK_msfp_surveyresponse_connections2)

|Property|Value|
|---|---|
|ReferencedEntity|`msfp_surveyresponse`|
|ReferencedAttribute|`activityid`|
|ReferencingAttribute|`record2id`|
|ReferencingEntityNavigationPropertyName|`record2id_msfp_surveyresponse`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_opportunity_connections1"></a> opportunity_connections1

One-To-Many Relationship: [opportunity opportunity_connections1](opportunity.md#BKMK_opportunity_connections1)

|Property|Value|
|---|---|
|ReferencedEntity|`opportunity`|
|ReferencedAttribute|`opportunityid`|
|ReferencingAttribute|`record1id`|
|ReferencingEntityNavigationPropertyName|`record1id_opportunity`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_opportunity_connections2"></a> opportunity_connections2

One-To-Many Relationship: [opportunity opportunity_connections2](opportunity.md#BKMK_opportunity_connections2)

|Property|Value|
|---|---|
|ReferencedEntity|`opportunity`|
|ReferencedAttribute|`opportunityid`|
|ReferencingAttribute|`record2id`|
|ReferencingEntityNavigationPropertyName|`record2id_opportunity`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_pricelevel_connections1"></a> pricelevel_connections1

One-To-Many Relationship: [pricelevel pricelevel_connections1](pricelevel.md#BKMK_pricelevel_connections1)

|Property|Value|
|---|---|
|ReferencedEntity|`pricelevel`|
|ReferencedAttribute|`pricelevelid`|
|ReferencingAttribute|`record1id`|
|ReferencingEntityNavigationPropertyName|`record1id_pricelevel`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_pricelevel_connections2"></a> pricelevel_connections2

One-To-Many Relationship: [pricelevel pricelevel_connections2](pricelevel.md#BKMK_pricelevel_connections2)

|Property|Value|
|---|---|
|ReferencedEntity|`pricelevel`|
|ReferencedAttribute|`pricelevelid`|
|ReferencingAttribute|`record2id`|
|ReferencingEntityNavigationPropertyName|`record2id_pricelevel`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_product_connections1"></a> product_connections1

One-To-Many Relationship: [product product_connections1](product.md#BKMK_product_connections1)

|Property|Value|
|---|---|
|ReferencedEntity|`product`|
|ReferencedAttribute|`productid`|
|ReferencingAttribute|`record1id`|
|ReferencingEntityNavigationPropertyName|`record1id_product`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_product_connections2"></a> product_connections2

One-To-Many Relationship: [product product_connections2](product.md#BKMK_product_connections2)

|Property|Value|
|---|---|
|ReferencedEntity|`product`|
|ReferencedAttribute|`productid`|
|ReferencingAttribute|`record2id`|
|ReferencingEntityNavigationPropertyName|`record2id_product`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_quote_connections1"></a> quote_connections1

One-To-Many Relationship: [quote quote_connections1](quote.md#BKMK_quote_connections1)

|Property|Value|
|---|---|
|ReferencedEntity|`quote`|
|ReferencedAttribute|`quoteid`|
|ReferencingAttribute|`record1id`|
|ReferencingEntityNavigationPropertyName|`record1id_quote`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_quote_connections2"></a> quote_connections2

One-To-Many Relationship: [quote quote_connections2](quote.md#BKMK_quote_connections2)

|Property|Value|
|---|---|
|ReferencedEntity|`quote`|
|ReferencedAttribute|`quoteid`|
|ReferencingAttribute|`record2id`|
|ReferencingEntityNavigationPropertyName|`record2id_quote`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_resourcegroup_connections1"></a> resourcegroup_connections1

One-To-Many Relationship: [resourcegroup resourcegroup_connections1](resourcegroup.md#BKMK_resourcegroup_connections1)

|Property|Value|
|---|---|
|ReferencedEntity|`resourcegroup`|
|ReferencedAttribute|`resourcegroupid`|
|ReferencingAttribute|`record1id`|
|ReferencingEntityNavigationPropertyName|`record1id_resourcegroup`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_resourcegroup_connections2"></a> resourcegroup_connections2

One-To-Many Relationship: [resourcegroup resourcegroup_connections2](resourcegroup.md#BKMK_resourcegroup_connections2)

|Property|Value|
|---|---|
|ReferencedEntity|`resourcegroup`|
|ReferencedAttribute|`resourcegroupid`|
|ReferencingAttribute|`record2id`|
|ReferencingEntityNavigationPropertyName|`record2id_resourcegroup`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_salesorder_connections1"></a> salesorder_connections1

One-To-Many Relationship: [salesorder salesorder_connections1](salesorder.md#BKMK_salesorder_connections1)

|Property|Value|
|---|---|
|ReferencedEntity|`salesorder`|
|ReferencedAttribute|`salesorderid`|
|ReferencingAttribute|`record1id`|
|ReferencingEntityNavigationPropertyName|`record1id_salesorder`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_salesorder_connections2"></a> salesorder_connections2

One-To-Many Relationship: [salesorder salesorder_connections2](salesorder.md#BKMK_salesorder_connections2)

|Property|Value|
|---|---|
|ReferencedEntity|`salesorder`|
|ReferencedAttribute|`salesorderid`|
|ReferencingAttribute|`record2id`|
|ReferencingEntityNavigationPropertyName|`record2id_salesorder`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_serviceappointment_connections1"></a> serviceappointment_connections1

One-To-Many Relationship: [serviceappointment serviceappointment_connections1](serviceappointment.md#BKMK_serviceappointment_connections1)

|Property|Value|
|---|---|
|ReferencedEntity|`serviceappointment`|
|ReferencedAttribute|`activityid`|
|ReferencingAttribute|`record1id`|
|ReferencingEntityNavigationPropertyName|`record1id_serviceappointment`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_serviceappointment_connections2"></a> serviceappointment_connections2

One-To-Many Relationship: [serviceappointment serviceappointment_connections2](serviceappointment.md#BKMK_serviceappointment_connections2)

|Property|Value|
|---|---|
|ReferencedEntity|`serviceappointment`|
|ReferencedAttribute|`activityid`|
|ReferencingAttribute|`record2id`|
|ReferencingEntityNavigationPropertyName|`record2id_serviceappointment`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|



### See also

[Dataverse table/entity reference](../about-entity-reference.md)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   
<xref:Microsoft.Dynamics.CRM.connection?displayProperty=fullName>
