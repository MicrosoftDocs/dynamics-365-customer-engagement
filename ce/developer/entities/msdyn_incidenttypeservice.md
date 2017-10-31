---
title: "msdyn_incidenttypeservice Entity Reference (Developer Guide for Dynamics 365 Customer Engagement)| MicrosoftDocs"
description: "Includes schema information and supported messages for the msdyn_incidenttypeservice entity."
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
# msdyn_incidenttypeservice Entity Reference

[!INCLUDE[](../../includes/cc_applies_to_update_9_0_0.md)]

This entity gives the ability to pre-configure services to be added to a work order when the related incident is added to the work order

**Added by**: Field Service Solution<br />

## Messages

|Message|Web API Operation|SDK Assembly|
|-|-|-|
|Assign|PATCH [*org URI*]/api/data/v9.0/msdyn_incidenttypeservices(*msdyn_incidenttypeserviceid*)<br />[Update](../webapi/update-delete-entities-using-web-api.md#basic-update) `ownerid` property.|<xref:Microsoft.Crm.Sdk.Messages.AssignRequest>|
|Create|POST [*org URI*]/api/data/v9.0/msdyn_incidenttypeservices<br />See [Create](../webapi/create-entity-web-api.md)|<xref:Microsoft.Xrm.Sdk.Messages.CreateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Create*>|
|Delete|DELETE [*org URI*]/api/data/v9.0/msdyn_incidenttypeservices(*msdyn_incidenttypeserviceid*)<br />See [Delete](../webapi/update-delete-entities-using-web-api.md#basic-delete)|<xref:Microsoft.Xrm.Sdk.Messages.DeleteRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Delete*>|
|GrantAccess|<xref href="Microsoft.Dynamics.CRM.GrantAccess?text=GrantAccess Action" />|<xref:Microsoft.Crm.Sdk.Messages.GrantAccessRequest>|
|IsValidStateTransition|<xref href="Microsoft.Dynamics.CRM.IsValidStateTransition?text=IsValidStateTransition Function" />|<xref:Microsoft.Crm.Sdk.Messages.IsValidStateTransitionRequest>|
|ModifyAccess|<xref href="Microsoft.Dynamics.CRM.ModifyAccess?text=ModifyAccess Action" />|<xref:Microsoft.Crm.Sdk.Messages.ModifyAccessRequest>|
|Retrieve|GET [*org URI*]/api/data/v9.0/msdyn_incidenttypeservices(*msdyn_incidenttypeserviceid*)<br />See [Retrieve](../webapi/retrieve-entity-using-web-api.md)|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Retrieve*>|
|RetrieveMultiple|GET [*org URI*]/api/data/v9.0/msdyn_incidenttypeservices<br />See [Query Data](../webapi/query-data-web-api.md)|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveMultipleRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.RetrieveMultiple*>|
|RetrievePrincipalAccess|<xref href="Microsoft.Dynamics.CRM.RetrievePrincipalAccess?text=RetrievePrincipalAccess Function" />|<xref:Microsoft.Crm.Sdk.Messages.RetrievePrincipalAccessRequest>|
|RetrieveSharedPrincipalsAndAccess|<xref href="Microsoft.Dynamics.CRM.RetrieveSharedPrincipalsAndAccess?text=RetrieveSharedPrincipalsAndAccess Function" />|<xref:Microsoft.Crm.Sdk.Messages.RetrieveSharedPrincipalsAndAccessRequest>|
|RevokeAccess|<xref href="Microsoft.Dynamics.CRM.RevokeAccess?text=RevokeAccess Action" />|<xref:Microsoft.Crm.Sdk.Messages.RevokeAccessRequest>|
|SetState|PATCH [*org URI*]/api/data/v9.0/msdyn_incidenttypeservices(*msdyn_incidenttypeserviceid*)<br />[Update](../webapi/update-delete-entities-using-web-api.md#basic-update) `statecode` and `statuscode` properties.|<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|
|Update|PATCH [*org URI*]/api/data/v9.0/msdyn_incidenttypeservices(*msdyn_incidenttypeserviceid*)<br />See [Update](../webapi/update-delete-entities-using-web-api.md#basic-update)|<xref:Microsoft.Xrm.Sdk.Messages.UpdateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Update*>|

## Properties

**DisplayName**: Incident Type Service<br />
**DisplayCollectionName**: Incident Type Services<br />
**SchemaName**: msdyn_incidenttypeservice<br />
**CollectionSchemaName**: msdyn_incidenttypeservices<br />
**LogicalName**: msdyn_incidenttypeservice<br />
**LogicalCollectionName**: msdyn_incidenttypeservices<br />
**EntitySetName**: msdyn_incidenttypeservices<br />
**PrimaryIdAttribute**: msdyn_incidenttypeserviceid<br />
**PrimaryNameAttribute**: msdyn_name<br />
**OwnershipType**: UserOwned<br />
**IsBPFEntity**: False<br />
<a name="writable-attributes"></a>

## Writable attributes

These attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [msdyn_Description](#BKMK_msdyn_Description)
- [msdyn_Duration](#BKMK_msdyn_Duration)
- [msdyn_IncidentType](#BKMK_msdyn_IncidentType)
- [msdyn_incidenttypeserviceId](#BKMK_msdyn_incidenttypeserviceId)
- [msdyn_InternalDescription](#BKMK_msdyn_InternalDescription)
- [msdyn_LineOrder](#BKMK_msdyn_LineOrder)
- [msdyn_name](#BKMK_msdyn_name)
- [msdyn_Service](#BKMK_msdyn_Service)
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

**Description**: Enter the description of the service as presented to the customer. The value defaults to the description defined on the service.<br />
**DisplayName**: Description<br />
**LogicalName**: msdyn_description<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Memo<br />
**Format**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 2000


### <a name="BKMK_msdyn_Duration"></a> msdyn_Duration

**Description**: Shows the duration of the service.<br />
**DisplayName**: Duration<br />
**LogicalName**: msdyn_duration<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: ApplicationRequired<br />
**Type**: Integer<br />
**Format**: Duration<br />
**MaxValue**: 2147483647<br />
**MinValue**: 0


### <a name="BKMK_msdyn_IncidentType"></a> msdyn_IncidentType

**Description**: The Incident related to this product<br />
**DisplayName**: Incident Type<br />
**LogicalName**: msdyn_incidenttype<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: ApplicationRequired<br />
**Type**: Lookup<br />
**Targets**: msdyn_incidenttype


### <a name="BKMK_msdyn_incidenttypeserviceId"></a> msdyn_incidenttypeserviceId

**Description**: Shows the entity instances.<br />
**DisplayName**: Incident Type Service<br />
**LogicalName**: msdyn_incidenttypeserviceid<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: SystemRequired<br />
**IsValidForUpdate**: False<br />
**Type**: Uniqueidentifier<br />


### <a name="BKMK_msdyn_InternalDescription"></a> msdyn_InternalDescription

**Description**: Enter any internal notes you want to track on this service.<br />
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


### <a name="BKMK_msdyn_Service"></a> msdyn_Service

**Description**: Unique identifier for Product/Service associated with Incident Type Service.<br />
**DisplayName**: Service<br />
**LogicalName**: msdyn_service<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: ApplicationRequired<br />
**Type**: Lookup<br />
**Targets**: product


### <a name="BKMK_msdyn_Unit"></a> msdyn_Unit

**Description**: The unit that determines the pricing for this service<br />
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

**Description**: Status of the Incident Type Service<br />
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

**Description**: Reason for the status of the Incident Type Service<br />
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
- [msdyn_ServiceName](#BKMK_msdyn_ServiceName)
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


### <a name="BKMK_msdyn_ServiceName"></a> msdyn_ServiceName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: msdyn_servicename<br />
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

- [msdyn_incidenttypeservice_ActivityPointers](#BKMK_msdyn_incidenttypeservice_ActivityPointers)
- [msdyn_incidenttypeservice_msdyn_approvals](#BKMK_msdyn_incidenttypeservice_msdyn_approvals)
- [msdyn_incidenttypeservice_msdyn_bookingalerts](#BKMK_msdyn_incidenttypeservice_msdyn_bookingalerts)
- [msdyn_incidenttypeservice_SyncErrors](#BKMK_msdyn_incidenttypeservice_SyncErrors)
- [msdyn_incidenttypeservice_DuplicateMatchingRecord](#BKMK_msdyn_incidenttypeservice_DuplicateMatchingRecord)
- [msdyn_incidenttypeservice_DuplicateBaseRecord](#BKMK_msdyn_incidenttypeservice_DuplicateBaseRecord)
- [msdyn_incidenttypeservice_AsyncOperations](#BKMK_msdyn_incidenttypeservice_AsyncOperations)
- [msdyn_incidenttypeservice_MailboxTrackingFolders](#BKMK_msdyn_incidenttypeservice_MailboxTrackingFolders)
- [msdyn_incidenttypeservice_UserEntityInstanceDatas](#BKMK_msdyn_incidenttypeservice_UserEntityInstanceDatas)
- [msdyn_incidenttypeservice_ProcessSession](#BKMK_msdyn_incidenttypeservice_ProcessSession)
- [msdyn_incidenttypeservice_BulkDeleteFailures](#BKMK_msdyn_incidenttypeservice_BulkDeleteFailures)
- [msdyn_incidenttypeservice_PrincipalObjectAttributeAccesses](#BKMK_msdyn_incidenttypeservice_PrincipalObjectAttributeAccesses)
- [msdyn_incidenttypeservice_Appointments](#BKMK_msdyn_incidenttypeservice_Appointments)
- [msdyn_incidenttypeservice_Emails](#BKMK_msdyn_incidenttypeservice_Emails)
- [msdyn_incidenttypeservice_Faxes](#BKMK_msdyn_incidenttypeservice_Faxes)
- [msdyn_incidenttypeservice_Letters](#BKMK_msdyn_incidenttypeservice_Letters)
- [msdyn_incidenttypeservice_PhoneCalls](#BKMK_msdyn_incidenttypeservice_PhoneCalls)
- [msdyn_incidenttypeservice_Tasks](#BKMK_msdyn_incidenttypeservice_Tasks)
- [msdyn_incidenttypeservice_RecurringAppointmentMasters](#BKMK_msdyn_incidenttypeservice_RecurringAppointmentMasters)
- [msdyn_incidenttypeservice_SocialActivities](#BKMK_msdyn_incidenttypeservice_SocialActivities)
- [msdyn_incidenttypeservice_connections1](#BKMK_msdyn_incidenttypeservice_connections1)
- [msdyn_incidenttypeservice_connections2](#BKMK_msdyn_incidenttypeservice_connections2)
- [msdyn_incidenttypeservice_Annotations](#BKMK_msdyn_incidenttypeservice_Annotations)
- [msdyn_incidenttypeservice_ServiceAppointments](#BKMK_msdyn_incidenttypeservice_ServiceAppointments)


### <a name="BKMK_msdyn_incidenttypeservice_ActivityPointers"></a> msdyn_incidenttypeservice_ActivityPointers

Same as activitypointer entity [msdyn_incidenttypeservice_ActivityPointers](activitypointer.md#BKMK_msdyn_incidenttypeservice_ActivityPointers) Many-To-One relationship.

**ReferencingEntity**: activitypointer<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_incidenttypeservice_ActivityPointers<br />
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


### <a name="BKMK_msdyn_incidenttypeservice_msdyn_approvals"></a> msdyn_incidenttypeservice_msdyn_approvals

Same as msdyn_approval entity [msdyn_incidenttypeservice_msdyn_approvals](msdyn_approval.md#BKMK_msdyn_incidenttypeservice_msdyn_approvals) Many-To-One relationship.

**ReferencingEntity**: msdyn_approval<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_incidenttypeservice_msdyn_approvals<br />
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


### <a name="BKMK_msdyn_incidenttypeservice_msdyn_bookingalerts"></a> msdyn_incidenttypeservice_msdyn_bookingalerts

Same as msdyn_bookingalert entity [msdyn_incidenttypeservice_msdyn_bookingalerts](msdyn_bookingalert.md#BKMK_msdyn_incidenttypeservice_msdyn_bookingalerts) Many-To-One relationship.

**ReferencingEntity**: msdyn_bookingalert<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_incidenttypeservice_msdyn_bookingalerts<br />
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


### <a name="BKMK_msdyn_incidenttypeservice_SyncErrors"></a> msdyn_incidenttypeservice_SyncErrors

Same as syncerror entity [msdyn_incidenttypeservice_SyncErrors](syncerror.md#BKMK_msdyn_incidenttypeservice_SyncErrors) Many-To-One relationship.

**ReferencingEntity**: syncerror<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_incidenttypeservice_SyncErrors<br />
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


### <a name="BKMK_msdyn_incidenttypeservice_DuplicateMatchingRecord"></a> msdyn_incidenttypeservice_DuplicateMatchingRecord

Same as duplicaterecord entity [msdyn_incidenttypeservice_DuplicateMatchingRecord](duplicaterecord.md#BKMK_msdyn_incidenttypeservice_DuplicateMatchingRecord) Many-To-One relationship.

**ReferencingEntity**: duplicaterecord<br />
**ReferencingAttribute**: duplicaterecordid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_incidenttypeservice_DuplicateMatchingRecord<br />
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


### <a name="BKMK_msdyn_incidenttypeservice_DuplicateBaseRecord"></a> msdyn_incidenttypeservice_DuplicateBaseRecord

Same as duplicaterecord entity [msdyn_incidenttypeservice_DuplicateBaseRecord](duplicaterecord.md#BKMK_msdyn_incidenttypeservice_DuplicateBaseRecord) Many-To-One relationship.

**ReferencingEntity**: duplicaterecord<br />
**ReferencingAttribute**: baserecordid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_incidenttypeservice_DuplicateBaseRecord<br />
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


### <a name="BKMK_msdyn_incidenttypeservice_AsyncOperations"></a> msdyn_incidenttypeservice_AsyncOperations

Same as asyncoperation entity [msdyn_incidenttypeservice_AsyncOperations](asyncoperation.md#BKMK_msdyn_incidenttypeservice_AsyncOperations) Many-To-One relationship.

**ReferencingEntity**: asyncoperation<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_incidenttypeservice_AsyncOperations<br />
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


### <a name="BKMK_msdyn_incidenttypeservice_MailboxTrackingFolders"></a> msdyn_incidenttypeservice_MailboxTrackingFolders

Same as mailboxtrackingfolder entity [msdyn_incidenttypeservice_MailboxTrackingFolders](mailboxtrackingfolder.md#BKMK_msdyn_incidenttypeservice_MailboxTrackingFolders) Many-To-One relationship.

**ReferencingEntity**: mailboxtrackingfolder<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_incidenttypeservice_MailboxTrackingFolders<br />
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


### <a name="BKMK_msdyn_incidenttypeservice_UserEntityInstanceDatas"></a> msdyn_incidenttypeservice_UserEntityInstanceDatas

Same as userentityinstancedata entity [msdyn_incidenttypeservice_UserEntityInstanceDatas](userentityinstancedata.md#BKMK_msdyn_incidenttypeservice_UserEntityInstanceDatas) Many-To-One relationship.

**ReferencingEntity**: userentityinstancedata<br />
**ReferencingAttribute**: objectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_incidenttypeservice_UserEntityInstanceDatas<br />
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


### <a name="BKMK_msdyn_incidenttypeservice_ProcessSession"></a> msdyn_incidenttypeservice_ProcessSession

Same as processsession entity [msdyn_incidenttypeservice_ProcessSession](processsession.md#BKMK_msdyn_incidenttypeservice_ProcessSession) Many-To-One relationship.

**ReferencingEntity**: processsession<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_incidenttypeservice_ProcessSession<br />
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


### <a name="BKMK_msdyn_incidenttypeservice_BulkDeleteFailures"></a> msdyn_incidenttypeservice_BulkDeleteFailures

Same as bulkdeletefailure entity [msdyn_incidenttypeservice_BulkDeleteFailures](bulkdeletefailure.md#BKMK_msdyn_incidenttypeservice_BulkDeleteFailures) Many-To-One relationship.

**ReferencingEntity**: bulkdeletefailure<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_incidenttypeservice_BulkDeleteFailures<br />
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


### <a name="BKMK_msdyn_incidenttypeservice_PrincipalObjectAttributeAccesses"></a> msdyn_incidenttypeservice_PrincipalObjectAttributeAccesses

Same as principalobjectattributeaccess entity [msdyn_incidenttypeservice_PrincipalObjectAttributeAccesses](principalobjectattributeaccess.md#BKMK_msdyn_incidenttypeservice_PrincipalObjectAttributeAccesses) Many-To-One relationship.

**ReferencingEntity**: principalobjectattributeaccess<br />
**ReferencingAttribute**: objectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_incidenttypeservice_PrincipalObjectAttributeAccesses<br />
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


### <a name="BKMK_msdyn_incidenttypeservice_Appointments"></a> msdyn_incidenttypeservice_Appointments

Same as appointment entity [msdyn_incidenttypeservice_Appointments](appointment.md#BKMK_msdyn_incidenttypeservice_Appointments) Many-To-One relationship.

**ReferencingEntity**: appointment<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_incidenttypeservice_Appointments<br />
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


### <a name="BKMK_msdyn_incidenttypeservice_Emails"></a> msdyn_incidenttypeservice_Emails

Same as email entity [msdyn_incidenttypeservice_Emails](email.md#BKMK_msdyn_incidenttypeservice_Emails) Many-To-One relationship.

**ReferencingEntity**: email<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_incidenttypeservice_Emails<br />
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


### <a name="BKMK_msdyn_incidenttypeservice_Faxes"></a> msdyn_incidenttypeservice_Faxes

Same as fax entity [msdyn_incidenttypeservice_Faxes](fax.md#BKMK_msdyn_incidenttypeservice_Faxes) Many-To-One relationship.

**ReferencingEntity**: fax<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_incidenttypeservice_Faxes<br />
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


### <a name="BKMK_msdyn_incidenttypeservice_Letters"></a> msdyn_incidenttypeservice_Letters

Same as letter entity [msdyn_incidenttypeservice_Letters](letter.md#BKMK_msdyn_incidenttypeservice_Letters) Many-To-One relationship.

**ReferencingEntity**: letter<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_incidenttypeservice_Letters<br />
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


### <a name="BKMK_msdyn_incidenttypeservice_PhoneCalls"></a> msdyn_incidenttypeservice_PhoneCalls

Same as phonecall entity [msdyn_incidenttypeservice_PhoneCalls](phonecall.md#BKMK_msdyn_incidenttypeservice_PhoneCalls) Many-To-One relationship.

**ReferencingEntity**: phonecall<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_incidenttypeservice_PhoneCalls<br />
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


### <a name="BKMK_msdyn_incidenttypeservice_Tasks"></a> msdyn_incidenttypeservice_Tasks

Same as task entity [msdyn_incidenttypeservice_Tasks](task.md#BKMK_msdyn_incidenttypeservice_Tasks) Many-To-One relationship.

**ReferencingEntity**: task<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_incidenttypeservice_Tasks<br />
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


### <a name="BKMK_msdyn_incidenttypeservice_RecurringAppointmentMasters"></a> msdyn_incidenttypeservice_RecurringAppointmentMasters

Same as recurringappointmentmaster entity [msdyn_incidenttypeservice_RecurringAppointmentMasters](recurringappointmentmaster.md#BKMK_msdyn_incidenttypeservice_RecurringAppointmentMasters) Many-To-One relationship.

**ReferencingEntity**: recurringappointmentmaster<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_incidenttypeservice_RecurringAppointmentMasters<br />
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


### <a name="BKMK_msdyn_incidenttypeservice_SocialActivities"></a> msdyn_incidenttypeservice_SocialActivities

Same as socialactivity entity [msdyn_incidenttypeservice_SocialActivities](socialactivity.md#BKMK_msdyn_incidenttypeservice_SocialActivities) Many-To-One relationship.

**ReferencingEntity**: socialactivity<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_incidenttypeservice_SocialActivities<br />
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


### <a name="BKMK_msdyn_incidenttypeservice_connections1"></a> msdyn_incidenttypeservice_connections1

Same as connection entity [msdyn_incidenttypeservice_connections1](connection.md#BKMK_msdyn_incidenttypeservice_connections1) Many-To-One relationship.

**ReferencingEntity**: connection<br />
**ReferencingAttribute**: record1id<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_incidenttypeservice_connections1<br />
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


### <a name="BKMK_msdyn_incidenttypeservice_connections2"></a> msdyn_incidenttypeservice_connections2

Same as connection entity [msdyn_incidenttypeservice_connections2](connection.md#BKMK_msdyn_incidenttypeservice_connections2) Many-To-One relationship.

**ReferencingEntity**: connection<br />
**ReferencingAttribute**: record2id<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_incidenttypeservice_connections2<br />
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


### <a name="BKMK_msdyn_incidenttypeservice_Annotations"></a> msdyn_incidenttypeservice_Annotations

Same as annotation entity [msdyn_incidenttypeservice_Annotations](annotation.md#BKMK_msdyn_incidenttypeservice_Annotations) Many-To-One relationship.

**ReferencingEntity**: annotation<br />
**ReferencingAttribute**: objectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_incidenttypeservice_Annotations<br />
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


### <a name="BKMK_msdyn_incidenttypeservice_ServiceAppointments"></a> msdyn_incidenttypeservice_ServiceAppointments

Same as serviceappointment entity [msdyn_incidenttypeservice_ServiceAppointments](serviceappointment.md#BKMK_msdyn_incidenttypeservice_ServiceAppointments) Many-To-One relationship.

**ReferencingEntity**: serviceappointment<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_incidenttypeservice_ServiceAppointments<br />
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

- [lk_msdyn_incidenttypeservice_createdby](#BKMK_lk_msdyn_incidenttypeservice_createdby)
- [lk_msdyn_incidenttypeservice_createdonbehalfby](#BKMK_lk_msdyn_incidenttypeservice_createdonbehalfby)
- [lk_msdyn_incidenttypeservice_modifiedby](#BKMK_lk_msdyn_incidenttypeservice_modifiedby)
- [lk_msdyn_incidenttypeservice_modifiedonbehalfby](#BKMK_lk_msdyn_incidenttypeservice_modifiedonbehalfby)
- [user_msdyn_incidenttypeservice](#BKMK_user_msdyn_incidenttypeservice)
- [team_msdyn_incidenttypeservice](#BKMK_team_msdyn_incidenttypeservice)
- [business_unit_msdyn_incidenttypeservice](#BKMK_business_unit_msdyn_incidenttypeservice)
- [msdyn_msdyn_incidenttype_msdyn_incidenttypeservice_IncidentType](#BKMK_msdyn_msdyn_incidenttype_msdyn_incidenttypeservice_IncidentType)
- [msdyn_product_msdyn_incidenttypeservice_Service](#BKMK_msdyn_product_msdyn_incidenttypeservice_Service)
- [msdyn_uom_msdyn_incidenttypeservice_Unit](#BKMK_msdyn_uom_msdyn_incidenttypeservice_Unit)


### <a name="BKMK_lk_msdyn_incidenttypeservice_createdby"></a> lk_msdyn_incidenttypeservice_createdby

See systemuser Entity [lk_msdyn_incidenttypeservice_createdby](systemuser.md#BKMK_lk_msdyn_incidenttypeservice_createdby) One-To-Many relationship.

### <a name="BKMK_lk_msdyn_incidenttypeservice_createdonbehalfby"></a> lk_msdyn_incidenttypeservice_createdonbehalfby

See systemuser Entity [lk_msdyn_incidenttypeservice_createdonbehalfby](systemuser.md#BKMK_lk_msdyn_incidenttypeservice_createdonbehalfby) One-To-Many relationship.

### <a name="BKMK_lk_msdyn_incidenttypeservice_modifiedby"></a> lk_msdyn_incidenttypeservice_modifiedby

See systemuser Entity [lk_msdyn_incidenttypeservice_modifiedby](systemuser.md#BKMK_lk_msdyn_incidenttypeservice_modifiedby) One-To-Many relationship.

### <a name="BKMK_lk_msdyn_incidenttypeservice_modifiedonbehalfby"></a> lk_msdyn_incidenttypeservice_modifiedonbehalfby

See systemuser Entity [lk_msdyn_incidenttypeservice_modifiedonbehalfby](systemuser.md#BKMK_lk_msdyn_incidenttypeservice_modifiedonbehalfby) One-To-Many relationship.

### <a name="BKMK_user_msdyn_incidenttypeservice"></a> user_msdyn_incidenttypeservice

See systemuser Entity [user_msdyn_incidenttypeservice](systemuser.md#BKMK_user_msdyn_incidenttypeservice) One-To-Many relationship.

### <a name="BKMK_team_msdyn_incidenttypeservice"></a> team_msdyn_incidenttypeservice

See team Entity [team_msdyn_incidenttypeservice](team.md#BKMK_team_msdyn_incidenttypeservice) One-To-Many relationship.

### <a name="BKMK_business_unit_msdyn_incidenttypeservice"></a> business_unit_msdyn_incidenttypeservice

See businessunit Entity [business_unit_msdyn_incidenttypeservice](businessunit.md#BKMK_business_unit_msdyn_incidenttypeservice) One-To-Many relationship.

### <a name="BKMK_msdyn_msdyn_incidenttype_msdyn_incidenttypeservice_IncidentType"></a> msdyn_msdyn_incidenttype_msdyn_incidenttypeservice_IncidentType

See msdyn_incidenttype Entity [msdyn_msdyn_incidenttype_msdyn_incidenttypeservice_IncidentType](msdyn_incidenttype.md#BKMK_msdyn_msdyn_incidenttype_msdyn_incidenttypeservice_IncidentType) One-To-Many relationship.

### <a name="BKMK_msdyn_product_msdyn_incidenttypeservice_Service"></a> msdyn_product_msdyn_incidenttypeservice_Service

See product Entity [msdyn_product_msdyn_incidenttypeservice_Service](product.md#BKMK_msdyn_product_msdyn_incidenttypeservice_Service) One-To-Many relationship.

### <a name="BKMK_msdyn_uom_msdyn_incidenttypeservice_Unit"></a> msdyn_uom_msdyn_incidenttypeservice_Unit

See uom Entity [msdyn_uom_msdyn_incidenttypeservice_Unit](uom.md#BKMK_msdyn_uom_msdyn_incidenttypeservice_Unit) One-To-Many relationship.

## See also

[About the Entity Reference](../about-entity-reference.md)<br />
[Programming reference for Dynamics 365 Customer Engagement](../programming-reference.md)<br />
[Web API Reference](/dynamics365/customer-engagement/web-api/about)<br />
<xref href="Microsoft.Dynamics.CRM.msdyn_incidenttypeservice?text=msdyn_incidenttypeservice EntityType" />