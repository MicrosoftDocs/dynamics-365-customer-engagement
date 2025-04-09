---
title: "Sales Copilot Insight (msdyn_salescopilotinsight) table/entity reference (Microsoft Dynamics 365)"
description: "Includes schema information and supported messages for the Sales Copilot Insight (msdyn_salescopilotinsight) table/entity with Microsoft Dynamics 365."
ms.topic: generated-reference
author: JimDaly
ms.author: jdaly
search.audienceType: 
  - developer
---

# Sales Copilot Insight (msdyn_salescopilotinsight) table/entity reference (Microsoft Dynamics 365)



## Messages

The following table lists the messages for the Sales Copilot Insight (msdyn_salescopilotinsight) table.
Messages represent operations that can be performed on the table. They may also be events.

| Name <br />Is Event? |Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `Assign`<br />Event: True |`PATCH` /msdyn_salescopilotinsights(*msdyn_salescopilotinsightid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `ownerid` property. |<xref:Microsoft.Crm.Sdk.Messages.AssignRequest>|
| `Associate`<br />Event: True |[Associate records](/power-apps/developer/data-platform/webapi/associate-disassociate-entities-using-web-api) |[Associate records](/power-apps/developer/data-platform/org-service/entity-operations-associate-disassociate#use-the-associate-method-or-associaterequest)|
| `BulkRetain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.BulkRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Create`<br />Event: True |`POST` /msdyn_salescopilotinsights<br />See [Create](/powerapps/developer/data-platform/webapi/create-entity-web-api) |[Create records](/power-apps/developer/data-platform/org-service/entity-operations-create#basic-create)|
| `CreateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.CreateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.CreateMultipleRequest>|
| `Delete`<br />Event: True |`DELETE` /msdyn_salescopilotinsights(*msdyn_salescopilotinsightid*)<br />See [Delete](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-delete) |[Delete records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-delete)|
| `Disassociate`<br />Event: True |[Disassociate records](/power-apps/developer/data-platform/webapi/associate-disassociate-entities-using-web-api) |[Disassociate records](/power-apps/developer/data-platform/org-service/entity-operations-associate-disassociate#use-the-disassociate-method-or-disassociaterequest)|
| `GrantAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.GrantAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.GrantAccessRequest>|
| `IsValidStateTransition`<br />Event: False |<xref:Microsoft.Dynamics.CRM.IsValidStateTransition?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.IsValidStateTransitionRequest>|
| `ModifyAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.ModifyAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.ModifyAccessRequest>|
| `PurgeRetainedContent`<br />Event: True |<xref:Microsoft.Dynamics.CRM.PurgeRetainedContent?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Restore`<br />Event: True |<xref:Microsoft.Dynamics.CRM.Restore?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.Retain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retrieve`<br />Event: True |`GET` /msdyn_salescopilotinsights(*msdyn_salescopilotinsightid*)<br />See [Retrieve](/powerapps/developer/data-platform/webapi/retrieve-entity-using-web-api) |[Retrieve records](/power-apps/developer/data-platform/org-service/entity-operations-retrieve)|
| `RetrieveMultiple`<br />Event: True |`GET` /msdyn_salescopilotinsights<br />See [Query data](/power-apps/developer/data-platform/webapi/query-data-web-api) |[Query data](/power-apps/developer/data-platform/org-service/entity-operations-query-data)|
| `RetrievePrincipalAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RetrievePrincipalAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RetrievePrincipalAccessRequest>|
| `RetrieveSharedPrincipalsAndAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RetrieveSharedPrincipalsAndAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RetrieveSharedPrincipalsAndAccessRequest>|
| `RevokeAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RevokeAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RevokeAccessRequest>|
| `RollbackRetain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RollbackRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `SetState`<br />Event: True |`PATCH` /msdyn_salescopilotinsights(*msdyn_salescopilotinsightid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `statecode` and `statuscode` properties. |<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|
| `Update`<br />Event: True |`PATCH` /msdyn_salescopilotinsights(*msdyn_salescopilotinsightid*)<br />See [Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) |[Update records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-update)|
| `UpdateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.UpdateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpdateMultipleRequest>|
| `Upsert`<br />Event: False |`PATCH` /msdyn_salescopilotinsights(*msdyn_salescopilotinsightid*)<br />See [Upsert a table row](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#upsert-a-table-row) |<xref:Microsoft.Xrm.Sdk.Messages.UpsertRequest>|
| `UpsertMultiple`<br />Event: False |<xref:Microsoft.Dynamics.CRM.UpsertMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpsertMultipleRequest>|
| `ValidateRetentionConfig`<br />Event: True |<xref:Microsoft.Dynamics.CRM.ValidateRetentionConfig?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|

## Properties

The following table lists selected properties for the Sales Copilot Insight (msdyn_salescopilotinsight) table.

|Property|Value|
| --- | --- |
| **DisplayName** | **Sales Copilot Insight** |
| **DisplayCollectionName** | **Sales Copilot Insights** |
| **SchemaName** | `msdyn_salescopilotinsight` |
| **CollectionSchemaName** | `msdyn_salescopilotinsights` |
| **EntitySetName** | `msdyn_salescopilotinsights`|
| **LogicalName** | `msdyn_salescopilotinsight` |
| **LogicalCollectionName** | `msdyn_salescopilotinsights` |
| **PrimaryIdAttribute** | `msdyn_salescopilotinsightid` |
| **PrimaryNameAttribute** |`msdyn_name` |
| **TableType** | `Standard` |
| **OwnershipType** | `UserOwned` |

## Writable columns/attributes

These columns/attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [msdyn_activityid](#BKMK_msdyn_activityid)
- [msdyn_activityidIdType](#BKMK_msdyn_activityidIdType)
- [msdyn_ctatype](#BKMK_msdyn_ctatype)
- [msdyn_duedate](#BKMK_msdyn_duedate)
- [msdyn_insighttext](#BKMK_msdyn_insighttext)
- [msdyn_name](#BKMK_msdyn_name)
- [msdyn_salescopilotinsightId](#BKMK_msdyn_salescopilotinsightId)
- [msdyn_targetentityid](#BKMK_msdyn_targetentityid)
- [msdyn_targetentityidIdType](#BKMK_msdyn_targetentityidIdType)
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

### <a name="BKMK_msdyn_activityid"></a> msdyn_activityid

|Property|Value|
|---|---|
|Description|**Unique identifier of the activity for which insights are generated**|
|DisplayName|**Activity Id**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_activityid`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|appointment, email, phonecall, task|

### <a name="BKMK_msdyn_activityidIdType"></a> msdyn_activityidIdType

|Property|Value|
|---|---|
|Description||
|DisplayName||
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`msdyn_activityididtype`|
|RequiredLevel|None|
|Type|EntityName|

### <a name="BKMK_msdyn_ctatype"></a> msdyn_ctatype

|Property|Value|
|---|---|
|Description|**CTA Type of the Insight**|
|DisplayName|**CTA Type**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_ctatype`|
|RequiredLevel|None|
|Type|Picklist|
|DefaultFormValue|-1|
|GlobalChoiceName|`msdyn_salescopilotinsight_msdyn_ctatype`|

#### msdyn_ctatype Choices/Options

|Value|Label|
|---|---|
|1|**Email Reminder**|
|2|**Email Follow Up**|
|3|**Phone Call Reminder**|
|4|**Phone Call Follow Up**|
|5|**Meeting Reminder**|
|6|**Meeting Follow Up**|
|7|**Opportunity Catch Up**|
|8|**Account Catch Up**|
|9|**Lead Catch Up**|
|10|**NBA Emails Last Processing Time**|

### <a name="BKMK_msdyn_duedate"></a> msdyn_duedate

|Property|Value|
|---|---|
|Description|**The due date of the insight**|
|DisplayName|**Due Date**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_duedate`|
|RequiredLevel|None|
|Type|DateTime|
|CanChangeDateTimeBehavior|True|
|DateTimeBehavior|UserLocal|
|Format|DateAndTime|
|ImeMode|Auto|
|SourceTypeMask|0|

### <a name="BKMK_msdyn_insighttext"></a> msdyn_insighttext

|Property|Value|
|---|---|
|Description|**Insight data of the referenced entity record**|
|DisplayName|**Insight Text**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_insighttext`|
|RequiredLevel|ApplicationRequired|
|Type|Memo|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100000|

### <a name="BKMK_msdyn_name"></a> msdyn_name

|Property|Value|
|---|---|
|Description|**The name of the record.**|
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

### <a name="BKMK_msdyn_salescopilotinsightId"></a> msdyn_salescopilotinsightId

|Property|Value|
|---|---|
|Description|**Unique identifier for entity instances**|
|DisplayName|**Sales Copilot Insight**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`msdyn_salescopilotinsightid`|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|

### <a name="BKMK_msdyn_targetentityid"></a> msdyn_targetentityid

|Property|Value|
|---|---|
|Description|**Unique identifier of the referenced entity for which insights are generated.**|
|DisplayName|**Target Entity Id**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_targetentityid`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|account, contact, lead, opportunity|

### <a name="BKMK_msdyn_targetentityidIdType"></a> msdyn_targetentityidIdType

|Property|Value|
|---|---|
|Description||
|DisplayName||
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`msdyn_targetentityididtype`|
|RequiredLevel|None|
|Type|EntityName|

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
|Description|**Status of the Sales Copilot Insight**|
|DisplayName|**Status**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statecode`|
|RequiredLevel|SystemRequired|
|Type|State|
|DefaultFormValue||
|GlobalChoiceName|`msdyn_salescopilotinsight_statecode`|

#### statecode Choices/Options

|Value|Details|
|---|---|
|0|Label: **Active**<br />DefaultStatus: 1<br />InvariantName: `Active`|
|1|Label: **Inactive**<br />DefaultStatus: 2<br />InvariantName: `Inactive`|

### <a name="BKMK_statuscode"></a> statuscode

|Property|Value|
|---|---|
|Description|**Reason for the status of the Sales Copilot Insight**|
|DisplayName|**Status Reason**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statuscode`|
|RequiredLevel|None|
|Type|Status|
|DefaultFormValue||
|GlobalChoiceName|`msdyn_salescopilotinsight_statuscode`|

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

- [business_unit_msdyn_salescopilotinsight](#BKMK_business_unit_msdyn_salescopilotinsight)
- [lk_msdyn_salescopilotinsight_createdby](#BKMK_lk_msdyn_salescopilotinsight_createdby)
- [lk_msdyn_salescopilotinsight_createdonbehalfby](#BKMK_lk_msdyn_salescopilotinsight_createdonbehalfby)
- [lk_msdyn_salescopilotinsight_modifiedby](#BKMK_lk_msdyn_salescopilotinsight_modifiedby)
- [lk_msdyn_salescopilotinsight_modifiedonbehalfby](#BKMK_lk_msdyn_salescopilotinsight_modifiedonbehalfby)
- [msdyn_msdyn_salescopilotinsight_account_msdyn_targetentityid](#BKMK_msdyn_msdyn_salescopilotinsight_account_msdyn_targetentityid)
- [msdyn_msdyn_salescopilotinsight_appointment_msdyn_activityid](#BKMK_msdyn_msdyn_salescopilotinsight_appointment_msdyn_activityid)
- [msdyn_msdyn_salescopilotinsight_contact_msdyn_targetentityid](#BKMK_msdyn_msdyn_salescopilotinsight_contact_msdyn_targetentityid)
- [msdyn_msdyn_salescopilotinsight_email_msdyn_activityid](#BKMK_msdyn_msdyn_salescopilotinsight_email_msdyn_activityid)
- [msdyn_msdyn_salescopilotinsight_lead_msdyn_targetentityid](#BKMK_msdyn_msdyn_salescopilotinsight_lead_msdyn_targetentityid)
- [msdyn_msdyn_salescopilotinsight_opportunity_msdyn_targetentityid](#BKMK_msdyn_msdyn_salescopilotinsight_opportunity_msdyn_targetentityid)
- [msdyn_msdyn_salescopilotinsight_phonecall_msdyn_activityid](#BKMK_msdyn_msdyn_salescopilotinsight_phonecall_msdyn_activityid)
- [msdyn_msdyn_salescopilotinsight_task_msdyn_activityid](#BKMK_msdyn_msdyn_salescopilotinsight_task_msdyn_activityid)
- [owner_msdyn_salescopilotinsight](#BKMK_owner_msdyn_salescopilotinsight)
- [team_msdyn_salescopilotinsight](#BKMK_team_msdyn_salescopilotinsight)
- [user_msdyn_salescopilotinsight](#BKMK_user_msdyn_salescopilotinsight)

### <a name="BKMK_business_unit_msdyn_salescopilotinsight"></a> business_unit_msdyn_salescopilotinsight

One-To-Many Relationship: [businessunit business_unit_msdyn_salescopilotinsight](businessunit.md#BKMK_business_unit_msdyn_salescopilotinsight)

|Property|Value|
|---|---|
|ReferencedEntity|`businessunit`|
|ReferencedAttribute|`businessunitid`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencingEntityNavigationPropertyName|`owningbusinessunit`|
|IsHierarchical||
|CascadeConfiguration|Archive: `Restrict`<br />Assign: `NoCascade`<br />Delete: `Restrict`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_salescopilotinsight_createdby"></a> lk_msdyn_salescopilotinsight_createdby

One-To-Many Relationship: [systemuser lk_msdyn_salescopilotinsight_createdby](systemuser.md#BKMK_lk_msdyn_salescopilotinsight_createdby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdby`|
|ReferencingEntityNavigationPropertyName|`createdby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_salescopilotinsight_createdonbehalfby"></a> lk_msdyn_salescopilotinsight_createdonbehalfby

One-To-Many Relationship: [systemuser lk_msdyn_salescopilotinsight_createdonbehalfby](systemuser.md#BKMK_lk_msdyn_salescopilotinsight_createdonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdonbehalfby`|
|ReferencingEntityNavigationPropertyName|`createdonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_salescopilotinsight_modifiedby"></a> lk_msdyn_salescopilotinsight_modifiedby

One-To-Many Relationship: [systemuser lk_msdyn_salescopilotinsight_modifiedby](systemuser.md#BKMK_lk_msdyn_salescopilotinsight_modifiedby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedby`|
|ReferencingEntityNavigationPropertyName|`modifiedby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_salescopilotinsight_modifiedonbehalfby"></a> lk_msdyn_salescopilotinsight_modifiedonbehalfby

One-To-Many Relationship: [systemuser lk_msdyn_salescopilotinsight_modifiedonbehalfby](systemuser.md#BKMK_lk_msdyn_salescopilotinsight_modifiedonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedonbehalfby`|
|ReferencingEntityNavigationPropertyName|`modifiedonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_msdyn_salescopilotinsight_account_msdyn_targetentityid"></a> msdyn_msdyn_salescopilotinsight_account_msdyn_targetentityid

One-To-Many Relationship: [account msdyn_msdyn_salescopilotinsight_account_msdyn_targetentityid](account.md#BKMK_msdyn_msdyn_salescopilotinsight_account_msdyn_targetentityid)

|Property|Value|
|---|---|
|ReferencedEntity|`account`|
|ReferencedAttribute|`accountid`|
|ReferencingAttribute|`msdyn_targetentityid`|
|ReferencingEntityNavigationPropertyName|`msdyn_targetentityid_account`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `Cascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_msdyn_salescopilotinsight_appointment_msdyn_activityid"></a> msdyn_msdyn_salescopilotinsight_appointment_msdyn_activityid

One-To-Many Relationship: [appointment msdyn_msdyn_salescopilotinsight_appointment_msdyn_activityid](appointment.md#BKMK_msdyn_msdyn_salescopilotinsight_appointment_msdyn_activityid)

|Property|Value|
|---|---|
|ReferencedEntity|`appointment`|
|ReferencedAttribute|`activityid`|
|ReferencingAttribute|`msdyn_activityid`|
|ReferencingEntityNavigationPropertyName|`msdyn_activityid_appointment`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_msdyn_salescopilotinsight_contact_msdyn_targetentityid"></a> msdyn_msdyn_salescopilotinsight_contact_msdyn_targetentityid

One-To-Many Relationship: [contact msdyn_msdyn_salescopilotinsight_contact_msdyn_targetentityid](contact.md#BKMK_msdyn_msdyn_salescopilotinsight_contact_msdyn_targetentityid)

|Property|Value|
|---|---|
|ReferencedEntity|`contact`|
|ReferencedAttribute|`contactid`|
|ReferencingAttribute|`msdyn_targetentityid`|
|ReferencingEntityNavigationPropertyName|`msdyn_targetentityid_contact`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `Cascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_msdyn_salescopilotinsight_email_msdyn_activityid"></a> msdyn_msdyn_salescopilotinsight_email_msdyn_activityid

One-To-Many Relationship: [email msdyn_msdyn_salescopilotinsight_email_msdyn_activityid](email.md#BKMK_msdyn_msdyn_salescopilotinsight_email_msdyn_activityid)

|Property|Value|
|---|---|
|ReferencedEntity|`email`|
|ReferencedAttribute|`activityid`|
|ReferencingAttribute|`msdyn_activityid`|
|ReferencingEntityNavigationPropertyName|`msdyn_activityid_email`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_msdyn_salescopilotinsight_lead_msdyn_targetentityid"></a> msdyn_msdyn_salescopilotinsight_lead_msdyn_targetentityid

One-To-Many Relationship: [lead msdyn_msdyn_salescopilotinsight_lead_msdyn_targetentityid](lead.md#BKMK_msdyn_msdyn_salescopilotinsight_lead_msdyn_targetentityid)

|Property|Value|
|---|---|
|ReferencedEntity|`lead`|
|ReferencedAttribute|`leadid`|
|ReferencingAttribute|`msdyn_targetentityid`|
|ReferencingEntityNavigationPropertyName|`msdyn_targetentityid_lead`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `Cascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_msdyn_salescopilotinsight_opportunity_msdyn_targetentityid"></a> msdyn_msdyn_salescopilotinsight_opportunity_msdyn_targetentityid

One-To-Many Relationship: [opportunity msdyn_msdyn_salescopilotinsight_opportunity_msdyn_targetentityid](opportunity.md#BKMK_msdyn_msdyn_salescopilotinsight_opportunity_msdyn_targetentityid)

|Property|Value|
|---|---|
|ReferencedEntity|`opportunity`|
|ReferencedAttribute|`opportunityid`|
|ReferencingAttribute|`msdyn_targetentityid`|
|ReferencingEntityNavigationPropertyName|`msdyn_targetentityid_opportunity`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_msdyn_salescopilotinsight_phonecall_msdyn_activityid"></a> msdyn_msdyn_salescopilotinsight_phonecall_msdyn_activityid

One-To-Many Relationship: [phonecall msdyn_msdyn_salescopilotinsight_phonecall_msdyn_activityid](phonecall.md#BKMK_msdyn_msdyn_salescopilotinsight_phonecall_msdyn_activityid)

|Property|Value|
|---|---|
|ReferencedEntity|`phonecall`|
|ReferencedAttribute|`activityid`|
|ReferencingAttribute|`msdyn_activityid`|
|ReferencingEntityNavigationPropertyName|`msdyn_activityid_phonecall`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_msdyn_salescopilotinsight_task_msdyn_activityid"></a> msdyn_msdyn_salescopilotinsight_task_msdyn_activityid

One-To-Many Relationship: [task msdyn_msdyn_salescopilotinsight_task_msdyn_activityid](task.md#BKMK_msdyn_msdyn_salescopilotinsight_task_msdyn_activityid)

|Property|Value|
|---|---|
|ReferencedEntity|`task`|
|ReferencedAttribute|`activityid`|
|ReferencingAttribute|`msdyn_activityid`|
|ReferencingEntityNavigationPropertyName|`msdyn_activityid_task`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_owner_msdyn_salescopilotinsight"></a> owner_msdyn_salescopilotinsight

One-To-Many Relationship: [owner owner_msdyn_salescopilotinsight](owner.md#BKMK_owner_msdyn_salescopilotinsight)

|Property|Value|
|---|---|
|ReferencedEntity|`owner`|
|ReferencedAttribute|`ownerid`|
|ReferencingAttribute|`ownerid`|
|ReferencingEntityNavigationPropertyName|`ownerid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_team_msdyn_salescopilotinsight"></a> team_msdyn_salescopilotinsight

One-To-Many Relationship: [team team_msdyn_salescopilotinsight](team.md#BKMK_team_msdyn_salescopilotinsight)

|Property|Value|
|---|---|
|ReferencedEntity|`team`|
|ReferencedAttribute|`teamid`|
|ReferencingAttribute|`owningteam`|
|ReferencingEntityNavigationPropertyName|`owningteam`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_user_msdyn_salescopilotinsight"></a> user_msdyn_salescopilotinsight

One-To-Many Relationship: [systemuser user_msdyn_salescopilotinsight](systemuser.md#BKMK_user_msdyn_salescopilotinsight)

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

- [msdyn_salescopilotinsight_AsyncOperations](#BKMK_msdyn_salescopilotinsight_AsyncOperations)
- [msdyn_salescopilotinsight_BulkDeleteFailures](#BKMK_msdyn_salescopilotinsight_BulkDeleteFailures)
- [msdyn_salescopilotinsight_DuplicateBaseRecord](#BKMK_msdyn_salescopilotinsight_DuplicateBaseRecord)
- [msdyn_salescopilotinsight_DuplicateMatchingRecord](#BKMK_msdyn_salescopilotinsight_DuplicateMatchingRecord)
- [msdyn_salescopilotinsight_MailboxTrackingFolders](#BKMK_msdyn_salescopilotinsight_MailboxTrackingFolders)
- [msdyn_salescopilotinsight_PrincipalObjectAttributeAccesses](#BKMK_msdyn_salescopilotinsight_PrincipalObjectAttributeAccesses)
- [msdyn_salescopilotinsight_ProcessSession](#BKMK_msdyn_salescopilotinsight_ProcessSession)
- [msdyn_salescopilotinsight_SyncErrors](#BKMK_msdyn_salescopilotinsight_SyncErrors)

### <a name="BKMK_msdyn_salescopilotinsight_AsyncOperations"></a> msdyn_salescopilotinsight_AsyncOperations

Many-To-One Relationship: [asyncoperation msdyn_salescopilotinsight_AsyncOperations](asyncoperation.md#BKMK_msdyn_salescopilotinsight_AsyncOperations)

|Property|Value|
|---|---|
|ReferencingEntity|`asyncoperation`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_salescopilotinsight_AsyncOperations`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_salescopilotinsight_BulkDeleteFailures"></a> msdyn_salescopilotinsight_BulkDeleteFailures

Many-To-One Relationship: [bulkdeletefailure msdyn_salescopilotinsight_BulkDeleteFailures](bulkdeletefailure.md#BKMK_msdyn_salescopilotinsight_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencingEntity|`bulkdeletefailure`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_salescopilotinsight_BulkDeleteFailures`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_salescopilotinsight_DuplicateBaseRecord"></a> msdyn_salescopilotinsight_DuplicateBaseRecord

Many-To-One Relationship: [duplicaterecord msdyn_salescopilotinsight_DuplicateBaseRecord](duplicaterecord.md#BKMK_msdyn_salescopilotinsight_DuplicateBaseRecord)

|Property|Value|
|---|---|
|ReferencingEntity|`duplicaterecord`|
|ReferencingAttribute|`baserecordid`|
|ReferencedEntityNavigationPropertyName|`msdyn_salescopilotinsight_DuplicateBaseRecord`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_salescopilotinsight_DuplicateMatchingRecord"></a> msdyn_salescopilotinsight_DuplicateMatchingRecord

Many-To-One Relationship: [duplicaterecord msdyn_salescopilotinsight_DuplicateMatchingRecord](duplicaterecord.md#BKMK_msdyn_salescopilotinsight_DuplicateMatchingRecord)

|Property|Value|
|---|---|
|ReferencingEntity|`duplicaterecord`|
|ReferencingAttribute|`duplicaterecordid`|
|ReferencedEntityNavigationPropertyName|`msdyn_salescopilotinsight_DuplicateMatchingRecord`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_salescopilotinsight_MailboxTrackingFolders"></a> msdyn_salescopilotinsight_MailboxTrackingFolders

Many-To-One Relationship: [mailboxtrackingfolder msdyn_salescopilotinsight_MailboxTrackingFolders](mailboxtrackingfolder.md#BKMK_msdyn_salescopilotinsight_MailboxTrackingFolders)

|Property|Value|
|---|---|
|ReferencingEntity|`mailboxtrackingfolder`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_salescopilotinsight_MailboxTrackingFolders`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_salescopilotinsight_PrincipalObjectAttributeAccesses"></a> msdyn_salescopilotinsight_PrincipalObjectAttributeAccesses

Many-To-One Relationship: [principalobjectattributeaccess msdyn_salescopilotinsight_PrincipalObjectAttributeAccesses](principalobjectattributeaccess.md#BKMK_msdyn_salescopilotinsight_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencingEntity|`principalobjectattributeaccess`|
|ReferencingAttribute|`objectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_salescopilotinsight_PrincipalObjectAttributeAccesses`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_salescopilotinsight_ProcessSession"></a> msdyn_salescopilotinsight_ProcessSession

Many-To-One Relationship: [processsession msdyn_salescopilotinsight_ProcessSession](processsession.md#BKMK_msdyn_salescopilotinsight_ProcessSession)

|Property|Value|
|---|---|
|ReferencingEntity|`processsession`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_salescopilotinsight_ProcessSession`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_salescopilotinsight_SyncErrors"></a> msdyn_salescopilotinsight_SyncErrors

Many-To-One Relationship: [syncerror msdyn_salescopilotinsight_SyncErrors](syncerror.md#BKMK_msdyn_salescopilotinsight_SyncErrors)

|Property|Value|
|---|---|
|ReferencingEntity|`syncerror`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_salescopilotinsight_SyncErrors`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|



### See also

[Dataverse table/entity reference](/power-apps/developer/data-platform/reference/about-entity-reference)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   

