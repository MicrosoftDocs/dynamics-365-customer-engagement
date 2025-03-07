---
title: "IoT Alert (msdyn_iotalert) table/entity reference (Microsoft Dynamics 365 Field Service)"
description: "Includes schema information and supported messages for the IoT Alert (msdyn_iotalert) table/entity with Microsoft Dynamics 365 Field Service."
ms.topic: generated-reference
author: m-hartmann
ms.author: mhart
search.audienceType: 
  - developer
---

# IoT Alert (msdyn_iotalert) table/entity reference (Microsoft Dynamics 365 Field Service)



> [!NOTE]
> The Microsoft Dynamics 365 Field Service IoT Alert (msdyn_iotalert) table extends the [Microsoft Dynamics 365 IoT Alert (msdyn_iotalert) table](/dynamics365/developer/reference/entities/msdyn_iotalert).



## Writable columns/attributes

These columns/attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [msdyn_suggestedincidenttype](#BKMK_msdyn_suggestedincidenttype)
- [msdyn_Workorder](#BKMK_msdyn_Workorder)

### <a name="BKMK_msdyn_suggestedincidenttype"></a> msdyn_suggestedincidenttype

|Property|Value|
|---|---|
|Description|**The suggested incident type for this alert**|
|DisplayName|**Incident Type**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_suggestedincidenttype`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|msdyn_incidenttype|

### <a name="BKMK_msdyn_Workorder"></a> msdyn_Workorder

|Property|Value|
|---|---|
|Description|**Work order created for this iot alert.**|
|DisplayName|**Work Order**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_workorder`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|msdyn_workorder|


## Customized columns/attributes

Microsoft Dynamics 365 Field Service modifies the definition of columns/attributes defined in other solutions. Listed by **SchemaName**.

### <a name="BKMK_statuscode"></a> statuscode

Changes from [statuscode (Microsoft Dynamics 365)](/dynamics365/developer/reference/entities/msdyn_iotalert#BKMK_statuscode)

#### statuscode Choices/Options

|Value|Details|
|---|---|
|4|Label: In Progress - Work Order Created<br />State: 2|
|7|Label: In Progress - Command Failed<br />State: 2|

## Many-to-One relationships

These relationships are many-to-one. Listed by **SchemaName**.

- [msdyn_msdyn_incidenttype_msdyn_iotalert_IncidentType](#BKMK_msdyn_msdyn_incidenttype_msdyn_iotalert_IncidentType)
- [msdyn_msdyn_workorder_msdyn_iotalert_Workorder](#BKMK_msdyn_msdyn_workorder_msdyn_iotalert_Workorder)

### <a name="BKMK_msdyn_msdyn_incidenttype_msdyn_iotalert_IncidentType"></a> msdyn_msdyn_incidenttype_msdyn_iotalert_IncidentType

One-To-Many Relationship: [msdyn_incidenttype msdyn_msdyn_incidenttype_msdyn_iotalert_IncidentType](msdyn_incidenttype.md#BKMK_msdyn_msdyn_incidenttype_msdyn_iotalert_IncidentType)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_incidenttype`|
|ReferencedAttribute|`msdyn_incidenttypeid`|
|ReferencingAttribute|`msdyn_suggestedincidenttype`|
|ReferencingEntityNavigationPropertyName|`msdyn_suggestedincidenttype`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_msdyn_workorder_msdyn_iotalert_Workorder"></a> msdyn_msdyn_workorder_msdyn_iotalert_Workorder

One-To-Many Relationship: [msdyn_workorder msdyn_msdyn_workorder_msdyn_iotalert_Workorder](msdyn_workorder.md#BKMK_msdyn_msdyn_workorder_msdyn_iotalert_Workorder)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_workorder`|
|ReferencedAttribute|`msdyn_workorderid`|
|ReferencingAttribute|`msdyn_workorder`|
|ReferencingEntityNavigationPropertyName|`msdyn_Workorder`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|


## One-to-Many relationships

These relationships are one-to-many. Listed by **SchemaName**.

### <a name="BKMK_msdyn_msdyn_iotalert_msdyn_workorder_IoTAlert"></a> msdyn_msdyn_iotalert_msdyn_workorder_IoTAlert

Many-To-One Relationship: [msdyn_workorder msdyn_msdyn_iotalert_msdyn_workorder_IoTAlert](msdyn_workorder.md#BKMK_msdyn_msdyn_iotalert_msdyn_workorder_IoTAlert)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_workorder`|
|ReferencingAttribute|`msdyn_iotalert`|
|ReferencedEntityNavigationPropertyName|`msdyn_msdyn_iotalert_msdyn_workorder_IoTAlert`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|



### See also

[Dataverse table/entity reference](/power-apps/developer/data-platform/reference/about-entity-reference)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   

