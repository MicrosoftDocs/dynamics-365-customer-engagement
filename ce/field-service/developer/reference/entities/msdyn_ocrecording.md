---
title: "Recording (msdyn_ocrecording) table/entity reference (Microsoft Dynamics 365 Field Service)"
description: "Includes schema information and supported messages for the Recording (msdyn_ocrecording) table/entity with Microsoft Dynamics 365 Field Service."
ms.topic: generated-reference
author: puneet-singh1
ms.author: puneetsingh
search.audienceType: 
  - developer
---

# Recording (msdyn_ocrecording) table/entity reference (Microsoft Dynamics 365 Field Service)

Records the audio/video session

> [!NOTE]
> The Microsoft Dynamics 365 Field Service Recording (msdyn_ocrecording) table extends the [Microsoft Dynamics 365 Recording (msdyn_ocrecording) table](/dynamics365/developer/reference/entities/msdyn_ocrecording).



## Writable columns/attributes

These columns/attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [msdyn_originalstored](#BKMK_msdyn_originalstored)
- [msdyn_platformrecordingid](#BKMK_msdyn_platformrecordingid)
- [msdyn_redactionapplied](#BKMK_msdyn_redactionapplied)
- [msdyn_redactionenabled](#BKMK_msdyn_redactionenabled)

### <a name="BKMK_msdyn_originalstored"></a> msdyn_originalstored

|Property|Value|
|---|---|
|Description|**Indicates whether the original unredacted copy was stored.**|
|DisplayName|**Original Stored**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_originalstored`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`msdyn_ocrecording_msdyn_originalstored`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

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

### <a name="BKMK_msdyn_redactionapplied"></a> msdyn_redactionapplied

|Property|Value|
|---|---|
|Description|**Indicates whether redaction was successfully applied to the recording.**|
|DisplayName|**Redaction Applied**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_redactionapplied`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`msdyn_ocrecording_msdyn_redactionapplied`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_msdyn_redactionenabled"></a> msdyn_redactionenabled

|Property|Value|
|---|---|
|Description|**Indicates whether redaction was enabled for this recording.**|
|DisplayName|**Redaction Enabled**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_redactionenabled`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`msdyn_ocrecording_msdyn_redactionenabled`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|


## Customized columns/attributes

Microsoft Dynamics 365 Field Service modifies the definition of columns/attributes defined in other solutions. Listed by **SchemaName**.

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

