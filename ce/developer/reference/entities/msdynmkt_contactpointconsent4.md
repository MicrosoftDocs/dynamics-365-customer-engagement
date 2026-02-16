---
title: "Contact Point Consent (msdynmkt_contactpointconsent4) table/entity reference (Microsoft Dynamics 365)"
description: "Includes schema information and supported messages for the Contact Point Consent (msdynmkt_contactpointconsent4) table/entity with Microsoft Dynamics 365."
ms.topic: generated-reference
author: JimDaly
ms.author: jdaly
search.audienceType: 
  - developer
---

# Contact Point Consent (msdynmkt_contactpointconsent4) table/entity reference (Microsoft Dynamics 365)



## Messages

The following table lists the messages for the Contact Point Consent (msdynmkt_contactpointconsent4) table.
Messages represent operations that can be performed on the table. They may also be events.

| Name <br />Is Event? |Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `Assign`<br />Event: True |`PATCH` /msdynmkt_contactpointconsent4s(*msdynmkt_contactpointconsent4id*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `ownerid` property. |<xref:Microsoft.Crm.Sdk.Messages.AssignRequest>|
| `Associate`<br />Event: True |[Associate records](/power-apps/developer/data-platform/webapi/associate-disassociate-entities-using-web-api) |[Associate records](/power-apps/developer/data-platform/org-service/entity-operations-associate-disassociate#use-the-associate-method-or-associaterequest)|
| `BulkRetain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.BulkRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Create`<br />Event: True |`POST` /msdynmkt_contactpointconsent4s<br />See [Create](/powerapps/developer/data-platform/webapi/create-entity-web-api) |[Create records](/power-apps/developer/data-platform/org-service/entity-operations-create#basic-create)|
| `CreateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.CreateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.CreateMultipleRequest>|
| `Delete`<br />Event: True |`DELETE` /msdynmkt_contactpointconsent4s(*msdynmkt_contactpointconsent4id*)<br />See [Delete](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-delete) |[Delete records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-delete)|
| `Disassociate`<br />Event: True |[Disassociate records](/power-apps/developer/data-platform/webapi/associate-disassociate-entities-using-web-api) |[Disassociate records](/power-apps/developer/data-platform/org-service/entity-operations-associate-disassociate#use-the-disassociate-method-or-disassociaterequest)|
| `GrantAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.GrantAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.GrantAccessRequest>|
| `IsValidStateTransition`<br />Event: False |<xref:Microsoft.Dynamics.CRM.IsValidStateTransition?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.IsValidStateTransitionRequest>|
| `ModifyAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.ModifyAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.ModifyAccessRequest>|
| `PurgeRetainedContent`<br />Event: True |<xref:Microsoft.Dynamics.CRM.PurgeRetainedContent?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.Retain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retrieve`<br />Event: True |`GET` /msdynmkt_contactpointconsent4s(*msdynmkt_contactpointconsent4id*)<br />See [Retrieve](/powerapps/developer/data-platform/webapi/retrieve-entity-using-web-api) |[Retrieve records](/power-apps/developer/data-platform/org-service/entity-operations-retrieve)|
| `RetrieveMultiple`<br />Event: True |`GET` /msdynmkt_contactpointconsent4s<br />See [Query data](/power-apps/developer/data-platform/webapi/query-data-web-api) |[Query data](/power-apps/developer/data-platform/org-service/entity-operations-query-data)|
| `RetrievePrincipalAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RetrievePrincipalAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RetrievePrincipalAccessRequest>|
| `RetrieveSharedPrincipalsAndAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RetrieveSharedPrincipalsAndAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RetrieveSharedPrincipalsAndAccessRequest>|
| `RevokeAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RevokeAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RevokeAccessRequest>|
| `RollbackRetain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RollbackRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `SetState`<br />Event: True |`PATCH` /msdynmkt_contactpointconsent4s(*msdynmkt_contactpointconsent4id*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `statecode` and `statuscode` properties. |<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|
| `Update`<br />Event: True |`PATCH` /msdynmkt_contactpointconsent4s(*msdynmkt_contactpointconsent4id*)<br />See [Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) |[Update records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-update)|
| `UpdateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.UpdateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpdateMultipleRequest>|
| `Upsert`<br />Event: False |`PATCH` /msdynmkt_contactpointconsent4s(*msdynmkt_contactpointconsent4id*)<br />See [Upsert a table row](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#upsert-a-table-row) |<xref:Microsoft.Xrm.Sdk.Messages.UpsertRequest>|
| `UpsertMultiple`<br />Event: False |<xref:Microsoft.Dynamics.CRM.UpsertMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpsertMultipleRequest>|
| `ValidateRetentionConfig`<br />Event: True |<xref:Microsoft.Dynamics.CRM.ValidateRetentionConfig?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|

## Properties

The following table lists selected properties for the Contact Point Consent (msdynmkt_contactpointconsent4) table.

|Property|Value|
| --- | --- |
| **DisplayName** | **Contact Point Consent** |
| **DisplayCollectionName** | **Contact Point Consents** |
| **SchemaName** | `msdynmkt_contactpointconsent4` |
| **CollectionSchemaName** | `msdynmkt_contactpointconsent4s` |
| **EntitySetName** | `msdynmkt_contactpointconsent4s`|
| **LogicalName** | `msdynmkt_contactpointconsent4` |
| **LogicalCollectionName** | `msdynmkt_contactpointconsent4s` |
| **PrimaryIdAttribute** | `msdynmkt_contactpointconsent4id` |
| **PrimaryNameAttribute** |`msdynmkt_contactpointvalue` |
| **TableType** | `Standard` |
| **OwnershipType** | `UserOwned` |

## Writable columns/attributes

These columns/attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [msdynmkt_contactpointconsent4Id](#BKMK_msdynmkt_contactpointconsent4Id)
- [msdynmkt_contactpointconsenttype](#BKMK_msdynmkt_contactpointconsenttype)
- [msdynmkt_contactpointtype](#BKMK_msdynmkt_contactpointtype)
- [msdynmkt_contactpointvalue](#BKMK_msdynmkt_contactpointvalue)
- [msdynmkt_logicalreason](#BKMK_msdynmkt_logicalreason)
- [msdynmkt_messageId](#BKMK_msdynmkt_messageId)
- [msdynmkt_messageidIdType](#BKMK_msdynmkt_messageidIdType)
- [msdynmkt_migrationtimestamp](#BKMK_msdynmkt_migrationtimestamp)
- [msdynmkt_modifiedonbehalf](#BKMK_msdynmkt_modifiedonbehalf)
- [msdynmkt_purposeId](#BKMK_msdynmkt_purposeId)
- [msdynmkt_reason](#BKMK_msdynmkt_reason)
- [msdynmkt_source](#BKMK_msdynmkt_source)
- [msdynmkt_topicId](#BKMK_msdynmkt_topicId)
- [msdynmkt_uionly_value_tracking](#BKMK_msdynmkt_uionly_value_tracking)
- [msdynmkt_value](#BKMK_msdynmkt_value)
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

### <a name="BKMK_msdynmkt_contactpointconsent4Id"></a> msdynmkt_contactpointconsent4Id

|Property|Value|
|---|---|
|Description|**Unique identifier for entity instances**|
|DisplayName|**Contact Point Consent**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`msdynmkt_contactpointconsent4id`|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|

### <a name="BKMK_msdynmkt_contactpointconsenttype"></a> msdynmkt_contactpointconsenttype

|Property|Value|
|---|---|
|Description||
|DisplayName|**Consent type**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdynmkt_contactpointconsenttype`|
|RequiredLevel|None|
|Type|Picklist|
|DefaultFormValue|-1|
|GlobalChoiceName|`msdynmkt_consentlevel`|

#### msdynmkt_contactpointconsenttype Choices/Options

|Value|Label|
|---|---|
|534120000|**Purpose**|
|534120001|**Topic**|

### <a name="BKMK_msdynmkt_contactpointtype"></a> msdynmkt_contactpointtype

|Property|Value|
|---|---|
|Description||
|DisplayName|**Channel**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdynmkt_contactpointtype`|
|RequiredLevel|ApplicationRequired|
|Type|Picklist|
|DefaultFormValue|-1|
|GlobalChoiceName|`msdynmkt_contactpointtype`|

#### msdynmkt_contactpointtype Choices/Options

|Value|Label|
|---|---|
|534120000|**Email**|
|534120001|**Text Message**|
|534120002|**Custom**|
|534120003|**Voice**|

### <a name="BKMK_msdynmkt_contactpointvalue"></a> msdynmkt_contactpointvalue

|Property|Value|
|---|---|
|Description||
|DisplayName|**Contact point**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdynmkt_contactpointvalue`|
|RequiredLevel|ApplicationRequired|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|400|

### <a name="BKMK_msdynmkt_logicalreason"></a> msdynmkt_logicalreason

|Property|Value|
|---|---|
|Description||
|DisplayName|**Reason**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdynmkt_logicalreason`|
|RequiredLevel|ApplicationRequired|
|Type|Picklist|
|DefaultFormValue|-1|
|GlobalChoiceName|`msdynmkt_reason`|

#### msdynmkt_logicalreason Choices/Options

|Value|Label|
|---|---|
|534119999|**No reasons**|
|534120000|**Opt-in - Advertisement**|
|534120001|**Opt-in - Landing page**|
|534120002|**Opt-in - Events**|
|534120003|**Opt-out - Content was irrelevant**|
|534120004|**Opt-out - Received too frequently**|
|534120005|**Opt-out - Didn’t recall signing up**|
|534120006|**Opt-out - Privacy concerns**|
|534120007|**Opt-out - One-click unsubscribe**|

### <a name="BKMK_msdynmkt_messageId"></a> msdynmkt_messageId

|Property|Value|
|---|---|
|Description|**Reference to the email message.**|
|DisplayName|**Message**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdynmkt_messageid`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|email|

### <a name="BKMK_msdynmkt_messageidIdType"></a> msdynmkt_messageidIdType

|Property|Value|
|---|---|
|Description||
|DisplayName||
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`msdynmkt_messageididtype`|
|RequiredLevel|None|
|Type|EntityName|

### <a name="BKMK_msdynmkt_migrationtimestamp"></a> msdynmkt_migrationtimestamp

|Property|Value|
|---|---|
|Description||
|DisplayName|**Migration timestamp**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdynmkt_migrationtimestamp`|
|RequiredLevel|None|
|Type|DateTime|
|CanChangeDateTimeBehavior|True|
|DateTimeBehavior|TimeZoneIndependent|
|Format|DateAndTime|
|ImeMode|Auto|
|SourceTypeMask|0|

### <a name="BKMK_msdynmkt_modifiedonbehalf"></a> msdynmkt_modifiedonbehalf

|Property|Value|
|---|---|
|Description||
|DisplayName|**Who requested the change**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdynmkt_modifiedonbehalf`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|500|

### <a name="BKMK_msdynmkt_purposeId"></a> msdynmkt_purposeId

|Property|Value|
|---|---|
|Description|**Unique identifier for Purpose associated with Contact Point Consent.**|
|DisplayName|**Purpose**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdynmkt_purposeid`|
|RequiredLevel|ApplicationRequired|
|Type|Lookup|
|Targets|msdynmkt_purpose|

### <a name="BKMK_msdynmkt_reason"></a> msdynmkt_reason

|Property|Value|
|---|---|
|Description||
|DisplayName|**Reason Description**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdynmkt_reason`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|500|

### <a name="BKMK_msdynmkt_source"></a> msdynmkt_source

|Property|Value|
|---|---|
|Description||
|DisplayName|**Source**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdynmkt_source`|
|RequiredLevel|ApplicationRequired|
|Type|Picklist|
|DefaultFormValue|534120000|
|GlobalChoiceName|`msdynmkt_consentsource`|

#### msdynmkt_source Choices/Options

|Value|Label|
|---|---|
|534120000|**Internal**|
|534120001|**Preference page**|
|534120002|**Text message**|
|534120003|**Loaded**|
|534120004|**Preference Center**|
|534120005|**Realtime Marketing Form**|
|534120006|**Subscription Center**|
|534120007|**Email - list-unsubscribe**|

### <a name="BKMK_msdynmkt_topicId"></a> msdynmkt_topicId

|Property|Value|
|---|---|
|Description|**Unique identifier for Topic associated with Contact Point Consent.**|
|DisplayName|**Topic**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdynmkt_topicid`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|msdynmkt_topic|

### <a name="BKMK_msdynmkt_uionly_value_tracking"></a> msdynmkt_uionly_value_tracking

|Property|Value|
|---|---|
|Description||
|DisplayName|**Tracking (used in ui only)**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdynmkt_uionly_value_tracking`|
|RequiredLevel|None|
|Type|Picklist|
|DefaultFormValue|534120000|
|GlobalChoiceName|`msdynmkt_consentvalue`|

#### msdynmkt_uionly_value_tracking Choices/Options

|Value|Label|
|---|---|
|534120000|**Not Set**|
|534120001|**Opted In**|
|534120002|**Opted Out**|

### <a name="BKMK_msdynmkt_value"></a> msdynmkt_value

|Property|Value|
|---|---|
|Description||
|DisplayName|**Consent status**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdynmkt_value`|
|RequiredLevel|ApplicationRequired|
|Type|Picklist|
|DefaultFormValue|-1|
|GlobalChoiceName|`msdynmkt_consentvalue`|

#### msdynmkt_value Choices/Options

|Value|Label|
|---|---|
|534120000|**Not Set**|
|534120001|**Opted In**|
|534120002|**Opted Out**|

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
|Description|**Status of the Contact Point Consent**|
|DisplayName|**Status**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statecode`|
|RequiredLevel|SystemRequired|
|Type|State|
|DefaultFormValue||
|GlobalChoiceName|`msdynmkt_contactpointconsent4_statecode`|

#### statecode Choices/Options

|Value|Details|
|---|---|
|0|Label: **Active**<br />DefaultStatus: 1<br />InvariantName: `Active`|
|1|Label: **Inactive**<br />DefaultStatus: 2<br />InvariantName: `Inactive`|

### <a name="BKMK_statuscode"></a> statuscode

|Property|Value|
|---|---|
|Description|**Reason for the status of the Contact Point Consent**|
|DisplayName|**Status Reason**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statuscode`|
|RequiredLevel|None|
|Type|Status|
|DefaultFormValue||
|GlobalChoiceName|`msdynmkt_contactpointconsent4_statuscode`|

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

- [business_unit_msdynmkt_contactpointconsent4](#BKMK_business_unit_msdynmkt_contactpointconsent4)
- [email_msdynmkt_contactpointconsent4_messageid](#BKMK_email_msdynmkt_contactpointconsent4_messageid)
- [lk_msdynmkt_contactpointconsent4_createdby](#BKMK_lk_msdynmkt_contactpointconsent4_createdby)
- [lk_msdynmkt_contactpointconsent4_createdonbehalfby](#BKMK_lk_msdynmkt_contactpointconsent4_createdonbehalfby)
- [lk_msdynmkt_contactpointconsent4_modifiedby](#BKMK_lk_msdynmkt_contactpointconsent4_modifiedby)
- [lk_msdynmkt_contactpointconsent4_modifiedonbehalfby](#BKMK_lk_msdynmkt_contactpointconsent4_modifiedonbehalfby)
- [msdynmkt_msdynmkt_contactpointconsent4_purposeId_m](#BKMK_msdynmkt_msdynmkt_contactpointconsent4_purposeId_m)
- [msdynmkt_msdynmkt_contactpointconsent4_topicId_msd](#BKMK_msdynmkt_msdynmkt_contactpointconsent4_topicId_msd)
- [owner_msdynmkt_contactpointconsent4](#BKMK_owner_msdynmkt_contactpointconsent4)
- [team_msdynmkt_contactpointconsent4](#BKMK_team_msdynmkt_contactpointconsent4)
- [user_msdynmkt_contactpointconsent4](#BKMK_user_msdynmkt_contactpointconsent4)

### <a name="BKMK_business_unit_msdynmkt_contactpointconsent4"></a> business_unit_msdynmkt_contactpointconsent4

One-To-Many Relationship: [businessunit business_unit_msdynmkt_contactpointconsent4](businessunit.md#BKMK_business_unit_msdynmkt_contactpointconsent4)

|Property|Value|
|---|---|
|ReferencedEntity|`businessunit`|
|ReferencedAttribute|`businessunitid`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencingEntityNavigationPropertyName|`owningbusinessunit`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Restrict`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_email_msdynmkt_contactpointconsent4_messageid"></a> email_msdynmkt_contactpointconsent4_messageid

One-To-Many Relationship: [email email_msdynmkt_contactpointconsent4_messageid](email.md#BKMK_email_msdynmkt_contactpointconsent4_messageid)

|Property|Value|
|---|---|
|ReferencedEntity|`email`|
|ReferencedAttribute|`activityid`|
|ReferencingAttribute|`msdynmkt_messageid`|
|ReferencingEntityNavigationPropertyName|`email_msdynmkt_messageid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdynmkt_contactpointconsent4_createdby"></a> lk_msdynmkt_contactpointconsent4_createdby

One-To-Many Relationship: [systemuser lk_msdynmkt_contactpointconsent4_createdby](systemuser.md#BKMK_lk_msdynmkt_contactpointconsent4_createdby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdby`|
|ReferencingEntityNavigationPropertyName|`createdby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdynmkt_contactpointconsent4_createdonbehalfby"></a> lk_msdynmkt_contactpointconsent4_createdonbehalfby

One-To-Many Relationship: [systemuser lk_msdynmkt_contactpointconsent4_createdonbehalfby](systemuser.md#BKMK_lk_msdynmkt_contactpointconsent4_createdonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdonbehalfby`|
|ReferencingEntityNavigationPropertyName|`createdonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdynmkt_contactpointconsent4_modifiedby"></a> lk_msdynmkt_contactpointconsent4_modifiedby

One-To-Many Relationship: [systemuser lk_msdynmkt_contactpointconsent4_modifiedby](systemuser.md#BKMK_lk_msdynmkt_contactpointconsent4_modifiedby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedby`|
|ReferencingEntityNavigationPropertyName|`modifiedby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdynmkt_contactpointconsent4_modifiedonbehalfby"></a> lk_msdynmkt_contactpointconsent4_modifiedonbehalfby

One-To-Many Relationship: [systemuser lk_msdynmkt_contactpointconsent4_modifiedonbehalfby](systemuser.md#BKMK_lk_msdynmkt_contactpointconsent4_modifiedonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedonbehalfby`|
|ReferencingEntityNavigationPropertyName|`modifiedonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdynmkt_msdynmkt_contactpointconsent4_purposeId_m"></a> msdynmkt_msdynmkt_contactpointconsent4_purposeId_m

One-To-Many Relationship: [msdynmkt_purpose msdynmkt_msdynmkt_contactpointconsent4_purposeId_m](msdynmkt_purpose.md#BKMK_msdynmkt_msdynmkt_contactpointconsent4_purposeId_m)

|Property|Value|
|---|---|
|ReferencedEntity|`msdynmkt_purpose`|
|ReferencedAttribute|`msdynmkt_purposeid`|
|ReferencingAttribute|`msdynmkt_purposeid`|
|ReferencingEntityNavigationPropertyName|`msdynmkt_purposeId`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdynmkt_msdynmkt_contactpointconsent4_topicId_msd"></a> msdynmkt_msdynmkt_contactpointconsent4_topicId_msd

One-To-Many Relationship: [msdynmkt_topic msdynmkt_msdynmkt_contactpointconsent4_topicId_msd](msdynmkt_topic.md#BKMK_msdynmkt_msdynmkt_contactpointconsent4_topicId_msd)

|Property|Value|
|---|---|
|ReferencedEntity|`msdynmkt_topic`|
|ReferencedAttribute|`msdynmkt_topicid`|
|ReferencingAttribute|`msdynmkt_topicid`|
|ReferencingEntityNavigationPropertyName|`msdynmkt_topicId`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_owner_msdynmkt_contactpointconsent4"></a> owner_msdynmkt_contactpointconsent4

One-To-Many Relationship: [owner owner_msdynmkt_contactpointconsent4](owner.md#BKMK_owner_msdynmkt_contactpointconsent4)

|Property|Value|
|---|---|
|ReferencedEntity|`owner`|
|ReferencedAttribute|`ownerid`|
|ReferencingAttribute|`ownerid`|
|ReferencingEntityNavigationPropertyName|`ownerid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_team_msdynmkt_contactpointconsent4"></a> team_msdynmkt_contactpointconsent4

One-To-Many Relationship: [team team_msdynmkt_contactpointconsent4](team.md#BKMK_team_msdynmkt_contactpointconsent4)

|Property|Value|
|---|---|
|ReferencedEntity|`team`|
|ReferencedAttribute|`teamid`|
|ReferencingAttribute|`owningteam`|
|ReferencingEntityNavigationPropertyName|`owningteam`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_user_msdynmkt_contactpointconsent4"></a> user_msdynmkt_contactpointconsent4

One-To-Many Relationship: [systemuser user_msdynmkt_contactpointconsent4](systemuser.md#BKMK_user_msdynmkt_contactpointconsent4)

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

- [msdynmkt_contactpointconsent4_AsyncOperations](#BKMK_msdynmkt_contactpointconsent4_AsyncOperations)
- [msdynmkt_contactpointconsent4_BulkDeleteFailures](#BKMK_msdynmkt_contactpointconsent4_BulkDeleteFailures)
- [msdynmkt_contactpointconsent4_DuplicateBaseRecord](#BKMK_msdynmkt_contactpointconsent4_DuplicateBaseRecord)
- [msdynmkt_contactpointconsent4_DuplicateMatchingRecord](#BKMK_msdynmkt_contactpointconsent4_DuplicateMatchingRecord)
- [msdynmkt_contactpointconsent4_MailboxTrackingFolders](#BKMK_msdynmkt_contactpointconsent4_MailboxTrackingFolders)
- [msdynmkt_contactpointconsent4_PrincipalObjectAttributeAccesses](#BKMK_msdynmkt_contactpointconsent4_PrincipalObjectAttributeAccesses)
- [msdynmkt_contactpointconsent4_ProcessSession](#BKMK_msdynmkt_contactpointconsent4_ProcessSession)
- [msdynmkt_contactpointconsent4_SyncErrors](#BKMK_msdynmkt_contactpointconsent4_SyncErrors)

### <a name="BKMK_msdynmkt_contactpointconsent4_AsyncOperations"></a> msdynmkt_contactpointconsent4_AsyncOperations

Many-To-One Relationship: [asyncoperation msdynmkt_contactpointconsent4_AsyncOperations](asyncoperation.md#BKMK_msdynmkt_contactpointconsent4_AsyncOperations)

|Property|Value|
|---|---|
|ReferencingEntity|`asyncoperation`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdynmkt_contactpointconsent4_AsyncOperations`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdynmkt_contactpointconsent4_BulkDeleteFailures"></a> msdynmkt_contactpointconsent4_BulkDeleteFailures

Many-To-One Relationship: [bulkdeletefailure msdynmkt_contactpointconsent4_BulkDeleteFailures](bulkdeletefailure.md#BKMK_msdynmkt_contactpointconsent4_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencingEntity|`bulkdeletefailure`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdynmkt_contactpointconsent4_BulkDeleteFailures`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdynmkt_contactpointconsent4_DuplicateBaseRecord"></a> msdynmkt_contactpointconsent4_DuplicateBaseRecord

Many-To-One Relationship: [duplicaterecord msdynmkt_contactpointconsent4_DuplicateBaseRecord](duplicaterecord.md#BKMK_msdynmkt_contactpointconsent4_DuplicateBaseRecord)

|Property|Value|
|---|---|
|ReferencingEntity|`duplicaterecord`|
|ReferencingAttribute|`baserecordid`|
|ReferencedEntityNavigationPropertyName|`msdynmkt_contactpointconsent4_DuplicateBaseRecord`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdynmkt_contactpointconsent4_DuplicateMatchingRecord"></a> msdynmkt_contactpointconsent4_DuplicateMatchingRecord

Many-To-One Relationship: [duplicaterecord msdynmkt_contactpointconsent4_DuplicateMatchingRecord](duplicaterecord.md#BKMK_msdynmkt_contactpointconsent4_DuplicateMatchingRecord)

|Property|Value|
|---|---|
|ReferencingEntity|`duplicaterecord`|
|ReferencingAttribute|`duplicaterecordid`|
|ReferencedEntityNavigationPropertyName|`msdynmkt_contactpointconsent4_DuplicateMatchingRecord`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdynmkt_contactpointconsent4_MailboxTrackingFolders"></a> msdynmkt_contactpointconsent4_MailboxTrackingFolders

Many-To-One Relationship: [mailboxtrackingfolder msdynmkt_contactpointconsent4_MailboxTrackingFolders](mailboxtrackingfolder.md#BKMK_msdynmkt_contactpointconsent4_MailboxTrackingFolders)

|Property|Value|
|---|---|
|ReferencingEntity|`mailboxtrackingfolder`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdynmkt_contactpointconsent4_MailboxTrackingFolders`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdynmkt_contactpointconsent4_PrincipalObjectAttributeAccesses"></a> msdynmkt_contactpointconsent4_PrincipalObjectAttributeAccesses

Many-To-One Relationship: [principalobjectattributeaccess msdynmkt_contactpointconsent4_PrincipalObjectAttributeAccesses](principalobjectattributeaccess.md#BKMK_msdynmkt_contactpointconsent4_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencingEntity|`principalobjectattributeaccess`|
|ReferencingAttribute|`objectid`|
|ReferencedEntityNavigationPropertyName|`msdynmkt_contactpointconsent4_PrincipalObjectAttributeAccesses`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdynmkt_contactpointconsent4_ProcessSession"></a> msdynmkt_contactpointconsent4_ProcessSession

Many-To-One Relationship: [processsession msdynmkt_contactpointconsent4_ProcessSession](processsession.md#BKMK_msdynmkt_contactpointconsent4_ProcessSession)

|Property|Value|
|---|---|
|ReferencingEntity|`processsession`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdynmkt_contactpointconsent4_ProcessSession`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdynmkt_contactpointconsent4_SyncErrors"></a> msdynmkt_contactpointconsent4_SyncErrors

Many-To-One Relationship: [syncerror msdynmkt_contactpointconsent4_SyncErrors](syncerror.md#BKMK_msdynmkt_contactpointconsent4_SyncErrors)

|Property|Value|
|---|---|
|ReferencingEntity|`syncerror`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdynmkt_contactpointconsent4_SyncErrors`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|



### See also

[Dataverse table/entity reference](/power-apps/developer/data-platform/reference/about-entity-reference)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   

