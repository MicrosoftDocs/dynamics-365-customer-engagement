---
title: "Portal Comment (adx_portalcomment) table/entity reference (Microsoft Dynamics 365 Sales) | Microsoft Docs"
description: "Includes schema information and supported messages for the Portal Comment (adx_portalcomment) table/entity with Microsoft Dynamics 365 Sales."
ms.date: 04/21/2024
ms.service: powerapps
ms.topic: reference
author: JimDaly
ms.author: jdaly
search.audienceType: 
  - developer
---

# Portal Comment (adx_portalcomment) table/entity reference

An activity which is used to share information between the user and the customer on the portal.

> [!NOTE]
> The Microsoft Dynamics 365 Sales Portal Comment (adx_portalcomment) table extends [Portal Comment (adx_portalcomment) table (Microsoft Dataverse)](/power-apps/developer/data-platform/reference/entities/adx_portalcomment) and [Portal Comment (adx_portalcomment) table (Microsoft Dynamics 365)](/dynamics365/developer/reference/dataverse/entities/adx_portalcomment).
>
> This reference contains only the changes added by Microsoft Dynamics 365 Sales.
> See the [Portal Comment (adx_portalcomment) table (Microsoft Dataverse)](/power-apps/developer/data-platform/reference/entities/adx_portalcomment) and [Portal Comment (adx_portalcomment) table (Microsoft Dynamics 365)](/dynamics365/developer/reference/dataverse/entities/adx_portalcomment) reference documentation for more information.



## Customized columns/attributes

Microsoft Dynamics 365 Sales
modifies the definition of columns/attributes defined in other solutions. Listed by **SchemaName**.

- [Community](#BKMK_Community)
- [OptionalAttendees](#BKMK_OptionalAttendees)
- [RegardingObjectId](#BKMK_RegardingObjectId)
- [RequiredAttendees](#BKMK_RequiredAttendees)

### <a name="BKMK_Community"></a> Community

Changes from [Community (Microsoft Dataverse)](/power-apps/developer/data-platform/reference/entities/adx_portalcomment#BKMK_Community):

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

### <a name="BKMK_OptionalAttendees"></a> OptionalAttendees

Changes from [OptionalAttendees (Microsoft Dataverse)](/power-apps/developer/data-platform/reference/entities/adx_portalcomment#BKMK_OptionalAttendees):

|Property|Value|
|---|---|
|Targets|entitlement|


### <a name="BKMK_RegardingObjectId"></a> RegardingObjectId

Changes from [RegardingObjectId (Microsoft Dataverse)](/power-apps/developer/data-platform/reference/entities/adx_portalcomment#BKMK_RegardingObjectId):

|Property|Value|
|---|---|
|Targets|bookableresourcebooking|


### <a name="BKMK_RequiredAttendees"></a> RequiredAttendees

Changes from [RequiredAttendees (Microsoft Dataverse)](/power-apps/developer/data-platform/reference/entities/adx_portalcomment#BKMK_RequiredAttendees):

|Property|Value|
|---|---|
|Targets|entitlement|




### See also

[Dataverse table/entity reference](../about-entity-reference.md)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   
<xref:Microsoft.Dynamics.CRM.adx_portalcomment?displayProperty=fullName>
