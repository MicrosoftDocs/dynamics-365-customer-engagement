---
title: "msdyn_quotebookingincident Entity Reference (Developer Guide for Dynamics 365 Customer Engagement)| MicrosoftDocs"
description: "Includes schema information and supported messages for the msdyn_quotebookingincident entity."
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
# msdyn_quotebookingincident Entity Reference

[!INCLUDE[](../../includes/cc_applies_to_update_9_0_0.md)]

Stores the Incidents associated with Quote and Quote Booking Setup

**Added by**: Field Service Solution<br />

## Messages

|Message|Web API Operation|SDK Assembly|
|-|-|-|
|Assign|PATCH [*org URI*]/api/data/v9.0/msdyn_quotebookingincidents(*msdyn_quotebookingincidentid*)<br />[Update](../webapi/update-delete-entities-using-web-api.md#basic-update) `ownerid` property.|<xref:Microsoft.Crm.Sdk.Messages.AssignRequest>|
|Create|POST [*org URI*]/api/data/v9.0/msdyn_quotebookingincidents<br />See [Create](../webapi/create-entity-web-api.md)|<xref:Microsoft.Xrm.Sdk.Messages.CreateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Create*>|
|Delete|DELETE [*org URI*]/api/data/v9.0/msdyn_quotebookingincidents(*msdyn_quotebookingincidentid*)<br />See [Delete](../webapi/update-delete-entities-using-web-api.md#basic-delete)|<xref:Microsoft.Xrm.Sdk.Messages.DeleteRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Delete*>|
|GrantAccess|<xref href="Microsoft.Dynamics.CRM.GrantAccess?text=GrantAccess Action" />|<xref:Microsoft.Crm.Sdk.Messages.GrantAccessRequest>|
|IsValidStateTransition|<xref href="Microsoft.Dynamics.CRM.IsValidStateTransition?text=IsValidStateTransition Function" />|<xref:Microsoft.Crm.Sdk.Messages.IsValidStateTransitionRequest>|
|ModifyAccess|<xref href="Microsoft.Dynamics.CRM.ModifyAccess?text=ModifyAccess Action" />|<xref:Microsoft.Crm.Sdk.Messages.ModifyAccessRequest>|
|Retrieve|GET [*org URI*]/api/data/v9.0/msdyn_quotebookingincidents(*msdyn_quotebookingincidentid*)<br />See [Retrieve](../webapi/retrieve-entity-using-web-api.md)|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Retrieve*>|
|RetrieveMultiple|GET [*org URI*]/api/data/v9.0/msdyn_quotebookingincidents<br />See [Query Data](../webapi/query-data-web-api.md)|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveMultipleRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.RetrieveMultiple*>|
|RetrievePrincipalAccess|<xref href="Microsoft.Dynamics.CRM.RetrievePrincipalAccess?text=RetrievePrincipalAccess Function" />|<xref:Microsoft.Crm.Sdk.Messages.RetrievePrincipalAccessRequest>|
|RetrieveSharedPrincipalsAndAccess|<xref href="Microsoft.Dynamics.CRM.RetrieveSharedPrincipalsAndAccess?text=RetrieveSharedPrincipalsAndAccess Function" />|<xref:Microsoft.Crm.Sdk.Messages.RetrieveSharedPrincipalsAndAccessRequest>|
|RevokeAccess|<xref href="Microsoft.Dynamics.CRM.RevokeAccess?text=RevokeAccess Action" />|<xref:Microsoft.Crm.Sdk.Messages.RevokeAccessRequest>|
|SetState|PATCH [*org URI*]/api/data/v9.0/msdyn_quotebookingincidents(*msdyn_quotebookingincidentid*)<br />[Update](../webapi/update-delete-entities-using-web-api.md#basic-update) `statecode` and `statuscode` properties.|<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|
|Update|PATCH [*org URI*]/api/data/v9.0/msdyn_quotebookingincidents(*msdyn_quotebookingincidentid*)<br />See [Update](../webapi/update-delete-entities-using-web-api.md#basic-update)|<xref:Microsoft.Xrm.Sdk.Messages.UpdateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Update*>|

## Entity Properties

**DisplayName**: Quote Booking Incident<br />
**DisplayCollectionName**: Quote Booking Incidents<br />
**SchemaName**: msdyn_quotebookingincident<br />
**CollectionSchemaName**: msdyn_quotebookingincidents<br />
**LogicalName**: msdyn_quotebookingincident<br />
**LogicalCollectionName**: msdyn_quotebookingincidents<br />
**EntitySetName**: msdyn_quotebookingincidents<br />
**PrimaryIdAttribute**: msdyn_quotebookingincidentid<br />
**PrimaryNameAttribute**: msdyn_name<br />
**OwnershipType**: UserOwned<br />
**IsBPFEntity**: False<br />
<a name="writable-attributes"></a>

## Writable attributes

These attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [msdyn_customerasset](#BKMK_msdyn_customerasset)
- [msdyn_description](#BKMK_msdyn_description)
- [msdyn_estimatedduration](#BKMK_msdyn_estimatedduration)
- [msdyn_incidentitemscopied](#BKMK_msdyn_incidentitemscopied)
- [msdyn_incidenttype](#BKMK_msdyn_incidenttype)
- [msdyn_internalflags](#BKMK_msdyn_internalflags)
- [msdyn_name](#BKMK_msdyn_name)
- [msdyn_Quote](#BKMK_msdyn_Quote)
- [msdyn_quotebookingincidentId](#BKMK_msdyn_quotebookingincidentId)
- [msdyn_quotebookingsetup](#BKMK_msdyn_quotebookingsetup)
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


### <a name="BKMK_msdyn_customerasset"></a> msdyn_customerasset

**Description**: Customer Asset related to this incident reported<br />
**DisplayName**: Customer Asset<br />
**LogicalName**: msdyn_customerasset<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: msdyn_customerasset


### <a name="BKMK_msdyn_description"></a> msdyn_description

**Description**: Enter the description of the incident<br />
**DisplayName**: Description<br />
**LogicalName**: msdyn_description<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Memo<br />
**Format**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 8000


### <a name="BKMK_msdyn_estimatedduration"></a> msdyn_estimatedduration

**Description**: Shows the time estimated to resolve this incident.<br />
**DisplayName**: Estimated Duration<br />
**LogicalName**: msdyn_estimatedduration<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Integer<br />
**Format**: Duration<br />
**MaxValue**: 2147483647<br />
**MinValue**: 0


### <a name="BKMK_msdyn_incidentitemscopied"></a> msdyn_incidentitemscopied

**Description**: If "yes", copied  service task, products, and services that are associated with the incident to quote booking setup<br />
**DisplayName**: Incident Items Copied<br />
**LogicalName**: msdyn_incidentitemscopied<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Boolean<br />
**Options**:

- **TrueOption Value**: 1 **Label**: Yes
- **FalseOption Value**: 0 **Label**: No

**DefaultValue**: False


### <a name="BKMK_msdyn_incidenttype"></a> msdyn_incidenttype

**Description**: Shows the incident type associated with the quote booking incident.<br />
**DisplayName**: Incident Type<br />
**LogicalName**: msdyn_incidenttype<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: ApplicationRequired<br />
**Type**: Lookup<br />
**Targets**: msdyn_incidenttype


### <a name="BKMK_msdyn_internalflags"></a> msdyn_internalflags

**Description**: Internal use only<br />
**DisplayName**: Internal Flags<br />
**LogicalName**: msdyn_internalflags<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Memo<br />
**Format**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 1048576


### <a name="BKMK_msdyn_name"></a> msdyn_name

**Description**: Displays name of the quote booking incident<br />
**DisplayName**: Name<br />
**LogicalName**: msdyn_name<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_msdyn_Quote"></a> msdyn_Quote

**Description**: Shows the quote associated with the agreement booking incident.<br />
**DisplayName**: Quote<br />
**LogicalName**: msdyn_quote<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: ApplicationRequired<br />
**Type**: Lookup<br />
**Targets**: quote


### <a name="BKMK_msdyn_quotebookingincidentId"></a> msdyn_quotebookingincidentId

**Description**: Unique identifier for entity instances<br />
**DisplayName**: Quote Booking Incident<br />
**LogicalName**: msdyn_quotebookingincidentid<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: SystemRequired<br />
**IsValidForUpdate**: False<br />
**Type**: Uniqueidentifier<br />


### <a name="BKMK_msdyn_quotebookingsetup"></a> msdyn_quotebookingsetup

**Description**: Shows the quote booking setup associated with the quote booking incident.<br />
**DisplayName**: Quote Booking Setup<br />
**LogicalName**: msdyn_quotebookingsetup<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: ApplicationRequired<br />
**Type**: Lookup<br />
**Targets**: msdyn_quotebookingsetup


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

**Description**: Status of the Quote Booking Incident<br />
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

**Description**: Reason for the status of the Quote Booking Incident<br />
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
- [msdyn_customerassetName](#BKMK_msdyn_customerassetName)
- [msdyn_incidenttypeName](#BKMK_msdyn_incidenttypeName)
- [msdyn_quotebookingsetupName](#BKMK_msdyn_quotebookingsetupName)
- [msdyn_QuoteName](#BKMK_msdyn_QuoteName)
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


### <a name="BKMK_msdyn_customerassetName"></a> msdyn_customerassetName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: msdyn_customerassetname<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_msdyn_incidenttypeName"></a> msdyn_incidenttypeName

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


### <a name="BKMK_msdyn_quotebookingsetupName"></a> msdyn_quotebookingsetupName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: msdyn_quotebookingsetupname<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_msdyn_QuoteName"></a> msdyn_QuoteName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: msdyn_quotename<br />
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

- [msdyn_quotebookingincident_ActivityPointers](#BKMK_msdyn_quotebookingincident_ActivityPointers)
- [msdyn_quotebookingincident_msdyn_approvals](#BKMK_msdyn_quotebookingincident_msdyn_approvals)
- [msdyn_quotebookingincident_msdyn_bookingalerts](#BKMK_msdyn_quotebookingincident_msdyn_bookingalerts)
- [msdyn_quotebookingincident_SyncErrors](#BKMK_msdyn_quotebookingincident_SyncErrors)
- [msdyn_quotebookingincident_DuplicateMatchingRecord](#BKMK_msdyn_quotebookingincident_DuplicateMatchingRecord)
- [msdyn_quotebookingincident_DuplicateBaseRecord](#BKMK_msdyn_quotebookingincident_DuplicateBaseRecord)
- [msdyn_quotebookingincident_AsyncOperations](#BKMK_msdyn_quotebookingincident_AsyncOperations)
- [msdyn_quotebookingincident_MailboxTrackingFolders](#BKMK_msdyn_quotebookingincident_MailboxTrackingFolders)
- [msdyn_quotebookingincident_UserEntityInstanceDatas](#BKMK_msdyn_quotebookingincident_UserEntityInstanceDatas)
- [msdyn_quotebookingincident_ProcessSession](#BKMK_msdyn_quotebookingincident_ProcessSession)
- [msdyn_quotebookingincident_BulkDeleteFailures](#BKMK_msdyn_quotebookingincident_BulkDeleteFailures)
- [msdyn_quotebookingincident_PrincipalObjectAttributeAccesses](#BKMK_msdyn_quotebookingincident_PrincipalObjectAttributeAccesses)
- [msdyn_quotebookingincident_Appointments](#BKMK_msdyn_quotebookingincident_Appointments)
- [msdyn_quotebookingincident_Emails](#BKMK_msdyn_quotebookingincident_Emails)
- [msdyn_quotebookingincident_Faxes](#BKMK_msdyn_quotebookingincident_Faxes)
- [msdyn_quotebookingincident_Letters](#BKMK_msdyn_quotebookingincident_Letters)
- [msdyn_quotebookingincident_PhoneCalls](#BKMK_msdyn_quotebookingincident_PhoneCalls)
- [msdyn_quotebookingincident_Tasks](#BKMK_msdyn_quotebookingincident_Tasks)
- [msdyn_quotebookingincident_RecurringAppointmentMasters](#BKMK_msdyn_quotebookingincident_RecurringAppointmentMasters)
- [msdyn_quotebookingincident_SocialActivities](#BKMK_msdyn_quotebookingincident_SocialActivities)
- [msdyn_quotebookingincident_connections1](#BKMK_msdyn_quotebookingincident_connections1)
- [msdyn_quotebookingincident_connections2](#BKMK_msdyn_quotebookingincident_connections2)
- [msdyn_quotebookingincident_Annotations](#BKMK_msdyn_quotebookingincident_Annotations)
- [msdyn_quotebookingincident_ServiceAppointments](#BKMK_msdyn_quotebookingincident_ServiceAppointments)
- [msdyn_msdyn_quotebookingincident_msdyn_quotebookingproduct_QuoteBookingIncident](#BKMK_msdyn_msdyn_quotebookingincident_msdyn_quotebookingproduct_QuoteBookingIncident)
- [msdyn_msdyn_quotebookingincident_msdyn_quotebookingservice_QuoteBookingIncident](#BKMK_msdyn_msdyn_quotebookingincident_msdyn_quotebookingservice_QuoteBookingIncident)
- [msdyn_msdyn_quotebookingincident_msdyn_quotebookingservicetask_QuoteBookingIncident](#BKMK_msdyn_msdyn_quotebookingincident_msdyn_quotebookingservicetask_QuoteBookingIncident)


### <a name="BKMK_msdyn_quotebookingincident_ActivityPointers"></a> msdyn_quotebookingincident_ActivityPointers

Same as activitypointer entity [msdyn_quotebookingincident_ActivityPointers](activitypointer.md#BKMK_msdyn_quotebookingincident_ActivityPointers) Many-To-One relationship.

**ReferencingEntity**: activitypointer<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_quotebookingincident_ActivityPointers<br />
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


### <a name="BKMK_msdyn_quotebookingincident_msdyn_approvals"></a> msdyn_quotebookingincident_msdyn_approvals

Same as msdyn_approval entity [msdyn_quotebookingincident_msdyn_approvals](msdyn_approval.md#BKMK_msdyn_quotebookingincident_msdyn_approvals) Many-To-One relationship.

**ReferencingEntity**: msdyn_approval<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_quotebookingincident_msdyn_approvals<br />
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


### <a name="BKMK_msdyn_quotebookingincident_msdyn_bookingalerts"></a> msdyn_quotebookingincident_msdyn_bookingalerts

Same as msdyn_bookingalert entity [msdyn_quotebookingincident_msdyn_bookingalerts](msdyn_bookingalert.md#BKMK_msdyn_quotebookingincident_msdyn_bookingalerts) Many-To-One relationship.

**ReferencingEntity**: msdyn_bookingalert<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_quotebookingincident_msdyn_bookingalerts<br />
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


### <a name="BKMK_msdyn_quotebookingincident_SyncErrors"></a> msdyn_quotebookingincident_SyncErrors

Same as syncerror entity [msdyn_quotebookingincident_SyncErrors](syncerror.md#BKMK_msdyn_quotebookingincident_SyncErrors) Many-To-One relationship.

**ReferencingEntity**: syncerror<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_quotebookingincident_SyncErrors<br />
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


### <a name="BKMK_msdyn_quotebookingincident_DuplicateMatchingRecord"></a> msdyn_quotebookingincident_DuplicateMatchingRecord

Same as duplicaterecord entity [msdyn_quotebookingincident_DuplicateMatchingRecord](duplicaterecord.md#BKMK_msdyn_quotebookingincident_DuplicateMatchingRecord) Many-To-One relationship.

**ReferencingEntity**: duplicaterecord<br />
**ReferencingAttribute**: duplicaterecordid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_quotebookingincident_DuplicateMatchingRecord<br />
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


### <a name="BKMK_msdyn_quotebookingincident_DuplicateBaseRecord"></a> msdyn_quotebookingincident_DuplicateBaseRecord

Same as duplicaterecord entity [msdyn_quotebookingincident_DuplicateBaseRecord](duplicaterecord.md#BKMK_msdyn_quotebookingincident_DuplicateBaseRecord) Many-To-One relationship.

**ReferencingEntity**: duplicaterecord<br />
**ReferencingAttribute**: baserecordid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_quotebookingincident_DuplicateBaseRecord<br />
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


### <a name="BKMK_msdyn_quotebookingincident_AsyncOperations"></a> msdyn_quotebookingincident_AsyncOperations

Same as asyncoperation entity [msdyn_quotebookingincident_AsyncOperations](asyncoperation.md#BKMK_msdyn_quotebookingincident_AsyncOperations) Many-To-One relationship.

**ReferencingEntity**: asyncoperation<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_quotebookingincident_AsyncOperations<br />
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


### <a name="BKMK_msdyn_quotebookingincident_MailboxTrackingFolders"></a> msdyn_quotebookingincident_MailboxTrackingFolders

Same as mailboxtrackingfolder entity [msdyn_quotebookingincident_MailboxTrackingFolders](mailboxtrackingfolder.md#BKMK_msdyn_quotebookingincident_MailboxTrackingFolders) Many-To-One relationship.

**ReferencingEntity**: mailboxtrackingfolder<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_quotebookingincident_MailboxTrackingFolders<br />
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


### <a name="BKMK_msdyn_quotebookingincident_UserEntityInstanceDatas"></a> msdyn_quotebookingincident_UserEntityInstanceDatas

Same as userentityinstancedata entity [msdyn_quotebookingincident_UserEntityInstanceDatas](userentityinstancedata.md#BKMK_msdyn_quotebookingincident_UserEntityInstanceDatas) Many-To-One relationship.

**ReferencingEntity**: userentityinstancedata<br />
**ReferencingAttribute**: objectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_quotebookingincident_UserEntityInstanceDatas<br />
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


### <a name="BKMK_msdyn_quotebookingincident_ProcessSession"></a> msdyn_quotebookingincident_ProcessSession

Same as processsession entity [msdyn_quotebookingincident_ProcessSession](processsession.md#BKMK_msdyn_quotebookingincident_ProcessSession) Many-To-One relationship.

**ReferencingEntity**: processsession<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_quotebookingincident_ProcessSession<br />
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


### <a name="BKMK_msdyn_quotebookingincident_BulkDeleteFailures"></a> msdyn_quotebookingincident_BulkDeleteFailures

Same as bulkdeletefailure entity [msdyn_quotebookingincident_BulkDeleteFailures](bulkdeletefailure.md#BKMK_msdyn_quotebookingincident_BulkDeleteFailures) Many-To-One relationship.

**ReferencingEntity**: bulkdeletefailure<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_quotebookingincident_BulkDeleteFailures<br />
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


### <a name="BKMK_msdyn_quotebookingincident_PrincipalObjectAttributeAccesses"></a> msdyn_quotebookingincident_PrincipalObjectAttributeAccesses

Same as principalobjectattributeaccess entity [msdyn_quotebookingincident_PrincipalObjectAttributeAccesses](principalobjectattributeaccess.md#BKMK_msdyn_quotebookingincident_PrincipalObjectAttributeAccesses) Many-To-One relationship.

**ReferencingEntity**: principalobjectattributeaccess<br />
**ReferencingAttribute**: objectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_quotebookingincident_PrincipalObjectAttributeAccesses<br />
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


### <a name="BKMK_msdyn_quotebookingincident_Appointments"></a> msdyn_quotebookingincident_Appointments

Same as appointment entity [msdyn_quotebookingincident_Appointments](appointment.md#BKMK_msdyn_quotebookingincident_Appointments) Many-To-One relationship.

**ReferencingEntity**: appointment<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_quotebookingincident_Appointments<br />
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


### <a name="BKMK_msdyn_quotebookingincident_Emails"></a> msdyn_quotebookingincident_Emails

Same as email entity [msdyn_quotebookingincident_Emails](email.md#BKMK_msdyn_quotebookingincident_Emails) Many-To-One relationship.

**ReferencingEntity**: email<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_quotebookingincident_Emails<br />
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


### <a name="BKMK_msdyn_quotebookingincident_Faxes"></a> msdyn_quotebookingincident_Faxes

Same as fax entity [msdyn_quotebookingincident_Faxes](fax.md#BKMK_msdyn_quotebookingincident_Faxes) Many-To-One relationship.

**ReferencingEntity**: fax<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_quotebookingincident_Faxes<br />
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


### <a name="BKMK_msdyn_quotebookingincident_Letters"></a> msdyn_quotebookingincident_Letters

Same as letter entity [msdyn_quotebookingincident_Letters](letter.md#BKMK_msdyn_quotebookingincident_Letters) Many-To-One relationship.

**ReferencingEntity**: letter<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_quotebookingincident_Letters<br />
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


### <a name="BKMK_msdyn_quotebookingincident_PhoneCalls"></a> msdyn_quotebookingincident_PhoneCalls

Same as phonecall entity [msdyn_quotebookingincident_PhoneCalls](phonecall.md#BKMK_msdyn_quotebookingincident_PhoneCalls) Many-To-One relationship.

**ReferencingEntity**: phonecall<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_quotebookingincident_PhoneCalls<br />
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


### <a name="BKMK_msdyn_quotebookingincident_Tasks"></a> msdyn_quotebookingincident_Tasks

Same as task entity [msdyn_quotebookingincident_Tasks](task.md#BKMK_msdyn_quotebookingincident_Tasks) Many-To-One relationship.

**ReferencingEntity**: task<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_quotebookingincident_Tasks<br />
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


### <a name="BKMK_msdyn_quotebookingincident_RecurringAppointmentMasters"></a> msdyn_quotebookingincident_RecurringAppointmentMasters

Same as recurringappointmentmaster entity [msdyn_quotebookingincident_RecurringAppointmentMasters](recurringappointmentmaster.md#BKMK_msdyn_quotebookingincident_RecurringAppointmentMasters) Many-To-One relationship.

**ReferencingEntity**: recurringappointmentmaster<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_quotebookingincident_RecurringAppointmentMasters<br />
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


### <a name="BKMK_msdyn_quotebookingincident_SocialActivities"></a> msdyn_quotebookingincident_SocialActivities

Same as socialactivity entity [msdyn_quotebookingincident_SocialActivities](socialactivity.md#BKMK_msdyn_quotebookingincident_SocialActivities) Many-To-One relationship.

**ReferencingEntity**: socialactivity<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_quotebookingincident_SocialActivities<br />
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


### <a name="BKMK_msdyn_quotebookingincident_connections1"></a> msdyn_quotebookingincident_connections1

Same as connection entity [msdyn_quotebookingincident_connections1](connection.md#BKMK_msdyn_quotebookingincident_connections1) Many-To-One relationship.

**ReferencingEntity**: connection<br />
**ReferencingAttribute**: record1id<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_quotebookingincident_connections1<br />
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


### <a name="BKMK_msdyn_quotebookingincident_connections2"></a> msdyn_quotebookingincident_connections2

Same as connection entity [msdyn_quotebookingincident_connections2](connection.md#BKMK_msdyn_quotebookingincident_connections2) Many-To-One relationship.

**ReferencingEntity**: connection<br />
**ReferencingAttribute**: record2id<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_quotebookingincident_connections2<br />
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


### <a name="BKMK_msdyn_quotebookingincident_Annotations"></a> msdyn_quotebookingincident_Annotations

Same as annotation entity [msdyn_quotebookingincident_Annotations](annotation.md#BKMK_msdyn_quotebookingincident_Annotations) Many-To-One relationship.

**ReferencingEntity**: annotation<br />
**ReferencingAttribute**: objectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_quotebookingincident_Annotations<br />
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


### <a name="BKMK_msdyn_quotebookingincident_ServiceAppointments"></a> msdyn_quotebookingincident_ServiceAppointments

Same as serviceappointment entity [msdyn_quotebookingincident_ServiceAppointments](serviceappointment.md#BKMK_msdyn_quotebookingincident_ServiceAppointments) Many-To-One relationship.

**ReferencingEntity**: serviceappointment<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_quotebookingincident_ServiceAppointments<br />
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


### <a name="BKMK_msdyn_msdyn_quotebookingincident_msdyn_quotebookingproduct_QuoteBookingIncident"></a> msdyn_msdyn_quotebookingincident_msdyn_quotebookingproduct_QuoteBookingIncident

Same as msdyn_quotebookingproduct entity [msdyn_msdyn_quotebookingincident_msdyn_quotebookingproduct_QuoteBookingIncident](msdyn_quotebookingproduct.md#BKMK_msdyn_msdyn_quotebookingincident_msdyn_quotebookingproduct_QuoteBookingIncident) Many-To-One relationship.

**ReferencingEntity**: msdyn_quotebookingproduct<br />
**ReferencingAttribute**: msdyn_quotebookingincident<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_msdyn_quotebookingincident_msdyn_quotebookingproduct_QuoteBookingIncident<br />
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


### <a name="BKMK_msdyn_msdyn_quotebookingincident_msdyn_quotebookingservice_QuoteBookingIncident"></a> msdyn_msdyn_quotebookingincident_msdyn_quotebookingservice_QuoteBookingIncident

Same as msdyn_quotebookingservice entity [msdyn_msdyn_quotebookingincident_msdyn_quotebookingservice_QuoteBookingIncident](msdyn_quotebookingservice.md#BKMK_msdyn_msdyn_quotebookingincident_msdyn_quotebookingservice_QuoteBookingIncident) Many-To-One relationship.

**ReferencingEntity**: msdyn_quotebookingservice<br />
**ReferencingAttribute**: msdyn_quotebookingincident<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_msdyn_quotebookingincident_msdyn_quotebookingservice_QuoteBookingIncident<br />
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


### <a name="BKMK_msdyn_msdyn_quotebookingincident_msdyn_quotebookingservicetask_QuoteBookingIncident"></a> msdyn_msdyn_quotebookingincident_msdyn_quotebookingservicetask_QuoteBookingIncident

Same as msdyn_quotebookingservicetask entity [msdyn_msdyn_quotebookingincident_msdyn_quotebookingservicetask_QuoteBookingIncident](msdyn_quotebookingservicetask.md#BKMK_msdyn_msdyn_quotebookingincident_msdyn_quotebookingservicetask_QuoteBookingIncident) Many-To-One relationship.

**ReferencingEntity**: msdyn_quotebookingservicetask<br />
**ReferencingAttribute**: msdyn_quotebookingincident<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_msdyn_quotebookingincident_msdyn_quotebookingservicetask_QuoteBookingIncident<br />
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

<a name="manytoone"></a>

## Many-To-One Relationships

Each Many-To-One relationship is defined by a corresponding One-To-Many relationship with the related entity. Listed by **SchemaName**.

- [lk_msdyn_quotebookingincident_createdby](#BKMK_lk_msdyn_quotebookingincident_createdby)
- [lk_msdyn_quotebookingincident_createdonbehalfby](#BKMK_lk_msdyn_quotebookingincident_createdonbehalfby)
- [lk_msdyn_quotebookingincident_modifiedby](#BKMK_lk_msdyn_quotebookingincident_modifiedby)
- [lk_msdyn_quotebookingincident_modifiedonbehalfby](#BKMK_lk_msdyn_quotebookingincident_modifiedonbehalfby)
- [user_msdyn_quotebookingincident](#BKMK_user_msdyn_quotebookingincident)
- [team_msdyn_quotebookingincident](#BKMK_team_msdyn_quotebookingincident)
- [business_unit_msdyn_quotebookingincident](#BKMK_business_unit_msdyn_quotebookingincident)
- [msdyn_msdyn_customerasset_msdyn_quotebookingincident_CustomerAsset](#BKMK_msdyn_msdyn_customerasset_msdyn_quotebookingincident_CustomerAsset)
- [msdyn_msdyn_incidenttype_msdyn_quotebookingincident_IncidentType](#BKMK_msdyn_msdyn_incidenttype_msdyn_quotebookingincident_IncidentType)
- [msdyn_msdyn_quotebookingsetup_msdyn_quotebookingincident_QuoteBookingSetup](#BKMK_msdyn_msdyn_quotebookingsetup_msdyn_quotebookingincident_QuoteBookingSetup)
- [msdyn_quote_msdyn_quotebookingincident_Quote](#BKMK_msdyn_quote_msdyn_quotebookingincident_Quote)


### <a name="BKMK_lk_msdyn_quotebookingincident_createdby"></a> lk_msdyn_quotebookingincident_createdby

See systemuser Entity [lk_msdyn_quotebookingincident_createdby](systemuser.md#BKMK_lk_msdyn_quotebookingincident_createdby) One-To-Many relationship.

### <a name="BKMK_lk_msdyn_quotebookingincident_createdonbehalfby"></a> lk_msdyn_quotebookingincident_createdonbehalfby

See systemuser Entity [lk_msdyn_quotebookingincident_createdonbehalfby](systemuser.md#BKMK_lk_msdyn_quotebookingincident_createdonbehalfby) One-To-Many relationship.

### <a name="BKMK_lk_msdyn_quotebookingincident_modifiedby"></a> lk_msdyn_quotebookingincident_modifiedby

See systemuser Entity [lk_msdyn_quotebookingincident_modifiedby](systemuser.md#BKMK_lk_msdyn_quotebookingincident_modifiedby) One-To-Many relationship.

### <a name="BKMK_lk_msdyn_quotebookingincident_modifiedonbehalfby"></a> lk_msdyn_quotebookingincident_modifiedonbehalfby

See systemuser Entity [lk_msdyn_quotebookingincident_modifiedonbehalfby](systemuser.md#BKMK_lk_msdyn_quotebookingincident_modifiedonbehalfby) One-To-Many relationship.

### <a name="BKMK_user_msdyn_quotebookingincident"></a> user_msdyn_quotebookingincident

See systemuser Entity [user_msdyn_quotebookingincident](systemuser.md#BKMK_user_msdyn_quotebookingincident) One-To-Many relationship.

### <a name="BKMK_team_msdyn_quotebookingincident"></a> team_msdyn_quotebookingincident

See team Entity [team_msdyn_quotebookingincident](team.md#BKMK_team_msdyn_quotebookingincident) One-To-Many relationship.

### <a name="BKMK_business_unit_msdyn_quotebookingincident"></a> business_unit_msdyn_quotebookingincident

See businessunit Entity [business_unit_msdyn_quotebookingincident](businessunit.md#BKMK_business_unit_msdyn_quotebookingincident) One-To-Many relationship.

### <a name="BKMK_msdyn_msdyn_customerasset_msdyn_quotebookingincident_CustomerAsset"></a> msdyn_msdyn_customerasset_msdyn_quotebookingincident_CustomerAsset

See msdyn_customerasset Entity [msdyn_msdyn_customerasset_msdyn_quotebookingincident_CustomerAsset](msdyn_customerasset.md#BKMK_msdyn_msdyn_customerasset_msdyn_quotebookingincident_CustomerAsset) One-To-Many relationship.

### <a name="BKMK_msdyn_msdyn_incidenttype_msdyn_quotebookingincident_IncidentType"></a> msdyn_msdyn_incidenttype_msdyn_quotebookingincident_IncidentType

See msdyn_incidenttype Entity [msdyn_msdyn_incidenttype_msdyn_quotebookingincident_IncidentType](msdyn_incidenttype.md#BKMK_msdyn_msdyn_incidenttype_msdyn_quotebookingincident_IncidentType) One-To-Many relationship.

### <a name="BKMK_msdyn_msdyn_quotebookingsetup_msdyn_quotebookingincident_QuoteBookingSetup"></a> msdyn_msdyn_quotebookingsetup_msdyn_quotebookingincident_QuoteBookingSetup

See msdyn_quotebookingsetup Entity [msdyn_msdyn_quotebookingsetup_msdyn_quotebookingincident_QuoteBookingSetup](msdyn_quotebookingsetup.md#BKMK_msdyn_msdyn_quotebookingsetup_msdyn_quotebookingincident_QuoteBookingSetup) One-To-Many relationship.

### <a name="BKMK_msdyn_quote_msdyn_quotebookingincident_Quote"></a> msdyn_quote_msdyn_quotebookingincident_Quote

See quote Entity [msdyn_quote_msdyn_quotebookingincident_Quote](quote.md#BKMK_msdyn_quote_msdyn_quotebookingincident_Quote) One-To-Many relationship.

## See also

[About the Entity Reference](../about-entity-reference.md)<br />
[Programming reference for Dynamics 365 Customer Engagement](../programming-reference.md)<br />
[Web API Reference](/dynamics365/customer-engagement/web-api/about)<br />
<xref href="Microsoft.Dynamics.CRM.msdyn_quotebookingincident?text=msdyn_quotebookingincident EntityType" />