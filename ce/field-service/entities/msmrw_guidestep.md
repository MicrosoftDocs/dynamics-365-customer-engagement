---
title: "Guide Step (msmrw_GuideStep) table/entity reference (Microsoft Dynamics 365 Field Service)"
description: "Includes schema information and supported messages for the Guide Step (msmrw_GuideStep) table/entity with Microsoft Dynamics 365 Field Service."
ms.date: 07.24.2024
ms.service: powerapps
ms.topic: reference
author: m-hartmann
ms.author: mhart
search.audienceType: 
  - developer
---

# Guide Step (msmrw_GuideStep) table/entity reference

Stores content and information about a guide step.

## Messages

The following table lists the messages for the Guide Step (msmrw_GuideStep) table.
Messages represent operations that can be performed on the table. They may also be events.

| Name <br />Is Event? |Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `Assign`<br />Event: True |`PATCH` /msmrw_guidesteps(*msmrw_guidestepid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `ownerid` property. |<xref:Microsoft.Crm.Sdk.Messages.AssignRequest>|
| `Create`<br />Event: True |`POST` /msmrw_guidesteps<br />See [Create](/powerapps/developer/data-platform/webapi/create-entity-web-api) |[Create records](/power-apps/developer/data-platform/org-service/entity-operations-create#basic-create)|
| `CreateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.CreateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.CreateMultipleRequest>|
| `Delete`<br />Event: True |`DELETE` /msmrw_guidesteps(*msmrw_guidestepid*)<br />See [Delete](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-delete) |[Delete records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-delete)|
| `GrantAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.GrantAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.GrantAccessRequest>|
| `IsValidStateTransition`<br />Event: False |<xref:Microsoft.Dynamics.CRM.IsValidStateTransition?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.IsValidStateTransitionRequest>|
| `ModifyAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.ModifyAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.ModifyAccessRequest>|
| `Restore`<br />Event: True |<xref:Microsoft.Dynamics.CRM.Restore?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retrieve`<br />Event: True |`GET` /msmrw_guidesteps(*msmrw_guidestepid*)<br />See [Retrieve](/powerapps/developer/data-platform/webapi/retrieve-entity-using-web-api) |[Retrieve records](/power-apps/developer/data-platform/org-service/entity-operations-retrieve)|
| `RetrieveMultiple`<br />Event: True |`GET` /msmrw_guidesteps<br />See [Query data](/power-apps/developer/data-platform/webapi/query-data-web-api) |[Query data](/power-apps/developer/data-platform/org-service/entity-operations-query-data)|
| `RetrievePrincipalAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RetrievePrincipalAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RetrievePrincipalAccessRequest>|
| `RetrieveSharedPrincipalsAndAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RetrieveSharedPrincipalsAndAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RetrieveSharedPrincipalsAndAccessRequest>|
| `RevokeAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RevokeAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RevokeAccessRequest>|
| `SetState`<br />Event: True |`PATCH` /msmrw_guidesteps(*msmrw_guidestepid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `statecode` and `statuscode` properties. |<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|
| `Update`<br />Event: True |`PATCH` /msmrw_guidesteps(*msmrw_guidestepid*)<br />See [Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) |[Update records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-update)|
| `UpdateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.UpdateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpdateMultipleRequest>|
| `Upsert`<br />Event: False |`PATCH` /msmrw_guidesteps(*msmrw_guidestepid*)<br />See [Upsert a table row](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#upsert-a-table-row) |<xref:Microsoft.Xrm.Sdk.Messages.UpsertRequest>|
| `UpsertMultiple`<br />Event: False |<xref:Microsoft.Dynamics.CRM.UpsertMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpsertMultipleRequest>|


## Events

The following table lists the events for the Guide Step (msmrw_GuideStep) table.
Events are messages that exist so that you can subscribe to them. Unless you added the event, you shouldn't invoke the message, only subscribe to it.

|Name|Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `BulkRetain`|<xref:Microsoft.Dynamics.CRM.BulkRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `PurgeRetainedContent`|<xref:Microsoft.Dynamics.CRM.PurgeRetainedContent?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retain`|<xref:Microsoft.Dynamics.CRM.Retain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `RollbackRetain`|<xref:Microsoft.Dynamics.CRM.RollbackRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `ValidateRetentionConfig`|<xref:Microsoft.Dynamics.CRM.ValidateRetentionConfig?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|

## Properties

The following table lists selected properties for the Guide Step (msmrw_GuideStep) table.

|Property|Value|
| --- | --- |
| **DisplayName** | **Guide Step** |
| **DisplayCollectionName** | **Guide Steps** |
| **SchemaName** | `msmrw_GuideStep` |
| **CollectionSchemaName** | `msmrw_GuideSteps` |
| **EntitySetName** | `msmrw_guidesteps`|
| **LogicalName** | `msmrw_guidestep` |
| **LogicalCollectionName** | `msmrw_guidesteps` |
| **PrimaryIdAttribute** | `msmrw_guidestepid` |
| **PrimaryNameAttribute** |`msmrw_name` |
| **TableType** | `Standard` |
| **OwnershipType** | `UserOwned` |

## Writable columns/attributes

These columns/attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [msmrw_ActionType](#BKMK_msmrw_ActionType)
- [msmrw_ActionURL](#BKMK_msmrw_ActionURL)
- [msmrw_AttentionDirector3DObject](#BKMK_msmrw_AttentionDirector3DObject)
- [msmrw_AttentionDirectorEndpointType](#BKMK_msmrw_AttentionDirectorEndpointType)
- [msmrw_AttentionDirectorIsPlaced](#BKMK_msmrw_AttentionDirectorIsPlaced)
- [msmrw_AttentionDirectorPositionX](#BKMK_msmrw_AttentionDirectorPositionX)
- [msmrw_AttentionDirectorPositionY](#BKMK_msmrw_AttentionDirectorPositionY)
- [msmrw_AttentionDirectorPositionZ](#BKMK_msmrw_AttentionDirectorPositionZ)
- [msmrw_AttentionDirectorRotationW](#BKMK_msmrw_AttentionDirectorRotationW)
- [msmrw_AttentionDirectorRotationX](#BKMK_msmrw_AttentionDirectorRotationX)
- [msmrw_AttentionDirectorRotationY](#BKMK_msmrw_AttentionDirectorRotationY)
- [msmrw_AttentionDirectorRotationZ](#BKMK_msmrw_AttentionDirectorRotationZ)
- [msmrw_Guide](#BKMK_msmrw_Guide)
- [msmrw_GuideStepId](#BKMK_msmrw_GuideStepId)
- [msmrw_Image](#BKMK_msmrw_Image)
- [msmrw_InstructionText](#BKMK_msmrw_InstructionText)
- [msmrw_Name](#BKMK_msmrw_Name)
- [msmrw_PreviousStep](#BKMK_msmrw_PreviousStep)
- [msmrw_Response1ActionType](#BKMK_msmrw_Response1ActionType)
- [msmrw_Response1Step](#BKMK_msmrw_Response1Step)
- [msmrw_Response1Text](#BKMK_msmrw_Response1Text)
- [msmrw_Response2ActionType](#BKMK_msmrw_Response2ActionType)
- [msmrw_Response2Step](#BKMK_msmrw_Response2Step)
- [msmrw_Response2Text](#BKMK_msmrw_Response2Text)
- [msmrw_Response3ActionType](#BKMK_msmrw_Response3ActionType)
- [msmrw_Response3Step](#BKMK_msmrw_Response3Step)
- [msmrw_Response3Text](#BKMK_msmrw_Response3Text)
- [msmrw_StepTemplateType](#BKMK_msmrw_StepTemplateType)
- [msmrw_Task](#BKMK_msmrw_Task)
- [msmrw_Video](#BKMK_msmrw_Video)
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

### <a name="BKMK_msmrw_ActionType"></a> msmrw_ActionType

|Property|Value|
|---|---|
|Description|**The type of action available to the operator on the step instruction. (Can be set to: No Action; Link; Power Apps.)**|
|DisplayName|**Action Type**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msmrw_actiontype`|
|RequiredLevel|None|
|Type|Picklist|
|DefaultFormValue|-1|
|GlobalChoiceName|`msmrw_guideactiontype`|

#### msmrw_ActionType Choices/Options

|Value|Label|
|---|---|
|937380000|**No Action**|
|937380001|**Link**|
|937380002|**Power Apps**|

### <a name="BKMK_msmrw_ActionURL"></a> msmrw_ActionURL

|Property|Value|
|---|---|
|Description|**The URL associated with the action available to operators on the step instruction.**|
|DisplayName|**Action URL**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msmrw_actionurl`|
|RequiredLevel|None|
|Type|String|
|Format|Url|
|FormatName|Url|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|2083|

### <a name="BKMK_msmrw_AttentionDirector3DObject"></a> msmrw_AttentionDirector3DObject

|Property|Value|
|---|---|
|Description|**Reference to the attention director 3D Object.**|
|DisplayName|**Attention Director 3D Object**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msmrw_attentiondirector3dobject`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|msmrw_guidestepobjectplacement|

### <a name="BKMK_msmrw_AttentionDirectorEndpointType"></a> msmrw_AttentionDirectorEndpointType

|Property|Value|
|---|---|
|Description|**Specifies what the attention director is attached to (Can be set to: Spatial Location, 3D Object, Anchor 3D Object, No Attachment).**|
|DisplayName|**Attention Director Endpoint Type**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msmrw_attentiondirectorendpointtype`|
|RequiredLevel|None|
|Type|Picklist|
|DefaultFormValue|-1|
|GlobalChoiceName|`msmrw_attentiondirectorendpointtype`|

#### msmrw_AttentionDirectorEndpointType Choices/Options

|Value|Label|
|---|---|
|937380000|**NoAttachment**|
|937380001|**SpatialLocation**|
|937380002|**3DObject**|
|937380003|**Anchor3DObject**|

### <a name="BKMK_msmrw_AttentionDirectorIsPlaced"></a> msmrw_AttentionDirectorIsPlaced

|Property|Value|
|---|---|
|Description|**Defines whether the attention director is spatially placed.**|
|DisplayName|**Attention Director Is Placed**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msmrw_attentiondirectorisplaced`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`msmrw_guidestep_msmrw_attentiondirectorisplaced`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_msmrw_AttentionDirectorPositionX"></a> msmrw_AttentionDirectorPositionX

|Property|Value|
|---|---|
|Description|**Spatial location of the attention director endpoint on a step along the X axis.**|
|DisplayName|**Attention Director Position X**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msmrw_attentiondirectorpositionx`|
|RequiredLevel|None|
|Type|Double|
|ImeMode|Auto|
|MaxValue|300000|
|MinValue|-300000|
|Precision|5|

### <a name="BKMK_msmrw_AttentionDirectorPositionY"></a> msmrw_AttentionDirectorPositionY

|Property|Value|
|---|---|
|Description|**Spatial location of the attention director endpoint on a step along the Y axis.**|
|DisplayName|**Attention Director Position Y**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msmrw_attentiondirectorpositiony`|
|RequiredLevel|None|
|Type|Double|
|ImeMode|Auto|
|MaxValue|300000|
|MinValue|-300000|
|Precision|5|

### <a name="BKMK_msmrw_AttentionDirectorPositionZ"></a> msmrw_AttentionDirectorPositionZ

|Property|Value|
|---|---|
|Description|**Spatial location of the attention director endpoint on a step along the Z axis.**|
|DisplayName|**Attention Director Position Z**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msmrw_attentiondirectorpositionz`|
|RequiredLevel|None|
|Type|Double|
|ImeMode|Auto|
|MaxValue|300000|
|MinValue|-300000|
|Precision|5|

### <a name="BKMK_msmrw_AttentionDirectorRotationW"></a> msmrw_AttentionDirectorRotationW

|Property|Value|
|---|---|
|Description|**Rotational quaternion of the attention director in a step along the W component.**|
|DisplayName|**Attention Director Rotation W**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msmrw_attentiondirectorrotationw`|
|RequiredLevel|None|
|Type|Double|
|ImeMode|Auto|
|MaxValue|1|
|MinValue|-1|
|Precision|5|

### <a name="BKMK_msmrw_AttentionDirectorRotationX"></a> msmrw_AttentionDirectorRotationX

|Property|Value|
|---|---|
|Description|**Rotational quaternion of the attention director in a step along the X component.**|
|DisplayName|**Attention Director Rotation X**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msmrw_attentiondirectorrotationx`|
|RequiredLevel|None|
|Type|Double|
|ImeMode|Auto|
|MaxValue|1|
|MinValue|-1|
|Precision|5|

### <a name="BKMK_msmrw_AttentionDirectorRotationY"></a> msmrw_AttentionDirectorRotationY

|Property|Value|
|---|---|
|Description|**Rotational quaternion of the attention director in a step along the Y component.**|
|DisplayName|**Attention Director Rotation Y**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msmrw_attentiondirectorrotationy`|
|RequiredLevel|None|
|Type|Double|
|ImeMode|Auto|
|MaxValue|1|
|MinValue|-1|
|Precision|5|

### <a name="BKMK_msmrw_AttentionDirectorRotationZ"></a> msmrw_AttentionDirectorRotationZ

|Property|Value|
|---|---|
|Description|**Rotational quaternion of the attention director in a step along the Z component.**|
|DisplayName|**Attention Director Rotation Z**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msmrw_attentiondirectorrotationz`|
|RequiredLevel|None|
|Type|Double|
|ImeMode|Auto|
|MaxValue|1|
|MinValue|-1|
|Precision|5|

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

### <a name="BKMK_msmrw_GuideStepId"></a> msmrw_GuideStepId

|Property|Value|
|---|---|
|Description|**Unique identifier for the step.**|
|DisplayName|**Guide Step**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`msmrw_guidestepid`|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|

### <a name="BKMK_msmrw_Image"></a> msmrw_Image

|Property|Value|
|---|---|
|Description|**Reference to the image associated to a step.**|
|DisplayName|**Image**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msmrw_image`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|msmrw_imageasset|

### <a name="BKMK_msmrw_InstructionText"></a> msmrw_InstructionText

|Property|Value|
|---|---|
|Description|**Instructional text that is written in each step.**|
|DisplayName|**Instruction Text**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msmrw_instructiontext`|
|RequiredLevel|None|
|Type|Memo|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|10000|

### <a name="BKMK_msmrw_Name"></a> msmrw_Name

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

### <a name="BKMK_msmrw_PreviousStep"></a> msmrw_PreviousStep

|Property|Value|
|---|---|
|Description|**Reference to the previous step in the guide.**|
|DisplayName|**Previous Step**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msmrw_previousstep`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|msmrw_guidestep|

### <a name="BKMK_msmrw_Response1ActionType"></a> msmrw_Response1ActionType

|Property|Value|
|---|---|
|Description|**Specifies the navigation behavior when selecting Response 1. (Can be set to: No Action; Go To Next Step; Go To Step.)**|
|DisplayName|**Response 1 Action Type**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msmrw_response1actiontype`|
|RequiredLevel|None|
|Type|Picklist|
|DefaultFormValue|937380001|
|GlobalChoiceName|`msmrw_stepresponseactiontype`|

#### msmrw_Response1ActionType Choices/Options

|Value|Label|
|---|---|
|937380000|**No Action**|
|937380001|**Go To Next Step**|
|937380002|**Go To Step**|

### <a name="BKMK_msmrw_Response1Step"></a> msmrw_Response1Step

|Property|Value|
|---|---|
|Description|**References what step to navigate to when Response 1 button is selected.**|
|DisplayName|**Response 1 Step**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msmrw_response1step`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|msmrw_guidestep|

### <a name="BKMK_msmrw_Response1Text"></a> msmrw_Response1Text

|Property|Value|
|---|---|
|Description|**Response 1 button label on the question step.**|
|DisplayName|**Response 1 Text**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msmrw_response1text`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msmrw_Response2ActionType"></a> msmrw_Response2ActionType

|Property|Value|
|---|---|
|Description|**Specifies the navigation behavior when selecting Response 2. (Can be set to: No Action; Go To Next Step; Go To Step.)**|
|DisplayName|**Response 2 Action Type**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msmrw_response2actiontype`|
|RequiredLevel|None|
|Type|Picklist|
|DefaultFormValue|937380000|
|GlobalChoiceName|`msmrw_stepresponseactiontype`|

#### msmrw_Response2ActionType Choices/Options

|Value|Label|
|---|---|
|937380000|**No Action**|
|937380001|**Go To Next Step**|
|937380002|**Go To Step**|

### <a name="BKMK_msmrw_Response2Step"></a> msmrw_Response2Step

|Property|Value|
|---|---|
|Description|**References what step to navigate to when Response 2 button is selected.**|
|DisplayName|**Response 2 Step**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msmrw_response2step`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|msmrw_guidestep|

### <a name="BKMK_msmrw_Response2Text"></a> msmrw_Response2Text

|Property|Value|
|---|---|
|Description|**Response 2 button label on the question step.**|
|DisplayName|**Response 2 Text**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msmrw_response2text`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msmrw_Response3ActionType"></a> msmrw_Response3ActionType

|Property|Value|
|---|---|
|Description|**Specifies the navigation behavior when selecting Response 3. (Can be set to: No Action; Go To Next Step; Go To Step.)**|
|DisplayName|**Response 3 Action Type**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msmrw_response3actiontype`|
|RequiredLevel|None|
|Type|Picklist|
|DefaultFormValue|937380000|
|GlobalChoiceName|`msmrw_stepresponseactiontype`|

#### msmrw_Response3ActionType Choices/Options

|Value|Label|
|---|---|
|937380000|**No Action**|
|937380001|**Go To Next Step**|
|937380002|**Go To Step**|

### <a name="BKMK_msmrw_Response3Step"></a> msmrw_Response3Step

|Property|Value|
|---|---|
|Description|**References what step to navigate to when Response 3 button is selected.**|
|DisplayName|**Response 3 Step**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msmrw_response3step`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|msmrw_guidestep|

### <a name="BKMK_msmrw_Response3Text"></a> msmrw_Response3Text

|Property|Value|
|---|---|
|Description|**Response 3 button label on the question step.**|
|DisplayName|**Response 3 Text**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msmrw_response3text`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msmrw_StepTemplateType"></a> msmrw_StepTemplateType

|Property|Value|
|---|---|
|Description|**Specifies the type of step. (Can be set to: Default; Question; Completion.)**|
|DisplayName|**Step Template Type**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msmrw_steptemplatetype`|
|RequiredLevel|None|
|Type|Picklist|
|DefaultFormValue|937380000|
|GlobalChoiceName|`msmrw_steptemplatetype`|

#### msmrw_StepTemplateType Choices/Options

|Value|Label|
|---|---|
|937380000|**Default**|
|937380001|**Question**|
|937380002|**Completion**|

### <a name="BKMK_msmrw_Task"></a> msmrw_Task

|Property|Value|
|---|---|
|Description|**Reference to the parent task for this step instruction.**|
|DisplayName|**Task**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msmrw_task`|
|RequiredLevel|ApplicationRequired|
|Type|Lookup|
|Targets|msmrw_guidetask|

### <a name="BKMK_msmrw_Video"></a> msmrw_Video

|Property|Value|
|---|---|
|Description|**Reference to the video that is associated to a step.**|
|DisplayName|**Video**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msmrw_video`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|msmrw_videoasset|

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
|Description|**Status of the Guide Step**|
|DisplayName|**Status**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statecode`|
|RequiredLevel|SystemRequired|
|Type|State|
|DefaultFormValue||
|GlobalChoiceName|`msmrw_guidestep_statecode`|

#### statecode Choices/Options

|Value|Details|
|---|---|
|0|Label: **Active**<br />DefaultStatus: 1<br />InvariantName: `Active`|
|1|Label: **Inactive**<br />DefaultStatus: 2<br />InvariantName: `Inactive`|

### <a name="BKMK_statuscode"></a> statuscode

|Property|Value|
|---|---|
|Description|**Reason for the status of the Guide Step**|
|DisplayName|**Status Reason**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statuscode`|
|RequiredLevel|None|
|Type|Status|
|DefaultFormValue||
|GlobalChoiceName|`msmrw_guidestep_statuscode`|

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

- [business_unit_msmrw_guidestep](#BKMK_business_unit_msmrw_guidestep)
- [lk_msmrw_guidestep_createdby](#BKMK_lk_msmrw_guidestep_createdby)
- [lk_msmrw_guidestep_createdonbehalfby](#BKMK_lk_msmrw_guidestep_createdonbehalfby)
- [lk_msmrw_guidestep_modifiedby](#BKMK_lk_msmrw_guidestep_modifiedby)
- [lk_msmrw_guidestep_modifiedonbehalfby](#BKMK_lk_msmrw_guidestep_modifiedonbehalfby)
- [msmrw_GuideStep_Guide_msmrw_guide](#BKMK_msmrw_GuideStep_Guide_msmrw_guide)
- [msmrw_GuideStep_Image_msmrw_imageasset](#BKMK_msmrw_GuideStep_Image_msmrw_imageasset)
- [msmrw_GuideStep_Task_msmrw_GuideTask](#BKMK_msmrw_GuideStep_Task_msmrw_GuideTask)
- [msmrw_GuideStep_Video_msmrw_videoasset](#BKMK_msmrw_GuideStep_Video_msmrw_videoasset)
- [msmrw_msmrw_guidestep_msmrw_guidestep_PreviousStep](#BKMK_msmrw_msmrw_guidestep_msmrw_guidestep_PreviousStep-many-to-one)
- [msmrw_msmrw_guidestep_msmrw_guidestep_Response1Step](#BKMK_msmrw_msmrw_guidestep_msmrw_guidestep_Response1Step-many-to-one)
- [msmrw_msmrw_guidestep_msmrw_guidestep_Response2Step](#BKMK_msmrw_msmrw_guidestep_msmrw_guidestep_Response2Step-many-to-one)
- [msmrw_msmrw_guidestep_msmrw_guidestep_Response3Step](#BKMK_msmrw_msmrw_guidestep_msmrw_guidestep_Response3Step-many-to-one)
- [msmrw_msmrw_guidestepobjectplacement_msmrw_guidestep_AttentionDirector3DObject](#BKMK_msmrw_msmrw_guidestepobjectplacement_msmrw_guidestep_AttentionDirector3DObject)
- [owner_msmrw_guidestep](#BKMK_owner_msmrw_guidestep)
- [team_msmrw_guidestep](#BKMK_team_msmrw_guidestep)
- [user_msmrw_guidestep](#BKMK_user_msmrw_guidestep)

### <a name="BKMK_business_unit_msmrw_guidestep"></a> business_unit_msmrw_guidestep

One-To-Many Relationship: [businessunit business_unit_msmrw_guidestep](businessunit.md#BKMK_business_unit_msmrw_guidestep)

|Property|Value|
|---|---|
|ReferencedEntity|`businessunit`|
|ReferencedAttribute|`businessunitid`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencingEntityNavigationPropertyName|`owningbusinessunit`|
|IsHierarchical||
|CascadeConfiguration|Archive: `Restrict`<br />Assign: `NoCascade`<br />Delete: `Restrict`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msmrw_guidestep_createdby"></a> lk_msmrw_guidestep_createdby

One-To-Many Relationship: [systemuser lk_msmrw_guidestep_createdby](systemuser.md#BKMK_lk_msmrw_guidestep_createdby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdby`|
|ReferencingEntityNavigationPropertyName|`createdby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msmrw_guidestep_createdonbehalfby"></a> lk_msmrw_guidestep_createdonbehalfby

One-To-Many Relationship: [systemuser lk_msmrw_guidestep_createdonbehalfby](systemuser.md#BKMK_lk_msmrw_guidestep_createdonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdonbehalfby`|
|ReferencingEntityNavigationPropertyName|`createdonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msmrw_guidestep_modifiedby"></a> lk_msmrw_guidestep_modifiedby

One-To-Many Relationship: [systemuser lk_msmrw_guidestep_modifiedby](systemuser.md#BKMK_lk_msmrw_guidestep_modifiedby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedby`|
|ReferencingEntityNavigationPropertyName|`modifiedby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msmrw_guidestep_modifiedonbehalfby"></a> lk_msmrw_guidestep_modifiedonbehalfby

One-To-Many Relationship: [systemuser lk_msmrw_guidestep_modifiedonbehalfby](systemuser.md#BKMK_lk_msmrw_guidestep_modifiedonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedonbehalfby`|
|ReferencingEntityNavigationPropertyName|`modifiedonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msmrw_GuideStep_Guide_msmrw_guide"></a> msmrw_GuideStep_Guide_msmrw_guide

One-To-Many Relationship: [msmrw_guide msmrw_GuideStep_Guide_msmrw_guide](msmrw_guide.md#BKMK_msmrw_GuideStep_Guide_msmrw_guide)

|Property|Value|
|---|---|
|ReferencedEntity|`msmrw_guide`|
|ReferencedAttribute|`msmrw_guideid`|
|ReferencingAttribute|`msmrw_guide`|
|ReferencingEntityNavigationPropertyName|`msmrw_Guide`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msmrw_GuideStep_Image_msmrw_imageasset"></a> msmrw_GuideStep_Image_msmrw_imageasset

One-To-Many Relationship: [msmrw_imageasset msmrw_GuideStep_Image_msmrw_imageasset](msmrw_imageasset.md#BKMK_msmrw_GuideStep_Image_msmrw_imageasset)

|Property|Value|
|---|---|
|ReferencedEntity|`msmrw_imageasset`|
|ReferencedAttribute|`msmrw_imageassetid`|
|ReferencingAttribute|`msmrw_image`|
|ReferencingEntityNavigationPropertyName|`msmrw_Image`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msmrw_GuideStep_Task_msmrw_GuideTask"></a> msmrw_GuideStep_Task_msmrw_GuideTask

One-To-Many Relationship: [msmrw_guidetask msmrw_GuideStep_Task_msmrw_GuideTask](msmrw_guidetask.md#BKMK_msmrw_GuideStep_Task_msmrw_GuideTask)

|Property|Value|
|---|---|
|ReferencedEntity|`msmrw_guidetask`|
|ReferencedAttribute|`msmrw_guidetaskid`|
|ReferencingAttribute|`msmrw_task`|
|ReferencingEntityNavigationPropertyName|`msmrw_Task`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msmrw_GuideStep_Video_msmrw_videoasset"></a> msmrw_GuideStep_Video_msmrw_videoasset

One-To-Many Relationship: [msmrw_videoasset msmrw_GuideStep_Video_msmrw_videoasset](msmrw_videoasset.md#BKMK_msmrw_GuideStep_Video_msmrw_videoasset)

|Property|Value|
|---|---|
|ReferencedEntity|`msmrw_videoasset`|
|ReferencedAttribute|`msmrw_videoassetid`|
|ReferencingAttribute|`msmrw_video`|
|ReferencingEntityNavigationPropertyName|`msmrw_Video`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msmrw_msmrw_guidestep_msmrw_guidestep_PreviousStep-many-to-one"></a> msmrw_msmrw_guidestep_msmrw_guidestep_PreviousStep

One-To-Many Relationship: [msmrw_guidestep msmrw_msmrw_guidestep_msmrw_guidestep_PreviousStep](#BKMK_msmrw_msmrw_guidestep_msmrw_guidestep_PreviousStep-one-to-many)

|Property|Value|
|---|---|
|ReferencedEntity|`msmrw_guidestep`|
|ReferencedAttribute|`msmrw_guidestepid`|
|ReferencingAttribute|`msmrw_previousstep`|
|ReferencingEntityNavigationPropertyName|`msmrw_PreviousStep`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msmrw_msmrw_guidestep_msmrw_guidestep_Response1Step-many-to-one"></a> msmrw_msmrw_guidestep_msmrw_guidestep_Response1Step

One-To-Many Relationship: [msmrw_guidestep msmrw_msmrw_guidestep_msmrw_guidestep_Response1Step](#BKMK_msmrw_msmrw_guidestep_msmrw_guidestep_Response1Step-one-to-many)

|Property|Value|
|---|---|
|ReferencedEntity|`msmrw_guidestep`|
|ReferencedAttribute|`msmrw_guidestepid`|
|ReferencingAttribute|`msmrw_response1step`|
|ReferencingEntityNavigationPropertyName|`msmrw_Response1Step`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msmrw_msmrw_guidestep_msmrw_guidestep_Response2Step-many-to-one"></a> msmrw_msmrw_guidestep_msmrw_guidestep_Response2Step

One-To-Many Relationship: [msmrw_guidestep msmrw_msmrw_guidestep_msmrw_guidestep_Response2Step](#BKMK_msmrw_msmrw_guidestep_msmrw_guidestep_Response2Step-one-to-many)

|Property|Value|
|---|---|
|ReferencedEntity|`msmrw_guidestep`|
|ReferencedAttribute|`msmrw_guidestepid`|
|ReferencingAttribute|`msmrw_response2step`|
|ReferencingEntityNavigationPropertyName|`msmrw_Response2Step`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msmrw_msmrw_guidestep_msmrw_guidestep_Response3Step-many-to-one"></a> msmrw_msmrw_guidestep_msmrw_guidestep_Response3Step

One-To-Many Relationship: [msmrw_guidestep msmrw_msmrw_guidestep_msmrw_guidestep_Response3Step](#BKMK_msmrw_msmrw_guidestep_msmrw_guidestep_Response3Step-one-to-many)

|Property|Value|
|---|---|
|ReferencedEntity|`msmrw_guidestep`|
|ReferencedAttribute|`msmrw_guidestepid`|
|ReferencingAttribute|`msmrw_response3step`|
|ReferencingEntityNavigationPropertyName|`msmrw_Response3Step`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msmrw_msmrw_guidestepobjectplacement_msmrw_guidestep_AttentionDirector3DObject"></a> msmrw_msmrw_guidestepobjectplacement_msmrw_guidestep_AttentionDirector3DObject

One-To-Many Relationship: [msmrw_guidestepobjectplacement msmrw_msmrw_guidestepobjectplacement_msmrw_guidestep_AttentionDirector3DObject](msmrw_guidestepobjectplacement.md#BKMK_msmrw_msmrw_guidestepobjectplacement_msmrw_guidestep_AttentionDirector3DObject)

|Property|Value|
|---|---|
|ReferencedEntity|`msmrw_guidestepobjectplacement`|
|ReferencedAttribute|`msmrw_guidestepobjectplacementid`|
|ReferencingAttribute|`msmrw_attentiondirector3dobject`|
|ReferencingEntityNavigationPropertyName|`msmrw_AttentionDirector3DObject`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_owner_msmrw_guidestep"></a> owner_msmrw_guidestep

One-To-Many Relationship: [owner owner_msmrw_guidestep](owner.md#BKMK_owner_msmrw_guidestep)

|Property|Value|
|---|---|
|ReferencedEntity|`owner`|
|ReferencedAttribute|`ownerid`|
|ReferencingAttribute|`ownerid`|
|ReferencingEntityNavigationPropertyName|`ownerid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_team_msmrw_guidestep"></a> team_msmrw_guidestep

One-To-Many Relationship: [team team_msmrw_guidestep](team.md#BKMK_team_msmrw_guidestep)

|Property|Value|
|---|---|
|ReferencedEntity|`team`|
|ReferencedAttribute|`teamid`|
|ReferencingAttribute|`owningteam`|
|ReferencingEntityNavigationPropertyName|`owningteam`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_user_msmrw_guidestep"></a> user_msmrw_guidestep

One-To-Many Relationship: [systemuser user_msmrw_guidestep](systemuser.md#BKMK_user_msmrw_guidestep)

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

- [msmrw_GuideSessionStepVisit_StepId_msmrw_](#BKMK_msmrw_GuideSessionStepVisit_StepId_msmrw_)
- [msmrw_guidestep_AsyncOperations](#BKMK_msmrw_guidestep_AsyncOperations)
- [msmrw_guidestep_BulkDeleteFailures](#BKMK_msmrw_guidestep_BulkDeleteFailures)
- [msmrw_guidestep_DuplicateBaseRecord](#BKMK_msmrw_guidestep_DuplicateBaseRecord)
- [msmrw_guidestep_DuplicateMatchingRecord](#BKMK_msmrw_guidestep_DuplicateMatchingRecord)
- [msmrw_guidestep_MailboxTrackingFolders](#BKMK_msmrw_guidestep_MailboxTrackingFolders)
- [msmrw_guidestep_PrincipalObjectAttributeAccesses](#BKMK_msmrw_guidestep_PrincipalObjectAttributeAccesses)
- [msmrw_guidestep_ProcessSession](#BKMK_msmrw_guidestep_ProcessSession)
- [msmrw_guidestep_SyncErrors](#BKMK_msmrw_guidestep_SyncErrors)
- [msmrw_msmrw_guidestep_msmrw_guidecompletionstepobject_completionstepobjecttriggerdestination](#BKMK_msmrw_msmrw_guidestep_msmrw_guidecompletionstepobject_completionstepobjecttriggerdestination)
- [msmrw_msmrw_guidestep_msmrw_guidecompletionstepobjectplacement_triggerdestination](#BKMK_msmrw_msmrw_guidestep_msmrw_guidecompletionstepobjectplacement_triggerdestination)
- [msmrw_msmrw_guidestep_msmrw_guidestep_PreviousStep](#BKMK_msmrw_msmrw_guidestep_msmrw_guidestep_PreviousStep-one-to-many)
- [msmrw_msmrw_guidestep_msmrw_guidestep_Response1Step](#BKMK_msmrw_msmrw_guidestep_msmrw_guidestep_Response1Step-one-to-many)
- [msmrw_msmrw_guidestep_msmrw_guidestep_Response2Step](#BKMK_msmrw_msmrw_guidestep_msmrw_guidestep_Response2Step-one-to-many)
- [msmrw_msmrw_guidestep_msmrw_guidestep_Response3Step](#BKMK_msmrw_msmrw_guidestep_msmrw_guidestep_Response3Step-one-to-many)
- [msmrw_msmrw_guidestep_msmrw_guidestepobject_GuideStep](#BKMK_msmrw_msmrw_guidestep_msmrw_guidestepobject_GuideStep)
- [msmrw_msmrw_guidestep_msmrw_guidestepobject_guidestepobjecttriggerdestination](#BKMK_msmrw_msmrw_guidestep_msmrw_guidestepobject_guidestepobjecttriggerdestination)
- [msmrw_msmrw_guidestep_msmrw_guidestepobjectplacement_triggerdestination](#BKMK_msmrw_msmrw_guidestep_msmrw_guidestepobjectplacement_triggerdestination)

### <a name="BKMK_msmrw_GuideSessionStepVisit_StepId_msmrw_"></a> msmrw_GuideSessionStepVisit_StepId_msmrw_

Many-To-One Relationship: [msmrw_guidesessionstepvisit msmrw_GuideSessionStepVisit_StepId_msmrw_](msmrw_guidesessionstepvisit.md#BKMK_msmrw_GuideSessionStepVisit_StepId_msmrw_)

|Property|Value|
|---|---|
|ReferencingEntity|`msmrw_guidesessionstepvisit`|
|ReferencingAttribute|`msmrw_stepid`|
|ReferencedEntityNavigationPropertyName|`msmrw_GuideSessionStepVisit_StepId_msmrw_`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msmrw_guidestep_AsyncOperations"></a> msmrw_guidestep_AsyncOperations

Many-To-One Relationship: [asyncoperation msmrw_guidestep_AsyncOperations](asyncoperation.md#BKMK_msmrw_guidestep_AsyncOperations)

|Property|Value|
|---|---|
|ReferencingEntity|`asyncoperation`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msmrw_guidestep_AsyncOperations`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msmrw_guidestep_BulkDeleteFailures"></a> msmrw_guidestep_BulkDeleteFailures

Many-To-One Relationship: [bulkdeletefailure msmrw_guidestep_BulkDeleteFailures](bulkdeletefailure.md#BKMK_msmrw_guidestep_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencingEntity|`bulkdeletefailure`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msmrw_guidestep_BulkDeleteFailures`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msmrw_guidestep_DuplicateBaseRecord"></a> msmrw_guidestep_DuplicateBaseRecord

Many-To-One Relationship: [duplicaterecord msmrw_guidestep_DuplicateBaseRecord](duplicaterecord.md#BKMK_msmrw_guidestep_DuplicateBaseRecord)

|Property|Value|
|---|---|
|ReferencingEntity|`duplicaterecord`|
|ReferencingAttribute|`baserecordid`|
|ReferencedEntityNavigationPropertyName|`msmrw_guidestep_DuplicateBaseRecord`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msmrw_guidestep_DuplicateMatchingRecord"></a> msmrw_guidestep_DuplicateMatchingRecord

Many-To-One Relationship: [duplicaterecord msmrw_guidestep_DuplicateMatchingRecord](duplicaterecord.md#BKMK_msmrw_guidestep_DuplicateMatchingRecord)

|Property|Value|
|---|---|
|ReferencingEntity|`duplicaterecord`|
|ReferencingAttribute|`duplicaterecordid`|
|ReferencedEntityNavigationPropertyName|`msmrw_guidestep_DuplicateMatchingRecord`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msmrw_guidestep_MailboxTrackingFolders"></a> msmrw_guidestep_MailboxTrackingFolders

Many-To-One Relationship: [mailboxtrackingfolder msmrw_guidestep_MailboxTrackingFolders](mailboxtrackingfolder.md#BKMK_msmrw_guidestep_MailboxTrackingFolders)

|Property|Value|
|---|---|
|ReferencingEntity|`mailboxtrackingfolder`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msmrw_guidestep_MailboxTrackingFolders`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msmrw_guidestep_PrincipalObjectAttributeAccesses"></a> msmrw_guidestep_PrincipalObjectAttributeAccesses

Many-To-One Relationship: [principalobjectattributeaccess msmrw_guidestep_PrincipalObjectAttributeAccesses](principalobjectattributeaccess.md#BKMK_msmrw_guidestep_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencingEntity|`principalobjectattributeaccess`|
|ReferencingAttribute|`objectid`|
|ReferencedEntityNavigationPropertyName|`msmrw_guidestep_PrincipalObjectAttributeAccesses`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msmrw_guidestep_ProcessSession"></a> msmrw_guidestep_ProcessSession

Many-To-One Relationship: [processsession msmrw_guidestep_ProcessSession](processsession.md#BKMK_msmrw_guidestep_ProcessSession)

|Property|Value|
|---|---|
|ReferencingEntity|`processsession`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msmrw_guidestep_ProcessSession`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msmrw_guidestep_SyncErrors"></a> msmrw_guidestep_SyncErrors

Many-To-One Relationship: [syncerror msmrw_guidestep_SyncErrors](syncerror.md#BKMK_msmrw_guidestep_SyncErrors)

|Property|Value|
|---|---|
|ReferencingEntity|`syncerror`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msmrw_guidestep_SyncErrors`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msmrw_msmrw_guidestep_msmrw_guidecompletionstepobject_completionstepobjecttriggerdestination"></a> msmrw_msmrw_guidestep_msmrw_guidecompletionstepobject_completionstepobjecttriggerdestination

Many-To-One Relationship: [msmrw_guidecompletionstepobject msmrw_msmrw_guidestep_msmrw_guidecompletionstepobject_completionstepobjecttriggerdestination](msmrw_guidecompletionstepobject.md#BKMK_msmrw_msmrw_guidestep_msmrw_guidecompletionstepobject_completionstepobjecttriggerdestination)

|Property|Value|
|---|---|
|ReferencingEntity|`msmrw_guidecompletionstepobject`|
|ReferencingAttribute|`msmrw_completionstepobjecttriggerdestination`|
|ReferencedEntityNavigationPropertyName|`msmrw_msmrw_guidestep_msmrw_guidecompletionstepobject_completionstepobjecttriggerdestination`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msmrw_msmrw_guidestep_msmrw_guidecompletionstepobjectplacement_triggerdestination"></a> msmrw_msmrw_guidestep_msmrw_guidecompletionstepobjectplacement_triggerdestination

Many-To-One Relationship: [msmrw_guidecompletionstepobjectplacement msmrw_msmrw_guidestep_msmrw_guidecompletionstepobjectplacement_triggerdestination](msmrw_guidecompletionstepobjectplacement.md#BKMK_msmrw_msmrw_guidestep_msmrw_guidecompletionstepobjectplacement_triggerdestination)

|Property|Value|
|---|---|
|ReferencingEntity|`msmrw_guidecompletionstepobjectplacement`|
|ReferencingAttribute|`msmrw_triggerdestination`|
|ReferencedEntityNavigationPropertyName|`msmrw_msmrw_guidestep_msmrw_guidecompletionstepobjectplacement_triggerdestination`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msmrw_msmrw_guidestep_msmrw_guidestep_PreviousStep-one-to-many"></a> msmrw_msmrw_guidestep_msmrw_guidestep_PreviousStep

Many-To-One Relationship: [msmrw_guidestep msmrw_msmrw_guidestep_msmrw_guidestep_PreviousStep](#BKMK_msmrw_msmrw_guidestep_msmrw_guidestep_PreviousStep-many-to-one)

|Property|Value|
|---|---|
|ReferencingEntity|`msmrw_guidestep`|
|ReferencingAttribute|`msmrw_previousstep`|
|ReferencedEntityNavigationPropertyName|`msmrw_msmrw_guidestep_msmrw_guidestep_PreviousStep`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msmrw_msmrw_guidestep_msmrw_guidestep_Response1Step-one-to-many"></a> msmrw_msmrw_guidestep_msmrw_guidestep_Response1Step

Many-To-One Relationship: [msmrw_guidestep msmrw_msmrw_guidestep_msmrw_guidestep_Response1Step](#BKMK_msmrw_msmrw_guidestep_msmrw_guidestep_Response1Step-many-to-one)

|Property|Value|
|---|---|
|ReferencingEntity|`msmrw_guidestep`|
|ReferencingAttribute|`msmrw_response1step`|
|ReferencedEntityNavigationPropertyName|`msmrw_msmrw_guidestep_msmrw_guidestep_Response1Step`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msmrw_msmrw_guidestep_msmrw_guidestep_Response2Step-one-to-many"></a> msmrw_msmrw_guidestep_msmrw_guidestep_Response2Step

Many-To-One Relationship: [msmrw_guidestep msmrw_msmrw_guidestep_msmrw_guidestep_Response2Step](#BKMK_msmrw_msmrw_guidestep_msmrw_guidestep_Response2Step-many-to-one)

|Property|Value|
|---|---|
|ReferencingEntity|`msmrw_guidestep`|
|ReferencingAttribute|`msmrw_response2step`|
|ReferencedEntityNavigationPropertyName|`msmrw_msmrw_guidestep_msmrw_guidestep_Response2Step`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msmrw_msmrw_guidestep_msmrw_guidestep_Response3Step-one-to-many"></a> msmrw_msmrw_guidestep_msmrw_guidestep_Response3Step

Many-To-One Relationship: [msmrw_guidestep msmrw_msmrw_guidestep_msmrw_guidestep_Response3Step](#BKMK_msmrw_msmrw_guidestep_msmrw_guidestep_Response3Step-many-to-one)

|Property|Value|
|---|---|
|ReferencingEntity|`msmrw_guidestep`|
|ReferencingAttribute|`msmrw_response3step`|
|ReferencedEntityNavigationPropertyName|`msmrw_msmrw_guidestep_msmrw_guidestep_Response3Step`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msmrw_msmrw_guidestep_msmrw_guidestepobject_GuideStep"></a> msmrw_msmrw_guidestep_msmrw_guidestepobject_GuideStep

Many-To-One Relationship: [msmrw_guidestepobject msmrw_msmrw_guidestep_msmrw_guidestepobject_GuideStep](msmrw_guidestepobject.md#BKMK_msmrw_msmrw_guidestep_msmrw_guidestepobject_GuideStep)

|Property|Value|
|---|---|
|ReferencingEntity|`msmrw_guidestepobject`|
|ReferencingAttribute|`msmrw_guidestep`|
|ReferencedEntityNavigationPropertyName|`msmrw_msmrw_guidestep_msmrw_guidestepobject_GuideStep`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msmrw_msmrw_guidestep_msmrw_guidestepobject_guidestepobjecttriggerdestination"></a> msmrw_msmrw_guidestep_msmrw_guidestepobject_guidestepobjecttriggerdestination

Many-To-One Relationship: [msmrw_guidestepobject msmrw_msmrw_guidestep_msmrw_guidestepobject_guidestepobjecttriggerdestination](msmrw_guidestepobject.md#BKMK_msmrw_msmrw_guidestep_msmrw_guidestepobject_guidestepobjecttriggerdestination)

|Property|Value|
|---|---|
|ReferencingEntity|`msmrw_guidestepobject`|
|ReferencingAttribute|`msmrw_guidestepobjecttriggerdestination`|
|ReferencedEntityNavigationPropertyName|`msmrw_msmrw_guidestep_msmrw_guidestepobject_guidestepobjecttriggerdestination`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msmrw_msmrw_guidestep_msmrw_guidestepobjectplacement_triggerdestination"></a> msmrw_msmrw_guidestep_msmrw_guidestepobjectplacement_triggerdestination

Many-To-One Relationship: [msmrw_guidestepobjectplacement msmrw_msmrw_guidestep_msmrw_guidestepobjectplacement_triggerdestination](msmrw_guidestepobjectplacement.md#BKMK_msmrw_msmrw_guidestep_msmrw_guidestepobjectplacement_triggerdestination)

|Property|Value|
|---|---|
|ReferencingEntity|`msmrw_guidestepobjectplacement`|
|ReferencingAttribute|`msmrw_triggerdestination`|
|ReferencedEntityNavigationPropertyName|`msmrw_msmrw_guidestep_msmrw_guidestepobjectplacement_triggerdestination`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|



### See also

[Dataverse table/entity reference](../about-entity-reference.md)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   

