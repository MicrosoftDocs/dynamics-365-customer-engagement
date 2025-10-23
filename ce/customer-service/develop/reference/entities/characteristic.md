---
title: "Characteristic table/entity reference (Microsoft Dynamics 365 Customer Service)"
description: "Includes schema information and supported messages for the Characteristic table/entity with Microsoft Dynamics 365 Customer Service."
ms.topic: generated-reference
author: gandhamm
ms.author: mgandham
search.audienceType: 
  - developer
---

# Characteristic table/entity reference (Microsoft Dynamics 365 Customer Service)

Skills, education and certifications of resources.

> [!NOTE]
> The Microsoft Dynamics 365 Customer Service Characteristic table extends the [Microsoft Dynamics 365 Characteristic table](/dynamics365/developer/reference/entities/characteristic).




## One-to-Many relationships

These relationships are one-to-many. Listed by **SchemaName**.

- [msdyn_characteristic_msdyn_requirementcharacteristic_characteristic](#BKMK_msdyn_characteristic_msdyn_requirementcharacteristic_characteristic)
- [msdyn_proactive_eng_config_characteristic_characteristic_characteristic](#BKMK_msdyn_proactive_eng_config_characteristic_characteristic_characteristic)

### <a name="BKMK_msdyn_characteristic_msdyn_requirementcharacteristic_characteristic"></a> msdyn_characteristic_msdyn_requirementcharacteristic_characteristic

Many-To-One Relationship: [msdyn_requirementcharacteristic msdyn_characteristic_msdyn_requirementcharacteristic_characteristic](msdyn_requirementcharacteristic.md#BKMK_msdyn_characteristic_msdyn_requirementcharacteristic_characteristic)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_requirementcharacteristic`|
|ReferencingAttribute|`msdyn_characteristic`|
|ReferencedEntityNavigationPropertyName|`msdyn_characteristic_msdyn_requirementcharacteristic_characteristic`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseLabel`<br />Group: `Details`<br />Label: Characteristics<br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_proactive_eng_config_characteristic_characteristic_characteristic"></a> msdyn_proactive_eng_config_characteristic_characteristic_characteristic

Many-To-One Relationship: [msdyn_proactive_eng_config_characteristic msdyn_proactive_eng_config_characteristic_characteristic_characteristic](msdyn_proactive_eng_config_characteristic.md#BKMK_msdyn_proactive_eng_config_characteristic_characteristic_characteristic)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_proactive_eng_config_characteristic`|
|ReferencingAttribute|`msdyn_characteristic`|
|ReferencedEntityNavigationPropertyName|`msdyn_proactive_eng_config_characteristic_characteristic_characteristic`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|



### See also

[Dataverse table/entity reference](/power-apps/developer/data-platform/reference/about-entity-reference)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   

