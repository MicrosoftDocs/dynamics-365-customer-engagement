---
title: "Document Location (SharePointDocumentLocation) table/entity reference (Microsoft Dynamics 365 Customer Service)"
description: "Includes schema information and supported messages for the Document Location (SharePointDocumentLocation) table/entity with Microsoft Dynamics 365 Customer Service."
ms.topic: generated-reference
author: gandhamm
ms.author: mgandham
search.audienceType: 
  - developer
---

# Document Location (SharePointDocumentLocation) table/entity reference (Microsoft Dynamics 365 Customer Service)

Document libraries or folders on a SharePoint server from where documents can be managed in Microsoft Dynamics 365.

> [!NOTE]
> The Microsoft Dynamics 365 Customer Service Document Location (SharePointDocumentLocation) table extends the [Microsoft Dynamics 365 Document Location (SharePointDocumentLocation) table](/dynamics365/developer/reference/entities/sharepointdocumentlocation).



## Customized columns/attributes

Microsoft Dynamics 365 Customer Service modifies the definition of columns/attributes defined in other solutions. Listed by **SchemaName**.

### <a name="BKMK_RegardingObjectId"></a> RegardingObjectId

Changes from [RegardingObjectId (Microsoft Dataverse)](/power-apps/developer/data-platform/reference/entities/sharepointdocumentlocation#BKMK_RegardingObjectId)

|Property|Value|
|---|---|
|Targets|msdyn_resourceterritory, msdyn_timegroup, msdyn_timegroupdetail|


## Many-to-One relationships

These relationships are many-to-one. Listed by **SchemaName**.

- [msdyn_resourceterritory_SharePointDocumentLocations](#BKMK_msdyn_resourceterritory_SharePointDocumentLocations)
- [msdyn_timegroup_SharePointDocumentLocations](#BKMK_msdyn_timegroup_SharePointDocumentLocations)
- [msdyn_timegroupdetail_SharePointDocumentLocations](#BKMK_msdyn_timegroupdetail_SharePointDocumentLocations)

### <a name="BKMK_msdyn_resourceterritory_SharePointDocumentLocations"></a> msdyn_resourceterritory_SharePointDocumentLocations

One-To-Many Relationship: [msdyn_resourceterritory msdyn_resourceterritory_SharePointDocumentLocations](msdyn_resourceterritory.md#BKMK_msdyn_resourceterritory_SharePointDocumentLocations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_resourceterritory`|
|ReferencedAttribute|`msdyn_resourceterritoryid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_resourceterritory`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `Cascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_timegroup_SharePointDocumentLocations"></a> msdyn_timegroup_SharePointDocumentLocations

One-To-Many Relationship: [msdyn_timegroup msdyn_timegroup_SharePointDocumentLocations](msdyn_timegroup.md#BKMK_msdyn_timegroup_SharePointDocumentLocations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_timegroup`|
|ReferencedAttribute|`msdyn_timegroupid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_timegroup`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `Cascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_timegroupdetail_SharePointDocumentLocations"></a> msdyn_timegroupdetail_SharePointDocumentLocations

One-To-Many Relationship: [msdyn_timegroupdetail msdyn_timegroupdetail_SharePointDocumentLocations](msdyn_timegroupdetail.md#BKMK_msdyn_timegroupdetail_SharePointDocumentLocations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_timegroupdetail`|
|ReferencedAttribute|`msdyn_timegroupdetailid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_timegroupdetail`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `Cascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|



### See also

[Dataverse table/entity reference](/power-apps/developer/data-platform/reference/about-entity-reference)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   
<xref:Microsoft.Dynamics.CRM.sharepointdocumentlocation?displayProperty=fullName>
