---
title: "Recording (msdyn_ocrecording) table/entity reference (Microsoft Dynamics 365 Customer Service)"
description: "Includes schema information and supported messages for the Recording (msdyn_ocrecording) table/entity with Microsoft Dynamics 365 Customer Service."
ms.topic: generated-reference
author: gandhamm
ms.author: mgandham
search.audienceType: 
  - developer
---

# Recording (msdyn_ocrecording) table/entity reference (Microsoft Dynamics 365 Customer Service)

Records the audio/video session

> [!NOTE]
> The Microsoft Dynamics 365 Customer Service Recording (msdyn_ocrecording) table extends the [Microsoft Dynamics 365 Recording (msdyn_ocrecording) table](/dynamics365/developer/reference/entities/msdyn_ocrecording).



## Writable columns/attributes

These columns/attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

### <a name="BKMK_msdyn_platformrecordingid"></a> msdyn_platformrecordingid

|Property|Value|
|---|---|
|Description|**The recording id from the platform.**|
|DisplayName|**Platform Recording Id**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_platformrecordingid`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|500|


## Customized columns/attributes

Microsoft Dynamics 365 Customer Service modifies the definition of columns/attributes defined in other solutions. Listed by **SchemaName**.

### <a name="BKMK_msdyn_recordingtarget"></a> msdyn_recordingtarget

Changes from [msdyn_recordingtarget (Microsoft Dynamics 365)](/dynamics365/developer/reference/entities/msdyn_ocrecording#BKMK_msdyn_recordingtarget)

|Property|Value|
|---|---|
|Targets|msdyn_ocvoicemail|


## Many-to-One relationships

These relationships are many-to-one. Listed by **SchemaName**.

### <a name="BKMK_msdyn_msdyn_ocvoicemail_msdyn_ocrecording_voicemailid_recordingtarget"></a> msdyn_msdyn_ocvoicemail_msdyn_ocrecording_voicemailid_recordingtarget

One-To-Many Relationship: [msdyn_ocvoicemail msdyn_msdyn_ocvoicemail_msdyn_ocrecording_voicemailid_recordingtarget](msdyn_ocvoicemail.md#BKMK_msdyn_msdyn_ocvoicemail_msdyn_ocrecording_voicemailid_recordingtarget)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_ocvoicemail`|
|ReferencedAttribute|`activityid`|
|ReferencingAttribute|`msdyn_recordingtarget`|
|ReferencingEntityNavigationPropertyName|`msdyn_recordingtarget_msdyn_voicemailid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|



### See also

[Dataverse table/entity reference](/power-apps/developer/data-platform/reference/about-entity-reference)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   

