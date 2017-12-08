---
title: "TopicModelConfiguration Entity Reference (Developer Guide for Dynamics 365 Customer Engagement)| MicrosoftDocs"
description: "Includes schema information and supported messages for the TopicModelConfiguration entity."
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
# TopicModelConfiguration Entity Reference

Configuration settings for identification of topics using text analytics.

**Added by**: Service Solution<br />

## Messages

|Message|Web API Operation|SDK Assembly|
|-|-|-|
|Create|POST [*org URI*]/api/data/v9.0/topicmodelconfigurations<br />See [Create](../webapi/create-entity-web-api.md)|<xref:Microsoft.Xrm.Sdk.Messages.CreateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Create*>|
|Delete|DELETE [*org URI*]/api/data/v9.0/topicmodelconfigurations(*topicmodelconfigurationid*)<br />See [Delete](../webapi/update-delete-entities-using-web-api.md#basic-delete)|<xref:Microsoft.Xrm.Sdk.Messages.DeleteRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Delete*>|
|Retrieve|GET [*org URI*]/api/data/v9.0/topicmodelconfigurations(*topicmodelconfigurationid*)<br />See [Retrieve](../webapi/retrieve-entity-using-web-api.md)|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Retrieve*>|
|RetrieveMultiple|GET [*org URI*]/api/data/v9.0/topicmodelconfigurations<br />See [Query Data](../webapi/query-data-web-api.md)|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveMultipleRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.RetrieveMultiple*>|
|Update|PATCH [*org URI*]/api/data/v9.0/topicmodelconfigurations(*topicmodelconfigurationid*)<br />See [Update](../webapi/update-delete-entities-using-web-api.md#basic-update)|<xref:Microsoft.Xrm.Sdk.Messages.UpdateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Update*>|

## Entity Properties

|Property|Value|
|--------|-----|
|CollectionSchemaName|TopicModelConfigurations|
|DisplayCollectionName|Topic Model Configurations|
|DisplayName|Topic Model Configuration|
|EntitySetName|topicmodelconfigurations|
|IsBPFEntity|False|
|LogicalCollectionName|topicmodelconfigurations|
|LogicalName|topicmodelconfiguration|
|OwnershipType|OrganizationOwned|
|PrimaryIdAttribute|topicmodelconfigurationid|
|PrimaryNameAttribute|name|
|SchemaName|TopicModelConfiguration|

<a name="writable-attributes"></a>

## Writable attributes

These attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [DataFilter](#BKMK_DataFilter)
- [Description](#BKMK_Description)
- [FetchXmlList](#BKMK_FetchXmlList)
- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [MinRelevanceScore](#BKMK_MinRelevanceScore)
- [Name](#BKMK_Name)
- [NgramSize](#BKMK_NgramSize)
- [OverriddenCreatedOn](#BKMK_OverriddenCreatedOn)
- [SourceEntity](#BKMK_SourceEntity)
- [StopWords](#BKMK_StopWords)
- [TimeFilter](#BKMK_TimeFilter)
- [TimeFilterDuration](#BKMK_TimeFilterDuration)
- [TimeZoneRuleVersionNumber](#BKMK_TimeZoneRuleVersionNumber)
- [TopicModelConfigurationId](#BKMK_TopicModelConfigurationId)
- [TopicModelId](#BKMK_TopicModelId)
- [UTCConversionTimeZoneCode](#BKMK_UTCConversionTimeZoneCode)


### <a name="BKMK_DataFilter"></a> DataFilter

|Property|Value|
|--------|-----|
|Description|Specify the data filter configured to filter records.|
|DisplayName|Data Filter|
|Format|TextArea|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|datafilter|
|MaxLength|1073741823|
|RequiredLevel|None|
|Type|Memo|


### <a name="BKMK_Description"></a> Description

|Property|Value|
|--------|-----|
|Description|Enter a description for the model|
|DisplayName|Description|
|Format|TextArea|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|description|
|MaxLength|2000|
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


### <a name="BKMK_MinRelevanceScore"></a> MinRelevanceScore

|Property|Value|
|--------|-----|
|Description|Enter the minimum relevance score of a topic.|
|DisplayName|Minimum Relevance Score|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|minrelevancescore|
|MaxValue|1|
|MinValue|0|
|Precision|2|
|RequiredLevel|None|
|Type|Decimal|


### <a name="BKMK_Name"></a> Name

|Property|Value|
|--------|-----|
|Description|Type a logical name for the model.|
|DisplayName|Name|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|name|
|MaxLength|100|
|RequiredLevel|ApplicationRequired|
|Type|String|


### <a name="BKMK_NgramSize"></a> NgramSize

|Property|Value|
|--------|-----|
|Description|Enter the maximum number of key phrase words to use in a topic.|
|DisplayName|Maximum Key Phrase Words|
|Format|None|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|ngramsize|
|MaxValue|3|
|MinValue|1|
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


### <a name="BKMK_SourceEntity"></a> SourceEntity

|Property|Value|
|--------|-----|
|Description|Type of entity with which the topic model configuration is associated.|
|DisplayName|Source Entity|
|IsValidForForm|True|
|IsValidForRead|True|
|IsValidForUpdate|False|
|LogicalName|sourceentity|
|RequiredLevel|ApplicationRequired|
|Type|EntityName|


### <a name="BKMK_StopWords"></a> StopWords

|Property|Value|
|--------|-----|
|Description|Stop words.|
|DisplayName|Stop Words|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|stopwords|
|MaxLength|500|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_TimeFilter"></a> TimeFilter

|Property|Value|
|--------|-----|
|Description|Select the time window to filter on for the last number of days or weeks.|
|DisplayName|Time Window Filter|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|timefilter|
|RequiredLevel|ApplicationRequired|
|Type|Picklist|

#### TimeFilter Options

|Value|Label|
|-----|-----|
|1|Last N Days|
|2|Last N Weeks|



### <a name="BKMK_TimeFilterDuration"></a> TimeFilterDuration

|Property|Value|
|--------|-----|
|Description|Time Filter Duration|
|DisplayName|Time Filter Duration|
|Format|None|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|timefilterduration|
|MaxValue|2147483647|
|MinValue|-2147483648|
|RequiredLevel|ApplicationRequired|
|Type|Integer|


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
|Description|Unique identifier for entity instances|
|DisplayName|TopicModelConfiguration|
|IsValidForForm|True|
|IsValidForRead|True|
|IsValidForUpdate|False|
|LogicalName|topicmodelconfigurationid|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|


### <a name="BKMK_TopicModelId"></a> TopicModelId

|Property|Value|
|--------|-----|
|Description|Unique identifier for Model associated with Topic Model Configuration.|
|DisplayName|TopicModelId|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|topicmodelid|
|RequiredLevel|SystemRequired|
|Targets|topicmodel|
|Type|Lookup|


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

- [ComponentState](#BKMK_ComponentState)
- [IsManaged](#BKMK_IsManaged)
- [OrganizationId](#BKMK_OrganizationId)
- [OrganizationIdName](#BKMK_OrganizationIdName)
- [OverwriteTime](#BKMK_OverwriteTime)
- [SolutionId](#BKMK_SolutionId)
- [SupportingSolutionId](#BKMK_SupportingSolutionId)
- [TopicModelConfigurationIdUnique](#BKMK_TopicModelConfigurationIdUnique)
- [TopicModelIdName](#BKMK_TopicModelIdName)
- [VersionNumber](#BKMK_VersionNumber)


### <a name="BKMK_ComponentState"></a> ComponentState

|Property|Value|
|--------|-----|
|Description|For internal use only.|
|DisplayName|Component State|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|componentstate|
|RequiredLevel|SystemRequired|
|Type|Picklist|

#### ComponentState Options

|Value|Label|
|-----|-----|
|0|Published|
|1|Unpublished|
|2|Deleted|
|3|Deleted Unpublished|



### <a name="BKMK_IsManaged"></a> IsManaged

|Property|Value|
|--------|-----|
|Description|Is Manageed|
|DisplayName|State|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|ismanaged|
|RequiredLevel|SystemRequired|
|Type|Boolean|

#### IsManaged Options

|Value|Label|
|-----|-----|
|1|Managed|
|0|Unmanaged|

**DefaultValue**: False



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


### <a name="BKMK_OverwriteTime"></a> OverwriteTime

|Property|Value|
|--------|-----|
|DateTimeBehavior|UserLocal|
|Description|Date and time when the record was created.|
|DisplayName|Created On|
|Format|DateOnly|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|overwritetime|
|RequiredLevel|SystemRequired|
|Type|DateTime|


### <a name="BKMK_SolutionId"></a> SolutionId

|Property|Value|
|--------|-----|
|Description|Unique identifier of the associated solution.|
|DisplayName|Solution|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|solutionid|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|


### <a name="BKMK_SupportingSolutionId"></a> SupportingSolutionId

|Property|Value|
|--------|-----|
|Description|For internal use only.|
|DisplayName|Solution|
|IsValidForForm|False|
|IsValidForRead|False|
|LogicalName|supportingsolutionid|
|RequiredLevel|None|
|Type|Uniqueidentifier|


### <a name="BKMK_TopicModelConfigurationIdUnique"></a> TopicModelConfigurationIdUnique

|Property|Value|
|--------|-----|
|Description|Unique identifier of the Topic Model Configuration used when synchronizing customizations for the Microsoft Dynamics 365 client for Outlook|
|DisplayName|Topic Model Configuration Unique Id|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|topicmodelconfigurationidunique|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|


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

- [topicmodelconfiguration_SyncErrors](#BKMK_topicmodelconfiguration_SyncErrors)
- [topicmodelconfiguration_AsyncOperations](#BKMK_topicmodelconfiguration_AsyncOperations)
- [topicmodelconfiguration_MailboxTrackingFolders](#BKMK_topicmodelconfiguration_MailboxTrackingFolders)
- [topicmodelconfiguration_UserEntityInstanceDatas](#BKMK_topicmodelconfiguration_UserEntityInstanceDatas)
- [topicmodelconfiguration_BulkDeleteFailures](#BKMK_topicmodelconfiguration_BulkDeleteFailures)
- [topicmodelconfiguration_PrincipalObjectAttributeAccesses](#BKMK_topicmodelconfiguration_PrincipalObjectAttributeAccesses)
- [topicmodelconfiguration_textanalyticsentitymapping](#BKMK_topicmodelconfiguration_textanalyticsentitymapping)
- [topicmodelconfiguration_topicmodel](#BKMK_topicmodelconfiguration_topicmodel)
- [topicmodelconfiguration_topicmodelexecutionhistory](#BKMK_topicmodelconfiguration_topicmodelexecutionhistory)


### <a name="BKMK_topicmodelconfiguration_SyncErrors"></a> topicmodelconfiguration_SyncErrors

Same as syncerror entity [topicmodelconfiguration_SyncErrors](syncerror.md#BKMK_topicmodelconfiguration_SyncErrors) Many-To-One relationship.
|Property|Value|
|--------|-----|
|ReferencingEntity|syncerror|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|topicmodelconfiguration_SyncErrors|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_topicmodelconfiguration_AsyncOperations"></a> topicmodelconfiguration_AsyncOperations

Same as asyncoperation entity [topicmodelconfiguration_AsyncOperations](asyncoperation.md#BKMK_topicmodelconfiguration_AsyncOperations) Many-To-One relationship.
|Property|Value|
|--------|-----|
|ReferencingEntity|asyncoperation|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|topicmodelconfiguration_AsyncOperations|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_topicmodelconfiguration_MailboxTrackingFolders"></a> topicmodelconfiguration_MailboxTrackingFolders

Same as mailboxtrackingfolder entity [topicmodelconfiguration_MailboxTrackingFolders](mailboxtrackingfolder.md#BKMK_topicmodelconfiguration_MailboxTrackingFolders) Many-To-One relationship.
|Property|Value|
|--------|-----|
|ReferencingEntity|mailboxtrackingfolder|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|topicmodelconfiguration_MailboxTrackingFolders|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_topicmodelconfiguration_UserEntityInstanceDatas"></a> topicmodelconfiguration_UserEntityInstanceDatas

Same as userentityinstancedata entity [topicmodelconfiguration_UserEntityInstanceDatas](userentityinstancedata.md#BKMK_topicmodelconfiguration_UserEntityInstanceDatas) Many-To-One relationship.
|Property|Value|
|--------|-----|
|ReferencingEntity|userentityinstancedata|
|ReferencingAttribute|objectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|topicmodelconfiguration_UserEntityInstanceDatas|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_topicmodelconfiguration_BulkDeleteFailures"></a> topicmodelconfiguration_BulkDeleteFailures

Same as bulkdeletefailure entity [topicmodelconfiguration_BulkDeleteFailures](bulkdeletefailure.md#BKMK_topicmodelconfiguration_BulkDeleteFailures) Many-To-One relationship.
|Property|Value|
|--------|-----|
|ReferencingEntity|bulkdeletefailure|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|topicmodelconfiguration_BulkDeleteFailures|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_topicmodelconfiguration_PrincipalObjectAttributeAccesses"></a> topicmodelconfiguration_PrincipalObjectAttributeAccesses

Same as principalobjectattributeaccess entity [topicmodelconfiguration_PrincipalObjectAttributeAccesses](principalobjectattributeaccess.md#BKMK_topicmodelconfiguration_PrincipalObjectAttributeAccesses) Many-To-One relationship.
|Property|Value|
|--------|-----|
|ReferencingEntity|principalobjectattributeaccess|
|ReferencingAttribute|objectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|topicmodelconfiguration_PrincipalObjectAttributeAccesses|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_topicmodelconfiguration_textanalyticsentitymapping"></a> topicmodelconfiguration_textanalyticsentitymapping

Same as textanalyticsentitymapping entity [topicmodelconfiguration_textanalyticsentitymapping](textanalyticsentitymapping.md#BKMK_topicmodelconfiguration_textanalyticsentitymapping) Many-To-One relationship.
|Property|Value|
|--------|-----|
|ReferencingEntity|textanalyticsentitymapping|
|ReferencingAttribute|topicmodelconfigurationid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|topicmodelconfiguration_textanalyticsentitymapping|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: 1000|
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_topicmodelconfiguration_topicmodel"></a> topicmodelconfiguration_topicmodel

Same as topicmodel entity [topicmodelconfiguration_topicmodel](topicmodel.md#BKMK_topicmodelconfiguration_topicmodel) Many-To-One relationship.
|Property|Value|
|--------|-----|
|ReferencingEntity|topicmodel|
|ReferencingAttribute|configurationused|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|topicmodelconfiguration_topicmodel|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: RemoveLink<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_topicmodelconfiguration_topicmodelexecutionhistory"></a> topicmodelconfiguration_topicmodelexecutionhistory

Same as topicmodelexecutionhistory entity [topicmodelconfiguration_topicmodelexecutionhistory](topicmodelexecutionhistory.md#BKMK_topicmodelconfiguration_topicmodelexecutionhistory) Many-To-One relationship.
|Property|Value|
|--------|-----|
|ReferencingEntity|topicmodelexecutionhistory|
|ReferencingAttribute|topicmodelconfigurationid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|topicmodelconfiguration_topicmodelexecutionhistory|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|

<a name="manytoone"></a>

## Many-To-One Relationships

Each Many-To-One relationship is defined by a corresponding One-To-Many relationship with the related entity. Listed by **SchemaName**.

- [organization_topicmodelconfiguration](#BKMK_organization_topicmodelconfiguration)
- [topicmodel_topicmodelconfiguration](#BKMK_topicmodel_topicmodelconfiguration)


### <a name="BKMK_organization_topicmodelconfiguration"></a> organization_topicmodelconfiguration

See organization Entity [organization_topicmodelconfiguration](organization.md#BKMK_organization_topicmodelconfiguration) One-To-Many relationship.

### <a name="BKMK_topicmodel_topicmodelconfiguration"></a> topicmodel_topicmodelconfiguration

See topicmodel Entity [topicmodel_topicmodelconfiguration](topicmodel.md#BKMK_topicmodel_topicmodelconfiguration) One-To-Many relationship.

### See also

[About the Entity Reference](../about-entity-reference.md)<br />
[Programming reference for Dynamics 365 Customer Engagement](../programming-reference.md)<br />
[Web API Reference](/dynamics365/customer-engagement/web-api/about)<br />
<xref href="Microsoft.Dynamics.CRM.topicmodelconfiguration?text=topicmodelconfiguration EntityType" />