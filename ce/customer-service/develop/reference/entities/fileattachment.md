---
title: "FileAttachment table/entity reference (Microsoft Dynamics 365 Customer Service)"
description: "Includes schema information and supported messages for the FileAttachment table/entity with Microsoft Dynamics 365 Customer Service."
ms.topic: generated-reference
author: gandhamm
ms.author: mgandham
search.audienceType: 
  - developer
---

# FileAttachment table/entity reference (Microsoft Dynamics 365 Customer Service)

File Attachment

> [!NOTE]
> The Microsoft Dynamics 365 Customer Service FileAttachment table extends the [Microsoft Dynamics 365 FileAttachment table](/dynamics365/developer/reference/entities/fileattachment).



## Customized columns/attributes

Microsoft Dynamics 365 Customer Service modifies the definition of columns/attributes defined in other solutions. Listed by **SchemaName**.

### <a name="BKMK_ObjectId"></a> ObjectId

Changes from [ObjectId (Microsoft Dataverse)](/power-apps/developer/data-platform/reference/entities/fileattachment#BKMK_ObjectId)

|Property|Value|
|---|---|
|Targets|msdyn_ocphonemusic|


## Many-to-One relationships

These relationships are many-to-one. Listed by **SchemaName**.

### <a name="BKMK_msdyn_ocphonemusic_FileAttachments"></a> msdyn_ocphonemusic_FileAttachments

One-To-Many Relationship: [msdyn_ocphonemusic msdyn_ocphonemusic_FileAttachments](msdyn_ocphonemusic.md#BKMK_msdyn_ocphonemusic_FileAttachments)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_ocphonemusic`|
|ReferencedAttribute|`msdyn_ocphonemusicid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_ocphonemusic`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|


## One-to-Many relationships

These relationships are one-to-many. Listed by **SchemaName**.

### <a name="BKMK_FileAttachment_msdyn_ocphonemusic_msdyn_musicfile"></a> FileAttachment_msdyn_ocphonemusic_msdyn_musicfile

Many-To-One Relationship: [msdyn_ocphonemusic FileAttachment_msdyn_ocphonemusic_msdyn_musicfile](msdyn_ocphonemusic.md#BKMK_FileAttachment_msdyn_ocphonemusic_msdyn_musicfile)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocphonemusic`|
|ReferencingAttribute|`msdyn_musicfile`|
|ReferencedEntityNavigationPropertyName|`FileAttachment_msdyn_ocphonemusic_msdyn_musicfile`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|



### See also

[Dataverse table/entity reference](/power-apps/developer/data-platform/reference/about-entity-reference)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   
<xref:Microsoft.Dynamics.CRM.fileattachment?displayProperty=fullName>
