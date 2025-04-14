---
title: "Sentiment daily topic (msdyn_ocsentimentdailytopic) table/entity reference (Microsoft Dynamics 365)"
description: "Includes schema information and supported messages for the Sentiment daily topic (msdyn_ocsentimentdailytopic) table/entity with Microsoft Dynamics 365."
ms.topic: generated-reference
author: JimDaly
ms.author: jdaly
search.audienceType: 
  - developer
---

# Sentiment daily topic (msdyn_ocsentimentdailytopic) table/entity reference (Microsoft Dynamics 365)

1. store properties regarding each topic cluster
2. used for dashboard visualization (like topic example) and calculation for topic mapping

## Messages

The following table lists the messages for the Sentiment daily topic (msdyn_ocsentimentdailytopic) table.
Messages represent operations that can be performed on the table. They may also be events.

| Name <br />Is Event? |Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `Assign`<br />Event: True |`PATCH` /msdyn_ocsentimentdailytopics(*msdyn_ocsentimentdailytopicid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `ownerid` property. |<xref:Microsoft.Crm.Sdk.Messages.AssignRequest>|
| `Associate`<br />Event: True |[Associate records](/power-apps/developer/data-platform/webapi/associate-disassociate-entities-using-web-api) |[Associate records](/power-apps/developer/data-platform/org-service/entity-operations-associate-disassociate#use-the-associate-method-or-associaterequest)|
| `BulkRetain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.BulkRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Create`<br />Event: True |`POST` /msdyn_ocsentimentdailytopics<br />See [Create](/powerapps/developer/data-platform/webapi/create-entity-web-api) |[Create records](/power-apps/developer/data-platform/org-service/entity-operations-create#basic-create)|
| `CreateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.CreateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.CreateMultipleRequest>|
| `Delete`<br />Event: True |`DELETE` /msdyn_ocsentimentdailytopics(*msdyn_ocsentimentdailytopicid*)<br />See [Delete](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-delete) |[Delete records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-delete)|
| `Disassociate`<br />Event: True |[Disassociate records](/power-apps/developer/data-platform/webapi/associate-disassociate-entities-using-web-api) |[Disassociate records](/power-apps/developer/data-platform/org-service/entity-operations-associate-disassociate#use-the-disassociate-method-or-disassociaterequest)|
| `GrantAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.GrantAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.GrantAccessRequest>|
| `IsValidStateTransition`<br />Event: False |<xref:Microsoft.Dynamics.CRM.IsValidStateTransition?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.IsValidStateTransitionRequest>|
| `ModifyAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.ModifyAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.ModifyAccessRequest>|
| `PurgeRetainedContent`<br />Event: True |<xref:Microsoft.Dynamics.CRM.PurgeRetainedContent?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Restore`<br />Event: True |<xref:Microsoft.Dynamics.CRM.Restore?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.Retain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retrieve`<br />Event: True |`GET` /msdyn_ocsentimentdailytopics(*msdyn_ocsentimentdailytopicid*)<br />See [Retrieve](/powerapps/developer/data-platform/webapi/retrieve-entity-using-web-api) |[Retrieve records](/power-apps/developer/data-platform/org-service/entity-operations-retrieve)|
| `RetrieveMultiple`<br />Event: True |`GET` /msdyn_ocsentimentdailytopics<br />See [Query data](/power-apps/developer/data-platform/webapi/query-data-web-api) |[Query data](/power-apps/developer/data-platform/org-service/entity-operations-query-data)|
| `RetrievePrincipalAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RetrievePrincipalAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RetrievePrincipalAccessRequest>|
| `RetrieveSharedPrincipalsAndAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RetrieveSharedPrincipalsAndAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RetrieveSharedPrincipalsAndAccessRequest>|
| `RevokeAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RevokeAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RevokeAccessRequest>|
| `RollbackRetain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RollbackRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `SetState`<br />Event: True |`PATCH` /msdyn_ocsentimentdailytopics(*msdyn_ocsentimentdailytopicid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `statecode` and `statuscode` properties. |<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|
| `Update`<br />Event: True |`PATCH` /msdyn_ocsentimentdailytopics(*msdyn_ocsentimentdailytopicid*)<br />See [Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) |[Update records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-update)|
| `UpdateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.UpdateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpdateMultipleRequest>|
| `Upsert`<br />Event: False |`PATCH` /msdyn_ocsentimentdailytopics(*msdyn_ocsentimentdailytopicid*)<br />See [Upsert a table row](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#upsert-a-table-row) |<xref:Microsoft.Xrm.Sdk.Messages.UpsertRequest>|
| `UpsertMultiple`<br />Event: False |<xref:Microsoft.Dynamics.CRM.UpsertMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpsertMultipleRequest>|
| `ValidateRetentionConfig`<br />Event: True |<xref:Microsoft.Dynamics.CRM.ValidateRetentionConfig?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|

## Properties

The following table lists selected properties for the Sentiment daily topic (msdyn_ocsentimentdailytopic) table.

|Property|Value|
| --- | --- |
| **DisplayName** | **Sentiment daily topic** |
| **DisplayCollectionName** | **Sentiment daily topic** |
| **SchemaName** | `msdyn_ocsentimentdailytopic` |
| **CollectionSchemaName** | `msdyn_ocsentimentdailytopics` |
| **EntitySetName** | `msdyn_ocsentimentdailytopics`|
| **LogicalName** | `msdyn_ocsentimentdailytopic` |
| **LogicalCollectionName** | `msdyn_ocsentimentdailytopics` |
| **PrimaryIdAttribute** | `msdyn_ocsentimentdailytopicid` |
| **PrimaryNameAttribute** |`msdyn_name` |
| **TableType** | `Standard` |
| **OwnershipType** | `UserOwned` |

## Writable columns/attributes

These columns/attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

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
|---|---|
|Description|**Sequence number of the import that created this record.**|
|DisplayName|**Import Sequence Number**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`importsequencenumber`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|-2147483648|

### <a name="BKMK_msdyn_conversationcount"></a> msdyn_conversationcount

|Property|Value|
|---|---|
|Description|**The volume of chat sessions within this topic cluster**|
|DisplayName|**Conversation count**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_conversationcount`|
|RequiredLevel|ApplicationRequired|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|0|

### <a name="BKMK_msdyn_conversationexample"></a> msdyn_conversationexample

|Property|Value|
|---|---|
|Description|**3 Chat conversation examples from this topic cluster**|
|DisplayName|**Conversation example**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_conversationexample`|
|RequiredLevel|ApplicationRequired|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|4000|

### <a name="BKMK_msdyn_name"></a> msdyn_name

|Property|Value|
|---|---|
|Description|**The name of the custom entity.**|
|DisplayName|**Name**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_name`|
|RequiredLevel|ApplicationRequired|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdyn_ocsentimentdailytopicId"></a> msdyn_ocsentimentdailytopicId

|Property|Value|
|---|---|
|Description|**Daily Topic  Id**|
|DisplayName|**Topic Unique Id**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`msdyn_ocsentimentdailytopicid`|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|

### <a name="BKMK_msdyn_sentimentdriverintradayweightimpact"></a> msdyn_sentimentdriverintradayweightimpact

|Property|Value|
|---|---|
|Description|**Intraday sentiment driver: The sentiment weighted  impact value from this topic cluster on the day’s average sentiment score**|
|DisplayName|**Sentiment driver intraday weight impact**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_sentimentdriverintradayweightimpact`|
|RequiredLevel|Recommended|
|Type|Double|
|ImeMode|Auto|
|MaxValue|100|
|MinValue|-100|
|Precision|3|

### <a name="BKMK_msdyn_sentimentscore"></a> msdyn_sentimentscore

|Property|Value|
|---|---|
|Description|**The average sentiment score for all the chat sessions within the topic cluster**|
|DisplayName|**Sentiment score**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_sentimentscore`|
|RequiredLevel|ApplicationRequired|
|Type|Double|
|ImeMode|Auto|
|MaxValue|1000000000|
|MinValue|0|
|Precision|3|

### <a name="BKMK_msdyn_topiccountpercentage"></a> msdyn_topiccountpercentage

|Property|Value|
|---|---|
|Description|**The percentage of this topic chat session volume in the total daily chat session volume**|
|DisplayName|**Topic count percentage**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_topiccountpercentage`|
|RequiredLevel|ApplicationRequired|
|Type|Double|
|ImeMode|Auto|
|MaxValue|1000000000|
|MinValue|0|
|Precision|3|

### <a name="BKMK_msdyn_topicdate"></a> msdyn_topicdate

|Property|Value|
|---|---|
|Description|**Date of the Topic**|
|DisplayName|**Topic date**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_topicdate`|
|RequiredLevel|ApplicationRequired|
|Type|DateTime|
|CanChangeDateTimeBehavior|True|
|DateTimeBehavior|UserLocal|
|Format|DateOnly|
|ImeMode|Auto|
|SourceTypeMask|0|

### <a name="BKMK_msdyn_topicindex"></a> msdyn_topicindex

|Property|Value|
|---|---|
|Description|**The topic cluster id from clustering algorithm-1 represent outlier clusterPositive number like 5 represent topic cluster**|
|DisplayName|**Topic index**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_topicindex`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|-100|

### <a name="BKMK_msdyn_topicname"></a> msdyn_topicname

|Property|Value|
|---|---|
|Description|**A combination of top noun keyword and verb keyword, which is used for dashboard visualization**|
|DisplayName|**Topic name**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_topicname`|
|RequiredLevel|ApplicationRequired|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|4000|

### <a name="BKMK_msdyn_weeklyid"></a> msdyn_weeklyid

|Property|Value|
|---|---|
|Description|**Weekly Id for the topic**|
|DisplayName|**Weekly id**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_weeklyid`|
|RequiredLevel|ApplicationRequired|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|4000|

### <a name="BKMK_msdyn_weeklytopicid"></a> msdyn_weeklytopicid

|Property|Value|
|---|---|
|Description|**Weekly TopicId for the topic**|
|DisplayName|**Weekly topic id**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_weeklytopicid`|
|RequiredLevel|ApplicationRequired|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|4000|

### <a name="BKMK_msdyn_weeklytopicname"></a> msdyn_weeklytopicname

|Property|Value|
|---|---|
|Description|**Weekly Topic Name for the topic**|
|DisplayName|**Weekly topic name**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_weeklytopicname`|
|RequiredLevel|ApplicationRequired|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|4000|

### <a name="BKMK_OverriddenCreatedOn"></a> OverriddenCreatedOn

|Property|Value|
|---|---|
|Description|**Date and time that the record was migrated.**|
|DisplayName|**Record Created On**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`overriddencreatedon`|
|RequiredLevel|None|
|Type|DateTime|
|CanChangeDateTimeBehavior|False|
|DateTimeBehavior|UserLocal|
|Format|DateOnly|
|ImeMode|Inactive|
|SourceTypeMask|0|

### <a name="BKMK_OwnerId"></a> OwnerId

|Property|Value|
|---|---|
|Description|**Owner Id**|
|DisplayName|**Owner**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`ownerid`|
|RequiredLevel|SystemRequired|
|Type|Owner|
|Targets|systemuser, team|

### <a name="BKMK_OwnerIdType"></a> OwnerIdType

|Property|Value|
|---|---|
|Description|**Owner Id Type**|
|DisplayName||
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`owneridtype`|
|RequiredLevel|SystemRequired|
|Type|EntityName|

### <a name="BKMK_statecode"></a> statecode

|Property|Value|
|---|---|
|Description|**Status of the Sentiment daily topic**|
|DisplayName|**Status**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statecode`|
|RequiredLevel|SystemRequired|
|Type|State|
|DefaultFormValue||
|GlobalChoiceName|`msdyn_ocsentimentdailytopic_statecode`|

#### statecode Choices/Options

|Value|Details|
|---|---|
|0|Label: **Active**<br />DefaultStatus: 1<br />InvariantName: `Active`|
|1|Label: **Inactive**<br />DefaultStatus: 2<br />InvariantName: `Inactive`|

### <a name="BKMK_statuscode"></a> statuscode

|Property|Value|
|---|---|
|Description|**Reason for the status of the Sentiment daily topic**|
|DisplayName|**Status Reason**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statuscode`|
|RequiredLevel|None|
|Type|Status|
|DefaultFormValue||
|GlobalChoiceName|`msdyn_ocsentimentdailytopic_statuscode`|

#### statuscode Choices/Options

|Value|Details|
|---|---|
|1|Label: **Active**<br />State:0<br />TransitionData: None|
|2|Label: **Inactive**<br />State:1<br />TransitionData: None|

### <a name="BKMK_TimeZoneRuleVersionNumber"></a> TimeZoneRuleVersionNumber

|Property|Value|
|---|---|
|Description|**For internal use only.**|
|DisplayName|**Time Zone Rule Version Number**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`timezoneruleversionnumber`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|-1|

### <a name="BKMK_UTCConversionTimeZoneCode"></a> UTCConversionTimeZoneCode

|Property|Value|
|---|---|
|Description|**Time zone code that was in use when the record was created.**|
|DisplayName|**UTC Conversion Time Zone Code**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`utcconversiontimezonecode`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|-1|


## Read-only columns/attributes

These columns/attributes return false for both **IsValidForCreate** and **IsValidForUpdate**. Listed by **SchemaName**.

- [CreatedBy](#BKMK_CreatedBy)
- [CreatedOn](#BKMK_CreatedOn)
- [CreatedOnBehalfBy](#BKMK_CreatedOnBehalfBy)
- [ModifiedBy](#BKMK_ModifiedBy)
- [ModifiedOn](#BKMK_ModifiedOn)
- [ModifiedOnBehalfBy](#BKMK_ModifiedOnBehalfBy)
- [OwnerIdName](#BKMK_OwnerIdName)
- [OwnerIdYomiName](#BKMK_OwnerIdYomiName)
- [OwningBusinessUnit](#BKMK_OwningBusinessUnit)
- [OwningTeam](#BKMK_OwningTeam)
- [OwningUser](#BKMK_OwningUser)
- [VersionNumber](#BKMK_VersionNumber)

### <a name="BKMK_CreatedBy"></a> CreatedBy

|Property|Value|
|---|---|
|Description|**Unique identifier of the user who created the record.**|
|DisplayName|**Created By**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`createdby`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|systemuser|

### <a name="BKMK_CreatedOn"></a> CreatedOn

|Property|Value|
|---|---|
|Description|**Date and time when the record was created.**|
|DisplayName|**Created On**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`createdon`|
|RequiredLevel|None|
|Type|DateTime|
|CanChangeDateTimeBehavior|False|
|DateTimeBehavior|UserLocal|
|Format|DateAndTime|
|ImeMode|Inactive|
|SourceTypeMask|0|

### <a name="BKMK_CreatedOnBehalfBy"></a> CreatedOnBehalfBy

|Property|Value|
|---|---|
|Description|**Unique identifier of the delegate user who created the record.**|
|DisplayName|**Created By (Delegate)**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`createdonbehalfby`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|systemuser|

### <a name="BKMK_ModifiedBy"></a> ModifiedBy

|Property|Value|
|---|---|
|Description|**Unique identifier of the user who modified the record.**|
|DisplayName|**Modified By**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`modifiedby`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|systemuser|

### <a name="BKMK_ModifiedOn"></a> ModifiedOn

|Property|Value|
|---|---|
|Description|**Date and time when the record was modified.**|
|DisplayName|**Modified On**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`modifiedon`|
|RequiredLevel|None|
|Type|DateTime|
|CanChangeDateTimeBehavior|False|
|DateTimeBehavior|UserLocal|
|Format|DateAndTime|
|ImeMode|Inactive|
|SourceTypeMask|0|

### <a name="BKMK_ModifiedOnBehalfBy"></a> ModifiedOnBehalfBy

|Property|Value|
|---|---|
|Description|**Unique identifier of the delegate user who modified the record.**|
|DisplayName|**Modified By (Delegate)**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`modifiedonbehalfby`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|systemuser|

### <a name="BKMK_OwnerIdName"></a> OwnerIdName

|Property|Value|
|---|---|
|Description|**Name of the owner**|
|DisplayName||
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`owneridname`|
|RequiredLevel|SystemRequired|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_OwnerIdYomiName"></a> OwnerIdYomiName

|Property|Value|
|---|---|
|Description|**Yomi name of the owner**|
|DisplayName||
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`owneridyominame`|
|RequiredLevel|SystemRequired|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_OwningBusinessUnit"></a> OwningBusinessUnit

|Property|Value|
|---|---|
|Description|**Unique identifier for the business unit that owns the record**|
|DisplayName|**Owning Business Unit**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`owningbusinessunit`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|businessunit|

### <a name="BKMK_OwningTeam"></a> OwningTeam

|Property|Value|
|---|---|
|Description|**Unique identifier for the team that owns the record.**|
|DisplayName|**Owning Team**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`owningteam`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|team|

### <a name="BKMK_OwningUser"></a> OwningUser

|Property|Value|
|---|---|
|Description|**Unique identifier for the user that owns the record.**|
|DisplayName|**Owning User**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`owninguser`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|systemuser|

### <a name="BKMK_VersionNumber"></a> VersionNumber

|Property|Value|
|---|---|
|Description|**Version Number**|
|DisplayName|**Version Number**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`versionnumber`|
|RequiredLevel|None|
|Type|BigInt|
|MaxValue|9223372036854775807|
|MinValue|-9223372036854775808|

## Many-to-One relationships

These relationships are many-to-one. Listed by **SchemaName**.

- [business_unit_msdyn_ocsentimentdailytopic](#BKMK_business_unit_msdyn_ocsentimentdailytopic)
- [lk_msdyn_ocsentimentdailytopic_createdby](#BKMK_lk_msdyn_ocsentimentdailytopic_createdby)
- [lk_msdyn_ocsentimentdailytopic_createdonbehalfby](#BKMK_lk_msdyn_ocsentimentdailytopic_createdonbehalfby)
- [lk_msdyn_ocsentimentdailytopic_modifiedby](#BKMK_lk_msdyn_ocsentimentdailytopic_modifiedby)
- [lk_msdyn_ocsentimentdailytopic_modifiedonbehalfby](#BKMK_lk_msdyn_ocsentimentdailytopic_modifiedonbehalfby)
- [owner_msdyn_ocsentimentdailytopic](#BKMK_owner_msdyn_ocsentimentdailytopic)
- [team_msdyn_ocsentimentdailytopic](#BKMK_team_msdyn_ocsentimentdailytopic)
- [user_msdyn_ocsentimentdailytopic](#BKMK_user_msdyn_ocsentimentdailytopic)

### <a name="BKMK_business_unit_msdyn_ocsentimentdailytopic"></a> business_unit_msdyn_ocsentimentdailytopic

One-To-Many Relationship: [businessunit business_unit_msdyn_ocsentimentdailytopic](businessunit.md#BKMK_business_unit_msdyn_ocsentimentdailytopic)

|Property|Value|
|---|---|
|ReferencedEntity|`businessunit`|
|ReferencedAttribute|`businessunitid`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencingEntityNavigationPropertyName|`owningbusinessunit`|
|IsHierarchical||
|CascadeConfiguration|Archive: `Restrict`<br />Assign: `NoCascade`<br />Delete: `Restrict`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_ocsentimentdailytopic_createdby"></a> lk_msdyn_ocsentimentdailytopic_createdby

One-To-Many Relationship: [systemuser lk_msdyn_ocsentimentdailytopic_createdby](systemuser.md#BKMK_lk_msdyn_ocsentimentdailytopic_createdby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdby`|
|ReferencingEntityNavigationPropertyName|`createdby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_ocsentimentdailytopic_createdonbehalfby"></a> lk_msdyn_ocsentimentdailytopic_createdonbehalfby

One-To-Many Relationship: [systemuser lk_msdyn_ocsentimentdailytopic_createdonbehalfby](systemuser.md#BKMK_lk_msdyn_ocsentimentdailytopic_createdonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdonbehalfby`|
|ReferencingEntityNavigationPropertyName|`createdonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_ocsentimentdailytopic_modifiedby"></a> lk_msdyn_ocsentimentdailytopic_modifiedby

One-To-Many Relationship: [systemuser lk_msdyn_ocsentimentdailytopic_modifiedby](systemuser.md#BKMK_lk_msdyn_ocsentimentdailytopic_modifiedby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedby`|
|ReferencingEntityNavigationPropertyName|`modifiedby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_ocsentimentdailytopic_modifiedonbehalfby"></a> lk_msdyn_ocsentimentdailytopic_modifiedonbehalfby

One-To-Many Relationship: [systemuser lk_msdyn_ocsentimentdailytopic_modifiedonbehalfby](systemuser.md#BKMK_lk_msdyn_ocsentimentdailytopic_modifiedonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedonbehalfby`|
|ReferencingEntityNavigationPropertyName|`modifiedonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_owner_msdyn_ocsentimentdailytopic"></a> owner_msdyn_ocsentimentdailytopic

One-To-Many Relationship: [owner owner_msdyn_ocsentimentdailytopic](owner.md#BKMK_owner_msdyn_ocsentimentdailytopic)

|Property|Value|
|---|---|
|ReferencedEntity|`owner`|
|ReferencedAttribute|`ownerid`|
|ReferencingAttribute|`ownerid`|
|ReferencingEntityNavigationPropertyName|`ownerid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_team_msdyn_ocsentimentdailytopic"></a> team_msdyn_ocsentimentdailytopic

One-To-Many Relationship: [team team_msdyn_ocsentimentdailytopic](team.md#BKMK_team_msdyn_ocsentimentdailytopic)

|Property|Value|
|---|---|
|ReferencedEntity|`team`|
|ReferencedAttribute|`teamid`|
|ReferencingAttribute|`owningteam`|
|ReferencingEntityNavigationPropertyName|`owningteam`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_user_msdyn_ocsentimentdailytopic"></a> user_msdyn_ocsentimentdailytopic

One-To-Many Relationship: [systemuser user_msdyn_ocsentimentdailytopic](systemuser.md#BKMK_user_msdyn_ocsentimentdailytopic)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`owninguser`|
|ReferencingEntityNavigationPropertyName|`owninguser`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|


## One-to-Many relationships

These relationships are one-to-many. Listed by **SchemaName**.

- [msdyn_msdyn_ocsentimentdailytopic_msdyn_ocliveworkitem_dailytopicid](#BKMK_msdyn_msdyn_ocsentimentdailytopic_msdyn_ocliveworkitem_dailytopicid)
- [msdyn_msdyn_ocsentimentdailytopic_msdyn_ocsentimentdailytopickeyword_dailytopicid](#BKMK_msdyn_msdyn_ocsentimentdailytopic_msdyn_ocsentimentdailytopickeyword_dailytopicid)
- [msdyn_msdyn_ocsentimentdailytopic_msdyn_ocsentimentdailytopictrending_basetopicid](#BKMK_msdyn_msdyn_ocsentimentdailytopic_msdyn_ocsentimentdailytopictrending_basetopicid)
- [msdyn_msdyn_ocsentimentdailytopic_msdyn_ocsentimentdailytopictrending_dailytopicid](#BKMK_msdyn_msdyn_ocsentimentdailytopic_msdyn_ocsentimentdailytopictrending_dailytopicid)
- [msdyn_ocsentimentdailytopic_AsyncOperations](#BKMK_msdyn_ocsentimentdailytopic_AsyncOperations)
- [msdyn_ocsentimentdailytopic_BulkDeleteFailures](#BKMK_msdyn_ocsentimentdailytopic_BulkDeleteFailures)
- [msdyn_ocsentimentdailytopic_DuplicateBaseRecord](#BKMK_msdyn_ocsentimentdailytopic_DuplicateBaseRecord)
- [msdyn_ocsentimentdailytopic_DuplicateMatchingRecord](#BKMK_msdyn_ocsentimentdailytopic_DuplicateMatchingRecord)
- [msdyn_ocsentimentdailytopic_MailboxTrackingFolders](#BKMK_msdyn_ocsentimentdailytopic_MailboxTrackingFolders)
- [msdyn_ocsentimentdailytopic_PrincipalObjectAttributeAccesses](#BKMK_msdyn_ocsentimentdailytopic_PrincipalObjectAttributeAccesses)
- [msdyn_ocsentimentdailytopic_ProcessSession](#BKMK_msdyn_ocsentimentdailytopic_ProcessSession)
- [msdyn_ocsentimentdailytopic_SyncErrors](#BKMK_msdyn_ocsentimentdailytopic_SyncErrors)

### <a name="BKMK_msdyn_msdyn_ocsentimentdailytopic_msdyn_ocliveworkitem_dailytopicid"></a> msdyn_msdyn_ocsentimentdailytopic_msdyn_ocliveworkitem_dailytopicid

Many-To-One Relationship: [msdyn_ocliveworkitem msdyn_msdyn_ocsentimentdailytopic_msdyn_ocliveworkitem_dailytopicid](msdyn_ocliveworkitem.md#BKMK_msdyn_msdyn_ocsentimentdailytopic_msdyn_ocliveworkitem_dailytopicid)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocliveworkitem`|
|ReferencingAttribute|`msdyn_dailytopicid`|
|ReferencedEntityNavigationPropertyName|`msdyn_msdyn_ocsentimentdailytopic_msdyn_ocliveworkitem_dailytopicid`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_msdyn_ocsentimentdailytopic_msdyn_ocsentimentdailytopickeyword_dailytopicid"></a> msdyn_msdyn_ocsentimentdailytopic_msdyn_ocsentimentdailytopickeyword_dailytopicid

Many-To-One Relationship: [msdyn_ocsentimentdailytopickeyword msdyn_msdyn_ocsentimentdailytopic_msdyn_ocsentimentdailytopickeyword_dailytopicid](msdyn_ocsentimentdailytopickeyword.md#BKMK_msdyn_msdyn_ocsentimentdailytopic_msdyn_ocsentimentdailytopickeyword_dailytopicid)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocsentimentdailytopickeyword`|
|ReferencingAttribute|`msdyn_dailytopicid`|
|ReferencedEntityNavigationPropertyName|`msdyn_msdyn_ocsentimentdailytopic_msdyn_ocsentimentdailytopickeyword_dailytopicid`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_msdyn_ocsentimentdailytopic_msdyn_ocsentimentdailytopictrending_basetopicid"></a> msdyn_msdyn_ocsentimentdailytopic_msdyn_ocsentimentdailytopictrending_basetopicid

Many-To-One Relationship: [msdyn_ocsentimentdailytopictrending msdyn_msdyn_ocsentimentdailytopic_msdyn_ocsentimentdailytopictrending_basetopicid](msdyn_ocsentimentdailytopictrending.md#BKMK_msdyn_msdyn_ocsentimentdailytopic_msdyn_ocsentimentdailytopictrending_basetopicid)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocsentimentdailytopictrending`|
|ReferencingAttribute|`msdyn_basetopicid`|
|ReferencedEntityNavigationPropertyName|`msdyn_msdyn_ocsentimentdailytopic_msdyn_ocsentimentdailytopictrending_basetopicid`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_msdyn_ocsentimentdailytopic_msdyn_ocsentimentdailytopictrending_dailytopicid"></a> msdyn_msdyn_ocsentimentdailytopic_msdyn_ocsentimentdailytopictrending_dailytopicid

Many-To-One Relationship: [msdyn_ocsentimentdailytopictrending msdyn_msdyn_ocsentimentdailytopic_msdyn_ocsentimentdailytopictrending_dailytopicid](msdyn_ocsentimentdailytopictrending.md#BKMK_msdyn_msdyn_ocsentimentdailytopic_msdyn_ocsentimentdailytopictrending_dailytopicid)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocsentimentdailytopictrending`|
|ReferencingAttribute|`msdyn_dailytopicid`|
|ReferencedEntityNavigationPropertyName|`msdyn_msdyn_ocsentimentdailytopic_msdyn_ocsentimentdailytopictrending_dailytopicid`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_ocsentimentdailytopic_AsyncOperations"></a> msdyn_ocsentimentdailytopic_AsyncOperations

Many-To-One Relationship: [asyncoperation msdyn_ocsentimentdailytopic_AsyncOperations](asyncoperation.md#BKMK_msdyn_ocsentimentdailytopic_AsyncOperations)

|Property|Value|
|---|---|
|ReferencingEntity|`asyncoperation`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_ocsentimentdailytopic_AsyncOperations`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_ocsentimentdailytopic_BulkDeleteFailures"></a> msdyn_ocsentimentdailytopic_BulkDeleteFailures

Many-To-One Relationship: [bulkdeletefailure msdyn_ocsentimentdailytopic_BulkDeleteFailures](bulkdeletefailure.md#BKMK_msdyn_ocsentimentdailytopic_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencingEntity|`bulkdeletefailure`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_ocsentimentdailytopic_BulkDeleteFailures`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_ocsentimentdailytopic_DuplicateBaseRecord"></a> msdyn_ocsentimentdailytopic_DuplicateBaseRecord

Many-To-One Relationship: [duplicaterecord msdyn_ocsentimentdailytopic_DuplicateBaseRecord](duplicaterecord.md#BKMK_msdyn_ocsentimentdailytopic_DuplicateBaseRecord)

|Property|Value|
|---|---|
|ReferencingEntity|`duplicaterecord`|
|ReferencingAttribute|`baserecordid`|
|ReferencedEntityNavigationPropertyName|`msdyn_ocsentimentdailytopic_DuplicateBaseRecord`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_ocsentimentdailytopic_DuplicateMatchingRecord"></a> msdyn_ocsentimentdailytopic_DuplicateMatchingRecord

Many-To-One Relationship: [duplicaterecord msdyn_ocsentimentdailytopic_DuplicateMatchingRecord](duplicaterecord.md#BKMK_msdyn_ocsentimentdailytopic_DuplicateMatchingRecord)

|Property|Value|
|---|---|
|ReferencingEntity|`duplicaterecord`|
|ReferencingAttribute|`duplicaterecordid`|
|ReferencedEntityNavigationPropertyName|`msdyn_ocsentimentdailytopic_DuplicateMatchingRecord`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_ocsentimentdailytopic_MailboxTrackingFolders"></a> msdyn_ocsentimentdailytopic_MailboxTrackingFolders

Many-To-One Relationship: [mailboxtrackingfolder msdyn_ocsentimentdailytopic_MailboxTrackingFolders](mailboxtrackingfolder.md#BKMK_msdyn_ocsentimentdailytopic_MailboxTrackingFolders)

|Property|Value|
|---|---|
|ReferencingEntity|`mailboxtrackingfolder`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_ocsentimentdailytopic_MailboxTrackingFolders`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_ocsentimentdailytopic_PrincipalObjectAttributeAccesses"></a> msdyn_ocsentimentdailytopic_PrincipalObjectAttributeAccesses

Many-To-One Relationship: [principalobjectattributeaccess msdyn_ocsentimentdailytopic_PrincipalObjectAttributeAccesses](principalobjectattributeaccess.md#BKMK_msdyn_ocsentimentdailytopic_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencingEntity|`principalobjectattributeaccess`|
|ReferencingAttribute|`objectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_ocsentimentdailytopic_PrincipalObjectAttributeAccesses`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_ocsentimentdailytopic_ProcessSession"></a> msdyn_ocsentimentdailytopic_ProcessSession

Many-To-One Relationship: [processsession msdyn_ocsentimentdailytopic_ProcessSession](processsession.md#BKMK_msdyn_ocsentimentdailytopic_ProcessSession)

|Property|Value|
|---|---|
|ReferencingEntity|`processsession`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_ocsentimentdailytopic_ProcessSession`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_ocsentimentdailytopic_SyncErrors"></a> msdyn_ocsentimentdailytopic_SyncErrors

Many-To-One Relationship: [syncerror msdyn_ocsentimentdailytopic_SyncErrors](syncerror.md#BKMK_msdyn_ocsentimentdailytopic_SyncErrors)

|Property|Value|
|---|---|
|ReferencingEntity|`syncerror`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_ocsentimentdailytopic_SyncErrors`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|



### See also

[Dataverse table/entity reference](/power-apps/developer/data-platform/reference/about-entity-reference)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   

