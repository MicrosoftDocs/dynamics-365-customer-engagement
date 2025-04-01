---
title: "User (SystemUser) table/entity reference (Microsoft Dynamics 365 Customer Service)"
description: "Includes schema information and supported messages for the User (SystemUser) table/entity with Microsoft Dynamics 365 Customer Service."
ms.topic: generated-reference
author: gandhamm
ms.author: mgandham
search.audienceType: 
  - developer
---

# User (SystemUser) table/entity reference (Microsoft Dynamics 365 Customer Service)

Person with access to the Microsoft CRM system and who owns objects in the Microsoft CRM database.

> [!NOTE]
> The Microsoft Dynamics 365 Customer Service User (SystemUser) table extends the [Microsoft Dynamics 365 User (SystemUser) table](/dynamics365/developer/reference/entities/systemuser).




## One-to-Many relationships

These relationships are one-to-many. Listed by **SchemaName**.

- [lk_msdyn_actual_createdby](#BKMK_lk_msdyn_actual_createdby)
- [lk_msdyn_actual_createdonbehalfby](#BKMK_lk_msdyn_actual_createdonbehalfby)
- [lk_msdyn_actual_modifiedby](#BKMK_lk_msdyn_actual_modifiedby)
- [lk_msdyn_actual_modifiedonbehalfby](#BKMK_lk_msdyn_actual_modifiedonbehalfby)
- [lk_msdyn_bookableresourceassociation_createdby](#BKMK_lk_msdyn_bookableresourceassociation_createdby)
- [lk_msdyn_bookableresourceassociation_createdonbehalfby](#BKMK_lk_msdyn_bookableresourceassociation_createdonbehalfby)
- [lk_msdyn_bookableresourceassociation_modifiedby](#BKMK_lk_msdyn_bookableresourceassociation_modifiedby)
- [lk_msdyn_bookableresourceassociation_modifiedonbehalfby](#BKMK_lk_msdyn_bookableresourceassociation_modifiedonbehalfby)
- [lk_msdyn_bookingalertstatus_createdby](#BKMK_lk_msdyn_bookingalertstatus_createdby)
- [lk_msdyn_bookingalertstatus_createdonbehalfby](#BKMK_lk_msdyn_bookingalertstatus_createdonbehalfby)
- [lk_msdyn_bookingalertstatus_modifiedby](#BKMK_lk_msdyn_bookingalertstatus_modifiedby)
- [lk_msdyn_bookingalertstatus_modifiedonbehalfby](#BKMK_lk_msdyn_bookingalertstatus_modifiedonbehalfby)
- [lk_msdyn_bookingchange_createdby](#BKMK_lk_msdyn_bookingchange_createdby)
- [lk_msdyn_bookingchange_createdonbehalfby](#BKMK_lk_msdyn_bookingchange_createdonbehalfby)
- [lk_msdyn_bookingchange_modifiedby](#BKMK_lk_msdyn_bookingchange_modifiedby)
- [lk_msdyn_bookingchange_modifiedonbehalfby](#BKMK_lk_msdyn_bookingchange_modifiedonbehalfby)
- [lk_msdyn_bookingrule_createdby](#BKMK_lk_msdyn_bookingrule_createdby)
- [lk_msdyn_bookingrule_createdonbehalfby](#BKMK_lk_msdyn_bookingrule_createdonbehalfby)
- [lk_msdyn_bookingrule_modifiedby](#BKMK_lk_msdyn_bookingrule_modifiedby)
- [lk_msdyn_bookingrule_modifiedonbehalfby](#BKMK_lk_msdyn_bookingrule_modifiedonbehalfby)
- [lk_msdyn_bookingsetupmetadata_createdby](#BKMK_lk_msdyn_bookingsetupmetadata_createdby)
- [lk_msdyn_bookingsetupmetadata_createdonbehalfby](#BKMK_lk_msdyn_bookingsetupmetadata_createdonbehalfby)
- [lk_msdyn_bookingsetupmetadata_modifiedby](#BKMK_lk_msdyn_bookingsetupmetadata_modifiedby)
- [lk_msdyn_bookingsetupmetadata_modifiedonbehalfby](#BKMK_lk_msdyn_bookingsetupmetadata_modifiedonbehalfby)
- [lk_msdyn_businessclosure_createdby](#BKMK_lk_msdyn_businessclosure_createdby)
- [lk_msdyn_businessclosure_createdonbehalfby](#BKMK_lk_msdyn_businessclosure_createdonbehalfby)
- [lk_msdyn_businessclosure_modifiedby](#BKMK_lk_msdyn_businessclosure_modifiedby)
- [lk_msdyn_businessclosure_modifiedonbehalfby](#BKMK_lk_msdyn_businessclosure_modifiedonbehalfby)
- [lk_msdyn_clientextension_createdby](#BKMK_lk_msdyn_clientextension_createdby)
- [lk_msdyn_clientextension_createdonbehalfby](#BKMK_lk_msdyn_clientextension_createdonbehalfby)
- [lk_msdyn_clientextension_modifiedby](#BKMK_lk_msdyn_clientextension_modifiedby)
- [lk_msdyn_clientextension_modifiedonbehalfby](#BKMK_lk_msdyn_clientextension_modifiedonbehalfby)
- [lk_msdyn_configuration_createdby](#BKMK_lk_msdyn_configuration_createdby)
- [lk_msdyn_configuration_createdonbehalfby](#BKMK_lk_msdyn_configuration_createdonbehalfby)
- [lk_msdyn_configuration_modifiedby](#BKMK_lk_msdyn_configuration_modifiedby)
- [lk_msdyn_configuration_modifiedonbehalfby](#BKMK_lk_msdyn_configuration_modifiedonbehalfby)
- [lk_msdyn_optimizationrequest_createdby](#BKMK_lk_msdyn_optimizationrequest_createdby)
- [lk_msdyn_optimizationrequest_createdonbehalfby](#BKMK_lk_msdyn_optimizationrequest_createdonbehalfby)
- [lk_msdyn_optimizationrequest_modifiedby](#BKMK_lk_msdyn_optimizationrequest_modifiedby)
- [lk_msdyn_optimizationrequest_modifiedonbehalfby](#BKMK_lk_msdyn_optimizationrequest_modifiedonbehalfby)
- [lk_msdyn_organizationalunit_createdby](#BKMK_lk_msdyn_organizationalunit_createdby)
- [lk_msdyn_organizationalunit_createdonbehalfby](#BKMK_lk_msdyn_organizationalunit_createdonbehalfby)
- [lk_msdyn_organizationalunit_modifiedby](#BKMK_lk_msdyn_organizationalunit_modifiedby)
- [lk_msdyn_organizationalunit_modifiedonbehalfby](#BKMK_lk_msdyn_organizationalunit_modifiedonbehalfby)
- [lk_msdyn_priority_createdby](#BKMK_lk_msdyn_priority_createdby)
- [lk_msdyn_priority_createdonbehalfby](#BKMK_lk_msdyn_priority_createdonbehalfby)
- [lk_msdyn_priority_modifiedby](#BKMK_lk_msdyn_priority_modifiedby)
- [lk_msdyn_priority_modifiedonbehalfby](#BKMK_lk_msdyn_priority_modifiedonbehalfby)
- [lk_msdyn_requirementchange_createdby](#BKMK_lk_msdyn_requirementchange_createdby)
- [lk_msdyn_requirementchange_createdonbehalfby](#BKMK_lk_msdyn_requirementchange_createdonbehalfby)
- [lk_msdyn_requirementchange_modifiedby](#BKMK_lk_msdyn_requirementchange_modifiedby)
- [lk_msdyn_requirementchange_modifiedonbehalfby](#BKMK_lk_msdyn_requirementchange_modifiedonbehalfby)
- [lk_msdyn_requirementcharacteristic_createdby](#BKMK_lk_msdyn_requirementcharacteristic_createdby)
- [lk_msdyn_requirementcharacteristic_createdonbehalfby](#BKMK_lk_msdyn_requirementcharacteristic_createdonbehalfby)
- [lk_msdyn_requirementcharacteristic_modifiedby](#BKMK_lk_msdyn_requirementcharacteristic_modifiedby)
- [lk_msdyn_requirementcharacteristic_modifiedonbehalfby](#BKMK_lk_msdyn_requirementcharacteristic_modifiedonbehalfby)
- [lk_msdyn_requirementdependency_createdby](#BKMK_lk_msdyn_requirementdependency_createdby)
- [lk_msdyn_requirementdependency_createdonbehalfby](#BKMK_lk_msdyn_requirementdependency_createdonbehalfby)
- [lk_msdyn_requirementdependency_modifiedby](#BKMK_lk_msdyn_requirementdependency_modifiedby)
- [lk_msdyn_requirementdependency_modifiedonbehalfby](#BKMK_lk_msdyn_requirementdependency_modifiedonbehalfby)
- [lk_msdyn_requirementgroup_createdby](#BKMK_lk_msdyn_requirementgroup_createdby)
- [lk_msdyn_requirementgroup_createdonbehalfby](#BKMK_lk_msdyn_requirementgroup_createdonbehalfby)
- [lk_msdyn_requirementgroup_modifiedby](#BKMK_lk_msdyn_requirementgroup_modifiedby)
- [lk_msdyn_requirementgroup_modifiedonbehalfby](#BKMK_lk_msdyn_requirementgroup_modifiedonbehalfby)
- [lk_msdyn_requirementorganizationunit_createdby](#BKMK_lk_msdyn_requirementorganizationunit_createdby)
- [lk_msdyn_requirementorganizationunit_createdonbehalfby](#BKMK_lk_msdyn_requirementorganizationunit_createdonbehalfby)
- [lk_msdyn_requirementorganizationunit_modifiedby](#BKMK_lk_msdyn_requirementorganizationunit_modifiedby)
- [lk_msdyn_requirementorganizationunit_modifiedonbehalfby](#BKMK_lk_msdyn_requirementorganizationunit_modifiedonbehalfby)
- [lk_msdyn_requirementrelationship_createdby](#BKMK_lk_msdyn_requirementrelationship_createdby)
- [lk_msdyn_requirementrelationship_createdonbehalfby](#BKMK_lk_msdyn_requirementrelationship_createdonbehalfby)
- [lk_msdyn_requirementrelationship_modifiedby](#BKMK_lk_msdyn_requirementrelationship_modifiedby)
- [lk_msdyn_requirementrelationship_modifiedonbehalfby](#BKMK_lk_msdyn_requirementrelationship_modifiedonbehalfby)
- [lk_msdyn_requirementresourcecategory_createdby](#BKMK_lk_msdyn_requirementresourcecategory_createdby)
- [lk_msdyn_requirementresourcecategory_createdonbehalfby](#BKMK_lk_msdyn_requirementresourcecategory_createdonbehalfby)
- [lk_msdyn_requirementresourcecategory_modifiedby](#BKMK_lk_msdyn_requirementresourcecategory_modifiedby)
- [lk_msdyn_requirementresourcecategory_modifiedonbehalfby](#BKMK_lk_msdyn_requirementresourcecategory_modifiedonbehalfby)
- [lk_msdyn_requirementresourcepreference_createdby](#BKMK_lk_msdyn_requirementresourcepreference_createdby)
- [lk_msdyn_requirementresourcepreference_createdonbehalfby](#BKMK_lk_msdyn_requirementresourcepreference_createdonbehalfby)
- [lk_msdyn_requirementresourcepreference_modifiedby](#BKMK_lk_msdyn_requirementresourcepreference_modifiedby)
- [lk_msdyn_requirementresourcepreference_modifiedonbehalfby](#BKMK_lk_msdyn_requirementresourcepreference_modifiedonbehalfby)
- [lk_msdyn_requirementstatus_createdby](#BKMK_lk_msdyn_requirementstatus_createdby)
- [lk_msdyn_requirementstatus_createdonbehalfby](#BKMK_lk_msdyn_requirementstatus_createdonbehalfby)
- [lk_msdyn_requirementstatus_modifiedby](#BKMK_lk_msdyn_requirementstatus_modifiedby)
- [lk_msdyn_requirementstatus_modifiedonbehalfby](#BKMK_lk_msdyn_requirementstatus_modifiedonbehalfby)
- [lk_msdyn_resourcerequirement_createdby](#BKMK_lk_msdyn_resourcerequirement_createdby)
- [lk_msdyn_resourcerequirement_createdonbehalfby](#BKMK_lk_msdyn_resourcerequirement_createdonbehalfby)
- [lk_msdyn_resourcerequirement_modifiedby](#BKMK_lk_msdyn_resourcerequirement_modifiedby)
- [lk_msdyn_resourcerequirement_modifiedonbehalfby](#BKMK_lk_msdyn_resourcerequirement_modifiedonbehalfby)
- [lk_msdyn_resourcerequirementdetail_createdby](#BKMK_lk_msdyn_resourcerequirementdetail_createdby)
- [lk_msdyn_resourcerequirementdetail_createdonbehalfby](#BKMK_lk_msdyn_resourcerequirementdetail_createdonbehalfby)
- [lk_msdyn_resourcerequirementdetail_modifiedby](#BKMK_lk_msdyn_resourcerequirementdetail_modifiedby)
- [lk_msdyn_resourcerequirementdetail_modifiedonbehalfby](#BKMK_lk_msdyn_resourcerequirementdetail_modifiedonbehalfby)
- [lk_msdyn_resourceterritory_createdby](#BKMK_lk_msdyn_resourceterritory_createdby)
- [lk_msdyn_resourceterritory_createdonbehalfby](#BKMK_lk_msdyn_resourceterritory_createdonbehalfby)
- [lk_msdyn_resourceterritory_modifiedby](#BKMK_lk_msdyn_resourceterritory_modifiedby)
- [lk_msdyn_resourceterritory_modifiedonbehalfby](#BKMK_lk_msdyn_resourceterritory_modifiedonbehalfby)
- [lk_msdyn_scheduleboardsetting_createdby](#BKMK_lk_msdyn_scheduleboardsetting_createdby)
- [lk_msdyn_scheduleboardsetting_createdonbehalfby](#BKMK_lk_msdyn_scheduleboardsetting_createdonbehalfby)
- [lk_msdyn_scheduleboardsetting_modifiedby](#BKMK_lk_msdyn_scheduleboardsetting_modifiedby)
- [lk_msdyn_scheduleboardsetting_modifiedonbehalfby](#BKMK_lk_msdyn_scheduleboardsetting_modifiedonbehalfby)
- [lk_msdyn_schedulingfeatureflag_createdby](#BKMK_lk_msdyn_schedulingfeatureflag_createdby)
- [lk_msdyn_schedulingfeatureflag_createdonbehalfby](#BKMK_lk_msdyn_schedulingfeatureflag_createdonbehalfby)
- [lk_msdyn_schedulingfeatureflag_modifiedby](#BKMK_lk_msdyn_schedulingfeatureflag_modifiedby)
- [lk_msdyn_schedulingfeatureflag_modifiedonbehalfby](#BKMK_lk_msdyn_schedulingfeatureflag_modifiedonbehalfby)
- [lk_msdyn_schedulingparameter_createdby](#BKMK_lk_msdyn_schedulingparameter_createdby)
- [lk_msdyn_schedulingparameter_createdonbehalfby](#BKMK_lk_msdyn_schedulingparameter_createdonbehalfby)
- [lk_msdyn_schedulingparameter_modifiedby](#BKMK_lk_msdyn_schedulingparameter_modifiedby)
- [lk_msdyn_schedulingparameter_modifiedonbehalfby](#BKMK_lk_msdyn_schedulingparameter_modifiedonbehalfby)
- [lk_msdyn_schedulingscope_createdby](#BKMK_lk_msdyn_schedulingscope_createdby)
- [lk_msdyn_schedulingscope_createdonbehalfby](#BKMK_lk_msdyn_schedulingscope_createdonbehalfby)
- [lk_msdyn_schedulingscope_modifiedby](#BKMK_lk_msdyn_schedulingscope_modifiedby)
- [lk_msdyn_schedulingscope_modifiedonbehalfby](#BKMK_lk_msdyn_schedulingscope_modifiedonbehalfby)
- [lk_msdyn_systemuserschedulersetting_createdby](#BKMK_lk_msdyn_systemuserschedulersetting_createdby)
- [lk_msdyn_systemuserschedulersetting_createdonbehalfby](#BKMK_lk_msdyn_systemuserschedulersetting_createdonbehalfby)
- [lk_msdyn_systemuserschedulersetting_modifiedby](#BKMK_lk_msdyn_systemuserschedulersetting_modifiedby)
- [lk_msdyn_systemuserschedulersetting_modifiedonbehalfby](#BKMK_lk_msdyn_systemuserschedulersetting_modifiedonbehalfby)
- [lk_msdyn_timegroup_createdby](#BKMK_lk_msdyn_timegroup_createdby)
- [lk_msdyn_timegroup_createdonbehalfby](#BKMK_lk_msdyn_timegroup_createdonbehalfby)
- [lk_msdyn_timegroup_modifiedby](#BKMK_lk_msdyn_timegroup_modifiedby)
- [lk_msdyn_timegroup_modifiedonbehalfby](#BKMK_lk_msdyn_timegroup_modifiedonbehalfby)
- [lk_msdyn_timegroupdetail_createdby](#BKMK_lk_msdyn_timegroupdetail_createdby)
- [lk_msdyn_timegroupdetail_createdonbehalfby](#BKMK_lk_msdyn_timegroupdetail_createdonbehalfby)
- [lk_msdyn_timegroupdetail_modifiedby](#BKMK_lk_msdyn_timegroupdetail_modifiedby)
- [lk_msdyn_timegroupdetail_modifiedonbehalfby](#BKMK_lk_msdyn_timegroupdetail_modifiedonbehalfby)
- [lk_msdyn_transactionorigin_createdby](#BKMK_lk_msdyn_transactionorigin_createdby)
- [lk_msdyn_transactionorigin_createdonbehalfby](#BKMK_lk_msdyn_transactionorigin_createdonbehalfby)
- [lk_msdyn_transactionorigin_modifiedby](#BKMK_lk_msdyn_transactionorigin_modifiedby)
- [lk_msdyn_transactionorigin_modifiedonbehalfby](#BKMK_lk_msdyn_transactionorigin_modifiedonbehalfby)
- [lk_msdyn_workhourtemplate_createdby](#BKMK_lk_msdyn_workhourtemplate_createdby)
- [lk_msdyn_workhourtemplate_createdonbehalfby](#BKMK_lk_msdyn_workhourtemplate_createdonbehalfby)
- [lk_msdyn_workhourtemplate_modifiedby](#BKMK_lk_msdyn_workhourtemplate_modifiedby)
- [lk_msdyn_workhourtemplate_modifiedonbehalfby](#BKMK_lk_msdyn_workhourtemplate_modifiedonbehalfby)
- [msdyn_bookingalert_systemuser_createdby](#BKMK_msdyn_bookingalert_systemuser_createdby)
- [msdyn_bookingalert_systemuser_createdonbehalfby](#BKMK_msdyn_bookingalert_systemuser_createdonbehalfby)
- [msdyn_bookingalert_systemuser_modifiedby](#BKMK_msdyn_bookingalert_systemuser_modifiedby)
- [msdyn_bookingalert_systemuser_modifiedonbehalfby](#BKMK_msdyn_bookingalert_systemuser_modifiedonbehalfby)
- [msdyn_bookingalert_systemuser_owninguser](#BKMK_msdyn_bookingalert_systemuser_owninguser)
- [msdyn_systemuser_msdyn_systemuserschedulersetting_User](#BKMK_msdyn_systemuser_msdyn_systemuserschedulersetting_User)
- [user_msdyn_actual](#BKMK_user_msdyn_actual)
- [user_msdyn_bookableresourceassociation](#BKMK_user_msdyn_bookableresourceassociation)
- [user_msdyn_bookingalertstatus](#BKMK_user_msdyn_bookingalertstatus)
- [user_msdyn_bookingchange](#BKMK_user_msdyn_bookingchange)
- [user_msdyn_bookingrule](#BKMK_user_msdyn_bookingrule)
- [user_msdyn_bookingsetupmetadata](#BKMK_user_msdyn_bookingsetupmetadata)
- [user_msdyn_businessclosure](#BKMK_user_msdyn_businessclosure)
- [user_msdyn_clientextension](#BKMK_user_msdyn_clientextension)
- [user_msdyn_configuration](#BKMK_user_msdyn_configuration)
- [user_msdyn_optimizationrequest](#BKMK_user_msdyn_optimizationrequest)
- [user_msdyn_priority](#BKMK_user_msdyn_priority)
- [user_msdyn_requirementchange](#BKMK_user_msdyn_requirementchange)
- [user_msdyn_requirementcharacteristic](#BKMK_user_msdyn_requirementcharacteristic)
- [user_msdyn_requirementdependency](#BKMK_user_msdyn_requirementdependency)
- [user_msdyn_requirementgroup](#BKMK_user_msdyn_requirementgroup)
- [user_msdyn_requirementorganizationunit](#BKMK_user_msdyn_requirementorganizationunit)
- [user_msdyn_requirementrelationship](#BKMK_user_msdyn_requirementrelationship)
- [user_msdyn_requirementresourcecategory](#BKMK_user_msdyn_requirementresourcecategory)
- [user_msdyn_requirementresourcepreference](#BKMK_user_msdyn_requirementresourcepreference)
- [user_msdyn_requirementstatus](#BKMK_user_msdyn_requirementstatus)
- [user_msdyn_resourcerequirement](#BKMK_user_msdyn_resourcerequirement)
- [user_msdyn_resourcerequirementdetail](#BKMK_user_msdyn_resourcerequirementdetail)
- [user_msdyn_resourceterritory](#BKMK_user_msdyn_resourceterritory)
- [user_msdyn_scheduleboardsetting](#BKMK_user_msdyn_scheduleboardsetting)
- [user_msdyn_schedulingfeatureflag](#BKMK_user_msdyn_schedulingfeatureflag)
- [user_msdyn_schedulingscope](#BKMK_user_msdyn_schedulingscope)
- [user_msdyn_systemuserschedulersetting](#BKMK_user_msdyn_systemuserschedulersetting)
- [user_msdyn_timegroup](#BKMK_user_msdyn_timegroup)
- [user_msdyn_timegroupdetail](#BKMK_user_msdyn_timegroupdetail)
- [user_msdyn_transactionorigin](#BKMK_user_msdyn_transactionorigin)
- [user_msdyn_workhourtemplate](#BKMK_user_msdyn_workhourtemplate)

### <a name="BKMK_lk_msdyn_actual_createdby"></a> lk_msdyn_actual_createdby

Many-To-One Relationship: [msdyn_actual lk_msdyn_actual_createdby](msdyn_actual.md#BKMK_lk_msdyn_actual_createdby)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_actual`|
|ReferencingAttribute|`createdby`|
|ReferencedEntityNavigationPropertyName|`lk_msdyn_actual_createdby`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_lk_msdyn_actual_createdonbehalfby"></a> lk_msdyn_actual_createdonbehalfby

Many-To-One Relationship: [msdyn_actual lk_msdyn_actual_createdonbehalfby](msdyn_actual.md#BKMK_lk_msdyn_actual_createdonbehalfby)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_actual`|
|ReferencingAttribute|`createdonbehalfby`|
|ReferencedEntityNavigationPropertyName|`lk_msdyn_actual_createdonbehalfby`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_lk_msdyn_actual_modifiedby"></a> lk_msdyn_actual_modifiedby

Many-To-One Relationship: [msdyn_actual lk_msdyn_actual_modifiedby](msdyn_actual.md#BKMK_lk_msdyn_actual_modifiedby)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_actual`|
|ReferencingAttribute|`modifiedby`|
|ReferencedEntityNavigationPropertyName|`lk_msdyn_actual_modifiedby`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_lk_msdyn_actual_modifiedonbehalfby"></a> lk_msdyn_actual_modifiedonbehalfby

Many-To-One Relationship: [msdyn_actual lk_msdyn_actual_modifiedonbehalfby](msdyn_actual.md#BKMK_lk_msdyn_actual_modifiedonbehalfby)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_actual`|
|ReferencingAttribute|`modifiedonbehalfby`|
|ReferencedEntityNavigationPropertyName|`lk_msdyn_actual_modifiedonbehalfby`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_lk_msdyn_bookableresourceassociation_createdby"></a> lk_msdyn_bookableresourceassociation_createdby

Many-To-One Relationship: [msdyn_bookableresourceassociation lk_msdyn_bookableresourceassociation_createdby](msdyn_bookableresourceassociation.md#BKMK_lk_msdyn_bookableresourceassociation_createdby)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_bookableresourceassociation`|
|ReferencingAttribute|`createdby`|
|ReferencedEntityNavigationPropertyName|`lk_msdyn_bookableresourceassociation_createdby`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_lk_msdyn_bookableresourceassociation_createdonbehalfby"></a> lk_msdyn_bookableresourceassociation_createdonbehalfby

Many-To-One Relationship: [msdyn_bookableresourceassociation lk_msdyn_bookableresourceassociation_createdonbehalfby](msdyn_bookableresourceassociation.md#BKMK_lk_msdyn_bookableresourceassociation_createdonbehalfby)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_bookableresourceassociation`|
|ReferencingAttribute|`createdonbehalfby`|
|ReferencedEntityNavigationPropertyName|`lk_msdyn_bookableresourceassociation_createdonbehalfby`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_lk_msdyn_bookableresourceassociation_modifiedby"></a> lk_msdyn_bookableresourceassociation_modifiedby

Many-To-One Relationship: [msdyn_bookableresourceassociation lk_msdyn_bookableresourceassociation_modifiedby](msdyn_bookableresourceassociation.md#BKMK_lk_msdyn_bookableresourceassociation_modifiedby)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_bookableresourceassociation`|
|ReferencingAttribute|`modifiedby`|
|ReferencedEntityNavigationPropertyName|`lk_msdyn_bookableresourceassociation_modifiedby`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_lk_msdyn_bookableresourceassociation_modifiedonbehalfby"></a> lk_msdyn_bookableresourceassociation_modifiedonbehalfby

Many-To-One Relationship: [msdyn_bookableresourceassociation lk_msdyn_bookableresourceassociation_modifiedonbehalfby](msdyn_bookableresourceassociation.md#BKMK_lk_msdyn_bookableresourceassociation_modifiedonbehalfby)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_bookableresourceassociation`|
|ReferencingAttribute|`modifiedonbehalfby`|
|ReferencedEntityNavigationPropertyName|`lk_msdyn_bookableresourceassociation_modifiedonbehalfby`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_lk_msdyn_bookingalertstatus_createdby"></a> lk_msdyn_bookingalertstatus_createdby

Many-To-One Relationship: [msdyn_bookingalertstatus lk_msdyn_bookingalertstatus_createdby](msdyn_bookingalertstatus.md#BKMK_lk_msdyn_bookingalertstatus_createdby)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_bookingalertstatus`|
|ReferencingAttribute|`createdby`|
|ReferencedEntityNavigationPropertyName|`lk_msdyn_bookingalertstatus_createdby`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_lk_msdyn_bookingalertstatus_createdonbehalfby"></a> lk_msdyn_bookingalertstatus_createdonbehalfby

Many-To-One Relationship: [msdyn_bookingalertstatus lk_msdyn_bookingalertstatus_createdonbehalfby](msdyn_bookingalertstatus.md#BKMK_lk_msdyn_bookingalertstatus_createdonbehalfby)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_bookingalertstatus`|
|ReferencingAttribute|`createdonbehalfby`|
|ReferencedEntityNavigationPropertyName|`lk_msdyn_bookingalertstatus_createdonbehalfby`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_lk_msdyn_bookingalertstatus_modifiedby"></a> lk_msdyn_bookingalertstatus_modifiedby

Many-To-One Relationship: [msdyn_bookingalertstatus lk_msdyn_bookingalertstatus_modifiedby](msdyn_bookingalertstatus.md#BKMK_lk_msdyn_bookingalertstatus_modifiedby)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_bookingalertstatus`|
|ReferencingAttribute|`modifiedby`|
|ReferencedEntityNavigationPropertyName|`lk_msdyn_bookingalertstatus_modifiedby`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_lk_msdyn_bookingalertstatus_modifiedonbehalfby"></a> lk_msdyn_bookingalertstatus_modifiedonbehalfby

Many-To-One Relationship: [msdyn_bookingalertstatus lk_msdyn_bookingalertstatus_modifiedonbehalfby](msdyn_bookingalertstatus.md#BKMK_lk_msdyn_bookingalertstatus_modifiedonbehalfby)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_bookingalertstatus`|
|ReferencingAttribute|`modifiedonbehalfby`|
|ReferencedEntityNavigationPropertyName|`lk_msdyn_bookingalertstatus_modifiedonbehalfby`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_lk_msdyn_bookingchange_createdby"></a> lk_msdyn_bookingchange_createdby

Many-To-One Relationship: [msdyn_bookingchange lk_msdyn_bookingchange_createdby](msdyn_bookingchange.md#BKMK_lk_msdyn_bookingchange_createdby)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_bookingchange`|
|ReferencingAttribute|`createdby`|
|ReferencedEntityNavigationPropertyName|`lk_msdyn_bookingchange_createdby`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_lk_msdyn_bookingchange_createdonbehalfby"></a> lk_msdyn_bookingchange_createdonbehalfby

Many-To-One Relationship: [msdyn_bookingchange lk_msdyn_bookingchange_createdonbehalfby](msdyn_bookingchange.md#BKMK_lk_msdyn_bookingchange_createdonbehalfby)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_bookingchange`|
|ReferencingAttribute|`createdonbehalfby`|
|ReferencedEntityNavigationPropertyName|`lk_msdyn_bookingchange_createdonbehalfby`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_lk_msdyn_bookingchange_modifiedby"></a> lk_msdyn_bookingchange_modifiedby

Many-To-One Relationship: [msdyn_bookingchange lk_msdyn_bookingchange_modifiedby](msdyn_bookingchange.md#BKMK_lk_msdyn_bookingchange_modifiedby)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_bookingchange`|
|ReferencingAttribute|`modifiedby`|
|ReferencedEntityNavigationPropertyName|`lk_msdyn_bookingchange_modifiedby`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_lk_msdyn_bookingchange_modifiedonbehalfby"></a> lk_msdyn_bookingchange_modifiedonbehalfby

Many-To-One Relationship: [msdyn_bookingchange lk_msdyn_bookingchange_modifiedonbehalfby](msdyn_bookingchange.md#BKMK_lk_msdyn_bookingchange_modifiedonbehalfby)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_bookingchange`|
|ReferencingAttribute|`modifiedonbehalfby`|
|ReferencedEntityNavigationPropertyName|`lk_msdyn_bookingchange_modifiedonbehalfby`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_lk_msdyn_bookingrule_createdby"></a> lk_msdyn_bookingrule_createdby

Many-To-One Relationship: [msdyn_bookingrule lk_msdyn_bookingrule_createdby](msdyn_bookingrule.md#BKMK_lk_msdyn_bookingrule_createdby)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_bookingrule`|
|ReferencingAttribute|`createdby`|
|ReferencedEntityNavigationPropertyName|`lk_msdyn_bookingrule_createdby`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_lk_msdyn_bookingrule_createdonbehalfby"></a> lk_msdyn_bookingrule_createdonbehalfby

Many-To-One Relationship: [msdyn_bookingrule lk_msdyn_bookingrule_createdonbehalfby](msdyn_bookingrule.md#BKMK_lk_msdyn_bookingrule_createdonbehalfby)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_bookingrule`|
|ReferencingAttribute|`createdonbehalfby`|
|ReferencedEntityNavigationPropertyName|`lk_msdyn_bookingrule_createdonbehalfby`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_lk_msdyn_bookingrule_modifiedby"></a> lk_msdyn_bookingrule_modifiedby

Many-To-One Relationship: [msdyn_bookingrule lk_msdyn_bookingrule_modifiedby](msdyn_bookingrule.md#BKMK_lk_msdyn_bookingrule_modifiedby)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_bookingrule`|
|ReferencingAttribute|`modifiedby`|
|ReferencedEntityNavigationPropertyName|`lk_msdyn_bookingrule_modifiedby`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_lk_msdyn_bookingrule_modifiedonbehalfby"></a> lk_msdyn_bookingrule_modifiedonbehalfby

Many-To-One Relationship: [msdyn_bookingrule lk_msdyn_bookingrule_modifiedonbehalfby](msdyn_bookingrule.md#BKMK_lk_msdyn_bookingrule_modifiedonbehalfby)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_bookingrule`|
|ReferencingAttribute|`modifiedonbehalfby`|
|ReferencedEntityNavigationPropertyName|`lk_msdyn_bookingrule_modifiedonbehalfby`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_lk_msdyn_bookingsetupmetadata_createdby"></a> lk_msdyn_bookingsetupmetadata_createdby

Many-To-One Relationship: [msdyn_bookingsetupmetadata lk_msdyn_bookingsetupmetadata_createdby](msdyn_bookingsetupmetadata.md#BKMK_lk_msdyn_bookingsetupmetadata_createdby)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_bookingsetupmetadata`|
|ReferencingAttribute|`createdby`|
|ReferencedEntityNavigationPropertyName|`lk_msdyn_bookingsetupmetadata_createdby`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_lk_msdyn_bookingsetupmetadata_createdonbehalfby"></a> lk_msdyn_bookingsetupmetadata_createdonbehalfby

Many-To-One Relationship: [msdyn_bookingsetupmetadata lk_msdyn_bookingsetupmetadata_createdonbehalfby](msdyn_bookingsetupmetadata.md#BKMK_lk_msdyn_bookingsetupmetadata_createdonbehalfby)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_bookingsetupmetadata`|
|ReferencingAttribute|`createdonbehalfby`|
|ReferencedEntityNavigationPropertyName|`lk_msdyn_bookingsetupmetadata_createdonbehalfby`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_lk_msdyn_bookingsetupmetadata_modifiedby"></a> lk_msdyn_bookingsetupmetadata_modifiedby

Many-To-One Relationship: [msdyn_bookingsetupmetadata lk_msdyn_bookingsetupmetadata_modifiedby](msdyn_bookingsetupmetadata.md#BKMK_lk_msdyn_bookingsetupmetadata_modifiedby)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_bookingsetupmetadata`|
|ReferencingAttribute|`modifiedby`|
|ReferencedEntityNavigationPropertyName|`lk_msdyn_bookingsetupmetadata_modifiedby`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_lk_msdyn_bookingsetupmetadata_modifiedonbehalfby"></a> lk_msdyn_bookingsetupmetadata_modifiedonbehalfby

Many-To-One Relationship: [msdyn_bookingsetupmetadata lk_msdyn_bookingsetupmetadata_modifiedonbehalfby](msdyn_bookingsetupmetadata.md#BKMK_lk_msdyn_bookingsetupmetadata_modifiedonbehalfby)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_bookingsetupmetadata`|
|ReferencingAttribute|`modifiedonbehalfby`|
|ReferencedEntityNavigationPropertyName|`lk_msdyn_bookingsetupmetadata_modifiedonbehalfby`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_lk_msdyn_businessclosure_createdby"></a> lk_msdyn_businessclosure_createdby

Many-To-One Relationship: [msdyn_businessclosure lk_msdyn_businessclosure_createdby](msdyn_businessclosure.md#BKMK_lk_msdyn_businessclosure_createdby)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_businessclosure`|
|ReferencingAttribute|`createdby`|
|ReferencedEntityNavigationPropertyName|`lk_msdyn_businessclosure_createdby`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_lk_msdyn_businessclosure_createdonbehalfby"></a> lk_msdyn_businessclosure_createdonbehalfby

Many-To-One Relationship: [msdyn_businessclosure lk_msdyn_businessclosure_createdonbehalfby](msdyn_businessclosure.md#BKMK_lk_msdyn_businessclosure_createdonbehalfby)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_businessclosure`|
|ReferencingAttribute|`createdonbehalfby`|
|ReferencedEntityNavigationPropertyName|`lk_msdyn_businessclosure_createdonbehalfby`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_lk_msdyn_businessclosure_modifiedby"></a> lk_msdyn_businessclosure_modifiedby

Many-To-One Relationship: [msdyn_businessclosure lk_msdyn_businessclosure_modifiedby](msdyn_businessclosure.md#BKMK_lk_msdyn_businessclosure_modifiedby)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_businessclosure`|
|ReferencingAttribute|`modifiedby`|
|ReferencedEntityNavigationPropertyName|`lk_msdyn_businessclosure_modifiedby`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_lk_msdyn_businessclosure_modifiedonbehalfby"></a> lk_msdyn_businessclosure_modifiedonbehalfby

Many-To-One Relationship: [msdyn_businessclosure lk_msdyn_businessclosure_modifiedonbehalfby](msdyn_businessclosure.md#BKMK_lk_msdyn_businessclosure_modifiedonbehalfby)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_businessclosure`|
|ReferencingAttribute|`modifiedonbehalfby`|
|ReferencedEntityNavigationPropertyName|`lk_msdyn_businessclosure_modifiedonbehalfby`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_lk_msdyn_clientextension_createdby"></a> lk_msdyn_clientextension_createdby

Many-To-One Relationship: [msdyn_clientextension lk_msdyn_clientextension_createdby](msdyn_clientextension.md#BKMK_lk_msdyn_clientextension_createdby)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_clientextension`|
|ReferencingAttribute|`createdby`|
|ReferencedEntityNavigationPropertyName|`lk_msdyn_clientextension_createdby`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_lk_msdyn_clientextension_createdonbehalfby"></a> lk_msdyn_clientextension_createdonbehalfby

Many-To-One Relationship: [msdyn_clientextension lk_msdyn_clientextension_createdonbehalfby](msdyn_clientextension.md#BKMK_lk_msdyn_clientextension_createdonbehalfby)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_clientextension`|
|ReferencingAttribute|`createdonbehalfby`|
|ReferencedEntityNavigationPropertyName|`lk_msdyn_clientextension_createdonbehalfby`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_lk_msdyn_clientextension_modifiedby"></a> lk_msdyn_clientextension_modifiedby

Many-To-One Relationship: [msdyn_clientextension lk_msdyn_clientextension_modifiedby](msdyn_clientextension.md#BKMK_lk_msdyn_clientextension_modifiedby)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_clientextension`|
|ReferencingAttribute|`modifiedby`|
|ReferencedEntityNavigationPropertyName|`lk_msdyn_clientextension_modifiedby`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_lk_msdyn_clientextension_modifiedonbehalfby"></a> lk_msdyn_clientextension_modifiedonbehalfby

Many-To-One Relationship: [msdyn_clientextension lk_msdyn_clientextension_modifiedonbehalfby](msdyn_clientextension.md#BKMK_lk_msdyn_clientextension_modifiedonbehalfby)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_clientextension`|
|ReferencingAttribute|`modifiedonbehalfby`|
|ReferencedEntityNavigationPropertyName|`lk_msdyn_clientextension_modifiedonbehalfby`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_lk_msdyn_configuration_createdby"></a> lk_msdyn_configuration_createdby

Many-To-One Relationship: [msdyn_configuration lk_msdyn_configuration_createdby](msdyn_configuration.md#BKMK_lk_msdyn_configuration_createdby)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_configuration`|
|ReferencingAttribute|`createdby`|
|ReferencedEntityNavigationPropertyName|`lk_msdyn_configuration_createdby`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_lk_msdyn_configuration_createdonbehalfby"></a> lk_msdyn_configuration_createdonbehalfby

Many-To-One Relationship: [msdyn_configuration lk_msdyn_configuration_createdonbehalfby](msdyn_configuration.md#BKMK_lk_msdyn_configuration_createdonbehalfby)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_configuration`|
|ReferencingAttribute|`createdonbehalfby`|
|ReferencedEntityNavigationPropertyName|`lk_msdyn_configuration_createdonbehalfby`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_lk_msdyn_configuration_modifiedby"></a> lk_msdyn_configuration_modifiedby

Many-To-One Relationship: [msdyn_configuration lk_msdyn_configuration_modifiedby](msdyn_configuration.md#BKMK_lk_msdyn_configuration_modifiedby)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_configuration`|
|ReferencingAttribute|`modifiedby`|
|ReferencedEntityNavigationPropertyName|`lk_msdyn_configuration_modifiedby`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_lk_msdyn_configuration_modifiedonbehalfby"></a> lk_msdyn_configuration_modifiedonbehalfby

Many-To-One Relationship: [msdyn_configuration lk_msdyn_configuration_modifiedonbehalfby](msdyn_configuration.md#BKMK_lk_msdyn_configuration_modifiedonbehalfby)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_configuration`|
|ReferencingAttribute|`modifiedonbehalfby`|
|ReferencedEntityNavigationPropertyName|`lk_msdyn_configuration_modifiedonbehalfby`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_lk_msdyn_optimizationrequest_createdby"></a> lk_msdyn_optimizationrequest_createdby

Many-To-One Relationship: [msdyn_optimizationrequest lk_msdyn_optimizationrequest_createdby](msdyn_optimizationrequest.md#BKMK_lk_msdyn_optimizationrequest_createdby)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_optimizationrequest`|
|ReferencingAttribute|`createdby`|
|ReferencedEntityNavigationPropertyName|`lk_msdyn_optimizationrequest_createdby`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_lk_msdyn_optimizationrequest_createdonbehalfby"></a> lk_msdyn_optimizationrequest_createdonbehalfby

Many-To-One Relationship: [msdyn_optimizationrequest lk_msdyn_optimizationrequest_createdonbehalfby](msdyn_optimizationrequest.md#BKMK_lk_msdyn_optimizationrequest_createdonbehalfby)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_optimizationrequest`|
|ReferencingAttribute|`createdonbehalfby`|
|ReferencedEntityNavigationPropertyName|`lk_msdyn_optimizationrequest_createdonbehalfby`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_lk_msdyn_optimizationrequest_modifiedby"></a> lk_msdyn_optimizationrequest_modifiedby

Many-To-One Relationship: [msdyn_optimizationrequest lk_msdyn_optimizationrequest_modifiedby](msdyn_optimizationrequest.md#BKMK_lk_msdyn_optimizationrequest_modifiedby)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_optimizationrequest`|
|ReferencingAttribute|`modifiedby`|
|ReferencedEntityNavigationPropertyName|`lk_msdyn_optimizationrequest_modifiedby`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_lk_msdyn_optimizationrequest_modifiedonbehalfby"></a> lk_msdyn_optimizationrequest_modifiedonbehalfby

Many-To-One Relationship: [msdyn_optimizationrequest lk_msdyn_optimizationrequest_modifiedonbehalfby](msdyn_optimizationrequest.md#BKMK_lk_msdyn_optimizationrequest_modifiedonbehalfby)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_optimizationrequest`|
|ReferencingAttribute|`modifiedonbehalfby`|
|ReferencedEntityNavigationPropertyName|`lk_msdyn_optimizationrequest_modifiedonbehalfby`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_lk_msdyn_organizationalunit_createdby"></a> lk_msdyn_organizationalunit_createdby

Many-To-One Relationship: [msdyn_organizationalunit lk_msdyn_organizationalunit_createdby](msdyn_organizationalunit.md#BKMK_lk_msdyn_organizationalunit_createdby)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_organizationalunit`|
|ReferencingAttribute|`createdby`|
|ReferencedEntityNavigationPropertyName|`lk_msdyn_organizationalunit_createdby`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_lk_msdyn_organizationalunit_createdonbehalfby"></a> lk_msdyn_organizationalunit_createdonbehalfby

Many-To-One Relationship: [msdyn_organizationalunit lk_msdyn_organizationalunit_createdonbehalfby](msdyn_organizationalunit.md#BKMK_lk_msdyn_organizationalunit_createdonbehalfby)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_organizationalunit`|
|ReferencingAttribute|`createdonbehalfby`|
|ReferencedEntityNavigationPropertyName|`lk_msdyn_organizationalunit_createdonbehalfby`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_lk_msdyn_organizationalunit_modifiedby"></a> lk_msdyn_organizationalunit_modifiedby

Many-To-One Relationship: [msdyn_organizationalunit lk_msdyn_organizationalunit_modifiedby](msdyn_organizationalunit.md#BKMK_lk_msdyn_organizationalunit_modifiedby)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_organizationalunit`|
|ReferencingAttribute|`modifiedby`|
|ReferencedEntityNavigationPropertyName|`lk_msdyn_organizationalunit_modifiedby`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_lk_msdyn_organizationalunit_modifiedonbehalfby"></a> lk_msdyn_organizationalunit_modifiedonbehalfby

Many-To-One Relationship: [msdyn_organizationalunit lk_msdyn_organizationalunit_modifiedonbehalfby](msdyn_organizationalunit.md#BKMK_lk_msdyn_organizationalunit_modifiedonbehalfby)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_organizationalunit`|
|ReferencingAttribute|`modifiedonbehalfby`|
|ReferencedEntityNavigationPropertyName|`lk_msdyn_organizationalunit_modifiedonbehalfby`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_lk_msdyn_priority_createdby"></a> lk_msdyn_priority_createdby

Many-To-One Relationship: [msdyn_priority lk_msdyn_priority_createdby](msdyn_priority.md#BKMK_lk_msdyn_priority_createdby)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_priority`|
|ReferencingAttribute|`createdby`|
|ReferencedEntityNavigationPropertyName|`lk_msdyn_priority_createdby`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_lk_msdyn_priority_createdonbehalfby"></a> lk_msdyn_priority_createdonbehalfby

Many-To-One Relationship: [msdyn_priority lk_msdyn_priority_createdonbehalfby](msdyn_priority.md#BKMK_lk_msdyn_priority_createdonbehalfby)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_priority`|
|ReferencingAttribute|`createdonbehalfby`|
|ReferencedEntityNavigationPropertyName|`lk_msdyn_priority_createdonbehalfby`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_lk_msdyn_priority_modifiedby"></a> lk_msdyn_priority_modifiedby

Many-To-One Relationship: [msdyn_priority lk_msdyn_priority_modifiedby](msdyn_priority.md#BKMK_lk_msdyn_priority_modifiedby)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_priority`|
|ReferencingAttribute|`modifiedby`|
|ReferencedEntityNavigationPropertyName|`lk_msdyn_priority_modifiedby`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_lk_msdyn_priority_modifiedonbehalfby"></a> lk_msdyn_priority_modifiedonbehalfby

Many-To-One Relationship: [msdyn_priority lk_msdyn_priority_modifiedonbehalfby](msdyn_priority.md#BKMK_lk_msdyn_priority_modifiedonbehalfby)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_priority`|
|ReferencingAttribute|`modifiedonbehalfby`|
|ReferencedEntityNavigationPropertyName|`lk_msdyn_priority_modifiedonbehalfby`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_lk_msdyn_requirementchange_createdby"></a> lk_msdyn_requirementchange_createdby

Many-To-One Relationship: [msdyn_requirementchange lk_msdyn_requirementchange_createdby](msdyn_requirementchange.md#BKMK_lk_msdyn_requirementchange_createdby)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_requirementchange`|
|ReferencingAttribute|`createdby`|
|ReferencedEntityNavigationPropertyName|`lk_msdyn_requirementchange_createdby`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_lk_msdyn_requirementchange_createdonbehalfby"></a> lk_msdyn_requirementchange_createdonbehalfby

Many-To-One Relationship: [msdyn_requirementchange lk_msdyn_requirementchange_createdonbehalfby](msdyn_requirementchange.md#BKMK_lk_msdyn_requirementchange_createdonbehalfby)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_requirementchange`|
|ReferencingAttribute|`createdonbehalfby`|
|ReferencedEntityNavigationPropertyName|`lk_msdyn_requirementchange_createdonbehalfby`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_lk_msdyn_requirementchange_modifiedby"></a> lk_msdyn_requirementchange_modifiedby

Many-To-One Relationship: [msdyn_requirementchange lk_msdyn_requirementchange_modifiedby](msdyn_requirementchange.md#BKMK_lk_msdyn_requirementchange_modifiedby)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_requirementchange`|
|ReferencingAttribute|`modifiedby`|
|ReferencedEntityNavigationPropertyName|`lk_msdyn_requirementchange_modifiedby`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_lk_msdyn_requirementchange_modifiedonbehalfby"></a> lk_msdyn_requirementchange_modifiedonbehalfby

Many-To-One Relationship: [msdyn_requirementchange lk_msdyn_requirementchange_modifiedonbehalfby](msdyn_requirementchange.md#BKMK_lk_msdyn_requirementchange_modifiedonbehalfby)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_requirementchange`|
|ReferencingAttribute|`modifiedonbehalfby`|
|ReferencedEntityNavigationPropertyName|`lk_msdyn_requirementchange_modifiedonbehalfby`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_lk_msdyn_requirementcharacteristic_createdby"></a> lk_msdyn_requirementcharacteristic_createdby

Many-To-One Relationship: [msdyn_requirementcharacteristic lk_msdyn_requirementcharacteristic_createdby](msdyn_requirementcharacteristic.md#BKMK_lk_msdyn_requirementcharacteristic_createdby)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_requirementcharacteristic`|
|ReferencingAttribute|`createdby`|
|ReferencedEntityNavigationPropertyName|`lk_msdyn_requirementcharacteristic_createdby`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_lk_msdyn_requirementcharacteristic_createdonbehalfby"></a> lk_msdyn_requirementcharacteristic_createdonbehalfby

Many-To-One Relationship: [msdyn_requirementcharacteristic lk_msdyn_requirementcharacteristic_createdonbehalfby](msdyn_requirementcharacteristic.md#BKMK_lk_msdyn_requirementcharacteristic_createdonbehalfby)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_requirementcharacteristic`|
|ReferencingAttribute|`createdonbehalfby`|
|ReferencedEntityNavigationPropertyName|`lk_msdyn_requirementcharacteristic_createdonbehalfby`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_lk_msdyn_requirementcharacteristic_modifiedby"></a> lk_msdyn_requirementcharacteristic_modifiedby

Many-To-One Relationship: [msdyn_requirementcharacteristic lk_msdyn_requirementcharacteristic_modifiedby](msdyn_requirementcharacteristic.md#BKMK_lk_msdyn_requirementcharacteristic_modifiedby)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_requirementcharacteristic`|
|ReferencingAttribute|`modifiedby`|
|ReferencedEntityNavigationPropertyName|`lk_msdyn_requirementcharacteristic_modifiedby`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_lk_msdyn_requirementcharacteristic_modifiedonbehalfby"></a> lk_msdyn_requirementcharacteristic_modifiedonbehalfby

Many-To-One Relationship: [msdyn_requirementcharacteristic lk_msdyn_requirementcharacteristic_modifiedonbehalfby](msdyn_requirementcharacteristic.md#BKMK_lk_msdyn_requirementcharacteristic_modifiedonbehalfby)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_requirementcharacteristic`|
|ReferencingAttribute|`modifiedonbehalfby`|
|ReferencedEntityNavigationPropertyName|`lk_msdyn_requirementcharacteristic_modifiedonbehalfby`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_lk_msdyn_requirementdependency_createdby"></a> lk_msdyn_requirementdependency_createdby

Many-To-One Relationship: [msdyn_requirementdependency lk_msdyn_requirementdependency_createdby](msdyn_requirementdependency.md#BKMK_lk_msdyn_requirementdependency_createdby)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_requirementdependency`|
|ReferencingAttribute|`createdby`|
|ReferencedEntityNavigationPropertyName|`lk_msdyn_requirementdependency_createdby`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_lk_msdyn_requirementdependency_createdonbehalfby"></a> lk_msdyn_requirementdependency_createdonbehalfby

Many-To-One Relationship: [msdyn_requirementdependency lk_msdyn_requirementdependency_createdonbehalfby](msdyn_requirementdependency.md#BKMK_lk_msdyn_requirementdependency_createdonbehalfby)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_requirementdependency`|
|ReferencingAttribute|`createdonbehalfby`|
|ReferencedEntityNavigationPropertyName|`lk_msdyn_requirementdependency_createdonbehalfby`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_lk_msdyn_requirementdependency_modifiedby"></a> lk_msdyn_requirementdependency_modifiedby

Many-To-One Relationship: [msdyn_requirementdependency lk_msdyn_requirementdependency_modifiedby](msdyn_requirementdependency.md#BKMK_lk_msdyn_requirementdependency_modifiedby)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_requirementdependency`|
|ReferencingAttribute|`modifiedby`|
|ReferencedEntityNavigationPropertyName|`lk_msdyn_requirementdependency_modifiedby`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_lk_msdyn_requirementdependency_modifiedonbehalfby"></a> lk_msdyn_requirementdependency_modifiedonbehalfby

Many-To-One Relationship: [msdyn_requirementdependency lk_msdyn_requirementdependency_modifiedonbehalfby](msdyn_requirementdependency.md#BKMK_lk_msdyn_requirementdependency_modifiedonbehalfby)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_requirementdependency`|
|ReferencingAttribute|`modifiedonbehalfby`|
|ReferencedEntityNavigationPropertyName|`lk_msdyn_requirementdependency_modifiedonbehalfby`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_lk_msdyn_requirementgroup_createdby"></a> lk_msdyn_requirementgroup_createdby

Many-To-One Relationship: [msdyn_requirementgroup lk_msdyn_requirementgroup_createdby](msdyn_requirementgroup.md#BKMK_lk_msdyn_requirementgroup_createdby)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_requirementgroup`|
|ReferencingAttribute|`createdby`|
|ReferencedEntityNavigationPropertyName|`lk_msdyn_requirementgroup_createdby`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_lk_msdyn_requirementgroup_createdonbehalfby"></a> lk_msdyn_requirementgroup_createdonbehalfby

Many-To-One Relationship: [msdyn_requirementgroup lk_msdyn_requirementgroup_createdonbehalfby](msdyn_requirementgroup.md#BKMK_lk_msdyn_requirementgroup_createdonbehalfby)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_requirementgroup`|
|ReferencingAttribute|`createdonbehalfby`|
|ReferencedEntityNavigationPropertyName|`lk_msdyn_requirementgroup_createdonbehalfby`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_lk_msdyn_requirementgroup_modifiedby"></a> lk_msdyn_requirementgroup_modifiedby

Many-To-One Relationship: [msdyn_requirementgroup lk_msdyn_requirementgroup_modifiedby](msdyn_requirementgroup.md#BKMK_lk_msdyn_requirementgroup_modifiedby)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_requirementgroup`|
|ReferencingAttribute|`modifiedby`|
|ReferencedEntityNavigationPropertyName|`lk_msdyn_requirementgroup_modifiedby`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_lk_msdyn_requirementgroup_modifiedonbehalfby"></a> lk_msdyn_requirementgroup_modifiedonbehalfby

Many-To-One Relationship: [msdyn_requirementgroup lk_msdyn_requirementgroup_modifiedonbehalfby](msdyn_requirementgroup.md#BKMK_lk_msdyn_requirementgroup_modifiedonbehalfby)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_requirementgroup`|
|ReferencingAttribute|`modifiedonbehalfby`|
|ReferencedEntityNavigationPropertyName|`lk_msdyn_requirementgroup_modifiedonbehalfby`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_lk_msdyn_requirementorganizationunit_createdby"></a> lk_msdyn_requirementorganizationunit_createdby

Many-To-One Relationship: [msdyn_requirementorganizationunit lk_msdyn_requirementorganizationunit_createdby](msdyn_requirementorganizationunit.md#BKMK_lk_msdyn_requirementorganizationunit_createdby)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_requirementorganizationunit`|
|ReferencingAttribute|`createdby`|
|ReferencedEntityNavigationPropertyName|`lk_msdyn_requirementorganizationunit_createdby`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_lk_msdyn_requirementorganizationunit_createdonbehalfby"></a> lk_msdyn_requirementorganizationunit_createdonbehalfby

Many-To-One Relationship: [msdyn_requirementorganizationunit lk_msdyn_requirementorganizationunit_createdonbehalfby](msdyn_requirementorganizationunit.md#BKMK_lk_msdyn_requirementorganizationunit_createdonbehalfby)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_requirementorganizationunit`|
|ReferencingAttribute|`createdonbehalfby`|
|ReferencedEntityNavigationPropertyName|`lk_msdyn_requirementorganizationunit_createdonbehalfby`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_lk_msdyn_requirementorganizationunit_modifiedby"></a> lk_msdyn_requirementorganizationunit_modifiedby

Many-To-One Relationship: [msdyn_requirementorganizationunit lk_msdyn_requirementorganizationunit_modifiedby](msdyn_requirementorganizationunit.md#BKMK_lk_msdyn_requirementorganizationunit_modifiedby)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_requirementorganizationunit`|
|ReferencingAttribute|`modifiedby`|
|ReferencedEntityNavigationPropertyName|`lk_msdyn_requirementorganizationunit_modifiedby`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_lk_msdyn_requirementorganizationunit_modifiedonbehalfby"></a> lk_msdyn_requirementorganizationunit_modifiedonbehalfby

Many-To-One Relationship: [msdyn_requirementorganizationunit lk_msdyn_requirementorganizationunit_modifiedonbehalfby](msdyn_requirementorganizationunit.md#BKMK_lk_msdyn_requirementorganizationunit_modifiedonbehalfby)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_requirementorganizationunit`|
|ReferencingAttribute|`modifiedonbehalfby`|
|ReferencedEntityNavigationPropertyName|`lk_msdyn_requirementorganizationunit_modifiedonbehalfby`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_lk_msdyn_requirementrelationship_createdby"></a> lk_msdyn_requirementrelationship_createdby

Many-To-One Relationship: [msdyn_requirementrelationship lk_msdyn_requirementrelationship_createdby](msdyn_requirementrelationship.md#BKMK_lk_msdyn_requirementrelationship_createdby)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_requirementrelationship`|
|ReferencingAttribute|`createdby`|
|ReferencedEntityNavigationPropertyName|`lk_msdyn_requirementrelationship_createdby`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_lk_msdyn_requirementrelationship_createdonbehalfby"></a> lk_msdyn_requirementrelationship_createdonbehalfby

Many-To-One Relationship: [msdyn_requirementrelationship lk_msdyn_requirementrelationship_createdonbehalfby](msdyn_requirementrelationship.md#BKMK_lk_msdyn_requirementrelationship_createdonbehalfby)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_requirementrelationship`|
|ReferencingAttribute|`createdonbehalfby`|
|ReferencedEntityNavigationPropertyName|`lk_msdyn_requirementrelationship_createdonbehalfby`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_lk_msdyn_requirementrelationship_modifiedby"></a> lk_msdyn_requirementrelationship_modifiedby

Many-To-One Relationship: [msdyn_requirementrelationship lk_msdyn_requirementrelationship_modifiedby](msdyn_requirementrelationship.md#BKMK_lk_msdyn_requirementrelationship_modifiedby)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_requirementrelationship`|
|ReferencingAttribute|`modifiedby`|
|ReferencedEntityNavigationPropertyName|`lk_msdyn_requirementrelationship_modifiedby`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_lk_msdyn_requirementrelationship_modifiedonbehalfby"></a> lk_msdyn_requirementrelationship_modifiedonbehalfby

Many-To-One Relationship: [msdyn_requirementrelationship lk_msdyn_requirementrelationship_modifiedonbehalfby](msdyn_requirementrelationship.md#BKMK_lk_msdyn_requirementrelationship_modifiedonbehalfby)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_requirementrelationship`|
|ReferencingAttribute|`modifiedonbehalfby`|
|ReferencedEntityNavigationPropertyName|`lk_msdyn_requirementrelationship_modifiedonbehalfby`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_lk_msdyn_requirementresourcecategory_createdby"></a> lk_msdyn_requirementresourcecategory_createdby

Many-To-One Relationship: [msdyn_requirementresourcecategory lk_msdyn_requirementresourcecategory_createdby](msdyn_requirementresourcecategory.md#BKMK_lk_msdyn_requirementresourcecategory_createdby)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_requirementresourcecategory`|
|ReferencingAttribute|`createdby`|
|ReferencedEntityNavigationPropertyName|`lk_msdyn_requirementresourcecategory_createdby`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_lk_msdyn_requirementresourcecategory_createdonbehalfby"></a> lk_msdyn_requirementresourcecategory_createdonbehalfby

Many-To-One Relationship: [msdyn_requirementresourcecategory lk_msdyn_requirementresourcecategory_createdonbehalfby](msdyn_requirementresourcecategory.md#BKMK_lk_msdyn_requirementresourcecategory_createdonbehalfby)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_requirementresourcecategory`|
|ReferencingAttribute|`createdonbehalfby`|
|ReferencedEntityNavigationPropertyName|`lk_msdyn_requirementresourcecategory_createdonbehalfby`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_lk_msdyn_requirementresourcecategory_modifiedby"></a> lk_msdyn_requirementresourcecategory_modifiedby

Many-To-One Relationship: [msdyn_requirementresourcecategory lk_msdyn_requirementresourcecategory_modifiedby](msdyn_requirementresourcecategory.md#BKMK_lk_msdyn_requirementresourcecategory_modifiedby)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_requirementresourcecategory`|
|ReferencingAttribute|`modifiedby`|
|ReferencedEntityNavigationPropertyName|`lk_msdyn_requirementresourcecategory_modifiedby`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_lk_msdyn_requirementresourcecategory_modifiedonbehalfby"></a> lk_msdyn_requirementresourcecategory_modifiedonbehalfby

Many-To-One Relationship: [msdyn_requirementresourcecategory lk_msdyn_requirementresourcecategory_modifiedonbehalfby](msdyn_requirementresourcecategory.md#BKMK_lk_msdyn_requirementresourcecategory_modifiedonbehalfby)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_requirementresourcecategory`|
|ReferencingAttribute|`modifiedonbehalfby`|
|ReferencedEntityNavigationPropertyName|`lk_msdyn_requirementresourcecategory_modifiedonbehalfby`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_lk_msdyn_requirementresourcepreference_createdby"></a> lk_msdyn_requirementresourcepreference_createdby

Many-To-One Relationship: [msdyn_requirementresourcepreference lk_msdyn_requirementresourcepreference_createdby](msdyn_requirementresourcepreference.md#BKMK_lk_msdyn_requirementresourcepreference_createdby)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_requirementresourcepreference`|
|ReferencingAttribute|`createdby`|
|ReferencedEntityNavigationPropertyName|`lk_msdyn_requirementresourcepreference_createdby`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_lk_msdyn_requirementresourcepreference_createdonbehalfby"></a> lk_msdyn_requirementresourcepreference_createdonbehalfby

Many-To-One Relationship: [msdyn_requirementresourcepreference lk_msdyn_requirementresourcepreference_createdonbehalfby](msdyn_requirementresourcepreference.md#BKMK_lk_msdyn_requirementresourcepreference_createdonbehalfby)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_requirementresourcepreference`|
|ReferencingAttribute|`createdonbehalfby`|
|ReferencedEntityNavigationPropertyName|`lk_msdyn_requirementresourcepreference_createdonbehalfby`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_lk_msdyn_requirementresourcepreference_modifiedby"></a> lk_msdyn_requirementresourcepreference_modifiedby

Many-To-One Relationship: [msdyn_requirementresourcepreference lk_msdyn_requirementresourcepreference_modifiedby](msdyn_requirementresourcepreference.md#BKMK_lk_msdyn_requirementresourcepreference_modifiedby)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_requirementresourcepreference`|
|ReferencingAttribute|`modifiedby`|
|ReferencedEntityNavigationPropertyName|`lk_msdyn_requirementresourcepreference_modifiedby`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_lk_msdyn_requirementresourcepreference_modifiedonbehalfby"></a> lk_msdyn_requirementresourcepreference_modifiedonbehalfby

Many-To-One Relationship: [msdyn_requirementresourcepreference lk_msdyn_requirementresourcepreference_modifiedonbehalfby](msdyn_requirementresourcepreference.md#BKMK_lk_msdyn_requirementresourcepreference_modifiedonbehalfby)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_requirementresourcepreference`|
|ReferencingAttribute|`modifiedonbehalfby`|
|ReferencedEntityNavigationPropertyName|`lk_msdyn_requirementresourcepreference_modifiedonbehalfby`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_lk_msdyn_requirementstatus_createdby"></a> lk_msdyn_requirementstatus_createdby

Many-To-One Relationship: [msdyn_requirementstatus lk_msdyn_requirementstatus_createdby](msdyn_requirementstatus.md#BKMK_lk_msdyn_requirementstatus_createdby)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_requirementstatus`|
|ReferencingAttribute|`createdby`|
|ReferencedEntityNavigationPropertyName|`lk_msdyn_requirementstatus_createdby`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_lk_msdyn_requirementstatus_createdonbehalfby"></a> lk_msdyn_requirementstatus_createdonbehalfby

Many-To-One Relationship: [msdyn_requirementstatus lk_msdyn_requirementstatus_createdonbehalfby](msdyn_requirementstatus.md#BKMK_lk_msdyn_requirementstatus_createdonbehalfby)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_requirementstatus`|
|ReferencingAttribute|`createdonbehalfby`|
|ReferencedEntityNavigationPropertyName|`lk_msdyn_requirementstatus_createdonbehalfby`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_lk_msdyn_requirementstatus_modifiedby"></a> lk_msdyn_requirementstatus_modifiedby

Many-To-One Relationship: [msdyn_requirementstatus lk_msdyn_requirementstatus_modifiedby](msdyn_requirementstatus.md#BKMK_lk_msdyn_requirementstatus_modifiedby)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_requirementstatus`|
|ReferencingAttribute|`modifiedby`|
|ReferencedEntityNavigationPropertyName|`lk_msdyn_requirementstatus_modifiedby`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_lk_msdyn_requirementstatus_modifiedonbehalfby"></a> lk_msdyn_requirementstatus_modifiedonbehalfby

Many-To-One Relationship: [msdyn_requirementstatus lk_msdyn_requirementstatus_modifiedonbehalfby](msdyn_requirementstatus.md#BKMK_lk_msdyn_requirementstatus_modifiedonbehalfby)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_requirementstatus`|
|ReferencingAttribute|`modifiedonbehalfby`|
|ReferencedEntityNavigationPropertyName|`lk_msdyn_requirementstatus_modifiedonbehalfby`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_lk_msdyn_resourcerequirement_createdby"></a> lk_msdyn_resourcerequirement_createdby

Many-To-One Relationship: [msdyn_resourcerequirement lk_msdyn_resourcerequirement_createdby](msdyn_resourcerequirement.md#BKMK_lk_msdyn_resourcerequirement_createdby)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_resourcerequirement`|
|ReferencingAttribute|`createdby`|
|ReferencedEntityNavigationPropertyName|`lk_msdyn_resourcerequirement_createdby`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_lk_msdyn_resourcerequirement_createdonbehalfby"></a> lk_msdyn_resourcerequirement_createdonbehalfby

Many-To-One Relationship: [msdyn_resourcerequirement lk_msdyn_resourcerequirement_createdonbehalfby](msdyn_resourcerequirement.md#BKMK_lk_msdyn_resourcerequirement_createdonbehalfby)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_resourcerequirement`|
|ReferencingAttribute|`createdonbehalfby`|
|ReferencedEntityNavigationPropertyName|`lk_msdyn_resourcerequirement_createdonbehalfby`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_lk_msdyn_resourcerequirement_modifiedby"></a> lk_msdyn_resourcerequirement_modifiedby

Many-To-One Relationship: [msdyn_resourcerequirement lk_msdyn_resourcerequirement_modifiedby](msdyn_resourcerequirement.md#BKMK_lk_msdyn_resourcerequirement_modifiedby)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_resourcerequirement`|
|ReferencingAttribute|`modifiedby`|
|ReferencedEntityNavigationPropertyName|`lk_msdyn_resourcerequirement_modifiedby`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_lk_msdyn_resourcerequirement_modifiedonbehalfby"></a> lk_msdyn_resourcerequirement_modifiedonbehalfby

Many-To-One Relationship: [msdyn_resourcerequirement lk_msdyn_resourcerequirement_modifiedonbehalfby](msdyn_resourcerequirement.md#BKMK_lk_msdyn_resourcerequirement_modifiedonbehalfby)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_resourcerequirement`|
|ReferencingAttribute|`modifiedonbehalfby`|
|ReferencedEntityNavigationPropertyName|`lk_msdyn_resourcerequirement_modifiedonbehalfby`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_lk_msdyn_resourcerequirementdetail_createdby"></a> lk_msdyn_resourcerequirementdetail_createdby

Many-To-One Relationship: [msdyn_resourcerequirementdetail lk_msdyn_resourcerequirementdetail_createdby](msdyn_resourcerequirementdetail.md#BKMK_lk_msdyn_resourcerequirementdetail_createdby)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_resourcerequirementdetail`|
|ReferencingAttribute|`createdby`|
|ReferencedEntityNavigationPropertyName|`lk_msdyn_resourcerequirementdetail_createdby`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_lk_msdyn_resourcerequirementdetail_createdonbehalfby"></a> lk_msdyn_resourcerequirementdetail_createdonbehalfby

Many-To-One Relationship: [msdyn_resourcerequirementdetail lk_msdyn_resourcerequirementdetail_createdonbehalfby](msdyn_resourcerequirementdetail.md#BKMK_lk_msdyn_resourcerequirementdetail_createdonbehalfby)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_resourcerequirementdetail`|
|ReferencingAttribute|`createdonbehalfby`|
|ReferencedEntityNavigationPropertyName|`lk_msdyn_resourcerequirementdetail_createdonbehalfby`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_lk_msdyn_resourcerequirementdetail_modifiedby"></a> lk_msdyn_resourcerequirementdetail_modifiedby

Many-To-One Relationship: [msdyn_resourcerequirementdetail lk_msdyn_resourcerequirementdetail_modifiedby](msdyn_resourcerequirementdetail.md#BKMK_lk_msdyn_resourcerequirementdetail_modifiedby)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_resourcerequirementdetail`|
|ReferencingAttribute|`modifiedby`|
|ReferencedEntityNavigationPropertyName|`lk_msdyn_resourcerequirementdetail_modifiedby`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_lk_msdyn_resourcerequirementdetail_modifiedonbehalfby"></a> lk_msdyn_resourcerequirementdetail_modifiedonbehalfby

Many-To-One Relationship: [msdyn_resourcerequirementdetail lk_msdyn_resourcerequirementdetail_modifiedonbehalfby](msdyn_resourcerequirementdetail.md#BKMK_lk_msdyn_resourcerequirementdetail_modifiedonbehalfby)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_resourcerequirementdetail`|
|ReferencingAttribute|`modifiedonbehalfby`|
|ReferencedEntityNavigationPropertyName|`lk_msdyn_resourcerequirementdetail_modifiedonbehalfby`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_lk_msdyn_resourceterritory_createdby"></a> lk_msdyn_resourceterritory_createdby

Many-To-One Relationship: [msdyn_resourceterritory lk_msdyn_resourceterritory_createdby](msdyn_resourceterritory.md#BKMK_lk_msdyn_resourceterritory_createdby)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_resourceterritory`|
|ReferencingAttribute|`createdby`|
|ReferencedEntityNavigationPropertyName|`lk_msdyn_resourceterritory_createdby`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_lk_msdyn_resourceterritory_createdonbehalfby"></a> lk_msdyn_resourceterritory_createdonbehalfby

Many-To-One Relationship: [msdyn_resourceterritory lk_msdyn_resourceterritory_createdonbehalfby](msdyn_resourceterritory.md#BKMK_lk_msdyn_resourceterritory_createdonbehalfby)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_resourceterritory`|
|ReferencingAttribute|`createdonbehalfby`|
|ReferencedEntityNavigationPropertyName|`lk_msdyn_resourceterritory_createdonbehalfby`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_lk_msdyn_resourceterritory_modifiedby"></a> lk_msdyn_resourceterritory_modifiedby

Many-To-One Relationship: [msdyn_resourceterritory lk_msdyn_resourceterritory_modifiedby](msdyn_resourceterritory.md#BKMK_lk_msdyn_resourceterritory_modifiedby)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_resourceterritory`|
|ReferencingAttribute|`modifiedby`|
|ReferencedEntityNavigationPropertyName|`lk_msdyn_resourceterritory_modifiedby`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_lk_msdyn_resourceterritory_modifiedonbehalfby"></a> lk_msdyn_resourceterritory_modifiedonbehalfby

Many-To-One Relationship: [msdyn_resourceterritory lk_msdyn_resourceterritory_modifiedonbehalfby](msdyn_resourceterritory.md#BKMK_lk_msdyn_resourceterritory_modifiedonbehalfby)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_resourceterritory`|
|ReferencingAttribute|`modifiedonbehalfby`|
|ReferencedEntityNavigationPropertyName|`lk_msdyn_resourceterritory_modifiedonbehalfby`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_lk_msdyn_scheduleboardsetting_createdby"></a> lk_msdyn_scheduleboardsetting_createdby

Many-To-One Relationship: [msdyn_scheduleboardsetting lk_msdyn_scheduleboardsetting_createdby](msdyn_scheduleboardsetting.md#BKMK_lk_msdyn_scheduleboardsetting_createdby)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_scheduleboardsetting`|
|ReferencingAttribute|`createdby`|
|ReferencedEntityNavigationPropertyName|`lk_msdyn_scheduleboardsetting_createdby`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_lk_msdyn_scheduleboardsetting_createdonbehalfby"></a> lk_msdyn_scheduleboardsetting_createdonbehalfby

Many-To-One Relationship: [msdyn_scheduleboardsetting lk_msdyn_scheduleboardsetting_createdonbehalfby](msdyn_scheduleboardsetting.md#BKMK_lk_msdyn_scheduleboardsetting_createdonbehalfby)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_scheduleboardsetting`|
|ReferencingAttribute|`createdonbehalfby`|
|ReferencedEntityNavigationPropertyName|`lk_msdyn_scheduleboardsetting_createdonbehalfby`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_lk_msdyn_scheduleboardsetting_modifiedby"></a> lk_msdyn_scheduleboardsetting_modifiedby

Many-To-One Relationship: [msdyn_scheduleboardsetting lk_msdyn_scheduleboardsetting_modifiedby](msdyn_scheduleboardsetting.md#BKMK_lk_msdyn_scheduleboardsetting_modifiedby)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_scheduleboardsetting`|
|ReferencingAttribute|`modifiedby`|
|ReferencedEntityNavigationPropertyName|`lk_msdyn_scheduleboardsetting_modifiedby`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_lk_msdyn_scheduleboardsetting_modifiedonbehalfby"></a> lk_msdyn_scheduleboardsetting_modifiedonbehalfby

Many-To-One Relationship: [msdyn_scheduleboardsetting lk_msdyn_scheduleboardsetting_modifiedonbehalfby](msdyn_scheduleboardsetting.md#BKMK_lk_msdyn_scheduleboardsetting_modifiedonbehalfby)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_scheduleboardsetting`|
|ReferencingAttribute|`modifiedonbehalfby`|
|ReferencedEntityNavigationPropertyName|`lk_msdyn_scheduleboardsetting_modifiedonbehalfby`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_lk_msdyn_schedulingfeatureflag_createdby"></a> lk_msdyn_schedulingfeatureflag_createdby

Many-To-One Relationship: [msdyn_schedulingfeatureflag lk_msdyn_schedulingfeatureflag_createdby](msdyn_schedulingfeatureflag.md#BKMK_lk_msdyn_schedulingfeatureflag_createdby)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_schedulingfeatureflag`|
|ReferencingAttribute|`createdby`|
|ReferencedEntityNavigationPropertyName|`lk_msdyn_schedulingfeatureflag_createdby`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_lk_msdyn_schedulingfeatureflag_createdonbehalfby"></a> lk_msdyn_schedulingfeatureflag_createdonbehalfby

Many-To-One Relationship: [msdyn_schedulingfeatureflag lk_msdyn_schedulingfeatureflag_createdonbehalfby](msdyn_schedulingfeatureflag.md#BKMK_lk_msdyn_schedulingfeatureflag_createdonbehalfby)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_schedulingfeatureflag`|
|ReferencingAttribute|`createdonbehalfby`|
|ReferencedEntityNavigationPropertyName|`lk_msdyn_schedulingfeatureflag_createdonbehalfby`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_lk_msdyn_schedulingfeatureflag_modifiedby"></a> lk_msdyn_schedulingfeatureflag_modifiedby

Many-To-One Relationship: [msdyn_schedulingfeatureflag lk_msdyn_schedulingfeatureflag_modifiedby](msdyn_schedulingfeatureflag.md#BKMK_lk_msdyn_schedulingfeatureflag_modifiedby)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_schedulingfeatureflag`|
|ReferencingAttribute|`modifiedby`|
|ReferencedEntityNavigationPropertyName|`lk_msdyn_schedulingfeatureflag_modifiedby`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_lk_msdyn_schedulingfeatureflag_modifiedonbehalfby"></a> lk_msdyn_schedulingfeatureflag_modifiedonbehalfby

Many-To-One Relationship: [msdyn_schedulingfeatureflag lk_msdyn_schedulingfeatureflag_modifiedonbehalfby](msdyn_schedulingfeatureflag.md#BKMK_lk_msdyn_schedulingfeatureflag_modifiedonbehalfby)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_schedulingfeatureflag`|
|ReferencingAttribute|`modifiedonbehalfby`|
|ReferencedEntityNavigationPropertyName|`lk_msdyn_schedulingfeatureflag_modifiedonbehalfby`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_lk_msdyn_schedulingparameter_createdby"></a> lk_msdyn_schedulingparameter_createdby

Many-To-One Relationship: [msdyn_schedulingparameter lk_msdyn_schedulingparameter_createdby](msdyn_schedulingparameter.md#BKMK_lk_msdyn_schedulingparameter_createdby)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_schedulingparameter`|
|ReferencingAttribute|`createdby`|
|ReferencedEntityNavigationPropertyName|`lk_msdyn_schedulingparameter_createdby`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_lk_msdyn_schedulingparameter_createdonbehalfby"></a> lk_msdyn_schedulingparameter_createdonbehalfby

Many-To-One Relationship: [msdyn_schedulingparameter lk_msdyn_schedulingparameter_createdonbehalfby](msdyn_schedulingparameter.md#BKMK_lk_msdyn_schedulingparameter_createdonbehalfby)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_schedulingparameter`|
|ReferencingAttribute|`createdonbehalfby`|
|ReferencedEntityNavigationPropertyName|`lk_msdyn_schedulingparameter_createdonbehalfby`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_lk_msdyn_schedulingparameter_modifiedby"></a> lk_msdyn_schedulingparameter_modifiedby

Many-To-One Relationship: [msdyn_schedulingparameter lk_msdyn_schedulingparameter_modifiedby](msdyn_schedulingparameter.md#BKMK_lk_msdyn_schedulingparameter_modifiedby)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_schedulingparameter`|
|ReferencingAttribute|`modifiedby`|
|ReferencedEntityNavigationPropertyName|`lk_msdyn_schedulingparameter_modifiedby`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_lk_msdyn_schedulingparameter_modifiedonbehalfby"></a> lk_msdyn_schedulingparameter_modifiedonbehalfby

Many-To-One Relationship: [msdyn_schedulingparameter lk_msdyn_schedulingparameter_modifiedonbehalfby](msdyn_schedulingparameter.md#BKMK_lk_msdyn_schedulingparameter_modifiedonbehalfby)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_schedulingparameter`|
|ReferencingAttribute|`modifiedonbehalfby`|
|ReferencedEntityNavigationPropertyName|`lk_msdyn_schedulingparameter_modifiedonbehalfby`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_lk_msdyn_schedulingscope_createdby"></a> lk_msdyn_schedulingscope_createdby

Many-To-One Relationship: [msdyn_schedulingscope lk_msdyn_schedulingscope_createdby](msdyn_schedulingscope.md#BKMK_lk_msdyn_schedulingscope_createdby)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_schedulingscope`|
|ReferencingAttribute|`createdby`|
|ReferencedEntityNavigationPropertyName|`lk_msdyn_schedulingscope_createdby`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_lk_msdyn_schedulingscope_createdonbehalfby"></a> lk_msdyn_schedulingscope_createdonbehalfby

Many-To-One Relationship: [msdyn_schedulingscope lk_msdyn_schedulingscope_createdonbehalfby](msdyn_schedulingscope.md#BKMK_lk_msdyn_schedulingscope_createdonbehalfby)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_schedulingscope`|
|ReferencingAttribute|`createdonbehalfby`|
|ReferencedEntityNavigationPropertyName|`lk_msdyn_schedulingscope_createdonbehalfby`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_lk_msdyn_schedulingscope_modifiedby"></a> lk_msdyn_schedulingscope_modifiedby

Many-To-One Relationship: [msdyn_schedulingscope lk_msdyn_schedulingscope_modifiedby](msdyn_schedulingscope.md#BKMK_lk_msdyn_schedulingscope_modifiedby)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_schedulingscope`|
|ReferencingAttribute|`modifiedby`|
|ReferencedEntityNavigationPropertyName|`lk_msdyn_schedulingscope_modifiedby`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_lk_msdyn_schedulingscope_modifiedonbehalfby"></a> lk_msdyn_schedulingscope_modifiedonbehalfby

Many-To-One Relationship: [msdyn_schedulingscope lk_msdyn_schedulingscope_modifiedonbehalfby](msdyn_schedulingscope.md#BKMK_lk_msdyn_schedulingscope_modifiedonbehalfby)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_schedulingscope`|
|ReferencingAttribute|`modifiedonbehalfby`|
|ReferencedEntityNavigationPropertyName|`lk_msdyn_schedulingscope_modifiedonbehalfby`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_lk_msdyn_systemuserschedulersetting_createdby"></a> lk_msdyn_systemuserschedulersetting_createdby

Many-To-One Relationship: [msdyn_systemuserschedulersetting lk_msdyn_systemuserschedulersetting_createdby](msdyn_systemuserschedulersetting.md#BKMK_lk_msdyn_systemuserschedulersetting_createdby)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_systemuserschedulersetting`|
|ReferencingAttribute|`createdby`|
|ReferencedEntityNavigationPropertyName|`lk_msdyn_systemuserschedulersetting_createdby`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_lk_msdyn_systemuserschedulersetting_createdonbehalfby"></a> lk_msdyn_systemuserschedulersetting_createdonbehalfby

Many-To-One Relationship: [msdyn_systemuserschedulersetting lk_msdyn_systemuserschedulersetting_createdonbehalfby](msdyn_systemuserschedulersetting.md#BKMK_lk_msdyn_systemuserschedulersetting_createdonbehalfby)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_systemuserschedulersetting`|
|ReferencingAttribute|`createdonbehalfby`|
|ReferencedEntityNavigationPropertyName|`lk_msdyn_systemuserschedulersetting_createdonbehalfby`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_lk_msdyn_systemuserschedulersetting_modifiedby"></a> lk_msdyn_systemuserschedulersetting_modifiedby

Many-To-One Relationship: [msdyn_systemuserschedulersetting lk_msdyn_systemuserschedulersetting_modifiedby](msdyn_systemuserschedulersetting.md#BKMK_lk_msdyn_systemuserschedulersetting_modifiedby)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_systemuserschedulersetting`|
|ReferencingAttribute|`modifiedby`|
|ReferencedEntityNavigationPropertyName|`lk_msdyn_systemuserschedulersetting_modifiedby`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_lk_msdyn_systemuserschedulersetting_modifiedonbehalfby"></a> lk_msdyn_systemuserschedulersetting_modifiedonbehalfby

Many-To-One Relationship: [msdyn_systemuserschedulersetting lk_msdyn_systemuserschedulersetting_modifiedonbehalfby](msdyn_systemuserschedulersetting.md#BKMK_lk_msdyn_systemuserschedulersetting_modifiedonbehalfby)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_systemuserschedulersetting`|
|ReferencingAttribute|`modifiedonbehalfby`|
|ReferencedEntityNavigationPropertyName|`lk_msdyn_systemuserschedulersetting_modifiedonbehalfby`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_lk_msdyn_timegroup_createdby"></a> lk_msdyn_timegroup_createdby

Many-To-One Relationship: [msdyn_timegroup lk_msdyn_timegroup_createdby](msdyn_timegroup.md#BKMK_lk_msdyn_timegroup_createdby)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_timegroup`|
|ReferencingAttribute|`createdby`|
|ReferencedEntityNavigationPropertyName|`lk_msdyn_timegroup_createdby`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_lk_msdyn_timegroup_createdonbehalfby"></a> lk_msdyn_timegroup_createdonbehalfby

Many-To-One Relationship: [msdyn_timegroup lk_msdyn_timegroup_createdonbehalfby](msdyn_timegroup.md#BKMK_lk_msdyn_timegroup_createdonbehalfby)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_timegroup`|
|ReferencingAttribute|`createdonbehalfby`|
|ReferencedEntityNavigationPropertyName|`lk_msdyn_timegroup_createdonbehalfby`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_lk_msdyn_timegroup_modifiedby"></a> lk_msdyn_timegroup_modifiedby

Many-To-One Relationship: [msdyn_timegroup lk_msdyn_timegroup_modifiedby](msdyn_timegroup.md#BKMK_lk_msdyn_timegroup_modifiedby)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_timegroup`|
|ReferencingAttribute|`modifiedby`|
|ReferencedEntityNavigationPropertyName|`lk_msdyn_timegroup_modifiedby`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_lk_msdyn_timegroup_modifiedonbehalfby"></a> lk_msdyn_timegroup_modifiedonbehalfby

Many-To-One Relationship: [msdyn_timegroup lk_msdyn_timegroup_modifiedonbehalfby](msdyn_timegroup.md#BKMK_lk_msdyn_timegroup_modifiedonbehalfby)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_timegroup`|
|ReferencingAttribute|`modifiedonbehalfby`|
|ReferencedEntityNavigationPropertyName|`lk_msdyn_timegroup_modifiedonbehalfby`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_lk_msdyn_timegroupdetail_createdby"></a> lk_msdyn_timegroupdetail_createdby

Many-To-One Relationship: [msdyn_timegroupdetail lk_msdyn_timegroupdetail_createdby](msdyn_timegroupdetail.md#BKMK_lk_msdyn_timegroupdetail_createdby)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_timegroupdetail`|
|ReferencingAttribute|`createdby`|
|ReferencedEntityNavigationPropertyName|`lk_msdyn_timegroupdetail_createdby`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_lk_msdyn_timegroupdetail_createdonbehalfby"></a> lk_msdyn_timegroupdetail_createdonbehalfby

Many-To-One Relationship: [msdyn_timegroupdetail lk_msdyn_timegroupdetail_createdonbehalfby](msdyn_timegroupdetail.md#BKMK_lk_msdyn_timegroupdetail_createdonbehalfby)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_timegroupdetail`|
|ReferencingAttribute|`createdonbehalfby`|
|ReferencedEntityNavigationPropertyName|`lk_msdyn_timegroupdetail_createdonbehalfby`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_lk_msdyn_timegroupdetail_modifiedby"></a> lk_msdyn_timegroupdetail_modifiedby

Many-To-One Relationship: [msdyn_timegroupdetail lk_msdyn_timegroupdetail_modifiedby](msdyn_timegroupdetail.md#BKMK_lk_msdyn_timegroupdetail_modifiedby)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_timegroupdetail`|
|ReferencingAttribute|`modifiedby`|
|ReferencedEntityNavigationPropertyName|`lk_msdyn_timegroupdetail_modifiedby`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_lk_msdyn_timegroupdetail_modifiedonbehalfby"></a> lk_msdyn_timegroupdetail_modifiedonbehalfby

Many-To-One Relationship: [msdyn_timegroupdetail lk_msdyn_timegroupdetail_modifiedonbehalfby](msdyn_timegroupdetail.md#BKMK_lk_msdyn_timegroupdetail_modifiedonbehalfby)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_timegroupdetail`|
|ReferencingAttribute|`modifiedonbehalfby`|
|ReferencedEntityNavigationPropertyName|`lk_msdyn_timegroupdetail_modifiedonbehalfby`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_lk_msdyn_transactionorigin_createdby"></a> lk_msdyn_transactionorigin_createdby

Many-To-One Relationship: [msdyn_transactionorigin lk_msdyn_transactionorigin_createdby](msdyn_transactionorigin.md#BKMK_lk_msdyn_transactionorigin_createdby)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_transactionorigin`|
|ReferencingAttribute|`createdby`|
|ReferencedEntityNavigationPropertyName|`lk_msdyn_transactionorigin_createdby`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_lk_msdyn_transactionorigin_createdonbehalfby"></a> lk_msdyn_transactionorigin_createdonbehalfby

Many-To-One Relationship: [msdyn_transactionorigin lk_msdyn_transactionorigin_createdonbehalfby](msdyn_transactionorigin.md#BKMK_lk_msdyn_transactionorigin_createdonbehalfby)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_transactionorigin`|
|ReferencingAttribute|`createdonbehalfby`|
|ReferencedEntityNavigationPropertyName|`lk_msdyn_transactionorigin_createdonbehalfby`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_lk_msdyn_transactionorigin_modifiedby"></a> lk_msdyn_transactionorigin_modifiedby

Many-To-One Relationship: [msdyn_transactionorigin lk_msdyn_transactionorigin_modifiedby](msdyn_transactionorigin.md#BKMK_lk_msdyn_transactionorigin_modifiedby)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_transactionorigin`|
|ReferencingAttribute|`modifiedby`|
|ReferencedEntityNavigationPropertyName|`lk_msdyn_transactionorigin_modifiedby`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_lk_msdyn_transactionorigin_modifiedonbehalfby"></a> lk_msdyn_transactionorigin_modifiedonbehalfby

Many-To-One Relationship: [msdyn_transactionorigin lk_msdyn_transactionorigin_modifiedonbehalfby](msdyn_transactionorigin.md#BKMK_lk_msdyn_transactionorigin_modifiedonbehalfby)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_transactionorigin`|
|ReferencingAttribute|`modifiedonbehalfby`|
|ReferencedEntityNavigationPropertyName|`lk_msdyn_transactionorigin_modifiedonbehalfby`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_lk_msdyn_workhourtemplate_createdby"></a> lk_msdyn_workhourtemplate_createdby

Many-To-One Relationship: [msdyn_workhourtemplate lk_msdyn_workhourtemplate_createdby](msdyn_workhourtemplate.md#BKMK_lk_msdyn_workhourtemplate_createdby)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_workhourtemplate`|
|ReferencingAttribute|`createdby`|
|ReferencedEntityNavigationPropertyName|`lk_msdyn_workhourtemplate_createdby`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_lk_msdyn_workhourtemplate_createdonbehalfby"></a> lk_msdyn_workhourtemplate_createdonbehalfby

Many-To-One Relationship: [msdyn_workhourtemplate lk_msdyn_workhourtemplate_createdonbehalfby](msdyn_workhourtemplate.md#BKMK_lk_msdyn_workhourtemplate_createdonbehalfby)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_workhourtemplate`|
|ReferencingAttribute|`createdonbehalfby`|
|ReferencedEntityNavigationPropertyName|`lk_msdyn_workhourtemplate_createdonbehalfby`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_lk_msdyn_workhourtemplate_modifiedby"></a> lk_msdyn_workhourtemplate_modifiedby

Many-To-One Relationship: [msdyn_workhourtemplate lk_msdyn_workhourtemplate_modifiedby](msdyn_workhourtemplate.md#BKMK_lk_msdyn_workhourtemplate_modifiedby)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_workhourtemplate`|
|ReferencingAttribute|`modifiedby`|
|ReferencedEntityNavigationPropertyName|`lk_msdyn_workhourtemplate_modifiedby`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_lk_msdyn_workhourtemplate_modifiedonbehalfby"></a> lk_msdyn_workhourtemplate_modifiedonbehalfby

Many-To-One Relationship: [msdyn_workhourtemplate lk_msdyn_workhourtemplate_modifiedonbehalfby](msdyn_workhourtemplate.md#BKMK_lk_msdyn_workhourtemplate_modifiedonbehalfby)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_workhourtemplate`|
|ReferencingAttribute|`modifiedonbehalfby`|
|ReferencedEntityNavigationPropertyName|`lk_msdyn_workhourtemplate_modifiedonbehalfby`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_bookingalert_systemuser_createdby"></a> msdyn_bookingalert_systemuser_createdby

Many-To-One Relationship: [msdyn_bookingalert msdyn_bookingalert_systemuser_createdby](msdyn_bookingalert.md#BKMK_msdyn_bookingalert_systemuser_createdby)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_bookingalert`|
|ReferencingAttribute|`createdby`|
|ReferencedEntityNavigationPropertyName|`msdyn_bookingalert_systemuser_createdby`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_bookingalert_systemuser_createdonbehalfby"></a> msdyn_bookingalert_systemuser_createdonbehalfby

Many-To-One Relationship: [msdyn_bookingalert msdyn_bookingalert_systemuser_createdonbehalfby](msdyn_bookingalert.md#BKMK_msdyn_bookingalert_systemuser_createdonbehalfby)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_bookingalert`|
|ReferencingAttribute|`createdonbehalfby`|
|ReferencedEntityNavigationPropertyName|`msdyn_bookingalert_systemuser_createdonbehalfby`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_bookingalert_systemuser_modifiedby"></a> msdyn_bookingalert_systemuser_modifiedby

Many-To-One Relationship: [msdyn_bookingalert msdyn_bookingalert_systemuser_modifiedby](msdyn_bookingalert.md#BKMK_msdyn_bookingalert_systemuser_modifiedby)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_bookingalert`|
|ReferencingAttribute|`modifiedby`|
|ReferencedEntityNavigationPropertyName|`msdyn_bookingalert_systemuser_modifiedby`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_bookingalert_systemuser_modifiedonbehalfby"></a> msdyn_bookingalert_systemuser_modifiedonbehalfby

Many-To-One Relationship: [msdyn_bookingalert msdyn_bookingalert_systemuser_modifiedonbehalfby](msdyn_bookingalert.md#BKMK_msdyn_bookingalert_systemuser_modifiedonbehalfby)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_bookingalert`|
|ReferencingAttribute|`modifiedonbehalfby`|
|ReferencedEntityNavigationPropertyName|`msdyn_bookingalert_systemuser_modifiedonbehalfby`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_bookingalert_systemuser_owninguser"></a> msdyn_bookingalert_systemuser_owninguser

Many-To-One Relationship: [msdyn_bookingalert msdyn_bookingalert_systemuser_owninguser](msdyn_bookingalert.md#BKMK_msdyn_bookingalert_systemuser_owninguser)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_bookingalert`|
|ReferencingAttribute|`owninguser`|
|ReferencedEntityNavigationPropertyName|`msdyn_bookingalert_systemuser_owninguser`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_systemuser_msdyn_systemuserschedulersetting_User"></a> msdyn_systemuser_msdyn_systemuserschedulersetting_User

Many-To-One Relationship: [msdyn_systemuserschedulersetting msdyn_systemuser_msdyn_systemuserschedulersetting_User](msdyn_systemuserschedulersetting.md#BKMK_msdyn_systemuser_msdyn_systemuserschedulersetting_User)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_systemuserschedulersetting`|
|ReferencingAttribute|`msdyn_user`|
|ReferencedEntityNavigationPropertyName|`msdyn_systemuser_msdyn_systemuserschedulersetting_User`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_user_msdyn_actual"></a> user_msdyn_actual

Many-To-One Relationship: [msdyn_actual user_msdyn_actual](msdyn_actual.md#BKMK_user_msdyn_actual)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_actual`|
|ReferencingAttribute|`owninguser`|
|ReferencedEntityNavigationPropertyName|`user_msdyn_actual`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_user_msdyn_bookableresourceassociation"></a> user_msdyn_bookableresourceassociation

Many-To-One Relationship: [msdyn_bookableresourceassociation user_msdyn_bookableresourceassociation](msdyn_bookableresourceassociation.md#BKMK_user_msdyn_bookableresourceassociation)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_bookableresourceassociation`|
|ReferencingAttribute|`owninguser`|
|ReferencedEntityNavigationPropertyName|`user_msdyn_bookableresourceassociation`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_user_msdyn_bookingalertstatus"></a> user_msdyn_bookingalertstatus

Many-To-One Relationship: [msdyn_bookingalertstatus user_msdyn_bookingalertstatus](msdyn_bookingalertstatus.md#BKMK_user_msdyn_bookingalertstatus)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_bookingalertstatus`|
|ReferencingAttribute|`owninguser`|
|ReferencedEntityNavigationPropertyName|`user_msdyn_bookingalertstatus`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_user_msdyn_bookingchange"></a> user_msdyn_bookingchange

Many-To-One Relationship: [msdyn_bookingchange user_msdyn_bookingchange](msdyn_bookingchange.md#BKMK_user_msdyn_bookingchange)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_bookingchange`|
|ReferencingAttribute|`owninguser`|
|ReferencedEntityNavigationPropertyName|`user_msdyn_bookingchange`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_user_msdyn_bookingrule"></a> user_msdyn_bookingrule

Many-To-One Relationship: [msdyn_bookingrule user_msdyn_bookingrule](msdyn_bookingrule.md#BKMK_user_msdyn_bookingrule)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_bookingrule`|
|ReferencingAttribute|`owninguser`|
|ReferencedEntityNavigationPropertyName|`user_msdyn_bookingrule`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_user_msdyn_bookingsetupmetadata"></a> user_msdyn_bookingsetupmetadata

Many-To-One Relationship: [msdyn_bookingsetupmetadata user_msdyn_bookingsetupmetadata](msdyn_bookingsetupmetadata.md#BKMK_user_msdyn_bookingsetupmetadata)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_bookingsetupmetadata`|
|ReferencingAttribute|`owninguser`|
|ReferencedEntityNavigationPropertyName|`user_msdyn_bookingsetupmetadata`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_user_msdyn_businessclosure"></a> user_msdyn_businessclosure

Many-To-One Relationship: [msdyn_businessclosure user_msdyn_businessclosure](msdyn_businessclosure.md#BKMK_user_msdyn_businessclosure)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_businessclosure`|
|ReferencingAttribute|`owninguser`|
|ReferencedEntityNavigationPropertyName|`user_msdyn_businessclosure`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_user_msdyn_clientextension"></a> user_msdyn_clientextension

Many-To-One Relationship: [msdyn_clientextension user_msdyn_clientextension](msdyn_clientextension.md#BKMK_user_msdyn_clientextension)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_clientextension`|
|ReferencingAttribute|`owninguser`|
|ReferencedEntityNavigationPropertyName|`user_msdyn_clientextension`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_user_msdyn_configuration"></a> user_msdyn_configuration

Many-To-One Relationship: [msdyn_configuration user_msdyn_configuration](msdyn_configuration.md#BKMK_user_msdyn_configuration)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_configuration`|
|ReferencingAttribute|`owninguser`|
|ReferencedEntityNavigationPropertyName|`user_msdyn_configuration`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_user_msdyn_optimizationrequest"></a> user_msdyn_optimizationrequest

Many-To-One Relationship: [msdyn_optimizationrequest user_msdyn_optimizationrequest](msdyn_optimizationrequest.md#BKMK_user_msdyn_optimizationrequest)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_optimizationrequest`|
|ReferencingAttribute|`owninguser`|
|ReferencedEntityNavigationPropertyName|`user_msdyn_optimizationrequest`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_user_msdyn_priority"></a> user_msdyn_priority

Many-To-One Relationship: [msdyn_priority user_msdyn_priority](msdyn_priority.md#BKMK_user_msdyn_priority)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_priority`|
|ReferencingAttribute|`owninguser`|
|ReferencedEntityNavigationPropertyName|`user_msdyn_priority`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_user_msdyn_requirementchange"></a> user_msdyn_requirementchange

Many-To-One Relationship: [msdyn_requirementchange user_msdyn_requirementchange](msdyn_requirementchange.md#BKMK_user_msdyn_requirementchange)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_requirementchange`|
|ReferencingAttribute|`owninguser`|
|ReferencedEntityNavigationPropertyName|`user_msdyn_requirementchange`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_user_msdyn_requirementcharacteristic"></a> user_msdyn_requirementcharacteristic

Many-To-One Relationship: [msdyn_requirementcharacteristic user_msdyn_requirementcharacteristic](msdyn_requirementcharacteristic.md#BKMK_user_msdyn_requirementcharacteristic)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_requirementcharacteristic`|
|ReferencingAttribute|`owninguser`|
|ReferencedEntityNavigationPropertyName|`user_msdyn_requirementcharacteristic`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_user_msdyn_requirementdependency"></a> user_msdyn_requirementdependency

Many-To-One Relationship: [msdyn_requirementdependency user_msdyn_requirementdependency](msdyn_requirementdependency.md#BKMK_user_msdyn_requirementdependency)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_requirementdependency`|
|ReferencingAttribute|`owninguser`|
|ReferencedEntityNavigationPropertyName|`user_msdyn_requirementdependency`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_user_msdyn_requirementgroup"></a> user_msdyn_requirementgroup

Many-To-One Relationship: [msdyn_requirementgroup user_msdyn_requirementgroup](msdyn_requirementgroup.md#BKMK_user_msdyn_requirementgroup)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_requirementgroup`|
|ReferencingAttribute|`owninguser`|
|ReferencedEntityNavigationPropertyName|`user_msdyn_requirementgroup`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_user_msdyn_requirementorganizationunit"></a> user_msdyn_requirementorganizationunit

Many-To-One Relationship: [msdyn_requirementorganizationunit user_msdyn_requirementorganizationunit](msdyn_requirementorganizationunit.md#BKMK_user_msdyn_requirementorganizationunit)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_requirementorganizationunit`|
|ReferencingAttribute|`owninguser`|
|ReferencedEntityNavigationPropertyName|`user_msdyn_requirementorganizationunit`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_user_msdyn_requirementrelationship"></a> user_msdyn_requirementrelationship

Many-To-One Relationship: [msdyn_requirementrelationship user_msdyn_requirementrelationship](msdyn_requirementrelationship.md#BKMK_user_msdyn_requirementrelationship)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_requirementrelationship`|
|ReferencingAttribute|`owninguser`|
|ReferencedEntityNavigationPropertyName|`user_msdyn_requirementrelationship`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_user_msdyn_requirementresourcecategory"></a> user_msdyn_requirementresourcecategory

Many-To-One Relationship: [msdyn_requirementresourcecategory user_msdyn_requirementresourcecategory](msdyn_requirementresourcecategory.md#BKMK_user_msdyn_requirementresourcecategory)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_requirementresourcecategory`|
|ReferencingAttribute|`owninguser`|
|ReferencedEntityNavigationPropertyName|`user_msdyn_requirementresourcecategory`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_user_msdyn_requirementresourcepreference"></a> user_msdyn_requirementresourcepreference

Many-To-One Relationship: [msdyn_requirementresourcepreference user_msdyn_requirementresourcepreference](msdyn_requirementresourcepreference.md#BKMK_user_msdyn_requirementresourcepreference)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_requirementresourcepreference`|
|ReferencingAttribute|`owninguser`|
|ReferencedEntityNavigationPropertyName|`user_msdyn_requirementresourcepreference`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_user_msdyn_requirementstatus"></a> user_msdyn_requirementstatus

Many-To-One Relationship: [msdyn_requirementstatus user_msdyn_requirementstatus](msdyn_requirementstatus.md#BKMK_user_msdyn_requirementstatus)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_requirementstatus`|
|ReferencingAttribute|`owninguser`|
|ReferencedEntityNavigationPropertyName|`user_msdyn_requirementstatus`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_user_msdyn_resourcerequirement"></a> user_msdyn_resourcerequirement

Many-To-One Relationship: [msdyn_resourcerequirement user_msdyn_resourcerequirement](msdyn_resourcerequirement.md#BKMK_user_msdyn_resourcerequirement)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_resourcerequirement`|
|ReferencingAttribute|`owninguser`|
|ReferencedEntityNavigationPropertyName|`user_msdyn_resourcerequirement`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_user_msdyn_resourcerequirementdetail"></a> user_msdyn_resourcerequirementdetail

Many-To-One Relationship: [msdyn_resourcerequirementdetail user_msdyn_resourcerequirementdetail](msdyn_resourcerequirementdetail.md#BKMK_user_msdyn_resourcerequirementdetail)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_resourcerequirementdetail`|
|ReferencingAttribute|`owninguser`|
|ReferencedEntityNavigationPropertyName|`user_msdyn_resourcerequirementdetail`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_user_msdyn_resourceterritory"></a> user_msdyn_resourceterritory

Many-To-One Relationship: [msdyn_resourceterritory user_msdyn_resourceterritory](msdyn_resourceterritory.md#BKMK_user_msdyn_resourceterritory)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_resourceterritory`|
|ReferencingAttribute|`owninguser`|
|ReferencedEntityNavigationPropertyName|`user_msdyn_resourceterritory`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_user_msdyn_scheduleboardsetting"></a> user_msdyn_scheduleboardsetting

Many-To-One Relationship: [msdyn_scheduleboardsetting user_msdyn_scheduleboardsetting](msdyn_scheduleboardsetting.md#BKMK_user_msdyn_scheduleboardsetting)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_scheduleboardsetting`|
|ReferencingAttribute|`owninguser`|
|ReferencedEntityNavigationPropertyName|`user_msdyn_scheduleboardsetting`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_user_msdyn_schedulingfeatureflag"></a> user_msdyn_schedulingfeatureflag

Many-To-One Relationship: [msdyn_schedulingfeatureflag user_msdyn_schedulingfeatureflag](msdyn_schedulingfeatureflag.md#BKMK_user_msdyn_schedulingfeatureflag)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_schedulingfeatureflag`|
|ReferencingAttribute|`owninguser`|
|ReferencedEntityNavigationPropertyName|`user_msdyn_schedulingfeatureflag`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_user_msdyn_schedulingscope"></a> user_msdyn_schedulingscope

Many-To-One Relationship: [msdyn_schedulingscope user_msdyn_schedulingscope](msdyn_schedulingscope.md#BKMK_user_msdyn_schedulingscope)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_schedulingscope`|
|ReferencingAttribute|`owninguser`|
|ReferencedEntityNavigationPropertyName|`user_msdyn_schedulingscope`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_user_msdyn_systemuserschedulersetting"></a> user_msdyn_systemuserschedulersetting

Many-To-One Relationship: [msdyn_systemuserschedulersetting user_msdyn_systemuserschedulersetting](msdyn_systemuserschedulersetting.md#BKMK_user_msdyn_systemuserschedulersetting)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_systemuserschedulersetting`|
|ReferencingAttribute|`owninguser`|
|ReferencedEntityNavigationPropertyName|`user_msdyn_systemuserschedulersetting`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_user_msdyn_timegroup"></a> user_msdyn_timegroup

Many-To-One Relationship: [msdyn_timegroup user_msdyn_timegroup](msdyn_timegroup.md#BKMK_user_msdyn_timegroup)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_timegroup`|
|ReferencingAttribute|`owninguser`|
|ReferencedEntityNavigationPropertyName|`user_msdyn_timegroup`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_user_msdyn_timegroupdetail"></a> user_msdyn_timegroupdetail

Many-To-One Relationship: [msdyn_timegroupdetail user_msdyn_timegroupdetail](msdyn_timegroupdetail.md#BKMK_user_msdyn_timegroupdetail)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_timegroupdetail`|
|ReferencingAttribute|`owninguser`|
|ReferencedEntityNavigationPropertyName|`user_msdyn_timegroupdetail`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_user_msdyn_transactionorigin"></a> user_msdyn_transactionorigin

Many-To-One Relationship: [msdyn_transactionorigin user_msdyn_transactionorigin](msdyn_transactionorigin.md#BKMK_user_msdyn_transactionorigin)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_transactionorigin`|
|ReferencingAttribute|`owninguser`|
|ReferencedEntityNavigationPropertyName|`user_msdyn_transactionorigin`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_user_msdyn_workhourtemplate"></a> user_msdyn_workhourtemplate

Many-To-One Relationship: [msdyn_workhourtemplate user_msdyn_workhourtemplate](msdyn_workhourtemplate.md#BKMK_user_msdyn_workhourtemplate)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_workhourtemplate`|
|ReferencingAttribute|`owninguser`|
|ReferencedEntityNavigationPropertyName|`user_msdyn_workhourtemplate`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|



### See also

[Dataverse table/entity reference](/power-apps/developer/data-platform/reference/about-entity-reference)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   
<xref:Microsoft.Dynamics.CRM.systemuser?displayProperty=fullName>
