---
title: "msdyn_ocsentimentdailytopic Entity Reference | MicrosoftDocs"
description: "Includes schema information and supported messages for the msdyn_ocsentimentdailytopic entity."
author: "v-sailab"
ms.author: "v-sailab"
manager: "shujoshi"
ms.date: 09/14/2020
ms.topic: "reference"
ms.service: "dynamics-365-customerservice"
applies_to: 
  - "Dynamics 365 (online)"
---
# msdyn_ocsentimentdailytopic Entity Reference

[!INCLUDE[cc-use-with-omnichannel](../../../../includes/cc-use-with-omnichannel.md)]

1. store properties regarding each topic cluster
2. used for dashboard visualization (like topic example) and calculation for topic mapping

**Added by**: Omnichannel - Base Patch Solution


## Messages

|Message|Web API Operation|SDK Assembly|
|-|-|-|
|Assign|PATCH [*org URI*]/api/data/v9.1/msdyn_ocsentimentdailytopics(*msdyn_ocsentimentdailytopicid*)<br />[Update](/powerapps/developer/common-data-service/webapi/update-delete-entities-using-web-api#basic-update) `ownerid` property.|<xref:Microsoft.Crm.Sdk.Messages.AssignRequest>|
|Create|POST [*org URI*]/api/data/v9.1/msdyn_ocsentimentdailytopics<br />See [Create](/powerapps/developer/common-data-service/webapi/create-entity-web-api)|<xref:Microsoft.Xrm.Sdk.Messages.CreateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Create*>|
|Delete|DELETE [*org URI*]/api/data/v9.1/msdyn_ocsentimentdailytopics(*msdyn_ocsentimentdailytopicid*)<br />See [Delete](/powerapps/developer/common-data-service/webapi/update-delete-entities-using-web-api#basic-delete)|<xref:Microsoft.Xrm.Sdk.Messages.DeleteRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Delete*>|
|GrantAccess|<xref href="Microsoft.Dynamics.CRM.GrantAccess?text=GrantAccess Action" />|<xref:Microsoft.Crm.Sdk.Messages.GrantAccessRequest>|
|IsValidStateTransition|<xref href="Microsoft.Dynamics.CRM.IsValidStateTransition?text=IsValidStateTransition Function" />|<xref:Microsoft.Crm.Sdk.Messages.IsValidStateTransitionRequest>|
|ModifyAccess|<xref href="Microsoft.Dynamics.CRM.ModifyAccess?text=ModifyAccess Action" />|<xref:Microsoft.Crm.Sdk.Messages.ModifyAccessRequest>|
|Retrieve|GET [*org URI*]/api/data/v9.1/msdyn_ocsentimentdailytopics(*msdyn_ocsentimentdailytopicid*)<br />See [Retrieve](/powerapps/developer/common-data-service/webapi/retrieve-entity-using-web-api)|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Retrieve*>|
|RetrieveMultiple|GET [*org URI*]/api/data/v9.1/msdyn_ocsentimentdailytopics<br />See [Query Data](/powerapps/developer/common-data-service/webapi/query-data-web-api)|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveMultipleRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.RetrieveMultiple*>|
|RetrievePrincipalAccess|<xref href="Microsoft.Dynamics.CRM.RetrievePrincipalAccess?text=RetrievePrincipalAccess Function" />|<xref:Microsoft.Crm.Sdk.Messages.RetrievePrincipalAccessRequest>|
|RetrieveSharedPrincipalsAndAccess|<xref href="Microsoft.Dynamics.CRM.RetrieveSharedPrincipalsAndAccess?text=RetrieveSharedPrincipalsAndAccess Function" />|<xref:Microsoft.Crm.Sdk.Messages.RetrieveSharedPrincipalsAndAccessRequest>|
|RevokeAccess|<xref href="Microsoft.Dynamics.CRM.RevokeAccess?text=RevokeAccess Action" />|<xref:Microsoft.Crm.Sdk.Messages.RevokeAccessRequest>|
|SetState|PATCH [*org URI*]/api/data/v9.1/msdyn_ocsentimentdailytopics(*msdyn_ocsentimentdailytopicid*)<br />[Update](/powerapps/developer/common-data-service/webapi/update-delete-entities-using-web-api#basic-update) `statecode` and `statuscode` properties.|<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|
|Update|PATCH [*org URI*]/api/data/v9.1/msdyn_ocsentimentdailytopics(*msdyn_ocsentimentdailytopicid*)<br />See [Update](/powerapps/developer/common-data-service/webapi/update-delete-entities-using-web-api#basic-update)|<xref:Microsoft.Xrm.Sdk.Messages.UpdateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Update*>|

## Entity Properties

|Property|Value|
|--------|-----|
|CollectionSchemaName|msdyn_ocsentimentdailytopics|
|DisplayCollectionName|Sentiment daily topic|
|DisplayName|Sentiment daily topic|
|EntitySetName|msdyn_ocsentimentdailytopics|
|IsBPFEntity|False|
|LogicalCollectionName|msdyn_ocsentimentdailytopics|
|LogicalName|msdyn_ocsentimentdailytopic|
|OwnershipType|UserOwned|
|PrimaryIdAttribute|msdyn_ocsentimentdailytopicid|
|PrimaryNameAttribute|msdyn_name|
|SchemaName|msdyn_ocsentimentdailytopic|

<a name="writable-attributes"></a>

## Writable attributes

These attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [msdyn_conversationcount](#BKMK_msdyn_conversationcount)
- [msdyn_conversationexample](#BKMK_msdyn_conversationexample)
- [msdyn_name](#BKMK_msdyn_name)
- [msdyn_ocsentimentdailytopicId](#BKMK_msdyn_ocsentimentdailytopicId)
- [msdyn_sentimentdriverintradayweightimpact](#BKMK_msdyn_sentimentdriverintradayweightimpact)
- [msdyn_sentimentscore](#BKMK_msdyn_sentimentscore)
- [msdyn_topiccountpercentage](#BKMK_msdyn_topiccountpercentage)
- [msdyn_topicdate](#BKMK_msdyn_topicdate)
- [msdyn_topicindex](#BKMK_msdyn_topicindex)
- [msdyn_topicname](#BKMK_msdyn_topicname)
- [msdyn_weeklyid](#BKMK_msdyn_weeklyid)
- [msdyn_weeklytopicid](#BKMK_msdyn_weeklytopicid)
- [msdyn_weeklytopicname](#BKMK_msdyn_weeklytopicname)
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


### <a name="BKMK_msdyn_conversationcount"></a> msdyn_conversationcount

|Property|Value|
|--------|-----|
|Description|The volume of chat sessions within this topic cluster|
|DisplayName|Conversation count|
|Format|None|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_conversationcount|
|MaxValue|2147483647|
|MinValue|0|
|RequiredLevel|ApplicationRequired|
|Type|Integer|


### <a name="BKMK_msdyn_conversationexample"></a> msdyn_conversationexample

|Property|Value|
|--------|-----|
|Description|3 Chat conversation examples from this topic cluster|
|DisplayName|Conversation example|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_conversationexample|
|MaxLength|4000|
|RequiredLevel|ApplicationRequired|
|Type|String|


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


### <a name="BKMK_msdyn_ocsentimentdailytopicId"></a> msdyn_ocsentimentdailytopicId

|Property|Value|
|--------|-----|
|Description|Daily Topic  Id|
|DisplayName|Topic Unique Id|
|IsValidForForm|False|
|IsValidForRead|True|
|IsValidForUpdate|False|
|LogicalName|msdyn_ocsentimentdailytopicid|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|


### <a name="BKMK_msdyn_sentimentdriverintradayweightimpact"></a> msdyn_sentimentdriverintradayweightimpact

|Property|Value|
|--------|-----|
|Description|Intraday sentiment driver: The sentiment weighted  impact value from this topic cluster on the day’s average sentiment score|
|DisplayName|Sentiment driver intraday weight impact|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_sentimentdriverintradayweightimpact|
|MaxValue|100|
|MinValue|-100|
|Precision|3|
|RequiredLevel|Recommended|
|Type|Double|


### <a name="BKMK_msdyn_sentimentscore"></a> msdyn_sentimentscore

|Property|Value|
|--------|-----|
|Description|The average sentiment score for all the chat sessions within the topic cluster|
|DisplayName|Sentiment score|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_sentimentscore|
|MaxValue|1000000000|
|MinValue|0|
|Precision|3|
|RequiredLevel|ApplicationRequired|
|Type|Double|


### <a name="BKMK_msdyn_topiccountpercentage"></a> msdyn_topiccountpercentage

|Property|Value|
|--------|-----|
|Description|The percentage of this topic chat session volume in the total daily chat session volume|
|DisplayName|Topic count percentage|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_topiccountpercentage|
|MaxValue|1000000000|
|MinValue|0|
|Precision|3|
|RequiredLevel|ApplicationRequired|
|Type|Double|


### <a name="BKMK_msdyn_topicdate"></a> msdyn_topicdate

|Property|Value|
|--------|-----|
|DateTimeBehavior|UserLocal|
|Description|Date of the Topic|
|DisplayName|Topic date|
|Format|DateOnly|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_topicdate|
|RequiredLevel|ApplicationRequired|
|Type|DateTime|


### <a name="BKMK_msdyn_topicindex"></a> msdyn_topicindex

|Property|Value|
|--------|-----|
|Description|The topic cluster id from clustering algorithm
-1 represent outlier cluster
Positive number like 5 represent topic cluster|
|DisplayName|Topic index|
|Format|None|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_topicindex|
|MaxValue|2147483647|
|MinValue|-100|
|RequiredLevel|None|
|Type|Integer|


### <a name="BKMK_msdyn_topicname"></a> msdyn_topicname

|Property|Value|
|--------|-----|
|Description|A combination of top noun keyword and verb keyword, which is used for dashboard visualization|
|DisplayName|Topic name|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_topicname|
|MaxLength|4000|
|RequiredLevel|ApplicationRequired|
|Type|String|


### <a name="BKMK_msdyn_weeklyid"></a> msdyn_weeklyid

|Property|Value|
|--------|-----|
|Description|Weekly Id for the topic|
|DisplayName|Weekly id|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_weeklyid|
|MaxLength|4000|
|RequiredLevel|ApplicationRequired|
|Type|String|


### <a name="BKMK_msdyn_weeklytopicid"></a> msdyn_weeklytopicid

|Property|Value|
|--------|-----|
|Description|Weekly TopicId for the topic|
|DisplayName|Weekly topic id|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_weeklytopicid|
|MaxLength|4000|
|RequiredLevel|ApplicationRequired|
|Type|String|


### <a name="BKMK_msdyn_weeklytopicname"></a> msdyn_weeklytopicname

|Property|Value|
|--------|-----|
|Description|Weekly Topic Name for the topic|
|DisplayName|Weekly topic name|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_weeklytopicname|
|MaxLength|4000|
|RequiredLevel|ApplicationRequired|
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
|Description|Status of the Sentiment daily topic|
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
|0|Active|1|Active|
|1|Inactive|2|Inactive|



### <a name="BKMK_statuscode"></a> statuscode

|Property|Value|
|--------|-----|
|Description|Reason for the status of the Sentiment daily topic|
|DisplayName|Status Reason|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|statuscode|
|RequiredLevel|None|
|Type|Status|

#### statuscode Options

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

<a name="onetomany"></a>

## One-To-Many Relationships

Listed by **SchemaName**.

- [msdyn_msdyn_ocsentimentdailytopic_msdyn_ocsentimentdailytopickeyword_dailytopicid](#BKMK_msdyn_msdyn_ocsentimentdailytopic_msdyn_ocsentimentdailytopickeyword_dailytopicid)
- [msdyn_msdyn_ocsentimentdailytopic_msdyn_ocsentimentdailytopictrending_basetopicid](#BKMK_msdyn_msdyn_ocsentimentdailytopic_msdyn_ocsentimentdailytopictrending_basetopicid)
- [msdyn_msdyn_ocsentimentdailytopic_msdyn_ocsentimentdailytopictrending_dailytopicid](#BKMK_msdyn_msdyn_ocsentimentdailytopic_msdyn_ocsentimentdailytopictrending_dailytopicid)


### <a name="BKMK_msdyn_msdyn_ocsentimentdailytopic_msdyn_ocsentimentdailytopickeyword_dailytopicid"></a> msdyn_msdyn_ocsentimentdailytopic_msdyn_ocsentimentdailytopickeyword_dailytopicid

Same as msdyn_ocsentimentdailytopickeyword entity [msdyn_msdyn_ocsentimentdailytopic_msdyn_ocsentimentdailytopickeyword_dailytopicid](msdyn_ocsentimentdailytopickeyword.md#BKMK_msdyn_msdyn_ocsentimentdailytopic_msdyn_ocsentimentdailytopickeyword_dailytopicid) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_ocsentimentdailytopickeyword|
|ReferencingAttribute|msdyn_dailytopicid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|msdyn_msdyn_ocsentimentdailytopic_msdyn_ocsentimentdailytopickeyword_dailytopicid|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Details<br />Label: <br />Order: 10000|
|CascadeConfiguration|Assign: NoCascade<br />Delete: RemoveLink<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_msdyn_ocsentimentdailytopic_msdyn_ocsentimentdailytopictrending_basetopicid"></a> msdyn_msdyn_ocsentimentdailytopic_msdyn_ocsentimentdailytopictrending_basetopicid

Same as msdyn_ocsentimentdailytopictrending entity [msdyn_msdyn_ocsentimentdailytopic_msdyn_ocsentimentdailytopictrending_basetopicid](msdyn_ocsentimentdailytopictrending.md#BKMK_msdyn_msdyn_ocsentimentdailytopic_msdyn_ocsentimentdailytopictrending_basetopicid) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_ocsentimentdailytopictrending|
|ReferencingAttribute|msdyn_basetopicid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_msdyn_ocsentimentdailytopic_msdyn_ocsentimentdailytopictrending_basetopicid|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Details<br />Label: <br />Order: 10000|
|CascadeConfiguration|Assign: NoCascade<br />Delete: RemoveLink<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_msdyn_ocsentimentdailytopic_msdyn_ocsentimentdailytopictrending_dailytopicid"></a> msdyn_msdyn_ocsentimentdailytopic_msdyn_ocsentimentdailytopictrending_dailytopicid

Same as msdyn_ocsentimentdailytopictrending entity [msdyn_msdyn_ocsentimentdailytopic_msdyn_ocsentimentdailytopictrending_dailytopicid](msdyn_ocsentimentdailytopictrending.md#BKMK_msdyn_msdyn_ocsentimentdailytopic_msdyn_ocsentimentdailytopictrending_dailytopicid) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_ocsentimentdailytopictrending|
|ReferencingAttribute|msdyn_dailytopicid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_msdyn_ocsentimentdailytopic_msdyn_ocsentimentdailytopictrending_dailytopicid|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Details<br />Label: <br />Order: 10000|
|CascadeConfiguration|Assign: NoCascade<br />Delete: RemoveLink<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### See also

[Introduction to Omnichannel for Customer Service](../../../introduction-omnichannel.md)<br />
[Developer guide for Omnichannel for Customer Service](../../omnichannel-developer.md)
