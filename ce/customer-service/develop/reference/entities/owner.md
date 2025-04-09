---
title: "Owner table/entity reference (Microsoft Dynamics 365 Customer Service)"
description: "Includes schema information and supported messages for the Owner table/entity with Microsoft Dynamics 365 Customer Service."
ms.topic: generated-reference
author: gandhamm
ms.author: mgandham
search.audienceType: 
  - developer
---

# Owner table/entity reference (Microsoft Dynamics 365 Customer Service)

Group of undeleted system users and undeleted teams. Owners can be used to control access to specific objects.

> [!NOTE]
> The Microsoft Dynamics 365 Customer Service Owner table extends the [Microsoft Dynamics 365 Owner table](/dynamics365/developer/reference/entities/owner).




## One-to-Many relationships

These relationships are one-to-many. Listed by **SchemaName**.

- [msdyn_bookingalert_owner_ownerid](#BKMK_msdyn_bookingalert_owner_ownerid)
- [owner_msdyn_actual](#BKMK_owner_msdyn_actual)
- [owner_msdyn_bookableresourceassociation](#BKMK_owner_msdyn_bookableresourceassociation)
- [owner_msdyn_bookingalertstatus](#BKMK_owner_msdyn_bookingalertstatus)
- [owner_msdyn_bookingchange](#BKMK_owner_msdyn_bookingchange)
- [owner_msdyn_bookingrule](#BKMK_owner_msdyn_bookingrule)
- [owner_msdyn_bookingsetupmetadata](#BKMK_owner_msdyn_bookingsetupmetadata)
- [owner_msdyn_businessclosure](#BKMK_owner_msdyn_businessclosure)
- [owner_msdyn_clientextension](#BKMK_owner_msdyn_clientextension)
- [owner_msdyn_configuration](#BKMK_owner_msdyn_configuration)
- [owner_msdyn_optimizationrequest](#BKMK_owner_msdyn_optimizationrequest)
- [owner_msdyn_priority](#BKMK_owner_msdyn_priority)
- [owner_msdyn_requirementchange](#BKMK_owner_msdyn_requirementchange)
- [owner_msdyn_requirementcharacteristic](#BKMK_owner_msdyn_requirementcharacteristic)
- [owner_msdyn_requirementdependency](#BKMK_owner_msdyn_requirementdependency)
- [owner_msdyn_requirementgroup](#BKMK_owner_msdyn_requirementgroup)
- [owner_msdyn_requirementorganizationunit](#BKMK_owner_msdyn_requirementorganizationunit)
- [owner_msdyn_requirementrelationship](#BKMK_owner_msdyn_requirementrelationship)
- [owner_msdyn_requirementresourcecategory](#BKMK_owner_msdyn_requirementresourcecategory)
- [owner_msdyn_requirementresourcepreference](#BKMK_owner_msdyn_requirementresourcepreference)
- [owner_msdyn_requirementstatus](#BKMK_owner_msdyn_requirementstatus)
- [owner_msdyn_resourcerequirement](#BKMK_owner_msdyn_resourcerequirement)
- [owner_msdyn_resourcerequirementdetail](#BKMK_owner_msdyn_resourcerequirementdetail)
- [owner_msdyn_resourceterritory](#BKMK_owner_msdyn_resourceterritory)
- [owner_msdyn_scheduleboardsetting](#BKMK_owner_msdyn_scheduleboardsetting)
- [owner_msdyn_schedulingfeatureflag](#BKMK_owner_msdyn_schedulingfeatureflag)
- [owner_msdyn_schedulingscope](#BKMK_owner_msdyn_schedulingscope)
- [owner_msdyn_systemuserschedulersetting](#BKMK_owner_msdyn_systemuserschedulersetting)
- [owner_msdyn_timegroup](#BKMK_owner_msdyn_timegroup)
- [owner_msdyn_timegroupdetail](#BKMK_owner_msdyn_timegroupdetail)
- [owner_msdyn_transactionorigin](#BKMK_owner_msdyn_transactionorigin)
- [owner_msdyn_workhourtemplate](#BKMK_owner_msdyn_workhourtemplate)

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

### <a name="BKMK_owner_msdyn_bookableresourceassociation"></a> owner_msdyn_bookableresourceassociation

Many-To-One Relationship: [msdyn_bookableresourceassociation owner_msdyn_bookableresourceassociation](msdyn_bookableresourceassociation.md#BKMK_owner_msdyn_bookableresourceassociation)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_bookableresourceassociation`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_bookableresourceassociation`|
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

### <a name="BKMK_owner_msdyn_optimizationrequest"></a> owner_msdyn_optimizationrequest

Many-To-One Relationship: [msdyn_optimizationrequest owner_msdyn_optimizationrequest](msdyn_optimizationrequest.md#BKMK_owner_msdyn_optimizationrequest)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_optimizationrequest`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_optimizationrequest`|
|IsCustomizable|`False`|
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

### <a name="BKMK_owner_msdyn_schedulingscope"></a> owner_msdyn_schedulingscope

Many-To-One Relationship: [msdyn_schedulingscope owner_msdyn_schedulingscope](msdyn_schedulingscope.md#BKMK_owner_msdyn_schedulingscope)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_schedulingscope`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_schedulingscope`|
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

### <a name="BKMK_owner_msdyn_transactionorigin"></a> owner_msdyn_transactionorigin

Many-To-One Relationship: [msdyn_transactionorigin owner_msdyn_transactionorigin](msdyn_transactionorigin.md#BKMK_owner_msdyn_transactionorigin)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_transactionorigin`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_transactionorigin`|
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



### See also

[Dataverse table/entity reference](/power-apps/developer/data-platform/reference/about-entity-reference)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   

