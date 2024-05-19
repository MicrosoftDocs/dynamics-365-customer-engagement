---
title: "Service Activity (ServiceAppointment) table/entity reference (Microsoft Dynamics 365 Sales) | Microsoft Docs"
description: "Includes schema information and supported messages for the Service Activity (ServiceAppointment) table/entity with Microsoft Dynamics 365 Sales."
ms.date: 05/19/2024
ms.service: powerapps
ms.topic: reference
author: JimDaly
ms.author: jdaly
search.audienceType: 
  - developer
---

# Service Activity (ServiceAppointment) table/entity reference

Activity offered by the organization to satisfy its customer's needs. Each service activity includes date, time, duration, and required resources.

> [!NOTE]
> The Microsoft Dynamics 365 Sales Service Activity (ServiceAppointment) table extends the [Microsoft Dynamics 365 Service Activity (ServiceAppointment) table](/dynamics365/developer/reference/dataverse/entities/serviceappointment).



## Customized columns/attributes

Microsoft Dynamics 365 Sales
modifies the definition of columns/attributes defined in other solutions. Listed by **SchemaName**.

### <a name="BKMK_RegardingObjectId"></a> RegardingObjectId

Changes from [RegardingObjectId (Microsoft Dynamics 365)](/dynamics365/developer/reference/dataverse/entities/serviceappointment#BKMK_RegardingObjectId):

|Property|Value|
|---|---|
|Targets|sample_bankaccount|


## Many-to-One relationships

These relationships are many-to-one. Listed by **SchemaName**.

### <a name="BKMK_sample_bankaccount_ServiceAppointments"></a> sample_bankaccount_ServiceAppointments

One-To-Many Relationship: [sample_bankaccount sample_bankaccount_ServiceAppointments](sample_bankaccount.md#BKMK_sample_bankaccount_ServiceAppointments)

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

