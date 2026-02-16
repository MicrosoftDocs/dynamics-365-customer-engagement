---
title: "SCA Engage Agent Result (msdyn_dcaengageagentresult) table/entity reference (Microsoft Dynamics 365)"
description: "Includes schema information and supported messages for the SCA Engage Agent Result (msdyn_dcaengageagentresult) table/entity with Microsoft Dynamics 365."
ms.topic: generated-reference
author: JimDaly
ms.author: jdaly
search.audienceType: 
  - developer
---

# SCA Engage Agent Result (msdyn_dcaengageagentresult) table/entity reference (Microsoft Dynamics 365)

This table displays the outcome of interactions handled by the Engage Agent within the Sales Close Agent - Engage process.

## Messages

The following table lists the messages for the SCA Engage Agent Result (msdyn_dcaengageagentresult) table.
Messages represent operations that can be performed on the table. They may also be events.

| Name <br />Is Event? |Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `Assign`<br />Event: True |`PATCH` /msdyn_dcaengageagentresults(*msdyn_dcaengageagentresultid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `ownerid` property. |<xref:Microsoft.Crm.Sdk.Messages.AssignRequest>|
| `Associate`<br />Event: True |[Associate records](/power-apps/developer/data-platform/webapi/associate-disassociate-entities-using-web-api) |[Associate records](/power-apps/developer/data-platform/org-service/entity-operations-associate-disassociate#use-the-associate-method-or-associaterequest)|
| `BulkRetain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.BulkRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Create`<br />Event: True |`POST` /msdyn_dcaengageagentresults<br />See [Create](/powerapps/developer/data-platform/webapi/create-entity-web-api) |[Create records](/power-apps/developer/data-platform/org-service/entity-operations-create#basic-create)|
| `CreateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.CreateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.CreateMultipleRequest>|
| `Delete`<br />Event: True |`DELETE` /msdyn_dcaengageagentresults(*msdyn_dcaengageagentresultid*)<br />See [Delete](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-delete) |[Delete records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-delete)|
| `Disassociate`<br />Event: True |[Disassociate records](/power-apps/developer/data-platform/webapi/associate-disassociate-entities-using-web-api) |[Disassociate records](/power-apps/developer/data-platform/org-service/entity-operations-associate-disassociate#use-the-disassociate-method-or-disassociaterequest)|
| `GrantAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.GrantAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.GrantAccessRequest>|
| `IsValidStateTransition`<br />Event: False |<xref:Microsoft.Dynamics.CRM.IsValidStateTransition?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.IsValidStateTransitionRequest>|
| `ModifyAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.ModifyAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.ModifyAccessRequest>|
| `PurgeRetainedContent`<br />Event: True |<xref:Microsoft.Dynamics.CRM.PurgeRetainedContent?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Restore`<br />Event: True |<xref:Microsoft.Dynamics.CRM.Restore?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.Retain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retrieve`<br />Event: True |`GET` /msdyn_dcaengageagentresults(*msdyn_dcaengageagentresultid*)<br />See [Retrieve](/powerapps/developer/data-platform/webapi/retrieve-entity-using-web-api) |[Retrieve records](/power-apps/developer/data-platform/org-service/entity-operations-retrieve)|
| `RetrieveMultiple`<br />Event: True |`GET` /msdyn_dcaengageagentresults<br />See [Query data](/power-apps/developer/data-platform/webapi/query-data-web-api) |[Query data](/power-apps/developer/data-platform/org-service/entity-operations-query-data)|
| `RetrievePrincipalAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RetrievePrincipalAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RetrievePrincipalAccessRequest>|
| `RetrieveSharedPrincipalsAndAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RetrieveSharedPrincipalsAndAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RetrieveSharedPrincipalsAndAccessRequest>|
| `RevokeAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RevokeAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RevokeAccessRequest>|
| `RollbackRetain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RollbackRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `SetState`<br />Event: True |`PATCH` /msdyn_dcaengageagentresults(*msdyn_dcaengageagentresultid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `statecode` and `statuscode` properties. |<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|
| `Update`<br />Event: True |`PATCH` /msdyn_dcaengageagentresults(*msdyn_dcaengageagentresultid*)<br />See [Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) |[Update records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-update)|
| `UpdateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.UpdateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpdateMultipleRequest>|
| `Upsert`<br />Event: False |`PATCH` /msdyn_dcaengageagentresults(*msdyn_dcaengageagentresultid*)<br />See [Upsert a table row](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#upsert-a-table-row) |<xref:Microsoft.Xrm.Sdk.Messages.UpsertRequest>|
| `UpsertMultiple`<br />Event: False |<xref:Microsoft.Dynamics.CRM.UpsertMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpsertMultipleRequest>|
| `ValidateRetentionConfig`<br />Event: True |<xref:Microsoft.Dynamics.CRM.ValidateRetentionConfig?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|

## Properties

The following table lists selected properties for the SCA Engage Agent Result (msdyn_dcaengageagentresult) table.

|Property|Value|
| --- | --- |
| **DisplayName** | **SCA Engage Agent Result** |
| **DisplayCollectionName** | **SCA Engage Agent Results** |
| **SchemaName** | `msdyn_dcaengageagentresult` |
| **CollectionSchemaName** | `msdyn_dcaengageagentresults` |
| **EntitySetName** | `msdyn_dcaengageagentresults`|
| **LogicalName** | `msdyn_dcaengageagentresult` |
| **LogicalCollectionName** | `msdyn_dcaengageagentresults` |
| **PrimaryIdAttribute** | `msdyn_dcaengageagentresultid` |
| **PrimaryNameAttribute** |`msdyn_name` |
| **TableType** | `Standard` |
| **OwnershipType** | `UserOwned` |

## Writable columns/attributes

These columns/attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [additionaldata](#BKMK_additionaldata)
- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [msdyn_dcaengageagentresultId](#BKMK_msdyn_dcaengageagentresultId)
- [msdyn_engageagentresponsehistory](#BKMK_msdyn_engageagentresponsehistory)
- [msdyn_executiondetails](#BKMK_msdyn_executiondetails)
- [msdyn_followupdetails](#BKMK_msdyn_followupdetails)
- [msdyn_lastengageagentresponse](#BKMK_msdyn_lastengageagentresponse)
- [msdyn_lastprocessedactivityid](#BKMK_msdyn_lastprocessedactivityid)
- [msdyn_lastprocessedactivitytype](#BKMK_msdyn_lastprocessedactivitytype)
- [msdyn_name](#BKMK_msdyn_name)
- [msdyn_regarding](#BKMK_msdyn_regarding)
- [msdyn_regardingIdType](#BKMK_msdyn_regardingIdType)
- [msdyn_runafterdate](#BKMK_msdyn_runafterdate)
- [msdyn_salesagentrun](#BKMK_msdyn_salesagentrun)
- [OverriddenCreatedOn](#BKMK_OverriddenCreatedOn)
- [OwnerId](#BKMK_OwnerId)
- [OwnerIdType](#BKMK_OwnerIdType)
- [prevstatuscode](#BKMK_prevstatuscode)
- [statecode](#BKMK_statecode)
- [statuscode](#BKMK_statuscode)
- [TimeZoneRuleVersionNumber](#BKMK_TimeZoneRuleVersionNumber)
- [UTCConversionTimeZoneCode](#BKMK_UTCConversionTimeZoneCode)

### <a name="BKMK_additionaldata"></a> additionaldata

|Property|Value|
|---|---|
|Description|**Additional data for tracking SCA engage agent result**|
|DisplayName|**Additional data**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`additionaldata`|
|RequiredLevel|None|
|Type|Memo|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|1048576|

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

### <a name="BKMK_msdyn_dcaengageagentresultId"></a> msdyn_dcaengageagentresultId

|Property|Value|
|---|---|
|Description|**Unique identifier for SCA Engage agent result**|
|DisplayName|**SCA Engage agent result**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`msdyn_dcaengageagentresultid`|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|

### <a name="BKMK_msdyn_engageagentresponsehistory"></a> msdyn_engageagentresponsehistory

|Property|Value|
|---|---|
|Description|**Stores historical engagement responses from the Engage Agent in JSON format for analysis and reference.**|
|DisplayName|**Engage Agent Response History**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_engageagentresponsehistory`|
|RequiredLevel|None|
|Type|Memo|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|1048576|

### <a name="BKMK_msdyn_executiondetails"></a> msdyn_executiondetails

|Property|Value|
|---|---|
|Description|**Stores execution-related information and metadata that provide context for this result.**|
|DisplayName|**Execution Details**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_executiondetails`|
|RequiredLevel|None|
|Type|Memo|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|1048576|

### <a name="BKMK_msdyn_followupdetails"></a> msdyn_followupdetails

|Property|Value|
|---|---|
|Description|**Contains metadata and execution information for follow-ups planned or executed as part of this Engage Agent run.**|
|DisplayName|**Follow Up Details**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_followupdetails`|
|RequiredLevel|None|
|Type|Memo|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|1048576|

### <a name="BKMK_msdyn_lastengageagentresponse"></a> msdyn_lastengageagentresponse

|Property|Value|
|---|---|
|Description|**Stores the most recent response from the Engage Agent in JSON format for reference or processing.**|
|DisplayName|**Last Engage Agent Response**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_lastengageagentresponse`|
|RequiredLevel|None|
|Type|Memo|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|1048576|

### <a name="BKMK_msdyn_lastprocessedactivityid"></a> msdyn_lastprocessedactivityid

|Property|Value|
|---|---|
|Description|**Identifier of the most recent activity processed**|
|DisplayName|**Last Processed Activity Id**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_lastprocessedactivityid`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdyn_lastprocessedactivitytype"></a> msdyn_lastprocessedactivitytype

|Property|Value|
|---|---|
|Description|**Specifies the type of the most recent activity processed**|
|DisplayName|**Last Processed Activity Type**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_lastprocessedactivitytype`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdyn_name"></a> msdyn_name

|Property|Value|
|---|---|
|Description|**The name of the entity.**|
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
|Description|**Uniquely identifies the object associated with this result record.**|
|DisplayName|**Regarding**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_regarding`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|account, contact, lead, opportunity|

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

### <a name="BKMK_msdyn_runafterdate"></a> msdyn_runafterdate

|Property|Value|
|---|---|
|Description|**Specifies the date and time after which the record becomes eligible for processing.**|
|DisplayName|**Run After Date**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_runafterdate`|
|RequiredLevel|None|
|Type|DateTime|
|CanChangeDateTimeBehavior|False|
|DateTimeBehavior|UserLocal|
|Format|DateAndTime|
|ImeMode|Auto|
|SourceTypeMask|0|

### <a name="BKMK_msdyn_salesagentrun"></a> msdyn_salesagentrun

|Property|Value|
|---|---|
|Description|**Uniquely identifies the Sales Agent Run linked to this result record.**|
|DisplayName|**Sales Agent Run**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_salesagentrun`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|msdyn_salesagentrun|

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

### <a name="BKMK_prevstatuscode"></a> prevstatuscode

|Property|Value|
|---|---|
|Description|**Previous status of the SCAEngageAgentResult**|
|DisplayName|**Previous Status**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`prevstatuscode`|
|RequiredLevel|None|
|Type|Status|
|DefaultFormValue||
|GlobalChoiceName|`msdyn_dcaengageagentresult_prevstatuscode`|

#### prevstatuscode Choices/Options

|Value|Details|
|---|---|
|1|Label: **Contacted**<br />State:0<br />TransitionData: None|
|2|Label: **Engaged**<br />State:0<br />TransitionData: None|
|3|Label: **Active Escalation**<br />State:1<br />TransitionData: None|
|4|Label: **Proposal**<br />State:0<br />TransitionData: None|
|5|Label: **Closed as Lost**<br />State:1<br />TransitionData: None|
|6|Label: **Completed**<br />State:1<br />TransitionData: None|
|7|Label: **Completed by Supervisor**<br />State:1<br />TransitionData: None|
|8|Label: **Closed as Not relevant**<br />State:1<br />TransitionData: None|

### <a name="BKMK_statecode"></a> statecode

|Property|Value|
|---|---|
|Description|**Status of the SCAEngageAgentResult**|
|DisplayName|**Status**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statecode`|
|RequiredLevel|SystemRequired|
|Type|State|
|DefaultFormValue||
|GlobalChoiceName|`msdyn_dcaengageagentresult_statecode`|

#### statecode Choices/Options

|Value|Details|
|---|---|
|0|Label: **Active**<br />DefaultStatus: 0<br />InvariantName: `Active`|
|1|Label: **Inactive**<br />DefaultStatus: 0<br />InvariantName: `Inactive`|

### <a name="BKMK_statuscode"></a> statuscode

|Property|Value|
|---|---|
|Description|**Reason for the status of the SCAEngageAgentResult**|
|DisplayName|**Status Reason**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statuscode`|
|RequiredLevel|None|
|Type|Status|
|DefaultFormValue||
|GlobalChoiceName|`msdyn_dcaengageagentresult_statuscode`|

#### statuscode Choices/Options

|Value|Details|
|---|---|
|1|Label: **Contacted**<br />State:0<br />TransitionData: None|
|2|Label: **Engaged**<br />State:0<br />TransitionData: None|
|3|Label: **Active Escalation**<br />State:1<br />TransitionData: None|
|4|Label: **Proposal**<br />State:0<br />TransitionData: None|
|5|Label: **Closed as Lost**<br />State:1<br />TransitionData: None|
|6|Label: **Completed**<br />State:1<br />TransitionData: None|
|7|Label: **Completed by Supervisor**<br />State:1<br />TransitionData: None|
|8|Label: **Closed as Not relevant**<br />State:1<br />TransitionData: None|
|9|Label: **Standby**<br />State:0<br />TransitionData: None|

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
- [msdyn_lastprocessedtimestamp](#BKMK_msdyn_lastprocessedtimestamp)
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

### <a name="BKMK_msdyn_lastprocessedtimestamp"></a> msdyn_lastprocessedtimestamp

|Property|Value|
|---|---|
|Description|**The date and time when the most recent activity was processed for this result.**|
|DisplayName|**Last Processed Timestamp**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_lastprocessedtimestamp`|
|RequiredLevel|None|
|Type|DateTime|
|CanChangeDateTimeBehavior|False|
|DateTimeBehavior|UserLocal|
|Format|DateAndTime|
|ImeMode|Inactive|
|SourceTypeMask|0|

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
|RequiredLevel|SystemRequired|
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

- [business_unit_msdyn_dcaengageagentresult](#BKMK_business_unit_msdyn_dcaengageagentresult)
- [lk_msdyn_dcaengageagentresult_createdby](#BKMK_lk_msdyn_dcaengageagentresult_createdby)
- [lk_msdyn_dcaengageagentresult_createdonbehalfby](#BKMK_lk_msdyn_dcaengageagentresult_createdonbehalfby)
- [lk_msdyn_dcaengageagentresult_modifiedby](#BKMK_lk_msdyn_dcaengageagentresult_modifiedby)
- [lk_msdyn_dcaengageagentresult_modifiedonbehalfby](#BKMK_lk_msdyn_dcaengageagentresult_modifiedonbehalfby)
- [msdyn_dcaengageagentresult_regarding_account](#BKMK_msdyn_dcaengageagentresult_regarding_account)
- [msdyn_dcaengageagentresult_regarding_contact](#BKMK_msdyn_dcaengageagentresult_regarding_contact)
- [msdyn_dcaengageagentresult_regarding_lead](#BKMK_msdyn_dcaengageagentresult_regarding_lead)
- [msdyn_dcaengageagentresult_regarding_opportunity](#BKMK_msdyn_dcaengageagentresult_regarding_opportunity)
- [msdyn_dcaengageagentresult_salesagentrun_msdyn_salesagentrun](#BKMK_msdyn_dcaengageagentresult_salesagentrun_msdyn_salesagentrun)
- [owner_msdyn_dcaengageagentresult](#BKMK_owner_msdyn_dcaengageagentresult)
- [team_msdyn_dcaengageagentresult](#BKMK_team_msdyn_dcaengageagentresult)
- [user_msdyn_dcaengageagentresult](#BKMK_user_msdyn_dcaengageagentresult)

### <a name="BKMK_business_unit_msdyn_dcaengageagentresult"></a> business_unit_msdyn_dcaengageagentresult

One-To-Many Relationship: [businessunit business_unit_msdyn_dcaengageagentresult](businessunit.md#BKMK_business_unit_msdyn_dcaengageagentresult)

|Property|Value|
|---|---|
|ReferencedEntity|`businessunit`|
|ReferencedAttribute|`businessunitid`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencingEntityNavigationPropertyName|`owningbusinessunit`|
|IsHierarchical||
|CascadeConfiguration|Archive: `Restrict`<br />Assign: `NoCascade`<br />Delete: `Restrict`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_dcaengageagentresult_createdby"></a> lk_msdyn_dcaengageagentresult_createdby

One-To-Many Relationship: [systemuser lk_msdyn_dcaengageagentresult_createdby](systemuser.md#BKMK_lk_msdyn_dcaengageagentresult_createdby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdby`|
|ReferencingEntityNavigationPropertyName|`createdby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_dcaengageagentresult_createdonbehalfby"></a> lk_msdyn_dcaengageagentresult_createdonbehalfby

One-To-Many Relationship: [systemuser lk_msdyn_dcaengageagentresult_createdonbehalfby](systemuser.md#BKMK_lk_msdyn_dcaengageagentresult_createdonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdonbehalfby`|
|ReferencingEntityNavigationPropertyName|`createdonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_dcaengageagentresult_modifiedby"></a> lk_msdyn_dcaengageagentresult_modifiedby

One-To-Many Relationship: [systemuser lk_msdyn_dcaengageagentresult_modifiedby](systemuser.md#BKMK_lk_msdyn_dcaengageagentresult_modifiedby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedby`|
|ReferencingEntityNavigationPropertyName|`modifiedby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_dcaengageagentresult_modifiedonbehalfby"></a> lk_msdyn_dcaengageagentresult_modifiedonbehalfby

One-To-Many Relationship: [systemuser lk_msdyn_dcaengageagentresult_modifiedonbehalfby](systemuser.md#BKMK_lk_msdyn_dcaengageagentresult_modifiedonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedonbehalfby`|
|ReferencingEntityNavigationPropertyName|`modifiedonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_dcaengageagentresult_regarding_account"></a> msdyn_dcaengageagentresult_regarding_account

One-To-Many Relationship: [account msdyn_dcaengageagentresult_regarding_account](account.md#BKMK_msdyn_dcaengageagentresult_regarding_account)

|Property|Value|
|---|---|
|ReferencedEntity|`account`|
|ReferencedAttribute|`accountid`|
|ReferencingAttribute|`msdyn_regarding`|
|ReferencingEntityNavigationPropertyName|`msdyn_regarding_account`|
|IsHierarchical||
|CascadeConfiguration|Archive: `RemoveLink`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `Cascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_dcaengageagentresult_regarding_contact"></a> msdyn_dcaengageagentresult_regarding_contact

One-To-Many Relationship: [contact msdyn_dcaengageagentresult_regarding_contact](contact.md#BKMK_msdyn_dcaengageagentresult_regarding_contact)

|Property|Value|
|---|---|
|ReferencedEntity|`contact`|
|ReferencedAttribute|`contactid`|
|ReferencingAttribute|`msdyn_regarding`|
|ReferencingEntityNavigationPropertyName|`msdyn_regarding_contact`|
|IsHierarchical||
|CascadeConfiguration|Archive: `RemoveLink`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `Cascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_dcaengageagentresult_regarding_lead"></a> msdyn_dcaengageagentresult_regarding_lead

One-To-Many Relationship: [lead msdyn_dcaengageagentresult_regarding_lead](lead.md#BKMK_msdyn_dcaengageagentresult_regarding_lead)

|Property|Value|
|---|---|
|ReferencedEntity|`lead`|
|ReferencedAttribute|`leadid`|
|ReferencingAttribute|`msdyn_regarding`|
|ReferencingEntityNavigationPropertyName|`msdyn_regarding_lead`|
|IsHierarchical||
|CascadeConfiguration|Archive: `RemoveLink`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `Cascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_dcaengageagentresult_regarding_opportunity"></a> msdyn_dcaengageagentresult_regarding_opportunity

One-To-Many Relationship: [opportunity msdyn_dcaengageagentresult_regarding_opportunity](opportunity.md#BKMK_msdyn_dcaengageagentresult_regarding_opportunity)

|Property|Value|
|---|---|
|ReferencedEntity|`opportunity`|
|ReferencedAttribute|`opportunityid`|
|ReferencingAttribute|`msdyn_regarding`|
|ReferencingEntityNavigationPropertyName|`msdyn_regarding_opportunity`|
|IsHierarchical||
|CascadeConfiguration|Archive: `RemoveLink`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_dcaengageagentresult_salesagentrun_msdyn_salesagentrun"></a> msdyn_dcaengageagentresult_salesagentrun_msdyn_salesagentrun

One-To-Many Relationship: [msdyn_salesagentrun msdyn_dcaengageagentresult_salesagentrun_msdyn_salesagentrun](msdyn_salesagentrun.md#BKMK_msdyn_dcaengageagentresult_salesagentrun_msdyn_salesagentrun)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_salesagentrun`|
|ReferencedAttribute|`msdyn_salesagentrunid`|
|ReferencingAttribute|`msdyn_salesagentrun`|
|ReferencingEntityNavigationPropertyName|`msdyn_salesagentrun`|
|IsHierarchical||
|CascadeConfiguration|Archive: `RemoveLink`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_owner_msdyn_dcaengageagentresult"></a> owner_msdyn_dcaengageagentresult

One-To-Many Relationship: [owner owner_msdyn_dcaengageagentresult](owner.md#BKMK_owner_msdyn_dcaengageagentresult)

|Property|Value|
|---|---|
|ReferencedEntity|`owner`|
|ReferencedAttribute|`ownerid`|
|ReferencingAttribute|`ownerid`|
|ReferencingEntityNavigationPropertyName|`ownerid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_team_msdyn_dcaengageagentresult"></a> team_msdyn_dcaengageagentresult

One-To-Many Relationship: [team team_msdyn_dcaengageagentresult](team.md#BKMK_team_msdyn_dcaengageagentresult)

|Property|Value|
|---|---|
|ReferencedEntity|`team`|
|ReferencedAttribute|`teamid`|
|ReferencingAttribute|`owningteam`|
|ReferencingEntityNavigationPropertyName|`owningteam`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_user_msdyn_dcaengageagentresult"></a> user_msdyn_dcaengageagentresult

One-To-Many Relationship: [systemuser user_msdyn_dcaengageagentresult](systemuser.md#BKMK_user_msdyn_dcaengageagentresult)

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

- [msdyn_dcaengageagentresult_AsyncOperations](#BKMK_msdyn_dcaengageagentresult_AsyncOperations)
- [msdyn_dcaengageagentresult_BulkDeleteFailures](#BKMK_msdyn_dcaengageagentresult_BulkDeleteFailures)
- [msdyn_dcaengageagentresult_MailboxTrackingFolders](#BKMK_msdyn_dcaengageagentresult_MailboxTrackingFolders)
- [msdyn_dcaengageagentresult_PrincipalObjectAttributeAccesses](#BKMK_msdyn_dcaengageagentresult_PrincipalObjectAttributeAccesses)
- [msdyn_dcaengageagentresult_ProcessSession](#BKMK_msdyn_dcaengageagentresult_ProcessSession)
- [msdyn_dcaengageagentresult_SyncErrors](#BKMK_msdyn_dcaengageagentresult_SyncErrors)

### <a name="BKMK_msdyn_dcaengageagentresult_AsyncOperations"></a> msdyn_dcaengageagentresult_AsyncOperations

Many-To-One Relationship: [asyncoperation msdyn_dcaengageagentresult_AsyncOperations](asyncoperation.md#BKMK_msdyn_dcaengageagentresult_AsyncOperations)

|Property|Value|
|---|---|
|ReferencingEntity|`asyncoperation`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_dcaengageagentresult_AsyncOperations`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_dcaengageagentresult_BulkDeleteFailures"></a> msdyn_dcaengageagentresult_BulkDeleteFailures

Many-To-One Relationship: [bulkdeletefailure msdyn_dcaengageagentresult_BulkDeleteFailures](bulkdeletefailure.md#BKMK_msdyn_dcaengageagentresult_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencingEntity|`bulkdeletefailure`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_dcaengageagentresult_BulkDeleteFailures`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_dcaengageagentresult_MailboxTrackingFolders"></a> msdyn_dcaengageagentresult_MailboxTrackingFolders

Many-To-One Relationship: [mailboxtrackingfolder msdyn_dcaengageagentresult_MailboxTrackingFolders](mailboxtrackingfolder.md#BKMK_msdyn_dcaengageagentresult_MailboxTrackingFolders)

|Property|Value|
|---|---|
|ReferencingEntity|`mailboxtrackingfolder`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_dcaengageagentresult_MailboxTrackingFolders`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_dcaengageagentresult_PrincipalObjectAttributeAccesses"></a> msdyn_dcaengageagentresult_PrincipalObjectAttributeAccesses

Many-To-One Relationship: [principalobjectattributeaccess msdyn_dcaengageagentresult_PrincipalObjectAttributeAccesses](principalobjectattributeaccess.md#BKMK_msdyn_dcaengageagentresult_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencingEntity|`principalobjectattributeaccess`|
|ReferencingAttribute|`objectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_dcaengageagentresult_PrincipalObjectAttributeAccesses`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_dcaengageagentresult_ProcessSession"></a> msdyn_dcaengageagentresult_ProcessSession

Many-To-One Relationship: [processsession msdyn_dcaengageagentresult_ProcessSession](processsession.md#BKMK_msdyn_dcaengageagentresult_ProcessSession)

|Property|Value|
|---|---|
|ReferencingEntity|`processsession`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_dcaengageagentresult_ProcessSession`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_dcaengageagentresult_SyncErrors"></a> msdyn_dcaengageagentresult_SyncErrors

Many-To-One Relationship: [syncerror msdyn_dcaengageagentresult_SyncErrors](syncerror.md#BKMK_msdyn_dcaengageagentresult_SyncErrors)

|Property|Value|
|---|---|
|ReferencingEntity|`syncerror`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_dcaengageagentresult_SyncErrors`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|



### See also

[Dataverse table/entity reference](/power-apps/developer/data-platform/reference/about-entity-reference)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   

