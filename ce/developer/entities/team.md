---
title: "Team Entity Reference (Developer Guide for Dynamics 365 Customer Engagement)| MicrosoftDocs"
description: "Includes schema information and supported messages for the Team entity."
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
# Team Entity Reference

Collection of system users that routinely collaborate. Teams can be used to simplify record sharing and provide team members with common access to organization data when team members belong to different Business Units.


## Messages

|Message|Web API Operation|SDK Assembly|
|-|-|-|
|AddMembersTeam|<xref href="Microsoft.Dynamics.CRM.AddMembersTeam?text=AddMembersTeam Action" />|<xref:Microsoft.Crm.Sdk.Messages.AddMembersTeamRequest>|
|ConvertOwnerTeamToAccessTeam|<xref href="Microsoft.Dynamics.CRM.ConvertOwnerTeamToAccessTeam?text=ConvertOwnerTeamToAccessTeam Action" />|<xref:Microsoft.Crm.Sdk.Messages.ConvertOwnerTeamToAccessTeamRequest>|
|Create|POST [*org URI*]/api/data/v9.0/teams<br />See [Create](../webapi/create-entity-web-api.md)|<xref:Microsoft.Xrm.Sdk.Messages.CreateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Create*>|
|Delete|DELETE [*org URI*]/api/data/v9.0/teams(*teamid*)<br />See [Delete](../webapi/update-delete-entities-using-web-api.md#basic-delete)|<xref:Microsoft.Xrm.Sdk.Messages.DeleteRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Delete*>|
|RemoveMembersTeam|<xref href="Microsoft.Dynamics.CRM.RemoveMembersTeam?text=RemoveMembersTeam Action" />|<xref:Microsoft.Crm.Sdk.Messages.RemoveMembersTeamRequest>|
|Retrieve|GET [*org URI*]/api/data/v9.0/teams(*teamid*)<br />See [Retrieve](../webapi/retrieve-entity-using-web-api.md)|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Retrieve*>|
|RetrieveMultiple|GET [*org URI*]/api/data/v9.0/teams<br />See [Query Data](../webapi/query-data-web-api.md)|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveMultipleRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.RetrieveMultiple*>|
|SetParentBusinessUnit|[Associate and disassociate entities](../webapi/associate-disassociate-entities-using-web-api.md)|<xref:Microsoft.Crm.Sdk.Messages.SetParentBusinessUnitRequest>|
|SetParentSystemUser|<xref href="Microsoft.Dynamics.CRM.SetParentSystemUser?text=SetParentSystemUser Action" />|<xref:Microsoft.Crm.Sdk.Messages.SetParentSystemUserRequest>|
|SetParentTeam|[Associate and disassociate entities](../webapi/associate-disassociate-entities-using-web-api.md)|<xref:Microsoft.Crm.Sdk.Messages.SetParentTeamRequest>|
|Update|PATCH [*org URI*]/api/data/v9.0/teams(*teamid*)<br />See [Update](../webapi/update-delete-entities-using-web-api.md#basic-update)|<xref:Microsoft.Xrm.Sdk.Messages.UpdateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Update*>|

## Properties

**DisplayName**: Team<br />
**DisplayCollectionName**: Teams<br />
**SchemaName**: Team<br />
**CollectionSchemaName**: Teams<br />
**LogicalName**: team<br />
**LogicalCollectionName**: teams<br />
**EntitySetName**: teams<br />
**PrimaryIdAttribute**: teamid<br />
**PrimaryNameAttribute**: name<br />
**OwnershipType**: BusinessOwned<br />
**IsBPFEntity**: False<br />
<a name="writable-attributes"></a>

## Writable attributes

These attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [AdministratorId](#BKMK_AdministratorId)
- [BusinessUnitId](#BKMK_BusinessUnitId)
- [Description](#BKMK_Description)
- [EMailAddress](#BKMK_EMailAddress)
- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [Name](#BKMK_Name)
- [OverriddenCreatedOn](#BKMK_OverriddenCreatedOn)
- [ProcessId](#BKMK_ProcessId)
- [QueueId](#BKMK_QueueId)
- [RegardingObjectId](#BKMK_RegardingObjectId)
- [RegardingObjectTypeCode](#BKMK_RegardingObjectTypeCode)
- [StageId](#BKMK_StageId)
- [TeamId](#BKMK_TeamId)
- [TeamTemplateId](#BKMK_TeamTemplateId)
- [TeamType](#BKMK_TeamType)
- [TransactionCurrencyId](#BKMK_TransactionCurrencyId)
- [TraversedPath](#BKMK_TraversedPath)
- [YomiName](#BKMK_YomiName)


### <a name="BKMK_AdministratorId"></a> AdministratorId

**Description**: Unique identifier of the user primary responsible for the team.<br />
**DisplayName**: Administrator<br />
**LogicalName**: administratorid<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: SystemRequired<br />
**Type**: Lookup<br />
**Targets**: systemuser


### <a name="BKMK_BusinessUnitId"></a> BusinessUnitId

**Description**: Unique identifier of the business unit with which the team is associated.<br />
**DisplayName**: Business Unit<br />
**LogicalName**: businessunitid<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: SystemRequired<br />
**Type**: Lookup<br />
**Targets**: businessunit


### <a name="BKMK_Description"></a> Description

**Description**: Description of the team.<br />
**DisplayName**: Description<br />
**LogicalName**: description<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Memo<br />
**Format**: TextArea<br />
**IsLocalizable**: False<br />
**MaxLength**: 2000


### <a name="BKMK_EMailAddress"></a> EMailAddress

**Description**: Email address for the team.<br />
**DisplayName**: Email<br />
**LogicalName**: emailaddress<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Email<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_ImportSequenceNumber"></a> ImportSequenceNumber

**Description**: Unique identifier of the data import or data migration that created this record.<br />
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


### <a name="BKMK_Name"></a> Name

**Description**: Name of the team.<br />
**DisplayName**: Team Name<br />
**LogicalName**: name<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: SystemRequired<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 160


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


### <a name="BKMK_ProcessId"></a> ProcessId

**Description**: Shows the ID of the process.<br />
**DisplayName**: Process<br />
**LogicalName**: processid<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Uniqueidentifier<br />


### <a name="BKMK_QueueId"></a> QueueId

**Description**: Unique identifier of the default queue for the team.<br />
**DisplayName**: Default Queue<br />
**LogicalName**: queueid<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: queue


### <a name="BKMK_RegardingObjectId"></a> RegardingObjectId

**Description**: Choose the record that the team relates to.<br />
**DisplayName**: Regarding Object Id<br />
**LogicalName**: regardingobjectid<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**IsValidForUpdate**: False<br />
**Type**: Lookup<br />
**Targets**: knowledgearticle,opportunity


### <a name="BKMK_RegardingObjectTypeCode"></a> RegardingObjectTypeCode

**Description**: Type of the associated record for team - used for system managed access teams only.<br />
**DisplayName**: Regarding Object Type<br />
**LogicalName**: regardingobjecttypecode<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**IsValidForUpdate**: False<br />
**Type**: EntityName<br />


### <a name="BKMK_StageId"></a> StageId

**Description**: Shows the ID of the stage.<br />
**DisplayName**: Process Stage<br />
**LogicalName**: stageid<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Uniqueidentifier<br />


### <a name="BKMK_TeamId"></a> TeamId

**Description**: Unique identifier for the team.<br />
**DisplayName**: Team<br />
**LogicalName**: teamid<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: SystemRequired<br />
**IsValidForUpdate**: False<br />
**Type**: Uniqueidentifier<br />


### <a name="BKMK_TeamTemplateId"></a> TeamTemplateId

**Description**: Shows the team template that is associated with the team.<br />
**DisplayName**: Team Template Identifier<br />
**LogicalName**: teamtemplateid<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**IsValidForUpdate**: False<br />
**Type**: Lookup<br />
**Targets**: teamtemplate


### <a name="BKMK_TeamType"></a> TeamType

**Description**: Select the team type.<br />
**DisplayName**: Team Type<br />
**LogicalName**: teamtype<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: SystemRequired<br />
**IsValidForUpdate**: False<br />
**Type**: Picklist<br />
**Options**:

- **Value**: 0 **Label**: Owner
- **Value**: 1 **Label**: Access



### <a name="BKMK_TransactionCurrencyId"></a> TransactionCurrencyId

**Description**: Unique identifier of the currency associated with the team.<br />
**DisplayName**: Currency<br />
**LogicalName**: transactioncurrencyid<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: transactioncurrency


### <a name="BKMK_TraversedPath"></a> TraversedPath

**Description**: For internal use only.<br />
**DisplayName**: Traversed Path<br />
**LogicalName**: traversedpath<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 1250


### <a name="BKMK_YomiName"></a> YomiName

**Description**: Pronunciation of the full name of the team, written in phonetic hiragana or katakana characters.<br />
**DisplayName**: Yomi Name<br />
**LogicalName**: yominame<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: PhoneticGuide<br />
**IsLocalizable**: False<br />
**MaxLength**: 160

<a name="read-only-attributes"></a>
## Read-only attributes
These attributes return false for both **IsValidForCreate** or **IsValidForUpdate**. Listed by **SchemaName**.

- [AdministratorIdName](#BKMK_AdministratorIdName)
- [AdministratorIdYomiName](#BKMK_AdministratorIdYomiName)
- [BusinessUnitIdName](#BKMK_BusinessUnitIdName)
- [CreatedBy](#BKMK_CreatedBy)
- [CreatedByName](#BKMK_CreatedByName)
- [CreatedByYomiName](#BKMK_CreatedByYomiName)
- [CreatedOn](#BKMK_CreatedOn)
- [CreatedOnBehalfBy](#BKMK_CreatedOnBehalfBy)
- [CreatedOnBehalfByName](#BKMK_CreatedOnBehalfByName)
- [CreatedOnBehalfByYomiName](#BKMK_CreatedOnBehalfByYomiName)
- [ExchangeRate](#BKMK_ExchangeRate)
- [IsDefault](#BKMK_IsDefault)
- [ModifiedBy](#BKMK_ModifiedBy)
- [ModifiedByName](#BKMK_ModifiedByName)
- [ModifiedByYomiName](#BKMK_ModifiedByYomiName)
- [ModifiedOn](#BKMK_ModifiedOn)
- [ModifiedOnBehalfBy](#BKMK_ModifiedOnBehalfBy)
- [ModifiedOnBehalfByName](#BKMK_ModifiedOnBehalfByName)
- [ModifiedOnBehalfByYomiName](#BKMK_ModifiedOnBehalfByYomiName)
- [OrganizationId](#BKMK_OrganizationId)
- [OrganizationIdName](#BKMK_OrganizationIdName)
- [QueueIdName](#BKMK_QueueIdName)
- [SystemManaged](#BKMK_SystemManaged)
- [TransactionCurrencyIdName](#BKMK_TransactionCurrencyIdName)
- [VersionNumber](#BKMK_VersionNumber)


### <a name="BKMK_AdministratorIdName"></a> AdministratorIdName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: administratoridname<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_AdministratorIdYomiName"></a> AdministratorIdYomiName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: administratoridyominame<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_BusinessUnitIdName"></a> BusinessUnitIdName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: businessunitidname<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: SystemRequired<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_CreatedBy"></a> CreatedBy

**Description**: Unique identifier of the user who created the team.<br />
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
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_CreatedOn"></a> CreatedOn

**Description**: Date and time when the team was created.<br />
**DisplayName**: Created On<br />
**LogicalName**: createdon<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: DateTime<br />
**DateTimeBehavior**: UserLocal<br />
**Format**: DateAndTime


### <a name="BKMK_CreatedOnBehalfBy"></a> CreatedOnBehalfBy

**Description**: Unique identifier of the delegate user who created the team.<br />
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
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_ExchangeRate"></a> ExchangeRate

**Description**: Exchange rate for the currency associated with the team with respect to the base currency.<br />
**DisplayName**: Exchange Rate<br />
**LogicalName**: exchangerate<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Decimal<br />
**MaxValue**: 100000000000<br />
**MinValue**: 0.0000000001<br />
**Precision**: 10


### <a name="BKMK_IsDefault"></a> IsDefault

**Description**: Information about whether the team is a default business unit team.<br />
**DisplayName**: Is Default<br />
**LogicalName**: isdefault<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: SystemRequired<br />
**Type**: Boolean<br />
**Options**:

- **TrueOption Value**: 1 **Label**: Yes
- **FalseOption Value**: 0 **Label**: No

**DefaultValue**: False


### <a name="BKMK_ModifiedBy"></a> ModifiedBy

**Description**: Unique identifier of the user who last modified the team.<br />
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
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_ModifiedOn"></a> ModifiedOn

**Description**: Date and time when the team was last modified.<br />
**DisplayName**: Modified On<br />
**LogicalName**: modifiedon<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: DateTime<br />
**DateTimeBehavior**: UserLocal<br />
**Format**: DateAndTime


### <a name="BKMK_ModifiedOnBehalfBy"></a> ModifiedOnBehalfBy

**Description**: Unique identifier of the delegate user who last modified the team.<br />
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
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_OrganizationId"></a> OrganizationId

**Description**: Unique identifier of the organization associated with the team.<br />
**DisplayName**: Organization <br />
**LogicalName**: organizationid<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: SystemRequired<br />
**Type**: Uniqueidentifier<br />


### <a name="BKMK_OrganizationIdName"></a> OrganizationIdName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: organizationidname<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: SystemRequired<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_QueueIdName"></a> QueueIdName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: queueidname<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 400


### <a name="BKMK_SystemManaged"></a> SystemManaged

**Description**: Select whether the team will be managed by the system.<br />
**DisplayName**: Is System Managed<br />
**LogicalName**: systemmanaged<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: SystemRequired<br />
**Type**: Boolean<br />
**Options**:

- **TrueOption Value**: 1 **Label**: Yes
- **FalseOption Value**: 0 **Label**: No

**DefaultValue**: False


### <a name="BKMK_TransactionCurrencyIdName"></a> TransactionCurrencyIdName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: transactioncurrencyidname<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_VersionNumber"></a> VersionNumber

**Description**: Version number of the team.<br />
**DisplayName**: Version number<br />
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

- [team_msdyn_iotalert](#BKMK_team_msdyn_iotalert)
- [team_msdyn_iotdevice](#BKMK_team_msdyn_iotdevice)
- [team_msdyn_iotdevicecategory](#BKMK_team_msdyn_iotdevicecategory)
- [team_msdyn_iotdevicecommand](#BKMK_team_msdyn_iotdevicecommand)
- [team_msdyn_iotdeviceregistrationhistory](#BKMK_team_msdyn_iotdeviceregistrationhistory)
- [lead_owning_team](#BKMK_lead_owning_team)
- [team_DynamicPropertyInstance](#BKMK_team_DynamicPropertyInstance)
- [team_bookableresource](#BKMK_team_bookableresource)
- [team_bookableresourcebooking](#BKMK_team_bookableresourcebooking)
- [team_bookableresourcebookingexchangesyncidmapping](#BKMK_team_bookableresourcebookingexchangesyncidmapping)
- [team_bookableresourcebookingheader](#BKMK_team_bookableresourcebookingheader)
- [team_bookableresourcecategory](#BKMK_team_bookableresourcecategory)
- [team_bookableresourcecategoryassn](#BKMK_team_bookableresourcecategoryassn)
- [team_bookableresourcecharacteristic](#BKMK_team_bookableresourcecharacteristic)
- [team_bookableresourcegroup](#BKMK_team_bookableresourcegroup)
- [team_bookingstatus](#BKMK_team_bookingstatus)
- [team_characteristic](#BKMK_team_characteristic)
- [team_ratingmodel](#BKMK_team_ratingmodel)
- [team_ratingvalue](#BKMK_team_ratingvalue)
- [team_BulkOperation](#BKMK_team_BulkOperation)
- [team_bulkoperationlog](#BKMK_team_bulkoperationlog)
- [team_Campaigns](#BKMK_team_Campaigns)
- [team_campaignactivity](#BKMK_team_campaignactivity)
- [team_campaignresponse](#BKMK_team_campaignresponse)
- [team_list](#BKMK_team_list)
- [team_service_contracts](#BKMK_team_service_contracts)
- [team_contractdetail](#BKMK_team_contractdetail)
- [team_entitlement](#BKMK_team_entitlement)
- [team_entitlementchannel](#BKMK_team_entitlementchannel)
- [team_incidents](#BKMK_team_incidents)
- [team_incidentresolution](#BKMK_team_incidentresolution)
- [team_knowledgearticleincident](#BKMK_team_knowledgearticleincident)
- [team_service_appointments](#BKMK_team_service_appointments)
- [team_resource_specs](#BKMK_team_resource_specs)
- [team_resource_groups](#BKMK_team_resource_groups)
- [team_customer_opportunity_roles](#BKMK_team_customer_opportunity_roles)
- [team_invoices](#BKMK_team_invoices)
- [team_invoicedetail](#BKMK_team_invoicedetail)
- [team_opportunities](#BKMK_team_opportunities)
- [team_opportunityclose](#BKMK_team_opportunityclose)
- [team_opportunityproduct](#BKMK_team_opportunityproduct)
- [team_orderclose](#BKMK_team_orderclose)
- [team_quotes](#BKMK_team_quotes)
- [team_quoteclose](#BKMK_team_quoteclose)
- [team_quotedetail](#BKMK_team_quotedetail)
- [team_orders](#BKMK_team_orders)
- [team_salesorderdetail](#BKMK_team_salesorderdetail)
- [team_msdyn_postalbum](#BKMK_team_msdyn_postalbum)
- [team_msdyn_wallsavedqueryusersettings](#BKMK_team_msdyn_wallsavedqueryusersettings)
- [team_msdyn_actual](#BKMK_team_msdyn_actual)
- [msdyn_bookingalert_team_owningteam](#BKMK_msdyn_bookingalert_team_owningteam)
- [team_msdyn_bookingalertstatus](#BKMK_team_msdyn_bookingalertstatus)
- [team_msdyn_bookingchange](#BKMK_team_msdyn_bookingchange)
- [team_msdyn_bookingrule](#BKMK_team_msdyn_bookingrule)
- [team_msdyn_bookingsetupmetadata](#BKMK_team_msdyn_bookingsetupmetadata)
- [team_msdyn_clientextension](#BKMK_team_msdyn_clientextension)
- [team_msdyn_configuration](#BKMK_team_msdyn_configuration)
- [team_msdyn_priority](#BKMK_team_msdyn_priority)
- [team_msdyn_requirementcharacteristic](#BKMK_team_msdyn_requirementcharacteristic)
- [team_msdyn_requirementorganizationunit](#BKMK_team_msdyn_requirementorganizationunit)
- [team_msdyn_requirementresourcecategory](#BKMK_team_msdyn_requirementresourcecategory)
- [team_msdyn_requirementresourcepreference](#BKMK_team_msdyn_requirementresourcepreference)
- [team_msdyn_requirementstatus](#BKMK_team_msdyn_requirementstatus)
- [team_msdyn_resourcerequirement](#BKMK_team_msdyn_resourcerequirement)
- [team_msdyn_resourcerequirementdetail](#BKMK_team_msdyn_resourcerequirementdetail)
- [team_msdyn_resourceterritory](#BKMK_team_msdyn_resourceterritory)
- [team_msdyn_scheduleboardsetting](#BKMK_team_msdyn_scheduleboardsetting)
- [team_msdyn_systemuserschedulersetting](#BKMK_team_msdyn_systemuserschedulersetting)
- [team_msdyn_timegroup](#BKMK_team_msdyn_timegroup)
- [team_msdyn_timegroupdetail](#BKMK_team_msdyn_timegroupdetail)
- [team_msdyn_transactionorigin](#BKMK_team_msdyn_transactionorigin)
- [team_msdyn_workhourtemplate](#BKMK_team_msdyn_workhourtemplate)
- [team_msdyn_accountpricelist](#BKMK_team_msdyn_accountpricelist)
- [msdyn_approval_team_owningteam](#BKMK_msdyn_approval_team_owningteam)
- [team_msdyn_characteristicreqforteammember](#BKMK_team_msdyn_characteristicreqforteammember)
- [team_msdyn_contactpricelist](#BKMK_team_msdyn_contactpricelist)
- [team_msdyn_contractlinescheduleofvalue](#BKMK_team_msdyn_contractlinescheduleofvalue)
- [team_msdyn_dataexport](#BKMK_team_msdyn_dataexport)
- [team_msdyn_delegation](#BKMK_team_msdyn_delegation)
- [team_msdyn_estimate](#BKMK_team_msdyn_estimate)
- [team_msdyn_estimateline](#BKMK_team_msdyn_estimateline)
- [team_msdyn_expense](#BKMK_team_msdyn_expense)
- [team_msdyn_expensereceipt](#BKMK_team_msdyn_expensereceipt)
- [team_msdyn_fact](#BKMK_team_msdyn_fact)
- [team_msdyn_fieldcomputation](#BKMK_team_msdyn_fieldcomputation)
- [team_msdyn_findworkevent](#BKMK_team_msdyn_findworkevent)
- [team_msdyn_integrationjob](#BKMK_team_msdyn_integrationjob)
- [team_msdyn_integrationjobdetail](#BKMK_team_msdyn_integrationjobdetail)
- [team_msdyn_invoicelinetransaction](#BKMK_team_msdyn_invoicelinetransaction)
- [team_msdyn_journal](#BKMK_team_msdyn_journal)
- [team_msdyn_journalline](#BKMK_team_msdyn_journalline)
- [team_msdyn_opportunitylineresourcecategory](#BKMK_team_msdyn_opportunitylineresourcecategory)
- [team_msdyn_opportunitylinetransaction](#BKMK_team_msdyn_opportunitylinetransaction)
- [team_msdyn_opportunitylinetransactioncategory](#BKMK_team_msdyn_opportunitylinetransactioncategory)
- [team_msdyn_opportunitylinetransactionclassificatio](#BKMK_team_msdyn_opportunitylinetransactionclassificatio)
- [team_msdyn_opportunitypricelist](#BKMK_team_msdyn_opportunitypricelist)
- [team_msdyn_orderlineresourcecategory](#BKMK_team_msdyn_orderlineresourcecategory)
- [team_msdyn_orderlinetransaction](#BKMK_team_msdyn_orderlinetransaction)
- [team_msdyn_orderlinetransactioncategory](#BKMK_team_msdyn_orderlinetransactioncategory)
- [team_msdyn_orderlinetransactionclassification](#BKMK_team_msdyn_orderlinetransactionclassification)
- [team_msdyn_orderpricelist](#BKMK_team_msdyn_orderpricelist)
- [team_msdyn_project](#BKMK_team_msdyn_project)
- [team_msdyn_projectapproval](#BKMK_team_msdyn_projectapproval)
- [team_msdyn_projectpricelist](#BKMK_team_msdyn_projectpricelist)
- [team_msdyn_projecttask](#BKMK_team_msdyn_projecttask)
- [team_msdyn_projecttaskdependency](#BKMK_team_msdyn_projecttaskdependency)
- [team_msdyn_projecttaskstatususer](#BKMK_team_msdyn_projecttaskstatususer)
- [team_msdyn_projectteam](#BKMK_team_msdyn_projectteam)
- [team_msdyn_projecttransactioncategory](#BKMK_team_msdyn_projecttransactioncategory)
- [team_msdyn_quotelineanalyticsbreakdown](#BKMK_team_msdyn_quotelineanalyticsbreakdown)
- [team_msdyn_quotelineresourcecategory](#BKMK_team_msdyn_quotelineresourcecategory)
- [team_msdyn_quotelinescheduleofvalue](#BKMK_team_msdyn_quotelinescheduleofvalue)
- [team_msdyn_quotelinetransaction](#BKMK_team_msdyn_quotelinetransaction)
- [team_msdyn_quotelinetransactioncategory](#BKMK_team_msdyn_quotelinetransactioncategory)
- [team_msdyn_quotelinetransactionclassification](#BKMK_team_msdyn_quotelinetransactionclassification)
- [team_msdyn_quotepricelist](#BKMK_team_msdyn_quotepricelist)
- [team_msdyn_resourceassignment](#BKMK_team_msdyn_resourceassignment)
- [team_msdyn_resourceassignmentdetail](#BKMK_team_msdyn_resourceassignmentdetail)
- [team_msdyn_resourcerequest](#BKMK_team_msdyn_resourcerequest)
- [team_msdyn_rolecompetencyrequirement](#BKMK_team_msdyn_rolecompetencyrequirement)
- [team_msdyn_roleutilization](#BKMK_team_msdyn_roleutilization)
- [team_msdyn_timeentry](#BKMK_team_msdyn_timeentry)
- [team_msdyn_timeoffcalendar](#BKMK_team_msdyn_timeoffcalendar)
- [team_msdyn_transactionconnection](#BKMK_team_msdyn_transactionconnection)
- [team_msdyn_userworkhistory](#BKMK_team_msdyn_userworkhistory)
- [msdyn_team_msdyn_project_projectteamid](#BKMK_msdyn_team_msdyn_project_projectteamid)
- [team_msdyn_agreement](#BKMK_team_msdyn_agreement)
- [team_msdyn_agreementbookingdate](#BKMK_team_msdyn_agreementbookingdate)
- [team_msdyn_agreementbookingincident](#BKMK_team_msdyn_agreementbookingincident)
- [team_msdyn_agreementbookingproduct](#BKMK_team_msdyn_agreementbookingproduct)
- [team_msdyn_agreementbookingservice](#BKMK_team_msdyn_agreementbookingservice)
- [team_msdyn_agreementbookingservicetask](#BKMK_team_msdyn_agreementbookingservicetask)
- [team_msdyn_agreementbookingsetup](#BKMK_team_msdyn_agreementbookingsetup)
- [team_msdyn_agreementinvoicedate](#BKMK_team_msdyn_agreementinvoicedate)
- [team_msdyn_agreementinvoiceproduct](#BKMK_team_msdyn_agreementinvoiceproduct)
- [team_msdyn_agreementinvoicesetup](#BKMK_team_msdyn_agreementinvoicesetup)
- [team_msdyn_agreementsubstatus](#BKMK_team_msdyn_agreementsubstatus)
- [team_msdyn_bookingjournal](#BKMK_team_msdyn_bookingjournal)
- [team_msdyn_bookingtimestamp](#BKMK_team_msdyn_bookingtimestamp)
- [team_msdyn_customerasset](#BKMK_team_msdyn_customerasset)
- [team_msdyn_fieldservicesetting](#BKMK_team_msdyn_fieldservicesetting)
- [team_msdyn_incidenttype](#BKMK_team_msdyn_incidenttype)
- [team_msdyn_incidenttypecharacteristic](#BKMK_team_msdyn_incidenttypecharacteristic)
- [team_msdyn_incidenttypeproduct](#BKMK_team_msdyn_incidenttypeproduct)
- [team_msdyn_incidenttypeservice](#BKMK_team_msdyn_incidenttypeservice)
- [team_msdyn_incidenttypeservicetask](#BKMK_team_msdyn_incidenttypeservicetask)
- [team_msdyn_inventoryadjustment](#BKMK_team_msdyn_inventoryadjustment)
- [team_msdyn_inventoryadjustmentproduct](#BKMK_team_msdyn_inventoryadjustmentproduct)
- [team_msdyn_inventoryjournal](#BKMK_team_msdyn_inventoryjournal)
- [team_msdyn_inventorytransfer](#BKMK_team_msdyn_inventorytransfer)
- [team_msdyn_orderinvoicingdate](#BKMK_team_msdyn_orderinvoicingdate)
- [team_msdyn_orderinvoicingproduct](#BKMK_team_msdyn_orderinvoicingproduct)
- [team_msdyn_orderinvoicingsetup](#BKMK_team_msdyn_orderinvoicingsetup)
- [team_msdyn_orderinvoicingsetupdate](#BKMK_team_msdyn_orderinvoicingsetupdate)
- [team_msdyn_payment](#BKMK_team_msdyn_payment)
- [team_msdyn_paymentdetail](#BKMK_team_msdyn_paymentdetail)
- [team_msdyn_paymentmethod](#BKMK_team_msdyn_paymentmethod)
- [team_msdyn_paymentterm](#BKMK_team_msdyn_paymentterm)
- [team_msdyn_postalcode](#BKMK_team_msdyn_postalcode)
- [team_msdyn_purchaseorder](#BKMK_team_msdyn_purchaseorder)
- [team_msdyn_purchaseorderbill](#BKMK_team_msdyn_purchaseorderbill)
- [team_msdyn_purchaseorderproduct](#BKMK_team_msdyn_purchaseorderproduct)
- [team_msdyn_purchaseorderreceipt](#BKMK_team_msdyn_purchaseorderreceipt)
- [team_msdyn_purchaseorderreceiptproduct](#BKMK_team_msdyn_purchaseorderreceiptproduct)
- [team_msdyn_purchaseordersubstatus](#BKMK_team_msdyn_purchaseordersubstatus)
- [team_msdyn_quotebookingincident](#BKMK_team_msdyn_quotebookingincident)
- [team_msdyn_quotebookingproduct](#BKMK_team_msdyn_quotebookingproduct)
- [team_msdyn_quotebookingservice](#BKMK_team_msdyn_quotebookingservice)
- [team_msdyn_quotebookingservicetask](#BKMK_team_msdyn_quotebookingservicetask)
- [team_msdyn_quotebookingsetup](#BKMK_team_msdyn_quotebookingsetup)
- [team_msdyn_quoteinvoicingproduct](#BKMK_team_msdyn_quoteinvoicingproduct)
- [team_msdyn_quoteinvoicingsetup](#BKMK_team_msdyn_quoteinvoicingsetup)
- [team_msdyn_resourcepaytype](#BKMK_team_msdyn_resourcepaytype)
- [team_msdyn_rma](#BKMK_team_msdyn_rma)
- [team_msdyn_rmaproduct](#BKMK_team_msdyn_rmaproduct)
- [team_msdyn_rmareceipt](#BKMK_team_msdyn_rmareceipt)
- [team_msdyn_rmareceiptproduct](#BKMK_team_msdyn_rmareceiptproduct)
- [team_msdyn_rmasubstatus](#BKMK_team_msdyn_rmasubstatus)
- [team_msdyn_rtv](#BKMK_team_msdyn_rtv)
- [team_msdyn_rtvproduct](#BKMK_team_msdyn_rtvproduct)
- [team_msdyn_rtvsubstatus](#BKMK_team_msdyn_rtvsubstatus)
- [team_msdyn_servicetasktype](#BKMK_team_msdyn_servicetasktype)
- [team_msdyn_shipvia](#BKMK_team_msdyn_shipvia)
- [team_msdyn_taxcode](#BKMK_team_msdyn_taxcode)
- [team_msdyn_taxcodedetail](#BKMK_team_msdyn_taxcodedetail)
- [team_msdyn_timeoffrequest](#BKMK_team_msdyn_timeoffrequest)
- [team_msdyn_warehouse](#BKMK_team_msdyn_warehouse)
- [team_msdyn_workorder](#BKMK_team_msdyn_workorder)
- [team_msdyn_workordercharacteristic](#BKMK_team_msdyn_workordercharacteristic)
- [team_msdyn_workorderincident](#BKMK_team_msdyn_workorderincident)
- [team_msdyn_workorderproduct](#BKMK_team_msdyn_workorderproduct)
- [team_msdyn_workorderresourcerestriction](#BKMK_team_msdyn_workorderresourcerestriction)
- [team_msdyn_workorderservice](#BKMK_team_msdyn_workorderservice)
- [team_msdyn_workorderservicetask](#BKMK_team_msdyn_workorderservicetask)
- [team_msdyn_workordersubstatus](#BKMK_team_msdyn_workordersubstatus)
- [team_msdyn_workordertype](#BKMK_team_msdyn_workordertype)
- [team_principalobjectattributeaccess_principalid](#BKMK_team_principalobjectattributeaccess_principalid)
- [team_exchangesyncidmapping](#BKMK_team_exchangesyncidmapping)
- [team_interactionforemail](#BKMK_team_interactionforemail)
- [team_knowledgearticle](#BKMK_team_knowledgearticle)
- [team_sharepointsite](#BKMK_team_sharepointsite)
- [team_sharepointdocumentlocation](#BKMK_team_sharepointdocumentlocation)
- [team_goal](#BKMK_team_goal)
- [team_goalrollupquery](#BKMK_team_goalrollupquery)
- [team_mailbox](#BKMK_team_mailbox)
- [team_channelaccessprofile](#BKMK_team_channelaccessprofile)
- [team_externalparty](#BKMK_team_externalparty)
- [team_profilerule](#BKMK_team_profilerule)
- [team_connections2](#BKMK_team_connections2)
- [team_slaBase](#BKMK_team_slaBase)
- [team_goal_goalowner](#BKMK_team_goal_goalowner)
- [team_principalobjectattributeaccess](#BKMK_team_principalobjectattributeaccess)
- [team_routingrule](#BKMK_team_routingrule)
- [OwningTeam_postfollows](#BKMK_OwningTeam_postfollows)
- [team_ImportMaps](#BKMK_team_ImportMaps)
- [team_recurringappointmentmaster](#BKMK_team_recurringappointmentmaster)
- [team_userentityinstancedata](#BKMK_team_userentityinstancedata)
- [team_queueitembase_workerid](#BKMK_team_queueitembase_workerid)
- [team_phonecall](#BKMK_team_phonecall)
- [team_emailserverprofile](#BKMK_team_emailserverprofile)
- [team_connections1](#BKMK_team_connections1)
- [team_actioncardusersettings](#BKMK_team_actioncardusersettings)
- [team_userqueryvisualizations](#BKMK_team_userqueryvisualizations)
- [team_userform](#BKMK_team_userform)
- [team_socialactivity](#BKMK_team_socialactivity)
- [Team_ProcessSessions](#BKMK_Team_ProcessSessions)
- [Team_DuplicateMatchingRecord](#BKMK_Team_DuplicateMatchingRecord)
- [team_userentityuisettings](#BKMK_team_userentityuisettings)
- [team_contacts](#BKMK_team_contacts)
- [Team_AsyncOperations](#BKMK_Team_AsyncOperations)
- [team_ImportLogs](#BKMK_team_ImportLogs)
- [team_workflowlog](#BKMK_team_workflowlog)
- [team_Imports](#BKMK_team_Imports)
- [team_processsession](#BKMK_team_processsession)
- [team_SyncError](#BKMK_team_SyncError)
- [team_letter](#BKMK_team_letter)
- [team_annotations](#BKMK_team_annotations)
- [team_appointment](#BKMK_team_appointment)
- [team_asyncoperation](#BKMK_team_asyncoperation)
- [userentityinstancedata_team](#BKMK_userentityinstancedata_team)
- [Team_BulkDeleteFailures](#BKMK_Team_BulkDeleteFailures)
- [team_customer_relationship](#BKMK_team_customer_relationship)
- [Team_SyncErrors](#BKMK_Team_SyncErrors)
- [team_convertrule](#BKMK_team_convertrule)
- [team_mailboxtrackingfolder](#BKMK_team_mailboxtrackingfolder)
- [team_task](#BKMK_team_task)
- [team_activity](#BKMK_team_activity)
- [Team_DuplicateBaseRecord](#BKMK_Team_DuplicateBaseRecord)
- [team_accounts](#BKMK_team_accounts)
- [team_userquery](#BKMK_team_userquery)
- [team_email](#BKMK_team_email)
- [ImportFile_Team](#BKMK_ImportFile_Team)
- [team_ImportFiles](#BKMK_team_ImportFiles)
- [team_email_templates](#BKMK_team_email_templates)
- [team_fax](#BKMK_team_fax)
- [team_routingruleitem](#BKMK_team_routingruleitem)
- [team_DuplicateRules](#BKMK_team_DuplicateRules)
- [team_workflow](#BKMK_team_workflow)


### <a name="BKMK_team_msdyn_iotalert"></a> team_msdyn_iotalert

Same as msdyn_iotalert entity [team_msdyn_iotalert](msdyn_iotalert.md#BKMK_team_msdyn_iotalert) Many-To-One relationship.

**ReferencingEntity**: msdyn_iotalert<br />
**ReferencingAttribute**: owningteam<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: team_msdyn_iotalert<br />
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


### <a name="BKMK_team_msdyn_iotdevice"></a> team_msdyn_iotdevice

Same as msdyn_iotdevice entity [team_msdyn_iotdevice](msdyn_iotdevice.md#BKMK_team_msdyn_iotdevice) Many-To-One relationship.

**ReferencingEntity**: msdyn_iotdevice<br />
**ReferencingAttribute**: owningteam<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: team_msdyn_iotdevice<br />
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


### <a name="BKMK_team_msdyn_iotdevicecategory"></a> team_msdyn_iotdevicecategory

Same as msdyn_iotdevicecategory entity [team_msdyn_iotdevicecategory](msdyn_iotdevicecategory.md#BKMK_team_msdyn_iotdevicecategory) Many-To-One relationship.

**ReferencingEntity**: msdyn_iotdevicecategory<br />
**ReferencingAttribute**: owningteam<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: team_msdyn_iotdevicecategory<br />
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


### <a name="BKMK_team_msdyn_iotdevicecommand"></a> team_msdyn_iotdevicecommand

Same as msdyn_iotdevicecommand entity [team_msdyn_iotdevicecommand](msdyn_iotdevicecommand.md#BKMK_team_msdyn_iotdevicecommand) Many-To-One relationship.

**ReferencingEntity**: msdyn_iotdevicecommand<br />
**ReferencingAttribute**: owningteam<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: team_msdyn_iotdevicecommand<br />
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


### <a name="BKMK_team_msdyn_iotdeviceregistrationhistory"></a> team_msdyn_iotdeviceregistrationhistory

Same as msdyn_iotdeviceregistrationhistory entity [team_msdyn_iotdeviceregistrationhistory](msdyn_iotdeviceregistrationhistory.md#BKMK_team_msdyn_iotdeviceregistrationhistory) Many-To-One relationship.

**ReferencingEntity**: msdyn_iotdeviceregistrationhistory<br />
**ReferencingAttribute**: owningteam<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: team_msdyn_iotdeviceregistrationhistory<br />
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


### <a name="BKMK_lead_owning_team"></a> lead_owning_team

Same as lead entity [lead_owning_team](lead.md#BKMK_lead_owning_team) Many-To-One relationship.

**ReferencingEntity**: lead<br />
**ReferencingAttribute**: owningteam<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: lead_owning_team<br />
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


### <a name="BKMK_team_DynamicPropertyInstance"></a> team_DynamicPropertyInstance

Same as dynamicpropertyinstance entity [team_DynamicPropertyInstance](dynamicpropertyinstance.md#BKMK_team_DynamicPropertyInstance) Many-To-One relationship.

**ReferencingEntity**: dynamicpropertyinstance<br />
**ReferencingAttribute**: owningteam<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: team_DynamicPropertyInstance<br />
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


### <a name="BKMK_team_bookableresource"></a> team_bookableresource

Same as bookableresource entity [team_bookableresource](bookableresource.md#BKMK_team_bookableresource) Many-To-One relationship.

**ReferencingEntity**: bookableresource<br />
**ReferencingAttribute**: owningteam<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: team_bookableresource<br />
**AssociatedMenuConfiguration**:

- **Behavior**: UseCollectionName
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


### <a name="BKMK_team_bookableresourcebooking"></a> team_bookableresourcebooking

Same as bookableresourcebooking entity [team_bookableresourcebooking](bookableresourcebooking.md#BKMK_team_bookableresourcebooking) Many-To-One relationship.

**ReferencingEntity**: bookableresourcebooking<br />
**ReferencingAttribute**: owningteam<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: team_bookableresourcebooking<br />
**AssociatedMenuConfiguration**:

- **Behavior**: UseCollectionName
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


### <a name="BKMK_team_bookableresourcebookingexchangesyncidmapping"></a> team_bookableresourcebookingexchangesyncidmapping

Same as bookableresourcebookingexchangesyncidmapping entity [team_bookableresourcebookingexchangesyncidmapping](bookableresourcebookingexchangesyncidmapping.md#BKMK_team_bookableresourcebookingexchangesyncidmapping) Many-To-One relationship.

**ReferencingEntity**: bookableresourcebookingexchangesyncidmapping<br />
**ReferencingAttribute**: owningteam<br />
**IsHierarchical**: False<br />
**IsCustomizable**: False<br />
**ReferencedEntityNavigationPropertyName**: team_bookableresourcebookingexchangesyncidmapping<br />
**AssociatedMenuConfiguration**:

- **Behavior**: UseCollectionName
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


### <a name="BKMK_team_bookableresourcebookingheader"></a> team_bookableresourcebookingheader

Same as bookableresourcebookingheader entity [team_bookableresourcebookingheader](bookableresourcebookingheader.md#BKMK_team_bookableresourcebookingheader) Many-To-One relationship.

**ReferencingEntity**: bookableresourcebookingheader<br />
**ReferencingAttribute**: owningteam<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: team_bookableresourcebookingheader<br />
**AssociatedMenuConfiguration**:

- **Behavior**: UseCollectionName
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


### <a name="BKMK_team_bookableresourcecategory"></a> team_bookableresourcecategory

Same as bookableresourcecategory entity [team_bookableresourcecategory](bookableresourcecategory.md#BKMK_team_bookableresourcecategory) Many-To-One relationship.

**ReferencingEntity**: bookableresourcecategory<br />
**ReferencingAttribute**: owningteam<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: team_bookableresourcecategory<br />
**AssociatedMenuConfiguration**:

- **Behavior**: UseCollectionName
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


### <a name="BKMK_team_bookableresourcecategoryassn"></a> team_bookableresourcecategoryassn

Same as bookableresourcecategoryassn entity [team_bookableresourcecategoryassn](bookableresourcecategoryassn.md#BKMK_team_bookableresourcecategoryassn) Many-To-One relationship.

**ReferencingEntity**: bookableresourcecategoryassn<br />
**ReferencingAttribute**: owningteam<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: team_bookableresourcecategoryassn<br />
**AssociatedMenuConfiguration**:

- **Behavior**: UseCollectionName
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


### <a name="BKMK_team_bookableresourcecharacteristic"></a> team_bookableresourcecharacteristic

Same as bookableresourcecharacteristic entity [team_bookableresourcecharacteristic](bookableresourcecharacteristic.md#BKMK_team_bookableresourcecharacteristic) Many-To-One relationship.

**ReferencingEntity**: bookableresourcecharacteristic<br />
**ReferencingAttribute**: owningteam<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: team_bookableresourcecharacteristic<br />
**AssociatedMenuConfiguration**:

- **Behavior**: UseCollectionName
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


### <a name="BKMK_team_bookableresourcegroup"></a> team_bookableresourcegroup

Same as bookableresourcegroup entity [team_bookableresourcegroup](bookableresourcegroup.md#BKMK_team_bookableresourcegroup) Many-To-One relationship.

**ReferencingEntity**: bookableresourcegroup<br />
**ReferencingAttribute**: owningteam<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: team_bookableresourcegroup<br />
**AssociatedMenuConfiguration**:

- **Behavior**: UseCollectionName
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


### <a name="BKMK_team_bookingstatus"></a> team_bookingstatus

Same as bookingstatus entity [team_bookingstatus](bookingstatus.md#BKMK_team_bookingstatus) Many-To-One relationship.

**ReferencingEntity**: bookingstatus<br />
**ReferencingAttribute**: owningteam<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: team_bookingstatus<br />
**AssociatedMenuConfiguration**:

- **Behavior**: UseCollectionName
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


### <a name="BKMK_team_characteristic"></a> team_characteristic

Same as characteristic entity [team_characteristic](characteristic.md#BKMK_team_characteristic) Many-To-One relationship.

**ReferencingEntity**: characteristic<br />
**ReferencingAttribute**: owningteam<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: team_characteristic<br />
**AssociatedMenuConfiguration**:

- **Behavior**: UseCollectionName
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


### <a name="BKMK_team_ratingmodel"></a> team_ratingmodel

Same as ratingmodel entity [team_ratingmodel](ratingmodel.md#BKMK_team_ratingmodel) Many-To-One relationship.

**ReferencingEntity**: ratingmodel<br />
**ReferencingAttribute**: owningteam<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: team_ratingmodel<br />
**AssociatedMenuConfiguration**:

- **Behavior**: UseCollectionName
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


### <a name="BKMK_team_ratingvalue"></a> team_ratingvalue

Same as ratingvalue entity [team_ratingvalue](ratingvalue.md#BKMK_team_ratingvalue) Many-To-One relationship.

**ReferencingEntity**: ratingvalue<br />
**ReferencingAttribute**: owningteam<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: team_ratingvalue<br />
**AssociatedMenuConfiguration**:

- **Behavior**: UseCollectionName
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


### <a name="BKMK_team_BulkOperation"></a> team_BulkOperation

Same as bulkoperation entity [team_BulkOperation](bulkoperation.md#BKMK_team_BulkOperation) Many-To-One relationship.

**ReferencingEntity**: bulkoperation<br />
**ReferencingAttribute**: owningteam<br />
**IsHierarchical**: False<br />
**IsCustomizable**: False<br />
**ReferencedEntityNavigationPropertyName**: team_BulkOperation<br />
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


### <a name="BKMK_team_bulkoperationlog"></a> team_bulkoperationlog

Same as bulkoperationlog entity [team_bulkoperationlog](bulkoperationlog.md#BKMK_team_bulkoperationlog) Many-To-One relationship.

**ReferencingEntity**: bulkoperationlog<br />
**ReferencingAttribute**: owningteam<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: team_bulkoperationlog<br />
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


### <a name="BKMK_team_Campaigns"></a> team_Campaigns

Same as campaign entity [team_Campaigns](campaign.md#BKMK_team_Campaigns) Many-To-One relationship.

**ReferencingEntity**: campaign<br />
**ReferencingAttribute**: owningteam<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: team_Campaigns<br />
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


### <a name="BKMK_team_campaignactivity"></a> team_campaignactivity

Same as campaignactivity entity [team_campaignactivity](campaignactivity.md#BKMK_team_campaignactivity) Many-To-One relationship.

**ReferencingEntity**: campaignactivity<br />
**ReferencingAttribute**: owningteam<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: team_campaignactivity<br />
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


### <a name="BKMK_team_campaignresponse"></a> team_campaignresponse

Same as campaignresponse entity [team_campaignresponse](campaignresponse.md#BKMK_team_campaignresponse) Many-To-One relationship.

**ReferencingEntity**: campaignresponse<br />
**ReferencingAttribute**: owningteam<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: team_campaignresponse<br />
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


### <a name="BKMK_team_list"></a> team_list

Same as list entity [team_list](list.md#BKMK_team_list) Many-To-One relationship.

**ReferencingEntity**: list<br />
**ReferencingAttribute**: owningteam<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: team_list<br />
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


### <a name="BKMK_team_service_contracts"></a> team_service_contracts

Same as contract entity [team_service_contracts](contract.md#BKMK_team_service_contracts) Many-To-One relationship.

**ReferencingEntity**: contract<br />
**ReferencingAttribute**: owningteam<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: team_service_contracts<br />
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


### <a name="BKMK_team_contractdetail"></a> team_contractdetail

Same as contractdetail entity [team_contractdetail](contractdetail.md#BKMK_team_contractdetail) Many-To-One relationship.

**ReferencingEntity**: contractdetail<br />
**ReferencingAttribute**: owningteam<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: team_contractdetail<br />
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


### <a name="BKMK_team_entitlement"></a> team_entitlement

Same as entitlement entity [team_entitlement](entitlement.md#BKMK_team_entitlement) Many-To-One relationship.

**ReferencingEntity**: entitlement<br />
**ReferencingAttribute**: owningteam<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: team_entitlement<br />
**AssociatedMenuConfiguration**:

- **Behavior**: UseCollectionName
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


### <a name="BKMK_team_entitlementchannel"></a> team_entitlementchannel

Same as entitlementchannel entity [team_entitlementchannel](entitlementchannel.md#BKMK_team_entitlementchannel) Many-To-One relationship.

**ReferencingEntity**: entitlementchannel<br />
**ReferencingAttribute**: owningteam<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: team_entitlementchannel<br />
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


### <a name="BKMK_team_incidents"></a> team_incidents

Same as incident entity [team_incidents](incident.md#BKMK_team_incidents) Many-To-One relationship.

**ReferencingEntity**: incident<br />
**ReferencingAttribute**: owningteam<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: team_incidents<br />
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


### <a name="BKMK_team_incidentresolution"></a> team_incidentresolution

Same as incidentresolution entity [team_incidentresolution](incidentresolution.md#BKMK_team_incidentresolution) Many-To-One relationship.

**ReferencingEntity**: incidentresolution<br />
**ReferencingAttribute**: owningteam<br />
**IsHierarchical**: False<br />
**IsCustomizable**: False<br />
**ReferencedEntityNavigationPropertyName**: team_incidentresolution<br />
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


### <a name="BKMK_team_knowledgearticleincident"></a> team_knowledgearticleincident

Same as knowledgearticleincident entity [team_knowledgearticleincident](knowledgearticleincident.md#BKMK_team_knowledgearticleincident) Many-To-One relationship.

**ReferencingEntity**: knowledgearticleincident<br />
**ReferencingAttribute**: owningteam<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: team_knowledgearticleincident<br />
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


### <a name="BKMK_team_service_appointments"></a> team_service_appointments

Same as serviceappointment entity [team_service_appointments](serviceappointment.md#BKMK_team_service_appointments) Many-To-One relationship.

**ReferencingEntity**: serviceappointment<br />
**ReferencingAttribute**: owningteam<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: team_service_appointments<br />
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


### <a name="BKMK_team_resource_specs"></a> team_resource_specs

Same as resourcespec entity [team_resource_specs](resourcespec.md#BKMK_team_resource_specs) Many-To-One relationship.

**ReferencingEntity**: resourcespec<br />
**ReferencingAttribute**: groupobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: False<br />
**ReferencedEntityNavigationPropertyName**: team_resource_specs<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: Restrict
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_team_resource_groups"></a> team_resource_groups

Same as resourcegroup entity [team_resource_groups](resourcegroup.md#BKMK_team_resource_groups) Many-To-One relationship.

**ReferencingEntity**: resourcegroup<br />
**ReferencingAttribute**: resourcegroupid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: False<br />
**ReferencedEntityNavigationPropertyName**: team_resource_groups<br />
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


### <a name="BKMK_team_customer_opportunity_roles"></a> team_customer_opportunity_roles

Same as customeropportunityrole entity [team_customer_opportunity_roles](customeropportunityrole.md#BKMK_team_customer_opportunity_roles) Many-To-One relationship.

**ReferencingEntity**: customeropportunityrole<br />
**ReferencingAttribute**: owningteam<br />
**IsHierarchical**: False<br />
**IsCustomizable**: False<br />
**ReferencedEntityNavigationPropertyName**: team_customer_opportunity_roles<br />
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


### <a name="BKMK_team_invoices"></a> team_invoices

Same as invoice entity [team_invoices](invoice.md#BKMK_team_invoices) Many-To-One relationship.

**ReferencingEntity**: invoice<br />
**ReferencingAttribute**: owningteam<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: team_invoices<br />
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


### <a name="BKMK_team_invoicedetail"></a> team_invoicedetail

Same as invoicedetail entity [team_invoicedetail](invoicedetail.md#BKMK_team_invoicedetail) Many-To-One relationship.

**ReferencingEntity**: invoicedetail<br />
**ReferencingAttribute**: owningteam<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: team_invoicedetail<br />
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


### <a name="BKMK_team_opportunities"></a> team_opportunities

Same as opportunity entity [team_opportunities](opportunity.md#BKMK_team_opportunities) Many-To-One relationship.

**ReferencingEntity**: opportunity<br />
**ReferencingAttribute**: owningteam<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: team_opportunities<br />
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


### <a name="BKMK_team_opportunityclose"></a> team_opportunityclose

Same as opportunityclose entity [team_opportunityclose](opportunityclose.md#BKMK_team_opportunityclose) Many-To-One relationship.

**ReferencingEntity**: opportunityclose<br />
**ReferencingAttribute**: owningteam<br />
**IsHierarchical**: False<br />
**IsCustomizable**: False<br />
**ReferencedEntityNavigationPropertyName**: team_opportunityclose<br />
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


### <a name="BKMK_team_opportunityproduct"></a> team_opportunityproduct

Same as opportunityproduct entity [team_opportunityproduct](opportunityproduct.md#BKMK_team_opportunityproduct) Many-To-One relationship.

**ReferencingEntity**: opportunityproduct<br />
**ReferencingAttribute**: owningteam<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: team_opportunityproduct<br />
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


### <a name="BKMK_team_orderclose"></a> team_orderclose

Same as orderclose entity [team_orderclose](orderclose.md#BKMK_team_orderclose) Many-To-One relationship.

**ReferencingEntity**: orderclose<br />
**ReferencingAttribute**: owningteam<br />
**IsHierarchical**: False<br />
**IsCustomizable**: False<br />
**ReferencedEntityNavigationPropertyName**: team_orderclose<br />
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


### <a name="BKMK_team_quotes"></a> team_quotes

Same as quote entity [team_quotes](quote.md#BKMK_team_quotes) Many-To-One relationship.

**ReferencingEntity**: quote<br />
**ReferencingAttribute**: owningteam<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: team_quotes<br />
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


### <a name="BKMK_team_quoteclose"></a> team_quoteclose

Same as quoteclose entity [team_quoteclose](quoteclose.md#BKMK_team_quoteclose) Many-To-One relationship.

**ReferencingEntity**: quoteclose<br />
**ReferencingAttribute**: owningteam<br />
**IsHierarchical**: False<br />
**IsCustomizable**: False<br />
**ReferencedEntityNavigationPropertyName**: team_quoteclose<br />
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


### <a name="BKMK_team_quotedetail"></a> team_quotedetail

Same as quotedetail entity [team_quotedetail](quotedetail.md#BKMK_team_quotedetail) Many-To-One relationship.

**ReferencingEntity**: quotedetail<br />
**ReferencingAttribute**: owningteam<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: team_quotedetail<br />
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


### <a name="BKMK_team_orders"></a> team_orders

Same as salesorder entity [team_orders](salesorder.md#BKMK_team_orders) Many-To-One relationship.

**ReferencingEntity**: salesorder<br />
**ReferencingAttribute**: owningteam<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: team_orders<br />
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


### <a name="BKMK_team_salesorderdetail"></a> team_salesorderdetail

Same as salesorderdetail entity [team_salesorderdetail](salesorderdetail.md#BKMK_team_salesorderdetail) Many-To-One relationship.

**ReferencingEntity**: salesorderdetail<br />
**ReferencingAttribute**: owningteam<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: team_salesorderdetail<br />
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


### <a name="BKMK_team_msdyn_postalbum"></a> team_msdyn_postalbum

Same as msdyn_postalbum entity [team_msdyn_postalbum](msdyn_postalbum.md#BKMK_team_msdyn_postalbum) Many-To-One relationship.

**ReferencingEntity**: msdyn_postalbum<br />
**ReferencingAttribute**: owningteam<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: team_msdyn_postalbum<br />
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


### <a name="BKMK_team_msdyn_wallsavedqueryusersettings"></a> team_msdyn_wallsavedqueryusersettings

Same as msdyn_wallsavedqueryusersettings entity [team_msdyn_wallsavedqueryusersettings](msdyn_wallsavedqueryusersettings.md#BKMK_team_msdyn_wallsavedqueryusersettings) Many-To-One relationship.

**ReferencingEntity**: msdyn_wallsavedqueryusersettings<br />
**ReferencingAttribute**: owningteam<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: team_msdyn_wallsavedqueryusersettings<br />
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


### <a name="BKMK_team_msdyn_actual"></a> team_msdyn_actual

Same as msdyn_actual entity [team_msdyn_actual](msdyn_actual.md#BKMK_team_msdyn_actual) Many-To-One relationship.

**ReferencingEntity**: msdyn_actual<br />
**ReferencingAttribute**: owningteam<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: team_msdyn_actual<br />
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


### <a name="BKMK_msdyn_bookingalert_team_owningteam"></a> msdyn_bookingalert_team_owningteam

Same as msdyn_bookingalert entity [msdyn_bookingalert_team_owningteam](msdyn_bookingalert.md#BKMK_msdyn_bookingalert_team_owningteam) Many-To-One relationship.

**ReferencingEntity**: msdyn_bookingalert<br />
**ReferencingAttribute**: owningteam<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_bookingalert_team_owningteam<br />
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


### <a name="BKMK_team_msdyn_bookingalertstatus"></a> team_msdyn_bookingalertstatus

Same as msdyn_bookingalertstatus entity [team_msdyn_bookingalertstatus](msdyn_bookingalertstatus.md#BKMK_team_msdyn_bookingalertstatus) Many-To-One relationship.

**ReferencingEntity**: msdyn_bookingalertstatus<br />
**ReferencingAttribute**: owningteam<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: team_msdyn_bookingalertstatus<br />
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


### <a name="BKMK_team_msdyn_bookingchange"></a> team_msdyn_bookingchange

Same as msdyn_bookingchange entity [team_msdyn_bookingchange](msdyn_bookingchange.md#BKMK_team_msdyn_bookingchange) Many-To-One relationship.

**ReferencingEntity**: msdyn_bookingchange<br />
**ReferencingAttribute**: owningteam<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: team_msdyn_bookingchange<br />
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


### <a name="BKMK_team_msdyn_bookingrule"></a> team_msdyn_bookingrule

Same as msdyn_bookingrule entity [team_msdyn_bookingrule](msdyn_bookingrule.md#BKMK_team_msdyn_bookingrule) Many-To-One relationship.

**ReferencingEntity**: msdyn_bookingrule<br />
**ReferencingAttribute**: owningteam<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: team_msdyn_bookingrule<br />
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


### <a name="BKMK_team_msdyn_bookingsetupmetadata"></a> team_msdyn_bookingsetupmetadata

Same as msdyn_bookingsetupmetadata entity [team_msdyn_bookingsetupmetadata](msdyn_bookingsetupmetadata.md#BKMK_team_msdyn_bookingsetupmetadata) Many-To-One relationship.

**ReferencingEntity**: msdyn_bookingsetupmetadata<br />
**ReferencingAttribute**: owningteam<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: team_msdyn_bookingsetupmetadata<br />
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


### <a name="BKMK_team_msdyn_clientextension"></a> team_msdyn_clientextension

Same as msdyn_clientextension entity [team_msdyn_clientextension](msdyn_clientextension.md#BKMK_team_msdyn_clientextension) Many-To-One relationship.

**ReferencingEntity**: msdyn_clientextension<br />
**ReferencingAttribute**: owningteam<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: team_msdyn_clientextension<br />
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


### <a name="BKMK_team_msdyn_configuration"></a> team_msdyn_configuration

Same as msdyn_configuration entity [team_msdyn_configuration](msdyn_configuration.md#BKMK_team_msdyn_configuration) Many-To-One relationship.

**ReferencingEntity**: msdyn_configuration<br />
**ReferencingAttribute**: owningteam<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: team_msdyn_configuration<br />
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


### <a name="BKMK_team_msdyn_priority"></a> team_msdyn_priority

Same as msdyn_priority entity [team_msdyn_priority](msdyn_priority.md#BKMK_team_msdyn_priority) Many-To-One relationship.

**ReferencingEntity**: msdyn_priority<br />
**ReferencingAttribute**: owningteam<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: team_msdyn_priority<br />
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


### <a name="BKMK_team_msdyn_requirementcharacteristic"></a> team_msdyn_requirementcharacteristic

Same as msdyn_requirementcharacteristic entity [team_msdyn_requirementcharacteristic](msdyn_requirementcharacteristic.md#BKMK_team_msdyn_requirementcharacteristic) Many-To-One relationship.

**ReferencingEntity**: msdyn_requirementcharacteristic<br />
**ReferencingAttribute**: owningteam<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: team_msdyn_requirementcharacteristic<br />
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


### <a name="BKMK_team_msdyn_requirementorganizationunit"></a> team_msdyn_requirementorganizationunit

Same as msdyn_requirementorganizationunit entity [team_msdyn_requirementorganizationunit](msdyn_requirementorganizationunit.md#BKMK_team_msdyn_requirementorganizationunit) Many-To-One relationship.

**ReferencingEntity**: msdyn_requirementorganizationunit<br />
**ReferencingAttribute**: owningteam<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: team_msdyn_requirementorganizationunit<br />
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


### <a name="BKMK_team_msdyn_requirementresourcecategory"></a> team_msdyn_requirementresourcecategory

Same as msdyn_requirementresourcecategory entity [team_msdyn_requirementresourcecategory](msdyn_requirementresourcecategory.md#BKMK_team_msdyn_requirementresourcecategory) Many-To-One relationship.

**ReferencingEntity**: msdyn_requirementresourcecategory<br />
**ReferencingAttribute**: owningteam<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: team_msdyn_requirementresourcecategory<br />
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


### <a name="BKMK_team_msdyn_requirementresourcepreference"></a> team_msdyn_requirementresourcepreference

Same as msdyn_requirementresourcepreference entity [team_msdyn_requirementresourcepreference](msdyn_requirementresourcepreference.md#BKMK_team_msdyn_requirementresourcepreference) Many-To-One relationship.

**ReferencingEntity**: msdyn_requirementresourcepreference<br />
**ReferencingAttribute**: owningteam<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: team_msdyn_requirementresourcepreference<br />
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


### <a name="BKMK_team_msdyn_requirementstatus"></a> team_msdyn_requirementstatus

Same as msdyn_requirementstatus entity [team_msdyn_requirementstatus](msdyn_requirementstatus.md#BKMK_team_msdyn_requirementstatus) Many-To-One relationship.

**ReferencingEntity**: msdyn_requirementstatus<br />
**ReferencingAttribute**: owningteam<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: team_msdyn_requirementstatus<br />
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


### <a name="BKMK_team_msdyn_resourcerequirement"></a> team_msdyn_resourcerequirement

Same as msdyn_resourcerequirement entity [team_msdyn_resourcerequirement](msdyn_resourcerequirement.md#BKMK_team_msdyn_resourcerequirement) Many-To-One relationship.

**ReferencingEntity**: msdyn_resourcerequirement<br />
**ReferencingAttribute**: owningteam<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: team_msdyn_resourcerequirement<br />
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


### <a name="BKMK_team_msdyn_resourcerequirementdetail"></a> team_msdyn_resourcerequirementdetail

Same as msdyn_resourcerequirementdetail entity [team_msdyn_resourcerequirementdetail](msdyn_resourcerequirementdetail.md#BKMK_team_msdyn_resourcerequirementdetail) Many-To-One relationship.

**ReferencingEntity**: msdyn_resourcerequirementdetail<br />
**ReferencingAttribute**: owningteam<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: team_msdyn_resourcerequirementdetail<br />
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


### <a name="BKMK_team_msdyn_resourceterritory"></a> team_msdyn_resourceterritory

Same as msdyn_resourceterritory entity [team_msdyn_resourceterritory](msdyn_resourceterritory.md#BKMK_team_msdyn_resourceterritory) Many-To-One relationship.

**ReferencingEntity**: msdyn_resourceterritory<br />
**ReferencingAttribute**: owningteam<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: team_msdyn_resourceterritory<br />
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


### <a name="BKMK_team_msdyn_scheduleboardsetting"></a> team_msdyn_scheduleboardsetting

Same as msdyn_scheduleboardsetting entity [team_msdyn_scheduleboardsetting](msdyn_scheduleboardsetting.md#BKMK_team_msdyn_scheduleboardsetting) Many-To-One relationship.

**ReferencingEntity**: msdyn_scheduleboardsetting<br />
**ReferencingAttribute**: owningteam<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: team_msdyn_scheduleboardsetting<br />
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


### <a name="BKMK_team_msdyn_systemuserschedulersetting"></a> team_msdyn_systemuserschedulersetting

Same as msdyn_systemuserschedulersetting entity [team_msdyn_systemuserschedulersetting](msdyn_systemuserschedulersetting.md#BKMK_team_msdyn_systemuserschedulersetting) Many-To-One relationship.

**ReferencingEntity**: msdyn_systemuserschedulersetting<br />
**ReferencingAttribute**: owningteam<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: team_msdyn_systemuserschedulersetting<br />
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


### <a name="BKMK_team_msdyn_timegroup"></a> team_msdyn_timegroup

Same as msdyn_timegroup entity [team_msdyn_timegroup](msdyn_timegroup.md#BKMK_team_msdyn_timegroup) Many-To-One relationship.

**ReferencingEntity**: msdyn_timegroup<br />
**ReferencingAttribute**: owningteam<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: team_msdyn_timegroup<br />
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


### <a name="BKMK_team_msdyn_timegroupdetail"></a> team_msdyn_timegroupdetail

Same as msdyn_timegroupdetail entity [team_msdyn_timegroupdetail](msdyn_timegroupdetail.md#BKMK_team_msdyn_timegroupdetail) Many-To-One relationship.

**ReferencingEntity**: msdyn_timegroupdetail<br />
**ReferencingAttribute**: owningteam<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: team_msdyn_timegroupdetail<br />
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


### <a name="BKMK_team_msdyn_transactionorigin"></a> team_msdyn_transactionorigin

Same as msdyn_transactionorigin entity [team_msdyn_transactionorigin](msdyn_transactionorigin.md#BKMK_team_msdyn_transactionorigin) Many-To-One relationship.

**ReferencingEntity**: msdyn_transactionorigin<br />
**ReferencingAttribute**: owningteam<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: team_msdyn_transactionorigin<br />
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


### <a name="BKMK_team_msdyn_workhourtemplate"></a> team_msdyn_workhourtemplate

Same as msdyn_workhourtemplate entity [team_msdyn_workhourtemplate](msdyn_workhourtemplate.md#BKMK_team_msdyn_workhourtemplate) Many-To-One relationship.

**ReferencingEntity**: msdyn_workhourtemplate<br />
**ReferencingAttribute**: owningteam<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: team_msdyn_workhourtemplate<br />
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


### <a name="BKMK_team_msdyn_accountpricelist"></a> team_msdyn_accountpricelist

Same as msdyn_accountpricelist entity [team_msdyn_accountpricelist](msdyn_accountpricelist.md#BKMK_team_msdyn_accountpricelist) Many-To-One relationship.

**ReferencingEntity**: msdyn_accountpricelist<br />
**ReferencingAttribute**: owningteam<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: team_msdyn_accountpricelist<br />
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


### <a name="BKMK_msdyn_approval_team_owningteam"></a> msdyn_approval_team_owningteam

Same as msdyn_approval entity [msdyn_approval_team_owningteam](msdyn_approval.md#BKMK_msdyn_approval_team_owningteam) Many-To-One relationship.

**ReferencingEntity**: msdyn_approval<br />
**ReferencingAttribute**: owningteam<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_approval_team_owningteam<br />
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


### <a name="BKMK_team_msdyn_characteristicreqforteammember"></a> team_msdyn_characteristicreqforteammember

Same as msdyn_characteristicreqforteammember entity [team_msdyn_characteristicreqforteammember](msdyn_characteristicreqforteammember.md#BKMK_team_msdyn_characteristicreqforteammember) Many-To-One relationship.

**ReferencingEntity**: msdyn_characteristicreqforteammember<br />
**ReferencingAttribute**: owningteam<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: team_msdyn_characteristicreqforteammember<br />
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


### <a name="BKMK_team_msdyn_contactpricelist"></a> team_msdyn_contactpricelist

Same as msdyn_contactpricelist entity [team_msdyn_contactpricelist](msdyn_contactpricelist.md#BKMK_team_msdyn_contactpricelist) Many-To-One relationship.

**ReferencingEntity**: msdyn_contactpricelist<br />
**ReferencingAttribute**: owningteam<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: team_msdyn_contactpricelist<br />
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


### <a name="BKMK_team_msdyn_contractlinescheduleofvalue"></a> team_msdyn_contractlinescheduleofvalue

Same as msdyn_contractlinescheduleofvalue entity [team_msdyn_contractlinescheduleofvalue](msdyn_contractlinescheduleofvalue.md#BKMK_team_msdyn_contractlinescheduleofvalue) Many-To-One relationship.

**ReferencingEntity**: msdyn_contractlinescheduleofvalue<br />
**ReferencingAttribute**: owningteam<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: team_msdyn_contractlinescheduleofvalue<br />
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


### <a name="BKMK_team_msdyn_dataexport"></a> team_msdyn_dataexport

Same as msdyn_dataexport entity [team_msdyn_dataexport](msdyn_dataexport.md#BKMK_team_msdyn_dataexport) Many-To-One relationship.

**ReferencingEntity**: msdyn_dataexport<br />
**ReferencingAttribute**: owningteam<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: team_msdyn_dataexport<br />
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


### <a name="BKMK_team_msdyn_delegation"></a> team_msdyn_delegation

Same as msdyn_delegation entity [team_msdyn_delegation](msdyn_delegation.md#BKMK_team_msdyn_delegation) Many-To-One relationship.

**ReferencingEntity**: msdyn_delegation<br />
**ReferencingAttribute**: owningteam<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: team_msdyn_delegation<br />
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


### <a name="BKMK_team_msdyn_estimate"></a> team_msdyn_estimate

Same as msdyn_estimate entity [team_msdyn_estimate](msdyn_estimate.md#BKMK_team_msdyn_estimate) Many-To-One relationship.

**ReferencingEntity**: msdyn_estimate<br />
**ReferencingAttribute**: owningteam<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: team_msdyn_estimate<br />
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


### <a name="BKMK_team_msdyn_estimateline"></a> team_msdyn_estimateline

Same as msdyn_estimateline entity [team_msdyn_estimateline](msdyn_estimateline.md#BKMK_team_msdyn_estimateline) Many-To-One relationship.

**ReferencingEntity**: msdyn_estimateline<br />
**ReferencingAttribute**: owningteam<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: team_msdyn_estimateline<br />
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


### <a name="BKMK_team_msdyn_expense"></a> team_msdyn_expense

Same as msdyn_expense entity [team_msdyn_expense](msdyn_expense.md#BKMK_team_msdyn_expense) Many-To-One relationship.

**ReferencingEntity**: msdyn_expense<br />
**ReferencingAttribute**: owningteam<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: team_msdyn_expense<br />
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


### <a name="BKMK_team_msdyn_expensereceipt"></a> team_msdyn_expensereceipt

Same as msdyn_expensereceipt entity [team_msdyn_expensereceipt](msdyn_expensereceipt.md#BKMK_team_msdyn_expensereceipt) Many-To-One relationship.

**ReferencingEntity**: msdyn_expensereceipt<br />
**ReferencingAttribute**: owningteam<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: team_msdyn_expensereceipt<br />
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


### <a name="BKMK_team_msdyn_fact"></a> team_msdyn_fact

Same as msdyn_fact entity [team_msdyn_fact](msdyn_fact.md#BKMK_team_msdyn_fact) Many-To-One relationship.

**ReferencingEntity**: msdyn_fact<br />
**ReferencingAttribute**: owningteam<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: team_msdyn_fact<br />
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


### <a name="BKMK_team_msdyn_fieldcomputation"></a> team_msdyn_fieldcomputation

Same as msdyn_fieldcomputation entity [team_msdyn_fieldcomputation](msdyn_fieldcomputation.md#BKMK_team_msdyn_fieldcomputation) Many-To-One relationship.

**ReferencingEntity**: msdyn_fieldcomputation<br />
**ReferencingAttribute**: owningteam<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: team_msdyn_fieldcomputation<br />
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


### <a name="BKMK_team_msdyn_findworkevent"></a> team_msdyn_findworkevent

Same as msdyn_findworkevent entity [team_msdyn_findworkevent](msdyn_findworkevent.md#BKMK_team_msdyn_findworkevent) Many-To-One relationship.

**ReferencingEntity**: msdyn_findworkevent<br />
**ReferencingAttribute**: owningteam<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: team_msdyn_findworkevent<br />
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


### <a name="BKMK_team_msdyn_integrationjob"></a> team_msdyn_integrationjob

Same as msdyn_integrationjob entity [team_msdyn_integrationjob](msdyn_integrationjob.md#BKMK_team_msdyn_integrationjob) Many-To-One relationship.

**ReferencingEntity**: msdyn_integrationjob<br />
**ReferencingAttribute**: owningteam<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: team_msdyn_integrationjob<br />
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


### <a name="BKMK_team_msdyn_integrationjobdetail"></a> team_msdyn_integrationjobdetail

Same as msdyn_integrationjobdetail entity [team_msdyn_integrationjobdetail](msdyn_integrationjobdetail.md#BKMK_team_msdyn_integrationjobdetail) Many-To-One relationship.

**ReferencingEntity**: msdyn_integrationjobdetail<br />
**ReferencingAttribute**: owningteam<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: team_msdyn_integrationjobdetail<br />
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


### <a name="BKMK_team_msdyn_invoicelinetransaction"></a> team_msdyn_invoicelinetransaction

Same as msdyn_invoicelinetransaction entity [team_msdyn_invoicelinetransaction](msdyn_invoicelinetransaction.md#BKMK_team_msdyn_invoicelinetransaction) Many-To-One relationship.

**ReferencingEntity**: msdyn_invoicelinetransaction<br />
**ReferencingAttribute**: owningteam<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: team_msdyn_invoicelinetransaction<br />
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


### <a name="BKMK_team_msdyn_journal"></a> team_msdyn_journal

Same as msdyn_journal entity [team_msdyn_journal](msdyn_journal.md#BKMK_team_msdyn_journal) Many-To-One relationship.

**ReferencingEntity**: msdyn_journal<br />
**ReferencingAttribute**: owningteam<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: team_msdyn_journal<br />
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


### <a name="BKMK_team_msdyn_journalline"></a> team_msdyn_journalline

Same as msdyn_journalline entity [team_msdyn_journalline](msdyn_journalline.md#BKMK_team_msdyn_journalline) Many-To-One relationship.

**ReferencingEntity**: msdyn_journalline<br />
**ReferencingAttribute**: owningteam<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: team_msdyn_journalline<br />
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


### <a name="BKMK_team_msdyn_opportunitylineresourcecategory"></a> team_msdyn_opportunitylineresourcecategory

Same as msdyn_opportunitylineresourcecategory entity [team_msdyn_opportunitylineresourcecategory](msdyn_opportunitylineresourcecategory.md#BKMK_team_msdyn_opportunitylineresourcecategory) Many-To-One relationship.

**ReferencingEntity**: msdyn_opportunitylineresourcecategory<br />
**ReferencingAttribute**: owningteam<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: team_msdyn_opportunitylineresourcecategory<br />
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


### <a name="BKMK_team_msdyn_opportunitylinetransaction"></a> team_msdyn_opportunitylinetransaction

Same as msdyn_opportunitylinetransaction entity [team_msdyn_opportunitylinetransaction](msdyn_opportunitylinetransaction.md#BKMK_team_msdyn_opportunitylinetransaction) Many-To-One relationship.

**ReferencingEntity**: msdyn_opportunitylinetransaction<br />
**ReferencingAttribute**: owningteam<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: team_msdyn_opportunitylinetransaction<br />
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


### <a name="BKMK_team_msdyn_opportunitylinetransactioncategory"></a> team_msdyn_opportunitylinetransactioncategory

Same as msdyn_opportunitylinetransactioncategory entity [team_msdyn_opportunitylinetransactioncategory](msdyn_opportunitylinetransactioncategory.md#BKMK_team_msdyn_opportunitylinetransactioncategory) Many-To-One relationship.

**ReferencingEntity**: msdyn_opportunitylinetransactioncategory<br />
**ReferencingAttribute**: owningteam<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: team_msdyn_opportunitylinetransactioncategory<br />
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


### <a name="BKMK_team_msdyn_opportunitylinetransactionclassificatio"></a> team_msdyn_opportunitylinetransactionclassificatio

Same as msdyn_opportunitylinetransactionclassificatio entity [team_msdyn_opportunitylinetransactionclassificatio](msdyn_opportunitylinetransactionclassificatio.md#BKMK_team_msdyn_opportunitylinetransactionclassificatio) Many-To-One relationship.

**ReferencingEntity**: msdyn_opportunitylinetransactionclassificatio<br />
**ReferencingAttribute**: owningteam<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: team_msdyn_opportunitylinetransactionclassificatio<br />
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


### <a name="BKMK_team_msdyn_opportunitypricelist"></a> team_msdyn_opportunitypricelist

Same as msdyn_opportunitypricelist entity [team_msdyn_opportunitypricelist](msdyn_opportunitypricelist.md#BKMK_team_msdyn_opportunitypricelist) Many-To-One relationship.

**ReferencingEntity**: msdyn_opportunitypricelist<br />
**ReferencingAttribute**: owningteam<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: team_msdyn_opportunitypricelist<br />
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


### <a name="BKMK_team_msdyn_orderlineresourcecategory"></a> team_msdyn_orderlineresourcecategory

Same as msdyn_orderlineresourcecategory entity [team_msdyn_orderlineresourcecategory](msdyn_orderlineresourcecategory.md#BKMK_team_msdyn_orderlineresourcecategory) Many-To-One relationship.

**ReferencingEntity**: msdyn_orderlineresourcecategory<br />
**ReferencingAttribute**: owningteam<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: team_msdyn_orderlineresourcecategory<br />
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


### <a name="BKMK_team_msdyn_orderlinetransaction"></a> team_msdyn_orderlinetransaction

Same as msdyn_orderlinetransaction entity [team_msdyn_orderlinetransaction](msdyn_orderlinetransaction.md#BKMK_team_msdyn_orderlinetransaction) Many-To-One relationship.

**ReferencingEntity**: msdyn_orderlinetransaction<br />
**ReferencingAttribute**: owningteam<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: team_msdyn_orderlinetransaction<br />
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


### <a name="BKMK_team_msdyn_orderlinetransactioncategory"></a> team_msdyn_orderlinetransactioncategory

Same as msdyn_orderlinetransactioncategory entity [team_msdyn_orderlinetransactioncategory](msdyn_orderlinetransactioncategory.md#BKMK_team_msdyn_orderlinetransactioncategory) Many-To-One relationship.

**ReferencingEntity**: msdyn_orderlinetransactioncategory<br />
**ReferencingAttribute**: owningteam<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: team_msdyn_orderlinetransactioncategory<br />
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


### <a name="BKMK_team_msdyn_orderlinetransactionclassification"></a> team_msdyn_orderlinetransactionclassification

Same as msdyn_orderlinetransactionclassification entity [team_msdyn_orderlinetransactionclassification](msdyn_orderlinetransactionclassification.md#BKMK_team_msdyn_orderlinetransactionclassification) Many-To-One relationship.

**ReferencingEntity**: msdyn_orderlinetransactionclassification<br />
**ReferencingAttribute**: owningteam<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: team_msdyn_orderlinetransactionclassification<br />
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


### <a name="BKMK_team_msdyn_orderpricelist"></a> team_msdyn_orderpricelist

Same as msdyn_orderpricelist entity [team_msdyn_orderpricelist](msdyn_orderpricelist.md#BKMK_team_msdyn_orderpricelist) Many-To-One relationship.

**ReferencingEntity**: msdyn_orderpricelist<br />
**ReferencingAttribute**: owningteam<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: team_msdyn_orderpricelist<br />
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


### <a name="BKMK_team_msdyn_project"></a> team_msdyn_project

Same as msdyn_project entity [team_msdyn_project](msdyn_project.md#BKMK_team_msdyn_project) Many-To-One relationship.

**ReferencingEntity**: msdyn_project<br />
**ReferencingAttribute**: owningteam<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: team_msdyn_project<br />
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


### <a name="BKMK_team_msdyn_projectapproval"></a> team_msdyn_projectapproval

Same as msdyn_projectapproval entity [team_msdyn_projectapproval](msdyn_projectapproval.md#BKMK_team_msdyn_projectapproval) Many-To-One relationship.

**ReferencingEntity**: msdyn_projectapproval<br />
**ReferencingAttribute**: owningteam<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: team_msdyn_projectapproval<br />
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


### <a name="BKMK_team_msdyn_projectpricelist"></a> team_msdyn_projectpricelist

Same as msdyn_projectpricelist entity [team_msdyn_projectpricelist](msdyn_projectpricelist.md#BKMK_team_msdyn_projectpricelist) Many-To-One relationship.

**ReferencingEntity**: msdyn_projectpricelist<br />
**ReferencingAttribute**: owningteam<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: team_msdyn_projectpricelist<br />
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


### <a name="BKMK_team_msdyn_projecttask"></a> team_msdyn_projecttask

Same as msdyn_projecttask entity [team_msdyn_projecttask](msdyn_projecttask.md#BKMK_team_msdyn_projecttask) Many-To-One relationship.

**ReferencingEntity**: msdyn_projecttask<br />
**ReferencingAttribute**: owningteam<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: team_msdyn_projecttask<br />
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


### <a name="BKMK_team_msdyn_projecttaskdependency"></a> team_msdyn_projecttaskdependency

Same as msdyn_projecttaskdependency entity [team_msdyn_projecttaskdependency](msdyn_projecttaskdependency.md#BKMK_team_msdyn_projecttaskdependency) Many-To-One relationship.

**ReferencingEntity**: msdyn_projecttaskdependency<br />
**ReferencingAttribute**: owningteam<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: team_msdyn_projecttaskdependency<br />
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


### <a name="BKMK_team_msdyn_projecttaskstatususer"></a> team_msdyn_projecttaskstatususer

Same as msdyn_projecttaskstatususer entity [team_msdyn_projecttaskstatususer](msdyn_projecttaskstatususer.md#BKMK_team_msdyn_projecttaskstatususer) Many-To-One relationship.

**ReferencingEntity**: msdyn_projecttaskstatususer<br />
**ReferencingAttribute**: owningteam<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: team_msdyn_projecttaskstatususer<br />
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


### <a name="BKMK_team_msdyn_projectteam"></a> team_msdyn_projectteam

Same as msdyn_projectteam entity [team_msdyn_projectteam](msdyn_projectteam.md#BKMK_team_msdyn_projectteam) Many-To-One relationship.

**ReferencingEntity**: msdyn_projectteam<br />
**ReferencingAttribute**: owningteam<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: team_msdyn_projectteam<br />
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


### <a name="BKMK_team_msdyn_projecttransactioncategory"></a> team_msdyn_projecttransactioncategory

Same as msdyn_projecttransactioncategory entity [team_msdyn_projecttransactioncategory](msdyn_projecttransactioncategory.md#BKMK_team_msdyn_projecttransactioncategory) Many-To-One relationship.

**ReferencingEntity**: msdyn_projecttransactioncategory<br />
**ReferencingAttribute**: owningteam<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: team_msdyn_projecttransactioncategory<br />
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


### <a name="BKMK_team_msdyn_quotelineanalyticsbreakdown"></a> team_msdyn_quotelineanalyticsbreakdown

Same as msdyn_quotelineanalyticsbreakdown entity [team_msdyn_quotelineanalyticsbreakdown](msdyn_quotelineanalyticsbreakdown.md#BKMK_team_msdyn_quotelineanalyticsbreakdown) Many-To-One relationship.

**ReferencingEntity**: msdyn_quotelineanalyticsbreakdown<br />
**ReferencingAttribute**: owningteam<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: team_msdyn_quotelineanalyticsbreakdown<br />
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


### <a name="BKMK_team_msdyn_quotelineresourcecategory"></a> team_msdyn_quotelineresourcecategory

Same as msdyn_quotelineresourcecategory entity [team_msdyn_quotelineresourcecategory](msdyn_quotelineresourcecategory.md#BKMK_team_msdyn_quotelineresourcecategory) Many-To-One relationship.

**ReferencingEntity**: msdyn_quotelineresourcecategory<br />
**ReferencingAttribute**: owningteam<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: team_msdyn_quotelineresourcecategory<br />
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


### <a name="BKMK_team_msdyn_quotelinescheduleofvalue"></a> team_msdyn_quotelinescheduleofvalue

Same as msdyn_quotelinescheduleofvalue entity [team_msdyn_quotelinescheduleofvalue](msdyn_quotelinescheduleofvalue.md#BKMK_team_msdyn_quotelinescheduleofvalue) Many-To-One relationship.

**ReferencingEntity**: msdyn_quotelinescheduleofvalue<br />
**ReferencingAttribute**: owningteam<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: team_msdyn_quotelinescheduleofvalue<br />
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


### <a name="BKMK_team_msdyn_quotelinetransaction"></a> team_msdyn_quotelinetransaction

Same as msdyn_quotelinetransaction entity [team_msdyn_quotelinetransaction](msdyn_quotelinetransaction.md#BKMK_team_msdyn_quotelinetransaction) Many-To-One relationship.

**ReferencingEntity**: msdyn_quotelinetransaction<br />
**ReferencingAttribute**: owningteam<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: team_msdyn_quotelinetransaction<br />
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


### <a name="BKMK_team_msdyn_quotelinetransactioncategory"></a> team_msdyn_quotelinetransactioncategory

Same as msdyn_quotelinetransactioncategory entity [team_msdyn_quotelinetransactioncategory](msdyn_quotelinetransactioncategory.md#BKMK_team_msdyn_quotelinetransactioncategory) Many-To-One relationship.

**ReferencingEntity**: msdyn_quotelinetransactioncategory<br />
**ReferencingAttribute**: owningteam<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: team_msdyn_quotelinetransactioncategory<br />
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


### <a name="BKMK_team_msdyn_quotelinetransactionclassification"></a> team_msdyn_quotelinetransactionclassification

Same as msdyn_quotelinetransactionclassification entity [team_msdyn_quotelinetransactionclassification](msdyn_quotelinetransactionclassification.md#BKMK_team_msdyn_quotelinetransactionclassification) Many-To-One relationship.

**ReferencingEntity**: msdyn_quotelinetransactionclassification<br />
**ReferencingAttribute**: owningteam<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: team_msdyn_quotelinetransactionclassification<br />
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


### <a name="BKMK_team_msdyn_quotepricelist"></a> team_msdyn_quotepricelist

Same as msdyn_quotepricelist entity [team_msdyn_quotepricelist](msdyn_quotepricelist.md#BKMK_team_msdyn_quotepricelist) Many-To-One relationship.

**ReferencingEntity**: msdyn_quotepricelist<br />
**ReferencingAttribute**: owningteam<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: team_msdyn_quotepricelist<br />
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


### <a name="BKMK_team_msdyn_resourceassignment"></a> team_msdyn_resourceassignment

Same as msdyn_resourceassignment entity [team_msdyn_resourceassignment](msdyn_resourceassignment.md#BKMK_team_msdyn_resourceassignment) Many-To-One relationship.

**ReferencingEntity**: msdyn_resourceassignment<br />
**ReferencingAttribute**: owningteam<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: team_msdyn_resourceassignment<br />
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


### <a name="BKMK_team_msdyn_resourceassignmentdetail"></a> team_msdyn_resourceassignmentdetail

Same as msdyn_resourceassignmentdetail entity [team_msdyn_resourceassignmentdetail](msdyn_resourceassignmentdetail.md#BKMK_team_msdyn_resourceassignmentdetail) Many-To-One relationship.

**ReferencingEntity**: msdyn_resourceassignmentdetail<br />
**ReferencingAttribute**: owningteam<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: team_msdyn_resourceassignmentdetail<br />
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


### <a name="BKMK_team_msdyn_resourcerequest"></a> team_msdyn_resourcerequest

Same as msdyn_resourcerequest entity [team_msdyn_resourcerequest](msdyn_resourcerequest.md#BKMK_team_msdyn_resourcerequest) Many-To-One relationship.

**ReferencingEntity**: msdyn_resourcerequest<br />
**ReferencingAttribute**: owningteam<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: team_msdyn_resourcerequest<br />
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


### <a name="BKMK_team_msdyn_rolecompetencyrequirement"></a> team_msdyn_rolecompetencyrequirement

Same as msdyn_rolecompetencyrequirement entity [team_msdyn_rolecompetencyrequirement](msdyn_rolecompetencyrequirement.md#BKMK_team_msdyn_rolecompetencyrequirement) Many-To-One relationship.

**ReferencingEntity**: msdyn_rolecompetencyrequirement<br />
**ReferencingAttribute**: owningteam<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: team_msdyn_rolecompetencyrequirement<br />
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


### <a name="BKMK_team_msdyn_roleutilization"></a> team_msdyn_roleutilization

Same as msdyn_roleutilization entity [team_msdyn_roleutilization](msdyn_roleutilization.md#BKMK_team_msdyn_roleutilization) Many-To-One relationship.

**ReferencingEntity**: msdyn_roleutilization<br />
**ReferencingAttribute**: owningteam<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: team_msdyn_roleutilization<br />
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


### <a name="BKMK_team_msdyn_timeentry"></a> team_msdyn_timeentry

Same as msdyn_timeentry entity [team_msdyn_timeentry](msdyn_timeentry.md#BKMK_team_msdyn_timeentry) Many-To-One relationship.

**ReferencingEntity**: msdyn_timeentry<br />
**ReferencingAttribute**: owningteam<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: team_msdyn_timeentry<br />
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


### <a name="BKMK_team_msdyn_timeoffcalendar"></a> team_msdyn_timeoffcalendar

Same as msdyn_timeoffcalendar entity [team_msdyn_timeoffcalendar](msdyn_timeoffcalendar.md#BKMK_team_msdyn_timeoffcalendar) Many-To-One relationship.

**ReferencingEntity**: msdyn_timeoffcalendar<br />
**ReferencingAttribute**: owningteam<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: team_msdyn_timeoffcalendar<br />
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


### <a name="BKMK_team_msdyn_transactionconnection"></a> team_msdyn_transactionconnection

Same as msdyn_transactionconnection entity [team_msdyn_transactionconnection](msdyn_transactionconnection.md#BKMK_team_msdyn_transactionconnection) Many-To-One relationship.

**ReferencingEntity**: msdyn_transactionconnection<br />
**ReferencingAttribute**: owningteam<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: team_msdyn_transactionconnection<br />
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


### <a name="BKMK_team_msdyn_userworkhistory"></a> team_msdyn_userworkhistory

Same as msdyn_userworkhistory entity [team_msdyn_userworkhistory](msdyn_userworkhistory.md#BKMK_team_msdyn_userworkhistory) Many-To-One relationship.

**ReferencingEntity**: msdyn_userworkhistory<br />
**ReferencingAttribute**: owningteam<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: team_msdyn_userworkhistory<br />
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


### <a name="BKMK_msdyn_team_msdyn_project_projectteamid"></a> msdyn_team_msdyn_project_projectteamid

Same as msdyn_project entity [msdyn_team_msdyn_project_projectteamid](msdyn_project.md#BKMK_msdyn_team_msdyn_project_projectteamid) Many-To-One relationship.

**ReferencingEntity**: msdyn_project<br />
**ReferencingAttribute**: msdyn_projectteamid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_team_msdyn_project_projectteamid<br />
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


### <a name="BKMK_team_msdyn_agreement"></a> team_msdyn_agreement

Same as msdyn_agreement entity [team_msdyn_agreement](msdyn_agreement.md#BKMK_team_msdyn_agreement) Many-To-One relationship.

**ReferencingEntity**: msdyn_agreement<br />
**ReferencingAttribute**: owningteam<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: team_msdyn_agreement<br />
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


### <a name="BKMK_team_msdyn_agreementbookingdate"></a> team_msdyn_agreementbookingdate

Same as msdyn_agreementbookingdate entity [team_msdyn_agreementbookingdate](msdyn_agreementbookingdate.md#BKMK_team_msdyn_agreementbookingdate) Many-To-One relationship.

**ReferencingEntity**: msdyn_agreementbookingdate<br />
**ReferencingAttribute**: owningteam<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: team_msdyn_agreementbookingdate<br />
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


### <a name="BKMK_team_msdyn_agreementbookingincident"></a> team_msdyn_agreementbookingincident

Same as msdyn_agreementbookingincident entity [team_msdyn_agreementbookingincident](msdyn_agreementbookingincident.md#BKMK_team_msdyn_agreementbookingincident) Many-To-One relationship.

**ReferencingEntity**: msdyn_agreementbookingincident<br />
**ReferencingAttribute**: owningteam<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: team_msdyn_agreementbookingincident<br />
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


### <a name="BKMK_team_msdyn_agreementbookingproduct"></a> team_msdyn_agreementbookingproduct

Same as msdyn_agreementbookingproduct entity [team_msdyn_agreementbookingproduct](msdyn_agreementbookingproduct.md#BKMK_team_msdyn_agreementbookingproduct) Many-To-One relationship.

**ReferencingEntity**: msdyn_agreementbookingproduct<br />
**ReferencingAttribute**: owningteam<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: team_msdyn_agreementbookingproduct<br />
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


### <a name="BKMK_team_msdyn_agreementbookingservice"></a> team_msdyn_agreementbookingservice

Same as msdyn_agreementbookingservice entity [team_msdyn_agreementbookingservice](msdyn_agreementbookingservice.md#BKMK_team_msdyn_agreementbookingservice) Many-To-One relationship.

**ReferencingEntity**: msdyn_agreementbookingservice<br />
**ReferencingAttribute**: owningteam<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: team_msdyn_agreementbookingservice<br />
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


### <a name="BKMK_team_msdyn_agreementbookingservicetask"></a> team_msdyn_agreementbookingservicetask

Same as msdyn_agreementbookingservicetask entity [team_msdyn_agreementbookingservicetask](msdyn_agreementbookingservicetask.md#BKMK_team_msdyn_agreementbookingservicetask) Many-To-One relationship.

**ReferencingEntity**: msdyn_agreementbookingservicetask<br />
**ReferencingAttribute**: owningteam<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: team_msdyn_agreementbookingservicetask<br />
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


### <a name="BKMK_team_msdyn_agreementbookingsetup"></a> team_msdyn_agreementbookingsetup

Same as msdyn_agreementbookingsetup entity [team_msdyn_agreementbookingsetup](msdyn_agreementbookingsetup.md#BKMK_team_msdyn_agreementbookingsetup) Many-To-One relationship.

**ReferencingEntity**: msdyn_agreementbookingsetup<br />
**ReferencingAttribute**: owningteam<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: team_msdyn_agreementbookingsetup<br />
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


### <a name="BKMK_team_msdyn_agreementinvoicedate"></a> team_msdyn_agreementinvoicedate

Same as msdyn_agreementinvoicedate entity [team_msdyn_agreementinvoicedate](msdyn_agreementinvoicedate.md#BKMK_team_msdyn_agreementinvoicedate) Many-To-One relationship.

**ReferencingEntity**: msdyn_agreementinvoicedate<br />
**ReferencingAttribute**: owningteam<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: team_msdyn_agreementinvoicedate<br />
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


### <a name="BKMK_team_msdyn_agreementinvoiceproduct"></a> team_msdyn_agreementinvoiceproduct

Same as msdyn_agreementinvoiceproduct entity [team_msdyn_agreementinvoiceproduct](msdyn_agreementinvoiceproduct.md#BKMK_team_msdyn_agreementinvoiceproduct) Many-To-One relationship.

**ReferencingEntity**: msdyn_agreementinvoiceproduct<br />
**ReferencingAttribute**: owningteam<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: team_msdyn_agreementinvoiceproduct<br />
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


### <a name="BKMK_team_msdyn_agreementinvoicesetup"></a> team_msdyn_agreementinvoicesetup

Same as msdyn_agreementinvoicesetup entity [team_msdyn_agreementinvoicesetup](msdyn_agreementinvoicesetup.md#BKMK_team_msdyn_agreementinvoicesetup) Many-To-One relationship.

**ReferencingEntity**: msdyn_agreementinvoicesetup<br />
**ReferencingAttribute**: owningteam<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: team_msdyn_agreementinvoicesetup<br />
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


### <a name="BKMK_team_msdyn_agreementsubstatus"></a> team_msdyn_agreementsubstatus

Same as msdyn_agreementsubstatus entity [team_msdyn_agreementsubstatus](msdyn_agreementsubstatus.md#BKMK_team_msdyn_agreementsubstatus) Many-To-One relationship.

**ReferencingEntity**: msdyn_agreementsubstatus<br />
**ReferencingAttribute**: owningteam<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: team_msdyn_agreementsubstatus<br />
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


### <a name="BKMK_team_msdyn_bookingjournal"></a> team_msdyn_bookingjournal

Same as msdyn_bookingjournal entity [team_msdyn_bookingjournal](msdyn_bookingjournal.md#BKMK_team_msdyn_bookingjournal) Many-To-One relationship.

**ReferencingEntity**: msdyn_bookingjournal<br />
**ReferencingAttribute**: owningteam<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: team_msdyn_bookingjournal<br />
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


### <a name="BKMK_team_msdyn_bookingtimestamp"></a> team_msdyn_bookingtimestamp

Same as msdyn_bookingtimestamp entity [team_msdyn_bookingtimestamp](msdyn_bookingtimestamp.md#BKMK_team_msdyn_bookingtimestamp) Many-To-One relationship.

**ReferencingEntity**: msdyn_bookingtimestamp<br />
**ReferencingAttribute**: owningteam<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: team_msdyn_bookingtimestamp<br />
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


### <a name="BKMK_team_msdyn_customerasset"></a> team_msdyn_customerasset

Same as msdyn_customerasset entity [team_msdyn_customerasset](msdyn_customerasset.md#BKMK_team_msdyn_customerasset) Many-To-One relationship.

**ReferencingEntity**: msdyn_customerasset<br />
**ReferencingAttribute**: owningteam<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: team_msdyn_customerasset<br />
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


### <a name="BKMK_team_msdyn_fieldservicesetting"></a> team_msdyn_fieldservicesetting

Same as msdyn_fieldservicesetting entity [team_msdyn_fieldservicesetting](msdyn_fieldservicesetting.md#BKMK_team_msdyn_fieldservicesetting) Many-To-One relationship.

**ReferencingEntity**: msdyn_fieldservicesetting<br />
**ReferencingAttribute**: owningteam<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: team_msdyn_fieldservicesetting<br />
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


### <a name="BKMK_team_msdyn_incidenttype"></a> team_msdyn_incidenttype

Same as msdyn_incidenttype entity [team_msdyn_incidenttype](msdyn_incidenttype.md#BKMK_team_msdyn_incidenttype) Many-To-One relationship.

**ReferencingEntity**: msdyn_incidenttype<br />
**ReferencingAttribute**: owningteam<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: team_msdyn_incidenttype<br />
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


### <a name="BKMK_team_msdyn_incidenttypecharacteristic"></a> team_msdyn_incidenttypecharacteristic

Same as msdyn_incidenttypecharacteristic entity [team_msdyn_incidenttypecharacteristic](msdyn_incidenttypecharacteristic.md#BKMK_team_msdyn_incidenttypecharacteristic) Many-To-One relationship.

**ReferencingEntity**: msdyn_incidenttypecharacteristic<br />
**ReferencingAttribute**: owningteam<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: team_msdyn_incidenttypecharacteristic<br />
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


### <a name="BKMK_team_msdyn_incidenttypeproduct"></a> team_msdyn_incidenttypeproduct

Same as msdyn_incidenttypeproduct entity [team_msdyn_incidenttypeproduct](msdyn_incidenttypeproduct.md#BKMK_team_msdyn_incidenttypeproduct) Many-To-One relationship.

**ReferencingEntity**: msdyn_incidenttypeproduct<br />
**ReferencingAttribute**: owningteam<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: team_msdyn_incidenttypeproduct<br />
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


### <a name="BKMK_team_msdyn_incidenttypeservice"></a> team_msdyn_incidenttypeservice

Same as msdyn_incidenttypeservice entity [team_msdyn_incidenttypeservice](msdyn_incidenttypeservice.md#BKMK_team_msdyn_incidenttypeservice) Many-To-One relationship.

**ReferencingEntity**: msdyn_incidenttypeservice<br />
**ReferencingAttribute**: owningteam<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: team_msdyn_incidenttypeservice<br />
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


### <a name="BKMK_team_msdyn_incidenttypeservicetask"></a> team_msdyn_incidenttypeservicetask

Same as msdyn_incidenttypeservicetask entity [team_msdyn_incidenttypeservicetask](msdyn_incidenttypeservicetask.md#BKMK_team_msdyn_incidenttypeservicetask) Many-To-One relationship.

**ReferencingEntity**: msdyn_incidenttypeservicetask<br />
**ReferencingAttribute**: owningteam<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: team_msdyn_incidenttypeservicetask<br />
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


### <a name="BKMK_team_msdyn_inventoryadjustment"></a> team_msdyn_inventoryadjustment

Same as msdyn_inventoryadjustment entity [team_msdyn_inventoryadjustment](msdyn_inventoryadjustment.md#BKMK_team_msdyn_inventoryadjustment) Many-To-One relationship.

**ReferencingEntity**: msdyn_inventoryadjustment<br />
**ReferencingAttribute**: owningteam<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: team_msdyn_inventoryadjustment<br />
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


### <a name="BKMK_team_msdyn_inventoryadjustmentproduct"></a> team_msdyn_inventoryadjustmentproduct

Same as msdyn_inventoryadjustmentproduct entity [team_msdyn_inventoryadjustmentproduct](msdyn_inventoryadjustmentproduct.md#BKMK_team_msdyn_inventoryadjustmentproduct) Many-To-One relationship.

**ReferencingEntity**: msdyn_inventoryadjustmentproduct<br />
**ReferencingAttribute**: owningteam<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: team_msdyn_inventoryadjustmentproduct<br />
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


### <a name="BKMK_team_msdyn_inventoryjournal"></a> team_msdyn_inventoryjournal

Same as msdyn_inventoryjournal entity [team_msdyn_inventoryjournal](msdyn_inventoryjournal.md#BKMK_team_msdyn_inventoryjournal) Many-To-One relationship.

**ReferencingEntity**: msdyn_inventoryjournal<br />
**ReferencingAttribute**: owningteam<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: team_msdyn_inventoryjournal<br />
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


### <a name="BKMK_team_msdyn_inventorytransfer"></a> team_msdyn_inventorytransfer

Same as msdyn_inventorytransfer entity [team_msdyn_inventorytransfer](msdyn_inventorytransfer.md#BKMK_team_msdyn_inventorytransfer) Many-To-One relationship.

**ReferencingEntity**: msdyn_inventorytransfer<br />
**ReferencingAttribute**: owningteam<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: team_msdyn_inventorytransfer<br />
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


### <a name="BKMK_team_msdyn_orderinvoicingdate"></a> team_msdyn_orderinvoicingdate

Same as msdyn_orderinvoicingdate entity [team_msdyn_orderinvoicingdate](msdyn_orderinvoicingdate.md#BKMK_team_msdyn_orderinvoicingdate) Many-To-One relationship.

**ReferencingEntity**: msdyn_orderinvoicingdate<br />
**ReferencingAttribute**: owningteam<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: team_msdyn_orderinvoicingdate<br />
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


### <a name="BKMK_team_msdyn_orderinvoicingproduct"></a> team_msdyn_orderinvoicingproduct

Same as msdyn_orderinvoicingproduct entity [team_msdyn_orderinvoicingproduct](msdyn_orderinvoicingproduct.md#BKMK_team_msdyn_orderinvoicingproduct) Many-To-One relationship.

**ReferencingEntity**: msdyn_orderinvoicingproduct<br />
**ReferencingAttribute**: owningteam<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: team_msdyn_orderinvoicingproduct<br />
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


### <a name="BKMK_team_msdyn_orderinvoicingsetup"></a> team_msdyn_orderinvoicingsetup

Same as msdyn_orderinvoicingsetup entity [team_msdyn_orderinvoicingsetup](msdyn_orderinvoicingsetup.md#BKMK_team_msdyn_orderinvoicingsetup) Many-To-One relationship.

**ReferencingEntity**: msdyn_orderinvoicingsetup<br />
**ReferencingAttribute**: owningteam<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: team_msdyn_orderinvoicingsetup<br />
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


### <a name="BKMK_team_msdyn_orderinvoicingsetupdate"></a> team_msdyn_orderinvoicingsetupdate

Same as msdyn_orderinvoicingsetupdate entity [team_msdyn_orderinvoicingsetupdate](msdyn_orderinvoicingsetupdate.md#BKMK_team_msdyn_orderinvoicingsetupdate) Many-To-One relationship.

**ReferencingEntity**: msdyn_orderinvoicingsetupdate<br />
**ReferencingAttribute**: owningteam<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: team_msdyn_orderinvoicingsetupdate<br />
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


### <a name="BKMK_team_msdyn_payment"></a> team_msdyn_payment

Same as msdyn_payment entity [team_msdyn_payment](msdyn_payment.md#BKMK_team_msdyn_payment) Many-To-One relationship.

**ReferencingEntity**: msdyn_payment<br />
**ReferencingAttribute**: owningteam<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: team_msdyn_payment<br />
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


### <a name="BKMK_team_msdyn_paymentdetail"></a> team_msdyn_paymentdetail

Same as msdyn_paymentdetail entity [team_msdyn_paymentdetail](msdyn_paymentdetail.md#BKMK_team_msdyn_paymentdetail) Many-To-One relationship.

**ReferencingEntity**: msdyn_paymentdetail<br />
**ReferencingAttribute**: owningteam<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: team_msdyn_paymentdetail<br />
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


### <a name="BKMK_team_msdyn_paymentmethod"></a> team_msdyn_paymentmethod

Same as msdyn_paymentmethod entity [team_msdyn_paymentmethod](msdyn_paymentmethod.md#BKMK_team_msdyn_paymentmethod) Many-To-One relationship.

**ReferencingEntity**: msdyn_paymentmethod<br />
**ReferencingAttribute**: owningteam<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: team_msdyn_paymentmethod<br />
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


### <a name="BKMK_team_msdyn_paymentterm"></a> team_msdyn_paymentterm

Same as msdyn_paymentterm entity [team_msdyn_paymentterm](msdyn_paymentterm.md#BKMK_team_msdyn_paymentterm) Many-To-One relationship.

**ReferencingEntity**: msdyn_paymentterm<br />
**ReferencingAttribute**: owningteam<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: team_msdyn_paymentterm<br />
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


### <a name="BKMK_team_msdyn_postalcode"></a> team_msdyn_postalcode

Same as msdyn_postalcode entity [team_msdyn_postalcode](msdyn_postalcode.md#BKMK_team_msdyn_postalcode) Many-To-One relationship.

**ReferencingEntity**: msdyn_postalcode<br />
**ReferencingAttribute**: owningteam<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: team_msdyn_postalcode<br />
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


### <a name="BKMK_team_msdyn_purchaseorder"></a> team_msdyn_purchaseorder

Same as msdyn_purchaseorder entity [team_msdyn_purchaseorder](msdyn_purchaseorder.md#BKMK_team_msdyn_purchaseorder) Many-To-One relationship.

**ReferencingEntity**: msdyn_purchaseorder<br />
**ReferencingAttribute**: owningteam<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: team_msdyn_purchaseorder<br />
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


### <a name="BKMK_team_msdyn_purchaseorderbill"></a> team_msdyn_purchaseorderbill

Same as msdyn_purchaseorderbill entity [team_msdyn_purchaseorderbill](msdyn_purchaseorderbill.md#BKMK_team_msdyn_purchaseorderbill) Many-To-One relationship.

**ReferencingEntity**: msdyn_purchaseorderbill<br />
**ReferencingAttribute**: owningteam<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: team_msdyn_purchaseorderbill<br />
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


### <a name="BKMK_team_msdyn_purchaseorderproduct"></a> team_msdyn_purchaseorderproduct

Same as msdyn_purchaseorderproduct entity [team_msdyn_purchaseorderproduct](msdyn_purchaseorderproduct.md#BKMK_team_msdyn_purchaseorderproduct) Many-To-One relationship.

**ReferencingEntity**: msdyn_purchaseorderproduct<br />
**ReferencingAttribute**: owningteam<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: team_msdyn_purchaseorderproduct<br />
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


### <a name="BKMK_team_msdyn_purchaseorderreceipt"></a> team_msdyn_purchaseorderreceipt

Same as msdyn_purchaseorderreceipt entity [team_msdyn_purchaseorderreceipt](msdyn_purchaseorderreceipt.md#BKMK_team_msdyn_purchaseorderreceipt) Many-To-One relationship.

**ReferencingEntity**: msdyn_purchaseorderreceipt<br />
**ReferencingAttribute**: owningteam<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: team_msdyn_purchaseorderreceipt<br />
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


### <a name="BKMK_team_msdyn_purchaseorderreceiptproduct"></a> team_msdyn_purchaseorderreceiptproduct

Same as msdyn_purchaseorderreceiptproduct entity [team_msdyn_purchaseorderreceiptproduct](msdyn_purchaseorderreceiptproduct.md#BKMK_team_msdyn_purchaseorderreceiptproduct) Many-To-One relationship.

**ReferencingEntity**: msdyn_purchaseorderreceiptproduct<br />
**ReferencingAttribute**: owningteam<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: team_msdyn_purchaseorderreceiptproduct<br />
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


### <a name="BKMK_team_msdyn_purchaseordersubstatus"></a> team_msdyn_purchaseordersubstatus

Same as msdyn_purchaseordersubstatus entity [team_msdyn_purchaseordersubstatus](msdyn_purchaseordersubstatus.md#BKMK_team_msdyn_purchaseordersubstatus) Many-To-One relationship.

**ReferencingEntity**: msdyn_purchaseordersubstatus<br />
**ReferencingAttribute**: owningteam<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: team_msdyn_purchaseordersubstatus<br />
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


### <a name="BKMK_team_msdyn_quotebookingincident"></a> team_msdyn_quotebookingincident

Same as msdyn_quotebookingincident entity [team_msdyn_quotebookingincident](msdyn_quotebookingincident.md#BKMK_team_msdyn_quotebookingincident) Many-To-One relationship.

**ReferencingEntity**: msdyn_quotebookingincident<br />
**ReferencingAttribute**: owningteam<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: team_msdyn_quotebookingincident<br />
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


### <a name="BKMK_team_msdyn_quotebookingproduct"></a> team_msdyn_quotebookingproduct

Same as msdyn_quotebookingproduct entity [team_msdyn_quotebookingproduct](msdyn_quotebookingproduct.md#BKMK_team_msdyn_quotebookingproduct) Many-To-One relationship.

**ReferencingEntity**: msdyn_quotebookingproduct<br />
**ReferencingAttribute**: owningteam<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: team_msdyn_quotebookingproduct<br />
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


### <a name="BKMK_team_msdyn_quotebookingservice"></a> team_msdyn_quotebookingservice

Same as msdyn_quotebookingservice entity [team_msdyn_quotebookingservice](msdyn_quotebookingservice.md#BKMK_team_msdyn_quotebookingservice) Many-To-One relationship.

**ReferencingEntity**: msdyn_quotebookingservice<br />
**ReferencingAttribute**: owningteam<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: team_msdyn_quotebookingservice<br />
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


### <a name="BKMK_team_msdyn_quotebookingservicetask"></a> team_msdyn_quotebookingservicetask

Same as msdyn_quotebookingservicetask entity [team_msdyn_quotebookingservicetask](msdyn_quotebookingservicetask.md#BKMK_team_msdyn_quotebookingservicetask) Many-To-One relationship.

**ReferencingEntity**: msdyn_quotebookingservicetask<br />
**ReferencingAttribute**: owningteam<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: team_msdyn_quotebookingservicetask<br />
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


### <a name="BKMK_team_msdyn_quotebookingsetup"></a> team_msdyn_quotebookingsetup

Same as msdyn_quotebookingsetup entity [team_msdyn_quotebookingsetup](msdyn_quotebookingsetup.md#BKMK_team_msdyn_quotebookingsetup) Many-To-One relationship.

**ReferencingEntity**: msdyn_quotebookingsetup<br />
**ReferencingAttribute**: owningteam<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: team_msdyn_quotebookingsetup<br />
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


### <a name="BKMK_team_msdyn_quoteinvoicingproduct"></a> team_msdyn_quoteinvoicingproduct

Same as msdyn_quoteinvoicingproduct entity [team_msdyn_quoteinvoicingproduct](msdyn_quoteinvoicingproduct.md#BKMK_team_msdyn_quoteinvoicingproduct) Many-To-One relationship.

**ReferencingEntity**: msdyn_quoteinvoicingproduct<br />
**ReferencingAttribute**: owningteam<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: team_msdyn_quoteinvoicingproduct<br />
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


### <a name="BKMK_team_msdyn_quoteinvoicingsetup"></a> team_msdyn_quoteinvoicingsetup

Same as msdyn_quoteinvoicingsetup entity [team_msdyn_quoteinvoicingsetup](msdyn_quoteinvoicingsetup.md#BKMK_team_msdyn_quoteinvoicingsetup) Many-To-One relationship.

**ReferencingEntity**: msdyn_quoteinvoicingsetup<br />
**ReferencingAttribute**: owningteam<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: team_msdyn_quoteinvoicingsetup<br />
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


### <a name="BKMK_team_msdyn_resourcepaytype"></a> team_msdyn_resourcepaytype

Same as msdyn_resourcepaytype entity [team_msdyn_resourcepaytype](msdyn_resourcepaytype.md#BKMK_team_msdyn_resourcepaytype) Many-To-One relationship.

**ReferencingEntity**: msdyn_resourcepaytype<br />
**ReferencingAttribute**: owningteam<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: team_msdyn_resourcepaytype<br />
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


### <a name="BKMK_team_msdyn_rma"></a> team_msdyn_rma

Same as msdyn_rma entity [team_msdyn_rma](msdyn_rma.md#BKMK_team_msdyn_rma) Many-To-One relationship.

**ReferencingEntity**: msdyn_rma<br />
**ReferencingAttribute**: owningteam<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: team_msdyn_rma<br />
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


### <a name="BKMK_team_msdyn_rmaproduct"></a> team_msdyn_rmaproduct

Same as msdyn_rmaproduct entity [team_msdyn_rmaproduct](msdyn_rmaproduct.md#BKMK_team_msdyn_rmaproduct) Many-To-One relationship.

**ReferencingEntity**: msdyn_rmaproduct<br />
**ReferencingAttribute**: owningteam<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: team_msdyn_rmaproduct<br />
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


### <a name="BKMK_team_msdyn_rmareceipt"></a> team_msdyn_rmareceipt

Same as msdyn_rmareceipt entity [team_msdyn_rmareceipt](msdyn_rmareceipt.md#BKMK_team_msdyn_rmareceipt) Many-To-One relationship.

**ReferencingEntity**: msdyn_rmareceipt<br />
**ReferencingAttribute**: owningteam<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: team_msdyn_rmareceipt<br />
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


### <a name="BKMK_team_msdyn_rmareceiptproduct"></a> team_msdyn_rmareceiptproduct

Same as msdyn_rmareceiptproduct entity [team_msdyn_rmareceiptproduct](msdyn_rmareceiptproduct.md#BKMK_team_msdyn_rmareceiptproduct) Many-To-One relationship.

**ReferencingEntity**: msdyn_rmareceiptproduct<br />
**ReferencingAttribute**: owningteam<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: team_msdyn_rmareceiptproduct<br />
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


### <a name="BKMK_team_msdyn_rmasubstatus"></a> team_msdyn_rmasubstatus

Same as msdyn_rmasubstatus entity [team_msdyn_rmasubstatus](msdyn_rmasubstatus.md#BKMK_team_msdyn_rmasubstatus) Many-To-One relationship.

**ReferencingEntity**: msdyn_rmasubstatus<br />
**ReferencingAttribute**: owningteam<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: team_msdyn_rmasubstatus<br />
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


### <a name="BKMK_team_msdyn_rtv"></a> team_msdyn_rtv

Same as msdyn_rtv entity [team_msdyn_rtv](msdyn_rtv.md#BKMK_team_msdyn_rtv) Many-To-One relationship.

**ReferencingEntity**: msdyn_rtv<br />
**ReferencingAttribute**: owningteam<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: team_msdyn_rtv<br />
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


### <a name="BKMK_team_msdyn_rtvproduct"></a> team_msdyn_rtvproduct

Same as msdyn_rtvproduct entity [team_msdyn_rtvproduct](msdyn_rtvproduct.md#BKMK_team_msdyn_rtvproduct) Many-To-One relationship.

**ReferencingEntity**: msdyn_rtvproduct<br />
**ReferencingAttribute**: owningteam<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: team_msdyn_rtvproduct<br />
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


### <a name="BKMK_team_msdyn_rtvsubstatus"></a> team_msdyn_rtvsubstatus

Same as msdyn_rtvsubstatus entity [team_msdyn_rtvsubstatus](msdyn_rtvsubstatus.md#BKMK_team_msdyn_rtvsubstatus) Many-To-One relationship.

**ReferencingEntity**: msdyn_rtvsubstatus<br />
**ReferencingAttribute**: owningteam<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: team_msdyn_rtvsubstatus<br />
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


### <a name="BKMK_team_msdyn_servicetasktype"></a> team_msdyn_servicetasktype

Same as msdyn_servicetasktype entity [team_msdyn_servicetasktype](msdyn_servicetasktype.md#BKMK_team_msdyn_servicetasktype) Many-To-One relationship.

**ReferencingEntity**: msdyn_servicetasktype<br />
**ReferencingAttribute**: owningteam<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: team_msdyn_servicetasktype<br />
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


### <a name="BKMK_team_msdyn_shipvia"></a> team_msdyn_shipvia

Same as msdyn_shipvia entity [team_msdyn_shipvia](msdyn_shipvia.md#BKMK_team_msdyn_shipvia) Many-To-One relationship.

**ReferencingEntity**: msdyn_shipvia<br />
**ReferencingAttribute**: owningteam<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: team_msdyn_shipvia<br />
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


### <a name="BKMK_team_msdyn_taxcode"></a> team_msdyn_taxcode

Same as msdyn_taxcode entity [team_msdyn_taxcode](msdyn_taxcode.md#BKMK_team_msdyn_taxcode) Many-To-One relationship.

**ReferencingEntity**: msdyn_taxcode<br />
**ReferencingAttribute**: owningteam<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: team_msdyn_taxcode<br />
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


### <a name="BKMK_team_msdyn_taxcodedetail"></a> team_msdyn_taxcodedetail

Same as msdyn_taxcodedetail entity [team_msdyn_taxcodedetail](msdyn_taxcodedetail.md#BKMK_team_msdyn_taxcodedetail) Many-To-One relationship.

**ReferencingEntity**: msdyn_taxcodedetail<br />
**ReferencingAttribute**: owningteam<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: team_msdyn_taxcodedetail<br />
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


### <a name="BKMK_team_msdyn_timeoffrequest"></a> team_msdyn_timeoffrequest

Same as msdyn_timeoffrequest entity [team_msdyn_timeoffrequest](msdyn_timeoffrequest.md#BKMK_team_msdyn_timeoffrequest) Many-To-One relationship.

**ReferencingEntity**: msdyn_timeoffrequest<br />
**ReferencingAttribute**: owningteam<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: team_msdyn_timeoffrequest<br />
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


### <a name="BKMK_team_msdyn_warehouse"></a> team_msdyn_warehouse

Same as msdyn_warehouse entity [team_msdyn_warehouse](msdyn_warehouse.md#BKMK_team_msdyn_warehouse) Many-To-One relationship.

**ReferencingEntity**: msdyn_warehouse<br />
**ReferencingAttribute**: owningteam<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: team_msdyn_warehouse<br />
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


### <a name="BKMK_team_msdyn_workorder"></a> team_msdyn_workorder

Same as msdyn_workorder entity [team_msdyn_workorder](msdyn_workorder.md#BKMK_team_msdyn_workorder) Many-To-One relationship.

**ReferencingEntity**: msdyn_workorder<br />
**ReferencingAttribute**: owningteam<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: team_msdyn_workorder<br />
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


### <a name="BKMK_team_msdyn_workordercharacteristic"></a> team_msdyn_workordercharacteristic

Same as msdyn_workordercharacteristic entity [team_msdyn_workordercharacteristic](msdyn_workordercharacteristic.md#BKMK_team_msdyn_workordercharacteristic) Many-To-One relationship.

**ReferencingEntity**: msdyn_workordercharacteristic<br />
**ReferencingAttribute**: owningteam<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: team_msdyn_workordercharacteristic<br />
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


### <a name="BKMK_team_msdyn_workorderincident"></a> team_msdyn_workorderincident

Same as msdyn_workorderincident entity [team_msdyn_workorderincident](msdyn_workorderincident.md#BKMK_team_msdyn_workorderincident) Many-To-One relationship.

**ReferencingEntity**: msdyn_workorderincident<br />
**ReferencingAttribute**: owningteam<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: team_msdyn_workorderincident<br />
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


### <a name="BKMK_team_msdyn_workorderproduct"></a> team_msdyn_workorderproduct

Same as msdyn_workorderproduct entity [team_msdyn_workorderproduct](msdyn_workorderproduct.md#BKMK_team_msdyn_workorderproduct) Many-To-One relationship.

**ReferencingEntity**: msdyn_workorderproduct<br />
**ReferencingAttribute**: owningteam<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: team_msdyn_workorderproduct<br />
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


### <a name="BKMK_team_msdyn_workorderresourcerestriction"></a> team_msdyn_workorderresourcerestriction

Same as msdyn_workorderresourcerestriction entity [team_msdyn_workorderresourcerestriction](msdyn_workorderresourcerestriction.md#BKMK_team_msdyn_workorderresourcerestriction) Many-To-One relationship.

**ReferencingEntity**: msdyn_workorderresourcerestriction<br />
**ReferencingAttribute**: owningteam<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: team_msdyn_workorderresourcerestriction<br />
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


### <a name="BKMK_team_msdyn_workorderservice"></a> team_msdyn_workorderservice

Same as msdyn_workorderservice entity [team_msdyn_workorderservice](msdyn_workorderservice.md#BKMK_team_msdyn_workorderservice) Many-To-One relationship.

**ReferencingEntity**: msdyn_workorderservice<br />
**ReferencingAttribute**: owningteam<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: team_msdyn_workorderservice<br />
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


### <a name="BKMK_team_msdyn_workorderservicetask"></a> team_msdyn_workorderservicetask

Same as msdyn_workorderservicetask entity [team_msdyn_workorderservicetask](msdyn_workorderservicetask.md#BKMK_team_msdyn_workorderservicetask) Many-To-One relationship.

**ReferencingEntity**: msdyn_workorderservicetask<br />
**ReferencingAttribute**: owningteam<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: team_msdyn_workorderservicetask<br />
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


### <a name="BKMK_team_msdyn_workordersubstatus"></a> team_msdyn_workordersubstatus

Same as msdyn_workordersubstatus entity [team_msdyn_workordersubstatus](msdyn_workordersubstatus.md#BKMK_team_msdyn_workordersubstatus) Many-To-One relationship.

**ReferencingEntity**: msdyn_workordersubstatus<br />
**ReferencingAttribute**: owningteam<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: team_msdyn_workordersubstatus<br />
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


### <a name="BKMK_team_msdyn_workordertype"></a> team_msdyn_workordertype

Same as msdyn_workordertype entity [team_msdyn_workordertype](msdyn_workordertype.md#BKMK_team_msdyn_workordertype) Many-To-One relationship.

**ReferencingEntity**: msdyn_workordertype<br />
**ReferencingAttribute**: owningteam<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: team_msdyn_workordertype<br />
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


### <a name="BKMK_team_principalobjectattributeaccess_principalid"></a> team_principalobjectattributeaccess_principalid

Same as principalobjectattributeaccess entity [team_principalobjectattributeaccess_principalid](principalobjectattributeaccess.md#BKMK_team_principalobjectattributeaccess_principalid) Many-To-One relationship.

**ReferencingEntity**: principalobjectattributeaccess<br />
**ReferencingAttribute**: principalid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: False<br />
**ReferencedEntityNavigationPropertyName**: team_principalobjectattributeaccess_principalid<br />
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


### <a name="BKMK_team_exchangesyncidmapping"></a> team_exchangesyncidmapping

Same as exchangesyncidmapping entity [team_exchangesyncidmapping](exchangesyncidmapping.md#BKMK_team_exchangesyncidmapping) Many-To-One relationship.

**ReferencingEntity**: exchangesyncidmapping<br />
**ReferencingAttribute**: owningteam<br />
**IsHierarchical**: False<br />
**IsCustomizable**: False<br />
**ReferencedEntityNavigationPropertyName**: team_exchangesyncidmapping<br />
**AssociatedMenuConfiguration**:

- **Behavior**: UseCollectionName
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


### <a name="BKMK_team_interactionforemail"></a> team_interactionforemail

Same as interactionforemail entity [team_interactionforemail](interactionforemail.md#BKMK_team_interactionforemail) Many-To-One relationship.

**ReferencingEntity**: interactionforemail<br />
**ReferencingAttribute**: owningteam<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: team_new_interactionforemail<br />
**AssociatedMenuConfiguration**:

- **Behavior**: UseCollectionName
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


### <a name="BKMK_team_knowledgearticle"></a> team_knowledgearticle

Same as knowledgearticle entity [team_knowledgearticle](knowledgearticle.md#BKMK_team_knowledgearticle) Many-To-One relationship.

**ReferencingEntity**: knowledgearticle<br />
**ReferencingAttribute**: owningteam<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: team_knowledgearticle<br />
**AssociatedMenuConfiguration**:

- **Behavior**: UseCollectionName
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


### <a name="BKMK_team_sharepointsite"></a> team_sharepointsite

Same as sharepointsite entity [team_sharepointsite](sharepointsite.md#BKMK_team_sharepointsite) Many-To-One relationship.

**ReferencingEntity**: sharepointsite<br />
**ReferencingAttribute**: owningteam<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: team_sharepointsite<br />
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


### <a name="BKMK_team_sharepointdocumentlocation"></a> team_sharepointdocumentlocation

Same as sharepointdocumentlocation entity [team_sharepointdocumentlocation](sharepointdocumentlocation.md#BKMK_team_sharepointdocumentlocation) Many-To-One relationship.

**ReferencingEntity**: sharepointdocumentlocation<br />
**ReferencingAttribute**: owningteam<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: team_sharepointdocumentlocation<br />
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


### <a name="BKMK_team_goal"></a> team_goal

Same as goal entity [team_goal](goal.md#BKMK_team_goal) Many-To-One relationship.

**ReferencingEntity**: goal<br />
**ReferencingAttribute**: owningteam<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: team_goal<br />
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


### <a name="BKMK_team_goalrollupquery"></a> team_goalrollupquery

Same as goalrollupquery entity [team_goalrollupquery](goalrollupquery.md#BKMK_team_goalrollupquery) Many-To-One relationship.

**ReferencingEntity**: goalrollupquery<br />
**ReferencingAttribute**: owningteam<br />
**IsHierarchical**: False<br />
**IsCustomizable**: False<br />
**ReferencedEntityNavigationPropertyName**: team_goalrollupquery<br />
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


### <a name="BKMK_team_mailbox"></a> team_mailbox

Same as mailbox entity [team_mailbox](mailbox.md#BKMK_team_mailbox) Many-To-One relationship.

**ReferencingEntity**: mailbox<br />
**ReferencingAttribute**: owningteam<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: team_mailbox<br />
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


### <a name="BKMK_team_channelaccessprofile"></a> team_channelaccessprofile

Same as channelaccessprofile entity [team_channelaccessprofile](channelaccessprofile.md#BKMK_team_channelaccessprofile) Many-To-One relationship.

**ReferencingEntity**: channelaccessprofile<br />
**ReferencingAttribute**: owningteam<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: team_channelaccessprofile<br />
**AssociatedMenuConfiguration**:

- **Behavior**: UseCollectionName
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


### <a name="BKMK_team_externalparty"></a> team_externalparty

Same as externalparty entity [team_externalparty](externalparty.md#BKMK_team_externalparty) Many-To-One relationship.

**ReferencingEntity**: externalparty<br />
**ReferencingAttribute**: owningteam<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: team_externalparty<br />
**AssociatedMenuConfiguration**:

- **Behavior**: UseCollectionName
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


### <a name="BKMK_team_profilerule"></a> team_profilerule

Same as channelaccessprofilerule entity [team_profilerule](channelaccessprofilerule.md#BKMK_team_profilerule) Many-To-One relationship.

**ReferencingEntity**: channelaccessprofilerule<br />
**ReferencingAttribute**: owningteam<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: team_profilerule<br />
**AssociatedMenuConfiguration**:

- **Behavior**: UseCollectionName
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


### <a name="BKMK_team_connections2"></a> team_connections2

Same as connection entity [team_connections2](connection.md#BKMK_team_connections2) Many-To-One relationship.

**ReferencingEntity**: connection<br />
**ReferencingAttribute**: record2id<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: team_connections2<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
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


### <a name="BKMK_team_slaBase"></a> team_slaBase

Same as sla entity [team_slaBase](sla.md#BKMK_team_slaBase) Many-To-One relationship.

**ReferencingEntity**: sla<br />
**ReferencingAttribute**: owningteam<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: team_slaBase<br />
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


### <a name="BKMK_team_goal_goalowner"></a> team_goal_goalowner

Same as goal entity [team_goal_goalowner](goal.md#BKMK_team_goal_goalowner) Many-To-One relationship.

**ReferencingEntity**: goal<br />
**ReferencingAttribute**: goalownerid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: team_goal_goalowner<br />
**AssociatedMenuConfiguration**:

- **Behavior**: UseCollectionName
- **Group**: Details
- **Label**: 
- **Order**: 110

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: NoCascade
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_team_principalobjectattributeaccess"></a> team_principalobjectattributeaccess

Same as principalobjectattributeaccess entity [team_principalobjectattributeaccess](principalobjectattributeaccess.md#BKMK_team_principalobjectattributeaccess) Many-To-One relationship.

**ReferencingEntity**: principalobjectattributeaccess<br />
**ReferencingAttribute**: objectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: False<br />
**ReferencedEntityNavigationPropertyName**: team_principalobjectattributeaccess<br />
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


### <a name="BKMK_team_routingrule"></a> team_routingrule

Same as routingrule entity [team_routingrule](routingrule.md#BKMK_team_routingrule) Many-To-One relationship.

**ReferencingEntity**: routingrule<br />
**ReferencingAttribute**: owningteam<br />
**IsHierarchical**: False<br />
**IsCustomizable**: False<br />
**ReferencedEntityNavigationPropertyName**: team_routingrule<br />
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


### <a name="BKMK_OwningTeam_postfollows"></a> OwningTeam_postfollows

Same as postfollow entity [OwningTeam_postfollows](postfollow.md#BKMK_OwningTeam_postfollows) Many-To-One relationship.

**ReferencingEntity**: postfollow<br />
**ReferencingAttribute**: owningteam<br />
**IsHierarchical**: False<br />
**IsCustomizable**: False<br />
**ReferencedEntityNavigationPropertyName**: OwningTeam_postfollows<br />
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


### <a name="BKMK_team_ImportMaps"></a> team_ImportMaps

Same as importmap entity [team_ImportMaps](importmap.md#BKMK_team_ImportMaps) Many-To-One relationship.

**ReferencingEntity**: importmap<br />
**ReferencingAttribute**: owningteam<br />
**IsHierarchical**: False<br />
**IsCustomizable**: False<br />
**ReferencedEntityNavigationPropertyName**: team_ImportMaps<br />
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


### <a name="BKMK_team_recurringappointmentmaster"></a> team_recurringappointmentmaster

Same as recurringappointmentmaster entity [team_recurringappointmentmaster](recurringappointmentmaster.md#BKMK_team_recurringappointmentmaster) Many-To-One relationship.

**ReferencingEntity**: recurringappointmentmaster<br />
**ReferencingAttribute**: owningteam<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: team_recurringappointmentmaster<br />
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


### <a name="BKMK_team_userentityinstancedata"></a> team_userentityinstancedata

Same as userentityinstancedata entity [team_userentityinstancedata](userentityinstancedata.md#BKMK_team_userentityinstancedata) Many-To-One relationship.

**ReferencingEntity**: userentityinstancedata<br />
**ReferencingAttribute**: owningteam<br />
**IsHierarchical**: False<br />
**IsCustomizable**: False<br />
**ReferencedEntityNavigationPropertyName**: team_userentityinstancedata<br />
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


### <a name="BKMK_team_queueitembase_workerid"></a> team_queueitembase_workerid

Same as queueitem entity [team_queueitembase_workerid](queueitem.md#BKMK_team_queueitembase_workerid) Many-To-One relationship.

**ReferencingEntity**: queueitem<br />
**ReferencingAttribute**: workerid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: team_queueitembase_workerid<br />
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


### <a name="BKMK_team_phonecall"></a> team_phonecall

Same as phonecall entity [team_phonecall](phonecall.md#BKMK_team_phonecall) Many-To-One relationship.

**ReferencingEntity**: phonecall<br />
**ReferencingAttribute**: owningteam<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: team_phonecall<br />
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


### <a name="BKMK_team_emailserverprofile"></a> team_emailserverprofile

Same as emailserverprofile entity [team_emailserverprofile](emailserverprofile.md#BKMK_team_emailserverprofile) Many-To-One relationship.

**ReferencingEntity**: emailserverprofile<br />
**ReferencingAttribute**: owningteam<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: team_emailserverprofile<br />
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


### <a name="BKMK_team_connections1"></a> team_connections1

Same as connection entity [team_connections1](connection.md#BKMK_team_connections1) Many-To-One relationship.

**ReferencingEntity**: connection<br />
**ReferencingAttribute**: record1id<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: team_connections1<br />
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


### <a name="BKMK_team_actioncardusersettings"></a> team_actioncardusersettings

Same as actioncardusersettings entity [team_actioncardusersettings](actioncardusersettings.md#BKMK_team_actioncardusersettings) Many-To-One relationship.

**ReferencingEntity**: actioncardusersettings<br />
**ReferencingAttribute**: owningteam<br />
**IsHierarchical**: False<br />
**IsCustomizable**: False<br />
**ReferencedEntityNavigationPropertyName**: team_actioncardusersettings<br />
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


### <a name="BKMK_team_userqueryvisualizations"></a> team_userqueryvisualizations

Same as userqueryvisualization entity [team_userqueryvisualizations](userqueryvisualization.md#BKMK_team_userqueryvisualizations) Many-To-One relationship.

**ReferencingEntity**: userqueryvisualization<br />
**ReferencingAttribute**: owningteam<br />
**IsHierarchical**: False<br />
**IsCustomizable**: False<br />
**ReferencedEntityNavigationPropertyName**: team_userqueryvisualizations<br />
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


### <a name="BKMK_team_userform"></a> team_userform

Same as userform entity [team_userform](userform.md#BKMK_team_userform) Many-To-One relationship.

**ReferencingEntity**: userform<br />
**ReferencingAttribute**: owningteam<br />
**IsHierarchical**: False<br />
**IsCustomizable**: False<br />
**ReferencedEntityNavigationPropertyName**: team_userform<br />
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


### <a name="BKMK_team_socialactivity"></a> team_socialactivity

Same as socialactivity entity [team_socialactivity](socialactivity.md#BKMK_team_socialactivity) Many-To-One relationship.

**ReferencingEntity**: socialactivity<br />
**ReferencingAttribute**: owningteam<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: team_socialactivity<br />
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


### <a name="BKMK_Team_ProcessSessions"></a> Team_ProcessSessions

Same as processsession entity [Team_ProcessSessions](processsession.md#BKMK_Team_ProcessSessions) Many-To-One relationship.

**ReferencingEntity**: processsession<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: False<br />
**ReferencedEntityNavigationPropertyName**: Team_ProcessSessions<br />
**AssociatedMenuConfiguration**:

- **Behavior**: UseCollectionName
- **Group**: Details
- **Label**: 
- **Order**: 110

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: NoCascade
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_Team_DuplicateMatchingRecord"></a> Team_DuplicateMatchingRecord

Same as duplicaterecord entity [Team_DuplicateMatchingRecord](duplicaterecord.md#BKMK_Team_DuplicateMatchingRecord) Many-To-One relationship.

**ReferencingEntity**: duplicaterecord<br />
**ReferencingAttribute**: duplicaterecordid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: False<br />
**ReferencedEntityNavigationPropertyName**: Team_DuplicateMatchingRecord<br />
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


### <a name="BKMK_team_userentityuisettings"></a> team_userentityuisettings

Same as userentityuisettings entity [team_userentityuisettings](userentityuisettings.md#BKMK_team_userentityuisettings) Many-To-One relationship.

**ReferencingEntity**: userentityuisettings<br />
**ReferencingAttribute**: owningteam<br />
**IsHierarchical**: False<br />
**IsCustomizable**: False<br />
**ReferencedEntityNavigationPropertyName**: team_userentityuisettings<br />
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


### <a name="BKMK_team_contacts"></a> team_contacts

Same as contact entity [team_contacts](contact.md#BKMK_team_contacts) Many-To-One relationship.

**ReferencingEntity**: contact<br />
**ReferencingAttribute**: owningteam<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: team_contacts<br />
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


### <a name="BKMK_Team_AsyncOperations"></a> Team_AsyncOperations

Same as asyncoperation entity [Team_AsyncOperations](asyncoperation.md#BKMK_Team_AsyncOperations) Many-To-One relationship.

**ReferencingEntity**: asyncoperation<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: False<br />
**ReferencedEntityNavigationPropertyName**: Team_AsyncOperations<br />
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


### <a name="BKMK_team_ImportLogs"></a> team_ImportLogs

Same as importlog entity [team_ImportLogs](importlog.md#BKMK_team_ImportLogs) Many-To-One relationship.

**ReferencingEntity**: importlog<br />
**ReferencingAttribute**: owningteam<br />
**IsHierarchical**: False<br />
**IsCustomizable**: False<br />
**ReferencedEntityNavigationPropertyName**: team_ImportLogs<br />
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


### <a name="BKMK_team_workflowlog"></a> team_workflowlog

Same as workflowlog entity [team_workflowlog](workflowlog.md#BKMK_team_workflowlog) Many-To-One relationship.

**ReferencingEntity**: workflowlog<br />
**ReferencingAttribute**: owningteam<br />
**IsHierarchical**: False<br />
**IsCustomizable**: False<br />
**ReferencedEntityNavigationPropertyName**: team_workflowlog<br />
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


### <a name="BKMK_team_Imports"></a> team_Imports

Same as import entity [team_Imports](import.md#BKMK_team_Imports) Many-To-One relationship.

**ReferencingEntity**: import<br />
**ReferencingAttribute**: owningteam<br />
**IsHierarchical**: False<br />
**IsCustomizable**: False<br />
**ReferencedEntityNavigationPropertyName**: team_Imports<br />
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


### <a name="BKMK_team_processsession"></a> team_processsession

Same as processsession entity [team_processsession](processsession.md#BKMK_team_processsession) Many-To-One relationship.

**ReferencingEntity**: processsession<br />
**ReferencingAttribute**: owningteam<br />
**IsHierarchical**: False<br />
**IsCustomizable**: False<br />
**ReferencedEntityNavigationPropertyName**: team_processsession<br />
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


### <a name="BKMK_team_SyncError"></a> team_SyncError

Same as syncerror entity [team_SyncError](syncerror.md#BKMK_team_SyncError) Many-To-One relationship.

**ReferencingEntity**: syncerror<br />
**ReferencingAttribute**: owningteam<br />
**IsHierarchical**: False<br />
**IsCustomizable**: False<br />
**ReferencedEntityNavigationPropertyName**: team_SyncError<br />
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


### <a name="BKMK_team_letter"></a> team_letter

Same as letter entity [team_letter](letter.md#BKMK_team_letter) Many-To-One relationship.

**ReferencingEntity**: letter<br />
**ReferencingAttribute**: owningteam<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: team_letter<br />
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


### <a name="BKMK_team_annotations"></a> team_annotations

Same as annotation entity [team_annotations](annotation.md#BKMK_team_annotations) Many-To-One relationship.

**ReferencingEntity**: annotation<br />
**ReferencingAttribute**: owningteam<br />
**IsHierarchical**: False<br />
**IsCustomizable**: False<br />
**ReferencedEntityNavigationPropertyName**: team_annotations<br />
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


### <a name="BKMK_team_appointment"></a> team_appointment

Same as appointment entity [team_appointment](appointment.md#BKMK_team_appointment) Many-To-One relationship.

**ReferencingEntity**: appointment<br />
**ReferencingAttribute**: owningteam<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: team_appointment<br />
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


### <a name="BKMK_team_asyncoperation"></a> team_asyncoperation

Same as asyncoperation entity [team_asyncoperation](asyncoperation.md#BKMK_team_asyncoperation) Many-To-One relationship.

**ReferencingEntity**: asyncoperation<br />
**ReferencingAttribute**: owningteam<br />
**IsHierarchical**: False<br />
**IsCustomizable**: False<br />
**ReferencedEntityNavigationPropertyName**: team_asyncoperation<br />
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


### <a name="BKMK_userentityinstancedata_team"></a> userentityinstancedata_team

Same as userentityinstancedata entity [userentityinstancedata_team](userentityinstancedata.md#BKMK_userentityinstancedata_team) Many-To-One relationship.

**ReferencingEntity**: userentityinstancedata<br />
**ReferencingAttribute**: objectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: False<br />
**ReferencedEntityNavigationPropertyName**: userentityinstancedata_team<br />
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


### <a name="BKMK_Team_BulkDeleteFailures"></a> Team_BulkDeleteFailures

Same as bulkdeletefailure entity [Team_BulkDeleteFailures](bulkdeletefailure.md#BKMK_Team_BulkDeleteFailures) Many-To-One relationship.

**ReferencingEntity**: bulkdeletefailure<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: False<br />
**ReferencedEntityNavigationPropertyName**: Team_BulkDeleteFailures<br />
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


### <a name="BKMK_team_customer_relationship"></a> team_customer_relationship

Same as customerrelationship entity [team_customer_relationship](customerrelationship.md#BKMK_team_customer_relationship) Many-To-One relationship.

**ReferencingEntity**: customerrelationship<br />
**ReferencingAttribute**: owningteam<br />
**IsHierarchical**: False<br />
**IsCustomizable**: False<br />
**ReferencedEntityNavigationPropertyName**: team_customer_relationship<br />
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


### <a name="BKMK_Team_SyncErrors"></a> Team_SyncErrors

Same as syncerror entity [Team_SyncErrors](syncerror.md#BKMK_Team_SyncErrors) Many-To-One relationship.

**ReferencingEntity**: syncerror<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: Team_SyncErrors<br />
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


### <a name="BKMK_team_convertrule"></a> team_convertrule

Same as convertrule entity [team_convertrule](convertrule.md#BKMK_team_convertrule) Many-To-One relationship.

**ReferencingEntity**: convertrule<br />
**ReferencingAttribute**: owningteam<br />
**IsHierarchical**: False<br />
**IsCustomizable**: False<br />
**ReferencedEntityNavigationPropertyName**: team_convertrule<br />
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


### <a name="BKMK_team_mailboxtrackingfolder"></a> team_mailboxtrackingfolder

Same as mailboxtrackingfolder entity [team_mailboxtrackingfolder](mailboxtrackingfolder.md#BKMK_team_mailboxtrackingfolder) Many-To-One relationship.

**ReferencingEntity**: mailboxtrackingfolder<br />
**ReferencingAttribute**: owningteam<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: team_mailboxtrackingfolder<br />
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


### <a name="BKMK_team_task"></a> team_task

Same as task entity [team_task](task.md#BKMK_team_task) Many-To-One relationship.

**ReferencingEntity**: task<br />
**ReferencingAttribute**: owningteam<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: team_task<br />
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


### <a name="BKMK_team_activity"></a> team_activity

Same as activitypointer entity [team_activity](activitypointer.md#BKMK_team_activity) Many-To-One relationship.

**ReferencingEntity**: activitypointer<br />
**ReferencingAttribute**: owningteam<br />
**IsHierarchical**: False<br />
**IsCustomizable**: False<br />
**ReferencedEntityNavigationPropertyName**: team_activity<br />
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


### <a name="BKMK_Team_DuplicateBaseRecord"></a> Team_DuplicateBaseRecord

Same as duplicaterecord entity [Team_DuplicateBaseRecord](duplicaterecord.md#BKMK_Team_DuplicateBaseRecord) Many-To-One relationship.

**ReferencingEntity**: duplicaterecord<br />
**ReferencingAttribute**: baserecordid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: False<br />
**ReferencedEntityNavigationPropertyName**: Team_DuplicateBaseRecord<br />
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


### <a name="BKMK_team_accounts"></a> team_accounts

Same as account entity [team_accounts](account.md#BKMK_team_accounts) Many-To-One relationship.

**ReferencingEntity**: account<br />
**ReferencingAttribute**: owningteam<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: team_accounts<br />
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


### <a name="BKMK_team_userquery"></a> team_userquery

Same as userquery entity [team_userquery](userquery.md#BKMK_team_userquery) Many-To-One relationship.

**ReferencingEntity**: userquery<br />
**ReferencingAttribute**: owningteam<br />
**IsHierarchical**: False<br />
**IsCustomizable**: False<br />
**ReferencedEntityNavigationPropertyName**: team_userquery<br />
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


### <a name="BKMK_team_email"></a> team_email

Same as email entity [team_email](email.md#BKMK_team_email) Many-To-One relationship.

**ReferencingEntity**: email<br />
**ReferencingAttribute**: owningteam<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: team_email<br />
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


### <a name="BKMK_ImportFile_Team"></a> ImportFile_Team

Same as importfile entity [ImportFile_Team](importfile.md#BKMK_ImportFile_Team) Many-To-One relationship.

**ReferencingEntity**: importfile<br />
**ReferencingAttribute**: recordsownerid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: False<br />
**ReferencedEntityNavigationPropertyName**: ImportFile_Team<br />
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


### <a name="BKMK_team_ImportFiles"></a> team_ImportFiles

Same as importfile entity [team_ImportFiles](importfile.md#BKMK_team_ImportFiles) Many-To-One relationship.

**ReferencingEntity**: importfile<br />
**ReferencingAttribute**: owningteam<br />
**IsHierarchical**: False<br />
**IsCustomizable**: False<br />
**ReferencedEntityNavigationPropertyName**: team_ImportFiles<br />
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


### <a name="BKMK_team_email_templates"></a> team_email_templates

Same as template entity [team_email_templates](template.md#BKMK_team_email_templates) Many-To-One relationship.

**ReferencingEntity**: template<br />
**ReferencingAttribute**: owningteam<br />
**IsHierarchical**: False<br />
**IsCustomizable**: False<br />
**ReferencedEntityNavigationPropertyName**: team_email_templates<br />
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


### <a name="BKMK_team_fax"></a> team_fax

Same as fax entity [team_fax](fax.md#BKMK_team_fax) Many-To-One relationship.

**ReferencingEntity**: fax<br />
**ReferencingAttribute**: owningteam<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: team_fax<br />
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


### <a name="BKMK_team_routingruleitem"></a> team_routingruleitem

Same as routingruleitem entity [team_routingruleitem](routingruleitem.md#BKMK_team_routingruleitem) Many-To-One relationship.

**ReferencingEntity**: routingruleitem<br />
**ReferencingAttribute**: assignobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: False<br />
**ReferencedEntityNavigationPropertyName**: team_routingruleitem<br />
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


### <a name="BKMK_team_DuplicateRules"></a> team_DuplicateRules

Same as duplicaterule entity [team_DuplicateRules](duplicaterule.md#BKMK_team_DuplicateRules) Many-To-One relationship.

**ReferencingEntity**: duplicaterule<br />
**ReferencingAttribute**: owningteam<br />
**IsHierarchical**: False<br />
**IsCustomizable**: False<br />
**ReferencedEntityNavigationPropertyName**: team_DuplicateRules<br />
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


### <a name="BKMK_team_workflow"></a> team_workflow

Same as workflow entity [team_workflow](workflow.md#BKMK_team_workflow) Many-To-One relationship.

**ReferencingEntity**: workflow<br />
**ReferencingAttribute**: owningteam<br />
**IsHierarchical**: False<br />
**IsCustomizable**: False<br />
**ReferencedEntityNavigationPropertyName**: team_workflow<br />
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

<a name="manytoone"></a>

## Many-To-One Relationships

Each Many-To-One relationship is defined by a corresponding One-To-Many relationship with the related entity. Listed by **SchemaName**.

- [opportunity_Teams](#BKMK_opportunity_Teams)
- [knowledgearticle_Teams](#BKMK_knowledgearticle_Teams)
- [teamtemplate_Teams](#BKMK_teamtemplate_Teams)
- [lk_teambase_administratorid](#BKMK_lk_teambase_administratorid)
- [processstage_teams](#BKMK_processstage_teams)
- [lk_teambase_modifiedby](#BKMK_lk_teambase_modifiedby)
- [lk_teambase_createdby](#BKMK_lk_teambase_createdby)
- [queue_team](#BKMK_queue_team)
- [TransactionCurrency_Team](#BKMK_TransactionCurrency_Team)
- [business_unit_teams](#BKMK_business_unit_teams)
- [organization_teams](#BKMK_organization_teams)
- [lk_team_modifiedonbehalfby](#BKMK_lk_team_modifiedonbehalfby)
- [lk_team_createdonbehalfby](#BKMK_lk_team_createdonbehalfby)


### <a name="BKMK_opportunity_Teams"></a> opportunity_Teams

See opportunity Entity [opportunity_Teams](opportunity.md#BKMK_opportunity_Teams) One-To-Many relationship.

### <a name="BKMK_knowledgearticle_Teams"></a> knowledgearticle_Teams

See knowledgearticle Entity [knowledgearticle_Teams](knowledgearticle.md#BKMK_knowledgearticle_Teams) One-To-Many relationship.

### <a name="BKMK_teamtemplate_Teams"></a> teamtemplate_Teams

See teamtemplate Entity [teamtemplate_Teams](teamtemplate.md#BKMK_teamtemplate_Teams) One-To-Many relationship.

### <a name="BKMK_lk_teambase_administratorid"></a> lk_teambase_administratorid

See systemuser Entity [lk_teambase_administratorid](systemuser.md#BKMK_lk_teambase_administratorid) One-To-Many relationship.

### <a name="BKMK_processstage_teams"></a> processstage_teams

See processstage Entity [processstage_teams](processstage.md#BKMK_processstage_teams) One-To-Many relationship.

### <a name="BKMK_lk_teambase_modifiedby"></a> lk_teambase_modifiedby

See systemuser Entity [lk_teambase_modifiedby](systemuser.md#BKMK_lk_teambase_modifiedby) One-To-Many relationship.

### <a name="BKMK_lk_teambase_createdby"></a> lk_teambase_createdby

See systemuser Entity [lk_teambase_createdby](systemuser.md#BKMK_lk_teambase_createdby) One-To-Many relationship.

### <a name="BKMK_queue_team"></a> queue_team

See queue Entity [queue_team](queue.md#BKMK_queue_team) One-To-Many relationship.

### <a name="BKMK_TransactionCurrency_Team"></a> TransactionCurrency_Team

See transactioncurrency Entity [TransactionCurrency_Team](transactioncurrency.md#BKMK_TransactionCurrency_Team) One-To-Many relationship.

### <a name="BKMK_business_unit_teams"></a> business_unit_teams

See businessunit Entity [business_unit_teams](businessunit.md#BKMK_business_unit_teams) One-To-Many relationship.

### <a name="BKMK_organization_teams"></a> organization_teams

See organization Entity [organization_teams](organization.md#BKMK_organization_teams) One-To-Many relationship.

### <a name="BKMK_lk_team_modifiedonbehalfby"></a> lk_team_modifiedonbehalfby

See systemuser Entity [lk_team_modifiedonbehalfby](systemuser.md#BKMK_lk_team_modifiedonbehalfby) One-To-Many relationship.

### <a name="BKMK_lk_team_createdonbehalfby"></a> lk_team_createdonbehalfby

See systemuser Entity [lk_team_createdonbehalfby](systemuser.md#BKMK_lk_team_createdonbehalfby) One-To-Many relationship.
<a name="manytomany"></a>

## Many-To-Many Relationships

Relationship details provided where the Team entity is the first entity in the relationship. Listed by **SchemaName**.

- [teamroles_association](#BKMK_teamroles_association)
- [teammembership_association](#BKMK_teammembership_association)
- [teamprofiles_association](#BKMK_teamprofiles_association)


### <a name="BKMK_teamroles_association"></a> teamroles_association

**IntersectEntityName**: teamroles<br />
**Entity1LogicalName**: team<br />

- **Entity1IntersectAttribute**: teamid
- **Entity1NavigationPropertyName**: teamroles_association
- **Entity1AssociatedMenuConfiguration**:

  - **Behavior**: DoNotDisplay
  - **Group**: Details
  - **Label**: 
  - **Order**: 

**Entity2LogicalName**: [role](role.md)<br />

- **Entity2IntersectAttribute**: roleid
- **Entity2NavigationPropertyName**: teamroles_association
- **Entity2AssociatedMenuConfiguration**:

  - **Behavior**: DoNotDisplay
  - **Group**: Details
  - **Label**: 
  - **Order**: 

**IsCustomizable**: False<br />

### <a name="BKMK_teammembership_association"></a> teammembership_association

**IntersectEntityName**: teammembership<br />
**Entity1LogicalName**: team<br />

- **Entity1IntersectAttribute**: teamid
- **Entity1NavigationPropertyName**: teammembership_association
- **Entity1AssociatedMenuConfiguration**:

  - **Behavior**: DoNotDisplay
  - **Group**: Details
  - **Label**: 
  - **Order**: 

**Entity2LogicalName**: [systemuser](systemuser.md)<br />

- **Entity2IntersectAttribute**: systemuserid
- **Entity2NavigationPropertyName**: teammembership_association
- **Entity2AssociatedMenuConfiguration**:

  - **Behavior**: DoNotDisplay
  - **Group**: Details
  - **Label**: 
  - **Order**: 

**IsCustomizable**: False<br />

### <a name="BKMK_teamprofiles_association"></a> teamprofiles_association

**IntersectEntityName**: teamprofiles<br />
**Entity1LogicalName**: team<br />

- **Entity1IntersectAttribute**: teamid
- **Entity1NavigationPropertyName**: teamprofiles_association
- **Entity1AssociatedMenuConfiguration**:

  - **Behavior**: UseCollectionName
  - **Group**: Details
  - **Label**: 
  - **Order**: 

**Entity2LogicalName**: [fieldsecurityprofile](fieldsecurityprofile.md)<br />

- **Entity2IntersectAttribute**: fieldsecurityprofileid
- **Entity2NavigationPropertyName**: teamprofiles_association
- **Entity2AssociatedMenuConfiguration**:

  - **Behavior**: UseCollectionName
  - **Group**: Details
  - **Label**: 
  - **Order**: 

**IsCustomizable**: False<br />

## See also

[About the Entity Reference](../about-entity-reference.md)<br />
[Programming reference for Dynamics 365 Customer Engagement](../programming-reference.md)<br />
[Web API Reference](/dynamics365/customer-engagement/web-api/about)<br />
<xref href="Microsoft.Dynamics.CRM.team?text=team EntityType" />