---
title: "Business Unit (BusinessUnit) table/entity reference (Microsoft Dynamics 365 Sales) | Microsoft Docs"
description: "Includes schema information and supported messages for the Business Unit (BusinessUnit) table/entity with Microsoft Dynamics 365 Sales."
ms.date: 05/12/2024
ms.service: powerapps
ms.topic: reference
author: JimDaly
ms.author: jdaly
search.audienceType: 
  - developer
---

# Business Unit (BusinessUnit) table/entity reference

Business, division, or department in the Microsoft Dynamics 365 database.

> [!NOTE]
> The Microsoft Dynamics 365 Sales Business Unit (BusinessUnit) table extends the [Microsoft Dataverse Business Unit (BusinessUnit) table](/power-apps/developer/data-platform/reference/entities/businessunit).




## One-to-Many relationships

These relationships are one-to-many. Listed by **SchemaName**.

### <a name="BKMK_business_unit_sample_bankaccount"></a> business_unit_sample_bankaccount

Many-To-One Relationship: [sample_bankaccount business_unit_sample_bankaccount](sample_bankaccount.md#BKMK_business_unit_sample_bankaccount)

|Property|Value|
|--------|-----|
|ReferencingEntity|`sample_bankaccount`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_sample_bankaccount`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|



### See also

[Dataverse table/entity reference](../about-entity-reference.md)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   
<xref:Microsoft.Dynamics.CRM.businessunit?displayProperty=fullName>
