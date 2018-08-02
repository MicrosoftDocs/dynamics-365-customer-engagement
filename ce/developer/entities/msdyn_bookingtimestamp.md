---
title: "msdyn_bookingtimestamp Entity Reference (Developer Guide for Dynamics 365 Customer Engagement)| MicrosoftDocs"
description: "Includes schema information and supported messages for the msdyn_bookingtimestamp entity."
ms.date: 12/05/2017
ms.service: "crm-online"
ms.topic: "reference"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: 3948cc48-07c8-7f60-0608-71c37158ad7c
author: "JimDaly"
ms.author: "jdaly"
manager: "jdaly"
---
# msdyn_bookingtimestamp Entity Reference

Tracks status changes of bookings and timestamps the change of the status

**Added by**: Field Service Solution<br />

## Messages

|Message|Web API Operation|SDK Assembly|
|-|-|-|
|Assign|PATCH [*org URI*]/api/data/v9.0/msdyn_bookingtimestamps(*msdyn_bookingtimestampid*)<br />[Update](../webapi/update-delete-entities-using-web-api.md#basic-update) `ownerid` property.|<xref:Microsoft.Crm.Sdk.Messages.AssignRequest>|
|Create|POST [*org URI*]/api/data/v9.0/msdyn_bookingtimestamps<br />See [Create](../webapi/create-entity-web-api.md)|<xref:Microsoft.Xrm.Sdk.Messages.CreateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Create*>|
|Delete|DELETE [*org URI*]/api/data/v9.0/msdyn_bookingtimestamps(*msdyn_bookingtimestampid*)<br />See [Delete](../webapi/update-delete-entities-using-web-api.md#basic-delete)|<xref:Microsoft.Xrm.Sdk.Messages.DeleteRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Delete*>|
|GrantAccess|<xref href="Microsoft.Dynamics.CRM.GrantAccess?text=GrantAccess Action" />|<xref:Microsoft.Crm.Sdk.Messages.GrantAccessRequest>|
|IsValidStateTransition|<xref href="Microsoft.Dynamics.CRM.IsValidStateTransition?text=IsValidStateTransition Function" />|<xref:Microsoft.Crm.Sdk.Messages.IsValidStateTransitionRequest>|
|ModifyAccess|<xref href="Microsoft.Dynamics.CRM.ModifyAccess?text=ModifyAccess Action" />|<xref:Microsoft.Crm.Sdk.Messages.ModifyAccessRequest>|
|Retrieve|GET [*org URI*]/api/data/v9.0/msdyn_bookingtimestamps(*msdyn_bookingtimestampid*)<br />See [Retrieve](../webapi/retrieve-entity-using-web-api.md)|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Retrieve*>|
|RetrieveMultiple|GET [*org URI*]/api/data/v9.0/msdyn_bookingtimestamps<br />See [Query Data](../webapi/query-data-web-api.md)|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveMultipleRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.RetrieveMultiple*>|
|RetrievePrincipalAccess|<xref href="Microsoft.Dynamics.CRM.RetrievePrincipalAccess?text=RetrievePrincipalAccess Function" />|<xref:Microsoft.Crm.Sdk.Messages.RetrievePrincipalAccessRequest>|
|RetrieveSharedPrincipalsAndAccess|<xref href="Microsoft.Dynamics.CRM.RetrieveSharedPrincipalsAndAccess?text=RetrieveSharedPrincipalsAndAccess Function" />|<xref:Microsoft.Crm.Sdk.Messages.RetrieveSharedPrincipalsAndAccessRequest>|
|RevokeAccess|<xref href="Microsoft.Dynamics.CRM.RevokeAccess?text=RevokeAccess Action" />|<xref:Microsoft.Crm.Sdk.Messages.RevokeAccessRequest>|
|SetState|PATCH [*org URI*]/api/data/v9.0/msdyn_bookingtimestamps(*msdyn_bookingtimestampid*)<br />[Update](../webapi/update-delete-entities-using-web-api.md#basic-update) `statecode` and `statuscode` properties.|<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|
|Update|PATCH [*org URI*]/api/data/v9.0/msdyn_bookingtimestamps(*msdyn_bookingtimestampid*)<br />See [Update](../webapi/update-delete-entities-using-web-api.md#basic-update)|<xref:Microsoft.Xrm.Sdk.Messages.UpdateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Update*>|

## Entity Properties

|Property|Value|
|--------|-----|
|CollectionSchemaName|msdyn_bookingtimestamps|
|DisplayCollectionName|Booking Timestamps|
|DisplayName|Booking Timestamp|
|EntitySetName|msdyn_bookingtimestamps|
|IsBPFEntity|False|
|LogicalCollectionName|msdyn_bookingtimestamps|
|LogicalName|msdyn_bookingtimestamp|
|OwnershipType|UserOwned|
|PrimaryIdAttribute|msdyn_bookingtimestampid|
|PrimaryNameAttribute|msdyn_name|
|SchemaName|msdyn_bookingtimestamp|

<a name="writable-attributes"></a>

## Writable attributes

These attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [msdyn_Booking](#BKMK_msdyn_Booking)
- [msdyn_bookingtimestampId](#BKMK_msdyn_bookingtimestampId)
- [msdyn_GenerateJournals](#BKMK_msdyn_GenerateJournals)
- [msdyn_name](#BKMK_msdyn_name)
- [msdyn_SystemStatus](#BKMK_msdyn_SystemStatus)
- [msdyn_TimestampSource](#BKMK_msdyn_TimestampSource)
- [msdyn_TimestampTime](#BKMK_msdyn_TimestampTime)
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
|Description|Shows the sequence number of the import that created this record.|
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


### <a name="BKMK_msdyn_Booking"></a> msdyn_Booking

|Property|Value|
|--------|-----|
|Description|Unique identifier for Resource Booking associated with Booking Timestamp.|
|DisplayName|Booking|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_booking|
|RequiredLevel|ApplicationRequired|
|Targets|bookableresourcebooking|
|Type|Lookup|


### <a name="BKMK_msdyn_bookingtimestampId"></a> msdyn_bookingtimestampId

|Property|Value|
|--------|-----|
|Description|Shows the entity instances.|
|DisplayName|Booking Timestamp|
|IsValidForForm|False|
|IsValidForRead|True|
|IsValidForUpdate|False|
|LogicalName|msdyn_bookingtimestampid|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|


### <a name="BKMK_msdyn_GenerateJournals"></a> msdyn_GenerateJournals

|Property|Value|
|--------|-----|
|Description|System internal field. Indicates that journals must be generated after saving timestamp from mobile.|
|DisplayName|Generate Journals|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_generatejournals|
|RequiredLevel|None|
|Type|Boolean|

#### msdyn_GenerateJournals Options

|Value|Label|
|-----|-----|
|1|Yes|
|0|No|

**DefaultValue**: False



### <a name="BKMK_msdyn_name"></a> msdyn_name

|Property|Value|
|--------|-----|
|Description|Enter the name of the custom entity.|
|DisplayName|Name|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_name|
|MaxLength|100|
|RequiredLevel|ApplicationRequired|
|Type|String|


### <a name="BKMK_msdyn_SystemStatus"></a> msdyn_SystemStatus

|Property|Value|
|--------|-----|
|Description||
|DisplayName|System Status|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_systemstatus|
|RequiredLevel|ApplicationRequired|
|Type|Picklist|

#### msdyn_SystemStatus Options

|Value|Label|
|-----|-----|
|690970000|Scheduled|
|690970001|Traveling|
|690970002|On Break|
|690970003|In Progress|
|690970004|Completed|
|690970005|Canceled|



### <a name="BKMK_msdyn_TimestampSource"></a> msdyn_TimestampSource

|Property|Value|
|--------|-----|
|Description||
|DisplayName|Timestamp Source|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_timestampsource|
|RequiredLevel|None|
|Type|Picklist|

#### msdyn_TimestampSource Options

|Value|Label|
|-----|-----|
|690970000|Desktop|
|690970001|Mobile|



### <a name="BKMK_msdyn_TimestampTime"></a> msdyn_TimestampTime

|Property|Value|
|--------|-----|
|DateTimeBehavior|UserLocal|
|Description||
|DisplayName|Timestamp Time|
|Format|DateAndTime|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_timestamptime|
|RequiredLevel|ApplicationRequired|
|Type|DateTime|


### <a name="BKMK_OverriddenCreatedOn"></a> OverriddenCreatedOn

|Property|Value|
|--------|-----|
|DateTimeBehavior|UserLocal|
|Description|Shows the date and time that the record was migrated.|
|DisplayName|Record Created On|
|Format|DateOnly|
|IsValidForForm|False|
|IsValidForRead|True|
|IsValidForUpdate|False|
|LogicalName|overriddencreatedon|
|RequiredLevel|None|
|Type|DateTime|


### <a name="BKMK_OwnerId"></a> OwnerId

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
|Description|Status of the Booking Timestamp|
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
|Description|Reason for the status of the Booking Timestamp|
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
|Description|Shows the time zone code that was in use when the record was created.|
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
- [msdyn_BookingName](#BKMK_msdyn_BookingName)
- [OwnerIdName](#BKMK_OwnerIdName)
- [OwnerIdYomiName](#BKMK_OwnerIdYomiName)
- [OwningBusinessUnit](#BKMK_OwningBusinessUnit)
- [OwningTeam](#BKMK_OwningTeam)
- [OwningUser](#BKMK_OwningUser)
- [VersionNumber](#BKMK_VersionNumber)


### <a name="BKMK_CreatedBy"></a> CreatedBy

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
|Description|Shows the date and time when the record was created. The date and time are displayed in the time zone selected in Microsoft Dynamics 365 options.|
|DisplayName|Created On|
|Format|DateAndTime|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|createdon|
|RequiredLevel|None|
|Type|DateTime|


### <a name="BKMK_CreatedOnBehalfBy"></a> CreatedOnBehalfBy

|Property|Value|
|--------|-----|
|Description|Shows who created the record on behalf of another user.|
|DisplayName|Created By (Delegate)|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|createdonbehalfby|
|RequiredLevel|None|
|Targets|systemuser|
|Type|Lookup|


### <a name="BKMK_CreatedOnBehalfByName"></a> CreatedOnBehalfByName

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
|Description|Shows the date and time when the record was last updated. The date and time are displayed in the time zone selected in Microsoft Dynamics 365 options.|
|DisplayName|Modified On|
|Format|DateAndTime|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|modifiedon|
|RequiredLevel|None|
|Type|DateTime|


### <a name="BKMK_ModifiedOnBehalfBy"></a> ModifiedOnBehalfBy

|Property|Value|
|--------|-----|
|Description|Shows who last updated the record on behalf of another user.|
|DisplayName|Modified By (Delegate)|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|modifiedonbehalfby|
|RequiredLevel|None|
|Targets|systemuser|
|Type|Lookup|


### <a name="BKMK_ModifiedOnBehalfByName"></a> ModifiedOnBehalfByName

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


### <a name="BKMK_msdyn_BookingName"></a> msdyn_BookingName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|msdyn_bookingname|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_OwnerIdName"></a> OwnerIdName

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

<a name="onetomany"></a>

## One-To-Many Relationships

Listed by **SchemaName**.

- [msdyn_bookingtimestamp_ActivityPointers](#BKMK_msdyn_bookingtimestamp_ActivityPointers)
- [msdyn_bookingtimestamp_msdyn_approvals](#BKMK_msdyn_bookingtimestamp_msdyn_approvals)
- [msdyn_bookingtimestamp_msdyn_bookingalerts](#BKMK_msdyn_bookingtimestamp_msdyn_bookingalerts)
- [msdyn_bookingtimestamp_SyncErrors](#BKMK_msdyn_bookingtimestamp_SyncErrors)
- [msdyn_bookingtimestamp_DuplicateMatchingRecord](#BKMK_msdyn_bookingtimestamp_DuplicateMatchingRecord)
- [msdyn_bookingtimestamp_DuplicateBaseRecord](#BKMK_msdyn_bookingtimestamp_DuplicateBaseRecord)
- [msdyn_bookingtimestamp_SharePointDocumentLocations](#BKMK_msdyn_bookingtimestamp_SharePointDocumentLocations)
- [msdyn_bookingtimestamp_SharePointDocuments](#BKMK_msdyn_bookingtimestamp_SharePointDocuments)
- [msdyn_bookingtimestamp_AsyncOperations](#BKMK_msdyn_bookingtimestamp_AsyncOperations)
- [msdyn_bookingtimestamp_MailboxTrackingFolders](#BKMK_msdyn_bookingtimestamp_MailboxTrackingFolders)
- [msdyn_bookingtimestamp_UserEntityInstanceDatas](#BKMK_msdyn_bookingtimestamp_UserEntityInstanceDatas)
- [msdyn_bookingtimestamp_ProcessSession](#BKMK_msdyn_bookingtimestamp_ProcessSession)
- [msdyn_bookingtimestamp_BulkDeleteFailures](#BKMK_msdyn_bookingtimestamp_BulkDeleteFailures)
- [msdyn_bookingtimestamp_PrincipalObjectAttributeAccesses](#BKMK_msdyn_bookingtimestamp_PrincipalObjectAttributeAccesses)
- [msdyn_bookingtimestamp_Appointments](#BKMK_msdyn_bookingtimestamp_Appointments)
- [msdyn_bookingtimestamp_Emails](#BKMK_msdyn_bookingtimestamp_Emails)
- [msdyn_bookingtimestamp_Faxes](#BKMK_msdyn_bookingtimestamp_Faxes)
- [msdyn_bookingtimestamp_Letters](#BKMK_msdyn_bookingtimestamp_Letters)
- [msdyn_bookingtimestamp_PhoneCalls](#BKMK_msdyn_bookingtimestamp_PhoneCalls)
- [msdyn_bookingtimestamp_Tasks](#BKMK_msdyn_bookingtimestamp_Tasks)
- [msdyn_bookingtimestamp_RecurringAppointmentMasters](#BKMK_msdyn_bookingtimestamp_RecurringAppointmentMasters)
- [msdyn_bookingtimestamp_SocialActivities](#BKMK_msdyn_bookingtimestamp_SocialActivities)
- [msdyn_bookingtimestamp_connections1](#BKMK_msdyn_bookingtimestamp_connections1)
- [msdyn_bookingtimestamp_connections2](#BKMK_msdyn_bookingtimestamp_connections2)
- [msdyn_bookingtimestamp_Annotations](#BKMK_msdyn_bookingtimestamp_Annotations)
- [msdyn_bookingtimestamp_ServiceAppointments](#BKMK_msdyn_bookingtimestamp_ServiceAppointments)


### <a name="BKMK_msdyn_bookingtimestamp_ActivityPointers"></a> msdyn_bookingtimestamp_ActivityPointers

Same as activitypointer entity [msdyn_bookingtimestamp_ActivityPointers](activitypointer.md#BKMK_msdyn_bookingtimestamp_ActivityPointers) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|activitypointer|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_bookingtimestamp_ActivityPointers|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: RemoveLink<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_bookingtimestamp_msdyn_approvals"></a> msdyn_bookingtimestamp_msdyn_approvals

Same as msdyn_approval entity [msdyn_bookingtimestamp_msdyn_approvals](msdyn_approval.md#BKMK_msdyn_bookingtimestamp_msdyn_approvals) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_approval|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_bookingtimestamp_msdyn_approvals|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: Cascade<br />Share: Cascade<br />Unshare: Cascade|


### <a name="BKMK_msdyn_bookingtimestamp_msdyn_bookingalerts"></a> msdyn_bookingtimestamp_msdyn_bookingalerts

Same as msdyn_bookingalert entity [msdyn_bookingtimestamp_msdyn_bookingalerts](msdyn_bookingalert.md#BKMK_msdyn_bookingtimestamp_msdyn_bookingalerts) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_bookingalert|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_bookingtimestamp_msdyn_bookingalerts|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: Cascade<br />Share: Cascade<br />Unshare: Cascade|


### <a name="BKMK_msdyn_bookingtimestamp_SyncErrors"></a> msdyn_bookingtimestamp_SyncErrors

Same as syncerror entity [msdyn_bookingtimestamp_SyncErrors](syncerror.md#BKMK_msdyn_bookingtimestamp_SyncErrors) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|syncerror|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_bookingtimestamp_SyncErrors|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: Cascade<br />Share: Cascade<br />Unshare: Cascade|


### <a name="BKMK_msdyn_bookingtimestamp_DuplicateMatchingRecord"></a> msdyn_bookingtimestamp_DuplicateMatchingRecord

Same as duplicaterecord entity [msdyn_bookingtimestamp_DuplicateMatchingRecord](duplicaterecord.md#BKMK_msdyn_bookingtimestamp_DuplicateMatchingRecord) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|duplicaterecord|
|ReferencingAttribute|duplicaterecordid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_bookingtimestamp_DuplicateMatchingRecord|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_bookingtimestamp_DuplicateBaseRecord"></a> msdyn_bookingtimestamp_DuplicateBaseRecord

Same as duplicaterecord entity [msdyn_bookingtimestamp_DuplicateBaseRecord](duplicaterecord.md#BKMK_msdyn_bookingtimestamp_DuplicateBaseRecord) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|duplicaterecord|
|ReferencingAttribute|baserecordid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_bookingtimestamp_DuplicateBaseRecord|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_bookingtimestamp_SharePointDocumentLocations"></a> msdyn_bookingtimestamp_SharePointDocumentLocations

Same as sharepointdocumentlocation entity [msdyn_bookingtimestamp_SharePointDocumentLocations](sharepointdocumentlocation.md#BKMK_msdyn_bookingtimestamp_SharePointDocumentLocations) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|sharepointdocumentlocation|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_bookingtimestamp_SharePointDocumentLocations|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: Cascade<br />Reparent: Cascade<br />Share: Cascade<br />Unshare: Cascade|


### <a name="BKMK_msdyn_bookingtimestamp_SharePointDocuments"></a> msdyn_bookingtimestamp_SharePointDocuments

Same as sharepointdocument entity [msdyn_bookingtimestamp_SharePointDocuments](sharepointdocument.md#BKMK_msdyn_bookingtimestamp_SharePointDocuments) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|sharepointdocument|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_bookingtimestamp_SharePointDocuments|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Details<br />Label: <br />Order: 60|
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: Cascade<br />Reparent: Cascade<br />Share: Cascade<br />Unshare: Cascade|


### <a name="BKMK_msdyn_bookingtimestamp_AsyncOperations"></a> msdyn_bookingtimestamp_AsyncOperations

Same as asyncoperation entity [msdyn_bookingtimestamp_AsyncOperations](asyncoperation.md#BKMK_msdyn_bookingtimestamp_AsyncOperations) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|asyncoperation|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_bookingtimestamp_AsyncOperations|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_bookingtimestamp_MailboxTrackingFolders"></a> msdyn_bookingtimestamp_MailboxTrackingFolders

Same as mailboxtrackingfolder entity [msdyn_bookingtimestamp_MailboxTrackingFolders](mailboxtrackingfolder.md#BKMK_msdyn_bookingtimestamp_MailboxTrackingFolders) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|mailboxtrackingfolder|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_bookingtimestamp_MailboxTrackingFolders|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: Cascade<br />Share: Cascade<br />Unshare: Cascade|


### <a name="BKMK_msdyn_bookingtimestamp_UserEntityInstanceDatas"></a> msdyn_bookingtimestamp_UserEntityInstanceDatas

Same as userentityinstancedata entity [msdyn_bookingtimestamp_UserEntityInstanceDatas](userentityinstancedata.md#BKMK_msdyn_bookingtimestamp_UserEntityInstanceDatas) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|userentityinstancedata|
|ReferencingAttribute|objectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_bookingtimestamp_UserEntityInstanceDatas|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_bookingtimestamp_ProcessSession"></a> msdyn_bookingtimestamp_ProcessSession

Same as processsession entity [msdyn_bookingtimestamp_ProcessSession](processsession.md#BKMK_msdyn_bookingtimestamp_ProcessSession) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|processsession|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_bookingtimestamp_ProcessSession|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_bookingtimestamp_BulkDeleteFailures"></a> msdyn_bookingtimestamp_BulkDeleteFailures

Same as bulkdeletefailure entity [msdyn_bookingtimestamp_BulkDeleteFailures](bulkdeletefailure.md#BKMK_msdyn_bookingtimestamp_BulkDeleteFailures) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|bulkdeletefailure|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_bookingtimestamp_BulkDeleteFailures|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_bookingtimestamp_PrincipalObjectAttributeAccesses"></a> msdyn_bookingtimestamp_PrincipalObjectAttributeAccesses

Same as principalobjectattributeaccess entity [msdyn_bookingtimestamp_PrincipalObjectAttributeAccesses](principalobjectattributeaccess.md#BKMK_msdyn_bookingtimestamp_PrincipalObjectAttributeAccesses) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|principalobjectattributeaccess|
|ReferencingAttribute|objectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_bookingtimestamp_PrincipalObjectAttributeAccesses|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_bookingtimestamp_Appointments"></a> msdyn_bookingtimestamp_Appointments

Same as appointment entity [msdyn_bookingtimestamp_Appointments](appointment.md#BKMK_msdyn_bookingtimestamp_Appointments) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|appointment|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_bookingtimestamp_Appointments|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: Cascade<br />Share: Cascade<br />Unshare: Cascade|


### <a name="BKMK_msdyn_bookingtimestamp_Emails"></a> msdyn_bookingtimestamp_Emails

Same as email entity [msdyn_bookingtimestamp_Emails](email.md#BKMK_msdyn_bookingtimestamp_Emails) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|email|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_bookingtimestamp_Emails|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: Cascade<br />Share: Cascade<br />Unshare: Cascade|


### <a name="BKMK_msdyn_bookingtimestamp_Faxes"></a> msdyn_bookingtimestamp_Faxes

Same as fax entity [msdyn_bookingtimestamp_Faxes](fax.md#BKMK_msdyn_bookingtimestamp_Faxes) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|fax|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_bookingtimestamp_Faxes|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: Cascade<br />Share: Cascade<br />Unshare: Cascade|


### <a name="BKMK_msdyn_bookingtimestamp_Letters"></a> msdyn_bookingtimestamp_Letters

Same as letter entity [msdyn_bookingtimestamp_Letters](letter.md#BKMK_msdyn_bookingtimestamp_Letters) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|letter|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_bookingtimestamp_Letters|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: Cascade<br />Share: Cascade<br />Unshare: Cascade|


### <a name="BKMK_msdyn_bookingtimestamp_PhoneCalls"></a> msdyn_bookingtimestamp_PhoneCalls

Same as phonecall entity [msdyn_bookingtimestamp_PhoneCalls](phonecall.md#BKMK_msdyn_bookingtimestamp_PhoneCalls) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|phonecall|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_bookingtimestamp_PhoneCalls|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: Cascade<br />Share: Cascade<br />Unshare: Cascade|


### <a name="BKMK_msdyn_bookingtimestamp_Tasks"></a> msdyn_bookingtimestamp_Tasks

Same as task entity [msdyn_bookingtimestamp_Tasks](task.md#BKMK_msdyn_bookingtimestamp_Tasks) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|task|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_bookingtimestamp_Tasks|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: Cascade<br />Share: Cascade<br />Unshare: Cascade|


### <a name="BKMK_msdyn_bookingtimestamp_RecurringAppointmentMasters"></a> msdyn_bookingtimestamp_RecurringAppointmentMasters

Same as recurringappointmentmaster entity [msdyn_bookingtimestamp_RecurringAppointmentMasters](recurringappointmentmaster.md#BKMK_msdyn_bookingtimestamp_RecurringAppointmentMasters) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|recurringappointmentmaster|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_bookingtimestamp_RecurringAppointmentMasters|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: Cascade<br />Share: Cascade<br />Unshare: Cascade|


### <a name="BKMK_msdyn_bookingtimestamp_SocialActivities"></a> msdyn_bookingtimestamp_SocialActivities

Same as socialactivity entity [msdyn_bookingtimestamp_SocialActivities](socialactivity.md#BKMK_msdyn_bookingtimestamp_SocialActivities) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|socialactivity|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_bookingtimestamp_SocialActivities|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: Cascade<br />Share: Cascade<br />Unshare: Cascade|


### <a name="BKMK_msdyn_bookingtimestamp_connections1"></a> msdyn_bookingtimestamp_connections1

Same as connection entity [msdyn_bookingtimestamp_connections1](connection.md#BKMK_msdyn_bookingtimestamp_connections1) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|connection|
|ReferencingAttribute|record1id|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_bookingtimestamp_connections1|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Details<br />Label: <br />Order: 100|
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_bookingtimestamp_connections2"></a> msdyn_bookingtimestamp_connections2

Same as connection entity [msdyn_bookingtimestamp_connections2](connection.md#BKMK_msdyn_bookingtimestamp_connections2) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|connection|
|ReferencingAttribute|record2id|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_bookingtimestamp_connections2|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_bookingtimestamp_Annotations"></a> msdyn_bookingtimestamp_Annotations

Same as annotation entity [msdyn_bookingtimestamp_Annotations](annotation.md#BKMK_msdyn_bookingtimestamp_Annotations) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|annotation|
|ReferencingAttribute|objectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_bookingtimestamp_Annotations|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: Cascade<br />Share: Cascade<br />Unshare: Cascade|


### <a name="BKMK_msdyn_bookingtimestamp_ServiceAppointments"></a> msdyn_bookingtimestamp_ServiceAppointments

Same as serviceappointment entity [msdyn_bookingtimestamp_ServiceAppointments](serviceappointment.md#BKMK_msdyn_bookingtimestamp_ServiceAppointments) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|serviceappointment|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_bookingtimestamp_ServiceAppointments|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: Cascade<br />Share: Cascade<br />Unshare: Cascade|

<a name="manytoone"></a>

## Many-To-One Relationships

Each Many-To-One relationship is defined by a corresponding One-To-Many relationship with the related entity. Listed by **SchemaName**.

- [lk_msdyn_bookingtimestamp_createdby](#BKMK_lk_msdyn_bookingtimestamp_createdby)
- [lk_msdyn_bookingtimestamp_createdonbehalfby](#BKMK_lk_msdyn_bookingtimestamp_createdonbehalfby)
- [lk_msdyn_bookingtimestamp_modifiedby](#BKMK_lk_msdyn_bookingtimestamp_modifiedby)
- [lk_msdyn_bookingtimestamp_modifiedonbehalfby](#BKMK_lk_msdyn_bookingtimestamp_modifiedonbehalfby)
- [user_msdyn_bookingtimestamp](#BKMK_user_msdyn_bookingtimestamp)
- [team_msdyn_bookingtimestamp](#BKMK_team_msdyn_bookingtimestamp)
- [business_unit_msdyn_bookingtimestamp](#BKMK_business_unit_msdyn_bookingtimestamp)
- [msdyn_bookableresourcebooking_msdyn_bookingtimestamp_Booking](#BKMK_msdyn_bookableresourcebooking_msdyn_bookingtimestamp_Booking)


### <a name="BKMK_lk_msdyn_bookingtimestamp_createdby"></a> lk_msdyn_bookingtimestamp_createdby

See systemuser Entity [lk_msdyn_bookingtimestamp_createdby](systemuser.md#BKMK_lk_msdyn_bookingtimestamp_createdby) One-To-Many relationship.

### <a name="BKMK_lk_msdyn_bookingtimestamp_createdonbehalfby"></a> lk_msdyn_bookingtimestamp_createdonbehalfby

See systemuser Entity [lk_msdyn_bookingtimestamp_createdonbehalfby](systemuser.md#BKMK_lk_msdyn_bookingtimestamp_createdonbehalfby) One-To-Many relationship.

### <a name="BKMK_lk_msdyn_bookingtimestamp_modifiedby"></a> lk_msdyn_bookingtimestamp_modifiedby

See systemuser Entity [lk_msdyn_bookingtimestamp_modifiedby](systemuser.md#BKMK_lk_msdyn_bookingtimestamp_modifiedby) One-To-Many relationship.

### <a name="BKMK_lk_msdyn_bookingtimestamp_modifiedonbehalfby"></a> lk_msdyn_bookingtimestamp_modifiedonbehalfby

See systemuser Entity [lk_msdyn_bookingtimestamp_modifiedonbehalfby](systemuser.md#BKMK_lk_msdyn_bookingtimestamp_modifiedonbehalfby) One-To-Many relationship.

### <a name="BKMK_user_msdyn_bookingtimestamp"></a> user_msdyn_bookingtimestamp

See systemuser Entity [user_msdyn_bookingtimestamp](systemuser.md#BKMK_user_msdyn_bookingtimestamp) One-To-Many relationship.

### <a name="BKMK_team_msdyn_bookingtimestamp"></a> team_msdyn_bookingtimestamp

See team Entity [team_msdyn_bookingtimestamp](team.md#BKMK_team_msdyn_bookingtimestamp) One-To-Many relationship.

### <a name="BKMK_business_unit_msdyn_bookingtimestamp"></a> business_unit_msdyn_bookingtimestamp

See businessunit Entity [business_unit_msdyn_bookingtimestamp](businessunit.md#BKMK_business_unit_msdyn_bookingtimestamp) One-To-Many relationship.

### <a name="BKMK_msdyn_bookableresourcebooking_msdyn_bookingtimestamp_Booking"></a> msdyn_bookableresourcebooking_msdyn_bookingtimestamp_Booking

See bookableresourcebooking Entity [msdyn_bookableresourcebooking_msdyn_bookingtimestamp_Booking](bookableresourcebooking.md#BKMK_msdyn_bookableresourcebooking_msdyn_bookingtimestamp_Booking) One-To-Many relationship.

### See also

[About the Entity Reference](../about-entity-reference.md)<br />
[Programming reference for Dynamics 365 Customer Engagement](../programming-reference.md)<br />
[Web API Reference](/dynamics365/customer-engagement/web-api/about)<br />
<xref href="Microsoft.Dynamics.CRM.msdyn_bookingtimestamp?text=msdyn_bookingtimestamp EntityType" />