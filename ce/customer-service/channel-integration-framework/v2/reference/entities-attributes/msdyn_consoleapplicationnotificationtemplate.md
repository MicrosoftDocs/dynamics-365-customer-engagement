---
title: "msdyn_consoleapplicationnotificationtemplate Entity Reference | MicrosoftDocs"
description: "Includes schema information and supported messages for the msdyn_consoleapplicationnotificationtemplate entity."
ms.date: 07/02/2020
ms.service: "crm-online"
ms.topic: "reference"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: 3948cc48-07c8-7f60-0608-71c37158ad7c
author: "susikka"
ms.author: "susikka"
manager: "susikka"
---
# msdyn_consoleapplicationnotificationtemplate Entity Reference

Template for a notification

**Added by**: Channel API Integration Framework Solution


## Messages

|Message|Web API Operation|SDK Assembly|
|-|-|-|
|Assign|PATCH [*org URI*]/api/data/v9.1/msdyn_sessionparticipantsdata(*msdyn_sessionparticipantdataid*)|<xref:Microsoft.Crm.Sdk.Messages.AssignRequest>|
|Create|POST [*org URI*]/api/data/v9.1/msdyn_sessionparticipantsdata|<xref:Microsoft.Xrm.Sdk.Messages.CreateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Create*>|
|Delete|DELETE [*org URI*]/api/data/v9.1/msdyn_sessionparticipantsdata(*msdyn_sessionparticipantdataid*)|<xref:Microsoft.Xrm.Sdk.Messages.DeleteRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Delete*>|
|GrantAccess|<xref href="Microsoft.Dynamics.CRM.GrantAccess?text=GrantAccess Action" />|<xref:Microsoft.Crm.Sdk.Messages.GrantAccessRequest>|
|IsValidStateTransition|<xref href="Microsoft.Dynamics.CRM.IsValidStateTransition?text=IsValidStateTransition Function" />|<xref:Microsoft.Crm.Sdk.Messages.IsValidStateTransitionRequest>|
|ModifyAccess|<xref href="Microsoft.Dynamics.CRM.ModifyAccess?text=ModifyAccess Action" />|<xref:Microsoft.Crm.Sdk.Messages.ModifyAccessRequest>|
|Retrieve|GET [*org URI*]/api/data/v9.1/msdyn_sessionparticipantsdata(*msdyn_sessionparticipantdataid*)|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Retrieve*>|
|RetrieveMultiple|GET [*org URI*]/api/data/v9.1/msdyn_sessionparticipantsdata|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveMultipleRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.RetrieveMultiple*>|
|RetrievePrincipalAccess|<xref href="Microsoft.Dynamics.CRM.RetrievePrincipalAccess?text=RetrievePrincipalAccess Function" />|<xref:Microsoft.Crm.Sdk.Messages.RetrievePrincipalAccessRequest>|
|RetrieveSharedPrincipalsAndAccess|<xref href="Microsoft.Dynamics.CRM.RetrieveSharedPrincipalsAndAccess?text=RetrieveSharedPrincipalsAndAccess Function" />|<xref:Microsoft.Crm.Sdk.Messages.RetrieveSharedPrincipalsAndAccessRequest>|
|RevokeAccess|<xref href="Microsoft.Dynamics.CRM.RevokeAccess?text=RevokeAccess Action" />|<xref:Microsoft.Crm.Sdk.Messages.RevokeAccessRequest>|
|SetState|PATCH [*org URI*]/api/data/v9.1/msdyn_sessionparticipantsdata(*msdyn_sessionparticipantdataid*)|<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|
|Update|PATCH [*org URI*]/api/data/v9.1/msdyn_sessionparticipantsdata(*msdyn_sessionparticipantdataid*)|<xref:Microsoft.Xrm.Sdk.Messages.UpdateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Update*>|

## Entity Properties

|Property|Value|
|--------|-----|
|CollectionSchemaName|msdyn_consoleapplicationnotificationtemplates|
|DisplayCollectionName|Notification Templates|
|DisplayName|Notification Template|
|EntitySetName|msdyn_consoleapplicationnotificationtemplates|
|IsBPFEntity|False|
|LogicalCollectionName|msdyn_consoleapplicationnotificationtemplates|
|LogicalName|msdyn_consoleapplicationnotificationtemplate|
|OwnershipType|UserOwned|
|PrimaryIdAttribute|msdyn_consoleapplicationnotificationtemplateid|
|PrimaryNameAttribute|msdyn_name|
|SchemaName|msdyn_consoleapplicationnotificationtemplate|

<a name="writable-attributes"></a>

## Writable attributes

These attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [msdyn_AcceptButtonText](#BKMK_msdyn_AcceptButtonText)
- [msdyn_ActionButtons](#BKMK_msdyn_ActionButtons)
- [msdyn_consoleapplicationnotificationtemplateId](#BKMK_msdyn_consoleapplicationnotificationtemplateId)
- [msdyn_DesktopNotificationSettings](#BKMK_msdyn_DesktopNotificationSettings)
- [msdyn_Icon](#BKMK_msdyn_Icon)
- [msdyn_name](#BKMK_msdyn_name)
- [msdyn_NotificationButtons](#BKMK_msdyn_NotificationButtons)
- [msdyn_NotificationFieldsPlaceholder](#BKMK_msdyn_NotificationFieldsPlaceholder)
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
|--------|-----|
|Description|Sequence number of the import that created this record.|
|DisplayName|Import Sequence Number|
|Format|None|
|IsValidForForm|False|
|IsValidForRead|True|
|IsValidForUpdate|False|
|LogicalName|importsequencenumber|
|MaxValue|2147483647|
|MinValue|-2147483648|
|RequiredLevel|None|
|Type|Integer|


### <a name="BKMK_msdyn_AcceptButtonText"></a> msdyn_AcceptButtonText

**Added by**: Channel API Integration Framework Patch Solution

|Property|Value|
|--------|-----|
|Description||
|DisplayName|Accept Button Text|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_acceptbuttontext|
|MaxLength|250|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_msdyn_ActionButtons"></a> msdyn_ActionButtons

|Property|Value|
|--------|-----|
|Description|The action buttons to be displayed. (Deprecated)|
|DisplayName|ActionButtons (Deprecated)|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_actionbuttons|
|RequiredLevel|None|
|Type|MultiSelectPicklist|

#### msdyn_ActionButtons Options

|Value|Label|
|-----|-----|
|100000000|Allow|
|100000001|Deny|



### <a name="BKMK_msdyn_consoleapplicationnotificationtemplateId"></a> msdyn_consoleapplicationnotificationtemplateId

|Property|Value|
|--------|-----|
|Description|Unique identifier for entity instances|
|DisplayName|ConsoleApplicationNotificationTemplate|
|IsValidForForm|False|
|IsValidForRead|True|
|IsValidForUpdate|False|
|LogicalName|msdyn_consoleapplicationnotificationtemplateid|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|


### <a name="BKMK_msdyn_DesktopNotificationSettings"></a> msdyn_DesktopNotificationSettings

**Added by**: Channel API Integration Framework Patch Solution

|Property|Value|
|--------|-----|
|Description|Show desktop notifications when app is in background or never|
|DisplayName|Show desktop notifications|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_desktopnotificationsettings|
|RequiredLevel|None|
|Type|Picklist|

#### msdyn_DesktopNotificationSettings Options

|Value|Label|
|-----|-----|
|100000002|Never|
|100000003|When app is in background|



### <a name="BKMK_msdyn_Icon"></a> msdyn_Icon

|Property|Value|
|--------|-----|
|Description|Display icon for this notification. Can be either an image URL or a font-icon|
|DisplayName|Icon|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_icon|
|MaxLength|1024|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_msdyn_name"></a> msdyn_name

|Property|Value|
|--------|-----|
|Description|The name of this Notification template.|
|DisplayName|Name|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_name|
|MaxLength|100|
|RequiredLevel|ApplicationRequired|
|Type|String|


### <a name="BKMK_msdyn_NotificationButtons"></a> msdyn_NotificationButtons

|Property|Value|
|--------|-----|
|Description|JSON object to pass key-value pairs for action buttons that are to be present on the notification|
|DisplayName|Notification Buttons|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_notificationbuttons|
|MaxLength|300|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_msdyn_NotificationFieldsPlaceholder"></a> msdyn_NotificationFieldsPlaceholder

|Property|Value|
|--------|-----|
|Description|Deprecated field|
|DisplayName|Notification Fields|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_notificationfieldsplaceholder|
|MaxLength|200|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_msdyn_RejectButtonText"></a> msdyn_RejectButtonText

**Added by**: Channel API Integration Framework Patch Solution

|Property|Value|
|--------|-----|
|Description||
|DisplayName|Reject Button Text|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_rejectbuttontext|
|MaxLength|250|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_msdyn_RenderingOrder"></a> msdyn_RenderingOrder

|Property|Value|
|--------|-----|
|Description|Notification display order relative to other notification templates.|
|DisplayName|Notification order|
|Format|None|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_renderingorder|
|MaxValue|2147483647|
|MinValue|0|
|RequiredLevel|None|
|Type|Integer|


### <a name="BKMK_msdyn_Showtimeout"></a> msdyn_Showtimeout

**Added by**: Channel API Integration Framework Patch Solution

|Property|Value|
|--------|-----|
|Description|Show countdown for when the notification will disappear|
|DisplayName|Show timeout|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_showtimeout|
|RequiredLevel|None|
|Type|Picklist|

#### msdyn_Showtimeout Options

|Value|Label|
|-----|-----|
|100000000|Yes|
|100000001|No|



### <a name="BKMK_msdyn_Theme"></a> msdyn_Theme

**Added by**: Channel API Integration Framework Patch Solution

|Property|Value|
|--------|-----|
|Description|Theme color for Notification template.|
|DisplayName|Theme|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_theme|
|RequiredLevel|None|
|Type|Picklist|

#### msdyn_Theme Options

|Value|Label|
|-----|-----|
|100000000|Dark|
|100000001|Light|



### <a name="BKMK_msdyn_Timeout"></a> msdyn_Timeout

|Property|Value|
|--------|-----|
|Description|Notification time out period.|
|DisplayName|Timeout (seconds)|
|Format|None|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_timeout|
|MaxValue|500|
|MinValue|0|
|RequiredLevel|None|
|Type|Integer|


### <a name="BKMK_msdyn_Title"></a> msdyn_Title

|Property|Value|
|--------|-----|
|Description|The title to be displayed for this notification.|
|DisplayName|Title|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_title|
|MaxLength|100|
|RequiredLevel|ApplicationRequired|
|Type|String|


### <a name="BKMK_OverriddenCreatedOn"></a> OverriddenCreatedOn

|Property|Value|
|--------|-----|
|DateTimeBehavior|UserLocal|
|Description|Date and time that the record was migrated.|
|DisplayName|Record Created On|
|Format|DateOnly|
|IsValidForForm|False|
|IsValidForRead|True|
|IsValidForUpdate|False|
|LogicalName|overriddencreatedon|
|RequiredLevel|None|
|Type|DateTime|


### <a name="BKMK_OwnerId"></a> OwnerId

**Added by**: Active Solution Solution

|Property|Value|
|--------|-----|
|Description|Owner Id|
|DisplayName|Owner|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|ownerid|
|RequiredLevel|SystemRequired|
|Targets|systemuser,team|
|Type|Owner|


### <a name="BKMK_OwnerIdType"></a> OwnerIdType

**Added by**: Active Solution Solution

|Property|Value|
|--------|-----|
|Description|Owner Id Type|
|DisplayName||
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|owneridtype|
|RequiredLevel|SystemRequired|
|Type|EntityName|


### <a name="BKMK_statecode"></a> statecode

|Property|Value|
|--------|-----|
|Description|Status of the Notification Template|
|DisplayName|Status|
|IsValidForCreate|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|statecode|
|RequiredLevel|SystemRequired|
|Type|State|

#### statecode Options

|Value|Label|DefaultStatus|InvariantName|
|-----|-----|-------------|-------------|
|0|Active|1|Active|
|1|Inactive|2|Inactive|



### <a name="BKMK_statuscode"></a> statuscode

|Property|Value|
|--------|-----|
|Description|Reason for the status of the Notification Template|
|DisplayName|Status Reason|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|statuscode|
|RequiredLevel|None|
|Type|Status|

#### statuscode Options

|Value|Label|State|
|-----|-----|-----|
|1|Active|0|
|2|Inactive|1|



### <a name="BKMK_TimeZoneRuleVersionNumber"></a> TimeZoneRuleVersionNumber

|Property|Value|
|--------|-----|
|Description|For internal use only.|
|DisplayName|Time Zone Rule Version Number|
|Format|None|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|timezoneruleversionnumber|
|MaxValue|2147483647|
|MinValue|-1|
|RequiredLevel|None|
|Type|Integer|


### <a name="BKMK_UTCConversionTimeZoneCode"></a> UTCConversionTimeZoneCode

|Property|Value|
|--------|-----|
|Description|Time zone code that was in use when the record was created.|
|DisplayName|UTC Conversion Time Zone Code|
|Format|None|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|utcconversiontimezonecode|
|MaxValue|2147483647|
|MinValue|-1|
|RequiredLevel|None|
|Type|Integer|

<a name="read-only-attributes"></a>

## Read-only attributes

These attributes return false for both **IsValidForCreate** or **IsValidForUpdate**. Listed by **SchemaName**.

- [CreatedBy](#BKMK_CreatedBy)
- [CreatedByName](#BKMK_CreatedByName)
- [CreatedByYomiName](#BKMK_CreatedByYomiName)
- [CreatedOn](#BKMK_CreatedOn)
- [CreatedOnBehalfBy](#BKMK_CreatedOnBehalfBy)
- [CreatedOnBehalfByName](#BKMK_CreatedOnBehalfByName)
- [CreatedOnBehalfByYomiName](#BKMK_CreatedOnBehalfByYomiName)
- [ModifiedBy](#BKMK_ModifiedBy)
- [ModifiedByName](#BKMK_ModifiedByName)
- [ModifiedByYomiName](#BKMK_ModifiedByYomiName)
- [ModifiedOn](#BKMK_ModifiedOn)
- [ModifiedOnBehalfBy](#BKMK_ModifiedOnBehalfBy)
- [ModifiedOnBehalfByName](#BKMK_ModifiedOnBehalfByName)
- [ModifiedOnBehalfByYomiName](#BKMK_ModifiedOnBehalfByYomiName)
- [OwnerIdName](#BKMK_OwnerIdName)
- [OwnerIdYomiName](#BKMK_OwnerIdYomiName)
- [OwningBusinessUnit](#BKMK_OwningBusinessUnit)
- [OwningTeam](#BKMK_OwningTeam)
- [OwningUser](#BKMK_OwningUser)
- [VersionNumber](#BKMK_VersionNumber)


### <a name="BKMK_CreatedBy"></a> CreatedBy

**Added by**: Active Solution Solution

|Property|Value|
|--------|-----|
|Description|Unique identifier of the user who created the record.|
|DisplayName|Created By|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|createdby|
|RequiredLevel|None|
|Targets|systemuser|
|Type|Lookup|


### <a name="BKMK_CreatedByName"></a> CreatedByName

**Added by**: Active Solution Solution

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|createdbyname|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_CreatedByYomiName"></a> CreatedByYomiName

**Added by**: Active Solution Solution

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|createdbyyominame|
|MaxLength|100|
|RequiredLevel|SystemRequired|
|Type|String|


### <a name="BKMK_CreatedOn"></a> CreatedOn

|Property|Value|
|--------|-----|
|DateTimeBehavior|UserLocal|
|Description|Date and time when the record was created.|
|DisplayName|Created On|
|Format|DateAndTime|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|createdon|
|RequiredLevel|None|
|Type|DateTime|


### <a name="BKMK_CreatedOnBehalfBy"></a> CreatedOnBehalfBy

**Added by**: Active Solution Solution

|Property|Value|
|--------|-----|
|Description|Unique identifier of the delegate user who created the record.|
|DisplayName|Created By (Delegate)|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|createdonbehalfby|
|RequiredLevel|None|
|Targets|systemuser|
|Type|Lookup|


### <a name="BKMK_CreatedOnBehalfByName"></a> CreatedOnBehalfByName

**Added by**: Active Solution Solution

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|createdonbehalfbyname|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_CreatedOnBehalfByYomiName"></a> CreatedOnBehalfByYomiName

**Added by**: Active Solution Solution

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|createdonbehalfbyyominame|
|MaxLength|100|
|RequiredLevel|SystemRequired|
|Type|String|


### <a name="BKMK_ModifiedBy"></a> ModifiedBy

**Added by**: Active Solution Solution

|Property|Value|
|--------|-----|
|Description|Unique identifier of the user who modified the record.|
|DisplayName|Modified By|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|modifiedby|
|RequiredLevel|None|
|Targets|systemuser|
|Type|Lookup|


### <a name="BKMK_ModifiedByName"></a> ModifiedByName

**Added by**: Active Solution Solution

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|modifiedbyname|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_ModifiedByYomiName"></a> ModifiedByYomiName

**Added by**: Active Solution Solution

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|modifiedbyyominame|
|MaxLength|100|
|RequiredLevel|SystemRequired|
|Type|String|


### <a name="BKMK_ModifiedOn"></a> ModifiedOn

|Property|Value|
|--------|-----|
|DateTimeBehavior|UserLocal|
|Description|Date and time when the record was modified.|
|DisplayName|Modified On|
|Format|DateAndTime|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|modifiedon|
|RequiredLevel|None|
|Type|DateTime|


### <a name="BKMK_ModifiedOnBehalfBy"></a> ModifiedOnBehalfBy

**Added by**: Active Solution Solution

|Property|Value|
|--------|-----|
|Description|Unique identifier of the delegate user who modified the record.|
|DisplayName|Modified By (Delegate)|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|modifiedonbehalfby|
|RequiredLevel|None|
|Targets|systemuser|
|Type|Lookup|


### <a name="BKMK_ModifiedOnBehalfByName"></a> ModifiedOnBehalfByName

**Added by**: Active Solution Solution

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|modifiedonbehalfbyname|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_ModifiedOnBehalfByYomiName"></a> ModifiedOnBehalfByYomiName

**Added by**: Active Solution Solution

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|modifiedonbehalfbyyominame|
|MaxLength|100|
|RequiredLevel|SystemRequired|
|Type|String|


### <a name="BKMK_OwnerIdName"></a> OwnerIdName

**Added by**: Active Solution Solution

|Property|Value|
|--------|-----|
|Description|Name of the owner|
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|owneridname|
|MaxLength|100|
|RequiredLevel|SystemRequired|
|Type|String|


### <a name="BKMK_OwnerIdYomiName"></a> OwnerIdYomiName

**Added by**: Active Solution Solution

|Property|Value|
|--------|-----|
|Description|Yomi name of the owner|
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|owneridyominame|
|MaxLength|100|
|RequiredLevel|SystemRequired|
|Type|String|


### <a name="BKMK_OwningBusinessUnit"></a> OwningBusinessUnit

**Added by**: Active Solution Solution

|Property|Value|
|--------|-----|
|Description|Unique identifier for the business unit that owns the record|
|DisplayName|Owning Business Unit|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|owningbusinessunit|
|RequiredLevel|None|
|Targets|businessunit|
|Type|Lookup|


### <a name="BKMK_OwningTeam"></a> OwningTeam

**Added by**: Active Solution Solution

|Property|Value|
|--------|-----|
|Description|Unique identifier for the team that owns the record.|
|DisplayName|Owning Team|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|owningteam|
|RequiredLevel|None|
|Targets|team|
|Type|Lookup|


### <a name="BKMK_OwningUser"></a> OwningUser

**Added by**: Active Solution Solution

|Property|Value|
|--------|-----|
|Description|Unique identifier for the user that owns the record.|
|DisplayName|Owning User|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|owninguser|
|RequiredLevel|None|
|Targets|systemuser|
|Type|Lookup|


### <a name="BKMK_VersionNumber"></a> VersionNumber

**Added by**: Active Solution Solution

|Property|Value|
|--------|-----|
|Description|Version Number|
|DisplayName|Version Number|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|versionnumber|
|MaxValue|9223372036854775807|
|MinValue|-9223372036854775808|
|RequiredLevel|None|
|Type|BigInt|

<a name="manytomany"></a>

## Many-To-Many Relationships

Relationship details provided where the msdyn_consoleapplicationnotificationtemplate entity is the first entity in the relationship. Listed by **SchemaName**.

- [msdyn_msdyn_consoleapplicationnotificationtempl](#BKMK_msdyn_msdyn_consoleapplicationnotificationtempl)
- [msdyn_msdyn_consoleapplicationnotificationtag](#BKMK_msdyn_msdyn_consoleapplicationnotificationtag)


### <a name="BKMK_msdyn_msdyn_consoleapplicationnotificationtempl"></a> msdyn_msdyn_consoleapplicationnotificationtempl

IntersectEntityName: msdyn_msdyn_consoleapplicationnotificationtem<br />
#### Entity 1

|Property|Value|
|--------|-----|
|IntersectAttribute|msdyn_consoleapplicationnotificationtemplateid|
|IsCustomizable|True|
|LogicalName|msdyn_consoleapplicationnotificationtemplate|
|NavigationPropertyName|msdyn_msdyn_consoleapplicationnotificationtempl|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |

#### Entity 2

|Property|Value|
|--------|-----|
|LogicalName|msdyn_consoleapplicationnotificationfield|
|IntersectAttribute|msdyn_consoleapplicationnotificationfieldid|
|NavigationPropertyName|msdyn_msdyn_consoleapplicationnotificationtempl|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Details<br />Label: Notification Body Data<br />Order: 10000|


### <a name="BKMK_msdyn_msdyn_consoleapplicationnotificationtag"></a> msdyn_msdyn_consoleapplicationnotificationtag

IntersectEntityName: msdyn_msdyn_consoleapplicationnotificationtag<br />
#### Entity 1

|Property|Value|
|--------|-----|
|IntersectAttribute|msdyn_consoleapplicationnotificationtemplateid|
|IsCustomizable|True|
|LogicalName|msdyn_consoleapplicationnotificationtemplate|
|NavigationPropertyName|msdyn_msdyn_consoleapplicationnotificationtag|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |

#### Entity 2

|Property|Value|
|--------|-----|
|LogicalName|msdyn_templatetags|
|IntersectAttribute|msdyn_templatetagsid|
|NavigationPropertyName|msdyn_msdyn_consoleapplicationnotificationtag|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Details<br />Label: <br />Order: 10000|


### See also

[Microsoft.CIFramework APIs](../microsoft-ciframework-v2.md)<br />
[Client-side events](../client-side-events.md)