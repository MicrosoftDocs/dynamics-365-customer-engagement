---
title: "Relationship Analytics Config (msdyn_activityanalysisconfig) table/entity reference (Microsoft Dynamics 365)"
description: "Includes schema information and supported messages for the Relationship Analytics Config (msdyn_activityanalysisconfig) table/entity with Microsoft Dynamics 365."
ms.topic: generated-reference
author: JimDaly
ms.author: jdaly
search.audienceType: 
  - developer
---

# Relationship Analytics Config (msdyn_activityanalysisconfig) table/entity reference (Microsoft Dynamics 365)



## Messages

The following table lists the messages for the Relationship Analytics Config (msdyn_activityanalysisconfig) table.
Messages represent operations that can be performed on the table. They may also be events.

| Name <br />Is Event? |Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `Associate`<br />Event: True |[Associate records](/power-apps/developer/data-platform/webapi/associate-disassociate-entities-using-web-api) |[Associate records](/power-apps/developer/data-platform/org-service/entity-operations-associate-disassociate#use-the-associate-method-or-associaterequest)|
| `BulkRetain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.BulkRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Create`<br />Event: True |`POST` /msdyn_activityanalysisconfigs<br />See [Create](/powerapps/developer/data-platform/webapi/create-entity-web-api) |[Create records](/power-apps/developer/data-platform/org-service/entity-operations-create#basic-create)|
| `CreateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.CreateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.CreateMultipleRequest>|
| `Delete`<br />Event: True |`DELETE` /msdyn_activityanalysisconfigs(*msdyn_activityanalysisconfigid*)<br />See [Delete](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-delete) |[Delete records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-delete)|
| `Disassociate`<br />Event: True |[Disassociate records](/power-apps/developer/data-platform/webapi/associate-disassociate-entities-using-web-api) |[Disassociate records](/power-apps/developer/data-platform/org-service/entity-operations-associate-disassociate#use-the-disassociate-method-or-disassociaterequest)|
| `IsValidStateTransition`<br />Event: False |<xref:Microsoft.Dynamics.CRM.IsValidStateTransition?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.IsValidStateTransitionRequest>|
| `PurgeRetainedContent`<br />Event: True |<xref:Microsoft.Dynamics.CRM.PurgeRetainedContent?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Restore`<br />Event: True |<xref:Microsoft.Dynamics.CRM.Restore?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.Retain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retrieve`<br />Event: True |`GET` /msdyn_activityanalysisconfigs(*msdyn_activityanalysisconfigid*)<br />See [Retrieve](/powerapps/developer/data-platform/webapi/retrieve-entity-using-web-api) |[Retrieve records](/power-apps/developer/data-platform/org-service/entity-operations-retrieve)|
| `RetrieveMultiple`<br />Event: True |`GET` /msdyn_activityanalysisconfigs<br />See [Query data](/power-apps/developer/data-platform/webapi/query-data-web-api) |[Query data](/power-apps/developer/data-platform/org-service/entity-operations-query-data)|
| `RollbackRetain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RollbackRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `SetState`<br />Event: True |`PATCH` /msdyn_activityanalysisconfigs(*msdyn_activityanalysisconfigid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `statecode` and `statuscode` properties. |<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|
| `Update`<br />Event: True |`PATCH` /msdyn_activityanalysisconfigs(*msdyn_activityanalysisconfigid*)<br />See [Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) |[Update records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-update)|
| `UpdateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.UpdateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpdateMultipleRequest>|
| `Upsert`<br />Event: False |`PATCH` /msdyn_activityanalysisconfigs(*msdyn_activityanalysisconfigid*)<br />See [Upsert a table row](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#upsert-a-table-row) |<xref:Microsoft.Xrm.Sdk.Messages.UpsertRequest>|
| `UpsertMultiple`<br />Event: False |<xref:Microsoft.Dynamics.CRM.UpsertMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpsertMultipleRequest>|
| `ValidateRetentionConfig`<br />Event: True |<xref:Microsoft.Dynamics.CRM.ValidateRetentionConfig?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|

## Properties

The following table lists selected properties for the Relationship Analytics Config (msdyn_activityanalysisconfig) table.

|Property|Value|
| --- | --- |
| **DisplayName** | **Relationship Analytics Config** |
| **DisplayCollectionName** | **RelationshipAnalysisConfigs** |
| **SchemaName** | `msdyn_activityanalysisconfig` |
| **CollectionSchemaName** | `msdyn_activityanalysisconfigs` |
| **EntitySetName** | `msdyn_activityanalysisconfigs`|
| **LogicalName** | `msdyn_activityanalysisconfig` |
| **LogicalCollectionName** | `msdyn_activityanalysisconfigs` |
| **PrimaryIdAttribute** | `msdyn_activityanalysisconfigid` |
| **PrimaryNameAttribute** |`msdyn_name` |
| **TableType** | `Standard` |
| **OwnershipType** | `OrganizationOwned` |

## Writable columns/attributes

These columns/attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [msdyn_activityanalysisconfigId](#BKMK_msdyn_activityanalysisconfigId)
- [msdyn_communicationfrequency](#BKMK_msdyn_communicationfrequency)
- [msdyn_currentstatus](#BKMK_msdyn_currentstatus)
- [msdyn_datasource](#BKMK_msdyn_datasource)
- [msdyn_emailweight](#BKMK_msdyn_emailweight)
- [msdyn_exchangemarsstatus](#BKMK_msdyn_exchangemarsstatus)
- [msdyn_healthfeaturestatus](#BKMK_msdyn_healthfeaturestatus)
- [msdyn_ignoreexchangeoptincheck](#BKMK_msdyn_ignoreexchangeoptincheck)
- [msdyn_inmailweight](#BKMK_msdyn_inmailweight)
- [msdyn_isaprilpreviewenabled](#BKMK_msdyn_isaprilpreviewenabled)
- [msdyn_islinkedinenabled](#BKMK_msdyn_islinkedinenabled)
- [msdyn_isorgsettingenable](#BKMK_msdyn_isorgsettingenable)
- [msdyn_linkedinstatus](#BKMK_msdyn_linkedinstatus)
- [msdyn_meetingweight](#BKMK_msdyn_meetingweight)
- [msdyn_name](#BKMK_msdyn_name)
- [msdyn_oneclickactivityanalysisprovisioning](#BKMK_msdyn_oneclickactivityanalysisprovisioning)
- [msdyn_orgtypesuffix](#BKMK_msdyn_orgtypesuffix)
- [msdyn_otheractivites](#BKMK_msdyn_otheractivites)
- [msdyn_overflowentitylist](#BKMK_msdyn_overflowentitylist)
- [msdyn_phonecallweight](#BKMK_msdyn_phonecallweight)
- [msdyn_taskweight](#BKMK_msdyn_taskweight)
- [msdyn_timelineactivites](#BKMK_msdyn_timelineactivites)
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

### <a name="BKMK_msdyn_activityanalysisconfigId"></a> msdyn_activityanalysisconfigId

|Property|Value|
|---|---|
|Description|**Unique identifier for entity instances.**|
|DisplayName|**Relationship Analytics Config**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`msdyn_activityanalysisconfigid`|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|

### <a name="BKMK_msdyn_communicationfrequency"></a> msdyn_communicationfrequency

|Property|Value|
|---|---|
|Description||
|DisplayName|**Communication Frequency**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_communicationfrequency`|
|RequiredLevel|None|
|Type|Picklist|
|DefaultFormValue|-1|
|GlobalChoiceName|`msdyn_activityanalysisconfig_msdyn_communicationfrequency`|

#### msdyn_communicationfrequency Choices/Options

|Value|Label|
|---|---|
|1|**Once a day**|
|2|**Once every few days**|
|3|**Once a week**|
|4|**Once every couple of weeks**|
|5|**Once a month**|

### <a name="BKMK_msdyn_currentstatus"></a> msdyn_currentstatus

|Property|Value|
|---|---|
|Description||
|DisplayName|**Current Status**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_currentstatus`|
|RequiredLevel|None|
|Type|Picklist|
|DefaultFormValue|1|
|GlobalChoiceName|`msdyn_activityanalysisconfig_msdyn_currentstatus`|

#### msdyn_currentstatus Choices/Options

|Value|Label|
|---|---|
|1|**None**|
|2|**ActivationInProgress**|
|3|**ActivationCompleted**|
|4|**ActivationFailed**|
|5|**DeactivationInProgress**|
|6|**DeactivationCompleted**|
|7|**DeactivationFailed**|

### <a name="BKMK_msdyn_datasource"></a> msdyn_datasource

|Property|Value|
|---|---|
|Description||
|DisplayName|**Data Source**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_datasource`|
|RequiredLevel|None|
|Type|Picklist|
|DefaultFormValue|1|
|GlobalChoiceName|`msdyn_activityanalysisconfig_msdyn_datasource`|

#### msdyn_datasource Choices/Options

|Value|Label|
|---|---|
|1|**CRM**|
|2|**MARS**|
|3|**Both**|

### <a name="BKMK_msdyn_emailweight"></a> msdyn_emailweight

|Property|Value|
|---|---|
|Description|**Shows weight of email activity type.**|
|DisplayName|**Email Weight**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_emailweight`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|9|
|MinValue|3|

### <a name="BKMK_msdyn_exchangemarsstatus"></a> msdyn_exchangemarsstatus

|Property|Value|
|---|---|
|Description|**Status of Exchange-Mars Connector**|
|DisplayName|**Mars Exchange Status**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_exchangemarsstatus`|
|RequiredLevel|None|
|Type|Picklist|
|DefaultFormValue|1|
|GlobalChoiceName|`msdyn_activityanalysisconfig_msdyn_exchangemarsstatus`|

#### msdyn_exchangemarsstatus Choices/Options

|Value|Label|
|---|---|
|1|**None**|
|2|**ActivationInProgress**|
|3|**ActivationCompleted**|
|4|**ActivationFailed**|
|5|**ActivationFailedDueToOptin**|
|6|**DeactivationInProgress**|
|7|**DeactivationCompleted**|
|401|**ActivationFailedDueToOptin**|
|402|**ActivationFailedDueToOptinAccess**|

### <a name="BKMK_msdyn_healthfeaturestatus"></a> msdyn_healthfeaturestatus

|Property|Value|
|---|---|
|Description|**Health Feature Status**|
|DisplayName|**Health Feature Status**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_healthfeaturestatus`|
|RequiredLevel|None|
|Type|Picklist|
|DefaultFormValue|1|
|GlobalChoiceName|`msdyn_activityanalysisconfig_msdyn_healthfeaturestatus`|

#### msdyn_healthfeaturestatus Choices/Options

|Value|Label|
|---|---|
|1|**Enabled**|
|2|**Disabled**|

### <a name="BKMK_msdyn_ignoreexchangeoptincheck"></a> msdyn_ignoreexchangeoptincheck

|Property|Value|
|---|---|
|Description||
|DisplayName|**Ignore Exchange Optin Check**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_ignoreexchangeoptincheck`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`msdyn_activityanalysisconfig_msdyn_ignoreexchangeoptincheck`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_msdyn_inmailweight"></a> msdyn_inmailweight

|Property|Value|
|---|---|
|Description|**Shows weight of InMails activity type.**|
|DisplayName|**InMail Weight**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_inmailweight`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|9|
|MinValue|0|

### <a name="BKMK_msdyn_isaprilpreviewenabled"></a> msdyn_isaprilpreviewenabled

|Property|Value|
|---|---|
|Description||
|DisplayName|**Is April Preview Setting Enabled**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_isaprilpreviewenabled`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`msdyn_activityanalysisconfig_msdyn_isaprilpreviewenabled`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_msdyn_islinkedinenabled"></a> msdyn_islinkedinenabled

|Property|Value|
|---|---|
|Description||
|DisplayName|**Is LinkedIn Analytics Enabled**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_islinkedinenabled`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`msdyn_activityanalysisconfig_msdyn_islinkedinenabled`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_msdyn_isorgsettingenable"></a> msdyn_isorgsettingenable

|Property|Value|
|---|---|
|Description||
|DisplayName|**Is Org Setting Enable**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_isorgsettingenable`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`msdyn_activityanalysisconfig_msdyn_isorgsettingenable`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_msdyn_linkedinstatus"></a> msdyn_linkedinstatus

|Property|Value|
|---|---|
|Description|**Status of LinkedIn Analytics**|
|DisplayName|**Status of LinkedIn Analytics**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_linkedinstatus`|
|RequiredLevel|None|
|Type|Picklist|
|DefaultFormValue|1|
|GlobalChoiceName|`msdyn_activityanalysisconfig_msdyn_linkedinstatus`|

#### msdyn_linkedinstatus Choices/Options

|Value|Label|
|---|---|
|1|**None**|
|2|**ActivationInProgress**|
|3|**ActivationCompleted**|
|4|**ActivationFailed**|
|5|**DeactivationInProgress**|
|6|**DeactivationCompleted**|
|7|**DeactivationFailed**|
|8|**UpgradePending**|
|9|**UpgradeInProgress**|
|10|**UpgradeFailed**|
|11|**UpgradeSucceeded**|

### <a name="BKMK_msdyn_meetingweight"></a> msdyn_meetingweight

|Property|Value|
|---|---|
|Description|**Shows weight of meeting activity type.**|
|DisplayName|**Meeting Weight**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_meetingweight`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|9|
|MinValue|3|

### <a name="BKMK_msdyn_name"></a> msdyn_name

|Property|Value|
|---|---|
|Description|**Shows the name of the custom entity.**|
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

### <a name="BKMK_msdyn_oneclickactivityanalysisprovisioning"></a> msdyn_oneclickactivityanalysisprovisioning

|Property|Value|
|---|---|
|Description||
|DisplayName|**Is One Click Activity Analysis Provisioning Enabled**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_oneclickactivityanalysisprovisioning`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`msdyn_activityanalysisconfig_msdyn_oneclickactivityanalysisprovisioning`|
|DefaultValue|True|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_msdyn_orgtypesuffix"></a> msdyn_orgtypesuffix

|Property|Value|
|---|---|
|Description|**Organization Type Suffix Set By Connector**|
|DisplayName|**Organization Type Suffix**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_orgtypesuffix`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdyn_otheractivites"></a> msdyn_otheractivites

|Property|Value|
|---|---|
|Description|**Shows the weight of default activity type.**|
|DisplayName|**Other Activites**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_otheractivites`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdyn_overflowentitylist"></a> msdyn_overflowentitylist

|Property|Value|
|---|---|
|Description|**Shows the Contact, Opportunity, Lead, and Account entities which have exceeded the scale limit for Relationship Insights.**|
|DisplayName|**Scale Limit Exceeded**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_overflowentitylist`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdyn_phonecallweight"></a> msdyn_phonecallweight

|Property|Value|
|---|---|
|Description|**Shows the weight of phone call activity type.**|
|DisplayName|**Phonecall Weight**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_phonecallweight`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|9|
|MinValue|3|

### <a name="BKMK_msdyn_taskweight"></a> msdyn_taskweight

|Property|Value|
|---|---|
|Description|**Shows the weight of task activity type.**|
|DisplayName|**Task Weight**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_taskweight`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|9|
|MinValue|3|

### <a name="BKMK_msdyn_timelineactivites"></a> msdyn_timelineactivites

|Property|Value|
|---|---|
|Description|**Shows activities to include on the relationship trend timeline.**|
|DisplayName|**Time Line Activites**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_timelineactivites`|
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
|Description|**Shows the date and time the record was migrated.**|
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
|Description|**Status of the Relationship Analytics Config**|
|DisplayName|**Status**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statecode`|
|RequiredLevel|SystemRequired|
|Type|State|
|DefaultFormValue||
|GlobalChoiceName|`msdyn_activityanalysisconfig_statecode`|

#### statecode Choices/Options

|Value|Details|
|---|---|
|0|Label: **Active**<br />DefaultStatus: 1<br />InvariantName: `Active`|
|1|Label: **Inactive**<br />DefaultStatus: 2<br />InvariantName: `Inactive`|

### <a name="BKMK_statuscode"></a> statuscode

|Property|Value|
|---|---|
|Description|**Reason for the status of the Relationship Analytics Config**|
|DisplayName|**Status Reason**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statuscode`|
|RequiredLevel|None|
|Type|Status|
|DefaultFormValue||
|GlobalChoiceName|`msdyn_activityanalysisconfig_statuscode`|

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
|Description|**Unique identifier for the organization.**|
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

- [lk_msdyn_activityanalysisconfig_createdby](#BKMK_lk_msdyn_activityanalysisconfig_createdby)
- [lk_msdyn_activityanalysisconfig_createdonbehalfby](#BKMK_lk_msdyn_activityanalysisconfig_createdonbehalfby)
- [lk_msdyn_activityanalysisconfig_modifiedby](#BKMK_lk_msdyn_activityanalysisconfig_modifiedby)
- [lk_msdyn_activityanalysisconfig_modifiedonbehalfby](#BKMK_lk_msdyn_activityanalysisconfig_modifiedonbehalfby)
- [organization_msdyn_activityanalysisconfig](#BKMK_organization_msdyn_activityanalysisconfig)

### <a name="BKMK_lk_msdyn_activityanalysisconfig_createdby"></a> lk_msdyn_activityanalysisconfig_createdby

One-To-Many Relationship: [systemuser lk_msdyn_activityanalysisconfig_createdby](systemuser.md#BKMK_lk_msdyn_activityanalysisconfig_createdby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdby`|
|ReferencingEntityNavigationPropertyName|`createdby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_activityanalysisconfig_createdonbehalfby"></a> lk_msdyn_activityanalysisconfig_createdonbehalfby

One-To-Many Relationship: [systemuser lk_msdyn_activityanalysisconfig_createdonbehalfby](systemuser.md#BKMK_lk_msdyn_activityanalysisconfig_createdonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdonbehalfby`|
|ReferencingEntityNavigationPropertyName|`createdonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_activityanalysisconfig_modifiedby"></a> lk_msdyn_activityanalysisconfig_modifiedby

One-To-Many Relationship: [systemuser lk_msdyn_activityanalysisconfig_modifiedby](systemuser.md#BKMK_lk_msdyn_activityanalysisconfig_modifiedby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedby`|
|ReferencingEntityNavigationPropertyName|`modifiedby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_activityanalysisconfig_modifiedonbehalfby"></a> lk_msdyn_activityanalysisconfig_modifiedonbehalfby

One-To-Many Relationship: [systemuser lk_msdyn_activityanalysisconfig_modifiedonbehalfby](systemuser.md#BKMK_lk_msdyn_activityanalysisconfig_modifiedonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedonbehalfby`|
|ReferencingEntityNavigationPropertyName|`modifiedonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_organization_msdyn_activityanalysisconfig"></a> organization_msdyn_activityanalysisconfig

One-To-Many Relationship: [organization organization_msdyn_activityanalysisconfig](organization.md#BKMK_organization_msdyn_activityanalysisconfig)

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

- [msdyn_activityanalysisconfig_AsyncOperations](#BKMK_msdyn_activityanalysisconfig_AsyncOperations)
- [msdyn_activityanalysisconfig_BulkDeleteFailures](#BKMK_msdyn_activityanalysisconfig_BulkDeleteFailures)
- [msdyn_activityanalysisconfig_MailboxTrackingFolders](#BKMK_msdyn_activityanalysisconfig_MailboxTrackingFolders)
- [msdyn_activityanalysisconfig_PrincipalObjectAttributeAccesses](#BKMK_msdyn_activityanalysisconfig_PrincipalObjectAttributeAccesses)
- [msdyn_activityanalysisconfig_ProcessSession](#BKMK_msdyn_activityanalysisconfig_ProcessSession)
- [msdyn_activityanalysisconfig_SyncErrors](#BKMK_msdyn_activityanalysisconfig_SyncErrors)

### <a name="BKMK_msdyn_activityanalysisconfig_AsyncOperations"></a> msdyn_activityanalysisconfig_AsyncOperations

Many-To-One Relationship: [asyncoperation msdyn_activityanalysisconfig_AsyncOperations](asyncoperation.md#BKMK_msdyn_activityanalysisconfig_AsyncOperations)

|Property|Value|
|---|---|
|ReferencingEntity|`asyncoperation`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_activityanalysisconfig_AsyncOperations`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_activityanalysisconfig_BulkDeleteFailures"></a> msdyn_activityanalysisconfig_BulkDeleteFailures

Many-To-One Relationship: [bulkdeletefailure msdyn_activityanalysisconfig_BulkDeleteFailures](bulkdeletefailure.md#BKMK_msdyn_activityanalysisconfig_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencingEntity|`bulkdeletefailure`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_activityanalysisconfig_BulkDeleteFailures`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_activityanalysisconfig_MailboxTrackingFolders"></a> msdyn_activityanalysisconfig_MailboxTrackingFolders

Many-To-One Relationship: [mailboxtrackingfolder msdyn_activityanalysisconfig_MailboxTrackingFolders](mailboxtrackingfolder.md#BKMK_msdyn_activityanalysisconfig_MailboxTrackingFolders)

|Property|Value|
|---|---|
|ReferencingEntity|`mailboxtrackingfolder`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_activityanalysisconfig_MailboxTrackingFolders`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_activityanalysisconfig_PrincipalObjectAttributeAccesses"></a> msdyn_activityanalysisconfig_PrincipalObjectAttributeAccesses

Many-To-One Relationship: [principalobjectattributeaccess msdyn_activityanalysisconfig_PrincipalObjectAttributeAccesses](principalobjectattributeaccess.md#BKMK_msdyn_activityanalysisconfig_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencingEntity|`principalobjectattributeaccess`|
|ReferencingAttribute|`objectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_activityanalysisconfig_PrincipalObjectAttributeAccesses`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_activityanalysisconfig_ProcessSession"></a> msdyn_activityanalysisconfig_ProcessSession

Many-To-One Relationship: [processsession msdyn_activityanalysisconfig_ProcessSession](processsession.md#BKMK_msdyn_activityanalysisconfig_ProcessSession)

|Property|Value|
|---|---|
|ReferencingEntity|`processsession`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_activityanalysisconfig_ProcessSession`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_activityanalysisconfig_SyncErrors"></a> msdyn_activityanalysisconfig_SyncErrors

Many-To-One Relationship: [syncerror msdyn_activityanalysisconfig_SyncErrors](syncerror.md#BKMK_msdyn_activityanalysisconfig_SyncErrors)

|Property|Value|
|---|---|
|ReferencingEntity|`syncerror`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_activityanalysisconfig_SyncErrors`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|



### See also

[Dataverse table/entity reference](/power-apps/developer/data-platform/reference/about-entity-reference)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   

