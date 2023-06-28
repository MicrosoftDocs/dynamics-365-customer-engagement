---
title: "BulkOperationLog table/entity reference (Dynamics 365 Sales) | Microsoft Docs"
description: "Includes schema information and supported messages for the BulkOperationLog table/entity."
ms.date: 02/17/2023
ms.service: dynamics-365-sales
ms.topic: "reference"
ms.assetid: 3948cc48-07c8-7f60-0608-71c37158ad7c
author: "udaykirang"
ms.author: "udag"
search.audienceType: 
  - developer
---

# BulkOperationLog table/entity reference

> [!NOTE]
> Unsure about table vs. entity? See [Developers: Understand terminology in Microsoft Dataverse](/powerapps/developer/data-platform/understand-terminology).

Log used to track bulk operation execution, successes, and failures.

**Added by**: Marketing Solution


## Messages

|Message|SDK Assembly|
|-|-|
|Create|<xref:Microsoft.Xrm.Sdk.Messages.CreateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Create*>|
|Retrieve|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Retrieve*>|
|RetrieveMultiple|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveMultipleRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.RetrieveMultiple*>|

## Properties

|Property|Value|
|--------|-----|
|CollectionSchemaName|BulkOperationLogs|
|DisplayCollectionName|Bulk Operation Logs|
|DisplayName|Bulk Operation Log|
|EntitySetName|bulkoperationlogs|
|IsBPFEntity|False|
|LogicalCollectionName|bulkoperationlogs|
|LogicalName|bulkoperationlog|
|OwnershipType|UserOwned|
|PrimaryIdAttribute|bulkoperationlogid|
|PrimaryNameAttribute|name|
|SchemaName|BulkOperationLog|

<a name="writable-attributes"></a>

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
|--------|-----|
|Description|Shows the data value at which an error occurred during the quick campaign.|
|DisplayName|Failed on Line|
|Format|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|IsValidForUpdate|False|
|LogicalName|additionalinfo|
|MaxLength|100000|
|RequiredLevel|None|
|Type|Memo|


### <a name="BKMK_BulkOperationId"></a> BulkOperationId

|Property|Value|
|--------|-----|
|Description|Shows the quick campaign record that the log applies to. This information is used to relate log data to the parent quick campaign.|
|DisplayName|Bulk Operation Number|
|IsValidForForm|True|
|IsValidForRead|True|
|IsValidForUpdate|False|
|LogicalName|bulkoperationid|
|RequiredLevel|SystemRequired|
|Targets|bulkoperation|
|Type|Lookup|


### <a name="BKMK_BulkOperationIdType"></a> BulkOperationIdType

**Added by**: Active Solution Solution

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|bulkoperationidtype|
|RequiredLevel|None|
|Type|EntityName|


### <a name="BKMK_BulkOperationLogId"></a> BulkOperationLogId

|Property|Value|
|--------|-----|
|Description|Unique identifier of the bulk operation log.|
|DisplayName|Bulk Operation Log Number|
|IsValidForForm|False|
|IsValidForRead|True|
|IsValidForUpdate|False|
|LogicalName|bulkoperationlogid|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|


### <a name="BKMK_CampaignActivityId"></a> CampaignActivityId

**Added by**: Marketing Patch Solution

|Property|Value|
|--------|-----|
|Description|Shows the campaign activity record that the log applies to. This information is used to relate log data to the parent campaign activity.|
|DisplayName|Campaign Activity Number|
|IsValidForForm|True|
|IsValidForRead|True|
|IsValidForUpdate|False|
|LogicalName|campaignactivityid|
|RequiredLevel|None|
|Targets|campaignactivity|
|Type|Lookup|


### <a name="BKMK_CampaignActivityIdType"></a> CampaignActivityIdType

**Added by**: Active Solution Solution

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|campaignactivityidtype|
|RequiredLevel|None|
|Type|EntityName|


### <a name="BKMK_CreatedObjectId"></a> CreatedObjectId

|Property|Value|
|--------|-----|
|Description|Choose the activity or other item created by the bulk operation.|
|DisplayName|Created Object|
|IsValidForForm|True|
|IsValidForRead|True|
|IsValidForUpdate|False|
|LogicalName|createdobjectid|
|RequiredLevel|None|
|Targets|account,activitypointer,contact,lead,opportunity|
|Type|Lookup|


### <a name="BKMK_CreatedObjectIdTypeCode"></a> CreatedObjectIdTypeCode

**Added by**: Active Solution Solution

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|IsValidForForm|False|
|IsValidForRead|True|
|IsValidForUpdate|False|
|LogicalName|createdobjectidtypecode|
|RequiredLevel|None|
|Type|EntityName|


### <a name="BKMK_ErrorDescriptionFormatted"></a> ErrorDescriptionFormatted

**Added by**: Marketing Patch Solution

|Property|Value|
|--------|-----|
|Description|The error description formatted.|
|DisplayName|Error description|
|Format|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|errordescriptionformatted|
|MaxLength|2000|
|RequiredLevel|None|
|Type|Memo|


### <a name="BKMK_ErrorNumberFormatted"></a> ErrorNumberFormatted

**Added by**: Marketing Patch Solution

|Property|Value|
|--------|-----|
|Description|The error number formatted.|
|DisplayName|Error number|
|Format|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|errornumberformatted|
|MaxLength|2000|
|RequiredLevel|None|
|Type|Memo|


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


### <a name="BKMK_Name"></a> Name

|Property|Value|
|--------|-----|
|Description|name|
|DisplayName|name|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|name|
|MaxLength|100|
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


### <a name="BKMK_RegardingObjectId"></a> RegardingObjectId

|Property|Value|
|--------|-----|
|Description|Choose the account, contact, lead, or list that the bulk operation log item applies to.|
|DisplayName|Customers|
|IsValidForForm|True|
|IsValidForRead|True|
|IsValidForUpdate|False|
|LogicalName|regardingobjectid|
|RequiredLevel|ApplicationRequired|
|Targets|account,contact,lead|
|Type|Lookup|


### <a name="BKMK_RegardingObjectIdTypeCode"></a> RegardingObjectIdTypeCode

**Added by**: Active Solution Solution

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|IsValidForForm|False|
|IsValidForRead|True|
|IsValidForUpdate|False|
|LogicalName|regardingobjectidtypecode|
|RequiredLevel|None|
|Type|EntityName|


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

- [BulkOperationIdName](#BKMK_BulkOperationIdName)
- [BulkOperationIdYomiName](#BKMK_BulkOperationIdYomiName)
- [CampaignActivityIdName](#BKMK_CampaignActivityIdName)
- [CampaignActivityIdYomiName](#BKMK_CampaignActivityIdYomiName)
- [CreatedObjectIdName](#BKMK_CreatedObjectIdName)
- [CreatedObjectIdYomiName](#BKMK_CreatedObjectIdYomiName)
- [ErrorNumber](#BKMK_ErrorNumber)
- [OwnerId](#BKMK_OwnerId)
- [OwnerIdName](#BKMK_OwnerIdName)
- [OwnerIdType](#BKMK_OwnerIdType)
- [OwnerIdYomiName](#BKMK_OwnerIdYomiName)
- [OwningBusinessUnit](#BKMK_OwningBusinessUnit)
- [OwningTeam](#BKMK_OwningTeam)
- [OwningUser](#BKMK_OwningUser)
- [RegardingObjectIdName](#BKMK_RegardingObjectIdName)
- [RegardingObjectIdYomiName](#BKMK_RegardingObjectIdYomiName)
- [VersionNumber](#BKMK_VersionNumber)


### <a name="BKMK_BulkOperationIdName"></a> BulkOperationIdName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|bulkoperationidname|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_BulkOperationIdYomiName"></a> BulkOperationIdYomiName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|bulkoperationidyominame|
|MaxLength|4000|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_CampaignActivityIdName"></a> CampaignActivityIdName

**Added by**: Marketing Patch Solution

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|campaignactivityidname|
|MaxLength|4000|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_CampaignActivityIdYomiName"></a> CampaignActivityIdYomiName

**Added by**: Marketing Patch Solution

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|campaignactivityidyominame|
|MaxLength|4000|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_CreatedObjectIdName"></a> CreatedObjectIdName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|createdobjectidname|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_CreatedObjectIdYomiName"></a> CreatedObjectIdYomiName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|createdobjectidyominame|
|MaxLength|4000|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_ErrorNumber"></a> ErrorNumber

|Property|Value|
|--------|-----|
|Description|Shows the error code that is used to troubleshoot issues in the bulk operation.|
|DisplayName|Reason Id|
|Format|None|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|errornumber|
|MaxValue|2147483647|
|MinValue|-2147483648|
|RequiredLevel|None|
|Type|Integer|


### <a name="BKMK_OwnerId"></a> OwnerId

|Property|Value|
|--------|-----|
|Description|Owner Id|
|DisplayName|Owner|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|ownerid|
|RequiredLevel|ApplicationRequired|
|Targets|systemuser,team|
|Type|Owner|


### <a name="BKMK_OwnerIdName"></a> OwnerIdName

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


### <a name="BKMK_OwnerIdType"></a> OwnerIdType

|Property|Value|
|--------|-----|
|Description|Owner Id Type|
|DisplayName||
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|owneridtype|
|RequiredLevel|SystemRequired|
|Type|EntityName|


### <a name="BKMK_OwnerIdYomiName"></a> OwnerIdYomiName

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

|Property|Value|
|--------|-----|
|Description|Unique identifier for the business unit that owns the record|
|DisplayName|Owning Business Unit|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|owningbusinessunit|
|RequiredLevel|None|
|Targets||
|Type|Lookup|


### <a name="BKMK_OwningTeam"></a> OwningTeam

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

|Property|Value|
|--------|-----|
|Description|Unique identifier for the user that owns the record.|
|DisplayName|Owning User|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|owninguser|
|RequiredLevel|ApplicationRequired|
|Targets||
|Type|Lookup|


### <a name="BKMK_RegardingObjectIdName"></a> RegardingObjectIdName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|regardingobjectidname|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_RegardingObjectIdYomiName"></a> RegardingObjectIdYomiName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|regardingobjectidyominame|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_VersionNumber"></a> VersionNumber

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

Each Many-To-One relationship is defined by a corresponding One-To-Many relationship with the related table. Listed by **SchemaName**.

- [CreatedAccount_BulkOperationLogs2](#BKMK_CreatedAccount_BulkOperationLogs2)
- [CreatedContact_BulkOperationLogs](#BKMK_CreatedContact_BulkOperationLogs)
- [CreatedLead_BulkOperationLogs](#BKMK_CreatedLead_BulkOperationLogs)
- [SourceAccount_BulkOperationLogs](#BKMK_SourceAccount_BulkOperationLogs)
- [BulkOperation_logs](#BKMK_BulkOperation_logs)
- [SourceContact_BulkOperationLogs](#BKMK_SourceContact_BulkOperationLogs)
- [SourceLead_BulkOperationLogs](#BKMK_SourceLead_BulkOperationLogs)
- [CampaignActivity_logs](#BKMK_CampaignActivity_logs)
- [CreatedOpportunity_BulkOperationLogs](#BKMK_CreatedOpportunity_BulkOperationLogs)


### <a name="BKMK_CreatedAccount_BulkOperationLogs2"></a> CreatedAccount_BulkOperationLogs2

**Added by**: System Solution Solution

See the [CreatedAccount_BulkOperationLogs2](account.md#BKMK_CreatedAccount_BulkOperationLogs2) one-to-many relationship for the [account](account.md) table/entity.

### <a name="BKMK_CreatedContact_BulkOperationLogs"></a> CreatedContact_BulkOperationLogs

**Added by**: System Solution Solution

See the [CreatedContact_BulkOperationLogs](contact.md#BKMK_CreatedContact_BulkOperationLogs) one-to-many relationship for the [contact](contact.md) table/entity.

### <a name="BKMK_CreatedLead_BulkOperationLogs"></a> CreatedLead_BulkOperationLogs

**Added by**: Lead Management Solution

See the [CreatedLead_BulkOperationLogs](lead.md#BKMK_CreatedLead_BulkOperationLogs) one-to-many relationship for the [lead](lead.md) table/entity.

### <a name="BKMK_SourceAccount_BulkOperationLogs"></a> SourceAccount_BulkOperationLogs

**Added by**: System Solution Solution

See the [SourceAccount_BulkOperationLogs](account.md#BKMK_SourceAccount_BulkOperationLogs) one-to-many relationship for the [account](account.md) table/entity.

### <a name="BKMK_BulkOperation_logs"></a> BulkOperation_logs

See the [BulkOperation_logs](bulkoperation.md#BKMK_BulkOperation_logs) one-to-many relationship for the [bulkoperation](bulkoperation.md) table/entity.

### <a name="BKMK_SourceContact_BulkOperationLogs"></a> SourceContact_BulkOperationLogs

**Added by**: System Solution Solution

See the [SourceContact_BulkOperationLogs](contact.md#BKMK_SourceContact_BulkOperationLogs) one-to-many relationship for the [contact](contact.md) table/entity.

### <a name="BKMK_SourceLead_BulkOperationLogs"></a> SourceLead_BulkOperationLogs

**Added by**: Lead Management Solution

See the [SourceLead_BulkOperationLogs](lead.md#BKMK_SourceLead_BulkOperationLogs) one-to-many relationship for the [lead](lead.md) table/entity.

### <a name="BKMK_CampaignActivity_logs"></a> CampaignActivity_logs

See the [CampaignActivity_logs](campaignactivity.md#BKMK_CampaignActivity_logs) one-to-many relationship for the [campaignactivity](campaignactivity.md) table/entity.

### <a name="BKMK_CreatedOpportunity_BulkOperationLogs"></a> CreatedOpportunity_BulkOperationLogs

**Added by**: Sales Solution

See the [CreatedOpportunity_BulkOperationLogs](opportunity.md#BKMK_CreatedOpportunity_BulkOperationLogs) one-to-many relationship for the [opportunity](opportunity.md) table/entity.
<a name="manytomany"></a>

## Many-To-Many Relationships

Relationship details provided where the BulkOperationLog table is the first table in the relationship. Listed by **SchemaName**.

- [BulkOperation_Accounts](#BKMK_BulkOperation_Accounts)
- [BulkOperation_Contacts](#BKMK_BulkOperation_Contacts)
- [BulkOperation_Leads](#BKMK_BulkOperation_Leads)
- [CampaignActivity_Accounts](#BKMK_CampaignActivity_Accounts)
- [CampaignActivity_Contacts](#BKMK_CampaignActivity_Contacts)
- [CampaignActivity_Leads](#BKMK_CampaignActivity_Leads)


### <a name="BKMK_BulkOperation_Accounts"></a> BulkOperation_Accounts

See the [BulkOperation_Accounts](bulkoperation.md#BKMK_BulkOperation_Accounts) many-to-many relationship for the [bulkoperation](bulkoperation.md) table/entity.

### <a name="BKMK_BulkOperation_Contacts"></a> BulkOperation_Contacts

See the [BulkOperation_Contacts](bulkoperation.md#BKMK_BulkOperation_Contacts) many-to-many relationship for the [bulkoperation](bulkoperation.md) table/entity.

### <a name="BKMK_BulkOperation_Leads"></a> BulkOperation_Leads

See the [BulkOperation_Leads](bulkoperation.md#BKMK_BulkOperation_Leads) many-to-many relationship for the [bulkoperation](bulkoperation.md) table/entity.

### <a name="BKMK_CampaignActivity_Accounts"></a> CampaignActivity_Accounts

See the [CampaignActivity_Accounts](campaignactivity.md#BKMK_CampaignActivity_Accounts) many-to-many relationship for the [campaignactivity](campaignactivity.md) table/entity.

### <a name="BKMK_CampaignActivity_Contacts"></a> CampaignActivity_Contacts

See the [CampaignActivity_Contacts](campaignactivity.md#BKMK_CampaignActivity_Contacts) many-to-many relationship for the [campaignactivity](campaignactivity.md) table/entity.

### <a name="BKMK_CampaignActivity_Leads"></a> CampaignActivity_Leads

See the [CampaignActivity_Leads](campaignactivity.md#BKMK_CampaignActivity_Leads) many-to-many relationship for the [campaignactivity](campaignactivity.md) table/entity.

### See also

[About the table reference](../about-entity-reference.md)<br />
[Web API Reference](/power-apps/developer/data-platform/webapi/reference/entitytypes)<br />
