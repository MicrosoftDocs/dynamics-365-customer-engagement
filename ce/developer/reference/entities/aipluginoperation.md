---
title: "AIPluginOperation table/entity reference (Microsoft Dynamics 365)"
description: "Includes schema information and supported messages for the AIPluginOperation table/entity with Microsoft Dynamics 365."
ms.topic: generated-reference
author: JimDaly
ms.author: jdaly
search.audienceType: 
  - developer
---

# AIPluginOperation table/entity reference (Microsoft Dynamics 365)

AIPluginOperations component

> [!NOTE]
> The Microsoft Dynamics 365 AIPluginOperation table extends the [Microsoft Dataverse AIPluginOperation table](/power-apps/developer/data-platform/reference/entities/aipluginoperation).




## One-to-Many relationships

These relationships are one-to-many. Listed by **SchemaName**.

### <a name="BKMK_msdyn_aipluginoperation_msdyn_servicecopilotpluginaction_aipluginoperationid"></a> msdyn_aipluginoperation_msdyn_servicecopilotpluginaction_aipluginoperationid

Many-To-One Relationship: [msdyn_servicecopilotpluginaction msdyn_aipluginoperation_msdyn_servicecopilotpluginaction_aipluginoperationid](msdyn_servicecopilotpluginaction.md#BKMK_msdyn_aipluginoperation_msdyn_servicecopilotpluginaction_aipluginoperationid)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_servicecopilotpluginaction`|
|ReferencingAttribute|`msdyn_aipluginoperationid`|
|ReferencedEntityNavigationPropertyName|`msdyn_aipluginoperation_msdyn_servicecopilotpluginaction_aipluginoperationid`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|



### See also

[Dataverse table/entity reference](/power-apps/developer/data-platform/reference/about-entity-reference)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   
<xref:Microsoft.Dynamics.CRM.aipluginoperation?displayProperty=fullName>
