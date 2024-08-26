---
title: "Sales Literature (SalesLiterature) table/entity reference (Microsoft Dynamics 365 Customer Service)"
description: "Includes schema information and supported messages for the Sales Literature (SalesLiterature) table/entity with Microsoft Dynamics 365 Customer Service."
ms.date: 08/26/2024
ms.service: powerapps
ms.topic: reference
author: gandhamm
ms.author: mgandham
search.audienceType: 
  - developer
---

# Sales Literature (SalesLiterature) table/entity reference (Microsoft Dynamics 365 Customer Service)

Storage of sales literature, which may contain one or more documents.

> [!NOTE]
> The Microsoft Dynamics 365 Customer Service Sales Literature (SalesLiterature) table extends the [Microsoft Dynamics 365 Sales Literature (SalesLiterature) table](/dynamics365/developer/entities/salesliterature).




## Many-to-One relationships

These relationships are many-to-one. Listed by **SchemaName**.

### <a name="BKMK_TransactionCurrency_SalesLiterature"></a> TransactionCurrency_SalesLiterature

One-To-Many Relationship: [transactioncurrency TransactionCurrency_SalesLiterature](transactioncurrency.md#BKMK_TransactionCurrency_SalesLiterature)

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

