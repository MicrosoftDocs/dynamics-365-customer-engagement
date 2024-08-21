---
title: "Process Session (ProcessSession) table/entity reference (Microsoft Dynamics 365 Field Service)"
description: "Includes schema information and supported messages for the Process Session (ProcessSession) table/entity with Microsoft Dynamics 365 Field Service."
ms.date: 08/21/2024
ms.service: powerapps
ms.topic: reference
author: m-hartmann
ms.author: mhart
search.audienceType: 
  - developer
---

# Process Session (ProcessSession) table/entity reference

Information that is generated when a dialog is run. Every time that you run a dialog, a dialog session is created.

> [!NOTE]
> The Microsoft Dynamics 365 Field Service Process Session (ProcessSession) table extends the [Microsoft Dataverse Process Session (ProcessSession) table](/power-apps/developer/data-platform/reference/entities/processsession).



## Customized columns/attributes

Microsoft Dynamics 365 Field Service modifies the definition of columns/attributes defined in other solutions. Listed by **SchemaName**.

### <a name="BKMK_RegardingObjectId"></a> RegardingObjectId

Changes from [RegardingObjectId (Microsoft Dataverse)](/power-apps/developer/data-platform/reference/entities/processsession#BKMK_RegardingObjectId)

|Property|Value|
|---|---|
|Targets|msdyn_3dmodel|


## Many-to-One relationships

These relationships are many-to-one. Listed by **SchemaName**.

- [msdyn_3dmodel_ProcessSession](#BKMK_msdyn_3dmodel_ProcessSession)
- [msdyn_actual_ProcessSession](#BKMK_msdyn_actual_ProcessSession)
- [msdyn_agreement_ProcessSession](#BKMK_msdyn_agreement_ProcessSession)
- [msdyn_agreementbookingdate_ProcessSession](#BKMK_msdyn_agreementbookingdate_ProcessSession)
- [msdyn_agreementbookingincident_ProcessSession](#BKMK_msdyn_agreementbookingincident_ProcessSession)
- [msdyn_agreementbookingproduct_ProcessSession](#BKMK_msdyn_agreementbookingproduct_ProcessSession)
- [msdyn_agreementbookingservice_ProcessSession](#BKMK_msdyn_agreementbookingservice_ProcessSession)
- [msdyn_agreementbookingservicetask_ProcessSession](#BKMK_msdyn_agreementbookingservicetask_ProcessSession)
- [msdyn_agreementbookingsetup_ProcessSession](#BKMK_msdyn_agreementbookingsetup_ProcessSession)
- [msdyn_agreementinvoicedate_ProcessSession](#BKMK_msdyn_agreementinvoicedate_ProcessSession)
- [msdyn_agreementinvoiceproduct_ProcessSession](#BKMK_msdyn_agreementinvoiceproduct_ProcessSession)
- [msdyn_agreementinvoicesetup_ProcessSession](#BKMK_msdyn_agreementinvoicesetup_ProcessSession)
- [msdyn_agreementsubstatus_ProcessSession](#BKMK_msdyn_agreementsubstatus_ProcessSession)
- [msdyn_assetsuggestionssetting_ProcessSession](#BKMK_msdyn_assetsuggestionssetting_ProcessSession)
- [msdyn_bookableresourceassociation_ProcessSession](#BKMK_msdyn_bookableresourceassociation_ProcessSession)
- [msdyn_bookableresourcebookingquicknote_ProcessSession](#BKMK_msdyn_bookableresourcebookingquicknote_ProcessSession)
- [msdyn_bookingalert_ProcessSession](#BKMK_msdyn_bookingalert_ProcessSession)
- [msdyn_bookingalertstatus_ProcessSession](#BKMK_msdyn_bookingalertstatus_ProcessSession)
- [msdyn_bookingchange_ProcessSession](#BKMK_msdyn_bookingchange_ProcessSession)
- [msdyn_bookingjournal_ProcessSession](#BKMK_msdyn_bookingjournal_ProcessSession)
- [msdyn_bookingrule_ProcessSession](#BKMK_msdyn_bookingrule_ProcessSession)
- [msdyn_bookingsetupmetadata_ProcessSession](#BKMK_msdyn_bookingsetupmetadata_ProcessSession)
- [msdyn_bookingtimestamp_ProcessSession](#BKMK_msdyn_bookingtimestamp_ProcessSession)
- [msdyn_bpf_2c5fe86acc8b414b8322ae571000c799_ProcessSession](#BKMK_msdyn_bpf_2c5fe86acc8b414b8322ae571000c799_ProcessSession)
- [msdyn_bpf_477c16f59170487b8b4dc895c5dcd09b_ProcessSession](#BKMK_msdyn_bpf_477c16f59170487b8b4dc895c5dcd09b_ProcessSession)
- [msdyn_bpf_989e9b1857e24af18787d5143b67523b_ProcessSession](#BKMK_msdyn_bpf_989e9b1857e24af18787d5143b67523b_ProcessSession)
- [msdyn_bpf_baa0a411a239410cb8bded8b5fdd88e3_ProcessSession](#BKMK_msdyn_bpf_baa0a411a239410cb8bded8b5fdd88e3_ProcessSession)
- [msdyn_bpf_d3d97bac8c294105840e99e37a9d1c39_ProcessSession](#BKMK_msdyn_bpf_d3d97bac8c294105840e99e37a9d1c39_ProcessSession)
- [msdyn_businessclosure_ProcessSession](#BKMK_msdyn_businessclosure_ProcessSession)
- [msdyn_clientextension_ProcessSession](#BKMK_msdyn_clientextension_ProcessSession)
- [msdyn_configuration_ProcessSession](#BKMK_msdyn_configuration_ProcessSession)
- [msdyn_dataanalyticsreport_fs_ProcessSession](#BKMK_msdyn_dataanalyticsreport_fs_ProcessSession)
- [msdyn_dataanalyticsreport_fspredictrs_ProcessSession](#BKMK_msdyn_dataanalyticsreport_fspredictrs_ProcessSession)
- [msdyn_dataanalyticsreport_fspredictwhd_ProcessSession](#BKMK_msdyn_dataanalyticsreport_fspredictwhd_ProcessSession)
- [msdyn_entitlementapplication_ProcessSession](#BKMK_msdyn_entitlementapplication_ProcessSession)
- [msdyn_entityconfiguration_ProcessSession](#BKMK_msdyn_entityconfiguration_ProcessSession)
- [msdyn_fieldservicepricelistitem_ProcessSession](#BKMK_msdyn_fieldservicepricelistitem_ProcessSession)
- [msdyn_fieldservicesetting_ProcessSession](#BKMK_msdyn_fieldservicesetting_ProcessSession)
- [msdyn_fieldserviceslaconfiguration_ProcessSession](#BKMK_msdyn_fieldserviceslaconfiguration_ProcessSession)
- [msdyn_fieldservicesummaryconfiguration_ProcessSession](#BKMK_msdyn_fieldservicesummaryconfiguration_ProcessSession)
- [msdyn_fieldservicesystemjob_ProcessSession](#BKMK_msdyn_fieldservicesystemjob_ProcessSession)
- [msdyn_flwconfiguration_ProcessSession](#BKMK_msdyn_flwconfiguration_ProcessSession)
- [msdyn_geofence_ProcessSession](#BKMK_msdyn_geofence_ProcessSession)
- [msdyn_geofenceevent_ProcessSession](#BKMK_msdyn_geofenceevent_ProcessSession)
- [msdyn_geofencingsettings_ProcessSession](#BKMK_msdyn_geofencingsettings_ProcessSession)
- [msdyn_geolocationsettings_ProcessSession](#BKMK_msdyn_geolocationsettings_ProcessSession)
- [msdyn_geolocationtracking_ProcessSession](#BKMK_msdyn_geolocationtracking_ProcessSession)
- [msdyn_incidenttype_ProcessSession](#BKMK_msdyn_incidenttype_ProcessSession)
- [msdyn_incidenttype_requirementgroup_ProcessSession](#BKMK_msdyn_incidenttype_requirementgroup_ProcessSession)
- [msdyn_incidenttypecharacteristic_ProcessSession](#BKMK_msdyn_incidenttypecharacteristic_ProcessSession)
- [msdyn_incidenttypeproduct_ProcessSession](#BKMK_msdyn_incidenttypeproduct_ProcessSession)
- [msdyn_incidenttyperecommendationresult_ProcessSession](#BKMK_msdyn_incidenttyperecommendationresult_ProcessSession)
- [msdyn_incidenttyperecommendationrunhistory_ProcessSession](#BKMK_msdyn_incidenttyperecommendationrunhistory_ProcessSession)
- [msdyn_incidenttyperesolution_ProcessSession](#BKMK_msdyn_incidenttyperesolution_ProcessSession)
- [msdyn_incidenttypeservice_ProcessSession](#BKMK_msdyn_incidenttypeservice_ProcessSession)
- [msdyn_incidenttypeservicetask_ProcessSession](#BKMK_msdyn_incidenttypeservicetask_ProcessSession)
- [msdyn_incidenttypessetup_ProcessSession](#BKMK_msdyn_incidenttypessetup_ProcessSession)
- [msdyn_inspection_ProcessSession](#BKMK_msdyn_inspection_ProcessSession)
- [msdyn_inspectionattachment_ProcessSession](#BKMK_msdyn_inspectionattachment_ProcessSession)
- [msdyn_inspectiondefinition_ProcessSession](#BKMK_msdyn_inspectiondefinition_ProcessSession)
- [msdyn_inspectioninstance_ProcessSession](#BKMK_msdyn_inspectioninstance_ProcessSession)
- [msdyn_inspectionresponse_ProcessSession](#BKMK_msdyn_inspectionresponse_ProcessSession)
- [msdyn_insurance_ProcessSession](#BKMK_msdyn_insurance_ProcessSession)
- [msdyn_inventoryadjustment_ProcessSession](#BKMK_msdyn_inventoryadjustment_ProcessSession)
- [msdyn_inventoryadjustmentproduct_ProcessSession](#BKMK_msdyn_inventoryadjustmentproduct_ProcessSession)
- [msdyn_inventoryjournal_ProcessSession](#BKMK_msdyn_inventoryjournal_ProcessSession)
- [msdyn_inventorytransfer_ProcessSession](#BKMK_msdyn_inventorytransfer_ProcessSession)
- [msdyn_mobilesource_ProcessSession](#BKMK_msdyn_mobilesource_ProcessSession)
- [msdyn_nottoexceed_ProcessSession](#BKMK_msdyn_nottoexceed_ProcessSession)
- [msdyn_orderinvoicingdate_ProcessSession](#BKMK_msdyn_orderinvoicingdate_ProcessSession)
- [msdyn_orderinvoicingproduct_ProcessSession](#BKMK_msdyn_orderinvoicingproduct_ProcessSession)
- [msdyn_orderinvoicingsetup_ProcessSession](#BKMK_msdyn_orderinvoicingsetup_ProcessSession)
- [msdyn_orderinvoicingsetupdate_ProcessSession](#BKMK_msdyn_orderinvoicingsetupdate_ProcessSession)
- [msdyn_organizationalunit_ProcessSession](#BKMK_msdyn_organizationalunit_ProcessSession)
- [msdyn_payment_ProcessSession](#BKMK_msdyn_payment_ProcessSession)
- [msdyn_paymentdetail_ProcessSession](#BKMK_msdyn_paymentdetail_ProcessSession)
- [msdyn_paymentmethod_ProcessSession](#BKMK_msdyn_paymentmethod_ProcessSession)
- [msdyn_paymentterm_ProcessSession](#BKMK_msdyn_paymentterm_ProcessSession)
- [msdyn_postalcode_ProcessSession](#BKMK_msdyn_postalcode_ProcessSession)
- [msdyn_predictworkhourdurationsetting_ProcessSession](#BKMK_msdyn_predictworkhourdurationsetting_ProcessSession)
- [msdyn_priority_ProcessSession](#BKMK_msdyn_priority_ProcessSession)
- [msdyn_problematicasset_ProcessSession](#BKMK_msdyn_problematicasset_ProcessSession)
- [msdyn_problematicassetfeedback_ProcessSession](#BKMK_msdyn_problematicassetfeedback_ProcessSession)
- [msdyn_productinventory_ProcessSession](#BKMK_msdyn_productinventory_ProcessSession)
- [msdyn_purchaseorder_ProcessSession](#BKMK_msdyn_purchaseorder_ProcessSession)
- [msdyn_purchaseorderbill_ProcessSession](#BKMK_msdyn_purchaseorderbill_ProcessSession)
- [msdyn_purchaseorderproduct_ProcessSession](#BKMK_msdyn_purchaseorderproduct_ProcessSession)
- [msdyn_purchaseorderreceipt_ProcessSession](#BKMK_msdyn_purchaseorderreceipt_ProcessSession)
- [msdyn_purchaseorderreceiptproduct_ProcessSession](#BKMK_msdyn_purchaseorderreceiptproduct_ProcessSession)
- [msdyn_purchaseordersubstatus_ProcessSession](#BKMK_msdyn_purchaseordersubstatus_ProcessSession)
- [msdyn_quotebookingincident_ProcessSession](#BKMK_msdyn_quotebookingincident_ProcessSession)
- [msdyn_quotebookingproduct_ProcessSession](#BKMK_msdyn_quotebookingproduct_ProcessSession)
- [msdyn_quotebookingservice_ProcessSession](#BKMK_msdyn_quotebookingservice_ProcessSession)
- [msdyn_quotebookingservicetask_ProcessSession](#BKMK_msdyn_quotebookingservicetask_ProcessSession)
- [msdyn_quotebookingsetup_ProcessSession](#BKMK_msdyn_quotebookingsetup_ProcessSession)
- [msdyn_quoteinvoicingproduct_ProcessSession](#BKMK_msdyn_quoteinvoicingproduct_ProcessSession)
- [msdyn_quoteinvoicingsetup_ProcessSession](#BKMK_msdyn_quoteinvoicingsetup_ProcessSession)
- [msdyn_requirementchange_ProcessSession](#BKMK_msdyn_requirementchange_ProcessSession)
- [msdyn_requirementcharacteristic_ProcessSession](#BKMK_msdyn_requirementcharacteristic_ProcessSession)
- [msdyn_requirementdependency_ProcessSession](#BKMK_msdyn_requirementdependency_ProcessSession)
- [msdyn_requirementgroup_ProcessSession](#BKMK_msdyn_requirementgroup_ProcessSession)
- [msdyn_requirementorganizationunit_ProcessSession](#BKMK_msdyn_requirementorganizationunit_ProcessSession)
- [msdyn_requirementrelationship_ProcessSession](#BKMK_msdyn_requirementrelationship_ProcessSession)
- [msdyn_requirementresourcecategory_ProcessSession](#BKMK_msdyn_requirementresourcecategory_ProcessSession)
- [msdyn_requirementresourcepreference_ProcessSession](#BKMK_msdyn_requirementresourcepreference_ProcessSession)
- [msdyn_requirementstatus_ProcessSession](#BKMK_msdyn_requirementstatus_ProcessSession)
- [msdyn_resolution_ProcessSession](#BKMK_msdyn_resolution_ProcessSession)
- [msdyn_resourcepaytype_ProcessSession](#BKMK_msdyn_resourcepaytype_ProcessSession)
- [msdyn_resourcerequirement_ProcessSession](#BKMK_msdyn_resourcerequirement_ProcessSession)
- [msdyn_resourcerequirementdetail_ProcessSession](#BKMK_msdyn_resourcerequirementdetail_ProcessSession)
- [msdyn_resourceterritory_ProcessSession](#BKMK_msdyn_resourceterritory_ProcessSession)
- [msdyn_rma_ProcessSession](#BKMK_msdyn_rma_ProcessSession)
- [msdyn_rmaproduct_ProcessSession](#BKMK_msdyn_rmaproduct_ProcessSession)
- [msdyn_rmareceipt_ProcessSession](#BKMK_msdyn_rmareceipt_ProcessSession)
- [msdyn_rmareceiptproduct_ProcessSession](#BKMK_msdyn_rmareceiptproduct_ProcessSession)
- [msdyn_rmasubstatus_ProcessSession](#BKMK_msdyn_rmasubstatus_ProcessSession)
- [msdyn_rtv_ProcessSession](#BKMK_msdyn_rtv_ProcessSession)
- [msdyn_rtvproduct_ProcessSession](#BKMK_msdyn_rtvproduct_ProcessSession)
- [msdyn_rtvsubstatus_ProcessSession](#BKMK_msdyn_rtvsubstatus_ProcessSession)
- [msdyn_scheduleboardsetting_ProcessSession](#BKMK_msdyn_scheduleboardsetting_ProcessSession)
- [msdyn_schedulingfeatureflag_ProcessSession](#BKMK_msdyn_schedulingfeatureflag_ProcessSession)
- [msdyn_schedulingparameter_ProcessSession](#BKMK_msdyn_schedulingparameter_ProcessSession)
- [msdyn_servicetasktype_ProcessSession](#BKMK_msdyn_servicetasktype_ProcessSession)
- [msdyn_shipvia_ProcessSession](#BKMK_msdyn_shipvia_ProcessSession)
- [msdyn_systemuserschedulersetting_ProcessSession](#BKMK_msdyn_systemuserschedulersetting_ProcessSession)
- [msdyn_taxcode_ProcessSession](#BKMK_msdyn_taxcode_ProcessSession)
- [msdyn_taxcodedetail_ProcessSession](#BKMK_msdyn_taxcodedetail_ProcessSession)
- [msdyn_timeentry_ProcessSession](#BKMK_msdyn_timeentry_ProcessSession)
- [msdyn_timeentrysetting_ProcessSession](#BKMK_msdyn_timeentrysetting_ProcessSession)
- [msdyn_timegroup_ProcessSession](#BKMK_msdyn_timegroup_ProcessSession)
- [msdyn_timegroupdetail_ProcessSession](#BKMK_msdyn_timegroupdetail_ProcessSession)
- [msdyn_timeoffrequest_ProcessSession](#BKMK_msdyn_timeoffrequest_ProcessSession)
- [msdyn_trade_ProcessSession](#BKMK_msdyn_trade_ProcessSession)
- [msdyn_tradecoverage_ProcessSession](#BKMK_msdyn_tradecoverage_ProcessSession)
- [msdyn_transactionorigin_ProcessSession](#BKMK_msdyn_transactionorigin_ProcessSession)
- [msdyn_uniquenumber_ProcessSession](#BKMK_msdyn_uniquenumber_ProcessSession)
- [msdyn_warehouse_ProcessSession](#BKMK_msdyn_warehouse_ProcessSession)
- [msdyn_workhourtemplate_ProcessSession](#BKMK_msdyn_workhourtemplate_ProcessSession)
- [msdyn_workorder_ProcessSession](#BKMK_msdyn_workorder_ProcessSession)
- [msdyn_workordercharacteristic_ProcessSession](#BKMK_msdyn_workordercharacteristic_ProcessSession)
- [msdyn_workorderdetailsgenerationqueue_ProcessSession](#BKMK_msdyn_workorderdetailsgenerationqueue_ProcessSession)
- [msdyn_workorderincident_ProcessSession](#BKMK_msdyn_workorderincident_ProcessSession)
- [msdyn_workordernte_ProcessSession](#BKMK_msdyn_workordernte_ProcessSession)
- [msdyn_workorderproduct_ProcessSession](#BKMK_msdyn_workorderproduct_ProcessSession)
- [msdyn_workorderresolution_ProcessSession](#BKMK_msdyn_workorderresolution_ProcessSession)
- [msdyn_workorderresourcerestriction_ProcessSession](#BKMK_msdyn_workorderresourcerestriction_ProcessSession)
- [msdyn_workorderservice_ProcessSession](#BKMK_msdyn_workorderservice_ProcessSession)
- [msdyn_workorderservicetask_ProcessSession](#BKMK_msdyn_workorderservicetask_ProcessSession)
- [msdyn_workordersubstatus_ProcessSession](#BKMK_msdyn_workordersubstatus_ProcessSession)
- [msdyn_workordertype_ProcessSession](#BKMK_msdyn_workordertype_ProcessSession)

### <a name="BKMK_msdyn_3dmodel_ProcessSession"></a> msdyn_3dmodel_ProcessSession

One-To-Many Relationship: [msdyn_3dmodel msdyn_3dmodel_ProcessSession](msdyn_3dmodel.md#BKMK_msdyn_3dmodel_ProcessSession)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_3dmodel`|
|ReferencedAttribute|`msdyn_3dmodelid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_3dmodel`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_actual_ProcessSession"></a> msdyn_actual_ProcessSession

One-To-Many Relationship: [msdyn_actual msdyn_actual_ProcessSession](msdyn_actual.md#BKMK_msdyn_actual_ProcessSession)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_actual`|
|ReferencedAttribute|`msdyn_actualid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_actual`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_agreement_ProcessSession"></a> msdyn_agreement_ProcessSession

One-To-Many Relationship: [msdyn_agreement msdyn_agreement_ProcessSession](msdyn_agreement.md#BKMK_msdyn_agreement_ProcessSession)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_agreement`|
|ReferencedAttribute|`msdyn_agreementid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_agreement`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_agreementbookingdate_ProcessSession"></a> msdyn_agreementbookingdate_ProcessSession

One-To-Many Relationship: [msdyn_agreementbookingdate msdyn_agreementbookingdate_ProcessSession](msdyn_agreementbookingdate.md#BKMK_msdyn_agreementbookingdate_ProcessSession)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_agreementbookingdate`|
|ReferencedAttribute|`msdyn_agreementbookingdateid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_agreementbookingdate`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_agreementbookingincident_ProcessSession"></a> msdyn_agreementbookingincident_ProcessSession

One-To-Many Relationship: [msdyn_agreementbookingincident msdyn_agreementbookingincident_ProcessSession](msdyn_agreementbookingincident.md#BKMK_msdyn_agreementbookingincident_ProcessSession)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_agreementbookingincident`|
|ReferencedAttribute|`msdyn_agreementbookingincidentid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_agreementbookingincident`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_agreementbookingproduct_ProcessSession"></a> msdyn_agreementbookingproduct_ProcessSession

One-To-Many Relationship: [msdyn_agreementbookingproduct msdyn_agreementbookingproduct_ProcessSession](msdyn_agreementbookingproduct.md#BKMK_msdyn_agreementbookingproduct_ProcessSession)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_agreementbookingproduct`|
|ReferencedAttribute|`msdyn_agreementbookingproductid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_agreementbookingproduct`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_agreementbookingservice_ProcessSession"></a> msdyn_agreementbookingservice_ProcessSession

One-To-Many Relationship: [msdyn_agreementbookingservice msdyn_agreementbookingservice_ProcessSession](msdyn_agreementbookingservice.md#BKMK_msdyn_agreementbookingservice_ProcessSession)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_agreementbookingservice`|
|ReferencedAttribute|`msdyn_agreementbookingserviceid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_agreementbookingservice`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_agreementbookingservicetask_ProcessSession"></a> msdyn_agreementbookingservicetask_ProcessSession

One-To-Many Relationship: [msdyn_agreementbookingservicetask msdyn_agreementbookingservicetask_ProcessSession](msdyn_agreementbookingservicetask.md#BKMK_msdyn_agreementbookingservicetask_ProcessSession)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_agreementbookingservicetask`|
|ReferencedAttribute|`msdyn_agreementbookingservicetaskid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_agreementbookingservicetask`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_agreementbookingsetup_ProcessSession"></a> msdyn_agreementbookingsetup_ProcessSession

One-To-Many Relationship: [msdyn_agreementbookingsetup msdyn_agreementbookingsetup_ProcessSession](msdyn_agreementbookingsetup.md#BKMK_msdyn_agreementbookingsetup_ProcessSession)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_agreementbookingsetup`|
|ReferencedAttribute|`msdyn_agreementbookingsetupid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_agreementbookingsetup`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_agreementinvoicedate_ProcessSession"></a> msdyn_agreementinvoicedate_ProcessSession

One-To-Many Relationship: [msdyn_agreementinvoicedate msdyn_agreementinvoicedate_ProcessSession](msdyn_agreementinvoicedate.md#BKMK_msdyn_agreementinvoicedate_ProcessSession)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_agreementinvoicedate`|
|ReferencedAttribute|`msdyn_agreementinvoicedateid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_agreementinvoicedate`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_agreementinvoiceproduct_ProcessSession"></a> msdyn_agreementinvoiceproduct_ProcessSession

One-To-Many Relationship: [msdyn_agreementinvoiceproduct msdyn_agreementinvoiceproduct_ProcessSession](msdyn_agreementinvoiceproduct.md#BKMK_msdyn_agreementinvoiceproduct_ProcessSession)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_agreementinvoiceproduct`|
|ReferencedAttribute|`msdyn_agreementinvoiceproductid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_agreementinvoiceproduct`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_agreementinvoicesetup_ProcessSession"></a> msdyn_agreementinvoicesetup_ProcessSession

One-To-Many Relationship: [msdyn_agreementinvoicesetup msdyn_agreementinvoicesetup_ProcessSession](msdyn_agreementinvoicesetup.md#BKMK_msdyn_agreementinvoicesetup_ProcessSession)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_agreementinvoicesetup`|
|ReferencedAttribute|`msdyn_agreementinvoicesetupid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_agreementinvoicesetup`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_agreementsubstatus_ProcessSession"></a> msdyn_agreementsubstatus_ProcessSession

One-To-Many Relationship: [msdyn_agreementsubstatus msdyn_agreementsubstatus_ProcessSession](msdyn_agreementsubstatus.md#BKMK_msdyn_agreementsubstatus_ProcessSession)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_agreementsubstatus`|
|ReferencedAttribute|`msdyn_agreementsubstatusid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_agreementsubstatus`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_assetsuggestionssetting_ProcessSession"></a> msdyn_assetsuggestionssetting_ProcessSession

One-To-Many Relationship: [msdyn_assetsuggestionssetting msdyn_assetsuggestionssetting_ProcessSession](msdyn_assetsuggestionssetting.md#BKMK_msdyn_assetsuggestionssetting_ProcessSession)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_assetsuggestionssetting`|
|ReferencedAttribute|`msdyn_assetsuggestionssettingid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_assetsuggestionssetting`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_bookableresourceassociation_ProcessSession"></a> msdyn_bookableresourceassociation_ProcessSession

One-To-Many Relationship: [msdyn_bookableresourceassociation msdyn_bookableresourceassociation_ProcessSession](msdyn_bookableresourceassociation.md#BKMK_msdyn_bookableresourceassociation_ProcessSession)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_bookableresourceassociation`|
|ReferencedAttribute|`msdyn_bookableresourceassociationid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_bookableresourceassociation`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_bookableresourcebookingquicknote_ProcessSession"></a> msdyn_bookableresourcebookingquicknote_ProcessSession

One-To-Many Relationship: [msdyn_bookableresourcebookingquicknote msdyn_bookableresourcebookingquicknote_ProcessSession](msdyn_bookableresourcebookingquicknote.md#BKMK_msdyn_bookableresourcebookingquicknote_ProcessSession)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_bookableresourcebookingquicknote`|
|ReferencedAttribute|`msdyn_bookableresourcebookingquicknoteid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_bookableresourcebookingquicknote`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_bookingalert_ProcessSession"></a> msdyn_bookingalert_ProcessSession

One-To-Many Relationship: [msdyn_bookingalert msdyn_bookingalert_ProcessSession](msdyn_bookingalert.md#BKMK_msdyn_bookingalert_ProcessSession)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_bookingalert`|
|ReferencedAttribute|`activityid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_bookingalert`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_bookingalertstatus_ProcessSession"></a> msdyn_bookingalertstatus_ProcessSession

One-To-Many Relationship: [msdyn_bookingalertstatus msdyn_bookingalertstatus_ProcessSession](msdyn_bookingalertstatus.md#BKMK_msdyn_bookingalertstatus_ProcessSession)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_bookingalertstatus`|
|ReferencedAttribute|`msdyn_bookingalertstatusid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_bookingalertstatus`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_bookingchange_ProcessSession"></a> msdyn_bookingchange_ProcessSession

One-To-Many Relationship: [msdyn_bookingchange msdyn_bookingchange_ProcessSession](msdyn_bookingchange.md#BKMK_msdyn_bookingchange_ProcessSession)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_bookingchange`|
|ReferencedAttribute|`msdyn_bookingchangeid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_bookingchange`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_bookingjournal_ProcessSession"></a> msdyn_bookingjournal_ProcessSession

One-To-Many Relationship: [msdyn_bookingjournal msdyn_bookingjournal_ProcessSession](msdyn_bookingjournal.md#BKMK_msdyn_bookingjournal_ProcessSession)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_bookingjournal`|
|ReferencedAttribute|`msdyn_bookingjournalid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_bookingjournal`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_bookingrule_ProcessSession"></a> msdyn_bookingrule_ProcessSession

One-To-Many Relationship: [msdyn_bookingrule msdyn_bookingrule_ProcessSession](msdyn_bookingrule.md#BKMK_msdyn_bookingrule_ProcessSession)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_bookingrule`|
|ReferencedAttribute|`msdyn_bookingruleid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_bookingrule`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_bookingsetupmetadata_ProcessSession"></a> msdyn_bookingsetupmetadata_ProcessSession

One-To-Many Relationship: [msdyn_bookingsetupmetadata msdyn_bookingsetupmetadata_ProcessSession](msdyn_bookingsetupmetadata.md#BKMK_msdyn_bookingsetupmetadata_ProcessSession)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_bookingsetupmetadata`|
|ReferencedAttribute|`msdyn_bookingsetupmetadataid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_bookingsetupmetadata`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_bookingtimestamp_ProcessSession"></a> msdyn_bookingtimestamp_ProcessSession

One-To-Many Relationship: [msdyn_bookingtimestamp msdyn_bookingtimestamp_ProcessSession](msdyn_bookingtimestamp.md#BKMK_msdyn_bookingtimestamp_ProcessSession)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_bookingtimestamp`|
|ReferencedAttribute|`msdyn_bookingtimestampid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_bookingtimestamp`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_bpf_2c5fe86acc8b414b8322ae571000c799_ProcessSession"></a> msdyn_bpf_2c5fe86acc8b414b8322ae571000c799_ProcessSession

One-To-Many Relationship: [msdyn_bpf_2c5fe86acc8b414b8322ae571000c799 msdyn_bpf_2c5fe86acc8b414b8322ae571000c799_ProcessSession](msdyn_bpf_2c5fe86acc8b414b8322ae571000c799.md#BKMK_msdyn_bpf_2c5fe86acc8b414b8322ae571000c799_ProcessSession)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_bpf_2c5fe86acc8b414b8322ae571000c799`|
|ReferencedAttribute|`businessprocessflowinstanceid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_bpf_2c5fe86acc8b414b8322ae571000c799`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_bpf_477c16f59170487b8b4dc895c5dcd09b_ProcessSession"></a> msdyn_bpf_477c16f59170487b8b4dc895c5dcd09b_ProcessSession

One-To-Many Relationship: [msdyn_bpf_477c16f59170487b8b4dc895c5dcd09b msdyn_bpf_477c16f59170487b8b4dc895c5dcd09b_ProcessSession](msdyn_bpf_477c16f59170487b8b4dc895c5dcd09b.md#BKMK_msdyn_bpf_477c16f59170487b8b4dc895c5dcd09b_ProcessSession)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_bpf_477c16f59170487b8b4dc895c5dcd09b`|
|ReferencedAttribute|`businessprocessflowinstanceid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_bpf_477c16f59170487b8b4dc895c5dcd09b`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_bpf_989e9b1857e24af18787d5143b67523b_ProcessSession"></a> msdyn_bpf_989e9b1857e24af18787d5143b67523b_ProcessSession

One-To-Many Relationship: [msdyn_bpf_989e9b1857e24af18787d5143b67523b msdyn_bpf_989e9b1857e24af18787d5143b67523b_ProcessSession](msdyn_bpf_989e9b1857e24af18787d5143b67523b.md#BKMK_msdyn_bpf_989e9b1857e24af18787d5143b67523b_ProcessSession)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_bpf_989e9b1857e24af18787d5143b67523b`|
|ReferencedAttribute|`businessprocessflowinstanceid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_bpf_989e9b1857e24af18787d5143b67523b`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_bpf_baa0a411a239410cb8bded8b5fdd88e3_ProcessSession"></a> msdyn_bpf_baa0a411a239410cb8bded8b5fdd88e3_ProcessSession

One-To-Many Relationship: [msdyn_bpf_baa0a411a239410cb8bded8b5fdd88e3 msdyn_bpf_baa0a411a239410cb8bded8b5fdd88e3_ProcessSession](msdyn_bpf_baa0a411a239410cb8bded8b5fdd88e3.md#BKMK_msdyn_bpf_baa0a411a239410cb8bded8b5fdd88e3_ProcessSession)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_bpf_baa0a411a239410cb8bded8b5fdd88e3`|
|ReferencedAttribute|`businessprocessflowinstanceid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_bpf_baa0a411a239410cb8bded8b5fdd88e3`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_bpf_d3d97bac8c294105840e99e37a9d1c39_ProcessSession"></a> msdyn_bpf_d3d97bac8c294105840e99e37a9d1c39_ProcessSession

One-To-Many Relationship: [msdyn_bpf_d3d97bac8c294105840e99e37a9d1c39 msdyn_bpf_d3d97bac8c294105840e99e37a9d1c39_ProcessSession](msdyn_bpf_d3d97bac8c294105840e99e37a9d1c39.md#BKMK_msdyn_bpf_d3d97bac8c294105840e99e37a9d1c39_ProcessSession)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_bpf_d3d97bac8c294105840e99e37a9d1c39`|
|ReferencedAttribute|`businessprocessflowinstanceid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_bpf_d3d97bac8c294105840e99e37a9d1c39`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_businessclosure_ProcessSession"></a> msdyn_businessclosure_ProcessSession

One-To-Many Relationship: [msdyn_businessclosure msdyn_businessclosure_ProcessSession](msdyn_businessclosure.md#BKMK_msdyn_businessclosure_ProcessSession)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_businessclosure`|
|ReferencedAttribute|`msdyn_businessclosureid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_businessclosure`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_clientextension_ProcessSession"></a> msdyn_clientextension_ProcessSession

One-To-Many Relationship: [msdyn_clientextension msdyn_clientextension_ProcessSession](msdyn_clientextension.md#BKMK_msdyn_clientextension_ProcessSession)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_clientextension`|
|ReferencedAttribute|`msdyn_clientextensionid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_clientextension`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_configuration_ProcessSession"></a> msdyn_configuration_ProcessSession

One-To-Many Relationship: [msdyn_configuration msdyn_configuration_ProcessSession](msdyn_configuration.md#BKMK_msdyn_configuration_ProcessSession)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_configuration`|
|ReferencedAttribute|`msdyn_configurationid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_configuration`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_dataanalyticsreport_fs_ProcessSession"></a> msdyn_dataanalyticsreport_fs_ProcessSession

One-To-Many Relationship: [msdyn_dataanalyticsreport_fs msdyn_dataanalyticsreport_fs_ProcessSession](msdyn_dataanalyticsreport_fs.md#BKMK_msdyn_dataanalyticsreport_fs_ProcessSession)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_dataanalyticsreport_fs`|
|ReferencedAttribute|`msdyn_dataanalyticsreport_fsid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_dataanalyticsreport_fs`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_dataanalyticsreport_fspredictrs_ProcessSession"></a> msdyn_dataanalyticsreport_fspredictrs_ProcessSession

One-To-Many Relationship: [msdyn_dataanalyticsreport_fspredictrs msdyn_dataanalyticsreport_fspredictrs_ProcessSession](msdyn_dataanalyticsreport_fspredictrs.md#BKMK_msdyn_dataanalyticsreport_fspredictrs_ProcessSession)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_dataanalyticsreport_fspredictrs`|
|ReferencedAttribute|`msdyn_dataanalyticsreport_fspredictrsid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_dataanalyticsreport_fspredictrs`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_dataanalyticsreport_fspredictwhd_ProcessSession"></a> msdyn_dataanalyticsreport_fspredictwhd_ProcessSession

One-To-Many Relationship: [msdyn_dataanalyticsreport_fspredictwhd msdyn_dataanalyticsreport_fspredictwhd_ProcessSession](msdyn_dataanalyticsreport_fspredictwhd.md#BKMK_msdyn_dataanalyticsreport_fspredictwhd_ProcessSession)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_dataanalyticsreport_fspredictwhd`|
|ReferencedAttribute|`msdyn_dataanalyticsreport_fspredictwhdid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_dataanalyticsreport_fspredictwhd`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_entitlementapplication_ProcessSession"></a> msdyn_entitlementapplication_ProcessSession

One-To-Many Relationship: [msdyn_entitlementapplication msdyn_entitlementapplication_ProcessSession](msdyn_entitlementapplication.md#BKMK_msdyn_entitlementapplication_ProcessSession)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_entitlementapplication`|
|ReferencedAttribute|`msdyn_entitlementapplicationid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_entitlementapplication`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_entityconfiguration_ProcessSession"></a> msdyn_entityconfiguration_ProcessSession

One-To-Many Relationship: [msdyn_entityconfiguration msdyn_entityconfiguration_ProcessSession](msdyn_entityconfiguration.md#BKMK_msdyn_entityconfiguration_ProcessSession)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_entityconfiguration`|
|ReferencedAttribute|`msdyn_entityconfigurationid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_entityconfiguration`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_fieldservicepricelistitem_ProcessSession"></a> msdyn_fieldservicepricelistitem_ProcessSession

One-To-Many Relationship: [msdyn_fieldservicepricelistitem msdyn_fieldservicepricelistitem_ProcessSession](msdyn_fieldservicepricelistitem.md#BKMK_msdyn_fieldservicepricelistitem_ProcessSession)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_fieldservicepricelistitem`|
|ReferencedAttribute|`msdyn_fieldservicepricelistitemid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_fieldservicepricelistitem`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_fieldservicesetting_ProcessSession"></a> msdyn_fieldservicesetting_ProcessSession

One-To-Many Relationship: [msdyn_fieldservicesetting msdyn_fieldservicesetting_ProcessSession](msdyn_fieldservicesetting.md#BKMK_msdyn_fieldservicesetting_ProcessSession)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_fieldservicesetting`|
|ReferencedAttribute|`msdyn_fieldservicesettingid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_fieldservicesetting`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_fieldserviceslaconfiguration_ProcessSession"></a> msdyn_fieldserviceslaconfiguration_ProcessSession

One-To-Many Relationship: [msdyn_fieldserviceslaconfiguration msdyn_fieldserviceslaconfiguration_ProcessSession](msdyn_fieldserviceslaconfiguration.md#BKMK_msdyn_fieldserviceslaconfiguration_ProcessSession)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_fieldserviceslaconfiguration`|
|ReferencedAttribute|`msdyn_fieldserviceslaconfigurationid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_fieldserviceslaconfiguration`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_fieldservicesummaryconfiguration_ProcessSession"></a> msdyn_fieldservicesummaryconfiguration_ProcessSession

One-To-Many Relationship: [msdyn_fieldservicesummaryconfiguration msdyn_fieldservicesummaryconfiguration_ProcessSession](msdyn_fieldservicesummaryconfiguration.md#BKMK_msdyn_fieldservicesummaryconfiguration_ProcessSession)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_fieldservicesummaryconfiguration`|
|ReferencedAttribute|`msdyn_fieldservicesummaryconfigurationid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_fieldservicesummaryconfiguration`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_fieldservicesystemjob_ProcessSession"></a> msdyn_fieldservicesystemjob_ProcessSession

One-To-Many Relationship: [msdyn_fieldservicesystemjob msdyn_fieldservicesystemjob_ProcessSession](msdyn_fieldservicesystemjob.md#BKMK_msdyn_fieldservicesystemjob_ProcessSession)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_fieldservicesystemjob`|
|ReferencedAttribute|`msdyn_fieldservicesystemjobid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_fieldservicesystemjob`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_flwconfiguration_ProcessSession"></a> msdyn_flwconfiguration_ProcessSession

One-To-Many Relationship: [msdyn_flwconfiguration msdyn_flwconfiguration_ProcessSession](msdyn_flwconfiguration.md#BKMK_msdyn_flwconfiguration_ProcessSession)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_flwconfiguration`|
|ReferencedAttribute|`msdyn_flwconfigurationid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_flwconfiguration`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_geofence_ProcessSession"></a> msdyn_geofence_ProcessSession

One-To-Many Relationship: [msdyn_geofence msdyn_geofence_ProcessSession](msdyn_geofence.md#BKMK_msdyn_geofence_ProcessSession)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_geofence`|
|ReferencedAttribute|`msdyn_geofenceid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_geofence`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_geofenceevent_ProcessSession"></a> msdyn_geofenceevent_ProcessSession

One-To-Many Relationship: [msdyn_geofenceevent msdyn_geofenceevent_ProcessSession](msdyn_geofenceevent.md#BKMK_msdyn_geofenceevent_ProcessSession)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_geofenceevent`|
|ReferencedAttribute|`msdyn_geofenceeventid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_geofenceevent`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_geofencingsettings_ProcessSession"></a> msdyn_geofencingsettings_ProcessSession

One-To-Many Relationship: [msdyn_geofencingsettings msdyn_geofencingsettings_ProcessSession](msdyn_geofencingsettings.md#BKMK_msdyn_geofencingsettings_ProcessSession)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_geofencingsettings`|
|ReferencedAttribute|`msdyn_geofencingsettingsid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_geofencingsettings`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_geolocationsettings_ProcessSession"></a> msdyn_geolocationsettings_ProcessSession

One-To-Many Relationship: [msdyn_geolocationsettings msdyn_geolocationsettings_ProcessSession](msdyn_geolocationsettings.md#BKMK_msdyn_geolocationsettings_ProcessSession)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_geolocationsettings`|
|ReferencedAttribute|`msdyn_geolocationsettingsid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_geolocationsettings`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_geolocationtracking_ProcessSession"></a> msdyn_geolocationtracking_ProcessSession

One-To-Many Relationship: [msdyn_geolocationtracking msdyn_geolocationtracking_ProcessSession](msdyn_geolocationtracking.md#BKMK_msdyn_geolocationtracking_ProcessSession)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_geolocationtracking`|
|ReferencedAttribute|`msdyn_geolocationtrackingid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_geolocationtracking`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_incidenttype_ProcessSession"></a> msdyn_incidenttype_ProcessSession

One-To-Many Relationship: [msdyn_incidenttype msdyn_incidenttype_ProcessSession](msdyn_incidenttype.md#BKMK_msdyn_incidenttype_ProcessSession)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_incidenttype`|
|ReferencedAttribute|`msdyn_incidenttypeid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_incidenttype`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_incidenttype_requirementgroup_ProcessSession"></a> msdyn_incidenttype_requirementgroup_ProcessSession

One-To-Many Relationship: [msdyn_incidenttype_requirementgroup msdyn_incidenttype_requirementgroup_ProcessSession](msdyn_incidenttype_requirementgroup.md#BKMK_msdyn_incidenttype_requirementgroup_ProcessSession)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_incidenttype_requirementgroup`|
|ReferencedAttribute|`msdyn_incidenttype_requirementgroupid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_incidenttype_requirementgroup`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_incidenttypecharacteristic_ProcessSession"></a> msdyn_incidenttypecharacteristic_ProcessSession

One-To-Many Relationship: [msdyn_incidenttypecharacteristic msdyn_incidenttypecharacteristic_ProcessSession](msdyn_incidenttypecharacteristic.md#BKMK_msdyn_incidenttypecharacteristic_ProcessSession)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_incidenttypecharacteristic`|
|ReferencedAttribute|`msdyn_incidenttypecharacteristicid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_incidenttypecharacteristic`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_incidenttypeproduct_ProcessSession"></a> msdyn_incidenttypeproduct_ProcessSession

One-To-Many Relationship: [msdyn_incidenttypeproduct msdyn_incidenttypeproduct_ProcessSession](msdyn_incidenttypeproduct.md#BKMK_msdyn_incidenttypeproduct_ProcessSession)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_incidenttypeproduct`|
|ReferencedAttribute|`msdyn_incidenttypeproductid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_incidenttypeproduct`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_incidenttyperecommendationresult_ProcessSession"></a> msdyn_incidenttyperecommendationresult_ProcessSession

One-To-Many Relationship: [msdyn_incidenttyperecommendationresult msdyn_incidenttyperecommendationresult_ProcessSession](msdyn_incidenttyperecommendationresult.md#BKMK_msdyn_incidenttyperecommendationresult_ProcessSession)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_incidenttyperecommendationresult`|
|ReferencedAttribute|`msdyn_incidenttyperecommendationresultid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_incidenttyperecommendationresult`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_incidenttyperecommendationrunhistory_ProcessSession"></a> msdyn_incidenttyperecommendationrunhistory_ProcessSession

One-To-Many Relationship: [msdyn_incidenttyperecommendationrunhistory msdyn_incidenttyperecommendationrunhistory_ProcessSession](msdyn_incidenttyperecommendationrunhistory.md#BKMK_msdyn_incidenttyperecommendationrunhistory_ProcessSession)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_incidenttyperecommendationrunhistory`|
|ReferencedAttribute|`msdyn_incidenttyperecommendationrunhistoryid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_incidenttyperecommendationrunhistory`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_incidenttyperesolution_ProcessSession"></a> msdyn_incidenttyperesolution_ProcessSession

One-To-Many Relationship: [msdyn_incidenttyperesolution msdyn_incidenttyperesolution_ProcessSession](msdyn_incidenttyperesolution.md#BKMK_msdyn_incidenttyperesolution_ProcessSession)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_incidenttyperesolution`|
|ReferencedAttribute|`msdyn_incidenttyperesolutionid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_incidenttyperesolution`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_incidenttypeservice_ProcessSession"></a> msdyn_incidenttypeservice_ProcessSession

One-To-Many Relationship: [msdyn_incidenttypeservice msdyn_incidenttypeservice_ProcessSession](msdyn_incidenttypeservice.md#BKMK_msdyn_incidenttypeservice_ProcessSession)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_incidenttypeservice`|
|ReferencedAttribute|`msdyn_incidenttypeserviceid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_incidenttypeservice`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_incidenttypeservicetask_ProcessSession"></a> msdyn_incidenttypeservicetask_ProcessSession

One-To-Many Relationship: [msdyn_incidenttypeservicetask msdyn_incidenttypeservicetask_ProcessSession](msdyn_incidenttypeservicetask.md#BKMK_msdyn_incidenttypeservicetask_ProcessSession)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_incidenttypeservicetask`|
|ReferencedAttribute|`msdyn_incidenttypeservicetaskid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_incidenttypeservicetask`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_incidenttypessetup_ProcessSession"></a> msdyn_incidenttypessetup_ProcessSession

One-To-Many Relationship: [msdyn_incidenttypessetup msdyn_incidenttypessetup_ProcessSession](msdyn_incidenttypessetup.md#BKMK_msdyn_incidenttypessetup_ProcessSession)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_incidenttypessetup`|
|ReferencedAttribute|`msdyn_incidenttypessetupid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_incidenttypessetup`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_inspection_ProcessSession"></a> msdyn_inspection_ProcessSession

One-To-Many Relationship: [msdyn_inspection msdyn_inspection_ProcessSession](msdyn_inspection.md#BKMK_msdyn_inspection_ProcessSession)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_inspection`|
|ReferencedAttribute|`msdyn_inspectionid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_inspection`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_inspectionattachment_ProcessSession"></a> msdyn_inspectionattachment_ProcessSession

One-To-Many Relationship: [msdyn_inspectionattachment msdyn_inspectionattachment_ProcessSession](msdyn_inspectionattachment.md#BKMK_msdyn_inspectionattachment_ProcessSession)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_inspectionattachment`|
|ReferencedAttribute|`msdyn_inspectionattachmentid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_inspectionattachment`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_inspectiondefinition_ProcessSession"></a> msdyn_inspectiondefinition_ProcessSession

One-To-Many Relationship: [msdyn_inspectiondefinition msdyn_inspectiondefinition_ProcessSession](msdyn_inspectiondefinition.md#BKMK_msdyn_inspectiondefinition_ProcessSession)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_inspectiondefinition`|
|ReferencedAttribute|`msdyn_inspectiondefinitionid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_inspectiondefinition`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_inspectioninstance_ProcessSession"></a> msdyn_inspectioninstance_ProcessSession

One-To-Many Relationship: [msdyn_inspectioninstance msdyn_inspectioninstance_ProcessSession](msdyn_inspectioninstance.md#BKMK_msdyn_inspectioninstance_ProcessSession)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_inspectioninstance`|
|ReferencedAttribute|`msdyn_inspectioninstanceid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_inspectioninstance`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_inspectionresponse_ProcessSession"></a> msdyn_inspectionresponse_ProcessSession

One-To-Many Relationship: [msdyn_inspectionresponse msdyn_inspectionresponse_ProcessSession](msdyn_inspectionresponse.md#BKMK_msdyn_inspectionresponse_ProcessSession)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_inspectionresponse`|
|ReferencedAttribute|`msdyn_inspectionresponseid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_inspectionresponse`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_insurance_ProcessSession"></a> msdyn_insurance_ProcessSession

One-To-Many Relationship: [msdyn_insurance msdyn_insurance_ProcessSession](msdyn_insurance.md#BKMK_msdyn_insurance_ProcessSession)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_insurance`|
|ReferencedAttribute|`msdyn_insuranceid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_insurance`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_inventoryadjustment_ProcessSession"></a> msdyn_inventoryadjustment_ProcessSession

One-To-Many Relationship: [msdyn_inventoryadjustment msdyn_inventoryadjustment_ProcessSession](msdyn_inventoryadjustment.md#BKMK_msdyn_inventoryadjustment_ProcessSession)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_inventoryadjustment`|
|ReferencedAttribute|`msdyn_inventoryadjustmentid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_inventoryadjustment`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_inventoryadjustmentproduct_ProcessSession"></a> msdyn_inventoryadjustmentproduct_ProcessSession

One-To-Many Relationship: [msdyn_inventoryadjustmentproduct msdyn_inventoryadjustmentproduct_ProcessSession](msdyn_inventoryadjustmentproduct.md#BKMK_msdyn_inventoryadjustmentproduct_ProcessSession)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_inventoryadjustmentproduct`|
|ReferencedAttribute|`msdyn_inventoryadjustmentproductid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_inventoryadjustmentproduct`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_inventoryjournal_ProcessSession"></a> msdyn_inventoryjournal_ProcessSession

One-To-Many Relationship: [msdyn_inventoryjournal msdyn_inventoryjournal_ProcessSession](msdyn_inventoryjournal.md#BKMK_msdyn_inventoryjournal_ProcessSession)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_inventoryjournal`|
|ReferencedAttribute|`msdyn_inventoryjournalid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_inventoryjournal`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_inventorytransfer_ProcessSession"></a> msdyn_inventorytransfer_ProcessSession

One-To-Many Relationship: [msdyn_inventorytransfer msdyn_inventorytransfer_ProcessSession](msdyn_inventorytransfer.md#BKMK_msdyn_inventorytransfer_ProcessSession)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_inventorytransfer`|
|ReferencedAttribute|`msdyn_inventorytransferid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_inventorytransfer`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_mobilesource_ProcessSession"></a> msdyn_mobilesource_ProcessSession

One-To-Many Relationship: [msdyn_mobilesource msdyn_mobilesource_ProcessSession](msdyn_mobilesource.md#BKMK_msdyn_mobilesource_ProcessSession)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_mobilesource`|
|ReferencedAttribute|`msdyn_mobilesourceid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_mobilesource`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_nottoexceed_ProcessSession"></a> msdyn_nottoexceed_ProcessSession

One-To-Many Relationship: [msdyn_nottoexceed msdyn_nottoexceed_ProcessSession](msdyn_nottoexceed.md#BKMK_msdyn_nottoexceed_ProcessSession)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_nottoexceed`|
|ReferencedAttribute|`msdyn_nottoexceedid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_nottoexceed`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_orderinvoicingdate_ProcessSession"></a> msdyn_orderinvoicingdate_ProcessSession

One-To-Many Relationship: [msdyn_orderinvoicingdate msdyn_orderinvoicingdate_ProcessSession](msdyn_orderinvoicingdate.md#BKMK_msdyn_orderinvoicingdate_ProcessSession)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_orderinvoicingdate`|
|ReferencedAttribute|`msdyn_orderinvoicingdateid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_orderinvoicingdate`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_orderinvoicingproduct_ProcessSession"></a> msdyn_orderinvoicingproduct_ProcessSession

One-To-Many Relationship: [msdyn_orderinvoicingproduct msdyn_orderinvoicingproduct_ProcessSession](msdyn_orderinvoicingproduct.md#BKMK_msdyn_orderinvoicingproduct_ProcessSession)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_orderinvoicingproduct`|
|ReferencedAttribute|`msdyn_orderinvoicingproductid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_orderinvoicingproduct`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_orderinvoicingsetup_ProcessSession"></a> msdyn_orderinvoicingsetup_ProcessSession

One-To-Many Relationship: [msdyn_orderinvoicingsetup msdyn_orderinvoicingsetup_ProcessSession](msdyn_orderinvoicingsetup.md#BKMK_msdyn_orderinvoicingsetup_ProcessSession)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_orderinvoicingsetup`|
|ReferencedAttribute|`msdyn_orderinvoicingsetupid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_orderinvoicingsetup`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_orderinvoicingsetupdate_ProcessSession"></a> msdyn_orderinvoicingsetupdate_ProcessSession

One-To-Many Relationship: [msdyn_orderinvoicingsetupdate msdyn_orderinvoicingsetupdate_ProcessSession](msdyn_orderinvoicingsetupdate.md#BKMK_msdyn_orderinvoicingsetupdate_ProcessSession)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_orderinvoicingsetupdate`|
|ReferencedAttribute|`msdyn_orderinvoicingsetupdateid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_orderinvoicingsetupdate`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_organizationalunit_ProcessSession"></a> msdyn_organizationalunit_ProcessSession

One-To-Many Relationship: [msdyn_organizationalunit msdyn_organizationalunit_ProcessSession](msdyn_organizationalunit.md#BKMK_msdyn_organizationalunit_ProcessSession)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_organizationalunit`|
|ReferencedAttribute|`msdyn_organizationalunitid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_organizationalunit`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_payment_ProcessSession"></a> msdyn_payment_ProcessSession

One-To-Many Relationship: [msdyn_payment msdyn_payment_ProcessSession](msdyn_payment.md#BKMK_msdyn_payment_ProcessSession)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_payment`|
|ReferencedAttribute|`msdyn_paymentid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_payment`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_paymentdetail_ProcessSession"></a> msdyn_paymentdetail_ProcessSession

One-To-Many Relationship: [msdyn_paymentdetail msdyn_paymentdetail_ProcessSession](msdyn_paymentdetail.md#BKMK_msdyn_paymentdetail_ProcessSession)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_paymentdetail`|
|ReferencedAttribute|`msdyn_paymentdetailid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_paymentdetail`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_paymentmethod_ProcessSession"></a> msdyn_paymentmethod_ProcessSession

One-To-Many Relationship: [msdyn_paymentmethod msdyn_paymentmethod_ProcessSession](msdyn_paymentmethod.md#BKMK_msdyn_paymentmethod_ProcessSession)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_paymentmethod`|
|ReferencedAttribute|`msdyn_paymentmethodid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_paymentmethod`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_paymentterm_ProcessSession"></a> msdyn_paymentterm_ProcessSession

One-To-Many Relationship: [msdyn_paymentterm msdyn_paymentterm_ProcessSession](msdyn_paymentterm.md#BKMK_msdyn_paymentterm_ProcessSession)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_paymentterm`|
|ReferencedAttribute|`msdyn_paymenttermid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_paymentterm`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_postalcode_ProcessSession"></a> msdyn_postalcode_ProcessSession

One-To-Many Relationship: [msdyn_postalcode msdyn_postalcode_ProcessSession](msdyn_postalcode.md#BKMK_msdyn_postalcode_ProcessSession)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_postalcode`|
|ReferencedAttribute|`msdyn_postalcodeid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_postalcode`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_predictworkhourdurationsetting_ProcessSession"></a> msdyn_predictworkhourdurationsetting_ProcessSession

One-To-Many Relationship: [msdyn_predictworkhourdurationsetting msdyn_predictworkhourdurationsetting_ProcessSession](msdyn_predictworkhourdurationsetting.md#BKMK_msdyn_predictworkhourdurationsetting_ProcessSession)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_predictworkhourdurationsetting`|
|ReferencedAttribute|`msdyn_predictworkhourdurationsettingid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_predictworkhourdurationsetting`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_priority_ProcessSession"></a> msdyn_priority_ProcessSession

One-To-Many Relationship: [msdyn_priority msdyn_priority_ProcessSession](msdyn_priority.md#BKMK_msdyn_priority_ProcessSession)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_priority`|
|ReferencedAttribute|`msdyn_priorityid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_priority`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_problematicasset_ProcessSession"></a> msdyn_problematicasset_ProcessSession

One-To-Many Relationship: [msdyn_problematicasset msdyn_problematicasset_ProcessSession](msdyn_problematicasset.md#BKMK_msdyn_problematicasset_ProcessSession)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_problematicasset`|
|ReferencedAttribute|`msdyn_problematicassetid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_problematicasset`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_problematicassetfeedback_ProcessSession"></a> msdyn_problematicassetfeedback_ProcessSession

One-To-Many Relationship: [msdyn_problematicassetfeedback msdyn_problematicassetfeedback_ProcessSession](msdyn_problematicassetfeedback.md#BKMK_msdyn_problematicassetfeedback_ProcessSession)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_problematicassetfeedback`|
|ReferencedAttribute|`msdyn_problematicassetfeedbackid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_problematicassetfeedback`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_productinventory_ProcessSession"></a> msdyn_productinventory_ProcessSession

One-To-Many Relationship: [msdyn_productinventory msdyn_productinventory_ProcessSession](msdyn_productinventory.md#BKMK_msdyn_productinventory_ProcessSession)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_productinventory`|
|ReferencedAttribute|`msdyn_productinventoryid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_productinventory`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_purchaseorder_ProcessSession"></a> msdyn_purchaseorder_ProcessSession

One-To-Many Relationship: [msdyn_purchaseorder msdyn_purchaseorder_ProcessSession](msdyn_purchaseorder.md#BKMK_msdyn_purchaseorder_ProcessSession)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_purchaseorder`|
|ReferencedAttribute|`msdyn_purchaseorderid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_purchaseorder`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_purchaseorderbill_ProcessSession"></a> msdyn_purchaseorderbill_ProcessSession

One-To-Many Relationship: [msdyn_purchaseorderbill msdyn_purchaseorderbill_ProcessSession](msdyn_purchaseorderbill.md#BKMK_msdyn_purchaseorderbill_ProcessSession)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_purchaseorderbill`|
|ReferencedAttribute|`msdyn_purchaseorderbillid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_purchaseorderbill`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_purchaseorderproduct_ProcessSession"></a> msdyn_purchaseorderproduct_ProcessSession

One-To-Many Relationship: [msdyn_purchaseorderproduct msdyn_purchaseorderproduct_ProcessSession](msdyn_purchaseorderproduct.md#BKMK_msdyn_purchaseorderproduct_ProcessSession)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_purchaseorderproduct`|
|ReferencedAttribute|`msdyn_purchaseorderproductid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_purchaseorderproduct`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_purchaseorderreceipt_ProcessSession"></a> msdyn_purchaseorderreceipt_ProcessSession

One-To-Many Relationship: [msdyn_purchaseorderreceipt msdyn_purchaseorderreceipt_ProcessSession](msdyn_purchaseorderreceipt.md#BKMK_msdyn_purchaseorderreceipt_ProcessSession)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_purchaseorderreceipt`|
|ReferencedAttribute|`msdyn_purchaseorderreceiptid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_purchaseorderreceipt`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_purchaseorderreceiptproduct_ProcessSession"></a> msdyn_purchaseorderreceiptproduct_ProcessSession

One-To-Many Relationship: [msdyn_purchaseorderreceiptproduct msdyn_purchaseorderreceiptproduct_ProcessSession](msdyn_purchaseorderreceiptproduct.md#BKMK_msdyn_purchaseorderreceiptproduct_ProcessSession)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_purchaseorderreceiptproduct`|
|ReferencedAttribute|`msdyn_purchaseorderreceiptproductid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_purchaseorderreceiptproduct`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_purchaseordersubstatus_ProcessSession"></a> msdyn_purchaseordersubstatus_ProcessSession

One-To-Many Relationship: [msdyn_purchaseordersubstatus msdyn_purchaseordersubstatus_ProcessSession](msdyn_purchaseordersubstatus.md#BKMK_msdyn_purchaseordersubstatus_ProcessSession)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_purchaseordersubstatus`|
|ReferencedAttribute|`msdyn_purchaseordersubstatusid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_purchaseordersubstatus`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_quotebookingincident_ProcessSession"></a> msdyn_quotebookingincident_ProcessSession

One-To-Many Relationship: [msdyn_quotebookingincident msdyn_quotebookingincident_ProcessSession](msdyn_quotebookingincident.md#BKMK_msdyn_quotebookingincident_ProcessSession)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_quotebookingincident`|
|ReferencedAttribute|`msdyn_quotebookingincidentid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_quotebookingincident`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_quotebookingproduct_ProcessSession"></a> msdyn_quotebookingproduct_ProcessSession

One-To-Many Relationship: [msdyn_quotebookingproduct msdyn_quotebookingproduct_ProcessSession](msdyn_quotebookingproduct.md#BKMK_msdyn_quotebookingproduct_ProcessSession)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_quotebookingproduct`|
|ReferencedAttribute|`msdyn_quotebookingproductid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_quotebookingproduct`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_quotebookingservice_ProcessSession"></a> msdyn_quotebookingservice_ProcessSession

One-To-Many Relationship: [msdyn_quotebookingservice msdyn_quotebookingservice_ProcessSession](msdyn_quotebookingservice.md#BKMK_msdyn_quotebookingservice_ProcessSession)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_quotebookingservice`|
|ReferencedAttribute|`msdyn_quotebookingserviceid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_quotebookingservice`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_quotebookingservicetask_ProcessSession"></a> msdyn_quotebookingservicetask_ProcessSession

One-To-Many Relationship: [msdyn_quotebookingservicetask msdyn_quotebookingservicetask_ProcessSession](msdyn_quotebookingservicetask.md#BKMK_msdyn_quotebookingservicetask_ProcessSession)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_quotebookingservicetask`|
|ReferencedAttribute|`msdyn_quotebookingservicetaskid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_quotebookingservicetask`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_quotebookingsetup_ProcessSession"></a> msdyn_quotebookingsetup_ProcessSession

One-To-Many Relationship: [msdyn_quotebookingsetup msdyn_quotebookingsetup_ProcessSession](msdyn_quotebookingsetup.md#BKMK_msdyn_quotebookingsetup_ProcessSession)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_quotebookingsetup`|
|ReferencedAttribute|`msdyn_quotebookingsetupid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_quotebookingsetup`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_quoteinvoicingproduct_ProcessSession"></a> msdyn_quoteinvoicingproduct_ProcessSession

One-To-Many Relationship: [msdyn_quoteinvoicingproduct msdyn_quoteinvoicingproduct_ProcessSession](msdyn_quoteinvoicingproduct.md#BKMK_msdyn_quoteinvoicingproduct_ProcessSession)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_quoteinvoicingproduct`|
|ReferencedAttribute|`msdyn_quoteinvoicingproductid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_quoteinvoicingproduct`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_quoteinvoicingsetup_ProcessSession"></a> msdyn_quoteinvoicingsetup_ProcessSession

One-To-Many Relationship: [msdyn_quoteinvoicingsetup msdyn_quoteinvoicingsetup_ProcessSession](msdyn_quoteinvoicingsetup.md#BKMK_msdyn_quoteinvoicingsetup_ProcessSession)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_quoteinvoicingsetup`|
|ReferencedAttribute|`msdyn_quoteinvoicingsetupid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_quoteinvoicingsetup`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_requirementchange_ProcessSession"></a> msdyn_requirementchange_ProcessSession

One-To-Many Relationship: [msdyn_requirementchange msdyn_requirementchange_ProcessSession](msdyn_requirementchange.md#BKMK_msdyn_requirementchange_ProcessSession)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_requirementchange`|
|ReferencedAttribute|`msdyn_requirementchangeid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_requirementchange`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_requirementcharacteristic_ProcessSession"></a> msdyn_requirementcharacteristic_ProcessSession

One-To-Many Relationship: [msdyn_requirementcharacteristic msdyn_requirementcharacteristic_ProcessSession](msdyn_requirementcharacteristic.md#BKMK_msdyn_requirementcharacteristic_ProcessSession)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_requirementcharacteristic`|
|ReferencedAttribute|`msdyn_requirementcharacteristicid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_requirementcharacteristic`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_requirementdependency_ProcessSession"></a> msdyn_requirementdependency_ProcessSession

One-To-Many Relationship: [msdyn_requirementdependency msdyn_requirementdependency_ProcessSession](msdyn_requirementdependency.md#BKMK_msdyn_requirementdependency_ProcessSession)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_requirementdependency`|
|ReferencedAttribute|`msdyn_requirementdependencyid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_requirementdependency`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_requirementgroup_ProcessSession"></a> msdyn_requirementgroup_ProcessSession

One-To-Many Relationship: [msdyn_requirementgroup msdyn_requirementgroup_ProcessSession](msdyn_requirementgroup.md#BKMK_msdyn_requirementgroup_ProcessSession)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_requirementgroup`|
|ReferencedAttribute|`msdyn_requirementgroupid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_requirementgroup`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_requirementorganizationunit_ProcessSession"></a> msdyn_requirementorganizationunit_ProcessSession

One-To-Many Relationship: [msdyn_requirementorganizationunit msdyn_requirementorganizationunit_ProcessSession](msdyn_requirementorganizationunit.md#BKMK_msdyn_requirementorganizationunit_ProcessSession)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_requirementorganizationunit`|
|ReferencedAttribute|`msdyn_requirementorganizationunitid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_requirementorganizationunit`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_requirementrelationship_ProcessSession"></a> msdyn_requirementrelationship_ProcessSession

One-To-Many Relationship: [msdyn_requirementrelationship msdyn_requirementrelationship_ProcessSession](msdyn_requirementrelationship.md#BKMK_msdyn_requirementrelationship_ProcessSession)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_requirementrelationship`|
|ReferencedAttribute|`msdyn_requirementrelationshipid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_requirementrelationship`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_requirementresourcecategory_ProcessSession"></a> msdyn_requirementresourcecategory_ProcessSession

One-To-Many Relationship: [msdyn_requirementresourcecategory msdyn_requirementresourcecategory_ProcessSession](msdyn_requirementresourcecategory.md#BKMK_msdyn_requirementresourcecategory_ProcessSession)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_requirementresourcecategory`|
|ReferencedAttribute|`msdyn_requirementresourcecategoryid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_requirementresourcecategory`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_requirementresourcepreference_ProcessSession"></a> msdyn_requirementresourcepreference_ProcessSession

One-To-Many Relationship: [msdyn_requirementresourcepreference msdyn_requirementresourcepreference_ProcessSession](msdyn_requirementresourcepreference.md#BKMK_msdyn_requirementresourcepreference_ProcessSession)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_requirementresourcepreference`|
|ReferencedAttribute|`msdyn_requirementresourcepreferenceid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_requirementresourcepreference`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_requirementstatus_ProcessSession"></a> msdyn_requirementstatus_ProcessSession

One-To-Many Relationship: [msdyn_requirementstatus msdyn_requirementstatus_ProcessSession](msdyn_requirementstatus.md#BKMK_msdyn_requirementstatus_ProcessSession)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_requirementstatus`|
|ReferencedAttribute|`msdyn_requirementstatusid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_requirementstatus`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_resolution_ProcessSession"></a> msdyn_resolution_ProcessSession

One-To-Many Relationship: [msdyn_resolution msdyn_resolution_ProcessSession](msdyn_resolution.md#BKMK_msdyn_resolution_ProcessSession)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_resolution`|
|ReferencedAttribute|`msdyn_resolutionid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_resolution`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_resourcepaytype_ProcessSession"></a> msdyn_resourcepaytype_ProcessSession

One-To-Many Relationship: [msdyn_resourcepaytype msdyn_resourcepaytype_ProcessSession](msdyn_resourcepaytype.md#BKMK_msdyn_resourcepaytype_ProcessSession)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_resourcepaytype`|
|ReferencedAttribute|`msdyn_resourcepaytypeid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_resourcepaytype`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_resourcerequirement_ProcessSession"></a> msdyn_resourcerequirement_ProcessSession

One-To-Many Relationship: [msdyn_resourcerequirement msdyn_resourcerequirement_ProcessSession](msdyn_resourcerequirement.md#BKMK_msdyn_resourcerequirement_ProcessSession)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_resourcerequirement`|
|ReferencedAttribute|`msdyn_resourcerequirementid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_resourcerequirement`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_resourcerequirementdetail_ProcessSession"></a> msdyn_resourcerequirementdetail_ProcessSession

One-To-Many Relationship: [msdyn_resourcerequirementdetail msdyn_resourcerequirementdetail_ProcessSession](msdyn_resourcerequirementdetail.md#BKMK_msdyn_resourcerequirementdetail_ProcessSession)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_resourcerequirementdetail`|
|ReferencedAttribute|`msdyn_resourcerequirementdetailid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_resourcerequirementdetail`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_resourceterritory_ProcessSession"></a> msdyn_resourceterritory_ProcessSession

One-To-Many Relationship: [msdyn_resourceterritory msdyn_resourceterritory_ProcessSession](msdyn_resourceterritory.md#BKMK_msdyn_resourceterritory_ProcessSession)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_resourceterritory`|
|ReferencedAttribute|`msdyn_resourceterritoryid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_resourceterritory`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_rma_ProcessSession"></a> msdyn_rma_ProcessSession

One-To-Many Relationship: [msdyn_rma msdyn_rma_ProcessSession](msdyn_rma.md#BKMK_msdyn_rma_ProcessSession)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_rma`|
|ReferencedAttribute|`msdyn_rmaid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_rma`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_rmaproduct_ProcessSession"></a> msdyn_rmaproduct_ProcessSession

One-To-Many Relationship: [msdyn_rmaproduct msdyn_rmaproduct_ProcessSession](msdyn_rmaproduct.md#BKMK_msdyn_rmaproduct_ProcessSession)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_rmaproduct`|
|ReferencedAttribute|`msdyn_rmaproductid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_rmaproduct`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_rmareceipt_ProcessSession"></a> msdyn_rmareceipt_ProcessSession

One-To-Many Relationship: [msdyn_rmareceipt msdyn_rmareceipt_ProcessSession](msdyn_rmareceipt.md#BKMK_msdyn_rmareceipt_ProcessSession)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_rmareceipt`|
|ReferencedAttribute|`msdyn_rmareceiptid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_rmareceipt`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_rmareceiptproduct_ProcessSession"></a> msdyn_rmareceiptproduct_ProcessSession

One-To-Many Relationship: [msdyn_rmareceiptproduct msdyn_rmareceiptproduct_ProcessSession](msdyn_rmareceiptproduct.md#BKMK_msdyn_rmareceiptproduct_ProcessSession)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_rmareceiptproduct`|
|ReferencedAttribute|`msdyn_rmareceiptproductid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_rmareceiptproduct`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_rmasubstatus_ProcessSession"></a> msdyn_rmasubstatus_ProcessSession

One-To-Many Relationship: [msdyn_rmasubstatus msdyn_rmasubstatus_ProcessSession](msdyn_rmasubstatus.md#BKMK_msdyn_rmasubstatus_ProcessSession)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_rmasubstatus`|
|ReferencedAttribute|`msdyn_rmasubstatusid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_rmasubstatus`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_rtv_ProcessSession"></a> msdyn_rtv_ProcessSession

One-To-Many Relationship: [msdyn_rtv msdyn_rtv_ProcessSession](msdyn_rtv.md#BKMK_msdyn_rtv_ProcessSession)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_rtv`|
|ReferencedAttribute|`msdyn_rtvid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_rtv`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_rtvproduct_ProcessSession"></a> msdyn_rtvproduct_ProcessSession

One-To-Many Relationship: [msdyn_rtvproduct msdyn_rtvproduct_ProcessSession](msdyn_rtvproduct.md#BKMK_msdyn_rtvproduct_ProcessSession)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_rtvproduct`|
|ReferencedAttribute|`msdyn_rtvproductid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_rtvproduct`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_rtvsubstatus_ProcessSession"></a> msdyn_rtvsubstatus_ProcessSession

One-To-Many Relationship: [msdyn_rtvsubstatus msdyn_rtvsubstatus_ProcessSession](msdyn_rtvsubstatus.md#BKMK_msdyn_rtvsubstatus_ProcessSession)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_rtvsubstatus`|
|ReferencedAttribute|`msdyn_rtvsubstatusid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_rtvsubstatus`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_scheduleboardsetting_ProcessSession"></a> msdyn_scheduleboardsetting_ProcessSession

One-To-Many Relationship: [msdyn_scheduleboardsetting msdyn_scheduleboardsetting_ProcessSession](msdyn_scheduleboardsetting.md#BKMK_msdyn_scheduleboardsetting_ProcessSession)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_scheduleboardsetting`|
|ReferencedAttribute|`msdyn_scheduleboardsettingid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_scheduleboardsetting`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_schedulingfeatureflag_ProcessSession"></a> msdyn_schedulingfeatureflag_ProcessSession

One-To-Many Relationship: [msdyn_schedulingfeatureflag msdyn_schedulingfeatureflag_ProcessSession](msdyn_schedulingfeatureflag.md#BKMK_msdyn_schedulingfeatureflag_ProcessSession)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_schedulingfeatureflag`|
|ReferencedAttribute|`msdyn_schedulingfeatureflagid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_schedulingfeatureflag`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_schedulingparameter_ProcessSession"></a> msdyn_schedulingparameter_ProcessSession

One-To-Many Relationship: [msdyn_schedulingparameter msdyn_schedulingparameter_ProcessSession](msdyn_schedulingparameter.md#BKMK_msdyn_schedulingparameter_ProcessSession)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_schedulingparameter`|
|ReferencedAttribute|`msdyn_schedulingparameterid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_schedulingparameter`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_servicetasktype_ProcessSession"></a> msdyn_servicetasktype_ProcessSession

One-To-Many Relationship: [msdyn_servicetasktype msdyn_servicetasktype_ProcessSession](msdyn_servicetasktype.md#BKMK_msdyn_servicetasktype_ProcessSession)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_servicetasktype`|
|ReferencedAttribute|`msdyn_servicetasktypeid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_servicetasktype`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_shipvia_ProcessSession"></a> msdyn_shipvia_ProcessSession

One-To-Many Relationship: [msdyn_shipvia msdyn_shipvia_ProcessSession](msdyn_shipvia.md#BKMK_msdyn_shipvia_ProcessSession)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_shipvia`|
|ReferencedAttribute|`msdyn_shipviaid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_shipvia`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_systemuserschedulersetting_ProcessSession"></a> msdyn_systemuserschedulersetting_ProcessSession

One-To-Many Relationship: [msdyn_systemuserschedulersetting msdyn_systemuserschedulersetting_ProcessSession](msdyn_systemuserschedulersetting.md#BKMK_msdyn_systemuserschedulersetting_ProcessSession)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_systemuserschedulersetting`|
|ReferencedAttribute|`msdyn_systemuserschedulersettingid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_systemuserschedulersetting`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_taxcode_ProcessSession"></a> msdyn_taxcode_ProcessSession

One-To-Many Relationship: [msdyn_taxcode msdyn_taxcode_ProcessSession](msdyn_taxcode.md#BKMK_msdyn_taxcode_ProcessSession)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_taxcode`|
|ReferencedAttribute|`msdyn_taxcodeid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_taxcode`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_taxcodedetail_ProcessSession"></a> msdyn_taxcodedetail_ProcessSession

One-To-Many Relationship: [msdyn_taxcodedetail msdyn_taxcodedetail_ProcessSession](msdyn_taxcodedetail.md#BKMK_msdyn_taxcodedetail_ProcessSession)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_taxcodedetail`|
|ReferencedAttribute|`msdyn_taxcodedetailid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_taxcodedetail`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_timeentry_ProcessSession"></a> msdyn_timeentry_ProcessSession

One-To-Many Relationship: [msdyn_timeentry msdyn_timeentry_ProcessSession](msdyn_timeentry.md#BKMK_msdyn_timeentry_ProcessSession)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_timeentry`|
|ReferencedAttribute|`msdyn_timeentryid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_timeentry`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_timeentrysetting_ProcessSession"></a> msdyn_timeentrysetting_ProcessSession

One-To-Many Relationship: [msdyn_timeentrysetting msdyn_timeentrysetting_ProcessSession](msdyn_timeentrysetting.md#BKMK_msdyn_timeentrysetting_ProcessSession)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_timeentrysetting`|
|ReferencedAttribute|`msdyn_timeentrysettingid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_timeentrysetting`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_timegroup_ProcessSession"></a> msdyn_timegroup_ProcessSession

One-To-Many Relationship: [msdyn_timegroup msdyn_timegroup_ProcessSession](msdyn_timegroup.md#BKMK_msdyn_timegroup_ProcessSession)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_timegroup`|
|ReferencedAttribute|`msdyn_timegroupid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_timegroup`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_timegroupdetail_ProcessSession"></a> msdyn_timegroupdetail_ProcessSession

One-To-Many Relationship: [msdyn_timegroupdetail msdyn_timegroupdetail_ProcessSession](msdyn_timegroupdetail.md#BKMK_msdyn_timegroupdetail_ProcessSession)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_timegroupdetail`|
|ReferencedAttribute|`msdyn_timegroupdetailid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_timegroupdetail`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_timeoffrequest_ProcessSession"></a> msdyn_timeoffrequest_ProcessSession

One-To-Many Relationship: [msdyn_timeoffrequest msdyn_timeoffrequest_ProcessSession](msdyn_timeoffrequest.md#BKMK_msdyn_timeoffrequest_ProcessSession)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_timeoffrequest`|
|ReferencedAttribute|`msdyn_timeoffrequestid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_timeoffrequest`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_trade_ProcessSession"></a> msdyn_trade_ProcessSession

One-To-Many Relationship: [msdyn_trade msdyn_trade_ProcessSession](msdyn_trade.md#BKMK_msdyn_trade_ProcessSession)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_trade`|
|ReferencedAttribute|`msdyn_tradeid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_trade`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_tradecoverage_ProcessSession"></a> msdyn_tradecoverage_ProcessSession

One-To-Many Relationship: [msdyn_tradecoverage msdyn_tradecoverage_ProcessSession](msdyn_tradecoverage.md#BKMK_msdyn_tradecoverage_ProcessSession)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_tradecoverage`|
|ReferencedAttribute|`msdyn_tradecoverageid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_tradecoverage`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_transactionorigin_ProcessSession"></a> msdyn_transactionorigin_ProcessSession

One-To-Many Relationship: [msdyn_transactionorigin msdyn_transactionorigin_ProcessSession](msdyn_transactionorigin.md#BKMK_msdyn_transactionorigin_ProcessSession)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_transactionorigin`|
|ReferencedAttribute|`msdyn_transactionoriginid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_transactionorigin`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_uniquenumber_ProcessSession"></a> msdyn_uniquenumber_ProcessSession

One-To-Many Relationship: [msdyn_uniquenumber msdyn_uniquenumber_ProcessSession](msdyn_uniquenumber.md#BKMK_msdyn_uniquenumber_ProcessSession)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_uniquenumber`|
|ReferencedAttribute|`msdyn_uniquenumberid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_uniquenumber`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_warehouse_ProcessSession"></a> msdyn_warehouse_ProcessSession

One-To-Many Relationship: [msdyn_warehouse msdyn_warehouse_ProcessSession](msdyn_warehouse.md#BKMK_msdyn_warehouse_ProcessSession)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_warehouse`|
|ReferencedAttribute|`msdyn_warehouseid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_warehouse`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_workhourtemplate_ProcessSession"></a> msdyn_workhourtemplate_ProcessSession

One-To-Many Relationship: [msdyn_workhourtemplate msdyn_workhourtemplate_ProcessSession](msdyn_workhourtemplate.md#BKMK_msdyn_workhourtemplate_ProcessSession)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_workhourtemplate`|
|ReferencedAttribute|`msdyn_workhourtemplateid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_workhourtemplate`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_workorder_ProcessSession"></a> msdyn_workorder_ProcessSession

One-To-Many Relationship: [msdyn_workorder msdyn_workorder_ProcessSession](msdyn_workorder.md#BKMK_msdyn_workorder_ProcessSession)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_workorder`|
|ReferencedAttribute|`msdyn_workorderid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_workorder`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_workordercharacteristic_ProcessSession"></a> msdyn_workordercharacteristic_ProcessSession

One-To-Many Relationship: [msdyn_workordercharacteristic msdyn_workordercharacteristic_ProcessSession](msdyn_workordercharacteristic.md#BKMK_msdyn_workordercharacteristic_ProcessSession)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_workordercharacteristic`|
|ReferencedAttribute|`msdyn_workordercharacteristicid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_workordercharacteristic`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_workorderdetailsgenerationqueue_ProcessSession"></a> msdyn_workorderdetailsgenerationqueue_ProcessSession

One-To-Many Relationship: [msdyn_workorderdetailsgenerationqueue msdyn_workorderdetailsgenerationqueue_ProcessSession](msdyn_workorderdetailsgenerationqueue.md#BKMK_msdyn_workorderdetailsgenerationqueue_ProcessSession)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_workorderdetailsgenerationqueue`|
|ReferencedAttribute|`msdyn_workorderdetailsgenerationqueueid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_workorderdetailsgenerationqueue`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_workorderincident_ProcessSession"></a> msdyn_workorderincident_ProcessSession

One-To-Many Relationship: [msdyn_workorderincident msdyn_workorderincident_ProcessSession](msdyn_workorderincident.md#BKMK_msdyn_workorderincident_ProcessSession)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_workorderincident`|
|ReferencedAttribute|`msdyn_workorderincidentid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_workorderincident`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_workordernte_ProcessSession"></a> msdyn_workordernte_ProcessSession

One-To-Many Relationship: [msdyn_workordernte msdyn_workordernte_ProcessSession](msdyn_workordernte.md#BKMK_msdyn_workordernte_ProcessSession)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_workordernte`|
|ReferencedAttribute|`msdyn_workordernteid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_workordernte`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_workorderproduct_ProcessSession"></a> msdyn_workorderproduct_ProcessSession

One-To-Many Relationship: [msdyn_workorderproduct msdyn_workorderproduct_ProcessSession](msdyn_workorderproduct.md#BKMK_msdyn_workorderproduct_ProcessSession)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_workorderproduct`|
|ReferencedAttribute|`msdyn_workorderproductid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_workorderproduct`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_workorderresolution_ProcessSession"></a> msdyn_workorderresolution_ProcessSession

One-To-Many Relationship: [msdyn_workorderresolution msdyn_workorderresolution_ProcessSession](msdyn_workorderresolution.md#BKMK_msdyn_workorderresolution_ProcessSession)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_workorderresolution`|
|ReferencedAttribute|`msdyn_workorderresolutionid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_workorderresolution`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_workorderresourcerestriction_ProcessSession"></a> msdyn_workorderresourcerestriction_ProcessSession

One-To-Many Relationship: [msdyn_workorderresourcerestriction msdyn_workorderresourcerestriction_ProcessSession](msdyn_workorderresourcerestriction.md#BKMK_msdyn_workorderresourcerestriction_ProcessSession)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_workorderresourcerestriction`|
|ReferencedAttribute|`msdyn_workorderresourcerestrictionid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_workorderresourcerestriction`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_workorderservice_ProcessSession"></a> msdyn_workorderservice_ProcessSession

One-To-Many Relationship: [msdyn_workorderservice msdyn_workorderservice_ProcessSession](msdyn_workorderservice.md#BKMK_msdyn_workorderservice_ProcessSession)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_workorderservice`|
|ReferencedAttribute|`msdyn_workorderserviceid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_workorderservice`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_workorderservicetask_ProcessSession"></a> msdyn_workorderservicetask_ProcessSession

One-To-Many Relationship: [msdyn_workorderservicetask msdyn_workorderservicetask_ProcessSession](msdyn_workorderservicetask.md#BKMK_msdyn_workorderservicetask_ProcessSession)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_workorderservicetask`|
|ReferencedAttribute|`msdyn_workorderservicetaskid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_workorderservicetask`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_workordersubstatus_ProcessSession"></a> msdyn_workordersubstatus_ProcessSession

One-To-Many Relationship: [msdyn_workordersubstatus msdyn_workordersubstatus_ProcessSession](msdyn_workordersubstatus.md#BKMK_msdyn_workordersubstatus_ProcessSession)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_workordersubstatus`|
|ReferencedAttribute|`msdyn_workordersubstatusid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_workordersubstatus`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_workordertype_ProcessSession"></a> msdyn_workordertype_ProcessSession

One-To-Many Relationship: [msdyn_workordertype msdyn_workordertype_ProcessSession](msdyn_workordertype.md#BKMK_msdyn_workordertype_ProcessSession)

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
<xref:Microsoft.Dynamics.CRM.processsession?displayProperty=fullName>
