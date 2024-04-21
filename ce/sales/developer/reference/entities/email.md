---
title: "Email table/entity reference (Microsoft Dynamics 365 Sales) | Microsoft Docs"
description: "Includes schema information and supported messages for the Email table/entity with Microsoft Dynamics 365 Sales."
ms.date: 04/21/2024
ms.service: powerapps
ms.topic: reference
author: JimDaly
ms.author: jdaly
search.audienceType: 
  - developer
---

# Email table/entity reference

Activity that is delivered using email protocols.

> [!NOTE]
> The Microsoft Dynamics 365 Sales Email table extends [Email table (Microsoft Dataverse)](/power-apps/developer/data-platform/reference/entities/email) and [Email table (Microsoft Dynamics 365)](/dynamics365/developer/reference/dataverse/entities/email).
>
> This reference contains only the changes added by Microsoft Dynamics 365 Sales.
> See the [Email table (Microsoft Dataverse)](/power-apps/developer/data-platform/reference/entities/email) and [Email table (Microsoft Dynamics 365)](/dynamics365/developer/reference/dataverse/entities/email) reference documentation for more information.



## Customized columns/attributes

Microsoft Dynamics 365 Sales
modifies the definition of columns/attributes defined in other solutions. Listed by **SchemaName**.

- [bcc](#BKMK_bcc)
- [cc](#BKMK_cc)
- [EmailSender](#BKMK_EmailSender)
- [RegardingObjectId](#BKMK_RegardingObjectId)
- [related](#BKMK_related)
- [to](#BKMK_to)

### <a name="BKMK_bcc"></a> bcc

Changes from [bcc (Microsoft Dataverse)](/power-apps/developer/data-platform/reference/entities/email#BKMK_bcc):

|Property|Value|
|---|---|
|Targets|entitlement|


### <a name="BKMK_cc"></a> cc

Changes from [cc (Microsoft Dataverse)](/power-apps/developer/data-platform/reference/entities/email#BKMK_cc):

|Property|Value|
|---|---|
|Targets|entitlement|


### <a name="BKMK_EmailSender"></a> EmailSender

Changes from [EmailSender (Microsoft Dataverse)](/power-apps/developer/data-platform/reference/entities/email#BKMK_EmailSender):

|Property|Value|
|---|---|
|Targets|equipment|


### <a name="BKMK_RegardingObjectId"></a> RegardingObjectId

Changes from [RegardingObjectId (Microsoft Dataverse)](/power-apps/developer/data-platform/reference/entities/email#BKMK_RegardingObjectId):

|Property|Value|
|---|---|
|Targets|bookableresourcebooking|


### <a name="BKMK_related"></a> related

Changes from [related (Microsoft Dataverse)](/power-apps/developer/data-platform/reference/entities/email#BKMK_related):

|Property|Value|
|---|---|
|Targets|campaign|


### <a name="BKMK_to"></a> to

Changes from [to (Microsoft Dataverse)](/power-apps/developer/data-platform/reference/entities/email#BKMK_to):

|Property|Value|
|---|---|
|Targets|entitlement|




### See also

[Dataverse table/entity reference](../about-entity-reference.md)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   
<xref:Microsoft.Dynamics.CRM.email?displayProperty=fullName>
