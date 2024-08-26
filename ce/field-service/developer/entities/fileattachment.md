---
title: "FileAttachment table/entity reference (Microsoft Dynamics 365 Field Service)"
description: "Includes schema information and supported messages for the FileAttachment table/entity with Microsoft Dynamics 365 Field Service."
ms.date: 08/26/2024
ms.service: powerapps
ms.topic: reference
author: m-hartmann
ms.author: mhart
search.audienceType: 
  - developer
---

# FileAttachment table/entity reference (Microsoft Dynamics 365 Field Service)

File Attachment

> [!NOTE]
> The Microsoft Dynamics 365 Field Service FileAttachment table extends the [Microsoft Dynamics 365 FileAttachment table](/dynamics365/developer/entities/fileattachment).



## Customized columns/attributes

Microsoft Dynamics 365 Field Service modifies the definition of columns/attributes defined in other solutions. Listed by **SchemaName**.

### <a name="BKMK_ObjectId"></a> ObjectId

Changes from [ObjectId (Microsoft Dataverse)](/power-apps/developer/data-platform/reference/entities/fileattachment#BKMK_ObjectId)

|Property|Value|
|---|---|
|Targets|msdyn_bookableresourcebookingquicknote|


## Many-to-One relationships

These relationships are many-to-one. Listed by **SchemaName**.

### <a name="BKMK_msdyn_bookableresourcebookingquicknote_FileAttachments"></a> msdyn_bookableresourcebookingquicknote_FileAttachments

One-To-Many Relationship: [msdyn_bookableresourcebookingquicknote msdyn_bookableresourcebookingquicknote_FileAttachments](msdyn_bookableresourcebookingquicknote.md#BKMK_msdyn_bookableresourcebookingquicknote_FileAttachments)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_bookableresourcebookingquicknote`|
|ReferencedAttribute|`msdyn_bookableresourcebookingquicknoteid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_bookableresourcebookingquicknote`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|


## One-to-Many relationships

These relationships are one-to-many. Listed by **SchemaName**.

### <a name="BKMK_FileAttachment_msdyn_bookableresourcebookingquicknote_msdyn_file"></a> FileAttachment_msdyn_bookableresourcebookingquicknote_msdyn_file

Many-To-One Relationship: [msdyn_bookableresourcebookingquicknote FileAttachment_msdyn_bookableresourcebookingquicknote_msdyn_file](msdyn_bookableresourcebookingquicknote.md#BKMK_FileAttachment_msdyn_bookableresourcebookingquicknote_msdyn_file)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_bookableresourcebookingquicknote`|
|ReferencingAttribute|`msdyn_file`|
|ReferencedEntityNavigationPropertyName|`FileAttachment_msdyn_bookableresourcebookingquicknote_msdyn_file`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|



### See also

[Dataverse table/entity reference](../about-entity-reference.md)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   
<xref:Microsoft.Dynamics.CRM.fileattachment?displayProperty=fullName>
