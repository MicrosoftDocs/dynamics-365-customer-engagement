---
title: "AIPlugin table/entity reference (Microsoft Dynamics 365 Field Service)"
description: "Includes schema information and supported messages for the AIPlugin table/entity with Microsoft Dynamics 365 Field Service."
ms.date: 07.24.2024
ms.service: powerapps
ms.topic: reference
author: m-hartmann
ms.author: mhart
search.audienceType: 
  - developer
---

# AIPlugin table/entity reference

AIPlugins component

> [!NOTE]
> The Microsoft Dynamics 365 Field Service AIPlugin table extends the [Microsoft Dataverse AIPlugin table](/power-apps/developer/data-platform/reference/entities/aiplugin).



## Customized columns/attributes

Microsoft Dynamics 365 Field Service modifies the definition of columns/attributes defined in other solutions. Listed by **SchemaName**.

### <a name="BKMK_PluginSubType"></a> PluginSubType

Changes from [PluginSubType (Microsoft Dataverse)](/power-apps/developer/data-platform/reference/entities/aiplugin#BKMK_PluginSubType)

|Property|Value|
|---|---|
|RequiredLevel|None|


## One-to-Many relationships

These relationships are one-to-many. Listed by **SchemaName**.

### <a name="BKMK_msdyn_aiplugin_msdyn_servicecopilotplugin_aipluginid"></a> msdyn_aiplugin_msdyn_servicecopilotplugin_aipluginid

Many-To-One Relationship: [msdyn_servicecopilotplugin msdyn_aiplugin_msdyn_servicecopilotplugin_aipluginid](msdyn_servicecopilotplugin.md#BKMK_msdyn_aiplugin_msdyn_servicecopilotplugin_aipluginid)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_servicecopilotplugin`|
|ReferencingAttribute|`msdyn_aipluginid`|
|ReferencedEntityNavigationPropertyName|`msdyn_aiplugin_msdyn_servicecopilotplugin_aipluginid`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|



### See also

[Dataverse table/entity reference](../about-entity-reference.md)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   
<xref:Microsoft.Dynamics.CRM.aiplugin?displayProperty=fullName>
