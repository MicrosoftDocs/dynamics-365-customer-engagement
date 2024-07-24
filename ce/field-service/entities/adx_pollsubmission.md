---
title: "Poll Submission (Adx_pollsubmission) table/entity reference (Microsoft Dynamics 365 Field Service)"
description: "Includes schema information and supported messages for the Poll Submission (Adx_pollsubmission) table/entity with Microsoft Dynamics 365 Field Service."
ms.date: 07.24.2024
ms.service: powerapps
ms.topic: reference
author: m-hartmann
ms.author: mhart
search.audienceType: 
  - developer
---

# Poll Submission (Adx_pollsubmission) table/entity reference



## Messages

The following table lists the messages for the Poll Submission (Adx_pollsubmission) table.
Messages represent operations that can be performed on the table. They may also be events.

| Name <br />Is Event? |Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `Assign`<br />Event: True |`PATCH` /adx_pollsubmissions(*adx_pollsubmissionid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `ownerid` property. |<xref:Microsoft.Crm.Sdk.Messages.AssignRequest>|
| `Create`<br />Event: True |`POST` /adx_pollsubmissions<br />See [Create](/powerapps/developer/data-platform/webapi/create-entity-web-api) |[Create records](/power-apps/developer/data-platform/org-service/entity-operations-create#basic-create)|
| `CreateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.CreateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.CreateMultipleRequest>|
| `Delete`<br />Event: True |`DELETE` /adx_pollsubmissions(*adx_pollsubmissionid*)<br />See [Delete](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-delete) |[Delete records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-delete)|
| `GrantAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.GrantAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.GrantAccessRequest>|
| `IsValidStateTransition`<br />Event: False |<xref:Microsoft.Dynamics.CRM.IsValidStateTransition?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.IsValidStateTransitionRequest>|
| `ModifyAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.ModifyAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.ModifyAccessRequest>|
| `Restore`<br />Event: True |<xref:Microsoft.Dynamics.CRM.Restore?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retrieve`<br />Event: True |`GET` /adx_pollsubmissions(*adx_pollsubmissionid*)<br />See [Retrieve](/powerapps/developer/data-platform/webapi/retrieve-entity-using-web-api) |[Retrieve records](/power-apps/developer/data-platform/org-service/entity-operations-retrieve)|
| `RetrieveMultiple`<br />Event: True |`GET` /adx_pollsubmissions<br />See [Query data](/power-apps/developer/data-platform/webapi/query-data-web-api) |[Query data](/power-apps/developer/data-platform/org-service/entity-operations-query-data)|
| `RetrievePrincipalAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RetrievePrincipalAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RetrievePrincipalAccessRequest>|
| `RetrieveSharedPrincipalsAndAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RetrieveSharedPrincipalsAndAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RetrieveSharedPrincipalsAndAccessRequest>|
| `RevokeAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RevokeAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RevokeAccessRequest>|
| `SetState`<br />Event: True |`PATCH` /adx_pollsubmissions(*adx_pollsubmissionid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `statecode` and `statuscode` properties. |<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|
| `Update`<br />Event: True |`PATCH` /adx_pollsubmissions(*adx_pollsubmissionid*)<br />See [Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) |[Update records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-update)|
| `UpdateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.UpdateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpdateMultipleRequest>|
| `Upsert`<br />Event: False |`PATCH` /adx_pollsubmissions(*adx_pollsubmissionid*)<br />See [Upsert a table row](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#upsert-a-table-row) |<xref:Microsoft.Xrm.Sdk.Messages.UpsertRequest>|
| `UpsertMultiple`<br />Event: False |<xref:Microsoft.Dynamics.CRM.UpsertMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpsertMultipleRequest>|


## Events

The following table lists the events for the Poll Submission (Adx_pollsubmission) table.
Events are messages that exist so that you can subscribe to them. Unless you added the event, you shouldn't invoke the message, only subscribe to it.

|Name|Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `BulkRetain`|<xref:Microsoft.Dynamics.CRM.BulkRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `PurgeRetainedContent`|<xref:Microsoft.Dynamics.CRM.PurgeRetainedContent?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retain`|<xref:Microsoft.Dynamics.CRM.Retain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `RollbackRetain`|<xref:Microsoft.Dynamics.CRM.RollbackRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `ValidateRetentionConfig`|<xref:Microsoft.Dynamics.CRM.ValidateRetentionConfig?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|

## Properties

The following table lists selected properties for the Poll Submission (Adx_pollsubmission) table.

|Property|Value|
| --- | --- |
| **DisplayName** | **Poll Submission** |
| **DisplayCollectionName** | **Poll Submissions** |
| **SchemaName** | `Adx_pollsubmission` |
| **CollectionSchemaName** | `Adx_pollsubmissions` |
| **EntitySetName** | `adx_pollsubmissions`|
| **LogicalName** | `adx_pollsubmission` |
| **LogicalCollectionName** | `adx_pollsubmissions` |
| **PrimaryIdAttribute** | `adx_pollsubmissionid` |
| **PrimaryNameAttribute** |`adx_name` |
| **TableType** | `Standard` |
| **OwnershipType** | `UserOwned` |

## Writable columns/attributes

These columns/attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [adx_contactid](#BKMK_adx_contactid)
- [Adx_name](#BKMK_Adx_name)
- [adx_pollid](#BKMK_adx_pollid)
- [adx_polloptionid](#BKMK_adx_polloptionid)
- [Adx_pollsubmissionId](#BKMK_Adx_pollsubmissionId)
- [Adx_VisitorID](#BKMK_Adx_VisitorID)
- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [OverriddenCreatedOn](#BKMK_OverriddenCreatedOn)
- [OwnerId](#BKMK_OwnerId)
- [OwnerIdType](#BKMK_OwnerIdType)
- [statecode](#BKMK_statecode)
- [statuscode](#BKMK_statuscode)
- [TimeZoneRuleVersionNumber](#BKMK_TimeZoneRuleVersionNumber)
- [UTCConversionTimeZoneCode](#BKMK_UTCConversionTimeZoneCode)

### <a name="BKMK_adx_contactid"></a> adx_contactid

|Property|Value|
|---|---|
|Description|**Unique identifier for Contact associated with Poll Submission.**|
|DisplayName|**Contact**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`adx_contactid`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|contact|

### <a name="BKMK_Adx_name"></a> Adx_name

|Property|Value|
|---|---|
|Description|**Type the name of the custom entity.**|
|DisplayName|**Name**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`adx_name`|
|RequiredLevel|ApplicationRequired|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_adx_pollid"></a> adx_pollid

|Property|Value|
|---|---|
|Description|**Unique identifier for Poll associated with Poll Submission.**|
|DisplayName|**Poll**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`adx_pollid`|
|RequiredLevel|ApplicationRequired|
|Type|Lookup|
|Targets|adx_poll|

### <a name="BKMK_adx_polloptionid"></a> adx_polloptionid

|Property|Value|
|---|---|
|Description|**Unique identifier for PollOption associated with Poll Submission.**|
|DisplayName|**Poll Option**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`adx_polloptionid`|
|RequiredLevel|ApplicationRequired|
|Type|Lookup|
|Targets|adx_polloption|

### <a name="BKMK_Adx_pollsubmissionId"></a> Adx_pollsubmissionId

|Property|Value|
|---|---|
|Description|**Shows the entity instance.**|
|DisplayName|**Poll Submission**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`adx_pollsubmissionid`|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|

### <a name="BKMK_Adx_VisitorID"></a> Adx_VisitorID

|Property|Value|
|---|---|
|Description||
|DisplayName|**Visitor ID**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`adx_visitorid`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_ImportSequenceNumber"></a> ImportSequenceNumber

|Property|Value|
|---|---|
|Description|**Shows the sequence number of the import that created this record.**|
|DisplayName|**Import Sequence Number**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`importsequencenumber`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|-2147483648|

### <a name="BKMK_OverriddenCreatedOn"></a> OverriddenCreatedOn

|Property|Value|
|---|---|
|Description|**Shows the date and time that the record was migrated.**|
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
|Description|**Enter the user who is assigned to manage the record. This field is updated every time the record is assigned to a different user.**|
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
|Description|**Status of the Poll Submission**|
|DisplayName|**Status**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statecode`|
|RequiredLevel|SystemRequired|
|Type|State|
|DefaultFormValue||
|GlobalChoiceName|`adx_pollsubmission_statecode`|

#### statecode Choices/Options

|Value|Details|
|---|---|
|0|Label: **Active**<br />DefaultStatus: 1<br />InvariantName: `Active`|
|1|Label: **Inactive**<br />DefaultStatus: 2<br />InvariantName: `Inactive`|

### <a name="BKMK_statuscode"></a> statuscode

|Property|Value|
|---|---|
|Description|**Select the poll submission's status.**|
|DisplayName|**Status Reason**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statuscode`|
|RequiredLevel|None|
|Type|Status|
|DefaultFormValue||
|GlobalChoiceName|`adx_pollsubmission_statuscode`|

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
|Description|**Shows the time zone code that was in use when the record was created.**|
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
|Description|**Shows who created the record.**|
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
|Description|**Shows the date and time when the record was created.**|
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
|Description|**Shows who created the record on behalf of another user.**|
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
|Description|**Shows who last updated the record.**|
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
|Description|**Shows the date and time when the record was modified.**|
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
|Description|**Shows who last updated the record on behalf of another user.**|
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
|Description|**Shows the business unit that owns the record.**|
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

- [adx_contact_pollsubmission](#BKMK_adx_contact_pollsubmission)
- [adx_poll_pollsubmission](#BKMK_adx_poll_pollsubmission)
- [adx_polloption_pollsubmission](#BKMK_adx_polloption_pollsubmission)
- [business_unit_adx_pollsubmission](#BKMK_business_unit_adx_pollsubmission)
- [lk_adx_pollsubmission_createdby](#BKMK_lk_adx_pollsubmission_createdby)
- [lk_adx_pollsubmission_createdonbehalfby](#BKMK_lk_adx_pollsubmission_createdonbehalfby)
- [lk_adx_pollsubmission_modifiedby](#BKMK_lk_adx_pollsubmission_modifiedby)
- [lk_adx_pollsubmission_modifiedonbehalfby](#BKMK_lk_adx_pollsubmission_modifiedonbehalfby)
- [owner_adx_pollsubmission](#BKMK_owner_adx_pollsubmission)
- [team_adx_pollsubmission](#BKMK_team_adx_pollsubmission)
- [user_adx_pollsubmission](#BKMK_user_adx_pollsubmission)

### <a name="BKMK_adx_contact_pollsubmission"></a> adx_contact_pollsubmission

One-To-Many Relationship: [contact adx_contact_pollsubmission](contact.md#BKMK_adx_contact_pollsubmission)

|Property|Value|
|---|---|
|ReferencedEntity|`contact`|
|ReferencedAttribute|`contactid`|
|ReferencingAttribute|`adx_contactid`|
|ReferencingEntityNavigationPropertyName|`adx_contactid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `Cascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_adx_poll_pollsubmission"></a> adx_poll_pollsubmission

One-To-Many Relationship: [adx_poll adx_poll_pollsubmission](adx_poll.md#BKMK_adx_poll_pollsubmission)

|Property|Value|
|---|---|
|ReferencedEntity|`adx_poll`|
|ReferencedAttribute|`adx_pollid`|
|ReferencingAttribute|`adx_pollid`|
|ReferencingEntityNavigationPropertyName|`adx_pollid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_adx_polloption_pollsubmission"></a> adx_polloption_pollsubmission

One-To-Many Relationship: [adx_polloption adx_polloption_pollsubmission](adx_polloption.md#BKMK_adx_polloption_pollsubmission)

|Property|Value|
|---|---|
|ReferencedEntity|`adx_polloption`|
|ReferencedAttribute|`adx_polloptionid`|
|ReferencingAttribute|`adx_polloptionid`|
|ReferencingEntityNavigationPropertyName|`adx_polloptionid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_business_unit_adx_pollsubmission"></a> business_unit_adx_pollsubmission

One-To-Many Relationship: [businessunit business_unit_adx_pollsubmission](businessunit.md#BKMK_business_unit_adx_pollsubmission)

|Property|Value|
|---|---|
|ReferencedEntity|`businessunit`|
|ReferencedAttribute|`businessunitid`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencingEntityNavigationPropertyName|`owningbusinessunit`|
|IsHierarchical||
|CascadeConfiguration|Archive: `Restrict`<br />Assign: `NoCascade`<br />Delete: `Restrict`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_adx_pollsubmission_createdby"></a> lk_adx_pollsubmission_createdby

One-To-Many Relationship: [systemuser lk_adx_pollsubmission_createdby](systemuser.md#BKMK_lk_adx_pollsubmission_createdby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdby`|
|ReferencingEntityNavigationPropertyName|`createdby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_adx_pollsubmission_createdonbehalfby"></a> lk_adx_pollsubmission_createdonbehalfby

One-To-Many Relationship: [systemuser lk_adx_pollsubmission_createdonbehalfby](systemuser.md#BKMK_lk_adx_pollsubmission_createdonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdonbehalfby`|
|ReferencingEntityNavigationPropertyName|`createdonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_adx_pollsubmission_modifiedby"></a> lk_adx_pollsubmission_modifiedby

One-To-Many Relationship: [systemuser lk_adx_pollsubmission_modifiedby](systemuser.md#BKMK_lk_adx_pollsubmission_modifiedby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedby`|
|ReferencingEntityNavigationPropertyName|`modifiedby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_adx_pollsubmission_modifiedonbehalfby"></a> lk_adx_pollsubmission_modifiedonbehalfby

One-To-Many Relationship: [systemuser lk_adx_pollsubmission_modifiedonbehalfby](systemuser.md#BKMK_lk_adx_pollsubmission_modifiedonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedonbehalfby`|
|ReferencingEntityNavigationPropertyName|`modifiedonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_owner_adx_pollsubmission"></a> owner_adx_pollsubmission

One-To-Many Relationship: [owner owner_adx_pollsubmission](owner.md#BKMK_owner_adx_pollsubmission)

|Property|Value|
|---|---|
|ReferencedEntity|`owner`|
|ReferencedAttribute|`ownerid`|
|ReferencingAttribute|`ownerid`|
|ReferencingEntityNavigationPropertyName|`ownerid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_team_adx_pollsubmission"></a> team_adx_pollsubmission

One-To-Many Relationship: [team team_adx_pollsubmission](team.md#BKMK_team_adx_pollsubmission)

|Property|Value|
|---|---|
|ReferencedEntity|`team`|
|ReferencedAttribute|`teamid`|
|ReferencingAttribute|`owningteam`|
|ReferencingEntityNavigationPropertyName|`owningteam`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_user_adx_pollsubmission"></a> user_adx_pollsubmission

One-To-Many Relationship: [systemuser user_adx_pollsubmission](systemuser.md#BKMK_user_adx_pollsubmission)

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

- [adx_pollsubmission_ActivityPointers](#BKMK_adx_pollsubmission_ActivityPointers)
- [adx_pollsubmission_adx_alertsubscriptions](#BKMK_adx_pollsubmission_adx_alertsubscriptions)
- [adx_pollsubmission_adx_inviteredemptions](#BKMK_adx_pollsubmission_adx_inviteredemptions)
- [adx_pollsubmission_adx_portalcomments](#BKMK_adx_pollsubmission_adx_portalcomments)
- [adx_pollsubmission_Annotations](#BKMK_adx_pollsubmission_Annotations)
- [adx_pollsubmission_Appointments](#BKMK_adx_pollsubmission_Appointments)
- [adx_pollsubmission_AsyncOperations](#BKMK_adx_pollsubmission_AsyncOperations)
- [adx_pollsubmission_BulkDeleteFailures](#BKMK_adx_pollsubmission_BulkDeleteFailures)
- [adx_pollsubmission_chats](#BKMK_adx_pollsubmission_chats)
- [adx_pollsubmission_DuplicateBaseRecord](#BKMK_adx_pollsubmission_DuplicateBaseRecord)
- [adx_pollsubmission_DuplicateMatchingRecord](#BKMK_adx_pollsubmission_DuplicateMatchingRecord)
- [adx_pollsubmission_Emails](#BKMK_adx_pollsubmission_Emails)
- [adx_pollsubmission_Faxes](#BKMK_adx_pollsubmission_Faxes)
- [adx_pollsubmission_Letters](#BKMK_adx_pollsubmission_Letters)
- [adx_pollsubmission_li_inmails](#BKMK_adx_pollsubmission_li_inmails)
- [adx_pollsubmission_li_messages](#BKMK_adx_pollsubmission_li_messages)
- [adx_pollsubmission_li_pointdrivepresentationvieweds](#BKMK_adx_pollsubmission_li_pointdrivepresentationvieweds)
- [adx_pollsubmission_MailboxTrackingFolders](#BKMK_adx_pollsubmission_MailboxTrackingFolders)
- [adx_pollsubmission_msdyn_bookingalerts](#BKMK_adx_pollsubmission_msdyn_bookingalerts)
- [adx_pollsubmission_msdyn_copilottranscripts](#BKMK_adx_pollsubmission_msdyn_copilottranscripts)
- [adx_pollsubmission_msdyn_ocliveworkitems](#BKMK_adx_pollsubmission_msdyn_ocliveworkitems)
- [adx_pollsubmission_msdyn_ocoutboundmessages](#BKMK_adx_pollsubmission_msdyn_ocoutboundmessages)
- [adx_pollsubmission_msdyn_ocsessions](#BKMK_adx_pollsubmission_msdyn_ocsessions)
- [adx_pollsubmission_msdyn_ocvoicemails](#BKMK_adx_pollsubmission_msdyn_ocvoicemails)
- [adx_pollsubmission_msfp_alerts](#BKMK_adx_pollsubmission_msfp_alerts)
- [adx_pollsubmission_msfp_surveyinvites](#BKMK_adx_pollsubmission_msfp_surveyinvites)
- [adx_pollsubmission_msfp_surveyresponses](#BKMK_adx_pollsubmission_msfp_surveyresponses)
- [adx_pollsubmission_PhoneCalls](#BKMK_adx_pollsubmission_PhoneCalls)
- [adx_pollsubmission_PrincipalObjectAttributeAccesses](#BKMK_adx_pollsubmission_PrincipalObjectAttributeAccesses)
- [adx_pollsubmission_ProcessSession](#BKMK_adx_pollsubmission_ProcessSession)
- [adx_pollsubmission_RecurringAppointmentMasters](#BKMK_adx_pollsubmission_RecurringAppointmentMasters)
- [adx_pollsubmission_ServiceAppointments](#BKMK_adx_pollsubmission_ServiceAppointments)
- [adx_pollsubmission_SocialActivities](#BKMK_adx_pollsubmission_SocialActivities)
- [adx_pollsubmission_SyncErrors](#BKMK_adx_pollsubmission_SyncErrors)
- [adx_pollsubmission_Tasks](#BKMK_adx_pollsubmission_Tasks)

### <a name="BKMK_adx_pollsubmission_ActivityPointers"></a> adx_pollsubmission_ActivityPointers

Many-To-One Relationship: [activitypointer adx_pollsubmission_ActivityPointers](activitypointer.md#BKMK_adx_pollsubmission_ActivityPointers)

|Property|Value|
|---|---|
|ReferencingEntity|`activitypointer`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`adx_pollsubmission_ActivityPointers`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_adx_pollsubmission_adx_alertsubscriptions"></a> adx_pollsubmission_adx_alertsubscriptions

Many-To-One Relationship: [adx_alertsubscription adx_pollsubmission_adx_alertsubscriptions](adx_alertsubscription.md#BKMK_adx_pollsubmission_adx_alertsubscriptions)

|Property|Value|
|---|---|
|ReferencingEntity|`adx_alertsubscription`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`adx_pollsubmission_adx_alertsubscriptions`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_adx_pollsubmission_adx_inviteredemptions"></a> adx_pollsubmission_adx_inviteredemptions

Many-To-One Relationship: [adx_inviteredemption adx_pollsubmission_adx_inviteredemptions](adx_inviteredemption.md#BKMK_adx_pollsubmission_adx_inviteredemptions)

|Property|Value|
|---|---|
|ReferencingEntity|`adx_inviteredemption`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`adx_pollsubmission_adx_inviteredemptions`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_adx_pollsubmission_adx_portalcomments"></a> adx_pollsubmission_adx_portalcomments

Many-To-One Relationship: [adx_portalcomment adx_pollsubmission_adx_portalcomments](adx_portalcomment.md#BKMK_adx_pollsubmission_adx_portalcomments)

|Property|Value|
|---|---|
|ReferencingEntity|`adx_portalcomment`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`adx_pollsubmission_adx_portalcomments`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_adx_pollsubmission_Annotations"></a> adx_pollsubmission_Annotations

Many-To-One Relationship: [annotation adx_pollsubmission_Annotations](annotation.md#BKMK_adx_pollsubmission_Annotations)

|Property|Value|
|---|---|
|ReferencingEntity|`annotation`|
|ReferencingAttribute|`objectid`|
|ReferencedEntityNavigationPropertyName|`adx_pollsubmission_Annotations`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_adx_pollsubmission_Appointments"></a> adx_pollsubmission_Appointments

Many-To-One Relationship: [appointment adx_pollsubmission_Appointments](appointment.md#BKMK_adx_pollsubmission_Appointments)

|Property|Value|
|---|---|
|ReferencingEntity|`appointment`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`adx_pollsubmission_Appointments`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_adx_pollsubmission_AsyncOperations"></a> adx_pollsubmission_AsyncOperations

Many-To-One Relationship: [asyncoperation adx_pollsubmission_AsyncOperations](asyncoperation.md#BKMK_adx_pollsubmission_AsyncOperations)

|Property|Value|
|---|---|
|ReferencingEntity|`asyncoperation`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`adx_pollsubmission_AsyncOperations`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_adx_pollsubmission_BulkDeleteFailures"></a> adx_pollsubmission_BulkDeleteFailures

Many-To-One Relationship: [bulkdeletefailure adx_pollsubmission_BulkDeleteFailures](bulkdeletefailure.md#BKMK_adx_pollsubmission_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencingEntity|`bulkdeletefailure`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`adx_pollsubmission_BulkDeleteFailures`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_adx_pollsubmission_chats"></a> adx_pollsubmission_chats

Many-To-One Relationship: [chat adx_pollsubmission_chats](chat.md#BKMK_adx_pollsubmission_chats)

|Property|Value|
|---|---|
|ReferencingEntity|`chat`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`adx_pollsubmission_chats`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_adx_pollsubmission_DuplicateBaseRecord"></a> adx_pollsubmission_DuplicateBaseRecord

Many-To-One Relationship: [duplicaterecord adx_pollsubmission_DuplicateBaseRecord](duplicaterecord.md#BKMK_adx_pollsubmission_DuplicateBaseRecord)

|Property|Value|
|---|---|
|ReferencingEntity|`duplicaterecord`|
|ReferencingAttribute|`baserecordid`|
|ReferencedEntityNavigationPropertyName|`adx_pollsubmission_DuplicateBaseRecord`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_adx_pollsubmission_DuplicateMatchingRecord"></a> adx_pollsubmission_DuplicateMatchingRecord

Many-To-One Relationship: [duplicaterecord adx_pollsubmission_DuplicateMatchingRecord](duplicaterecord.md#BKMK_adx_pollsubmission_DuplicateMatchingRecord)

|Property|Value|
|---|---|
|ReferencingEntity|`duplicaterecord`|
|ReferencingAttribute|`duplicaterecordid`|
|ReferencedEntityNavigationPropertyName|`adx_pollsubmission_DuplicateMatchingRecord`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_adx_pollsubmission_Emails"></a> adx_pollsubmission_Emails

Many-To-One Relationship: [email adx_pollsubmission_Emails](email.md#BKMK_adx_pollsubmission_Emails)

|Property|Value|
|---|---|
|ReferencingEntity|`email`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`adx_pollsubmission_Emails`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_adx_pollsubmission_Faxes"></a> adx_pollsubmission_Faxes

Many-To-One Relationship: [fax adx_pollsubmission_Faxes](fax.md#BKMK_adx_pollsubmission_Faxes)

|Property|Value|
|---|---|
|ReferencingEntity|`fax`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`adx_pollsubmission_Faxes`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_adx_pollsubmission_Letters"></a> adx_pollsubmission_Letters

Many-To-One Relationship: [letter adx_pollsubmission_Letters](letter.md#BKMK_adx_pollsubmission_Letters)

|Property|Value|
|---|---|
|ReferencingEntity|`letter`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`adx_pollsubmission_Letters`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_adx_pollsubmission_li_inmails"></a> adx_pollsubmission_li_inmails

Many-To-One Relationship: [li_inmail adx_pollsubmission_li_inmails](li_inmail.md#BKMK_adx_pollsubmission_li_inmails)

|Property|Value|
|---|---|
|ReferencingEntity|`li_inmail`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`adx_pollsubmission_li_inmails`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_adx_pollsubmission_li_messages"></a> adx_pollsubmission_li_messages

Many-To-One Relationship: [li_message adx_pollsubmission_li_messages](li_message.md#BKMK_adx_pollsubmission_li_messages)

|Property|Value|
|---|---|
|ReferencingEntity|`li_message`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`adx_pollsubmission_li_messages`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_adx_pollsubmission_li_pointdrivepresentationvieweds"></a> adx_pollsubmission_li_pointdrivepresentationvieweds

Many-To-One Relationship: [li_pointdrivepresentationviewed adx_pollsubmission_li_pointdrivepresentationvieweds](li_pointdrivepresentationviewed.md#BKMK_adx_pollsubmission_li_pointdrivepresentationvieweds)

|Property|Value|
|---|---|
|ReferencingEntity|`li_pointdrivepresentationviewed`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`adx_pollsubmission_li_pointdrivepresentationvieweds`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_adx_pollsubmission_MailboxTrackingFolders"></a> adx_pollsubmission_MailboxTrackingFolders

Many-To-One Relationship: [mailboxtrackingfolder adx_pollsubmission_MailboxTrackingFolders](mailboxtrackingfolder.md#BKMK_adx_pollsubmission_MailboxTrackingFolders)

|Property|Value|
|---|---|
|ReferencingEntity|`mailboxtrackingfolder`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`adx_pollsubmission_MailboxTrackingFolders`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_adx_pollsubmission_msdyn_bookingalerts"></a> adx_pollsubmission_msdyn_bookingalerts

Many-To-One Relationship: [msdyn_bookingalert adx_pollsubmission_msdyn_bookingalerts](msdyn_bookingalert.md#BKMK_adx_pollsubmission_msdyn_bookingalerts)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_bookingalert`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`adx_pollsubmission_msdyn_bookingalerts`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_adx_pollsubmission_msdyn_copilottranscripts"></a> adx_pollsubmission_msdyn_copilottranscripts

Many-To-One Relationship: [msdyn_copilottranscript adx_pollsubmission_msdyn_copilottranscripts](msdyn_copilottranscript.md#BKMK_adx_pollsubmission_msdyn_copilottranscripts)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_copilottranscript`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`adx_pollsubmission_msdyn_copilottranscripts`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_adx_pollsubmission_msdyn_ocliveworkitems"></a> adx_pollsubmission_msdyn_ocliveworkitems

Many-To-One Relationship: [msdyn_ocliveworkitem adx_pollsubmission_msdyn_ocliveworkitems](msdyn_ocliveworkitem.md#BKMK_adx_pollsubmission_msdyn_ocliveworkitems)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocliveworkitem`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`adx_pollsubmission_msdyn_ocliveworkitems`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_adx_pollsubmission_msdyn_ocoutboundmessages"></a> adx_pollsubmission_msdyn_ocoutboundmessages

Many-To-One Relationship: [msdyn_ocoutboundmessage adx_pollsubmission_msdyn_ocoutboundmessages](msdyn_ocoutboundmessage.md#BKMK_adx_pollsubmission_msdyn_ocoutboundmessages)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocoutboundmessage`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`adx_pollsubmission_msdyn_ocoutboundmessages`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_adx_pollsubmission_msdyn_ocsessions"></a> adx_pollsubmission_msdyn_ocsessions

Many-To-One Relationship: [msdyn_ocsession adx_pollsubmission_msdyn_ocsessions](msdyn_ocsession.md#BKMK_adx_pollsubmission_msdyn_ocsessions)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocsession`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`adx_pollsubmission_msdyn_ocsessions`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_adx_pollsubmission_msdyn_ocvoicemails"></a> adx_pollsubmission_msdyn_ocvoicemails

Many-To-One Relationship: [msdyn_ocvoicemail adx_pollsubmission_msdyn_ocvoicemails](msdyn_ocvoicemail.md#BKMK_adx_pollsubmission_msdyn_ocvoicemails)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocvoicemail`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`adx_pollsubmission_msdyn_ocvoicemails`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_adx_pollsubmission_msfp_alerts"></a> adx_pollsubmission_msfp_alerts

Many-To-One Relationship: [msfp_alert adx_pollsubmission_msfp_alerts](msfp_alert.md#BKMK_adx_pollsubmission_msfp_alerts)

|Property|Value|
|---|---|
|ReferencingEntity|`msfp_alert`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`adx_pollsubmission_msfp_alerts`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_adx_pollsubmission_msfp_surveyinvites"></a> adx_pollsubmission_msfp_surveyinvites

Many-To-One Relationship: [msfp_surveyinvite adx_pollsubmission_msfp_surveyinvites](msfp_surveyinvite.md#BKMK_adx_pollsubmission_msfp_surveyinvites)

|Property|Value|
|---|---|
|ReferencingEntity|`msfp_surveyinvite`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`adx_pollsubmission_msfp_surveyinvites`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_adx_pollsubmission_msfp_surveyresponses"></a> adx_pollsubmission_msfp_surveyresponses

Many-To-One Relationship: [msfp_surveyresponse adx_pollsubmission_msfp_surveyresponses](msfp_surveyresponse.md#BKMK_adx_pollsubmission_msfp_surveyresponses)

|Property|Value|
|---|---|
|ReferencingEntity|`msfp_surveyresponse`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`adx_pollsubmission_msfp_surveyresponses`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_adx_pollsubmission_PhoneCalls"></a> adx_pollsubmission_PhoneCalls

Many-To-One Relationship: [phonecall adx_pollsubmission_PhoneCalls](phonecall.md#BKMK_adx_pollsubmission_PhoneCalls)

|Property|Value|
|---|---|
|ReferencingEntity|`phonecall`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`adx_pollsubmission_PhoneCalls`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_adx_pollsubmission_PrincipalObjectAttributeAccesses"></a> adx_pollsubmission_PrincipalObjectAttributeAccesses

Many-To-One Relationship: [principalobjectattributeaccess adx_pollsubmission_PrincipalObjectAttributeAccesses](principalobjectattributeaccess.md#BKMK_adx_pollsubmission_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencingEntity|`principalobjectattributeaccess`|
|ReferencingAttribute|`objectid`|
|ReferencedEntityNavigationPropertyName|`adx_pollsubmission_PrincipalObjectAttributeAccesses`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_adx_pollsubmission_ProcessSession"></a> adx_pollsubmission_ProcessSession

Many-To-One Relationship: [processsession adx_pollsubmission_ProcessSession](processsession.md#BKMK_adx_pollsubmission_ProcessSession)

|Property|Value|
|---|---|
|ReferencingEntity|`processsession`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`adx_pollsubmission_ProcessSession`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_adx_pollsubmission_RecurringAppointmentMasters"></a> adx_pollsubmission_RecurringAppointmentMasters

Many-To-One Relationship: [recurringappointmentmaster adx_pollsubmission_RecurringAppointmentMasters](recurringappointmentmaster.md#BKMK_adx_pollsubmission_RecurringAppointmentMasters)

|Property|Value|
|---|---|
|ReferencingEntity|`recurringappointmentmaster`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`adx_pollsubmission_RecurringAppointmentMasters`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_adx_pollsubmission_ServiceAppointments"></a> adx_pollsubmission_ServiceAppointments

Many-To-One Relationship: [serviceappointment adx_pollsubmission_ServiceAppointments](serviceappointment.md#BKMK_adx_pollsubmission_ServiceAppointments)

|Property|Value|
|---|---|
|ReferencingEntity|`serviceappointment`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`adx_pollsubmission_ServiceAppointments`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_adx_pollsubmission_SocialActivities"></a> adx_pollsubmission_SocialActivities

Many-To-One Relationship: [socialactivity adx_pollsubmission_SocialActivities](socialactivity.md#BKMK_adx_pollsubmission_SocialActivities)

|Property|Value|
|---|---|
|ReferencingEntity|`socialactivity`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`adx_pollsubmission_SocialActivities`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_adx_pollsubmission_SyncErrors"></a> adx_pollsubmission_SyncErrors

Many-To-One Relationship: [syncerror adx_pollsubmission_SyncErrors](syncerror.md#BKMK_adx_pollsubmission_SyncErrors)

|Property|Value|
|---|---|
|ReferencingEntity|`syncerror`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`adx_pollsubmission_SyncErrors`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_adx_pollsubmission_Tasks"></a> adx_pollsubmission_Tasks

Many-To-One Relationship: [task adx_pollsubmission_Tasks](task.md#BKMK_adx_pollsubmission_Tasks)

|Property|Value|
|---|---|
|ReferencingEntity|`task`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`adx_pollsubmission_Tasks`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|



### See also

[Dataverse table/entity reference](../about-entity-reference.md)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   

