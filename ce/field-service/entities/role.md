---
title: "Security Role (Role) table/entity reference (Microsoft Dynamics 365 Field Service)"
description: "Includes schema information and supported messages for the Security Role (Role) table/entity with Microsoft Dynamics 365 Field Service."
ms.date: 07.24.2024
ms.service: powerapps
ms.topic: reference
author: m-hartmann
ms.author: mhart
search.audienceType: 
  - developer
---

# Security Role (Role) table/entity reference

Grouping of security privileges. Users are assigned roles that authorize their access to the Microsoft CRM system.

> [!NOTE]
> The Microsoft Dynamics 365 Field Service Security Role (Role) table extends the [Microsoft Dataverse Security Role (Role) table](/power-apps/developer/data-platform/reference/entities/role).



## Writable columns/attributes

These columns/attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [AppliesTo](#BKMK_AppliesTo)
- [Description](#BKMK_Description)
- [IsAutoAssigned](#BKMK_IsAutoAssigned)
- [SummaryofCoreTablePermissions](#BKMK_SummaryofCoreTablePermissions)

### <a name="BKMK_AppliesTo"></a> AppliesTo

|Property|Value|
|---|---|
|Description|**Personas/Licenses the security role applies to**|
|DisplayName|**Applies To**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`appliesto`|
|RequiredLevel|ApplicationRequired|
|Type|String|
|Format|TextArea|
|FormatName|TextArea|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_Description"></a> Description

|Property|Value|
|---|---|
|Description|**Description of the security role**|
|DisplayName|**Description**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`description`|
|RequiredLevel|ApplicationRequired|
|Type|String|
|Format|TextArea|
|FormatName|TextArea|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_IsAutoAssigned"></a> IsAutoAssigned

|Property|Value|
|---|---|
|Description|**Value indicating whether security role is auto-assigned based on user license**|
|DisplayName|**Is Auto Assigned**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`isautoassigned`|
|RequiredLevel|ApplicationRequired|
|Type|Picklist|
|DefaultFormValue||
|GlobalChoiceName|`securityrole_isautoassigned`|

#### IsAutoAssigned Choices/Options

|Value|Label|
|---|---|
|0|**No**|
|1|**Yes**|

### <a name="BKMK_SummaryofCoreTablePermissions"></a> SummaryofCoreTablePermissions

|Property|Value|
|---|---|
|Description|**Summary of Core Table Permissions of the Role**|
|DisplayName|**Summary of Core Table Permissions**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`summaryofcoretablepermissions`|
|RequiredLevel|ApplicationRequired|
|Type|Memo|
|Format|TextArea|
|FormatName|TextArea|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|2000|


## One-to-Many relationships

These relationships are one-to-many. Listed by **SchemaName**.

- [lk_msdyn_roleid](#BKMK_lk_msdyn_roleid)
- [msdyn_role_msdyn_personasecurityrolemapping](#BKMK_msdyn_role_msdyn_personasecurityrolemapping)
- [msdyn_role_msdyn_servicecopilotpluginrole_roleid](#BKMK_msdyn_role_msdyn_servicecopilotpluginrole_roleid)
- [role_msdyn_appprofilerolemapping](#BKMK_role_msdyn_appprofilerolemapping)

### <a name="BKMK_lk_msdyn_roleid"></a> lk_msdyn_roleid

Many-To-One Relationship: [msdyn_actioncardrolesetting lk_msdyn_roleid](msdyn_actioncardrolesetting.md#BKMK_lk_msdyn_roleid)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_actioncardrolesetting`|
|ReferencingAttribute|`msdyn_roleid`|
|ReferencedEntityNavigationPropertyName|`msdyn_role_msdyn_actioncardrolesetting`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_role_msdyn_personasecurityrolemapping"></a> msdyn_role_msdyn_personasecurityrolemapping

Many-To-One Relationship: [msdyn_personasecurityrolemapping msdyn_role_msdyn_personasecurityrolemapping](msdyn_personasecurityrolemapping.md#BKMK_msdyn_role_msdyn_personasecurityrolemapping)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_personasecurityrolemapping`|
|ReferencingAttribute|`msdyn_securityroleid`|
|ReferencedEntityNavigationPropertyName|`msdyn_role_msdyn_personasecurityrolemapping`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_role_msdyn_servicecopilotpluginrole_roleid"></a> msdyn_role_msdyn_servicecopilotpluginrole_roleid

Many-To-One Relationship: [msdyn_servicecopilotpluginrole msdyn_role_msdyn_servicecopilotpluginrole_roleid](msdyn_servicecopilotpluginrole.md#BKMK_msdyn_role_msdyn_servicecopilotpluginrole_roleid)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_servicecopilotpluginrole`|
|ReferencingAttribute|`msdyn_roleid`|
|ReferencedEntityNavigationPropertyName|`msdyn_role_msdyn_servicecopilotpluginrole_roleid`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_role_msdyn_appprofilerolemapping"></a> role_msdyn_appprofilerolemapping

Many-To-One Relationship: [msdyn_appprofilerolemapping role_msdyn_appprofilerolemapping](msdyn_appprofilerolemapping.md#BKMK_role_msdyn_appprofilerolemapping)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_appprofilerolemapping`|
|ReferencingAttribute|`msdyn_securityroleid`|
|ReferencedEntityNavigationPropertyName|`role_msdyn_appprofilerolemapping`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|



### See also

[Dataverse table/entity reference](../about-entity-reference.md)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   
<xref:Microsoft.Dynamics.CRM.role?displayProperty=fullName>
