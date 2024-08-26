---
title: "Organization table/entity reference (Microsoft Dynamics 365 Customer Service)"
description: "Includes schema information and supported messages for the Organization table/entity with Microsoft Dynamics 365 Customer Service."
ms.date: 08/26/2024
ms.service: powerapps
ms.topic: reference
author: gandhamm
ms.author: mgandham
search.audienceType: 
  - developer
---

# Organization table/entity reference (Microsoft Dynamics 365 Customer Service)

Top level of the Microsoft Dynamics 365 business hierarchy. The organization can be a specific business, holding company, or corporation.

> [!NOTE]
> The Microsoft Dynamics 365 Customer Service Organization table extends the [Microsoft Dynamics 365 Organization table](/dynamics365/developer/entities/organization).



## Customized columns/attributes

Microsoft Dynamics 365 Customer Service modifies the definition of columns/attributes defined in other solutions. Listed by **SchemaName**.

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

Changes from [EmailTemplateDefaultView (Microsoft Dynamics 365)](/dynamics365/developer/entities/organization#BKMK_EmailTemplateDefaultView)

|Property|Value|
|---|---|
|RequiredLevel|SystemRequired|
|DefaultFormValue||


### <a name="BKMK_EnableCalendarImportExport"></a> EnableCalendarImportExport

Changes from [EnableCalendarImportExport (Microsoft Dynamics 365)](/dynamics365/developer/entities/organization#BKMK_EnableCalendarImportExport)

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

Changes from [SchedulingEngine (Microsoft Dynamics 365)](/dynamics365/developer/entities/organization#BKMK_SchedulingEngine)

#### SchedulingEngine Choices/Options

|Value|Label|
|---|---|
|192350000|**(Deprecated) Universal Resource Scheduling**|

## One-to-Many relationships

These relationships are one-to-many. Listed by **SchemaName**.

- [organization_msdyn_organizationalunit](#BKMK_organization_msdyn_organizationalunit)
- [organization_msdyn_schedulingparameter](#BKMK_organization_msdyn_schedulingparameter)

### <a name="BKMK_organization_msdyn_organizationalunit"></a> organization_msdyn_organizationalunit

Many-To-One Relationship: [msdyn_organizationalunit organization_msdyn_organizationalunit](msdyn_organizationalunit.md#BKMK_organization_msdyn_organizationalunit)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_organizationalunit`|
|ReferencingAttribute|`organizationid`|
|ReferencedEntityNavigationPropertyName|`organization_msdyn_organizationalunit`|
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



### See also

[Dataverse table/entity reference](../about-entity-reference.md)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   
<xref:Microsoft.Dynamics.CRM.organization?displayProperty=fullName>
