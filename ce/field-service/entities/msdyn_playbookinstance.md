---
title: "Playbook (msdyn_playbookinstance) table/entity reference (Microsoft Dynamics 365 Field Service)"
description: "Includes schema information and supported messages for the Playbook (msdyn_playbookinstance) table/entity with Microsoft Dynamics 365 Field Service."
ms.date: 07.24.2024
ms.service: powerapps
ms.topic: reference
author: m-hartmann
ms.author: mhart
search.audienceType: 
  - developer
---

# Playbook (msdyn_playbookinstance) table/entity reference

Actual instance of a playbook template once it is launched.

## Messages

The following table lists the messages for the Playbook (msdyn_playbookinstance) table.
Messages represent operations that can be performed on the table. They may also be events.

| Name <br />Is Event? |Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `Assign`<br />Event: True |`PATCH` /msdyn_playbookinstances(*msdyn_playbookinstanceid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `ownerid` property. |<xref:Microsoft.Crm.Sdk.Messages.AssignRequest>|
| `Create`<br />Event: True |`POST` /msdyn_playbookinstances<br />See [Create](/powerapps/developer/data-platform/webapi/create-entity-web-api) |[Create records](/power-apps/developer/data-platform/org-service/entity-operations-create#basic-create)|
| `CreateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.CreateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.CreateMultipleRequest>|
| `Delete`<br />Event: True |`DELETE` /msdyn_playbookinstances(*msdyn_playbookinstanceid*)<br />See [Delete](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-delete) |[Delete records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-delete)|
| `GrantAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.GrantAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.GrantAccessRequest>|
| `IsValidStateTransition`<br />Event: False |<xref:Microsoft.Dynamics.CRM.IsValidStateTransition?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.IsValidStateTransitionRequest>|
| `ModifyAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.ModifyAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.ModifyAccessRequest>|
| `Restore`<br />Event: True |<xref:Microsoft.Dynamics.CRM.Restore?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retrieve`<br />Event: True |`GET` /msdyn_playbookinstances(*msdyn_playbookinstanceid*)<br />See [Retrieve](/powerapps/developer/data-platform/webapi/retrieve-entity-using-web-api) |[Retrieve records](/power-apps/developer/data-platform/org-service/entity-operations-retrieve)|
| `RetrieveMultiple`<br />Event: True |`GET` /msdyn_playbookinstances<br />See [Query data](/power-apps/developer/data-platform/webapi/query-data-web-api) |[Query data](/power-apps/developer/data-platform/org-service/entity-operations-query-data)|
| `RetrievePrincipalAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RetrievePrincipalAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RetrievePrincipalAccessRequest>|
| `RetrieveSharedPrincipalsAndAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RetrieveSharedPrincipalsAndAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RetrieveSharedPrincipalsAndAccessRequest>|
| `RevokeAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RevokeAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RevokeAccessRequest>|
| `SetState`<br />Event: True |`PATCH` /msdyn_playbookinstances(*msdyn_playbookinstanceid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `statecode` and `statuscode` properties. |<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|
| `Update`<br />Event: True |`PATCH` /msdyn_playbookinstances(*msdyn_playbookinstanceid*)<br />See [Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) |[Update records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-update)|
| `UpdateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.UpdateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpdateMultipleRequest>|
| `Upsert`<br />Event: False |`PATCH` /msdyn_playbookinstances(*msdyn_playbookinstanceid*)<br />See [Upsert a table row](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#upsert-a-table-row) |<xref:Microsoft.Xrm.Sdk.Messages.UpsertRequest>|
| `UpsertMultiple`<br />Event: False |<xref:Microsoft.Dynamics.CRM.UpsertMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpsertMultipleRequest>|


## Events

The following table lists the events for the Playbook (msdyn_playbookinstance) table.
Events are messages that exist so that you can subscribe to them. Unless you added the event, you shouldn't invoke the message, only subscribe to it.

|Name|Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `BulkRetain`|<xref:Microsoft.Dynamics.CRM.BulkRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `PurgeRetainedContent`|<xref:Microsoft.Dynamics.CRM.PurgeRetainedContent?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retain`|<xref:Microsoft.Dynamics.CRM.Retain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `RollbackRetain`|<xref:Microsoft.Dynamics.CRM.RollbackRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `ValidateRetentionConfig`|<xref:Microsoft.Dynamics.CRM.ValidateRetentionConfig?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|

## Properties

The following table lists selected properties for the Playbook (msdyn_playbookinstance) table.

|Property|Value|
| --- | --- |
| **DisplayName** | **Playbook** |
| **DisplayCollectionName** | **Playbooks** |
| **SchemaName** | `msdyn_playbookinstance` |
| **CollectionSchemaName** | `msdyn_playbookinstances` |
| **EntitySetName** | `msdyn_playbookinstances`|
| **LogicalName** | `msdyn_playbookinstance` |
| **LogicalCollectionName** | `msdyn_playbookinstances` |
| **PrimaryIdAttribute** | `msdyn_playbookinstanceid` |
| **PrimaryNameAttribute** |`msdyn_name` |
| **TableType** | `Standard` |
| **OwnershipType** | `UserOwned` |

## Writable columns/attributes

These columns/attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [msdyn_activitiesassociated](#BKMK_msdyn_activitiesassociated)
- [msdyn_activitiesclosed](#BKMK_msdyn_activitiesclosed)
- [msdyn_categoryid](#BKMK_msdyn_categoryid)
- [msdyn_estimatedclose](#BKMK_msdyn_estimatedclose)
- [msdyn_evaluateactivityclosure](#BKMK_msdyn_evaluateactivityclosure)
- [msdyn_name](#BKMK_msdyn_name)
- [msdyn_playbookinstanceId](#BKMK_msdyn_playbookinstanceId)
- [msdyn_playbooktemplateid](#BKMK_msdyn_playbooktemplateid)
- [msdyn_trackprogress](#BKMK_msdyn_trackprogress)
- [OverriddenCreatedOn](#BKMK_OverriddenCreatedOn)
- [OwnerId](#BKMK_OwnerId)
- [OwnerIdType](#BKMK_OwnerIdType)
- [Regarding](#BKMK_Regarding)
- [RegardingObjectTypeCode](#BKMK_RegardingObjectTypeCode)
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

### <a name="BKMK_msdyn_activitiesassociated"></a> msdyn_activitiesassociated

|Property|Value|
|---|---|
|Description||
|DisplayName|**Total activities**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_activitiesassociated`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|-2147483648|

### <a name="BKMK_msdyn_activitiesclosed"></a> msdyn_activitiesclosed

|Property|Value|
|---|---|
|Description||
|DisplayName|**Completed activities**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_activitiesclosed`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|-2147483648|

### <a name="BKMK_msdyn_categoryid"></a> msdyn_categoryid

|Property|Value|
|---|---|
|Description|**Select the playbook category for the playbook.**|
|DisplayName|**Category**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_categoryid`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|msdyn_playbookcategory|

### <a name="BKMK_msdyn_estimatedclose"></a> msdyn_estimatedclose

|Property|Value|
|---|---|
|Description|**Estimated close date for a playbook based on the estimated duration specified for the playbook template.**|
|DisplayName|**Estimated close**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_estimatedclose`|
|RequiredLevel|None|
|Type|DateTime|
|CanChangeDateTimeBehavior|False|
|DateTimeBehavior|UserLocal|
|Format|DateOnly|
|ImeMode|Auto|
|SourceTypeMask|0|

### <a name="BKMK_msdyn_evaluateactivityclosure"></a> msdyn_evaluateactivityclosure

|Property|Value|
|---|---|
|Description|**Internal Use Only**|
|DisplayName|**Evaluate Activity Closure**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`msdyn_evaluateactivityclosure`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`msdyn_playbookinstance_msdyn_evaluateactivityclosure`|
|DefaultValue|False|
|True Label|true|
|False Label|false|

### <a name="BKMK_msdyn_name"></a> msdyn_name

|Property|Value|
|---|---|
|Description|**Type the name of the playbook.**|
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
|MaxLength|128|

### <a name="BKMK_msdyn_playbookinstanceId"></a> msdyn_playbookinstanceId

|Property|Value|
|---|---|
|Description|**Unique identifier for entity instances**|
|DisplayName|**Playbook**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`msdyn_playbookinstanceid`|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|

### <a name="BKMK_msdyn_playbooktemplateid"></a> msdyn_playbooktemplateid

|Property|Value|
|---|---|
|Description|**Shows the unique ID of the playbook template associated with the playbook.**|
|DisplayName|**Playbook Template**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_playbooktemplateid`|
|RequiredLevel|ApplicationRequired|
|Type|Lookup|
|Targets|msdyn_playbooktemplate|

### <a name="BKMK_msdyn_trackprogress"></a> msdyn_trackprogress

|Property|Value|
|---|---|
|Description|**Select whether or not to track the progress of the playbook by creating the activities under a playbook which is in turn linked to the record type the playbook applies to.**|
|DisplayName|**Track progress**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_trackprogress`|
|RequiredLevel|ApplicationRequired|
|Type|Boolean|
|GlobalChoiceName|`msdyn_playbookinstance_msdyn_trackprogress`|
|DefaultValue|True|
|True Label|Yes|
|False Label|No|

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

### <a name="BKMK_Regarding"></a> Regarding

|Property|Value|
|---|---|
|Description|**Shows the entity the playbook is launched for.**|
|DisplayName|**Regarding**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`regarding`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|account, contact, invoice, lead, opportunity, quote, salesorder|

### <a name="BKMK_RegardingObjectTypeCode"></a> RegardingObjectTypeCode

|Property|Value|
|---|---|
|Description||
|DisplayName||
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`regardingobjecttypecode`|
|RequiredLevel|None|
|Type|EntityName|

### <a name="BKMK_statecode"></a> statecode

|Property|Value|
|---|---|
|Description|**Status of the Playbook**|
|DisplayName|**Status**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statecode`|
|RequiredLevel|SystemRequired|
|Type|State|
|DefaultFormValue||
|GlobalChoiceName|`msdyn_playbookinstance_statecode`|

#### statecode Choices/Options

|Value|Details|
|---|---|
|0|Label: **Active**<br />DefaultStatus: 1<br />InvariantName: `Active`|
|1|Label: **Completed**<br />DefaultStatus: 2<br />InvariantName: `Completed`|

### <a name="BKMK_statuscode"></a> statuscode

|Property|Value|
|---|---|
|Description|**Playbook result**|
|DisplayName|**Result**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statuscode`|
|RequiredLevel|None|
|Type|Status|
|DefaultFormValue||
|GlobalChoiceName|`msdyn_playbookinstance_statuscode`|

#### statuscode Choices/Options

|Value|Details|
|---|---|
|1|Label: **In Progress**<br />State:0<br />TransitionData: None|
|2|Label: **Successful**<br />State:1<br />TransitionData: None|
|3|Label: **Not Successful**<br />State:1<br />TransitionData: None|
|4|Label: **Partially Successful**<br />State:1<br />TransitionData: None|
|5|Label: **Not Required**<br />State:1<br />TransitionData: None|
|6|Label: **Not Tracked**<br />State:1<br />TransitionData: None|

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
|Description|**Date and time when the playbook was started.**|
|DisplayName|**Started On**|
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

- [business_unit_msdyn_playbookinstance](#BKMK_business_unit_msdyn_playbookinstance)
- [lk_msdyn_playbookinstance_createdby](#BKMK_lk_msdyn_playbookinstance_createdby)
- [lk_msdyn_playbookinstance_createdonbehalfby](#BKMK_lk_msdyn_playbookinstance_createdonbehalfby)
- [lk_msdyn_playbookinstance_modifiedby](#BKMK_lk_msdyn_playbookinstance_modifiedby)
- [lk_msdyn_playbookinstance_modifiedonbehalfby](#BKMK_lk_msdyn_playbookinstance_modifiedonbehalfby)
- [msdyn_playbookcategory_msdyn_playbookinstance](#BKMK_msdyn_playbookcategory_msdyn_playbookinstance)
- [msdyn_playbookinstance_account](#BKMK_msdyn_playbookinstance_account)
- [msdyn_playbookinstance_contact](#BKMK_msdyn_playbookinstance_contact)
- [msdyn_playbookinstance_invoice](#BKMK_msdyn_playbookinstance_invoice)
- [msdyn_playbookinstance_lead](#BKMK_msdyn_playbookinstance_lead)
- [msdyn_playbookinstance_opportunity](#BKMK_msdyn_playbookinstance_opportunity)
- [msdyn_playbookinstance_quote](#BKMK_msdyn_playbookinstance_quote)
- [msdyn_playbookinstance_salesorder](#BKMK_msdyn_playbookinstance_salesorder)
- [msdyn_playbooktemplate_msdyn_playbookinstance](#BKMK_msdyn_playbooktemplate_msdyn_playbookinstance)
- [owner_msdyn_playbookinstance](#BKMK_owner_msdyn_playbookinstance)
- [team_msdyn_playbookinstance](#BKMK_team_msdyn_playbookinstance)
- [user_msdyn_playbookinstance](#BKMK_user_msdyn_playbookinstance)

### <a name="BKMK_business_unit_msdyn_playbookinstance"></a> business_unit_msdyn_playbookinstance

One-To-Many Relationship: [businessunit business_unit_msdyn_playbookinstance](businessunit.md#BKMK_business_unit_msdyn_playbookinstance)

|Property|Value|
|---|---|
|ReferencedEntity|`businessunit`|
|ReferencedAttribute|`businessunitid`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencingEntityNavigationPropertyName|`owningbusinessunit`|
|IsHierarchical||
|CascadeConfiguration|Archive: `Restrict`<br />Assign: `NoCascade`<br />Delete: `Restrict`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_playbookinstance_createdby"></a> lk_msdyn_playbookinstance_createdby

One-To-Many Relationship: [systemuser lk_msdyn_playbookinstance_createdby](systemuser.md#BKMK_lk_msdyn_playbookinstance_createdby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdby`|
|ReferencingEntityNavigationPropertyName|`createdby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_playbookinstance_createdonbehalfby"></a> lk_msdyn_playbookinstance_createdonbehalfby

One-To-Many Relationship: [systemuser lk_msdyn_playbookinstance_createdonbehalfby](systemuser.md#BKMK_lk_msdyn_playbookinstance_createdonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdonbehalfby`|
|ReferencingEntityNavigationPropertyName|`createdonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_playbookinstance_modifiedby"></a> lk_msdyn_playbookinstance_modifiedby

One-To-Many Relationship: [systemuser lk_msdyn_playbookinstance_modifiedby](systemuser.md#BKMK_lk_msdyn_playbookinstance_modifiedby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedby`|
|ReferencingEntityNavigationPropertyName|`modifiedby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_playbookinstance_modifiedonbehalfby"></a> lk_msdyn_playbookinstance_modifiedonbehalfby

One-To-Many Relationship: [systemuser lk_msdyn_playbookinstance_modifiedonbehalfby](systemuser.md#BKMK_lk_msdyn_playbookinstance_modifiedonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedonbehalfby`|
|ReferencingEntityNavigationPropertyName|`modifiedonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_playbookcategory_msdyn_playbookinstance"></a> msdyn_playbookcategory_msdyn_playbookinstance

One-To-Many Relationship: [msdyn_playbookcategory msdyn_playbookcategory_msdyn_playbookinstance](msdyn_playbookcategory.md#BKMK_msdyn_playbookcategory_msdyn_playbookinstance)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_playbookcategory`|
|ReferencedAttribute|`msdyn_playbookcategoryid`|
|ReferencingAttribute|`msdyn_categoryid`|
|ReferencingEntityNavigationPropertyName|`msdyn_categoryid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_playbookinstance_account"></a> msdyn_playbookinstance_account

One-To-Many Relationship: [account msdyn_playbookinstance_account](account.md#BKMK_msdyn_playbookinstance_account)

|Property|Value|
|---|---|
|ReferencedEntity|`account`|
|ReferencedAttribute|`accountid`|
|ReferencingAttribute|`regarding`|
|ReferencingEntityNavigationPropertyName|`regarding_account`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_playbookinstance_contact"></a> msdyn_playbookinstance_contact

One-To-Many Relationship: [contact msdyn_playbookinstance_contact](contact.md#BKMK_msdyn_playbookinstance_contact)

|Property|Value|
|---|---|
|ReferencedEntity|`contact`|
|ReferencedAttribute|`contactid`|
|ReferencingAttribute|`regarding`|
|ReferencingEntityNavigationPropertyName|`regarding_contact`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_playbookinstance_invoice"></a> msdyn_playbookinstance_invoice

One-To-Many Relationship: [invoice msdyn_playbookinstance_invoice](invoice.md#BKMK_msdyn_playbookinstance_invoice)

|Property|Value|
|---|---|
|ReferencedEntity|`invoice`|
|ReferencedAttribute|`invoiceid`|
|ReferencingAttribute|`regarding`|
|ReferencingEntityNavigationPropertyName|`regarding_invoice`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_playbookinstance_lead"></a> msdyn_playbookinstance_lead

One-To-Many Relationship: [lead msdyn_playbookinstance_lead](lead.md#BKMK_msdyn_playbookinstance_lead)

|Property|Value|
|---|---|
|ReferencedEntity|`lead`|
|ReferencedAttribute|`leadid`|
|ReferencingAttribute|`regarding`|
|ReferencingEntityNavigationPropertyName|`regarding_lead`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_playbookinstance_opportunity"></a> msdyn_playbookinstance_opportunity

One-To-Many Relationship: [opportunity msdyn_playbookinstance_opportunity](opportunity.md#BKMK_msdyn_playbookinstance_opportunity)

|Property|Value|
|---|---|
|ReferencedEntity|`opportunity`|
|ReferencedAttribute|`opportunityid`|
|ReferencingAttribute|`regarding`|
|ReferencingEntityNavigationPropertyName|`regarding_opportunity`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_playbookinstance_quote"></a> msdyn_playbookinstance_quote

One-To-Many Relationship: [quote msdyn_playbookinstance_quote](quote.md#BKMK_msdyn_playbookinstance_quote)

|Property|Value|
|---|---|
|ReferencedEntity|`quote`|
|ReferencedAttribute|`quoteid`|
|ReferencingAttribute|`regarding`|
|ReferencingEntityNavigationPropertyName|`regarding_quote`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_playbookinstance_salesorder"></a> msdyn_playbookinstance_salesorder

One-To-Many Relationship: [salesorder msdyn_playbookinstance_salesorder](salesorder.md#BKMK_msdyn_playbookinstance_salesorder)

|Property|Value|
|---|---|
|ReferencedEntity|`salesorder`|
|ReferencedAttribute|`salesorderid`|
|ReferencingAttribute|`regarding`|
|ReferencingEntityNavigationPropertyName|`regarding_salesorder`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_playbooktemplate_msdyn_playbookinstance"></a> msdyn_playbooktemplate_msdyn_playbookinstance

One-To-Many Relationship: [msdyn_playbooktemplate msdyn_playbooktemplate_msdyn_playbookinstance](msdyn_playbooktemplate.md#BKMK_msdyn_playbooktemplate_msdyn_playbookinstance)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_playbooktemplate`|
|ReferencedAttribute|`msdyn_playbooktemplateid`|
|ReferencingAttribute|`msdyn_playbooktemplateid`|
|ReferencingEntityNavigationPropertyName|`msdyn_playbooktemplateid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Restrict`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_owner_msdyn_playbookinstance"></a> owner_msdyn_playbookinstance

One-To-Many Relationship: [owner owner_msdyn_playbookinstance](owner.md#BKMK_owner_msdyn_playbookinstance)

|Property|Value|
|---|---|
|ReferencedEntity|`owner`|
|ReferencedAttribute|`ownerid`|
|ReferencingAttribute|`ownerid`|
|ReferencingEntityNavigationPropertyName|`ownerid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_team_msdyn_playbookinstance"></a> team_msdyn_playbookinstance

One-To-Many Relationship: [team team_msdyn_playbookinstance](team.md#BKMK_team_msdyn_playbookinstance)

|Property|Value|
|---|---|
|ReferencedEntity|`team`|
|ReferencedAttribute|`teamid`|
|ReferencingAttribute|`owningteam`|
|ReferencingEntityNavigationPropertyName|`owningteam`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_user_msdyn_playbookinstance"></a> user_msdyn_playbookinstance

One-To-Many Relationship: [systemuser user_msdyn_playbookinstance](systemuser.md#BKMK_user_msdyn_playbookinstance)

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

- [msdyn_playbookinstance_ActivityPointers](#BKMK_msdyn_playbookinstance_ActivityPointers)
- [msdyn_playbookinstance_adx_alertsubscriptions](#BKMK_msdyn_playbookinstance_adx_alertsubscriptions)
- [msdyn_playbookinstance_adx_inviteredemptions](#BKMK_msdyn_playbookinstance_adx_inviteredemptions)
- [msdyn_playbookinstance_adx_portalcomments](#BKMK_msdyn_playbookinstance_adx_portalcomments)
- [msdyn_playbookinstance_Annotations](#BKMK_msdyn_playbookinstance_Annotations)
- [msdyn_playbookinstance_Appointments](#BKMK_msdyn_playbookinstance_Appointments)
- [msdyn_playbookinstance_AsyncOperations](#BKMK_msdyn_playbookinstance_AsyncOperations)
- [msdyn_playbookinstance_BulkDeleteFailures](#BKMK_msdyn_playbookinstance_BulkDeleteFailures)
- [msdyn_playbookinstance_chats](#BKMK_msdyn_playbookinstance_chats)
- [msdyn_playbookinstance_DuplicateBaseRecord](#BKMK_msdyn_playbookinstance_DuplicateBaseRecord)
- [msdyn_playbookinstance_DuplicateMatchingRecord](#BKMK_msdyn_playbookinstance_DuplicateMatchingRecord)
- [msdyn_playbookinstance_Emails](#BKMK_msdyn_playbookinstance_Emails)
- [msdyn_playbookinstance_Faxes](#BKMK_msdyn_playbookinstance_Faxes)
- [msdyn_playbookinstance_Letters](#BKMK_msdyn_playbookinstance_Letters)
- [msdyn_playbookinstance_li_inmails](#BKMK_msdyn_playbookinstance_li_inmails)
- [msdyn_playbookinstance_li_messages](#BKMK_msdyn_playbookinstance_li_messages)
- [msdyn_playbookinstance_li_pointdrivepresentationvieweds](#BKMK_msdyn_playbookinstance_li_pointdrivepresentationvieweds)
- [msdyn_playbookinstance_MailboxTrackingFolders](#BKMK_msdyn_playbookinstance_MailboxTrackingFolders)
- [msdyn_playbookinstance_msdyn_bookingalerts](#BKMK_msdyn_playbookinstance_msdyn_bookingalerts)
- [msdyn_playbookinstance_msdyn_copilottranscripts](#BKMK_msdyn_playbookinstance_msdyn_copilottranscripts)
- [msdyn_playbookinstance_msdyn_ocliveworkitems](#BKMK_msdyn_playbookinstance_msdyn_ocliveworkitems)
- [msdyn_playbookinstance_msdyn_ocoutboundmessages](#BKMK_msdyn_playbookinstance_msdyn_ocoutboundmessages)
- [msdyn_playbookinstance_msdyn_ocsessions](#BKMK_msdyn_playbookinstance_msdyn_ocsessions)
- [msdyn_playbookinstance_msdyn_ocvoicemails](#BKMK_msdyn_playbookinstance_msdyn_ocvoicemails)
- [msdyn_playbookinstance_msfp_alerts](#BKMK_msdyn_playbookinstance_msfp_alerts)
- [msdyn_playbookinstance_msfp_surveyinvites](#BKMK_msdyn_playbookinstance_msfp_surveyinvites)
- [msdyn_playbookinstance_msfp_surveyresponses](#BKMK_msdyn_playbookinstance_msfp_surveyresponses)
- [msdyn_playbookinstance_OpportunityCloses](#BKMK_msdyn_playbookinstance_OpportunityCloses)
- [msdyn_playbookinstance_OrderCloses](#BKMK_msdyn_playbookinstance_OrderCloses)
- [msdyn_playbookinstance_PhoneCalls](#BKMK_msdyn_playbookinstance_PhoneCalls)
- [msdyn_playbookinstance_PrincipalObjectAttributeAccesses](#BKMK_msdyn_playbookinstance_PrincipalObjectAttributeAccesses)
- [msdyn_playbookinstance_ProcessSession](#BKMK_msdyn_playbookinstance_ProcessSession)
- [msdyn_playbookinstance_QuoteCloses](#BKMK_msdyn_playbookinstance_QuoteCloses)
- [msdyn_playbookinstance_RecurringAppointmentMasters](#BKMK_msdyn_playbookinstance_RecurringAppointmentMasters)
- [msdyn_playbookinstance_ServiceAppointments](#BKMK_msdyn_playbookinstance_ServiceAppointments)
- [msdyn_playbookinstance_SocialActivities](#BKMK_msdyn_playbookinstance_SocialActivities)
- [msdyn_playbookinstance_SyncErrors](#BKMK_msdyn_playbookinstance_SyncErrors)
- [msdyn_playbookinstance_Tasks](#BKMK_msdyn_playbookinstance_Tasks)

### <a name="BKMK_msdyn_playbookinstance_ActivityPointers"></a> msdyn_playbookinstance_ActivityPointers

Many-To-One Relationship: [activitypointer msdyn_playbookinstance_ActivityPointers](activitypointer.md#BKMK_msdyn_playbookinstance_ActivityPointers)

|Property|Value|
|---|---|
|ReferencingEntity|`activitypointer`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_playbookinstance_ActivityPointers`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_playbookinstance_adx_alertsubscriptions"></a> msdyn_playbookinstance_adx_alertsubscriptions

Many-To-One Relationship: [adx_alertsubscription msdyn_playbookinstance_adx_alertsubscriptions](adx_alertsubscription.md#BKMK_msdyn_playbookinstance_adx_alertsubscriptions)

|Property|Value|
|---|---|
|ReferencingEntity|`adx_alertsubscription`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_playbookinstance_adx_alertsubscriptions`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_playbookinstance_adx_inviteredemptions"></a> msdyn_playbookinstance_adx_inviteredemptions

Many-To-One Relationship: [adx_inviteredemption msdyn_playbookinstance_adx_inviteredemptions](adx_inviteredemption.md#BKMK_msdyn_playbookinstance_adx_inviteredemptions)

|Property|Value|
|---|---|
|ReferencingEntity|`adx_inviteredemption`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_playbookinstance_adx_inviteredemptions`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_playbookinstance_adx_portalcomments"></a> msdyn_playbookinstance_adx_portalcomments

Many-To-One Relationship: [adx_portalcomment msdyn_playbookinstance_adx_portalcomments](adx_portalcomment.md#BKMK_msdyn_playbookinstance_adx_portalcomments)

|Property|Value|
|---|---|
|ReferencingEntity|`adx_portalcomment`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_playbookinstance_adx_portalcomments`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_playbookinstance_Annotations"></a> msdyn_playbookinstance_Annotations

Many-To-One Relationship: [annotation msdyn_playbookinstance_Annotations](annotation.md#BKMK_msdyn_playbookinstance_Annotations)

|Property|Value|
|---|---|
|ReferencingEntity|`annotation`|
|ReferencingAttribute|`objectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_playbookinstance_Annotations`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_playbookinstance_Appointments"></a> msdyn_playbookinstance_Appointments

Many-To-One Relationship: [appointment msdyn_playbookinstance_Appointments](appointment.md#BKMK_msdyn_playbookinstance_Appointments)

|Property|Value|
|---|---|
|ReferencingEntity|`appointment`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_playbookinstance_Appointments`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_playbookinstance_AsyncOperations"></a> msdyn_playbookinstance_AsyncOperations

Many-To-One Relationship: [asyncoperation msdyn_playbookinstance_AsyncOperations](asyncoperation.md#BKMK_msdyn_playbookinstance_AsyncOperations)

|Property|Value|
|---|---|
|ReferencingEntity|`asyncoperation`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_playbookinstance_AsyncOperations`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_playbookinstance_BulkDeleteFailures"></a> msdyn_playbookinstance_BulkDeleteFailures

Many-To-One Relationship: [bulkdeletefailure msdyn_playbookinstance_BulkDeleteFailures](bulkdeletefailure.md#BKMK_msdyn_playbookinstance_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencingEntity|`bulkdeletefailure`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_playbookinstance_BulkDeleteFailures`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_playbookinstance_chats"></a> msdyn_playbookinstance_chats

Many-To-One Relationship: [chat msdyn_playbookinstance_chats](chat.md#BKMK_msdyn_playbookinstance_chats)

|Property|Value|
|---|---|
|ReferencingEntity|`chat`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_playbookinstance_chats`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_playbookinstance_DuplicateBaseRecord"></a> msdyn_playbookinstance_DuplicateBaseRecord

Many-To-One Relationship: [duplicaterecord msdyn_playbookinstance_DuplicateBaseRecord](duplicaterecord.md#BKMK_msdyn_playbookinstance_DuplicateBaseRecord)

|Property|Value|
|---|---|
|ReferencingEntity|`duplicaterecord`|
|ReferencingAttribute|`baserecordid`|
|ReferencedEntityNavigationPropertyName|`msdyn_playbookinstance_DuplicateBaseRecord`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_playbookinstance_DuplicateMatchingRecord"></a> msdyn_playbookinstance_DuplicateMatchingRecord

Many-To-One Relationship: [duplicaterecord msdyn_playbookinstance_DuplicateMatchingRecord](duplicaterecord.md#BKMK_msdyn_playbookinstance_DuplicateMatchingRecord)

|Property|Value|
|---|---|
|ReferencingEntity|`duplicaterecord`|
|ReferencingAttribute|`duplicaterecordid`|
|ReferencedEntityNavigationPropertyName|`msdyn_playbookinstance_DuplicateMatchingRecord`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_playbookinstance_Emails"></a> msdyn_playbookinstance_Emails

Many-To-One Relationship: [email msdyn_playbookinstance_Emails](email.md#BKMK_msdyn_playbookinstance_Emails)

|Property|Value|
|---|---|
|ReferencingEntity|`email`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_playbookinstance_Emails`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_playbookinstance_Faxes"></a> msdyn_playbookinstance_Faxes

Many-To-One Relationship: [fax msdyn_playbookinstance_Faxes](fax.md#BKMK_msdyn_playbookinstance_Faxes)

|Property|Value|
|---|---|
|ReferencingEntity|`fax`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_playbookinstance_Faxes`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_playbookinstance_Letters"></a> msdyn_playbookinstance_Letters

Many-To-One Relationship: [letter msdyn_playbookinstance_Letters](letter.md#BKMK_msdyn_playbookinstance_Letters)

|Property|Value|
|---|---|
|ReferencingEntity|`letter`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_playbookinstance_Letters`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_playbookinstance_li_inmails"></a> msdyn_playbookinstance_li_inmails

Many-To-One Relationship: [li_inmail msdyn_playbookinstance_li_inmails](li_inmail.md#BKMK_msdyn_playbookinstance_li_inmails)

|Property|Value|
|---|---|
|ReferencingEntity|`li_inmail`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_playbookinstance_li_inmails`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_playbookinstance_li_messages"></a> msdyn_playbookinstance_li_messages

Many-To-One Relationship: [li_message msdyn_playbookinstance_li_messages](li_message.md#BKMK_msdyn_playbookinstance_li_messages)

|Property|Value|
|---|---|
|ReferencingEntity|`li_message`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_playbookinstance_li_messages`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_playbookinstance_li_pointdrivepresentationvieweds"></a> msdyn_playbookinstance_li_pointdrivepresentationvieweds

Many-To-One Relationship: [li_pointdrivepresentationviewed msdyn_playbookinstance_li_pointdrivepresentationvieweds](li_pointdrivepresentationviewed.md#BKMK_msdyn_playbookinstance_li_pointdrivepresentationvieweds)

|Property|Value|
|---|---|
|ReferencingEntity|`li_pointdrivepresentationviewed`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_playbookinstance_li_pointdrivepresentationvieweds`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_playbookinstance_MailboxTrackingFolders"></a> msdyn_playbookinstance_MailboxTrackingFolders

Many-To-One Relationship: [mailboxtrackingfolder msdyn_playbookinstance_MailboxTrackingFolders](mailboxtrackingfolder.md#BKMK_msdyn_playbookinstance_MailboxTrackingFolders)

|Property|Value|
|---|---|
|ReferencingEntity|`mailboxtrackingfolder`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_playbookinstance_MailboxTrackingFolders`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_playbookinstance_msdyn_bookingalerts"></a> msdyn_playbookinstance_msdyn_bookingalerts

Many-To-One Relationship: [msdyn_bookingalert msdyn_playbookinstance_msdyn_bookingalerts](msdyn_bookingalert.md#BKMK_msdyn_playbookinstance_msdyn_bookingalerts)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_bookingalert`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_playbookinstance_msdyn_bookingalerts`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_playbookinstance_msdyn_copilottranscripts"></a> msdyn_playbookinstance_msdyn_copilottranscripts

Many-To-One Relationship: [msdyn_copilottranscript msdyn_playbookinstance_msdyn_copilottranscripts](msdyn_copilottranscript.md#BKMK_msdyn_playbookinstance_msdyn_copilottranscripts)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_copilottranscript`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_playbookinstance_msdyn_copilottranscripts`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_playbookinstance_msdyn_ocliveworkitems"></a> msdyn_playbookinstance_msdyn_ocliveworkitems

Many-To-One Relationship: [msdyn_ocliveworkitem msdyn_playbookinstance_msdyn_ocliveworkitems](msdyn_ocliveworkitem.md#BKMK_msdyn_playbookinstance_msdyn_ocliveworkitems)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocliveworkitem`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_playbookinstance_msdyn_ocliveworkitems`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_playbookinstance_msdyn_ocoutboundmessages"></a> msdyn_playbookinstance_msdyn_ocoutboundmessages

Many-To-One Relationship: [msdyn_ocoutboundmessage msdyn_playbookinstance_msdyn_ocoutboundmessages](msdyn_ocoutboundmessage.md#BKMK_msdyn_playbookinstance_msdyn_ocoutboundmessages)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocoutboundmessage`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_playbookinstance_msdyn_ocoutboundmessages`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_playbookinstance_msdyn_ocsessions"></a> msdyn_playbookinstance_msdyn_ocsessions

Many-To-One Relationship: [msdyn_ocsession msdyn_playbookinstance_msdyn_ocsessions](msdyn_ocsession.md#BKMK_msdyn_playbookinstance_msdyn_ocsessions)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocsession`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_playbookinstance_msdyn_ocsessions`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_playbookinstance_msdyn_ocvoicemails"></a> msdyn_playbookinstance_msdyn_ocvoicemails

Many-To-One Relationship: [msdyn_ocvoicemail msdyn_playbookinstance_msdyn_ocvoicemails](msdyn_ocvoicemail.md#BKMK_msdyn_playbookinstance_msdyn_ocvoicemails)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocvoicemail`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_playbookinstance_msdyn_ocvoicemails`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_playbookinstance_msfp_alerts"></a> msdyn_playbookinstance_msfp_alerts

Many-To-One Relationship: [msfp_alert msdyn_playbookinstance_msfp_alerts](msfp_alert.md#BKMK_msdyn_playbookinstance_msfp_alerts)

|Property|Value|
|---|---|
|ReferencingEntity|`msfp_alert`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_playbookinstance_msfp_alerts`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_playbookinstance_msfp_surveyinvites"></a> msdyn_playbookinstance_msfp_surveyinvites

Many-To-One Relationship: [msfp_surveyinvite msdyn_playbookinstance_msfp_surveyinvites](msfp_surveyinvite.md#BKMK_msdyn_playbookinstance_msfp_surveyinvites)

|Property|Value|
|---|---|
|ReferencingEntity|`msfp_surveyinvite`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_playbookinstance_msfp_surveyinvites`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_playbookinstance_msfp_surveyresponses"></a> msdyn_playbookinstance_msfp_surveyresponses

Many-To-One Relationship: [msfp_surveyresponse msdyn_playbookinstance_msfp_surveyresponses](msfp_surveyresponse.md#BKMK_msdyn_playbookinstance_msfp_surveyresponses)

|Property|Value|
|---|---|
|ReferencingEntity|`msfp_surveyresponse`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_playbookinstance_msfp_surveyresponses`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_playbookinstance_OpportunityCloses"></a> msdyn_playbookinstance_OpportunityCloses

Many-To-One Relationship: [opportunityclose msdyn_playbookinstance_OpportunityCloses](opportunityclose.md#BKMK_msdyn_playbookinstance_OpportunityCloses)

|Property|Value|
|---|---|
|ReferencingEntity|`opportunityclose`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_playbookinstance_OpportunityCloses`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_playbookinstance_OrderCloses"></a> msdyn_playbookinstance_OrderCloses

Many-To-One Relationship: [orderclose msdyn_playbookinstance_OrderCloses](orderclose.md#BKMK_msdyn_playbookinstance_OrderCloses)

|Property|Value|
|---|---|
|ReferencingEntity|`orderclose`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_playbookinstance_OrderCloses`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_playbookinstance_PhoneCalls"></a> msdyn_playbookinstance_PhoneCalls

Many-To-One Relationship: [phonecall msdyn_playbookinstance_PhoneCalls](phonecall.md#BKMK_msdyn_playbookinstance_PhoneCalls)

|Property|Value|
|---|---|
|ReferencingEntity|`phonecall`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_playbookinstance_PhoneCalls`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_playbookinstance_PrincipalObjectAttributeAccesses"></a> msdyn_playbookinstance_PrincipalObjectAttributeAccesses

Many-To-One Relationship: [principalobjectattributeaccess msdyn_playbookinstance_PrincipalObjectAttributeAccesses](principalobjectattributeaccess.md#BKMK_msdyn_playbookinstance_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencingEntity|`principalobjectattributeaccess`|
|ReferencingAttribute|`objectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_playbookinstance_PrincipalObjectAttributeAccesses`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_playbookinstance_ProcessSession"></a> msdyn_playbookinstance_ProcessSession

Many-To-One Relationship: [processsession msdyn_playbookinstance_ProcessSession](processsession.md#BKMK_msdyn_playbookinstance_ProcessSession)

|Property|Value|
|---|---|
|ReferencingEntity|`processsession`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_playbookinstance_ProcessSession`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_playbookinstance_QuoteCloses"></a> msdyn_playbookinstance_QuoteCloses

Many-To-One Relationship: [quoteclose msdyn_playbookinstance_QuoteCloses](quoteclose.md#BKMK_msdyn_playbookinstance_QuoteCloses)

|Property|Value|
|---|---|
|ReferencingEntity|`quoteclose`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_playbookinstance_QuoteCloses`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_playbookinstance_RecurringAppointmentMasters"></a> msdyn_playbookinstance_RecurringAppointmentMasters

Many-To-One Relationship: [recurringappointmentmaster msdyn_playbookinstance_RecurringAppointmentMasters](recurringappointmentmaster.md#BKMK_msdyn_playbookinstance_RecurringAppointmentMasters)

|Property|Value|
|---|---|
|ReferencingEntity|`recurringappointmentmaster`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_playbookinstance_RecurringAppointmentMasters`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_playbookinstance_ServiceAppointments"></a> msdyn_playbookinstance_ServiceAppointments

Many-To-One Relationship: [serviceappointment msdyn_playbookinstance_ServiceAppointments](serviceappointment.md#BKMK_msdyn_playbookinstance_ServiceAppointments)

|Property|Value|
|---|---|
|ReferencingEntity|`serviceappointment`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_playbookinstance_ServiceAppointments`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_playbookinstance_SocialActivities"></a> msdyn_playbookinstance_SocialActivities

Many-To-One Relationship: [socialactivity msdyn_playbookinstance_SocialActivities](socialactivity.md#BKMK_msdyn_playbookinstance_SocialActivities)

|Property|Value|
|---|---|
|ReferencingEntity|`socialactivity`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_playbookinstance_SocialActivities`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_playbookinstance_SyncErrors"></a> msdyn_playbookinstance_SyncErrors

Many-To-One Relationship: [syncerror msdyn_playbookinstance_SyncErrors](syncerror.md#BKMK_msdyn_playbookinstance_SyncErrors)

|Property|Value|
|---|---|
|ReferencingEntity|`syncerror`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_playbookinstance_SyncErrors`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_playbookinstance_Tasks"></a> msdyn_playbookinstance_Tasks

Many-To-One Relationship: [task msdyn_playbookinstance_Tasks](task.md#BKMK_msdyn_playbookinstance_Tasks)

|Property|Value|
|---|---|
|ReferencingEntity|`task`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_playbookinstance_Tasks`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|



### See also

[Dataverse table/entity reference](../about-entity-reference.md)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   

