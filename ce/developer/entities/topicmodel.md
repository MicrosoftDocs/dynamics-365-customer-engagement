---
title: "TopicModel Entity Reference (Developer Guide for Dynamics 365 Customer Engagement)| MicrosoftDocs"
description: "Includes schema information and supported messages for the TopicModel entity."
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

## Entity Properties

|Property|Value|
|--------|-----|
|CollectionSchemaName|TopicModels|
|DisplayCollectionName|Topic Model|
|DisplayName|Topic Model|
|EntitySetName|topicmodels|
|IsBPFEntity|False|
|LogicalCollectionName|topicmodels|
|LogicalName|topicmodel|
|OwnershipType|OrganizationOwned|
|PrimaryIdAttribute|topicmodelid|
|PrimaryNameAttribute|name|
|SchemaName|TopicModel|

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

|Property|Value|
|--------|-----|
|Description|Shows the average number of topics found per build.|
|DisplayName|Average Number of Topics per Build|
|Format|None|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|avgnumberoftopics|
|MaxValue|1000|
|MinValue|0|
|RequiredLevel|None|
|Type|Integer|


### <a name="BKMK_AzureSchedulerJobName"></a> AzureSchedulerJobName

|Property|Value|
|--------|-----|
|Description|Azure Scheduler Job Name.|
|DisplayName|AzureSchedulerJobName|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|azureschedulerjobname|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_AzureSchedulerOnDemandJobName"></a> AzureSchedulerOnDemandJobName

|Property|Value|
|--------|-----|
|Description|Azure Scheduler Job Name for build model|
|DisplayName|Scheduler Build Job|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|azureschedulerondemandjobname|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_AzureSchedulerTestJobName"></a> AzureSchedulerTestJobName

|Property|Value|
|--------|-----|
|Description|Azure Scheduler Job Name for test model|
|DisplayName|Scheduler Test Job|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|azureschedulertestjobname|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_AzureServiceConnectionId"></a> AzureServiceConnectionId

|Property|Value|
|--------|-----|
|Description|Unique identifier for AzureServiceConnection associated with TopicModel.|
|DisplayName|Connection|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|azureserviceconnectionid|
|RequiredLevel|ApplicationRequired|
|Targets|azureserviceconnection|
|Type|Lookup|


### <a name="BKMK_BuildRecurrence"></a> BuildRecurrence

|Property|Value|
|--------|-----|
|Description|Shows how frequently topic analysis is done.|
|DisplayName|Build Recurrence|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|buildrecurrence|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_ConfigurationUsed"></a> ConfigurationUsed

|Property|Value|
|--------|-----|
|Description|Shows the configuration used for topic analysis.|
|DisplayName|Configuration|
|IsValidForCreate|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|configurationused|
|RequiredLevel|None|
|Targets|topicmodelconfiguration|
|Type|Lookup|


### <a name="BKMK_Description"></a> Description

|Property|Value|
|--------|-----|
|Description|Enter a description for the model.|
|DisplayName|Description|
|Format|TextArea|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|description|
|MaxLength|2000|
|RequiredLevel|None|
|Type|Memo|


### <a name="BKMK_EndTime"></a> EndTime

|Property|Value|
|--------|-----|
|DateTimeBehavior|UserLocal|
|Description|Shows the time when topic analysis will stop|
|DisplayName|End Time|
|Format|DateAndTime|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|endtime|
|RequiredLevel|None|
|Type|DateTime|


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


### <a name="BKMK_MaxNumberofTopics"></a> MaxNumberofTopics

|Property|Value|
|--------|-----|
|Description|Shows the maximum number of topics found across builds.|
|DisplayName|Maximum Topics Found Across Builds|
|Format|None|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|maxnumberoftopics|
|MaxValue|1000|
|MinValue|0|
|RequiredLevel|None|
|Type|Integer|


### <a name="BKMK_MaxTopics"></a> MaxTopics

|Property|Value|
|--------|-----|
|Description|Shows the maximum number of topics to be determined.|
|DisplayName|Maximum Topics|
|Format|None|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|maxtopics|
|MaxValue|1000|
|MinValue|0|
|RequiredLevel|ApplicationRequired|
|Type|Integer|


### <a name="BKMK_Name"></a> Name

|Property|Value|
|--------|-----|
|Description|Shows the name of the topic model.|
|DisplayName|Name|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|name|
|MaxLength|160|
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


### <a name="BKMK_SourceEntity"></a> SourceEntity

|Property|Value|
|--------|-----|
|Description|Shows the entity whose records are used for topic analysis.|
|DisplayName|Source Entity|
|IsValidForForm|True|
|IsValidForRead|True|
|IsValidForUpdate|False|
|LogicalName|sourceentity|
|RequiredLevel|ApplicationRequired|
|Type|EntityName|


### <a name="BKMK_StartTime"></a> StartTime

|Property|Value|
|--------|-----|
|DateTimeBehavior|UserLocal|
|Description|Shows the time when topic analysis will start according to the recurrence schedule.|
|DisplayName|Start Time|
|Format|DateAndTime|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|starttime|
|RequiredLevel|None|
|Type|DateTime|


### <a name="BKMK_StateCode"></a> StateCode

|Property|Value|
|--------|-----|
|Description|Shows the status of the topic model build|
|DisplayName|Status|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|statecode|
|RequiredLevel|SystemRequired|
|Type|State|

#### StateCode Options

|Value|Label|DefaultStatus|InvariantName|
|-----|-----|-------------|-------------|
|0|Active|1|Active|
|1|Inactive|2|Inactive|



### <a name="BKMK_StatusCode"></a> StatusCode

|Property|Value|
|--------|-----|
|Description|Reason for the status of the TopicModel|
|DisplayName|Status Reason|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|statuscode|
|RequiredLevel|None|
|Type|Status|

#### StatusCode Options

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


### <a name="BKMK_TopicModelId"></a> TopicModelId

|Property|Value|
|--------|-----|
|Description|Unique identifier for entity instances|
|DisplayName|TopicModel|
|IsValidForForm|True|
|IsValidForRead|True|
|IsValidForUpdate|False|
|LogicalName|topicmodelid|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|


### <a name="BKMK_TopicsLastCreatedOn"></a> TopicsLastCreatedOn

|Property|Value|
|--------|-----|
|DateTimeBehavior|UserLocal|
|Description|Shows when the topics were last created.|
|DisplayName|Topics Last Created On|
|Format|DateAndTime|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|topicslastcreatedon|
|RequiredLevel|None|
|Type|DateTime|


### <a name="BKMK_TotalTopicsFound"></a> TotalTopicsFound

|Property|Value|
|--------|-----|
|Description|Shows the total number of topics found.|
|DisplayName|Total Topics Found|
|Format|None|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|totaltopicsfound|
|MaxValue|1000|
|MinValue|0|
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

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|azureserviceconnectionidname|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_ConfigurationUsedName"></a> ConfigurationUsedName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|configurationusedname|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_CreatedBy"></a> CreatedBy

|Property|Value|
|--------|-----|
|Description|Unique identifier of the user who created the Topic Model.|
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
|Description|Date and time when the record was created.|
|DisplayName|Created On|
|Format|DateOnly|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|createdon|
|RequiredLevel|None|
|Type|DateTime|


### <a name="BKMK_CreatedOnBehalfBy"></a> CreatedOnBehalfBy

|Property|Value|
|--------|-----|
|Description|Unique identifier of the delegate user who created the topic Model.|
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
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_ModifiedBy"></a> ModifiedBy

|Property|Value|
|--------|-----|
|Description|Unique identifier of the user who modified the Topic Model.|
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
|Description|Date and time when the record was modified.|
|DisplayName|Modified On|
|Format|DateOnly|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|modifiedon|
|RequiredLevel|None|
|Type|DateTime|


### <a name="BKMK_ModifiedOnBehalfBy"></a> ModifiedOnBehalfBy

|Property|Value|
|--------|-----|
|Description|Unique identifier of the delegate user who last modified the Topic model.|
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
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_OrganizationId"></a> OrganizationId

|Property|Value|
|--------|-----|
|Description|Unique identifier for the organization|
|DisplayName|Organization Id|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|organizationid|
|RequiredLevel|SystemRequired|
|Targets|organization|
|Type|Lookup|


### <a name="BKMK_OrganizationIdName"></a> OrganizationIdName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|organizationidname|
|MaxLength|100|
|RequiredLevel|SystemRequired|
|Type|String|


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
|Property|Value|
|--------|-----|
|ReferencingEntity|syncerror|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|topicmodel_SyncErrors|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_topicmodel_AsyncOperations"></a> topicmodel_AsyncOperations

Same as asyncoperation entity [topicmodel_AsyncOperations](asyncoperation.md#BKMK_topicmodel_AsyncOperations) Many-To-One relationship.
|Property|Value|
|--------|-----|
|ReferencingEntity|asyncoperation|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|topicmodel_AsyncOperations|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_topicmodel_MailboxTrackingFolders"></a> topicmodel_MailboxTrackingFolders

Same as mailboxtrackingfolder entity [topicmodel_MailboxTrackingFolders](mailboxtrackingfolder.md#BKMK_topicmodel_MailboxTrackingFolders) Many-To-One relationship.
|Property|Value|
|--------|-----|
|ReferencingEntity|mailboxtrackingfolder|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|topicmodel_MailboxTrackingFolders|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_topicmodel_UserEntityInstanceDatas"></a> topicmodel_UserEntityInstanceDatas

Same as userentityinstancedata entity [topicmodel_UserEntityInstanceDatas](userentityinstancedata.md#BKMK_topicmodel_UserEntityInstanceDatas) Many-To-One relationship.
|Property|Value|
|--------|-----|
|ReferencingEntity|userentityinstancedata|
|ReferencingAttribute|objectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|topicmodel_UserEntityInstanceDatas|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_topicmodel_BulkDeleteFailures"></a> topicmodel_BulkDeleteFailures

Same as bulkdeletefailure entity [topicmodel_BulkDeleteFailures](bulkdeletefailure.md#BKMK_topicmodel_BulkDeleteFailures) Many-To-One relationship.
|Property|Value|
|--------|-----|
|ReferencingEntity|bulkdeletefailure|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|topicmodel_BulkDeleteFailures|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_topicmodel_PrincipalObjectAttributeAccesses"></a> topicmodel_PrincipalObjectAttributeAccesses

Same as principalobjectattributeaccess entity [topicmodel_PrincipalObjectAttributeAccesses](principalobjectattributeaccess.md#BKMK_topicmodel_PrincipalObjectAttributeAccesses) Many-To-One relationship.
|Property|Value|
|--------|-----|
|ReferencingEntity|principalobjectattributeaccess|
|ReferencingAttribute|objectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|topicmodel_PrincipalObjectAttributeAccesses|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_topicmodel_topicmodelconfiguration"></a> topicmodel_topicmodelconfiguration

Same as topicmodelconfiguration entity [topicmodel_topicmodelconfiguration](topicmodelconfiguration.md#BKMK_topicmodel_topicmodelconfiguration) Many-To-One relationship.
|Property|Value|
|--------|-----|
|ReferencingEntity|topicmodelconfiguration|
|ReferencingAttribute|topicmodelid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|topicmodel_topicmodelconfiguration|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_topicmodel_topicmodelexecutionhistory"></a> topicmodel_topicmodelexecutionhistory

Same as topicmodelexecutionhistory entity [topicmodel_topicmodelexecutionhistory](topicmodelexecutionhistory.md#BKMK_topicmodel_topicmodelexecutionhistory) Many-To-One relationship.
|Property|Value|
|--------|-----|
|ReferencingEntity|topicmodelexecutionhistory|
|ReferencingAttribute|topicmodelid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|topicmodel_topicmodelexecutionhistory|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|

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

### See also

[About the Entity Reference](../about-entity-reference.md)<br />
[Programming reference for Dynamics 365 Customer Engagement](../programming-reference.md)<br />
[Web API Reference](/dynamics365/customer-engagement/web-api/about)<br />
<xref href="Microsoft.Dynamics.CRM.topicmodel?text=topicmodel EntityType" />