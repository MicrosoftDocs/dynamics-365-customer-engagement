---
title: "msdyn_incidenttypeproduct Entity Reference (Developer Guide for Dynamics 365 Customer Engagement)| MicrosoftDocs"
description: "Includes schema information and supported messages for the msdyn_incidenttypeproduct entity."
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
# msdyn_incidenttypeproduct Entity Reference

[!INCLUDE[](../../includes/cc_applies_to_update_9_0_0.md)]

This entity gives the ability to pre-configure products to be added to a work order when the related incident is added to the work order

**Added by**: Field Service Solution<br />

## Messages

|Message|Web API Operation|SDK Assembly|
|-|-|-|
|Assign|PATCH [*org URI*]/api/data/v9.0/msdyn_incidenttypeproducts(*msdyn_incidenttypeproductid*)<br />[Update](../webapi/update-delete-entities-using-web-api.md#basic-update) `ownerid` property.|<xref:Microsoft.Crm.Sdk.Messages.AssignRequest>|
|Create|POST [*org URI*]/api/data/v9.0/msdyn_incidenttypeproducts<br />See [Create](../webapi/create-entity-web-api.md)|<xref:Microsoft.Xrm.Sdk.Messages.CreateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Create*>|
|Delete|DELETE [*org URI*]/api/data/v9.0/msdyn_incidenttypeproducts(*msdyn_incidenttypeproductid*)<br />See [Delete](../webapi/update-delete-entities-using-web-api.md#basic-delete)|<xref:Microsoft.Xrm.Sdk.Messages.DeleteRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Delete*>|
|GrantAccess|<xref href="Microsoft.Dynamics.CRM.GrantAccess?text=GrantAccess Action" />|<xref:Microsoft.Crm.Sdk.Messages.GrantAccessRequest>|
|IsValidStateTransition|<xref href="Microsoft.Dynamics.CRM.IsValidStateTransition?text=IsValidStateTransition Function" />|<xref:Microsoft.Crm.Sdk.Messages.IsValidStateTransitionRequest>|
|ModifyAccess|<xref href="Microsoft.Dynamics.CRM.ModifyAccess?text=ModifyAccess Action" />|<xref:Microsoft.Crm.Sdk.Messages.ModifyAccessRequest>|
|Retrieve|GET [*org URI*]/api/data/v9.0/msdyn_incidenttypeproducts(*msdyn_incidenttypeproductid*)<br />See [Retrieve](../webapi/retrieve-entity-using-web-api.md)|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Retrieve*>|
|RetrieveMultiple|GET [*org URI*]/api/data/v9.0/msdyn_incidenttypeproducts<br />See [Query Data](../webapi/query-data-web-api.md)|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveMultipleRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.RetrieveMultiple*>|
|RetrievePrincipalAccess|<xref href="Microsoft.Dynamics.CRM.RetrievePrincipalAccess?text=RetrievePrincipalAccess Function" />|<xref:Microsoft.Crm.Sdk.Messages.RetrievePrincipalAccessRequest>|
|RetrieveSharedPrincipalsAndAccess|<xref href="Microsoft.Dynamics.CRM.RetrieveSharedPrincipalsAndAccess?text=RetrieveSharedPrincipalsAndAccess Function" />|<xref:Microsoft.Crm.Sdk.Messages.RetrieveSharedPrincipalsAndAccessRequest>|
|RevokeAccess|<xref href="Microsoft.Dynamics.CRM.RevokeAccess?text=RevokeAccess Action" />|<xref:Microsoft.Crm.Sdk.Messages.RevokeAccessRequest>|
|SetState|PATCH [*org URI*]/api/data/v9.0/msdyn_incidenttypeproducts(*msdyn_incidenttypeproductid*)<br />[Update](../webapi/update-delete-entities-using-web-api.md#basic-update) `statecode` and `statuscode` properties.|<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|
|Update|PATCH [*org URI*]/api/data/v9.0/msdyn_incidenttypeproducts(*msdyn_incidenttypeproductid*)<br />See [Update](../webapi/update-delete-entities-using-web-api.md#basic-update)|<xref:Microsoft.Xrm.Sdk.Messages.UpdateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Update*>|

## Properties

**DisplayName**: Incident Type Product<br />
**DisplayCollectionName**: Incident Type Products<br />
**SchemaName**: msdyn_incidenttypeproduct<br />
**CollectionSchemaName**: msdyn_incidenttypeproducts<br />
**LogicalName**: msdyn_incidenttypeproduct<br />
**LogicalCollectionName**: msdyn_incidenttypeproducts<br />
**EntitySetName**: msdyn_incidenttypeproducts<br />
**PrimaryIdAttribute**: msdyn_incidenttypeproductid<br />
**PrimaryNameAttribute**: msdyn_name<br />
**OwnershipType**: UserOwned<br />
**IsBPFEntity**: False<br />
<a name="writable-attributes"></a>

## Writable attributes

These attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [msdyn_Description](#BKMK_msdyn_Description)
- [msdyn_IncidentType](#BKMK_msdyn_IncidentType)
- [msdyn_incidenttypeproductId](#BKMK_msdyn_incidenttypeproductId)
- [msdyn_InternalDescription](#BKMK_msdyn_InternalDescription)
- [msdyn_LineOrder](#BKMK_msdyn_LineOrder)
- [msdyn_name](#BKMK_msdyn_name)
- [msdyn_Product](#BKMK_msdyn_Product)
- [msdyn_Quantity](#BKMK_msdyn_Quantity)
- [msdyn_Unit](#BKMK_msdyn_Unit)
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

**Description**: Enter the description of the product as presented to the customer. The value defaults to the description defined on the product.<br />
**DisplayName**: Description<br />
**LogicalName**: msdyn_description<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Memo<br />
**Format**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 2000


### <a name="BKMK_msdyn_IncidentType"></a> msdyn_IncidentType

**Description**: The Incident related to this product<br />
**DisplayName**: Incident Type<br />
**LogicalName**: msdyn_incidenttype<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: ApplicationRequired<br />
**Type**: Lookup<br />
**Targets**: msdyn_incidenttype


### <a name="BKMK_msdyn_incidenttypeproductId"></a> msdyn_incidenttypeproductId

**Description**: Shows the entity instances.<br />
**DisplayName**: Incident Type Product<br />
**LogicalName**: msdyn_incidenttypeproductid<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: SystemRequired<br />
**IsValidForUpdate**: False<br />
**Type**: Uniqueidentifier<br />


### <a name="BKMK_msdyn_InternalDescription"></a> msdyn_InternalDescription

**Description**: Enter any internal notes you want to track on this product.<br />
**DisplayName**: Internal Description<br />
**LogicalName**: msdyn_internaldescription<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Memo<br />
**Format**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 2000


### <a name="BKMK_msdyn_LineOrder"></a> msdyn_LineOrder

**Description**: <br />
**DisplayName**: Line Order<br />
**LogicalName**: msdyn_lineorder<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Integer<br />
**Format**: None<br />
**MaxValue**: 2147483647<br />
**MinValue**: -2147483648


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
**MaxLength**: 200


### <a name="BKMK_msdyn_Product"></a> msdyn_Product

**Description**: Unique identifier for Product/Service associated with Incident Type Product.<br />
**DisplayName**: Product<br />
**LogicalName**: msdyn_product<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: ApplicationRequired<br />
**Type**: Lookup<br />
**Targets**: product


### <a name="BKMK_msdyn_Quantity"></a> msdyn_Quantity

**Description**: Shows the actual quantity of the product.<br />
**DisplayName**: Quantity<br />
**LogicalName**: msdyn_quantity<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: ApplicationRequired<br />
**Type**: Double<br />
**MaxValue**: 1000000000<br />
**MinValue**: 0<br />
**Precision**: 2


### <a name="BKMK_msdyn_Unit"></a> msdyn_Unit

**Description**: The unit that determines the pricing and final quantity for this product<br />
**DisplayName**: Unit<br />
**LogicalName**: msdyn_unit<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: ApplicationRequired<br />
**Type**: Lookup<br />
**Targets**: uom


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

**Description**: Status of the Incident Type Product<br />
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

**Description**: Reason for the status of the Incident Type Product<br />
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
- [msdyn_IncidentTypeName](#BKMK_msdyn_IncidentTypeName)
- [msdyn_ProductName](#BKMK_msdyn_ProductName)
- [msdyn_UnitName](#BKMK_msdyn_UnitName)
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


### <a name="BKMK_msdyn_IncidentTypeName"></a> msdyn_IncidentTypeName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: msdyn_incidenttypename<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_msdyn_ProductName"></a> msdyn_ProductName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: msdyn_productname<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_msdyn_UnitName"></a> msdyn_UnitName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: msdyn_unitname<br />
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

- [msdyn_incidenttypeproduct_ActivityPointers](#BKMK_msdyn_incidenttypeproduct_ActivityPointers)
- [msdyn_incidenttypeproduct_msdyn_approvals](#BKMK_msdyn_incidenttypeproduct_msdyn_approvals)
- [msdyn_incidenttypeproduct_msdyn_bookingalerts](#BKMK_msdyn_incidenttypeproduct_msdyn_bookingalerts)
- [msdyn_incidenttypeproduct_SyncErrors](#BKMK_msdyn_incidenttypeproduct_SyncErrors)
- [msdyn_incidenttypeproduct_DuplicateMatchingRecord](#BKMK_msdyn_incidenttypeproduct_DuplicateMatchingRecord)
- [msdyn_incidenttypeproduct_DuplicateBaseRecord](#BKMK_msdyn_incidenttypeproduct_DuplicateBaseRecord)
- [msdyn_incidenttypeproduct_SharePointDocumentLocations](#BKMK_msdyn_incidenttypeproduct_SharePointDocumentLocations)
- [msdyn_incidenttypeproduct_SharePointDocuments](#BKMK_msdyn_incidenttypeproduct_SharePointDocuments)
- [msdyn_incidenttypeproduct_AsyncOperations](#BKMK_msdyn_incidenttypeproduct_AsyncOperations)
- [msdyn_incidenttypeproduct_MailboxTrackingFolders](#BKMK_msdyn_incidenttypeproduct_MailboxTrackingFolders)
- [msdyn_incidenttypeproduct_UserEntityInstanceDatas](#BKMK_msdyn_incidenttypeproduct_UserEntityInstanceDatas)
- [msdyn_incidenttypeproduct_ProcessSession](#BKMK_msdyn_incidenttypeproduct_ProcessSession)
- [msdyn_incidenttypeproduct_BulkDeleteFailures](#BKMK_msdyn_incidenttypeproduct_BulkDeleteFailures)
- [msdyn_incidenttypeproduct_PrincipalObjectAttributeAccesses](#BKMK_msdyn_incidenttypeproduct_PrincipalObjectAttributeAccesses)
- [msdyn_incidenttypeproduct_Appointments](#BKMK_msdyn_incidenttypeproduct_Appointments)
- [msdyn_incidenttypeproduct_Emails](#BKMK_msdyn_incidenttypeproduct_Emails)
- [msdyn_incidenttypeproduct_Faxes](#BKMK_msdyn_incidenttypeproduct_Faxes)
- [msdyn_incidenttypeproduct_Letters](#BKMK_msdyn_incidenttypeproduct_Letters)
- [msdyn_incidenttypeproduct_PhoneCalls](#BKMK_msdyn_incidenttypeproduct_PhoneCalls)
- [msdyn_incidenttypeproduct_Tasks](#BKMK_msdyn_incidenttypeproduct_Tasks)
- [msdyn_incidenttypeproduct_RecurringAppointmentMasters](#BKMK_msdyn_incidenttypeproduct_RecurringAppointmentMasters)
- [msdyn_incidenttypeproduct_SocialActivities](#BKMK_msdyn_incidenttypeproduct_SocialActivities)
- [msdyn_incidenttypeproduct_connections1](#BKMK_msdyn_incidenttypeproduct_connections1)
- [msdyn_incidenttypeproduct_connections2](#BKMK_msdyn_incidenttypeproduct_connections2)
- [msdyn_incidenttypeproduct_Annotations](#BKMK_msdyn_incidenttypeproduct_Annotations)
- [msdyn_incidenttypeproduct_ServiceAppointments](#BKMK_msdyn_incidenttypeproduct_ServiceAppointments)


### <a name="BKMK_msdyn_incidenttypeproduct_ActivityPointers"></a> msdyn_incidenttypeproduct_ActivityPointers

Same as activitypointer entity [msdyn_incidenttypeproduct_ActivityPointers](activitypointer.md#BKMK_msdyn_incidenttypeproduct_ActivityPointers) Many-To-One relationship.

**ReferencingEntity**: activitypointer<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_incidenttypeproduct_ActivityPointers<br />
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


### <a name="BKMK_msdyn_incidenttypeproduct_msdyn_approvals"></a> msdyn_incidenttypeproduct_msdyn_approvals

Same as msdyn_approval entity [msdyn_incidenttypeproduct_msdyn_approvals](msdyn_approval.md#BKMK_msdyn_incidenttypeproduct_msdyn_approvals) Many-To-One relationship.

**ReferencingEntity**: msdyn_approval<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_incidenttypeproduct_msdyn_approvals<br />
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


### <a name="BKMK_msdyn_incidenttypeproduct_msdyn_bookingalerts"></a> msdyn_incidenttypeproduct_msdyn_bookingalerts

Same as msdyn_bookingalert entity [msdyn_incidenttypeproduct_msdyn_bookingalerts](msdyn_bookingalert.md#BKMK_msdyn_incidenttypeproduct_msdyn_bookingalerts) Many-To-One relationship.

**ReferencingEntity**: msdyn_bookingalert<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_incidenttypeproduct_msdyn_bookingalerts<br />
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


### <a name="BKMK_msdyn_incidenttypeproduct_SyncErrors"></a> msdyn_incidenttypeproduct_SyncErrors

Same as syncerror entity [msdyn_incidenttypeproduct_SyncErrors](syncerror.md#BKMK_msdyn_incidenttypeproduct_SyncErrors) Many-To-One relationship.

**ReferencingEntity**: syncerror<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_incidenttypeproduct_SyncErrors<br />
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


### <a name="BKMK_msdyn_incidenttypeproduct_DuplicateMatchingRecord"></a> msdyn_incidenttypeproduct_DuplicateMatchingRecord

Same as duplicaterecord entity [msdyn_incidenttypeproduct_DuplicateMatchingRecord](duplicaterecord.md#BKMK_msdyn_incidenttypeproduct_DuplicateMatchingRecord) Many-To-One relationship.

**ReferencingEntity**: duplicaterecord<br />
**ReferencingAttribute**: duplicaterecordid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_incidenttypeproduct_DuplicateMatchingRecord<br />
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


### <a name="BKMK_msdyn_incidenttypeproduct_DuplicateBaseRecord"></a> msdyn_incidenttypeproduct_DuplicateBaseRecord

Same as duplicaterecord entity [msdyn_incidenttypeproduct_DuplicateBaseRecord](duplicaterecord.md#BKMK_msdyn_incidenttypeproduct_DuplicateBaseRecord) Many-To-One relationship.

**ReferencingEntity**: duplicaterecord<br />
**ReferencingAttribute**: baserecordid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_incidenttypeproduct_DuplicateBaseRecord<br />
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


### <a name="BKMK_msdyn_incidenttypeproduct_SharePointDocumentLocations"></a> msdyn_incidenttypeproduct_SharePointDocumentLocations

Same as sharepointdocumentlocation entity [msdyn_incidenttypeproduct_SharePointDocumentLocations](sharepointdocumentlocation.md#BKMK_msdyn_incidenttypeproduct_SharePointDocumentLocations) Many-To-One relationship.

**ReferencingEntity**: sharepointdocumentlocation<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_incidenttypeproduct_SharePointDocumentLocations<br />
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


### <a name="BKMK_msdyn_incidenttypeproduct_SharePointDocuments"></a> msdyn_incidenttypeproduct_SharePointDocuments

Same as sharepointdocument entity [msdyn_incidenttypeproduct_SharePointDocuments](sharepointdocument.md#BKMK_msdyn_incidenttypeproduct_SharePointDocuments) Many-To-One relationship.

**ReferencingEntity**: sharepointdocument<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_incidenttypeproduct_SharePointDocuments<br />
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


### <a name="BKMK_msdyn_incidenttypeproduct_AsyncOperations"></a> msdyn_incidenttypeproduct_AsyncOperations

Same as asyncoperation entity [msdyn_incidenttypeproduct_AsyncOperations](asyncoperation.md#BKMK_msdyn_incidenttypeproduct_AsyncOperations) Many-To-One relationship.

**ReferencingEntity**: asyncoperation<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_incidenttypeproduct_AsyncOperations<br />
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


### <a name="BKMK_msdyn_incidenttypeproduct_MailboxTrackingFolders"></a> msdyn_incidenttypeproduct_MailboxTrackingFolders

Same as mailboxtrackingfolder entity [msdyn_incidenttypeproduct_MailboxTrackingFolders](mailboxtrackingfolder.md#BKMK_msdyn_incidenttypeproduct_MailboxTrackingFolders) Many-To-One relationship.

**ReferencingEntity**: mailboxtrackingfolder<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_incidenttypeproduct_MailboxTrackingFolders<br />
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


### <a name="BKMK_msdyn_incidenttypeproduct_UserEntityInstanceDatas"></a> msdyn_incidenttypeproduct_UserEntityInstanceDatas

Same as userentityinstancedata entity [msdyn_incidenttypeproduct_UserEntityInstanceDatas](userentityinstancedata.md#BKMK_msdyn_incidenttypeproduct_UserEntityInstanceDatas) Many-To-One relationship.

**ReferencingEntity**: userentityinstancedata<br />
**ReferencingAttribute**: objectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_incidenttypeproduct_UserEntityInstanceDatas<br />
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


### <a name="BKMK_msdyn_incidenttypeproduct_ProcessSession"></a> msdyn_incidenttypeproduct_ProcessSession

Same as processsession entity [msdyn_incidenttypeproduct_ProcessSession](processsession.md#BKMK_msdyn_incidenttypeproduct_ProcessSession) Many-To-One relationship.

**ReferencingEntity**: processsession<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_incidenttypeproduct_ProcessSession<br />
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


### <a name="BKMK_msdyn_incidenttypeproduct_BulkDeleteFailures"></a> msdyn_incidenttypeproduct_BulkDeleteFailures

Same as bulkdeletefailure entity [msdyn_incidenttypeproduct_BulkDeleteFailures](bulkdeletefailure.md#BKMK_msdyn_incidenttypeproduct_BulkDeleteFailures) Many-To-One relationship.

**ReferencingEntity**: bulkdeletefailure<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_incidenttypeproduct_BulkDeleteFailures<br />
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


### <a name="BKMK_msdyn_incidenttypeproduct_PrincipalObjectAttributeAccesses"></a> msdyn_incidenttypeproduct_PrincipalObjectAttributeAccesses

Same as principalobjectattributeaccess entity [msdyn_incidenttypeproduct_PrincipalObjectAttributeAccesses](principalobjectattributeaccess.md#BKMK_msdyn_incidenttypeproduct_PrincipalObjectAttributeAccesses) Many-To-One relationship.

**ReferencingEntity**: principalobjectattributeaccess<br />
**ReferencingAttribute**: objectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_incidenttypeproduct_PrincipalObjectAttributeAccesses<br />
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


### <a name="BKMK_msdyn_incidenttypeproduct_Appointments"></a> msdyn_incidenttypeproduct_Appointments

Same as appointment entity [msdyn_incidenttypeproduct_Appointments](appointment.md#BKMK_msdyn_incidenttypeproduct_Appointments) Many-To-One relationship.

**ReferencingEntity**: appointment<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_incidenttypeproduct_Appointments<br />
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


### <a name="BKMK_msdyn_incidenttypeproduct_Emails"></a> msdyn_incidenttypeproduct_Emails

Same as email entity [msdyn_incidenttypeproduct_Emails](email.md#BKMK_msdyn_incidenttypeproduct_Emails) Many-To-One relationship.

**ReferencingEntity**: email<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_incidenttypeproduct_Emails<br />
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


### <a name="BKMK_msdyn_incidenttypeproduct_Faxes"></a> msdyn_incidenttypeproduct_Faxes

Same as fax entity [msdyn_incidenttypeproduct_Faxes](fax.md#BKMK_msdyn_incidenttypeproduct_Faxes) Many-To-One relationship.

**ReferencingEntity**: fax<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_incidenttypeproduct_Faxes<br />
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


### <a name="BKMK_msdyn_incidenttypeproduct_Letters"></a> msdyn_incidenttypeproduct_Letters

Same as letter entity [msdyn_incidenttypeproduct_Letters](letter.md#BKMK_msdyn_incidenttypeproduct_Letters) Many-To-One relationship.

**ReferencingEntity**: letter<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_incidenttypeproduct_Letters<br />
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


### <a name="BKMK_msdyn_incidenttypeproduct_PhoneCalls"></a> msdyn_incidenttypeproduct_PhoneCalls

Same as phonecall entity [msdyn_incidenttypeproduct_PhoneCalls](phonecall.md#BKMK_msdyn_incidenttypeproduct_PhoneCalls) Many-To-One relationship.

**ReferencingEntity**: phonecall<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_incidenttypeproduct_PhoneCalls<br />
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


### <a name="BKMK_msdyn_incidenttypeproduct_Tasks"></a> msdyn_incidenttypeproduct_Tasks

Same as task entity [msdyn_incidenttypeproduct_Tasks](task.md#BKMK_msdyn_incidenttypeproduct_Tasks) Many-To-One relationship.

**ReferencingEntity**: task<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_incidenttypeproduct_Tasks<br />
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


### <a name="BKMK_msdyn_incidenttypeproduct_RecurringAppointmentMasters"></a> msdyn_incidenttypeproduct_RecurringAppointmentMasters

Same as recurringappointmentmaster entity [msdyn_incidenttypeproduct_RecurringAppointmentMasters](recurringappointmentmaster.md#BKMK_msdyn_incidenttypeproduct_RecurringAppointmentMasters) Many-To-One relationship.

**ReferencingEntity**: recurringappointmentmaster<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_incidenttypeproduct_RecurringAppointmentMasters<br />
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


### <a name="BKMK_msdyn_incidenttypeproduct_SocialActivities"></a> msdyn_incidenttypeproduct_SocialActivities

Same as socialactivity entity [msdyn_incidenttypeproduct_SocialActivities](socialactivity.md#BKMK_msdyn_incidenttypeproduct_SocialActivities) Many-To-One relationship.

**ReferencingEntity**: socialactivity<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_incidenttypeproduct_SocialActivities<br />
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


### <a name="BKMK_msdyn_incidenttypeproduct_connections1"></a> msdyn_incidenttypeproduct_connections1

Same as connection entity [msdyn_incidenttypeproduct_connections1](connection.md#BKMK_msdyn_incidenttypeproduct_connections1) Many-To-One relationship.

**ReferencingEntity**: connection<br />
**ReferencingAttribute**: record1id<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_incidenttypeproduct_connections1<br />
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


### <a name="BKMK_msdyn_incidenttypeproduct_connections2"></a> msdyn_incidenttypeproduct_connections2

Same as connection entity [msdyn_incidenttypeproduct_connections2](connection.md#BKMK_msdyn_incidenttypeproduct_connections2) Many-To-One relationship.

**ReferencingEntity**: connection<br />
**ReferencingAttribute**: record2id<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_incidenttypeproduct_connections2<br />
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


### <a name="BKMK_msdyn_incidenttypeproduct_Annotations"></a> msdyn_incidenttypeproduct_Annotations

Same as annotation entity [msdyn_incidenttypeproduct_Annotations](annotation.md#BKMK_msdyn_incidenttypeproduct_Annotations) Many-To-One relationship.

**ReferencingEntity**: annotation<br />
**ReferencingAttribute**: objectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_incidenttypeproduct_Annotations<br />
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


### <a name="BKMK_msdyn_incidenttypeproduct_ServiceAppointments"></a> msdyn_incidenttypeproduct_ServiceAppointments

Same as serviceappointment entity [msdyn_incidenttypeproduct_ServiceAppointments](serviceappointment.md#BKMK_msdyn_incidenttypeproduct_ServiceAppointments) Many-To-One relationship.

**ReferencingEntity**: serviceappointment<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_incidenttypeproduct_ServiceAppointments<br />
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

- [lk_msdyn_incidenttypeproduct_createdby](#BKMK_lk_msdyn_incidenttypeproduct_createdby)
- [lk_msdyn_incidenttypeproduct_createdonbehalfby](#BKMK_lk_msdyn_incidenttypeproduct_createdonbehalfby)
- [lk_msdyn_incidenttypeproduct_modifiedby](#BKMK_lk_msdyn_incidenttypeproduct_modifiedby)
- [lk_msdyn_incidenttypeproduct_modifiedonbehalfby](#BKMK_lk_msdyn_incidenttypeproduct_modifiedonbehalfby)
- [user_msdyn_incidenttypeproduct](#BKMK_user_msdyn_incidenttypeproduct)
- [team_msdyn_incidenttypeproduct](#BKMK_team_msdyn_incidenttypeproduct)
- [business_unit_msdyn_incidenttypeproduct](#BKMK_business_unit_msdyn_incidenttypeproduct)
- [msdyn_msdyn_incidenttype_msdyn_incidenttypeproduct_IncidentType](#BKMK_msdyn_msdyn_incidenttype_msdyn_incidenttypeproduct_IncidentType)
- [msdyn_product_msdyn_incidenttypeproduct_Product](#BKMK_msdyn_product_msdyn_incidenttypeproduct_Product)
- [msdyn_uom_msdyn_incidenttypeproduct_Unit](#BKMK_msdyn_uom_msdyn_incidenttypeproduct_Unit)


### <a name="BKMK_lk_msdyn_incidenttypeproduct_createdby"></a> lk_msdyn_incidenttypeproduct_createdby

See systemuser Entity [lk_msdyn_incidenttypeproduct_createdby](systemuser.md#BKMK_lk_msdyn_incidenttypeproduct_createdby) One-To-Many relationship.

### <a name="BKMK_lk_msdyn_incidenttypeproduct_createdonbehalfby"></a> lk_msdyn_incidenttypeproduct_createdonbehalfby

See systemuser Entity [lk_msdyn_incidenttypeproduct_createdonbehalfby](systemuser.md#BKMK_lk_msdyn_incidenttypeproduct_createdonbehalfby) One-To-Many relationship.

### <a name="BKMK_lk_msdyn_incidenttypeproduct_modifiedby"></a> lk_msdyn_incidenttypeproduct_modifiedby

See systemuser Entity [lk_msdyn_incidenttypeproduct_modifiedby](systemuser.md#BKMK_lk_msdyn_incidenttypeproduct_modifiedby) One-To-Many relationship.

### <a name="BKMK_lk_msdyn_incidenttypeproduct_modifiedonbehalfby"></a> lk_msdyn_incidenttypeproduct_modifiedonbehalfby

See systemuser Entity [lk_msdyn_incidenttypeproduct_modifiedonbehalfby](systemuser.md#BKMK_lk_msdyn_incidenttypeproduct_modifiedonbehalfby) One-To-Many relationship.

### <a name="BKMK_user_msdyn_incidenttypeproduct"></a> user_msdyn_incidenttypeproduct

See systemuser Entity [user_msdyn_incidenttypeproduct](systemuser.md#BKMK_user_msdyn_incidenttypeproduct) One-To-Many relationship.

### <a name="BKMK_team_msdyn_incidenttypeproduct"></a> team_msdyn_incidenttypeproduct

See team Entity [team_msdyn_incidenttypeproduct](team.md#BKMK_team_msdyn_incidenttypeproduct) One-To-Many relationship.

### <a name="BKMK_business_unit_msdyn_incidenttypeproduct"></a> business_unit_msdyn_incidenttypeproduct

See businessunit Entity [business_unit_msdyn_incidenttypeproduct](businessunit.md#BKMK_business_unit_msdyn_incidenttypeproduct) One-To-Many relationship.

### <a name="BKMK_msdyn_msdyn_incidenttype_msdyn_incidenttypeproduct_IncidentType"></a> msdyn_msdyn_incidenttype_msdyn_incidenttypeproduct_IncidentType

See msdyn_incidenttype Entity [msdyn_msdyn_incidenttype_msdyn_incidenttypeproduct_IncidentType](msdyn_incidenttype.md#BKMK_msdyn_msdyn_incidenttype_msdyn_incidenttypeproduct_IncidentType) One-To-Many relationship.

### <a name="BKMK_msdyn_product_msdyn_incidenttypeproduct_Product"></a> msdyn_product_msdyn_incidenttypeproduct_Product

See product Entity [msdyn_product_msdyn_incidenttypeproduct_Product](product.md#BKMK_msdyn_product_msdyn_incidenttypeproduct_Product) One-To-Many relationship.

### <a name="BKMK_msdyn_uom_msdyn_incidenttypeproduct_Unit"></a> msdyn_uom_msdyn_incidenttypeproduct_Unit

See uom Entity [msdyn_uom_msdyn_incidenttypeproduct_Unit](uom.md#BKMK_msdyn_uom_msdyn_incidenttypeproduct_Unit) One-To-Many relationship.

## See also

[About the Entity Reference](../about-entity-reference.md)<br />
[Programming reference for Dynamics 365 Customer Engagement](../programming-reference.md)<br />
[Web API Reference](/dynamics365/customer-engagement/web-api/about)<br />
<xref href="Microsoft.Dynamics.CRM.msdyn_incidenttypeproduct?text=msdyn_incidenttypeproduct EntityType" />