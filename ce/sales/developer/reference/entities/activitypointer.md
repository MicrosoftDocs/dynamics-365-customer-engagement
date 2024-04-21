---
title: "Activity (ActivityPointer) table/entity reference (Microsoft Dynamics 365 Sales) | Microsoft Docs"
description: "Includes schema information and supported messages for the Activity (ActivityPointer) table/entity with Microsoft Dynamics 365 Sales."
ms.date: 04/21/2024
ms.service: powerapps
ms.topic: reference
author: JimDaly
ms.author: jdaly
search.audienceType: 
  - developer
---

# Activity (ActivityPointer) table/entity reference

Task performed, or to be performed, by a user. An activity is any action for which an entry can be made on a calendar.

> [!NOTE]
> The Microsoft Dynamics 365 Sales Activity (ActivityPointer) table extends [Activity (ActivityPointer) table (Microsoft Dataverse)](/power-apps/developer/data-platform/reference/entities/activitypointer) and [Activity (ActivityPointer) table (Microsoft Dynamics 365)](/dynamics365/developer/reference/dataverse/entities/activitypointer).
>
> This reference contains only the changes added by Microsoft Dynamics 365 Sales.
> See the [Activity (ActivityPointer) table (Microsoft Dataverse)](/power-apps/developer/data-platform/reference/entities/activitypointer) and [Activity (ActivityPointer) table (Microsoft Dynamics 365)](/dynamics365/developer/reference/dataverse/entities/activitypointer) reference documentation for more information.



## Customized columns/attributes

Microsoft Dynamics 365 Sales
modifies the definition of columns/attributes defined in other solutions. Listed by **SchemaName**.

- [allparties](#BKMK_allparties)
- [Community](#BKMK_Community)
- [RegardingObjectId](#BKMK_RegardingObjectId)

### <a name="BKMK_allparties"></a> allparties

Changes from [allparties (Microsoft Dataverse)](/power-apps/developer/data-platform/reference/entities/activitypointer#BKMK_allparties):

|Property|Value|
|---|---|
|Targets|equipment|


### <a name="BKMK_Community"></a> Community

Changes from [Community (Microsoft Dataverse)](/power-apps/developer/data-platform/reference/entities/activitypointer#BKMK_Community):

#### Community Choices/Options

|Value|Label|
|---|---|
|5|**Cortana**|
|6|**Direct Line**|
|7|**Microsoft Teams**|
|8|**Direct Line Speech**|
|9|**Email**|
|10|**GroupMe**|
|11|**Kik**|
|12|**Telegram**|
|13|**Skype**|
|14|**Slack**|
|15|**WhatsApp**|
|16|**Apple Messages For Business**|
|17|**Google's Business Messages**|
|3|**Line**|
|4|**Wechat**|
|1|****|
|2|****|
|0|****|

### <a name="BKMK_RegardingObjectId"></a> RegardingObjectId

Changes from [RegardingObjectId (Microsoft Dataverse)](/power-apps/developer/data-platform/reference/entities/activitypointer#BKMK_RegardingObjectId):

|Property|Value|
|---|---|
|Targets|bookableresourcebooking|




### See also

[Dataverse table/entity reference](../about-entity-reference.md)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   
<xref:Microsoft.Dynamics.CRM.activitypointer?displayProperty=fullName>
