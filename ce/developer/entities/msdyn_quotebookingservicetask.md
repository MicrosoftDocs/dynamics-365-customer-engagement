---
title: "msdyn_quotebookingservicetask Entity Reference (Developer Guide for Dynamics 365 Customer Engagement)| MicrosoftDocs"
description: "Includes schema information and supported messages for the msdyn_quotebookingservicetask entity."
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
# msdyn_quotebookingservicetask Entity Reference

[!INCLUDE[](../../includes/cc_applies_to_update_9_0_0.md)]

**Added by**: Field Service Solution<br />

## Messages

|Message|Web API Operation|SDK Assembly|
|-|-|-|
|Assign|PATCH [*org URI*]/api/data/v9.0/msdyn_quotebookingservicetasks(*msdyn_quotebookingservicetaskid*)<br />[Update](../webapi/update-delete-entities-using-web-api.md#basic-update) `ownerid` property.|<xref:Microsoft.Crm.Sdk.Messages.AssignRequest>|
|Create|POST [*org URI*]/api/data/v9.0/msdyn_quotebookingservicetasks<br />See [Create](../webapi/create-entity-web-api.md)|<xref:Microsoft.Xrm.Sdk.Messages.CreateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Create*>|
|Delete|DELETE [*org URI*]/api/data/v9.0/msdyn_quotebookingservicetasks(*msdyn_quotebookingservicetaskid*)<br />See [Delete](../webapi/update-delete-entities-using-web-api.md#basic-delete)|<xref:Microsoft.Xrm.Sdk.Messages.DeleteRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Delete*>|
|GrantAccess|<xref href="Microsoft.Dynamics.CRM.GrantAccess?text=GrantAccess Action" />|<xref:Microsoft.Crm.Sdk.Messages.GrantAccessRequest>|
|IsValidStateTransition|<xref href="Microsoft.Dynamics.CRM.IsValidStateTransition?text=IsValidStateTransition Function" />|<xref:Microsoft.Crm.Sdk.Messages.IsValidStateTransitionRequest>|
|ModifyAccess|<xref href="Microsoft.Dynamics.CRM.ModifyAccess?text=ModifyAccess Action" />|<xref:Microsoft.Crm.Sdk.Messages.ModifyAccessRequest>|
|Retrieve|GET [*org URI*]/api/data/v9.0/msdyn_quotebookingservicetasks(*msdyn_quotebookingservicetaskid*)<br />See [Retrieve](../webapi/retrieve-entity-using-web-api.md)|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Retrieve*>|
|RetrieveMultiple|GET [*org URI*]/api/data/v9.0/msdyn_quotebookingservicetasks<br />See [Query Data](../webapi/query-data-web-api.md)|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveMultipleRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.RetrieveMultiple*>|
|RetrievePrincipalAccess|<xref href="Microsoft.Dynamics.CRM.RetrievePrincipalAccess?text=RetrievePrincipalAccess Function" />|<xref:Microsoft.Crm.Sdk.Messages.RetrievePrincipalAccessRequest>|
|RetrieveSharedPrincipalsAndAccess|<xref href="Microsoft.Dynamics.CRM.RetrieveSharedPrincipalsAndAccess?text=RetrieveSharedPrincipalsAndAccess Function" />|<xref:Microsoft.Crm.Sdk.Messages.RetrieveSharedPrincipalsAndAccessRequest>|
|RevokeAccess|<xref href="Microsoft.Dynamics.CRM.RevokeAccess?text=RevokeAccess Action" />|<xref:Microsoft.Crm.Sdk.Messages.RevokeAccessRequest>|
|SetState|PATCH [*org URI*]/api/data/v9.0/msdyn_quotebookingservicetasks(*msdyn_quotebookingservicetaskid*)<br />[Update](../webapi/update-delete-entities-using-web-api.md#basic-update) `statecode` and `statuscode` properties.|<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|
|Update|PATCH [*org URI*]/api/data/v9.0/msdyn_quotebookingservicetasks(*msdyn_quotebookingservicetaskid*)<br />See [Update](../webapi/update-delete-entities-using-web-api.md#basic-update)|<xref:Microsoft.Xrm.Sdk.Messages.UpdateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Update*>|

## Entity Properties

**DisplayName**: Quote Booking Service Task<br />
**DisplayCollectionName**: Quote Booking Service Tasks<br />
**SchemaName**: msdyn_quotebookingservicetask<br />
**CollectionSchemaName**: msdyn_quotebookingservicetasks<br />
**LogicalName**: msdyn_quotebookingservicetask<br />
**LogicalCollectionName**: msdyn_quotebookingservicetasks<br />
**EntitySetName**: msdyn_quotebookingservicetasks<br />
**PrimaryIdAttribute**: msdyn_quotebookingservicetaskid<br />
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
- [msdyn_internalflags](#BKMK_msdyn_internalflags)
- [msdyn_iscopied](#BKMK_msdyn_iscopied)
- [msdyn_lineorder](#BKMK_msdyn_lineorder)
- [msdyn_name](#BKMK_msdyn_name)
- [msdyn_quote](#BKMK_msdyn_quote)
- [msdyn_quotebookingincident](#BKMK_msdyn_quotebookingincident)
- [msdyn_quotebookingservicetaskId](#BKMK_msdyn_quotebookingservicetaskId)
- [msdyn_QuoteBookingSetup](#BKMK_msdyn_QuoteBookingSetup)
- [msdyn_TaskType](#BKMK_msdyn_TaskType)
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

**Description**: Unique identifier for Customer Asset associated with Quote Booking Service Task.<br />
**DisplayName**: Customer Asset<br />
**LogicalName**: msdyn_customerasset<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: msdyn_customerasset


### <a name="BKMK_msdyn_description"></a> msdyn_description

**Description**: Type a description of this quote booking service task.<br />
**DisplayName**: Description<br />
**LogicalName**: msdyn_description<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Memo<br />
**Format**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 2000


### <a name="BKMK_msdyn_estimatedduration"></a> msdyn_estimatedduration

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


### <a name="BKMK_msdyn_iscopied"></a> msdyn_iscopied

**Description**: <br />
**DisplayName**: Is Copied<br />
**LogicalName**: msdyn_iscopied<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Boolean<br />
**Options**:

- **TrueOption Value**: 1 **Label**: Yes
- **FalseOption Value**: 0 **Label**: No

**DefaultValue**: False


### <a name="BKMK_msdyn_lineorder"></a> msdyn_lineorder

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


### <a name="BKMK_msdyn_quote"></a> msdyn_quote

**Description**: Unique identifier for Quote associated with Quote Booking Service Task.<br />
**DisplayName**: Quote<br />
**LogicalName**: msdyn_quote<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: ApplicationRequired<br />
**Type**: Lookup<br />
**Targets**: quote


### <a name="BKMK_msdyn_quotebookingincident"></a> msdyn_quotebookingincident

**Description**: Shows the quote booking incident associated with the quote booking service task.<br />
**DisplayName**: Quote Booking Incident<br />
**LogicalName**: msdyn_quotebookingincident<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: msdyn_quotebookingincident


### <a name="BKMK_msdyn_quotebookingservicetaskId"></a> msdyn_quotebookingservicetaskId

**Description**: Unique identifier for entity instances<br />
**DisplayName**: Quote Booking Service Task<br />
**LogicalName**: msdyn_quotebookingservicetaskid<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: SystemRequired<br />
**IsValidForUpdate**: False<br />
**Type**: Uniqueidentifier<br />


### <a name="BKMK_msdyn_QuoteBookingSetup"></a> msdyn_QuoteBookingSetup

**Description**: Unique identifier for Quote Booking Setup associated with Quote Booking Service Task.<br />
**DisplayName**: Quote Booking Setup<br />
**LogicalName**: msdyn_quotebookingsetup<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: ApplicationRequired<br />
**Type**: Lookup<br />
**Targets**: msdyn_quotebookingsetup


### <a name="BKMK_msdyn_TaskType"></a> msdyn_TaskType

**Description**: Unique identifier for Service Task Type associated with Quote Booking Service Task.<br />
**DisplayName**: Task Type<br />
**LogicalName**: msdyn_tasktype<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: ApplicationRequired<br />
**Type**: Lookup<br />
**Targets**: msdyn_servicetasktype


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

**Description**: Status of the Quote Booking Service Task<br />
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

**Description**: Reason for the status of the Quote Booking Service Task<br />
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
- [msdyn_quotebookingincidentName](#BKMK_msdyn_quotebookingincidentName)
- [msdyn_QuoteBookingSetupName](#BKMK_msdyn_QuoteBookingSetupName)
- [msdyn_quoteName](#BKMK_msdyn_quoteName)
- [msdyn_TaskTypeName](#BKMK_msdyn_TaskTypeName)
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


### <a name="BKMK_msdyn_quotebookingincidentName"></a> msdyn_quotebookingincidentName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: msdyn_quotebookingincidentname<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_msdyn_QuoteBookingSetupName"></a> msdyn_QuoteBookingSetupName

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


### <a name="BKMK_msdyn_quoteName"></a> msdyn_quoteName

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


### <a name="BKMK_msdyn_TaskTypeName"></a> msdyn_TaskTypeName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: msdyn_tasktypename<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 200


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

- [msdyn_quotebookingservicetask_ActivityPointers](#BKMK_msdyn_quotebookingservicetask_ActivityPointers)
- [msdyn_quotebookingservicetask_msdyn_approvals](#BKMK_msdyn_quotebookingservicetask_msdyn_approvals)
- [msdyn_quotebookingservicetask_msdyn_bookingalerts](#BKMK_msdyn_quotebookingservicetask_msdyn_bookingalerts)
- [msdyn_quotebookingservicetask_SyncErrors](#BKMK_msdyn_quotebookingservicetask_SyncErrors)
- [msdyn_quotebookingservicetask_DuplicateMatchingRecord](#BKMK_msdyn_quotebookingservicetask_DuplicateMatchingRecord)
- [msdyn_quotebookingservicetask_DuplicateBaseRecord](#BKMK_msdyn_quotebookingservicetask_DuplicateBaseRecord)
- [msdyn_quotebookingservicetask_AsyncOperations](#BKMK_msdyn_quotebookingservicetask_AsyncOperations)
- [msdyn_quotebookingservicetask_MailboxTrackingFolders](#BKMK_msdyn_quotebookingservicetask_MailboxTrackingFolders)
- [msdyn_quotebookingservicetask_UserEntityInstanceDatas](#BKMK_msdyn_quotebookingservicetask_UserEntityInstanceDatas)
- [msdyn_quotebookingservicetask_ProcessSession](#BKMK_msdyn_quotebookingservicetask_ProcessSession)
- [msdyn_quotebookingservicetask_BulkDeleteFailures](#BKMK_msdyn_quotebookingservicetask_BulkDeleteFailures)
- [msdyn_quotebookingservicetask_PrincipalObjectAttributeAccesses](#BKMK_msdyn_quotebookingservicetask_PrincipalObjectAttributeAccesses)
- [msdyn_quotebookingservicetask_Appointments](#BKMK_msdyn_quotebookingservicetask_Appointments)
- [msdyn_quotebookingservicetask_Emails](#BKMK_msdyn_quotebookingservicetask_Emails)
- [msdyn_quotebookingservicetask_Faxes](#BKMK_msdyn_quotebookingservicetask_Faxes)
- [msdyn_quotebookingservicetask_Letters](#BKMK_msdyn_quotebookingservicetask_Letters)
- [msdyn_quotebookingservicetask_PhoneCalls](#BKMK_msdyn_quotebookingservicetask_PhoneCalls)
- [msdyn_quotebookingservicetask_Tasks](#BKMK_msdyn_quotebookingservicetask_Tasks)
- [msdyn_quotebookingservicetask_RecurringAppointmentMasters](#BKMK_msdyn_quotebookingservicetask_RecurringAppointmentMasters)
- [msdyn_quotebookingservicetask_SocialActivities](#BKMK_msdyn_quotebookingservicetask_SocialActivities)
- [msdyn_quotebookingservicetask_connections1](#BKMK_msdyn_quotebookingservicetask_connections1)
- [msdyn_quotebookingservicetask_connections2](#BKMK_msdyn_quotebookingservicetask_connections2)
- [msdyn_quotebookingservicetask_Annotations](#BKMK_msdyn_quotebookingservicetask_Annotations)
- [msdyn_quotebookingservicetask_ServiceAppointments](#BKMK_msdyn_quotebookingservicetask_ServiceAppointments)


### <a name="BKMK_msdyn_quotebookingservicetask_ActivityPointers"></a> msdyn_quotebookingservicetask_ActivityPointers

Same as activitypointer entity [msdyn_quotebookingservicetask_ActivityPointers](activitypointer.md#BKMK_msdyn_quotebookingservicetask_ActivityPointers) Many-To-One relationship.

**ReferencingEntity**: activitypointer<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_quotebookingservicetask_ActivityPointers<br />
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


### <a name="BKMK_msdyn_quotebookingservicetask_msdyn_approvals"></a> msdyn_quotebookingservicetask_msdyn_approvals

Same as msdyn_approval entity [msdyn_quotebookingservicetask_msdyn_approvals](msdyn_approval.md#BKMK_msdyn_quotebookingservicetask_msdyn_approvals) Many-To-One relationship.

**ReferencingEntity**: msdyn_approval<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_quotebookingservicetask_msdyn_approvals<br />
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


### <a name="BKMK_msdyn_quotebookingservicetask_msdyn_bookingalerts"></a> msdyn_quotebookingservicetask_msdyn_bookingalerts

Same as msdyn_bookingalert entity [msdyn_quotebookingservicetask_msdyn_bookingalerts](msdyn_bookingalert.md#BKMK_msdyn_quotebookingservicetask_msdyn_bookingalerts) Many-To-One relationship.

**ReferencingEntity**: msdyn_bookingalert<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_quotebookingservicetask_msdyn_bookingalerts<br />
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


### <a name="BKMK_msdyn_quotebookingservicetask_SyncErrors"></a> msdyn_quotebookingservicetask_SyncErrors

Same as syncerror entity [msdyn_quotebookingservicetask_SyncErrors](syncerror.md#BKMK_msdyn_quotebookingservicetask_SyncErrors) Many-To-One relationship.

**ReferencingEntity**: syncerror<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_quotebookingservicetask_SyncErrors<br />
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


### <a name="BKMK_msdyn_quotebookingservicetask_DuplicateMatchingRecord"></a> msdyn_quotebookingservicetask_DuplicateMatchingRecord

Same as duplicaterecord entity [msdyn_quotebookingservicetask_DuplicateMatchingRecord](duplicaterecord.md#BKMK_msdyn_quotebookingservicetask_DuplicateMatchingRecord) Many-To-One relationship.

**ReferencingEntity**: duplicaterecord<br />
**ReferencingAttribute**: duplicaterecordid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_quotebookingservicetask_DuplicateMatchingRecord<br />
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


### <a name="BKMK_msdyn_quotebookingservicetask_DuplicateBaseRecord"></a> msdyn_quotebookingservicetask_DuplicateBaseRecord

Same as duplicaterecord entity [msdyn_quotebookingservicetask_DuplicateBaseRecord](duplicaterecord.md#BKMK_msdyn_quotebookingservicetask_DuplicateBaseRecord) Many-To-One relationship.

**ReferencingEntity**: duplicaterecord<br />
**ReferencingAttribute**: baserecordid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_quotebookingservicetask_DuplicateBaseRecord<br />
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


### <a name="BKMK_msdyn_quotebookingservicetask_AsyncOperations"></a> msdyn_quotebookingservicetask_AsyncOperations

Same as asyncoperation entity [msdyn_quotebookingservicetask_AsyncOperations](asyncoperation.md#BKMK_msdyn_quotebookingservicetask_AsyncOperations) Many-To-One relationship.

**ReferencingEntity**: asyncoperation<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_quotebookingservicetask_AsyncOperations<br />
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


### <a name="BKMK_msdyn_quotebookingservicetask_MailboxTrackingFolders"></a> msdyn_quotebookingservicetask_MailboxTrackingFolders

Same as mailboxtrackingfolder entity [msdyn_quotebookingservicetask_MailboxTrackingFolders](mailboxtrackingfolder.md#BKMK_msdyn_quotebookingservicetask_MailboxTrackingFolders) Many-To-One relationship.

**ReferencingEntity**: mailboxtrackingfolder<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_quotebookingservicetask_MailboxTrackingFolders<br />
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


### <a name="BKMK_msdyn_quotebookingservicetask_UserEntityInstanceDatas"></a> msdyn_quotebookingservicetask_UserEntityInstanceDatas

Same as userentityinstancedata entity [msdyn_quotebookingservicetask_UserEntityInstanceDatas](userentityinstancedata.md#BKMK_msdyn_quotebookingservicetask_UserEntityInstanceDatas) Many-To-One relationship.

**ReferencingEntity**: userentityinstancedata<br />
**ReferencingAttribute**: objectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_quotebookingservicetask_UserEntityInstanceDatas<br />
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


### <a name="BKMK_msdyn_quotebookingservicetask_ProcessSession"></a> msdyn_quotebookingservicetask_ProcessSession

Same as processsession entity [msdyn_quotebookingservicetask_ProcessSession](processsession.md#BKMK_msdyn_quotebookingservicetask_ProcessSession) Many-To-One relationship.

**ReferencingEntity**: processsession<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_quotebookingservicetask_ProcessSession<br />
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


### <a name="BKMK_msdyn_quotebookingservicetask_BulkDeleteFailures"></a> msdyn_quotebookingservicetask_BulkDeleteFailures

Same as bulkdeletefailure entity [msdyn_quotebookingservicetask_BulkDeleteFailures](bulkdeletefailure.md#BKMK_msdyn_quotebookingservicetask_BulkDeleteFailures) Many-To-One relationship.

**ReferencingEntity**: bulkdeletefailure<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_quotebookingservicetask_BulkDeleteFailures<br />
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


### <a name="BKMK_msdyn_quotebookingservicetask_PrincipalObjectAttributeAccesses"></a> msdyn_quotebookingservicetask_PrincipalObjectAttributeAccesses

Same as principalobjectattributeaccess entity [msdyn_quotebookingservicetask_PrincipalObjectAttributeAccesses](principalobjectattributeaccess.md#BKMK_msdyn_quotebookingservicetask_PrincipalObjectAttributeAccesses) Many-To-One relationship.

**ReferencingEntity**: principalobjectattributeaccess<br />
**ReferencingAttribute**: objectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_quotebookingservicetask_PrincipalObjectAttributeAccesses<br />
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


### <a name="BKMK_msdyn_quotebookingservicetask_Appointments"></a> msdyn_quotebookingservicetask_Appointments

Same as appointment entity [msdyn_quotebookingservicetask_Appointments](appointment.md#BKMK_msdyn_quotebookingservicetask_Appointments) Many-To-One relationship.

**ReferencingEntity**: appointment<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_quotebookingservicetask_Appointments<br />
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


### <a name="BKMK_msdyn_quotebookingservicetask_Emails"></a> msdyn_quotebookingservicetask_Emails

Same as email entity [msdyn_quotebookingservicetask_Emails](email.md#BKMK_msdyn_quotebookingservicetask_Emails) Many-To-One relationship.

**ReferencingEntity**: email<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_quotebookingservicetask_Emails<br />
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


### <a name="BKMK_msdyn_quotebookingservicetask_Faxes"></a> msdyn_quotebookingservicetask_Faxes

Same as fax entity [msdyn_quotebookingservicetask_Faxes](fax.md#BKMK_msdyn_quotebookingservicetask_Faxes) Many-To-One relationship.

**ReferencingEntity**: fax<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_quotebookingservicetask_Faxes<br />
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


### <a name="BKMK_msdyn_quotebookingservicetask_Letters"></a> msdyn_quotebookingservicetask_Letters

Same as letter entity [msdyn_quotebookingservicetask_Letters](letter.md#BKMK_msdyn_quotebookingservicetask_Letters) Many-To-One relationship.

**ReferencingEntity**: letter<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_quotebookingservicetask_Letters<br />
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


### <a name="BKMK_msdyn_quotebookingservicetask_PhoneCalls"></a> msdyn_quotebookingservicetask_PhoneCalls

Same as phonecall entity [msdyn_quotebookingservicetask_PhoneCalls](phonecall.md#BKMK_msdyn_quotebookingservicetask_PhoneCalls) Many-To-One relationship.

**ReferencingEntity**: phonecall<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_quotebookingservicetask_PhoneCalls<br />
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


### <a name="BKMK_msdyn_quotebookingservicetask_Tasks"></a> msdyn_quotebookingservicetask_Tasks

Same as task entity [msdyn_quotebookingservicetask_Tasks](task.md#BKMK_msdyn_quotebookingservicetask_Tasks) Many-To-One relationship.

**ReferencingEntity**: task<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_quotebookingservicetask_Tasks<br />
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


### <a name="BKMK_msdyn_quotebookingservicetask_RecurringAppointmentMasters"></a> msdyn_quotebookingservicetask_RecurringAppointmentMasters

Same as recurringappointmentmaster entity [msdyn_quotebookingservicetask_RecurringAppointmentMasters](recurringappointmentmaster.md#BKMK_msdyn_quotebookingservicetask_RecurringAppointmentMasters) Many-To-One relationship.

**ReferencingEntity**: recurringappointmentmaster<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_quotebookingservicetask_RecurringAppointmentMasters<br />
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


### <a name="BKMK_msdyn_quotebookingservicetask_SocialActivities"></a> msdyn_quotebookingservicetask_SocialActivities

Same as socialactivity entity [msdyn_quotebookingservicetask_SocialActivities](socialactivity.md#BKMK_msdyn_quotebookingservicetask_SocialActivities) Many-To-One relationship.

**ReferencingEntity**: socialactivity<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_quotebookingservicetask_SocialActivities<br />
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


### <a name="BKMK_msdyn_quotebookingservicetask_connections1"></a> msdyn_quotebookingservicetask_connections1

Same as connection entity [msdyn_quotebookingservicetask_connections1](connection.md#BKMK_msdyn_quotebookingservicetask_connections1) Many-To-One relationship.

**ReferencingEntity**: connection<br />
**ReferencingAttribute**: record1id<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_quotebookingservicetask_connections1<br />
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


### <a name="BKMK_msdyn_quotebookingservicetask_connections2"></a> msdyn_quotebookingservicetask_connections2

Same as connection entity [msdyn_quotebookingservicetask_connections2](connection.md#BKMK_msdyn_quotebookingservicetask_connections2) Many-To-One relationship.

**ReferencingEntity**: connection<br />
**ReferencingAttribute**: record2id<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_quotebookingservicetask_connections2<br />
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


### <a name="BKMK_msdyn_quotebookingservicetask_Annotations"></a> msdyn_quotebookingservicetask_Annotations

Same as annotation entity [msdyn_quotebookingservicetask_Annotations](annotation.md#BKMK_msdyn_quotebookingservicetask_Annotations) Many-To-One relationship.

**ReferencingEntity**: annotation<br />
**ReferencingAttribute**: objectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_quotebookingservicetask_Annotations<br />
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


### <a name="BKMK_msdyn_quotebookingservicetask_ServiceAppointments"></a> msdyn_quotebookingservicetask_ServiceAppointments

Same as serviceappointment entity [msdyn_quotebookingservicetask_ServiceAppointments](serviceappointment.md#BKMK_msdyn_quotebookingservicetask_ServiceAppointments) Many-To-One relationship.

**ReferencingEntity**: serviceappointment<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_quotebookingservicetask_ServiceAppointments<br />
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

- [lk_msdyn_quotebookingservicetask_createdby](#BKMK_lk_msdyn_quotebookingservicetask_createdby)
- [lk_msdyn_quotebookingservicetask_createdonbehalfby](#BKMK_lk_msdyn_quotebookingservicetask_createdonbehalfby)
- [lk_msdyn_quotebookingservicetask_modifiedby](#BKMK_lk_msdyn_quotebookingservicetask_modifiedby)
- [lk_msdyn_quotebookingservicetask_modifiedonbehalfby](#BKMK_lk_msdyn_quotebookingservicetask_modifiedonbehalfby)
- [user_msdyn_quotebookingservicetask](#BKMK_user_msdyn_quotebookingservicetask)
- [team_msdyn_quotebookingservicetask](#BKMK_team_msdyn_quotebookingservicetask)
- [business_unit_msdyn_quotebookingservicetask](#BKMK_business_unit_msdyn_quotebookingservicetask)
- [msdyn_msdyn_customerasset_msdyn_quotebookingservicetask_CustomerAsset](#BKMK_msdyn_msdyn_customerasset_msdyn_quotebookingservicetask_CustomerAsset)
- [msdyn_msdyn_quotebookingincident_msdyn_quotebookingservicetask_QuoteBookingIncident](#BKMK_msdyn_msdyn_quotebookingincident_msdyn_quotebookingservicetask_QuoteBookingIncident)
- [msdyn_msdyn_quotebookingsetup_msdyn_quotebookingservicetask_QuoteBookingSetup](#BKMK_msdyn_msdyn_quotebookingsetup_msdyn_quotebookingservicetask_QuoteBookingSetup)
- [msdyn_msdyn_servicetasktype_msdyn_quotebookingservicetask_TaskType](#BKMK_msdyn_msdyn_servicetasktype_msdyn_quotebookingservicetask_TaskType)
- [msdyn_quote_msdyn_quotebookingservicetask_Quote](#BKMK_msdyn_quote_msdyn_quotebookingservicetask_Quote)


### <a name="BKMK_lk_msdyn_quotebookingservicetask_createdby"></a> lk_msdyn_quotebookingservicetask_createdby

See systemuser Entity [lk_msdyn_quotebookingservicetask_createdby](systemuser.md#BKMK_lk_msdyn_quotebookingservicetask_createdby) One-To-Many relationship.

### <a name="BKMK_lk_msdyn_quotebookingservicetask_createdonbehalfby"></a> lk_msdyn_quotebookingservicetask_createdonbehalfby

See systemuser Entity [lk_msdyn_quotebookingservicetask_createdonbehalfby](systemuser.md#BKMK_lk_msdyn_quotebookingservicetask_createdonbehalfby) One-To-Many relationship.

### <a name="BKMK_lk_msdyn_quotebookingservicetask_modifiedby"></a> lk_msdyn_quotebookingservicetask_modifiedby

See systemuser Entity [lk_msdyn_quotebookingservicetask_modifiedby](systemuser.md#BKMK_lk_msdyn_quotebookingservicetask_modifiedby) One-To-Many relationship.

### <a name="BKMK_lk_msdyn_quotebookingservicetask_modifiedonbehalfby"></a> lk_msdyn_quotebookingservicetask_modifiedonbehalfby

See systemuser Entity [lk_msdyn_quotebookingservicetask_modifiedonbehalfby](systemuser.md#BKMK_lk_msdyn_quotebookingservicetask_modifiedonbehalfby) One-To-Many relationship.

### <a name="BKMK_user_msdyn_quotebookingservicetask"></a> user_msdyn_quotebookingservicetask

See systemuser Entity [user_msdyn_quotebookingservicetask](systemuser.md#BKMK_user_msdyn_quotebookingservicetask) One-To-Many relationship.

### <a name="BKMK_team_msdyn_quotebookingservicetask"></a> team_msdyn_quotebookingservicetask

See team Entity [team_msdyn_quotebookingservicetask](team.md#BKMK_team_msdyn_quotebookingservicetask) One-To-Many relationship.

### <a name="BKMK_business_unit_msdyn_quotebookingservicetask"></a> business_unit_msdyn_quotebookingservicetask

See businessunit Entity [business_unit_msdyn_quotebookingservicetask](businessunit.md#BKMK_business_unit_msdyn_quotebookingservicetask) One-To-Many relationship.

### <a name="BKMK_msdyn_msdyn_customerasset_msdyn_quotebookingservicetask_CustomerAsset"></a> msdyn_msdyn_customerasset_msdyn_quotebookingservicetask_CustomerAsset

See msdyn_customerasset Entity [msdyn_msdyn_customerasset_msdyn_quotebookingservicetask_CustomerAsset](msdyn_customerasset.md#BKMK_msdyn_msdyn_customerasset_msdyn_quotebookingservicetask_CustomerAsset) One-To-Many relationship.

### <a name="BKMK_msdyn_msdyn_quotebookingincident_msdyn_quotebookingservicetask_QuoteBookingIncident"></a> msdyn_msdyn_quotebookingincident_msdyn_quotebookingservicetask_QuoteBookingIncident

See msdyn_quotebookingincident Entity [msdyn_msdyn_quotebookingincident_msdyn_quotebookingservicetask_QuoteBookingIncident](msdyn_quotebookingincident.md#BKMK_msdyn_msdyn_quotebookingincident_msdyn_quotebookingservicetask_QuoteBookingIncident) One-To-Many relationship.

### <a name="BKMK_msdyn_msdyn_quotebookingsetup_msdyn_quotebookingservicetask_QuoteBookingSetup"></a> msdyn_msdyn_quotebookingsetup_msdyn_quotebookingservicetask_QuoteBookingSetup

See msdyn_quotebookingsetup Entity [msdyn_msdyn_quotebookingsetup_msdyn_quotebookingservicetask_QuoteBookingSetup](msdyn_quotebookingsetup.md#BKMK_msdyn_msdyn_quotebookingsetup_msdyn_quotebookingservicetask_QuoteBookingSetup) One-To-Many relationship.

### <a name="BKMK_msdyn_msdyn_servicetasktype_msdyn_quotebookingservicetask_TaskType"></a> msdyn_msdyn_servicetasktype_msdyn_quotebookingservicetask_TaskType

See msdyn_servicetasktype Entity [msdyn_msdyn_servicetasktype_msdyn_quotebookingservicetask_TaskType](msdyn_servicetasktype.md#BKMK_msdyn_msdyn_servicetasktype_msdyn_quotebookingservicetask_TaskType) One-To-Many relationship.

### <a name="BKMK_msdyn_quote_msdyn_quotebookingservicetask_Quote"></a> msdyn_quote_msdyn_quotebookingservicetask_Quote

See quote Entity [msdyn_quote_msdyn_quotebookingservicetask_Quote](quote.md#BKMK_msdyn_quote_msdyn_quotebookingservicetask_Quote) One-To-Many relationship.

## See also

[About the Entity Reference](../about-entity-reference.md)<br />
[Programming reference for Dynamics 365 Customer Engagement](../programming-reference.md)<br />
[Web API Reference](/dynamics365/customer-engagement/web-api/about)<br />
<xref href="Microsoft.Dynamics.CRM.msdyn_quotebookingservicetask?text=msdyn_quotebookingservicetask EntityType" />