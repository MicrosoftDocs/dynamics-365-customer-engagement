---
title: "Prioritized Action Catalogue (msdyn_prioritizedactioncatalogue) table/entity reference (Microsoft Dynamics 365)"
description: "Includes schema information and supported messages for the Prioritized Action Catalogue (msdyn_prioritizedactioncatalogue) table/entity with Microsoft Dynamics 365."
ms.topic: generated-reference
author: JimDaly
ms.author: jdaly
search.audienceType: 
  - developer
---

# Prioritized Action Catalogue (msdyn_prioritizedactioncatalogue) table/entity reference (Microsoft Dynamics 365)

Stores the result of scoring done by recommended actions agent for each action.

## Messages

The following table lists the messages for the Prioritized Action Catalogue (msdyn_prioritizedactioncatalogue) table.
Messages represent operations that can be performed on the table. They may also be events.

| Name <br />Is Event? |Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `Assign`<br />Event: True |`PATCH` /msdyn_prioritizedactioncatalogues(*msdyn_prioritizedactioncatalogueid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `ownerid` property. |<xref:Microsoft.Crm.Sdk.Messages.AssignRequest>|
| `Associate`<br />Event: True |[Associate records](/power-apps/developer/data-platform/webapi/associate-disassociate-entities-using-web-api) |[Associate records](/power-apps/developer/data-platform/org-service/entity-operations-associate-disassociate#use-the-associate-method-or-associaterequest)|
| `BulkRetain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.BulkRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Create`<br />Event: True |`POST` /msdyn_prioritizedactioncatalogues<br />See [Create](/powerapps/developer/data-platform/webapi/create-entity-web-api) |[Create records](/power-apps/developer/data-platform/org-service/entity-operations-create#basic-create)|
| `CreateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.CreateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.CreateMultipleRequest>|
| `Delete`<br />Event: True |`DELETE` /msdyn_prioritizedactioncatalogues(*msdyn_prioritizedactioncatalogueid*)<br />See [Delete](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-delete) |[Delete records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-delete)|
| `Disassociate`<br />Event: True |[Disassociate records](/power-apps/developer/data-platform/webapi/associate-disassociate-entities-using-web-api) |[Disassociate records](/power-apps/developer/data-platform/org-service/entity-operations-associate-disassociate#use-the-disassociate-method-or-disassociaterequest)|
| `GrantAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.GrantAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.GrantAccessRequest>|
| `IsValidStateTransition`<br />Event: False |<xref:Microsoft.Dynamics.CRM.IsValidStateTransition?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.IsValidStateTransitionRequest>|
| `ModifyAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.ModifyAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.ModifyAccessRequest>|
| `PurgeRetainedContent`<br />Event: True |<xref:Microsoft.Dynamics.CRM.PurgeRetainedContent?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.Retain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retrieve`<br />Event: True |`GET` /msdyn_prioritizedactioncatalogues(*msdyn_prioritizedactioncatalogueid*)<br />See [Retrieve](/powerapps/developer/data-platform/webapi/retrieve-entity-using-web-api) |[Retrieve records](/power-apps/developer/data-platform/org-service/entity-operations-retrieve)|
| `RetrieveMultiple`<br />Event: True |`GET` /msdyn_prioritizedactioncatalogues<br />See [Query data](/power-apps/developer/data-platform/webapi/query-data-web-api) |[Query data](/power-apps/developer/data-platform/org-service/entity-operations-query-data)|
| `RetrievePrincipalAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RetrievePrincipalAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RetrievePrincipalAccessRequest>|
| `RetrieveSharedPrincipalsAndAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RetrieveSharedPrincipalsAndAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RetrieveSharedPrincipalsAndAccessRequest>|
| `RevokeAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RevokeAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RevokeAccessRequest>|
| `RollbackRetain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RollbackRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `SetState`<br />Event: True |`PATCH` /msdyn_prioritizedactioncatalogues(*msdyn_prioritizedactioncatalogueid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `statecode` and `statuscode` properties. |<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|
| `Update`<br />Event: True |`PATCH` /msdyn_prioritizedactioncatalogues(*msdyn_prioritizedactioncatalogueid*)<br />See [Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) |[Update records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-update)|
| `UpdateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.UpdateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpdateMultipleRequest>|
| `Upsert`<br />Event: False |`PATCH` /msdyn_prioritizedactioncatalogues(*msdyn_prioritizedactioncatalogueid*)<br />See [Upsert a table row](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#upsert-a-table-row) |<xref:Microsoft.Xrm.Sdk.Messages.UpsertRequest>|
| `UpsertMultiple`<br />Event: False |<xref:Microsoft.Dynamics.CRM.UpsertMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpsertMultipleRequest>|
| `ValidateRetentionConfig`<br />Event: True |<xref:Microsoft.Dynamics.CRM.ValidateRetentionConfig?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|

## Properties

The following table lists selected properties for the Prioritized Action Catalogue (msdyn_prioritizedactioncatalogue) table.

|Property|Value|
| --- | --- |
| **DisplayName** | **Prioritized Action Catalogue** |
| **DisplayCollectionName** | **Prioritized Action Catalogues** |
| **SchemaName** | `msdyn_prioritizedactioncatalogue` |
| **CollectionSchemaName** | `msdyn_prioritizedactioncatalogues` |
| **EntitySetName** | `msdyn_prioritizedactioncatalogues`|
| **LogicalName** | `msdyn_prioritizedactioncatalogue` |
| **LogicalCollectionName** | `msdyn_prioritizedactioncatalogues` |
| **PrimaryIdAttribute** | `msdyn_prioritizedactioncatalogueid` |
| **PrimaryNameAttribute** |`msdyn_actionid` |
| **TableType** | `Standard` |
| **OwnershipType** | `UserOwned` |

## Writable columns/attributes

These columns/attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [msdyn_actionid](#BKMK_msdyn_actionid)
- [msdyn_actionscore](#BKMK_msdyn_actionscore)
- [msdyn_actionuipayload](#BKMK_msdyn_actionuipayload)
- [msdyn_actionuistatus](#BKMK_msdyn_actionuistatus)
- [msdyn_eventgroupid](#BKMK_msdyn_eventgroupid)
- [msdyn_eventid](#BKMK_msdyn_eventid)
- [msdyn_eventtype](#BKMK_msdyn_eventtype)
- [msdyn_expireson](#BKMK_msdyn_expireson)
- [msdyn_hascrossedceiling](#BKMK_msdyn_hascrossedceiling)
- [msdyn_hascrossedfloor](#BKMK_msdyn_hascrossedfloor)
- [msdyn_prioritizedactioncatalogueId](#BKMK_msdyn_prioritizedactioncatalogueId)
- [msdyn_rawactioncatalogueId](#BKMK_msdyn_rawactioncatalogueId)
- [msdyn_scoredetails](#BKMK_msdyn_scoredetails)
- [msdyn_sourceagentconfig](#BKMK_msdyn_sourceagentconfig)
- [msdyn_targetentity](#BKMK_msdyn_targetentity)
- [msdyn_targetentityIdType](#BKMK_msdyn_targetentityIdType)
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
|Description|**Action id from Raw Action Catalogue entity for which scoring is completed.**|
|DisplayName|**Action Id**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_actionid`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdyn_actionscore"></a> msdyn_actionscore

|Property|Value|
|---|---|
|Description|**Prioritization score for the action as generated by agent.**|
|DisplayName|**Action Score**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_actionscore`|
|RequiredLevel|None|
|Type|Double|
|ImeMode|Auto|
|MaxValue|1000000000|
|MinValue|0|
|Precision|2|

### <a name="BKMK_msdyn_actionuipayload"></a> msdyn_actionuipayload

|Property|Value|
|---|---|
|Description|**Payload containing snapshot data for scored actions.**|
|DisplayName|**Action UI Payload**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_actionuipayload`|
|RequiredLevel|None|
|Type|Memo|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|1048576|

### <a name="BKMK_msdyn_actionuistatus"></a> msdyn_actionuistatus

|Property|Value|
|---|---|
|Description|**Status of the action taken on card**|
|DisplayName|**Action UI Status**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_actionuistatus`|
|RequiredLevel|None|
|Type|Picklist|
|DefaultFormValue|1|
|GlobalChoiceName|`msdyn_prioritizedactioncatalogue_msdyn_actionuistatus`|

#### msdyn_actionuistatus Choices/Options

|Value|Label|
|---|---|
|1|**Active**|
|2|**MarkAsDone**|
|3|**Dismissed**|

### <a name="BKMK_msdyn_eventgroupid"></a> msdyn_eventgroupid

|Property|Value|
|---|---|
|Description|**Group identifier linking related M365 events for this action.**|
|DisplayName|**Event Group Id**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_eventgroupid`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|2000|

### <a name="BKMK_msdyn_eventid"></a> msdyn_eventid

|Property|Value|
|---|---|
|Description|**Identifier of the M365 event that originated this action.**|
|DisplayName|**Event Id**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_eventid`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|2000|

### <a name="BKMK_msdyn_eventtype"></a> msdyn_eventtype

|Property|Value|
|---|---|
|Description|**Type of the M365 event that originated this action.**|
|DisplayName|**Event Type**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_eventtype`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|2000|

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

### <a name="BKMK_msdyn_hascrossedceiling"></a> msdyn_hascrossedceiling

|Property|Value|
|---|---|
|Description|**Whether the action is above ceiling criteria.**|
|DisplayName|**Has Crossed Ceiling**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_hascrossedceiling`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`msdyn_prioritizedactioncatalogue_msdyn_hascrossedceiling`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_msdyn_hascrossedfloor"></a> msdyn_hascrossedfloor

|Property|Value|
|---|---|
|Description|**Whether action is below floor criteria.**|
|DisplayName|**Has Crossed Floor**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_hascrossedfloor`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`msdyn_prioritizedactioncatalogue_msdyn_hascrossedfloor`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_msdyn_prioritizedactioncatalogueId"></a> msdyn_prioritizedactioncatalogueId

|Property|Value|
|---|---|
|Description|**Unique identifier for entity instances**|
|DisplayName|**Prioritized Action Catalogue**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`msdyn_prioritizedactioncatalogueid`|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|

### <a name="BKMK_msdyn_rawactioncatalogueId"></a> msdyn_rawactioncatalogueId

|Property|Value|
|---|---|
|Description|**Lookup to the raw action catalogue record associated with this prioritized action.**|
|DisplayName|**Raw Action Catalogue**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_rawactioncatalogueid`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|msdyn_rawactioncatalogue|

### <a name="BKMK_msdyn_scoredetails"></a> msdyn_scoredetails

|Property|Value|
|---|---|
|Description|**Details related to scoring run as generated by LLM containg explaination, citation and action impact.**|
|DisplayName|**Score Details**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_scoredetails`|
|RequiredLevel|None|
|Type|Memo|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|1048576|

### <a name="BKMK_msdyn_sourceagentconfig"></a> msdyn_sourceagentconfig

|Property|Value|
|---|---|
|Description|**Lookup to the source agent configuration record associated with this action.**|
|DisplayName|**Source Agent Configuration**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_sourceagentconfig`|
|RequiredLevel|ApplicationRequired|
|Type|Lookup|
|Targets|msdyn_recommendedactionsourceagentconfig|

### <a name="BKMK_msdyn_targetentity"></a> msdyn_targetentity

|Property|Value|
|---|---|
|Description|**Record for which the action is generated.**|
|DisplayName|**Target Entity**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_targetentity`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|account, contact, lead, opportunity|

### <a name="BKMK_msdyn_targetentityIdType"></a> msdyn_targetentityIdType

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
|Description|**Status of the Prioritized Action Catalogue**|
|DisplayName|**Status**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statecode`|
|RequiredLevel|SystemRequired|
|Type|State|
|DefaultFormValue||
|GlobalChoiceName|`msdyn_prioritizedactioncatalogue_statecode`|

#### statecode Choices/Options

|Value|Details|
|---|---|
|0|Label: **Active**<br />DefaultStatus: 1<br />InvariantName: `Active`|
|1|Label: **Inactive**<br />DefaultStatus: 2<br />InvariantName: `Inactive`|

### <a name="BKMK_statuscode"></a> statuscode

|Property|Value|
|---|---|
|Description|**Reason for the status of the Prioritized Action Catalogue**|
|DisplayName|**Status Reason**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statuscode`|
|RequiredLevel|None|
|Type|Status|
|DefaultFormValue||
|GlobalChoiceName|`msdyn_prioritizedactioncatalogue_statuscode`|

#### statuscode Choices/Options

|Value|Details|
|---|---|
|1|Label: **Active**<br />State:0<br />TransitionData: None|
|2|Label: **Inactive**<br />State:1<br />TransitionData: None|
|3|Label: **Removed**<br />State:1<br />TransitionData: None|

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

- [business_unit_msdyn_prioritizedactioncatalogue](#BKMK_business_unit_msdyn_prioritizedactioncatalogue)
- [lk_msdyn_prioritizedactioncatalogue_createdby](#BKMK_lk_msdyn_prioritizedactioncatalogue_createdby)
- [lk_msdyn_prioritizedactioncatalogue_createdonbehalfby](#BKMK_lk_msdyn_prioritizedactioncatalogue_createdonbehalfby)
- [lk_msdyn_prioritizedactioncatalogue_modifiedby](#BKMK_lk_msdyn_prioritizedactioncatalogue_modifiedby)
- [lk_msdyn_prioritizedactioncatalogue_modifiedonbehalfby](#BKMK_lk_msdyn_prioritizedactioncatalogue_modifiedonbehalfby)
- [msdyn_prioritizedactioncatalogue_account](#BKMK_msdyn_prioritizedactioncatalogue_account)
- [msdyn_prioritizedactioncatalogue_contact](#BKMK_msdyn_prioritizedactioncatalogue_contact)
- [msdyn_prioritizedactioncatalogue_lead](#BKMK_msdyn_prioritizedactioncatalogue_lead)
- [msdyn_prioritizedactioncatalogue_msdyn_rawactioncatalogue](#BKMK_msdyn_prioritizedactioncatalogue_msdyn_rawactioncatalogue)
- [msdyn_prioritizedactioncatalogue_msdyn_recommendedactionsourceagentconfig](#BKMK_msdyn_prioritizedactioncatalogue_msdyn_recommendedactionsourceagentconfig)
- [msdyn_prioritizedactioncatalogue_opportunity](#BKMK_msdyn_prioritizedactioncatalogue_opportunity)
- [owner_msdyn_prioritizedactioncatalogue](#BKMK_owner_msdyn_prioritizedactioncatalogue)
- [team_msdyn_prioritizedactioncatalogue](#BKMK_team_msdyn_prioritizedactioncatalogue)
- [user_msdyn_prioritizedactioncatalogue](#BKMK_user_msdyn_prioritizedactioncatalogue)

### <a name="BKMK_business_unit_msdyn_prioritizedactioncatalogue"></a> business_unit_msdyn_prioritizedactioncatalogue

One-To-Many Relationship: [businessunit business_unit_msdyn_prioritizedactioncatalogue](businessunit.md#BKMK_business_unit_msdyn_prioritizedactioncatalogue)

|Property|Value|
|---|---|
|ReferencedEntity|`businessunit`|
|ReferencedAttribute|`businessunitid`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencingEntityNavigationPropertyName|`owningbusinessunit`|
|IsHierarchical||
|CascadeConfiguration|Archive: `Restrict`<br />Assign: `NoCascade`<br />Delete: `Restrict`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_prioritizedactioncatalogue_createdby"></a> lk_msdyn_prioritizedactioncatalogue_createdby

One-To-Many Relationship: [systemuser lk_msdyn_prioritizedactioncatalogue_createdby](systemuser.md#BKMK_lk_msdyn_prioritizedactioncatalogue_createdby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdby`|
|ReferencingEntityNavigationPropertyName|`createdby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_prioritizedactioncatalogue_createdonbehalfby"></a> lk_msdyn_prioritizedactioncatalogue_createdonbehalfby

One-To-Many Relationship: [systemuser lk_msdyn_prioritizedactioncatalogue_createdonbehalfby](systemuser.md#BKMK_lk_msdyn_prioritizedactioncatalogue_createdonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdonbehalfby`|
|ReferencingEntityNavigationPropertyName|`createdonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_prioritizedactioncatalogue_modifiedby"></a> lk_msdyn_prioritizedactioncatalogue_modifiedby

One-To-Many Relationship: [systemuser lk_msdyn_prioritizedactioncatalogue_modifiedby](systemuser.md#BKMK_lk_msdyn_prioritizedactioncatalogue_modifiedby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedby`|
|ReferencingEntityNavigationPropertyName|`modifiedby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_prioritizedactioncatalogue_modifiedonbehalfby"></a> lk_msdyn_prioritizedactioncatalogue_modifiedonbehalfby

One-To-Many Relationship: [systemuser lk_msdyn_prioritizedactioncatalogue_modifiedonbehalfby](systemuser.md#BKMK_lk_msdyn_prioritizedactioncatalogue_modifiedonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedonbehalfby`|
|ReferencingEntityNavigationPropertyName|`modifiedonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_prioritizedactioncatalogue_account"></a> msdyn_prioritizedactioncatalogue_account

One-To-Many Relationship: [account msdyn_prioritizedactioncatalogue_account](account.md#BKMK_msdyn_prioritizedactioncatalogue_account)

|Property|Value|
|---|---|
|ReferencedEntity|`account`|
|ReferencedAttribute|`accountid`|
|ReferencingAttribute|`msdyn_targetentity`|
|ReferencingEntityNavigationPropertyName|`msdyn_targetentity_account`|
|IsHierarchical||
|CascadeConfiguration|Archive: `RemoveLink`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `Cascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_prioritizedactioncatalogue_contact"></a> msdyn_prioritizedactioncatalogue_contact

One-To-Many Relationship: [contact msdyn_prioritizedactioncatalogue_contact](contact.md#BKMK_msdyn_prioritizedactioncatalogue_contact)

|Property|Value|
|---|---|
|ReferencedEntity|`contact`|
|ReferencedAttribute|`contactid`|
|ReferencingAttribute|`msdyn_targetentity`|
|ReferencingEntityNavigationPropertyName|`msdyn_targetentity_contact`|
|IsHierarchical||
|CascadeConfiguration|Archive: `RemoveLink`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `Cascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_prioritizedactioncatalogue_lead"></a> msdyn_prioritizedactioncatalogue_lead

One-To-Many Relationship: [lead msdyn_prioritizedactioncatalogue_lead](lead.md#BKMK_msdyn_prioritizedactioncatalogue_lead)

|Property|Value|
|---|---|
|ReferencedEntity|`lead`|
|ReferencedAttribute|`leadid`|
|ReferencingAttribute|`msdyn_targetentity`|
|ReferencingEntityNavigationPropertyName|`msdyn_targetentity_lead`|
|IsHierarchical||
|CascadeConfiguration|Archive: `RemoveLink`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `Cascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_prioritizedactioncatalogue_msdyn_rawactioncatalogue"></a> msdyn_prioritizedactioncatalogue_msdyn_rawactioncatalogue

One-To-Many Relationship: [msdyn_rawactioncatalogue msdyn_prioritizedactioncatalogue_msdyn_rawactioncatalogue](msdyn_rawactioncatalogue.md#BKMK_msdyn_prioritizedactioncatalogue_msdyn_rawactioncatalogue)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_rawactioncatalogue`|
|ReferencedAttribute|`msdyn_rawactioncatalogueid`|
|ReferencingAttribute|`msdyn_rawactioncatalogueid`|
|ReferencingEntityNavigationPropertyName|`msdyn_rawactioncatalogueid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `Cascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_prioritizedactioncatalogue_msdyn_recommendedactionsourceagentconfig"></a> msdyn_prioritizedactioncatalogue_msdyn_recommendedactionsourceagentconfig

One-To-Many Relationship: [msdyn_recommendedactionsourceagentconfig msdyn_prioritizedactioncatalogue_msdyn_recommendedactionsourceagentconfig](msdyn_recommendedactionsourceagentconfig.md#BKMK_msdyn_prioritizedactioncatalogue_msdyn_recommendedactionsourceagentconfig)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_recommendedactionsourceagentconfig`|
|ReferencedAttribute|`msdyn_recommendedactionsourceagentconfigid`|
|ReferencingAttribute|`msdyn_sourceagentconfig`|
|ReferencingEntityNavigationPropertyName|`msdyn_sourceagentconfig`|
|IsHierarchical||
|CascadeConfiguration|Archive: `Cascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_prioritizedactioncatalogue_opportunity"></a> msdyn_prioritizedactioncatalogue_opportunity

One-To-Many Relationship: [opportunity msdyn_prioritizedactioncatalogue_opportunity](opportunity.md#BKMK_msdyn_prioritizedactioncatalogue_opportunity)

|Property|Value|
|---|---|
|ReferencedEntity|`opportunity`|
|ReferencedAttribute|`opportunityid`|
|ReferencingAttribute|`msdyn_targetentity`|
|ReferencingEntityNavigationPropertyName|`msdyn_targetentity_opportunity`|
|IsHierarchical||
|CascadeConfiguration|Archive: `RemoveLink`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_owner_msdyn_prioritizedactioncatalogue"></a> owner_msdyn_prioritizedactioncatalogue

One-To-Many Relationship: [owner owner_msdyn_prioritizedactioncatalogue](owner.md#BKMK_owner_msdyn_prioritizedactioncatalogue)

|Property|Value|
|---|---|
|ReferencedEntity|`owner`|
|ReferencedAttribute|`ownerid`|
|ReferencingAttribute|`ownerid`|
|ReferencingEntityNavigationPropertyName|`ownerid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_team_msdyn_prioritizedactioncatalogue"></a> team_msdyn_prioritizedactioncatalogue

One-To-Many Relationship: [team team_msdyn_prioritizedactioncatalogue](team.md#BKMK_team_msdyn_prioritizedactioncatalogue)

|Property|Value|
|---|---|
|ReferencedEntity|`team`|
|ReferencedAttribute|`teamid`|
|ReferencingAttribute|`owningteam`|
|ReferencingEntityNavigationPropertyName|`owningteam`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_user_msdyn_prioritizedactioncatalogue"></a> user_msdyn_prioritizedactioncatalogue

One-To-Many Relationship: [systemuser user_msdyn_prioritizedactioncatalogue](systemuser.md#BKMK_user_msdyn_prioritizedactioncatalogue)

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

- [msdyn_prioritizedactioncatalogue_AsyncOperations](#BKMK_msdyn_prioritizedactioncatalogue_AsyncOperations)
- [msdyn_prioritizedactioncatalogue_BulkDeleteFailures](#BKMK_msdyn_prioritizedactioncatalogue_BulkDeleteFailures)
- [msdyn_prioritizedactioncatalogue_DuplicateBaseRecord](#BKMK_msdyn_prioritizedactioncatalogue_DuplicateBaseRecord)
- [msdyn_prioritizedactioncatalogue_DuplicateMatchingRecord](#BKMK_msdyn_prioritizedactioncatalogue_DuplicateMatchingRecord)
- [msdyn_prioritizedactioncatalogue_MailboxTrackingFolders](#BKMK_msdyn_prioritizedactioncatalogue_MailboxTrackingFolders)
- [msdyn_prioritizedactioncatalogue_PrincipalObjectAttributeAccesses](#BKMK_msdyn_prioritizedactioncatalogue_PrincipalObjectAttributeAccesses)
- [msdyn_prioritizedactioncatalogue_ProcessSession](#BKMK_msdyn_prioritizedactioncatalogue_ProcessSession)
- [msdyn_prioritizedactioncatalogue_SyncErrors](#BKMK_msdyn_prioritizedactioncatalogue_SyncErrors)

### <a name="BKMK_msdyn_prioritizedactioncatalogue_AsyncOperations"></a> msdyn_prioritizedactioncatalogue_AsyncOperations

Many-To-One Relationship: [asyncoperation msdyn_prioritizedactioncatalogue_AsyncOperations](asyncoperation.md#BKMK_msdyn_prioritizedactioncatalogue_AsyncOperations)

|Property|Value|
|---|---|
|ReferencingEntity|`asyncoperation`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_prioritizedactioncatalogue_AsyncOperations`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_prioritizedactioncatalogue_BulkDeleteFailures"></a> msdyn_prioritizedactioncatalogue_BulkDeleteFailures

Many-To-One Relationship: [bulkdeletefailure msdyn_prioritizedactioncatalogue_BulkDeleteFailures](bulkdeletefailure.md#BKMK_msdyn_prioritizedactioncatalogue_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencingEntity|`bulkdeletefailure`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_prioritizedactioncatalogue_BulkDeleteFailures`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_prioritizedactioncatalogue_DuplicateBaseRecord"></a> msdyn_prioritizedactioncatalogue_DuplicateBaseRecord

Many-To-One Relationship: [duplicaterecord msdyn_prioritizedactioncatalogue_DuplicateBaseRecord](duplicaterecord.md#BKMK_msdyn_prioritizedactioncatalogue_DuplicateBaseRecord)

|Property|Value|
|---|---|
|ReferencingEntity|`duplicaterecord`|
|ReferencingAttribute|`baserecordid`|
|ReferencedEntityNavigationPropertyName|`msdyn_prioritizedactioncatalogue_DuplicateBaseRecord`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_prioritizedactioncatalogue_DuplicateMatchingRecord"></a> msdyn_prioritizedactioncatalogue_DuplicateMatchingRecord

Many-To-One Relationship: [duplicaterecord msdyn_prioritizedactioncatalogue_DuplicateMatchingRecord](duplicaterecord.md#BKMK_msdyn_prioritizedactioncatalogue_DuplicateMatchingRecord)

|Property|Value|
|---|---|
|ReferencingEntity|`duplicaterecord`|
|ReferencingAttribute|`duplicaterecordid`|
|ReferencedEntityNavigationPropertyName|`msdyn_prioritizedactioncatalogue_DuplicateMatchingRecord`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_prioritizedactioncatalogue_MailboxTrackingFolders"></a> msdyn_prioritizedactioncatalogue_MailboxTrackingFolders

Many-To-One Relationship: [mailboxtrackingfolder msdyn_prioritizedactioncatalogue_MailboxTrackingFolders](mailboxtrackingfolder.md#BKMK_msdyn_prioritizedactioncatalogue_MailboxTrackingFolders)

|Property|Value|
|---|---|
|ReferencingEntity|`mailboxtrackingfolder`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_prioritizedactioncatalogue_MailboxTrackingFolders`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_prioritizedactioncatalogue_PrincipalObjectAttributeAccesses"></a> msdyn_prioritizedactioncatalogue_PrincipalObjectAttributeAccesses

Many-To-One Relationship: [principalobjectattributeaccess msdyn_prioritizedactioncatalogue_PrincipalObjectAttributeAccesses](principalobjectattributeaccess.md#BKMK_msdyn_prioritizedactioncatalogue_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencingEntity|`principalobjectattributeaccess`|
|ReferencingAttribute|`objectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_prioritizedactioncatalogue_PrincipalObjectAttributeAccesses`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_prioritizedactioncatalogue_ProcessSession"></a> msdyn_prioritizedactioncatalogue_ProcessSession

Many-To-One Relationship: [processsession msdyn_prioritizedactioncatalogue_ProcessSession](processsession.md#BKMK_msdyn_prioritizedactioncatalogue_ProcessSession)

|Property|Value|
|---|---|
|ReferencingEntity|`processsession`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_prioritizedactioncatalogue_ProcessSession`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_prioritizedactioncatalogue_SyncErrors"></a> msdyn_prioritizedactioncatalogue_SyncErrors

Many-To-One Relationship: [syncerror msdyn_prioritizedactioncatalogue_SyncErrors](syncerror.md#BKMK_msdyn_prioritizedactioncatalogue_SyncErrors)

|Property|Value|
|---|---|
|ReferencingEntity|`syncerror`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_prioritizedactioncatalogue_SyncErrors`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|



### See also

[Dataverse table/entity reference](/power-apps/developer/data-platform/reference/about-entity-reference)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   

