---
title: "Read Tracker (msdyn_readtracker) table/entity reference (Microsoft Dynamics 365 Customer Service)"
description: "Includes schema information and supported messages for the Read Tracker (msdyn_readtracker) table/entity with Microsoft Dynamics 365 Customer Service."
ms.topic: generated-reference
author: gandhamm
ms.author: mgandham
search.audienceType: 
  - developer
---

# Read Tracker (msdyn_readtracker) table/entity reference (Microsoft Dynamics 365 Customer Service)

Keeps track of the records read by an user in the system

> [!NOTE]
> The Microsoft Dynamics 365 Customer Service Read Tracker (msdyn_readtracker) table extends the [Microsoft Dynamics 365 Read Tracker (msdyn_readtracker) table](/dynamics365/developer/reference/entities/msdyn_readtracker).



## Customized columns/attributes

Microsoft Dynamics 365 Customer Service modifies the definition of columns/attributes defined in other solutions. Listed by **SchemaName**.

### <a name="BKMK_msdyn_RegardingObjectId"></a> msdyn_RegardingObjectId

Changes from [msdyn_RegardingObjectId (Microsoft Dynamics 365)](/dynamics365/developer/reference/entities/msdyn_readtracker#BKMK_msdyn_RegardingObjectId)

|Property|Value|
|---|---|
|Targets|msdyn_ocvoicemail|


## Many-to-One relationships

These relationships are many-to-one. Listed by **SchemaName**.

### <a name="BKMK_msdyn_readtracker_poly_msdyn_ocvoicemail"></a> msdyn_readtracker_poly_msdyn_ocvoicemail

One-To-Many Relationship: [msdyn_ocvoicemail msdyn_readtracker_poly_msdyn_ocvoicemail](msdyn_ocvoicemail.md#BKMK_msdyn_readtracker_poly_msdyn_ocvoicemail)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_ocvoicemail`|
|ReferencedAttribute|`activityid`|
|ReferencingAttribute|`msdyn_regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`msdyn_RegardingObjectId`|
|IsHierarchical||
|CascadeConfiguration|Archive: `RemoveLink`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|



### See also

[Dataverse table/entity reference](/power-apps/developer/data-platform/reference/about-entity-reference)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   

