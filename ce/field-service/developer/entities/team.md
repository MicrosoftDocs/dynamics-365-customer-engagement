---
title: "Team table/entity reference (Microsoft Dynamics 365 Field Service)"
description: "Includes schema information and supported messages for the Team table/entity with Microsoft Dynamics 365 Field Service."
ms.date: 08/26/2024
ms.service: powerapps
ms.topic: reference
author: m-hartmann
ms.author: mhart
search.audienceType: 
  - developer
---

# Team table/entity reference (Microsoft Dynamics 365 Field Service)

Collection of system users that routinely collaborate. Teams can be used to simplify record sharing and provide team members with common access to organization data when team members belong to different Business Units.

> [!NOTE]
> The Microsoft Dynamics 365 Field Service Team table extends the [Microsoft Dynamics 365 Team table](/dynamics365/developer/entities/team).




## One-to-Many relationships

These relationships are one-to-many. Listed by **SchemaName**.

- [msdyn_bookingalert_team_owningteam](#BKMK_msdyn_bookingalert_team_owningteam)
- [team_msdyn_actual](#BKMK_team_msdyn_actual)
- [team_msdyn_agreement](#BKMK_team_msdyn_agreement)
- [team_msdyn_agreementbookingdate](#BKMK_team_msdyn_agreementbookingdate)
- [team_msdyn_agreementbookingincident](#BKMK_team_msdyn_agreementbookingincident)
- [team_msdyn_agreementbookingproduct](#BKMK_team_msdyn_agreementbookingproduct)
- [team_msdyn_agreementbookingservice](#BKMK_team_msdyn_agreementbookingservice)
- [team_msdyn_agreementbookingservicetask](#BKMK_team_msdyn_agreementbookingservicetask)
- [team_msdyn_agreementbookingsetup](#BKMK_team_msdyn_agreementbookingsetup)
- [team_msdyn_agreementinvoicedate](#BKMK_team_msdyn_agreementinvoicedate)
- [team_msdyn_agreementinvoiceproduct](#BKMK_team_msdyn_agreementinvoiceproduct)
- [team_msdyn_agreementinvoicesetup](#BKMK_team_msdyn_agreementinvoicesetup)
- [team_msdyn_agreementsubstatus](#BKMK_team_msdyn_agreementsubstatus)
- [team_msdyn_bookableresourceassociation](#BKMK_team_msdyn_bookableresourceassociation)
- [team_msdyn_bookableresourcebookingquicknote](#BKMK_team_msdyn_bookableresourcebookingquicknote)
- [team_msdyn_bookingalertstatus](#BKMK_team_msdyn_bookingalertstatus)
- [team_msdyn_bookingchange](#BKMK_team_msdyn_bookingchange)
- [team_msdyn_bookingjournal](#BKMK_team_msdyn_bookingjournal)
- [team_msdyn_bookingrule](#BKMK_team_msdyn_bookingrule)
- [team_msdyn_bookingsetupmetadata](#BKMK_team_msdyn_bookingsetupmetadata)
- [team_msdyn_bookingtimestamp](#BKMK_team_msdyn_bookingtimestamp)
- [team_msdyn_businessclosure](#BKMK_team_msdyn_businessclosure)
- [team_msdyn_clientextension](#BKMK_team_msdyn_clientextension)
- [team_msdyn_configuration](#BKMK_team_msdyn_configuration)
- [team_msdyn_consoleapplicationsessiontemplate](#BKMK_team_msdyn_consoleapplicationsessiontemplate)
- [team_msdyn_entitlementapplication](#BKMK_team_msdyn_entitlementapplication)
- [team_msdyn_entityconfiguration](#BKMK_team_msdyn_entityconfiguration)
- [team_msdyn_fieldservicesetting](#BKMK_team_msdyn_fieldservicesetting)
- [team_msdyn_fieldserviceslaconfiguration](#BKMK_team_msdyn_fieldserviceslaconfiguration)
- [team_msdyn_fieldservicesummaryconfiguration](#BKMK_team_msdyn_fieldservicesummaryconfiguration)
- [team_msdyn_geofence](#BKMK_team_msdyn_geofence)
- [team_msdyn_geofenceevent](#BKMK_team_msdyn_geofenceevent)
- [team_msdyn_geofencingsettings](#BKMK_team_msdyn_geofencingsettings)
- [team_msdyn_incidenttype](#BKMK_team_msdyn_incidenttype)
- [team_msdyn_incidenttype_requirementgroup](#BKMK_team_msdyn_incidenttype_requirementgroup)
- [team_msdyn_incidenttypecharacteristic](#BKMK_team_msdyn_incidenttypecharacteristic)
- [team_msdyn_incidenttypeproduct](#BKMK_team_msdyn_incidenttypeproduct)
- [team_msdyn_incidenttyperecommendationresult](#BKMK_team_msdyn_incidenttyperecommendationresult)
- [team_msdyn_incidenttyperecommendationrunhistory](#BKMK_team_msdyn_incidenttyperecommendationrunhistory)
- [team_msdyn_incidenttyperesolution](#BKMK_team_msdyn_incidenttyperesolution)
- [team_msdyn_incidenttypeservice](#BKMK_team_msdyn_incidenttypeservice)
- [team_msdyn_incidenttypeservicetask](#BKMK_team_msdyn_incidenttypeservicetask)
- [team_msdyn_incidenttypessetup](#BKMK_team_msdyn_incidenttypessetup)
- [team_msdyn_inspection](#BKMK_team_msdyn_inspection)
- [team_msdyn_inspectionattachment](#BKMK_team_msdyn_inspectionattachment)
- [team_msdyn_inspectiondefinition](#BKMK_team_msdyn_inspectiondefinition)
- [team_msdyn_inspectioninstance](#BKMK_team_msdyn_inspectioninstance)
- [team_msdyn_inspectionresponse](#BKMK_team_msdyn_inspectionresponse)
- [team_msdyn_insurance](#BKMK_team_msdyn_insurance)
- [team_msdyn_inventoryadjustment](#BKMK_team_msdyn_inventoryadjustment)
- [team_msdyn_inventoryadjustmentproduct](#BKMK_team_msdyn_inventoryadjustmentproduct)
- [team_msdyn_inventoryjournal](#BKMK_team_msdyn_inventoryjournal)
- [team_msdyn_inventorytransfer](#BKMK_team_msdyn_inventorytransfer)
- [team_msdyn_mobilesource](#BKMK_team_msdyn_mobilesource)
- [team_msdyn_nottoexceed](#BKMK_team_msdyn_nottoexceed)
- [team_msdyn_optimizationrequest](#BKMK_team_msdyn_optimizationrequest)
- [team_msdyn_orderinvoicingdate](#BKMK_team_msdyn_orderinvoicingdate)
- [team_msdyn_orderinvoicingproduct](#BKMK_team_msdyn_orderinvoicingproduct)
- [team_msdyn_orderinvoicingsetup](#BKMK_team_msdyn_orderinvoicingsetup)
- [team_msdyn_orderinvoicingsetupdate](#BKMK_team_msdyn_orderinvoicingsetupdate)
- [team_msdyn_payment](#BKMK_team_msdyn_payment)
- [team_msdyn_paymentdetail](#BKMK_team_msdyn_paymentdetail)
- [team_msdyn_paymentmethod](#BKMK_team_msdyn_paymentmethod)
- [team_msdyn_paymentterm](#BKMK_team_msdyn_paymentterm)
- [team_msdyn_postalcode](#BKMK_team_msdyn_postalcode)
- [team_msdyn_priority](#BKMK_team_msdyn_priority)
- [team_msdyn_problematicasset](#BKMK_team_msdyn_problematicasset)
- [team_msdyn_problematicassetfeedback](#BKMK_team_msdyn_problematicassetfeedback)
- [team_msdyn_purchaseorder](#BKMK_team_msdyn_purchaseorder)
- [team_msdyn_purchaseorderbill](#BKMK_team_msdyn_purchaseorderbill)
- [team_msdyn_purchaseorderproduct](#BKMK_team_msdyn_purchaseorderproduct)
- [team_msdyn_purchaseorderreceipt](#BKMK_team_msdyn_purchaseorderreceipt)
- [team_msdyn_purchaseorderreceiptproduct](#BKMK_team_msdyn_purchaseorderreceiptproduct)
- [team_msdyn_purchaseordersubstatus](#BKMK_team_msdyn_purchaseordersubstatus)
- [team_msdyn_quotebookingincident](#BKMK_team_msdyn_quotebookingincident)
- [team_msdyn_quotebookingproduct](#BKMK_team_msdyn_quotebookingproduct)
- [team_msdyn_quotebookingservice](#BKMK_team_msdyn_quotebookingservice)
- [team_msdyn_quotebookingservicetask](#BKMK_team_msdyn_quotebookingservicetask)
- [team_msdyn_quotebookingsetup](#BKMK_team_msdyn_quotebookingsetup)
- [team_msdyn_quoteinvoicingproduct](#BKMK_team_msdyn_quoteinvoicingproduct)
- [team_msdyn_quoteinvoicingsetup](#BKMK_team_msdyn_quoteinvoicingsetup)
- [team_msdyn_requirementchange](#BKMK_team_msdyn_requirementchange)
- [team_msdyn_requirementcharacteristic](#BKMK_team_msdyn_requirementcharacteristic)
- [team_msdyn_requirementdependency](#BKMK_team_msdyn_requirementdependency)
- [team_msdyn_requirementgroup](#BKMK_team_msdyn_requirementgroup)
- [team_msdyn_requirementorganizationunit](#BKMK_team_msdyn_requirementorganizationunit)
- [team_msdyn_requirementrelationship](#BKMK_team_msdyn_requirementrelationship)
- [team_msdyn_requirementresourcecategory](#BKMK_team_msdyn_requirementresourcecategory)
- [team_msdyn_requirementresourcepreference](#BKMK_team_msdyn_requirementresourcepreference)
- [team_msdyn_requirementstatus](#BKMK_team_msdyn_requirementstatus)
- [team_msdyn_resolution](#BKMK_team_msdyn_resolution)
- [team_msdyn_resourcepaytype](#BKMK_team_msdyn_resourcepaytype)
- [team_msdyn_resourcerequirement](#BKMK_team_msdyn_resourcerequirement)
- [team_msdyn_resourcerequirementdetail](#BKMK_team_msdyn_resourcerequirementdetail)
- [team_msdyn_resourceterritory](#BKMK_team_msdyn_resourceterritory)
- [team_msdyn_rma](#BKMK_team_msdyn_rma)
- [team_msdyn_rmaproduct](#BKMK_team_msdyn_rmaproduct)
- [team_msdyn_rmareceipt](#BKMK_team_msdyn_rmareceipt)
- [team_msdyn_rmareceiptproduct](#BKMK_team_msdyn_rmareceiptproduct)
- [team_msdyn_rmasubstatus](#BKMK_team_msdyn_rmasubstatus)
- [team_msdyn_rtv](#BKMK_team_msdyn_rtv)
- [team_msdyn_rtvproduct](#BKMK_team_msdyn_rtvproduct)
- [team_msdyn_rtvsubstatus](#BKMK_team_msdyn_rtvsubstatus)
- [team_msdyn_scheduleboardsetting](#BKMK_team_msdyn_scheduleboardsetting)
- [team_msdyn_schedulingfeatureflag](#BKMK_team_msdyn_schedulingfeatureflag)
- [team_msdyn_servicetasktype](#BKMK_team_msdyn_servicetasktype)
- [team_msdyn_sessiondata](#BKMK_team_msdyn_sessiondata)
- [team_msdyn_sessionparticipantdata](#BKMK_team_msdyn_sessionparticipantdata)
- [team_msdyn_shipvia](#BKMK_team_msdyn_shipvia)
- [team_msdyn_systemuserschedulersetting](#BKMK_team_msdyn_systemuserschedulersetting)
- [team_msdyn_taxcode](#BKMK_team_msdyn_taxcode)
- [team_msdyn_taxcodedetail](#BKMK_team_msdyn_taxcodedetail)
- [team_msdyn_timeentry](#BKMK_team_msdyn_timeentry)
- [team_msdyn_timeentrysetting](#BKMK_team_msdyn_timeentrysetting)
- [team_msdyn_timegroup](#BKMK_team_msdyn_timegroup)
- [team_msdyn_timegroupdetail](#BKMK_team_msdyn_timegroupdetail)
- [team_msdyn_timeoffrequest](#BKMK_team_msdyn_timeoffrequest)
- [team_msdyn_trade](#BKMK_team_msdyn_trade)
- [team_msdyn_tradecoverage](#BKMK_team_msdyn_tradecoverage)
- [team_msdyn_transactionorigin](#BKMK_team_msdyn_transactionorigin)
- [team_msdyn_warehouse](#BKMK_team_msdyn_warehouse)
- [team_msdyn_workhourtemplate](#BKMK_team_msdyn_workhourtemplate)
- [team_msdyn_workorder](#BKMK_team_msdyn_workorder)
- [team_msdyn_workorderincident](#BKMK_team_msdyn_workorderincident)
- [team_msdyn_workordernte](#BKMK_team_msdyn_workordernte)
- [team_msdyn_workorderproduct](#BKMK_team_msdyn_workorderproduct)
- [team_msdyn_workorderresolution](#BKMK_team_msdyn_workorderresolution)
- [team_msdyn_workorderresourcerestriction](#BKMK_team_msdyn_workorderresourcerestriction)
- [team_msdyn_workorderservice](#BKMK_team_msdyn_workorderservice)
- [team_msdyn_workorderservicetask](#BKMK_team_msdyn_workorderservicetask)
- [team_msdyn_workordersubstatus](#BKMK_team_msdyn_workordersubstatus)
- [team_msdyn_workordertype](#BKMK_team_msdyn_workordertype)

### <a name="BKMK_msdyn_bookingalert_team_owningteam"></a> msdyn_bookingalert_team_owningteam

Many-To-One Relationship: [msdyn_bookingalert msdyn_bookingalert_team_owningteam](msdyn_bookingalert.md#BKMK_msdyn_bookingalert_team_owningteam)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_bookingalert`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`msdyn_bookingalert_team_owningteam`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_actual"></a> team_msdyn_actual

Many-To-One Relationship: [msdyn_actual team_msdyn_actual](msdyn_actual.md#BKMK_team_msdyn_actual)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_actual`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_actual`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_agreement"></a> team_msdyn_agreement

Many-To-One Relationship: [msdyn_agreement team_msdyn_agreement](msdyn_agreement.md#BKMK_team_msdyn_agreement)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_agreement`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_agreement`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_agreementbookingdate"></a> team_msdyn_agreementbookingdate

Many-To-One Relationship: [msdyn_agreementbookingdate team_msdyn_agreementbookingdate](msdyn_agreementbookingdate.md#BKMK_team_msdyn_agreementbookingdate)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_agreementbookingdate`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_agreementbookingdate`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_agreementbookingincident"></a> team_msdyn_agreementbookingincident

Many-To-One Relationship: [msdyn_agreementbookingincident team_msdyn_agreementbookingincident](msdyn_agreementbookingincident.md#BKMK_team_msdyn_agreementbookingincident)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_agreementbookingincident`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_agreementbookingincident`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_agreementbookingproduct"></a> team_msdyn_agreementbookingproduct

Many-To-One Relationship: [msdyn_agreementbookingproduct team_msdyn_agreementbookingproduct](msdyn_agreementbookingproduct.md#BKMK_team_msdyn_agreementbookingproduct)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_agreementbookingproduct`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_agreementbookingproduct`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_agreementbookingservice"></a> team_msdyn_agreementbookingservice

Many-To-One Relationship: [msdyn_agreementbookingservice team_msdyn_agreementbookingservice](msdyn_agreementbookingservice.md#BKMK_team_msdyn_agreementbookingservice)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_agreementbookingservice`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_agreementbookingservice`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_agreementbookingservicetask"></a> team_msdyn_agreementbookingservicetask

Many-To-One Relationship: [msdyn_agreementbookingservicetask team_msdyn_agreementbookingservicetask](msdyn_agreementbookingservicetask.md#BKMK_team_msdyn_agreementbookingservicetask)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_agreementbookingservicetask`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_agreementbookingservicetask`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_agreementbookingsetup"></a> team_msdyn_agreementbookingsetup

Many-To-One Relationship: [msdyn_agreementbookingsetup team_msdyn_agreementbookingsetup](msdyn_agreementbookingsetup.md#BKMK_team_msdyn_agreementbookingsetup)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_agreementbookingsetup`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_agreementbookingsetup`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_agreementinvoicedate"></a> team_msdyn_agreementinvoicedate

Many-To-One Relationship: [msdyn_agreementinvoicedate team_msdyn_agreementinvoicedate](msdyn_agreementinvoicedate.md#BKMK_team_msdyn_agreementinvoicedate)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_agreementinvoicedate`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_agreementinvoicedate`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_agreementinvoiceproduct"></a> team_msdyn_agreementinvoiceproduct

Many-To-One Relationship: [msdyn_agreementinvoiceproduct team_msdyn_agreementinvoiceproduct](msdyn_agreementinvoiceproduct.md#BKMK_team_msdyn_agreementinvoiceproduct)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_agreementinvoiceproduct`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_agreementinvoiceproduct`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_agreementinvoicesetup"></a> team_msdyn_agreementinvoicesetup

Many-To-One Relationship: [msdyn_agreementinvoicesetup team_msdyn_agreementinvoicesetup](msdyn_agreementinvoicesetup.md#BKMK_team_msdyn_agreementinvoicesetup)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_agreementinvoicesetup`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_agreementinvoicesetup`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_agreementsubstatus"></a> team_msdyn_agreementsubstatus

Many-To-One Relationship: [msdyn_agreementsubstatus team_msdyn_agreementsubstatus](msdyn_agreementsubstatus.md#BKMK_team_msdyn_agreementsubstatus)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_agreementsubstatus`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_agreementsubstatus`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_bookableresourceassociation"></a> team_msdyn_bookableresourceassociation

Many-To-One Relationship: [msdyn_bookableresourceassociation team_msdyn_bookableresourceassociation](msdyn_bookableresourceassociation.md#BKMK_team_msdyn_bookableresourceassociation)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_bookableresourceassociation`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_bookableresourceassociation`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_bookableresourcebookingquicknote"></a> team_msdyn_bookableresourcebookingquicknote

Many-To-One Relationship: [msdyn_bookableresourcebookingquicknote team_msdyn_bookableresourcebookingquicknote](msdyn_bookableresourcebookingquicknote.md#BKMK_team_msdyn_bookableresourcebookingquicknote)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_bookableresourcebookingquicknote`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_bookableresourcebookingquicknote`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_bookingalertstatus"></a> team_msdyn_bookingalertstatus

Many-To-One Relationship: [msdyn_bookingalertstatus team_msdyn_bookingalertstatus](msdyn_bookingalertstatus.md#BKMK_team_msdyn_bookingalertstatus)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_bookingalertstatus`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_bookingalertstatus`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_bookingchange"></a> team_msdyn_bookingchange

Many-To-One Relationship: [msdyn_bookingchange team_msdyn_bookingchange](msdyn_bookingchange.md#BKMK_team_msdyn_bookingchange)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_bookingchange`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_bookingchange`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_bookingjournal"></a> team_msdyn_bookingjournal

Many-To-One Relationship: [msdyn_bookingjournal team_msdyn_bookingjournal](msdyn_bookingjournal.md#BKMK_team_msdyn_bookingjournal)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_bookingjournal`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_bookingjournal`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_bookingrule"></a> team_msdyn_bookingrule

Many-To-One Relationship: [msdyn_bookingrule team_msdyn_bookingrule](msdyn_bookingrule.md#BKMK_team_msdyn_bookingrule)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_bookingrule`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_bookingrule`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_bookingsetupmetadata"></a> team_msdyn_bookingsetupmetadata

Many-To-One Relationship: [msdyn_bookingsetupmetadata team_msdyn_bookingsetupmetadata](msdyn_bookingsetupmetadata.md#BKMK_team_msdyn_bookingsetupmetadata)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_bookingsetupmetadata`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_bookingsetupmetadata`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_bookingtimestamp"></a> team_msdyn_bookingtimestamp

Many-To-One Relationship: [msdyn_bookingtimestamp team_msdyn_bookingtimestamp](msdyn_bookingtimestamp.md#BKMK_team_msdyn_bookingtimestamp)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_bookingtimestamp`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_bookingtimestamp`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_businessclosure"></a> team_msdyn_businessclosure

Many-To-One Relationship: [msdyn_businessclosure team_msdyn_businessclosure](msdyn_businessclosure.md#BKMK_team_msdyn_businessclosure)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_businessclosure`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_businessclosure`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_clientextension"></a> team_msdyn_clientextension

Many-To-One Relationship: [msdyn_clientextension team_msdyn_clientextension](msdyn_clientextension.md#BKMK_team_msdyn_clientextension)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_clientextension`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_clientextension`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_configuration"></a> team_msdyn_configuration

Many-To-One Relationship: [msdyn_configuration team_msdyn_configuration](msdyn_configuration.md#BKMK_team_msdyn_configuration)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_configuration`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_configuration`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_consoleapplicationsessiontemplate"></a> team_msdyn_consoleapplicationsessiontemplate

Many-To-One Relationship: [msdyn_consoleapplicationsessiontemplate team_msdyn_consoleapplicationsessiontemplate](msdyn_consoleapplicationsessiontemplate.md#BKMK_team_msdyn_consoleapplicationsessiontemplate)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_consoleapplicationsessiontemplate`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_consoleapplicationsessiontemplate`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_entitlementapplication"></a> team_msdyn_entitlementapplication

Many-To-One Relationship: [msdyn_entitlementapplication team_msdyn_entitlementapplication](msdyn_entitlementapplication.md#BKMK_team_msdyn_entitlementapplication)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_entitlementapplication`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_entitlementapplication`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_entityconfiguration"></a> team_msdyn_entityconfiguration

Many-To-One Relationship: [msdyn_entityconfiguration team_msdyn_entityconfiguration](msdyn_entityconfiguration.md#BKMK_team_msdyn_entityconfiguration)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_entityconfiguration`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_entityconfiguration`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_fieldservicesetting"></a> team_msdyn_fieldservicesetting

Many-To-One Relationship: [msdyn_fieldservicesetting team_msdyn_fieldservicesetting](msdyn_fieldservicesetting.md#BKMK_team_msdyn_fieldservicesetting)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_fieldservicesetting`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_fieldservicesetting`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_fieldserviceslaconfiguration"></a> team_msdyn_fieldserviceslaconfiguration

Many-To-One Relationship: [msdyn_fieldserviceslaconfiguration team_msdyn_fieldserviceslaconfiguration](msdyn_fieldserviceslaconfiguration.md#BKMK_team_msdyn_fieldserviceslaconfiguration)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_fieldserviceslaconfiguration`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_fieldserviceslaconfiguration`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_fieldservicesummaryconfiguration"></a> team_msdyn_fieldservicesummaryconfiguration

Many-To-One Relationship: [msdyn_fieldservicesummaryconfiguration team_msdyn_fieldservicesummaryconfiguration](msdyn_fieldservicesummaryconfiguration.md#BKMK_team_msdyn_fieldservicesummaryconfiguration)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_fieldservicesummaryconfiguration`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_fieldservicesummaryconfiguration`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_geofence"></a> team_msdyn_geofence

Many-To-One Relationship: [msdyn_geofence team_msdyn_geofence](msdyn_geofence.md#BKMK_team_msdyn_geofence)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_geofence`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_geofence`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_geofenceevent"></a> team_msdyn_geofenceevent

Many-To-One Relationship: [msdyn_geofenceevent team_msdyn_geofenceevent](msdyn_geofenceevent.md#BKMK_team_msdyn_geofenceevent)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_geofenceevent`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_geofenceevent`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_geofencingsettings"></a> team_msdyn_geofencingsettings

Many-To-One Relationship: [msdyn_geofencingsettings team_msdyn_geofencingsettings](msdyn_geofencingsettings.md#BKMK_team_msdyn_geofencingsettings)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_geofencingsettings`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_geofencingsettings`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_incidenttype"></a> team_msdyn_incidenttype

Many-To-One Relationship: [msdyn_incidenttype team_msdyn_incidenttype](msdyn_incidenttype.md#BKMK_team_msdyn_incidenttype)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_incidenttype`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_incidenttype`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_incidenttype_requirementgroup"></a> team_msdyn_incidenttype_requirementgroup

Many-To-One Relationship: [msdyn_incidenttype_requirementgroup team_msdyn_incidenttype_requirementgroup](msdyn_incidenttype_requirementgroup.md#BKMK_team_msdyn_incidenttype_requirementgroup)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_incidenttype_requirementgroup`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_incidenttype_requirementgroup`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_incidenttypecharacteristic"></a> team_msdyn_incidenttypecharacteristic

Many-To-One Relationship: [msdyn_incidenttypecharacteristic team_msdyn_incidenttypecharacteristic](msdyn_incidenttypecharacteristic.md#BKMK_team_msdyn_incidenttypecharacteristic)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_incidenttypecharacteristic`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_incidenttypecharacteristic`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_incidenttypeproduct"></a> team_msdyn_incidenttypeproduct

Many-To-One Relationship: [msdyn_incidenttypeproduct team_msdyn_incidenttypeproduct](msdyn_incidenttypeproduct.md#BKMK_team_msdyn_incidenttypeproduct)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_incidenttypeproduct`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_incidenttypeproduct`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_incidenttyperecommendationresult"></a> team_msdyn_incidenttyperecommendationresult

Many-To-One Relationship: [msdyn_incidenttyperecommendationresult team_msdyn_incidenttyperecommendationresult](msdyn_incidenttyperecommendationresult.md#BKMK_team_msdyn_incidenttyperecommendationresult)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_incidenttyperecommendationresult`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_incidenttyperecommendationresult`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_incidenttyperecommendationrunhistory"></a> team_msdyn_incidenttyperecommendationrunhistory

Many-To-One Relationship: [msdyn_incidenttyperecommendationrunhistory team_msdyn_incidenttyperecommendationrunhistory](msdyn_incidenttyperecommendationrunhistory.md#BKMK_team_msdyn_incidenttyperecommendationrunhistory)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_incidenttyperecommendationrunhistory`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_incidenttyperecommendationrunhistory`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_incidenttyperesolution"></a> team_msdyn_incidenttyperesolution

Many-To-One Relationship: [msdyn_incidenttyperesolution team_msdyn_incidenttyperesolution](msdyn_incidenttyperesolution.md#BKMK_team_msdyn_incidenttyperesolution)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_incidenttyperesolution`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_incidenttyperesolution`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_incidenttypeservice"></a> team_msdyn_incidenttypeservice

Many-To-One Relationship: [msdyn_incidenttypeservice team_msdyn_incidenttypeservice](msdyn_incidenttypeservice.md#BKMK_team_msdyn_incidenttypeservice)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_incidenttypeservice`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_incidenttypeservice`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_incidenttypeservicetask"></a> team_msdyn_incidenttypeservicetask

Many-To-One Relationship: [msdyn_incidenttypeservicetask team_msdyn_incidenttypeservicetask](msdyn_incidenttypeservicetask.md#BKMK_team_msdyn_incidenttypeservicetask)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_incidenttypeservicetask`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_incidenttypeservicetask`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_incidenttypessetup"></a> team_msdyn_incidenttypessetup

Many-To-One Relationship: [msdyn_incidenttypessetup team_msdyn_incidenttypessetup](msdyn_incidenttypessetup.md#BKMK_team_msdyn_incidenttypessetup)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_incidenttypessetup`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_incidenttypessetup`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_inspection"></a> team_msdyn_inspection

Many-To-One Relationship: [msdyn_inspection team_msdyn_inspection](msdyn_inspection.md#BKMK_team_msdyn_inspection)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_inspection`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_inspection`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_inspectionattachment"></a> team_msdyn_inspectionattachment

Many-To-One Relationship: [msdyn_inspectionattachment team_msdyn_inspectionattachment](msdyn_inspectionattachment.md#BKMK_team_msdyn_inspectionattachment)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_inspectionattachment`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_inspectionattachment`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_inspectiondefinition"></a> team_msdyn_inspectiondefinition

Many-To-One Relationship: [msdyn_inspectiondefinition team_msdyn_inspectiondefinition](msdyn_inspectiondefinition.md#BKMK_team_msdyn_inspectiondefinition)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_inspectiondefinition`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_inspectiondefinition`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_inspectioninstance"></a> team_msdyn_inspectioninstance

Many-To-One Relationship: [msdyn_inspectioninstance team_msdyn_inspectioninstance](msdyn_inspectioninstance.md#BKMK_team_msdyn_inspectioninstance)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_inspectioninstance`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_inspectioninstance`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_inspectionresponse"></a> team_msdyn_inspectionresponse

Many-To-One Relationship: [msdyn_inspectionresponse team_msdyn_inspectionresponse](msdyn_inspectionresponse.md#BKMK_team_msdyn_inspectionresponse)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_inspectionresponse`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_inspectionresponse`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_insurance"></a> team_msdyn_insurance

Many-To-One Relationship: [msdyn_insurance team_msdyn_insurance](msdyn_insurance.md#BKMK_team_msdyn_insurance)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_insurance`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_insurance`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_inventoryadjustment"></a> team_msdyn_inventoryadjustment

Many-To-One Relationship: [msdyn_inventoryadjustment team_msdyn_inventoryadjustment](msdyn_inventoryadjustment.md#BKMK_team_msdyn_inventoryadjustment)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_inventoryadjustment`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_inventoryadjustment`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_inventoryadjustmentproduct"></a> team_msdyn_inventoryadjustmentproduct

Many-To-One Relationship: [msdyn_inventoryadjustmentproduct team_msdyn_inventoryadjustmentproduct](msdyn_inventoryadjustmentproduct.md#BKMK_team_msdyn_inventoryadjustmentproduct)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_inventoryadjustmentproduct`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_inventoryadjustmentproduct`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_inventoryjournal"></a> team_msdyn_inventoryjournal

Many-To-One Relationship: [msdyn_inventoryjournal team_msdyn_inventoryjournal](msdyn_inventoryjournal.md#BKMK_team_msdyn_inventoryjournal)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_inventoryjournal`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_inventoryjournal`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_inventorytransfer"></a> team_msdyn_inventorytransfer

Many-To-One Relationship: [msdyn_inventorytransfer team_msdyn_inventorytransfer](msdyn_inventorytransfer.md#BKMK_team_msdyn_inventorytransfer)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_inventorytransfer`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_inventorytransfer`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_mobilesource"></a> team_msdyn_mobilesource

Many-To-One Relationship: [msdyn_mobilesource team_msdyn_mobilesource](msdyn_mobilesource.md#BKMK_team_msdyn_mobilesource)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_mobilesource`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_mobilesource`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_nottoexceed"></a> team_msdyn_nottoexceed

Many-To-One Relationship: [msdyn_nottoexceed team_msdyn_nottoexceed](msdyn_nottoexceed.md#BKMK_team_msdyn_nottoexceed)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_nottoexceed`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_nottoexceed`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_optimizationrequest"></a> team_msdyn_optimizationrequest

Many-To-One Relationship: [msdyn_optimizationrequest team_msdyn_optimizationrequest](msdyn_optimizationrequest.md#BKMK_team_msdyn_optimizationrequest)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_optimizationrequest`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_optimizationrequest`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_orderinvoicingdate"></a> team_msdyn_orderinvoicingdate

Many-To-One Relationship: [msdyn_orderinvoicingdate team_msdyn_orderinvoicingdate](msdyn_orderinvoicingdate.md#BKMK_team_msdyn_orderinvoicingdate)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_orderinvoicingdate`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_orderinvoicingdate`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_orderinvoicingproduct"></a> team_msdyn_orderinvoicingproduct

Many-To-One Relationship: [msdyn_orderinvoicingproduct team_msdyn_orderinvoicingproduct](msdyn_orderinvoicingproduct.md#BKMK_team_msdyn_orderinvoicingproduct)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_orderinvoicingproduct`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_orderinvoicingproduct`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_orderinvoicingsetup"></a> team_msdyn_orderinvoicingsetup

Many-To-One Relationship: [msdyn_orderinvoicingsetup team_msdyn_orderinvoicingsetup](msdyn_orderinvoicingsetup.md#BKMK_team_msdyn_orderinvoicingsetup)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_orderinvoicingsetup`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_orderinvoicingsetup`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_orderinvoicingsetupdate"></a> team_msdyn_orderinvoicingsetupdate

Many-To-One Relationship: [msdyn_orderinvoicingsetupdate team_msdyn_orderinvoicingsetupdate](msdyn_orderinvoicingsetupdate.md#BKMK_team_msdyn_orderinvoicingsetupdate)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_orderinvoicingsetupdate`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_orderinvoicingsetupdate`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_payment"></a> team_msdyn_payment

Many-To-One Relationship: [msdyn_payment team_msdyn_payment](msdyn_payment.md#BKMK_team_msdyn_payment)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_payment`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_payment`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_paymentdetail"></a> team_msdyn_paymentdetail

Many-To-One Relationship: [msdyn_paymentdetail team_msdyn_paymentdetail](msdyn_paymentdetail.md#BKMK_team_msdyn_paymentdetail)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_paymentdetail`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_paymentdetail`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_paymentmethod"></a> team_msdyn_paymentmethod

Many-To-One Relationship: [msdyn_paymentmethod team_msdyn_paymentmethod](msdyn_paymentmethod.md#BKMK_team_msdyn_paymentmethod)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_paymentmethod`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_paymentmethod`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_paymentterm"></a> team_msdyn_paymentterm

Many-To-One Relationship: [msdyn_paymentterm team_msdyn_paymentterm](msdyn_paymentterm.md#BKMK_team_msdyn_paymentterm)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_paymentterm`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_paymentterm`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_postalcode"></a> team_msdyn_postalcode

Many-To-One Relationship: [msdyn_postalcode team_msdyn_postalcode](msdyn_postalcode.md#BKMK_team_msdyn_postalcode)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_postalcode`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_postalcode`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_priority"></a> team_msdyn_priority

Many-To-One Relationship: [msdyn_priority team_msdyn_priority](msdyn_priority.md#BKMK_team_msdyn_priority)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_priority`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_priority`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_problematicasset"></a> team_msdyn_problematicasset

Many-To-One Relationship: [msdyn_problematicasset team_msdyn_problematicasset](msdyn_problematicasset.md#BKMK_team_msdyn_problematicasset)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_problematicasset`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_problematicasset`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_problematicassetfeedback"></a> team_msdyn_problematicassetfeedback

Many-To-One Relationship: [msdyn_problematicassetfeedback team_msdyn_problematicassetfeedback](msdyn_problematicassetfeedback.md#BKMK_team_msdyn_problematicassetfeedback)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_problematicassetfeedback`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_problematicassetfeedback`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_purchaseorder"></a> team_msdyn_purchaseorder

Many-To-One Relationship: [msdyn_purchaseorder team_msdyn_purchaseorder](msdyn_purchaseorder.md#BKMK_team_msdyn_purchaseorder)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_purchaseorder`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_purchaseorder`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_purchaseorderbill"></a> team_msdyn_purchaseorderbill

Many-To-One Relationship: [msdyn_purchaseorderbill team_msdyn_purchaseorderbill](msdyn_purchaseorderbill.md#BKMK_team_msdyn_purchaseorderbill)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_purchaseorderbill`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_purchaseorderbill`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_purchaseorderproduct"></a> team_msdyn_purchaseorderproduct

Many-To-One Relationship: [msdyn_purchaseorderproduct team_msdyn_purchaseorderproduct](msdyn_purchaseorderproduct.md#BKMK_team_msdyn_purchaseorderproduct)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_purchaseorderproduct`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_purchaseorderproduct`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_purchaseorderreceipt"></a> team_msdyn_purchaseorderreceipt

Many-To-One Relationship: [msdyn_purchaseorderreceipt team_msdyn_purchaseorderreceipt](msdyn_purchaseorderreceipt.md#BKMK_team_msdyn_purchaseorderreceipt)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_purchaseorderreceipt`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_purchaseorderreceipt`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_purchaseorderreceiptproduct"></a> team_msdyn_purchaseorderreceiptproduct

Many-To-One Relationship: [msdyn_purchaseorderreceiptproduct team_msdyn_purchaseorderreceiptproduct](msdyn_purchaseorderreceiptproduct.md#BKMK_team_msdyn_purchaseorderreceiptproduct)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_purchaseorderreceiptproduct`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_purchaseorderreceiptproduct`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_purchaseordersubstatus"></a> team_msdyn_purchaseordersubstatus

Many-To-One Relationship: [msdyn_purchaseordersubstatus team_msdyn_purchaseordersubstatus](msdyn_purchaseordersubstatus.md#BKMK_team_msdyn_purchaseordersubstatus)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_purchaseordersubstatus`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_purchaseordersubstatus`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_quotebookingincident"></a> team_msdyn_quotebookingincident

Many-To-One Relationship: [msdyn_quotebookingincident team_msdyn_quotebookingincident](msdyn_quotebookingincident.md#BKMK_team_msdyn_quotebookingincident)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_quotebookingincident`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_quotebookingincident`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_quotebookingproduct"></a> team_msdyn_quotebookingproduct

Many-To-One Relationship: [msdyn_quotebookingproduct team_msdyn_quotebookingproduct](msdyn_quotebookingproduct.md#BKMK_team_msdyn_quotebookingproduct)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_quotebookingproduct`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_quotebookingproduct`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_quotebookingservice"></a> team_msdyn_quotebookingservice

Many-To-One Relationship: [msdyn_quotebookingservice team_msdyn_quotebookingservice](msdyn_quotebookingservice.md#BKMK_team_msdyn_quotebookingservice)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_quotebookingservice`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_quotebookingservice`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_quotebookingservicetask"></a> team_msdyn_quotebookingservicetask

Many-To-One Relationship: [msdyn_quotebookingservicetask team_msdyn_quotebookingservicetask](msdyn_quotebookingservicetask.md#BKMK_team_msdyn_quotebookingservicetask)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_quotebookingservicetask`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_quotebookingservicetask`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_quotebookingsetup"></a> team_msdyn_quotebookingsetup

Many-To-One Relationship: [msdyn_quotebookingsetup team_msdyn_quotebookingsetup](msdyn_quotebookingsetup.md#BKMK_team_msdyn_quotebookingsetup)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_quotebookingsetup`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_quotebookingsetup`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_quoteinvoicingproduct"></a> team_msdyn_quoteinvoicingproduct

Many-To-One Relationship: [msdyn_quoteinvoicingproduct team_msdyn_quoteinvoicingproduct](msdyn_quoteinvoicingproduct.md#BKMK_team_msdyn_quoteinvoicingproduct)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_quoteinvoicingproduct`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_quoteinvoicingproduct`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_quoteinvoicingsetup"></a> team_msdyn_quoteinvoicingsetup

Many-To-One Relationship: [msdyn_quoteinvoicingsetup team_msdyn_quoteinvoicingsetup](msdyn_quoteinvoicingsetup.md#BKMK_team_msdyn_quoteinvoicingsetup)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_quoteinvoicingsetup`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_quoteinvoicingsetup`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_requirementchange"></a> team_msdyn_requirementchange

Many-To-One Relationship: [msdyn_requirementchange team_msdyn_requirementchange](msdyn_requirementchange.md#BKMK_team_msdyn_requirementchange)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_requirementchange`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_requirementchange`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_requirementcharacteristic"></a> team_msdyn_requirementcharacteristic

Many-To-One Relationship: [msdyn_requirementcharacteristic team_msdyn_requirementcharacteristic](msdyn_requirementcharacteristic.md#BKMK_team_msdyn_requirementcharacteristic)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_requirementcharacteristic`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_requirementcharacteristic`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_requirementdependency"></a> team_msdyn_requirementdependency

Many-To-One Relationship: [msdyn_requirementdependency team_msdyn_requirementdependency](msdyn_requirementdependency.md#BKMK_team_msdyn_requirementdependency)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_requirementdependency`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_requirementdependency`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_requirementgroup"></a> team_msdyn_requirementgroup

Many-To-One Relationship: [msdyn_requirementgroup team_msdyn_requirementgroup](msdyn_requirementgroup.md#BKMK_team_msdyn_requirementgroup)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_requirementgroup`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_requirementgroup`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_requirementorganizationunit"></a> team_msdyn_requirementorganizationunit

Many-To-One Relationship: [msdyn_requirementorganizationunit team_msdyn_requirementorganizationunit](msdyn_requirementorganizationunit.md#BKMK_team_msdyn_requirementorganizationunit)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_requirementorganizationunit`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_requirementorganizationunit`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_requirementrelationship"></a> team_msdyn_requirementrelationship

Many-To-One Relationship: [msdyn_requirementrelationship team_msdyn_requirementrelationship](msdyn_requirementrelationship.md#BKMK_team_msdyn_requirementrelationship)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_requirementrelationship`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_requirementrelationship`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_requirementresourcecategory"></a> team_msdyn_requirementresourcecategory

Many-To-One Relationship: [msdyn_requirementresourcecategory team_msdyn_requirementresourcecategory](msdyn_requirementresourcecategory.md#BKMK_team_msdyn_requirementresourcecategory)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_requirementresourcecategory`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_requirementresourcecategory`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_requirementresourcepreference"></a> team_msdyn_requirementresourcepreference

Many-To-One Relationship: [msdyn_requirementresourcepreference team_msdyn_requirementresourcepreference](msdyn_requirementresourcepreference.md#BKMK_team_msdyn_requirementresourcepreference)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_requirementresourcepreference`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_requirementresourcepreference`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_requirementstatus"></a> team_msdyn_requirementstatus

Many-To-One Relationship: [msdyn_requirementstatus team_msdyn_requirementstatus](msdyn_requirementstatus.md#BKMK_team_msdyn_requirementstatus)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_requirementstatus`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_requirementstatus`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_resolution"></a> team_msdyn_resolution

Many-To-One Relationship: [msdyn_resolution team_msdyn_resolution](msdyn_resolution.md#BKMK_team_msdyn_resolution)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_resolution`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_resolution`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_resourcepaytype"></a> team_msdyn_resourcepaytype

Many-To-One Relationship: [msdyn_resourcepaytype team_msdyn_resourcepaytype](msdyn_resourcepaytype.md#BKMK_team_msdyn_resourcepaytype)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_resourcepaytype`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_resourcepaytype`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_resourcerequirement"></a> team_msdyn_resourcerequirement

Many-To-One Relationship: [msdyn_resourcerequirement team_msdyn_resourcerequirement](msdyn_resourcerequirement.md#BKMK_team_msdyn_resourcerequirement)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_resourcerequirement`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_resourcerequirement`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_resourcerequirementdetail"></a> team_msdyn_resourcerequirementdetail

Many-To-One Relationship: [msdyn_resourcerequirementdetail team_msdyn_resourcerequirementdetail](msdyn_resourcerequirementdetail.md#BKMK_team_msdyn_resourcerequirementdetail)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_resourcerequirementdetail`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_resourcerequirementdetail`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_resourceterritory"></a> team_msdyn_resourceterritory

Many-To-One Relationship: [msdyn_resourceterritory team_msdyn_resourceterritory](msdyn_resourceterritory.md#BKMK_team_msdyn_resourceterritory)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_resourceterritory`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_resourceterritory`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_rma"></a> team_msdyn_rma

Many-To-One Relationship: [msdyn_rma team_msdyn_rma](msdyn_rma.md#BKMK_team_msdyn_rma)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_rma`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_rma`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_rmaproduct"></a> team_msdyn_rmaproduct

Many-To-One Relationship: [msdyn_rmaproduct team_msdyn_rmaproduct](msdyn_rmaproduct.md#BKMK_team_msdyn_rmaproduct)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_rmaproduct`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_rmaproduct`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_rmareceipt"></a> team_msdyn_rmareceipt

Many-To-One Relationship: [msdyn_rmareceipt team_msdyn_rmareceipt](msdyn_rmareceipt.md#BKMK_team_msdyn_rmareceipt)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_rmareceipt`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_rmareceipt`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_rmareceiptproduct"></a> team_msdyn_rmareceiptproduct

Many-To-One Relationship: [msdyn_rmareceiptproduct team_msdyn_rmareceiptproduct](msdyn_rmareceiptproduct.md#BKMK_team_msdyn_rmareceiptproduct)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_rmareceiptproduct`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_rmareceiptproduct`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_rmasubstatus"></a> team_msdyn_rmasubstatus

Many-To-One Relationship: [msdyn_rmasubstatus team_msdyn_rmasubstatus](msdyn_rmasubstatus.md#BKMK_team_msdyn_rmasubstatus)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_rmasubstatus`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_rmasubstatus`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_rtv"></a> team_msdyn_rtv

Many-To-One Relationship: [msdyn_rtv team_msdyn_rtv](msdyn_rtv.md#BKMK_team_msdyn_rtv)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_rtv`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_rtv`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_rtvproduct"></a> team_msdyn_rtvproduct

Many-To-One Relationship: [msdyn_rtvproduct team_msdyn_rtvproduct](msdyn_rtvproduct.md#BKMK_team_msdyn_rtvproduct)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_rtvproduct`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_rtvproduct`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_rtvsubstatus"></a> team_msdyn_rtvsubstatus

Many-To-One Relationship: [msdyn_rtvsubstatus team_msdyn_rtvsubstatus](msdyn_rtvsubstatus.md#BKMK_team_msdyn_rtvsubstatus)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_rtvsubstatus`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_rtvsubstatus`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_scheduleboardsetting"></a> team_msdyn_scheduleboardsetting

Many-To-One Relationship: [msdyn_scheduleboardsetting team_msdyn_scheduleboardsetting](msdyn_scheduleboardsetting.md#BKMK_team_msdyn_scheduleboardsetting)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_scheduleboardsetting`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_scheduleboardsetting`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_schedulingfeatureflag"></a> team_msdyn_schedulingfeatureflag

Many-To-One Relationship: [msdyn_schedulingfeatureflag team_msdyn_schedulingfeatureflag](msdyn_schedulingfeatureflag.md#BKMK_team_msdyn_schedulingfeatureflag)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_schedulingfeatureflag`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_schedulingfeatureflag`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_servicetasktype"></a> team_msdyn_servicetasktype

Many-To-One Relationship: [msdyn_servicetasktype team_msdyn_servicetasktype](msdyn_servicetasktype.md#BKMK_team_msdyn_servicetasktype)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_servicetasktype`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_servicetasktype`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_sessiondata"></a> team_msdyn_sessiondata

Many-To-One Relationship: [msdyn_sessiondata team_msdyn_sessiondata](msdyn_sessiondata.md#BKMK_team_msdyn_sessiondata)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_sessiondata`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_sessiondata`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_sessionparticipantdata"></a> team_msdyn_sessionparticipantdata

Many-To-One Relationship: [msdyn_sessionparticipantdata team_msdyn_sessionparticipantdata](msdyn_sessionparticipantdata.md#BKMK_team_msdyn_sessionparticipantdata)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_sessionparticipantdata`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_sessionparticipantdata`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_shipvia"></a> team_msdyn_shipvia

Many-To-One Relationship: [msdyn_shipvia team_msdyn_shipvia](msdyn_shipvia.md#BKMK_team_msdyn_shipvia)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_shipvia`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_shipvia`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_systemuserschedulersetting"></a> team_msdyn_systemuserschedulersetting

Many-To-One Relationship: [msdyn_systemuserschedulersetting team_msdyn_systemuserschedulersetting](msdyn_systemuserschedulersetting.md#BKMK_team_msdyn_systemuserschedulersetting)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_systemuserschedulersetting`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_systemuserschedulersetting`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_taxcode"></a> team_msdyn_taxcode

Many-To-One Relationship: [msdyn_taxcode team_msdyn_taxcode](msdyn_taxcode.md#BKMK_team_msdyn_taxcode)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_taxcode`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_taxcode`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_taxcodedetail"></a> team_msdyn_taxcodedetail

Many-To-One Relationship: [msdyn_taxcodedetail team_msdyn_taxcodedetail](msdyn_taxcodedetail.md#BKMK_team_msdyn_taxcodedetail)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_taxcodedetail`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_taxcodedetail`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_timeentry"></a> team_msdyn_timeentry

Many-To-One Relationship: [msdyn_timeentry team_msdyn_timeentry](msdyn_timeentry.md#BKMK_team_msdyn_timeentry)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_timeentry`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_timeentry`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_timeentrysetting"></a> team_msdyn_timeentrysetting

Many-To-One Relationship: [msdyn_timeentrysetting team_msdyn_timeentrysetting](msdyn_timeentrysetting.md#BKMK_team_msdyn_timeentrysetting)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_timeentrysetting`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_timeentrysetting`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_timegroup"></a> team_msdyn_timegroup

Many-To-One Relationship: [msdyn_timegroup team_msdyn_timegroup](msdyn_timegroup.md#BKMK_team_msdyn_timegroup)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_timegroup`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_timegroup`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_timegroupdetail"></a> team_msdyn_timegroupdetail

Many-To-One Relationship: [msdyn_timegroupdetail team_msdyn_timegroupdetail](msdyn_timegroupdetail.md#BKMK_team_msdyn_timegroupdetail)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_timegroupdetail`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_timegroupdetail`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_timeoffrequest"></a> team_msdyn_timeoffrequest

Many-To-One Relationship: [msdyn_timeoffrequest team_msdyn_timeoffrequest](msdyn_timeoffrequest.md#BKMK_team_msdyn_timeoffrequest)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_timeoffrequest`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_timeoffrequest`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_trade"></a> team_msdyn_trade

Many-To-One Relationship: [msdyn_trade team_msdyn_trade](msdyn_trade.md#BKMK_team_msdyn_trade)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_trade`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_trade`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_tradecoverage"></a> team_msdyn_tradecoverage

Many-To-One Relationship: [msdyn_tradecoverage team_msdyn_tradecoverage](msdyn_tradecoverage.md#BKMK_team_msdyn_tradecoverage)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_tradecoverage`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_tradecoverage`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_transactionorigin"></a> team_msdyn_transactionorigin

Many-To-One Relationship: [msdyn_transactionorigin team_msdyn_transactionorigin](msdyn_transactionorigin.md#BKMK_team_msdyn_transactionorigin)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_transactionorigin`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_transactionorigin`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_warehouse"></a> team_msdyn_warehouse

Many-To-One Relationship: [msdyn_warehouse team_msdyn_warehouse](msdyn_warehouse.md#BKMK_team_msdyn_warehouse)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_warehouse`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_warehouse`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_workhourtemplate"></a> team_msdyn_workhourtemplate

Many-To-One Relationship: [msdyn_workhourtemplate team_msdyn_workhourtemplate](msdyn_workhourtemplate.md#BKMK_team_msdyn_workhourtemplate)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_workhourtemplate`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_workhourtemplate`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_workorder"></a> team_msdyn_workorder

Many-To-One Relationship: [msdyn_workorder team_msdyn_workorder](msdyn_workorder.md#BKMK_team_msdyn_workorder)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_workorder`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_workorder`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_workorderincident"></a> team_msdyn_workorderincident

Many-To-One Relationship: [msdyn_workorderincident team_msdyn_workorderincident](msdyn_workorderincident.md#BKMK_team_msdyn_workorderincident)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_workorderincident`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_workorderincident`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_workordernte"></a> team_msdyn_workordernte

Many-To-One Relationship: [msdyn_workordernte team_msdyn_workordernte](msdyn_workordernte.md#BKMK_team_msdyn_workordernte)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_workordernte`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_workordernte`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_workorderproduct"></a> team_msdyn_workorderproduct

Many-To-One Relationship: [msdyn_workorderproduct team_msdyn_workorderproduct](msdyn_workorderproduct.md#BKMK_team_msdyn_workorderproduct)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_workorderproduct`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_workorderproduct`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_workorderresolution"></a> team_msdyn_workorderresolution

Many-To-One Relationship: [msdyn_workorderresolution team_msdyn_workorderresolution](msdyn_workorderresolution.md#BKMK_team_msdyn_workorderresolution)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_workorderresolution`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_workorderresolution`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_workorderresourcerestriction"></a> team_msdyn_workorderresourcerestriction

Many-To-One Relationship: [msdyn_workorderresourcerestriction team_msdyn_workorderresourcerestriction](msdyn_workorderresourcerestriction.md#BKMK_team_msdyn_workorderresourcerestriction)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_workorderresourcerestriction`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_workorderresourcerestriction`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_workorderservice"></a> team_msdyn_workorderservice

Many-To-One Relationship: [msdyn_workorderservice team_msdyn_workorderservice](msdyn_workorderservice.md#BKMK_team_msdyn_workorderservice)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_workorderservice`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_workorderservice`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_workorderservicetask"></a> team_msdyn_workorderservicetask

Many-To-One Relationship: [msdyn_workorderservicetask team_msdyn_workorderservicetask](msdyn_workorderservicetask.md#BKMK_team_msdyn_workorderservicetask)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_workorderservicetask`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_workorderservicetask`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_workordersubstatus"></a> team_msdyn_workordersubstatus

Many-To-One Relationship: [msdyn_workordersubstatus team_msdyn_workordersubstatus](msdyn_workordersubstatus.md#BKMK_team_msdyn_workordersubstatus)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_workordersubstatus`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_workordersubstatus`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_workordertype"></a> team_msdyn_workordertype

Many-To-One Relationship: [msdyn_workordertype team_msdyn_workordertype](msdyn_workordertype.md#BKMK_team_msdyn_workordertype)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_workordertype`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_workordertype`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|



### See also

[Dataverse table/entity reference](../about-entity-reference.md)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   
<xref:Microsoft.Dynamics.CRM.team?displayProperty=fullName>
