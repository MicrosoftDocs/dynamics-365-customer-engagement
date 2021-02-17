---
title: "msdyn_paymentterm Entity Reference (Dynamics 365 Customer Engagement)| MicrosoftDocs"
description: "Includes schema information and supported messages for the msdyn_paymentterm entity."
ms.date: 04/02/2019
ms.service: "crm-online"
ms.topic: "reference"
ms.assetid: 3948cc48-07c8-7f60-0608-71c37158ad7c
author: "KumarVivek"
ms.author: "kvivek"
manager: "annbe"
search.audienceType: 
  - developer

---
# msdyn_paymentterm Entity Reference

Specify payment terms used for billing.

**Added by**: Field Service Solution


## Messages

|Message|Web API Operation|SDK Assembly|
|-|-|-|
|Assign|PATCH [*org URI*]/api/data/v9.0/msdyn_paymentterms(*msdyn_paymenttermid*)<br />[Update](/powerapps/developer/common-data-service/webapi/update-delete-entities-using-web-api#basic-update) `ownerid` property.|<xref:Microsoft.Crm.Sdk.Messages.AssignRequest>|
|Create|POST [*org URI*]/api/data/v9.0/msdyn_paymentterms<br />See [Create](/powerapps/developer/common-data-service/webapi/create-entity-web-api)|<xref:Microsoft.Xrm.Sdk.Messages.CreateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Create*>|
|Delete|DELETE [*org URI*]/api/data/v9.0/msdyn_paymentterms(*msdyn_paymenttermid*)<br />See [Delete](/powerapps/developer/common-data-service/webapi/update-delete-entities-using-web-api#basic-delete)|<xref:Microsoft.Xrm.Sdk.Messages.DeleteRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Delete*>|
|GrantAccess|<xref href="Microsoft.Dynamics.CRM.GrantAccess?text=GrantAccess Action" />|<xref:Microsoft.Crm.Sdk.Messages.GrantAccessRequest>|
|IsValidStateTransition|<xref href="Microsoft.Dynamics.CRM.IsValidStateTransition?text=IsValidStateTransition Function" />|<xref:Microsoft.Crm.Sdk.Messages.IsValidStateTransitionRequest>|
|ModifyAccess|<xref href="Microsoft.Dynamics.CRM.ModifyAccess?text=ModifyAccess Action" />|<xref:Microsoft.Crm.Sdk.Messages.ModifyAccessRequest>|
|Retrieve|GET [*org URI*]/api/data/v9.0/msdyn_paymentterms(*msdyn_paymenttermid*)<br />See [Retrieve](/powerapps/developer/common-data-service/webapi/retrieve-entity-using-web-api)|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Retrieve*>|
|RetrieveMultiple|GET [*org URI*]/api/data/v9.0/msdyn_paymentterms<br />See [Query Data](/powerapps/developer/common-data-service/webapi/query-data-web-api)|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveMultipleRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.RetrieveMultiple*>|
|RetrievePrincipalAccess|<xref href="Microsoft.Dynamics.CRM.RetrievePrincipalAccess?text=RetrievePrincipalAccess Function" />|<xref:Microsoft.Crm.Sdk.Messages.RetrievePrincipalAccessRequest>|
|RetrieveSharedPrincipalsAndAccess|<xref href="Microsoft.Dynamics.CRM.RetrieveSharedPrincipalsAndAccess?text=RetrieveSharedPrincipalsAndAccess Function" />|<xref:Microsoft.Crm.Sdk.Messages.RetrieveSharedPrincipalsAndAccessRequest>|
|RevokeAccess|<xref href="Microsoft.Dynamics.CRM.RevokeAccess?text=RevokeAccess Action" />|<xref:Microsoft.Crm.Sdk.Messages.RevokeAccessRequest>|
|SetState|PATCH [*org URI*]/api/data/v9.0/msdyn_paymentterms(*msdyn_paymenttermid*)<br />[Update](/powerapps/developer/common-data-service/webapi/update-delete-entities-using-web-api#basic-update) `statecode` and `statuscode` properties.|<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|
|Update|PATCH [*org URI*]/api/data/v9.0/msdyn_paymentterms(*msdyn_paymenttermid*)<br />See [Update](/powerapps/developer/common-data-service/webapi/update-delete-entities-using-web-api#basic-update)|<xref:Microsoft.Xrm.Sdk.Messages.UpdateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Update*>|

## Entity Properties

|Property|Value|
|--------|-----|
|CollectionSchemaName|msdyn_paymentterms|
|DisplayCollectionName|Payment Terms|
|DisplayName|Payment Term|
|EntitySetName|msdyn_paymentterms|
|IsBPFEntity|False|
|LogicalCollectionName|msdyn_paymentterms|
|LogicalName|msdyn_paymentterm|
|OwnershipType|UserOwned|
|PrimaryIdAttribute|msdyn_paymenttermid|
|PrimaryNameAttribute|msdyn_name|
|SchemaName|msdyn_paymentterm|

<a name="writable-attributes"></a>

## Writable attributes

These attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [msdyn_Days](#BKMK_msdyn_Days)
- [msdyn_name](#BKMK_msdyn_name)
- [msdyn_paymenttermId](#BKMK_msdyn_paymenttermId)
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


### <a name="BKMK_msdyn_Days"></a> msdyn_Days

|Property|Value|
|--------|-----|
|Description||
|DisplayName|Days|
|Format|None|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_days|
|MaxValue|2147483647|
|MinValue|0|
|RequiredLevel|ApplicationRequired|
|Type|Integer|


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


### <a name="BKMK_msdyn_paymenttermId"></a> msdyn_paymenttermId

|Property|Value|
|--------|-----|
|Description|Shows the entity instances.|
|DisplayName|Payment Term|
|IsValidForForm|False|
|IsValidForRead|True|
|IsValidForUpdate|False|
|LogicalName|msdyn_paymenttermid|
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

**Added by**: Active Solution Solution

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

**Added by**: Active Solution Solution

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
|Description|Status of the Payment Term|
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
|Description|Reason for the status of the Payment Term|
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

**Added by**: Active Solution Solution

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

**Added by**: Active Solution Solution

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

**Added by**: Active Solution Solution

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

**Added by**: Active Solution Solution

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

**Added by**: Active Solution Solution

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

**Added by**: Active Solution Solution

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

**Added by**: Active Solution Solution

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

**Added by**: Active Solution Solution

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

**Added by**: Active Solution Solution

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

**Added by**: Active Solution Solution

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

**Added by**: Active Solution Solution

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

**Added by**: Active Solution Solution

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

**Added by**: Active Solution Solution

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

**Added by**: Active Solution Solution

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

**Added by**: Active Solution Solution

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

**Added by**: Active Solution Solution

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

**Added by**: Active Solution Solution

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

**Added by**: Active Solution Solution

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

- [msdyn_paymentterm_ActivityPointers](#BKMK_msdyn_paymentterm_ActivityPointers)
- [msdyn_paymentterm_msdyn_bookingalerts](#BKMK_msdyn_paymentterm_msdyn_bookingalerts)
- [msdyn_paymentterm_msdyn_approvals](#BKMK_msdyn_paymentterm_msdyn_approvals)
- [msdyn_paymentterm_SyncErrors](#BKMK_msdyn_paymentterm_SyncErrors)
- [msdyn_paymentterm_DuplicateMatchingRecord](#BKMK_msdyn_paymentterm_DuplicateMatchingRecord)
- [msdyn_paymentterm_DuplicateBaseRecord](#BKMK_msdyn_paymentterm_DuplicateBaseRecord)
- [msdyn_paymentterm_AsyncOperations](#BKMK_msdyn_paymentterm_AsyncOperations)
- [msdyn_paymentterm_MailboxTrackingFolders](#BKMK_msdyn_paymentterm_MailboxTrackingFolders)
- [msdyn_paymentterm_ProcessSession](#BKMK_msdyn_paymentterm_ProcessSession)
- [msdyn_paymentterm_BulkDeleteFailures](#BKMK_msdyn_paymentterm_BulkDeleteFailures)
- [msdyn_paymentterm_PrincipalObjectAttributeAccesses](#BKMK_msdyn_paymentterm_PrincipalObjectAttributeAccesses)
- [msdyn_paymentterm_Appointments](#BKMK_msdyn_paymentterm_Appointments)
- [msdyn_paymentterm_Emails](#BKMK_msdyn_paymentterm_Emails)
- [msdyn_paymentterm_Faxes](#BKMK_msdyn_paymentterm_Faxes)
- [msdyn_paymentterm_Letters](#BKMK_msdyn_paymentterm_Letters)
- [msdyn_paymentterm_PhoneCalls](#BKMK_msdyn_paymentterm_PhoneCalls)
- [msdyn_paymentterm_Tasks](#BKMK_msdyn_paymentterm_Tasks)
- [msdyn_paymentterm_RecurringAppointmentMasters](#BKMK_msdyn_paymentterm_RecurringAppointmentMasters)
- [msdyn_paymentterm_SocialActivities](#BKMK_msdyn_paymentterm_SocialActivities)
- [msdyn_paymentterm_connections1](#BKMK_msdyn_paymentterm_connections1)
- [msdyn_paymentterm_connections2](#BKMK_msdyn_paymentterm_connections2)
- [msdyn_paymentterm_Annotations](#BKMK_msdyn_paymentterm_Annotations)
- [msdyn_paymentterm_ServiceAppointments](#BKMK_msdyn_paymentterm_ServiceAppointments)
- [msdyn_msdyn_paymentterm_msdyn_purchaseorder_PaymentTerm](#BKMK_msdyn_msdyn_paymentterm_msdyn_purchaseorder_PaymentTerm)
- [msdyn_msdyn_paymentterm_msdyn_purchaseorderbill_PaymentTerm](#BKMK_msdyn_msdyn_paymentterm_msdyn_purchaseorderbill_PaymentTerm)


### <a name="BKMK_msdyn_paymentterm_ActivityPointers"></a> msdyn_paymentterm_ActivityPointers

**Added by**: System Solution Solution

Same as activitypointer entity [msdyn_paymentterm_ActivityPointers](activitypointer.md#BKMK_msdyn_paymentterm_ActivityPointers) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|activitypointer|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_paymentterm_ActivityPointers|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: RemoveLink<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_paymentterm_msdyn_bookingalerts"></a> msdyn_paymentterm_msdyn_bookingalerts

**Added by**: Active Solution Solution

Same as msdyn_bookingalert entity [msdyn_paymentterm_msdyn_bookingalerts](msdyn_bookingalert.md#BKMK_msdyn_paymentterm_msdyn_bookingalerts) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_bookingalert|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_paymentterm_msdyn_bookingalerts|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: Cascade<br />Share: Cascade<br />Unshare: Cascade|


### <a name="BKMK_msdyn_paymentterm_msdyn_approvals"></a> msdyn_paymentterm_msdyn_approvals

**Added by**: Active Solution Solution

Same as msdyn_approval entity [msdyn_paymentterm_msdyn_approvals](msdyn_approval.md#BKMK_msdyn_paymentterm_msdyn_approvals) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_approval|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_paymentterm_msdyn_approvals|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: Cascade<br />Share: Cascade<br />Unshare: Cascade|


### <a name="BKMK_msdyn_paymentterm_SyncErrors"></a> msdyn_paymentterm_SyncErrors

**Added by**: System Solution Solution

Same as syncerror entity [msdyn_paymentterm_SyncErrors](syncerror.md#BKMK_msdyn_paymentterm_SyncErrors) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|syncerror|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_paymentterm_SyncErrors|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_paymentterm_DuplicateMatchingRecord"></a> msdyn_paymentterm_DuplicateMatchingRecord

**Added by**: System Solution Solution

Same as duplicaterecord entity [msdyn_paymentterm_DuplicateMatchingRecord](duplicaterecord.md#BKMK_msdyn_paymentterm_DuplicateMatchingRecord) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|duplicaterecord|
|ReferencingAttribute|duplicaterecordid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_paymentterm_DuplicateMatchingRecord|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_paymentterm_DuplicateBaseRecord"></a> msdyn_paymentterm_DuplicateBaseRecord

**Added by**: System Solution Solution

Same as duplicaterecord entity [msdyn_paymentterm_DuplicateBaseRecord](duplicaterecord.md#BKMK_msdyn_paymentterm_DuplicateBaseRecord) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|duplicaterecord|
|ReferencingAttribute|baserecordid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_paymentterm_DuplicateBaseRecord|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_paymentterm_AsyncOperations"></a> msdyn_paymentterm_AsyncOperations

**Added by**: System Solution Solution

Same as asyncoperation entity [msdyn_paymentterm_AsyncOperations](asyncoperation.md#BKMK_msdyn_paymentterm_AsyncOperations) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|asyncoperation|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_paymentterm_AsyncOperations|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_paymentterm_MailboxTrackingFolders"></a> msdyn_paymentterm_MailboxTrackingFolders

**Added by**: System Solution Solution

Same as mailboxtrackingfolder entity [msdyn_paymentterm_MailboxTrackingFolders](mailboxtrackingfolder.md#BKMK_msdyn_paymentterm_MailboxTrackingFolders) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|mailboxtrackingfolder|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_paymentterm_MailboxTrackingFolders|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_paymentterm_ProcessSession"></a> msdyn_paymentterm_ProcessSession

**Added by**: System Solution Solution

Same as processsession entity [msdyn_paymentterm_ProcessSession](processsession.md#BKMK_msdyn_paymentterm_ProcessSession) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|processsession|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_paymentterm_ProcessSession|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_paymentterm_BulkDeleteFailures"></a> msdyn_paymentterm_BulkDeleteFailures

**Added by**: System Solution Solution

Same as bulkdeletefailure entity [msdyn_paymentterm_BulkDeleteFailures](bulkdeletefailure.md#BKMK_msdyn_paymentterm_BulkDeleteFailures) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|bulkdeletefailure|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_paymentterm_BulkDeleteFailures|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_paymentterm_PrincipalObjectAttributeAccesses"></a> msdyn_paymentterm_PrincipalObjectAttributeAccesses

**Added by**: System Solution Solution

Same as principalobjectattributeaccess entity [msdyn_paymentterm_PrincipalObjectAttributeAccesses](principalobjectattributeaccess.md#BKMK_msdyn_paymentterm_PrincipalObjectAttributeAccesses) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|principalobjectattributeaccess|
|ReferencingAttribute|objectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_paymentterm_PrincipalObjectAttributeAccesses|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_paymentterm_Appointments"></a> msdyn_paymentterm_Appointments

**Added by**: System Solution Solution

Same as appointment entity [msdyn_paymentterm_Appointments](appointment.md#BKMK_msdyn_paymentterm_Appointments) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|appointment|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_paymentterm_Appointments|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: Cascade<br />Share: Cascade<br />Unshare: Cascade|


### <a name="BKMK_msdyn_paymentterm_Emails"></a> msdyn_paymentterm_Emails

**Added by**: System Solution Solution

Same as email entity [msdyn_paymentterm_Emails](email.md#BKMK_msdyn_paymentterm_Emails) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|email|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_paymentterm_Emails|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: Cascade<br />Share: Cascade<br />Unshare: Cascade|


### <a name="BKMK_msdyn_paymentterm_Faxes"></a> msdyn_paymentterm_Faxes

**Added by**: System Solution Solution

Same as fax entity [msdyn_paymentterm_Faxes](fax.md#BKMK_msdyn_paymentterm_Faxes) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|fax|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_paymentterm_Faxes|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: Cascade<br />Share: Cascade<br />Unshare: Cascade|


### <a name="BKMK_msdyn_paymentterm_Letters"></a> msdyn_paymentterm_Letters

**Added by**: System Solution Solution

Same as letter entity [msdyn_paymentterm_Letters](letter.md#BKMK_msdyn_paymentterm_Letters) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|letter|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_paymentterm_Letters|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: Cascade<br />Share: Cascade<br />Unshare: Cascade|


### <a name="BKMK_msdyn_paymentterm_PhoneCalls"></a> msdyn_paymentterm_PhoneCalls

**Added by**: System Solution Solution

Same as phonecall entity [msdyn_paymentterm_PhoneCalls](phonecall.md#BKMK_msdyn_paymentterm_PhoneCalls) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|phonecall|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_paymentterm_PhoneCalls|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: Cascade<br />Share: Cascade<br />Unshare: Cascade|


### <a name="BKMK_msdyn_paymentterm_Tasks"></a> msdyn_paymentterm_Tasks

**Added by**: System Solution Solution

Same as task entity [msdyn_paymentterm_Tasks](task.md#BKMK_msdyn_paymentterm_Tasks) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|task|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_paymentterm_Tasks|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: Cascade<br />Share: Cascade<br />Unshare: Cascade|


### <a name="BKMK_msdyn_paymentterm_RecurringAppointmentMasters"></a> msdyn_paymentterm_RecurringAppointmentMasters

**Added by**: System Solution Solution

Same as recurringappointmentmaster entity [msdyn_paymentterm_RecurringAppointmentMasters](recurringappointmentmaster.md#BKMK_msdyn_paymentterm_RecurringAppointmentMasters) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|recurringappointmentmaster|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_paymentterm_RecurringAppointmentMasters|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: Cascade<br />Share: Cascade<br />Unshare: Cascade|


### <a name="BKMK_msdyn_paymentterm_SocialActivities"></a> msdyn_paymentterm_SocialActivities

**Added by**: System Solution Solution

Same as socialactivity entity [msdyn_paymentterm_SocialActivities](socialactivity.md#BKMK_msdyn_paymentterm_SocialActivities) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|socialactivity|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_paymentterm_SocialActivities|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: Cascade<br />Share: Cascade<br />Unshare: Cascade|


### <a name="BKMK_msdyn_paymentterm_connections1"></a> msdyn_paymentterm_connections1

**Added by**: System Solution Solution

Same as connection entity [msdyn_paymentterm_connections1](connection.md#BKMK_msdyn_paymentterm_connections1) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|connection|
|ReferencingAttribute|record1id|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_paymentterm_connections1|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Details<br />Label: <br />Order: 100|
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_paymentterm_connections2"></a> msdyn_paymentterm_connections2

**Added by**: System Solution Solution

Same as connection entity [msdyn_paymentterm_connections2](connection.md#BKMK_msdyn_paymentterm_connections2) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|connection|
|ReferencingAttribute|record2id|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_paymentterm_connections2|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_paymentterm_Annotations"></a> msdyn_paymentterm_Annotations

**Added by**: System Solution Solution

Same as annotation entity [msdyn_paymentterm_Annotations](annotation.md#BKMK_msdyn_paymentterm_Annotations) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|annotation|
|ReferencingAttribute|objectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_paymentterm_Annotations|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: Cascade<br />Share: Cascade<br />Unshare: Cascade|


### <a name="BKMK_msdyn_paymentterm_ServiceAppointments"></a> msdyn_paymentterm_ServiceAppointments

**Added by**: Service Solution

Same as serviceappointment entity [msdyn_paymentterm_ServiceAppointments](serviceappointment.md#BKMK_msdyn_paymentterm_ServiceAppointments) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|serviceappointment|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_paymentterm_ServiceAppointments|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: Cascade<br />Share: Cascade<br />Unshare: Cascade|


### <a name="BKMK_msdyn_msdyn_paymentterm_msdyn_purchaseorder_PaymentTerm"></a> msdyn_msdyn_paymentterm_msdyn_purchaseorder_PaymentTerm

Same as msdyn_purchaseorder entity [msdyn_msdyn_paymentterm_msdyn_purchaseorder_PaymentTerm](msdyn_purchaseorder.md#BKMK_msdyn_msdyn_paymentterm_msdyn_purchaseorder_PaymentTerm) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_purchaseorder|
|ReferencingAttribute|msdyn_paymentterm|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_msdyn_paymentterm_msdyn_purchaseorder_PaymentTerm|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Details<br />Label: <br />Order: 10000|
|CascadeConfiguration|Assign: NoCascade<br />Delete: RemoveLink<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_msdyn_paymentterm_msdyn_purchaseorderbill_PaymentTerm"></a> msdyn_msdyn_paymentterm_msdyn_purchaseorderbill_PaymentTerm

Same as msdyn_purchaseorderbill entity [msdyn_msdyn_paymentterm_msdyn_purchaseorderbill_PaymentTerm](msdyn_purchaseorderbill.md#BKMK_msdyn_msdyn_paymentterm_msdyn_purchaseorderbill_PaymentTerm) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_purchaseorderbill|
|ReferencingAttribute|msdyn_paymentterm|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_msdyn_paymentterm_msdyn_purchaseorderbill_PaymentTerm|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Details<br />Label: <br />Order: 10000|
|CascadeConfiguration|Assign: NoCascade<br />Delete: RemoveLink<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|

<a name="manytoone"></a>

## Many-To-One Relationships

Each Many-To-One relationship is defined by a corresponding One-To-Many relationship with the related entity. Listed by **SchemaName**.

- [lk_msdyn_paymentterm_createdby](#BKMK_lk_msdyn_paymentterm_createdby)
- [lk_msdyn_paymentterm_createdonbehalfby](#BKMK_lk_msdyn_paymentterm_createdonbehalfby)
- [lk_msdyn_paymentterm_modifiedby](#BKMK_lk_msdyn_paymentterm_modifiedby)
- [lk_msdyn_paymentterm_modifiedonbehalfby](#BKMK_lk_msdyn_paymentterm_modifiedonbehalfby)
- [user_msdyn_paymentterm](#BKMK_user_msdyn_paymentterm)
- [team_msdyn_paymentterm](#BKMK_team_msdyn_paymentterm)
- [business_unit_msdyn_paymentterm](#BKMK_business_unit_msdyn_paymentterm)


### <a name="BKMK_lk_msdyn_paymentterm_createdby"></a> lk_msdyn_paymentterm_createdby

**Added by**: System Solution Solution

See systemuser Entity [lk_msdyn_paymentterm_createdby](systemuser.md#BKMK_lk_msdyn_paymentterm_createdby) One-To-Many relationship.

### <a name="BKMK_lk_msdyn_paymentterm_createdonbehalfby"></a> lk_msdyn_paymentterm_createdonbehalfby

**Added by**: System Solution Solution

See systemuser Entity [lk_msdyn_paymentterm_createdonbehalfby](systemuser.md#BKMK_lk_msdyn_paymentterm_createdonbehalfby) One-To-Many relationship.

### <a name="BKMK_lk_msdyn_paymentterm_modifiedby"></a> lk_msdyn_paymentterm_modifiedby

**Added by**: System Solution Solution

See systemuser Entity [lk_msdyn_paymentterm_modifiedby](systemuser.md#BKMK_lk_msdyn_paymentterm_modifiedby) One-To-Many relationship.

### <a name="BKMK_lk_msdyn_paymentterm_modifiedonbehalfby"></a> lk_msdyn_paymentterm_modifiedonbehalfby

**Added by**: System Solution Solution

See systemuser Entity [lk_msdyn_paymentterm_modifiedonbehalfby](systemuser.md#BKMK_lk_msdyn_paymentterm_modifiedonbehalfby) One-To-Many relationship.

### <a name="BKMK_user_msdyn_paymentterm"></a> user_msdyn_paymentterm

**Added by**: System Solution Solution

See systemuser Entity [user_msdyn_paymentterm](systemuser.md#BKMK_user_msdyn_paymentterm) One-To-Many relationship.

### <a name="BKMK_team_msdyn_paymentterm"></a> team_msdyn_paymentterm

**Added by**: System Solution Solution

See team Entity [team_msdyn_paymentterm](team.md#BKMK_team_msdyn_paymentterm) One-To-Many relationship.

### <a name="BKMK_business_unit_msdyn_paymentterm"></a> business_unit_msdyn_paymentterm

**Added by**: System Solution Solution

See businessunit Entity [business_unit_msdyn_paymentterm](businessunit.md#BKMK_business_unit_msdyn_paymentterm) One-To-Many relationship.

### See also

[About the Entity Reference](../about-entity-reference.md)<br />
[Programming reference for Dynamics 365 Customer Engagement](../programming-reference.md)<br />
[Web API Reference](/dynamics365/customer-engagement/web-api/about)<br />
<xref href="Microsoft.Dynamics.CRM.msdyn_paymentterm?text=msdyn_paymentterm EntityType" />

[!INCLUDE[footer-include](../../../../includes/footer-banner.md)]