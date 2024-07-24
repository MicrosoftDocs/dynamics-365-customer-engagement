---
title: "Virtual Connector Data Source (msdyn_connectordatasource) table/entity reference (Microsoft Dynamics 365 Field Service)"
description: "Includes schema information and supported messages for the Virtual Connector Data Source (msdyn_connectordatasource) table/entity with Microsoft Dynamics 365 Field Service."
ms.date: 07.24.2024
ms.service: powerapps
ms.topic: reference
author: m-hartmann
ms.author: mhart
search.audienceType: 
  - developer
---

# Virtual Connector Data Source (msdyn_connectordatasource) table/entity reference



> [!NOTE]
> The Microsoft Dynamics 365 Field Service Virtual Connector Data Source (msdyn_connectordatasource) table extends the [Microsoft Dataverse Virtual Connector Data Source (msdyn_connectordatasource) table](/power-apps/developer/data-platform/reference/entities/msdyn_connectordatasource).



## Writable columns/attributes

These columns/attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

### <a name="BKMK_msdyn_dataset_unresolvedvalue"></a> msdyn_dataset_unresolvedvalue

|Property|Value|
|---|---|
|Description||
|DisplayName|**Dataset Unresolved Value**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_dataset_unresolvedvalue`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|4000|


## Many-to-Many relationships

These relationships are many-to-many. Listed by **SchemaName**.

### <a name="BKMK_msdyn_connectordatasource_environmentvariable"></a> msdyn_connectordatasource_environmentvariable

See [environmentvariabledefinition msdyn_connectordatasource_environmentvariable Many-To-Many Relationship](environmentvariabledefinition.md#BKMK_msdyn_connectordatasource_environmentvariable)

|Property|Value|
|---|---|
|IntersectEntityName|`msdyn_connectordatasource_environmentva`|
|IsCustomizable|True|
|SchemaName|`msdyn_connectordatasource_environmentvariable`|
|IntersectAttribute|`msdyn_connectordatasourceid`|
|NavigationPropertyName|`msdyn_connectordatasource_environmentvari`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|



### See also

[Dataverse table/entity reference](../about-entity-reference.md)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   
<xref:Microsoft.Dynamics.CRM.msdyn_connectordatasource?displayProperty=fullName>
