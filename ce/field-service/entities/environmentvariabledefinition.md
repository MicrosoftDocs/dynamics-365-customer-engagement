---
title: "Environment Variable Definition (EnvironmentVariableDefinition) table/entity reference (Microsoft Dynamics 365 Field Service)"
description: "Includes schema information and supported messages for the Environment Variable Definition (EnvironmentVariableDefinition) table/entity with Microsoft Dynamics 365 Field Service."
ms.date: 07.24.2024
ms.service: powerapps
ms.topic: reference
author: m-hartmann
ms.author: mhart
search.audienceType: 
  - developer
---

# Environment Variable Definition (EnvironmentVariableDefinition) table/entity reference

Contains information about the settable variable: its type, default value, and etc.

> [!NOTE]
> The Microsoft Dynamics 365 Field Service Environment Variable Definition (EnvironmentVariableDefinition) table extends the [Microsoft Dataverse Environment Variable Definition (EnvironmentVariableDefinition) table](/power-apps/developer/data-platform/reference/entities/environmentvariabledefinition).




## Many-to-Many relationships

These relationships are many-to-many. Listed by **SchemaName**.

### <a name="BKMK_msdyn_connectordatasource_environmentvariable"></a> msdyn_connectordatasource_environmentvariable

See [msdyn_connectordatasource msdyn_connectordatasource_environmentvariable Many-To-Many Relationship](msdyn_connectordatasource.md#BKMK_msdyn_connectordatasource_environmentvariable)

|Property|Value|
|---|---|
|IntersectEntityName|`msdyn_connectordatasource_environmentva`|
|IsCustomizable|True|
|SchemaName|`msdyn_connectordatasource_environmentvariable`|
|IntersectAttribute|`environmentvariabledefinitionid`|
|NavigationPropertyName|`msdyn_connectordatasource_environmentvari`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|



### See also

[Dataverse table/entity reference](../about-entity-reference.md)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   
<xref:Microsoft.Dynamics.CRM.environmentvariabledefinition?displayProperty=fullName>
