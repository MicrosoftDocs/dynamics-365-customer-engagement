---
title: "System Job (AsyncOperation) table/entity reference (Microsoft Dynamics 365 Field Service)"
description: "Includes schema information and supported messages for the System Job (AsyncOperation) table/entity with Microsoft Dynamics 365 Field Service."
ms.date: 08/26/2024
ms.service: powerapps
ms.topic: reference
author: m-hartmann
ms.author: mhart
search.audienceType: 
  - developer
---

# System Job (AsyncOperation) table/entity reference

Process whose execution can proceed independently or in the background.

> [!NOTE]
> The Microsoft Dynamics 365 Field Service System Job (AsyncOperation) table extends the [Microsoft Dynamics 365 System Job (AsyncOperation) table](/dynamics365/developer/entities/asyncoperation).



## Customized columns/attributes

Microsoft Dynamics 365 Field Service modifies the definition of columns/attributes defined in other solutions. Listed by **SchemaName**.

### <a name="BKMK_RegardingObjectId"></a> RegardingObjectId

Changes from [RegardingObjectId (Microsoft Dataverse)](/power-apps/developer/data-platform/reference/entities/asyncoperation#BKMK_RegardingObjectId)

|Property|Value|
|---|---|
|Targets|msdyn_3dmodel|


## Many-to-One relationships

These relationships are many-to-one. Listed by **SchemaName**.

- [msdyn_3dmodel_AsyncOperations](#BKMK_msdyn_3dmodel_AsyncOperations)
- [msdyn_actual_AsyncOperations](#BKMK_msdyn_actual_AsyncOperations)
- [msdyn_agreement_AsyncOperations](#BKMK_msdyn_agreement_AsyncOperations)
- [msdyn_agreementbookingdate_AsyncOperations](#BKMK_msdyn_agreementbookingdate_AsyncOperations)
- [msdyn_agreementbookingincident_AsyncOperations](#BKMK_msdyn_agreementbookingincident_AsyncOperations)
- [msdyn_agreementbookingproduct_AsyncOperations](#BKMK_msdyn_agreementbookingproduct_AsyncOperations)
- [msdyn_agreementbookingservice_AsyncOperations](#BKMK_msdyn_agreementbookingservice_AsyncOperations)
- [msdyn_agreementbookingservicetask_AsyncOperations](#BKMK_msdyn_agreementbookingservicetask_AsyncOperations)
- [msdyn_agreementbookingsetup_AsyncOperations](#BKMK_msdyn_agreementbookingsetup_AsyncOperations)
- [msdyn_agreementinvoicedate_AsyncOperations](#BKMK_msdyn_agreementinvoicedate_AsyncOperations)
- [msdyn_agreementinvoiceproduct_AsyncOperations](#BKMK_msdyn_agreementinvoiceproduct_AsyncOperations)
- [msdyn_agreementinvoicesetup_AsyncOperations](#BKMK_msdyn_agreementinvoicesetup_AsyncOperations)
- [msdyn_agreementsubstatus_AsyncOperations](#BKMK_msdyn_agreementsubstatus_AsyncOperations)
- [msdyn_assetsuggestionssetting_AsyncOperations](#BKMK_msdyn_assetsuggestionssetting_AsyncOperations)
- [msdyn_bookableresourceassociation_AsyncOperations](#BKMK_msdyn_bookableresourceassociation_AsyncOperations)
- [msdyn_bookableresourcebookingquicknote_AsyncOperations](#BKMK_msdyn_bookableresourcebookingquicknote_AsyncOperations)
- [msdyn_bookingalert_AsyncOperations](#BKMK_msdyn_bookingalert_AsyncOperations)
- [msdyn_bookingalertstatus_AsyncOperations](#BKMK_msdyn_bookingalertstatus_AsyncOperations)
- [msdyn_bookingchange_AsyncOperations](#BKMK_msdyn_bookingchange_AsyncOperations)
- [msdyn_bookingjournal_AsyncOperations](#BKMK_msdyn_bookingjournal_AsyncOperations)
- [msdyn_bookingrule_AsyncOperations](#BKMK_msdyn_bookingrule_AsyncOperations)
- [msdyn_bookingsetupmetadata_AsyncOperations](#BKMK_msdyn_bookingsetupmetadata_AsyncOperations)
- [msdyn_bookingtimestamp_AsyncOperations](#BKMK_msdyn_bookingtimestamp_AsyncOperations)
- [msdyn_bpf_2c5fe86acc8b414b8322ae571000c799_AsyncOperations](#BKMK_msdyn_bpf_2c5fe86acc8b414b8322ae571000c799_AsyncOperations)
- [msdyn_bpf_477c16f59170487b8b4dc895c5dcd09b_AsyncOperations](#BKMK_msdyn_bpf_477c16f59170487b8b4dc895c5dcd09b_AsyncOperations)
- [msdyn_bpf_989e9b1857e24af18787d5143b67523b_AsyncOperations](#BKMK_msdyn_bpf_989e9b1857e24af18787d5143b67523b_AsyncOperations)
- [msdyn_bpf_baa0a411a239410cb8bded8b5fdd88e3_AsyncOperations](#BKMK_msdyn_bpf_baa0a411a239410cb8bded8b5fdd88e3_AsyncOperations)
- [msdyn_bpf_d3d97bac8c294105840e99e37a9d1c39_AsyncOperations](#BKMK_msdyn_bpf_d3d97bac8c294105840e99e37a9d1c39_AsyncOperations)
- [msdyn_businessclosure_AsyncOperations](#BKMK_msdyn_businessclosure_AsyncOperations)
- [msdyn_clientextension_AsyncOperations](#BKMK_msdyn_clientextension_AsyncOperations)
- [msdyn_configuration_AsyncOperations](#BKMK_msdyn_configuration_AsyncOperations)
- [msdyn_consoleapplicationsessiontemplate_AsyncOperations](#BKMK_msdyn_consoleapplicationsessiontemplate_AsyncOperations)
- [msdyn_dataanalyticsreport_fs_AsyncOperations](#BKMK_msdyn_dataanalyticsreport_fs_AsyncOperations)
- [msdyn_dataanalyticsreport_fspredictrs_AsyncOperations](#BKMK_msdyn_dataanalyticsreport_fspredictrs_AsyncOperations)
- [msdyn_dataanalyticsreport_fspredictwhd_AsyncOperations](#BKMK_msdyn_dataanalyticsreport_fspredictwhd_AsyncOperations)
- [msdyn_entitlementapplication_AsyncOperations](#BKMK_msdyn_entitlementapplication_AsyncOperations)
- [msdyn_entityconfiguration_AsyncOperations](#BKMK_msdyn_entityconfiguration_AsyncOperations)
- [msdyn_fieldservicepricelistitem_AsyncOperations](#BKMK_msdyn_fieldservicepricelistitem_AsyncOperations)
- [msdyn_fieldservicesetting_AsyncOperations](#BKMK_msdyn_fieldservicesetting_AsyncOperations)
- [msdyn_fieldserviceslaconfiguration_AsyncOperations](#BKMK_msdyn_fieldserviceslaconfiguration_AsyncOperations)
- [msdyn_fieldservicesummaryconfiguration_AsyncOperations](#BKMK_msdyn_fieldservicesummaryconfiguration_AsyncOperations)
- [msdyn_fieldservicesystemjob_AsyncOperations](#BKMK_msdyn_fieldservicesystemjob_AsyncOperations)
- [msdyn_flwconfiguration_AsyncOperations](#BKMK_msdyn_flwconfiguration_AsyncOperations)
- [msdyn_geofence_AsyncOperations](#BKMK_msdyn_geofence_AsyncOperations)
- [msdyn_geofenceevent_AsyncOperations](#BKMK_msdyn_geofenceevent_AsyncOperations)
- [msdyn_geofencingsettings_AsyncOperations](#BKMK_msdyn_geofencingsettings_AsyncOperations)
- [msdyn_geolocationsettings_AsyncOperations](#BKMK_msdyn_geolocationsettings_AsyncOperations)
- [msdyn_geolocationtracking_AsyncOperations](#BKMK_msdyn_geolocationtracking_AsyncOperations)
- [msdyn_incidenttype_AsyncOperations](#BKMK_msdyn_incidenttype_AsyncOperations)
- [msdyn_incidenttype_requirementgroup_AsyncOperations](#BKMK_msdyn_incidenttype_requirementgroup_AsyncOperations)
- [msdyn_incidenttypecharacteristic_AsyncOperations](#BKMK_msdyn_incidenttypecharacteristic_AsyncOperations)
- [msdyn_incidenttypeproduct_AsyncOperations](#BKMK_msdyn_incidenttypeproduct_AsyncOperations)
- [msdyn_incidenttyperecommendationresult_AsyncOperations](#BKMK_msdyn_incidenttyperecommendationresult_AsyncOperations)
- [msdyn_incidenttyperecommendationrunhistory_AsyncOperations](#BKMK_msdyn_incidenttyperecommendationrunhistory_AsyncOperations)
- [msdyn_incidenttyperesolution_AsyncOperations](#BKMK_msdyn_incidenttyperesolution_AsyncOperations)
- [msdyn_incidenttypeservice_AsyncOperations](#BKMK_msdyn_incidenttypeservice_AsyncOperations)
- [msdyn_incidenttypeservicetask_AsyncOperations](#BKMK_msdyn_incidenttypeservicetask_AsyncOperations)
- [msdyn_incidenttypessetup_AsyncOperations](#BKMK_msdyn_incidenttypessetup_AsyncOperations)
- [msdyn_inspection_AsyncOperations](#BKMK_msdyn_inspection_AsyncOperations)
- [msdyn_inspectionattachment_AsyncOperations](#BKMK_msdyn_inspectionattachment_AsyncOperations)
- [msdyn_inspectiondefinition_AsyncOperations](#BKMK_msdyn_inspectiondefinition_AsyncOperations)
- [msdyn_inspectioninstance_AsyncOperations](#BKMK_msdyn_inspectioninstance_AsyncOperations)
- [msdyn_inspectionresponse_AsyncOperations](#BKMK_msdyn_inspectionresponse_AsyncOperations)
- [msdyn_insurance_AsyncOperations](#BKMK_msdyn_insurance_AsyncOperations)
- [msdyn_inventoryadjustment_AsyncOperations](#BKMK_msdyn_inventoryadjustment_AsyncOperations)
- [msdyn_inventoryadjustmentproduct_AsyncOperations](#BKMK_msdyn_inventoryadjustmentproduct_AsyncOperations)
- [msdyn_inventoryjournal_AsyncOperations](#BKMK_msdyn_inventoryjournal_AsyncOperations)
- [msdyn_inventorytransfer_AsyncOperations](#BKMK_msdyn_inventorytransfer_AsyncOperations)
- [msdyn_mobilesource_AsyncOperations](#BKMK_msdyn_mobilesource_AsyncOperations)
- [msdyn_nottoexceed_AsyncOperations](#BKMK_msdyn_nottoexceed_AsyncOperations)
- [msdyn_orderinvoicingdate_AsyncOperations](#BKMK_msdyn_orderinvoicingdate_AsyncOperations)
- [msdyn_orderinvoicingproduct_AsyncOperations](#BKMK_msdyn_orderinvoicingproduct_AsyncOperations)
- [msdyn_orderinvoicingsetup_AsyncOperations](#BKMK_msdyn_orderinvoicingsetup_AsyncOperations)
- [msdyn_orderinvoicingsetupdate_AsyncOperations](#BKMK_msdyn_orderinvoicingsetupdate_AsyncOperations)
- [msdyn_organizationalunit_AsyncOperations](#BKMK_msdyn_organizationalunit_AsyncOperations)
- [msdyn_payment_AsyncOperations](#BKMK_msdyn_payment_AsyncOperations)
- [msdyn_paymentdetail_AsyncOperations](#BKMK_msdyn_paymentdetail_AsyncOperations)
- [msdyn_paymentmethod_AsyncOperations](#BKMK_msdyn_paymentmethod_AsyncOperations)
- [msdyn_paymentterm_AsyncOperations](#BKMK_msdyn_paymentterm_AsyncOperations)
- [msdyn_postalcode_AsyncOperations](#BKMK_msdyn_postalcode_AsyncOperations)
- [msdyn_predictworkhourdurationsetting_AsyncOperations](#BKMK_msdyn_predictworkhourdurationsetting_AsyncOperations)
- [msdyn_priority_AsyncOperations](#BKMK_msdyn_priority_AsyncOperations)
- [msdyn_problematicasset_AsyncOperations](#BKMK_msdyn_problematicasset_AsyncOperations)
- [msdyn_problematicassetfeedback_AsyncOperations](#BKMK_msdyn_problematicassetfeedback_AsyncOperations)
- [msdyn_productinventory_AsyncOperations](#BKMK_msdyn_productinventory_AsyncOperations)
- [msdyn_purchaseorder_AsyncOperations](#BKMK_msdyn_purchaseorder_AsyncOperations)
- [msdyn_purchaseorderbill_AsyncOperations](#BKMK_msdyn_purchaseorderbill_AsyncOperations)
- [msdyn_purchaseorderproduct_AsyncOperations](#BKMK_msdyn_purchaseorderproduct_AsyncOperations)
- [msdyn_purchaseorderreceipt_AsyncOperations](#BKMK_msdyn_purchaseorderreceipt_AsyncOperations)
- [msdyn_purchaseorderreceiptproduct_AsyncOperations](#BKMK_msdyn_purchaseorderreceiptproduct_AsyncOperations)
- [msdyn_purchaseordersubstatus_AsyncOperations](#BKMK_msdyn_purchaseordersubstatus_AsyncOperations)
- [msdyn_quotebookingincident_AsyncOperations](#BKMK_msdyn_quotebookingincident_AsyncOperations)
- [msdyn_quotebookingproduct_AsyncOperations](#BKMK_msdyn_quotebookingproduct_AsyncOperations)
- [msdyn_quotebookingservice_AsyncOperations](#BKMK_msdyn_quotebookingservice_AsyncOperations)
- [msdyn_quotebookingservicetask_AsyncOperations](#BKMK_msdyn_quotebookingservicetask_AsyncOperations)
- [msdyn_quotebookingsetup_AsyncOperations](#BKMK_msdyn_quotebookingsetup_AsyncOperations)
- [msdyn_quoteinvoicingproduct_AsyncOperations](#BKMK_msdyn_quoteinvoicingproduct_AsyncOperations)
- [msdyn_quoteinvoicingsetup_AsyncOperations](#BKMK_msdyn_quoteinvoicingsetup_AsyncOperations)
- [msdyn_requirementchange_AsyncOperations](#BKMK_msdyn_requirementchange_AsyncOperations)
- [msdyn_requirementcharacteristic_AsyncOperations](#BKMK_msdyn_requirementcharacteristic_AsyncOperations)
- [msdyn_requirementdependency_AsyncOperations](#BKMK_msdyn_requirementdependency_AsyncOperations)
- [msdyn_requirementgroup_AsyncOperations](#BKMK_msdyn_requirementgroup_AsyncOperations)
- [msdyn_requirementorganizationunit_AsyncOperations](#BKMK_msdyn_requirementorganizationunit_AsyncOperations)
- [msdyn_requirementrelationship_AsyncOperations](#BKMK_msdyn_requirementrelationship_AsyncOperations)
- [msdyn_requirementresourcecategory_AsyncOperations](#BKMK_msdyn_requirementresourcecategory_AsyncOperations)
- [msdyn_requirementresourcepreference_AsyncOperations](#BKMK_msdyn_requirementresourcepreference_AsyncOperations)
- [msdyn_requirementstatus_AsyncOperations](#BKMK_msdyn_requirementstatus_AsyncOperations)
- [msdyn_resolution_AsyncOperations](#BKMK_msdyn_resolution_AsyncOperations)
- [msdyn_resourcepaytype_AsyncOperations](#BKMK_msdyn_resourcepaytype_AsyncOperations)
- [msdyn_resourcerequirement_AsyncOperations](#BKMK_msdyn_resourcerequirement_AsyncOperations)
- [msdyn_resourcerequirementdetail_AsyncOperations](#BKMK_msdyn_resourcerequirementdetail_AsyncOperations)
- [msdyn_resourceterritory_AsyncOperations](#BKMK_msdyn_resourceterritory_AsyncOperations)
- [msdyn_rma_AsyncOperations](#BKMK_msdyn_rma_AsyncOperations)
- [msdyn_rmaproduct_AsyncOperations](#BKMK_msdyn_rmaproduct_AsyncOperations)
- [msdyn_rmareceipt_AsyncOperations](#BKMK_msdyn_rmareceipt_AsyncOperations)
- [msdyn_rmareceiptproduct_AsyncOperations](#BKMK_msdyn_rmareceiptproduct_AsyncOperations)
- [msdyn_rmasubstatus_AsyncOperations](#BKMK_msdyn_rmasubstatus_AsyncOperations)
- [msdyn_rtv_AsyncOperations](#BKMK_msdyn_rtv_AsyncOperations)
- [msdyn_rtvproduct_AsyncOperations](#BKMK_msdyn_rtvproduct_AsyncOperations)
- [msdyn_rtvsubstatus_AsyncOperations](#BKMK_msdyn_rtvsubstatus_AsyncOperations)
- [msdyn_scheduleboardsetting_AsyncOperations](#BKMK_msdyn_scheduleboardsetting_AsyncOperations)
- [msdyn_schedulingfeatureflag_AsyncOperations](#BKMK_msdyn_schedulingfeatureflag_AsyncOperations)
- [msdyn_schedulingparameter_AsyncOperations](#BKMK_msdyn_schedulingparameter_AsyncOperations)
- [msdyn_servicetasktype_AsyncOperations](#BKMK_msdyn_servicetasktype_AsyncOperations)
- [msdyn_sessiondata_AsyncOperations](#BKMK_msdyn_sessiondata_AsyncOperations)
- [msdyn_sessionparticipantdata_AsyncOperations](#BKMK_msdyn_sessionparticipantdata_AsyncOperations)
- [msdyn_shipvia_AsyncOperations](#BKMK_msdyn_shipvia_AsyncOperations)
- [msdyn_systemuserschedulersetting_AsyncOperations](#BKMK_msdyn_systemuserschedulersetting_AsyncOperations)
- [msdyn_taxcode_AsyncOperations](#BKMK_msdyn_taxcode_AsyncOperations)
- [msdyn_taxcodedetail_AsyncOperations](#BKMK_msdyn_taxcodedetail_AsyncOperations)
- [msdyn_timeentry_AsyncOperations](#BKMK_msdyn_timeentry_AsyncOperations)
- [msdyn_timeentrysetting_AsyncOperations](#BKMK_msdyn_timeentrysetting_AsyncOperations)
- [msdyn_timegroup_AsyncOperations](#BKMK_msdyn_timegroup_AsyncOperations)
- [msdyn_timegroupdetail_AsyncOperations](#BKMK_msdyn_timegroupdetail_AsyncOperations)
- [msdyn_timeoffrequest_AsyncOperations](#BKMK_msdyn_timeoffrequest_AsyncOperations)
- [msdyn_trade_AsyncOperations](#BKMK_msdyn_trade_AsyncOperations)
- [msdyn_tradecoverage_AsyncOperations](#BKMK_msdyn_tradecoverage_AsyncOperations)
- [msdyn_transactionorigin_AsyncOperations](#BKMK_msdyn_transactionorigin_AsyncOperations)
- [msdyn_uniquenumber_AsyncOperations](#BKMK_msdyn_uniquenumber_AsyncOperations)
- [msdyn_warehouse_AsyncOperations](#BKMK_msdyn_warehouse_AsyncOperations)
- [msdyn_workhourtemplate_AsyncOperations](#BKMK_msdyn_workhourtemplate_AsyncOperations)
- [msdyn_workorder_AsyncOperations](#BKMK_msdyn_workorder_AsyncOperations)
- [msdyn_workorderincident_AsyncOperations](#BKMK_msdyn_workorderincident_AsyncOperations)
- [msdyn_workordernte_AsyncOperations](#BKMK_msdyn_workordernte_AsyncOperations)
- [msdyn_workorderproduct_AsyncOperations](#BKMK_msdyn_workorderproduct_AsyncOperations)
- [msdyn_workorderresolution_AsyncOperations](#BKMK_msdyn_workorderresolution_AsyncOperations)
- [msdyn_workorderresourcerestriction_AsyncOperations](#BKMK_msdyn_workorderresourcerestriction_AsyncOperations)
- [msdyn_workorderservice_AsyncOperations](#BKMK_msdyn_workorderservice_AsyncOperations)
- [msdyn_workorderservicetask_AsyncOperations](#BKMK_msdyn_workorderservicetask_AsyncOperations)
- [msdyn_workordersubstatus_AsyncOperations](#BKMK_msdyn_workordersubstatus_AsyncOperations)
- [msdyn_workordertype_AsyncOperations](#BKMK_msdyn_workordertype_AsyncOperations)

### <a name="BKMK_msdyn_3dmodel_AsyncOperations"></a> msdyn_3dmodel_AsyncOperations

One-To-Many Relationship: [msdyn_3dmodel msdyn_3dmodel_AsyncOperations](msdyn_3dmodel.md#BKMK_msdyn_3dmodel_AsyncOperations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_3dmodel`|
|ReferencedAttribute|`msdyn_3dmodelid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_3dmodel`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_actual_AsyncOperations"></a> msdyn_actual_AsyncOperations

One-To-Many Relationship: [msdyn_actual msdyn_actual_AsyncOperations](msdyn_actual.md#BKMK_msdyn_actual_AsyncOperations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_actual`|
|ReferencedAttribute|`msdyn_actualid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_actual`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_agreement_AsyncOperations"></a> msdyn_agreement_AsyncOperations

One-To-Many Relationship: [msdyn_agreement msdyn_agreement_AsyncOperations](msdyn_agreement.md#BKMK_msdyn_agreement_AsyncOperations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_agreement`|
|ReferencedAttribute|`msdyn_agreementid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_agreement`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_agreementbookingdate_AsyncOperations"></a> msdyn_agreementbookingdate_AsyncOperations

One-To-Many Relationship: [msdyn_agreementbookingdate msdyn_agreementbookingdate_AsyncOperations](msdyn_agreementbookingdate.md#BKMK_msdyn_agreementbookingdate_AsyncOperations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_agreementbookingdate`|
|ReferencedAttribute|`msdyn_agreementbookingdateid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_agreementbookingdate`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_agreementbookingincident_AsyncOperations"></a> msdyn_agreementbookingincident_AsyncOperations

One-To-Many Relationship: [msdyn_agreementbookingincident msdyn_agreementbookingincident_AsyncOperations](msdyn_agreementbookingincident.md#BKMK_msdyn_agreementbookingincident_AsyncOperations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_agreementbookingincident`|
|ReferencedAttribute|`msdyn_agreementbookingincidentid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_agreementbookingincident`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_agreementbookingproduct_AsyncOperations"></a> msdyn_agreementbookingproduct_AsyncOperations

One-To-Many Relationship: [msdyn_agreementbookingproduct msdyn_agreementbookingproduct_AsyncOperations](msdyn_agreementbookingproduct.md#BKMK_msdyn_agreementbookingproduct_AsyncOperations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_agreementbookingproduct`|
|ReferencedAttribute|`msdyn_agreementbookingproductid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_agreementbookingproduct`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_agreementbookingservice_AsyncOperations"></a> msdyn_agreementbookingservice_AsyncOperations

One-To-Many Relationship: [msdyn_agreementbookingservice msdyn_agreementbookingservice_AsyncOperations](msdyn_agreementbookingservice.md#BKMK_msdyn_agreementbookingservice_AsyncOperations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_agreementbookingservice`|
|ReferencedAttribute|`msdyn_agreementbookingserviceid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_agreementbookingservice`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_agreementbookingservicetask_AsyncOperations"></a> msdyn_agreementbookingservicetask_AsyncOperations

One-To-Many Relationship: [msdyn_agreementbookingservicetask msdyn_agreementbookingservicetask_AsyncOperations](msdyn_agreementbookingservicetask.md#BKMK_msdyn_agreementbookingservicetask_AsyncOperations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_agreementbookingservicetask`|
|ReferencedAttribute|`msdyn_agreementbookingservicetaskid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_agreementbookingservicetask`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_agreementbookingsetup_AsyncOperations"></a> msdyn_agreementbookingsetup_AsyncOperations

One-To-Many Relationship: [msdyn_agreementbookingsetup msdyn_agreementbookingsetup_AsyncOperations](msdyn_agreementbookingsetup.md#BKMK_msdyn_agreementbookingsetup_AsyncOperations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_agreementbookingsetup`|
|ReferencedAttribute|`msdyn_agreementbookingsetupid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_agreementbookingsetup`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_agreementinvoicedate_AsyncOperations"></a> msdyn_agreementinvoicedate_AsyncOperations

One-To-Many Relationship: [msdyn_agreementinvoicedate msdyn_agreementinvoicedate_AsyncOperations](msdyn_agreementinvoicedate.md#BKMK_msdyn_agreementinvoicedate_AsyncOperations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_agreementinvoicedate`|
|ReferencedAttribute|`msdyn_agreementinvoicedateid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_agreementinvoicedate`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_agreementinvoiceproduct_AsyncOperations"></a> msdyn_agreementinvoiceproduct_AsyncOperations

One-To-Many Relationship: [msdyn_agreementinvoiceproduct msdyn_agreementinvoiceproduct_AsyncOperations](msdyn_agreementinvoiceproduct.md#BKMK_msdyn_agreementinvoiceproduct_AsyncOperations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_agreementinvoiceproduct`|
|ReferencedAttribute|`msdyn_agreementinvoiceproductid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_agreementinvoiceproduct`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_agreementinvoicesetup_AsyncOperations"></a> msdyn_agreementinvoicesetup_AsyncOperations

One-To-Many Relationship: [msdyn_agreementinvoicesetup msdyn_agreementinvoicesetup_AsyncOperations](msdyn_agreementinvoicesetup.md#BKMK_msdyn_agreementinvoicesetup_AsyncOperations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_agreementinvoicesetup`|
|ReferencedAttribute|`msdyn_agreementinvoicesetupid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_agreementinvoicesetup`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_agreementsubstatus_AsyncOperations"></a> msdyn_agreementsubstatus_AsyncOperations

One-To-Many Relationship: [msdyn_agreementsubstatus msdyn_agreementsubstatus_AsyncOperations](msdyn_agreementsubstatus.md#BKMK_msdyn_agreementsubstatus_AsyncOperations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_agreementsubstatus`|
|ReferencedAttribute|`msdyn_agreementsubstatusid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_agreementsubstatus`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_assetsuggestionssetting_AsyncOperations"></a> msdyn_assetsuggestionssetting_AsyncOperations

One-To-Many Relationship: [msdyn_assetsuggestionssetting msdyn_assetsuggestionssetting_AsyncOperations](msdyn_assetsuggestionssetting.md#BKMK_msdyn_assetsuggestionssetting_AsyncOperations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_assetsuggestionssetting`|
|ReferencedAttribute|`msdyn_assetsuggestionssettingid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_assetsuggestionssetting`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_bookableresourceassociation_AsyncOperations"></a> msdyn_bookableresourceassociation_AsyncOperations

One-To-Many Relationship: [msdyn_bookableresourceassociation msdyn_bookableresourceassociation_AsyncOperations](msdyn_bookableresourceassociation.md#BKMK_msdyn_bookableresourceassociation_AsyncOperations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_bookableresourceassociation`|
|ReferencedAttribute|`msdyn_bookableresourceassociationid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_bookableresourceassociation`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_bookableresourcebookingquicknote_AsyncOperations"></a> msdyn_bookableresourcebookingquicknote_AsyncOperations

One-To-Many Relationship: [msdyn_bookableresourcebookingquicknote msdyn_bookableresourcebookingquicknote_AsyncOperations](msdyn_bookableresourcebookingquicknote.md#BKMK_msdyn_bookableresourcebookingquicknote_AsyncOperations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_bookableresourcebookingquicknote`|
|ReferencedAttribute|`msdyn_bookableresourcebookingquicknoteid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_bookableresourcebookingquicknote`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_bookingalert_AsyncOperations"></a> msdyn_bookingalert_AsyncOperations

One-To-Many Relationship: [msdyn_bookingalert msdyn_bookingalert_AsyncOperations](msdyn_bookingalert.md#BKMK_msdyn_bookingalert_AsyncOperations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_bookingalert`|
|ReferencedAttribute|`activityid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_bookingalert`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_bookingalertstatus_AsyncOperations"></a> msdyn_bookingalertstatus_AsyncOperations

One-To-Many Relationship: [msdyn_bookingalertstatus msdyn_bookingalertstatus_AsyncOperations](msdyn_bookingalertstatus.md#BKMK_msdyn_bookingalertstatus_AsyncOperations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_bookingalertstatus`|
|ReferencedAttribute|`msdyn_bookingalertstatusid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_bookingalertstatus`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_bookingchange_AsyncOperations"></a> msdyn_bookingchange_AsyncOperations

One-To-Many Relationship: [msdyn_bookingchange msdyn_bookingchange_AsyncOperations](msdyn_bookingchange.md#BKMK_msdyn_bookingchange_AsyncOperations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_bookingchange`|
|ReferencedAttribute|`msdyn_bookingchangeid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_bookingchange`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_bookingjournal_AsyncOperations"></a> msdyn_bookingjournal_AsyncOperations

One-To-Many Relationship: [msdyn_bookingjournal msdyn_bookingjournal_AsyncOperations](msdyn_bookingjournal.md#BKMK_msdyn_bookingjournal_AsyncOperations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_bookingjournal`|
|ReferencedAttribute|`msdyn_bookingjournalid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_bookingjournal`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_bookingrule_AsyncOperations"></a> msdyn_bookingrule_AsyncOperations

One-To-Many Relationship: [msdyn_bookingrule msdyn_bookingrule_AsyncOperations](msdyn_bookingrule.md#BKMK_msdyn_bookingrule_AsyncOperations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_bookingrule`|
|ReferencedAttribute|`msdyn_bookingruleid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_bookingrule`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_bookingsetupmetadata_AsyncOperations"></a> msdyn_bookingsetupmetadata_AsyncOperations

One-To-Many Relationship: [msdyn_bookingsetupmetadata msdyn_bookingsetupmetadata_AsyncOperations](msdyn_bookingsetupmetadata.md#BKMK_msdyn_bookingsetupmetadata_AsyncOperations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_bookingsetupmetadata`|
|ReferencedAttribute|`msdyn_bookingsetupmetadataid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_bookingsetupmetadata`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_bookingtimestamp_AsyncOperations"></a> msdyn_bookingtimestamp_AsyncOperations

One-To-Many Relationship: [msdyn_bookingtimestamp msdyn_bookingtimestamp_AsyncOperations](msdyn_bookingtimestamp.md#BKMK_msdyn_bookingtimestamp_AsyncOperations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_bookingtimestamp`|
|ReferencedAttribute|`msdyn_bookingtimestampid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_bookingtimestamp`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_bpf_2c5fe86acc8b414b8322ae571000c799_AsyncOperations"></a> msdyn_bpf_2c5fe86acc8b414b8322ae571000c799_AsyncOperations

One-To-Many Relationship: [msdyn_bpf_2c5fe86acc8b414b8322ae571000c799 msdyn_bpf_2c5fe86acc8b414b8322ae571000c799_AsyncOperations](msdyn_bpf_2c5fe86acc8b414b8322ae571000c799.md#BKMK_msdyn_bpf_2c5fe86acc8b414b8322ae571000c799_AsyncOperations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_bpf_2c5fe86acc8b414b8322ae571000c799`|
|ReferencedAttribute|`businessprocessflowinstanceid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_bpf_2c5fe86acc8b414b8322ae571000c799`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_bpf_477c16f59170487b8b4dc895c5dcd09b_AsyncOperations"></a> msdyn_bpf_477c16f59170487b8b4dc895c5dcd09b_AsyncOperations

One-To-Many Relationship: [msdyn_bpf_477c16f59170487b8b4dc895c5dcd09b msdyn_bpf_477c16f59170487b8b4dc895c5dcd09b_AsyncOperations](msdyn_bpf_477c16f59170487b8b4dc895c5dcd09b.md#BKMK_msdyn_bpf_477c16f59170487b8b4dc895c5dcd09b_AsyncOperations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_bpf_477c16f59170487b8b4dc895c5dcd09b`|
|ReferencedAttribute|`businessprocessflowinstanceid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_bpf_477c16f59170487b8b4dc895c5dcd09b`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_bpf_989e9b1857e24af18787d5143b67523b_AsyncOperations"></a> msdyn_bpf_989e9b1857e24af18787d5143b67523b_AsyncOperations

One-To-Many Relationship: [msdyn_bpf_989e9b1857e24af18787d5143b67523b msdyn_bpf_989e9b1857e24af18787d5143b67523b_AsyncOperations](msdyn_bpf_989e9b1857e24af18787d5143b67523b.md#BKMK_msdyn_bpf_989e9b1857e24af18787d5143b67523b_AsyncOperations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_bpf_989e9b1857e24af18787d5143b67523b`|
|ReferencedAttribute|`businessprocessflowinstanceid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_bpf_989e9b1857e24af18787d5143b67523b`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_bpf_baa0a411a239410cb8bded8b5fdd88e3_AsyncOperations"></a> msdyn_bpf_baa0a411a239410cb8bded8b5fdd88e3_AsyncOperations

One-To-Many Relationship: [msdyn_bpf_baa0a411a239410cb8bded8b5fdd88e3 msdyn_bpf_baa0a411a239410cb8bded8b5fdd88e3_AsyncOperations](msdyn_bpf_baa0a411a239410cb8bded8b5fdd88e3.md#BKMK_msdyn_bpf_baa0a411a239410cb8bded8b5fdd88e3_AsyncOperations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_bpf_baa0a411a239410cb8bded8b5fdd88e3`|
|ReferencedAttribute|`businessprocessflowinstanceid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_bpf_baa0a411a239410cb8bded8b5fdd88e3`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_bpf_d3d97bac8c294105840e99e37a9d1c39_AsyncOperations"></a> msdyn_bpf_d3d97bac8c294105840e99e37a9d1c39_AsyncOperations

One-To-Many Relationship: [msdyn_bpf_d3d97bac8c294105840e99e37a9d1c39 msdyn_bpf_d3d97bac8c294105840e99e37a9d1c39_AsyncOperations](msdyn_bpf_d3d97bac8c294105840e99e37a9d1c39.md#BKMK_msdyn_bpf_d3d97bac8c294105840e99e37a9d1c39_AsyncOperations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_bpf_d3d97bac8c294105840e99e37a9d1c39`|
|ReferencedAttribute|`businessprocessflowinstanceid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_bpf_d3d97bac8c294105840e99e37a9d1c39`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_businessclosure_AsyncOperations"></a> msdyn_businessclosure_AsyncOperations

One-To-Many Relationship: [msdyn_businessclosure msdyn_businessclosure_AsyncOperations](msdyn_businessclosure.md#BKMK_msdyn_businessclosure_AsyncOperations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_businessclosure`|
|ReferencedAttribute|`msdyn_businessclosureid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_businessclosure`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_clientextension_AsyncOperations"></a> msdyn_clientextension_AsyncOperations

One-To-Many Relationship: [msdyn_clientextension msdyn_clientextension_AsyncOperations](msdyn_clientextension.md#BKMK_msdyn_clientextension_AsyncOperations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_clientextension`|
|ReferencedAttribute|`msdyn_clientextensionid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_clientextension`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_configuration_AsyncOperations"></a> msdyn_configuration_AsyncOperations

One-To-Many Relationship: [msdyn_configuration msdyn_configuration_AsyncOperations](msdyn_configuration.md#BKMK_msdyn_configuration_AsyncOperations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_configuration`|
|ReferencedAttribute|`msdyn_configurationid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_configuration`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_consoleapplicationsessiontemplate_AsyncOperations"></a> msdyn_consoleapplicationsessiontemplate_AsyncOperations

One-To-Many Relationship: [msdyn_consoleapplicationsessiontemplate msdyn_consoleapplicationsessiontemplate_AsyncOperations](msdyn_consoleapplicationsessiontemplate.md#BKMK_msdyn_consoleapplicationsessiontemplate_AsyncOperations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_consoleapplicationsessiontemplate`|
|ReferencedAttribute|`msdyn_consoleapplicationsessiontemplateid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_consoleapplicationsessiontemplate`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_dataanalyticsreport_fs_AsyncOperations"></a> msdyn_dataanalyticsreport_fs_AsyncOperations

One-To-Many Relationship: [msdyn_dataanalyticsreport_fs msdyn_dataanalyticsreport_fs_AsyncOperations](msdyn_dataanalyticsreport_fs.md#BKMK_msdyn_dataanalyticsreport_fs_AsyncOperations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_dataanalyticsreport_fs`|
|ReferencedAttribute|`msdyn_dataanalyticsreport_fsid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_dataanalyticsreport_fs`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_dataanalyticsreport_fspredictrs_AsyncOperations"></a> msdyn_dataanalyticsreport_fspredictrs_AsyncOperations

One-To-Many Relationship: [msdyn_dataanalyticsreport_fspredictrs msdyn_dataanalyticsreport_fspredictrs_AsyncOperations](msdyn_dataanalyticsreport_fspredictrs.md#BKMK_msdyn_dataanalyticsreport_fspredictrs_AsyncOperations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_dataanalyticsreport_fspredictrs`|
|ReferencedAttribute|`msdyn_dataanalyticsreport_fspredictrsid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_dataanalyticsreport_fspredictrs`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_dataanalyticsreport_fspredictwhd_AsyncOperations"></a> msdyn_dataanalyticsreport_fspredictwhd_AsyncOperations

One-To-Many Relationship: [msdyn_dataanalyticsreport_fspredictwhd msdyn_dataanalyticsreport_fspredictwhd_AsyncOperations](msdyn_dataanalyticsreport_fspredictwhd.md#BKMK_msdyn_dataanalyticsreport_fspredictwhd_AsyncOperations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_dataanalyticsreport_fspredictwhd`|
|ReferencedAttribute|`msdyn_dataanalyticsreport_fspredictwhdid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_dataanalyticsreport_fspredictwhd`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_entitlementapplication_AsyncOperations"></a> msdyn_entitlementapplication_AsyncOperations

One-To-Many Relationship: [msdyn_entitlementapplication msdyn_entitlementapplication_AsyncOperations](msdyn_entitlementapplication.md#BKMK_msdyn_entitlementapplication_AsyncOperations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_entitlementapplication`|
|ReferencedAttribute|`msdyn_entitlementapplicationid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_entitlementapplication`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_entityconfiguration_AsyncOperations"></a> msdyn_entityconfiguration_AsyncOperations

One-To-Many Relationship: [msdyn_entityconfiguration msdyn_entityconfiguration_AsyncOperations](msdyn_entityconfiguration.md#BKMK_msdyn_entityconfiguration_AsyncOperations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_entityconfiguration`|
|ReferencedAttribute|`msdyn_entityconfigurationid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_entityconfiguration`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_fieldservicepricelistitem_AsyncOperations"></a> msdyn_fieldservicepricelistitem_AsyncOperations

One-To-Many Relationship: [msdyn_fieldservicepricelistitem msdyn_fieldservicepricelistitem_AsyncOperations](msdyn_fieldservicepricelistitem.md#BKMK_msdyn_fieldservicepricelistitem_AsyncOperations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_fieldservicepricelistitem`|
|ReferencedAttribute|`msdyn_fieldservicepricelistitemid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_fieldservicepricelistitem`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_fieldservicesetting_AsyncOperations"></a> msdyn_fieldservicesetting_AsyncOperations

One-To-Many Relationship: [msdyn_fieldservicesetting msdyn_fieldservicesetting_AsyncOperations](msdyn_fieldservicesetting.md#BKMK_msdyn_fieldservicesetting_AsyncOperations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_fieldservicesetting`|
|ReferencedAttribute|`msdyn_fieldservicesettingid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_fieldservicesetting`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_fieldserviceslaconfiguration_AsyncOperations"></a> msdyn_fieldserviceslaconfiguration_AsyncOperations

One-To-Many Relationship: [msdyn_fieldserviceslaconfiguration msdyn_fieldserviceslaconfiguration_AsyncOperations](msdyn_fieldserviceslaconfiguration.md#BKMK_msdyn_fieldserviceslaconfiguration_AsyncOperations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_fieldserviceslaconfiguration`|
|ReferencedAttribute|`msdyn_fieldserviceslaconfigurationid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_fieldserviceslaconfiguration`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_fieldservicesummaryconfiguration_AsyncOperations"></a> msdyn_fieldservicesummaryconfiguration_AsyncOperations

One-To-Many Relationship: [msdyn_fieldservicesummaryconfiguration msdyn_fieldservicesummaryconfiguration_AsyncOperations](msdyn_fieldservicesummaryconfiguration.md#BKMK_msdyn_fieldservicesummaryconfiguration_AsyncOperations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_fieldservicesummaryconfiguration`|
|ReferencedAttribute|`msdyn_fieldservicesummaryconfigurationid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_fieldservicesummaryconfiguration`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_fieldservicesystemjob_AsyncOperations"></a> msdyn_fieldservicesystemjob_AsyncOperations

One-To-Many Relationship: [msdyn_fieldservicesystemjob msdyn_fieldservicesystemjob_AsyncOperations](msdyn_fieldservicesystemjob.md#BKMK_msdyn_fieldservicesystemjob_AsyncOperations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_fieldservicesystemjob`|
|ReferencedAttribute|`msdyn_fieldservicesystemjobid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_fieldservicesystemjob`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_flwconfiguration_AsyncOperations"></a> msdyn_flwconfiguration_AsyncOperations

One-To-Many Relationship: [msdyn_flwconfiguration msdyn_flwconfiguration_AsyncOperations](msdyn_flwconfiguration.md#BKMK_msdyn_flwconfiguration_AsyncOperations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_flwconfiguration`|
|ReferencedAttribute|`msdyn_flwconfigurationid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_flwconfiguration`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_geofence_AsyncOperations"></a> msdyn_geofence_AsyncOperations

One-To-Many Relationship: [msdyn_geofence msdyn_geofence_AsyncOperations](msdyn_geofence.md#BKMK_msdyn_geofence_AsyncOperations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_geofence`|
|ReferencedAttribute|`msdyn_geofenceid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_geofence`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_geofenceevent_AsyncOperations"></a> msdyn_geofenceevent_AsyncOperations

One-To-Many Relationship: [msdyn_geofenceevent msdyn_geofenceevent_AsyncOperations](msdyn_geofenceevent.md#BKMK_msdyn_geofenceevent_AsyncOperations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_geofenceevent`|
|ReferencedAttribute|`msdyn_geofenceeventid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_geofenceevent`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_geofencingsettings_AsyncOperations"></a> msdyn_geofencingsettings_AsyncOperations

One-To-Many Relationship: [msdyn_geofencingsettings msdyn_geofencingsettings_AsyncOperations](msdyn_geofencingsettings.md#BKMK_msdyn_geofencingsettings_AsyncOperations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_geofencingsettings`|
|ReferencedAttribute|`msdyn_geofencingsettingsid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_geofencingsettings`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_geolocationsettings_AsyncOperations"></a> msdyn_geolocationsettings_AsyncOperations

One-To-Many Relationship: [msdyn_geolocationsettings msdyn_geolocationsettings_AsyncOperations](msdyn_geolocationsettings.md#BKMK_msdyn_geolocationsettings_AsyncOperations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_geolocationsettings`|
|ReferencedAttribute|`msdyn_geolocationsettingsid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_geolocationsettings`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_geolocationtracking_AsyncOperations"></a> msdyn_geolocationtracking_AsyncOperations

One-To-Many Relationship: [msdyn_geolocationtracking msdyn_geolocationtracking_AsyncOperations](msdyn_geolocationtracking.md#BKMK_msdyn_geolocationtracking_AsyncOperations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_geolocationtracking`|
|ReferencedAttribute|`msdyn_geolocationtrackingid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_geolocationtracking`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_incidenttype_AsyncOperations"></a> msdyn_incidenttype_AsyncOperations

One-To-Many Relationship: [msdyn_incidenttype msdyn_incidenttype_AsyncOperations](msdyn_incidenttype.md#BKMK_msdyn_incidenttype_AsyncOperations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_incidenttype`|
|ReferencedAttribute|`msdyn_incidenttypeid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_incidenttype`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_incidenttype_requirementgroup_AsyncOperations"></a> msdyn_incidenttype_requirementgroup_AsyncOperations

One-To-Many Relationship: [msdyn_incidenttype_requirementgroup msdyn_incidenttype_requirementgroup_AsyncOperations](msdyn_incidenttype_requirementgroup.md#BKMK_msdyn_incidenttype_requirementgroup_AsyncOperations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_incidenttype_requirementgroup`|
|ReferencedAttribute|`msdyn_incidenttype_requirementgroupid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_incidenttype_requirementgroup`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_incidenttypecharacteristic_AsyncOperations"></a> msdyn_incidenttypecharacteristic_AsyncOperations

One-To-Many Relationship: [msdyn_incidenttypecharacteristic msdyn_incidenttypecharacteristic_AsyncOperations](msdyn_incidenttypecharacteristic.md#BKMK_msdyn_incidenttypecharacteristic_AsyncOperations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_incidenttypecharacteristic`|
|ReferencedAttribute|`msdyn_incidenttypecharacteristicid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_incidenttypecharacteristic`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_incidenttypeproduct_AsyncOperations"></a> msdyn_incidenttypeproduct_AsyncOperations

One-To-Many Relationship: [msdyn_incidenttypeproduct msdyn_incidenttypeproduct_AsyncOperations](msdyn_incidenttypeproduct.md#BKMK_msdyn_incidenttypeproduct_AsyncOperations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_incidenttypeproduct`|
|ReferencedAttribute|`msdyn_incidenttypeproductid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_incidenttypeproduct`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_incidenttyperecommendationresult_AsyncOperations"></a> msdyn_incidenttyperecommendationresult_AsyncOperations

One-To-Many Relationship: [msdyn_incidenttyperecommendationresult msdyn_incidenttyperecommendationresult_AsyncOperations](msdyn_incidenttyperecommendationresult.md#BKMK_msdyn_incidenttyperecommendationresult_AsyncOperations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_incidenttyperecommendationresult`|
|ReferencedAttribute|`msdyn_incidenttyperecommendationresultid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_incidenttyperecommendationresult`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_incidenttyperecommendationrunhistory_AsyncOperations"></a> msdyn_incidenttyperecommendationrunhistory_AsyncOperations

One-To-Many Relationship: [msdyn_incidenttyperecommendationrunhistory msdyn_incidenttyperecommendationrunhistory_AsyncOperations](msdyn_incidenttyperecommendationrunhistory.md#BKMK_msdyn_incidenttyperecommendationrunhistory_AsyncOperations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_incidenttyperecommendationrunhistory`|
|ReferencedAttribute|`msdyn_incidenttyperecommendationrunhistoryid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_incidenttyperecommendationrunhistory`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_incidenttyperesolution_AsyncOperations"></a> msdyn_incidenttyperesolution_AsyncOperations

One-To-Many Relationship: [msdyn_incidenttyperesolution msdyn_incidenttyperesolution_AsyncOperations](msdyn_incidenttyperesolution.md#BKMK_msdyn_incidenttyperesolution_AsyncOperations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_incidenttyperesolution`|
|ReferencedAttribute|`msdyn_incidenttyperesolutionid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_incidenttyperesolution`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_incidenttypeservice_AsyncOperations"></a> msdyn_incidenttypeservice_AsyncOperations

One-To-Many Relationship: [msdyn_incidenttypeservice msdyn_incidenttypeservice_AsyncOperations](msdyn_incidenttypeservice.md#BKMK_msdyn_incidenttypeservice_AsyncOperations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_incidenttypeservice`|
|ReferencedAttribute|`msdyn_incidenttypeserviceid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_incidenttypeservice`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_incidenttypeservicetask_AsyncOperations"></a> msdyn_incidenttypeservicetask_AsyncOperations

One-To-Many Relationship: [msdyn_incidenttypeservicetask msdyn_incidenttypeservicetask_AsyncOperations](msdyn_incidenttypeservicetask.md#BKMK_msdyn_incidenttypeservicetask_AsyncOperations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_incidenttypeservicetask`|
|ReferencedAttribute|`msdyn_incidenttypeservicetaskid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_incidenttypeservicetask`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_incidenttypessetup_AsyncOperations"></a> msdyn_incidenttypessetup_AsyncOperations

One-To-Many Relationship: [msdyn_incidenttypessetup msdyn_incidenttypessetup_AsyncOperations](msdyn_incidenttypessetup.md#BKMK_msdyn_incidenttypessetup_AsyncOperations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_incidenttypessetup`|
|ReferencedAttribute|`msdyn_incidenttypessetupid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_incidenttypessetup`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_inspection_AsyncOperations"></a> msdyn_inspection_AsyncOperations

One-To-Many Relationship: [msdyn_inspection msdyn_inspection_AsyncOperations](msdyn_inspection.md#BKMK_msdyn_inspection_AsyncOperations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_inspection`|
|ReferencedAttribute|`msdyn_inspectionid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_inspection`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_inspectionattachment_AsyncOperations"></a> msdyn_inspectionattachment_AsyncOperations

One-To-Many Relationship: [msdyn_inspectionattachment msdyn_inspectionattachment_AsyncOperations](msdyn_inspectionattachment.md#BKMK_msdyn_inspectionattachment_AsyncOperations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_inspectionattachment`|
|ReferencedAttribute|`msdyn_inspectionattachmentid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_inspectionattachment`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_inspectiondefinition_AsyncOperations"></a> msdyn_inspectiondefinition_AsyncOperations

One-To-Many Relationship: [msdyn_inspectiondefinition msdyn_inspectiondefinition_AsyncOperations](msdyn_inspectiondefinition.md#BKMK_msdyn_inspectiondefinition_AsyncOperations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_inspectiondefinition`|
|ReferencedAttribute|`msdyn_inspectiondefinitionid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_inspectiondefinition`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_inspectioninstance_AsyncOperations"></a> msdyn_inspectioninstance_AsyncOperations

One-To-Many Relationship: [msdyn_inspectioninstance msdyn_inspectioninstance_AsyncOperations](msdyn_inspectioninstance.md#BKMK_msdyn_inspectioninstance_AsyncOperations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_inspectioninstance`|
|ReferencedAttribute|`msdyn_inspectioninstanceid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_inspectioninstance`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_inspectionresponse_AsyncOperations"></a> msdyn_inspectionresponse_AsyncOperations

One-To-Many Relationship: [msdyn_inspectionresponse msdyn_inspectionresponse_AsyncOperations](msdyn_inspectionresponse.md#BKMK_msdyn_inspectionresponse_AsyncOperations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_inspectionresponse`|
|ReferencedAttribute|`msdyn_inspectionresponseid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_inspectionresponse`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_insurance_AsyncOperations"></a> msdyn_insurance_AsyncOperations

One-To-Many Relationship: [msdyn_insurance msdyn_insurance_AsyncOperations](msdyn_insurance.md#BKMK_msdyn_insurance_AsyncOperations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_insurance`|
|ReferencedAttribute|`msdyn_insuranceid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_insurance`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_inventoryadjustment_AsyncOperations"></a> msdyn_inventoryadjustment_AsyncOperations

One-To-Many Relationship: [msdyn_inventoryadjustment msdyn_inventoryadjustment_AsyncOperations](msdyn_inventoryadjustment.md#BKMK_msdyn_inventoryadjustment_AsyncOperations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_inventoryadjustment`|
|ReferencedAttribute|`msdyn_inventoryadjustmentid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_inventoryadjustment`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_inventoryadjustmentproduct_AsyncOperations"></a> msdyn_inventoryadjustmentproduct_AsyncOperations

One-To-Many Relationship: [msdyn_inventoryadjustmentproduct msdyn_inventoryadjustmentproduct_AsyncOperations](msdyn_inventoryadjustmentproduct.md#BKMK_msdyn_inventoryadjustmentproduct_AsyncOperations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_inventoryadjustmentproduct`|
|ReferencedAttribute|`msdyn_inventoryadjustmentproductid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_inventoryadjustmentproduct`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_inventoryjournal_AsyncOperations"></a> msdyn_inventoryjournal_AsyncOperations

One-To-Many Relationship: [msdyn_inventoryjournal msdyn_inventoryjournal_AsyncOperations](msdyn_inventoryjournal.md#BKMK_msdyn_inventoryjournal_AsyncOperations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_inventoryjournal`|
|ReferencedAttribute|`msdyn_inventoryjournalid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_inventoryjournal`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_inventorytransfer_AsyncOperations"></a> msdyn_inventorytransfer_AsyncOperations

One-To-Many Relationship: [msdyn_inventorytransfer msdyn_inventorytransfer_AsyncOperations](msdyn_inventorytransfer.md#BKMK_msdyn_inventorytransfer_AsyncOperations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_inventorytransfer`|
|ReferencedAttribute|`msdyn_inventorytransferid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_inventorytransfer`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_mobilesource_AsyncOperations"></a> msdyn_mobilesource_AsyncOperations

One-To-Many Relationship: [msdyn_mobilesource msdyn_mobilesource_AsyncOperations](msdyn_mobilesource.md#BKMK_msdyn_mobilesource_AsyncOperations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_mobilesource`|
|ReferencedAttribute|`msdyn_mobilesourceid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_mobilesource`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_nottoexceed_AsyncOperations"></a> msdyn_nottoexceed_AsyncOperations

One-To-Many Relationship: [msdyn_nottoexceed msdyn_nottoexceed_AsyncOperations](msdyn_nottoexceed.md#BKMK_msdyn_nottoexceed_AsyncOperations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_nottoexceed`|
|ReferencedAttribute|`msdyn_nottoexceedid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_nottoexceed`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_orderinvoicingdate_AsyncOperations"></a> msdyn_orderinvoicingdate_AsyncOperations

One-To-Many Relationship: [msdyn_orderinvoicingdate msdyn_orderinvoicingdate_AsyncOperations](msdyn_orderinvoicingdate.md#BKMK_msdyn_orderinvoicingdate_AsyncOperations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_orderinvoicingdate`|
|ReferencedAttribute|`msdyn_orderinvoicingdateid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_orderinvoicingdate`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_orderinvoicingproduct_AsyncOperations"></a> msdyn_orderinvoicingproduct_AsyncOperations

One-To-Many Relationship: [msdyn_orderinvoicingproduct msdyn_orderinvoicingproduct_AsyncOperations](msdyn_orderinvoicingproduct.md#BKMK_msdyn_orderinvoicingproduct_AsyncOperations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_orderinvoicingproduct`|
|ReferencedAttribute|`msdyn_orderinvoicingproductid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_orderinvoicingproduct`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_orderinvoicingsetup_AsyncOperations"></a> msdyn_orderinvoicingsetup_AsyncOperations

One-To-Many Relationship: [msdyn_orderinvoicingsetup msdyn_orderinvoicingsetup_AsyncOperations](msdyn_orderinvoicingsetup.md#BKMK_msdyn_orderinvoicingsetup_AsyncOperations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_orderinvoicingsetup`|
|ReferencedAttribute|`msdyn_orderinvoicingsetupid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_orderinvoicingsetup`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_orderinvoicingsetupdate_AsyncOperations"></a> msdyn_orderinvoicingsetupdate_AsyncOperations

One-To-Many Relationship: [msdyn_orderinvoicingsetupdate msdyn_orderinvoicingsetupdate_AsyncOperations](msdyn_orderinvoicingsetupdate.md#BKMK_msdyn_orderinvoicingsetupdate_AsyncOperations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_orderinvoicingsetupdate`|
|ReferencedAttribute|`msdyn_orderinvoicingsetupdateid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_orderinvoicingsetupdate`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_organizationalunit_AsyncOperations"></a> msdyn_organizationalunit_AsyncOperations

One-To-Many Relationship: [msdyn_organizationalunit msdyn_organizationalunit_AsyncOperations](msdyn_organizationalunit.md#BKMK_msdyn_organizationalunit_AsyncOperations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_organizationalunit`|
|ReferencedAttribute|`msdyn_organizationalunitid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_organizationalunit`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_payment_AsyncOperations"></a> msdyn_payment_AsyncOperations

One-To-Many Relationship: [msdyn_payment msdyn_payment_AsyncOperations](msdyn_payment.md#BKMK_msdyn_payment_AsyncOperations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_payment`|
|ReferencedAttribute|`msdyn_paymentid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_payment`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_paymentdetail_AsyncOperations"></a> msdyn_paymentdetail_AsyncOperations

One-To-Many Relationship: [msdyn_paymentdetail msdyn_paymentdetail_AsyncOperations](msdyn_paymentdetail.md#BKMK_msdyn_paymentdetail_AsyncOperations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_paymentdetail`|
|ReferencedAttribute|`msdyn_paymentdetailid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_paymentdetail`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_paymentmethod_AsyncOperations"></a> msdyn_paymentmethod_AsyncOperations

One-To-Many Relationship: [msdyn_paymentmethod msdyn_paymentmethod_AsyncOperations](msdyn_paymentmethod.md#BKMK_msdyn_paymentmethod_AsyncOperations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_paymentmethod`|
|ReferencedAttribute|`msdyn_paymentmethodid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_paymentmethod`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_paymentterm_AsyncOperations"></a> msdyn_paymentterm_AsyncOperations

One-To-Many Relationship: [msdyn_paymentterm msdyn_paymentterm_AsyncOperations](msdyn_paymentterm.md#BKMK_msdyn_paymentterm_AsyncOperations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_paymentterm`|
|ReferencedAttribute|`msdyn_paymenttermid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_paymentterm`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_postalcode_AsyncOperations"></a> msdyn_postalcode_AsyncOperations

One-To-Many Relationship: [msdyn_postalcode msdyn_postalcode_AsyncOperations](msdyn_postalcode.md#BKMK_msdyn_postalcode_AsyncOperations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_postalcode`|
|ReferencedAttribute|`msdyn_postalcodeid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_postalcode`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_predictworkhourdurationsetting_AsyncOperations"></a> msdyn_predictworkhourdurationsetting_AsyncOperations

One-To-Many Relationship: [msdyn_predictworkhourdurationsetting msdyn_predictworkhourdurationsetting_AsyncOperations](msdyn_predictworkhourdurationsetting.md#BKMK_msdyn_predictworkhourdurationsetting_AsyncOperations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_predictworkhourdurationsetting`|
|ReferencedAttribute|`msdyn_predictworkhourdurationsettingid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_predictworkhourdurationsetting`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_priority_AsyncOperations"></a> msdyn_priority_AsyncOperations

One-To-Many Relationship: [msdyn_priority msdyn_priority_AsyncOperations](msdyn_priority.md#BKMK_msdyn_priority_AsyncOperations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_priority`|
|ReferencedAttribute|`msdyn_priorityid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_priority`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_problematicasset_AsyncOperations"></a> msdyn_problematicasset_AsyncOperations

One-To-Many Relationship: [msdyn_problematicasset msdyn_problematicasset_AsyncOperations](msdyn_problematicasset.md#BKMK_msdyn_problematicasset_AsyncOperations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_problematicasset`|
|ReferencedAttribute|`msdyn_problematicassetid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_problematicasset`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_problematicassetfeedback_AsyncOperations"></a> msdyn_problematicassetfeedback_AsyncOperations

One-To-Many Relationship: [msdyn_problematicassetfeedback msdyn_problematicassetfeedback_AsyncOperations](msdyn_problematicassetfeedback.md#BKMK_msdyn_problematicassetfeedback_AsyncOperations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_problematicassetfeedback`|
|ReferencedAttribute|`msdyn_problematicassetfeedbackid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_problematicassetfeedback`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_productinventory_AsyncOperations"></a> msdyn_productinventory_AsyncOperations

One-To-Many Relationship: [msdyn_productinventory msdyn_productinventory_AsyncOperations](msdyn_productinventory.md#BKMK_msdyn_productinventory_AsyncOperations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_productinventory`|
|ReferencedAttribute|`msdyn_productinventoryid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_productinventory`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_purchaseorder_AsyncOperations"></a> msdyn_purchaseorder_AsyncOperations

One-To-Many Relationship: [msdyn_purchaseorder msdyn_purchaseorder_AsyncOperations](msdyn_purchaseorder.md#BKMK_msdyn_purchaseorder_AsyncOperations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_purchaseorder`|
|ReferencedAttribute|`msdyn_purchaseorderid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_purchaseorder`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_purchaseorderbill_AsyncOperations"></a> msdyn_purchaseorderbill_AsyncOperations

One-To-Many Relationship: [msdyn_purchaseorderbill msdyn_purchaseorderbill_AsyncOperations](msdyn_purchaseorderbill.md#BKMK_msdyn_purchaseorderbill_AsyncOperations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_purchaseorderbill`|
|ReferencedAttribute|`msdyn_purchaseorderbillid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_purchaseorderbill`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_purchaseorderproduct_AsyncOperations"></a> msdyn_purchaseorderproduct_AsyncOperations

One-To-Many Relationship: [msdyn_purchaseorderproduct msdyn_purchaseorderproduct_AsyncOperations](msdyn_purchaseorderproduct.md#BKMK_msdyn_purchaseorderproduct_AsyncOperations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_purchaseorderproduct`|
|ReferencedAttribute|`msdyn_purchaseorderproductid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_purchaseorderproduct`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_purchaseorderreceipt_AsyncOperations"></a> msdyn_purchaseorderreceipt_AsyncOperations

One-To-Many Relationship: [msdyn_purchaseorderreceipt msdyn_purchaseorderreceipt_AsyncOperations](msdyn_purchaseorderreceipt.md#BKMK_msdyn_purchaseorderreceipt_AsyncOperations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_purchaseorderreceipt`|
|ReferencedAttribute|`msdyn_purchaseorderreceiptid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_purchaseorderreceipt`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_purchaseorderreceiptproduct_AsyncOperations"></a> msdyn_purchaseorderreceiptproduct_AsyncOperations

One-To-Many Relationship: [msdyn_purchaseorderreceiptproduct msdyn_purchaseorderreceiptproduct_AsyncOperations](msdyn_purchaseorderreceiptproduct.md#BKMK_msdyn_purchaseorderreceiptproduct_AsyncOperations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_purchaseorderreceiptproduct`|
|ReferencedAttribute|`msdyn_purchaseorderreceiptproductid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_purchaseorderreceiptproduct`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_purchaseordersubstatus_AsyncOperations"></a> msdyn_purchaseordersubstatus_AsyncOperations

One-To-Many Relationship: [msdyn_purchaseordersubstatus msdyn_purchaseordersubstatus_AsyncOperations](msdyn_purchaseordersubstatus.md#BKMK_msdyn_purchaseordersubstatus_AsyncOperations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_purchaseordersubstatus`|
|ReferencedAttribute|`msdyn_purchaseordersubstatusid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_purchaseordersubstatus`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_quotebookingincident_AsyncOperations"></a> msdyn_quotebookingincident_AsyncOperations

One-To-Many Relationship: [msdyn_quotebookingincident msdyn_quotebookingincident_AsyncOperations](msdyn_quotebookingincident.md#BKMK_msdyn_quotebookingincident_AsyncOperations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_quotebookingincident`|
|ReferencedAttribute|`msdyn_quotebookingincidentid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_quotebookingincident`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_quotebookingproduct_AsyncOperations"></a> msdyn_quotebookingproduct_AsyncOperations

One-To-Many Relationship: [msdyn_quotebookingproduct msdyn_quotebookingproduct_AsyncOperations](msdyn_quotebookingproduct.md#BKMK_msdyn_quotebookingproduct_AsyncOperations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_quotebookingproduct`|
|ReferencedAttribute|`msdyn_quotebookingproductid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_quotebookingproduct`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_quotebookingservice_AsyncOperations"></a> msdyn_quotebookingservice_AsyncOperations

One-To-Many Relationship: [msdyn_quotebookingservice msdyn_quotebookingservice_AsyncOperations](msdyn_quotebookingservice.md#BKMK_msdyn_quotebookingservice_AsyncOperations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_quotebookingservice`|
|ReferencedAttribute|`msdyn_quotebookingserviceid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_quotebookingservice`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_quotebookingservicetask_AsyncOperations"></a> msdyn_quotebookingservicetask_AsyncOperations

One-To-Many Relationship: [msdyn_quotebookingservicetask msdyn_quotebookingservicetask_AsyncOperations](msdyn_quotebookingservicetask.md#BKMK_msdyn_quotebookingservicetask_AsyncOperations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_quotebookingservicetask`|
|ReferencedAttribute|`msdyn_quotebookingservicetaskid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_quotebookingservicetask`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_quotebookingsetup_AsyncOperations"></a> msdyn_quotebookingsetup_AsyncOperations

One-To-Many Relationship: [msdyn_quotebookingsetup msdyn_quotebookingsetup_AsyncOperations](msdyn_quotebookingsetup.md#BKMK_msdyn_quotebookingsetup_AsyncOperations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_quotebookingsetup`|
|ReferencedAttribute|`msdyn_quotebookingsetupid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_quotebookingsetup`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_quoteinvoicingproduct_AsyncOperations"></a> msdyn_quoteinvoicingproduct_AsyncOperations

One-To-Many Relationship: [msdyn_quoteinvoicingproduct msdyn_quoteinvoicingproduct_AsyncOperations](msdyn_quoteinvoicingproduct.md#BKMK_msdyn_quoteinvoicingproduct_AsyncOperations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_quoteinvoicingproduct`|
|ReferencedAttribute|`msdyn_quoteinvoicingproductid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_quoteinvoicingproduct`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_quoteinvoicingsetup_AsyncOperations"></a> msdyn_quoteinvoicingsetup_AsyncOperations

One-To-Many Relationship: [msdyn_quoteinvoicingsetup msdyn_quoteinvoicingsetup_AsyncOperations](msdyn_quoteinvoicingsetup.md#BKMK_msdyn_quoteinvoicingsetup_AsyncOperations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_quoteinvoicingsetup`|
|ReferencedAttribute|`msdyn_quoteinvoicingsetupid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_quoteinvoicingsetup`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_requirementchange_AsyncOperations"></a> msdyn_requirementchange_AsyncOperations

One-To-Many Relationship: [msdyn_requirementchange msdyn_requirementchange_AsyncOperations](msdyn_requirementchange.md#BKMK_msdyn_requirementchange_AsyncOperations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_requirementchange`|
|ReferencedAttribute|`msdyn_requirementchangeid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_requirementchange`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_requirementcharacteristic_AsyncOperations"></a> msdyn_requirementcharacteristic_AsyncOperations

One-To-Many Relationship: [msdyn_requirementcharacteristic msdyn_requirementcharacteristic_AsyncOperations](msdyn_requirementcharacteristic.md#BKMK_msdyn_requirementcharacteristic_AsyncOperations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_requirementcharacteristic`|
|ReferencedAttribute|`msdyn_requirementcharacteristicid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_requirementcharacteristic`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_requirementdependency_AsyncOperations"></a> msdyn_requirementdependency_AsyncOperations

One-To-Many Relationship: [msdyn_requirementdependency msdyn_requirementdependency_AsyncOperations](msdyn_requirementdependency.md#BKMK_msdyn_requirementdependency_AsyncOperations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_requirementdependency`|
|ReferencedAttribute|`msdyn_requirementdependencyid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_requirementdependency`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_requirementgroup_AsyncOperations"></a> msdyn_requirementgroup_AsyncOperations

One-To-Many Relationship: [msdyn_requirementgroup msdyn_requirementgroup_AsyncOperations](msdyn_requirementgroup.md#BKMK_msdyn_requirementgroup_AsyncOperations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_requirementgroup`|
|ReferencedAttribute|`msdyn_requirementgroupid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_requirementgroup`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_requirementorganizationunit_AsyncOperations"></a> msdyn_requirementorganizationunit_AsyncOperations

One-To-Many Relationship: [msdyn_requirementorganizationunit msdyn_requirementorganizationunit_AsyncOperations](msdyn_requirementorganizationunit.md#BKMK_msdyn_requirementorganizationunit_AsyncOperations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_requirementorganizationunit`|
|ReferencedAttribute|`msdyn_requirementorganizationunitid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_requirementorganizationunit`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_requirementrelationship_AsyncOperations"></a> msdyn_requirementrelationship_AsyncOperations

One-To-Many Relationship: [msdyn_requirementrelationship msdyn_requirementrelationship_AsyncOperations](msdyn_requirementrelationship.md#BKMK_msdyn_requirementrelationship_AsyncOperations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_requirementrelationship`|
|ReferencedAttribute|`msdyn_requirementrelationshipid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_requirementrelationship`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_requirementresourcecategory_AsyncOperations"></a> msdyn_requirementresourcecategory_AsyncOperations

One-To-Many Relationship: [msdyn_requirementresourcecategory msdyn_requirementresourcecategory_AsyncOperations](msdyn_requirementresourcecategory.md#BKMK_msdyn_requirementresourcecategory_AsyncOperations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_requirementresourcecategory`|
|ReferencedAttribute|`msdyn_requirementresourcecategoryid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_requirementresourcecategory`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_requirementresourcepreference_AsyncOperations"></a> msdyn_requirementresourcepreference_AsyncOperations

One-To-Many Relationship: [msdyn_requirementresourcepreference msdyn_requirementresourcepreference_AsyncOperations](msdyn_requirementresourcepreference.md#BKMK_msdyn_requirementresourcepreference_AsyncOperations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_requirementresourcepreference`|
|ReferencedAttribute|`msdyn_requirementresourcepreferenceid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_requirementresourcepreference`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_requirementstatus_AsyncOperations"></a> msdyn_requirementstatus_AsyncOperations

One-To-Many Relationship: [msdyn_requirementstatus msdyn_requirementstatus_AsyncOperations](msdyn_requirementstatus.md#BKMK_msdyn_requirementstatus_AsyncOperations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_requirementstatus`|
|ReferencedAttribute|`msdyn_requirementstatusid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_requirementstatus`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_resolution_AsyncOperations"></a> msdyn_resolution_AsyncOperations

One-To-Many Relationship: [msdyn_resolution msdyn_resolution_AsyncOperations](msdyn_resolution.md#BKMK_msdyn_resolution_AsyncOperations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_resolution`|
|ReferencedAttribute|`msdyn_resolutionid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_resolution`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_resourcepaytype_AsyncOperations"></a> msdyn_resourcepaytype_AsyncOperations

One-To-Many Relationship: [msdyn_resourcepaytype msdyn_resourcepaytype_AsyncOperations](msdyn_resourcepaytype.md#BKMK_msdyn_resourcepaytype_AsyncOperations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_resourcepaytype`|
|ReferencedAttribute|`msdyn_resourcepaytypeid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_resourcepaytype`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_resourcerequirement_AsyncOperations"></a> msdyn_resourcerequirement_AsyncOperations

One-To-Many Relationship: [msdyn_resourcerequirement msdyn_resourcerequirement_AsyncOperations](msdyn_resourcerequirement.md#BKMK_msdyn_resourcerequirement_AsyncOperations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_resourcerequirement`|
|ReferencedAttribute|`msdyn_resourcerequirementid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_resourcerequirement`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_resourcerequirementdetail_AsyncOperations"></a> msdyn_resourcerequirementdetail_AsyncOperations

One-To-Many Relationship: [msdyn_resourcerequirementdetail msdyn_resourcerequirementdetail_AsyncOperations](msdyn_resourcerequirementdetail.md#BKMK_msdyn_resourcerequirementdetail_AsyncOperations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_resourcerequirementdetail`|
|ReferencedAttribute|`msdyn_resourcerequirementdetailid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_resourcerequirementdetail`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_resourceterritory_AsyncOperations"></a> msdyn_resourceterritory_AsyncOperations

One-To-Many Relationship: [msdyn_resourceterritory msdyn_resourceterritory_AsyncOperations](msdyn_resourceterritory.md#BKMK_msdyn_resourceterritory_AsyncOperations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_resourceterritory`|
|ReferencedAttribute|`msdyn_resourceterritoryid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_resourceterritory`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_rma_AsyncOperations"></a> msdyn_rma_AsyncOperations

One-To-Many Relationship: [msdyn_rma msdyn_rma_AsyncOperations](msdyn_rma.md#BKMK_msdyn_rma_AsyncOperations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_rma`|
|ReferencedAttribute|`msdyn_rmaid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_rma`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_rmaproduct_AsyncOperations"></a> msdyn_rmaproduct_AsyncOperations

One-To-Many Relationship: [msdyn_rmaproduct msdyn_rmaproduct_AsyncOperations](msdyn_rmaproduct.md#BKMK_msdyn_rmaproduct_AsyncOperations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_rmaproduct`|
|ReferencedAttribute|`msdyn_rmaproductid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_rmaproduct`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_rmareceipt_AsyncOperations"></a> msdyn_rmareceipt_AsyncOperations

One-To-Many Relationship: [msdyn_rmareceipt msdyn_rmareceipt_AsyncOperations](msdyn_rmareceipt.md#BKMK_msdyn_rmareceipt_AsyncOperations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_rmareceipt`|
|ReferencedAttribute|`msdyn_rmareceiptid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_rmareceipt`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_rmareceiptproduct_AsyncOperations"></a> msdyn_rmareceiptproduct_AsyncOperations

One-To-Many Relationship: [msdyn_rmareceiptproduct msdyn_rmareceiptproduct_AsyncOperations](msdyn_rmareceiptproduct.md#BKMK_msdyn_rmareceiptproduct_AsyncOperations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_rmareceiptproduct`|
|ReferencedAttribute|`msdyn_rmareceiptproductid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_rmareceiptproduct`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_rmasubstatus_AsyncOperations"></a> msdyn_rmasubstatus_AsyncOperations

One-To-Many Relationship: [msdyn_rmasubstatus msdyn_rmasubstatus_AsyncOperations](msdyn_rmasubstatus.md#BKMK_msdyn_rmasubstatus_AsyncOperations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_rmasubstatus`|
|ReferencedAttribute|`msdyn_rmasubstatusid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_rmasubstatus`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_rtv_AsyncOperations"></a> msdyn_rtv_AsyncOperations

One-To-Many Relationship: [msdyn_rtv msdyn_rtv_AsyncOperations](msdyn_rtv.md#BKMK_msdyn_rtv_AsyncOperations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_rtv`|
|ReferencedAttribute|`msdyn_rtvid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_rtv`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_rtvproduct_AsyncOperations"></a> msdyn_rtvproduct_AsyncOperations

One-To-Many Relationship: [msdyn_rtvproduct msdyn_rtvproduct_AsyncOperations](msdyn_rtvproduct.md#BKMK_msdyn_rtvproduct_AsyncOperations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_rtvproduct`|
|ReferencedAttribute|`msdyn_rtvproductid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_rtvproduct`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_rtvsubstatus_AsyncOperations"></a> msdyn_rtvsubstatus_AsyncOperations

One-To-Many Relationship: [msdyn_rtvsubstatus msdyn_rtvsubstatus_AsyncOperations](msdyn_rtvsubstatus.md#BKMK_msdyn_rtvsubstatus_AsyncOperations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_rtvsubstatus`|
|ReferencedAttribute|`msdyn_rtvsubstatusid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_rtvsubstatus`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_scheduleboardsetting_AsyncOperations"></a> msdyn_scheduleboardsetting_AsyncOperations

One-To-Many Relationship: [msdyn_scheduleboardsetting msdyn_scheduleboardsetting_AsyncOperations](msdyn_scheduleboardsetting.md#BKMK_msdyn_scheduleboardsetting_AsyncOperations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_scheduleboardsetting`|
|ReferencedAttribute|`msdyn_scheduleboardsettingid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_scheduleboardsetting`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_schedulingfeatureflag_AsyncOperations"></a> msdyn_schedulingfeatureflag_AsyncOperations

One-To-Many Relationship: [msdyn_schedulingfeatureflag msdyn_schedulingfeatureflag_AsyncOperations](msdyn_schedulingfeatureflag.md#BKMK_msdyn_schedulingfeatureflag_AsyncOperations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_schedulingfeatureflag`|
|ReferencedAttribute|`msdyn_schedulingfeatureflagid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_schedulingfeatureflag`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_schedulingparameter_AsyncOperations"></a> msdyn_schedulingparameter_AsyncOperations

One-To-Many Relationship: [msdyn_schedulingparameter msdyn_schedulingparameter_AsyncOperations](msdyn_schedulingparameter.md#BKMK_msdyn_schedulingparameter_AsyncOperations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_schedulingparameter`|
|ReferencedAttribute|`msdyn_schedulingparameterid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_schedulingparameter`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_servicetasktype_AsyncOperations"></a> msdyn_servicetasktype_AsyncOperations

One-To-Many Relationship: [msdyn_servicetasktype msdyn_servicetasktype_AsyncOperations](msdyn_servicetasktype.md#BKMK_msdyn_servicetasktype_AsyncOperations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_servicetasktype`|
|ReferencedAttribute|`msdyn_servicetasktypeid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_servicetasktype`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_sessiondata_AsyncOperations"></a> msdyn_sessiondata_AsyncOperations

One-To-Many Relationship: [msdyn_sessiondata msdyn_sessiondata_AsyncOperations](msdyn_sessiondata.md#BKMK_msdyn_sessiondata_AsyncOperations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_sessiondata`|
|ReferencedAttribute|`msdyn_sessiondataid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_sessiondata`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_sessionparticipantdata_AsyncOperations"></a> msdyn_sessionparticipantdata_AsyncOperations

One-To-Many Relationship: [msdyn_sessionparticipantdata msdyn_sessionparticipantdata_AsyncOperations](msdyn_sessionparticipantdata.md#BKMK_msdyn_sessionparticipantdata_AsyncOperations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_sessionparticipantdata`|
|ReferencedAttribute|`msdyn_sessionparticipantdataid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_sessionparticipantdata`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_shipvia_AsyncOperations"></a> msdyn_shipvia_AsyncOperations

One-To-Many Relationship: [msdyn_shipvia msdyn_shipvia_AsyncOperations](msdyn_shipvia.md#BKMK_msdyn_shipvia_AsyncOperations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_shipvia`|
|ReferencedAttribute|`msdyn_shipviaid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_shipvia`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_systemuserschedulersetting_AsyncOperations"></a> msdyn_systemuserschedulersetting_AsyncOperations

One-To-Many Relationship: [msdyn_systemuserschedulersetting msdyn_systemuserschedulersetting_AsyncOperations](msdyn_systemuserschedulersetting.md#BKMK_msdyn_systemuserschedulersetting_AsyncOperations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_systemuserschedulersetting`|
|ReferencedAttribute|`msdyn_systemuserschedulersettingid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_systemuserschedulersetting`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_taxcode_AsyncOperations"></a> msdyn_taxcode_AsyncOperations

One-To-Many Relationship: [msdyn_taxcode msdyn_taxcode_AsyncOperations](msdyn_taxcode.md#BKMK_msdyn_taxcode_AsyncOperations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_taxcode`|
|ReferencedAttribute|`msdyn_taxcodeid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_taxcode`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_taxcodedetail_AsyncOperations"></a> msdyn_taxcodedetail_AsyncOperations

One-To-Many Relationship: [msdyn_taxcodedetail msdyn_taxcodedetail_AsyncOperations](msdyn_taxcodedetail.md#BKMK_msdyn_taxcodedetail_AsyncOperations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_taxcodedetail`|
|ReferencedAttribute|`msdyn_taxcodedetailid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_taxcodedetail`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_timeentry_AsyncOperations"></a> msdyn_timeentry_AsyncOperations

One-To-Many Relationship: [msdyn_timeentry msdyn_timeentry_AsyncOperations](msdyn_timeentry.md#BKMK_msdyn_timeentry_AsyncOperations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_timeentry`|
|ReferencedAttribute|`msdyn_timeentryid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_timeentry`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_timeentrysetting_AsyncOperations"></a> msdyn_timeentrysetting_AsyncOperations

One-To-Many Relationship: [msdyn_timeentrysetting msdyn_timeentrysetting_AsyncOperations](msdyn_timeentrysetting.md#BKMK_msdyn_timeentrysetting_AsyncOperations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_timeentrysetting`|
|ReferencedAttribute|`msdyn_timeentrysettingid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_timeentrysetting`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_timegroup_AsyncOperations"></a> msdyn_timegroup_AsyncOperations

One-To-Many Relationship: [msdyn_timegroup msdyn_timegroup_AsyncOperations](msdyn_timegroup.md#BKMK_msdyn_timegroup_AsyncOperations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_timegroup`|
|ReferencedAttribute|`msdyn_timegroupid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_timegroup`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_timegroupdetail_AsyncOperations"></a> msdyn_timegroupdetail_AsyncOperations

One-To-Many Relationship: [msdyn_timegroupdetail msdyn_timegroupdetail_AsyncOperations](msdyn_timegroupdetail.md#BKMK_msdyn_timegroupdetail_AsyncOperations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_timegroupdetail`|
|ReferencedAttribute|`msdyn_timegroupdetailid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_timegroupdetail`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_timeoffrequest_AsyncOperations"></a> msdyn_timeoffrequest_AsyncOperations

One-To-Many Relationship: [msdyn_timeoffrequest msdyn_timeoffrequest_AsyncOperations](msdyn_timeoffrequest.md#BKMK_msdyn_timeoffrequest_AsyncOperations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_timeoffrequest`|
|ReferencedAttribute|`msdyn_timeoffrequestid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_timeoffrequest`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_trade_AsyncOperations"></a> msdyn_trade_AsyncOperations

One-To-Many Relationship: [msdyn_trade msdyn_trade_AsyncOperations](msdyn_trade.md#BKMK_msdyn_trade_AsyncOperations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_trade`|
|ReferencedAttribute|`msdyn_tradeid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_trade`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_tradecoverage_AsyncOperations"></a> msdyn_tradecoverage_AsyncOperations

One-To-Many Relationship: [msdyn_tradecoverage msdyn_tradecoverage_AsyncOperations](msdyn_tradecoverage.md#BKMK_msdyn_tradecoverage_AsyncOperations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_tradecoverage`|
|ReferencedAttribute|`msdyn_tradecoverageid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_tradecoverage`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_transactionorigin_AsyncOperations"></a> msdyn_transactionorigin_AsyncOperations

One-To-Many Relationship: [msdyn_transactionorigin msdyn_transactionorigin_AsyncOperations](msdyn_transactionorigin.md#BKMK_msdyn_transactionorigin_AsyncOperations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_transactionorigin`|
|ReferencedAttribute|`msdyn_transactionoriginid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_transactionorigin`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_uniquenumber_AsyncOperations"></a> msdyn_uniquenumber_AsyncOperations

One-To-Many Relationship: [msdyn_uniquenumber msdyn_uniquenumber_AsyncOperations](msdyn_uniquenumber.md#BKMK_msdyn_uniquenumber_AsyncOperations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_uniquenumber`|
|ReferencedAttribute|`msdyn_uniquenumberid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_uniquenumber`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_warehouse_AsyncOperations"></a> msdyn_warehouse_AsyncOperations

One-To-Many Relationship: [msdyn_warehouse msdyn_warehouse_AsyncOperations](msdyn_warehouse.md#BKMK_msdyn_warehouse_AsyncOperations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_warehouse`|
|ReferencedAttribute|`msdyn_warehouseid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_warehouse`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_workhourtemplate_AsyncOperations"></a> msdyn_workhourtemplate_AsyncOperations

One-To-Many Relationship: [msdyn_workhourtemplate msdyn_workhourtemplate_AsyncOperations](msdyn_workhourtemplate.md#BKMK_msdyn_workhourtemplate_AsyncOperations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_workhourtemplate`|
|ReferencedAttribute|`msdyn_workhourtemplateid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_workhourtemplate`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_workorder_AsyncOperations"></a> msdyn_workorder_AsyncOperations

One-To-Many Relationship: [msdyn_workorder msdyn_workorder_AsyncOperations](msdyn_workorder.md#BKMK_msdyn_workorder_AsyncOperations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_workorder`|
|ReferencedAttribute|`msdyn_workorderid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_workorder`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_workorderincident_AsyncOperations"></a> msdyn_workorderincident_AsyncOperations

One-To-Many Relationship: [msdyn_workorderincident msdyn_workorderincident_AsyncOperations](msdyn_workorderincident.md#BKMK_msdyn_workorderincident_AsyncOperations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_workorderincident`|
|ReferencedAttribute|`msdyn_workorderincidentid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_workorderincident`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_workordernte_AsyncOperations"></a> msdyn_workordernte_AsyncOperations

One-To-Many Relationship: [msdyn_workordernte msdyn_workordernte_AsyncOperations](msdyn_workordernte.md#BKMK_msdyn_workordernte_AsyncOperations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_workordernte`|
|ReferencedAttribute|`msdyn_workordernteid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_workordernte`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_workorderproduct_AsyncOperations"></a> msdyn_workorderproduct_AsyncOperations

One-To-Many Relationship: [msdyn_workorderproduct msdyn_workorderproduct_AsyncOperations](msdyn_workorderproduct.md#BKMK_msdyn_workorderproduct_AsyncOperations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_workorderproduct`|
|ReferencedAttribute|`msdyn_workorderproductid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_workorderproduct`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_workorderresolution_AsyncOperations"></a> msdyn_workorderresolution_AsyncOperations

One-To-Many Relationship: [msdyn_workorderresolution msdyn_workorderresolution_AsyncOperations](msdyn_workorderresolution.md#BKMK_msdyn_workorderresolution_AsyncOperations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_workorderresolution`|
|ReferencedAttribute|`msdyn_workorderresolutionid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_workorderresolution`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_workorderresourcerestriction_AsyncOperations"></a> msdyn_workorderresourcerestriction_AsyncOperations

One-To-Many Relationship: [msdyn_workorderresourcerestriction msdyn_workorderresourcerestriction_AsyncOperations](msdyn_workorderresourcerestriction.md#BKMK_msdyn_workorderresourcerestriction_AsyncOperations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_workorderresourcerestriction`|
|ReferencedAttribute|`msdyn_workorderresourcerestrictionid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_workorderresourcerestriction`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_workorderservice_AsyncOperations"></a> msdyn_workorderservice_AsyncOperations

One-To-Many Relationship: [msdyn_workorderservice msdyn_workorderservice_AsyncOperations](msdyn_workorderservice.md#BKMK_msdyn_workorderservice_AsyncOperations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_workorderservice`|
|ReferencedAttribute|`msdyn_workorderserviceid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_workorderservice`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_workorderservicetask_AsyncOperations"></a> msdyn_workorderservicetask_AsyncOperations

One-To-Many Relationship: [msdyn_workorderservicetask msdyn_workorderservicetask_AsyncOperations](msdyn_workorderservicetask.md#BKMK_msdyn_workorderservicetask_AsyncOperations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_workorderservicetask`|
|ReferencedAttribute|`msdyn_workorderservicetaskid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_workorderservicetask`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_workordersubstatus_AsyncOperations"></a> msdyn_workordersubstatus_AsyncOperations

One-To-Many Relationship: [msdyn_workordersubstatus msdyn_workordersubstatus_AsyncOperations](msdyn_workordersubstatus.md#BKMK_msdyn_workordersubstatus_AsyncOperations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_workordersubstatus`|
|ReferencedAttribute|`msdyn_workordersubstatusid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_workordersubstatus`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_workordertype_AsyncOperations"></a> msdyn_workordertype_AsyncOperations

One-To-Many Relationship: [msdyn_workordertype msdyn_workordertype_AsyncOperations](msdyn_workordertype.md#BKMK_msdyn_workordertype_AsyncOperations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_workordertype`|
|ReferencedAttribute|`msdyn_workordertypeid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_workordertype`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|



### See also

[Dataverse table/entity reference](../about-entity-reference.md)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   
<xref:Microsoft.Dynamics.CRM.asyncoperation?displayProperty=fullName>
