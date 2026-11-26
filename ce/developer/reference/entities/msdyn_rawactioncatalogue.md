---
title: "rawactioncatalogue (msdyn_rawactioncatalogue) table/entity reference (Microsoft Dynamics 365)"
description: "Includes schema information and supported messages for the rawactioncatalogue (msdyn_rawactioncatalogue) table/entity with Microsoft Dynamics 365."
ms.topic: generated-reference
author: JimDaly
ms.author: jdaly
search.audienceType: 
  - developer
---

# rawactioncatalogue (msdyn_rawactioncatalogue) table/entity reference (Microsoft Dynamics 365)



## Messages

The following table lists the messages for the rawactioncatalogue (msdyn_rawactioncatalogue) table.
Messages represent operations that can be performed on the table. They may also be events.

| Name <br />Is Event? |Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `Assign`<br />Event: True |`PATCH` /msdyn_rawactioncatalogues(*msdyn_rawactioncatalogueid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `ownerid` property. |<xref:Microsoft.Crm.Sdk.Messages.AssignRequest>|
| `Associate`<br />Event: True |[Associate records](/power-apps/developer/data-platform/webapi/associate-disassociate-entities-using-web-api) |[Associate records](/power-apps/developer/data-platform/org-service/entity-operations-associate-disassociate#use-the-associate-method-or-associaterequest)|
| `BulkRetain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.BulkRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Create`<br />Event: True |`POST` /msdyn_rawactioncatalogues<br />See [Create](/powerapps/developer/data-platform/webapi/create-entity-web-api) |[Create records](/power-apps/developer/data-platform/org-service/entity-operations-create#basic-create)|
| `CreateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.CreateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.CreateMultipleRequest>|
| `Delete`<br />Event: True |`DELETE` /msdyn_rawactioncatalogues(*msdyn_rawactioncatalogueid*)<br />See [Delete](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-delete) |[Delete records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-delete)|
| `Disassociate`<br />Event: True |[Disassociate records](/power-apps/developer/data-platform/webapi/associate-disassociate-entities-using-web-api) |[Disassociate records](/power-apps/developer/data-platform/org-service/entity-operations-associate-disassociate#use-the-disassociate-method-or-disassociaterequest)|
| `GrantAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.GrantAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.GrantAccessRequest>|
| `IsValidStateTransition`<br />Event: False |<xref:Microsoft.Dynamics.CRM.IsValidStateTransition?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.IsValidStateTransitionRequest>|
| `ModifyAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.ModifyAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.ModifyAccessRequest>|
| `PurgeRetainedContent`<br />Event: True |<xref:Microsoft.Dynamics.CRM.PurgeRetainedContent?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.Retain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retrieve`<br />Event: True |`GET` /msdyn_rawactioncatalogues(*msdyn_rawactioncatalogueid*)<br />See [Retrieve](/powerapps/developer/data-platform/webapi/retrieve-entity-using-web-api) |[Retrieve records](/power-apps/developer/data-platform/org-service/entity-operations-retrieve)|
| `RetrieveMultiple`<br />Event: True |`GET` /msdyn_rawactioncatalogues<br />See [Query data](/power-apps/developer/data-platform/webapi/query-data-web-api) |[Query data](/power-apps/developer/data-platform/org-service/entity-operations-query-data)|
| `RetrievePrincipalAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RetrievePrincipalAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RetrievePrincipalAccessRequest>|
| `RetrieveSharedPrincipalsAndAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RetrieveSharedPrincipalsAndAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RetrieveSharedPrincipalsAndAccessRequest>|
| `RevokeAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RevokeAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RevokeAccessRequest>|
| `RollbackRetain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RollbackRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `SetState`<br />Event: True |`PATCH` /msdyn_rawactioncatalogues(*msdyn_rawactioncatalogueid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `statecode` and `statuscode` properties. |<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|
| `Update`<br />Event: True |`PATCH` /msdyn_rawactioncatalogues(*msdyn_rawactioncatalogueid*)<br />See [Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) |[Update records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-update)|
| `UpdateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.UpdateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpdateMultipleRequest>|
| `Upsert`<br />Event: False |`PATCH` /msdyn_rawactioncatalogues(*msdyn_rawactioncatalogueid*)<br />See [Upsert a table row](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#upsert-a-table-row) |<xref:Microsoft.Xrm.Sdk.Messages.UpsertRequest>|
| `UpsertMultiple`<br />Event: False |<xref:Microsoft.Dynamics.CRM.UpsertMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpsertMultipleRequest>|
| `ValidateRetentionConfig`<br />Event: True |<xref:Microsoft.Dynamics.CRM.ValidateRetentionConfig?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|

## Properties

The following table lists selected properties for the rawactioncatalogue (msdyn_rawactioncatalogue) table.

|Property|Value|
| --- | --- |
| **DisplayName** | **rawactioncatalogue** |
| **DisplayCollectionName** | **rawactioncatalogues** |
| **SchemaName** | `msdyn_rawactioncatalogue` |
| **CollectionSchemaName** | `msdyn_rawactioncatalogues` |
| **EntitySetName** | `msdyn_rawactioncatalogues`|
| **LogicalName** | `msdyn_rawactioncatalogue` |
| **LogicalCollectionName** | `msdyn_rawactioncatalogues` |
| **PrimaryIdAttribute** | `msdyn_rawactioncatalogueid` |
| **PrimaryNameAttribute** |`msdyn_actionid` |
| **TableType** | `Standard` |
| **OwnershipType** | `UserOwned` |

## Writable columns/attributes

These columns/attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [msdyn_actionid](#BKMK_msdyn_actionid)
- [msdyn_actionreason](#BKMK_msdyn_actionreason)
- [msdyn_actionuipayload](#BKMK_msdyn_actionuipayload)
- [msdyn_expireson](#BKMK_msdyn_expireson)
- [msdyn_prioritizationdata](#BKMK_msdyn_prioritizationdata)
- [msdyn_rawactioncatalogueId](#BKMK_msdyn_rawactioncatalogueId)
- [msdyn_salesprioritizationprinciple](#BKMK_msdyn_salesprioritizationprinciple)
- [msdyn_sourceagentconfig](#BKMK_msdyn_sourceagentconfig)
- [msdyn_TargetentityId](#BKMK_msdyn_TargetentityId)
- [msdyn_TargetentityIdType](#BKMK_msdyn_TargetentityIdType)
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

### <a name="BKMK_msdyn_actionid"></a> msdyn_actionid

|Property|Value|
|---|---|
|Description|**ActionId**|
|DisplayName|**actionid**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_actionid`|
|RequiredLevel|ApplicationRequired|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|850|

### <a name="BKMK_msdyn_actionreason"></a> msdyn_actionreason

|Property|Value|
|---|---|
|Description|**reason for the action**|
|DisplayName|**actionreason**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_actionreason`|
|RequiredLevel|None|
|Type|Memo|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|1048576|

### <a name="BKMK_msdyn_actionuipayload"></a> msdyn_actionuipayload

|Property|Value|
|---|---|
|Description|**UI payload for the action**|
|DisplayName|**actionuipayload**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_actionuipayload`|
|RequiredLevel|None|
|Type|Memo|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|1000000000|

### <a name="BKMK_msdyn_expireson"></a> msdyn_expireson

|Property|Value|
|---|---|
|Description|**The date and time when this action record expires and should be considered no longer valid.**|
|DisplayName|**Expires On**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_expireson`|
|RequiredLevel|None|
|Type|DateTime|
|CanChangeDateTimeBehavior|False|
|DateTimeBehavior|UserLocal|
|Format|DateAndTime|
|ImeMode|Inactive|
|SourceTypeMask|0|

### <a name="BKMK_msdyn_prioritizationdata"></a> msdyn_prioritizationdata

|Property|Value|
|---|---|
|Description|**Prioritization data**|
|DisplayName|**Prioritization data**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_prioritizationdata`|
|RequiredLevel|None|
|Type|Memo|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|1048576|

### <a name="BKMK_msdyn_rawactioncatalogueId"></a> msdyn_rawactioncatalogueId

|Property|Value|
|---|---|
|Description|**Unique identifier for entity instances**|
|DisplayName|**rawactioncatalogue**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`msdyn_rawactioncatalogueid`|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|

### <a name="BKMK_msdyn_salesprioritizationprinciple"></a> msdyn_salesprioritizationprinciple

|Property|Value|
|---|---|
|Description|**The sales prioritization principle associated with this action.**|
|DisplayName|**Sales Prioritization Principle**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_salesprioritizationprinciple`|
|RequiredLevel|None|
|Type|MultiSelectPicklist|
|DefaultFormValue||
|GlobalChoiceName|`msdyn_recommendedactionagent_salesprioritizationprinciples`|

#### msdyn_salesprioritizationprinciple Choices/Options

|Value|Label|
|---|---|
|1|**Revenue Generation**|
|2|**Deal Velocity**|
|3|**Pipeline Generation**|
|4|**Risk Reduction**|
|5|**Customer Sentiment**|
|6|**Data Hygiene**|
|7|**Stakeholder Coverage**|

### <a name="BKMK_msdyn_sourceagentconfig"></a> msdyn_sourceagentconfig

|Property|Value|
|---|---|
|Description|**Reference to recommendedactionssourceagentconfig**|
|DisplayName|**Source Agent Configuration**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_sourceagentconfig`|
|RequiredLevel|ApplicationRequired|
|Type|Lookup|
|Targets|msdyn_recommendedactionsourceagentconfig|

### <a name="BKMK_msdyn_TargetentityId"></a> msdyn_TargetentityId

|Property|Value|
|---|---|
|Description||
|DisplayName|**targetentity**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_targetentityid`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|account, contact, lead, opportunity|

### <a name="BKMK_msdyn_TargetentityIdType"></a> msdyn_TargetentityIdType

|Property|Value|
|---|---|
|Description||
|DisplayName||
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`msdyn_targetentityidtype`|
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
|Description|**Status of the rawactioncatalogue**|
|DisplayName|**Status**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statecode`|
|RequiredLevel|SystemRequired|
|Type|State|
|DefaultFormValue||
|GlobalChoiceName|`msdyn_rawactioncatalogue_statecode`|

#### statecode Choices/Options

|Value|Details|
|---|---|
|0|Label: **Active**<br />DefaultStatus: 1<br />InvariantName: `Active`|
|1|Label: **Inactive**<br />DefaultStatus: 5<br />InvariantName: `Inactive`|

### <a name="BKMK_statuscode"></a> statuscode

|Property|Value|
|---|---|
|Description|**Reason for the status of the rawactioncatalogue**|
|DisplayName|**Status Reason**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statuscode`|
|RequiredLevel|None|
|Type|Status|
|DefaultFormValue||
|GlobalChoiceName|`msdyn_rawactioncatalogue_statuscode`|

#### statuscode Choices/Options

|Value|Details|
|---|---|
|1|Label: **Active**<br />State:0<br />TransitionData: None|
|2|Label: **Obsolete**<br />State:0<br />TransitionData: None|
|3|Label: **Skipped**<br />State:0<br />TransitionData: None|
|4|Label: **Error**<br />State:1<br />TransitionData: None|
|5|Label: **Removed**<br />State:1<br />TransitionData: None|

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

- [business_unit_msdyn_rawactioncatalogue](#BKMK_business_unit_msdyn_rawactioncatalogue)
- [lk_msdyn_rawactioncatalogue_createdby](#BKMK_lk_msdyn_rawactioncatalogue_createdby)
- [lk_msdyn_rawactioncatalogue_createdonbehalfby](#BKMK_lk_msdyn_rawactioncatalogue_createdonbehalfby)
- [lk_msdyn_rawactioncatalogue_modifiedby](#BKMK_lk_msdyn_rawactioncatalogue_modifiedby)
- [lk_msdyn_rawactioncatalogue_modifiedonbehalfby](#BKMK_lk_msdyn_rawactioncatalogue_modifiedonbehalfby)
- [msdyn_rawactioncatalogue_account_msdyn_TargetentityId](#BKMK_msdyn_rawactioncatalogue_account_msdyn_TargetentityId)
- [msdyn_rawactioncatalogue_contact_msdyn_TargetentityId](#BKMK_msdyn_rawactioncatalogue_contact_msdyn_TargetentityId)
- [msdyn_rawactioncatalogue_lead_msdyn_TargetentityId](#BKMK_msdyn_rawactioncatalogue_lead_msdyn_TargetentityId)
- [msdyn_rawactioncatalogue_msdyn_recommendedactionsourceagentconfig](#BKMK_msdyn_rawactioncatalogue_msdyn_recommendedactionsourceagentconfig)
- [msdyn_rawactioncatalogue_opportunity_msdyn_TargetentityId](#BKMK_msdyn_rawactioncatalogue_opportunity_msdyn_TargetentityId)
- [owner_msdyn_rawactioncatalogue](#BKMK_owner_msdyn_rawactioncatalogue)
- [team_msdyn_rawactioncatalogue](#BKMK_team_msdyn_rawactioncatalogue)
- [user_msdyn_rawactioncatalogue](#BKMK_user_msdyn_rawactioncatalogue)

### <a name="BKMK_business_unit_msdyn_rawactioncatalogue"></a> business_unit_msdyn_rawactioncatalogue

One-To-Many Relationship: [businessunit business_unit_msdyn_rawactioncatalogue](businessunit.md#BKMK_business_unit_msdyn_rawactioncatalogue)

|Property|Value|
|---|---|
|ReferencedEntity|`businessunit`|
|ReferencedAttribute|`businessunitid`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencingEntityNavigationPropertyName|`owningbusinessunit`|
|IsHierarchical||
|CascadeConfiguration|Archive: `Restrict`<br />Assign: `NoCascade`<br />Delete: `Restrict`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_rawactioncatalogue_createdby"></a> lk_msdyn_rawactioncatalogue_createdby

One-To-Many Relationship: [systemuser lk_msdyn_rawactioncatalogue_createdby](systemuser.md#BKMK_lk_msdyn_rawactioncatalogue_createdby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdby`|
|ReferencingEntityNavigationPropertyName|`createdby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_rawactioncatalogue_createdonbehalfby"></a> lk_msdyn_rawactioncatalogue_createdonbehalfby

One-To-Many Relationship: [systemuser lk_msdyn_rawactioncatalogue_createdonbehalfby](systemuser.md#BKMK_lk_msdyn_rawactioncatalogue_createdonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdonbehalfby`|
|ReferencingEntityNavigationPropertyName|`createdonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_rawactioncatalogue_modifiedby"></a> lk_msdyn_rawactioncatalogue_modifiedby

One-To-Many Relationship: [systemuser lk_msdyn_rawactioncatalogue_modifiedby](systemuser.md#BKMK_lk_msdyn_rawactioncatalogue_modifiedby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedby`|
|ReferencingEntityNavigationPropertyName|`modifiedby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_rawactioncatalogue_modifiedonbehalfby"></a> lk_msdyn_rawactioncatalogue_modifiedonbehalfby

One-To-Many Relationship: [systemuser lk_msdyn_rawactioncatalogue_modifiedonbehalfby](systemuser.md#BKMK_lk_msdyn_rawactioncatalogue_modifiedonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedonbehalfby`|
|ReferencingEntityNavigationPropertyName|`modifiedonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_rawactioncatalogue_account_msdyn_TargetentityId"></a> msdyn_rawactioncatalogue_account_msdyn_TargetentityId

One-To-Many Relationship: [account msdyn_rawactioncatalogue_account_msdyn_TargetentityId](account.md#BKMK_msdyn_rawactioncatalogue_account_msdyn_TargetentityId)

|Property|Value|
|---|---|
|ReferencedEntity|`account`|
|ReferencedAttribute|`accountid`|
|ReferencingAttribute|`msdyn_targetentityid`|
|ReferencingEntityNavigationPropertyName|`msdyn_TargetentityId_account`|
|IsHierarchical||
|CascadeConfiguration|Archive: `RemoveLink`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `Cascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_rawactioncatalogue_contact_msdyn_TargetentityId"></a> msdyn_rawactioncatalogue_contact_msdyn_TargetentityId

One-To-Many Relationship: [contact msdyn_rawactioncatalogue_contact_msdyn_TargetentityId](contact.md#BKMK_msdyn_rawactioncatalogue_contact_msdyn_TargetentityId)

|Property|Value|
|---|---|
|ReferencedEntity|`contact`|
|ReferencedAttribute|`contactid`|
|ReferencingAttribute|`msdyn_targetentityid`|
|ReferencingEntityNavigationPropertyName|`msdyn_TargetentityId_contact`|
|IsHierarchical||
|CascadeConfiguration|Archive: `RemoveLink`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `Cascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_rawactioncatalogue_lead_msdyn_TargetentityId"></a> msdyn_rawactioncatalogue_lead_msdyn_TargetentityId

One-To-Many Relationship: [lead msdyn_rawactioncatalogue_lead_msdyn_TargetentityId](lead.md#BKMK_msdyn_rawactioncatalogue_lead_msdyn_TargetentityId)

|Property|Value|
|---|---|
|ReferencedEntity|`lead`|
|ReferencedAttribute|`leadid`|
|ReferencingAttribute|`msdyn_targetentityid`|
|ReferencingEntityNavigationPropertyName|`msdyn_TargetentityId_lead`|
|IsHierarchical||
|CascadeConfiguration|Archive: `RemoveLink`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `Cascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_rawactioncatalogue_msdyn_recommendedactionsourceagentconfig"></a> msdyn_rawactioncatalogue_msdyn_recommendedactionsourceagentconfig

One-To-Many Relationship: [msdyn_recommendedactionsourceagentconfig msdyn_rawactioncatalogue_msdyn_recommendedactionsourceagentconfig](msdyn_recommendedactionsourceagentconfig.md#BKMK_msdyn_rawactioncatalogue_msdyn_recommendedactionsourceagentconfig)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_recommendedactionsourceagentconfig`|
|ReferencedAttribute|`msdyn_recommendedactionsourceagentconfigid`|
|ReferencingAttribute|`msdyn_sourceagentconfig`|
|ReferencingEntityNavigationPropertyName|`msdyn_sourceagentconfig`|
|IsHierarchical||
|CascadeConfiguration|Archive: `RemoveLink`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_rawactioncatalogue_opportunity_msdyn_TargetentityId"></a> msdyn_rawactioncatalogue_opportunity_msdyn_TargetentityId

One-To-Many Relationship: [opportunity msdyn_rawactioncatalogue_opportunity_msdyn_TargetentityId](opportunity.md#BKMK_msdyn_rawactioncatalogue_opportunity_msdyn_TargetentityId)

|Property|Value|
|---|---|
|ReferencedEntity|`opportunity`|
|ReferencedAttribute|`opportunityid`|
|ReferencingAttribute|`msdyn_targetentityid`|
|ReferencingEntityNavigationPropertyName|`msdyn_TargetentityId_opportunity`|
|IsHierarchical||
|CascadeConfiguration|Archive: `RemoveLink`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_owner_msdyn_rawactioncatalogue"></a> owner_msdyn_rawactioncatalogue

One-To-Many Relationship: [owner owner_msdyn_rawactioncatalogue](owner.md#BKMK_owner_msdyn_rawactioncatalogue)

|Property|Value|
|---|---|
|ReferencedEntity|`owner`|
|ReferencedAttribute|`ownerid`|
|ReferencingAttribute|`ownerid`|
|ReferencingEntityNavigationPropertyName|`ownerid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_team_msdyn_rawactioncatalogue"></a> team_msdyn_rawactioncatalogue

One-To-Many Relationship: [team team_msdyn_rawactioncatalogue](team.md#BKMK_team_msdyn_rawactioncatalogue)

|Property|Value|
|---|---|
|ReferencedEntity|`team`|
|ReferencedAttribute|`teamid`|
|ReferencingAttribute|`owningteam`|
|ReferencingEntityNavigationPropertyName|`owningteam`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_user_msdyn_rawactioncatalogue"></a> user_msdyn_rawactioncatalogue

One-To-Many Relationship: [systemuser user_msdyn_rawactioncatalogue](systemuser.md#BKMK_user_msdyn_rawactioncatalogue)

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

- [msdyn_prioritizedactioncatalogue_msdyn_rawactioncatalogue](#BKMK_msdyn_prioritizedactioncatalogue_msdyn_rawactioncatalogue)
- [msdyn_rawactioncatalogue_AsyncOperations](#BKMK_msdyn_rawactioncatalogue_AsyncOperations)
- [msdyn_rawactioncatalogue_BulkDeleteFailures](#BKMK_msdyn_rawactioncatalogue_BulkDeleteFailures)
- [msdyn_rawactioncatalogue_DuplicateBaseRecord](#BKMK_msdyn_rawactioncatalogue_DuplicateBaseRecord)
- [msdyn_rawactioncatalogue_DuplicateMatchingRecord](#BKMK_msdyn_rawactioncatalogue_DuplicateMatchingRecord)
- [msdyn_rawactioncatalogue_MailboxTrackingFolders](#BKMK_msdyn_rawactioncatalogue_MailboxTrackingFolders)
- [msdyn_rawactioncatalogue_PrincipalObjectAttributeAccesses](#BKMK_msdyn_rawactioncatalogue_PrincipalObjectAttributeAccesses)
- [msdyn_rawactioncatalogue_ProcessSession](#BKMK_msdyn_rawactioncatalogue_ProcessSession)
- [msdyn_rawactioncatalogue_SyncErrors](#BKMK_msdyn_rawactioncatalogue_SyncErrors)
- [msdyn_recommendedactionrundetails_msdyn_rawactioncatalogue](#BKMK_msdyn_recommendedactionrundetails_msdyn_rawactioncatalogue)

### <a name="BKMK_msdyn_prioritizedactioncatalogue_msdyn_rawactioncatalogue"></a> msdyn_prioritizedactioncatalogue_msdyn_rawactioncatalogue

Many-To-One Relationship: [msdyn_prioritizedactioncatalogue msdyn_prioritizedactioncatalogue_msdyn_rawactioncatalogue](msdyn_prioritizedactioncatalogue.md#BKMK_msdyn_prioritizedactioncatalogue_msdyn_rawactioncatalogue)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_prioritizedactioncatalogue`|
|ReferencingAttribute|`msdyn_rawactioncatalogueid`|
|ReferencedEntityNavigationPropertyName|`msdyn_prioritizedactioncatalogue_msdyn_rawactioncatalogue`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_rawactioncatalogue_AsyncOperations"></a> msdyn_rawactioncatalogue_AsyncOperations

Many-To-One Relationship: [asyncoperation msdyn_rawactioncatalogue_AsyncOperations](asyncoperation.md#BKMK_msdyn_rawactioncatalogue_AsyncOperations)

|Property|Value|
|---|---|
|ReferencingEntity|`asyncoperation`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_rawactioncatalogue_AsyncOperations`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_rawactioncatalogue_BulkDeleteFailures"></a> msdyn_rawactioncatalogue_BulkDeleteFailures

Many-To-One Relationship: [bulkdeletefailure msdyn_rawactioncatalogue_BulkDeleteFailures](bulkdeletefailure.md#BKMK_msdyn_rawactioncatalogue_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencingEntity|`bulkdeletefailure`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_rawactioncatalogue_BulkDeleteFailures`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_rawactioncatalogue_DuplicateBaseRecord"></a> msdyn_rawactioncatalogue_DuplicateBaseRecord

Many-To-One Relationship: [duplicaterecord msdyn_rawactioncatalogue_DuplicateBaseRecord](duplicaterecord.md#BKMK_msdyn_rawactioncatalogue_DuplicateBaseRecord)

|Property|Value|
|---|---|
|ReferencingEntity|`duplicaterecord`|
|ReferencingAttribute|`baserecordid`|
|ReferencedEntityNavigationPropertyName|`msdyn_rawactioncatalogue_DuplicateBaseRecord`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_rawactioncatalogue_DuplicateMatchingRecord"></a> msdyn_rawactioncatalogue_DuplicateMatchingRecord

Many-To-One Relationship: [duplicaterecord msdyn_rawactioncatalogue_DuplicateMatchingRecord](duplicaterecord.md#BKMK_msdyn_rawactioncatalogue_DuplicateMatchingRecord)

|Property|Value|
|---|---|
|ReferencingEntity|`duplicaterecord`|
|ReferencingAttribute|`duplicaterecordid`|
|ReferencedEntityNavigationPropertyName|`msdyn_rawactioncatalogue_DuplicateMatchingRecord`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_rawactioncatalogue_MailboxTrackingFolders"></a> msdyn_rawactioncatalogue_MailboxTrackingFolders

Many-To-One Relationship: [mailboxtrackingfolder msdyn_rawactioncatalogue_MailboxTrackingFolders](mailboxtrackingfolder.md#BKMK_msdyn_rawactioncatalogue_MailboxTrackingFolders)

|Property|Value|
|---|---|
|ReferencingEntity|`mailboxtrackingfolder`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_rawactioncatalogue_MailboxTrackingFolders`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_rawactioncatalogue_PrincipalObjectAttributeAccesses"></a> msdyn_rawactioncatalogue_PrincipalObjectAttributeAccesses

Many-To-One Relationship: [principalobjectattributeaccess msdyn_rawactioncatalogue_PrincipalObjectAttributeAccesses](principalobjectattributeaccess.md#BKMK_msdyn_rawactioncatalogue_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencingEntity|`principalobjectattributeaccess`|
|ReferencingAttribute|`objectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_rawactioncatalogue_PrincipalObjectAttributeAccesses`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_rawactioncatalogue_ProcessSession"></a> msdyn_rawactioncatalogue_ProcessSession

Many-To-One Relationship: [processsession msdyn_rawactioncatalogue_ProcessSession](processsession.md#BKMK_msdyn_rawactioncatalogue_ProcessSession)

|Property|Value|
|---|---|
|ReferencingEntity|`processsession`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_rawactioncatalogue_ProcessSession`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_rawactioncatalogue_SyncErrors"></a> msdyn_rawactioncatalogue_SyncErrors

Many-To-One Relationship: [syncerror msdyn_rawactioncatalogue_SyncErrors](syncerror.md#BKMK_msdyn_rawactioncatalogue_SyncErrors)

|Property|Value|
|---|---|
|ReferencingEntity|`syncerror`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_rawactioncatalogue_SyncErrors`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_recommendedactionrundetails_msdyn_rawactioncatalogue"></a> msdyn_recommendedactionrundetails_msdyn_rawactioncatalogue

Many-To-One Relationship: [msdyn_recommendedactionrundetails msdyn_recommendedactionrundetails_msdyn_rawactioncatalogue](msdyn_recommendedactionrundetails.md#BKMK_msdyn_recommendedactionrundetails_msdyn_rawactioncatalogue)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_recommendedactionrundetails`|
|ReferencingAttribute|`msdyn_rawactioncatalogueid`|
|ReferencedEntityNavigationPropertyName|`msdyn_recommendedactionrundetails_msdyn_rawactioncatalogue`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|



### See also

[Dataverse table/entity reference](/power-apps/developer/data-platform/reference/about-entity-reference)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   

