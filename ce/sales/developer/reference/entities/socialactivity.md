---
title: "Social Activity (SocialActivity) table/entity reference (Microsoft Dynamics 365 Sales) | Microsoft Docs"
description: "Includes schema information and supported messages for the Social Activity (SocialActivity) table/entity with Microsoft Dynamics 365 Sales."
ms.date: 04/21/2024
ms.service: powerapps
ms.topic: reference
author: JimDaly
ms.author: jdaly
search.audienceType: 
  - developer
---

# Social Activity (SocialActivity) table/entity reference

For internal use only.

> [!NOTE]
> The Microsoft Dynamics 365 Sales Social Activity (SocialActivity) table extends [Social Activity (SocialActivity) table (Microsoft Dataverse)](/power-apps/developer/data-platform/reference/entities/socialactivity) and [Social Activity (SocialActivity) table (Microsoft Dynamics 365)](/dynamics365/developer/reference/dataverse/entities/socialactivity).
>
> This reference contains only the changes added by Microsoft Dynamics 365 Sales.
> See the [Social Activity (SocialActivity) table (Microsoft Dataverse)](/power-apps/developer/data-platform/reference/entities/socialactivity) and [Social Activity (SocialActivity) table (Microsoft Dynamics 365)](/dynamics365/developer/reference/dataverse/entities/socialactivity) reference documentation for more information.



## Customized columns/attributes

Microsoft Dynamics 365 Sales
modifies the definition of columns/attributes defined in other solutions. Listed by **SchemaName**.

- [Community](#BKMK_Community)
- [From](#BKMK_From)
- [RegardingObjectId](#BKMK_RegardingObjectId)
- [Resources](#BKMK_Resources)
- [To](#BKMK_To)

### <a name="BKMK_Community"></a> Community

Changes from [Community (Microsoft Dataverse)](/power-apps/developer/data-platform/reference/entities/socialactivity#BKMK_Community):

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

### <a name="BKMK_From"></a> From

Changes from [From (Microsoft Dataverse)](/power-apps/developer/data-platform/reference/entities/socialactivity#BKMK_From):

|Property|Value|
|---|---|
|Targets|lead|


### <a name="BKMK_RegardingObjectId"></a> RegardingObjectId

Changes from [RegardingObjectId (Microsoft Dataverse)](/power-apps/developer/data-platform/reference/entities/socialactivity#BKMK_RegardingObjectId):

|Property|Value|
|---|---|
|Targets|bookableresourcebooking|


### <a name="BKMK_Resources"></a> Resources

Changes from [Resources (Microsoft Dataverse)](/power-apps/developer/data-platform/reference/entities/socialactivity#BKMK_Resources):

|Property|Value|
|---|---|
|Targets|equipment|


### <a name="BKMK_To"></a> To

Changes from [To (Microsoft Dataverse)](/power-apps/developer/data-platform/reference/entities/socialactivity#BKMK_To):

|Property|Value|
|---|---|
|Targets|lead|




### See also

[Dataverse table/entity reference](../about-entity-reference.md)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   
<xref:Microsoft.Dynamics.CRM.socialactivity?displayProperty=fullName>
