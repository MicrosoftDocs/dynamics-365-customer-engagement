---
title: "msdyn_warehouse Entity Reference (Developer Guide for Dynamics 365 Customer Engagement)| MicrosoftDocs"
description: "Includes schema information and supported messages for the msdyn_warehouse entity."
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
# msdyn_warehouse Entity Reference

[!INCLUDE[](../../includes/cc_applies_to_update_9_0_0.md)]

Warehouses where inventory products are stored and managed

**Added by**: Field Service Solution<br />

## Messages

|Message|Web API Operation|SDK Assembly|
|-|-|-|
|Assign|PATCH [*org URI*]/api/data/v9.0/msdyn_warehouses(*msdyn_warehouseid*)<br />[Update](../webapi/update-delete-entities-using-web-api.md#basic-update) `ownerid` property.|<xref:Microsoft.Crm.Sdk.Messages.AssignRequest>|
|Create|POST [*org URI*]/api/data/v9.0/msdyn_warehouses<br />See [Create](../webapi/create-entity-web-api.md)|<xref:Microsoft.Xrm.Sdk.Messages.CreateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Create*>|
|Delete|DELETE [*org URI*]/api/data/v9.0/msdyn_warehouses(*msdyn_warehouseid*)<br />See [Delete](../webapi/update-delete-entities-using-web-api.md#basic-delete)|<xref:Microsoft.Xrm.Sdk.Messages.DeleteRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Delete*>|
|GrantAccess|<xref href="Microsoft.Dynamics.CRM.GrantAccess?text=GrantAccess Action" />|<xref:Microsoft.Crm.Sdk.Messages.GrantAccessRequest>|
|IsValidStateTransition|<xref href="Microsoft.Dynamics.CRM.IsValidStateTransition?text=IsValidStateTransition Function" />|<xref:Microsoft.Crm.Sdk.Messages.IsValidStateTransitionRequest>|
|ModifyAccess|<xref href="Microsoft.Dynamics.CRM.ModifyAccess?text=ModifyAccess Action" />|<xref:Microsoft.Crm.Sdk.Messages.ModifyAccessRequest>|
|Retrieve|GET [*org URI*]/api/data/v9.0/msdyn_warehouses(*msdyn_warehouseid*)<br />See [Retrieve](../webapi/retrieve-entity-using-web-api.md)|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Retrieve*>|
|RetrieveMultiple|GET [*org URI*]/api/data/v9.0/msdyn_warehouses<br />See [Query Data](../webapi/query-data-web-api.md)|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveMultipleRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.RetrieveMultiple*>|
|RetrievePrincipalAccess|<xref href="Microsoft.Dynamics.CRM.RetrievePrincipalAccess?text=RetrievePrincipalAccess Function" />|<xref:Microsoft.Crm.Sdk.Messages.RetrievePrincipalAccessRequest>|
|RetrieveSharedPrincipalsAndAccess|<xref href="Microsoft.Dynamics.CRM.RetrieveSharedPrincipalsAndAccess?text=RetrieveSharedPrincipalsAndAccess Function" />|<xref:Microsoft.Crm.Sdk.Messages.RetrieveSharedPrincipalsAndAccessRequest>|
|RevokeAccess|<xref href="Microsoft.Dynamics.CRM.RevokeAccess?text=RevokeAccess Action" />|<xref:Microsoft.Crm.Sdk.Messages.RevokeAccessRequest>|
|SetState|PATCH [*org URI*]/api/data/v9.0/msdyn_warehouses(*msdyn_warehouseid*)<br />[Update](../webapi/update-delete-entities-using-web-api.md#basic-update) `statecode` and `statuscode` properties.|<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|
|Update|PATCH [*org URI*]/api/data/v9.0/msdyn_warehouses(*msdyn_warehouseid*)<br />See [Update](../webapi/update-delete-entities-using-web-api.md#basic-update)|<xref:Microsoft.Xrm.Sdk.Messages.UpdateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Update*>|

## Entity Properties

**DisplayName**: Warehouse<br />
**DisplayCollectionName**: Warehouses<br />
**SchemaName**: msdyn_warehouse<br />
**CollectionSchemaName**: msdyn_warehouses<br />
**LogicalName**: msdyn_warehouse<br />
**LogicalCollectionName**: msdyn_warehouses<br />
**EntitySetName**: msdyn_warehouses<br />
**PrimaryIdAttribute**: msdyn_warehouseid<br />
**PrimaryNameAttribute**: msdyn_name<br />
**OwnershipType**: UserOwned<br />
**IsBPFEntity**: False<br />
<a name="writable-attributes"></a>

## Writable attributes

These attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [msdyn_Description](#BKMK_msdyn_Description)
- [msdyn_name](#BKMK_msdyn_name)
- [msdyn_warehouseId](#BKMK_msdyn_warehouseId)
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


### <a name="BKMK_msdyn_warehouseId"></a> msdyn_warehouseId

**Description**: Shows the entity instances.<br />
**DisplayName**: Warehouse<br />
**LogicalName**: msdyn_warehouseid<br />
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

**Description**: Status of the Warehouse<br />
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

**Description**: Reason for the status of the Warehouse<br />
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

- [msdyn_warehouse_ActivityPointers](#BKMK_msdyn_warehouse_ActivityPointers)
- [msdyn_warehouse_msdyn_approvals](#BKMK_msdyn_warehouse_msdyn_approvals)
- [msdyn_warehouse_msdyn_bookingalerts](#BKMK_msdyn_warehouse_msdyn_bookingalerts)
- [msdyn_warehouse_SyncErrors](#BKMK_msdyn_warehouse_SyncErrors)
- [msdyn_warehouse_DuplicateMatchingRecord](#BKMK_msdyn_warehouse_DuplicateMatchingRecord)
- [msdyn_warehouse_DuplicateBaseRecord](#BKMK_msdyn_warehouse_DuplicateBaseRecord)
- [msdyn_warehouse_SharePointDocumentLocations](#BKMK_msdyn_warehouse_SharePointDocumentLocations)
- [msdyn_warehouse_SharePointDocuments](#BKMK_msdyn_warehouse_SharePointDocuments)
- [msdyn_warehouse_AsyncOperations](#BKMK_msdyn_warehouse_AsyncOperations)
- [msdyn_warehouse_MailboxTrackingFolders](#BKMK_msdyn_warehouse_MailboxTrackingFolders)
- [msdyn_warehouse_UserEntityInstanceDatas](#BKMK_msdyn_warehouse_UserEntityInstanceDatas)
- [msdyn_warehouse_ProcessSession](#BKMK_msdyn_warehouse_ProcessSession)
- [msdyn_warehouse_BulkDeleteFailures](#BKMK_msdyn_warehouse_BulkDeleteFailures)
- [msdyn_warehouse_PrincipalObjectAttributeAccesses](#BKMK_msdyn_warehouse_PrincipalObjectAttributeAccesses)
- [msdyn_warehouse_Appointments](#BKMK_msdyn_warehouse_Appointments)
- [msdyn_warehouse_Emails](#BKMK_msdyn_warehouse_Emails)
- [msdyn_warehouse_Faxes](#BKMK_msdyn_warehouse_Faxes)
- [msdyn_warehouse_Letters](#BKMK_msdyn_warehouse_Letters)
- [msdyn_warehouse_PhoneCalls](#BKMK_msdyn_warehouse_PhoneCalls)
- [msdyn_warehouse_Tasks](#BKMK_msdyn_warehouse_Tasks)
- [msdyn_warehouse_RecurringAppointmentMasters](#BKMK_msdyn_warehouse_RecurringAppointmentMasters)
- [msdyn_warehouse_SocialActivities](#BKMK_msdyn_warehouse_SocialActivities)
- [msdyn_warehouse_connections1](#BKMK_msdyn_warehouse_connections1)
- [msdyn_warehouse_connections2](#BKMK_msdyn_warehouse_connections2)
- [msdyn_warehouse_Annotations](#BKMK_msdyn_warehouse_Annotations)
- [msdyn_warehouse_ServiceAppointments](#BKMK_msdyn_warehouse_ServiceAppointments)
- [msdyn_msdyn_warehouse_bookableresource_Warehouse](#BKMK_msdyn_msdyn_warehouse_bookableresource_Warehouse)
- [msdyn_msdyn_warehouse_businessunit_Warehouse](#BKMK_msdyn_msdyn_warehouse_businessunit_Warehouse)
- [msdyn_msdyn_warehouse_msdyn_actual_Warehouse](#BKMK_msdyn_msdyn_warehouse_msdyn_actual_Warehouse)
- [msdyn_msdyn_warehouse_msdyn_fieldservicesetting_DefaultWarehouse](#BKMK_msdyn_msdyn_warehouse_msdyn_fieldservicesetting_DefaultWarehouse)
- [msdyn_msdyn_warehouse_msdyn_inventoryadjustment_Warehouse](#BKMK_msdyn_msdyn_warehouse_msdyn_inventoryadjustment_Warehouse)
- [msdyn_msdyn_warehouse_msdyn_inventoryjournal_Warehouse](#BKMK_msdyn_msdyn_warehouse_msdyn_inventoryjournal_Warehouse)
- [msdyn_msdyn_warehouse_msdyn_inventorytransfer_DestinationWarehouse](#BKMK_msdyn_msdyn_warehouse_msdyn_inventorytransfer_DestinationWarehouse)
- [msdyn_msdyn_warehouse_msdyn_inventorytransfer_SourceWarehouse](#BKMK_msdyn_msdyn_warehouse_msdyn_inventorytransfer_SourceWarehouse)
- [msdyn_msdyn_warehouse_msdyn_productinventory_Warehouse](#BKMK_msdyn_msdyn_warehouse_msdyn_productinventory_Warehouse)
- [msdyn_msdyn_warehouse_msdyn_purchaseorder_ReceivetoWarehouse](#BKMK_msdyn_msdyn_warehouse_msdyn_purchaseorder_ReceivetoWarehouse)
- [msdyn_msdyn_warehouse_msdyn_purchaseorderproduct_AssociateToWarehouse](#BKMK_msdyn_msdyn_warehouse_msdyn_purchaseorderproduct_AssociateToWarehouse)
- [msdyn_msdyn_warehouse_msdyn_purchaseorderreceiptproduct_AssociateToWarehouse](#BKMK_msdyn_msdyn_warehouse_msdyn_purchaseorderreceiptproduct_AssociateToWarehouse)
- [msdyn_msdyn_warehouse_msdyn_rmaproduct_ReturntoWarehouse](#BKMK_msdyn_msdyn_warehouse_msdyn_rmaproduct_ReturntoWarehouse)
- [msdyn_msdyn_warehouse_msdyn_rtvproduct_Warehouse](#BKMK_msdyn_msdyn_warehouse_msdyn_rtvproduct_Warehouse)
- [msdyn_msdyn_warehouse_msdyn_workorderproduct_Warehouse](#BKMK_msdyn_msdyn_warehouse_msdyn_workorderproduct_Warehouse)


### <a name="BKMK_msdyn_warehouse_ActivityPointers"></a> msdyn_warehouse_ActivityPointers

Same as activitypointer entity [msdyn_warehouse_ActivityPointers](activitypointer.md#BKMK_msdyn_warehouse_ActivityPointers) Many-To-One relationship.

**ReferencingEntity**: activitypointer<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_warehouse_ActivityPointers<br />
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


### <a name="BKMK_msdyn_warehouse_msdyn_approvals"></a> msdyn_warehouse_msdyn_approvals

Same as msdyn_approval entity [msdyn_warehouse_msdyn_approvals](msdyn_approval.md#BKMK_msdyn_warehouse_msdyn_approvals) Many-To-One relationship.

**ReferencingEntity**: msdyn_approval<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_warehouse_msdyn_approvals<br />
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


### <a name="BKMK_msdyn_warehouse_msdyn_bookingalerts"></a> msdyn_warehouse_msdyn_bookingalerts

Same as msdyn_bookingalert entity [msdyn_warehouse_msdyn_bookingalerts](msdyn_bookingalert.md#BKMK_msdyn_warehouse_msdyn_bookingalerts) Many-To-One relationship.

**ReferencingEntity**: msdyn_bookingalert<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_warehouse_msdyn_bookingalerts<br />
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


### <a name="BKMK_msdyn_warehouse_SyncErrors"></a> msdyn_warehouse_SyncErrors

Same as syncerror entity [msdyn_warehouse_SyncErrors](syncerror.md#BKMK_msdyn_warehouse_SyncErrors) Many-To-One relationship.

**ReferencingEntity**: syncerror<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_warehouse_SyncErrors<br />
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


### <a name="BKMK_msdyn_warehouse_DuplicateMatchingRecord"></a> msdyn_warehouse_DuplicateMatchingRecord

Same as duplicaterecord entity [msdyn_warehouse_DuplicateMatchingRecord](duplicaterecord.md#BKMK_msdyn_warehouse_DuplicateMatchingRecord) Many-To-One relationship.

**ReferencingEntity**: duplicaterecord<br />
**ReferencingAttribute**: duplicaterecordid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_warehouse_DuplicateMatchingRecord<br />
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


### <a name="BKMK_msdyn_warehouse_DuplicateBaseRecord"></a> msdyn_warehouse_DuplicateBaseRecord

Same as duplicaterecord entity [msdyn_warehouse_DuplicateBaseRecord](duplicaterecord.md#BKMK_msdyn_warehouse_DuplicateBaseRecord) Many-To-One relationship.

**ReferencingEntity**: duplicaterecord<br />
**ReferencingAttribute**: baserecordid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_warehouse_DuplicateBaseRecord<br />
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


### <a name="BKMK_msdyn_warehouse_SharePointDocumentLocations"></a> msdyn_warehouse_SharePointDocumentLocations

Same as sharepointdocumentlocation entity [msdyn_warehouse_SharePointDocumentLocations](sharepointdocumentlocation.md#BKMK_msdyn_warehouse_SharePointDocumentLocations) Many-To-One relationship.

**ReferencingEntity**: sharepointdocumentlocation<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_warehouse_SharePointDocumentLocations<br />
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


### <a name="BKMK_msdyn_warehouse_SharePointDocuments"></a> msdyn_warehouse_SharePointDocuments

Same as sharepointdocument entity [msdyn_warehouse_SharePointDocuments](sharepointdocument.md#BKMK_msdyn_warehouse_SharePointDocuments) Many-To-One relationship.

**ReferencingEntity**: sharepointdocument<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_warehouse_SharePointDocuments<br />
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


### <a name="BKMK_msdyn_warehouse_AsyncOperations"></a> msdyn_warehouse_AsyncOperations

Same as asyncoperation entity [msdyn_warehouse_AsyncOperations](asyncoperation.md#BKMK_msdyn_warehouse_AsyncOperations) Many-To-One relationship.

**ReferencingEntity**: asyncoperation<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_warehouse_AsyncOperations<br />
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


### <a name="BKMK_msdyn_warehouse_MailboxTrackingFolders"></a> msdyn_warehouse_MailboxTrackingFolders

Same as mailboxtrackingfolder entity [msdyn_warehouse_MailboxTrackingFolders](mailboxtrackingfolder.md#BKMK_msdyn_warehouse_MailboxTrackingFolders) Many-To-One relationship.

**ReferencingEntity**: mailboxtrackingfolder<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_warehouse_MailboxTrackingFolders<br />
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


### <a name="BKMK_msdyn_warehouse_UserEntityInstanceDatas"></a> msdyn_warehouse_UserEntityInstanceDatas

Same as userentityinstancedata entity [msdyn_warehouse_UserEntityInstanceDatas](userentityinstancedata.md#BKMK_msdyn_warehouse_UserEntityInstanceDatas) Many-To-One relationship.

**ReferencingEntity**: userentityinstancedata<br />
**ReferencingAttribute**: objectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_warehouse_UserEntityInstanceDatas<br />
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


### <a name="BKMK_msdyn_warehouse_ProcessSession"></a> msdyn_warehouse_ProcessSession

Same as processsession entity [msdyn_warehouse_ProcessSession](processsession.md#BKMK_msdyn_warehouse_ProcessSession) Many-To-One relationship.

**ReferencingEntity**: processsession<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_warehouse_ProcessSession<br />
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


### <a name="BKMK_msdyn_warehouse_BulkDeleteFailures"></a> msdyn_warehouse_BulkDeleteFailures

Same as bulkdeletefailure entity [msdyn_warehouse_BulkDeleteFailures](bulkdeletefailure.md#BKMK_msdyn_warehouse_BulkDeleteFailures) Many-To-One relationship.

**ReferencingEntity**: bulkdeletefailure<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_warehouse_BulkDeleteFailures<br />
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


### <a name="BKMK_msdyn_warehouse_PrincipalObjectAttributeAccesses"></a> msdyn_warehouse_PrincipalObjectAttributeAccesses

Same as principalobjectattributeaccess entity [msdyn_warehouse_PrincipalObjectAttributeAccesses](principalobjectattributeaccess.md#BKMK_msdyn_warehouse_PrincipalObjectAttributeAccesses) Many-To-One relationship.

**ReferencingEntity**: principalobjectattributeaccess<br />
**ReferencingAttribute**: objectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_warehouse_PrincipalObjectAttributeAccesses<br />
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


### <a name="BKMK_msdyn_warehouse_Appointments"></a> msdyn_warehouse_Appointments

Same as appointment entity [msdyn_warehouse_Appointments](appointment.md#BKMK_msdyn_warehouse_Appointments) Many-To-One relationship.

**ReferencingEntity**: appointment<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_warehouse_Appointments<br />
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


### <a name="BKMK_msdyn_warehouse_Emails"></a> msdyn_warehouse_Emails

Same as email entity [msdyn_warehouse_Emails](email.md#BKMK_msdyn_warehouse_Emails) Many-To-One relationship.

**ReferencingEntity**: email<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_warehouse_Emails<br />
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


### <a name="BKMK_msdyn_warehouse_Faxes"></a> msdyn_warehouse_Faxes

Same as fax entity [msdyn_warehouse_Faxes](fax.md#BKMK_msdyn_warehouse_Faxes) Many-To-One relationship.

**ReferencingEntity**: fax<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_warehouse_Faxes<br />
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


### <a name="BKMK_msdyn_warehouse_Letters"></a> msdyn_warehouse_Letters

Same as letter entity [msdyn_warehouse_Letters](letter.md#BKMK_msdyn_warehouse_Letters) Many-To-One relationship.

**ReferencingEntity**: letter<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_warehouse_Letters<br />
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


### <a name="BKMK_msdyn_warehouse_PhoneCalls"></a> msdyn_warehouse_PhoneCalls

Same as phonecall entity [msdyn_warehouse_PhoneCalls](phonecall.md#BKMK_msdyn_warehouse_PhoneCalls) Many-To-One relationship.

**ReferencingEntity**: phonecall<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_warehouse_PhoneCalls<br />
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


### <a name="BKMK_msdyn_warehouse_Tasks"></a> msdyn_warehouse_Tasks

Same as task entity [msdyn_warehouse_Tasks](task.md#BKMK_msdyn_warehouse_Tasks) Many-To-One relationship.

**ReferencingEntity**: task<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_warehouse_Tasks<br />
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


### <a name="BKMK_msdyn_warehouse_RecurringAppointmentMasters"></a> msdyn_warehouse_RecurringAppointmentMasters

Same as recurringappointmentmaster entity [msdyn_warehouse_RecurringAppointmentMasters](recurringappointmentmaster.md#BKMK_msdyn_warehouse_RecurringAppointmentMasters) Many-To-One relationship.

**ReferencingEntity**: recurringappointmentmaster<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_warehouse_RecurringAppointmentMasters<br />
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


### <a name="BKMK_msdyn_warehouse_SocialActivities"></a> msdyn_warehouse_SocialActivities

Same as socialactivity entity [msdyn_warehouse_SocialActivities](socialactivity.md#BKMK_msdyn_warehouse_SocialActivities) Many-To-One relationship.

**ReferencingEntity**: socialactivity<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_warehouse_SocialActivities<br />
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


### <a name="BKMK_msdyn_warehouse_connections1"></a> msdyn_warehouse_connections1

Same as connection entity [msdyn_warehouse_connections1](connection.md#BKMK_msdyn_warehouse_connections1) Many-To-One relationship.

**ReferencingEntity**: connection<br />
**ReferencingAttribute**: record1id<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_warehouse_connections1<br />
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


### <a name="BKMK_msdyn_warehouse_connections2"></a> msdyn_warehouse_connections2

Same as connection entity [msdyn_warehouse_connections2](connection.md#BKMK_msdyn_warehouse_connections2) Many-To-One relationship.

**ReferencingEntity**: connection<br />
**ReferencingAttribute**: record2id<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_warehouse_connections2<br />
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


### <a name="BKMK_msdyn_warehouse_Annotations"></a> msdyn_warehouse_Annotations

Same as annotation entity [msdyn_warehouse_Annotations](annotation.md#BKMK_msdyn_warehouse_Annotations) Many-To-One relationship.

**ReferencingEntity**: annotation<br />
**ReferencingAttribute**: objectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_warehouse_Annotations<br />
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


### <a name="BKMK_msdyn_warehouse_ServiceAppointments"></a> msdyn_warehouse_ServiceAppointments

Same as serviceappointment entity [msdyn_warehouse_ServiceAppointments](serviceappointment.md#BKMK_msdyn_warehouse_ServiceAppointments) Many-To-One relationship.

**ReferencingEntity**: serviceappointment<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_warehouse_ServiceAppointments<br />
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


### <a name="BKMK_msdyn_msdyn_warehouse_bookableresource_Warehouse"></a> msdyn_msdyn_warehouse_bookableresource_Warehouse

Same as bookableresource entity [msdyn_msdyn_warehouse_bookableresource_Warehouse](bookableresource.md#BKMK_msdyn_msdyn_warehouse_bookableresource_Warehouse) Many-To-One relationship.

**ReferencingEntity**: bookableresource<br />
**ReferencingAttribute**: msdyn_warehouse<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_msdyn_warehouse_bookableresource_Warehouse<br />
**AssociatedMenuConfiguration**:

- **Behavior**: UseCollectionName
- **Group**: Details
- **Label**: 
- **Order**: 10000

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: RemoveLink
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_msdyn_msdyn_warehouse_businessunit_Warehouse"></a> msdyn_msdyn_warehouse_businessunit_Warehouse

Same as businessunit entity [msdyn_msdyn_warehouse_businessunit_Warehouse](businessunit.md#BKMK_msdyn_msdyn_warehouse_businessunit_Warehouse) Many-To-One relationship.

**ReferencingEntity**: businessunit<br />
**ReferencingAttribute**: msdyn_warehouse<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_msdyn_warehouse_businessunit_Warehouse<br />
**AssociatedMenuConfiguration**:

- **Behavior**: UseCollectionName
- **Group**: Details
- **Label**: 
- **Order**: 10000

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: RemoveLink
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_msdyn_msdyn_warehouse_msdyn_actual_Warehouse"></a> msdyn_msdyn_warehouse_msdyn_actual_Warehouse

Same as msdyn_actual entity [msdyn_msdyn_warehouse_msdyn_actual_Warehouse](msdyn_actual.md#BKMK_msdyn_msdyn_warehouse_msdyn_actual_Warehouse) Many-To-One relationship.

**ReferencingEntity**: msdyn_actual<br />
**ReferencingAttribute**: msdyn_warehouse<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_msdyn_warehouse_msdyn_actual_Warehouse<br />
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


### <a name="BKMK_msdyn_msdyn_warehouse_msdyn_fieldservicesetting_DefaultWarehouse"></a> msdyn_msdyn_warehouse_msdyn_fieldservicesetting_DefaultWarehouse

Same as msdyn_fieldservicesetting entity [msdyn_msdyn_warehouse_msdyn_fieldservicesetting_DefaultWarehouse](msdyn_fieldservicesetting.md#BKMK_msdyn_msdyn_warehouse_msdyn_fieldservicesetting_DefaultWarehouse) Many-To-One relationship.

**ReferencingEntity**: msdyn_fieldservicesetting<br />
**ReferencingAttribute**: msdyn_defaultwarehouse<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_msdyn_warehouse_msdyn_fieldservicesetting_DefaultWarehouse<br />
**AssociatedMenuConfiguration**:

- **Behavior**: UseCollectionName
- **Group**: Details
- **Label**: 
- **Order**: 10000

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: RemoveLink
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_msdyn_msdyn_warehouse_msdyn_inventoryadjustment_Warehouse"></a> msdyn_msdyn_warehouse_msdyn_inventoryadjustment_Warehouse

Same as msdyn_inventoryadjustment entity [msdyn_msdyn_warehouse_msdyn_inventoryadjustment_Warehouse](msdyn_inventoryadjustment.md#BKMK_msdyn_msdyn_warehouse_msdyn_inventoryadjustment_Warehouse) Many-To-One relationship.

**ReferencingEntity**: msdyn_inventoryadjustment<br />
**ReferencingAttribute**: msdyn_warehouse<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_msdyn_warehouse_msdyn_inventoryadjustment_Warehouse<br />
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


### <a name="BKMK_msdyn_msdyn_warehouse_msdyn_inventoryjournal_Warehouse"></a> msdyn_msdyn_warehouse_msdyn_inventoryjournal_Warehouse

Same as msdyn_inventoryjournal entity [msdyn_msdyn_warehouse_msdyn_inventoryjournal_Warehouse](msdyn_inventoryjournal.md#BKMK_msdyn_msdyn_warehouse_msdyn_inventoryjournal_Warehouse) Many-To-One relationship.

**ReferencingEntity**: msdyn_inventoryjournal<br />
**ReferencingAttribute**: msdyn_warehouse<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_msdyn_warehouse_msdyn_inventoryjournal_Warehouse<br />
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


### <a name="BKMK_msdyn_msdyn_warehouse_msdyn_inventorytransfer_DestinationWarehouse"></a> msdyn_msdyn_warehouse_msdyn_inventorytransfer_DestinationWarehouse

Same as msdyn_inventorytransfer entity [msdyn_msdyn_warehouse_msdyn_inventorytransfer_DestinationWarehouse](msdyn_inventorytransfer.md#BKMK_msdyn_msdyn_warehouse_msdyn_inventorytransfer_DestinationWarehouse) Many-To-One relationship.

**ReferencingEntity**: msdyn_inventorytransfer<br />
**ReferencingAttribute**: msdyn_destinationwarehouse<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_msdyn_warehouse_msdyn_inventorytransfer_DestinationWarehouse<br />
**AssociatedMenuConfiguration**:

- **Behavior**: UseLabel
- **Group**: Details
- **Label**: Destination Warehouse
- **Order**: 10000

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: Restrict
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_msdyn_msdyn_warehouse_msdyn_inventorytransfer_SourceWarehouse"></a> msdyn_msdyn_warehouse_msdyn_inventorytransfer_SourceWarehouse

Same as msdyn_inventorytransfer entity [msdyn_msdyn_warehouse_msdyn_inventorytransfer_SourceWarehouse](msdyn_inventorytransfer.md#BKMK_msdyn_msdyn_warehouse_msdyn_inventorytransfer_SourceWarehouse) Many-To-One relationship.

**ReferencingEntity**: msdyn_inventorytransfer<br />
**ReferencingAttribute**: msdyn_sourcewarehouse<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_msdyn_warehouse_msdyn_inventorytransfer_SourceWarehouse<br />
**AssociatedMenuConfiguration**:

- **Behavior**: UseLabel
- **Group**: Details
- **Label**: Source Warehouse
- **Order**: 10000

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: Restrict
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_msdyn_msdyn_warehouse_msdyn_productinventory_Warehouse"></a> msdyn_msdyn_warehouse_msdyn_productinventory_Warehouse

Same as msdyn_productinventory entity [msdyn_msdyn_warehouse_msdyn_productinventory_Warehouse](msdyn_productinventory.md#BKMK_msdyn_msdyn_warehouse_msdyn_productinventory_Warehouse) Many-To-One relationship.

**ReferencingEntity**: msdyn_productinventory<br />
**ReferencingAttribute**: msdyn_warehouse<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_msdyn_warehouse_msdyn_productinventory_Warehouse<br />
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


### <a name="BKMK_msdyn_msdyn_warehouse_msdyn_purchaseorder_ReceivetoWarehouse"></a> msdyn_msdyn_warehouse_msdyn_purchaseorder_ReceivetoWarehouse

Same as msdyn_purchaseorder entity [msdyn_msdyn_warehouse_msdyn_purchaseorder_ReceivetoWarehouse](msdyn_purchaseorder.md#BKMK_msdyn_msdyn_warehouse_msdyn_purchaseorder_ReceivetoWarehouse) Many-To-One relationship.

**ReferencingEntity**: msdyn_purchaseorder<br />
**ReferencingAttribute**: msdyn_receivetowarehouse<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_msdyn_warehouse_msdyn_purchaseorder_ReceivetoWarehouse<br />
**AssociatedMenuConfiguration**:

- **Behavior**: UseCollectionName
- **Group**: Details
- **Label**: 
- **Order**: 10000

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: RemoveLink
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_msdyn_msdyn_warehouse_msdyn_purchaseorderproduct_AssociateToWarehouse"></a> msdyn_msdyn_warehouse_msdyn_purchaseorderproduct_AssociateToWarehouse

Same as msdyn_purchaseorderproduct entity [msdyn_msdyn_warehouse_msdyn_purchaseorderproduct_AssociateToWarehouse](msdyn_purchaseorderproduct.md#BKMK_msdyn_msdyn_warehouse_msdyn_purchaseorderproduct_AssociateToWarehouse) Many-To-One relationship.

**ReferencingEntity**: msdyn_purchaseorderproduct<br />
**ReferencingAttribute**: msdyn_associatetowarehouse<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_msdyn_warehouse_msdyn_purchaseorderproduct_AssociateToWarehouse<br />
**AssociatedMenuConfiguration**:

- **Behavior**: UseLabel
- **Group**: Details
- **Label**: Associate To Warehouse
- **Order**: 10000

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: RemoveLink
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_msdyn_msdyn_warehouse_msdyn_purchaseorderreceiptproduct_AssociateToWarehouse"></a> msdyn_msdyn_warehouse_msdyn_purchaseorderreceiptproduct_AssociateToWarehouse

Same as msdyn_purchaseorderreceiptproduct entity [msdyn_msdyn_warehouse_msdyn_purchaseorderreceiptproduct_AssociateToWarehouse](msdyn_purchaseorderreceiptproduct.md#BKMK_msdyn_msdyn_warehouse_msdyn_purchaseorderreceiptproduct_AssociateToWarehouse) Many-To-One relationship.

**ReferencingEntity**: msdyn_purchaseorderreceiptproduct<br />
**ReferencingAttribute**: msdyn_associatetowarehouse<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_msdyn_warehouse_msdyn_purchaseorderreceiptproduct_AssociateToWarehouse<br />
**AssociatedMenuConfiguration**:

- **Behavior**: UseCollectionName
- **Group**: Details
- **Label**: 
- **Order**: 10000

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: RemoveLink
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_msdyn_msdyn_warehouse_msdyn_rmaproduct_ReturntoWarehouse"></a> msdyn_msdyn_warehouse_msdyn_rmaproduct_ReturntoWarehouse

Same as msdyn_rmaproduct entity [msdyn_msdyn_warehouse_msdyn_rmaproduct_ReturntoWarehouse](msdyn_rmaproduct.md#BKMK_msdyn_msdyn_warehouse_msdyn_rmaproduct_ReturntoWarehouse) Many-To-One relationship.

**ReferencingEntity**: msdyn_rmaproduct<br />
**ReferencingAttribute**: msdyn_returntowarehouse<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_msdyn_warehouse_msdyn_rmaproduct_ReturntoWarehouse<br />
**AssociatedMenuConfiguration**:

- **Behavior**: UseLabel
- **Group**: Details
- **Label**: Warehouse
- **Order**: 10000

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: RemoveLink
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_msdyn_msdyn_warehouse_msdyn_rtvproduct_Warehouse"></a> msdyn_msdyn_warehouse_msdyn_rtvproduct_Warehouse

Same as msdyn_rtvproduct entity [msdyn_msdyn_warehouse_msdyn_rtvproduct_Warehouse](msdyn_rtvproduct.md#BKMK_msdyn_msdyn_warehouse_msdyn_rtvproduct_Warehouse) Many-To-One relationship.

**ReferencingEntity**: msdyn_rtvproduct<br />
**ReferencingAttribute**: msdyn_warehouse<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_msdyn_warehouse_msdyn_rtvproduct_Warehouse<br />
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


### <a name="BKMK_msdyn_msdyn_warehouse_msdyn_workorderproduct_Warehouse"></a> msdyn_msdyn_warehouse_msdyn_workorderproduct_Warehouse

Same as msdyn_workorderproduct entity [msdyn_msdyn_warehouse_msdyn_workorderproduct_Warehouse](msdyn_workorderproduct.md#BKMK_msdyn_msdyn_warehouse_msdyn_workorderproduct_Warehouse) Many-To-One relationship.

**ReferencingEntity**: msdyn_workorderproduct<br />
**ReferencingAttribute**: msdyn_warehouse<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_msdyn_warehouse_msdyn_workorderproduct_Warehouse<br />
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

- [lk_msdyn_warehouse_createdby](#BKMK_lk_msdyn_warehouse_createdby)
- [lk_msdyn_warehouse_createdonbehalfby](#BKMK_lk_msdyn_warehouse_createdonbehalfby)
- [lk_msdyn_warehouse_modifiedby](#BKMK_lk_msdyn_warehouse_modifiedby)
- [lk_msdyn_warehouse_modifiedonbehalfby](#BKMK_lk_msdyn_warehouse_modifiedonbehalfby)
- [user_msdyn_warehouse](#BKMK_user_msdyn_warehouse)
- [team_msdyn_warehouse](#BKMK_team_msdyn_warehouse)
- [business_unit_msdyn_warehouse](#BKMK_business_unit_msdyn_warehouse)


### <a name="BKMK_lk_msdyn_warehouse_createdby"></a> lk_msdyn_warehouse_createdby

See systemuser Entity [lk_msdyn_warehouse_createdby](systemuser.md#BKMK_lk_msdyn_warehouse_createdby) One-To-Many relationship.

### <a name="BKMK_lk_msdyn_warehouse_createdonbehalfby"></a> lk_msdyn_warehouse_createdonbehalfby

See systemuser Entity [lk_msdyn_warehouse_createdonbehalfby](systemuser.md#BKMK_lk_msdyn_warehouse_createdonbehalfby) One-To-Many relationship.

### <a name="BKMK_lk_msdyn_warehouse_modifiedby"></a> lk_msdyn_warehouse_modifiedby

See systemuser Entity [lk_msdyn_warehouse_modifiedby](systemuser.md#BKMK_lk_msdyn_warehouse_modifiedby) One-To-Many relationship.

### <a name="BKMK_lk_msdyn_warehouse_modifiedonbehalfby"></a> lk_msdyn_warehouse_modifiedonbehalfby

See systemuser Entity [lk_msdyn_warehouse_modifiedonbehalfby](systemuser.md#BKMK_lk_msdyn_warehouse_modifiedonbehalfby) One-To-Many relationship.

### <a name="BKMK_user_msdyn_warehouse"></a> user_msdyn_warehouse

See systemuser Entity [user_msdyn_warehouse](systemuser.md#BKMK_user_msdyn_warehouse) One-To-Many relationship.

### <a name="BKMK_team_msdyn_warehouse"></a> team_msdyn_warehouse

See team Entity [team_msdyn_warehouse](team.md#BKMK_team_msdyn_warehouse) One-To-Many relationship.

### <a name="BKMK_business_unit_msdyn_warehouse"></a> business_unit_msdyn_warehouse

See businessunit Entity [business_unit_msdyn_warehouse](businessunit.md#BKMK_business_unit_msdyn_warehouse) One-To-Many relationship.

## See also

[About the Entity Reference](../about-entity-reference.md)<br />
[Programming reference for Dynamics 365 Customer Engagement](../programming-reference.md)<br />
[Web API Reference](/dynamics365/customer-engagement/web-api/about)<br />
<xref href="Microsoft.Dynamics.CRM.msdyn_warehouse?text=msdyn_warehouse EntityType" />