---
title: "Field Sharing (PrincipalObjectAttributeAccess) table/entity reference (Microsoft Dynamics 365 Field Service)"
description: "Includes schema information and supported messages for the Field Sharing (PrincipalObjectAttributeAccess) table/entity with Microsoft Dynamics 365 Field Service."
ms.date: 08/21/2024
ms.service: powerapps
ms.topic: reference
author: m-hartmann
ms.author: mhart
search.audienceType: 
  - developer
---

# Field Sharing (PrincipalObjectAttributeAccess) table/entity reference

Defines CRM security principals (users and teams) access rights to secured field for an entity instance.

> [!NOTE]
> The Microsoft Dynamics 365 Field Service Field Sharing (PrincipalObjectAttributeAccess) table extends the [Microsoft Dataverse Field Sharing (PrincipalObjectAttributeAccess) table](/power-apps/developer/data-platform/reference/entities/principalobjectattributeaccess).



## Customized columns/attributes

Microsoft Dynamics 365 Field Service modifies the definition of columns/attributes defined in other solutions. Listed by **SchemaName**.

### <a name="BKMK_ObjectId"></a> ObjectId

Changes from [ObjectId (Microsoft Dataverse)](/power-apps/developer/data-platform/reference/entities/principalobjectattributeaccess#BKMK_ObjectId)

|Property|Value|
|---|---|
|Targets|msdyn_3dmodel|


## Many-to-One relationships

These relationships are many-to-one. Listed by **SchemaName**.

- [msdyn_3dmodel_PrincipalObjectAttributeAccesses](#BKMK_msdyn_3dmodel_PrincipalObjectAttributeAccesses)
- [msdyn_actual_PrincipalObjectAttributeAccesses](#BKMK_msdyn_actual_PrincipalObjectAttributeAccesses)
- [msdyn_agreement_PrincipalObjectAttributeAccesses](#BKMK_msdyn_agreement_PrincipalObjectAttributeAccesses)
- [msdyn_agreementbookingdate_PrincipalObjectAttributeAccesses](#BKMK_msdyn_agreementbookingdate_PrincipalObjectAttributeAccesses)
- [msdyn_agreementbookingincident_PrincipalObjectAttributeAccesses](#BKMK_msdyn_agreementbookingincident_PrincipalObjectAttributeAccesses)
- [msdyn_agreementbookingproduct_PrincipalObjectAttributeAccesses](#BKMK_msdyn_agreementbookingproduct_PrincipalObjectAttributeAccesses)
- [msdyn_agreementbookingservice_PrincipalObjectAttributeAccesses](#BKMK_msdyn_agreementbookingservice_PrincipalObjectAttributeAccesses)
- [msdyn_agreementbookingservicetask_PrincipalObjectAttributeAccesses](#BKMK_msdyn_agreementbookingservicetask_PrincipalObjectAttributeAccesses)
- [msdyn_agreementbookingsetup_PrincipalObjectAttributeAccesses](#BKMK_msdyn_agreementbookingsetup_PrincipalObjectAttributeAccesses)
- [msdyn_agreementinvoicedate_PrincipalObjectAttributeAccesses](#BKMK_msdyn_agreementinvoicedate_PrincipalObjectAttributeAccesses)
- [msdyn_agreementinvoiceproduct_PrincipalObjectAttributeAccesses](#BKMK_msdyn_agreementinvoiceproduct_PrincipalObjectAttributeAccesses)
- [msdyn_agreementinvoicesetup_PrincipalObjectAttributeAccesses](#BKMK_msdyn_agreementinvoicesetup_PrincipalObjectAttributeAccesses)
- [msdyn_agreementsubstatus_PrincipalObjectAttributeAccesses](#BKMK_msdyn_agreementsubstatus_PrincipalObjectAttributeAccesses)
- [msdyn_assetsuggestionssetting_PrincipalObjectAttributeAccesses](#BKMK_msdyn_assetsuggestionssetting_PrincipalObjectAttributeAccesses)
- [msdyn_bookableresourceassociation_PrincipalObjectAttributeAccesses](#BKMK_msdyn_bookableresourceassociation_PrincipalObjectAttributeAccesses)
- [msdyn_bookableresourcebookingquicknote_PrincipalObjectAttributeAccesses](#BKMK_msdyn_bookableresourcebookingquicknote_PrincipalObjectAttributeAccesses)
- [msdyn_bookingalert_PrincipalObjectAttributeAccesses](#BKMK_msdyn_bookingalert_PrincipalObjectAttributeAccesses)
- [msdyn_bookingalertstatus_PrincipalObjectAttributeAccesses](#BKMK_msdyn_bookingalertstatus_PrincipalObjectAttributeAccesses)
- [msdyn_bookingchange_PrincipalObjectAttributeAccesses](#BKMK_msdyn_bookingchange_PrincipalObjectAttributeAccesses)
- [msdyn_bookingjournal_PrincipalObjectAttributeAccesses](#BKMK_msdyn_bookingjournal_PrincipalObjectAttributeAccesses)
- [msdyn_bookingrule_PrincipalObjectAttributeAccesses](#BKMK_msdyn_bookingrule_PrincipalObjectAttributeAccesses)
- [msdyn_bookingsetupmetadata_PrincipalObjectAttributeAccesses](#BKMK_msdyn_bookingsetupmetadata_PrincipalObjectAttributeAccesses)
- [msdyn_bookingtimestamp_PrincipalObjectAttributeAccesses](#BKMK_msdyn_bookingtimestamp_PrincipalObjectAttributeAccesses)
- [msdyn_bpf_2c5fe86acc8b414b8322ae571000c799_PrincipalObjectAttributeAccesses](#BKMK_msdyn_bpf_2c5fe86acc8b414b8322ae571000c799_PrincipalObjectAttributeAccesses)
- [msdyn_bpf_477c16f59170487b8b4dc895c5dcd09b_PrincipalObjectAttributeAccesses](#BKMK_msdyn_bpf_477c16f59170487b8b4dc895c5dcd09b_PrincipalObjectAttributeAccesses)
- [msdyn_bpf_989e9b1857e24af18787d5143b67523b_PrincipalObjectAttributeAccesses](#BKMK_msdyn_bpf_989e9b1857e24af18787d5143b67523b_PrincipalObjectAttributeAccesses)
- [msdyn_bpf_baa0a411a239410cb8bded8b5fdd88e3_PrincipalObjectAttributeAccesses](#BKMK_msdyn_bpf_baa0a411a239410cb8bded8b5fdd88e3_PrincipalObjectAttributeAccesses)
- [msdyn_bpf_d3d97bac8c294105840e99e37a9d1c39_PrincipalObjectAttributeAccesses](#BKMK_msdyn_bpf_d3d97bac8c294105840e99e37a9d1c39_PrincipalObjectAttributeAccesses)
- [msdyn_businessclosure_PrincipalObjectAttributeAccesses](#BKMK_msdyn_businessclosure_PrincipalObjectAttributeAccesses)
- [msdyn_clientextension_PrincipalObjectAttributeAccesses](#BKMK_msdyn_clientextension_PrincipalObjectAttributeAccesses)
- [msdyn_configuration_PrincipalObjectAttributeAccesses](#BKMK_msdyn_configuration_PrincipalObjectAttributeAccesses)
- [msdyn_dataanalyticsreport_fs_PrincipalObjectAttributeAccesses](#BKMK_msdyn_dataanalyticsreport_fs_PrincipalObjectAttributeAccesses)
- [msdyn_dataanalyticsreport_fspredictrs_PrincipalObjectAttributeAccesses](#BKMK_msdyn_dataanalyticsreport_fspredictrs_PrincipalObjectAttributeAccesses)
- [msdyn_dataanalyticsreport_fspredictwhd_PrincipalObjectAttributeAccesses](#BKMK_msdyn_dataanalyticsreport_fspredictwhd_PrincipalObjectAttributeAccesses)
- [msdyn_entitlementapplication_PrincipalObjectAttributeAccesses](#BKMK_msdyn_entitlementapplication_PrincipalObjectAttributeAccesses)
- [msdyn_entityconfiguration_PrincipalObjectAttributeAccesses](#BKMK_msdyn_entityconfiguration_PrincipalObjectAttributeAccesses)
- [msdyn_fieldservicepricelistitem_PrincipalObjectAttributeAccesses](#BKMK_msdyn_fieldservicepricelistitem_PrincipalObjectAttributeAccesses)
- [msdyn_fieldservicesetting_PrincipalObjectAttributeAccesses](#BKMK_msdyn_fieldservicesetting_PrincipalObjectAttributeAccesses)
- [msdyn_fieldserviceslaconfiguration_PrincipalObjectAttributeAccesses](#BKMK_msdyn_fieldserviceslaconfiguration_PrincipalObjectAttributeAccesses)
- [msdyn_fieldservicesummaryconfiguration_PrincipalObjectAttributeAccesses](#BKMK_msdyn_fieldservicesummaryconfiguration_PrincipalObjectAttributeAccesses)
- [msdyn_fieldservicesystemjob_PrincipalObjectAttributeAccesses](#BKMK_msdyn_fieldservicesystemjob_PrincipalObjectAttributeAccesses)
- [msdyn_flwconfiguration_PrincipalObjectAttributeAccesses](#BKMK_msdyn_flwconfiguration_PrincipalObjectAttributeAccesses)
- [msdyn_geofence_PrincipalObjectAttributeAccesses](#BKMK_msdyn_geofence_PrincipalObjectAttributeAccesses)
- [msdyn_geofenceevent_PrincipalObjectAttributeAccesses](#BKMK_msdyn_geofenceevent_PrincipalObjectAttributeAccesses)
- [msdyn_geofencingsettings_PrincipalObjectAttributeAccesses](#BKMK_msdyn_geofencingsettings_PrincipalObjectAttributeAccesses)
- [msdyn_geolocationsettings_PrincipalObjectAttributeAccesses](#BKMK_msdyn_geolocationsettings_PrincipalObjectAttributeAccesses)
- [msdyn_geolocationtracking_PrincipalObjectAttributeAccesses](#BKMK_msdyn_geolocationtracking_PrincipalObjectAttributeAccesses)
- [msdyn_incidenttype_PrincipalObjectAttributeAccesses](#BKMK_msdyn_incidenttype_PrincipalObjectAttributeAccesses)
- [msdyn_incidenttype_requirementgroup_PrincipalObjectAttributeAccesses](#BKMK_msdyn_incidenttype_requirementgroup_PrincipalObjectAttributeAccesses)
- [msdyn_incidenttypecharacteristic_PrincipalObjectAttributeAccesses](#BKMK_msdyn_incidenttypecharacteristic_PrincipalObjectAttributeAccesses)
- [msdyn_incidenttypeproduct_PrincipalObjectAttributeAccesses](#BKMK_msdyn_incidenttypeproduct_PrincipalObjectAttributeAccesses)
- [msdyn_incidenttyperecommendationresult_PrincipalObjectAttributeAccesses](#BKMK_msdyn_incidenttyperecommendationresult_PrincipalObjectAttributeAccesses)
- [msdyn_incidenttyperecommendationrunhistory_PrincipalObjectAttributeAccesses](#BKMK_msdyn_incidenttyperecommendationrunhistory_PrincipalObjectAttributeAccesses)
- [msdyn_incidenttyperesolution_PrincipalObjectAttributeAccesses](#BKMK_msdyn_incidenttyperesolution_PrincipalObjectAttributeAccesses)
- [msdyn_incidenttypeservice_PrincipalObjectAttributeAccesses](#BKMK_msdyn_incidenttypeservice_PrincipalObjectAttributeAccesses)
- [msdyn_incidenttypeservicetask_PrincipalObjectAttributeAccesses](#BKMK_msdyn_incidenttypeservicetask_PrincipalObjectAttributeAccesses)
- [msdyn_incidenttypessetup_PrincipalObjectAttributeAccesses](#BKMK_msdyn_incidenttypessetup_PrincipalObjectAttributeAccesses)
- [msdyn_inspection_PrincipalObjectAttributeAccesses](#BKMK_msdyn_inspection_PrincipalObjectAttributeAccesses)
- [msdyn_inspectionattachment_PrincipalObjectAttributeAccesses](#BKMK_msdyn_inspectionattachment_PrincipalObjectAttributeAccesses)
- [msdyn_inspectiondefinition_PrincipalObjectAttributeAccesses](#BKMK_msdyn_inspectiondefinition_PrincipalObjectAttributeAccesses)
- [msdyn_inspectioninstance_PrincipalObjectAttributeAccesses](#BKMK_msdyn_inspectioninstance_PrincipalObjectAttributeAccesses)
- [msdyn_inspectionresponse_PrincipalObjectAttributeAccesses](#BKMK_msdyn_inspectionresponse_PrincipalObjectAttributeAccesses)
- [msdyn_insurance_PrincipalObjectAttributeAccesses](#BKMK_msdyn_insurance_PrincipalObjectAttributeAccesses)
- [msdyn_inventoryadjustment_PrincipalObjectAttributeAccesses](#BKMK_msdyn_inventoryadjustment_PrincipalObjectAttributeAccesses)
- [msdyn_inventoryadjustmentproduct_PrincipalObjectAttributeAccesses](#BKMK_msdyn_inventoryadjustmentproduct_PrincipalObjectAttributeAccesses)
- [msdyn_inventoryjournal_PrincipalObjectAttributeAccesses](#BKMK_msdyn_inventoryjournal_PrincipalObjectAttributeAccesses)
- [msdyn_inventorytransfer_PrincipalObjectAttributeAccesses](#BKMK_msdyn_inventorytransfer_PrincipalObjectAttributeAccesses)
- [msdyn_mobilesource_PrincipalObjectAttributeAccesses](#BKMK_msdyn_mobilesource_PrincipalObjectAttributeAccesses)
- [msdyn_nottoexceed_PrincipalObjectAttributeAccesses](#BKMK_msdyn_nottoexceed_PrincipalObjectAttributeAccesses)
- [msdyn_orderinvoicingdate_PrincipalObjectAttributeAccesses](#BKMK_msdyn_orderinvoicingdate_PrincipalObjectAttributeAccesses)
- [msdyn_orderinvoicingproduct_PrincipalObjectAttributeAccesses](#BKMK_msdyn_orderinvoicingproduct_PrincipalObjectAttributeAccesses)
- [msdyn_orderinvoicingsetup_PrincipalObjectAttributeAccesses](#BKMK_msdyn_orderinvoicingsetup_PrincipalObjectAttributeAccesses)
- [msdyn_orderinvoicingsetupdate_PrincipalObjectAttributeAccesses](#BKMK_msdyn_orderinvoicingsetupdate_PrincipalObjectAttributeAccesses)
- [msdyn_organizationalunit_PrincipalObjectAttributeAccesses](#BKMK_msdyn_organizationalunit_PrincipalObjectAttributeAccesses)
- [msdyn_payment_PrincipalObjectAttributeAccesses](#BKMK_msdyn_payment_PrincipalObjectAttributeAccesses)
- [msdyn_paymentdetail_PrincipalObjectAttributeAccesses](#BKMK_msdyn_paymentdetail_PrincipalObjectAttributeAccesses)
- [msdyn_paymentmethod_PrincipalObjectAttributeAccesses](#BKMK_msdyn_paymentmethod_PrincipalObjectAttributeAccesses)
- [msdyn_paymentterm_PrincipalObjectAttributeAccesses](#BKMK_msdyn_paymentterm_PrincipalObjectAttributeAccesses)
- [msdyn_postalcode_PrincipalObjectAttributeAccesses](#BKMK_msdyn_postalcode_PrincipalObjectAttributeAccesses)
- [msdyn_predictworkhourdurationsetting_PrincipalObjectAttributeAccesses](#BKMK_msdyn_predictworkhourdurationsetting_PrincipalObjectAttributeAccesses)
- [msdyn_priority_PrincipalObjectAttributeAccesses](#BKMK_msdyn_priority_PrincipalObjectAttributeAccesses)
- [msdyn_problematicasset_PrincipalObjectAttributeAccesses](#BKMK_msdyn_problematicasset_PrincipalObjectAttributeAccesses)
- [msdyn_problematicassetfeedback_PrincipalObjectAttributeAccesses](#BKMK_msdyn_problematicassetfeedback_PrincipalObjectAttributeAccesses)
- [msdyn_productinventory_PrincipalObjectAttributeAccesses](#BKMK_msdyn_productinventory_PrincipalObjectAttributeAccesses)
- [msdyn_purchaseorder_PrincipalObjectAttributeAccesses](#BKMK_msdyn_purchaseorder_PrincipalObjectAttributeAccesses)
- [msdyn_purchaseorderbill_PrincipalObjectAttributeAccesses](#BKMK_msdyn_purchaseorderbill_PrincipalObjectAttributeAccesses)
- [msdyn_purchaseorderproduct_PrincipalObjectAttributeAccesses](#BKMK_msdyn_purchaseorderproduct_PrincipalObjectAttributeAccesses)
- [msdyn_purchaseorderreceipt_PrincipalObjectAttributeAccesses](#BKMK_msdyn_purchaseorderreceipt_PrincipalObjectAttributeAccesses)
- [msdyn_purchaseorderreceiptproduct_PrincipalObjectAttributeAccesses](#BKMK_msdyn_purchaseorderreceiptproduct_PrincipalObjectAttributeAccesses)
- [msdyn_purchaseordersubstatus_PrincipalObjectAttributeAccesses](#BKMK_msdyn_purchaseordersubstatus_PrincipalObjectAttributeAccesses)
- [msdyn_quotebookingincident_PrincipalObjectAttributeAccesses](#BKMK_msdyn_quotebookingincident_PrincipalObjectAttributeAccesses)
- [msdyn_quotebookingproduct_PrincipalObjectAttributeAccesses](#BKMK_msdyn_quotebookingproduct_PrincipalObjectAttributeAccesses)
- [msdyn_quotebookingservice_PrincipalObjectAttributeAccesses](#BKMK_msdyn_quotebookingservice_PrincipalObjectAttributeAccesses)
- [msdyn_quotebookingservicetask_PrincipalObjectAttributeAccesses](#BKMK_msdyn_quotebookingservicetask_PrincipalObjectAttributeAccesses)
- [msdyn_quotebookingsetup_PrincipalObjectAttributeAccesses](#BKMK_msdyn_quotebookingsetup_PrincipalObjectAttributeAccesses)
- [msdyn_quoteinvoicingproduct_PrincipalObjectAttributeAccesses](#BKMK_msdyn_quoteinvoicingproduct_PrincipalObjectAttributeAccesses)
- [msdyn_quoteinvoicingsetup_PrincipalObjectAttributeAccesses](#BKMK_msdyn_quoteinvoicingsetup_PrincipalObjectAttributeAccesses)
- [msdyn_requirementchange_PrincipalObjectAttributeAccesses](#BKMK_msdyn_requirementchange_PrincipalObjectAttributeAccesses)
- [msdyn_requirementcharacteristic_PrincipalObjectAttributeAccesses](#BKMK_msdyn_requirementcharacteristic_PrincipalObjectAttributeAccesses)
- [msdyn_requirementdependency_PrincipalObjectAttributeAccesses](#BKMK_msdyn_requirementdependency_PrincipalObjectAttributeAccesses)
- [msdyn_requirementgroup_PrincipalObjectAttributeAccesses](#BKMK_msdyn_requirementgroup_PrincipalObjectAttributeAccesses)
- [msdyn_requirementorganizationunit_PrincipalObjectAttributeAccesses](#BKMK_msdyn_requirementorganizationunit_PrincipalObjectAttributeAccesses)
- [msdyn_requirementrelationship_PrincipalObjectAttributeAccesses](#BKMK_msdyn_requirementrelationship_PrincipalObjectAttributeAccesses)
- [msdyn_requirementresourcecategory_PrincipalObjectAttributeAccesses](#BKMK_msdyn_requirementresourcecategory_PrincipalObjectAttributeAccesses)
- [msdyn_requirementresourcepreference_PrincipalObjectAttributeAccesses](#BKMK_msdyn_requirementresourcepreference_PrincipalObjectAttributeAccesses)
- [msdyn_requirementstatus_PrincipalObjectAttributeAccesses](#BKMK_msdyn_requirementstatus_PrincipalObjectAttributeAccesses)
- [msdyn_resolution_PrincipalObjectAttributeAccesses](#BKMK_msdyn_resolution_PrincipalObjectAttributeAccesses)
- [msdyn_resourcepaytype_PrincipalObjectAttributeAccesses](#BKMK_msdyn_resourcepaytype_PrincipalObjectAttributeAccesses)
- [msdyn_resourcerequirement_PrincipalObjectAttributeAccesses](#BKMK_msdyn_resourcerequirement_PrincipalObjectAttributeAccesses)
- [msdyn_resourcerequirementdetail_PrincipalObjectAttributeAccesses](#BKMK_msdyn_resourcerequirementdetail_PrincipalObjectAttributeAccesses)
- [msdyn_resourceterritory_PrincipalObjectAttributeAccesses](#BKMK_msdyn_resourceterritory_PrincipalObjectAttributeAccesses)
- [msdyn_rma_PrincipalObjectAttributeAccesses](#BKMK_msdyn_rma_PrincipalObjectAttributeAccesses)
- [msdyn_rmaproduct_PrincipalObjectAttributeAccesses](#BKMK_msdyn_rmaproduct_PrincipalObjectAttributeAccesses)
- [msdyn_rmareceipt_PrincipalObjectAttributeAccesses](#BKMK_msdyn_rmareceipt_PrincipalObjectAttributeAccesses)
- [msdyn_rmareceiptproduct_PrincipalObjectAttributeAccesses](#BKMK_msdyn_rmareceiptproduct_PrincipalObjectAttributeAccesses)
- [msdyn_rmasubstatus_PrincipalObjectAttributeAccesses](#BKMK_msdyn_rmasubstatus_PrincipalObjectAttributeAccesses)
- [msdyn_rtv_PrincipalObjectAttributeAccesses](#BKMK_msdyn_rtv_PrincipalObjectAttributeAccesses)
- [msdyn_rtvproduct_PrincipalObjectAttributeAccesses](#BKMK_msdyn_rtvproduct_PrincipalObjectAttributeAccesses)
- [msdyn_rtvsubstatus_PrincipalObjectAttributeAccesses](#BKMK_msdyn_rtvsubstatus_PrincipalObjectAttributeAccesses)
- [msdyn_scheduleboardsetting_PrincipalObjectAttributeAccesses](#BKMK_msdyn_scheduleboardsetting_PrincipalObjectAttributeAccesses)
- [msdyn_schedulingfeatureflag_PrincipalObjectAttributeAccesses](#BKMK_msdyn_schedulingfeatureflag_PrincipalObjectAttributeAccesses)
- [msdyn_schedulingparameter_PrincipalObjectAttributeAccesses](#BKMK_msdyn_schedulingparameter_PrincipalObjectAttributeAccesses)
- [msdyn_servicetasktype_PrincipalObjectAttributeAccesses](#BKMK_msdyn_servicetasktype_PrincipalObjectAttributeAccesses)
- [msdyn_shipvia_PrincipalObjectAttributeAccesses](#BKMK_msdyn_shipvia_PrincipalObjectAttributeAccesses)
- [msdyn_systemuserschedulersetting_PrincipalObjectAttributeAccesses](#BKMK_msdyn_systemuserschedulersetting_PrincipalObjectAttributeAccesses)
- [msdyn_taxcode_PrincipalObjectAttributeAccesses](#BKMK_msdyn_taxcode_PrincipalObjectAttributeAccesses)
- [msdyn_taxcodedetail_PrincipalObjectAttributeAccesses](#BKMK_msdyn_taxcodedetail_PrincipalObjectAttributeAccesses)
- [msdyn_timeentry_PrincipalObjectAttributeAccesses](#BKMK_msdyn_timeentry_PrincipalObjectAttributeAccesses)
- [msdyn_timeentrysetting_PrincipalObjectAttributeAccesses](#BKMK_msdyn_timeentrysetting_PrincipalObjectAttributeAccesses)
- [msdyn_timegroup_PrincipalObjectAttributeAccesses](#BKMK_msdyn_timegroup_PrincipalObjectAttributeAccesses)
- [msdyn_timegroupdetail_PrincipalObjectAttributeAccesses](#BKMK_msdyn_timegroupdetail_PrincipalObjectAttributeAccesses)
- [msdyn_timeoffrequest_PrincipalObjectAttributeAccesses](#BKMK_msdyn_timeoffrequest_PrincipalObjectAttributeAccesses)
- [msdyn_trade_PrincipalObjectAttributeAccesses](#BKMK_msdyn_trade_PrincipalObjectAttributeAccesses)
- [msdyn_tradecoverage_PrincipalObjectAttributeAccesses](#BKMK_msdyn_tradecoverage_PrincipalObjectAttributeAccesses)
- [msdyn_transactionorigin_PrincipalObjectAttributeAccesses](#BKMK_msdyn_transactionorigin_PrincipalObjectAttributeAccesses)
- [msdyn_uniquenumber_PrincipalObjectAttributeAccesses](#BKMK_msdyn_uniquenumber_PrincipalObjectAttributeAccesses)
- [msdyn_warehouse_PrincipalObjectAttributeAccesses](#BKMK_msdyn_warehouse_PrincipalObjectAttributeAccesses)
- [msdyn_workhourtemplate_PrincipalObjectAttributeAccesses](#BKMK_msdyn_workhourtemplate_PrincipalObjectAttributeAccesses)
- [msdyn_workorder_PrincipalObjectAttributeAccesses](#BKMK_msdyn_workorder_PrincipalObjectAttributeAccesses)
- [msdyn_workordercharacteristic_PrincipalObjectAttributeAccesses](#BKMK_msdyn_workordercharacteristic_PrincipalObjectAttributeAccesses)
- [msdyn_workorderdetailsgenerationqueue_PrincipalObjectAttributeAccesses](#BKMK_msdyn_workorderdetailsgenerationqueue_PrincipalObjectAttributeAccesses)
- [msdyn_workorderincident_PrincipalObjectAttributeAccesses](#BKMK_msdyn_workorderincident_PrincipalObjectAttributeAccesses)
- [msdyn_workordernte_PrincipalObjectAttributeAccesses](#BKMK_msdyn_workordernte_PrincipalObjectAttributeAccesses)
- [msdyn_workorderproduct_PrincipalObjectAttributeAccesses](#BKMK_msdyn_workorderproduct_PrincipalObjectAttributeAccesses)
- [msdyn_workorderresolution_PrincipalObjectAttributeAccesses](#BKMK_msdyn_workorderresolution_PrincipalObjectAttributeAccesses)
- [msdyn_workorderresourcerestriction_PrincipalObjectAttributeAccesses](#BKMK_msdyn_workorderresourcerestriction_PrincipalObjectAttributeAccesses)
- [msdyn_workorderservice_PrincipalObjectAttributeAccesses](#BKMK_msdyn_workorderservice_PrincipalObjectAttributeAccesses)
- [msdyn_workorderservicetask_PrincipalObjectAttributeAccesses](#BKMK_msdyn_workorderservicetask_PrincipalObjectAttributeAccesses)
- [msdyn_workordersubstatus_PrincipalObjectAttributeAccesses](#BKMK_msdyn_workordersubstatus_PrincipalObjectAttributeAccesses)
- [msdyn_workordertype_PrincipalObjectAttributeAccesses](#BKMK_msdyn_workordertype_PrincipalObjectAttributeAccesses)

### <a name="BKMK_msdyn_3dmodel_PrincipalObjectAttributeAccesses"></a> msdyn_3dmodel_PrincipalObjectAttributeAccesses

One-To-Many Relationship: [msdyn_3dmodel msdyn_3dmodel_PrincipalObjectAttributeAccesses](msdyn_3dmodel.md#BKMK_msdyn_3dmodel_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_3dmodel`|
|ReferencedAttribute|`msdyn_3dmodelid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_3dmodel`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_actual_PrincipalObjectAttributeAccesses"></a> msdyn_actual_PrincipalObjectAttributeAccesses

One-To-Many Relationship: [msdyn_actual msdyn_actual_PrincipalObjectAttributeAccesses](msdyn_actual.md#BKMK_msdyn_actual_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_actual`|
|ReferencedAttribute|`msdyn_actualid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_actual`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_agreement_PrincipalObjectAttributeAccesses"></a> msdyn_agreement_PrincipalObjectAttributeAccesses

One-To-Many Relationship: [msdyn_agreement msdyn_agreement_PrincipalObjectAttributeAccesses](msdyn_agreement.md#BKMK_msdyn_agreement_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_agreement`|
|ReferencedAttribute|`msdyn_agreementid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_agreement`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_agreementbookingdate_PrincipalObjectAttributeAccesses"></a> msdyn_agreementbookingdate_PrincipalObjectAttributeAccesses

One-To-Many Relationship: [msdyn_agreementbookingdate msdyn_agreementbookingdate_PrincipalObjectAttributeAccesses](msdyn_agreementbookingdate.md#BKMK_msdyn_agreementbookingdate_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_agreementbookingdate`|
|ReferencedAttribute|`msdyn_agreementbookingdateid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_agreementbookingdate`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_agreementbookingincident_PrincipalObjectAttributeAccesses"></a> msdyn_agreementbookingincident_PrincipalObjectAttributeAccesses

One-To-Many Relationship: [msdyn_agreementbookingincident msdyn_agreementbookingincident_PrincipalObjectAttributeAccesses](msdyn_agreementbookingincident.md#BKMK_msdyn_agreementbookingincident_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_agreementbookingincident`|
|ReferencedAttribute|`msdyn_agreementbookingincidentid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_agreementbookingincident`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_agreementbookingproduct_PrincipalObjectAttributeAccesses"></a> msdyn_agreementbookingproduct_PrincipalObjectAttributeAccesses

One-To-Many Relationship: [msdyn_agreementbookingproduct msdyn_agreementbookingproduct_PrincipalObjectAttributeAccesses](msdyn_agreementbookingproduct.md#BKMK_msdyn_agreementbookingproduct_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_agreementbookingproduct`|
|ReferencedAttribute|`msdyn_agreementbookingproductid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_agreementbookingproduct`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_agreementbookingservice_PrincipalObjectAttributeAccesses"></a> msdyn_agreementbookingservice_PrincipalObjectAttributeAccesses

One-To-Many Relationship: [msdyn_agreementbookingservice msdyn_agreementbookingservice_PrincipalObjectAttributeAccesses](msdyn_agreementbookingservice.md#BKMK_msdyn_agreementbookingservice_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_agreementbookingservice`|
|ReferencedAttribute|`msdyn_agreementbookingserviceid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_agreementbookingservice`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_agreementbookingservicetask_PrincipalObjectAttributeAccesses"></a> msdyn_agreementbookingservicetask_PrincipalObjectAttributeAccesses

One-To-Many Relationship: [msdyn_agreementbookingservicetask msdyn_agreementbookingservicetask_PrincipalObjectAttributeAccesses](msdyn_agreementbookingservicetask.md#BKMK_msdyn_agreementbookingservicetask_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_agreementbookingservicetask`|
|ReferencedAttribute|`msdyn_agreementbookingservicetaskid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_agreementbookingservicetask`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_agreementbookingsetup_PrincipalObjectAttributeAccesses"></a> msdyn_agreementbookingsetup_PrincipalObjectAttributeAccesses

One-To-Many Relationship: [msdyn_agreementbookingsetup msdyn_agreementbookingsetup_PrincipalObjectAttributeAccesses](msdyn_agreementbookingsetup.md#BKMK_msdyn_agreementbookingsetup_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_agreementbookingsetup`|
|ReferencedAttribute|`msdyn_agreementbookingsetupid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_agreementbookingsetup`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_agreementinvoicedate_PrincipalObjectAttributeAccesses"></a> msdyn_agreementinvoicedate_PrincipalObjectAttributeAccesses

One-To-Many Relationship: [msdyn_agreementinvoicedate msdyn_agreementinvoicedate_PrincipalObjectAttributeAccesses](msdyn_agreementinvoicedate.md#BKMK_msdyn_agreementinvoicedate_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_agreementinvoicedate`|
|ReferencedAttribute|`msdyn_agreementinvoicedateid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_agreementinvoicedate`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_agreementinvoiceproduct_PrincipalObjectAttributeAccesses"></a> msdyn_agreementinvoiceproduct_PrincipalObjectAttributeAccesses

One-To-Many Relationship: [msdyn_agreementinvoiceproduct msdyn_agreementinvoiceproduct_PrincipalObjectAttributeAccesses](msdyn_agreementinvoiceproduct.md#BKMK_msdyn_agreementinvoiceproduct_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_agreementinvoiceproduct`|
|ReferencedAttribute|`msdyn_agreementinvoiceproductid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_agreementinvoiceproduct`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_agreementinvoicesetup_PrincipalObjectAttributeAccesses"></a> msdyn_agreementinvoicesetup_PrincipalObjectAttributeAccesses

One-To-Many Relationship: [msdyn_agreementinvoicesetup msdyn_agreementinvoicesetup_PrincipalObjectAttributeAccesses](msdyn_agreementinvoicesetup.md#BKMK_msdyn_agreementinvoicesetup_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_agreementinvoicesetup`|
|ReferencedAttribute|`msdyn_agreementinvoicesetupid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_agreementinvoicesetup`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_agreementsubstatus_PrincipalObjectAttributeAccesses"></a> msdyn_agreementsubstatus_PrincipalObjectAttributeAccesses

One-To-Many Relationship: [msdyn_agreementsubstatus msdyn_agreementsubstatus_PrincipalObjectAttributeAccesses](msdyn_agreementsubstatus.md#BKMK_msdyn_agreementsubstatus_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_agreementsubstatus`|
|ReferencedAttribute|`msdyn_agreementsubstatusid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_agreementsubstatus`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_assetsuggestionssetting_PrincipalObjectAttributeAccesses"></a> msdyn_assetsuggestionssetting_PrincipalObjectAttributeAccesses

One-To-Many Relationship: [msdyn_assetsuggestionssetting msdyn_assetsuggestionssetting_PrincipalObjectAttributeAccesses](msdyn_assetsuggestionssetting.md#BKMK_msdyn_assetsuggestionssetting_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_assetsuggestionssetting`|
|ReferencedAttribute|`msdyn_assetsuggestionssettingid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_assetsuggestionssetting`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_bookableresourceassociation_PrincipalObjectAttributeAccesses"></a> msdyn_bookableresourceassociation_PrincipalObjectAttributeAccesses

One-To-Many Relationship: [msdyn_bookableresourceassociation msdyn_bookableresourceassociation_PrincipalObjectAttributeAccesses](msdyn_bookableresourceassociation.md#BKMK_msdyn_bookableresourceassociation_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_bookableresourceassociation`|
|ReferencedAttribute|`msdyn_bookableresourceassociationid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_bookableresourceassociation`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_bookableresourcebookingquicknote_PrincipalObjectAttributeAccesses"></a> msdyn_bookableresourcebookingquicknote_PrincipalObjectAttributeAccesses

One-To-Many Relationship: [msdyn_bookableresourcebookingquicknote msdyn_bookableresourcebookingquicknote_PrincipalObjectAttributeAccesses](msdyn_bookableresourcebookingquicknote.md#BKMK_msdyn_bookableresourcebookingquicknote_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_bookableresourcebookingquicknote`|
|ReferencedAttribute|`msdyn_bookableresourcebookingquicknoteid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_bookableresourcebookingquicknote`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_bookingalert_PrincipalObjectAttributeAccesses"></a> msdyn_bookingalert_PrincipalObjectAttributeAccesses

One-To-Many Relationship: [msdyn_bookingalert msdyn_bookingalert_PrincipalObjectAttributeAccesses](msdyn_bookingalert.md#BKMK_msdyn_bookingalert_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_bookingalert`|
|ReferencedAttribute|`activityid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_bookingalert`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_bookingalertstatus_PrincipalObjectAttributeAccesses"></a> msdyn_bookingalertstatus_PrincipalObjectAttributeAccesses

One-To-Many Relationship: [msdyn_bookingalertstatus msdyn_bookingalertstatus_PrincipalObjectAttributeAccesses](msdyn_bookingalertstatus.md#BKMK_msdyn_bookingalertstatus_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_bookingalertstatus`|
|ReferencedAttribute|`msdyn_bookingalertstatusid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_bookingalertstatus`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_bookingchange_PrincipalObjectAttributeAccesses"></a> msdyn_bookingchange_PrincipalObjectAttributeAccesses

One-To-Many Relationship: [msdyn_bookingchange msdyn_bookingchange_PrincipalObjectAttributeAccesses](msdyn_bookingchange.md#BKMK_msdyn_bookingchange_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_bookingchange`|
|ReferencedAttribute|`msdyn_bookingchangeid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_bookingchange`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_bookingjournal_PrincipalObjectAttributeAccesses"></a> msdyn_bookingjournal_PrincipalObjectAttributeAccesses

One-To-Many Relationship: [msdyn_bookingjournal msdyn_bookingjournal_PrincipalObjectAttributeAccesses](msdyn_bookingjournal.md#BKMK_msdyn_bookingjournal_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_bookingjournal`|
|ReferencedAttribute|`msdyn_bookingjournalid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_bookingjournal`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_bookingrule_PrincipalObjectAttributeAccesses"></a> msdyn_bookingrule_PrincipalObjectAttributeAccesses

One-To-Many Relationship: [msdyn_bookingrule msdyn_bookingrule_PrincipalObjectAttributeAccesses](msdyn_bookingrule.md#BKMK_msdyn_bookingrule_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_bookingrule`|
|ReferencedAttribute|`msdyn_bookingruleid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_bookingrule`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_bookingsetupmetadata_PrincipalObjectAttributeAccesses"></a> msdyn_bookingsetupmetadata_PrincipalObjectAttributeAccesses

One-To-Many Relationship: [msdyn_bookingsetupmetadata msdyn_bookingsetupmetadata_PrincipalObjectAttributeAccesses](msdyn_bookingsetupmetadata.md#BKMK_msdyn_bookingsetupmetadata_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_bookingsetupmetadata`|
|ReferencedAttribute|`msdyn_bookingsetupmetadataid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_bookingsetupmetadata`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_bookingtimestamp_PrincipalObjectAttributeAccesses"></a> msdyn_bookingtimestamp_PrincipalObjectAttributeAccesses

One-To-Many Relationship: [msdyn_bookingtimestamp msdyn_bookingtimestamp_PrincipalObjectAttributeAccesses](msdyn_bookingtimestamp.md#BKMK_msdyn_bookingtimestamp_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_bookingtimestamp`|
|ReferencedAttribute|`msdyn_bookingtimestampid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_bookingtimestamp`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_bpf_2c5fe86acc8b414b8322ae571000c799_PrincipalObjectAttributeAccesses"></a> msdyn_bpf_2c5fe86acc8b414b8322ae571000c799_PrincipalObjectAttributeAccesses

One-To-Many Relationship: [msdyn_bpf_2c5fe86acc8b414b8322ae571000c799 msdyn_bpf_2c5fe86acc8b414b8322ae571000c799_PrincipalObjectAttributeAccesses](msdyn_bpf_2c5fe86acc8b414b8322ae571000c799.md#BKMK_msdyn_bpf_2c5fe86acc8b414b8322ae571000c799_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_bpf_2c5fe86acc8b414b8322ae571000c799`|
|ReferencedAttribute|`businessprocessflowinstanceid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_bpf_2c5fe86acc8b414b8322ae571000c799`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_bpf_477c16f59170487b8b4dc895c5dcd09b_PrincipalObjectAttributeAccesses"></a> msdyn_bpf_477c16f59170487b8b4dc895c5dcd09b_PrincipalObjectAttributeAccesses

One-To-Many Relationship: [msdyn_bpf_477c16f59170487b8b4dc895c5dcd09b msdyn_bpf_477c16f59170487b8b4dc895c5dcd09b_PrincipalObjectAttributeAccesses](msdyn_bpf_477c16f59170487b8b4dc895c5dcd09b.md#BKMK_msdyn_bpf_477c16f59170487b8b4dc895c5dcd09b_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_bpf_477c16f59170487b8b4dc895c5dcd09b`|
|ReferencedAttribute|`businessprocessflowinstanceid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_bpf_477c16f59170487b8b4dc895c5dcd09b`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_bpf_989e9b1857e24af18787d5143b67523b_PrincipalObjectAttributeAccesses"></a> msdyn_bpf_989e9b1857e24af18787d5143b67523b_PrincipalObjectAttributeAccesses

One-To-Many Relationship: [msdyn_bpf_989e9b1857e24af18787d5143b67523b msdyn_bpf_989e9b1857e24af18787d5143b67523b_PrincipalObjectAttributeAccesses](msdyn_bpf_989e9b1857e24af18787d5143b67523b.md#BKMK_msdyn_bpf_989e9b1857e24af18787d5143b67523b_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_bpf_989e9b1857e24af18787d5143b67523b`|
|ReferencedAttribute|`businessprocessflowinstanceid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_bpf_989e9b1857e24af18787d5143b67523b`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_bpf_baa0a411a239410cb8bded8b5fdd88e3_PrincipalObjectAttributeAccesses"></a> msdyn_bpf_baa0a411a239410cb8bded8b5fdd88e3_PrincipalObjectAttributeAccesses

One-To-Many Relationship: [msdyn_bpf_baa0a411a239410cb8bded8b5fdd88e3 msdyn_bpf_baa0a411a239410cb8bded8b5fdd88e3_PrincipalObjectAttributeAccesses](msdyn_bpf_baa0a411a239410cb8bded8b5fdd88e3.md#BKMK_msdyn_bpf_baa0a411a239410cb8bded8b5fdd88e3_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_bpf_baa0a411a239410cb8bded8b5fdd88e3`|
|ReferencedAttribute|`businessprocessflowinstanceid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_bpf_baa0a411a239410cb8bded8b5fdd88e3`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_bpf_d3d97bac8c294105840e99e37a9d1c39_PrincipalObjectAttributeAccesses"></a> msdyn_bpf_d3d97bac8c294105840e99e37a9d1c39_PrincipalObjectAttributeAccesses

One-To-Many Relationship: [msdyn_bpf_d3d97bac8c294105840e99e37a9d1c39 msdyn_bpf_d3d97bac8c294105840e99e37a9d1c39_PrincipalObjectAttributeAccesses](msdyn_bpf_d3d97bac8c294105840e99e37a9d1c39.md#BKMK_msdyn_bpf_d3d97bac8c294105840e99e37a9d1c39_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_bpf_d3d97bac8c294105840e99e37a9d1c39`|
|ReferencedAttribute|`businessprocessflowinstanceid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_bpf_d3d97bac8c294105840e99e37a9d1c39`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_businessclosure_PrincipalObjectAttributeAccesses"></a> msdyn_businessclosure_PrincipalObjectAttributeAccesses

One-To-Many Relationship: [msdyn_businessclosure msdyn_businessclosure_PrincipalObjectAttributeAccesses](msdyn_businessclosure.md#BKMK_msdyn_businessclosure_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_businessclosure`|
|ReferencedAttribute|`msdyn_businessclosureid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_businessclosure`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_clientextension_PrincipalObjectAttributeAccesses"></a> msdyn_clientextension_PrincipalObjectAttributeAccesses

One-To-Many Relationship: [msdyn_clientextension msdyn_clientextension_PrincipalObjectAttributeAccesses](msdyn_clientextension.md#BKMK_msdyn_clientextension_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_clientextension`|
|ReferencedAttribute|`msdyn_clientextensionid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_clientextension`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_configuration_PrincipalObjectAttributeAccesses"></a> msdyn_configuration_PrincipalObjectAttributeAccesses

One-To-Many Relationship: [msdyn_configuration msdyn_configuration_PrincipalObjectAttributeAccesses](msdyn_configuration.md#BKMK_msdyn_configuration_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_configuration`|
|ReferencedAttribute|`msdyn_configurationid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_configuration`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_dataanalyticsreport_fs_PrincipalObjectAttributeAccesses"></a> msdyn_dataanalyticsreport_fs_PrincipalObjectAttributeAccesses

One-To-Many Relationship: [msdyn_dataanalyticsreport_fs msdyn_dataanalyticsreport_fs_PrincipalObjectAttributeAccesses](msdyn_dataanalyticsreport_fs.md#BKMK_msdyn_dataanalyticsreport_fs_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_dataanalyticsreport_fs`|
|ReferencedAttribute|`msdyn_dataanalyticsreport_fsid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_dataanalyticsreport_fs`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_dataanalyticsreport_fspredictrs_PrincipalObjectAttributeAccesses"></a> msdyn_dataanalyticsreport_fspredictrs_PrincipalObjectAttributeAccesses

One-To-Many Relationship: [msdyn_dataanalyticsreport_fspredictrs msdyn_dataanalyticsreport_fspredictrs_PrincipalObjectAttributeAccesses](msdyn_dataanalyticsreport_fspredictrs.md#BKMK_msdyn_dataanalyticsreport_fspredictrs_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_dataanalyticsreport_fspredictrs`|
|ReferencedAttribute|`msdyn_dataanalyticsreport_fspredictrsid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_dataanalyticsreport_fspredictrs`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_dataanalyticsreport_fspredictwhd_PrincipalObjectAttributeAccesses"></a> msdyn_dataanalyticsreport_fspredictwhd_PrincipalObjectAttributeAccesses

One-To-Many Relationship: [msdyn_dataanalyticsreport_fspredictwhd msdyn_dataanalyticsreport_fspredictwhd_PrincipalObjectAttributeAccesses](msdyn_dataanalyticsreport_fspredictwhd.md#BKMK_msdyn_dataanalyticsreport_fspredictwhd_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_dataanalyticsreport_fspredictwhd`|
|ReferencedAttribute|`msdyn_dataanalyticsreport_fspredictwhdid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_dataanalyticsreport_fspredictwhd`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_entitlementapplication_PrincipalObjectAttributeAccesses"></a> msdyn_entitlementapplication_PrincipalObjectAttributeAccesses

One-To-Many Relationship: [msdyn_entitlementapplication msdyn_entitlementapplication_PrincipalObjectAttributeAccesses](msdyn_entitlementapplication.md#BKMK_msdyn_entitlementapplication_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_entitlementapplication`|
|ReferencedAttribute|`msdyn_entitlementapplicationid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_entitlementapplication`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_entityconfiguration_PrincipalObjectAttributeAccesses"></a> msdyn_entityconfiguration_PrincipalObjectAttributeAccesses

One-To-Many Relationship: [msdyn_entityconfiguration msdyn_entityconfiguration_PrincipalObjectAttributeAccesses](msdyn_entityconfiguration.md#BKMK_msdyn_entityconfiguration_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_entityconfiguration`|
|ReferencedAttribute|`msdyn_entityconfigurationid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_entityconfiguration`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_fieldservicepricelistitem_PrincipalObjectAttributeAccesses"></a> msdyn_fieldservicepricelistitem_PrincipalObjectAttributeAccesses

One-To-Many Relationship: [msdyn_fieldservicepricelistitem msdyn_fieldservicepricelistitem_PrincipalObjectAttributeAccesses](msdyn_fieldservicepricelistitem.md#BKMK_msdyn_fieldservicepricelistitem_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_fieldservicepricelistitem`|
|ReferencedAttribute|`msdyn_fieldservicepricelistitemid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_fieldservicepricelistitem`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_fieldservicesetting_PrincipalObjectAttributeAccesses"></a> msdyn_fieldservicesetting_PrincipalObjectAttributeAccesses

One-To-Many Relationship: [msdyn_fieldservicesetting msdyn_fieldservicesetting_PrincipalObjectAttributeAccesses](msdyn_fieldservicesetting.md#BKMK_msdyn_fieldservicesetting_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_fieldservicesetting`|
|ReferencedAttribute|`msdyn_fieldservicesettingid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_fieldservicesetting`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_fieldserviceslaconfiguration_PrincipalObjectAttributeAccesses"></a> msdyn_fieldserviceslaconfiguration_PrincipalObjectAttributeAccesses

One-To-Many Relationship: [msdyn_fieldserviceslaconfiguration msdyn_fieldserviceslaconfiguration_PrincipalObjectAttributeAccesses](msdyn_fieldserviceslaconfiguration.md#BKMK_msdyn_fieldserviceslaconfiguration_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_fieldserviceslaconfiguration`|
|ReferencedAttribute|`msdyn_fieldserviceslaconfigurationid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_fieldserviceslaconfiguration`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_fieldservicesummaryconfiguration_PrincipalObjectAttributeAccesses"></a> msdyn_fieldservicesummaryconfiguration_PrincipalObjectAttributeAccesses

One-To-Many Relationship: [msdyn_fieldservicesummaryconfiguration msdyn_fieldservicesummaryconfiguration_PrincipalObjectAttributeAccesses](msdyn_fieldservicesummaryconfiguration.md#BKMK_msdyn_fieldservicesummaryconfiguration_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_fieldservicesummaryconfiguration`|
|ReferencedAttribute|`msdyn_fieldservicesummaryconfigurationid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_fieldservicesummaryconfiguration`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_fieldservicesystemjob_PrincipalObjectAttributeAccesses"></a> msdyn_fieldservicesystemjob_PrincipalObjectAttributeAccesses

One-To-Many Relationship: [msdyn_fieldservicesystemjob msdyn_fieldservicesystemjob_PrincipalObjectAttributeAccesses](msdyn_fieldservicesystemjob.md#BKMK_msdyn_fieldservicesystemjob_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_fieldservicesystemjob`|
|ReferencedAttribute|`msdyn_fieldservicesystemjobid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_fieldservicesystemjob`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_flwconfiguration_PrincipalObjectAttributeAccesses"></a> msdyn_flwconfiguration_PrincipalObjectAttributeAccesses

One-To-Many Relationship: [msdyn_flwconfiguration msdyn_flwconfiguration_PrincipalObjectAttributeAccesses](msdyn_flwconfiguration.md#BKMK_msdyn_flwconfiguration_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_flwconfiguration`|
|ReferencedAttribute|`msdyn_flwconfigurationid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_flwconfiguration`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_geofence_PrincipalObjectAttributeAccesses"></a> msdyn_geofence_PrincipalObjectAttributeAccesses

One-To-Many Relationship: [msdyn_geofence msdyn_geofence_PrincipalObjectAttributeAccesses](msdyn_geofence.md#BKMK_msdyn_geofence_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_geofence`|
|ReferencedAttribute|`msdyn_geofenceid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_geofence`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_geofenceevent_PrincipalObjectAttributeAccesses"></a> msdyn_geofenceevent_PrincipalObjectAttributeAccesses

One-To-Many Relationship: [msdyn_geofenceevent msdyn_geofenceevent_PrincipalObjectAttributeAccesses](msdyn_geofenceevent.md#BKMK_msdyn_geofenceevent_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_geofenceevent`|
|ReferencedAttribute|`msdyn_geofenceeventid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_geofenceevent`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_geofencingsettings_PrincipalObjectAttributeAccesses"></a> msdyn_geofencingsettings_PrincipalObjectAttributeAccesses

One-To-Many Relationship: [msdyn_geofencingsettings msdyn_geofencingsettings_PrincipalObjectAttributeAccesses](msdyn_geofencingsettings.md#BKMK_msdyn_geofencingsettings_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_geofencingsettings`|
|ReferencedAttribute|`msdyn_geofencingsettingsid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_geofencingsettings`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_geolocationsettings_PrincipalObjectAttributeAccesses"></a> msdyn_geolocationsettings_PrincipalObjectAttributeAccesses

One-To-Many Relationship: [msdyn_geolocationsettings msdyn_geolocationsettings_PrincipalObjectAttributeAccesses](msdyn_geolocationsettings.md#BKMK_msdyn_geolocationsettings_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_geolocationsettings`|
|ReferencedAttribute|`msdyn_geolocationsettingsid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_geolocationsettings`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_geolocationtracking_PrincipalObjectAttributeAccesses"></a> msdyn_geolocationtracking_PrincipalObjectAttributeAccesses

One-To-Many Relationship: [msdyn_geolocationtracking msdyn_geolocationtracking_PrincipalObjectAttributeAccesses](msdyn_geolocationtracking.md#BKMK_msdyn_geolocationtracking_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_geolocationtracking`|
|ReferencedAttribute|`msdyn_geolocationtrackingid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_geolocationtracking`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_incidenttype_PrincipalObjectAttributeAccesses"></a> msdyn_incidenttype_PrincipalObjectAttributeAccesses

One-To-Many Relationship: [msdyn_incidenttype msdyn_incidenttype_PrincipalObjectAttributeAccesses](msdyn_incidenttype.md#BKMK_msdyn_incidenttype_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_incidenttype`|
|ReferencedAttribute|`msdyn_incidenttypeid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_incidenttype`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_incidenttype_requirementgroup_PrincipalObjectAttributeAccesses"></a> msdyn_incidenttype_requirementgroup_PrincipalObjectAttributeAccesses

One-To-Many Relationship: [msdyn_incidenttype_requirementgroup msdyn_incidenttype_requirementgroup_PrincipalObjectAttributeAccesses](msdyn_incidenttype_requirementgroup.md#BKMK_msdyn_incidenttype_requirementgroup_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_incidenttype_requirementgroup`|
|ReferencedAttribute|`msdyn_incidenttype_requirementgroupid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_incidenttype_requirementgroup`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_incidenttypecharacteristic_PrincipalObjectAttributeAccesses"></a> msdyn_incidenttypecharacteristic_PrincipalObjectAttributeAccesses

One-To-Many Relationship: [msdyn_incidenttypecharacteristic msdyn_incidenttypecharacteristic_PrincipalObjectAttributeAccesses](msdyn_incidenttypecharacteristic.md#BKMK_msdyn_incidenttypecharacteristic_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_incidenttypecharacteristic`|
|ReferencedAttribute|`msdyn_incidenttypecharacteristicid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_incidenttypecharacteristic`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_incidenttypeproduct_PrincipalObjectAttributeAccesses"></a> msdyn_incidenttypeproduct_PrincipalObjectAttributeAccesses

One-To-Many Relationship: [msdyn_incidenttypeproduct msdyn_incidenttypeproduct_PrincipalObjectAttributeAccesses](msdyn_incidenttypeproduct.md#BKMK_msdyn_incidenttypeproduct_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_incidenttypeproduct`|
|ReferencedAttribute|`msdyn_incidenttypeproductid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_incidenttypeproduct`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_incidenttyperecommendationresult_PrincipalObjectAttributeAccesses"></a> msdyn_incidenttyperecommendationresult_PrincipalObjectAttributeAccesses

One-To-Many Relationship: [msdyn_incidenttyperecommendationresult msdyn_incidenttyperecommendationresult_PrincipalObjectAttributeAccesses](msdyn_incidenttyperecommendationresult.md#BKMK_msdyn_incidenttyperecommendationresult_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_incidenttyperecommendationresult`|
|ReferencedAttribute|`msdyn_incidenttyperecommendationresultid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_incidenttyperecommendationresult`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_incidenttyperecommendationrunhistory_PrincipalObjectAttributeAccesses"></a> msdyn_incidenttyperecommendationrunhistory_PrincipalObjectAttributeAccesses

One-To-Many Relationship: [msdyn_incidenttyperecommendationrunhistory msdyn_incidenttyperecommendationrunhistory_PrincipalObjectAttributeAccesses](msdyn_incidenttyperecommendationrunhistory.md#BKMK_msdyn_incidenttyperecommendationrunhistory_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_incidenttyperecommendationrunhistory`|
|ReferencedAttribute|`msdyn_incidenttyperecommendationrunhistoryid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_incidenttyperecommendationrunhistory`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_incidenttyperesolution_PrincipalObjectAttributeAccesses"></a> msdyn_incidenttyperesolution_PrincipalObjectAttributeAccesses

One-To-Many Relationship: [msdyn_incidenttyperesolution msdyn_incidenttyperesolution_PrincipalObjectAttributeAccesses](msdyn_incidenttyperesolution.md#BKMK_msdyn_incidenttyperesolution_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_incidenttyperesolution`|
|ReferencedAttribute|`msdyn_incidenttyperesolutionid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_incidenttyperesolution`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_incidenttypeservice_PrincipalObjectAttributeAccesses"></a> msdyn_incidenttypeservice_PrincipalObjectAttributeAccesses

One-To-Many Relationship: [msdyn_incidenttypeservice msdyn_incidenttypeservice_PrincipalObjectAttributeAccesses](msdyn_incidenttypeservice.md#BKMK_msdyn_incidenttypeservice_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_incidenttypeservice`|
|ReferencedAttribute|`msdyn_incidenttypeserviceid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_incidenttypeservice`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_incidenttypeservicetask_PrincipalObjectAttributeAccesses"></a> msdyn_incidenttypeservicetask_PrincipalObjectAttributeAccesses

One-To-Many Relationship: [msdyn_incidenttypeservicetask msdyn_incidenttypeservicetask_PrincipalObjectAttributeAccesses](msdyn_incidenttypeservicetask.md#BKMK_msdyn_incidenttypeservicetask_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_incidenttypeservicetask`|
|ReferencedAttribute|`msdyn_incidenttypeservicetaskid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_incidenttypeservicetask`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_incidenttypessetup_PrincipalObjectAttributeAccesses"></a> msdyn_incidenttypessetup_PrincipalObjectAttributeAccesses

One-To-Many Relationship: [msdyn_incidenttypessetup msdyn_incidenttypessetup_PrincipalObjectAttributeAccesses](msdyn_incidenttypessetup.md#BKMK_msdyn_incidenttypessetup_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_incidenttypessetup`|
|ReferencedAttribute|`msdyn_incidenttypessetupid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_incidenttypessetup`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_inspection_PrincipalObjectAttributeAccesses"></a> msdyn_inspection_PrincipalObjectAttributeAccesses

One-To-Many Relationship: [msdyn_inspection msdyn_inspection_PrincipalObjectAttributeAccesses](msdyn_inspection.md#BKMK_msdyn_inspection_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_inspection`|
|ReferencedAttribute|`msdyn_inspectionid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_inspection`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_inspectionattachment_PrincipalObjectAttributeAccesses"></a> msdyn_inspectionattachment_PrincipalObjectAttributeAccesses

One-To-Many Relationship: [msdyn_inspectionattachment msdyn_inspectionattachment_PrincipalObjectAttributeAccesses](msdyn_inspectionattachment.md#BKMK_msdyn_inspectionattachment_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_inspectionattachment`|
|ReferencedAttribute|`msdyn_inspectionattachmentid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_inspectionattachment`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_inspectiondefinition_PrincipalObjectAttributeAccesses"></a> msdyn_inspectiondefinition_PrincipalObjectAttributeAccesses

One-To-Many Relationship: [msdyn_inspectiondefinition msdyn_inspectiondefinition_PrincipalObjectAttributeAccesses](msdyn_inspectiondefinition.md#BKMK_msdyn_inspectiondefinition_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_inspectiondefinition`|
|ReferencedAttribute|`msdyn_inspectiondefinitionid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_inspectiondefinition`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_inspectioninstance_PrincipalObjectAttributeAccesses"></a> msdyn_inspectioninstance_PrincipalObjectAttributeAccesses

One-To-Many Relationship: [msdyn_inspectioninstance msdyn_inspectioninstance_PrincipalObjectAttributeAccesses](msdyn_inspectioninstance.md#BKMK_msdyn_inspectioninstance_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_inspectioninstance`|
|ReferencedAttribute|`msdyn_inspectioninstanceid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_inspectioninstance`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_inspectionresponse_PrincipalObjectAttributeAccesses"></a> msdyn_inspectionresponse_PrincipalObjectAttributeAccesses

One-To-Many Relationship: [msdyn_inspectionresponse msdyn_inspectionresponse_PrincipalObjectAttributeAccesses](msdyn_inspectionresponse.md#BKMK_msdyn_inspectionresponse_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_inspectionresponse`|
|ReferencedAttribute|`msdyn_inspectionresponseid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_inspectionresponse`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_insurance_PrincipalObjectAttributeAccesses"></a> msdyn_insurance_PrincipalObjectAttributeAccesses

One-To-Many Relationship: [msdyn_insurance msdyn_insurance_PrincipalObjectAttributeAccesses](msdyn_insurance.md#BKMK_msdyn_insurance_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_insurance`|
|ReferencedAttribute|`msdyn_insuranceid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_insurance`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_inventoryadjustment_PrincipalObjectAttributeAccesses"></a> msdyn_inventoryadjustment_PrincipalObjectAttributeAccesses

One-To-Many Relationship: [msdyn_inventoryadjustment msdyn_inventoryadjustment_PrincipalObjectAttributeAccesses](msdyn_inventoryadjustment.md#BKMK_msdyn_inventoryadjustment_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_inventoryadjustment`|
|ReferencedAttribute|`msdyn_inventoryadjustmentid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_inventoryadjustment`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_inventoryadjustmentproduct_PrincipalObjectAttributeAccesses"></a> msdyn_inventoryadjustmentproduct_PrincipalObjectAttributeAccesses

One-To-Many Relationship: [msdyn_inventoryadjustmentproduct msdyn_inventoryadjustmentproduct_PrincipalObjectAttributeAccesses](msdyn_inventoryadjustmentproduct.md#BKMK_msdyn_inventoryadjustmentproduct_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_inventoryadjustmentproduct`|
|ReferencedAttribute|`msdyn_inventoryadjustmentproductid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_inventoryadjustmentproduct`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_inventoryjournal_PrincipalObjectAttributeAccesses"></a> msdyn_inventoryjournal_PrincipalObjectAttributeAccesses

One-To-Many Relationship: [msdyn_inventoryjournal msdyn_inventoryjournal_PrincipalObjectAttributeAccesses](msdyn_inventoryjournal.md#BKMK_msdyn_inventoryjournal_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_inventoryjournal`|
|ReferencedAttribute|`msdyn_inventoryjournalid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_inventoryjournal`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_inventorytransfer_PrincipalObjectAttributeAccesses"></a> msdyn_inventorytransfer_PrincipalObjectAttributeAccesses

One-To-Many Relationship: [msdyn_inventorytransfer msdyn_inventorytransfer_PrincipalObjectAttributeAccesses](msdyn_inventorytransfer.md#BKMK_msdyn_inventorytransfer_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_inventorytransfer`|
|ReferencedAttribute|`msdyn_inventorytransferid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_inventorytransfer`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_mobilesource_PrincipalObjectAttributeAccesses"></a> msdyn_mobilesource_PrincipalObjectAttributeAccesses

One-To-Many Relationship: [msdyn_mobilesource msdyn_mobilesource_PrincipalObjectAttributeAccesses](msdyn_mobilesource.md#BKMK_msdyn_mobilesource_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_mobilesource`|
|ReferencedAttribute|`msdyn_mobilesourceid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_mobilesource`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_nottoexceed_PrincipalObjectAttributeAccesses"></a> msdyn_nottoexceed_PrincipalObjectAttributeAccesses

One-To-Many Relationship: [msdyn_nottoexceed msdyn_nottoexceed_PrincipalObjectAttributeAccesses](msdyn_nottoexceed.md#BKMK_msdyn_nottoexceed_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_nottoexceed`|
|ReferencedAttribute|`msdyn_nottoexceedid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_nottoexceed`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_orderinvoicingdate_PrincipalObjectAttributeAccesses"></a> msdyn_orderinvoicingdate_PrincipalObjectAttributeAccesses

One-To-Many Relationship: [msdyn_orderinvoicingdate msdyn_orderinvoicingdate_PrincipalObjectAttributeAccesses](msdyn_orderinvoicingdate.md#BKMK_msdyn_orderinvoicingdate_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_orderinvoicingdate`|
|ReferencedAttribute|`msdyn_orderinvoicingdateid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_orderinvoicingdate`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_orderinvoicingproduct_PrincipalObjectAttributeAccesses"></a> msdyn_orderinvoicingproduct_PrincipalObjectAttributeAccesses

One-To-Many Relationship: [msdyn_orderinvoicingproduct msdyn_orderinvoicingproduct_PrincipalObjectAttributeAccesses](msdyn_orderinvoicingproduct.md#BKMK_msdyn_orderinvoicingproduct_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_orderinvoicingproduct`|
|ReferencedAttribute|`msdyn_orderinvoicingproductid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_orderinvoicingproduct`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_orderinvoicingsetup_PrincipalObjectAttributeAccesses"></a> msdyn_orderinvoicingsetup_PrincipalObjectAttributeAccesses

One-To-Many Relationship: [msdyn_orderinvoicingsetup msdyn_orderinvoicingsetup_PrincipalObjectAttributeAccesses](msdyn_orderinvoicingsetup.md#BKMK_msdyn_orderinvoicingsetup_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_orderinvoicingsetup`|
|ReferencedAttribute|`msdyn_orderinvoicingsetupid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_orderinvoicingsetup`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_orderinvoicingsetupdate_PrincipalObjectAttributeAccesses"></a> msdyn_orderinvoicingsetupdate_PrincipalObjectAttributeAccesses

One-To-Many Relationship: [msdyn_orderinvoicingsetupdate msdyn_orderinvoicingsetupdate_PrincipalObjectAttributeAccesses](msdyn_orderinvoicingsetupdate.md#BKMK_msdyn_orderinvoicingsetupdate_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_orderinvoicingsetupdate`|
|ReferencedAttribute|`msdyn_orderinvoicingsetupdateid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_orderinvoicingsetupdate`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_organizationalunit_PrincipalObjectAttributeAccesses"></a> msdyn_organizationalunit_PrincipalObjectAttributeAccesses

One-To-Many Relationship: [msdyn_organizationalunit msdyn_organizationalunit_PrincipalObjectAttributeAccesses](msdyn_organizationalunit.md#BKMK_msdyn_organizationalunit_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_organizationalunit`|
|ReferencedAttribute|`msdyn_organizationalunitid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_organizationalunit`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_payment_PrincipalObjectAttributeAccesses"></a> msdyn_payment_PrincipalObjectAttributeAccesses

One-To-Many Relationship: [msdyn_payment msdyn_payment_PrincipalObjectAttributeAccesses](msdyn_payment.md#BKMK_msdyn_payment_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_payment`|
|ReferencedAttribute|`msdyn_paymentid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_payment`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_paymentdetail_PrincipalObjectAttributeAccesses"></a> msdyn_paymentdetail_PrincipalObjectAttributeAccesses

One-To-Many Relationship: [msdyn_paymentdetail msdyn_paymentdetail_PrincipalObjectAttributeAccesses](msdyn_paymentdetail.md#BKMK_msdyn_paymentdetail_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_paymentdetail`|
|ReferencedAttribute|`msdyn_paymentdetailid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_paymentdetail`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_paymentmethod_PrincipalObjectAttributeAccesses"></a> msdyn_paymentmethod_PrincipalObjectAttributeAccesses

One-To-Many Relationship: [msdyn_paymentmethod msdyn_paymentmethod_PrincipalObjectAttributeAccesses](msdyn_paymentmethod.md#BKMK_msdyn_paymentmethod_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_paymentmethod`|
|ReferencedAttribute|`msdyn_paymentmethodid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_paymentmethod`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_paymentterm_PrincipalObjectAttributeAccesses"></a> msdyn_paymentterm_PrincipalObjectAttributeAccesses

One-To-Many Relationship: [msdyn_paymentterm msdyn_paymentterm_PrincipalObjectAttributeAccesses](msdyn_paymentterm.md#BKMK_msdyn_paymentterm_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_paymentterm`|
|ReferencedAttribute|`msdyn_paymenttermid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_paymentterm`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_postalcode_PrincipalObjectAttributeAccesses"></a> msdyn_postalcode_PrincipalObjectAttributeAccesses

One-To-Many Relationship: [msdyn_postalcode msdyn_postalcode_PrincipalObjectAttributeAccesses](msdyn_postalcode.md#BKMK_msdyn_postalcode_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_postalcode`|
|ReferencedAttribute|`msdyn_postalcodeid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_postalcode`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_predictworkhourdurationsetting_PrincipalObjectAttributeAccesses"></a> msdyn_predictworkhourdurationsetting_PrincipalObjectAttributeAccesses

One-To-Many Relationship: [msdyn_predictworkhourdurationsetting msdyn_predictworkhourdurationsetting_PrincipalObjectAttributeAccesses](msdyn_predictworkhourdurationsetting.md#BKMK_msdyn_predictworkhourdurationsetting_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_predictworkhourdurationsetting`|
|ReferencedAttribute|`msdyn_predictworkhourdurationsettingid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_predictworkhourdurationsetting`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_priority_PrincipalObjectAttributeAccesses"></a> msdyn_priority_PrincipalObjectAttributeAccesses

One-To-Many Relationship: [msdyn_priority msdyn_priority_PrincipalObjectAttributeAccesses](msdyn_priority.md#BKMK_msdyn_priority_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_priority`|
|ReferencedAttribute|`msdyn_priorityid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_priority`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_problematicasset_PrincipalObjectAttributeAccesses"></a> msdyn_problematicasset_PrincipalObjectAttributeAccesses

One-To-Many Relationship: [msdyn_problematicasset msdyn_problematicasset_PrincipalObjectAttributeAccesses](msdyn_problematicasset.md#BKMK_msdyn_problematicasset_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_problematicasset`|
|ReferencedAttribute|`msdyn_problematicassetid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_problematicasset`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_problematicassetfeedback_PrincipalObjectAttributeAccesses"></a> msdyn_problematicassetfeedback_PrincipalObjectAttributeAccesses

One-To-Many Relationship: [msdyn_problematicassetfeedback msdyn_problematicassetfeedback_PrincipalObjectAttributeAccesses](msdyn_problematicassetfeedback.md#BKMK_msdyn_problematicassetfeedback_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_problematicassetfeedback`|
|ReferencedAttribute|`msdyn_problematicassetfeedbackid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_problematicassetfeedback`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_productinventory_PrincipalObjectAttributeAccesses"></a> msdyn_productinventory_PrincipalObjectAttributeAccesses

One-To-Many Relationship: [msdyn_productinventory msdyn_productinventory_PrincipalObjectAttributeAccesses](msdyn_productinventory.md#BKMK_msdyn_productinventory_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_productinventory`|
|ReferencedAttribute|`msdyn_productinventoryid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_productinventory`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_purchaseorder_PrincipalObjectAttributeAccesses"></a> msdyn_purchaseorder_PrincipalObjectAttributeAccesses

One-To-Many Relationship: [msdyn_purchaseorder msdyn_purchaseorder_PrincipalObjectAttributeAccesses](msdyn_purchaseorder.md#BKMK_msdyn_purchaseorder_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_purchaseorder`|
|ReferencedAttribute|`msdyn_purchaseorderid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_purchaseorder`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_purchaseorderbill_PrincipalObjectAttributeAccesses"></a> msdyn_purchaseorderbill_PrincipalObjectAttributeAccesses

One-To-Many Relationship: [msdyn_purchaseorderbill msdyn_purchaseorderbill_PrincipalObjectAttributeAccesses](msdyn_purchaseorderbill.md#BKMK_msdyn_purchaseorderbill_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_purchaseorderbill`|
|ReferencedAttribute|`msdyn_purchaseorderbillid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_purchaseorderbill`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_purchaseorderproduct_PrincipalObjectAttributeAccesses"></a> msdyn_purchaseorderproduct_PrincipalObjectAttributeAccesses

One-To-Many Relationship: [msdyn_purchaseorderproduct msdyn_purchaseorderproduct_PrincipalObjectAttributeAccesses](msdyn_purchaseorderproduct.md#BKMK_msdyn_purchaseorderproduct_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_purchaseorderproduct`|
|ReferencedAttribute|`msdyn_purchaseorderproductid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_purchaseorderproduct`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_purchaseorderreceipt_PrincipalObjectAttributeAccesses"></a> msdyn_purchaseorderreceipt_PrincipalObjectAttributeAccesses

One-To-Many Relationship: [msdyn_purchaseorderreceipt msdyn_purchaseorderreceipt_PrincipalObjectAttributeAccesses](msdyn_purchaseorderreceipt.md#BKMK_msdyn_purchaseorderreceipt_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_purchaseorderreceipt`|
|ReferencedAttribute|`msdyn_purchaseorderreceiptid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_purchaseorderreceipt`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_purchaseorderreceiptproduct_PrincipalObjectAttributeAccesses"></a> msdyn_purchaseorderreceiptproduct_PrincipalObjectAttributeAccesses

One-To-Many Relationship: [msdyn_purchaseorderreceiptproduct msdyn_purchaseorderreceiptproduct_PrincipalObjectAttributeAccesses](msdyn_purchaseorderreceiptproduct.md#BKMK_msdyn_purchaseorderreceiptproduct_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_purchaseorderreceiptproduct`|
|ReferencedAttribute|`msdyn_purchaseorderreceiptproductid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_purchaseorderreceiptproduct`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_purchaseordersubstatus_PrincipalObjectAttributeAccesses"></a> msdyn_purchaseordersubstatus_PrincipalObjectAttributeAccesses

One-To-Many Relationship: [msdyn_purchaseordersubstatus msdyn_purchaseordersubstatus_PrincipalObjectAttributeAccesses](msdyn_purchaseordersubstatus.md#BKMK_msdyn_purchaseordersubstatus_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_purchaseordersubstatus`|
|ReferencedAttribute|`msdyn_purchaseordersubstatusid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_purchaseordersubstatus`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_quotebookingincident_PrincipalObjectAttributeAccesses"></a> msdyn_quotebookingincident_PrincipalObjectAttributeAccesses

One-To-Many Relationship: [msdyn_quotebookingincident msdyn_quotebookingincident_PrincipalObjectAttributeAccesses](msdyn_quotebookingincident.md#BKMK_msdyn_quotebookingincident_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_quotebookingincident`|
|ReferencedAttribute|`msdyn_quotebookingincidentid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_quotebookingincident`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_quotebookingproduct_PrincipalObjectAttributeAccesses"></a> msdyn_quotebookingproduct_PrincipalObjectAttributeAccesses

One-To-Many Relationship: [msdyn_quotebookingproduct msdyn_quotebookingproduct_PrincipalObjectAttributeAccesses](msdyn_quotebookingproduct.md#BKMK_msdyn_quotebookingproduct_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_quotebookingproduct`|
|ReferencedAttribute|`msdyn_quotebookingproductid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_quotebookingproduct`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_quotebookingservice_PrincipalObjectAttributeAccesses"></a> msdyn_quotebookingservice_PrincipalObjectAttributeAccesses

One-To-Many Relationship: [msdyn_quotebookingservice msdyn_quotebookingservice_PrincipalObjectAttributeAccesses](msdyn_quotebookingservice.md#BKMK_msdyn_quotebookingservice_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_quotebookingservice`|
|ReferencedAttribute|`msdyn_quotebookingserviceid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_quotebookingservice`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_quotebookingservicetask_PrincipalObjectAttributeAccesses"></a> msdyn_quotebookingservicetask_PrincipalObjectAttributeAccesses

One-To-Many Relationship: [msdyn_quotebookingservicetask msdyn_quotebookingservicetask_PrincipalObjectAttributeAccesses](msdyn_quotebookingservicetask.md#BKMK_msdyn_quotebookingservicetask_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_quotebookingservicetask`|
|ReferencedAttribute|`msdyn_quotebookingservicetaskid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_quotebookingservicetask`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_quotebookingsetup_PrincipalObjectAttributeAccesses"></a> msdyn_quotebookingsetup_PrincipalObjectAttributeAccesses

One-To-Many Relationship: [msdyn_quotebookingsetup msdyn_quotebookingsetup_PrincipalObjectAttributeAccesses](msdyn_quotebookingsetup.md#BKMK_msdyn_quotebookingsetup_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_quotebookingsetup`|
|ReferencedAttribute|`msdyn_quotebookingsetupid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_quotebookingsetup`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_quoteinvoicingproduct_PrincipalObjectAttributeAccesses"></a> msdyn_quoteinvoicingproduct_PrincipalObjectAttributeAccesses

One-To-Many Relationship: [msdyn_quoteinvoicingproduct msdyn_quoteinvoicingproduct_PrincipalObjectAttributeAccesses](msdyn_quoteinvoicingproduct.md#BKMK_msdyn_quoteinvoicingproduct_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_quoteinvoicingproduct`|
|ReferencedAttribute|`msdyn_quoteinvoicingproductid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_quoteinvoicingproduct`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_quoteinvoicingsetup_PrincipalObjectAttributeAccesses"></a> msdyn_quoteinvoicingsetup_PrincipalObjectAttributeAccesses

One-To-Many Relationship: [msdyn_quoteinvoicingsetup msdyn_quoteinvoicingsetup_PrincipalObjectAttributeAccesses](msdyn_quoteinvoicingsetup.md#BKMK_msdyn_quoteinvoicingsetup_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_quoteinvoicingsetup`|
|ReferencedAttribute|`msdyn_quoteinvoicingsetupid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_quoteinvoicingsetup`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_requirementchange_PrincipalObjectAttributeAccesses"></a> msdyn_requirementchange_PrincipalObjectAttributeAccesses

One-To-Many Relationship: [msdyn_requirementchange msdyn_requirementchange_PrincipalObjectAttributeAccesses](msdyn_requirementchange.md#BKMK_msdyn_requirementchange_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_requirementchange`|
|ReferencedAttribute|`msdyn_requirementchangeid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_requirementchange`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_requirementcharacteristic_PrincipalObjectAttributeAccesses"></a> msdyn_requirementcharacteristic_PrincipalObjectAttributeAccesses

One-To-Many Relationship: [msdyn_requirementcharacteristic msdyn_requirementcharacteristic_PrincipalObjectAttributeAccesses](msdyn_requirementcharacteristic.md#BKMK_msdyn_requirementcharacteristic_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_requirementcharacteristic`|
|ReferencedAttribute|`msdyn_requirementcharacteristicid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_requirementcharacteristic`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_requirementdependency_PrincipalObjectAttributeAccesses"></a> msdyn_requirementdependency_PrincipalObjectAttributeAccesses

One-To-Many Relationship: [msdyn_requirementdependency msdyn_requirementdependency_PrincipalObjectAttributeAccesses](msdyn_requirementdependency.md#BKMK_msdyn_requirementdependency_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_requirementdependency`|
|ReferencedAttribute|`msdyn_requirementdependencyid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_requirementdependency`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_requirementgroup_PrincipalObjectAttributeAccesses"></a> msdyn_requirementgroup_PrincipalObjectAttributeAccesses

One-To-Many Relationship: [msdyn_requirementgroup msdyn_requirementgroup_PrincipalObjectAttributeAccesses](msdyn_requirementgroup.md#BKMK_msdyn_requirementgroup_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_requirementgroup`|
|ReferencedAttribute|`msdyn_requirementgroupid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_requirementgroup`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_requirementorganizationunit_PrincipalObjectAttributeAccesses"></a> msdyn_requirementorganizationunit_PrincipalObjectAttributeAccesses

One-To-Many Relationship: [msdyn_requirementorganizationunit msdyn_requirementorganizationunit_PrincipalObjectAttributeAccesses](msdyn_requirementorganizationunit.md#BKMK_msdyn_requirementorganizationunit_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_requirementorganizationunit`|
|ReferencedAttribute|`msdyn_requirementorganizationunitid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_requirementorganizationunit`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_requirementrelationship_PrincipalObjectAttributeAccesses"></a> msdyn_requirementrelationship_PrincipalObjectAttributeAccesses

One-To-Many Relationship: [msdyn_requirementrelationship msdyn_requirementrelationship_PrincipalObjectAttributeAccesses](msdyn_requirementrelationship.md#BKMK_msdyn_requirementrelationship_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_requirementrelationship`|
|ReferencedAttribute|`msdyn_requirementrelationshipid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_requirementrelationship`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_requirementresourcecategory_PrincipalObjectAttributeAccesses"></a> msdyn_requirementresourcecategory_PrincipalObjectAttributeAccesses

One-To-Many Relationship: [msdyn_requirementresourcecategory msdyn_requirementresourcecategory_PrincipalObjectAttributeAccesses](msdyn_requirementresourcecategory.md#BKMK_msdyn_requirementresourcecategory_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_requirementresourcecategory`|
|ReferencedAttribute|`msdyn_requirementresourcecategoryid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_requirementresourcecategory`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_requirementresourcepreference_PrincipalObjectAttributeAccesses"></a> msdyn_requirementresourcepreference_PrincipalObjectAttributeAccesses

One-To-Many Relationship: [msdyn_requirementresourcepreference msdyn_requirementresourcepreference_PrincipalObjectAttributeAccesses](msdyn_requirementresourcepreference.md#BKMK_msdyn_requirementresourcepreference_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_requirementresourcepreference`|
|ReferencedAttribute|`msdyn_requirementresourcepreferenceid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_requirementresourcepreference`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_requirementstatus_PrincipalObjectAttributeAccesses"></a> msdyn_requirementstatus_PrincipalObjectAttributeAccesses

One-To-Many Relationship: [msdyn_requirementstatus msdyn_requirementstatus_PrincipalObjectAttributeAccesses](msdyn_requirementstatus.md#BKMK_msdyn_requirementstatus_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_requirementstatus`|
|ReferencedAttribute|`msdyn_requirementstatusid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_requirementstatus`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_resolution_PrincipalObjectAttributeAccesses"></a> msdyn_resolution_PrincipalObjectAttributeAccesses

One-To-Many Relationship: [msdyn_resolution msdyn_resolution_PrincipalObjectAttributeAccesses](msdyn_resolution.md#BKMK_msdyn_resolution_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_resolution`|
|ReferencedAttribute|`msdyn_resolutionid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_resolution`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_resourcepaytype_PrincipalObjectAttributeAccesses"></a> msdyn_resourcepaytype_PrincipalObjectAttributeAccesses

One-To-Many Relationship: [msdyn_resourcepaytype msdyn_resourcepaytype_PrincipalObjectAttributeAccesses](msdyn_resourcepaytype.md#BKMK_msdyn_resourcepaytype_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_resourcepaytype`|
|ReferencedAttribute|`msdyn_resourcepaytypeid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_resourcepaytype`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_resourcerequirement_PrincipalObjectAttributeAccesses"></a> msdyn_resourcerequirement_PrincipalObjectAttributeAccesses

One-To-Many Relationship: [msdyn_resourcerequirement msdyn_resourcerequirement_PrincipalObjectAttributeAccesses](msdyn_resourcerequirement.md#BKMK_msdyn_resourcerequirement_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_resourcerequirement`|
|ReferencedAttribute|`msdyn_resourcerequirementid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_resourcerequirement`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_resourcerequirementdetail_PrincipalObjectAttributeAccesses"></a> msdyn_resourcerequirementdetail_PrincipalObjectAttributeAccesses

One-To-Many Relationship: [msdyn_resourcerequirementdetail msdyn_resourcerequirementdetail_PrincipalObjectAttributeAccesses](msdyn_resourcerequirementdetail.md#BKMK_msdyn_resourcerequirementdetail_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_resourcerequirementdetail`|
|ReferencedAttribute|`msdyn_resourcerequirementdetailid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_resourcerequirementdetail`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_resourceterritory_PrincipalObjectAttributeAccesses"></a> msdyn_resourceterritory_PrincipalObjectAttributeAccesses

One-To-Many Relationship: [msdyn_resourceterritory msdyn_resourceterritory_PrincipalObjectAttributeAccesses](msdyn_resourceterritory.md#BKMK_msdyn_resourceterritory_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_resourceterritory`|
|ReferencedAttribute|`msdyn_resourceterritoryid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_resourceterritory`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_rma_PrincipalObjectAttributeAccesses"></a> msdyn_rma_PrincipalObjectAttributeAccesses

One-To-Many Relationship: [msdyn_rma msdyn_rma_PrincipalObjectAttributeAccesses](msdyn_rma.md#BKMK_msdyn_rma_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_rma`|
|ReferencedAttribute|`msdyn_rmaid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_rma`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_rmaproduct_PrincipalObjectAttributeAccesses"></a> msdyn_rmaproduct_PrincipalObjectAttributeAccesses

One-To-Many Relationship: [msdyn_rmaproduct msdyn_rmaproduct_PrincipalObjectAttributeAccesses](msdyn_rmaproduct.md#BKMK_msdyn_rmaproduct_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_rmaproduct`|
|ReferencedAttribute|`msdyn_rmaproductid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_rmaproduct`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_rmareceipt_PrincipalObjectAttributeAccesses"></a> msdyn_rmareceipt_PrincipalObjectAttributeAccesses

One-To-Many Relationship: [msdyn_rmareceipt msdyn_rmareceipt_PrincipalObjectAttributeAccesses](msdyn_rmareceipt.md#BKMK_msdyn_rmareceipt_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_rmareceipt`|
|ReferencedAttribute|`msdyn_rmareceiptid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_rmareceipt`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_rmareceiptproduct_PrincipalObjectAttributeAccesses"></a> msdyn_rmareceiptproduct_PrincipalObjectAttributeAccesses

One-To-Many Relationship: [msdyn_rmareceiptproduct msdyn_rmareceiptproduct_PrincipalObjectAttributeAccesses](msdyn_rmareceiptproduct.md#BKMK_msdyn_rmareceiptproduct_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_rmareceiptproduct`|
|ReferencedAttribute|`msdyn_rmareceiptproductid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_rmareceiptproduct`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_rmasubstatus_PrincipalObjectAttributeAccesses"></a> msdyn_rmasubstatus_PrincipalObjectAttributeAccesses

One-To-Many Relationship: [msdyn_rmasubstatus msdyn_rmasubstatus_PrincipalObjectAttributeAccesses](msdyn_rmasubstatus.md#BKMK_msdyn_rmasubstatus_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_rmasubstatus`|
|ReferencedAttribute|`msdyn_rmasubstatusid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_rmasubstatus`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_rtv_PrincipalObjectAttributeAccesses"></a> msdyn_rtv_PrincipalObjectAttributeAccesses

One-To-Many Relationship: [msdyn_rtv msdyn_rtv_PrincipalObjectAttributeAccesses](msdyn_rtv.md#BKMK_msdyn_rtv_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_rtv`|
|ReferencedAttribute|`msdyn_rtvid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_rtv`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_rtvproduct_PrincipalObjectAttributeAccesses"></a> msdyn_rtvproduct_PrincipalObjectAttributeAccesses

One-To-Many Relationship: [msdyn_rtvproduct msdyn_rtvproduct_PrincipalObjectAttributeAccesses](msdyn_rtvproduct.md#BKMK_msdyn_rtvproduct_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_rtvproduct`|
|ReferencedAttribute|`msdyn_rtvproductid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_rtvproduct`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_rtvsubstatus_PrincipalObjectAttributeAccesses"></a> msdyn_rtvsubstatus_PrincipalObjectAttributeAccesses

One-To-Many Relationship: [msdyn_rtvsubstatus msdyn_rtvsubstatus_PrincipalObjectAttributeAccesses](msdyn_rtvsubstatus.md#BKMK_msdyn_rtvsubstatus_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_rtvsubstatus`|
|ReferencedAttribute|`msdyn_rtvsubstatusid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_rtvsubstatus`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_scheduleboardsetting_PrincipalObjectAttributeAccesses"></a> msdyn_scheduleboardsetting_PrincipalObjectAttributeAccesses

One-To-Many Relationship: [msdyn_scheduleboardsetting msdyn_scheduleboardsetting_PrincipalObjectAttributeAccesses](msdyn_scheduleboardsetting.md#BKMK_msdyn_scheduleboardsetting_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_scheduleboardsetting`|
|ReferencedAttribute|`msdyn_scheduleboardsettingid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_scheduleboardsetting`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_schedulingfeatureflag_PrincipalObjectAttributeAccesses"></a> msdyn_schedulingfeatureflag_PrincipalObjectAttributeAccesses

One-To-Many Relationship: [msdyn_schedulingfeatureflag msdyn_schedulingfeatureflag_PrincipalObjectAttributeAccesses](msdyn_schedulingfeatureflag.md#BKMK_msdyn_schedulingfeatureflag_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_schedulingfeatureflag`|
|ReferencedAttribute|`msdyn_schedulingfeatureflagid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_schedulingfeatureflag`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_schedulingparameter_PrincipalObjectAttributeAccesses"></a> msdyn_schedulingparameter_PrincipalObjectAttributeAccesses

One-To-Many Relationship: [msdyn_schedulingparameter msdyn_schedulingparameter_PrincipalObjectAttributeAccesses](msdyn_schedulingparameter.md#BKMK_msdyn_schedulingparameter_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_schedulingparameter`|
|ReferencedAttribute|`msdyn_schedulingparameterid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_schedulingparameter`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_servicetasktype_PrincipalObjectAttributeAccesses"></a> msdyn_servicetasktype_PrincipalObjectAttributeAccesses

One-To-Many Relationship: [msdyn_servicetasktype msdyn_servicetasktype_PrincipalObjectAttributeAccesses](msdyn_servicetasktype.md#BKMK_msdyn_servicetasktype_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_servicetasktype`|
|ReferencedAttribute|`msdyn_servicetasktypeid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_servicetasktype`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_shipvia_PrincipalObjectAttributeAccesses"></a> msdyn_shipvia_PrincipalObjectAttributeAccesses

One-To-Many Relationship: [msdyn_shipvia msdyn_shipvia_PrincipalObjectAttributeAccesses](msdyn_shipvia.md#BKMK_msdyn_shipvia_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_shipvia`|
|ReferencedAttribute|`msdyn_shipviaid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_shipvia`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_systemuserschedulersetting_PrincipalObjectAttributeAccesses"></a> msdyn_systemuserschedulersetting_PrincipalObjectAttributeAccesses

One-To-Many Relationship: [msdyn_systemuserschedulersetting msdyn_systemuserschedulersetting_PrincipalObjectAttributeAccesses](msdyn_systemuserschedulersetting.md#BKMK_msdyn_systemuserschedulersetting_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_systemuserschedulersetting`|
|ReferencedAttribute|`msdyn_systemuserschedulersettingid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_systemuserschedulersetting`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_taxcode_PrincipalObjectAttributeAccesses"></a> msdyn_taxcode_PrincipalObjectAttributeAccesses

One-To-Many Relationship: [msdyn_taxcode msdyn_taxcode_PrincipalObjectAttributeAccesses](msdyn_taxcode.md#BKMK_msdyn_taxcode_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_taxcode`|
|ReferencedAttribute|`msdyn_taxcodeid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_taxcode`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_taxcodedetail_PrincipalObjectAttributeAccesses"></a> msdyn_taxcodedetail_PrincipalObjectAttributeAccesses

One-To-Many Relationship: [msdyn_taxcodedetail msdyn_taxcodedetail_PrincipalObjectAttributeAccesses](msdyn_taxcodedetail.md#BKMK_msdyn_taxcodedetail_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_taxcodedetail`|
|ReferencedAttribute|`msdyn_taxcodedetailid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_taxcodedetail`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_timeentry_PrincipalObjectAttributeAccesses"></a> msdyn_timeentry_PrincipalObjectAttributeAccesses

One-To-Many Relationship: [msdyn_timeentry msdyn_timeentry_PrincipalObjectAttributeAccesses](msdyn_timeentry.md#BKMK_msdyn_timeentry_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_timeentry`|
|ReferencedAttribute|`msdyn_timeentryid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_timeentry`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_timeentrysetting_PrincipalObjectAttributeAccesses"></a> msdyn_timeentrysetting_PrincipalObjectAttributeAccesses

One-To-Many Relationship: [msdyn_timeentrysetting msdyn_timeentrysetting_PrincipalObjectAttributeAccesses](msdyn_timeentrysetting.md#BKMK_msdyn_timeentrysetting_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_timeentrysetting`|
|ReferencedAttribute|`msdyn_timeentrysettingid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_timeentrysetting`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_timegroup_PrincipalObjectAttributeAccesses"></a> msdyn_timegroup_PrincipalObjectAttributeAccesses

One-To-Many Relationship: [msdyn_timegroup msdyn_timegroup_PrincipalObjectAttributeAccesses](msdyn_timegroup.md#BKMK_msdyn_timegroup_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_timegroup`|
|ReferencedAttribute|`msdyn_timegroupid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_timegroup`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_timegroupdetail_PrincipalObjectAttributeAccesses"></a> msdyn_timegroupdetail_PrincipalObjectAttributeAccesses

One-To-Many Relationship: [msdyn_timegroupdetail msdyn_timegroupdetail_PrincipalObjectAttributeAccesses](msdyn_timegroupdetail.md#BKMK_msdyn_timegroupdetail_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_timegroupdetail`|
|ReferencedAttribute|`msdyn_timegroupdetailid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_timegroupdetail`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_timeoffrequest_PrincipalObjectAttributeAccesses"></a> msdyn_timeoffrequest_PrincipalObjectAttributeAccesses

One-To-Many Relationship: [msdyn_timeoffrequest msdyn_timeoffrequest_PrincipalObjectAttributeAccesses](msdyn_timeoffrequest.md#BKMK_msdyn_timeoffrequest_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_timeoffrequest`|
|ReferencedAttribute|`msdyn_timeoffrequestid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_timeoffrequest`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_trade_PrincipalObjectAttributeAccesses"></a> msdyn_trade_PrincipalObjectAttributeAccesses

One-To-Many Relationship: [msdyn_trade msdyn_trade_PrincipalObjectAttributeAccesses](msdyn_trade.md#BKMK_msdyn_trade_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_trade`|
|ReferencedAttribute|`msdyn_tradeid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_trade`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_tradecoverage_PrincipalObjectAttributeAccesses"></a> msdyn_tradecoverage_PrincipalObjectAttributeAccesses

One-To-Many Relationship: [msdyn_tradecoverage msdyn_tradecoverage_PrincipalObjectAttributeAccesses](msdyn_tradecoverage.md#BKMK_msdyn_tradecoverage_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_tradecoverage`|
|ReferencedAttribute|`msdyn_tradecoverageid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_tradecoverage`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_transactionorigin_PrincipalObjectAttributeAccesses"></a> msdyn_transactionorigin_PrincipalObjectAttributeAccesses

One-To-Many Relationship: [msdyn_transactionorigin msdyn_transactionorigin_PrincipalObjectAttributeAccesses](msdyn_transactionorigin.md#BKMK_msdyn_transactionorigin_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_transactionorigin`|
|ReferencedAttribute|`msdyn_transactionoriginid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_transactionorigin`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_uniquenumber_PrincipalObjectAttributeAccesses"></a> msdyn_uniquenumber_PrincipalObjectAttributeAccesses

One-To-Many Relationship: [msdyn_uniquenumber msdyn_uniquenumber_PrincipalObjectAttributeAccesses](msdyn_uniquenumber.md#BKMK_msdyn_uniquenumber_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_uniquenumber`|
|ReferencedAttribute|`msdyn_uniquenumberid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_uniquenumber`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_warehouse_PrincipalObjectAttributeAccesses"></a> msdyn_warehouse_PrincipalObjectAttributeAccesses

One-To-Many Relationship: [msdyn_warehouse msdyn_warehouse_PrincipalObjectAttributeAccesses](msdyn_warehouse.md#BKMK_msdyn_warehouse_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_warehouse`|
|ReferencedAttribute|`msdyn_warehouseid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_warehouse`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_workhourtemplate_PrincipalObjectAttributeAccesses"></a> msdyn_workhourtemplate_PrincipalObjectAttributeAccesses

One-To-Many Relationship: [msdyn_workhourtemplate msdyn_workhourtemplate_PrincipalObjectAttributeAccesses](msdyn_workhourtemplate.md#BKMK_msdyn_workhourtemplate_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_workhourtemplate`|
|ReferencedAttribute|`msdyn_workhourtemplateid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_workhourtemplate`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_workorder_PrincipalObjectAttributeAccesses"></a> msdyn_workorder_PrincipalObjectAttributeAccesses

One-To-Many Relationship: [msdyn_workorder msdyn_workorder_PrincipalObjectAttributeAccesses](msdyn_workorder.md#BKMK_msdyn_workorder_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_workorder`|
|ReferencedAttribute|`msdyn_workorderid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_workorder`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_workordercharacteristic_PrincipalObjectAttributeAccesses"></a> msdyn_workordercharacteristic_PrincipalObjectAttributeAccesses

One-To-Many Relationship: [msdyn_workordercharacteristic msdyn_workordercharacteristic_PrincipalObjectAttributeAccesses](msdyn_workordercharacteristic.md#BKMK_msdyn_workordercharacteristic_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_workordercharacteristic`|
|ReferencedAttribute|`msdyn_workordercharacteristicid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_workordercharacteristic`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_workorderdetailsgenerationqueue_PrincipalObjectAttributeAccesses"></a> msdyn_workorderdetailsgenerationqueue_PrincipalObjectAttributeAccesses

One-To-Many Relationship: [msdyn_workorderdetailsgenerationqueue msdyn_workorderdetailsgenerationqueue_PrincipalObjectAttributeAccesses](msdyn_workorderdetailsgenerationqueue.md#BKMK_msdyn_workorderdetailsgenerationqueue_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_workorderdetailsgenerationqueue`|
|ReferencedAttribute|`msdyn_workorderdetailsgenerationqueueid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_workorderdetailsgenerationqueue`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_workorderincident_PrincipalObjectAttributeAccesses"></a> msdyn_workorderincident_PrincipalObjectAttributeAccesses

One-To-Many Relationship: [msdyn_workorderincident msdyn_workorderincident_PrincipalObjectAttributeAccesses](msdyn_workorderincident.md#BKMK_msdyn_workorderincident_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_workorderincident`|
|ReferencedAttribute|`msdyn_workorderincidentid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_workorderincident`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_workordernte_PrincipalObjectAttributeAccesses"></a> msdyn_workordernte_PrincipalObjectAttributeAccesses

One-To-Many Relationship: [msdyn_workordernte msdyn_workordernte_PrincipalObjectAttributeAccesses](msdyn_workordernte.md#BKMK_msdyn_workordernte_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_workordernte`|
|ReferencedAttribute|`msdyn_workordernteid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_workordernte`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_workorderproduct_PrincipalObjectAttributeAccesses"></a> msdyn_workorderproduct_PrincipalObjectAttributeAccesses

One-To-Many Relationship: [msdyn_workorderproduct msdyn_workorderproduct_PrincipalObjectAttributeAccesses](msdyn_workorderproduct.md#BKMK_msdyn_workorderproduct_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_workorderproduct`|
|ReferencedAttribute|`msdyn_workorderproductid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_workorderproduct`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_workorderresolution_PrincipalObjectAttributeAccesses"></a> msdyn_workorderresolution_PrincipalObjectAttributeAccesses

One-To-Many Relationship: [msdyn_workorderresolution msdyn_workorderresolution_PrincipalObjectAttributeAccesses](msdyn_workorderresolution.md#BKMK_msdyn_workorderresolution_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_workorderresolution`|
|ReferencedAttribute|`msdyn_workorderresolutionid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_workorderresolution`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_workorderresourcerestriction_PrincipalObjectAttributeAccesses"></a> msdyn_workorderresourcerestriction_PrincipalObjectAttributeAccesses

One-To-Many Relationship: [msdyn_workorderresourcerestriction msdyn_workorderresourcerestriction_PrincipalObjectAttributeAccesses](msdyn_workorderresourcerestriction.md#BKMK_msdyn_workorderresourcerestriction_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_workorderresourcerestriction`|
|ReferencedAttribute|`msdyn_workorderresourcerestrictionid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_workorderresourcerestriction`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_workorderservice_PrincipalObjectAttributeAccesses"></a> msdyn_workorderservice_PrincipalObjectAttributeAccesses

One-To-Many Relationship: [msdyn_workorderservice msdyn_workorderservice_PrincipalObjectAttributeAccesses](msdyn_workorderservice.md#BKMK_msdyn_workorderservice_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_workorderservice`|
|ReferencedAttribute|`msdyn_workorderserviceid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_workorderservice`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_workorderservicetask_PrincipalObjectAttributeAccesses"></a> msdyn_workorderservicetask_PrincipalObjectAttributeAccesses

One-To-Many Relationship: [msdyn_workorderservicetask msdyn_workorderservicetask_PrincipalObjectAttributeAccesses](msdyn_workorderservicetask.md#BKMK_msdyn_workorderservicetask_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_workorderservicetask`|
|ReferencedAttribute|`msdyn_workorderservicetaskid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_workorderservicetask`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_workordersubstatus_PrincipalObjectAttributeAccesses"></a> msdyn_workordersubstatus_PrincipalObjectAttributeAccesses

One-To-Many Relationship: [msdyn_workordersubstatus msdyn_workordersubstatus_PrincipalObjectAttributeAccesses](msdyn_workordersubstatus.md#BKMK_msdyn_workordersubstatus_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_workordersubstatus`|
|ReferencedAttribute|`msdyn_workordersubstatusid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_workordersubstatus`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_workordertype_PrincipalObjectAttributeAccesses"></a> msdyn_workordertype_PrincipalObjectAttributeAccesses

One-To-Many Relationship: [msdyn_workordertype msdyn_workordertype_PrincipalObjectAttributeAccesses](msdyn_workordertype.md#BKMK_msdyn_workordertype_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_workordertype`|
|ReferencedAttribute|`msdyn_workordertypeid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_workordertype`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|



### See also

[Dataverse table/entity reference](../about-entity-reference.md)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   
<xref:Microsoft.Dynamics.CRM.principalobjectattributeaccess?displayProperty=fullName>
