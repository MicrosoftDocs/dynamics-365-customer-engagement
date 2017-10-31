---
title: "msdyn_workorderresourcerestriction Entity Reference (Developer Guide for Dynamics 365 Customer Engagement)| MicrosoftDocs"
description: "Includes schema information and supported messages for the msdyn_workorderresourcerestriction entity."
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
# msdyn_workorderresourcerestriction Entity Reference

[!INCLUDE[](../../includes/cc_applies_to_update_9_0_0.md)]

This entity is deprecated.

**Added by**: Field Service Solution<br />

## Messages

|Message|Web API Operation|SDK Assembly|
|-|-|-|
|Assign|PATCH [*org URI*]/api/data/v9.0/msdyn_workorderresourcerestrictions(*msdyn_workorderresourcerestrictionid*)<br />[Update](../webapi/update-delete-entities-using-web-api.md#basic-update) `ownerid` property.|<xref:Microsoft.Crm.Sdk.Messages.AssignRequest>|
|Create|POST [*org URI*]/api/data/v9.0/msdyn_workorderresourcerestrictions<br />See [Create](../webapi/create-entity-web-api.md)|<xref:Microsoft.Xrm.Sdk.Messages.CreateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Create*>|
|Delete|DELETE [*org URI*]/api/data/v9.0/msdyn_workorderresourcerestrictions(*msdyn_workorderresourcerestrictionid*)<br />See [Delete](../webapi/update-delete-entities-using-web-api.md#basic-delete)|<xref:Microsoft.Xrm.Sdk.Messages.DeleteRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Delete*>|
|GrantAccess|<xref href="Microsoft.Dynamics.CRM.GrantAccess?text=GrantAccess Action" />|<xref:Microsoft.Crm.Sdk.Messages.GrantAccessRequest>|
|IsValidStateTransition|<xref href="Microsoft.Dynamics.CRM.IsValidStateTransition?text=IsValidStateTransition Function" />|<xref:Microsoft.Crm.Sdk.Messages.IsValidStateTransitionRequest>|
|ModifyAccess|<xref href="Microsoft.Dynamics.CRM.ModifyAccess?text=ModifyAccess Action" />|<xref:Microsoft.Crm.Sdk.Messages.ModifyAccessRequest>|
|Retrieve|GET [*org URI*]/api/data/v9.0/msdyn_workorderresourcerestrictions(*msdyn_workorderresourcerestrictionid*)<br />See [Retrieve](../webapi/retrieve-entity-using-web-api.md)|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Retrieve*>|
|RetrieveMultiple|GET [*org URI*]/api/data/v9.0/msdyn_workorderresourcerestrictions<br />See [Query Data](../webapi/query-data-web-api.md)|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveMultipleRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.RetrieveMultiple*>|
|RetrievePrincipalAccess|<xref href="Microsoft.Dynamics.CRM.RetrievePrincipalAccess?text=RetrievePrincipalAccess Function" />|<xref:Microsoft.Crm.Sdk.Messages.RetrievePrincipalAccessRequest>|
|RetrieveSharedPrincipalsAndAccess|<xref href="Microsoft.Dynamics.CRM.RetrieveSharedPrincipalsAndAccess?text=RetrieveSharedPrincipalsAndAccess Function" />|<xref:Microsoft.Crm.Sdk.Messages.RetrieveSharedPrincipalsAndAccessRequest>|
|RevokeAccess|<xref href="Microsoft.Dynamics.CRM.RevokeAccess?text=RevokeAccess Action" />|<xref:Microsoft.Crm.Sdk.Messages.RevokeAccessRequest>|
|SetState|PATCH [*org URI*]/api/data/v9.0/msdyn_workorderresourcerestrictions(*msdyn_workorderresourcerestrictionid*)<br />[Update](../webapi/update-delete-entities-using-web-api.md#basic-update) `statecode` and `statuscode` properties.|<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|
|Update|PATCH [*org URI*]/api/data/v9.0/msdyn_workorderresourcerestrictions(*msdyn_workorderresourcerestrictionid*)<br />See [Update](../webapi/update-delete-entities-using-web-api.md#basic-update)|<xref:Microsoft.Xrm.Sdk.Messages.UpdateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Update*>|

## Properties

**DisplayName**: Resource Restriction (Deprecated)<br />
**DisplayCollectionName**: Resource Restrictions (Deprecated)<br />
**SchemaName**: msdyn_workorderresourcerestriction<br />
**CollectionSchemaName**: msdyn_workorderresourcerestrictions<br />
**LogicalName**: msdyn_workorderresourcerestriction<br />
**LogicalCollectionName**: msdyn_workorderresourcerestrictions<br />
**EntitySetName**: msdyn_workorderresourcerestrictions<br />
**PrimaryIdAttribute**: msdyn_workorderresourcerestrictionid<br />
**PrimaryNameAttribute**: msdyn_name<br />
**OwnershipType**: UserOwned<br />
**IsBPFEntity**: False<br />
<a name="writable-attributes"></a>

## Writable attributes

These attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [msdyn_Account](#BKMK_msdyn_Account)
- [msdyn_Cascade](#BKMK_msdyn_Cascade)
- [msdyn_ExpirationDate](#BKMK_msdyn_ExpirationDate)
- [msdyn_name](#BKMK_msdyn_name)
- [msdyn_Resource](#BKMK_msdyn_Resource)
- [msdyn_WorkOrder](#BKMK_msdyn_WorkOrder)
- [msdyn_workorderresourcerestrictionId](#BKMK_msdyn_workorderresourcerestrictionId)
- [OverriddenCreatedOn](#BKMK_OverriddenCreatedOn)
- [OwnerId](#BKMK_OwnerId)
- [OwnerIdType](#BKMK_OwnerIdType)
- [statecode](#BKMK_statecode)
- [statuscode](#BKMK_statuscode)
- [TimeZoneRuleVersionNumber](#BKMK_TimeZoneRuleVersionNumber)
- [UTCConversionTimeZoneCode](#BKMK_UTCConversionTimeZoneCode)


### <a name="BKMK_ImportSequenceNumber"></a> ImportSequenceNumber

**Description**: Shows the sequence number of the import that created this record.<br />
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


### <a name="BKMK_msdyn_Account"></a> msdyn_Account

**Description**: <br />
**DisplayName**: Account<br />
**LogicalName**: msdyn_account<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: account


### <a name="BKMK_msdyn_Cascade"></a> msdyn_Cascade

**Description**: <br />
**DisplayName**: Cascade<br />
**LogicalName**: msdyn_cascade<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Boolean<br />
**Options**:

- **TrueOption Value**: 1 **Label**: Yes
- **FalseOption Value**: 0 **Label**: No

**DefaultValue**: False


### <a name="BKMK_msdyn_ExpirationDate"></a> msdyn_ExpirationDate

**Description**: <br />
**DisplayName**: Expiration Date<br />
**LogicalName**: msdyn_expirationdate<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: DateTime<br />
**DateTimeBehavior**: UserLocal<br />
**Format**: DateAndTime


### <a name="BKMK_msdyn_name"></a> msdyn_name

**Description**: Enter the name of the custom entity.<br />
**DisplayName**: Name<br />
**LogicalName**: msdyn_name<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_msdyn_Resource"></a> msdyn_Resource

**Description**: <br />
**DisplayName**: Resource<br />
**LogicalName**: msdyn_resource<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: ApplicationRequired<br />
**Type**: Lookup<br />
**Targets**: bookableresource


### <a name="BKMK_msdyn_WorkOrder"></a> msdyn_WorkOrder

**Description**: <br />
**DisplayName**: Work Order<br />
**LogicalName**: msdyn_workorder<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: msdyn_workorder


### <a name="BKMK_msdyn_workorderresourcerestrictionId"></a> msdyn_workorderresourcerestrictionId

**Description**: Shows the entity instances.<br />
**DisplayName**: Resource Restriction<br />
**LogicalName**: msdyn_workorderresourcerestrictionid<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: SystemRequired<br />
**IsValidForUpdate**: False<br />
**Type**: Uniqueidentifier<br />


### <a name="BKMK_OverriddenCreatedOn"></a> OverriddenCreatedOn

**Description**: Shows the date and time that the record was migrated.<br />
**DisplayName**: Record Created On<br />
**LogicalName**: overriddencreatedon<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**IsValidForUpdate**: False<br />
**Type**: DateTime<br />
**DateTimeBehavior**: UserLocal<br />
**Format**: DateOnly


### <a name="BKMK_OwnerId"></a> OwnerId

**Description**: Owner Id<br />
**DisplayName**: Owner<br />
**LogicalName**: ownerid<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: SystemRequired<br />
**Type**: Owner<br />
**Targets**: systemuser,team


### <a name="BKMK_OwnerIdType"></a> OwnerIdType

**Description**: Owner Id Type<br />
**DisplayName**: <br />
**LogicalName**: owneridtype<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: SystemRequired<br />
**Type**: EntityName<br />


### <a name="BKMK_statecode"></a> statecode

**Description**: Status of the Work Order Resource Restriction<br />
**DisplayName**: Status<br />
**LogicalName**: statecode<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: SystemRequired<br />
**IsValidForCreate**: False<br />
**Type**: State<br />
**Options**:

- **Value**: 0 **Label**: Active **DefaultStatus**: 1 **InvariantName**: Active
- **Value**: 1 **Label**: Inactive **DefaultStatus**: 2 **InvariantName**: Inactive



### <a name="BKMK_statuscode"></a> statuscode

**Description**: Reason for the status of the Work Order Resource Restriction<br />
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


### <a name="BKMK_UTCConversionTimeZoneCode"></a> UTCConversionTimeZoneCode

**Description**: Shows the time zone code that was in use when the record was created.<br />
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
- [msdyn_AccountName](#BKMK_msdyn_AccountName)
- [msdyn_AccountYomiName](#BKMK_msdyn_AccountYomiName)
- [msdyn_ResourceName](#BKMK_msdyn_ResourceName)
- [msdyn_WorkOrderName](#BKMK_msdyn_WorkOrderName)
- [OwnerIdName](#BKMK_OwnerIdName)
- [OwnerIdYomiName](#BKMK_OwnerIdYomiName)
- [OwningBusinessUnit](#BKMK_OwningBusinessUnit)
- [OwningTeam](#BKMK_OwningTeam)
- [OwningUser](#BKMK_OwningUser)
- [VersionNumber](#BKMK_VersionNumber)


### <a name="BKMK_CreatedBy"></a> CreatedBy

**Description**: Unique identifier of the user who created the record.<br />
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

**Description**: Shows the date and time when the record was created. The date and time are displayed in the time zone selected in Microsoft Dynamics 365 options.<br />
**DisplayName**: Created On<br />
**LogicalName**: createdon<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: DateTime<br />
**DateTimeBehavior**: UserLocal<br />
**Format**: DateAndTime


### <a name="BKMK_CreatedOnBehalfBy"></a> CreatedOnBehalfBy

**Description**: Shows who created the record on behalf of another user.<br />
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
**RequiredLevel**: SystemRequired<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_ModifiedBy"></a> ModifiedBy

**Description**: Unique identifier of the user who modified the record.<br />
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

**Description**: Shows the date and time when the record was last updated. The date and time are displayed in the time zone selected in Microsoft Dynamics 365 options.<br />
**DisplayName**: Modified On<br />
**LogicalName**: modifiedon<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: DateTime<br />
**DateTimeBehavior**: UserLocal<br />
**Format**: DateAndTime


### <a name="BKMK_ModifiedOnBehalfBy"></a> ModifiedOnBehalfBy

**Description**: Shows who last updated the record on behalf of another user.<br />
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
**RequiredLevel**: SystemRequired<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_msdyn_AccountName"></a> msdyn_AccountName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: msdyn_accountname<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 160


### <a name="BKMK_msdyn_AccountYomiName"></a> msdyn_AccountYomiName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: msdyn_accountyominame<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 160


### <a name="BKMK_msdyn_ResourceName"></a> msdyn_ResourceName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: msdyn_resourcename<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_msdyn_WorkOrderName"></a> msdyn_WorkOrderName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: msdyn_workordername<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_OwnerIdName"></a> OwnerIdName

**Description**: Name of the owner<br />
**DisplayName**: <br />
**LogicalName**: owneridname<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: SystemRequired<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_OwnerIdYomiName"></a> OwnerIdYomiName

**Description**: Yomi name of the owner<br />
**DisplayName**: <br />
**LogicalName**: owneridyominame<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: SystemRequired<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_OwningBusinessUnit"></a> OwningBusinessUnit

**Description**: Unique identifier for the business unit that owns the record<br />
**DisplayName**: Owning Business Unit<br />
**LogicalName**: owningbusinessunit<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: businessunit


### <a name="BKMK_OwningTeam"></a> OwningTeam

**Description**: Unique identifier for the team that owns the record.<br />
**DisplayName**: Owning Team<br />
**LogicalName**: owningteam<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: team


### <a name="BKMK_OwningUser"></a> OwningUser

**Description**: Unique identifier for the user that owns the record.<br />
**DisplayName**: Owning User<br />
**LogicalName**: owninguser<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: systemuser


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

- [msdyn_workorderresourcerestriction_ActivityPointers](#BKMK_msdyn_workorderresourcerestriction_ActivityPointers)
- [msdyn_workorderresourcerestriction_msdyn_approvals](#BKMK_msdyn_workorderresourcerestriction_msdyn_approvals)
- [msdyn_workorderresourcerestriction_msdyn_bookingalerts](#BKMK_msdyn_workorderresourcerestriction_msdyn_bookingalerts)
- [msdyn_workorderresourcerestriction_SyncErrors](#BKMK_msdyn_workorderresourcerestriction_SyncErrors)
- [msdyn_workorderresourcerestriction_DuplicateMatchingRecord](#BKMK_msdyn_workorderresourcerestriction_DuplicateMatchingRecord)
- [msdyn_workorderresourcerestriction_DuplicateBaseRecord](#BKMK_msdyn_workorderresourcerestriction_DuplicateBaseRecord)
- [msdyn_workorderresourcerestriction_AsyncOperations](#BKMK_msdyn_workorderresourcerestriction_AsyncOperations)
- [msdyn_workorderresourcerestriction_MailboxTrackingFolders](#BKMK_msdyn_workorderresourcerestriction_MailboxTrackingFolders)
- [msdyn_workorderresourcerestriction_UserEntityInstanceDatas](#BKMK_msdyn_workorderresourcerestriction_UserEntityInstanceDatas)
- [msdyn_workorderresourcerestriction_ProcessSession](#BKMK_msdyn_workorderresourcerestriction_ProcessSession)
- [msdyn_workorderresourcerestriction_BulkDeleteFailures](#BKMK_msdyn_workorderresourcerestriction_BulkDeleteFailures)
- [msdyn_workorderresourcerestriction_PrincipalObjectAttributeAccesses](#BKMK_msdyn_workorderresourcerestriction_PrincipalObjectAttributeAccesses)
- [msdyn_workorderresourcerestriction_Appointments](#BKMK_msdyn_workorderresourcerestriction_Appointments)
- [msdyn_workorderresourcerestriction_Emails](#BKMK_msdyn_workorderresourcerestriction_Emails)
- [msdyn_workorderresourcerestriction_Faxes](#BKMK_msdyn_workorderresourcerestriction_Faxes)
- [msdyn_workorderresourcerestriction_Letters](#BKMK_msdyn_workorderresourcerestriction_Letters)
- [msdyn_workorderresourcerestriction_PhoneCalls](#BKMK_msdyn_workorderresourcerestriction_PhoneCalls)
- [msdyn_workorderresourcerestriction_Tasks](#BKMK_msdyn_workorderresourcerestriction_Tasks)
- [msdyn_workorderresourcerestriction_RecurringAppointmentMasters](#BKMK_msdyn_workorderresourcerestriction_RecurringAppointmentMasters)
- [msdyn_workorderresourcerestriction_SocialActivities](#BKMK_msdyn_workorderresourcerestriction_SocialActivities)
- [msdyn_workorderresourcerestriction_connections1](#BKMK_msdyn_workorderresourcerestriction_connections1)
- [msdyn_workorderresourcerestriction_connections2](#BKMK_msdyn_workorderresourcerestriction_connections2)
- [msdyn_workorderresourcerestriction_Annotations](#BKMK_msdyn_workorderresourcerestriction_Annotations)
- [msdyn_workorderresourcerestriction_ServiceAppointments](#BKMK_msdyn_workorderresourcerestriction_ServiceAppointments)


### <a name="BKMK_msdyn_workorderresourcerestriction_ActivityPointers"></a> msdyn_workorderresourcerestriction_ActivityPointers

Same as activitypointer entity [msdyn_workorderresourcerestriction_ActivityPointers](activitypointer.md#BKMK_msdyn_workorderresourcerestriction_ActivityPointers) Many-To-One relationship.

**ReferencingEntity**: activitypointer<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_workorderresourcerestriction_ActivityPointers<br />
**AssociatedMenuConfiguration**:

- **Behavior**: UseCollectionName
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


### <a name="BKMK_msdyn_workorderresourcerestriction_msdyn_approvals"></a> msdyn_workorderresourcerestriction_msdyn_approvals

Same as msdyn_approval entity [msdyn_workorderresourcerestriction_msdyn_approvals](msdyn_approval.md#BKMK_msdyn_workorderresourcerestriction_msdyn_approvals) Many-To-One relationship.

**ReferencingEntity**: msdyn_approval<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_workorderresourcerestriction_msdyn_approvals<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: Cascade
- **Delete**: Cascade
- **Merge**: NoCascade
- **Reparent**: Cascade
- **Share**: Cascade
- **Unshare**: Cascade


### <a name="BKMK_msdyn_workorderresourcerestriction_msdyn_bookingalerts"></a> msdyn_workorderresourcerestriction_msdyn_bookingalerts

Same as msdyn_bookingalert entity [msdyn_workorderresourcerestriction_msdyn_bookingalerts](msdyn_bookingalert.md#BKMK_msdyn_workorderresourcerestriction_msdyn_bookingalerts) Many-To-One relationship.

**ReferencingEntity**: msdyn_bookingalert<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_workorderresourcerestriction_msdyn_bookingalerts<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: Cascade
- **Delete**: Cascade
- **Merge**: NoCascade
- **Reparent**: Cascade
- **Share**: Cascade
- **Unshare**: Cascade


### <a name="BKMK_msdyn_workorderresourcerestriction_SyncErrors"></a> msdyn_workorderresourcerestriction_SyncErrors

Same as syncerror entity [msdyn_workorderresourcerestriction_SyncErrors](syncerror.md#BKMK_msdyn_workorderresourcerestriction_SyncErrors) Many-To-One relationship.

**ReferencingEntity**: syncerror<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_workorderresourcerestriction_SyncErrors<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: Cascade
- **Delete**: Cascade
- **Merge**: NoCascade
- **Reparent**: Cascade
- **Share**: Cascade
- **Unshare**: Cascade


### <a name="BKMK_msdyn_workorderresourcerestriction_DuplicateMatchingRecord"></a> msdyn_workorderresourcerestriction_DuplicateMatchingRecord

Same as duplicaterecord entity [msdyn_workorderresourcerestriction_DuplicateMatchingRecord](duplicaterecord.md#BKMK_msdyn_workorderresourcerestriction_DuplicateMatchingRecord) Many-To-One relationship.

**ReferencingEntity**: duplicaterecord<br />
**ReferencingAttribute**: duplicaterecordid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_workorderresourcerestriction_DuplicateMatchingRecord<br />
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


### <a name="BKMK_msdyn_workorderresourcerestriction_DuplicateBaseRecord"></a> msdyn_workorderresourcerestriction_DuplicateBaseRecord

Same as duplicaterecord entity [msdyn_workorderresourcerestriction_DuplicateBaseRecord](duplicaterecord.md#BKMK_msdyn_workorderresourcerestriction_DuplicateBaseRecord) Many-To-One relationship.

**ReferencingEntity**: duplicaterecord<br />
**ReferencingAttribute**: baserecordid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_workorderresourcerestriction_DuplicateBaseRecord<br />
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


### <a name="BKMK_msdyn_workorderresourcerestriction_AsyncOperations"></a> msdyn_workorderresourcerestriction_AsyncOperations

Same as asyncoperation entity [msdyn_workorderresourcerestriction_AsyncOperations](asyncoperation.md#BKMK_msdyn_workorderresourcerestriction_AsyncOperations) Many-To-One relationship.

**ReferencingEntity**: asyncoperation<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_workorderresourcerestriction_AsyncOperations<br />
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


### <a name="BKMK_msdyn_workorderresourcerestriction_MailboxTrackingFolders"></a> msdyn_workorderresourcerestriction_MailboxTrackingFolders

Same as mailboxtrackingfolder entity [msdyn_workorderresourcerestriction_MailboxTrackingFolders](mailboxtrackingfolder.md#BKMK_msdyn_workorderresourcerestriction_MailboxTrackingFolders) Many-To-One relationship.

**ReferencingEntity**: mailboxtrackingfolder<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_workorderresourcerestriction_MailboxTrackingFolders<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: Cascade
- **Delete**: Cascade
- **Merge**: NoCascade
- **Reparent**: Cascade
- **Share**: Cascade
- **Unshare**: Cascade


### <a name="BKMK_msdyn_workorderresourcerestriction_UserEntityInstanceDatas"></a> msdyn_workorderresourcerestriction_UserEntityInstanceDatas

Same as userentityinstancedata entity [msdyn_workorderresourcerestriction_UserEntityInstanceDatas](userentityinstancedata.md#BKMK_msdyn_workorderresourcerestriction_UserEntityInstanceDatas) Many-To-One relationship.

**ReferencingEntity**: userentityinstancedata<br />
**ReferencingAttribute**: objectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_workorderresourcerestriction_UserEntityInstanceDatas<br />
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


### <a name="BKMK_msdyn_workorderresourcerestriction_ProcessSession"></a> msdyn_workorderresourcerestriction_ProcessSession

Same as processsession entity [msdyn_workorderresourcerestriction_ProcessSession](processsession.md#BKMK_msdyn_workorderresourcerestriction_ProcessSession) Many-To-One relationship.

**ReferencingEntity**: processsession<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_workorderresourcerestriction_ProcessSession<br />
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


### <a name="BKMK_msdyn_workorderresourcerestriction_BulkDeleteFailures"></a> msdyn_workorderresourcerestriction_BulkDeleteFailures

Same as bulkdeletefailure entity [msdyn_workorderresourcerestriction_BulkDeleteFailures](bulkdeletefailure.md#BKMK_msdyn_workorderresourcerestriction_BulkDeleteFailures) Many-To-One relationship.

**ReferencingEntity**: bulkdeletefailure<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_workorderresourcerestriction_BulkDeleteFailures<br />
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


### <a name="BKMK_msdyn_workorderresourcerestriction_PrincipalObjectAttributeAccesses"></a> msdyn_workorderresourcerestriction_PrincipalObjectAttributeAccesses

Same as principalobjectattributeaccess entity [msdyn_workorderresourcerestriction_PrincipalObjectAttributeAccesses](principalobjectattributeaccess.md#BKMK_msdyn_workorderresourcerestriction_PrincipalObjectAttributeAccesses) Many-To-One relationship.

**ReferencingEntity**: principalobjectattributeaccess<br />
**ReferencingAttribute**: objectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_workorderresourcerestriction_PrincipalObjectAttributeAccesses<br />
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


### <a name="BKMK_msdyn_workorderresourcerestriction_Appointments"></a> msdyn_workorderresourcerestriction_Appointments

Same as appointment entity [msdyn_workorderresourcerestriction_Appointments](appointment.md#BKMK_msdyn_workorderresourcerestriction_Appointments) Many-To-One relationship.

**ReferencingEntity**: appointment<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_workorderresourcerestriction_Appointments<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: Cascade
- **Delete**: Cascade
- **Merge**: NoCascade
- **Reparent**: Cascade
- **Share**: Cascade
- **Unshare**: Cascade


### <a name="BKMK_msdyn_workorderresourcerestriction_Emails"></a> msdyn_workorderresourcerestriction_Emails

Same as email entity [msdyn_workorderresourcerestriction_Emails](email.md#BKMK_msdyn_workorderresourcerestriction_Emails) Many-To-One relationship.

**ReferencingEntity**: email<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_workorderresourcerestriction_Emails<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: Cascade
- **Delete**: Cascade
- **Merge**: NoCascade
- **Reparent**: Cascade
- **Share**: Cascade
- **Unshare**: Cascade


### <a name="BKMK_msdyn_workorderresourcerestriction_Faxes"></a> msdyn_workorderresourcerestriction_Faxes

Same as fax entity [msdyn_workorderresourcerestriction_Faxes](fax.md#BKMK_msdyn_workorderresourcerestriction_Faxes) Many-To-One relationship.

**ReferencingEntity**: fax<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_workorderresourcerestriction_Faxes<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: Cascade
- **Delete**: Cascade
- **Merge**: NoCascade
- **Reparent**: Cascade
- **Share**: Cascade
- **Unshare**: Cascade


### <a name="BKMK_msdyn_workorderresourcerestriction_Letters"></a> msdyn_workorderresourcerestriction_Letters

Same as letter entity [msdyn_workorderresourcerestriction_Letters](letter.md#BKMK_msdyn_workorderresourcerestriction_Letters) Many-To-One relationship.

**ReferencingEntity**: letter<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_workorderresourcerestriction_Letters<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: Cascade
- **Delete**: Cascade
- **Merge**: NoCascade
- **Reparent**: Cascade
- **Share**: Cascade
- **Unshare**: Cascade


### <a name="BKMK_msdyn_workorderresourcerestriction_PhoneCalls"></a> msdyn_workorderresourcerestriction_PhoneCalls

Same as phonecall entity [msdyn_workorderresourcerestriction_PhoneCalls](phonecall.md#BKMK_msdyn_workorderresourcerestriction_PhoneCalls) Many-To-One relationship.

**ReferencingEntity**: phonecall<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_workorderresourcerestriction_PhoneCalls<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: Cascade
- **Delete**: Cascade
- **Merge**: NoCascade
- **Reparent**: Cascade
- **Share**: Cascade
- **Unshare**: Cascade


### <a name="BKMK_msdyn_workorderresourcerestriction_Tasks"></a> msdyn_workorderresourcerestriction_Tasks

Same as task entity [msdyn_workorderresourcerestriction_Tasks](task.md#BKMK_msdyn_workorderresourcerestriction_Tasks) Many-To-One relationship.

**ReferencingEntity**: task<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_workorderresourcerestriction_Tasks<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: Cascade
- **Delete**: Cascade
- **Merge**: NoCascade
- **Reparent**: Cascade
- **Share**: Cascade
- **Unshare**: Cascade


### <a name="BKMK_msdyn_workorderresourcerestriction_RecurringAppointmentMasters"></a> msdyn_workorderresourcerestriction_RecurringAppointmentMasters

Same as recurringappointmentmaster entity [msdyn_workorderresourcerestriction_RecurringAppointmentMasters](recurringappointmentmaster.md#BKMK_msdyn_workorderresourcerestriction_RecurringAppointmentMasters) Many-To-One relationship.

**ReferencingEntity**: recurringappointmentmaster<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_workorderresourcerestriction_RecurringAppointmentMasters<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: Cascade
- **Delete**: Cascade
- **Merge**: NoCascade
- **Reparent**: Cascade
- **Share**: Cascade
- **Unshare**: Cascade


### <a name="BKMK_msdyn_workorderresourcerestriction_SocialActivities"></a> msdyn_workorderresourcerestriction_SocialActivities

Same as socialactivity entity [msdyn_workorderresourcerestriction_SocialActivities](socialactivity.md#BKMK_msdyn_workorderresourcerestriction_SocialActivities) Many-To-One relationship.

**ReferencingEntity**: socialactivity<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_workorderresourcerestriction_SocialActivities<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: Cascade
- **Delete**: Cascade
- **Merge**: NoCascade
- **Reparent**: Cascade
- **Share**: Cascade
- **Unshare**: Cascade


### <a name="BKMK_msdyn_workorderresourcerestriction_connections1"></a> msdyn_workorderresourcerestriction_connections1

Same as connection entity [msdyn_workorderresourcerestriction_connections1](connection.md#BKMK_msdyn_workorderresourcerestriction_connections1) Many-To-One relationship.

**ReferencingEntity**: connection<br />
**ReferencingAttribute**: record1id<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_workorderresourcerestriction_connections1<br />
**AssociatedMenuConfiguration**:

- **Behavior**: UseCollectionName
- **Group**: Details
- **Label**: 
- **Order**: 100

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: Cascade
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_msdyn_workorderresourcerestriction_connections2"></a> msdyn_workorderresourcerestriction_connections2

Same as connection entity [msdyn_workorderresourcerestriction_connections2](connection.md#BKMK_msdyn_workorderresourcerestriction_connections2) Many-To-One relationship.

**ReferencingEntity**: connection<br />
**ReferencingAttribute**: record2id<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_workorderresourcerestriction_connections2<br />
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


### <a name="BKMK_msdyn_workorderresourcerestriction_Annotations"></a> msdyn_workorderresourcerestriction_Annotations

Same as annotation entity [msdyn_workorderresourcerestriction_Annotations](annotation.md#BKMK_msdyn_workorderresourcerestriction_Annotations) Many-To-One relationship.

**ReferencingEntity**: annotation<br />
**ReferencingAttribute**: objectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_workorderresourcerestriction_Annotations<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: Cascade
- **Delete**: Cascade
- **Merge**: NoCascade
- **Reparent**: Cascade
- **Share**: Cascade
- **Unshare**: Cascade


### <a name="BKMK_msdyn_workorderresourcerestriction_ServiceAppointments"></a> msdyn_workorderresourcerestriction_ServiceAppointments

Same as serviceappointment entity [msdyn_workorderresourcerestriction_ServiceAppointments](serviceappointment.md#BKMK_msdyn_workorderresourcerestriction_ServiceAppointments) Many-To-One relationship.

**ReferencingEntity**: serviceappointment<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_workorderresourcerestriction_ServiceAppointments<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: Cascade
- **Delete**: Cascade
- **Merge**: NoCascade
- **Reparent**: Cascade
- **Share**: Cascade
- **Unshare**: Cascade

<a name="manytoone"></a>

## Many-To-One Relationships

Each Many-To-One relationship is defined by a corresponding One-To-Many relationship with the related entity. Listed by **SchemaName**.

- [lk_msdyn_workorderresourcerestriction_createdby](#BKMK_lk_msdyn_workorderresourcerestriction_createdby)
- [lk_msdyn_workorderresourcerestriction_createdonbehalfby](#BKMK_lk_msdyn_workorderresourcerestriction_createdonbehalfby)
- [lk_msdyn_workorderresourcerestriction_modifiedby](#BKMK_lk_msdyn_workorderresourcerestriction_modifiedby)
- [lk_msdyn_workorderresourcerestriction_modifiedonbehalfby](#BKMK_lk_msdyn_workorderresourcerestriction_modifiedonbehalfby)
- [user_msdyn_workorderresourcerestriction](#BKMK_user_msdyn_workorderresourcerestriction)
- [team_msdyn_workorderresourcerestriction](#BKMK_team_msdyn_workorderresourcerestriction)
- [business_unit_msdyn_workorderresourcerestriction](#BKMK_business_unit_msdyn_workorderresourcerestriction)
- [msdyn_account_msdyn_workorderresourcerestriction_Account](#BKMK_msdyn_account_msdyn_workorderresourcerestriction_Account)
- [msdyn_bookableresource_msdyn_workorderresourcerestriction_Resource](#BKMK_msdyn_bookableresource_msdyn_workorderresourcerestriction_Resource)
- [msdyn_msdyn_workorder_msdyn_workorderresourcerestriction_WorkOrder](#BKMK_msdyn_msdyn_workorder_msdyn_workorderresourcerestriction_WorkOrder)


### <a name="BKMK_lk_msdyn_workorderresourcerestriction_createdby"></a> lk_msdyn_workorderresourcerestriction_createdby

See systemuser Entity [lk_msdyn_workorderresourcerestriction_createdby](systemuser.md#BKMK_lk_msdyn_workorderresourcerestriction_createdby) One-To-Many relationship.

### <a name="BKMK_lk_msdyn_workorderresourcerestriction_createdonbehalfby"></a> lk_msdyn_workorderresourcerestriction_createdonbehalfby

See systemuser Entity [lk_msdyn_workorderresourcerestriction_createdonbehalfby](systemuser.md#BKMK_lk_msdyn_workorderresourcerestriction_createdonbehalfby) One-To-Many relationship.

### <a name="BKMK_lk_msdyn_workorderresourcerestriction_modifiedby"></a> lk_msdyn_workorderresourcerestriction_modifiedby

See systemuser Entity [lk_msdyn_workorderresourcerestriction_modifiedby](systemuser.md#BKMK_lk_msdyn_workorderresourcerestriction_modifiedby) One-To-Many relationship.

### <a name="BKMK_lk_msdyn_workorderresourcerestriction_modifiedonbehalfby"></a> lk_msdyn_workorderresourcerestriction_modifiedonbehalfby

See systemuser Entity [lk_msdyn_workorderresourcerestriction_modifiedonbehalfby](systemuser.md#BKMK_lk_msdyn_workorderresourcerestriction_modifiedonbehalfby) One-To-Many relationship.

### <a name="BKMK_user_msdyn_workorderresourcerestriction"></a> user_msdyn_workorderresourcerestriction

See systemuser Entity [user_msdyn_workorderresourcerestriction](systemuser.md#BKMK_user_msdyn_workorderresourcerestriction) One-To-Many relationship.

### <a name="BKMK_team_msdyn_workorderresourcerestriction"></a> team_msdyn_workorderresourcerestriction

See team Entity [team_msdyn_workorderresourcerestriction](team.md#BKMK_team_msdyn_workorderresourcerestriction) One-To-Many relationship.

### <a name="BKMK_business_unit_msdyn_workorderresourcerestriction"></a> business_unit_msdyn_workorderresourcerestriction

See businessunit Entity [business_unit_msdyn_workorderresourcerestriction](businessunit.md#BKMK_business_unit_msdyn_workorderresourcerestriction) One-To-Many relationship.

### <a name="BKMK_msdyn_account_msdyn_workorderresourcerestriction_Account"></a> msdyn_account_msdyn_workorderresourcerestriction_Account

See account Entity [msdyn_account_msdyn_workorderresourcerestriction_Account](account.md#BKMK_msdyn_account_msdyn_workorderresourcerestriction_Account) One-To-Many relationship.

### <a name="BKMK_msdyn_bookableresource_msdyn_workorderresourcerestriction_Resource"></a> msdyn_bookableresource_msdyn_workorderresourcerestriction_Resource

See bookableresource Entity [msdyn_bookableresource_msdyn_workorderresourcerestriction_Resource](bookableresource.md#BKMK_msdyn_bookableresource_msdyn_workorderresourcerestriction_Resource) One-To-Many relationship.

### <a name="BKMK_msdyn_msdyn_workorder_msdyn_workorderresourcerestriction_WorkOrder"></a> msdyn_msdyn_workorder_msdyn_workorderresourcerestriction_WorkOrder

See msdyn_workorder Entity [msdyn_msdyn_workorder_msdyn_workorderresourcerestriction_WorkOrder](msdyn_workorder.md#BKMK_msdyn_msdyn_workorder_msdyn_workorderresourcerestriction_WorkOrder) One-To-Many relationship.

## See also

[About the Entity Reference](../about-entity-reference.md)<br />
[Programming reference for Dynamics 365 Customer Engagement](../programming-reference.md)<br />
[Web API Reference](/dynamics365/customer-engagement/web-api/about)<br />
<xref href="Microsoft.Dynamics.CRM.msdyn_workorderresourcerestriction?text=msdyn_workorderresourcerestriction EntityType" />