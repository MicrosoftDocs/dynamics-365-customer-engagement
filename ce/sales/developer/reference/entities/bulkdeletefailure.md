---
title: "Bulk Delete Failure (BulkDeleteFailure) table/entity reference (Microsoft Dynamics 365 Sales) | Microsoft Docs"
description: "Includes schema information and supported messages for the Bulk Delete Failure (BulkDeleteFailure) table/entity with Microsoft Dynamics 365 Sales."
ms.date: 04/21/2024
ms.service: powerapps
ms.topic: reference
author: JimDaly
ms.author: jdaly
search.audienceType: 
  - developer
---

# Bulk Delete Failure (BulkDeleteFailure) table/entity reference

Record that was not deleted during a bulk deletion job.

> [!NOTE]
> The Microsoft Dynamics 365 Sales Bulk Delete Failure (BulkDeleteFailure) table extends [Bulk Delete Failure (BulkDeleteFailure) table (Microsoft Dataverse)](/power-apps/developer/data-platform/reference/entities/bulkdeletefailure) and [Bulk Delete Failure (BulkDeleteFailure) table (Microsoft Dynamics 365)](/dynamics365/developer/reference/dataverse/entities/bulkdeletefailure).
>
> This reference contains only the changes added by Microsoft Dynamics 365 Sales.
> See the [Bulk Delete Failure (BulkDeleteFailure) table (Microsoft Dataverse)](/power-apps/developer/data-platform/reference/entities/bulkdeletefailure) and [Bulk Delete Failure (BulkDeleteFailure) table (Microsoft Dynamics 365)](/dynamics365/developer/reference/dataverse/entities/bulkdeletefailure) reference documentation for more information.



## Customized columns/attributes

Microsoft Dynamics 365 Sales
modifies the definition of columns/attributes defined in other solutions. Listed by **SchemaName**.

- [OwningUser](#BKMK_OwningUser)
- [RegardingObjectId](#BKMK_RegardingObjectId)

### <a name="BKMK_OwningUser"></a> OwningUser

Changes from [OwningUser (Microsoft Dataverse)](/power-apps/developer/data-platform/reference/entities/bulkdeletefailure#BKMK_OwningUser):

|Property|Value|
|---|---|
|Description|Unique identifier of the user who owns the bulk deletion failure record.
|


### <a name="BKMK_RegardingObjectId"></a> RegardingObjectId

Changes from [RegardingObjectId (Microsoft Dataverse)](/power-apps/developer/data-platform/reference/entities/bulkdeletefailure#BKMK_RegardingObjectId):

|Property|Value|
|---|---|
|Targets|accountleads|


## Customized relationships

### Customized Many-to-One relationships

#### <a name="BKMK_Territory_BulkDeleteFailures"></a> Territory_BulkDeleteFailures

Changes from [Territory_BulkDeleteFailures (Microsoft Dataverse)](/power-apps/developer/data-platform/reference/entities/bulkdeletefailure#BKMK_Territory_BulkDeleteFailures):



### See also

[Dataverse table/entity reference](../about-entity-reference.md)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   
<xref:Microsoft.Dynamics.CRM.bulkdeletefailure?displayProperty=fullName>
