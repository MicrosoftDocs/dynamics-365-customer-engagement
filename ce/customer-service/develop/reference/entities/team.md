---
title: "Team table/entity reference (Microsoft Dynamics 365 Customer Service)"
description: "Includes schema information and supported messages for the Team table/entity with Microsoft Dynamics 365 Customer Service."
ms.topic: generated-reference
author: gandhamm
ms.author: mgandham
search.audienceType: 
  - developer
---

# Team table/entity reference (Microsoft Dynamics 365 Customer Service)

Collection of system users that routinely collaborate. Teams can be used to simplify record sharing and provide team members with common access to organization data when team members belong to different Business Units.

> [!NOTE]
> The Microsoft Dynamics 365 Customer Service Team table extends the [Microsoft Dynamics 365 Team table](/dynamics365/developer/reference/entities/team).




## One-to-Many relationships

These relationships are one-to-many. Listed by **SchemaName**.

- [msdyn_bookingalert_team_owningteam](#BKMK_msdyn_bookingalert_team_owningteam)
- [team_msdyn_actual](#BKMK_team_msdyn_actual)
- [team_msdyn_bookableresourceassociation](#BKMK_team_msdyn_bookableresourceassociation)
- [team_msdyn_bookingalertstatus](#BKMK_team_msdyn_bookingalertstatus)
- [team_msdyn_bookingchange](#BKMK_team_msdyn_bookingchange)
- [team_msdyn_bookingrule](#BKMK_team_msdyn_bookingrule)
- [team_msdyn_bookingsetupmetadata](#BKMK_team_msdyn_bookingsetupmetadata)
- [team_msdyn_businessclosure](#BKMK_team_msdyn_businessclosure)
- [team_msdyn_clientextension](#BKMK_team_msdyn_clientextension)
- [team_msdyn_configuration](#BKMK_team_msdyn_configuration)
- [team_msdyn_optimizationrequest](#BKMK_team_msdyn_optimizationrequest)
- [team_msdyn_priority](#BKMK_team_msdyn_priority)
- [team_msdyn_requirementchange](#BKMK_team_msdyn_requirementchange)
- [team_msdyn_requirementcharacteristic](#BKMK_team_msdyn_requirementcharacteristic)
- [team_msdyn_requirementdependency](#BKMK_team_msdyn_requirementdependency)
- [team_msdyn_requirementgroup](#BKMK_team_msdyn_requirementgroup)
- [team_msdyn_requirementorganizationunit](#BKMK_team_msdyn_requirementorganizationunit)
- [team_msdyn_requirementrelationship](#BKMK_team_msdyn_requirementrelationship)
- [team_msdyn_requirementresourcecategory](#BKMK_team_msdyn_requirementresourcecategory)
- [team_msdyn_requirementresourcepreference](#BKMK_team_msdyn_requirementresourcepreference)
- [team_msdyn_requirementstatus](#BKMK_team_msdyn_requirementstatus)
- [team_msdyn_resourcerequirement](#BKMK_team_msdyn_resourcerequirement)
- [team_msdyn_resourcerequirementdetail](#BKMK_team_msdyn_resourcerequirementdetail)
- [team_msdyn_resourceterritory](#BKMK_team_msdyn_resourceterritory)
- [team_msdyn_scheduleboardsetting](#BKMK_team_msdyn_scheduleboardsetting)
- [team_msdyn_schedulingfeatureflag](#BKMK_team_msdyn_schedulingfeatureflag)
- [team_msdyn_schedulingscope](#BKMK_team_msdyn_schedulingscope)
- [team_msdyn_systemuserschedulersetting](#BKMK_team_msdyn_systemuserschedulersetting)
- [team_msdyn_timegroup](#BKMK_team_msdyn_timegroup)
- [team_msdyn_timegroupdetail](#BKMK_team_msdyn_timegroupdetail)
- [team_msdyn_transactionorigin](#BKMK_team_msdyn_transactionorigin)
- [team_msdyn_workhourtemplate](#BKMK_team_msdyn_workhourtemplate)

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

### <a name="BKMK_team_msdyn_bookableresourceassociation"></a> team_msdyn_bookableresourceassociation

Many-To-One Relationship: [msdyn_bookableresourceassociation team_msdyn_bookableresourceassociation](msdyn_bookableresourceassociation.md#BKMK_team_msdyn_bookableresourceassociation)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_bookableresourceassociation`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_bookableresourceassociation`|
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

### <a name="BKMK_team_msdyn_optimizationrequest"></a> team_msdyn_optimizationrequest

Many-To-One Relationship: [msdyn_optimizationrequest team_msdyn_optimizationrequest](msdyn_optimizationrequest.md#BKMK_team_msdyn_optimizationrequest)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_optimizationrequest`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_optimizationrequest`|
|IsCustomizable|`False`|
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

### <a name="BKMK_team_msdyn_schedulingscope"></a> team_msdyn_schedulingscope

Many-To-One Relationship: [msdyn_schedulingscope team_msdyn_schedulingscope](msdyn_schedulingscope.md#BKMK_team_msdyn_schedulingscope)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_schedulingscope`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_schedulingscope`|
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

### <a name="BKMK_team_msdyn_transactionorigin"></a> team_msdyn_transactionorigin

Many-To-One Relationship: [msdyn_transactionorigin team_msdyn_transactionorigin](msdyn_transactionorigin.md#BKMK_team_msdyn_transactionorigin)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_transactionorigin`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_transactionorigin`|
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



### See also

[Dataverse table/entity reference](/power-apps/developer/data-platform/reference/about-entity-reference)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   
<xref:Microsoft.Dynamics.CRM.team?displayProperty=fullName>
