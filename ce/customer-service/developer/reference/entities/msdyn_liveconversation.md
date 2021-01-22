---
title: "msdyn_liveconversation Entity Reference | MicrosoftDocs"
description: "Includes schema information and supported messages for the msdyn_liveconversation entity."
author: "v-sailab"
ms.author: "v-sailab"
manager: "shujoshi"
ms.date: 07/29/2020
---
# msdyn_liveconversation Entity Reference


[!INCLUDE[cc-use-with-omnichannel](../../../../includes/cc-use-with-omnichannel.md)]

Tracks the interactions between the agents and customer

**Added by**: Omnichannel – Base Solution


## Messages

|Message|Web API Operation|SDK Assembly|
|-|-|-|
|Assign|PATCH [*org URI*]/api/data/v9.1/msdyn_liveconversations(*msdyn_liveconversationid*)<br />[Update](/powerapps/developer/common-data-service/webapi/update-delete-entities-using-web-api#basic-update) `ownerid` property.|<xref:Microsoft.Crm.Sdk.Messages.AssignRequest>|
|Create|POST [*org URI*]/api/data/v9.1/msdyn_liveconversations<br />See [Create](/powerapps/developer/common-data-service/webapi/create-entity-web-api)|<xref:Microsoft.Xrm.Sdk.Messages.CreateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Create*>|
|Delete|DELETE [*org URI*]/api/data/v9.1/msdyn_liveconversations(*msdyn_liveconversationid*)<br />See [Delete](/powerapps/developer/common-data-service/webapi/update-delete-entities-using-web-api#basic-delete)|<xref:Microsoft.Xrm.Sdk.Messages.DeleteRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Delete*>|
|GrantAccess|<xref href="Microsoft.Dynamics.CRM.GrantAccess?text=GrantAccess Action" />|<xref:Microsoft.Crm.Sdk.Messages.GrantAccessRequest>|
|IsValidStateTransition|<xref href="Microsoft.Dynamics.CRM.IsValidStateTransition?text=IsValidStateTransition Function" />|<xref:Microsoft.Crm.Sdk.Messages.IsValidStateTransitionRequest>|
|ModifyAccess|<xref href="Microsoft.Dynamics.CRM.ModifyAccess?text=ModifyAccess Action" />|<xref:Microsoft.Crm.Sdk.Messages.ModifyAccessRequest>|
|Retrieve|GET [*org URI*]/api/data/v9.1/msdyn_liveconversations(*msdyn_liveconversationid*)<br />See [Retrieve](/powerapps/developer/common-data-service/webapi/retrieve-entity-using-web-api)|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Retrieve*>|
|RetrieveMultiple|GET [*org URI*]/api/data/v9.1/msdyn_liveconversations<br />See [Query Data](/powerapps/developer/common-data-service/webapi/query-data-web-api)|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveMultipleRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.RetrieveMultiple*>|
|RetrievePrincipalAccess|<xref href="Microsoft.Dynamics.CRM.RetrievePrincipalAccess?text=RetrievePrincipalAccess Function" />|<xref:Microsoft.Crm.Sdk.Messages.RetrievePrincipalAccessRequest>|
|RetrieveSharedPrincipalsAndAccess|<xref href="Microsoft.Dynamics.CRM.RetrieveSharedPrincipalsAndAccess?text=RetrieveSharedPrincipalsAndAccess Function" />|<xref:Microsoft.Crm.Sdk.Messages.RetrieveSharedPrincipalsAndAccessRequest>|
|RevokeAccess|<xref href="Microsoft.Dynamics.CRM.RevokeAccess?text=RevokeAccess Action" />|<xref:Microsoft.Crm.Sdk.Messages.RevokeAccessRequest>|
|SetState|PATCH [*org URI*]/api/data/v9.1/msdyn_liveconversations(*msdyn_liveconversationid*)<br />[Update](/powerapps/developer/common-data-service/webapi/update-delete-entities-using-web-api#basic-update) `statecode` and `statuscode` properties.|<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|
|Update|PATCH [*org URI*]/api/data/v9.1/msdyn_liveconversations(*msdyn_liveconversationid*)<br />See [Update](/powerapps/developer/common-data-service/webapi/update-delete-entities-using-web-api#basic-update)|<xref:Microsoft.Xrm.Sdk.Messages.UpdateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Update*>|

## Entity Properties

|Property|Value|
|--------|-----|
|CollectionSchemaName|msdyn_liveconversations|
|DisplayCollectionName|Ongoing conversations|
|DisplayName|Ongoing conversation|
|EntitySetName|msdyn_liveconversations|
|IsBPFEntity|False|
|LogicalCollectionName|msdyn_liveconversations|
|LogicalName|msdyn_liveconversation|
|OwnershipType|UserOwned|
|PrimaryIdAttribute|msdyn_liveconversationid|
|PrimaryNameAttribute|msdyn_subject|
|SchemaName|msdyn_liveconversation|

<a name="writable-attributes"></a>

## Writable attributes

These attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [msdyn_activeagentassignedon](#BKMK_msdyn_activeagentassignedon)
- [msdyn_activeagentid](#BKMK_msdyn_activeagentid)
- [msdyn_cdsqueueid](#BKMK_msdyn_cdsqueueid)
- [msdyn_channel](#BKMK_msdyn_channel)
- [msdyn_closedon](#BKMK_msdyn_closedon)
- [msdyn_createdon](#BKMK_msdyn_createdon)
- [msdyn_customer](#BKMK_msdyn_customer)
- [msdyn_customerIdType](#BKMK_msdyn_customerIdType)
- [msdyn_customersentimentlabel](#BKMK_msdyn_customersentimentlabel)
- [msdyn_escalationcount](#BKMK_msdyn_escalationcount)
- [msdyn_initiatedon](#BKMK_msdyn_initiatedon)
- [msdyn_liveconversationId](#BKMK_msdyn_liveconversationId)
- [msdyn_liveworkstreamid](#BKMK_msdyn_liveworkstreamid)
- [msdyn_modifiedon](#BKMK_msdyn_modifiedon)
- [msdyn_oclastsessionid](#BKMK_msdyn_oclastsessionid)
- [msdyn_queueid](#BKMK_msdyn_queueid)
- [msdyn_startedon](#BKMK_msdyn_startedon)
- [msdyn_statecode](#BKMK_msdyn_statecode)
- [msdyn_statuscode](#BKMK_msdyn_statuscode)
- [msdyn_statusupdatedon](#BKMK_msdyn_statusupdatedon)
- [msdyn_subject](#BKMK_msdyn_subject)
- [msdyn_title](#BKMK_msdyn_title)
- [msdyn_transfercount](#BKMK_msdyn_transfercount)
- [msdyn_workstreamworkdistributionmode](#BKMK_msdyn_workstreamworkdistributionmode)
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


### <a name="BKMK_msdyn_activeagentassignedon"></a> msdyn_activeagentassignedon

|Property|Value|
|--------|-----|
|DateTimeBehavior|UserLocal|
|Description|Date and time when last agent was assigned to the conversation|
|DisplayName|Active Agent Assigned On|
|Format|DateAndTime|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_activeagentassignedon|
|RequiredLevel|None|
|Type|DateTime|


### <a name="BKMK_msdyn_activeagentid"></a> msdyn_activeagentid

|Property|Value|
|--------|-----|
|Description|Last agent assigned to the conversation|
|DisplayName|Active Agent|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_activeagentid|
|RequiredLevel|None|
|Targets|systemuser|
|Type|Lookup|


### <a name="BKMK_msdyn_cdsqueueid"></a> msdyn_cdsqueueid

|Property|Value|
|--------|-----|
|Description|Unique identifier for Queue associated with Conversation.|
|DisplayName|Queue|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_cdsqueueid|
|RequiredLevel|None|
|Targets|queue|
|Type|Lookup|


### <a name="BKMK_msdyn_channel"></a> msdyn_channel

**Added by**: Omnichannel - Base Patch Solution

|Property|Value|
|--------|-----|
|Description|The channel(s) in the conversation.|
|DisplayName|Channel|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_channel|
|RequiredLevel|None|
|Type|MultiSelectPicklist|

#### msdyn_channel Options

|Value|Label|
|-----|-----|
|19241000|Microsoft Teams|
|192300000|WhatsApp|
|192310000|LINE|
|192320000|WeChat|
|192330000|Facebook|
|192340000|SMS|
|192350000|Entity Records|
|192350001|Twitter|
|192350002|Custom|
|192360000|Live chat|
|192370000|Voice|
|192380000|Video|
|192390000|Co-browse|
|192400000|Screen sharing|



### <a name="BKMK_msdyn_closedon"></a> msdyn_closedon

|Property|Value|
|--------|-----|
|DateTimeBehavior|UserLocal|
|Description|Date and time when conversation was closed|
|DisplayName|Closed On|
|Format|DateAndTime|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_closedon|
|RequiredLevel|None|
|Type|DateTime|


### <a name="BKMK_msdyn_createdon"></a> msdyn_createdon

|Property|Value|
|--------|-----|
|DateTimeBehavior|UserLocal|
|Description|Date and time when conversation was created|
|DisplayName|Created On|
|Format|DateAndTime|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_createdon|
|RequiredLevel|None|
|Type|DateTime|


### <a name="BKMK_msdyn_customer"></a> msdyn_customer

|Property|Value|
|--------|-----|
|Description|Customer associated to the conversation|
|DisplayName|Customer|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_customer|
|RequiredLevel|None|
|Targets|account,contact|
|Type|Customer|


### <a name="BKMK_msdyn_customerIdType"></a> msdyn_customerIdType

**Added by**: Active Solution Solution

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|msdyn_customeridtype|
|RequiredLevel|None|
|Type|EntityName|


### <a name="BKMK_msdyn_customersentimentlabel"></a> msdyn_customersentimentlabel

|Property|Value|
|--------|-----|
|Description|Customer Sentiment Label powered by Sentiment Service|
|DisplayName|Customer Sentiment|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_customersentimentlabel|
|RequiredLevel|None|
|Type|Picklist|

#### msdyn_customersentimentlabel Options

|Value|Label|
|-----|-----|
|0|N/A|
|7|Very negative|
|8|Negative|
|9|Slightly negative|
|10|Neutral|
|11|Slightly positive|
|12|Positive|
|13|Very positive|



### <a name="BKMK_msdyn_escalationcount"></a> msdyn_escalationcount

|Property|Value|
|--------|-----|
|Description|Number of times conversation was escalated to Supervisor i.e. transferred to Supervisor|
|DisplayName|Escalation Count|
|Format|None|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_escalationcount|
|MaxValue|2147483647|
|MinValue|0|
|RequiredLevel|None|
|Type|Integer|


### <a name="BKMK_msdyn_initiatedon"></a> msdyn_initiatedon

|Property|Value|
|--------|-----|
|DateTimeBehavior|UserLocal|
|Description|Time when conversation was initiated|
|DisplayName|Initiated On|
|Format|DateAndTime|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_initiatedon|
|RequiredLevel|None|
|Type|DateTime|


### <a name="BKMK_msdyn_liveconversationId"></a> msdyn_liveconversationId

|Property|Value|
|--------|-----|
|Description|Id of this ongoing conversation record|
|DisplayName|OngoingConversationId|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|msdyn_liveconversationid|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|


### <a name="BKMK_msdyn_liveworkstreamid"></a> msdyn_liveworkstreamid

|Property|Value|
|--------|-----|
|Description|Work stream associated to the conversation|
|DisplayName|Work stream|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_liveworkstreamid|
|RequiredLevel|None|
|Targets|msdyn_liveworkstream|
|Type|Lookup|


### <a name="BKMK_msdyn_modifiedon"></a> msdyn_modifiedon

|Property|Value|
|--------|-----|
|DateTimeBehavior|UserLocal|
|Description|Date and time when conversation was last modified|
|DisplayName|Modified On|
|Format|DateAndTime|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_modifiedon|
|RequiredLevel|None|
|Type|DateTime|


### <a name="BKMK_msdyn_oclastsessionid"></a> msdyn_oclastsessionid

|Property|Value|
|--------|-----|
|Description|Last agent session|
|DisplayName|Last session Id|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_oclastsessionid|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_msdyn_queueid"></a> msdyn_queueid

|Property|Value|
|--------|-----|
|Description|Unique identifier for msdyn_omnichannelqueue associated with Conversation|
|DisplayName|Queue|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_queueid|
|RequiredLevel|None|
|Targets|msdyn_omnichannelqueue|
|Type|Lookup|


### <a name="BKMK_msdyn_startedon"></a> msdyn_startedon

|Property|Value|
|--------|-----|
|DateTimeBehavior|UserLocal|
|Description|Date and time when conversation was started|
|DisplayName|Started On|
|Format|DateAndTime|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_startedon|
|RequiredLevel|None|
|Type|DateTime|


### <a name="BKMK_msdyn_statecode"></a> msdyn_statecode

|Property|Value|
|--------|-----|
|Description|State of the conversation record|
|DisplayName|State|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_statecode|
|RequiredLevel|None|
|Type|Picklist|

#### msdyn_statecode Options

|Value|Label|
|-----|-----|
|0|Open|
|1|Active|
|2|Waiting|
|3|Closed|
|4|Wrap-up|



### <a name="BKMK_msdyn_statuscode"></a> msdyn_statuscode

|Property|Value|
|--------|-----|
|Description|Reason for the status of Ongoing conversation record|
|DisplayName|Status Reason|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_statuscode|
|RequiredLevel|None|
|Type|Picklist|

#### msdyn_statuscode Options

|Value|Label|
|-----|-----|
|1|Open|
|2|Active|
|3|Waiting|
|4|Closed|
|5|Wrap-up|



### <a name="BKMK_msdyn_statusupdatedon"></a> msdyn_statusupdatedon

|Property|Value|
|--------|-----|
|DateTimeBehavior|UserLocal|
|Description|Date and time when conversation status was last modified|
|DisplayName|Status Updated On|
|Format|DateAndTime|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_statusupdatedon|
|RequiredLevel|None|
|Type|DateTime|


### <a name="BKMK_msdyn_subject"></a> msdyn_subject

|Property|Value|
|--------|-----|
|Description|Subject associated with the conversation record|
|DisplayName|Subject|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_subject|
|MaxLength|200|
|RequiredLevel|ApplicationRequired|
|Type|String|


### <a name="BKMK_msdyn_title"></a> msdyn_title

|Property|Value|
|--------|-----|
|Description|Conversation Title|
|DisplayName|Title|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_title|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_msdyn_transfercount"></a> msdyn_transfercount

|Property|Value|
|--------|-----|
|Description|Number of times the conversation was transferred|
|DisplayName|Transfer Count|
|Format|None|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_transfercount|
|MaxValue|2147483647|
|MinValue|0|
|RequiredLevel|None|
|Type|Integer|


### <a name="BKMK_msdyn_workstreamworkdistributionmode"></a> msdyn_workstreamworkdistributionmode

**Added by**: Omnichannel - Base Patch Solution

|Property|Value|
|--------|-----|
|Description|Work distribution mode of the associated work stream|
|DisplayName|Work distribution mode|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_workstreamworkdistributionmode|
|RequiredLevel|None|
|Type|Picklist|

#### msdyn_workstreamworkdistributionmode Options

|Value|Label|
|-----|-----|
|192350000|Push|
|192350001|Pick|



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
|Description|Unique identifier of the user or team who owns the conversation record.|
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
|Description|Status of the Ongoing conversation record|
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
|0|Open|1|Open|
|1|Active|2|Active|
|2|Waiting|3|Waiting|
|3|Closed|4|Closed|
|4|Wrap-up|5|Wrap-up|



### <a name="BKMK_statuscode"></a> statuscode

|Property|Value|
|--------|-----|
|Description|Reason for the status of Ongoing conversation record|
|DisplayName|Status Reason|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|statuscode|
|RequiredLevel|None|
|Type|Status|

#### statuscode Options

|Value|Label|State|
|-----|-----|-----|
|1|Open|0|
|2|Active|1|
|3|Waiting|2|
|4|Closed|3|
|5|Wrap-up|4|



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
- [msdyn_activeagentidName](#BKMK_msdyn_activeagentidName)
- [msdyn_activeagentidYomiName](#BKMK_msdyn_activeagentidYomiName)
- [msdyn_cdsqueueidName](#BKMK_msdyn_cdsqueueidName)
- [msdyn_customerName](#BKMK_msdyn_customerName)
- [msdyn_customerYomiName](#BKMK_msdyn_customerYomiName)
- [msdyn_liveworkstreamidName](#BKMK_msdyn_liveworkstreamidName)
- [msdyn_queueidName](#BKMK_msdyn_queueidName)
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
|Description|Unique identifier of the user who created the Ongoing Conversation.|
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
|Description|Date and time when the Ongoing Conversation was created.|
|DisplayName|Date Created|
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
|Description|Unique identifier of the delegate user who created the Ongoing Conversation.|
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
|Description|Unique identifier of user who last modified the Ongoing Conversation.|
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
|Description|Date and time when Ongoing Conversation was last modified.|
|DisplayName|Last Updated|
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
|Description|Unique identifier of the delegate user who last modified the Ongoing Conversation.|
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


### <a name="BKMK_msdyn_activeagentidName"></a> msdyn_activeagentidName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|msdyn_activeagentidname|
|MaxLength|200|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_msdyn_activeagentidYomiName"></a> msdyn_activeagentidYomiName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|msdyn_activeagentidyominame|
|MaxLength|200|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_msdyn_cdsqueueidName"></a> msdyn_cdsqueueidName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|msdyn_cdsqueueidname|
|MaxLength|200|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_msdyn_customerName"></a> msdyn_customerName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|msdyn_customername|
|MaxLength|4000|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_msdyn_customerYomiName"></a> msdyn_customerYomiName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|msdyn_customeryominame|
|MaxLength|4000|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_msdyn_liveworkstreamidName"></a> msdyn_liveworkstreamidName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|msdyn_liveworkstreamidname|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_msdyn_queueidName"></a> msdyn_queueidName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|msdyn_queueidname|
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
|Description|Unique identifier of the business unit that owns the Ongoing Conversation.|
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
|Description|Unique identifier of the team that owns the Ongoing Conversation.|
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
|Description|Unique identifier of the user that owns the Ongoing Conversation.|
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

- [msdyn_msdyn_liveworkstream_msdyn_liveconversation](#BKMK_msdyn_msdyn_liveworkstream_msdyn_liveconversation)
- [msdyn_msdyn_omnichannelqueue_msdyn_liveconversation](#BKMK_msdyn_msdyn_omnichannelqueue_msdyn_liveconversation)


### <a name="BKMK_msdyn_msdyn_liveworkstream_msdyn_liveconversation"></a> msdyn_msdyn_liveworkstream_msdyn_liveconversation

See msdyn_liveworkstream Entity [msdyn_msdyn_liveworkstream_msdyn_liveconversation](msdyn_liveworkstream.md#BKMK_msdyn_msdyn_liveworkstream_msdyn_liveconversation) One-To-Many relationship.

### <a name="BKMK_msdyn_msdyn_omnichannelqueue_msdyn_liveconversation"></a> msdyn_msdyn_omnichannelqueue_msdyn_liveconversation

See msdyn_omnichannelqueue Entity [msdyn_msdyn_omnichannelqueue_msdyn_liveconversation](msdyn_omnichannelqueue.md#BKMK_msdyn_msdyn_omnichannelqueue_msdyn_liveconversation) One-To-Many relationship.

### See also

[Introduction to Omnichannel for Customer Service](../../../introduction-omnichannel.md)<br />
[Developer guide for Omnichannel for Customer Service](../../omnichannel-developer.md)
