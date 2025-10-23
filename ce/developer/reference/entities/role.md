---
title: "Security Role (Role) table/entity reference (Microsoft Dynamics 365)"
description: "Includes schema information and supported messages for the Security Role (Role) table/entity with Microsoft Dynamics 365."
ms.topic: generated-reference
author: JimDaly
ms.author: jdaly
search.audienceType: 
  - developer
---

# Security Role (Role) table/entity reference (Microsoft Dynamics 365)

Grouping of security privileges. Users are assigned roles that authorize their access to the Microsoft CRM system.

> [!NOTE]
> The Microsoft Dynamics 365 Security Role (Role) table extends the [Microsoft Dataverse Security Role (Role) table](/power-apps/developer/data-platform/reference/entities/role).




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

[Dataverse table/entity reference](/power-apps/developer/data-platform/reference/about-entity-reference)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   
<xref:Microsoft.Dynamics.CRM.role?displayProperty=fullName>
