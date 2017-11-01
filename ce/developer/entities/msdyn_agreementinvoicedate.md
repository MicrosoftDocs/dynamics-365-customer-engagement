---
title: "msdyn_agreementinvoicedate Entity Reference (Developer Guide for Dynamics 365 Customer Engagement)| MicrosoftDocs"
description: "Includes schema information and supported messages for the msdyn_agreementinvoicedate entity."
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
# msdyn_agreementinvoicedate Entity Reference

[!INCLUDE[](../../includes/cc_applies_to_update_9_0_0.md)]

Specify the invoice dates for the agreement.

**Added by**: Field Service Solution<br />

## Messages

|Message|Web API Operation|SDK Assembly|
|-|-|-|
|Assign|PATCH [*org URI*]/api/data/v9.0/msdyn_agreementinvoicedates(*msdyn_agreementinvoicedateid*)<br />[Update](../webapi/update-delete-entities-using-web-api.md#basic-update) `ownerid` property.|<xref:Microsoft.Crm.Sdk.Messages.AssignRequest>|
|Create|POST [*org URI*]/api/data/v9.0/msdyn_agreementinvoicedates<br />See [Create](../webapi/create-entity-web-api.md)|<xref:Microsoft.Xrm.Sdk.Messages.CreateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Create*>|
|Delete|DELETE [*org URI*]/api/data/v9.0/msdyn_agreementinvoicedates(*msdyn_agreementinvoicedateid*)<br />See [Delete](../webapi/update-delete-entities-using-web-api.md#basic-delete)|<xref:Microsoft.Xrm.Sdk.Messages.DeleteRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Delete*>|
|GrantAccess|<xref href="Microsoft.Dynamics.CRM.GrantAccess?text=GrantAccess Action" />|<xref:Microsoft.Crm.Sdk.Messages.GrantAccessRequest>|
|IsValidStateTransition|<xref href="Microsoft.Dynamics.CRM.IsValidStateTransition?text=IsValidStateTransition Function" />|<xref:Microsoft.Crm.Sdk.Messages.IsValidStateTransitionRequest>|
|ModifyAccess|<xref href="Microsoft.Dynamics.CRM.ModifyAccess?text=ModifyAccess Action" />|<xref:Microsoft.Crm.Sdk.Messages.ModifyAccessRequest>|
|Retrieve|GET [*org URI*]/api/data/v9.0/msdyn_agreementinvoicedates(*msdyn_agreementinvoicedateid*)<br />See [Retrieve](../webapi/retrieve-entity-using-web-api.md)|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Retrieve*>|
|RetrieveMultiple|GET [*org URI*]/api/data/v9.0/msdyn_agreementinvoicedates<br />See [Query Data](../webapi/query-data-web-api.md)|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveMultipleRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.RetrieveMultiple*>|
|RetrievePrincipalAccess|<xref href="Microsoft.Dynamics.CRM.RetrievePrincipalAccess?text=RetrievePrincipalAccess Function" />|<xref:Microsoft.Crm.Sdk.Messages.RetrievePrincipalAccessRequest>|
|RetrieveSharedPrincipalsAndAccess|<xref href="Microsoft.Dynamics.CRM.RetrieveSharedPrincipalsAndAccess?text=RetrieveSharedPrincipalsAndAccess Function" />|<xref:Microsoft.Crm.Sdk.Messages.RetrieveSharedPrincipalsAndAccessRequest>|
|RevokeAccess|<xref href="Microsoft.Dynamics.CRM.RevokeAccess?text=RevokeAccess Action" />|<xref:Microsoft.Crm.Sdk.Messages.RevokeAccessRequest>|
|SetState|PATCH [*org URI*]/api/data/v9.0/msdyn_agreementinvoicedates(*msdyn_agreementinvoicedateid*)<br />[Update](../webapi/update-delete-entities-using-web-api.md#basic-update) `statecode` and `statuscode` properties.|<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|
|Update|PATCH [*org URI*]/api/data/v9.0/msdyn_agreementinvoicedates(*msdyn_agreementinvoicedateid*)<br />See [Update](../webapi/update-delete-entities-using-web-api.md#basic-update)|<xref:Microsoft.Xrm.Sdk.Messages.UpdateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Update*>|

## Properties

**DisplayName**: Agreement Invoice Date<br />
**DisplayCollectionName**: Agreement Invoice Dates<br />
**SchemaName**: msdyn_agreementinvoicedate<br />
**CollectionSchemaName**: msdyn_agreementinvoicedates<br />
**LogicalName**: msdyn_agreementinvoicedate<br />
**LogicalCollectionName**: msdyn_agreementinvoicedates<br />
**EntitySetName**: msdyn_agreementinvoicedates<br />
**PrimaryIdAttribute**: msdyn_agreementinvoicedateid<br />
**PrimaryNameAttribute**: msdyn_name<br />
**OwnershipType**: UserOwned<br />
**IsBPFEntity**: False<br />
<a name="writable-attributes"></a>

## Writable attributes

These attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [msdyn_Agreement](#BKMK_msdyn_Agreement)
- [msdyn_agreementinvoicedateId](#BKMK_msdyn_agreementinvoicedateId)
- [msdyn_Invoice](#BKMK_msdyn_Invoice)
- [msdyn_InvoiceDate](#BKMK_msdyn_InvoiceDate)
- [msdyn_InvoiceSetup](#BKMK_msdyn_InvoiceSetup)
- [msdyn_InvoiceStatus](#BKMK_msdyn_InvoiceStatus)
- [msdyn_name](#BKMK_msdyn_name)
- [msdyn_PostponeGenerationUntil](#BKMK_msdyn_PostponeGenerationUntil)
- [msdyn_Revision](#BKMK_msdyn_Revision)
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


### <a name="BKMK_msdyn_Agreement"></a> msdyn_Agreement

**Description**: Agreement this Invoice Date relates to<br />
**DisplayName**: Agreement<br />
**LogicalName**: msdyn_agreement<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: ApplicationRequired<br />
**Type**: Lookup<br />
**Targets**: msdyn_agreement


### <a name="BKMK_msdyn_agreementinvoicedateId"></a> msdyn_agreementinvoicedateId

**Description**: Shows the entity instances.<br />
**DisplayName**: Agreement Invoice Date<br />
**LogicalName**: msdyn_agreementinvoicedateid<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: SystemRequired<br />
**IsValidForUpdate**: False<br />
**Type**: Uniqueidentifier<br />


### <a name="BKMK_msdyn_Invoice"></a> msdyn_Invoice

**Description**: Shows the invoice generated for this agreement invoice date.<br />
**DisplayName**: Invoice<br />
**LogicalName**: msdyn_invoice<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: invoice


### <a name="BKMK_msdyn_InvoiceDate"></a> msdyn_InvoiceDate

**Description**: Enter the date to generate the invoice.<br />
**DisplayName**: Invoice Date<br />
**LogicalName**: msdyn_invoicedate<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: ApplicationRequired<br />
**Type**: DateTime<br />
**DateTimeBehavior**: UserLocal<br />
**Format**: DateOnly


### <a name="BKMK_msdyn_InvoiceSetup"></a> msdyn_InvoiceSetup

**Description**: Invoice Setup this Invoice Date relates to<br />
**DisplayName**: Invoice Setup<br />
**LogicalName**: msdyn_invoicesetup<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: ApplicationRequired<br />
**Type**: Lookup<br />
**Targets**: msdyn_agreementinvoicesetup


### <a name="BKMK_msdyn_InvoiceStatus"></a> msdyn_InvoiceStatus

**Description**: <br />
**DisplayName**: Invoice Status<br />
**LogicalName**: msdyn_invoicestatus<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Picklist<br />
**Options**:

- **Value**: 690970000 **Label**: Scheduled
- **Value**: 690970001 **Label**: Processed
- **Value**: 690970002 **Label**: Canceled



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


### <a name="BKMK_msdyn_PostponeGenerationUntil"></a> msdyn_PostponeGenerationUntil

**Description**: <br />
**DisplayName**: Postpone Generation Until<br />
**LogicalName**: msdyn_postponegenerationuntil<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: DateTime<br />
**DateTimeBehavior**: TimeZoneIndependent<br />
**Format**: DateAndTime


### <a name="BKMK_msdyn_Revision"></a> msdyn_Revision

**Description**: For internal use only.<br />
**DisplayName**: Revision<br />
**LogicalName**: msdyn_revision<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Integer<br />
**Format**: None<br />
**MaxValue**: 2147483647<br />
**MinValue**: 1


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

**Description**: Status of the Agreement Invoice Date<br />
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

**Description**: Reason for the status of the Agreement Invoice Date<br />
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
- [msdyn_AgreementName](#BKMK_msdyn_AgreementName)
- [msdyn_InvoiceName](#BKMK_msdyn_InvoiceName)
- [msdyn_InvoiceSetupName](#BKMK_msdyn_InvoiceSetupName)
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


### <a name="BKMK_msdyn_AgreementName"></a> msdyn_AgreementName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: msdyn_agreementname<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_msdyn_InvoiceName"></a> msdyn_InvoiceName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: msdyn_invoicename<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 300


### <a name="BKMK_msdyn_InvoiceSetupName"></a> msdyn_InvoiceSetupName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: msdyn_invoicesetupname<br />
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

- [msdyn_agreementinvoicedate_ActivityPointers](#BKMK_msdyn_agreementinvoicedate_ActivityPointers)
- [msdyn_agreementinvoicedate_msdyn_approvals](#BKMK_msdyn_agreementinvoicedate_msdyn_approvals)
- [msdyn_agreementinvoicedate_msdyn_bookingalerts](#BKMK_msdyn_agreementinvoicedate_msdyn_bookingalerts)
- [msdyn_agreementinvoicedate_SyncErrors](#BKMK_msdyn_agreementinvoicedate_SyncErrors)
- [msdyn_agreementinvoicedate_DuplicateMatchingRecord](#BKMK_msdyn_agreementinvoicedate_DuplicateMatchingRecord)
- [msdyn_agreementinvoicedate_DuplicateBaseRecord](#BKMK_msdyn_agreementinvoicedate_DuplicateBaseRecord)
- [msdyn_agreementinvoicedate_SharePointDocumentLocations](#BKMK_msdyn_agreementinvoicedate_SharePointDocumentLocations)
- [msdyn_agreementinvoicedate_SharePointDocuments](#BKMK_msdyn_agreementinvoicedate_SharePointDocuments)
- [msdyn_agreementinvoicedate_AsyncOperations](#BKMK_msdyn_agreementinvoicedate_AsyncOperations)
- [msdyn_agreementinvoicedate_MailboxTrackingFolders](#BKMK_msdyn_agreementinvoicedate_MailboxTrackingFolders)
- [msdyn_agreementinvoicedate_UserEntityInstanceDatas](#BKMK_msdyn_agreementinvoicedate_UserEntityInstanceDatas)
- [msdyn_agreementinvoicedate_ProcessSession](#BKMK_msdyn_agreementinvoicedate_ProcessSession)
- [msdyn_agreementinvoicedate_BulkDeleteFailures](#BKMK_msdyn_agreementinvoicedate_BulkDeleteFailures)
- [msdyn_agreementinvoicedate_PrincipalObjectAttributeAccesses](#BKMK_msdyn_agreementinvoicedate_PrincipalObjectAttributeAccesses)
- [msdyn_agreementinvoicedate_Appointments](#BKMK_msdyn_agreementinvoicedate_Appointments)
- [msdyn_agreementinvoicedate_Emails](#BKMK_msdyn_agreementinvoicedate_Emails)
- [msdyn_agreementinvoicedate_Faxes](#BKMK_msdyn_agreementinvoicedate_Faxes)
- [msdyn_agreementinvoicedate_Letters](#BKMK_msdyn_agreementinvoicedate_Letters)
- [msdyn_agreementinvoicedate_PhoneCalls](#BKMK_msdyn_agreementinvoicedate_PhoneCalls)
- [msdyn_agreementinvoicedate_Tasks](#BKMK_msdyn_agreementinvoicedate_Tasks)
- [msdyn_agreementinvoicedate_RecurringAppointmentMasters](#BKMK_msdyn_agreementinvoicedate_RecurringAppointmentMasters)
- [msdyn_agreementinvoicedate_SocialActivities](#BKMK_msdyn_agreementinvoicedate_SocialActivities)
- [msdyn_agreementinvoicedate_connections1](#BKMK_msdyn_agreementinvoicedate_connections1)
- [msdyn_agreementinvoicedate_connections2](#BKMK_msdyn_agreementinvoicedate_connections2)
- [msdyn_agreementinvoicedate_QueueItems](#BKMK_msdyn_agreementinvoicedate_QueueItems)
- [msdyn_agreementinvoicedate_Annotations](#BKMK_msdyn_agreementinvoicedate_Annotations)
- [msdyn_agreementinvoicedate_ServiceAppointments](#BKMK_msdyn_agreementinvoicedate_ServiceAppointments)


### <a name="BKMK_msdyn_agreementinvoicedate_ActivityPointers"></a> msdyn_agreementinvoicedate_ActivityPointers

Same as activitypointer entity [msdyn_agreementinvoicedate_ActivityPointers](activitypointer.md#BKMK_msdyn_agreementinvoicedate_ActivityPointers) Many-To-One relationship.

**ReferencingEntity**: activitypointer<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_agreementinvoicedate_ActivityPointers<br />
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


### <a name="BKMK_msdyn_agreementinvoicedate_msdyn_approvals"></a> msdyn_agreementinvoicedate_msdyn_approvals

Same as msdyn_approval entity [msdyn_agreementinvoicedate_msdyn_approvals](msdyn_approval.md#BKMK_msdyn_agreementinvoicedate_msdyn_approvals) Many-To-One relationship.

**ReferencingEntity**: msdyn_approval<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_agreementinvoicedate_msdyn_approvals<br />
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


### <a name="BKMK_msdyn_agreementinvoicedate_msdyn_bookingalerts"></a> msdyn_agreementinvoicedate_msdyn_bookingalerts

Same as msdyn_bookingalert entity [msdyn_agreementinvoicedate_msdyn_bookingalerts](msdyn_bookingalert.md#BKMK_msdyn_agreementinvoicedate_msdyn_bookingalerts) Many-To-One relationship.

**ReferencingEntity**: msdyn_bookingalert<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_agreementinvoicedate_msdyn_bookingalerts<br />
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


### <a name="BKMK_msdyn_agreementinvoicedate_SyncErrors"></a> msdyn_agreementinvoicedate_SyncErrors

Same as syncerror entity [msdyn_agreementinvoicedate_SyncErrors](syncerror.md#BKMK_msdyn_agreementinvoicedate_SyncErrors) Many-To-One relationship.

**ReferencingEntity**: syncerror<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_agreementinvoicedate_SyncErrors<br />
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


### <a name="BKMK_msdyn_agreementinvoicedate_DuplicateMatchingRecord"></a> msdyn_agreementinvoicedate_DuplicateMatchingRecord

Same as duplicaterecord entity [msdyn_agreementinvoicedate_DuplicateMatchingRecord](duplicaterecord.md#BKMK_msdyn_agreementinvoicedate_DuplicateMatchingRecord) Many-To-One relationship.

**ReferencingEntity**: duplicaterecord<br />
**ReferencingAttribute**: duplicaterecordid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_agreementinvoicedate_DuplicateMatchingRecord<br />
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


### <a name="BKMK_msdyn_agreementinvoicedate_DuplicateBaseRecord"></a> msdyn_agreementinvoicedate_DuplicateBaseRecord

Same as duplicaterecord entity [msdyn_agreementinvoicedate_DuplicateBaseRecord](duplicaterecord.md#BKMK_msdyn_agreementinvoicedate_DuplicateBaseRecord) Many-To-One relationship.

**ReferencingEntity**: duplicaterecord<br />
**ReferencingAttribute**: baserecordid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_agreementinvoicedate_DuplicateBaseRecord<br />
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


### <a name="BKMK_msdyn_agreementinvoicedate_SharePointDocumentLocations"></a> msdyn_agreementinvoicedate_SharePointDocumentLocations

Same as sharepointdocumentlocation entity [msdyn_agreementinvoicedate_SharePointDocumentLocations](sharepointdocumentlocation.md#BKMK_msdyn_agreementinvoicedate_SharePointDocumentLocations) Many-To-One relationship.

**ReferencingEntity**: sharepointdocumentlocation<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_agreementinvoicedate_SharePointDocumentLocations<br />
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


### <a name="BKMK_msdyn_agreementinvoicedate_SharePointDocuments"></a> msdyn_agreementinvoicedate_SharePointDocuments

Same as sharepointdocument entity [msdyn_agreementinvoicedate_SharePointDocuments](sharepointdocument.md#BKMK_msdyn_agreementinvoicedate_SharePointDocuments) Many-To-One relationship.

**ReferencingEntity**: sharepointdocument<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_agreementinvoicedate_SharePointDocuments<br />
**AssociatedMenuConfiguration**:

- **Behavior**: UseCollectionName
- **Group**: Details
- **Label**: 
- **Order**: 60

**CascadeConfiguration**:

- **Assign**: Cascade
- **Delete**: Cascade
- **Merge**: Cascade
- **Reparent**: Cascade
- **Share**: Cascade
- **Unshare**: Cascade


### <a name="BKMK_msdyn_agreementinvoicedate_AsyncOperations"></a> msdyn_agreementinvoicedate_AsyncOperations

Same as asyncoperation entity [msdyn_agreementinvoicedate_AsyncOperations](asyncoperation.md#BKMK_msdyn_agreementinvoicedate_AsyncOperations) Many-To-One relationship.

**ReferencingEntity**: asyncoperation<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_agreementinvoicedate_AsyncOperations<br />
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


### <a name="BKMK_msdyn_agreementinvoicedate_MailboxTrackingFolders"></a> msdyn_agreementinvoicedate_MailboxTrackingFolders

Same as mailboxtrackingfolder entity [msdyn_agreementinvoicedate_MailboxTrackingFolders](mailboxtrackingfolder.md#BKMK_msdyn_agreementinvoicedate_MailboxTrackingFolders) Many-To-One relationship.

**ReferencingEntity**: mailboxtrackingfolder<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_agreementinvoicedate_MailboxTrackingFolders<br />
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


### <a name="BKMK_msdyn_agreementinvoicedate_UserEntityInstanceDatas"></a> msdyn_agreementinvoicedate_UserEntityInstanceDatas

Same as userentityinstancedata entity [msdyn_agreementinvoicedate_UserEntityInstanceDatas](userentityinstancedata.md#BKMK_msdyn_agreementinvoicedate_UserEntityInstanceDatas) Many-To-One relationship.

**ReferencingEntity**: userentityinstancedata<br />
**ReferencingAttribute**: objectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_agreementinvoicedate_UserEntityInstanceDatas<br />
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


### <a name="BKMK_msdyn_agreementinvoicedate_ProcessSession"></a> msdyn_agreementinvoicedate_ProcessSession

Same as processsession entity [msdyn_agreementinvoicedate_ProcessSession](processsession.md#BKMK_msdyn_agreementinvoicedate_ProcessSession) Many-To-One relationship.

**ReferencingEntity**: processsession<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_agreementinvoicedate_ProcessSession<br />
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


### <a name="BKMK_msdyn_agreementinvoicedate_BulkDeleteFailures"></a> msdyn_agreementinvoicedate_BulkDeleteFailures

Same as bulkdeletefailure entity [msdyn_agreementinvoicedate_BulkDeleteFailures](bulkdeletefailure.md#BKMK_msdyn_agreementinvoicedate_BulkDeleteFailures) Many-To-One relationship.

**ReferencingEntity**: bulkdeletefailure<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_agreementinvoicedate_BulkDeleteFailures<br />
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


### <a name="BKMK_msdyn_agreementinvoicedate_PrincipalObjectAttributeAccesses"></a> msdyn_agreementinvoicedate_PrincipalObjectAttributeAccesses

Same as principalobjectattributeaccess entity [msdyn_agreementinvoicedate_PrincipalObjectAttributeAccesses](principalobjectattributeaccess.md#BKMK_msdyn_agreementinvoicedate_PrincipalObjectAttributeAccesses) Many-To-One relationship.

**ReferencingEntity**: principalobjectattributeaccess<br />
**ReferencingAttribute**: objectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_agreementinvoicedate_PrincipalObjectAttributeAccesses<br />
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


### <a name="BKMK_msdyn_agreementinvoicedate_Appointments"></a> msdyn_agreementinvoicedate_Appointments

Same as appointment entity [msdyn_agreementinvoicedate_Appointments](appointment.md#BKMK_msdyn_agreementinvoicedate_Appointments) Many-To-One relationship.

**ReferencingEntity**: appointment<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_agreementinvoicedate_Appointments<br />
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


### <a name="BKMK_msdyn_agreementinvoicedate_Emails"></a> msdyn_agreementinvoicedate_Emails

Same as email entity [msdyn_agreementinvoicedate_Emails](email.md#BKMK_msdyn_agreementinvoicedate_Emails) Many-To-One relationship.

**ReferencingEntity**: email<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_agreementinvoicedate_Emails<br />
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


### <a name="BKMK_msdyn_agreementinvoicedate_Faxes"></a> msdyn_agreementinvoicedate_Faxes

Same as fax entity [msdyn_agreementinvoicedate_Faxes](fax.md#BKMK_msdyn_agreementinvoicedate_Faxes) Many-To-One relationship.

**ReferencingEntity**: fax<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_agreementinvoicedate_Faxes<br />
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


### <a name="BKMK_msdyn_agreementinvoicedate_Letters"></a> msdyn_agreementinvoicedate_Letters

Same as letter entity [msdyn_agreementinvoicedate_Letters](letter.md#BKMK_msdyn_agreementinvoicedate_Letters) Many-To-One relationship.

**ReferencingEntity**: letter<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_agreementinvoicedate_Letters<br />
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


### <a name="BKMK_msdyn_agreementinvoicedate_PhoneCalls"></a> msdyn_agreementinvoicedate_PhoneCalls

Same as phonecall entity [msdyn_agreementinvoicedate_PhoneCalls](phonecall.md#BKMK_msdyn_agreementinvoicedate_PhoneCalls) Many-To-One relationship.

**ReferencingEntity**: phonecall<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_agreementinvoicedate_PhoneCalls<br />
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


### <a name="BKMK_msdyn_agreementinvoicedate_Tasks"></a> msdyn_agreementinvoicedate_Tasks

Same as task entity [msdyn_agreementinvoicedate_Tasks](task.md#BKMK_msdyn_agreementinvoicedate_Tasks) Many-To-One relationship.

**ReferencingEntity**: task<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_agreementinvoicedate_Tasks<br />
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


### <a name="BKMK_msdyn_agreementinvoicedate_RecurringAppointmentMasters"></a> msdyn_agreementinvoicedate_RecurringAppointmentMasters

Same as recurringappointmentmaster entity [msdyn_agreementinvoicedate_RecurringAppointmentMasters](recurringappointmentmaster.md#BKMK_msdyn_agreementinvoicedate_RecurringAppointmentMasters) Many-To-One relationship.

**ReferencingEntity**: recurringappointmentmaster<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_agreementinvoicedate_RecurringAppointmentMasters<br />
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


### <a name="BKMK_msdyn_agreementinvoicedate_SocialActivities"></a> msdyn_agreementinvoicedate_SocialActivities

Same as socialactivity entity [msdyn_agreementinvoicedate_SocialActivities](socialactivity.md#BKMK_msdyn_agreementinvoicedate_SocialActivities) Many-To-One relationship.

**ReferencingEntity**: socialactivity<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_agreementinvoicedate_SocialActivities<br />
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


### <a name="BKMK_msdyn_agreementinvoicedate_connections1"></a> msdyn_agreementinvoicedate_connections1

Same as connection entity [msdyn_agreementinvoicedate_connections1](connection.md#BKMK_msdyn_agreementinvoicedate_connections1) Many-To-One relationship.

**ReferencingEntity**: connection<br />
**ReferencingAttribute**: record1id<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_agreementinvoicedate_connections1<br />
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


### <a name="BKMK_msdyn_agreementinvoicedate_connections2"></a> msdyn_agreementinvoicedate_connections2

Same as connection entity [msdyn_agreementinvoicedate_connections2](connection.md#BKMK_msdyn_agreementinvoicedate_connections2) Many-To-One relationship.

**ReferencingEntity**: connection<br />
**ReferencingAttribute**: record2id<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_agreementinvoicedate_connections2<br />
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


### <a name="BKMK_msdyn_agreementinvoicedate_QueueItems"></a> msdyn_agreementinvoicedate_QueueItems

Same as queueitem entity [msdyn_agreementinvoicedate_QueueItems](queueitem.md#BKMK_msdyn_agreementinvoicedate_QueueItems) Many-To-One relationship.

**ReferencingEntity**: queueitem<br />
**ReferencingAttribute**: objectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_agreementinvoicedate_QueueItems<br />
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


### <a name="BKMK_msdyn_agreementinvoicedate_Annotations"></a> msdyn_agreementinvoicedate_Annotations

Same as annotation entity [msdyn_agreementinvoicedate_Annotations](annotation.md#BKMK_msdyn_agreementinvoicedate_Annotations) Many-To-One relationship.

**ReferencingEntity**: annotation<br />
**ReferencingAttribute**: objectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_agreementinvoicedate_Annotations<br />
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


### <a name="BKMK_msdyn_agreementinvoicedate_ServiceAppointments"></a> msdyn_agreementinvoicedate_ServiceAppointments

Same as serviceappointment entity [msdyn_agreementinvoicedate_ServiceAppointments](serviceappointment.md#BKMK_msdyn_agreementinvoicedate_ServiceAppointments) Many-To-One relationship.

**ReferencingEntity**: serviceappointment<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_agreementinvoicedate_ServiceAppointments<br />
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

- [lk_msdyn_agreementinvoicedate_createdby](#BKMK_lk_msdyn_agreementinvoicedate_createdby)
- [lk_msdyn_agreementinvoicedate_createdonbehalfby](#BKMK_lk_msdyn_agreementinvoicedate_createdonbehalfby)
- [lk_msdyn_agreementinvoicedate_modifiedby](#BKMK_lk_msdyn_agreementinvoicedate_modifiedby)
- [lk_msdyn_agreementinvoicedate_modifiedonbehalfby](#BKMK_lk_msdyn_agreementinvoicedate_modifiedonbehalfby)
- [user_msdyn_agreementinvoicedate](#BKMK_user_msdyn_agreementinvoicedate)
- [team_msdyn_agreementinvoicedate](#BKMK_team_msdyn_agreementinvoicedate)
- [business_unit_msdyn_agreementinvoicedate](#BKMK_business_unit_msdyn_agreementinvoicedate)
- [msdyn_invoice_msdyn_agreementinvoicedate_Invoice](#BKMK_msdyn_invoice_msdyn_agreementinvoicedate_Invoice)
- [msdyn_msdyn_agreement_msdyn_agreementinvoicedate_Agreement](#BKMK_msdyn_msdyn_agreement_msdyn_agreementinvoicedate_Agreement)
- [msdyn_msdyn_agreementinvoicesetup_msdyn_agreementinvoicedate_InvoiceSetup](#BKMK_msdyn_msdyn_agreementinvoicesetup_msdyn_agreementinvoicedate_InvoiceSetup)


### <a name="BKMK_lk_msdyn_agreementinvoicedate_createdby"></a> lk_msdyn_agreementinvoicedate_createdby

See systemuser Entity [lk_msdyn_agreementinvoicedate_createdby](systemuser.md#BKMK_lk_msdyn_agreementinvoicedate_createdby) One-To-Many relationship.

### <a name="BKMK_lk_msdyn_agreementinvoicedate_createdonbehalfby"></a> lk_msdyn_agreementinvoicedate_createdonbehalfby

See systemuser Entity [lk_msdyn_agreementinvoicedate_createdonbehalfby](systemuser.md#BKMK_lk_msdyn_agreementinvoicedate_createdonbehalfby) One-To-Many relationship.

### <a name="BKMK_lk_msdyn_agreementinvoicedate_modifiedby"></a> lk_msdyn_agreementinvoicedate_modifiedby

See systemuser Entity [lk_msdyn_agreementinvoicedate_modifiedby](systemuser.md#BKMK_lk_msdyn_agreementinvoicedate_modifiedby) One-To-Many relationship.

### <a name="BKMK_lk_msdyn_agreementinvoicedate_modifiedonbehalfby"></a> lk_msdyn_agreementinvoicedate_modifiedonbehalfby

See systemuser Entity [lk_msdyn_agreementinvoicedate_modifiedonbehalfby](systemuser.md#BKMK_lk_msdyn_agreementinvoicedate_modifiedonbehalfby) One-To-Many relationship.

### <a name="BKMK_user_msdyn_agreementinvoicedate"></a> user_msdyn_agreementinvoicedate

See systemuser Entity [user_msdyn_agreementinvoicedate](systemuser.md#BKMK_user_msdyn_agreementinvoicedate) One-To-Many relationship.

### <a name="BKMK_team_msdyn_agreementinvoicedate"></a> team_msdyn_agreementinvoicedate

See team Entity [team_msdyn_agreementinvoicedate](team.md#BKMK_team_msdyn_agreementinvoicedate) One-To-Many relationship.

### <a name="BKMK_business_unit_msdyn_agreementinvoicedate"></a> business_unit_msdyn_agreementinvoicedate

See businessunit Entity [business_unit_msdyn_agreementinvoicedate](businessunit.md#BKMK_business_unit_msdyn_agreementinvoicedate) One-To-Many relationship.

### <a name="BKMK_msdyn_invoice_msdyn_agreementinvoicedate_Invoice"></a> msdyn_invoice_msdyn_agreementinvoicedate_Invoice

See invoice Entity [msdyn_invoice_msdyn_agreementinvoicedate_Invoice](invoice.md#BKMK_msdyn_invoice_msdyn_agreementinvoicedate_Invoice) One-To-Many relationship.

### <a name="BKMK_msdyn_msdyn_agreement_msdyn_agreementinvoicedate_Agreement"></a> msdyn_msdyn_agreement_msdyn_agreementinvoicedate_Agreement

See msdyn_agreement Entity [msdyn_msdyn_agreement_msdyn_agreementinvoicedate_Agreement](msdyn_agreement.md#BKMK_msdyn_msdyn_agreement_msdyn_agreementinvoicedate_Agreement) One-To-Many relationship.

### <a name="BKMK_msdyn_msdyn_agreementinvoicesetup_msdyn_agreementinvoicedate_InvoiceSetup"></a> msdyn_msdyn_agreementinvoicesetup_msdyn_agreementinvoicedate_InvoiceSetup

See msdyn_agreementinvoicesetup Entity [msdyn_msdyn_agreementinvoicesetup_msdyn_agreementinvoicedate_InvoiceSetup](msdyn_agreementinvoicesetup.md#BKMK_msdyn_msdyn_agreementinvoicesetup_msdyn_agreementinvoicedate_InvoiceSetup) One-To-Many relationship.

## See also

[About the Entity Reference](../about-entity-reference.md)<br />
[Programming reference for Dynamics 365 Customer Engagement](../programming-reference.md)<br />
[Web API Reference](/dynamics365/customer-engagement/web-api/about)<br />
<xref href="Microsoft.Dynamics.CRM.msdyn_agreementinvoicedate?text=msdyn_agreementinvoicedate EntityType" />