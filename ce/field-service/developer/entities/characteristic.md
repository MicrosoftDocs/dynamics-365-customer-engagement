---
title: "Characteristic table/entity reference (Microsoft Dynamics 365 Field Service)"
description: "Includes schema information and supported messages for the Characteristic table/entity with Microsoft Dynamics 365 Field Service."
ms.date: 08/21/2024
ms.service: powerapps
ms.topic: reference
author: m-hartmann
ms.author: mhart
search.audienceType: 
  - developer
---

# Characteristic table/entity reference

Skills and Characteristics for front line worker

> [!NOTE]
> The Microsoft Dynamics 365 Field Service Characteristic table extends the [Microsoft Dynamics 365 Characteristic table](/dynamics365/developer/entities//characteristic).




## One-to-Many relationships

These relationships are one-to-many. Listed by **SchemaName**.

- [msdyn_characteristic_msdyn_incidenttypecharacteristic_Characteristic](#BKMK_msdyn_characteristic_msdyn_incidenttypecharacteristic_Characteristic)
- [msdyn_characteristic_msdyn_requirementcharacteristic_characteristic](#BKMK_msdyn_characteristic_msdyn_requirementcharacteristic_characteristic)
- [msdyn_characteristic_msdyn_workordercharacteristic_Characteristic](#BKMK_msdyn_characteristic_msdyn_workordercharacteristic_Characteristic)

### <a name="BKMK_msdyn_characteristic_msdyn_incidenttypecharacteristic_Characteristic"></a> msdyn_characteristic_msdyn_incidenttypecharacteristic_Characteristic

Many-To-One Relationship: [msdyn_incidenttypecharacteristic msdyn_characteristic_msdyn_incidenttypecharacteristic_Characteristic](msdyn_incidenttypecharacteristic.md#BKMK_msdyn_characteristic_msdyn_incidenttypecharacteristic_Characteristic)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_incidenttypecharacteristic`|
|ReferencingAttribute|`msdyn_characteristic`|
|ReferencedEntityNavigationPropertyName|`msdyn_characteristic_msdyn_incidenttypecharacteristic_Characteristic`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_characteristic_msdyn_requirementcharacteristic_characteristic"></a> msdyn_characteristic_msdyn_requirementcharacteristic_characteristic

Many-To-One Relationship: [msdyn_requirementcharacteristic msdyn_characteristic_msdyn_requirementcharacteristic_characteristic](msdyn_requirementcharacteristic.md#BKMK_msdyn_characteristic_msdyn_requirementcharacteristic_characteristic)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_requirementcharacteristic`|
|ReferencingAttribute|`msdyn_characteristic`|
|ReferencedEntityNavigationPropertyName|`msdyn_characteristic_msdyn_requirementcharacteristic_characteristic`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseLabel`<br />Group: `Details`<br />Label: Characteristics<br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_characteristic_msdyn_workordercharacteristic_Characteristic"></a> msdyn_characteristic_msdyn_workordercharacteristic_Characteristic

Many-To-One Relationship: [msdyn_workordercharacteristic msdyn_characteristic_msdyn_workordercharacteristic_Characteristic](msdyn_workordercharacteristic.md#BKMK_msdyn_characteristic_msdyn_workordercharacteristic_Characteristic)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_workordercharacteristic`|
|ReferencingAttribute|`msdyn_characteristic`|
|ReferencedEntityNavigationPropertyName|`msdyn_characteristic_msdyn_workordercharacteristic_Characteristic`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|



### See also

[Dataverse table/entity reference](../about-entity-reference.md)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   

