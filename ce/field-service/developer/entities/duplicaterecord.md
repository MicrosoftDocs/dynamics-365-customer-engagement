---
title: "Duplicate Record (DuplicateRecord) table/entity reference (Microsoft Dynamics 365 Field Service)"
description: "Includes schema information and supported messages for the Duplicate Record (DuplicateRecord) table/entity with Microsoft Dynamics 365 Field Service."
ms.date: 08/26/2024
ms.service: powerapps
ms.topic: reference
author: m-hartmann
ms.author: mhart
search.audienceType: 
  - developer
---

# Duplicate Record (DuplicateRecord) table/entity reference (Microsoft Dynamics 365 Field Service)

Potential duplicate record.

> [!NOTE]
> The Microsoft Dynamics 365 Field Service Duplicate Record (DuplicateRecord) table extends the [Microsoft Dynamics 365 Duplicate Record (DuplicateRecord) table](/dynamics365/developer/entities/duplicaterecord).



## Customized columns/attributes

Microsoft Dynamics 365 Field Service modifies the definition of columns/attributes defined in other solutions. Listed by **SchemaName**.

- [BaseRecordId](#BKMK_BaseRecordId)
- [DuplicateRecordId](#BKMK_DuplicateRecordId)

### <a name="BKMK_BaseRecordId"></a> BaseRecordId

Changes from [BaseRecordId (Microsoft Dataverse)](/power-apps/developer/data-platform/reference/entities/duplicaterecord#BKMK_BaseRecordId)

|Property|Value|
|---|---|
|Targets|msdyn_actual|


### <a name="BKMK_DuplicateRecordId"></a> DuplicateRecordId

Changes from [DuplicateRecordId (Microsoft Dataverse)](/power-apps/developer/data-platform/reference/entities/duplicaterecord#BKMK_DuplicateRecordId)

|Property|Value|
|---|---|
|Targets|msdyn_actual|


## Many-to-One relationships

These relationships are many-to-one. Listed by **SchemaName**.

- [msdyn_actual_DuplicateBaseRecord](#BKMK_msdyn_actual_DuplicateBaseRecord)
- [msdyn_actual_DuplicateMatchingRecord](#BKMK_msdyn_actual_DuplicateMatchingRecord)
- [msdyn_agreement_DuplicateBaseRecord](#BKMK_msdyn_agreement_DuplicateBaseRecord)
- [msdyn_agreement_DuplicateMatchingRecord](#BKMK_msdyn_agreement_DuplicateMatchingRecord)
- [msdyn_agreementbookingdate_DuplicateBaseRecord](#BKMK_msdyn_agreementbookingdate_DuplicateBaseRecord)
- [msdyn_agreementbookingdate_DuplicateMatchingRecord](#BKMK_msdyn_agreementbookingdate_DuplicateMatchingRecord)
- [msdyn_agreementbookingincident_DuplicateBaseRecord](#BKMK_msdyn_agreementbookingincident_DuplicateBaseRecord)
- [msdyn_agreementbookingincident_DuplicateMatchingRecord](#BKMK_msdyn_agreementbookingincident_DuplicateMatchingRecord)
- [msdyn_agreementbookingproduct_DuplicateBaseRecord](#BKMK_msdyn_agreementbookingproduct_DuplicateBaseRecord)
- [msdyn_agreementbookingproduct_DuplicateMatchingRecord](#BKMK_msdyn_agreementbookingproduct_DuplicateMatchingRecord)
- [msdyn_agreementbookingservice_DuplicateBaseRecord](#BKMK_msdyn_agreementbookingservice_DuplicateBaseRecord)
- [msdyn_agreementbookingservice_DuplicateMatchingRecord](#BKMK_msdyn_agreementbookingservice_DuplicateMatchingRecord)
- [msdyn_agreementbookingservicetask_DuplicateBaseRecord](#BKMK_msdyn_agreementbookingservicetask_DuplicateBaseRecord)
- [msdyn_agreementbookingservicetask_DuplicateMatchingRecord](#BKMK_msdyn_agreementbookingservicetask_DuplicateMatchingRecord)
- [msdyn_agreementbookingsetup_DuplicateBaseRecord](#BKMK_msdyn_agreementbookingsetup_DuplicateBaseRecord)
- [msdyn_agreementbookingsetup_DuplicateMatchingRecord](#BKMK_msdyn_agreementbookingsetup_DuplicateMatchingRecord)
- [msdyn_agreementinvoicedate_DuplicateBaseRecord](#BKMK_msdyn_agreementinvoicedate_DuplicateBaseRecord)
- [msdyn_agreementinvoicedate_DuplicateMatchingRecord](#BKMK_msdyn_agreementinvoicedate_DuplicateMatchingRecord)
- [msdyn_agreementinvoiceproduct_DuplicateBaseRecord](#BKMK_msdyn_agreementinvoiceproduct_DuplicateBaseRecord)
- [msdyn_agreementinvoiceproduct_DuplicateMatchingRecord](#BKMK_msdyn_agreementinvoiceproduct_DuplicateMatchingRecord)
- [msdyn_agreementinvoicesetup_DuplicateBaseRecord](#BKMK_msdyn_agreementinvoicesetup_DuplicateBaseRecord)
- [msdyn_agreementinvoicesetup_DuplicateMatchingRecord](#BKMK_msdyn_agreementinvoicesetup_DuplicateMatchingRecord)
- [msdyn_agreementsubstatus_DuplicateBaseRecord](#BKMK_msdyn_agreementsubstatus_DuplicateBaseRecord)
- [msdyn_agreementsubstatus_DuplicateMatchingRecord](#BKMK_msdyn_agreementsubstatus_DuplicateMatchingRecord)
- [msdyn_bookableresourceassociation_DuplicateBaseRecord](#BKMK_msdyn_bookableresourceassociation_DuplicateBaseRecord)
- [msdyn_bookableresourceassociation_DuplicateMatchingRecord](#BKMK_msdyn_bookableresourceassociation_DuplicateMatchingRecord)
- [msdyn_bookableresourcebookingquicknote_DuplicateBaseRecord](#BKMK_msdyn_bookableresourcebookingquicknote_DuplicateBaseRecord)
- [msdyn_bookableresourcebookingquicknote_DuplicateMatchingRecord](#BKMK_msdyn_bookableresourcebookingquicknote_DuplicateMatchingRecord)
- [msdyn_bookingalert_DuplicateBaseRecord](#BKMK_msdyn_bookingalert_DuplicateBaseRecord)
- [msdyn_bookingalert_DuplicateMatchingRecord](#BKMK_msdyn_bookingalert_DuplicateMatchingRecord)
- [msdyn_bookingalertstatus_DuplicateBaseRecord](#BKMK_msdyn_bookingalertstatus_DuplicateBaseRecord)
- [msdyn_bookingalertstatus_DuplicateMatchingRecord](#BKMK_msdyn_bookingalertstatus_DuplicateMatchingRecord)
- [msdyn_bookingrule_DuplicateBaseRecord](#BKMK_msdyn_bookingrule_DuplicateBaseRecord)
- [msdyn_bookingrule_DuplicateMatchingRecord](#BKMK_msdyn_bookingrule_DuplicateMatchingRecord)
- [msdyn_bookingtimestamp_DuplicateBaseRecord](#BKMK_msdyn_bookingtimestamp_DuplicateBaseRecord)
- [msdyn_bookingtimestamp_DuplicateMatchingRecord](#BKMK_msdyn_bookingtimestamp_DuplicateMatchingRecord)
- [msdyn_clientextension_DuplicateBaseRecord](#BKMK_msdyn_clientextension_DuplicateBaseRecord)
- [msdyn_clientextension_DuplicateMatchingRecord](#BKMK_msdyn_clientextension_DuplicateMatchingRecord)
- [msdyn_consoleapplicationsessiontemplate_DuplicateBaseRecord](#BKMK_msdyn_consoleapplicationsessiontemplate_DuplicateBaseRecord)
- [msdyn_consoleapplicationsessiontemplate_DuplicateMatchingRecord](#BKMK_msdyn_consoleapplicationsessiontemplate_DuplicateMatchingRecord)
- [msdyn_dataanalyticsreport_fs_DuplicateBaseRecord](#BKMK_msdyn_dataanalyticsreport_fs_DuplicateBaseRecord)
- [msdyn_dataanalyticsreport_fs_DuplicateMatchingRecord](#BKMK_msdyn_dataanalyticsreport_fs_DuplicateMatchingRecord)
- [msdyn_dataanalyticsreport_fspredictrs_DuplicateBaseRecord](#BKMK_msdyn_dataanalyticsreport_fspredictrs_DuplicateBaseRecord)
- [msdyn_dataanalyticsreport_fspredictrs_DuplicateMatchingRecord](#BKMK_msdyn_dataanalyticsreport_fspredictrs_DuplicateMatchingRecord)
- [msdyn_dataanalyticsreport_fspredictwhd_DuplicateBaseRecord](#BKMK_msdyn_dataanalyticsreport_fspredictwhd_DuplicateBaseRecord)
- [msdyn_dataanalyticsreport_fspredictwhd_DuplicateMatchingRecord](#BKMK_msdyn_dataanalyticsreport_fspredictwhd_DuplicateMatchingRecord)
- [msdyn_entitlementapplication_DuplicateBaseRecord](#BKMK_msdyn_entitlementapplication_DuplicateBaseRecord)
- [msdyn_entitlementapplication_DuplicateMatchingRecord](#BKMK_msdyn_entitlementapplication_DuplicateMatchingRecord)
- [msdyn_entityconfiguration_DuplicateBaseRecord](#BKMK_msdyn_entityconfiguration_DuplicateBaseRecord)
- [msdyn_entityconfiguration_DuplicateMatchingRecord](#BKMK_msdyn_entityconfiguration_DuplicateMatchingRecord)
- [msdyn_fieldservicepricelistitem_DuplicateBaseRecord](#BKMK_msdyn_fieldservicepricelistitem_DuplicateBaseRecord)
- [msdyn_fieldservicepricelistitem_DuplicateMatchingRecord](#BKMK_msdyn_fieldservicepricelistitem_DuplicateMatchingRecord)
- [msdyn_flwconfiguration_DuplicateBaseRecord](#BKMK_msdyn_flwconfiguration_DuplicateBaseRecord)
- [msdyn_flwconfiguration_DuplicateMatchingRecord](#BKMK_msdyn_flwconfiguration_DuplicateMatchingRecord)
- [msdyn_geofence_DuplicateBaseRecord](#BKMK_msdyn_geofence_DuplicateBaseRecord)
- [msdyn_geofence_DuplicateMatchingRecord](#BKMK_msdyn_geofence_DuplicateMatchingRecord)
- [msdyn_geofenceevent_DuplicateBaseRecord](#BKMK_msdyn_geofenceevent_DuplicateBaseRecord)
- [msdyn_geofenceevent_DuplicateMatchingRecord](#BKMK_msdyn_geofenceevent_DuplicateMatchingRecord)
- [msdyn_geofencingsettings_DuplicateBaseRecord](#BKMK_msdyn_geofencingsettings_DuplicateBaseRecord)
- [msdyn_geofencingsettings_DuplicateMatchingRecord](#BKMK_msdyn_geofencingsettings_DuplicateMatchingRecord)
- [msdyn_geolocationsettings_DuplicateBaseRecord](#BKMK_msdyn_geolocationsettings_DuplicateBaseRecord)
- [msdyn_geolocationsettings_DuplicateMatchingRecord](#BKMK_msdyn_geolocationsettings_DuplicateMatchingRecord)
- [msdyn_geolocationtracking_DuplicateBaseRecord](#BKMK_msdyn_geolocationtracking_DuplicateBaseRecord)
- [msdyn_geolocationtracking_DuplicateMatchingRecord](#BKMK_msdyn_geolocationtracking_DuplicateMatchingRecord)
- [msdyn_incidenttype_DuplicateBaseRecord](#BKMK_msdyn_incidenttype_DuplicateBaseRecord)
- [msdyn_incidenttype_DuplicateMatchingRecord](#BKMK_msdyn_incidenttype_DuplicateMatchingRecord)
- [msdyn_incidenttype_requirementgroup_DuplicateBaseRecord](#BKMK_msdyn_incidenttype_requirementgroup_DuplicateBaseRecord)
- [msdyn_incidenttype_requirementgroup_DuplicateMatchingRecord](#BKMK_msdyn_incidenttype_requirementgroup_DuplicateMatchingRecord)
- [msdyn_incidenttypecharacteristic_DuplicateBaseRecord](#BKMK_msdyn_incidenttypecharacteristic_DuplicateBaseRecord)
- [msdyn_incidenttypecharacteristic_DuplicateMatchingRecord](#BKMK_msdyn_incidenttypecharacteristic_DuplicateMatchingRecord)
- [msdyn_incidenttypeproduct_DuplicateBaseRecord](#BKMK_msdyn_incidenttypeproduct_DuplicateBaseRecord)
- [msdyn_incidenttypeproduct_DuplicateMatchingRecord](#BKMK_msdyn_incidenttypeproduct_DuplicateMatchingRecord)
- [msdyn_incidenttyperecommendationresult_DuplicateBaseRecord](#BKMK_msdyn_incidenttyperecommendationresult_DuplicateBaseRecord)
- [msdyn_incidenttyperecommendationresult_DuplicateMatchingRecord](#BKMK_msdyn_incidenttyperecommendationresult_DuplicateMatchingRecord)
- [msdyn_incidenttyperecommendationrunhistory_DuplicateBaseRecord](#BKMK_msdyn_incidenttyperecommendationrunhistory_DuplicateBaseRecord)
- [msdyn_incidenttyperecommendationrunhistory_DuplicateMatchingRecord](#BKMK_msdyn_incidenttyperecommendationrunhistory_DuplicateMatchingRecord)
- [msdyn_incidenttyperesolution_DuplicateBaseRecord](#BKMK_msdyn_incidenttyperesolution_DuplicateBaseRecord)
- [msdyn_incidenttyperesolution_DuplicateMatchingRecord](#BKMK_msdyn_incidenttyperesolution_DuplicateMatchingRecord)
- [msdyn_incidenttypeservice_DuplicateBaseRecord](#BKMK_msdyn_incidenttypeservice_DuplicateBaseRecord)
- [msdyn_incidenttypeservice_DuplicateMatchingRecord](#BKMK_msdyn_incidenttypeservice_DuplicateMatchingRecord)
- [msdyn_incidenttypeservicetask_DuplicateBaseRecord](#BKMK_msdyn_incidenttypeservicetask_DuplicateBaseRecord)
- [msdyn_incidenttypeservicetask_DuplicateMatchingRecord](#BKMK_msdyn_incidenttypeservicetask_DuplicateMatchingRecord)
- [msdyn_incidenttypessetup_DuplicateBaseRecord](#BKMK_msdyn_incidenttypessetup_DuplicateBaseRecord)
- [msdyn_incidenttypessetup_DuplicateMatchingRecord](#BKMK_msdyn_incidenttypessetup_DuplicateMatchingRecord)
- [msdyn_inspection_DuplicateBaseRecord](#BKMK_msdyn_inspection_DuplicateBaseRecord)
- [msdyn_inspection_DuplicateMatchingRecord](#BKMK_msdyn_inspection_DuplicateMatchingRecord)
- [msdyn_inspectionattachment_DuplicateBaseRecord](#BKMK_msdyn_inspectionattachment_DuplicateBaseRecord)
- [msdyn_inspectionattachment_DuplicateMatchingRecord](#BKMK_msdyn_inspectionattachment_DuplicateMatchingRecord)
- [msdyn_inspectiondefinition_DuplicateBaseRecord](#BKMK_msdyn_inspectiondefinition_DuplicateBaseRecord)
- [msdyn_inspectiondefinition_DuplicateMatchingRecord](#BKMK_msdyn_inspectiondefinition_DuplicateMatchingRecord)
- [msdyn_inspectioninstance_DuplicateBaseRecord](#BKMK_msdyn_inspectioninstance_DuplicateBaseRecord)
- [msdyn_inspectioninstance_DuplicateMatchingRecord](#BKMK_msdyn_inspectioninstance_DuplicateMatchingRecord)
- [msdyn_inspectionresponse_DuplicateBaseRecord](#BKMK_msdyn_inspectionresponse_DuplicateBaseRecord)
- [msdyn_inspectionresponse_DuplicateMatchingRecord](#BKMK_msdyn_inspectionresponse_DuplicateMatchingRecord)
- [msdyn_insurance_DuplicateBaseRecord](#BKMK_msdyn_insurance_DuplicateBaseRecord)
- [msdyn_insurance_DuplicateMatchingRecord](#BKMK_msdyn_insurance_DuplicateMatchingRecord)
- [msdyn_inventoryadjustment_DuplicateBaseRecord](#BKMK_msdyn_inventoryadjustment_DuplicateBaseRecord)
- [msdyn_inventoryadjustment_DuplicateMatchingRecord](#BKMK_msdyn_inventoryadjustment_DuplicateMatchingRecord)
- [msdyn_inventoryadjustmentproduct_DuplicateBaseRecord](#BKMK_msdyn_inventoryadjustmentproduct_DuplicateBaseRecord)
- [msdyn_inventoryadjustmentproduct_DuplicateMatchingRecord](#BKMK_msdyn_inventoryadjustmentproduct_DuplicateMatchingRecord)
- [msdyn_inventoryjournal_DuplicateBaseRecord](#BKMK_msdyn_inventoryjournal_DuplicateBaseRecord)
- [msdyn_inventoryjournal_DuplicateMatchingRecord](#BKMK_msdyn_inventoryjournal_DuplicateMatchingRecord)
- [msdyn_inventorytransfer_DuplicateBaseRecord](#BKMK_msdyn_inventorytransfer_DuplicateBaseRecord)
- [msdyn_inventorytransfer_DuplicateMatchingRecord](#BKMK_msdyn_inventorytransfer_DuplicateMatchingRecord)
- [msdyn_mobilesource_DuplicateBaseRecord](#BKMK_msdyn_mobilesource_DuplicateBaseRecord)
- [msdyn_mobilesource_DuplicateMatchingRecord](#BKMK_msdyn_mobilesource_DuplicateMatchingRecord)
- [msdyn_nottoexceed_DuplicateBaseRecord](#BKMK_msdyn_nottoexceed_DuplicateBaseRecord)
- [msdyn_nottoexceed_DuplicateMatchingRecord](#BKMK_msdyn_nottoexceed_DuplicateMatchingRecord)
- [msdyn_orderinvoicingdate_DuplicateBaseRecord](#BKMK_msdyn_orderinvoicingdate_DuplicateBaseRecord)
- [msdyn_orderinvoicingdate_DuplicateMatchingRecord](#BKMK_msdyn_orderinvoicingdate_DuplicateMatchingRecord)
- [msdyn_orderinvoicingproduct_DuplicateBaseRecord](#BKMK_msdyn_orderinvoicingproduct_DuplicateBaseRecord)
- [msdyn_orderinvoicingproduct_DuplicateMatchingRecord](#BKMK_msdyn_orderinvoicingproduct_DuplicateMatchingRecord)
- [msdyn_orderinvoicingsetup_DuplicateBaseRecord](#BKMK_msdyn_orderinvoicingsetup_DuplicateBaseRecord)
- [msdyn_orderinvoicingsetup_DuplicateMatchingRecord](#BKMK_msdyn_orderinvoicingsetup_DuplicateMatchingRecord)
- [msdyn_orderinvoicingsetupdate_DuplicateBaseRecord](#BKMK_msdyn_orderinvoicingsetupdate_DuplicateBaseRecord)
- [msdyn_orderinvoicingsetupdate_DuplicateMatchingRecord](#BKMK_msdyn_orderinvoicingsetupdate_DuplicateMatchingRecord)
- [msdyn_organizationalunit_DuplicateBaseRecord](#BKMK_msdyn_organizationalunit_DuplicateBaseRecord)
- [msdyn_organizationalunit_DuplicateMatchingRecord](#BKMK_msdyn_organizationalunit_DuplicateMatchingRecord)
- [msdyn_payment_DuplicateBaseRecord](#BKMK_msdyn_payment_DuplicateBaseRecord)
- [msdyn_payment_DuplicateMatchingRecord](#BKMK_msdyn_payment_DuplicateMatchingRecord)
- [msdyn_paymentdetail_DuplicateBaseRecord](#BKMK_msdyn_paymentdetail_DuplicateBaseRecord)
- [msdyn_paymentdetail_DuplicateMatchingRecord](#BKMK_msdyn_paymentdetail_DuplicateMatchingRecord)
- [msdyn_paymentmethod_DuplicateBaseRecord](#BKMK_msdyn_paymentmethod_DuplicateBaseRecord)
- [msdyn_paymentmethod_DuplicateMatchingRecord](#BKMK_msdyn_paymentmethod_DuplicateMatchingRecord)
- [msdyn_paymentterm_DuplicateBaseRecord](#BKMK_msdyn_paymentterm_DuplicateBaseRecord)
- [msdyn_paymentterm_DuplicateMatchingRecord](#BKMK_msdyn_paymentterm_DuplicateMatchingRecord)
- [msdyn_postalcode_DuplicateBaseRecord](#BKMK_msdyn_postalcode_DuplicateBaseRecord)
- [msdyn_postalcode_DuplicateMatchingRecord](#BKMK_msdyn_postalcode_DuplicateMatchingRecord)
- [msdyn_priority_DuplicateBaseRecord](#BKMK_msdyn_priority_DuplicateBaseRecord)
- [msdyn_priority_DuplicateMatchingRecord](#BKMK_msdyn_priority_DuplicateMatchingRecord)
- [msdyn_problematicasset_DuplicateBaseRecord](#BKMK_msdyn_problematicasset_DuplicateBaseRecord)
- [msdyn_problematicasset_DuplicateMatchingRecord](#BKMK_msdyn_problematicasset_DuplicateMatchingRecord)
- [msdyn_problematicassetfeedback_DuplicateBaseRecord](#BKMK_msdyn_problematicassetfeedback_DuplicateBaseRecord)
- [msdyn_problematicassetfeedback_DuplicateMatchingRecord](#BKMK_msdyn_problematicassetfeedback_DuplicateMatchingRecord)
- [msdyn_productinventory_DuplicateBaseRecord](#BKMK_msdyn_productinventory_DuplicateBaseRecord)
- [msdyn_productinventory_DuplicateMatchingRecord](#BKMK_msdyn_productinventory_DuplicateMatchingRecord)
- [msdyn_purchaseorder_DuplicateBaseRecord](#BKMK_msdyn_purchaseorder_DuplicateBaseRecord)
- [msdyn_purchaseorder_DuplicateMatchingRecord](#BKMK_msdyn_purchaseorder_DuplicateMatchingRecord)
- [msdyn_purchaseorderbill_DuplicateBaseRecord](#BKMK_msdyn_purchaseorderbill_DuplicateBaseRecord)
- [msdyn_purchaseorderbill_DuplicateMatchingRecord](#BKMK_msdyn_purchaseorderbill_DuplicateMatchingRecord)
- [msdyn_purchaseorderreceipt_DuplicateBaseRecord](#BKMK_msdyn_purchaseorderreceipt_DuplicateBaseRecord)
- [msdyn_purchaseorderreceipt_DuplicateMatchingRecord](#BKMK_msdyn_purchaseorderreceipt_DuplicateMatchingRecord)
- [msdyn_purchaseorderreceiptproduct_DuplicateBaseRecord](#BKMK_msdyn_purchaseorderreceiptproduct_DuplicateBaseRecord)
- [msdyn_purchaseorderreceiptproduct_DuplicateMatchingRecord](#BKMK_msdyn_purchaseorderreceiptproduct_DuplicateMatchingRecord)
- [msdyn_purchaseordersubstatus_DuplicateBaseRecord](#BKMK_msdyn_purchaseordersubstatus_DuplicateBaseRecord)
- [msdyn_purchaseordersubstatus_DuplicateMatchingRecord](#BKMK_msdyn_purchaseordersubstatus_DuplicateMatchingRecord)
- [msdyn_quotebookingincident_DuplicateBaseRecord](#BKMK_msdyn_quotebookingincident_DuplicateBaseRecord)
- [msdyn_quotebookingincident_DuplicateMatchingRecord](#BKMK_msdyn_quotebookingincident_DuplicateMatchingRecord)
- [msdyn_quotebookingproduct_DuplicateBaseRecord](#BKMK_msdyn_quotebookingproduct_DuplicateBaseRecord)
- [msdyn_quotebookingproduct_DuplicateMatchingRecord](#BKMK_msdyn_quotebookingproduct_DuplicateMatchingRecord)
- [msdyn_quotebookingservice_DuplicateBaseRecord](#BKMK_msdyn_quotebookingservice_DuplicateBaseRecord)
- [msdyn_quotebookingservice_DuplicateMatchingRecord](#BKMK_msdyn_quotebookingservice_DuplicateMatchingRecord)
- [msdyn_quotebookingservicetask_DuplicateBaseRecord](#BKMK_msdyn_quotebookingservicetask_DuplicateBaseRecord)
- [msdyn_quotebookingservicetask_DuplicateMatchingRecord](#BKMK_msdyn_quotebookingservicetask_DuplicateMatchingRecord)
- [msdyn_quotebookingsetup_DuplicateBaseRecord](#BKMK_msdyn_quotebookingsetup_DuplicateBaseRecord)
- [msdyn_quotebookingsetup_DuplicateMatchingRecord](#BKMK_msdyn_quotebookingsetup_DuplicateMatchingRecord)
- [msdyn_quoteinvoicingproduct_DuplicateBaseRecord](#BKMK_msdyn_quoteinvoicingproduct_DuplicateBaseRecord)
- [msdyn_quoteinvoicingproduct_DuplicateMatchingRecord](#BKMK_msdyn_quoteinvoicingproduct_DuplicateMatchingRecord)
- [msdyn_quoteinvoicingsetup_DuplicateBaseRecord](#BKMK_msdyn_quoteinvoicingsetup_DuplicateBaseRecord)
- [msdyn_quoteinvoicingsetup_DuplicateMatchingRecord](#BKMK_msdyn_quoteinvoicingsetup_DuplicateMatchingRecord)
- [msdyn_requirementcharacteristic_DuplicateBaseRecord](#BKMK_msdyn_requirementcharacteristic_DuplicateBaseRecord)
- [msdyn_requirementcharacteristic_DuplicateMatchingRecord](#BKMK_msdyn_requirementcharacteristic_DuplicateMatchingRecord)
- [msdyn_requirementdependency_DuplicateBaseRecord](#BKMK_msdyn_requirementdependency_DuplicateBaseRecord)
- [msdyn_requirementdependency_DuplicateMatchingRecord](#BKMK_msdyn_requirementdependency_DuplicateMatchingRecord)
- [msdyn_requirementgroup_DuplicateBaseRecord](#BKMK_msdyn_requirementgroup_DuplicateBaseRecord)
- [msdyn_requirementgroup_DuplicateMatchingRecord](#BKMK_msdyn_requirementgroup_DuplicateMatchingRecord)
- [msdyn_requirementorganizationunit_DuplicateBaseRecord](#BKMK_msdyn_requirementorganizationunit_DuplicateBaseRecord)
- [msdyn_requirementorganizationunit_DuplicateMatchingRecord](#BKMK_msdyn_requirementorganizationunit_DuplicateMatchingRecord)
- [msdyn_requirementrelationship_DuplicateBaseRecord](#BKMK_msdyn_requirementrelationship_DuplicateBaseRecord)
- [msdyn_requirementrelationship_DuplicateMatchingRecord](#BKMK_msdyn_requirementrelationship_DuplicateMatchingRecord)
- [msdyn_requirementresourcecategory_DuplicateBaseRecord](#BKMK_msdyn_requirementresourcecategory_DuplicateBaseRecord)
- [msdyn_requirementresourcecategory_DuplicateMatchingRecord](#BKMK_msdyn_requirementresourcecategory_DuplicateMatchingRecord)
- [msdyn_requirementresourcepreference_DuplicateBaseRecord](#BKMK_msdyn_requirementresourcepreference_DuplicateBaseRecord)
- [msdyn_requirementresourcepreference_DuplicateMatchingRecord](#BKMK_msdyn_requirementresourcepreference_DuplicateMatchingRecord)
- [msdyn_requirementstatus_DuplicateBaseRecord](#BKMK_msdyn_requirementstatus_DuplicateBaseRecord)
- [msdyn_requirementstatus_DuplicateMatchingRecord](#BKMK_msdyn_requirementstatus_DuplicateMatchingRecord)
- [msdyn_resolution_DuplicateBaseRecord](#BKMK_msdyn_resolution_DuplicateBaseRecord)
- [msdyn_resolution_DuplicateMatchingRecord](#BKMK_msdyn_resolution_DuplicateMatchingRecord)
- [msdyn_resourcerequirement_DuplicateBaseRecord](#BKMK_msdyn_resourcerequirement_DuplicateBaseRecord)
- [msdyn_resourcerequirement_DuplicateMatchingRecord](#BKMK_msdyn_resourcerequirement_DuplicateMatchingRecord)
- [msdyn_resourcerequirementdetail_DuplicateBaseRecord](#BKMK_msdyn_resourcerequirementdetail_DuplicateBaseRecord)
- [msdyn_resourcerequirementdetail_DuplicateMatchingRecord](#BKMK_msdyn_resourcerequirementdetail_DuplicateMatchingRecord)
- [msdyn_resourceterritory_DuplicateBaseRecord](#BKMK_msdyn_resourceterritory_DuplicateBaseRecord)
- [msdyn_resourceterritory_DuplicateMatchingRecord](#BKMK_msdyn_resourceterritory_DuplicateMatchingRecord)
- [msdyn_rma_DuplicateBaseRecord](#BKMK_msdyn_rma_DuplicateBaseRecord)
- [msdyn_rma_DuplicateMatchingRecord](#BKMK_msdyn_rma_DuplicateMatchingRecord)
- [msdyn_rmareceipt_DuplicateBaseRecord](#BKMK_msdyn_rmareceipt_DuplicateBaseRecord)
- [msdyn_rmareceipt_DuplicateMatchingRecord](#BKMK_msdyn_rmareceipt_DuplicateMatchingRecord)
- [msdyn_rmareceiptproduct_DuplicateBaseRecord](#BKMK_msdyn_rmareceiptproduct_DuplicateBaseRecord)
- [msdyn_rmareceiptproduct_DuplicateMatchingRecord](#BKMK_msdyn_rmareceiptproduct_DuplicateMatchingRecord)
- [msdyn_rmasubstatus_DuplicateBaseRecord](#BKMK_msdyn_rmasubstatus_DuplicateBaseRecord)
- [msdyn_rmasubstatus_DuplicateMatchingRecord](#BKMK_msdyn_rmasubstatus_DuplicateMatchingRecord)
- [msdyn_rtv_DuplicateBaseRecord](#BKMK_msdyn_rtv_DuplicateBaseRecord)
- [msdyn_rtv_DuplicateMatchingRecord](#BKMK_msdyn_rtv_DuplicateMatchingRecord)
- [msdyn_rtvproduct_DuplicateBaseRecord](#BKMK_msdyn_rtvproduct_DuplicateBaseRecord)
- [msdyn_rtvproduct_DuplicateMatchingRecord](#BKMK_msdyn_rtvproduct_DuplicateMatchingRecord)
- [msdyn_rtvsubstatus_DuplicateBaseRecord](#BKMK_msdyn_rtvsubstatus_DuplicateBaseRecord)
- [msdyn_rtvsubstatus_DuplicateMatchingRecord](#BKMK_msdyn_rtvsubstatus_DuplicateMatchingRecord)
- [msdyn_scheduleboardsetting_DuplicateBaseRecord](#BKMK_msdyn_scheduleboardsetting_DuplicateBaseRecord)
- [msdyn_scheduleboardsetting_DuplicateMatchingRecord](#BKMK_msdyn_scheduleboardsetting_DuplicateMatchingRecord)
- [msdyn_schedulingfeatureflag_DuplicateBaseRecord](#BKMK_msdyn_schedulingfeatureflag_DuplicateBaseRecord)
- [msdyn_schedulingfeatureflag_DuplicateMatchingRecord](#BKMK_msdyn_schedulingfeatureflag_DuplicateMatchingRecord)
- [msdyn_servicetasktype_DuplicateBaseRecord](#BKMK_msdyn_servicetasktype_DuplicateBaseRecord)
- [msdyn_servicetasktype_DuplicateMatchingRecord](#BKMK_msdyn_servicetasktype_DuplicateMatchingRecord)
- [msdyn_sessiondata_DuplicateBaseRecord](#BKMK_msdyn_sessiondata_DuplicateBaseRecord)
- [msdyn_sessiondata_DuplicateMatchingRecord](#BKMK_msdyn_sessiondata_DuplicateMatchingRecord)
- [msdyn_sessionparticipantdata_DuplicateBaseRecord](#BKMK_msdyn_sessionparticipantdata_DuplicateBaseRecord)
- [msdyn_sessionparticipantdata_DuplicateMatchingRecord](#BKMK_msdyn_sessionparticipantdata_DuplicateMatchingRecord)
- [msdyn_shipvia_DuplicateBaseRecord](#BKMK_msdyn_shipvia_DuplicateBaseRecord)
- [msdyn_shipvia_DuplicateMatchingRecord](#BKMK_msdyn_shipvia_DuplicateMatchingRecord)
- [msdyn_systemuserschedulersetting_DuplicateBaseRecord](#BKMK_msdyn_systemuserschedulersetting_DuplicateBaseRecord)
- [msdyn_systemuserschedulersetting_DuplicateMatchingRecord](#BKMK_msdyn_systemuserschedulersetting_DuplicateMatchingRecord)
- [msdyn_taxcode_DuplicateBaseRecord](#BKMK_msdyn_taxcode_DuplicateBaseRecord)
- [msdyn_taxcode_DuplicateMatchingRecord](#BKMK_msdyn_taxcode_DuplicateMatchingRecord)
- [msdyn_taxcodedetail_DuplicateBaseRecord](#BKMK_msdyn_taxcodedetail_DuplicateBaseRecord)
- [msdyn_taxcodedetail_DuplicateMatchingRecord](#BKMK_msdyn_taxcodedetail_DuplicateMatchingRecord)
- [msdyn_timeentrysetting_DuplicateBaseRecord](#BKMK_msdyn_timeentrysetting_DuplicateBaseRecord)
- [msdyn_timeentrysetting_DuplicateMatchingRecord](#BKMK_msdyn_timeentrysetting_DuplicateMatchingRecord)
- [msdyn_timegroup_DuplicateBaseRecord](#BKMK_msdyn_timegroup_DuplicateBaseRecord)
- [msdyn_timegroup_DuplicateMatchingRecord](#BKMK_msdyn_timegroup_DuplicateMatchingRecord)
- [msdyn_timegroupdetail_DuplicateBaseRecord](#BKMK_msdyn_timegroupdetail_DuplicateBaseRecord)
- [msdyn_timegroupdetail_DuplicateMatchingRecord](#BKMK_msdyn_timegroupdetail_DuplicateMatchingRecord)
- [msdyn_timeoffrequest_DuplicateBaseRecord](#BKMK_msdyn_timeoffrequest_DuplicateBaseRecord)
- [msdyn_timeoffrequest_DuplicateMatchingRecord](#BKMK_msdyn_timeoffrequest_DuplicateMatchingRecord)
- [msdyn_trade_DuplicateBaseRecord](#BKMK_msdyn_trade_DuplicateBaseRecord)
- [msdyn_trade_DuplicateMatchingRecord](#BKMK_msdyn_trade_DuplicateMatchingRecord)
- [msdyn_tradecoverage_DuplicateBaseRecord](#BKMK_msdyn_tradecoverage_DuplicateBaseRecord)
- [msdyn_tradecoverage_DuplicateMatchingRecord](#BKMK_msdyn_tradecoverage_DuplicateMatchingRecord)
- [msdyn_transactionorigin_DuplicateBaseRecord](#BKMK_msdyn_transactionorigin_DuplicateBaseRecord)
- [msdyn_transactionorigin_DuplicateMatchingRecord](#BKMK_msdyn_transactionorigin_DuplicateMatchingRecord)
- [msdyn_warehouse_DuplicateBaseRecord](#BKMK_msdyn_warehouse_DuplicateBaseRecord)
- [msdyn_warehouse_DuplicateMatchingRecord](#BKMK_msdyn_warehouse_DuplicateMatchingRecord)
- [msdyn_workhourtemplate_DuplicateBaseRecord](#BKMK_msdyn_workhourtemplate_DuplicateBaseRecord)
- [msdyn_workhourtemplate_DuplicateMatchingRecord](#BKMK_msdyn_workhourtemplate_DuplicateMatchingRecord)
- [msdyn_workorder_DuplicateBaseRecord](#BKMK_msdyn_workorder_DuplicateBaseRecord)
- [msdyn_workorder_DuplicateMatchingRecord](#BKMK_msdyn_workorder_DuplicateMatchingRecord)
- [msdyn_workorderincident_DuplicateBaseRecord](#BKMK_msdyn_workorderincident_DuplicateBaseRecord)
- [msdyn_workorderincident_DuplicateMatchingRecord](#BKMK_msdyn_workorderincident_DuplicateMatchingRecord)
- [msdyn_workordernte_DuplicateBaseRecord](#BKMK_msdyn_workordernte_DuplicateBaseRecord)
- [msdyn_workordernte_DuplicateMatchingRecord](#BKMK_msdyn_workordernte_DuplicateMatchingRecord)
- [msdyn_workorderresolution_DuplicateBaseRecord](#BKMK_msdyn_workorderresolution_DuplicateBaseRecord)
- [msdyn_workorderresolution_DuplicateMatchingRecord](#BKMK_msdyn_workorderresolution_DuplicateMatchingRecord)
- [msdyn_workorderresourcerestriction_DuplicateBaseRecord](#BKMK_msdyn_workorderresourcerestriction_DuplicateBaseRecord)
- [msdyn_workorderresourcerestriction_DuplicateMatchingRecord](#BKMK_msdyn_workorderresourcerestriction_DuplicateMatchingRecord)
- [msdyn_workorderservice_DuplicateBaseRecord](#BKMK_msdyn_workorderservice_DuplicateBaseRecord)
- [msdyn_workorderservice_DuplicateMatchingRecord](#BKMK_msdyn_workorderservice_DuplicateMatchingRecord)
- [msdyn_workorderservicetask_DuplicateBaseRecord](#BKMK_msdyn_workorderservicetask_DuplicateBaseRecord)
- [msdyn_workorderservicetask_DuplicateMatchingRecord](#BKMK_msdyn_workorderservicetask_DuplicateMatchingRecord)
- [msdyn_workordersubstatus_DuplicateBaseRecord](#BKMK_msdyn_workordersubstatus_DuplicateBaseRecord)
- [msdyn_workordersubstatus_DuplicateMatchingRecord](#BKMK_msdyn_workordersubstatus_DuplicateMatchingRecord)
- [msdyn_workordertype_DuplicateBaseRecord](#BKMK_msdyn_workordertype_DuplicateBaseRecord)
- [msdyn_workordertype_DuplicateMatchingRecord](#BKMK_msdyn_workordertype_DuplicateMatchingRecord)

### <a name="BKMK_msdyn_actual_DuplicateBaseRecord"></a> msdyn_actual_DuplicateBaseRecord

One-To-Many Relationship: [msdyn_actual msdyn_actual_DuplicateBaseRecord](msdyn_actual.md#BKMK_msdyn_actual_DuplicateBaseRecord)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_actual`|
|ReferencedAttribute|`msdyn_actualid`|
|ReferencingAttribute|`baserecordid`|
|ReferencingEntityNavigationPropertyName|`baserecordid_msdyn_actual`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_actual_DuplicateMatchingRecord"></a> msdyn_actual_DuplicateMatchingRecord

One-To-Many Relationship: [msdyn_actual msdyn_actual_DuplicateMatchingRecord](msdyn_actual.md#BKMK_msdyn_actual_DuplicateMatchingRecord)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_actual`|
|ReferencedAttribute|`msdyn_actualid`|
|ReferencingAttribute|`duplicaterecordid`|
|ReferencingEntityNavigationPropertyName|`duplicaterecordid_msdyn_actual`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_agreement_DuplicateBaseRecord"></a> msdyn_agreement_DuplicateBaseRecord

One-To-Many Relationship: [msdyn_agreement msdyn_agreement_DuplicateBaseRecord](msdyn_agreement.md#BKMK_msdyn_agreement_DuplicateBaseRecord)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_agreement`|
|ReferencedAttribute|`msdyn_agreementid`|
|ReferencingAttribute|`baserecordid`|
|ReferencingEntityNavigationPropertyName|`baserecordid_msdyn_agreement`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_agreement_DuplicateMatchingRecord"></a> msdyn_agreement_DuplicateMatchingRecord

One-To-Many Relationship: [msdyn_agreement msdyn_agreement_DuplicateMatchingRecord](msdyn_agreement.md#BKMK_msdyn_agreement_DuplicateMatchingRecord)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_agreement`|
|ReferencedAttribute|`msdyn_agreementid`|
|ReferencingAttribute|`duplicaterecordid`|
|ReferencingEntityNavigationPropertyName|`duplicaterecordid_msdyn_agreement`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_agreementbookingdate_DuplicateBaseRecord"></a> msdyn_agreementbookingdate_DuplicateBaseRecord

One-To-Many Relationship: [msdyn_agreementbookingdate msdyn_agreementbookingdate_DuplicateBaseRecord](msdyn_agreementbookingdate.md#BKMK_msdyn_agreementbookingdate_DuplicateBaseRecord)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_agreementbookingdate`|
|ReferencedAttribute|`msdyn_agreementbookingdateid`|
|ReferencingAttribute|`baserecordid`|
|ReferencingEntityNavigationPropertyName|`baserecordid_msdyn_agreementbookingdate`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_agreementbookingdate_DuplicateMatchingRecord"></a> msdyn_agreementbookingdate_DuplicateMatchingRecord

One-To-Many Relationship: [msdyn_agreementbookingdate msdyn_agreementbookingdate_DuplicateMatchingRecord](msdyn_agreementbookingdate.md#BKMK_msdyn_agreementbookingdate_DuplicateMatchingRecord)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_agreementbookingdate`|
|ReferencedAttribute|`msdyn_agreementbookingdateid`|
|ReferencingAttribute|`duplicaterecordid`|
|ReferencingEntityNavigationPropertyName|`duplicaterecordid_msdyn_agreementbookingdate`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_agreementbookingincident_DuplicateBaseRecord"></a> msdyn_agreementbookingincident_DuplicateBaseRecord

One-To-Many Relationship: [msdyn_agreementbookingincident msdyn_agreementbookingincident_DuplicateBaseRecord](msdyn_agreementbookingincident.md#BKMK_msdyn_agreementbookingincident_DuplicateBaseRecord)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_agreementbookingincident`|
|ReferencedAttribute|`msdyn_agreementbookingincidentid`|
|ReferencingAttribute|`baserecordid`|
|ReferencingEntityNavigationPropertyName|`baserecordid_msdyn_agreementbookingincident`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_agreementbookingincident_DuplicateMatchingRecord"></a> msdyn_agreementbookingincident_DuplicateMatchingRecord

One-To-Many Relationship: [msdyn_agreementbookingincident msdyn_agreementbookingincident_DuplicateMatchingRecord](msdyn_agreementbookingincident.md#BKMK_msdyn_agreementbookingincident_DuplicateMatchingRecord)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_agreementbookingincident`|
|ReferencedAttribute|`msdyn_agreementbookingincidentid`|
|ReferencingAttribute|`duplicaterecordid`|
|ReferencingEntityNavigationPropertyName|`duplicaterecordid_msdyn_agreementbookingincident`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_agreementbookingproduct_DuplicateBaseRecord"></a> msdyn_agreementbookingproduct_DuplicateBaseRecord

One-To-Many Relationship: [msdyn_agreementbookingproduct msdyn_agreementbookingproduct_DuplicateBaseRecord](msdyn_agreementbookingproduct.md#BKMK_msdyn_agreementbookingproduct_DuplicateBaseRecord)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_agreementbookingproduct`|
|ReferencedAttribute|`msdyn_agreementbookingproductid`|
|ReferencingAttribute|`baserecordid`|
|ReferencingEntityNavigationPropertyName|`baserecordid_msdyn_agreementbookingproduct`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_agreementbookingproduct_DuplicateMatchingRecord"></a> msdyn_agreementbookingproduct_DuplicateMatchingRecord

One-To-Many Relationship: [msdyn_agreementbookingproduct msdyn_agreementbookingproduct_DuplicateMatchingRecord](msdyn_agreementbookingproduct.md#BKMK_msdyn_agreementbookingproduct_DuplicateMatchingRecord)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_agreementbookingproduct`|
|ReferencedAttribute|`msdyn_agreementbookingproductid`|
|ReferencingAttribute|`duplicaterecordid`|
|ReferencingEntityNavigationPropertyName|`duplicaterecordid_msdyn_agreementbookingproduct`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_agreementbookingservice_DuplicateBaseRecord"></a> msdyn_agreementbookingservice_DuplicateBaseRecord

One-To-Many Relationship: [msdyn_agreementbookingservice msdyn_agreementbookingservice_DuplicateBaseRecord](msdyn_agreementbookingservice.md#BKMK_msdyn_agreementbookingservice_DuplicateBaseRecord)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_agreementbookingservice`|
|ReferencedAttribute|`msdyn_agreementbookingserviceid`|
|ReferencingAttribute|`baserecordid`|
|ReferencingEntityNavigationPropertyName|`baserecordid_msdyn_agreementbookingservice`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_agreementbookingservice_DuplicateMatchingRecord"></a> msdyn_agreementbookingservice_DuplicateMatchingRecord

One-To-Many Relationship: [msdyn_agreementbookingservice msdyn_agreementbookingservice_DuplicateMatchingRecord](msdyn_agreementbookingservice.md#BKMK_msdyn_agreementbookingservice_DuplicateMatchingRecord)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_agreementbookingservice`|
|ReferencedAttribute|`msdyn_agreementbookingserviceid`|
|ReferencingAttribute|`duplicaterecordid`|
|ReferencingEntityNavigationPropertyName|`duplicaterecordid_msdyn_agreementbookingservice`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_agreementbookingservicetask_DuplicateBaseRecord"></a> msdyn_agreementbookingservicetask_DuplicateBaseRecord

One-To-Many Relationship: [msdyn_agreementbookingservicetask msdyn_agreementbookingservicetask_DuplicateBaseRecord](msdyn_agreementbookingservicetask.md#BKMK_msdyn_agreementbookingservicetask_DuplicateBaseRecord)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_agreementbookingservicetask`|
|ReferencedAttribute|`msdyn_agreementbookingservicetaskid`|
|ReferencingAttribute|`baserecordid`|
|ReferencingEntityNavigationPropertyName|`baserecordid_msdyn_agreementbookingservicetask`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_agreementbookingservicetask_DuplicateMatchingRecord"></a> msdyn_agreementbookingservicetask_DuplicateMatchingRecord

One-To-Many Relationship: [msdyn_agreementbookingservicetask msdyn_agreementbookingservicetask_DuplicateMatchingRecord](msdyn_agreementbookingservicetask.md#BKMK_msdyn_agreementbookingservicetask_DuplicateMatchingRecord)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_agreementbookingservicetask`|
|ReferencedAttribute|`msdyn_agreementbookingservicetaskid`|
|ReferencingAttribute|`duplicaterecordid`|
|ReferencingEntityNavigationPropertyName|`duplicaterecordid_msdyn_agreementbookingservicetask`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_agreementbookingsetup_DuplicateBaseRecord"></a> msdyn_agreementbookingsetup_DuplicateBaseRecord

One-To-Many Relationship: [msdyn_agreementbookingsetup msdyn_agreementbookingsetup_DuplicateBaseRecord](msdyn_agreementbookingsetup.md#BKMK_msdyn_agreementbookingsetup_DuplicateBaseRecord)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_agreementbookingsetup`|
|ReferencedAttribute|`msdyn_agreementbookingsetupid`|
|ReferencingAttribute|`baserecordid`|
|ReferencingEntityNavigationPropertyName|`baserecordid_msdyn_agreementbookingsetup`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_agreementbookingsetup_DuplicateMatchingRecord"></a> msdyn_agreementbookingsetup_DuplicateMatchingRecord

One-To-Many Relationship: [msdyn_agreementbookingsetup msdyn_agreementbookingsetup_DuplicateMatchingRecord](msdyn_agreementbookingsetup.md#BKMK_msdyn_agreementbookingsetup_DuplicateMatchingRecord)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_agreementbookingsetup`|
|ReferencedAttribute|`msdyn_agreementbookingsetupid`|
|ReferencingAttribute|`duplicaterecordid`|
|ReferencingEntityNavigationPropertyName|`duplicaterecordid_msdyn_agreementbookingsetup`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_agreementinvoicedate_DuplicateBaseRecord"></a> msdyn_agreementinvoicedate_DuplicateBaseRecord

One-To-Many Relationship: [msdyn_agreementinvoicedate msdyn_agreementinvoicedate_DuplicateBaseRecord](msdyn_agreementinvoicedate.md#BKMK_msdyn_agreementinvoicedate_DuplicateBaseRecord)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_agreementinvoicedate`|
|ReferencedAttribute|`msdyn_agreementinvoicedateid`|
|ReferencingAttribute|`baserecordid`|
|ReferencingEntityNavigationPropertyName|`baserecordid_msdyn_agreementinvoicedate`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_agreementinvoicedate_DuplicateMatchingRecord"></a> msdyn_agreementinvoicedate_DuplicateMatchingRecord

One-To-Many Relationship: [msdyn_agreementinvoicedate msdyn_agreementinvoicedate_DuplicateMatchingRecord](msdyn_agreementinvoicedate.md#BKMK_msdyn_agreementinvoicedate_DuplicateMatchingRecord)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_agreementinvoicedate`|
|ReferencedAttribute|`msdyn_agreementinvoicedateid`|
|ReferencingAttribute|`duplicaterecordid`|
|ReferencingEntityNavigationPropertyName|`duplicaterecordid_msdyn_agreementinvoicedate`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_agreementinvoiceproduct_DuplicateBaseRecord"></a> msdyn_agreementinvoiceproduct_DuplicateBaseRecord

One-To-Many Relationship: [msdyn_agreementinvoiceproduct msdyn_agreementinvoiceproduct_DuplicateBaseRecord](msdyn_agreementinvoiceproduct.md#BKMK_msdyn_agreementinvoiceproduct_DuplicateBaseRecord)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_agreementinvoiceproduct`|
|ReferencedAttribute|`msdyn_agreementinvoiceproductid`|
|ReferencingAttribute|`baserecordid`|
|ReferencingEntityNavigationPropertyName|`baserecordid_msdyn_agreementinvoiceproduct`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_agreementinvoiceproduct_DuplicateMatchingRecord"></a> msdyn_agreementinvoiceproduct_DuplicateMatchingRecord

One-To-Many Relationship: [msdyn_agreementinvoiceproduct msdyn_agreementinvoiceproduct_DuplicateMatchingRecord](msdyn_agreementinvoiceproduct.md#BKMK_msdyn_agreementinvoiceproduct_DuplicateMatchingRecord)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_agreementinvoiceproduct`|
|ReferencedAttribute|`msdyn_agreementinvoiceproductid`|
|ReferencingAttribute|`duplicaterecordid`|
|ReferencingEntityNavigationPropertyName|`duplicaterecordid_msdyn_agreementinvoiceproduct`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_agreementinvoicesetup_DuplicateBaseRecord"></a> msdyn_agreementinvoicesetup_DuplicateBaseRecord

One-To-Many Relationship: [msdyn_agreementinvoicesetup msdyn_agreementinvoicesetup_DuplicateBaseRecord](msdyn_agreementinvoicesetup.md#BKMK_msdyn_agreementinvoicesetup_DuplicateBaseRecord)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_agreementinvoicesetup`|
|ReferencedAttribute|`msdyn_agreementinvoicesetupid`|
|ReferencingAttribute|`baserecordid`|
|ReferencingEntityNavigationPropertyName|`baserecordid_msdyn_agreementinvoicesetup`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_agreementinvoicesetup_DuplicateMatchingRecord"></a> msdyn_agreementinvoicesetup_DuplicateMatchingRecord

One-To-Many Relationship: [msdyn_agreementinvoicesetup msdyn_agreementinvoicesetup_DuplicateMatchingRecord](msdyn_agreementinvoicesetup.md#BKMK_msdyn_agreementinvoicesetup_DuplicateMatchingRecord)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_agreementinvoicesetup`|
|ReferencedAttribute|`msdyn_agreementinvoicesetupid`|
|ReferencingAttribute|`duplicaterecordid`|
|ReferencingEntityNavigationPropertyName|`duplicaterecordid_msdyn_agreementinvoicesetup`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_agreementsubstatus_DuplicateBaseRecord"></a> msdyn_agreementsubstatus_DuplicateBaseRecord

One-To-Many Relationship: [msdyn_agreementsubstatus msdyn_agreementsubstatus_DuplicateBaseRecord](msdyn_agreementsubstatus.md#BKMK_msdyn_agreementsubstatus_DuplicateBaseRecord)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_agreementsubstatus`|
|ReferencedAttribute|`msdyn_agreementsubstatusid`|
|ReferencingAttribute|`baserecordid`|
|ReferencingEntityNavigationPropertyName|`baserecordid_msdyn_agreementsubstatus`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_agreementsubstatus_DuplicateMatchingRecord"></a> msdyn_agreementsubstatus_DuplicateMatchingRecord

One-To-Many Relationship: [msdyn_agreementsubstatus msdyn_agreementsubstatus_DuplicateMatchingRecord](msdyn_agreementsubstatus.md#BKMK_msdyn_agreementsubstatus_DuplicateMatchingRecord)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_agreementsubstatus`|
|ReferencedAttribute|`msdyn_agreementsubstatusid`|
|ReferencingAttribute|`duplicaterecordid`|
|ReferencingEntityNavigationPropertyName|`duplicaterecordid_msdyn_agreementsubstatus`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_bookableresourceassociation_DuplicateBaseRecord"></a> msdyn_bookableresourceassociation_DuplicateBaseRecord

One-To-Many Relationship: [msdyn_bookableresourceassociation msdyn_bookableresourceassociation_DuplicateBaseRecord](msdyn_bookableresourceassociation.md#BKMK_msdyn_bookableresourceassociation_DuplicateBaseRecord)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_bookableresourceassociation`|
|ReferencedAttribute|`msdyn_bookableresourceassociationid`|
|ReferencingAttribute|`baserecordid`|
|ReferencingEntityNavigationPropertyName|`baserecordid_msdyn_bookableresourceassociation`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_bookableresourceassociation_DuplicateMatchingRecord"></a> msdyn_bookableresourceassociation_DuplicateMatchingRecord

One-To-Many Relationship: [msdyn_bookableresourceassociation msdyn_bookableresourceassociation_DuplicateMatchingRecord](msdyn_bookableresourceassociation.md#BKMK_msdyn_bookableresourceassociation_DuplicateMatchingRecord)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_bookableresourceassociation`|
|ReferencedAttribute|`msdyn_bookableresourceassociationid`|
|ReferencingAttribute|`duplicaterecordid`|
|ReferencingEntityNavigationPropertyName|`duplicaterecordid_msdyn_bookableresourceassociation`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_bookableresourcebookingquicknote_DuplicateBaseRecord"></a> msdyn_bookableresourcebookingquicknote_DuplicateBaseRecord

One-To-Many Relationship: [msdyn_bookableresourcebookingquicknote msdyn_bookableresourcebookingquicknote_DuplicateBaseRecord](msdyn_bookableresourcebookingquicknote.md#BKMK_msdyn_bookableresourcebookingquicknote_DuplicateBaseRecord)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_bookableresourcebookingquicknote`|
|ReferencedAttribute|`msdyn_bookableresourcebookingquicknoteid`|
|ReferencingAttribute|`baserecordid`|
|ReferencingEntityNavigationPropertyName|`baserecordid_msdyn_bookableresourcebookingquicknote`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_bookableresourcebookingquicknote_DuplicateMatchingRecord"></a> msdyn_bookableresourcebookingquicknote_DuplicateMatchingRecord

One-To-Many Relationship: [msdyn_bookableresourcebookingquicknote msdyn_bookableresourcebookingquicknote_DuplicateMatchingRecord](msdyn_bookableresourcebookingquicknote.md#BKMK_msdyn_bookableresourcebookingquicknote_DuplicateMatchingRecord)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_bookableresourcebookingquicknote`|
|ReferencedAttribute|`msdyn_bookableresourcebookingquicknoteid`|
|ReferencingAttribute|`duplicaterecordid`|
|ReferencingEntityNavigationPropertyName|`duplicaterecordid_msdyn_bookableresourcebookingquicknote`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_bookingalert_DuplicateBaseRecord"></a> msdyn_bookingalert_DuplicateBaseRecord

One-To-Many Relationship: [msdyn_bookingalert msdyn_bookingalert_DuplicateBaseRecord](msdyn_bookingalert.md#BKMK_msdyn_bookingalert_DuplicateBaseRecord)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_bookingalert`|
|ReferencedAttribute|`activityid`|
|ReferencingAttribute|`baserecordid`|
|ReferencingEntityNavigationPropertyName|`baserecordid_msdyn_bookingalert`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_bookingalert_DuplicateMatchingRecord"></a> msdyn_bookingalert_DuplicateMatchingRecord

One-To-Many Relationship: [msdyn_bookingalert msdyn_bookingalert_DuplicateMatchingRecord](msdyn_bookingalert.md#BKMK_msdyn_bookingalert_DuplicateMatchingRecord)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_bookingalert`|
|ReferencedAttribute|`activityid`|
|ReferencingAttribute|`duplicaterecordid`|
|ReferencingEntityNavigationPropertyName|`duplicaterecordid_msdyn_bookingalert`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_bookingalertstatus_DuplicateBaseRecord"></a> msdyn_bookingalertstatus_DuplicateBaseRecord

One-To-Many Relationship: [msdyn_bookingalertstatus msdyn_bookingalertstatus_DuplicateBaseRecord](msdyn_bookingalertstatus.md#BKMK_msdyn_bookingalertstatus_DuplicateBaseRecord)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_bookingalertstatus`|
|ReferencedAttribute|`msdyn_bookingalertstatusid`|
|ReferencingAttribute|`baserecordid`|
|ReferencingEntityNavigationPropertyName|`baserecordid_msdyn_bookingalertstatus`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_bookingalertstatus_DuplicateMatchingRecord"></a> msdyn_bookingalertstatus_DuplicateMatchingRecord

One-To-Many Relationship: [msdyn_bookingalertstatus msdyn_bookingalertstatus_DuplicateMatchingRecord](msdyn_bookingalertstatus.md#BKMK_msdyn_bookingalertstatus_DuplicateMatchingRecord)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_bookingalertstatus`|
|ReferencedAttribute|`msdyn_bookingalertstatusid`|
|ReferencingAttribute|`duplicaterecordid`|
|ReferencingEntityNavigationPropertyName|`duplicaterecordid_msdyn_bookingalertstatus`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_bookingrule_DuplicateBaseRecord"></a> msdyn_bookingrule_DuplicateBaseRecord

One-To-Many Relationship: [msdyn_bookingrule msdyn_bookingrule_DuplicateBaseRecord](msdyn_bookingrule.md#BKMK_msdyn_bookingrule_DuplicateBaseRecord)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_bookingrule`|
|ReferencedAttribute|`msdyn_bookingruleid`|
|ReferencingAttribute|`baserecordid`|
|ReferencingEntityNavigationPropertyName|`baserecordid_msdyn_bookingrule`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_bookingrule_DuplicateMatchingRecord"></a> msdyn_bookingrule_DuplicateMatchingRecord

One-To-Many Relationship: [msdyn_bookingrule msdyn_bookingrule_DuplicateMatchingRecord](msdyn_bookingrule.md#BKMK_msdyn_bookingrule_DuplicateMatchingRecord)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_bookingrule`|
|ReferencedAttribute|`msdyn_bookingruleid`|
|ReferencingAttribute|`duplicaterecordid`|
|ReferencingEntityNavigationPropertyName|`duplicaterecordid_msdyn_bookingrule`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_bookingtimestamp_DuplicateBaseRecord"></a> msdyn_bookingtimestamp_DuplicateBaseRecord

One-To-Many Relationship: [msdyn_bookingtimestamp msdyn_bookingtimestamp_DuplicateBaseRecord](msdyn_bookingtimestamp.md#BKMK_msdyn_bookingtimestamp_DuplicateBaseRecord)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_bookingtimestamp`|
|ReferencedAttribute|`msdyn_bookingtimestampid`|
|ReferencingAttribute|`baserecordid`|
|ReferencingEntityNavigationPropertyName|`baserecordid_msdyn_bookingtimestamp`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_bookingtimestamp_DuplicateMatchingRecord"></a> msdyn_bookingtimestamp_DuplicateMatchingRecord

One-To-Many Relationship: [msdyn_bookingtimestamp msdyn_bookingtimestamp_DuplicateMatchingRecord](msdyn_bookingtimestamp.md#BKMK_msdyn_bookingtimestamp_DuplicateMatchingRecord)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_bookingtimestamp`|
|ReferencedAttribute|`msdyn_bookingtimestampid`|
|ReferencingAttribute|`duplicaterecordid`|
|ReferencingEntityNavigationPropertyName|`duplicaterecordid_msdyn_bookingtimestamp`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_clientextension_DuplicateBaseRecord"></a> msdyn_clientextension_DuplicateBaseRecord

One-To-Many Relationship: [msdyn_clientextension msdyn_clientextension_DuplicateBaseRecord](msdyn_clientextension.md#BKMK_msdyn_clientextension_DuplicateBaseRecord)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_clientextension`|
|ReferencedAttribute|`msdyn_clientextensionid`|
|ReferencingAttribute|`baserecordid`|
|ReferencingEntityNavigationPropertyName|`baserecordid_msdyn_clientextension`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_clientextension_DuplicateMatchingRecord"></a> msdyn_clientextension_DuplicateMatchingRecord

One-To-Many Relationship: [msdyn_clientextension msdyn_clientextension_DuplicateMatchingRecord](msdyn_clientextension.md#BKMK_msdyn_clientextension_DuplicateMatchingRecord)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_clientextension`|
|ReferencedAttribute|`msdyn_clientextensionid`|
|ReferencingAttribute|`duplicaterecordid`|
|ReferencingEntityNavigationPropertyName|`duplicaterecordid_msdyn_clientextension`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_consoleapplicationsessiontemplate_DuplicateBaseRecord"></a> msdyn_consoleapplicationsessiontemplate_DuplicateBaseRecord

One-To-Many Relationship: [msdyn_consoleapplicationsessiontemplate msdyn_consoleapplicationsessiontemplate_DuplicateBaseRecord](msdyn_consoleapplicationsessiontemplate.md#BKMK_msdyn_consoleapplicationsessiontemplate_DuplicateBaseRecord)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_consoleapplicationsessiontemplate`|
|ReferencedAttribute|`msdyn_consoleapplicationsessiontemplateid`|
|ReferencingAttribute|`baserecordid`|
|ReferencingEntityNavigationPropertyName|`baserecordid_msdyn_consoleapplicationsessiontemplate`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_consoleapplicationsessiontemplate_DuplicateMatchingRecord"></a> msdyn_consoleapplicationsessiontemplate_DuplicateMatchingRecord

One-To-Many Relationship: [msdyn_consoleapplicationsessiontemplate msdyn_consoleapplicationsessiontemplate_DuplicateMatchingRecord](msdyn_consoleapplicationsessiontemplate.md#BKMK_msdyn_consoleapplicationsessiontemplate_DuplicateMatchingRecord)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_consoleapplicationsessiontemplate`|
|ReferencedAttribute|`msdyn_consoleapplicationsessiontemplateid`|
|ReferencingAttribute|`duplicaterecordid`|
|ReferencingEntityNavigationPropertyName|`duplicaterecordid_msdyn_consoleapplicationsessiontemplate`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_dataanalyticsreport_fs_DuplicateBaseRecord"></a> msdyn_dataanalyticsreport_fs_DuplicateBaseRecord

One-To-Many Relationship: [msdyn_dataanalyticsreport_fs msdyn_dataanalyticsreport_fs_DuplicateBaseRecord](msdyn_dataanalyticsreport_fs.md#BKMK_msdyn_dataanalyticsreport_fs_DuplicateBaseRecord)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_dataanalyticsreport_fs`|
|ReferencedAttribute|`msdyn_dataanalyticsreport_fsid`|
|ReferencingAttribute|`baserecordid`|
|ReferencingEntityNavigationPropertyName|`baserecordid_msdyn_dataanalyticsreport_fs`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_dataanalyticsreport_fs_DuplicateMatchingRecord"></a> msdyn_dataanalyticsreport_fs_DuplicateMatchingRecord

One-To-Many Relationship: [msdyn_dataanalyticsreport_fs msdyn_dataanalyticsreport_fs_DuplicateMatchingRecord](msdyn_dataanalyticsreport_fs.md#BKMK_msdyn_dataanalyticsreport_fs_DuplicateMatchingRecord)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_dataanalyticsreport_fs`|
|ReferencedAttribute|`msdyn_dataanalyticsreport_fsid`|
|ReferencingAttribute|`duplicaterecordid`|
|ReferencingEntityNavigationPropertyName|`duplicaterecordid_msdyn_dataanalyticsreport_fs`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_dataanalyticsreport_fspredictrs_DuplicateBaseRecord"></a> msdyn_dataanalyticsreport_fspredictrs_DuplicateBaseRecord

One-To-Many Relationship: [msdyn_dataanalyticsreport_fspredictrs msdyn_dataanalyticsreport_fspredictrs_DuplicateBaseRecord](msdyn_dataanalyticsreport_fspredictrs.md#BKMK_msdyn_dataanalyticsreport_fspredictrs_DuplicateBaseRecord)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_dataanalyticsreport_fspredictrs`|
|ReferencedAttribute|`msdyn_dataanalyticsreport_fspredictrsid`|
|ReferencingAttribute|`baserecordid`|
|ReferencingEntityNavigationPropertyName|`baserecordid_msdyn_dataanalyticsreport_fspredictrs`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_dataanalyticsreport_fspredictrs_DuplicateMatchingRecord"></a> msdyn_dataanalyticsreport_fspredictrs_DuplicateMatchingRecord

One-To-Many Relationship: [msdyn_dataanalyticsreport_fspredictrs msdyn_dataanalyticsreport_fspredictrs_DuplicateMatchingRecord](msdyn_dataanalyticsreport_fspredictrs.md#BKMK_msdyn_dataanalyticsreport_fspredictrs_DuplicateMatchingRecord)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_dataanalyticsreport_fspredictrs`|
|ReferencedAttribute|`msdyn_dataanalyticsreport_fspredictrsid`|
|ReferencingAttribute|`duplicaterecordid`|
|ReferencingEntityNavigationPropertyName|`duplicaterecordid_msdyn_dataanalyticsreport_fspredictrs`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_dataanalyticsreport_fspredictwhd_DuplicateBaseRecord"></a> msdyn_dataanalyticsreport_fspredictwhd_DuplicateBaseRecord

One-To-Many Relationship: [msdyn_dataanalyticsreport_fspredictwhd msdyn_dataanalyticsreport_fspredictwhd_DuplicateBaseRecord](msdyn_dataanalyticsreport_fspredictwhd.md#BKMK_msdyn_dataanalyticsreport_fspredictwhd_DuplicateBaseRecord)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_dataanalyticsreport_fspredictwhd`|
|ReferencedAttribute|`msdyn_dataanalyticsreport_fspredictwhdid`|
|ReferencingAttribute|`baserecordid`|
|ReferencingEntityNavigationPropertyName|`baserecordid_msdyn_dataanalyticsreport_fspredictwhd`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_dataanalyticsreport_fspredictwhd_DuplicateMatchingRecord"></a> msdyn_dataanalyticsreport_fspredictwhd_DuplicateMatchingRecord

One-To-Many Relationship: [msdyn_dataanalyticsreport_fspredictwhd msdyn_dataanalyticsreport_fspredictwhd_DuplicateMatchingRecord](msdyn_dataanalyticsreport_fspredictwhd.md#BKMK_msdyn_dataanalyticsreport_fspredictwhd_DuplicateMatchingRecord)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_dataanalyticsreport_fspredictwhd`|
|ReferencedAttribute|`msdyn_dataanalyticsreport_fspredictwhdid`|
|ReferencingAttribute|`duplicaterecordid`|
|ReferencingEntityNavigationPropertyName|`duplicaterecordid_msdyn_dataanalyticsreport_fspredictwhd`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_entitlementapplication_DuplicateBaseRecord"></a> msdyn_entitlementapplication_DuplicateBaseRecord

One-To-Many Relationship: [msdyn_entitlementapplication msdyn_entitlementapplication_DuplicateBaseRecord](msdyn_entitlementapplication.md#BKMK_msdyn_entitlementapplication_DuplicateBaseRecord)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_entitlementapplication`|
|ReferencedAttribute|`msdyn_entitlementapplicationid`|
|ReferencingAttribute|`baserecordid`|
|ReferencingEntityNavigationPropertyName|`baserecordid_msdyn_entitlementapplication`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_entitlementapplication_DuplicateMatchingRecord"></a> msdyn_entitlementapplication_DuplicateMatchingRecord

One-To-Many Relationship: [msdyn_entitlementapplication msdyn_entitlementapplication_DuplicateMatchingRecord](msdyn_entitlementapplication.md#BKMK_msdyn_entitlementapplication_DuplicateMatchingRecord)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_entitlementapplication`|
|ReferencedAttribute|`msdyn_entitlementapplicationid`|
|ReferencingAttribute|`duplicaterecordid`|
|ReferencingEntityNavigationPropertyName|`duplicaterecordid_msdyn_entitlementapplication`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_entityconfiguration_DuplicateBaseRecord"></a> msdyn_entityconfiguration_DuplicateBaseRecord

One-To-Many Relationship: [msdyn_entityconfiguration msdyn_entityconfiguration_DuplicateBaseRecord](msdyn_entityconfiguration.md#BKMK_msdyn_entityconfiguration_DuplicateBaseRecord)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_entityconfiguration`|
|ReferencedAttribute|`msdyn_entityconfigurationid`|
|ReferencingAttribute|`baserecordid`|
|ReferencingEntityNavigationPropertyName|`baserecordid_msdyn_entityconfiguration`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_entityconfiguration_DuplicateMatchingRecord"></a> msdyn_entityconfiguration_DuplicateMatchingRecord

One-To-Many Relationship: [msdyn_entityconfiguration msdyn_entityconfiguration_DuplicateMatchingRecord](msdyn_entityconfiguration.md#BKMK_msdyn_entityconfiguration_DuplicateMatchingRecord)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_entityconfiguration`|
|ReferencedAttribute|`msdyn_entityconfigurationid`|
|ReferencingAttribute|`duplicaterecordid`|
|ReferencingEntityNavigationPropertyName|`duplicaterecordid_msdyn_entityconfiguration`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_fieldservicepricelistitem_DuplicateBaseRecord"></a> msdyn_fieldservicepricelistitem_DuplicateBaseRecord

One-To-Many Relationship: [msdyn_fieldservicepricelistitem msdyn_fieldservicepricelistitem_DuplicateBaseRecord](msdyn_fieldservicepricelistitem.md#BKMK_msdyn_fieldservicepricelistitem_DuplicateBaseRecord)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_fieldservicepricelistitem`|
|ReferencedAttribute|`msdyn_fieldservicepricelistitemid`|
|ReferencingAttribute|`baserecordid`|
|ReferencingEntityNavigationPropertyName|`baserecordid_msdyn_fieldservicepricelistitem`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_fieldservicepricelistitem_DuplicateMatchingRecord"></a> msdyn_fieldservicepricelistitem_DuplicateMatchingRecord

One-To-Many Relationship: [msdyn_fieldservicepricelistitem msdyn_fieldservicepricelistitem_DuplicateMatchingRecord](msdyn_fieldservicepricelistitem.md#BKMK_msdyn_fieldservicepricelistitem_DuplicateMatchingRecord)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_fieldservicepricelistitem`|
|ReferencedAttribute|`msdyn_fieldservicepricelistitemid`|
|ReferencingAttribute|`duplicaterecordid`|
|ReferencingEntityNavigationPropertyName|`duplicaterecordid_msdyn_fieldservicepricelistitem`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_flwconfiguration_DuplicateBaseRecord"></a> msdyn_flwconfiguration_DuplicateBaseRecord

One-To-Many Relationship: [msdyn_flwconfiguration msdyn_flwconfiguration_DuplicateBaseRecord](msdyn_flwconfiguration.md#BKMK_msdyn_flwconfiguration_DuplicateBaseRecord)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_flwconfiguration`|
|ReferencedAttribute|`msdyn_flwconfigurationid`|
|ReferencingAttribute|`baserecordid`|
|ReferencingEntityNavigationPropertyName|`baserecordid_msdyn_flwconfiguration`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_flwconfiguration_DuplicateMatchingRecord"></a> msdyn_flwconfiguration_DuplicateMatchingRecord

One-To-Many Relationship: [msdyn_flwconfiguration msdyn_flwconfiguration_DuplicateMatchingRecord](msdyn_flwconfiguration.md#BKMK_msdyn_flwconfiguration_DuplicateMatchingRecord)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_flwconfiguration`|
|ReferencedAttribute|`msdyn_flwconfigurationid`|
|ReferencingAttribute|`duplicaterecordid`|
|ReferencingEntityNavigationPropertyName|`duplicaterecordid_msdyn_flwconfiguration`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_geofence_DuplicateBaseRecord"></a> msdyn_geofence_DuplicateBaseRecord

One-To-Many Relationship: [msdyn_geofence msdyn_geofence_DuplicateBaseRecord](msdyn_geofence.md#BKMK_msdyn_geofence_DuplicateBaseRecord)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_geofence`|
|ReferencedAttribute|`msdyn_geofenceid`|
|ReferencingAttribute|`baserecordid`|
|ReferencingEntityNavigationPropertyName|`baserecordid_msdyn_geofence`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_geofence_DuplicateMatchingRecord"></a> msdyn_geofence_DuplicateMatchingRecord

One-To-Many Relationship: [msdyn_geofence msdyn_geofence_DuplicateMatchingRecord](msdyn_geofence.md#BKMK_msdyn_geofence_DuplicateMatchingRecord)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_geofence`|
|ReferencedAttribute|`msdyn_geofenceid`|
|ReferencingAttribute|`duplicaterecordid`|
|ReferencingEntityNavigationPropertyName|`duplicaterecordid_msdyn_geofence`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_geofenceevent_DuplicateBaseRecord"></a> msdyn_geofenceevent_DuplicateBaseRecord

One-To-Many Relationship: [msdyn_geofenceevent msdyn_geofenceevent_DuplicateBaseRecord](msdyn_geofenceevent.md#BKMK_msdyn_geofenceevent_DuplicateBaseRecord)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_geofenceevent`|
|ReferencedAttribute|`msdyn_geofenceeventid`|
|ReferencingAttribute|`baserecordid`|
|ReferencingEntityNavigationPropertyName|`baserecordid_msdyn_geofenceevent`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_geofenceevent_DuplicateMatchingRecord"></a> msdyn_geofenceevent_DuplicateMatchingRecord

One-To-Many Relationship: [msdyn_geofenceevent msdyn_geofenceevent_DuplicateMatchingRecord](msdyn_geofenceevent.md#BKMK_msdyn_geofenceevent_DuplicateMatchingRecord)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_geofenceevent`|
|ReferencedAttribute|`msdyn_geofenceeventid`|
|ReferencingAttribute|`duplicaterecordid`|
|ReferencingEntityNavigationPropertyName|`duplicaterecordid_msdyn_geofenceevent`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_geofencingsettings_DuplicateBaseRecord"></a> msdyn_geofencingsettings_DuplicateBaseRecord

One-To-Many Relationship: [msdyn_geofencingsettings msdyn_geofencingsettings_DuplicateBaseRecord](msdyn_geofencingsettings.md#BKMK_msdyn_geofencingsettings_DuplicateBaseRecord)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_geofencingsettings`|
|ReferencedAttribute|`msdyn_geofencingsettingsid`|
|ReferencingAttribute|`baserecordid`|
|ReferencingEntityNavigationPropertyName|`baserecordid_msdyn_geofencingsettings`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_geofencingsettings_DuplicateMatchingRecord"></a> msdyn_geofencingsettings_DuplicateMatchingRecord

One-To-Many Relationship: [msdyn_geofencingsettings msdyn_geofencingsettings_DuplicateMatchingRecord](msdyn_geofencingsettings.md#BKMK_msdyn_geofencingsettings_DuplicateMatchingRecord)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_geofencingsettings`|
|ReferencedAttribute|`msdyn_geofencingsettingsid`|
|ReferencingAttribute|`duplicaterecordid`|
|ReferencingEntityNavigationPropertyName|`duplicaterecordid_msdyn_geofencingsettings`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_geolocationsettings_DuplicateBaseRecord"></a> msdyn_geolocationsettings_DuplicateBaseRecord

One-To-Many Relationship: [msdyn_geolocationsettings msdyn_geolocationsettings_DuplicateBaseRecord](msdyn_geolocationsettings.md#BKMK_msdyn_geolocationsettings_DuplicateBaseRecord)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_geolocationsettings`|
|ReferencedAttribute|`msdyn_geolocationsettingsid`|
|ReferencingAttribute|`baserecordid`|
|ReferencingEntityNavigationPropertyName|`baserecordid_msdyn_geolocationsettings`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_geolocationsettings_DuplicateMatchingRecord"></a> msdyn_geolocationsettings_DuplicateMatchingRecord

One-To-Many Relationship: [msdyn_geolocationsettings msdyn_geolocationsettings_DuplicateMatchingRecord](msdyn_geolocationsettings.md#BKMK_msdyn_geolocationsettings_DuplicateMatchingRecord)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_geolocationsettings`|
|ReferencedAttribute|`msdyn_geolocationsettingsid`|
|ReferencingAttribute|`duplicaterecordid`|
|ReferencingEntityNavigationPropertyName|`duplicaterecordid_msdyn_geolocationsettings`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_geolocationtracking_DuplicateBaseRecord"></a> msdyn_geolocationtracking_DuplicateBaseRecord

One-To-Many Relationship: [msdyn_geolocationtracking msdyn_geolocationtracking_DuplicateBaseRecord](msdyn_geolocationtracking.md#BKMK_msdyn_geolocationtracking_DuplicateBaseRecord)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_geolocationtracking`|
|ReferencedAttribute|`msdyn_geolocationtrackingid`|
|ReferencingAttribute|`baserecordid`|
|ReferencingEntityNavigationPropertyName|`baserecordid_msdyn_geolocationtracking`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_geolocationtracking_DuplicateMatchingRecord"></a> msdyn_geolocationtracking_DuplicateMatchingRecord

One-To-Many Relationship: [msdyn_geolocationtracking msdyn_geolocationtracking_DuplicateMatchingRecord](msdyn_geolocationtracking.md#BKMK_msdyn_geolocationtracking_DuplicateMatchingRecord)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_geolocationtracking`|
|ReferencedAttribute|`msdyn_geolocationtrackingid`|
|ReferencingAttribute|`duplicaterecordid`|
|ReferencingEntityNavigationPropertyName|`duplicaterecordid_msdyn_geolocationtracking`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_incidenttype_DuplicateBaseRecord"></a> msdyn_incidenttype_DuplicateBaseRecord

One-To-Many Relationship: [msdyn_incidenttype msdyn_incidenttype_DuplicateBaseRecord](msdyn_incidenttype.md#BKMK_msdyn_incidenttype_DuplicateBaseRecord)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_incidenttype`|
|ReferencedAttribute|`msdyn_incidenttypeid`|
|ReferencingAttribute|`baserecordid`|
|ReferencingEntityNavigationPropertyName|`baserecordid_msdyn_incidenttype`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_incidenttype_DuplicateMatchingRecord"></a> msdyn_incidenttype_DuplicateMatchingRecord

One-To-Many Relationship: [msdyn_incidenttype msdyn_incidenttype_DuplicateMatchingRecord](msdyn_incidenttype.md#BKMK_msdyn_incidenttype_DuplicateMatchingRecord)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_incidenttype`|
|ReferencedAttribute|`msdyn_incidenttypeid`|
|ReferencingAttribute|`duplicaterecordid`|
|ReferencingEntityNavigationPropertyName|`duplicaterecordid_msdyn_incidenttype`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_incidenttype_requirementgroup_DuplicateBaseRecord"></a> msdyn_incidenttype_requirementgroup_DuplicateBaseRecord

One-To-Many Relationship: [msdyn_incidenttype_requirementgroup msdyn_incidenttype_requirementgroup_DuplicateBaseRecord](msdyn_incidenttype_requirementgroup.md#BKMK_msdyn_incidenttype_requirementgroup_DuplicateBaseRecord)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_incidenttype_requirementgroup`|
|ReferencedAttribute|`msdyn_incidenttype_requirementgroupid`|
|ReferencingAttribute|`baserecordid`|
|ReferencingEntityNavigationPropertyName|`baserecordid_msdyn_incidenttype_requirementgroup`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_incidenttype_requirementgroup_DuplicateMatchingRecord"></a> msdyn_incidenttype_requirementgroup_DuplicateMatchingRecord

One-To-Many Relationship: [msdyn_incidenttype_requirementgroup msdyn_incidenttype_requirementgroup_DuplicateMatchingRecord](msdyn_incidenttype_requirementgroup.md#BKMK_msdyn_incidenttype_requirementgroup_DuplicateMatchingRecord)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_incidenttype_requirementgroup`|
|ReferencedAttribute|`msdyn_incidenttype_requirementgroupid`|
|ReferencingAttribute|`duplicaterecordid`|
|ReferencingEntityNavigationPropertyName|`duplicaterecordid_msdyn_incidenttype_requirementgroup`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_incidenttypecharacteristic_DuplicateBaseRecord"></a> msdyn_incidenttypecharacteristic_DuplicateBaseRecord

One-To-Many Relationship: [msdyn_incidenttypecharacteristic msdyn_incidenttypecharacteristic_DuplicateBaseRecord](msdyn_incidenttypecharacteristic.md#BKMK_msdyn_incidenttypecharacteristic_DuplicateBaseRecord)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_incidenttypecharacteristic`|
|ReferencedAttribute|`msdyn_incidenttypecharacteristicid`|
|ReferencingAttribute|`baserecordid`|
|ReferencingEntityNavigationPropertyName|`baserecordid_msdyn_incidenttypecharacteristic`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_incidenttypecharacteristic_DuplicateMatchingRecord"></a> msdyn_incidenttypecharacteristic_DuplicateMatchingRecord

One-To-Many Relationship: [msdyn_incidenttypecharacteristic msdyn_incidenttypecharacteristic_DuplicateMatchingRecord](msdyn_incidenttypecharacteristic.md#BKMK_msdyn_incidenttypecharacteristic_DuplicateMatchingRecord)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_incidenttypecharacteristic`|
|ReferencedAttribute|`msdyn_incidenttypecharacteristicid`|
|ReferencingAttribute|`duplicaterecordid`|
|ReferencingEntityNavigationPropertyName|`duplicaterecordid_msdyn_incidenttypecharacteristic`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_incidenttypeproduct_DuplicateBaseRecord"></a> msdyn_incidenttypeproduct_DuplicateBaseRecord

One-To-Many Relationship: [msdyn_incidenttypeproduct msdyn_incidenttypeproduct_DuplicateBaseRecord](msdyn_incidenttypeproduct.md#BKMK_msdyn_incidenttypeproduct_DuplicateBaseRecord)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_incidenttypeproduct`|
|ReferencedAttribute|`msdyn_incidenttypeproductid`|
|ReferencingAttribute|`baserecordid`|
|ReferencingEntityNavigationPropertyName|`baserecordid_msdyn_incidenttypeproduct`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_incidenttypeproduct_DuplicateMatchingRecord"></a> msdyn_incidenttypeproduct_DuplicateMatchingRecord

One-To-Many Relationship: [msdyn_incidenttypeproduct msdyn_incidenttypeproduct_DuplicateMatchingRecord](msdyn_incidenttypeproduct.md#BKMK_msdyn_incidenttypeproduct_DuplicateMatchingRecord)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_incidenttypeproduct`|
|ReferencedAttribute|`msdyn_incidenttypeproductid`|
|ReferencingAttribute|`duplicaterecordid`|
|ReferencingEntityNavigationPropertyName|`duplicaterecordid_msdyn_incidenttypeproduct`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_incidenttyperecommendationresult_DuplicateBaseRecord"></a> msdyn_incidenttyperecommendationresult_DuplicateBaseRecord

One-To-Many Relationship: [msdyn_incidenttyperecommendationresult msdyn_incidenttyperecommendationresult_DuplicateBaseRecord](msdyn_incidenttyperecommendationresult.md#BKMK_msdyn_incidenttyperecommendationresult_DuplicateBaseRecord)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_incidenttyperecommendationresult`|
|ReferencedAttribute|`msdyn_incidenttyperecommendationresultid`|
|ReferencingAttribute|`baserecordid`|
|ReferencingEntityNavigationPropertyName|`baserecordid_msdyn_incidenttyperecommendationresult`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_incidenttyperecommendationresult_DuplicateMatchingRecord"></a> msdyn_incidenttyperecommendationresult_DuplicateMatchingRecord

One-To-Many Relationship: [msdyn_incidenttyperecommendationresult msdyn_incidenttyperecommendationresult_DuplicateMatchingRecord](msdyn_incidenttyperecommendationresult.md#BKMK_msdyn_incidenttyperecommendationresult_DuplicateMatchingRecord)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_incidenttyperecommendationresult`|
|ReferencedAttribute|`msdyn_incidenttyperecommendationresultid`|
|ReferencingAttribute|`duplicaterecordid`|
|ReferencingEntityNavigationPropertyName|`duplicaterecordid_msdyn_incidenttyperecommendationresult`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_incidenttyperecommendationrunhistory_DuplicateBaseRecord"></a> msdyn_incidenttyperecommendationrunhistory_DuplicateBaseRecord

One-To-Many Relationship: [msdyn_incidenttyperecommendationrunhistory msdyn_incidenttyperecommendationrunhistory_DuplicateBaseRecord](msdyn_incidenttyperecommendationrunhistory.md#BKMK_msdyn_incidenttyperecommendationrunhistory_DuplicateBaseRecord)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_incidenttyperecommendationrunhistory`|
|ReferencedAttribute|`msdyn_incidenttyperecommendationrunhistoryid`|
|ReferencingAttribute|`baserecordid`|
|ReferencingEntityNavigationPropertyName|`baserecordid_msdyn_incidenttyperecommendationrunhistory`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_incidenttyperecommendationrunhistory_DuplicateMatchingRecord"></a> msdyn_incidenttyperecommendationrunhistory_DuplicateMatchingRecord

One-To-Many Relationship: [msdyn_incidenttyperecommendationrunhistory msdyn_incidenttyperecommendationrunhistory_DuplicateMatchingRecord](msdyn_incidenttyperecommendationrunhistory.md#BKMK_msdyn_incidenttyperecommendationrunhistory_DuplicateMatchingRecord)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_incidenttyperecommendationrunhistory`|
|ReferencedAttribute|`msdyn_incidenttyperecommendationrunhistoryid`|
|ReferencingAttribute|`duplicaterecordid`|
|ReferencingEntityNavigationPropertyName|`duplicaterecordid_msdyn_incidenttyperecommendationrunhistory`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_incidenttyperesolution_DuplicateBaseRecord"></a> msdyn_incidenttyperesolution_DuplicateBaseRecord

One-To-Many Relationship: [msdyn_incidenttyperesolution msdyn_incidenttyperesolution_DuplicateBaseRecord](msdyn_incidenttyperesolution.md#BKMK_msdyn_incidenttyperesolution_DuplicateBaseRecord)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_incidenttyperesolution`|
|ReferencedAttribute|`msdyn_incidenttyperesolutionid`|
|ReferencingAttribute|`baserecordid`|
|ReferencingEntityNavigationPropertyName|`baserecordid_msdyn_incidenttyperesolution`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_incidenttyperesolution_DuplicateMatchingRecord"></a> msdyn_incidenttyperesolution_DuplicateMatchingRecord

One-To-Many Relationship: [msdyn_incidenttyperesolution msdyn_incidenttyperesolution_DuplicateMatchingRecord](msdyn_incidenttyperesolution.md#BKMK_msdyn_incidenttyperesolution_DuplicateMatchingRecord)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_incidenttyperesolution`|
|ReferencedAttribute|`msdyn_incidenttyperesolutionid`|
|ReferencingAttribute|`duplicaterecordid`|
|ReferencingEntityNavigationPropertyName|`duplicaterecordid_msdyn_incidenttyperesolution`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_incidenttypeservice_DuplicateBaseRecord"></a> msdyn_incidenttypeservice_DuplicateBaseRecord

One-To-Many Relationship: [msdyn_incidenttypeservice msdyn_incidenttypeservice_DuplicateBaseRecord](msdyn_incidenttypeservice.md#BKMK_msdyn_incidenttypeservice_DuplicateBaseRecord)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_incidenttypeservice`|
|ReferencedAttribute|`msdyn_incidenttypeserviceid`|
|ReferencingAttribute|`baserecordid`|
|ReferencingEntityNavigationPropertyName|`baserecordid_msdyn_incidenttypeservice`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_incidenttypeservice_DuplicateMatchingRecord"></a> msdyn_incidenttypeservice_DuplicateMatchingRecord

One-To-Many Relationship: [msdyn_incidenttypeservice msdyn_incidenttypeservice_DuplicateMatchingRecord](msdyn_incidenttypeservice.md#BKMK_msdyn_incidenttypeservice_DuplicateMatchingRecord)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_incidenttypeservice`|
|ReferencedAttribute|`msdyn_incidenttypeserviceid`|
|ReferencingAttribute|`duplicaterecordid`|
|ReferencingEntityNavigationPropertyName|`duplicaterecordid_msdyn_incidenttypeservice`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_incidenttypeservicetask_DuplicateBaseRecord"></a> msdyn_incidenttypeservicetask_DuplicateBaseRecord

One-To-Many Relationship: [msdyn_incidenttypeservicetask msdyn_incidenttypeservicetask_DuplicateBaseRecord](msdyn_incidenttypeservicetask.md#BKMK_msdyn_incidenttypeservicetask_DuplicateBaseRecord)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_incidenttypeservicetask`|
|ReferencedAttribute|`msdyn_incidenttypeservicetaskid`|
|ReferencingAttribute|`baserecordid`|
|ReferencingEntityNavigationPropertyName|`baserecordid_msdyn_incidenttypeservicetask`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_incidenttypeservicetask_DuplicateMatchingRecord"></a> msdyn_incidenttypeservicetask_DuplicateMatchingRecord

One-To-Many Relationship: [msdyn_incidenttypeservicetask msdyn_incidenttypeservicetask_DuplicateMatchingRecord](msdyn_incidenttypeservicetask.md#BKMK_msdyn_incidenttypeservicetask_DuplicateMatchingRecord)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_incidenttypeservicetask`|
|ReferencedAttribute|`msdyn_incidenttypeservicetaskid`|
|ReferencingAttribute|`duplicaterecordid`|
|ReferencingEntityNavigationPropertyName|`duplicaterecordid_msdyn_incidenttypeservicetask`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_incidenttypessetup_DuplicateBaseRecord"></a> msdyn_incidenttypessetup_DuplicateBaseRecord

One-To-Many Relationship: [msdyn_incidenttypessetup msdyn_incidenttypessetup_DuplicateBaseRecord](msdyn_incidenttypessetup.md#BKMK_msdyn_incidenttypessetup_DuplicateBaseRecord)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_incidenttypessetup`|
|ReferencedAttribute|`msdyn_incidenttypessetupid`|
|ReferencingAttribute|`baserecordid`|
|ReferencingEntityNavigationPropertyName|`baserecordid_msdyn_incidenttypessetup`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_incidenttypessetup_DuplicateMatchingRecord"></a> msdyn_incidenttypessetup_DuplicateMatchingRecord

One-To-Many Relationship: [msdyn_incidenttypessetup msdyn_incidenttypessetup_DuplicateMatchingRecord](msdyn_incidenttypessetup.md#BKMK_msdyn_incidenttypessetup_DuplicateMatchingRecord)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_incidenttypessetup`|
|ReferencedAttribute|`msdyn_incidenttypessetupid`|
|ReferencingAttribute|`duplicaterecordid`|
|ReferencingEntityNavigationPropertyName|`duplicaterecordid_msdyn_incidenttypessetup`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_inspection_DuplicateBaseRecord"></a> msdyn_inspection_DuplicateBaseRecord

One-To-Many Relationship: [msdyn_inspection msdyn_inspection_DuplicateBaseRecord](msdyn_inspection.md#BKMK_msdyn_inspection_DuplicateBaseRecord)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_inspection`|
|ReferencedAttribute|`msdyn_inspectionid`|
|ReferencingAttribute|`baserecordid`|
|ReferencingEntityNavigationPropertyName|`baserecordid_msdyn_inspection`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_inspection_DuplicateMatchingRecord"></a> msdyn_inspection_DuplicateMatchingRecord

One-To-Many Relationship: [msdyn_inspection msdyn_inspection_DuplicateMatchingRecord](msdyn_inspection.md#BKMK_msdyn_inspection_DuplicateMatchingRecord)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_inspection`|
|ReferencedAttribute|`msdyn_inspectionid`|
|ReferencingAttribute|`duplicaterecordid`|
|ReferencingEntityNavigationPropertyName|`duplicaterecordid_msdyn_inspection`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_inspectionattachment_DuplicateBaseRecord"></a> msdyn_inspectionattachment_DuplicateBaseRecord

One-To-Many Relationship: [msdyn_inspectionattachment msdyn_inspectionattachment_DuplicateBaseRecord](msdyn_inspectionattachment.md#BKMK_msdyn_inspectionattachment_DuplicateBaseRecord)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_inspectionattachment`|
|ReferencedAttribute|`msdyn_inspectionattachmentid`|
|ReferencingAttribute|`baserecordid`|
|ReferencingEntityNavigationPropertyName|`baserecordid_msdyn_inspectionattachment`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_inspectionattachment_DuplicateMatchingRecord"></a> msdyn_inspectionattachment_DuplicateMatchingRecord

One-To-Many Relationship: [msdyn_inspectionattachment msdyn_inspectionattachment_DuplicateMatchingRecord](msdyn_inspectionattachment.md#BKMK_msdyn_inspectionattachment_DuplicateMatchingRecord)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_inspectionattachment`|
|ReferencedAttribute|`msdyn_inspectionattachmentid`|
|ReferencingAttribute|`duplicaterecordid`|
|ReferencingEntityNavigationPropertyName|`duplicaterecordid_msdyn_inspectionattachment`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_inspectiondefinition_DuplicateBaseRecord"></a> msdyn_inspectiondefinition_DuplicateBaseRecord

One-To-Many Relationship: [msdyn_inspectiondefinition msdyn_inspectiondefinition_DuplicateBaseRecord](msdyn_inspectiondefinition.md#BKMK_msdyn_inspectiondefinition_DuplicateBaseRecord)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_inspectiondefinition`|
|ReferencedAttribute|`msdyn_inspectiondefinitionid`|
|ReferencingAttribute|`baserecordid`|
|ReferencingEntityNavigationPropertyName|`baserecordid_msdyn_inspectiondefinition`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_inspectiondefinition_DuplicateMatchingRecord"></a> msdyn_inspectiondefinition_DuplicateMatchingRecord

One-To-Many Relationship: [msdyn_inspectiondefinition msdyn_inspectiondefinition_DuplicateMatchingRecord](msdyn_inspectiondefinition.md#BKMK_msdyn_inspectiondefinition_DuplicateMatchingRecord)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_inspectiondefinition`|
|ReferencedAttribute|`msdyn_inspectiondefinitionid`|
|ReferencingAttribute|`duplicaterecordid`|
|ReferencingEntityNavigationPropertyName|`duplicaterecordid_msdyn_inspectiondefinition`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_inspectioninstance_DuplicateBaseRecord"></a> msdyn_inspectioninstance_DuplicateBaseRecord

One-To-Many Relationship: [msdyn_inspectioninstance msdyn_inspectioninstance_DuplicateBaseRecord](msdyn_inspectioninstance.md#BKMK_msdyn_inspectioninstance_DuplicateBaseRecord)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_inspectioninstance`|
|ReferencedAttribute|`msdyn_inspectioninstanceid`|
|ReferencingAttribute|`baserecordid`|
|ReferencingEntityNavigationPropertyName|`baserecordid_msdyn_inspectioninstance`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_inspectioninstance_DuplicateMatchingRecord"></a> msdyn_inspectioninstance_DuplicateMatchingRecord

One-To-Many Relationship: [msdyn_inspectioninstance msdyn_inspectioninstance_DuplicateMatchingRecord](msdyn_inspectioninstance.md#BKMK_msdyn_inspectioninstance_DuplicateMatchingRecord)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_inspectioninstance`|
|ReferencedAttribute|`msdyn_inspectioninstanceid`|
|ReferencingAttribute|`duplicaterecordid`|
|ReferencingEntityNavigationPropertyName|`duplicaterecordid_msdyn_inspectioninstance`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_inspectionresponse_DuplicateBaseRecord"></a> msdyn_inspectionresponse_DuplicateBaseRecord

One-To-Many Relationship: [msdyn_inspectionresponse msdyn_inspectionresponse_DuplicateBaseRecord](msdyn_inspectionresponse.md#BKMK_msdyn_inspectionresponse_DuplicateBaseRecord)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_inspectionresponse`|
|ReferencedAttribute|`msdyn_inspectionresponseid`|
|ReferencingAttribute|`baserecordid`|
|ReferencingEntityNavigationPropertyName|`baserecordid_msdyn_inspectionresponse`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_inspectionresponse_DuplicateMatchingRecord"></a> msdyn_inspectionresponse_DuplicateMatchingRecord

One-To-Many Relationship: [msdyn_inspectionresponse msdyn_inspectionresponse_DuplicateMatchingRecord](msdyn_inspectionresponse.md#BKMK_msdyn_inspectionresponse_DuplicateMatchingRecord)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_inspectionresponse`|
|ReferencedAttribute|`msdyn_inspectionresponseid`|
|ReferencingAttribute|`duplicaterecordid`|
|ReferencingEntityNavigationPropertyName|`duplicaterecordid_msdyn_inspectionresponse`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_insurance_DuplicateBaseRecord"></a> msdyn_insurance_DuplicateBaseRecord

One-To-Many Relationship: [msdyn_insurance msdyn_insurance_DuplicateBaseRecord](msdyn_insurance.md#BKMK_msdyn_insurance_DuplicateBaseRecord)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_insurance`|
|ReferencedAttribute|`msdyn_insuranceid`|
|ReferencingAttribute|`baserecordid`|
|ReferencingEntityNavigationPropertyName|`baserecordid_msdyn_insurance`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_insurance_DuplicateMatchingRecord"></a> msdyn_insurance_DuplicateMatchingRecord

One-To-Many Relationship: [msdyn_insurance msdyn_insurance_DuplicateMatchingRecord](msdyn_insurance.md#BKMK_msdyn_insurance_DuplicateMatchingRecord)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_insurance`|
|ReferencedAttribute|`msdyn_insuranceid`|
|ReferencingAttribute|`duplicaterecordid`|
|ReferencingEntityNavigationPropertyName|`duplicaterecordid_msdyn_insurance`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_inventoryadjustment_DuplicateBaseRecord"></a> msdyn_inventoryadjustment_DuplicateBaseRecord

One-To-Many Relationship: [msdyn_inventoryadjustment msdyn_inventoryadjustment_DuplicateBaseRecord](msdyn_inventoryadjustment.md#BKMK_msdyn_inventoryadjustment_DuplicateBaseRecord)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_inventoryadjustment`|
|ReferencedAttribute|`msdyn_inventoryadjustmentid`|
|ReferencingAttribute|`baserecordid`|
|ReferencingEntityNavigationPropertyName|`baserecordid_msdyn_inventoryadjustment`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_inventoryadjustment_DuplicateMatchingRecord"></a> msdyn_inventoryadjustment_DuplicateMatchingRecord

One-To-Many Relationship: [msdyn_inventoryadjustment msdyn_inventoryadjustment_DuplicateMatchingRecord](msdyn_inventoryadjustment.md#BKMK_msdyn_inventoryadjustment_DuplicateMatchingRecord)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_inventoryadjustment`|
|ReferencedAttribute|`msdyn_inventoryadjustmentid`|
|ReferencingAttribute|`duplicaterecordid`|
|ReferencingEntityNavigationPropertyName|`duplicaterecordid_msdyn_inventoryadjustment`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_inventoryadjustmentproduct_DuplicateBaseRecord"></a> msdyn_inventoryadjustmentproduct_DuplicateBaseRecord

One-To-Many Relationship: [msdyn_inventoryadjustmentproduct msdyn_inventoryadjustmentproduct_DuplicateBaseRecord](msdyn_inventoryadjustmentproduct.md#BKMK_msdyn_inventoryadjustmentproduct_DuplicateBaseRecord)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_inventoryadjustmentproduct`|
|ReferencedAttribute|`msdyn_inventoryadjustmentproductid`|
|ReferencingAttribute|`baserecordid`|
|ReferencingEntityNavigationPropertyName|`baserecordid_msdyn_inventoryadjustmentproduct`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_inventoryadjustmentproduct_DuplicateMatchingRecord"></a> msdyn_inventoryadjustmentproduct_DuplicateMatchingRecord

One-To-Many Relationship: [msdyn_inventoryadjustmentproduct msdyn_inventoryadjustmentproduct_DuplicateMatchingRecord](msdyn_inventoryadjustmentproduct.md#BKMK_msdyn_inventoryadjustmentproduct_DuplicateMatchingRecord)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_inventoryadjustmentproduct`|
|ReferencedAttribute|`msdyn_inventoryadjustmentproductid`|
|ReferencingAttribute|`duplicaterecordid`|
|ReferencingEntityNavigationPropertyName|`duplicaterecordid_msdyn_inventoryadjustmentproduct`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_inventoryjournal_DuplicateBaseRecord"></a> msdyn_inventoryjournal_DuplicateBaseRecord

One-To-Many Relationship: [msdyn_inventoryjournal msdyn_inventoryjournal_DuplicateBaseRecord](msdyn_inventoryjournal.md#BKMK_msdyn_inventoryjournal_DuplicateBaseRecord)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_inventoryjournal`|
|ReferencedAttribute|`msdyn_inventoryjournalid`|
|ReferencingAttribute|`baserecordid`|
|ReferencingEntityNavigationPropertyName|`baserecordid_msdyn_inventoryjournal`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_inventoryjournal_DuplicateMatchingRecord"></a> msdyn_inventoryjournal_DuplicateMatchingRecord

One-To-Many Relationship: [msdyn_inventoryjournal msdyn_inventoryjournal_DuplicateMatchingRecord](msdyn_inventoryjournal.md#BKMK_msdyn_inventoryjournal_DuplicateMatchingRecord)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_inventoryjournal`|
|ReferencedAttribute|`msdyn_inventoryjournalid`|
|ReferencingAttribute|`duplicaterecordid`|
|ReferencingEntityNavigationPropertyName|`duplicaterecordid_msdyn_inventoryjournal`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_inventorytransfer_DuplicateBaseRecord"></a> msdyn_inventorytransfer_DuplicateBaseRecord

One-To-Many Relationship: [msdyn_inventorytransfer msdyn_inventorytransfer_DuplicateBaseRecord](msdyn_inventorytransfer.md#BKMK_msdyn_inventorytransfer_DuplicateBaseRecord)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_inventorytransfer`|
|ReferencedAttribute|`msdyn_inventorytransferid`|
|ReferencingAttribute|`baserecordid`|
|ReferencingEntityNavigationPropertyName|`baserecordid_msdyn_inventorytransfer`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_inventorytransfer_DuplicateMatchingRecord"></a> msdyn_inventorytransfer_DuplicateMatchingRecord

One-To-Many Relationship: [msdyn_inventorytransfer msdyn_inventorytransfer_DuplicateMatchingRecord](msdyn_inventorytransfer.md#BKMK_msdyn_inventorytransfer_DuplicateMatchingRecord)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_inventorytransfer`|
|ReferencedAttribute|`msdyn_inventorytransferid`|
|ReferencingAttribute|`duplicaterecordid`|
|ReferencingEntityNavigationPropertyName|`duplicaterecordid_msdyn_inventorytransfer`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_mobilesource_DuplicateBaseRecord"></a> msdyn_mobilesource_DuplicateBaseRecord

One-To-Many Relationship: [msdyn_mobilesource msdyn_mobilesource_DuplicateBaseRecord](msdyn_mobilesource.md#BKMK_msdyn_mobilesource_DuplicateBaseRecord)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_mobilesource`|
|ReferencedAttribute|`msdyn_mobilesourceid`|
|ReferencingAttribute|`baserecordid`|
|ReferencingEntityNavigationPropertyName|`baserecordid_msdyn_mobilesource`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_mobilesource_DuplicateMatchingRecord"></a> msdyn_mobilesource_DuplicateMatchingRecord

One-To-Many Relationship: [msdyn_mobilesource msdyn_mobilesource_DuplicateMatchingRecord](msdyn_mobilesource.md#BKMK_msdyn_mobilesource_DuplicateMatchingRecord)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_mobilesource`|
|ReferencedAttribute|`msdyn_mobilesourceid`|
|ReferencingAttribute|`duplicaterecordid`|
|ReferencingEntityNavigationPropertyName|`duplicaterecordid_msdyn_mobilesource`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_nottoexceed_DuplicateBaseRecord"></a> msdyn_nottoexceed_DuplicateBaseRecord

One-To-Many Relationship: [msdyn_nottoexceed msdyn_nottoexceed_DuplicateBaseRecord](msdyn_nottoexceed.md#BKMK_msdyn_nottoexceed_DuplicateBaseRecord)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_nottoexceed`|
|ReferencedAttribute|`msdyn_nottoexceedid`|
|ReferencingAttribute|`baserecordid`|
|ReferencingEntityNavigationPropertyName|`baserecordid_msdyn_nottoexceed`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_nottoexceed_DuplicateMatchingRecord"></a> msdyn_nottoexceed_DuplicateMatchingRecord

One-To-Many Relationship: [msdyn_nottoexceed msdyn_nottoexceed_DuplicateMatchingRecord](msdyn_nottoexceed.md#BKMK_msdyn_nottoexceed_DuplicateMatchingRecord)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_nottoexceed`|
|ReferencedAttribute|`msdyn_nottoexceedid`|
|ReferencingAttribute|`duplicaterecordid`|
|ReferencingEntityNavigationPropertyName|`duplicaterecordid_msdyn_nottoexceed`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_orderinvoicingdate_DuplicateBaseRecord"></a> msdyn_orderinvoicingdate_DuplicateBaseRecord

One-To-Many Relationship: [msdyn_orderinvoicingdate msdyn_orderinvoicingdate_DuplicateBaseRecord](msdyn_orderinvoicingdate.md#BKMK_msdyn_orderinvoicingdate_DuplicateBaseRecord)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_orderinvoicingdate`|
|ReferencedAttribute|`msdyn_orderinvoicingdateid`|
|ReferencingAttribute|`baserecordid`|
|ReferencingEntityNavigationPropertyName|`baserecordid_msdyn_orderinvoicingdate`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_orderinvoicingdate_DuplicateMatchingRecord"></a> msdyn_orderinvoicingdate_DuplicateMatchingRecord

One-To-Many Relationship: [msdyn_orderinvoicingdate msdyn_orderinvoicingdate_DuplicateMatchingRecord](msdyn_orderinvoicingdate.md#BKMK_msdyn_orderinvoicingdate_DuplicateMatchingRecord)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_orderinvoicingdate`|
|ReferencedAttribute|`msdyn_orderinvoicingdateid`|
|ReferencingAttribute|`duplicaterecordid`|
|ReferencingEntityNavigationPropertyName|`duplicaterecordid_msdyn_orderinvoicingdate`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_orderinvoicingproduct_DuplicateBaseRecord"></a> msdyn_orderinvoicingproduct_DuplicateBaseRecord

One-To-Many Relationship: [msdyn_orderinvoicingproduct msdyn_orderinvoicingproduct_DuplicateBaseRecord](msdyn_orderinvoicingproduct.md#BKMK_msdyn_orderinvoicingproduct_DuplicateBaseRecord)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_orderinvoicingproduct`|
|ReferencedAttribute|`msdyn_orderinvoicingproductid`|
|ReferencingAttribute|`baserecordid`|
|ReferencingEntityNavigationPropertyName|`baserecordid_msdyn_orderinvoicingproduct`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_orderinvoicingproduct_DuplicateMatchingRecord"></a> msdyn_orderinvoicingproduct_DuplicateMatchingRecord

One-To-Many Relationship: [msdyn_orderinvoicingproduct msdyn_orderinvoicingproduct_DuplicateMatchingRecord](msdyn_orderinvoicingproduct.md#BKMK_msdyn_orderinvoicingproduct_DuplicateMatchingRecord)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_orderinvoicingproduct`|
|ReferencedAttribute|`msdyn_orderinvoicingproductid`|
|ReferencingAttribute|`duplicaterecordid`|
|ReferencingEntityNavigationPropertyName|`duplicaterecordid_msdyn_orderinvoicingproduct`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_orderinvoicingsetup_DuplicateBaseRecord"></a> msdyn_orderinvoicingsetup_DuplicateBaseRecord

One-To-Many Relationship: [msdyn_orderinvoicingsetup msdyn_orderinvoicingsetup_DuplicateBaseRecord](msdyn_orderinvoicingsetup.md#BKMK_msdyn_orderinvoicingsetup_DuplicateBaseRecord)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_orderinvoicingsetup`|
|ReferencedAttribute|`msdyn_orderinvoicingsetupid`|
|ReferencingAttribute|`baserecordid`|
|ReferencingEntityNavigationPropertyName|`baserecordid_msdyn_orderinvoicingsetup`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_orderinvoicingsetup_DuplicateMatchingRecord"></a> msdyn_orderinvoicingsetup_DuplicateMatchingRecord

One-To-Many Relationship: [msdyn_orderinvoicingsetup msdyn_orderinvoicingsetup_DuplicateMatchingRecord](msdyn_orderinvoicingsetup.md#BKMK_msdyn_orderinvoicingsetup_DuplicateMatchingRecord)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_orderinvoicingsetup`|
|ReferencedAttribute|`msdyn_orderinvoicingsetupid`|
|ReferencingAttribute|`duplicaterecordid`|
|ReferencingEntityNavigationPropertyName|`duplicaterecordid_msdyn_orderinvoicingsetup`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_orderinvoicingsetupdate_DuplicateBaseRecord"></a> msdyn_orderinvoicingsetupdate_DuplicateBaseRecord

One-To-Many Relationship: [msdyn_orderinvoicingsetupdate msdyn_orderinvoicingsetupdate_DuplicateBaseRecord](msdyn_orderinvoicingsetupdate.md#BKMK_msdyn_orderinvoicingsetupdate_DuplicateBaseRecord)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_orderinvoicingsetupdate`|
|ReferencedAttribute|`msdyn_orderinvoicingsetupdateid`|
|ReferencingAttribute|`baserecordid`|
|ReferencingEntityNavigationPropertyName|`baserecordid_msdyn_orderinvoicingsetupdate`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_orderinvoicingsetupdate_DuplicateMatchingRecord"></a> msdyn_orderinvoicingsetupdate_DuplicateMatchingRecord

One-To-Many Relationship: [msdyn_orderinvoicingsetupdate msdyn_orderinvoicingsetupdate_DuplicateMatchingRecord](msdyn_orderinvoicingsetupdate.md#BKMK_msdyn_orderinvoicingsetupdate_DuplicateMatchingRecord)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_orderinvoicingsetupdate`|
|ReferencedAttribute|`msdyn_orderinvoicingsetupdateid`|
|ReferencingAttribute|`duplicaterecordid`|
|ReferencingEntityNavigationPropertyName|`duplicaterecordid_msdyn_orderinvoicingsetupdate`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_organizationalunit_DuplicateBaseRecord"></a> msdyn_organizationalunit_DuplicateBaseRecord

One-To-Many Relationship: [msdyn_organizationalunit msdyn_organizationalunit_DuplicateBaseRecord](msdyn_organizationalunit.md#BKMK_msdyn_organizationalunit_DuplicateBaseRecord)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_organizationalunit`|
|ReferencedAttribute|`msdyn_organizationalunitid`|
|ReferencingAttribute|`baserecordid`|
|ReferencingEntityNavigationPropertyName|`baserecordid_msdyn_organizationalunit`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_organizationalunit_DuplicateMatchingRecord"></a> msdyn_organizationalunit_DuplicateMatchingRecord

One-To-Many Relationship: [msdyn_organizationalunit msdyn_organizationalunit_DuplicateMatchingRecord](msdyn_organizationalunit.md#BKMK_msdyn_organizationalunit_DuplicateMatchingRecord)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_organizationalunit`|
|ReferencedAttribute|`msdyn_organizationalunitid`|
|ReferencingAttribute|`duplicaterecordid`|
|ReferencingEntityNavigationPropertyName|`duplicaterecordid_msdyn_organizationalunit`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_payment_DuplicateBaseRecord"></a> msdyn_payment_DuplicateBaseRecord

One-To-Many Relationship: [msdyn_payment msdyn_payment_DuplicateBaseRecord](msdyn_payment.md#BKMK_msdyn_payment_DuplicateBaseRecord)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_payment`|
|ReferencedAttribute|`msdyn_paymentid`|
|ReferencingAttribute|`baserecordid`|
|ReferencingEntityNavigationPropertyName|`baserecordid_msdyn_payment`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_payment_DuplicateMatchingRecord"></a> msdyn_payment_DuplicateMatchingRecord

One-To-Many Relationship: [msdyn_payment msdyn_payment_DuplicateMatchingRecord](msdyn_payment.md#BKMK_msdyn_payment_DuplicateMatchingRecord)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_payment`|
|ReferencedAttribute|`msdyn_paymentid`|
|ReferencingAttribute|`duplicaterecordid`|
|ReferencingEntityNavigationPropertyName|`duplicaterecordid_msdyn_payment`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_paymentdetail_DuplicateBaseRecord"></a> msdyn_paymentdetail_DuplicateBaseRecord

One-To-Many Relationship: [msdyn_paymentdetail msdyn_paymentdetail_DuplicateBaseRecord](msdyn_paymentdetail.md#BKMK_msdyn_paymentdetail_DuplicateBaseRecord)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_paymentdetail`|
|ReferencedAttribute|`msdyn_paymentdetailid`|
|ReferencingAttribute|`baserecordid`|
|ReferencingEntityNavigationPropertyName|`baserecordid_msdyn_paymentdetail`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_paymentdetail_DuplicateMatchingRecord"></a> msdyn_paymentdetail_DuplicateMatchingRecord

One-To-Many Relationship: [msdyn_paymentdetail msdyn_paymentdetail_DuplicateMatchingRecord](msdyn_paymentdetail.md#BKMK_msdyn_paymentdetail_DuplicateMatchingRecord)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_paymentdetail`|
|ReferencedAttribute|`msdyn_paymentdetailid`|
|ReferencingAttribute|`duplicaterecordid`|
|ReferencingEntityNavigationPropertyName|`duplicaterecordid_msdyn_paymentdetail`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_paymentmethod_DuplicateBaseRecord"></a> msdyn_paymentmethod_DuplicateBaseRecord

One-To-Many Relationship: [msdyn_paymentmethod msdyn_paymentmethod_DuplicateBaseRecord](msdyn_paymentmethod.md#BKMK_msdyn_paymentmethod_DuplicateBaseRecord)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_paymentmethod`|
|ReferencedAttribute|`msdyn_paymentmethodid`|
|ReferencingAttribute|`baserecordid`|
|ReferencingEntityNavigationPropertyName|`baserecordid_msdyn_paymentmethod`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_paymentmethod_DuplicateMatchingRecord"></a> msdyn_paymentmethod_DuplicateMatchingRecord

One-To-Many Relationship: [msdyn_paymentmethod msdyn_paymentmethod_DuplicateMatchingRecord](msdyn_paymentmethod.md#BKMK_msdyn_paymentmethod_DuplicateMatchingRecord)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_paymentmethod`|
|ReferencedAttribute|`msdyn_paymentmethodid`|
|ReferencingAttribute|`duplicaterecordid`|
|ReferencingEntityNavigationPropertyName|`duplicaterecordid_msdyn_paymentmethod`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_paymentterm_DuplicateBaseRecord"></a> msdyn_paymentterm_DuplicateBaseRecord

One-To-Many Relationship: [msdyn_paymentterm msdyn_paymentterm_DuplicateBaseRecord](msdyn_paymentterm.md#BKMK_msdyn_paymentterm_DuplicateBaseRecord)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_paymentterm`|
|ReferencedAttribute|`msdyn_paymenttermid`|
|ReferencingAttribute|`baserecordid`|
|ReferencingEntityNavigationPropertyName|`baserecordid_msdyn_paymentterm`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_paymentterm_DuplicateMatchingRecord"></a> msdyn_paymentterm_DuplicateMatchingRecord

One-To-Many Relationship: [msdyn_paymentterm msdyn_paymentterm_DuplicateMatchingRecord](msdyn_paymentterm.md#BKMK_msdyn_paymentterm_DuplicateMatchingRecord)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_paymentterm`|
|ReferencedAttribute|`msdyn_paymenttermid`|
|ReferencingAttribute|`duplicaterecordid`|
|ReferencingEntityNavigationPropertyName|`duplicaterecordid_msdyn_paymentterm`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_postalcode_DuplicateBaseRecord"></a> msdyn_postalcode_DuplicateBaseRecord

One-To-Many Relationship: [msdyn_postalcode msdyn_postalcode_DuplicateBaseRecord](msdyn_postalcode.md#BKMK_msdyn_postalcode_DuplicateBaseRecord)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_postalcode`|
|ReferencedAttribute|`msdyn_postalcodeid`|
|ReferencingAttribute|`baserecordid`|
|ReferencingEntityNavigationPropertyName|`baserecordid_msdyn_postalcode`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_postalcode_DuplicateMatchingRecord"></a> msdyn_postalcode_DuplicateMatchingRecord

One-To-Many Relationship: [msdyn_postalcode msdyn_postalcode_DuplicateMatchingRecord](msdyn_postalcode.md#BKMK_msdyn_postalcode_DuplicateMatchingRecord)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_postalcode`|
|ReferencedAttribute|`msdyn_postalcodeid`|
|ReferencingAttribute|`duplicaterecordid`|
|ReferencingEntityNavigationPropertyName|`duplicaterecordid_msdyn_postalcode`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_priority_DuplicateBaseRecord"></a> msdyn_priority_DuplicateBaseRecord

One-To-Many Relationship: [msdyn_priority msdyn_priority_DuplicateBaseRecord](msdyn_priority.md#BKMK_msdyn_priority_DuplicateBaseRecord)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_priority`|
|ReferencedAttribute|`msdyn_priorityid`|
|ReferencingAttribute|`baserecordid`|
|ReferencingEntityNavigationPropertyName|`baserecordid_msdyn_priority`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_priority_DuplicateMatchingRecord"></a> msdyn_priority_DuplicateMatchingRecord

One-To-Many Relationship: [msdyn_priority msdyn_priority_DuplicateMatchingRecord](msdyn_priority.md#BKMK_msdyn_priority_DuplicateMatchingRecord)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_priority`|
|ReferencedAttribute|`msdyn_priorityid`|
|ReferencingAttribute|`duplicaterecordid`|
|ReferencingEntityNavigationPropertyName|`duplicaterecordid_msdyn_priority`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_problematicasset_DuplicateBaseRecord"></a> msdyn_problematicasset_DuplicateBaseRecord

One-To-Many Relationship: [msdyn_problematicasset msdyn_problematicasset_DuplicateBaseRecord](msdyn_problematicasset.md#BKMK_msdyn_problematicasset_DuplicateBaseRecord)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_problematicasset`|
|ReferencedAttribute|`msdyn_problematicassetid`|
|ReferencingAttribute|`baserecordid`|
|ReferencingEntityNavigationPropertyName|`baserecordid_msdyn_problematicasset`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_problematicasset_DuplicateMatchingRecord"></a> msdyn_problematicasset_DuplicateMatchingRecord

One-To-Many Relationship: [msdyn_problematicasset msdyn_problematicasset_DuplicateMatchingRecord](msdyn_problematicasset.md#BKMK_msdyn_problematicasset_DuplicateMatchingRecord)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_problematicasset`|
|ReferencedAttribute|`msdyn_problematicassetid`|
|ReferencingAttribute|`duplicaterecordid`|
|ReferencingEntityNavigationPropertyName|`duplicaterecordid_msdyn_problematicasset`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_problematicassetfeedback_DuplicateBaseRecord"></a> msdyn_problematicassetfeedback_DuplicateBaseRecord

One-To-Many Relationship: [msdyn_problematicassetfeedback msdyn_problematicassetfeedback_DuplicateBaseRecord](msdyn_problematicassetfeedback.md#BKMK_msdyn_problematicassetfeedback_DuplicateBaseRecord)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_problematicassetfeedback`|
|ReferencedAttribute|`msdyn_problematicassetfeedbackid`|
|ReferencingAttribute|`baserecordid`|
|ReferencingEntityNavigationPropertyName|`baserecordid_msdyn_problematicassetfeedback`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_problematicassetfeedback_DuplicateMatchingRecord"></a> msdyn_problematicassetfeedback_DuplicateMatchingRecord

One-To-Many Relationship: [msdyn_problematicassetfeedback msdyn_problematicassetfeedback_DuplicateMatchingRecord](msdyn_problematicassetfeedback.md#BKMK_msdyn_problematicassetfeedback_DuplicateMatchingRecord)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_problematicassetfeedback`|
|ReferencedAttribute|`msdyn_problematicassetfeedbackid`|
|ReferencingAttribute|`duplicaterecordid`|
|ReferencingEntityNavigationPropertyName|`duplicaterecordid_msdyn_problematicassetfeedback`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_productinventory_DuplicateBaseRecord"></a> msdyn_productinventory_DuplicateBaseRecord

One-To-Many Relationship: [msdyn_productinventory msdyn_productinventory_DuplicateBaseRecord](msdyn_productinventory.md#BKMK_msdyn_productinventory_DuplicateBaseRecord)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_productinventory`|
|ReferencedAttribute|`msdyn_productinventoryid`|
|ReferencingAttribute|`baserecordid`|
|ReferencingEntityNavigationPropertyName|`baserecordid_msdyn_productinventory`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_productinventory_DuplicateMatchingRecord"></a> msdyn_productinventory_DuplicateMatchingRecord

One-To-Many Relationship: [msdyn_productinventory msdyn_productinventory_DuplicateMatchingRecord](msdyn_productinventory.md#BKMK_msdyn_productinventory_DuplicateMatchingRecord)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_productinventory`|
|ReferencedAttribute|`msdyn_productinventoryid`|
|ReferencingAttribute|`duplicaterecordid`|
|ReferencingEntityNavigationPropertyName|`duplicaterecordid_msdyn_productinventory`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_purchaseorder_DuplicateBaseRecord"></a> msdyn_purchaseorder_DuplicateBaseRecord

One-To-Many Relationship: [msdyn_purchaseorder msdyn_purchaseorder_DuplicateBaseRecord](msdyn_purchaseorder.md#BKMK_msdyn_purchaseorder_DuplicateBaseRecord)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_purchaseorder`|
|ReferencedAttribute|`msdyn_purchaseorderid`|
|ReferencingAttribute|`baserecordid`|
|ReferencingEntityNavigationPropertyName|`baserecordid_msdyn_purchaseorder`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_purchaseorder_DuplicateMatchingRecord"></a> msdyn_purchaseorder_DuplicateMatchingRecord

One-To-Many Relationship: [msdyn_purchaseorder msdyn_purchaseorder_DuplicateMatchingRecord](msdyn_purchaseorder.md#BKMK_msdyn_purchaseorder_DuplicateMatchingRecord)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_purchaseorder`|
|ReferencedAttribute|`msdyn_purchaseorderid`|
|ReferencingAttribute|`duplicaterecordid`|
|ReferencingEntityNavigationPropertyName|`duplicaterecordid_msdyn_purchaseorder`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_purchaseorderbill_DuplicateBaseRecord"></a> msdyn_purchaseorderbill_DuplicateBaseRecord

One-To-Many Relationship: [msdyn_purchaseorderbill msdyn_purchaseorderbill_DuplicateBaseRecord](msdyn_purchaseorderbill.md#BKMK_msdyn_purchaseorderbill_DuplicateBaseRecord)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_purchaseorderbill`|
|ReferencedAttribute|`msdyn_purchaseorderbillid`|
|ReferencingAttribute|`baserecordid`|
|ReferencingEntityNavigationPropertyName|`baserecordid_msdyn_purchaseorderbill`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_purchaseorderbill_DuplicateMatchingRecord"></a> msdyn_purchaseorderbill_DuplicateMatchingRecord

One-To-Many Relationship: [msdyn_purchaseorderbill msdyn_purchaseorderbill_DuplicateMatchingRecord](msdyn_purchaseorderbill.md#BKMK_msdyn_purchaseorderbill_DuplicateMatchingRecord)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_purchaseorderbill`|
|ReferencedAttribute|`msdyn_purchaseorderbillid`|
|ReferencingAttribute|`duplicaterecordid`|
|ReferencingEntityNavigationPropertyName|`duplicaterecordid_msdyn_purchaseorderbill`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_purchaseorderreceipt_DuplicateBaseRecord"></a> msdyn_purchaseorderreceipt_DuplicateBaseRecord

One-To-Many Relationship: [msdyn_purchaseorderreceipt msdyn_purchaseorderreceipt_DuplicateBaseRecord](msdyn_purchaseorderreceipt.md#BKMK_msdyn_purchaseorderreceipt_DuplicateBaseRecord)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_purchaseorderreceipt`|
|ReferencedAttribute|`msdyn_purchaseorderreceiptid`|
|ReferencingAttribute|`baserecordid`|
|ReferencingEntityNavigationPropertyName|`baserecordid_msdyn_purchaseorderreceipt`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_purchaseorderreceipt_DuplicateMatchingRecord"></a> msdyn_purchaseorderreceipt_DuplicateMatchingRecord

One-To-Many Relationship: [msdyn_purchaseorderreceipt msdyn_purchaseorderreceipt_DuplicateMatchingRecord](msdyn_purchaseorderreceipt.md#BKMK_msdyn_purchaseorderreceipt_DuplicateMatchingRecord)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_purchaseorderreceipt`|
|ReferencedAttribute|`msdyn_purchaseorderreceiptid`|
|ReferencingAttribute|`duplicaterecordid`|
|ReferencingEntityNavigationPropertyName|`duplicaterecordid_msdyn_purchaseorderreceipt`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_purchaseorderreceiptproduct_DuplicateBaseRecord"></a> msdyn_purchaseorderreceiptproduct_DuplicateBaseRecord

One-To-Many Relationship: [msdyn_purchaseorderreceiptproduct msdyn_purchaseorderreceiptproduct_DuplicateBaseRecord](msdyn_purchaseorderreceiptproduct.md#BKMK_msdyn_purchaseorderreceiptproduct_DuplicateBaseRecord)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_purchaseorderreceiptproduct`|
|ReferencedAttribute|`msdyn_purchaseorderreceiptproductid`|
|ReferencingAttribute|`baserecordid`|
|ReferencingEntityNavigationPropertyName|`baserecordid_msdyn_purchaseorderreceiptproduct`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_purchaseorderreceiptproduct_DuplicateMatchingRecord"></a> msdyn_purchaseorderreceiptproduct_DuplicateMatchingRecord

One-To-Many Relationship: [msdyn_purchaseorderreceiptproduct msdyn_purchaseorderreceiptproduct_DuplicateMatchingRecord](msdyn_purchaseorderreceiptproduct.md#BKMK_msdyn_purchaseorderreceiptproduct_DuplicateMatchingRecord)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_purchaseorderreceiptproduct`|
|ReferencedAttribute|`msdyn_purchaseorderreceiptproductid`|
|ReferencingAttribute|`duplicaterecordid`|
|ReferencingEntityNavigationPropertyName|`duplicaterecordid_msdyn_purchaseorderreceiptproduct`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_purchaseordersubstatus_DuplicateBaseRecord"></a> msdyn_purchaseordersubstatus_DuplicateBaseRecord

One-To-Many Relationship: [msdyn_purchaseordersubstatus msdyn_purchaseordersubstatus_DuplicateBaseRecord](msdyn_purchaseordersubstatus.md#BKMK_msdyn_purchaseordersubstatus_DuplicateBaseRecord)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_purchaseordersubstatus`|
|ReferencedAttribute|`msdyn_purchaseordersubstatusid`|
|ReferencingAttribute|`baserecordid`|
|ReferencingEntityNavigationPropertyName|`baserecordid_msdyn_purchaseordersubstatus`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_purchaseordersubstatus_DuplicateMatchingRecord"></a> msdyn_purchaseordersubstatus_DuplicateMatchingRecord

One-To-Many Relationship: [msdyn_purchaseordersubstatus msdyn_purchaseordersubstatus_DuplicateMatchingRecord](msdyn_purchaseordersubstatus.md#BKMK_msdyn_purchaseordersubstatus_DuplicateMatchingRecord)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_purchaseordersubstatus`|
|ReferencedAttribute|`msdyn_purchaseordersubstatusid`|
|ReferencingAttribute|`duplicaterecordid`|
|ReferencingEntityNavigationPropertyName|`duplicaterecordid_msdyn_purchaseordersubstatus`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_quotebookingincident_DuplicateBaseRecord"></a> msdyn_quotebookingincident_DuplicateBaseRecord

One-To-Many Relationship: [msdyn_quotebookingincident msdyn_quotebookingincident_DuplicateBaseRecord](msdyn_quotebookingincident.md#BKMK_msdyn_quotebookingincident_DuplicateBaseRecord)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_quotebookingincident`|
|ReferencedAttribute|`msdyn_quotebookingincidentid`|
|ReferencingAttribute|`baserecordid`|
|ReferencingEntityNavigationPropertyName|`baserecordid_msdyn_quotebookingincident`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_quotebookingincident_DuplicateMatchingRecord"></a> msdyn_quotebookingincident_DuplicateMatchingRecord

One-To-Many Relationship: [msdyn_quotebookingincident msdyn_quotebookingincident_DuplicateMatchingRecord](msdyn_quotebookingincident.md#BKMK_msdyn_quotebookingincident_DuplicateMatchingRecord)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_quotebookingincident`|
|ReferencedAttribute|`msdyn_quotebookingincidentid`|
|ReferencingAttribute|`duplicaterecordid`|
|ReferencingEntityNavigationPropertyName|`duplicaterecordid_msdyn_quotebookingincident`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_quotebookingproduct_DuplicateBaseRecord"></a> msdyn_quotebookingproduct_DuplicateBaseRecord

One-To-Many Relationship: [msdyn_quotebookingproduct msdyn_quotebookingproduct_DuplicateBaseRecord](msdyn_quotebookingproduct.md#BKMK_msdyn_quotebookingproduct_DuplicateBaseRecord)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_quotebookingproduct`|
|ReferencedAttribute|`msdyn_quotebookingproductid`|
|ReferencingAttribute|`baserecordid`|
|ReferencingEntityNavigationPropertyName|`baserecordid_msdyn_quotebookingproduct`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_quotebookingproduct_DuplicateMatchingRecord"></a> msdyn_quotebookingproduct_DuplicateMatchingRecord

One-To-Many Relationship: [msdyn_quotebookingproduct msdyn_quotebookingproduct_DuplicateMatchingRecord](msdyn_quotebookingproduct.md#BKMK_msdyn_quotebookingproduct_DuplicateMatchingRecord)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_quotebookingproduct`|
|ReferencedAttribute|`msdyn_quotebookingproductid`|
|ReferencingAttribute|`duplicaterecordid`|
|ReferencingEntityNavigationPropertyName|`duplicaterecordid_msdyn_quotebookingproduct`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_quotebookingservice_DuplicateBaseRecord"></a> msdyn_quotebookingservice_DuplicateBaseRecord

One-To-Many Relationship: [msdyn_quotebookingservice msdyn_quotebookingservice_DuplicateBaseRecord](msdyn_quotebookingservice.md#BKMK_msdyn_quotebookingservice_DuplicateBaseRecord)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_quotebookingservice`|
|ReferencedAttribute|`msdyn_quotebookingserviceid`|
|ReferencingAttribute|`baserecordid`|
|ReferencingEntityNavigationPropertyName|`baserecordid_msdyn_quotebookingservice`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_quotebookingservice_DuplicateMatchingRecord"></a> msdyn_quotebookingservice_DuplicateMatchingRecord

One-To-Many Relationship: [msdyn_quotebookingservice msdyn_quotebookingservice_DuplicateMatchingRecord](msdyn_quotebookingservice.md#BKMK_msdyn_quotebookingservice_DuplicateMatchingRecord)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_quotebookingservice`|
|ReferencedAttribute|`msdyn_quotebookingserviceid`|
|ReferencingAttribute|`duplicaterecordid`|
|ReferencingEntityNavigationPropertyName|`duplicaterecordid_msdyn_quotebookingservice`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_quotebookingservicetask_DuplicateBaseRecord"></a> msdyn_quotebookingservicetask_DuplicateBaseRecord

One-To-Many Relationship: [msdyn_quotebookingservicetask msdyn_quotebookingservicetask_DuplicateBaseRecord](msdyn_quotebookingservicetask.md#BKMK_msdyn_quotebookingservicetask_DuplicateBaseRecord)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_quotebookingservicetask`|
|ReferencedAttribute|`msdyn_quotebookingservicetaskid`|
|ReferencingAttribute|`baserecordid`|
|ReferencingEntityNavigationPropertyName|`baserecordid_msdyn_quotebookingservicetask`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_quotebookingservicetask_DuplicateMatchingRecord"></a> msdyn_quotebookingservicetask_DuplicateMatchingRecord

One-To-Many Relationship: [msdyn_quotebookingservicetask msdyn_quotebookingservicetask_DuplicateMatchingRecord](msdyn_quotebookingservicetask.md#BKMK_msdyn_quotebookingservicetask_DuplicateMatchingRecord)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_quotebookingservicetask`|
|ReferencedAttribute|`msdyn_quotebookingservicetaskid`|
|ReferencingAttribute|`duplicaterecordid`|
|ReferencingEntityNavigationPropertyName|`duplicaterecordid_msdyn_quotebookingservicetask`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_quotebookingsetup_DuplicateBaseRecord"></a> msdyn_quotebookingsetup_DuplicateBaseRecord

One-To-Many Relationship: [msdyn_quotebookingsetup msdyn_quotebookingsetup_DuplicateBaseRecord](msdyn_quotebookingsetup.md#BKMK_msdyn_quotebookingsetup_DuplicateBaseRecord)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_quotebookingsetup`|
|ReferencedAttribute|`msdyn_quotebookingsetupid`|
|ReferencingAttribute|`baserecordid`|
|ReferencingEntityNavigationPropertyName|`baserecordid_msdyn_quotebookingsetup`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_quotebookingsetup_DuplicateMatchingRecord"></a> msdyn_quotebookingsetup_DuplicateMatchingRecord

One-To-Many Relationship: [msdyn_quotebookingsetup msdyn_quotebookingsetup_DuplicateMatchingRecord](msdyn_quotebookingsetup.md#BKMK_msdyn_quotebookingsetup_DuplicateMatchingRecord)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_quotebookingsetup`|
|ReferencedAttribute|`msdyn_quotebookingsetupid`|
|ReferencingAttribute|`duplicaterecordid`|
|ReferencingEntityNavigationPropertyName|`duplicaterecordid_msdyn_quotebookingsetup`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_quoteinvoicingproduct_DuplicateBaseRecord"></a> msdyn_quoteinvoicingproduct_DuplicateBaseRecord

One-To-Many Relationship: [msdyn_quoteinvoicingproduct msdyn_quoteinvoicingproduct_DuplicateBaseRecord](msdyn_quoteinvoicingproduct.md#BKMK_msdyn_quoteinvoicingproduct_DuplicateBaseRecord)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_quoteinvoicingproduct`|
|ReferencedAttribute|`msdyn_quoteinvoicingproductid`|
|ReferencingAttribute|`baserecordid`|
|ReferencingEntityNavigationPropertyName|`baserecordid_msdyn_quoteinvoicingproduct`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_quoteinvoicingproduct_DuplicateMatchingRecord"></a> msdyn_quoteinvoicingproduct_DuplicateMatchingRecord

One-To-Many Relationship: [msdyn_quoteinvoicingproduct msdyn_quoteinvoicingproduct_DuplicateMatchingRecord](msdyn_quoteinvoicingproduct.md#BKMK_msdyn_quoteinvoicingproduct_DuplicateMatchingRecord)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_quoteinvoicingproduct`|
|ReferencedAttribute|`msdyn_quoteinvoicingproductid`|
|ReferencingAttribute|`duplicaterecordid`|
|ReferencingEntityNavigationPropertyName|`duplicaterecordid_msdyn_quoteinvoicingproduct`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_quoteinvoicingsetup_DuplicateBaseRecord"></a> msdyn_quoteinvoicingsetup_DuplicateBaseRecord

One-To-Many Relationship: [msdyn_quoteinvoicingsetup msdyn_quoteinvoicingsetup_DuplicateBaseRecord](msdyn_quoteinvoicingsetup.md#BKMK_msdyn_quoteinvoicingsetup_DuplicateBaseRecord)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_quoteinvoicingsetup`|
|ReferencedAttribute|`msdyn_quoteinvoicingsetupid`|
|ReferencingAttribute|`baserecordid`|
|ReferencingEntityNavigationPropertyName|`baserecordid_msdyn_quoteinvoicingsetup`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_quoteinvoicingsetup_DuplicateMatchingRecord"></a> msdyn_quoteinvoicingsetup_DuplicateMatchingRecord

One-To-Many Relationship: [msdyn_quoteinvoicingsetup msdyn_quoteinvoicingsetup_DuplicateMatchingRecord](msdyn_quoteinvoicingsetup.md#BKMK_msdyn_quoteinvoicingsetup_DuplicateMatchingRecord)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_quoteinvoicingsetup`|
|ReferencedAttribute|`msdyn_quoteinvoicingsetupid`|
|ReferencingAttribute|`duplicaterecordid`|
|ReferencingEntityNavigationPropertyName|`duplicaterecordid_msdyn_quoteinvoicingsetup`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_requirementcharacteristic_DuplicateBaseRecord"></a> msdyn_requirementcharacteristic_DuplicateBaseRecord

One-To-Many Relationship: [msdyn_requirementcharacteristic msdyn_requirementcharacteristic_DuplicateBaseRecord](msdyn_requirementcharacteristic.md#BKMK_msdyn_requirementcharacteristic_DuplicateBaseRecord)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_requirementcharacteristic`|
|ReferencedAttribute|`msdyn_requirementcharacteristicid`|
|ReferencingAttribute|`baserecordid`|
|ReferencingEntityNavigationPropertyName|`baserecordid_msdyn_requirementcharacteristic`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_requirementcharacteristic_DuplicateMatchingRecord"></a> msdyn_requirementcharacteristic_DuplicateMatchingRecord

One-To-Many Relationship: [msdyn_requirementcharacteristic msdyn_requirementcharacteristic_DuplicateMatchingRecord](msdyn_requirementcharacteristic.md#BKMK_msdyn_requirementcharacteristic_DuplicateMatchingRecord)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_requirementcharacteristic`|
|ReferencedAttribute|`msdyn_requirementcharacteristicid`|
|ReferencingAttribute|`duplicaterecordid`|
|ReferencingEntityNavigationPropertyName|`duplicaterecordid_msdyn_requirementcharacteristic`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_requirementdependency_DuplicateBaseRecord"></a> msdyn_requirementdependency_DuplicateBaseRecord

One-To-Many Relationship: [msdyn_requirementdependency msdyn_requirementdependency_DuplicateBaseRecord](msdyn_requirementdependency.md#BKMK_msdyn_requirementdependency_DuplicateBaseRecord)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_requirementdependency`|
|ReferencedAttribute|`msdyn_requirementdependencyid`|
|ReferencingAttribute|`baserecordid`|
|ReferencingEntityNavigationPropertyName|`baserecordid_msdyn_requirementdependency`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_requirementdependency_DuplicateMatchingRecord"></a> msdyn_requirementdependency_DuplicateMatchingRecord

One-To-Many Relationship: [msdyn_requirementdependency msdyn_requirementdependency_DuplicateMatchingRecord](msdyn_requirementdependency.md#BKMK_msdyn_requirementdependency_DuplicateMatchingRecord)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_requirementdependency`|
|ReferencedAttribute|`msdyn_requirementdependencyid`|
|ReferencingAttribute|`duplicaterecordid`|
|ReferencingEntityNavigationPropertyName|`duplicaterecordid_msdyn_requirementdependency`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_requirementgroup_DuplicateBaseRecord"></a> msdyn_requirementgroup_DuplicateBaseRecord

One-To-Many Relationship: [msdyn_requirementgroup msdyn_requirementgroup_DuplicateBaseRecord](msdyn_requirementgroup.md#BKMK_msdyn_requirementgroup_DuplicateBaseRecord)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_requirementgroup`|
|ReferencedAttribute|`msdyn_requirementgroupid`|
|ReferencingAttribute|`baserecordid`|
|ReferencingEntityNavigationPropertyName|`baserecordid_msdyn_requirementgroup`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_requirementgroup_DuplicateMatchingRecord"></a> msdyn_requirementgroup_DuplicateMatchingRecord

One-To-Many Relationship: [msdyn_requirementgroup msdyn_requirementgroup_DuplicateMatchingRecord](msdyn_requirementgroup.md#BKMK_msdyn_requirementgroup_DuplicateMatchingRecord)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_requirementgroup`|
|ReferencedAttribute|`msdyn_requirementgroupid`|
|ReferencingAttribute|`duplicaterecordid`|
|ReferencingEntityNavigationPropertyName|`duplicaterecordid_msdyn_requirementgroup`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_requirementorganizationunit_DuplicateBaseRecord"></a> msdyn_requirementorganizationunit_DuplicateBaseRecord

One-To-Many Relationship: [msdyn_requirementorganizationunit msdyn_requirementorganizationunit_DuplicateBaseRecord](msdyn_requirementorganizationunit.md#BKMK_msdyn_requirementorganizationunit_DuplicateBaseRecord)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_requirementorganizationunit`|
|ReferencedAttribute|`msdyn_requirementorganizationunitid`|
|ReferencingAttribute|`baserecordid`|
|ReferencingEntityNavigationPropertyName|`baserecordid_msdyn_requirementorganizationunit`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_requirementorganizationunit_DuplicateMatchingRecord"></a> msdyn_requirementorganizationunit_DuplicateMatchingRecord

One-To-Many Relationship: [msdyn_requirementorganizationunit msdyn_requirementorganizationunit_DuplicateMatchingRecord](msdyn_requirementorganizationunit.md#BKMK_msdyn_requirementorganizationunit_DuplicateMatchingRecord)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_requirementorganizationunit`|
|ReferencedAttribute|`msdyn_requirementorganizationunitid`|
|ReferencingAttribute|`duplicaterecordid`|
|ReferencingEntityNavigationPropertyName|`duplicaterecordid_msdyn_requirementorganizationunit`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_requirementrelationship_DuplicateBaseRecord"></a> msdyn_requirementrelationship_DuplicateBaseRecord

One-To-Many Relationship: [msdyn_requirementrelationship msdyn_requirementrelationship_DuplicateBaseRecord](msdyn_requirementrelationship.md#BKMK_msdyn_requirementrelationship_DuplicateBaseRecord)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_requirementrelationship`|
|ReferencedAttribute|`msdyn_requirementrelationshipid`|
|ReferencingAttribute|`baserecordid`|
|ReferencingEntityNavigationPropertyName|`baserecordid_msdyn_requirementrelationship`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_requirementrelationship_DuplicateMatchingRecord"></a> msdyn_requirementrelationship_DuplicateMatchingRecord

One-To-Many Relationship: [msdyn_requirementrelationship msdyn_requirementrelationship_DuplicateMatchingRecord](msdyn_requirementrelationship.md#BKMK_msdyn_requirementrelationship_DuplicateMatchingRecord)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_requirementrelationship`|
|ReferencedAttribute|`msdyn_requirementrelationshipid`|
|ReferencingAttribute|`duplicaterecordid`|
|ReferencingEntityNavigationPropertyName|`duplicaterecordid_msdyn_requirementrelationship`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_requirementresourcecategory_DuplicateBaseRecord"></a> msdyn_requirementresourcecategory_DuplicateBaseRecord

One-To-Many Relationship: [msdyn_requirementresourcecategory msdyn_requirementresourcecategory_DuplicateBaseRecord](msdyn_requirementresourcecategory.md#BKMK_msdyn_requirementresourcecategory_DuplicateBaseRecord)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_requirementresourcecategory`|
|ReferencedAttribute|`msdyn_requirementresourcecategoryid`|
|ReferencingAttribute|`baserecordid`|
|ReferencingEntityNavigationPropertyName|`baserecordid_msdyn_requirementresourcecategory`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_requirementresourcecategory_DuplicateMatchingRecord"></a> msdyn_requirementresourcecategory_DuplicateMatchingRecord

One-To-Many Relationship: [msdyn_requirementresourcecategory msdyn_requirementresourcecategory_DuplicateMatchingRecord](msdyn_requirementresourcecategory.md#BKMK_msdyn_requirementresourcecategory_DuplicateMatchingRecord)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_requirementresourcecategory`|
|ReferencedAttribute|`msdyn_requirementresourcecategoryid`|
|ReferencingAttribute|`duplicaterecordid`|
|ReferencingEntityNavigationPropertyName|`duplicaterecordid_msdyn_requirementresourcecategory`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_requirementresourcepreference_DuplicateBaseRecord"></a> msdyn_requirementresourcepreference_DuplicateBaseRecord

One-To-Many Relationship: [msdyn_requirementresourcepreference msdyn_requirementresourcepreference_DuplicateBaseRecord](msdyn_requirementresourcepreference.md#BKMK_msdyn_requirementresourcepreference_DuplicateBaseRecord)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_requirementresourcepreference`|
|ReferencedAttribute|`msdyn_requirementresourcepreferenceid`|
|ReferencingAttribute|`baserecordid`|
|ReferencingEntityNavigationPropertyName|`baserecordid_msdyn_requirementresourcepreference`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_requirementresourcepreference_DuplicateMatchingRecord"></a> msdyn_requirementresourcepreference_DuplicateMatchingRecord

One-To-Many Relationship: [msdyn_requirementresourcepreference msdyn_requirementresourcepreference_DuplicateMatchingRecord](msdyn_requirementresourcepreference.md#BKMK_msdyn_requirementresourcepreference_DuplicateMatchingRecord)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_requirementresourcepreference`|
|ReferencedAttribute|`msdyn_requirementresourcepreferenceid`|
|ReferencingAttribute|`duplicaterecordid`|
|ReferencingEntityNavigationPropertyName|`duplicaterecordid_msdyn_requirementresourcepreference`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_requirementstatus_DuplicateBaseRecord"></a> msdyn_requirementstatus_DuplicateBaseRecord

One-To-Many Relationship: [msdyn_requirementstatus msdyn_requirementstatus_DuplicateBaseRecord](msdyn_requirementstatus.md#BKMK_msdyn_requirementstatus_DuplicateBaseRecord)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_requirementstatus`|
|ReferencedAttribute|`msdyn_requirementstatusid`|
|ReferencingAttribute|`baserecordid`|
|ReferencingEntityNavigationPropertyName|`baserecordid_msdyn_requirementstatus`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_requirementstatus_DuplicateMatchingRecord"></a> msdyn_requirementstatus_DuplicateMatchingRecord

One-To-Many Relationship: [msdyn_requirementstatus msdyn_requirementstatus_DuplicateMatchingRecord](msdyn_requirementstatus.md#BKMK_msdyn_requirementstatus_DuplicateMatchingRecord)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_requirementstatus`|
|ReferencedAttribute|`msdyn_requirementstatusid`|
|ReferencingAttribute|`duplicaterecordid`|
|ReferencingEntityNavigationPropertyName|`duplicaterecordid_msdyn_requirementstatus`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_resolution_DuplicateBaseRecord"></a> msdyn_resolution_DuplicateBaseRecord

One-To-Many Relationship: [msdyn_resolution msdyn_resolution_DuplicateBaseRecord](msdyn_resolution.md#BKMK_msdyn_resolution_DuplicateBaseRecord)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_resolution`|
|ReferencedAttribute|`msdyn_resolutionid`|
|ReferencingAttribute|`baserecordid`|
|ReferencingEntityNavigationPropertyName|`baserecordid_msdyn_resolution`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_resolution_DuplicateMatchingRecord"></a> msdyn_resolution_DuplicateMatchingRecord

One-To-Many Relationship: [msdyn_resolution msdyn_resolution_DuplicateMatchingRecord](msdyn_resolution.md#BKMK_msdyn_resolution_DuplicateMatchingRecord)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_resolution`|
|ReferencedAttribute|`msdyn_resolutionid`|
|ReferencingAttribute|`duplicaterecordid`|
|ReferencingEntityNavigationPropertyName|`duplicaterecordid_msdyn_resolution`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_resourcerequirement_DuplicateBaseRecord"></a> msdyn_resourcerequirement_DuplicateBaseRecord

One-To-Many Relationship: [msdyn_resourcerequirement msdyn_resourcerequirement_DuplicateBaseRecord](msdyn_resourcerequirement.md#BKMK_msdyn_resourcerequirement_DuplicateBaseRecord)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_resourcerequirement`|
|ReferencedAttribute|`msdyn_resourcerequirementid`|
|ReferencingAttribute|`baserecordid`|
|ReferencingEntityNavigationPropertyName|`baserecordid_msdyn_resourcerequirement`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_resourcerequirement_DuplicateMatchingRecord"></a> msdyn_resourcerequirement_DuplicateMatchingRecord

One-To-Many Relationship: [msdyn_resourcerequirement msdyn_resourcerequirement_DuplicateMatchingRecord](msdyn_resourcerequirement.md#BKMK_msdyn_resourcerequirement_DuplicateMatchingRecord)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_resourcerequirement`|
|ReferencedAttribute|`msdyn_resourcerequirementid`|
|ReferencingAttribute|`duplicaterecordid`|
|ReferencingEntityNavigationPropertyName|`duplicaterecordid_msdyn_resourcerequirement`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_resourcerequirementdetail_DuplicateBaseRecord"></a> msdyn_resourcerequirementdetail_DuplicateBaseRecord

One-To-Many Relationship: [msdyn_resourcerequirementdetail msdyn_resourcerequirementdetail_DuplicateBaseRecord](msdyn_resourcerequirementdetail.md#BKMK_msdyn_resourcerequirementdetail_DuplicateBaseRecord)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_resourcerequirementdetail`|
|ReferencedAttribute|`msdyn_resourcerequirementdetailid`|
|ReferencingAttribute|`baserecordid`|
|ReferencingEntityNavigationPropertyName|`baserecordid_msdyn_resourcerequirementdetail`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_resourcerequirementdetail_DuplicateMatchingRecord"></a> msdyn_resourcerequirementdetail_DuplicateMatchingRecord

One-To-Many Relationship: [msdyn_resourcerequirementdetail msdyn_resourcerequirementdetail_DuplicateMatchingRecord](msdyn_resourcerequirementdetail.md#BKMK_msdyn_resourcerequirementdetail_DuplicateMatchingRecord)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_resourcerequirementdetail`|
|ReferencedAttribute|`msdyn_resourcerequirementdetailid`|
|ReferencingAttribute|`duplicaterecordid`|
|ReferencingEntityNavigationPropertyName|`duplicaterecordid_msdyn_resourcerequirementdetail`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_resourceterritory_DuplicateBaseRecord"></a> msdyn_resourceterritory_DuplicateBaseRecord

One-To-Many Relationship: [msdyn_resourceterritory msdyn_resourceterritory_DuplicateBaseRecord](msdyn_resourceterritory.md#BKMK_msdyn_resourceterritory_DuplicateBaseRecord)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_resourceterritory`|
|ReferencedAttribute|`msdyn_resourceterritoryid`|
|ReferencingAttribute|`baserecordid`|
|ReferencingEntityNavigationPropertyName|`baserecordid_msdyn_resourceterritory`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_resourceterritory_DuplicateMatchingRecord"></a> msdyn_resourceterritory_DuplicateMatchingRecord

One-To-Many Relationship: [msdyn_resourceterritory msdyn_resourceterritory_DuplicateMatchingRecord](msdyn_resourceterritory.md#BKMK_msdyn_resourceterritory_DuplicateMatchingRecord)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_resourceterritory`|
|ReferencedAttribute|`msdyn_resourceterritoryid`|
|ReferencingAttribute|`duplicaterecordid`|
|ReferencingEntityNavigationPropertyName|`duplicaterecordid_msdyn_resourceterritory`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_rma_DuplicateBaseRecord"></a> msdyn_rma_DuplicateBaseRecord

One-To-Many Relationship: [msdyn_rma msdyn_rma_DuplicateBaseRecord](msdyn_rma.md#BKMK_msdyn_rma_DuplicateBaseRecord)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_rma`|
|ReferencedAttribute|`msdyn_rmaid`|
|ReferencingAttribute|`baserecordid`|
|ReferencingEntityNavigationPropertyName|`baserecordid_msdyn_rma`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_rma_DuplicateMatchingRecord"></a> msdyn_rma_DuplicateMatchingRecord

One-To-Many Relationship: [msdyn_rma msdyn_rma_DuplicateMatchingRecord](msdyn_rma.md#BKMK_msdyn_rma_DuplicateMatchingRecord)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_rma`|
|ReferencedAttribute|`msdyn_rmaid`|
|ReferencingAttribute|`duplicaterecordid`|
|ReferencingEntityNavigationPropertyName|`duplicaterecordid_msdyn_rma`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_rmareceipt_DuplicateBaseRecord"></a> msdyn_rmareceipt_DuplicateBaseRecord

One-To-Many Relationship: [msdyn_rmareceipt msdyn_rmareceipt_DuplicateBaseRecord](msdyn_rmareceipt.md#BKMK_msdyn_rmareceipt_DuplicateBaseRecord)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_rmareceipt`|
|ReferencedAttribute|`msdyn_rmareceiptid`|
|ReferencingAttribute|`baserecordid`|
|ReferencingEntityNavigationPropertyName|`baserecordid_msdyn_rmareceipt`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_rmareceipt_DuplicateMatchingRecord"></a> msdyn_rmareceipt_DuplicateMatchingRecord

One-To-Many Relationship: [msdyn_rmareceipt msdyn_rmareceipt_DuplicateMatchingRecord](msdyn_rmareceipt.md#BKMK_msdyn_rmareceipt_DuplicateMatchingRecord)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_rmareceipt`|
|ReferencedAttribute|`msdyn_rmareceiptid`|
|ReferencingAttribute|`duplicaterecordid`|
|ReferencingEntityNavigationPropertyName|`duplicaterecordid_msdyn_rmareceipt`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_rmareceiptproduct_DuplicateBaseRecord"></a> msdyn_rmareceiptproduct_DuplicateBaseRecord

One-To-Many Relationship: [msdyn_rmareceiptproduct msdyn_rmareceiptproduct_DuplicateBaseRecord](msdyn_rmareceiptproduct.md#BKMK_msdyn_rmareceiptproduct_DuplicateBaseRecord)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_rmareceiptproduct`|
|ReferencedAttribute|`msdyn_rmareceiptproductid`|
|ReferencingAttribute|`baserecordid`|
|ReferencingEntityNavigationPropertyName|`baserecordid_msdyn_rmareceiptproduct`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_rmareceiptproduct_DuplicateMatchingRecord"></a> msdyn_rmareceiptproduct_DuplicateMatchingRecord

One-To-Many Relationship: [msdyn_rmareceiptproduct msdyn_rmareceiptproduct_DuplicateMatchingRecord](msdyn_rmareceiptproduct.md#BKMK_msdyn_rmareceiptproduct_DuplicateMatchingRecord)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_rmareceiptproduct`|
|ReferencedAttribute|`msdyn_rmareceiptproductid`|
|ReferencingAttribute|`duplicaterecordid`|
|ReferencingEntityNavigationPropertyName|`duplicaterecordid_msdyn_rmareceiptproduct`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_rmasubstatus_DuplicateBaseRecord"></a> msdyn_rmasubstatus_DuplicateBaseRecord

One-To-Many Relationship: [msdyn_rmasubstatus msdyn_rmasubstatus_DuplicateBaseRecord](msdyn_rmasubstatus.md#BKMK_msdyn_rmasubstatus_DuplicateBaseRecord)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_rmasubstatus`|
|ReferencedAttribute|`msdyn_rmasubstatusid`|
|ReferencingAttribute|`baserecordid`|
|ReferencingEntityNavigationPropertyName|`baserecordid_msdyn_rmasubstatus`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_rmasubstatus_DuplicateMatchingRecord"></a> msdyn_rmasubstatus_DuplicateMatchingRecord

One-To-Many Relationship: [msdyn_rmasubstatus msdyn_rmasubstatus_DuplicateMatchingRecord](msdyn_rmasubstatus.md#BKMK_msdyn_rmasubstatus_DuplicateMatchingRecord)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_rmasubstatus`|
|ReferencedAttribute|`msdyn_rmasubstatusid`|
|ReferencingAttribute|`duplicaterecordid`|
|ReferencingEntityNavigationPropertyName|`duplicaterecordid_msdyn_rmasubstatus`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_rtv_DuplicateBaseRecord"></a> msdyn_rtv_DuplicateBaseRecord

One-To-Many Relationship: [msdyn_rtv msdyn_rtv_DuplicateBaseRecord](msdyn_rtv.md#BKMK_msdyn_rtv_DuplicateBaseRecord)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_rtv`|
|ReferencedAttribute|`msdyn_rtvid`|
|ReferencingAttribute|`baserecordid`|
|ReferencingEntityNavigationPropertyName|`baserecordid_msdyn_rtv`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_rtv_DuplicateMatchingRecord"></a> msdyn_rtv_DuplicateMatchingRecord

One-To-Many Relationship: [msdyn_rtv msdyn_rtv_DuplicateMatchingRecord](msdyn_rtv.md#BKMK_msdyn_rtv_DuplicateMatchingRecord)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_rtv`|
|ReferencedAttribute|`msdyn_rtvid`|
|ReferencingAttribute|`duplicaterecordid`|
|ReferencingEntityNavigationPropertyName|`duplicaterecordid_msdyn_rtv`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_rtvproduct_DuplicateBaseRecord"></a> msdyn_rtvproduct_DuplicateBaseRecord

One-To-Many Relationship: [msdyn_rtvproduct msdyn_rtvproduct_DuplicateBaseRecord](msdyn_rtvproduct.md#BKMK_msdyn_rtvproduct_DuplicateBaseRecord)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_rtvproduct`|
|ReferencedAttribute|`msdyn_rtvproductid`|
|ReferencingAttribute|`baserecordid`|
|ReferencingEntityNavigationPropertyName|`baserecordid_msdyn_rtvproduct`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_rtvproduct_DuplicateMatchingRecord"></a> msdyn_rtvproduct_DuplicateMatchingRecord

One-To-Many Relationship: [msdyn_rtvproduct msdyn_rtvproduct_DuplicateMatchingRecord](msdyn_rtvproduct.md#BKMK_msdyn_rtvproduct_DuplicateMatchingRecord)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_rtvproduct`|
|ReferencedAttribute|`msdyn_rtvproductid`|
|ReferencingAttribute|`duplicaterecordid`|
|ReferencingEntityNavigationPropertyName|`duplicaterecordid_msdyn_rtvproduct`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_rtvsubstatus_DuplicateBaseRecord"></a> msdyn_rtvsubstatus_DuplicateBaseRecord

One-To-Many Relationship: [msdyn_rtvsubstatus msdyn_rtvsubstatus_DuplicateBaseRecord](msdyn_rtvsubstatus.md#BKMK_msdyn_rtvsubstatus_DuplicateBaseRecord)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_rtvsubstatus`|
|ReferencedAttribute|`msdyn_rtvsubstatusid`|
|ReferencingAttribute|`baserecordid`|
|ReferencingEntityNavigationPropertyName|`baserecordid_msdyn_rtvsubstatus`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_rtvsubstatus_DuplicateMatchingRecord"></a> msdyn_rtvsubstatus_DuplicateMatchingRecord

One-To-Many Relationship: [msdyn_rtvsubstatus msdyn_rtvsubstatus_DuplicateMatchingRecord](msdyn_rtvsubstatus.md#BKMK_msdyn_rtvsubstatus_DuplicateMatchingRecord)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_rtvsubstatus`|
|ReferencedAttribute|`msdyn_rtvsubstatusid`|
|ReferencingAttribute|`duplicaterecordid`|
|ReferencingEntityNavigationPropertyName|`duplicaterecordid_msdyn_rtvsubstatus`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_scheduleboardsetting_DuplicateBaseRecord"></a> msdyn_scheduleboardsetting_DuplicateBaseRecord

One-To-Many Relationship: [msdyn_scheduleboardsetting msdyn_scheduleboardsetting_DuplicateBaseRecord](msdyn_scheduleboardsetting.md#BKMK_msdyn_scheduleboardsetting_DuplicateBaseRecord)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_scheduleboardsetting`|
|ReferencedAttribute|`msdyn_scheduleboardsettingid`|
|ReferencingAttribute|`baserecordid`|
|ReferencingEntityNavigationPropertyName|`baserecordid_msdyn_scheduleboardsetting`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_scheduleboardsetting_DuplicateMatchingRecord"></a> msdyn_scheduleboardsetting_DuplicateMatchingRecord

One-To-Many Relationship: [msdyn_scheduleboardsetting msdyn_scheduleboardsetting_DuplicateMatchingRecord](msdyn_scheduleboardsetting.md#BKMK_msdyn_scheduleboardsetting_DuplicateMatchingRecord)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_scheduleboardsetting`|
|ReferencedAttribute|`msdyn_scheduleboardsettingid`|
|ReferencingAttribute|`duplicaterecordid`|
|ReferencingEntityNavigationPropertyName|`duplicaterecordid_msdyn_scheduleboardsetting`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_schedulingfeatureflag_DuplicateBaseRecord"></a> msdyn_schedulingfeatureflag_DuplicateBaseRecord

One-To-Many Relationship: [msdyn_schedulingfeatureflag msdyn_schedulingfeatureflag_DuplicateBaseRecord](msdyn_schedulingfeatureflag.md#BKMK_msdyn_schedulingfeatureflag_DuplicateBaseRecord)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_schedulingfeatureflag`|
|ReferencedAttribute|`msdyn_schedulingfeatureflagid`|
|ReferencingAttribute|`baserecordid`|
|ReferencingEntityNavigationPropertyName|`baserecordid_msdyn_schedulingfeatureflag`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_schedulingfeatureflag_DuplicateMatchingRecord"></a> msdyn_schedulingfeatureflag_DuplicateMatchingRecord

One-To-Many Relationship: [msdyn_schedulingfeatureflag msdyn_schedulingfeatureflag_DuplicateMatchingRecord](msdyn_schedulingfeatureflag.md#BKMK_msdyn_schedulingfeatureflag_DuplicateMatchingRecord)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_schedulingfeatureflag`|
|ReferencedAttribute|`msdyn_schedulingfeatureflagid`|
|ReferencingAttribute|`duplicaterecordid`|
|ReferencingEntityNavigationPropertyName|`duplicaterecordid_msdyn_schedulingfeatureflag`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_servicetasktype_DuplicateBaseRecord"></a> msdyn_servicetasktype_DuplicateBaseRecord

One-To-Many Relationship: [msdyn_servicetasktype msdyn_servicetasktype_DuplicateBaseRecord](msdyn_servicetasktype.md#BKMK_msdyn_servicetasktype_DuplicateBaseRecord)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_servicetasktype`|
|ReferencedAttribute|`msdyn_servicetasktypeid`|
|ReferencingAttribute|`baserecordid`|
|ReferencingEntityNavigationPropertyName|`baserecordid_msdyn_servicetasktype`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_servicetasktype_DuplicateMatchingRecord"></a> msdyn_servicetasktype_DuplicateMatchingRecord

One-To-Many Relationship: [msdyn_servicetasktype msdyn_servicetasktype_DuplicateMatchingRecord](msdyn_servicetasktype.md#BKMK_msdyn_servicetasktype_DuplicateMatchingRecord)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_servicetasktype`|
|ReferencedAttribute|`msdyn_servicetasktypeid`|
|ReferencingAttribute|`duplicaterecordid`|
|ReferencingEntityNavigationPropertyName|`duplicaterecordid_msdyn_servicetasktype`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_sessiondata_DuplicateBaseRecord"></a> msdyn_sessiondata_DuplicateBaseRecord

One-To-Many Relationship: [msdyn_sessiondata msdyn_sessiondata_DuplicateBaseRecord](msdyn_sessiondata.md#BKMK_msdyn_sessiondata_DuplicateBaseRecord)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_sessiondata`|
|ReferencedAttribute|`msdyn_sessiondataid`|
|ReferencingAttribute|`baserecordid`|
|ReferencingEntityNavigationPropertyName|`baserecordid_msdyn_sessiondata`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_sessiondata_DuplicateMatchingRecord"></a> msdyn_sessiondata_DuplicateMatchingRecord

One-To-Many Relationship: [msdyn_sessiondata msdyn_sessiondata_DuplicateMatchingRecord](msdyn_sessiondata.md#BKMK_msdyn_sessiondata_DuplicateMatchingRecord)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_sessiondata`|
|ReferencedAttribute|`msdyn_sessiondataid`|
|ReferencingAttribute|`duplicaterecordid`|
|ReferencingEntityNavigationPropertyName|`duplicaterecordid_msdyn_sessiondata`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_sessionparticipantdata_DuplicateBaseRecord"></a> msdyn_sessionparticipantdata_DuplicateBaseRecord

One-To-Many Relationship: [msdyn_sessionparticipantdata msdyn_sessionparticipantdata_DuplicateBaseRecord](msdyn_sessionparticipantdata.md#BKMK_msdyn_sessionparticipantdata_DuplicateBaseRecord)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_sessionparticipantdata`|
|ReferencedAttribute|`msdyn_sessionparticipantdataid`|
|ReferencingAttribute|`baserecordid`|
|ReferencingEntityNavigationPropertyName|`baserecordid_msdyn_sessionparticipantdata`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_sessionparticipantdata_DuplicateMatchingRecord"></a> msdyn_sessionparticipantdata_DuplicateMatchingRecord

One-To-Many Relationship: [msdyn_sessionparticipantdata msdyn_sessionparticipantdata_DuplicateMatchingRecord](msdyn_sessionparticipantdata.md#BKMK_msdyn_sessionparticipantdata_DuplicateMatchingRecord)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_sessionparticipantdata`|
|ReferencedAttribute|`msdyn_sessionparticipantdataid`|
|ReferencingAttribute|`duplicaterecordid`|
|ReferencingEntityNavigationPropertyName|`duplicaterecordid_msdyn_sessionparticipantdata`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_shipvia_DuplicateBaseRecord"></a> msdyn_shipvia_DuplicateBaseRecord

One-To-Many Relationship: [msdyn_shipvia msdyn_shipvia_DuplicateBaseRecord](msdyn_shipvia.md#BKMK_msdyn_shipvia_DuplicateBaseRecord)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_shipvia`|
|ReferencedAttribute|`msdyn_shipviaid`|
|ReferencingAttribute|`baserecordid`|
|ReferencingEntityNavigationPropertyName|`baserecordid_msdyn_shipvia`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_shipvia_DuplicateMatchingRecord"></a> msdyn_shipvia_DuplicateMatchingRecord

One-To-Many Relationship: [msdyn_shipvia msdyn_shipvia_DuplicateMatchingRecord](msdyn_shipvia.md#BKMK_msdyn_shipvia_DuplicateMatchingRecord)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_shipvia`|
|ReferencedAttribute|`msdyn_shipviaid`|
|ReferencingAttribute|`duplicaterecordid`|
|ReferencingEntityNavigationPropertyName|`duplicaterecordid_msdyn_shipvia`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_systemuserschedulersetting_DuplicateBaseRecord"></a> msdyn_systemuserschedulersetting_DuplicateBaseRecord

One-To-Many Relationship: [msdyn_systemuserschedulersetting msdyn_systemuserschedulersetting_DuplicateBaseRecord](msdyn_systemuserschedulersetting.md#BKMK_msdyn_systemuserschedulersetting_DuplicateBaseRecord)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_systemuserschedulersetting`|
|ReferencedAttribute|`msdyn_systemuserschedulersettingid`|
|ReferencingAttribute|`baserecordid`|
|ReferencingEntityNavigationPropertyName|`baserecordid_msdyn_systemuserschedulersetting`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_systemuserschedulersetting_DuplicateMatchingRecord"></a> msdyn_systemuserschedulersetting_DuplicateMatchingRecord

One-To-Many Relationship: [msdyn_systemuserschedulersetting msdyn_systemuserschedulersetting_DuplicateMatchingRecord](msdyn_systemuserschedulersetting.md#BKMK_msdyn_systemuserschedulersetting_DuplicateMatchingRecord)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_systemuserschedulersetting`|
|ReferencedAttribute|`msdyn_systemuserschedulersettingid`|
|ReferencingAttribute|`duplicaterecordid`|
|ReferencingEntityNavigationPropertyName|`duplicaterecordid_msdyn_systemuserschedulersetting`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_taxcode_DuplicateBaseRecord"></a> msdyn_taxcode_DuplicateBaseRecord

One-To-Many Relationship: [msdyn_taxcode msdyn_taxcode_DuplicateBaseRecord](msdyn_taxcode.md#BKMK_msdyn_taxcode_DuplicateBaseRecord)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_taxcode`|
|ReferencedAttribute|`msdyn_taxcodeid`|
|ReferencingAttribute|`baserecordid`|
|ReferencingEntityNavigationPropertyName|`baserecordid_msdyn_taxcode`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_taxcode_DuplicateMatchingRecord"></a> msdyn_taxcode_DuplicateMatchingRecord

One-To-Many Relationship: [msdyn_taxcode msdyn_taxcode_DuplicateMatchingRecord](msdyn_taxcode.md#BKMK_msdyn_taxcode_DuplicateMatchingRecord)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_taxcode`|
|ReferencedAttribute|`msdyn_taxcodeid`|
|ReferencingAttribute|`duplicaterecordid`|
|ReferencingEntityNavigationPropertyName|`duplicaterecordid_msdyn_taxcode`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_taxcodedetail_DuplicateBaseRecord"></a> msdyn_taxcodedetail_DuplicateBaseRecord

One-To-Many Relationship: [msdyn_taxcodedetail msdyn_taxcodedetail_DuplicateBaseRecord](msdyn_taxcodedetail.md#BKMK_msdyn_taxcodedetail_DuplicateBaseRecord)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_taxcodedetail`|
|ReferencedAttribute|`msdyn_taxcodedetailid`|
|ReferencingAttribute|`baserecordid`|
|ReferencingEntityNavigationPropertyName|`baserecordid_msdyn_taxcodedetail`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_taxcodedetail_DuplicateMatchingRecord"></a> msdyn_taxcodedetail_DuplicateMatchingRecord

One-To-Many Relationship: [msdyn_taxcodedetail msdyn_taxcodedetail_DuplicateMatchingRecord](msdyn_taxcodedetail.md#BKMK_msdyn_taxcodedetail_DuplicateMatchingRecord)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_taxcodedetail`|
|ReferencedAttribute|`msdyn_taxcodedetailid`|
|ReferencingAttribute|`duplicaterecordid`|
|ReferencingEntityNavigationPropertyName|`duplicaterecordid_msdyn_taxcodedetail`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_timeentrysetting_DuplicateBaseRecord"></a> msdyn_timeentrysetting_DuplicateBaseRecord

One-To-Many Relationship: [msdyn_timeentrysetting msdyn_timeentrysetting_DuplicateBaseRecord](msdyn_timeentrysetting.md#BKMK_msdyn_timeentrysetting_DuplicateBaseRecord)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_timeentrysetting`|
|ReferencedAttribute|`msdyn_timeentrysettingid`|
|ReferencingAttribute|`baserecordid`|
|ReferencingEntityNavigationPropertyName|`baserecordid_msdyn_timeentrysetting`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_timeentrysetting_DuplicateMatchingRecord"></a> msdyn_timeentrysetting_DuplicateMatchingRecord

One-To-Many Relationship: [msdyn_timeentrysetting msdyn_timeentrysetting_DuplicateMatchingRecord](msdyn_timeentrysetting.md#BKMK_msdyn_timeentrysetting_DuplicateMatchingRecord)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_timeentrysetting`|
|ReferencedAttribute|`msdyn_timeentrysettingid`|
|ReferencingAttribute|`duplicaterecordid`|
|ReferencingEntityNavigationPropertyName|`duplicaterecordid_msdyn_timeentrysetting`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_timegroup_DuplicateBaseRecord"></a> msdyn_timegroup_DuplicateBaseRecord

One-To-Many Relationship: [msdyn_timegroup msdyn_timegroup_DuplicateBaseRecord](msdyn_timegroup.md#BKMK_msdyn_timegroup_DuplicateBaseRecord)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_timegroup`|
|ReferencedAttribute|`msdyn_timegroupid`|
|ReferencingAttribute|`baserecordid`|
|ReferencingEntityNavigationPropertyName|`baserecordid_msdyn_timegroup`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_timegroup_DuplicateMatchingRecord"></a> msdyn_timegroup_DuplicateMatchingRecord

One-To-Many Relationship: [msdyn_timegroup msdyn_timegroup_DuplicateMatchingRecord](msdyn_timegroup.md#BKMK_msdyn_timegroup_DuplicateMatchingRecord)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_timegroup`|
|ReferencedAttribute|`msdyn_timegroupid`|
|ReferencingAttribute|`duplicaterecordid`|
|ReferencingEntityNavigationPropertyName|`duplicaterecordid_msdyn_timegroup`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_timegroupdetail_DuplicateBaseRecord"></a> msdyn_timegroupdetail_DuplicateBaseRecord

One-To-Many Relationship: [msdyn_timegroupdetail msdyn_timegroupdetail_DuplicateBaseRecord](msdyn_timegroupdetail.md#BKMK_msdyn_timegroupdetail_DuplicateBaseRecord)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_timegroupdetail`|
|ReferencedAttribute|`msdyn_timegroupdetailid`|
|ReferencingAttribute|`baserecordid`|
|ReferencingEntityNavigationPropertyName|`baserecordid_msdyn_timegroupdetail`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_timegroupdetail_DuplicateMatchingRecord"></a> msdyn_timegroupdetail_DuplicateMatchingRecord

One-To-Many Relationship: [msdyn_timegroupdetail msdyn_timegroupdetail_DuplicateMatchingRecord](msdyn_timegroupdetail.md#BKMK_msdyn_timegroupdetail_DuplicateMatchingRecord)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_timegroupdetail`|
|ReferencedAttribute|`msdyn_timegroupdetailid`|
|ReferencingAttribute|`duplicaterecordid`|
|ReferencingEntityNavigationPropertyName|`duplicaterecordid_msdyn_timegroupdetail`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_timeoffrequest_DuplicateBaseRecord"></a> msdyn_timeoffrequest_DuplicateBaseRecord

One-To-Many Relationship: [msdyn_timeoffrequest msdyn_timeoffrequest_DuplicateBaseRecord](msdyn_timeoffrequest.md#BKMK_msdyn_timeoffrequest_DuplicateBaseRecord)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_timeoffrequest`|
|ReferencedAttribute|`msdyn_timeoffrequestid`|
|ReferencingAttribute|`baserecordid`|
|ReferencingEntityNavigationPropertyName|`baserecordid_msdyn_timeoffrequest`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_timeoffrequest_DuplicateMatchingRecord"></a> msdyn_timeoffrequest_DuplicateMatchingRecord

One-To-Many Relationship: [msdyn_timeoffrequest msdyn_timeoffrequest_DuplicateMatchingRecord](msdyn_timeoffrequest.md#BKMK_msdyn_timeoffrequest_DuplicateMatchingRecord)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_timeoffrequest`|
|ReferencedAttribute|`msdyn_timeoffrequestid`|
|ReferencingAttribute|`duplicaterecordid`|
|ReferencingEntityNavigationPropertyName|`duplicaterecordid_msdyn_timeoffrequest`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_trade_DuplicateBaseRecord"></a> msdyn_trade_DuplicateBaseRecord

One-To-Many Relationship: [msdyn_trade msdyn_trade_DuplicateBaseRecord](msdyn_trade.md#BKMK_msdyn_trade_DuplicateBaseRecord)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_trade`|
|ReferencedAttribute|`msdyn_tradeid`|
|ReferencingAttribute|`baserecordid`|
|ReferencingEntityNavigationPropertyName|`baserecordid_msdyn_trade`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_trade_DuplicateMatchingRecord"></a> msdyn_trade_DuplicateMatchingRecord

One-To-Many Relationship: [msdyn_trade msdyn_trade_DuplicateMatchingRecord](msdyn_trade.md#BKMK_msdyn_trade_DuplicateMatchingRecord)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_trade`|
|ReferencedAttribute|`msdyn_tradeid`|
|ReferencingAttribute|`duplicaterecordid`|
|ReferencingEntityNavigationPropertyName|`duplicaterecordid_msdyn_trade`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_tradecoverage_DuplicateBaseRecord"></a> msdyn_tradecoverage_DuplicateBaseRecord

One-To-Many Relationship: [msdyn_tradecoverage msdyn_tradecoverage_DuplicateBaseRecord](msdyn_tradecoverage.md#BKMK_msdyn_tradecoverage_DuplicateBaseRecord)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_tradecoverage`|
|ReferencedAttribute|`msdyn_tradecoverageid`|
|ReferencingAttribute|`baserecordid`|
|ReferencingEntityNavigationPropertyName|`baserecordid_msdyn_tradecoverage`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_tradecoverage_DuplicateMatchingRecord"></a> msdyn_tradecoverage_DuplicateMatchingRecord

One-To-Many Relationship: [msdyn_tradecoverage msdyn_tradecoverage_DuplicateMatchingRecord](msdyn_tradecoverage.md#BKMK_msdyn_tradecoverage_DuplicateMatchingRecord)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_tradecoverage`|
|ReferencedAttribute|`msdyn_tradecoverageid`|
|ReferencingAttribute|`duplicaterecordid`|
|ReferencingEntityNavigationPropertyName|`duplicaterecordid_msdyn_tradecoverage`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_transactionorigin_DuplicateBaseRecord"></a> msdyn_transactionorigin_DuplicateBaseRecord

One-To-Many Relationship: [msdyn_transactionorigin msdyn_transactionorigin_DuplicateBaseRecord](msdyn_transactionorigin.md#BKMK_msdyn_transactionorigin_DuplicateBaseRecord)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_transactionorigin`|
|ReferencedAttribute|`msdyn_transactionoriginid`|
|ReferencingAttribute|`baserecordid`|
|ReferencingEntityNavigationPropertyName|`baserecordid_msdyn_transactionorigin`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_transactionorigin_DuplicateMatchingRecord"></a> msdyn_transactionorigin_DuplicateMatchingRecord

One-To-Many Relationship: [msdyn_transactionorigin msdyn_transactionorigin_DuplicateMatchingRecord](msdyn_transactionorigin.md#BKMK_msdyn_transactionorigin_DuplicateMatchingRecord)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_transactionorigin`|
|ReferencedAttribute|`msdyn_transactionoriginid`|
|ReferencingAttribute|`duplicaterecordid`|
|ReferencingEntityNavigationPropertyName|`duplicaterecordid_msdyn_transactionorigin`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_warehouse_DuplicateBaseRecord"></a> msdyn_warehouse_DuplicateBaseRecord

One-To-Many Relationship: [msdyn_warehouse msdyn_warehouse_DuplicateBaseRecord](msdyn_warehouse.md#BKMK_msdyn_warehouse_DuplicateBaseRecord)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_warehouse`|
|ReferencedAttribute|`msdyn_warehouseid`|
|ReferencingAttribute|`baserecordid`|
|ReferencingEntityNavigationPropertyName|`baserecordid_msdyn_warehouse`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_warehouse_DuplicateMatchingRecord"></a> msdyn_warehouse_DuplicateMatchingRecord

One-To-Many Relationship: [msdyn_warehouse msdyn_warehouse_DuplicateMatchingRecord](msdyn_warehouse.md#BKMK_msdyn_warehouse_DuplicateMatchingRecord)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_warehouse`|
|ReferencedAttribute|`msdyn_warehouseid`|
|ReferencingAttribute|`duplicaterecordid`|
|ReferencingEntityNavigationPropertyName|`duplicaterecordid_msdyn_warehouse`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_workhourtemplate_DuplicateBaseRecord"></a> msdyn_workhourtemplate_DuplicateBaseRecord

One-To-Many Relationship: [msdyn_workhourtemplate msdyn_workhourtemplate_DuplicateBaseRecord](msdyn_workhourtemplate.md#BKMK_msdyn_workhourtemplate_DuplicateBaseRecord)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_workhourtemplate`|
|ReferencedAttribute|`msdyn_workhourtemplateid`|
|ReferencingAttribute|`baserecordid`|
|ReferencingEntityNavigationPropertyName|`baserecordid_msdyn_workhourtemplate`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_workhourtemplate_DuplicateMatchingRecord"></a> msdyn_workhourtemplate_DuplicateMatchingRecord

One-To-Many Relationship: [msdyn_workhourtemplate msdyn_workhourtemplate_DuplicateMatchingRecord](msdyn_workhourtemplate.md#BKMK_msdyn_workhourtemplate_DuplicateMatchingRecord)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_workhourtemplate`|
|ReferencedAttribute|`msdyn_workhourtemplateid`|
|ReferencingAttribute|`duplicaterecordid`|
|ReferencingEntityNavigationPropertyName|`duplicaterecordid_msdyn_workhourtemplate`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_workorder_DuplicateBaseRecord"></a> msdyn_workorder_DuplicateBaseRecord

One-To-Many Relationship: [msdyn_workorder msdyn_workorder_DuplicateBaseRecord](msdyn_workorder.md#BKMK_msdyn_workorder_DuplicateBaseRecord)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_workorder`|
|ReferencedAttribute|`msdyn_workorderid`|
|ReferencingAttribute|`baserecordid`|
|ReferencingEntityNavigationPropertyName|`baserecordid_msdyn_workorder`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_workorder_DuplicateMatchingRecord"></a> msdyn_workorder_DuplicateMatchingRecord

One-To-Many Relationship: [msdyn_workorder msdyn_workorder_DuplicateMatchingRecord](msdyn_workorder.md#BKMK_msdyn_workorder_DuplicateMatchingRecord)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_workorder`|
|ReferencedAttribute|`msdyn_workorderid`|
|ReferencingAttribute|`duplicaterecordid`|
|ReferencingEntityNavigationPropertyName|`duplicaterecordid_msdyn_workorder`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_workorderincident_DuplicateBaseRecord"></a> msdyn_workorderincident_DuplicateBaseRecord

One-To-Many Relationship: [msdyn_workorderincident msdyn_workorderincident_DuplicateBaseRecord](msdyn_workorderincident.md#BKMK_msdyn_workorderincident_DuplicateBaseRecord)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_workorderincident`|
|ReferencedAttribute|`msdyn_workorderincidentid`|
|ReferencingAttribute|`baserecordid`|
|ReferencingEntityNavigationPropertyName|`baserecordid_msdyn_workorderincident`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_workorderincident_DuplicateMatchingRecord"></a> msdyn_workorderincident_DuplicateMatchingRecord

One-To-Many Relationship: [msdyn_workorderincident msdyn_workorderincident_DuplicateMatchingRecord](msdyn_workorderincident.md#BKMK_msdyn_workorderincident_DuplicateMatchingRecord)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_workorderincident`|
|ReferencedAttribute|`msdyn_workorderincidentid`|
|ReferencingAttribute|`duplicaterecordid`|
|ReferencingEntityNavigationPropertyName|`duplicaterecordid_msdyn_workorderincident`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_workordernte_DuplicateBaseRecord"></a> msdyn_workordernte_DuplicateBaseRecord

One-To-Many Relationship: [msdyn_workordernte msdyn_workordernte_DuplicateBaseRecord](msdyn_workordernte.md#BKMK_msdyn_workordernte_DuplicateBaseRecord)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_workordernte`|
|ReferencedAttribute|`msdyn_workordernteid`|
|ReferencingAttribute|`baserecordid`|
|ReferencingEntityNavigationPropertyName|`baserecordid_msdyn_workordernte`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_workordernte_DuplicateMatchingRecord"></a> msdyn_workordernte_DuplicateMatchingRecord

One-To-Many Relationship: [msdyn_workordernte msdyn_workordernte_DuplicateMatchingRecord](msdyn_workordernte.md#BKMK_msdyn_workordernte_DuplicateMatchingRecord)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_workordernte`|
|ReferencedAttribute|`msdyn_workordernteid`|
|ReferencingAttribute|`duplicaterecordid`|
|ReferencingEntityNavigationPropertyName|`duplicaterecordid_msdyn_workordernte`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_workorderresolution_DuplicateBaseRecord"></a> msdyn_workorderresolution_DuplicateBaseRecord

One-To-Many Relationship: [msdyn_workorderresolution msdyn_workorderresolution_DuplicateBaseRecord](msdyn_workorderresolution.md#BKMK_msdyn_workorderresolution_DuplicateBaseRecord)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_workorderresolution`|
|ReferencedAttribute|`msdyn_workorderresolutionid`|
|ReferencingAttribute|`baserecordid`|
|ReferencingEntityNavigationPropertyName|`baserecordid_msdyn_workorderresolution`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_workorderresolution_DuplicateMatchingRecord"></a> msdyn_workorderresolution_DuplicateMatchingRecord

One-To-Many Relationship: [msdyn_workorderresolution msdyn_workorderresolution_DuplicateMatchingRecord](msdyn_workorderresolution.md#BKMK_msdyn_workorderresolution_DuplicateMatchingRecord)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_workorderresolution`|
|ReferencedAttribute|`msdyn_workorderresolutionid`|
|ReferencingAttribute|`duplicaterecordid`|
|ReferencingEntityNavigationPropertyName|`duplicaterecordid_msdyn_workorderresolution`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_workorderresourcerestriction_DuplicateBaseRecord"></a> msdyn_workorderresourcerestriction_DuplicateBaseRecord

One-To-Many Relationship: [msdyn_workorderresourcerestriction msdyn_workorderresourcerestriction_DuplicateBaseRecord](msdyn_workorderresourcerestriction.md#BKMK_msdyn_workorderresourcerestriction_DuplicateBaseRecord)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_workorderresourcerestriction`|
|ReferencedAttribute|`msdyn_workorderresourcerestrictionid`|
|ReferencingAttribute|`baserecordid`|
|ReferencingEntityNavigationPropertyName|`baserecordid_msdyn_workorderresourcerestriction`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_workorderresourcerestriction_DuplicateMatchingRecord"></a> msdyn_workorderresourcerestriction_DuplicateMatchingRecord

One-To-Many Relationship: [msdyn_workorderresourcerestriction msdyn_workorderresourcerestriction_DuplicateMatchingRecord](msdyn_workorderresourcerestriction.md#BKMK_msdyn_workorderresourcerestriction_DuplicateMatchingRecord)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_workorderresourcerestriction`|
|ReferencedAttribute|`msdyn_workorderresourcerestrictionid`|
|ReferencingAttribute|`duplicaterecordid`|
|ReferencingEntityNavigationPropertyName|`duplicaterecordid_msdyn_workorderresourcerestriction`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_workorderservice_DuplicateBaseRecord"></a> msdyn_workorderservice_DuplicateBaseRecord

One-To-Many Relationship: [msdyn_workorderservice msdyn_workorderservice_DuplicateBaseRecord](msdyn_workorderservice.md#BKMK_msdyn_workorderservice_DuplicateBaseRecord)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_workorderservice`|
|ReferencedAttribute|`msdyn_workorderserviceid`|
|ReferencingAttribute|`baserecordid`|
|ReferencingEntityNavigationPropertyName|`baserecordid_msdyn_workorderservice`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_workorderservice_DuplicateMatchingRecord"></a> msdyn_workorderservice_DuplicateMatchingRecord

One-To-Many Relationship: [msdyn_workorderservice msdyn_workorderservice_DuplicateMatchingRecord](msdyn_workorderservice.md#BKMK_msdyn_workorderservice_DuplicateMatchingRecord)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_workorderservice`|
|ReferencedAttribute|`msdyn_workorderserviceid`|
|ReferencingAttribute|`duplicaterecordid`|
|ReferencingEntityNavigationPropertyName|`duplicaterecordid_msdyn_workorderservice`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_workorderservicetask_DuplicateBaseRecord"></a> msdyn_workorderservicetask_DuplicateBaseRecord

One-To-Many Relationship: [msdyn_workorderservicetask msdyn_workorderservicetask_DuplicateBaseRecord](msdyn_workorderservicetask.md#BKMK_msdyn_workorderservicetask_DuplicateBaseRecord)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_workorderservicetask`|
|ReferencedAttribute|`msdyn_workorderservicetaskid`|
|ReferencingAttribute|`baserecordid`|
|ReferencingEntityNavigationPropertyName|`baserecordid_msdyn_workorderservicetask`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_workorderservicetask_DuplicateMatchingRecord"></a> msdyn_workorderservicetask_DuplicateMatchingRecord

One-To-Many Relationship: [msdyn_workorderservicetask msdyn_workorderservicetask_DuplicateMatchingRecord](msdyn_workorderservicetask.md#BKMK_msdyn_workorderservicetask_DuplicateMatchingRecord)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_workorderservicetask`|
|ReferencedAttribute|`msdyn_workorderservicetaskid`|
|ReferencingAttribute|`duplicaterecordid`|
|ReferencingEntityNavigationPropertyName|`duplicaterecordid_msdyn_workorderservicetask`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_workordersubstatus_DuplicateBaseRecord"></a> msdyn_workordersubstatus_DuplicateBaseRecord

One-To-Many Relationship: [msdyn_workordersubstatus msdyn_workordersubstatus_DuplicateBaseRecord](msdyn_workordersubstatus.md#BKMK_msdyn_workordersubstatus_DuplicateBaseRecord)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_workordersubstatus`|
|ReferencedAttribute|`msdyn_workordersubstatusid`|
|ReferencingAttribute|`baserecordid`|
|ReferencingEntityNavigationPropertyName|`baserecordid_msdyn_workordersubstatus`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_workordersubstatus_DuplicateMatchingRecord"></a> msdyn_workordersubstatus_DuplicateMatchingRecord

One-To-Many Relationship: [msdyn_workordersubstatus msdyn_workordersubstatus_DuplicateMatchingRecord](msdyn_workordersubstatus.md#BKMK_msdyn_workordersubstatus_DuplicateMatchingRecord)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_workordersubstatus`|
|ReferencedAttribute|`msdyn_workordersubstatusid`|
|ReferencingAttribute|`duplicaterecordid`|
|ReferencingEntityNavigationPropertyName|`duplicaterecordid_msdyn_workordersubstatus`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_workordertype_DuplicateBaseRecord"></a> msdyn_workordertype_DuplicateBaseRecord

One-To-Many Relationship: [msdyn_workordertype msdyn_workordertype_DuplicateBaseRecord](msdyn_workordertype.md#BKMK_msdyn_workordertype_DuplicateBaseRecord)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_workordertype`|
|ReferencedAttribute|`msdyn_workordertypeid`|
|ReferencingAttribute|`baserecordid`|
|ReferencingEntityNavigationPropertyName|`baserecordid_msdyn_workordertype`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_workordertype_DuplicateMatchingRecord"></a> msdyn_workordertype_DuplicateMatchingRecord

One-To-Many Relationship: [msdyn_workordertype msdyn_workordertype_DuplicateMatchingRecord](msdyn_workordertype.md#BKMK_msdyn_workordertype_DuplicateMatchingRecord)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_workordertype`|
|ReferencedAttribute|`msdyn_workordertypeid`|
|ReferencingAttribute|`duplicaterecordid`|
|ReferencingEntityNavigationPropertyName|`duplicaterecordid_msdyn_workordertype`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|



### See also

[Dataverse table/entity reference](../about-entity-reference.md)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   
<xref:Microsoft.Dynamics.CRM.duplicaterecord?displayProperty=fullName>
