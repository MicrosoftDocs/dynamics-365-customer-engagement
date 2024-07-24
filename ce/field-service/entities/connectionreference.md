---
title: "Connection Reference (connectionreference) table/entity reference (Microsoft Dynamics 365 Field Service)"
description: "Includes schema information and supported messages for the Connection Reference (connectionreference) table/entity with Microsoft Dynamics 365 Field Service."
ms.date: 07.24.2024
ms.service: powerapps
ms.topic: reference
author: m-hartmann
ms.author: mhart
search.audienceType: 
  - developer
---

# Connection Reference (connectionreference) table/entity reference



> [!NOTE]
> The Microsoft Dynamics 365 Field Service Connection Reference (connectionreference) table extends the [Microsoft Dataverse Connection Reference (connectionreference) table](/power-apps/developer/data-platform/reference/entities/connectionreference).




## One-to-Many relationships

These relationships are one-to-many. Listed by **SchemaName**.

### <a name="BKMK_connectionreference_federatedknowledgeconfiguration"></a> connectionreference_federatedknowledgeconfiguration

Many-To-One Relationship: [federatedknowledgeconfiguration connectionreference_federatedknowledgeconfiguration](federatedknowledgeconfiguration.md#BKMK_connectionreference_federatedknowledgeconfiguration)

|Property|Value|
|---|---|
|ReferencingEntity|`federatedknowledgeconfiguration`|
|ReferencingAttribute|`connectionreference`|
|ReferencedEntityNavigationPropertyName|`connectionreference_federatedknowledgeconfiguration`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|



### See also

[Dataverse table/entity reference](../about-entity-reference.md)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   
<xref:Microsoft.Dynamics.CRM.connectionreference?displayProperty=fullName>
