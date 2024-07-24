---
title: "Guide (msmrw_guide) table/entity reference (Microsoft Dynamics 365 Field Service)"
description: "Includes schema information and supported messages for the Guide (msmrw_guide) table/entity with Microsoft Dynamics 365 Field Service."
ms.date: 07.24.2024
ms.service: powerapps
ms.topic: reference
author: m-hartmann
ms.author: mhart
search.audienceType: 
  - developer
---

# Guide (msmrw_guide) table/entity reference

Stores information about the content of a guide, including its anchor information.

## Messages

The following table lists the messages for the Guide (msmrw_guide) table.
Messages represent operations that can be performed on the table. They may also be events.

| Name <br />Is Event? |Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `Assign`<br />Event: True |`PATCH` /msmrw_guides(*msmrw_guideid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `ownerid` property. |<xref:Microsoft.Crm.Sdk.Messages.AssignRequest>|
| `Create`<br />Event: True |`POST` /msmrw_guides<br />See [Create](/powerapps/developer/data-platform/webapi/create-entity-web-api) |[Create records](/power-apps/developer/data-platform/org-service/entity-operations-create#basic-create)|
| `CreateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.CreateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.CreateMultipleRequest>|
| `Delete`<br />Event: True |`DELETE` /msmrw_guides(*msmrw_guideid*)<br />See [Delete](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-delete) |[Delete records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-delete)|
| `GrantAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.GrantAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.GrantAccessRequest>|
| `IsValidStateTransition`<br />Event: False |<xref:Microsoft.Dynamics.CRM.IsValidStateTransition?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.IsValidStateTransitionRequest>|
| `ModifyAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.ModifyAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.ModifyAccessRequest>|
| `msmrw_Copy`<br />Event: False |**msmrw_Copy action** |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `msmrw_RepairGuideStructureAction`<br />Event: False |**msmrw_RepairGuideStructureAction action** |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `msmrw_UpgradeGuideSchema`<br />Event: False |**msmrw_UpgradeGuideSchema action** |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Restore`<br />Event: True |<xref:Microsoft.Dynamics.CRM.Restore?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retrieve`<br />Event: True |`GET` /msmrw_guides(*msmrw_guideid*)<br />See [Retrieve](/powerapps/developer/data-platform/webapi/retrieve-entity-using-web-api) |[Retrieve records](/power-apps/developer/data-platform/org-service/entity-operations-retrieve)|
| `RetrieveMultiple`<br />Event: True |`GET` /msmrw_guides<br />See [Query data](/power-apps/developer/data-platform/webapi/query-data-web-api) |[Query data](/power-apps/developer/data-platform/org-service/entity-operations-query-data)|
| `RetrievePrincipalAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RetrievePrincipalAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RetrievePrincipalAccessRequest>|
| `RetrieveSharedPrincipalsAndAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RetrieveSharedPrincipalsAndAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RetrieveSharedPrincipalsAndAccessRequest>|
| `RevokeAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RevokeAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RevokeAccessRequest>|
| `SetState`<br />Event: True |`PATCH` /msmrw_guides(*msmrw_guideid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `statecode` and `statuscode` properties. |<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|
| `Update`<br />Event: True |`PATCH` /msmrw_guides(*msmrw_guideid*)<br />See [Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) |[Update records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-update)|
| `UpdateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.UpdateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpdateMultipleRequest>|
| `Upsert`<br />Event: False |`PATCH` /msmrw_guides(*msmrw_guideid*)<br />See [Upsert a table row](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#upsert-a-table-row) |<xref:Microsoft.Xrm.Sdk.Messages.UpsertRequest>|
| `UpsertMultiple`<br />Event: False |<xref:Microsoft.Dynamics.CRM.UpsertMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpsertMultipleRequest>|


## Events

The following table lists the events for the Guide (msmrw_guide) table.
Events are messages that exist so that you can subscribe to them. Unless you added the event, you shouldn't invoke the message, only subscribe to it.

|Name|Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `BulkRetain`|<xref:Microsoft.Dynamics.CRM.BulkRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `PurgeRetainedContent`|<xref:Microsoft.Dynamics.CRM.PurgeRetainedContent?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retain`|<xref:Microsoft.Dynamics.CRM.Retain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `RollbackRetain`|<xref:Microsoft.Dynamics.CRM.RollbackRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `ValidateRetentionConfig`|<xref:Microsoft.Dynamics.CRM.ValidateRetentionConfig?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|

## Properties

The following table lists selected properties for the Guide (msmrw_guide) table.

|Property|Value|
| --- | --- |
| **DisplayName** | **Guide** |
| **DisplayCollectionName** | **Guides** |
| **SchemaName** | `msmrw_guide` |
| **CollectionSchemaName** | `msmrw_guides` |
| **EntitySetName** | `msmrw_guides`|
| **LogicalName** | `msmrw_guide` |
| **LogicalCollectionName** | `msmrw_guides` |
| **PrimaryIdAttribute** | `msmrw_guideid` |
| **PrimaryNameAttribute** |`msmrw_name` |
| **TableType** | `Standard` |
| **OwnershipType** | `UserOwned` |

## Writable columns/attributes

These columns/attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [msdyn_AnchorObjectAnchor](#BKMK_msdyn_AnchorObjectAnchor)
- [msdyn_ParentFolderId](#BKMK_msdyn_ParentFolderId)
- [msmrw_Anchor3DObject](#BKMK_msmrw_Anchor3DObject)
- [msmrw_Anchor3DObjectIsAnimated](#BKMK_msmrw_Anchor3DObjectIsAnimated)
- [msmrw_Anchor3DObjectStyle](#BKMK_msmrw_Anchor3DObjectStyle)
- [msmrw_AnchorStepImage](#BKMK_msmrw_AnchorStepImage)
- [msmrw_AnchorStepInstructionText](#BKMK_msmrw_AnchorStepInstructionText)
- [msmrw_AnchorStepVideo](#BKMK_msmrw_AnchorStepVideo)
- [msmrw_AnchorType](#BKMK_msmrw_AnchorType)
- [msmrw_CompletionAttentionDirector3DObject](#BKMK_msmrw_CompletionAttentionDirector3DObject)
- [msmrw_CompletionAttentionDirectorEndpointType](#BKMK_msmrw_CompletionAttentionDirectorEndpointType)
- [msmrw_CompletionAttentionDirectorIsPlaced](#BKMK_msmrw_CompletionAttentionDirectorIsPlaced)
- [msmrw_CompletionAttentionDirectorPositionX](#BKMK_msmrw_CompletionAttentionDirectorPositionX)
- [msmrw_CompletionAttentionDirectorPositionY](#BKMK_msmrw_CompletionAttentionDirectorPositionY)
- [msmrw_CompletionAttentionDirectorPositionZ](#BKMK_msmrw_CompletionAttentionDirectorPositionZ)
- [msmrw_CompletionAttentionDirectorRotationW](#BKMK_msmrw_CompletionAttentionDirectorRotationW)
- [msmrw_CompletionAttentionDirectorRotationX](#BKMK_msmrw_CompletionAttentionDirectorRotationX)
- [msmrw_CompletionAttentionDirectorRotationY](#BKMK_msmrw_CompletionAttentionDirectorRotationY)
- [msmrw_CompletionAttentionDirectorRotationZ](#BKMK_msmrw_CompletionAttentionDirectorRotationZ)
- [msmrw_CompletionImage](#BKMK_msmrw_CompletionImage)
- [msmrw_CompletionInstructionText](#BKMK_msmrw_CompletionInstructionText)
- [msmrw_CompletionVideo](#BKMK_msmrw_CompletionVideo)
- [msmrw_guideId](#BKMK_msmrw_guideId)
- [msmrw_integrationkey](#BKMK_msmrw_integrationkey)
- [msmrw_name](#BKMK_msmrw_name)
- [msmrw_SchemaVersion](#BKMK_msmrw_SchemaVersion)
- [OverriddenCreatedOn](#BKMK_OverriddenCreatedOn)
- [OwnerId](#BKMK_OwnerId)
- [OwnerIdType](#BKMK_OwnerIdType)
- [statecode](#BKMK_statecode)
- [statuscode](#BKMK_statuscode)
- [TimeZoneRuleVersionNumber](#BKMK_TimeZoneRuleVersionNumber)
- [UTCConversionTimeZoneCode](#BKMK_UTCConversionTimeZoneCode)

### <a name="BKMK_ImportSequenceNumber"></a> ImportSequenceNumber

|Property|Value|
|---|---|
|Description|**Sequence number of the import that created this record.**|
|DisplayName|**Import Sequence Number**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`importsequencenumber`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|-2147483648|

### <a name="BKMK_msdyn_AnchorObjectAnchor"></a> msdyn_AnchorObjectAnchor

|Property|Value|
|---|---|
|Description||
|DisplayName|**Anchor Object Anchor**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_anchorobjectanchor`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|msdyn_objectanchor|

### <a name="BKMK_msdyn_ParentFolderId"></a> msdyn_ParentFolderId

|Property|Value|
|---|---|
|Description|**Reference to the parent folder for this guide.**|
|DisplayName|**Parent Folder**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_parentfolderid`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|msdyn_mrfolder|

### <a name="BKMK_msmrw_Anchor3DObject"></a> msmrw_Anchor3DObject

|Property|Value|
|---|---|
|Description|**Reference to the 3D object used as a holographic anchor.**|
|DisplayName|**Anchor 3D Object**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msmrw_anchor3dobject`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|msmrw_3dasset|

### <a name="BKMK_msmrw_Anchor3DObjectIsAnimated"></a> msmrw_Anchor3DObjectIsAnimated

|Property|Value|
|---|---|
|Description|**Defines whether the animation playback for the digital anchor is enabled.**|
|DisplayName|**Anchor 3D Object Is Animated**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msmrw_anchor3dobjectisanimated`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`msmrw_guide_msmrw_anchor3dobjectisanimated`|
|DefaultValue|True|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_msmrw_Anchor3DObjectStyle"></a> msmrw_Anchor3DObjectStyle

|Property|Value|
|---|---|
|Description|**Defines the visual style of the anchor 3D object. (Can be set to: Original, Pick up, Place, See-through 1, See-through 2, Warning, Avoid, X-Ray, Metal).**|
|DisplayName|**Anchor 3D Object Style**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msmrw_anchor3dobjectstyle`|
|RequiredLevel|None|
|Type|Picklist|
|DefaultFormValue|-1|
|GlobalChoiceName|`msmrw_guide3dobjectstyle`|

#### msmrw_Anchor3DObjectStyle Choices/Options

|Value|Label|
|---|---|
|937380000|**Original**|
|937380001|**Outline**|
|937380002|**Dashed Outline**|
|937380003|**50% Transparent**|
|937380004|**75% Transparent**|
|937380005|**Caution**|
|937380006|**Red**|
|937380007|**X-ray**|
|937380008|**Metallic**|
|937380009|**Green**|
|937380010|**Pass-through**|
|937380011|**Obscure**|

### <a name="BKMK_msmrw_AnchorStepImage"></a> msmrw_AnchorStepImage

|Property|Value|
|---|---|
|Description|**Reference to the image associated to the anchor step.**|
|DisplayName|**Anchor Step Image**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msmrw_anchorstepimage`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|msmrw_imageasset|

### <a name="BKMK_msmrw_AnchorStepInstructionText"></a> msmrw_AnchorStepInstructionText

|Property|Value|
|---|---|
|Description|**Instruction text on the anchor step.**|
|DisplayName|**Anchor Step Instruction Text**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msmrw_anchorstepinstructiontext`|
|RequiredLevel|None|
|Type|Memo|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|10000|

### <a name="BKMK_msmrw_AnchorStepVideo"></a> msmrw_AnchorStepVideo

|Property|Value|
|---|---|
|Description|**Reference to the video associated to the anchor step.**|
|DisplayName|**Anchor Step Video**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msmrw_anchorstepvideo`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|msmrw_videoasset|

### <a name="BKMK_msmrw_AnchorType"></a> msmrw_AnchorType

|Property|Value|
|---|---|
|Description|**Specifies the anchor type chosen for the guide (Can be set to: Holographic, CircularCode, QR Code).**|
|DisplayName|**Anchor Type**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msmrw_anchortype`|
|RequiredLevel|None|
|Type|Picklist|
|DefaultFormValue|-1|
|GlobalChoiceName|`msmrw_guideanchortype`|

#### msmrw_AnchorType Choices/Options

|Value|Label|
|---|---|
|937380000|**Holographic**|
|937380001|**CircularCode**|
|937380002|**Undecided**|
|937380005|**QRCode**|
|937380006|**Object**|

### <a name="BKMK_msmrw_CompletionAttentionDirector3DObject"></a> msmrw_CompletionAttentionDirector3DObject

|Property|Value|
|---|---|
|Description|**Reference to the 3D object that the attention director points to in the completion step.**|
|DisplayName|**Completion Step Attention Director 3D Object**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msmrw_completionattentiondirector3dobject`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|msmrw_guidecompletionstepobjectplacement|

### <a name="BKMK_msmrw_CompletionAttentionDirectorEndpointType"></a> msmrw_CompletionAttentionDirectorEndpointType

|Property|Value|
|---|---|
|Description|**Specifies what the attention director is attached to. (Can be set to: Spatial Location, 3D Object, Anchor 3D Object, No Attachment).**|
|DisplayName|**Completion Step Attention Director Endpoint Type**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msmrw_completionattentiondirectorendpointtype`|
|RequiredLevel|None|
|Type|Picklist|
|DefaultFormValue|-1|
|GlobalChoiceName|`msmrw_attentiondirectorendpointtype`|

#### msmrw_CompletionAttentionDirectorEndpointType Choices/Options

|Value|Label|
|---|---|
|937380000|**NoAttachment**|
|937380001|**SpatialLocation**|
|937380002|**3DObject**|
|937380003|**Anchor3DObject**|

### <a name="BKMK_msmrw_CompletionAttentionDirectorIsPlaced"></a> msmrw_CompletionAttentionDirectorIsPlaced

|Property|Value|
|---|---|
|Description|**Defines whether the attention director in the completion step is spatially placed.**|
|DisplayName|**Completion Step Attention Director Is Placed**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msmrw_completionattentiondirectorisplaced`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`msmrw_guide_msmrw_completionattentiondirectorisplaced`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_msmrw_CompletionAttentionDirectorPositionX"></a> msmrw_CompletionAttentionDirectorPositionX

|Property|Value|
|---|---|
|Description|**Spatial location of the attention director endpoint in the completion step along the X axis.**|
|DisplayName|**Completion Step Attention Director Position X**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msmrw_completionattentiondirectorpositionx`|
|RequiredLevel|None|
|Type|Double|
|ImeMode|Auto|
|MaxValue|300000|
|MinValue|-300000|
|Precision|5|

### <a name="BKMK_msmrw_CompletionAttentionDirectorPositionY"></a> msmrw_CompletionAttentionDirectorPositionY

|Property|Value|
|---|---|
|Description|**Spatial location of the attention director endpoint in the completion step along the Y axis.**|
|DisplayName|**Completion Step Attention Director Position Y**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msmrw_completionattentiondirectorpositiony`|
|RequiredLevel|None|
|Type|Double|
|ImeMode|Auto|
|MaxValue|300000|
|MinValue|-300000|
|Precision|5|

### <a name="BKMK_msmrw_CompletionAttentionDirectorPositionZ"></a> msmrw_CompletionAttentionDirectorPositionZ

|Property|Value|
|---|---|
|Description|**Spatial location of the attention director endpoint in the completion step along the Z axis.**|
|DisplayName|**Completion Step Attention Director Position Z**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msmrw_completionattentiondirectorpositionz`|
|RequiredLevel|None|
|Type|Double|
|ImeMode|Auto|
|MaxValue|300000|
|MinValue|-300000|
|Precision|5|

### <a name="BKMK_msmrw_CompletionAttentionDirectorRotationW"></a> msmrw_CompletionAttentionDirectorRotationW

|Property|Value|
|---|---|
|Description|**Rotational quaternion of the attention director in the completion step along the W component.**|
|DisplayName|**Completion Step Attention Director Rotation W**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msmrw_completionattentiondirectorrotationw`|
|RequiredLevel|None|
|Type|Double|
|ImeMode|Auto|
|MaxValue|1|
|MinValue|-1|
|Precision|5|

### <a name="BKMK_msmrw_CompletionAttentionDirectorRotationX"></a> msmrw_CompletionAttentionDirectorRotationX

|Property|Value|
|---|---|
|Description|**Rotational quaternion of the attention director in the completion step along the X component.**|
|DisplayName|**Completion Step Attention Director Rotation X**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msmrw_completionattentiondirectorrotationx`|
|RequiredLevel|None|
|Type|Double|
|ImeMode|Auto|
|MaxValue|1|
|MinValue|-1|
|Precision|5|

### <a name="BKMK_msmrw_CompletionAttentionDirectorRotationY"></a> msmrw_CompletionAttentionDirectorRotationY

|Property|Value|
|---|---|
|Description|**Rotational quaternion of the attention director in the completion step along the Y component.**|
|DisplayName|**Completion Step Attention Director Rotation Y**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msmrw_completionattentiondirectorrotationy`|
|RequiredLevel|None|
|Type|Double|
|ImeMode|Auto|
|MaxValue|1|
|MinValue|-1|
|Precision|5|

### <a name="BKMK_msmrw_CompletionAttentionDirectorRotationZ"></a> msmrw_CompletionAttentionDirectorRotationZ

|Property|Value|
|---|---|
|Description|**Rotational quaternion of the attention director in the completion step along the Z component.**|
|DisplayName|**Completion Step Attention Director Rotation Z**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msmrw_completionattentiondirectorrotationz`|
|RequiredLevel|None|
|Type|Double|
|ImeMode|Auto|
|MaxValue|1|
|MinValue|-1|
|Precision|5|

### <a name="BKMK_msmrw_CompletionImage"></a> msmrw_CompletionImage

|Property|Value|
|---|---|
|Description|**Reference to the image associated to the completion step.**|
|DisplayName|**Completion Step Image**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msmrw_completionimage`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|msmrw_imageasset|

### <a name="BKMK_msmrw_CompletionInstructionText"></a> msmrw_CompletionInstructionText

|Property|Value|
|---|---|
|Description|**Instruction text on the completion step.**|
|DisplayName|**Completion Step Instruction Text**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msmrw_completioninstructiontext`|
|RequiredLevel|None|
|Type|Memo|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|10000|

### <a name="BKMK_msmrw_CompletionVideo"></a> msmrw_CompletionVideo

|Property|Value|
|---|---|
|Description|**Reference to the video associated to the completion step.**|
|DisplayName|**Completion Step Video**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msmrw_completionvideo`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|msmrw_videoasset|

### <a name="BKMK_msmrw_guideId"></a> msmrw_guideId

|Property|Value|
|---|---|
|Description|**Unique identifier for a guide.**|
|DisplayName|**Guide**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`msmrw_guideid`|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|

### <a name="BKMK_msmrw_integrationkey"></a> msmrw_integrationkey

|Property|Value|
|---|---|
|Description|**Guide identification for integrations.**|
|DisplayName|**Integration Key**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msmrw_integrationkey`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msmrw_name"></a> msmrw_name

|Property|Value|
|---|---|
|Description|**The name of the custom entity. For internal use only.**|
|DisplayName|**Name**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msmrw_name`|
|RequiredLevel|ApplicationRequired|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msmrw_SchemaVersion"></a> msmrw_SchemaVersion

|Property|Value|
|---|---|
|Description|**For internal use only. Version number for the Guides JSON schema.**|
|DisplayName|**Schema Version**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msmrw_schemaversion`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|-2147483648|

### <a name="BKMK_OverriddenCreatedOn"></a> OverriddenCreatedOn

|Property|Value|
|---|---|
|Description|**Date and time that the record was migrated.**|
|DisplayName|**Record Created On**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`overriddencreatedon`|
|RequiredLevel|None|
|Type|DateTime|
|CanChangeDateTimeBehavior|False|
|DateTimeBehavior|UserLocal|
|Format|DateOnly|
|ImeMode|Inactive|
|SourceTypeMask|0|

### <a name="BKMK_OwnerId"></a> OwnerId

|Property|Value|
|---|---|
|Description|**Owner Id**|
|DisplayName|**Owner**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`ownerid`|
|RequiredLevel|SystemRequired|
|Type|Owner|
|Targets|systemuser, team|

### <a name="BKMK_OwnerIdType"></a> OwnerIdType

|Property|Value|
|---|---|
|Description|**Owner Id Type**|
|DisplayName||
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`owneridtype`|
|RequiredLevel|SystemRequired|
|Type|EntityName|

### <a name="BKMK_statecode"></a> statecode

|Property|Value|
|---|---|
|Description|**Status of the Guide**|
|DisplayName|**Status**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statecode`|
|RequiredLevel|SystemRequired|
|Type|State|
|DefaultFormValue||
|GlobalChoiceName|`msmrw_guide_statecode`|

#### statecode Choices/Options

|Value|Details|
|---|---|
|0|Label: **Active**<br />DefaultStatus: 1<br />InvariantName: `Active`|
|1|Label: **Inactive**<br />DefaultStatus: 2<br />InvariantName: `Inactive`|

### <a name="BKMK_statuscode"></a> statuscode

|Property|Value|
|---|---|
|Description|**Reason for the status of the Guide**|
|DisplayName|**Status Reason**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statuscode`|
|RequiredLevel|None|
|Type|Status|
|DefaultFormValue||
|GlobalChoiceName|`msmrw_guide_statuscode`|

#### statuscode Choices/Options

|Value|Details|
|---|---|
|1|Label: **Active**<br />State:0<br />TransitionData: None|
|2|Label: **Inactive**<br />State:1<br />TransitionData: None|

### <a name="BKMK_TimeZoneRuleVersionNumber"></a> TimeZoneRuleVersionNumber

|Property|Value|
|---|---|
|Description|**For internal use only.**|
|DisplayName|**Time Zone Rule Version Number**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`timezoneruleversionnumber`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|-1|

### <a name="BKMK_UTCConversionTimeZoneCode"></a> UTCConversionTimeZoneCode

|Property|Value|
|---|---|
|Description|**Time zone code that was in use when the record was created.**|
|DisplayName|**UTC Conversion Time Zone Code**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`utcconversiontimezonecode`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|-1|


## Read-only columns/attributes

These columns/attributes return false for both **IsValidForCreate** and **IsValidForUpdate**. Listed by **SchemaName**.

- [CreatedBy](#BKMK_CreatedBy)
- [CreatedOn](#BKMK_CreatedOn)
- [CreatedOnBehalfBy](#BKMK_CreatedOnBehalfBy)
- [ModifiedBy](#BKMK_ModifiedBy)
- [ModifiedOn](#BKMK_ModifiedOn)
- [ModifiedOnBehalfBy](#BKMK_ModifiedOnBehalfBy)
- [OwnerIdName](#BKMK_OwnerIdName)
- [OwnerIdYomiName](#BKMK_OwnerIdYomiName)
- [OwningBusinessUnit](#BKMK_OwningBusinessUnit)
- [OwningTeam](#BKMK_OwningTeam)
- [OwningUser](#BKMK_OwningUser)
- [VersionNumber](#BKMK_VersionNumber)

### <a name="BKMK_CreatedBy"></a> CreatedBy

|Property|Value|
|---|---|
|Description|**Unique identifier of the user who created the record.**|
|DisplayName|**Created By**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`createdby`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|systemuser|

### <a name="BKMK_CreatedOn"></a> CreatedOn

|Property|Value|
|---|---|
|Description|**Date and time when the record was created.**|
|DisplayName|**Created On**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`createdon`|
|RequiredLevel|None|
|Type|DateTime|
|CanChangeDateTimeBehavior|False|
|DateTimeBehavior|UserLocal|
|Format|DateAndTime|
|ImeMode|Inactive|
|SourceTypeMask|0|

### <a name="BKMK_CreatedOnBehalfBy"></a> CreatedOnBehalfBy

|Property|Value|
|---|---|
|Description|**Unique identifier of the delegate user who created the record.**|
|DisplayName|**Created By (Delegate)**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`createdonbehalfby`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|systemuser|

### <a name="BKMK_ModifiedBy"></a> ModifiedBy

|Property|Value|
|---|---|
|Description|**Unique identifier of the user who modified the record.**|
|DisplayName|**Modified By**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`modifiedby`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|systemuser|

### <a name="BKMK_ModifiedOn"></a> ModifiedOn

|Property|Value|
|---|---|
|Description|**Date and time when the record was modified.**|
|DisplayName|**Modified On**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`modifiedon`|
|RequiredLevel|None|
|Type|DateTime|
|CanChangeDateTimeBehavior|False|
|DateTimeBehavior|UserLocal|
|Format|DateAndTime|
|ImeMode|Inactive|
|SourceTypeMask|0|

### <a name="BKMK_ModifiedOnBehalfBy"></a> ModifiedOnBehalfBy

|Property|Value|
|---|---|
|Description|**Unique identifier of the delegate user who modified the record.**|
|DisplayName|**Modified By (Delegate)**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`modifiedonbehalfby`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|systemuser|

### <a name="BKMK_OwnerIdName"></a> OwnerIdName

|Property|Value|
|---|---|
|Description|**Name of the owner**|
|DisplayName||
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`owneridname`|
|RequiredLevel|SystemRequired|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_OwnerIdYomiName"></a> OwnerIdYomiName

|Property|Value|
|---|---|
|Description|**Yomi name of the owner**|
|DisplayName||
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`owneridyominame`|
|RequiredLevel|SystemRequired|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_OwningBusinessUnit"></a> OwningBusinessUnit

|Property|Value|
|---|---|
|Description|**Unique identifier for the business unit that owns the record**|
|DisplayName|**Owning Business Unit**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`owningbusinessunit`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|businessunit|

### <a name="BKMK_OwningTeam"></a> OwningTeam

|Property|Value|
|---|---|
|Description|**Unique identifier for the team that owns the record.**|
|DisplayName|**Owning Team**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`owningteam`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|team|

### <a name="BKMK_OwningUser"></a> OwningUser

|Property|Value|
|---|---|
|Description|**Unique identifier for the user that owns the record.**|
|DisplayName|**Owning User**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`owninguser`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|systemuser|

### <a name="BKMK_VersionNumber"></a> VersionNumber

|Property|Value|
|---|---|
|Description|**Version Number**|
|DisplayName|**Version Number**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`versionnumber`|
|RequiredLevel|None|
|Type|BigInt|
|MaxValue|9223372036854775807|
|MinValue|-9223372036854775808|

## Many-to-One relationships

These relationships are many-to-one. Listed by **SchemaName**.

- [business_unit_msmrw_guide](#BKMK_business_unit_msmrw_guide)
- [lk_msmrw_guide_createdby](#BKMK_lk_msmrw_guide_createdby)
- [lk_msmrw_guide_createdonbehalfby](#BKMK_lk_msmrw_guide_createdonbehalfby)
- [lk_msmrw_guide_modifiedby](#BKMK_lk_msmrw_guide_modifiedby)
- [lk_msmrw_guide_modifiedonbehalfby](#BKMK_lk_msmrw_guide_modifiedonbehalfby)
- [msdyn_msdyn_mrfolder_msmrw_guide](#BKMK_msdyn_msdyn_mrfolder_msmrw_guide)
- [msdyn_msmrw_guide_AnchorObjectAnchor_msdyn_obje](#BKMK_msdyn_msmrw_guide_AnchorObjectAnchor_msdyn_obje)
- [msmrw_msmrw_3dasset_msmrw_guide_Anchor3DObjectStyle](#BKMK_msmrw_msmrw_3dasset_msmrw_guide_Anchor3DObjectStyle)
- [msmrw_msmrw_guidecompletionstepobjectplacement_msmrw_guide_CompletionAttentionDirector3DObject](#BKMK_msmrw_msmrw_guidecompletionstepobjectplacement_msmrw_guide_CompletionAttentionDirector3DObject)
- [msmrw_msmrw_imageasset_msmrw_guide_AnchorStepImage](#BKMK_msmrw_msmrw_imageasset_msmrw_guide_AnchorStepImage)
- [msmrw_msmrw_imageasset_msmrw_guide_CompletionImage](#BKMK_msmrw_msmrw_imageasset_msmrw_guide_CompletionImage)
- [msmrw_msmrw_videoasset_msmrw_guide_AnchorStepVideo](#BKMK_msmrw_msmrw_videoasset_msmrw_guide_AnchorStepVideo)
- [msmrw_msmrw_videoasset_msmrw_guide_CompletionVideo](#BKMK_msmrw_msmrw_videoasset_msmrw_guide_CompletionVideo)
- [owner_msmrw_guide](#BKMK_owner_msmrw_guide)
- [team_msmrw_guide](#BKMK_team_msmrw_guide)
- [user_msmrw_guide](#BKMK_user_msmrw_guide)

### <a name="BKMK_business_unit_msmrw_guide"></a> business_unit_msmrw_guide

One-To-Many Relationship: [businessunit business_unit_msmrw_guide](businessunit.md#BKMK_business_unit_msmrw_guide)

|Property|Value|
|---|---|
|ReferencedEntity|`businessunit`|
|ReferencedAttribute|`businessunitid`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencingEntityNavigationPropertyName|`owningbusinessunit`|
|IsHierarchical||
|CascadeConfiguration|Archive: `Restrict`<br />Assign: `NoCascade`<br />Delete: `Restrict`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msmrw_guide_createdby"></a> lk_msmrw_guide_createdby

One-To-Many Relationship: [systemuser lk_msmrw_guide_createdby](systemuser.md#BKMK_lk_msmrw_guide_createdby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdby`|
|ReferencingEntityNavigationPropertyName|`createdby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msmrw_guide_createdonbehalfby"></a> lk_msmrw_guide_createdonbehalfby

One-To-Many Relationship: [systemuser lk_msmrw_guide_createdonbehalfby](systemuser.md#BKMK_lk_msmrw_guide_createdonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdonbehalfby`|
|ReferencingEntityNavigationPropertyName|`createdonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msmrw_guide_modifiedby"></a> lk_msmrw_guide_modifiedby

One-To-Many Relationship: [systemuser lk_msmrw_guide_modifiedby](systemuser.md#BKMK_lk_msmrw_guide_modifiedby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedby`|
|ReferencingEntityNavigationPropertyName|`modifiedby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msmrw_guide_modifiedonbehalfby"></a> lk_msmrw_guide_modifiedonbehalfby

One-To-Many Relationship: [systemuser lk_msmrw_guide_modifiedonbehalfby](systemuser.md#BKMK_lk_msmrw_guide_modifiedonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedonbehalfby`|
|ReferencingEntityNavigationPropertyName|`modifiedonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_msdyn_mrfolder_msmrw_guide"></a> msdyn_msdyn_mrfolder_msmrw_guide

One-To-Many Relationship: [msdyn_mrfolder msdyn_msdyn_mrfolder_msmrw_guide](msdyn_mrfolder.md#BKMK_msdyn_msdyn_mrfolder_msmrw_guide)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_mrfolder`|
|ReferencedAttribute|`msdyn_mrfolderid`|
|ReferencingAttribute|`msdyn_parentfolderid`|
|ReferencingEntityNavigationPropertyName|`msdyn_ParentFolderId`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_msmrw_guide_AnchorObjectAnchor_msdyn_obje"></a> msdyn_msmrw_guide_AnchorObjectAnchor_msdyn_obje

One-To-Many Relationship: [msdyn_objectanchor msdyn_msmrw_guide_AnchorObjectAnchor_msdyn_obje](msdyn_objectanchor.md#BKMK_msdyn_msmrw_guide_AnchorObjectAnchor_msdyn_obje)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_objectanchor`|
|ReferencedAttribute|`msdyn_objectanchorid`|
|ReferencingAttribute|`msdyn_anchorobjectanchor`|
|ReferencingEntityNavigationPropertyName|`msdyn_AnchorObjectAnchor`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msmrw_msmrw_3dasset_msmrw_guide_Anchor3DObjectStyle"></a> msmrw_msmrw_3dasset_msmrw_guide_Anchor3DObjectStyle

One-To-Many Relationship: [msmrw_3dasset msmrw_msmrw_3dasset_msmrw_guide_Anchor3DObjectStyle](msmrw_3dasset.md#BKMK_msmrw_msmrw_3dasset_msmrw_guide_Anchor3DObjectStyle)

|Property|Value|
|---|---|
|ReferencedEntity|`msmrw_3dasset`|
|ReferencedAttribute|`msmrw_3dassetid`|
|ReferencingAttribute|`msmrw_anchor3dobject`|
|ReferencingEntityNavigationPropertyName|`msmrw_Anchor3DObject`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msmrw_msmrw_guidecompletionstepobjectplacement_msmrw_guide_CompletionAttentionDirector3DObject"></a> msmrw_msmrw_guidecompletionstepobjectplacement_msmrw_guide_CompletionAttentionDirector3DObject

One-To-Many Relationship: [msmrw_guidecompletionstepobjectplacement msmrw_msmrw_guidecompletionstepobjectplacement_msmrw_guide_CompletionAttentionDirector3DObject](msmrw_guidecompletionstepobjectplacement.md#BKMK_msmrw_msmrw_guidecompletionstepobjectplacement_msmrw_guide_CompletionAttentionDirector3DObject)

|Property|Value|
|---|---|
|ReferencedEntity|`msmrw_guidecompletionstepobjectplacement`|
|ReferencedAttribute|`msmrw_guidecompletionstepobjectplacementid`|
|ReferencingAttribute|`msmrw_completionattentiondirector3dobject`|
|ReferencingEntityNavigationPropertyName|`msmrw_CompletionAttentionDirector3DObject`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msmrw_msmrw_imageasset_msmrw_guide_AnchorStepImage"></a> msmrw_msmrw_imageasset_msmrw_guide_AnchorStepImage

One-To-Many Relationship: [msmrw_imageasset msmrw_msmrw_imageasset_msmrw_guide_AnchorStepImage](msmrw_imageasset.md#BKMK_msmrw_msmrw_imageasset_msmrw_guide_AnchorStepImage)

|Property|Value|
|---|---|
|ReferencedEntity|`msmrw_imageasset`|
|ReferencedAttribute|`msmrw_imageassetid`|
|ReferencingAttribute|`msmrw_anchorstepimage`|
|ReferencingEntityNavigationPropertyName|`msmrw_AnchorStepImage`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msmrw_msmrw_imageasset_msmrw_guide_CompletionImage"></a> msmrw_msmrw_imageasset_msmrw_guide_CompletionImage

One-To-Many Relationship: [msmrw_imageasset msmrw_msmrw_imageasset_msmrw_guide_CompletionImage](msmrw_imageasset.md#BKMK_msmrw_msmrw_imageasset_msmrw_guide_CompletionImage)

|Property|Value|
|---|---|
|ReferencedEntity|`msmrw_imageasset`|
|ReferencedAttribute|`msmrw_imageassetid`|
|ReferencingAttribute|`msmrw_completionimage`|
|ReferencingEntityNavigationPropertyName|`msmrw_CompletionImage`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msmrw_msmrw_videoasset_msmrw_guide_AnchorStepVideo"></a> msmrw_msmrw_videoasset_msmrw_guide_AnchorStepVideo

One-To-Many Relationship: [msmrw_videoasset msmrw_msmrw_videoasset_msmrw_guide_AnchorStepVideo](msmrw_videoasset.md#BKMK_msmrw_msmrw_videoasset_msmrw_guide_AnchorStepVideo)

|Property|Value|
|---|---|
|ReferencedEntity|`msmrw_videoasset`|
|ReferencedAttribute|`msmrw_videoassetid`|
|ReferencingAttribute|`msmrw_anchorstepvideo`|
|ReferencingEntityNavigationPropertyName|`msmrw_AnchorStepVideo`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msmrw_msmrw_videoasset_msmrw_guide_CompletionVideo"></a> msmrw_msmrw_videoasset_msmrw_guide_CompletionVideo

One-To-Many Relationship: [msmrw_videoasset msmrw_msmrw_videoasset_msmrw_guide_CompletionVideo](msmrw_videoasset.md#BKMK_msmrw_msmrw_videoasset_msmrw_guide_CompletionVideo)

|Property|Value|
|---|---|
|ReferencedEntity|`msmrw_videoasset`|
|ReferencedAttribute|`msmrw_videoassetid`|
|ReferencingAttribute|`msmrw_completionvideo`|
|ReferencingEntityNavigationPropertyName|`msmrw_CompletionVideo`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_owner_msmrw_guide"></a> owner_msmrw_guide

One-To-Many Relationship: [owner owner_msmrw_guide](owner.md#BKMK_owner_msmrw_guide)

|Property|Value|
|---|---|
|ReferencedEntity|`owner`|
|ReferencedAttribute|`ownerid`|
|ReferencingAttribute|`ownerid`|
|ReferencingEntityNavigationPropertyName|`ownerid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_team_msmrw_guide"></a> team_msmrw_guide

One-To-Many Relationship: [team team_msmrw_guide](team.md#BKMK_team_msmrw_guide)

|Property|Value|
|---|---|
|ReferencedEntity|`team`|
|ReferencedAttribute|`teamid`|
|ReferencingAttribute|`owningteam`|
|ReferencingEntityNavigationPropertyName|`owningteam`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_user_msmrw_guide"></a> user_msmrw_guide

One-To-Many Relationship: [systemuser user_msmrw_guide](systemuser.md#BKMK_user_msmrw_guide)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`owninguser`|
|ReferencingEntityNavigationPropertyName|`owninguser`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|


## One-to-Many relationships

These relationships are one-to-many. Listed by **SchemaName**.

- [msdyn_GuideAuthorSession_GuideID_msmrw_gu](#BKMK_msdyn_GuideAuthorSession_GuideID_msmrw_gu)
- [msdyn_mrasjob_guide](#BKMK_msdyn_mrasjob_guide)
- [msdyn_msmrw_guide_msdyn_workorderservicetask](#BKMK_msdyn_msmrw_guide_msdyn_workorderservicetask)
- [msmrw_guide_Annotations](#BKMK_msmrw_guide_Annotations)
- [msmrw_guide_AsyncOperations](#BKMK_msmrw_guide_AsyncOperations)
- [msmrw_guide_BulkDeleteFailures](#BKMK_msmrw_guide_BulkDeleteFailures)
- [msmrw_guide_DuplicateBaseRecord](#BKMK_msmrw_guide_DuplicateBaseRecord)
- [msmrw_guide_DuplicateMatchingRecord](#BKMK_msmrw_guide_DuplicateMatchingRecord)
- [msmrw_guide_MailboxTrackingFolders](#BKMK_msmrw_guide_MailboxTrackingFolders)
- [msmrw_guide_PrincipalObjectAttributeAccesses](#BKMK_msmrw_guide_PrincipalObjectAttributeAccesses)
- [msmrw_guide_ProcessSession](#BKMK_msmrw_guide_ProcessSession)
- [msmrw_guide_SyncErrors](#BKMK_msmrw_guide_SyncErrors)
- [msmrw_GuideSession_Guide_msmrw_guide](#BKMK_msmrw_GuideSession_Guide_msmrw_guide)
- [msmrw_GuideStep_Guide_msmrw_guide](#BKMK_msmrw_GuideStep_Guide_msmrw_guide)
- [msmrw_GuideTask_Guide_msmrw_guide](#BKMK_msmrw_GuideTask_Guide_msmrw_guide)
- [msmrw_msmrw_guide_msmrw_guidecompletionstepobject_Guide](#BKMK_msmrw_msmrw_guide_msmrw_guidecompletionstepobject_Guide)
- [msmrw_msmrw_guide_msmrw_guidecompletionstepobjectplacement_Guide](#BKMK_msmrw_msmrw_guide_msmrw_guidecompletionstepobjectplacement_Guide)
- [msmrw_msmrw_guide_msmrw_guidestepobject_Guide](#BKMK_msmrw_msmrw_guide_msmrw_guidestepobject_Guide)
- [msmrw_msmrw_guide_msmrw_guidestepobjectplacement_Guide](#BKMK_msmrw_msmrw_guide_msmrw_guidestepobjectplacement_Guide)

### <a name="BKMK_msdyn_GuideAuthorSession_GuideID_msmrw_gu"></a> msdyn_GuideAuthorSession_GuideID_msmrw_gu

Many-To-One Relationship: [msdyn_guideauthorsession msdyn_GuideAuthorSession_GuideID_msmrw_gu](msdyn_guideauthorsession.md#BKMK_msdyn_GuideAuthorSession_GuideID_msmrw_gu)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_guideauthorsession`|
|ReferencingAttribute|`msdyn_guide`|
|ReferencedEntityNavigationPropertyName|`msdyn_GuideAuthorSession_GuideID_msmrw_gu`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_mrasjob_guide"></a> msdyn_mrasjob_guide

Many-To-One Relationship: [msdyn_mrasjob msdyn_mrasjob_guide](msdyn_mrasjob.md#BKMK_msdyn_mrasjob_guide)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_mrasjob`|
|ReferencingAttribute|`msdyn_mrasjobrelatedid`|
|ReferencedEntityNavigationPropertyName|`msdyn_mrasjob_guide`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_msmrw_guide_msdyn_workorderservicetask"></a> msdyn_msmrw_guide_msdyn_workorderservicetask

Many-To-One Relationship: [msdyn_workorderservicetask msdyn_msmrw_guide_msdyn_workorderservicetask](msdyn_workorderservicetask.md#BKMK_msdyn_msmrw_guide_msdyn_workorderservicetask)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_workorderservicetask`|
|ReferencingAttribute|`msdyn_guideid`|
|ReferencedEntityNavigationPropertyName|`msdyn_msmrw_guide_msdyn_workorderservicetask`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msmrw_guide_Annotations"></a> msmrw_guide_Annotations

Many-To-One Relationship: [annotation msmrw_guide_Annotations](annotation.md#BKMK_msmrw_guide_Annotations)

|Property|Value|
|---|---|
|ReferencingEntity|`annotation`|
|ReferencingAttribute|`objectid`|
|ReferencedEntityNavigationPropertyName|`msmrw_guide_Annotations`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msmrw_guide_AsyncOperations"></a> msmrw_guide_AsyncOperations

Many-To-One Relationship: [asyncoperation msmrw_guide_AsyncOperations](asyncoperation.md#BKMK_msmrw_guide_AsyncOperations)

|Property|Value|
|---|---|
|ReferencingEntity|`asyncoperation`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msmrw_guide_AsyncOperations`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msmrw_guide_BulkDeleteFailures"></a> msmrw_guide_BulkDeleteFailures

Many-To-One Relationship: [bulkdeletefailure msmrw_guide_BulkDeleteFailures](bulkdeletefailure.md#BKMK_msmrw_guide_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencingEntity|`bulkdeletefailure`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msmrw_guide_BulkDeleteFailures`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msmrw_guide_DuplicateBaseRecord"></a> msmrw_guide_DuplicateBaseRecord

Many-To-One Relationship: [duplicaterecord msmrw_guide_DuplicateBaseRecord](duplicaterecord.md#BKMK_msmrw_guide_DuplicateBaseRecord)

|Property|Value|
|---|---|
|ReferencingEntity|`duplicaterecord`|
|ReferencingAttribute|`baserecordid`|
|ReferencedEntityNavigationPropertyName|`msmrw_guide_DuplicateBaseRecord`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msmrw_guide_DuplicateMatchingRecord"></a> msmrw_guide_DuplicateMatchingRecord

Many-To-One Relationship: [duplicaterecord msmrw_guide_DuplicateMatchingRecord](duplicaterecord.md#BKMK_msmrw_guide_DuplicateMatchingRecord)

|Property|Value|
|---|---|
|ReferencingEntity|`duplicaterecord`|
|ReferencingAttribute|`duplicaterecordid`|
|ReferencedEntityNavigationPropertyName|`msmrw_guide_DuplicateMatchingRecord`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msmrw_guide_MailboxTrackingFolders"></a> msmrw_guide_MailboxTrackingFolders

Many-To-One Relationship: [mailboxtrackingfolder msmrw_guide_MailboxTrackingFolders](mailboxtrackingfolder.md#BKMK_msmrw_guide_MailboxTrackingFolders)

|Property|Value|
|---|---|
|ReferencingEntity|`mailboxtrackingfolder`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msmrw_guide_MailboxTrackingFolders`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msmrw_guide_PrincipalObjectAttributeAccesses"></a> msmrw_guide_PrincipalObjectAttributeAccesses

Many-To-One Relationship: [principalobjectattributeaccess msmrw_guide_PrincipalObjectAttributeAccesses](principalobjectattributeaccess.md#BKMK_msmrw_guide_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencingEntity|`principalobjectattributeaccess`|
|ReferencingAttribute|`objectid`|
|ReferencedEntityNavigationPropertyName|`msmrw_guide_PrincipalObjectAttributeAccesses`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msmrw_guide_ProcessSession"></a> msmrw_guide_ProcessSession

Many-To-One Relationship: [processsession msmrw_guide_ProcessSession](processsession.md#BKMK_msmrw_guide_ProcessSession)

|Property|Value|
|---|---|
|ReferencingEntity|`processsession`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msmrw_guide_ProcessSession`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msmrw_guide_SyncErrors"></a> msmrw_guide_SyncErrors

Many-To-One Relationship: [syncerror msmrw_guide_SyncErrors](syncerror.md#BKMK_msmrw_guide_SyncErrors)

|Property|Value|
|---|---|
|ReferencingEntity|`syncerror`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msmrw_guide_SyncErrors`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msmrw_GuideSession_Guide_msmrw_guide"></a> msmrw_GuideSession_Guide_msmrw_guide

Many-To-One Relationship: [msmrw_guidesession msmrw_GuideSession_Guide_msmrw_guide](msmrw_guidesession.md#BKMK_msmrw_GuideSession_Guide_msmrw_guide)

|Property|Value|
|---|---|
|ReferencingEntity|`msmrw_guidesession`|
|ReferencingAttribute|`msmrw_guide`|
|ReferencedEntityNavigationPropertyName|`msmrw_GuideSession_Guide_msmrw_guide`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msmrw_GuideStep_Guide_msmrw_guide"></a> msmrw_GuideStep_Guide_msmrw_guide

Many-To-One Relationship: [msmrw_guidestep msmrw_GuideStep_Guide_msmrw_guide](msmrw_guidestep.md#BKMK_msmrw_GuideStep_Guide_msmrw_guide)

|Property|Value|
|---|---|
|ReferencingEntity|`msmrw_guidestep`|
|ReferencingAttribute|`msmrw_guide`|
|ReferencedEntityNavigationPropertyName|`msmrw_GuideStep_Guide_msmrw_guide`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msmrw_GuideTask_Guide_msmrw_guide"></a> msmrw_GuideTask_Guide_msmrw_guide

Many-To-One Relationship: [msmrw_guidetask msmrw_GuideTask_Guide_msmrw_guide](msmrw_guidetask.md#BKMK_msmrw_GuideTask_Guide_msmrw_guide)

|Property|Value|
|---|---|
|ReferencingEntity|`msmrw_guidetask`|
|ReferencingAttribute|`msmrw_guide`|
|ReferencedEntityNavigationPropertyName|`msmrw_GuideTask_Guide_msmrw_guide`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msmrw_msmrw_guide_msmrw_guidecompletionstepobject_Guide"></a> msmrw_msmrw_guide_msmrw_guidecompletionstepobject_Guide

Many-To-One Relationship: [msmrw_guidecompletionstepobject msmrw_msmrw_guide_msmrw_guidecompletionstepobject_Guide](msmrw_guidecompletionstepobject.md#BKMK_msmrw_msmrw_guide_msmrw_guidecompletionstepobject_Guide)

|Property|Value|
|---|---|
|ReferencingEntity|`msmrw_guidecompletionstepobject`|
|ReferencingAttribute|`msmrw_guide`|
|ReferencedEntityNavigationPropertyName|`msmrw_msmrw_guide_msmrw_guidecompletionstepobject_Guide`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msmrw_msmrw_guide_msmrw_guidecompletionstepobjectplacement_Guide"></a> msmrw_msmrw_guide_msmrw_guidecompletionstepobjectplacement_Guide

Many-To-One Relationship: [msmrw_guidecompletionstepobjectplacement msmrw_msmrw_guide_msmrw_guidecompletionstepobjectplacement_Guide](msmrw_guidecompletionstepobjectplacement.md#BKMK_msmrw_msmrw_guide_msmrw_guidecompletionstepobjectplacement_Guide)

|Property|Value|
|---|---|
|ReferencingEntity|`msmrw_guidecompletionstepobjectplacement`|
|ReferencingAttribute|`msmrw_guide`|
|ReferencedEntityNavigationPropertyName|`msmrw_msmrw_guide_msmrw_guidecompletionstepobjectplacement_Guide`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msmrw_msmrw_guide_msmrw_guidestepobject_Guide"></a> msmrw_msmrw_guide_msmrw_guidestepobject_Guide

Many-To-One Relationship: [msmrw_guidestepobject msmrw_msmrw_guide_msmrw_guidestepobject_Guide](msmrw_guidestepobject.md#BKMK_msmrw_msmrw_guide_msmrw_guidestepobject_Guide)

|Property|Value|
|---|---|
|ReferencingEntity|`msmrw_guidestepobject`|
|ReferencingAttribute|`msmrw_guide`|
|ReferencedEntityNavigationPropertyName|`msmrw_msmrw_guide_msmrw_guidestepobject_Guide`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msmrw_msmrw_guide_msmrw_guidestepobjectplacement_Guide"></a> msmrw_msmrw_guide_msmrw_guidestepobjectplacement_Guide

Many-To-One Relationship: [msmrw_guidestepobjectplacement msmrw_msmrw_guide_msmrw_guidestepobjectplacement_Guide](msmrw_guidestepobjectplacement.md#BKMK_msmrw_msmrw_guide_msmrw_guidestepobjectplacement_Guide)

|Property|Value|
|---|---|
|ReferencingEntity|`msmrw_guidestepobjectplacement`|
|ReferencingAttribute|`msmrw_guide`|
|ReferencedEntityNavigationPropertyName|`msmrw_msmrw_guide_msmrw_guidestepobjectplacement_Guide`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|



### See also

[Dataverse table/entity reference](../about-entity-reference.md)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   

