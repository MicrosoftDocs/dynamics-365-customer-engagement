---
title: "Guide Completion Step Object Placement (msmrw_guidecompletionstepobjectplacement) table/entity reference (Microsoft Dynamics 365 Field Service)"
description: "Includes schema information and supported messages for the Guide Completion Step Object Placement (msmrw_guidecompletionstepobjectplacement) table/entity with Microsoft Dynamics 365 Field Service."
ms.date: 07.24.2024
ms.service: powerapps
ms.topic: reference
author: m-hartmann
ms.author: mhart
search.audienceType: 
  - developer
---

# Guide Completion Step Object Placement (msmrw_guidecompletionstepobjectplacement) table/entity reference

Specifies which 3D objects have been placed in the world in the completion step of a guide. Other information about the 3D objects is also stored.

## Messages

The following table lists the messages for the Guide Completion Step Object Placement (msmrw_guidecompletionstepobjectplacement) table.
Messages represent operations that can be performed on the table. They may also be events.

| Name <br />Is Event? |Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `Assign`<br />Event: True |`PATCH` /msmrw_guidecompletionstepobjectplacements(*msmrw_guidecompletionstepobjectplacementid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `ownerid` property. |<xref:Microsoft.Crm.Sdk.Messages.AssignRequest>|
| `Create`<br />Event: True |`POST` /msmrw_guidecompletionstepobjectplacements<br />See [Create](/powerapps/developer/data-platform/webapi/create-entity-web-api) |[Create records](/power-apps/developer/data-platform/org-service/entity-operations-create#basic-create)|
| `CreateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.CreateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.CreateMultipleRequest>|
| `Delete`<br />Event: True |`DELETE` /msmrw_guidecompletionstepobjectplacements(*msmrw_guidecompletionstepobjectplacementid*)<br />See [Delete](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-delete) |[Delete records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-delete)|
| `GrantAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.GrantAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.GrantAccessRequest>|
| `IsValidStateTransition`<br />Event: False |<xref:Microsoft.Dynamics.CRM.IsValidStateTransition?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.IsValidStateTransitionRequest>|
| `ModifyAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.ModifyAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.ModifyAccessRequest>|
| `Restore`<br />Event: True |<xref:Microsoft.Dynamics.CRM.Restore?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retrieve`<br />Event: True |`GET` /msmrw_guidecompletionstepobjectplacements(*msmrw_guidecompletionstepobjectplacementid*)<br />See [Retrieve](/powerapps/developer/data-platform/webapi/retrieve-entity-using-web-api) |[Retrieve records](/power-apps/developer/data-platform/org-service/entity-operations-retrieve)|
| `RetrieveMultiple`<br />Event: True |`GET` /msmrw_guidecompletionstepobjectplacements<br />See [Query data](/power-apps/developer/data-platform/webapi/query-data-web-api) |[Query data](/power-apps/developer/data-platform/org-service/entity-operations-query-data)|
| `RetrievePrincipalAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RetrievePrincipalAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RetrievePrincipalAccessRequest>|
| `RetrieveSharedPrincipalsAndAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RetrieveSharedPrincipalsAndAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RetrieveSharedPrincipalsAndAccessRequest>|
| `RevokeAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RevokeAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RevokeAccessRequest>|
| `SetState`<br />Event: True |`PATCH` /msmrw_guidecompletionstepobjectplacements(*msmrw_guidecompletionstepobjectplacementid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `statecode` and `statuscode` properties. |<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|
| `Update`<br />Event: True |`PATCH` /msmrw_guidecompletionstepobjectplacements(*msmrw_guidecompletionstepobjectplacementid*)<br />See [Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) |[Update records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-update)|
| `UpdateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.UpdateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpdateMultipleRequest>|
| `Upsert`<br />Event: False |`PATCH` /msmrw_guidecompletionstepobjectplacements(*msmrw_guidecompletionstepobjectplacementid*)<br />See [Upsert a table row](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#upsert-a-table-row) |<xref:Microsoft.Xrm.Sdk.Messages.UpsertRequest>|
| `UpsertMultiple`<br />Event: False |<xref:Microsoft.Dynamics.CRM.UpsertMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpsertMultipleRequest>|


## Events

The following table lists the events for the Guide Completion Step Object Placement (msmrw_guidecompletionstepobjectplacement) table.
Events are messages that exist so that you can subscribe to them. Unless you added the event, you shouldn't invoke the message, only subscribe to it.

|Name|Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `BulkRetain`|<xref:Microsoft.Dynamics.CRM.BulkRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `PurgeRetainedContent`|<xref:Microsoft.Dynamics.CRM.PurgeRetainedContent?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retain`|<xref:Microsoft.Dynamics.CRM.Retain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `RollbackRetain`|<xref:Microsoft.Dynamics.CRM.RollbackRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `ValidateRetentionConfig`|<xref:Microsoft.Dynamics.CRM.ValidateRetentionConfig?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|

## Properties

The following table lists selected properties for the Guide Completion Step Object Placement (msmrw_guidecompletionstepobjectplacement) table.

|Property|Value|
| --- | --- |
| **DisplayName** | **Guide Completion Step Object Placement** |
| **DisplayCollectionName** | **Guide Completion Step Object Placements** |
| **SchemaName** | `msmrw_guidecompletionstepobjectplacement` |
| **CollectionSchemaName** | `msmrw_guidecompletionstepobjectplacements` |
| **EntitySetName** | `msmrw_guidecompletionstepobjectplacements`|
| **LogicalName** | `msmrw_guidecompletionstepobjectplacement` |
| **LogicalCollectionName** | `msmrw_guidecompletionstepobjectplacements` |
| **PrimaryIdAttribute** | `msmrw_guidecompletionstepobjectplacementid` |
| **PrimaryNameAttribute** |`msmrw_name` |
| **TableType** | `Standard` |
| **OwnershipType** | `UserOwned` |

## Writable columns/attributes

These columns/attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [msmrw_3DObject](#BKMK_msmrw_3DObject)
- [msmrw_3DObjectAnimationDirection](#BKMK_msmrw_3DObjectAnimationDirection)
- [msmrw_3DObjectAnimationMode](#BKMK_msmrw_3DObjectAnimationMode)
- [msmrw_3dobjectanimationspeed](#BKMK_msmrw_3dobjectanimationspeed)
- [msmrw_3DObjectAnimationTake](#BKMK_msmrw_3DObjectAnimationTake)
- [msmrw_3DObjectIsAnimated](#BKMK_msmrw_3DObjectIsAnimated)
- [msmrw_3DObjectStyle](#BKMK_msmrw_3DObjectStyle)
- [msmrw_Guide](#BKMK_msmrw_Guide)
- [msmrw_GuideCompletionObject](#BKMK_msmrw_GuideCompletionObject)
- [msmrw_guidecompletionstepobjectplacementId](#BKMK_msmrw_guidecompletionstepobjectplacementId)
- [msmrw_IsInteractable](#BKMK_msmrw_IsInteractable)
- [msmrw_IsPlaced](#BKMK_msmrw_IsPlaced)
- [msmrw_name](#BKMK_msmrw_name)
- [msmrw_ObjectGhostIsEnabled](#BKMK_msmrw_ObjectGhostIsEnabled)
- [msmrw_PositionX](#BKMK_msmrw_PositionX)
- [msmrw_PositionY](#BKMK_msmrw_PositionY)
- [msmrw_PositionZ](#BKMK_msmrw_PositionZ)
- [msmrw_RotationW](#BKMK_msmrw_RotationW)
- [msmrw_RotationX](#BKMK_msmrw_RotationX)
- [msmrw_RotationY](#BKMK_msmrw_RotationY)
- [msmrw_RotationZ](#BKMK_msmrw_RotationZ)
- [msmrw_ScaleX](#BKMK_msmrw_ScaleX)
- [msmrw_ScaleY](#BKMK_msmrw_ScaleY)
- [msmrw_ScaleZ](#BKMK_msmrw_ScaleZ)
- [msmrw_triggeraction](#BKMK_msmrw_triggeraction)
- [msmrw_triggeractivation](#BKMK_msmrw_triggeractivation)
- [msmrw_triggerdestination](#BKMK_msmrw_triggerdestination)
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

### <a name="BKMK_msmrw_3DObject"></a> msmrw_3DObject

|Property|Value|
|---|---|
|Description|**Reference to 3D object that is placed spatially on the completion step.**|
|DisplayName|**3D Object**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msmrw_3dobject`|
|RequiredLevel|ApplicationRequired|
|Type|Lookup|
|Targets|msmrw_3dasset|

### <a name="BKMK_msmrw_3DObjectAnimationDirection"></a> msmrw_3DObjectAnimationDirection

|Property|Value|
|---|---|
|Description|**Specifies the direction to play the animation take. (Set to: Backward or Forward)**|
|DisplayName|**3D Object Animation Direction**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msmrw_3dobjectanimationdirection`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`msmrw_guidecompletionstepobjectplacement_msmrw_3dobjectanimationdirection`|
|DefaultValue|True|
|True Label|Forward|
|False Label|Backward|

### <a name="BKMK_msmrw_3DObjectAnimationMode"></a> msmrw_3DObjectAnimationMode

|Property|Value|
|---|---|
|Description|**Specifies the selected mode of playback for the animation take. (Set to: Loop, Once, PingPong)**|
|DisplayName|**3D Object Animation Mode**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msmrw_3dobjectanimationmode`|
|RequiredLevel|None|
|Type|Picklist|
|DefaultFormValue|937380000|
|GlobalChoiceName|`msmrw_3dobjectanimationmode`|

#### msmrw_3DObjectAnimationMode Choices/Options

|Value|Label|
|---|---|
|937380000|**Loop**|
|937380001|**Once**|
|937380002|**PingPong**|

### <a name="BKMK_msmrw_3dobjectanimationspeed"></a> msmrw_3dobjectanimationspeed

|Property|Value|
|---|---|
|Description|**Specifies the speed of the playback take as a percentage (for example, 100 = 1x speed).**|
|DisplayName|**3D Object Animation Speed**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msmrw_3dobjectanimationspeed`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|1000|
|MinValue|0|

### <a name="BKMK_msmrw_3DObjectAnimationTake"></a> msmrw_3DObjectAnimationTake

|Property|Value|
|---|---|
|Description|**Specifies the take name of the selected animation for playback.**|
|DisplayName|**3D Object Animation Take**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msmrw_3dobjectanimationtake`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msmrw_3DObjectIsAnimated"></a> msmrw_3DObjectIsAnimated

|Property|Value|
|---|---|
|Description|**Defines whether animation playback of the 3D object is enabled.**|
|DisplayName|**3D Object Is Animated**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msmrw_3dobjectisanimated`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`msmrw_guidecompletionstepobjectplacement_msmrw_3dobjectisanimated`|
|DefaultValue|True|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_msmrw_3DObjectStyle"></a> msmrw_3DObjectStyle

|Property|Value|
|---|---|
|Description|**Defines the 3D object style of the 3D object in the completion step. (Can be set to: Original, Pick up, Place, See-through 1, See-through 2, Warning, Avoid, X-Ray, Metal).**|
|DisplayName|**3D Object Style**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msmrw_3dobjectstyle`|
|RequiredLevel|None|
|Type|Picklist|
|DefaultFormValue|-1|
|GlobalChoiceName|`msmrw_guide3dobjectstyle`|

#### msmrw_3DObjectStyle Choices/Options

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

### <a name="BKMK_msmrw_Guide"></a> msmrw_Guide

|Property|Value|
|---|---|
|Description|**Reference to the guide.**|
|DisplayName|**Guide**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msmrw_guide`|
|RequiredLevel|ApplicationRequired|
|Type|Lookup|
|Targets|msmrw_guide|

### <a name="BKMK_msmrw_GuideCompletionObject"></a> msmrw_GuideCompletionObject

|Property|Value|
|---|---|
|Description|**Reference to the object that can be spatially placed in the world.**|
|DisplayName|**Guide Completion Step Object**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msmrw_guidecompletionobject`|
|RequiredLevel|ApplicationRequired|
|Type|Lookup|
|Targets|msmrw_guidecompletionstepobject|

### <a name="BKMK_msmrw_guidecompletionstepobjectplacementId"></a> msmrw_guidecompletionstepobjectplacementId

|Property|Value|
|---|---|
|Description|**Unique identifier for the object placed spatially in the completion step.**|
|DisplayName|**Guide Completion Step Object Placement**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`msmrw_guidecompletionstepobjectplacementid`|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|

### <a name="BKMK_msmrw_IsInteractable"></a> msmrw_IsInteractable

|Property|Value|
|---|---|
|Description|**This boolean type field specifies whether the operator can interact with the object or not. The default value is false.**|
|DisplayName|**3D Object Is Interactable**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msmrw_isinteractable`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`msmrw_guidecompletionstepobjectplacement_msmrw_isinteractable`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_msmrw_IsPlaced"></a> msmrw_IsPlaced

|Property|Value|
|---|---|
|Description|**Defines whether the object is spatially placed in the world.**|
|DisplayName|**3D Object Is Placed**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msmrw_isplaced`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`msmrw_guidecompletionstepobjectplacement_msmrw_isplaced`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_msmrw_name"></a> msmrw_name

|Property|Value|
|---|---|
|Description|**The name of the custom entity.**|
|DisplayName|**Name**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msmrw_name`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msmrw_ObjectGhostIsEnabled"></a> msmrw_ObjectGhostIsEnabled

|Property|Value|
|---|---|
|Description|**This boolean type field specifies whether or not to show a ghost of the 3D object at its original location. The default value is false**|
|DisplayName|**3D Object Ghost Is Enabled**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msmrw_objectghostisenabled`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`msmrw_guidecompletionstepobjectplacement_msmrw_objectghostisenabled`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_msmrw_PositionX"></a> msmrw_PositionX

|Property|Value|
|---|---|
|Description|**Spatial location of the 3D object in the completion step along the X axis.**|
|DisplayName|**Position X**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msmrw_positionx`|
|RequiredLevel|None|
|Type|Double|
|ImeMode|Auto|
|MaxValue|300000|
|MinValue|-300000|
|Precision|5|

### <a name="BKMK_msmrw_PositionY"></a> msmrw_PositionY

|Property|Value|
|---|---|
|Description|**Spatial location of the 3D object in the completion step along the Y axis.**|
|DisplayName|**Position Y**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msmrw_positiony`|
|RequiredLevel|None|
|Type|Double|
|ImeMode|Auto|
|MaxValue|300000|
|MinValue|-300000|
|Precision|5|

### <a name="BKMK_msmrw_PositionZ"></a> msmrw_PositionZ

|Property|Value|
|---|---|
|Description|**Spatial location of the 3D object in the completion step along the Z axis.**|
|DisplayName|**Position Z**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msmrw_positionz`|
|RequiredLevel|None|
|Type|Double|
|ImeMode|Auto|
|MaxValue|300000|
|MinValue|-300000|
|Precision|5|

### <a name="BKMK_msmrw_RotationW"></a> msmrw_RotationW

|Property|Value|
|---|---|
|Description|**Rotational quaternion of the 3D object in the completion step along the W component.**|
|DisplayName|**Rotation W**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msmrw_rotationw`|
|RequiredLevel|None|
|Type|Double|
|ImeMode|Auto|
|MaxValue|1|
|MinValue|-1|
|Precision|5|

### <a name="BKMK_msmrw_RotationX"></a> msmrw_RotationX

|Property|Value|
|---|---|
|Description|**Rotational quaternion of the 3D object in the completion step along the X component.**|
|DisplayName|**Rotation X**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msmrw_rotationx`|
|RequiredLevel|None|
|Type|Double|
|ImeMode|Auto|
|MaxValue|1|
|MinValue|-1|
|Precision|5|

### <a name="BKMK_msmrw_RotationY"></a> msmrw_RotationY

|Property|Value|
|---|---|
|Description|**Rotational quaternion of the 3D object in the completion step along the Y component.**|
|DisplayName|**Rotation Y**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msmrw_rotationy`|
|RequiredLevel|None|
|Type|Double|
|ImeMode|Auto|
|MaxValue|1|
|MinValue|-1|
|Precision|5|

### <a name="BKMK_msmrw_RotationZ"></a> msmrw_RotationZ

|Property|Value|
|---|---|
|Description|**Rotational quaternion of the 3D object in the completion step along the Z component.**|
|DisplayName|**Rotation Z**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msmrw_rotationz`|
|RequiredLevel|None|
|Type|Double|
|ImeMode|Auto|
|MaxValue|1|
|MinValue|-1|
|Precision|5|

### <a name="BKMK_msmrw_ScaleX"></a> msmrw_ScaleX

|Property|Value|
|---|---|
|Description|**Scale of the 3D object in the completion step along the X axis.**|
|DisplayName|**Scale X**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msmrw_scalex`|
|RequiredLevel|None|
|Type|Double|
|ImeMode|Auto|
|MaxValue|165180|
|MinValue|0|
|Precision|5|

### <a name="BKMK_msmrw_ScaleY"></a> msmrw_ScaleY

|Property|Value|
|---|---|
|Description|**Scale of the 3D object in the completion step along the Y axis.**|
|DisplayName|**Scale Y**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msmrw_scaley`|
|RequiredLevel|None|
|Type|Double|
|ImeMode|Auto|
|MaxValue|165180|
|MinValue|0|
|Precision|5|

### <a name="BKMK_msmrw_ScaleZ"></a> msmrw_ScaleZ

|Property|Value|
|---|---|
|Description|**Scale of the 3D object in the completion step along the Z axis.**|
|DisplayName|**Scale Z**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msmrw_scalez`|
|RequiredLevel|None|
|Type|Double|
|ImeMode|Auto|
|MaxValue|165180|
|MinValue|0|
|Precision|5|

### <a name="BKMK_msmrw_triggeraction"></a> msmrw_triggeraction

|Property|Value|
|---|---|
|Description|**Specifies the action that the spatial trigger will perform on activation. (Can be set to: No Action, Go Back, Use Response 1, Use Response 2, Use Response 3, Go To Step)**|
|DisplayName|**Trigger Action Type**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msmrw_triggeraction`|
|RequiredLevel|None|
|Type|Picklist|
|DefaultFormValue|937380000|
|GlobalChoiceName|`msmrw_triggeractiontype`|

#### msmrw_triggeraction Choices/Options

|Value|Label|
|---|---|
|937380000|**No Action**|
|937380001|**Go Back**|
|937380002|**Use Response 1**|
|937380003|**Use Response 2**|
|937380004|**Use Response 3**|
|937380005|**Go To Step**|

### <a name="BKMK_msmrw_triggeractivation"></a> msmrw_triggeractivation

|Property|Value|
|---|---|
|Description|**Specifies how to activate the spatial trigger.  (Can be set to: On Hand Enter, On Hand Exit)**|
|DisplayName|**Trigger Activation**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msmrw_triggeractivation`|
|RequiredLevel|None|
|Type|Picklist|
|DefaultFormValue|937380001|
|GlobalChoiceName|`msmrw_triggeractivationmethod`|

#### msmrw_triggeractivation Choices/Options

|Value|Label|
|---|---|
|937380000|**On Hand Enter**|
|937380001|**On Hand Exit**|

### <a name="BKMK_msmrw_triggerdestination"></a> msmrw_triggerdestination

|Property|Value|
|---|---|
|Description|**Reference to the destination step set in the spatial trigger, if the trigger action is set to Go To Step.**|
|DisplayName|**Trigger Destination**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msmrw_triggerdestination`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|msmrw_guidestep|

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
|Description|**Status of the Guide Completion Step Object Placement**|
|DisplayName|**Status**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statecode`|
|RequiredLevel|SystemRequired|
|Type|State|
|DefaultFormValue||
|GlobalChoiceName|`msmrw_guidecompletionstepobjectplacement_statecode`|

#### statecode Choices/Options

|Value|Details|
|---|---|
|0|Label: **Active**<br />DefaultStatus: 1<br />InvariantName: `Active`|
|1|Label: **Inactive**<br />DefaultStatus: 2<br />InvariantName: `Inactive`|

### <a name="BKMK_statuscode"></a> statuscode

|Property|Value|
|---|---|
|Description|**Reason for the status of the Guide Completion Step Object Placement**|
|DisplayName|**Status Reason**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statuscode`|
|RequiredLevel|None|
|Type|Status|
|DefaultFormValue||
|GlobalChoiceName|`msmrw_guidecompletionstepobjectplacement_statuscode`|

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

- [business_unit_msmrw_guidecompletionstepobjectplacement](#BKMK_business_unit_msmrw_guidecompletionstepobjectplacement)
- [lk_msmrw_guidecompletionstepobjectplacement_createdby](#BKMK_lk_msmrw_guidecompletionstepobjectplacement_createdby)
- [lk_msmrw_guidecompletionstepobjectplacement_createdonbehalfby](#BKMK_lk_msmrw_guidecompletionstepobjectplacement_createdonbehalfby)
- [lk_msmrw_guidecompletionstepobjectplacement_modifiedby](#BKMK_lk_msmrw_guidecompletionstepobjectplacement_modifiedby)
- [lk_msmrw_guidecompletionstepobjectplacement_modifiedonbehalfby](#BKMK_lk_msmrw_guidecompletionstepobjectplacement_modifiedonbehalfby)
- [msmrw_msmrw_3dasset_msmrw_guidecompletionstepobjectplacement_3DObject](#BKMK_msmrw_msmrw_3dasset_msmrw_guidecompletionstepobjectplacement_3DObject)
- [msmrw_msmrw_guide_msmrw_guidecompletionstepobjectplacement_Guide](#BKMK_msmrw_msmrw_guide_msmrw_guidecompletionstepobjectplacement_Guide)
- [msmrw_msmrw_guidecompletionobject_msmrw_guidecompletionstepobjectplacement_GuideCompletionStepObject](#BKMK_msmrw_msmrw_guidecompletionobject_msmrw_guidecompletionstepobjectplacement_GuideCompletionStepObject)
- [msmrw_msmrw_guidestep_msmrw_guidecompletionstepobjectplacement_triggerdestination](#BKMK_msmrw_msmrw_guidestep_msmrw_guidecompletionstepobjectplacement_triggerdestination)
- [owner_msmrw_guidecompletionstepobjectplacement](#BKMK_owner_msmrw_guidecompletionstepobjectplacement)
- [team_msmrw_guidecompletionstepobjectplacement](#BKMK_team_msmrw_guidecompletionstepobjectplacement)
- [user_msmrw_guidecompletionstepobjectplacement](#BKMK_user_msmrw_guidecompletionstepobjectplacement)

### <a name="BKMK_business_unit_msmrw_guidecompletionstepobjectplacement"></a> business_unit_msmrw_guidecompletionstepobjectplacement

One-To-Many Relationship: [businessunit business_unit_msmrw_guidecompletionstepobjectplacement](businessunit.md#BKMK_business_unit_msmrw_guidecompletionstepobjectplacement)

|Property|Value|
|---|---|
|ReferencedEntity|`businessunit`|
|ReferencedAttribute|`businessunitid`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencingEntityNavigationPropertyName|`owningbusinessunit`|
|IsHierarchical||
|CascadeConfiguration|Archive: `Restrict`<br />Assign: `NoCascade`<br />Delete: `Restrict`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msmrw_guidecompletionstepobjectplacement_createdby"></a> lk_msmrw_guidecompletionstepobjectplacement_createdby

One-To-Many Relationship: [systemuser lk_msmrw_guidecompletionstepobjectplacement_createdby](systemuser.md#BKMK_lk_msmrw_guidecompletionstepobjectplacement_createdby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdby`|
|ReferencingEntityNavigationPropertyName|`createdby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msmrw_guidecompletionstepobjectplacement_createdonbehalfby"></a> lk_msmrw_guidecompletionstepobjectplacement_createdonbehalfby

One-To-Many Relationship: [systemuser lk_msmrw_guidecompletionstepobjectplacement_createdonbehalfby](systemuser.md#BKMK_lk_msmrw_guidecompletionstepobjectplacement_createdonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdonbehalfby`|
|ReferencingEntityNavigationPropertyName|`createdonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msmrw_guidecompletionstepobjectplacement_modifiedby"></a> lk_msmrw_guidecompletionstepobjectplacement_modifiedby

One-To-Many Relationship: [systemuser lk_msmrw_guidecompletionstepobjectplacement_modifiedby](systemuser.md#BKMK_lk_msmrw_guidecompletionstepobjectplacement_modifiedby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedby`|
|ReferencingEntityNavigationPropertyName|`modifiedby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msmrw_guidecompletionstepobjectplacement_modifiedonbehalfby"></a> lk_msmrw_guidecompletionstepobjectplacement_modifiedonbehalfby

One-To-Many Relationship: [systemuser lk_msmrw_guidecompletionstepobjectplacement_modifiedonbehalfby](systemuser.md#BKMK_lk_msmrw_guidecompletionstepobjectplacement_modifiedonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedonbehalfby`|
|ReferencingEntityNavigationPropertyName|`modifiedonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msmrw_msmrw_3dasset_msmrw_guidecompletionstepobjectplacement_3DObject"></a> msmrw_msmrw_3dasset_msmrw_guidecompletionstepobjectplacement_3DObject

One-To-Many Relationship: [msmrw_3dasset msmrw_msmrw_3dasset_msmrw_guidecompletionstepobjectplacement_3DObject](msmrw_3dasset.md#BKMK_msmrw_msmrw_3dasset_msmrw_guidecompletionstepobjectplacement_3DObject)

|Property|Value|
|---|---|
|ReferencedEntity|`msmrw_3dasset`|
|ReferencedAttribute|`msmrw_3dassetid`|
|ReferencingAttribute|`msmrw_3dobject`|
|ReferencingEntityNavigationPropertyName|`msmrw_3DObject`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msmrw_msmrw_guide_msmrw_guidecompletionstepobjectplacement_Guide"></a> msmrw_msmrw_guide_msmrw_guidecompletionstepobjectplacement_Guide

One-To-Many Relationship: [msmrw_guide msmrw_msmrw_guide_msmrw_guidecompletionstepobjectplacement_Guide](msmrw_guide.md#BKMK_msmrw_msmrw_guide_msmrw_guidecompletionstepobjectplacement_Guide)

|Property|Value|
|---|---|
|ReferencedEntity|`msmrw_guide`|
|ReferencedAttribute|`msmrw_guideid`|
|ReferencingAttribute|`msmrw_guide`|
|ReferencingEntityNavigationPropertyName|`msmrw_Guide`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msmrw_msmrw_guidecompletionobject_msmrw_guidecompletionstepobjectplacement_GuideCompletionStepObject"></a> msmrw_msmrw_guidecompletionobject_msmrw_guidecompletionstepobjectplacement_GuideCompletionStepObject

One-To-Many Relationship: [msmrw_guidecompletionstepobject msmrw_msmrw_guidecompletionobject_msmrw_guidecompletionstepobjectplacement_GuideCompletionStepObject](msmrw_guidecompletionstepobject.md#BKMK_msmrw_msmrw_guidecompletionobject_msmrw_guidecompletionstepobjectplacement_GuideCompletionStepObject)

|Property|Value|
|---|---|
|ReferencedEntity|`msmrw_guidecompletionstepobject`|
|ReferencedAttribute|`msmrw_guidecompletionstepobjectid`|
|ReferencingAttribute|`msmrw_guidecompletionobject`|
|ReferencingEntityNavigationPropertyName|`msmrw_GuideCompletionObject`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msmrw_msmrw_guidestep_msmrw_guidecompletionstepobjectplacement_triggerdestination"></a> msmrw_msmrw_guidestep_msmrw_guidecompletionstepobjectplacement_triggerdestination

One-To-Many Relationship: [msmrw_guidestep msmrw_msmrw_guidestep_msmrw_guidecompletionstepobjectplacement_triggerdestination](msmrw_guidestep.md#BKMK_msmrw_msmrw_guidestep_msmrw_guidecompletionstepobjectplacement_triggerdestination)

|Property|Value|
|---|---|
|ReferencedEntity|`msmrw_guidestep`|
|ReferencedAttribute|`msmrw_guidestepid`|
|ReferencingAttribute|`msmrw_triggerdestination`|
|ReferencingEntityNavigationPropertyName|`msmrw_triggerdestination`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_owner_msmrw_guidecompletionstepobjectplacement"></a> owner_msmrw_guidecompletionstepobjectplacement

One-To-Many Relationship: [owner owner_msmrw_guidecompletionstepobjectplacement](owner.md#BKMK_owner_msmrw_guidecompletionstepobjectplacement)

|Property|Value|
|---|---|
|ReferencedEntity|`owner`|
|ReferencedAttribute|`ownerid`|
|ReferencingAttribute|`ownerid`|
|ReferencingEntityNavigationPropertyName|`ownerid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_team_msmrw_guidecompletionstepobjectplacement"></a> team_msmrw_guidecompletionstepobjectplacement

One-To-Many Relationship: [team team_msmrw_guidecompletionstepobjectplacement](team.md#BKMK_team_msmrw_guidecompletionstepobjectplacement)

|Property|Value|
|---|---|
|ReferencedEntity|`team`|
|ReferencedAttribute|`teamid`|
|ReferencingAttribute|`owningteam`|
|ReferencingEntityNavigationPropertyName|`owningteam`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_user_msmrw_guidecompletionstepobjectplacement"></a> user_msmrw_guidecompletionstepobjectplacement

One-To-Many Relationship: [systemuser user_msmrw_guidecompletionstepobjectplacement](systemuser.md#BKMK_user_msmrw_guidecompletionstepobjectplacement)

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

- [msmrw_guidecompletionstepobjectplacement_AsyncOperations](#BKMK_msmrw_guidecompletionstepobjectplacement_AsyncOperations)
- [msmrw_guidecompletionstepobjectplacement_BulkDeleteFailures](#BKMK_msmrw_guidecompletionstepobjectplacement_BulkDeleteFailures)
- [msmrw_guidecompletionstepobjectplacement_DuplicateBaseRecord](#BKMK_msmrw_guidecompletionstepobjectplacement_DuplicateBaseRecord)
- [msmrw_guidecompletionstepobjectplacement_DuplicateMatchingRecord](#BKMK_msmrw_guidecompletionstepobjectplacement_DuplicateMatchingRecord)
- [msmrw_guidecompletionstepobjectplacement_MailboxTrackingFolders](#BKMK_msmrw_guidecompletionstepobjectplacement_MailboxTrackingFolders)
- [msmrw_guidecompletionstepobjectplacement_PrincipalObjectAttributeAccesses](#BKMK_msmrw_guidecompletionstepobjectplacement_PrincipalObjectAttributeAccesses)
- [msmrw_guidecompletionstepobjectplacement_ProcessSession](#BKMK_msmrw_guidecompletionstepobjectplacement_ProcessSession)
- [msmrw_guidecompletionstepobjectplacement_SyncErrors](#BKMK_msmrw_guidecompletionstepobjectplacement_SyncErrors)
- [msmrw_msmrw_guidecompletionstepobjectplacement_msmrw_guide_CompletionAttentionDirector3DObject](#BKMK_msmrw_msmrw_guidecompletionstepobjectplacement_msmrw_guide_CompletionAttentionDirector3DObject)

### <a name="BKMK_msmrw_guidecompletionstepobjectplacement_AsyncOperations"></a> msmrw_guidecompletionstepobjectplacement_AsyncOperations

Many-To-One Relationship: [asyncoperation msmrw_guidecompletionstepobjectplacement_AsyncOperations](asyncoperation.md#BKMK_msmrw_guidecompletionstepobjectplacement_AsyncOperations)

|Property|Value|
|---|---|
|ReferencingEntity|`asyncoperation`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msmrw_guidecompletionstepobjectplacement_AsyncOperations`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msmrw_guidecompletionstepobjectplacement_BulkDeleteFailures"></a> msmrw_guidecompletionstepobjectplacement_BulkDeleteFailures

Many-To-One Relationship: [bulkdeletefailure msmrw_guidecompletionstepobjectplacement_BulkDeleteFailures](bulkdeletefailure.md#BKMK_msmrw_guidecompletionstepobjectplacement_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencingEntity|`bulkdeletefailure`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msmrw_guidecompletionstepobjectplacement_BulkDeleteFailures`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msmrw_guidecompletionstepobjectplacement_DuplicateBaseRecord"></a> msmrw_guidecompletionstepobjectplacement_DuplicateBaseRecord

Many-To-One Relationship: [duplicaterecord msmrw_guidecompletionstepobjectplacement_DuplicateBaseRecord](duplicaterecord.md#BKMK_msmrw_guidecompletionstepobjectplacement_DuplicateBaseRecord)

|Property|Value|
|---|---|
|ReferencingEntity|`duplicaterecord`|
|ReferencingAttribute|`baserecordid`|
|ReferencedEntityNavigationPropertyName|`msmrw_guidecompletionstepobjectplacement_DuplicateBaseRecord`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msmrw_guidecompletionstepobjectplacement_DuplicateMatchingRecord"></a> msmrw_guidecompletionstepobjectplacement_DuplicateMatchingRecord

Many-To-One Relationship: [duplicaterecord msmrw_guidecompletionstepobjectplacement_DuplicateMatchingRecord](duplicaterecord.md#BKMK_msmrw_guidecompletionstepobjectplacement_DuplicateMatchingRecord)

|Property|Value|
|---|---|
|ReferencingEntity|`duplicaterecord`|
|ReferencingAttribute|`duplicaterecordid`|
|ReferencedEntityNavigationPropertyName|`msmrw_guidecompletionstepobjectplacement_DuplicateMatchingRecord`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msmrw_guidecompletionstepobjectplacement_MailboxTrackingFolders"></a> msmrw_guidecompletionstepobjectplacement_MailboxTrackingFolders

Many-To-One Relationship: [mailboxtrackingfolder msmrw_guidecompletionstepobjectplacement_MailboxTrackingFolders](mailboxtrackingfolder.md#BKMK_msmrw_guidecompletionstepobjectplacement_MailboxTrackingFolders)

|Property|Value|
|---|---|
|ReferencingEntity|`mailboxtrackingfolder`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msmrw_guidecompletionstepobjectplacement_MailboxTrackingFolders`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msmrw_guidecompletionstepobjectplacement_PrincipalObjectAttributeAccesses"></a> msmrw_guidecompletionstepobjectplacement_PrincipalObjectAttributeAccesses

Many-To-One Relationship: [principalobjectattributeaccess msmrw_guidecompletionstepobjectplacement_PrincipalObjectAttributeAccesses](principalobjectattributeaccess.md#BKMK_msmrw_guidecompletionstepobjectplacement_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencingEntity|`principalobjectattributeaccess`|
|ReferencingAttribute|`objectid`|
|ReferencedEntityNavigationPropertyName|`msmrw_guidecompletionstepobjectplacement_PrincipalObjectAttributeAccesses`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msmrw_guidecompletionstepobjectplacement_ProcessSession"></a> msmrw_guidecompletionstepobjectplacement_ProcessSession

Many-To-One Relationship: [processsession msmrw_guidecompletionstepobjectplacement_ProcessSession](processsession.md#BKMK_msmrw_guidecompletionstepobjectplacement_ProcessSession)

|Property|Value|
|---|---|
|ReferencingEntity|`processsession`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msmrw_guidecompletionstepobjectplacement_ProcessSession`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msmrw_guidecompletionstepobjectplacement_SyncErrors"></a> msmrw_guidecompletionstepobjectplacement_SyncErrors

Many-To-One Relationship: [syncerror msmrw_guidecompletionstepobjectplacement_SyncErrors](syncerror.md#BKMK_msmrw_guidecompletionstepobjectplacement_SyncErrors)

|Property|Value|
|---|---|
|ReferencingEntity|`syncerror`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msmrw_guidecompletionstepobjectplacement_SyncErrors`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msmrw_msmrw_guidecompletionstepobjectplacement_msmrw_guide_CompletionAttentionDirector3DObject"></a> msmrw_msmrw_guidecompletionstepobjectplacement_msmrw_guide_CompletionAttentionDirector3DObject

Many-To-One Relationship: [msmrw_guide msmrw_msmrw_guidecompletionstepobjectplacement_msmrw_guide_CompletionAttentionDirector3DObject](msmrw_guide.md#BKMK_msmrw_msmrw_guidecompletionstepobjectplacement_msmrw_guide_CompletionAttentionDirector3DObject)

|Property|Value|
|---|---|
|ReferencingEntity|`msmrw_guide`|
|ReferencingAttribute|`msmrw_completionattentiondirector3dobject`|
|ReferencedEntityNavigationPropertyName|`msmrw_msmrw_guidecompletionstepobjectplacement_msmrw_guide_CompletionAttentionDirector3DObject`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|



### See also

[Dataverse table/entity reference](../about-entity-reference.md)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   

