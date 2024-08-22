---
title: "Owner table/entity reference (Microsoft Dynamics 365 Field Service)"
description: "Includes schema information and supported messages for the Owner table/entity with Microsoft Dynamics 365 Field Service."
ms.date: 08/21/2024
ms.service: powerapps
ms.topic: reference
author: m-hartmann
ms.author: mhart
search.audienceType: 
  - developer
---

# Owner table/entity reference

Group of undeleted system users and undeleted teams. Owners can be used to control access to specific objects.

> [!NOTE]
> The Microsoft Dynamics 365 Field Service Owner table extends the [Microsoft Dynamics 365 Owner table](/dynamics365/developer/entities/owner).




## One-to-Many relationships

These relationships are one-to-many. Listed by **SchemaName**.

- [msdyn_bookingalert_owner_ownerid](#BKMK_msdyn_bookingalert_owner_ownerid)
- [owner_msdyn_actual](#BKMK_owner_msdyn_actual)
- [owner_msdyn_agreement](#BKMK_owner_msdyn_agreement)
- [owner_msdyn_agreementbookingdate](#BKMK_owner_msdyn_agreementbookingdate)
- [owner_msdyn_agreementbookingincident](#BKMK_owner_msdyn_agreementbookingincident)
- [owner_msdyn_agreementbookingproduct](#BKMK_owner_msdyn_agreementbookingproduct)
- [owner_msdyn_agreementbookingservice](#BKMK_owner_msdyn_agreementbookingservice)
- [owner_msdyn_agreementbookingservicetask](#BKMK_owner_msdyn_agreementbookingservicetask)
- [owner_msdyn_agreementbookingsetup](#BKMK_owner_msdyn_agreementbookingsetup)
- [owner_msdyn_agreementinvoicedate](#BKMK_owner_msdyn_agreementinvoicedate)
- [owner_msdyn_agreementinvoiceproduct](#BKMK_owner_msdyn_agreementinvoiceproduct)
- [owner_msdyn_agreementinvoicesetup](#BKMK_owner_msdyn_agreementinvoicesetup)
- [owner_msdyn_agreementsubstatus](#BKMK_owner_msdyn_agreementsubstatus)
- [owner_msdyn_analyticsforcs](#BKMK_owner_msdyn_analyticsforcs)
- [owner_msdyn_bookableresourceassociation](#BKMK_owner_msdyn_bookableresourceassociation)
- [owner_msdyn_bookableresourcebookingquicknote](#BKMK_owner_msdyn_bookableresourcebookingquicknote)
- [owner_msdyn_bookingalertstatus](#BKMK_owner_msdyn_bookingalertstatus)
- [owner_msdyn_bookingchange](#BKMK_owner_msdyn_bookingchange)
- [owner_msdyn_bookingjournal](#BKMK_owner_msdyn_bookingjournal)
- [owner_msdyn_bookingrule](#BKMK_owner_msdyn_bookingrule)
- [owner_msdyn_bookingsetupmetadata](#BKMK_owner_msdyn_bookingsetupmetadata)
- [owner_msdyn_bookingtimestamp](#BKMK_owner_msdyn_bookingtimestamp)
- [owner_msdyn_businessclosure](#BKMK_owner_msdyn_businessclosure)
- [owner_msdyn_clientextension](#BKMK_owner_msdyn_clientextension)
- [owner_msdyn_configuration](#BKMK_owner_msdyn_configuration)
- [owner_msdyn_consoleapplicationsessiontemplate](#BKMK_owner_msdyn_consoleapplicationsessiontemplate)
- [owner_msdyn_consoleapplicationtemplate](#BKMK_owner_msdyn_consoleapplicationtemplate)
- [owner_msdyn_consoleapplicationtemplateparameter](#BKMK_owner_msdyn_consoleapplicationtemplateparameter)
- [owner_msdyn_entitlementapplication](#BKMK_owner_msdyn_entitlementapplication)
- [owner_msdyn_entityconfiguration](#BKMK_owner_msdyn_entityconfiguration)
- [owner_msdyn_fieldservicesetting](#BKMK_owner_msdyn_fieldservicesetting)
- [owner_msdyn_fieldserviceslaconfiguration](#BKMK_owner_msdyn_fieldserviceslaconfiguration)
- [owner_msdyn_fieldservicesummaryconfiguration](#BKMK_owner_msdyn_fieldservicesummaryconfiguration)
- [owner_msdyn_geofence](#BKMK_owner_msdyn_geofence)
- [owner_msdyn_geofenceevent](#BKMK_owner_msdyn_geofenceevent)
- [owner_msdyn_geofencingsettings](#BKMK_owner_msdyn_geofencingsettings)
- [owner_msdyn_incidenttype](#BKMK_owner_msdyn_incidenttype)
- [owner_msdyn_incidenttype_requirementgroup](#BKMK_owner_msdyn_incidenttype_requirementgroup)
- [owner_msdyn_incidenttypecharacteristic](#BKMK_owner_msdyn_incidenttypecharacteristic)
- [owner_msdyn_incidenttypeproduct](#BKMK_owner_msdyn_incidenttypeproduct)
- [owner_msdyn_incidenttyperecommendationresult](#BKMK_owner_msdyn_incidenttyperecommendationresult)
- [owner_msdyn_incidenttyperecommendationrunhistory](#BKMK_owner_msdyn_incidenttyperecommendationrunhistory)
- [owner_msdyn_incidenttyperesolution](#BKMK_owner_msdyn_incidenttyperesolution)
- [owner_msdyn_incidenttypeservice](#BKMK_owner_msdyn_incidenttypeservice)
- [owner_msdyn_incidenttypeservicetask](#BKMK_owner_msdyn_incidenttypeservicetask)
- [owner_msdyn_incidenttypessetup](#BKMK_owner_msdyn_incidenttypessetup)
- [owner_msdyn_inspection](#BKMK_owner_msdyn_inspection)
- [owner_msdyn_inspectionattachment](#BKMK_owner_msdyn_inspectionattachment)
- [owner_msdyn_inspectiondefinition](#BKMK_owner_msdyn_inspectiondefinition)
- [owner_msdyn_inspectioninstance](#BKMK_owner_msdyn_inspectioninstance)
- [owner_msdyn_inspectionresponse](#BKMK_owner_msdyn_inspectionresponse)
- [owner_msdyn_insurance](#BKMK_owner_msdyn_insurance)
- [owner_msdyn_inventoryadjustment](#BKMK_owner_msdyn_inventoryadjustment)
- [owner_msdyn_inventoryadjustmentproduct](#BKMK_owner_msdyn_inventoryadjustmentproduct)
- [owner_msdyn_inventoryjournal](#BKMK_owner_msdyn_inventoryjournal)
- [owner_msdyn_inventorytransfer](#BKMK_owner_msdyn_inventorytransfer)
- [owner_msdyn_mobilesource](#BKMK_owner_msdyn_mobilesource)
- [owner_msdyn_nottoexceed](#BKMK_owner_msdyn_nottoexceed)
- [owner_msdyn_optimizationrequest](#BKMK_owner_msdyn_optimizationrequest)
- [owner_msdyn_orderinvoicingdate](#BKMK_owner_msdyn_orderinvoicingdate)
- [owner_msdyn_orderinvoicingproduct](#BKMK_owner_msdyn_orderinvoicingproduct)
- [owner_msdyn_orderinvoicingsetup](#BKMK_owner_msdyn_orderinvoicingsetup)
- [owner_msdyn_orderinvoicingsetupdate](#BKMK_owner_msdyn_orderinvoicingsetupdate)
- [owner_msdyn_payment](#BKMK_owner_msdyn_payment)
- [owner_msdyn_paymentdetail](#BKMK_owner_msdyn_paymentdetail)
- [owner_msdyn_paymentmethod](#BKMK_owner_msdyn_paymentmethod)
- [owner_msdyn_paymentterm](#BKMK_owner_msdyn_paymentterm)
- [owner_msdyn_playbookcategory](#BKMK_owner_msdyn_playbookcategory)
- [owner_msdyn_playbooktemplate](#BKMK_owner_msdyn_playbooktemplate)
- [owner_msdyn_postalcode](#BKMK_owner_msdyn_postalcode)
- [owner_msdyn_priority](#BKMK_owner_msdyn_priority)
- [owner_msdyn_problematicasset](#BKMK_owner_msdyn_problematicasset)
- [owner_msdyn_problematicassetfeedback](#BKMK_owner_msdyn_problematicassetfeedback)
- [owner_msdyn_purchaseorder](#BKMK_owner_msdyn_purchaseorder)
- [owner_msdyn_purchaseorderbill](#BKMK_owner_msdyn_purchaseorderbill)
- [owner_msdyn_purchaseorderproduct](#BKMK_owner_msdyn_purchaseorderproduct)
- [owner_msdyn_purchaseorderreceipt](#BKMK_owner_msdyn_purchaseorderreceipt)
- [owner_msdyn_purchaseorderreceiptproduct](#BKMK_owner_msdyn_purchaseorderreceiptproduct)
- [owner_msdyn_purchaseordersubstatus](#BKMK_owner_msdyn_purchaseordersubstatus)
- [owner_msdyn_quotebookingincident](#BKMK_owner_msdyn_quotebookingincident)
- [owner_msdyn_quotebookingproduct](#BKMK_owner_msdyn_quotebookingproduct)
- [owner_msdyn_quotebookingservice](#BKMK_owner_msdyn_quotebookingservice)
- [owner_msdyn_quotebookingservicetask](#BKMK_owner_msdyn_quotebookingservicetask)
- [owner_msdyn_quotebookingsetup](#BKMK_owner_msdyn_quotebookingsetup)
- [owner_msdyn_quoteinvoicingproduct](#BKMK_owner_msdyn_quoteinvoicingproduct)
- [owner_msdyn_quoteinvoicingsetup](#BKMK_owner_msdyn_quoteinvoicingsetup)
- [owner_msdyn_requirementchange](#BKMK_owner_msdyn_requirementchange)
- [owner_msdyn_requirementcharacteristic](#BKMK_owner_msdyn_requirementcharacteristic)
- [owner_msdyn_requirementdependency](#BKMK_owner_msdyn_requirementdependency)
- [owner_msdyn_requirementgroup](#BKMK_owner_msdyn_requirementgroup)
- [owner_msdyn_requirementorganizationunit](#BKMK_owner_msdyn_requirementorganizationunit)
- [owner_msdyn_requirementrelationship](#BKMK_owner_msdyn_requirementrelationship)
- [owner_msdyn_requirementresourcecategory](#BKMK_owner_msdyn_requirementresourcecategory)
- [owner_msdyn_requirementresourcepreference](#BKMK_owner_msdyn_requirementresourcepreference)
- [owner_msdyn_requirementstatus](#BKMK_owner_msdyn_requirementstatus)
- [owner_msdyn_resolution](#BKMK_owner_msdyn_resolution)
- [owner_msdyn_resourcepaytype](#BKMK_owner_msdyn_resourcepaytype)
- [owner_msdyn_resourcerequirement](#BKMK_owner_msdyn_resourcerequirement)
- [owner_msdyn_resourcerequirementdetail](#BKMK_owner_msdyn_resourcerequirementdetail)
- [owner_msdyn_resourceterritory](#BKMK_owner_msdyn_resourceterritory)
- [owner_msdyn_rma](#BKMK_owner_msdyn_rma)
- [owner_msdyn_rmaproduct](#BKMK_owner_msdyn_rmaproduct)
- [owner_msdyn_rmareceipt](#BKMK_owner_msdyn_rmareceipt)
- [owner_msdyn_rmareceiptproduct](#BKMK_owner_msdyn_rmareceiptproduct)
- [owner_msdyn_rmasubstatus](#BKMK_owner_msdyn_rmasubstatus)
- [owner_msdyn_rtv](#BKMK_owner_msdyn_rtv)
- [owner_msdyn_rtvproduct](#BKMK_owner_msdyn_rtvproduct)
- [owner_msdyn_rtvsubstatus](#BKMK_owner_msdyn_rtvsubstatus)
- [owner_msdyn_scheduleboardsetting](#BKMK_owner_msdyn_scheduleboardsetting)
- [owner_msdyn_schedulingfeatureflag](#BKMK_owner_msdyn_schedulingfeatureflag)
- [owner_msdyn_servicetasktype](#BKMK_owner_msdyn_servicetasktype)
- [owner_msdyn_sessiondata](#BKMK_owner_msdyn_sessiondata)
- [owner_msdyn_sessionparticipantdata](#BKMK_owner_msdyn_sessionparticipantdata)
- [owner_msdyn_shipvia](#BKMK_owner_msdyn_shipvia)
- [owner_msdyn_systemuserschedulersetting](#BKMK_owner_msdyn_systemuserschedulersetting)
- [owner_msdyn_taxcode](#BKMK_owner_msdyn_taxcode)
- [owner_msdyn_taxcodedetail](#BKMK_owner_msdyn_taxcodedetail)
- [owner_msdyn_templatetags](#BKMK_owner_msdyn_templatetags)
- [owner_msdyn_timeentry](#BKMK_owner_msdyn_timeentry)
- [owner_msdyn_timeentrysetting](#BKMK_owner_msdyn_timeentrysetting)
- [owner_msdyn_timegroup](#BKMK_owner_msdyn_timegroup)
- [owner_msdyn_timegroupdetail](#BKMK_owner_msdyn_timegroupdetail)
- [owner_msdyn_timeoffrequest](#BKMK_owner_msdyn_timeoffrequest)
- [owner_msdyn_trade](#BKMK_owner_msdyn_trade)
- [owner_msdyn_tradecoverage](#BKMK_owner_msdyn_tradecoverage)
- [owner_msdyn_transactionorigin](#BKMK_owner_msdyn_transactionorigin)
- [owner_msdyn_warehouse](#BKMK_owner_msdyn_warehouse)
- [owner_msdyn_workhourtemplate](#BKMK_owner_msdyn_workhourtemplate)
- [owner_msdyn_workorder](#BKMK_owner_msdyn_workorder)
- [owner_msdyn_workordercharacteristic](#BKMK_owner_msdyn_workordercharacteristic)
- [owner_msdyn_workorderincident](#BKMK_owner_msdyn_workorderincident)
- [owner_msdyn_workordernte](#BKMK_owner_msdyn_workordernte)
- [owner_msdyn_workorderproduct](#BKMK_owner_msdyn_workorderproduct)
- [owner_msdyn_workorderresolution](#BKMK_owner_msdyn_workorderresolution)
- [owner_msdyn_workorderresourcerestriction](#BKMK_owner_msdyn_workorderresourcerestriction)
- [owner_msdyn_workorderservice](#BKMK_owner_msdyn_workorderservice)
- [owner_msdyn_workorderservicetask](#BKMK_owner_msdyn_workorderservicetask)
- [owner_msdyn_workordersubstatus](#BKMK_owner_msdyn_workordersubstatus)
- [owner_msdyn_workordertype](#BKMK_owner_msdyn_workordertype)

### <a name="BKMK_msdyn_bookingalert_owner_ownerid"></a> msdyn_bookingalert_owner_ownerid

Many-To-One Relationship: [msdyn_bookingalert msdyn_bookingalert_owner_ownerid](msdyn_bookingalert.md#BKMK_msdyn_bookingalert_owner_ownerid)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_bookingalert`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`msdyn_bookingalert_owner_ownerid`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_actual"></a> owner_msdyn_actual

Many-To-One Relationship: [msdyn_actual owner_msdyn_actual](msdyn_actual.md#BKMK_owner_msdyn_actual)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_actual`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_actual`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_agreement"></a> owner_msdyn_agreement

Many-To-One Relationship: [msdyn_agreement owner_msdyn_agreement](msdyn_agreement.md#BKMK_owner_msdyn_agreement)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_agreement`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_agreement`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_agreementbookingdate"></a> owner_msdyn_agreementbookingdate

Many-To-One Relationship: [msdyn_agreementbookingdate owner_msdyn_agreementbookingdate](msdyn_agreementbookingdate.md#BKMK_owner_msdyn_agreementbookingdate)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_agreementbookingdate`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_agreementbookingdate`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_agreementbookingincident"></a> owner_msdyn_agreementbookingincident

Many-To-One Relationship: [msdyn_agreementbookingincident owner_msdyn_agreementbookingincident](msdyn_agreementbookingincident.md#BKMK_owner_msdyn_agreementbookingincident)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_agreementbookingincident`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_agreementbookingincident`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_agreementbookingproduct"></a> owner_msdyn_agreementbookingproduct

Many-To-One Relationship: [msdyn_agreementbookingproduct owner_msdyn_agreementbookingproduct](msdyn_agreementbookingproduct.md#BKMK_owner_msdyn_agreementbookingproduct)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_agreementbookingproduct`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_agreementbookingproduct`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_agreementbookingservice"></a> owner_msdyn_agreementbookingservice

Many-To-One Relationship: [msdyn_agreementbookingservice owner_msdyn_agreementbookingservice](msdyn_agreementbookingservice.md#BKMK_owner_msdyn_agreementbookingservice)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_agreementbookingservice`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_agreementbookingservice`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_agreementbookingservicetask"></a> owner_msdyn_agreementbookingservicetask

Many-To-One Relationship: [msdyn_agreementbookingservicetask owner_msdyn_agreementbookingservicetask](msdyn_agreementbookingservicetask.md#BKMK_owner_msdyn_agreementbookingservicetask)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_agreementbookingservicetask`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_agreementbookingservicetask`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_agreementbookingsetup"></a> owner_msdyn_agreementbookingsetup

Many-To-One Relationship: [msdyn_agreementbookingsetup owner_msdyn_agreementbookingsetup](msdyn_agreementbookingsetup.md#BKMK_owner_msdyn_agreementbookingsetup)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_agreementbookingsetup`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_agreementbookingsetup`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_agreementinvoicedate"></a> owner_msdyn_agreementinvoicedate

Many-To-One Relationship: [msdyn_agreementinvoicedate owner_msdyn_agreementinvoicedate](msdyn_agreementinvoicedate.md#BKMK_owner_msdyn_agreementinvoicedate)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_agreementinvoicedate`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_agreementinvoicedate`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_agreementinvoiceproduct"></a> owner_msdyn_agreementinvoiceproduct

Many-To-One Relationship: [msdyn_agreementinvoiceproduct owner_msdyn_agreementinvoiceproduct](msdyn_agreementinvoiceproduct.md#BKMK_owner_msdyn_agreementinvoiceproduct)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_agreementinvoiceproduct`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_agreementinvoiceproduct`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_agreementinvoicesetup"></a> owner_msdyn_agreementinvoicesetup

Many-To-One Relationship: [msdyn_agreementinvoicesetup owner_msdyn_agreementinvoicesetup](msdyn_agreementinvoicesetup.md#BKMK_owner_msdyn_agreementinvoicesetup)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_agreementinvoicesetup`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_agreementinvoicesetup`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_agreementsubstatus"></a> owner_msdyn_agreementsubstatus

Many-To-One Relationship: [msdyn_agreementsubstatus owner_msdyn_agreementsubstatus](msdyn_agreementsubstatus.md#BKMK_owner_msdyn_agreementsubstatus)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_agreementsubstatus`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_agreementsubstatus`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_analyticsforcs"></a> owner_msdyn_analyticsforcs

Many-To-One Relationship: [msdyn_analyticsforcs owner_msdyn_analyticsforcs](msdyn_analyticsforcs.md#BKMK_owner_msdyn_analyticsforcs)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_analyticsforcs`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_analyticsforcs`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_bookableresourceassociation"></a> owner_msdyn_bookableresourceassociation

Many-To-One Relationship: [msdyn_bookableresourceassociation owner_msdyn_bookableresourceassociation](msdyn_bookableresourceassociation.md#BKMK_owner_msdyn_bookableresourceassociation)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_bookableresourceassociation`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_bookableresourceassociation`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_bookableresourcebookingquicknote"></a> owner_msdyn_bookableresourcebookingquicknote

Many-To-One Relationship: [msdyn_bookableresourcebookingquicknote owner_msdyn_bookableresourcebookingquicknote](msdyn_bookableresourcebookingquicknote.md#BKMK_owner_msdyn_bookableresourcebookingquicknote)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_bookableresourcebookingquicknote`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_bookableresourcebookingquicknote`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_bookingalertstatus"></a> owner_msdyn_bookingalertstatus

Many-To-One Relationship: [msdyn_bookingalertstatus owner_msdyn_bookingalertstatus](msdyn_bookingalertstatus.md#BKMK_owner_msdyn_bookingalertstatus)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_bookingalertstatus`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_bookingalertstatus`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_bookingchange"></a> owner_msdyn_bookingchange

Many-To-One Relationship: [msdyn_bookingchange owner_msdyn_bookingchange](msdyn_bookingchange.md#BKMK_owner_msdyn_bookingchange)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_bookingchange`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_bookingchange`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_bookingjournal"></a> owner_msdyn_bookingjournal

Many-To-One Relationship: [msdyn_bookingjournal owner_msdyn_bookingjournal](msdyn_bookingjournal.md#BKMK_owner_msdyn_bookingjournal)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_bookingjournal`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_bookingjournal`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_bookingrule"></a> owner_msdyn_bookingrule

Many-To-One Relationship: [msdyn_bookingrule owner_msdyn_bookingrule](msdyn_bookingrule.md#BKMK_owner_msdyn_bookingrule)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_bookingrule`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_bookingrule`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_bookingsetupmetadata"></a> owner_msdyn_bookingsetupmetadata

Many-To-One Relationship: [msdyn_bookingsetupmetadata owner_msdyn_bookingsetupmetadata](msdyn_bookingsetupmetadata.md#BKMK_owner_msdyn_bookingsetupmetadata)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_bookingsetupmetadata`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_bookingsetupmetadata`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_bookingtimestamp"></a> owner_msdyn_bookingtimestamp

Many-To-One Relationship: [msdyn_bookingtimestamp owner_msdyn_bookingtimestamp](msdyn_bookingtimestamp.md#BKMK_owner_msdyn_bookingtimestamp)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_bookingtimestamp`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_bookingtimestamp`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_businessclosure"></a> owner_msdyn_businessclosure

Many-To-One Relationship: [msdyn_businessclosure owner_msdyn_businessclosure](msdyn_businessclosure.md#BKMK_owner_msdyn_businessclosure)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_businessclosure`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_businessclosure`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_clientextension"></a> owner_msdyn_clientextension

Many-To-One Relationship: [msdyn_clientextension owner_msdyn_clientextension](msdyn_clientextension.md#BKMK_owner_msdyn_clientextension)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_clientextension`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_clientextension`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_configuration"></a> owner_msdyn_configuration

Many-To-One Relationship: [msdyn_configuration owner_msdyn_configuration](msdyn_configuration.md#BKMK_owner_msdyn_configuration)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_configuration`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_configuration`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_consoleapplicationsessiontemplate"></a> owner_msdyn_consoleapplicationsessiontemplate

Many-To-One Relationship: [msdyn_consoleapplicationsessiontemplate owner_msdyn_consoleapplicationsessiontemplate](msdyn_consoleapplicationsessiontemplate.md#BKMK_owner_msdyn_consoleapplicationsessiontemplate)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_consoleapplicationsessiontemplate`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_consoleapplicationsessiontemplate`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_consoleapplicationtemplate"></a> owner_msdyn_consoleapplicationtemplate

Many-To-One Relationship: [msdyn_consoleapplicationtemplate owner_msdyn_consoleapplicationtemplate](msdyn_consoleapplicationtemplate.md#BKMK_owner_msdyn_consoleapplicationtemplate)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_consoleapplicationtemplate`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_consoleapplicationtemplate`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_consoleapplicationtemplateparameter"></a> owner_msdyn_consoleapplicationtemplateparameter

Many-To-One Relationship: [msdyn_consoleapplicationtemplateparameter owner_msdyn_consoleapplicationtemplateparameter](msdyn_consoleapplicationtemplateparameter.md#BKMK_owner_msdyn_consoleapplicationtemplateparameter)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_consoleapplicationtemplateparameter`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_consoleapplicationtemplateparameter`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_entitlementapplication"></a> owner_msdyn_entitlementapplication

Many-To-One Relationship: [msdyn_entitlementapplication owner_msdyn_entitlementapplication](msdyn_entitlementapplication.md#BKMK_owner_msdyn_entitlementapplication)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_entitlementapplication`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_entitlementapplication`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_entityconfiguration"></a> owner_msdyn_entityconfiguration

Many-To-One Relationship: [msdyn_entityconfiguration owner_msdyn_entityconfiguration](msdyn_entityconfiguration.md#BKMK_owner_msdyn_entityconfiguration)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_entityconfiguration`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_entityconfiguration`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_fieldservicesetting"></a> owner_msdyn_fieldservicesetting

Many-To-One Relationship: [msdyn_fieldservicesetting owner_msdyn_fieldservicesetting](msdyn_fieldservicesetting.md#BKMK_owner_msdyn_fieldservicesetting)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_fieldservicesetting`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_fieldservicesetting`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_fieldserviceslaconfiguration"></a> owner_msdyn_fieldserviceslaconfiguration

Many-To-One Relationship: [msdyn_fieldserviceslaconfiguration owner_msdyn_fieldserviceslaconfiguration](msdyn_fieldserviceslaconfiguration.md#BKMK_owner_msdyn_fieldserviceslaconfiguration)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_fieldserviceslaconfiguration`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_fieldserviceslaconfiguration`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_fieldservicesummaryconfiguration"></a> owner_msdyn_fieldservicesummaryconfiguration

Many-To-One Relationship: [msdyn_fieldservicesummaryconfiguration owner_msdyn_fieldservicesummaryconfiguration](msdyn_fieldservicesummaryconfiguration.md#BKMK_owner_msdyn_fieldservicesummaryconfiguration)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_fieldservicesummaryconfiguration`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_fieldservicesummaryconfiguration`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_geofence"></a> owner_msdyn_geofence

Many-To-One Relationship: [msdyn_geofence owner_msdyn_geofence](msdyn_geofence.md#BKMK_owner_msdyn_geofence)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_geofence`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_geofence`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_geofenceevent"></a> owner_msdyn_geofenceevent

Many-To-One Relationship: [msdyn_geofenceevent owner_msdyn_geofenceevent](msdyn_geofenceevent.md#BKMK_owner_msdyn_geofenceevent)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_geofenceevent`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_geofenceevent`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_geofencingsettings"></a> owner_msdyn_geofencingsettings

Many-To-One Relationship: [msdyn_geofencingsettings owner_msdyn_geofencingsettings](msdyn_geofencingsettings.md#BKMK_owner_msdyn_geofencingsettings)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_geofencingsettings`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_geofencingsettings`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_incidenttype"></a> owner_msdyn_incidenttype

Many-To-One Relationship: [msdyn_incidenttype owner_msdyn_incidenttype](msdyn_incidenttype.md#BKMK_owner_msdyn_incidenttype)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_incidenttype`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_incidenttype`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_incidenttype_requirementgroup"></a> owner_msdyn_incidenttype_requirementgroup

Many-To-One Relationship: [msdyn_incidenttype_requirementgroup owner_msdyn_incidenttype_requirementgroup](msdyn_incidenttype_requirementgroup.md#BKMK_owner_msdyn_incidenttype_requirementgroup)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_incidenttype_requirementgroup`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_incidenttype_requirementgroup`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_incidenttypecharacteristic"></a> owner_msdyn_incidenttypecharacteristic

Many-To-One Relationship: [msdyn_incidenttypecharacteristic owner_msdyn_incidenttypecharacteristic](msdyn_incidenttypecharacteristic.md#BKMK_owner_msdyn_incidenttypecharacteristic)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_incidenttypecharacteristic`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_incidenttypecharacteristic`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_incidenttypeproduct"></a> owner_msdyn_incidenttypeproduct

Many-To-One Relationship: [msdyn_incidenttypeproduct owner_msdyn_incidenttypeproduct](msdyn_incidenttypeproduct.md#BKMK_owner_msdyn_incidenttypeproduct)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_incidenttypeproduct`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_incidenttypeproduct`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_incidenttyperecommendationresult"></a> owner_msdyn_incidenttyperecommendationresult

Many-To-One Relationship: [msdyn_incidenttyperecommendationresult owner_msdyn_incidenttyperecommendationresult](msdyn_incidenttyperecommendationresult.md#BKMK_owner_msdyn_incidenttyperecommendationresult)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_incidenttyperecommendationresult`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_incidenttyperecommendationresult`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_incidenttyperecommendationrunhistory"></a> owner_msdyn_incidenttyperecommendationrunhistory

Many-To-One Relationship: [msdyn_incidenttyperecommendationrunhistory owner_msdyn_incidenttyperecommendationrunhistory](msdyn_incidenttyperecommendationrunhistory.md#BKMK_owner_msdyn_incidenttyperecommendationrunhistory)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_incidenttyperecommendationrunhistory`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_incidenttyperecommendationrunhistory`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_incidenttyperesolution"></a> owner_msdyn_incidenttyperesolution

Many-To-One Relationship: [msdyn_incidenttyperesolution owner_msdyn_incidenttyperesolution](msdyn_incidenttyperesolution.md#BKMK_owner_msdyn_incidenttyperesolution)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_incidenttyperesolution`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_incidenttyperesolution`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_incidenttypeservice"></a> owner_msdyn_incidenttypeservice

Many-To-One Relationship: [msdyn_incidenttypeservice owner_msdyn_incidenttypeservice](msdyn_incidenttypeservice.md#BKMK_owner_msdyn_incidenttypeservice)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_incidenttypeservice`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_incidenttypeservice`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_incidenttypeservicetask"></a> owner_msdyn_incidenttypeservicetask

Many-To-One Relationship: [msdyn_incidenttypeservicetask owner_msdyn_incidenttypeservicetask](msdyn_incidenttypeservicetask.md#BKMK_owner_msdyn_incidenttypeservicetask)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_incidenttypeservicetask`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_incidenttypeservicetask`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_incidenttypessetup"></a> owner_msdyn_incidenttypessetup

Many-To-One Relationship: [msdyn_incidenttypessetup owner_msdyn_incidenttypessetup](msdyn_incidenttypessetup.md#BKMK_owner_msdyn_incidenttypessetup)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_incidenttypessetup`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_incidenttypessetup`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_inspection"></a> owner_msdyn_inspection

Many-To-One Relationship: [msdyn_inspection owner_msdyn_inspection](msdyn_inspection.md#BKMK_owner_msdyn_inspection)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_inspection`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_inspection`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_inspectionattachment"></a> owner_msdyn_inspectionattachment

Many-To-One Relationship: [msdyn_inspectionattachment owner_msdyn_inspectionattachment](msdyn_inspectionattachment.md#BKMK_owner_msdyn_inspectionattachment)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_inspectionattachment`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_inspectionattachment`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_inspectiondefinition"></a> owner_msdyn_inspectiondefinition

Many-To-One Relationship: [msdyn_inspectiondefinition owner_msdyn_inspectiondefinition](msdyn_inspectiondefinition.md#BKMK_owner_msdyn_inspectiondefinition)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_inspectiondefinition`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_inspectiondefinition`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_inspectioninstance"></a> owner_msdyn_inspectioninstance

Many-To-One Relationship: [msdyn_inspectioninstance owner_msdyn_inspectioninstance](msdyn_inspectioninstance.md#BKMK_owner_msdyn_inspectioninstance)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_inspectioninstance`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_inspectioninstance`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_inspectionresponse"></a> owner_msdyn_inspectionresponse

Many-To-One Relationship: [msdyn_inspectionresponse owner_msdyn_inspectionresponse](msdyn_inspectionresponse.md#BKMK_owner_msdyn_inspectionresponse)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_inspectionresponse`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_inspectionresponse`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_insurance"></a> owner_msdyn_insurance

Many-To-One Relationship: [msdyn_insurance owner_msdyn_insurance](msdyn_insurance.md#BKMK_owner_msdyn_insurance)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_insurance`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_insurance`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_inventoryadjustment"></a> owner_msdyn_inventoryadjustment

Many-To-One Relationship: [msdyn_inventoryadjustment owner_msdyn_inventoryadjustment](msdyn_inventoryadjustment.md#BKMK_owner_msdyn_inventoryadjustment)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_inventoryadjustment`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_inventoryadjustment`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_inventoryadjustmentproduct"></a> owner_msdyn_inventoryadjustmentproduct

Many-To-One Relationship: [msdyn_inventoryadjustmentproduct owner_msdyn_inventoryadjustmentproduct](msdyn_inventoryadjustmentproduct.md#BKMK_owner_msdyn_inventoryadjustmentproduct)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_inventoryadjustmentproduct`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_inventoryadjustmentproduct`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_inventoryjournal"></a> owner_msdyn_inventoryjournal

Many-To-One Relationship: [msdyn_inventoryjournal owner_msdyn_inventoryjournal](msdyn_inventoryjournal.md#BKMK_owner_msdyn_inventoryjournal)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_inventoryjournal`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_inventoryjournal`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_inventorytransfer"></a> owner_msdyn_inventorytransfer

Many-To-One Relationship: [msdyn_inventorytransfer owner_msdyn_inventorytransfer](msdyn_inventorytransfer.md#BKMK_owner_msdyn_inventorytransfer)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_inventorytransfer`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_inventorytransfer`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_mobilesource"></a> owner_msdyn_mobilesource

Many-To-One Relationship: [msdyn_mobilesource owner_msdyn_mobilesource](msdyn_mobilesource.md#BKMK_owner_msdyn_mobilesource)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_mobilesource`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_mobilesource`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_nottoexceed"></a> owner_msdyn_nottoexceed

Many-To-One Relationship: [msdyn_nottoexceed owner_msdyn_nottoexceed](msdyn_nottoexceed.md#BKMK_owner_msdyn_nottoexceed)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_nottoexceed`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_nottoexceed`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_optimizationrequest"></a> owner_msdyn_optimizationrequest

Many-To-One Relationship: [msdyn_optimizationrequest owner_msdyn_optimizationrequest](msdyn_optimizationrequest.md#BKMK_owner_msdyn_optimizationrequest)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_optimizationrequest`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_optimizationrequest`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_orderinvoicingdate"></a> owner_msdyn_orderinvoicingdate

Many-To-One Relationship: [msdyn_orderinvoicingdate owner_msdyn_orderinvoicingdate](msdyn_orderinvoicingdate.md#BKMK_owner_msdyn_orderinvoicingdate)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_orderinvoicingdate`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_orderinvoicingdate`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_orderinvoicingproduct"></a> owner_msdyn_orderinvoicingproduct

Many-To-One Relationship: [msdyn_orderinvoicingproduct owner_msdyn_orderinvoicingproduct](msdyn_orderinvoicingproduct.md#BKMK_owner_msdyn_orderinvoicingproduct)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_orderinvoicingproduct`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_orderinvoicingproduct`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_orderinvoicingsetup"></a> owner_msdyn_orderinvoicingsetup

Many-To-One Relationship: [msdyn_orderinvoicingsetup owner_msdyn_orderinvoicingsetup](msdyn_orderinvoicingsetup.md#BKMK_owner_msdyn_orderinvoicingsetup)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_orderinvoicingsetup`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_orderinvoicingsetup`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_orderinvoicingsetupdate"></a> owner_msdyn_orderinvoicingsetupdate

Many-To-One Relationship: [msdyn_orderinvoicingsetupdate owner_msdyn_orderinvoicingsetupdate](msdyn_orderinvoicingsetupdate.md#BKMK_owner_msdyn_orderinvoicingsetupdate)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_orderinvoicingsetupdate`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_orderinvoicingsetupdate`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_payment"></a> owner_msdyn_payment

Many-To-One Relationship: [msdyn_payment owner_msdyn_payment](msdyn_payment.md#BKMK_owner_msdyn_payment)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_payment`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_payment`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_paymentdetail"></a> owner_msdyn_paymentdetail

Many-To-One Relationship: [msdyn_paymentdetail owner_msdyn_paymentdetail](msdyn_paymentdetail.md#BKMK_owner_msdyn_paymentdetail)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_paymentdetail`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_paymentdetail`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_paymentmethod"></a> owner_msdyn_paymentmethod

Many-To-One Relationship: [msdyn_paymentmethod owner_msdyn_paymentmethod](msdyn_paymentmethod.md#BKMK_owner_msdyn_paymentmethod)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_paymentmethod`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_paymentmethod`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_paymentterm"></a> owner_msdyn_paymentterm

Many-To-One Relationship: [msdyn_paymentterm owner_msdyn_paymentterm](msdyn_paymentterm.md#BKMK_owner_msdyn_paymentterm)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_paymentterm`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_paymentterm`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_playbookcategory"></a> owner_msdyn_playbookcategory

Many-To-One Relationship: [msdyn_playbookcategory owner_msdyn_playbookcategory](msdyn_playbookcategory.md#BKMK_owner_msdyn_playbookcategory)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_playbookcategory`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_playbookcategory`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_playbooktemplate"></a> owner_msdyn_playbooktemplate

Many-To-One Relationship: [msdyn_playbooktemplate owner_msdyn_playbooktemplate](msdyn_playbooktemplate.md#BKMK_owner_msdyn_playbooktemplate)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_playbooktemplate`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_playbooktemplate`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_postalcode"></a> owner_msdyn_postalcode

Many-To-One Relationship: [msdyn_postalcode owner_msdyn_postalcode](msdyn_postalcode.md#BKMK_owner_msdyn_postalcode)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_postalcode`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_postalcode`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_priority"></a> owner_msdyn_priority

Many-To-One Relationship: [msdyn_priority owner_msdyn_priority](msdyn_priority.md#BKMK_owner_msdyn_priority)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_priority`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_priority`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_problematicasset"></a> owner_msdyn_problematicasset

Many-To-One Relationship: [msdyn_problematicasset owner_msdyn_problematicasset](msdyn_problematicasset.md#BKMK_owner_msdyn_problematicasset)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_problematicasset`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_problematicasset`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_problematicassetfeedback"></a> owner_msdyn_problematicassetfeedback

Many-To-One Relationship: [msdyn_problematicassetfeedback owner_msdyn_problematicassetfeedback](msdyn_problematicassetfeedback.md#BKMK_owner_msdyn_problematicassetfeedback)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_problematicassetfeedback`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_problematicassetfeedback`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_purchaseorder"></a> owner_msdyn_purchaseorder

Many-To-One Relationship: [msdyn_purchaseorder owner_msdyn_purchaseorder](msdyn_purchaseorder.md#BKMK_owner_msdyn_purchaseorder)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_purchaseorder`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_purchaseorder`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_purchaseorderbill"></a> owner_msdyn_purchaseorderbill

Many-To-One Relationship: [msdyn_purchaseorderbill owner_msdyn_purchaseorderbill](msdyn_purchaseorderbill.md#BKMK_owner_msdyn_purchaseorderbill)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_purchaseorderbill`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_purchaseorderbill`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_purchaseorderproduct"></a> owner_msdyn_purchaseorderproduct

Many-To-One Relationship: [msdyn_purchaseorderproduct owner_msdyn_purchaseorderproduct](msdyn_purchaseorderproduct.md#BKMK_owner_msdyn_purchaseorderproduct)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_purchaseorderproduct`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_purchaseorderproduct`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_purchaseorderreceipt"></a> owner_msdyn_purchaseorderreceipt

Many-To-One Relationship: [msdyn_purchaseorderreceipt owner_msdyn_purchaseorderreceipt](msdyn_purchaseorderreceipt.md#BKMK_owner_msdyn_purchaseorderreceipt)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_purchaseorderreceipt`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_purchaseorderreceipt`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_purchaseorderreceiptproduct"></a> owner_msdyn_purchaseorderreceiptproduct

Many-To-One Relationship: [msdyn_purchaseorderreceiptproduct owner_msdyn_purchaseorderreceiptproduct](msdyn_purchaseorderreceiptproduct.md#BKMK_owner_msdyn_purchaseorderreceiptproduct)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_purchaseorderreceiptproduct`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_purchaseorderreceiptproduct`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_purchaseordersubstatus"></a> owner_msdyn_purchaseordersubstatus

Many-To-One Relationship: [msdyn_purchaseordersubstatus owner_msdyn_purchaseordersubstatus](msdyn_purchaseordersubstatus.md#BKMK_owner_msdyn_purchaseordersubstatus)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_purchaseordersubstatus`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_purchaseordersubstatus`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_quotebookingincident"></a> owner_msdyn_quotebookingincident

Many-To-One Relationship: [msdyn_quotebookingincident owner_msdyn_quotebookingincident](msdyn_quotebookingincident.md#BKMK_owner_msdyn_quotebookingincident)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_quotebookingincident`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_quotebookingincident`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_quotebookingproduct"></a> owner_msdyn_quotebookingproduct

Many-To-One Relationship: [msdyn_quotebookingproduct owner_msdyn_quotebookingproduct](msdyn_quotebookingproduct.md#BKMK_owner_msdyn_quotebookingproduct)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_quotebookingproduct`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_quotebookingproduct`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_quotebookingservice"></a> owner_msdyn_quotebookingservice

Many-To-One Relationship: [msdyn_quotebookingservice owner_msdyn_quotebookingservice](msdyn_quotebookingservice.md#BKMK_owner_msdyn_quotebookingservice)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_quotebookingservice`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_quotebookingservice`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_quotebookingservicetask"></a> owner_msdyn_quotebookingservicetask

Many-To-One Relationship: [msdyn_quotebookingservicetask owner_msdyn_quotebookingservicetask](msdyn_quotebookingservicetask.md#BKMK_owner_msdyn_quotebookingservicetask)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_quotebookingservicetask`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_quotebookingservicetask`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_quotebookingsetup"></a> owner_msdyn_quotebookingsetup

Many-To-One Relationship: [msdyn_quotebookingsetup owner_msdyn_quotebookingsetup](msdyn_quotebookingsetup.md#BKMK_owner_msdyn_quotebookingsetup)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_quotebookingsetup`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_quotebookingsetup`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_quoteinvoicingproduct"></a> owner_msdyn_quoteinvoicingproduct

Many-To-One Relationship: [msdyn_quoteinvoicingproduct owner_msdyn_quoteinvoicingproduct](msdyn_quoteinvoicingproduct.md#BKMK_owner_msdyn_quoteinvoicingproduct)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_quoteinvoicingproduct`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_quoteinvoicingproduct`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_quoteinvoicingsetup"></a> owner_msdyn_quoteinvoicingsetup

Many-To-One Relationship: [msdyn_quoteinvoicingsetup owner_msdyn_quoteinvoicingsetup](msdyn_quoteinvoicingsetup.md#BKMK_owner_msdyn_quoteinvoicingsetup)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_quoteinvoicingsetup`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_quoteinvoicingsetup`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_requirementchange"></a> owner_msdyn_requirementchange

Many-To-One Relationship: [msdyn_requirementchange owner_msdyn_requirementchange](msdyn_requirementchange.md#BKMK_owner_msdyn_requirementchange)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_requirementchange`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_requirementchange`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_requirementcharacteristic"></a> owner_msdyn_requirementcharacteristic

Many-To-One Relationship: [msdyn_requirementcharacteristic owner_msdyn_requirementcharacteristic](msdyn_requirementcharacteristic.md#BKMK_owner_msdyn_requirementcharacteristic)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_requirementcharacteristic`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_requirementcharacteristic`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_requirementdependency"></a> owner_msdyn_requirementdependency

Many-To-One Relationship: [msdyn_requirementdependency owner_msdyn_requirementdependency](msdyn_requirementdependency.md#BKMK_owner_msdyn_requirementdependency)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_requirementdependency`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_requirementdependency`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_requirementgroup"></a> owner_msdyn_requirementgroup

Many-To-One Relationship: [msdyn_requirementgroup owner_msdyn_requirementgroup](msdyn_requirementgroup.md#BKMK_owner_msdyn_requirementgroup)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_requirementgroup`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_requirementgroup`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_requirementorganizationunit"></a> owner_msdyn_requirementorganizationunit

Many-To-One Relationship: [msdyn_requirementorganizationunit owner_msdyn_requirementorganizationunit](msdyn_requirementorganizationunit.md#BKMK_owner_msdyn_requirementorganizationunit)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_requirementorganizationunit`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_requirementorganizationunit`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_requirementrelationship"></a> owner_msdyn_requirementrelationship

Many-To-One Relationship: [msdyn_requirementrelationship owner_msdyn_requirementrelationship](msdyn_requirementrelationship.md#BKMK_owner_msdyn_requirementrelationship)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_requirementrelationship`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_requirementrelationship`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_requirementresourcecategory"></a> owner_msdyn_requirementresourcecategory

Many-To-One Relationship: [msdyn_requirementresourcecategory owner_msdyn_requirementresourcecategory](msdyn_requirementresourcecategory.md#BKMK_owner_msdyn_requirementresourcecategory)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_requirementresourcecategory`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_requirementresourcecategory`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_requirementresourcepreference"></a> owner_msdyn_requirementresourcepreference

Many-To-One Relationship: [msdyn_requirementresourcepreference owner_msdyn_requirementresourcepreference](msdyn_requirementresourcepreference.md#BKMK_owner_msdyn_requirementresourcepreference)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_requirementresourcepreference`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_requirementresourcepreference`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_requirementstatus"></a> owner_msdyn_requirementstatus

Many-To-One Relationship: [msdyn_requirementstatus owner_msdyn_requirementstatus](msdyn_requirementstatus.md#BKMK_owner_msdyn_requirementstatus)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_requirementstatus`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_requirementstatus`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_resolution"></a> owner_msdyn_resolution

Many-To-One Relationship: [msdyn_resolution owner_msdyn_resolution](msdyn_resolution.md#BKMK_owner_msdyn_resolution)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_resolution`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_resolution`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_resourcepaytype"></a> owner_msdyn_resourcepaytype

Many-To-One Relationship: [msdyn_resourcepaytype owner_msdyn_resourcepaytype](msdyn_resourcepaytype.md#BKMK_owner_msdyn_resourcepaytype)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_resourcepaytype`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_resourcepaytype`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_resourcerequirement"></a> owner_msdyn_resourcerequirement

Many-To-One Relationship: [msdyn_resourcerequirement owner_msdyn_resourcerequirement](msdyn_resourcerequirement.md#BKMK_owner_msdyn_resourcerequirement)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_resourcerequirement`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_resourcerequirement`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_resourcerequirementdetail"></a> owner_msdyn_resourcerequirementdetail

Many-To-One Relationship: [msdyn_resourcerequirementdetail owner_msdyn_resourcerequirementdetail](msdyn_resourcerequirementdetail.md#BKMK_owner_msdyn_resourcerequirementdetail)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_resourcerequirementdetail`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_resourcerequirementdetail`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_resourceterritory"></a> owner_msdyn_resourceterritory

Many-To-One Relationship: [msdyn_resourceterritory owner_msdyn_resourceterritory](msdyn_resourceterritory.md#BKMK_owner_msdyn_resourceterritory)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_resourceterritory`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_resourceterritory`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_rma"></a> owner_msdyn_rma

Many-To-One Relationship: [msdyn_rma owner_msdyn_rma](msdyn_rma.md#BKMK_owner_msdyn_rma)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_rma`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_rma`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_rmaproduct"></a> owner_msdyn_rmaproduct

Many-To-One Relationship: [msdyn_rmaproduct owner_msdyn_rmaproduct](msdyn_rmaproduct.md#BKMK_owner_msdyn_rmaproduct)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_rmaproduct`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_rmaproduct`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_rmareceipt"></a> owner_msdyn_rmareceipt

Many-To-One Relationship: [msdyn_rmareceipt owner_msdyn_rmareceipt](msdyn_rmareceipt.md#BKMK_owner_msdyn_rmareceipt)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_rmareceipt`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_rmareceipt`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_rmareceiptproduct"></a> owner_msdyn_rmareceiptproduct

Many-To-One Relationship: [msdyn_rmareceiptproduct owner_msdyn_rmareceiptproduct](msdyn_rmareceiptproduct.md#BKMK_owner_msdyn_rmareceiptproduct)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_rmareceiptproduct`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_rmareceiptproduct`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_rmasubstatus"></a> owner_msdyn_rmasubstatus

Many-To-One Relationship: [msdyn_rmasubstatus owner_msdyn_rmasubstatus](msdyn_rmasubstatus.md#BKMK_owner_msdyn_rmasubstatus)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_rmasubstatus`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_rmasubstatus`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_rtv"></a> owner_msdyn_rtv

Many-To-One Relationship: [msdyn_rtv owner_msdyn_rtv](msdyn_rtv.md#BKMK_owner_msdyn_rtv)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_rtv`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_rtv`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_rtvproduct"></a> owner_msdyn_rtvproduct

Many-To-One Relationship: [msdyn_rtvproduct owner_msdyn_rtvproduct](msdyn_rtvproduct.md#BKMK_owner_msdyn_rtvproduct)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_rtvproduct`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_rtvproduct`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_rtvsubstatus"></a> owner_msdyn_rtvsubstatus

Many-To-One Relationship: [msdyn_rtvsubstatus owner_msdyn_rtvsubstatus](msdyn_rtvsubstatus.md#BKMK_owner_msdyn_rtvsubstatus)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_rtvsubstatus`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_rtvsubstatus`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_scheduleboardsetting"></a> owner_msdyn_scheduleboardsetting

Many-To-One Relationship: [msdyn_scheduleboardsetting owner_msdyn_scheduleboardsetting](msdyn_scheduleboardsetting.md#BKMK_owner_msdyn_scheduleboardsetting)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_scheduleboardsetting`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_scheduleboardsetting`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_schedulingfeatureflag"></a> owner_msdyn_schedulingfeatureflag

Many-To-One Relationship: [msdyn_schedulingfeatureflag owner_msdyn_schedulingfeatureflag](msdyn_schedulingfeatureflag.md#BKMK_owner_msdyn_schedulingfeatureflag)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_schedulingfeatureflag`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_schedulingfeatureflag`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_servicetasktype"></a> owner_msdyn_servicetasktype

Many-To-One Relationship: [msdyn_servicetasktype owner_msdyn_servicetasktype](msdyn_servicetasktype.md#BKMK_owner_msdyn_servicetasktype)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_servicetasktype`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_servicetasktype`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_sessiondata"></a> owner_msdyn_sessiondata

Many-To-One Relationship: [msdyn_sessiondata owner_msdyn_sessiondata](msdyn_sessiondata.md#BKMK_owner_msdyn_sessiondata)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_sessiondata`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_sessiondata`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_sessionparticipantdata"></a> owner_msdyn_sessionparticipantdata

Many-To-One Relationship: [msdyn_sessionparticipantdata owner_msdyn_sessionparticipantdata](msdyn_sessionparticipantdata.md#BKMK_owner_msdyn_sessionparticipantdata)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_sessionparticipantdata`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_sessionparticipantdata`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_shipvia"></a> owner_msdyn_shipvia

Many-To-One Relationship: [msdyn_shipvia owner_msdyn_shipvia](msdyn_shipvia.md#BKMK_owner_msdyn_shipvia)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_shipvia`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_shipvia`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_systemuserschedulersetting"></a> owner_msdyn_systemuserschedulersetting

Many-To-One Relationship: [msdyn_systemuserschedulersetting owner_msdyn_systemuserschedulersetting](msdyn_systemuserschedulersetting.md#BKMK_owner_msdyn_systemuserschedulersetting)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_systemuserschedulersetting`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_systemuserschedulersetting`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_taxcode"></a> owner_msdyn_taxcode

Many-To-One Relationship: [msdyn_taxcode owner_msdyn_taxcode](msdyn_taxcode.md#BKMK_owner_msdyn_taxcode)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_taxcode`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_taxcode`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_taxcodedetail"></a> owner_msdyn_taxcodedetail

Many-To-One Relationship: [msdyn_taxcodedetail owner_msdyn_taxcodedetail](msdyn_taxcodedetail.md#BKMK_owner_msdyn_taxcodedetail)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_taxcodedetail`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_taxcodedetail`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_templatetags"></a> owner_msdyn_templatetags

Many-To-One Relationship: [msdyn_templatetags owner_msdyn_templatetags](msdyn_templatetags.md#BKMK_owner_msdyn_templatetags)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_templatetags`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_templatetags`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_timeentry"></a> owner_msdyn_timeentry

Many-To-One Relationship: [msdyn_timeentry owner_msdyn_timeentry](msdyn_timeentry.md#BKMK_owner_msdyn_timeentry)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_timeentry`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_timeentry`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_timeentrysetting"></a> owner_msdyn_timeentrysetting

Many-To-One Relationship: [msdyn_timeentrysetting owner_msdyn_timeentrysetting](msdyn_timeentrysetting.md#BKMK_owner_msdyn_timeentrysetting)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_timeentrysetting`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_timeentrysetting`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_timegroup"></a> owner_msdyn_timegroup

Many-To-One Relationship: [msdyn_timegroup owner_msdyn_timegroup](msdyn_timegroup.md#BKMK_owner_msdyn_timegroup)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_timegroup`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_timegroup`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_timegroupdetail"></a> owner_msdyn_timegroupdetail

Many-To-One Relationship: [msdyn_timegroupdetail owner_msdyn_timegroupdetail](msdyn_timegroupdetail.md#BKMK_owner_msdyn_timegroupdetail)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_timegroupdetail`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_timegroupdetail`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_timeoffrequest"></a> owner_msdyn_timeoffrequest

Many-To-One Relationship: [msdyn_timeoffrequest owner_msdyn_timeoffrequest](msdyn_timeoffrequest.md#BKMK_owner_msdyn_timeoffrequest)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_timeoffrequest`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_timeoffrequest`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_trade"></a> owner_msdyn_trade

Many-To-One Relationship: [msdyn_trade owner_msdyn_trade](msdyn_trade.md#BKMK_owner_msdyn_trade)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_trade`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_trade`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_tradecoverage"></a> owner_msdyn_tradecoverage

Many-To-One Relationship: [msdyn_tradecoverage owner_msdyn_tradecoverage](msdyn_tradecoverage.md#BKMK_owner_msdyn_tradecoverage)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_tradecoverage`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_tradecoverage`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_transactionorigin"></a> owner_msdyn_transactionorigin

Many-To-One Relationship: [msdyn_transactionorigin owner_msdyn_transactionorigin](msdyn_transactionorigin.md#BKMK_owner_msdyn_transactionorigin)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_transactionorigin`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_transactionorigin`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_warehouse"></a> owner_msdyn_warehouse

Many-To-One Relationship: [msdyn_warehouse owner_msdyn_warehouse](msdyn_warehouse.md#BKMK_owner_msdyn_warehouse)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_warehouse`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_warehouse`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_workhourtemplate"></a> owner_msdyn_workhourtemplate

Many-To-One Relationship: [msdyn_workhourtemplate owner_msdyn_workhourtemplate](msdyn_workhourtemplate.md#BKMK_owner_msdyn_workhourtemplate)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_workhourtemplate`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_workhourtemplate`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_workorder"></a> owner_msdyn_workorder

Many-To-One Relationship: [msdyn_workorder owner_msdyn_workorder](msdyn_workorder.md#BKMK_owner_msdyn_workorder)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_workorder`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_workorder`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_workordercharacteristic"></a> owner_msdyn_workordercharacteristic

Many-To-One Relationship: [msdyn_workordercharacteristic owner_msdyn_workordercharacteristic](msdyn_workordercharacteristic.md#BKMK_owner_msdyn_workordercharacteristic)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_workordercharacteristic`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_workordercharacteristic`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_workorderincident"></a> owner_msdyn_workorderincident

Many-To-One Relationship: [msdyn_workorderincident owner_msdyn_workorderincident](msdyn_workorderincident.md#BKMK_owner_msdyn_workorderincident)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_workorderincident`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_workorderincident`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_workordernte"></a> owner_msdyn_workordernte

Many-To-One Relationship: [msdyn_workordernte owner_msdyn_workordernte](msdyn_workordernte.md#BKMK_owner_msdyn_workordernte)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_workordernte`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_workordernte`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_workorderproduct"></a> owner_msdyn_workorderproduct

Many-To-One Relationship: [msdyn_workorderproduct owner_msdyn_workorderproduct](msdyn_workorderproduct.md#BKMK_owner_msdyn_workorderproduct)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_workorderproduct`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_workorderproduct`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_workorderresolution"></a> owner_msdyn_workorderresolution

Many-To-One Relationship: [msdyn_workorderresolution owner_msdyn_workorderresolution](msdyn_workorderresolution.md#BKMK_owner_msdyn_workorderresolution)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_workorderresolution`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_workorderresolution`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_workorderresourcerestriction"></a> owner_msdyn_workorderresourcerestriction

Many-To-One Relationship: [msdyn_workorderresourcerestriction owner_msdyn_workorderresourcerestriction](msdyn_workorderresourcerestriction.md#BKMK_owner_msdyn_workorderresourcerestriction)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_workorderresourcerestriction`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_workorderresourcerestriction`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_workorderservice"></a> owner_msdyn_workorderservice

Many-To-One Relationship: [msdyn_workorderservice owner_msdyn_workorderservice](msdyn_workorderservice.md#BKMK_owner_msdyn_workorderservice)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_workorderservice`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_workorderservice`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_workorderservicetask"></a> owner_msdyn_workorderservicetask

Many-To-One Relationship: [msdyn_workorderservicetask owner_msdyn_workorderservicetask](msdyn_workorderservicetask.md#BKMK_owner_msdyn_workorderservicetask)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_workorderservicetask`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_workorderservicetask`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_workordersubstatus"></a> owner_msdyn_workordersubstatus

Many-To-One Relationship: [msdyn_workordersubstatus owner_msdyn_workordersubstatus](msdyn_workordersubstatus.md#BKMK_owner_msdyn_workordersubstatus)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_workordersubstatus`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_workordersubstatus`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_workordertype"></a> owner_msdyn_workordertype

Many-To-One Relationship: [msdyn_workordertype owner_msdyn_workordertype](msdyn_workordertype.md#BKMK_owner_msdyn_workordertype)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_workordertype`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_workordertype`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|



### See also

[Dataverse table/entity reference](../about-entity-reference.md)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   

