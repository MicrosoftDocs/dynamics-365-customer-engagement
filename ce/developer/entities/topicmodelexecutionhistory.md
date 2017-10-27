---
title: "TopicModelExecutionHistory Entity Reference (Developer Guide for Dynamics 365 Customer Engagement)| MicrosoftDocs"
description: "Includes schema information and supported messages for the TopicModelExecutionHistory entity."
ms.date: 10/31/2017
ms.service: "crm-online"
ms.topic: "reference"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: 3948cc48-07c8-7f60-0608-71c37158ad7c
author: "JimDaly"
ms.author: "jdaly"
manager: "jdaly"
---
# TopicModelExecutionHistory Entity Reference

Entity for Topic Model Execution History

**Added by**: Service Solution<br />

## Messages

|Message|Web API Operation|SDK Assembly|
|-|-|-|
|Create|POST [*org URI*]/api/data/v9.0/topicmodelexecutionhistories<br />See [Create](../webapi/create-entity-web-api.md)|<xref:Microsoft.Xrm.Sdk.Messages.CreateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Create*>|
|Delete|DELETE [*org URI*]/api/data/v9.0/topicmodelexecutionhistories(*topicmodelexecutionhistoryid*)<br />See [Delete](../webapi/update-delete-entities-using-web-api.md#basic-delete)|<xref:Microsoft.Xrm.Sdk.Messages.DeleteRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Delete*>|
|Retrieve|GET [*org URI*]/api/data/v9.0/topicmodelexecutionhistories(*topicmodelexecutionhistoryid*)<br />See [Retrieve](../webapi/retrieve-entity-using-web-api.md)|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Retrieve*>|
|RetrieveMultiple|GET [*org URI*]/api/data/v9.0/topicmodelexecutionhistories<br />See [Query Data](../webapi/query-data-web-api.md)|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveMultipleRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.RetrieveMultiple*>|
|Update|PATCH [*org URI*]/api/data/v9.0/topicmodelexecutionhistories(*topicmodelexecutionhistoryid*)<br />See [Update](../webapi/update-delete-entities-using-web-api.md#basic-update)|<xref:Microsoft.Xrm.Sdk.Messages.UpdateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Update*>|

## Properties

**DisplayName**: Topic Model Execution History<br />
**DisplayCollectionName**: Topic Model Execution Histories<br />
**SchemaName**: TopicModelExecutionHistory<br />
**CollectionSchemaName**: TopicModelExecutionHistories<br />
**LogicalName**: topicmodelexecutionhistory<br />
**LogicalCollectionName**: topicmodelexecutionhistories<br />
**EntitySetName**: topicmodelexecutionhistories<br />
**PrimaryIdAttribute**: topicmodelexecutionhistoryid<br />
**PrimaryNameAttribute**: name<br />
**OwnershipType**: OrganizationOwned<br />
**IsBPFEntity**: False<br />
<a name="writable-attributes"></a>

## Writable attributes

These attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [ErrorDetails](#BKMK_ErrorDetails)
- [FetchXmlList](#BKMK_FetchXmlList)
- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [IsTestExecution](#BKMK_IsTestExecution)
- [MaxTopics](#BKMK_MaxTopics)
- [Name](#BKMK_Name)
- [NumberOfTopicsFound](#BKMK_NumberOfTopicsFound)
- [OverriddenCreatedOn](#BKMK_OverriddenCreatedOn)
- [RecordCorrelationId](#BKMK_RecordCorrelationId)
- [RecordsProcessed](#BKMK_RecordsProcessed)
- [StartTime](#BKMK_StartTime)
- [Status](#BKMK_Status)
- [StatusReason](#BKMK_StatusReason)
- [TimeZoneRuleVersionNumber](#BKMK_TimeZoneRuleVersionNumber)
- [TopicModelConfigurationId](#BKMK_TopicModelConfigurationId)
- [TopicModelExecutionHistoryId](#BKMK_TopicModelExecutionHistoryId)
- [TopicModelId](#BKMK_TopicModelId)
- [TotalTime](#BKMK_TotalTime)
- [UTCConversionTimeZoneCode](#BKMK_UTCConversionTimeZoneCode)


### <a name="BKMK_ErrorDetails"></a> ErrorDetails

**Description**: Detailed error message for the Topic Analysis process<br />
**DisplayName**: Error Details<br />
**LogicalName**: azuresyncerrormessage<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Memo<br />
**Format**: TextArea<br />
**IsLocalizable**: False<br />
**MaxLength**: 1073741823


### <a name="BKMK_FetchXmlList"></a> FetchXmlList

**Description**: Fetch Xml<br />
**DisplayName**: Fetch Xml<br />
**LogicalName**: fetchxmllist<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Memo<br />
**Format**: TextArea<br />
**IsLocalizable**: False<br />
**MaxLength**: 500000


### <a name="BKMK_ImportSequenceNumber"></a> ImportSequenceNumber

**Description**: Sequence number of the import that created this record.<br />
**DisplayName**: Import Sequence Number<br />
**LogicalName**: importsequencenumber<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**IsValidForUpdate**: False<br />
**Type**: Integer<br />
**Format**: None<br />
**MaxValue**: 2147483647<br />
**MinValue**: -2147483648


### <a name="BKMK_IsTestExecution"></a> IsTestExecution

**Description**: Allow model to check is test executed.<br />
**DisplayName**: Test Execution<br />
**LogicalName**: istestexecution<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Boolean<br />
**Options**:

- **TrueOption Value**: 1 **Label**: Yes
- **FalseOption Value**: 0 **Label**: No

**DefaultValue**: False


### <a name="BKMK_MaxTopics"></a> MaxTopics

**Description**: Maximum number of Topics.<br />
**DisplayName**: Max Topics<br />
**LogicalName**: maxtopics<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: ApplicationRequired<br />
**Type**: Integer<br />
**Format**: None<br />
**MaxValue**: 1000<br />
**MinValue**: 0


### <a name="BKMK_Name"></a> Name

**Description**: name<br />
**DisplayName**: name<br />
**LogicalName**: name<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: ApplicationRequired<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_NumberOfTopicsFound"></a> NumberOfTopicsFound

**Description**: Number of Topics Identified<br />
**DisplayName**: Number of Topics Identified<br />
**LogicalName**: numberoftopicsfound<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Integer<br />
**Format**: None<br />
**MaxValue**: 2147483647<br />
**MinValue**: 0


### <a name="BKMK_OverriddenCreatedOn"></a> OverriddenCreatedOn

**Description**: Date and time that the record was migrated.<br />
**DisplayName**: Record Created On<br />
**LogicalName**: overriddencreatedon<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**IsValidForUpdate**: False<br />
**Type**: DateTime<br />
**DateTimeBehavior**: UserLocal<br />
**Format**: DateOnly


### <a name="BKMK_RecordCorrelationId"></a> RecordCorrelationId

**Description**: Record Correlation Id.<br />
**DisplayName**: Record Correlation Id<br />
**LogicalName**: recordcorrelationid<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_RecordsProcessed"></a> RecordsProcessed

**Description**: Number of Records Synchronized<br />
**DisplayName**: Number of Records Synchronized<br />
**LogicalName**: recordsprocessed<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Integer<br />
**Format**: None<br />
**MaxValue**: 2147483647<br />
**MinValue**: 0


### <a name="BKMK_StartTime"></a> StartTime

**Description**: StartTime<br />
**DisplayName**: Start Time<br />
**LogicalName**: starttime<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: DateTime<br />
**DateTimeBehavior**: UserLocal<br />
**Format**: DateAndTime


### <a name="BKMK_Status"></a> Status

**Description**: Status<br />
**DisplayName**: Status<br />
**LogicalName**: status<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Picklist<br />
**Options**:

- **Value**: 1 **Label**: Queued
- **Value**: 2 **Label**: In progress
- **Value**: 3 **Label**: Success
- **Value**: 4 **Label**: Failed



### <a name="BKMK_StatusReason"></a> StatusReason

**Description**: StatusReason<br />
**DisplayName**: Status Reason<br />
**LogicalName**: statusreason<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Picklist<br />
**Options**:

- **Value**: 1 **Label**: Topic analysis execution is queued
- **Value**: 2 **Label**: Topic analysis execution is synchronizing
- **Value**: 3 **Label**: Analyzing topic analysis execution
- **Value**: 4 **Label**: Topic analysis has built
- **Value**: 5 **Label**: Synchronization failed
- **Value**: 6 **Label**: Analysis failed
- **Value**: 7 **Label**: Connection failed



### <a name="BKMK_TimeZoneRuleVersionNumber"></a> TimeZoneRuleVersionNumber

**Description**: For internal use only.<br />
**DisplayName**: Time Zone Rule Version Number<br />
**LogicalName**: timezoneruleversionnumber<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Integer<br />
**Format**: None<br />
**MaxValue**: 2147483647<br />
**MinValue**: -1


### <a name="BKMK_TopicModelConfigurationId"></a> TopicModelConfigurationId

**Description**: Unique identifier for Model associated with Topic Model Execution History.<br />
**DisplayName**: Topic Model Configuration<br />
**LogicalName**: topicmodelconfigurationid<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: ApplicationRequired<br />
**IsValidForUpdate**: False<br />
**Type**: Lookup<br />
**Targets**: topicmodelconfiguration


### <a name="BKMK_TopicModelExecutionHistoryId"></a> TopicModelExecutionHistoryId

**Description**: Unique identifier for entity instances<br />
**DisplayName**: TopicModelExecutionHistory<br />
**LogicalName**: topicmodelexecutionhistoryid<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: SystemRequired<br />
**IsValidForUpdate**: False<br />
**Type**: Uniqueidentifier<br />


### <a name="BKMK_TopicModelId"></a> TopicModelId

**Description**: Unique identifier for Model associated with Topic Model Execution History.<br />
**DisplayName**: TopicModelId<br />
**LogicalName**: topicmodelid<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: ApplicationRequired<br />
**IsValidForUpdate**: False<br />
**Type**: Lookup<br />
**Targets**: topicmodel


### <a name="BKMK_TotalTime"></a> TotalTime

**Description**: Duration (in mins)<br />
**DisplayName**: Duration (in mins)<br />
**LogicalName**: totaltime<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Integer<br />
**Format**: Duration<br />
**MaxValue**: 2147483647<br />
**MinValue**: 0


### <a name="BKMK_UTCConversionTimeZoneCode"></a> UTCConversionTimeZoneCode

**Description**: Time zone code that was in use when the record was created.<br />
**DisplayName**: UTC Conversion Time Zone Code<br />
**LogicalName**: utcconversiontimezonecode<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Integer<br />
**Format**: None<br />
**MaxValue**: 2147483647<br />
**MinValue**: -1

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
- [OrganizationId](#BKMK_OrganizationId)
- [OrganizationIdName](#BKMK_OrganizationIdName)
- [TopicModelConfigurationIdName](#BKMK_TopicModelConfigurationIdName)
- [TopicModelIdName](#BKMK_TopicModelIdName)
- [VersionNumber](#BKMK_VersionNumber)


### <a name="BKMK_CreatedBy"></a> CreatedBy

**Description**: Unique identifier of the user who created the topic model execution history.<br />
**DisplayName**: Created By<br />
**LogicalName**: createdby<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: systemuser


### <a name="BKMK_CreatedByName"></a> CreatedByName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: createdbyname<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_CreatedByYomiName"></a> CreatedByYomiName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: createdbyyominame<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: SystemRequired<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_CreatedOn"></a> CreatedOn

**Description**: Date and time when the record was created.<br />
**DisplayName**: Created On<br />
**LogicalName**: createdon<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: DateTime<br />
**DateTimeBehavior**: UserLocal<br />
**Format**: DateOnly


### <a name="BKMK_CreatedOnBehalfBy"></a> CreatedOnBehalfBy

**Description**: Unique identifier of the delegate user who created the topic model execution history.<br />
**DisplayName**: Created By (Delegate)<br />
**LogicalName**: createdonbehalfby<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: systemuser


### <a name="BKMK_CreatedOnBehalfByName"></a> CreatedOnBehalfByName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: createdonbehalfbyname<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_CreatedOnBehalfByYomiName"></a> CreatedOnBehalfByYomiName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: createdonbehalfbyyominame<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_ModifiedBy"></a> ModifiedBy

**Description**: Unique identifier of the user who modified the topic model execution history.<br />
**DisplayName**: Modified By<br />
**LogicalName**: modifiedby<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: systemuser


### <a name="BKMK_ModifiedByName"></a> ModifiedByName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: modifiedbyname<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_ModifiedByYomiName"></a> ModifiedByYomiName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: modifiedbyyominame<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: SystemRequired<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_ModifiedOn"></a> ModifiedOn

**Description**: Date and time when the record was modified.<br />
**DisplayName**: Modified On<br />
**LogicalName**: modifiedon<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: DateTime<br />
**DateTimeBehavior**: UserLocal<br />
**Format**: DateOnly


### <a name="BKMK_ModifiedOnBehalfBy"></a> ModifiedOnBehalfBy

**Description**: Unique identifier of the delegate user who last modified the topic model execution history.<br />
**DisplayName**: Modified By (Delegate)<br />
**LogicalName**: modifiedonbehalfby<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: systemuser


### <a name="BKMK_ModifiedOnBehalfByName"></a> ModifiedOnBehalfByName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: modifiedonbehalfbyname<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_ModifiedOnBehalfByYomiName"></a> ModifiedOnBehalfByYomiName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: modifiedonbehalfbyyominame<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_OrganizationId"></a> OrganizationId

**Description**: Unique identifier for the organization<br />
**DisplayName**: Organization Id<br />
**LogicalName**: organizationid<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: SystemRequired<br />
**Type**: Lookup<br />
**Targets**: organization


### <a name="BKMK_OrganizationIdName"></a> OrganizationIdName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: organizationidname<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: SystemRequired<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_TopicModelConfigurationIdName"></a> TopicModelConfigurationIdName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: topicmodelconfigurationidname<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: ApplicationRequired<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_TopicModelIdName"></a> TopicModelIdName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: topicmodelidname<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: ApplicationRequired<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_VersionNumber"></a> VersionNumber

**Description**: Version Number<br />
**DisplayName**: Version Number<br />
**LogicalName**: versionnumber<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: BigInt<br />
**MaxValue**: 9223372036854775807<br />
**MinValue**: -9223372036854775808<br />

<a name="onetomany"></a>

## One-To-Many Relationships

Listed by **SchemaName**.

- [topicmodelexecutionhistory_SyncErrors](#BKMK_topicmodelexecutionhistory_SyncErrors)
- [topicmodelexecutionhistory_AsyncOperations](#BKMK_topicmodelexecutionhistory_AsyncOperations)
- [topicmodelexecutionhistory_MailboxTrackingFolders](#BKMK_topicmodelexecutionhistory_MailboxTrackingFolders)
- [topicmodelexecutionhistory_UserEntityInstanceDatas](#BKMK_topicmodelexecutionhistory_UserEntityInstanceDatas)
- [topicmodelexecutionhistory_BulkDeleteFailures](#BKMK_topicmodelexecutionhistory_BulkDeleteFailures)
- [topicmodelexecutionhistory_PrincipalObjectAttributeAccesses](#BKMK_topicmodelexecutionhistory_PrincipalObjectAttributeAccesses)
- [topicmodelexecutionhistory_topichistory](#BKMK_topicmodelexecutionhistory_topichistory)


### <a name="BKMK_topicmodelexecutionhistory_SyncErrors"></a> topicmodelexecutionhistory_SyncErrors

Same as syncerror entity [topicmodelexecutionhistory_SyncErrors](syncerror.md#BKMK_topicmodelexecutionhistory_SyncErrors) Many-To-One relationship.

**ReferencingEntity**: syncerror<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: topicmodelexecutionhistory_SyncErrors<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: Cascade
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_topicmodelexecutionhistory_AsyncOperations"></a> topicmodelexecutionhistory_AsyncOperations

Same as asyncoperation entity [topicmodelexecutionhistory_AsyncOperations](asyncoperation.md#BKMK_topicmodelexecutionhistory_AsyncOperations) Many-To-One relationship.

**ReferencingEntity**: asyncoperation<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: topicmodelexecutionhistory_AsyncOperations<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: NoCascade
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_topicmodelexecutionhistory_MailboxTrackingFolders"></a> topicmodelexecutionhistory_MailboxTrackingFolders

Same as mailboxtrackingfolder entity [topicmodelexecutionhistory_MailboxTrackingFolders](mailboxtrackingfolder.md#BKMK_topicmodelexecutionhistory_MailboxTrackingFolders) Many-To-One relationship.

**ReferencingEntity**: mailboxtrackingfolder<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: topicmodelexecutionhistory_MailboxTrackingFolders<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: Cascade
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_topicmodelexecutionhistory_UserEntityInstanceDatas"></a> topicmodelexecutionhistory_UserEntityInstanceDatas

Same as userentityinstancedata entity [topicmodelexecutionhistory_UserEntityInstanceDatas](userentityinstancedata.md#BKMK_topicmodelexecutionhistory_UserEntityInstanceDatas) Many-To-One relationship.

**ReferencingEntity**: userentityinstancedata<br />
**ReferencingAttribute**: objectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: topicmodelexecutionhistory_UserEntityInstanceDatas<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: Cascade
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_topicmodelexecutionhistory_BulkDeleteFailures"></a> topicmodelexecutionhistory_BulkDeleteFailures

Same as bulkdeletefailure entity [topicmodelexecutionhistory_BulkDeleteFailures](bulkdeletefailure.md#BKMK_topicmodelexecutionhistory_BulkDeleteFailures) Many-To-One relationship.

**ReferencingEntity**: bulkdeletefailure<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: topicmodelexecutionhistory_BulkDeleteFailures<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: Cascade
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_topicmodelexecutionhistory_PrincipalObjectAttributeAccesses"></a> topicmodelexecutionhistory_PrincipalObjectAttributeAccesses

Same as principalobjectattributeaccess entity [topicmodelexecutionhistory_PrincipalObjectAttributeAccesses](principalobjectattributeaccess.md#BKMK_topicmodelexecutionhistory_PrincipalObjectAttributeAccesses) Many-To-One relationship.

**ReferencingEntity**: principalobjectattributeaccess<br />
**ReferencingAttribute**: objectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: topicmodelexecutionhistory_PrincipalObjectAttributeAccesses<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: Cascade
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_topicmodelexecutionhistory_topichistory"></a> topicmodelexecutionhistory_topichistory

Same as topichistory entity [topicmodelexecutionhistory_topichistory](topichistory.md#BKMK_topicmodelexecutionhistory_topichistory) Many-To-One relationship.

**ReferencingEntity**: topichistory<br />
**ReferencingAttribute**: topicmodelexecutionhistoryid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: topicmodelexecutionhistory_topichistory<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: RemoveLink
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade

<a name="manytoone"></a>

## Many-To-One Relationships

Each Many-To-One relationship is defined by a corresponding One-To-Many relationship with the related entity. Listed by **SchemaName**.

- [lk_topicmodelexecutionhistory_createdby](#BKMK_lk_topicmodelexecutionhistory_createdby)
- [lk_topicmodelexecutionhistory_createdonbehalfby](#BKMK_lk_topicmodelexecutionhistory_createdonbehalfby)
- [lk_topicmodelexecutionhistory_modifiedby](#BKMK_lk_topicmodelexecutionhistory_modifiedby)
- [lk_topicmodelexecutionhistory_modifiedonbehalfby](#BKMK_lk_topicmodelexecutionhistory_modifiedonbehalfby)
- [organization_topicmodelexecutionhistory](#BKMK_organization_topicmodelexecutionhistory)
- [topicmodel_topicmodelexecutionhistory](#BKMK_topicmodel_topicmodelexecutionhistory)
- [topicmodelconfiguration_topicmodelexecutionhistory](#BKMK_topicmodelconfiguration_topicmodelexecutionhistory)


### <a name="BKMK_lk_topicmodelexecutionhistory_createdby"></a> lk_topicmodelexecutionhistory_createdby

See systemuser Entity [lk_topicmodelexecutionhistory_createdby](systemuser.md#BKMK_lk_topicmodelexecutionhistory_createdby) One-To-Many relationship.

### <a name="BKMK_lk_topicmodelexecutionhistory_createdonbehalfby"></a> lk_topicmodelexecutionhistory_createdonbehalfby

See systemuser Entity [lk_topicmodelexecutionhistory_createdonbehalfby](systemuser.md#BKMK_lk_topicmodelexecutionhistory_createdonbehalfby) One-To-Many relationship.

### <a name="BKMK_lk_topicmodelexecutionhistory_modifiedby"></a> lk_topicmodelexecutionhistory_modifiedby

See systemuser Entity [lk_topicmodelexecutionhistory_modifiedby](systemuser.md#BKMK_lk_topicmodelexecutionhistory_modifiedby) One-To-Many relationship.

### <a name="BKMK_lk_topicmodelexecutionhistory_modifiedonbehalfby"></a> lk_topicmodelexecutionhistory_modifiedonbehalfby

See systemuser Entity [lk_topicmodelexecutionhistory_modifiedonbehalfby](systemuser.md#BKMK_lk_topicmodelexecutionhistory_modifiedonbehalfby) One-To-Many relationship.

### <a name="BKMK_organization_topicmodelexecutionhistory"></a> organization_topicmodelexecutionhistory

See organization Entity [organization_topicmodelexecutionhistory](organization.md#BKMK_organization_topicmodelexecutionhistory) One-To-Many relationship.

### <a name="BKMK_topicmodel_topicmodelexecutionhistory"></a> topicmodel_topicmodelexecutionhistory

See topicmodel Entity [topicmodel_topicmodelexecutionhistory](topicmodel.md#BKMK_topicmodel_topicmodelexecutionhistory) One-To-Many relationship.

### <a name="BKMK_topicmodelconfiguration_topicmodelexecutionhistory"></a> topicmodelconfiguration_topicmodelexecutionhistory

See topicmodelconfiguration Entity [topicmodelconfiguration_topicmodelexecutionhistory](topicmodelconfiguration.md#BKMK_topicmodelconfiguration_topicmodelexecutionhistory) One-To-Many relationship.

## See also

[About the Entity Reference](../about-entity-reference.md)<br />
[Programming reference for Dynamics 365 Customer Engagement](../programming-reference.md)<br />
[Web API Reference](/dynamics365/customer-engagement/web-api/about)<br />
<xref href="Microsoft.Dynamics.CRM.topicmodelexecutionhistory?text=topicmodelexecutionhistory EntityType" />