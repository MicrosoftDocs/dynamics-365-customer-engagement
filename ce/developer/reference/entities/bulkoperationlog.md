---
title: "Bulk Operation Log (BulkOperationLog) table/entity reference (Microsoft Dynamics 365)"
description: "Includes schema information and supported messages for the Bulk Operation Log (BulkOperationLog) table/entity with Microsoft Dynamics 365."
ms.topic: generated-reference
author: JimDaly
ms.author: jdaly
search.audienceType: 
  - developer
---

# Bulk Operation Log (BulkOperationLog) table/entity reference (Microsoft Dynamics 365)

Log used to track bulk operation execution, successes, and failures.

## Messages

The following table lists the messages for the Bulk Operation Log (BulkOperationLog) table.
Messages represent operations that can be performed on the table. They may also be events.

| Name <br />Is Event? |Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `Associate`<br />Event: True |[Associate records](/power-apps/developer/data-platform/webapi/associate-disassociate-entities-using-web-api) |[Associate records](/power-apps/developer/data-platform/org-service/entity-operations-associate-disassociate#use-the-associate-method-or-associaterequest)|
| `Create`<br />Event: True |`POST` /bulkoperationlogs<br />See [Create](/powerapps/developer/data-platform/webapi/create-entity-web-api) |[Create records](/power-apps/developer/data-platform/org-service/entity-operations-create#basic-create)|
| `Disassociate`<br />Event: True |[Disassociate records](/power-apps/developer/data-platform/webapi/associate-disassociate-entities-using-web-api) |[Disassociate records](/power-apps/developer/data-platform/org-service/entity-operations-associate-disassociate#use-the-disassociate-method-or-disassociaterequest)|
| `Retrieve`<br />Event: False |`GET` /bulkoperationlogs(*bulkoperationlogid*)<br />See [Retrieve](/powerapps/developer/data-platform/webapi/retrieve-entity-using-web-api) |[Retrieve records](/power-apps/developer/data-platform/org-service/entity-operations-retrieve)|
| `RetrieveMultiple`<br />Event: False |`GET` /bulkoperationlogs<br />See [Query data](/power-apps/developer/data-platform/webapi/query-data-web-api) |[Query data](/power-apps/developer/data-platform/org-service/entity-operations-query-data)|

## Properties

The following table lists selected properties for the Bulk Operation Log (BulkOperationLog) table.

|Property|Value|
| --- | --- |
| **DisplayName** | **Bulk Operation Log** |
| **DisplayCollectionName** | **Bulk Operation Logs** |
| **SchemaName** | `BulkOperationLog` |
| **CollectionSchemaName** | `BulkOperationLogs` |
| **EntitySetName** | `bulkoperationlogs`|
| **LogicalName** | `bulkoperationlog` |
| **LogicalCollectionName** | `bulkoperationlogs` |
| **PrimaryIdAttribute** | `bulkoperationlogid` |
| **PrimaryNameAttribute** |`name` |
| **TableType** | `Standard` |
| **OwnershipType** | `UserOwned` |

## Writable columns/attributes

These columns/attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [AdditionalInfo](#BKMK_AdditionalInfo)
- [BulkOperationId](#BKMK_BulkOperationId)
- [BulkOperationIdType](#BKMK_BulkOperationIdType)
- [BulkOperationLogId](#BKMK_BulkOperationLogId)
- [CampaignActivityId](#BKMK_CampaignActivityId)
- [CampaignActivityIdType](#BKMK_CampaignActivityIdType)
- [CreatedObjectId](#BKMK_CreatedObjectId)
- [CreatedObjectIdTypeCode](#BKMK_CreatedObjectIdTypeCode)
- [ErrorDescriptionFormatted](#BKMK_ErrorDescriptionFormatted)
- [ErrorNumberFormatted](#BKMK_ErrorNumberFormatted)
- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [Name](#BKMK_Name)
- [OverriddenCreatedOn](#BKMK_OverriddenCreatedOn)
- [RegardingObjectId](#BKMK_RegardingObjectId)
- [RegardingObjectIdTypeCode](#BKMK_RegardingObjectIdTypeCode)
- [TimeZoneRuleVersionNumber](#BKMK_TimeZoneRuleVersionNumber)
- [UTCConversionTimeZoneCode](#BKMK_UTCConversionTimeZoneCode)

### <a name="BKMK_AdditionalInfo"></a> AdditionalInfo

|Property|Value|
|---|---|
|Description|**Shows the data value at which an error occurred during the quick campaign.**|
|DisplayName|**Failed on Line**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`additionalinfo`|
|RequiredLevel|None|
|Type|Memo|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100000|

### <a name="BKMK_BulkOperationId"></a> BulkOperationId

|Property|Value|
|---|---|
|Description|**Shows the quick campaign record that the log applies to. This information is used to relate log data to the parent quick campaign.**|
|DisplayName|**Bulk Operation Number**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`bulkoperationid`|
|RequiredLevel|SystemRequired|
|Type|Lookup|
|Targets|bulkoperation|

### <a name="BKMK_BulkOperationIdType"></a> BulkOperationIdType

|Property|Value|
|---|---|
|Description||
|DisplayName||
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`bulkoperationidtype`|
|RequiredLevel|None|
|Type|EntityName|

### <a name="BKMK_BulkOperationLogId"></a> BulkOperationLogId

|Property|Value|
|---|---|
|Description|**Unique identifier of the bulk operation log.**|
|DisplayName|**Bulk Operation Log Number**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`bulkoperationlogid`|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|

### <a name="BKMK_CampaignActivityId"></a> CampaignActivityId

|Property|Value|
|---|---|
|Description|**Shows the campaign activity record that the log applies to. This information is used to relate log data to the parent campaign activity.**|
|DisplayName|**Campaign Activity Number**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`campaignactivityid`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|campaignactivity|

### <a name="BKMK_CampaignActivityIdType"></a> CampaignActivityIdType

|Property|Value|
|---|---|
|Description||
|DisplayName||
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`campaignactivityidtype`|
|RequiredLevel|None|
|Type|EntityName|

### <a name="BKMK_CreatedObjectId"></a> CreatedObjectId

|Property|Value|
|---|---|
|Description|**Choose the activity or other item created by the bulk operation.**|
|DisplayName|**Created Object**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`createdobjectid`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|account, activitypointer, contact, lead, opportunity|

### <a name="BKMK_CreatedObjectIdTypeCode"></a> CreatedObjectIdTypeCode

|Property|Value|
|---|---|
|Description||
|DisplayName||
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`createdobjectidtypecode`|
|RequiredLevel|None|
|Type|EntityName|

### <a name="BKMK_ErrorDescriptionFormatted"></a> ErrorDescriptionFormatted

|Property|Value|
|---|---|
|Description|**The error description formatted.**|
|DisplayName|**Error description**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`errordescriptionformatted`|
|RequiredLevel|None|
|Type|Memo|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|2000|

### <a name="BKMK_ErrorNumberFormatted"></a> ErrorNumberFormatted

|Property|Value|
|---|---|
|Description|**The error number formatted.**|
|DisplayName|**Error number**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`errornumberformatted`|
|RequiredLevel|None|
|Type|Memo|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|2000|

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

### <a name="BKMK_Name"></a> Name

|Property|Value|
|---|---|
|Description|**name**|
|DisplayName|**name**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`name`|
|RequiredLevel|ApplicationRequired|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

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

### <a name="BKMK_RegardingObjectId"></a> RegardingObjectId

|Property|Value|
|---|---|
|Description|**Choose the account, contact, lead, or list that the bulk operation log item applies to.**|
|DisplayName|**Customers**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`regardingobjectid`|
|RequiredLevel|ApplicationRequired|
|Type|Lookup|
|Targets|account, contact, lead|

### <a name="BKMK_RegardingObjectIdTypeCode"></a> RegardingObjectIdTypeCode

|Property|Value|
|---|---|
|Description||
|DisplayName||
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`regardingobjectidtypecode`|
|RequiredLevel|None|
|Type|EntityName|

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

- [ErrorNumber](#BKMK_ErrorNumber)
- [OwnerId](#BKMK_OwnerId)
- [OwnerIdName](#BKMK_OwnerIdName)
- [OwnerIdType](#BKMK_OwnerIdType)
- [OwnerIdYomiName](#BKMK_OwnerIdYomiName)
- [OwningBusinessUnit](#BKMK_OwningBusinessUnit)
- [OwningTeam](#BKMK_OwningTeam)
- [OwningUser](#BKMK_OwningUser)
- [VersionNumber](#BKMK_VersionNumber)

### <a name="BKMK_ErrorNumber"></a> ErrorNumber

|Property|Value|
|---|---|
|Description|**Shows the error code that is used to troubleshoot issues in the bulk operation.**|
|DisplayName|**Reason Id**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`errornumber`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|-2147483648|

### <a name="BKMK_OwnerId"></a> OwnerId

|Property|Value|
|---|---|
|Description|**Owner Id**|
|DisplayName|**Owner**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`ownerid`|
|RequiredLevel|ApplicationRequired|
|Type|Owner|
|Targets|systemuser, team|

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
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`owningbusinessunit`|
|RequiredLevel|SystemRequired|
|Type|Lookup|
|Targets||

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
|RequiredLevel|ApplicationRequired|
|Type|Lookup|
|Targets||

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

- [activity_pointer_BulkOperation_logs](#BKMK_activity_pointer_BulkOperation_logs)
- [BulkOperation_logs](#BKMK_BulkOperation_logs)
- [CampaignActivity_logs](#BKMK_CampaignActivity_logs)
- [CreatedAccount_BulkOperationLogs2](#BKMK_CreatedAccount_BulkOperationLogs2)
- [CreatedActivity_BulkOperationLogs](#BKMK_CreatedActivity_BulkOperationLogs)
- [CreatedContact_BulkOperationLogs](#BKMK_CreatedContact_BulkOperationLogs)
- [CreatedLead_BulkOperationLogs](#BKMK_CreatedLead_BulkOperationLogs)
- [CreatedOpportunity_BulkOperationLogs](#BKMK_CreatedOpportunity_BulkOperationLogs)
- [SourceAccount_BulkOperationLogs](#BKMK_SourceAccount_BulkOperationLogs)
- [SourceContact_BulkOperationLogs](#BKMK_SourceContact_BulkOperationLogs)
- [SourceLead_BulkOperationLogs](#BKMK_SourceLead_BulkOperationLogs)
- [team_bulkoperationlog](#BKMK_team_bulkoperationlog)
- [user_bulkoperationlog](#BKMK_user_bulkoperationlog)

### <a name="BKMK_activity_pointer_BulkOperation_logs"></a> activity_pointer_BulkOperation_logs

One-To-Many Relationship: [activitypointer activity_pointer_BulkOperation_logs](activitypointer.md#BKMK_activity_pointer_BulkOperation_logs)

|Property|Value|
|---|---|
|ReferencedEntity|`activitypointer`|
|ReferencedAttribute|`activityid`|
|ReferencingAttribute|`bulkoperationid`|
|ReferencingEntityNavigationPropertyName|`bulkoperationid_activitypointer`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_BulkOperation_logs"></a> BulkOperation_logs

One-To-Many Relationship: [bulkoperation BulkOperation_logs](bulkoperation.md#BKMK_BulkOperation_logs)

|Property|Value|
|---|---|
|ReferencedEntity|`bulkoperation`|
|ReferencedAttribute|`activityid`|
|ReferencingAttribute|`bulkoperationid`|
|ReferencingEntityNavigationPropertyName|`bulkoperationid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_CampaignActivity_logs"></a> CampaignActivity_logs

One-To-Many Relationship: [campaignactivity CampaignActivity_logs](campaignactivity.md#BKMK_CampaignActivity_logs)

|Property|Value|
|---|---|
|ReferencedEntity|`campaignactivity`|
|ReferencedAttribute|`activityid`|
|ReferencingAttribute|`campaignactivityid`|
|ReferencingEntityNavigationPropertyName|`CampaignActivityId_Logs`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_CreatedAccount_BulkOperationLogs2"></a> CreatedAccount_BulkOperationLogs2

One-To-Many Relationship: [account CreatedAccount_BulkOperationLogs2](account.md#BKMK_CreatedAccount_BulkOperationLogs2)

|Property|Value|
|---|---|
|ReferencedEntity|`account`|
|ReferencedAttribute|`accountid`|
|ReferencingAttribute|`createdobjectid`|
|ReferencingEntityNavigationPropertyName|`createdobjectid_account`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_CreatedActivity_BulkOperationLogs"></a> CreatedActivity_BulkOperationLogs

One-To-Many Relationship: [activitypointer CreatedActivity_BulkOperationLogs](activitypointer.md#BKMK_CreatedActivity_BulkOperationLogs)

|Property|Value|
|---|---|
|ReferencedEntity|`activitypointer`|
|ReferencedAttribute|`activityid`|
|ReferencingAttribute|`createdobjectid`|
|ReferencingEntityNavigationPropertyName|`createdobjectid_activitypointer`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_CreatedContact_BulkOperationLogs"></a> CreatedContact_BulkOperationLogs

One-To-Many Relationship: [contact CreatedContact_BulkOperationLogs](contact.md#BKMK_CreatedContact_BulkOperationLogs)

|Property|Value|
|---|---|
|ReferencedEntity|`contact`|
|ReferencedAttribute|`contactid`|
|ReferencingAttribute|`createdobjectid`|
|ReferencingEntityNavigationPropertyName|`createdobjectid_contact`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_CreatedLead_BulkOperationLogs"></a> CreatedLead_BulkOperationLogs

One-To-Many Relationship: [lead CreatedLead_BulkOperationLogs](lead.md#BKMK_CreatedLead_BulkOperationLogs)

|Property|Value|
|---|---|
|ReferencedEntity|`lead`|
|ReferencedAttribute|`leadid`|
|ReferencingAttribute|`createdobjectid`|
|ReferencingEntityNavigationPropertyName|`createdobjectid_lead`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_CreatedOpportunity_BulkOperationLogs"></a> CreatedOpportunity_BulkOperationLogs

One-To-Many Relationship: [opportunity CreatedOpportunity_BulkOperationLogs](opportunity.md#BKMK_CreatedOpportunity_BulkOperationLogs)

|Property|Value|
|---|---|
|ReferencedEntity|`opportunity`|
|ReferencedAttribute|`opportunityid`|
|ReferencingAttribute|`createdobjectid`|
|ReferencingEntityNavigationPropertyName|`createdobjectid_opportunity`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_SourceAccount_BulkOperationLogs"></a> SourceAccount_BulkOperationLogs

One-To-Many Relationship: [account SourceAccount_BulkOperationLogs](account.md#BKMK_SourceAccount_BulkOperationLogs)

|Property|Value|
|---|---|
|ReferencedEntity|`account`|
|ReferencedAttribute|`accountid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_account`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_SourceContact_BulkOperationLogs"></a> SourceContact_BulkOperationLogs

One-To-Many Relationship: [contact SourceContact_BulkOperationLogs](contact.md#BKMK_SourceContact_BulkOperationLogs)

|Property|Value|
|---|---|
|ReferencedEntity|`contact`|
|ReferencedAttribute|`contactid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_contact`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_SourceLead_BulkOperationLogs"></a> SourceLead_BulkOperationLogs

One-To-Many Relationship: [lead SourceLead_BulkOperationLogs](lead.md#BKMK_SourceLead_BulkOperationLogs)

|Property|Value|
|---|---|
|ReferencedEntity|`lead`|
|ReferencedAttribute|`leadid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_lead`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_team_bulkoperationlog"></a> team_bulkoperationlog

One-To-Many Relationship: [team team_bulkoperationlog](team.md#BKMK_team_bulkoperationlog)

|Property|Value|
|---|---|
|ReferencedEntity|`team`|
|ReferencedAttribute|`teamid`|
|ReferencingAttribute|`owningteam`|
|ReferencingEntityNavigationPropertyName|`owningteam`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_user_bulkoperationlog"></a> user_bulkoperationlog

One-To-Many Relationship: [systemuser user_bulkoperationlog](systemuser.md#BKMK_user_bulkoperationlog)

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

- [BulkOperationLog_AsyncOperations](#BKMK_BulkOperationLog_AsyncOperations)
- [BulkOperationLog_BulkDeleteFailures](#BKMK_BulkOperationLog_BulkDeleteFailures)
- [bulkoperationlog_MailboxTrackingFolders](#BKMK_bulkoperationlog_MailboxTrackingFolders)
- [bulkoperationlog_PrincipalObjectAttributeAccesses](#BKMK_bulkoperationlog_PrincipalObjectAttributeAccesses)
- [bulkoperationlog_SyncErrors](#BKMK_bulkoperationlog_SyncErrors)

### <a name="BKMK_BulkOperationLog_AsyncOperations"></a> BulkOperationLog_AsyncOperations

Many-To-One Relationship: [asyncoperation BulkOperationLog_AsyncOperations](asyncoperation.md#BKMK_BulkOperationLog_AsyncOperations)

|Property|Value|
|---|---|
|ReferencingEntity|`asyncoperation`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`BulkOperationLog_AsyncOperations`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_BulkOperationLog_BulkDeleteFailures"></a> BulkOperationLog_BulkDeleteFailures

Many-To-One Relationship: [bulkdeletefailure BulkOperationLog_BulkDeleteFailures](bulkdeletefailure.md#BKMK_BulkOperationLog_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencingEntity|`bulkdeletefailure`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`BulkOperationLog_BulkDeleteFailures`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_bulkoperationlog_MailboxTrackingFolders"></a> bulkoperationlog_MailboxTrackingFolders

Many-To-One Relationship: [mailboxtrackingfolder bulkoperationlog_MailboxTrackingFolders](mailboxtrackingfolder.md#BKMK_bulkoperationlog_MailboxTrackingFolders)

|Property|Value|
|---|---|
|ReferencingEntity|`mailboxtrackingfolder`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`bulkoperationlog_MailboxTrackingFolders`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_bulkoperationlog_PrincipalObjectAttributeAccesses"></a> bulkoperationlog_PrincipalObjectAttributeAccesses

Many-To-One Relationship: [principalobjectattributeaccess bulkoperationlog_PrincipalObjectAttributeAccesses](principalobjectattributeaccess.md#BKMK_bulkoperationlog_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencingEntity|`principalobjectattributeaccess`|
|ReferencingAttribute|`objectid`|
|ReferencedEntityNavigationPropertyName|`bulkoperationlog_PrincipalObjectAttributeAccesses`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_bulkoperationlog_SyncErrors"></a> bulkoperationlog_SyncErrors

Many-To-One Relationship: [syncerror bulkoperationlog_SyncErrors](syncerror.md#BKMK_bulkoperationlog_SyncErrors)

|Property|Value|
|---|---|
|ReferencingEntity|`syncerror`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`bulkoperationlog_SyncErrors`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|


## Many-to-Many relationships

These relationships are many-to-many. Listed by **SchemaName**.

- [BulkOperation_Accounts](#BKMK_BulkOperation_Accounts)
- [BulkOperation_Contacts](#BKMK_BulkOperation_Contacts)
- [BulkOperation_Leads](#BKMK_BulkOperation_Leads)
- [CampaignActivity_Accounts](#BKMK_CampaignActivity_Accounts)
- [CampaignActivity_Contacts](#BKMK_CampaignActivity_Contacts)
- [CampaignActivity_Leads](#BKMK_CampaignActivity_Leads)

### <a name="BKMK_BulkOperation_Accounts"></a> BulkOperation_Accounts


|Property|Value|
|---|---|
|IntersectEntityName|`bulkoperationlog`|
|IsCustomizable|False|
|SchemaName|`BulkOperation_Accounts`|

### <a name="BKMK_BulkOperation_Contacts"></a> BulkOperation_Contacts


|Property|Value|
|---|---|
|IntersectEntityName|`bulkoperationlog`|
|IsCustomizable|False|
|SchemaName|`BulkOperation_Contacts`|

### <a name="BKMK_BulkOperation_Leads"></a> BulkOperation_Leads


|Property|Value|
|---|---|
|IntersectEntityName|`bulkoperationlog`|
|IsCustomizable|False|
|SchemaName|`BulkOperation_Leads`|

### <a name="BKMK_CampaignActivity_Accounts"></a> CampaignActivity_Accounts


|Property|Value|
|---|---|
|IntersectEntityName|`bulkoperationlog`|
|IsCustomizable|False|
|SchemaName|`CampaignActivity_Accounts`|

### <a name="BKMK_CampaignActivity_Contacts"></a> CampaignActivity_Contacts


|Property|Value|
|---|---|
|IntersectEntityName|`bulkoperationlog`|
|IsCustomizable|False|
|SchemaName|`CampaignActivity_Contacts`|

### <a name="BKMK_CampaignActivity_Leads"></a> CampaignActivity_Leads


|Property|Value|
|---|---|
|IntersectEntityName|`bulkoperationlog`|
|IsCustomizable|False|
|SchemaName|`CampaignActivity_Leads`|



### See also

[Dataverse table/entity reference](/power-apps/developer/data-platform/reference/about-entity-reference)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   

