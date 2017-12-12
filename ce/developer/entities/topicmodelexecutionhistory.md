---
title: "TopicModelExecutionHistory Entity Reference (Developer Guide for Dynamics 365 Customer Engagement)| MicrosoftDocs"
description: "Includes schema information and supported messages for the TopicModelExecutionHistory entity."
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

## Entity Properties

|Property|Value|
|--------|-----|
|CollectionSchemaName|TopicModelExecutionHistories|
|DisplayCollectionName|Topic Model Execution Histories|
|DisplayName|Topic Model Execution History|
|EntitySetName|topicmodelexecutionhistories|
|IsBPFEntity|False|
|LogicalCollectionName|topicmodelexecutionhistories|
|LogicalName|topicmodelexecutionhistory|
|OwnershipType|OrganizationOwned|
|PrimaryIdAttribute|topicmodelexecutionhistoryid|
|PrimaryNameAttribute|name|
|SchemaName|TopicModelExecutionHistory|

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

|Property|Value|
|--------|-----|
|Description|Detailed error message for the Topic Analysis process|
|DisplayName|Error Details|
|Format|TextArea|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|azuresyncerrormessage|
|MaxLength|1073741823|
|RequiredLevel|None|
|Type|Memo|


### <a name="BKMK_FetchXmlList"></a> FetchXmlList

|Property|Value|
|--------|-----|
|Description|Fetch Xml|
|DisplayName|Fetch Xml|
|Format|TextArea|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|fetchxmllist|
|MaxLength|500000|
|RequiredLevel|None|
|Type|Memo|


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


### <a name="BKMK_IsTestExecution"></a> IsTestExecution

|Property|Value|
|--------|-----|
|Description|Allow model to check is test executed.|
|DisplayName|Test Execution|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|istestexecution|
|RequiredLevel|None|
|Type|Boolean|

#### IsTestExecution Options

|Value|Label|
|-----|-----|
|1|Yes|
|0|No|

**DefaultValue**: False



### <a name="BKMK_MaxTopics"></a> MaxTopics

|Property|Value|
|--------|-----|
|Description|Maximum number of Topics.|
|DisplayName|Max Topics|
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
|Description|name|
|DisplayName|name|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|name|
|MaxLength|100|
|RequiredLevel|ApplicationRequired|
|Type|String|


### <a name="BKMK_NumberOfTopicsFound"></a> NumberOfTopicsFound

|Property|Value|
|--------|-----|
|Description|Number of Topics Identified|
|DisplayName|Number of Topics Identified|
|Format|None|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|numberoftopicsfound|
|MaxValue|2147483647|
|MinValue|0|
|RequiredLevel|None|
|Type|Integer|


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


### <a name="BKMK_RecordCorrelationId"></a> RecordCorrelationId

|Property|Value|
|--------|-----|
|Description|Record Correlation Id.|
|DisplayName|Record Correlation Id|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|recordcorrelationid|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_RecordsProcessed"></a> RecordsProcessed

|Property|Value|
|--------|-----|
|Description|Number of Records Synchronized|
|DisplayName|Number of Records Synchronized|
|Format|None|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|recordsprocessed|
|MaxValue|2147483647|
|MinValue|0|
|RequiredLevel|None|
|Type|Integer|


### <a name="BKMK_StartTime"></a> StartTime

|Property|Value|
|--------|-----|
|DateTimeBehavior|UserLocal|
|Description|StartTime|
|DisplayName|Start Time|
|Format|DateAndTime|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|starttime|
|RequiredLevel|None|
|Type|DateTime|


### <a name="BKMK_Status"></a> Status

|Property|Value|
|--------|-----|
|Description|Status|
|DisplayName|Status|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|status|
|RequiredLevel|None|
|Type|Picklist|

#### Status Options

|Value|Label|
|-----|-----|
|1|Queued|
|2|In progress|
|3|Success|
|4|Failed|



### <a name="BKMK_StatusReason"></a> StatusReason

|Property|Value|
|--------|-----|
|Description|StatusReason|
|DisplayName|Status Reason|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|statusreason|
|RequiredLevel|None|
|Type|Picklist|

#### StatusReason Options

|Value|Label|
|-----|-----|
|1|Topic analysis execution is queued|
|2|Topic analysis execution is synchronizing|
|3|Analyzing topic analysis execution|
|4|Topic analysis has built|
|5|Synchronization failed|
|6|Analysis failed|
|7|Connection failed|



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


### <a name="BKMK_TopicModelConfigurationId"></a> TopicModelConfigurationId

|Property|Value|
|--------|-----|
|Description|Unique identifier for Model associated with Topic Model Execution History.|
|DisplayName|Topic Model Configuration|
|IsValidForForm|False|
|IsValidForRead|True|
|IsValidForUpdate|False|
|LogicalName|topicmodelconfigurationid|
|RequiredLevel|ApplicationRequired|
|Targets|topicmodelconfiguration|
|Type|Lookup|


### <a name="BKMK_TopicModelExecutionHistoryId"></a> TopicModelExecutionHistoryId

|Property|Value|
|--------|-----|
|Description|Unique identifier for entity instances|
|DisplayName|TopicModelExecutionHistory|
|IsValidForForm|False|
|IsValidForRead|True|
|IsValidForUpdate|False|
|LogicalName|topicmodelexecutionhistoryid|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|


### <a name="BKMK_TopicModelId"></a> TopicModelId

|Property|Value|
|--------|-----|
|Description|Unique identifier for Model associated with Topic Model Execution History.|
|DisplayName|TopicModelId|
|IsValidForForm|False|
|IsValidForRead|True|
|IsValidForUpdate|False|
|LogicalName|topicmodelid|
|RequiredLevel|ApplicationRequired|
|Targets|topicmodel|
|Type|Lookup|


### <a name="BKMK_TotalTime"></a> TotalTime

|Property|Value|
|--------|-----|
|Description|Duration (in mins)|
|DisplayName|Duration (in mins)|
|Format|Duration|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|totaltime|
|MaxValue|2147483647|
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

|Property|Value|
|--------|-----|
|Description|Unique identifier of the user who created the topic model execution history.|
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
|Description|Unique identifier of the delegate user who created the topic model execution history.|
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
|Description|Unique identifier of the user who modified the topic model execution history.|
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
|Description|Unique identifier of the delegate user who last modified the topic model execution history.|
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


### <a name="BKMK_TopicModelConfigurationIdName"></a> TopicModelConfigurationIdName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|topicmodelconfigurationidname|
|MaxLength|100|
|RequiredLevel|ApplicationRequired|
|Type|String|


### <a name="BKMK_TopicModelIdName"></a> TopicModelIdName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|topicmodelidname|
|MaxLength|100|
|RequiredLevel|ApplicationRequired|
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

- [topicmodelexecutionhistory_SyncErrors](#BKMK_topicmodelexecutionhistory_SyncErrors)
- [topicmodelexecutionhistory_AsyncOperations](#BKMK_topicmodelexecutionhistory_AsyncOperations)
- [topicmodelexecutionhistory_MailboxTrackingFolders](#BKMK_topicmodelexecutionhistory_MailboxTrackingFolders)
- [topicmodelexecutionhistory_UserEntityInstanceDatas](#BKMK_topicmodelexecutionhistory_UserEntityInstanceDatas)
- [topicmodelexecutionhistory_BulkDeleteFailures](#BKMK_topicmodelexecutionhistory_BulkDeleteFailures)
- [topicmodelexecutionhistory_PrincipalObjectAttributeAccesses](#BKMK_topicmodelexecutionhistory_PrincipalObjectAttributeAccesses)
- [topicmodelexecutionhistory_topichistory](#BKMK_topicmodelexecutionhistory_topichistory)


### <a name="BKMK_topicmodelexecutionhistory_SyncErrors"></a> topicmodelexecutionhistory_SyncErrors

Same as syncerror entity [topicmodelexecutionhistory_SyncErrors](syncerror.md#BKMK_topicmodelexecutionhistory_SyncErrors) Many-To-One relationship.
|Property|Value|
|--------|-----|
|ReferencingEntity|syncerror|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|topicmodelexecutionhistory_SyncErrors|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_topicmodelexecutionhistory_AsyncOperations"></a> topicmodelexecutionhistory_AsyncOperations

Same as asyncoperation entity [topicmodelexecutionhistory_AsyncOperations](asyncoperation.md#BKMK_topicmodelexecutionhistory_AsyncOperations) Many-To-One relationship.
|Property|Value|
|--------|-----|
|ReferencingEntity|asyncoperation|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|topicmodelexecutionhistory_AsyncOperations|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_topicmodelexecutionhistory_MailboxTrackingFolders"></a> topicmodelexecutionhistory_MailboxTrackingFolders

Same as mailboxtrackingfolder entity [topicmodelexecutionhistory_MailboxTrackingFolders](mailboxtrackingfolder.md#BKMK_topicmodelexecutionhistory_MailboxTrackingFolders) Many-To-One relationship.
|Property|Value|
|--------|-----|
|ReferencingEntity|mailboxtrackingfolder|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|topicmodelexecutionhistory_MailboxTrackingFolders|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_topicmodelexecutionhistory_UserEntityInstanceDatas"></a> topicmodelexecutionhistory_UserEntityInstanceDatas

Same as userentityinstancedata entity [topicmodelexecutionhistory_UserEntityInstanceDatas](userentityinstancedata.md#BKMK_topicmodelexecutionhistory_UserEntityInstanceDatas) Many-To-One relationship.
|Property|Value|
|--------|-----|
|ReferencingEntity|userentityinstancedata|
|ReferencingAttribute|objectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|topicmodelexecutionhistory_UserEntityInstanceDatas|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_topicmodelexecutionhistory_BulkDeleteFailures"></a> topicmodelexecutionhistory_BulkDeleteFailures

Same as bulkdeletefailure entity [topicmodelexecutionhistory_BulkDeleteFailures](bulkdeletefailure.md#BKMK_topicmodelexecutionhistory_BulkDeleteFailures) Many-To-One relationship.
|Property|Value|
|--------|-----|
|ReferencingEntity|bulkdeletefailure|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|topicmodelexecutionhistory_BulkDeleteFailures|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_topicmodelexecutionhistory_PrincipalObjectAttributeAccesses"></a> topicmodelexecutionhistory_PrincipalObjectAttributeAccesses

Same as principalobjectattributeaccess entity [topicmodelexecutionhistory_PrincipalObjectAttributeAccesses](principalobjectattributeaccess.md#BKMK_topicmodelexecutionhistory_PrincipalObjectAttributeAccesses) Many-To-One relationship.
|Property|Value|
|--------|-----|
|ReferencingEntity|principalobjectattributeaccess|
|ReferencingAttribute|objectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|topicmodelexecutionhistory_PrincipalObjectAttributeAccesses|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_topicmodelexecutionhistory_topichistory"></a> topicmodelexecutionhistory_topichistory

Same as topichistory entity [topicmodelexecutionhistory_topichistory](topichistory.md#BKMK_topicmodelexecutionhistory_topichistory) Many-To-One relationship.
|Property|Value|
|--------|-----|
|ReferencingEntity|topichistory|
|ReferencingAttribute|topicmodelexecutionhistoryid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|topicmodelexecutionhistory_topichistory|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: RemoveLink<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|

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

### See also

[About the Entity Reference](../about-entity-reference.md)<br />
[Programming reference for Dynamics 365 Customer Engagement](../programming-reference.md)<br />
[Web API Reference](/dynamics365/customer-engagement/web-api/about)<br />
<xref href="Microsoft.Dynamics.CRM.topicmodelexecutionhistory?text=topicmodelexecutionhistory EntityType" />