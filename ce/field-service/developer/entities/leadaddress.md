---
title: "Lead Address (LeadAddress) table/entity reference (Microsoft Dynamics 365 Field Service)"
description: "Includes schema information and supported messages for the Lead Address (LeadAddress) table/entity with Microsoft Dynamics 365 Field Service."
ms.date: 08/26/2024
ms.service: powerapps
ms.topic: reference
author: m-hartmann
ms.author: mhart
search.audienceType: 
  - developer
---

# Lead Address (LeadAddress) table/entity reference (Microsoft Dynamics 365 Field Service)

Address information for a lead.

> [!NOTE]
> The Microsoft Dynamics 365 Field Service Lead Address (LeadAddress) table extends the [Microsoft Dynamics 365 Lead Address (LeadAddress) table](/dynamics365/developer/entities/leadaddress).




## Many-to-One relationships

These relationships are many-to-one. Listed by **SchemaName**.

### <a name="BKMK_TransactionCurrency_LeadAddress"></a> TransactionCurrency_LeadAddress

One-To-Many Relationship: [transactioncurrency TransactionCurrency_LeadAddress](transactioncurrency.md#BKMK_TransactionCurrency_LeadAddress)

|Property|Value|
|---|---|
|ReferencedEntity|`transactioncurrency`|
|ReferencedAttribute|`transactioncurrencyid`|
|ReferencingAttribute|`transactioncurrencyid`|
|ReferencingEntityNavigationPropertyName|`transactioncurrencyid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Restrict`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|



### See also

[Dataverse table/entity reference](../about-entity-reference.md)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   

