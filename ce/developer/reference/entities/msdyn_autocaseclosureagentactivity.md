---
title: "Case Management Agent for case closure Activity (msdyn_autocaseclosureagentactivity) table/entity reference (Microsoft Dynamics 365)"
description: "Includes schema information and supported messages for the Case Management Agent for case closure Activity (msdyn_autocaseclosureagentactivity) table/entity with Microsoft Dynamics 365."
ms.topic: generated-reference
author: JimDaly
ms.author: jdaly
search.audienceType: 
  - developer
---

# Case Management Agent for case closure Activity (msdyn_autocaseclosureagentactivity) table/entity reference (Microsoft Dynamics 365)



## Messages

The following table lists the messages for the Case Management Agent for case closure Activity (msdyn_autocaseclosureagentactivity) table.
Messages represent operations that can be performed on the table. They may also be events.

| Name <br />Is Event? |Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `Associate`<br />Event: True |[Associate records](/power-apps/developer/data-platform/webapi/associate-disassociate-entities-using-web-api) |[Associate records](/power-apps/developer/data-platform/org-service/entity-operations-associate-disassociate#use-the-associate-method-or-associaterequest)|
| `BulkRetain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.BulkRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Create`<br />Event: True |`POST` /msdyn_autocaseclosureagentactivities<br />See [Create](/powerapps/developer/data-platform/webapi/create-entity-web-api) |[Create records](/power-apps/developer/data-platform/org-service/entity-operations-create#basic-create)|
| `CreateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.CreateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.CreateMultipleRequest>|
| `Delete`<br />Event: True |`DELETE` /msdyn_autocaseclosureagentactivities(*msdyn_autocaseclosureagentactivityid*)<br />See [Delete](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-delete) |[Delete records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-delete)|
| `Disassociate`<br />Event: True |[Disassociate records](/power-apps/developer/data-platform/webapi/associate-disassociate-entities-using-web-api) |[Disassociate records](/power-apps/developer/data-platform/org-service/entity-operations-associate-disassociate#use-the-disassociate-method-or-disassociaterequest)|
| `IsValidStateTransition`<br />Event: False |<xref:Microsoft.Dynamics.CRM.IsValidStateTransition?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.IsValidStateTransitionRequest>|
| `PurgeRetainedContent`<br />Event: True |<xref:Microsoft.Dynamics.CRM.PurgeRetainedContent?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Restore`<br />Event: True |<xref:Microsoft.Dynamics.CRM.Restore?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.Retain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retrieve`<br />Event: True |`GET` /msdyn_autocaseclosureagentactivities(*msdyn_autocaseclosureagentactivityid*)<br />See [Retrieve](/powerapps/developer/data-platform/webapi/retrieve-entity-using-web-api) |[Retrieve records](/power-apps/developer/data-platform/org-service/entity-operations-retrieve)|
| `RetrieveMultiple`<br />Event: True |`GET` /msdyn_autocaseclosureagentactivities<br />See [Query data](/power-apps/developer/data-platform/webapi/query-data-web-api) |[Query data](/power-apps/developer/data-platform/org-service/entity-operations-query-data)|
| `RollbackRetain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RollbackRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `SetState`<br />Event: True |`PATCH` /msdyn_autocaseclosureagentactivities(*msdyn_autocaseclosureagentactivityid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `statecode` and `statuscode` properties. |<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|
| `Update`<br />Event: True |`PATCH` /msdyn_autocaseclosureagentactivities(*msdyn_autocaseclosureagentactivityid*)<br />See [Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) |[Update records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-update)|
| `UpdateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.UpdateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpdateMultipleRequest>|
| `Upsert`<br />Event: False |`PATCH` /msdyn_autocaseclosureagentactivities(*msdyn_autocaseclosureagentactivityid*)<br />See [Upsert a table row](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#upsert-a-table-row) |<xref:Microsoft.Xrm.Sdk.Messages.UpsertRequest>|
| `UpsertMultiple`<br />Event: False |<xref:Microsoft.Dynamics.CRM.UpsertMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpsertMultipleRequest>|
| `ValidateRetentionConfig`<br />Event: True |<xref:Microsoft.Dynamics.CRM.ValidateRetentionConfig?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|

## Properties

The following table lists selected properties for the Case Management Agent for case closure Activity (msdyn_autocaseclosureagentactivity) table.

|Property|Value|
| --- | --- |
| **DisplayName** | **Case Management Agent for case closure Activity** |
| **DisplayCollectionName** | **Case Management Agent for case closure Activities** |
| **SchemaName** | `msdyn_autocaseclosureagentactivity` |
| **CollectionSchemaName** | `msdyn_autocaseclosureagentactivities` |
| **EntitySetName** | `msdyn_autocaseclosureagentactivities`|
| **LogicalName** | `msdyn_autocaseclosureagentactivity` |
| **LogicalCollectionName** | `msdyn_autocaseclosureagentactivities` |
| **PrimaryIdAttribute** | `msdyn_autocaseclosureagentactivityid` |
| **PrimaryNameAttribute** |`msdyn_name` |
| **TableType** | `Standard` |
| **OwnershipType** | `OrganizationOwned` |

## Writable columns/attributes

These columns/attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [msdyn_activityid](#BKMK_msdyn_activityid)
- [msdyn_activitytype](#BKMK_msdyn_activitytype)
- [msdyn_autocaseclosureagentactivityId](#BKMK_msdyn_autocaseclosureagentactivityId)
- [msdyn_autocaseclosureagentgeneratedemailid](#BKMK_msdyn_autocaseclosureagentgeneratedemailid)
- [msdyn_autocaseclosureagentmonitoringid](#BKMK_msdyn_autocaseclosureagentmonitoringid)
- [msdyn_casefollowupandclosureconfigurationid](#BKMK_msdyn_casefollowupandclosureconfigurationid)
- [msdyn_followupcount](#BKMK_msdyn_followupcount)
- [msdyn_incidentid](#BKMK_msdyn_incidentid)
- [msdyn_isfullautonomous](#BKMK_msdyn_isfullautonomous)
- [msdyn_name](#BKMK_msdyn_name)
- [msdyn_regarding](#BKMK_msdyn_regarding)
- [msdyn_regardingIdType](#BKMK_msdyn_regardingIdType)
- [msdyn_retrycount](#BKMK_msdyn_retrycount)
- [msdyn_triggertrackingid](#BKMK_msdyn_triggertrackingid)
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

### <a name="BKMK_msdyn_activityid"></a> msdyn_activityid

|Property|Value|
|---|---|
|Description|**Email that this relates to**|
|DisplayName|**Activity Id**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_activityid`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|email|

### <a name="BKMK_msdyn_activitytype"></a> msdyn_activitytype

|Property|Value|
|---|---|
|Description||
|DisplayName|**Activity Type**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_activitytype`|
|RequiredLevel|ApplicationRequired|
|Type|Picklist|
|DefaultFormValue|-1|
|GlobalChoiceName|`msdyn_autocaseclosureagentactivity_msdyn_activitytype`|

#### msdyn_activitytype Choices/Options

|Value|Label|
|---|---|
|419550000|**GenerateFollowupEmail**|
|419550001|**AnalyzeCustomerResponse**|

### <a name="BKMK_msdyn_autocaseclosureagentactivityId"></a> msdyn_autocaseclosureagentactivityId

|Property|Value|
|---|---|
|Description|**Unique identifier for entity instances**|
|DisplayName|**Case Management Agent for case closure Activity**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`msdyn_autocaseclosureagentactivityid`|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|

### <a name="BKMK_msdyn_autocaseclosureagentgeneratedemailid"></a> msdyn_autocaseclosureagentgeneratedemailid

|Property|Value|
|---|---|
|Description|**Id of Case Management Agent for case closure generated email**|
|DisplayName|**Id of Case Management Agent for case closure generated email**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_autocaseclosureagentgeneratedemailid`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|email|

### <a name="BKMK_msdyn_autocaseclosureagentmonitoringid"></a> msdyn_autocaseclosureagentmonitoringid

|Property|Value|
|---|---|
|Description|**Id of Case Management Agent for case closure monitoring**|
|DisplayName|**Id of Case Management Agent for case closure monitoring**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_autocaseclosureagentmonitoringid`|
|RequiredLevel|ApplicationRequired|
|Type|Lookup|
|Targets|msdyn_autocaseclosureagentmonitoring|

### <a name="BKMK_msdyn_casefollowupandclosureconfigurationid"></a> msdyn_casefollowupandclosureconfigurationid

|Property|Value|
|---|---|
|Description||
|DisplayName|**Case Follow-up and Closure Configuration Id**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_casefollowupandclosureconfigurationid`|
|RequiredLevel|ApplicationRequired|
|Type|Lookup|
|Targets|msdyn_casefollowupandclosureconfiguration|

### <a name="BKMK_msdyn_followupcount"></a> msdyn_followupcount

|Property|Value|
|---|---|
|Description||
|DisplayName|**Followup Count**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_followupcount`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|100|
|MinValue|0|

### <a name="BKMK_msdyn_incidentid"></a> msdyn_incidentid

|Property|Value|
|---|---|
|Description||
|DisplayName|**Incident Id**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_incidentid`|
|RequiredLevel|ApplicationRequired|
|Type|Lookup|
|Targets|incident|

### <a name="BKMK_msdyn_isfullautonomous"></a> msdyn_isfullautonomous

|Property|Value|
|---|---|
|Description|**Whether the record is in full autonomous mode or semi autonomous mode**|
|DisplayName|**Is Full Autonomous**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_isfullautonomous`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`msdyn_autocaseclosureagentactivity_msdyn_isfullautonomous`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_msdyn_name"></a> msdyn_name

|Property|Value|
|---|---|
|Description|**The name of the custom entity.**|
|DisplayName|**Name**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_name`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdyn_regarding"></a> msdyn_regarding

|Property|Value|
|---|---|
|Description|**The record this activity is for**|
|DisplayName|**Regarding**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_regarding`|
|RequiredLevel|SystemRequired|
|Type|Lookup|
|Targets|incident|

### <a name="BKMK_msdyn_regardingIdType"></a> msdyn_regardingIdType

|Property|Value|
|---|---|
|Description||
|DisplayName||
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`msdyn_regardingidtype`|
|RequiredLevel|None|
|Type|EntityName|

### <a name="BKMK_msdyn_retrycount"></a> msdyn_retrycount

|Property|Value|
|---|---|
|Description||
|DisplayName|**Retry Count**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_retrycount`|
|RequiredLevel|ApplicationRequired|
|Type|Integer|
|MaxValue|100|
|MinValue|1|

### <a name="BKMK_msdyn_triggertrackingid"></a> msdyn_triggertrackingid

|Property|Value|
|---|---|
|Description|**Id to track the each case followup and closure agent trigger status**|
|DisplayName|**Trigger Tracking Id**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_triggertrackingid`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

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
|Description|**Status of the Case Management Agent for case closure Activity**|
|DisplayName|**Status**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statecode`|
|RequiredLevel|SystemRequired|
|Type|State|
|DefaultFormValue||
|GlobalChoiceName|`msdyn_autocaseclosureagentactivity_statecode`|

#### statecode Choices/Options

|Value|Details|
|---|---|
|0|Label: **Active**<br />DefaultStatus: 1<br />InvariantName: `Active`|
|1|Label: **Inactive**<br />DefaultStatus: 2<br />InvariantName: `Inactive`|

### <a name="BKMK_statuscode"></a> statuscode

|Property|Value|
|---|---|
|Description|**Reason for the status of the Case Management Agent for case closure Activity**|
|DisplayName|**Status Reason**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statuscode`|
|RequiredLevel|None|
|Type|Status|
|DefaultFormValue||
|GlobalChoiceName|`msdyn_autocaseclosureagentactivity_statuscode`|

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

- [lk_msdyn_autocaseclosureagentactivity_createdby](#BKMK_lk_msdyn_autocaseclosureagentactivity_createdby)
- [lk_msdyn_autocaseclosureagentactivity_createdonbehalfby](#BKMK_lk_msdyn_autocaseclosureagentactivity_createdonbehalfby)
- [lk_msdyn_autocaseclosureagentactivity_modifiedby](#BKMK_lk_msdyn_autocaseclosureagentactivity_modifiedby)
- [lk_msdyn_autocaseclosureagentactivity_modifiedonbehalfby](#BKMK_lk_msdyn_autocaseclosureagentactivity_modifiedonbehalfby)
- [msdyn_autocaseclosureagentactivity_msdyn_autocaseclosureagentmonitoringid_monitoringid](#BKMK_msdyn_autocaseclosureagentactivity_msdyn_autocaseclosureagentmonitoringid_monitoringid)
- [msdyn_autocaseclosureagentactivity_msdyn_casefollowupandclosureconfigurationid_configurationid](#BKMK_msdyn_autocaseclosureagentactivity_msdyn_casefollowupandclosureconfigurationid_configurationid)
- [msdyn_autocaseclosureagentactivity_regarding_incident](#BKMK_msdyn_autocaseclosureagentactivity_regarding_incident)
- [msdyn_email_msdyn_autocaseclosureagentactivity_activityid](#BKMK_msdyn_email_msdyn_autocaseclosureagentactivity_activityid)
- [msdyn_email_msdyn_autocaseclosureagentactivity_autocaseclosureagentgeneratedemailid](#BKMK_msdyn_email_msdyn_autocaseclosureagentactivity_autocaseclosureagentgeneratedemailid)
- [msdyn_incident_msdyn_autocaseclosureagentactivity_incidentid](#BKMK_msdyn_incident_msdyn_autocaseclosureagentactivity_incidentid)
- [organization_msdyn_autocaseclosureagentactivity](#BKMK_organization_msdyn_autocaseclosureagentactivity)

### <a name="BKMK_lk_msdyn_autocaseclosureagentactivity_createdby"></a> lk_msdyn_autocaseclosureagentactivity_createdby

One-To-Many Relationship: [systemuser lk_msdyn_autocaseclosureagentactivity_createdby](systemuser.md#BKMK_lk_msdyn_autocaseclosureagentactivity_createdby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdby`|
|ReferencingEntityNavigationPropertyName|`createdby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_autocaseclosureagentactivity_createdonbehalfby"></a> lk_msdyn_autocaseclosureagentactivity_createdonbehalfby

One-To-Many Relationship: [systemuser lk_msdyn_autocaseclosureagentactivity_createdonbehalfby](systemuser.md#BKMK_lk_msdyn_autocaseclosureagentactivity_createdonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdonbehalfby`|
|ReferencingEntityNavigationPropertyName|`createdonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_autocaseclosureagentactivity_modifiedby"></a> lk_msdyn_autocaseclosureagentactivity_modifiedby

One-To-Many Relationship: [systemuser lk_msdyn_autocaseclosureagentactivity_modifiedby](systemuser.md#BKMK_lk_msdyn_autocaseclosureagentactivity_modifiedby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedby`|
|ReferencingEntityNavigationPropertyName|`modifiedby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_autocaseclosureagentactivity_modifiedonbehalfby"></a> lk_msdyn_autocaseclosureagentactivity_modifiedonbehalfby

One-To-Many Relationship: [systemuser lk_msdyn_autocaseclosureagentactivity_modifiedonbehalfby](systemuser.md#BKMK_lk_msdyn_autocaseclosureagentactivity_modifiedonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedonbehalfby`|
|ReferencingEntityNavigationPropertyName|`modifiedonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_autocaseclosureagentactivity_msdyn_autocaseclosureagentmonitoringid_monitoringid"></a> msdyn_autocaseclosureagentactivity_msdyn_autocaseclosureagentmonitoringid_monitoringid

One-To-Many Relationship: [msdyn_autocaseclosureagentmonitoring msdyn_autocaseclosureagentactivity_msdyn_autocaseclosureagentmonitoringid_monitoringid](msdyn_autocaseclosureagentmonitoring.md#BKMK_msdyn_autocaseclosureagentactivity_msdyn_autocaseclosureagentmonitoringid_monitoringid)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_autocaseclosureagentmonitoring`|
|ReferencedAttribute|`msdyn_autocaseclosureagentmonitoringid`|
|ReferencingAttribute|`msdyn_autocaseclosureagentmonitoringid`|
|ReferencingEntityNavigationPropertyName|`msdyn_autocaseclosureagentmonitoringid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `RemoveLink`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_autocaseclosureagentactivity_msdyn_casefollowupandclosureconfigurationid_configurationid"></a> msdyn_autocaseclosureagentactivity_msdyn_casefollowupandclosureconfigurationid_configurationid

One-To-Many Relationship: [msdyn_casefollowupandclosureconfiguration msdyn_autocaseclosureagentactivity_msdyn_casefollowupandclosureconfigurationid_configurationid](msdyn_casefollowupandclosureconfiguration.md#BKMK_msdyn_autocaseclosureagentactivity_msdyn_casefollowupandclosureconfigurationid_configurationid)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_casefollowupandclosureconfiguration`|
|ReferencedAttribute|`msdyn_casefollowupandclosureconfigurationid`|
|ReferencingAttribute|`msdyn_casefollowupandclosureconfigurationid`|
|ReferencingEntityNavigationPropertyName|`msdyn_casefollowupandclosureconfigurationid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `RemoveLink`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_autocaseclosureagentactivity_regarding_incident"></a> msdyn_autocaseclosureagentactivity_regarding_incident

One-To-Many Relationship: [incident msdyn_autocaseclosureagentactivity_regarding_incident](incident.md#BKMK_msdyn_autocaseclosureagentactivity_regarding_incident)

|Property|Value|
|---|---|
|ReferencedEntity|`incident`|
|ReferencedAttribute|`incidentid`|
|ReferencingAttribute|`msdyn_regarding`|
|ReferencingEntityNavigationPropertyName|`msdyn_regarding`|
|IsHierarchical||
|CascadeConfiguration|Archive: `Cascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_email_msdyn_autocaseclosureagentactivity_activityid"></a> msdyn_email_msdyn_autocaseclosureagentactivity_activityid

One-To-Many Relationship: [email msdyn_email_msdyn_autocaseclosureagentactivity_activityid](email.md#BKMK_msdyn_email_msdyn_autocaseclosureagentactivity_activityid)

|Property|Value|
|---|---|
|ReferencedEntity|`email`|
|ReferencedAttribute|`activityid`|
|ReferencingAttribute|`msdyn_activityid`|
|ReferencingEntityNavigationPropertyName|`msdyn_activityid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `RemoveLink`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_email_msdyn_autocaseclosureagentactivity_autocaseclosureagentgeneratedemailid"></a> msdyn_email_msdyn_autocaseclosureagentactivity_autocaseclosureagentgeneratedemailid

One-To-Many Relationship: [email msdyn_email_msdyn_autocaseclosureagentactivity_autocaseclosureagentgeneratedemailid](email.md#BKMK_msdyn_email_msdyn_autocaseclosureagentactivity_autocaseclosureagentgeneratedemailid)

|Property|Value|
|---|---|
|ReferencedEntity|`email`|
|ReferencedAttribute|`activityid`|
|ReferencingAttribute|`msdyn_autocaseclosureagentgeneratedemailid`|
|ReferencingEntityNavigationPropertyName|`msdyn_autocaseclosureagentgeneratedemailid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `RemoveLink`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_incident_msdyn_autocaseclosureagentactivity_incidentid"></a> msdyn_incident_msdyn_autocaseclosureagentactivity_incidentid

One-To-Many Relationship: [incident msdyn_incident_msdyn_autocaseclosureagentactivity_incidentid](incident.md#BKMK_msdyn_incident_msdyn_autocaseclosureagentactivity_incidentid)

|Property|Value|
|---|---|
|ReferencedEntity|`incident`|
|ReferencedAttribute|`incidentid`|
|ReferencingAttribute|`msdyn_incidentid`|
|ReferencingEntityNavigationPropertyName|`msdyn_incidentid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `RemoveLink`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_organization_msdyn_autocaseclosureagentactivity"></a> organization_msdyn_autocaseclosureagentactivity

One-To-Many Relationship: [organization organization_msdyn_autocaseclosureagentactivity](organization.md#BKMK_organization_msdyn_autocaseclosureagentactivity)

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

- [msdyn_autocaseclosureagentactivity_AsyncOperations](#BKMK_msdyn_autocaseclosureagentactivity_AsyncOperations)
- [msdyn_autocaseclosureagentactivity_BulkDeleteFailures](#BKMK_msdyn_autocaseclosureagentactivity_BulkDeleteFailures)
- [msdyn_autocaseclosureagentactivity_MailboxTrackingFolders](#BKMK_msdyn_autocaseclosureagentactivity_MailboxTrackingFolders)
- [msdyn_autocaseclosureagentactivity_PrincipalObjectAttributeAccesses](#BKMK_msdyn_autocaseclosureagentactivity_PrincipalObjectAttributeAccesses)
- [msdyn_autocaseclosureagentactivity_ProcessSession](#BKMK_msdyn_autocaseclosureagentactivity_ProcessSession)
- [msdyn_autocaseclosureagentactivity_SyncErrors](#BKMK_msdyn_autocaseclosureagentactivity_SyncErrors)

### <a name="BKMK_msdyn_autocaseclosureagentactivity_AsyncOperations"></a> msdyn_autocaseclosureagentactivity_AsyncOperations

Many-To-One Relationship: [asyncoperation msdyn_autocaseclosureagentactivity_AsyncOperations](asyncoperation.md#BKMK_msdyn_autocaseclosureagentactivity_AsyncOperations)

|Property|Value|
|---|---|
|ReferencingEntity|`asyncoperation`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_autocaseclosureagentactivity_AsyncOperations`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_autocaseclosureagentactivity_BulkDeleteFailures"></a> msdyn_autocaseclosureagentactivity_BulkDeleteFailures

Many-To-One Relationship: [bulkdeletefailure msdyn_autocaseclosureagentactivity_BulkDeleteFailures](bulkdeletefailure.md#BKMK_msdyn_autocaseclosureagentactivity_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencingEntity|`bulkdeletefailure`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_autocaseclosureagentactivity_BulkDeleteFailures`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_autocaseclosureagentactivity_MailboxTrackingFolders"></a> msdyn_autocaseclosureagentactivity_MailboxTrackingFolders

Many-To-One Relationship: [mailboxtrackingfolder msdyn_autocaseclosureagentactivity_MailboxTrackingFolders](mailboxtrackingfolder.md#BKMK_msdyn_autocaseclosureagentactivity_MailboxTrackingFolders)

|Property|Value|
|---|---|
|ReferencingEntity|`mailboxtrackingfolder`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_autocaseclosureagentactivity_MailboxTrackingFolders`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_autocaseclosureagentactivity_PrincipalObjectAttributeAccesses"></a> msdyn_autocaseclosureagentactivity_PrincipalObjectAttributeAccesses

Many-To-One Relationship: [principalobjectattributeaccess msdyn_autocaseclosureagentactivity_PrincipalObjectAttributeAccesses](principalobjectattributeaccess.md#BKMK_msdyn_autocaseclosureagentactivity_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencingEntity|`principalobjectattributeaccess`|
|ReferencingAttribute|`objectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_autocaseclosureagentactivity_PrincipalObjectAttributeAccesses`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_autocaseclosureagentactivity_ProcessSession"></a> msdyn_autocaseclosureagentactivity_ProcessSession

Many-To-One Relationship: [processsession msdyn_autocaseclosureagentactivity_ProcessSession](processsession.md#BKMK_msdyn_autocaseclosureagentactivity_ProcessSession)

|Property|Value|
|---|---|
|ReferencingEntity|`processsession`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_autocaseclosureagentactivity_ProcessSession`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_autocaseclosureagentactivity_SyncErrors"></a> msdyn_autocaseclosureagentactivity_SyncErrors

Many-To-One Relationship: [syncerror msdyn_autocaseclosureagentactivity_SyncErrors](syncerror.md#BKMK_msdyn_autocaseclosureagentactivity_SyncErrors)

|Property|Value|
|---|---|
|ReferencingEntity|`syncerror`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_autocaseclosureagentactivity_SyncErrors`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|



### See also

[Dataverse table/entity reference](/power-apps/developer/data-platform/reference/about-entity-reference)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   

