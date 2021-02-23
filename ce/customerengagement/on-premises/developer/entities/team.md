---
title: "Team Entity Reference (Dynamics 365 Customer Engagement)| MicrosoftDocs"
description: "Includes schema information and supported messages for the Team entity."
ms.date: 09/16/2020
ms.service: "crm-online"
ms.topic: "reference"
ms.assetid: 3948cc48-07c8-7f60-0608-71c37158ad7c
author: "KumarVivek"
ms.author: "kvivek"
manager: "annbe"
search.audienceType: 
  - developer

---
# Team Entity Reference

Collection of system users that routinely collaborate. Teams can be used to simplify record sharing and provide team members with common access to organization data when team members belong to different Business Units.


## Messages

|Message|Web API Operation|SDK Assembly|
|-|-|-|
|AddMembersTeam|<xref href="Microsoft.Dynamics.CRM.AddMembersTeam?text=AddMembersTeam Action" />|<xref:Microsoft.Crm.Sdk.Messages.AddMembersTeamRequest>|
|ConvertOwnerTeamToAccessTeam|<xref href="Microsoft.Dynamics.CRM.ConvertOwnerTeamToAccessTeam?text=ConvertOwnerTeamToAccessTeam Action" />|<xref:Microsoft.Crm.Sdk.Messages.ConvertOwnerTeamToAccessTeamRequest>|
|Create|POST [*org URI*]/api/data/v9.0/teams<br />See [Create](/powerapps/developer/common-data-service/webapi/create-entity-web-api)|<xref:Microsoft.Xrm.Sdk.Messages.CreateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Create*>|
|Delete|DELETE [*org URI*]/api/data/v9.0/teams(*teamid*)<br />See [Delete](/powerapps/developer/common-data-service/webapi/update-delete-entities-using-web-api#basic-delete)|<xref:Microsoft.Xrm.Sdk.Messages.DeleteRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Delete*>|
|RemoveMembersTeam|<xref href="Microsoft.Dynamics.CRM.RemoveMembersTeam?text=RemoveMembersTeam Action" />|<xref:Microsoft.Crm.Sdk.Messages.RemoveMembersTeamRequest>|
|Retrieve|GET [*org URI*]/api/data/v9.0/teams(*teamid*)<br />See [Retrieve](/powerapps/developer/common-data-service/webapi/retrieve-entity-using-web-api)|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Retrieve*>|
|RetrieveMultiple|GET [*org URI*]/api/data/v9.0/teams<br />See [Query Data](/powerapps/developer/common-data-service/webapi/query-data-web-api)|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveMultipleRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.RetrieveMultiple*>|
|SetParentBusinessUnit|[Associate and disassociate entities](/powerapps/developer/common-data-service/webapi/associate-disassociate-entities-using-web-api)|<xref:Microsoft.Crm.Sdk.Messages.SetParentBusinessUnitRequest>|
|SetParentSystemUser|<xref href="Microsoft.Dynamics.CRM.SetParentSystemUser?text=SetParentSystemUser Action" />|<xref:Microsoft.Crm.Sdk.Messages.SetParentSystemUserRequest>|
|SetParentTeam|[Associate and disassociate entities](/powerapps/developer/common-data-service/webapi/associate-disassociate-entities-using-web-api)|<xref:Microsoft.Crm.Sdk.Messages.SetParentTeamRequest>|
|Update|PATCH [*org URI*]/api/data/v9.0/teams(*teamid*)<br />See [Update](/powerapps/developer/common-data-service/webapi/update-delete-entities-using-web-api#basic-update)|<xref:Microsoft.Xrm.Sdk.Messages.UpdateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Update*>|

## Entity Properties

|Property|Value|
|--------|-----|
|CollectionSchemaName|Teams|
|DisplayCollectionName|Teams|
|DisplayName|Team|
|EntitySetName|teams|
|IsBPFEntity|False|
|LogicalCollectionName|teams|
|LogicalName|team|
|OwnershipType|BusinessOwned|
|PrimaryIdAttribute|teamid|
|PrimaryNameAttribute|name|
|SchemaName|Team|

<a name="writable-attributes"></a>

## Writable attributes

These attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [AdministratorId](#BKMK_AdministratorId)
- [AzureActiveDirectoryObjectId](#BKMK_AzureActiveDirectoryObjectId)
- [BusinessUnitId](#BKMK_BusinessUnitId)
- [Description](#BKMK_Description)
- [EMailAddress](#BKMK_EMailAddress)
- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [MembershipType](#BKMK_MembershipType)
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

|Property|Value|
|--------|-----|
|Description|Unique identifier of the user primary responsible for the team.|
|DisplayName|Administrator|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|administratorid|
|RequiredLevel|SystemRequired|
|Targets|systemuser|
|Type|Lookup|


### <a name="BKMK_AzureActiveDirectoryObjectId"></a> AzureActiveDirectoryObjectId

|Property|Value|
|--------|-----|
|Description|The Azure active directory object Id for a group.|
|DisplayName|Azure AD Object Id for a group|
|IsValidForForm|True|
|IsValidForRead|True|
|IsValidForUpdate|False|
|LogicalName|azureactivedirectoryobjectid|
|RequiredLevel|None|
|Type|Uniqueidentifier|


### <a name="BKMK_BusinessUnitId"></a> BusinessUnitId

|Property|Value|
|--------|-----|
|Description|Unique identifier of the business unit with which the team is associated.|
|DisplayName|Business Unit|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|businessunitid|
|RequiredLevel|SystemRequired|
|Targets|businessunit|
|Type|Lookup|


### <a name="BKMK_Description"></a> Description

|Property|Value|
|--------|-----|
|Description|Description of the team.|
|DisplayName|Description|
|Format|TextArea|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|description|
|MaxLength|2000|
|RequiredLevel|None|
|Type|Memo|


### <a name="BKMK_EMailAddress"></a> EMailAddress

|Property|Value|
|--------|-----|
|Description|Email address for the team.|
|DisplayName|Email|
|FormatName|Email|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|emailaddress|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_ImportSequenceNumber"></a> ImportSequenceNumber

|Property|Value|
|--------|-----|
|Description|Unique identifier of the data import or data migration that created this record.|
|DisplayName|Import Sequence Number|
|Format|None|
|IsValidForForm|False|
|IsValidForRead|True|
|IsValidForUpdate|False|
|LogicalName|importsequencenumber|
|MaxValue|2147483647|
|MinValue|-2147483648|
|RequiredLevel|None|
|Type|Integer|


### <a name="BKMK_MembershipType"></a> MembershipType

|Property|Value|
|--------|-----|
|Description|Information about team membership type.|
|DisplayName|Team Membership Type|
|IsValidForForm|True|
|IsValidForRead|True|
|IsValidForUpdate|False|
|LogicalName|membershiptype|
|RequiredLevel|SystemRequired|
|Type|Picklist|

#### MembershipType Options

|Value|Label|
|-----|-----|
|0|Members and guests|
|1|Members|
|2|Owners|
|3|Guests|



### <a name="BKMK_Name"></a> Name

|Property|Value|
|--------|-----|
|Description|Name of the team.|
|DisplayName|Team Name|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|name|
|MaxLength|160|
|RequiredLevel|SystemRequired|
|Type|String|


### <a name="BKMK_OverriddenCreatedOn"></a> OverriddenCreatedOn

|Property|Value|
|--------|-----|
|DateTimeBehavior|UserLocal|
|Description|Date and time that the record was migrated.|
|DisplayName|Record Created On|
|Format|DateOnly|
|IsValidForForm|False|
|IsValidForRead|True|
|IsValidForUpdate|False|
|LogicalName|overriddencreatedon|
|RequiredLevel|None|
|Type|DateTime|


### <a name="BKMK_ProcessId"></a> ProcessId

|Property|Value|
|--------|-----|
|Description|Shows the ID of the process.|
|DisplayName|Process|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|processid|
|RequiredLevel|None|
|Type|Uniqueidentifier|


### <a name="BKMK_QueueId"></a> QueueId

|Property|Value|
|--------|-----|
|Description|Unique identifier of the default queue for the team.|
|DisplayName|Default Queue|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|queueid|
|RequiredLevel|None|
|Targets|queue|
|Type|Lookup|


### <a name="BKMK_RegardingObjectId"></a> RegardingObjectId

|Property|Value|
|--------|-----|
|Description|Choose the record that the team relates to.|
|DisplayName|Regarding Object Id|
|IsValidForForm|False|
|IsValidForRead|True|
|IsValidForUpdate|False|
|LogicalName|regardingobjectid|
|RequiredLevel|None|
|Targets|knowledgearticle,opportunity|
|Type|Lookup|


### <a name="BKMK_RegardingObjectTypeCode"></a> RegardingObjectTypeCode

|Property|Value|
|--------|-----|
|Description|Type of the associated record for team - used for system managed access teams only.|
|DisplayName|Regarding Object Type|
|IsValidForForm|False|
|IsValidForRead|True|
|IsValidForUpdate|False|
|LogicalName|regardingobjecttypecode|
|RequiredLevel|None|
|Type|EntityName|


### <a name="BKMK_StageId"></a> StageId

|Property|Value|
|--------|-----|
|Description|Shows the ID of the stage.|
|DisplayName|(Deprecated) Process Stage|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|stageid|
|RequiredLevel|None|
|Type|Uniqueidentifier|


### <a name="BKMK_TeamId"></a> TeamId

|Property|Value|
|--------|-----|
|Description|Unique identifier for the team.|
|DisplayName|Team|
|IsValidForForm|False|
|IsValidForRead|True|
|IsValidForUpdate|False|
|LogicalName|teamid|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|


### <a name="BKMK_TeamTemplateId"></a> TeamTemplateId

|Property|Value|
|--------|-----|
|Description|Shows the team template that is associated with the team.|
|DisplayName|Team Template Identifier|
|IsValidForForm|True|
|IsValidForRead|True|
|IsValidForUpdate|False|
|LogicalName|teamtemplateid|
|RequiredLevel|None|
|Targets|teamtemplate|
|Type|Lookup|


### <a name="BKMK_TeamType"></a> TeamType

|Property|Value|
|--------|-----|
|Description|Select the team type.|
|DisplayName|Team Type|
|IsValidForForm|True|
|IsValidForRead|True|
|IsValidForUpdate|False|
|LogicalName|teamtype|
|RequiredLevel|SystemRequired|
|Type|Picklist|

#### TeamType Options

|Value|Label|
|-----|-----|
|0|Owner|
|1|Access|
|2|AAD Security Group|
|3|AAD Office Group|



### <a name="BKMK_TransactionCurrencyId"></a> TransactionCurrencyId

|Property|Value|
|--------|-----|
|Description|Unique identifier of the currency associated with the team.|
|DisplayName|Currency|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|transactioncurrencyid|
|RequiredLevel|None|
|Targets|transactioncurrency|
|Type|Lookup|


### <a name="BKMK_TraversedPath"></a> TraversedPath

|Property|Value|
|--------|-----|
|Description|For internal use only.|
|DisplayName|(Deprecated) Traversed Path|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|traversedpath|
|MaxLength|1250|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_YomiName"></a> YomiName

|Property|Value|
|--------|-----|
|Description|Pronunciation of the full name of the team, written in phonetic hiragana or katakana characters.|
|DisplayName|Yomi Name|
|FormatName|PhoneticGuide|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|yominame|
|MaxLength|160|
|RequiredLevel|None|
|Type|String|

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

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|administratoridname|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_AdministratorIdYomiName"></a> AdministratorIdYomiName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|administratoridyominame|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_BusinessUnitIdName"></a> BusinessUnitIdName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|businessunitidname|
|MaxLength|100|
|RequiredLevel|SystemRequired|
|Type|String|


### <a name="BKMK_CreatedBy"></a> CreatedBy

|Property|Value|
|--------|-----|
|Description|Unique identifier of the user who created the team.|
|DisplayName|Created By|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|createdby|
|RequiredLevel|None|
|Targets|systemuser|
|Type|Lookup|


### <a name="BKMK_CreatedByName"></a> CreatedByName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|createdbyname|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_CreatedByYomiName"></a> CreatedByYomiName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|createdbyyominame|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_CreatedOn"></a> CreatedOn

|Property|Value|
|--------|-----|
|DateTimeBehavior|UserLocal|
|Description|Date and time when the team was created.|
|DisplayName|Created On|
|Format|DateAndTime|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|createdon|
|RequiredLevel|None|
|Type|DateTime|


### <a name="BKMK_CreatedOnBehalfBy"></a> CreatedOnBehalfBy

|Property|Value|
|--------|-----|
|Description|Unique identifier of the delegate user who created the team.|
|DisplayName|Created By (Delegate)|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|createdonbehalfby|
|RequiredLevel|None|
|Targets|systemuser|
|Type|Lookup|


### <a name="BKMK_CreatedOnBehalfByName"></a> CreatedOnBehalfByName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|createdonbehalfbyname|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_CreatedOnBehalfByYomiName"></a> CreatedOnBehalfByYomiName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|createdonbehalfbyyominame|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_ExchangeRate"></a> ExchangeRate

|Property|Value|
|--------|-----|
|Description|Exchange rate for the currency associated with the team with respect to the base currency.|
|DisplayName|Exchange Rate|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|exchangerate|
|MaxValue|100000000000|
|MinValue|0.0000000001|
|Precision|10|
|RequiredLevel|None|
|Type|Decimal|


### <a name="BKMK_IsDefault"></a> IsDefault

|Property|Value|
|--------|-----|
|Description|Information about whether the team is a default business unit team.|
|DisplayName|Is Default|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|isdefault|
|RequiredLevel|SystemRequired|
|Type|Boolean|

#### IsDefault Options

|Value|Label|
|-----|-----|
|1|Yes|
|0|No|

**DefaultValue**: False



### <a name="BKMK_ModifiedBy"></a> ModifiedBy

|Property|Value|
|--------|-----|
|Description|Unique identifier of the user who last modified the team.|
|DisplayName|Modified By|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|modifiedby|
|RequiredLevel|None|
|Targets|systemuser|
|Type|Lookup|


### <a name="BKMK_ModifiedByName"></a> ModifiedByName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|modifiedbyname|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_ModifiedByYomiName"></a> ModifiedByYomiName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|modifiedbyyominame|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_ModifiedOn"></a> ModifiedOn

|Property|Value|
|--------|-----|
|DateTimeBehavior|UserLocal|
|Description|Date and time when the team was last modified.|
|DisplayName|Modified On|
|Format|DateAndTime|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|modifiedon|
|RequiredLevel|None|
|Type|DateTime|


### <a name="BKMK_ModifiedOnBehalfBy"></a> ModifiedOnBehalfBy

|Property|Value|
|--------|-----|
|Description|Unique identifier of the delegate user who last modified the team.|
|DisplayName|Modified By (Delegate)|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|modifiedonbehalfby|
|RequiredLevel|None|
|Targets|systemuser|
|Type|Lookup|


### <a name="BKMK_ModifiedOnBehalfByName"></a> ModifiedOnBehalfByName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|modifiedonbehalfbyname|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_ModifiedOnBehalfByYomiName"></a> ModifiedOnBehalfByYomiName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|modifiedonbehalfbyyominame|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_OrganizationId"></a> OrganizationId

|Property|Value|
|--------|-----|
|Description|Unique identifier of the organization associated with the team.|
|DisplayName|Organization |
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|organizationid|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|


### <a name="BKMK_OrganizationIdName"></a> OrganizationIdName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|organizationidname|
|MaxLength|100|
|RequiredLevel|SystemRequired|
|Type|String|


### <a name="BKMK_QueueIdName"></a> QueueIdName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|queueidname|
|MaxLength|400|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_SystemManaged"></a> SystemManaged

|Property|Value|
|--------|-----|
|Description|Select whether the team will be managed by the system.|
|DisplayName|Is System Managed|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|systemmanaged|
|RequiredLevel|SystemRequired|
|Type|Boolean|

#### SystemManaged Options

|Value|Label|
|-----|-----|
|1|Yes|
|0|No|

**DefaultValue**: False



### <a name="BKMK_TransactionCurrencyIdName"></a> TransactionCurrencyIdName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|transactioncurrencyidname|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_VersionNumber"></a> VersionNumber

|Property|Value|
|--------|-----|
|Description|Version number of the team.|
|DisplayName|Version number|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|versionnumber|
|MaxValue|9223372036854775807|
|MinValue|-9223372036854775808|
|RequiredLevel|None|
|Type|BigInt|

<a name="onetomany"></a>

## One-To-Many Relationships

Listed by **SchemaName**.

- [lead_owning_team](#BKMK_lead_owning_team)
- [team_DynamicPropertyInstance](#BKMK_team_DynamicPropertyInstance)
- [team_bookableresource](#BKMK_team_bookableresource)
- [team_bookableresourcebooking](#BKMK_team_bookableresourcebooking)
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
- [team_entitlemententityallocationtypemapping](#BKMK_team_entitlemententityallocationtypemapping)
- [team_msdyn_callablecontext](#BKMK_team_msdyn_callablecontext)
- [team_msdyn_playbookactivity](#BKMK_team_msdyn_playbookactivity)
- [team_msdyn_playbookactivityattribute](#BKMK_team_msdyn_playbookactivityattribute)
- [team_msdyn_playbookcategory](#BKMK_team_msdyn_playbookcategory)
- [team_msdyn_playbookinstance](#BKMK_team_msdyn_playbookinstance)
- [team_msdyn_playbooktemplate](#BKMK_team_msdyn_playbooktemplate)
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
- [team_adminsettingsentity](#BKMK_team_adminsettingsentity)
- [team_msdyn_forecastdefinition](#BKMK_team_msdyn_forecastdefinition)
- [team_msdyn_forecastinstance](#BKMK_team_msdyn_forecastinstance)
- [team_msdyn_forecastrecurrence](#BKMK_team_msdyn_forecastrecurrence)
- [team_msdyn_relationshipinsightsunifiedconfig](#BKMK_team_msdyn_relationshipinsightsunifiedconfig)
- [team_msdyn_siconfig](#BKMK_team_msdyn_siconfig)
- [team_msdyn_untrackedappointment](#BKMK_team_msdyn_untrackedappointment)
- [team_msdyn_notesanalysisconfig](#BKMK_team_msdyn_notesanalysisconfig)
- [team_msdyn_icebreakersconfig](#BKMK_team_msdyn_icebreakersconfig)
- [team_msdyn_postalbum](#BKMK_team_msdyn_postalbum)
- [team_msdyn_wallsavedqueryusersettings](#BKMK_team_msdyn_wallsavedqueryusersettings)
- [team_msdyn_actual](#BKMK_team_msdyn_actual)
- [team_msdyn_bookableresourceassociation](#BKMK_team_msdyn_bookableresourceassociation)
- [msdyn_bookingalert_team_owningteam](#BKMK_msdyn_bookingalert_team_owningteam)
- [team_msdyn_bookingalertstatus](#BKMK_team_msdyn_bookingalertstatus)
- [team_msdyn_bookingchange](#BKMK_team_msdyn_bookingchange)
- [team_msdyn_bookingrule](#BKMK_team_msdyn_bookingrule)
- [team_msdyn_bookingsetupmetadata](#BKMK_team_msdyn_bookingsetupmetadata)
- [team_msdyn_businessclosure](#BKMK_team_msdyn_businessclosure)
- [team_msdyn_clientextension](#BKMK_team_msdyn_clientextension)
- [team_msdyn_configuration](#BKMK_team_msdyn_configuration)
- [team_msdyn_priority](#BKMK_team_msdyn_priority)
- [team_msdyn_requirementcharacteristic](#BKMK_team_msdyn_requirementcharacteristic)
- [team_msdyn_requirementgroup](#BKMK_team_msdyn_requirementgroup)
- [team_msdyn_requirementorganizationunit](#BKMK_team_msdyn_requirementorganizationunit)
- [team_msdyn_requirementrelationship](#BKMK_team_msdyn_requirementrelationship)
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
- [team_msdyn_dimension](#BKMK_team_msdyn_dimension)
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
- [team_msdyn_customerassetcategory](#BKMK_team_msdyn_customerassetcategory)
- [team_msdyn_entitlementapplication](#BKMK_team_msdyn_entitlementapplication)
- [team_msdyn_fieldservicesetting](#BKMK_team_msdyn_fieldservicesetting)
- [team_msdyn_fieldserviceslaconfiguration](#BKMK_team_msdyn_fieldserviceslaconfiguration)
- [team_msdyn_incidenttype](#BKMK_team_msdyn_incidenttype)
- [team_msdyn_incidenttypecharacteristic](#BKMK_team_msdyn_incidenttypecharacteristic)
- [team_msdyn_incidenttypeproduct](#BKMK_team_msdyn_incidenttypeproduct)
- [team_msdyn_incidenttypeservice](#BKMK_team_msdyn_incidenttypeservice)
- [team_msdyn_incidenttypeservicetask](#BKMK_team_msdyn_incidenttypeservicetask)
- [team_msdyn_incidenttypessetup](#BKMK_team_msdyn_incidenttypessetup)
- [team_msdyn_incidenttype_requirementgroup](#BKMK_team_msdyn_incidenttype_requirementgroup)
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
- [team_msdyn_iotalert](#BKMK_team_msdyn_iotalert)
- [team_msdyn_iotdevice](#BKMK_team_msdyn_iotdevice)
- [team_msdyn_iotdevicecategory](#BKMK_team_msdyn_iotdevicecategory)
- [team_msdyn_iotdevicecommand](#BKMK_team_msdyn_iotdevicecommand)
- [team_msdyn_iotdevicecommanddefinition](#BKMK_team_msdyn_iotdevicecommanddefinition)
- [team_msdyn_iotdevicedatahistory](#BKMK_team_msdyn_iotdevicedatahistory)
- [team_msdyn_iotdeviceproperty](#BKMK_team_msdyn_iotdeviceproperty)
- [team_msdyn_iotdeviceregistrationhistory](#BKMK_team_msdyn_iotdeviceregistrationhistory)
- [team_msdyn_iotpropertydefinition](#BKMK_team_msdyn_iotpropertydefinition)
- [team_msdyn_iotsettings](#BKMK_team_msdyn_iotsettings)
- [team_msdyn_entityconfiguration](#BKMK_team_msdyn_entityconfiguration)
- [team_msdyn_geofence](#BKMK_team_msdyn_geofence)
- [team_msdyn_geofenceevent](#BKMK_team_msdyn_geofenceevent)
- [team_msdyn_geofencingsettings](#BKMK_team_msdyn_geofencingsettings)
- [team_msdyn_connector](#BKMK_team_msdyn_connector)
- [team_principalobjectattributeaccess_principalid](#BKMK_team_principalobjectattributeaccess_principalid)
- [team_exchangesyncidmapping](#BKMK_team_exchangesyncidmapping)
- [team_interactionforemail](#BKMK_team_interactionforemail)
- [team_knowledgearticle](#BKMK_team_knowledgearticle)
- [team_sharepointsite](#BKMK_team_sharepointsite)
- [team_sharepointdocumentlocation](#BKMK_team_sharepointdocumentlocation)
- [team_goal](#BKMK_team_goal)
- [team_goalrollupquery](#BKMK_team_goalrollupquery)
- [team_mailbox](#BKMK_team_mailbox)
- [team_connections2](#BKMK_team_connections2)
- [team_slaBase](#BKMK_team_slaBase)
- [team_goal_goalowner](#BKMK_team_goal_goalowner)
- [team_principalobjectattributeaccess](#BKMK_team_principalobjectattributeaccess)
- [OwningTeam_postfollows](#BKMK_OwningTeam_postfollows)
- [team_ImportMaps](#BKMK_team_ImportMaps)
- [team_recurringappointmentmaster](#BKMK_team_recurringappointmentmaster)
- [team_queueitembase_workerid](#BKMK_team_queueitembase_workerid)
- [team_phonecall](#BKMK_team_phonecall)
- [team_emailserverprofile](#BKMK_team_emailserverprofile)
- [team_connections1](#BKMK_team_connections1)
- [team_userqueryvisualizations](#BKMK_team_userqueryvisualizations)
- [team_userform](#BKMK_team_userform)
- [team_socialactivity](#BKMK_team_socialactivity)
- [Team_ProcessSessions](#BKMK_Team_ProcessSessions)
- [Team_DuplicateMatchingRecord](#BKMK_Team_DuplicateMatchingRecord)
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
- [Team_BulkDeleteFailures](#BKMK_Team_BulkDeleteFailures)
- [Team_SyncErrors](#BKMK_Team_SyncErrors)
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
- [team_DuplicateRules](#BKMK_team_DuplicateRules)
- [team_workflow](#BKMK_team_workflow)


### <a name="BKMK_lead_owning_team"></a> lead_owning_team

**Added by**: Lead Management Solution

Same as lead entity [lead_owning_team](lead.md#BKMK_lead_owning_team) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|lead|
|ReferencingAttribute|owningteam|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|lead_owning_team|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_team_DynamicPropertyInstance"></a> team_DynamicPropertyInstance

**Added by**: Product Management Solution

Same as dynamicpropertyinstance entity [team_DynamicPropertyInstance](dynamicpropertyinstance.md#BKMK_team_DynamicPropertyInstance) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|dynamicpropertyinstance|
|ReferencingAttribute|owningteam|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|team_DynamicPropertyInstance|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_team_bookableresource"></a> team_bookableresource

**Added by**: Scheduling Solution

Same as bookableresource entity [team_bookableresource](bookableresource.md#BKMK_team_bookableresource) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|bookableresource|
|ReferencingAttribute|owningteam|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|team_bookableresource|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_team_bookableresourcebooking"></a> team_bookableresourcebooking

**Added by**: Scheduling Solution

Same as bookableresourcebooking entity [team_bookableresourcebooking](bookableresourcebooking.md#BKMK_team_bookableresourcebooking) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|bookableresourcebooking|
|ReferencingAttribute|owningteam|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|team_bookableresourcebooking|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_team_bookableresourcebookingheader"></a> team_bookableresourcebookingheader

**Added by**: Scheduling Solution

Same as bookableresourcebookingheader entity [team_bookableresourcebookingheader](bookableresourcebookingheader.md#BKMK_team_bookableresourcebookingheader) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|bookableresourcebookingheader|
|ReferencingAttribute|owningteam|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|team_bookableresourcebookingheader|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_team_bookableresourcecategory"></a> team_bookableresourcecategory

**Added by**: Scheduling Solution

Same as bookableresourcecategory entity [team_bookableresourcecategory](bookableresourcecategory.md#BKMK_team_bookableresourcecategory) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|bookableresourcecategory|
|ReferencingAttribute|owningteam|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|team_bookableresourcecategory|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_team_bookableresourcecategoryassn"></a> team_bookableresourcecategoryassn

**Added by**: Scheduling Solution

Same as bookableresourcecategoryassn entity [team_bookableresourcecategoryassn](bookableresourcecategoryassn.md#BKMK_team_bookableresourcecategoryassn) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|bookableresourcecategoryassn|
|ReferencingAttribute|owningteam|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|team_bookableresourcecategoryassn|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_team_bookableresourcecharacteristic"></a> team_bookableresourcecharacteristic

**Added by**: Scheduling Solution

Same as bookableresourcecharacteristic entity [team_bookableresourcecharacteristic](bookableresourcecharacteristic.md#BKMK_team_bookableresourcecharacteristic) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|bookableresourcecharacteristic|
|ReferencingAttribute|owningteam|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|team_bookableresourcecharacteristic|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_team_bookableresourcegroup"></a> team_bookableresourcegroup

**Added by**: Scheduling Solution

Same as bookableresourcegroup entity [team_bookableresourcegroup](bookableresourcegroup.md#BKMK_team_bookableresourcegroup) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|bookableresourcegroup|
|ReferencingAttribute|owningteam|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|team_bookableresourcegroup|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_team_bookingstatus"></a> team_bookingstatus

**Added by**: Scheduling Solution

Same as bookingstatus entity [team_bookingstatus](bookingstatus.md#BKMK_team_bookingstatus) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|bookingstatus|
|ReferencingAttribute|owningteam|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|team_bookingstatus|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_team_characteristic"></a> team_characteristic

**Added by**: Scheduling Solution

Same as characteristic entity [team_characteristic](characteristic.md#BKMK_team_characteristic) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|characteristic|
|ReferencingAttribute|owningteam|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|team_characteristic|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_team_ratingmodel"></a> team_ratingmodel

**Added by**: Scheduling Solution

Same as ratingmodel entity [team_ratingmodel](ratingmodel.md#BKMK_team_ratingmodel) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|ratingmodel|
|ReferencingAttribute|owningteam|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|team_ratingmodel|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_team_ratingvalue"></a> team_ratingvalue

**Added by**: Scheduling Solution

Same as ratingvalue entity [team_ratingvalue](ratingvalue.md#BKMK_team_ratingvalue) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|ratingvalue|
|ReferencingAttribute|owningteam|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|team_ratingvalue|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_team_BulkOperation"></a> team_BulkOperation

**Added by**: Marketing Solution

Same as bulkoperation entity [team_BulkOperation](bulkoperation.md#BKMK_team_BulkOperation) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|bulkoperation|
|ReferencingAttribute|owningteam|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|team_BulkOperation|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_team_bulkoperationlog"></a> team_bulkoperationlog

**Added by**: Marketing Solution

Same as bulkoperationlog entity [team_bulkoperationlog](bulkoperationlog.md#BKMK_team_bulkoperationlog) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|bulkoperationlog|
|ReferencingAttribute|owningteam|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|team_bulkoperationlog|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_team_Campaigns"></a> team_Campaigns

**Added by**: Marketing Solution

Same as campaign entity [team_Campaigns](campaign.md#BKMK_team_Campaigns) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|campaign|
|ReferencingAttribute|owningteam|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|team_Campaigns|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_team_campaignactivity"></a> team_campaignactivity

**Added by**: Marketing Solution

Same as campaignactivity entity [team_campaignactivity](campaignactivity.md#BKMK_team_campaignactivity) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|campaignactivity|
|ReferencingAttribute|owningteam|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|team_campaignactivity|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_team_campaignresponse"></a> team_campaignresponse

**Added by**: Marketing Solution

Same as campaignresponse entity [team_campaignresponse](campaignresponse.md#BKMK_team_campaignresponse) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|campaignresponse|
|ReferencingAttribute|owningteam|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|team_campaignresponse|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_team_list"></a> team_list

**Added by**: Marketing Solution

Same as list entity [team_list](list.md#BKMK_team_list) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|list|
|ReferencingAttribute|owningteam|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|team_list|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_team_service_contracts"></a> team_service_contracts

**Added by**: Service Solution

Same as contract entity [team_service_contracts](contract.md#BKMK_team_service_contracts) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|contract|
|ReferencingAttribute|owningteam|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|team_service_contracts|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_team_contractdetail"></a> team_contractdetail

**Added by**: Service Solution

Same as contractdetail entity [team_contractdetail](contractdetail.md#BKMK_team_contractdetail) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|contractdetail|
|ReferencingAttribute|owningteam|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|team_contractdetail|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_team_entitlement"></a> team_entitlement

**Added by**: Service Solution

Same as entitlement entity [team_entitlement](entitlement.md#BKMK_team_entitlement) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|entitlement|
|ReferencingAttribute|owningteam|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|team_entitlement|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_team_entitlementchannel"></a> team_entitlementchannel

**Added by**: Service Solution

Same as entitlementchannel entity [team_entitlementchannel](entitlementchannel.md#BKMK_team_entitlementchannel) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|entitlementchannel|
|ReferencingAttribute|owningteam|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|team_entitlementchannel|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_team_incidents"></a> team_incidents

**Added by**: Service Solution

Same as incident entity [team_incidents](incident.md#BKMK_team_incidents) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|incident|
|ReferencingAttribute|owningteam|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|team_incidents|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_team_incidentresolution"></a> team_incidentresolution

**Added by**: Service Solution

Same as incidentresolution entity [team_incidentresolution](incidentresolution.md#BKMK_team_incidentresolution) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|incidentresolution|
|ReferencingAttribute|owningteam|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|team_incidentresolution|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_team_knowledgearticleincident"></a> team_knowledgearticleincident

**Added by**: Service Solution

Same as knowledgearticleincident entity [team_knowledgearticleincident](knowledgearticleincident.md#BKMK_team_knowledgearticleincident) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|knowledgearticleincident|
|ReferencingAttribute|owningteam|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|team_knowledgearticleincident|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_team_service_appointments"></a> team_service_appointments

**Added by**: Service Solution

Same as serviceappointment entity [team_service_appointments](serviceappointment.md#BKMK_team_service_appointments) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|serviceappointment|
|ReferencingAttribute|owningteam|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|team_service_appointments|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_team_resource_specs"></a> team_resource_specs

**Added by**: Service Solution

Same as resourcespec entity [team_resource_specs](resourcespec.md#BKMK_team_resource_specs) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|resourcespec|
|ReferencingAttribute|groupobjectid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|team_resource_specs|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Restrict<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_team_resource_groups"></a> team_resource_groups

**Added by**: Service Solution

Same as resourcegroup entity [team_resource_groups](resourcegroup.md#BKMK_team_resource_groups) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|resourcegroup|
|ReferencingAttribute|resourcegroupid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|team_resource_groups|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_team_entitlemententityallocationtypemapping"></a> team_entitlemententityallocationtypemapping

**Added by**: Service Patch Solution

Same as entitlemententityallocationtypemapping entity [team_entitlemententityallocationtypemapping](entitlemententityallocationtypemapping.md#BKMK_team_entitlemententityallocationtypemapping) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|entitlemententityallocationtypemapping|
|ReferencingAttribute|owningteam|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|team_entitlemententityallocationtypemapping|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_team_msdyn_callablecontext"></a> team_msdyn_callablecontext

**Added by**: Active Solution Solution

Same as msdyn_callablecontext entity [team_msdyn_callablecontext](msdyn_callablecontext.md#BKMK_team_msdyn_callablecontext) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_callablecontext|
|ReferencingAttribute|owningteam|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|team_msdyn_callablecontext|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_team_msdyn_playbookactivity"></a> team_msdyn_playbookactivity

**Added by**: Active Solution Solution

Same as msdyn_playbookactivity entity [team_msdyn_playbookactivity](msdyn_playbookactivity.md#BKMK_team_msdyn_playbookactivity) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_playbookactivity|
|ReferencingAttribute|owningteam|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|team_msdyn_playbookactivity|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_team_msdyn_playbookactivityattribute"></a> team_msdyn_playbookactivityattribute

**Added by**: Active Solution Solution

Same as msdyn_playbookactivityattribute entity [team_msdyn_playbookactivityattribute](msdyn_playbookactivityattribute.md#BKMK_team_msdyn_playbookactivityattribute) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_playbookactivityattribute|
|ReferencingAttribute|owningteam|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|team_msdyn_playbookactivityattribute|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_team_msdyn_playbookcategory"></a> team_msdyn_playbookcategory

**Added by**: Active Solution Solution

Same as msdyn_playbookcategory entity [team_msdyn_playbookcategory](msdyn_playbookcategory.md#BKMK_team_msdyn_playbookcategory) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_playbookcategory|
|ReferencingAttribute|owningteam|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|team_msdyn_playbookcategory|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_team_msdyn_playbookinstance"></a> team_msdyn_playbookinstance

**Added by**: Active Solution Solution

Same as msdyn_playbookinstance entity [team_msdyn_playbookinstance](msdyn_playbookinstance.md#BKMK_team_msdyn_playbookinstance) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_playbookinstance|
|ReferencingAttribute|owningteam|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|team_msdyn_playbookinstance|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_team_msdyn_playbooktemplate"></a> team_msdyn_playbooktemplate

**Added by**: Active Solution Solution

Same as msdyn_playbooktemplate entity [team_msdyn_playbooktemplate](msdyn_playbooktemplate.md#BKMK_team_msdyn_playbooktemplate) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_playbooktemplate|
|ReferencingAttribute|owningteam|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|team_msdyn_playbooktemplate|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_team_invoices"></a> team_invoices

**Added by**: Sales Solution

Same as invoice entity [team_invoices](invoice.md#BKMK_team_invoices) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|invoice|
|ReferencingAttribute|owningteam|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|team_invoices|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_team_invoicedetail"></a> team_invoicedetail

**Added by**: Sales Solution

Same as invoicedetail entity [team_invoicedetail](invoicedetail.md#BKMK_team_invoicedetail) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|invoicedetail|
|ReferencingAttribute|owningteam|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|team_invoicedetail|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_team_opportunities"></a> team_opportunities

**Added by**: Sales Solution

Same as opportunity entity [team_opportunities](opportunity.md#BKMK_team_opportunities) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|opportunity|
|ReferencingAttribute|owningteam|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|team_opportunities|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_team_opportunityclose"></a> team_opportunityclose

**Added by**: Sales Solution

Same as opportunityclose entity [team_opportunityclose](opportunityclose.md#BKMK_team_opportunityclose) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|opportunityclose|
|ReferencingAttribute|owningteam|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|team_opportunityclose|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_team_opportunityproduct"></a> team_opportunityproduct

**Added by**: Sales Solution

Same as opportunityproduct entity [team_opportunityproduct](opportunityproduct.md#BKMK_team_opportunityproduct) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|opportunityproduct|
|ReferencingAttribute|owningteam|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|team_opportunityproduct|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_team_orderclose"></a> team_orderclose

**Added by**: Sales Solution

Same as orderclose entity [team_orderclose](orderclose.md#BKMK_team_orderclose) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|orderclose|
|ReferencingAttribute|owningteam|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|team_orderclose|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_team_quotes"></a> team_quotes

**Added by**: Sales Solution

Same as quote entity [team_quotes](quote.md#BKMK_team_quotes) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|quote|
|ReferencingAttribute|owningteam|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|team_quotes|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_team_quoteclose"></a> team_quoteclose

**Added by**: Sales Solution

Same as quoteclose entity [team_quoteclose](quoteclose.md#BKMK_team_quoteclose) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|quoteclose|
|ReferencingAttribute|owningteam|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|team_quoteclose|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_team_quotedetail"></a> team_quotedetail

**Added by**: Sales Solution

Same as quotedetail entity [team_quotedetail](quotedetail.md#BKMK_team_quotedetail) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|quotedetail|
|ReferencingAttribute|owningteam|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|team_quotedetail|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_team_orders"></a> team_orders

**Added by**: Sales Solution

Same as salesorder entity [team_orders](salesorder.md#BKMK_team_orders) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|salesorder|
|ReferencingAttribute|owningteam|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|team_orders|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_team_salesorderdetail"></a> team_salesorderdetail

**Added by**: Sales Solution

Same as salesorderdetail entity [team_salesorderdetail](salesorderdetail.md#BKMK_team_salesorderdetail) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|salesorderdetail|
|ReferencingAttribute|owningteam|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|team_salesorderdetail|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_team_adminsettingsentity"></a> team_adminsettingsentity

**Added by**: Sales Patch Solution

Same as adminsettingsentity entity [team_adminsettingsentity](adminsettingsentity.md#BKMK_team_adminsettingsentity) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|adminsettingsentity|
|ReferencingAttribute|owningteam|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|team_adminsettingsentity|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_team_msdyn_forecastdefinition"></a> team_msdyn_forecastdefinition

**Added by**: Active Solution Solution

Same as msdyn_forecastdefinition entity [team_msdyn_forecastdefinition](msdyn_forecastdefinition.md#BKMK_team_msdyn_forecastdefinition) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_forecastdefinition|
|ReferencingAttribute|owningteam|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|team_msdyn_forecastdefinition|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_team_msdyn_forecastinstance"></a> team_msdyn_forecastinstance

**Added by**: Active Solution Solution

Same as msdyn_forecastinstance entity [team_msdyn_forecastinstance](msdyn_forecastinstance.md#BKMK_team_msdyn_forecastinstance) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_forecastinstance|
|ReferencingAttribute|owningteam|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|team_msdyn_forecastinstance|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_team_msdyn_forecastrecurrence"></a> team_msdyn_forecastrecurrence

**Added by**: Active Solution Solution

Same as msdyn_forecastrecurrence entity [team_msdyn_forecastrecurrence](msdyn_forecastrecurrence.md#BKMK_team_msdyn_forecastrecurrence) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_forecastrecurrence|
|ReferencingAttribute|owningteam|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|team_msdyn_forecastrecurrence|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_team_msdyn_relationshipinsightsunifiedconfig"></a> team_msdyn_relationshipinsightsunifiedconfig

**Added by**: Active Solution Solution

Same as msdyn_relationshipinsightsunifiedconfig entity [team_msdyn_relationshipinsightsunifiedconfig](msdyn_relationshipinsightsunifiedconfig.md#BKMK_team_msdyn_relationshipinsightsunifiedconfig) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_relationshipinsightsunifiedconfig|
|ReferencingAttribute|owningteam|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|team_msdyn_relationshipinsightsunifiedconfig|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_team_msdyn_siconfig"></a> team_msdyn_siconfig

**Added by**: Active Solution Solution

Same as msdyn_siconfig entity [team_msdyn_siconfig](msdyn_siconfig.md#BKMK_team_msdyn_siconfig) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_siconfig|
|ReferencingAttribute|owningteam|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|team_msdyn_siconfig|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_team_msdyn_untrackedappointment"></a> team_msdyn_untrackedappointment

**Added by**: Active Solution Solution

Same as msdyn_untrackedappointment entity [team_msdyn_untrackedappointment](msdyn_untrackedappointment.md#BKMK_team_msdyn_untrackedappointment) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_untrackedappointment|
|ReferencingAttribute|owningteam|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|team_msdyn_untrackedappointment|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_team_msdyn_notesanalysisconfig"></a> team_msdyn_notesanalysisconfig

**Added by**: Active Solution Solution

Same as msdyn_notesanalysisconfig entity [team_msdyn_notesanalysisconfig](msdyn_notesanalysisconfig.md#BKMK_team_msdyn_notesanalysisconfig) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_notesanalysisconfig|
|ReferencingAttribute|owningteam|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|team_msdyn_notesanalysisconfig|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_team_msdyn_icebreakersconfig"></a> team_msdyn_icebreakersconfig

**Added by**: Active Solution Solution

Same as msdyn_icebreakersconfig entity [team_msdyn_icebreakersconfig](msdyn_icebreakersconfig.md#BKMK_team_msdyn_icebreakersconfig) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_icebreakersconfig|
|ReferencingAttribute|owningteam|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|team_msdyn_icebreakersconfig|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_team_msdyn_postalbum"></a> team_msdyn_postalbum

**Added by**: Active Solution Solution

Same as msdyn_postalbum entity [team_msdyn_postalbum](msdyn_postalbum.md#BKMK_team_msdyn_postalbum) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_postalbum|
|ReferencingAttribute|owningteam|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|team_msdyn_postalbum|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_team_msdyn_wallsavedqueryusersettings"></a> team_msdyn_wallsavedqueryusersettings

**Added by**: Active Solution Solution

Same as msdyn_wallsavedqueryusersettings entity [team_msdyn_wallsavedqueryusersettings](msdyn_wallsavedqueryusersettings.md#BKMK_team_msdyn_wallsavedqueryusersettings) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_wallsavedqueryusersettings|
|ReferencingAttribute|owningteam|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|team_msdyn_wallsavedqueryusersettings|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_team_msdyn_actual"></a> team_msdyn_actual

**Added by**: Active Solution Solution

Same as msdyn_actual entity [team_msdyn_actual](msdyn_actual.md#BKMK_team_msdyn_actual) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_actual|
|ReferencingAttribute|owningteam|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|team_msdyn_actual|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_team_msdyn_bookableresourceassociation"></a> team_msdyn_bookableresourceassociation

**Added by**: Active Solution Solution

Same as msdyn_bookableresourceassociation entity [team_msdyn_bookableresourceassociation](msdyn_bookableresourceassociation.md#BKMK_team_msdyn_bookableresourceassociation) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_bookableresourceassociation|
|ReferencingAttribute|owningteam|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|team_msdyn_bookableresourceassociation|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_bookingalert_team_owningteam"></a> msdyn_bookingalert_team_owningteam

**Added by**: Active Solution Solution

Same as msdyn_bookingalert entity [msdyn_bookingalert_team_owningteam](msdyn_bookingalert.md#BKMK_msdyn_bookingalert_team_owningteam) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_bookingalert|
|ReferencingAttribute|owningteam|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_bookingalert_team_owningteam|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_team_msdyn_bookingalertstatus"></a> team_msdyn_bookingalertstatus

**Added by**: Active Solution Solution

Same as msdyn_bookingalertstatus entity [team_msdyn_bookingalertstatus](msdyn_bookingalertstatus.md#BKMK_team_msdyn_bookingalertstatus) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_bookingalertstatus|
|ReferencingAttribute|owningteam|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|team_msdyn_bookingalertstatus|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_team_msdyn_bookingchange"></a> team_msdyn_bookingchange

**Added by**: Active Solution Solution

Same as msdyn_bookingchange entity [team_msdyn_bookingchange](msdyn_bookingchange.md#BKMK_team_msdyn_bookingchange) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_bookingchange|
|ReferencingAttribute|owningteam|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|team_msdyn_bookingchange|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_team_msdyn_bookingrule"></a> team_msdyn_bookingrule

**Added by**: Active Solution Solution

Same as msdyn_bookingrule entity [team_msdyn_bookingrule](msdyn_bookingrule.md#BKMK_team_msdyn_bookingrule) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_bookingrule|
|ReferencingAttribute|owningteam|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|team_msdyn_bookingrule|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_team_msdyn_bookingsetupmetadata"></a> team_msdyn_bookingsetupmetadata

**Added by**: Active Solution Solution

Same as msdyn_bookingsetupmetadata entity [team_msdyn_bookingsetupmetadata](msdyn_bookingsetupmetadata.md#BKMK_team_msdyn_bookingsetupmetadata) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_bookingsetupmetadata|
|ReferencingAttribute|owningteam|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|team_msdyn_bookingsetupmetadata|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_team_msdyn_businessclosure"></a> team_msdyn_businessclosure

**Added by**: Active Solution Solution

Same as msdyn_businessclosure entity [team_msdyn_businessclosure](msdyn_businessclosure.md#BKMK_team_msdyn_businessclosure) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_businessclosure|
|ReferencingAttribute|owningteam|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|team_msdyn_businessclosure|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_team_msdyn_clientextension"></a> team_msdyn_clientextension

**Added by**: Active Solution Solution

Same as msdyn_clientextension entity [team_msdyn_clientextension](msdyn_clientextension.md#BKMK_team_msdyn_clientextension) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_clientextension|
|ReferencingAttribute|owningteam|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|team_msdyn_clientextension|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_team_msdyn_configuration"></a> team_msdyn_configuration

**Added by**: Active Solution Solution

Same as msdyn_configuration entity [team_msdyn_configuration](msdyn_configuration.md#BKMK_team_msdyn_configuration) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_configuration|
|ReferencingAttribute|owningteam|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|team_msdyn_configuration|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_team_msdyn_priority"></a> team_msdyn_priority

**Added by**: Active Solution Solution

Same as msdyn_priority entity [team_msdyn_priority](msdyn_priority.md#BKMK_team_msdyn_priority) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_priority|
|ReferencingAttribute|owningteam|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|team_msdyn_priority|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_team_msdyn_requirementcharacteristic"></a> team_msdyn_requirementcharacteristic

**Added by**: Active Solution Solution

Same as msdyn_requirementcharacteristic entity [team_msdyn_requirementcharacteristic](msdyn_requirementcharacteristic.md#BKMK_team_msdyn_requirementcharacteristic) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_requirementcharacteristic|
|ReferencingAttribute|owningteam|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|team_msdyn_requirementcharacteristic|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_team_msdyn_requirementgroup"></a> team_msdyn_requirementgroup

**Added by**: Active Solution Solution

Same as msdyn_requirementgroup entity [team_msdyn_requirementgroup](msdyn_requirementgroup.md#BKMK_team_msdyn_requirementgroup) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_requirementgroup|
|ReferencingAttribute|owningteam|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|team_msdyn_requirementgroup|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_team_msdyn_requirementorganizationunit"></a> team_msdyn_requirementorganizationunit

**Added by**: Active Solution Solution

Same as msdyn_requirementorganizationunit entity [team_msdyn_requirementorganizationunit](msdyn_requirementorganizationunit.md#BKMK_team_msdyn_requirementorganizationunit) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_requirementorganizationunit|
|ReferencingAttribute|owningteam|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|team_msdyn_requirementorganizationunit|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_team_msdyn_requirementrelationship"></a> team_msdyn_requirementrelationship

**Added by**: Active Solution Solution

Same as msdyn_requirementrelationship entity [team_msdyn_requirementrelationship](msdyn_requirementrelationship.md#BKMK_team_msdyn_requirementrelationship) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_requirementrelationship|
|ReferencingAttribute|owningteam|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|team_msdyn_requirementrelationship|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_team_msdyn_requirementresourcecategory"></a> team_msdyn_requirementresourcecategory

**Added by**: Active Solution Solution

Same as msdyn_requirementresourcecategory entity [team_msdyn_requirementresourcecategory](msdyn_requirementresourcecategory.md#BKMK_team_msdyn_requirementresourcecategory) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_requirementresourcecategory|
|ReferencingAttribute|owningteam|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|team_msdyn_requirementresourcecategory|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_team_msdyn_requirementresourcepreference"></a> team_msdyn_requirementresourcepreference

**Added by**: Active Solution Solution

Same as msdyn_requirementresourcepreference entity [team_msdyn_requirementresourcepreference](msdyn_requirementresourcepreference.md#BKMK_team_msdyn_requirementresourcepreference) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_requirementresourcepreference|
|ReferencingAttribute|owningteam|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|team_msdyn_requirementresourcepreference|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_team_msdyn_requirementstatus"></a> team_msdyn_requirementstatus

**Added by**: Active Solution Solution

Same as msdyn_requirementstatus entity [team_msdyn_requirementstatus](msdyn_requirementstatus.md#BKMK_team_msdyn_requirementstatus) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_requirementstatus|
|ReferencingAttribute|owningteam|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|team_msdyn_requirementstatus|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_team_msdyn_resourcerequirement"></a> team_msdyn_resourcerequirement

**Added by**: Active Solution Solution

Same as msdyn_resourcerequirement entity [team_msdyn_resourcerequirement](msdyn_resourcerequirement.md#BKMK_team_msdyn_resourcerequirement) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_resourcerequirement|
|ReferencingAttribute|owningteam|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|team_msdyn_resourcerequirement|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_team_msdyn_resourcerequirementdetail"></a> team_msdyn_resourcerequirementdetail

**Added by**: Active Solution Solution

Same as msdyn_resourcerequirementdetail entity [team_msdyn_resourcerequirementdetail](msdyn_resourcerequirementdetail.md#BKMK_team_msdyn_resourcerequirementdetail) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_resourcerequirementdetail|
|ReferencingAttribute|owningteam|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|team_msdyn_resourcerequirementdetail|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_team_msdyn_resourceterritory"></a> team_msdyn_resourceterritory

**Added by**: Active Solution Solution

Same as msdyn_resourceterritory entity [team_msdyn_resourceterritory](msdyn_resourceterritory.md#BKMK_team_msdyn_resourceterritory) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_resourceterritory|
|ReferencingAttribute|owningteam|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|team_msdyn_resourceterritory|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_team_msdyn_scheduleboardsetting"></a> team_msdyn_scheduleboardsetting

**Added by**: Active Solution Solution

Same as msdyn_scheduleboardsetting entity [team_msdyn_scheduleboardsetting](msdyn_scheduleboardsetting.md#BKMK_team_msdyn_scheduleboardsetting) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_scheduleboardsetting|
|ReferencingAttribute|owningteam|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|team_msdyn_scheduleboardsetting|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_team_msdyn_systemuserschedulersetting"></a> team_msdyn_systemuserschedulersetting

**Added by**: Active Solution Solution

Same as msdyn_systemuserschedulersetting entity [team_msdyn_systemuserschedulersetting](msdyn_systemuserschedulersetting.md#BKMK_team_msdyn_systemuserschedulersetting) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_systemuserschedulersetting|
|ReferencingAttribute|owningteam|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|team_msdyn_systemuserschedulersetting|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_team_msdyn_timegroup"></a> team_msdyn_timegroup

**Added by**: Active Solution Solution

Same as msdyn_timegroup entity [team_msdyn_timegroup](msdyn_timegroup.md#BKMK_team_msdyn_timegroup) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_timegroup|
|ReferencingAttribute|owningteam|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|team_msdyn_timegroup|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_team_msdyn_timegroupdetail"></a> team_msdyn_timegroupdetail

**Added by**: Active Solution Solution

Same as msdyn_timegroupdetail entity [team_msdyn_timegroupdetail](msdyn_timegroupdetail.md#BKMK_team_msdyn_timegroupdetail) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_timegroupdetail|
|ReferencingAttribute|owningteam|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|team_msdyn_timegroupdetail|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_team_msdyn_transactionorigin"></a> team_msdyn_transactionorigin

**Added by**: Active Solution Solution

Same as msdyn_transactionorigin entity [team_msdyn_transactionorigin](msdyn_transactionorigin.md#BKMK_team_msdyn_transactionorigin) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_transactionorigin|
|ReferencingAttribute|owningteam|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|team_msdyn_transactionorigin|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_team_msdyn_workhourtemplate"></a> team_msdyn_workhourtemplate

**Added by**: Active Solution Solution

Same as msdyn_workhourtemplate entity [team_msdyn_workhourtemplate](msdyn_workhourtemplate.md#BKMK_team_msdyn_workhourtemplate) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_workhourtemplate|
|ReferencingAttribute|owningteam|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|team_msdyn_workhourtemplate|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_team_msdyn_accountpricelist"></a> team_msdyn_accountpricelist

**Added by**: Active Solution Solution

Same as msdyn_accountpricelist entity [team_msdyn_accountpricelist](msdyn_accountpricelist.md#BKMK_team_msdyn_accountpricelist) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_accountpricelist|
|ReferencingAttribute|owningteam|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|team_msdyn_accountpricelist|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_approval_team_owningteam"></a> msdyn_approval_team_owningteam

**Added by**: Active Solution Solution

Same as msdyn_approval entity [msdyn_approval_team_owningteam](msdyn_approval.md#BKMK_msdyn_approval_team_owningteam) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_approval|
|ReferencingAttribute|owningteam|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_approval_team_owningteam|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_team_msdyn_characteristicreqforteammember"></a> team_msdyn_characteristicreqforteammember

**Added by**: Active Solution Solution

Same as msdyn_characteristicreqforteammember entity [team_msdyn_characteristicreqforteammember](msdyn_characteristicreqforteammember.md#BKMK_team_msdyn_characteristicreqforteammember) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_characteristicreqforteammember|
|ReferencingAttribute|owningteam|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|team_msdyn_characteristicreqforteammember|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_team_msdyn_contactpricelist"></a> team_msdyn_contactpricelist

**Added by**: Active Solution Solution

Same as msdyn_contactpricelist entity [team_msdyn_contactpricelist](msdyn_contactpricelist.md#BKMK_team_msdyn_contactpricelist) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_contactpricelist|
|ReferencingAttribute|owningteam|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|team_msdyn_contactpricelist|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_team_msdyn_contractlinescheduleofvalue"></a> team_msdyn_contractlinescheduleofvalue

**Added by**: Active Solution Solution

Same as msdyn_contractlinescheduleofvalue entity [team_msdyn_contractlinescheduleofvalue](msdyn_contractlinescheduleofvalue.md#BKMK_team_msdyn_contractlinescheduleofvalue) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_contractlinescheduleofvalue|
|ReferencingAttribute|owningteam|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|team_msdyn_contractlinescheduleofvalue|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_team_msdyn_dataexport"></a> team_msdyn_dataexport

**Added by**: Active Solution Solution

Same as msdyn_dataexport entity [team_msdyn_dataexport](msdyn_dataexport.md#BKMK_team_msdyn_dataexport) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_dataexport|
|ReferencingAttribute|owningteam|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|team_msdyn_dataexport|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_team_msdyn_delegation"></a> team_msdyn_delegation

**Added by**: Active Solution Solution

Same as msdyn_delegation entity [team_msdyn_delegation](msdyn_delegation.md#BKMK_team_msdyn_delegation) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_delegation|
|ReferencingAttribute|owningteam|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|team_msdyn_delegation|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_team_msdyn_dimension"></a> team_msdyn_dimension

**Added by**: Active Solution Solution

Same as msdyn_dimension entity [team_msdyn_dimension](msdyn_dimension.md#BKMK_team_msdyn_dimension) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_dimension|
|ReferencingAttribute|owningteam|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|team_msdyn_dimension|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_team_msdyn_estimate"></a> team_msdyn_estimate

**Added by**: Active Solution Solution

Same as msdyn_estimate entity [team_msdyn_estimate](msdyn_estimate.md#BKMK_team_msdyn_estimate) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_estimate|
|ReferencingAttribute|owningteam|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|team_msdyn_estimate|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_team_msdyn_estimateline"></a> team_msdyn_estimateline

**Added by**: Active Solution Solution

Same as msdyn_estimateline entity [team_msdyn_estimateline](msdyn_estimateline.md#BKMK_team_msdyn_estimateline) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_estimateline|
|ReferencingAttribute|owningteam|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|team_msdyn_estimateline|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_team_msdyn_expense"></a> team_msdyn_expense

**Added by**: Active Solution Solution

Same as msdyn_expense entity [team_msdyn_expense](msdyn_expense.md#BKMK_team_msdyn_expense) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_expense|
|ReferencingAttribute|owningteam|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|team_msdyn_expense|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_team_msdyn_expensereceipt"></a> team_msdyn_expensereceipt

**Added by**: Active Solution Solution

Same as msdyn_expensereceipt entity [team_msdyn_expensereceipt](msdyn_expensereceipt.md#BKMK_team_msdyn_expensereceipt) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_expensereceipt|
|ReferencingAttribute|owningteam|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|team_msdyn_expensereceipt|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_team_msdyn_fact"></a> team_msdyn_fact

**Added by**: Active Solution Solution

Same as msdyn_fact entity [team_msdyn_fact](msdyn_fact.md#BKMK_team_msdyn_fact) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_fact|
|ReferencingAttribute|owningteam|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|team_msdyn_fact|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_team_msdyn_fieldcomputation"></a> team_msdyn_fieldcomputation

**Added by**: Active Solution Solution

Same as msdyn_fieldcomputation entity [team_msdyn_fieldcomputation](msdyn_fieldcomputation.md#BKMK_team_msdyn_fieldcomputation) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_fieldcomputation|
|ReferencingAttribute|owningteam|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|team_msdyn_fieldcomputation|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_team_msdyn_findworkevent"></a> team_msdyn_findworkevent

**Added by**: Active Solution Solution

Same as msdyn_findworkevent entity [team_msdyn_findworkevent](msdyn_findworkevent.md#BKMK_team_msdyn_findworkevent) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_findworkevent|
|ReferencingAttribute|owningteam|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|team_msdyn_findworkevent|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_team_msdyn_integrationjob"></a> team_msdyn_integrationjob

**Added by**: Active Solution Solution

Same as msdyn_integrationjob entity [team_msdyn_integrationjob](msdyn_integrationjob.md#BKMK_team_msdyn_integrationjob) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_integrationjob|
|ReferencingAttribute|owningteam|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|team_msdyn_integrationjob|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_team_msdyn_integrationjobdetail"></a> team_msdyn_integrationjobdetail

**Added by**: Active Solution Solution

Same as msdyn_integrationjobdetail entity [team_msdyn_integrationjobdetail](msdyn_integrationjobdetail.md#BKMK_team_msdyn_integrationjobdetail) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_integrationjobdetail|
|ReferencingAttribute|owningteam|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|team_msdyn_integrationjobdetail|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_team_msdyn_invoicelinetransaction"></a> team_msdyn_invoicelinetransaction

**Added by**: Active Solution Solution

Same as msdyn_invoicelinetransaction entity [team_msdyn_invoicelinetransaction](msdyn_invoicelinetransaction.md#BKMK_team_msdyn_invoicelinetransaction) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_invoicelinetransaction|
|ReferencingAttribute|owningteam|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|team_msdyn_invoicelinetransaction|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_team_msdyn_journal"></a> team_msdyn_journal

**Added by**: Active Solution Solution

Same as msdyn_journal entity [team_msdyn_journal](msdyn_journal.md#BKMK_team_msdyn_journal) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_journal|
|ReferencingAttribute|owningteam|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|team_msdyn_journal|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_team_msdyn_journalline"></a> team_msdyn_journalline

**Added by**: Active Solution Solution

Same as msdyn_journalline entity [team_msdyn_journalline](msdyn_journalline.md#BKMK_team_msdyn_journalline) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_journalline|
|ReferencingAttribute|owningteam|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|team_msdyn_journalline|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_team_msdyn_opportunitylineresourcecategory"></a> team_msdyn_opportunitylineresourcecategory

**Added by**: Active Solution Solution

Same as msdyn_opportunitylineresourcecategory entity [team_msdyn_opportunitylineresourcecategory](msdyn_opportunitylineresourcecategory.md#BKMK_team_msdyn_opportunitylineresourcecategory) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_opportunitylineresourcecategory|
|ReferencingAttribute|owningteam|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|team_msdyn_opportunitylineresourcecategory|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_team_msdyn_opportunitylinetransaction"></a> team_msdyn_opportunitylinetransaction

**Added by**: Active Solution Solution

Same as msdyn_opportunitylinetransaction entity [team_msdyn_opportunitylinetransaction](msdyn_opportunitylinetransaction.md#BKMK_team_msdyn_opportunitylinetransaction) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_opportunitylinetransaction|
|ReferencingAttribute|owningteam|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|team_msdyn_opportunitylinetransaction|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_team_msdyn_opportunitylinetransactioncategory"></a> team_msdyn_opportunitylinetransactioncategory

**Added by**: Active Solution Solution

Same as msdyn_opportunitylinetransactioncategory entity [team_msdyn_opportunitylinetransactioncategory](msdyn_opportunitylinetransactioncategory.md#BKMK_team_msdyn_opportunitylinetransactioncategory) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_opportunitylinetransactioncategory|
|ReferencingAttribute|owningteam|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|team_msdyn_opportunitylinetransactioncategory|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_team_msdyn_opportunitylinetransactionclassificatio"></a> team_msdyn_opportunitylinetransactionclassificatio

**Added by**: Active Solution Solution

Same as msdyn_opportunitylinetransactionclassificatio entity [team_msdyn_opportunitylinetransactionclassificatio](msdyn_opportunitylinetransactionclassificatio.md#BKMK_team_msdyn_opportunitylinetransactionclassificatio) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_opportunitylinetransactionclassificatio|
|ReferencingAttribute|owningteam|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|team_msdyn_opportunitylinetransactionclassificatio|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_team_msdyn_opportunitypricelist"></a> team_msdyn_opportunitypricelist

**Added by**: Active Solution Solution

Same as msdyn_opportunitypricelist entity [team_msdyn_opportunitypricelist](msdyn_opportunitypricelist.md#BKMK_team_msdyn_opportunitypricelist) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_opportunitypricelist|
|ReferencingAttribute|owningteam|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|team_msdyn_opportunitypricelist|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_team_msdyn_orderlineresourcecategory"></a> team_msdyn_orderlineresourcecategory

**Added by**: Active Solution Solution

Same as msdyn_orderlineresourcecategory entity [team_msdyn_orderlineresourcecategory](msdyn_orderlineresourcecategory.md#BKMK_team_msdyn_orderlineresourcecategory) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_orderlineresourcecategory|
|ReferencingAttribute|owningteam|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|team_msdyn_orderlineresourcecategory|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_team_msdyn_orderlinetransaction"></a> team_msdyn_orderlinetransaction

**Added by**: Active Solution Solution

Same as msdyn_orderlinetransaction entity [team_msdyn_orderlinetransaction](msdyn_orderlinetransaction.md#BKMK_team_msdyn_orderlinetransaction) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_orderlinetransaction|
|ReferencingAttribute|owningteam|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|team_msdyn_orderlinetransaction|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_team_msdyn_orderlinetransactioncategory"></a> team_msdyn_orderlinetransactioncategory

**Added by**: Active Solution Solution

Same as msdyn_orderlinetransactioncategory entity [team_msdyn_orderlinetransactioncategory](msdyn_orderlinetransactioncategory.md#BKMK_team_msdyn_orderlinetransactioncategory) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_orderlinetransactioncategory|
|ReferencingAttribute|owningteam|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|team_msdyn_orderlinetransactioncategory|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_team_msdyn_orderlinetransactionclassification"></a> team_msdyn_orderlinetransactionclassification

**Added by**: Active Solution Solution

Same as msdyn_orderlinetransactionclassification entity [team_msdyn_orderlinetransactionclassification](msdyn_orderlinetransactionclassification.md#BKMK_team_msdyn_orderlinetransactionclassification) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_orderlinetransactionclassification|
|ReferencingAttribute|owningteam|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|team_msdyn_orderlinetransactionclassification|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_team_msdyn_orderpricelist"></a> team_msdyn_orderpricelist

**Added by**: Active Solution Solution

Same as msdyn_orderpricelist entity [team_msdyn_orderpricelist](msdyn_orderpricelist.md#BKMK_team_msdyn_orderpricelist) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_orderpricelist|
|ReferencingAttribute|owningteam|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|team_msdyn_orderpricelist|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_team_msdyn_project"></a> team_msdyn_project

**Added by**: Active Solution Solution

Same as msdyn_project entity [team_msdyn_project](msdyn_project.md#BKMK_team_msdyn_project) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_project|
|ReferencingAttribute|owningteam|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|team_msdyn_project|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_team_msdyn_projectapproval"></a> team_msdyn_projectapproval

**Added by**: Active Solution Solution

Same as msdyn_projectapproval entity [team_msdyn_projectapproval](msdyn_projectapproval.md#BKMK_team_msdyn_projectapproval) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_projectapproval|
|ReferencingAttribute|owningteam|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|team_msdyn_projectapproval|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_team_msdyn_projectpricelist"></a> team_msdyn_projectpricelist

**Added by**: Active Solution Solution

Same as msdyn_projectpricelist entity [team_msdyn_projectpricelist](msdyn_projectpricelist.md#BKMK_team_msdyn_projectpricelist) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_projectpricelist|
|ReferencingAttribute|owningteam|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|team_msdyn_projectpricelist|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_team_msdyn_projecttask"></a> team_msdyn_projecttask

**Added by**: Active Solution Solution

Same as msdyn_projecttask entity [team_msdyn_projecttask](msdyn_projecttask.md#BKMK_team_msdyn_projecttask) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_projecttask|
|ReferencingAttribute|owningteam|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|team_msdyn_projecttask|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_team_msdyn_projecttaskdependency"></a> team_msdyn_projecttaskdependency

**Added by**: Active Solution Solution

Same as msdyn_projecttaskdependency entity [team_msdyn_projecttaskdependency](msdyn_projecttaskdependency.md#BKMK_team_msdyn_projecttaskdependency) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_projecttaskdependency|
|ReferencingAttribute|owningteam|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|team_msdyn_projecttaskdependency|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_team_msdyn_projecttaskstatususer"></a> team_msdyn_projecttaskstatususer

**Added by**: Active Solution Solution

Same as msdyn_projecttaskstatususer entity [team_msdyn_projecttaskstatususer](msdyn_projecttaskstatususer.md#BKMK_team_msdyn_projecttaskstatususer) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_projecttaskstatususer|
|ReferencingAttribute|owningteam|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|team_msdyn_projecttaskstatususer|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_team_msdyn_projectteam"></a> team_msdyn_projectteam

**Added by**: Active Solution Solution

Same as msdyn_projectteam entity [team_msdyn_projectteam](msdyn_projectteam.md#BKMK_team_msdyn_projectteam) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_projectteam|
|ReferencingAttribute|owningteam|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|team_msdyn_projectteam|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_team_msdyn_projecttransactioncategory"></a> team_msdyn_projecttransactioncategory

**Added by**: Active Solution Solution

Same as msdyn_projecttransactioncategory entity [team_msdyn_projecttransactioncategory](msdyn_projecttransactioncategory.md#BKMK_team_msdyn_projecttransactioncategory) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_projecttransactioncategory|
|ReferencingAttribute|owningteam|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|team_msdyn_projecttransactioncategory|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_team_msdyn_quotelineanalyticsbreakdown"></a> team_msdyn_quotelineanalyticsbreakdown

**Added by**: Active Solution Solution

Same as msdyn_quotelineanalyticsbreakdown entity [team_msdyn_quotelineanalyticsbreakdown](msdyn_quotelineanalyticsbreakdown.md#BKMK_team_msdyn_quotelineanalyticsbreakdown) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_quotelineanalyticsbreakdown|
|ReferencingAttribute|owningteam|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|team_msdyn_quotelineanalyticsbreakdown|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_team_msdyn_quotelineresourcecategory"></a> team_msdyn_quotelineresourcecategory

**Added by**: Active Solution Solution

Same as msdyn_quotelineresourcecategory entity [team_msdyn_quotelineresourcecategory](msdyn_quotelineresourcecategory.md#BKMK_team_msdyn_quotelineresourcecategory) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_quotelineresourcecategory|
|ReferencingAttribute|owningteam|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|team_msdyn_quotelineresourcecategory|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_team_msdyn_quotelinescheduleofvalue"></a> team_msdyn_quotelinescheduleofvalue

**Added by**: Active Solution Solution

Same as msdyn_quotelinescheduleofvalue entity [team_msdyn_quotelinescheduleofvalue](msdyn_quotelinescheduleofvalue.md#BKMK_team_msdyn_quotelinescheduleofvalue) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_quotelinescheduleofvalue|
|ReferencingAttribute|owningteam|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|team_msdyn_quotelinescheduleofvalue|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_team_msdyn_quotelinetransaction"></a> team_msdyn_quotelinetransaction

**Added by**: Active Solution Solution

Same as msdyn_quotelinetransaction entity [team_msdyn_quotelinetransaction](msdyn_quotelinetransaction.md#BKMK_team_msdyn_quotelinetransaction) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_quotelinetransaction|
|ReferencingAttribute|owningteam|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|team_msdyn_quotelinetransaction|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_team_msdyn_quotelinetransactioncategory"></a> team_msdyn_quotelinetransactioncategory

**Added by**: Active Solution Solution

Same as msdyn_quotelinetransactioncategory entity [team_msdyn_quotelinetransactioncategory](msdyn_quotelinetransactioncategory.md#BKMK_team_msdyn_quotelinetransactioncategory) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_quotelinetransactioncategory|
|ReferencingAttribute|owningteam|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|team_msdyn_quotelinetransactioncategory|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_team_msdyn_quotelinetransactionclassification"></a> team_msdyn_quotelinetransactionclassification

**Added by**: Active Solution Solution

Same as msdyn_quotelinetransactionclassification entity [team_msdyn_quotelinetransactionclassification](msdyn_quotelinetransactionclassification.md#BKMK_team_msdyn_quotelinetransactionclassification) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_quotelinetransactionclassification|
|ReferencingAttribute|owningteam|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|team_msdyn_quotelinetransactionclassification|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_team_msdyn_quotepricelist"></a> team_msdyn_quotepricelist

**Added by**: Active Solution Solution

Same as msdyn_quotepricelist entity [team_msdyn_quotepricelist](msdyn_quotepricelist.md#BKMK_team_msdyn_quotepricelist) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_quotepricelist|
|ReferencingAttribute|owningteam|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|team_msdyn_quotepricelist|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_team_msdyn_resourceassignment"></a> team_msdyn_resourceassignment

**Added by**: Active Solution Solution

Same as msdyn_resourceassignment entity [team_msdyn_resourceassignment](msdyn_resourceassignment.md#BKMK_team_msdyn_resourceassignment) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_resourceassignment|
|ReferencingAttribute|owningteam|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|team_msdyn_resourceassignment|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_team_msdyn_resourceassignmentdetail"></a> team_msdyn_resourceassignmentdetail

**Added by**: Active Solution Solution

Same as msdyn_resourceassignmentdetail entity [team_msdyn_resourceassignmentdetail](msdyn_resourceassignmentdetail.md#BKMK_team_msdyn_resourceassignmentdetail) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_resourceassignmentdetail|
|ReferencingAttribute|owningteam|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|team_msdyn_resourceassignmentdetail|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_team_msdyn_resourcerequest"></a> team_msdyn_resourcerequest

**Added by**: Active Solution Solution

Same as msdyn_resourcerequest entity [team_msdyn_resourcerequest](msdyn_resourcerequest.md#BKMK_team_msdyn_resourcerequest) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_resourcerequest|
|ReferencingAttribute|owningteam|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|team_msdyn_resourcerequest|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_team_msdyn_rolecompetencyrequirement"></a> team_msdyn_rolecompetencyrequirement

**Added by**: Active Solution Solution

Same as msdyn_rolecompetencyrequirement entity [team_msdyn_rolecompetencyrequirement](msdyn_rolecompetencyrequirement.md#BKMK_team_msdyn_rolecompetencyrequirement) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_rolecompetencyrequirement|
|ReferencingAttribute|owningteam|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|team_msdyn_rolecompetencyrequirement|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_team_msdyn_roleutilization"></a> team_msdyn_roleutilization

**Added by**: Active Solution Solution

Same as msdyn_roleutilization entity [team_msdyn_roleutilization](msdyn_roleutilization.md#BKMK_team_msdyn_roleutilization) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_roleutilization|
|ReferencingAttribute|owningteam|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|team_msdyn_roleutilization|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_team_msdyn_timeentry"></a> team_msdyn_timeentry

**Added by**: Active Solution Solution

Same as msdyn_timeentry entity [team_msdyn_timeentry](msdyn_timeentry.md#BKMK_team_msdyn_timeentry) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_timeentry|
|ReferencingAttribute|owningteam|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|team_msdyn_timeentry|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_team_msdyn_timeoffcalendar"></a> team_msdyn_timeoffcalendar

**Added by**: Active Solution Solution

Same as msdyn_timeoffcalendar entity [team_msdyn_timeoffcalendar](msdyn_timeoffcalendar.md#BKMK_team_msdyn_timeoffcalendar) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_timeoffcalendar|
|ReferencingAttribute|owningteam|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|team_msdyn_timeoffcalendar|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_team_msdyn_transactionconnection"></a> team_msdyn_transactionconnection

**Added by**: Active Solution Solution

Same as msdyn_transactionconnection entity [team_msdyn_transactionconnection](msdyn_transactionconnection.md#BKMK_team_msdyn_transactionconnection) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_transactionconnection|
|ReferencingAttribute|owningteam|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|team_msdyn_transactionconnection|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_team_msdyn_userworkhistory"></a> team_msdyn_userworkhistory

**Added by**: Active Solution Solution

Same as msdyn_userworkhistory entity [team_msdyn_userworkhistory](msdyn_userworkhistory.md#BKMK_team_msdyn_userworkhistory) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_userworkhistory|
|ReferencingAttribute|owningteam|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|team_msdyn_userworkhistory|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_team_msdyn_project_projectteamid"></a> msdyn_team_msdyn_project_projectteamid

**Added by**: Project Service Automation Solution

Same as msdyn_project entity [msdyn_team_msdyn_project_projectteamid](msdyn_project.md#BKMK_msdyn_team_msdyn_project_projectteamid) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_project|
|ReferencingAttribute|msdyn_projectteamid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_team_msdyn_project_projectteamid|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Details<br />Label: <br />Order: 10000|
|CascadeConfiguration|Assign: NoCascade<br />Delete: RemoveLink<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_team_msdyn_agreement"></a> team_msdyn_agreement

**Added by**: Active Solution Solution

Same as msdyn_agreement entity [team_msdyn_agreement](msdyn_agreement.md#BKMK_team_msdyn_agreement) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_agreement|
|ReferencingAttribute|owningteam|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|team_msdyn_agreement|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_team_msdyn_agreementbookingdate"></a> team_msdyn_agreementbookingdate

**Added by**: Active Solution Solution

Same as msdyn_agreementbookingdate entity [team_msdyn_agreementbookingdate](msdyn_agreementbookingdate.md#BKMK_team_msdyn_agreementbookingdate) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_agreementbookingdate|
|ReferencingAttribute|owningteam|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|team_msdyn_agreementbookingdate|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_team_msdyn_agreementbookingincident"></a> team_msdyn_agreementbookingincident

**Added by**: Active Solution Solution

Same as msdyn_agreementbookingincident entity [team_msdyn_agreementbookingincident](msdyn_agreementbookingincident.md#BKMK_team_msdyn_agreementbookingincident) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_agreementbookingincident|
|ReferencingAttribute|owningteam|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|team_msdyn_agreementbookingincident|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_team_msdyn_agreementbookingproduct"></a> team_msdyn_agreementbookingproduct

**Added by**: Active Solution Solution

Same as msdyn_agreementbookingproduct entity [team_msdyn_agreementbookingproduct](msdyn_agreementbookingproduct.md#BKMK_team_msdyn_agreementbookingproduct) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_agreementbookingproduct|
|ReferencingAttribute|owningteam|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|team_msdyn_agreementbookingproduct|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_team_msdyn_agreementbookingservice"></a> team_msdyn_agreementbookingservice

**Added by**: Active Solution Solution

Same as msdyn_agreementbookingservice entity [team_msdyn_agreementbookingservice](msdyn_agreementbookingservice.md#BKMK_team_msdyn_agreementbookingservice) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_agreementbookingservice|
|ReferencingAttribute|owningteam|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|team_msdyn_agreementbookingservice|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_team_msdyn_agreementbookingservicetask"></a> team_msdyn_agreementbookingservicetask

**Added by**: Active Solution Solution

Same as msdyn_agreementbookingservicetask entity [team_msdyn_agreementbookingservicetask](msdyn_agreementbookingservicetask.md#BKMK_team_msdyn_agreementbookingservicetask) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_agreementbookingservicetask|
|ReferencingAttribute|owningteam|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|team_msdyn_agreementbookingservicetask|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_team_msdyn_agreementbookingsetup"></a> team_msdyn_agreementbookingsetup

**Added by**: Active Solution Solution

Same as msdyn_agreementbookingsetup entity [team_msdyn_agreementbookingsetup](msdyn_agreementbookingsetup.md#BKMK_team_msdyn_agreementbookingsetup) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_agreementbookingsetup|
|ReferencingAttribute|owningteam|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|team_msdyn_agreementbookingsetup|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_team_msdyn_agreementinvoicedate"></a> team_msdyn_agreementinvoicedate

**Added by**: Active Solution Solution

Same as msdyn_agreementinvoicedate entity [team_msdyn_agreementinvoicedate](msdyn_agreementinvoicedate.md#BKMK_team_msdyn_agreementinvoicedate) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_agreementinvoicedate|
|ReferencingAttribute|owningteam|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|team_msdyn_agreementinvoicedate|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_team_msdyn_agreementinvoiceproduct"></a> team_msdyn_agreementinvoiceproduct

**Added by**: Active Solution Solution

Same as msdyn_agreementinvoiceproduct entity [team_msdyn_agreementinvoiceproduct](msdyn_agreementinvoiceproduct.md#BKMK_team_msdyn_agreementinvoiceproduct) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_agreementinvoiceproduct|
|ReferencingAttribute|owningteam|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|team_msdyn_agreementinvoiceproduct|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_team_msdyn_agreementinvoicesetup"></a> team_msdyn_agreementinvoicesetup

**Added by**: Active Solution Solution

Same as msdyn_agreementinvoicesetup entity [team_msdyn_agreementinvoicesetup](msdyn_agreementinvoicesetup.md#BKMK_team_msdyn_agreementinvoicesetup) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_agreementinvoicesetup|
|ReferencingAttribute|owningteam|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|team_msdyn_agreementinvoicesetup|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_team_msdyn_agreementsubstatus"></a> team_msdyn_agreementsubstatus

**Added by**: Active Solution Solution

Same as msdyn_agreementsubstatus entity [team_msdyn_agreementsubstatus](msdyn_agreementsubstatus.md#BKMK_team_msdyn_agreementsubstatus) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_agreementsubstatus|
|ReferencingAttribute|owningteam|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|team_msdyn_agreementsubstatus|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_team_msdyn_bookingjournal"></a> team_msdyn_bookingjournal

**Added by**: Active Solution Solution

Same as msdyn_bookingjournal entity [team_msdyn_bookingjournal](msdyn_bookingjournal.md#BKMK_team_msdyn_bookingjournal) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_bookingjournal|
|ReferencingAttribute|owningteam|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|team_msdyn_bookingjournal|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_team_msdyn_bookingtimestamp"></a> team_msdyn_bookingtimestamp

**Added by**: Active Solution Solution

Same as msdyn_bookingtimestamp entity [team_msdyn_bookingtimestamp](msdyn_bookingtimestamp.md#BKMK_team_msdyn_bookingtimestamp) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_bookingtimestamp|
|ReferencingAttribute|owningteam|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|team_msdyn_bookingtimestamp|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_team_msdyn_customerasset"></a> team_msdyn_customerasset

**Added by**: Active Solution Solution

Same as msdyn_customerasset entity [team_msdyn_customerasset](msdyn_customerasset.md#BKMK_team_msdyn_customerasset) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_customerasset|
|ReferencingAttribute|owningteam|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|team_msdyn_customerasset|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_team_msdyn_customerassetcategory"></a> team_msdyn_customerassetcategory

**Added by**: Active Solution Solution

Same as msdyn_customerassetcategory entity [team_msdyn_customerassetcategory](msdyn_customerassetcategory.md#BKMK_team_msdyn_customerassetcategory) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_customerassetcategory|
|ReferencingAttribute|owningteam|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|team_msdyn_customerassetcategory|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_team_msdyn_entitlementapplication"></a> team_msdyn_entitlementapplication

**Added by**: Active Solution Solution

Same as msdyn_entitlementapplication entity [team_msdyn_entitlementapplication](msdyn_entitlementapplication.md#BKMK_team_msdyn_entitlementapplication) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_entitlementapplication|
|ReferencingAttribute|owningteam|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|team_msdyn_entitlementapplication|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_team_msdyn_fieldservicesetting"></a> team_msdyn_fieldservicesetting

**Added by**: Active Solution Solution

Same as msdyn_fieldservicesetting entity [team_msdyn_fieldservicesetting](msdyn_fieldservicesetting.md#BKMK_team_msdyn_fieldservicesetting) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_fieldservicesetting|
|ReferencingAttribute|owningteam|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|team_msdyn_fieldservicesetting|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_team_msdyn_fieldserviceslaconfiguration"></a> team_msdyn_fieldserviceslaconfiguration

**Added by**: Active Solution Solution

Same as msdyn_fieldserviceslaconfiguration entity [team_msdyn_fieldserviceslaconfiguration](msdyn_fieldserviceslaconfiguration.md#BKMK_team_msdyn_fieldserviceslaconfiguration) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_fieldserviceslaconfiguration|
|ReferencingAttribute|owningteam|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|team_msdyn_fieldserviceslaconfiguration|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_team_msdyn_incidenttype"></a> team_msdyn_incidenttype

**Added by**: Active Solution Solution

Same as msdyn_incidenttype entity [team_msdyn_incidenttype](msdyn_incidenttype.md#BKMK_team_msdyn_incidenttype) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_incidenttype|
|ReferencingAttribute|owningteam|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|team_msdyn_incidenttype|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_team_msdyn_incidenttypecharacteristic"></a> team_msdyn_incidenttypecharacteristic

**Added by**: Active Solution Solution

Same as msdyn_incidenttypecharacteristic entity [team_msdyn_incidenttypecharacteristic](msdyn_incidenttypecharacteristic.md#BKMK_team_msdyn_incidenttypecharacteristic) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_incidenttypecharacteristic|
|ReferencingAttribute|owningteam|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|team_msdyn_incidenttypecharacteristic|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_team_msdyn_incidenttypeproduct"></a> team_msdyn_incidenttypeproduct

**Added by**: Active Solution Solution

Same as msdyn_incidenttypeproduct entity [team_msdyn_incidenttypeproduct](msdyn_incidenttypeproduct.md#BKMK_team_msdyn_incidenttypeproduct) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_incidenttypeproduct|
|ReferencingAttribute|owningteam|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|team_msdyn_incidenttypeproduct|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_team_msdyn_incidenttypeservice"></a> team_msdyn_incidenttypeservice

**Added by**: Active Solution Solution

Same as msdyn_incidenttypeservice entity [team_msdyn_incidenttypeservice](msdyn_incidenttypeservice.md#BKMK_team_msdyn_incidenttypeservice) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_incidenttypeservice|
|ReferencingAttribute|owningteam|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|team_msdyn_incidenttypeservice|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_team_msdyn_incidenttypeservicetask"></a> team_msdyn_incidenttypeservicetask

**Added by**: Active Solution Solution

Same as msdyn_incidenttypeservicetask entity [team_msdyn_incidenttypeservicetask](msdyn_incidenttypeservicetask.md#BKMK_team_msdyn_incidenttypeservicetask) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_incidenttypeservicetask|
|ReferencingAttribute|owningteam|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|team_msdyn_incidenttypeservicetask|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_team_msdyn_incidenttypessetup"></a> team_msdyn_incidenttypessetup

**Added by**: Active Solution Solution

Same as msdyn_incidenttypessetup entity [team_msdyn_incidenttypessetup](msdyn_incidenttypessetup.md#BKMK_team_msdyn_incidenttypessetup) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_incidenttypessetup|
|ReferencingAttribute|owningteam|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|team_msdyn_incidenttypessetup|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_team_msdyn_incidenttype_requirementgroup"></a> team_msdyn_incidenttype_requirementgroup

**Added by**: Active Solution Solution

Same as msdyn_incidenttype_requirementgroup entity [team_msdyn_incidenttype_requirementgroup](msdyn_incidenttype_requirementgroup.md#BKMK_team_msdyn_incidenttype_requirementgroup) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_incidenttype_requirementgroup|
|ReferencingAttribute|owningteam|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|team_msdyn_incidenttype_requirementgroup|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_team_msdyn_inventoryadjustment"></a> team_msdyn_inventoryadjustment

**Added by**: Active Solution Solution

Same as msdyn_inventoryadjustment entity [team_msdyn_inventoryadjustment](msdyn_inventoryadjustment.md#BKMK_team_msdyn_inventoryadjustment) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_inventoryadjustment|
|ReferencingAttribute|owningteam|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|team_msdyn_inventoryadjustment|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_team_msdyn_inventoryadjustmentproduct"></a> team_msdyn_inventoryadjustmentproduct

**Added by**: Active Solution Solution

Same as msdyn_inventoryadjustmentproduct entity [team_msdyn_inventoryadjustmentproduct](msdyn_inventoryadjustmentproduct.md#BKMK_team_msdyn_inventoryadjustmentproduct) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_inventoryadjustmentproduct|
|ReferencingAttribute|owningteam|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|team_msdyn_inventoryadjustmentproduct|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_team_msdyn_inventoryjournal"></a> team_msdyn_inventoryjournal

**Added by**: Active Solution Solution

Same as msdyn_inventoryjournal entity [team_msdyn_inventoryjournal](msdyn_inventoryjournal.md#BKMK_team_msdyn_inventoryjournal) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_inventoryjournal|
|ReferencingAttribute|owningteam|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|team_msdyn_inventoryjournal|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_team_msdyn_inventorytransfer"></a> team_msdyn_inventorytransfer

**Added by**: Active Solution Solution

Same as msdyn_inventorytransfer entity [team_msdyn_inventorytransfer](msdyn_inventorytransfer.md#BKMK_team_msdyn_inventorytransfer) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_inventorytransfer|
|ReferencingAttribute|owningteam|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|team_msdyn_inventorytransfer|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_team_msdyn_orderinvoicingdate"></a> team_msdyn_orderinvoicingdate

**Added by**: Active Solution Solution

Same as msdyn_orderinvoicingdate entity [team_msdyn_orderinvoicingdate](msdyn_orderinvoicingdate.md#BKMK_team_msdyn_orderinvoicingdate) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_orderinvoicingdate|
|ReferencingAttribute|owningteam|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|team_msdyn_orderinvoicingdate|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_team_msdyn_orderinvoicingproduct"></a> team_msdyn_orderinvoicingproduct

**Added by**: Active Solution Solution

Same as msdyn_orderinvoicingproduct entity [team_msdyn_orderinvoicingproduct](msdyn_orderinvoicingproduct.md#BKMK_team_msdyn_orderinvoicingproduct) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_orderinvoicingproduct|
|ReferencingAttribute|owningteam|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|team_msdyn_orderinvoicingproduct|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_team_msdyn_orderinvoicingsetup"></a> team_msdyn_orderinvoicingsetup

**Added by**: Active Solution Solution

Same as msdyn_orderinvoicingsetup entity [team_msdyn_orderinvoicingsetup](msdyn_orderinvoicingsetup.md#BKMK_team_msdyn_orderinvoicingsetup) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_orderinvoicingsetup|
|ReferencingAttribute|owningteam|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|team_msdyn_orderinvoicingsetup|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_team_msdyn_orderinvoicingsetupdate"></a> team_msdyn_orderinvoicingsetupdate

**Added by**: Active Solution Solution

Same as msdyn_orderinvoicingsetupdate entity [team_msdyn_orderinvoicingsetupdate](msdyn_orderinvoicingsetupdate.md#BKMK_team_msdyn_orderinvoicingsetupdate) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_orderinvoicingsetupdate|
|ReferencingAttribute|owningteam|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|team_msdyn_orderinvoicingsetupdate|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_team_msdyn_payment"></a> team_msdyn_payment

**Added by**: Active Solution Solution

Same as msdyn_payment entity [team_msdyn_payment](msdyn_payment.md#BKMK_team_msdyn_payment) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_payment|
|ReferencingAttribute|owningteam|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|team_msdyn_payment|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_team_msdyn_paymentdetail"></a> team_msdyn_paymentdetail

**Added by**: Active Solution Solution

Same as msdyn_paymentdetail entity [team_msdyn_paymentdetail](msdyn_paymentdetail.md#BKMK_team_msdyn_paymentdetail) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_paymentdetail|
|ReferencingAttribute|owningteam|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|team_msdyn_paymentdetail|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_team_msdyn_paymentmethod"></a> team_msdyn_paymentmethod

**Added by**: Active Solution Solution

Same as msdyn_paymentmethod entity [team_msdyn_paymentmethod](msdyn_paymentmethod.md#BKMK_team_msdyn_paymentmethod) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_paymentmethod|
|ReferencingAttribute|owningteam|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|team_msdyn_paymentmethod|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_team_msdyn_paymentterm"></a> team_msdyn_paymentterm

**Added by**: Active Solution Solution

Same as msdyn_paymentterm entity [team_msdyn_paymentterm](msdyn_paymentterm.md#BKMK_team_msdyn_paymentterm) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_paymentterm|
|ReferencingAttribute|owningteam|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|team_msdyn_paymentterm|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_team_msdyn_postalcode"></a> team_msdyn_postalcode

**Added by**: Active Solution Solution

Same as msdyn_postalcode entity [team_msdyn_postalcode](msdyn_postalcode.md#BKMK_team_msdyn_postalcode) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_postalcode|
|ReferencingAttribute|owningteam|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|team_msdyn_postalcode|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_team_msdyn_purchaseorder"></a> team_msdyn_purchaseorder

**Added by**: Active Solution Solution

Same as msdyn_purchaseorder entity [team_msdyn_purchaseorder](msdyn_purchaseorder.md#BKMK_team_msdyn_purchaseorder) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_purchaseorder|
|ReferencingAttribute|owningteam|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|team_msdyn_purchaseorder|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_team_msdyn_purchaseorderbill"></a> team_msdyn_purchaseorderbill

**Added by**: Active Solution Solution

Same as msdyn_purchaseorderbill entity [team_msdyn_purchaseorderbill](msdyn_purchaseorderbill.md#BKMK_team_msdyn_purchaseorderbill) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_purchaseorderbill|
|ReferencingAttribute|owningteam|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|team_msdyn_purchaseorderbill|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_team_msdyn_purchaseorderproduct"></a> team_msdyn_purchaseorderproduct

**Added by**: Active Solution Solution

Same as msdyn_purchaseorderproduct entity [team_msdyn_purchaseorderproduct](msdyn_purchaseorderproduct.md#BKMK_team_msdyn_purchaseorderproduct) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_purchaseorderproduct|
|ReferencingAttribute|owningteam|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|team_msdyn_purchaseorderproduct|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_team_msdyn_purchaseorderreceipt"></a> team_msdyn_purchaseorderreceipt

**Added by**: Active Solution Solution

Same as msdyn_purchaseorderreceipt entity [team_msdyn_purchaseorderreceipt](msdyn_purchaseorderreceipt.md#BKMK_team_msdyn_purchaseorderreceipt) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_purchaseorderreceipt|
|ReferencingAttribute|owningteam|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|team_msdyn_purchaseorderreceipt|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_team_msdyn_purchaseorderreceiptproduct"></a> team_msdyn_purchaseorderreceiptproduct

**Added by**: Active Solution Solution

Same as msdyn_purchaseorderreceiptproduct entity [team_msdyn_purchaseorderreceiptproduct](msdyn_purchaseorderreceiptproduct.md#BKMK_team_msdyn_purchaseorderreceiptproduct) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_purchaseorderreceiptproduct|
|ReferencingAttribute|owningteam|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|team_msdyn_purchaseorderreceiptproduct|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_team_msdyn_purchaseordersubstatus"></a> team_msdyn_purchaseordersubstatus

**Added by**: Active Solution Solution

Same as msdyn_purchaseordersubstatus entity [team_msdyn_purchaseordersubstatus](msdyn_purchaseordersubstatus.md#BKMK_team_msdyn_purchaseordersubstatus) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_purchaseordersubstatus|
|ReferencingAttribute|owningteam|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|team_msdyn_purchaseordersubstatus|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_team_msdyn_quotebookingincident"></a> team_msdyn_quotebookingincident

**Added by**: Active Solution Solution

Same as msdyn_quotebookingincident entity [team_msdyn_quotebookingincident](msdyn_quotebookingincident.md#BKMK_team_msdyn_quotebookingincident) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_quotebookingincident|
|ReferencingAttribute|owningteam|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|team_msdyn_quotebookingincident|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_team_msdyn_quotebookingproduct"></a> team_msdyn_quotebookingproduct

**Added by**: Active Solution Solution

Same as msdyn_quotebookingproduct entity [team_msdyn_quotebookingproduct](msdyn_quotebookingproduct.md#BKMK_team_msdyn_quotebookingproduct) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_quotebookingproduct|
|ReferencingAttribute|owningteam|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|team_msdyn_quotebookingproduct|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_team_msdyn_quotebookingservice"></a> team_msdyn_quotebookingservice

**Added by**: Active Solution Solution

Same as msdyn_quotebookingservice entity [team_msdyn_quotebookingservice](msdyn_quotebookingservice.md#BKMK_team_msdyn_quotebookingservice) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_quotebookingservice|
|ReferencingAttribute|owningteam|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|team_msdyn_quotebookingservice|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_team_msdyn_quotebookingservicetask"></a> team_msdyn_quotebookingservicetask

**Added by**: Active Solution Solution

Same as msdyn_quotebookingservicetask entity [team_msdyn_quotebookingservicetask](msdyn_quotebookingservicetask.md#BKMK_team_msdyn_quotebookingservicetask) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_quotebookingservicetask|
|ReferencingAttribute|owningteam|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|team_msdyn_quotebookingservicetask|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_team_msdyn_quotebookingsetup"></a> team_msdyn_quotebookingsetup

**Added by**: Active Solution Solution

Same as msdyn_quotebookingsetup entity [team_msdyn_quotebookingsetup](msdyn_quotebookingsetup.md#BKMK_team_msdyn_quotebookingsetup) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_quotebookingsetup|
|ReferencingAttribute|owningteam|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|team_msdyn_quotebookingsetup|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_team_msdyn_quoteinvoicingproduct"></a> team_msdyn_quoteinvoicingproduct

**Added by**: Active Solution Solution

Same as msdyn_quoteinvoicingproduct entity [team_msdyn_quoteinvoicingproduct](msdyn_quoteinvoicingproduct.md#BKMK_team_msdyn_quoteinvoicingproduct) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_quoteinvoicingproduct|
|ReferencingAttribute|owningteam|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|team_msdyn_quoteinvoicingproduct|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_team_msdyn_quoteinvoicingsetup"></a> team_msdyn_quoteinvoicingsetup

**Added by**: Active Solution Solution

Same as msdyn_quoteinvoicingsetup entity [team_msdyn_quoteinvoicingsetup](msdyn_quoteinvoicingsetup.md#BKMK_team_msdyn_quoteinvoicingsetup) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_quoteinvoicingsetup|
|ReferencingAttribute|owningteam|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|team_msdyn_quoteinvoicingsetup|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_team_msdyn_resourcepaytype"></a> team_msdyn_resourcepaytype

**Added by**: Active Solution Solution

Same as msdyn_resourcepaytype entity [team_msdyn_resourcepaytype](msdyn_resourcepaytype.md#BKMK_team_msdyn_resourcepaytype) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_resourcepaytype|
|ReferencingAttribute|owningteam|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|team_msdyn_resourcepaytype|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_team_msdyn_rma"></a> team_msdyn_rma

**Added by**: Active Solution Solution

Same as msdyn_rma entity [team_msdyn_rma](msdyn_rma.md#BKMK_team_msdyn_rma) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_rma|
|ReferencingAttribute|owningteam|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|team_msdyn_rma|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_team_msdyn_rmaproduct"></a> team_msdyn_rmaproduct

**Added by**: Active Solution Solution

Same as msdyn_rmaproduct entity [team_msdyn_rmaproduct](msdyn_rmaproduct.md#BKMK_team_msdyn_rmaproduct) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_rmaproduct|
|ReferencingAttribute|owningteam|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|team_msdyn_rmaproduct|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_team_msdyn_rmareceipt"></a> team_msdyn_rmareceipt

**Added by**: Active Solution Solution

Same as msdyn_rmareceipt entity [team_msdyn_rmareceipt](msdyn_rmareceipt.md#BKMK_team_msdyn_rmareceipt) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_rmareceipt|
|ReferencingAttribute|owningteam|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|team_msdyn_rmareceipt|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_team_msdyn_rmareceiptproduct"></a> team_msdyn_rmareceiptproduct

**Added by**: Active Solution Solution

Same as msdyn_rmareceiptproduct entity [team_msdyn_rmareceiptproduct](msdyn_rmareceiptproduct.md#BKMK_team_msdyn_rmareceiptproduct) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_rmareceiptproduct|
|ReferencingAttribute|owningteam|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|team_msdyn_rmareceiptproduct|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_team_msdyn_rmasubstatus"></a> team_msdyn_rmasubstatus

**Added by**: Active Solution Solution

Same as msdyn_rmasubstatus entity [team_msdyn_rmasubstatus](msdyn_rmasubstatus.md#BKMK_team_msdyn_rmasubstatus) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_rmasubstatus|
|ReferencingAttribute|owningteam|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|team_msdyn_rmasubstatus|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_team_msdyn_rtv"></a> team_msdyn_rtv

**Added by**: Active Solution Solution

Same as msdyn_rtv entity [team_msdyn_rtv](msdyn_rtv.md#BKMK_team_msdyn_rtv) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_rtv|
|ReferencingAttribute|owningteam|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|team_msdyn_rtv|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_team_msdyn_rtvproduct"></a> team_msdyn_rtvproduct

**Added by**: Active Solution Solution

Same as msdyn_rtvproduct entity [team_msdyn_rtvproduct](msdyn_rtvproduct.md#BKMK_team_msdyn_rtvproduct) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_rtvproduct|
|ReferencingAttribute|owningteam|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|team_msdyn_rtvproduct|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_team_msdyn_rtvsubstatus"></a> team_msdyn_rtvsubstatus

**Added by**: Active Solution Solution

Same as msdyn_rtvsubstatus entity [team_msdyn_rtvsubstatus](msdyn_rtvsubstatus.md#BKMK_team_msdyn_rtvsubstatus) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_rtvsubstatus|
|ReferencingAttribute|owningteam|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|team_msdyn_rtvsubstatus|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_team_msdyn_servicetasktype"></a> team_msdyn_servicetasktype

**Added by**: Active Solution Solution

Same as msdyn_servicetasktype entity [team_msdyn_servicetasktype](msdyn_servicetasktype.md#BKMK_team_msdyn_servicetasktype) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_servicetasktype|
|ReferencingAttribute|owningteam|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|team_msdyn_servicetasktype|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_team_msdyn_shipvia"></a> team_msdyn_shipvia

**Added by**: Active Solution Solution

Same as msdyn_shipvia entity [team_msdyn_shipvia](msdyn_shipvia.md#BKMK_team_msdyn_shipvia) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_shipvia|
|ReferencingAttribute|owningteam|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|team_msdyn_shipvia|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_team_msdyn_taxcode"></a> team_msdyn_taxcode

**Added by**: Active Solution Solution

Same as msdyn_taxcode entity [team_msdyn_taxcode](msdyn_taxcode.md#BKMK_team_msdyn_taxcode) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_taxcode|
|ReferencingAttribute|owningteam|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|team_msdyn_taxcode|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_team_msdyn_taxcodedetail"></a> team_msdyn_taxcodedetail

**Added by**: Active Solution Solution

Same as msdyn_taxcodedetail entity [team_msdyn_taxcodedetail](msdyn_taxcodedetail.md#BKMK_team_msdyn_taxcodedetail) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_taxcodedetail|
|ReferencingAttribute|owningteam|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|team_msdyn_taxcodedetail|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_team_msdyn_timeoffrequest"></a> team_msdyn_timeoffrequest

**Added by**: Active Solution Solution

Same as msdyn_timeoffrequest entity [team_msdyn_timeoffrequest](msdyn_timeoffrequest.md#BKMK_team_msdyn_timeoffrequest) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_timeoffrequest|
|ReferencingAttribute|owningteam|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|team_msdyn_timeoffrequest|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_team_msdyn_warehouse"></a> team_msdyn_warehouse

**Added by**: Active Solution Solution

Same as msdyn_warehouse entity [team_msdyn_warehouse](msdyn_warehouse.md#BKMK_team_msdyn_warehouse) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_warehouse|
|ReferencingAttribute|owningteam|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|team_msdyn_warehouse|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_team_msdyn_workorder"></a> team_msdyn_workorder

**Added by**: Active Solution Solution

Same as msdyn_workorder entity [team_msdyn_workorder](msdyn_workorder.md#BKMK_team_msdyn_workorder) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_workorder|
|ReferencingAttribute|owningteam|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|team_msdyn_workorder|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_team_msdyn_workordercharacteristic"></a> team_msdyn_workordercharacteristic

**Added by**: Active Solution Solution

Same as msdyn_workordercharacteristic entity [team_msdyn_workordercharacteristic](msdyn_workordercharacteristic.md#BKMK_team_msdyn_workordercharacteristic) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_workordercharacteristic|
|ReferencingAttribute|owningteam|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|team_msdyn_workordercharacteristic|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_team_msdyn_workorderincident"></a> team_msdyn_workorderincident

**Added by**: Active Solution Solution

Same as msdyn_workorderincident entity [team_msdyn_workorderincident](msdyn_workorderincident.md#BKMK_team_msdyn_workorderincident) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_workorderincident|
|ReferencingAttribute|owningteam|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|team_msdyn_workorderincident|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_team_msdyn_workorderproduct"></a> team_msdyn_workorderproduct

**Added by**: Active Solution Solution

Same as msdyn_workorderproduct entity [team_msdyn_workorderproduct](msdyn_workorderproduct.md#BKMK_team_msdyn_workorderproduct) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_workorderproduct|
|ReferencingAttribute|owningteam|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|team_msdyn_workorderproduct|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_team_msdyn_workorderresourcerestriction"></a> team_msdyn_workorderresourcerestriction

**Added by**: Active Solution Solution

Same as msdyn_workorderresourcerestriction entity [team_msdyn_workorderresourcerestriction](msdyn_workorderresourcerestriction.md#BKMK_team_msdyn_workorderresourcerestriction) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_workorderresourcerestriction|
|ReferencingAttribute|owningteam|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|team_msdyn_workorderresourcerestriction|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_team_msdyn_workorderservice"></a> team_msdyn_workorderservice

**Added by**: Active Solution Solution

Same as msdyn_workorderservice entity [team_msdyn_workorderservice](msdyn_workorderservice.md#BKMK_team_msdyn_workorderservice) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_workorderservice|
|ReferencingAttribute|owningteam|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|team_msdyn_workorderservice|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_team_msdyn_workorderservicetask"></a> team_msdyn_workorderservicetask

**Added by**: Active Solution Solution

Same as msdyn_workorderservicetask entity [team_msdyn_workorderservicetask](msdyn_workorderservicetask.md#BKMK_team_msdyn_workorderservicetask) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_workorderservicetask|
|ReferencingAttribute|owningteam|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|team_msdyn_workorderservicetask|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_team_msdyn_workordersubstatus"></a> team_msdyn_workordersubstatus

**Added by**: Active Solution Solution

Same as msdyn_workordersubstatus entity [team_msdyn_workordersubstatus](msdyn_workordersubstatus.md#BKMK_team_msdyn_workordersubstatus) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_workordersubstatus|
|ReferencingAttribute|owningteam|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|team_msdyn_workordersubstatus|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_team_msdyn_workordertype"></a> team_msdyn_workordertype

**Added by**: Active Solution Solution

Same as msdyn_workordertype entity [team_msdyn_workordertype](msdyn_workordertype.md#BKMK_team_msdyn_workordertype) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_workordertype|
|ReferencingAttribute|owningteam|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|team_msdyn_workordertype|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_team_msdyn_iotalert"></a> team_msdyn_iotalert

**Added by**: Active Solution Solution

Same as msdyn_iotalert entity [team_msdyn_iotalert](msdyn_iotalert.md#BKMK_team_msdyn_iotalert) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_iotalert|
|ReferencingAttribute|owningteam|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|team_msdyn_iotalert|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_team_msdyn_iotdevice"></a> team_msdyn_iotdevice

**Added by**: Active Solution Solution

Same as msdyn_iotdevice entity [team_msdyn_iotdevice](msdyn_iotdevice.md#BKMK_team_msdyn_iotdevice) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_iotdevice|
|ReferencingAttribute|owningteam|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|team_msdyn_iotdevice|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_team_msdyn_iotdevicecategory"></a> team_msdyn_iotdevicecategory

**Added by**: Active Solution Solution

Same as msdyn_iotdevicecategory entity [team_msdyn_iotdevicecategory](msdyn_iotdevicecategory.md#BKMK_team_msdyn_iotdevicecategory) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_iotdevicecategory|
|ReferencingAttribute|owningteam|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|team_msdyn_iotdevicecategory|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_team_msdyn_iotdevicecommand"></a> team_msdyn_iotdevicecommand

**Added by**: Active Solution Solution

Same as msdyn_iotdevicecommand entity [team_msdyn_iotdevicecommand](msdyn_iotdevicecommand.md#BKMK_team_msdyn_iotdevicecommand) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_iotdevicecommand|
|ReferencingAttribute|owningteam|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|team_msdyn_iotdevicecommand|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_team_msdyn_iotdevicecommanddefinition"></a> team_msdyn_iotdevicecommanddefinition

**Added by**: Active Solution Solution

Same as msdyn_iotdevicecommanddefinition entity [team_msdyn_iotdevicecommanddefinition](msdyn_iotdevicecommanddefinition.md#BKMK_team_msdyn_iotdevicecommanddefinition) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_iotdevicecommanddefinition|
|ReferencingAttribute|owningteam|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|team_msdyn_iotdevicecommanddefinition|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_team_msdyn_iotdevicedatahistory"></a> team_msdyn_iotdevicedatahistory

**Added by**: Active Solution Solution

Same as msdyn_iotdevicedatahistory entity [team_msdyn_iotdevicedatahistory](msdyn_iotdevicedatahistory.md#BKMK_team_msdyn_iotdevicedatahistory) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_iotdevicedatahistory|
|ReferencingAttribute|owningteam|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|team_msdyn_iotdevicedatahistory|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_team_msdyn_iotdeviceproperty"></a> team_msdyn_iotdeviceproperty

**Added by**: Active Solution Solution

Same as msdyn_iotdeviceproperty entity [team_msdyn_iotdeviceproperty](msdyn_iotdeviceproperty.md#BKMK_team_msdyn_iotdeviceproperty) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_iotdeviceproperty|
|ReferencingAttribute|owningteam|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|team_msdyn_iotdeviceproperty|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_team_msdyn_iotdeviceregistrationhistory"></a> team_msdyn_iotdeviceregistrationhistory

**Added by**: Active Solution Solution

Same as msdyn_iotdeviceregistrationhistory entity [team_msdyn_iotdeviceregistrationhistory](msdyn_iotdeviceregistrationhistory.md#BKMK_team_msdyn_iotdeviceregistrationhistory) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_iotdeviceregistrationhistory|
|ReferencingAttribute|owningteam|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|team_msdyn_iotdeviceregistrationhistory|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_team_msdyn_iotpropertydefinition"></a> team_msdyn_iotpropertydefinition

**Added by**: Active Solution Solution

Same as msdyn_iotpropertydefinition entity [team_msdyn_iotpropertydefinition](msdyn_iotpropertydefinition.md#BKMK_team_msdyn_iotpropertydefinition) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_iotpropertydefinition|
|ReferencingAttribute|owningteam|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|team_msdyn_iotpropertydefinition|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_team_msdyn_iotsettings"></a> team_msdyn_iotsettings

**Added by**: Active Solution Solution

Same as msdyn_iotsettings entity [team_msdyn_iotsettings](msdyn_iotsettings.md#BKMK_team_msdyn_iotsettings) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_iotsettings|
|ReferencingAttribute|owningteam|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|team_msdyn_iotsettings|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_team_msdyn_entityconfiguration"></a> team_msdyn_entityconfiguration

**Added by**: Active Solution Solution

Same as msdyn_entityconfiguration entity [team_msdyn_entityconfiguration](msdyn_entityconfiguration.md#BKMK_team_msdyn_entityconfiguration) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_entityconfiguration|
|ReferencingAttribute|owningteam|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|team_msdyn_entityconfiguration|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_team_msdyn_geofence"></a> team_msdyn_geofence

**Added by**: Active Solution Solution

Same as msdyn_geofence entity [team_msdyn_geofence](msdyn_geofence.md#BKMK_team_msdyn_geofence) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_geofence|
|ReferencingAttribute|owningteam|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|team_msdyn_geofence|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_team_msdyn_geofenceevent"></a> team_msdyn_geofenceevent

**Added by**: Active Solution Solution

Same as msdyn_geofenceevent entity [team_msdyn_geofenceevent](msdyn_geofenceevent.md#BKMK_team_msdyn_geofenceevent) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_geofenceevent|
|ReferencingAttribute|owningteam|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|team_msdyn_geofenceevent|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_team_msdyn_geofencingsettings"></a> team_msdyn_geofencingsettings

**Added by**: Active Solution Solution

Same as msdyn_geofencingsettings entity [team_msdyn_geofencingsettings](msdyn_geofencingsettings.md#BKMK_team_msdyn_geofencingsettings) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_geofencingsettings|
|ReferencingAttribute|owningteam|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|team_msdyn_geofencingsettings|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_team_msdyn_connector"></a> team_msdyn_connector

**Added by**: Active Solution Solution

Same as msdyn_connector entity [team_msdyn_connector](msdyn_connector.md#BKMK_team_msdyn_connector) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_connector|
|ReferencingAttribute|owningteam|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|team_msdyn_connector|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_team_principalobjectattributeaccess_principalid"></a> team_principalobjectattributeaccess_principalid

Same as principalobjectattributeaccess entity [team_principalobjectattributeaccess_principalid](principalobjectattributeaccess.md#BKMK_team_principalobjectattributeaccess_principalid) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|principalobjectattributeaccess|
|ReferencingAttribute|principalid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|team_principalobjectattributeaccess_principalid|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_team_exchangesyncidmapping"></a> team_exchangesyncidmapping

Same as exchangesyncidmapping entity [team_exchangesyncidmapping](exchangesyncidmapping.md#BKMK_team_exchangesyncidmapping) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|exchangesyncidmapping|
|ReferencingAttribute|owningteam|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|team_exchangesyncidmapping|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_team_interactionforemail"></a> team_interactionforemail

Same as interactionforemail entity [team_interactionforemail](interactionforemail.md#BKMK_team_interactionforemail) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|interactionforemail|
|ReferencingAttribute|owningteam|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|team_new_interactionforemail|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_team_knowledgearticle"></a> team_knowledgearticle

Same as knowledgearticle entity [team_knowledgearticle](knowledgearticle.md#BKMK_team_knowledgearticle) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|knowledgearticle|
|ReferencingAttribute|owningteam|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|team_knowledgearticle|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_team_sharepointsite"></a> team_sharepointsite

Same as sharepointsite entity [team_sharepointsite](sharepointsite.md#BKMK_team_sharepointsite) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|sharepointsite|
|ReferencingAttribute|owningteam|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|team_sharepointsite|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_team_sharepointdocumentlocation"></a> team_sharepointdocumentlocation

Same as sharepointdocumentlocation entity [team_sharepointdocumentlocation](sharepointdocumentlocation.md#BKMK_team_sharepointdocumentlocation) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|sharepointdocumentlocation|
|ReferencingAttribute|owningteam|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|team_sharepointdocumentlocation|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_team_goal"></a> team_goal

Same as goal entity [team_goal](goal.md#BKMK_team_goal) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|goal|
|ReferencingAttribute|owningteam|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|team_goal|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_team_goalrollupquery"></a> team_goalrollupquery

Same as goalrollupquery entity [team_goalrollupquery](goalrollupquery.md#BKMK_team_goalrollupquery) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|goalrollupquery|
|ReferencingAttribute|owningteam|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|team_goalrollupquery|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_team_mailbox"></a> team_mailbox

Same as mailbox entity [team_mailbox](mailbox.md#BKMK_team_mailbox) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|mailbox|
|ReferencingAttribute|owningteam|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|team_mailbox|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_team_connections2"></a> team_connections2

Same as connection entity [team_connections2](connection.md#BKMK_team_connections2) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|connection|
|ReferencingAttribute|record2id|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|team_connections2|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: 100|
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_team_slaBase"></a> team_slaBase

Same as sla entity [team_slaBase](sla.md#BKMK_team_slaBase) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|sla|
|ReferencingAttribute|owningteam|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|team_slaBase|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_team_goal_goalowner"></a> team_goal_goalowner

Same as goal entity [team_goal_goalowner](goal.md#BKMK_team_goal_goalowner) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|goal|
|ReferencingAttribute|goalownerid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|team_goal_goalowner|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Details<br />Label: <br />Order: 110|
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_team_principalobjectattributeaccess"></a> team_principalobjectattributeaccess

Same as principalobjectattributeaccess entity [team_principalobjectattributeaccess](principalobjectattributeaccess.md#BKMK_team_principalobjectattributeaccess) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|principalobjectattributeaccess|
|ReferencingAttribute|objectid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|team_principalobjectattributeaccess|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_OwningTeam_postfollows"></a> OwningTeam_postfollows

Same as postfollow entity [OwningTeam_postfollows](postfollow.md#BKMK_OwningTeam_postfollows) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|postfollow|
|ReferencingAttribute|owningteam|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|OwningTeam_postfollows|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_team_ImportMaps"></a> team_ImportMaps

Same as importmap entity [team_ImportMaps](importmap.md#BKMK_team_ImportMaps) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|importmap|
|ReferencingAttribute|owningteam|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|team_ImportMaps|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_team_recurringappointmentmaster"></a> team_recurringappointmentmaster

Same as recurringappointmentmaster entity [team_recurringappointmentmaster](recurringappointmentmaster.md#BKMK_team_recurringappointmentmaster) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|recurringappointmentmaster|
|ReferencingAttribute|owningteam|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|team_recurringappointmentmaster|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_team_queueitembase_workerid"></a> team_queueitembase_workerid

Same as queueitem entity [team_queueitembase_workerid](queueitem.md#BKMK_team_queueitembase_workerid) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|queueitem|
|ReferencingAttribute|workerid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|team_queueitembase_workerid|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_team_phonecall"></a> team_phonecall

Same as phonecall entity [team_phonecall](phonecall.md#BKMK_team_phonecall) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|phonecall|
|ReferencingAttribute|owningteam|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|team_phonecall|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_team_emailserverprofile"></a> team_emailserverprofile

Same as emailserverprofile entity [team_emailserverprofile](emailserverprofile.md#BKMK_team_emailserverprofile) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|emailserverprofile|
|ReferencingAttribute|owningteam|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|team_emailserverprofile|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_team_connections1"></a> team_connections1

Same as connection entity [team_connections1](connection.md#BKMK_team_connections1) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|connection|
|ReferencingAttribute|record1id|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|team_connections1|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Details<br />Label: <br />Order: 100|
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_team_userqueryvisualizations"></a> team_userqueryvisualizations

Same as userqueryvisualization entity [team_userqueryvisualizations](userqueryvisualization.md#BKMK_team_userqueryvisualizations) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|userqueryvisualization|
|ReferencingAttribute|owningteam|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|team_userqueryvisualizations|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_team_userform"></a> team_userform

Same as userform entity [team_userform](userform.md#BKMK_team_userform) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|userform|
|ReferencingAttribute|owningteam|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|team_userform|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_team_socialactivity"></a> team_socialactivity

Same as socialactivity entity [team_socialactivity](socialactivity.md#BKMK_team_socialactivity) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|socialactivity|
|ReferencingAttribute|owningteam|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|team_socialactivity|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_Team_ProcessSessions"></a> Team_ProcessSessions

Same as processsession entity [Team_ProcessSessions](processsession.md#BKMK_Team_ProcessSessions) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|processsession|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|Team_ProcessSessions|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Details<br />Label: <br />Order: 110|
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_Team_DuplicateMatchingRecord"></a> Team_DuplicateMatchingRecord

Same as duplicaterecord entity [Team_DuplicateMatchingRecord](duplicaterecord.md#BKMK_Team_DuplicateMatchingRecord) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|duplicaterecord|
|ReferencingAttribute|duplicaterecordid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|Team_DuplicateMatchingRecord|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_team_contacts"></a> team_contacts

Same as contact entity [team_contacts](contact.md#BKMK_team_contacts) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|contact|
|ReferencingAttribute|owningteam|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|team_contacts|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_Team_AsyncOperations"></a> Team_AsyncOperations

Same as asyncoperation entity [Team_AsyncOperations](asyncoperation.md#BKMK_Team_AsyncOperations) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|asyncoperation|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|Team_AsyncOperations|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_team_ImportLogs"></a> team_ImportLogs

Same as importlog entity [team_ImportLogs](importlog.md#BKMK_team_ImportLogs) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|importlog|
|ReferencingAttribute|owningteam|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|team_ImportLogs|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_team_workflowlog"></a> team_workflowlog

Same as workflowlog entity [team_workflowlog](workflowlog.md#BKMK_team_workflowlog) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|workflowlog|
|ReferencingAttribute|owningteam|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|team_workflowlog|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_team_Imports"></a> team_Imports

Same as import entity [team_Imports](import.md#BKMK_team_Imports) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|import|
|ReferencingAttribute|owningteam|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|team_Imports|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_team_processsession"></a> team_processsession

Same as processsession entity [team_processsession](processsession.md#BKMK_team_processsession) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|processsession|
|ReferencingAttribute|owningteam|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|team_processsession|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_team_SyncError"></a> team_SyncError

Same as syncerror entity [team_SyncError](syncerror.md#BKMK_team_SyncError) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|syncerror|
|ReferencingAttribute|owningteam|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|team_SyncError|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_team_letter"></a> team_letter

Same as letter entity [team_letter](letter.md#BKMK_team_letter) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|letter|
|ReferencingAttribute|owningteam|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|team_letter|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_team_annotations"></a> team_annotations

Same as annotation entity [team_annotations](annotation.md#BKMK_team_annotations) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|annotation|
|ReferencingAttribute|owningteam|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|team_annotations|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_team_appointment"></a> team_appointment

Same as appointment entity [team_appointment](appointment.md#BKMK_team_appointment) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|appointment|
|ReferencingAttribute|owningteam|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|team_appointment|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_team_asyncoperation"></a> team_asyncoperation

Same as asyncoperation entity [team_asyncoperation](asyncoperation.md#BKMK_team_asyncoperation) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|asyncoperation|
|ReferencingAttribute|owningteam|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|team_asyncoperation|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_Team_BulkDeleteFailures"></a> Team_BulkDeleteFailures

Same as bulkdeletefailure entity [Team_BulkDeleteFailures](bulkdeletefailure.md#BKMK_Team_BulkDeleteFailures) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|bulkdeletefailure|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|Team_BulkDeleteFailures|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_Team_SyncErrors"></a> Team_SyncErrors

Same as syncerror entity [Team_SyncErrors](syncerror.md#BKMK_Team_SyncErrors) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|syncerror|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|Team_SyncErrors|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: Cascade<br />Reparent: Cascade<br />Share: Cascade<br />Unshare: Cascade|


### <a name="BKMK_team_mailboxtrackingfolder"></a> team_mailboxtrackingfolder

Same as mailboxtrackingfolder entity [team_mailboxtrackingfolder](mailboxtrackingfolder.md#BKMK_team_mailboxtrackingfolder) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|mailboxtrackingfolder|
|ReferencingAttribute|owningteam|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|team_mailboxtrackingfolder|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_team_task"></a> team_task

Same as task entity [team_task](task.md#BKMK_team_task) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|task|
|ReferencingAttribute|owningteam|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|team_task|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_team_activity"></a> team_activity

Same as activitypointer entity [team_activity](activitypointer.md#BKMK_team_activity) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|activitypointer|
|ReferencingAttribute|owningteam|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|team_activity|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_Team_DuplicateBaseRecord"></a> Team_DuplicateBaseRecord

Same as duplicaterecord entity [Team_DuplicateBaseRecord](duplicaterecord.md#BKMK_Team_DuplicateBaseRecord) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|duplicaterecord|
|ReferencingAttribute|baserecordid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|Team_DuplicateBaseRecord|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_team_accounts"></a> team_accounts

Same as account entity [team_accounts](account.md#BKMK_team_accounts) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|account|
|ReferencingAttribute|owningteam|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|team_accounts|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_team_userquery"></a> team_userquery

Same as userquery entity [team_userquery](userquery.md#BKMK_team_userquery) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|userquery|
|ReferencingAttribute|owningteam|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|team_userquery|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_team_email"></a> team_email

Same as email entity [team_email](email.md#BKMK_team_email) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|email|
|ReferencingAttribute|owningteam|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|team_email|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_ImportFile_Team"></a> ImportFile_Team

Same as importfile entity [ImportFile_Team](importfile.md#BKMK_ImportFile_Team) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|importfile|
|ReferencingAttribute|recordsownerid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|ImportFile_Team|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_team_ImportFiles"></a> team_ImportFiles

Same as importfile entity [team_ImportFiles](importfile.md#BKMK_team_ImportFiles) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|importfile|
|ReferencingAttribute|owningteam|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|team_ImportFiles|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_team_email_templates"></a> team_email_templates

Same as template entity [team_email_templates](template.md#BKMK_team_email_templates) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|template|
|ReferencingAttribute|owningteam|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|team_email_templates|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_team_fax"></a> team_fax

Same as fax entity [team_fax](fax.md#BKMK_team_fax) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|fax|
|ReferencingAttribute|owningteam|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|team_fax|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_team_DuplicateRules"></a> team_DuplicateRules

Same as duplicaterule entity [team_DuplicateRules](duplicaterule.md#BKMK_team_DuplicateRules) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|duplicaterule|
|ReferencingAttribute|owningteam|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|team_DuplicateRules|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_team_workflow"></a> team_workflow

Same as workflow entity [team_workflow](workflow.md#BKMK_team_workflow) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|workflow|
|ReferencingAttribute|owningteam|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|team_workflow|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|

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

**Added by**: Sales Solution

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

IntersectEntityName: teamroles<br />
#### Entity 1

|Property|Value|
|--------|-----|
|IntersectAttribute|teamid|
|IsCustomizable|False|
|LogicalName|team|
|NavigationPropertyName|teamroles_association|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |

#### Entity 2

|Property|Value|
|--------|-----|
|LogicalName|role|
|IntersectAttribute|roleid|
|NavigationPropertyName|teamroles_association|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |


### <a name="BKMK_teammembership_association"></a> teammembership_association

IntersectEntityName: teammembership<br />
#### Entity 1

|Property|Value|
|--------|-----|
|IntersectAttribute|teamid|
|IsCustomizable|False|
|LogicalName|team|
|NavigationPropertyName|teammembership_association|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |

#### Entity 2

|Property|Value|
|--------|-----|
|LogicalName|systemuser|
|IntersectAttribute|systemuserid|
|NavigationPropertyName|teammembership_association|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |


### <a name="BKMK_teamprofiles_association"></a> teamprofiles_association

IntersectEntityName: teamprofiles<br />
#### Entity 1

|Property|Value|
|--------|-----|
|IntersectAttribute|teamid|
|IsCustomizable|False|
|LogicalName|team|
|NavigationPropertyName|teamprofiles_association|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Details<br />Label: <br />Order: |

#### Entity 2

|Property|Value|
|--------|-----|
|LogicalName|fieldsecurityprofile|
|IntersectAttribute|fieldsecurityprofileid|
|NavigationPropertyName|teamprofiles_association|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Details<br />Label: <br />Order: |


### See also

[About the Entity Reference](../about-entity-reference.md)<br />
[Programming reference for Dynamics 365 Customer Engagement](../programming-reference.md)<br />
[Web API Reference](/dynamics365/customer-engagement/web-api/about)<br />
<xref href="Microsoft.Dynamics.CRM.team?text=team EntityType" />

[!INCLUDE[footer-include](../../../../includes/footer-banner.md)]