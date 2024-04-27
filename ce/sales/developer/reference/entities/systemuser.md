---
title: "User (SystemUser) table/entity reference (Microsoft Dynamics 365 Sales) | Microsoft Docs"
description: "Includes schema information and supported messages for the User (SystemUser) table/entity with Microsoft Dynamics 365 Sales."
ms.date: 04/27/2024
ms.service: powerapps
ms.topic: reference
author: JimDaly
ms.author: jdaly
search.audienceType: 
  - developer
---

# User (SystemUser) table/entity reference

Person with access to the Microsoft CRM system and who owns objects in the Microsoft CRM database.

> [!NOTE]
> The Microsoft Dynamics 365 Sales User (SystemUser) table extends [User (SystemUser) table (Microsoft Dataverse)](/power-apps/developer/data-platform/reference/entities/systemuser) and [User (SystemUser) table (Microsoft Dynamics 365)](/dynamics365/developer/reference/dataverse/entities/systemuser).
>
> This reference contains only the changes added by Microsoft Dynamics 365 Sales.
> See the [User (SystemUser) table (Microsoft Dataverse)](/power-apps/developer/data-platform/reference/entities/systemuser) and [User (SystemUser) table (Microsoft Dynamics 365)](/dynamics365/developer/reference/dataverse/entities/systemuser) reference documentation for more information.




## Customized relationships

### Customized One-to-many relationships

- [lk_territory_createdonbehalfby](#BKMK_lk_territory_createdonbehalfby)
- [lk_territory_modifiedonbehalfby](#BKMK_lk_territory_modifiedonbehalfby)

#### <a name="BKMK_lk_territory_createdonbehalfby"></a> lk_territory_createdonbehalfby

Changes from [lk_territory_createdonbehalfby (Microsoft Dataverse)](/power-apps/developer/data-platform/reference/entities/systemuser#BKMK_lk_territory_createdonbehalfby):

|Property|Value|
|--------|-----|
|ReferencedEntityNavigationPropertyName|lk_territory_createdonbehalfby|

#### <a name="BKMK_lk_territory_modifiedonbehalfby"></a> lk_territory_modifiedonbehalfby

Changes from [lk_territory_modifiedonbehalfby (Microsoft Dataverse)](/power-apps/developer/data-platform/reference/entities/systemuser#BKMK_lk_territory_modifiedonbehalfby):

|Property|Value|
|--------|-----|
|ReferencedEntityNavigationPropertyName|lk_territory_modifiedonbehalfby|


### See also

[Dataverse table/entity reference](../about-entity-reference.md)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   
<xref:Microsoft.Dynamics.CRM.systemuser?displayProperty=fullName>
