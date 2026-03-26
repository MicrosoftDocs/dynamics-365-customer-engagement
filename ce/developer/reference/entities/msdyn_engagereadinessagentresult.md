---
title: "Engage And Readiness Agent Result V2 (msdyn_engagereadinessagentresult) table/entity reference (Microsoft Dynamics 365)"
description: "Includes schema information and supported messages for the Engage And Readiness Agent Result V2 (msdyn_engagereadinessagentresult) table/entity with Microsoft Dynamics 365."
ms.topic: generated-reference
author: JimDaly
ms.author: jdaly
search.audienceType: 
  - developer
---

# Engage And Readiness Agent Result V2 (msdyn_engagereadinessagentresult) table/entity reference (Microsoft Dynamics 365)

This table contains records of Engage And Readiness Agent Results.

## Messages

The following table lists the messages for the Engage And Readiness Agent Result V2 (msdyn_engagereadinessagentresult) table.
Messages represent operations that can be performed on the table. They may also be events.

| Name <br />Is Event? |Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `Assign`<br />Event: True |`PATCH` /msdyn_engagereadinessagentresults(*msdyn_engagereadinessagentresultid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `ownerid` property. |<xref:Microsoft.Crm.Sdk.Messages.AssignRequest>|
| `Associate`<br />Event: True |[Associate records](/power-apps/developer/data-platform/webapi/associate-disassociate-entities-using-web-api) |[Associate records](/power-apps/developer/data-platform/org-service/entity-operations-associate-disassociate#use-the-associate-method-or-associaterequest)|
| `BulkRetain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.BulkRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Create`<br />Event: True |`POST` /msdyn_engagereadinessagentresults<br />See [Create](/powerapps/developer/data-platform/webapi/create-entity-web-api) |[Create records](/power-apps/developer/data-platform/org-service/entity-operations-create#basic-create)|
| `CreateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.CreateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.CreateMultipleRequest>|
| `Delete`<br />Event: True |`DELETE` /msdyn_engagereadinessagentresults(*msdyn_engagereadinessagentresultid*)<br />See [Delete](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-delete) |[Delete records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-delete)|
| `Disassociate`<br />Event: True |[Disassociate records](/power-apps/developer/data-platform/webapi/associate-disassociate-entities-using-web-api) |[Disassociate records](/power-apps/developer/data-platform/org-service/entity-operations-associate-disassociate#use-the-disassociate-method-or-disassociaterequest)|
| `GrantAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.GrantAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.GrantAccessRequest>|
| `IsValidStateTransition`<br />Event: False |<xref:Microsoft.Dynamics.CRM.IsValidStateTransition?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.IsValidStateTransitionRequest>|
| `ModifyAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.ModifyAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.ModifyAccessRequest>|
| `PurgeRetainedContent`<br />Event: True |<xref:Microsoft.Dynamics.CRM.PurgeRetainedContent?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Restore`<br />Event: True |<xref:Microsoft.Dynamics.CRM.Restore?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.Retain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retrieve`<br />Event: True |`GET` /msdyn_engagereadinessagentresults(*msdyn_engagereadinessagentresultid*)<br />See [Retrieve](/powerapps/developer/data-platform/webapi/retrieve-entity-using-web-api) |[Retrieve records](/power-apps/developer/data-platform/org-service/entity-operations-retrieve)|
| `RetrieveMultiple`<br />Event: True |`GET` /msdyn_engagereadinessagentresults<br />See [Query data](/power-apps/developer/data-platform/webapi/query-data-web-api) |[Query data](/power-apps/developer/data-platform/org-service/entity-operations-query-data)|
| `RetrievePrincipalAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RetrievePrincipalAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RetrievePrincipalAccessRequest>|
| `RetrieveSharedPrincipalsAndAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RetrieveSharedPrincipalsAndAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RetrieveSharedPrincipalsAndAccessRequest>|
| `RevokeAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RevokeAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RevokeAccessRequest>|
| `RollbackRetain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RollbackRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `SetState`<br />Event: True |`PATCH` /msdyn_engagereadinessagentresults(*msdyn_engagereadinessagentresultid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `statecode` and `statuscode` properties. |<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|
| `Update`<br />Event: True |`PATCH` /msdyn_engagereadinessagentresults(*msdyn_engagereadinessagentresultid*)<br />See [Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) |[Update records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-update)|
| `UpdateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.UpdateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpdateMultipleRequest>|
| `Upsert`<br />Event: False |`PATCH` /msdyn_engagereadinessagentresults(*msdyn_engagereadinessagentresultid*)<br />See [Upsert a table row](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#upsert-a-table-row) |<xref:Microsoft.Xrm.Sdk.Messages.UpsertRequest>|
| `UpsertMultiple`<br />Event: False |<xref:Microsoft.Dynamics.CRM.UpsertMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpsertMultipleRequest>|
| `ValidateRetentionConfig`<br />Event: True |<xref:Microsoft.Dynamics.CRM.ValidateRetentionConfig?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|

## Properties

The following table lists selected properties for the Engage And Readiness Agent Result V2 (msdyn_engagereadinessagentresult) table.

|Property|Value|
| --- | --- |
| **DisplayName** | **Engage And Readiness Agent Result V2** |
| **DisplayCollectionName** | **Engage And Readiness Agent Results V2** |
| **SchemaName** | `msdyn_engagereadinessagentresult` |
| **CollectionSchemaName** | `msdyn_engagereadinessagentresults` |
| **EntitySetName** | `msdyn_engagereadinessagentresults`|
| **LogicalName** | `msdyn_engagereadinessagentresult` |
| **LogicalCollectionName** | `msdyn_engagereadinessagentresults` |
| **PrimaryIdAttribute** | `msdyn_engagereadinessagentresultid` |
| **PrimaryNameAttribute** |`msdyn_name` |
| **TableType** | `Standard` |
| **OwnershipType** | `UserOwned` |

## Writable columns/attributes

These columns/attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [msdyn_agentrespondedquerycount](#BKMK_msdyn_agentrespondedquerycount)
- [msdyn_bantdata](#BKMK_msdyn_bantdata)
- [msdyn_customeraskedquerycount](#BKMK_msdyn_customeraskedquerycount)
- [msdyn_engagereadinessagentresultId](#BKMK_msdyn_engagereadinessagentresultId)
- [msdyn_executiondetails](#BKMK_msdyn_executiondetails)
- [msdyn_followupdetails](#BKMK_msdyn_followupdetails)
- [msdyn_lastengageagentresponse](#BKMK_msdyn_lastengageagentresponse)
- [msdyn_lastprocessedactivityid](#BKMK_msdyn_lastprocessedactivityid)
- [msdyn_lastprocessedactivitytype](#BKMK_msdyn_lastprocessedactivitytype)
- [msdyn_name](#BKMK_msdyn_name)
- [msdyn_purchaseintentdata](#BKMK_msdyn_purchaseintentdata)
- [msdyn_regardingid](#BKMK_msdyn_regardingid)
- [msdyn_regardingidIdType](#BKMK_msdyn_regardingidIdType)
- [msdyn_RunAfterDate](#BKMK_msdyn_RunAfterDate)
- [msdyn_salesagentrun](#BKMK_msdyn_salesagentrun)
- [msdyn_standardsinterviewed](#BKMK_msdyn_standardsinterviewed)
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

### <a name="BKMK_msdyn_agentrespondedquerycount"></a> msdyn_agentrespondedquerycount

|Property|Value|
|---|---|
|Description|**Count of the queries responded by agent as part of engagement.**|
|DisplayName|**Agent responded query count**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`msdyn_agentrespondedquerycount`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|0|

### <a name="BKMK_msdyn_bantdata"></a> msdyn_bantdata

|Property|Value|
|---|---|
|Description|**Json to hold BANT data**|
|DisplayName|**BANT data**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_bantdata`|
|RequiredLevel|None|
|Type|Memo|
|Format|TextArea|
|FormatName|TextArea|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|1000000000|

### <a name="BKMK_msdyn_customeraskedquerycount"></a> msdyn_customeraskedquerycount

|Property|Value|
|---|---|
|Description|**Count of the queries asked by customer as part of engagement.**|
|DisplayName|**Customer asked query count**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`msdyn_customeraskedquerycount`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|0|

### <a name="BKMK_msdyn_engagereadinessagentresultId"></a> msdyn_engagereadinessagentresultId

|Property|Value|
|---|---|
|Description|**Unique identifier for engage and readiness agent result**|
|DisplayName|**Engage and readiness agent result**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`msdyn_engagereadinessagentresultid`|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|

### <a name="BKMK_msdyn_executiondetails"></a> msdyn_executiondetails

|Property|Value|
|---|---|
|Description|**Execution Details**|
|DisplayName|**Execution Details**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_executiondetails`|
|RequiredLevel|None|
|Type|Memo|
|Format|TextArea|
|FormatName|TextArea|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100000|

### <a name="BKMK_msdyn_followupdetails"></a> msdyn_followupdetails

|Property|Value|
|---|---|
|Description|**Follow-up Details**|
|DisplayName|**Follow-up Details**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_followupdetails`|
|RequiredLevel|None|
|Type|Memo|
|Format|TextArea|
|FormatName|TextArea|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100000|

### <a name="BKMK_msdyn_lastengageagentresponse"></a> msdyn_lastengageagentresponse

|Property|Value|
|---|---|
|Description|**Json to hold Last Engage And Readiness Agent Response**|
|DisplayName|**Last Engage And Readiness Agent Response**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_lastengageagentresponse`|
|RequiredLevel|None|
|Type|Memo|
|Format|TextArea|
|FormatName|TextArea|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|1000000000|

### <a name="BKMK_msdyn_lastprocessedactivityid"></a> msdyn_lastprocessedactivityid

|Property|Value|
|---|---|
|Description|**Last processed activity id**|
|DisplayName|**LastProcessedActivityId**|
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
|Description|**Last processed activity type**|
|DisplayName|**LastProcessedActivityType**|
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

### <a name="BKMK_msdyn_purchaseintentdata"></a> msdyn_purchaseintentdata

|Property|Value|
|---|---|
|Description|**Json to hold Purchase Intent Data**|
|DisplayName|**Purchase Intent Data**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_purchaseintentdata`|
|RequiredLevel|None|
|Type|Memo|
|Format|TextArea|
|FormatName|TextArea|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|1000000000|

### <a name="BKMK_msdyn_regardingid"></a> msdyn_regardingid

|Property|Value|
|---|---|
|Description|**Unique identifier of the object with which the result is associated.**|
|DisplayName|**Regarding id**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_regardingid`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|lead|

### <a name="BKMK_msdyn_regardingidIdType"></a> msdyn_regardingidIdType

|Property|Value|
|---|---|
|Description||
|DisplayName||
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`msdyn_regardingididtype`|
|RequiredLevel|None|
|Type|EntityName|

### <a name="BKMK_msdyn_RunAfterDate"></a> msdyn_RunAfterDate

|Property|Value|
|---|---|
|Description|**Date and time after which the reocrd can be processed.**|
|DisplayName|**Run after date**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_runafterdate`|
|RequiredLevel|None|
|Type|DateTime|
|CanChangeDateTimeBehavior|False|
|DateTimeBehavior|UserLocal|
|Format|DateAndTime|
|ImeMode|Inactive|
|SourceTypeMask|0|

### <a name="BKMK_msdyn_salesagentrun"></a> msdyn_salesagentrun

|Property|Value|
|---|---|
|Description|**Sales Agent Run**|
|DisplayName|**SalesAgentRun**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_salesagentrun`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|msdyn_salesagentrun|

### <a name="BKMK_msdyn_standardsinterviewed"></a> msdyn_standardsinterviewed

|Property|Value|
|---|---|
|Description|**Json to hold standards interviewed by engage agent**|
|DisplayName|**Standards interviewed by engage agent**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_standardsinterviewed`|
|RequiredLevel|None|
|Type|Memo|
|Format|TextArea|
|FormatName|TextArea|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|2000|

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
|Description|**Status of the msdyn engagereadinessagentresult**|
|DisplayName|**Status**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statecode`|
|RequiredLevel|SystemRequired|
|Type|State|
|DefaultFormValue||
|GlobalChoiceName|`msdyn_engagereadinessagentresult_statecode`|

#### statecode Choices/Options

|Value|Details|
|---|---|
|0|Label: **Active**<br />DefaultStatus: 1<br />InvariantName: `Active`|
|1|Label: **Inactive**<br />DefaultStatus: 2<br />InvariantName: `Inactive`|

### <a name="BKMK_statuscode"></a> statuscode

|Property|Value|
|---|---|
|Description|**Reason for the status of the msdyn engagereadinessagentresult**|
|DisplayName|**Status Reason**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statuscode`|
|RequiredLevel|None|
|Type|Status|
|DefaultFormValue||
|GlobalChoiceName|`msdyn_engagereadinessagentresult_statuscode`|

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
|Description|**Last processed timestamp**|
|DisplayName|**Last processed timestamp**|
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

- [business_unit_msdyn_engagereadinessagentresult](#BKMK_business_unit_msdyn_engagereadinessagentresult)
- [lk_msdyn_engagereadinessagentresult_createdby](#BKMK_lk_msdyn_engagereadinessagentresult_createdby)
- [lk_msdyn_engagereadinessagentresult_createdonbehalfby](#BKMK_lk_msdyn_engagereadinessagentresult_createdonbehalfby)
- [lk_msdyn_engagereadinessagentresult_modifiedby](#BKMK_lk_msdyn_engagereadinessagentresult_modifiedby)
- [lk_msdyn_engagereadinessagentresult_modifiedonbehalfby](#BKMK_lk_msdyn_engagereadinessagentresult_modifiedonbehalfby)
- [msdyn_engagereadinessagentresult_lead](#BKMK_msdyn_engagereadinessagentresult_lead)
- [msdyn_salesagentrun_msdyn_engagereadinessagentresult](#BKMK_msdyn_salesagentrun_msdyn_engagereadinessagentresult)
- [owner_msdyn_engagereadinessagentresult](#BKMK_owner_msdyn_engagereadinessagentresult)
- [team_msdyn_engagereadinessagentresult](#BKMK_team_msdyn_engagereadinessagentresult)
- [user_msdyn_engagereadinessagentresult](#BKMK_user_msdyn_engagereadinessagentresult)

### <a name="BKMK_business_unit_msdyn_engagereadinessagentresult"></a> business_unit_msdyn_engagereadinessagentresult

One-To-Many Relationship: [businessunit business_unit_msdyn_engagereadinessagentresult](businessunit.md#BKMK_business_unit_msdyn_engagereadinessagentresult)

|Property|Value|
|---|---|
|ReferencedEntity|`businessunit`|
|ReferencedAttribute|`businessunitid`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencingEntityNavigationPropertyName|`owningbusinessunit`|
|IsHierarchical||
|CascadeConfiguration|Archive: `Restrict`<br />Assign: `NoCascade`<br />Delete: `Restrict`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_engagereadinessagentresult_createdby"></a> lk_msdyn_engagereadinessagentresult_createdby

One-To-Many Relationship: [systemuser lk_msdyn_engagereadinessagentresult_createdby](systemuser.md#BKMK_lk_msdyn_engagereadinessagentresult_createdby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdby`|
|ReferencingEntityNavigationPropertyName|`createdby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_engagereadinessagentresult_createdonbehalfby"></a> lk_msdyn_engagereadinessagentresult_createdonbehalfby

One-To-Many Relationship: [systemuser lk_msdyn_engagereadinessagentresult_createdonbehalfby](systemuser.md#BKMK_lk_msdyn_engagereadinessagentresult_createdonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdonbehalfby`|
|ReferencingEntityNavigationPropertyName|`createdonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_engagereadinessagentresult_modifiedby"></a> lk_msdyn_engagereadinessagentresult_modifiedby

One-To-Many Relationship: [systemuser lk_msdyn_engagereadinessagentresult_modifiedby](systemuser.md#BKMK_lk_msdyn_engagereadinessagentresult_modifiedby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedby`|
|ReferencingEntityNavigationPropertyName|`modifiedby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_engagereadinessagentresult_modifiedonbehalfby"></a> lk_msdyn_engagereadinessagentresult_modifiedonbehalfby

One-To-Many Relationship: [systemuser lk_msdyn_engagereadinessagentresult_modifiedonbehalfby](systemuser.md#BKMK_lk_msdyn_engagereadinessagentresult_modifiedonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedonbehalfby`|
|ReferencingEntityNavigationPropertyName|`modifiedonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_engagereadinessagentresult_lead"></a> msdyn_engagereadinessagentresult_lead

One-To-Many Relationship: [lead msdyn_engagereadinessagentresult_lead](lead.md#BKMK_msdyn_engagereadinessagentresult_lead)

|Property|Value|
|---|---|
|ReferencedEntity|`lead`|
|ReferencedAttribute|`leadid`|
|ReferencingAttribute|`msdyn_regardingid`|
|ReferencingEntityNavigationPropertyName|`msdyn_regardingid_lead`|
|IsHierarchical||
|CascadeConfiguration|Archive: `RemoveLink`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `Cascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_salesagentrun_msdyn_engagereadinessagentresult"></a> msdyn_salesagentrun_msdyn_engagereadinessagentresult

One-To-Many Relationship: [msdyn_salesagentrun msdyn_salesagentrun_msdyn_engagereadinessagentresult](msdyn_salesagentrun.md#BKMK_msdyn_salesagentrun_msdyn_engagereadinessagentresult)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_salesagentrun`|
|ReferencedAttribute|`msdyn_salesagentrunid`|
|ReferencingAttribute|`msdyn_salesagentrun`|
|ReferencingEntityNavigationPropertyName|`msdyn_salesagentrun`|
|IsHierarchical||
|CascadeConfiguration|Archive: `RemoveLink`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_owner_msdyn_engagereadinessagentresult"></a> owner_msdyn_engagereadinessagentresult

One-To-Many Relationship: [owner owner_msdyn_engagereadinessagentresult](owner.md#BKMK_owner_msdyn_engagereadinessagentresult)

|Property|Value|
|---|---|
|ReferencedEntity|`owner`|
|ReferencedAttribute|`ownerid`|
|ReferencingAttribute|`ownerid`|
|ReferencingEntityNavigationPropertyName|`ownerid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_team_msdyn_engagereadinessagentresult"></a> team_msdyn_engagereadinessagentresult

One-To-Many Relationship: [team team_msdyn_engagereadinessagentresult](team.md#BKMK_team_msdyn_engagereadinessagentresult)

|Property|Value|
|---|---|
|ReferencedEntity|`team`|
|ReferencedAttribute|`teamid`|
|ReferencingAttribute|`owningteam`|
|ReferencingEntityNavigationPropertyName|`owningteam`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_user_msdyn_engagereadinessagentresult"></a> user_msdyn_engagereadinessagentresult

One-To-Many Relationship: [systemuser user_msdyn_engagereadinessagentresult](systemuser.md#BKMK_user_msdyn_engagereadinessagentresult)

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

- [msdyn_engagereadinessagentresult_AsyncOperations](#BKMK_msdyn_engagereadinessagentresult_AsyncOperations)
- [msdyn_engagereadinessagentresult_BulkDeleteFailures](#BKMK_msdyn_engagereadinessagentresult_BulkDeleteFailures)
- [msdyn_engagereadinessagentresult_MailboxTrackingFolders](#BKMK_msdyn_engagereadinessagentresult_MailboxTrackingFolders)
- [msdyn_engagereadinessagentresult_PrincipalObjectAttributeAccesses](#BKMK_msdyn_engagereadinessagentresult_PrincipalObjectAttributeAccesses)
- [msdyn_engagereadinessagentresult_ProcessSession](#BKMK_msdyn_engagereadinessagentresult_ProcessSession)
- [msdyn_engagereadinessagentresult_SyncErrors](#BKMK_msdyn_engagereadinessagentresult_SyncErrors)

### <a name="BKMK_msdyn_engagereadinessagentresult_AsyncOperations"></a> msdyn_engagereadinessagentresult_AsyncOperations

Many-To-One Relationship: [asyncoperation msdyn_engagereadinessagentresult_AsyncOperations](asyncoperation.md#BKMK_msdyn_engagereadinessagentresult_AsyncOperations)

|Property|Value|
|---|---|
|ReferencingEntity|`asyncoperation`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_engagereadinessagentresult_AsyncOperations`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_engagereadinessagentresult_BulkDeleteFailures"></a> msdyn_engagereadinessagentresult_BulkDeleteFailures

Many-To-One Relationship: [bulkdeletefailure msdyn_engagereadinessagentresult_BulkDeleteFailures](bulkdeletefailure.md#BKMK_msdyn_engagereadinessagentresult_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencingEntity|`bulkdeletefailure`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_engagereadinessagentresult_BulkDeleteFailures`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_engagereadinessagentresult_MailboxTrackingFolders"></a> msdyn_engagereadinessagentresult_MailboxTrackingFolders

Many-To-One Relationship: [mailboxtrackingfolder msdyn_engagereadinessagentresult_MailboxTrackingFolders](mailboxtrackingfolder.md#BKMK_msdyn_engagereadinessagentresult_MailboxTrackingFolders)

|Property|Value|
|---|---|
|ReferencingEntity|`mailboxtrackingfolder`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_engagereadinessagentresult_MailboxTrackingFolders`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_engagereadinessagentresult_PrincipalObjectAttributeAccesses"></a> msdyn_engagereadinessagentresult_PrincipalObjectAttributeAccesses

Many-To-One Relationship: [principalobjectattributeaccess msdyn_engagereadinessagentresult_PrincipalObjectAttributeAccesses](principalobjectattributeaccess.md#BKMK_msdyn_engagereadinessagentresult_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencingEntity|`principalobjectattributeaccess`|
|ReferencingAttribute|`objectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_engagereadinessagentresult_PrincipalObjectAttributeAccesses`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_engagereadinessagentresult_ProcessSession"></a> msdyn_engagereadinessagentresult_ProcessSession

Many-To-One Relationship: [processsession msdyn_engagereadinessagentresult_ProcessSession](processsession.md#BKMK_msdyn_engagereadinessagentresult_ProcessSession)

|Property|Value|
|---|---|
|ReferencingEntity|`processsession`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_engagereadinessagentresult_ProcessSession`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_engagereadinessagentresult_SyncErrors"></a> msdyn_engagereadinessagentresult_SyncErrors

Many-To-One Relationship: [syncerror msdyn_engagereadinessagentresult_SyncErrors](syncerror.md#BKMK_msdyn_engagereadinessagentresult_SyncErrors)

|Property|Value|
|---|---|
|ReferencingEntity|`syncerror`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_engagereadinessagentresult_SyncErrors`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|



### See also

[Dataverse table/entity reference](/power-apps/developer/data-platform/reference/about-entity-reference)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   

