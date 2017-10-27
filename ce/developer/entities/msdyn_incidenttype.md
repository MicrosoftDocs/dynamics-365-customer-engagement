---
title: "msdyn_incidenttype Entity Reference (Developer Guide for Dynamics 365 Customer Engagement)| MicrosoftDocs"
description: "Includes schema information and supported messages for the msdyn_incidenttype entity."
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
# msdyn_incidenttype Entity Reference

Incident types define the various types of incidents (issues) that a customer could report, on which work orders are based.

**Added by**: Field Service Solution<br />

## Messages

|Message|Web API Operation|SDK Assembly|
|-|-|-|
|Assign|PATCH [*org URI*]/api/data/v9.0/msdyn_incidenttypes(*msdyn_incidenttypeid*)<br />[Update](../webapi/update-delete-entities-using-web-api.md#basic-update) `ownerid` property.|<xref:Microsoft.Crm.Sdk.Messages.AssignRequest>|
|Create|POST [*org URI*]/api/data/v9.0/msdyn_incidenttypes<br />See [Create](../webapi/create-entity-web-api.md)|<xref:Microsoft.Xrm.Sdk.Messages.CreateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Create*>|
|Delete|DELETE [*org URI*]/api/data/v9.0/msdyn_incidenttypes(*msdyn_incidenttypeid*)<br />See [Delete](../webapi/update-delete-entities-using-web-api.md#basic-delete)|<xref:Microsoft.Xrm.Sdk.Messages.DeleteRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Delete*>|
|GrantAccess|<xref href="Microsoft.Dynamics.CRM.GrantAccess?text=GrantAccess Action" />|<xref:Microsoft.Crm.Sdk.Messages.GrantAccessRequest>|
|IsValidStateTransition|<xref href="Microsoft.Dynamics.CRM.IsValidStateTransition?text=IsValidStateTransition Function" />|<xref:Microsoft.Crm.Sdk.Messages.IsValidStateTransitionRequest>|
|ModifyAccess|<xref href="Microsoft.Dynamics.CRM.ModifyAccess?text=ModifyAccess Action" />|<xref:Microsoft.Crm.Sdk.Messages.ModifyAccessRequest>|
|Retrieve|GET [*org URI*]/api/data/v9.0/msdyn_incidenttypes(*msdyn_incidenttypeid*)<br />See [Retrieve](../webapi/retrieve-entity-using-web-api.md)|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Retrieve*>|
|RetrieveMultiple|GET [*org URI*]/api/data/v9.0/msdyn_incidenttypes<br />See [Query Data](../webapi/query-data-web-api.md)|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveMultipleRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.RetrieveMultiple*>|
|RetrievePrincipalAccess|<xref href="Microsoft.Dynamics.CRM.RetrievePrincipalAccess?text=RetrievePrincipalAccess Function" />|<xref:Microsoft.Crm.Sdk.Messages.RetrievePrincipalAccessRequest>|
|RetrieveSharedPrincipalsAndAccess|<xref href="Microsoft.Dynamics.CRM.RetrieveSharedPrincipalsAndAccess?text=RetrieveSharedPrincipalsAndAccess Function" />|<xref:Microsoft.Crm.Sdk.Messages.RetrieveSharedPrincipalsAndAccessRequest>|
|RevokeAccess|<xref href="Microsoft.Dynamics.CRM.RevokeAccess?text=RevokeAccess Action" />|<xref:Microsoft.Crm.Sdk.Messages.RevokeAccessRequest>|
|SetState|PATCH [*org URI*]/api/data/v9.0/msdyn_incidenttypes(*msdyn_incidenttypeid*)<br />[Update](../webapi/update-delete-entities-using-web-api.md#basic-update) `statecode` and `statuscode` properties.|<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|
|Update|PATCH [*org URI*]/api/data/v9.0/msdyn_incidenttypes(*msdyn_incidenttypeid*)<br />See [Update](../webapi/update-delete-entities-using-web-api.md#basic-update)|<xref:Microsoft.Xrm.Sdk.Messages.UpdateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Update*>|

## Properties

**DisplayName**: Incident Type<br />
**DisplayCollectionName**: Incident Types<br />
**SchemaName**: msdyn_incidenttype<br />
**CollectionSchemaName**: msdyn_incidenttypes<br />
**LogicalName**: msdyn_incidenttype<br />
**LogicalCollectionName**: msdyn_incidenttypes<br />
**EntitySetName**: msdyn_incidenttypes<br />
**PrimaryIdAttribute**: msdyn_incidenttypeid<br />
**PrimaryNameAttribute**: msdyn_name<br />
**OwnershipType**: UserOwned<br />
**IsBPFEntity**: False<br />
<a name="writable-attributes"></a>

## Writable attributes

These attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [msdyn_CopyIncidentItemstoAgreement](#BKMK_msdyn_CopyIncidentItemstoAgreement)
- [msdyn_DefaultWorkOrderType](#BKMK_msdyn_DefaultWorkOrderType)
- [msdyn_Description](#BKMK_msdyn_Description)
- [msdyn_EstimatedDuration](#BKMK_msdyn_EstimatedDuration)
- [msdyn_incidenttypeId](#BKMK_msdyn_incidenttypeId)
- [msdyn_name](#BKMK_msdyn_name)
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


### <a name="BKMK_msdyn_CopyIncidentItemstoAgreement"></a> msdyn_CopyIncidentItemstoAgreement

**Description**: <br />
**DisplayName**: Copy Incident Items to Agreement<br />
**LogicalName**: msdyn_copyincidentitemstoagreement<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Boolean<br />
**Options**:

- **TrueOption Value**: 1 **Label**: Yes
- **FalseOption Value**: 0 **Label**: No

**DefaultValue**: False


### <a name="BKMK_msdyn_DefaultWorkOrderType"></a> msdyn_DefaultWorkOrderType

**Description**: Unique identifier for Work Order Type associated with Incident Type.<br />
**DisplayName**: Default Work Order Type<br />
**LogicalName**: msdyn_defaultworkordertype<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: msdyn_workordertype


### <a name="BKMK_msdyn_Description"></a> msdyn_Description

**Description**: Incident Type description. This will be the default description shown on the work order<br />
**DisplayName**: Description<br />
**LogicalName**: msdyn_description<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Memo<br />
**Format**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 8000


### <a name="BKMK_msdyn_EstimatedDuration"></a> msdyn_EstimatedDuration

**Description**: <br />
**DisplayName**: Estimated Duration<br />
**LogicalName**: msdyn_estimatedduration<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Integer<br />
**Format**: Duration<br />
**MaxValue**: 2147483647<br />
**MinValue**: 0


### <a name="BKMK_msdyn_incidenttypeId"></a> msdyn_incidenttypeId

**Description**: Shows the entity instances.<br />
**DisplayName**: Incident Type<br />
**LogicalName**: msdyn_incidenttypeid<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: SystemRequired<br />
**IsValidForUpdate**: False<br />
**Type**: Uniqueidentifier<br />


### <a name="BKMK_msdyn_name"></a> msdyn_name

**Description**: Incident Type name<br />
**DisplayName**: Name<br />
**LogicalName**: msdyn_name<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: ApplicationRequired<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


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

**Description**: Status of the Incident Type<br />
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

**Description**: Reason for the status of the Incident Type<br />
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
- [msdyn_DefaultWorkOrderTypeName](#BKMK_msdyn_DefaultWorkOrderTypeName)
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


### <a name="BKMK_msdyn_DefaultWorkOrderTypeName"></a> msdyn_DefaultWorkOrderTypeName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: msdyn_defaultworkordertypename<br />
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

- [msdyn_incidenttype_SyncErrors](#BKMK_msdyn_incidenttype_SyncErrors)
- [msdyn_incidenttype_DuplicateMatchingRecord](#BKMK_msdyn_incidenttype_DuplicateMatchingRecord)
- [msdyn_incidenttype_DuplicateBaseRecord](#BKMK_msdyn_incidenttype_DuplicateBaseRecord)
- [msdyn_incidenttype_AsyncOperations](#BKMK_msdyn_incidenttype_AsyncOperations)
- [msdyn_incidenttype_MailboxTrackingFolders](#BKMK_msdyn_incidenttype_MailboxTrackingFolders)
- [msdyn_incidenttype_UserEntityInstanceDatas](#BKMK_msdyn_incidenttype_UserEntityInstanceDatas)
- [msdyn_incidenttype_ProcessSession](#BKMK_msdyn_incidenttype_ProcessSession)
- [msdyn_incidenttype_BulkDeleteFailures](#BKMK_msdyn_incidenttype_BulkDeleteFailures)
- [msdyn_incidenttype_PrincipalObjectAttributeAccesses](#BKMK_msdyn_incidenttype_PrincipalObjectAttributeAccesses)
- [msdyn_incidenttype_Annotations](#BKMK_msdyn_incidenttype_Annotations)
- [msdyn_msdyn_incidenttype_incident_IncidentType](#BKMK_msdyn_msdyn_incidenttype_incident_IncidentType)
- [msdyn_msdyn_incidenttype_msdyn_actual_IncidentType](#BKMK_msdyn_msdyn_incidenttype_msdyn_actual_IncidentType)
- [msdyn_msdyn_incidenttype_msdyn_agreementbookingincident_IncidentType](#BKMK_msdyn_msdyn_incidenttype_msdyn_agreementbookingincident_IncidentType)
- [msdyn_msdyn_incidenttype_msdyn_incidenttypecharacteristic_IncidentType](#BKMK_msdyn_msdyn_incidenttype_msdyn_incidenttypecharacteristic_IncidentType)
- [msdyn_msdyn_incidenttype_msdyn_incidenttypeproduct_IncidentType](#BKMK_msdyn_msdyn_incidenttype_msdyn_incidenttypeproduct_IncidentType)
- [msdyn_msdyn_incidenttype_msdyn_incidenttypeservice_IncidentType](#BKMK_msdyn_msdyn_incidenttype_msdyn_incidenttypeservice_IncidentType)
- [msdyn_msdyn_incidenttype_msdyn_incidenttypeservicetask_IncidentType](#BKMK_msdyn_msdyn_incidenttype_msdyn_incidenttypeservicetask_IncidentType)
- [msdyn_msdyn_incidenttype_msdyn_quotebookingincident_IncidentType](#BKMK_msdyn_msdyn_incidenttype_msdyn_quotebookingincident_IncidentType)
- [msdyn_msdyn_incidenttype_msdyn_workorder_PrimaryIncidentType](#BKMK_msdyn_msdyn_incidenttype_msdyn_workorder_PrimaryIncidentType)
- [msdyn_msdyn_incidenttype_msdyn_workorderincident_IncidentType](#BKMK_msdyn_msdyn_incidenttype_msdyn_workorderincident_IncidentType)


### <a name="BKMK_msdyn_incidenttype_SyncErrors"></a> msdyn_incidenttype_SyncErrors

Same as syncerror entity [msdyn_incidenttype_SyncErrors](syncerror.md#BKMK_msdyn_incidenttype_SyncErrors) Many-To-One relationship.

**ReferencingEntity**: syncerror<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_incidenttype_SyncErrors<br />
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


### <a name="BKMK_msdyn_incidenttype_DuplicateMatchingRecord"></a> msdyn_incidenttype_DuplicateMatchingRecord

Same as duplicaterecord entity [msdyn_incidenttype_DuplicateMatchingRecord](duplicaterecord.md#BKMK_msdyn_incidenttype_DuplicateMatchingRecord) Many-To-One relationship.

**ReferencingEntity**: duplicaterecord<br />
**ReferencingAttribute**: duplicaterecordid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_incidenttype_DuplicateMatchingRecord<br />
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


### <a name="BKMK_msdyn_incidenttype_DuplicateBaseRecord"></a> msdyn_incidenttype_DuplicateBaseRecord

Same as duplicaterecord entity [msdyn_incidenttype_DuplicateBaseRecord](duplicaterecord.md#BKMK_msdyn_incidenttype_DuplicateBaseRecord) Many-To-One relationship.

**ReferencingEntity**: duplicaterecord<br />
**ReferencingAttribute**: baserecordid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_incidenttype_DuplicateBaseRecord<br />
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


### <a name="BKMK_msdyn_incidenttype_AsyncOperations"></a> msdyn_incidenttype_AsyncOperations

Same as asyncoperation entity [msdyn_incidenttype_AsyncOperations](asyncoperation.md#BKMK_msdyn_incidenttype_AsyncOperations) Many-To-One relationship.

**ReferencingEntity**: asyncoperation<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_incidenttype_AsyncOperations<br />
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


### <a name="BKMK_msdyn_incidenttype_MailboxTrackingFolders"></a> msdyn_incidenttype_MailboxTrackingFolders

Same as mailboxtrackingfolder entity [msdyn_incidenttype_MailboxTrackingFolders](mailboxtrackingfolder.md#BKMK_msdyn_incidenttype_MailboxTrackingFolders) Many-To-One relationship.

**ReferencingEntity**: mailboxtrackingfolder<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_incidenttype_MailboxTrackingFolders<br />
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


### <a name="BKMK_msdyn_incidenttype_UserEntityInstanceDatas"></a> msdyn_incidenttype_UserEntityInstanceDatas

Same as userentityinstancedata entity [msdyn_incidenttype_UserEntityInstanceDatas](userentityinstancedata.md#BKMK_msdyn_incidenttype_UserEntityInstanceDatas) Many-To-One relationship.

**ReferencingEntity**: userentityinstancedata<br />
**ReferencingAttribute**: objectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_incidenttype_UserEntityInstanceDatas<br />
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


### <a name="BKMK_msdyn_incidenttype_ProcessSession"></a> msdyn_incidenttype_ProcessSession

Same as processsession entity [msdyn_incidenttype_ProcessSession](processsession.md#BKMK_msdyn_incidenttype_ProcessSession) Many-To-One relationship.

**ReferencingEntity**: processsession<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_incidenttype_ProcessSession<br />
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


### <a name="BKMK_msdyn_incidenttype_BulkDeleteFailures"></a> msdyn_incidenttype_BulkDeleteFailures

Same as bulkdeletefailure entity [msdyn_incidenttype_BulkDeleteFailures](bulkdeletefailure.md#BKMK_msdyn_incidenttype_BulkDeleteFailures) Many-To-One relationship.

**ReferencingEntity**: bulkdeletefailure<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_incidenttype_BulkDeleteFailures<br />
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


### <a name="BKMK_msdyn_incidenttype_PrincipalObjectAttributeAccesses"></a> msdyn_incidenttype_PrincipalObjectAttributeAccesses

Same as principalobjectattributeaccess entity [msdyn_incidenttype_PrincipalObjectAttributeAccesses](principalobjectattributeaccess.md#BKMK_msdyn_incidenttype_PrincipalObjectAttributeAccesses) Many-To-One relationship.

**ReferencingEntity**: principalobjectattributeaccess<br />
**ReferencingAttribute**: objectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_incidenttype_PrincipalObjectAttributeAccesses<br />
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


### <a name="BKMK_msdyn_incidenttype_Annotations"></a> msdyn_incidenttype_Annotations

Same as annotation entity [msdyn_incidenttype_Annotations](annotation.md#BKMK_msdyn_incidenttype_Annotations) Many-To-One relationship.

**ReferencingEntity**: annotation<br />
**ReferencingAttribute**: objectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_incidenttype_Annotations<br />
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


### <a name="BKMK_msdyn_msdyn_incidenttype_incident_IncidentType"></a> msdyn_msdyn_incidenttype_incident_IncidentType

Same as incident entity [msdyn_msdyn_incidenttype_incident_IncidentType](incident.md#BKMK_msdyn_msdyn_incidenttype_incident_IncidentType) Many-To-One relationship.

**ReferencingEntity**: incident<br />
**ReferencingAttribute**: msdyn_incidenttype<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_msdyn_incidenttype_incident_IncidentType<br />
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


### <a name="BKMK_msdyn_msdyn_incidenttype_msdyn_actual_IncidentType"></a> msdyn_msdyn_incidenttype_msdyn_actual_IncidentType

Same as msdyn_actual entity [msdyn_msdyn_incidenttype_msdyn_actual_IncidentType](msdyn_actual.md#BKMK_msdyn_msdyn_incidenttype_msdyn_actual_IncidentType) Many-To-One relationship.

**ReferencingEntity**: msdyn_actual<br />
**ReferencingAttribute**: msdyn_incidenttype<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_msdyn_incidenttype_msdyn_actual_IncidentType<br />
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


### <a name="BKMK_msdyn_msdyn_incidenttype_msdyn_agreementbookingincident_IncidentType"></a> msdyn_msdyn_incidenttype_msdyn_agreementbookingincident_IncidentType

Same as msdyn_agreementbookingincident entity [msdyn_msdyn_incidenttype_msdyn_agreementbookingincident_IncidentType](msdyn_agreementbookingincident.md#BKMK_msdyn_msdyn_incidenttype_msdyn_agreementbookingincident_IncidentType) Many-To-One relationship.

**ReferencingEntity**: msdyn_agreementbookingincident<br />
**ReferencingAttribute**: msdyn_incidenttype<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_msdyn_incidenttype_msdyn_agreementbookingincident_IncidentType<br />
**AssociatedMenuConfiguration**:

- **Behavior**: UseLabel
- **Group**: Details
- **Label**: Incident Type
- **Order**: 10000

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: Restrict
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_msdyn_msdyn_incidenttype_msdyn_incidenttypecharacteristic_IncidentType"></a> msdyn_msdyn_incidenttype_msdyn_incidenttypecharacteristic_IncidentType

Same as msdyn_incidenttypecharacteristic entity [msdyn_msdyn_incidenttype_msdyn_incidenttypecharacteristic_IncidentType](msdyn_incidenttypecharacteristic.md#BKMK_msdyn_msdyn_incidenttype_msdyn_incidenttypecharacteristic_IncidentType) Many-To-One relationship.

**ReferencingEntity**: msdyn_incidenttypecharacteristic<br />
**ReferencingAttribute**: msdyn_incidenttype<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_msdyn_incidenttype_msdyn_incidenttypecharacteristic_IncidentType<br />
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


### <a name="BKMK_msdyn_msdyn_incidenttype_msdyn_incidenttypeproduct_IncidentType"></a> msdyn_msdyn_incidenttype_msdyn_incidenttypeproduct_IncidentType

Same as msdyn_incidenttypeproduct entity [msdyn_msdyn_incidenttype_msdyn_incidenttypeproduct_IncidentType](msdyn_incidenttypeproduct.md#BKMK_msdyn_msdyn_incidenttype_msdyn_incidenttypeproduct_IncidentType) Many-To-One relationship.

**ReferencingEntity**: msdyn_incidenttypeproduct<br />
**ReferencingAttribute**: msdyn_incidenttype<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_msdyn_incidenttype_msdyn_incidenttypeproduct_IncidentType<br />
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


### <a name="BKMK_msdyn_msdyn_incidenttype_msdyn_incidenttypeservice_IncidentType"></a> msdyn_msdyn_incidenttype_msdyn_incidenttypeservice_IncidentType

Same as msdyn_incidenttypeservice entity [msdyn_msdyn_incidenttype_msdyn_incidenttypeservice_IncidentType](msdyn_incidenttypeservice.md#BKMK_msdyn_msdyn_incidenttype_msdyn_incidenttypeservice_IncidentType) Many-To-One relationship.

**ReferencingEntity**: msdyn_incidenttypeservice<br />
**ReferencingAttribute**: msdyn_incidenttype<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_msdyn_incidenttype_msdyn_incidenttypeservice_IncidentType<br />
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


### <a name="BKMK_msdyn_msdyn_incidenttype_msdyn_incidenttypeservicetask_IncidentType"></a> msdyn_msdyn_incidenttype_msdyn_incidenttypeservicetask_IncidentType

Same as msdyn_incidenttypeservicetask entity [msdyn_msdyn_incidenttype_msdyn_incidenttypeservicetask_IncidentType](msdyn_incidenttypeservicetask.md#BKMK_msdyn_msdyn_incidenttype_msdyn_incidenttypeservicetask_IncidentType) Many-To-One relationship.

**ReferencingEntity**: msdyn_incidenttypeservicetask<br />
**ReferencingAttribute**: msdyn_incidenttype<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_msdyn_incidenttype_msdyn_incidenttypeservicetask_IncidentType<br />
**AssociatedMenuConfiguration**:

- **Behavior**: UseLabel
- **Group**: Details
- **Label**: Service Tasks
- **Order**: 10000

**CascadeConfiguration**:

- **Assign**: Cascade
- **Delete**: Cascade
- **Merge**: NoCascade
- **Reparent**: Cascade
- **Share**: Cascade
- **Unshare**: Cascade


### <a name="BKMK_msdyn_msdyn_incidenttype_msdyn_quotebookingincident_IncidentType"></a> msdyn_msdyn_incidenttype_msdyn_quotebookingincident_IncidentType

Same as msdyn_quotebookingincident entity [msdyn_msdyn_incidenttype_msdyn_quotebookingincident_IncidentType](msdyn_quotebookingincident.md#BKMK_msdyn_msdyn_incidenttype_msdyn_quotebookingincident_IncidentType) Many-To-One relationship.

**ReferencingEntity**: msdyn_quotebookingincident<br />
**ReferencingAttribute**: msdyn_incidenttype<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_msdyn_incidenttype_msdyn_quotebookingincident_IncidentType<br />
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


### <a name="BKMK_msdyn_msdyn_incidenttype_msdyn_workorder_PrimaryIncidentType"></a> msdyn_msdyn_incidenttype_msdyn_workorder_PrimaryIncidentType

Same as msdyn_workorder entity [msdyn_msdyn_incidenttype_msdyn_workorder_PrimaryIncidentType](msdyn_workorder.md#BKMK_msdyn_msdyn_incidenttype_msdyn_workorder_PrimaryIncidentType) Many-To-One relationship.

**ReferencingEntity**: msdyn_workorder<br />
**ReferencingAttribute**: msdyn_primaryincidenttype<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_msdyn_incidenttype_msdyn_workorder_PrimaryIncidentType<br />
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


### <a name="BKMK_msdyn_msdyn_incidenttype_msdyn_workorderincident_IncidentType"></a> msdyn_msdyn_incidenttype_msdyn_workorderincident_IncidentType

Same as msdyn_workorderincident entity [msdyn_msdyn_incidenttype_msdyn_workorderincident_IncidentType](msdyn_workorderincident.md#BKMK_msdyn_msdyn_incidenttype_msdyn_workorderincident_IncidentType) Many-To-One relationship.

**ReferencingEntity**: msdyn_workorderincident<br />
**ReferencingAttribute**: msdyn_incidenttype<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_msdyn_incidenttype_msdyn_workorderincident_IncidentType<br />
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

- [lk_msdyn_incidenttype_createdby](#BKMK_lk_msdyn_incidenttype_createdby)
- [lk_msdyn_incidenttype_createdonbehalfby](#BKMK_lk_msdyn_incidenttype_createdonbehalfby)
- [lk_msdyn_incidenttype_modifiedby](#BKMK_lk_msdyn_incidenttype_modifiedby)
- [lk_msdyn_incidenttype_modifiedonbehalfby](#BKMK_lk_msdyn_incidenttype_modifiedonbehalfby)
- [user_msdyn_incidenttype](#BKMK_user_msdyn_incidenttype)
- [team_msdyn_incidenttype](#BKMK_team_msdyn_incidenttype)
- [business_unit_msdyn_incidenttype](#BKMK_business_unit_msdyn_incidenttype)
- [msdyn_msdyn_workordertype_msdyn_incidenttype_DefaultWorkOrderType](#BKMK_msdyn_msdyn_workordertype_msdyn_incidenttype_DefaultWorkOrderType)


### <a name="BKMK_lk_msdyn_incidenttype_createdby"></a> lk_msdyn_incidenttype_createdby

See systemuser Entity [lk_msdyn_incidenttype_createdby](systemuser.md#BKMK_lk_msdyn_incidenttype_createdby) One-To-Many relationship.

### <a name="BKMK_lk_msdyn_incidenttype_createdonbehalfby"></a> lk_msdyn_incidenttype_createdonbehalfby

See systemuser Entity [lk_msdyn_incidenttype_createdonbehalfby](systemuser.md#BKMK_lk_msdyn_incidenttype_createdonbehalfby) One-To-Many relationship.

### <a name="BKMK_lk_msdyn_incidenttype_modifiedby"></a> lk_msdyn_incidenttype_modifiedby

See systemuser Entity [lk_msdyn_incidenttype_modifiedby](systemuser.md#BKMK_lk_msdyn_incidenttype_modifiedby) One-To-Many relationship.

### <a name="BKMK_lk_msdyn_incidenttype_modifiedonbehalfby"></a> lk_msdyn_incidenttype_modifiedonbehalfby

See systemuser Entity [lk_msdyn_incidenttype_modifiedonbehalfby](systemuser.md#BKMK_lk_msdyn_incidenttype_modifiedonbehalfby) One-To-Many relationship.

### <a name="BKMK_user_msdyn_incidenttype"></a> user_msdyn_incidenttype

See systemuser Entity [user_msdyn_incidenttype](systemuser.md#BKMK_user_msdyn_incidenttype) One-To-Many relationship.

### <a name="BKMK_team_msdyn_incidenttype"></a> team_msdyn_incidenttype

See team Entity [team_msdyn_incidenttype](team.md#BKMK_team_msdyn_incidenttype) One-To-Many relationship.

### <a name="BKMK_business_unit_msdyn_incidenttype"></a> business_unit_msdyn_incidenttype

See businessunit Entity [business_unit_msdyn_incidenttype](businessunit.md#BKMK_business_unit_msdyn_incidenttype) One-To-Many relationship.

### <a name="BKMK_msdyn_msdyn_workordertype_msdyn_incidenttype_DefaultWorkOrderType"></a> msdyn_msdyn_workordertype_msdyn_incidenttype_DefaultWorkOrderType

See msdyn_workordertype Entity [msdyn_msdyn_workordertype_msdyn_incidenttype_DefaultWorkOrderType](msdyn_workordertype.md#BKMK_msdyn_msdyn_workordertype_msdyn_incidenttype_DefaultWorkOrderType) One-To-Many relationship.

## See also

[About the Entity Reference](../about-entity-reference.md)<br />
[Programming reference for Dynamics 365 Customer Engagement](../programming-reference.md)<br />
[Web API Reference](/dynamics365/customer-engagement/web-api/about)<br />
<xref href="Microsoft.Dynamics.CRM.msdyn_incidenttype?text=msdyn_incidenttype EntityType" />