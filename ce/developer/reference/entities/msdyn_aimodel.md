---
title: "AI Model (msdyn_AIModel) table/entity reference (Microsoft Dynamics 365)"
description: "Includes schema information and supported messages for the AI Model (msdyn_AIModel) table/entity with Microsoft Dynamics 365."
ms.topic: generated-reference
author: JimDaly
ms.author: jdaly
search.audienceType: 
  - developer
---

# AI Model (msdyn_AIModel) table/entity reference (Microsoft Dynamics 365)



> [!NOTE]
> The Microsoft Dynamics 365 AI Model (msdyn_AIModel) table extends the [Microsoft Dataverse AI Model (msdyn_AIModel) table](/power-apps/developer/data-platform/reference/entities/msdyn_aimodel).




## One-to-Many relationships

These relationships are one-to-many. Listed by **SchemaName**.

- [msdyn_aimodel_msdyn_decisionruleset_aibmodelid](#BKMK_msdyn_aimodel_msdyn_decisionruleset_aibmodelid)
- [msdyn_iermlmodel_aimodelid_msdyn](#BKMK_msdyn_iermlmodel_aimodelid_msdyn)
- [msdyn_msdyn_aimodel_msdyn_effortpredictionresult_msdyn_aimodelid](#BKMK_msdyn_msdyn_aimodel_msdyn_effortpredictionresult_msdyn_aimodelid)
- [msdyn_ocliveworkitemcharacteristic_mlmodelid](#BKMK_msdyn_ocliveworkitemcharacteristic_mlmodelid)
- [msdyn_ocskillidentmlmodel_aimodelid_msdyn](#BKMK_msdyn_ocskillidentmlmodel_aimodelid_msdyn)

### <a name="BKMK_msdyn_aimodel_msdyn_decisionruleset_aibmodelid"></a> msdyn_aimodel_msdyn_decisionruleset_aibmodelid

Many-To-One Relationship: [msdyn_decisionruleset msdyn_aimodel_msdyn_decisionruleset_aibmodelid](msdyn_decisionruleset.md#BKMK_msdyn_aimodel_msdyn_decisionruleset_aibmodelid)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_decisionruleset`|
|ReferencingAttribute|`msdyn_aibmodelid`|
|ReferencedEntityNavigationPropertyName|`msdyn_aimodel_msdyn_decisionruleset_aibmodelid`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_iermlmodel_aimodelid_msdyn"></a> msdyn_iermlmodel_aimodelid_msdyn

Many-To-One Relationship: [msdyn_iermlmodel msdyn_iermlmodel_aimodelid_msdyn](msdyn_iermlmodel.md#BKMK_msdyn_iermlmodel_aimodelid_msdyn)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_iermlmodel`|
|ReferencingAttribute|`msdyn_aimodelid`|
|ReferencedEntityNavigationPropertyName|`msdyn_iermlmodel_aimodelid_msdyn`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_msdyn_aimodel_msdyn_effortpredictionresult_msdyn_aimodelid"></a> msdyn_msdyn_aimodel_msdyn_effortpredictionresult_msdyn_aimodelid

Many-To-One Relationship: [msdyn_effortpredictionresult msdyn_msdyn_aimodel_msdyn_effortpredictionresult_msdyn_aimodelid](msdyn_effortpredictionresult.md#BKMK_msdyn_msdyn_aimodel_msdyn_effortpredictionresult_msdyn_aimodelid)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_effortpredictionresult`|
|ReferencingAttribute|`msdyn_aimodelid`|
|ReferencedEntityNavigationPropertyName|`msdyn_msdyn_aimodel_msdyn_effortpredictionresult_msdyn_aimodelid`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_ocliveworkitemcharacteristic_mlmodelid"></a> msdyn_ocliveworkitemcharacteristic_mlmodelid

Many-To-One Relationship: [msdyn_ocliveworkitemcharacteristic msdyn_ocliveworkitemcharacteristic_mlmodelid](msdyn_ocliveworkitemcharacteristic.md#BKMK_msdyn_ocliveworkitemcharacteristic_mlmodelid)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocliveworkitemcharacteristic`|
|ReferencingAttribute|`msdyn_mlmodelid`|
|ReferencedEntityNavigationPropertyName|`msdyn_ocliveworkitemcharacteristic_mlmodelid`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_ocskillidentmlmodel_aimodelid_msdyn"></a> msdyn_ocskillidentmlmodel_aimodelid_msdyn

Many-To-One Relationship: [msdyn_ocskillidentmlmodel msdyn_ocskillidentmlmodel_aimodelid_msdyn](msdyn_ocskillidentmlmodel.md#BKMK_msdyn_ocskillidentmlmodel_aimodelid_msdyn)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocskillidentmlmodel`|
|ReferencingAttribute|`msdyn_aimodelid`|
|ReferencedEntityNavigationPropertyName|`msdyn_ocskillidentmlmodel_aimodelid_msdyn`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|



### See also

[Dataverse table/entity reference](/power-apps/developer/data-platform/reference/about-entity-reference)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   
<xref:Microsoft.Dynamics.CRM.msdyn_aimodel?displayProperty=fullName>
