---
title: "Subject Entity Reference (Developer Guide for Dynamics 365 Customer Engagement)| MicrosoftDocs"
description: "Includes schema information and supported messages for the Subject entity."
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
# Subject Entity Reference

Information regarding subjects available in the system.


## Messages

|Message|Web API Operation|SDK Assembly|
|-|-|-|
|Create|POST [*org URI*]/api/data/v9.0/subjects<br />See [Create](../webapi/create-entity-web-api.md)|<xref:Microsoft.Xrm.Sdk.Messages.CreateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Create*>|
|Delete|DELETE [*org URI*]/api/data/v9.0/subjects(*subjectid*)<br />See [Delete](../webapi/update-delete-entities-using-web-api.md#basic-delete)|<xref:Microsoft.Xrm.Sdk.Messages.DeleteRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Delete*>|
|Retrieve|GET [*org URI*]/api/data/v9.0/subjects(*subjectid*)<br />See [Retrieve](../webapi/retrieve-entity-using-web-api.md)|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Retrieve*>|
|RetrieveMultiple|GET [*org URI*]/api/data/v9.0/subjects<br />See [Query Data](../webapi/query-data-web-api.md)|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveMultipleRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.RetrieveMultiple*>|
|Update|PATCH [*org URI*]/api/data/v9.0/subjects(*subjectid*)<br />See [Update](../webapi/update-delete-entities-using-web-api.md#basic-update)|<xref:Microsoft.Xrm.Sdk.Messages.UpdateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Update*>|

## Entity Properties

|Property|Value|
|--------|-----|
|CollectionSchemaName|Subjects|
|DisplayCollectionName|Subjects|
|DisplayName|Subject|
|EntitySetName|subjects|
|IsBPFEntity|False|
|LogicalCollectionName|subjects|
|LogicalName|subject|
|OwnershipType|OrganizationOwned|
|PrimaryIdAttribute|subjectid|
|PrimaryNameAttribute|title|
|SchemaName|Subject|

<a name="writable-attributes"></a>

## Writable attributes

These attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [Description](#BKMK_Description)
- [FeatureMask](#BKMK_FeatureMask)
- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [OverriddenCreatedOn](#BKMK_OverriddenCreatedOn)
- [ParentSubject](#BKMK_ParentSubject)
- [SubjectId](#BKMK_SubjectId)
- [Title](#BKMK_Title)


### <a name="BKMK_Description"></a> Description

|Property|Value|
|--------|-----|
|Description|Description of the subject.|
|DisplayName|Description|
|Format|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|description|
|MaxLength|2000|
|RequiredLevel|None|
|Type|Memo|


### <a name="BKMK_FeatureMask"></a> FeatureMask

|Property|Value|
|--------|-----|
|Description|Information that specifies when the subject will be displayed in lists of subjects.|
|DisplayName|Feature Mask|
|Format|None|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|featuremask|
|MaxValue|1000000000|
|MinValue|0|
|RequiredLevel|None|
|Type|Integer|


### <a name="BKMK_ImportSequenceNumber"></a> ImportSequenceNumber

|Property|Value|
|--------|-----|
|Description|Unique identifier of the data import or data migration that created this record.|
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


### <a name="BKMK_ParentSubject"></a> ParentSubject

|Property|Value|
|--------|-----|
|Description|Unique identifier of the parent subject.|
|DisplayName|Parent Subject|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|parentsubject|
|RequiredLevel|None|
|Targets|subject|
|Type|Lookup|


### <a name="BKMK_SubjectId"></a> SubjectId

|Property|Value|
|--------|-----|
|Description|Unique identifier of the subject.|
|DisplayName|Subject|
|IsValidForForm|False|
|IsValidForRead|True|
|IsValidForUpdate|False|
|LogicalName|subjectid|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|


### <a name="BKMK_Title"></a> Title

|Property|Value|
|--------|-----|
|Description|Title of the subject.|
|DisplayName|Title|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|title|
|MaxLength|500|
|RequiredLevel|None|
|Type|String|

<a name="read-only-attributes"></a>
## Read-only attributes
These attributes return false for both **IsValidForCreate** or **IsValidForUpdate**. Listed by **SchemaName**.

- [CreatedBy](#BKMK_CreatedBy)
- [CreatedByExternalParty](#BKMK_CreatedByExternalParty)
- [CreatedByExternalPartyName](#BKMK_CreatedByExternalPartyName)
- [CreatedByExternalPartyYomiName](#BKMK_CreatedByExternalPartyYomiName)
- [CreatedByName](#BKMK_CreatedByName)
- [CreatedByYomiName](#BKMK_CreatedByYomiName)
- [CreatedOn](#BKMK_CreatedOn)
- [CreatedOnBehalfBy](#BKMK_CreatedOnBehalfBy)
- [CreatedOnBehalfByName](#BKMK_CreatedOnBehalfByName)
- [CreatedOnBehalfByYomiName](#BKMK_CreatedOnBehalfByYomiName)
- [ModifiedBy](#BKMK_ModifiedBy)
- [ModifiedByExternalParty](#BKMK_ModifiedByExternalParty)
- [ModifiedByExternalPartyName](#BKMK_ModifiedByExternalPartyName)
- [ModifiedByExternalPartyYomiName](#BKMK_ModifiedByExternalPartyYomiName)
- [ModifiedByName](#BKMK_ModifiedByName)
- [ModifiedByYomiName](#BKMK_ModifiedByYomiName)
- [ModifiedOn](#BKMK_ModifiedOn)
- [ModifiedOnBehalfBy](#BKMK_ModifiedOnBehalfBy)
- [ModifiedOnBehalfByName](#BKMK_ModifiedOnBehalfByName)
- [ModifiedOnBehalfByYomiName](#BKMK_ModifiedOnBehalfByYomiName)
- [OrganizationId](#BKMK_OrganizationId)
- [OrganizationIdName](#BKMK_OrganizationIdName)
- [ParentSubjectName](#BKMK_ParentSubjectName)
- [VersionNumber](#BKMK_VersionNumber)


### <a name="BKMK_CreatedBy"></a> CreatedBy

|Property|Value|
|--------|-----|
|Description|Unique identifier of the user who created the subject.|
|DisplayName|Created By|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|createdby|
|RequiredLevel|None|
|Targets|systemuser|
|Type|Lookup|


### <a name="BKMK_CreatedByExternalParty"></a> CreatedByExternalParty

|Property|Value|
|--------|-----|
|Description|Shows the external party who created the record.|
|DisplayName|Created By (External Party)|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|createdbyexternalparty|
|RequiredLevel|None|
|Targets|externalparty|
|Type|Lookup|


### <a name="BKMK_CreatedByExternalPartyName"></a> CreatedByExternalPartyName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|createdbyexternalpartyname|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_CreatedByExternalPartyYomiName"></a> CreatedByExternalPartyYomiName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|createdbyexternalpartyyominame|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


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
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_CreatedOn"></a> CreatedOn

|Property|Value|
|--------|-----|
|DateTimeBehavior|UserLocal|
|Description|Date and time when the subject was created.|
|DisplayName|Created On|
|Format|DateAndTime|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|createdon|
|RequiredLevel|None|
|Type|DateTime|


### <a name="BKMK_CreatedOnBehalfBy"></a> CreatedOnBehalfBy

|Property|Value|
|--------|-----|
|Description|Unique identifier of the delegate user who created the subject.|
|DisplayName|Created By (Delegate)|
|IsValidForForm|False|
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
|Description|Unique identifier of the user who last modified the subject.|
|DisplayName|Modified By|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|modifiedby|
|RequiredLevel|None|
|Targets|systemuser|
|Type|Lookup|


### <a name="BKMK_ModifiedByExternalParty"></a> ModifiedByExternalParty

|Property|Value|
|--------|-----|
|Description|Shows the external party who modified the record.|
|DisplayName|Modified By (External Party)|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|modifiedbyexternalparty|
|RequiredLevel|None|
|Targets|externalparty|
|Type|Lookup|


### <a name="BKMK_ModifiedByExternalPartyName"></a> ModifiedByExternalPartyName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|modifiedbyexternalpartyname|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_ModifiedByExternalPartyYomiName"></a> ModifiedByExternalPartyYomiName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|modifiedbyexternalpartyyominame|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


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
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_ModifiedOn"></a> ModifiedOn

|Property|Value|
|--------|-----|
|DateTimeBehavior|UserLocal|
|Description|Date and time when the subject was last modified.|
|DisplayName|Modified On|
|Format|DateAndTime|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|modifiedon|
|RequiredLevel|None|
|Type|DateTime|


### <a name="BKMK_ModifiedOnBehalfBy"></a> ModifiedOnBehalfBy

|Property|Value|
|--------|-----|
|Description|Unique identifier of the delegate user who last modified the subject.|
|DisplayName|Modified By (Delegate)|
|IsValidForForm|False|
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
|Description|Unique identifier for the organization associated with the subject.|
|DisplayName|Organization|
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


### <a name="BKMK_ParentSubjectName"></a> ParentSubjectName

|Property|Value|
|--------|-----|
|Description|Name of the parent subject.|
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|parentsubjectname|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_VersionNumber"></a> VersionNumber

|Property|Value|
|--------|-----|
|Description|Version number of the subject.|
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

- [subject_products](#BKMK_subject_products)
- [subject_incidents](#BKMK_subject_incidents)
- [subject_sales_literature](#BKMK_subject_sales_literature)
- [userentityinstancedata_subject](#BKMK_userentityinstancedata_subject)
- [Subject_AsyncOperations](#BKMK_Subject_AsyncOperations)
- [subject_knowledgearticles](#BKMK_subject_knowledgearticles)
- [Subject_BulkDeleteFailures](#BKMK_Subject_BulkDeleteFailures)
- [Subject_ProcessSessions](#BKMK_Subject_ProcessSessions)
- [Subject_SyncErrors](#BKMK_Subject_SyncErrors)
- [subject_parent_subject](#BKMK_subject_parent_subject)
- [subject_kb_articles](#BKMK_subject_kb_articles)


### <a name="BKMK_subject_products"></a> subject_products

Same as product entity [subject_products](product.md#BKMK_subject_products) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|product|
|ReferencingAttribute|subjectid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|subject_products|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Restrict<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_subject_incidents"></a> subject_incidents

Same as incident entity [subject_incidents](incident.md#BKMK_subject_incidents) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|incident|
|ReferencingAttribute|subjectid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|subject_incidents|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Restrict<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_subject_sales_literature"></a> subject_sales_literature

Same as salesliterature entity [subject_sales_literature](salesliterature.md#BKMK_subject_sales_literature) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|salesliterature|
|ReferencingAttribute|subjectid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|subject_sales_literature|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Restrict<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_userentityinstancedata_subject"></a> userentityinstancedata_subject

Same as userentityinstancedata entity [userentityinstancedata_subject](userentityinstancedata.md#BKMK_userentityinstancedata_subject) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|userentityinstancedata|
|ReferencingAttribute|objectid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|userentityinstancedata_subject|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_Subject_AsyncOperations"></a> Subject_AsyncOperations

Same as asyncoperation entity [Subject_AsyncOperations](asyncoperation.md#BKMK_Subject_AsyncOperations) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|asyncoperation|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|Subject_AsyncOperations|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_subject_knowledgearticles"></a> subject_knowledgearticles

Same as knowledgearticle entity [subject_knowledgearticles](knowledgearticle.md#BKMK_subject_knowledgearticles) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|knowledgearticle|
|ReferencingAttribute|subjectid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|subject_knowledgearticles|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Restrict<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_Subject_BulkDeleteFailures"></a> Subject_BulkDeleteFailures

Same as bulkdeletefailure entity [Subject_BulkDeleteFailures](bulkdeletefailure.md#BKMK_Subject_BulkDeleteFailures) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|bulkdeletefailure|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|Subject_BulkDeleteFailures|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_Subject_ProcessSessions"></a> Subject_ProcessSessions

Same as processsession entity [Subject_ProcessSessions](processsession.md#BKMK_Subject_ProcessSessions) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|processsession|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|Subject_ProcessSessions|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Details<br />Label: <br />Order: 110|
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_Subject_SyncErrors"></a> Subject_SyncErrors

Same as syncerror entity [Subject_SyncErrors](syncerror.md#BKMK_Subject_SyncErrors) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|syncerror|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|Subject_SyncErrors|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: Cascade<br />Reparent: Cascade<br />Share: Cascade<br />Unshare: Cascade|


### <a name="BKMK_subject_parent_subject"></a> subject_parent_subject

Same as subject entity [subject_parent_subject](subject.md#BKMK_subject_parent_subject) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|subject|
|ReferencingAttribute|parentsubject|
|IsHierarchical|True|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|subject_parent_subject|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: RemoveLink<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_subject_kb_articles"></a> subject_kb_articles

Same as kbarticle entity [subject_kb_articles](kbarticle.md#BKMK_subject_kb_articles) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|kbarticle|
|ReferencingAttribute|subjectid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|subject_kb_articles|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Restrict<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|

<a name="manytoone"></a>

## Many-To-One Relationships

Each Many-To-One relationship is defined by a corresponding One-To-Many relationship with the related entity. Listed by **SchemaName**.

- [lk_subjectbase_modifiedby](#BKMK_lk_subjectbase_modifiedby)
- [lk_externalparty_subject_modifiedby](#BKMK_lk_externalparty_subject_modifiedby)
- [lk_externalparty_subject_createdby](#BKMK_lk_externalparty_subject_createdby)
- [lk_subjectbase_createdby](#BKMK_lk_subjectbase_createdby)
- [organization_subjects](#BKMK_organization_subjects)
- [lk_subject_createdonbehalfby](#BKMK_lk_subject_createdonbehalfby)
- [subject_parent_subject](#BKMK_subject_parent_subject)
- [lk_subject_modifiedonbehalfby](#BKMK_lk_subject_modifiedonbehalfby)


### <a name="BKMK_lk_subjectbase_modifiedby"></a> lk_subjectbase_modifiedby

See systemuser Entity [lk_subjectbase_modifiedby](systemuser.md#BKMK_lk_subjectbase_modifiedby) One-To-Many relationship.

### <a name="BKMK_lk_externalparty_subject_modifiedby"></a> lk_externalparty_subject_modifiedby

See externalparty Entity [lk_externalparty_subject_modifiedby](externalparty.md#BKMK_lk_externalparty_subject_modifiedby) One-To-Many relationship.

### <a name="BKMK_lk_externalparty_subject_createdby"></a> lk_externalparty_subject_createdby

See externalparty Entity [lk_externalparty_subject_createdby](externalparty.md#BKMK_lk_externalparty_subject_createdby) One-To-Many relationship.

### <a name="BKMK_lk_subjectbase_createdby"></a> lk_subjectbase_createdby

See systemuser Entity [lk_subjectbase_createdby](systemuser.md#BKMK_lk_subjectbase_createdby) One-To-Many relationship.

### <a name="BKMK_organization_subjects"></a> organization_subjects

See organization Entity [organization_subjects](organization.md#BKMK_organization_subjects) One-To-Many relationship.

### <a name="BKMK_lk_subject_createdonbehalfby"></a> lk_subject_createdonbehalfby

See systemuser Entity [lk_subject_createdonbehalfby](systemuser.md#BKMK_lk_subject_createdonbehalfby) One-To-Many relationship.

### <a name="BKMK_subject_parent_subject"></a> subject_parent_subject

See subject Entity [subject_parent_subject](subject.md#BKMK_subject_parent_subject) One-To-Many relationship.

### <a name="BKMK_lk_subject_modifiedonbehalfby"></a> lk_subject_modifiedonbehalfby

See systemuser Entity [lk_subject_modifiedonbehalfby](systemuser.md#BKMK_lk_subject_modifiedonbehalfby) One-To-Many relationship.

### See also

[About the Entity Reference](../about-entity-reference.md)<br />
[Programming reference for Dynamics 365 Customer Engagement](../programming-reference.md)<br />
[Web API Reference](/dynamics365/customer-engagement/web-api/about)<br />
<xref href="Microsoft.Dynamics.CRM.subject?text=subject EntityType" />