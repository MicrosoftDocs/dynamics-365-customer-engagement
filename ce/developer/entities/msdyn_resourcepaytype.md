---
title: "msdyn_resourcepaytype Entity Reference (Developer Guide for Dynamics 365 Customer Engagement)| MicrosoftDocs"
description: "Includes schema information and supported messages for the msdyn_resourcepaytype entity."
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
# msdyn_resourcepaytype Entity Reference

Pay Types of resources hourly rate to calculate the resource cost

**Added by**: Field Service Solution<br />

## Messages

|Message|Web API Operation|SDK Assembly|
|-|-|-|
|Assign|PATCH [*org URI*]/api/data/v9.0/msdyn_resourcepaytypes(*msdyn_resourcepaytypeid*)<br />[Update](../webapi/update-delete-entities-using-web-api.md#basic-update) `ownerid` property.|<xref:Microsoft.Crm.Sdk.Messages.AssignRequest>|
|Create|POST [*org URI*]/api/data/v9.0/msdyn_resourcepaytypes<br />See [Create](../webapi/create-entity-web-api.md)|<xref:Microsoft.Xrm.Sdk.Messages.CreateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Create*>|
|Delete|DELETE [*org URI*]/api/data/v9.0/msdyn_resourcepaytypes(*msdyn_resourcepaytypeid*)<br />See [Delete](../webapi/update-delete-entities-using-web-api.md#basic-delete)|<xref:Microsoft.Xrm.Sdk.Messages.DeleteRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Delete*>|
|GrantAccess|<xref href="Microsoft.Dynamics.CRM.GrantAccess?text=GrantAccess Action" />|<xref:Microsoft.Crm.Sdk.Messages.GrantAccessRequest>|
|IsValidStateTransition|<xref href="Microsoft.Dynamics.CRM.IsValidStateTransition?text=IsValidStateTransition Function" />|<xref:Microsoft.Crm.Sdk.Messages.IsValidStateTransitionRequest>|
|ModifyAccess|<xref href="Microsoft.Dynamics.CRM.ModifyAccess?text=ModifyAccess Action" />|<xref:Microsoft.Crm.Sdk.Messages.ModifyAccessRequest>|
|Retrieve|GET [*org URI*]/api/data/v9.0/msdyn_resourcepaytypes(*msdyn_resourcepaytypeid*)<br />See [Retrieve](../webapi/retrieve-entity-using-web-api.md)|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Retrieve*>|
|RetrieveMultiple|GET [*org URI*]/api/data/v9.0/msdyn_resourcepaytypes<br />See [Query Data](../webapi/query-data-web-api.md)|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveMultipleRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.RetrieveMultiple*>|
|RetrievePrincipalAccess|<xref href="Microsoft.Dynamics.CRM.RetrievePrincipalAccess?text=RetrievePrincipalAccess Function" />|<xref:Microsoft.Crm.Sdk.Messages.RetrievePrincipalAccessRequest>|
|RetrieveSharedPrincipalsAndAccess|<xref href="Microsoft.Dynamics.CRM.RetrieveSharedPrincipalsAndAccess?text=RetrieveSharedPrincipalsAndAccess Function" />|<xref:Microsoft.Crm.Sdk.Messages.RetrieveSharedPrincipalsAndAccessRequest>|
|RevokeAccess|<xref href="Microsoft.Dynamics.CRM.RevokeAccess?text=RevokeAccess Action" />|<xref:Microsoft.Crm.Sdk.Messages.RevokeAccessRequest>|
|SetState|PATCH [*org URI*]/api/data/v9.0/msdyn_resourcepaytypes(*msdyn_resourcepaytypeid*)<br />[Update](../webapi/update-delete-entities-using-web-api.md#basic-update) `statecode` and `statuscode` properties.|<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|
|Update|PATCH [*org URI*]/api/data/v9.0/msdyn_resourcepaytypes(*msdyn_resourcepaytypeid*)<br />See [Update](../webapi/update-delete-entities-using-web-api.md#basic-update)|<xref:Microsoft.Xrm.Sdk.Messages.UpdateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Update*>|

## Entity Properties

|Property|Value|
|--------|-----|
|CollectionSchemaName|msdyn_resourcepaytypes|
|DisplayCollectionName|Resource Pay Types|
|DisplayName|Resource Pay Type|
|EntitySetName|msdyn_resourcepaytypes|
|IsBPFEntity|False|
|LogicalCollectionName|msdyn_resourcepaytypes|
|LogicalName|msdyn_resourcepaytype|
|OwnershipType|UserOwned|
|PrimaryIdAttribute|msdyn_resourcepaytypeid|
|PrimaryNameAttribute|msdyn_name|
|SchemaName|msdyn_resourcepaytype|

<a name="writable-attributes"></a>

## Writable attributes

These attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [msdyn_HourlyMarkup](#BKMK_msdyn_HourlyMarkup)
- [msdyn_name](#BKMK_msdyn_name)
- [msdyn_resourcepaytypeId](#BKMK_msdyn_resourcepaytypeId)
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


### <a name="BKMK_msdyn_HourlyMarkup"></a> msdyn_HourlyMarkup

|Property|Value|
|--------|-----|
|Description|Enter the markup percentage on the resource hourly cost. Use a value greater than 100% to mark it up and a value less than 100% to mark it down.|
|DisplayName|Hourly Markup %|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_hourlymarkup|
|MaxValue|1000000000|
|MinValue|0|
|Precision|2|
|RequiredLevel|ApplicationRequired|
|Type|Double|


### <a name="BKMK_msdyn_name"></a> msdyn_name

|Property|Value|
|--------|-----|
|Description|Enter the resource pay type name.|
|DisplayName|Name|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_name|
|MaxLength|200|
|RequiredLevel|ApplicationRequired|
|Type|String|


### <a name="BKMK_msdyn_resourcepaytypeId"></a> msdyn_resourcepaytypeId

|Property|Value|
|--------|-----|
|Description|Shows the entity instances.|
|DisplayName|Resource Pay Type|
|IsValidForForm|False|
|IsValidForRead|True|
|IsValidForUpdate|False|
|LogicalName|msdyn_resourcepaytypeid|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|


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
|Description|Status of the Resource Pay Type|
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
|Description|Reason for the status of the Resource Pay Type|
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

- [msdyn_resourcepaytype_SyncErrors](#BKMK_msdyn_resourcepaytype_SyncErrors)
- [msdyn_resourcepaytype_AsyncOperations](#BKMK_msdyn_resourcepaytype_AsyncOperations)
- [msdyn_resourcepaytype_MailboxTrackingFolders](#BKMK_msdyn_resourcepaytype_MailboxTrackingFolders)
- [msdyn_resourcepaytype_UserEntityInstanceDatas](#BKMK_msdyn_resourcepaytype_UserEntityInstanceDatas)
- [msdyn_resourcepaytype_ProcessSession](#BKMK_msdyn_resourcepaytype_ProcessSession)
- [msdyn_resourcepaytype_BulkDeleteFailures](#BKMK_msdyn_resourcepaytype_BulkDeleteFailures)
- [msdyn_resourcepaytype_PrincipalObjectAttributeAccesses](#BKMK_msdyn_resourcepaytype_PrincipalObjectAttributeAccesses)
- [msdyn_resourcepaytype_Annotations](#BKMK_msdyn_resourcepaytype_Annotations)
- [msdyn_msdyn_resourcepaytype_msdyn_bookingjournal_PayType](#BKMK_msdyn_msdyn_resourcepaytype_msdyn_bookingjournal_PayType)
- [msdyn_msdyn_resourcepaytype_msdyn_fieldservicesetting_BreakPayType](#BKMK_msdyn_msdyn_resourcepaytype_msdyn_fieldservicesetting_BreakPayType)
- [msdyn_msdyn_resourcepaytype_msdyn_fieldservicesetting_BusinessClosurePayType](#BKMK_msdyn_msdyn_resourcepaytype_msdyn_fieldservicesetting_BusinessClosurePayType)
- [msdyn_msdyn_resourcepaytype_msdyn_fieldservicesetting_OvertimePayType](#BKMK_msdyn_msdyn_resourcepaytype_msdyn_fieldservicesetting_OvertimePayType)
- [msdyn_msdyn_resourcepaytype_msdyn_fieldservicesetting_TravelPayType](#BKMK_msdyn_msdyn_resourcepaytype_msdyn_fieldservicesetting_TravelPayType)
- [msdyn_msdyn_resourcepaytype_msdyn_fieldservicesetting_WorkPayType](#BKMK_msdyn_msdyn_resourcepaytype_msdyn_fieldservicesetting_WorkPayType)


### <a name="BKMK_msdyn_resourcepaytype_SyncErrors"></a> msdyn_resourcepaytype_SyncErrors

Same as syncerror entity [msdyn_resourcepaytype_SyncErrors](syncerror.md#BKMK_msdyn_resourcepaytype_SyncErrors) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|syncerror|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_resourcepaytype_SyncErrors|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: Cascade<br />Share: Cascade<br />Unshare: Cascade|


### <a name="BKMK_msdyn_resourcepaytype_AsyncOperations"></a> msdyn_resourcepaytype_AsyncOperations

Same as asyncoperation entity [msdyn_resourcepaytype_AsyncOperations](asyncoperation.md#BKMK_msdyn_resourcepaytype_AsyncOperations) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|asyncoperation|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_resourcepaytype_AsyncOperations|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_resourcepaytype_MailboxTrackingFolders"></a> msdyn_resourcepaytype_MailboxTrackingFolders

Same as mailboxtrackingfolder entity [msdyn_resourcepaytype_MailboxTrackingFolders](mailboxtrackingfolder.md#BKMK_msdyn_resourcepaytype_MailboxTrackingFolders) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|mailboxtrackingfolder|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_resourcepaytype_MailboxTrackingFolders|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: Cascade<br />Share: Cascade<br />Unshare: Cascade|


### <a name="BKMK_msdyn_resourcepaytype_UserEntityInstanceDatas"></a> msdyn_resourcepaytype_UserEntityInstanceDatas

Same as userentityinstancedata entity [msdyn_resourcepaytype_UserEntityInstanceDatas](userentityinstancedata.md#BKMK_msdyn_resourcepaytype_UserEntityInstanceDatas) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|userentityinstancedata|
|ReferencingAttribute|objectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_resourcepaytype_UserEntityInstanceDatas|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_resourcepaytype_ProcessSession"></a> msdyn_resourcepaytype_ProcessSession

Same as processsession entity [msdyn_resourcepaytype_ProcessSession](processsession.md#BKMK_msdyn_resourcepaytype_ProcessSession) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|processsession|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_resourcepaytype_ProcessSession|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_resourcepaytype_BulkDeleteFailures"></a> msdyn_resourcepaytype_BulkDeleteFailures

Same as bulkdeletefailure entity [msdyn_resourcepaytype_BulkDeleteFailures](bulkdeletefailure.md#BKMK_msdyn_resourcepaytype_BulkDeleteFailures) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|bulkdeletefailure|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_resourcepaytype_BulkDeleteFailures|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_resourcepaytype_PrincipalObjectAttributeAccesses"></a> msdyn_resourcepaytype_PrincipalObjectAttributeAccesses

Same as principalobjectattributeaccess entity [msdyn_resourcepaytype_PrincipalObjectAttributeAccesses](principalobjectattributeaccess.md#BKMK_msdyn_resourcepaytype_PrincipalObjectAttributeAccesses) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|principalobjectattributeaccess|
|ReferencingAttribute|objectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_resourcepaytype_PrincipalObjectAttributeAccesses|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_resourcepaytype_Annotations"></a> msdyn_resourcepaytype_Annotations

Same as annotation entity [msdyn_resourcepaytype_Annotations](annotation.md#BKMK_msdyn_resourcepaytype_Annotations) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|annotation|
|ReferencingAttribute|objectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_resourcepaytype_Annotations|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: Cascade<br />Share: Cascade<br />Unshare: Cascade|


### <a name="BKMK_msdyn_msdyn_resourcepaytype_msdyn_bookingjournal_PayType"></a> msdyn_msdyn_resourcepaytype_msdyn_bookingjournal_PayType

Same as msdyn_bookingjournal entity [msdyn_msdyn_resourcepaytype_msdyn_bookingjournal_PayType](msdyn_bookingjournal.md#BKMK_msdyn_msdyn_resourcepaytype_msdyn_bookingjournal_PayType) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_bookingjournal|
|ReferencingAttribute|msdyn_paytype|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_msdyn_resourcepaytype_msdyn_bookingjournal_PayType|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Details<br />Label: <br />Order: 10000|
|CascadeConfiguration|Assign: NoCascade<br />Delete: Restrict<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_msdyn_resourcepaytype_msdyn_fieldservicesetting_BreakPayType"></a> msdyn_msdyn_resourcepaytype_msdyn_fieldservicesetting_BreakPayType

Same as msdyn_fieldservicesetting entity [msdyn_msdyn_resourcepaytype_msdyn_fieldservicesetting_BreakPayType](msdyn_fieldservicesetting.md#BKMK_msdyn_msdyn_resourcepaytype_msdyn_fieldservicesetting_BreakPayType) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_fieldservicesetting|
|ReferencingAttribute|msdyn_breakpaytype|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_msdyn_resourcepaytype_msdyn_fieldservicesetting_BreakPayType|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Details<br />Label: <br />Order: 10000|
|CascadeConfiguration|Assign: NoCascade<br />Delete: RemoveLink<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_msdyn_resourcepaytype_msdyn_fieldservicesetting_BusinessClosurePayType"></a> msdyn_msdyn_resourcepaytype_msdyn_fieldservicesetting_BusinessClosurePayType

Same as msdyn_fieldservicesetting entity [msdyn_msdyn_resourcepaytype_msdyn_fieldservicesetting_BusinessClosurePayType](msdyn_fieldservicesetting.md#BKMK_msdyn_msdyn_resourcepaytype_msdyn_fieldservicesetting_BusinessClosurePayType) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_fieldservicesetting|
|ReferencingAttribute|msdyn_businessclosurepaytype|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_msdyn_resourcepaytype_msdyn_fieldservicesetting_BusinessClosurePayType|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Details<br />Label: <br />Order: 10000|
|CascadeConfiguration|Assign: NoCascade<br />Delete: Restrict<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_msdyn_resourcepaytype_msdyn_fieldservicesetting_OvertimePayType"></a> msdyn_msdyn_resourcepaytype_msdyn_fieldservicesetting_OvertimePayType

Same as msdyn_fieldservicesetting entity [msdyn_msdyn_resourcepaytype_msdyn_fieldservicesetting_OvertimePayType](msdyn_fieldservicesetting.md#BKMK_msdyn_msdyn_resourcepaytype_msdyn_fieldservicesetting_OvertimePayType) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_fieldservicesetting|
|ReferencingAttribute|msdyn_overtimepaytype|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_msdyn_resourcepaytype_msdyn_fieldservicesetting_OvertimePayType|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Details<br />Label: <br />Order: 10000|
|CascadeConfiguration|Assign: NoCascade<br />Delete: Restrict<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_msdyn_resourcepaytype_msdyn_fieldservicesetting_TravelPayType"></a> msdyn_msdyn_resourcepaytype_msdyn_fieldservicesetting_TravelPayType

Same as msdyn_fieldservicesetting entity [msdyn_msdyn_resourcepaytype_msdyn_fieldservicesetting_TravelPayType](msdyn_fieldservicesetting.md#BKMK_msdyn_msdyn_resourcepaytype_msdyn_fieldservicesetting_TravelPayType) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_fieldservicesetting|
|ReferencingAttribute|msdyn_travelpaytype|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_msdyn_resourcepaytype_msdyn_fieldservicesetting_TravelPayType|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Details<br />Label: <br />Order: 10000|
|CascadeConfiguration|Assign: NoCascade<br />Delete: RemoveLink<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_msdyn_resourcepaytype_msdyn_fieldservicesetting_WorkPayType"></a> msdyn_msdyn_resourcepaytype_msdyn_fieldservicesetting_WorkPayType

Same as msdyn_fieldservicesetting entity [msdyn_msdyn_resourcepaytype_msdyn_fieldservicesetting_WorkPayType](msdyn_fieldservicesetting.md#BKMK_msdyn_msdyn_resourcepaytype_msdyn_fieldservicesetting_WorkPayType) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_fieldservicesetting|
|ReferencingAttribute|msdyn_workpaytype|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_msdyn_resourcepaytype_msdyn_fieldservicesetting_WorkPayType|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Details<br />Label: <br />Order: 10000|
|CascadeConfiguration|Assign: NoCascade<br />Delete: Restrict<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|

<a name="manytoone"></a>

## Many-To-One Relationships

Each Many-To-One relationship is defined by a corresponding One-To-Many relationship with the related entity. Listed by **SchemaName**.

- [lk_msdyn_resourcepaytype_createdby](#BKMK_lk_msdyn_resourcepaytype_createdby)
- [lk_msdyn_resourcepaytype_createdonbehalfby](#BKMK_lk_msdyn_resourcepaytype_createdonbehalfby)
- [lk_msdyn_resourcepaytype_modifiedby](#BKMK_lk_msdyn_resourcepaytype_modifiedby)
- [lk_msdyn_resourcepaytype_modifiedonbehalfby](#BKMK_lk_msdyn_resourcepaytype_modifiedonbehalfby)
- [user_msdyn_resourcepaytype](#BKMK_user_msdyn_resourcepaytype)
- [team_msdyn_resourcepaytype](#BKMK_team_msdyn_resourcepaytype)
- [business_unit_msdyn_resourcepaytype](#BKMK_business_unit_msdyn_resourcepaytype)


### <a name="BKMK_lk_msdyn_resourcepaytype_createdby"></a> lk_msdyn_resourcepaytype_createdby

See systemuser Entity [lk_msdyn_resourcepaytype_createdby](systemuser.md#BKMK_lk_msdyn_resourcepaytype_createdby) One-To-Many relationship.

### <a name="BKMK_lk_msdyn_resourcepaytype_createdonbehalfby"></a> lk_msdyn_resourcepaytype_createdonbehalfby

See systemuser Entity [lk_msdyn_resourcepaytype_createdonbehalfby](systemuser.md#BKMK_lk_msdyn_resourcepaytype_createdonbehalfby) One-To-Many relationship.

### <a name="BKMK_lk_msdyn_resourcepaytype_modifiedby"></a> lk_msdyn_resourcepaytype_modifiedby

See systemuser Entity [lk_msdyn_resourcepaytype_modifiedby](systemuser.md#BKMK_lk_msdyn_resourcepaytype_modifiedby) One-To-Many relationship.

### <a name="BKMK_lk_msdyn_resourcepaytype_modifiedonbehalfby"></a> lk_msdyn_resourcepaytype_modifiedonbehalfby

See systemuser Entity [lk_msdyn_resourcepaytype_modifiedonbehalfby](systemuser.md#BKMK_lk_msdyn_resourcepaytype_modifiedonbehalfby) One-To-Many relationship.

### <a name="BKMK_user_msdyn_resourcepaytype"></a> user_msdyn_resourcepaytype

See systemuser Entity [user_msdyn_resourcepaytype](systemuser.md#BKMK_user_msdyn_resourcepaytype) One-To-Many relationship.

### <a name="BKMK_team_msdyn_resourcepaytype"></a> team_msdyn_resourcepaytype

See team Entity [team_msdyn_resourcepaytype](team.md#BKMK_team_msdyn_resourcepaytype) One-To-Many relationship.

### <a name="BKMK_business_unit_msdyn_resourcepaytype"></a> business_unit_msdyn_resourcepaytype

See businessunit Entity [business_unit_msdyn_resourcepaytype](businessunit.md#BKMK_business_unit_msdyn_resourcepaytype) One-To-Many relationship.

### See also

[About the Entity Reference](../about-entity-reference.md)<br />
[Programming reference for Dynamics 365 Customer Engagement](../programming-reference.md)<br />
[Web API Reference](/dynamics365/customer-engagement/web-api/about)<br />
<xref href="Microsoft.Dynamics.CRM.msdyn_resourcepaytype?text=msdyn_resourcepaytype EntityType" />