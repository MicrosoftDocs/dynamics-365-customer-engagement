---
title: "msdyn_agreementbookingservicetask Entity Reference (Developer Guide for Dynamics 365 Customer Engagement)| MicrosoftDocs"
description: "Includes schema information and supported messages for the msdyn_agreementbookingservicetask entity."
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
# msdyn_agreementbookingservicetask Entity Reference

[!INCLUDE[](../../includes/cc_applies_to_update_9_0_0.md)]

Specify the booking service task for the agreement.

**Added by**: Field Service Solution<br />

## Messages

|Message|Web API Operation|SDK Assembly|
|-|-|-|
|Assign|PATCH [*org URI*]/api/data/v9.0/msdyn_agreementbookingservicetasks(*msdyn_agreementbookingservicetaskid*)<br />[Update](../webapi/update-delete-entities-using-web-api.md#basic-update) `ownerid` property.|<xref:Microsoft.Crm.Sdk.Messages.AssignRequest>|
|Create|POST [*org URI*]/api/data/v9.0/msdyn_agreementbookingservicetasks<br />See [Create](../webapi/create-entity-web-api.md)|<xref:Microsoft.Xrm.Sdk.Messages.CreateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Create*>|
|Delete|DELETE [*org URI*]/api/data/v9.0/msdyn_agreementbookingservicetasks(*msdyn_agreementbookingservicetaskid*)<br />See [Delete](../webapi/update-delete-entities-using-web-api.md#basic-delete)|<xref:Microsoft.Xrm.Sdk.Messages.DeleteRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Delete*>|
|GrantAccess|<xref href="Microsoft.Dynamics.CRM.GrantAccess?text=GrantAccess Action" />|<xref:Microsoft.Crm.Sdk.Messages.GrantAccessRequest>|
|IsValidStateTransition|<xref href="Microsoft.Dynamics.CRM.IsValidStateTransition?text=IsValidStateTransition Function" />|<xref:Microsoft.Crm.Sdk.Messages.IsValidStateTransitionRequest>|
|ModifyAccess|<xref href="Microsoft.Dynamics.CRM.ModifyAccess?text=ModifyAccess Action" />|<xref:Microsoft.Crm.Sdk.Messages.ModifyAccessRequest>|
|Retrieve|GET [*org URI*]/api/data/v9.0/msdyn_agreementbookingservicetasks(*msdyn_agreementbookingservicetaskid*)<br />See [Retrieve](../webapi/retrieve-entity-using-web-api.md)|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Retrieve*>|
|RetrieveMultiple|GET [*org URI*]/api/data/v9.0/msdyn_agreementbookingservicetasks<br />See [Query Data](../webapi/query-data-web-api.md)|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveMultipleRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.RetrieveMultiple*>|
|RetrievePrincipalAccess|<xref href="Microsoft.Dynamics.CRM.RetrievePrincipalAccess?text=RetrievePrincipalAccess Function" />|<xref:Microsoft.Crm.Sdk.Messages.RetrievePrincipalAccessRequest>|
|RetrieveSharedPrincipalsAndAccess|<xref href="Microsoft.Dynamics.CRM.RetrieveSharedPrincipalsAndAccess?text=RetrieveSharedPrincipalsAndAccess Function" />|<xref:Microsoft.Crm.Sdk.Messages.RetrieveSharedPrincipalsAndAccessRequest>|
|RevokeAccess|<xref href="Microsoft.Dynamics.CRM.RevokeAccess?text=RevokeAccess Action" />|<xref:Microsoft.Crm.Sdk.Messages.RevokeAccessRequest>|
|SetState|PATCH [*org URI*]/api/data/v9.0/msdyn_agreementbookingservicetasks(*msdyn_agreementbookingservicetaskid*)<br />[Update](../webapi/update-delete-entities-using-web-api.md#basic-update) `statecode` and `statuscode` properties.|<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|
|Update|PATCH [*org URI*]/api/data/v9.0/msdyn_agreementbookingservicetasks(*msdyn_agreementbookingservicetaskid*)<br />See [Update](../webapi/update-delete-entities-using-web-api.md#basic-update)|<xref:Microsoft.Xrm.Sdk.Messages.UpdateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Update*>|

## Properties

**DisplayName**: Agreement Booking Service Task<br />
**DisplayCollectionName**: Agreement Booking Service Tasks<br />
**SchemaName**: msdyn_agreementbookingservicetask<br />
**CollectionSchemaName**: msdyn_agreementbookingservicetasks<br />
**LogicalName**: msdyn_agreementbookingservicetask<br />
**LogicalCollectionName**: msdyn_agreementbookingservicetasks<br />
**EntitySetName**: msdyn_agreementbookingservicetasks<br />
**PrimaryIdAttribute**: msdyn_agreementbookingservicetaskid<br />
**PrimaryNameAttribute**: msdyn_name<br />
**OwnershipType**: UserOwned<br />
**IsBPFEntity**: False<br />
<a name="writable-attributes"></a>

## Writable attributes

These attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [msdyn_Agreement](#BKMK_msdyn_Agreement)
- [msdyn_AgreementBookingIncident](#BKMK_msdyn_AgreementBookingIncident)
- [msdyn_agreementbookingservicetaskId](#BKMK_msdyn_agreementbookingservicetaskId)
- [msdyn_AgreementBookingSetup](#BKMK_msdyn_AgreementBookingSetup)
- [msdyn_CustomerAsset](#BKMK_msdyn_CustomerAsset)
- [msdyn_Description](#BKMK_msdyn_Description)
- [msdyn_EstimatedDuration](#BKMK_msdyn_EstimatedDuration)
- [msdyn_InternalFlags](#BKMK_msdyn_InternalFlags)
- [msdyn_IsCopied](#BKMK_msdyn_IsCopied)
- [msdyn_LineOrder](#BKMK_msdyn_LineOrder)
- [msdyn_name](#BKMK_msdyn_name)
- [msdyn_TaskType](#BKMK_msdyn_TaskType)
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

**Description**: Unique identifier for Agreement associated with Agreement Booking Service Task.<br />
**DisplayName**: Agreement<br />
**LogicalName**: msdyn_agreement<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: ApplicationRequired<br />
**Type**: Lookup<br />
**Targets**: msdyn_agreement


### <a name="BKMK_msdyn_AgreementBookingIncident"></a> msdyn_AgreementBookingIncident

**Description**: Shows the agreement booking incident associated with the agreement booking service task.<br />
**DisplayName**: Agreement Booking Incident<br />
**LogicalName**: msdyn_agreementbookingincident<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: msdyn_agreementbookingincident


### <a name="BKMK_msdyn_agreementbookingservicetaskId"></a> msdyn_agreementbookingservicetaskId

**Description**: Shows the entity instances.<br />
**DisplayName**: Agreement Booking Service Task<br />
**LogicalName**: msdyn_agreementbookingservicetaskid<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: SystemRequired<br />
**IsValidForUpdate**: False<br />
**Type**: Uniqueidentifier<br />


### <a name="BKMK_msdyn_AgreementBookingSetup"></a> msdyn_AgreementBookingSetup

**Description**: Unique identifier for Agreement Booking Setup associated with Agreement Booking Service Task.<br />
**DisplayName**: Agreement Booking Setup<br />
**LogicalName**: msdyn_agreementbookingsetup<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: ApplicationRequired<br />
**Type**: Lookup<br />
**Targets**: msdyn_agreementbookingsetup


### <a name="BKMK_msdyn_CustomerAsset"></a> msdyn_CustomerAsset

**Description**: Unique identifier for Customer Asset associated with Agreement Booking Service Task.<br />
**DisplayName**: Customer Asset<br />
**LogicalName**: msdyn_customerasset<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: msdyn_customerasset


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


### <a name="BKMK_msdyn_InternalFlags"></a> msdyn_InternalFlags

**Description**: <br />
**DisplayName**: Internal Flags<br />
**LogicalName**: msdyn_internalflags<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Memo<br />
**Format**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 1048576


### <a name="BKMK_msdyn_IsCopied"></a> msdyn_IsCopied

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
**RequiredLevel**: ApplicationRequired<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 200


### <a name="BKMK_msdyn_TaskType"></a> msdyn_TaskType

**Description**: Unique identifier for Service Task Type associated with Agreement Booking Service Task.<br />
**DisplayName**: Task Type<br />
**LogicalName**: msdyn_tasktype<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: ApplicationRequired<br />
**Type**: Lookup<br />
**Targets**: msdyn_servicetasktype


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

**Description**: Status of the Agreement Booking Service Task<br />
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

**Description**: Reason for the status of the Agreement Booking Service Task<br />
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
- [msdyn_AgreementBookingIncidentName](#BKMK_msdyn_AgreementBookingIncidentName)
- [msdyn_AgreementBookingSetupName](#BKMK_msdyn_AgreementBookingSetupName)
- [msdyn_AgreementName](#BKMK_msdyn_AgreementName)
- [msdyn_CustomerAssetName](#BKMK_msdyn_CustomerAssetName)
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


### <a name="BKMK_msdyn_AgreementBookingIncidentName"></a> msdyn_AgreementBookingIncidentName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: msdyn_agreementbookingincidentname<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_msdyn_AgreementBookingSetupName"></a> msdyn_AgreementBookingSetupName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: msdyn_agreementbookingsetupname<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
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


### <a name="BKMK_msdyn_CustomerAssetName"></a> msdyn_CustomerAssetName

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

- [msdyn_agreementbookingservicetask_ActivityPointers](#BKMK_msdyn_agreementbookingservicetask_ActivityPointers)
- [msdyn_agreementbookingservicetask_msdyn_approvals](#BKMK_msdyn_agreementbookingservicetask_msdyn_approvals)
- [msdyn_agreementbookingservicetask_msdyn_bookingalerts](#BKMK_msdyn_agreementbookingservicetask_msdyn_bookingalerts)
- [msdyn_agreementbookingservicetask_SyncErrors](#BKMK_msdyn_agreementbookingservicetask_SyncErrors)
- [msdyn_agreementbookingservicetask_DuplicateMatchingRecord](#BKMK_msdyn_agreementbookingservicetask_DuplicateMatchingRecord)
- [msdyn_agreementbookingservicetask_DuplicateBaseRecord](#BKMK_msdyn_agreementbookingservicetask_DuplicateBaseRecord)
- [msdyn_agreementbookingservicetask_AsyncOperations](#BKMK_msdyn_agreementbookingservicetask_AsyncOperations)
- [msdyn_agreementbookingservicetask_MailboxTrackingFolders](#BKMK_msdyn_agreementbookingservicetask_MailboxTrackingFolders)
- [msdyn_agreementbookingservicetask_UserEntityInstanceDatas](#BKMK_msdyn_agreementbookingservicetask_UserEntityInstanceDatas)
- [msdyn_agreementbookingservicetask_ProcessSession](#BKMK_msdyn_agreementbookingservicetask_ProcessSession)
- [msdyn_agreementbookingservicetask_BulkDeleteFailures](#BKMK_msdyn_agreementbookingservicetask_BulkDeleteFailures)
- [msdyn_agreementbookingservicetask_PrincipalObjectAttributeAccesses](#BKMK_msdyn_agreementbookingservicetask_PrincipalObjectAttributeAccesses)
- [msdyn_agreementbookingservicetask_Appointments](#BKMK_msdyn_agreementbookingservicetask_Appointments)
- [msdyn_agreementbookingservicetask_Emails](#BKMK_msdyn_agreementbookingservicetask_Emails)
- [msdyn_agreementbookingservicetask_Faxes](#BKMK_msdyn_agreementbookingservicetask_Faxes)
- [msdyn_agreementbookingservicetask_Letters](#BKMK_msdyn_agreementbookingservicetask_Letters)
- [msdyn_agreementbookingservicetask_PhoneCalls](#BKMK_msdyn_agreementbookingservicetask_PhoneCalls)
- [msdyn_agreementbookingservicetask_Tasks](#BKMK_msdyn_agreementbookingservicetask_Tasks)
- [msdyn_agreementbookingservicetask_RecurringAppointmentMasters](#BKMK_msdyn_agreementbookingservicetask_RecurringAppointmentMasters)
- [msdyn_agreementbookingservicetask_SocialActivities](#BKMK_msdyn_agreementbookingservicetask_SocialActivities)
- [msdyn_agreementbookingservicetask_connections1](#BKMK_msdyn_agreementbookingservicetask_connections1)
- [msdyn_agreementbookingservicetask_connections2](#BKMK_msdyn_agreementbookingservicetask_connections2)
- [msdyn_agreementbookingservicetask_Annotations](#BKMK_msdyn_agreementbookingservicetask_Annotations)
- [msdyn_agreementbookingservicetask_ServiceAppointments](#BKMK_msdyn_agreementbookingservicetask_ServiceAppointments)
- [msdyn_msdyn_agreementbookingservicetask_msdyn_workorderservicetask_AgreementBookingServiceTask](#BKMK_msdyn_msdyn_agreementbookingservicetask_msdyn_workorderservicetask_AgreementBookingServiceTask)


### <a name="BKMK_msdyn_agreementbookingservicetask_ActivityPointers"></a> msdyn_agreementbookingservicetask_ActivityPointers

Same as activitypointer entity [msdyn_agreementbookingservicetask_ActivityPointers](activitypointer.md#BKMK_msdyn_agreementbookingservicetask_ActivityPointers) Many-To-One relationship.

**ReferencingEntity**: activitypointer<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_agreementbookingservicetask_ActivityPointers<br />
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


### <a name="BKMK_msdyn_agreementbookingservicetask_msdyn_approvals"></a> msdyn_agreementbookingservicetask_msdyn_approvals

Same as msdyn_approval entity [msdyn_agreementbookingservicetask_msdyn_approvals](msdyn_approval.md#BKMK_msdyn_agreementbookingservicetask_msdyn_approvals) Many-To-One relationship.

**ReferencingEntity**: msdyn_approval<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_agreementbookingservicetask_msdyn_approvals<br />
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


### <a name="BKMK_msdyn_agreementbookingservicetask_msdyn_bookingalerts"></a> msdyn_agreementbookingservicetask_msdyn_bookingalerts

Same as msdyn_bookingalert entity [msdyn_agreementbookingservicetask_msdyn_bookingalerts](msdyn_bookingalert.md#BKMK_msdyn_agreementbookingservicetask_msdyn_bookingalerts) Many-To-One relationship.

**ReferencingEntity**: msdyn_bookingalert<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_agreementbookingservicetask_msdyn_bookingalerts<br />
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


### <a name="BKMK_msdyn_agreementbookingservicetask_SyncErrors"></a> msdyn_agreementbookingservicetask_SyncErrors

Same as syncerror entity [msdyn_agreementbookingservicetask_SyncErrors](syncerror.md#BKMK_msdyn_agreementbookingservicetask_SyncErrors) Many-To-One relationship.

**ReferencingEntity**: syncerror<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_agreementbookingservicetask_SyncErrors<br />
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


### <a name="BKMK_msdyn_agreementbookingservicetask_DuplicateMatchingRecord"></a> msdyn_agreementbookingservicetask_DuplicateMatchingRecord

Same as duplicaterecord entity [msdyn_agreementbookingservicetask_DuplicateMatchingRecord](duplicaterecord.md#BKMK_msdyn_agreementbookingservicetask_DuplicateMatchingRecord) Many-To-One relationship.

**ReferencingEntity**: duplicaterecord<br />
**ReferencingAttribute**: duplicaterecordid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_agreementbookingservicetask_DuplicateMatchingRecord<br />
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


### <a name="BKMK_msdyn_agreementbookingservicetask_DuplicateBaseRecord"></a> msdyn_agreementbookingservicetask_DuplicateBaseRecord

Same as duplicaterecord entity [msdyn_agreementbookingservicetask_DuplicateBaseRecord](duplicaterecord.md#BKMK_msdyn_agreementbookingservicetask_DuplicateBaseRecord) Many-To-One relationship.

**ReferencingEntity**: duplicaterecord<br />
**ReferencingAttribute**: baserecordid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_agreementbookingservicetask_DuplicateBaseRecord<br />
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


### <a name="BKMK_msdyn_agreementbookingservicetask_AsyncOperations"></a> msdyn_agreementbookingservicetask_AsyncOperations

Same as asyncoperation entity [msdyn_agreementbookingservicetask_AsyncOperations](asyncoperation.md#BKMK_msdyn_agreementbookingservicetask_AsyncOperations) Many-To-One relationship.

**ReferencingEntity**: asyncoperation<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_agreementbookingservicetask_AsyncOperations<br />
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


### <a name="BKMK_msdyn_agreementbookingservicetask_MailboxTrackingFolders"></a> msdyn_agreementbookingservicetask_MailboxTrackingFolders

Same as mailboxtrackingfolder entity [msdyn_agreementbookingservicetask_MailboxTrackingFolders](mailboxtrackingfolder.md#BKMK_msdyn_agreementbookingservicetask_MailboxTrackingFolders) Many-To-One relationship.

**ReferencingEntity**: mailboxtrackingfolder<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_agreementbookingservicetask_MailboxTrackingFolders<br />
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


### <a name="BKMK_msdyn_agreementbookingservicetask_UserEntityInstanceDatas"></a> msdyn_agreementbookingservicetask_UserEntityInstanceDatas

Same as userentityinstancedata entity [msdyn_agreementbookingservicetask_UserEntityInstanceDatas](userentityinstancedata.md#BKMK_msdyn_agreementbookingservicetask_UserEntityInstanceDatas) Many-To-One relationship.

**ReferencingEntity**: userentityinstancedata<br />
**ReferencingAttribute**: objectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_agreementbookingservicetask_UserEntityInstanceDatas<br />
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


### <a name="BKMK_msdyn_agreementbookingservicetask_ProcessSession"></a> msdyn_agreementbookingservicetask_ProcessSession

Same as processsession entity [msdyn_agreementbookingservicetask_ProcessSession](processsession.md#BKMK_msdyn_agreementbookingservicetask_ProcessSession) Many-To-One relationship.

**ReferencingEntity**: processsession<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_agreementbookingservicetask_ProcessSession<br />
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


### <a name="BKMK_msdyn_agreementbookingservicetask_BulkDeleteFailures"></a> msdyn_agreementbookingservicetask_BulkDeleteFailures

Same as bulkdeletefailure entity [msdyn_agreementbookingservicetask_BulkDeleteFailures](bulkdeletefailure.md#BKMK_msdyn_agreementbookingservicetask_BulkDeleteFailures) Many-To-One relationship.

**ReferencingEntity**: bulkdeletefailure<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_agreementbookingservicetask_BulkDeleteFailures<br />
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


### <a name="BKMK_msdyn_agreementbookingservicetask_PrincipalObjectAttributeAccesses"></a> msdyn_agreementbookingservicetask_PrincipalObjectAttributeAccesses

Same as principalobjectattributeaccess entity [msdyn_agreementbookingservicetask_PrincipalObjectAttributeAccesses](principalobjectattributeaccess.md#BKMK_msdyn_agreementbookingservicetask_PrincipalObjectAttributeAccesses) Many-To-One relationship.

**ReferencingEntity**: principalobjectattributeaccess<br />
**ReferencingAttribute**: objectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_agreementbookingservicetask_PrincipalObjectAttributeAccesses<br />
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


### <a name="BKMK_msdyn_agreementbookingservicetask_Appointments"></a> msdyn_agreementbookingservicetask_Appointments

Same as appointment entity [msdyn_agreementbookingservicetask_Appointments](appointment.md#BKMK_msdyn_agreementbookingservicetask_Appointments) Many-To-One relationship.

**ReferencingEntity**: appointment<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_agreementbookingservicetask_Appointments<br />
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


### <a name="BKMK_msdyn_agreementbookingservicetask_Emails"></a> msdyn_agreementbookingservicetask_Emails

Same as email entity [msdyn_agreementbookingservicetask_Emails](email.md#BKMK_msdyn_agreementbookingservicetask_Emails) Many-To-One relationship.

**ReferencingEntity**: email<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_agreementbookingservicetask_Emails<br />
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


### <a name="BKMK_msdyn_agreementbookingservicetask_Faxes"></a> msdyn_agreementbookingservicetask_Faxes

Same as fax entity [msdyn_agreementbookingservicetask_Faxes](fax.md#BKMK_msdyn_agreementbookingservicetask_Faxes) Many-To-One relationship.

**ReferencingEntity**: fax<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_agreementbookingservicetask_Faxes<br />
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


### <a name="BKMK_msdyn_agreementbookingservicetask_Letters"></a> msdyn_agreementbookingservicetask_Letters

Same as letter entity [msdyn_agreementbookingservicetask_Letters](letter.md#BKMK_msdyn_agreementbookingservicetask_Letters) Many-To-One relationship.

**ReferencingEntity**: letter<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_agreementbookingservicetask_Letters<br />
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


### <a name="BKMK_msdyn_agreementbookingservicetask_PhoneCalls"></a> msdyn_agreementbookingservicetask_PhoneCalls

Same as phonecall entity [msdyn_agreementbookingservicetask_PhoneCalls](phonecall.md#BKMK_msdyn_agreementbookingservicetask_PhoneCalls) Many-To-One relationship.

**ReferencingEntity**: phonecall<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_agreementbookingservicetask_PhoneCalls<br />
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


### <a name="BKMK_msdyn_agreementbookingservicetask_Tasks"></a> msdyn_agreementbookingservicetask_Tasks

Same as task entity [msdyn_agreementbookingservicetask_Tasks](task.md#BKMK_msdyn_agreementbookingservicetask_Tasks) Many-To-One relationship.

**ReferencingEntity**: task<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_agreementbookingservicetask_Tasks<br />
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


### <a name="BKMK_msdyn_agreementbookingservicetask_RecurringAppointmentMasters"></a> msdyn_agreementbookingservicetask_RecurringAppointmentMasters

Same as recurringappointmentmaster entity [msdyn_agreementbookingservicetask_RecurringAppointmentMasters](recurringappointmentmaster.md#BKMK_msdyn_agreementbookingservicetask_RecurringAppointmentMasters) Many-To-One relationship.

**ReferencingEntity**: recurringappointmentmaster<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_agreementbookingservicetask_RecurringAppointmentMasters<br />
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


### <a name="BKMK_msdyn_agreementbookingservicetask_SocialActivities"></a> msdyn_agreementbookingservicetask_SocialActivities

Same as socialactivity entity [msdyn_agreementbookingservicetask_SocialActivities](socialactivity.md#BKMK_msdyn_agreementbookingservicetask_SocialActivities) Many-To-One relationship.

**ReferencingEntity**: socialactivity<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_agreementbookingservicetask_SocialActivities<br />
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


### <a name="BKMK_msdyn_agreementbookingservicetask_connections1"></a> msdyn_agreementbookingservicetask_connections1

Same as connection entity [msdyn_agreementbookingservicetask_connections1](connection.md#BKMK_msdyn_agreementbookingservicetask_connections1) Many-To-One relationship.

**ReferencingEntity**: connection<br />
**ReferencingAttribute**: record1id<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_agreementbookingservicetask_connections1<br />
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


### <a name="BKMK_msdyn_agreementbookingservicetask_connections2"></a> msdyn_agreementbookingservicetask_connections2

Same as connection entity [msdyn_agreementbookingservicetask_connections2](connection.md#BKMK_msdyn_agreementbookingservicetask_connections2) Many-To-One relationship.

**ReferencingEntity**: connection<br />
**ReferencingAttribute**: record2id<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_agreementbookingservicetask_connections2<br />
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


### <a name="BKMK_msdyn_agreementbookingservicetask_Annotations"></a> msdyn_agreementbookingservicetask_Annotations

Same as annotation entity [msdyn_agreementbookingservicetask_Annotations](annotation.md#BKMK_msdyn_agreementbookingservicetask_Annotations) Many-To-One relationship.

**ReferencingEntity**: annotation<br />
**ReferencingAttribute**: objectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_agreementbookingservicetask_Annotations<br />
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


### <a name="BKMK_msdyn_agreementbookingservicetask_ServiceAppointments"></a> msdyn_agreementbookingservicetask_ServiceAppointments

Same as serviceappointment entity [msdyn_agreementbookingservicetask_ServiceAppointments](serviceappointment.md#BKMK_msdyn_agreementbookingservicetask_ServiceAppointments) Many-To-One relationship.

**ReferencingEntity**: serviceappointment<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_agreementbookingservicetask_ServiceAppointments<br />
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


### <a name="BKMK_msdyn_msdyn_agreementbookingservicetask_msdyn_workorderservicetask_AgreementBookingServiceTask"></a> msdyn_msdyn_agreementbookingservicetask_msdyn_workorderservicetask_AgreementBookingServiceTask

Same as msdyn_workorderservicetask entity [msdyn_msdyn_agreementbookingservicetask_msdyn_workorderservicetask_AgreementBookingServiceTask](msdyn_workorderservicetask.md#BKMK_msdyn_msdyn_agreementbookingservicetask_msdyn_workorderservicetask_AgreementBookingServiceTask) Many-To-One relationship.

**ReferencingEntity**: msdyn_workorderservicetask<br />
**ReferencingAttribute**: msdyn_agreementbookingservicetask<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_msdyn_agreementbookingservicetask_msdyn_workorderservicetask_AgreementBookingServiceTask<br />
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

- [lk_msdyn_agreementbookingservicetask_createdby](#BKMK_lk_msdyn_agreementbookingservicetask_createdby)
- [lk_msdyn_agreementbookingservicetask_createdonbehalfby](#BKMK_lk_msdyn_agreementbookingservicetask_createdonbehalfby)
- [lk_msdyn_agreementbookingservicetask_modifiedby](#BKMK_lk_msdyn_agreementbookingservicetask_modifiedby)
- [lk_msdyn_agreementbookingservicetask_modifiedonbehalfby](#BKMK_lk_msdyn_agreementbookingservicetask_modifiedonbehalfby)
- [user_msdyn_agreementbookingservicetask](#BKMK_user_msdyn_agreementbookingservicetask)
- [team_msdyn_agreementbookingservicetask](#BKMK_team_msdyn_agreementbookingservicetask)
- [business_unit_msdyn_agreementbookingservicetask](#BKMK_business_unit_msdyn_agreementbookingservicetask)
- [msdyn_msdyn_agreement_msdyn_agreementbookingservicetask_Agreement](#BKMK_msdyn_msdyn_agreement_msdyn_agreementbookingservicetask_Agreement)
- [msdyn_msdyn_agreementbookingincident_msdyn_agreementbookingservicetask_AgreementBookingIncident](#BKMK_msdyn_msdyn_agreementbookingincident_msdyn_agreementbookingservicetask_AgreementBookingIncident)
- [msdyn_msdyn_agreementbookingsetup_msdyn_agreementbookingservicetask_AgreementBookingSetup](#BKMK_msdyn_msdyn_agreementbookingsetup_msdyn_agreementbookingservicetask_AgreementBookingSetup)
- [msdyn_msdyn_customerasset_msdyn_agreementbookingservicetask_CustomerAsset](#BKMK_msdyn_msdyn_customerasset_msdyn_agreementbookingservicetask_CustomerAsset)
- [msdyn_msdyn_servicetasktype_msdyn_agreementbookingservicetask_TaskType](#BKMK_msdyn_msdyn_servicetasktype_msdyn_agreementbookingservicetask_TaskType)


### <a name="BKMK_lk_msdyn_agreementbookingservicetask_createdby"></a> lk_msdyn_agreementbookingservicetask_createdby

See systemuser Entity [lk_msdyn_agreementbookingservicetask_createdby](systemuser.md#BKMK_lk_msdyn_agreementbookingservicetask_createdby) One-To-Many relationship.

### <a name="BKMK_lk_msdyn_agreementbookingservicetask_createdonbehalfby"></a> lk_msdyn_agreementbookingservicetask_createdonbehalfby

See systemuser Entity [lk_msdyn_agreementbookingservicetask_createdonbehalfby](systemuser.md#BKMK_lk_msdyn_agreementbookingservicetask_createdonbehalfby) One-To-Many relationship.

### <a name="BKMK_lk_msdyn_agreementbookingservicetask_modifiedby"></a> lk_msdyn_agreementbookingservicetask_modifiedby

See systemuser Entity [lk_msdyn_agreementbookingservicetask_modifiedby](systemuser.md#BKMK_lk_msdyn_agreementbookingservicetask_modifiedby) One-To-Many relationship.

### <a name="BKMK_lk_msdyn_agreementbookingservicetask_modifiedonbehalfby"></a> lk_msdyn_agreementbookingservicetask_modifiedonbehalfby

See systemuser Entity [lk_msdyn_agreementbookingservicetask_modifiedonbehalfby](systemuser.md#BKMK_lk_msdyn_agreementbookingservicetask_modifiedonbehalfby) One-To-Many relationship.

### <a name="BKMK_user_msdyn_agreementbookingservicetask"></a> user_msdyn_agreementbookingservicetask

See systemuser Entity [user_msdyn_agreementbookingservicetask](systemuser.md#BKMK_user_msdyn_agreementbookingservicetask) One-To-Many relationship.

### <a name="BKMK_team_msdyn_agreementbookingservicetask"></a> team_msdyn_agreementbookingservicetask

See team Entity [team_msdyn_agreementbookingservicetask](team.md#BKMK_team_msdyn_agreementbookingservicetask) One-To-Many relationship.

### <a name="BKMK_business_unit_msdyn_agreementbookingservicetask"></a> business_unit_msdyn_agreementbookingservicetask

See businessunit Entity [business_unit_msdyn_agreementbookingservicetask](businessunit.md#BKMK_business_unit_msdyn_agreementbookingservicetask) One-To-Many relationship.

### <a name="BKMK_msdyn_msdyn_agreement_msdyn_agreementbookingservicetask_Agreement"></a> msdyn_msdyn_agreement_msdyn_agreementbookingservicetask_Agreement

See msdyn_agreement Entity [msdyn_msdyn_agreement_msdyn_agreementbookingservicetask_Agreement](msdyn_agreement.md#BKMK_msdyn_msdyn_agreement_msdyn_agreementbookingservicetask_Agreement) One-To-Many relationship.

### <a name="BKMK_msdyn_msdyn_agreementbookingincident_msdyn_agreementbookingservicetask_AgreementBookingIncident"></a> msdyn_msdyn_agreementbookingincident_msdyn_agreementbookingservicetask_AgreementBookingIncident

See msdyn_agreementbookingincident Entity [msdyn_msdyn_agreementbookingincident_msdyn_agreementbookingservicetask_AgreementBookingIncident](msdyn_agreementbookingincident.md#BKMK_msdyn_msdyn_agreementbookingincident_msdyn_agreementbookingservicetask_AgreementBookingIncident) One-To-Many relationship.

### <a name="BKMK_msdyn_msdyn_agreementbookingsetup_msdyn_agreementbookingservicetask_AgreementBookingSetup"></a> msdyn_msdyn_agreementbookingsetup_msdyn_agreementbookingservicetask_AgreementBookingSetup

See msdyn_agreementbookingsetup Entity [msdyn_msdyn_agreementbookingsetup_msdyn_agreementbookingservicetask_AgreementBookingSetup](msdyn_agreementbookingsetup.md#BKMK_msdyn_msdyn_agreementbookingsetup_msdyn_agreementbookingservicetask_AgreementBookingSetup) One-To-Many relationship.

### <a name="BKMK_msdyn_msdyn_customerasset_msdyn_agreementbookingservicetask_CustomerAsset"></a> msdyn_msdyn_customerasset_msdyn_agreementbookingservicetask_CustomerAsset

See msdyn_customerasset Entity [msdyn_msdyn_customerasset_msdyn_agreementbookingservicetask_CustomerAsset](msdyn_customerasset.md#BKMK_msdyn_msdyn_customerasset_msdyn_agreementbookingservicetask_CustomerAsset) One-To-Many relationship.

### <a name="BKMK_msdyn_msdyn_servicetasktype_msdyn_agreementbookingservicetask_TaskType"></a> msdyn_msdyn_servicetasktype_msdyn_agreementbookingservicetask_TaskType

See msdyn_servicetasktype Entity [msdyn_msdyn_servicetasktype_msdyn_agreementbookingservicetask_TaskType](msdyn_servicetasktype.md#BKMK_msdyn_msdyn_servicetasktype_msdyn_agreementbookingservicetask_TaskType) One-To-Many relationship.

## See also

[About the Entity Reference](../about-entity-reference.md)<br />
[Programming reference for Dynamics 365 Customer Engagement](../programming-reference.md)<br />
[Web API Reference](/dynamics365/customer-engagement/web-api/about)<br />
<xref href="Microsoft.Dynamics.CRM.msdyn_agreementbookingservicetask?text=msdyn_agreementbookingservicetask EntityType" />