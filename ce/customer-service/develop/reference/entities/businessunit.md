---
title: "Business Unit (BusinessUnit) table/entity reference (Microsoft Dynamics 365 Customer Service)"
description: "Includes schema information and supported messages for the Business Unit (BusinessUnit) table/entity with Microsoft Dynamics 365 Customer Service."
ms.topic: generated-reference
author: gandhamm
ms.author: mgandham
search.audienceType: 
  - developer
---

# Business Unit (BusinessUnit) table/entity reference (Microsoft Dynamics 365 Customer Service)

Business, division, or department in the Microsoft Dynamics 365 database.

> [!NOTE]
> The Microsoft Dynamics 365 Customer Service Business Unit (BusinessUnit) table extends the [Microsoft Dynamics 365 Business Unit (BusinessUnit) table](/dynamics365/developer/reference/entities/businessunit).




## One-to-Many relationships

These relationships are one-to-many. Listed by **SchemaName**.

- [business_unit_msdyn_actual](#BKMK_business_unit_msdyn_actual)
- [business_unit_msdyn_bookableresourceassociation](#BKMK_business_unit_msdyn_bookableresourceassociation)
- [business_unit_msdyn_bookingalertstatus](#BKMK_business_unit_msdyn_bookingalertstatus)
- [business_unit_msdyn_bookingchange](#BKMK_business_unit_msdyn_bookingchange)
- [business_unit_msdyn_bookingrule](#BKMK_business_unit_msdyn_bookingrule)
- [business_unit_msdyn_bookingsetupmetadata](#BKMK_business_unit_msdyn_bookingsetupmetadata)
- [business_unit_msdyn_businessclosure](#BKMK_business_unit_msdyn_businessclosure)
- [business_unit_msdyn_clientextension](#BKMK_business_unit_msdyn_clientextension)
- [business_unit_msdyn_configuration](#BKMK_business_unit_msdyn_configuration)
- [business_unit_msdyn_optimizationrequest](#BKMK_business_unit_msdyn_optimizationrequest)
- [business_unit_msdyn_priority](#BKMK_business_unit_msdyn_priority)
- [business_unit_msdyn_requirementchange](#BKMK_business_unit_msdyn_requirementchange)
- [business_unit_msdyn_requirementcharacteristic](#BKMK_business_unit_msdyn_requirementcharacteristic)
- [business_unit_msdyn_requirementdependency](#BKMK_business_unit_msdyn_requirementdependency)
- [business_unit_msdyn_requirementgroup](#BKMK_business_unit_msdyn_requirementgroup)
- [business_unit_msdyn_requirementorganizationunit](#BKMK_business_unit_msdyn_requirementorganizationunit)
- [business_unit_msdyn_requirementrelationship](#BKMK_business_unit_msdyn_requirementrelationship)
- [business_unit_msdyn_requirementresourcecategory](#BKMK_business_unit_msdyn_requirementresourcecategory)
- [business_unit_msdyn_requirementresourcepreference](#BKMK_business_unit_msdyn_requirementresourcepreference)
- [business_unit_msdyn_requirementstatus](#BKMK_business_unit_msdyn_requirementstatus)
- [business_unit_msdyn_resourcerequirement](#BKMK_business_unit_msdyn_resourcerequirement)
- [business_unit_msdyn_resourcerequirementdetail](#BKMK_business_unit_msdyn_resourcerequirementdetail)
- [business_unit_msdyn_resourceterritory](#BKMK_business_unit_msdyn_resourceterritory)
- [business_unit_msdyn_scheduleboardsetting](#BKMK_business_unit_msdyn_scheduleboardsetting)
- [business_unit_msdyn_schedulingfeatureflag](#BKMK_business_unit_msdyn_schedulingfeatureflag)
- [business_unit_msdyn_schedulingscope](#BKMK_business_unit_msdyn_schedulingscope)
- [business_unit_msdyn_systemuserschedulersetting](#BKMK_business_unit_msdyn_systemuserschedulersetting)
- [business_unit_msdyn_timegroup](#BKMK_business_unit_msdyn_timegroup)
- [business_unit_msdyn_timegroupdetail](#BKMK_business_unit_msdyn_timegroupdetail)
- [business_unit_msdyn_transactionorigin](#BKMK_business_unit_msdyn_transactionorigin)
- [business_unit_msdyn_workhourtemplate](#BKMK_business_unit_msdyn_workhourtemplate)
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

### <a name="BKMK_business_unit_msdyn_bookableresourceassociation"></a> business_unit_msdyn_bookableresourceassociation

Many-To-One Relationship: [msdyn_bookableresourceassociation business_unit_msdyn_bookableresourceassociation](msdyn_bookableresourceassociation.md#BKMK_business_unit_msdyn_bookableresourceassociation)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_bookableresourceassociation`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msdyn_bookableresourceassociation`|
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

### <a name="BKMK_business_unit_msdyn_optimizationrequest"></a> business_unit_msdyn_optimizationrequest

Many-To-One Relationship: [msdyn_optimizationrequest business_unit_msdyn_optimizationrequest](msdyn_optimizationrequest.md#BKMK_business_unit_msdyn_optimizationrequest)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_optimizationrequest`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msdyn_optimizationrequest`|
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

### <a name="BKMK_business_unit_msdyn_schedulingscope"></a> business_unit_msdyn_schedulingscope

Many-To-One Relationship: [msdyn_schedulingscope business_unit_msdyn_schedulingscope](msdyn_schedulingscope.md#BKMK_business_unit_msdyn_schedulingscope)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_schedulingscope`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msdyn_schedulingscope`|
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

### <a name="BKMK_business_unit_msdyn_transactionorigin"></a> business_unit_msdyn_transactionorigin

Many-To-One Relationship: [msdyn_transactionorigin business_unit_msdyn_transactionorigin](msdyn_transactionorigin.md#BKMK_business_unit_msdyn_transactionorigin)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_transactionorigin`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msdyn_transactionorigin`|
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

[Dataverse table/entity reference](/power-apps/developer/data-platform/reference/about-entity-reference)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   
<xref:Microsoft.Dynamics.CRM.businessunit?displayProperty=fullName>
