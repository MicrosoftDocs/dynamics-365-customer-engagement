---
title: "msdyn_conversationmessageblock table (Microsoft Dataverse)| MicrosoftDocs"
description: "Includes schema information and supported messages for the msdyn_conversationmessageblock table."
ms.date: 03/23/2020
ms.topic: "reference"
author: "gandhamm"
ms.author: mgandham
---

# msdyn_conversationmessageblock table

A Message Block would constitute a block of messages up till an agent responds (including the messages sent by the agent). A follow up message, after an agent responds, will create another message block, this block again ends with the messages from the agent.

You can only use this table to enable change tracking. You can't customize this table.

**Added by**: Omnichannel – Base Solution


## Messages

|Message|Web API Operation|SDK Assembly|
|-|-|-|
|Assign|PATCH [*org URI*]/api/data/v9.0/msdyn_conversationmessageblocks(*msdyn_conversationmessageblockid*)<br />[Update](/powerapps/developer/common-data-service/webapi/update-delete-entities-using-web-api#basic-update) `ownerid` property.|<xref:Microsoft.Crm.Sdk.Messages.AssignRequest>|
|BulkRetain|<xref href="Microsoft.Dynamics.CRM.BulkRetain?text=BulkRetain Action" />|<xref:Microsoft.Crm.Sdk.Messages.BulkRetainRequest>|
|Create|POST [*org URI*]/api/data/v9.0/msdyn_conversationmessageblocks<br />See [Create](/powerapps/developer/common-data-service/webapi/create-entity-web-api)|<xref:Microsoft.Xrm.Sdk.Messages.CreateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Create*>|
|CreateMultiple|<xref href="Microsoft.Dynamics.CRM.CreateMultiple?text=CreateMultiple Action" />|<xref:Microsoft.Xrm.Sdk.Messages.CreateMultipleRequest>|
|Delete|DELETE [*org URI*]/api/data/v9.0/msdyn_conversationmessageblocks(*msdyn_conversationmessageblockid*)<br />See [Delete](/powerapps/developer/common-data-service/webapi/update-delete-entities-using-web-api#basic-delete)|<xref:Microsoft.Xrm.Sdk.Messages.DeleteRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Delete*>|
|GrantAccess|<xref href="Microsoft.Dynamics.CRM.GrantAccess?text=GrantAccess Action" />|<xref:Microsoft.Crm.Sdk.Messages.GrantAccessRequest>|
|IsValidStateTransition|<xref href="Microsoft.Dynamics.CRM.IsValidStateTransition?text=IsValidStateTransition Function" />|<xref:Microsoft.Crm.Sdk.Messages.IsValidStateTransitionRequest>|
|ModifyAccess|<xref href="Microsoft.Dynamics.CRM.ModifyAccess?text=ModifyAccess Action" />|<xref:Microsoft.Crm.Sdk.Messages.ModifyAccessRequest>|
|PurgeRetainedContent|<xref href="Microsoft.Dynamics.CRM.PurgeRetainedContent?text=PurgeRetainedContent Action" />|<xref:Microsoft.Crm.Sdk.Messages.PurgeRetainedContentRequest>|
|Retain|<xref href="Microsoft.Dynamics.CRM.Retain?text=Retain Action" />|<xref:Microsoft.Crm.Sdk.Messages.RetainRequest>|
|Retrieve|GET [*org URI*]/api/data/v9.0/msdyn_conversationmessageblocks(*msdyn_conversationmessageblockid*)<br />See [Retrieve](/powerapps/developer/common-data-service/webapi/retrieve-entity-using-web-api)|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Retrieve*>|
|RetrieveMultiple|GET [*org URI*]/api/data/v9.0/msdyn_conversationmessageblocks<br />See [Query Data](/powerapps/developer/common-data-service/webapi/query-data-web-api)|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveMultipleRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.RetrieveMultiple*>|
|RetrievePrincipalAccess|<xref href="Microsoft.Dynamics.CRM.RetrievePrincipalAccess?text=RetrievePrincipalAccess Function" />|<xref:Microsoft.Crm.Sdk.Messages.RetrievePrincipalAccessRequest>|
|RetrieveSharedPrincipalsAndAccess|<xref href="Microsoft.Dynamics.CRM.RetrieveSharedPrincipalsAndAccess?text=RetrieveSharedPrincipalsAndAccess Function" />|<xref:Microsoft.Crm.Sdk.Messages.RetrieveSharedPrincipalsAndAccessRequest>|
|RevokeAccess|<xref href="Microsoft.Dynamics.CRM.RevokeAccess?text=RevokeAccess Action" />|<xref:Microsoft.Crm.Sdk.Messages.RevokeAccessRequest>|
|RollbackRetain|<xref href="Microsoft.Dynamics.CRM.RollbackRetain?text=RollbackRetain Action" />|<xref:Microsoft.Crm.Sdk.Messages.RollbackRetainRequest>|
|SetState|PATCH [*org URI*]/api/data/v9.0/msdyn_conversationmessageblocks(*msdyn_conversationmessageblockid*)<br />[Update](/powerapps/developer/common-data-service/webapi/update-delete-entities-using-web-api#basic-update) `statecode` and `statuscode` properties.|<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|
|Update|PATCH [*org URI*]/api/data/v9.0/msdyn_conversationmessageblocks(*msdyn_conversationmessageblockid*)<br />See [Update](/powerapps/developer/common-data-service/webapi/update-delete-entities-using-web-api#basic-update)|<xref:Microsoft.Xrm.Sdk.Messages.UpdateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Update*>|
|UpdateMultiple|<xref href="Microsoft.Dynamics.CRM.UpdateMultiple?text=UpdateMultiple Action" />|<xref:Microsoft.Xrm.Sdk.Messages.UpdateMultipleRequest>|
|ValidateRetentionConfig|<xref href="Microsoft.Dynamics.CRM.ValidateRetentionConfig?text=ValidateRetentionConfig Action" />|<xref:Microsoft.Crm.Sdk.Messages.ValidateRetentionConfigRequest>|

## Properties

|Property|Value|
|--------|-----|
|CollectionSchemaName|msdyn_conversationmessageblocks|
|DisplayCollectionName|msdyn_conversationmessageblock|
|DisplayName|Conversation Message Block|
|EntitySetName|msdyn_conversationmessageblocks|
|IsBPFEntity|False|
|LogicalCollectionName|msdyn_conversationmessageblocks|
|LogicalName|msdyn_conversationmessageblock|
|OwnershipType|UserOwned|
|PrimaryIdAttribute|msdyn_conversationmessageblockid|
|PrimaryNameAttribute|msdyn_name|
|SchemaName|msdyn_conversationmessageblock|

<a name="writable-attributes"></a>

## Writable columns/attributes

These columns/attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [msdyn_agentid](#BKMK_msdyn_agentid)
- [msdyn_agentmessagetime](#BKMK_msdyn_agentmessagetime)
- [msdyn_agentresponsesessionid](#BKMK_msdyn_agentresponsesessionid)
- [msdyn_agentresponsetimeadjforoh](#BKMK_msdyn_agentresponsetimeadjforoh)
- [msdyn_agentresponsetimenotadjforoh](#BKMK_msdyn_agentresponsetimenotadjforoh)
- [msdyn_conversationmessageblockId](#BKMK_msdyn_conversationmessageblockId)
- [msdyn_customermessagesessionid](#BKMK_msdyn_customermessagesessionid)
- [msdyn_customermessagetimestamp](#BKMK_msdyn_customermessagetimestamp)
- [msdyn_inboundmessagecountoutsideoh](#BKMK_msdyn_inboundmessagecountoutsideoh)
- [msdyn_inboundmessagecountwithinoh](#BKMK_msdyn_inboundmessagecountwithinoh)
- [msdyn_isfirstresponsetime](#BKMK_msdyn_isfirstresponsetime)
- [msdyn_name](#BKMK_msdyn_name)
- [msdyn_ocliveworkitemid](#BKMK_msdyn_ocliveworkitemid)
- [msdyn_outboundmessagecountoutsideoh](#BKMK_msdyn_outboundmessagecountoutsideoh)
- [msdyn_outboundmessagecountwithinoh](#BKMK_msdyn_outboundmessagecountwithinoh)
- [msdyn_responsetimeadjforoh](#BKMK_msdyn_responsetimeadjforoh)
- [msdyn_responsetimenotadjforoh](#BKMK_msdyn_responsetimenotadjforoh)
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
|Description|Sequence number of the import that created this record|
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


### <a name="BKMK_msdyn_agentid"></a> msdyn_agentid

|Property|Value|
|--------|-----|
|Description|Id of Agent who first responded to customer in this message block|
|DisplayName|Agent Id|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_agentid|
|RequiredLevel|None|
|Targets|systemuser|
|Type|Lookup|


### <a name="BKMK_msdyn_agentmessagetime"></a> msdyn_agentmessagetime

|Property|Value|
|--------|-----|
|DateTimeBehavior|UserLocal|
|Description|Timestamp of first message sent by agent within a message block. Each message block record is a summary of consecutive messages sent by customer and agent’s response to the same|
|DisplayName|Agent message time|
|Format|DateOnly|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_agentmessagetime|
|RequiredLevel|None|
|Type|DateTime|


### <a name="BKMK_msdyn_agentresponsesessionid"></a> msdyn_agentresponsesessionid

|Property|Value|
|--------|-----|
|Description|Agent response session identifier. The session in which agent responded to the customer’s message within this message block|
|DisplayName|Agent response session identifier|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_agentresponsesessionid|
|RequiredLevel|None|
|Targets|msdyn_ocsession|
|Type|Lookup|


### <a name="BKMK_msdyn_agentresponsetimeadjforoh"></a> msdyn_agentresponsetimeadjforoh

|Property|Value|
|--------|-----|
|Description|Time it took for the agent to respond to the customer from the time agent accepted the session., excluding agent's out of operating hours (OOOH)|
|DisplayName|Agent response time adjusted for operating hours.|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_agentresponsetimeadjforoh|
|MaxValue|100000000000|
|MinValue|-100000000000|
|Precision|2|
|RequiredLevel|None|
|Type|Decimal|


### <a name="BKMK_msdyn_agentresponsetimenotadjforoh"></a> msdyn_agentresponsetimenotadjforoh

|Property|Value|
|--------|-----|
|Description|Time it took for the agent to respond to the customer from the time agent accepted the session, including agent's out of operating hours (OOOH)|
|DisplayName|Agent response time not adjusted for OH|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_agentresponsetimenotadjforoh|
|MaxValue|100000000000|
|MinValue|-100000000000|
|Precision|2|
|RequiredLevel|None|
|Type|Decimal|


### <a name="BKMK_msdyn_conversationmessageblockId"></a> msdyn_conversationmessageblockId

|Property|Value|
|--------|-----|
|Description|Unique identifier for entity instances|
|DisplayName|Conversation Message Blocks|
|IsValidForForm|False|
|IsValidForRead|True|
|IsValidForUpdate|False|
|LogicalName|msdyn_conversationmessageblockid|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|


### <a name="BKMK_msdyn_customermessagesessionid"></a> msdyn_customermessagesessionid

|Property|Value|
|--------|-----|
|Description|Customer message session identifier. The session in which customer sent the message within this message block|
|DisplayName|Customer message session identifier|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_customermessagesessionid|
|RequiredLevel|None|
|Targets|msdyn_ocsession|
|Type|Lookup|


### <a name="BKMK_msdyn_customermessagetimestamp"></a> msdyn_customermessagetimestamp

|Property|Value|
|--------|-----|
|DateTimeBehavior|UserLocal|
|Description|Customer Message Session timestamp. Timestamp of first customer message within this message block|
|DisplayName|Customer message time|
|Format|DateOnly|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_customermessagetimestamp|
|RequiredLevel|None|
|Type|DateTime|


### <a name="BKMK_msdyn_inboundmessagecountoutsideoh"></a> msdyn_inboundmessagecountoutsideoh

|Property|Value|
|--------|-----|
|Description|Number of messages from customer to agent outside the agent's operating hours|
|DisplayName|In message outside OH|
|Format|None|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_inboundmessagecountoutsideoh|
|MaxValue|2147483647|
|MinValue|-2147483648|
|RequiredLevel|None|
|Type|Integer|


### <a name="BKMK_msdyn_inboundmessagecountwithinoh"></a> msdyn_inboundmessagecountwithinoh

|Property|Value|
|--------|-----|
|Description|Number of messages from customer to agent within the agent's operating hours|
|DisplayName|In message within OH|
|Format|None|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_inboundmessagecountwithinoh|
|MaxValue|2147483647|
|MinValue|-2147483648|
|RequiredLevel|None|
|Type|Integer|


### <a name="BKMK_msdyn_isfirstresponsetime"></a> msdyn_isfirstresponsetime

|Property|Value|
|--------|-----|
|Description|Indicates if this message block contains the first response time for the conversation|
|DisplayName|Is first response time|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_isfirstresponsetime|
|RequiredLevel|None|
|Type|Boolean|

#### msdyn_isfirstresponsetime Choices/Options

|Value|Label|
|-----|-----|
|1|Yes|
|0|No|

**DefaultValue**: False



### <a name="BKMK_msdyn_name"></a> msdyn_name

|Property|Value|
|--------|-----|
|Description|The name of the custom entity|
|DisplayName|Name|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_name|
|MaxLength|100|
|RequiredLevel|ApplicationRequired|
|Type|String|


### <a name="BKMK_msdyn_ocliveworkitemid"></a> msdyn_ocliveworkitemid

|Property|Value|
|--------|-----|
|Description|Conversation Id|
|DisplayName|Conversation Id|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_ocliveworkitemid|
|RequiredLevel|None|
|Targets|msdyn_ocliveworkitem|
|Type|Lookup|


### <a name="BKMK_msdyn_outboundmessagecountoutsideoh"></a> msdyn_outboundmessagecountoutsideoh

|Property|Value|
|--------|-----|
|Description|Number of messages from agent to customer outside the agent's operating hours|
|DisplayName|Outbound message outside operating hours|
|Format|None|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_outboundmessagecountoutsideoh|
|MaxValue|2147483647|
|MinValue|-2147483648|
|RequiredLevel|None|
|Type|Integer|


### <a name="BKMK_msdyn_outboundmessagecountwithinoh"></a> msdyn_outboundmessagecountwithinoh

|Property|Value|
|--------|-----|
|Description|Number of messages from agent to customer within the agent's operating hours|
|DisplayName|Outboud message within operating hours|
|Format|None|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_outboundmessagecountwithinoh|
|MaxValue|2147483647|
|MinValue|-2147483648|
|RequiredLevel|None|
|Type|Integer|


### <a name="BKMK_msdyn_responsetimeadjforoh"></a> msdyn_responsetimeadjforoh

|Property|Value|
|--------|-----|
|Description|Time it took to respond to customer, excluding agent's out of operating hours (OOOH)|
|DisplayName|Response time adjusted for OH|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_responsetimeadjforoh|
|MaxValue|100000000000|
|MinValue|-100000000000|
|Precision|2|
|RequiredLevel|None|
|Type|Decimal|


### <a name="BKMK_msdyn_responsetimenotadjforoh"></a> msdyn_responsetimenotadjforoh

|Property|Value|
|--------|-----|
|Description|Time it took to respond to customer, including agent's out of operating hours|
|DisplayName|Response time not adjusted for OH|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_responsetimenotadjforoh|
|MaxValue|100000000000|
|MinValue|-100000000000|
|Precision|2|
|RequiredLevel|None|
|Type|Decimal|


### <a name="BKMK_OverriddenCreatedOn"></a> OverriddenCreatedOn

|Property|Value|
|--------|-----|
|DateTimeBehavior|UserLocal|
|Description|Date and time that the record was migrated|
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
|Description|Status of the Conversation Message Blocks|
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
|Description|Reason for the status of the Conversation Message Blocks|
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
|Description|Time zone code that was in use when the record was created|
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
- [msdyn_agentresponsesessionidName](#BKMK_msdyn_agentresponsesessionidName)
- [msdyn_customermessagesessionidName](#BKMK_msdyn_customermessagesessionidName)
- [msdyn_ocliveworkitemidName](#BKMK_msdyn_ocliveworkitemidName)
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
|Description|Unique identifier of the user who created the record|
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
|Description|Date and time when the record was created|
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
|Description|Unique identifier of the delegate user who created the record|
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
|Description|Unique identifier of the user who modified the record|
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
|Description|Date and time when the record was modified|
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
|Description|Unique identifier of the delegate user who modified the record|
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


### <a name="BKMK_msdyn_agentresponsesessionidName"></a> msdyn_agentresponsesessionidName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|msdyn_agentresponsesessionidname|
|MaxLength|200|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_msdyn_customermessagesessionidName"></a> msdyn_customermessagesessionidName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|msdyn_customermessagesessionidname|
|MaxLength|200|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_msdyn_ocliveworkitemidName"></a> msdyn_ocliveworkitemidName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|msdyn_ocliveworkitemidname|
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
|Description|Unique identifier for the team that owns the record|
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
|Description|Unique identifier for the user that owns the record|
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

<a name="onetomany"></a>

## One-To-Many Relationships

Listed by **SchemaName**.

- [msdyn_conversationmessageblock_SyncErrors](#BKMK_msdyn_conversationmessageblock_SyncErrors)
- [msdyn_conversationmessageblock_DuplicateMatchingRecord](#BKMK_msdyn_conversationmessageblock_DuplicateMatchingRecord)
- [msdyn_conversationmessageblock_DuplicateBaseRecord](#BKMK_msdyn_conversationmessageblock_DuplicateBaseRecord)
- [msdyn_conversationmessageblock_AsyncOperations](#BKMK_msdyn_conversationmessageblock_AsyncOperations)
- [msdyn_conversationmessageblock_MailboxTrackingFolders](#BKMK_msdyn_conversationmessageblock_MailboxTrackingFolders)
- [msdyn_conversationmessageblock_UserEntityInstanceDatas](#BKMK_msdyn_conversationmessageblock_UserEntityInstanceDatas)
- [msdyn_conversationmessageblock_ProcessSession](#BKMK_msdyn_conversationmessageblock_ProcessSession)
- [msdyn_conversationmessageblock_BulkDeleteFailures](#BKMK_msdyn_conversationmessageblock_BulkDeleteFailures)
- [msdyn_conversationmessageblock_PrincipalObjectAttributeAccesses](#BKMK_msdyn_conversationmessageblock_PrincipalObjectAttributeAccesses)


### <a name="BKMK_msdyn_conversationmessageblock_SyncErrors"></a> msdyn_conversationmessageblock_SyncErrors

**Added by**: System Solution Solution

Same as syncerror table [msdyn_conversationmessageblock_SyncErrors](syncerror.md#BKMK_msdyn_conversationmessageblock_SyncErrors) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|syncerror|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_conversationmessageblock_SyncErrors|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_conversationmessageblock_DuplicateMatchingRecord"></a> msdyn_conversationmessageblock_DuplicateMatchingRecord

**Added by**: System Solution Solution

Same as duplicaterecord table [msdyn_conversationmessageblock_DuplicateMatchingRecord](duplicaterecord.md#BKMK_msdyn_conversationmessageblock_DuplicateMatchingRecord) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|duplicaterecord|
|ReferencingAttribute|duplicaterecordid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_conversationmessageblock_DuplicateMatchingRecord|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_conversationmessageblock_DuplicateBaseRecord"></a> msdyn_conversationmessageblock_DuplicateBaseRecord

**Added by**: System Solution Solution

Same as duplicaterecord table [msdyn_conversationmessageblock_DuplicateBaseRecord](duplicaterecord.md#BKMK_msdyn_conversationmessageblock_DuplicateBaseRecord) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|duplicaterecord|
|ReferencingAttribute|baserecordid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_conversationmessageblock_DuplicateBaseRecord|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_conversationmessageblock_AsyncOperations"></a> msdyn_conversationmessageblock_AsyncOperations

**Added by**: System Solution Solution

Same as asyncoperation table [msdyn_conversationmessageblock_AsyncOperations](asyncoperation.md#BKMK_msdyn_conversationmessageblock_AsyncOperations) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|asyncoperation|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_conversationmessageblock_AsyncOperations|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_conversationmessageblock_MailboxTrackingFolders"></a> msdyn_conversationmessageblock_MailboxTrackingFolders

**Added by**: System Solution Solution

Same as mailboxtrackingfolder table [msdyn_conversationmessageblock_MailboxTrackingFolders](mailboxtrackingfolder.md#BKMK_msdyn_conversationmessageblock_MailboxTrackingFolders) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|mailboxtrackingfolder|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_conversationmessageblock_MailboxTrackingFolders|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_conversationmessageblock_UserEntityInstanceDatas"></a> msdyn_conversationmessageblock_UserEntityInstanceDatas

**Added by**: System Solution Solution

Same as userentityinstancedata table [msdyn_conversationmessageblock_UserEntityInstanceDatas](userentityinstancedata.md#BKMK_msdyn_conversationmessageblock_UserEntityInstanceDatas) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|userentityinstancedata|
|ReferencingAttribute|objectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_conversationmessageblock_UserEntityInstanceDatas|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_conversationmessageblock_ProcessSession"></a> msdyn_conversationmessageblock_ProcessSession

**Added by**: System Solution Solution

Same as processsession table [msdyn_conversationmessageblock_ProcessSession](processsession.md#BKMK_msdyn_conversationmessageblock_ProcessSession) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|processsession|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_conversationmessageblock_ProcessSession|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_conversationmessageblock_BulkDeleteFailures"></a> msdyn_conversationmessageblock_BulkDeleteFailures

**Added by**: System Solution Solution

Same as bulkdeletefailure table [msdyn_conversationmessageblock_BulkDeleteFailures](bulkdeletefailure.md#BKMK_msdyn_conversationmessageblock_BulkDeleteFailures) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|bulkdeletefailure|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_conversationmessageblock_BulkDeleteFailures|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_conversationmessageblock_PrincipalObjectAttributeAccesses"></a> msdyn_conversationmessageblock_PrincipalObjectAttributeAccesses

**Added by**: System Solution Solution

Same as principalobjectattributeaccess table [msdyn_conversationmessageblock_PrincipalObjectAttributeAccesses](principalobjectattributeaccess.md#BKMK_msdyn_conversationmessageblock_PrincipalObjectAttributeAccesses) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|principalobjectattributeaccess|
|ReferencingAttribute|objectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_conversationmessageblock_PrincipalObjectAttributeAccesses|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|

<a name="manytoone"></a>

## Many-To-One Relationships

Each Many-To-One relationship is defined by a corresponding One-To-Many relationship with the related table. Listed by **SchemaName**.

- [lk_msdyn_conversationmessageblock_createdby](#BKMK_lk_msdyn_conversationmessageblock_createdby)
- [lk_msdyn_conversationmessageblock_createdonbehalfby](#BKMK_lk_msdyn_conversationmessageblock_createdonbehalfby)
- [lk_msdyn_conversationmessageblock_modifiedby](#BKMK_lk_msdyn_conversationmessageblock_modifiedby)
- [lk_msdyn_conversationmessageblock_modifiedonbehalfby](#BKMK_lk_msdyn_conversationmessageblock_modifiedonbehalfby)
- [user_msdyn_conversationmessageblock](#BKMK_user_msdyn_conversationmessageblock)
- [team_msdyn_conversationmessageblock](#BKMK_team_msdyn_conversationmessageblock)
- [business_unit_msdyn_conversationmessageblock](#BKMK_business_unit_msdyn_conversationmessageblock)
- [msdyn_ocliveworkitem_msdyn_conversationmessageblock_msdyn_ocliveworkitemid](#BKMK_msdyn_ocliveworkitem_msdyn_conversationmessageblock_msdyn_ocliveworkitemid)
- [msdyn_ocsession_msdyn_conversationmessageblock_msdyn_agentresponsesessionid](#BKMK_msdyn_ocsession_msdyn_conversationmessageblock_msdyn_agentresponsesessionid)
- [msdyn_ocsession_msdyn_conversationmessageblock_msdyn_customermessagesessionid](#BKMK_msdyn_ocsession_msdyn_conversationmessageblock_msdyn_customermessagesessionid)
- [msdyn_systemuser_msdyn_conversationmessageblock_msdyn_agentid](#BKMK_msdyn_systemuser_msdyn_conversationmessageblock_msdyn_agentid)


### <a name="BKMK_lk_msdyn_conversationmessageblock_createdby"></a> lk_msdyn_conversationmessageblock_createdby

**Added by**: System Solution Solution

See systemuser Table [lk_msdyn_conversationmessageblock_createdby](systemuser.md#BKMK_lk_msdyn_conversationmessageblock_createdby) One-To-Many relationship.

### <a name="BKMK_lk_msdyn_conversationmessageblock_createdonbehalfby"></a> lk_msdyn_conversationmessageblock_createdonbehalfby

**Added by**: System Solution Solution

See systemuser Table [lk_msdyn_conversationmessageblock_createdonbehalfby](systemuser.md#BKMK_lk_msdyn_conversationmessageblock_createdonbehalfby) One-To-Many relationship.

### <a name="BKMK_lk_msdyn_conversationmessageblock_modifiedby"></a> lk_msdyn_conversationmessageblock_modifiedby

**Added by**: System Solution Solution

See systemuser Table [lk_msdyn_conversationmessageblock_modifiedby](systemuser.md#BKMK_lk_msdyn_conversationmessageblock_modifiedby) One-To-Many relationship.

### <a name="BKMK_lk_msdyn_conversationmessageblock_modifiedonbehalfby"></a> lk_msdyn_conversationmessageblock_modifiedonbehalfby

**Added by**: System Solution Solution

See systemuser Table [lk_msdyn_conversationmessageblock_modifiedonbehalfby](systemuser.md#BKMK_lk_msdyn_conversationmessageblock_modifiedonbehalfby) One-To-Many relationship.

### <a name="BKMK_user_msdyn_conversationmessageblock"></a> user_msdyn_conversationmessageblock

**Added by**: System Solution Solution

See systemuser Table [user_msdyn_conversationmessageblock](systemuser.md#BKMK_user_msdyn_conversationmessageblock) One-To-Many relationship.

### <a name="BKMK_team_msdyn_conversationmessageblock"></a> team_msdyn_conversationmessageblock

**Added by**: System Solution Solution

See team Table [team_msdyn_conversationmessageblock](team.md#BKMK_team_msdyn_conversationmessageblock) One-To-Many relationship.

### <a name="BKMK_business_unit_msdyn_conversationmessageblock"></a> business_unit_msdyn_conversationmessageblock

**Added by**: System Solution Solution

See businessunit Table [business_unit_msdyn_conversationmessageblock](businessunit.md#BKMK_business_unit_msdyn_conversationmessageblock) One-To-Many relationship.

### <a name="BKMK_msdyn_ocliveworkitem_msdyn_conversationmessageblock_msdyn_ocliveworkitemid"></a> msdyn_ocliveworkitem_msdyn_conversationmessageblock_msdyn_ocliveworkitemid

**Added by**: Active Solution Solution

See msdyn_ocliveworkitem Table [msdyn_ocliveworkitem_msdyn_conversationmessageblock_msdyn_ocliveworkitemid](msdyn_ocliveworkitem.md#BKMK_msdyn_ocliveworkitem_msdyn_conversationmessageblock_msdyn_ocliveworkitemid) One-To-Many relationship.

### <a name="BKMK_msdyn_ocsession_msdyn_conversationmessageblock_msdyn_agentresponsesessionid"></a> msdyn_ocsession_msdyn_conversationmessageblock_msdyn_agentresponsesessionid

**Added by**: Active Solution Solution

See msdyn_ocsession Table [msdyn_ocsession_msdyn_conversationmessageblock_msdyn_agentresponsesessionid](msdyn_ocsession.md#BKMK_msdyn_ocsession_msdyn_conversationmessageblock_msdyn_agentresponsesessionid) One-To-Many relationship.

### <a name="BKMK_msdyn_ocsession_msdyn_conversationmessageblock_msdyn_customermessagesessionid"></a> msdyn_ocsession_msdyn_conversationmessageblock_msdyn_customermessagesessionid

**Added by**: Active Solution Solution

See msdyn_ocsession Table [msdyn_ocsession_msdyn_conversationmessageblock_msdyn_customermessagesessionid](msdyn_ocsession.md#BKMK_msdyn_ocsession_msdyn_conversationmessageblock_msdyn_customermessagesessionid) One-To-Many relationship.

### <a name="BKMK_msdyn_systemuser_msdyn_conversationmessageblock_msdyn_agentid"></a> msdyn_systemuser_msdyn_conversationmessageblock_msdyn_agentid

**Added by**: System Solution Solution

See systemuser Table [msdyn_systemuser_msdyn_conversationmessageblock_msdyn_agentid](systemuser.md#BKMK_msdyn_systemuser_msdyn_conversationmessageblock_msdyn_agentid) One-To-Many relationship.

### See also

[Introduction to Omnichannel for Customer Service](../../../introduction-omnichannel.md)<br />
[Developer guide for Omnichannel for Customer Service](../../omnichannel-developer.md)


[!INCLUDE[footer-include](../../../../includes/footer-banner.md)]
