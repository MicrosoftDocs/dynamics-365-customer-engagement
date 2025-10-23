---
title: "Routing diagnostic (msdyn_unifiedroutingrun) table/entity reference (Microsoft Dynamics 365 Customer Service)"
description: "Includes schema information and supported messages for the Routing diagnostic (msdyn_unifiedroutingrun) table/entity with Microsoft Dynamics 365 Customer Service."
ms.topic: generated-reference
author: gandhamm
ms.author: mgandham
search.audienceType: 
  - developer
---

# Routing diagnostic (msdyn_unifiedroutingrun) table/entity reference (Microsoft Dynamics 365 Customer Service)



> [!NOTE]
> The Microsoft Dynamics 365 Customer Service Routing diagnostic (msdyn_unifiedroutingrun) table extends the [Microsoft Dynamics 365 Routing diagnostic (msdyn_unifiedroutingrun) table](/dynamics365/developer/reference/entities/msdyn_unifiedroutingrun).



## Customized columns/attributes

Microsoft Dynamics 365 Customer Service modifies the definition of columns/attributes defined in other solutions. Listed by **SchemaName**.

### <a name="BKMK_msdyn_targetobject"></a> msdyn_targetobject

Changes from [msdyn_targetobject (Microsoft Dynamics 365)](/dynamics365/developer/reference/entities/msdyn_unifiedroutingrun#BKMK_msdyn_targetobject)

|Property|Value|
|---|---|
|Targets|msdyn_ocvoicemail|


## Many-to-One relationships

These relationships are many-to-one. Listed by **SchemaName**.

### <a name="BKMK_msdyn_unifiedroutingrun_msdyn_ocvoicemail_msdyn_targetobject"></a> msdyn_unifiedroutingrun_msdyn_ocvoicemail_msdyn_targetobject

One-To-Many Relationship: [msdyn_ocvoicemail msdyn_unifiedroutingrun_msdyn_ocvoicemail_msdyn_targetobject](msdyn_ocvoicemail.md#BKMK_msdyn_unifiedroutingrun_msdyn_ocvoicemail_msdyn_targetobject)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_ocvoicemail`|
|ReferencedAttribute|`activityid`|
|ReferencingAttribute|`msdyn_targetobject`|
|ReferencingEntityNavigationPropertyName|`msdyn_targetobject_msdyn_ocvoicemail_msdyn_ocvoicemail`|
|IsHierarchical||
|CascadeConfiguration|Archive: `RemoveLink`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|



### See also

[Dataverse table/entity reference](/power-apps/developer/data-platform/reference/about-entity-reference)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   

