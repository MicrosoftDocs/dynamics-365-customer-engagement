---
title: "Organization table/entity reference (Microsoft Dynamics 365 Field Service)"
description: "Includes schema information and supported messages for the Organization table/entity with Microsoft Dynamics 365 Field Service."
ms.date: 08/21/2024
ms.service: powerapps
ms.topic: reference
author: m-hartmann
ms.author: mhart
search.audienceType: 
  - developer
---

# Organization table/entity reference

Top level of the Microsoft Dynamics 365 business hierarchy. The organization can be a specific business, holding company, or corporation.

> [!NOTE]
> The Microsoft Dynamics 365 Field Service Organization table extends the [Microsoft Dataverse Organization table](/power-apps/developer/data-platform/reference/entities/organization).



## Customized columns/attributes

Microsoft Dynamics 365 Field Service modifies the definition of columns/attributes defined in other solutions. Listed by **SchemaName**.

- [DisableSystemLabelsCacheSharing](#BKMK_DisableSystemLabelsCacheSharing)
- [EmailTemplateDefaultView](#BKMK_EmailTemplateDefaultView)
- [EnableCalendarImportExport](#BKMK_EnableCalendarImportExport)
- [IsCopilotFeedbackEnabled](#BKMK_IsCopilotFeedbackEnabled)
- [IsDesktopFlowConnectionEmbeddingEnabled](#BKMK_IsDesktopFlowConnectionEmbeddingEnabled)
- [IsDesktopFlowRuntimeRepairAttendedEnabled](#BKMK_IsDesktopFlowRuntimeRepairAttendedEnabled)
- [IsDesktopFlowRuntimeRepairUnattendedEnabled](#BKMK_IsDesktopFlowRuntimeRepairUnattendedEnabled)
- [IsPerProcessCapacityOverageEnabled](#BKMK_IsPerProcessCapacityOverageEnabled)
- [LegacyAppToggle](#BKMK_LegacyAppToggle)
- [SchedulingEngine](#BKMK_SchedulingEngine)

### <a name="BKMK_DisableSystemLabelsCacheSharing"></a> DisableSystemLabelsCacheSharing

Changes from [DisableSystemLabelsCacheSharing (Microsoft Dataverse)](/power-apps/developer/data-platform/reference/entities/organization#BKMK_DisableSystemLabelsCacheSharing)

|Property|Value|
|---|---|
|RequiredLevel|SystemRequired|


### <a name="BKMK_EmailTemplateDefaultView"></a> EmailTemplateDefaultView

Changes from [EmailTemplateDefaultView (Microsoft Dynamics 365)](/dynamics365/developer/entities//organization#BKMK_EmailTemplateDefaultView)

|Property|Value|
|---|---|
|RequiredLevel|SystemRequired|
|DefaultFormValue||


### <a name="BKMK_EnableCalendarImportExport"></a> EnableCalendarImportExport

Changes from [EnableCalendarImportExport (Microsoft Dynamics 365)](/dynamics365/developer/entities//organization#BKMK_EnableCalendarImportExport)

|Property|Value|
|---|---|
|RequiredLevel|SystemRequired|


### <a name="BKMK_IsCopilotFeedbackEnabled"></a> IsCopilotFeedbackEnabled

Changes from [IsCopilotFeedbackEnabled (Microsoft Dataverse)](/power-apps/developer/data-platform/reference/entities/organization#BKMK_IsCopilotFeedbackEnabled)

|Property|Value|
|---|---|
|RequiredLevel|SystemRequired|


### <a name="BKMK_IsDesktopFlowConnectionEmbeddingEnabled"></a> IsDesktopFlowConnectionEmbeddingEnabled

Changes from [IsDesktopFlowConnectionEmbeddingEnabled (Microsoft Dataverse)](/power-apps/developer/data-platform/reference/entities/organization#BKMK_IsDesktopFlowConnectionEmbeddingEnabled)

|Property|Value|
|---|---|
|RequiredLevel|SystemRequired|


### <a name="BKMK_IsDesktopFlowRuntimeRepairAttendedEnabled"></a> IsDesktopFlowRuntimeRepairAttendedEnabled

Changes from [IsDesktopFlowRuntimeRepairAttendedEnabled (Microsoft Dataverse)](/power-apps/developer/data-platform/reference/entities/organization#BKMK_IsDesktopFlowRuntimeRepairAttendedEnabled)

|Property|Value|
|---|---|
|RequiredLevel|SystemRequired|


### <a name="BKMK_IsDesktopFlowRuntimeRepairUnattendedEnabled"></a> IsDesktopFlowRuntimeRepairUnattendedEnabled

Changes from [IsDesktopFlowRuntimeRepairUnattendedEnabled (Microsoft Dataverse)](/power-apps/developer/data-platform/reference/entities/organization#BKMK_IsDesktopFlowRuntimeRepairUnattendedEnabled)

|Property|Value|
|---|---|
|RequiredLevel|SystemRequired|


### <a name="BKMK_IsPerProcessCapacityOverageEnabled"></a> IsPerProcessCapacityOverageEnabled

Changes from [IsPerProcessCapacityOverageEnabled (Microsoft Dataverse)](/power-apps/developer/data-platform/reference/entities/organization#BKMK_IsPerProcessCapacityOverageEnabled)

|Property|Value|
|---|---|
|RequiredLevel|SystemRequired|


### <a name="BKMK_LegacyAppToggle"></a> LegacyAppToggle

Changes from [LegacyAppToggle (Microsoft Dataverse)](/power-apps/developer/data-platform/reference/entities/organization#BKMK_LegacyAppToggle)

|Property|Value|
|---|---|
|RequiredLevel|SystemRequired|


### <a name="BKMK_SchedulingEngine"></a> SchedulingEngine

Changes from [SchedulingEngine (Microsoft Dynamics 365)](/dynamics365/developer/entities//organization#BKMK_SchedulingEngine)

#### SchedulingEngine Choices/Options

|Value|Label|
|---|---|
|192350000|**(Deprecated) Universal Resource Scheduling**|

## One-to-Many relationships

These relationships are one-to-many. Listed by **SchemaName**.

- [organization_msdyn_3dmodel](#BKMK_organization_msdyn_3dmodel)
- [organization_msdyn_assetsuggestionssetting](#BKMK_organization_msdyn_assetsuggestionssetting)
- [organization_msdyn_bpf_2c5fe86acc8b414b8322ae571000c799](#BKMK_organization_msdyn_bpf_2c5fe86acc8b414b8322ae571000c799)
- [organization_msdyn_bpf_477c16f59170487b8b4dc895c5dcd09b](#BKMK_organization_msdyn_bpf_477c16f59170487b8b4dc895c5dcd09b)
- [organization_msdyn_bpf_989e9b1857e24af18787d5143b67523b](#BKMK_organization_msdyn_bpf_989e9b1857e24af18787d5143b67523b)
- [organization_msdyn_bpf_baa0a411a239410cb8bded8b5fdd88e3](#BKMK_organization_msdyn_bpf_baa0a411a239410cb8bded8b5fdd88e3)
- [organization_msdyn_bpf_d3d97bac8c294105840e99e37a9d1c39](#BKMK_organization_msdyn_bpf_d3d97bac8c294105840e99e37a9d1c39)
- [organization_msdyn_dataanalyticsreport_fs](#BKMK_organization_msdyn_dataanalyticsreport_fs)
- [organization_msdyn_dataanalyticsreport_fspredictrs](#BKMK_organization_msdyn_dataanalyticsreport_fspredictrs)
- [organization_msdyn_dataanalyticsreport_fspredictwhd](#BKMK_organization_msdyn_dataanalyticsreport_fspredictwhd)
- [organization_msdyn_fieldservicepricelistitem](#BKMK_organization_msdyn_fieldservicepricelistitem)
- [organization_msdyn_fieldservicesystemjob](#BKMK_organization_msdyn_fieldservicesystemjob)
- [organization_msdyn_flwconfiguration](#BKMK_organization_msdyn_flwconfiguration)
- [organization_msdyn_geolocationsettings](#BKMK_organization_msdyn_geolocationsettings)
- [organization_msdyn_geolocationtracking](#BKMK_organization_msdyn_geolocationtracking)
- [organization_msdyn_organizationalunit](#BKMK_organization_msdyn_organizationalunit)
- [organization_msdyn_predictworkhourdurationsetting](#BKMK_organization_msdyn_predictworkhourdurationsetting)
- [organization_msdyn_productinventory](#BKMK_organization_msdyn_productinventory)
- [organization_msdyn_schedulingparameter](#BKMK_organization_msdyn_schedulingparameter)
- [organization_msdyn_uniquenumber](#BKMK_organization_msdyn_uniquenumber)
- [organization_msdyn_workorderdetailsgenerationqueue](#BKMK_organization_msdyn_workorderdetailsgenerationqueue)

### <a name="BKMK_organization_msdyn_3dmodel"></a> organization_msdyn_3dmodel

Many-To-One Relationship: [msdyn_3dmodel organization_msdyn_3dmodel](msdyn_3dmodel.md#BKMK_organization_msdyn_3dmodel)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_3dmodel`|
|ReferencingAttribute|`organizationid`|
|ReferencedEntityNavigationPropertyName|`organization_msdyn_3dmodel`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_organization_msdyn_assetsuggestionssetting"></a> organization_msdyn_assetsuggestionssetting

Many-To-One Relationship: [msdyn_assetsuggestionssetting organization_msdyn_assetsuggestionssetting](msdyn_assetsuggestionssetting.md#BKMK_organization_msdyn_assetsuggestionssetting)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_assetsuggestionssetting`|
|ReferencingAttribute|`organizationid`|
|ReferencedEntityNavigationPropertyName|`organization_msdyn_assetsuggestionssetting`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_organization_msdyn_bpf_2c5fe86acc8b414b8322ae571000c799"></a> organization_msdyn_bpf_2c5fe86acc8b414b8322ae571000c799

Many-To-One Relationship: [msdyn_bpf_2c5fe86acc8b414b8322ae571000c799 organization_msdyn_bpf_2c5fe86acc8b414b8322ae571000c799](msdyn_bpf_2c5fe86acc8b414b8322ae571000c799.md#BKMK_organization_msdyn_bpf_2c5fe86acc8b414b8322ae571000c799)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_bpf_2c5fe86acc8b414b8322ae571000c799`|
|ReferencingAttribute|`organizationid`|
|ReferencedEntityNavigationPropertyName|`organization_msdyn_bpf_2c5fe86acc8b414b8322ae571000c799`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_organization_msdyn_bpf_477c16f59170487b8b4dc895c5dcd09b"></a> organization_msdyn_bpf_477c16f59170487b8b4dc895c5dcd09b

Many-To-One Relationship: [msdyn_bpf_477c16f59170487b8b4dc895c5dcd09b organization_msdyn_bpf_477c16f59170487b8b4dc895c5dcd09b](msdyn_bpf_477c16f59170487b8b4dc895c5dcd09b.md#BKMK_organization_msdyn_bpf_477c16f59170487b8b4dc895c5dcd09b)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_bpf_477c16f59170487b8b4dc895c5dcd09b`|
|ReferencingAttribute|`organizationid`|
|ReferencedEntityNavigationPropertyName|`organization_msdyn_bpf_477c16f59170487b8b4dc895c5dcd09b`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_organization_msdyn_bpf_989e9b1857e24af18787d5143b67523b"></a> organization_msdyn_bpf_989e9b1857e24af18787d5143b67523b

Many-To-One Relationship: [msdyn_bpf_989e9b1857e24af18787d5143b67523b organization_msdyn_bpf_989e9b1857e24af18787d5143b67523b](msdyn_bpf_989e9b1857e24af18787d5143b67523b.md#BKMK_organization_msdyn_bpf_989e9b1857e24af18787d5143b67523b)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_bpf_989e9b1857e24af18787d5143b67523b`|
|ReferencingAttribute|`organizationid`|
|ReferencedEntityNavigationPropertyName|`organization_msdyn_bpf_989e9b1857e24af18787d5143b67523b`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_organization_msdyn_bpf_baa0a411a239410cb8bded8b5fdd88e3"></a> organization_msdyn_bpf_baa0a411a239410cb8bded8b5fdd88e3

Many-To-One Relationship: [msdyn_bpf_baa0a411a239410cb8bded8b5fdd88e3 organization_msdyn_bpf_baa0a411a239410cb8bded8b5fdd88e3](msdyn_bpf_baa0a411a239410cb8bded8b5fdd88e3.md#BKMK_organization_msdyn_bpf_baa0a411a239410cb8bded8b5fdd88e3)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_bpf_baa0a411a239410cb8bded8b5fdd88e3`|
|ReferencingAttribute|`organizationid`|
|ReferencedEntityNavigationPropertyName|`organization_msdyn_bpf_baa0a411a239410cb8bded8b5fdd88e3`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_organization_msdyn_bpf_d3d97bac8c294105840e99e37a9d1c39"></a> organization_msdyn_bpf_d3d97bac8c294105840e99e37a9d1c39

Many-To-One Relationship: [msdyn_bpf_d3d97bac8c294105840e99e37a9d1c39 organization_msdyn_bpf_d3d97bac8c294105840e99e37a9d1c39](msdyn_bpf_d3d97bac8c294105840e99e37a9d1c39.md#BKMK_organization_msdyn_bpf_d3d97bac8c294105840e99e37a9d1c39)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_bpf_d3d97bac8c294105840e99e37a9d1c39`|
|ReferencingAttribute|`organizationid`|
|ReferencedEntityNavigationPropertyName|`organization_msdyn_bpf_d3d97bac8c294105840e99e37a9d1c39`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_organization_msdyn_dataanalyticsreport_fs"></a> organization_msdyn_dataanalyticsreport_fs

Many-To-One Relationship: [msdyn_dataanalyticsreport_fs organization_msdyn_dataanalyticsreport_fs](msdyn_dataanalyticsreport_fs.md#BKMK_organization_msdyn_dataanalyticsreport_fs)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_dataanalyticsreport_fs`|
|ReferencingAttribute|`organizationid`|
|ReferencedEntityNavigationPropertyName|`organization_msdyn_dataanalyticsreport_fs`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_organization_msdyn_dataanalyticsreport_fspredictrs"></a> organization_msdyn_dataanalyticsreport_fspredictrs

Many-To-One Relationship: [msdyn_dataanalyticsreport_fspredictrs organization_msdyn_dataanalyticsreport_fspredictrs](msdyn_dataanalyticsreport_fspredictrs.md#BKMK_organization_msdyn_dataanalyticsreport_fspredictrs)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_dataanalyticsreport_fspredictrs`|
|ReferencingAttribute|`organizationid`|
|ReferencedEntityNavigationPropertyName|`organization_msdyn_dataanalyticsreport_fspredictrs`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_organization_msdyn_dataanalyticsreport_fspredictwhd"></a> organization_msdyn_dataanalyticsreport_fspredictwhd

Many-To-One Relationship: [msdyn_dataanalyticsreport_fspredictwhd organization_msdyn_dataanalyticsreport_fspredictwhd](msdyn_dataanalyticsreport_fspredictwhd.md#BKMK_organization_msdyn_dataanalyticsreport_fspredictwhd)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_dataanalyticsreport_fspredictwhd`|
|ReferencingAttribute|`organizationid`|
|ReferencedEntityNavigationPropertyName|`organization_msdyn_dataanalyticsreport_fspredictwhd`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_organization_msdyn_fieldservicepricelistitem"></a> organization_msdyn_fieldservicepricelistitem

Many-To-One Relationship: [msdyn_fieldservicepricelistitem organization_msdyn_fieldservicepricelistitem](msdyn_fieldservicepricelistitem.md#BKMK_organization_msdyn_fieldservicepricelistitem)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_fieldservicepricelistitem`|
|ReferencingAttribute|`organizationid`|
|ReferencedEntityNavigationPropertyName|`organization_msdyn_fieldservicepricelistitem`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_organization_msdyn_fieldservicesystemjob"></a> organization_msdyn_fieldservicesystemjob

Many-To-One Relationship: [msdyn_fieldservicesystemjob organization_msdyn_fieldservicesystemjob](msdyn_fieldservicesystemjob.md#BKMK_organization_msdyn_fieldservicesystemjob)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_fieldservicesystemjob`|
|ReferencingAttribute|`organizationid`|
|ReferencedEntityNavigationPropertyName|`organization_msdyn_fieldservicesystemjob`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_organization_msdyn_flwconfiguration"></a> organization_msdyn_flwconfiguration

Many-To-One Relationship: [msdyn_flwconfiguration organization_msdyn_flwconfiguration](msdyn_flwconfiguration.md#BKMK_organization_msdyn_flwconfiguration)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_flwconfiguration`|
|ReferencingAttribute|`organizationid`|
|ReferencedEntityNavigationPropertyName|`organization_msdyn_flwconfiguration`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_organization_msdyn_geolocationsettings"></a> organization_msdyn_geolocationsettings

Many-To-One Relationship: [msdyn_geolocationsettings organization_msdyn_geolocationsettings](msdyn_geolocationsettings.md#BKMK_organization_msdyn_geolocationsettings)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_geolocationsettings`|
|ReferencingAttribute|`organizationid`|
|ReferencedEntityNavigationPropertyName|`organization_msdyn_geolocationsettings`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_organization_msdyn_geolocationtracking"></a> organization_msdyn_geolocationtracking

Many-To-One Relationship: [msdyn_geolocationtracking organization_msdyn_geolocationtracking](msdyn_geolocationtracking.md#BKMK_organization_msdyn_geolocationtracking)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_geolocationtracking`|
|ReferencingAttribute|`organizationid`|
|ReferencedEntityNavigationPropertyName|`organization_msdyn_geolocationtracking`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_organization_msdyn_organizationalunit"></a> organization_msdyn_organizationalunit

Many-To-One Relationship: [msdyn_organizationalunit organization_msdyn_organizationalunit](msdyn_organizationalunit.md#BKMK_organization_msdyn_organizationalunit)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_organizationalunit`|
|ReferencingAttribute|`organizationid`|
|ReferencedEntityNavigationPropertyName|`organization_msdyn_organizationalunit`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_organization_msdyn_predictworkhourdurationsetting"></a> organization_msdyn_predictworkhourdurationsetting

Many-To-One Relationship: [msdyn_predictworkhourdurationsetting organization_msdyn_predictworkhourdurationsetting](msdyn_predictworkhourdurationsetting.md#BKMK_organization_msdyn_predictworkhourdurationsetting)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_predictworkhourdurationsetting`|
|ReferencingAttribute|`organizationid`|
|ReferencedEntityNavigationPropertyName|`organization_msdyn_predictworkhourdurationsetting`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_organization_msdyn_productinventory"></a> organization_msdyn_productinventory

Many-To-One Relationship: [msdyn_productinventory organization_msdyn_productinventory](msdyn_productinventory.md#BKMK_organization_msdyn_productinventory)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_productinventory`|
|ReferencingAttribute|`organizationid`|
|ReferencedEntityNavigationPropertyName|`organization_msdyn_productinventory`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_organization_msdyn_schedulingparameter"></a> organization_msdyn_schedulingparameter

Many-To-One Relationship: [msdyn_schedulingparameter organization_msdyn_schedulingparameter](msdyn_schedulingparameter.md#BKMK_organization_msdyn_schedulingparameter)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_schedulingparameter`|
|ReferencingAttribute|`organizationid`|
|ReferencedEntityNavigationPropertyName|`organization_msdyn_schedulingparameter`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_organization_msdyn_uniquenumber"></a> organization_msdyn_uniquenumber

Many-To-One Relationship: [msdyn_uniquenumber organization_msdyn_uniquenumber](msdyn_uniquenumber.md#BKMK_organization_msdyn_uniquenumber)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_uniquenumber`|
|ReferencingAttribute|`organizationid`|
|ReferencedEntityNavigationPropertyName|`organization_msdyn_uniquenumber`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_organization_msdyn_workorderdetailsgenerationqueue"></a> organization_msdyn_workorderdetailsgenerationqueue

Many-To-One Relationship: [msdyn_workorderdetailsgenerationqueue organization_msdyn_workorderdetailsgenerationqueue](msdyn_workorderdetailsgenerationqueue.md#BKMK_organization_msdyn_workorderdetailsgenerationqueue)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_workorderdetailsgenerationqueue`|
|ReferencingAttribute|`organizationid`|
|ReferencedEntityNavigationPropertyName|`organization_msdyn_workorderdetailsgenerationqueue`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|



### See also

[Dataverse table/entity reference](../about-entity-reference.md)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   
<xref:Microsoft.Dynamics.CRM.organization?displayProperty=fullName>
