---
title: "Background Operation (backgroundoperation) table/entity reference (Microsoft Dynamics 365 Sales) | Microsoft Docs"
description: "Includes schema information and supported messages for the Background Operation (backgroundoperation) table/entity with Microsoft Dynamics 365 Sales."
ms.date: 04/27/2024
ms.service: powerapps
ms.topic: reference
author: JimDaly
ms.author: jdaly
search.audienceType: 
  - developer
---

# Background Operation (backgroundoperation) table/entity reference



> [!NOTE]
> The Microsoft Dynamics 365 Sales Background Operation (backgroundoperation) table extends [Background Operation (backgroundoperation) table (Microsoft Dataverse)](/power-apps/developer/data-platform/reference/entities/backgroundoperation) and [Background Operation (backgroundoperation) table (Microsoft Dynamics 365)](/dynamics365/developer/reference/dataverse/entities/backgroundoperation).
>
> This reference contains only the changes added by Microsoft Dynamics 365 Sales.
> See the [Background Operation (backgroundoperation) table (Microsoft Dataverse)](/power-apps/developer/data-platform/reference/entities/backgroundoperation) and [Background Operation (backgroundoperation) table (Microsoft Dynamics 365)](/dynamics365/developer/reference/dataverse/entities/backgroundoperation) reference documentation for more information.



## Customized columns/attributes

Microsoft Dynamics 365 Sales
modifies the definition of columns/attributes defined in other solutions. Listed by **SchemaName**.

- [StateCode](#BKMK_StateCode)
- [StatusCode](#BKMK_StatusCode)

### <a name="BKMK_StateCode"></a> StateCode

Changes from [StateCode (Microsoft Dataverse)](/power-apps/developer/data-platform/reference/entities/backgroundoperation#BKMK_StateCode):

#### StateCode Choices/Options

|Value|Label|
|---|---|
|0|**Ready**|
|2|**Locked**|
|3|**Completed**|

### <a name="BKMK_StatusCode"></a> StatusCode

Changes from [StatusCode (Microsoft Dataverse)](/power-apps/developer/data-platform/reference/entities/backgroundoperation#BKMK_StatusCode):

#### StatusCode Choices/Options

|Value|Label|
|---|---|
|0|**Waiting For Resources**|
|20|**In Progress**|
|22|**Canceling**|
|30|**Succeeded**|
|31|**Failed**|
|32|**Canceled**|



### See also

[Dataverse table/entity reference](../about-entity-reference.md)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   
<xref:Microsoft.Dynamics.CRM.backgroundoperation?displayProperty=fullName>
