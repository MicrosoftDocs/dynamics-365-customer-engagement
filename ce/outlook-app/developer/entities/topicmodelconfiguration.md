---
title: "TopicModelConfiguration Entity Reference (Developer Guide for Dynamics 365 Customer Engagement)| MicrosoftDocs"
description: "Includes schema information and supported messages for the TopicModelConfiguration entity."
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

## Properties

**DisplayName**: Topic Model Configuration<br />
**DisplayCollectionName**: Topic Model Configurations<br />
**SchemaName**: TopicModelConfiguration<br />
**CollectionSchemaName**: TopicModelConfigurations<br />
**LogicalName**: topicmodelconfiguration<br />
**LogicalCollectionName**: topicmodelconfigurations<br />
**EntitySetName**: topicmodelconfigurations<br />
**PrimaryIdAttribute**: topicmodelconfigurationid<br />
**PrimaryNameAttribute**: name<br />
**OwnershipType**: OrganizationOwned<br />
**IsBPFEntity**: False<br />
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

**Description**: Specify the data filter configured to filter records.<br />
**DisplayName**: Data Filter<br />
**LogicalName**: datafilter<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Memo<br />
**Format**: TextArea<br />
**IsLocalizable**: False<br />
**MaxLength**: 1073741823


### <a name="BKMK_Description"></a> Description

**Description**: Enter a description for the model<br />
**DisplayName**: Description<br />
**LogicalName**: description<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Memo<br />
**Format**: TextArea<br />
**IsLocalizable**: False<br />
**MaxLength**: 2000


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


### <a name="BKMK_MinRelevanceScore"></a> MinRelevanceScore

**Description**: Enter the minimum relevance score of a topic.<br />
**DisplayName**: Minimum Relevance Score<br />
**LogicalName**: minrelevancescore<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Decimal<br />
**MaxValue**: 1<br />
**MinValue**: 0<br />
**Precision**: 2


### <a name="BKMK_Name"></a> Name

**Description**: Type a logical name for the model.<br />
**DisplayName**: Name<br />
**LogicalName**: name<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: ApplicationRequired<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_NgramSize"></a> NgramSize

**Description**: Enter the maximum number of key phrase words to use in a topic.<br />
**DisplayName**: Maximum Key Phrase Words<br />
**LogicalName**: ngramsize<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Integer<br />
**Format**: None<br />
**MaxValue**: 3<br />
**MinValue**: 1


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

**Description**: Type of entity with which the topic model configuration is associated.<br />
**DisplayName**: Source Entity<br />
**LogicalName**: sourceentity<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: ApplicationRequired<br />
**IsValidForUpdate**: False<br />
**Type**: EntityName<br />


### <a name="BKMK_StopWords"></a> StopWords

**Description**: Stop words.<br />
**DisplayName**: Stop Words<br />
**LogicalName**: stopwords<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 500


### <a name="BKMK_TimeFilter"></a> TimeFilter

**Description**: Select the time window to filter on for the last number of days or weeks.<br />
**DisplayName**: Time Window Filter<br />
**LogicalName**: timefilter<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: ApplicationRequired<br />
**Type**: Picklist<br />
**Options**:

- **Value**: 1 **Label**: Last N Days
- **Value**: 2 **Label**: Last N Weeks



### <a name="BKMK_TimeFilterDuration"></a> TimeFilterDuration

**Description**: Time Filter Duration<br />
**DisplayName**: Time Filter Duration<br />
**LogicalName**: timefilterduration<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: ApplicationRequired<br />
**Type**: Integer<br />
**Format**: None<br />
**MaxValue**: 2147483647<br />
**MinValue**: -2147483648


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

**Description**: Unique identifier for entity instances<br />
**DisplayName**: TopicModelConfiguration<br />
**LogicalName**: topicmodelconfigurationid<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: SystemRequired<br />
**IsValidForUpdate**: False<br />
**Type**: Uniqueidentifier<br />


### <a name="BKMK_TopicModelId"></a> TopicModelId

**Description**: Unique identifier for Model associated with Topic Model Configuration.<br />
**DisplayName**: TopicModelId<br />
**LogicalName**: topicmodelid<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: SystemRequired<br />
**Type**: Lookup<br />
**Targets**: topicmodel


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

**Description**: For internal use only.<br />
**DisplayName**: Component State<br />
**LogicalName**: componentstate<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: SystemRequired<br />
**Type**: Picklist<br />
**Options**:

- **Value**: 0 **Label**: Published
- **Value**: 1 **Label**: Unpublished
- **Value**: 2 **Label**: Deleted
- **Value**: 3 **Label**: Deleted Unpublished



### <a name="BKMK_IsManaged"></a> IsManaged

**Description**: Is Manageed<br />
**DisplayName**: State<br />
**LogicalName**: ismanaged<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: SystemRequired<br />
**Type**: Boolean<br />
**Options**:

- **TrueOption Value**: 1 **Label**: Managed
- **FalseOption Value**: 0 **Label**: Unmanaged

**DefaultValue**: False


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


### <a name="BKMK_OverwriteTime"></a> OverwriteTime

**Description**: Date and time when the record was created.<br />
**DisplayName**: Created On<br />
**LogicalName**: overwritetime<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: SystemRequired<br />
**Type**: DateTime<br />
**DateTimeBehavior**: UserLocal<br />
**Format**: DateOnly


### <a name="BKMK_SolutionId"></a> SolutionId

**Description**: Unique identifier of the associated solution.<br />
**DisplayName**: Solution<br />
**LogicalName**: solutionid<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: SystemRequired<br />
**Type**: Uniqueidentifier<br />


### <a name="BKMK_SupportingSolutionId"></a> SupportingSolutionId

**Description**: For internal use only.<br />
**DisplayName**: Solution<br />
**LogicalName**: supportingsolutionid<br />
**IsValidForForm**: False<br />
**IsValidForRead**: False<br />
**RequiredLevel**: None<br />
**Type**: Uniqueidentifier<br />


### <a name="BKMK_TopicModelConfigurationIdUnique"></a> TopicModelConfigurationIdUnique

**Description**: Unique identifier of the Topic Model Configuration used when synchronizing customizations for the Microsoft Dynamics 365 client for Outlook<br />
**DisplayName**: Topic Model Configuration Unique Id<br />
**LogicalName**: topicmodelconfigurationidunique<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: SystemRequired<br />
**Type**: Uniqueidentifier<br />


### <a name="BKMK_TopicModelIdName"></a> TopicModelIdName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: topicmodelidname<br />
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

**ReferencingEntity**: syncerror<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: topicmodelconfiguration_SyncErrors<br />
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


### <a name="BKMK_topicmodelconfiguration_AsyncOperations"></a> topicmodelconfiguration_AsyncOperations

Same as asyncoperation entity [topicmodelconfiguration_AsyncOperations](asyncoperation.md#BKMK_topicmodelconfiguration_AsyncOperations) Many-To-One relationship.

**ReferencingEntity**: asyncoperation<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: topicmodelconfiguration_AsyncOperations<br />
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


### <a name="BKMK_topicmodelconfiguration_MailboxTrackingFolders"></a> topicmodelconfiguration_MailboxTrackingFolders

Same as mailboxtrackingfolder entity [topicmodelconfiguration_MailboxTrackingFolders](mailboxtrackingfolder.md#BKMK_topicmodelconfiguration_MailboxTrackingFolders) Many-To-One relationship.

**ReferencingEntity**: mailboxtrackingfolder<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: topicmodelconfiguration_MailboxTrackingFolders<br />
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


### <a name="BKMK_topicmodelconfiguration_UserEntityInstanceDatas"></a> topicmodelconfiguration_UserEntityInstanceDatas

Same as userentityinstancedata entity [topicmodelconfiguration_UserEntityInstanceDatas](userentityinstancedata.md#BKMK_topicmodelconfiguration_UserEntityInstanceDatas) Many-To-One relationship.

**ReferencingEntity**: userentityinstancedata<br />
**ReferencingAttribute**: objectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: topicmodelconfiguration_UserEntityInstanceDatas<br />
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


### <a name="BKMK_topicmodelconfiguration_BulkDeleteFailures"></a> topicmodelconfiguration_BulkDeleteFailures

Same as bulkdeletefailure entity [topicmodelconfiguration_BulkDeleteFailures](bulkdeletefailure.md#BKMK_topicmodelconfiguration_BulkDeleteFailures) Many-To-One relationship.

**ReferencingEntity**: bulkdeletefailure<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: topicmodelconfiguration_BulkDeleteFailures<br />
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


### <a name="BKMK_topicmodelconfiguration_PrincipalObjectAttributeAccesses"></a> topicmodelconfiguration_PrincipalObjectAttributeAccesses

Same as principalobjectattributeaccess entity [topicmodelconfiguration_PrincipalObjectAttributeAccesses](principalobjectattributeaccess.md#BKMK_topicmodelconfiguration_PrincipalObjectAttributeAccesses) Many-To-One relationship.

**ReferencingEntity**: principalobjectattributeaccess<br />
**ReferencingAttribute**: objectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: topicmodelconfiguration_PrincipalObjectAttributeAccesses<br />
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


### <a name="BKMK_topicmodelconfiguration_textanalyticsentitymapping"></a> topicmodelconfiguration_textanalyticsentitymapping

Same as textanalyticsentitymapping entity [topicmodelconfiguration_textanalyticsentitymapping](textanalyticsentitymapping.md#BKMK_topicmodelconfiguration_textanalyticsentitymapping) Many-To-One relationship.

**ReferencingEntity**: textanalyticsentitymapping<br />
**ReferencingAttribute**: topicmodelconfigurationid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: False<br />
**ReferencedEntityNavigationPropertyName**: topicmodelconfiguration_textanalyticsentitymapping<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 1000

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: Cascade
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_topicmodelconfiguration_topicmodel"></a> topicmodelconfiguration_topicmodel

Same as topicmodel entity [topicmodelconfiguration_topicmodel](topicmodel.md#BKMK_topicmodelconfiguration_topicmodel) Many-To-One relationship.

**ReferencingEntity**: topicmodel<br />
**ReferencingAttribute**: configurationused<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: topicmodelconfiguration_topicmodel<br />
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


### <a name="BKMK_topicmodelconfiguration_topicmodelexecutionhistory"></a> topicmodelconfiguration_topicmodelexecutionhistory

Same as topicmodelexecutionhistory entity [topicmodelconfiguration_topicmodelexecutionhistory](topicmodelexecutionhistory.md#BKMK_topicmodelconfiguration_topicmodelexecutionhistory) Many-To-One relationship.

**ReferencingEntity**: topicmodelexecutionhistory<br />
**ReferencingAttribute**: topicmodelconfigurationid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: topicmodelconfiguration_topicmodelexecutionhistory<br />
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

- [organization_topicmodelconfiguration](#BKMK_organization_topicmodelconfiguration)
- [topicmodel_topicmodelconfiguration](#BKMK_topicmodel_topicmodelconfiguration)


### <a name="BKMK_organization_topicmodelconfiguration"></a> organization_topicmodelconfiguration

See organization Entity [organization_topicmodelconfiguration](organization.md#BKMK_organization_topicmodelconfiguration) One-To-Many relationship.

### <a name="BKMK_topicmodel_topicmodelconfiguration"></a> topicmodel_topicmodelconfiguration

See topicmodel Entity [topicmodel_topicmodelconfiguration](topicmodel.md#BKMK_topicmodel_topicmodelconfiguration) One-To-Many relationship.

## See also

[About the Entity Reference](../about-entity-reference.md)<br />
[Programming reference for Dynamics 365 Customer Engagement](../programming-reference.md)<br />
[Web API Reference](/dynamics365/customer-engagement/web-api/about)<br />
<xref href="Microsoft.Dynamics.CRM.topicmodelconfiguration?text=topicmodelconfiguration EntityType" />