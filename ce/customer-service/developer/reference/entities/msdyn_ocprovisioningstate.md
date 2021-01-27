---
title: "msdyn_ocprovisioningstate Entity Reference | MicrosoftDocs"
description: "Includes schema information and supported messages for the msdyn_ocprovisioningstate entity."
author: "v-sailab"
ms.author: "v-sailab"
manager: "shujoshi"
ms.date: 09/14/2020
ms.topic: "reference"
ms.service: "dynamics-365-customerservice"
applies_to: 
  - "Dynamics 365 (online)"
---
# msdyn_ocprovisioningstate Entity Reference

[!INCLUDE[cc-use-with-omnichannel](../../../../includes/cc-use-with-omnichannel.md)]

Provisioning state

**Added by**: Omnichannel – Base Solution


## Messages

|Message|Web API Operation|SDK Assembly|
|-|-|-|
|Assign|PATCH [*org URI*]/api/data/v9.1/msdyn_ocprovisioningstates(*msdyn_ocprovisioningstateid*)<br />[Update](/powerapps/developer/common-data-service/webapi/update-delete-entities-using-web-api#basic-update) `ownerid` property.|<xref:Microsoft.Crm.Sdk.Messages.AssignRequest>|
|Create|POST [*org URI*]/api/data/v9.1/msdyn_ocprovisioningstates<br />See [Create](/powerapps/developer/common-data-service/webapi/create-entity-web-api)|<xref:Microsoft.Xrm.Sdk.Messages.CreateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Create*>|
|Delete|DELETE [*org URI*]/api/data/v9.1/msdyn_ocprovisioningstates(*msdyn_ocprovisioningstateid*)<br />See [Delete](/powerapps/developer/common-data-service/webapi/update-delete-entities-using-web-api#basic-delete)|<xref:Microsoft.Xrm.Sdk.Messages.DeleteRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Delete*>|
|GrantAccess|<xref href="Microsoft.Dynamics.CRM.GrantAccess?text=GrantAccess Action" />|<xref:Microsoft.Crm.Sdk.Messages.GrantAccessRequest>|
|IsValidStateTransition|<xref href="Microsoft.Dynamics.CRM.IsValidStateTransition?text=IsValidStateTransition Function" />|<xref:Microsoft.Crm.Sdk.Messages.IsValidStateTransitionRequest>|
|ModifyAccess|<xref href="Microsoft.Dynamics.CRM.ModifyAccess?text=ModifyAccess Action" />|<xref:Microsoft.Crm.Sdk.Messages.ModifyAccessRequest>|
|Retrieve|GET [*org URI*]/api/data/v9.1/msdyn_ocprovisioningstates(*msdyn_ocprovisioningstateid*)<br />See [Retrieve](/powerapps/developer/common-data-service/webapi/retrieve-entity-using-web-api)|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Retrieve*>|
|RetrieveMultiple|GET [*org URI*]/api/data/v9.1/msdyn_ocprovisioningstates<br />See [Query Data](/powerapps/developer/common-data-service/webapi/query-data-web-api)|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveMultipleRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.RetrieveMultiple*>|
|RetrievePrincipalAccess|<xref href="Microsoft.Dynamics.CRM.RetrievePrincipalAccess?text=RetrievePrincipalAccess Function" />|<xref:Microsoft.Crm.Sdk.Messages.RetrievePrincipalAccessRequest>|
|RetrieveSharedPrincipalsAndAccess|<xref href="Microsoft.Dynamics.CRM.RetrieveSharedPrincipalsAndAccess?text=RetrieveSharedPrincipalsAndAccess Function" />|<xref:Microsoft.Crm.Sdk.Messages.RetrieveSharedPrincipalsAndAccessRequest>|
|RevokeAccess|<xref href="Microsoft.Dynamics.CRM.RevokeAccess?text=RevokeAccess Action" />|<xref:Microsoft.Crm.Sdk.Messages.RevokeAccessRequest>|
|SetState|PATCH [*org URI*]/api/data/v9.1/msdyn_ocprovisioningstates(*msdyn_ocprovisioningstateid*)<br />[Update](/powerapps/developer/common-data-service/webapi/update-delete-entities-using-web-api#basic-update) `statecode` and `statuscode` properties.|<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|
|Update|PATCH [*org URI*]/api/data/v9.1/msdyn_ocprovisioningstates(*msdyn_ocprovisioningstateid*)<br />See [Update](/powerapps/developer/common-data-service/webapi/update-delete-entities-using-web-api#basic-update)|<xref:Microsoft.Xrm.Sdk.Messages.UpdateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Update*>|

## Entity Properties

|Property|Value|
|--------|-----|
|CollectionSchemaName|msdyn_ocprovisioningstates|
|DisplayCollectionName|Provisioning States|
|DisplayName|Provisioning State|
|EntitySetName|msdyn_ocprovisioningstates|
|IsBPFEntity|False|
|LogicalCollectionName|msdyn_ocprovisioningstates|
|LogicalName|msdyn_ocprovisioningstate|
|OwnershipType|UserOwned|
|PrimaryIdAttribute|msdyn_ocprovisioningstateid|
|PrimaryNameAttribute|msdyn_name|
|SchemaName|msdyn_ocprovisioningstate|

<a name="writable-attributes"></a>

## Writable attributes

These attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [msdyn_errormessage](#BKMK_msdyn_errormessage)
- [msdyn_exceptiondetails](#BKMK_msdyn_exceptiondetails)
- [msdyn_name](#BKMK_msdyn_name)
- [msdyn_ocfbapplicationid](#BKMK_msdyn_ocfbapplicationid)
- [msdyn_ocfbpageid](#BKMK_msdyn_ocfbpageid)
- [msdyn_oclinechannelconfigid](#BKMK_msdyn_oclinechannelconfigid)
- [msdyn_ocprovisioningstateId](#BKMK_msdyn_ocprovisioningstateId)
- [msdyn_octeamschannelconfigid](#BKMK_msdyn_octeamschannelconfigid)
- [msdyn_ocwhatsappchannelaccountId](#BKMK_msdyn_ocwhatsappchannelaccountId)
- [msdyn_provisioningresponse](#BKMK_msdyn_provisioningresponse)
- [OverriddenCreatedOn](#BKMK_OverriddenCreatedOn)
- [OwnerId](#BKMK_OwnerId)
- [OwnerIdType](#BKMK_OwnerIdType)
- [statecode](#BKMK_statecode)
- [statuscode](#BKMK_statuscode)
- [TimeZoneRuleVersionNumber](#BKMK_TimeZoneRuleVersionNumber)
- [UTCConversionTimeZoneCode](#BKMK_UTCConversionTimeZoneCode)


### <a name="BKMK_ImportSequenceNumber"></a> ImportSequenceNumber

|Property|Value|
|--------|-----|
|Description|Sequence number of the import that created this record.|
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


### <a name="BKMK_msdyn_errormessage"></a> msdyn_errormessage

**Added by**: Omnichannel - Base Patch Solution

|Property|Value|
|--------|-----|
|Description|Additional details|
|DisplayName|Additional details|
|Format|TextArea|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_errormessage|
|MaxLength|8192|
|RequiredLevel|None|
|Type|Memo|


### <a name="BKMK_msdyn_exceptiondetails"></a> msdyn_exceptiondetails

**Added by**: Omnichannel - Facebook Patch Solution

|Property|Value|
|--------|-----|
|Description|Exception Details during channel provisioning|
|DisplayName|Error Message (Deprecated)|
|Format|TextArea|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_exceptiondetails|
|MaxLength|8192|
|RequiredLevel|ApplicationRequired|
|Type|Memo|


### <a name="BKMK_msdyn_name"></a> msdyn_name

|Property|Value|
|--------|-----|
|Description|The name of the custom entity.|
|DisplayName|Name|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_name|
|MaxLength|100|
|RequiredLevel|ApplicationRequired|
|Type|String|


### <a name="BKMK_msdyn_ocfbapplicationid"></a> msdyn_ocfbapplicationid

**Added by**: Omnichannel – Facebook Solution

|Property|Value|
|--------|-----|
|Description|Related Facebook application|
|DisplayName|Facebook Application|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_ocfbapplicationid|
|RequiredLevel|None|
|Targets|msdyn_ocfbapplication|
|Type|Lookup|


### <a name="BKMK_msdyn_ocfbpageid"></a> msdyn_ocfbpageid

**Added by**: Omnichannel – Facebook Solution

|Property|Value|
|--------|-----|
|Description|Related Facebook page|
|DisplayName|Facebook Page|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_ocfbpageid|
|RequiredLevel|None|
|Targets|msdyn_ocfbpage|
|Type|Lookup|


### <a name="BKMK_msdyn_oclinechannelconfigid"></a> msdyn_oclinechannelconfigid

**Added by**: Omnichannel – SocialChannels Solution

|Property|Value|
|--------|-----|
|Description|Related Line Channel|
|DisplayName|Line Channel|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_oclinechannelconfigid|
|RequiredLevel|None|
|Targets|msdyn_oclinechannelconfig|
|Type|Lookup|


### <a name="BKMK_msdyn_ocprovisioningstateId"></a> msdyn_ocprovisioningstateId

|Property|Value|
|--------|-----|
|Description|Unique identifier for entity instances|
|DisplayName|Provisioning State|
|IsValidForForm|False|
|IsValidForRead|True|
|IsValidForUpdate|False|
|LogicalName|msdyn_ocprovisioningstateid|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|


### <a name="BKMK_msdyn_octeamschannelconfigid"></a> msdyn_octeamschannelconfigid

**Added by**: Omnichannel - Teams Solution

|Property|Value|
|--------|-----|
|Description|Related Teams Channel|
|DisplayName|Teams Channel|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_octeamschannelconfigid|
|RequiredLevel|None|
|Targets|msdyn_octeamschannelconfig|
|Type|Lookup|


### <a name="BKMK_msdyn_ocwhatsappchannelaccountId"></a> msdyn_ocwhatsappchannelaccountId

**Added by**: Omnichannel – SocialChannels Solution

|Property|Value|
|--------|-----|
|Description|Related WhatsApp Account|
|DisplayName|WhatsApp Account|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_ocwhatsappchannelaccountid|
|RequiredLevel|None|
|Targets|msdyn_ocwhatsappchannelaccount|
|Type|Lookup|


### <a name="BKMK_msdyn_provisioningresponse"></a> msdyn_provisioningresponse

|Property|Value|
|--------|-----|
|Description|Response for the provisioning action|
|DisplayName|msdyn_provisioningresponse|
|Format|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_provisioningresponse|
|MaxLength|2000|
|RequiredLevel|None|
|Type|Memo|


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


### <a name="BKMK_OwnerId"></a> OwnerId

**Added by**: Active Solution Solution

|Property|Value|
|--------|-----|
|Description|Owner Id|
|DisplayName|Owner|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|ownerid|
|RequiredLevel|SystemRequired|
|Targets|systemuser,team|
|Type|Owner|


### <a name="BKMK_OwnerIdType"></a> OwnerIdType

**Added by**: Active Solution Solution

|Property|Value|
|--------|-----|
|Description|Owner Id Type|
|DisplayName||
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|owneridtype|
|RequiredLevel|SystemRequired|
|Type|EntityName|


### <a name="BKMK_statecode"></a> statecode

|Property|Value|
|--------|-----|
|Description|Status of the Provisioning State|
|DisplayName|Status|
|IsValidForCreate|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|statecode|
|RequiredLevel|SystemRequired|
|Type|State|

#### statecode Options

|Value|Label|DefaultStatus|InvariantName|
|-----|-----|-------------|-------------|
|0|Active|192350001|Active|
|1|Inactive|192350003|Inactive|



### <a name="BKMK_statuscode"></a> statuscode

|Property|Value|
|--------|-----|
|Description|Reason for the status of the Provisioning State|
|DisplayName|Status Reason|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|statuscode|
|RequiredLevel|None|
|Type|Status|

#### statuscode Options

|Value|Label|State|
|-----|-----|-----|
|192350001|Draft|0|
|192350002|Processing|0|
|192350003|Running|0|
|192350004|Error|0|



### <a name="BKMK_TimeZoneRuleVersionNumber"></a> TimeZoneRuleVersionNumber

|Property|Value|
|--------|-----|
|Description|For internal use only.|
|DisplayName|Time Zone Rule Version Number|
|Format|None|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|timezoneruleversionnumber|
|MaxValue|2147483647|
|MinValue|-1|
|RequiredLevel|None|
|Type|Integer|


### <a name="BKMK_UTCConversionTimeZoneCode"></a> UTCConversionTimeZoneCode

|Property|Value|
|--------|-----|
|Description|Time zone code that was in use when the record was created.|
|DisplayName|UTC Conversion Time Zone Code|
|Format|None|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|utcconversiontimezonecode|
|MaxValue|2147483647|
|MinValue|-1|
|RequiredLevel|None|
|Type|Integer|

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
- [msdyn_ocfbapplicationidName](#BKMK_msdyn_ocfbapplicationidName)
- [msdyn_ocfbpageidName](#BKMK_msdyn_ocfbpageidName)
- [msdyn_oclinechannelconfigidName](#BKMK_msdyn_oclinechannelconfigidName)
- [msdyn_octeamschannelconfigidName](#BKMK_msdyn_octeamschannelconfigidName)
- [msdyn_ocwhatsappchannelaccountIdName](#BKMK_msdyn_ocwhatsappchannelaccountIdName)
- [OwnerIdName](#BKMK_OwnerIdName)
- [OwnerIdYomiName](#BKMK_OwnerIdYomiName)
- [OwningBusinessUnit](#BKMK_OwningBusinessUnit)
- [OwningTeam](#BKMK_OwningTeam)
- [OwningUser](#BKMK_OwningUser)
- [VersionNumber](#BKMK_VersionNumber)


### <a name="BKMK_CreatedBy"></a> CreatedBy

**Added by**: Active Solution Solution

|Property|Value|
|--------|-----|
|Description|Unique identifier of the user who created the record.|
|DisplayName|Created By|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|createdby|
|RequiredLevel|None|
|Targets|systemuser|
|Type|Lookup|


### <a name="BKMK_CreatedByName"></a> CreatedByName

**Added by**: Active Solution Solution

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

**Added by**: Active Solution Solution

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
|RequiredLevel|SystemRequired|
|Type|String|


### <a name="BKMK_CreatedOn"></a> CreatedOn

|Property|Value|
|--------|-----|
|DateTimeBehavior|UserLocal|
|Description|Date and time when the record was created.|
|DisplayName|Created On|
|Format|DateAndTime|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|createdon|
|RequiredLevel|None|
|Type|DateTime|


### <a name="BKMK_CreatedOnBehalfBy"></a> CreatedOnBehalfBy

**Added by**: Active Solution Solution

|Property|Value|
|--------|-----|
|Description|Unique identifier of the delegate user who created the record.|
|DisplayName|Created By (Delegate)|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|createdonbehalfby|
|RequiredLevel|None|
|Targets|systemuser|
|Type|Lookup|


### <a name="BKMK_CreatedOnBehalfByName"></a> CreatedOnBehalfByName

**Added by**: Active Solution Solution

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

**Added by**: Active Solution Solution

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
|RequiredLevel|SystemRequired|
|Type|String|


### <a name="BKMK_ModifiedBy"></a> ModifiedBy

**Added by**: Active Solution Solution

|Property|Value|
|--------|-----|
|Description|Unique identifier of the user who modified the record.|
|DisplayName|Modified By|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|modifiedby|
|RequiredLevel|None|
|Targets|systemuser|
|Type|Lookup|


### <a name="BKMK_ModifiedByName"></a> ModifiedByName

**Added by**: Active Solution Solution

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

**Added by**: Active Solution Solution

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
|RequiredLevel|SystemRequired|
|Type|String|


### <a name="BKMK_ModifiedOn"></a> ModifiedOn

|Property|Value|
|--------|-----|
|DateTimeBehavior|UserLocal|
|Description|Date and time when the record was modified.|
|DisplayName|Modified On|
|Format|DateAndTime|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|modifiedon|
|RequiredLevel|None|
|Type|DateTime|


### <a name="BKMK_ModifiedOnBehalfBy"></a> ModifiedOnBehalfBy

**Added by**: Active Solution Solution

|Property|Value|
|--------|-----|
|Description|Unique identifier of the delegate user who modified the record.|
|DisplayName|Modified By (Delegate)|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|modifiedonbehalfby|
|RequiredLevel|None|
|Targets|systemuser|
|Type|Lookup|


### <a name="BKMK_ModifiedOnBehalfByName"></a> ModifiedOnBehalfByName

**Added by**: Active Solution Solution

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

**Added by**: Active Solution Solution

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
|RequiredLevel|SystemRequired|
|Type|String|


### <a name="BKMK_msdyn_ocfbapplicationidName"></a> msdyn_ocfbapplicationidName

**Added by**: Omnichannel – Facebook Solution

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|msdyn_ocfbapplicationidname|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_msdyn_ocfbpageidName"></a> msdyn_ocfbpageidName

**Added by**: Omnichannel – Facebook Solution

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|msdyn_ocfbpageidname|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_msdyn_oclinechannelconfigidName"></a> msdyn_oclinechannelconfigidName

**Added by**: Omnichannel – SocialChannels Solution

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|msdyn_oclinechannelconfigidname|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_msdyn_octeamschannelconfigidName"></a> msdyn_octeamschannelconfigidName

**Added by**: Omnichannel - Teams Solution

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|msdyn_octeamschannelconfigidname|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_msdyn_ocwhatsappchannelaccountIdName"></a> msdyn_ocwhatsappchannelaccountIdName

**Added by**: Omnichannel – SocialChannels Solution

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|msdyn_ocwhatsappchannelaccountidname|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_OwnerIdName"></a> OwnerIdName

**Added by**: Active Solution Solution

|Property|Value|
|--------|-----|
|Description|Name of the owner|
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|owneridname|
|MaxLength|100|
|RequiredLevel|SystemRequired|
|Type|String|


### <a name="BKMK_OwnerIdYomiName"></a> OwnerIdYomiName

**Added by**: Active Solution Solution

|Property|Value|
|--------|-----|
|Description|Yomi name of the owner|
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|owneridyominame|
|MaxLength|100|
|RequiredLevel|SystemRequired|
|Type|String|


### <a name="BKMK_OwningBusinessUnit"></a> OwningBusinessUnit

**Added by**: Active Solution Solution

|Property|Value|
|--------|-----|
|Description|Unique identifier for the business unit that owns the record|
|DisplayName|Owning Business Unit|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|owningbusinessunit|
|RequiredLevel|None|
|Targets|businessunit|
|Type|Lookup|


### <a name="BKMK_OwningTeam"></a> OwningTeam

**Added by**: Active Solution Solution

|Property|Value|
|--------|-----|
|Description|Unique identifier for the team that owns the record.|
|DisplayName|Owning Team|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|owningteam|
|RequiredLevel|None|
|Targets|team|
|Type|Lookup|


### <a name="BKMK_OwningUser"></a> OwningUser

**Added by**: Active Solution Solution

|Property|Value|
|--------|-----|
|Description|Unique identifier for the user that owns the record.|
|DisplayName|Owning User|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|owninguser|
|RequiredLevel|None|
|Targets|systemuser|
|Type|Lookup|


### <a name="BKMK_VersionNumber"></a> VersionNumber

**Added by**: Active Solution Solution

|Property|Value|
|--------|-----|
|Description|Version Number|
|DisplayName|Version Number|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|versionnumber|
|MaxValue|9223372036854775807|
|MinValue|-9223372036854775808|
|RequiredLevel|None|
|Type|BigInt|

<a name="manytoone"></a>

## Many-To-One Relationships

Each Many-To-One relationship is defined by a corresponding One-To-Many relationship with the related entity. Listed by **SchemaName**.

- [msdyn_msdyn_ocfbpage_msdyn_ocprovisioningstate](#BKMK_msdyn_msdyn_ocfbpage_msdyn_ocprovisioningstate)
- [msdyn_oclinechannelconfig_msdyn_ocprovisioningstate_oclinechannelconfigid](#BKMK_msdyn_oclinechannelconfig_msdyn_ocprovisioningstate_oclinechannelconfigid)
- [msdyn_octeamschannelconfig_msdyn_ocprovisioningstate_octeamschannelconfigid](#BKMK_msdyn_octeamschannelconfig_msdyn_ocprovisioningstate_octeamschannelconfigid)
- [msdyn_ocwhatsappchannelaccount_msdyn_ocprovisioningstate_msdyn_ocwhatsappchannelaccountId](#BKMK_msdyn_ocwhatsappchannelaccount_msdyn_ocprovisioningstate_msdyn_ocwhatsappchannelaccountId)


### <a name="BKMK_msdyn_msdyn_ocfbpage_msdyn_ocprovisioningstate"></a> msdyn_msdyn_ocfbpage_msdyn_ocprovisioningstate

**Added by**: Omnichannel – Facebook Solution

See msdyn_ocfbpage Entity [msdyn_msdyn_ocfbpage_msdyn_ocprovisioningstate](msdyn_ocfbpage.md#BKMK_msdyn_msdyn_ocfbpage_msdyn_ocprovisioningstate) One-To-Many relationship.

### <a name="BKMK_msdyn_oclinechannelconfig_msdyn_ocprovisioningstate_oclinechannelconfigid"></a> msdyn_oclinechannelconfig_msdyn_ocprovisioningstate_oclinechannelconfigid

**Added by**: Omnichannel – SocialChannels Solution

See msdyn_oclinechannelconfig Entity [msdyn_oclinechannelconfig_msdyn_ocprovisioningstate_oclinechannelconfigid](msdyn_oclinechannelconfig.md#BKMK_msdyn_oclinechannelconfig_msdyn_ocprovisioningstate_oclinechannelconfigid) One-To-Many relationship.

### <a name="BKMK_msdyn_octeamschannelconfig_msdyn_ocprovisioningstate_octeamschannelconfigid"></a> msdyn_octeamschannelconfig_msdyn_ocprovisioningstate_octeamschannelconfigid

**Added by**: Omnichannel - Teams Solution

See msdyn_octeamschannelconfig Entity [msdyn_octeamschannelconfig_msdyn_ocprovisioningstate_octeamschannelconfigid](msdyn_octeamschannelconfig.md#BKMK_msdyn_octeamschannelconfig_msdyn_ocprovisioningstate_octeamschannelconfigid) One-To-Many relationship.

### <a name="BKMK_msdyn_ocwhatsappchannelaccount_msdyn_ocprovisioningstate_msdyn_ocwhatsappchannelaccountId"></a> msdyn_ocwhatsappchannelaccount_msdyn_ocprovisioningstate_msdyn_ocwhatsappchannelaccountId

**Added by**: Omnichannel – SocialChannels Solution

See msdyn_ocwhatsappchannelaccount Entity [msdyn_ocwhatsappchannelaccount_msdyn_ocprovisioningstate_msdyn_ocwhatsappchannelaccountId](msdyn_ocwhatsappchannelaccount.md#BKMK_msdyn_ocwhatsappchannelaccount_msdyn_ocprovisioningstate_msdyn_ocwhatsappchannelaccountId) One-To-Many relationship.

### See also

[Introduction to Omnichannel for Customer Service](../../../introduction-omnichannel.md)<br />
[Developer guide for Omnichannel for Customer Service](../../omnichannel-developer.md)
