---
title: "Customer feedback survey (msdyn_customerfeedbacksurvey) table/entity reference (Microsoft Dynamics 365)"
description: "Includes schema information and supported messages for the Customer feedback survey (msdyn_customerfeedbacksurvey) table/entity with Microsoft Dynamics 365."
ms.topic: generated-reference
author: JimDaly
ms.author: jdaly
search.audienceType: 
  - developer
---

# Customer feedback survey (msdyn_customerfeedbacksurvey) table/entity reference (Microsoft Dynamics 365)



## Messages

The following table lists the messages for the Customer feedback survey (msdyn_customerfeedbacksurvey) table.
Messages represent operations that can be performed on the table. They may also be events.

| Name <br />Is Event? |Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `Associate`<br />Event: True |[Associate records](/power-apps/developer/data-platform/webapi/associate-disassociate-entities-using-web-api) |[Associate records](/power-apps/developer/data-platform/org-service/entity-operations-associate-disassociate#use-the-associate-method-or-associaterequest)|
| `BulkRetain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.BulkRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Create`<br />Event: True |`POST` /msdyn_customerfeedbacksurveys<br />See [Create](/powerapps/developer/data-platform/webapi/create-entity-web-api) |[Create records](/power-apps/developer/data-platform/org-service/entity-operations-create#basic-create)|
| `CreateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.CreateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.CreateMultipleRequest>|
| `Delete`<br />Event: True |`DELETE` /msdyn_customerfeedbacksurveys(*msdyn_customerfeedbacksurveyid*)<br />See [Delete](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-delete) |[Delete records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-delete)|
| `Disassociate`<br />Event: True |[Disassociate records](/power-apps/developer/data-platform/webapi/associate-disassociate-entities-using-web-api) |[Disassociate records](/power-apps/developer/data-platform/org-service/entity-operations-associate-disassociate#use-the-disassociate-method-or-disassociaterequest)|
| `IsValidStateTransition`<br />Event: False |<xref:Microsoft.Dynamics.CRM.IsValidStateTransition?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.IsValidStateTransitionRequest>|
| `PurgeRetainedContent`<br />Event: True |<xref:Microsoft.Dynamics.CRM.PurgeRetainedContent?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Restore`<br />Event: True |<xref:Microsoft.Dynamics.CRM.Restore?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.Retain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retrieve`<br />Event: True |`GET` /msdyn_customerfeedbacksurveys(*msdyn_customerfeedbacksurveyid*)<br />See [Retrieve](/powerapps/developer/data-platform/webapi/retrieve-entity-using-web-api) |[Retrieve records](/power-apps/developer/data-platform/org-service/entity-operations-retrieve)|
| `RetrieveMultiple`<br />Event: True |`GET` /msdyn_customerfeedbacksurveys<br />See [Query data](/power-apps/developer/data-platform/webapi/query-data-web-api) |[Query data](/power-apps/developer/data-platform/org-service/entity-operations-query-data)|
| `RollbackRetain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RollbackRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `SetState`<br />Event: True |`PATCH` /msdyn_customerfeedbacksurveys(*msdyn_customerfeedbacksurveyid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `statecode` and `statuscode` properties. |<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|
| `Update`<br />Event: True |`PATCH` /msdyn_customerfeedbacksurveys(*msdyn_customerfeedbacksurveyid*)<br />See [Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) |[Update records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-update)|
| `UpdateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.UpdateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpdateMultipleRequest>|
| `Upsert`<br />Event: False |`PATCH` /msdyn_customerfeedbacksurveys(*msdyn_customerfeedbacksurveyid*)<br />See [Upsert a table row](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#upsert-a-table-row) |<xref:Microsoft.Xrm.Sdk.Messages.UpsertRequest>|
| `UpsertMultiple`<br />Event: False |<xref:Microsoft.Dynamics.CRM.UpsertMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpsertMultipleRequest>|
| `ValidateRetentionConfig`<br />Event: True |<xref:Microsoft.Dynamics.CRM.ValidateRetentionConfig?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|

## Properties

The following table lists selected properties for the Customer feedback survey (msdyn_customerfeedbacksurvey) table.

|Property|Value|
| --- | --- |
| **DisplayName** | **Customer feedback survey** |
| **DisplayCollectionName** | **Customer feedback surveys** |
| **SchemaName** | `msdyn_customerfeedbacksurvey` |
| **CollectionSchemaName** | `msdyn_customerfeedbacksurveies` |
| **EntitySetName** | `msdyn_customerfeedbacksurveys`|
| **LogicalName** | `msdyn_customerfeedbacksurvey` |
| **LogicalCollectionName** | `msdyn_customerfeedbacksurveies` |
| **PrimaryIdAttribute** | `msdyn_customerfeedbacksurveyid` |
| **PrimaryNameAttribute** |`msdyn_customerfeedbacksurveyname` |
| **TableType** | `Standard` |
| **OwnershipType** | `OrganizationOwned` |

## Writable columns/attributes

These columns/attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [msdyn_customerfeedbackbotstatus](#BKMK_msdyn_customerfeedbackbotstatus)
- [msdyn_customerfeedbacksurveyId](#BKMK_msdyn_customerfeedbacksurveyId)
- [msdyn_customerfeedbacksurveyname](#BKMK_msdyn_customerfeedbacksurveyname)
- [msdyn_customerfeedbacksurveyprovider](#BKMK_msdyn_customerfeedbacksurveyprovider)
- [msdyn_customerfeedbacksurveyurl](#BKMK_msdyn_customerfeedbacksurveyurl)
- [msdyn_customhosturl](#BKMK_msdyn_customhosturl)
- [msdyn_microsoftcopilotstudiobot](#BKMK_msdyn_microsoftcopilotstudiobot)
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

### <a name="BKMK_msdyn_customerfeedbackbotstatus"></a> msdyn_customerfeedbackbotstatus

|Property|Value|
|---|---|
|Description|**Customer feedback bot status**|
|DisplayName|**Customer feedback bot status**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_customerfeedbackbotstatus`|
|RequiredLevel|None|
|Type|Picklist|
|DefaultFormValue|357890000|
|GlobalChoiceName|`msdyn_mcsbotstatus`|

#### msdyn_customerfeedbackbotstatus Choices/Options

|Value|Label|
|---|---|
|357890000|**InProgress**|
|357890001|**Ready**|
|357890002|**Disconnected**|

### <a name="BKMK_msdyn_customerfeedbacksurveyId"></a> msdyn_customerfeedbacksurveyId

|Property|Value|
|---|---|
|Description|**Unique identifier for entity instances**|
|DisplayName|**Customer feedback survey Id**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`msdyn_customerfeedbacksurveyid`|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|

### <a name="BKMK_msdyn_customerfeedbacksurveyname"></a> msdyn_customerfeedbacksurveyname

|Property|Value|
|---|---|
|Description|**Customer feedback survey name**|
|DisplayName|**Customer feedback survey name**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_customerfeedbacksurveyname`|
|RequiredLevel|ApplicationRequired|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdyn_customerfeedbacksurveyprovider"></a> msdyn_customerfeedbacksurveyprovider

|Property|Value|
|---|---|
|Description||
|DisplayName|**Customer feedback survey provider**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_customerfeedbacksurveyprovider`|
|RequiredLevel|ApplicationRequired|
|Type|Picklist|
|DefaultFormValue|600990001|
|GlobalChoiceName|`msdyn_surveyprovider`|

#### msdyn_customerfeedbacksurveyprovider Choices/Options

|Value|Label|
|---|---|
|600990000|**Customer Voice**|
|600990001|**Microsoft Copilot Studio**|

### <a name="BKMK_msdyn_customerfeedbacksurveyurl"></a> msdyn_customerfeedbacksurveyurl

|Property|Value|
|---|---|
|Description|**Customer feedback survey URL**|
|DisplayName|**Customer feedback survey URL**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_customerfeedbacksurveyurl`|
|RequiredLevel|ApplicationRequired|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|500|

### <a name="BKMK_msdyn_customhosturl"></a> msdyn_customhosturl

|Property|Value|
|---|---|
|Description|**Custom host url**|
|DisplayName|**customhosturl**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_customhosturl`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|500|

### <a name="BKMK_msdyn_microsoftcopilotstudiobot"></a> msdyn_microsoftcopilotstudiobot

|Property|Value|
|---|---|
|Description|**Copilot Bot Id**|
|DisplayName|**Copilot Bot Id**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_microsoftcopilotstudiobot`|
|RequiredLevel|ApplicationRequired|
|Type|Lookup|
|Targets|bot|

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
|Description|**Status of the customer feedback survey**|
|DisplayName|**Status**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statecode`|
|RequiredLevel|SystemRequired|
|Type|State|
|DefaultFormValue||
|GlobalChoiceName|`msdyn_customerfeedbacksurvey_statecode`|

#### statecode Choices/Options

|Value|Details|
|---|---|
|0|Label: **Active**<br />DefaultStatus: 1<br />InvariantName: `Active`|
|1|Label: **Inactive**<br />DefaultStatus: 2<br />InvariantName: `Inactive`|

### <a name="BKMK_statuscode"></a> statuscode

|Property|Value|
|---|---|
|Description|**Reason for the status of the customer feedback survey**|
|DisplayName|**Status Reason**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statuscode`|
|RequiredLevel|None|
|Type|Status|
|DefaultFormValue||
|GlobalChoiceName|`msdyn_customerfeedbacksurvey_statuscode`|

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

- [bot_msdyn_microsoftcopilotstudiobot](#BKMK_bot_msdyn_microsoftcopilotstudiobot)
- [lk_msdyn_customerfeedbacksurvey_createdby](#BKMK_lk_msdyn_customerfeedbacksurvey_createdby)
- [lk_msdyn_customerfeedbacksurvey_createdonbehalfby](#BKMK_lk_msdyn_customerfeedbacksurvey_createdonbehalfby)
- [lk_msdyn_customerfeedbacksurvey_modifiedby](#BKMK_lk_msdyn_customerfeedbacksurvey_modifiedby)
- [lk_msdyn_customerfeedbacksurvey_modifiedonbehalfby](#BKMK_lk_msdyn_customerfeedbacksurvey_modifiedonbehalfby)
- [organization_msdyn_customerfeedbacksurvey](#BKMK_organization_msdyn_customerfeedbacksurvey)

### <a name="BKMK_bot_msdyn_microsoftcopilotstudiobot"></a> bot_msdyn_microsoftcopilotstudiobot

One-To-Many Relationship: [bot bot_msdyn_microsoftcopilotstudiobot](bot.md#BKMK_bot_msdyn_microsoftcopilotstudiobot)

|Property|Value|
|---|---|
|ReferencedEntity|`bot`|
|ReferencedAttribute|`botid`|
|ReferencingAttribute|`msdyn_microsoftcopilotstudiobot`|
|ReferencingEntityNavigationPropertyName|`msdyn_microsoftcopilotstudiobot`|
|IsHierarchical||
|CascadeConfiguration|Archive: `RemoveLink`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_customerfeedbacksurvey_createdby"></a> lk_msdyn_customerfeedbacksurvey_createdby

One-To-Many Relationship: [systemuser lk_msdyn_customerfeedbacksurvey_createdby](systemuser.md#BKMK_lk_msdyn_customerfeedbacksurvey_createdby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdby`|
|ReferencingEntityNavigationPropertyName|`createdby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_customerfeedbacksurvey_createdonbehalfby"></a> lk_msdyn_customerfeedbacksurvey_createdonbehalfby

One-To-Many Relationship: [systemuser lk_msdyn_customerfeedbacksurvey_createdonbehalfby](systemuser.md#BKMK_lk_msdyn_customerfeedbacksurvey_createdonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdonbehalfby`|
|ReferencingEntityNavigationPropertyName|`createdonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_customerfeedbacksurvey_modifiedby"></a> lk_msdyn_customerfeedbacksurvey_modifiedby

One-To-Many Relationship: [systemuser lk_msdyn_customerfeedbacksurvey_modifiedby](systemuser.md#BKMK_lk_msdyn_customerfeedbacksurvey_modifiedby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedby`|
|ReferencingEntityNavigationPropertyName|`modifiedby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_customerfeedbacksurvey_modifiedonbehalfby"></a> lk_msdyn_customerfeedbacksurvey_modifiedonbehalfby

One-To-Many Relationship: [systemuser lk_msdyn_customerfeedbacksurvey_modifiedonbehalfby](systemuser.md#BKMK_lk_msdyn_customerfeedbacksurvey_modifiedonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedonbehalfby`|
|ReferencingEntityNavigationPropertyName|`modifiedonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_organization_msdyn_customerfeedbacksurvey"></a> organization_msdyn_customerfeedbacksurvey

One-To-Many Relationship: [organization organization_msdyn_customerfeedbacksurvey](organization.md#BKMK_organization_msdyn_customerfeedbacksurvey)

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

- [msdyn_customerfeedbacksurvey_AsyncOperations](#BKMK_msdyn_customerfeedbacksurvey_AsyncOperations)
- [msdyn_customerfeedbacksurvey_BulkDeleteFailures](#BKMK_msdyn_customerfeedbacksurvey_BulkDeleteFailures)
- [msdyn_customerfeedbacksurvey_DuplicateBaseRecord](#BKMK_msdyn_customerfeedbacksurvey_DuplicateBaseRecord)
- [msdyn_customerfeedbacksurvey_DuplicateMatchingRecord](#BKMK_msdyn_customerfeedbacksurvey_DuplicateMatchingRecord)
- [msdyn_customerfeedbacksurvey_MailboxTrackingFolders](#BKMK_msdyn_customerfeedbacksurvey_MailboxTrackingFolders)
- [msdyn_customerfeedbacksurvey_msdyn_customerfeedbacksurveyinvite](#BKMK_msdyn_customerfeedbacksurvey_msdyn_customerfeedbacksurveyinvite)
- [msdyn_customerfeedbacksurvey_msdyn_customerfeedbacksurveyresponse](#BKMK_msdyn_customerfeedbacksurvey_msdyn_customerfeedbacksurveyresponse)
- [msdyn_customerfeedbacksurvey_msdyn_surveysetting](#BKMK_msdyn_customerfeedbacksurvey_msdyn_surveysetting)
- [msdyn_customerfeedbacksurvey_PrincipalObjectAttributeAccesses](#BKMK_msdyn_customerfeedbacksurvey_PrincipalObjectAttributeAccesses)
- [msdyn_customerfeedbacksurvey_ProcessSession](#BKMK_msdyn_customerfeedbacksurvey_ProcessSession)
- [msdyn_customerfeedbacksurvey_SyncErrors](#BKMK_msdyn_customerfeedbacksurvey_SyncErrors)

### <a name="BKMK_msdyn_customerfeedbacksurvey_AsyncOperations"></a> msdyn_customerfeedbacksurvey_AsyncOperations

Many-To-One Relationship: [asyncoperation msdyn_customerfeedbacksurvey_AsyncOperations](asyncoperation.md#BKMK_msdyn_customerfeedbacksurvey_AsyncOperations)

|Property|Value|
|---|---|
|ReferencingEntity|`asyncoperation`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_customerfeedbacksurvey_AsyncOperations`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_customerfeedbacksurvey_BulkDeleteFailures"></a> msdyn_customerfeedbacksurvey_BulkDeleteFailures

Many-To-One Relationship: [bulkdeletefailure msdyn_customerfeedbacksurvey_BulkDeleteFailures](bulkdeletefailure.md#BKMK_msdyn_customerfeedbacksurvey_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencingEntity|`bulkdeletefailure`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_customerfeedbacksurvey_BulkDeleteFailures`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_customerfeedbacksurvey_DuplicateBaseRecord"></a> msdyn_customerfeedbacksurvey_DuplicateBaseRecord

Many-To-One Relationship: [duplicaterecord msdyn_customerfeedbacksurvey_DuplicateBaseRecord](duplicaterecord.md#BKMK_msdyn_customerfeedbacksurvey_DuplicateBaseRecord)

|Property|Value|
|---|---|
|ReferencingEntity|`duplicaterecord`|
|ReferencingAttribute|`baserecordid`|
|ReferencedEntityNavigationPropertyName|`msdyn_customerfeedbacksurvey_DuplicateBaseRecord`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_customerfeedbacksurvey_DuplicateMatchingRecord"></a> msdyn_customerfeedbacksurvey_DuplicateMatchingRecord

Many-To-One Relationship: [duplicaterecord msdyn_customerfeedbacksurvey_DuplicateMatchingRecord](duplicaterecord.md#BKMK_msdyn_customerfeedbacksurvey_DuplicateMatchingRecord)

|Property|Value|
|---|---|
|ReferencingEntity|`duplicaterecord`|
|ReferencingAttribute|`duplicaterecordid`|
|ReferencedEntityNavigationPropertyName|`msdyn_customerfeedbacksurvey_DuplicateMatchingRecord`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_customerfeedbacksurvey_MailboxTrackingFolders"></a> msdyn_customerfeedbacksurvey_MailboxTrackingFolders

Many-To-One Relationship: [mailboxtrackingfolder msdyn_customerfeedbacksurvey_MailboxTrackingFolders](mailboxtrackingfolder.md#BKMK_msdyn_customerfeedbacksurvey_MailboxTrackingFolders)

|Property|Value|
|---|---|
|ReferencingEntity|`mailboxtrackingfolder`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_customerfeedbacksurvey_MailboxTrackingFolders`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_customerfeedbacksurvey_msdyn_customerfeedbacksurveyinvite"></a> msdyn_customerfeedbacksurvey_msdyn_customerfeedbacksurveyinvite

Many-To-One Relationship: [msdyn_customerfeedbacksurveyinvite msdyn_customerfeedbacksurvey_msdyn_customerfeedbacksurveyinvite](msdyn_customerfeedbacksurveyinvite.md#BKMK_msdyn_customerfeedbacksurvey_msdyn_customerfeedbacksurveyinvite)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_customerfeedbacksurveyinvite`|
|ReferencingAttribute|`msdyn_customerfeedbacksurveyid`|
|ReferencedEntityNavigationPropertyName|`msdyn_customerfeedbacksurvey_msdyn_customerfeedbacksurveyinvite`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_customerfeedbacksurvey_msdyn_customerfeedbacksurveyresponse"></a> msdyn_customerfeedbacksurvey_msdyn_customerfeedbacksurveyresponse

Many-To-One Relationship: [msdyn_customerfeedbacksurveyresponse msdyn_customerfeedbacksurvey_msdyn_customerfeedbacksurveyresponse](msdyn_customerfeedbacksurveyresponse.md#BKMK_msdyn_customerfeedbacksurvey_msdyn_customerfeedbacksurveyresponse)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_customerfeedbacksurveyresponse`|
|ReferencingAttribute|`msdyn_customerfeedbacksurveyid`|
|ReferencedEntityNavigationPropertyName|`msdyn_customerfeedbacksurvey_msdyn_customerfeedbacksurveyresponse`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_customerfeedbacksurvey_msdyn_surveysetting"></a> msdyn_customerfeedbacksurvey_msdyn_surveysetting

Many-To-One Relationship: [msdyn_surveysetting msdyn_customerfeedbacksurvey_msdyn_surveysetting](msdyn_surveysetting.md#BKMK_msdyn_customerfeedbacksurvey_msdyn_surveysetting)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_surveysetting`|
|ReferencingAttribute|`msdyn_customerfeedbacksurvey`|
|ReferencedEntityNavigationPropertyName|`msdyn_customerfeedbacksurvey_msdyn_surveysetting`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_customerfeedbacksurvey_PrincipalObjectAttributeAccesses"></a> msdyn_customerfeedbacksurvey_PrincipalObjectAttributeAccesses

Many-To-One Relationship: [principalobjectattributeaccess msdyn_customerfeedbacksurvey_PrincipalObjectAttributeAccesses](principalobjectattributeaccess.md#BKMK_msdyn_customerfeedbacksurvey_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencingEntity|`principalobjectattributeaccess`|
|ReferencingAttribute|`objectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_customerfeedbacksurvey_PrincipalObjectAttributeAccesses`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_customerfeedbacksurvey_ProcessSession"></a> msdyn_customerfeedbacksurvey_ProcessSession

Many-To-One Relationship: [processsession msdyn_customerfeedbacksurvey_ProcessSession](processsession.md#BKMK_msdyn_customerfeedbacksurvey_ProcessSession)

|Property|Value|
|---|---|
|ReferencingEntity|`processsession`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_customerfeedbacksurvey_ProcessSession`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_customerfeedbacksurvey_SyncErrors"></a> msdyn_customerfeedbacksurvey_SyncErrors

Many-To-One Relationship: [syncerror msdyn_customerfeedbacksurvey_SyncErrors](syncerror.md#BKMK_msdyn_customerfeedbacksurvey_SyncErrors)

|Property|Value|
|---|---|
|ReferencingEntity|`syncerror`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_customerfeedbacksurvey_SyncErrors`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|



### See also

[Dataverse table/entity reference](/power-apps/developer/data-platform/reference/about-entity-reference)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   

