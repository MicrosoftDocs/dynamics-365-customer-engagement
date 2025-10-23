---
title: "Lead Agent Result (msdyn_leadagentresult) table/entity reference (Microsoft Dynamics 365)"
description: "Includes schema information and supported messages for the Lead Agent Result (msdyn_leadagentresult) table/entity with Microsoft Dynamics 365."
ms.topic: generated-reference
author: JimDaly
ms.author: jdaly
search.audienceType: 
  - developer
---

# Lead Agent Result (msdyn_leadagentresult) table/entity reference (Microsoft Dynamics 365)

Entity to save lead agent results.

## Messages

The following table lists the messages for the Lead Agent Result (msdyn_leadagentresult) table.
Messages represent operations that can be performed on the table. They may also be events.

| Name <br />Is Event? |Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `Assign`<br />Event: True |`PATCH` /msdyn_leadagentresults(*msdyn_leadagentresultid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `ownerid` property. |<xref:Microsoft.Crm.Sdk.Messages.AssignRequest>|
| `Associate`<br />Event: True |[Associate records](/power-apps/developer/data-platform/webapi/associate-disassociate-entities-using-web-api) |[Associate records](/power-apps/developer/data-platform/org-service/entity-operations-associate-disassociate#use-the-associate-method-or-associaterequest)|
| `BulkRetain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.BulkRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Create`<br />Event: True |`POST` /msdyn_leadagentresults<br />See [Create](/powerapps/developer/data-platform/webapi/create-entity-web-api) |[Create records](/power-apps/developer/data-platform/org-service/entity-operations-create#basic-create)|
| `CreateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.CreateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.CreateMultipleRequest>|
| `Delete`<br />Event: True |`DELETE` /msdyn_leadagentresults(*msdyn_leadagentresultid*)<br />See [Delete](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-delete) |[Delete records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-delete)|
| `Disassociate`<br />Event: True |[Disassociate records](/power-apps/developer/data-platform/webapi/associate-disassociate-entities-using-web-api) |[Disassociate records](/power-apps/developer/data-platform/org-service/entity-operations-associate-disassociate#use-the-disassociate-method-or-disassociaterequest)|
| `GrantAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.GrantAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.GrantAccessRequest>|
| `IsValidStateTransition`<br />Event: False |<xref:Microsoft.Dynamics.CRM.IsValidStateTransition?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.IsValidStateTransitionRequest>|
| `ModifyAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.ModifyAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.ModifyAccessRequest>|
| `PurgeRetainedContent`<br />Event: True |<xref:Microsoft.Dynamics.CRM.PurgeRetainedContent?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Restore`<br />Event: True |<xref:Microsoft.Dynamics.CRM.Restore?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.Retain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retrieve`<br />Event: True |`GET` /msdyn_leadagentresults(*msdyn_leadagentresultid*)<br />See [Retrieve](/powerapps/developer/data-platform/webapi/retrieve-entity-using-web-api) |[Retrieve records](/power-apps/developer/data-platform/org-service/entity-operations-retrieve)|
| `RetrieveMultiple`<br />Event: True |`GET` /msdyn_leadagentresults<br />See [Query data](/power-apps/developer/data-platform/webapi/query-data-web-api) |[Query data](/power-apps/developer/data-platform/org-service/entity-operations-query-data)|
| `RetrievePrincipalAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RetrievePrincipalAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RetrievePrincipalAccessRequest>|
| `RetrieveSharedPrincipalsAndAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RetrieveSharedPrincipalsAndAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RetrieveSharedPrincipalsAndAccessRequest>|
| `RevokeAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RevokeAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RevokeAccessRequest>|
| `RollbackRetain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RollbackRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `SetState`<br />Event: True |`PATCH` /msdyn_leadagentresults(*msdyn_leadagentresultid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `statecode` and `statuscode` properties. |<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|
| `Update`<br />Event: True |`PATCH` /msdyn_leadagentresults(*msdyn_leadagentresultid*)<br />See [Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) |[Update records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-update)|
| `UpdateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.UpdateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpdateMultipleRequest>|
| `Upsert`<br />Event: False |`PATCH` /msdyn_leadagentresults(*msdyn_leadagentresultid*)<br />See [Upsert a table row](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#upsert-a-table-row) |<xref:Microsoft.Xrm.Sdk.Messages.UpsertRequest>|
| `UpsertMultiple`<br />Event: False |<xref:Microsoft.Dynamics.CRM.UpsertMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpsertMultipleRequest>|
| `ValidateRetentionConfig`<br />Event: True |<xref:Microsoft.Dynamics.CRM.ValidateRetentionConfig?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|

## Properties

The following table lists selected properties for the Lead Agent Result (msdyn_leadagentresult) table.

|Property|Value|
| --- | --- |
| **DisplayName** | **Lead Agent Result** |
| **DisplayCollectionName** | **Lead Agent Results** |
| **SchemaName** | `msdyn_leadagentresult` |
| **CollectionSchemaName** | `msdyn_leadagentresults` |
| **EntitySetName** | `msdyn_leadagentresults`|
| **LogicalName** | `msdyn_leadagentresult` |
| **LogicalCollectionName** | `msdyn_leadagentresults` |
| **PrimaryIdAttribute** | `msdyn_leadagentresultid` |
| **PrimaryNameAttribute** |`msdyn_name` |
| **TableType** | `Standard` |
| **OwnershipType** | `UserOwned` |

## Writable columns/attributes

These columns/attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [msdyn_bantscore](#BKMK_msdyn_bantscore)
- [msdyn_cioengagementsummary](#BKMK_msdyn_cioengagementsummary)
- [msdyn_cioengagementsummarylastrun](#BKMK_msdyn_cioengagementsummarylastrun)
- [msdyn_firesynthesisadditionalinsights](#BKMK_msdyn_firesynthesisadditionalinsights)
- [msdyn_firesynthesisagentlastrun](#BKMK_msdyn_firesynthesisagentlastrun)
- [msdyn_firesynthesisdata](#BKMK_msdyn_firesynthesisdata)
- [msdyn_icpbantsummary](#BKMK_msdyn_icpbantsummary)
- [msdyn_icpexecutivesummary](#BKMK_msdyn_icpexecutivesummary)
- [msdyn_icpscore](#BKMK_msdyn_icpscore)
- [msdyn_leadagentresultId](#BKMK_msdyn_leadagentresultId)
- [msdyn_leadid](#BKMK_msdyn_leadid)
- [msdyn_leadidIdType](#BKMK_msdyn_leadidIdType)
- [msdyn_mostrecentoutlookactivity](#BKMK_msdyn_mostrecentoutlookactivity)
- [msdyn_name](#BKMK_msdyn_name)
- [msdyn_prioritizationagentlastrun](#BKMK_msdyn_prioritizationagentlastrun)
- [msdyn_prioritizationresultdetails](#BKMK_msdyn_prioritizationresultdetails)
- [msdyn_prioritizationresultscore](#BKMK_msdyn_prioritizationresultscore)
- [msdyn_purchasinginterestdata](#BKMK_msdyn_purchasinginterestdata)
- [msdyn_qualificationagentlastrun](#BKMK_msdyn_qualificationagentlastrun)
- [msdyn_qualificationdecision](#BKMK_msdyn_qualificationdecision)
- [msdyn_qualificationresultdetails](#BKMK_msdyn_qualificationresultdetails)
- [msdyn_qualificationresultrank](#BKMK_msdyn_qualificationresultrank)
- [msdyn_qualificationstandards](#BKMK_msdyn_qualificationstandards)
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

### <a name="BKMK_msdyn_bantscore"></a> msdyn_bantscore

|Property|Value|
|---|---|
|Description|**Score indicating Budget, Authority, Need, and Timeline qualification**|
|DisplayName|**BANT Score**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_bantscore`|
|RequiredLevel|None|
|Type|Decimal|
|ImeMode|Disabled|
|MaxValue|1000|
|MinValue|0|
|Precision|2|
|SourceTypeMask|0|

### <a name="BKMK_msdyn_cioengagementsummary"></a> msdyn_cioengagementsummary

|Property|Value|
|---|---|
|Description||
|DisplayName|**CIO Engagement Summary**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_cioengagementsummary`|
|RequiredLevel|None|
|Type|Memo|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|1048576|

### <a name="BKMK_msdyn_cioengagementsummarylastrun"></a> msdyn_cioengagementsummarylastrun

|Property|Value|
|---|---|
|Description||
|DisplayName|**CIO Engagement Summary Last Run**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_cioengagementsummarylastrun`|
|RequiredLevel|None|
|Type|DateTime|
|CanChangeDateTimeBehavior|True|
|DateTimeBehavior|UserLocal|
|Format|DateAndTime|
|ImeMode|Auto|
|SourceTypeMask|0|

### <a name="BKMK_msdyn_firesynthesisadditionalinsights"></a> msdyn_firesynthesisadditionalinsights

|Property|Value|
|---|---|
|Description||
|DisplayName|**JSON data containing additional insights for FIRE Synthesis**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_firesynthesisadditionalinsights`|
|RequiredLevel|None|
|Type|Memo|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|1048576|

### <a name="BKMK_msdyn_firesynthesisagentlastrun"></a> msdyn_firesynthesisagentlastrun

|Property|Value|
|---|---|
|Description||
|DisplayName|**FIRE Synthesis Agent Last Run**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_firesynthesisagentlastrun`|
|RequiredLevel|None|
|Type|DateTime|
|CanChangeDateTimeBehavior|True|
|DateTimeBehavior|UserLocal|
|Format|DateAndTime|
|ImeMode|Auto|
|SourceTypeMask|0|

### <a name="BKMK_msdyn_firesynthesisdata"></a> msdyn_firesynthesisdata

|Property|Value|
|---|---|
|Description|**JSON data containing detailed FIRE Synthesis information**|
|DisplayName|**FIRE Synthesis Data**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_firesynthesisdata`|
|RequiredLevel|None|
|Type|Memo|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|1048576|

### <a name="BKMK_msdyn_icpbantsummary"></a> msdyn_icpbantsummary

|Property|Value|
|---|---|
|Description|**JSON data containing the combined executive summary for BANT and ICP qualification information.**|
|DisplayName|**ICP \+ BANT Summary**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_icpbantsummary`|
|RequiredLevel|None|
|Type|Memo|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|1048576|

### <a name="BKMK_msdyn_icpexecutivesummary"></a> msdyn_icpexecutivesummary

|Property|Value|
|---|---|
|Description|**JSON data containing the executive summary for ICP (Ideal Customer Profile) information.**|
|DisplayName|**ICP Executive Summary**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_icpexecutivesummary`|
|RequiredLevel|None|
|Type|Memo|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|1048576|

### <a name="BKMK_msdyn_icpscore"></a> msdyn_icpscore

|Property|Value|
|---|---|
|Description|**Score indicating ICP fit for this lead**|
|DisplayName|**ICP Score**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_icpscore`|
|RequiredLevel|None|
|Type|Decimal|
|ImeMode|Disabled|
|MaxValue|100|
|MinValue|0|
|Precision|2|
|SourceTypeMask|0|

### <a name="BKMK_msdyn_leadagentresultId"></a> msdyn_leadagentresultId

|Property|Value|
|---|---|
|Description|**Unique identifier for entity instances**|
|DisplayName|**Lead Agent Result**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`msdyn_leadagentresultid`|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|

### <a name="BKMK_msdyn_leadid"></a> msdyn_leadid

|Property|Value|
|---|---|
|Description||
|DisplayName|**Lead Id**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_leadid`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|lead|

### <a name="BKMK_msdyn_leadidIdType"></a> msdyn_leadidIdType

|Property|Value|
|---|---|
|Description||
|DisplayName||
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`msdyn_leadididtype`|
|RequiredLevel|None|
|Type|EntityName|

### <a name="BKMK_msdyn_mostrecentoutlookactivity"></a> msdyn_mostrecentoutlookactivity

|Property|Value|
|---|---|
|Description||
|DisplayName|**Most Recent Outlook Activity**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_mostrecentoutlookactivity`|
|RequiredLevel|None|
|Type|DateTime|
|CanChangeDateTimeBehavior|True|
|DateTimeBehavior|UserLocal|
|Format|DateAndTime|
|ImeMode|Auto|
|SourceTypeMask|0|

### <a name="BKMK_msdyn_name"></a> msdyn_name

|Property|Value|
|---|---|
|Description||
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
|MaxLength|850|

### <a name="BKMK_msdyn_prioritizationagentlastrun"></a> msdyn_prioritizationagentlastrun

|Property|Value|
|---|---|
|Description||
|DisplayName|**Prioritization Agent Last Run**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_prioritizationagentlastrun`|
|RequiredLevel|None|
|Type|DateTime|
|CanChangeDateTimeBehavior|True|
|DateTimeBehavior|UserLocal|
|Format|DateAndTime|
|ImeMode|Auto|
|SourceTypeMask|0|

### <a name="BKMK_msdyn_prioritizationresultdetails"></a> msdyn_prioritizationresultdetails

|Property|Value|
|---|---|
|Description||
|DisplayName|**Prioritization Result Details**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_prioritizationresultdetails`|
|RequiredLevel|None|
|Type|Memo|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|1048576|

### <a name="BKMK_msdyn_prioritizationresultscore"></a> msdyn_prioritizationresultscore

|Property|Value|
|---|---|
|Description||
|DisplayName|**Prioritization Result Score**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_prioritizationresultscore`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|-2147483648|

### <a name="BKMK_msdyn_purchasinginterestdata"></a> msdyn_purchasinginterestdata

|Property|Value|
|---|---|
|Description|**JSON data containing detailed purchasing interest information**|
|DisplayName|**Purchasing Interest Data**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_purchasinginterestdata`|
|RequiredLevel|None|
|Type|Memo|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|1048576|

### <a name="BKMK_msdyn_qualificationagentlastrun"></a> msdyn_qualificationagentlastrun

|Property|Value|
|---|---|
|Description||
|DisplayName|**Qualification Agent Last Run**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_qualificationagentlastrun`|
|RequiredLevel|None|
|Type|DateTime|
|CanChangeDateTimeBehavior|True|
|DateTimeBehavior|UserLocal|
|Format|DateAndTime|
|ImeMode|Auto|
|SourceTypeMask|0|

### <a name="BKMK_msdyn_qualificationdecision"></a> msdyn_qualificationdecision

|Property|Value|
|---|---|
|Description|**Indicates whether the lead is qualified, disqualified, or undetected**|
|DisplayName|**Qualification Decision**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_qualificationdecision`|
|RequiredLevel|None|
|Type|Picklist|
|DefaultFormValue||
|GlobalChoiceName|`msdyn_leadagentresult_msdyn_qualificationdecision`|

#### msdyn_qualificationdecision Choices/Options

|Value|Label|
|---|---|
|733400000|**Qualified**|
|733400001|**Disqualified**|
|733400002|**Undetected**|

### <a name="BKMK_msdyn_qualificationresultdetails"></a> msdyn_qualificationresultdetails

|Property|Value|
|---|---|
|Description||
|DisplayName|**Qualification Result Details**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_qualificationresultdetails`|
|RequiredLevel|None|
|Type|Memo|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|1048576|

### <a name="BKMK_msdyn_qualificationresultrank"></a> msdyn_qualificationresultrank

|Property|Value|
|---|---|
|Description||
|DisplayName|**Qualification Result Rank**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_qualificationresultrank`|
|RequiredLevel|None|
|Type|Picklist|
|DefaultFormValue|-1|
|GlobalChoiceName|`msdyn_leadagentresult_msdyn_qualificationresultrank`|

#### msdyn_qualificationresultrank Choices/Options

|Value|Label|
|---|---|
|733390000|**High**|
|733390001|**Medium**|
|733390002|**Low**|
|733390003|**No Match**|

### <a name="BKMK_msdyn_qualificationstandards"></a> msdyn_qualificationstandards

|Property|Value|
|---|---|
|Description|**JSON data containing detailed qualification standards information**|
|DisplayName|**Qualification standards**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_qualificationstandards`|
|RequiredLevel|None|
|Type|Memo|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|1048576|

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
|Description|**Status of the Lead Agent Result**|
|DisplayName|**Status**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statecode`|
|RequiredLevel|SystemRequired|
|Type|State|
|DefaultFormValue||
|GlobalChoiceName|`msdyn_leadagentresult_statecode`|

#### statecode Choices/Options

|Value|Details|
|---|---|
|0|Label: **Active**<br />DefaultStatus: 1<br />InvariantName: `Active`|
|1|Label: **Inactive**<br />DefaultStatus: 2<br />InvariantName: `Inactive`|

### <a name="BKMK_statuscode"></a> statuscode

|Property|Value|
|---|---|
|Description|**Reason for the status of the Lead Agent Result**|
|DisplayName|**Status Reason**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statuscode`|
|RequiredLevel|None|
|Type|Status|
|DefaultFormValue||
|GlobalChoiceName|`msdyn_leadagentresult_statuscode`|

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

- [business_unit_msdyn_leadagentresult](#BKMK_business_unit_msdyn_leadagentresult)
- [lk_msdyn_leadagentresult_createdby](#BKMK_lk_msdyn_leadagentresult_createdby)
- [lk_msdyn_leadagentresult_createdonbehalfby](#BKMK_lk_msdyn_leadagentresult_createdonbehalfby)
- [lk_msdyn_leadagentresult_modifiedby](#BKMK_lk_msdyn_leadagentresult_modifiedby)
- [lk_msdyn_leadagentresult_modifiedonbehalfby](#BKMK_lk_msdyn_leadagentresult_modifiedonbehalfby)
- [msdyn_leadagentresult_leadid](#BKMK_msdyn_leadagentresult_leadid)
- [owner_msdyn_leadagentresult](#BKMK_owner_msdyn_leadagentresult)
- [team_msdyn_leadagentresult](#BKMK_team_msdyn_leadagentresult)
- [user_msdyn_leadagentresult](#BKMK_user_msdyn_leadagentresult)

### <a name="BKMK_business_unit_msdyn_leadagentresult"></a> business_unit_msdyn_leadagentresult

One-To-Many Relationship: [businessunit business_unit_msdyn_leadagentresult](businessunit.md#BKMK_business_unit_msdyn_leadagentresult)

|Property|Value|
|---|---|
|ReferencedEntity|`businessunit`|
|ReferencedAttribute|`businessunitid`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencingEntityNavigationPropertyName|`owningbusinessunit`|
|IsHierarchical||
|CascadeConfiguration|Archive: `Restrict`<br />Assign: `NoCascade`<br />Delete: `Restrict`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_leadagentresult_createdby"></a> lk_msdyn_leadagentresult_createdby

One-To-Many Relationship: [systemuser lk_msdyn_leadagentresult_createdby](systemuser.md#BKMK_lk_msdyn_leadagentresult_createdby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdby`|
|ReferencingEntityNavigationPropertyName|`createdby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_leadagentresult_createdonbehalfby"></a> lk_msdyn_leadagentresult_createdonbehalfby

One-To-Many Relationship: [systemuser lk_msdyn_leadagentresult_createdonbehalfby](systemuser.md#BKMK_lk_msdyn_leadagentresult_createdonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdonbehalfby`|
|ReferencingEntityNavigationPropertyName|`createdonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_leadagentresult_modifiedby"></a> lk_msdyn_leadagentresult_modifiedby

One-To-Many Relationship: [systemuser lk_msdyn_leadagentresult_modifiedby](systemuser.md#BKMK_lk_msdyn_leadagentresult_modifiedby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedby`|
|ReferencingEntityNavigationPropertyName|`modifiedby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_leadagentresult_modifiedonbehalfby"></a> lk_msdyn_leadagentresult_modifiedonbehalfby

One-To-Many Relationship: [systemuser lk_msdyn_leadagentresult_modifiedonbehalfby](systemuser.md#BKMK_lk_msdyn_leadagentresult_modifiedonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedonbehalfby`|
|ReferencingEntityNavigationPropertyName|`modifiedonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_leadagentresult_leadid"></a> msdyn_leadagentresult_leadid

One-To-Many Relationship: [lead msdyn_leadagentresult_leadid](lead.md#BKMK_msdyn_leadagentresult_leadid)

|Property|Value|
|---|---|
|ReferencedEntity|`lead`|
|ReferencedAttribute|`leadid`|
|ReferencingAttribute|`msdyn_leadid`|
|ReferencingEntityNavigationPropertyName|`msdyn_leadid_lead`|
|IsHierarchical||
|CascadeConfiguration|Archive: `RemoveLink`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `Cascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_owner_msdyn_leadagentresult"></a> owner_msdyn_leadagentresult

One-To-Many Relationship: [owner owner_msdyn_leadagentresult](owner.md#BKMK_owner_msdyn_leadagentresult)

|Property|Value|
|---|---|
|ReferencedEntity|`owner`|
|ReferencedAttribute|`ownerid`|
|ReferencingAttribute|`ownerid`|
|ReferencingEntityNavigationPropertyName|`ownerid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_team_msdyn_leadagentresult"></a> team_msdyn_leadagentresult

One-To-Many Relationship: [team team_msdyn_leadagentresult](team.md#BKMK_team_msdyn_leadagentresult)

|Property|Value|
|---|---|
|ReferencedEntity|`team`|
|ReferencedAttribute|`teamid`|
|ReferencingAttribute|`owningteam`|
|ReferencingEntityNavigationPropertyName|`owningteam`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_user_msdyn_leadagentresult"></a> user_msdyn_leadagentresult

One-To-Many Relationship: [systemuser user_msdyn_leadagentresult](systemuser.md#BKMK_user_msdyn_leadagentresult)

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

- [msdyn_leadagentresult_AsyncOperations](#BKMK_msdyn_leadagentresult_AsyncOperations)
- [msdyn_leadagentresult_BulkDeleteFailures](#BKMK_msdyn_leadagentresult_BulkDeleteFailures)
- [msdyn_leadagentresult_DuplicateBaseRecord](#BKMK_msdyn_leadagentresult_DuplicateBaseRecord)
- [msdyn_leadagentresult_DuplicateMatchingRecord](#BKMK_msdyn_leadagentresult_DuplicateMatchingRecord)
- [msdyn_leadagentresult_MailboxTrackingFolders](#BKMK_msdyn_leadagentresult_MailboxTrackingFolders)
- [msdyn_leadagentresult_PrincipalObjectAttributeAccesses](#BKMK_msdyn_leadagentresult_PrincipalObjectAttributeAccesses)
- [msdyn_leadagentresult_ProcessSession](#BKMK_msdyn_leadagentresult_ProcessSession)
- [msdyn_leadagentresult_SyncErrors](#BKMK_msdyn_leadagentresult_SyncErrors)

### <a name="BKMK_msdyn_leadagentresult_AsyncOperations"></a> msdyn_leadagentresult_AsyncOperations

Many-To-One Relationship: [asyncoperation msdyn_leadagentresult_AsyncOperations](asyncoperation.md#BKMK_msdyn_leadagentresult_AsyncOperations)

|Property|Value|
|---|---|
|ReferencingEntity|`asyncoperation`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_leadagentresult_AsyncOperations`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_leadagentresult_BulkDeleteFailures"></a> msdyn_leadagentresult_BulkDeleteFailures

Many-To-One Relationship: [bulkdeletefailure msdyn_leadagentresult_BulkDeleteFailures](bulkdeletefailure.md#BKMK_msdyn_leadagentresult_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencingEntity|`bulkdeletefailure`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_leadagentresult_BulkDeleteFailures`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_leadagentresult_DuplicateBaseRecord"></a> msdyn_leadagentresult_DuplicateBaseRecord

Many-To-One Relationship: [duplicaterecord msdyn_leadagentresult_DuplicateBaseRecord](duplicaterecord.md#BKMK_msdyn_leadagentresult_DuplicateBaseRecord)

|Property|Value|
|---|---|
|ReferencingEntity|`duplicaterecord`|
|ReferencingAttribute|`baserecordid`|
|ReferencedEntityNavigationPropertyName|`msdyn_leadagentresult_DuplicateBaseRecord`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_leadagentresult_DuplicateMatchingRecord"></a> msdyn_leadagentresult_DuplicateMatchingRecord

Many-To-One Relationship: [duplicaterecord msdyn_leadagentresult_DuplicateMatchingRecord](duplicaterecord.md#BKMK_msdyn_leadagentresult_DuplicateMatchingRecord)

|Property|Value|
|---|---|
|ReferencingEntity|`duplicaterecord`|
|ReferencingAttribute|`duplicaterecordid`|
|ReferencedEntityNavigationPropertyName|`msdyn_leadagentresult_DuplicateMatchingRecord`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_leadagentresult_MailboxTrackingFolders"></a> msdyn_leadagentresult_MailboxTrackingFolders

Many-To-One Relationship: [mailboxtrackingfolder msdyn_leadagentresult_MailboxTrackingFolders](mailboxtrackingfolder.md#BKMK_msdyn_leadagentresult_MailboxTrackingFolders)

|Property|Value|
|---|---|
|ReferencingEntity|`mailboxtrackingfolder`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_leadagentresult_MailboxTrackingFolders`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_leadagentresult_PrincipalObjectAttributeAccesses"></a> msdyn_leadagentresult_PrincipalObjectAttributeAccesses

Many-To-One Relationship: [principalobjectattributeaccess msdyn_leadagentresult_PrincipalObjectAttributeAccesses](principalobjectattributeaccess.md#BKMK_msdyn_leadagentresult_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencingEntity|`principalobjectattributeaccess`|
|ReferencingAttribute|`objectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_leadagentresult_PrincipalObjectAttributeAccesses`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_leadagentresult_ProcessSession"></a> msdyn_leadagentresult_ProcessSession

Many-To-One Relationship: [processsession msdyn_leadagentresult_ProcessSession](processsession.md#BKMK_msdyn_leadagentresult_ProcessSession)

|Property|Value|
|---|---|
|ReferencingEntity|`processsession`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_leadagentresult_ProcessSession`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_leadagentresult_SyncErrors"></a> msdyn_leadagentresult_SyncErrors

Many-To-One Relationship: [syncerror msdyn_leadagentresult_SyncErrors](syncerror.md#BKMK_msdyn_leadagentresult_SyncErrors)

|Property|Value|
|---|---|
|ReferencingEntity|`syncerror`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_leadagentresult_SyncErrors`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|



### See also

[Dataverse table/entity reference](/power-apps/developer/data-platform/reference/about-entity-reference)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   

