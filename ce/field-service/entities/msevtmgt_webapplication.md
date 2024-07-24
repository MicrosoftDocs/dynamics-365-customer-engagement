---
title: "Web application (msevtmgt_webapplication) table/entity reference (Microsoft Dynamics 365 Field Service)"
description: "Includes schema information and supported messages for the Web application (msevtmgt_webapplication) table/entity with Microsoft Dynamics 365 Field Service."
ms.date: 07.24.2024
ms.service: powerapps
ms.topic: reference
author: m-hartmann
ms.author: mhart
search.audienceType: 
  - developer
---

# Web application (msevtmgt_webapplication) table/entity reference



## Messages

The following table lists the messages for the Web application (msevtmgt_webapplication) table.
Messages represent operations that can be performed on the table. They may also be events.

| Name <br />Is Event? |Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `Create`<br />Event: True |`POST` /msevtmgt_webapplications<br />See [Create](/powerapps/developer/data-platform/webapi/create-entity-web-api) |[Create records](/power-apps/developer/data-platform/org-service/entity-operations-create#basic-create)|
| `CreateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.CreateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.CreateMultipleRequest>|
| `Delete`<br />Event: True |`DELETE` /msevtmgt_webapplications(*msevtmgt_webapplicationid*)<br />See [Delete](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-delete) |[Delete records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-delete)|
| `IsValidStateTransition`<br />Event: False |<xref:Microsoft.Dynamics.CRM.IsValidStateTransition?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.IsValidStateTransitionRequest>|
| `Restore`<br />Event: True |<xref:Microsoft.Dynamics.CRM.Restore?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retrieve`<br />Event: True |`GET` /msevtmgt_webapplications(*msevtmgt_webapplicationid*)<br />See [Retrieve](/powerapps/developer/data-platform/webapi/retrieve-entity-using-web-api) |[Retrieve records](/power-apps/developer/data-platform/org-service/entity-operations-retrieve)|
| `RetrieveMultiple`<br />Event: True |`GET` /msevtmgt_webapplications<br />See [Query data](/power-apps/developer/data-platform/webapi/query-data-web-api) |[Query data](/power-apps/developer/data-platform/org-service/entity-operations-query-data)|
| `SetState`<br />Event: True |`PATCH` /msevtmgt_webapplications(*msevtmgt_webapplicationid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `statecode` and `statuscode` properties. |<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|
| `Update`<br />Event: True |`PATCH` /msevtmgt_webapplications(*msevtmgt_webapplicationid*)<br />See [Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) |[Update records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-update)|
| `UpdateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.UpdateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpdateMultipleRequest>|
| `Upsert`<br />Event: False |`PATCH` /msevtmgt_webapplications(*msevtmgt_webapplicationid*)<br />See [Upsert a table row](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#upsert-a-table-row) |<xref:Microsoft.Xrm.Sdk.Messages.UpsertRequest>|
| `UpsertMultiple`<br />Event: False |<xref:Microsoft.Dynamics.CRM.UpsertMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpsertMultipleRequest>|


## Events

The following table lists the events for the Web application (msevtmgt_webapplication) table.
Events are messages that exist so that you can subscribe to them. Unless you added the event, you shouldn't invoke the message, only subscribe to it.

|Name|Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `BulkRetain`|<xref:Microsoft.Dynamics.CRM.BulkRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `PurgeRetainedContent`|<xref:Microsoft.Dynamics.CRM.PurgeRetainedContent?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retain`|<xref:Microsoft.Dynamics.CRM.Retain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `RollbackRetain`|<xref:Microsoft.Dynamics.CRM.RollbackRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `ValidateRetentionConfig`|<xref:Microsoft.Dynamics.CRM.ValidateRetentionConfig?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|

## Properties

The following table lists selected properties for the Web application (msevtmgt_webapplication) table.

|Property|Value|
| --- | --- |
| **DisplayName** | **Web application** |
| **DisplayCollectionName** | **Web applications** |
| **SchemaName** | `msevtmgt_webapplication` |
| **CollectionSchemaName** | `msevtmgt_webapplications` |
| **EntitySetName** | `msevtmgt_webapplications`|
| **LogicalName** | `msevtmgt_webapplication` |
| **LogicalCollectionName** | `msevtmgt_webapplications` |
| **PrimaryIdAttribute** | `msevtmgt_webapplicationid` |
| **PrimaryNameAttribute** |`msevtmgt_name` |
| **TableType** | `Standard` |
| **OwnershipType** | `OrganizationOwned` |

## Writable columns/attributes

These columns/attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [msevtmgt_aadclientid](#BKMK_msevtmgt_aadclientid)
- [msevtmgt_aadmetadataendpoint](#BKMK_msevtmgt_aadmetadataendpoint)
- [msevtmgt_learnmorelink](#BKMK_msevtmgt_learnmorelink)
- [msevtmgt_name](#BKMK_msevtmgt_name)
- [msevtmgt_origin](#BKMK_msevtmgt_origin)
- [msevtmgt_publicendpoint](#BKMK_msevtmgt_publicendpoint)
- [msevtmgt_publicendpointv2_api](#BKMK_msevtmgt_publicendpointv2_api)
- [msevtmgt_publicendpointv2_app](#BKMK_msevtmgt_publicendpointv2_app)
- [msevtmgt_publicendpointv2_docs](#BKMK_msevtmgt_publicendpointv2_docs)
- [msevtmgt_token](#BKMK_msevtmgt_token)
- [msevtmgt_userauthenticationtype](#BKMK_msevtmgt_userauthenticationtype)
- [msevtmgt_webapplicationId](#BKMK_msevtmgt_webapplicationId)
- [OverriddenCreatedOn](#BKMK_OverriddenCreatedOn)
- [statecode](#BKMK_statecode)
- [statuscode](#BKMK_statuscode)
- [TimeZoneRuleVersionNumber](#BKMK_TimeZoneRuleVersionNumber)
- [UTCConversionTimeZoneCode](#BKMK_UTCConversionTimeZoneCode)

### <a name="BKMK_ImportSequenceNumber"></a> ImportSequenceNumber

|Property|Value|
|---|---|
|Description|**Sequence number of the import that created this record**|
|DisplayName|**Import sequence number**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`importsequencenumber`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|-2147483648|

### <a name="BKMK_msevtmgt_aadclientid"></a> msevtmgt_aadclientid

|Property|Value|
|---|---|
|Description||
|DisplayName|**Microsoft Entra Client ID**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msevtmgt_aadclientid`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|300|

### <a name="BKMK_msevtmgt_aadmetadataendpoint"></a> msevtmgt_aadmetadataendpoint

|Property|Value|
|---|---|
|Description||
|DisplayName|**Microsoft Entra metadata endpoint**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msevtmgt_aadmetadataendpoint`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|300|

### <a name="BKMK_msevtmgt_learnmorelink"></a> msevtmgt_learnmorelink

|Property|Value|
|---|---|
|Description||
|DisplayName|**Learn more**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msevtmgt_learnmorelink`|
|RequiredLevel|None|
|Type|String|
|Format|Url|
|FormatName|Url|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|300|

### <a name="BKMK_msevtmgt_name"></a> msevtmgt_name

|Property|Value|
|---|---|
|Description|**The name of the custom entity**|
|DisplayName|**Name**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msevtmgt_name`|
|RequiredLevel|ApplicationRequired|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msevtmgt_origin"></a> msevtmgt_origin

|Property|Value|
|---|---|
|Description||
|DisplayName|**Origin**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msevtmgt_origin`|
|RequiredLevel|ApplicationRequired|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msevtmgt_publicendpoint"></a> msevtmgt_publicendpoint

|Property|Value|
|---|---|
|Description||
|DisplayName|**Outbound Marketing Endpoint**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msevtmgt_publicendpoint`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|300|

### <a name="BKMK_msevtmgt_publicendpointv2_api"></a> msevtmgt_publicendpointv2_api

|Property|Value|
|---|---|
|Description||
|DisplayName|**Endpoint (Preview)**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msevtmgt_publicendpointv2_api`|
|RequiredLevel|None|
|Type|String|
|Format|Url|
|FormatName|Url|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|300|

### <a name="BKMK_msevtmgt_publicendpointv2_app"></a> msevtmgt_publicendpointv2_app

|Property|Value|
|---|---|
|Description||
|DisplayName|**Sample web application (Preview)**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msevtmgt_publicendpointv2_app`|
|RequiredLevel|None|
|Type|String|
|Format|Url|
|FormatName|Url|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|300|

### <a name="BKMK_msevtmgt_publicendpointv2_docs"></a> msevtmgt_publicendpointv2_docs

|Property|Value|
|---|---|
|Description||
|DisplayName|**Endpoint documentation (Preview)**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msevtmgt_publicendpointv2_docs`|
|RequiredLevel|None|
|Type|String|
|Format|Url|
|FormatName|Url|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|300|

### <a name="BKMK_msevtmgt_token"></a> msevtmgt_token

|Property|Value|
|---|---|
|Description||
|DisplayName|**Token**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msevtmgt_token`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|300|

### <a name="BKMK_msevtmgt_userauthenticationtype"></a> msevtmgt_userauthenticationtype

|Property|Value|
|---|---|
|Description||
|DisplayName|**User Authentication Type**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msevtmgt_userauthenticationtype`|
|RequiredLevel|None|
|Type|Picklist|
|DefaultFormValue|-1|
|GlobalChoiceName|`msevtmgt_webapplication_msevtmgt_userauthenticationtype`|

#### msevtmgt_userauthenticationtype Choices/Options

|Value|Label|
|---|---|
|100000001|**Azure Active Directory B2C**|

### <a name="BKMK_msevtmgt_webapplicationId"></a> msevtmgt_webapplicationId

|Property|Value|
|---|---|
|Description|**Unique identifier for entity instances**|
|DisplayName|**Web application**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`msevtmgt_webapplicationid`|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|

### <a name="BKMK_OverriddenCreatedOn"></a> OverriddenCreatedOn

|Property|Value|
|---|---|
|Description|**Date and time that the record was migrated.**|
|DisplayName|**Record created on**|
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
|Description|**Status of the web application**|
|DisplayName|**Status**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statecode`|
|RequiredLevel|SystemRequired|
|Type|State|
|DefaultFormValue||
|GlobalChoiceName|`msevtmgt_webapplication_statecode`|

#### statecode Choices/Options

|Value|Details|
|---|---|
|0|Label: **Active**<br />DefaultStatus: 1<br />InvariantName: `Active`|
|1|Label: **Inactive**<br />DefaultStatus: 2<br />InvariantName: `Inactive`|

### <a name="BKMK_statuscode"></a> statuscode

|Property|Value|
|---|---|
|Description|**Reason for the status of the web application**|
|DisplayName|**Status reason**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statuscode`|
|RequiredLevel|None|
|Type|Status|
|DefaultFormValue||
|GlobalChoiceName|`msevtmgt_webapplication_statuscode`|

#### statuscode Choices/Options

|Value|Details|
|---|---|
|1|Label: **Active**<br />State:0<br />TransitionData: None|
|2|Label: **Inactive**<br />State:1<br />TransitionData: None|

### <a name="BKMK_TimeZoneRuleVersionNumber"></a> TimeZoneRuleVersionNumber

|Property|Value|
|---|---|
|Description|**For internal use only**|
|DisplayName|**Time zone rule version number**|
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
|Description|**Time zone code that was in use when the record was created**|
|DisplayName|**UTC conversion time zone code**|
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
|Description|**Unique identifier of the user who created the record**|
|DisplayName|**Created by**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`createdby`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|systemuser|

### <a name="BKMK_CreatedOn"></a> CreatedOn

|Property|Value|
|---|---|
|Description|**Date and time when the record was created**|
|DisplayName|**Created on**|
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
|Description|**Unique identifier of the delegate user who created the record**|
|DisplayName|**Created by (delegate)**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`createdonbehalfby`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|systemuser|

### <a name="BKMK_ModifiedBy"></a> ModifiedBy

|Property|Value|
|---|---|
|Description|**Unique identifier of the user who modified the record**|
|DisplayName|**Modified by**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`modifiedby`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|systemuser|

### <a name="BKMK_ModifiedOn"></a> ModifiedOn

|Property|Value|
|---|---|
|Description|**Date and time when the record was modified**|
|DisplayName|**Modified on**|
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
|Description|**Unique identifier of the delegate user who modified the record**|
|DisplayName|**Modified by (delegate)**|
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
|DisplayName|**Organization ID**|
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

- [lk_msevtmgt_webapplication_createdby](#BKMK_lk_msevtmgt_webapplication_createdby)
- [lk_msevtmgt_webapplication_createdonbehalfby](#BKMK_lk_msevtmgt_webapplication_createdonbehalfby)
- [lk_msevtmgt_webapplication_modifiedby](#BKMK_lk_msevtmgt_webapplication_modifiedby)
- [lk_msevtmgt_webapplication_modifiedonbehalfby](#BKMK_lk_msevtmgt_webapplication_modifiedonbehalfby)
- [organization_msevtmgt_webapplication](#BKMK_organization_msevtmgt_webapplication)

### <a name="BKMK_lk_msevtmgt_webapplication_createdby"></a> lk_msevtmgt_webapplication_createdby

One-To-Many Relationship: [systemuser lk_msevtmgt_webapplication_createdby](systemuser.md#BKMK_lk_msevtmgt_webapplication_createdby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdby`|
|ReferencingEntityNavigationPropertyName|`createdby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msevtmgt_webapplication_createdonbehalfby"></a> lk_msevtmgt_webapplication_createdonbehalfby

One-To-Many Relationship: [systemuser lk_msevtmgt_webapplication_createdonbehalfby](systemuser.md#BKMK_lk_msevtmgt_webapplication_createdonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdonbehalfby`|
|ReferencingEntityNavigationPropertyName|`createdonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msevtmgt_webapplication_modifiedby"></a> lk_msevtmgt_webapplication_modifiedby

One-To-Many Relationship: [systemuser lk_msevtmgt_webapplication_modifiedby](systemuser.md#BKMK_lk_msevtmgt_webapplication_modifiedby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedby`|
|ReferencingEntityNavigationPropertyName|`modifiedby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msevtmgt_webapplication_modifiedonbehalfby"></a> lk_msevtmgt_webapplication_modifiedonbehalfby

One-To-Many Relationship: [systemuser lk_msevtmgt_webapplication_modifiedonbehalfby](systemuser.md#BKMK_lk_msevtmgt_webapplication_modifiedonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedonbehalfby`|
|ReferencingEntityNavigationPropertyName|`modifiedonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_organization_msevtmgt_webapplication"></a> organization_msevtmgt_webapplication

One-To-Many Relationship: [organization organization_msevtmgt_webapplication](organization.md#BKMK_organization_msevtmgt_webapplication)

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

- [msevtmgt_webapplication_AsyncOperations](#BKMK_msevtmgt_webapplication_AsyncOperations)
- [msevtmgt_webapplication_BulkDeleteFailures](#BKMK_msevtmgt_webapplication_BulkDeleteFailures)
- [msevtmgt_webapplication_DuplicateBaseRecord](#BKMK_msevtmgt_webapplication_DuplicateBaseRecord)
- [msevtmgt_webapplication_DuplicateMatchingRecord](#BKMK_msevtmgt_webapplication_DuplicateMatchingRecord)
- [msevtmgt_webapplication_MailboxTrackingFolders](#BKMK_msevtmgt_webapplication_MailboxTrackingFolders)
- [msevtmgt_webapplication_PrincipalObjectAttributeAccesses](#BKMK_msevtmgt_webapplication_PrincipalObjectAttributeAccesses)
- [msevtmgt_webapplication_ProcessSession](#BKMK_msevtmgt_webapplication_ProcessSession)
- [msevtmgt_webapplication_SyncErrors](#BKMK_msevtmgt_webapplication_SyncErrors)

### <a name="BKMK_msevtmgt_webapplication_AsyncOperations"></a> msevtmgt_webapplication_AsyncOperations

Many-To-One Relationship: [asyncoperation msevtmgt_webapplication_AsyncOperations](asyncoperation.md#BKMK_msevtmgt_webapplication_AsyncOperations)

|Property|Value|
|---|---|
|ReferencingEntity|`asyncoperation`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_webapplication_AsyncOperations`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_webapplication_BulkDeleteFailures"></a> msevtmgt_webapplication_BulkDeleteFailures

Many-To-One Relationship: [bulkdeletefailure msevtmgt_webapplication_BulkDeleteFailures](bulkdeletefailure.md#BKMK_msevtmgt_webapplication_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencingEntity|`bulkdeletefailure`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_webapplication_BulkDeleteFailures`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_webapplication_DuplicateBaseRecord"></a> msevtmgt_webapplication_DuplicateBaseRecord

Many-To-One Relationship: [duplicaterecord msevtmgt_webapplication_DuplicateBaseRecord](duplicaterecord.md#BKMK_msevtmgt_webapplication_DuplicateBaseRecord)

|Property|Value|
|---|---|
|ReferencingEntity|`duplicaterecord`|
|ReferencingAttribute|`baserecordid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_webapplication_DuplicateBaseRecord`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_webapplication_DuplicateMatchingRecord"></a> msevtmgt_webapplication_DuplicateMatchingRecord

Many-To-One Relationship: [duplicaterecord msevtmgt_webapplication_DuplicateMatchingRecord](duplicaterecord.md#BKMK_msevtmgt_webapplication_DuplicateMatchingRecord)

|Property|Value|
|---|---|
|ReferencingEntity|`duplicaterecord`|
|ReferencingAttribute|`duplicaterecordid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_webapplication_DuplicateMatchingRecord`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_webapplication_MailboxTrackingFolders"></a> msevtmgt_webapplication_MailboxTrackingFolders

Many-To-One Relationship: [mailboxtrackingfolder msevtmgt_webapplication_MailboxTrackingFolders](mailboxtrackingfolder.md#BKMK_msevtmgt_webapplication_MailboxTrackingFolders)

|Property|Value|
|---|---|
|ReferencingEntity|`mailboxtrackingfolder`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_webapplication_MailboxTrackingFolders`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_webapplication_PrincipalObjectAttributeAccesses"></a> msevtmgt_webapplication_PrincipalObjectAttributeAccesses

Many-To-One Relationship: [principalobjectattributeaccess msevtmgt_webapplication_PrincipalObjectAttributeAccesses](principalobjectattributeaccess.md#BKMK_msevtmgt_webapplication_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencingEntity|`principalobjectattributeaccess`|
|ReferencingAttribute|`objectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_webapplication_PrincipalObjectAttributeAccesses`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_webapplication_ProcessSession"></a> msevtmgt_webapplication_ProcessSession

Many-To-One Relationship: [processsession msevtmgt_webapplication_ProcessSession](processsession.md#BKMK_msevtmgt_webapplication_ProcessSession)

|Property|Value|
|---|---|
|ReferencingEntity|`processsession`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_webapplication_ProcessSession`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_webapplication_SyncErrors"></a> msevtmgt_webapplication_SyncErrors

Many-To-One Relationship: [syncerror msevtmgt_webapplication_SyncErrors](syncerror.md#BKMK_msevtmgt_webapplication_SyncErrors)

|Property|Value|
|---|---|
|ReferencingEntity|`syncerror`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_webapplication_SyncErrors`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|



### See also

[Dataverse table/entity reference](../about-entity-reference.md)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   

