---
title: "Suggestion request payload (msdyn_suggestionrequestpayload) table/entity reference (Microsoft Dynamics 365)"
description: "Includes schema information and supported messages for the Suggestion request payload (msdyn_suggestionrequestpayload) table/entity with Microsoft Dynamics 365."
ms.topic: generated-reference
author: JimDaly
ms.author: jdaly
search.audienceType: 
  - developer
---

# Suggestion request payload (msdyn_suggestionrequestpayload) table/entity reference (Microsoft Dynamics 365)



## Messages

The following table lists the messages for the Suggestion request payload (msdyn_suggestionrequestpayload) table.
Messages represent operations that can be performed on the table. They may also be events.

| Name <br />Is Event? |Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `Associate`<br />Event: True |[Associate records](/power-apps/developer/data-platform/webapi/associate-disassociate-entities-using-web-api) |[Associate records](/power-apps/developer/data-platform/org-service/entity-operations-associate-disassociate#use-the-associate-method-or-associaterequest)|
| `BulkRetain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.BulkRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Create`<br />Event: True |`POST` /msdyn_suggestionrequestpayloads<br />See [Create](/powerapps/developer/data-platform/webapi/create-entity-web-api) |[Create records](/power-apps/developer/data-platform/org-service/entity-operations-create#basic-create)|
| `CreateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.CreateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.CreateMultipleRequest>|
| `Delete`<br />Event: True |`DELETE` /msdyn_suggestionrequestpayloads(*msdyn_suggestionrequestpayloadid*)<br />See [Delete](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-delete) |[Delete records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-delete)|
| `Disassociate`<br />Event: True |[Disassociate records](/power-apps/developer/data-platform/webapi/associate-disassociate-entities-using-web-api) |[Disassociate records](/power-apps/developer/data-platform/org-service/entity-operations-associate-disassociate#use-the-disassociate-method-or-disassociaterequest)|
| `IsValidStateTransition`<br />Event: False |<xref:Microsoft.Dynamics.CRM.IsValidStateTransition?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.IsValidStateTransitionRequest>|
| `PurgeRetainedContent`<br />Event: True |<xref:Microsoft.Dynamics.CRM.PurgeRetainedContent?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Restore`<br />Event: True |<xref:Microsoft.Dynamics.CRM.Restore?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.Retain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retrieve`<br />Event: True |`GET` /msdyn_suggestionrequestpayloads(*msdyn_suggestionrequestpayloadid*)<br />See [Retrieve](/powerapps/developer/data-platform/webapi/retrieve-entity-using-web-api) |[Retrieve records](/power-apps/developer/data-platform/org-service/entity-operations-retrieve)|
| `RetrieveMultiple`<br />Event: True |`GET` /msdyn_suggestionrequestpayloads<br />See [Query data](/power-apps/developer/data-platform/webapi/query-data-web-api) |[Query data](/power-apps/developer/data-platform/org-service/entity-operations-query-data)|
| `RollbackRetain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RollbackRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `SetState`<br />Event: True |`PATCH` /msdyn_suggestionrequestpayloads(*msdyn_suggestionrequestpayloadid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `statecode` and `statuscode` properties. |<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|
| `Update`<br />Event: True |`PATCH` /msdyn_suggestionrequestpayloads(*msdyn_suggestionrequestpayloadid*)<br />See [Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) |[Update records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-update)|
| `UpdateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.UpdateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpdateMultipleRequest>|
| `Upsert`<br />Event: False |`PATCH` /msdyn_suggestionrequestpayloads(*msdyn_suggestionrequestpayloadid*)<br />See [Upsert a table row](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#upsert-a-table-row) |<xref:Microsoft.Xrm.Sdk.Messages.UpsertRequest>|
| `UpsertMultiple`<br />Event: False |<xref:Microsoft.Dynamics.CRM.UpsertMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpsertMultipleRequest>|
| `ValidateRetentionConfig`<br />Event: True |<xref:Microsoft.Dynamics.CRM.ValidateRetentionConfig?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|

## Properties

The following table lists selected properties for the Suggestion request payload (msdyn_suggestionrequestpayload) table.

|Property|Value|
| --- | --- |
| **DisplayName** | **Suggestion request payload** |
| **DisplayCollectionName** | **Suggestion request payloads** |
| **SchemaName** | `msdyn_suggestionrequestpayload` |
| **CollectionSchemaName** | `msdyn_suggestionrequestpayloads` |
| **EntitySetName** | `msdyn_suggestionrequestpayloads`|
| **LogicalName** | `msdyn_suggestionrequestpayload` |
| **LogicalCollectionName** | `msdyn_suggestionrequestpayloads` |
| **PrimaryIdAttribute** | `msdyn_suggestionrequestpayloadid` |
| **PrimaryNameAttribute** |`msdyn_suggestedentitylogicalname` |
| **TableType** | `Standard` |
| **OwnershipType** | `OrganizationOwned` |

## Writable columns/attributes

These columns/attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [msdyn_requestpayload](#BKMK_msdyn_requestpayload)
- [msdyn_responsepayload](#BKMK_msdyn_responsepayload)
- [msdyn_suggestedentitylogicalname](#BKMK_msdyn_suggestedentitylogicalname)
- [msdyn_suggestionfor](#BKMK_msdyn_suggestionfor)
- [msdyn_suggestionforIdType](#BKMK_msdyn_suggestionforIdType)
- [msdyn_suggestionrequestpayloadId](#BKMK_msdyn_suggestionrequestpayloadId)
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

### <a name="BKMK_msdyn_requestpayload"></a> msdyn_requestpayload

|Property|Value|
|---|---|
|Description||
|DisplayName|**Request Payload**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_requestpayload`|
|RequiredLevel|ApplicationRequired|
|Type|Memo|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|1048576|

### <a name="BKMK_msdyn_responsepayload"></a> msdyn_responsepayload

|Property|Value|
|---|---|
|Description||
|DisplayName|**Response Payload**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_responsepayload`|
|RequiredLevel|ApplicationRequired|
|Type|Memo|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|10000|

### <a name="BKMK_msdyn_suggestedentitylogicalname"></a> msdyn_suggestedentitylogicalname

|Property|Value|
|---|---|
|Description||
|DisplayName|**Suggested entity logical name**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_suggestedentitylogicalname`|
|RequiredLevel|ApplicationRequired|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|150|

### <a name="BKMK_msdyn_suggestionfor"></a> msdyn_suggestionfor

|Property|Value|
|---|---|
|Description|**Suggestion for poly lookup attribute**|
|DisplayName|**Suggestion For**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_suggestionfor`|
|RequiredLevel|ApplicationRequired|
|Type|Lookup|
|Targets|incident, msdyn_ocliveworkitem|

### <a name="BKMK_msdyn_suggestionforIdType"></a> msdyn_suggestionforIdType

|Property|Value|
|---|---|
|Description||
|DisplayName||
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`msdyn_suggestionforidtype`|
|RequiredLevel|None|
|Type|EntityName|

### <a name="BKMK_msdyn_suggestionrequestpayloadId"></a> msdyn_suggestionrequestpayloadId

|Property|Value|
|---|---|
|Description|**Unique identifier for entity instances**|
|DisplayName|**Suggestion request payload**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`msdyn_suggestionrequestpayloadid`|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|

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
|Description|**Status of the Suggestion request payload**|
|DisplayName|**Status**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statecode`|
|RequiredLevel|SystemRequired|
|Type|State|
|DefaultFormValue||
|GlobalChoiceName|`msdyn_suggestionrequestpayload_statecode`|

#### statecode Choices/Options

|Value|Details|
|---|---|
|0|Label: **Active**<br />DefaultStatus: 1<br />InvariantName: `Active`|
|1|Label: **Inactive**<br />DefaultStatus: 2<br />InvariantName: `Inactive`|

### <a name="BKMK_statuscode"></a> statuscode

|Property|Value|
|---|---|
|Description|**Reason for the status of the Suggestion request payload**|
|DisplayName|**Status Reason**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statuscode`|
|RequiredLevel|None|
|Type|Status|
|DefaultFormValue||
|GlobalChoiceName|`msdyn_suggestionrequestpayload_statuscode`|

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

- [lk_msdyn_suggestionrequestpayload_createdby](#BKMK_lk_msdyn_suggestionrequestpayload_createdby)
- [lk_msdyn_suggestionrequestpayload_createdonbehalfby](#BKMK_lk_msdyn_suggestionrequestpayload_createdonbehalfby)
- [lk_msdyn_suggestionrequestpayload_modifiedby](#BKMK_lk_msdyn_suggestionrequestpayload_modifiedby)
- [lk_msdyn_suggestionrequestpayload_modifiedonbehalfby](#BKMK_lk_msdyn_suggestionrequestpayload_modifiedonbehalfby)
- [msdyn_incident_msdyn_suggestionrequestpayload](#BKMK_msdyn_incident_msdyn_suggestionrequestpayload)
- [msdyn_msdyn_ocliveworkitem_msdyn_suggestionrequestpayload](#BKMK_msdyn_msdyn_ocliveworkitem_msdyn_suggestionrequestpayload)
- [organization_msdyn_suggestionrequestpayload](#BKMK_organization_msdyn_suggestionrequestpayload)

### <a name="BKMK_lk_msdyn_suggestionrequestpayload_createdby"></a> lk_msdyn_suggestionrequestpayload_createdby

One-To-Many Relationship: [systemuser lk_msdyn_suggestionrequestpayload_createdby](systemuser.md#BKMK_lk_msdyn_suggestionrequestpayload_createdby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdby`|
|ReferencingEntityNavigationPropertyName|`createdby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_suggestionrequestpayload_createdonbehalfby"></a> lk_msdyn_suggestionrequestpayload_createdonbehalfby

One-To-Many Relationship: [systemuser lk_msdyn_suggestionrequestpayload_createdonbehalfby](systemuser.md#BKMK_lk_msdyn_suggestionrequestpayload_createdonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdonbehalfby`|
|ReferencingEntityNavigationPropertyName|`createdonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_suggestionrequestpayload_modifiedby"></a> lk_msdyn_suggestionrequestpayload_modifiedby

One-To-Many Relationship: [systemuser lk_msdyn_suggestionrequestpayload_modifiedby](systemuser.md#BKMK_lk_msdyn_suggestionrequestpayload_modifiedby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedby`|
|ReferencingEntityNavigationPropertyName|`modifiedby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_suggestionrequestpayload_modifiedonbehalfby"></a> lk_msdyn_suggestionrequestpayload_modifiedonbehalfby

One-To-Many Relationship: [systemuser lk_msdyn_suggestionrequestpayload_modifiedonbehalfby](systemuser.md#BKMK_lk_msdyn_suggestionrequestpayload_modifiedonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedonbehalfby`|
|ReferencingEntityNavigationPropertyName|`modifiedonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_incident_msdyn_suggestionrequestpayload"></a> msdyn_incident_msdyn_suggestionrequestpayload

One-To-Many Relationship: [incident msdyn_incident_msdyn_suggestionrequestpayload](incident.md#BKMK_msdyn_incident_msdyn_suggestionrequestpayload)

|Property|Value|
|---|---|
|ReferencedEntity|`incident`|
|ReferencedAttribute|`incidentid`|
|ReferencingAttribute|`msdyn_suggestionfor`|
|ReferencingEntityNavigationPropertyName|`msdyn_suggestionfor_incident`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_msdyn_ocliveworkitem_msdyn_suggestionrequestpayload"></a> msdyn_msdyn_ocliveworkitem_msdyn_suggestionrequestpayload

One-To-Many Relationship: [msdyn_ocliveworkitem msdyn_msdyn_ocliveworkitem_msdyn_suggestionrequestpayload](msdyn_ocliveworkitem.md#BKMK_msdyn_msdyn_ocliveworkitem_msdyn_suggestionrequestpayload)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_ocliveworkitem`|
|ReferencedAttribute|`activityid`|
|ReferencingAttribute|`msdyn_suggestionfor`|
|ReferencingEntityNavigationPropertyName|`msdyn_suggestionfor_msdyn_ocliveworkitem`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_organization_msdyn_suggestionrequestpayload"></a> organization_msdyn_suggestionrequestpayload

One-To-Many Relationship: [organization organization_msdyn_suggestionrequestpayload](organization.md#BKMK_organization_msdyn_suggestionrequestpayload)

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

- [msdyn_msdyn_suggestionrequestpayload_msdyn_suggestioninteraction_SuggestionRequestPayload](#BKMK_msdyn_msdyn_suggestionrequestpayload_msdyn_suggestioninteraction_SuggestionRequestPayload)
- [msdyn_suggestionrequestpayload_AsyncOperations](#BKMK_msdyn_suggestionrequestpayload_AsyncOperations)
- [msdyn_suggestionrequestpayload_BulkDeleteFailures](#BKMK_msdyn_suggestionrequestpayload_BulkDeleteFailures)
- [msdyn_suggestionrequestpayload_MailboxTrackingFolders](#BKMK_msdyn_suggestionrequestpayload_MailboxTrackingFolders)
- [msdyn_suggestionrequestpayload_PrincipalObjectAttributeAccesses](#BKMK_msdyn_suggestionrequestpayload_PrincipalObjectAttributeAccesses)
- [msdyn_suggestionrequestpayload_ProcessSession](#BKMK_msdyn_suggestionrequestpayload_ProcessSession)
- [msdyn_suggestionrequestpayload_SyncErrors](#BKMK_msdyn_suggestionrequestpayload_SyncErrors)

### <a name="BKMK_msdyn_msdyn_suggestionrequestpayload_msdyn_suggestioninteraction_SuggestionRequestPayload"></a> msdyn_msdyn_suggestionrequestpayload_msdyn_suggestioninteraction_SuggestionRequestPayload

Many-To-One Relationship: [msdyn_suggestioninteraction msdyn_msdyn_suggestionrequestpayload_msdyn_suggestioninteraction_SuggestionRequestPayload](msdyn_suggestioninteraction.md#BKMK_msdyn_msdyn_suggestionrequestpayload_msdyn_suggestioninteraction_SuggestionRequestPayload)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_suggestioninteraction`|
|ReferencingAttribute|`msdyn_suggestionrequestpayload`|
|ReferencedEntityNavigationPropertyName|`msdyn_msdyn_suggestionrequestpayload_msdyn_suggestioninteraction_SuggestionRequestPayload`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_suggestionrequestpayload_AsyncOperations"></a> msdyn_suggestionrequestpayload_AsyncOperations

Many-To-One Relationship: [asyncoperation msdyn_suggestionrequestpayload_AsyncOperations](asyncoperation.md#BKMK_msdyn_suggestionrequestpayload_AsyncOperations)

|Property|Value|
|---|---|
|ReferencingEntity|`asyncoperation`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_suggestionrequestpayload_AsyncOperations`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_suggestionrequestpayload_BulkDeleteFailures"></a> msdyn_suggestionrequestpayload_BulkDeleteFailures

Many-To-One Relationship: [bulkdeletefailure msdyn_suggestionrequestpayload_BulkDeleteFailures](bulkdeletefailure.md#BKMK_msdyn_suggestionrequestpayload_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencingEntity|`bulkdeletefailure`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_suggestionrequestpayload_BulkDeleteFailures`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_suggestionrequestpayload_MailboxTrackingFolders"></a> msdyn_suggestionrequestpayload_MailboxTrackingFolders

Many-To-One Relationship: [mailboxtrackingfolder msdyn_suggestionrequestpayload_MailboxTrackingFolders](mailboxtrackingfolder.md#BKMK_msdyn_suggestionrequestpayload_MailboxTrackingFolders)

|Property|Value|
|---|---|
|ReferencingEntity|`mailboxtrackingfolder`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_suggestionrequestpayload_MailboxTrackingFolders`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_suggestionrequestpayload_PrincipalObjectAttributeAccesses"></a> msdyn_suggestionrequestpayload_PrincipalObjectAttributeAccesses

Many-To-One Relationship: [principalobjectattributeaccess msdyn_suggestionrequestpayload_PrincipalObjectAttributeAccesses](principalobjectattributeaccess.md#BKMK_msdyn_suggestionrequestpayload_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencingEntity|`principalobjectattributeaccess`|
|ReferencingAttribute|`objectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_suggestionrequestpayload_PrincipalObjectAttributeAccesses`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_suggestionrequestpayload_ProcessSession"></a> msdyn_suggestionrequestpayload_ProcessSession

Many-To-One Relationship: [processsession msdyn_suggestionrequestpayload_ProcessSession](processsession.md#BKMK_msdyn_suggestionrequestpayload_ProcessSession)

|Property|Value|
|---|---|
|ReferencingEntity|`processsession`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_suggestionrequestpayload_ProcessSession`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_suggestionrequestpayload_SyncErrors"></a> msdyn_suggestionrequestpayload_SyncErrors

Many-To-One Relationship: [syncerror msdyn_suggestionrequestpayload_SyncErrors](syncerror.md#BKMK_msdyn_suggestionrequestpayload_SyncErrors)

|Property|Value|
|---|---|
|ReferencingEntity|`syncerror`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_suggestionrequestpayload_SyncErrors`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|



### See also

[Dataverse table/entity reference](/power-apps/developer/data-platform/reference/about-entity-reference)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   

