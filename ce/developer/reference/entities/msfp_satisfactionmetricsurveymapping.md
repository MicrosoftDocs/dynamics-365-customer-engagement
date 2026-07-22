---
title: "Customer Voice Satisfaction Metric Survey Mapping (msfp_satisfactionmetricsurveymapping) table/entity reference (Microsoft Dynamics 365)"
description: "Includes schema information and supported messages for the Customer Voice Satisfaction Metric Survey Mapping (msfp_satisfactionmetricsurveymapping) table/entity with Microsoft Dynamics 365."
ms.topic: generated-reference
author: JimDaly
ms.author: jdaly
search.audienceType: 
  - developer
---

# Customer Voice Satisfaction Metric Survey Mapping (msfp_satisfactionmetricsurveymapping) table/entity reference (Microsoft Dynamics 365)

Mapping between satisfaction metric and survey

## Messages

The following table lists the messages for the Customer Voice Satisfaction Metric Survey Mapping (msfp_satisfactionmetricsurveymapping) table.
Messages represent operations that can be performed on the table. They may also be events.

| Name <br />Is Event? |Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `Assign`<br />Event: True |`PATCH` /msfp_satisfactionmetricsurveymappings(*msfp_satisfactionmetricsurveymappingid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `ownerid` property. |<xref:Microsoft.Crm.Sdk.Messages.AssignRequest>|
| `Associate`<br />Event: True |[Associate records](/power-apps/developer/data-platform/webapi/associate-disassociate-entities-using-web-api) |[Associate records](/power-apps/developer/data-platform/org-service/entity-operations-associate-disassociate#use-the-associate-method-or-associaterequest)|
| `BulkRetain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.BulkRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Create`<br />Event: True |`POST` /msfp_satisfactionmetricsurveymappings<br />See [Create](/powerapps/developer/data-platform/webapi/create-entity-web-api) |[Create records](/power-apps/developer/data-platform/org-service/entity-operations-create#basic-create)|
| `CreateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.CreateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.CreateMultipleRequest>|
| `Delete`<br />Event: True |`DELETE` /msfp_satisfactionmetricsurveymappings(*msfp_satisfactionmetricsurveymappingid*)<br />See [Delete](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-delete) |[Delete records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-delete)|
| `Disassociate`<br />Event: True |[Disassociate records](/power-apps/developer/data-platform/webapi/associate-disassociate-entities-using-web-api) |[Disassociate records](/power-apps/developer/data-platform/org-service/entity-operations-associate-disassociate#use-the-disassociate-method-or-disassociaterequest)|
| `GrantAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.GrantAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.GrantAccessRequest>|
| `IsValidStateTransition`<br />Event: False |<xref:Microsoft.Dynamics.CRM.IsValidStateTransition?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.IsValidStateTransitionRequest>|
| `ModifyAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.ModifyAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.ModifyAccessRequest>|
| `PurgeRetainedContent`<br />Event: True |<xref:Microsoft.Dynamics.CRM.PurgeRetainedContent?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Restore`<br />Event: True |<xref:Microsoft.Dynamics.CRM.Restore?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.Retain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retrieve`<br />Event: True |`GET` /msfp_satisfactionmetricsurveymappings(*msfp_satisfactionmetricsurveymappingid*)<br />See [Retrieve](/powerapps/developer/data-platform/webapi/retrieve-entity-using-web-api) |[Retrieve records](/power-apps/developer/data-platform/org-service/entity-operations-retrieve)|
| `RetrieveMultiple`<br />Event: True |`GET` /msfp_satisfactionmetricsurveymappings<br />See [Query data](/power-apps/developer/data-platform/webapi/query-data-web-api) |[Query data](/power-apps/developer/data-platform/org-service/entity-operations-query-data)|
| `RetrievePrincipalAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RetrievePrincipalAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RetrievePrincipalAccessRequest>|
| `RetrieveSharedPrincipalsAndAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RetrieveSharedPrincipalsAndAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RetrieveSharedPrincipalsAndAccessRequest>|
| `RevokeAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RevokeAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RevokeAccessRequest>|
| `RollbackRetain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RollbackRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `SetState`<br />Event: True |`PATCH` /msfp_satisfactionmetricsurveymappings(*msfp_satisfactionmetricsurveymappingid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `statecode` and `statuscode` properties. |<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|
| `Update`<br />Event: True |`PATCH` /msfp_satisfactionmetricsurveymappings(*msfp_satisfactionmetricsurveymappingid*)<br />See [Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) |[Update records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-update)|
| `UpdateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.UpdateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpdateMultipleRequest>|
| `Upsert`<br />Event: False |`PATCH` /msfp_satisfactionmetricsurveymappings(*msfp_satisfactionmetricsurveymappingid*)<br />See [Upsert a table row](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#upsert-a-table-row) |<xref:Microsoft.Xrm.Sdk.Messages.UpsertRequest>|
| `UpsertMultiple`<br />Event: False |<xref:Microsoft.Dynamics.CRM.UpsertMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpsertMultipleRequest>|
| `ValidateRetentionConfig`<br />Event: True |<xref:Microsoft.Dynamics.CRM.ValidateRetentionConfig?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|

## Properties

The following table lists selected properties for the Customer Voice Satisfaction Metric Survey Mapping (msfp_satisfactionmetricsurveymapping) table.

|Property|Value|
| --- | --- |
| **DisplayName** | **Customer Voice Satisfaction Metric Survey Mapping** |
| **DisplayCollectionName** | **Customer Voice Satisfaction Metric Survey Mappings** |
| **SchemaName** | `msfp_satisfactionmetricsurveymapping` |
| **CollectionSchemaName** | `msfp_satisfactionmetricsurveymappings` |
| **EntitySetName** | `msfp_satisfactionmetricsurveymappings`|
| **LogicalName** | `msfp_satisfactionmetricsurveymapping` |
| **LogicalCollectionName** | `msfp_satisfactionmetricsurveymappings` |
| **PrimaryIdAttribute** | `msfp_satisfactionmetricsurveymappingid` |
| **PrimaryNameAttribute** |`msfp_name` |
| **TableType** | `Standard` |
| **OwnershipType** | `UserOwned` |

## Writable columns/attributes

These columns/attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [msfp_name](#BKMK_msfp_name)
- [msfp_projectid](#BKMK_msfp_projectid)
- [msfp_satisfactionmetricid](#BKMK_msfp_satisfactionmetricid)
- [msfp_satisfactionmetricsurveymappingId](#BKMK_msfp_satisfactionmetricsurveymappingId)
- [msfp_satisfactionmetrictype](#BKMK_msfp_satisfactionmetrictype)
- [msfp_surveyid](#BKMK_msfp_surveyid)
- [msfp_surveyquestionid](#BKMK_msfp_surveyquestionid)
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

### <a name="BKMK_msfp_name"></a> msfp_name

|Property|Value|
|---|---|
|Description|**Concatenation of the satisfaction metric type and the survey friendly name**|
|DisplayName|**Name**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msfp_name`|
|RequiredLevel|ApplicationRequired|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|850|

### <a name="BKMK_msfp_projectid"></a> msfp_projectid

|Property|Value|
|---|---|
|Description|**Lookup to Customer Voice Project**|
|DisplayName|**Project**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msfp_projectid`|
|RequiredLevel|ApplicationRequired|
|Type|Lookup|
|Targets|msfp_project|

### <a name="BKMK_msfp_satisfactionmetricid"></a> msfp_satisfactionmetricid

|Property|Value|
|---|---|
|Description|**Lookup to Satisfaction Metric**|
|DisplayName|**Satisfaction Metric**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msfp_satisfactionmetricid`|
|RequiredLevel|ApplicationRequired|
|Type|Lookup|
|Targets|msfp_satisfactionmetric|

### <a name="BKMK_msfp_satisfactionmetricsurveymappingId"></a> msfp_satisfactionmetricsurveymappingId

|Property|Value|
|---|---|
|Description|**Unique identifier for entity instances**|
|DisplayName|**Customer Voice Satisfaction Metric Survey Mapping**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`msfp_satisfactionmetricsurveymappingid`|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|

### <a name="BKMK_msfp_satisfactionmetrictype"></a> msfp_satisfactionmetrictype

|Property|Value|
|---|---|
|Description||
|DisplayName|**Satisfaction Metric Type**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msfp_satisfactionmetrictype`|
|RequiredLevel|None|
|Type|Picklist|
|DefaultFormValue|-1|
|GlobalChoiceName|`msfp_satisfactionmetricsurveymapping_msfp_satisfactionmetrictype`|

#### msfp_satisfactionmetrictype Choices/Options

|Value|Label|
|---|---|
|1|**CSAT**|
|2|**NPS**|
|3|**Sentiment**|
|4|**Custom Score**|

### <a name="BKMK_msfp_surveyid"></a> msfp_surveyid

|Property|Value|
|---|---|
|Description|**Lookup to Customer Voice Survey**|
|DisplayName|**Survey**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msfp_surveyid`|
|RequiredLevel|ApplicationRequired|
|Type|Lookup|
|Targets|msfp_survey|

### <a name="BKMK_msfp_surveyquestionid"></a> msfp_surveyquestionid

|Property|Value|
|---|---|
|Description|**Lookup to Customer Voice Survey Question**|
|DisplayName|**Survey Question**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msfp_surveyquestionid`|
|RequiredLevel|ApplicationRequired|
|Type|Lookup|
|Targets|msfp_question|

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
|Description|**Status of the Customer Voice Satisfaction Metric Survey Mapping**|
|DisplayName|**Status**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statecode`|
|RequiredLevel|SystemRequired|
|Type|State|
|DefaultFormValue||
|GlobalChoiceName|`msfp_satisfactionmetricsurveymapping_statecode`|

#### statecode Choices/Options

|Value|Details|
|---|---|
|0|Label: **Active**<br />DefaultStatus: 1<br />InvariantName: `Active`|
|1|Label: **Inactive**<br />DefaultStatus: 2<br />InvariantName: `Inactive`|

### <a name="BKMK_statuscode"></a> statuscode

|Property|Value|
|---|---|
|Description|**Reason for the status of the Customer Voice Satisfaction Metric Survey Mapping**|
|DisplayName|**Status Reason**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statuscode`|
|RequiredLevel|None|
|Type|Status|
|DefaultFormValue||
|GlobalChoiceName|`msfp_satisfactionmetricsurveymapping_statuscode`|

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
|RequiredLevel|SystemRequired|
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

- [business_unit_msfp_satisfactionmetricsurveymapping](#BKMK_business_unit_msfp_satisfactionmetricsurveymapping)
- [lk_msfp_satisfactionmetricsurveymapping_createdby](#BKMK_lk_msfp_satisfactionmetricsurveymapping_createdby)
- [lk_msfp_satisfactionmetricsurveymapping_createdonbehalfby](#BKMK_lk_msfp_satisfactionmetricsurveymapping_createdonbehalfby)
- [lk_msfp_satisfactionmetricsurveymapping_modifiedby](#BKMK_lk_msfp_satisfactionmetricsurveymapping_modifiedby)
- [lk_msfp_satisfactionmetricsurveymapping_modifiedonbehalfby](#BKMK_lk_msfp_satisfactionmetricsurveymapping_modifiedonbehalfby)
- [msfp_satisfactionmetricsurveymapping_projectid_msfp_project](#BKMK_msfp_satisfactionmetricsurveymapping_projectid_msfp_project)
- [msfp_satisfactionmetricsurveymapping_satisfactionmetricid_msfp_satisfactionmetric](#BKMK_msfp_satisfactionmetricsurveymapping_satisfactionmetricid_msfp_satisfactionmetric)
- [msfp_satisfactionmetricsurveymapping_surveyid_msfp_survey](#BKMK_msfp_satisfactionmetricsurveymapping_surveyid_msfp_survey)
- [msfp_satisfactionmetricsurveymapping_surveyquestionid_msfp_question](#BKMK_msfp_satisfactionmetricsurveymapping_surveyquestionid_msfp_question)
- [owner_msfp_satisfactionmetricsurveymapping](#BKMK_owner_msfp_satisfactionmetricsurveymapping)
- [team_msfp_satisfactionmetricsurveymapping](#BKMK_team_msfp_satisfactionmetricsurveymapping)
- [user_msfp_satisfactionmetricsurveymapping](#BKMK_user_msfp_satisfactionmetricsurveymapping)

### <a name="BKMK_business_unit_msfp_satisfactionmetricsurveymapping"></a> business_unit_msfp_satisfactionmetricsurveymapping

One-To-Many Relationship: [businessunit business_unit_msfp_satisfactionmetricsurveymapping](businessunit.md#BKMK_business_unit_msfp_satisfactionmetricsurveymapping)

|Property|Value|
|---|---|
|ReferencedEntity|`businessunit`|
|ReferencedAttribute|`businessunitid`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencingEntityNavigationPropertyName|`owningbusinessunit`|
|IsHierarchical||
|CascadeConfiguration|Archive: `Restrict`<br />Assign: `NoCascade`<br />Delete: `Restrict`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msfp_satisfactionmetricsurveymapping_createdby"></a> lk_msfp_satisfactionmetricsurveymapping_createdby

One-To-Many Relationship: [systemuser lk_msfp_satisfactionmetricsurveymapping_createdby](systemuser.md#BKMK_lk_msfp_satisfactionmetricsurveymapping_createdby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdby`|
|ReferencingEntityNavigationPropertyName|`createdby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msfp_satisfactionmetricsurveymapping_createdonbehalfby"></a> lk_msfp_satisfactionmetricsurveymapping_createdonbehalfby

One-To-Many Relationship: [systemuser lk_msfp_satisfactionmetricsurveymapping_createdonbehalfby](systemuser.md#BKMK_lk_msfp_satisfactionmetricsurveymapping_createdonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdonbehalfby`|
|ReferencingEntityNavigationPropertyName|`createdonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msfp_satisfactionmetricsurveymapping_modifiedby"></a> lk_msfp_satisfactionmetricsurveymapping_modifiedby

One-To-Many Relationship: [systemuser lk_msfp_satisfactionmetricsurveymapping_modifiedby](systemuser.md#BKMK_lk_msfp_satisfactionmetricsurveymapping_modifiedby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedby`|
|ReferencingEntityNavigationPropertyName|`modifiedby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msfp_satisfactionmetricsurveymapping_modifiedonbehalfby"></a> lk_msfp_satisfactionmetricsurveymapping_modifiedonbehalfby

One-To-Many Relationship: [systemuser lk_msfp_satisfactionmetricsurveymapping_modifiedonbehalfby](systemuser.md#BKMK_lk_msfp_satisfactionmetricsurveymapping_modifiedonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedonbehalfby`|
|ReferencingEntityNavigationPropertyName|`modifiedonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msfp_satisfactionmetricsurveymapping_projectid_msfp_project"></a> msfp_satisfactionmetricsurveymapping_projectid_msfp_project

One-To-Many Relationship: [msfp_project msfp_satisfactionmetricsurveymapping_projectid_msfp_project](msfp_project.md#BKMK_msfp_satisfactionmetricsurveymapping_projectid_msfp_project)

|Property|Value|
|---|---|
|ReferencedEntity|`msfp_project`|
|ReferencedAttribute|`msfp_projectid`|
|ReferencingAttribute|`msfp_projectid`|
|ReferencingEntityNavigationPropertyName|`msfp_projectid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `RemoveLink`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msfp_satisfactionmetricsurveymapping_satisfactionmetricid_msfp_satisfactionmetric"></a> msfp_satisfactionmetricsurveymapping_satisfactionmetricid_msfp_satisfactionmetric

One-To-Many Relationship: [msfp_satisfactionmetric msfp_satisfactionmetricsurveymapping_satisfactionmetricid_msfp_satisfactionmetric](msfp_satisfactionmetric.md#BKMK_msfp_satisfactionmetricsurveymapping_satisfactionmetricid_msfp_satisfactionmetric)

|Property|Value|
|---|---|
|ReferencedEntity|`msfp_satisfactionmetric`|
|ReferencedAttribute|`msfp_satisfactionmetricid`|
|ReferencingAttribute|`msfp_satisfactionmetricid`|
|ReferencingEntityNavigationPropertyName|`msfp_satisfactionmetricid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `RemoveLink`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msfp_satisfactionmetricsurveymapping_surveyid_msfp_survey"></a> msfp_satisfactionmetricsurveymapping_surveyid_msfp_survey

One-To-Many Relationship: [msfp_survey msfp_satisfactionmetricsurveymapping_surveyid_msfp_survey](msfp_survey.md#BKMK_msfp_satisfactionmetricsurveymapping_surveyid_msfp_survey)

|Property|Value|
|---|---|
|ReferencedEntity|`msfp_survey`|
|ReferencedAttribute|`msfp_surveyid`|
|ReferencingAttribute|`msfp_surveyid`|
|ReferencingEntityNavigationPropertyName|`msfp_surveyid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `RemoveLink`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msfp_satisfactionmetricsurveymapping_surveyquestionid_msfp_question"></a> msfp_satisfactionmetricsurveymapping_surveyquestionid_msfp_question

One-To-Many Relationship: [msfp_question msfp_satisfactionmetricsurveymapping_surveyquestionid_msfp_question](msfp_question.md#BKMK_msfp_satisfactionmetricsurveymapping_surveyquestionid_msfp_question)

|Property|Value|
|---|---|
|ReferencedEntity|`msfp_question`|
|ReferencedAttribute|`msfp_questionid`|
|ReferencingAttribute|`msfp_surveyquestionid`|
|ReferencingEntityNavigationPropertyName|`msfp_surveyquestionid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `RemoveLink`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_owner_msfp_satisfactionmetricsurveymapping"></a> owner_msfp_satisfactionmetricsurveymapping

One-To-Many Relationship: [owner owner_msfp_satisfactionmetricsurveymapping](owner.md#BKMK_owner_msfp_satisfactionmetricsurveymapping)

|Property|Value|
|---|---|
|ReferencedEntity|`owner`|
|ReferencedAttribute|`ownerid`|
|ReferencingAttribute|`ownerid`|
|ReferencingEntityNavigationPropertyName|`ownerid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_team_msfp_satisfactionmetricsurveymapping"></a> team_msfp_satisfactionmetricsurveymapping

One-To-Many Relationship: [team team_msfp_satisfactionmetricsurveymapping](team.md#BKMK_team_msfp_satisfactionmetricsurveymapping)

|Property|Value|
|---|---|
|ReferencedEntity|`team`|
|ReferencedAttribute|`teamid`|
|ReferencingAttribute|`owningteam`|
|ReferencingEntityNavigationPropertyName|`owningteam`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_user_msfp_satisfactionmetricsurveymapping"></a> user_msfp_satisfactionmetricsurveymapping

One-To-Many Relationship: [systemuser user_msfp_satisfactionmetricsurveymapping](systemuser.md#BKMK_user_msfp_satisfactionmetricsurveymapping)

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

- [msfp_satisfactionmetricaggregate_satisfactionmetricsurveymappingid_msfp_satisfactionmetricsurveymap](#BKMK_msfp_satisfactionmetricaggregate_satisfactionmetricsurveymappingid_msfp_satisfactionmetricsurveymap)
- [msfp_satisfactionmetricsurveymapping_AsyncOperations](#BKMK_msfp_satisfactionmetricsurveymapping_AsyncOperations)
- [msfp_satisfactionmetricsurveymapping_BulkDeleteFailures](#BKMK_msfp_satisfactionmetricsurveymapping_BulkDeleteFailures)
- [msfp_satisfactionmetricsurveymapping_DuplicateBaseRecord](#BKMK_msfp_satisfactionmetricsurveymapping_DuplicateBaseRecord)
- [msfp_satisfactionmetricsurveymapping_DuplicateMatchingRecord](#BKMK_msfp_satisfactionmetricsurveymapping_DuplicateMatchingRecord)
- [msfp_satisfactionmetricsurveymapping_MailboxTrackingFolders](#BKMK_msfp_satisfactionmetricsurveymapping_MailboxTrackingFolders)
- [msfp_satisfactionmetricsurveymapping_PrincipalObjectAttributeAccesses](#BKMK_msfp_satisfactionmetricsurveymapping_PrincipalObjectAttributeAccesses)
- [msfp_satisfactionmetricsurveymapping_ProcessSession](#BKMK_msfp_satisfactionmetricsurveymapping_ProcessSession)
- [msfp_satisfactionmetricsurveymapping_SyncErrors](#BKMK_msfp_satisfactionmetricsurveymapping_SyncErrors)

### <a name="BKMK_msfp_satisfactionmetricaggregate_satisfactionmetricsurveymappingid_msfp_satisfactionmetricsurveymap"></a> msfp_satisfactionmetricaggregate_satisfactionmetricsurveymappingid_msfp_satisfactionmetricsurveymap

Many-To-One Relationship: [msfp_satisfactionmetricaggregate msfp_satisfactionmetricaggregate_satisfactionmetricsurveymappingid_msfp_satisfactionmetricsurveymap](msfp_satisfactionmetricaggregate.md#BKMK_msfp_satisfactionmetricaggregate_satisfactionmetricsurveymappingid_msfp_satisfactionmetricsurveymap)

|Property|Value|
|---|---|
|ReferencingEntity|`msfp_satisfactionmetricaggregate`|
|ReferencingAttribute|`msfp_satisfactionmetricsurveymappingid`|
|ReferencedEntityNavigationPropertyName|`msfp_satisfactionmetricaggregate_satisfactionmetricsurveymappingid_msfp_satisfactionmetricsurveymap`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msfp_satisfactionmetricsurveymapping_AsyncOperations"></a> msfp_satisfactionmetricsurveymapping_AsyncOperations

Many-To-One Relationship: [asyncoperation msfp_satisfactionmetricsurveymapping_AsyncOperations](asyncoperation.md#BKMK_msfp_satisfactionmetricsurveymapping_AsyncOperations)

|Property|Value|
|---|---|
|ReferencingEntity|`asyncoperation`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msfp_satisfactionmetricsurveymapping_AsyncOperations`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msfp_satisfactionmetricsurveymapping_BulkDeleteFailures"></a> msfp_satisfactionmetricsurveymapping_BulkDeleteFailures

Many-To-One Relationship: [bulkdeletefailure msfp_satisfactionmetricsurveymapping_BulkDeleteFailures](bulkdeletefailure.md#BKMK_msfp_satisfactionmetricsurveymapping_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencingEntity|`bulkdeletefailure`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msfp_satisfactionmetricsurveymapping_BulkDeleteFailures`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msfp_satisfactionmetricsurveymapping_DuplicateBaseRecord"></a> msfp_satisfactionmetricsurveymapping_DuplicateBaseRecord

Many-To-One Relationship: [duplicaterecord msfp_satisfactionmetricsurveymapping_DuplicateBaseRecord](duplicaterecord.md#BKMK_msfp_satisfactionmetricsurveymapping_DuplicateBaseRecord)

|Property|Value|
|---|---|
|ReferencingEntity|`duplicaterecord`|
|ReferencingAttribute|`baserecordid`|
|ReferencedEntityNavigationPropertyName|`msfp_satisfactionmetricsurveymapping_DuplicateBaseRecord`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msfp_satisfactionmetricsurveymapping_DuplicateMatchingRecord"></a> msfp_satisfactionmetricsurveymapping_DuplicateMatchingRecord

Many-To-One Relationship: [duplicaterecord msfp_satisfactionmetricsurveymapping_DuplicateMatchingRecord](duplicaterecord.md#BKMK_msfp_satisfactionmetricsurveymapping_DuplicateMatchingRecord)

|Property|Value|
|---|---|
|ReferencingEntity|`duplicaterecord`|
|ReferencingAttribute|`duplicaterecordid`|
|ReferencedEntityNavigationPropertyName|`msfp_satisfactionmetricsurveymapping_DuplicateMatchingRecord`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msfp_satisfactionmetricsurveymapping_MailboxTrackingFolders"></a> msfp_satisfactionmetricsurveymapping_MailboxTrackingFolders

Many-To-One Relationship: [mailboxtrackingfolder msfp_satisfactionmetricsurveymapping_MailboxTrackingFolders](mailboxtrackingfolder.md#BKMK_msfp_satisfactionmetricsurveymapping_MailboxTrackingFolders)

|Property|Value|
|---|---|
|ReferencingEntity|`mailboxtrackingfolder`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msfp_satisfactionmetricsurveymapping_MailboxTrackingFolders`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msfp_satisfactionmetricsurveymapping_PrincipalObjectAttributeAccesses"></a> msfp_satisfactionmetricsurveymapping_PrincipalObjectAttributeAccesses

Many-To-One Relationship: [principalobjectattributeaccess msfp_satisfactionmetricsurveymapping_PrincipalObjectAttributeAccesses](principalobjectattributeaccess.md#BKMK_msfp_satisfactionmetricsurveymapping_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencingEntity|`principalobjectattributeaccess`|
|ReferencingAttribute|`objectid`|
|ReferencedEntityNavigationPropertyName|`msfp_satisfactionmetricsurveymapping_PrincipalObjectAttributeAccesses`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msfp_satisfactionmetricsurveymapping_ProcessSession"></a> msfp_satisfactionmetricsurveymapping_ProcessSession

Many-To-One Relationship: [processsession msfp_satisfactionmetricsurveymapping_ProcessSession](processsession.md#BKMK_msfp_satisfactionmetricsurveymapping_ProcessSession)

|Property|Value|
|---|---|
|ReferencingEntity|`processsession`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msfp_satisfactionmetricsurveymapping_ProcessSession`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msfp_satisfactionmetricsurveymapping_SyncErrors"></a> msfp_satisfactionmetricsurveymapping_SyncErrors

Many-To-One Relationship: [syncerror msfp_satisfactionmetricsurveymapping_SyncErrors](syncerror.md#BKMK_msfp_satisfactionmetricsurveymapping_SyncErrors)

|Property|Value|
|---|---|
|ReferencingEntity|`syncerror`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msfp_satisfactionmetricsurveymapping_SyncErrors`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|



### See also

[Dataverse table/entity reference](/power-apps/developer/data-platform/reference/about-entity-reference)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   

