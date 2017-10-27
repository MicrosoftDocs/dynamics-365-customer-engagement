---
title: "msdyn_purchaseorderreceipt Entity Reference (Developer Guide for Dynamics 365 Customer Engagement)| MicrosoftDocs"
description: "Includes schema information and supported messages for the msdyn_purchaseorderreceipt entity."
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
# msdyn_purchaseorderreceipt Entity Reference

Specify purchase order receipt.

**Added by**: Field Service Solution<br />

## Messages

|Message|Web API Operation|SDK Assembly|
|-|-|-|
|Assign|PATCH [*org URI*]/api/data/v9.0/msdyn_purchaseorderreceipts(*msdyn_purchaseorderreceiptid*)<br />[Update](../webapi/update-delete-entities-using-web-api.md#basic-update) `ownerid` property.|<xref:Microsoft.Crm.Sdk.Messages.AssignRequest>|
|Create|POST [*org URI*]/api/data/v9.0/msdyn_purchaseorderreceipts<br />See [Create](../webapi/create-entity-web-api.md)|<xref:Microsoft.Xrm.Sdk.Messages.CreateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Create*>|
|Delete|DELETE [*org URI*]/api/data/v9.0/msdyn_purchaseorderreceipts(*msdyn_purchaseorderreceiptid*)<br />See [Delete](../webapi/update-delete-entities-using-web-api.md#basic-delete)|<xref:Microsoft.Xrm.Sdk.Messages.DeleteRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Delete*>|
|GrantAccess|<xref href="Microsoft.Dynamics.CRM.GrantAccess?text=GrantAccess Action" />|<xref:Microsoft.Crm.Sdk.Messages.GrantAccessRequest>|
|IsValidStateTransition|<xref href="Microsoft.Dynamics.CRM.IsValidStateTransition?text=IsValidStateTransition Function" />|<xref:Microsoft.Crm.Sdk.Messages.IsValidStateTransitionRequest>|
|ModifyAccess|<xref href="Microsoft.Dynamics.CRM.ModifyAccess?text=ModifyAccess Action" />|<xref:Microsoft.Crm.Sdk.Messages.ModifyAccessRequest>|
|Retrieve|GET [*org URI*]/api/data/v9.0/msdyn_purchaseorderreceipts(*msdyn_purchaseorderreceiptid*)<br />See [Retrieve](../webapi/retrieve-entity-using-web-api.md)|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Retrieve*>|
|RetrieveMultiple|GET [*org URI*]/api/data/v9.0/msdyn_purchaseorderreceipts<br />See [Query Data](../webapi/query-data-web-api.md)|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveMultipleRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.RetrieveMultiple*>|
|RetrievePrincipalAccess|<xref href="Microsoft.Dynamics.CRM.RetrievePrincipalAccess?text=RetrievePrincipalAccess Function" />|<xref:Microsoft.Crm.Sdk.Messages.RetrievePrincipalAccessRequest>|
|RetrieveSharedPrincipalsAndAccess|<xref href="Microsoft.Dynamics.CRM.RetrieveSharedPrincipalsAndAccess?text=RetrieveSharedPrincipalsAndAccess Function" />|<xref:Microsoft.Crm.Sdk.Messages.RetrieveSharedPrincipalsAndAccessRequest>|
|RevokeAccess|<xref href="Microsoft.Dynamics.CRM.RevokeAccess?text=RevokeAccess Action" />|<xref:Microsoft.Crm.Sdk.Messages.RevokeAccessRequest>|
|SetState|PATCH [*org URI*]/api/data/v9.0/msdyn_purchaseorderreceipts(*msdyn_purchaseorderreceiptid*)<br />[Update](../webapi/update-delete-entities-using-web-api.md#basic-update) `statecode` and `statuscode` properties.|<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|
|Update|PATCH [*org URI*]/api/data/v9.0/msdyn_purchaseorderreceipts(*msdyn_purchaseorderreceiptid*)<br />See [Update](../webapi/update-delete-entities-using-web-api.md#basic-update)|<xref:Microsoft.Xrm.Sdk.Messages.UpdateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Update*>|

## Properties

**DisplayName**: Purchase Order Receipt<br />
**DisplayCollectionName**: Purchase Order Receipts<br />
**SchemaName**: msdyn_purchaseorderreceipt<br />
**CollectionSchemaName**: msdyn_purchaseorderreceipts<br />
**LogicalName**: msdyn_purchaseorderreceipt<br />
**LogicalCollectionName**: msdyn_purchaseorderreceipts<br />
**EntitySetName**: msdyn_purchaseorderreceipts<br />
**PrimaryIdAttribute**: msdyn_purchaseorderreceiptid<br />
**PrimaryNameAttribute**: msdyn_name<br />
**OwnershipType**: UserOwned<br />
**IsBPFEntity**: False<br />
<a name="writable-attributes"></a>

## Writable attributes

These attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [msdyn_DateReceived](#BKMK_msdyn_DateReceived)
- [msdyn_name](#BKMK_msdyn_name)
- [msdyn_Note](#BKMK_msdyn_Note)
- [msdyn_PurchaseOrder](#BKMK_msdyn_PurchaseOrder)
- [msdyn_purchaseorderreceiptId](#BKMK_msdyn_purchaseorderreceiptId)
- [msdyn_ReceivedBy](#BKMK_msdyn_ReceivedBy)
- [msdyn_ShipVia](#BKMK_msdyn_ShipVia)
- [OverriddenCreatedOn](#BKMK_OverriddenCreatedOn)
- [OwnerId](#BKMK_OwnerId)
- [OwnerIdType](#BKMK_OwnerIdType)
- [processid](#BKMK_processid)
- [stageid](#BKMK_stageid)
- [statecode](#BKMK_statecode)
- [statuscode](#BKMK_statuscode)
- [TimeZoneRuleVersionNumber](#BKMK_TimeZoneRuleVersionNumber)
- [traversedpath](#BKMK_traversedpath)
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


### <a name="BKMK_msdyn_DateReceived"></a> msdyn_DateReceived

**Description**: <br />
**DisplayName**: Date Received<br />
**LogicalName**: msdyn_datereceived<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: ApplicationRequired<br />
**Type**: DateTime<br />
**DateTimeBehavior**: UserLocal<br />
**Format**: DateOnly


### <a name="BKMK_msdyn_name"></a> msdyn_name

**Description**: Enter the name of the custom entity.<br />
**DisplayName**: Name<br />
**LogicalName**: msdyn_name<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: ApplicationRequired<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_msdyn_Note"></a> msdyn_Note

**Description**: <br />
**DisplayName**: Note<br />
**LogicalName**: msdyn_note<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Memo<br />
**Format**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 2000


### <a name="BKMK_msdyn_PurchaseOrder"></a> msdyn_PurchaseOrder

**Description**: Unique identifier for Purchase Order associated with Purchase Order Receipt.<br />
**DisplayName**: Purchase Order<br />
**LogicalName**: msdyn_purchaseorder<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: ApplicationRequired<br />
**Type**: Lookup<br />
**Targets**: msdyn_purchaseorder


### <a name="BKMK_msdyn_purchaseorderreceiptId"></a> msdyn_purchaseorderreceiptId

**Description**: Shows the entity instances.<br />
**DisplayName**: Purchase Order Receipt<br />
**LogicalName**: msdyn_purchaseorderreceiptid<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: SystemRequired<br />
**IsValidForUpdate**: False<br />
**Type**: Uniqueidentifier<br />


### <a name="BKMK_msdyn_ReceivedBy"></a> msdyn_ReceivedBy

**Description**: Unique identifier for User associated with Purchase Order Receipt.<br />
**DisplayName**: Received By<br />
**LogicalName**: msdyn_receivedby<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: systemuser


### <a name="BKMK_msdyn_ShipVia"></a> msdyn_ShipVia

**Description**: Unique identifier for Ship Via associated with Purchase Order Receipt.<br />
**DisplayName**: Ship Via<br />
**LogicalName**: msdyn_shipvia<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: msdyn_shipvia


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


### <a name="BKMK_processid"></a> processid

**Description**: Contains the ID of the process associated with the entity.<br />
**DisplayName**: Process Id<br />
**LogicalName**: processid<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Uniqueidentifier<br />


### <a name="BKMK_stageid"></a> stageid

**Description**: Contains the ID of the stage where the entity is located.<br />
**DisplayName**: Stage Id<br />
**LogicalName**: stageid<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Uniqueidentifier<br />


### <a name="BKMK_statecode"></a> statecode

**Description**: Status of the Purchase Order Receipt<br />
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

**Description**: Reason for the status of the Purchase Order Receipt<br />
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


### <a name="BKMK_traversedpath"></a> traversedpath

**Description**: Shows a comma-separated list of string values that represent the unique identifiers of stages in a business process flow instance in the order that they occur.<br />
**DisplayName**: Traversed Path<br />
**LogicalName**: traversedpath<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 1250


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
- [msdyn_PurchaseOrderName](#BKMK_msdyn_PurchaseOrderName)
- [msdyn_ReceivedByName](#BKMK_msdyn_ReceivedByName)
- [msdyn_ReceivedByYomiName](#BKMK_msdyn_ReceivedByYomiName)
- [msdyn_ShipViaName](#BKMK_msdyn_ShipViaName)
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


### <a name="BKMK_msdyn_PurchaseOrderName"></a> msdyn_PurchaseOrderName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: msdyn_purchaseordername<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_msdyn_ReceivedByName"></a> msdyn_ReceivedByName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: msdyn_receivedbyname<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 200


### <a name="BKMK_msdyn_ReceivedByYomiName"></a> msdyn_ReceivedByYomiName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: msdyn_receivedbyyominame<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 200


### <a name="BKMK_msdyn_ShipViaName"></a> msdyn_ShipViaName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: msdyn_shipvianame<br />
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

- [msdyn_purchaseorderreceipt_ActivityPointers](#BKMK_msdyn_purchaseorderreceipt_ActivityPointers)
- [msdyn_purchaseorderreceipt_msdyn_approvals](#BKMK_msdyn_purchaseorderreceipt_msdyn_approvals)
- [msdyn_purchaseorderreceipt_msdyn_bookingalerts](#BKMK_msdyn_purchaseorderreceipt_msdyn_bookingalerts)
- [msdyn_purchaseorderreceipt_SyncErrors](#BKMK_msdyn_purchaseorderreceipt_SyncErrors)
- [msdyn_purchaseorderreceipt_DuplicateMatchingRecord](#BKMK_msdyn_purchaseorderreceipt_DuplicateMatchingRecord)
- [msdyn_purchaseorderreceipt_DuplicateBaseRecord](#BKMK_msdyn_purchaseorderreceipt_DuplicateBaseRecord)
- [msdyn_purchaseorderreceipt_SharePointDocumentLocations](#BKMK_msdyn_purchaseorderreceipt_SharePointDocumentLocations)
- [msdyn_purchaseorderreceipt_SharePointDocuments](#BKMK_msdyn_purchaseorderreceipt_SharePointDocuments)
- [msdyn_purchaseorderreceipt_AsyncOperations](#BKMK_msdyn_purchaseorderreceipt_AsyncOperations)
- [msdyn_purchaseorderreceipt_MailboxTrackingFolders](#BKMK_msdyn_purchaseorderreceipt_MailboxTrackingFolders)
- [msdyn_purchaseorderreceipt_UserEntityInstanceDatas](#BKMK_msdyn_purchaseorderreceipt_UserEntityInstanceDatas)
- [msdyn_purchaseorderreceipt_ProcessSession](#BKMK_msdyn_purchaseorderreceipt_ProcessSession)
- [msdyn_purchaseorderreceipt_BulkDeleteFailures](#BKMK_msdyn_purchaseorderreceipt_BulkDeleteFailures)
- [msdyn_purchaseorderreceipt_PrincipalObjectAttributeAccesses](#BKMK_msdyn_purchaseorderreceipt_PrincipalObjectAttributeAccesses)
- [msdyn_purchaseorderreceipt_Appointments](#BKMK_msdyn_purchaseorderreceipt_Appointments)
- [msdyn_purchaseorderreceipt_Emails](#BKMK_msdyn_purchaseorderreceipt_Emails)
- [msdyn_purchaseorderreceipt_Faxes](#BKMK_msdyn_purchaseorderreceipt_Faxes)
- [msdyn_purchaseorderreceipt_Letters](#BKMK_msdyn_purchaseorderreceipt_Letters)
- [msdyn_purchaseorderreceipt_PhoneCalls](#BKMK_msdyn_purchaseorderreceipt_PhoneCalls)
- [msdyn_purchaseorderreceipt_Tasks](#BKMK_msdyn_purchaseorderreceipt_Tasks)
- [msdyn_purchaseorderreceipt_RecurringAppointmentMasters](#BKMK_msdyn_purchaseorderreceipt_RecurringAppointmentMasters)
- [msdyn_purchaseorderreceipt_SocialActivities](#BKMK_msdyn_purchaseorderreceipt_SocialActivities)
- [msdyn_purchaseorderreceipt_connections1](#BKMK_msdyn_purchaseorderreceipt_connections1)
- [msdyn_purchaseorderreceipt_connections2](#BKMK_msdyn_purchaseorderreceipt_connections2)
- [msdyn_purchaseorderreceipt_Annotations](#BKMK_msdyn_purchaseorderreceipt_Annotations)
- [msdyn_purchaseorderreceipt_ServiceAppointments](#BKMK_msdyn_purchaseorderreceipt_ServiceAppointments)
- [bpf_msdyn_purchaseorderreceipt_msdyn_bpf_2c5fe86acc8b414b8322ae571000c799](#BKMK_bpf_msdyn_purchaseorderreceipt_msdyn_bpf_2c5fe86acc8b414b8322ae571000c799)
- [msdyn_msdyn_purchaseorderreceipt_msdyn_purchaseorderreceiptproduct_PurchaseOrderReceipt](#BKMK_msdyn_msdyn_purchaseorderreceipt_msdyn_purchaseorderreceiptproduct_PurchaseOrderReceipt)


### <a name="BKMK_msdyn_purchaseorderreceipt_ActivityPointers"></a> msdyn_purchaseorderreceipt_ActivityPointers

Same as activitypointer entity [msdyn_purchaseorderreceipt_ActivityPointers](activitypointer.md#BKMK_msdyn_purchaseorderreceipt_ActivityPointers) Many-To-One relationship.

**ReferencingEntity**: activitypointer<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_purchaseorderreceipt_ActivityPointers<br />
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


### <a name="BKMK_msdyn_purchaseorderreceipt_msdyn_approvals"></a> msdyn_purchaseorderreceipt_msdyn_approvals

Same as msdyn_approval entity [msdyn_purchaseorderreceipt_msdyn_approvals](msdyn_approval.md#BKMK_msdyn_purchaseorderreceipt_msdyn_approvals) Many-To-One relationship.

**ReferencingEntity**: msdyn_approval<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_purchaseorderreceipt_msdyn_approvals<br />
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


### <a name="BKMK_msdyn_purchaseorderreceipt_msdyn_bookingalerts"></a> msdyn_purchaseorderreceipt_msdyn_bookingalerts

Same as msdyn_bookingalert entity [msdyn_purchaseorderreceipt_msdyn_bookingalerts](msdyn_bookingalert.md#BKMK_msdyn_purchaseorderreceipt_msdyn_bookingalerts) Many-To-One relationship.

**ReferencingEntity**: msdyn_bookingalert<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_purchaseorderreceipt_msdyn_bookingalerts<br />
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


### <a name="BKMK_msdyn_purchaseorderreceipt_SyncErrors"></a> msdyn_purchaseorderreceipt_SyncErrors

Same as syncerror entity [msdyn_purchaseorderreceipt_SyncErrors](syncerror.md#BKMK_msdyn_purchaseorderreceipt_SyncErrors) Many-To-One relationship.

**ReferencingEntity**: syncerror<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_purchaseorderreceipt_SyncErrors<br />
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


### <a name="BKMK_msdyn_purchaseorderreceipt_DuplicateMatchingRecord"></a> msdyn_purchaseorderreceipt_DuplicateMatchingRecord

Same as duplicaterecord entity [msdyn_purchaseorderreceipt_DuplicateMatchingRecord](duplicaterecord.md#BKMK_msdyn_purchaseorderreceipt_DuplicateMatchingRecord) Many-To-One relationship.

**ReferencingEntity**: duplicaterecord<br />
**ReferencingAttribute**: duplicaterecordid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_purchaseorderreceipt_DuplicateMatchingRecord<br />
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


### <a name="BKMK_msdyn_purchaseorderreceipt_DuplicateBaseRecord"></a> msdyn_purchaseorderreceipt_DuplicateBaseRecord

Same as duplicaterecord entity [msdyn_purchaseorderreceipt_DuplicateBaseRecord](duplicaterecord.md#BKMK_msdyn_purchaseorderreceipt_DuplicateBaseRecord) Many-To-One relationship.

**ReferencingEntity**: duplicaterecord<br />
**ReferencingAttribute**: baserecordid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_purchaseorderreceipt_DuplicateBaseRecord<br />
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


### <a name="BKMK_msdyn_purchaseorderreceipt_SharePointDocumentLocations"></a> msdyn_purchaseorderreceipt_SharePointDocumentLocations

Same as sharepointdocumentlocation entity [msdyn_purchaseorderreceipt_SharePointDocumentLocations](sharepointdocumentlocation.md#BKMK_msdyn_purchaseorderreceipt_SharePointDocumentLocations) Many-To-One relationship.

**ReferencingEntity**: sharepointdocumentlocation<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_purchaseorderreceipt_SharePointDocumentLocations<br />
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


### <a name="BKMK_msdyn_purchaseorderreceipt_SharePointDocuments"></a> msdyn_purchaseorderreceipt_SharePointDocuments

Same as sharepointdocument entity [msdyn_purchaseorderreceipt_SharePointDocuments](sharepointdocument.md#BKMK_msdyn_purchaseorderreceipt_SharePointDocuments) Many-To-One relationship.

**ReferencingEntity**: sharepointdocument<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_purchaseorderreceipt_SharePointDocuments<br />
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


### <a name="BKMK_msdyn_purchaseorderreceipt_AsyncOperations"></a> msdyn_purchaseorderreceipt_AsyncOperations

Same as asyncoperation entity [msdyn_purchaseorderreceipt_AsyncOperations](asyncoperation.md#BKMK_msdyn_purchaseorderreceipt_AsyncOperations) Many-To-One relationship.

**ReferencingEntity**: asyncoperation<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_purchaseorderreceipt_AsyncOperations<br />
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


### <a name="BKMK_msdyn_purchaseorderreceipt_MailboxTrackingFolders"></a> msdyn_purchaseorderreceipt_MailboxTrackingFolders

Same as mailboxtrackingfolder entity [msdyn_purchaseorderreceipt_MailboxTrackingFolders](mailboxtrackingfolder.md#BKMK_msdyn_purchaseorderreceipt_MailboxTrackingFolders) Many-To-One relationship.

**ReferencingEntity**: mailboxtrackingfolder<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_purchaseorderreceipt_MailboxTrackingFolders<br />
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


### <a name="BKMK_msdyn_purchaseorderreceipt_UserEntityInstanceDatas"></a> msdyn_purchaseorderreceipt_UserEntityInstanceDatas

Same as userentityinstancedata entity [msdyn_purchaseorderreceipt_UserEntityInstanceDatas](userentityinstancedata.md#BKMK_msdyn_purchaseorderreceipt_UserEntityInstanceDatas) Many-To-One relationship.

**ReferencingEntity**: userentityinstancedata<br />
**ReferencingAttribute**: objectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_purchaseorderreceipt_UserEntityInstanceDatas<br />
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


### <a name="BKMK_msdyn_purchaseorderreceipt_ProcessSession"></a> msdyn_purchaseorderreceipt_ProcessSession

Same as processsession entity [msdyn_purchaseorderreceipt_ProcessSession](processsession.md#BKMK_msdyn_purchaseorderreceipt_ProcessSession) Many-To-One relationship.

**ReferencingEntity**: processsession<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_purchaseorderreceipt_ProcessSession<br />
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


### <a name="BKMK_msdyn_purchaseorderreceipt_BulkDeleteFailures"></a> msdyn_purchaseorderreceipt_BulkDeleteFailures

Same as bulkdeletefailure entity [msdyn_purchaseorderreceipt_BulkDeleteFailures](bulkdeletefailure.md#BKMK_msdyn_purchaseorderreceipt_BulkDeleteFailures) Many-To-One relationship.

**ReferencingEntity**: bulkdeletefailure<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_purchaseorderreceipt_BulkDeleteFailures<br />
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


### <a name="BKMK_msdyn_purchaseorderreceipt_PrincipalObjectAttributeAccesses"></a> msdyn_purchaseorderreceipt_PrincipalObjectAttributeAccesses

Same as principalobjectattributeaccess entity [msdyn_purchaseorderreceipt_PrincipalObjectAttributeAccesses](principalobjectattributeaccess.md#BKMK_msdyn_purchaseorderreceipt_PrincipalObjectAttributeAccesses) Many-To-One relationship.

**ReferencingEntity**: principalobjectattributeaccess<br />
**ReferencingAttribute**: objectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_purchaseorderreceipt_PrincipalObjectAttributeAccesses<br />
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


### <a name="BKMK_msdyn_purchaseorderreceipt_Appointments"></a> msdyn_purchaseorderreceipt_Appointments

Same as appointment entity [msdyn_purchaseorderreceipt_Appointments](appointment.md#BKMK_msdyn_purchaseorderreceipt_Appointments) Many-To-One relationship.

**ReferencingEntity**: appointment<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_purchaseorderreceipt_Appointments<br />
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


### <a name="BKMK_msdyn_purchaseorderreceipt_Emails"></a> msdyn_purchaseorderreceipt_Emails

Same as email entity [msdyn_purchaseorderreceipt_Emails](email.md#BKMK_msdyn_purchaseorderreceipt_Emails) Many-To-One relationship.

**ReferencingEntity**: email<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_purchaseorderreceipt_Emails<br />
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


### <a name="BKMK_msdyn_purchaseorderreceipt_Faxes"></a> msdyn_purchaseorderreceipt_Faxes

Same as fax entity [msdyn_purchaseorderreceipt_Faxes](fax.md#BKMK_msdyn_purchaseorderreceipt_Faxes) Many-To-One relationship.

**ReferencingEntity**: fax<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_purchaseorderreceipt_Faxes<br />
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


### <a name="BKMK_msdyn_purchaseorderreceipt_Letters"></a> msdyn_purchaseorderreceipt_Letters

Same as letter entity [msdyn_purchaseorderreceipt_Letters](letter.md#BKMK_msdyn_purchaseorderreceipt_Letters) Many-To-One relationship.

**ReferencingEntity**: letter<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_purchaseorderreceipt_Letters<br />
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


### <a name="BKMK_msdyn_purchaseorderreceipt_PhoneCalls"></a> msdyn_purchaseorderreceipt_PhoneCalls

Same as phonecall entity [msdyn_purchaseorderreceipt_PhoneCalls](phonecall.md#BKMK_msdyn_purchaseorderreceipt_PhoneCalls) Many-To-One relationship.

**ReferencingEntity**: phonecall<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_purchaseorderreceipt_PhoneCalls<br />
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


### <a name="BKMK_msdyn_purchaseorderreceipt_Tasks"></a> msdyn_purchaseorderreceipt_Tasks

Same as task entity [msdyn_purchaseorderreceipt_Tasks](task.md#BKMK_msdyn_purchaseorderreceipt_Tasks) Many-To-One relationship.

**ReferencingEntity**: task<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_purchaseorderreceipt_Tasks<br />
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


### <a name="BKMK_msdyn_purchaseorderreceipt_RecurringAppointmentMasters"></a> msdyn_purchaseorderreceipt_RecurringAppointmentMasters

Same as recurringappointmentmaster entity [msdyn_purchaseorderreceipt_RecurringAppointmentMasters](recurringappointmentmaster.md#BKMK_msdyn_purchaseorderreceipt_RecurringAppointmentMasters) Many-To-One relationship.

**ReferencingEntity**: recurringappointmentmaster<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_purchaseorderreceipt_RecurringAppointmentMasters<br />
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


### <a name="BKMK_msdyn_purchaseorderreceipt_SocialActivities"></a> msdyn_purchaseorderreceipt_SocialActivities

Same as socialactivity entity [msdyn_purchaseorderreceipt_SocialActivities](socialactivity.md#BKMK_msdyn_purchaseorderreceipt_SocialActivities) Many-To-One relationship.

**ReferencingEntity**: socialactivity<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_purchaseorderreceipt_SocialActivities<br />
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


### <a name="BKMK_msdyn_purchaseorderreceipt_connections1"></a> msdyn_purchaseorderreceipt_connections1

Same as connection entity [msdyn_purchaseorderreceipt_connections1](connection.md#BKMK_msdyn_purchaseorderreceipt_connections1) Many-To-One relationship.

**ReferencingEntity**: connection<br />
**ReferencingAttribute**: record1id<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_purchaseorderreceipt_connections1<br />
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


### <a name="BKMK_msdyn_purchaseorderreceipt_connections2"></a> msdyn_purchaseorderreceipt_connections2

Same as connection entity [msdyn_purchaseorderreceipt_connections2](connection.md#BKMK_msdyn_purchaseorderreceipt_connections2) Many-To-One relationship.

**ReferencingEntity**: connection<br />
**ReferencingAttribute**: record2id<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_purchaseorderreceipt_connections2<br />
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


### <a name="BKMK_msdyn_purchaseorderreceipt_Annotations"></a> msdyn_purchaseorderreceipt_Annotations

Same as annotation entity [msdyn_purchaseorderreceipt_Annotations](annotation.md#BKMK_msdyn_purchaseorderreceipt_Annotations) Many-To-One relationship.

**ReferencingEntity**: annotation<br />
**ReferencingAttribute**: objectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_purchaseorderreceipt_Annotations<br />
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


### <a name="BKMK_msdyn_purchaseorderreceipt_ServiceAppointments"></a> msdyn_purchaseorderreceipt_ServiceAppointments

Same as serviceappointment entity [msdyn_purchaseorderreceipt_ServiceAppointments](serviceappointment.md#BKMK_msdyn_purchaseorderreceipt_ServiceAppointments) Many-To-One relationship.

**ReferencingEntity**: serviceappointment<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_purchaseorderreceipt_ServiceAppointments<br />
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


### <a name="BKMK_bpf_msdyn_purchaseorderreceipt_msdyn_bpf_2c5fe86acc8b414b8322ae571000c799"></a> bpf_msdyn_purchaseorderreceipt_msdyn_bpf_2c5fe86acc8b414b8322ae571000c799

Same as msdyn_bpf_2c5fe86acc8b414b8322ae571000c799 entity [bpf_msdyn_purchaseorderreceipt_msdyn_bpf_2c5fe86acc8b414b8322ae571000c799](msdyn_bpf_2c5fe86acc8b414b8322ae571000c799.md#BKMK_bpf_msdyn_purchaseorderreceipt_msdyn_bpf_2c5fe86acc8b414b8322ae571000c799) Many-To-One relationship.

**ReferencingEntity**: msdyn_bpf_2c5fe86acc8b414b8322ae571000c799<br />
**ReferencingAttribute**: bpf_msdyn_purchaseorderreceiptid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: bpf_msdyn_purchaseorderreceipt_msdyn_bpf_2c5fe86acc8b414b8322ae571000c799<br />
**AssociatedMenuConfiguration**:

- **Behavior**: UseLabel
- **Group**: Details
- **Label**: msdyn_purchaseorderreceipt
- **Order**: 10000

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: RemoveLink
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_msdyn_msdyn_purchaseorderreceipt_msdyn_purchaseorderreceiptproduct_PurchaseOrderReceipt"></a> msdyn_msdyn_purchaseorderreceipt_msdyn_purchaseorderreceiptproduct_PurchaseOrderReceipt

Same as msdyn_purchaseorderreceiptproduct entity [msdyn_msdyn_purchaseorderreceipt_msdyn_purchaseorderreceiptproduct_PurchaseOrderReceipt](msdyn_purchaseorderreceiptproduct.md#BKMK_msdyn_msdyn_purchaseorderreceipt_msdyn_purchaseorderreceiptproduct_PurchaseOrderReceipt) Many-To-One relationship.

**ReferencingEntity**: msdyn_purchaseorderreceiptproduct<br />
**ReferencingAttribute**: msdyn_purchaseorderreceipt<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_msdyn_purchaseorderreceipt_msdyn_purchaseorderreceiptproduct_PurchaseOrderReceipt<br />
**AssociatedMenuConfiguration**:

- **Behavior**: UseCollectionName
- **Group**: Details
- **Label**: 
- **Order**: 10000

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

- [lk_msdyn_purchaseorderreceipt_createdby](#BKMK_lk_msdyn_purchaseorderreceipt_createdby)
- [lk_msdyn_purchaseorderreceipt_createdonbehalfby](#BKMK_lk_msdyn_purchaseorderreceipt_createdonbehalfby)
- [lk_msdyn_purchaseorderreceipt_modifiedby](#BKMK_lk_msdyn_purchaseorderreceipt_modifiedby)
- [lk_msdyn_purchaseorderreceipt_modifiedonbehalfby](#BKMK_lk_msdyn_purchaseorderreceipt_modifiedonbehalfby)
- [user_msdyn_purchaseorderreceipt](#BKMK_user_msdyn_purchaseorderreceipt)
- [team_msdyn_purchaseorderreceipt](#BKMK_team_msdyn_purchaseorderreceipt)
- [business_unit_msdyn_purchaseorderreceipt](#BKMK_business_unit_msdyn_purchaseorderreceipt)
- [processstage_msdyn_purchaseorderreceipt](#BKMK_processstage_msdyn_purchaseorderreceipt)
- [msdyn_msdyn_purchaseorder_msdyn_purchaseorderreceipt_PurchaseOrder](#BKMK_msdyn_msdyn_purchaseorder_msdyn_purchaseorderreceipt_PurchaseOrder)
- [msdyn_msdyn_shipvia_msdyn_purchaseorderreceipt_ShipVia](#BKMK_msdyn_msdyn_shipvia_msdyn_purchaseorderreceipt_ShipVia)
- [msdyn_systemuser_msdyn_purchaseorderreceipt_ReceivedBy](#BKMK_msdyn_systemuser_msdyn_purchaseorderreceipt_ReceivedBy)


### <a name="BKMK_lk_msdyn_purchaseorderreceipt_createdby"></a> lk_msdyn_purchaseorderreceipt_createdby

See systemuser Entity [lk_msdyn_purchaseorderreceipt_createdby](systemuser.md#BKMK_lk_msdyn_purchaseorderreceipt_createdby) One-To-Many relationship.

### <a name="BKMK_lk_msdyn_purchaseorderreceipt_createdonbehalfby"></a> lk_msdyn_purchaseorderreceipt_createdonbehalfby

See systemuser Entity [lk_msdyn_purchaseorderreceipt_createdonbehalfby](systemuser.md#BKMK_lk_msdyn_purchaseorderreceipt_createdonbehalfby) One-To-Many relationship.

### <a name="BKMK_lk_msdyn_purchaseorderreceipt_modifiedby"></a> lk_msdyn_purchaseorderreceipt_modifiedby

See systemuser Entity [lk_msdyn_purchaseorderreceipt_modifiedby](systemuser.md#BKMK_lk_msdyn_purchaseorderreceipt_modifiedby) One-To-Many relationship.

### <a name="BKMK_lk_msdyn_purchaseorderreceipt_modifiedonbehalfby"></a> lk_msdyn_purchaseorderreceipt_modifiedonbehalfby

See systemuser Entity [lk_msdyn_purchaseorderreceipt_modifiedonbehalfby](systemuser.md#BKMK_lk_msdyn_purchaseorderreceipt_modifiedonbehalfby) One-To-Many relationship.

### <a name="BKMK_user_msdyn_purchaseorderreceipt"></a> user_msdyn_purchaseorderreceipt

See systemuser Entity [user_msdyn_purchaseorderreceipt](systemuser.md#BKMK_user_msdyn_purchaseorderreceipt) One-To-Many relationship.

### <a name="BKMK_team_msdyn_purchaseorderreceipt"></a> team_msdyn_purchaseorderreceipt

See team Entity [team_msdyn_purchaseorderreceipt](team.md#BKMK_team_msdyn_purchaseorderreceipt) One-To-Many relationship.

### <a name="BKMK_business_unit_msdyn_purchaseorderreceipt"></a> business_unit_msdyn_purchaseorderreceipt

See businessunit Entity [business_unit_msdyn_purchaseorderreceipt](businessunit.md#BKMK_business_unit_msdyn_purchaseorderreceipt) One-To-Many relationship.

### <a name="BKMK_processstage_msdyn_purchaseorderreceipt"></a> processstage_msdyn_purchaseorderreceipt

See processstage Entity [processstage_msdyn_purchaseorderreceipt](processstage.md#BKMK_processstage_msdyn_purchaseorderreceipt) One-To-Many relationship.

### <a name="BKMK_msdyn_msdyn_purchaseorder_msdyn_purchaseorderreceipt_PurchaseOrder"></a> msdyn_msdyn_purchaseorder_msdyn_purchaseorderreceipt_PurchaseOrder

See msdyn_purchaseorder Entity [msdyn_msdyn_purchaseorder_msdyn_purchaseorderreceipt_PurchaseOrder](msdyn_purchaseorder.md#BKMK_msdyn_msdyn_purchaseorder_msdyn_purchaseorderreceipt_PurchaseOrder) One-To-Many relationship.

### <a name="BKMK_msdyn_msdyn_shipvia_msdyn_purchaseorderreceipt_ShipVia"></a> msdyn_msdyn_shipvia_msdyn_purchaseorderreceipt_ShipVia

See msdyn_shipvia Entity [msdyn_msdyn_shipvia_msdyn_purchaseorderreceipt_ShipVia](msdyn_shipvia.md#BKMK_msdyn_msdyn_shipvia_msdyn_purchaseorderreceipt_ShipVia) One-To-Many relationship.

### <a name="BKMK_msdyn_systemuser_msdyn_purchaseorderreceipt_ReceivedBy"></a> msdyn_systemuser_msdyn_purchaseorderreceipt_ReceivedBy

See systemuser Entity [msdyn_systemuser_msdyn_purchaseorderreceipt_ReceivedBy](systemuser.md#BKMK_msdyn_systemuser_msdyn_purchaseorderreceipt_ReceivedBy) One-To-Many relationship.

## See also

[About the Entity Reference](../about-entity-reference.md)<br />
[Programming reference for Dynamics 365 Customer Engagement](../programming-reference.md)<br />
[Web API Reference](/dynamics365/customer-engagement/web-api/about)<br />
<xref href="Microsoft.Dynamics.CRM.msdyn_purchaseorderreceipt?text=msdyn_purchaseorderreceipt EntityType" />