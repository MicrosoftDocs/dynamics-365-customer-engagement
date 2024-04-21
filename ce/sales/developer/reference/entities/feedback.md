---
title: "Feedback table/entity reference (Microsoft Dynamics 365 Sales) | Microsoft Docs"
description: "Includes schema information and supported messages for the Feedback table/entity with Microsoft Dynamics 365 Sales."
ms.date: 04/21/2024
ms.service: powerapps
ms.topic: reference
author: JimDaly
ms.author: jdaly
search.audienceType: 
  - developer
---

# Feedback table/entity reference

Feedback and rating.

> [!NOTE]
> The Microsoft Dynamics 365 Sales Feedback table extends [Feedback table (Microsoft Dataverse)](/power-apps/developer/data-platform/reference/entities/feedback) and [Feedback table (Microsoft Dynamics 365)](/dynamics365/developer/reference/dataverse/entities/feedback).
>
> This reference contains only the changes added by Microsoft Dynamics 365 Sales.
> See the [Feedback table (Microsoft Dataverse)](/power-apps/developer/data-platform/reference/entities/feedback) and [Feedback table (Microsoft Dynamics 365)](/dynamics365/developer/reference/dataverse/entities/feedback) reference documentation for more information.



## Customized columns/attributes

Microsoft Dynamics 365 Sales
modifies the definition of columns/attributes defined in other solutions. Listed by **SchemaName**.

- [msdyn_ContextObjectId](#BKMK_msdyn_ContextObjectId)
- [RegardingObjectId](#BKMK_RegardingObjectId)

### <a name="BKMK_msdyn_ContextObjectId"></a> msdyn_ContextObjectId

Changes from [msdyn_ContextObjectId (Microsoft Dataverse)](/power-apps/developer/data-platform/reference/entities/feedback#BKMK_msdyn_ContextObjectId):

|Property|Value|
|---|---|
|Targets|incident|


### <a name="BKMK_RegardingObjectId"></a> RegardingObjectId

Changes from [RegardingObjectId (Microsoft Dataverse)](/power-apps/developer/data-platform/reference/entities/feedback#BKMK_RegardingObjectId):

|Property|Value|
|---|---|
|Targets|msdyn_copilottranscript|




### See also

[Dataverse table/entity reference](../about-entity-reference.md)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   
<xref:Microsoft.Dynamics.CRM.feedback?displayProperty=fullName>
