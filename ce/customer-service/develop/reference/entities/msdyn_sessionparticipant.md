---
title: msdyn_sessionparticipant Entity Reference 
description: Includes schema information and supported messages for the msdyn_sessionparticipant entity.
ms.date: 06/12/2024
author: gandhamm
ms.author: mgandham
ms.reviewer: mgandham
ms.topic: reference
---
# msdyn_sessionparticipant Entity Reference

[!INCLUDE[cc-use-with-omnichannel](../../../../includes/cc-use-with-omnichannel.md)]

Users in a session interacting with the customer

**Added by**: Omnichannel – Base Solution

## Messages

|Message|Web API Operation|SDK Assembly|
|-|-|-|
|Assign|PATCH [*org URI*]/api/data/v9.0/msdyn_sessionparticipants(*msdyn_sessionparticipantid*)<br />[Update](/powerapps/developer/common-data-service/webapi/update-delete-entities-using-web-api#basic-update) `ownerid` property.|<xref:Microsoft.Crm.Sdk.Messages.AssignRequest>|
|BulkRetain|<xref href="Microsoft.Dynamics.CRM.BulkRetain?text=BulkRetain Action" />| Microsoft.Crm.Sdk.Messages.BulkRetainRequest |
|Create|POST [*org URI*]/api/data/v9.0/msdyn_sessionparticipants<br />See [Create](/powerapps/developer/common-data-service/webapi/create-entity-web-api)|<xref:Microsoft.Xrm.Sdk.Messages.CreateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Create*>|
|CreateMultiple|<xref href="Microsoft.Dynamics.CRM.CreateMultiple?text=CreateMultiple Action" />|<xref:Microsoft.Xrm.Sdk.Messages.CreateMultipleRequest>|
|Delete|DELETE [*org URI*]/api/data/v9.0/msdyn_sessionparticipants(*msdyn_sessionparticipantid*)<br />See [Delete](/powerapps/developer/common-data-service/webapi/update-delete-entities-using-web-api#basic-delete)|<xref:Microsoft.Xrm.Sdk.Messages.DeleteRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Delete*>|
|GrantAccess|<xref href="Microsoft.Dynamics.CRM.GrantAccess?text=GrantAccess Action" />|<xref:Microsoft.Crm.Sdk.Messages.GrantAccessRequest>|
|IsValidStateTransition|<xref href="Microsoft.Dynamics.CRM.IsValidStateTransition?text=IsValidStateTransition Function" />|<xref:Microsoft.Crm.Sdk.Messages.IsValidStateTransitionRequest>|
|ModifyAccess|<xref href="Microsoft.Dynamics.CRM.ModifyAccess?text=ModifyAccess Action" />|<xref:Microsoft.Crm.Sdk.Messages.ModifyAccessRequest>|
|PurgeRetainedContent|<xref href="Microsoft.Dynamics.CRM.PurgeRetainedContent?text=PurgeRetainedContent Action" />|Microsoft.Crm.Sdk.Messages.PurgeRetainedContentRequest|
|Restore|<xref href="Microsoft.Dynamics.CRM.Restore?text=Restore Action" />|Microsoft.Crm.Sdk.Messages.RestoreRequest|
|Retain|<xref href="Microsoft.Dynamics.CRM.Retain?text=Retain Action" />|Microsoft.Crm.Sdk.Messages.RetainRequest|
|Retrieve|GET [*org URI*]/api/data/v9.0/msdyn_sessionparticipants(*msdyn_sessionparticipantid*)<br />See [Retrieve](/powerapps/developer/common-data-service/webapi/retrieve-entity-using-web-api)|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Retrieve*>|
|RetrieveMultiple|GET [*org URI*]/api/data/v9.0/msdyn_sessionparticipants<br />See [Query Data](/powerapps/developer/common-data-service/webapi/query-data-web-api)|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveMultipleRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.RetrieveMultiple*>|
|RetrievePrincipalAccess|<xref href="Microsoft.Dynamics.CRM.RetrievePrincipalAccess?text=RetrievePrincipalAccess Function" />|<xref:Microsoft.Crm.Sdk.Messages.RetrievePrincipalAccessRequest>|
|RetrieveSharedPrincipalsAndAccess|<xref href="Microsoft.Dynamics.CRM.RetrieveSharedPrincipalsAndAccess?text=RetrieveSharedPrincipalsAndAccess Function" />|<xref:Microsoft.Crm.Sdk.Messages.RetrieveSharedPrincipalsAndAccessRequest>|
|RevokeAccess|<xref href="Microsoft.Dynamics.CRM.RevokeAccess?text=RevokeAccess Action" />|<xref:Microsoft.Crm.Sdk.Messages.RevokeAccessRequest>|
|RollbackRetain|<xref href="Microsoft.Dynamics.CRM.RollbackRetain?text=RollbackRetain Action" />|Microsoft.Crm.Sdk.Messages.RollbackRetainRequest|
|SetState|PATCH [*org URI*]/api/data/v9.0/msdyn_sessionparticipants(*msdyn_sessionparticipantid*)<br />[Update](/powerapps/developer/common-data-service/webapi/update-delete-entities-using-web-api#basic-update) `statecode` and `statuscode` properties.|<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|
|Update|PATCH [*org URI*]/api/data/v9.0/msdyn_sessionparticipants(*msdyn_sessionparticipantid*)<br />See [Update](/powerapps/developer/common-data-service/webapi/update-delete-entities-using-web-api#basic-update)|<xref:Microsoft.Xrm.Sdk.Messages.UpdateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Update*>|
|UpdateMultiple|<xref href="Microsoft.Dynamics.CRM.UpdateMultiple?text=UpdateMultiple Action" />|<xref:Microsoft.Xrm.Sdk.Messages.UpdateMultipleRequest>|
|ValidateRetentionConfig|<xref href="Microsoft.Dynamics.CRM.ValidateRetentionConfig?text=ValidateRetentionConfig Action" />|Microsoft.Crm.Sdk.Messages.ValidateRetentionConfigRequest|

## Properties

|Property|Value|
|--------|-----|
|CollectionSchemaName|msdyn_sessionparticipants|
|DisplayCollectionName|Session participants|
|DisplayName|Session participant|
|EntitySetName|msdyn_sessionparticipants|
|IsBPFEntity|False|
|LogicalCollectionName|msdyn_sessionparticipants|
|LogicalName|msdyn_sessionparticipant|
|OwnershipType|UserOwned|
|PrimaryIdAttribute|msdyn_sessionparticipantid|
|PrimaryNameAttribute|msdyn_name|
|SchemaName|msdyn_sessionparticipant|

<a name="writable-attributes"></a>

## Writable columns/attributes

These columns/attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [msdyn_activedirectoryuserid](#BKMK_msdyn_activedirectoryuserid)
- [msdyn_activetime](#BKMK_msdyn_activetime)
- [msdyn_addedon](#BKMK_msdyn_addedon)
- [msdyn_agentid](#BKMK_msdyn_agentid)
- [msdyn_assignreason](#BKMK_msdyn_assignreason)
- [msdyn_externalparticipantchannel](#BKMK_msdyn_externalparticipantchannel)
- [msdyn_externalparticipantchanneltype](#BKMK_msdyn_externalparticipantchanneltype)
- [msdyn_idletime](#BKMK_msdyn_idletime)
- [msdyn_inactivetime](#BKMK_msdyn_inactivetime)
- [msdyn_joinedon](#BKMK_msdyn_joinedon)
- [msdyn_lastupdatedon](#BKMK_msdyn_lastupdatedon)
- [msdyn_lefton](#BKMK_msdyn_lefton)
- [msdyn_leftonreason](#BKMK_msdyn_leftonreason)
- [msdyn_mode](#BKMK_msdyn_mode)
- [msdyn_modifiedon](#BKMK_msdyn_modifiedon)
- [msdyn_name](#BKMK_msdyn_name)
- [msdyn_omnichannelsession](#BKMK_msdyn_omnichannelsession)
- [msdyn_sessionparticipantId](#BKMK_msdyn_sessionparticipantId)
- [msdyn_startactivetime](#BKMK_msdyn_startactivetime)
- [msdyn_startidletime](#BKMK_msdyn_startidletime)
- [msdyn_startinactivetime](#BKMK_msdyn_startinactivetime)
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


### <a name="BKMK_msdyn_activedirectoryuserid"></a> msdyn_activedirectoryuserid

|Property|Value|
|--------|-----|
|Description|Unique identifier of Active Directory User participating in session.|
|DisplayName|Active Directory User Id|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_activedirectoryuserid|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_msdyn_activetime"></a> msdyn_activetime

|Property|Value|
|--------|-----|
|Description|Active time for agent on the session|
|DisplayName|Active time|
|Format|None|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_activetime|
|MaxValue|2147483647|
|MinValue|0|
|RequiredLevel|None|
|Type|Integer|


### <a name="BKMK_msdyn_addedon"></a> msdyn_addedon

|Property|Value|
|--------|-----|
|DateTimeBehavior|UserLocal|
|Description|Date and time when agent assigned to the session.|
|DisplayName|Added On|
|Format|DateOnly|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_addedon|
|RequiredLevel|None|
|Type|DateTime|


### <a name="BKMK_msdyn_agentid"></a> msdyn_agentid

|Property|Value|
|--------|-----|
|Description|Unique identifier of System User participating in session.|
|DisplayName|Agent|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_agentid|
|RequiredLevel|None|
|Targets|systemuser|
|Type|Lookup|


### <a name="BKMK_msdyn_assignreason"></a> msdyn_assignreason

**Added by**: Omnichannel Conversation Extension Solution

|Property|Value|
|--------|-----|
|Description|The agent assignment reason (This is for internal use only. Customers are advised to not use this property). Possible values include:<br><ul><li>AgentConsult</li><li>AgentConversationRejoin</li><li>AgentConversationRejoin</li><li>AgentTransfer</li><li>ExternalWarmTransfer</li><li>ExternalBlindTransfer</li><li>ExternalColdTransfer</li><li>CustomerReconnect</li><li>AgentConversationJoin</li><li>AgentMonitor</li><li>AgentPick</li><li>SupervisorAssign</li><li>SupervisorTransferToAgent</li></ul>|
|DisplayName|Assign Reason|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_assignreason|
|MaxLength|100|
|RequiredLevel|ApplicationRequired|
|Type|String|


### <a name="BKMK_msdyn_externalparticipantchannel"></a> msdyn_externalparticipantchannel

|Property|Value|
|--------|-----|
|Description||
|DisplayName|External channel of participant|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_externalparticipantchannel|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_msdyn_externalparticipantchanneltype"></a> msdyn_externalparticipantchanneltype

|Property|Value|
|--------|-----|
|Description|Channel type of external participant|
|DisplayName|Channel type of external participant|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_externalparticipantchanneltype|
|RequiredLevel|None|
|Type|Picklist|

#### msdyn_externalparticipantchanneltype Choices/Options

|Value|Label|
|-----|-----|
|426120000|Phone Number|



### <a name="BKMK_msdyn_idletime"></a> msdyn_idletime

|Property|Value|
|--------|-----|
|Description|Idle time for agent on the session|
|DisplayName|Idle time|
|Format|None|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_idletime|
|MaxValue|2147483647|
|MinValue|0|
|RequiredLevel|None|
|Type|Integer|


### <a name="BKMK_msdyn_inactivetime"></a> msdyn_inactivetime

|Property|Value|
|--------|-----|
|Description|Inactive time for agent on the session|
|DisplayName|Inactive time|
|Format|None|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_inactivetime|
|MaxValue|2147483647|
|MinValue|0|
|RequiredLevel|None|
|Type|Integer|


### <a name="BKMK_msdyn_joinedon"></a> msdyn_joinedon

|Property|Value|
|--------|-----|
|DateTimeBehavior|UserLocal|
|Description|Date and time when agent accepted the session.|
|DisplayName|Joined On|
|Format|DateAndTime|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_joinedon|
|RequiredLevel|None|
|Type|DateTime|


### <a name="BKMK_msdyn_lastupdatedon"></a> msdyn_lastupdatedon

**Added by**: Omnichannel Conversation Extension Solution

|Property|Value|
|--------|-----|
|DateTimeBehavior|UserLocal|
|Description|Last Updated On timestamp for the record|
|DisplayName|Last Updated On|
|Format|DateAndTime|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_lastupdatedon|
|RequiredLevel|None|
|Type|DateTime|


### <a name="BKMK_msdyn_lefton"></a> msdyn_lefton

|Property|Value|
|--------|-----|
|DateTimeBehavior|UserLocal|
|Description|Date and time when agent left the session.|
|DisplayName|Left On|
|Format|DateAndTime|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_lefton|
|RequiredLevel|None|
|Type|DateTime|


### <a name="BKMK_msdyn_leftonreason"></a> msdyn_leftonreason

**Added by**: Omnichannel Conversation Extension Solution

|Property|Value|
|--------|-----|
|Description|The agent left on reason (This is for internal use only. Customers are advised to not use this property). Possible value is AgentReject or AgentTimeout|
|DisplayName|LeftOn Reason|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_leftonreason|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_msdyn_mode"></a> msdyn_mode

|Property|Value|
|--------|-----|
|Description|Mode of Agent participation i.e. primary, consult, monitor, preview etc.|
|DisplayName|Mode|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_mode|
|RequiredLevel|None|
|Type|Picklist|

#### msdyn_mode Choices/Options

|Value|Label|
|-----|-----|
|192350002|Primary|
|192350003|Consult|
|192350004|Monitor|
|192350005|Preview|



### <a name="BKMK_msdyn_modifiedon"></a> msdyn_modifiedon

|Property|Value|
|--------|-----|
|DateTimeBehavior|UserLocal|
|Description|Date and time when session participant information was last modified.|
|DisplayName|Session Participant Modified On|
|Format|DateOnly|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_modifiedon|
|RequiredLevel|None|
|Type|DateTime|


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
|MaxLength|200|
|RequiredLevel|ApplicationRequired|
|Type|String|


### <a name="BKMK_msdyn_omnichannelsession"></a> msdyn_omnichannelsession

|Property|Value|
|--------|-----|
|Description|Unique identifier of the session associated to the participant.|
|DisplayName|Omni Channel Session|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_omnichannelsession|
|RequiredLevel|None|
|Targets|msdyn_ocsession|
|Type|Lookup|


### <a name="BKMK_msdyn_sessionparticipantId"></a> msdyn_sessionparticipantId

|Property|Value|
|--------|-----|
|Description|Unique identifier for entity instances|
|DisplayName|Session participant|
|IsValidForForm|False|
|IsValidForRead|True|
|IsValidForUpdate|False|
|LogicalName|msdyn_sessionparticipantid|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|


### <a name="BKMK_msdyn_startactivetime"></a> msdyn_startactivetime

|Property|Value|
|--------|-----|
|DateTimeBehavior|UserLocal|
|Description|Start active time for agent on the session|
|DisplayName|Start active time|
|Format|DateAndTime|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_startactivetime|
|RequiredLevel|None|
|Type|DateTime|


### <a name="BKMK_msdyn_startidletime"></a> msdyn_startidletime

|Property|Value|
|--------|-----|
|DateTimeBehavior|UserLocal|
|Description|Start idle time for agent on the session|
|DisplayName|Start idle time|
|Format|DateAndTime|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_startidletime|
|RequiredLevel|None|
|Type|DateTime|


### <a name="BKMK_msdyn_startinactivetime"></a> msdyn_startinactivetime

|Property|Value|
|--------|-----|
|DateTimeBehavior|UserLocal|
|Description|Start inactive time for agent on the session|
|DisplayName|Start inactive time|
|Format|DateAndTime|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_startinactivetime|
|RequiredLevel|None|
|Type|DateTime|


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
|Description|Status of the Session participant|
|DisplayName|Status|
|IsValidForCreate|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|statecode|
|RequiredLevel|SystemRequired|
|Type|State|

#### statecode Choices/Options

|Value|Label|DefaultStatus|InvariantName|
|-----|-----|-------------|-------------|
|0|Active|1|Active|
|1|Inactive|2|Inactive|



### <a name="BKMK_statuscode"></a> statuscode

|Property|Value|
|--------|-----|
|Description|Reason for the status of the Session participant|
|DisplayName|Status Reason|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|statuscode|
|RequiredLevel|None|
|Type|Status|

#### statuscode Choices/Options

|Value|Label|State|
|-----|-----|-----|
|1|Active|0|
|2|Inactive|1|



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

## Read-only columns/attributes

These columns/attributes return false for both **IsValidForCreate** or **IsValidForUpdate**. Listed by **SchemaName**.

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
- [msdyn_agentidName](#BKMK_msdyn_agentidName)
- [msdyn_agentidYomiName](#BKMK_msdyn_agentidYomiName)
- [msdyn_omnichannelsessionName](#BKMK_msdyn_omnichannelsessionName)
- [OwnerIdName](#BKMK_OwnerIdName)
- [OwnerIdYomiName](#BKMK_OwnerIdYomiName)
- [OwningBusinessUnit](#BKMK_OwningBusinessUnit)
- [OwningBusinessUnitName](#BKMK_OwningBusinessUnitName)
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


### <a name="BKMK_msdyn_agentidName"></a> msdyn_agentidName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|msdyn_agentidname|
|MaxLength|200|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_msdyn_agentidYomiName"></a> msdyn_agentidYomiName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|msdyn_agentidyominame|
|MaxLength|200|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_msdyn_omnichannelsessionName"></a> msdyn_omnichannelsessionName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|msdyn_omnichannelsessionname|
|MaxLength|200|
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
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|owningbusinessunit|
|RequiredLevel|None|
|Targets|businessunit|
|Type|Lookup|


### <a name="BKMK_OwningBusinessUnitName"></a> OwningBusinessUnitName

**Added by**: Active Solution Solution

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|owningbusinessunitname|
|MaxLength|100|
|RequiredLevel|SystemRequired|
|Type|String|


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

### Related information

[Introduction to Omnichannel for Customer Service](../../../implement/introduction-omnichannel.md)<br />
[Developer guide for Omnichannel for Customer Service](../../omnichannel-developer.md)


[!INCLUDE[footer-include](../../../../includes/footer-banner.md)]
