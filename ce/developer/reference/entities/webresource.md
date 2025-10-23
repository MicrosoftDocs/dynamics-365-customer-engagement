---
title: "Web Resource (WebResource) table/entity reference (Microsoft Dynamics 365)"
description: "Includes schema information and supported messages for the Web Resource (WebResource) table/entity with Microsoft Dynamics 365."
ms.topic: generated-reference
author: JimDaly
ms.author: jdaly
search.audienceType: 
  - developer
---

# Web Resource (WebResource) table/entity reference (Microsoft Dynamics 365)

Data equivalent to files used in Web development. Web resources provide client-side components that are used to provide custom user interface elements.

> [!NOTE]
> The Microsoft Dynamics 365 Web Resource (WebResource) table extends the [Microsoft Dataverse Web Resource (WebResource) table](/power-apps/developer/data-platform/reference/entities/webresource).




## One-to-Many relationships

These relationships are one-to-many. Listed by **SchemaName**.

- [msdyn_webresource_ciprovider_channelprovidericon](#BKMK_msdyn_webresource_ciprovider_channelprovidericon)
- [msdyn_webresource_msdyn_toolconfig_icon](#BKMK_msdyn_webresource_msdyn_toolconfig_icon)
- [msdyn_webresource_sessiontemplate_sessionicon](#BKMK_msdyn_webresource_sessiontemplate_sessionicon)

### <a name="BKMK_msdyn_webresource_ciprovider_channelprovidericon"></a> msdyn_webresource_ciprovider_channelprovidericon

Many-To-One Relationship: [msdyn_ciprovider msdyn_webresource_ciprovider_channelprovidericon](msdyn_ciprovider.md#BKMK_msdyn_webresource_ciprovider_channelprovidericon)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ciprovider`|
|ReferencingAttribute|`msdyn_channelprovidericon`|
|ReferencedEntityNavigationPropertyName|`msdyn_webresource_ciprovider_channelprovidericon`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_webresource_msdyn_toolconfig_icon"></a> msdyn_webresource_msdyn_toolconfig_icon

Many-To-One Relationship: [msdyn_panetoolconfiguration msdyn_webresource_msdyn_toolconfig_icon](msdyn_panetoolconfiguration.md#BKMK_msdyn_webresource_msdyn_toolconfig_icon)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_panetoolconfiguration`|
|ReferencingAttribute|`msdyn_icon`|
|ReferencedEntityNavigationPropertyName|`msdyn_webresource_msdyn_toolconfig_icon`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_webresource_sessiontemplate_sessionicon"></a> msdyn_webresource_sessiontemplate_sessionicon

Many-To-One Relationship: [msdyn_sessiontemplate msdyn_webresource_sessiontemplate_sessionicon](msdyn_sessiontemplate.md#BKMK_msdyn_webresource_sessiontemplate_sessionicon)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_sessiontemplate`|
|ReferencingAttribute|`msdyn_sessionicon`|
|ReferencedEntityNavigationPropertyName|`msdyn_webresource_sessiontemplate_sessionicon`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|



### See also

[Dataverse table/entity reference](/power-apps/developer/data-platform/reference/about-entity-reference)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   
<xref:Microsoft.Dynamics.CRM.webresource?displayProperty=fullName>
