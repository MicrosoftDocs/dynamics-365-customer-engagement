---
title: "TopicModel Entity Reference (Developer Guide for Dynamics 365 Customer Engagement)| MicrosoftDocs"
description: "Includes schema information and supported messages for the TopicModel entity."
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
# TopicModel Entity Reference

The model for automatic identification of topics using text analytics.

**Added by**: Service Solution<br />

## Messages

|Message|Web API Operation|SDK Assembly|
|-|-|-|
|Create|POST [*org URI*]/api/data/v9.0/topicmodels<br />See [Create](../webapi/create-entity-web-api.md)|<xref:Microsoft.Xrm.Sdk.Messages.CreateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Create*>|
|Delete|DELETE [*org URI*]/api/data/v9.0/topicmodels(*topicmodelid*)<br />See [Delete](../webapi/update-delete-entities-using-web-api.md#basic-delete)|<xref:Microsoft.Xrm.Sdk.Messages.DeleteRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Delete*>|
|Retrieve|GET [*org URI*]/api/data/v9.0/topicmodels(*topicmodelid*)<br />See [Retrieve](../webapi/retrieve-entity-using-web-api.md)|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Retrieve*>|
|RetrieveMultiple|GET [*org URI*]/api/data/v9.0/topicmodels<br />See [Query Data](../webapi/query-data-web-api.md)|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveMultipleRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.RetrieveMultiple*>|
|SetState|PATCH [*org URI*]/api/data/v9.0/topicmodels(*topicmodelid*)<br />[Update](../webapi/update-delete-entities-using-web-api.md#basic-update) `statecode` and `statuscode` properties.|<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|
|Update|PATCH [*org URI*]/api/data/v9.0/topicmodels(*topicmodelid*)<br />See [Update](../webapi/update-delete-entities-using-web-api.md#basic-update)|<xref:Microsoft.Xrm.Sdk.Messages.UpdateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Update*>|

## Properties

**DisplayName**: Topic Model<br />
**DisplayCollectionName**: Topic Model<br />
**SchemaName**: TopicModel<br />
**CollectionSchemaName**: TopicModels<br />
**LogicalName**: topicmodel<br />
**LogicalCollectionName**: topicmodels<br />
**EntitySetName**: topicmodels<br />
**PrimaryIdAttribute**: topicmodelid<br />
**PrimaryNameAttribute**: name<br />
**OwnershipType**: OrganizationOwned<br />
**IsBPFEntity**: False<br />
<a name="writable-attributes"></a>

## Writable attributes

These attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [AvgNumberofTopics](#BKMK_AvgNumberofTopics)
- [AzureSchedulerJobName](#BKMK_AzureSchedulerJobName)
- [AzureSchedulerOnDemandJobName](#BKMK_AzureSchedulerOnDemandJobName)
- [AzureSchedulerTestJobName](#BKMK_AzureSchedulerTestJobName)
- [AzureServiceConnectionId](#BKMK_AzureServiceConnectionId)
- [BuildRecurrence](#BKMK_BuildRecurrence)
- [ConfigurationUsed](#BKMK_ConfigurationUsed)
- [Description](#BKMK_Description)
- [EndTime](#BKMK_EndTime)
- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [MaxNumberofTopics](#BKMK_MaxNumberofTopics)
- [MaxTopics](#BKMK_MaxTopics)
- [Name](#BKMK_Name)
- [OverriddenCreatedOn](#BKMK_OverriddenCreatedOn)
- [SourceEntity](#BKMK_SourceEntity)
- [StartTime](#BKMK_StartTime)
- [StateCode](#BKMK_StateCode)
- [StatusCode](#BKMK_StatusCode)
- [TimeZoneRuleVersionNumber](#BKMK_TimeZoneRuleVersionNumber)
- [TopicModelId](#BKMK_TopicModelId)
- [TopicsLastCreatedOn](#BKMK_TopicsLastCreatedOn)
- [TotalTopicsFound](#BKMK_TotalTopicsFound)
- [UTCConversionTimeZoneCode](#BKMK_UTCConversionTimeZoneCode)


### <a name="BKMK_AvgNumberofTopics"></a> AvgNumberofTopics

**Description**: Shows the average number of topics found per build.<br />
**DisplayName**: Average Number of Topics per Build<br />
**LogicalName**: avgnumberoftopics<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Integer<br />
**Format**: None<br />
**MaxValue**: 1000<br />
**MinValue**: 0


### <a name="BKMK_AzureSchedulerJobName"></a> AzureSchedulerJobName

**Description**: Azure Scheduler Job Name.<br />
**DisplayName**: AzureSchedulerJobName<br />
**LogicalName**: azureschedulerjobname<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_AzureSchedulerOnDemandJobName"></a> AzureSchedulerOnDemandJobName

**Description**: Azure Scheduler Job Name for build model<br />
**DisplayName**: Scheduler Build Job<br />
**LogicalName**: azureschedulerondemandjobname<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_AzureSchedulerTestJobName"></a> AzureSchedulerTestJobName

**Description**: Azure Scheduler Job Name for test model<br />
**DisplayName**: Scheduler Test Job<br />
**LogicalName**: azureschedulertestjobname<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_AzureServiceConnectionId"></a> AzureServiceConnectionId

**Description**: Unique identifier for AzureServiceConnection associated with TopicModel.<br />
**DisplayName**: Connection<br />
**LogicalName**: azureserviceconnectionid<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: ApplicationRequired<br />
**Type**: Lookup<br />
**Targets**: azureserviceconnection


### <a name="BKMK_BuildRecurrence"></a> BuildRecurrence

**Description**: Shows how frequently topic analysis is done.<br />
**DisplayName**: Build Recurrence<br />
**LogicalName**: buildrecurrence<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_ConfigurationUsed"></a> ConfigurationUsed

**Description**: Shows the configuration used for topic analysis.<br />
**DisplayName**: Configuration<br />
**LogicalName**: configurationused<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**IsValidForCreate**: False<br />
**Type**: Lookup<br />
**Targets**: topicmodelconfiguration


### <a name="BKMK_Description"></a> Description

**Description**: Enter a description for the model.<br />
**DisplayName**: Description<br />
**LogicalName**: description<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Memo<br />
**Format**: TextArea<br />
**IsLocalizable**: False<br />
**MaxLength**: 2000


### <a name="BKMK_EndTime"></a> EndTime

**Description**: Shows the time when topic analysis will stop<br />
**DisplayName**: End Time<br />
**LogicalName**: endtime<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: DateTime<br />
**DateTimeBehavior**: UserLocal<br />
**Format**: DateAndTime


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


### <a name="BKMK_MaxNumberofTopics"></a> MaxNumberofTopics

**Description**: Shows the maximum number of topics found across builds.<br />
**DisplayName**: Maximum Topics Found Across Builds<br />
**LogicalName**: maxnumberoftopics<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Integer<br />
**Format**: None<br />
**MaxValue**: 1000<br />
**MinValue**: 0


### <a name="BKMK_MaxTopics"></a> MaxTopics

**Description**: Shows the maximum number of topics to be determined.<br />
**DisplayName**: Maximum Topics<br />
**LogicalName**: maxtopics<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: ApplicationRequired<br />
**Type**: Integer<br />
**Format**: None<br />
**MaxValue**: 1000<br />
**MinValue**: 0


### <a name="BKMK_Name"></a> Name

**Description**: Shows the name of the topic model.<br />
**DisplayName**: Name<br />
**LogicalName**: name<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: ApplicationRequired<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 160


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


### <a name="BKMK_SourceEntity"></a> SourceEntity

**Description**: Shows the entity whose records are used for topic analysis.<br />
**DisplayName**: Source Entity<br />
**LogicalName**: sourceentity<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: ApplicationRequired<br />
**IsValidForUpdate**: False<br />
**Type**: EntityName<br />


### <a name="BKMK_StartTime"></a> StartTime

**Description**: Shows the time when topic analysis will start according to the recurrence schedule.<br />
**DisplayName**: Start Time<br />
**LogicalName**: starttime<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: DateTime<br />
**DateTimeBehavior**: UserLocal<br />
**Format**: DateAndTime


### <a name="BKMK_StateCode"></a> StateCode

**Description**: Shows the status of the topic model build<br />
**DisplayName**: Status<br />
**LogicalName**: statecode<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: SystemRequired<br />
**Type**: State<br />
**Options**:

- **Value**: 0 **Label**: Active **DefaultStatus**: 1 **InvariantName**: Active
- **Value**: 1 **Label**: Inactive **DefaultStatus**: 2 **InvariantName**: Inactive



### <a name="BKMK_StatusCode"></a> StatusCode

**Description**: Reason for the status of the TopicModel<br />
**DisplayName**: Status Reason<br />
**LogicalName**: statuscode<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Status<br />
**Options**:

- **Value**: 1 **Label**: Active **State**: 0
- **Value**: 2 **Label**: Inactive **State**: 1



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


### <a name="BKMK_TopicModelId"></a> TopicModelId

**Description**: Unique identifier for entity instances<br />
**DisplayName**: TopicModel<br />
**LogicalName**: topicmodelid<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: SystemRequired<br />
**IsValidForUpdate**: False<br />
**Type**: Uniqueidentifier<br />


### <a name="BKMK_TopicsLastCreatedOn"></a> TopicsLastCreatedOn

**Description**: Shows when the topics were last created.<br />
**DisplayName**: Topics Last Created On<br />
**LogicalName**: topicslastcreatedon<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: DateTime<br />
**DateTimeBehavior**: UserLocal<br />
**Format**: DateAndTime


### <a name="BKMK_TotalTopicsFound"></a> TotalTopicsFound

**Description**: Shows the total number of topics found.<br />
**DisplayName**: Total Topics Found<br />
**LogicalName**: totaltopicsfound<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Integer<br />
**Format**: None<br />
**MaxValue**: 1000<br />
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

- [AzureServiceConnectionIdName](#BKMK_AzureServiceConnectionIdName)
- [ConfigurationUsedName](#BKMK_ConfigurationUsedName)
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
- [VersionNumber](#BKMK_VersionNumber)


### <a name="BKMK_AzureServiceConnectionIdName"></a> AzureServiceConnectionIdName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: azureserviceconnectionidname<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_ConfigurationUsedName"></a> ConfigurationUsedName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: configurationusedname<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_CreatedBy"></a> CreatedBy

**Description**: Unique identifier of the user who created the Topic Model.<br />
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

**Description**: Unique identifier of the delegate user who created the topic Model.<br />
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

**Description**: Unique identifier of the user who modified the Topic Model.<br />
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

**Description**: Unique identifier of the delegate user who last modified the Topic model.<br />
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

- [topicmodel_SyncErrors](#BKMK_topicmodel_SyncErrors)
- [topicmodel_AsyncOperations](#BKMK_topicmodel_AsyncOperations)
- [topicmodel_MailboxTrackingFolders](#BKMK_topicmodel_MailboxTrackingFolders)
- [topicmodel_UserEntityInstanceDatas](#BKMK_topicmodel_UserEntityInstanceDatas)
- [topicmodel_BulkDeleteFailures](#BKMK_topicmodel_BulkDeleteFailures)
- [topicmodel_PrincipalObjectAttributeAccesses](#BKMK_topicmodel_PrincipalObjectAttributeAccesses)
- [topicmodel_topicmodelconfiguration](#BKMK_topicmodel_topicmodelconfiguration)
- [topicmodel_topicmodelexecutionhistory](#BKMK_topicmodel_topicmodelexecutionhistory)


### <a name="BKMK_topicmodel_SyncErrors"></a> topicmodel_SyncErrors

Same as syncerror entity [topicmodel_SyncErrors](syncerror.md#BKMK_topicmodel_SyncErrors) Many-To-One relationship.

**ReferencingEntity**: syncerror<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: topicmodel_SyncErrors<br />
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


### <a name="BKMK_topicmodel_AsyncOperations"></a> topicmodel_AsyncOperations

Same as asyncoperation entity [topicmodel_AsyncOperations](asyncoperation.md#BKMK_topicmodel_AsyncOperations) Many-To-One relationship.

**ReferencingEntity**: asyncoperation<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: topicmodel_AsyncOperations<br />
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


### <a name="BKMK_topicmodel_MailboxTrackingFolders"></a> topicmodel_MailboxTrackingFolders

Same as mailboxtrackingfolder entity [topicmodel_MailboxTrackingFolders](mailboxtrackingfolder.md#BKMK_topicmodel_MailboxTrackingFolders) Many-To-One relationship.

**ReferencingEntity**: mailboxtrackingfolder<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: topicmodel_MailboxTrackingFolders<br />
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


### <a name="BKMK_topicmodel_UserEntityInstanceDatas"></a> topicmodel_UserEntityInstanceDatas

Same as userentityinstancedata entity [topicmodel_UserEntityInstanceDatas](userentityinstancedata.md#BKMK_topicmodel_UserEntityInstanceDatas) Many-To-One relationship.

**ReferencingEntity**: userentityinstancedata<br />
**ReferencingAttribute**: objectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: topicmodel_UserEntityInstanceDatas<br />
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


### <a name="BKMK_topicmodel_BulkDeleteFailures"></a> topicmodel_BulkDeleteFailures

Same as bulkdeletefailure entity [topicmodel_BulkDeleteFailures](bulkdeletefailure.md#BKMK_topicmodel_BulkDeleteFailures) Many-To-One relationship.

**ReferencingEntity**: bulkdeletefailure<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: topicmodel_BulkDeleteFailures<br />
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


### <a name="BKMK_topicmodel_PrincipalObjectAttributeAccesses"></a> topicmodel_PrincipalObjectAttributeAccesses

Same as principalobjectattributeaccess entity [topicmodel_PrincipalObjectAttributeAccesses](principalobjectattributeaccess.md#BKMK_topicmodel_PrincipalObjectAttributeAccesses) Many-To-One relationship.

**ReferencingEntity**: principalobjectattributeaccess<br />
**ReferencingAttribute**: objectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: topicmodel_PrincipalObjectAttributeAccesses<br />
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


### <a name="BKMK_topicmodel_topicmodelconfiguration"></a> topicmodel_topicmodelconfiguration

Same as topicmodelconfiguration entity [topicmodel_topicmodelconfiguration](topicmodelconfiguration.md#BKMK_topicmodel_topicmodelconfiguration) Many-To-One relationship.

**ReferencingEntity**: topicmodelconfiguration<br />
**ReferencingAttribute**: topicmodelid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: topicmodel_topicmodelconfiguration<br />
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


### <a name="BKMK_topicmodel_topicmodelexecutionhistory"></a> topicmodel_topicmodelexecutionhistory

Same as topicmodelexecutionhistory entity [topicmodel_topicmodelexecutionhistory](topicmodelexecutionhistory.md#BKMK_topicmodel_topicmodelexecutionhistory) Many-To-One relationship.

**ReferencingEntity**: topicmodelexecutionhistory<br />
**ReferencingAttribute**: topicmodelid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: topicmodel_topicmodelexecutionhistory<br />
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

<a name="manytoone"></a>

## Many-To-One Relationships

Each Many-To-One relationship is defined by a corresponding One-To-Many relationship with the related entity. Listed by **SchemaName**.

- [lk_topicmodel_createdby](#BKMK_lk_topicmodel_createdby)
- [lk_topicmodel_createdonbehalfby](#BKMK_lk_topicmodel_createdonbehalfby)
- [lk_topicmodel_modifiedby](#BKMK_lk_topicmodel_modifiedby)
- [lk_topicmodel_modifiedonbehalfby](#BKMK_lk_topicmodel_modifiedonbehalfby)
- [organization_topicmodel](#BKMK_organization_topicmodel)
- [azureserviceconnection_topicmodel](#BKMK_azureserviceconnection_topicmodel)
- [topicmodelconfiguration_topicmodel](#BKMK_topicmodelconfiguration_topicmodel)


### <a name="BKMK_lk_topicmodel_createdby"></a> lk_topicmodel_createdby

See systemuser Entity [lk_topicmodel_createdby](systemuser.md#BKMK_lk_topicmodel_createdby) One-To-Many relationship.

### <a name="BKMK_lk_topicmodel_createdonbehalfby"></a> lk_topicmodel_createdonbehalfby

See systemuser Entity [lk_topicmodel_createdonbehalfby](systemuser.md#BKMK_lk_topicmodel_createdonbehalfby) One-To-Many relationship.

### <a name="BKMK_lk_topicmodel_modifiedby"></a> lk_topicmodel_modifiedby

See systemuser Entity [lk_topicmodel_modifiedby](systemuser.md#BKMK_lk_topicmodel_modifiedby) One-To-Many relationship.

### <a name="BKMK_lk_topicmodel_modifiedonbehalfby"></a> lk_topicmodel_modifiedonbehalfby

See systemuser Entity [lk_topicmodel_modifiedonbehalfby](systemuser.md#BKMK_lk_topicmodel_modifiedonbehalfby) One-To-Many relationship.

### <a name="BKMK_organization_topicmodel"></a> organization_topicmodel

See organization Entity [organization_topicmodel](organization.md#BKMK_organization_topicmodel) One-To-Many relationship.

### <a name="BKMK_azureserviceconnection_topicmodel"></a> azureserviceconnection_topicmodel

See azureserviceconnection Entity [azureserviceconnection_topicmodel](azureserviceconnection.md#BKMK_azureserviceconnection_topicmodel) One-To-Many relationship.

### <a name="BKMK_topicmodelconfiguration_topicmodel"></a> topicmodelconfiguration_topicmodel

See topicmodelconfiguration Entity [topicmodelconfiguration_topicmodel](topicmodelconfiguration.md#BKMK_topicmodelconfiguration_topicmodel) One-To-Many relationship.

## See also

[About the Entity Reference](../about-entity-reference.md)<br />
[Programming reference for Dynamics 365 Customer Engagement](../programming-reference.md)<br />
[Web API Reference](/dynamics365/customer-engagement/web-api/about)<br />
<xref href="Microsoft.Dynamics.CRM.topicmodel?text=topicmodel EntityType" />