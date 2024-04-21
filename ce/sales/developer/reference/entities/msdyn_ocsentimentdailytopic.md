---
title: "Sentiment daily topic (msdyn_ocsentimentdailytopic) table/entity reference (Microsoft Dynamics 365 Sales) | Microsoft Docs"
description: "Includes schema information and supported messages for the Sentiment daily topic (msdyn_ocsentimentdailytopic) table/entity with Microsoft Dynamics 365 Sales."
ms.date: 04/21/2024
ms.service: powerapps
ms.topic: reference
author: JimDaly
ms.author: jdaly
search.audienceType: 
  - developer
---

# Sentiment daily topic (msdyn_ocsentimentdailytopic) table/entity reference

1. store properties regarding each topic cluster
2. used for dashboard visualization (like topic example) and calculation for topic mapping

> [!NOTE]
> The Microsoft Dynamics 365 Sales Sentiment daily topic (msdyn_ocsentimentdailytopic) table extends [Sentiment daily topic (msdyn_ocsentimentdailytopic) table (Microsoft Dynamics 365)](/dynamics365/developer/reference/dataverse/entities/msdyn_ocsentimentdailytopic).
>
> This reference contains only the changes added by Microsoft Dynamics 365 Sales.
> See the [Sentiment daily topic (msdyn_ocsentimentdailytopic) table (Microsoft Dynamics 365)](/dynamics365/developer/reference/dataverse/entities/msdyn_ocsentimentdailytopic) reference documentation for more information.



## Customized columns/attributes

Microsoft Dynamics 365 Sales
modifies the definition of columns/attributes defined in other solutions. Listed by **SchemaName**.

### <a name="BKMK_msdyn_topicindex"></a> msdyn_topicindex

Changes from [msdyn_topicindex (Microsoft Dynamics 365)](/dynamics365/developer/reference/dataverse/entities/msdyn_ocsentimentdailytopic#BKMK_msdyn_topicindex):

|Property|Value|
|---|---|
|Description|The topic cluster id from clustering algorithm
-1 represent outlier cluster
Positive number like 5 represent topic cluster|




### See also

[Dataverse table/entity reference](../about-entity-reference.md)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   

