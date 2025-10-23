---
title: "Feedback table/entity reference (Microsoft Dynamics 365 Customer Service)"
description: "Includes schema information and supported messages for the Feedback table/entity with Microsoft Dynamics 365 Customer Service."
ms.topic: generated-reference
author: gandhamm
ms.author: mgandham
search.audienceType: 
  - developer
---

# Feedback table/entity reference (Microsoft Dynamics 365 Customer Service)

Feedback and rating.

> [!NOTE]
> The Microsoft Dynamics 365 Customer Service Feedback table extends the [Microsoft Dynamics 365 Feedback table](/dynamics365/developer/reference/entities/feedback).



## Customized columns/attributes

Microsoft Dynamics 365 Customer Service modifies the definition of columns/attributes defined in other solutions. Listed by **SchemaName**.

### <a name="BKMK_RegardingObjectId"></a> RegardingObjectId

Changes from [RegardingObjectId (Microsoft Dataverse)](/power-apps/developer/data-platform/reference/entities/feedback#BKMK_RegardingObjectId)

|Property|Value|
|---|---|
|Targets|msdyn_ocoutboundmessage, msdyn_ocvoicemail|


## Many-to-One relationships

These relationships are many-to-one. Listed by **SchemaName**.

- [msdyn_ocoutboundmessage_Feedback](#BKMK_msdyn_ocoutboundmessage_Feedback)
- [msdyn_ocvoicemail_Feedback](#BKMK_msdyn_ocvoicemail_Feedback)

### <a name="BKMK_msdyn_ocoutboundmessage_Feedback"></a> msdyn_ocoutboundmessage_Feedback

One-To-Many Relationship: [msdyn_ocoutboundmessage msdyn_ocoutboundmessage_Feedback](msdyn_ocoutboundmessage.md#BKMK_msdyn_ocoutboundmessage_Feedback)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_ocoutboundmessage`|
|ReferencedAttribute|`activityid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_ocoutboundmessage`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_ocvoicemail_Feedback"></a> msdyn_ocvoicemail_Feedback

One-To-Many Relationship: [msdyn_ocvoicemail msdyn_ocvoicemail_Feedback](msdyn_ocvoicemail.md#BKMK_msdyn_ocvoicemail_Feedback)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_ocvoicemail`|
|ReferencedAttribute|`activityid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_ocvoicemail`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|



### See also

[Dataverse table/entity reference](/power-apps/developer/data-platform/reference/about-entity-reference)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   
<xref:Microsoft.Dynamics.CRM.feedback?displayProperty=fullName>
