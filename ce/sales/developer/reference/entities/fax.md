---
title: "Fax table/entity reference (Microsoft Dynamics 365 Sales) | Microsoft Docs"
description: "Includes schema information and supported messages for the Fax table/entity with Microsoft Dynamics 365 Sales."
ms.date: 04/21/2024
ms.service: powerapps
ms.topic: reference
author: JimDaly
ms.author: jdaly
search.audienceType: 
  - developer
---

# Fax table/entity reference

Activity that tracks call outcome and number of pages for a fax and optionally stores an electronic copy of the document.

> [!NOTE]
> The Microsoft Dynamics 365 Sales Fax table extends [Fax table (Microsoft Dataverse)](/power-apps/developer/data-platform/reference/entities/fax) and [Fax table (Microsoft Dynamics 365)](/dynamics365/developer/reference/dataverse/entities/fax).
>
> This reference contains only the changes added by Microsoft Dynamics 365 Sales.
> See the [Fax table (Microsoft Dataverse)](/power-apps/developer/data-platform/reference/entities/fax) and [Fax table (Microsoft Dynamics 365)](/dynamics365/developer/reference/dataverse/entities/fax) reference documentation for more information.



## Customized columns/attributes

Microsoft Dynamics 365 Sales
modifies the definition of columns/attributes defined in other solutions. Listed by **SchemaName**.

- [from](#BKMK_from)
- [RegardingObjectId](#BKMK_RegardingObjectId)
- [to](#BKMK_to)

### <a name="BKMK_from"></a> from

Changes from [from (Microsoft Dataverse)](/power-apps/developer/data-platform/reference/entities/fax#BKMK_from):

|Property|Value|
|---|---|
|Targets|lead|


### <a name="BKMK_RegardingObjectId"></a> RegardingObjectId

Changes from [RegardingObjectId (Microsoft Dataverse)](/power-apps/developer/data-platform/reference/entities/fax#BKMK_RegardingObjectId):

|Property|Value|
|---|---|
|Targets|bookableresourcebooking|


### <a name="BKMK_to"></a> to

Changes from [to (Microsoft Dataverse)](/power-apps/developer/data-platform/reference/entities/fax#BKMK_to):

|Property|Value|
|---|---|
|Targets|lead|




### See also

[Dataverse table/entity reference](../about-entity-reference.md)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   
<xref:Microsoft.Dynamics.CRM.fax?displayProperty=fullName>
