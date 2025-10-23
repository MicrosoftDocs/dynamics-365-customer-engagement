---
title: "Lead Intelligence Insight Entity Link (msdyn_leadintelligenceinsightentitylink) table/entity reference (Microsoft Dynamics 365)"
description: "Includes schema information and supported messages for the Lead Intelligence Insight Entity Link (msdyn_leadintelligenceinsightentitylink) table/entity with Microsoft Dynamics 365."
ms.topic: generated-reference
author: JimDaly
ms.author: jdaly
search.audienceType: 
  - developer
---

# Lead Intelligence Insight Entity Link (msdyn_leadintelligenceinsightentitylink) table/entity reference (Microsoft Dynamics 365)



## Messages

The following table lists the messages for the Lead Intelligence Insight Entity Link (msdyn_leadintelligenceinsightentitylink) table.
Messages represent operations that can be performed on the table. They may also be events.

| Name <br />Is Event? |Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `Assign`<br />Event: True |`PATCH` /msdyn_leadintelligenceinsightentitylinks(*msdyn_leadintelligenceinsightentitylinkid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `ownerid` property. |<xref:Microsoft.Crm.Sdk.Messages.AssignRequest>|
| `Associate`<br />Event: True |[Associate records](/power-apps/developer/data-platform/webapi/associate-disassociate-entities-using-web-api) |[Associate records](/power-apps/developer/data-platform/org-service/entity-operations-associate-disassociate#use-the-associate-method-or-associaterequest)|
| `BulkRetain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.BulkRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Create`<br />Event: True |`POST` /msdyn_leadintelligenceinsightentitylinks<br />See [Create](/powerapps/developer/data-platform/webapi/create-entity-web-api) |[Create records](/power-apps/developer/data-platform/org-service/entity-operations-create#basic-create)|
| `CreateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.CreateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.CreateMultipleRequest>|
| `Delete`<br />Event: True |`DELETE` /msdyn_leadintelligenceinsightentitylinks(*msdyn_leadintelligenceinsightentitylinkid*)<br />See [Delete](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-delete) |[Delete records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-delete)|
| `Disassociate`<br />Event: True |[Disassociate records](/power-apps/developer/data-platform/webapi/associate-disassociate-entities-using-web-api) |[Disassociate records](/power-apps/developer/data-platform/org-service/entity-operations-associate-disassociate#use-the-disassociate-method-or-disassociaterequest)|
| `GrantAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.GrantAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.GrantAccessRequest>|
| `IsValidStateTransition`<br />Event: False |<xref:Microsoft.Dynamics.CRM.IsValidStateTransition?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.IsValidStateTransitionRequest>|
| `ModifyAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.ModifyAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.ModifyAccessRequest>|
| `PurgeRetainedContent`<br />Event: True |<xref:Microsoft.Dynamics.CRM.PurgeRetainedContent?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Restore`<br />Event: True |<xref:Microsoft.Dynamics.CRM.Restore?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.Retain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retrieve`<br />Event: True |`GET` /msdyn_leadintelligenceinsightentitylinks(*msdyn_leadintelligenceinsightentitylinkid*)<br />See [Retrieve](/powerapps/developer/data-platform/webapi/retrieve-entity-using-web-api) |[Retrieve records](/power-apps/developer/data-platform/org-service/entity-operations-retrieve)|
| `RetrieveMultiple`<br />Event: True |`GET` /msdyn_leadintelligenceinsightentitylinks<br />See [Query data](/power-apps/developer/data-platform/webapi/query-data-web-api) |[Query data](/power-apps/developer/data-platform/org-service/entity-operations-query-data)|
| `RetrievePrincipalAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RetrievePrincipalAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RetrievePrincipalAccessRequest>|
| `RetrieveSharedPrincipalsAndAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RetrieveSharedPrincipalsAndAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RetrieveSharedPrincipalsAndAccessRequest>|
| `RevokeAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RevokeAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RevokeAccessRequest>|
| `RollbackRetain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RollbackRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `SetState`<br />Event: True |`PATCH` /msdyn_leadintelligenceinsightentitylinks(*msdyn_leadintelligenceinsightentitylinkid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `statecode` and `statuscode` properties. |<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|
| `Update`<br />Event: True |`PATCH` /msdyn_leadintelligenceinsightentitylinks(*msdyn_leadintelligenceinsightentitylinkid*)<br />See [Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) |[Update records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-update)|
| `UpdateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.UpdateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpdateMultipleRequest>|
| `Upsert`<br />Event: False |`PATCH` /msdyn_leadintelligenceinsightentitylinks(*msdyn_leadintelligenceinsightentitylinkid*)<br />See [Upsert a table row](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#upsert-a-table-row) |<xref:Microsoft.Xrm.Sdk.Messages.UpsertRequest>|
| `UpsertMultiple`<br />Event: False |<xref:Microsoft.Dynamics.CRM.UpsertMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpsertMultipleRequest>|
| `ValidateRetentionConfig`<br />Event: True |<xref:Microsoft.Dynamics.CRM.ValidateRetentionConfig?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|

## Properties

The following table lists selected properties for the Lead Intelligence Insight Entity Link (msdyn_leadintelligenceinsightentitylink) table.

|Property|Value|
| --- | --- |
| **DisplayName** | **Lead Intelligence Insight Entity Link** |
| **DisplayCollectionName** | **Lead Intelligence Insight Entity Links** |
| **SchemaName** | `msdyn_leadintelligenceinsightentitylink` |
| **CollectionSchemaName** | `msdyn_leadintelligenceinsightentitylinks` |
| **EntitySetName** | `msdyn_leadintelligenceinsightentitylinks`|
| **LogicalName** | `msdyn_leadintelligenceinsightentitylink` |
| **LogicalCollectionName** | `msdyn_leadintelligenceinsightentitylinks` |
| **PrimaryIdAttribute** | `msdyn_leadintelligenceinsightentitylinkid` |
| **PrimaryNameAttribute** |`msdyn_name` |
| **TableType** | `Standard` |
| **OwnershipType** | `UserOwned` |

## Writable columns/attributes

These columns/attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [msdyn_leadintelligenceinsightentitylinkId](#BKMK_msdyn_leadintelligenceinsightentitylinkId)
- [msdyn_leadintelligenceinsightId](#BKMK_msdyn_leadintelligenceinsightId)
- [msdyn_Name](#BKMK_msdyn_Name)
- [msdyn_regardingentityid](#BKMK_msdyn_regardingentityid)
- [msdyn_regardingentitytype](#BKMK_msdyn_regardingentitytype)
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

### <a name="BKMK_msdyn_leadintelligenceinsightentitylinkId"></a> msdyn_leadintelligenceinsightentitylinkId

|Property|Value|
|---|---|
|Description|**Unique identifier for entity instances**|
|DisplayName|**Lead Intelligence Insight Entity Link**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`msdyn_leadintelligenceinsightentitylinkid`|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|

### <a name="BKMK_msdyn_leadintelligenceinsightId"></a> msdyn_leadintelligenceinsightId

|Property|Value|
|---|---|
|Description||
|DisplayName|**Lead Intelligence Insight Id**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_leadintelligenceinsightid`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|msdyn_leadintelligenceinsight|

### <a name="BKMK_msdyn_Name"></a> msdyn_Name

|Property|Value|
|---|---|
|Description||
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
|MaxLength|850|

### <a name="BKMK_msdyn_regardingentityid"></a> msdyn_regardingentityid

|Property|Value|
|---|---|
|Description||
|DisplayName|**Regarding Entity Id**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_regardingentityid`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdyn_regardingentitytype"></a> msdyn_regardingentitytype

|Property|Value|
|---|---|
|Description||
|DisplayName|**Regarding Entity Type**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_regardingentitytype`|
|RequiredLevel|None|
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
|Description|**Status of the Lead Intelligence Insight Entity Link**|
|DisplayName|**Status**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statecode`|
|RequiredLevel|SystemRequired|
|Type|State|
|DefaultFormValue||
|GlobalChoiceName|`msdyn_leadintelligenceinsightentitylink_statecode`|

#### statecode Choices/Options

|Value|Details|
|---|---|
|0|Label: **Active**<br />DefaultStatus: 1<br />InvariantName: `Active`|
|1|Label: **Inactive**<br />DefaultStatus: 2<br />InvariantName: `Inactive`|

### <a name="BKMK_statuscode"></a> statuscode

|Property|Value|
|---|---|
|Description|**Reason for the status of the Lead Intelligence Insight Entity Link**|
|DisplayName|**Status Reason**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statuscode`|
|RequiredLevel|None|
|Type|Status|
|DefaultFormValue||
|GlobalChoiceName|`msdyn_leadintelligenceinsightentitylink_statuscode`|

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

- [business_unit_msdyn_leadintelligenceinsightentitylink](#BKMK_business_unit_msdyn_leadintelligenceinsightentitylink)
- [lk_msdyn_leadintelligenceinsightentitylink_createdby](#BKMK_lk_msdyn_leadintelligenceinsightentitylink_createdby)
- [lk_msdyn_leadintelligenceinsightentitylink_createdonbehalfby](#BKMK_lk_msdyn_leadintelligenceinsightentitylink_createdonbehalfby)
- [lk_msdyn_leadintelligenceinsightentitylink_modifiedby](#BKMK_lk_msdyn_leadintelligenceinsightentitylink_modifiedby)
- [lk_msdyn_leadintelligenceinsightentitylink_modifiedonbehalfby](#BKMK_lk_msdyn_leadintelligenceinsightentitylink_modifiedonbehalfby)
- [msdyn_leadintelligenceinsightentitylink_leadintelligenceinsightId_msdyn_leadintelligenceinsight](#BKMK_msdyn_leadintelligenceinsightentitylink_leadintelligenceinsightId_msdyn_leadintelligenceinsight)
- [owner_msdyn_leadintelligenceinsightentitylink](#BKMK_owner_msdyn_leadintelligenceinsightentitylink)
- [team_msdyn_leadintelligenceinsightentitylink](#BKMK_team_msdyn_leadintelligenceinsightentitylink)
- [user_msdyn_leadintelligenceinsightentitylink](#BKMK_user_msdyn_leadintelligenceinsightentitylink)

### <a name="BKMK_business_unit_msdyn_leadintelligenceinsightentitylink"></a> business_unit_msdyn_leadintelligenceinsightentitylink

One-To-Many Relationship: [businessunit business_unit_msdyn_leadintelligenceinsightentitylink](businessunit.md#BKMK_business_unit_msdyn_leadintelligenceinsightentitylink)

|Property|Value|
|---|---|
|ReferencedEntity|`businessunit`|
|ReferencedAttribute|`businessunitid`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencingEntityNavigationPropertyName|`owningbusinessunit`|
|IsHierarchical||
|CascadeConfiguration|Archive: `Restrict`<br />Assign: `NoCascade`<br />Delete: `Restrict`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_leadintelligenceinsightentitylink_createdby"></a> lk_msdyn_leadintelligenceinsightentitylink_createdby

One-To-Many Relationship: [systemuser lk_msdyn_leadintelligenceinsightentitylink_createdby](systemuser.md#BKMK_lk_msdyn_leadintelligenceinsightentitylink_createdby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdby`|
|ReferencingEntityNavigationPropertyName|`createdby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_leadintelligenceinsightentitylink_createdonbehalfby"></a> lk_msdyn_leadintelligenceinsightentitylink_createdonbehalfby

One-To-Many Relationship: [systemuser lk_msdyn_leadintelligenceinsightentitylink_createdonbehalfby](systemuser.md#BKMK_lk_msdyn_leadintelligenceinsightentitylink_createdonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdonbehalfby`|
|ReferencingEntityNavigationPropertyName|`createdonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_leadintelligenceinsightentitylink_modifiedby"></a> lk_msdyn_leadintelligenceinsightentitylink_modifiedby

One-To-Many Relationship: [systemuser lk_msdyn_leadintelligenceinsightentitylink_modifiedby](systemuser.md#BKMK_lk_msdyn_leadintelligenceinsightentitylink_modifiedby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedby`|
|ReferencingEntityNavigationPropertyName|`modifiedby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_leadintelligenceinsightentitylink_modifiedonbehalfby"></a> lk_msdyn_leadintelligenceinsightentitylink_modifiedonbehalfby

One-To-Many Relationship: [systemuser lk_msdyn_leadintelligenceinsightentitylink_modifiedonbehalfby](systemuser.md#BKMK_lk_msdyn_leadintelligenceinsightentitylink_modifiedonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedonbehalfby`|
|ReferencingEntityNavigationPropertyName|`modifiedonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_leadintelligenceinsightentitylink_leadintelligenceinsightId_msdyn_leadintelligenceinsight"></a> msdyn_leadintelligenceinsightentitylink_leadintelligenceinsightId_msdyn_leadintelligenceinsight

One-To-Many Relationship: [msdyn_leadintelligenceinsight msdyn_leadintelligenceinsightentitylink_leadintelligenceinsightId_msdyn_leadintelligenceinsight](msdyn_leadintelligenceinsight.md#BKMK_msdyn_leadintelligenceinsightentitylink_leadintelligenceinsightId_msdyn_leadintelligenceinsight)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_leadintelligenceinsight`|
|ReferencedAttribute|`msdyn_leadintelligenceinsightid`|
|ReferencingAttribute|`msdyn_leadintelligenceinsightid`|
|ReferencingEntityNavigationPropertyName|`msdyn_leadintelligenceinsightId`|
|IsHierarchical||
|CascadeConfiguration|Archive: `RemoveLink`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_owner_msdyn_leadintelligenceinsightentitylink"></a> owner_msdyn_leadintelligenceinsightentitylink

One-To-Many Relationship: [owner owner_msdyn_leadintelligenceinsightentitylink](owner.md#BKMK_owner_msdyn_leadintelligenceinsightentitylink)

|Property|Value|
|---|---|
|ReferencedEntity|`owner`|
|ReferencedAttribute|`ownerid`|
|ReferencingAttribute|`ownerid`|
|ReferencingEntityNavigationPropertyName|`ownerid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_team_msdyn_leadintelligenceinsightentitylink"></a> team_msdyn_leadintelligenceinsightentitylink

One-To-Many Relationship: [team team_msdyn_leadintelligenceinsightentitylink](team.md#BKMK_team_msdyn_leadintelligenceinsightentitylink)

|Property|Value|
|---|---|
|ReferencedEntity|`team`|
|ReferencedAttribute|`teamid`|
|ReferencingAttribute|`owningteam`|
|ReferencingEntityNavigationPropertyName|`owningteam`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_user_msdyn_leadintelligenceinsightentitylink"></a> user_msdyn_leadintelligenceinsightentitylink

One-To-Many Relationship: [systemuser user_msdyn_leadintelligenceinsightentitylink](systemuser.md#BKMK_user_msdyn_leadintelligenceinsightentitylink)

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

- [msdyn_leadintelligenceinsightentitylink_AsyncOperations](#BKMK_msdyn_leadintelligenceinsightentitylink_AsyncOperations)
- [msdyn_leadintelligenceinsightentitylink_BulkDeleteFailures](#BKMK_msdyn_leadintelligenceinsightentitylink_BulkDeleteFailures)
- [msdyn_leadintelligenceinsightentitylink_DuplicateBaseRecord](#BKMK_msdyn_leadintelligenceinsightentitylink_DuplicateBaseRecord)
- [msdyn_leadintelligenceinsightentitylink_DuplicateMatchingRecord](#BKMK_msdyn_leadintelligenceinsightentitylink_DuplicateMatchingRecord)
- [msdyn_leadintelligenceinsightentitylink_MailboxTrackingFolders](#BKMK_msdyn_leadintelligenceinsightentitylink_MailboxTrackingFolders)
- [msdyn_leadintelligenceinsightentitylink_PrincipalObjectAttributeAccesses](#BKMK_msdyn_leadintelligenceinsightentitylink_PrincipalObjectAttributeAccesses)
- [msdyn_leadintelligenceinsightentitylink_ProcessSession](#BKMK_msdyn_leadintelligenceinsightentitylink_ProcessSession)
- [msdyn_leadintelligenceinsightentitylink_SyncErrors](#BKMK_msdyn_leadintelligenceinsightentitylink_SyncErrors)

### <a name="BKMK_msdyn_leadintelligenceinsightentitylink_AsyncOperations"></a> msdyn_leadintelligenceinsightentitylink_AsyncOperations

Many-To-One Relationship: [asyncoperation msdyn_leadintelligenceinsightentitylink_AsyncOperations](asyncoperation.md#BKMK_msdyn_leadintelligenceinsightentitylink_AsyncOperations)

|Property|Value|
|---|---|
|ReferencingEntity|`asyncoperation`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_leadintelligenceinsightentitylink_AsyncOperations`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_leadintelligenceinsightentitylink_BulkDeleteFailures"></a> msdyn_leadintelligenceinsightentitylink_BulkDeleteFailures

Many-To-One Relationship: [bulkdeletefailure msdyn_leadintelligenceinsightentitylink_BulkDeleteFailures](bulkdeletefailure.md#BKMK_msdyn_leadintelligenceinsightentitylink_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencingEntity|`bulkdeletefailure`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_leadintelligenceinsightentitylink_BulkDeleteFailures`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_leadintelligenceinsightentitylink_DuplicateBaseRecord"></a> msdyn_leadintelligenceinsightentitylink_DuplicateBaseRecord

Many-To-One Relationship: [duplicaterecord msdyn_leadintelligenceinsightentitylink_DuplicateBaseRecord](duplicaterecord.md#BKMK_msdyn_leadintelligenceinsightentitylink_DuplicateBaseRecord)

|Property|Value|
|---|---|
|ReferencingEntity|`duplicaterecord`|
|ReferencingAttribute|`baserecordid`|
|ReferencedEntityNavigationPropertyName|`msdyn_leadintelligenceinsightentitylink_DuplicateBaseRecord`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_leadintelligenceinsightentitylink_DuplicateMatchingRecord"></a> msdyn_leadintelligenceinsightentitylink_DuplicateMatchingRecord

Many-To-One Relationship: [duplicaterecord msdyn_leadintelligenceinsightentitylink_DuplicateMatchingRecord](duplicaterecord.md#BKMK_msdyn_leadintelligenceinsightentitylink_DuplicateMatchingRecord)

|Property|Value|
|---|---|
|ReferencingEntity|`duplicaterecord`|
|ReferencingAttribute|`duplicaterecordid`|
|ReferencedEntityNavigationPropertyName|`msdyn_leadintelligenceinsightentitylink_DuplicateMatchingRecord`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_leadintelligenceinsightentitylink_MailboxTrackingFolders"></a> msdyn_leadintelligenceinsightentitylink_MailboxTrackingFolders

Many-To-One Relationship: [mailboxtrackingfolder msdyn_leadintelligenceinsightentitylink_MailboxTrackingFolders](mailboxtrackingfolder.md#BKMK_msdyn_leadintelligenceinsightentitylink_MailboxTrackingFolders)

|Property|Value|
|---|---|
|ReferencingEntity|`mailboxtrackingfolder`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_leadintelligenceinsightentitylink_MailboxTrackingFolders`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_leadintelligenceinsightentitylink_PrincipalObjectAttributeAccesses"></a> msdyn_leadintelligenceinsightentitylink_PrincipalObjectAttributeAccesses

Many-To-One Relationship: [principalobjectattributeaccess msdyn_leadintelligenceinsightentitylink_PrincipalObjectAttributeAccesses](principalobjectattributeaccess.md#BKMK_msdyn_leadintelligenceinsightentitylink_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencingEntity|`principalobjectattributeaccess`|
|ReferencingAttribute|`objectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_leadintelligenceinsightentitylink_PrincipalObjectAttributeAccesses`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_leadintelligenceinsightentitylink_ProcessSession"></a> msdyn_leadintelligenceinsightentitylink_ProcessSession

Many-To-One Relationship: [processsession msdyn_leadintelligenceinsightentitylink_ProcessSession](processsession.md#BKMK_msdyn_leadintelligenceinsightentitylink_ProcessSession)

|Property|Value|
|---|---|
|ReferencingEntity|`processsession`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_leadintelligenceinsightentitylink_ProcessSession`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_leadintelligenceinsightentitylink_SyncErrors"></a> msdyn_leadintelligenceinsightentitylink_SyncErrors

Many-To-One Relationship: [syncerror msdyn_leadintelligenceinsightentitylink_SyncErrors](syncerror.md#BKMK_msdyn_leadintelligenceinsightentitylink_SyncErrors)

|Property|Value|
|---|---|
|ReferencingEntity|`syncerror`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_leadintelligenceinsightentitylink_SyncErrors`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|



### See also

[Dataverse table/entity reference](/power-apps/developer/data-platform/reference/about-entity-reference)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   

