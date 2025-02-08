---
title: "Copilot Interaction (msdyn_copilotinteraction) table/entity reference (Microsoft Dynamics 365)"
description: "Includes schema information and supported messages for the Copilot Interaction (msdyn_copilotinteraction) table/entity with Microsoft Dynamics 365."
ms.topic: generated-reference
author: JimDaly
ms.author: jdaly
search.audienceType: 
  - developer
---

# Copilot Interaction (msdyn_copilotinteraction) table/entity reference (Microsoft Dynamics 365)



## Messages

The following table lists the messages for the Copilot Interaction (msdyn_copilotinteraction) table.
Messages represent operations that can be performed on the table. They may also be events.

| Name <br />Is Event? |Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `Associate`<br />Event: True |[Associate records](/power-apps/developer/data-platform/webapi/associate-disassociate-entities-using-web-api) |[Associate records](/power-apps/developer/data-platform/org-service/entity-operations-associate-disassociate#use-the-associate-method-or-associaterequest)|
| `BulkRetain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.BulkRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Create`<br />Event: True |`POST` /msdyn_copilotinteractions<br />See [Create](/powerapps/developer/data-platform/webapi/create-entity-web-api) |[Create records](/power-apps/developer/data-platform/org-service/entity-operations-create#basic-create)|
| `CreateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.CreateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.CreateMultipleRequest>|
| `Delete`<br />Event: True |`DELETE` /msdyn_copilotinteractions(*msdyn_copilotinteractionid*)<br />See [Delete](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-delete) |[Delete records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-delete)|
| `Disassociate`<br />Event: True |[Disassociate records](/power-apps/developer/data-platform/webapi/associate-disassociate-entities-using-web-api) |[Disassociate records](/power-apps/developer/data-platform/org-service/entity-operations-associate-disassociate#use-the-disassociate-method-or-disassociaterequest)|
| `IsValidStateTransition`<br />Event: False |<xref:Microsoft.Dynamics.CRM.IsValidStateTransition?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.IsValidStateTransitionRequest>|
| `PurgeRetainedContent`<br />Event: True |<xref:Microsoft.Dynamics.CRM.PurgeRetainedContent?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Restore`<br />Event: True |<xref:Microsoft.Dynamics.CRM.Restore?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.Retain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retrieve`<br />Event: True |`GET` /msdyn_copilotinteractions(*msdyn_copilotinteractionid*)<br />See [Retrieve](/powerapps/developer/data-platform/webapi/retrieve-entity-using-web-api) |[Retrieve records](/power-apps/developer/data-platform/org-service/entity-operations-retrieve)|
| `RetrieveMultiple`<br />Event: True |`GET` /msdyn_copilotinteractions<br />See [Query data](/power-apps/developer/data-platform/webapi/query-data-web-api) |[Query data](/power-apps/developer/data-platform/org-service/entity-operations-query-data)|
| `RollbackRetain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RollbackRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `SetState`<br />Event: True |`PATCH` /msdyn_copilotinteractions(*msdyn_copilotinteractionid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `statecode` and `statuscode` properties. |<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|
| `Update`<br />Event: True |`PATCH` /msdyn_copilotinteractions(*msdyn_copilotinteractionid*)<br />See [Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) |[Update records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-update)|
| `UpdateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.UpdateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpdateMultipleRequest>|
| `Upsert`<br />Event: False |`PATCH` /msdyn_copilotinteractions(*msdyn_copilotinteractionid*)<br />See [Upsert a table row](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#upsert-a-table-row) |<xref:Microsoft.Xrm.Sdk.Messages.UpsertRequest>|
| `UpsertMultiple`<br />Event: False |<xref:Microsoft.Dynamics.CRM.UpsertMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpsertMultipleRequest>|
| `ValidateRetentionConfig`<br />Event: True |<xref:Microsoft.Dynamics.CRM.ValidateRetentionConfig?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|

## Properties

The following table lists selected properties for the Copilot Interaction (msdyn_copilotinteraction) table.

|Property|Value|
| --- | --- |
| **DisplayName** | **Copilot Interaction** |
| **DisplayCollectionName** | **Copilot Interactions** |
| **SchemaName** | `msdyn_copilotinteraction` |
| **CollectionSchemaName** | `msdyn_copilotinteractions` |
| **EntitySetName** | `msdyn_copilotinteractions`|
| **LogicalName** | `msdyn_copilotinteraction` |
| **LogicalCollectionName** | `msdyn_copilotinteractions` |
| **PrimaryIdAttribute** | `msdyn_copilotinteractionid` |
| **PrimaryNameAttribute** |`msdyn_name` |
| **TableType** | `Standard` |
| **OwnershipType** | `OrganizationOwned` |

## Writable columns/attributes

These columns/attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [msdyn_clienttimestamp](#BKMK_msdyn_clienttimestamp)
- [msdyn_copilotinteractionId](#BKMK_msdyn_copilotinteractionId)
- [msdyn_interactioncontext](#BKMK_msdyn_interactioncontext)
- [msdyn_interactiondataid](#BKMK_msdyn_interactiondataid)
- [msdyn_interactionforid](#BKMK_msdyn_interactionforid)
- [msdyn_interactionforlogicalname](#BKMK_msdyn_interactionforlogicalname)
- [msdyn_interactiontype](#BKMK_msdyn_interactiontype)
- [msdyn_name](#BKMK_msdyn_name)
- [msdyn_scenariorequestid](#BKMK_msdyn_scenariorequestid)
- [msdyn_scenariotype](#BKMK_msdyn_scenariotype)
- [OverriddenCreatedOn](#BKMK_OverriddenCreatedOn)
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

### <a name="BKMK_msdyn_clienttimestamp"></a> msdyn_clienttimestamp

|Property|Value|
|---|---|
|Description|**Utc Timestamp from client**|
|DisplayName|**Client Timestamp**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_clienttimestamp`|
|RequiredLevel|None|
|Type|DateTime|
|CanChangeDateTimeBehavior|False|
|DateTimeBehavior|UserLocal|
|Format|DateAndTime|
|ImeMode|Auto|
|SourceTypeMask|0|

### <a name="BKMK_msdyn_copilotinteractionId"></a> msdyn_copilotinteractionId

|Property|Value|
|---|---|
|Description|**Unique identifier for entity instances**|
|DisplayName|**Copilot Interaction**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`msdyn_copilotinteractionid`|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|

### <a name="BKMK_msdyn_interactioncontext"></a> msdyn_interactioncontext

|Property|Value|
|---|---|
|Description|**Stores additional context about the interaction**|
|DisplayName|**Interaction Context**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_interactioncontext`|
|RequiredLevel|None|
|Type|Memo|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|1048576|

### <a name="BKMK_msdyn_interactiondataid"></a> msdyn_interactiondataid

|Property|Value|
|---|---|
|Description|**Links to the interaction data record**|
|DisplayName|**Interaction Data Id**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_interactiondataid`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|msdyn_copilotinteractiondata|

### <a name="BKMK_msdyn_interactionforid"></a> msdyn_interactionforid

|Property|Value|
|---|---|
|Description|**Id of the record to which this interaction is associated**|
|DisplayName|**Interaction For Id**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_interactionforid`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdyn_interactionforlogicalname"></a> msdyn_interactionforlogicalname

|Property|Value|
|---|---|
|Description|**LogicalName of the record to which this interaction is associated**|
|DisplayName|**Interaction For Logical Name**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_interactionforlogicalname`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdyn_interactiontype"></a> msdyn_interactiontype

|Property|Value|
|---|---|
|Description|**Identifies the type of interaction**|
|DisplayName|**Interaction Type**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_interactiontype`|
|RequiredLevel|ApplicationRequired|
|Type|Picklist|
|DefaultFormValue|-1|
|GlobalChoiceName|`msdyn_copilotinteractions_msdyn_interactiontype`|

#### msdyn_interactiontype Choices/Options

|Value|Label|
|---|---|
|100230301|**ThumbsUp**|
|100230302|**ThumbsDown**|
|100230303|**ThumbsClear**|
|100230304|**Copy**|
|100230305|**Generated**|
|100230306|**SendToCustomer**|
|100230307|**EditAndSend**|
|100230308|**ManualCopy**|
|100230309|**Available**|
|100230310|**ArticleProposed**|
|100230311|**MarkAsReviewed**|
|100230312|**AcceptSuggestion**|
|100230313|**ViewHistory**|
|100230314|**ExpandTile**|
|100230315|**RequestSolution**|

### <a name="BKMK_msdyn_name"></a> msdyn_name

|Property|Value|
|---|---|
|Description|**The name of the custom entity.**|
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

### <a name="BKMK_msdyn_scenariorequestid"></a> msdyn_scenariorequestid

|Property|Value|
|---|---|
|Description|**Unique identifier that ties the request across layers**|
|DisplayName|**Scenario Request Id**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_scenariorequestid`|
|RequiredLevel|ApplicationRequired|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdyn_scenariotype"></a> msdyn_scenariotype

|Property|Value|
|---|---|
|Description|**Identifies the type of scenario**|
|DisplayName|**Scenario Type**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_scenariotype`|
|RequiredLevel|ApplicationRequired|
|Type|Picklist|
|DefaultFormValue|-1|
|GlobalChoiceName|`msdyn_copilotinteraction_msdyn_scenariotype`|

#### msdyn_scenariotype Choices/Options

|Value|Label|
|---|---|
|100230201|**Ask a question**|
|100230202|**Live conversation response**|
|100230203|**Write an email**|
|100230204|**Copilot**|
|100230205|**Case summary**|
|100230206|**Live conversation summary**|
|100230207|**Timeline highlights**|
|100230208|**Knowledge draft assist**|
|100230209|**Custom entity summary**|
|100230210|**Collaborate with SMEs**|
|100230211|**Inline Copilot for email**|
|100230212|**Timeline next best actions**|
|100230213|**Intent Assist**|
|100230214|**knowledge harvest**|
|100230215|**Resolution notes**|
|100230216|**Chat Assist**|

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

### <a name="BKMK_statecode"></a> statecode

|Property|Value|
|---|---|
|Description|**Status of the Copilot Interaction**|
|DisplayName|**Status**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statecode`|
|RequiredLevel|SystemRequired|
|Type|State|
|DefaultFormValue||
|GlobalChoiceName|`msdyn_copilotinteraction_statecode`|

#### statecode Choices/Options

|Value|Details|
|---|---|
|0|Label: **Active**<br />DefaultStatus: 1<br />InvariantName: `Active`|
|1|Label: **Inactive**<br />DefaultStatus: 2<br />InvariantName: `Inactive`|

### <a name="BKMK_statuscode"></a> statuscode

|Property|Value|
|---|---|
|Description|**Reason for the status of the Copilot Interaction**|
|DisplayName|**Status Reason**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statuscode`|
|RequiredLevel|None|
|Type|Status|
|DefaultFormValue||
|GlobalChoiceName|`msdyn_copilotinteraction_statuscode`|

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
- [OrganizationId](#BKMK_OrganizationId)
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

### <a name="BKMK_OrganizationId"></a> OrganizationId

|Property|Value|
|---|---|
|Description|**Unique identifier for the organization**|
|DisplayName|**Organization Id**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`organizationid`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|organization|

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

- [lk_msdyn_copilotinteraction_createdby](#BKMK_lk_msdyn_copilotinteraction_createdby)
- [lk_msdyn_copilotinteraction_createdonbehalfby](#BKMK_lk_msdyn_copilotinteraction_createdonbehalfby)
- [lk_msdyn_copilotinteraction_modifiedby](#BKMK_lk_msdyn_copilotinteraction_modifiedby)
- [lk_msdyn_copilotinteraction_modifiedonbehalfby](#BKMK_lk_msdyn_copilotinteraction_modifiedonbehalfby)
- [msdyn_msdyn_copilotinteractiondata_msdyn_copilotinteraction_interactiondataid](#BKMK_msdyn_msdyn_copilotinteractiondata_msdyn_copilotinteraction_interactiondataid)
- [organization_msdyn_copilotinteraction](#BKMK_organization_msdyn_copilotinteraction)

### <a name="BKMK_lk_msdyn_copilotinteraction_createdby"></a> lk_msdyn_copilotinteraction_createdby

One-To-Many Relationship: [systemuser lk_msdyn_copilotinteraction_createdby](systemuser.md#BKMK_lk_msdyn_copilotinteraction_createdby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdby`|
|ReferencingEntityNavigationPropertyName|`createdby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_copilotinteraction_createdonbehalfby"></a> lk_msdyn_copilotinteraction_createdonbehalfby

One-To-Many Relationship: [systemuser lk_msdyn_copilotinteraction_createdonbehalfby](systemuser.md#BKMK_lk_msdyn_copilotinteraction_createdonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdonbehalfby`|
|ReferencingEntityNavigationPropertyName|`createdonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_copilotinteraction_modifiedby"></a> lk_msdyn_copilotinteraction_modifiedby

One-To-Many Relationship: [systemuser lk_msdyn_copilotinteraction_modifiedby](systemuser.md#BKMK_lk_msdyn_copilotinteraction_modifiedby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedby`|
|ReferencingEntityNavigationPropertyName|`modifiedby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_copilotinteraction_modifiedonbehalfby"></a> lk_msdyn_copilotinteraction_modifiedonbehalfby

One-To-Many Relationship: [systemuser lk_msdyn_copilotinteraction_modifiedonbehalfby](systemuser.md#BKMK_lk_msdyn_copilotinteraction_modifiedonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedonbehalfby`|
|ReferencingEntityNavigationPropertyName|`modifiedonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_msdyn_copilotinteractiondata_msdyn_copilotinteraction_interactiondataid"></a> msdyn_msdyn_copilotinteractiondata_msdyn_copilotinteraction_interactiondataid

One-To-Many Relationship: [msdyn_copilotinteractiondata msdyn_msdyn_copilotinteractiondata_msdyn_copilotinteraction_interactiondataid](msdyn_copilotinteractiondata.md#BKMK_msdyn_msdyn_copilotinteractiondata_msdyn_copilotinteraction_interactiondataid)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_copilotinteractiondata`|
|ReferencedAttribute|`msdyn_copilotinteractiondataid`|
|ReferencingAttribute|`msdyn_interactiondataid`|
|ReferencingEntityNavigationPropertyName|`msdyn_interactiondataid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `RemoveLink`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_organization_msdyn_copilotinteraction"></a> organization_msdyn_copilotinteraction

One-To-Many Relationship: [organization organization_msdyn_copilotinteraction](organization.md#BKMK_organization_msdyn_copilotinteraction)

|Property|Value|
|---|---|
|ReferencedEntity|`organization`|
|ReferencedAttribute|`organizationid`|
|ReferencingAttribute|`organizationid`|
|ReferencingEntityNavigationPropertyName|`organizationid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|


## One-to-Many relationships

These relationships are one-to-many. Listed by **SchemaName**.

- [msdyn_copilotinteraction_AsyncOperations](#BKMK_msdyn_copilotinteraction_AsyncOperations)
- [msdyn_copilotinteraction_BulkDeleteFailures](#BKMK_msdyn_copilotinteraction_BulkDeleteFailures)
- [msdyn_copilotinteraction_DuplicateBaseRecord](#BKMK_msdyn_copilotinteraction_DuplicateBaseRecord)
- [msdyn_copilotinteraction_DuplicateMatchingRecord](#BKMK_msdyn_copilotinteraction_DuplicateMatchingRecord)
- [msdyn_copilotinteraction_MailboxTrackingFolders](#BKMK_msdyn_copilotinteraction_MailboxTrackingFolders)
- [msdyn_copilotinteraction_PrincipalObjectAttributeAccesses](#BKMK_msdyn_copilotinteraction_PrincipalObjectAttributeAccesses)
- [msdyn_copilotinteraction_ProcessSession](#BKMK_msdyn_copilotinteraction_ProcessSession)
- [msdyn_copilotinteraction_SyncErrors](#BKMK_msdyn_copilotinteraction_SyncErrors)

### <a name="BKMK_msdyn_copilotinteraction_AsyncOperations"></a> msdyn_copilotinteraction_AsyncOperations

Many-To-One Relationship: [asyncoperation msdyn_copilotinteraction_AsyncOperations](asyncoperation.md#BKMK_msdyn_copilotinteraction_AsyncOperations)

|Property|Value|
|---|---|
|ReferencingEntity|`asyncoperation`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_copilotinteraction_AsyncOperations`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_copilotinteraction_BulkDeleteFailures"></a> msdyn_copilotinteraction_BulkDeleteFailures

Many-To-One Relationship: [bulkdeletefailure msdyn_copilotinteraction_BulkDeleteFailures](bulkdeletefailure.md#BKMK_msdyn_copilotinteraction_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencingEntity|`bulkdeletefailure`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_copilotinteraction_BulkDeleteFailures`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_copilotinteraction_DuplicateBaseRecord"></a> msdyn_copilotinteraction_DuplicateBaseRecord

Many-To-One Relationship: [duplicaterecord msdyn_copilotinteraction_DuplicateBaseRecord](duplicaterecord.md#BKMK_msdyn_copilotinteraction_DuplicateBaseRecord)

|Property|Value|
|---|---|
|ReferencingEntity|`duplicaterecord`|
|ReferencingAttribute|`baserecordid`|
|ReferencedEntityNavigationPropertyName|`msdyn_copilotinteraction_DuplicateBaseRecord`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_copilotinteraction_DuplicateMatchingRecord"></a> msdyn_copilotinteraction_DuplicateMatchingRecord

Many-To-One Relationship: [duplicaterecord msdyn_copilotinteraction_DuplicateMatchingRecord](duplicaterecord.md#BKMK_msdyn_copilotinteraction_DuplicateMatchingRecord)

|Property|Value|
|---|---|
|ReferencingEntity|`duplicaterecord`|
|ReferencingAttribute|`duplicaterecordid`|
|ReferencedEntityNavigationPropertyName|`msdyn_copilotinteraction_DuplicateMatchingRecord`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_copilotinteraction_MailboxTrackingFolders"></a> msdyn_copilotinteraction_MailboxTrackingFolders

Many-To-One Relationship: [mailboxtrackingfolder msdyn_copilotinteraction_MailboxTrackingFolders](mailboxtrackingfolder.md#BKMK_msdyn_copilotinteraction_MailboxTrackingFolders)

|Property|Value|
|---|---|
|ReferencingEntity|`mailboxtrackingfolder`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_copilotinteraction_MailboxTrackingFolders`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_copilotinteraction_PrincipalObjectAttributeAccesses"></a> msdyn_copilotinteraction_PrincipalObjectAttributeAccesses

Many-To-One Relationship: [principalobjectattributeaccess msdyn_copilotinteraction_PrincipalObjectAttributeAccesses](principalobjectattributeaccess.md#BKMK_msdyn_copilotinteraction_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencingEntity|`principalobjectattributeaccess`|
|ReferencingAttribute|`objectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_copilotinteraction_PrincipalObjectAttributeAccesses`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_copilotinteraction_ProcessSession"></a> msdyn_copilotinteraction_ProcessSession

Many-To-One Relationship: [processsession msdyn_copilotinteraction_ProcessSession](processsession.md#BKMK_msdyn_copilotinteraction_ProcessSession)

|Property|Value|
|---|---|
|ReferencingEntity|`processsession`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_copilotinteraction_ProcessSession`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_copilotinteraction_SyncErrors"></a> msdyn_copilotinteraction_SyncErrors

Many-To-One Relationship: [syncerror msdyn_copilotinteraction_SyncErrors](syncerror.md#BKMK_msdyn_copilotinteraction_SyncErrors)

|Property|Value|
|---|---|
|ReferencingEntity|`syncerror`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_copilotinteraction_SyncErrors`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|



### See also

[Dataverse table/entity reference](/power-apps/developer/data-platform/reference/about-entity-reference)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   

