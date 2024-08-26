---
title: "Business Unit (BusinessUnit) table/entity reference (Microsoft Dynamics 365 Field Service)"
description: "Includes schema information and supported messages for the Business Unit (BusinessUnit) table/entity with Microsoft Dynamics 365 Field Service."
ms.date: 08/26/2024
ms.service: powerapps
ms.topic: reference
author: m-hartmann
ms.author: mhart
search.audienceType: 
  - developer
---

# Business Unit (BusinessUnit) table/entity reference

Business, division, or department in the Microsoft Dynamics 365 database.

> [!NOTE]
> The Microsoft Dynamics 365 Field Service Business Unit (BusinessUnit) table extends the [Microsoft Dynamics 365 Business Unit (BusinessUnit) table](/dynamics365/developer/entities/businessunit).



## Writable columns/attributes

These columns/attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

### <a name="BKMK_msdyn_Warehouse"></a> msdyn_Warehouse

|Property|Value|
|---|---|
|Description|**Unique identifier for Warehouse associated with Business Unit.**|
|DisplayName|**Warehouse (Deprecated)**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_warehouse`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|msdyn_warehouse|


## Many-to-One relationships

These relationships are many-to-one. Listed by **SchemaName**.

### <a name="BKMK_msdyn_msdyn_warehouse_businessunit_Warehouse"></a> msdyn_msdyn_warehouse_businessunit_Warehouse

One-To-Many Relationship: [msdyn_warehouse msdyn_msdyn_warehouse_businessunit_Warehouse](msdyn_warehouse.md#BKMK_msdyn_msdyn_warehouse_businessunit_Warehouse)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_warehouse`|
|ReferencedAttribute|`msdyn_warehouseid`|
|ReferencingAttribute|`msdyn_warehouse`|
|ReferencingEntityNavigationPropertyName|`msdyn_warehouse`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|


## One-to-Many relationships

These relationships are one-to-many. Listed by **SchemaName**.

- [business_unit_msdyn_actual](#BKMK_business_unit_msdyn_actual)
- [business_unit_msdyn_agreement](#BKMK_business_unit_msdyn_agreement)
- [business_unit_msdyn_agreementbookingdate](#BKMK_business_unit_msdyn_agreementbookingdate)
- [business_unit_msdyn_agreementbookingincident](#BKMK_business_unit_msdyn_agreementbookingincident)
- [business_unit_msdyn_agreementbookingproduct](#BKMK_business_unit_msdyn_agreementbookingproduct)
- [business_unit_msdyn_agreementbookingservice](#BKMK_business_unit_msdyn_agreementbookingservice)
- [business_unit_msdyn_agreementbookingservicetask](#BKMK_business_unit_msdyn_agreementbookingservicetask)
- [business_unit_msdyn_agreementbookingsetup](#BKMK_business_unit_msdyn_agreementbookingsetup)
- [business_unit_msdyn_agreementinvoicedate](#BKMK_business_unit_msdyn_agreementinvoicedate)
- [business_unit_msdyn_agreementinvoiceproduct](#BKMK_business_unit_msdyn_agreementinvoiceproduct)
- [business_unit_msdyn_agreementinvoicesetup](#BKMK_business_unit_msdyn_agreementinvoicesetup)
- [business_unit_msdyn_agreementsubstatus](#BKMK_business_unit_msdyn_agreementsubstatus)
- [business_unit_msdyn_bookableresourceassociation](#BKMK_business_unit_msdyn_bookableresourceassociation)
- [business_unit_msdyn_bookableresourcebookingquicknote](#BKMK_business_unit_msdyn_bookableresourcebookingquicknote)
- [business_unit_msdyn_bookingalertstatus](#BKMK_business_unit_msdyn_bookingalertstatus)
- [business_unit_msdyn_bookingchange](#BKMK_business_unit_msdyn_bookingchange)
- [business_unit_msdyn_bookingjournal](#BKMK_business_unit_msdyn_bookingjournal)
- [business_unit_msdyn_bookingrule](#BKMK_business_unit_msdyn_bookingrule)
- [business_unit_msdyn_bookingsetupmetadata](#BKMK_business_unit_msdyn_bookingsetupmetadata)
- [business_unit_msdyn_bookingtimestamp](#BKMK_business_unit_msdyn_bookingtimestamp)
- [business_unit_msdyn_businessclosure](#BKMK_business_unit_msdyn_businessclosure)
- [business_unit_msdyn_clientextension](#BKMK_business_unit_msdyn_clientextension)
- [business_unit_msdyn_configuration](#BKMK_business_unit_msdyn_configuration)
- [business_unit_msdyn_consoleapplicationsessiontemplate](#BKMK_business_unit_msdyn_consoleapplicationsessiontemplate)
- [business_unit_msdyn_entitlementapplication](#BKMK_business_unit_msdyn_entitlementapplication)
- [business_unit_msdyn_entityconfiguration](#BKMK_business_unit_msdyn_entityconfiguration)
- [business_unit_msdyn_fieldservicesetting](#BKMK_business_unit_msdyn_fieldservicesetting)
- [business_unit_msdyn_fieldserviceslaconfiguration](#BKMK_business_unit_msdyn_fieldserviceslaconfiguration)
- [business_unit_msdyn_fieldservicesummaryconfiguration](#BKMK_business_unit_msdyn_fieldservicesummaryconfiguration)
- [business_unit_msdyn_geofence](#BKMK_business_unit_msdyn_geofence)
- [business_unit_msdyn_geofenceevent](#BKMK_business_unit_msdyn_geofenceevent)
- [business_unit_msdyn_geofencingsettings](#BKMK_business_unit_msdyn_geofencingsettings)
- [business_unit_msdyn_incidenttype](#BKMK_business_unit_msdyn_incidenttype)
- [business_unit_msdyn_incidenttype_requirementgroup](#BKMK_business_unit_msdyn_incidenttype_requirementgroup)
- [business_unit_msdyn_incidenttypecharacteristic](#BKMK_business_unit_msdyn_incidenttypecharacteristic)
- [business_unit_msdyn_incidenttypeproduct](#BKMK_business_unit_msdyn_incidenttypeproduct)
- [business_unit_msdyn_incidenttyperecommendationresult](#BKMK_business_unit_msdyn_incidenttyperecommendationresult)
- [business_unit_msdyn_incidenttyperecommendationrunhistory](#BKMK_business_unit_msdyn_incidenttyperecommendationrunhistory)
- [business_unit_msdyn_incidenttyperesolution](#BKMK_business_unit_msdyn_incidenttyperesolution)
- [business_unit_msdyn_incidenttypeservice](#BKMK_business_unit_msdyn_incidenttypeservice)
- [business_unit_msdyn_incidenttypeservicetask](#BKMK_business_unit_msdyn_incidenttypeservicetask)
- [business_unit_msdyn_incidenttypessetup](#BKMK_business_unit_msdyn_incidenttypessetup)
- [business_unit_msdyn_inspection](#BKMK_business_unit_msdyn_inspection)
- [business_unit_msdyn_inspectionattachment](#BKMK_business_unit_msdyn_inspectionattachment)
- [business_unit_msdyn_inspectiondefinition](#BKMK_business_unit_msdyn_inspectiondefinition)
- [business_unit_msdyn_inspectioninstance](#BKMK_business_unit_msdyn_inspectioninstance)
- [business_unit_msdyn_inspectionresponse](#BKMK_business_unit_msdyn_inspectionresponse)
- [business_unit_msdyn_insurance](#BKMK_business_unit_msdyn_insurance)
- [business_unit_msdyn_inventoryadjustment](#BKMK_business_unit_msdyn_inventoryadjustment)
- [business_unit_msdyn_inventoryadjustmentproduct](#BKMK_business_unit_msdyn_inventoryadjustmentproduct)
- [business_unit_msdyn_inventoryjournal](#BKMK_business_unit_msdyn_inventoryjournal)
- [business_unit_msdyn_inventorytransfer](#BKMK_business_unit_msdyn_inventorytransfer)
- [business_unit_msdyn_mobilesource](#BKMK_business_unit_msdyn_mobilesource)
- [business_unit_msdyn_nottoexceed](#BKMK_business_unit_msdyn_nottoexceed)
- [business_unit_msdyn_optimizationrequest](#BKMK_business_unit_msdyn_optimizationrequest)
- [business_unit_msdyn_orderinvoicingdate](#BKMK_business_unit_msdyn_orderinvoicingdate)
- [business_unit_msdyn_orderinvoicingproduct](#BKMK_business_unit_msdyn_orderinvoicingproduct)
- [business_unit_msdyn_orderinvoicingsetup](#BKMK_business_unit_msdyn_orderinvoicingsetup)
- [business_unit_msdyn_orderinvoicingsetupdate](#BKMK_business_unit_msdyn_orderinvoicingsetupdate)
- [business_unit_msdyn_payment](#BKMK_business_unit_msdyn_payment)
- [business_unit_msdyn_paymentdetail](#BKMK_business_unit_msdyn_paymentdetail)
- [business_unit_msdyn_paymentmethod](#BKMK_business_unit_msdyn_paymentmethod)
- [business_unit_msdyn_paymentterm](#BKMK_business_unit_msdyn_paymentterm)
- [business_unit_msdyn_postalcode](#BKMK_business_unit_msdyn_postalcode)
- [business_unit_msdyn_priority](#BKMK_business_unit_msdyn_priority)
- [business_unit_msdyn_problematicasset](#BKMK_business_unit_msdyn_problematicasset)
- [business_unit_msdyn_problematicassetfeedback](#BKMK_business_unit_msdyn_problematicassetfeedback)
- [business_unit_msdyn_purchaseorder](#BKMK_business_unit_msdyn_purchaseorder)
- [business_unit_msdyn_purchaseorderbill](#BKMK_business_unit_msdyn_purchaseorderbill)
- [business_unit_msdyn_purchaseorderproduct](#BKMK_business_unit_msdyn_purchaseorderproduct)
- [business_unit_msdyn_purchaseorderreceipt](#BKMK_business_unit_msdyn_purchaseorderreceipt)
- [business_unit_msdyn_purchaseorderreceiptproduct](#BKMK_business_unit_msdyn_purchaseorderreceiptproduct)
- [business_unit_msdyn_purchaseordersubstatus](#BKMK_business_unit_msdyn_purchaseordersubstatus)
- [business_unit_msdyn_quotebookingincident](#BKMK_business_unit_msdyn_quotebookingincident)
- [business_unit_msdyn_quotebookingproduct](#BKMK_business_unit_msdyn_quotebookingproduct)
- [business_unit_msdyn_quotebookingservice](#BKMK_business_unit_msdyn_quotebookingservice)
- [business_unit_msdyn_quotebookingservicetask](#BKMK_business_unit_msdyn_quotebookingservicetask)
- [business_unit_msdyn_quotebookingsetup](#BKMK_business_unit_msdyn_quotebookingsetup)
- [business_unit_msdyn_quoteinvoicingproduct](#BKMK_business_unit_msdyn_quoteinvoicingproduct)
- [business_unit_msdyn_quoteinvoicingsetup](#BKMK_business_unit_msdyn_quoteinvoicingsetup)
- [business_unit_msdyn_requirementchange](#BKMK_business_unit_msdyn_requirementchange)
- [business_unit_msdyn_requirementcharacteristic](#BKMK_business_unit_msdyn_requirementcharacteristic)
- [business_unit_msdyn_requirementdependency](#BKMK_business_unit_msdyn_requirementdependency)
- [business_unit_msdyn_requirementgroup](#BKMK_business_unit_msdyn_requirementgroup)
- [business_unit_msdyn_requirementorganizationunit](#BKMK_business_unit_msdyn_requirementorganizationunit)
- [business_unit_msdyn_requirementrelationship](#BKMK_business_unit_msdyn_requirementrelationship)
- [business_unit_msdyn_requirementresourcecategory](#BKMK_business_unit_msdyn_requirementresourcecategory)
- [business_unit_msdyn_requirementresourcepreference](#BKMK_business_unit_msdyn_requirementresourcepreference)
- [business_unit_msdyn_requirementstatus](#BKMK_business_unit_msdyn_requirementstatus)
- [business_unit_msdyn_resolution](#BKMK_business_unit_msdyn_resolution)
- [business_unit_msdyn_resourcepaytype](#BKMK_business_unit_msdyn_resourcepaytype)
- [business_unit_msdyn_resourcerequirement](#BKMK_business_unit_msdyn_resourcerequirement)
- [business_unit_msdyn_resourcerequirementdetail](#BKMK_business_unit_msdyn_resourcerequirementdetail)
- [business_unit_msdyn_resourceterritory](#BKMK_business_unit_msdyn_resourceterritory)
- [business_unit_msdyn_rma](#BKMK_business_unit_msdyn_rma)
- [business_unit_msdyn_rmaproduct](#BKMK_business_unit_msdyn_rmaproduct)
- [business_unit_msdyn_rmareceipt](#BKMK_business_unit_msdyn_rmareceipt)
- [business_unit_msdyn_rmareceiptproduct](#BKMK_business_unit_msdyn_rmareceiptproduct)
- [business_unit_msdyn_rmasubstatus](#BKMK_business_unit_msdyn_rmasubstatus)
- [business_unit_msdyn_rtv](#BKMK_business_unit_msdyn_rtv)
- [business_unit_msdyn_rtvproduct](#BKMK_business_unit_msdyn_rtvproduct)
- [business_unit_msdyn_rtvsubstatus](#BKMK_business_unit_msdyn_rtvsubstatus)
- [business_unit_msdyn_scheduleboardsetting](#BKMK_business_unit_msdyn_scheduleboardsetting)
- [business_unit_msdyn_schedulingfeatureflag](#BKMK_business_unit_msdyn_schedulingfeatureflag)
- [business_unit_msdyn_servicetasktype](#BKMK_business_unit_msdyn_servicetasktype)
- [business_unit_msdyn_sessiondata](#BKMK_business_unit_msdyn_sessiondata)
- [business_unit_msdyn_sessionparticipantdata](#BKMK_business_unit_msdyn_sessionparticipantdata)
- [business_unit_msdyn_shipvia](#BKMK_business_unit_msdyn_shipvia)
- [business_unit_msdyn_systemuserschedulersetting](#BKMK_business_unit_msdyn_systemuserschedulersetting)
- [business_unit_msdyn_taxcode](#BKMK_business_unit_msdyn_taxcode)
- [business_unit_msdyn_taxcodedetail](#BKMK_business_unit_msdyn_taxcodedetail)
- [business_unit_msdyn_timeentry](#BKMK_business_unit_msdyn_timeentry)
- [business_unit_msdyn_timeentrysetting](#BKMK_business_unit_msdyn_timeentrysetting)
- [business_unit_msdyn_timegroup](#BKMK_business_unit_msdyn_timegroup)
- [business_unit_msdyn_timegroupdetail](#BKMK_business_unit_msdyn_timegroupdetail)
- [business_unit_msdyn_timeoffrequest](#BKMK_business_unit_msdyn_timeoffrequest)
- [business_unit_msdyn_trade](#BKMK_business_unit_msdyn_trade)
- [business_unit_msdyn_tradecoverage](#BKMK_business_unit_msdyn_tradecoverage)
- [business_unit_msdyn_transactionorigin](#BKMK_business_unit_msdyn_transactionorigin)
- [business_unit_msdyn_warehouse](#BKMK_business_unit_msdyn_warehouse)
- [business_unit_msdyn_workhourtemplate](#BKMK_business_unit_msdyn_workhourtemplate)
- [business_unit_msdyn_workorder](#BKMK_business_unit_msdyn_workorder)
- [business_unit_msdyn_workorderincident](#BKMK_business_unit_msdyn_workorderincident)
- [business_unit_msdyn_workordernte](#BKMK_business_unit_msdyn_workordernte)
- [business_unit_msdyn_workorderproduct](#BKMK_business_unit_msdyn_workorderproduct)
- [business_unit_msdyn_workorderresolution](#BKMK_business_unit_msdyn_workorderresolution)
- [business_unit_msdyn_workorderresourcerestriction](#BKMK_business_unit_msdyn_workorderresourcerestriction)
- [business_unit_msdyn_workorderservice](#BKMK_business_unit_msdyn_workorderservice)
- [business_unit_msdyn_workorderservicetask](#BKMK_business_unit_msdyn_workorderservicetask)
- [business_unit_msdyn_workordersubstatus](#BKMK_business_unit_msdyn_workordersubstatus)
- [business_unit_msdyn_workordertype](#BKMK_business_unit_msdyn_workordertype)
- [msdyn_bookingalert_businessunit_owningbusinessunit](#BKMK_msdyn_bookingalert_businessunit_owningbusinessunit)

### <a name="BKMK_business_unit_msdyn_actual"></a> business_unit_msdyn_actual

Many-To-One Relationship: [msdyn_actual business_unit_msdyn_actual](msdyn_actual.md#BKMK_business_unit_msdyn_actual)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_actual`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msdyn_actual`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msdyn_agreement"></a> business_unit_msdyn_agreement

Many-To-One Relationship: [msdyn_agreement business_unit_msdyn_agreement](msdyn_agreement.md#BKMK_business_unit_msdyn_agreement)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_agreement`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msdyn_agreement`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msdyn_agreementbookingdate"></a> business_unit_msdyn_agreementbookingdate

Many-To-One Relationship: [msdyn_agreementbookingdate business_unit_msdyn_agreementbookingdate](msdyn_agreementbookingdate.md#BKMK_business_unit_msdyn_agreementbookingdate)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_agreementbookingdate`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msdyn_agreementbookingdate`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msdyn_agreementbookingincident"></a> business_unit_msdyn_agreementbookingincident

Many-To-One Relationship: [msdyn_agreementbookingincident business_unit_msdyn_agreementbookingincident](msdyn_agreementbookingincident.md#BKMK_business_unit_msdyn_agreementbookingincident)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_agreementbookingincident`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msdyn_agreementbookingincident`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msdyn_agreementbookingproduct"></a> business_unit_msdyn_agreementbookingproduct

Many-To-One Relationship: [msdyn_agreementbookingproduct business_unit_msdyn_agreementbookingproduct](msdyn_agreementbookingproduct.md#BKMK_business_unit_msdyn_agreementbookingproduct)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_agreementbookingproduct`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msdyn_agreementbookingproduct`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msdyn_agreementbookingservice"></a> business_unit_msdyn_agreementbookingservice

Many-To-One Relationship: [msdyn_agreementbookingservice business_unit_msdyn_agreementbookingservice](msdyn_agreementbookingservice.md#BKMK_business_unit_msdyn_agreementbookingservice)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_agreementbookingservice`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msdyn_agreementbookingservice`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msdyn_agreementbookingservicetask"></a> business_unit_msdyn_agreementbookingservicetask

Many-To-One Relationship: [msdyn_agreementbookingservicetask business_unit_msdyn_agreementbookingservicetask](msdyn_agreementbookingservicetask.md#BKMK_business_unit_msdyn_agreementbookingservicetask)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_agreementbookingservicetask`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msdyn_agreementbookingservicetask`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msdyn_agreementbookingsetup"></a> business_unit_msdyn_agreementbookingsetup

Many-To-One Relationship: [msdyn_agreementbookingsetup business_unit_msdyn_agreementbookingsetup](msdyn_agreementbookingsetup.md#BKMK_business_unit_msdyn_agreementbookingsetup)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_agreementbookingsetup`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msdyn_agreementbookingsetup`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msdyn_agreementinvoicedate"></a> business_unit_msdyn_agreementinvoicedate

Many-To-One Relationship: [msdyn_agreementinvoicedate business_unit_msdyn_agreementinvoicedate](msdyn_agreementinvoicedate.md#BKMK_business_unit_msdyn_agreementinvoicedate)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_agreementinvoicedate`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msdyn_agreementinvoicedate`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msdyn_agreementinvoiceproduct"></a> business_unit_msdyn_agreementinvoiceproduct

Many-To-One Relationship: [msdyn_agreementinvoiceproduct business_unit_msdyn_agreementinvoiceproduct](msdyn_agreementinvoiceproduct.md#BKMK_business_unit_msdyn_agreementinvoiceproduct)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_agreementinvoiceproduct`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msdyn_agreementinvoiceproduct`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msdyn_agreementinvoicesetup"></a> business_unit_msdyn_agreementinvoicesetup

Many-To-One Relationship: [msdyn_agreementinvoicesetup business_unit_msdyn_agreementinvoicesetup](msdyn_agreementinvoicesetup.md#BKMK_business_unit_msdyn_agreementinvoicesetup)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_agreementinvoicesetup`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msdyn_agreementinvoicesetup`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msdyn_agreementsubstatus"></a> business_unit_msdyn_agreementsubstatus

Many-To-One Relationship: [msdyn_agreementsubstatus business_unit_msdyn_agreementsubstatus](msdyn_agreementsubstatus.md#BKMK_business_unit_msdyn_agreementsubstatus)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_agreementsubstatus`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msdyn_agreementsubstatus`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msdyn_bookableresourceassociation"></a> business_unit_msdyn_bookableresourceassociation

Many-To-One Relationship: [msdyn_bookableresourceassociation business_unit_msdyn_bookableresourceassociation](msdyn_bookableresourceassociation.md#BKMK_business_unit_msdyn_bookableresourceassociation)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_bookableresourceassociation`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msdyn_bookableresourceassociation`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msdyn_bookableresourcebookingquicknote"></a> business_unit_msdyn_bookableresourcebookingquicknote

Many-To-One Relationship: [msdyn_bookableresourcebookingquicknote business_unit_msdyn_bookableresourcebookingquicknote](msdyn_bookableresourcebookingquicknote.md#BKMK_business_unit_msdyn_bookableresourcebookingquicknote)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_bookableresourcebookingquicknote`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msdyn_bookableresourcebookingquicknote`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msdyn_bookingalertstatus"></a> business_unit_msdyn_bookingalertstatus

Many-To-One Relationship: [msdyn_bookingalertstatus business_unit_msdyn_bookingalertstatus](msdyn_bookingalertstatus.md#BKMK_business_unit_msdyn_bookingalertstatus)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_bookingalertstatus`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msdyn_bookingalertstatus`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msdyn_bookingchange"></a> business_unit_msdyn_bookingchange

Many-To-One Relationship: [msdyn_bookingchange business_unit_msdyn_bookingchange](msdyn_bookingchange.md#BKMK_business_unit_msdyn_bookingchange)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_bookingchange`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msdyn_bookingchange`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msdyn_bookingjournal"></a> business_unit_msdyn_bookingjournal

Many-To-One Relationship: [msdyn_bookingjournal business_unit_msdyn_bookingjournal](msdyn_bookingjournal.md#BKMK_business_unit_msdyn_bookingjournal)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_bookingjournal`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msdyn_bookingjournal`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msdyn_bookingrule"></a> business_unit_msdyn_bookingrule

Many-To-One Relationship: [msdyn_bookingrule business_unit_msdyn_bookingrule](msdyn_bookingrule.md#BKMK_business_unit_msdyn_bookingrule)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_bookingrule`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msdyn_bookingrule`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msdyn_bookingsetupmetadata"></a> business_unit_msdyn_bookingsetupmetadata

Many-To-One Relationship: [msdyn_bookingsetupmetadata business_unit_msdyn_bookingsetupmetadata](msdyn_bookingsetupmetadata.md#BKMK_business_unit_msdyn_bookingsetupmetadata)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_bookingsetupmetadata`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msdyn_bookingsetupmetadata`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msdyn_bookingtimestamp"></a> business_unit_msdyn_bookingtimestamp

Many-To-One Relationship: [msdyn_bookingtimestamp business_unit_msdyn_bookingtimestamp](msdyn_bookingtimestamp.md#BKMK_business_unit_msdyn_bookingtimestamp)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_bookingtimestamp`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msdyn_bookingtimestamp`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msdyn_businessclosure"></a> business_unit_msdyn_businessclosure

Many-To-One Relationship: [msdyn_businessclosure business_unit_msdyn_businessclosure](msdyn_businessclosure.md#BKMK_business_unit_msdyn_businessclosure)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_businessclosure`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msdyn_businessclosure`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msdyn_clientextension"></a> business_unit_msdyn_clientextension

Many-To-One Relationship: [msdyn_clientextension business_unit_msdyn_clientextension](msdyn_clientextension.md#BKMK_business_unit_msdyn_clientextension)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_clientextension`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msdyn_clientextension`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msdyn_configuration"></a> business_unit_msdyn_configuration

Many-To-One Relationship: [msdyn_configuration business_unit_msdyn_configuration](msdyn_configuration.md#BKMK_business_unit_msdyn_configuration)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_configuration`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msdyn_configuration`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msdyn_consoleapplicationsessiontemplate"></a> business_unit_msdyn_consoleapplicationsessiontemplate

Many-To-One Relationship: [msdyn_consoleapplicationsessiontemplate business_unit_msdyn_consoleapplicationsessiontemplate](msdyn_consoleapplicationsessiontemplate.md#BKMK_business_unit_msdyn_consoleapplicationsessiontemplate)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_consoleapplicationsessiontemplate`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msdyn_consoleapplicationsessiontemplate`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msdyn_entitlementapplication"></a> business_unit_msdyn_entitlementapplication

Many-To-One Relationship: [msdyn_entitlementapplication business_unit_msdyn_entitlementapplication](msdyn_entitlementapplication.md#BKMK_business_unit_msdyn_entitlementapplication)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_entitlementapplication`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msdyn_entitlementapplication`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msdyn_entityconfiguration"></a> business_unit_msdyn_entityconfiguration

Many-To-One Relationship: [msdyn_entityconfiguration business_unit_msdyn_entityconfiguration](msdyn_entityconfiguration.md#BKMK_business_unit_msdyn_entityconfiguration)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_entityconfiguration`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msdyn_entityconfiguration`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msdyn_fieldservicesetting"></a> business_unit_msdyn_fieldservicesetting

Many-To-One Relationship: [msdyn_fieldservicesetting business_unit_msdyn_fieldservicesetting](msdyn_fieldservicesetting.md#BKMK_business_unit_msdyn_fieldservicesetting)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_fieldservicesetting`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msdyn_fieldservicesetting`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msdyn_fieldserviceslaconfiguration"></a> business_unit_msdyn_fieldserviceslaconfiguration

Many-To-One Relationship: [msdyn_fieldserviceslaconfiguration business_unit_msdyn_fieldserviceslaconfiguration](msdyn_fieldserviceslaconfiguration.md#BKMK_business_unit_msdyn_fieldserviceslaconfiguration)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_fieldserviceslaconfiguration`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msdyn_fieldserviceslaconfiguration`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msdyn_fieldservicesummaryconfiguration"></a> business_unit_msdyn_fieldservicesummaryconfiguration

Many-To-One Relationship: [msdyn_fieldservicesummaryconfiguration business_unit_msdyn_fieldservicesummaryconfiguration](msdyn_fieldservicesummaryconfiguration.md#BKMK_business_unit_msdyn_fieldservicesummaryconfiguration)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_fieldservicesummaryconfiguration`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msdyn_fieldservicesummaryconfiguration`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msdyn_geofence"></a> business_unit_msdyn_geofence

Many-To-One Relationship: [msdyn_geofence business_unit_msdyn_geofence](msdyn_geofence.md#BKMK_business_unit_msdyn_geofence)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_geofence`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msdyn_geofence`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msdyn_geofenceevent"></a> business_unit_msdyn_geofenceevent

Many-To-One Relationship: [msdyn_geofenceevent business_unit_msdyn_geofenceevent](msdyn_geofenceevent.md#BKMK_business_unit_msdyn_geofenceevent)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_geofenceevent`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msdyn_geofenceevent`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msdyn_geofencingsettings"></a> business_unit_msdyn_geofencingsettings

Many-To-One Relationship: [msdyn_geofencingsettings business_unit_msdyn_geofencingsettings](msdyn_geofencingsettings.md#BKMK_business_unit_msdyn_geofencingsettings)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_geofencingsettings`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msdyn_geofencingsettings`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msdyn_incidenttype"></a> business_unit_msdyn_incidenttype

Many-To-One Relationship: [msdyn_incidenttype business_unit_msdyn_incidenttype](msdyn_incidenttype.md#BKMK_business_unit_msdyn_incidenttype)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_incidenttype`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msdyn_incidenttype`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msdyn_incidenttype_requirementgroup"></a> business_unit_msdyn_incidenttype_requirementgroup

Many-To-One Relationship: [msdyn_incidenttype_requirementgroup business_unit_msdyn_incidenttype_requirementgroup](msdyn_incidenttype_requirementgroup.md#BKMK_business_unit_msdyn_incidenttype_requirementgroup)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_incidenttype_requirementgroup`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msdyn_incidenttype_requirementgroup`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msdyn_incidenttypecharacteristic"></a> business_unit_msdyn_incidenttypecharacteristic

Many-To-One Relationship: [msdyn_incidenttypecharacteristic business_unit_msdyn_incidenttypecharacteristic](msdyn_incidenttypecharacteristic.md#BKMK_business_unit_msdyn_incidenttypecharacteristic)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_incidenttypecharacteristic`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msdyn_incidenttypecharacteristic`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msdyn_incidenttypeproduct"></a> business_unit_msdyn_incidenttypeproduct

Many-To-One Relationship: [msdyn_incidenttypeproduct business_unit_msdyn_incidenttypeproduct](msdyn_incidenttypeproduct.md#BKMK_business_unit_msdyn_incidenttypeproduct)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_incidenttypeproduct`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msdyn_incidenttypeproduct`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msdyn_incidenttyperecommendationresult"></a> business_unit_msdyn_incidenttyperecommendationresult

Many-To-One Relationship: [msdyn_incidenttyperecommendationresult business_unit_msdyn_incidenttyperecommendationresult](msdyn_incidenttyperecommendationresult.md#BKMK_business_unit_msdyn_incidenttyperecommendationresult)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_incidenttyperecommendationresult`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msdyn_incidenttyperecommendationresult`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msdyn_incidenttyperecommendationrunhistory"></a> business_unit_msdyn_incidenttyperecommendationrunhistory

Many-To-One Relationship: [msdyn_incidenttyperecommendationrunhistory business_unit_msdyn_incidenttyperecommendationrunhistory](msdyn_incidenttyperecommendationrunhistory.md#BKMK_business_unit_msdyn_incidenttyperecommendationrunhistory)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_incidenttyperecommendationrunhistory`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msdyn_incidenttyperecommendationrunhistory`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msdyn_incidenttyperesolution"></a> business_unit_msdyn_incidenttyperesolution

Many-To-One Relationship: [msdyn_incidenttyperesolution business_unit_msdyn_incidenttyperesolution](msdyn_incidenttyperesolution.md#BKMK_business_unit_msdyn_incidenttyperesolution)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_incidenttyperesolution`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msdyn_incidenttyperesolution`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msdyn_incidenttypeservice"></a> business_unit_msdyn_incidenttypeservice

Many-To-One Relationship: [msdyn_incidenttypeservice business_unit_msdyn_incidenttypeservice](msdyn_incidenttypeservice.md#BKMK_business_unit_msdyn_incidenttypeservice)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_incidenttypeservice`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msdyn_incidenttypeservice`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msdyn_incidenttypeservicetask"></a> business_unit_msdyn_incidenttypeservicetask

Many-To-One Relationship: [msdyn_incidenttypeservicetask business_unit_msdyn_incidenttypeservicetask](msdyn_incidenttypeservicetask.md#BKMK_business_unit_msdyn_incidenttypeservicetask)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_incidenttypeservicetask`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msdyn_incidenttypeservicetask`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msdyn_incidenttypessetup"></a> business_unit_msdyn_incidenttypessetup

Many-To-One Relationship: [msdyn_incidenttypessetup business_unit_msdyn_incidenttypessetup](msdyn_incidenttypessetup.md#BKMK_business_unit_msdyn_incidenttypessetup)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_incidenttypessetup`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msdyn_incidenttypessetup`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msdyn_inspection"></a> business_unit_msdyn_inspection

Many-To-One Relationship: [msdyn_inspection business_unit_msdyn_inspection](msdyn_inspection.md#BKMK_business_unit_msdyn_inspection)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_inspection`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msdyn_inspection`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msdyn_inspectionattachment"></a> business_unit_msdyn_inspectionattachment

Many-To-One Relationship: [msdyn_inspectionattachment business_unit_msdyn_inspectionattachment](msdyn_inspectionattachment.md#BKMK_business_unit_msdyn_inspectionattachment)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_inspectionattachment`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msdyn_inspectionattachment`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msdyn_inspectiondefinition"></a> business_unit_msdyn_inspectiondefinition

Many-To-One Relationship: [msdyn_inspectiondefinition business_unit_msdyn_inspectiondefinition](msdyn_inspectiondefinition.md#BKMK_business_unit_msdyn_inspectiondefinition)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_inspectiondefinition`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msdyn_inspectiondefinition`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msdyn_inspectioninstance"></a> business_unit_msdyn_inspectioninstance

Many-To-One Relationship: [msdyn_inspectioninstance business_unit_msdyn_inspectioninstance](msdyn_inspectioninstance.md#BKMK_business_unit_msdyn_inspectioninstance)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_inspectioninstance`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msdyn_inspectioninstance`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msdyn_inspectionresponse"></a> business_unit_msdyn_inspectionresponse

Many-To-One Relationship: [msdyn_inspectionresponse business_unit_msdyn_inspectionresponse](msdyn_inspectionresponse.md#BKMK_business_unit_msdyn_inspectionresponse)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_inspectionresponse`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msdyn_inspectionresponse`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msdyn_insurance"></a> business_unit_msdyn_insurance

Many-To-One Relationship: [msdyn_insurance business_unit_msdyn_insurance](msdyn_insurance.md#BKMK_business_unit_msdyn_insurance)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_insurance`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msdyn_insurance`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msdyn_inventoryadjustment"></a> business_unit_msdyn_inventoryadjustment

Many-To-One Relationship: [msdyn_inventoryadjustment business_unit_msdyn_inventoryadjustment](msdyn_inventoryadjustment.md#BKMK_business_unit_msdyn_inventoryadjustment)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_inventoryadjustment`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msdyn_inventoryadjustment`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msdyn_inventoryadjustmentproduct"></a> business_unit_msdyn_inventoryadjustmentproduct

Many-To-One Relationship: [msdyn_inventoryadjustmentproduct business_unit_msdyn_inventoryadjustmentproduct](msdyn_inventoryadjustmentproduct.md#BKMK_business_unit_msdyn_inventoryadjustmentproduct)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_inventoryadjustmentproduct`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msdyn_inventoryadjustmentproduct`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msdyn_inventoryjournal"></a> business_unit_msdyn_inventoryjournal

Many-To-One Relationship: [msdyn_inventoryjournal business_unit_msdyn_inventoryjournal](msdyn_inventoryjournal.md#BKMK_business_unit_msdyn_inventoryjournal)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_inventoryjournal`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msdyn_inventoryjournal`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msdyn_inventorytransfer"></a> business_unit_msdyn_inventorytransfer

Many-To-One Relationship: [msdyn_inventorytransfer business_unit_msdyn_inventorytransfer](msdyn_inventorytransfer.md#BKMK_business_unit_msdyn_inventorytransfer)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_inventorytransfer`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msdyn_inventorytransfer`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msdyn_mobilesource"></a> business_unit_msdyn_mobilesource

Many-To-One Relationship: [msdyn_mobilesource business_unit_msdyn_mobilesource](msdyn_mobilesource.md#BKMK_business_unit_msdyn_mobilesource)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_mobilesource`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msdyn_mobilesource`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msdyn_nottoexceed"></a> business_unit_msdyn_nottoexceed

Many-To-One Relationship: [msdyn_nottoexceed business_unit_msdyn_nottoexceed](msdyn_nottoexceed.md#BKMK_business_unit_msdyn_nottoexceed)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_nottoexceed`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msdyn_nottoexceed`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msdyn_optimizationrequest"></a> business_unit_msdyn_optimizationrequest

Many-To-One Relationship: [msdyn_optimizationrequest business_unit_msdyn_optimizationrequest](msdyn_optimizationrequest.md#BKMK_business_unit_msdyn_optimizationrequest)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_optimizationrequest`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msdyn_optimizationrequest`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msdyn_orderinvoicingdate"></a> business_unit_msdyn_orderinvoicingdate

Many-To-One Relationship: [msdyn_orderinvoicingdate business_unit_msdyn_orderinvoicingdate](msdyn_orderinvoicingdate.md#BKMK_business_unit_msdyn_orderinvoicingdate)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_orderinvoicingdate`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msdyn_orderinvoicingdate`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msdyn_orderinvoicingproduct"></a> business_unit_msdyn_orderinvoicingproduct

Many-To-One Relationship: [msdyn_orderinvoicingproduct business_unit_msdyn_orderinvoicingproduct](msdyn_orderinvoicingproduct.md#BKMK_business_unit_msdyn_orderinvoicingproduct)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_orderinvoicingproduct`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msdyn_orderinvoicingproduct`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msdyn_orderinvoicingsetup"></a> business_unit_msdyn_orderinvoicingsetup

Many-To-One Relationship: [msdyn_orderinvoicingsetup business_unit_msdyn_orderinvoicingsetup](msdyn_orderinvoicingsetup.md#BKMK_business_unit_msdyn_orderinvoicingsetup)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_orderinvoicingsetup`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msdyn_orderinvoicingsetup`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msdyn_orderinvoicingsetupdate"></a> business_unit_msdyn_orderinvoicingsetupdate

Many-To-One Relationship: [msdyn_orderinvoicingsetupdate business_unit_msdyn_orderinvoicingsetupdate](msdyn_orderinvoicingsetupdate.md#BKMK_business_unit_msdyn_orderinvoicingsetupdate)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_orderinvoicingsetupdate`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msdyn_orderinvoicingsetupdate`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msdyn_payment"></a> business_unit_msdyn_payment

Many-To-One Relationship: [msdyn_payment business_unit_msdyn_payment](msdyn_payment.md#BKMK_business_unit_msdyn_payment)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_payment`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msdyn_payment`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msdyn_paymentdetail"></a> business_unit_msdyn_paymentdetail

Many-To-One Relationship: [msdyn_paymentdetail business_unit_msdyn_paymentdetail](msdyn_paymentdetail.md#BKMK_business_unit_msdyn_paymentdetail)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_paymentdetail`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msdyn_paymentdetail`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msdyn_paymentmethod"></a> business_unit_msdyn_paymentmethod

Many-To-One Relationship: [msdyn_paymentmethod business_unit_msdyn_paymentmethod](msdyn_paymentmethod.md#BKMK_business_unit_msdyn_paymentmethod)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_paymentmethod`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msdyn_paymentmethod`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msdyn_paymentterm"></a> business_unit_msdyn_paymentterm

Many-To-One Relationship: [msdyn_paymentterm business_unit_msdyn_paymentterm](msdyn_paymentterm.md#BKMK_business_unit_msdyn_paymentterm)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_paymentterm`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msdyn_paymentterm`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msdyn_postalcode"></a> business_unit_msdyn_postalcode

Many-To-One Relationship: [msdyn_postalcode business_unit_msdyn_postalcode](msdyn_postalcode.md#BKMK_business_unit_msdyn_postalcode)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_postalcode`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msdyn_postalcode`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msdyn_priority"></a> business_unit_msdyn_priority

Many-To-One Relationship: [msdyn_priority business_unit_msdyn_priority](msdyn_priority.md#BKMK_business_unit_msdyn_priority)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_priority`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msdyn_priority`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msdyn_problematicasset"></a> business_unit_msdyn_problematicasset

Many-To-One Relationship: [msdyn_problematicasset business_unit_msdyn_problematicasset](msdyn_problematicasset.md#BKMK_business_unit_msdyn_problematicasset)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_problematicasset`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msdyn_problematicasset`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msdyn_problematicassetfeedback"></a> business_unit_msdyn_problematicassetfeedback

Many-To-One Relationship: [msdyn_problematicassetfeedback business_unit_msdyn_problematicassetfeedback](msdyn_problematicassetfeedback.md#BKMK_business_unit_msdyn_problematicassetfeedback)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_problematicassetfeedback`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msdyn_problematicassetfeedback`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msdyn_purchaseorder"></a> business_unit_msdyn_purchaseorder

Many-To-One Relationship: [msdyn_purchaseorder business_unit_msdyn_purchaseorder](msdyn_purchaseorder.md#BKMK_business_unit_msdyn_purchaseorder)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_purchaseorder`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msdyn_purchaseorder`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msdyn_purchaseorderbill"></a> business_unit_msdyn_purchaseorderbill

Many-To-One Relationship: [msdyn_purchaseorderbill business_unit_msdyn_purchaseorderbill](msdyn_purchaseorderbill.md#BKMK_business_unit_msdyn_purchaseorderbill)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_purchaseorderbill`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msdyn_purchaseorderbill`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msdyn_purchaseorderproduct"></a> business_unit_msdyn_purchaseorderproduct

Many-To-One Relationship: [msdyn_purchaseorderproduct business_unit_msdyn_purchaseorderproduct](msdyn_purchaseorderproduct.md#BKMK_business_unit_msdyn_purchaseorderproduct)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_purchaseorderproduct`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msdyn_purchaseorderproduct`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msdyn_purchaseorderreceipt"></a> business_unit_msdyn_purchaseorderreceipt

Many-To-One Relationship: [msdyn_purchaseorderreceipt business_unit_msdyn_purchaseorderreceipt](msdyn_purchaseorderreceipt.md#BKMK_business_unit_msdyn_purchaseorderreceipt)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_purchaseorderreceipt`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msdyn_purchaseorderreceipt`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msdyn_purchaseorderreceiptproduct"></a> business_unit_msdyn_purchaseorderreceiptproduct

Many-To-One Relationship: [msdyn_purchaseorderreceiptproduct business_unit_msdyn_purchaseorderreceiptproduct](msdyn_purchaseorderreceiptproduct.md#BKMK_business_unit_msdyn_purchaseorderreceiptproduct)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_purchaseorderreceiptproduct`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msdyn_purchaseorderreceiptproduct`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msdyn_purchaseordersubstatus"></a> business_unit_msdyn_purchaseordersubstatus

Many-To-One Relationship: [msdyn_purchaseordersubstatus business_unit_msdyn_purchaseordersubstatus](msdyn_purchaseordersubstatus.md#BKMK_business_unit_msdyn_purchaseordersubstatus)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_purchaseordersubstatus`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msdyn_purchaseordersubstatus`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msdyn_quotebookingincident"></a> business_unit_msdyn_quotebookingincident

Many-To-One Relationship: [msdyn_quotebookingincident business_unit_msdyn_quotebookingincident](msdyn_quotebookingincident.md#BKMK_business_unit_msdyn_quotebookingincident)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_quotebookingincident`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msdyn_quotebookingincident`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msdyn_quotebookingproduct"></a> business_unit_msdyn_quotebookingproduct

Many-To-One Relationship: [msdyn_quotebookingproduct business_unit_msdyn_quotebookingproduct](msdyn_quotebookingproduct.md#BKMK_business_unit_msdyn_quotebookingproduct)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_quotebookingproduct`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msdyn_quotebookingproduct`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msdyn_quotebookingservice"></a> business_unit_msdyn_quotebookingservice

Many-To-One Relationship: [msdyn_quotebookingservice business_unit_msdyn_quotebookingservice](msdyn_quotebookingservice.md#BKMK_business_unit_msdyn_quotebookingservice)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_quotebookingservice`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msdyn_quotebookingservice`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msdyn_quotebookingservicetask"></a> business_unit_msdyn_quotebookingservicetask

Many-To-One Relationship: [msdyn_quotebookingservicetask business_unit_msdyn_quotebookingservicetask](msdyn_quotebookingservicetask.md#BKMK_business_unit_msdyn_quotebookingservicetask)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_quotebookingservicetask`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msdyn_quotebookingservicetask`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msdyn_quotebookingsetup"></a> business_unit_msdyn_quotebookingsetup

Many-To-One Relationship: [msdyn_quotebookingsetup business_unit_msdyn_quotebookingsetup](msdyn_quotebookingsetup.md#BKMK_business_unit_msdyn_quotebookingsetup)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_quotebookingsetup`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msdyn_quotebookingsetup`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msdyn_quoteinvoicingproduct"></a> business_unit_msdyn_quoteinvoicingproduct

Many-To-One Relationship: [msdyn_quoteinvoicingproduct business_unit_msdyn_quoteinvoicingproduct](msdyn_quoteinvoicingproduct.md#BKMK_business_unit_msdyn_quoteinvoicingproduct)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_quoteinvoicingproduct`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msdyn_quoteinvoicingproduct`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msdyn_quoteinvoicingsetup"></a> business_unit_msdyn_quoteinvoicingsetup

Many-To-One Relationship: [msdyn_quoteinvoicingsetup business_unit_msdyn_quoteinvoicingsetup](msdyn_quoteinvoicingsetup.md#BKMK_business_unit_msdyn_quoteinvoicingsetup)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_quoteinvoicingsetup`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msdyn_quoteinvoicingsetup`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msdyn_requirementchange"></a> business_unit_msdyn_requirementchange

Many-To-One Relationship: [msdyn_requirementchange business_unit_msdyn_requirementchange](msdyn_requirementchange.md#BKMK_business_unit_msdyn_requirementchange)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_requirementchange`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msdyn_requirementchange`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msdyn_requirementcharacteristic"></a> business_unit_msdyn_requirementcharacteristic

Many-To-One Relationship: [msdyn_requirementcharacteristic business_unit_msdyn_requirementcharacteristic](msdyn_requirementcharacteristic.md#BKMK_business_unit_msdyn_requirementcharacteristic)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_requirementcharacteristic`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msdyn_requirementcharacteristic`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msdyn_requirementdependency"></a> business_unit_msdyn_requirementdependency

Many-To-One Relationship: [msdyn_requirementdependency business_unit_msdyn_requirementdependency](msdyn_requirementdependency.md#BKMK_business_unit_msdyn_requirementdependency)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_requirementdependency`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msdyn_requirementdependency`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msdyn_requirementgroup"></a> business_unit_msdyn_requirementgroup

Many-To-One Relationship: [msdyn_requirementgroup business_unit_msdyn_requirementgroup](msdyn_requirementgroup.md#BKMK_business_unit_msdyn_requirementgroup)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_requirementgroup`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msdyn_requirementgroup`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msdyn_requirementorganizationunit"></a> business_unit_msdyn_requirementorganizationunit

Many-To-One Relationship: [msdyn_requirementorganizationunit business_unit_msdyn_requirementorganizationunit](msdyn_requirementorganizationunit.md#BKMK_business_unit_msdyn_requirementorganizationunit)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_requirementorganizationunit`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msdyn_requirementorganizationunit`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msdyn_requirementrelationship"></a> business_unit_msdyn_requirementrelationship

Many-To-One Relationship: [msdyn_requirementrelationship business_unit_msdyn_requirementrelationship](msdyn_requirementrelationship.md#BKMK_business_unit_msdyn_requirementrelationship)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_requirementrelationship`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msdyn_requirementrelationship`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msdyn_requirementresourcecategory"></a> business_unit_msdyn_requirementresourcecategory

Many-To-One Relationship: [msdyn_requirementresourcecategory business_unit_msdyn_requirementresourcecategory](msdyn_requirementresourcecategory.md#BKMK_business_unit_msdyn_requirementresourcecategory)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_requirementresourcecategory`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msdyn_requirementresourcecategory`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msdyn_requirementresourcepreference"></a> business_unit_msdyn_requirementresourcepreference

Many-To-One Relationship: [msdyn_requirementresourcepreference business_unit_msdyn_requirementresourcepreference](msdyn_requirementresourcepreference.md#BKMK_business_unit_msdyn_requirementresourcepreference)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_requirementresourcepreference`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msdyn_requirementresourcepreference`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msdyn_requirementstatus"></a> business_unit_msdyn_requirementstatus

Many-To-One Relationship: [msdyn_requirementstatus business_unit_msdyn_requirementstatus](msdyn_requirementstatus.md#BKMK_business_unit_msdyn_requirementstatus)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_requirementstatus`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msdyn_requirementstatus`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msdyn_resolution"></a> business_unit_msdyn_resolution

Many-To-One Relationship: [msdyn_resolution business_unit_msdyn_resolution](msdyn_resolution.md#BKMK_business_unit_msdyn_resolution)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_resolution`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msdyn_resolution`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msdyn_resourcepaytype"></a> business_unit_msdyn_resourcepaytype

Many-To-One Relationship: [msdyn_resourcepaytype business_unit_msdyn_resourcepaytype](msdyn_resourcepaytype.md#BKMK_business_unit_msdyn_resourcepaytype)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_resourcepaytype`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msdyn_resourcepaytype`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msdyn_resourcerequirement"></a> business_unit_msdyn_resourcerequirement

Many-To-One Relationship: [msdyn_resourcerequirement business_unit_msdyn_resourcerequirement](msdyn_resourcerequirement.md#BKMK_business_unit_msdyn_resourcerequirement)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_resourcerequirement`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msdyn_resourcerequirement`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msdyn_resourcerequirementdetail"></a> business_unit_msdyn_resourcerequirementdetail

Many-To-One Relationship: [msdyn_resourcerequirementdetail business_unit_msdyn_resourcerequirementdetail](msdyn_resourcerequirementdetail.md#BKMK_business_unit_msdyn_resourcerequirementdetail)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_resourcerequirementdetail`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msdyn_resourcerequirementdetail`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msdyn_resourceterritory"></a> business_unit_msdyn_resourceterritory

Many-To-One Relationship: [msdyn_resourceterritory business_unit_msdyn_resourceterritory](msdyn_resourceterritory.md#BKMK_business_unit_msdyn_resourceterritory)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_resourceterritory`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msdyn_resourceterritory`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msdyn_rma"></a> business_unit_msdyn_rma

Many-To-One Relationship: [msdyn_rma business_unit_msdyn_rma](msdyn_rma.md#BKMK_business_unit_msdyn_rma)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_rma`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msdyn_rma`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msdyn_rmaproduct"></a> business_unit_msdyn_rmaproduct

Many-To-One Relationship: [msdyn_rmaproduct business_unit_msdyn_rmaproduct](msdyn_rmaproduct.md#BKMK_business_unit_msdyn_rmaproduct)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_rmaproduct`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msdyn_rmaproduct`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msdyn_rmareceipt"></a> business_unit_msdyn_rmareceipt

Many-To-One Relationship: [msdyn_rmareceipt business_unit_msdyn_rmareceipt](msdyn_rmareceipt.md#BKMK_business_unit_msdyn_rmareceipt)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_rmareceipt`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msdyn_rmareceipt`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msdyn_rmareceiptproduct"></a> business_unit_msdyn_rmareceiptproduct

Many-To-One Relationship: [msdyn_rmareceiptproduct business_unit_msdyn_rmareceiptproduct](msdyn_rmareceiptproduct.md#BKMK_business_unit_msdyn_rmareceiptproduct)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_rmareceiptproduct`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msdyn_rmareceiptproduct`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msdyn_rmasubstatus"></a> business_unit_msdyn_rmasubstatus

Many-To-One Relationship: [msdyn_rmasubstatus business_unit_msdyn_rmasubstatus](msdyn_rmasubstatus.md#BKMK_business_unit_msdyn_rmasubstatus)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_rmasubstatus`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msdyn_rmasubstatus`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msdyn_rtv"></a> business_unit_msdyn_rtv

Many-To-One Relationship: [msdyn_rtv business_unit_msdyn_rtv](msdyn_rtv.md#BKMK_business_unit_msdyn_rtv)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_rtv`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msdyn_rtv`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msdyn_rtvproduct"></a> business_unit_msdyn_rtvproduct

Many-To-One Relationship: [msdyn_rtvproduct business_unit_msdyn_rtvproduct](msdyn_rtvproduct.md#BKMK_business_unit_msdyn_rtvproduct)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_rtvproduct`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msdyn_rtvproduct`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msdyn_rtvsubstatus"></a> business_unit_msdyn_rtvsubstatus

Many-To-One Relationship: [msdyn_rtvsubstatus business_unit_msdyn_rtvsubstatus](msdyn_rtvsubstatus.md#BKMK_business_unit_msdyn_rtvsubstatus)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_rtvsubstatus`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msdyn_rtvsubstatus`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msdyn_scheduleboardsetting"></a> business_unit_msdyn_scheduleboardsetting

Many-To-One Relationship: [msdyn_scheduleboardsetting business_unit_msdyn_scheduleboardsetting](msdyn_scheduleboardsetting.md#BKMK_business_unit_msdyn_scheduleboardsetting)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_scheduleboardsetting`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msdyn_scheduleboardsetting`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msdyn_schedulingfeatureflag"></a> business_unit_msdyn_schedulingfeatureflag

Many-To-One Relationship: [msdyn_schedulingfeatureflag business_unit_msdyn_schedulingfeatureflag](msdyn_schedulingfeatureflag.md#BKMK_business_unit_msdyn_schedulingfeatureflag)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_schedulingfeatureflag`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msdyn_schedulingfeatureflag`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msdyn_servicetasktype"></a> business_unit_msdyn_servicetasktype

Many-To-One Relationship: [msdyn_servicetasktype business_unit_msdyn_servicetasktype](msdyn_servicetasktype.md#BKMK_business_unit_msdyn_servicetasktype)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_servicetasktype`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msdyn_servicetasktype`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msdyn_sessiondata"></a> business_unit_msdyn_sessiondata

Many-To-One Relationship: [msdyn_sessiondata business_unit_msdyn_sessiondata](msdyn_sessiondata.md#BKMK_business_unit_msdyn_sessiondata)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_sessiondata`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msdyn_sessiondata`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msdyn_sessionparticipantdata"></a> business_unit_msdyn_sessionparticipantdata

Many-To-One Relationship: [msdyn_sessionparticipantdata business_unit_msdyn_sessionparticipantdata](msdyn_sessionparticipantdata.md#BKMK_business_unit_msdyn_sessionparticipantdata)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_sessionparticipantdata`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msdyn_sessionparticipantdata`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msdyn_shipvia"></a> business_unit_msdyn_shipvia

Many-To-One Relationship: [msdyn_shipvia business_unit_msdyn_shipvia](msdyn_shipvia.md#BKMK_business_unit_msdyn_shipvia)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_shipvia`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msdyn_shipvia`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msdyn_systemuserschedulersetting"></a> business_unit_msdyn_systemuserschedulersetting

Many-To-One Relationship: [msdyn_systemuserschedulersetting business_unit_msdyn_systemuserschedulersetting](msdyn_systemuserschedulersetting.md#BKMK_business_unit_msdyn_systemuserschedulersetting)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_systemuserschedulersetting`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msdyn_systemuserschedulersetting`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msdyn_taxcode"></a> business_unit_msdyn_taxcode

Many-To-One Relationship: [msdyn_taxcode business_unit_msdyn_taxcode](msdyn_taxcode.md#BKMK_business_unit_msdyn_taxcode)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_taxcode`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msdyn_taxcode`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msdyn_taxcodedetail"></a> business_unit_msdyn_taxcodedetail

Many-To-One Relationship: [msdyn_taxcodedetail business_unit_msdyn_taxcodedetail](msdyn_taxcodedetail.md#BKMK_business_unit_msdyn_taxcodedetail)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_taxcodedetail`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msdyn_taxcodedetail`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msdyn_timeentry"></a> business_unit_msdyn_timeentry

Many-To-One Relationship: [msdyn_timeentry business_unit_msdyn_timeentry](msdyn_timeentry.md#BKMK_business_unit_msdyn_timeentry)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_timeentry`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msdyn_timeentry`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msdyn_timeentrysetting"></a> business_unit_msdyn_timeentrysetting

Many-To-One Relationship: [msdyn_timeentrysetting business_unit_msdyn_timeentrysetting](msdyn_timeentrysetting.md#BKMK_business_unit_msdyn_timeentrysetting)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_timeentrysetting`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msdyn_timeentrysetting`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msdyn_timegroup"></a> business_unit_msdyn_timegroup

Many-To-One Relationship: [msdyn_timegroup business_unit_msdyn_timegroup](msdyn_timegroup.md#BKMK_business_unit_msdyn_timegroup)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_timegroup`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msdyn_timegroup`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msdyn_timegroupdetail"></a> business_unit_msdyn_timegroupdetail

Many-To-One Relationship: [msdyn_timegroupdetail business_unit_msdyn_timegroupdetail](msdyn_timegroupdetail.md#BKMK_business_unit_msdyn_timegroupdetail)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_timegroupdetail`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msdyn_timegroupdetail`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msdyn_timeoffrequest"></a> business_unit_msdyn_timeoffrequest

Many-To-One Relationship: [msdyn_timeoffrequest business_unit_msdyn_timeoffrequest](msdyn_timeoffrequest.md#BKMK_business_unit_msdyn_timeoffrequest)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_timeoffrequest`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msdyn_timeoffrequest`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msdyn_trade"></a> business_unit_msdyn_trade

Many-To-One Relationship: [msdyn_trade business_unit_msdyn_trade](msdyn_trade.md#BKMK_business_unit_msdyn_trade)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_trade`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msdyn_trade`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msdyn_tradecoverage"></a> business_unit_msdyn_tradecoverage

Many-To-One Relationship: [msdyn_tradecoverage business_unit_msdyn_tradecoverage](msdyn_tradecoverage.md#BKMK_business_unit_msdyn_tradecoverage)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_tradecoverage`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msdyn_tradecoverage`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msdyn_transactionorigin"></a> business_unit_msdyn_transactionorigin

Many-To-One Relationship: [msdyn_transactionorigin business_unit_msdyn_transactionorigin](msdyn_transactionorigin.md#BKMK_business_unit_msdyn_transactionorigin)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_transactionorigin`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msdyn_transactionorigin`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msdyn_warehouse"></a> business_unit_msdyn_warehouse

Many-To-One Relationship: [msdyn_warehouse business_unit_msdyn_warehouse](msdyn_warehouse.md#BKMK_business_unit_msdyn_warehouse)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_warehouse`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msdyn_warehouse`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msdyn_workhourtemplate"></a> business_unit_msdyn_workhourtemplate

Many-To-One Relationship: [msdyn_workhourtemplate business_unit_msdyn_workhourtemplate](msdyn_workhourtemplate.md#BKMK_business_unit_msdyn_workhourtemplate)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_workhourtemplate`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msdyn_workhourtemplate`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msdyn_workorder"></a> business_unit_msdyn_workorder

Many-To-One Relationship: [msdyn_workorder business_unit_msdyn_workorder](msdyn_workorder.md#BKMK_business_unit_msdyn_workorder)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_workorder`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msdyn_workorder`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msdyn_workorderincident"></a> business_unit_msdyn_workorderincident

Many-To-One Relationship: [msdyn_workorderincident business_unit_msdyn_workorderincident](msdyn_workorderincident.md#BKMK_business_unit_msdyn_workorderincident)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_workorderincident`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msdyn_workorderincident`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msdyn_workordernte"></a> business_unit_msdyn_workordernte

Many-To-One Relationship: [msdyn_workordernte business_unit_msdyn_workordernte](msdyn_workordernte.md#BKMK_business_unit_msdyn_workordernte)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_workordernte`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msdyn_workordernte`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msdyn_workorderproduct"></a> business_unit_msdyn_workorderproduct

Many-To-One Relationship: [msdyn_workorderproduct business_unit_msdyn_workorderproduct](msdyn_workorderproduct.md#BKMK_business_unit_msdyn_workorderproduct)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_workorderproduct`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msdyn_workorderproduct`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msdyn_workorderresolution"></a> business_unit_msdyn_workorderresolution

Many-To-One Relationship: [msdyn_workorderresolution business_unit_msdyn_workorderresolution](msdyn_workorderresolution.md#BKMK_business_unit_msdyn_workorderresolution)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_workorderresolution`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msdyn_workorderresolution`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msdyn_workorderresourcerestriction"></a> business_unit_msdyn_workorderresourcerestriction

Many-To-One Relationship: [msdyn_workorderresourcerestriction business_unit_msdyn_workorderresourcerestriction](msdyn_workorderresourcerestriction.md#BKMK_business_unit_msdyn_workorderresourcerestriction)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_workorderresourcerestriction`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msdyn_workorderresourcerestriction`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msdyn_workorderservice"></a> business_unit_msdyn_workorderservice

Many-To-One Relationship: [msdyn_workorderservice business_unit_msdyn_workorderservice](msdyn_workorderservice.md#BKMK_business_unit_msdyn_workorderservice)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_workorderservice`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msdyn_workorderservice`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msdyn_workorderservicetask"></a> business_unit_msdyn_workorderservicetask

Many-To-One Relationship: [msdyn_workorderservicetask business_unit_msdyn_workorderservicetask](msdyn_workorderservicetask.md#BKMK_business_unit_msdyn_workorderservicetask)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_workorderservicetask`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msdyn_workorderservicetask`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msdyn_workordersubstatus"></a> business_unit_msdyn_workordersubstatus

Many-To-One Relationship: [msdyn_workordersubstatus business_unit_msdyn_workordersubstatus](msdyn_workordersubstatus.md#BKMK_business_unit_msdyn_workordersubstatus)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_workordersubstatus`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msdyn_workordersubstatus`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msdyn_workordertype"></a> business_unit_msdyn_workordertype

Many-To-One Relationship: [msdyn_workordertype business_unit_msdyn_workordertype](msdyn_workordertype.md#BKMK_business_unit_msdyn_workordertype)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_workordertype`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msdyn_workordertype`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_bookingalert_businessunit_owningbusinessunit"></a> msdyn_bookingalert_businessunit_owningbusinessunit

Many-To-One Relationship: [msdyn_bookingalert msdyn_bookingalert_businessunit_owningbusinessunit](msdyn_bookingalert.md#BKMK_msdyn_bookingalert_businessunit_owningbusinessunit)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_bookingalert`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`msdyn_bookingalert_businessunit_owningbusinessunit`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|



### See also

[Dataverse table/entity reference](../about-entity-reference.md)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   
<xref:Microsoft.Dynamics.CRM.businessunit?displayProperty=fullName>
