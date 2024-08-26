---
title: "connector table/entity reference (Microsoft Dynamics 365)"
description: "Includes schema information and supported messages for the connector table/entity with Microsoft Dynamics 365."
ms.date: 08/26/2024
ms.service: powerapps
ms.topic: reference
author: JimDaly
ms.author: jdaly
search.audienceType: 
  - developer
---

# connector table/entity reference (Microsoft Dynamics 365)

Connector Entity to support Solutioning Integration

> [!NOTE]
> The Microsoft Dynamics 365 connector table extends the [Microsoft Dataverse connector table](/power-apps/developer/data-platform/reference/entities/connector).




## One-to-Many relationships

These relationships are one-to-many. Listed by **SchemaName**.

### <a name="BKMK_AIPluginOperation_connector_connector"></a> AIPluginOperation_connector_connector

Many-To-One Relationship: [aipluginoperation AIPluginOperation_connector_connector](aipluginoperation.md#BKMK_AIPluginOperation_connector_connector)

|Property|Value|
|---|---|
|ReferencingEntity|`aipluginoperation`|
|ReferencingAttribute|`connector`|
|ReferencedEntityNavigationPropertyName|`AIPluginOperation_connector_connector`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|



### See also

[Dataverse table/entity reference](../about-entity-reference.md)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   
<xref:Microsoft.Dynamics.CRM.connector?displayProperty=fullName>
