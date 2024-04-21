---
title: "Queue Item (QueueItem) table/entity reference (Microsoft Dynamics 365 Sales) | Microsoft Docs"
description: "Includes schema information and supported messages for the Queue Item (QueueItem) table/entity with Microsoft Dynamics 365 Sales."
ms.date: 04/21/2024
ms.service: powerapps
ms.topic: reference
author: JimDaly
ms.author: jdaly
search.audienceType: 
  - developer
---

# Queue Item (QueueItem) table/entity reference

A specific item in a queue, such as a case record or an activity record.

> [!NOTE]
> The Microsoft Dynamics 365 Sales Queue Item (QueueItem) table extends [Queue Item (QueueItem) table (Microsoft Dataverse)](/power-apps/developer/data-platform/reference/entities/queueitem) and [Queue Item (QueueItem) table (Microsoft Dynamics 365)](/dynamics365/developer/reference/dataverse/entities/queueitem).
>
> This reference contains only the changes added by Microsoft Dynamics 365 Sales.
> See the [Queue Item (QueueItem) table (Microsoft Dataverse)](/power-apps/developer/data-platform/reference/entities/queueitem) and [Queue Item (QueueItem) table (Microsoft Dynamics 365)](/dynamics365/developer/reference/dataverse/entities/queueitem) reference documentation for more information.



## Customized columns/attributes

Microsoft Dynamics 365 Sales
modifies the definition of columns/attributes defined in other solutions. Listed by **SchemaName**.

- [ObjectId](#BKMK_ObjectId)
- [ObjectTypeCode](#BKMK_ObjectTypeCode)

### <a name="BKMK_ObjectId"></a> ObjectId

Changes from [ObjectId (Microsoft Dataverse)](/power-apps/developer/data-platform/reference/entities/queueitem#BKMK_ObjectId):

|Property|Value|
|---|---|
|Targets|bulkoperation|


### <a name="BKMK_ObjectTypeCode"></a> ObjectTypeCode

Changes from [ObjectTypeCode (Microsoft Dataverse)](/power-apps/developer/data-platform/reference/entities/queueitem#BKMK_ObjectTypeCode):

#### ObjectTypeCode Choices/Options

|Value|Label|
|---|---|
|10542|**Customer Voice alert**|
|10552|**Customer Voice survey invite**|
|10554|**Customer Voice survey response**|
|10343|**IoT Alert**|
|4402|**Campaign Activity**|
|4401|**Campaign Response**|
|4406|**Quick Campaign**|
|10667|**Session**|
|112|**Case**|
|4214|**Service Activity**|
|10650|**Conversation**|
|10590|**Copilot Transcript**|
|10614|**Overflow Action Config**|
|10638|**Ongoing conversation (Deprecated)**|
|10137|**Knowledge Article Template**|
|10262|**Invite Redemption**|
|10263|**Portal Comment**|
|10121|**Teams chat**|



### See also

[Dataverse table/entity reference](../about-entity-reference.md)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   
<xref:Microsoft.Dynamics.CRM.queueitem?displayProperty=fullName>
