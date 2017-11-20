---
title: "msdyn_orderinvoicingsetupdate Entity Reference (Developer Guide for Dynamics 365 Customer Engagement)| MicrosoftDocs"
description: "Includes schema information and supported messages for the msdyn_orderinvoicingsetupdate entity."
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
# msdyn_orderinvoicingsetupdate Entity Reference

[!INCLUDE[](../../includes/cc_applies_to_update_9_0_0.md)]

**Added by**: Field Service Solution<br />

## Messages

|Message|Web API Operation|SDK Assembly|
|-|-|-|
|Assign|PATCH [*org URI*]/api/data/v9.0/msdyn_orderinvoicingsetupdates(*msdyn_orderinvoicingsetupdateid*)<br />[Update](../webapi/update-delete-entities-using-web-api.md#basic-update) `ownerid` property.|<xref:Microsoft.Crm.Sdk.Messages.AssignRequest>|
|Create|POST [*org URI*]/api/data/v9.0/msdyn_orderinvoicingsetupdates<br />See [Create](../webapi/create-entity-web-api.md)|<xref:Microsoft.Xrm.Sdk.Messages.CreateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Create*>|
|Delete|DELETE [*org URI*]/api/data/v9.0/msdyn_orderinvoicingsetupdates(*msdyn_orderinvoicingsetupdateid*)<br />See [Delete](../webapi/update-delete-entities-using-web-api.md#basic-delete)|<xref:Microsoft.Xrm.Sdk.Messages.DeleteRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Delete*>|
|GrantAccess|<xref href="Microsoft.Dynamics.CRM.GrantAccess?text=GrantAccess Action" />|<xref:Microsoft.Crm.Sdk.Messages.GrantAccessRequest>|
|IsValidStateTransition|<xref href="Microsoft.Dynamics.CRM.IsValidStateTransition?text=IsValidStateTransition Function" />|<xref:Microsoft.Crm.Sdk.Messages.IsValidStateTransitionRequest>|
|ModifyAccess|<xref href="Microsoft.Dynamics.CRM.ModifyAccess?text=ModifyAccess Action" />|<xref:Microsoft.Crm.Sdk.Messages.ModifyAccessRequest>|
|Retrieve|GET [*org URI*]/api/data/v9.0/msdyn_orderinvoicingsetupdates(*msdyn_orderinvoicingsetupdateid*)<br />See [Retrieve](../webapi/retrieve-entity-using-web-api.md)|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Retrieve*>|
|RetrieveMultiple|GET [*org URI*]/api/data/v9.0/msdyn_orderinvoicingsetupdates<br />See [Query Data](../webapi/query-data-web-api.md)|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveMultipleRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.RetrieveMultiple*>|
|RetrievePrincipalAccess|<xref href="Microsoft.Dynamics.CRM.RetrievePrincipalAccess?text=RetrievePrincipalAccess Function" />|<xref:Microsoft.Crm.Sdk.Messages.RetrievePrincipalAccessRequest>|
|RetrieveSharedPrincipalsAndAccess|<xref href="Microsoft.Dynamics.CRM.RetrieveSharedPrincipalsAndAccess?text=RetrieveSharedPrincipalsAndAccess Function" />|<xref:Microsoft.Crm.Sdk.Messages.RetrieveSharedPrincipalsAndAccessRequest>|
|RevokeAccess|<xref href="Microsoft.Dynamics.CRM.RevokeAccess?text=RevokeAccess Action" />|<xref:Microsoft.Crm.Sdk.Messages.RevokeAccessRequest>|
|SetState|PATCH [*org URI*]/api/data/v9.0/msdyn_orderinvoicingsetupdates(*msdyn_orderinvoicingsetupdateid*)<br />[Update](../webapi/update-delete-entities-using-web-api.md#basic-update) `statecode` and `statuscode` properties.|<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|
|Update|PATCH [*org URI*]/api/data/v9.0/msdyn_orderinvoicingsetupdates(*msdyn_orderinvoicingsetupdateid*)<br />See [Update](../webapi/update-delete-entities-using-web-api.md#basic-update)|<xref:Microsoft.Xrm.Sdk.Messages.UpdateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Update*>|

## Entity Properties

**DisplayName**: Order Invoicing Setup Date<br />
**DisplayCollectionName**: Order Invoicing Setup Dates<br />
**SchemaName**: msdyn_orderinvoicingsetupdate<br />
**CollectionSchemaName**: msdyn_orderinvoicingsetupdates<br />
**LogicalName**: msdyn_orderinvoicingsetupdate<br />
**LogicalCollectionName**: msdyn_orderinvoicingsetupdates<br />
**EntitySetName**: msdyn_orderinvoicingsetupdates<br />
**PrimaryIdAttribute**: msdyn_orderinvoicingsetupdateid<br />
**PrimaryNameAttribute**: msdyn_name<br />
**OwnershipType**: UserOwned<br />
**IsBPFEntity**: False<br />
<a name="writable-attributes"></a>

## Writable attributes

These attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [msdyn_Invoice](#BKMK_msdyn_Invoice)
- [msdyn_InvoiceDate](#BKMK_msdyn_InvoiceDate)
- [msdyn_InvoiceSetup](#BKMK_msdyn_InvoiceSetup)
- [msdyn_InvoiceStatus](#BKMK_msdyn_InvoiceStatus)
- [msdyn_name](#BKMK_msdyn_name)
- [msdyn_Order](#BKMK_msdyn_Order)
- [msdyn_OrderInvoicingDate](#BKMK_msdyn_OrderInvoicingDate)
- [msdyn_orderinvoicingsetupdateId](#BKMK_msdyn_orderinvoicingsetupdateId)
- [msdyn_PostponeGenerationUntil](#BKMK_msdyn_PostponeGenerationUntil)
- [msdyn_PreviousInvoiceDate](#BKMK_msdyn_PreviousInvoiceDate)
- [msdyn_Revision](#BKMK_msdyn_Revision)
- [OverriddenCreatedOn](#BKMK_OverriddenCreatedOn)
- [OwnerId](#BKMK_OwnerId)
- [OwnerIdType](#BKMK_OwnerIdType)
- [statecode](#BKMK_statecode)
- [statuscode](#BKMK_statuscode)
- [TimeZoneRuleVersionNumber](#BKMK_TimeZoneRuleVersionNumber)
- [UTCConversionTimeZoneCode](#BKMK_UTCConversionTimeZoneCode)


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


### <a name="BKMK_msdyn_Invoice"></a> msdyn_Invoice

**Description**: Shows the invoice generated for this invoice date.<br />
**DisplayName**: Invoice<br />
**LogicalName**: msdyn_invoice<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: invoice


### <a name="BKMK_msdyn_InvoiceDate"></a> msdyn_InvoiceDate

**Description**: The last day of the invoicing period.<br />
**DisplayName**: Period End<br />
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
**Targets**: msdyn_orderinvoicingsetup


### <a name="BKMK_msdyn_InvoiceStatus"></a> msdyn_InvoiceStatus

**Description**: Status of the invoice generation for this Invoice Date<br />
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

**Description**: The name of the custom entity.<br />
**DisplayName**: Name<br />
**LogicalName**: msdyn_name<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_msdyn_Order"></a> msdyn_Order

**Description**: Order this Invoice Date relates to<br />
**DisplayName**: Order<br />
**LogicalName**: msdyn_order<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: ApplicationRequired<br />
**Type**: Lookup<br />
**Targets**: salesorder


### <a name="BKMK_msdyn_OrderInvoicingDate"></a> msdyn_OrderInvoicingDate

**Description**: Reference to the Order Invoicing Date that this record relates to.<br />
**DisplayName**: Order Invoicing Date<br />
**LogicalName**: msdyn_orderinvoicingdate<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: msdyn_orderinvoicingdate


### <a name="BKMK_msdyn_orderinvoicingsetupdateId"></a> msdyn_orderinvoicingsetupdateId

**Description**: Unique identifier for entity instances<br />
**DisplayName**: Order Invoicing Setup Date<br />
**LogicalName**: msdyn_orderinvoicingsetupdateid<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: SystemRequired<br />
**IsValidForUpdate**: False<br />
**Type**: Uniqueidentifier<br />


### <a name="BKMK_msdyn_PostponeGenerationUntil"></a> msdyn_PostponeGenerationUntil

**Description**: Time and date used for scheduling invoice generation.<br />
**DisplayName**: Postpone Generation Until<br />
**LogicalName**: msdyn_postponegenerationuntil<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: DateTime<br />
**DateTimeBehavior**: TimeZoneIndependent<br />
**Format**: DateAndTime


### <a name="BKMK_msdyn_PreviousInvoiceDate"></a> msdyn_PreviousInvoiceDate

**Description**: The first day of the invoicing period.<br />
**DisplayName**: Period Start<br />
**LogicalName**: msdyn_previousinvoicedate<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: DateTime<br />
**DateTimeBehavior**: UserLocal<br />
**Format**: DateOnly


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

**Description**: Status of the Order Invoicing Setup Date<br />
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

**Description**: Reason for the status of the Order Invoicing Setup Date<br />
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
- [ModifiedBy](#BKMK_ModifiedBy)
- [ModifiedByName](#BKMK_ModifiedByName)
- [ModifiedByYomiName](#BKMK_ModifiedByYomiName)
- [ModifiedOn](#BKMK_ModifiedOn)
- [ModifiedOnBehalfBy](#BKMK_ModifiedOnBehalfBy)
- [ModifiedOnBehalfByName](#BKMK_ModifiedOnBehalfByName)
- [ModifiedOnBehalfByYomiName](#BKMK_ModifiedOnBehalfByYomiName)
- [msdyn_InvoiceName](#BKMK_msdyn_InvoiceName)
- [msdyn_InvoiceSetupName](#BKMK_msdyn_InvoiceSetupName)
- [msdyn_OrderInvoicingDateName](#BKMK_msdyn_OrderInvoicingDateName)
- [msdyn_OrderName](#BKMK_msdyn_OrderName)
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

**Description**: Date and time when the record was created.<br />
**DisplayName**: Created On<br />
**LogicalName**: createdon<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: DateTime<br />
**DateTimeBehavior**: UserLocal<br />
**Format**: DateAndTime


### <a name="BKMK_CreatedOnBehalfBy"></a> CreatedOnBehalfBy

**Description**: Unique identifier of the delegate user who created the record.<br />
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

**Description**: Date and time when the record was modified.<br />
**DisplayName**: Modified On<br />
**LogicalName**: modifiedon<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: DateTime<br />
**DateTimeBehavior**: UserLocal<br />
**Format**: DateAndTime


### <a name="BKMK_ModifiedOnBehalfBy"></a> ModifiedOnBehalfBy

**Description**: Unique identifier of the delegate user who modified the record.<br />
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


### <a name="BKMK_msdyn_OrderInvoicingDateName"></a> msdyn_OrderInvoicingDateName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: msdyn_orderinvoicingdatename<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_msdyn_OrderName"></a> msdyn_OrderName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: msdyn_ordername<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 300


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

- [msdyn_orderinvoicingsetupdate_SyncErrors](#BKMK_msdyn_orderinvoicingsetupdate_SyncErrors)
- [msdyn_orderinvoicingsetupdate_DuplicateMatchingRecord](#BKMK_msdyn_orderinvoicingsetupdate_DuplicateMatchingRecord)
- [msdyn_orderinvoicingsetupdate_DuplicateBaseRecord](#BKMK_msdyn_orderinvoicingsetupdate_DuplicateBaseRecord)
- [msdyn_orderinvoicingsetupdate_AsyncOperations](#BKMK_msdyn_orderinvoicingsetupdate_AsyncOperations)
- [msdyn_orderinvoicingsetupdate_MailboxTrackingFolders](#BKMK_msdyn_orderinvoicingsetupdate_MailboxTrackingFolders)
- [msdyn_orderinvoicingsetupdate_UserEntityInstanceDatas](#BKMK_msdyn_orderinvoicingsetupdate_UserEntityInstanceDatas)
- [msdyn_orderinvoicingsetupdate_ProcessSession](#BKMK_msdyn_orderinvoicingsetupdate_ProcessSession)
- [msdyn_orderinvoicingsetupdate_BulkDeleteFailures](#BKMK_msdyn_orderinvoicingsetupdate_BulkDeleteFailures)
- [msdyn_orderinvoicingsetupdate_PrincipalObjectAttributeAccesses](#BKMK_msdyn_orderinvoicingsetupdate_PrincipalObjectAttributeAccesses)


### <a name="BKMK_msdyn_orderinvoicingsetupdate_SyncErrors"></a> msdyn_orderinvoicingsetupdate_SyncErrors

Same as syncerror entity [msdyn_orderinvoicingsetupdate_SyncErrors](syncerror.md#BKMK_msdyn_orderinvoicingsetupdate_SyncErrors) Many-To-One relationship.

**ReferencingEntity**: syncerror<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_orderinvoicingsetupdate_SyncErrors<br />
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


### <a name="BKMK_msdyn_orderinvoicingsetupdate_DuplicateMatchingRecord"></a> msdyn_orderinvoicingsetupdate_DuplicateMatchingRecord

Same as duplicaterecord entity [msdyn_orderinvoicingsetupdate_DuplicateMatchingRecord](duplicaterecord.md#BKMK_msdyn_orderinvoicingsetupdate_DuplicateMatchingRecord) Many-To-One relationship.

**ReferencingEntity**: duplicaterecord<br />
**ReferencingAttribute**: duplicaterecordid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_orderinvoicingsetupdate_DuplicateMatchingRecord<br />
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


### <a name="BKMK_msdyn_orderinvoicingsetupdate_DuplicateBaseRecord"></a> msdyn_orderinvoicingsetupdate_DuplicateBaseRecord

Same as duplicaterecord entity [msdyn_orderinvoicingsetupdate_DuplicateBaseRecord](duplicaterecord.md#BKMK_msdyn_orderinvoicingsetupdate_DuplicateBaseRecord) Many-To-One relationship.

**ReferencingEntity**: duplicaterecord<br />
**ReferencingAttribute**: baserecordid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_orderinvoicingsetupdate_DuplicateBaseRecord<br />
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


### <a name="BKMK_msdyn_orderinvoicingsetupdate_AsyncOperations"></a> msdyn_orderinvoicingsetupdate_AsyncOperations

Same as asyncoperation entity [msdyn_orderinvoicingsetupdate_AsyncOperations](asyncoperation.md#BKMK_msdyn_orderinvoicingsetupdate_AsyncOperations) Many-To-One relationship.

**ReferencingEntity**: asyncoperation<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_orderinvoicingsetupdate_AsyncOperations<br />
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


### <a name="BKMK_msdyn_orderinvoicingsetupdate_MailboxTrackingFolders"></a> msdyn_orderinvoicingsetupdate_MailboxTrackingFolders

Same as mailboxtrackingfolder entity [msdyn_orderinvoicingsetupdate_MailboxTrackingFolders](mailboxtrackingfolder.md#BKMK_msdyn_orderinvoicingsetupdate_MailboxTrackingFolders) Many-To-One relationship.

**ReferencingEntity**: mailboxtrackingfolder<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_orderinvoicingsetupdate_MailboxTrackingFolders<br />
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


### <a name="BKMK_msdyn_orderinvoicingsetupdate_UserEntityInstanceDatas"></a> msdyn_orderinvoicingsetupdate_UserEntityInstanceDatas

Same as userentityinstancedata entity [msdyn_orderinvoicingsetupdate_UserEntityInstanceDatas](userentityinstancedata.md#BKMK_msdyn_orderinvoicingsetupdate_UserEntityInstanceDatas) Many-To-One relationship.

**ReferencingEntity**: userentityinstancedata<br />
**ReferencingAttribute**: objectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_orderinvoicingsetupdate_UserEntityInstanceDatas<br />
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


### <a name="BKMK_msdyn_orderinvoicingsetupdate_ProcessSession"></a> msdyn_orderinvoicingsetupdate_ProcessSession

Same as processsession entity [msdyn_orderinvoicingsetupdate_ProcessSession](processsession.md#BKMK_msdyn_orderinvoicingsetupdate_ProcessSession) Many-To-One relationship.

**ReferencingEntity**: processsession<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_orderinvoicingsetupdate_ProcessSession<br />
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


### <a name="BKMK_msdyn_orderinvoicingsetupdate_BulkDeleteFailures"></a> msdyn_orderinvoicingsetupdate_BulkDeleteFailures

Same as bulkdeletefailure entity [msdyn_orderinvoicingsetupdate_BulkDeleteFailures](bulkdeletefailure.md#BKMK_msdyn_orderinvoicingsetupdate_BulkDeleteFailures) Many-To-One relationship.

**ReferencingEntity**: bulkdeletefailure<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_orderinvoicingsetupdate_BulkDeleteFailures<br />
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


### <a name="BKMK_msdyn_orderinvoicingsetupdate_PrincipalObjectAttributeAccesses"></a> msdyn_orderinvoicingsetupdate_PrincipalObjectAttributeAccesses

Same as principalobjectattributeaccess entity [msdyn_orderinvoicingsetupdate_PrincipalObjectAttributeAccesses](principalobjectattributeaccess.md#BKMK_msdyn_orderinvoicingsetupdate_PrincipalObjectAttributeAccesses) Many-To-One relationship.

**ReferencingEntity**: principalobjectattributeaccess<br />
**ReferencingAttribute**: objectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_orderinvoicingsetupdate_PrincipalObjectAttributeAccesses<br />
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

- [lk_msdyn_orderinvoicingsetupdate_createdby](#BKMK_lk_msdyn_orderinvoicingsetupdate_createdby)
- [lk_msdyn_orderinvoicingsetupdate_createdonbehalfby](#BKMK_lk_msdyn_orderinvoicingsetupdate_createdonbehalfby)
- [lk_msdyn_orderinvoicingsetupdate_modifiedby](#BKMK_lk_msdyn_orderinvoicingsetupdate_modifiedby)
- [lk_msdyn_orderinvoicingsetupdate_modifiedonbehalfby](#BKMK_lk_msdyn_orderinvoicingsetupdate_modifiedonbehalfby)
- [user_msdyn_orderinvoicingsetupdate](#BKMK_user_msdyn_orderinvoicingsetupdate)
- [team_msdyn_orderinvoicingsetupdate](#BKMK_team_msdyn_orderinvoicingsetupdate)
- [business_unit_msdyn_orderinvoicingsetupdate](#BKMK_business_unit_msdyn_orderinvoicingsetupdate)
- [msdyn_invoice_msdyn_orderinvoicingsetupdate_Invoice](#BKMK_msdyn_invoice_msdyn_orderinvoicingsetupdate_Invoice)
- [msdyn_msdyn_orderinvoicingdate_msdyn_orderinvoicingsetupdate_OrderInvoicingDate](#BKMK_msdyn_msdyn_orderinvoicingdate_msdyn_orderinvoicingsetupdate_OrderInvoicingDate)
- [msdyn_msdyn_orderinvoicingsetup_msdyn_orderinvoicingsetupdate_InvoiceSetup](#BKMK_msdyn_msdyn_orderinvoicingsetup_msdyn_orderinvoicingsetupdate_InvoiceSetup)
- [msdyn_salesorder_msdyn_orderinvoicingsetupdate_Order](#BKMK_msdyn_salesorder_msdyn_orderinvoicingsetupdate_Order)


### <a name="BKMK_lk_msdyn_orderinvoicingsetupdate_createdby"></a> lk_msdyn_orderinvoicingsetupdate_createdby

See systemuser Entity [lk_msdyn_orderinvoicingsetupdate_createdby](systemuser.md#BKMK_lk_msdyn_orderinvoicingsetupdate_createdby) One-To-Many relationship.

### <a name="BKMK_lk_msdyn_orderinvoicingsetupdate_createdonbehalfby"></a> lk_msdyn_orderinvoicingsetupdate_createdonbehalfby

See systemuser Entity [lk_msdyn_orderinvoicingsetupdate_createdonbehalfby](systemuser.md#BKMK_lk_msdyn_orderinvoicingsetupdate_createdonbehalfby) One-To-Many relationship.

### <a name="BKMK_lk_msdyn_orderinvoicingsetupdate_modifiedby"></a> lk_msdyn_orderinvoicingsetupdate_modifiedby

See systemuser Entity [lk_msdyn_orderinvoicingsetupdate_modifiedby](systemuser.md#BKMK_lk_msdyn_orderinvoicingsetupdate_modifiedby) One-To-Many relationship.

### <a name="BKMK_lk_msdyn_orderinvoicingsetupdate_modifiedonbehalfby"></a> lk_msdyn_orderinvoicingsetupdate_modifiedonbehalfby

See systemuser Entity [lk_msdyn_orderinvoicingsetupdate_modifiedonbehalfby](systemuser.md#BKMK_lk_msdyn_orderinvoicingsetupdate_modifiedonbehalfby) One-To-Many relationship.

### <a name="BKMK_user_msdyn_orderinvoicingsetupdate"></a> user_msdyn_orderinvoicingsetupdate

See systemuser Entity [user_msdyn_orderinvoicingsetupdate](systemuser.md#BKMK_user_msdyn_orderinvoicingsetupdate) One-To-Many relationship.

### <a name="BKMK_team_msdyn_orderinvoicingsetupdate"></a> team_msdyn_orderinvoicingsetupdate

See team Entity [team_msdyn_orderinvoicingsetupdate](team.md#BKMK_team_msdyn_orderinvoicingsetupdate) One-To-Many relationship.

### <a name="BKMK_business_unit_msdyn_orderinvoicingsetupdate"></a> business_unit_msdyn_orderinvoicingsetupdate

See businessunit Entity [business_unit_msdyn_orderinvoicingsetupdate](businessunit.md#BKMK_business_unit_msdyn_orderinvoicingsetupdate) One-To-Many relationship.

### <a name="BKMK_msdyn_invoice_msdyn_orderinvoicingsetupdate_Invoice"></a> msdyn_invoice_msdyn_orderinvoicingsetupdate_Invoice

See invoice Entity [msdyn_invoice_msdyn_orderinvoicingsetupdate_Invoice](invoice.md#BKMK_msdyn_invoice_msdyn_orderinvoicingsetupdate_Invoice) One-To-Many relationship.

### <a name="BKMK_msdyn_msdyn_orderinvoicingdate_msdyn_orderinvoicingsetupdate_OrderInvoicingDate"></a> msdyn_msdyn_orderinvoicingdate_msdyn_orderinvoicingsetupdate_OrderInvoicingDate

See msdyn_orderinvoicingdate Entity [msdyn_msdyn_orderinvoicingdate_msdyn_orderinvoicingsetupdate_OrderInvoicingDate](msdyn_orderinvoicingdate.md#BKMK_msdyn_msdyn_orderinvoicingdate_msdyn_orderinvoicingsetupdate_OrderInvoicingDate) One-To-Many relationship.

### <a name="BKMK_msdyn_msdyn_orderinvoicingsetup_msdyn_orderinvoicingsetupdate_InvoiceSetup"></a> msdyn_msdyn_orderinvoicingsetup_msdyn_orderinvoicingsetupdate_InvoiceSetup

See msdyn_orderinvoicingsetup Entity [msdyn_msdyn_orderinvoicingsetup_msdyn_orderinvoicingsetupdate_InvoiceSetup](msdyn_orderinvoicingsetup.md#BKMK_msdyn_msdyn_orderinvoicingsetup_msdyn_orderinvoicingsetupdate_InvoiceSetup) One-To-Many relationship.

### <a name="BKMK_msdyn_salesorder_msdyn_orderinvoicingsetupdate_Order"></a> msdyn_salesorder_msdyn_orderinvoicingsetupdate_Order

See salesorder Entity [msdyn_salesorder_msdyn_orderinvoicingsetupdate_Order](salesorder.md#BKMK_msdyn_salesorder_msdyn_orderinvoicingsetupdate_Order) One-To-Many relationship.

## See also

[About the Entity Reference](../about-entity-reference.md)<br />
[Programming reference for Dynamics 365 Customer Engagement](../programming-reference.md)<br />
[Web API Reference](/dynamics365/customer-engagement/web-api/about)<br />
<xref href="Microsoft.Dynamics.CRM.msdyn_orderinvoicingsetupdate?text=msdyn_orderinvoicingsetupdate EntityType" />