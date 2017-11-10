---
title: "CustomerOpportunityRole Entity Reference (Developer Guide for Dynamics 365 Customer Engagement)| MicrosoftDocs"
description: "Includes schema information and supported messages for the CustomerOpportunityRole entity."
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
# CustomerOpportunityRole Entity Reference

[!INCLUDE[](../../includes/cc_applies_to_update_9_0_0.md)]

Relationship between an account or contact and an opportunity.

**Added by**: Sales Solution<br />

## Messages

|Message|Web API Operation|SDK Assembly|
|-|-|-|
|Assign|PATCH [*org URI*]/api/data/v9.0/customeropportunityroles(*customeropportunityroleid*)<br />[Update](../webapi/update-delete-entities-using-web-api.md#basic-update) `ownerid` property.|<xref:Microsoft.Crm.Sdk.Messages.AssignRequest>|
|Create|POST [*org URI*]/api/data/v9.0/customeropportunityroles<br />See [Create](../webapi/create-entity-web-api.md)|<xref:Microsoft.Xrm.Sdk.Messages.CreateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Create*>|
|Delete|DELETE [*org URI*]/api/data/v9.0/customeropportunityroles(*customeropportunityroleid*)<br />See [Delete](../webapi/update-delete-entities-using-web-api.md#basic-delete)|<xref:Microsoft.Xrm.Sdk.Messages.DeleteRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Delete*>|
|GrantAccess|<xref href="Microsoft.Dynamics.CRM.GrantAccess?text=GrantAccess Action" />|<xref:Microsoft.Crm.Sdk.Messages.GrantAccessRequest>|
|ModifyAccess|<xref href="Microsoft.Dynamics.CRM.ModifyAccess?text=ModifyAccess Action" />|<xref:Microsoft.Crm.Sdk.Messages.ModifyAccessRequest>|
|Retrieve|GET [*org URI*]/api/data/v9.0/customeropportunityroles(*customeropportunityroleid*)<br />See [Retrieve](../webapi/retrieve-entity-using-web-api.md)|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Retrieve*>|
|RetrieveMultiple|GET [*org URI*]/api/data/v9.0/customeropportunityroles<br />See [Query Data](../webapi/query-data-web-api.md)|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveMultipleRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.RetrieveMultiple*>|
|RetrievePrincipalAccess|<xref href="Microsoft.Dynamics.CRM.RetrievePrincipalAccess?text=RetrievePrincipalAccess Function" />|<xref:Microsoft.Crm.Sdk.Messages.RetrievePrincipalAccessRequest>|
|RetrieveSharedPrincipalsAndAccess|<xref href="Microsoft.Dynamics.CRM.RetrieveSharedPrincipalsAndAccess?text=RetrieveSharedPrincipalsAndAccess Function" />|<xref:Microsoft.Crm.Sdk.Messages.RetrieveSharedPrincipalsAndAccessRequest>|
|RevokeAccess|<xref href="Microsoft.Dynamics.CRM.RevokeAccess?text=RevokeAccess Action" />|<xref:Microsoft.Crm.Sdk.Messages.RevokeAccessRequest>|
|Update|PATCH [*org URI*]/api/data/v9.0/customeropportunityroles(*customeropportunityroleid*)<br />See [Update](../webapi/update-delete-entities-using-web-api.md#basic-update)|<xref:Microsoft.Xrm.Sdk.Messages.UpdateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Update*>|

## Properties

**DisplayName**: Opportunity Relationship<br />
**DisplayCollectionName**: Opportunity Relationships<br />
**SchemaName**: CustomerOpportunityRole<br />
**CollectionSchemaName**: CustomerOpportunityRoles<br />
**LogicalName**: customeropportunityrole<br />
**LogicalCollectionName**: customeropportunityroles<br />
**EntitySetName**: customeropportunityroles<br />
**PrimaryIdAttribute**: customeropportunityroleid<br />
**PrimaryNameAttribute**: opportunityroleidname<br />
**OwnershipType**: UserOwned<br />
**IsBPFEntity**: False<br />
<a name="writable-attributes"></a>

## Writable attributes

These attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [CustomerId](#BKMK_CustomerId)
- [CustomerIdType](#BKMK_CustomerIdType)
- [CustomerOpportunityRoleId](#BKMK_CustomerOpportunityRoleId)
- [Description](#BKMK_Description)
- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [OpportunityId](#BKMK_OpportunityId)
- [OpportunityRoleId](#BKMK_OpportunityRoleId)
- [OverriddenCreatedOn](#BKMK_OverriddenCreatedOn)
- [OwnerId](#BKMK_OwnerId)
- [OwnerIdType](#BKMK_OwnerIdType)
- [TimeZoneRuleVersionNumber](#BKMK_TimeZoneRuleVersionNumber)
- [UTCConversionTimeZoneCode](#BKMK_UTCConversionTimeZoneCode)


### <a name="BKMK_CustomerId"></a> CustomerId

**Description**: Select the account or contact associated to the opportunity, such as a strategic partner, third-party vendor, or key decision maker.<br />
**DisplayName**: Customer<br />
**LogicalName**: customerid<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: SystemRequired<br />
**Type**: Customer<br />
**Targets**: account,contact


### <a name="BKMK_CustomerIdType"></a> CustomerIdType

**Description**: Type of the customer.<br />
**DisplayName**: Customer Type<br />
**LogicalName**: customeridtype<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: ApplicationRequired<br />
**Type**: EntityName<br />


### <a name="BKMK_CustomerOpportunityRoleId"></a> CustomerOpportunityRoleId

**Description**: Unique identifier of the opportunity relationship.<br />
**DisplayName**: Opportunity Relationship<br />
**LogicalName**: customeropportunityroleid<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: SystemRequired<br />
**IsValidForUpdate**: False<br />
**Type**: Uniqueidentifier<br />


### <a name="BKMK_Description"></a> Description

**Description**: Type additional information to describe the opportunity relationship, such as the length or quality of the relationship.<br />
**DisplayName**: Description<br />
**LogicalName**: description<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: TextArea<br />
**IsLocalizable**: False<br />
**MaxLength**: 500


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


### <a name="BKMK_OpportunityId"></a> OpportunityId

**Description**: Choose the opportunity that the specified account or contact is related to. The opportunity relationship will be displayed in the Relationships view on the selected opportunity.<br />
**DisplayName**: Opportunity<br />
**LogicalName**: opportunityid<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: SystemRequired<br />
**Type**: Lookup<br />
**Targets**: opportunity


### <a name="BKMK_OpportunityRoleId"></a> OpportunityRoleId

**Description**: Choose the role or nature of the relationship that the customer has with the opportunity. The field is read-only until a customer has been selected. Administrators can configure role values under Business Management in the Settings area.<br />
**DisplayName**: Customer Role<br />
**LogicalName**: opportunityroleid<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: relationshiprole


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


### <a name="BKMK_OwnerId"></a> OwnerId

**Description**: Owner Id<br />
**DisplayName**: Owner<br />
**LogicalName**: ownerid<br />
**IsValidForForm**: False<br />
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

- [CreatedBy](#BKMK_CreatedBy)
- [CreatedByName](#BKMK_CreatedByName)
- [CreatedByYomiName](#BKMK_CreatedByYomiName)
- [CreatedOn](#BKMK_CreatedOn)
- [CreatedOnBehalfBy](#BKMK_CreatedOnBehalfBy)
- [CreatedOnBehalfByName](#BKMK_CreatedOnBehalfByName)
- [CreatedOnBehalfByYomiName](#BKMK_CreatedOnBehalfByYomiName)
- [CustomerIdName](#BKMK_CustomerIdName)
- [CustomerIdYomiName](#BKMK_CustomerIdYomiName)
- [ModifiedBy](#BKMK_ModifiedBy)
- [ModifiedByName](#BKMK_ModifiedByName)
- [ModifiedByYomiName](#BKMK_ModifiedByYomiName)
- [ModifiedOn](#BKMK_ModifiedOn)
- [ModifiedOnBehalfBy](#BKMK_ModifiedOnBehalfBy)
- [ModifiedOnBehalfByName](#BKMK_ModifiedOnBehalfByName)
- [ModifiedOnBehalfByYomiName](#BKMK_ModifiedOnBehalfByYomiName)
- [OpportunityIdName](#BKMK_OpportunityIdName)
- [OpportunityRoleIdName](#BKMK_OpportunityRoleIdName)
- [OpportunityStateCode](#BKMK_OpportunityStateCode)
- [OpportunityStatusCode](#BKMK_OpportunityStatusCode)
- [OwnerIdName](#BKMK_OwnerIdName)
- [OwnerIdYomiName](#BKMK_OwnerIdYomiName)
- [OwningBusinessUnit](#BKMK_OwningBusinessUnit)
- [OwningTeam](#BKMK_OwningTeam)
- [OwningUser](#BKMK_OwningUser)
- [UniqueDscId](#BKMK_UniqueDscId)
- [VersionNumber](#BKMK_VersionNumber)


### <a name="BKMK_CreatedBy"></a> CreatedBy

**Description**: Shows who created the record.<br />
**DisplayName**: Created By<br />
**LogicalName**: createdby<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: systemuser


### <a name="BKMK_CreatedByName"></a> CreatedByName

**Description**: Name of the user who created the opportunity relationship.<br />
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
**RequiredLevel**: None<br />
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
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_CustomerIdName"></a> CustomerIdName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: customeridname<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: ApplicationRequired<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 160


### <a name="BKMK_CustomerIdYomiName"></a> CustomerIdYomiName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: customeridyominame<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: ApplicationRequired<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 450


### <a name="BKMK_ModifiedBy"></a> ModifiedBy

**Description**: Shows who last updated the record.<br />
**DisplayName**: Modified By<br />
**LogicalName**: modifiedby<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: systemuser


### <a name="BKMK_ModifiedByName"></a> ModifiedByName

**Description**: Name of the user who last modified the opportunity relationship.<br />
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
**RequiredLevel**: None<br />
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
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_OpportunityIdName"></a> OpportunityIdName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: opportunityidname<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_OpportunityRoleIdName"></a> OpportunityRoleIdName

**Description**: Name of the role the customer plays with the opportunity.<br />
**DisplayName**: <br />
**LogicalName**: opportunityroleidname<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: SystemRequired<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_OpportunityStateCode"></a> OpportunityStateCode

**Description**: Status of the opportunity.<br />
**DisplayName**: Opportunity Status<br />
**LogicalName**: opportunitystatecode<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: SystemRequired<br />
**Type**: Integer<br />
**Format**: None<br />
**MaxValue**: 1000000000<br />
**MinValue**: 0


### <a name="BKMK_OpportunityStatusCode"></a> OpportunityStatusCode

**Description**: Reason for the status of the opportunity.<br />
**DisplayName**: Opportunity Status Reason<br />
**LogicalName**: opportunitystatuscode<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: ApplicationRequired<br />
**Type**: Integer<br />
**Format**: None<br />
**MaxValue**: 1000000000<br />
**MinValue**: 0


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


### <a name="BKMK_UniqueDscId"></a> UniqueDscId

**Description**: For internal use only.<br />
**DisplayName**: UniqueDscId<br />
**LogicalName**: uniquedscid<br />
**IsValidForForm**: False<br />
**IsValidForRead**: False<br />
**RequiredLevel**: None<br />
**Type**: Uniqueidentifier<br />


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

- [CustomerOpportunityRole_SyncErrors](#BKMK_CustomerOpportunityRole_SyncErrors)
- [CustomerOpportunityRole_AsyncOperations](#BKMK_CustomerOpportunityRole_AsyncOperations)
- [customeropportunityrole_MailboxTrackingFolders](#BKMK_customeropportunityrole_MailboxTrackingFolders)
- [userentityinstancedata_customeropportunityrole](#BKMK_userentityinstancedata_customeropportunityrole)
- [CustomerOpportunityRole_ProcessSessions](#BKMK_CustomerOpportunityRole_ProcessSessions)
- [CustomerOpportunityRole_BulkDeleteFailures](#BKMK_CustomerOpportunityRole_BulkDeleteFailures)
- [customeropportunityrole_PrincipalObjectAttributeAccesses](#BKMK_customeropportunityrole_PrincipalObjectAttributeAccesses)


### <a name="BKMK_CustomerOpportunityRole_SyncErrors"></a> CustomerOpportunityRole_SyncErrors

Same as syncerror entity [CustomerOpportunityRole_SyncErrors](syncerror.md#BKMK_CustomerOpportunityRole_SyncErrors) Many-To-One relationship.

**ReferencingEntity**: syncerror<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: CustomerOpportunityRole_SyncErrors<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: Cascade
- **Delete**: Cascade
- **Merge**: Cascade
- **Reparent**: Cascade
- **Share**: Cascade
- **Unshare**: Cascade


### <a name="BKMK_CustomerOpportunityRole_AsyncOperations"></a> CustomerOpportunityRole_AsyncOperations

Same as asyncoperation entity [CustomerOpportunityRole_AsyncOperations](asyncoperation.md#BKMK_CustomerOpportunityRole_AsyncOperations) Many-To-One relationship.

**ReferencingEntity**: asyncoperation<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: False<br />
**ReferencedEntityNavigationPropertyName**: CustomerOpportunityRole_AsyncOperations<br />
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


### <a name="BKMK_customeropportunityrole_MailboxTrackingFolders"></a> customeropportunityrole_MailboxTrackingFolders

Same as mailboxtrackingfolder entity [customeropportunityrole_MailboxTrackingFolders](mailboxtrackingfolder.md#BKMK_customeropportunityrole_MailboxTrackingFolders) Many-To-One relationship.

**ReferencingEntity**: mailboxtrackingfolder<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: customeropportunityrole_MailboxTrackingFolders<br />
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


### <a name="BKMK_userentityinstancedata_customeropportunityrole"></a> userentityinstancedata_customeropportunityrole

Same as userentityinstancedata entity [userentityinstancedata_customeropportunityrole](userentityinstancedata.md#BKMK_userentityinstancedata_customeropportunityrole) Many-To-One relationship.

**ReferencingEntity**: userentityinstancedata<br />
**ReferencingAttribute**: objectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: False<br />
**ReferencedEntityNavigationPropertyName**: userentityinstancedata_customeropportunityrole<br />
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


### <a name="BKMK_CustomerOpportunityRole_ProcessSessions"></a> CustomerOpportunityRole_ProcessSessions

Same as processsession entity [CustomerOpportunityRole_ProcessSessions](processsession.md#BKMK_CustomerOpportunityRole_ProcessSessions) Many-To-One relationship.

**ReferencingEntity**: processsession<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: False<br />
**ReferencedEntityNavigationPropertyName**: CustomerOpportunityRole_ProcessSessions<br />
**AssociatedMenuConfiguration**:

- **Behavior**: UseCollectionName
- **Group**: Details
- **Label**: 
- **Order**: 110

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: NoCascade
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_CustomerOpportunityRole_BulkDeleteFailures"></a> CustomerOpportunityRole_BulkDeleteFailures

Same as bulkdeletefailure entity [CustomerOpportunityRole_BulkDeleteFailures](bulkdeletefailure.md#BKMK_CustomerOpportunityRole_BulkDeleteFailures) Many-To-One relationship.

**ReferencingEntity**: bulkdeletefailure<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: False<br />
**ReferencedEntityNavigationPropertyName**: CustomerOpportunityRole_BulkDeleteFailures<br />
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


### <a name="BKMK_customeropportunityrole_PrincipalObjectAttributeAccesses"></a> customeropportunityrole_PrincipalObjectAttributeAccesses

Same as principalobjectattributeaccess entity [customeropportunityrole_PrincipalObjectAttributeAccesses](principalobjectattributeaccess.md#BKMK_customeropportunityrole_PrincipalObjectAttributeAccesses) Many-To-One relationship.

**ReferencingEntity**: principalobjectattributeaccess<br />
**ReferencingAttribute**: objectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: customeropportunityrole_PrincipalObjectAttributeAccesses<br />
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

- [lk_customeropportunityrole_createdby](#BKMK_lk_customeropportunityrole_createdby)
- [lk_customeropportunityrole_createdonbehalfby](#BKMK_lk_customeropportunityrole_createdonbehalfby)
- [lk_customeropportunityrole_modifiedby](#BKMK_lk_customeropportunityrole_modifiedby)
- [lk_customeropportunityrole_modifiedonbehalfby](#BKMK_lk_customeropportunityrole_modifiedonbehalfby)
- [user_customer_opportunity_roles](#BKMK_user_customer_opportunity_roles)
- [team_customer_opportunity_roles](#BKMK_team_customer_opportunity_roles)
- [business_customer_opportunity_roles](#BKMK_business_customer_opportunity_roles)
- [account_customer_opportunity_roles](#BKMK_account_customer_opportunity_roles)
- [contact_customer_opportunity_roles](#BKMK_contact_customer_opportunity_roles)
- [opportunity_customer_opportunity_roles](#BKMK_opportunity_customer_opportunity_roles)
- [relationship_role_customer_opportunity_roles](#BKMK_relationship_role_customer_opportunity_roles)


### <a name="BKMK_lk_customeropportunityrole_createdby"></a> lk_customeropportunityrole_createdby

See systemuser Entity [lk_customeropportunityrole_createdby](systemuser.md#BKMK_lk_customeropportunityrole_createdby) One-To-Many relationship.

### <a name="BKMK_lk_customeropportunityrole_createdonbehalfby"></a> lk_customeropportunityrole_createdonbehalfby

See systemuser Entity [lk_customeropportunityrole_createdonbehalfby](systemuser.md#BKMK_lk_customeropportunityrole_createdonbehalfby) One-To-Many relationship.

### <a name="BKMK_lk_customeropportunityrole_modifiedby"></a> lk_customeropportunityrole_modifiedby

See systemuser Entity [lk_customeropportunityrole_modifiedby](systemuser.md#BKMK_lk_customeropportunityrole_modifiedby) One-To-Many relationship.

### <a name="BKMK_lk_customeropportunityrole_modifiedonbehalfby"></a> lk_customeropportunityrole_modifiedonbehalfby

See systemuser Entity [lk_customeropportunityrole_modifiedonbehalfby](systemuser.md#BKMK_lk_customeropportunityrole_modifiedonbehalfby) One-To-Many relationship.

### <a name="BKMK_user_customer_opportunity_roles"></a> user_customer_opportunity_roles

See systemuser Entity [user_customer_opportunity_roles](systemuser.md#BKMK_user_customer_opportunity_roles) One-To-Many relationship.

### <a name="BKMK_team_customer_opportunity_roles"></a> team_customer_opportunity_roles

See team Entity [team_customer_opportunity_roles](team.md#BKMK_team_customer_opportunity_roles) One-To-Many relationship.

### <a name="BKMK_business_customer_opportunity_roles"></a> business_customer_opportunity_roles

See businessunit Entity [business_customer_opportunity_roles](businessunit.md#BKMK_business_customer_opportunity_roles) One-To-Many relationship.

### <a name="BKMK_account_customer_opportunity_roles"></a> account_customer_opportunity_roles

See account Entity [account_customer_opportunity_roles](account.md#BKMK_account_customer_opportunity_roles) One-To-Many relationship.

### <a name="BKMK_contact_customer_opportunity_roles"></a> contact_customer_opportunity_roles

See contact Entity [contact_customer_opportunity_roles](contact.md#BKMK_contact_customer_opportunity_roles) One-To-Many relationship.

### <a name="BKMK_opportunity_customer_opportunity_roles"></a> opportunity_customer_opportunity_roles

See opportunity Entity [opportunity_customer_opportunity_roles](opportunity.md#BKMK_opportunity_customer_opportunity_roles) One-To-Many relationship.

### <a name="BKMK_relationship_role_customer_opportunity_roles"></a> relationship_role_customer_opportunity_roles

See relationshiprole Entity [relationship_role_customer_opportunity_roles](relationshiprole.md#BKMK_relationship_role_customer_opportunity_roles) One-To-Many relationship.

## See also

[About the Entity Reference](../about-entity-reference.md)<br />
[Programming reference for Dynamics 365 Customer Engagement](../programming-reference.md)<br />
[Web API Reference](/dynamics365/customer-engagement/web-api/about)<br />
<xref href="Microsoft.Dynamics.CRM.customeropportunityrole?text=customeropportunityrole EntityType" />