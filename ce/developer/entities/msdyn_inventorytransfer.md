---
title: "msdyn_inventorytransfer Entity Reference (Developer Guide for Dynamics 365 Customer Engagement)| MicrosoftDocs"
description: "Includes schema information and supported messages for the msdyn_inventorytransfer entity."
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
# msdyn_inventorytransfer Entity Reference

[!INCLUDE[](../../includes/cc_applies_to_update_9_0_0.md)]

Records inventory adjustments

**Added by**: Field Service Solution<br />

## Messages

|Message|Web API Operation|SDK Assembly|
|-|-|-|
|Assign|PATCH [*org URI*]/api/data/v9.0/msdyn_inventorytransfers(*msdyn_inventorytransferid*)<br />[Update](../webapi/update-delete-entities-using-web-api.md#basic-update) `ownerid` property.|<xref:Microsoft.Crm.Sdk.Messages.AssignRequest>|
|Create|POST [*org URI*]/api/data/v9.0/msdyn_inventorytransfers<br />See [Create](../webapi/create-entity-web-api.md)|<xref:Microsoft.Xrm.Sdk.Messages.CreateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Create*>|
|Delete|DELETE [*org URI*]/api/data/v9.0/msdyn_inventorytransfers(*msdyn_inventorytransferid*)<br />See [Delete](../webapi/update-delete-entities-using-web-api.md#basic-delete)|<xref:Microsoft.Xrm.Sdk.Messages.DeleteRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Delete*>|
|GrantAccess|<xref href="Microsoft.Dynamics.CRM.GrantAccess?text=GrantAccess Action" />|<xref:Microsoft.Crm.Sdk.Messages.GrantAccessRequest>|
|IsValidStateTransition|<xref href="Microsoft.Dynamics.CRM.IsValidStateTransition?text=IsValidStateTransition Function" />|<xref:Microsoft.Crm.Sdk.Messages.IsValidStateTransitionRequest>|
|ModifyAccess|<xref href="Microsoft.Dynamics.CRM.ModifyAccess?text=ModifyAccess Action" />|<xref:Microsoft.Crm.Sdk.Messages.ModifyAccessRequest>|
|Retrieve|GET [*org URI*]/api/data/v9.0/msdyn_inventorytransfers(*msdyn_inventorytransferid*)<br />See [Retrieve](../webapi/retrieve-entity-using-web-api.md)|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Retrieve*>|
|RetrieveMultiple|GET [*org URI*]/api/data/v9.0/msdyn_inventorytransfers<br />See [Query Data](../webapi/query-data-web-api.md)|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveMultipleRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.RetrieveMultiple*>|
|RetrievePrincipalAccess|<xref href="Microsoft.Dynamics.CRM.RetrievePrincipalAccess?text=RetrievePrincipalAccess Function" />|<xref:Microsoft.Crm.Sdk.Messages.RetrievePrincipalAccessRequest>|
|RetrieveSharedPrincipalsAndAccess|<xref href="Microsoft.Dynamics.CRM.RetrieveSharedPrincipalsAndAccess?text=RetrieveSharedPrincipalsAndAccess Function" />|<xref:Microsoft.Crm.Sdk.Messages.RetrieveSharedPrincipalsAndAccessRequest>|
|RevokeAccess|<xref href="Microsoft.Dynamics.CRM.RevokeAccess?text=RevokeAccess Action" />|<xref:Microsoft.Crm.Sdk.Messages.RevokeAccessRequest>|
|SetState|PATCH [*org URI*]/api/data/v9.0/msdyn_inventorytransfers(*msdyn_inventorytransferid*)<br />[Update](../webapi/update-delete-entities-using-web-api.md#basic-update) `statecode` and `statuscode` properties.|<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|
|Update|PATCH [*org URI*]/api/data/v9.0/msdyn_inventorytransfers(*msdyn_inventorytransferid*)<br />See [Update](../webapi/update-delete-entities-using-web-api.md#basic-update)|<xref:Microsoft.Xrm.Sdk.Messages.UpdateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Update*>|

## Properties

**DisplayName**: Inventory Transfer<br />
**DisplayCollectionName**: Inventory Transfers<br />
**SchemaName**: msdyn_inventorytransfer<br />
**CollectionSchemaName**: msdyn_inventorytransfers<br />
**LogicalName**: msdyn_inventorytransfer<br />
**LogicalCollectionName**: msdyn_inventorytransfers<br />
**EntitySetName**: msdyn_inventorytransfers<br />
**PrimaryIdAttribute**: msdyn_inventorytransferid<br />
**PrimaryNameAttribute**: msdyn_name<br />
**OwnershipType**: UserOwned<br />
**IsBPFEntity**: False<br />
<a name="writable-attributes"></a>

## Writable attributes

These attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [msdyn_Description](#BKMK_msdyn_Description)
- [msdyn_DestinationWarehouse](#BKMK_msdyn_DestinationWarehouse)
- [msdyn_inventorytransferId](#BKMK_msdyn_inventorytransferId)
- [msdyn_name](#BKMK_msdyn_name)
- [msdyn_SourceWarehouse](#BKMK_msdyn_SourceWarehouse)
- [msdyn_TransferredByResource](#BKMK_msdyn_TransferredByResource)
- [msdyn_TransferTime](#BKMK_msdyn_TransferTime)
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


### <a name="BKMK_msdyn_Description"></a> msdyn_Description

**Description**: <br />
**DisplayName**: Description<br />
**LogicalName**: msdyn_description<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Memo<br />
**Format**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 2000


### <a name="BKMK_msdyn_DestinationWarehouse"></a> msdyn_DestinationWarehouse

**Description**: Unique identifier for Warehouse associated with Inventory Transfer.<br />
**DisplayName**: Destination Warehouse<br />
**LogicalName**: msdyn_destinationwarehouse<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: ApplicationRequired<br />
**Type**: Lookup<br />
**Targets**: msdyn_warehouse


### <a name="BKMK_msdyn_inventorytransferId"></a> msdyn_inventorytransferId

**Description**: Shows the entity instances.<br />
**DisplayName**: Inventory Transfer<br />
**LogicalName**: msdyn_inventorytransferid<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: SystemRequired<br />
**IsValidForUpdate**: False<br />
**Type**: Uniqueidentifier<br />


### <a name="BKMK_msdyn_name"></a> msdyn_name

**Description**: Enter the name of the custom entity.<br />
**DisplayName**: Transfer No<br />
**LogicalName**: msdyn_name<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: Recommended<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_msdyn_SourceWarehouse"></a> msdyn_SourceWarehouse

**Description**: Unique identifier for Warehouse associated with Inventory Transfer.<br />
**DisplayName**: Source Warehouse<br />
**LogicalName**: msdyn_sourcewarehouse<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: ApplicationRequired<br />
**Type**: Lookup<br />
**Targets**: msdyn_warehouse


### <a name="BKMK_msdyn_TransferredByResource"></a> msdyn_TransferredByResource

**Description**: Unique identifier for Resource associated with Inventory Transfer.<br />
**DisplayName**: Transferred By Resource<br />
**LogicalName**: msdyn_transferredbyresource<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: bookableresource


### <a name="BKMK_msdyn_TransferTime"></a> msdyn_TransferTime

**Description**: <br />
**DisplayName**: Transfer Time<br />
**LogicalName**: msdyn_transfertime<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: DateTime<br />
**DateTimeBehavior**: UserLocal<br />
**Format**: DateAndTime


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

**Description**: Status of the Inventory Transfer<br />
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

**Description**: Reason for the status of the Inventory Transfer<br />
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
- [msdyn_DestinationWarehouseName](#BKMK_msdyn_DestinationWarehouseName)
- [msdyn_SourceWarehouseName](#BKMK_msdyn_SourceWarehouseName)
- [msdyn_TransferredByResourceName](#BKMK_msdyn_TransferredByResourceName)
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


### <a name="BKMK_msdyn_DestinationWarehouseName"></a> msdyn_DestinationWarehouseName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: msdyn_destinationwarehousename<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_msdyn_SourceWarehouseName"></a> msdyn_SourceWarehouseName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: msdyn_sourcewarehousename<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_msdyn_TransferredByResourceName"></a> msdyn_TransferredByResourceName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: msdyn_transferredbyresourcename<br />
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

- [msdyn_inventorytransfer_ActivityPointers](#BKMK_msdyn_inventorytransfer_ActivityPointers)
- [msdyn_inventorytransfer_msdyn_approvals](#BKMK_msdyn_inventorytransfer_msdyn_approvals)
- [msdyn_inventorytransfer_msdyn_bookingalerts](#BKMK_msdyn_inventorytransfer_msdyn_bookingalerts)
- [msdyn_inventorytransfer_SyncErrors](#BKMK_msdyn_inventorytransfer_SyncErrors)
- [msdyn_inventorytransfer_DuplicateMatchingRecord](#BKMK_msdyn_inventorytransfer_DuplicateMatchingRecord)
- [msdyn_inventorytransfer_DuplicateBaseRecord](#BKMK_msdyn_inventorytransfer_DuplicateBaseRecord)
- [msdyn_inventorytransfer_SharePointDocumentLocations](#BKMK_msdyn_inventorytransfer_SharePointDocumentLocations)
- [msdyn_inventorytransfer_SharePointDocuments](#BKMK_msdyn_inventorytransfer_SharePointDocuments)
- [msdyn_inventorytransfer_AsyncOperations](#BKMK_msdyn_inventorytransfer_AsyncOperations)
- [msdyn_inventorytransfer_MailboxTrackingFolders](#BKMK_msdyn_inventorytransfer_MailboxTrackingFolders)
- [msdyn_inventorytransfer_UserEntityInstanceDatas](#BKMK_msdyn_inventorytransfer_UserEntityInstanceDatas)
- [msdyn_inventorytransfer_ProcessSession](#BKMK_msdyn_inventorytransfer_ProcessSession)
- [msdyn_inventorytransfer_BulkDeleteFailures](#BKMK_msdyn_inventorytransfer_BulkDeleteFailures)
- [msdyn_inventorytransfer_PrincipalObjectAttributeAccesses](#BKMK_msdyn_inventorytransfer_PrincipalObjectAttributeAccesses)
- [msdyn_inventorytransfer_Appointments](#BKMK_msdyn_inventorytransfer_Appointments)
- [msdyn_inventorytransfer_Emails](#BKMK_msdyn_inventorytransfer_Emails)
- [msdyn_inventorytransfer_Faxes](#BKMK_msdyn_inventorytransfer_Faxes)
- [msdyn_inventorytransfer_Letters](#BKMK_msdyn_inventorytransfer_Letters)
- [msdyn_inventorytransfer_PhoneCalls](#BKMK_msdyn_inventorytransfer_PhoneCalls)
- [msdyn_inventorytransfer_Tasks](#BKMK_msdyn_inventorytransfer_Tasks)
- [msdyn_inventorytransfer_RecurringAppointmentMasters](#BKMK_msdyn_inventorytransfer_RecurringAppointmentMasters)
- [msdyn_inventorytransfer_SocialActivities](#BKMK_msdyn_inventorytransfer_SocialActivities)
- [msdyn_inventorytransfer_connections1](#BKMK_msdyn_inventorytransfer_connections1)
- [msdyn_inventorytransfer_connections2](#BKMK_msdyn_inventorytransfer_connections2)
- [msdyn_inventorytransfer_QueueItems](#BKMK_msdyn_inventorytransfer_QueueItems)
- [msdyn_inventorytransfer_Annotations](#BKMK_msdyn_inventorytransfer_Annotations)
- [msdyn_inventorytransfer_ServiceAppointments](#BKMK_msdyn_inventorytransfer_ServiceAppointments)
- [msdyn_msdyn_inventorytransfer_msdyn_inventoryadjustmentproduct_InventoryTransfer](#BKMK_msdyn_msdyn_inventorytransfer_msdyn_inventoryadjustmentproduct_InventoryTransfer)


### <a name="BKMK_msdyn_inventorytransfer_ActivityPointers"></a> msdyn_inventorytransfer_ActivityPointers

Same as activitypointer entity [msdyn_inventorytransfer_ActivityPointers](activitypointer.md#BKMK_msdyn_inventorytransfer_ActivityPointers) Many-To-One relationship.

**ReferencingEntity**: activitypointer<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_inventorytransfer_ActivityPointers<br />
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


### <a name="BKMK_msdyn_inventorytransfer_msdyn_approvals"></a> msdyn_inventorytransfer_msdyn_approvals

Same as msdyn_approval entity [msdyn_inventorytransfer_msdyn_approvals](msdyn_approval.md#BKMK_msdyn_inventorytransfer_msdyn_approvals) Many-To-One relationship.

**ReferencingEntity**: msdyn_approval<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_inventorytransfer_msdyn_approvals<br />
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


### <a name="BKMK_msdyn_inventorytransfer_msdyn_bookingalerts"></a> msdyn_inventorytransfer_msdyn_bookingalerts

Same as msdyn_bookingalert entity [msdyn_inventorytransfer_msdyn_bookingalerts](msdyn_bookingalert.md#BKMK_msdyn_inventorytransfer_msdyn_bookingalerts) Many-To-One relationship.

**ReferencingEntity**: msdyn_bookingalert<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_inventorytransfer_msdyn_bookingalerts<br />
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


### <a name="BKMK_msdyn_inventorytransfer_SyncErrors"></a> msdyn_inventorytransfer_SyncErrors

Same as syncerror entity [msdyn_inventorytransfer_SyncErrors](syncerror.md#BKMK_msdyn_inventorytransfer_SyncErrors) Many-To-One relationship.

**ReferencingEntity**: syncerror<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_inventorytransfer_SyncErrors<br />
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


### <a name="BKMK_msdyn_inventorytransfer_DuplicateMatchingRecord"></a> msdyn_inventorytransfer_DuplicateMatchingRecord

Same as duplicaterecord entity [msdyn_inventorytransfer_DuplicateMatchingRecord](duplicaterecord.md#BKMK_msdyn_inventorytransfer_DuplicateMatchingRecord) Many-To-One relationship.

**ReferencingEntity**: duplicaterecord<br />
**ReferencingAttribute**: duplicaterecordid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_inventorytransfer_DuplicateMatchingRecord<br />
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


### <a name="BKMK_msdyn_inventorytransfer_DuplicateBaseRecord"></a> msdyn_inventorytransfer_DuplicateBaseRecord

Same as duplicaterecord entity [msdyn_inventorytransfer_DuplicateBaseRecord](duplicaterecord.md#BKMK_msdyn_inventorytransfer_DuplicateBaseRecord) Many-To-One relationship.

**ReferencingEntity**: duplicaterecord<br />
**ReferencingAttribute**: baserecordid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_inventorytransfer_DuplicateBaseRecord<br />
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


### <a name="BKMK_msdyn_inventorytransfer_SharePointDocumentLocations"></a> msdyn_inventorytransfer_SharePointDocumentLocations

Same as sharepointdocumentlocation entity [msdyn_inventorytransfer_SharePointDocumentLocations](sharepointdocumentlocation.md#BKMK_msdyn_inventorytransfer_SharePointDocumentLocations) Many-To-One relationship.

**ReferencingEntity**: sharepointdocumentlocation<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_inventorytransfer_SharePointDocumentLocations<br />
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


### <a name="BKMK_msdyn_inventorytransfer_SharePointDocuments"></a> msdyn_inventorytransfer_SharePointDocuments

Same as sharepointdocument entity [msdyn_inventorytransfer_SharePointDocuments](sharepointdocument.md#BKMK_msdyn_inventorytransfer_SharePointDocuments) Many-To-One relationship.

**ReferencingEntity**: sharepointdocument<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_inventorytransfer_SharePointDocuments<br />
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


### <a name="BKMK_msdyn_inventorytransfer_AsyncOperations"></a> msdyn_inventorytransfer_AsyncOperations

Same as asyncoperation entity [msdyn_inventorytransfer_AsyncOperations](asyncoperation.md#BKMK_msdyn_inventorytransfer_AsyncOperations) Many-To-One relationship.

**ReferencingEntity**: asyncoperation<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_inventorytransfer_AsyncOperations<br />
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


### <a name="BKMK_msdyn_inventorytransfer_MailboxTrackingFolders"></a> msdyn_inventorytransfer_MailboxTrackingFolders

Same as mailboxtrackingfolder entity [msdyn_inventorytransfer_MailboxTrackingFolders](mailboxtrackingfolder.md#BKMK_msdyn_inventorytransfer_MailboxTrackingFolders) Many-To-One relationship.

**ReferencingEntity**: mailboxtrackingfolder<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_inventorytransfer_MailboxTrackingFolders<br />
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


### <a name="BKMK_msdyn_inventorytransfer_UserEntityInstanceDatas"></a> msdyn_inventorytransfer_UserEntityInstanceDatas

Same as userentityinstancedata entity [msdyn_inventorytransfer_UserEntityInstanceDatas](userentityinstancedata.md#BKMK_msdyn_inventorytransfer_UserEntityInstanceDatas) Many-To-One relationship.

**ReferencingEntity**: userentityinstancedata<br />
**ReferencingAttribute**: objectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_inventorytransfer_UserEntityInstanceDatas<br />
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


### <a name="BKMK_msdyn_inventorytransfer_ProcessSession"></a> msdyn_inventorytransfer_ProcessSession

Same as processsession entity [msdyn_inventorytransfer_ProcessSession](processsession.md#BKMK_msdyn_inventorytransfer_ProcessSession) Many-To-One relationship.

**ReferencingEntity**: processsession<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_inventorytransfer_ProcessSession<br />
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


### <a name="BKMK_msdyn_inventorytransfer_BulkDeleteFailures"></a> msdyn_inventorytransfer_BulkDeleteFailures

Same as bulkdeletefailure entity [msdyn_inventorytransfer_BulkDeleteFailures](bulkdeletefailure.md#BKMK_msdyn_inventorytransfer_BulkDeleteFailures) Many-To-One relationship.

**ReferencingEntity**: bulkdeletefailure<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_inventorytransfer_BulkDeleteFailures<br />
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


### <a name="BKMK_msdyn_inventorytransfer_PrincipalObjectAttributeAccesses"></a> msdyn_inventorytransfer_PrincipalObjectAttributeAccesses

Same as principalobjectattributeaccess entity [msdyn_inventorytransfer_PrincipalObjectAttributeAccesses](principalobjectattributeaccess.md#BKMK_msdyn_inventorytransfer_PrincipalObjectAttributeAccesses) Many-To-One relationship.

**ReferencingEntity**: principalobjectattributeaccess<br />
**ReferencingAttribute**: objectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_inventorytransfer_PrincipalObjectAttributeAccesses<br />
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


### <a name="BKMK_msdyn_inventorytransfer_Appointments"></a> msdyn_inventorytransfer_Appointments

Same as appointment entity [msdyn_inventorytransfer_Appointments](appointment.md#BKMK_msdyn_inventorytransfer_Appointments) Many-To-One relationship.

**ReferencingEntity**: appointment<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_inventorytransfer_Appointments<br />
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


### <a name="BKMK_msdyn_inventorytransfer_Emails"></a> msdyn_inventorytransfer_Emails

Same as email entity [msdyn_inventorytransfer_Emails](email.md#BKMK_msdyn_inventorytransfer_Emails) Many-To-One relationship.

**ReferencingEntity**: email<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_inventorytransfer_Emails<br />
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


### <a name="BKMK_msdyn_inventorytransfer_Faxes"></a> msdyn_inventorytransfer_Faxes

Same as fax entity [msdyn_inventorytransfer_Faxes](fax.md#BKMK_msdyn_inventorytransfer_Faxes) Many-To-One relationship.

**ReferencingEntity**: fax<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_inventorytransfer_Faxes<br />
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


### <a name="BKMK_msdyn_inventorytransfer_Letters"></a> msdyn_inventorytransfer_Letters

Same as letter entity [msdyn_inventorytransfer_Letters](letter.md#BKMK_msdyn_inventorytransfer_Letters) Many-To-One relationship.

**ReferencingEntity**: letter<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_inventorytransfer_Letters<br />
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


### <a name="BKMK_msdyn_inventorytransfer_PhoneCalls"></a> msdyn_inventorytransfer_PhoneCalls

Same as phonecall entity [msdyn_inventorytransfer_PhoneCalls](phonecall.md#BKMK_msdyn_inventorytransfer_PhoneCalls) Many-To-One relationship.

**ReferencingEntity**: phonecall<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_inventorytransfer_PhoneCalls<br />
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


### <a name="BKMK_msdyn_inventorytransfer_Tasks"></a> msdyn_inventorytransfer_Tasks

Same as task entity [msdyn_inventorytransfer_Tasks](task.md#BKMK_msdyn_inventorytransfer_Tasks) Many-To-One relationship.

**ReferencingEntity**: task<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_inventorytransfer_Tasks<br />
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


### <a name="BKMK_msdyn_inventorytransfer_RecurringAppointmentMasters"></a> msdyn_inventorytransfer_RecurringAppointmentMasters

Same as recurringappointmentmaster entity [msdyn_inventorytransfer_RecurringAppointmentMasters](recurringappointmentmaster.md#BKMK_msdyn_inventorytransfer_RecurringAppointmentMasters) Many-To-One relationship.

**ReferencingEntity**: recurringappointmentmaster<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_inventorytransfer_RecurringAppointmentMasters<br />
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


### <a name="BKMK_msdyn_inventorytransfer_SocialActivities"></a> msdyn_inventorytransfer_SocialActivities

Same as socialactivity entity [msdyn_inventorytransfer_SocialActivities](socialactivity.md#BKMK_msdyn_inventorytransfer_SocialActivities) Many-To-One relationship.

**ReferencingEntity**: socialactivity<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_inventorytransfer_SocialActivities<br />
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


### <a name="BKMK_msdyn_inventorytransfer_connections1"></a> msdyn_inventorytransfer_connections1

Same as connection entity [msdyn_inventorytransfer_connections1](connection.md#BKMK_msdyn_inventorytransfer_connections1) Many-To-One relationship.

**ReferencingEntity**: connection<br />
**ReferencingAttribute**: record1id<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_inventorytransfer_connections1<br />
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


### <a name="BKMK_msdyn_inventorytransfer_connections2"></a> msdyn_inventorytransfer_connections2

Same as connection entity [msdyn_inventorytransfer_connections2](connection.md#BKMK_msdyn_inventorytransfer_connections2) Many-To-One relationship.

**ReferencingEntity**: connection<br />
**ReferencingAttribute**: record2id<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_inventorytransfer_connections2<br />
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


### <a name="BKMK_msdyn_inventorytransfer_QueueItems"></a> msdyn_inventorytransfer_QueueItems

Same as queueitem entity [msdyn_inventorytransfer_QueueItems](queueitem.md#BKMK_msdyn_inventorytransfer_QueueItems) Many-To-One relationship.

**ReferencingEntity**: queueitem<br />
**ReferencingAttribute**: objectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_inventorytransfer_QueueItems<br />
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


### <a name="BKMK_msdyn_inventorytransfer_Annotations"></a> msdyn_inventorytransfer_Annotations

Same as annotation entity [msdyn_inventorytransfer_Annotations](annotation.md#BKMK_msdyn_inventorytransfer_Annotations) Many-To-One relationship.

**ReferencingEntity**: annotation<br />
**ReferencingAttribute**: objectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_inventorytransfer_Annotations<br />
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


### <a name="BKMK_msdyn_inventorytransfer_ServiceAppointments"></a> msdyn_inventorytransfer_ServiceAppointments

Same as serviceappointment entity [msdyn_inventorytransfer_ServiceAppointments](serviceappointment.md#BKMK_msdyn_inventorytransfer_ServiceAppointments) Many-To-One relationship.

**ReferencingEntity**: serviceappointment<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_inventorytransfer_ServiceAppointments<br />
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


### <a name="BKMK_msdyn_msdyn_inventorytransfer_msdyn_inventoryadjustmentproduct_InventoryTransfer"></a> msdyn_msdyn_inventorytransfer_msdyn_inventoryadjustmentproduct_InventoryTransfer

Same as msdyn_inventoryadjustmentproduct entity [msdyn_msdyn_inventorytransfer_msdyn_inventoryadjustmentproduct_InventoryTransfer](msdyn_inventoryadjustmentproduct.md#BKMK_msdyn_msdyn_inventorytransfer_msdyn_inventoryadjustmentproduct_InventoryTransfer) Many-To-One relationship.

**ReferencingEntity**: msdyn_inventoryadjustmentproduct<br />
**ReferencingAttribute**: msdyn_inventorytransfer<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_msdyn_inventorytransfer_msdyn_inventoryadjustmentproduct_InventoryTransfer<br />
**AssociatedMenuConfiguration**:

- **Behavior**: UseCollectionName
- **Group**: Details
- **Label**: 
- **Order**: 10000

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: Restrict
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade

<a name="manytoone"></a>

## Many-To-One Relationships

Each Many-To-One relationship is defined by a corresponding One-To-Many relationship with the related entity. Listed by **SchemaName**.

- [lk_msdyn_inventorytransfer_createdby](#BKMK_lk_msdyn_inventorytransfer_createdby)
- [lk_msdyn_inventorytransfer_createdonbehalfby](#BKMK_lk_msdyn_inventorytransfer_createdonbehalfby)
- [lk_msdyn_inventorytransfer_modifiedby](#BKMK_lk_msdyn_inventorytransfer_modifiedby)
- [lk_msdyn_inventorytransfer_modifiedonbehalfby](#BKMK_lk_msdyn_inventorytransfer_modifiedonbehalfby)
- [user_msdyn_inventorytransfer](#BKMK_user_msdyn_inventorytransfer)
- [team_msdyn_inventorytransfer](#BKMK_team_msdyn_inventorytransfer)
- [business_unit_msdyn_inventorytransfer](#BKMK_business_unit_msdyn_inventorytransfer)
- [msdyn_bookableresource_msdyn_inventorytransfer_TransferredByResource](#BKMK_msdyn_bookableresource_msdyn_inventorytransfer_TransferredByResource)
- [msdyn_msdyn_warehouse_msdyn_inventorytransfer_DestinationWarehouse](#BKMK_msdyn_msdyn_warehouse_msdyn_inventorytransfer_DestinationWarehouse)
- [msdyn_msdyn_warehouse_msdyn_inventorytransfer_SourceWarehouse](#BKMK_msdyn_msdyn_warehouse_msdyn_inventorytransfer_SourceWarehouse)


### <a name="BKMK_lk_msdyn_inventorytransfer_createdby"></a> lk_msdyn_inventorytransfer_createdby

See systemuser Entity [lk_msdyn_inventorytransfer_createdby](systemuser.md#BKMK_lk_msdyn_inventorytransfer_createdby) One-To-Many relationship.

### <a name="BKMK_lk_msdyn_inventorytransfer_createdonbehalfby"></a> lk_msdyn_inventorytransfer_createdonbehalfby

See systemuser Entity [lk_msdyn_inventorytransfer_createdonbehalfby](systemuser.md#BKMK_lk_msdyn_inventorytransfer_createdonbehalfby) One-To-Many relationship.

### <a name="BKMK_lk_msdyn_inventorytransfer_modifiedby"></a> lk_msdyn_inventorytransfer_modifiedby

See systemuser Entity [lk_msdyn_inventorytransfer_modifiedby](systemuser.md#BKMK_lk_msdyn_inventorytransfer_modifiedby) One-To-Many relationship.

### <a name="BKMK_lk_msdyn_inventorytransfer_modifiedonbehalfby"></a> lk_msdyn_inventorytransfer_modifiedonbehalfby

See systemuser Entity [lk_msdyn_inventorytransfer_modifiedonbehalfby](systemuser.md#BKMK_lk_msdyn_inventorytransfer_modifiedonbehalfby) One-To-Many relationship.

### <a name="BKMK_user_msdyn_inventorytransfer"></a> user_msdyn_inventorytransfer

See systemuser Entity [user_msdyn_inventorytransfer](systemuser.md#BKMK_user_msdyn_inventorytransfer) One-To-Many relationship.

### <a name="BKMK_team_msdyn_inventorytransfer"></a> team_msdyn_inventorytransfer

See team Entity [team_msdyn_inventorytransfer](team.md#BKMK_team_msdyn_inventorytransfer) One-To-Many relationship.

### <a name="BKMK_business_unit_msdyn_inventorytransfer"></a> business_unit_msdyn_inventorytransfer

See businessunit Entity [business_unit_msdyn_inventorytransfer](businessunit.md#BKMK_business_unit_msdyn_inventorytransfer) One-To-Many relationship.

### <a name="BKMK_msdyn_bookableresource_msdyn_inventorytransfer_TransferredByResource"></a> msdyn_bookableresource_msdyn_inventorytransfer_TransferredByResource

See bookableresource Entity [msdyn_bookableresource_msdyn_inventorytransfer_TransferredByResource](bookableresource.md#BKMK_msdyn_bookableresource_msdyn_inventorytransfer_TransferredByResource) One-To-Many relationship.

### <a name="BKMK_msdyn_msdyn_warehouse_msdyn_inventorytransfer_DestinationWarehouse"></a> msdyn_msdyn_warehouse_msdyn_inventorytransfer_DestinationWarehouse

See msdyn_warehouse Entity [msdyn_msdyn_warehouse_msdyn_inventorytransfer_DestinationWarehouse](msdyn_warehouse.md#BKMK_msdyn_msdyn_warehouse_msdyn_inventorytransfer_DestinationWarehouse) One-To-Many relationship.

### <a name="BKMK_msdyn_msdyn_warehouse_msdyn_inventorytransfer_SourceWarehouse"></a> msdyn_msdyn_warehouse_msdyn_inventorytransfer_SourceWarehouse

See msdyn_warehouse Entity [msdyn_msdyn_warehouse_msdyn_inventorytransfer_SourceWarehouse](msdyn_warehouse.md#BKMK_msdyn_msdyn_warehouse_msdyn_inventorytransfer_SourceWarehouse) One-To-Many relationship.

## See also

[About the Entity Reference](../about-entity-reference.md)<br />
[Programming reference for Dynamics 365 Customer Engagement](../programming-reference.md)<br />
[Web API Reference](/dynamics365/customer-engagement/web-api/about)<br />
<xref href="Microsoft.Dynamics.CRM.msdyn_inventorytransfer?text=msdyn_inventorytransfer EntityType" />