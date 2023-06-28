---
title: "Note (Annotation)  entity reference (Dynamics 365 Customer Engagement) | Microsoft Docs"
description: "Includes schema information and supported messages for the Note (Annotation)  entity."
ms.date: 08/30/2022
ms.topic: "reference"
ms.assetid: 3948cc48-07c8-7f60-0608-71c37158ad7c
author: "KumarVivek"
ms.author: "kvivek"
search.audienceType: 
  - developer
---

# Note (Annotation)  entity reference

Note that is attached to one or more objects, including other notes.


## Messages

|Message|SDK class or method|
|-|-|
|Assign|<xref:Microsoft.Crm.Sdk.Messages.AssignRequest>|
|Create|<xref:Microsoft.Xrm.Sdk.Messages.CreateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Create*>|
|Delete|<xref:Microsoft.Xrm.Sdk.Messages.DeleteRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Delete*>|
|GrantAccess|<xref:Microsoft.Crm.Sdk.Messages.GrantAccessRequest>|
|ModifyAccess|<xref:Microsoft.Crm.Sdk.Messages.ModifyAccessRequest>|
|Retrieve|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Retrieve*>|
|RetrieveMultiple|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveMultipleRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.RetrieveMultiple*>|
|RetrievePrincipalAccess|<xref:Microsoft.Crm.Sdk.Messages.RetrievePrincipalAccessRequest>|
|RetrieveSharedPrincipalsAndAccess|<xref:Microsoft.Crm.Sdk.Messages.RetrieveSharedPrincipalsAndAccessRequest>|
|RevokeAccess|<xref:Microsoft.Crm.Sdk.Messages.RevokeAccessRequest>|
|Rollup|<xref:Microsoft.Crm.Sdk.Messages.RollupRequest>|
|Update|<xref:Microsoft.Xrm.Sdk.Messages.UpdateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Update*>|

## Properties

|Property|Value|
|--------|-----|
|CollectionSchemaName|Annotations|
|DisplayCollectionName|Notes|
|DisplayName|Note|
|EntitySetName|annotations|
|IsBPFEntity|False|
|LogicalCollectionName|annotations|
|LogicalName|annotation|
|OwnershipType|UserOwned|
|PrimaryIdAttribute|annotationid|
|PrimaryNameAttribute|subject|
|SchemaName|Annotation|

<a name="writable-attributes"></a>

## Writable attributes

These attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [AnnotationId](#BKMK_AnnotationId)
- [DocumentBody](#BKMK_DocumentBody)
- [FileName](#BKMK_FileName)
- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [IsDocument](#BKMK_IsDocument)
- [LangId](#BKMK_LangId)
- [MimeType](#BKMK_MimeType)
- [NoteText](#BKMK_NoteText)
- [ObjectId](#BKMK_ObjectId)
- [ObjectIdTypeCode](#BKMK_ObjectIdTypeCode)
- [ObjectTypeCode](#BKMK_ObjectTypeCode)
- [OverriddenCreatedOn](#BKMK_OverriddenCreatedOn)
- [OwnerId](#BKMK_OwnerId)
- [OwnerIdType](#BKMK_OwnerIdType)
- [StepId](#BKMK_StepId)
- [Subject](#BKMK_Subject)


### <a name="BKMK_AnnotationId"></a> AnnotationId

|Property|Value|
|--------|-----|
|Description|Unique identifier of the note.|
|DisplayName|Note|
|IsValidForForm|False|
|IsValidForRead|True|
|IsValidForUpdate|False|
|LogicalName|annotationid|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|


### <a name="BKMK_DocumentBody"></a> DocumentBody

|Property|Value|
|--------|-----|
|Description|Contents of the note's attachment.|
|DisplayName|Document|
|FormatName|TextArea|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|documentbody|
|MaxLength|1073741823|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_FileName"></a> FileName

|Property|Value|
|--------|-----|
|Description|File name of the note.|
|DisplayName|File Name|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|filename|
|MaxLength|255|
|RequiredLevel|None|
|Type|String|


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


### <a name="BKMK_IsDocument"></a> IsDocument

|Property|Value|
|--------|-----|
|Description|Specifies whether the note is an attachment.|
|DisplayName|Is Document|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|isdocument|
|RequiredLevel|SystemRequired|
|Type|Boolean|

#### IsDocument Choices/Options

|Value|Label|Description|
|-----|-----|--------|
|1|Yes||
|0|No||

**DefaultValue**: 0



### <a name="BKMK_LangId"></a> LangId

|Property|Value|
|--------|-----|
|Description|Language identifier for the note.|
|DisplayName|Language ID|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|langid|
|MaxLength|2|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_MimeType"></a> MimeType

|Property|Value|
|--------|-----|
|Description|MIME type of the note's attachment.|
|DisplayName|Mime Type|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|mimetype|
|MaxLength|256|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_NoteText"></a> NoteText

|Property|Value|
|--------|-----|
|Description|Text of the note.|
|DisplayName|Description|
|Format|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|notetext|
|MaxLength|100000|
|RequiredLevel|None|
|Type|Memo|


### <a name="BKMK_ObjectId"></a> ObjectId

|Property|Value|
|--------|-----|
|Description|Unique identifier of the object with which the note is associated.|
|DisplayName|Regarding|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|objectid|
|RequiredLevel|None|
|Targets|account,appointment,bookableresource,bookableresourcebooking,bookableresourcebookingheader,bookableresourcecategoryassn,bookableresourcecharacteristic,bookableresourcegroup,bulkoperation,calendar,campaign,campaignactivity,campaignresponse,channelaccessprofile,channelaccessprofilerule,channelaccessprofileruleitem,commitment,competitor,contact,contract,contractdetail,convertrule,duplicaterule,email,emailserverprofile,entitlement,entitlementchannel,entitlementtemplate,equipment,fax,goal,incident,incidentresolution,invoice,kbarticle,knowledgearticle,knowledgebaserecord,lead,letter,list,mailbox,msdyn_postalbum,msdyn_solutioncomponentdatasource,opportunity,opportunityclose,orderclose,phonecall,product,quote,quoteclose,recurringappointmentmaster,resourcespec,routingrule,routingruleitem,salesorder,service,serviceappointment,sharepointdocument,sla,socialactivity,task,workflow|
|Type|Lookup|


### <a name="BKMK_ObjectIdTypeCode"></a> ObjectIdTypeCode

|Property|Value|
|--------|-----|
|Description||
|DisplayName|Regarding Object Type|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|objectidtypecode|
|RequiredLevel|None|
|Type|EntityName|


### <a name="BKMK_ObjectTypeCode"></a> ObjectTypeCode

|Property|Value|
|--------|-----|
|Description|Type of entity with which the note is associated.|
|DisplayName|Object Type |
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|objecttypecode|
|RequiredLevel|None|
|Type|EntityName|


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

|Property|Value|
|--------|-----|
|Description|Unique identifier of the user or team who owns the note.|
|DisplayName|Owner|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|ownerid|
|RequiredLevel|SystemRequired|
|Targets|systemuser,team|
|Type|Owner|


### <a name="BKMK_OwnerIdType"></a> OwnerIdType

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|owneridtype|
|RequiredLevel|SystemRequired|
|Type|EntityName|


### <a name="BKMK_StepId"></a> StepId

|Property|Value|
|--------|-----|
|Description|workflow step id associated with the note.|
|DisplayName|Step Id|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|stepid|
|MaxLength|32|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_Subject"></a> Subject

|Property|Value|
|--------|-----|
|Description|Subject associated with the note.|
|DisplayName|Title|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|subject|
|MaxLength|500|
|RequiredLevel|ApplicationRequired|
|Type|String|

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
- [FileSize](#BKMK_FileSize)
- [IsPrivate](#BKMK_IsPrivate)
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

|Property|Value|
|--------|-----|
|Description|Unique identifier of the user who created the note.|
|DisplayName|Created By|
|IsValidForForm|False|
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
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_CreatedOn"></a> CreatedOn

|Property|Value|
|--------|-----|
|DateTimeBehavior|UserLocal|
|Description|Date and time when the note was created.|
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
|Description|Unique identifier of the delegate user who created the annotation.|
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


### <a name="BKMK_FileSize"></a> FileSize

|Property|Value|
|--------|-----|
|Description|File size of the note.|
|DisplayName|File Size (Bytes)|
|Format|None|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|filesize|
|MaxValue|1000000000|
|MinValue|0|
|RequiredLevel|None|
|Type|Integer|


### <a name="BKMK_IsPrivate"></a> IsPrivate

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|IsValidForForm|False|
|IsValidForRead|False|
|LogicalName|isprivate|
|RequiredLevel|None|
|Type|Boolean|

#### IsPrivate Choices/Options

|Value|Label|Description|
|-----|-----|--------|
|1|Yes||
|0|No||

**DefaultValue**: 0



### <a name="BKMK_ModifiedBy"></a> ModifiedBy

|Property|Value|
|--------|-----|
|Description|Unique identifier of the user who last modified the note.|
|DisplayName|Modified By|
|IsValidForForm|False|
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
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_ModifiedOn"></a> ModifiedOn

|Property|Value|
|--------|-----|
|DateTimeBehavior|UserLocal|
|Description|Date and time when the note was last modified.|
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
|Description|Unique identifier of the delegate user who last modified the annotation.|
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


### <a name="BKMK_OwnerIdName"></a> OwnerIdName

|Property|Value|
|--------|-----|
|Description||
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
|Description||
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
|Description|Unique identifier of the business unit that owns the note.|
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
|Description|Unique identifier of the team who owns the note.|
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
|Description|Unique identifier of the user who owns the note.|
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
|Description|Version number of the note.|
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

- [Annotation_SyncErrors](#BKMK_Annotation_SyncErrors)
- [Annotation_AsyncOperations](#BKMK_Annotation_AsyncOperations)
- [Annotation_BulkDeleteFailures](#BKMK_Annotation_BulkDeleteFailures)
- [Annotation_ProcessSessions](#BKMK_Annotation_ProcessSessions)


### <a name="BKMK_Annotation_SyncErrors"></a> Annotation_SyncErrors

Same as the [Annotation_SyncErrors](syncerror.md#BKMK_Annotation_SyncErrors) many-to-one relationship for the [syncerror](syncerror.md) entity.

|Property|Value|
|--------|-----|
|ReferencingEntity|syncerror|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|Annotation_SyncErrors|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: Cascade<br />Reparent: Cascade<br />Share: Cascade<br />Unshare: Cascade|


### <a name="BKMK_Annotation_AsyncOperations"></a> Annotation_AsyncOperations

Same as the [Annotation_AsyncOperations](asyncoperation.md#BKMK_Annotation_AsyncOperations) many-to-one relationship for the [asyncoperation](asyncoperation.md) entity.

|Property|Value|
|--------|-----|
|ReferencingEntity|asyncoperation|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|Annotation_AsyncOperations|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_Annotation_BulkDeleteFailures"></a> Annotation_BulkDeleteFailures

Same as the [Annotation_BulkDeleteFailures](bulkdeletefailure.md#BKMK_Annotation_BulkDeleteFailures) many-to-one relationship for the [bulkdeletefailure](bulkdeletefailure.md) entity.

|Property|Value|
|--------|-----|
|ReferencingEntity|bulkdeletefailure|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|Annotation_BulkDeleteFailures|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_Annotation_ProcessSessions"></a> Annotation_ProcessSessions

Same as the [Annotation_ProcessSessions](processsession.md#BKMK_Annotation_ProcessSessions) many-to-one relationship for the [processsession](processsession.md) entity.

|Property|Value|
|--------|-----|
|ReferencingEntity|processsession|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|Annotation_ProcessSessions|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Details<br />Label: <br />Order: 110|
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|

<a name="manytoone"></a>

## Many-To-One Relationships

Each Many-To-One relationship is defined by a corresponding One-To-Many relationship with the related entity. Listed by **SchemaName**.

- [knowledgearticle_Annotations](#BKMK_knowledgearticle_Annotations)
- [msdyn_solutioncomponentdatasource_Annotations](#BKMK_msdyn_solutioncomponentdatasource_Annotations)
- [Lead_Annotation](#BKMK_Lead_Annotation)
- [Product_Annotation](#BKMK_Product_Annotation)
- [bookableresource_Annotations](#BKMK_bookableresource_Annotations)
- [bookableresourcebooking_Annotations](#BKMK_bookableresourcebooking_Annotations)
- [bookableresourcebookingheader_Annotations](#BKMK_bookableresourcebookingheader_Annotations)
- [bookableresourcecategoryassn_Annotations](#BKMK_bookableresourcecategoryassn_Annotations)
- [bookableresourcecharacteristic_Annotations](#BKMK_bookableresourcecharacteristic_Annotations)
- [bookableresourcegroup_Annotations](#BKMK_bookableresourcegroup_Annotations)
- [bulkoperation_Annotations](#BKMK_bulkoperation_Annotations)
- [Campaign_Annotation](#BKMK_Campaign_Annotation)
- [CampaignActivity_Annotation](#BKMK_CampaignActivity_Annotation)
- [CampaignResponse_Annotation](#BKMK_CampaignResponse_Annotation)
- [List_Annotation](#BKMK_List_Annotation)
- [Contract_Annotation](#BKMK_Contract_Annotation)
- [ContractDetail_Annotation](#BKMK_ContractDetail_Annotation)
- [entitlement_Annotations](#BKMK_entitlement_Annotations)
- [entitlementchannel_Annotations](#BKMK_entitlementchannel_Annotations)
- [entitlementtemplate_Annotations](#BKMK_entitlementtemplate_Annotations)
- [Equipment_Annotation](#BKMK_Equipment_Annotation)
- [Incident_Annotation](#BKMK_Incident_Annotation)
- [IncidentResolution_Annotation](#BKMK_IncidentResolution_Annotation)
- [ResourceSpec_Annotation](#BKMK_ResourceSpec_Annotation)
- [Service_Annotation](#BKMK_Service_Annotation)
- [ServiceAppointment_Annotation](#BKMK_ServiceAppointment_Annotation)
- [Invoice_Annotation](#BKMK_Invoice_Annotation)
- [Opportunity_Annotation](#BKMK_Opportunity_Annotation)
- [OpportunityClose_Annotation](#BKMK_OpportunityClose_Annotation)
- [OrderClose_Annotation](#BKMK_OrderClose_Annotation)
- [Quote_Annotation](#BKMK_Quote_Annotation)
- [QuoteClose_Annotation](#BKMK_QuoteClose_Annotation)
- [SalesOrder_Annotation](#BKMK_SalesOrder_Annotation)
- [Competitor_Annotation](#BKMK_Competitor_Annotation)
- [msdyn_postalbum_Annotations](#BKMK_msdyn_postalbum_Annotations)
- [KnowledgeBaseRecord_Annotations](#BKMK_KnowledgeBaseRecord_Annotations)
- [lk_annotationbase_modifiedonbehalfby](#BKMK_lk_annotationbase_modifiedonbehalfby)
- [Mailbox_Annotation](#BKMK_Mailbox_Annotation)
- [team_annotations](#BKMK_team_annotations)
- [annotation_owning_user](#BKMK_annotation_owning_user)
- [PhoneCall_Annotation](#BKMK_PhoneCall_Annotation)
- [Contact_Annotation](#BKMK_Contact_Annotation)
- [SocialActivity_Annotation](#BKMK_SocialActivity_Annotation)
- [sla_Annotation](#BKMK_sla_Annotation)
- [Calendar_Annotation](#BKMK_Calendar_Annotation)
- [Email_Annotation](#BKMK_Email_Annotation)
- [Task_Annotation](#BKMK_Task_Annotation)
- [lk_annotationbase_createdby](#BKMK_lk_annotationbase_createdby)
- [EmailServerProfile_Annotation](#BKMK_EmailServerProfile_Annotation)
- [Account_Annotation](#BKMK_Account_Annotation)
- [RecurringAppointmentMaster_Annotation](#BKMK_RecurringAppointmentMaster_Annotation)
- [business_unit_annotations](#BKMK_business_unit_annotations)
- [lk_annotationbase_modifiedby](#BKMK_lk_annotationbase_modifiedby)
- [Letter_Annotation](#BKMK_Letter_Annotation)
- [Fax_Annotation](#BKMK_Fax_Annotation)
- [Workflow_Annotation](#BKMK_Workflow_Annotation)
- [Appointment_Annotation](#BKMK_Appointment_Annotation)
- [lk_annotationbase_createdonbehalfby](#BKMK_lk_annotationbase_createdonbehalfby)
- [Goal_Annotation](#BKMK_Goal_Annotation)
- [KbArticle_Annotation](#BKMK_KbArticle_Annotation)
- [DuplicateRule_Annotation](#BKMK_DuplicateRule_Annotation)


### <a name="BKMK_knowledgearticle_Annotations"></a> knowledgearticle_Annotations

See the [knowledgearticle_Annotations](knowledgearticle.md#BKMK_knowledgearticle_Annotations) one-to-many relationship for the [knowledgearticle](knowledgearticle.md) entity.

### <a name="BKMK_msdyn_solutioncomponentdatasource_Annotations"></a> msdyn_solutioncomponentdatasource_Annotations

**Added by**: Microsoft Dynamics 365 Settings APIs Solution

See the [msdyn_solutioncomponentdatasource_Annotations](msdyn_solutioncomponentdatasource.md#BKMK_msdyn_solutioncomponentdatasource_Annotations) one-to-many relationship for the [msdyn_solutioncomponentdatasource](msdyn_solutioncomponentdatasource.md) entity.

### <a name="BKMK_Lead_Annotation"></a> Lead_Annotation

**Added by**: Lead Management Solution

See the [Lead_Annotation](lead.md#BKMK_Lead_Annotation) one-to-many relationship for the [lead](lead.md) entity.

### <a name="BKMK_Product_Annotation"></a> Product_Annotation

**Added by**: Product Management Solution

See the [Product_Annotation](product.md#BKMK_Product_Annotation) one-to-many relationship for the [product](product.md) entity.

### <a name="BKMK_bookableresource_Annotations"></a> bookableresource_Annotations

**Added by**: Scheduling Solution

See the [bookableresource_Annotations](bookableresource.md#BKMK_bookableresource_Annotations) one-to-many relationship for the [bookableresource](bookableresource.md) entity.

### <a name="BKMK_bookableresourcebooking_Annotations"></a> bookableresourcebooking_Annotations

**Added by**: Scheduling Solution

See the [bookableresourcebooking_Annotations](bookableresourcebooking.md#BKMK_bookableresourcebooking_Annotations) one-to-many relationship for the [bookableresourcebooking](bookableresourcebooking.md) entity.

### <a name="BKMK_bookableresourcebookingheader_Annotations"></a> bookableresourcebookingheader_Annotations

**Added by**: Scheduling Solution

See the [bookableresourcebookingheader_Annotations](bookableresourcebookingheader.md#BKMK_bookableresourcebookingheader_Annotations) one-to-many relationship for the [bookableresourcebookingheader](bookableresourcebookingheader.md) entity.

### <a name="BKMK_bookableresourcecategoryassn_Annotations"></a> bookableresourcecategoryassn_Annotations

**Added by**: Scheduling Solution

See the [bookableresourcecategoryassn_Annotations](bookableresourcecategoryassn.md#BKMK_bookableresourcecategoryassn_Annotations) one-to-many relationship for the [bookableresourcecategoryassn](bookableresourcecategoryassn.md) entity.

### <a name="BKMK_bookableresourcecharacteristic_Annotations"></a> bookableresourcecharacteristic_Annotations

**Added by**: Scheduling Solution

See the [bookableresourcecharacteristic_Annotations](bookableresourcecharacteristic.md#BKMK_bookableresourcecharacteristic_Annotations) one-to-many relationship for the [bookableresourcecharacteristic](bookableresourcecharacteristic.md) entity.

### <a name="BKMK_bookableresourcegroup_Annotations"></a> bookableresourcegroup_Annotations

**Added by**: Scheduling Solution

See the [bookableresourcegroup_Annotations](bookableresourcegroup.md#BKMK_bookableresourcegroup_Annotations) one-to-many relationship for the [bookableresourcegroup](bookableresourcegroup.md) entity.

### <a name="BKMK_bulkoperation_Annotations"></a> bulkoperation_Annotations

**Added by**: Marketing Solution

See the [bulkoperation_Annotations](bulkoperation.md#BKMK_bulkoperation_Annotations) one-to-many relationship for the [bulkoperation](bulkoperation.md) entity.

### <a name="BKMK_Campaign_Annotation"></a> Campaign_Annotation

**Added by**: Marketing Solution

See the [Campaign_Annotation](campaign.md#BKMK_Campaign_Annotation) one-to-many relationship for the [campaign](campaign.md) entity.

### <a name="BKMK_CampaignActivity_Annotation"></a> CampaignActivity_Annotation

**Added by**: Marketing Solution

See the [CampaignActivity_Annotation](campaignactivity.md#BKMK_CampaignActivity_Annotation) one-to-many relationship for the [campaignactivity](campaignactivity.md) entity.

### <a name="BKMK_CampaignResponse_Annotation"></a> CampaignResponse_Annotation

**Added by**: Marketing Solution

See the [CampaignResponse_Annotation](campaignresponse.md#BKMK_CampaignResponse_Annotation) one-to-many relationship for the [campaignresponse](campaignresponse.md) entity.

### <a name="BKMK_List_Annotation"></a> List_Annotation

**Added by**: Marketing Solution

See the [List_Annotation](list.md#BKMK_List_Annotation) one-to-many relationship for the [list](list.md) entity.

### <a name="BKMK_Contract_Annotation"></a> Contract_Annotation

**Added by**: Service Solution

See the [Contract_Annotation](contract.md#BKMK_Contract_Annotation) one-to-many relationship for the [contract](contract.md) entity.

### <a name="BKMK_ContractDetail_Annotation"></a> ContractDetail_Annotation

**Added by**: Service Solution

See the [ContractDetail_Annotation](contractdetail.md#BKMK_ContractDetail_Annotation) one-to-many relationship for the [contractdetail](contractdetail.md) entity.

### <a name="BKMK_entitlement_Annotations"></a> entitlement_Annotations

**Added by**: Service Solution

See the [entitlement_Annotations](entitlement.md#BKMK_entitlement_Annotations) one-to-many relationship for the [entitlement](entitlement.md) entity.

### <a name="BKMK_entitlementchannel_Annotations"></a> entitlementchannel_Annotations

**Added by**: Service Solution

See the [entitlementchannel_Annotations](entitlementchannel.md#BKMK_entitlementchannel_Annotations) one-to-many relationship for the [entitlementchannel](entitlementchannel.md) entity.

### <a name="BKMK_entitlementtemplate_Annotations"></a> entitlementtemplate_Annotations

**Added by**: Service Solution

See the [entitlementtemplate_Annotations](entitlementtemplate.md#BKMK_entitlementtemplate_Annotations) one-to-many relationship for the [entitlementtemplate](entitlementtemplate.md) entity.

### <a name="BKMK_Equipment_Annotation"></a> Equipment_Annotation

**Added by**: Service Solution

See the [Equipment_Annotation](equipment.md#BKMK_Equipment_Annotation) one-to-many relationship for the [equipment](equipment.md) entity.

### <a name="BKMK_Incident_Annotation"></a> Incident_Annotation

**Added by**: Service Solution

See the [Incident_Annotation](incident.md#BKMK_Incident_Annotation) one-to-many relationship for the [incident](incident.md) entity.

### <a name="BKMK_IncidentResolution_Annotation"></a> IncidentResolution_Annotation

**Added by**: Service Solution

See the [IncidentResolution_Annotation](incidentresolution.md#BKMK_IncidentResolution_Annotation) one-to-many relationship for the [incidentresolution](incidentresolution.md) entity.

### <a name="BKMK_ResourceSpec_Annotation"></a> ResourceSpec_Annotation

**Added by**: Service Solution

See the [ResourceSpec_Annotation](resourcespec.md#BKMK_ResourceSpec_Annotation) one-to-many relationship for the [resourcespec](resourcespec.md) entity.

### <a name="BKMK_Service_Annotation"></a> Service_Annotation

**Added by**: Service Solution

See the [Service_Annotation](service.md#BKMK_Service_Annotation) one-to-many relationship for the [service](service.md) entity.

### <a name="BKMK_ServiceAppointment_Annotation"></a> ServiceAppointment_Annotation

**Added by**: Service Solution

See the [ServiceAppointment_Annotation](serviceappointment.md#BKMK_ServiceAppointment_Annotation) one-to-many relationship for the [serviceappointment](serviceappointment.md) entity.

### <a name="BKMK_Invoice_Annotation"></a> Invoice_Annotation

**Added by**: Sales Solution

See the [Invoice_Annotation](invoice.md#BKMK_Invoice_Annotation) one-to-many relationship for the [invoice](invoice.md) entity.

### <a name="BKMK_Opportunity_Annotation"></a> Opportunity_Annotation

**Added by**: Sales Solution

See the [Opportunity_Annotation](opportunity.md#BKMK_Opportunity_Annotation) one-to-many relationship for the [opportunity](opportunity.md) entity.

### <a name="BKMK_OpportunityClose_Annotation"></a> OpportunityClose_Annotation

**Added by**: Sales Solution

See the [OpportunityClose_Annotation](opportunityclose.md#BKMK_OpportunityClose_Annotation) one-to-many relationship for the [opportunityclose](opportunityclose.md) entity.

### <a name="BKMK_OrderClose_Annotation"></a> OrderClose_Annotation

**Added by**: Sales Solution

See the [OrderClose_Annotation](orderclose.md#BKMK_OrderClose_Annotation) one-to-many relationship for the [orderclose](orderclose.md) entity.

### <a name="BKMK_Quote_Annotation"></a> Quote_Annotation

**Added by**: Sales Solution

See the [Quote_Annotation](quote.md#BKMK_Quote_Annotation) one-to-many relationship for the [quote](quote.md) entity.

### <a name="BKMK_QuoteClose_Annotation"></a> QuoteClose_Annotation

**Added by**: Sales Solution

See the [QuoteClose_Annotation](quoteclose.md#BKMK_QuoteClose_Annotation) one-to-many relationship for the [quoteclose](quoteclose.md) entity.

### <a name="BKMK_SalesOrder_Annotation"></a> SalesOrder_Annotation

**Added by**: Sales Solution

See the [SalesOrder_Annotation](salesorder.md#BKMK_SalesOrder_Annotation) one-to-many relationship for the [salesorder](salesorder.md) entity.

### <a name="BKMK_Competitor_Annotation"></a> Competitor_Annotation

**Added by**: Sales Solution

See the [Competitor_Annotation](competitor.md#BKMK_Competitor_Annotation) one-to-many relationship for the [competitor](competitor.md) entity.

### <a name="BKMK_msdyn_postalbum_Annotations"></a> msdyn_postalbum_Annotations

**Added by**: Activity Feeds Solution

See the [msdyn_postalbum_Annotations](msdyn_postalbum.md#BKMK_msdyn_postalbum_Annotations) one-to-many relationship for the [msdyn_postalbum](msdyn_postalbum.md) entity.

### <a name="BKMK_KnowledgeBaseRecord_Annotations"></a> KnowledgeBaseRecord_Annotations

See the [KnowledgeBaseRecord_Annotations](knowledgebaserecord.md#BKMK_KnowledgeBaseRecord_Annotations) one-to-many relationship for the [knowledgebaserecord](knowledgebaserecord.md) entity.

### <a name="BKMK_lk_annotationbase_modifiedonbehalfby"></a> lk_annotationbase_modifiedonbehalfby

See the [lk_annotationbase_modifiedonbehalfby](systemuser.md#BKMK_lk_annotationbase_modifiedonbehalfby) one-to-many relationship for the [systemuser](systemuser.md) entity.

### <a name="BKMK_Mailbox_Annotation"></a> Mailbox_Annotation

See the [Mailbox_Annotation](mailbox.md#BKMK_Mailbox_Annotation) one-to-many relationship for the [mailbox](mailbox.md) entity.

### <a name="BKMK_team_annotations"></a> team_annotations

See the [team_annotations](team.md#BKMK_team_annotations) one-to-many relationship for the [team](team.md) entity.

### <a name="BKMK_annotation_owning_user"></a> annotation_owning_user

See the [annotation_owning_user](systemuser.md#BKMK_annotation_owning_user) one-to-many relationship for the [systemuser](systemuser.md) entity.

### <a name="BKMK_PhoneCall_Annotation"></a> PhoneCall_Annotation

See the [PhoneCall_Annotation](phonecall.md#BKMK_PhoneCall_Annotation) one-to-many relationship for the [phonecall](phonecall.md) entity.

### <a name="BKMK_Contact_Annotation"></a> Contact_Annotation

See the [Contact_Annotation](contact.md#BKMK_Contact_Annotation) one-to-many relationship for the [contact](contact.md) entity.

### <a name="BKMK_SocialActivity_Annotation"></a> SocialActivity_Annotation

See the [SocialActivity_Annotation](socialactivity.md#BKMK_SocialActivity_Annotation) one-to-many relationship for the [socialactivity](socialactivity.md) entity.

### <a name="BKMK_sla_Annotation"></a> sla_Annotation

See the [sla_Annotation](sla.md#BKMK_sla_Annotation) one-to-many relationship for the [sla](sla.md) entity.

### <a name="BKMK_Calendar_Annotation"></a> Calendar_Annotation

See the [Calendar_Annotation](calendar.md#BKMK_Calendar_Annotation) one-to-many relationship for the [calendar](calendar.md) entity.

### <a name="BKMK_Email_Annotation"></a> Email_Annotation

See the [Email_Annotation](email.md#BKMK_Email_Annotation) one-to-many relationship for the [email](email.md) entity.

### <a name="BKMK_Task_Annotation"></a> Task_Annotation

See the [Task_Annotation](task.md#BKMK_Task_Annotation) one-to-many relationship for the [task](task.md) entity.

### <a name="BKMK_lk_annotationbase_createdby"></a> lk_annotationbase_createdby

See the [lk_annotationbase_createdby](systemuser.md#BKMK_lk_annotationbase_createdby) one-to-many relationship for the [systemuser](systemuser.md) entity.

### <a name="BKMK_EmailServerProfile_Annotation"></a> EmailServerProfile_Annotation

See the [EmailServerProfile_Annotation](emailserverprofile.md#BKMK_EmailServerProfile_Annotation) one-to-many relationship for the [emailserverprofile](emailserverprofile.md) entity.

### <a name="BKMK_Account_Annotation"></a> Account_Annotation

See the [Account_Annotation](account.md#BKMK_Account_Annotation) one-to-many relationship for the [account](account.md) entity.

### <a name="BKMK_RecurringAppointmentMaster_Annotation"></a> RecurringAppointmentMaster_Annotation

See the [RecurringAppointmentMaster_Annotation](recurringappointmentmaster.md#BKMK_RecurringAppointmentMaster_Annotation) one-to-many relationship for the [recurringappointmentmaster](recurringappointmentmaster.md) entity.

### <a name="BKMK_business_unit_annotations"></a> business_unit_annotations

See the [business_unit_annotations](businessunit.md#BKMK_business_unit_annotations) one-to-many relationship for the [businessunit](businessunit.md) entity.

### <a name="BKMK_lk_annotationbase_modifiedby"></a> lk_annotationbase_modifiedby

See the [lk_annotationbase_modifiedby](systemuser.md#BKMK_lk_annotationbase_modifiedby) one-to-many relationship for the [systemuser](systemuser.md) entity.

### <a name="BKMK_Letter_Annotation"></a> Letter_Annotation

See the [Letter_Annotation](letter.md#BKMK_Letter_Annotation) one-to-many relationship for the [letter](letter.md) entity.

### <a name="BKMK_Fax_Annotation"></a> Fax_Annotation

See the [Fax_Annotation](fax.md#BKMK_Fax_Annotation) one-to-many relationship for the [fax](fax.md) entity.

### <a name="BKMK_Workflow_Annotation"></a> Workflow_Annotation

See the [Workflow_Annotation](workflow.md#BKMK_Workflow_Annotation) one-to-many relationship for the [workflow](workflow.md) entity.

### <a name="BKMK_Appointment_Annotation"></a> Appointment_Annotation

See the [Appointment_Annotation](appointment.md#BKMK_Appointment_Annotation) one-to-many relationship for the [appointment](appointment.md) entity.

### <a name="BKMK_lk_annotationbase_createdonbehalfby"></a> lk_annotationbase_createdonbehalfby

See the [lk_annotationbase_createdonbehalfby](systemuser.md#BKMK_lk_annotationbase_createdonbehalfby) one-to-many relationship for the [systemuser](systemuser.md) entity.

### <a name="BKMK_Goal_Annotation"></a> Goal_Annotation

See the [Goal_Annotation](goal.md#BKMK_Goal_Annotation) one-to-many relationship for the [goal](goal.md) entity.

### <a name="BKMK_KbArticle_Annotation"></a> KbArticle_Annotation

See the [KbArticle_Annotation](kbarticle.md#BKMK_KbArticle_Annotation) one-to-many relationship for the [kbarticle](kbarticle.md) entity.

### <a name="BKMK_DuplicateRule_Annotation"></a> DuplicateRule_Annotation

See the [DuplicateRule_Annotation](duplicaterule.md#BKMK_DuplicateRule_Annotation) one-to-many relationship for the [duplicaterule](duplicaterule.md) entity.

### See also

[About the Entity Reference](../about-entity-reference.md)<br />
[Web API EntityType Reference](/power-apps/developer/data-platform/webapi/reference/entitytypes)
