---
title: "OC Payment Profile (msdyn_ocpaymentprofile) table/entity reference (Microsoft Dynamics 365 Customer Service)"
description: "Includes schema information and supported messages for the OC Payment Profile (msdyn_ocpaymentprofile) table/entity with Microsoft Dynamics 365 Customer Service."
ms.topic: generated-reference
author: gandhamm
ms.author: mgandham
search.audienceType: 
  - developer
---

# OC Payment Profile (msdyn_ocpaymentprofile) table/entity reference (Microsoft Dynamics 365 Customer Service)



> [!NOTE]
> The Microsoft Dynamics 365 Customer Service OC Payment Profile (msdyn_ocpaymentprofile) table extends the [Microsoft Dynamics 365 OC Payment Profile (msdyn_ocpaymentprofile) table](/dynamics365/developer/reference/entities/msdyn_ocpaymentprofile).



## Writable columns/attributes

These columns/attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

### <a name="BKMK_msdyn_ocapplepayid"></a> msdyn_ocapplepayid

|Property|Value|
|---|---|
|Description||
|DisplayName|**OC Apple Pay Id**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_ocapplepayid`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|msdyn_ocapplepay|


## Many-to-One relationships

These relationships are many-to-one. Listed by **SchemaName**.

### <a name="BKMK_msdyn_msdyn_ocapplepay_msdyn_ocpaymentprofile_ocapplepayid"></a> msdyn_msdyn_ocapplepay_msdyn_ocpaymentprofile_ocapplepayid

One-To-Many Relationship: [msdyn_ocapplepay msdyn_msdyn_ocapplepay_msdyn_ocpaymentprofile_ocapplepayid](msdyn_ocapplepay.md#BKMK_msdyn_msdyn_ocapplepay_msdyn_ocpaymentprofile_ocapplepayid)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_ocapplepay`|
|ReferencedAttribute|`msdyn_ocapplepayid`|
|ReferencingAttribute|`msdyn_ocapplepayid`|
|ReferencingEntityNavigationPropertyName|`msdyn_ocapplepayid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|


## One-to-Many relationships

These relationships are one-to-many. Listed by **SchemaName**.

### <a name="BKMK_msdyn_msdyn_ocpaymentprofile_msdyn_ocapplebusinessaccount_ocpaymentprofileid"></a> msdyn_msdyn_ocpaymentprofile_msdyn_ocapplebusinessaccount_ocpaymentprofileid

Many-To-One Relationship: [msdyn_ocapplebusinessaccount msdyn_msdyn_ocpaymentprofile_msdyn_ocapplebusinessaccount_ocpaymentprofileid](msdyn_ocapplebusinessaccount.md#BKMK_msdyn_msdyn_ocpaymentprofile_msdyn_ocapplebusinessaccount_ocpaymentprofileid)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocapplebusinessaccount`|
|ReferencingAttribute|`msdyn_ocpaymentprofileid`|
|ReferencedEntityNavigationPropertyName|`msdyn_msdyn_ocpaymentprofile_msdyn_ocapplebusinessaccount_ocpaymentprofileid`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|



### See also

[Dataverse table/entity reference](/power-apps/developer/data-platform/reference/about-entity-reference)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   

