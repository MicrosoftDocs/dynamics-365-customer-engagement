---
title: "Mailbox Auto Tracking Folder (MailboxTrackingFolder) table/entity reference (Microsoft Dynamics 365 Field Service)"
description: "Includes schema information and supported messages for the Mailbox Auto Tracking Folder (MailboxTrackingFolder) table/entity with Microsoft Dynamics 365 Field Service."
ms.date: 08/26/2024
ms.service: powerapps
ms.topic: reference
author: m-hartmann
ms.author: mhart
search.audienceType: 
  - developer
---

# Mailbox Auto Tracking Folder (MailboxTrackingFolder) table/entity reference

Stores data about what folders for a mailbox are auto tracked

> [!NOTE]
> The Microsoft Dynamics 365 Field Service Mailbox Auto Tracking Folder (MailboxTrackingFolder) table extends the [Microsoft Dynamics 365 Mailbox Auto Tracking Folder (MailboxTrackingFolder) table](/dynamics365/developer/entities/mailboxtrackingfolder).



## Customized columns/attributes

Microsoft Dynamics 365 Field Service modifies the definition of columns/attributes defined in other solutions. Listed by **SchemaName**.

### <a name="BKMK_RegardingObjectId"></a> RegardingObjectId

Changes from [RegardingObjectId (Microsoft Dataverse)](/power-apps/developer/data-platform/reference/entities/mailboxtrackingfolder#BKMK_RegardingObjectId)

|Property|Value|
|---|---|
|Targets|msdyn_3dmodel|


## Many-to-One relationships

These relationships are many-to-one. Listed by **SchemaName**.

- [msdyn_3dmodel_MailboxTrackingFolders](#BKMK_msdyn_3dmodel_MailboxTrackingFolders)
- [msdyn_actual_MailboxTrackingFolders](#BKMK_msdyn_actual_MailboxTrackingFolders)
- [msdyn_agreement_MailboxTrackingFolders](#BKMK_msdyn_agreement_MailboxTrackingFolders)
- [msdyn_agreementbookingdate_MailboxTrackingFolders](#BKMK_msdyn_agreementbookingdate_MailboxTrackingFolders)
- [msdyn_agreementbookingincident_MailboxTrackingFolders](#BKMK_msdyn_agreementbookingincident_MailboxTrackingFolders)
- [msdyn_agreementbookingproduct_MailboxTrackingFolders](#BKMK_msdyn_agreementbookingproduct_MailboxTrackingFolders)
- [msdyn_agreementbookingservice_MailboxTrackingFolders](#BKMK_msdyn_agreementbookingservice_MailboxTrackingFolders)
- [msdyn_agreementbookingservicetask_MailboxTrackingFolders](#BKMK_msdyn_agreementbookingservicetask_MailboxTrackingFolders)
- [msdyn_agreementbookingsetup_MailboxTrackingFolders](#BKMK_msdyn_agreementbookingsetup_MailboxTrackingFolders)
- [msdyn_agreementinvoicedate_MailboxTrackingFolders](#BKMK_msdyn_agreementinvoicedate_MailboxTrackingFolders)
- [msdyn_agreementinvoiceproduct_MailboxTrackingFolders](#BKMK_msdyn_agreementinvoiceproduct_MailboxTrackingFolders)
- [msdyn_agreementinvoicesetup_MailboxTrackingFolders](#BKMK_msdyn_agreementinvoicesetup_MailboxTrackingFolders)
- [msdyn_agreementsubstatus_MailboxTrackingFolders](#BKMK_msdyn_agreementsubstatus_MailboxTrackingFolders)
- [msdyn_assetsuggestionssetting_MailboxTrackingFolders](#BKMK_msdyn_assetsuggestionssetting_MailboxTrackingFolders)
- [msdyn_bookableresourceassociation_MailboxTrackingFolders](#BKMK_msdyn_bookableresourceassociation_MailboxTrackingFolders)
- [msdyn_bookableresourcebookingquicknote_MailboxTrackingFolders](#BKMK_msdyn_bookableresourcebookingquicknote_MailboxTrackingFolders)
- [msdyn_bookingalert_MailboxTrackingFolders](#BKMK_msdyn_bookingalert_MailboxTrackingFolders)
- [msdyn_bookingalertstatus_MailboxTrackingFolders](#BKMK_msdyn_bookingalertstatus_MailboxTrackingFolders)
- [msdyn_bookingchange_MailboxTrackingFolders](#BKMK_msdyn_bookingchange_MailboxTrackingFolders)
- [msdyn_bookingjournal_MailboxTrackingFolders](#BKMK_msdyn_bookingjournal_MailboxTrackingFolders)
- [msdyn_bookingrule_MailboxTrackingFolders](#BKMK_msdyn_bookingrule_MailboxTrackingFolders)
- [msdyn_bookingsetupmetadata_MailboxTrackingFolders](#BKMK_msdyn_bookingsetupmetadata_MailboxTrackingFolders)
- [msdyn_bookingtimestamp_MailboxTrackingFolders](#BKMK_msdyn_bookingtimestamp_MailboxTrackingFolders)
- [msdyn_bpf_2c5fe86acc8b414b8322ae571000c799_MailboxTrackingFolders](#BKMK_msdyn_bpf_2c5fe86acc8b414b8322ae571000c799_MailboxTrackingFolders)
- [msdyn_bpf_477c16f59170487b8b4dc895c5dcd09b_MailboxTrackingFolders](#BKMK_msdyn_bpf_477c16f59170487b8b4dc895c5dcd09b_MailboxTrackingFolders)
- [msdyn_bpf_989e9b1857e24af18787d5143b67523b_MailboxTrackingFolders](#BKMK_msdyn_bpf_989e9b1857e24af18787d5143b67523b_MailboxTrackingFolders)
- [msdyn_bpf_baa0a411a239410cb8bded8b5fdd88e3_MailboxTrackingFolders](#BKMK_msdyn_bpf_baa0a411a239410cb8bded8b5fdd88e3_MailboxTrackingFolders)
- [msdyn_bpf_d3d97bac8c294105840e99e37a9d1c39_MailboxTrackingFolders](#BKMK_msdyn_bpf_d3d97bac8c294105840e99e37a9d1c39_MailboxTrackingFolders)
- [msdyn_businessclosure_MailboxTrackingFolders](#BKMK_msdyn_businessclosure_MailboxTrackingFolders)
- [msdyn_clientextension_MailboxTrackingFolders](#BKMK_msdyn_clientextension_MailboxTrackingFolders)
- [msdyn_configuration_MailboxTrackingFolders](#BKMK_msdyn_configuration_MailboxTrackingFolders)
- [msdyn_consoleapplicationsessiontemplate_MailboxTrackingFolders](#BKMK_msdyn_consoleapplicationsessiontemplate_MailboxTrackingFolders)
- [msdyn_dataanalyticsreport_fs_MailboxTrackingFolders](#BKMK_msdyn_dataanalyticsreport_fs_MailboxTrackingFolders)
- [msdyn_dataanalyticsreport_fspredictrs_MailboxTrackingFolders](#BKMK_msdyn_dataanalyticsreport_fspredictrs_MailboxTrackingFolders)
- [msdyn_dataanalyticsreport_fspredictwhd_MailboxTrackingFolders](#BKMK_msdyn_dataanalyticsreport_fspredictwhd_MailboxTrackingFolders)
- [msdyn_entitlementapplication_MailboxTrackingFolders](#BKMK_msdyn_entitlementapplication_MailboxTrackingFolders)
- [msdyn_entityconfiguration_MailboxTrackingFolders](#BKMK_msdyn_entityconfiguration_MailboxTrackingFolders)
- [msdyn_fieldservicepricelistitem_MailboxTrackingFolders](#BKMK_msdyn_fieldservicepricelistitem_MailboxTrackingFolders)
- [msdyn_fieldservicesetting_MailboxTrackingFolders](#BKMK_msdyn_fieldservicesetting_MailboxTrackingFolders)
- [msdyn_fieldserviceslaconfiguration_MailboxTrackingFolders](#BKMK_msdyn_fieldserviceslaconfiguration_MailboxTrackingFolders)
- [msdyn_fieldservicesummaryconfiguration_MailboxTrackingFolders](#BKMK_msdyn_fieldservicesummaryconfiguration_MailboxTrackingFolders)
- [msdyn_fieldservicesystemjob_MailboxTrackingFolders](#BKMK_msdyn_fieldservicesystemjob_MailboxTrackingFolders)
- [msdyn_flwconfiguration_MailboxTrackingFolders](#BKMK_msdyn_flwconfiguration_MailboxTrackingFolders)
- [msdyn_geofence_MailboxTrackingFolders](#BKMK_msdyn_geofence_MailboxTrackingFolders)
- [msdyn_geofenceevent_MailboxTrackingFolders](#BKMK_msdyn_geofenceevent_MailboxTrackingFolders)
- [msdyn_geofencingsettings_MailboxTrackingFolders](#BKMK_msdyn_geofencingsettings_MailboxTrackingFolders)
- [msdyn_geolocationsettings_MailboxTrackingFolders](#BKMK_msdyn_geolocationsettings_MailboxTrackingFolders)
- [msdyn_geolocationtracking_MailboxTrackingFolders](#BKMK_msdyn_geolocationtracking_MailboxTrackingFolders)
- [msdyn_incidenttype_MailboxTrackingFolders](#BKMK_msdyn_incidenttype_MailboxTrackingFolders)
- [msdyn_incidenttype_requirementgroup_MailboxTrackingFolders](#BKMK_msdyn_incidenttype_requirementgroup_MailboxTrackingFolders)
- [msdyn_incidenttypecharacteristic_MailboxTrackingFolders](#BKMK_msdyn_incidenttypecharacteristic_MailboxTrackingFolders)
- [msdyn_incidenttypeproduct_MailboxTrackingFolders](#BKMK_msdyn_incidenttypeproduct_MailboxTrackingFolders)
- [msdyn_incidenttyperecommendationresult_MailboxTrackingFolders](#BKMK_msdyn_incidenttyperecommendationresult_MailboxTrackingFolders)
- [msdyn_incidenttyperecommendationrunhistory_MailboxTrackingFolders](#BKMK_msdyn_incidenttyperecommendationrunhistory_MailboxTrackingFolders)
- [msdyn_incidenttyperesolution_MailboxTrackingFolders](#BKMK_msdyn_incidenttyperesolution_MailboxTrackingFolders)
- [msdyn_incidenttypeservice_MailboxTrackingFolders](#BKMK_msdyn_incidenttypeservice_MailboxTrackingFolders)
- [msdyn_incidenttypeservicetask_MailboxTrackingFolders](#BKMK_msdyn_incidenttypeservicetask_MailboxTrackingFolders)
- [msdyn_incidenttypessetup_MailboxTrackingFolders](#BKMK_msdyn_incidenttypessetup_MailboxTrackingFolders)
- [msdyn_inspection_MailboxTrackingFolders](#BKMK_msdyn_inspection_MailboxTrackingFolders)
- [msdyn_inspectionattachment_MailboxTrackingFolders](#BKMK_msdyn_inspectionattachment_MailboxTrackingFolders)
- [msdyn_inspectiondefinition_MailboxTrackingFolders](#BKMK_msdyn_inspectiondefinition_MailboxTrackingFolders)
- [msdyn_inspectioninstance_MailboxTrackingFolders](#BKMK_msdyn_inspectioninstance_MailboxTrackingFolders)
- [msdyn_inspectionresponse_MailboxTrackingFolders](#BKMK_msdyn_inspectionresponse_MailboxTrackingFolders)
- [msdyn_insurance_MailboxTrackingFolders](#BKMK_msdyn_insurance_MailboxTrackingFolders)
- [msdyn_inventoryadjustment_MailboxTrackingFolders](#BKMK_msdyn_inventoryadjustment_MailboxTrackingFolders)
- [msdyn_inventoryadjustmentproduct_MailboxTrackingFolders](#BKMK_msdyn_inventoryadjustmentproduct_MailboxTrackingFolders)
- [msdyn_inventoryjournal_MailboxTrackingFolders](#BKMK_msdyn_inventoryjournal_MailboxTrackingFolders)
- [msdyn_inventorytransfer_MailboxTrackingFolders](#BKMK_msdyn_inventorytransfer_MailboxTrackingFolders)
- [msdyn_mobilesource_MailboxTrackingFolders](#BKMK_msdyn_mobilesource_MailboxTrackingFolders)
- [msdyn_nottoexceed_MailboxTrackingFolders](#BKMK_msdyn_nottoexceed_MailboxTrackingFolders)
- [msdyn_orderinvoicingdate_MailboxTrackingFolders](#BKMK_msdyn_orderinvoicingdate_MailboxTrackingFolders)
- [msdyn_orderinvoicingproduct_MailboxTrackingFolders](#BKMK_msdyn_orderinvoicingproduct_MailboxTrackingFolders)
- [msdyn_orderinvoicingsetup_MailboxTrackingFolders](#BKMK_msdyn_orderinvoicingsetup_MailboxTrackingFolders)
- [msdyn_orderinvoicingsetupdate_MailboxTrackingFolders](#BKMK_msdyn_orderinvoicingsetupdate_MailboxTrackingFolders)
- [msdyn_organizationalunit_MailboxTrackingFolders](#BKMK_msdyn_organizationalunit_MailboxTrackingFolders)
- [msdyn_payment_MailboxTrackingFolders](#BKMK_msdyn_payment_MailboxTrackingFolders)
- [msdyn_paymentdetail_MailboxTrackingFolders](#BKMK_msdyn_paymentdetail_MailboxTrackingFolders)
- [msdyn_paymentmethod_MailboxTrackingFolders](#BKMK_msdyn_paymentmethod_MailboxTrackingFolders)
- [msdyn_paymentterm_MailboxTrackingFolders](#BKMK_msdyn_paymentterm_MailboxTrackingFolders)
- [msdyn_postalcode_MailboxTrackingFolders](#BKMK_msdyn_postalcode_MailboxTrackingFolders)
- [msdyn_predictworkhourdurationsetting_MailboxTrackingFolders](#BKMK_msdyn_predictworkhourdurationsetting_MailboxTrackingFolders)
- [msdyn_priority_MailboxTrackingFolders](#BKMK_msdyn_priority_MailboxTrackingFolders)
- [msdyn_problematicasset_MailboxTrackingFolders](#BKMK_msdyn_problematicasset_MailboxTrackingFolders)
- [msdyn_problematicassetfeedback_MailboxTrackingFolders](#BKMK_msdyn_problematicassetfeedback_MailboxTrackingFolders)
- [msdyn_productinventory_MailboxTrackingFolders](#BKMK_msdyn_productinventory_MailboxTrackingFolders)
- [msdyn_purchaseorder_MailboxTrackingFolders](#BKMK_msdyn_purchaseorder_MailboxTrackingFolders)
- [msdyn_purchaseorderbill_MailboxTrackingFolders](#BKMK_msdyn_purchaseorderbill_MailboxTrackingFolders)
- [msdyn_purchaseorderproduct_MailboxTrackingFolders](#BKMK_msdyn_purchaseorderproduct_MailboxTrackingFolders)
- [msdyn_purchaseorderreceipt_MailboxTrackingFolders](#BKMK_msdyn_purchaseorderreceipt_MailboxTrackingFolders)
- [msdyn_purchaseorderreceiptproduct_MailboxTrackingFolders](#BKMK_msdyn_purchaseorderreceiptproduct_MailboxTrackingFolders)
- [msdyn_purchaseordersubstatus_MailboxTrackingFolders](#BKMK_msdyn_purchaseordersubstatus_MailboxTrackingFolders)
- [msdyn_quotebookingincident_MailboxTrackingFolders](#BKMK_msdyn_quotebookingincident_MailboxTrackingFolders)
- [msdyn_quotebookingproduct_MailboxTrackingFolders](#BKMK_msdyn_quotebookingproduct_MailboxTrackingFolders)
- [msdyn_quotebookingservice_MailboxTrackingFolders](#BKMK_msdyn_quotebookingservice_MailboxTrackingFolders)
- [msdyn_quotebookingservicetask_MailboxTrackingFolders](#BKMK_msdyn_quotebookingservicetask_MailboxTrackingFolders)
- [msdyn_quotebookingsetup_MailboxTrackingFolders](#BKMK_msdyn_quotebookingsetup_MailboxTrackingFolders)
- [msdyn_quoteinvoicingproduct_MailboxTrackingFolders](#BKMK_msdyn_quoteinvoicingproduct_MailboxTrackingFolders)
- [msdyn_quoteinvoicingsetup_MailboxTrackingFolders](#BKMK_msdyn_quoteinvoicingsetup_MailboxTrackingFolders)
- [msdyn_requirementchange_MailboxTrackingFolders](#BKMK_msdyn_requirementchange_MailboxTrackingFolders)
- [msdyn_requirementcharacteristic_MailboxTrackingFolders](#BKMK_msdyn_requirementcharacteristic_MailboxTrackingFolders)
- [msdyn_requirementdependency_MailboxTrackingFolders](#BKMK_msdyn_requirementdependency_MailboxTrackingFolders)
- [msdyn_requirementgroup_MailboxTrackingFolders](#BKMK_msdyn_requirementgroup_MailboxTrackingFolders)
- [msdyn_requirementorganizationunit_MailboxTrackingFolders](#BKMK_msdyn_requirementorganizationunit_MailboxTrackingFolders)
- [msdyn_requirementrelationship_MailboxTrackingFolders](#BKMK_msdyn_requirementrelationship_MailboxTrackingFolders)
- [msdyn_requirementresourcecategory_MailboxTrackingFolders](#BKMK_msdyn_requirementresourcecategory_MailboxTrackingFolders)
- [msdyn_requirementresourcepreference_MailboxTrackingFolders](#BKMK_msdyn_requirementresourcepreference_MailboxTrackingFolders)
- [msdyn_requirementstatus_MailboxTrackingFolders](#BKMK_msdyn_requirementstatus_MailboxTrackingFolders)
- [msdyn_resolution_MailboxTrackingFolders](#BKMK_msdyn_resolution_MailboxTrackingFolders)
- [msdyn_resourcepaytype_MailboxTrackingFolders](#BKMK_msdyn_resourcepaytype_MailboxTrackingFolders)
- [msdyn_resourcerequirement_MailboxTrackingFolders](#BKMK_msdyn_resourcerequirement_MailboxTrackingFolders)
- [msdyn_resourcerequirementdetail_MailboxTrackingFolders](#BKMK_msdyn_resourcerequirementdetail_MailboxTrackingFolders)
- [msdyn_resourceterritory_MailboxTrackingFolders](#BKMK_msdyn_resourceterritory_MailboxTrackingFolders)
- [msdyn_rma_MailboxTrackingFolders](#BKMK_msdyn_rma_MailboxTrackingFolders)
- [msdyn_rmaproduct_MailboxTrackingFolders](#BKMK_msdyn_rmaproduct_MailboxTrackingFolders)
- [msdyn_rmareceipt_MailboxTrackingFolders](#BKMK_msdyn_rmareceipt_MailboxTrackingFolders)
- [msdyn_rmareceiptproduct_MailboxTrackingFolders](#BKMK_msdyn_rmareceiptproduct_MailboxTrackingFolders)
- [msdyn_rmasubstatus_MailboxTrackingFolders](#BKMK_msdyn_rmasubstatus_MailboxTrackingFolders)
- [msdyn_rtv_MailboxTrackingFolders](#BKMK_msdyn_rtv_MailboxTrackingFolders)
- [msdyn_rtvproduct_MailboxTrackingFolders](#BKMK_msdyn_rtvproduct_MailboxTrackingFolders)
- [msdyn_rtvsubstatus_MailboxTrackingFolders](#BKMK_msdyn_rtvsubstatus_MailboxTrackingFolders)
- [msdyn_scheduleboardsetting_MailboxTrackingFolders](#BKMK_msdyn_scheduleboardsetting_MailboxTrackingFolders)
- [msdyn_schedulingfeatureflag_MailboxTrackingFolders](#BKMK_msdyn_schedulingfeatureflag_MailboxTrackingFolders)
- [msdyn_schedulingparameter_MailboxTrackingFolders](#BKMK_msdyn_schedulingparameter_MailboxTrackingFolders)
- [msdyn_servicetasktype_MailboxTrackingFolders](#BKMK_msdyn_servicetasktype_MailboxTrackingFolders)
- [msdyn_sessiondata_MailboxTrackingFolders](#BKMK_msdyn_sessiondata_MailboxTrackingFolders)
- [msdyn_sessionparticipantdata_MailboxTrackingFolders](#BKMK_msdyn_sessionparticipantdata_MailboxTrackingFolders)
- [msdyn_shipvia_MailboxTrackingFolders](#BKMK_msdyn_shipvia_MailboxTrackingFolders)
- [msdyn_systemuserschedulersetting_MailboxTrackingFolders](#BKMK_msdyn_systemuserschedulersetting_MailboxTrackingFolders)
- [msdyn_taxcode_MailboxTrackingFolders](#BKMK_msdyn_taxcode_MailboxTrackingFolders)
- [msdyn_taxcodedetail_MailboxTrackingFolders](#BKMK_msdyn_taxcodedetail_MailboxTrackingFolders)
- [msdyn_timeentry_MailboxTrackingFolders](#BKMK_msdyn_timeentry_MailboxTrackingFolders)
- [msdyn_timeentrysetting_MailboxTrackingFolders](#BKMK_msdyn_timeentrysetting_MailboxTrackingFolders)
- [msdyn_timegroup_MailboxTrackingFolders](#BKMK_msdyn_timegroup_MailboxTrackingFolders)
- [msdyn_timegroupdetail_MailboxTrackingFolders](#BKMK_msdyn_timegroupdetail_MailboxTrackingFolders)
- [msdyn_timeoffrequest_MailboxTrackingFolders](#BKMK_msdyn_timeoffrequest_MailboxTrackingFolders)
- [msdyn_trade_MailboxTrackingFolders](#BKMK_msdyn_trade_MailboxTrackingFolders)
- [msdyn_tradecoverage_MailboxTrackingFolders](#BKMK_msdyn_tradecoverage_MailboxTrackingFolders)
- [msdyn_transactionorigin_MailboxTrackingFolders](#BKMK_msdyn_transactionorigin_MailboxTrackingFolders)
- [msdyn_uniquenumber_MailboxTrackingFolders](#BKMK_msdyn_uniquenumber_MailboxTrackingFolders)
- [msdyn_warehouse_MailboxTrackingFolders](#BKMK_msdyn_warehouse_MailboxTrackingFolders)
- [msdyn_workhourtemplate_MailboxTrackingFolders](#BKMK_msdyn_workhourtemplate_MailboxTrackingFolders)
- [msdyn_workorder_MailboxTrackingFolders](#BKMK_msdyn_workorder_MailboxTrackingFolders)
- [msdyn_workorderincident_MailboxTrackingFolders](#BKMK_msdyn_workorderincident_MailboxTrackingFolders)
- [msdyn_workordernte_MailboxTrackingFolders](#BKMK_msdyn_workordernte_MailboxTrackingFolders)
- [msdyn_workorderproduct_MailboxTrackingFolders](#BKMK_msdyn_workorderproduct_MailboxTrackingFolders)
- [msdyn_workorderresolution_MailboxTrackingFolders](#BKMK_msdyn_workorderresolution_MailboxTrackingFolders)
- [msdyn_workorderresourcerestriction_MailboxTrackingFolders](#BKMK_msdyn_workorderresourcerestriction_MailboxTrackingFolders)
- [msdyn_workorderservice_MailboxTrackingFolders](#BKMK_msdyn_workorderservice_MailboxTrackingFolders)
- [msdyn_workorderservicetask_MailboxTrackingFolders](#BKMK_msdyn_workorderservicetask_MailboxTrackingFolders)
- [msdyn_workordersubstatus_MailboxTrackingFolders](#BKMK_msdyn_workordersubstatus_MailboxTrackingFolders)
- [msdyn_workordertype_MailboxTrackingFolders](#BKMK_msdyn_workordertype_MailboxTrackingFolders)

### <a name="BKMK_msdyn_3dmodel_MailboxTrackingFolders"></a> msdyn_3dmodel_MailboxTrackingFolders

One-To-Many Relationship: [msdyn_3dmodel msdyn_3dmodel_MailboxTrackingFolders](msdyn_3dmodel.md#BKMK_msdyn_3dmodel_MailboxTrackingFolders)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_3dmodel`|
|ReferencedAttribute|`msdyn_3dmodelid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_3dmodel`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_actual_MailboxTrackingFolders"></a> msdyn_actual_MailboxTrackingFolders

One-To-Many Relationship: [msdyn_actual msdyn_actual_MailboxTrackingFolders](msdyn_actual.md#BKMK_msdyn_actual_MailboxTrackingFolders)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_actual`|
|ReferencedAttribute|`msdyn_actualid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_actual`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_agreement_MailboxTrackingFolders"></a> msdyn_agreement_MailboxTrackingFolders

One-To-Many Relationship: [msdyn_agreement msdyn_agreement_MailboxTrackingFolders](msdyn_agreement.md#BKMK_msdyn_agreement_MailboxTrackingFolders)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_agreement`|
|ReferencedAttribute|`msdyn_agreementid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_agreement`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_agreementbookingdate_MailboxTrackingFolders"></a> msdyn_agreementbookingdate_MailboxTrackingFolders

One-To-Many Relationship: [msdyn_agreementbookingdate msdyn_agreementbookingdate_MailboxTrackingFolders](msdyn_agreementbookingdate.md#BKMK_msdyn_agreementbookingdate_MailboxTrackingFolders)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_agreementbookingdate`|
|ReferencedAttribute|`msdyn_agreementbookingdateid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_agreementbookingdate`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_agreementbookingincident_MailboxTrackingFolders"></a> msdyn_agreementbookingincident_MailboxTrackingFolders

One-To-Many Relationship: [msdyn_agreementbookingincident msdyn_agreementbookingincident_MailboxTrackingFolders](msdyn_agreementbookingincident.md#BKMK_msdyn_agreementbookingincident_MailboxTrackingFolders)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_agreementbookingincident`|
|ReferencedAttribute|`msdyn_agreementbookingincidentid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_agreementbookingincident`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_agreementbookingproduct_MailboxTrackingFolders"></a> msdyn_agreementbookingproduct_MailboxTrackingFolders

One-To-Many Relationship: [msdyn_agreementbookingproduct msdyn_agreementbookingproduct_MailboxTrackingFolders](msdyn_agreementbookingproduct.md#BKMK_msdyn_agreementbookingproduct_MailboxTrackingFolders)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_agreementbookingproduct`|
|ReferencedAttribute|`msdyn_agreementbookingproductid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_agreementbookingproduct`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_agreementbookingservice_MailboxTrackingFolders"></a> msdyn_agreementbookingservice_MailboxTrackingFolders

One-To-Many Relationship: [msdyn_agreementbookingservice msdyn_agreementbookingservice_MailboxTrackingFolders](msdyn_agreementbookingservice.md#BKMK_msdyn_agreementbookingservice_MailboxTrackingFolders)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_agreementbookingservice`|
|ReferencedAttribute|`msdyn_agreementbookingserviceid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_agreementbookingservice`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_agreementbookingservicetask_MailboxTrackingFolders"></a> msdyn_agreementbookingservicetask_MailboxTrackingFolders

One-To-Many Relationship: [msdyn_agreementbookingservicetask msdyn_agreementbookingservicetask_MailboxTrackingFolders](msdyn_agreementbookingservicetask.md#BKMK_msdyn_agreementbookingservicetask_MailboxTrackingFolders)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_agreementbookingservicetask`|
|ReferencedAttribute|`msdyn_agreementbookingservicetaskid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_agreementbookingservicetask`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_agreementbookingsetup_MailboxTrackingFolders"></a> msdyn_agreementbookingsetup_MailboxTrackingFolders

One-To-Many Relationship: [msdyn_agreementbookingsetup msdyn_agreementbookingsetup_MailboxTrackingFolders](msdyn_agreementbookingsetup.md#BKMK_msdyn_agreementbookingsetup_MailboxTrackingFolders)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_agreementbookingsetup`|
|ReferencedAttribute|`msdyn_agreementbookingsetupid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_agreementbookingsetup`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_agreementinvoicedate_MailboxTrackingFolders"></a> msdyn_agreementinvoicedate_MailboxTrackingFolders

One-To-Many Relationship: [msdyn_agreementinvoicedate msdyn_agreementinvoicedate_MailboxTrackingFolders](msdyn_agreementinvoicedate.md#BKMK_msdyn_agreementinvoicedate_MailboxTrackingFolders)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_agreementinvoicedate`|
|ReferencedAttribute|`msdyn_agreementinvoicedateid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_agreementinvoicedate`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_agreementinvoiceproduct_MailboxTrackingFolders"></a> msdyn_agreementinvoiceproduct_MailboxTrackingFolders

One-To-Many Relationship: [msdyn_agreementinvoiceproduct msdyn_agreementinvoiceproduct_MailboxTrackingFolders](msdyn_agreementinvoiceproduct.md#BKMK_msdyn_agreementinvoiceproduct_MailboxTrackingFolders)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_agreementinvoiceproduct`|
|ReferencedAttribute|`msdyn_agreementinvoiceproductid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_agreementinvoiceproduct`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_agreementinvoicesetup_MailboxTrackingFolders"></a> msdyn_agreementinvoicesetup_MailboxTrackingFolders

One-To-Many Relationship: [msdyn_agreementinvoicesetup msdyn_agreementinvoicesetup_MailboxTrackingFolders](msdyn_agreementinvoicesetup.md#BKMK_msdyn_agreementinvoicesetup_MailboxTrackingFolders)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_agreementinvoicesetup`|
|ReferencedAttribute|`msdyn_agreementinvoicesetupid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_agreementinvoicesetup`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_agreementsubstatus_MailboxTrackingFolders"></a> msdyn_agreementsubstatus_MailboxTrackingFolders

One-To-Many Relationship: [msdyn_agreementsubstatus msdyn_agreementsubstatus_MailboxTrackingFolders](msdyn_agreementsubstatus.md#BKMK_msdyn_agreementsubstatus_MailboxTrackingFolders)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_agreementsubstatus`|
|ReferencedAttribute|`msdyn_agreementsubstatusid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_agreementsubstatus`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_assetsuggestionssetting_MailboxTrackingFolders"></a> msdyn_assetsuggestionssetting_MailboxTrackingFolders

One-To-Many Relationship: [msdyn_assetsuggestionssetting msdyn_assetsuggestionssetting_MailboxTrackingFolders](msdyn_assetsuggestionssetting.md#BKMK_msdyn_assetsuggestionssetting_MailboxTrackingFolders)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_assetsuggestionssetting`|
|ReferencedAttribute|`msdyn_assetsuggestionssettingid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_assetsuggestionssetting`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_bookableresourceassociation_MailboxTrackingFolders"></a> msdyn_bookableresourceassociation_MailboxTrackingFolders

One-To-Many Relationship: [msdyn_bookableresourceassociation msdyn_bookableresourceassociation_MailboxTrackingFolders](msdyn_bookableresourceassociation.md#BKMK_msdyn_bookableresourceassociation_MailboxTrackingFolders)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_bookableresourceassociation`|
|ReferencedAttribute|`msdyn_bookableresourceassociationid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_bookableresourceassociation`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_bookableresourcebookingquicknote_MailboxTrackingFolders"></a> msdyn_bookableresourcebookingquicknote_MailboxTrackingFolders

One-To-Many Relationship: [msdyn_bookableresourcebookingquicknote msdyn_bookableresourcebookingquicknote_MailboxTrackingFolders](msdyn_bookableresourcebookingquicknote.md#BKMK_msdyn_bookableresourcebookingquicknote_MailboxTrackingFolders)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_bookableresourcebookingquicknote`|
|ReferencedAttribute|`msdyn_bookableresourcebookingquicknoteid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_bookableresourcebookingquicknote`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_bookingalert_MailboxTrackingFolders"></a> msdyn_bookingalert_MailboxTrackingFolders

One-To-Many Relationship: [msdyn_bookingalert msdyn_bookingalert_MailboxTrackingFolders](msdyn_bookingalert.md#BKMK_msdyn_bookingalert_MailboxTrackingFolders)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_bookingalert`|
|ReferencedAttribute|`activityid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_bookingalert`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_bookingalertstatus_MailboxTrackingFolders"></a> msdyn_bookingalertstatus_MailboxTrackingFolders

One-To-Many Relationship: [msdyn_bookingalertstatus msdyn_bookingalertstatus_MailboxTrackingFolders](msdyn_bookingalertstatus.md#BKMK_msdyn_bookingalertstatus_MailboxTrackingFolders)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_bookingalertstatus`|
|ReferencedAttribute|`msdyn_bookingalertstatusid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_bookingalertstatus`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_bookingchange_MailboxTrackingFolders"></a> msdyn_bookingchange_MailboxTrackingFolders

One-To-Many Relationship: [msdyn_bookingchange msdyn_bookingchange_MailboxTrackingFolders](msdyn_bookingchange.md#BKMK_msdyn_bookingchange_MailboxTrackingFolders)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_bookingchange`|
|ReferencedAttribute|`msdyn_bookingchangeid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_bookingchange`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_bookingjournal_MailboxTrackingFolders"></a> msdyn_bookingjournal_MailboxTrackingFolders

One-To-Many Relationship: [msdyn_bookingjournal msdyn_bookingjournal_MailboxTrackingFolders](msdyn_bookingjournal.md#BKMK_msdyn_bookingjournal_MailboxTrackingFolders)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_bookingjournal`|
|ReferencedAttribute|`msdyn_bookingjournalid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_bookingjournal`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_bookingrule_MailboxTrackingFolders"></a> msdyn_bookingrule_MailboxTrackingFolders

One-To-Many Relationship: [msdyn_bookingrule msdyn_bookingrule_MailboxTrackingFolders](msdyn_bookingrule.md#BKMK_msdyn_bookingrule_MailboxTrackingFolders)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_bookingrule`|
|ReferencedAttribute|`msdyn_bookingruleid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_bookingrule`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_bookingsetupmetadata_MailboxTrackingFolders"></a> msdyn_bookingsetupmetadata_MailboxTrackingFolders

One-To-Many Relationship: [msdyn_bookingsetupmetadata msdyn_bookingsetupmetadata_MailboxTrackingFolders](msdyn_bookingsetupmetadata.md#BKMK_msdyn_bookingsetupmetadata_MailboxTrackingFolders)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_bookingsetupmetadata`|
|ReferencedAttribute|`msdyn_bookingsetupmetadataid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_bookingsetupmetadata`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_bookingtimestamp_MailboxTrackingFolders"></a> msdyn_bookingtimestamp_MailboxTrackingFolders

One-To-Many Relationship: [msdyn_bookingtimestamp msdyn_bookingtimestamp_MailboxTrackingFolders](msdyn_bookingtimestamp.md#BKMK_msdyn_bookingtimestamp_MailboxTrackingFolders)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_bookingtimestamp`|
|ReferencedAttribute|`msdyn_bookingtimestampid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_bookingtimestamp`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_bpf_2c5fe86acc8b414b8322ae571000c799_MailboxTrackingFolders"></a> msdyn_bpf_2c5fe86acc8b414b8322ae571000c799_MailboxTrackingFolders

One-To-Many Relationship: [msdyn_bpf_2c5fe86acc8b414b8322ae571000c799 msdyn_bpf_2c5fe86acc8b414b8322ae571000c799_MailboxTrackingFolders](msdyn_bpf_2c5fe86acc8b414b8322ae571000c799.md#BKMK_msdyn_bpf_2c5fe86acc8b414b8322ae571000c799_MailboxTrackingFolders)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_bpf_2c5fe86acc8b414b8322ae571000c799`|
|ReferencedAttribute|`businessprocessflowinstanceid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_bpf_2c5fe86acc8b414b8322ae571000c799`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_bpf_477c16f59170487b8b4dc895c5dcd09b_MailboxTrackingFolders"></a> msdyn_bpf_477c16f59170487b8b4dc895c5dcd09b_MailboxTrackingFolders

One-To-Many Relationship: [msdyn_bpf_477c16f59170487b8b4dc895c5dcd09b msdyn_bpf_477c16f59170487b8b4dc895c5dcd09b_MailboxTrackingFolders](msdyn_bpf_477c16f59170487b8b4dc895c5dcd09b.md#BKMK_msdyn_bpf_477c16f59170487b8b4dc895c5dcd09b_MailboxTrackingFolders)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_bpf_477c16f59170487b8b4dc895c5dcd09b`|
|ReferencedAttribute|`businessprocessflowinstanceid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_bpf_477c16f59170487b8b4dc895c5dcd09b`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_bpf_989e9b1857e24af18787d5143b67523b_MailboxTrackingFolders"></a> msdyn_bpf_989e9b1857e24af18787d5143b67523b_MailboxTrackingFolders

One-To-Many Relationship: [msdyn_bpf_989e9b1857e24af18787d5143b67523b msdyn_bpf_989e9b1857e24af18787d5143b67523b_MailboxTrackingFolders](msdyn_bpf_989e9b1857e24af18787d5143b67523b.md#BKMK_msdyn_bpf_989e9b1857e24af18787d5143b67523b_MailboxTrackingFolders)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_bpf_989e9b1857e24af18787d5143b67523b`|
|ReferencedAttribute|`businessprocessflowinstanceid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_bpf_989e9b1857e24af18787d5143b67523b`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_bpf_baa0a411a239410cb8bded8b5fdd88e3_MailboxTrackingFolders"></a> msdyn_bpf_baa0a411a239410cb8bded8b5fdd88e3_MailboxTrackingFolders

One-To-Many Relationship: [msdyn_bpf_baa0a411a239410cb8bded8b5fdd88e3 msdyn_bpf_baa0a411a239410cb8bded8b5fdd88e3_MailboxTrackingFolders](msdyn_bpf_baa0a411a239410cb8bded8b5fdd88e3.md#BKMK_msdyn_bpf_baa0a411a239410cb8bded8b5fdd88e3_MailboxTrackingFolders)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_bpf_baa0a411a239410cb8bded8b5fdd88e3`|
|ReferencedAttribute|`businessprocessflowinstanceid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_bpf_baa0a411a239410cb8bded8b5fdd88e3`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_bpf_d3d97bac8c294105840e99e37a9d1c39_MailboxTrackingFolders"></a> msdyn_bpf_d3d97bac8c294105840e99e37a9d1c39_MailboxTrackingFolders

One-To-Many Relationship: [msdyn_bpf_d3d97bac8c294105840e99e37a9d1c39 msdyn_bpf_d3d97bac8c294105840e99e37a9d1c39_MailboxTrackingFolders](msdyn_bpf_d3d97bac8c294105840e99e37a9d1c39.md#BKMK_msdyn_bpf_d3d97bac8c294105840e99e37a9d1c39_MailboxTrackingFolders)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_bpf_d3d97bac8c294105840e99e37a9d1c39`|
|ReferencedAttribute|`businessprocessflowinstanceid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_bpf_d3d97bac8c294105840e99e37a9d1c39`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_businessclosure_MailboxTrackingFolders"></a> msdyn_businessclosure_MailboxTrackingFolders

One-To-Many Relationship: [msdyn_businessclosure msdyn_businessclosure_MailboxTrackingFolders](msdyn_businessclosure.md#BKMK_msdyn_businessclosure_MailboxTrackingFolders)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_businessclosure`|
|ReferencedAttribute|`msdyn_businessclosureid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_businessclosure`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_clientextension_MailboxTrackingFolders"></a> msdyn_clientextension_MailboxTrackingFolders

One-To-Many Relationship: [msdyn_clientextension msdyn_clientextension_MailboxTrackingFolders](msdyn_clientextension.md#BKMK_msdyn_clientextension_MailboxTrackingFolders)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_clientextension`|
|ReferencedAttribute|`msdyn_clientextensionid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_clientextension`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_configuration_MailboxTrackingFolders"></a> msdyn_configuration_MailboxTrackingFolders

One-To-Many Relationship: [msdyn_configuration msdyn_configuration_MailboxTrackingFolders](msdyn_configuration.md#BKMK_msdyn_configuration_MailboxTrackingFolders)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_configuration`|
|ReferencedAttribute|`msdyn_configurationid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_configuration`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_consoleapplicationsessiontemplate_MailboxTrackingFolders"></a> msdyn_consoleapplicationsessiontemplate_MailboxTrackingFolders

One-To-Many Relationship: [msdyn_consoleapplicationsessiontemplate msdyn_consoleapplicationsessiontemplate_MailboxTrackingFolders](msdyn_consoleapplicationsessiontemplate.md#BKMK_msdyn_consoleapplicationsessiontemplate_MailboxTrackingFolders)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_consoleapplicationsessiontemplate`|
|ReferencedAttribute|`msdyn_consoleapplicationsessiontemplateid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_consoleapplicationsessiontemplate`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_dataanalyticsreport_fs_MailboxTrackingFolders"></a> msdyn_dataanalyticsreport_fs_MailboxTrackingFolders

One-To-Many Relationship: [msdyn_dataanalyticsreport_fs msdyn_dataanalyticsreport_fs_MailboxTrackingFolders](msdyn_dataanalyticsreport_fs.md#BKMK_msdyn_dataanalyticsreport_fs_MailboxTrackingFolders)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_dataanalyticsreport_fs`|
|ReferencedAttribute|`msdyn_dataanalyticsreport_fsid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_dataanalyticsreport_fs`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_dataanalyticsreport_fspredictrs_MailboxTrackingFolders"></a> msdyn_dataanalyticsreport_fspredictrs_MailboxTrackingFolders

One-To-Many Relationship: [msdyn_dataanalyticsreport_fspredictrs msdyn_dataanalyticsreport_fspredictrs_MailboxTrackingFolders](msdyn_dataanalyticsreport_fspredictrs.md#BKMK_msdyn_dataanalyticsreport_fspredictrs_MailboxTrackingFolders)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_dataanalyticsreport_fspredictrs`|
|ReferencedAttribute|`msdyn_dataanalyticsreport_fspredictrsid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_dataanalyticsreport_fspredictrs`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_dataanalyticsreport_fspredictwhd_MailboxTrackingFolders"></a> msdyn_dataanalyticsreport_fspredictwhd_MailboxTrackingFolders

One-To-Many Relationship: [msdyn_dataanalyticsreport_fspredictwhd msdyn_dataanalyticsreport_fspredictwhd_MailboxTrackingFolders](msdyn_dataanalyticsreport_fspredictwhd.md#BKMK_msdyn_dataanalyticsreport_fspredictwhd_MailboxTrackingFolders)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_dataanalyticsreport_fspredictwhd`|
|ReferencedAttribute|`msdyn_dataanalyticsreport_fspredictwhdid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_dataanalyticsreport_fspredictwhd`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_entitlementapplication_MailboxTrackingFolders"></a> msdyn_entitlementapplication_MailboxTrackingFolders

One-To-Many Relationship: [msdyn_entitlementapplication msdyn_entitlementapplication_MailboxTrackingFolders](msdyn_entitlementapplication.md#BKMK_msdyn_entitlementapplication_MailboxTrackingFolders)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_entitlementapplication`|
|ReferencedAttribute|`msdyn_entitlementapplicationid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_entitlementapplication`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_entityconfiguration_MailboxTrackingFolders"></a> msdyn_entityconfiguration_MailboxTrackingFolders

One-To-Many Relationship: [msdyn_entityconfiguration msdyn_entityconfiguration_MailboxTrackingFolders](msdyn_entityconfiguration.md#BKMK_msdyn_entityconfiguration_MailboxTrackingFolders)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_entityconfiguration`|
|ReferencedAttribute|`msdyn_entityconfigurationid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_entityconfiguration`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_fieldservicepricelistitem_MailboxTrackingFolders"></a> msdyn_fieldservicepricelistitem_MailboxTrackingFolders

One-To-Many Relationship: [msdyn_fieldservicepricelistitem msdyn_fieldservicepricelistitem_MailboxTrackingFolders](msdyn_fieldservicepricelistitem.md#BKMK_msdyn_fieldservicepricelistitem_MailboxTrackingFolders)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_fieldservicepricelistitem`|
|ReferencedAttribute|`msdyn_fieldservicepricelistitemid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_fieldservicepricelistitem`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_fieldservicesetting_MailboxTrackingFolders"></a> msdyn_fieldservicesetting_MailboxTrackingFolders

One-To-Many Relationship: [msdyn_fieldservicesetting msdyn_fieldservicesetting_MailboxTrackingFolders](msdyn_fieldservicesetting.md#BKMK_msdyn_fieldservicesetting_MailboxTrackingFolders)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_fieldservicesetting`|
|ReferencedAttribute|`msdyn_fieldservicesettingid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_fieldservicesetting`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_fieldserviceslaconfiguration_MailboxTrackingFolders"></a> msdyn_fieldserviceslaconfiguration_MailboxTrackingFolders

One-To-Many Relationship: [msdyn_fieldserviceslaconfiguration msdyn_fieldserviceslaconfiguration_MailboxTrackingFolders](msdyn_fieldserviceslaconfiguration.md#BKMK_msdyn_fieldserviceslaconfiguration_MailboxTrackingFolders)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_fieldserviceslaconfiguration`|
|ReferencedAttribute|`msdyn_fieldserviceslaconfigurationid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_fieldserviceslaconfiguration`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_fieldservicesummaryconfiguration_MailboxTrackingFolders"></a> msdyn_fieldservicesummaryconfiguration_MailboxTrackingFolders

One-To-Many Relationship: [msdyn_fieldservicesummaryconfiguration msdyn_fieldservicesummaryconfiguration_MailboxTrackingFolders](msdyn_fieldservicesummaryconfiguration.md#BKMK_msdyn_fieldservicesummaryconfiguration_MailboxTrackingFolders)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_fieldservicesummaryconfiguration`|
|ReferencedAttribute|`msdyn_fieldservicesummaryconfigurationid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_fieldservicesummaryconfiguration`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_fieldservicesystemjob_MailboxTrackingFolders"></a> msdyn_fieldservicesystemjob_MailboxTrackingFolders

One-To-Many Relationship: [msdyn_fieldservicesystemjob msdyn_fieldservicesystemjob_MailboxTrackingFolders](msdyn_fieldservicesystemjob.md#BKMK_msdyn_fieldservicesystemjob_MailboxTrackingFolders)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_fieldservicesystemjob`|
|ReferencedAttribute|`msdyn_fieldservicesystemjobid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_fieldservicesystemjob`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_flwconfiguration_MailboxTrackingFolders"></a> msdyn_flwconfiguration_MailboxTrackingFolders

One-To-Many Relationship: [msdyn_flwconfiguration msdyn_flwconfiguration_MailboxTrackingFolders](msdyn_flwconfiguration.md#BKMK_msdyn_flwconfiguration_MailboxTrackingFolders)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_flwconfiguration`|
|ReferencedAttribute|`msdyn_flwconfigurationid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_flwconfiguration`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_geofence_MailboxTrackingFolders"></a> msdyn_geofence_MailboxTrackingFolders

One-To-Many Relationship: [msdyn_geofence msdyn_geofence_MailboxTrackingFolders](msdyn_geofence.md#BKMK_msdyn_geofence_MailboxTrackingFolders)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_geofence`|
|ReferencedAttribute|`msdyn_geofenceid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_geofence`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_geofenceevent_MailboxTrackingFolders"></a> msdyn_geofenceevent_MailboxTrackingFolders

One-To-Many Relationship: [msdyn_geofenceevent msdyn_geofenceevent_MailboxTrackingFolders](msdyn_geofenceevent.md#BKMK_msdyn_geofenceevent_MailboxTrackingFolders)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_geofenceevent`|
|ReferencedAttribute|`msdyn_geofenceeventid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_geofenceevent`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_geofencingsettings_MailboxTrackingFolders"></a> msdyn_geofencingsettings_MailboxTrackingFolders

One-To-Many Relationship: [msdyn_geofencingsettings msdyn_geofencingsettings_MailboxTrackingFolders](msdyn_geofencingsettings.md#BKMK_msdyn_geofencingsettings_MailboxTrackingFolders)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_geofencingsettings`|
|ReferencedAttribute|`msdyn_geofencingsettingsid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_geofencingsettings`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_geolocationsettings_MailboxTrackingFolders"></a> msdyn_geolocationsettings_MailboxTrackingFolders

One-To-Many Relationship: [msdyn_geolocationsettings msdyn_geolocationsettings_MailboxTrackingFolders](msdyn_geolocationsettings.md#BKMK_msdyn_geolocationsettings_MailboxTrackingFolders)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_geolocationsettings`|
|ReferencedAttribute|`msdyn_geolocationsettingsid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_geolocationsettings`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_geolocationtracking_MailboxTrackingFolders"></a> msdyn_geolocationtracking_MailboxTrackingFolders

One-To-Many Relationship: [msdyn_geolocationtracking msdyn_geolocationtracking_MailboxTrackingFolders](msdyn_geolocationtracking.md#BKMK_msdyn_geolocationtracking_MailboxTrackingFolders)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_geolocationtracking`|
|ReferencedAttribute|`msdyn_geolocationtrackingid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_geolocationtracking`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_incidenttype_MailboxTrackingFolders"></a> msdyn_incidenttype_MailboxTrackingFolders

One-To-Many Relationship: [msdyn_incidenttype msdyn_incidenttype_MailboxTrackingFolders](msdyn_incidenttype.md#BKMK_msdyn_incidenttype_MailboxTrackingFolders)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_incidenttype`|
|ReferencedAttribute|`msdyn_incidenttypeid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_incidenttype`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_incidenttype_requirementgroup_MailboxTrackingFolders"></a> msdyn_incidenttype_requirementgroup_MailboxTrackingFolders

One-To-Many Relationship: [msdyn_incidenttype_requirementgroup msdyn_incidenttype_requirementgroup_MailboxTrackingFolders](msdyn_incidenttype_requirementgroup.md#BKMK_msdyn_incidenttype_requirementgroup_MailboxTrackingFolders)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_incidenttype_requirementgroup`|
|ReferencedAttribute|`msdyn_incidenttype_requirementgroupid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_incidenttype_requirementgroup`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_incidenttypecharacteristic_MailboxTrackingFolders"></a> msdyn_incidenttypecharacteristic_MailboxTrackingFolders

One-To-Many Relationship: [msdyn_incidenttypecharacteristic msdyn_incidenttypecharacteristic_MailboxTrackingFolders](msdyn_incidenttypecharacteristic.md#BKMK_msdyn_incidenttypecharacteristic_MailboxTrackingFolders)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_incidenttypecharacteristic`|
|ReferencedAttribute|`msdyn_incidenttypecharacteristicid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_incidenttypecharacteristic`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_incidenttypeproduct_MailboxTrackingFolders"></a> msdyn_incidenttypeproduct_MailboxTrackingFolders

One-To-Many Relationship: [msdyn_incidenttypeproduct msdyn_incidenttypeproduct_MailboxTrackingFolders](msdyn_incidenttypeproduct.md#BKMK_msdyn_incidenttypeproduct_MailboxTrackingFolders)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_incidenttypeproduct`|
|ReferencedAttribute|`msdyn_incidenttypeproductid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_incidenttypeproduct`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_incidenttyperecommendationresult_MailboxTrackingFolders"></a> msdyn_incidenttyperecommendationresult_MailboxTrackingFolders

One-To-Many Relationship: [msdyn_incidenttyperecommendationresult msdyn_incidenttyperecommendationresult_MailboxTrackingFolders](msdyn_incidenttyperecommendationresult.md#BKMK_msdyn_incidenttyperecommendationresult_MailboxTrackingFolders)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_incidenttyperecommendationresult`|
|ReferencedAttribute|`msdyn_incidenttyperecommendationresultid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_incidenttyperecommendationresult`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_incidenttyperecommendationrunhistory_MailboxTrackingFolders"></a> msdyn_incidenttyperecommendationrunhistory_MailboxTrackingFolders

One-To-Many Relationship: [msdyn_incidenttyperecommendationrunhistory msdyn_incidenttyperecommendationrunhistory_MailboxTrackingFolders](msdyn_incidenttyperecommendationrunhistory.md#BKMK_msdyn_incidenttyperecommendationrunhistory_MailboxTrackingFolders)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_incidenttyperecommendationrunhistory`|
|ReferencedAttribute|`msdyn_incidenttyperecommendationrunhistoryid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_incidenttyperecommendationrunhistory`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_incidenttyperesolution_MailboxTrackingFolders"></a> msdyn_incidenttyperesolution_MailboxTrackingFolders

One-To-Many Relationship: [msdyn_incidenttyperesolution msdyn_incidenttyperesolution_MailboxTrackingFolders](msdyn_incidenttyperesolution.md#BKMK_msdyn_incidenttyperesolution_MailboxTrackingFolders)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_incidenttyperesolution`|
|ReferencedAttribute|`msdyn_incidenttyperesolutionid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_incidenttyperesolution`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_incidenttypeservice_MailboxTrackingFolders"></a> msdyn_incidenttypeservice_MailboxTrackingFolders

One-To-Many Relationship: [msdyn_incidenttypeservice msdyn_incidenttypeservice_MailboxTrackingFolders](msdyn_incidenttypeservice.md#BKMK_msdyn_incidenttypeservice_MailboxTrackingFolders)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_incidenttypeservice`|
|ReferencedAttribute|`msdyn_incidenttypeserviceid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_incidenttypeservice`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_incidenttypeservicetask_MailboxTrackingFolders"></a> msdyn_incidenttypeservicetask_MailboxTrackingFolders

One-To-Many Relationship: [msdyn_incidenttypeservicetask msdyn_incidenttypeservicetask_MailboxTrackingFolders](msdyn_incidenttypeservicetask.md#BKMK_msdyn_incidenttypeservicetask_MailboxTrackingFolders)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_incidenttypeservicetask`|
|ReferencedAttribute|`msdyn_incidenttypeservicetaskid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_incidenttypeservicetask`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_incidenttypessetup_MailboxTrackingFolders"></a> msdyn_incidenttypessetup_MailboxTrackingFolders

One-To-Many Relationship: [msdyn_incidenttypessetup msdyn_incidenttypessetup_MailboxTrackingFolders](msdyn_incidenttypessetup.md#BKMK_msdyn_incidenttypessetup_MailboxTrackingFolders)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_incidenttypessetup`|
|ReferencedAttribute|`msdyn_incidenttypessetupid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_incidenttypessetup`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_inspection_MailboxTrackingFolders"></a> msdyn_inspection_MailboxTrackingFolders

One-To-Many Relationship: [msdyn_inspection msdyn_inspection_MailboxTrackingFolders](msdyn_inspection.md#BKMK_msdyn_inspection_MailboxTrackingFolders)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_inspection`|
|ReferencedAttribute|`msdyn_inspectionid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_inspection`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_inspectionattachment_MailboxTrackingFolders"></a> msdyn_inspectionattachment_MailboxTrackingFolders

One-To-Many Relationship: [msdyn_inspectionattachment msdyn_inspectionattachment_MailboxTrackingFolders](msdyn_inspectionattachment.md#BKMK_msdyn_inspectionattachment_MailboxTrackingFolders)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_inspectionattachment`|
|ReferencedAttribute|`msdyn_inspectionattachmentid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_inspectionattachment`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_inspectiondefinition_MailboxTrackingFolders"></a> msdyn_inspectiondefinition_MailboxTrackingFolders

One-To-Many Relationship: [msdyn_inspectiondefinition msdyn_inspectiondefinition_MailboxTrackingFolders](msdyn_inspectiondefinition.md#BKMK_msdyn_inspectiondefinition_MailboxTrackingFolders)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_inspectiondefinition`|
|ReferencedAttribute|`msdyn_inspectiondefinitionid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_inspectiondefinition`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_inspectioninstance_MailboxTrackingFolders"></a> msdyn_inspectioninstance_MailboxTrackingFolders

One-To-Many Relationship: [msdyn_inspectioninstance msdyn_inspectioninstance_MailboxTrackingFolders](msdyn_inspectioninstance.md#BKMK_msdyn_inspectioninstance_MailboxTrackingFolders)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_inspectioninstance`|
|ReferencedAttribute|`msdyn_inspectioninstanceid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_inspectioninstance`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_inspectionresponse_MailboxTrackingFolders"></a> msdyn_inspectionresponse_MailboxTrackingFolders

One-To-Many Relationship: [msdyn_inspectionresponse msdyn_inspectionresponse_MailboxTrackingFolders](msdyn_inspectionresponse.md#BKMK_msdyn_inspectionresponse_MailboxTrackingFolders)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_inspectionresponse`|
|ReferencedAttribute|`msdyn_inspectionresponseid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_inspectionresponse`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_insurance_MailboxTrackingFolders"></a> msdyn_insurance_MailboxTrackingFolders

One-To-Many Relationship: [msdyn_insurance msdyn_insurance_MailboxTrackingFolders](msdyn_insurance.md#BKMK_msdyn_insurance_MailboxTrackingFolders)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_insurance`|
|ReferencedAttribute|`msdyn_insuranceid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_insurance`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_inventoryadjustment_MailboxTrackingFolders"></a> msdyn_inventoryadjustment_MailboxTrackingFolders

One-To-Many Relationship: [msdyn_inventoryadjustment msdyn_inventoryadjustment_MailboxTrackingFolders](msdyn_inventoryadjustment.md#BKMK_msdyn_inventoryadjustment_MailboxTrackingFolders)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_inventoryadjustment`|
|ReferencedAttribute|`msdyn_inventoryadjustmentid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_inventoryadjustment`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_inventoryadjustmentproduct_MailboxTrackingFolders"></a> msdyn_inventoryadjustmentproduct_MailboxTrackingFolders

One-To-Many Relationship: [msdyn_inventoryadjustmentproduct msdyn_inventoryadjustmentproduct_MailboxTrackingFolders](msdyn_inventoryadjustmentproduct.md#BKMK_msdyn_inventoryadjustmentproduct_MailboxTrackingFolders)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_inventoryadjustmentproduct`|
|ReferencedAttribute|`msdyn_inventoryadjustmentproductid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_inventoryadjustmentproduct`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_inventoryjournal_MailboxTrackingFolders"></a> msdyn_inventoryjournal_MailboxTrackingFolders

One-To-Many Relationship: [msdyn_inventoryjournal msdyn_inventoryjournal_MailboxTrackingFolders](msdyn_inventoryjournal.md#BKMK_msdyn_inventoryjournal_MailboxTrackingFolders)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_inventoryjournal`|
|ReferencedAttribute|`msdyn_inventoryjournalid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_inventoryjournal`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_inventorytransfer_MailboxTrackingFolders"></a> msdyn_inventorytransfer_MailboxTrackingFolders

One-To-Many Relationship: [msdyn_inventorytransfer msdyn_inventorytransfer_MailboxTrackingFolders](msdyn_inventorytransfer.md#BKMK_msdyn_inventorytransfer_MailboxTrackingFolders)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_inventorytransfer`|
|ReferencedAttribute|`msdyn_inventorytransferid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_inventorytransfer`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_mobilesource_MailboxTrackingFolders"></a> msdyn_mobilesource_MailboxTrackingFolders

One-To-Many Relationship: [msdyn_mobilesource msdyn_mobilesource_MailboxTrackingFolders](msdyn_mobilesource.md#BKMK_msdyn_mobilesource_MailboxTrackingFolders)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_mobilesource`|
|ReferencedAttribute|`msdyn_mobilesourceid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_mobilesource`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_nottoexceed_MailboxTrackingFolders"></a> msdyn_nottoexceed_MailboxTrackingFolders

One-To-Many Relationship: [msdyn_nottoexceed msdyn_nottoexceed_MailboxTrackingFolders](msdyn_nottoexceed.md#BKMK_msdyn_nottoexceed_MailboxTrackingFolders)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_nottoexceed`|
|ReferencedAttribute|`msdyn_nottoexceedid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_nottoexceed`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_orderinvoicingdate_MailboxTrackingFolders"></a> msdyn_orderinvoicingdate_MailboxTrackingFolders

One-To-Many Relationship: [msdyn_orderinvoicingdate msdyn_orderinvoicingdate_MailboxTrackingFolders](msdyn_orderinvoicingdate.md#BKMK_msdyn_orderinvoicingdate_MailboxTrackingFolders)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_orderinvoicingdate`|
|ReferencedAttribute|`msdyn_orderinvoicingdateid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_orderinvoicingdate`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_orderinvoicingproduct_MailboxTrackingFolders"></a> msdyn_orderinvoicingproduct_MailboxTrackingFolders

One-To-Many Relationship: [msdyn_orderinvoicingproduct msdyn_orderinvoicingproduct_MailboxTrackingFolders](msdyn_orderinvoicingproduct.md#BKMK_msdyn_orderinvoicingproduct_MailboxTrackingFolders)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_orderinvoicingproduct`|
|ReferencedAttribute|`msdyn_orderinvoicingproductid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_orderinvoicingproduct`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_orderinvoicingsetup_MailboxTrackingFolders"></a> msdyn_orderinvoicingsetup_MailboxTrackingFolders

One-To-Many Relationship: [msdyn_orderinvoicingsetup msdyn_orderinvoicingsetup_MailboxTrackingFolders](msdyn_orderinvoicingsetup.md#BKMK_msdyn_orderinvoicingsetup_MailboxTrackingFolders)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_orderinvoicingsetup`|
|ReferencedAttribute|`msdyn_orderinvoicingsetupid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_orderinvoicingsetup`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_orderinvoicingsetupdate_MailboxTrackingFolders"></a> msdyn_orderinvoicingsetupdate_MailboxTrackingFolders

One-To-Many Relationship: [msdyn_orderinvoicingsetupdate msdyn_orderinvoicingsetupdate_MailboxTrackingFolders](msdyn_orderinvoicingsetupdate.md#BKMK_msdyn_orderinvoicingsetupdate_MailboxTrackingFolders)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_orderinvoicingsetupdate`|
|ReferencedAttribute|`msdyn_orderinvoicingsetupdateid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_orderinvoicingsetupdate`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_organizationalunit_MailboxTrackingFolders"></a> msdyn_organizationalunit_MailboxTrackingFolders

One-To-Many Relationship: [msdyn_organizationalunit msdyn_organizationalunit_MailboxTrackingFolders](msdyn_organizationalunit.md#BKMK_msdyn_organizationalunit_MailboxTrackingFolders)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_organizationalunit`|
|ReferencedAttribute|`msdyn_organizationalunitid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_organizationalunit`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_payment_MailboxTrackingFolders"></a> msdyn_payment_MailboxTrackingFolders

One-To-Many Relationship: [msdyn_payment msdyn_payment_MailboxTrackingFolders](msdyn_payment.md#BKMK_msdyn_payment_MailboxTrackingFolders)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_payment`|
|ReferencedAttribute|`msdyn_paymentid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_payment`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_paymentdetail_MailboxTrackingFolders"></a> msdyn_paymentdetail_MailboxTrackingFolders

One-To-Many Relationship: [msdyn_paymentdetail msdyn_paymentdetail_MailboxTrackingFolders](msdyn_paymentdetail.md#BKMK_msdyn_paymentdetail_MailboxTrackingFolders)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_paymentdetail`|
|ReferencedAttribute|`msdyn_paymentdetailid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_paymentdetail`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_paymentmethod_MailboxTrackingFolders"></a> msdyn_paymentmethod_MailboxTrackingFolders

One-To-Many Relationship: [msdyn_paymentmethod msdyn_paymentmethod_MailboxTrackingFolders](msdyn_paymentmethod.md#BKMK_msdyn_paymentmethod_MailboxTrackingFolders)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_paymentmethod`|
|ReferencedAttribute|`msdyn_paymentmethodid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_paymentmethod`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_paymentterm_MailboxTrackingFolders"></a> msdyn_paymentterm_MailboxTrackingFolders

One-To-Many Relationship: [msdyn_paymentterm msdyn_paymentterm_MailboxTrackingFolders](msdyn_paymentterm.md#BKMK_msdyn_paymentterm_MailboxTrackingFolders)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_paymentterm`|
|ReferencedAttribute|`msdyn_paymenttermid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_paymentterm`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_postalcode_MailboxTrackingFolders"></a> msdyn_postalcode_MailboxTrackingFolders

One-To-Many Relationship: [msdyn_postalcode msdyn_postalcode_MailboxTrackingFolders](msdyn_postalcode.md#BKMK_msdyn_postalcode_MailboxTrackingFolders)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_postalcode`|
|ReferencedAttribute|`msdyn_postalcodeid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_postalcode`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_predictworkhourdurationsetting_MailboxTrackingFolders"></a> msdyn_predictworkhourdurationsetting_MailboxTrackingFolders

One-To-Many Relationship: [msdyn_predictworkhourdurationsetting msdyn_predictworkhourdurationsetting_MailboxTrackingFolders](msdyn_predictworkhourdurationsetting.md#BKMK_msdyn_predictworkhourdurationsetting_MailboxTrackingFolders)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_predictworkhourdurationsetting`|
|ReferencedAttribute|`msdyn_predictworkhourdurationsettingid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_predictworkhourdurationsetting`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_priority_MailboxTrackingFolders"></a> msdyn_priority_MailboxTrackingFolders

One-To-Many Relationship: [msdyn_priority msdyn_priority_MailboxTrackingFolders](msdyn_priority.md#BKMK_msdyn_priority_MailboxTrackingFolders)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_priority`|
|ReferencedAttribute|`msdyn_priorityid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_priority`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_problematicasset_MailboxTrackingFolders"></a> msdyn_problematicasset_MailboxTrackingFolders

One-To-Many Relationship: [msdyn_problematicasset msdyn_problematicasset_MailboxTrackingFolders](msdyn_problematicasset.md#BKMK_msdyn_problematicasset_MailboxTrackingFolders)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_problematicasset`|
|ReferencedAttribute|`msdyn_problematicassetid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_problematicasset`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_problematicassetfeedback_MailboxTrackingFolders"></a> msdyn_problematicassetfeedback_MailboxTrackingFolders

One-To-Many Relationship: [msdyn_problematicassetfeedback msdyn_problematicassetfeedback_MailboxTrackingFolders](msdyn_problematicassetfeedback.md#BKMK_msdyn_problematicassetfeedback_MailboxTrackingFolders)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_problematicassetfeedback`|
|ReferencedAttribute|`msdyn_problematicassetfeedbackid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_problematicassetfeedback`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_productinventory_MailboxTrackingFolders"></a> msdyn_productinventory_MailboxTrackingFolders

One-To-Many Relationship: [msdyn_productinventory msdyn_productinventory_MailboxTrackingFolders](msdyn_productinventory.md#BKMK_msdyn_productinventory_MailboxTrackingFolders)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_productinventory`|
|ReferencedAttribute|`msdyn_productinventoryid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_productinventory`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_purchaseorder_MailboxTrackingFolders"></a> msdyn_purchaseorder_MailboxTrackingFolders

One-To-Many Relationship: [msdyn_purchaseorder msdyn_purchaseorder_MailboxTrackingFolders](msdyn_purchaseorder.md#BKMK_msdyn_purchaseorder_MailboxTrackingFolders)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_purchaseorder`|
|ReferencedAttribute|`msdyn_purchaseorderid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_purchaseorder`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_purchaseorderbill_MailboxTrackingFolders"></a> msdyn_purchaseorderbill_MailboxTrackingFolders

One-To-Many Relationship: [msdyn_purchaseorderbill msdyn_purchaseorderbill_MailboxTrackingFolders](msdyn_purchaseorderbill.md#BKMK_msdyn_purchaseorderbill_MailboxTrackingFolders)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_purchaseorderbill`|
|ReferencedAttribute|`msdyn_purchaseorderbillid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_purchaseorderbill`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_purchaseorderproduct_MailboxTrackingFolders"></a> msdyn_purchaseorderproduct_MailboxTrackingFolders

One-To-Many Relationship: [msdyn_purchaseorderproduct msdyn_purchaseorderproduct_MailboxTrackingFolders](msdyn_purchaseorderproduct.md#BKMK_msdyn_purchaseorderproduct_MailboxTrackingFolders)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_purchaseorderproduct`|
|ReferencedAttribute|`msdyn_purchaseorderproductid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_purchaseorderproduct`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_purchaseorderreceipt_MailboxTrackingFolders"></a> msdyn_purchaseorderreceipt_MailboxTrackingFolders

One-To-Many Relationship: [msdyn_purchaseorderreceipt msdyn_purchaseorderreceipt_MailboxTrackingFolders](msdyn_purchaseorderreceipt.md#BKMK_msdyn_purchaseorderreceipt_MailboxTrackingFolders)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_purchaseorderreceipt`|
|ReferencedAttribute|`msdyn_purchaseorderreceiptid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_purchaseorderreceipt`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_purchaseorderreceiptproduct_MailboxTrackingFolders"></a> msdyn_purchaseorderreceiptproduct_MailboxTrackingFolders

One-To-Many Relationship: [msdyn_purchaseorderreceiptproduct msdyn_purchaseorderreceiptproduct_MailboxTrackingFolders](msdyn_purchaseorderreceiptproduct.md#BKMK_msdyn_purchaseorderreceiptproduct_MailboxTrackingFolders)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_purchaseorderreceiptproduct`|
|ReferencedAttribute|`msdyn_purchaseorderreceiptproductid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_purchaseorderreceiptproduct`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_purchaseordersubstatus_MailboxTrackingFolders"></a> msdyn_purchaseordersubstatus_MailboxTrackingFolders

One-To-Many Relationship: [msdyn_purchaseordersubstatus msdyn_purchaseordersubstatus_MailboxTrackingFolders](msdyn_purchaseordersubstatus.md#BKMK_msdyn_purchaseordersubstatus_MailboxTrackingFolders)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_purchaseordersubstatus`|
|ReferencedAttribute|`msdyn_purchaseordersubstatusid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_purchaseordersubstatus`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_quotebookingincident_MailboxTrackingFolders"></a> msdyn_quotebookingincident_MailboxTrackingFolders

One-To-Many Relationship: [msdyn_quotebookingincident msdyn_quotebookingincident_MailboxTrackingFolders](msdyn_quotebookingincident.md#BKMK_msdyn_quotebookingincident_MailboxTrackingFolders)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_quotebookingincident`|
|ReferencedAttribute|`msdyn_quotebookingincidentid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_quotebookingincident`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_quotebookingproduct_MailboxTrackingFolders"></a> msdyn_quotebookingproduct_MailboxTrackingFolders

One-To-Many Relationship: [msdyn_quotebookingproduct msdyn_quotebookingproduct_MailboxTrackingFolders](msdyn_quotebookingproduct.md#BKMK_msdyn_quotebookingproduct_MailboxTrackingFolders)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_quotebookingproduct`|
|ReferencedAttribute|`msdyn_quotebookingproductid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_quotebookingproduct`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_quotebookingservice_MailboxTrackingFolders"></a> msdyn_quotebookingservice_MailboxTrackingFolders

One-To-Many Relationship: [msdyn_quotebookingservice msdyn_quotebookingservice_MailboxTrackingFolders](msdyn_quotebookingservice.md#BKMK_msdyn_quotebookingservice_MailboxTrackingFolders)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_quotebookingservice`|
|ReferencedAttribute|`msdyn_quotebookingserviceid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_quotebookingservice`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_quotebookingservicetask_MailboxTrackingFolders"></a> msdyn_quotebookingservicetask_MailboxTrackingFolders

One-To-Many Relationship: [msdyn_quotebookingservicetask msdyn_quotebookingservicetask_MailboxTrackingFolders](msdyn_quotebookingservicetask.md#BKMK_msdyn_quotebookingservicetask_MailboxTrackingFolders)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_quotebookingservicetask`|
|ReferencedAttribute|`msdyn_quotebookingservicetaskid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_quotebookingservicetask`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_quotebookingsetup_MailboxTrackingFolders"></a> msdyn_quotebookingsetup_MailboxTrackingFolders

One-To-Many Relationship: [msdyn_quotebookingsetup msdyn_quotebookingsetup_MailboxTrackingFolders](msdyn_quotebookingsetup.md#BKMK_msdyn_quotebookingsetup_MailboxTrackingFolders)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_quotebookingsetup`|
|ReferencedAttribute|`msdyn_quotebookingsetupid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_quotebookingsetup`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_quoteinvoicingproduct_MailboxTrackingFolders"></a> msdyn_quoteinvoicingproduct_MailboxTrackingFolders

One-To-Many Relationship: [msdyn_quoteinvoicingproduct msdyn_quoteinvoicingproduct_MailboxTrackingFolders](msdyn_quoteinvoicingproduct.md#BKMK_msdyn_quoteinvoicingproduct_MailboxTrackingFolders)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_quoteinvoicingproduct`|
|ReferencedAttribute|`msdyn_quoteinvoicingproductid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_quoteinvoicingproduct`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_quoteinvoicingsetup_MailboxTrackingFolders"></a> msdyn_quoteinvoicingsetup_MailboxTrackingFolders

One-To-Many Relationship: [msdyn_quoteinvoicingsetup msdyn_quoteinvoicingsetup_MailboxTrackingFolders](msdyn_quoteinvoicingsetup.md#BKMK_msdyn_quoteinvoicingsetup_MailboxTrackingFolders)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_quoteinvoicingsetup`|
|ReferencedAttribute|`msdyn_quoteinvoicingsetupid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_quoteinvoicingsetup`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_requirementchange_MailboxTrackingFolders"></a> msdyn_requirementchange_MailboxTrackingFolders

One-To-Many Relationship: [msdyn_requirementchange msdyn_requirementchange_MailboxTrackingFolders](msdyn_requirementchange.md#BKMK_msdyn_requirementchange_MailboxTrackingFolders)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_requirementchange`|
|ReferencedAttribute|`msdyn_requirementchangeid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_requirementchange`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_requirementcharacteristic_MailboxTrackingFolders"></a> msdyn_requirementcharacteristic_MailboxTrackingFolders

One-To-Many Relationship: [msdyn_requirementcharacteristic msdyn_requirementcharacteristic_MailboxTrackingFolders](msdyn_requirementcharacteristic.md#BKMK_msdyn_requirementcharacteristic_MailboxTrackingFolders)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_requirementcharacteristic`|
|ReferencedAttribute|`msdyn_requirementcharacteristicid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_requirementcharacteristic`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_requirementdependency_MailboxTrackingFolders"></a> msdyn_requirementdependency_MailboxTrackingFolders

One-To-Many Relationship: [msdyn_requirementdependency msdyn_requirementdependency_MailboxTrackingFolders](msdyn_requirementdependency.md#BKMK_msdyn_requirementdependency_MailboxTrackingFolders)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_requirementdependency`|
|ReferencedAttribute|`msdyn_requirementdependencyid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_requirementdependency`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_requirementgroup_MailboxTrackingFolders"></a> msdyn_requirementgroup_MailboxTrackingFolders

One-To-Many Relationship: [msdyn_requirementgroup msdyn_requirementgroup_MailboxTrackingFolders](msdyn_requirementgroup.md#BKMK_msdyn_requirementgroup_MailboxTrackingFolders)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_requirementgroup`|
|ReferencedAttribute|`msdyn_requirementgroupid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_requirementgroup`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_requirementorganizationunit_MailboxTrackingFolders"></a> msdyn_requirementorganizationunit_MailboxTrackingFolders

One-To-Many Relationship: [msdyn_requirementorganizationunit msdyn_requirementorganizationunit_MailboxTrackingFolders](msdyn_requirementorganizationunit.md#BKMK_msdyn_requirementorganizationunit_MailboxTrackingFolders)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_requirementorganizationunit`|
|ReferencedAttribute|`msdyn_requirementorganizationunitid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_requirementorganizationunit`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_requirementrelationship_MailboxTrackingFolders"></a> msdyn_requirementrelationship_MailboxTrackingFolders

One-To-Many Relationship: [msdyn_requirementrelationship msdyn_requirementrelationship_MailboxTrackingFolders](msdyn_requirementrelationship.md#BKMK_msdyn_requirementrelationship_MailboxTrackingFolders)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_requirementrelationship`|
|ReferencedAttribute|`msdyn_requirementrelationshipid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_requirementrelationship`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_requirementresourcecategory_MailboxTrackingFolders"></a> msdyn_requirementresourcecategory_MailboxTrackingFolders

One-To-Many Relationship: [msdyn_requirementresourcecategory msdyn_requirementresourcecategory_MailboxTrackingFolders](msdyn_requirementresourcecategory.md#BKMK_msdyn_requirementresourcecategory_MailboxTrackingFolders)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_requirementresourcecategory`|
|ReferencedAttribute|`msdyn_requirementresourcecategoryid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_requirementresourcecategory`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_requirementresourcepreference_MailboxTrackingFolders"></a> msdyn_requirementresourcepreference_MailboxTrackingFolders

One-To-Many Relationship: [msdyn_requirementresourcepreference msdyn_requirementresourcepreference_MailboxTrackingFolders](msdyn_requirementresourcepreference.md#BKMK_msdyn_requirementresourcepreference_MailboxTrackingFolders)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_requirementresourcepreference`|
|ReferencedAttribute|`msdyn_requirementresourcepreferenceid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_requirementresourcepreference`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_requirementstatus_MailboxTrackingFolders"></a> msdyn_requirementstatus_MailboxTrackingFolders

One-To-Many Relationship: [msdyn_requirementstatus msdyn_requirementstatus_MailboxTrackingFolders](msdyn_requirementstatus.md#BKMK_msdyn_requirementstatus_MailboxTrackingFolders)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_requirementstatus`|
|ReferencedAttribute|`msdyn_requirementstatusid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_requirementstatus`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_resolution_MailboxTrackingFolders"></a> msdyn_resolution_MailboxTrackingFolders

One-To-Many Relationship: [msdyn_resolution msdyn_resolution_MailboxTrackingFolders](msdyn_resolution.md#BKMK_msdyn_resolution_MailboxTrackingFolders)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_resolution`|
|ReferencedAttribute|`msdyn_resolutionid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_resolution`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_resourcepaytype_MailboxTrackingFolders"></a> msdyn_resourcepaytype_MailboxTrackingFolders

One-To-Many Relationship: [msdyn_resourcepaytype msdyn_resourcepaytype_MailboxTrackingFolders](msdyn_resourcepaytype.md#BKMK_msdyn_resourcepaytype_MailboxTrackingFolders)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_resourcepaytype`|
|ReferencedAttribute|`msdyn_resourcepaytypeid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_resourcepaytype`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_resourcerequirement_MailboxTrackingFolders"></a> msdyn_resourcerequirement_MailboxTrackingFolders

One-To-Many Relationship: [msdyn_resourcerequirement msdyn_resourcerequirement_MailboxTrackingFolders](msdyn_resourcerequirement.md#BKMK_msdyn_resourcerequirement_MailboxTrackingFolders)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_resourcerequirement`|
|ReferencedAttribute|`msdyn_resourcerequirementid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_resourcerequirement`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_resourcerequirementdetail_MailboxTrackingFolders"></a> msdyn_resourcerequirementdetail_MailboxTrackingFolders

One-To-Many Relationship: [msdyn_resourcerequirementdetail msdyn_resourcerequirementdetail_MailboxTrackingFolders](msdyn_resourcerequirementdetail.md#BKMK_msdyn_resourcerequirementdetail_MailboxTrackingFolders)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_resourcerequirementdetail`|
|ReferencedAttribute|`msdyn_resourcerequirementdetailid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_resourcerequirementdetail`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_resourceterritory_MailboxTrackingFolders"></a> msdyn_resourceterritory_MailboxTrackingFolders

One-To-Many Relationship: [msdyn_resourceterritory msdyn_resourceterritory_MailboxTrackingFolders](msdyn_resourceterritory.md#BKMK_msdyn_resourceterritory_MailboxTrackingFolders)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_resourceterritory`|
|ReferencedAttribute|`msdyn_resourceterritoryid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_resourceterritory`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_rma_MailboxTrackingFolders"></a> msdyn_rma_MailboxTrackingFolders

One-To-Many Relationship: [msdyn_rma msdyn_rma_MailboxTrackingFolders](msdyn_rma.md#BKMK_msdyn_rma_MailboxTrackingFolders)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_rma`|
|ReferencedAttribute|`msdyn_rmaid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_rma`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_rmaproduct_MailboxTrackingFolders"></a> msdyn_rmaproduct_MailboxTrackingFolders

One-To-Many Relationship: [msdyn_rmaproduct msdyn_rmaproduct_MailboxTrackingFolders](msdyn_rmaproduct.md#BKMK_msdyn_rmaproduct_MailboxTrackingFolders)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_rmaproduct`|
|ReferencedAttribute|`msdyn_rmaproductid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_rmaproduct`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_rmareceipt_MailboxTrackingFolders"></a> msdyn_rmareceipt_MailboxTrackingFolders

One-To-Many Relationship: [msdyn_rmareceipt msdyn_rmareceipt_MailboxTrackingFolders](msdyn_rmareceipt.md#BKMK_msdyn_rmareceipt_MailboxTrackingFolders)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_rmareceipt`|
|ReferencedAttribute|`msdyn_rmareceiptid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_rmareceipt`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_rmareceiptproduct_MailboxTrackingFolders"></a> msdyn_rmareceiptproduct_MailboxTrackingFolders

One-To-Many Relationship: [msdyn_rmareceiptproduct msdyn_rmareceiptproduct_MailboxTrackingFolders](msdyn_rmareceiptproduct.md#BKMK_msdyn_rmareceiptproduct_MailboxTrackingFolders)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_rmareceiptproduct`|
|ReferencedAttribute|`msdyn_rmareceiptproductid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_rmareceiptproduct`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_rmasubstatus_MailboxTrackingFolders"></a> msdyn_rmasubstatus_MailboxTrackingFolders

One-To-Many Relationship: [msdyn_rmasubstatus msdyn_rmasubstatus_MailboxTrackingFolders](msdyn_rmasubstatus.md#BKMK_msdyn_rmasubstatus_MailboxTrackingFolders)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_rmasubstatus`|
|ReferencedAttribute|`msdyn_rmasubstatusid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_rmasubstatus`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_rtv_MailboxTrackingFolders"></a> msdyn_rtv_MailboxTrackingFolders

One-To-Many Relationship: [msdyn_rtv msdyn_rtv_MailboxTrackingFolders](msdyn_rtv.md#BKMK_msdyn_rtv_MailboxTrackingFolders)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_rtv`|
|ReferencedAttribute|`msdyn_rtvid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_rtv`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_rtvproduct_MailboxTrackingFolders"></a> msdyn_rtvproduct_MailboxTrackingFolders

One-To-Many Relationship: [msdyn_rtvproduct msdyn_rtvproduct_MailboxTrackingFolders](msdyn_rtvproduct.md#BKMK_msdyn_rtvproduct_MailboxTrackingFolders)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_rtvproduct`|
|ReferencedAttribute|`msdyn_rtvproductid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_rtvproduct`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_rtvsubstatus_MailboxTrackingFolders"></a> msdyn_rtvsubstatus_MailboxTrackingFolders

One-To-Many Relationship: [msdyn_rtvsubstatus msdyn_rtvsubstatus_MailboxTrackingFolders](msdyn_rtvsubstatus.md#BKMK_msdyn_rtvsubstatus_MailboxTrackingFolders)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_rtvsubstatus`|
|ReferencedAttribute|`msdyn_rtvsubstatusid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_rtvsubstatus`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_scheduleboardsetting_MailboxTrackingFolders"></a> msdyn_scheduleboardsetting_MailboxTrackingFolders

One-To-Many Relationship: [msdyn_scheduleboardsetting msdyn_scheduleboardsetting_MailboxTrackingFolders](msdyn_scheduleboardsetting.md#BKMK_msdyn_scheduleboardsetting_MailboxTrackingFolders)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_scheduleboardsetting`|
|ReferencedAttribute|`msdyn_scheduleboardsettingid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_scheduleboardsetting`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_schedulingfeatureflag_MailboxTrackingFolders"></a> msdyn_schedulingfeatureflag_MailboxTrackingFolders

One-To-Many Relationship: [msdyn_schedulingfeatureflag msdyn_schedulingfeatureflag_MailboxTrackingFolders](msdyn_schedulingfeatureflag.md#BKMK_msdyn_schedulingfeatureflag_MailboxTrackingFolders)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_schedulingfeatureflag`|
|ReferencedAttribute|`msdyn_schedulingfeatureflagid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_schedulingfeatureflag`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_schedulingparameter_MailboxTrackingFolders"></a> msdyn_schedulingparameter_MailboxTrackingFolders

One-To-Many Relationship: [msdyn_schedulingparameter msdyn_schedulingparameter_MailboxTrackingFolders](msdyn_schedulingparameter.md#BKMK_msdyn_schedulingparameter_MailboxTrackingFolders)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_schedulingparameter`|
|ReferencedAttribute|`msdyn_schedulingparameterid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_schedulingparameter`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_servicetasktype_MailboxTrackingFolders"></a> msdyn_servicetasktype_MailboxTrackingFolders

One-To-Many Relationship: [msdyn_servicetasktype msdyn_servicetasktype_MailboxTrackingFolders](msdyn_servicetasktype.md#BKMK_msdyn_servicetasktype_MailboxTrackingFolders)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_servicetasktype`|
|ReferencedAttribute|`msdyn_servicetasktypeid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_servicetasktype`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_sessiondata_MailboxTrackingFolders"></a> msdyn_sessiondata_MailboxTrackingFolders

One-To-Many Relationship: [msdyn_sessiondata msdyn_sessiondata_MailboxTrackingFolders](msdyn_sessiondata.md#BKMK_msdyn_sessiondata_MailboxTrackingFolders)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_sessiondata`|
|ReferencedAttribute|`msdyn_sessiondataid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_sessiondata`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_sessionparticipantdata_MailboxTrackingFolders"></a> msdyn_sessionparticipantdata_MailboxTrackingFolders

One-To-Many Relationship: [msdyn_sessionparticipantdata msdyn_sessionparticipantdata_MailboxTrackingFolders](msdyn_sessionparticipantdata.md#BKMK_msdyn_sessionparticipantdata_MailboxTrackingFolders)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_sessionparticipantdata`|
|ReferencedAttribute|`msdyn_sessionparticipantdataid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_sessionparticipantdata`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_shipvia_MailboxTrackingFolders"></a> msdyn_shipvia_MailboxTrackingFolders

One-To-Many Relationship: [msdyn_shipvia msdyn_shipvia_MailboxTrackingFolders](msdyn_shipvia.md#BKMK_msdyn_shipvia_MailboxTrackingFolders)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_shipvia`|
|ReferencedAttribute|`msdyn_shipviaid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_shipvia`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_systemuserschedulersetting_MailboxTrackingFolders"></a> msdyn_systemuserschedulersetting_MailboxTrackingFolders

One-To-Many Relationship: [msdyn_systemuserschedulersetting msdyn_systemuserschedulersetting_MailboxTrackingFolders](msdyn_systemuserschedulersetting.md#BKMK_msdyn_systemuserschedulersetting_MailboxTrackingFolders)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_systemuserschedulersetting`|
|ReferencedAttribute|`msdyn_systemuserschedulersettingid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_systemuserschedulersetting`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_taxcode_MailboxTrackingFolders"></a> msdyn_taxcode_MailboxTrackingFolders

One-To-Many Relationship: [msdyn_taxcode msdyn_taxcode_MailboxTrackingFolders](msdyn_taxcode.md#BKMK_msdyn_taxcode_MailboxTrackingFolders)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_taxcode`|
|ReferencedAttribute|`msdyn_taxcodeid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_taxcode`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_taxcodedetail_MailboxTrackingFolders"></a> msdyn_taxcodedetail_MailboxTrackingFolders

One-To-Many Relationship: [msdyn_taxcodedetail msdyn_taxcodedetail_MailboxTrackingFolders](msdyn_taxcodedetail.md#BKMK_msdyn_taxcodedetail_MailboxTrackingFolders)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_taxcodedetail`|
|ReferencedAttribute|`msdyn_taxcodedetailid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_taxcodedetail`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_timeentry_MailboxTrackingFolders"></a> msdyn_timeentry_MailboxTrackingFolders

One-To-Many Relationship: [msdyn_timeentry msdyn_timeentry_MailboxTrackingFolders](msdyn_timeentry.md#BKMK_msdyn_timeentry_MailboxTrackingFolders)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_timeentry`|
|ReferencedAttribute|`msdyn_timeentryid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_timeentry`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_timeentrysetting_MailboxTrackingFolders"></a> msdyn_timeentrysetting_MailboxTrackingFolders

One-To-Many Relationship: [msdyn_timeentrysetting msdyn_timeentrysetting_MailboxTrackingFolders](msdyn_timeentrysetting.md#BKMK_msdyn_timeentrysetting_MailboxTrackingFolders)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_timeentrysetting`|
|ReferencedAttribute|`msdyn_timeentrysettingid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_timeentrysetting`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_timegroup_MailboxTrackingFolders"></a> msdyn_timegroup_MailboxTrackingFolders

One-To-Many Relationship: [msdyn_timegroup msdyn_timegroup_MailboxTrackingFolders](msdyn_timegroup.md#BKMK_msdyn_timegroup_MailboxTrackingFolders)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_timegroup`|
|ReferencedAttribute|`msdyn_timegroupid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_timegroup`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_timegroupdetail_MailboxTrackingFolders"></a> msdyn_timegroupdetail_MailboxTrackingFolders

One-To-Many Relationship: [msdyn_timegroupdetail msdyn_timegroupdetail_MailboxTrackingFolders](msdyn_timegroupdetail.md#BKMK_msdyn_timegroupdetail_MailboxTrackingFolders)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_timegroupdetail`|
|ReferencedAttribute|`msdyn_timegroupdetailid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_timegroupdetail`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_timeoffrequest_MailboxTrackingFolders"></a> msdyn_timeoffrequest_MailboxTrackingFolders

One-To-Many Relationship: [msdyn_timeoffrequest msdyn_timeoffrequest_MailboxTrackingFolders](msdyn_timeoffrequest.md#BKMK_msdyn_timeoffrequest_MailboxTrackingFolders)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_timeoffrequest`|
|ReferencedAttribute|`msdyn_timeoffrequestid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_timeoffrequest`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_trade_MailboxTrackingFolders"></a> msdyn_trade_MailboxTrackingFolders

One-To-Many Relationship: [msdyn_trade msdyn_trade_MailboxTrackingFolders](msdyn_trade.md#BKMK_msdyn_trade_MailboxTrackingFolders)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_trade`|
|ReferencedAttribute|`msdyn_tradeid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_trade`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_tradecoverage_MailboxTrackingFolders"></a> msdyn_tradecoverage_MailboxTrackingFolders

One-To-Many Relationship: [msdyn_tradecoverage msdyn_tradecoverage_MailboxTrackingFolders](msdyn_tradecoverage.md#BKMK_msdyn_tradecoverage_MailboxTrackingFolders)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_tradecoverage`|
|ReferencedAttribute|`msdyn_tradecoverageid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_tradecoverage`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_transactionorigin_MailboxTrackingFolders"></a> msdyn_transactionorigin_MailboxTrackingFolders

One-To-Many Relationship: [msdyn_transactionorigin msdyn_transactionorigin_MailboxTrackingFolders](msdyn_transactionorigin.md#BKMK_msdyn_transactionorigin_MailboxTrackingFolders)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_transactionorigin`|
|ReferencedAttribute|`msdyn_transactionoriginid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_transactionorigin`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_uniquenumber_MailboxTrackingFolders"></a> msdyn_uniquenumber_MailboxTrackingFolders

One-To-Many Relationship: [msdyn_uniquenumber msdyn_uniquenumber_MailboxTrackingFolders](msdyn_uniquenumber.md#BKMK_msdyn_uniquenumber_MailboxTrackingFolders)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_uniquenumber`|
|ReferencedAttribute|`msdyn_uniquenumberid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_uniquenumber`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_warehouse_MailboxTrackingFolders"></a> msdyn_warehouse_MailboxTrackingFolders

One-To-Many Relationship: [msdyn_warehouse msdyn_warehouse_MailboxTrackingFolders](msdyn_warehouse.md#BKMK_msdyn_warehouse_MailboxTrackingFolders)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_warehouse`|
|ReferencedAttribute|`msdyn_warehouseid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_warehouse`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_workhourtemplate_MailboxTrackingFolders"></a> msdyn_workhourtemplate_MailboxTrackingFolders

One-To-Many Relationship: [msdyn_workhourtemplate msdyn_workhourtemplate_MailboxTrackingFolders](msdyn_workhourtemplate.md#BKMK_msdyn_workhourtemplate_MailboxTrackingFolders)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_workhourtemplate`|
|ReferencedAttribute|`msdyn_workhourtemplateid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_workhourtemplate`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_workorder_MailboxTrackingFolders"></a> msdyn_workorder_MailboxTrackingFolders

One-To-Many Relationship: [msdyn_workorder msdyn_workorder_MailboxTrackingFolders](msdyn_workorder.md#BKMK_msdyn_workorder_MailboxTrackingFolders)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_workorder`|
|ReferencedAttribute|`msdyn_workorderid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_workorder`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_workorderincident_MailboxTrackingFolders"></a> msdyn_workorderincident_MailboxTrackingFolders

One-To-Many Relationship: [msdyn_workorderincident msdyn_workorderincident_MailboxTrackingFolders](msdyn_workorderincident.md#BKMK_msdyn_workorderincident_MailboxTrackingFolders)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_workorderincident`|
|ReferencedAttribute|`msdyn_workorderincidentid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_workorderincident`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_workordernte_MailboxTrackingFolders"></a> msdyn_workordernte_MailboxTrackingFolders

One-To-Many Relationship: [msdyn_workordernte msdyn_workordernte_MailboxTrackingFolders](msdyn_workordernte.md#BKMK_msdyn_workordernte_MailboxTrackingFolders)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_workordernte`|
|ReferencedAttribute|`msdyn_workordernteid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_workordernte`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_workorderproduct_MailboxTrackingFolders"></a> msdyn_workorderproduct_MailboxTrackingFolders

One-To-Many Relationship: [msdyn_workorderproduct msdyn_workorderproduct_MailboxTrackingFolders](msdyn_workorderproduct.md#BKMK_msdyn_workorderproduct_MailboxTrackingFolders)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_workorderproduct`|
|ReferencedAttribute|`msdyn_workorderproductid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_workorderproduct`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_workorderresolution_MailboxTrackingFolders"></a> msdyn_workorderresolution_MailboxTrackingFolders

One-To-Many Relationship: [msdyn_workorderresolution msdyn_workorderresolution_MailboxTrackingFolders](msdyn_workorderresolution.md#BKMK_msdyn_workorderresolution_MailboxTrackingFolders)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_workorderresolution`|
|ReferencedAttribute|`msdyn_workorderresolutionid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_workorderresolution`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_workorderresourcerestriction_MailboxTrackingFolders"></a> msdyn_workorderresourcerestriction_MailboxTrackingFolders

One-To-Many Relationship: [msdyn_workorderresourcerestriction msdyn_workorderresourcerestriction_MailboxTrackingFolders](msdyn_workorderresourcerestriction.md#BKMK_msdyn_workorderresourcerestriction_MailboxTrackingFolders)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_workorderresourcerestriction`|
|ReferencedAttribute|`msdyn_workorderresourcerestrictionid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_workorderresourcerestriction`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_workorderservice_MailboxTrackingFolders"></a> msdyn_workorderservice_MailboxTrackingFolders

One-To-Many Relationship: [msdyn_workorderservice msdyn_workorderservice_MailboxTrackingFolders](msdyn_workorderservice.md#BKMK_msdyn_workorderservice_MailboxTrackingFolders)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_workorderservice`|
|ReferencedAttribute|`msdyn_workorderserviceid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_workorderservice`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_workorderservicetask_MailboxTrackingFolders"></a> msdyn_workorderservicetask_MailboxTrackingFolders

One-To-Many Relationship: [msdyn_workorderservicetask msdyn_workorderservicetask_MailboxTrackingFolders](msdyn_workorderservicetask.md#BKMK_msdyn_workorderservicetask_MailboxTrackingFolders)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_workorderservicetask`|
|ReferencedAttribute|`msdyn_workorderservicetaskid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_workorderservicetask`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_workordersubstatus_MailboxTrackingFolders"></a> msdyn_workordersubstatus_MailboxTrackingFolders

One-To-Many Relationship: [msdyn_workordersubstatus msdyn_workordersubstatus_MailboxTrackingFolders](msdyn_workordersubstatus.md#BKMK_msdyn_workordersubstatus_MailboxTrackingFolders)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_workordersubstatus`|
|ReferencedAttribute|`msdyn_workordersubstatusid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_workordersubstatus`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_workordertype_MailboxTrackingFolders"></a> msdyn_workordertype_MailboxTrackingFolders

One-To-Many Relationship: [msdyn_workordertype msdyn_workordertype_MailboxTrackingFolders](msdyn_workordertype.md#BKMK_msdyn_workordertype_MailboxTrackingFolders)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_workordertype`|
|ReferencedAttribute|`msdyn_workordertypeid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_workordertype`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|



### See also

[Dataverse table/entity reference](../about-entity-reference.md)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   
<xref:Microsoft.Dynamics.CRM.mailboxtrackingfolder?displayProperty=fullName>
