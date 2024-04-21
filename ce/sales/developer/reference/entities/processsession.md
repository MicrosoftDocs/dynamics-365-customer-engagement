---
title: "Process Session (ProcessSession) table/entity reference (Microsoft Dynamics 365 Sales) | Microsoft Docs"
description: "Includes schema information and supported messages for the Process Session (ProcessSession) table/entity with Microsoft Dynamics 365 Sales."
ms.date: 04/21/2024
ms.service: powerapps
ms.topic: reference
author: JimDaly
ms.author: jdaly
search.audienceType: 
  - developer
---

# Process Session (ProcessSession) table/entity reference

Information that is generated when a dialog is run. Every time that you run a dialog, a dialog session is created.

> [!NOTE]
> The Microsoft Dynamics 365 Sales Process Session (ProcessSession) table extends [Process Session (ProcessSession) table (Microsoft Dataverse)](/power-apps/developer/data-platform/reference/entities/processsession) and [Process Session (ProcessSession) table (Microsoft Dynamics 365)](/dynamics365/developer/reference/dataverse/entities/processsession).
>
> This reference contains only the changes added by Microsoft Dynamics 365 Sales.
> See the [Process Session (ProcessSession) table (Microsoft Dataverse)](/power-apps/developer/data-platform/reference/entities/processsession) and [Process Session (ProcessSession) table (Microsoft Dynamics 365)](/dynamics365/developer/reference/dataverse/entities/processsession) reference documentation for more information.



## Customized columns/attributes

Microsoft Dynamics 365 Sales
modifies the definition of columns/attributes defined in other solutions. Listed by **SchemaName**.

### <a name="BKMK_RegardingObjectId"></a> RegardingObjectId

Changes from [RegardingObjectId (Microsoft Dataverse)](/power-apps/developer/data-platform/reference/entities/processsession#BKMK_RegardingObjectId):

|Property|Value|
|---|---|
|Targets|activitymonitor|


## Customized relationships

### Customized Many-to-One relationships

#### <a name="BKMK_Territory_ProcessSessions"></a> Territory_ProcessSessions

Changes from [Territory_ProcessSessions (Microsoft Dataverse)](/power-apps/developer/data-platform/reference/entities/processsession#BKMK_Territory_ProcessSessions):



### See also

[Dataverse table/entity reference](../about-entity-reference.md)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   
<xref:Microsoft.Dynamics.CRM.processsession?displayProperty=fullName>
