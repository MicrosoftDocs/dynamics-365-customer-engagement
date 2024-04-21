---
title: "AIPlugin table/entity reference (Microsoft Dynamics 365 Sales) | Microsoft Docs"
description: "Includes schema information and supported messages for the AIPlugin table/entity with Microsoft Dynamics 365 Sales."
ms.date: 04/21/2024
ms.service: powerapps
ms.topic: reference
author: JimDaly
ms.author: jdaly
search.audienceType: 
  - developer
---

# AIPlugin table/entity reference

AIPlugins component

> [!NOTE]
> The Microsoft Dynamics 365 Sales AIPlugin table extends [AIPlugin table (Microsoft Dataverse)](/power-apps/developer/data-platform/reference/entities/aiplugin) and [AIPlugin table (Microsoft Dynamics 365)](/dynamics365/developer/reference/dataverse/entities/aiplugin).
>
> This reference contains only the changes added by Microsoft Dynamics 365 Sales.
> See the [AIPlugin table (Microsoft Dataverse)](/power-apps/developer/data-platform/reference/entities/aiplugin) and [AIPlugin table (Microsoft Dynamics 365)](/dynamics365/developer/reference/dataverse/entities/aiplugin) reference documentation for more information.



## Customized columns/attributes

Microsoft Dynamics 365 Sales
modifies the definition of columns/attributes defined in other solutions. Listed by **SchemaName**.

### <a name="BKMK_UpsertSwagger"></a> UpsertSwagger

Changes from [UpsertSwagger (Microsoft Dataverse)](/power-apps/developer/data-platform/reference/entities/aiplugin#BKMK_UpsertSwagger):

|Property|Value|
|---|---|
|Description|Swagger value that is upserted to generated plugin definition, used to provide override for properties not exposed as table/columns.

Example:

{
  "info": {
      "x-ms-keywords": [ "sales", "support" ]
   }
}

Adds x-ms-keywords in info property.|




### See also

[Dataverse table/entity reference](../about-entity-reference.md)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   
<xref:Microsoft.Dynamics.CRM.aiplugin?displayProperty=fullName>
