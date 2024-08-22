---
title: "Notification Template (Deprecated) (msdyn_consoleapplicationnotificationtemplate) table/entity reference (Microsoft Dynamics 365)"
description: "Includes schema information and supported messages for the Notification Template (Deprecated) (msdyn_consoleapplicationnotificationtemplate) table/entity with Microsoft Dynamics 365."
ms.date: 08/21/2024
ms.service: powerapps
ms.topic: reference
author: JimDaly
ms.author: jdaly
search.audienceType: 
  - developer
---

# Notification Template (Deprecated) (msdyn_consoleapplicationnotificationtemplate) table/entity reference

Template for a notification

## Messages

The following table lists the messages for the Notification Template (Deprecated) (msdyn_consoleapplicationnotificationtemplate) table.
Messages represent operations that can be performed on the table. They may also be events.

| Name <br />Is Event? |Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `Assign`<br />Event: True |`PATCH` /msdyn_consoleapplicationnotificationtemplates(*msdyn_consoleapplicationnotificationtemplateid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `ownerid` property. |<xref:Microsoft.Crm.Sdk.Messages.AssignRequest>|
| `Create`<br />Event: True |`POST` /msdyn_consoleapplicationnotificationtemplates<br />See [Create](/powerapps/developer/data-platform/webapi/create-entity-web-api) |[Create records](/power-apps/developer/data-platform/org-service/entity-operations-create#basic-create)|
| `CreateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.CreateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.CreateMultipleRequest>|
| `Delete`<br />Event: True |`DELETE` /msdyn_consoleapplicationnotificationtemplates(*msdyn_consoleapplicationnotificationtemplateid*)<br />See [Delete](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-delete) |[Delete records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-delete)|
| `DeleteMultiple`<br />Event: True | |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `GrantAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.GrantAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.GrantAccessRequest>|
| `IsValidStateTransition`<br />Event: False |<xref:Microsoft.Dynamics.CRM.IsValidStateTransition?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.IsValidStateTransitionRequest>|
| `ModifyAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.ModifyAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.ModifyAccessRequest>|
| `Restore`<br />Event: True |<xref:Microsoft.Dynamics.CRM.Restore?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retrieve`<br />Event: True |`GET` /msdyn_consoleapplicationnotificationtemplates(*msdyn_consoleapplicationnotificationtemplateid*)<br />See [Retrieve](/powerapps/developer/data-platform/webapi/retrieve-entity-using-web-api) |[Retrieve records](/power-apps/developer/data-platform/org-service/entity-operations-retrieve)|
| `RetrieveMultiple`<br />Event: True |`GET` /msdyn_consoleapplicationnotificationtemplates<br />See [Query data](/power-apps/developer/data-platform/webapi/query-data-web-api) |[Query data](/power-apps/developer/data-platform/org-service/entity-operations-query-data)|
| `RetrievePrincipalAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RetrievePrincipalAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RetrievePrincipalAccessRequest>|
| `RetrieveSharedPrincipalsAndAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RetrieveSharedPrincipalsAndAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RetrieveSharedPrincipalsAndAccessRequest>|
| `RevokeAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RevokeAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RevokeAccessRequest>|
| `SetState`<br />Event: True |`PATCH` /msdyn_consoleapplicationnotificationtemplates(*msdyn_consoleapplicationnotificationtemplateid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `statecode` and `statuscode` properties. |<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|
| `Update`<br />Event: True |`PATCH` /msdyn_consoleapplicationnotificationtemplates(*msdyn_consoleapplicationnotificationtemplateid*)<br />See [Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) |[Update records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-update)|
| `UpdateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.UpdateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpdateMultipleRequest>|
| `Upsert`<br />Event: False |`PATCH` /msdyn_consoleapplicationnotificationtemplates(*msdyn_consoleapplicationnotificationtemplateid*)<br />See [Upsert a table row](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#upsert-a-table-row) |<xref:Microsoft.Xrm.Sdk.Messages.UpsertRequest>|
| `UpsertMultiple`<br />Event: False |<xref:Microsoft.Dynamics.CRM.UpsertMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpsertMultipleRequest>|


## Events

The following table lists the events for the Notification Template (Deprecated) (msdyn_consoleapplicationnotificationtemplate) table.
Events are messages that exist so that you can subscribe to them. Unless you added the event, you shouldn't invoke the message, only subscribe to it.

|Name|Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `BulkRetain`|<xref:Microsoft.Dynamics.CRM.BulkRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `PurgeRetainedContent`|<xref:Microsoft.Dynamics.CRM.PurgeRetainedContent?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retain`|<xref:Microsoft.Dynamics.CRM.Retain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `RollbackRetain`|<xref:Microsoft.Dynamics.CRM.RollbackRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `ValidateRetentionConfig`|<xref:Microsoft.Dynamics.CRM.ValidateRetentionConfig?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|

## Properties

The following table lists selected properties for the Notification Template (Deprecated) (msdyn_consoleapplicationnotificationtemplate) table.

|Property|Value|
| --- | --- |
| **DisplayName** | **Notification Template (Deprecated)** |
| **DisplayCollectionName** | **Notification Templates (Deprecated)** |
| **SchemaName** | `msdyn_consoleapplicationnotificationtemplate` |
| **CollectionSchemaName** | `msdyn_consoleapplicationnotificationtemplates` |
| **EntitySetName** | `msdyn_consoleapplicationnotificationtemplates`|
| **LogicalName** | `msdyn_consoleapplicationnotificationtemplate` |
| **LogicalCollectionName** | `msdyn_consoleapplicationnotificationtemplates` |
| **PrimaryIdAttribute** | `msdyn_consoleapplicationnotificationtemplateid` |
| **PrimaryNameAttribute** |`msdyn_name` |
| **TableType** | `Standard` |
| **OwnershipType** | `UserOwned` |

## Writable columns/attributes

These columns/attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [msdyn_AcceptButtonText](#BKMK_msdyn_AcceptButtonText)
- [msdyn_ActionButtons](#BKMK_msdyn_ActionButtons)
- [msdyn_AutoAcceptNotification](#BKMK_msdyn_AutoAcceptNotification)
- [msdyn_consoleapplicationnotificationtemplateId](#BKMK_msdyn_consoleapplicationnotificationtemplateId)
- [msdyn_DesktopNotificationSettings](#BKMK_msdyn_DesktopNotificationSettings)
- [msdyn_Icon](#BKMK_msdyn_Icon)
- [msdyn_name](#BKMK_msdyn_name)
- [msdyn_NotificationButtons](#BKMK_msdyn_NotificationButtons)
- [msdyn_NotificationFieldsPlaceholder](#BKMK_msdyn_NotificationFieldsPlaceholder)
- [msdyn_RejectButtonAutoAccept](#BKMK_msdyn_RejectButtonAutoAccept)
- [msdyn_RejectButtonText](#BKMK_msdyn_RejectButtonText)
- [msdyn_RenderingOrder](#BKMK_msdyn_RenderingOrder)
- [msdyn_Showtimeout](#BKMK_msdyn_Showtimeout)
- [msdyn_Theme](#BKMK_msdyn_Theme)
- [msdyn_Timeout](#BKMK_msdyn_Timeout)
- [msdyn_Title](#BKMK_msdyn_Title)
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

### <a name="BKMK_msdyn_AcceptButtonText"></a> msdyn_AcceptButtonText

|Property|Value|
|---|---|
|Description|**Display label for the button to accept a notification**|
|DisplayName|**Accept Button Text**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_acceptbuttontext`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|250|

### <a name="BKMK_msdyn_ActionButtons"></a> msdyn_ActionButtons

|Property|Value|
|---|---|
|Description|**The action buttons to be displayed. (Deprecated)**|
|DisplayName|**ActionButtons (Deprecated)**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_actionbuttons`|
|RequiredLevel|None|
|Type|MultiSelectPicklist|
|DefaultFormValue|-1|
|GlobalChoiceName|`msdyn_consoleapplicationnotificationaction`|

#### msdyn_ActionButtons Choices/Options

|Value|Label|
|---|---|
|100000000|**Allow**|
|100000001|**Deny**|

### <a name="BKMK_msdyn_AutoAcceptNotification"></a> msdyn_AutoAcceptNotification

|Property|Value|
|---|---|
|Description||
|DisplayName|**Auto Accept Notification**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_autoacceptnotification`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`msdyn_consoleapplicationnotificationtemplate_msdyn_autoacceptnotification`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_msdyn_consoleapplicationnotificationtemplateId"></a> msdyn_consoleapplicationnotificationtemplateId

|Property|Value|
|---|---|
|Description|**Unique identifier for entity instances**|
|DisplayName|**ConsoleApplicationNotificationTemplate**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`msdyn_consoleapplicationnotificationtemplateid`|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|

### <a name="BKMK_msdyn_DesktopNotificationSettings"></a> msdyn_DesktopNotificationSettings

|Property|Value|
|---|---|
|Description|**Show desktop notifications when app is in background or never**|
|DisplayName|**Show desktop notifications**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_desktopnotificationsettings`|
|RequiredLevel|None|
|Type|Picklist|
|DefaultFormValue|100000002|
|GlobalChoiceName|`msdyn_desktopnotificationsettings`|

#### msdyn_DesktopNotificationSettings Choices/Options

|Value|Label|
|---|---|
|100000002|**Never**|
|100000003|**When app is in background**|

### <a name="BKMK_msdyn_Icon"></a> msdyn_Icon

|Property|Value|
|---|---|
|Description|**Display icon for this notification. Can be either an image URL or a font-icon**|
|DisplayName|**Icon**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_icon`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|1024|

### <a name="BKMK_msdyn_name"></a> msdyn_name

|Property|Value|
|---|---|
|Description|**The name of this Notification template.**|
|DisplayName|**Name**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_name`|
|RequiredLevel|ApplicationRequired|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdyn_NotificationButtons"></a> msdyn_NotificationButtons

|Property|Value|
|---|---|
|Description|**JSON object to pass key-value pairs for action buttons that are to be present on the notification**|
|DisplayName|**Notification Buttons**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_notificationbuttons`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|300|

### <a name="BKMK_msdyn_NotificationFieldsPlaceholder"></a> msdyn_NotificationFieldsPlaceholder

|Property|Value|
|---|---|
|Description|**Deprecated field**|
|DisplayName|**Notification Fields**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_notificationfieldsplaceholder`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|200|

### <a name="BKMK_msdyn_RejectButtonAutoAccept"></a> msdyn_RejectButtonAutoAccept

|Property|Value|
|---|---|
|Description||
|DisplayName|**Reject Button**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_rejectbuttonautoaccept`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`msdyn_consoleapplicationnotificationtemplate_msdyn_rejectbuttonautoaccept`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_msdyn_RejectButtonText"></a> msdyn_RejectButtonText

|Property|Value|
|---|---|
|Description|**Display label for the button to reject a notification**|
|DisplayName|**Reject Button Text**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_rejectbuttontext`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|250|

### <a name="BKMK_msdyn_RenderingOrder"></a> msdyn_RenderingOrder

|Property|Value|
|---|---|
|Description|**Notification display order relative to other notification templates.**|
|DisplayName|**Notification order**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_renderingorder`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|0|

### <a name="BKMK_msdyn_Showtimeout"></a> msdyn_Showtimeout

|Property|Value|
|---|---|
|Description|**Show countdown for when the notification will disappear**|
|DisplayName|**Show timeout**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_showtimeout`|
|RequiredLevel|None|
|Type|Picklist|
|DefaultFormValue|100000000|
|GlobalChoiceName|`msdyn_consoleapplicationnotificationtemplate_msdyn_showtimeout`|

#### msdyn_Showtimeout Choices/Options

|Value|Label|
|---|---|
|100000000|**Yes**|
|100000001|**No**|

### <a name="BKMK_msdyn_Theme"></a> msdyn_Theme

|Property|Value|
|---|---|
|Description|**Theme color for Notification template.**|
|DisplayName|**Theme**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_theme`|
|RequiredLevel|None|
|Type|Picklist|
|DefaultFormValue|100000000|
|GlobalChoiceName|`msdyn_consoleapplicationnotificationtemplate_msdyn_theme`|

#### msdyn_Theme Choices/Options

|Value|Label|
|---|---|
|100000000|**Dark**|
|100000001|**Light**|

### <a name="BKMK_msdyn_Timeout"></a> msdyn_Timeout

|Property|Value|
|---|---|
|Description|**Notification time out period.**|
|DisplayName|**Timeout (seconds)**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_timeout`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|500|
|MinValue|0|

### <a name="BKMK_msdyn_Title"></a> msdyn_Title

|Property|Value|
|---|---|
|Description|**The title to be displayed for this notification.**|
|DisplayName|**Title**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_title`|
|RequiredLevel|ApplicationRequired|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

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
|Description|**Status of the Notification Template**|
|DisplayName|**Status**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statecode`|
|RequiredLevel|SystemRequired|
|Type|State|
|DefaultFormValue||
|GlobalChoiceName|`msdyn_consoleapplicationnotificationtemplate_statecode`|

#### statecode Choices/Options

|Value|Details|
|---|---|
|0|Label: **Active**<br />DefaultStatus: 1<br />InvariantName: `Active`|
|1|Label: **Inactive**<br />DefaultStatus: 2<br />InvariantName: `Inactive`|

### <a name="BKMK_statuscode"></a> statuscode

|Property|Value|
|---|---|
|Description|**Reason for the status of the Notification Template**|
|DisplayName|**Status Reason**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statuscode`|
|RequiredLevel|None|
|Type|Status|
|DefaultFormValue||
|GlobalChoiceName|`msdyn_consoleapplicationnotificationtemplate_statuscode`|

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

- [business_unit_msdyn_consoleapplicationnotificationtemplate](#BKMK_business_unit_msdyn_consoleapplicationnotificationtemplate)
- [lk_msdyn_consoleapplicationnotificationtemplate_createdby](#BKMK_lk_msdyn_consoleapplicationnotificationtemplate_createdby)
- [lk_msdyn_consoleapplicationnotificationtemplate_createdonbehalfby](#BKMK_lk_msdyn_consoleapplicationnotificationtemplate_createdonbehalfby)
- [lk_msdyn_consoleapplicationnotificationtemplate_modifiedby](#BKMK_lk_msdyn_consoleapplicationnotificationtemplate_modifiedby)
- [lk_msdyn_consoleapplicationnotificationtemplate_modifiedonbehalfby](#BKMK_lk_msdyn_consoleapplicationnotificationtemplate_modifiedonbehalfby)
- [owner_msdyn_consoleapplicationnotificationtemplate](#BKMK_owner_msdyn_consoleapplicationnotificationtemplate)
- [team_msdyn_consoleapplicationnotificationtemplate](#BKMK_team_msdyn_consoleapplicationnotificationtemplate)
- [user_msdyn_consoleapplicationnotificationtemplate](#BKMK_user_msdyn_consoleapplicationnotificationtemplate)

### <a name="BKMK_business_unit_msdyn_consoleapplicationnotificationtemplate"></a> business_unit_msdyn_consoleapplicationnotificationtemplate

One-To-Many Relationship: [businessunit business_unit_msdyn_consoleapplicationnotificationtemplate](businessunit.md#BKMK_business_unit_msdyn_consoleapplicationnotificationtemplate)

|Property|Value|
|---|---|
|ReferencedEntity|`businessunit`|
|ReferencedAttribute|`businessunitid`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencingEntityNavigationPropertyName|`owningbusinessunit`|
|IsHierarchical||
|CascadeConfiguration|Archive: `Restrict`<br />Assign: `NoCascade`<br />Delete: `Restrict`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_consoleapplicationnotificationtemplate_createdby"></a> lk_msdyn_consoleapplicationnotificationtemplate_createdby

One-To-Many Relationship: [systemuser lk_msdyn_consoleapplicationnotificationtemplate_createdby](systemuser.md#BKMK_lk_msdyn_consoleapplicationnotificationtemplate_createdby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdby`|
|ReferencingEntityNavigationPropertyName|`createdby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_consoleapplicationnotificationtemplate_createdonbehalfby"></a> lk_msdyn_consoleapplicationnotificationtemplate_createdonbehalfby

One-To-Many Relationship: [systemuser lk_msdyn_consoleapplicationnotificationtemplate_createdonbehalfby](systemuser.md#BKMK_lk_msdyn_consoleapplicationnotificationtemplate_createdonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdonbehalfby`|
|ReferencingEntityNavigationPropertyName|`createdonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_consoleapplicationnotificationtemplate_modifiedby"></a> lk_msdyn_consoleapplicationnotificationtemplate_modifiedby

One-To-Many Relationship: [systemuser lk_msdyn_consoleapplicationnotificationtemplate_modifiedby](systemuser.md#BKMK_lk_msdyn_consoleapplicationnotificationtemplate_modifiedby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedby`|
|ReferencingEntityNavigationPropertyName|`modifiedby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_consoleapplicationnotificationtemplate_modifiedonbehalfby"></a> lk_msdyn_consoleapplicationnotificationtemplate_modifiedonbehalfby

One-To-Many Relationship: [systemuser lk_msdyn_consoleapplicationnotificationtemplate_modifiedonbehalfby](systemuser.md#BKMK_lk_msdyn_consoleapplicationnotificationtemplate_modifiedonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedonbehalfby`|
|ReferencingEntityNavigationPropertyName|`modifiedonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_owner_msdyn_consoleapplicationnotificationtemplate"></a> owner_msdyn_consoleapplicationnotificationtemplate

One-To-Many Relationship: [owner owner_msdyn_consoleapplicationnotificationtemplate](owner.md#BKMK_owner_msdyn_consoleapplicationnotificationtemplate)

|Property|Value|
|---|---|
|ReferencedEntity|`owner`|
|ReferencedAttribute|`ownerid`|
|ReferencingAttribute|`ownerid`|
|ReferencingEntityNavigationPropertyName|`ownerid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_team_msdyn_consoleapplicationnotificationtemplate"></a> team_msdyn_consoleapplicationnotificationtemplate

One-To-Many Relationship: [team team_msdyn_consoleapplicationnotificationtemplate](team.md#BKMK_team_msdyn_consoleapplicationnotificationtemplate)

|Property|Value|
|---|---|
|ReferencedEntity|`team`|
|ReferencedAttribute|`teamid`|
|ReferencingAttribute|`owningteam`|
|ReferencingEntityNavigationPropertyName|`owningteam`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_user_msdyn_consoleapplicationnotificationtemplate"></a> user_msdyn_consoleapplicationnotificationtemplate

One-To-Many Relationship: [systemuser user_msdyn_consoleapplicationnotificationtemplate](systemuser.md#BKMK_user_msdyn_consoleapplicationnotificationtemplate)

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

- [msdyn_consoleapplicationnotificationtemplate_AsyncOperations](#BKMK_msdyn_consoleapplicationnotificationtemplate_AsyncOperations)
- [msdyn_consoleapplicationnotificationtemplate_BulkDeleteFailures](#BKMK_msdyn_consoleapplicationnotificationtemplate_BulkDeleteFailures)
- [msdyn_consoleapplicationnotificationtemplate_DuplicateBaseRecord](#BKMK_msdyn_consoleapplicationnotificationtemplate_DuplicateBaseRecord)
- [msdyn_consoleapplicationnotificationtemplate_DuplicateMatchingRecord](#BKMK_msdyn_consoleapplicationnotificationtemplate_DuplicateMatchingRecord)
- [msdyn_consoleapplicationnotificationtemplate_MailboxTrackingFolders](#BKMK_msdyn_consoleapplicationnotificationtemplate_MailboxTrackingFolders)
- [msdyn_consoleapplicationnotificationtemplate_PrincipalObjectAttributeAccesses](#BKMK_msdyn_consoleapplicationnotificationtemplate_PrincipalObjectAttributeAccesses)
- [msdyn_consoleapplicationnotificationtemplate_ProcessSession](#BKMK_msdyn_consoleapplicationnotificationtemplate_ProcessSession)
- [msdyn_consoleapplicationnotificationtemplate_SyncErrors](#BKMK_msdyn_consoleapplicationnotificationtemplate_SyncErrors)

### <a name="BKMK_msdyn_consoleapplicationnotificationtemplate_AsyncOperations"></a> msdyn_consoleapplicationnotificationtemplate_AsyncOperations

Many-To-One Relationship: [asyncoperation msdyn_consoleapplicationnotificationtemplate_AsyncOperations](asyncoperation.md#BKMK_msdyn_consoleapplicationnotificationtemplate_AsyncOperations)

|Property|Value|
|---|---|
|ReferencingEntity|`asyncoperation`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_consoleapplicationnotificationtemplate_AsyncOperations`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_consoleapplicationnotificationtemplate_BulkDeleteFailures"></a> msdyn_consoleapplicationnotificationtemplate_BulkDeleteFailures

Many-To-One Relationship: [bulkdeletefailure msdyn_consoleapplicationnotificationtemplate_BulkDeleteFailures](bulkdeletefailure.md#BKMK_msdyn_consoleapplicationnotificationtemplate_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencingEntity|`bulkdeletefailure`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_consoleapplicationnotificationtemplate_BulkDeleteFailures`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_consoleapplicationnotificationtemplate_DuplicateBaseRecord"></a> msdyn_consoleapplicationnotificationtemplate_DuplicateBaseRecord

Many-To-One Relationship: [duplicaterecord msdyn_consoleapplicationnotificationtemplate_DuplicateBaseRecord](duplicaterecord.md#BKMK_msdyn_consoleapplicationnotificationtemplate_DuplicateBaseRecord)

|Property|Value|
|---|---|
|ReferencingEntity|`duplicaterecord`|
|ReferencingAttribute|`baserecordid`|
|ReferencedEntityNavigationPropertyName|`msdyn_consoleapplicationnotificationtemplate_DuplicateBaseRecord`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_consoleapplicationnotificationtemplate_DuplicateMatchingRecord"></a> msdyn_consoleapplicationnotificationtemplate_DuplicateMatchingRecord

Many-To-One Relationship: [duplicaterecord msdyn_consoleapplicationnotificationtemplate_DuplicateMatchingRecord](duplicaterecord.md#BKMK_msdyn_consoleapplicationnotificationtemplate_DuplicateMatchingRecord)

|Property|Value|
|---|---|
|ReferencingEntity|`duplicaterecord`|
|ReferencingAttribute|`duplicaterecordid`|
|ReferencedEntityNavigationPropertyName|`msdyn_consoleapplicationnotificationtemplate_DuplicateMatchingRecord`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_consoleapplicationnotificationtemplate_MailboxTrackingFolders"></a> msdyn_consoleapplicationnotificationtemplate_MailboxTrackingFolders

Many-To-One Relationship: [mailboxtrackingfolder msdyn_consoleapplicationnotificationtemplate_MailboxTrackingFolders](mailboxtrackingfolder.md#BKMK_msdyn_consoleapplicationnotificationtemplate_MailboxTrackingFolders)

|Property|Value|
|---|---|
|ReferencingEntity|`mailboxtrackingfolder`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_consoleapplicationnotificationtemplate_MailboxTrackingFolders`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_consoleapplicationnotificationtemplate_PrincipalObjectAttributeAccesses"></a> msdyn_consoleapplicationnotificationtemplate_PrincipalObjectAttributeAccesses

Many-To-One Relationship: [principalobjectattributeaccess msdyn_consoleapplicationnotificationtemplate_PrincipalObjectAttributeAccesses](principalobjectattributeaccess.md#BKMK_msdyn_consoleapplicationnotificationtemplate_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencingEntity|`principalobjectattributeaccess`|
|ReferencingAttribute|`objectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_consoleapplicationnotificationtemplate_PrincipalObjectAttributeAccesses`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_consoleapplicationnotificationtemplate_ProcessSession"></a> msdyn_consoleapplicationnotificationtemplate_ProcessSession

Many-To-One Relationship: [processsession msdyn_consoleapplicationnotificationtemplate_ProcessSession](processsession.md#BKMK_msdyn_consoleapplicationnotificationtemplate_ProcessSession)

|Property|Value|
|---|---|
|ReferencingEntity|`processsession`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_consoleapplicationnotificationtemplate_ProcessSession`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_consoleapplicationnotificationtemplate_SyncErrors"></a> msdyn_consoleapplicationnotificationtemplate_SyncErrors

Many-To-One Relationship: [syncerror msdyn_consoleapplicationnotificationtemplate_SyncErrors](syncerror.md#BKMK_msdyn_consoleapplicationnotificationtemplate_SyncErrors)

|Property|Value|
|---|---|
|ReferencingEntity|`syncerror`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_consoleapplicationnotificationtemplate_SyncErrors`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|


## Many-to-Many relationships

These relationships are many-to-many. Listed by **SchemaName**.

### <a name="BKMK_msdyn_msdyn_consoleapplicationnotificationtempl"></a> msdyn_msdyn_consoleapplicationnotificationtempl

See [msdyn_consoleapplicationnotificationfield msdyn_msdyn_consoleapplicationnotificationtempl Many-To-Many Relationship](msdyn_consoleapplicationnotificationfield.md#BKMK_msdyn_msdyn_consoleapplicationnotificationtempl)

|Property|Value|
|---|---|
|IntersectEntityName|`msdyn_msdyn_consoleapplicationnotificationtem`|
|IsCustomizable|True|
|SchemaName|`msdyn_msdyn_consoleapplicationnotificationtempl`|
|IntersectAttribute|`msdyn_consoleapplicationnotificationtemplateid`|
|NavigationPropertyName|`msdyn_msdyn_consoleapplicationnotificationtempl`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|



### See also

[Dataverse table/entity reference](../about-entity-reference.md)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   

