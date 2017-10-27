---
title: "msdyn_workorderincident Entity Reference (Developer Guide for Dynamics 365 Customer Engagement)| MicrosoftDocs"
description: "Includes schema information and supported messages for the msdyn_workorderincident entity."
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
# msdyn_workorderincident Entity Reference

Specify work order incidents reported to you by the client. These are also referred to as problem codes.

**Added by**: Field Service Solution<br />

## Messages

|Message|Web API Operation|SDK Assembly|
|-|-|-|
|Assign|PATCH [*org URI*]/api/data/v9.0/msdyn_workorderincidents(*msdyn_workorderincidentid*)<br />[Update](../webapi/update-delete-entities-using-web-api.md#basic-update) `ownerid` property.|<xref:Microsoft.Crm.Sdk.Messages.AssignRequest>|
|Create|POST [*org URI*]/api/data/v9.0/msdyn_workorderincidents<br />See [Create](../webapi/create-entity-web-api.md)|<xref:Microsoft.Xrm.Sdk.Messages.CreateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Create*>|
|Delete|DELETE [*org URI*]/api/data/v9.0/msdyn_workorderincidents(*msdyn_workorderincidentid*)<br />See [Delete](../webapi/update-delete-entities-using-web-api.md#basic-delete)|<xref:Microsoft.Xrm.Sdk.Messages.DeleteRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Delete*>|
|GrantAccess|<xref href="Microsoft.Dynamics.CRM.GrantAccess?text=GrantAccess Action" />|<xref:Microsoft.Crm.Sdk.Messages.GrantAccessRequest>|
|IsValidStateTransition|<xref href="Microsoft.Dynamics.CRM.IsValidStateTransition?text=IsValidStateTransition Function" />|<xref:Microsoft.Crm.Sdk.Messages.IsValidStateTransitionRequest>|
|ModifyAccess|<xref href="Microsoft.Dynamics.CRM.ModifyAccess?text=ModifyAccess Action" />|<xref:Microsoft.Crm.Sdk.Messages.ModifyAccessRequest>|
|Retrieve|GET [*org URI*]/api/data/v9.0/msdyn_workorderincidents(*msdyn_workorderincidentid*)<br />See [Retrieve](../webapi/retrieve-entity-using-web-api.md)|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Retrieve*>|
|RetrieveMultiple|GET [*org URI*]/api/data/v9.0/msdyn_workorderincidents<br />See [Query Data](../webapi/query-data-web-api.md)|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveMultipleRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.RetrieveMultiple*>|
|RetrievePrincipalAccess|<xref href="Microsoft.Dynamics.CRM.RetrievePrincipalAccess?text=RetrievePrincipalAccess Function" />|<xref:Microsoft.Crm.Sdk.Messages.RetrievePrincipalAccessRequest>|
|RetrieveSharedPrincipalsAndAccess|<xref href="Microsoft.Dynamics.CRM.RetrieveSharedPrincipalsAndAccess?text=RetrieveSharedPrincipalsAndAccess Function" />|<xref:Microsoft.Crm.Sdk.Messages.RetrieveSharedPrincipalsAndAccessRequest>|
|RevokeAccess|<xref href="Microsoft.Dynamics.CRM.RevokeAccess?text=RevokeAccess Action" />|<xref:Microsoft.Crm.Sdk.Messages.RevokeAccessRequest>|
|SetState|PATCH [*org URI*]/api/data/v9.0/msdyn_workorderincidents(*msdyn_workorderincidentid*)<br />[Update](../webapi/update-delete-entities-using-web-api.md#basic-update) `statecode` and `statuscode` properties.|<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|
|Update|PATCH [*org URI*]/api/data/v9.0/msdyn_workorderincidents(*msdyn_workorderincidentid*)<br />See [Update](../webapi/update-delete-entities-using-web-api.md#basic-update)|<xref:Microsoft.Xrm.Sdk.Messages.UpdateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Update*>|

## Properties

**DisplayName**: Work Order Incident<br />
**DisplayCollectionName**: Work Order Incidents<br />
**SchemaName**: msdyn_workorderincident<br />
**CollectionSchemaName**: msdyn_workorderincidents<br />
**LogicalName**: msdyn_workorderincident<br />
**LogicalCollectionName**: msdyn_workorderincidents<br />
**EntitySetName**: msdyn_workorderincidents<br />
**PrimaryIdAttribute**: msdyn_workorderincidentid<br />
**PrimaryNameAttribute**: msdyn_name<br />
**OwnershipType**: UserOwned<br />
**IsBPFEntity**: False<br />
<a name="writable-attributes"></a>

## Writable attributes

These attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [msdyn_AgreementBookingIncident](#BKMK_msdyn_AgreementBookingIncident)
- [msdyn_CustomerAsset](#BKMK_msdyn_CustomerAsset)
- [msdyn_Description](#BKMK_msdyn_Description)
- [msdyn_EstimatedDuration](#BKMK_msdyn_EstimatedDuration)
- [msdyn_IncidentResolved](#BKMK_msdyn_IncidentResolved)
- [msdyn_IncidentType](#BKMK_msdyn_IncidentType)
- [msdyn_InternalFlags](#BKMK_msdyn_InternalFlags)
- [msdyn_IsMobile](#BKMK_msdyn_IsMobile)
- [msdyn_IsPrimary](#BKMK_msdyn_IsPrimary)
- [msdyn_ItemsPopulated](#BKMK_msdyn_ItemsPopulated)
- [msdyn_name](#BKMK_msdyn_name)
- [msdyn_ResourceRequirement](#BKMK_msdyn_ResourceRequirement)
- [msdyn_TasksPercentCompleted](#BKMK_msdyn_TasksPercentCompleted)
- [msdyn_WorkOrder](#BKMK_msdyn_WorkOrder)
- [msdyn_workorderincidentId](#BKMK_msdyn_workorderincidentId)
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


### <a name="BKMK_msdyn_AgreementBookingIncident"></a> msdyn_AgreementBookingIncident

**Description**: Agreement Booking Incident linked to this Work Order Incident<br />
**DisplayName**: Agreement Booking Incident<br />
**LogicalName**: msdyn_agreementbookingincident<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: msdyn_agreementbookingincident


### <a name="BKMK_msdyn_CustomerAsset"></a> msdyn_CustomerAsset

**Description**: Customer Asset related to this incident reported<br />
**DisplayName**: Customer Asset<br />
**LogicalName**: msdyn_customerasset<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: msdyn_customerasset


### <a name="BKMK_msdyn_Description"></a> msdyn_Description

**Description**: Incident description<br />
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


### <a name="BKMK_msdyn_IncidentResolved"></a> msdyn_IncidentResolved

**Description**: Shows if the incident has been resolved by one of its related tasks.<br />
**DisplayName**: Incident Resolved<br />
**LogicalName**: msdyn_incidentresolved<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Boolean<br />
**Options**:

- **TrueOption Value**: 1 **Label**: Yes
- **FalseOption Value**: 0 **Label**: No

**DefaultValue**: False


### <a name="BKMK_msdyn_IncidentType"></a> msdyn_IncidentType

**Description**: Incident type reported<br />
**DisplayName**: Incident Type<br />
**LogicalName**: msdyn_incidenttype<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: ApplicationRequired<br />
**Type**: Lookup<br />
**Targets**: msdyn_incidenttype


### <a name="BKMK_msdyn_InternalFlags"></a> msdyn_InternalFlags

**Description**: For internal use only.<br />
**DisplayName**: Internal Flags<br />
**LogicalName**: msdyn_internalflags<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Memo<br />
**Format**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 1048576


### <a name="BKMK_msdyn_IsMobile"></a> msdyn_IsMobile

**Description**: <br />
**DisplayName**: Is Mobile<br />
**LogicalName**: msdyn_ismobile<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Boolean<br />
**Options**:

- **TrueOption Value**: 1 **Label**: Yes
- **FalseOption Value**: 0 **Label**: No

**DefaultValue**: False


### <a name="BKMK_msdyn_IsPrimary"></a> msdyn_IsPrimary

**Description**: <br />
**DisplayName**: Is Primary<br />
**LogicalName**: msdyn_isprimary<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Boolean<br />
**Options**:

- **TrueOption Value**: 1 **Label**: Yes
- **FalseOption Value**: 0 **Label**: No

**DefaultValue**: False


### <a name="BKMK_msdyn_ItemsPopulated"></a> msdyn_ItemsPopulated

**Description**: <br />
**DisplayName**: Items Populated<br />
**LogicalName**: msdyn_itemspopulated<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Boolean<br />
**Options**:

- **TrueOption Value**: 1 **Label**: Yes
- **FalseOption Value**: 0 **Label**: No

**DefaultValue**: True


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
**MaxLength**: 100


### <a name="BKMK_msdyn_ResourceRequirement"></a> msdyn_ResourceRequirement

**Description**: Resource Requirement<br />
**DisplayName**: Resource Requirement<br />
**LogicalName**: msdyn_resourcerequirement<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: msdyn_resourcerequirement


### <a name="BKMK_msdyn_TasksPercentCompleted"></a> msdyn_TasksPercentCompleted

**Description**: Shows the percent completed on associated tasks. This indicates the total of completed tasks, but not if the incident was resolved.<br />
**DisplayName**: Tasks % Completed<br />
**LogicalName**: msdyn_taskspercentcompleted<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Double<br />
**MaxValue**: 100<br />
**MinValue**: 0<br />
**Precision**: 2


### <a name="BKMK_msdyn_WorkOrder"></a> msdyn_WorkOrder

**Description**: Parent Work Order where incident was reported on<br />
**DisplayName**: Work Order<br />
**LogicalName**: msdyn_workorder<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: ApplicationRequired<br />
**Type**: Lookup<br />
**Targets**: msdyn_workorder


### <a name="BKMK_msdyn_workorderincidentId"></a> msdyn_workorderincidentId

**Description**: Shows the entity instances.<br />
**DisplayName**: Work Order Incident<br />
**LogicalName**: msdyn_workorderincidentid<br />
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

**Description**: Status of the Work Order Incident<br />
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

**Description**: Reason for the status of the Work Order Incident<br />
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
- [msdyn_CustomerAssetName](#BKMK_msdyn_CustomerAssetName)
- [msdyn_IncidentTypeName](#BKMK_msdyn_IncidentTypeName)
- [msdyn_ResourceRequirementName](#BKMK_msdyn_ResourceRequirementName)
- [msdyn_WorkOrderName](#BKMK_msdyn_WorkOrderName)
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


### <a name="BKMK_msdyn_ResourceRequirementName"></a> msdyn_ResourceRequirementName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: msdyn_resourcerequirementname<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_msdyn_WorkOrderName"></a> msdyn_WorkOrderName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: msdyn_workordername<br />
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

- [msdyn_workorderincident_ActivityPointers](#BKMK_msdyn_workorderincident_ActivityPointers)
- [msdyn_workorderincident_msdyn_approvals](#BKMK_msdyn_workorderincident_msdyn_approvals)
- [msdyn_workorderincident_msdyn_bookingalerts](#BKMK_msdyn_workorderincident_msdyn_bookingalerts)
- [msdyn_workorderincident_SyncErrors](#BKMK_msdyn_workorderincident_SyncErrors)
- [msdyn_workorderincident_DuplicateMatchingRecord](#BKMK_msdyn_workorderincident_DuplicateMatchingRecord)
- [msdyn_workorderincident_DuplicateBaseRecord](#BKMK_msdyn_workorderincident_DuplicateBaseRecord)
- [msdyn_workorderincident_SharePointDocumentLocations](#BKMK_msdyn_workorderincident_SharePointDocumentLocations)
- [msdyn_workorderincident_SharePointDocuments](#BKMK_msdyn_workorderincident_SharePointDocuments)
- [msdyn_workorderincident_AsyncOperations](#BKMK_msdyn_workorderincident_AsyncOperations)
- [msdyn_workorderincident_MailboxTrackingFolders](#BKMK_msdyn_workorderincident_MailboxTrackingFolders)
- [msdyn_workorderincident_UserEntityInstanceDatas](#BKMK_msdyn_workorderincident_UserEntityInstanceDatas)
- [msdyn_workorderincident_ProcessSession](#BKMK_msdyn_workorderincident_ProcessSession)
- [msdyn_workorderincident_BulkDeleteFailures](#BKMK_msdyn_workorderincident_BulkDeleteFailures)
- [msdyn_workorderincident_PrincipalObjectAttributeAccesses](#BKMK_msdyn_workorderincident_PrincipalObjectAttributeAccesses)
- [msdyn_workorderincident_Appointments](#BKMK_msdyn_workorderincident_Appointments)
- [msdyn_workorderincident_Emails](#BKMK_msdyn_workorderincident_Emails)
- [msdyn_workorderincident_Faxes](#BKMK_msdyn_workorderincident_Faxes)
- [msdyn_workorderincident_Letters](#BKMK_msdyn_workorderincident_Letters)
- [msdyn_workorderincident_PhoneCalls](#BKMK_msdyn_workorderincident_PhoneCalls)
- [msdyn_workorderincident_Tasks](#BKMK_msdyn_workorderincident_Tasks)
- [msdyn_workorderincident_RecurringAppointmentMasters](#BKMK_msdyn_workorderincident_RecurringAppointmentMasters)
- [msdyn_workorderincident_SocialActivities](#BKMK_msdyn_workorderincident_SocialActivities)
- [msdyn_workorderincident_connections1](#BKMK_msdyn_workorderincident_connections1)
- [msdyn_workorderincident_connections2](#BKMK_msdyn_workorderincident_connections2)
- [msdyn_workorderincident_QueueItems](#BKMK_msdyn_workorderincident_QueueItems)
- [msdyn_workorderincident_Annotations](#BKMK_msdyn_workorderincident_Annotations)
- [msdyn_workorderincident_ServiceAppointments](#BKMK_msdyn_workorderincident_ServiceAppointments)
- [msdyn_msdyn_workorderincident_msdyn_requirementcharacteristic_WorkOrderIncident](#BKMK_msdyn_msdyn_workorderincident_msdyn_requirementcharacteristic_WorkOrderIncident)
- [msdyn_msdyn_workorderincident_msdyn_workordercharacteristic_WorkOrderIncident](#BKMK_msdyn_msdyn_workorderincident_msdyn_workordercharacteristic_WorkOrderIncident)
- [msdyn_msdyn_workorderincident_msdyn_workorderproduct_WorkOrderIncident](#BKMK_msdyn_msdyn_workorderincident_msdyn_workorderproduct_WorkOrderIncident)
- [msdyn_msdyn_workorderincident_msdyn_workorderservice_WorkOrderIncident](#BKMK_msdyn_msdyn_workorderincident_msdyn_workorderservice_WorkOrderIncident)
- [msdyn_msdyn_workorderincident_msdyn_workorderservicetask_WorkOrderIncident](#BKMK_msdyn_msdyn_workorderincident_msdyn_workorderservicetask_WorkOrderIncident)


### <a name="BKMK_msdyn_workorderincident_ActivityPointers"></a> msdyn_workorderincident_ActivityPointers

Same as activitypointer entity [msdyn_workorderincident_ActivityPointers](activitypointer.md#BKMK_msdyn_workorderincident_ActivityPointers) Many-To-One relationship.

**ReferencingEntity**: activitypointer<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_workorderincident_ActivityPointers<br />
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


### <a name="BKMK_msdyn_workorderincident_msdyn_approvals"></a> msdyn_workorderincident_msdyn_approvals

Same as msdyn_approval entity [msdyn_workorderincident_msdyn_approvals](msdyn_approval.md#BKMK_msdyn_workorderincident_msdyn_approvals) Many-To-One relationship.

**ReferencingEntity**: msdyn_approval<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_workorderincident_msdyn_approvals<br />
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


### <a name="BKMK_msdyn_workorderincident_msdyn_bookingalerts"></a> msdyn_workorderincident_msdyn_bookingalerts

Same as msdyn_bookingalert entity [msdyn_workorderincident_msdyn_bookingalerts](msdyn_bookingalert.md#BKMK_msdyn_workorderincident_msdyn_bookingalerts) Many-To-One relationship.

**ReferencingEntity**: msdyn_bookingalert<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_workorderincident_msdyn_bookingalerts<br />
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


### <a name="BKMK_msdyn_workorderincident_SyncErrors"></a> msdyn_workorderincident_SyncErrors

Same as syncerror entity [msdyn_workorderincident_SyncErrors](syncerror.md#BKMK_msdyn_workorderincident_SyncErrors) Many-To-One relationship.

**ReferencingEntity**: syncerror<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_workorderincident_SyncErrors<br />
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


### <a name="BKMK_msdyn_workorderincident_DuplicateMatchingRecord"></a> msdyn_workorderincident_DuplicateMatchingRecord

Same as duplicaterecord entity [msdyn_workorderincident_DuplicateMatchingRecord](duplicaterecord.md#BKMK_msdyn_workorderincident_DuplicateMatchingRecord) Many-To-One relationship.

**ReferencingEntity**: duplicaterecord<br />
**ReferencingAttribute**: duplicaterecordid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_workorderincident_DuplicateMatchingRecord<br />
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


### <a name="BKMK_msdyn_workorderincident_DuplicateBaseRecord"></a> msdyn_workorderincident_DuplicateBaseRecord

Same as duplicaterecord entity [msdyn_workorderincident_DuplicateBaseRecord](duplicaterecord.md#BKMK_msdyn_workorderincident_DuplicateBaseRecord) Many-To-One relationship.

**ReferencingEntity**: duplicaterecord<br />
**ReferencingAttribute**: baserecordid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_workorderincident_DuplicateBaseRecord<br />
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


### <a name="BKMK_msdyn_workorderincident_SharePointDocumentLocations"></a> msdyn_workorderincident_SharePointDocumentLocations

Same as sharepointdocumentlocation entity [msdyn_workorderincident_SharePointDocumentLocations](sharepointdocumentlocation.md#BKMK_msdyn_workorderincident_SharePointDocumentLocations) Many-To-One relationship.

**ReferencingEntity**: sharepointdocumentlocation<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_workorderincident_SharePointDocumentLocations<br />
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


### <a name="BKMK_msdyn_workorderincident_SharePointDocuments"></a> msdyn_workorderincident_SharePointDocuments

Same as sharepointdocument entity [msdyn_workorderincident_SharePointDocuments](sharepointdocument.md#BKMK_msdyn_workorderincident_SharePointDocuments) Many-To-One relationship.

**ReferencingEntity**: sharepointdocument<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_workorderincident_SharePointDocuments<br />
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


### <a name="BKMK_msdyn_workorderincident_AsyncOperations"></a> msdyn_workorderincident_AsyncOperations

Same as asyncoperation entity [msdyn_workorderincident_AsyncOperations](asyncoperation.md#BKMK_msdyn_workorderincident_AsyncOperations) Many-To-One relationship.

**ReferencingEntity**: asyncoperation<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_workorderincident_AsyncOperations<br />
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


### <a name="BKMK_msdyn_workorderincident_MailboxTrackingFolders"></a> msdyn_workorderincident_MailboxTrackingFolders

Same as mailboxtrackingfolder entity [msdyn_workorderincident_MailboxTrackingFolders](mailboxtrackingfolder.md#BKMK_msdyn_workorderincident_MailboxTrackingFolders) Many-To-One relationship.

**ReferencingEntity**: mailboxtrackingfolder<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_workorderincident_MailboxTrackingFolders<br />
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


### <a name="BKMK_msdyn_workorderincident_UserEntityInstanceDatas"></a> msdyn_workorderincident_UserEntityInstanceDatas

Same as userentityinstancedata entity [msdyn_workorderincident_UserEntityInstanceDatas](userentityinstancedata.md#BKMK_msdyn_workorderincident_UserEntityInstanceDatas) Many-To-One relationship.

**ReferencingEntity**: userentityinstancedata<br />
**ReferencingAttribute**: objectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_workorderincident_UserEntityInstanceDatas<br />
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


### <a name="BKMK_msdyn_workorderincident_ProcessSession"></a> msdyn_workorderincident_ProcessSession

Same as processsession entity [msdyn_workorderincident_ProcessSession](processsession.md#BKMK_msdyn_workorderincident_ProcessSession) Many-To-One relationship.

**ReferencingEntity**: processsession<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_workorderincident_ProcessSession<br />
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


### <a name="BKMK_msdyn_workorderincident_BulkDeleteFailures"></a> msdyn_workorderincident_BulkDeleteFailures

Same as bulkdeletefailure entity [msdyn_workorderincident_BulkDeleteFailures](bulkdeletefailure.md#BKMK_msdyn_workorderincident_BulkDeleteFailures) Many-To-One relationship.

**ReferencingEntity**: bulkdeletefailure<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_workorderincident_BulkDeleteFailures<br />
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


### <a name="BKMK_msdyn_workorderincident_PrincipalObjectAttributeAccesses"></a> msdyn_workorderincident_PrincipalObjectAttributeAccesses

Same as principalobjectattributeaccess entity [msdyn_workorderincident_PrincipalObjectAttributeAccesses](principalobjectattributeaccess.md#BKMK_msdyn_workorderincident_PrincipalObjectAttributeAccesses) Many-To-One relationship.

**ReferencingEntity**: principalobjectattributeaccess<br />
**ReferencingAttribute**: objectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_workorderincident_PrincipalObjectAttributeAccesses<br />
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


### <a name="BKMK_msdyn_workorderincident_Appointments"></a> msdyn_workorderincident_Appointments

Same as appointment entity [msdyn_workorderincident_Appointments](appointment.md#BKMK_msdyn_workorderincident_Appointments) Many-To-One relationship.

**ReferencingEntity**: appointment<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_workorderincident_Appointments<br />
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


### <a name="BKMK_msdyn_workorderincident_Emails"></a> msdyn_workorderincident_Emails

Same as email entity [msdyn_workorderincident_Emails](email.md#BKMK_msdyn_workorderincident_Emails) Many-To-One relationship.

**ReferencingEntity**: email<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_workorderincident_Emails<br />
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


### <a name="BKMK_msdyn_workorderincident_Faxes"></a> msdyn_workorderincident_Faxes

Same as fax entity [msdyn_workorderincident_Faxes](fax.md#BKMK_msdyn_workorderincident_Faxes) Many-To-One relationship.

**ReferencingEntity**: fax<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_workorderincident_Faxes<br />
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


### <a name="BKMK_msdyn_workorderincident_Letters"></a> msdyn_workorderincident_Letters

Same as letter entity [msdyn_workorderincident_Letters](letter.md#BKMK_msdyn_workorderincident_Letters) Many-To-One relationship.

**ReferencingEntity**: letter<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_workorderincident_Letters<br />
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


### <a name="BKMK_msdyn_workorderincident_PhoneCalls"></a> msdyn_workorderincident_PhoneCalls

Same as phonecall entity [msdyn_workorderincident_PhoneCalls](phonecall.md#BKMK_msdyn_workorderincident_PhoneCalls) Many-To-One relationship.

**ReferencingEntity**: phonecall<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_workorderincident_PhoneCalls<br />
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


### <a name="BKMK_msdyn_workorderincident_Tasks"></a> msdyn_workorderincident_Tasks

Same as task entity [msdyn_workorderincident_Tasks](task.md#BKMK_msdyn_workorderincident_Tasks) Many-To-One relationship.

**ReferencingEntity**: task<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_workorderincident_Tasks<br />
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


### <a name="BKMK_msdyn_workorderincident_RecurringAppointmentMasters"></a> msdyn_workorderincident_RecurringAppointmentMasters

Same as recurringappointmentmaster entity [msdyn_workorderincident_RecurringAppointmentMasters](recurringappointmentmaster.md#BKMK_msdyn_workorderincident_RecurringAppointmentMasters) Many-To-One relationship.

**ReferencingEntity**: recurringappointmentmaster<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_workorderincident_RecurringAppointmentMasters<br />
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


### <a name="BKMK_msdyn_workorderincident_SocialActivities"></a> msdyn_workorderincident_SocialActivities

Same as socialactivity entity [msdyn_workorderincident_SocialActivities](socialactivity.md#BKMK_msdyn_workorderincident_SocialActivities) Many-To-One relationship.

**ReferencingEntity**: socialactivity<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_workorderincident_SocialActivities<br />
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


### <a name="BKMK_msdyn_workorderincident_connections1"></a> msdyn_workorderincident_connections1

Same as connection entity [msdyn_workorderincident_connections1](connection.md#BKMK_msdyn_workorderincident_connections1) Many-To-One relationship.

**ReferencingEntity**: connection<br />
**ReferencingAttribute**: record1id<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_workorderincident_connections1<br />
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


### <a name="BKMK_msdyn_workorderincident_connections2"></a> msdyn_workorderincident_connections2

Same as connection entity [msdyn_workorderincident_connections2](connection.md#BKMK_msdyn_workorderincident_connections2) Many-To-One relationship.

**ReferencingEntity**: connection<br />
**ReferencingAttribute**: record2id<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_workorderincident_connections2<br />
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


### <a name="BKMK_msdyn_workorderincident_QueueItems"></a> msdyn_workorderincident_QueueItems

Same as queueitem entity [msdyn_workorderincident_QueueItems](queueitem.md#BKMK_msdyn_workorderincident_QueueItems) Many-To-One relationship.

**ReferencingEntity**: queueitem<br />
**ReferencingAttribute**: objectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_workorderincident_QueueItems<br />
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


### <a name="BKMK_msdyn_workorderincident_Annotations"></a> msdyn_workorderincident_Annotations

Same as annotation entity [msdyn_workorderincident_Annotations](annotation.md#BKMK_msdyn_workorderincident_Annotations) Many-To-One relationship.

**ReferencingEntity**: annotation<br />
**ReferencingAttribute**: objectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_workorderincident_Annotations<br />
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


### <a name="BKMK_msdyn_workorderincident_ServiceAppointments"></a> msdyn_workorderincident_ServiceAppointments

Same as serviceappointment entity [msdyn_workorderincident_ServiceAppointments](serviceappointment.md#BKMK_msdyn_workorderincident_ServiceAppointments) Many-To-One relationship.

**ReferencingEntity**: serviceappointment<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_workorderincident_ServiceAppointments<br />
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


### <a name="BKMK_msdyn_msdyn_workorderincident_msdyn_requirementcharacteristic_WorkOrderIncident"></a> msdyn_msdyn_workorderincident_msdyn_requirementcharacteristic_WorkOrderIncident

Same as msdyn_requirementcharacteristic entity [msdyn_msdyn_workorderincident_msdyn_requirementcharacteristic_WorkOrderIncident](msdyn_requirementcharacteristic.md#BKMK_msdyn_msdyn_workorderincident_msdyn_requirementcharacteristic_WorkOrderIncident) Many-To-One relationship.

**ReferencingEntity**: msdyn_requirementcharacteristic<br />
**ReferencingAttribute**: msdyn_workorderincident<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_msdyn_workorderincident_msdyn_requirementcharacteristic_WorkOrderIncident<br />
**AssociatedMenuConfiguration**:

- **Behavior**: UseLabel
- **Group**: Details
- **Label**: Characteristics
- **Order**: 10000

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: RemoveLink
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_msdyn_msdyn_workorderincident_msdyn_workordercharacteristic_WorkOrderIncident"></a> msdyn_msdyn_workorderincident_msdyn_workordercharacteristic_WorkOrderIncident

Same as msdyn_workordercharacteristic entity [msdyn_msdyn_workorderincident_msdyn_workordercharacteristic_WorkOrderIncident](msdyn_workordercharacteristic.md#BKMK_msdyn_msdyn_workorderincident_msdyn_workordercharacteristic_WorkOrderIncident) Many-To-One relationship.

**ReferencingEntity**: msdyn_workordercharacteristic<br />
**ReferencingAttribute**: msdyn_workorderincident<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_msdyn_workorderincident_msdyn_workordercharacteristic_WorkOrderIncident<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
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


### <a name="BKMK_msdyn_msdyn_workorderincident_msdyn_workorderproduct_WorkOrderIncident"></a> msdyn_msdyn_workorderincident_msdyn_workorderproduct_WorkOrderIncident

Same as msdyn_workorderproduct entity [msdyn_msdyn_workorderincident_msdyn_workorderproduct_WorkOrderIncident](msdyn_workorderproduct.md#BKMK_msdyn_msdyn_workorderincident_msdyn_workorderproduct_WorkOrderIncident) Many-To-One relationship.

**ReferencingEntity**: msdyn_workorderproduct<br />
**ReferencingAttribute**: msdyn_workorderincident<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_msdyn_workorderincident_msdyn_workorderproduct_WorkOrderIncident<br />
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


### <a name="BKMK_msdyn_msdyn_workorderincident_msdyn_workorderservice_WorkOrderIncident"></a> msdyn_msdyn_workorderincident_msdyn_workorderservice_WorkOrderIncident

Same as msdyn_workorderservice entity [msdyn_msdyn_workorderincident_msdyn_workorderservice_WorkOrderIncident](msdyn_workorderservice.md#BKMK_msdyn_msdyn_workorderincident_msdyn_workorderservice_WorkOrderIncident) Many-To-One relationship.

**ReferencingEntity**: msdyn_workorderservice<br />
**ReferencingAttribute**: msdyn_workorderincident<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_msdyn_workorderincident_msdyn_workorderservice_WorkOrderIncident<br />
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


### <a name="BKMK_msdyn_msdyn_workorderincident_msdyn_workorderservicetask_WorkOrderIncident"></a> msdyn_msdyn_workorderincident_msdyn_workorderservicetask_WorkOrderIncident

Same as msdyn_workorderservicetask entity [msdyn_msdyn_workorderincident_msdyn_workorderservicetask_WorkOrderIncident](msdyn_workorderservicetask.md#BKMK_msdyn_msdyn_workorderincident_msdyn_workorderservicetask_WorkOrderIncident) Many-To-One relationship.

**ReferencingEntity**: msdyn_workorderservicetask<br />
**ReferencingAttribute**: msdyn_workorderincident<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_msdyn_workorderincident_msdyn_workorderservicetask_WorkOrderIncident<br />
**AssociatedMenuConfiguration**:

- **Behavior**: UseLabel
- **Group**: Details
- **Label**: Work Order Service Tasks
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

- [lk_msdyn_workorderincident_createdby](#BKMK_lk_msdyn_workorderincident_createdby)
- [lk_msdyn_workorderincident_createdonbehalfby](#BKMK_lk_msdyn_workorderincident_createdonbehalfby)
- [lk_msdyn_workorderincident_modifiedby](#BKMK_lk_msdyn_workorderincident_modifiedby)
- [lk_msdyn_workorderincident_modifiedonbehalfby](#BKMK_lk_msdyn_workorderincident_modifiedonbehalfby)
- [user_msdyn_workorderincident](#BKMK_user_msdyn_workorderincident)
- [team_msdyn_workorderincident](#BKMK_team_msdyn_workorderincident)
- [business_unit_msdyn_workorderincident](#BKMK_business_unit_msdyn_workorderincident)
- [msdyn_msdyn_agreementbookingincident_msdyn_workorderincident_AgreementBookingIncident](#BKMK_msdyn_msdyn_agreementbookingincident_msdyn_workorderincident_AgreementBookingIncident)
- [msdyn_msdyn_customerasset_msdyn_workorderincident_CustomerAsset](#BKMK_msdyn_msdyn_customerasset_msdyn_workorderincident_CustomerAsset)
- [msdyn_msdyn_incidenttype_msdyn_workorderincident_IncidentType](#BKMK_msdyn_msdyn_incidenttype_msdyn_workorderincident_IncidentType)
- [msdyn_msdyn_resourcerequirement_msdyn_workorderincident_ResourceRequirement](#BKMK_msdyn_msdyn_resourcerequirement_msdyn_workorderincident_ResourceRequirement)
- [msdyn_msdyn_workorder_msdyn_workorderincident_WorkOrder](#BKMK_msdyn_msdyn_workorder_msdyn_workorderincident_WorkOrder)


### <a name="BKMK_lk_msdyn_workorderincident_createdby"></a> lk_msdyn_workorderincident_createdby

See systemuser Entity [lk_msdyn_workorderincident_createdby](systemuser.md#BKMK_lk_msdyn_workorderincident_createdby) One-To-Many relationship.

### <a name="BKMK_lk_msdyn_workorderincident_createdonbehalfby"></a> lk_msdyn_workorderincident_createdonbehalfby

See systemuser Entity [lk_msdyn_workorderincident_createdonbehalfby](systemuser.md#BKMK_lk_msdyn_workorderincident_createdonbehalfby) One-To-Many relationship.

### <a name="BKMK_lk_msdyn_workorderincident_modifiedby"></a> lk_msdyn_workorderincident_modifiedby

See systemuser Entity [lk_msdyn_workorderincident_modifiedby](systemuser.md#BKMK_lk_msdyn_workorderincident_modifiedby) One-To-Many relationship.

### <a name="BKMK_lk_msdyn_workorderincident_modifiedonbehalfby"></a> lk_msdyn_workorderincident_modifiedonbehalfby

See systemuser Entity [lk_msdyn_workorderincident_modifiedonbehalfby](systemuser.md#BKMK_lk_msdyn_workorderincident_modifiedonbehalfby) One-To-Many relationship.

### <a name="BKMK_user_msdyn_workorderincident"></a> user_msdyn_workorderincident

See systemuser Entity [user_msdyn_workorderincident](systemuser.md#BKMK_user_msdyn_workorderincident) One-To-Many relationship.

### <a name="BKMK_team_msdyn_workorderincident"></a> team_msdyn_workorderincident

See team Entity [team_msdyn_workorderincident](team.md#BKMK_team_msdyn_workorderincident) One-To-Many relationship.

### <a name="BKMK_business_unit_msdyn_workorderincident"></a> business_unit_msdyn_workorderincident

See businessunit Entity [business_unit_msdyn_workorderincident](businessunit.md#BKMK_business_unit_msdyn_workorderincident) One-To-Many relationship.

### <a name="BKMK_msdyn_msdyn_agreementbookingincident_msdyn_workorderincident_AgreementBookingIncident"></a> msdyn_msdyn_agreementbookingincident_msdyn_workorderincident_AgreementBookingIncident

See msdyn_agreementbookingincident Entity [msdyn_msdyn_agreementbookingincident_msdyn_workorderincident_AgreementBookingIncident](msdyn_agreementbookingincident.md#BKMK_msdyn_msdyn_agreementbookingincident_msdyn_workorderincident_AgreementBookingIncident) One-To-Many relationship.

### <a name="BKMK_msdyn_msdyn_customerasset_msdyn_workorderincident_CustomerAsset"></a> msdyn_msdyn_customerasset_msdyn_workorderincident_CustomerAsset

See msdyn_customerasset Entity [msdyn_msdyn_customerasset_msdyn_workorderincident_CustomerAsset](msdyn_customerasset.md#BKMK_msdyn_msdyn_customerasset_msdyn_workorderincident_CustomerAsset) One-To-Many relationship.

### <a name="BKMK_msdyn_msdyn_incidenttype_msdyn_workorderincident_IncidentType"></a> msdyn_msdyn_incidenttype_msdyn_workorderincident_IncidentType

See msdyn_incidenttype Entity [msdyn_msdyn_incidenttype_msdyn_workorderincident_IncidentType](msdyn_incidenttype.md#BKMK_msdyn_msdyn_incidenttype_msdyn_workorderincident_IncidentType) One-To-Many relationship.

### <a name="BKMK_msdyn_msdyn_resourcerequirement_msdyn_workorderincident_ResourceRequirement"></a> msdyn_msdyn_resourcerequirement_msdyn_workorderincident_ResourceRequirement

See msdyn_resourcerequirement Entity [msdyn_msdyn_resourcerequirement_msdyn_workorderincident_ResourceRequirement](msdyn_resourcerequirement.md#BKMK_msdyn_msdyn_resourcerequirement_msdyn_workorderincident_ResourceRequirement) One-To-Many relationship.

### <a name="BKMK_msdyn_msdyn_workorder_msdyn_workorderincident_WorkOrder"></a> msdyn_msdyn_workorder_msdyn_workorderincident_WorkOrder

See msdyn_workorder Entity [msdyn_msdyn_workorder_msdyn_workorderincident_WorkOrder](msdyn_workorder.md#BKMK_msdyn_msdyn_workorder_msdyn_workorderincident_WorkOrder) One-To-Many relationship.

## See also

[About the Entity Reference](../about-entity-reference.md)<br />
[Programming reference for Dynamics 365 Customer Engagement](../programming-reference.md)<br />
[Web API Reference](/dynamics365/customer-engagement/web-api/about)<br />
<xref href="Microsoft.Dynamics.CRM.msdyn_workorderincident?text=msdyn_workorderincident EntityType" />