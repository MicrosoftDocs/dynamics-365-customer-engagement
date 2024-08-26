---
title: "Bulk Delete Failure (BulkDeleteFailure) table/entity reference (Microsoft Dynamics 365 Field Service)"
description: "Includes schema information and supported messages for the Bulk Delete Failure (BulkDeleteFailure) table/entity with Microsoft Dynamics 365 Field Service."
ms.date: 08/26/2024
ms.service: powerapps
ms.topic: reference
author: m-hartmann
ms.author: mhart
search.audienceType: 
  - developer
---

# Bulk Delete Failure (BulkDeleteFailure) table/entity reference (Microsoft Dynamics 365 Field Service)

Record that was not deleted during a bulk deletion job.

> [!NOTE]
> The Microsoft Dynamics 365 Field Service Bulk Delete Failure (BulkDeleteFailure) table extends the [Microsoft Dynamics 365 Bulk Delete Failure (BulkDeleteFailure) table](/dynamics365/developer/entities/bulkdeletefailure).



## Customized columns/attributes

Microsoft Dynamics 365 Field Service modifies the definition of columns/attributes defined in other solutions. Listed by **SchemaName**.

### <a name="BKMK_RegardingObjectId"></a> RegardingObjectId

Changes from [RegardingObjectId (Microsoft Dataverse)](/power-apps/developer/data-platform/reference/entities/bulkdeletefailure#BKMK_RegardingObjectId)

|Property|Value|
|---|---|
|Targets|msdyn_3dmodel|


## Many-to-One relationships

These relationships are many-to-one. Listed by **SchemaName**.

- [msdyn_3dmodel_BulkDeleteFailures](#BKMK_msdyn_3dmodel_BulkDeleteFailures)
- [msdyn_actual_BulkDeleteFailures](#BKMK_msdyn_actual_BulkDeleteFailures)
- [msdyn_agreement_BulkDeleteFailures](#BKMK_msdyn_agreement_BulkDeleteFailures)
- [msdyn_agreementbookingdate_BulkDeleteFailures](#BKMK_msdyn_agreementbookingdate_BulkDeleteFailures)
- [msdyn_agreementbookingincident_BulkDeleteFailures](#BKMK_msdyn_agreementbookingincident_BulkDeleteFailures)
- [msdyn_agreementbookingproduct_BulkDeleteFailures](#BKMK_msdyn_agreementbookingproduct_BulkDeleteFailures)
- [msdyn_agreementbookingservice_BulkDeleteFailures](#BKMK_msdyn_agreementbookingservice_BulkDeleteFailures)
- [msdyn_agreementbookingservicetask_BulkDeleteFailures](#BKMK_msdyn_agreementbookingservicetask_BulkDeleteFailures)
- [msdyn_agreementbookingsetup_BulkDeleteFailures](#BKMK_msdyn_agreementbookingsetup_BulkDeleteFailures)
- [msdyn_agreementinvoicedate_BulkDeleteFailures](#BKMK_msdyn_agreementinvoicedate_BulkDeleteFailures)
- [msdyn_agreementinvoiceproduct_BulkDeleteFailures](#BKMK_msdyn_agreementinvoiceproduct_BulkDeleteFailures)
- [msdyn_agreementinvoicesetup_BulkDeleteFailures](#BKMK_msdyn_agreementinvoicesetup_BulkDeleteFailures)
- [msdyn_agreementsubstatus_BulkDeleteFailures](#BKMK_msdyn_agreementsubstatus_BulkDeleteFailures)
- [msdyn_assetsuggestionssetting_BulkDeleteFailures](#BKMK_msdyn_assetsuggestionssetting_BulkDeleteFailures)
- [msdyn_bookableresourceassociation_BulkDeleteFailures](#BKMK_msdyn_bookableresourceassociation_BulkDeleteFailures)
- [msdyn_bookableresourcebookingquicknote_BulkDeleteFailures](#BKMK_msdyn_bookableresourcebookingquicknote_BulkDeleteFailures)
- [msdyn_bookingalert_BulkDeleteFailures](#BKMK_msdyn_bookingalert_BulkDeleteFailures)
- [msdyn_bookingalertstatus_BulkDeleteFailures](#BKMK_msdyn_bookingalertstatus_BulkDeleteFailures)
- [msdyn_bookingchange_BulkDeleteFailures](#BKMK_msdyn_bookingchange_BulkDeleteFailures)
- [msdyn_bookingjournal_BulkDeleteFailures](#BKMK_msdyn_bookingjournal_BulkDeleteFailures)
- [msdyn_bookingrule_BulkDeleteFailures](#BKMK_msdyn_bookingrule_BulkDeleteFailures)
- [msdyn_bookingsetupmetadata_BulkDeleteFailures](#BKMK_msdyn_bookingsetupmetadata_BulkDeleteFailures)
- [msdyn_bookingtimestamp_BulkDeleteFailures](#BKMK_msdyn_bookingtimestamp_BulkDeleteFailures)
- [msdyn_bpf_2c5fe86acc8b414b8322ae571000c799_BulkDeleteFailures](#BKMK_msdyn_bpf_2c5fe86acc8b414b8322ae571000c799_BulkDeleteFailures)
- [msdyn_bpf_477c16f59170487b8b4dc895c5dcd09b_BulkDeleteFailures](#BKMK_msdyn_bpf_477c16f59170487b8b4dc895c5dcd09b_BulkDeleteFailures)
- [msdyn_bpf_989e9b1857e24af18787d5143b67523b_BulkDeleteFailures](#BKMK_msdyn_bpf_989e9b1857e24af18787d5143b67523b_BulkDeleteFailures)
- [msdyn_bpf_baa0a411a239410cb8bded8b5fdd88e3_BulkDeleteFailures](#BKMK_msdyn_bpf_baa0a411a239410cb8bded8b5fdd88e3_BulkDeleteFailures)
- [msdyn_bpf_d3d97bac8c294105840e99e37a9d1c39_BulkDeleteFailures](#BKMK_msdyn_bpf_d3d97bac8c294105840e99e37a9d1c39_BulkDeleteFailures)
- [msdyn_businessclosure_BulkDeleteFailures](#BKMK_msdyn_businessclosure_BulkDeleteFailures)
- [msdyn_clientextension_BulkDeleteFailures](#BKMK_msdyn_clientextension_BulkDeleteFailures)
- [msdyn_configuration_BulkDeleteFailures](#BKMK_msdyn_configuration_BulkDeleteFailures)
- [msdyn_consoleapplicationsessiontemplate_BulkDeleteFailures](#BKMK_msdyn_consoleapplicationsessiontemplate_BulkDeleteFailures)
- [msdyn_dataanalyticsreport_fs_BulkDeleteFailures](#BKMK_msdyn_dataanalyticsreport_fs_BulkDeleteFailures)
- [msdyn_dataanalyticsreport_fspredictrs_BulkDeleteFailures](#BKMK_msdyn_dataanalyticsreport_fspredictrs_BulkDeleteFailures)
- [msdyn_dataanalyticsreport_fspredictwhd_BulkDeleteFailures](#BKMK_msdyn_dataanalyticsreport_fspredictwhd_BulkDeleteFailures)
- [msdyn_entitlementapplication_BulkDeleteFailures](#BKMK_msdyn_entitlementapplication_BulkDeleteFailures)
- [msdyn_entityconfiguration_BulkDeleteFailures](#BKMK_msdyn_entityconfiguration_BulkDeleteFailures)
- [msdyn_fieldservicepricelistitem_BulkDeleteFailures](#BKMK_msdyn_fieldservicepricelistitem_BulkDeleteFailures)
- [msdyn_fieldservicesetting_BulkDeleteFailures](#BKMK_msdyn_fieldservicesetting_BulkDeleteFailures)
- [msdyn_fieldserviceslaconfiguration_BulkDeleteFailures](#BKMK_msdyn_fieldserviceslaconfiguration_BulkDeleteFailures)
- [msdyn_fieldservicesummaryconfiguration_BulkDeleteFailures](#BKMK_msdyn_fieldservicesummaryconfiguration_BulkDeleteFailures)
- [msdyn_fieldservicesystemjob_BulkDeleteFailures](#BKMK_msdyn_fieldservicesystemjob_BulkDeleteFailures)
- [msdyn_flwconfiguration_BulkDeleteFailures](#BKMK_msdyn_flwconfiguration_BulkDeleteFailures)
- [msdyn_geofence_BulkDeleteFailures](#BKMK_msdyn_geofence_BulkDeleteFailures)
- [msdyn_geofenceevent_BulkDeleteFailures](#BKMK_msdyn_geofenceevent_BulkDeleteFailures)
- [msdyn_geofencingsettings_BulkDeleteFailures](#BKMK_msdyn_geofencingsettings_BulkDeleteFailures)
- [msdyn_geolocationsettings_BulkDeleteFailures](#BKMK_msdyn_geolocationsettings_BulkDeleteFailures)
- [msdyn_geolocationtracking_BulkDeleteFailures](#BKMK_msdyn_geolocationtracking_BulkDeleteFailures)
- [msdyn_incidenttype_BulkDeleteFailures](#BKMK_msdyn_incidenttype_BulkDeleteFailures)
- [msdyn_incidenttype_requirementgroup_BulkDeleteFailures](#BKMK_msdyn_incidenttype_requirementgroup_BulkDeleteFailures)
- [msdyn_incidenttypecharacteristic_BulkDeleteFailures](#BKMK_msdyn_incidenttypecharacteristic_BulkDeleteFailures)
- [msdyn_incidenttypeproduct_BulkDeleteFailures](#BKMK_msdyn_incidenttypeproduct_BulkDeleteFailures)
- [msdyn_incidenttyperecommendationresult_BulkDeleteFailures](#BKMK_msdyn_incidenttyperecommendationresult_BulkDeleteFailures)
- [msdyn_incidenttyperecommendationrunhistory_BulkDeleteFailures](#BKMK_msdyn_incidenttyperecommendationrunhistory_BulkDeleteFailures)
- [msdyn_incidenttyperesolution_BulkDeleteFailures](#BKMK_msdyn_incidenttyperesolution_BulkDeleteFailures)
- [msdyn_incidenttypeservice_BulkDeleteFailures](#BKMK_msdyn_incidenttypeservice_BulkDeleteFailures)
- [msdyn_incidenttypeservicetask_BulkDeleteFailures](#BKMK_msdyn_incidenttypeservicetask_BulkDeleteFailures)
- [msdyn_incidenttypessetup_BulkDeleteFailures](#BKMK_msdyn_incidenttypessetup_BulkDeleteFailures)
- [msdyn_inspection_BulkDeleteFailures](#BKMK_msdyn_inspection_BulkDeleteFailures)
- [msdyn_inspectionattachment_BulkDeleteFailures](#BKMK_msdyn_inspectionattachment_BulkDeleteFailures)
- [msdyn_inspectiondefinition_BulkDeleteFailures](#BKMK_msdyn_inspectiondefinition_BulkDeleteFailures)
- [msdyn_inspectioninstance_BulkDeleteFailures](#BKMK_msdyn_inspectioninstance_BulkDeleteFailures)
- [msdyn_inspectionresponse_BulkDeleteFailures](#BKMK_msdyn_inspectionresponse_BulkDeleteFailures)
- [msdyn_insurance_BulkDeleteFailures](#BKMK_msdyn_insurance_BulkDeleteFailures)
- [msdyn_inventoryadjustment_BulkDeleteFailures](#BKMK_msdyn_inventoryadjustment_BulkDeleteFailures)
- [msdyn_inventoryadjustmentproduct_BulkDeleteFailures](#BKMK_msdyn_inventoryadjustmentproduct_BulkDeleteFailures)
- [msdyn_inventoryjournal_BulkDeleteFailures](#BKMK_msdyn_inventoryjournal_BulkDeleteFailures)
- [msdyn_inventorytransfer_BulkDeleteFailures](#BKMK_msdyn_inventorytransfer_BulkDeleteFailures)
- [msdyn_mobilesource_BulkDeleteFailures](#BKMK_msdyn_mobilesource_BulkDeleteFailures)
- [msdyn_nottoexceed_BulkDeleteFailures](#BKMK_msdyn_nottoexceed_BulkDeleteFailures)
- [msdyn_orderinvoicingdate_BulkDeleteFailures](#BKMK_msdyn_orderinvoicingdate_BulkDeleteFailures)
- [msdyn_orderinvoicingproduct_BulkDeleteFailures](#BKMK_msdyn_orderinvoicingproduct_BulkDeleteFailures)
- [msdyn_orderinvoicingsetup_BulkDeleteFailures](#BKMK_msdyn_orderinvoicingsetup_BulkDeleteFailures)
- [msdyn_orderinvoicingsetupdate_BulkDeleteFailures](#BKMK_msdyn_orderinvoicingsetupdate_BulkDeleteFailures)
- [msdyn_organizationalunit_BulkDeleteFailures](#BKMK_msdyn_organizationalunit_BulkDeleteFailures)
- [msdyn_payment_BulkDeleteFailures](#BKMK_msdyn_payment_BulkDeleteFailures)
- [msdyn_paymentdetail_BulkDeleteFailures](#BKMK_msdyn_paymentdetail_BulkDeleteFailures)
- [msdyn_paymentmethod_BulkDeleteFailures](#BKMK_msdyn_paymentmethod_BulkDeleteFailures)
- [msdyn_paymentterm_BulkDeleteFailures](#BKMK_msdyn_paymentterm_BulkDeleteFailures)
- [msdyn_postalcode_BulkDeleteFailures](#BKMK_msdyn_postalcode_BulkDeleteFailures)
- [msdyn_predictworkhourdurationsetting_BulkDeleteFailures](#BKMK_msdyn_predictworkhourdurationsetting_BulkDeleteFailures)
- [msdyn_priority_BulkDeleteFailures](#BKMK_msdyn_priority_BulkDeleteFailures)
- [msdyn_problematicasset_BulkDeleteFailures](#BKMK_msdyn_problematicasset_BulkDeleteFailures)
- [msdyn_problematicassetfeedback_BulkDeleteFailures](#BKMK_msdyn_problematicassetfeedback_BulkDeleteFailures)
- [msdyn_productinventory_BulkDeleteFailures](#BKMK_msdyn_productinventory_BulkDeleteFailures)
- [msdyn_purchaseorder_BulkDeleteFailures](#BKMK_msdyn_purchaseorder_BulkDeleteFailures)
- [msdyn_purchaseorderbill_BulkDeleteFailures](#BKMK_msdyn_purchaseorderbill_BulkDeleteFailures)
- [msdyn_purchaseorderproduct_BulkDeleteFailures](#BKMK_msdyn_purchaseorderproduct_BulkDeleteFailures)
- [msdyn_purchaseorderreceipt_BulkDeleteFailures](#BKMK_msdyn_purchaseorderreceipt_BulkDeleteFailures)
- [msdyn_purchaseorderreceiptproduct_BulkDeleteFailures](#BKMK_msdyn_purchaseorderreceiptproduct_BulkDeleteFailures)
- [msdyn_purchaseordersubstatus_BulkDeleteFailures](#BKMK_msdyn_purchaseordersubstatus_BulkDeleteFailures)
- [msdyn_quotebookingincident_BulkDeleteFailures](#BKMK_msdyn_quotebookingincident_BulkDeleteFailures)
- [msdyn_quotebookingproduct_BulkDeleteFailures](#BKMK_msdyn_quotebookingproduct_BulkDeleteFailures)
- [msdyn_quotebookingservice_BulkDeleteFailures](#BKMK_msdyn_quotebookingservice_BulkDeleteFailures)
- [msdyn_quotebookingservicetask_BulkDeleteFailures](#BKMK_msdyn_quotebookingservicetask_BulkDeleteFailures)
- [msdyn_quotebookingsetup_BulkDeleteFailures](#BKMK_msdyn_quotebookingsetup_BulkDeleteFailures)
- [msdyn_quoteinvoicingproduct_BulkDeleteFailures](#BKMK_msdyn_quoteinvoicingproduct_BulkDeleteFailures)
- [msdyn_quoteinvoicingsetup_BulkDeleteFailures](#BKMK_msdyn_quoteinvoicingsetup_BulkDeleteFailures)
- [msdyn_requirementchange_BulkDeleteFailures](#BKMK_msdyn_requirementchange_BulkDeleteFailures)
- [msdyn_requirementcharacteristic_BulkDeleteFailures](#BKMK_msdyn_requirementcharacteristic_BulkDeleteFailures)
- [msdyn_requirementdependency_BulkDeleteFailures](#BKMK_msdyn_requirementdependency_BulkDeleteFailures)
- [msdyn_requirementgroup_BulkDeleteFailures](#BKMK_msdyn_requirementgroup_BulkDeleteFailures)
- [msdyn_requirementorganizationunit_BulkDeleteFailures](#BKMK_msdyn_requirementorganizationunit_BulkDeleteFailures)
- [msdyn_requirementrelationship_BulkDeleteFailures](#BKMK_msdyn_requirementrelationship_BulkDeleteFailures)
- [msdyn_requirementresourcecategory_BulkDeleteFailures](#BKMK_msdyn_requirementresourcecategory_BulkDeleteFailures)
- [msdyn_requirementresourcepreference_BulkDeleteFailures](#BKMK_msdyn_requirementresourcepreference_BulkDeleteFailures)
- [msdyn_requirementstatus_BulkDeleteFailures](#BKMK_msdyn_requirementstatus_BulkDeleteFailures)
- [msdyn_resolution_BulkDeleteFailures](#BKMK_msdyn_resolution_BulkDeleteFailures)
- [msdyn_resourcepaytype_BulkDeleteFailures](#BKMK_msdyn_resourcepaytype_BulkDeleteFailures)
- [msdyn_resourcerequirement_BulkDeleteFailures](#BKMK_msdyn_resourcerequirement_BulkDeleteFailures)
- [msdyn_resourcerequirementdetail_BulkDeleteFailures](#BKMK_msdyn_resourcerequirementdetail_BulkDeleteFailures)
- [msdyn_resourceterritory_BulkDeleteFailures](#BKMK_msdyn_resourceterritory_BulkDeleteFailures)
- [msdyn_rma_BulkDeleteFailures](#BKMK_msdyn_rma_BulkDeleteFailures)
- [msdyn_rmaproduct_BulkDeleteFailures](#BKMK_msdyn_rmaproduct_BulkDeleteFailures)
- [msdyn_rmareceipt_BulkDeleteFailures](#BKMK_msdyn_rmareceipt_BulkDeleteFailures)
- [msdyn_rmareceiptproduct_BulkDeleteFailures](#BKMK_msdyn_rmareceiptproduct_BulkDeleteFailures)
- [msdyn_rmasubstatus_BulkDeleteFailures](#BKMK_msdyn_rmasubstatus_BulkDeleteFailures)
- [msdyn_rtv_BulkDeleteFailures](#BKMK_msdyn_rtv_BulkDeleteFailures)
- [msdyn_rtvproduct_BulkDeleteFailures](#BKMK_msdyn_rtvproduct_BulkDeleteFailures)
- [msdyn_rtvsubstatus_BulkDeleteFailures](#BKMK_msdyn_rtvsubstatus_BulkDeleteFailures)
- [msdyn_scheduleboardsetting_BulkDeleteFailures](#BKMK_msdyn_scheduleboardsetting_BulkDeleteFailures)
- [msdyn_schedulingfeatureflag_BulkDeleteFailures](#BKMK_msdyn_schedulingfeatureflag_BulkDeleteFailures)
- [msdyn_schedulingparameter_BulkDeleteFailures](#BKMK_msdyn_schedulingparameter_BulkDeleteFailures)
- [msdyn_servicetasktype_BulkDeleteFailures](#BKMK_msdyn_servicetasktype_BulkDeleteFailures)
- [msdyn_sessiondata_BulkDeleteFailures](#BKMK_msdyn_sessiondata_BulkDeleteFailures)
- [msdyn_sessionparticipantdata_BulkDeleteFailures](#BKMK_msdyn_sessionparticipantdata_BulkDeleteFailures)
- [msdyn_shipvia_BulkDeleteFailures](#BKMK_msdyn_shipvia_BulkDeleteFailures)
- [msdyn_systemuserschedulersetting_BulkDeleteFailures](#BKMK_msdyn_systemuserschedulersetting_BulkDeleteFailures)
- [msdyn_taxcode_BulkDeleteFailures](#BKMK_msdyn_taxcode_BulkDeleteFailures)
- [msdyn_taxcodedetail_BulkDeleteFailures](#BKMK_msdyn_taxcodedetail_BulkDeleteFailures)
- [msdyn_timeentry_BulkDeleteFailures](#BKMK_msdyn_timeentry_BulkDeleteFailures)
- [msdyn_timeentrysetting_BulkDeleteFailures](#BKMK_msdyn_timeentrysetting_BulkDeleteFailures)
- [msdyn_timegroup_BulkDeleteFailures](#BKMK_msdyn_timegroup_BulkDeleteFailures)
- [msdyn_timegroupdetail_BulkDeleteFailures](#BKMK_msdyn_timegroupdetail_BulkDeleteFailures)
- [msdyn_timeoffrequest_BulkDeleteFailures](#BKMK_msdyn_timeoffrequest_BulkDeleteFailures)
- [msdyn_trade_BulkDeleteFailures](#BKMK_msdyn_trade_BulkDeleteFailures)
- [msdyn_tradecoverage_BulkDeleteFailures](#BKMK_msdyn_tradecoverage_BulkDeleteFailures)
- [msdyn_transactionorigin_BulkDeleteFailures](#BKMK_msdyn_transactionorigin_BulkDeleteFailures)
- [msdyn_uniquenumber_BulkDeleteFailures](#BKMK_msdyn_uniquenumber_BulkDeleteFailures)
- [msdyn_warehouse_BulkDeleteFailures](#BKMK_msdyn_warehouse_BulkDeleteFailures)
- [msdyn_workhourtemplate_BulkDeleteFailures](#BKMK_msdyn_workhourtemplate_BulkDeleteFailures)
- [msdyn_workorder_BulkDeleteFailures](#BKMK_msdyn_workorder_BulkDeleteFailures)
- [msdyn_workorderincident_BulkDeleteFailures](#BKMK_msdyn_workorderincident_BulkDeleteFailures)
- [msdyn_workordernte_BulkDeleteFailures](#BKMK_msdyn_workordernte_BulkDeleteFailures)
- [msdyn_workorderproduct_BulkDeleteFailures](#BKMK_msdyn_workorderproduct_BulkDeleteFailures)
- [msdyn_workorderresolution_BulkDeleteFailures](#BKMK_msdyn_workorderresolution_BulkDeleteFailures)
- [msdyn_workorderresourcerestriction_BulkDeleteFailures](#BKMK_msdyn_workorderresourcerestriction_BulkDeleteFailures)
- [msdyn_workorderservice_BulkDeleteFailures](#BKMK_msdyn_workorderservice_BulkDeleteFailures)
- [msdyn_workorderservicetask_BulkDeleteFailures](#BKMK_msdyn_workorderservicetask_BulkDeleteFailures)
- [msdyn_workordersubstatus_BulkDeleteFailures](#BKMK_msdyn_workordersubstatus_BulkDeleteFailures)
- [msdyn_workordertype_BulkDeleteFailures](#BKMK_msdyn_workordertype_BulkDeleteFailures)

### <a name="BKMK_msdyn_3dmodel_BulkDeleteFailures"></a> msdyn_3dmodel_BulkDeleteFailures

One-To-Many Relationship: [msdyn_3dmodel msdyn_3dmodel_BulkDeleteFailures](msdyn_3dmodel.md#BKMK_msdyn_3dmodel_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_3dmodel`|
|ReferencedAttribute|`msdyn_3dmodelid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_3dmodel`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_actual_BulkDeleteFailures"></a> msdyn_actual_BulkDeleteFailures

One-To-Many Relationship: [msdyn_actual msdyn_actual_BulkDeleteFailures](msdyn_actual.md#BKMK_msdyn_actual_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_actual`|
|ReferencedAttribute|`msdyn_actualid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_actual`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_agreement_BulkDeleteFailures"></a> msdyn_agreement_BulkDeleteFailures

One-To-Many Relationship: [msdyn_agreement msdyn_agreement_BulkDeleteFailures](msdyn_agreement.md#BKMK_msdyn_agreement_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_agreement`|
|ReferencedAttribute|`msdyn_agreementid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_agreement`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_agreementbookingdate_BulkDeleteFailures"></a> msdyn_agreementbookingdate_BulkDeleteFailures

One-To-Many Relationship: [msdyn_agreementbookingdate msdyn_agreementbookingdate_BulkDeleteFailures](msdyn_agreementbookingdate.md#BKMK_msdyn_agreementbookingdate_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_agreementbookingdate`|
|ReferencedAttribute|`msdyn_agreementbookingdateid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_agreementbookingdate`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_agreementbookingincident_BulkDeleteFailures"></a> msdyn_agreementbookingincident_BulkDeleteFailures

One-To-Many Relationship: [msdyn_agreementbookingincident msdyn_agreementbookingincident_BulkDeleteFailures](msdyn_agreementbookingincident.md#BKMK_msdyn_agreementbookingincident_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_agreementbookingincident`|
|ReferencedAttribute|`msdyn_agreementbookingincidentid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_agreementbookingincident`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_agreementbookingproduct_BulkDeleteFailures"></a> msdyn_agreementbookingproduct_BulkDeleteFailures

One-To-Many Relationship: [msdyn_agreementbookingproduct msdyn_agreementbookingproduct_BulkDeleteFailures](msdyn_agreementbookingproduct.md#BKMK_msdyn_agreementbookingproduct_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_agreementbookingproduct`|
|ReferencedAttribute|`msdyn_agreementbookingproductid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_agreementbookingproduct`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_agreementbookingservice_BulkDeleteFailures"></a> msdyn_agreementbookingservice_BulkDeleteFailures

One-To-Many Relationship: [msdyn_agreementbookingservice msdyn_agreementbookingservice_BulkDeleteFailures](msdyn_agreementbookingservice.md#BKMK_msdyn_agreementbookingservice_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_agreementbookingservice`|
|ReferencedAttribute|`msdyn_agreementbookingserviceid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_agreementbookingservice`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_agreementbookingservicetask_BulkDeleteFailures"></a> msdyn_agreementbookingservicetask_BulkDeleteFailures

One-To-Many Relationship: [msdyn_agreementbookingservicetask msdyn_agreementbookingservicetask_BulkDeleteFailures](msdyn_agreementbookingservicetask.md#BKMK_msdyn_agreementbookingservicetask_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_agreementbookingservicetask`|
|ReferencedAttribute|`msdyn_agreementbookingservicetaskid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_agreementbookingservicetask`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_agreementbookingsetup_BulkDeleteFailures"></a> msdyn_agreementbookingsetup_BulkDeleteFailures

One-To-Many Relationship: [msdyn_agreementbookingsetup msdyn_agreementbookingsetup_BulkDeleteFailures](msdyn_agreementbookingsetup.md#BKMK_msdyn_agreementbookingsetup_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_agreementbookingsetup`|
|ReferencedAttribute|`msdyn_agreementbookingsetupid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_agreementbookingsetup`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_agreementinvoicedate_BulkDeleteFailures"></a> msdyn_agreementinvoicedate_BulkDeleteFailures

One-To-Many Relationship: [msdyn_agreementinvoicedate msdyn_agreementinvoicedate_BulkDeleteFailures](msdyn_agreementinvoicedate.md#BKMK_msdyn_agreementinvoicedate_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_agreementinvoicedate`|
|ReferencedAttribute|`msdyn_agreementinvoicedateid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_agreementinvoicedate`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_agreementinvoiceproduct_BulkDeleteFailures"></a> msdyn_agreementinvoiceproduct_BulkDeleteFailures

One-To-Many Relationship: [msdyn_agreementinvoiceproduct msdyn_agreementinvoiceproduct_BulkDeleteFailures](msdyn_agreementinvoiceproduct.md#BKMK_msdyn_agreementinvoiceproduct_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_agreementinvoiceproduct`|
|ReferencedAttribute|`msdyn_agreementinvoiceproductid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_agreementinvoiceproduct`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_agreementinvoicesetup_BulkDeleteFailures"></a> msdyn_agreementinvoicesetup_BulkDeleteFailures

One-To-Many Relationship: [msdyn_agreementinvoicesetup msdyn_agreementinvoicesetup_BulkDeleteFailures](msdyn_agreementinvoicesetup.md#BKMK_msdyn_agreementinvoicesetup_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_agreementinvoicesetup`|
|ReferencedAttribute|`msdyn_agreementinvoicesetupid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_agreementinvoicesetup`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_agreementsubstatus_BulkDeleteFailures"></a> msdyn_agreementsubstatus_BulkDeleteFailures

One-To-Many Relationship: [msdyn_agreementsubstatus msdyn_agreementsubstatus_BulkDeleteFailures](msdyn_agreementsubstatus.md#BKMK_msdyn_agreementsubstatus_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_agreementsubstatus`|
|ReferencedAttribute|`msdyn_agreementsubstatusid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_agreementsubstatus`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_assetsuggestionssetting_BulkDeleteFailures"></a> msdyn_assetsuggestionssetting_BulkDeleteFailures

One-To-Many Relationship: [msdyn_assetsuggestionssetting msdyn_assetsuggestionssetting_BulkDeleteFailures](msdyn_assetsuggestionssetting.md#BKMK_msdyn_assetsuggestionssetting_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_assetsuggestionssetting`|
|ReferencedAttribute|`msdyn_assetsuggestionssettingid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_assetsuggestionssetting`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_bookableresourceassociation_BulkDeleteFailures"></a> msdyn_bookableresourceassociation_BulkDeleteFailures

One-To-Many Relationship: [msdyn_bookableresourceassociation msdyn_bookableresourceassociation_BulkDeleteFailures](msdyn_bookableresourceassociation.md#BKMK_msdyn_bookableresourceassociation_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_bookableresourceassociation`|
|ReferencedAttribute|`msdyn_bookableresourceassociationid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_bookableresourceassociation`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_bookableresourcebookingquicknote_BulkDeleteFailures"></a> msdyn_bookableresourcebookingquicknote_BulkDeleteFailures

One-To-Many Relationship: [msdyn_bookableresourcebookingquicknote msdyn_bookableresourcebookingquicknote_BulkDeleteFailures](msdyn_bookableresourcebookingquicknote.md#BKMK_msdyn_bookableresourcebookingquicknote_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_bookableresourcebookingquicknote`|
|ReferencedAttribute|`msdyn_bookableresourcebookingquicknoteid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_bookableresourcebookingquicknote`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_bookingalert_BulkDeleteFailures"></a> msdyn_bookingalert_BulkDeleteFailures

One-To-Many Relationship: [msdyn_bookingalert msdyn_bookingalert_BulkDeleteFailures](msdyn_bookingalert.md#BKMK_msdyn_bookingalert_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_bookingalert`|
|ReferencedAttribute|`activityid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_bookingalert`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_bookingalertstatus_BulkDeleteFailures"></a> msdyn_bookingalertstatus_BulkDeleteFailures

One-To-Many Relationship: [msdyn_bookingalertstatus msdyn_bookingalertstatus_BulkDeleteFailures](msdyn_bookingalertstatus.md#BKMK_msdyn_bookingalertstatus_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_bookingalertstatus`|
|ReferencedAttribute|`msdyn_bookingalertstatusid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_bookingalertstatus`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_bookingchange_BulkDeleteFailures"></a> msdyn_bookingchange_BulkDeleteFailures

One-To-Many Relationship: [msdyn_bookingchange msdyn_bookingchange_BulkDeleteFailures](msdyn_bookingchange.md#BKMK_msdyn_bookingchange_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_bookingchange`|
|ReferencedAttribute|`msdyn_bookingchangeid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_bookingchange`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_bookingjournal_BulkDeleteFailures"></a> msdyn_bookingjournal_BulkDeleteFailures

One-To-Many Relationship: [msdyn_bookingjournal msdyn_bookingjournal_BulkDeleteFailures](msdyn_bookingjournal.md#BKMK_msdyn_bookingjournal_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_bookingjournal`|
|ReferencedAttribute|`msdyn_bookingjournalid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_bookingjournal`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_bookingrule_BulkDeleteFailures"></a> msdyn_bookingrule_BulkDeleteFailures

One-To-Many Relationship: [msdyn_bookingrule msdyn_bookingrule_BulkDeleteFailures](msdyn_bookingrule.md#BKMK_msdyn_bookingrule_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_bookingrule`|
|ReferencedAttribute|`msdyn_bookingruleid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_bookingrule`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_bookingsetupmetadata_BulkDeleteFailures"></a> msdyn_bookingsetupmetadata_BulkDeleteFailures

One-To-Many Relationship: [msdyn_bookingsetupmetadata msdyn_bookingsetupmetadata_BulkDeleteFailures](msdyn_bookingsetupmetadata.md#BKMK_msdyn_bookingsetupmetadata_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_bookingsetupmetadata`|
|ReferencedAttribute|`msdyn_bookingsetupmetadataid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_bookingsetupmetadata`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_bookingtimestamp_BulkDeleteFailures"></a> msdyn_bookingtimestamp_BulkDeleteFailures

One-To-Many Relationship: [msdyn_bookingtimestamp msdyn_bookingtimestamp_BulkDeleteFailures](msdyn_bookingtimestamp.md#BKMK_msdyn_bookingtimestamp_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_bookingtimestamp`|
|ReferencedAttribute|`msdyn_bookingtimestampid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_bookingtimestamp`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_bpf_2c5fe86acc8b414b8322ae571000c799_BulkDeleteFailures"></a> msdyn_bpf_2c5fe86acc8b414b8322ae571000c799_BulkDeleteFailures

One-To-Many Relationship: [msdyn_bpf_2c5fe86acc8b414b8322ae571000c799 msdyn_bpf_2c5fe86acc8b414b8322ae571000c799_BulkDeleteFailures](msdyn_bpf_2c5fe86acc8b414b8322ae571000c799.md#BKMK_msdyn_bpf_2c5fe86acc8b414b8322ae571000c799_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_bpf_2c5fe86acc8b414b8322ae571000c799`|
|ReferencedAttribute|`businessprocessflowinstanceid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_bpf_2c5fe86acc8b414b8322ae571000c799`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_bpf_477c16f59170487b8b4dc895c5dcd09b_BulkDeleteFailures"></a> msdyn_bpf_477c16f59170487b8b4dc895c5dcd09b_BulkDeleteFailures

One-To-Many Relationship: [msdyn_bpf_477c16f59170487b8b4dc895c5dcd09b msdyn_bpf_477c16f59170487b8b4dc895c5dcd09b_BulkDeleteFailures](msdyn_bpf_477c16f59170487b8b4dc895c5dcd09b.md#BKMK_msdyn_bpf_477c16f59170487b8b4dc895c5dcd09b_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_bpf_477c16f59170487b8b4dc895c5dcd09b`|
|ReferencedAttribute|`businessprocessflowinstanceid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_bpf_477c16f59170487b8b4dc895c5dcd09b`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_bpf_989e9b1857e24af18787d5143b67523b_BulkDeleteFailures"></a> msdyn_bpf_989e9b1857e24af18787d5143b67523b_BulkDeleteFailures

One-To-Many Relationship: [msdyn_bpf_989e9b1857e24af18787d5143b67523b msdyn_bpf_989e9b1857e24af18787d5143b67523b_BulkDeleteFailures](msdyn_bpf_989e9b1857e24af18787d5143b67523b.md#BKMK_msdyn_bpf_989e9b1857e24af18787d5143b67523b_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_bpf_989e9b1857e24af18787d5143b67523b`|
|ReferencedAttribute|`businessprocessflowinstanceid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_bpf_989e9b1857e24af18787d5143b67523b`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_bpf_baa0a411a239410cb8bded8b5fdd88e3_BulkDeleteFailures"></a> msdyn_bpf_baa0a411a239410cb8bded8b5fdd88e3_BulkDeleteFailures

One-To-Many Relationship: [msdyn_bpf_baa0a411a239410cb8bded8b5fdd88e3 msdyn_bpf_baa0a411a239410cb8bded8b5fdd88e3_BulkDeleteFailures](msdyn_bpf_baa0a411a239410cb8bded8b5fdd88e3.md#BKMK_msdyn_bpf_baa0a411a239410cb8bded8b5fdd88e3_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_bpf_baa0a411a239410cb8bded8b5fdd88e3`|
|ReferencedAttribute|`businessprocessflowinstanceid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_bpf_baa0a411a239410cb8bded8b5fdd88e3`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_bpf_d3d97bac8c294105840e99e37a9d1c39_BulkDeleteFailures"></a> msdyn_bpf_d3d97bac8c294105840e99e37a9d1c39_BulkDeleteFailures

One-To-Many Relationship: [msdyn_bpf_d3d97bac8c294105840e99e37a9d1c39 msdyn_bpf_d3d97bac8c294105840e99e37a9d1c39_BulkDeleteFailures](msdyn_bpf_d3d97bac8c294105840e99e37a9d1c39.md#BKMK_msdyn_bpf_d3d97bac8c294105840e99e37a9d1c39_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_bpf_d3d97bac8c294105840e99e37a9d1c39`|
|ReferencedAttribute|`businessprocessflowinstanceid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_bpf_d3d97bac8c294105840e99e37a9d1c39`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_businessclosure_BulkDeleteFailures"></a> msdyn_businessclosure_BulkDeleteFailures

One-To-Many Relationship: [msdyn_businessclosure msdyn_businessclosure_BulkDeleteFailures](msdyn_businessclosure.md#BKMK_msdyn_businessclosure_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_businessclosure`|
|ReferencedAttribute|`msdyn_businessclosureid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_businessclosure`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_clientextension_BulkDeleteFailures"></a> msdyn_clientextension_BulkDeleteFailures

One-To-Many Relationship: [msdyn_clientextension msdyn_clientextension_BulkDeleteFailures](msdyn_clientextension.md#BKMK_msdyn_clientextension_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_clientextension`|
|ReferencedAttribute|`msdyn_clientextensionid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_clientextension`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_configuration_BulkDeleteFailures"></a> msdyn_configuration_BulkDeleteFailures

One-To-Many Relationship: [msdyn_configuration msdyn_configuration_BulkDeleteFailures](msdyn_configuration.md#BKMK_msdyn_configuration_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_configuration`|
|ReferencedAttribute|`msdyn_configurationid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_configuration`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_consoleapplicationsessiontemplate_BulkDeleteFailures"></a> msdyn_consoleapplicationsessiontemplate_BulkDeleteFailures

One-To-Many Relationship: [msdyn_consoleapplicationsessiontemplate msdyn_consoleapplicationsessiontemplate_BulkDeleteFailures](msdyn_consoleapplicationsessiontemplate.md#BKMK_msdyn_consoleapplicationsessiontemplate_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_consoleapplicationsessiontemplate`|
|ReferencedAttribute|`msdyn_consoleapplicationsessiontemplateid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_consoleapplicationsessiontemplate`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_dataanalyticsreport_fs_BulkDeleteFailures"></a> msdyn_dataanalyticsreport_fs_BulkDeleteFailures

One-To-Many Relationship: [msdyn_dataanalyticsreport_fs msdyn_dataanalyticsreport_fs_BulkDeleteFailures](msdyn_dataanalyticsreport_fs.md#BKMK_msdyn_dataanalyticsreport_fs_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_dataanalyticsreport_fs`|
|ReferencedAttribute|`msdyn_dataanalyticsreport_fsid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_dataanalyticsreport_fs`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_dataanalyticsreport_fspredictrs_BulkDeleteFailures"></a> msdyn_dataanalyticsreport_fspredictrs_BulkDeleteFailures

One-To-Many Relationship: [msdyn_dataanalyticsreport_fspredictrs msdyn_dataanalyticsreport_fspredictrs_BulkDeleteFailures](msdyn_dataanalyticsreport_fspredictrs.md#BKMK_msdyn_dataanalyticsreport_fspredictrs_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_dataanalyticsreport_fspredictrs`|
|ReferencedAttribute|`msdyn_dataanalyticsreport_fspredictrsid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_dataanalyticsreport_fspredictrs`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_dataanalyticsreport_fspredictwhd_BulkDeleteFailures"></a> msdyn_dataanalyticsreport_fspredictwhd_BulkDeleteFailures

One-To-Many Relationship: [msdyn_dataanalyticsreport_fspredictwhd msdyn_dataanalyticsreport_fspredictwhd_BulkDeleteFailures](msdyn_dataanalyticsreport_fspredictwhd.md#BKMK_msdyn_dataanalyticsreport_fspredictwhd_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_dataanalyticsreport_fspredictwhd`|
|ReferencedAttribute|`msdyn_dataanalyticsreport_fspredictwhdid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_dataanalyticsreport_fspredictwhd`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_entitlementapplication_BulkDeleteFailures"></a> msdyn_entitlementapplication_BulkDeleteFailures

One-To-Many Relationship: [msdyn_entitlementapplication msdyn_entitlementapplication_BulkDeleteFailures](msdyn_entitlementapplication.md#BKMK_msdyn_entitlementapplication_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_entitlementapplication`|
|ReferencedAttribute|`msdyn_entitlementapplicationid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_entitlementapplication`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_entityconfiguration_BulkDeleteFailures"></a> msdyn_entityconfiguration_BulkDeleteFailures

One-To-Many Relationship: [msdyn_entityconfiguration msdyn_entityconfiguration_BulkDeleteFailures](msdyn_entityconfiguration.md#BKMK_msdyn_entityconfiguration_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_entityconfiguration`|
|ReferencedAttribute|`msdyn_entityconfigurationid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_entityconfiguration`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_fieldservicepricelistitem_BulkDeleteFailures"></a> msdyn_fieldservicepricelistitem_BulkDeleteFailures

One-To-Many Relationship: [msdyn_fieldservicepricelistitem msdyn_fieldservicepricelistitem_BulkDeleteFailures](msdyn_fieldservicepricelistitem.md#BKMK_msdyn_fieldservicepricelistitem_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_fieldservicepricelistitem`|
|ReferencedAttribute|`msdyn_fieldservicepricelistitemid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_fieldservicepricelistitem`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_fieldservicesetting_BulkDeleteFailures"></a> msdyn_fieldservicesetting_BulkDeleteFailures

One-To-Many Relationship: [msdyn_fieldservicesetting msdyn_fieldservicesetting_BulkDeleteFailures](msdyn_fieldservicesetting.md#BKMK_msdyn_fieldservicesetting_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_fieldservicesetting`|
|ReferencedAttribute|`msdyn_fieldservicesettingid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_fieldservicesetting`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_fieldserviceslaconfiguration_BulkDeleteFailures"></a> msdyn_fieldserviceslaconfiguration_BulkDeleteFailures

One-To-Many Relationship: [msdyn_fieldserviceslaconfiguration msdyn_fieldserviceslaconfiguration_BulkDeleteFailures](msdyn_fieldserviceslaconfiguration.md#BKMK_msdyn_fieldserviceslaconfiguration_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_fieldserviceslaconfiguration`|
|ReferencedAttribute|`msdyn_fieldserviceslaconfigurationid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_fieldserviceslaconfiguration`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_fieldservicesummaryconfiguration_BulkDeleteFailures"></a> msdyn_fieldservicesummaryconfiguration_BulkDeleteFailures

One-To-Many Relationship: [msdyn_fieldservicesummaryconfiguration msdyn_fieldservicesummaryconfiguration_BulkDeleteFailures](msdyn_fieldservicesummaryconfiguration.md#BKMK_msdyn_fieldservicesummaryconfiguration_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_fieldservicesummaryconfiguration`|
|ReferencedAttribute|`msdyn_fieldservicesummaryconfigurationid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_fieldservicesummaryconfiguration`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_fieldservicesystemjob_BulkDeleteFailures"></a> msdyn_fieldservicesystemjob_BulkDeleteFailures

One-To-Many Relationship: [msdyn_fieldservicesystemjob msdyn_fieldservicesystemjob_BulkDeleteFailures](msdyn_fieldservicesystemjob.md#BKMK_msdyn_fieldservicesystemjob_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_fieldservicesystemjob`|
|ReferencedAttribute|`msdyn_fieldservicesystemjobid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_fieldservicesystemjob`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_flwconfiguration_BulkDeleteFailures"></a> msdyn_flwconfiguration_BulkDeleteFailures

One-To-Many Relationship: [msdyn_flwconfiguration msdyn_flwconfiguration_BulkDeleteFailures](msdyn_flwconfiguration.md#BKMK_msdyn_flwconfiguration_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_flwconfiguration`|
|ReferencedAttribute|`msdyn_flwconfigurationid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_flwconfiguration`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_geofence_BulkDeleteFailures"></a> msdyn_geofence_BulkDeleteFailures

One-To-Many Relationship: [msdyn_geofence msdyn_geofence_BulkDeleteFailures](msdyn_geofence.md#BKMK_msdyn_geofence_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_geofence`|
|ReferencedAttribute|`msdyn_geofenceid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_geofence`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_geofenceevent_BulkDeleteFailures"></a> msdyn_geofenceevent_BulkDeleteFailures

One-To-Many Relationship: [msdyn_geofenceevent msdyn_geofenceevent_BulkDeleteFailures](msdyn_geofenceevent.md#BKMK_msdyn_geofenceevent_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_geofenceevent`|
|ReferencedAttribute|`msdyn_geofenceeventid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_geofenceevent`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_geofencingsettings_BulkDeleteFailures"></a> msdyn_geofencingsettings_BulkDeleteFailures

One-To-Many Relationship: [msdyn_geofencingsettings msdyn_geofencingsettings_BulkDeleteFailures](msdyn_geofencingsettings.md#BKMK_msdyn_geofencingsettings_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_geofencingsettings`|
|ReferencedAttribute|`msdyn_geofencingsettingsid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_geofencingsettings`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_geolocationsettings_BulkDeleteFailures"></a> msdyn_geolocationsettings_BulkDeleteFailures

One-To-Many Relationship: [msdyn_geolocationsettings msdyn_geolocationsettings_BulkDeleteFailures](msdyn_geolocationsettings.md#BKMK_msdyn_geolocationsettings_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_geolocationsettings`|
|ReferencedAttribute|`msdyn_geolocationsettingsid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_geolocationsettings`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_geolocationtracking_BulkDeleteFailures"></a> msdyn_geolocationtracking_BulkDeleteFailures

One-To-Many Relationship: [msdyn_geolocationtracking msdyn_geolocationtracking_BulkDeleteFailures](msdyn_geolocationtracking.md#BKMK_msdyn_geolocationtracking_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_geolocationtracking`|
|ReferencedAttribute|`msdyn_geolocationtrackingid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_geolocationtracking`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_incidenttype_BulkDeleteFailures"></a> msdyn_incidenttype_BulkDeleteFailures

One-To-Many Relationship: [msdyn_incidenttype msdyn_incidenttype_BulkDeleteFailures](msdyn_incidenttype.md#BKMK_msdyn_incidenttype_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_incidenttype`|
|ReferencedAttribute|`msdyn_incidenttypeid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_incidenttype`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_incidenttype_requirementgroup_BulkDeleteFailures"></a> msdyn_incidenttype_requirementgroup_BulkDeleteFailures

One-To-Many Relationship: [msdyn_incidenttype_requirementgroup msdyn_incidenttype_requirementgroup_BulkDeleteFailures](msdyn_incidenttype_requirementgroup.md#BKMK_msdyn_incidenttype_requirementgroup_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_incidenttype_requirementgroup`|
|ReferencedAttribute|`msdyn_incidenttype_requirementgroupid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_incidenttype_requirementgroup`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_incidenttypecharacteristic_BulkDeleteFailures"></a> msdyn_incidenttypecharacteristic_BulkDeleteFailures

One-To-Many Relationship: [msdyn_incidenttypecharacteristic msdyn_incidenttypecharacteristic_BulkDeleteFailures](msdyn_incidenttypecharacteristic.md#BKMK_msdyn_incidenttypecharacteristic_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_incidenttypecharacteristic`|
|ReferencedAttribute|`msdyn_incidenttypecharacteristicid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_incidenttypecharacteristic`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_incidenttypeproduct_BulkDeleteFailures"></a> msdyn_incidenttypeproduct_BulkDeleteFailures

One-To-Many Relationship: [msdyn_incidenttypeproduct msdyn_incidenttypeproduct_BulkDeleteFailures](msdyn_incidenttypeproduct.md#BKMK_msdyn_incidenttypeproduct_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_incidenttypeproduct`|
|ReferencedAttribute|`msdyn_incidenttypeproductid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_incidenttypeproduct`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_incidenttyperecommendationresult_BulkDeleteFailures"></a> msdyn_incidenttyperecommendationresult_BulkDeleteFailures

One-To-Many Relationship: [msdyn_incidenttyperecommendationresult msdyn_incidenttyperecommendationresult_BulkDeleteFailures](msdyn_incidenttyperecommendationresult.md#BKMK_msdyn_incidenttyperecommendationresult_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_incidenttyperecommendationresult`|
|ReferencedAttribute|`msdyn_incidenttyperecommendationresultid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_incidenttyperecommendationresult`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_incidenttyperecommendationrunhistory_BulkDeleteFailures"></a> msdyn_incidenttyperecommendationrunhistory_BulkDeleteFailures

One-To-Many Relationship: [msdyn_incidenttyperecommendationrunhistory msdyn_incidenttyperecommendationrunhistory_BulkDeleteFailures](msdyn_incidenttyperecommendationrunhistory.md#BKMK_msdyn_incidenttyperecommendationrunhistory_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_incidenttyperecommendationrunhistory`|
|ReferencedAttribute|`msdyn_incidenttyperecommendationrunhistoryid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_incidenttyperecommendationrunhistory`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_incidenttyperesolution_BulkDeleteFailures"></a> msdyn_incidenttyperesolution_BulkDeleteFailures

One-To-Many Relationship: [msdyn_incidenttyperesolution msdyn_incidenttyperesolution_BulkDeleteFailures](msdyn_incidenttyperesolution.md#BKMK_msdyn_incidenttyperesolution_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_incidenttyperesolution`|
|ReferencedAttribute|`msdyn_incidenttyperesolutionid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_incidenttyperesolution`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_incidenttypeservice_BulkDeleteFailures"></a> msdyn_incidenttypeservice_BulkDeleteFailures

One-To-Many Relationship: [msdyn_incidenttypeservice msdyn_incidenttypeservice_BulkDeleteFailures](msdyn_incidenttypeservice.md#BKMK_msdyn_incidenttypeservice_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_incidenttypeservice`|
|ReferencedAttribute|`msdyn_incidenttypeserviceid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_incidenttypeservice`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_incidenttypeservicetask_BulkDeleteFailures"></a> msdyn_incidenttypeservicetask_BulkDeleteFailures

One-To-Many Relationship: [msdyn_incidenttypeservicetask msdyn_incidenttypeservicetask_BulkDeleteFailures](msdyn_incidenttypeservicetask.md#BKMK_msdyn_incidenttypeservicetask_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_incidenttypeservicetask`|
|ReferencedAttribute|`msdyn_incidenttypeservicetaskid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_incidenttypeservicetask`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_incidenttypessetup_BulkDeleteFailures"></a> msdyn_incidenttypessetup_BulkDeleteFailures

One-To-Many Relationship: [msdyn_incidenttypessetup msdyn_incidenttypessetup_BulkDeleteFailures](msdyn_incidenttypessetup.md#BKMK_msdyn_incidenttypessetup_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_incidenttypessetup`|
|ReferencedAttribute|`msdyn_incidenttypessetupid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_incidenttypessetup`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_inspection_BulkDeleteFailures"></a> msdyn_inspection_BulkDeleteFailures

One-To-Many Relationship: [msdyn_inspection msdyn_inspection_BulkDeleteFailures](msdyn_inspection.md#BKMK_msdyn_inspection_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_inspection`|
|ReferencedAttribute|`msdyn_inspectionid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_inspection`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_inspectionattachment_BulkDeleteFailures"></a> msdyn_inspectionattachment_BulkDeleteFailures

One-To-Many Relationship: [msdyn_inspectionattachment msdyn_inspectionattachment_BulkDeleteFailures](msdyn_inspectionattachment.md#BKMK_msdyn_inspectionattachment_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_inspectionattachment`|
|ReferencedAttribute|`msdyn_inspectionattachmentid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_inspectionattachment`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_inspectiondefinition_BulkDeleteFailures"></a> msdyn_inspectiondefinition_BulkDeleteFailures

One-To-Many Relationship: [msdyn_inspectiondefinition msdyn_inspectiondefinition_BulkDeleteFailures](msdyn_inspectiondefinition.md#BKMK_msdyn_inspectiondefinition_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_inspectiondefinition`|
|ReferencedAttribute|`msdyn_inspectiondefinitionid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_inspectiondefinition`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_inspectioninstance_BulkDeleteFailures"></a> msdyn_inspectioninstance_BulkDeleteFailures

One-To-Many Relationship: [msdyn_inspectioninstance msdyn_inspectioninstance_BulkDeleteFailures](msdyn_inspectioninstance.md#BKMK_msdyn_inspectioninstance_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_inspectioninstance`|
|ReferencedAttribute|`msdyn_inspectioninstanceid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_inspectioninstance`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_inspectionresponse_BulkDeleteFailures"></a> msdyn_inspectionresponse_BulkDeleteFailures

One-To-Many Relationship: [msdyn_inspectionresponse msdyn_inspectionresponse_BulkDeleteFailures](msdyn_inspectionresponse.md#BKMK_msdyn_inspectionresponse_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_inspectionresponse`|
|ReferencedAttribute|`msdyn_inspectionresponseid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_inspectionresponse`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_insurance_BulkDeleteFailures"></a> msdyn_insurance_BulkDeleteFailures

One-To-Many Relationship: [msdyn_insurance msdyn_insurance_BulkDeleteFailures](msdyn_insurance.md#BKMK_msdyn_insurance_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_insurance`|
|ReferencedAttribute|`msdyn_insuranceid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_insurance`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_inventoryadjustment_BulkDeleteFailures"></a> msdyn_inventoryadjustment_BulkDeleteFailures

One-To-Many Relationship: [msdyn_inventoryadjustment msdyn_inventoryadjustment_BulkDeleteFailures](msdyn_inventoryadjustment.md#BKMK_msdyn_inventoryadjustment_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_inventoryadjustment`|
|ReferencedAttribute|`msdyn_inventoryadjustmentid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_inventoryadjustment`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_inventoryadjustmentproduct_BulkDeleteFailures"></a> msdyn_inventoryadjustmentproduct_BulkDeleteFailures

One-To-Many Relationship: [msdyn_inventoryadjustmentproduct msdyn_inventoryadjustmentproduct_BulkDeleteFailures](msdyn_inventoryadjustmentproduct.md#BKMK_msdyn_inventoryadjustmentproduct_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_inventoryadjustmentproduct`|
|ReferencedAttribute|`msdyn_inventoryadjustmentproductid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_inventoryadjustmentproduct`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_inventoryjournal_BulkDeleteFailures"></a> msdyn_inventoryjournal_BulkDeleteFailures

One-To-Many Relationship: [msdyn_inventoryjournal msdyn_inventoryjournal_BulkDeleteFailures](msdyn_inventoryjournal.md#BKMK_msdyn_inventoryjournal_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_inventoryjournal`|
|ReferencedAttribute|`msdyn_inventoryjournalid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_inventoryjournal`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_inventorytransfer_BulkDeleteFailures"></a> msdyn_inventorytransfer_BulkDeleteFailures

One-To-Many Relationship: [msdyn_inventorytransfer msdyn_inventorytransfer_BulkDeleteFailures](msdyn_inventorytransfer.md#BKMK_msdyn_inventorytransfer_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_inventorytransfer`|
|ReferencedAttribute|`msdyn_inventorytransferid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_inventorytransfer`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_mobilesource_BulkDeleteFailures"></a> msdyn_mobilesource_BulkDeleteFailures

One-To-Many Relationship: [msdyn_mobilesource msdyn_mobilesource_BulkDeleteFailures](msdyn_mobilesource.md#BKMK_msdyn_mobilesource_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_mobilesource`|
|ReferencedAttribute|`msdyn_mobilesourceid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_mobilesource`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_nottoexceed_BulkDeleteFailures"></a> msdyn_nottoexceed_BulkDeleteFailures

One-To-Many Relationship: [msdyn_nottoexceed msdyn_nottoexceed_BulkDeleteFailures](msdyn_nottoexceed.md#BKMK_msdyn_nottoexceed_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_nottoexceed`|
|ReferencedAttribute|`msdyn_nottoexceedid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_nottoexceed`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_orderinvoicingdate_BulkDeleteFailures"></a> msdyn_orderinvoicingdate_BulkDeleteFailures

One-To-Many Relationship: [msdyn_orderinvoicingdate msdyn_orderinvoicingdate_BulkDeleteFailures](msdyn_orderinvoicingdate.md#BKMK_msdyn_orderinvoicingdate_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_orderinvoicingdate`|
|ReferencedAttribute|`msdyn_orderinvoicingdateid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_orderinvoicingdate`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_orderinvoicingproduct_BulkDeleteFailures"></a> msdyn_orderinvoicingproduct_BulkDeleteFailures

One-To-Many Relationship: [msdyn_orderinvoicingproduct msdyn_orderinvoicingproduct_BulkDeleteFailures](msdyn_orderinvoicingproduct.md#BKMK_msdyn_orderinvoicingproduct_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_orderinvoicingproduct`|
|ReferencedAttribute|`msdyn_orderinvoicingproductid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_orderinvoicingproduct`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_orderinvoicingsetup_BulkDeleteFailures"></a> msdyn_orderinvoicingsetup_BulkDeleteFailures

One-To-Many Relationship: [msdyn_orderinvoicingsetup msdyn_orderinvoicingsetup_BulkDeleteFailures](msdyn_orderinvoicingsetup.md#BKMK_msdyn_orderinvoicingsetup_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_orderinvoicingsetup`|
|ReferencedAttribute|`msdyn_orderinvoicingsetupid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_orderinvoicingsetup`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_orderinvoicingsetupdate_BulkDeleteFailures"></a> msdyn_orderinvoicingsetupdate_BulkDeleteFailures

One-To-Many Relationship: [msdyn_orderinvoicingsetupdate msdyn_orderinvoicingsetupdate_BulkDeleteFailures](msdyn_orderinvoicingsetupdate.md#BKMK_msdyn_orderinvoicingsetupdate_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_orderinvoicingsetupdate`|
|ReferencedAttribute|`msdyn_orderinvoicingsetupdateid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_orderinvoicingsetupdate`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_organizationalunit_BulkDeleteFailures"></a> msdyn_organizationalunit_BulkDeleteFailures

One-To-Many Relationship: [msdyn_organizationalunit msdyn_organizationalunit_BulkDeleteFailures](msdyn_organizationalunit.md#BKMK_msdyn_organizationalunit_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_organizationalunit`|
|ReferencedAttribute|`msdyn_organizationalunitid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_organizationalunit`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_payment_BulkDeleteFailures"></a> msdyn_payment_BulkDeleteFailures

One-To-Many Relationship: [msdyn_payment msdyn_payment_BulkDeleteFailures](msdyn_payment.md#BKMK_msdyn_payment_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_payment`|
|ReferencedAttribute|`msdyn_paymentid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_payment`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_paymentdetail_BulkDeleteFailures"></a> msdyn_paymentdetail_BulkDeleteFailures

One-To-Many Relationship: [msdyn_paymentdetail msdyn_paymentdetail_BulkDeleteFailures](msdyn_paymentdetail.md#BKMK_msdyn_paymentdetail_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_paymentdetail`|
|ReferencedAttribute|`msdyn_paymentdetailid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_paymentdetail`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_paymentmethod_BulkDeleteFailures"></a> msdyn_paymentmethod_BulkDeleteFailures

One-To-Many Relationship: [msdyn_paymentmethod msdyn_paymentmethod_BulkDeleteFailures](msdyn_paymentmethod.md#BKMK_msdyn_paymentmethod_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_paymentmethod`|
|ReferencedAttribute|`msdyn_paymentmethodid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_paymentmethod`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_paymentterm_BulkDeleteFailures"></a> msdyn_paymentterm_BulkDeleteFailures

One-To-Many Relationship: [msdyn_paymentterm msdyn_paymentterm_BulkDeleteFailures](msdyn_paymentterm.md#BKMK_msdyn_paymentterm_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_paymentterm`|
|ReferencedAttribute|`msdyn_paymenttermid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_paymentterm`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_postalcode_BulkDeleteFailures"></a> msdyn_postalcode_BulkDeleteFailures

One-To-Many Relationship: [msdyn_postalcode msdyn_postalcode_BulkDeleteFailures](msdyn_postalcode.md#BKMK_msdyn_postalcode_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_postalcode`|
|ReferencedAttribute|`msdyn_postalcodeid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_postalcode`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_predictworkhourdurationsetting_BulkDeleteFailures"></a> msdyn_predictworkhourdurationsetting_BulkDeleteFailures

One-To-Many Relationship: [msdyn_predictworkhourdurationsetting msdyn_predictworkhourdurationsetting_BulkDeleteFailures](msdyn_predictworkhourdurationsetting.md#BKMK_msdyn_predictworkhourdurationsetting_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_predictworkhourdurationsetting`|
|ReferencedAttribute|`msdyn_predictworkhourdurationsettingid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_predictworkhourdurationsetting`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_priority_BulkDeleteFailures"></a> msdyn_priority_BulkDeleteFailures

One-To-Many Relationship: [msdyn_priority msdyn_priority_BulkDeleteFailures](msdyn_priority.md#BKMK_msdyn_priority_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_priority`|
|ReferencedAttribute|`msdyn_priorityid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_priority`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_problematicasset_BulkDeleteFailures"></a> msdyn_problematicasset_BulkDeleteFailures

One-To-Many Relationship: [msdyn_problematicasset msdyn_problematicasset_BulkDeleteFailures](msdyn_problematicasset.md#BKMK_msdyn_problematicasset_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_problematicasset`|
|ReferencedAttribute|`msdyn_problematicassetid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_problematicasset`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_problematicassetfeedback_BulkDeleteFailures"></a> msdyn_problematicassetfeedback_BulkDeleteFailures

One-To-Many Relationship: [msdyn_problematicassetfeedback msdyn_problematicassetfeedback_BulkDeleteFailures](msdyn_problematicassetfeedback.md#BKMK_msdyn_problematicassetfeedback_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_problematicassetfeedback`|
|ReferencedAttribute|`msdyn_problematicassetfeedbackid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_problematicassetfeedback`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_productinventory_BulkDeleteFailures"></a> msdyn_productinventory_BulkDeleteFailures

One-To-Many Relationship: [msdyn_productinventory msdyn_productinventory_BulkDeleteFailures](msdyn_productinventory.md#BKMK_msdyn_productinventory_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_productinventory`|
|ReferencedAttribute|`msdyn_productinventoryid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_productinventory`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_purchaseorder_BulkDeleteFailures"></a> msdyn_purchaseorder_BulkDeleteFailures

One-To-Many Relationship: [msdyn_purchaseorder msdyn_purchaseorder_BulkDeleteFailures](msdyn_purchaseorder.md#BKMK_msdyn_purchaseorder_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_purchaseorder`|
|ReferencedAttribute|`msdyn_purchaseorderid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_purchaseorder`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_purchaseorderbill_BulkDeleteFailures"></a> msdyn_purchaseorderbill_BulkDeleteFailures

One-To-Many Relationship: [msdyn_purchaseorderbill msdyn_purchaseorderbill_BulkDeleteFailures](msdyn_purchaseorderbill.md#BKMK_msdyn_purchaseorderbill_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_purchaseorderbill`|
|ReferencedAttribute|`msdyn_purchaseorderbillid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_purchaseorderbill`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_purchaseorderproduct_BulkDeleteFailures"></a> msdyn_purchaseorderproduct_BulkDeleteFailures

One-To-Many Relationship: [msdyn_purchaseorderproduct msdyn_purchaseorderproduct_BulkDeleteFailures](msdyn_purchaseorderproduct.md#BKMK_msdyn_purchaseorderproduct_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_purchaseorderproduct`|
|ReferencedAttribute|`msdyn_purchaseorderproductid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_purchaseorderproduct`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_purchaseorderreceipt_BulkDeleteFailures"></a> msdyn_purchaseorderreceipt_BulkDeleteFailures

One-To-Many Relationship: [msdyn_purchaseorderreceipt msdyn_purchaseorderreceipt_BulkDeleteFailures](msdyn_purchaseorderreceipt.md#BKMK_msdyn_purchaseorderreceipt_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_purchaseorderreceipt`|
|ReferencedAttribute|`msdyn_purchaseorderreceiptid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_purchaseorderreceipt`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_purchaseorderreceiptproduct_BulkDeleteFailures"></a> msdyn_purchaseorderreceiptproduct_BulkDeleteFailures

One-To-Many Relationship: [msdyn_purchaseorderreceiptproduct msdyn_purchaseorderreceiptproduct_BulkDeleteFailures](msdyn_purchaseorderreceiptproduct.md#BKMK_msdyn_purchaseorderreceiptproduct_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_purchaseorderreceiptproduct`|
|ReferencedAttribute|`msdyn_purchaseorderreceiptproductid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_purchaseorderreceiptproduct`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_purchaseordersubstatus_BulkDeleteFailures"></a> msdyn_purchaseordersubstatus_BulkDeleteFailures

One-To-Many Relationship: [msdyn_purchaseordersubstatus msdyn_purchaseordersubstatus_BulkDeleteFailures](msdyn_purchaseordersubstatus.md#BKMK_msdyn_purchaseordersubstatus_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_purchaseordersubstatus`|
|ReferencedAttribute|`msdyn_purchaseordersubstatusid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_purchaseordersubstatus`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_quotebookingincident_BulkDeleteFailures"></a> msdyn_quotebookingincident_BulkDeleteFailures

One-To-Many Relationship: [msdyn_quotebookingincident msdyn_quotebookingincident_BulkDeleteFailures](msdyn_quotebookingincident.md#BKMK_msdyn_quotebookingincident_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_quotebookingincident`|
|ReferencedAttribute|`msdyn_quotebookingincidentid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_quotebookingincident`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_quotebookingproduct_BulkDeleteFailures"></a> msdyn_quotebookingproduct_BulkDeleteFailures

One-To-Many Relationship: [msdyn_quotebookingproduct msdyn_quotebookingproduct_BulkDeleteFailures](msdyn_quotebookingproduct.md#BKMK_msdyn_quotebookingproduct_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_quotebookingproduct`|
|ReferencedAttribute|`msdyn_quotebookingproductid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_quotebookingproduct`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_quotebookingservice_BulkDeleteFailures"></a> msdyn_quotebookingservice_BulkDeleteFailures

One-To-Many Relationship: [msdyn_quotebookingservice msdyn_quotebookingservice_BulkDeleteFailures](msdyn_quotebookingservice.md#BKMK_msdyn_quotebookingservice_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_quotebookingservice`|
|ReferencedAttribute|`msdyn_quotebookingserviceid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_quotebookingservice`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_quotebookingservicetask_BulkDeleteFailures"></a> msdyn_quotebookingservicetask_BulkDeleteFailures

One-To-Many Relationship: [msdyn_quotebookingservicetask msdyn_quotebookingservicetask_BulkDeleteFailures](msdyn_quotebookingservicetask.md#BKMK_msdyn_quotebookingservicetask_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_quotebookingservicetask`|
|ReferencedAttribute|`msdyn_quotebookingservicetaskid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_quotebookingservicetask`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_quotebookingsetup_BulkDeleteFailures"></a> msdyn_quotebookingsetup_BulkDeleteFailures

One-To-Many Relationship: [msdyn_quotebookingsetup msdyn_quotebookingsetup_BulkDeleteFailures](msdyn_quotebookingsetup.md#BKMK_msdyn_quotebookingsetup_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_quotebookingsetup`|
|ReferencedAttribute|`msdyn_quotebookingsetupid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_quotebookingsetup`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_quoteinvoicingproduct_BulkDeleteFailures"></a> msdyn_quoteinvoicingproduct_BulkDeleteFailures

One-To-Many Relationship: [msdyn_quoteinvoicingproduct msdyn_quoteinvoicingproduct_BulkDeleteFailures](msdyn_quoteinvoicingproduct.md#BKMK_msdyn_quoteinvoicingproduct_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_quoteinvoicingproduct`|
|ReferencedAttribute|`msdyn_quoteinvoicingproductid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_quoteinvoicingproduct`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_quoteinvoicingsetup_BulkDeleteFailures"></a> msdyn_quoteinvoicingsetup_BulkDeleteFailures

One-To-Many Relationship: [msdyn_quoteinvoicingsetup msdyn_quoteinvoicingsetup_BulkDeleteFailures](msdyn_quoteinvoicingsetup.md#BKMK_msdyn_quoteinvoicingsetup_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_quoteinvoicingsetup`|
|ReferencedAttribute|`msdyn_quoteinvoicingsetupid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_quoteinvoicingsetup`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_requirementchange_BulkDeleteFailures"></a> msdyn_requirementchange_BulkDeleteFailures

One-To-Many Relationship: [msdyn_requirementchange msdyn_requirementchange_BulkDeleteFailures](msdyn_requirementchange.md#BKMK_msdyn_requirementchange_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_requirementchange`|
|ReferencedAttribute|`msdyn_requirementchangeid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_requirementchange`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_requirementcharacteristic_BulkDeleteFailures"></a> msdyn_requirementcharacteristic_BulkDeleteFailures

One-To-Many Relationship: [msdyn_requirementcharacteristic msdyn_requirementcharacteristic_BulkDeleteFailures](msdyn_requirementcharacteristic.md#BKMK_msdyn_requirementcharacteristic_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_requirementcharacteristic`|
|ReferencedAttribute|`msdyn_requirementcharacteristicid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_requirementcharacteristic`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_requirementdependency_BulkDeleteFailures"></a> msdyn_requirementdependency_BulkDeleteFailures

One-To-Many Relationship: [msdyn_requirementdependency msdyn_requirementdependency_BulkDeleteFailures](msdyn_requirementdependency.md#BKMK_msdyn_requirementdependency_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_requirementdependency`|
|ReferencedAttribute|`msdyn_requirementdependencyid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_requirementdependency`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_requirementgroup_BulkDeleteFailures"></a> msdyn_requirementgroup_BulkDeleteFailures

One-To-Many Relationship: [msdyn_requirementgroup msdyn_requirementgroup_BulkDeleteFailures](msdyn_requirementgroup.md#BKMK_msdyn_requirementgroup_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_requirementgroup`|
|ReferencedAttribute|`msdyn_requirementgroupid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_requirementgroup`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_requirementorganizationunit_BulkDeleteFailures"></a> msdyn_requirementorganizationunit_BulkDeleteFailures

One-To-Many Relationship: [msdyn_requirementorganizationunit msdyn_requirementorganizationunit_BulkDeleteFailures](msdyn_requirementorganizationunit.md#BKMK_msdyn_requirementorganizationunit_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_requirementorganizationunit`|
|ReferencedAttribute|`msdyn_requirementorganizationunitid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_requirementorganizationunit`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_requirementrelationship_BulkDeleteFailures"></a> msdyn_requirementrelationship_BulkDeleteFailures

One-To-Many Relationship: [msdyn_requirementrelationship msdyn_requirementrelationship_BulkDeleteFailures](msdyn_requirementrelationship.md#BKMK_msdyn_requirementrelationship_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_requirementrelationship`|
|ReferencedAttribute|`msdyn_requirementrelationshipid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_requirementrelationship`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_requirementresourcecategory_BulkDeleteFailures"></a> msdyn_requirementresourcecategory_BulkDeleteFailures

One-To-Many Relationship: [msdyn_requirementresourcecategory msdyn_requirementresourcecategory_BulkDeleteFailures](msdyn_requirementresourcecategory.md#BKMK_msdyn_requirementresourcecategory_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_requirementresourcecategory`|
|ReferencedAttribute|`msdyn_requirementresourcecategoryid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_requirementresourcecategory`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_requirementresourcepreference_BulkDeleteFailures"></a> msdyn_requirementresourcepreference_BulkDeleteFailures

One-To-Many Relationship: [msdyn_requirementresourcepreference msdyn_requirementresourcepreference_BulkDeleteFailures](msdyn_requirementresourcepreference.md#BKMK_msdyn_requirementresourcepreference_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_requirementresourcepreference`|
|ReferencedAttribute|`msdyn_requirementresourcepreferenceid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_requirementresourcepreference`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_requirementstatus_BulkDeleteFailures"></a> msdyn_requirementstatus_BulkDeleteFailures

One-To-Many Relationship: [msdyn_requirementstatus msdyn_requirementstatus_BulkDeleteFailures](msdyn_requirementstatus.md#BKMK_msdyn_requirementstatus_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_requirementstatus`|
|ReferencedAttribute|`msdyn_requirementstatusid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_requirementstatus`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_resolution_BulkDeleteFailures"></a> msdyn_resolution_BulkDeleteFailures

One-To-Many Relationship: [msdyn_resolution msdyn_resolution_BulkDeleteFailures](msdyn_resolution.md#BKMK_msdyn_resolution_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_resolution`|
|ReferencedAttribute|`msdyn_resolutionid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_resolution`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_resourcepaytype_BulkDeleteFailures"></a> msdyn_resourcepaytype_BulkDeleteFailures

One-To-Many Relationship: [msdyn_resourcepaytype msdyn_resourcepaytype_BulkDeleteFailures](msdyn_resourcepaytype.md#BKMK_msdyn_resourcepaytype_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_resourcepaytype`|
|ReferencedAttribute|`msdyn_resourcepaytypeid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_resourcepaytype`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_resourcerequirement_BulkDeleteFailures"></a> msdyn_resourcerequirement_BulkDeleteFailures

One-To-Many Relationship: [msdyn_resourcerequirement msdyn_resourcerequirement_BulkDeleteFailures](msdyn_resourcerequirement.md#BKMK_msdyn_resourcerequirement_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_resourcerequirement`|
|ReferencedAttribute|`msdyn_resourcerequirementid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_resourcerequirement`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_resourcerequirementdetail_BulkDeleteFailures"></a> msdyn_resourcerequirementdetail_BulkDeleteFailures

One-To-Many Relationship: [msdyn_resourcerequirementdetail msdyn_resourcerequirementdetail_BulkDeleteFailures](msdyn_resourcerequirementdetail.md#BKMK_msdyn_resourcerequirementdetail_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_resourcerequirementdetail`|
|ReferencedAttribute|`msdyn_resourcerequirementdetailid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_resourcerequirementdetail`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_resourceterritory_BulkDeleteFailures"></a> msdyn_resourceterritory_BulkDeleteFailures

One-To-Many Relationship: [msdyn_resourceterritory msdyn_resourceterritory_BulkDeleteFailures](msdyn_resourceterritory.md#BKMK_msdyn_resourceterritory_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_resourceterritory`|
|ReferencedAttribute|`msdyn_resourceterritoryid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_resourceterritory`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_rma_BulkDeleteFailures"></a> msdyn_rma_BulkDeleteFailures

One-To-Many Relationship: [msdyn_rma msdyn_rma_BulkDeleteFailures](msdyn_rma.md#BKMK_msdyn_rma_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_rma`|
|ReferencedAttribute|`msdyn_rmaid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_rma`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_rmaproduct_BulkDeleteFailures"></a> msdyn_rmaproduct_BulkDeleteFailures

One-To-Many Relationship: [msdyn_rmaproduct msdyn_rmaproduct_BulkDeleteFailures](msdyn_rmaproduct.md#BKMK_msdyn_rmaproduct_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_rmaproduct`|
|ReferencedAttribute|`msdyn_rmaproductid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_rmaproduct`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_rmareceipt_BulkDeleteFailures"></a> msdyn_rmareceipt_BulkDeleteFailures

One-To-Many Relationship: [msdyn_rmareceipt msdyn_rmareceipt_BulkDeleteFailures](msdyn_rmareceipt.md#BKMK_msdyn_rmareceipt_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_rmareceipt`|
|ReferencedAttribute|`msdyn_rmareceiptid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_rmareceipt`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_rmareceiptproduct_BulkDeleteFailures"></a> msdyn_rmareceiptproduct_BulkDeleteFailures

One-To-Many Relationship: [msdyn_rmareceiptproduct msdyn_rmareceiptproduct_BulkDeleteFailures](msdyn_rmareceiptproduct.md#BKMK_msdyn_rmareceiptproduct_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_rmareceiptproduct`|
|ReferencedAttribute|`msdyn_rmareceiptproductid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_rmareceiptproduct`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_rmasubstatus_BulkDeleteFailures"></a> msdyn_rmasubstatus_BulkDeleteFailures

One-To-Many Relationship: [msdyn_rmasubstatus msdyn_rmasubstatus_BulkDeleteFailures](msdyn_rmasubstatus.md#BKMK_msdyn_rmasubstatus_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_rmasubstatus`|
|ReferencedAttribute|`msdyn_rmasubstatusid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_rmasubstatus`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_rtv_BulkDeleteFailures"></a> msdyn_rtv_BulkDeleteFailures

One-To-Many Relationship: [msdyn_rtv msdyn_rtv_BulkDeleteFailures](msdyn_rtv.md#BKMK_msdyn_rtv_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_rtv`|
|ReferencedAttribute|`msdyn_rtvid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_rtv`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_rtvproduct_BulkDeleteFailures"></a> msdyn_rtvproduct_BulkDeleteFailures

One-To-Many Relationship: [msdyn_rtvproduct msdyn_rtvproduct_BulkDeleteFailures](msdyn_rtvproduct.md#BKMK_msdyn_rtvproduct_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_rtvproduct`|
|ReferencedAttribute|`msdyn_rtvproductid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_rtvproduct`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_rtvsubstatus_BulkDeleteFailures"></a> msdyn_rtvsubstatus_BulkDeleteFailures

One-To-Many Relationship: [msdyn_rtvsubstatus msdyn_rtvsubstatus_BulkDeleteFailures](msdyn_rtvsubstatus.md#BKMK_msdyn_rtvsubstatus_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_rtvsubstatus`|
|ReferencedAttribute|`msdyn_rtvsubstatusid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_rtvsubstatus`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_scheduleboardsetting_BulkDeleteFailures"></a> msdyn_scheduleboardsetting_BulkDeleteFailures

One-To-Many Relationship: [msdyn_scheduleboardsetting msdyn_scheduleboardsetting_BulkDeleteFailures](msdyn_scheduleboardsetting.md#BKMK_msdyn_scheduleboardsetting_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_scheduleboardsetting`|
|ReferencedAttribute|`msdyn_scheduleboardsettingid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_scheduleboardsetting`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_schedulingfeatureflag_BulkDeleteFailures"></a> msdyn_schedulingfeatureflag_BulkDeleteFailures

One-To-Many Relationship: [msdyn_schedulingfeatureflag msdyn_schedulingfeatureflag_BulkDeleteFailures](msdyn_schedulingfeatureflag.md#BKMK_msdyn_schedulingfeatureflag_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_schedulingfeatureflag`|
|ReferencedAttribute|`msdyn_schedulingfeatureflagid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_schedulingfeatureflag`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_schedulingparameter_BulkDeleteFailures"></a> msdyn_schedulingparameter_BulkDeleteFailures

One-To-Many Relationship: [msdyn_schedulingparameter msdyn_schedulingparameter_BulkDeleteFailures](msdyn_schedulingparameter.md#BKMK_msdyn_schedulingparameter_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_schedulingparameter`|
|ReferencedAttribute|`msdyn_schedulingparameterid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_schedulingparameter`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_servicetasktype_BulkDeleteFailures"></a> msdyn_servicetasktype_BulkDeleteFailures

One-To-Many Relationship: [msdyn_servicetasktype msdyn_servicetasktype_BulkDeleteFailures](msdyn_servicetasktype.md#BKMK_msdyn_servicetasktype_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_servicetasktype`|
|ReferencedAttribute|`msdyn_servicetasktypeid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_servicetasktype`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_sessiondata_BulkDeleteFailures"></a> msdyn_sessiondata_BulkDeleteFailures

One-To-Many Relationship: [msdyn_sessiondata msdyn_sessiondata_BulkDeleteFailures](msdyn_sessiondata.md#BKMK_msdyn_sessiondata_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_sessiondata`|
|ReferencedAttribute|`msdyn_sessiondataid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_sessiondata`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_sessionparticipantdata_BulkDeleteFailures"></a> msdyn_sessionparticipantdata_BulkDeleteFailures

One-To-Many Relationship: [msdyn_sessionparticipantdata msdyn_sessionparticipantdata_BulkDeleteFailures](msdyn_sessionparticipantdata.md#BKMK_msdyn_sessionparticipantdata_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_sessionparticipantdata`|
|ReferencedAttribute|`msdyn_sessionparticipantdataid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_sessionparticipantdata`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_shipvia_BulkDeleteFailures"></a> msdyn_shipvia_BulkDeleteFailures

One-To-Many Relationship: [msdyn_shipvia msdyn_shipvia_BulkDeleteFailures](msdyn_shipvia.md#BKMK_msdyn_shipvia_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_shipvia`|
|ReferencedAttribute|`msdyn_shipviaid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_shipvia`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_systemuserschedulersetting_BulkDeleteFailures"></a> msdyn_systemuserschedulersetting_BulkDeleteFailures

One-To-Many Relationship: [msdyn_systemuserschedulersetting msdyn_systemuserschedulersetting_BulkDeleteFailures](msdyn_systemuserschedulersetting.md#BKMK_msdyn_systemuserschedulersetting_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_systemuserschedulersetting`|
|ReferencedAttribute|`msdyn_systemuserschedulersettingid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_systemuserschedulersetting`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_taxcode_BulkDeleteFailures"></a> msdyn_taxcode_BulkDeleteFailures

One-To-Many Relationship: [msdyn_taxcode msdyn_taxcode_BulkDeleteFailures](msdyn_taxcode.md#BKMK_msdyn_taxcode_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_taxcode`|
|ReferencedAttribute|`msdyn_taxcodeid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_taxcode`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_taxcodedetail_BulkDeleteFailures"></a> msdyn_taxcodedetail_BulkDeleteFailures

One-To-Many Relationship: [msdyn_taxcodedetail msdyn_taxcodedetail_BulkDeleteFailures](msdyn_taxcodedetail.md#BKMK_msdyn_taxcodedetail_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_taxcodedetail`|
|ReferencedAttribute|`msdyn_taxcodedetailid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_taxcodedetail`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_timeentry_BulkDeleteFailures"></a> msdyn_timeentry_BulkDeleteFailures

One-To-Many Relationship: [msdyn_timeentry msdyn_timeentry_BulkDeleteFailures](msdyn_timeentry.md#BKMK_msdyn_timeentry_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_timeentry`|
|ReferencedAttribute|`msdyn_timeentryid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_timeentry`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_timeentrysetting_BulkDeleteFailures"></a> msdyn_timeentrysetting_BulkDeleteFailures

One-To-Many Relationship: [msdyn_timeentrysetting msdyn_timeentrysetting_BulkDeleteFailures](msdyn_timeentrysetting.md#BKMK_msdyn_timeentrysetting_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_timeentrysetting`|
|ReferencedAttribute|`msdyn_timeentrysettingid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_timeentrysetting`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_timegroup_BulkDeleteFailures"></a> msdyn_timegroup_BulkDeleteFailures

One-To-Many Relationship: [msdyn_timegroup msdyn_timegroup_BulkDeleteFailures](msdyn_timegroup.md#BKMK_msdyn_timegroup_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_timegroup`|
|ReferencedAttribute|`msdyn_timegroupid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_timegroup`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_timegroupdetail_BulkDeleteFailures"></a> msdyn_timegroupdetail_BulkDeleteFailures

One-To-Many Relationship: [msdyn_timegroupdetail msdyn_timegroupdetail_BulkDeleteFailures](msdyn_timegroupdetail.md#BKMK_msdyn_timegroupdetail_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_timegroupdetail`|
|ReferencedAttribute|`msdyn_timegroupdetailid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_timegroupdetail`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_timeoffrequest_BulkDeleteFailures"></a> msdyn_timeoffrequest_BulkDeleteFailures

One-To-Many Relationship: [msdyn_timeoffrequest msdyn_timeoffrequest_BulkDeleteFailures](msdyn_timeoffrequest.md#BKMK_msdyn_timeoffrequest_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_timeoffrequest`|
|ReferencedAttribute|`msdyn_timeoffrequestid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_timeoffrequest`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_trade_BulkDeleteFailures"></a> msdyn_trade_BulkDeleteFailures

One-To-Many Relationship: [msdyn_trade msdyn_trade_BulkDeleteFailures](msdyn_trade.md#BKMK_msdyn_trade_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_trade`|
|ReferencedAttribute|`msdyn_tradeid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_trade`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_tradecoverage_BulkDeleteFailures"></a> msdyn_tradecoverage_BulkDeleteFailures

One-To-Many Relationship: [msdyn_tradecoverage msdyn_tradecoverage_BulkDeleteFailures](msdyn_tradecoverage.md#BKMK_msdyn_tradecoverage_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_tradecoverage`|
|ReferencedAttribute|`msdyn_tradecoverageid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_tradecoverage`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_transactionorigin_BulkDeleteFailures"></a> msdyn_transactionorigin_BulkDeleteFailures

One-To-Many Relationship: [msdyn_transactionorigin msdyn_transactionorigin_BulkDeleteFailures](msdyn_transactionorigin.md#BKMK_msdyn_transactionorigin_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_transactionorigin`|
|ReferencedAttribute|`msdyn_transactionoriginid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_transactionorigin`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_uniquenumber_BulkDeleteFailures"></a> msdyn_uniquenumber_BulkDeleteFailures

One-To-Many Relationship: [msdyn_uniquenumber msdyn_uniquenumber_BulkDeleteFailures](msdyn_uniquenumber.md#BKMK_msdyn_uniquenumber_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_uniquenumber`|
|ReferencedAttribute|`msdyn_uniquenumberid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_uniquenumber`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_warehouse_BulkDeleteFailures"></a> msdyn_warehouse_BulkDeleteFailures

One-To-Many Relationship: [msdyn_warehouse msdyn_warehouse_BulkDeleteFailures](msdyn_warehouse.md#BKMK_msdyn_warehouse_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_warehouse`|
|ReferencedAttribute|`msdyn_warehouseid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_warehouse`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_workhourtemplate_BulkDeleteFailures"></a> msdyn_workhourtemplate_BulkDeleteFailures

One-To-Many Relationship: [msdyn_workhourtemplate msdyn_workhourtemplate_BulkDeleteFailures](msdyn_workhourtemplate.md#BKMK_msdyn_workhourtemplate_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_workhourtemplate`|
|ReferencedAttribute|`msdyn_workhourtemplateid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_workhourtemplate`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_workorder_BulkDeleteFailures"></a> msdyn_workorder_BulkDeleteFailures

One-To-Many Relationship: [msdyn_workorder msdyn_workorder_BulkDeleteFailures](msdyn_workorder.md#BKMK_msdyn_workorder_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_workorder`|
|ReferencedAttribute|`msdyn_workorderid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_workorder`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_workorderincident_BulkDeleteFailures"></a> msdyn_workorderincident_BulkDeleteFailures

One-To-Many Relationship: [msdyn_workorderincident msdyn_workorderincident_BulkDeleteFailures](msdyn_workorderincident.md#BKMK_msdyn_workorderincident_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_workorderincident`|
|ReferencedAttribute|`msdyn_workorderincidentid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_workorderincident`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_workordernte_BulkDeleteFailures"></a> msdyn_workordernte_BulkDeleteFailures

One-To-Many Relationship: [msdyn_workordernte msdyn_workordernte_BulkDeleteFailures](msdyn_workordernte.md#BKMK_msdyn_workordernte_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_workordernte`|
|ReferencedAttribute|`msdyn_workordernteid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_workordernte`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_workorderproduct_BulkDeleteFailures"></a> msdyn_workorderproduct_BulkDeleteFailures

One-To-Many Relationship: [msdyn_workorderproduct msdyn_workorderproduct_BulkDeleteFailures](msdyn_workorderproduct.md#BKMK_msdyn_workorderproduct_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_workorderproduct`|
|ReferencedAttribute|`msdyn_workorderproductid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_workorderproduct`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_workorderresolution_BulkDeleteFailures"></a> msdyn_workorderresolution_BulkDeleteFailures

One-To-Many Relationship: [msdyn_workorderresolution msdyn_workorderresolution_BulkDeleteFailures](msdyn_workorderresolution.md#BKMK_msdyn_workorderresolution_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_workorderresolution`|
|ReferencedAttribute|`msdyn_workorderresolutionid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_workorderresolution`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_workorderresourcerestriction_BulkDeleteFailures"></a> msdyn_workorderresourcerestriction_BulkDeleteFailures

One-To-Many Relationship: [msdyn_workorderresourcerestriction msdyn_workorderresourcerestriction_BulkDeleteFailures](msdyn_workorderresourcerestriction.md#BKMK_msdyn_workorderresourcerestriction_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_workorderresourcerestriction`|
|ReferencedAttribute|`msdyn_workorderresourcerestrictionid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_workorderresourcerestriction`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_workorderservice_BulkDeleteFailures"></a> msdyn_workorderservice_BulkDeleteFailures

One-To-Many Relationship: [msdyn_workorderservice msdyn_workorderservice_BulkDeleteFailures](msdyn_workorderservice.md#BKMK_msdyn_workorderservice_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_workorderservice`|
|ReferencedAttribute|`msdyn_workorderserviceid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_workorderservice`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_workorderservicetask_BulkDeleteFailures"></a> msdyn_workorderservicetask_BulkDeleteFailures

One-To-Many Relationship: [msdyn_workorderservicetask msdyn_workorderservicetask_BulkDeleteFailures](msdyn_workorderservicetask.md#BKMK_msdyn_workorderservicetask_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_workorderservicetask`|
|ReferencedAttribute|`msdyn_workorderservicetaskid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_workorderservicetask`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_workordersubstatus_BulkDeleteFailures"></a> msdyn_workordersubstatus_BulkDeleteFailures

One-To-Many Relationship: [msdyn_workordersubstatus msdyn_workordersubstatus_BulkDeleteFailures](msdyn_workordersubstatus.md#BKMK_msdyn_workordersubstatus_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_workordersubstatus`|
|ReferencedAttribute|`msdyn_workordersubstatusid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_workordersubstatus`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_workordertype_BulkDeleteFailures"></a> msdyn_workordertype_BulkDeleteFailures

One-To-Many Relationship: [msdyn_workordertype msdyn_workordertype_BulkDeleteFailures](msdyn_workordertype.md#BKMK_msdyn_workordertype_BulkDeleteFailures)

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
<xref:Microsoft.Dynamics.CRM.bulkdeletefailure?displayProperty=fullName>
