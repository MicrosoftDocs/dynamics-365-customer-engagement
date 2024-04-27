---
title: "Event Expander Breadcrumb (EventExpanderBreadcrumb) table/entity reference (Microsoft Dynamics 365 Sales) | Microsoft Docs"
description: "Includes schema information and supported messages for the Event Expander Breadcrumb (EventExpanderBreadcrumb) table/entity with Microsoft Dynamics 365 Sales."
ms.date: 04/27/2024
ms.service: powerapps
ms.topic: reference
author: JimDaly
ms.author: jdaly
search.audienceType: 
  - developer
---

# Event Expander Breadcrumb (EventExpanderBreadcrumb) table/entity reference

Table to store breadcrumb records of Event Expander pipeline.

> [!NOTE]
> The Microsoft Dynamics 365 Sales Event Expander Breadcrumb (EventExpanderBreadcrumb) table extends [Event Expander Breadcrumb (EventExpanderBreadcrumb) table (Microsoft Dataverse)](/power-apps/developer/data-platform/reference/entities/eventexpanderbreadcrumb) and [Event Expander Breadcrumb (EventExpanderBreadcrumb) table (Microsoft Dynamics 365)](/dynamics365/developer/reference/dataverse/entities/eventexpanderbreadcrumb).
>
> This reference contains only the changes added by Microsoft Dynamics 365 Sales.
> See the [Event Expander Breadcrumb (EventExpanderBreadcrumb) table (Microsoft Dataverse)](/power-apps/developer/data-platform/reference/entities/eventexpanderbreadcrumb) and [Event Expander Breadcrumb (EventExpanderBreadcrumb) table (Microsoft Dynamics 365)](/dynamics365/developer/reference/dataverse/entities/eventexpanderbreadcrumb) reference documentation for more information.



## Customized columns/attributes

Microsoft Dynamics 365 Sales
modifies the definition of columns/attributes defined in other solutions. Listed by **SchemaName**.

- [StateCode](#BKMK_StateCode)
- [StatusCode](#BKMK_StatusCode)

### <a name="BKMK_StateCode"></a> StateCode

Changes from [StateCode (Microsoft Dataverse)](/power-apps/developer/data-platform/reference/entities/eventexpanderbreadcrumb#BKMK_StateCode):

#### StateCode Choices/Options

|Value|Label|
|---|---|
|0|**Ready**|
|2|**Locked**|
|3|**Completed**|

### <a name="BKMK_StatusCode"></a> StatusCode

Changes from [StatusCode (Microsoft Dataverse)](/power-apps/developer/data-platform/reference/entities/eventexpanderbreadcrumb#BKMK_StatusCode):

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

