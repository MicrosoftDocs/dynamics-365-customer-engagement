---
title: "Sync Error (SyncError) table/entity reference (Microsoft Dynamics 365 Field Service)"
description: "Includes schema information and supported messages for the Sync Error (SyncError) table/entity with Microsoft Dynamics 365 Field Service."
ms.date: 08/26/2024
ms.service: powerapps
ms.topic: reference
author: m-hartmann
ms.author: mhart
search.audienceType: 
  - developer
---

# Sync Error (SyncError) table/entity reference (Microsoft Dynamics 365 Field Service)

Failure reason and other detailed information for a record that failed to sync.

> [!NOTE]
> The Microsoft Dynamics 365 Field Service Sync Error (SyncError) table extends the [Microsoft Dynamics 365 Sync Error (SyncError) table](/dynamics365/developer/entities/syncerror).



## Customized columns/attributes

Microsoft Dynamics 365 Field Service modifies the definition of columns/attributes defined in other solutions. Listed by **SchemaName**.

### <a name="BKMK_RegardingObjectId"></a> RegardingObjectId

Changes from [RegardingObjectId (Microsoft Dataverse)](/power-apps/developer/data-platform/reference/entities/syncerror#BKMK_RegardingObjectId)

|Property|Value|
|---|---|
|Targets|msdyn_3dmodel|


## Many-to-One relationships

These relationships are many-to-one. Listed by **SchemaName**.

- [msdyn_3dmodel_SyncErrors](#BKMK_msdyn_3dmodel_SyncErrors)
- [msdyn_actual_SyncErrors](#BKMK_msdyn_actual_SyncErrors)
- [msdyn_agreement_SyncErrors](#BKMK_msdyn_agreement_SyncErrors)
- [msdyn_agreementbookingdate_SyncErrors](#BKMK_msdyn_agreementbookingdate_SyncErrors)
- [msdyn_agreementbookingincident_SyncErrors](#BKMK_msdyn_agreementbookingincident_SyncErrors)
- [msdyn_agreementbookingproduct_SyncErrors](#BKMK_msdyn_agreementbookingproduct_SyncErrors)
- [msdyn_agreementbookingservice_SyncErrors](#BKMK_msdyn_agreementbookingservice_SyncErrors)
- [msdyn_agreementbookingservicetask_SyncErrors](#BKMK_msdyn_agreementbookingservicetask_SyncErrors)
- [msdyn_agreementbookingsetup_SyncErrors](#BKMK_msdyn_agreementbookingsetup_SyncErrors)
- [msdyn_agreementinvoicedate_SyncErrors](#BKMK_msdyn_agreementinvoicedate_SyncErrors)
- [msdyn_agreementinvoiceproduct_SyncErrors](#BKMK_msdyn_agreementinvoiceproduct_SyncErrors)
- [msdyn_agreementinvoicesetup_SyncErrors](#BKMK_msdyn_agreementinvoicesetup_SyncErrors)
- [msdyn_agreementsubstatus_SyncErrors](#BKMK_msdyn_agreementsubstatus_SyncErrors)
- [msdyn_assetsuggestionssetting_SyncErrors](#BKMK_msdyn_assetsuggestionssetting_SyncErrors)
- [msdyn_bookableresourceassociation_SyncErrors](#BKMK_msdyn_bookableresourceassociation_SyncErrors)
- [msdyn_bookableresourcebookingquicknote_SyncErrors](#BKMK_msdyn_bookableresourcebookingquicknote_SyncErrors)
- [msdyn_bookingalert_SyncErrors](#BKMK_msdyn_bookingalert_SyncErrors)
- [msdyn_bookingalertstatus_SyncErrors](#BKMK_msdyn_bookingalertstatus_SyncErrors)
- [msdyn_bookingchange_SyncErrors](#BKMK_msdyn_bookingchange_SyncErrors)
- [msdyn_bookingjournal_SyncErrors](#BKMK_msdyn_bookingjournal_SyncErrors)
- [msdyn_bookingrule_SyncErrors](#BKMK_msdyn_bookingrule_SyncErrors)
- [msdyn_bookingsetupmetadata_SyncErrors](#BKMK_msdyn_bookingsetupmetadata_SyncErrors)
- [msdyn_bookingtimestamp_SyncErrors](#BKMK_msdyn_bookingtimestamp_SyncErrors)
- [msdyn_bpf_2c5fe86acc8b414b8322ae571000c799_SyncErrors](#BKMK_msdyn_bpf_2c5fe86acc8b414b8322ae571000c799_SyncErrors)
- [msdyn_bpf_477c16f59170487b8b4dc895c5dcd09b_SyncErrors](#BKMK_msdyn_bpf_477c16f59170487b8b4dc895c5dcd09b_SyncErrors)
- [msdyn_bpf_989e9b1857e24af18787d5143b67523b_SyncErrors](#BKMK_msdyn_bpf_989e9b1857e24af18787d5143b67523b_SyncErrors)
- [msdyn_bpf_baa0a411a239410cb8bded8b5fdd88e3_SyncErrors](#BKMK_msdyn_bpf_baa0a411a239410cb8bded8b5fdd88e3_SyncErrors)
- [msdyn_bpf_d3d97bac8c294105840e99e37a9d1c39_SyncErrors](#BKMK_msdyn_bpf_d3d97bac8c294105840e99e37a9d1c39_SyncErrors)
- [msdyn_businessclosure_SyncErrors](#BKMK_msdyn_businessclosure_SyncErrors)
- [msdyn_clientextension_SyncErrors](#BKMK_msdyn_clientextension_SyncErrors)
- [msdyn_configuration_SyncErrors](#BKMK_msdyn_configuration_SyncErrors)
- [msdyn_consoleapplicationsessiontemplate_SyncErrors](#BKMK_msdyn_consoleapplicationsessiontemplate_SyncErrors)
- [msdyn_dataanalyticsreport_fs_SyncErrors](#BKMK_msdyn_dataanalyticsreport_fs_SyncErrors)
- [msdyn_dataanalyticsreport_fspredictrs_SyncErrors](#BKMK_msdyn_dataanalyticsreport_fspredictrs_SyncErrors)
- [msdyn_dataanalyticsreport_fspredictwhd_SyncErrors](#BKMK_msdyn_dataanalyticsreport_fspredictwhd_SyncErrors)
- [msdyn_entitlementapplication_SyncErrors](#BKMK_msdyn_entitlementapplication_SyncErrors)
- [msdyn_entityconfiguration_SyncErrors](#BKMK_msdyn_entityconfiguration_SyncErrors)
- [msdyn_fieldservicepricelistitem_SyncErrors](#BKMK_msdyn_fieldservicepricelistitem_SyncErrors)
- [msdyn_fieldservicesetting_SyncErrors](#BKMK_msdyn_fieldservicesetting_SyncErrors)
- [msdyn_fieldserviceslaconfiguration_SyncErrors](#BKMK_msdyn_fieldserviceslaconfiguration_SyncErrors)
- [msdyn_fieldservicesummaryconfiguration_SyncErrors](#BKMK_msdyn_fieldservicesummaryconfiguration_SyncErrors)
- [msdyn_fieldservicesystemjob_SyncErrors](#BKMK_msdyn_fieldservicesystemjob_SyncErrors)
- [msdyn_flwconfiguration_SyncErrors](#BKMK_msdyn_flwconfiguration_SyncErrors)
- [msdyn_geofence_SyncErrors](#BKMK_msdyn_geofence_SyncErrors)
- [msdyn_geofenceevent_SyncErrors](#BKMK_msdyn_geofenceevent_SyncErrors)
- [msdyn_geofencingsettings_SyncErrors](#BKMK_msdyn_geofencingsettings_SyncErrors)
- [msdyn_geolocationsettings_SyncErrors](#BKMK_msdyn_geolocationsettings_SyncErrors)
- [msdyn_geolocationtracking_SyncErrors](#BKMK_msdyn_geolocationtracking_SyncErrors)
- [msdyn_incidenttype_requirementgroup_SyncErrors](#BKMK_msdyn_incidenttype_requirementgroup_SyncErrors)
- [msdyn_incidenttype_SyncErrors](#BKMK_msdyn_incidenttype_SyncErrors)
- [msdyn_incidenttypecharacteristic_SyncErrors](#BKMK_msdyn_incidenttypecharacteristic_SyncErrors)
- [msdyn_incidenttypeproduct_SyncErrors](#BKMK_msdyn_incidenttypeproduct_SyncErrors)
- [msdyn_incidenttyperecommendationresult_SyncErrors](#BKMK_msdyn_incidenttyperecommendationresult_SyncErrors)
- [msdyn_incidenttyperecommendationrunhistory_SyncErrors](#BKMK_msdyn_incidenttyperecommendationrunhistory_SyncErrors)
- [msdyn_incidenttyperesolution_SyncErrors](#BKMK_msdyn_incidenttyperesolution_SyncErrors)
- [msdyn_incidenttypeservice_SyncErrors](#BKMK_msdyn_incidenttypeservice_SyncErrors)
- [msdyn_incidenttypeservicetask_SyncErrors](#BKMK_msdyn_incidenttypeservicetask_SyncErrors)
- [msdyn_incidenttypessetup_SyncErrors](#BKMK_msdyn_incidenttypessetup_SyncErrors)
- [msdyn_inspection_SyncErrors](#BKMK_msdyn_inspection_SyncErrors)
- [msdyn_inspectionattachment_SyncErrors](#BKMK_msdyn_inspectionattachment_SyncErrors)
- [msdyn_inspectiondefinition_SyncErrors](#BKMK_msdyn_inspectiondefinition_SyncErrors)
- [msdyn_inspectioninstance_SyncErrors](#BKMK_msdyn_inspectioninstance_SyncErrors)
- [msdyn_inspectionresponse_SyncErrors](#BKMK_msdyn_inspectionresponse_SyncErrors)
- [msdyn_insurance_SyncErrors](#BKMK_msdyn_insurance_SyncErrors)
- [msdyn_inventoryadjustment_SyncErrors](#BKMK_msdyn_inventoryadjustment_SyncErrors)
- [msdyn_inventoryadjustmentproduct_SyncErrors](#BKMK_msdyn_inventoryadjustmentproduct_SyncErrors)
- [msdyn_inventoryjournal_SyncErrors](#BKMK_msdyn_inventoryjournal_SyncErrors)
- [msdyn_inventorytransfer_SyncErrors](#BKMK_msdyn_inventorytransfer_SyncErrors)
- [msdyn_mobilesource_SyncErrors](#BKMK_msdyn_mobilesource_SyncErrors)
- [msdyn_nottoexceed_SyncErrors](#BKMK_msdyn_nottoexceed_SyncErrors)
- [msdyn_orderinvoicingdate_SyncErrors](#BKMK_msdyn_orderinvoicingdate_SyncErrors)
- [msdyn_orderinvoicingproduct_SyncErrors](#BKMK_msdyn_orderinvoicingproduct_SyncErrors)
- [msdyn_orderinvoicingsetup_SyncErrors](#BKMK_msdyn_orderinvoicingsetup_SyncErrors)
- [msdyn_orderinvoicingsetupdate_SyncErrors](#BKMK_msdyn_orderinvoicingsetupdate_SyncErrors)
- [msdyn_organizationalunit_SyncErrors](#BKMK_msdyn_organizationalunit_SyncErrors)
- [msdyn_payment_SyncErrors](#BKMK_msdyn_payment_SyncErrors)
- [msdyn_paymentdetail_SyncErrors](#BKMK_msdyn_paymentdetail_SyncErrors)
- [msdyn_paymentmethod_SyncErrors](#BKMK_msdyn_paymentmethod_SyncErrors)
- [msdyn_paymentterm_SyncErrors](#BKMK_msdyn_paymentterm_SyncErrors)
- [msdyn_postalcode_SyncErrors](#BKMK_msdyn_postalcode_SyncErrors)
- [msdyn_predictworkhourdurationsetting_SyncErrors](#BKMK_msdyn_predictworkhourdurationsetting_SyncErrors)
- [msdyn_priority_SyncErrors](#BKMK_msdyn_priority_SyncErrors)
- [msdyn_problematicasset_SyncErrors](#BKMK_msdyn_problematicasset_SyncErrors)
- [msdyn_problematicassetfeedback_SyncErrors](#BKMK_msdyn_problematicassetfeedback_SyncErrors)
- [msdyn_productinventory_SyncErrors](#BKMK_msdyn_productinventory_SyncErrors)
- [msdyn_purchaseorder_SyncErrors](#BKMK_msdyn_purchaseorder_SyncErrors)
- [msdyn_purchaseorderbill_SyncErrors](#BKMK_msdyn_purchaseorderbill_SyncErrors)
- [msdyn_purchaseorderproduct_SyncErrors](#BKMK_msdyn_purchaseorderproduct_SyncErrors)
- [msdyn_purchaseorderreceipt_SyncErrors](#BKMK_msdyn_purchaseorderreceipt_SyncErrors)
- [msdyn_purchaseorderreceiptproduct_SyncErrors](#BKMK_msdyn_purchaseorderreceiptproduct_SyncErrors)
- [msdyn_purchaseordersubstatus_SyncErrors](#BKMK_msdyn_purchaseordersubstatus_SyncErrors)
- [msdyn_quotebookingincident_SyncErrors](#BKMK_msdyn_quotebookingincident_SyncErrors)
- [msdyn_quotebookingproduct_SyncErrors](#BKMK_msdyn_quotebookingproduct_SyncErrors)
- [msdyn_quotebookingservice_SyncErrors](#BKMK_msdyn_quotebookingservice_SyncErrors)
- [msdyn_quotebookingservicetask_SyncErrors](#BKMK_msdyn_quotebookingservicetask_SyncErrors)
- [msdyn_quotebookingsetup_SyncErrors](#BKMK_msdyn_quotebookingsetup_SyncErrors)
- [msdyn_quoteinvoicingproduct_SyncErrors](#BKMK_msdyn_quoteinvoicingproduct_SyncErrors)
- [msdyn_quoteinvoicingsetup_SyncErrors](#BKMK_msdyn_quoteinvoicingsetup_SyncErrors)
- [msdyn_requirementchange_SyncErrors](#BKMK_msdyn_requirementchange_SyncErrors)
- [msdyn_requirementcharacteristic_SyncErrors](#BKMK_msdyn_requirementcharacteristic_SyncErrors)
- [msdyn_requirementdependency_SyncErrors](#BKMK_msdyn_requirementdependency_SyncErrors)
- [msdyn_requirementgroup_SyncErrors](#BKMK_msdyn_requirementgroup_SyncErrors)
- [msdyn_requirementorganizationunit_SyncErrors](#BKMK_msdyn_requirementorganizationunit_SyncErrors)
- [msdyn_requirementrelationship_SyncErrors](#BKMK_msdyn_requirementrelationship_SyncErrors)
- [msdyn_requirementresourcecategory_SyncErrors](#BKMK_msdyn_requirementresourcecategory_SyncErrors)
- [msdyn_requirementresourcepreference_SyncErrors](#BKMK_msdyn_requirementresourcepreference_SyncErrors)
- [msdyn_requirementstatus_SyncErrors](#BKMK_msdyn_requirementstatus_SyncErrors)
- [msdyn_resolution_SyncErrors](#BKMK_msdyn_resolution_SyncErrors)
- [msdyn_resourcepaytype_SyncErrors](#BKMK_msdyn_resourcepaytype_SyncErrors)
- [msdyn_resourcerequirement_SyncErrors](#BKMK_msdyn_resourcerequirement_SyncErrors)
- [msdyn_resourcerequirementdetail_SyncErrors](#BKMK_msdyn_resourcerequirementdetail_SyncErrors)
- [msdyn_resourceterritory_SyncErrors](#BKMK_msdyn_resourceterritory_SyncErrors)
- [msdyn_rma_SyncErrors](#BKMK_msdyn_rma_SyncErrors)
- [msdyn_rmaproduct_SyncErrors](#BKMK_msdyn_rmaproduct_SyncErrors)
- [msdyn_rmareceipt_SyncErrors](#BKMK_msdyn_rmareceipt_SyncErrors)
- [msdyn_rmareceiptproduct_SyncErrors](#BKMK_msdyn_rmareceiptproduct_SyncErrors)
- [msdyn_rmasubstatus_SyncErrors](#BKMK_msdyn_rmasubstatus_SyncErrors)
- [msdyn_rtv_SyncErrors](#BKMK_msdyn_rtv_SyncErrors)
- [msdyn_rtvproduct_SyncErrors](#BKMK_msdyn_rtvproduct_SyncErrors)
- [msdyn_rtvsubstatus_SyncErrors](#BKMK_msdyn_rtvsubstatus_SyncErrors)
- [msdyn_scheduleboardsetting_SyncErrors](#BKMK_msdyn_scheduleboardsetting_SyncErrors)
- [msdyn_schedulingfeatureflag_SyncErrors](#BKMK_msdyn_schedulingfeatureflag_SyncErrors)
- [msdyn_schedulingparameter_SyncErrors](#BKMK_msdyn_schedulingparameter_SyncErrors)
- [msdyn_servicetasktype_SyncErrors](#BKMK_msdyn_servicetasktype_SyncErrors)
- [msdyn_sessiondata_SyncErrors](#BKMK_msdyn_sessiondata_SyncErrors)
- [msdyn_sessionparticipantdata_SyncErrors](#BKMK_msdyn_sessionparticipantdata_SyncErrors)
- [msdyn_shipvia_SyncErrors](#BKMK_msdyn_shipvia_SyncErrors)
- [msdyn_systemuserschedulersetting_SyncErrors](#BKMK_msdyn_systemuserschedulersetting_SyncErrors)
- [msdyn_taxcode_SyncErrors](#BKMK_msdyn_taxcode_SyncErrors)
- [msdyn_taxcodedetail_SyncErrors](#BKMK_msdyn_taxcodedetail_SyncErrors)
- [msdyn_timeentry_SyncErrors](#BKMK_msdyn_timeentry_SyncErrors)
- [msdyn_timeentrysetting_SyncErrors](#BKMK_msdyn_timeentrysetting_SyncErrors)
- [msdyn_timegroup_SyncErrors](#BKMK_msdyn_timegroup_SyncErrors)
- [msdyn_timegroupdetail_SyncErrors](#BKMK_msdyn_timegroupdetail_SyncErrors)
- [msdyn_timeoffrequest_SyncErrors](#BKMK_msdyn_timeoffrequest_SyncErrors)
- [msdyn_trade_SyncErrors](#BKMK_msdyn_trade_SyncErrors)
- [msdyn_tradecoverage_SyncErrors](#BKMK_msdyn_tradecoverage_SyncErrors)
- [msdyn_transactionorigin_SyncErrors](#BKMK_msdyn_transactionorigin_SyncErrors)
- [msdyn_uniquenumber_SyncErrors](#BKMK_msdyn_uniquenumber_SyncErrors)
- [msdyn_warehouse_SyncErrors](#BKMK_msdyn_warehouse_SyncErrors)
- [msdyn_workhourtemplate_SyncErrors](#BKMK_msdyn_workhourtemplate_SyncErrors)
- [msdyn_workorder_SyncErrors](#BKMK_msdyn_workorder_SyncErrors)
- [msdyn_workorderincident_SyncErrors](#BKMK_msdyn_workorderincident_SyncErrors)
- [msdyn_workordernte_SyncErrors](#BKMK_msdyn_workordernte_SyncErrors)
- [msdyn_workorderproduct_SyncErrors](#BKMK_msdyn_workorderproduct_SyncErrors)
- [msdyn_workorderresolution_SyncErrors](#BKMK_msdyn_workorderresolution_SyncErrors)
- [msdyn_workorderresourcerestriction_SyncErrors](#BKMK_msdyn_workorderresourcerestriction_SyncErrors)
- [msdyn_workorderservice_SyncErrors](#BKMK_msdyn_workorderservice_SyncErrors)
- [msdyn_workorderservicetask_SyncErrors](#BKMK_msdyn_workorderservicetask_SyncErrors)
- [msdyn_workordersubstatus_SyncErrors](#BKMK_msdyn_workordersubstatus_SyncErrors)
- [msdyn_workordertype_SyncErrors](#BKMK_msdyn_workordertype_SyncErrors)

### <a name="BKMK_msdyn_3dmodel_SyncErrors"></a> msdyn_3dmodel_SyncErrors

One-To-Many Relationship: [msdyn_3dmodel msdyn_3dmodel_SyncErrors](msdyn_3dmodel.md#BKMK_msdyn_3dmodel_SyncErrors)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_3dmodel`|
|ReferencedAttribute|`msdyn_3dmodelid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_3dmodel`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_actual_SyncErrors"></a> msdyn_actual_SyncErrors

One-To-Many Relationship: [msdyn_actual msdyn_actual_SyncErrors](msdyn_actual.md#BKMK_msdyn_actual_SyncErrors)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_actual`|
|ReferencedAttribute|`msdyn_actualid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_actual`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_agreement_SyncErrors"></a> msdyn_agreement_SyncErrors

One-To-Many Relationship: [msdyn_agreement msdyn_agreement_SyncErrors](msdyn_agreement.md#BKMK_msdyn_agreement_SyncErrors)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_agreement`|
|ReferencedAttribute|`msdyn_agreementid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_agreement`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_agreementbookingdate_SyncErrors"></a> msdyn_agreementbookingdate_SyncErrors

One-To-Many Relationship: [msdyn_agreementbookingdate msdyn_agreementbookingdate_SyncErrors](msdyn_agreementbookingdate.md#BKMK_msdyn_agreementbookingdate_SyncErrors)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_agreementbookingdate`|
|ReferencedAttribute|`msdyn_agreementbookingdateid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_agreementbookingdate`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_agreementbookingincident_SyncErrors"></a> msdyn_agreementbookingincident_SyncErrors

One-To-Many Relationship: [msdyn_agreementbookingincident msdyn_agreementbookingincident_SyncErrors](msdyn_agreementbookingincident.md#BKMK_msdyn_agreementbookingincident_SyncErrors)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_agreementbookingincident`|
|ReferencedAttribute|`msdyn_agreementbookingincidentid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_agreementbookingincident`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_agreementbookingproduct_SyncErrors"></a> msdyn_agreementbookingproduct_SyncErrors

One-To-Many Relationship: [msdyn_agreementbookingproduct msdyn_agreementbookingproduct_SyncErrors](msdyn_agreementbookingproduct.md#BKMK_msdyn_agreementbookingproduct_SyncErrors)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_agreementbookingproduct`|
|ReferencedAttribute|`msdyn_agreementbookingproductid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_agreementbookingproduct`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_agreementbookingservice_SyncErrors"></a> msdyn_agreementbookingservice_SyncErrors

One-To-Many Relationship: [msdyn_agreementbookingservice msdyn_agreementbookingservice_SyncErrors](msdyn_agreementbookingservice.md#BKMK_msdyn_agreementbookingservice_SyncErrors)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_agreementbookingservice`|
|ReferencedAttribute|`msdyn_agreementbookingserviceid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_agreementbookingservice`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_agreementbookingservicetask_SyncErrors"></a> msdyn_agreementbookingservicetask_SyncErrors

One-To-Many Relationship: [msdyn_agreementbookingservicetask msdyn_agreementbookingservicetask_SyncErrors](msdyn_agreementbookingservicetask.md#BKMK_msdyn_agreementbookingservicetask_SyncErrors)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_agreementbookingservicetask`|
|ReferencedAttribute|`msdyn_agreementbookingservicetaskid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_agreementbookingservicetask`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_agreementbookingsetup_SyncErrors"></a> msdyn_agreementbookingsetup_SyncErrors

One-To-Many Relationship: [msdyn_agreementbookingsetup msdyn_agreementbookingsetup_SyncErrors](msdyn_agreementbookingsetup.md#BKMK_msdyn_agreementbookingsetup_SyncErrors)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_agreementbookingsetup`|
|ReferencedAttribute|`msdyn_agreementbookingsetupid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_agreementbookingsetup`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_agreementinvoicedate_SyncErrors"></a> msdyn_agreementinvoicedate_SyncErrors

One-To-Many Relationship: [msdyn_agreementinvoicedate msdyn_agreementinvoicedate_SyncErrors](msdyn_agreementinvoicedate.md#BKMK_msdyn_agreementinvoicedate_SyncErrors)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_agreementinvoicedate`|
|ReferencedAttribute|`msdyn_agreementinvoicedateid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_agreementinvoicedate`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_agreementinvoiceproduct_SyncErrors"></a> msdyn_agreementinvoiceproduct_SyncErrors

One-To-Many Relationship: [msdyn_agreementinvoiceproduct msdyn_agreementinvoiceproduct_SyncErrors](msdyn_agreementinvoiceproduct.md#BKMK_msdyn_agreementinvoiceproduct_SyncErrors)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_agreementinvoiceproduct`|
|ReferencedAttribute|`msdyn_agreementinvoiceproductid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_agreementinvoiceproduct`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_agreementinvoicesetup_SyncErrors"></a> msdyn_agreementinvoicesetup_SyncErrors

One-To-Many Relationship: [msdyn_agreementinvoicesetup msdyn_agreementinvoicesetup_SyncErrors](msdyn_agreementinvoicesetup.md#BKMK_msdyn_agreementinvoicesetup_SyncErrors)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_agreementinvoicesetup`|
|ReferencedAttribute|`msdyn_agreementinvoicesetupid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_agreementinvoicesetup`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_agreementsubstatus_SyncErrors"></a> msdyn_agreementsubstatus_SyncErrors

One-To-Many Relationship: [msdyn_agreementsubstatus msdyn_agreementsubstatus_SyncErrors](msdyn_agreementsubstatus.md#BKMK_msdyn_agreementsubstatus_SyncErrors)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_agreementsubstatus`|
|ReferencedAttribute|`msdyn_agreementsubstatusid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_agreementsubstatus`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_assetsuggestionssetting_SyncErrors"></a> msdyn_assetsuggestionssetting_SyncErrors

One-To-Many Relationship: [msdyn_assetsuggestionssetting msdyn_assetsuggestionssetting_SyncErrors](msdyn_assetsuggestionssetting.md#BKMK_msdyn_assetsuggestionssetting_SyncErrors)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_assetsuggestionssetting`|
|ReferencedAttribute|`msdyn_assetsuggestionssettingid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_assetsuggestionssetting`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_bookableresourceassociation_SyncErrors"></a> msdyn_bookableresourceassociation_SyncErrors

One-To-Many Relationship: [msdyn_bookableresourceassociation msdyn_bookableresourceassociation_SyncErrors](msdyn_bookableresourceassociation.md#BKMK_msdyn_bookableresourceassociation_SyncErrors)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_bookableresourceassociation`|
|ReferencedAttribute|`msdyn_bookableresourceassociationid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_bookableresourceassociation`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_bookableresourcebookingquicknote_SyncErrors"></a> msdyn_bookableresourcebookingquicknote_SyncErrors

One-To-Many Relationship: [msdyn_bookableresourcebookingquicknote msdyn_bookableresourcebookingquicknote_SyncErrors](msdyn_bookableresourcebookingquicknote.md#BKMK_msdyn_bookableresourcebookingquicknote_SyncErrors)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_bookableresourcebookingquicknote`|
|ReferencedAttribute|`msdyn_bookableresourcebookingquicknoteid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_bookableresourcebookingquicknote`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_bookingalert_SyncErrors"></a> msdyn_bookingalert_SyncErrors

One-To-Many Relationship: [msdyn_bookingalert msdyn_bookingalert_SyncErrors](msdyn_bookingalert.md#BKMK_msdyn_bookingalert_SyncErrors)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_bookingalert`|
|ReferencedAttribute|`activityid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_bookingalert`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_bookingalertstatus_SyncErrors"></a> msdyn_bookingalertstatus_SyncErrors

One-To-Many Relationship: [msdyn_bookingalertstatus msdyn_bookingalertstatus_SyncErrors](msdyn_bookingalertstatus.md#BKMK_msdyn_bookingalertstatus_SyncErrors)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_bookingalertstatus`|
|ReferencedAttribute|`msdyn_bookingalertstatusid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_bookingalertstatus`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_bookingchange_SyncErrors"></a> msdyn_bookingchange_SyncErrors

One-To-Many Relationship: [msdyn_bookingchange msdyn_bookingchange_SyncErrors](msdyn_bookingchange.md#BKMK_msdyn_bookingchange_SyncErrors)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_bookingchange`|
|ReferencedAttribute|`msdyn_bookingchangeid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_bookingchange`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_bookingjournal_SyncErrors"></a> msdyn_bookingjournal_SyncErrors

One-To-Many Relationship: [msdyn_bookingjournal msdyn_bookingjournal_SyncErrors](msdyn_bookingjournal.md#BKMK_msdyn_bookingjournal_SyncErrors)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_bookingjournal`|
|ReferencedAttribute|`msdyn_bookingjournalid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_bookingjournal`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_bookingrule_SyncErrors"></a> msdyn_bookingrule_SyncErrors

One-To-Many Relationship: [msdyn_bookingrule msdyn_bookingrule_SyncErrors](msdyn_bookingrule.md#BKMK_msdyn_bookingrule_SyncErrors)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_bookingrule`|
|ReferencedAttribute|`msdyn_bookingruleid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_bookingrule`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_bookingsetupmetadata_SyncErrors"></a> msdyn_bookingsetupmetadata_SyncErrors

One-To-Many Relationship: [msdyn_bookingsetupmetadata msdyn_bookingsetupmetadata_SyncErrors](msdyn_bookingsetupmetadata.md#BKMK_msdyn_bookingsetupmetadata_SyncErrors)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_bookingsetupmetadata`|
|ReferencedAttribute|`msdyn_bookingsetupmetadataid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_bookingsetupmetadata`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_bookingtimestamp_SyncErrors"></a> msdyn_bookingtimestamp_SyncErrors

One-To-Many Relationship: [msdyn_bookingtimestamp msdyn_bookingtimestamp_SyncErrors](msdyn_bookingtimestamp.md#BKMK_msdyn_bookingtimestamp_SyncErrors)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_bookingtimestamp`|
|ReferencedAttribute|`msdyn_bookingtimestampid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_bookingtimestamp`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_bpf_2c5fe86acc8b414b8322ae571000c799_SyncErrors"></a> msdyn_bpf_2c5fe86acc8b414b8322ae571000c799_SyncErrors

One-To-Many Relationship: [msdyn_bpf_2c5fe86acc8b414b8322ae571000c799 msdyn_bpf_2c5fe86acc8b414b8322ae571000c799_SyncErrors](msdyn_bpf_2c5fe86acc8b414b8322ae571000c799.md#BKMK_msdyn_bpf_2c5fe86acc8b414b8322ae571000c799_SyncErrors)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_bpf_2c5fe86acc8b414b8322ae571000c799`|
|ReferencedAttribute|`businessprocessflowinstanceid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_bpf_2c5fe86acc8b414b8322ae571000c799`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_bpf_477c16f59170487b8b4dc895c5dcd09b_SyncErrors"></a> msdyn_bpf_477c16f59170487b8b4dc895c5dcd09b_SyncErrors

One-To-Many Relationship: [msdyn_bpf_477c16f59170487b8b4dc895c5dcd09b msdyn_bpf_477c16f59170487b8b4dc895c5dcd09b_SyncErrors](msdyn_bpf_477c16f59170487b8b4dc895c5dcd09b.md#BKMK_msdyn_bpf_477c16f59170487b8b4dc895c5dcd09b_SyncErrors)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_bpf_477c16f59170487b8b4dc895c5dcd09b`|
|ReferencedAttribute|`businessprocessflowinstanceid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_bpf_477c16f59170487b8b4dc895c5dcd09b`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_bpf_989e9b1857e24af18787d5143b67523b_SyncErrors"></a> msdyn_bpf_989e9b1857e24af18787d5143b67523b_SyncErrors

One-To-Many Relationship: [msdyn_bpf_989e9b1857e24af18787d5143b67523b msdyn_bpf_989e9b1857e24af18787d5143b67523b_SyncErrors](msdyn_bpf_989e9b1857e24af18787d5143b67523b.md#BKMK_msdyn_bpf_989e9b1857e24af18787d5143b67523b_SyncErrors)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_bpf_989e9b1857e24af18787d5143b67523b`|
|ReferencedAttribute|`businessprocessflowinstanceid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_bpf_989e9b1857e24af18787d5143b67523b`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_bpf_baa0a411a239410cb8bded8b5fdd88e3_SyncErrors"></a> msdyn_bpf_baa0a411a239410cb8bded8b5fdd88e3_SyncErrors

One-To-Many Relationship: [msdyn_bpf_baa0a411a239410cb8bded8b5fdd88e3 msdyn_bpf_baa0a411a239410cb8bded8b5fdd88e3_SyncErrors](msdyn_bpf_baa0a411a239410cb8bded8b5fdd88e3.md#BKMK_msdyn_bpf_baa0a411a239410cb8bded8b5fdd88e3_SyncErrors)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_bpf_baa0a411a239410cb8bded8b5fdd88e3`|
|ReferencedAttribute|`businessprocessflowinstanceid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_bpf_baa0a411a239410cb8bded8b5fdd88e3`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_bpf_d3d97bac8c294105840e99e37a9d1c39_SyncErrors"></a> msdyn_bpf_d3d97bac8c294105840e99e37a9d1c39_SyncErrors

One-To-Many Relationship: [msdyn_bpf_d3d97bac8c294105840e99e37a9d1c39 msdyn_bpf_d3d97bac8c294105840e99e37a9d1c39_SyncErrors](msdyn_bpf_d3d97bac8c294105840e99e37a9d1c39.md#BKMK_msdyn_bpf_d3d97bac8c294105840e99e37a9d1c39_SyncErrors)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_bpf_d3d97bac8c294105840e99e37a9d1c39`|
|ReferencedAttribute|`businessprocessflowinstanceid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_bpf_d3d97bac8c294105840e99e37a9d1c39`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_businessclosure_SyncErrors"></a> msdyn_businessclosure_SyncErrors

One-To-Many Relationship: [msdyn_businessclosure msdyn_businessclosure_SyncErrors](msdyn_businessclosure.md#BKMK_msdyn_businessclosure_SyncErrors)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_businessclosure`|
|ReferencedAttribute|`msdyn_businessclosureid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_businessclosure`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_clientextension_SyncErrors"></a> msdyn_clientextension_SyncErrors

One-To-Many Relationship: [msdyn_clientextension msdyn_clientextension_SyncErrors](msdyn_clientextension.md#BKMK_msdyn_clientextension_SyncErrors)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_clientextension`|
|ReferencedAttribute|`msdyn_clientextensionid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_clientextension`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_configuration_SyncErrors"></a> msdyn_configuration_SyncErrors

One-To-Many Relationship: [msdyn_configuration msdyn_configuration_SyncErrors](msdyn_configuration.md#BKMK_msdyn_configuration_SyncErrors)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_configuration`|
|ReferencedAttribute|`msdyn_configurationid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_configuration`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_consoleapplicationsessiontemplate_SyncErrors"></a> msdyn_consoleapplicationsessiontemplate_SyncErrors

One-To-Many Relationship: [msdyn_consoleapplicationsessiontemplate msdyn_consoleapplicationsessiontemplate_SyncErrors](msdyn_consoleapplicationsessiontemplate.md#BKMK_msdyn_consoleapplicationsessiontemplate_SyncErrors)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_consoleapplicationsessiontemplate`|
|ReferencedAttribute|`msdyn_consoleapplicationsessiontemplateid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_consoleapplicationsessiontemplate`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_dataanalyticsreport_fs_SyncErrors"></a> msdyn_dataanalyticsreport_fs_SyncErrors

One-To-Many Relationship: [msdyn_dataanalyticsreport_fs msdyn_dataanalyticsreport_fs_SyncErrors](msdyn_dataanalyticsreport_fs.md#BKMK_msdyn_dataanalyticsreport_fs_SyncErrors)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_dataanalyticsreport_fs`|
|ReferencedAttribute|`msdyn_dataanalyticsreport_fsid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_dataanalyticsreport_fs`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_dataanalyticsreport_fspredictrs_SyncErrors"></a> msdyn_dataanalyticsreport_fspredictrs_SyncErrors

One-To-Many Relationship: [msdyn_dataanalyticsreport_fspredictrs msdyn_dataanalyticsreport_fspredictrs_SyncErrors](msdyn_dataanalyticsreport_fspredictrs.md#BKMK_msdyn_dataanalyticsreport_fspredictrs_SyncErrors)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_dataanalyticsreport_fspredictrs`|
|ReferencedAttribute|`msdyn_dataanalyticsreport_fspredictrsid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_dataanalyticsreport_fspredictrs`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_dataanalyticsreport_fspredictwhd_SyncErrors"></a> msdyn_dataanalyticsreport_fspredictwhd_SyncErrors

One-To-Many Relationship: [msdyn_dataanalyticsreport_fspredictwhd msdyn_dataanalyticsreport_fspredictwhd_SyncErrors](msdyn_dataanalyticsreport_fspredictwhd.md#BKMK_msdyn_dataanalyticsreport_fspredictwhd_SyncErrors)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_dataanalyticsreport_fspredictwhd`|
|ReferencedAttribute|`msdyn_dataanalyticsreport_fspredictwhdid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_dataanalyticsreport_fspredictwhd`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_entitlementapplication_SyncErrors"></a> msdyn_entitlementapplication_SyncErrors

One-To-Many Relationship: [msdyn_entitlementapplication msdyn_entitlementapplication_SyncErrors](msdyn_entitlementapplication.md#BKMK_msdyn_entitlementapplication_SyncErrors)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_entitlementapplication`|
|ReferencedAttribute|`msdyn_entitlementapplicationid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_entitlementapplication`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_entityconfiguration_SyncErrors"></a> msdyn_entityconfiguration_SyncErrors

One-To-Many Relationship: [msdyn_entityconfiguration msdyn_entityconfiguration_SyncErrors](msdyn_entityconfiguration.md#BKMK_msdyn_entityconfiguration_SyncErrors)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_entityconfiguration`|
|ReferencedAttribute|`msdyn_entityconfigurationid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_entityconfiguration`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_fieldservicepricelistitem_SyncErrors"></a> msdyn_fieldservicepricelistitem_SyncErrors

One-To-Many Relationship: [msdyn_fieldservicepricelistitem msdyn_fieldservicepricelistitem_SyncErrors](msdyn_fieldservicepricelistitem.md#BKMK_msdyn_fieldservicepricelistitem_SyncErrors)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_fieldservicepricelistitem`|
|ReferencedAttribute|`msdyn_fieldservicepricelistitemid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_fieldservicepricelistitem`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_fieldservicesetting_SyncErrors"></a> msdyn_fieldservicesetting_SyncErrors

One-To-Many Relationship: [msdyn_fieldservicesetting msdyn_fieldservicesetting_SyncErrors](msdyn_fieldservicesetting.md#BKMK_msdyn_fieldservicesetting_SyncErrors)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_fieldservicesetting`|
|ReferencedAttribute|`msdyn_fieldservicesettingid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_fieldservicesetting`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_fieldserviceslaconfiguration_SyncErrors"></a> msdyn_fieldserviceslaconfiguration_SyncErrors

One-To-Many Relationship: [msdyn_fieldserviceslaconfiguration msdyn_fieldserviceslaconfiguration_SyncErrors](msdyn_fieldserviceslaconfiguration.md#BKMK_msdyn_fieldserviceslaconfiguration_SyncErrors)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_fieldserviceslaconfiguration`|
|ReferencedAttribute|`msdyn_fieldserviceslaconfigurationid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_fieldserviceslaconfiguration`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_fieldservicesummaryconfiguration_SyncErrors"></a> msdyn_fieldservicesummaryconfiguration_SyncErrors

One-To-Many Relationship: [msdyn_fieldservicesummaryconfiguration msdyn_fieldservicesummaryconfiguration_SyncErrors](msdyn_fieldservicesummaryconfiguration.md#BKMK_msdyn_fieldservicesummaryconfiguration_SyncErrors)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_fieldservicesummaryconfiguration`|
|ReferencedAttribute|`msdyn_fieldservicesummaryconfigurationid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_fieldservicesummaryconfiguration`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_fieldservicesystemjob_SyncErrors"></a> msdyn_fieldservicesystemjob_SyncErrors

One-To-Many Relationship: [msdyn_fieldservicesystemjob msdyn_fieldservicesystemjob_SyncErrors](msdyn_fieldservicesystemjob.md#BKMK_msdyn_fieldservicesystemjob_SyncErrors)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_fieldservicesystemjob`|
|ReferencedAttribute|`msdyn_fieldservicesystemjobid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_fieldservicesystemjob`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_flwconfiguration_SyncErrors"></a> msdyn_flwconfiguration_SyncErrors

One-To-Many Relationship: [msdyn_flwconfiguration msdyn_flwconfiguration_SyncErrors](msdyn_flwconfiguration.md#BKMK_msdyn_flwconfiguration_SyncErrors)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_flwconfiguration`|
|ReferencedAttribute|`msdyn_flwconfigurationid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_flwconfiguration`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_geofence_SyncErrors"></a> msdyn_geofence_SyncErrors

One-To-Many Relationship: [msdyn_geofence msdyn_geofence_SyncErrors](msdyn_geofence.md#BKMK_msdyn_geofence_SyncErrors)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_geofence`|
|ReferencedAttribute|`msdyn_geofenceid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_geofence`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_geofenceevent_SyncErrors"></a> msdyn_geofenceevent_SyncErrors

One-To-Many Relationship: [msdyn_geofenceevent msdyn_geofenceevent_SyncErrors](msdyn_geofenceevent.md#BKMK_msdyn_geofenceevent_SyncErrors)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_geofenceevent`|
|ReferencedAttribute|`msdyn_geofenceeventid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_geofenceevent`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_geofencingsettings_SyncErrors"></a> msdyn_geofencingsettings_SyncErrors

One-To-Many Relationship: [msdyn_geofencingsettings msdyn_geofencingsettings_SyncErrors](msdyn_geofencingsettings.md#BKMK_msdyn_geofencingsettings_SyncErrors)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_geofencingsettings`|
|ReferencedAttribute|`msdyn_geofencingsettingsid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_geofencingsettings`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_geolocationsettings_SyncErrors"></a> msdyn_geolocationsettings_SyncErrors

One-To-Many Relationship: [msdyn_geolocationsettings msdyn_geolocationsettings_SyncErrors](msdyn_geolocationsettings.md#BKMK_msdyn_geolocationsettings_SyncErrors)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_geolocationsettings`|
|ReferencedAttribute|`msdyn_geolocationsettingsid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_geolocationsettings`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_geolocationtracking_SyncErrors"></a> msdyn_geolocationtracking_SyncErrors

One-To-Many Relationship: [msdyn_geolocationtracking msdyn_geolocationtracking_SyncErrors](msdyn_geolocationtracking.md#BKMK_msdyn_geolocationtracking_SyncErrors)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_geolocationtracking`|
|ReferencedAttribute|`msdyn_geolocationtrackingid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_geolocationtracking`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_incidenttype_requirementgroup_SyncErrors"></a> msdyn_incidenttype_requirementgroup_SyncErrors

One-To-Many Relationship: [msdyn_incidenttype_requirementgroup msdyn_incidenttype_requirementgroup_SyncErrors](msdyn_incidenttype_requirementgroup.md#BKMK_msdyn_incidenttype_requirementgroup_SyncErrors)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_incidenttype_requirementgroup`|
|ReferencedAttribute|`msdyn_incidenttype_requirementgroupid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_incidenttype_requirementgroup`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_incidenttype_SyncErrors"></a> msdyn_incidenttype_SyncErrors

One-To-Many Relationship: [msdyn_incidenttype msdyn_incidenttype_SyncErrors](msdyn_incidenttype.md#BKMK_msdyn_incidenttype_SyncErrors)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_incidenttype`|
|ReferencedAttribute|`msdyn_incidenttypeid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_incidenttype`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_incidenttypecharacteristic_SyncErrors"></a> msdyn_incidenttypecharacteristic_SyncErrors

One-To-Many Relationship: [msdyn_incidenttypecharacteristic msdyn_incidenttypecharacteristic_SyncErrors](msdyn_incidenttypecharacteristic.md#BKMK_msdyn_incidenttypecharacteristic_SyncErrors)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_incidenttypecharacteristic`|
|ReferencedAttribute|`msdyn_incidenttypecharacteristicid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_incidenttypecharacteristic`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_incidenttypeproduct_SyncErrors"></a> msdyn_incidenttypeproduct_SyncErrors

One-To-Many Relationship: [msdyn_incidenttypeproduct msdyn_incidenttypeproduct_SyncErrors](msdyn_incidenttypeproduct.md#BKMK_msdyn_incidenttypeproduct_SyncErrors)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_incidenttypeproduct`|
|ReferencedAttribute|`msdyn_incidenttypeproductid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_incidenttypeproduct`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_incidenttyperecommendationresult_SyncErrors"></a> msdyn_incidenttyperecommendationresult_SyncErrors

One-To-Many Relationship: [msdyn_incidenttyperecommendationresult msdyn_incidenttyperecommendationresult_SyncErrors](msdyn_incidenttyperecommendationresult.md#BKMK_msdyn_incidenttyperecommendationresult_SyncErrors)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_incidenttyperecommendationresult`|
|ReferencedAttribute|`msdyn_incidenttyperecommendationresultid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_incidenttyperecommendationresult`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_incidenttyperecommendationrunhistory_SyncErrors"></a> msdyn_incidenttyperecommendationrunhistory_SyncErrors

One-To-Many Relationship: [msdyn_incidenttyperecommendationrunhistory msdyn_incidenttyperecommendationrunhistory_SyncErrors](msdyn_incidenttyperecommendationrunhistory.md#BKMK_msdyn_incidenttyperecommendationrunhistory_SyncErrors)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_incidenttyperecommendationrunhistory`|
|ReferencedAttribute|`msdyn_incidenttyperecommendationrunhistoryid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_incidenttyperecommendationrunhistory`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_incidenttyperesolution_SyncErrors"></a> msdyn_incidenttyperesolution_SyncErrors

One-To-Many Relationship: [msdyn_incidenttyperesolution msdyn_incidenttyperesolution_SyncErrors](msdyn_incidenttyperesolution.md#BKMK_msdyn_incidenttyperesolution_SyncErrors)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_incidenttyperesolution`|
|ReferencedAttribute|`msdyn_incidenttyperesolutionid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_incidenttyperesolution`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_incidenttypeservice_SyncErrors"></a> msdyn_incidenttypeservice_SyncErrors

One-To-Many Relationship: [msdyn_incidenttypeservice msdyn_incidenttypeservice_SyncErrors](msdyn_incidenttypeservice.md#BKMK_msdyn_incidenttypeservice_SyncErrors)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_incidenttypeservice`|
|ReferencedAttribute|`msdyn_incidenttypeserviceid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_incidenttypeservice`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_incidenttypeservicetask_SyncErrors"></a> msdyn_incidenttypeservicetask_SyncErrors

One-To-Many Relationship: [msdyn_incidenttypeservicetask msdyn_incidenttypeservicetask_SyncErrors](msdyn_incidenttypeservicetask.md#BKMK_msdyn_incidenttypeservicetask_SyncErrors)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_incidenttypeservicetask`|
|ReferencedAttribute|`msdyn_incidenttypeservicetaskid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_incidenttypeservicetask`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_incidenttypessetup_SyncErrors"></a> msdyn_incidenttypessetup_SyncErrors

One-To-Many Relationship: [msdyn_incidenttypessetup msdyn_incidenttypessetup_SyncErrors](msdyn_incidenttypessetup.md#BKMK_msdyn_incidenttypessetup_SyncErrors)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_incidenttypessetup`|
|ReferencedAttribute|`msdyn_incidenttypessetupid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_incidenttypessetup`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_inspection_SyncErrors"></a> msdyn_inspection_SyncErrors

One-To-Many Relationship: [msdyn_inspection msdyn_inspection_SyncErrors](msdyn_inspection.md#BKMK_msdyn_inspection_SyncErrors)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_inspection`|
|ReferencedAttribute|`msdyn_inspectionid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_inspection`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_inspectionattachment_SyncErrors"></a> msdyn_inspectionattachment_SyncErrors

One-To-Many Relationship: [msdyn_inspectionattachment msdyn_inspectionattachment_SyncErrors](msdyn_inspectionattachment.md#BKMK_msdyn_inspectionattachment_SyncErrors)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_inspectionattachment`|
|ReferencedAttribute|`msdyn_inspectionattachmentid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_inspectionattachment`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_inspectiondefinition_SyncErrors"></a> msdyn_inspectiondefinition_SyncErrors

One-To-Many Relationship: [msdyn_inspectiondefinition msdyn_inspectiondefinition_SyncErrors](msdyn_inspectiondefinition.md#BKMK_msdyn_inspectiondefinition_SyncErrors)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_inspectiondefinition`|
|ReferencedAttribute|`msdyn_inspectiondefinitionid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_inspectiondefinition`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_inspectioninstance_SyncErrors"></a> msdyn_inspectioninstance_SyncErrors

One-To-Many Relationship: [msdyn_inspectioninstance msdyn_inspectioninstance_SyncErrors](msdyn_inspectioninstance.md#BKMK_msdyn_inspectioninstance_SyncErrors)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_inspectioninstance`|
|ReferencedAttribute|`msdyn_inspectioninstanceid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_inspectioninstance`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_inspectionresponse_SyncErrors"></a> msdyn_inspectionresponse_SyncErrors

One-To-Many Relationship: [msdyn_inspectionresponse msdyn_inspectionresponse_SyncErrors](msdyn_inspectionresponse.md#BKMK_msdyn_inspectionresponse_SyncErrors)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_inspectionresponse`|
|ReferencedAttribute|`msdyn_inspectionresponseid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_inspectionresponse`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_insurance_SyncErrors"></a> msdyn_insurance_SyncErrors

One-To-Many Relationship: [msdyn_insurance msdyn_insurance_SyncErrors](msdyn_insurance.md#BKMK_msdyn_insurance_SyncErrors)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_insurance`|
|ReferencedAttribute|`msdyn_insuranceid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_insurance`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_inventoryadjustment_SyncErrors"></a> msdyn_inventoryadjustment_SyncErrors

One-To-Many Relationship: [msdyn_inventoryadjustment msdyn_inventoryadjustment_SyncErrors](msdyn_inventoryadjustment.md#BKMK_msdyn_inventoryadjustment_SyncErrors)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_inventoryadjustment`|
|ReferencedAttribute|`msdyn_inventoryadjustmentid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_inventoryadjustment`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_inventoryadjustmentproduct_SyncErrors"></a> msdyn_inventoryadjustmentproduct_SyncErrors

One-To-Many Relationship: [msdyn_inventoryadjustmentproduct msdyn_inventoryadjustmentproduct_SyncErrors](msdyn_inventoryadjustmentproduct.md#BKMK_msdyn_inventoryadjustmentproduct_SyncErrors)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_inventoryadjustmentproduct`|
|ReferencedAttribute|`msdyn_inventoryadjustmentproductid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_inventoryadjustmentproduct`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_inventoryjournal_SyncErrors"></a> msdyn_inventoryjournal_SyncErrors

One-To-Many Relationship: [msdyn_inventoryjournal msdyn_inventoryjournal_SyncErrors](msdyn_inventoryjournal.md#BKMK_msdyn_inventoryjournal_SyncErrors)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_inventoryjournal`|
|ReferencedAttribute|`msdyn_inventoryjournalid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_inventoryjournal`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_inventorytransfer_SyncErrors"></a> msdyn_inventorytransfer_SyncErrors

One-To-Many Relationship: [msdyn_inventorytransfer msdyn_inventorytransfer_SyncErrors](msdyn_inventorytransfer.md#BKMK_msdyn_inventorytransfer_SyncErrors)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_inventorytransfer`|
|ReferencedAttribute|`msdyn_inventorytransferid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_inventorytransfer`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_mobilesource_SyncErrors"></a> msdyn_mobilesource_SyncErrors

One-To-Many Relationship: [msdyn_mobilesource msdyn_mobilesource_SyncErrors](msdyn_mobilesource.md#BKMK_msdyn_mobilesource_SyncErrors)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_mobilesource`|
|ReferencedAttribute|`msdyn_mobilesourceid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_mobilesource`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_nottoexceed_SyncErrors"></a> msdyn_nottoexceed_SyncErrors

One-To-Many Relationship: [msdyn_nottoexceed msdyn_nottoexceed_SyncErrors](msdyn_nottoexceed.md#BKMK_msdyn_nottoexceed_SyncErrors)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_nottoexceed`|
|ReferencedAttribute|`msdyn_nottoexceedid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_nottoexceed`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_orderinvoicingdate_SyncErrors"></a> msdyn_orderinvoicingdate_SyncErrors

One-To-Many Relationship: [msdyn_orderinvoicingdate msdyn_orderinvoicingdate_SyncErrors](msdyn_orderinvoicingdate.md#BKMK_msdyn_orderinvoicingdate_SyncErrors)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_orderinvoicingdate`|
|ReferencedAttribute|`msdyn_orderinvoicingdateid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_orderinvoicingdate`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_orderinvoicingproduct_SyncErrors"></a> msdyn_orderinvoicingproduct_SyncErrors

One-To-Many Relationship: [msdyn_orderinvoicingproduct msdyn_orderinvoicingproduct_SyncErrors](msdyn_orderinvoicingproduct.md#BKMK_msdyn_orderinvoicingproduct_SyncErrors)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_orderinvoicingproduct`|
|ReferencedAttribute|`msdyn_orderinvoicingproductid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_orderinvoicingproduct`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_orderinvoicingsetup_SyncErrors"></a> msdyn_orderinvoicingsetup_SyncErrors

One-To-Many Relationship: [msdyn_orderinvoicingsetup msdyn_orderinvoicingsetup_SyncErrors](msdyn_orderinvoicingsetup.md#BKMK_msdyn_orderinvoicingsetup_SyncErrors)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_orderinvoicingsetup`|
|ReferencedAttribute|`msdyn_orderinvoicingsetupid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_orderinvoicingsetup`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_orderinvoicingsetupdate_SyncErrors"></a> msdyn_orderinvoicingsetupdate_SyncErrors

One-To-Many Relationship: [msdyn_orderinvoicingsetupdate msdyn_orderinvoicingsetupdate_SyncErrors](msdyn_orderinvoicingsetupdate.md#BKMK_msdyn_orderinvoicingsetupdate_SyncErrors)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_orderinvoicingsetupdate`|
|ReferencedAttribute|`msdyn_orderinvoicingsetupdateid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_orderinvoicingsetupdate`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_organizationalunit_SyncErrors"></a> msdyn_organizationalunit_SyncErrors

One-To-Many Relationship: [msdyn_organizationalunit msdyn_organizationalunit_SyncErrors](msdyn_organizationalunit.md#BKMK_msdyn_organizationalunit_SyncErrors)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_organizationalunit`|
|ReferencedAttribute|`msdyn_organizationalunitid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_organizationalunit`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_payment_SyncErrors"></a> msdyn_payment_SyncErrors

One-To-Many Relationship: [msdyn_payment msdyn_payment_SyncErrors](msdyn_payment.md#BKMK_msdyn_payment_SyncErrors)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_payment`|
|ReferencedAttribute|`msdyn_paymentid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_payment`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_paymentdetail_SyncErrors"></a> msdyn_paymentdetail_SyncErrors

One-To-Many Relationship: [msdyn_paymentdetail msdyn_paymentdetail_SyncErrors](msdyn_paymentdetail.md#BKMK_msdyn_paymentdetail_SyncErrors)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_paymentdetail`|
|ReferencedAttribute|`msdyn_paymentdetailid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_paymentdetail`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_paymentmethod_SyncErrors"></a> msdyn_paymentmethod_SyncErrors

One-To-Many Relationship: [msdyn_paymentmethod msdyn_paymentmethod_SyncErrors](msdyn_paymentmethod.md#BKMK_msdyn_paymentmethod_SyncErrors)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_paymentmethod`|
|ReferencedAttribute|`msdyn_paymentmethodid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_paymentmethod`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_paymentterm_SyncErrors"></a> msdyn_paymentterm_SyncErrors

One-To-Many Relationship: [msdyn_paymentterm msdyn_paymentterm_SyncErrors](msdyn_paymentterm.md#BKMK_msdyn_paymentterm_SyncErrors)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_paymentterm`|
|ReferencedAttribute|`msdyn_paymenttermid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_paymentterm`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_postalcode_SyncErrors"></a> msdyn_postalcode_SyncErrors

One-To-Many Relationship: [msdyn_postalcode msdyn_postalcode_SyncErrors](msdyn_postalcode.md#BKMK_msdyn_postalcode_SyncErrors)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_postalcode`|
|ReferencedAttribute|`msdyn_postalcodeid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_postalcode`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_predictworkhourdurationsetting_SyncErrors"></a> msdyn_predictworkhourdurationsetting_SyncErrors

One-To-Many Relationship: [msdyn_predictworkhourdurationsetting msdyn_predictworkhourdurationsetting_SyncErrors](msdyn_predictworkhourdurationsetting.md#BKMK_msdyn_predictworkhourdurationsetting_SyncErrors)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_predictworkhourdurationsetting`|
|ReferencedAttribute|`msdyn_predictworkhourdurationsettingid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_predictworkhourdurationsetting`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_priority_SyncErrors"></a> msdyn_priority_SyncErrors

One-To-Many Relationship: [msdyn_priority msdyn_priority_SyncErrors](msdyn_priority.md#BKMK_msdyn_priority_SyncErrors)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_priority`|
|ReferencedAttribute|`msdyn_priorityid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_priority`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_problematicasset_SyncErrors"></a> msdyn_problematicasset_SyncErrors

One-To-Many Relationship: [msdyn_problematicasset msdyn_problematicasset_SyncErrors](msdyn_problematicasset.md#BKMK_msdyn_problematicasset_SyncErrors)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_problematicasset`|
|ReferencedAttribute|`msdyn_problematicassetid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_problematicasset`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_problematicassetfeedback_SyncErrors"></a> msdyn_problematicassetfeedback_SyncErrors

One-To-Many Relationship: [msdyn_problematicassetfeedback msdyn_problematicassetfeedback_SyncErrors](msdyn_problematicassetfeedback.md#BKMK_msdyn_problematicassetfeedback_SyncErrors)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_problematicassetfeedback`|
|ReferencedAttribute|`msdyn_problematicassetfeedbackid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_problematicassetfeedback`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_productinventory_SyncErrors"></a> msdyn_productinventory_SyncErrors

One-To-Many Relationship: [msdyn_productinventory msdyn_productinventory_SyncErrors](msdyn_productinventory.md#BKMK_msdyn_productinventory_SyncErrors)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_productinventory`|
|ReferencedAttribute|`msdyn_productinventoryid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_productinventory`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_purchaseorder_SyncErrors"></a> msdyn_purchaseorder_SyncErrors

One-To-Many Relationship: [msdyn_purchaseorder msdyn_purchaseorder_SyncErrors](msdyn_purchaseorder.md#BKMK_msdyn_purchaseorder_SyncErrors)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_purchaseorder`|
|ReferencedAttribute|`msdyn_purchaseorderid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_purchaseorder`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_purchaseorderbill_SyncErrors"></a> msdyn_purchaseorderbill_SyncErrors

One-To-Many Relationship: [msdyn_purchaseorderbill msdyn_purchaseorderbill_SyncErrors](msdyn_purchaseorderbill.md#BKMK_msdyn_purchaseorderbill_SyncErrors)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_purchaseorderbill`|
|ReferencedAttribute|`msdyn_purchaseorderbillid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_purchaseorderbill`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_purchaseorderproduct_SyncErrors"></a> msdyn_purchaseorderproduct_SyncErrors

One-To-Many Relationship: [msdyn_purchaseorderproduct msdyn_purchaseorderproduct_SyncErrors](msdyn_purchaseorderproduct.md#BKMK_msdyn_purchaseorderproduct_SyncErrors)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_purchaseorderproduct`|
|ReferencedAttribute|`msdyn_purchaseorderproductid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_purchaseorderproduct`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_purchaseorderreceipt_SyncErrors"></a> msdyn_purchaseorderreceipt_SyncErrors

One-To-Many Relationship: [msdyn_purchaseorderreceipt msdyn_purchaseorderreceipt_SyncErrors](msdyn_purchaseorderreceipt.md#BKMK_msdyn_purchaseorderreceipt_SyncErrors)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_purchaseorderreceipt`|
|ReferencedAttribute|`msdyn_purchaseorderreceiptid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_purchaseorderreceipt`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_purchaseorderreceiptproduct_SyncErrors"></a> msdyn_purchaseorderreceiptproduct_SyncErrors

One-To-Many Relationship: [msdyn_purchaseorderreceiptproduct msdyn_purchaseorderreceiptproduct_SyncErrors](msdyn_purchaseorderreceiptproduct.md#BKMK_msdyn_purchaseorderreceiptproduct_SyncErrors)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_purchaseorderreceiptproduct`|
|ReferencedAttribute|`msdyn_purchaseorderreceiptproductid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_purchaseorderreceiptproduct`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_purchaseordersubstatus_SyncErrors"></a> msdyn_purchaseordersubstatus_SyncErrors

One-To-Many Relationship: [msdyn_purchaseordersubstatus msdyn_purchaseordersubstatus_SyncErrors](msdyn_purchaseordersubstatus.md#BKMK_msdyn_purchaseordersubstatus_SyncErrors)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_purchaseordersubstatus`|
|ReferencedAttribute|`msdyn_purchaseordersubstatusid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_purchaseordersubstatus`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_quotebookingincident_SyncErrors"></a> msdyn_quotebookingincident_SyncErrors

One-To-Many Relationship: [msdyn_quotebookingincident msdyn_quotebookingincident_SyncErrors](msdyn_quotebookingincident.md#BKMK_msdyn_quotebookingincident_SyncErrors)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_quotebookingincident`|
|ReferencedAttribute|`msdyn_quotebookingincidentid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_quotebookingincident`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_quotebookingproduct_SyncErrors"></a> msdyn_quotebookingproduct_SyncErrors

One-To-Many Relationship: [msdyn_quotebookingproduct msdyn_quotebookingproduct_SyncErrors](msdyn_quotebookingproduct.md#BKMK_msdyn_quotebookingproduct_SyncErrors)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_quotebookingproduct`|
|ReferencedAttribute|`msdyn_quotebookingproductid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_quotebookingproduct`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_quotebookingservice_SyncErrors"></a> msdyn_quotebookingservice_SyncErrors

One-To-Many Relationship: [msdyn_quotebookingservice msdyn_quotebookingservice_SyncErrors](msdyn_quotebookingservice.md#BKMK_msdyn_quotebookingservice_SyncErrors)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_quotebookingservice`|
|ReferencedAttribute|`msdyn_quotebookingserviceid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_quotebookingservice`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_quotebookingservicetask_SyncErrors"></a> msdyn_quotebookingservicetask_SyncErrors

One-To-Many Relationship: [msdyn_quotebookingservicetask msdyn_quotebookingservicetask_SyncErrors](msdyn_quotebookingservicetask.md#BKMK_msdyn_quotebookingservicetask_SyncErrors)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_quotebookingservicetask`|
|ReferencedAttribute|`msdyn_quotebookingservicetaskid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_quotebookingservicetask`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_quotebookingsetup_SyncErrors"></a> msdyn_quotebookingsetup_SyncErrors

One-To-Many Relationship: [msdyn_quotebookingsetup msdyn_quotebookingsetup_SyncErrors](msdyn_quotebookingsetup.md#BKMK_msdyn_quotebookingsetup_SyncErrors)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_quotebookingsetup`|
|ReferencedAttribute|`msdyn_quotebookingsetupid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_quotebookingsetup`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_quoteinvoicingproduct_SyncErrors"></a> msdyn_quoteinvoicingproduct_SyncErrors

One-To-Many Relationship: [msdyn_quoteinvoicingproduct msdyn_quoteinvoicingproduct_SyncErrors](msdyn_quoteinvoicingproduct.md#BKMK_msdyn_quoteinvoicingproduct_SyncErrors)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_quoteinvoicingproduct`|
|ReferencedAttribute|`msdyn_quoteinvoicingproductid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_quoteinvoicingproduct`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_quoteinvoicingsetup_SyncErrors"></a> msdyn_quoteinvoicingsetup_SyncErrors

One-To-Many Relationship: [msdyn_quoteinvoicingsetup msdyn_quoteinvoicingsetup_SyncErrors](msdyn_quoteinvoicingsetup.md#BKMK_msdyn_quoteinvoicingsetup_SyncErrors)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_quoteinvoicingsetup`|
|ReferencedAttribute|`msdyn_quoteinvoicingsetupid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_quoteinvoicingsetup`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_requirementchange_SyncErrors"></a> msdyn_requirementchange_SyncErrors

One-To-Many Relationship: [msdyn_requirementchange msdyn_requirementchange_SyncErrors](msdyn_requirementchange.md#BKMK_msdyn_requirementchange_SyncErrors)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_requirementchange`|
|ReferencedAttribute|`msdyn_requirementchangeid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_requirementchange`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_requirementcharacteristic_SyncErrors"></a> msdyn_requirementcharacteristic_SyncErrors

One-To-Many Relationship: [msdyn_requirementcharacteristic msdyn_requirementcharacteristic_SyncErrors](msdyn_requirementcharacteristic.md#BKMK_msdyn_requirementcharacteristic_SyncErrors)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_requirementcharacteristic`|
|ReferencedAttribute|`msdyn_requirementcharacteristicid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_requirementcharacteristic`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_requirementdependency_SyncErrors"></a> msdyn_requirementdependency_SyncErrors

One-To-Many Relationship: [msdyn_requirementdependency msdyn_requirementdependency_SyncErrors](msdyn_requirementdependency.md#BKMK_msdyn_requirementdependency_SyncErrors)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_requirementdependency`|
|ReferencedAttribute|`msdyn_requirementdependencyid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_requirementdependency`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_requirementgroup_SyncErrors"></a> msdyn_requirementgroup_SyncErrors

One-To-Many Relationship: [msdyn_requirementgroup msdyn_requirementgroup_SyncErrors](msdyn_requirementgroup.md#BKMK_msdyn_requirementgroup_SyncErrors)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_requirementgroup`|
|ReferencedAttribute|`msdyn_requirementgroupid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_requirementgroup`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_requirementorganizationunit_SyncErrors"></a> msdyn_requirementorganizationunit_SyncErrors

One-To-Many Relationship: [msdyn_requirementorganizationunit msdyn_requirementorganizationunit_SyncErrors](msdyn_requirementorganizationunit.md#BKMK_msdyn_requirementorganizationunit_SyncErrors)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_requirementorganizationunit`|
|ReferencedAttribute|`msdyn_requirementorganizationunitid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_requirementorganizationunit`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_requirementrelationship_SyncErrors"></a> msdyn_requirementrelationship_SyncErrors

One-To-Many Relationship: [msdyn_requirementrelationship msdyn_requirementrelationship_SyncErrors](msdyn_requirementrelationship.md#BKMK_msdyn_requirementrelationship_SyncErrors)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_requirementrelationship`|
|ReferencedAttribute|`msdyn_requirementrelationshipid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_requirementrelationship`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_requirementresourcecategory_SyncErrors"></a> msdyn_requirementresourcecategory_SyncErrors

One-To-Many Relationship: [msdyn_requirementresourcecategory msdyn_requirementresourcecategory_SyncErrors](msdyn_requirementresourcecategory.md#BKMK_msdyn_requirementresourcecategory_SyncErrors)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_requirementresourcecategory`|
|ReferencedAttribute|`msdyn_requirementresourcecategoryid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_requirementresourcecategory`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_requirementresourcepreference_SyncErrors"></a> msdyn_requirementresourcepreference_SyncErrors

One-To-Many Relationship: [msdyn_requirementresourcepreference msdyn_requirementresourcepreference_SyncErrors](msdyn_requirementresourcepreference.md#BKMK_msdyn_requirementresourcepreference_SyncErrors)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_requirementresourcepreference`|
|ReferencedAttribute|`msdyn_requirementresourcepreferenceid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_requirementresourcepreference`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_requirementstatus_SyncErrors"></a> msdyn_requirementstatus_SyncErrors

One-To-Many Relationship: [msdyn_requirementstatus msdyn_requirementstatus_SyncErrors](msdyn_requirementstatus.md#BKMK_msdyn_requirementstatus_SyncErrors)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_requirementstatus`|
|ReferencedAttribute|`msdyn_requirementstatusid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_requirementstatus`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_resolution_SyncErrors"></a> msdyn_resolution_SyncErrors

One-To-Many Relationship: [msdyn_resolution msdyn_resolution_SyncErrors](msdyn_resolution.md#BKMK_msdyn_resolution_SyncErrors)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_resolution`|
|ReferencedAttribute|`msdyn_resolutionid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_resolution`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_resourcepaytype_SyncErrors"></a> msdyn_resourcepaytype_SyncErrors

One-To-Many Relationship: [msdyn_resourcepaytype msdyn_resourcepaytype_SyncErrors](msdyn_resourcepaytype.md#BKMK_msdyn_resourcepaytype_SyncErrors)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_resourcepaytype`|
|ReferencedAttribute|`msdyn_resourcepaytypeid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_resourcepaytype`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_resourcerequirement_SyncErrors"></a> msdyn_resourcerequirement_SyncErrors

One-To-Many Relationship: [msdyn_resourcerequirement msdyn_resourcerequirement_SyncErrors](msdyn_resourcerequirement.md#BKMK_msdyn_resourcerequirement_SyncErrors)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_resourcerequirement`|
|ReferencedAttribute|`msdyn_resourcerequirementid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_resourcerequirement`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_resourcerequirementdetail_SyncErrors"></a> msdyn_resourcerequirementdetail_SyncErrors

One-To-Many Relationship: [msdyn_resourcerequirementdetail msdyn_resourcerequirementdetail_SyncErrors](msdyn_resourcerequirementdetail.md#BKMK_msdyn_resourcerequirementdetail_SyncErrors)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_resourcerequirementdetail`|
|ReferencedAttribute|`msdyn_resourcerequirementdetailid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_resourcerequirementdetail`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_resourceterritory_SyncErrors"></a> msdyn_resourceterritory_SyncErrors

One-To-Many Relationship: [msdyn_resourceterritory msdyn_resourceterritory_SyncErrors](msdyn_resourceterritory.md#BKMK_msdyn_resourceterritory_SyncErrors)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_resourceterritory`|
|ReferencedAttribute|`msdyn_resourceterritoryid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_resourceterritory`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_rma_SyncErrors"></a> msdyn_rma_SyncErrors

One-To-Many Relationship: [msdyn_rma msdyn_rma_SyncErrors](msdyn_rma.md#BKMK_msdyn_rma_SyncErrors)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_rma`|
|ReferencedAttribute|`msdyn_rmaid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_rma`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_rmaproduct_SyncErrors"></a> msdyn_rmaproduct_SyncErrors

One-To-Many Relationship: [msdyn_rmaproduct msdyn_rmaproduct_SyncErrors](msdyn_rmaproduct.md#BKMK_msdyn_rmaproduct_SyncErrors)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_rmaproduct`|
|ReferencedAttribute|`msdyn_rmaproductid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_rmaproduct`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_rmareceipt_SyncErrors"></a> msdyn_rmareceipt_SyncErrors

One-To-Many Relationship: [msdyn_rmareceipt msdyn_rmareceipt_SyncErrors](msdyn_rmareceipt.md#BKMK_msdyn_rmareceipt_SyncErrors)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_rmareceipt`|
|ReferencedAttribute|`msdyn_rmareceiptid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_rmareceipt`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_rmareceiptproduct_SyncErrors"></a> msdyn_rmareceiptproduct_SyncErrors

One-To-Many Relationship: [msdyn_rmareceiptproduct msdyn_rmareceiptproduct_SyncErrors](msdyn_rmareceiptproduct.md#BKMK_msdyn_rmareceiptproduct_SyncErrors)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_rmareceiptproduct`|
|ReferencedAttribute|`msdyn_rmareceiptproductid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_rmareceiptproduct`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_rmasubstatus_SyncErrors"></a> msdyn_rmasubstatus_SyncErrors

One-To-Many Relationship: [msdyn_rmasubstatus msdyn_rmasubstatus_SyncErrors](msdyn_rmasubstatus.md#BKMK_msdyn_rmasubstatus_SyncErrors)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_rmasubstatus`|
|ReferencedAttribute|`msdyn_rmasubstatusid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_rmasubstatus`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_rtv_SyncErrors"></a> msdyn_rtv_SyncErrors

One-To-Many Relationship: [msdyn_rtv msdyn_rtv_SyncErrors](msdyn_rtv.md#BKMK_msdyn_rtv_SyncErrors)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_rtv`|
|ReferencedAttribute|`msdyn_rtvid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_rtv`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_rtvproduct_SyncErrors"></a> msdyn_rtvproduct_SyncErrors

One-To-Many Relationship: [msdyn_rtvproduct msdyn_rtvproduct_SyncErrors](msdyn_rtvproduct.md#BKMK_msdyn_rtvproduct_SyncErrors)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_rtvproduct`|
|ReferencedAttribute|`msdyn_rtvproductid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_rtvproduct`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_rtvsubstatus_SyncErrors"></a> msdyn_rtvsubstatus_SyncErrors

One-To-Many Relationship: [msdyn_rtvsubstatus msdyn_rtvsubstatus_SyncErrors](msdyn_rtvsubstatus.md#BKMK_msdyn_rtvsubstatus_SyncErrors)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_rtvsubstatus`|
|ReferencedAttribute|`msdyn_rtvsubstatusid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_rtvsubstatus`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_scheduleboardsetting_SyncErrors"></a> msdyn_scheduleboardsetting_SyncErrors

One-To-Many Relationship: [msdyn_scheduleboardsetting msdyn_scheduleboardsetting_SyncErrors](msdyn_scheduleboardsetting.md#BKMK_msdyn_scheduleboardsetting_SyncErrors)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_scheduleboardsetting`|
|ReferencedAttribute|`msdyn_scheduleboardsettingid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_scheduleboardsetting`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_schedulingfeatureflag_SyncErrors"></a> msdyn_schedulingfeatureflag_SyncErrors

One-To-Many Relationship: [msdyn_schedulingfeatureflag msdyn_schedulingfeatureflag_SyncErrors](msdyn_schedulingfeatureflag.md#BKMK_msdyn_schedulingfeatureflag_SyncErrors)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_schedulingfeatureflag`|
|ReferencedAttribute|`msdyn_schedulingfeatureflagid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_schedulingfeatureflag`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_schedulingparameter_SyncErrors"></a> msdyn_schedulingparameter_SyncErrors

One-To-Many Relationship: [msdyn_schedulingparameter msdyn_schedulingparameter_SyncErrors](msdyn_schedulingparameter.md#BKMK_msdyn_schedulingparameter_SyncErrors)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_schedulingparameter`|
|ReferencedAttribute|`msdyn_schedulingparameterid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_schedulingparameter`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_servicetasktype_SyncErrors"></a> msdyn_servicetasktype_SyncErrors

One-To-Many Relationship: [msdyn_servicetasktype msdyn_servicetasktype_SyncErrors](msdyn_servicetasktype.md#BKMK_msdyn_servicetasktype_SyncErrors)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_servicetasktype`|
|ReferencedAttribute|`msdyn_servicetasktypeid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_servicetasktype`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_sessiondata_SyncErrors"></a> msdyn_sessiondata_SyncErrors

One-To-Many Relationship: [msdyn_sessiondata msdyn_sessiondata_SyncErrors](msdyn_sessiondata.md#BKMK_msdyn_sessiondata_SyncErrors)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_sessiondata`|
|ReferencedAttribute|`msdyn_sessiondataid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_sessiondata`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_sessionparticipantdata_SyncErrors"></a> msdyn_sessionparticipantdata_SyncErrors

One-To-Many Relationship: [msdyn_sessionparticipantdata msdyn_sessionparticipantdata_SyncErrors](msdyn_sessionparticipantdata.md#BKMK_msdyn_sessionparticipantdata_SyncErrors)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_sessionparticipantdata`|
|ReferencedAttribute|`msdyn_sessionparticipantdataid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_sessionparticipantdata`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_shipvia_SyncErrors"></a> msdyn_shipvia_SyncErrors

One-To-Many Relationship: [msdyn_shipvia msdyn_shipvia_SyncErrors](msdyn_shipvia.md#BKMK_msdyn_shipvia_SyncErrors)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_shipvia`|
|ReferencedAttribute|`msdyn_shipviaid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_shipvia`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_systemuserschedulersetting_SyncErrors"></a> msdyn_systemuserschedulersetting_SyncErrors

One-To-Many Relationship: [msdyn_systemuserschedulersetting msdyn_systemuserschedulersetting_SyncErrors](msdyn_systemuserschedulersetting.md#BKMK_msdyn_systemuserschedulersetting_SyncErrors)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_systemuserschedulersetting`|
|ReferencedAttribute|`msdyn_systemuserschedulersettingid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_systemuserschedulersetting`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_taxcode_SyncErrors"></a> msdyn_taxcode_SyncErrors

One-To-Many Relationship: [msdyn_taxcode msdyn_taxcode_SyncErrors](msdyn_taxcode.md#BKMK_msdyn_taxcode_SyncErrors)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_taxcode`|
|ReferencedAttribute|`msdyn_taxcodeid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_taxcode`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_taxcodedetail_SyncErrors"></a> msdyn_taxcodedetail_SyncErrors

One-To-Many Relationship: [msdyn_taxcodedetail msdyn_taxcodedetail_SyncErrors](msdyn_taxcodedetail.md#BKMK_msdyn_taxcodedetail_SyncErrors)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_taxcodedetail`|
|ReferencedAttribute|`msdyn_taxcodedetailid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_taxcodedetail`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_timeentry_SyncErrors"></a> msdyn_timeentry_SyncErrors

One-To-Many Relationship: [msdyn_timeentry msdyn_timeentry_SyncErrors](msdyn_timeentry.md#BKMK_msdyn_timeentry_SyncErrors)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_timeentry`|
|ReferencedAttribute|`msdyn_timeentryid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_timeentry`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_timeentrysetting_SyncErrors"></a> msdyn_timeentrysetting_SyncErrors

One-To-Many Relationship: [msdyn_timeentrysetting msdyn_timeentrysetting_SyncErrors](msdyn_timeentrysetting.md#BKMK_msdyn_timeentrysetting_SyncErrors)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_timeentrysetting`|
|ReferencedAttribute|`msdyn_timeentrysettingid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_timeentrysetting`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_timegroup_SyncErrors"></a> msdyn_timegroup_SyncErrors

One-To-Many Relationship: [msdyn_timegroup msdyn_timegroup_SyncErrors](msdyn_timegroup.md#BKMK_msdyn_timegroup_SyncErrors)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_timegroup`|
|ReferencedAttribute|`msdyn_timegroupid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_timegroup`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_timegroupdetail_SyncErrors"></a> msdyn_timegroupdetail_SyncErrors

One-To-Many Relationship: [msdyn_timegroupdetail msdyn_timegroupdetail_SyncErrors](msdyn_timegroupdetail.md#BKMK_msdyn_timegroupdetail_SyncErrors)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_timegroupdetail`|
|ReferencedAttribute|`msdyn_timegroupdetailid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_timegroupdetail`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_timeoffrequest_SyncErrors"></a> msdyn_timeoffrequest_SyncErrors

One-To-Many Relationship: [msdyn_timeoffrequest msdyn_timeoffrequest_SyncErrors](msdyn_timeoffrequest.md#BKMK_msdyn_timeoffrequest_SyncErrors)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_timeoffrequest`|
|ReferencedAttribute|`msdyn_timeoffrequestid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_timeoffrequest`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_trade_SyncErrors"></a> msdyn_trade_SyncErrors

One-To-Many Relationship: [msdyn_trade msdyn_trade_SyncErrors](msdyn_trade.md#BKMK_msdyn_trade_SyncErrors)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_trade`|
|ReferencedAttribute|`msdyn_tradeid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_trade`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_tradecoverage_SyncErrors"></a> msdyn_tradecoverage_SyncErrors

One-To-Many Relationship: [msdyn_tradecoverage msdyn_tradecoverage_SyncErrors](msdyn_tradecoverage.md#BKMK_msdyn_tradecoverage_SyncErrors)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_tradecoverage`|
|ReferencedAttribute|`msdyn_tradecoverageid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_tradecoverage`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_transactionorigin_SyncErrors"></a> msdyn_transactionorigin_SyncErrors

One-To-Many Relationship: [msdyn_transactionorigin msdyn_transactionorigin_SyncErrors](msdyn_transactionorigin.md#BKMK_msdyn_transactionorigin_SyncErrors)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_transactionorigin`|
|ReferencedAttribute|`msdyn_transactionoriginid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_transactionorigin`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_uniquenumber_SyncErrors"></a> msdyn_uniquenumber_SyncErrors

One-To-Many Relationship: [msdyn_uniquenumber msdyn_uniquenumber_SyncErrors](msdyn_uniquenumber.md#BKMK_msdyn_uniquenumber_SyncErrors)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_uniquenumber`|
|ReferencedAttribute|`msdyn_uniquenumberid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_uniquenumber`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_warehouse_SyncErrors"></a> msdyn_warehouse_SyncErrors

One-To-Many Relationship: [msdyn_warehouse msdyn_warehouse_SyncErrors](msdyn_warehouse.md#BKMK_msdyn_warehouse_SyncErrors)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_warehouse`|
|ReferencedAttribute|`msdyn_warehouseid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_warehouse`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_workhourtemplate_SyncErrors"></a> msdyn_workhourtemplate_SyncErrors

One-To-Many Relationship: [msdyn_workhourtemplate msdyn_workhourtemplate_SyncErrors](msdyn_workhourtemplate.md#BKMK_msdyn_workhourtemplate_SyncErrors)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_workhourtemplate`|
|ReferencedAttribute|`msdyn_workhourtemplateid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_workhourtemplate`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_workorder_SyncErrors"></a> msdyn_workorder_SyncErrors

One-To-Many Relationship: [msdyn_workorder msdyn_workorder_SyncErrors](msdyn_workorder.md#BKMK_msdyn_workorder_SyncErrors)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_workorder`|
|ReferencedAttribute|`msdyn_workorderid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_workorder`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_workorderincident_SyncErrors"></a> msdyn_workorderincident_SyncErrors

One-To-Many Relationship: [msdyn_workorderincident msdyn_workorderincident_SyncErrors](msdyn_workorderincident.md#BKMK_msdyn_workorderincident_SyncErrors)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_workorderincident`|
|ReferencedAttribute|`msdyn_workorderincidentid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_workorderincident`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_workordernte_SyncErrors"></a> msdyn_workordernte_SyncErrors

One-To-Many Relationship: [msdyn_workordernte msdyn_workordernte_SyncErrors](msdyn_workordernte.md#BKMK_msdyn_workordernte_SyncErrors)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_workordernte`|
|ReferencedAttribute|`msdyn_workordernteid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_workordernte`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_workorderproduct_SyncErrors"></a> msdyn_workorderproduct_SyncErrors

One-To-Many Relationship: [msdyn_workorderproduct msdyn_workorderproduct_SyncErrors](msdyn_workorderproduct.md#BKMK_msdyn_workorderproduct_SyncErrors)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_workorderproduct`|
|ReferencedAttribute|`msdyn_workorderproductid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_workorderproduct`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_workorderresolution_SyncErrors"></a> msdyn_workorderresolution_SyncErrors

One-To-Many Relationship: [msdyn_workorderresolution msdyn_workorderresolution_SyncErrors](msdyn_workorderresolution.md#BKMK_msdyn_workorderresolution_SyncErrors)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_workorderresolution`|
|ReferencedAttribute|`msdyn_workorderresolutionid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_workorderresolution`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_workorderresourcerestriction_SyncErrors"></a> msdyn_workorderresourcerestriction_SyncErrors

One-To-Many Relationship: [msdyn_workorderresourcerestriction msdyn_workorderresourcerestriction_SyncErrors](msdyn_workorderresourcerestriction.md#BKMK_msdyn_workorderresourcerestriction_SyncErrors)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_workorderresourcerestriction`|
|ReferencedAttribute|`msdyn_workorderresourcerestrictionid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_workorderresourcerestriction`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_workorderservice_SyncErrors"></a> msdyn_workorderservice_SyncErrors

One-To-Many Relationship: [msdyn_workorderservice msdyn_workorderservice_SyncErrors](msdyn_workorderservice.md#BKMK_msdyn_workorderservice_SyncErrors)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_workorderservice`|
|ReferencedAttribute|`msdyn_workorderserviceid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_workorderservice`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_workorderservicetask_SyncErrors"></a> msdyn_workorderservicetask_SyncErrors

One-To-Many Relationship: [msdyn_workorderservicetask msdyn_workorderservicetask_SyncErrors](msdyn_workorderservicetask.md#BKMK_msdyn_workorderservicetask_SyncErrors)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_workorderservicetask`|
|ReferencedAttribute|`msdyn_workorderservicetaskid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_workorderservicetask`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_workordersubstatus_SyncErrors"></a> msdyn_workordersubstatus_SyncErrors

One-To-Many Relationship: [msdyn_workordersubstatus msdyn_workordersubstatus_SyncErrors](msdyn_workordersubstatus.md#BKMK_msdyn_workordersubstatus_SyncErrors)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_workordersubstatus`|
|ReferencedAttribute|`msdyn_workordersubstatusid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_workordersubstatus`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_workordertype_SyncErrors"></a> msdyn_workordertype_SyncErrors

One-To-Many Relationship: [msdyn_workordertype msdyn_workordertype_SyncErrors](msdyn_workordertype.md#BKMK_msdyn_workordertype_SyncErrors)

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
<xref:Microsoft.Dynamics.CRM.syncerror?displayProperty=fullName>
