---
title: "Recurring Appointment (RecurringAppointmentMaster) table/entity reference (Microsoft Dynamics 365 Sales) | Microsoft Docs"
description: "Includes schema information and supported messages for the Recurring Appointment (RecurringAppointmentMaster) table/entity with Microsoft Dynamics 365 Sales."
ms.date: 05/19/2024
ms.service: powerapps
ms.topic: reference
author: JimDaly
ms.author: jdaly
search.audienceType: 
  - developer
---

# Recurring Appointment (RecurringAppointmentMaster) table/entity reference

The Master appointment of a recurring appointment series.

> [!NOTE]
> The Microsoft Dynamics 365 Sales Recurring Appointment (RecurringAppointmentMaster) table extends the [Microsoft Dataverse Recurring Appointment (RecurringAppointmentMaster) table](/power-apps/developer/data-platform/reference/entities/recurringappointmentmaster).



## Customized columns/attributes

Microsoft Dynamics 365 Sales
modifies the definition of columns/attributes defined in other solutions. Listed by **SchemaName**.

### <a name="BKMK_RegardingObjectId"></a> RegardingObjectId

Changes from [RegardingObjectId (Microsoft Dataverse)](/power-apps/developer/data-platform/reference/entities/recurringappointmentmaster#BKMK_RegardingObjectId):

|Property|Value|
|---|---|
|Targets|sample_bankaccount|


## Many-to-One relationships

These relationships are many-to-one. Listed by **SchemaName**.

### <a name="BKMK_sample_bankaccount_RecurringAppointmentMasters"></a> sample_bankaccount_RecurringAppointmentMasters

One-To-Many Relationship: [sample_bankaccount sample_bankaccount_RecurringAppointmentMasters](sample_bankaccount.md#BKMK_sample_bankaccount_RecurringAppointmentMasters)

|Property|Value|
|--------|-----|
|ReferencedEntity|`sample_bankaccount`|
|ReferencedAttribute|`sample_bankaccountid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|``|
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|
|IsHierarchical||
|IsRelationshipAttributeDenormalized||



### See also

[Dataverse table/entity reference](../about-entity-reference.md)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   
<xref:Microsoft.Dynamics.CRM.recurringappointmentmaster?displayProperty=fullName>
