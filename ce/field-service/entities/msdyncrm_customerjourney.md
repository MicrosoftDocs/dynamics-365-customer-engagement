---
title: "Customer journey (msdyncrm_customerjourney) table/entity reference (Microsoft Dynamics 365 Field Service)"
description: "Includes schema information and supported messages for the Customer journey (msdyncrm_customerjourney) table/entity with Microsoft Dynamics 365 Field Service."
ms.date: 07.24.2024
ms.service: powerapps
ms.topic: reference
author: m-hartmann
ms.author: mhart
search.audienceType: 
  - developer
---

# Customer journey (msdyncrm_customerjourney) table/entity reference



## Messages

The following table lists the messages for the Customer journey (msdyncrm_customerjourney) table.
Messages represent operations that can be performed on the table. They may also be events.

| Name <br />Is Event? |Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `Assign`<br />Event: True |`PATCH` /msdyncrm_customerjourneys(*msdyncrm_customerjourneyid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `ownerid` property. |<xref:Microsoft.Crm.Sdk.Messages.AssignRequest>|
| `Create`<br />Event: True |`POST` /msdyncrm_customerjourneys<br />See [Create](/powerapps/developer/data-platform/webapi/create-entity-web-api) |[Create records](/power-apps/developer/data-platform/org-service/entity-operations-create#basic-create)|
| `CreateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.CreateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.CreateMultipleRequest>|
| `Delete`<br />Event: True |`DELETE` /msdyncrm_customerjourneys(*msdyncrm_customerjourneyid*)<br />See [Delete](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-delete) |[Delete records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-delete)|
| `GrantAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.GrantAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.GrantAccessRequest>|
| `IsValidStateTransition`<br />Event: False |<xref:Microsoft.Dynamics.CRM.IsValidStateTransition?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.IsValidStateTransitionRequest>|
| `ModifyAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.ModifyAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.ModifyAccessRequest>|
| `Restore`<br />Event: True |<xref:Microsoft.Dynamics.CRM.Restore?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retrieve`<br />Event: True |`GET` /msdyncrm_customerjourneys(*msdyncrm_customerjourneyid*)<br />See [Retrieve](/powerapps/developer/data-platform/webapi/retrieve-entity-using-web-api) |[Retrieve records](/power-apps/developer/data-platform/org-service/entity-operations-retrieve)|
| `RetrieveMultiple`<br />Event: True |`GET` /msdyncrm_customerjourneys<br />See [Query data](/power-apps/developer/data-platform/webapi/query-data-web-api) |[Query data](/power-apps/developer/data-platform/org-service/entity-operations-query-data)|
| `RetrievePrincipalAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RetrievePrincipalAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RetrievePrincipalAccessRequest>|
| `RetrieveSharedPrincipalsAndAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RetrieveSharedPrincipalsAndAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RetrieveSharedPrincipalsAndAccessRequest>|
| `RevokeAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RevokeAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RevokeAccessRequest>|
| `SetState`<br />Event: True |`PATCH` /msdyncrm_customerjourneys(*msdyncrm_customerjourneyid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `statecode` and `statuscode` properties. |<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|
| `Update`<br />Event: True |`PATCH` /msdyncrm_customerjourneys(*msdyncrm_customerjourneyid*)<br />See [Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) |[Update records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-update)|
| `UpdateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.UpdateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpdateMultipleRequest>|
| `Upsert`<br />Event: False |`PATCH` /msdyncrm_customerjourneys(*msdyncrm_customerjourneyid*)<br />See [Upsert a table row](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#upsert-a-table-row) |<xref:Microsoft.Xrm.Sdk.Messages.UpsertRequest>|
| `UpsertMultiple`<br />Event: False |<xref:Microsoft.Dynamics.CRM.UpsertMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpsertMultipleRequest>|


## Events

The following table lists the events for the Customer journey (msdyncrm_customerjourney) table.
Events are messages that exist so that you can subscribe to them. Unless you added the event, you shouldn't invoke the message, only subscribe to it.

|Name|Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `BulkRetain`|<xref:Microsoft.Dynamics.CRM.BulkRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `PurgeRetainedContent`|<xref:Microsoft.Dynamics.CRM.PurgeRetainedContent?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retain`|<xref:Microsoft.Dynamics.CRM.Retain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `RollbackRetain`|<xref:Microsoft.Dynamics.CRM.RollbackRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `ValidateRetentionConfig`|<xref:Microsoft.Dynamics.CRM.ValidateRetentionConfig?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|

## Properties

The following table lists selected properties for the Customer journey (msdyncrm_customerjourney) table.

|Property|Value|
| --- | --- |
| **DisplayName** | **Customer journey** |
| **DisplayCollectionName** | **Customer journeys** |
| **SchemaName** | `msdyncrm_customerjourney` |
| **CollectionSchemaName** | `msdyncrm_customerjourneies` |
| **EntitySetName** | `msdyncrm_customerjourneys`|
| **LogicalName** | `msdyncrm_customerjourney` |
| **LogicalCollectionName** | `msdyncrm_customerjourneies` |
| **PrimaryIdAttribute** | `msdyncrm_customerjourneyid` |
| **PrimaryNameAttribute** |`msdyncrm_name` |
| **TableType** | `Standard` |
| **OwnershipType** | `UserOwned` |

## Writable columns/attributes

These columns/attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [msdyncr2_LinkedInCampaign](#BKMK_msdyncr2_LinkedInCampaign)
- [msdyncrm_ContentSettingsId](#BKMK_msdyncrm_ContentSettingsId)
- [msdyncrm_CustomerJourneyDesignerState](#BKMK_msdyncrm_CustomerJourneyDesignerState)
- [msdyncrm_customerjourneyId](#BKMK_msdyncrm_customerjourneyId)
- [msdyncrm_CustomerJourneyTemplate](#BKMK_msdyncrm_CustomerJourneyTemplate)
- [msdyncrm_CustomerJourneyTimeZone](#BKMK_msdyncrm_CustomerJourneyTimeZone)
- [msdyncrm_description](#BKMK_msdyncrm_description)
- [msdyncrm_EndDateTime](#BKMK_msdyncrm_EndDateTime)
- [msdyncrm_entitytarget](#BKMK_msdyncrm_entitytarget)
- [msdyncrm_insights_placeholder](#BKMK_msdyncrm_insights_placeholder)
- [msdyncrm_IsRecurring](#BKMK_msdyncrm_IsRecurring)
- [msdyncrm_lockdowndateinmilliseconds](#BKMK_msdyncrm_lockdowndateinmilliseconds)
- [msdyncrm_name](#BKMK_msdyncrm_name)
- [msdyncrm_publishedby](#BKMK_msdyncrm_publishedby)
- [msdyncrm_purpose](#BKMK_msdyncrm_purpose)
- [msdyncrm_RecurrenceCount](#BKMK_msdyncrm_RecurrenceCount)
- [msdyncrm_RecurrenceIntervalDays](#BKMK_msdyncrm_RecurrenceIntervalDays)
- [msdyncrm_scope](#BKMK_msdyncrm_scope)
- [msdyncrm_StartDateTime](#BKMK_msdyncrm_StartDateTime)
- [msdyncrm_SuppressionSegmentId](#BKMK_msdyncrm_SuppressionSegmentId)
- [msdyncrm_Type](#BKMK_msdyncrm_Type)
- [msdyncrm_ValidationResults](#BKMK_msdyncrm_ValidationResults)
- [msdyncrm_WorkflowDefinition](#BKMK_msdyncrm_WorkflowDefinition)
- [msgdpr_requiredconsent](#BKMK_msgdpr_requiredconsent)
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
|Description|**Sequence number of the import that created this record**|
|DisplayName|**Import sequence number**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`importsequencenumber`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|-2147483648|

### <a name="BKMK_msdyncr2_LinkedInCampaign"></a> msdyncr2_LinkedInCampaign

|Property|Value|
|---|---|
|Description|**Link to LinkedIn**|
|DisplayName|**LinkedIn campaign**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncr2_linkedincampaign`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|msdyncrm_linkedincampaign|

### <a name="BKMK_msdyncrm_ContentSettingsId"></a> msdyncrm_ContentSettingsId

|Property|Value|
|---|---|
|Description|**Content settings that apply to this customer journey**|
|DisplayName|**Content settings**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_contentsettingsid`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|msdyncrm_contentsettings|

### <a name="BKMK_msdyncrm_CustomerJourneyDesignerState"></a> msdyncrm_CustomerJourneyDesignerState

|Property|Value|
|---|---|
|Description|**The state of customer journey**|
|DisplayName|**Customer journey designer state**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_customerjourneydesignerstate`|
|RequiredLevel|None|
|Type|Memo|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100000|

### <a name="BKMK_msdyncrm_customerjourneyId"></a> msdyncrm_customerjourneyId

|Property|Value|
|---|---|
|Description|**Unique ID for entity instances**|
|DisplayName|**Customer journey**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`msdyncrm_customerjourneyid`|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|

### <a name="BKMK_msdyncrm_CustomerJourneyTemplate"></a> msdyncrm_CustomerJourneyTemplate

|Property|Value|
|---|---|
|Description|**The template used to create the initial layout of the customer journey**|
|DisplayName|**Customer journey template**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_customerjourneytemplate`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|msdyncrm_customerjourneytemplate|

### <a name="BKMK_msdyncrm_CustomerJourneyTimeZone"></a> msdyncrm_CustomerJourneyTimeZone

|Property|Value|
|---|---|
|Description|**Effective time zone for this customer journey**|
|DisplayName|**Time zone**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_customerjourneytimezone`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|1500|
|MinValue|-1500|

### <a name="BKMK_msdyncrm_description"></a> msdyncrm_description

|Property|Value|
|---|---|
|Description|**Enter additional information to describe this customer journey**|
|DisplayName|**Description**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_description`|
|RequiredLevel|None|
|Type|Memo|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|5000|

### <a name="BKMK_msdyncrm_EndDateTime"></a> msdyncrm_EndDateTime

|Property|Value|
|---|---|
|Description|**The end date of customer journey**|
|DisplayName|**End date and time**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_enddatetime`|
|RequiredLevel|None|
|Type|DateTime|
|CanChangeDateTimeBehavior|True|
|DateTimeBehavior|TimeZoneIndependent|
|Format|DateAndTime|
|ImeMode|Auto|
|SourceTypeMask|0|

### <a name="BKMK_msdyncrm_entitytarget"></a> msdyncrm_entitytarget

|Property|Value|
|---|---|
|Description|**Tells which is the entity target**|
|DisplayName|**Target**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_entitytarget`|
|RequiredLevel|ApplicationRequired|
|Type|Picklist|
|DefaultFormValue|0|
|GlobalChoiceName|`msdyncrm_customerjourney_msdyncrm_entitytarget`|

#### msdyncrm_entitytarget Choices/Options

|Value|Label|
|---|---|
|0|**Contact**|
|1|**Account**|

### <a name="BKMK_msdyncrm_insights_placeholder"></a> msdyncrm_insights_placeholder

|Property|Value|
|---|---|
|Description||
|DisplayName|**Insights**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_insights_placeholder`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdyncrm_IsRecurring"></a> msdyncrm_IsRecurring

|Property|Value|
|---|---|
|Description|**Tells whether the customer journey is recurring**|
|DisplayName|**Is recurring**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_isrecurring`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`msdyncrm_customerjourney_msdyncrm_isrecurring`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_msdyncrm_lockdowndateinmilliseconds"></a> msdyncrm_lockdowndateinmilliseconds

|Property|Value|
|---|---|
|Description|**Lockdown date in milliseconds (Unix format).**|
|DisplayName|**Lockdown date in milliseconds**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`msdyncrm_lockdowndateinmilliseconds`|
|RequiredLevel|None|
|Type|BigInt|
|MaxValue|9223372036854775807|
|MinValue|-9223372036854775808|

### <a name="BKMK_msdyncrm_name"></a> msdyncrm_name

|Property|Value|
|---|---|
|Description|**The name of the customer journey**|
|DisplayName|**Name**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_name`|
|RequiredLevel|ApplicationRequired|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdyncrm_publishedby"></a> msdyncrm_publishedby

|Property|Value|
|---|---|
|Description|**Indicates the person who published this.**|
|DisplayName|**Published by**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_publishedby`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|systemuser|

### <a name="BKMK_msdyncrm_purpose"></a> msdyncrm_purpose

|Property|Value|
|---|---|
|Description||
|DisplayName|**Purpose**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_purpose`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|1000|

### <a name="BKMK_msdyncrm_RecurrenceCount"></a> msdyncrm_RecurrenceCount

|Property|Value|
|---|---|
|Description|**The number of iterations**|
|DisplayName|**Recurrence count**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_recurrencecount`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|0|

### <a name="BKMK_msdyncrm_RecurrenceIntervalDays"></a> msdyncrm_RecurrenceIntervalDays

|Property|Value|
|---|---|
|Description|**The duration of the iteration (in days)**|
|DisplayName|**Recurrence interval (days)**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_recurrenceintervaldays`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|0|

### <a name="BKMK_msdyncrm_scope"></a> msdyncrm_scope

|Property|Value|
|---|---|
|Description|**Scope for the customer journey execution**|
|DisplayName|**Scope**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_scope`|
|RequiredLevel|None|
|Type|Picklist|
|DefaultFormValue|270100000|
|GlobalChoiceName|`msdyncrm_processscope`|

#### msdyncrm_scope Choices/Options

|Value|Label|
|---|---|
|270100000|**Organization**|
|270100001|**Business unit**|

### <a name="BKMK_msdyncrm_StartDateTime"></a> msdyncrm_StartDateTime

|Property|Value|
|---|---|
|Description|**The start date of the customer journey**|
|DisplayName|**Start date and time**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_startdatetime`|
|RequiredLevel|None|
|Type|DateTime|
|CanChangeDateTimeBehavior|True|
|DateTimeBehavior|TimeZoneIndependent|
|Format|DateAndTime|
|ImeMode|Auto|
|SourceTypeMask|0|

### <a name="BKMK_msdyncrm_SuppressionSegmentId"></a> msdyncrm_SuppressionSegmentId

|Property|Value|
|---|---|
|Description|**A segment that defines a list of contacts excluded from this customer journey**|
|DisplayName|**Suppression segment**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_suppressionsegmentid`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|msdyncrm_segment|

### <a name="BKMK_msdyncrm_Type"></a> msdyncrm_Type

|Property|Value|
|---|---|
|Description||
|DisplayName|**Type**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_type`|
|RequiredLevel|None|
|Type|Picklist|
|DefaultFormValue|192350000|
|GlobalChoiceName|`msdyncrm_customerjourney_msdyncrm_type`|

#### msdyncrm_Type Choices/Options

|Value|Label|
|---|---|
|192350000|**Automated**|
|192350001|**LinkedIn**|

### <a name="BKMK_msdyncrm_ValidationResults"></a> msdyncrm_ValidationResults

|Property|Value|
|---|---|
|Description||
|DisplayName|**Error check results**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_validationresults`|
|RequiredLevel|None|
|Type|Memo|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|1048576|

### <a name="BKMK_msdyncrm_WorkflowDefinition"></a> msdyncrm_WorkflowDefinition

|Property|Value|
|---|---|
|Description|**The customer journey design definition**|
|DisplayName|**Workflow definition**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_workflowdefinition`|
|RequiredLevel|None|
|Type|Memo|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|1048576|

### <a name="BKMK_msgdpr_requiredconsent"></a> msgdpr_requiredconsent

|Property|Value|
|---|---|
|Description||
|DisplayName|**Minimum consent**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msgdpr_requiredconsent`|
|RequiredLevel|None|
|Type|Picklist|
|DefaultFormValue|-1|
|GlobalChoiceName|`msgdpr_gdpr_consent_option_set`|

#### msgdpr_requiredconsent Choices/Options

|Value|Label|
|---|---|
|587030001|**(1) Consent**|
|587030002|**(2) Transactional**|
|587030003|**(3) Subscriptions**|
|587030004|**(4) Marketing**|
|587030005|**(5) Profiling**|

### <a name="BKMK_OverriddenCreatedOn"></a> OverriddenCreatedOn

|Property|Value|
|---|---|
|Description|**Date and time that the record was migrated**|
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

### <a name="BKMK_OwnerId"></a> OwnerId

|Property|Value|
|---|---|
|Description|**Owner ID**|
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
|Description|**Status of the customer journey**|
|DisplayName|**Status**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statecode`|
|RequiredLevel|SystemRequired|
|Type|State|
|DefaultFormValue||
|GlobalChoiceName|`msdyncrm_customerjourney_statecode`|

#### statecode Choices/Options

|Value|Details|
|---|---|
|0|Label: **Active**<br />DefaultStatus: 192350000<br />InvariantName: `Active`|
|1|Label: **Inactive**<br />DefaultStatus: 192350004<br />InvariantName: `Inactive`|

### <a name="BKMK_statuscode"></a> statuscode

|Property|Value|
|---|---|
|Description|**Reason for the status of the customer journey**|
|DisplayName|**Status reason**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statuscode`|
|RequiredLevel|None|
|Type|Status|
|DefaultFormValue||
|GlobalChoiceName|`msdyncrm_customerjourney_statuscode`|

#### statuscode Choices/Options

|Value|Details|
|---|---|
|192350000|Label: **Draft**<br />State:0<br />TransitionData:<br />`<allowedtransitions xmlns="http://schemas.microsoft.com/crm/2009/WebServices"><allowedtransition sourcestatusid="192350000" tostatusid="192350006" /><allowedtransition sourcestatusid="192350000" tostatusid="192350004" /></allowedtransitions>`|
|192350001|Label: **Live**<br />State:0<br />TransitionData:<br />`<allowedtransitions xmlns="http://schemas.microsoft.com/crm/2009/WebServices"><allowedtransition sourcestatusid="192350001" tostatusid="192350007" /><allowedtransition sourcestatusid="192350001" tostatusid="192350002" /><allowedtransition sourcestatusid="192350001" tostatusid="192350006" /><allowedtransition sourcestatusid="192350001" tostatusid="192350003" /><allowedtransition sourcestatusid="192350001" tostatusid="192350005" /></allowedtransitions>`|
|192350002|Label: **Stopped**<br />State:0<br />TransitionData:<br />`<allowedtransitions xmlns="http://schemas.microsoft.com/crm/2009/WebServices"><allowedtransition sourcestatusid="192350002" tostatusid="192350004" /><allowedtransition sourcestatusid="192350002" tostatusid="192350006" /></allowedtransitions>`|
|192350003|Label: **Live, editable**<br />State:0<br />TransitionData:<br />`<allowedtransitions xmlns="http://schemas.microsoft.com/crm/2009/WebServices"><allowedtransition sourcestatusid="192350003" tostatusid="192350001" /><allowedtransition sourcestatusid="192350003" tostatusid="192350005" /><allowedtransition sourcestatusid="192350003" tostatusid="192350006" /></allowedtransitions>`|
|192350004|Label: **Expired**<br />State:1<br />TransitionData: None|
|192350005|Label: **Error**<br />State:0<br />TransitionData:<br />`<allowedtransitions xmlns="http://schemas.microsoft.com/crm/2009/WebServices"><allowedtransition sourcestatusid="192350005" tostatusid="192350006" /><allowedtransition sourcestatusid="192350005" tostatusid="192350007" /></allowedtransitions>`|
|192350006|Label: **Going live**<br />State:0<br />TransitionData:<br />`<allowedtransitions xmlns="http://schemas.microsoft.com/crm/2009/WebServices"><allowedtransition sourcestatusid="192350006" tostatusid="192350001" /><allowedtransition sourcestatusid="192350006" tostatusid="192350005" /></allowedtransitions>`|
|192350007|Label: **Stopping...**<br />State:0<br />TransitionData:<br />`<allowedtransitions xmlns="http://schemas.microsoft.com/crm/2009/WebServices"><allowedtransition sourcestatusid="192350007" tostatusid="192350002" /><allowedtransition sourcestatusid="192350007" tostatusid="192350005" /></allowedtransitions>`|

### <a name="BKMK_TimeZoneRuleVersionNumber"></a> TimeZoneRuleVersionNumber

|Property|Value|
|---|---|
|Description|**For internal use only**|
|DisplayName|**Time-zone rule version number**|
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
|Description|**Time-zone code that was in use when the record was created**|
|DisplayName|**UTC conversion time-zone code**|
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
- [msdyncrm_formtosave](#BKMK_msdyncrm_formtosave)
- [OwnerIdName](#BKMK_OwnerIdName)
- [OwnerIdYomiName](#BKMK_OwnerIdYomiName)
- [OwningBusinessUnit](#BKMK_OwningBusinessUnit)
- [OwningTeam](#BKMK_OwningTeam)
- [OwningUser](#BKMK_OwningUser)
- [VersionNumber](#BKMK_VersionNumber)

### <a name="BKMK_CreatedBy"></a> CreatedBy

|Property|Value|
|---|---|
|Description|**Indicates the person who created this.**|
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
|Description|**Indicates the person who created this for another person.**|
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
|Description|**Indicates the person who modified this.**|
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
|Description|**Indicates the person who modified this for another person.**|
|DisplayName|**Modified by (delegate)**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`modifiedonbehalfby`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|systemuser|

### <a name="BKMK_msdyncrm_formtosave"></a> msdyncrm_formtosave

|Property|Value|
|---|---|
|Description|**Form to save**|
|DisplayName|**Form to save**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_formtosave`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`msdyncrm_customerjourney_formtosave`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

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
|Description|**Indicates the business unit that owns this.**|
|DisplayName|**Owning business unit**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`owningbusinessunit`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|businessunit|

### <a name="BKMK_OwningTeam"></a> OwningTeam

|Property|Value|
|---|---|
|Description|**Indicates the team that owns this.**|
|DisplayName|**Owning team**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`owningteam`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|team|

### <a name="BKMK_OwningUser"></a> OwningUser

|Property|Value|
|---|---|
|Description|**Indicates the person who owns this.**|
|DisplayName|**Owning user**|
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

- [business_unit_msdyncrm_customerjourney](#BKMK_business_unit_msdyncrm_customerjourney)
- [lk_msdyncrm_customerjourney_createdby](#BKMK_lk_msdyncrm_customerjourney_createdby)
- [lk_msdyncrm_customerjourney_createdonbehalfby](#BKMK_lk_msdyncrm_customerjourney_createdonbehalfby)
- [lk_msdyncrm_customerjourney_modifiedby](#BKMK_lk_msdyncrm_customerjourney_modifiedby)
- [lk_msdyncrm_customerjourney_modifiedonbehalfby](#BKMK_lk_msdyncrm_customerjourney_modifiedonbehalfby)
- [lk_msdyncrm_customerjourney_msdyncrm_publishedby](#BKMK_lk_msdyncrm_customerjourney_msdyncrm_publishedby)
- [msdyncr2_msdyncrm_linkedincampaign_msdyncrm_customerjourney_LinkedInCampaign](#BKMK_msdyncr2_msdyncrm_linkedincampaign_msdyncrm_customerjourney_LinkedInCampaign)
- [msdyncrm_msdyncrm_contentsettings_msdyncrm_customerjourney_contentsettingsid](#BKMK_msdyncrm_msdyncrm_contentsettings_msdyncrm_customerjourney_contentsettingsid)
- [msdyncrm_msdyncrm_customerjourneytemplate_msdyncrm_customerjourney_CustomerJourneyTemplate](#BKMK_msdyncrm_msdyncrm_customerjourneytemplate_msdyncrm_customerjourney_CustomerJourneyTemplate)
- [msdyncrm_msdyncrm_segment_msdyncrm_customerjourney_SuppressionSegmentId](#BKMK_msdyncrm_msdyncrm_segment_msdyncrm_customerjourney_SuppressionSegmentId)
- [owner_msdyncrm_customerjourney](#BKMK_owner_msdyncrm_customerjourney)
- [team_msdyncrm_customerjourney](#BKMK_team_msdyncrm_customerjourney)
- [user_msdyncrm_customerjourney](#BKMK_user_msdyncrm_customerjourney)

### <a name="BKMK_business_unit_msdyncrm_customerjourney"></a> business_unit_msdyncrm_customerjourney

One-To-Many Relationship: [businessunit business_unit_msdyncrm_customerjourney](businessunit.md#BKMK_business_unit_msdyncrm_customerjourney)

|Property|Value|
|---|---|
|ReferencedEntity|`businessunit`|
|ReferencedAttribute|`businessunitid`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencingEntityNavigationPropertyName|`owningbusinessunit`|
|IsHierarchical||
|CascadeConfiguration|Archive: `Restrict`<br />Assign: `NoCascade`<br />Delete: `Restrict`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyncrm_customerjourney_createdby"></a> lk_msdyncrm_customerjourney_createdby

One-To-Many Relationship: [systemuser lk_msdyncrm_customerjourney_createdby](systemuser.md#BKMK_lk_msdyncrm_customerjourney_createdby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdby`|
|ReferencingEntityNavigationPropertyName|`createdby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyncrm_customerjourney_createdonbehalfby"></a> lk_msdyncrm_customerjourney_createdonbehalfby

One-To-Many Relationship: [systemuser lk_msdyncrm_customerjourney_createdonbehalfby](systemuser.md#BKMK_lk_msdyncrm_customerjourney_createdonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdonbehalfby`|
|ReferencingEntityNavigationPropertyName|`createdonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyncrm_customerjourney_modifiedby"></a> lk_msdyncrm_customerjourney_modifiedby

One-To-Many Relationship: [systemuser lk_msdyncrm_customerjourney_modifiedby](systemuser.md#BKMK_lk_msdyncrm_customerjourney_modifiedby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedby`|
|ReferencingEntityNavigationPropertyName|`modifiedby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyncrm_customerjourney_modifiedonbehalfby"></a> lk_msdyncrm_customerjourney_modifiedonbehalfby

One-To-Many Relationship: [systemuser lk_msdyncrm_customerjourney_modifiedonbehalfby](systemuser.md#BKMK_lk_msdyncrm_customerjourney_modifiedonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedonbehalfby`|
|ReferencingEntityNavigationPropertyName|`modifiedonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyncrm_customerjourney_msdyncrm_publishedby"></a> lk_msdyncrm_customerjourney_msdyncrm_publishedby

One-To-Many Relationship: [systemuser lk_msdyncrm_customerjourney_msdyncrm_publishedby](systemuser.md#BKMK_lk_msdyncrm_customerjourney_msdyncrm_publishedby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`msdyncrm_publishedby`|
|ReferencingEntityNavigationPropertyName|`msdyncrm_publishedby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyncr2_msdyncrm_linkedincampaign_msdyncrm_customerjourney_LinkedInCampaign"></a> msdyncr2_msdyncrm_linkedincampaign_msdyncrm_customerjourney_LinkedInCampaign

One-To-Many Relationship: [msdyncrm_linkedincampaign msdyncr2_msdyncrm_linkedincampaign_msdyncrm_customerjourney_LinkedInCampaign](msdyncrm_linkedincampaign.md#BKMK_msdyncr2_msdyncrm_linkedincampaign_msdyncrm_customerjourney_LinkedInCampaign)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyncrm_linkedincampaign`|
|ReferencedAttribute|`msdyncrm_linkedincampaignid`|
|ReferencingAttribute|`msdyncr2_linkedincampaign`|
|ReferencingEntityNavigationPropertyName|`msdyncr2_LinkedInCampaign`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyncrm_msdyncrm_contentsettings_msdyncrm_customerjourney_contentsettingsid"></a> msdyncrm_msdyncrm_contentsettings_msdyncrm_customerjourney_contentsettingsid

One-To-Many Relationship: [msdyncrm_contentsettings msdyncrm_msdyncrm_contentsettings_msdyncrm_customerjourney_contentsettingsid](msdyncrm_contentsettings.md#BKMK_msdyncrm_msdyncrm_contentsettings_msdyncrm_customerjourney_contentsettingsid)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyncrm_contentsettings`|
|ReferencedAttribute|`msdyncrm_contentsettingsid`|
|ReferencingAttribute|`msdyncrm_contentsettingsid`|
|ReferencingEntityNavigationPropertyName|`msdyncrm_contentsettingsId`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Restrict`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyncrm_msdyncrm_customerjourneytemplate_msdyncrm_customerjourney_CustomerJourneyTemplate"></a> msdyncrm_msdyncrm_customerjourneytemplate_msdyncrm_customerjourney_CustomerJourneyTemplate

One-To-Many Relationship: [msdyncrm_customerjourneytemplate msdyncrm_msdyncrm_customerjourneytemplate_msdyncrm_customerjourney_CustomerJourneyTemplate](msdyncrm_customerjourneytemplate.md#BKMK_msdyncrm_msdyncrm_customerjourneytemplate_msdyncrm_customerjourney_CustomerJourneyTemplate)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyncrm_customerjourneytemplate`|
|ReferencedAttribute|`msdyncrm_customerjourneytemplateid`|
|ReferencingAttribute|`msdyncrm_customerjourneytemplate`|
|ReferencingEntityNavigationPropertyName|`msdyncrm_CustomerJourneyTemplate`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyncrm_msdyncrm_segment_msdyncrm_customerjourney_SuppressionSegmentId"></a> msdyncrm_msdyncrm_segment_msdyncrm_customerjourney_SuppressionSegmentId

One-To-Many Relationship: [msdyncrm_segment msdyncrm_msdyncrm_segment_msdyncrm_customerjourney_SuppressionSegmentId](msdyncrm_segment.md#BKMK_msdyncrm_msdyncrm_segment_msdyncrm_customerjourney_SuppressionSegmentId)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyncrm_segment`|
|ReferencedAttribute|`msdyncrm_segmentid`|
|ReferencingAttribute|`msdyncrm_suppressionsegmentid`|
|ReferencingEntityNavigationPropertyName|`msdyncrm_SuppressionSegmentId`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Restrict`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_owner_msdyncrm_customerjourney"></a> owner_msdyncrm_customerjourney

One-To-Many Relationship: [owner owner_msdyncrm_customerjourney](owner.md#BKMK_owner_msdyncrm_customerjourney)

|Property|Value|
|---|---|
|ReferencedEntity|`owner`|
|ReferencedAttribute|`ownerid`|
|ReferencingAttribute|`ownerid`|
|ReferencingEntityNavigationPropertyName|`ownerid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_team_msdyncrm_customerjourney"></a> team_msdyncrm_customerjourney

One-To-Many Relationship: [team team_msdyncrm_customerjourney](team.md#BKMK_team_msdyncrm_customerjourney)

|Property|Value|
|---|---|
|ReferencedEntity|`team`|
|ReferencedAttribute|`teamid`|
|ReferencingAttribute|`owningteam`|
|ReferencingEntityNavigationPropertyName|`owningteam`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_user_msdyncrm_customerjourney"></a> user_msdyncrm_customerjourney

One-To-Many Relationship: [systemuser user_msdyncrm_customerjourney](systemuser.md#BKMK_user_msdyncrm_customerjourney)

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

- [msdyncr2_linkedinformsubmission_customerjourney](#BKMK_msdyncr2_linkedinformsubmission_customerjourney)
- [msdyncrm_customerjourney_ActivityPointers](#BKMK_msdyncrm_customerjourney_ActivityPointers)
- [msdyncrm_customerjourney_adx_alertsubscriptions](#BKMK_msdyncrm_customerjourney_adx_alertsubscriptions)
- [msdyncrm_customerjourney_adx_inviteredemptions](#BKMK_msdyncrm_customerjourney_adx_inviteredemptions)
- [msdyncrm_customerjourney_adx_portalcomments](#BKMK_msdyncrm_customerjourney_adx_portalcomments)
- [msdyncrm_customerjourney_Annotations](#BKMK_msdyncrm_customerjourney_Annotations)
- [msdyncrm_customerjourney_Appointments](#BKMK_msdyncrm_customerjourney_Appointments)
- [msdyncrm_customerjourney_AsyncOperations](#BKMK_msdyncrm_customerjourney_AsyncOperations)
- [msdyncrm_customerjourney_BulkDeleteFailures](#BKMK_msdyncrm_customerjourney_BulkDeleteFailures)
- [msdyncrm_customerjourney_chats](#BKMK_msdyncrm_customerjourney_chats)
- [msdyncrm_customerjourney_Emails](#BKMK_msdyncrm_customerjourney_Emails)
- [msdyncrm_customerjourney_Faxes](#BKMK_msdyncrm_customerjourney_Faxes)
- [msdyncrm_customerjourney_Feedback](#BKMK_msdyncrm_customerjourney_Feedback)
- [msdyncrm_customerjourney_Letters](#BKMK_msdyncrm_customerjourney_Letters)
- [msdyncrm_customerjourney_li_inmails](#BKMK_msdyncrm_customerjourney_li_inmails)
- [msdyncrm_customerjourney_li_messages](#BKMK_msdyncrm_customerjourney_li_messages)
- [msdyncrm_customerjourney_li_pointdrivepresentationvieweds](#BKMK_msdyncrm_customerjourney_li_pointdrivepresentationvieweds)
- [msdyncrm_customerjourney_MailboxTrackingFolders](#BKMK_msdyncrm_customerjourney_MailboxTrackingFolders)
- [msdyncrm_customerjourney_marketingformsubmission](#BKMK_msdyncrm_customerjourney_marketingformsubmission)
- [msdyncrm_customerjourney_msdyn_bookingalerts](#BKMK_msdyncrm_customerjourney_msdyn_bookingalerts)
- [msdyncrm_customerjourney_msdyn_copilottranscripts](#BKMK_msdyncrm_customerjourney_msdyn_copilottranscripts)
- [msdyncrm_customerjourney_msdyn_ocliveworkitems](#BKMK_msdyncrm_customerjourney_msdyn_ocliveworkitems)
- [msdyncrm_customerjourney_msdyn_ocoutboundmessages](#BKMK_msdyncrm_customerjourney_msdyn_ocoutboundmessages)
- [msdyncrm_customerjourney_msdyn_ocsessions](#BKMK_msdyncrm_customerjourney_msdyn_ocsessions)
- [msdyncrm_customerjourney_msdyn_ocvoicemails](#BKMK_msdyncrm_customerjourney_msdyn_ocvoicemails)
- [msdyncrm_customerjourney_msfp_alerts](#BKMK_msdyncrm_customerjourney_msfp_alerts)
- [msdyncrm_customerjourney_msfp_surveyinvites](#BKMK_msdyncrm_customerjourney_msfp_surveyinvites)
- [msdyncrm_customerjourney_msfp_surveyresponses](#BKMK_msdyncrm_customerjourney_msfp_surveyresponses)
- [msdyncrm_customerjourney_PhoneCalls](#BKMK_msdyncrm_customerjourney_PhoneCalls)
- [msdyncrm_customerjourney_PrincipalObjectAttributeAccesses](#BKMK_msdyncrm_customerjourney_PrincipalObjectAttributeAccesses)
- [msdyncrm_customerjourney_ProcessSession](#BKMK_msdyncrm_customerjourney_ProcessSession)
- [msdyncrm_customerjourney_RecurringAppointmentMasters](#BKMK_msdyncrm_customerjourney_RecurringAppointmentMasters)
- [msdyncrm_customerjourney_ServiceAppointments](#BKMK_msdyncrm_customerjourney_ServiceAppointments)
- [msdyncrm_customerjourney_SocialActivities](#BKMK_msdyncrm_customerjourney_SocialActivities)
- [msdyncrm_customerjourney_SyncErrors](#BKMK_msdyncrm_customerjourney_SyncErrors)
- [msdyncrm_customerjourney_Tasks](#BKMK_msdyncrm_customerjourney_Tasks)
- [msdyncrm_msdyncrm_customerjourney_contact_customerjourneyid](#BKMK_msdyncrm_msdyncrm_customerjourney_contact_customerjourneyid)
- [msdyncrm_msdyncrm_customerjourney_lead_customerjourneyid](#BKMK_msdyncrm_msdyncrm_customerjourney_lead_customerjourneyid)
- [msdyncrm_msdyncrm_customerjourney_msdyncrm_custome](#BKMK_msdyncrm_msdyncrm_customerjourney_msdyncrm_custome)
- [msdyncrm_msdyncrm_customerjourney_msdyncrm_customerjourneycustomchannelactivity_customerjourney](#BKMK_msdyncrm_msdyncrm_customerjourney_msdyncrm_customerjourneycustomchannelactivity_customerjourney)
- [msdyncrm_msdyncrm_customerjourney_msdyncrm_customerjourneyiteration_customerjourneyid](#BKMK_msdyncrm_msdyncrm_customerjourney_msdyncrm_customerjourneyiteration_customerjourneyid)
- [msdyncrm_msdyncrm_customerjourney_msdyncrm_customerjourneytemplate_Origin](#BKMK_msdyncrm_msdyncrm_customerjourney_msdyncrm_customerjourneytemplate_Origin)
- [msdyncrm_msdyncrm_customerjourney_msdyncrm_geopin_customerJourney](#BKMK_msdyncrm_msdyncrm_customerjourney_msdyncrm_geopin_customerJourney)

### <a name="BKMK_msdyncr2_linkedinformsubmission_customerjourney"></a> msdyncr2_linkedinformsubmission_customerjourney

Many-To-One Relationship: [msdyncrm_linkedinformsubmission msdyncr2_linkedinformsubmission_customerjourney](msdyncrm_linkedinformsubmission.md#BKMK_msdyncr2_linkedinformsubmission_customerjourney)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyncrm_linkedinformsubmission`|
|ReferencingAttribute|`msdyncr2_customerjourney`|
|ReferencedEntityNavigationPropertyName|`msdyncr2_linkedinformsubmission_customerjourney`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_customerjourney_ActivityPointers"></a> msdyncrm_customerjourney_ActivityPointers

Many-To-One Relationship: [activitypointer msdyncrm_customerjourney_ActivityPointers](activitypointer.md#BKMK_msdyncrm_customerjourney_ActivityPointers)

|Property|Value|
|---|---|
|ReferencingEntity|`activitypointer`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_customerjourney_ActivityPointers`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_customerjourney_adx_alertsubscriptions"></a> msdyncrm_customerjourney_adx_alertsubscriptions

Many-To-One Relationship: [adx_alertsubscription msdyncrm_customerjourney_adx_alertsubscriptions](adx_alertsubscription.md#BKMK_msdyncrm_customerjourney_adx_alertsubscriptions)

|Property|Value|
|---|---|
|ReferencingEntity|`adx_alertsubscription`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_customerjourney_adx_alertsubscriptions`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_customerjourney_adx_inviteredemptions"></a> msdyncrm_customerjourney_adx_inviteredemptions

Many-To-One Relationship: [adx_inviteredemption msdyncrm_customerjourney_adx_inviteredemptions](adx_inviteredemption.md#BKMK_msdyncrm_customerjourney_adx_inviteredemptions)

|Property|Value|
|---|---|
|ReferencingEntity|`adx_inviteredemption`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_customerjourney_adx_inviteredemptions`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_customerjourney_adx_portalcomments"></a> msdyncrm_customerjourney_adx_portalcomments

Many-To-One Relationship: [adx_portalcomment msdyncrm_customerjourney_adx_portalcomments](adx_portalcomment.md#BKMK_msdyncrm_customerjourney_adx_portalcomments)

|Property|Value|
|---|---|
|ReferencingEntity|`adx_portalcomment`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_customerjourney_adx_portalcomments`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_customerjourney_Annotations"></a> msdyncrm_customerjourney_Annotations

Many-To-One Relationship: [annotation msdyncrm_customerjourney_Annotations](annotation.md#BKMK_msdyncrm_customerjourney_Annotations)

|Property|Value|
|---|---|
|ReferencingEntity|`annotation`|
|ReferencingAttribute|`objectid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_customerjourney_Annotations`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_customerjourney_Appointments"></a> msdyncrm_customerjourney_Appointments

Many-To-One Relationship: [appointment msdyncrm_customerjourney_Appointments](appointment.md#BKMK_msdyncrm_customerjourney_Appointments)

|Property|Value|
|---|---|
|ReferencingEntity|`appointment`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_customerjourney_Appointments`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_customerjourney_AsyncOperations"></a> msdyncrm_customerjourney_AsyncOperations

Many-To-One Relationship: [asyncoperation msdyncrm_customerjourney_AsyncOperations](asyncoperation.md#BKMK_msdyncrm_customerjourney_AsyncOperations)

|Property|Value|
|---|---|
|ReferencingEntity|`asyncoperation`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_customerjourney_AsyncOperations`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_customerjourney_BulkDeleteFailures"></a> msdyncrm_customerjourney_BulkDeleteFailures

Many-To-One Relationship: [bulkdeletefailure msdyncrm_customerjourney_BulkDeleteFailures](bulkdeletefailure.md#BKMK_msdyncrm_customerjourney_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencingEntity|`bulkdeletefailure`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_customerjourney_BulkDeleteFailures`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_customerjourney_chats"></a> msdyncrm_customerjourney_chats

Many-To-One Relationship: [chat msdyncrm_customerjourney_chats](chat.md#BKMK_msdyncrm_customerjourney_chats)

|Property|Value|
|---|---|
|ReferencingEntity|`chat`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_customerjourney_chats`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_customerjourney_Emails"></a> msdyncrm_customerjourney_Emails

Many-To-One Relationship: [email msdyncrm_customerjourney_Emails](email.md#BKMK_msdyncrm_customerjourney_Emails)

|Property|Value|
|---|---|
|ReferencingEntity|`email`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_customerjourney_Emails`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_customerjourney_Faxes"></a> msdyncrm_customerjourney_Faxes

Many-To-One Relationship: [fax msdyncrm_customerjourney_Faxes](fax.md#BKMK_msdyncrm_customerjourney_Faxes)

|Property|Value|
|---|---|
|ReferencingEntity|`fax`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_customerjourney_Faxes`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_customerjourney_Feedback"></a> msdyncrm_customerjourney_Feedback

Many-To-One Relationship: [feedback msdyncrm_customerjourney_Feedback](feedback.md#BKMK_msdyncrm_customerjourney_Feedback)

|Property|Value|
|---|---|
|ReferencingEntity|`feedback`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_customerjourney_Feedback`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 150<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_customerjourney_Letters"></a> msdyncrm_customerjourney_Letters

Many-To-One Relationship: [letter msdyncrm_customerjourney_Letters](letter.md#BKMK_msdyncrm_customerjourney_Letters)

|Property|Value|
|---|---|
|ReferencingEntity|`letter`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_customerjourney_Letters`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_customerjourney_li_inmails"></a> msdyncrm_customerjourney_li_inmails

Many-To-One Relationship: [li_inmail msdyncrm_customerjourney_li_inmails](li_inmail.md#BKMK_msdyncrm_customerjourney_li_inmails)

|Property|Value|
|---|---|
|ReferencingEntity|`li_inmail`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_customerjourney_li_inmails`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_customerjourney_li_messages"></a> msdyncrm_customerjourney_li_messages

Many-To-One Relationship: [li_message msdyncrm_customerjourney_li_messages](li_message.md#BKMK_msdyncrm_customerjourney_li_messages)

|Property|Value|
|---|---|
|ReferencingEntity|`li_message`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_customerjourney_li_messages`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_customerjourney_li_pointdrivepresentationvieweds"></a> msdyncrm_customerjourney_li_pointdrivepresentationvieweds

Many-To-One Relationship: [li_pointdrivepresentationviewed msdyncrm_customerjourney_li_pointdrivepresentationvieweds](li_pointdrivepresentationviewed.md#BKMK_msdyncrm_customerjourney_li_pointdrivepresentationvieweds)

|Property|Value|
|---|---|
|ReferencingEntity|`li_pointdrivepresentationviewed`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_customerjourney_li_pointdrivepresentationvieweds`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_customerjourney_MailboxTrackingFolders"></a> msdyncrm_customerjourney_MailboxTrackingFolders

Many-To-One Relationship: [mailboxtrackingfolder msdyncrm_customerjourney_MailboxTrackingFolders](mailboxtrackingfolder.md#BKMK_msdyncrm_customerjourney_MailboxTrackingFolders)

|Property|Value|
|---|---|
|ReferencingEntity|`mailboxtrackingfolder`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_customerjourney_MailboxTrackingFolders`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_customerjourney_marketingformsubmission"></a> msdyncrm_customerjourney_marketingformsubmission

Many-To-One Relationship: [msdyncrm_marketingformsubmission msdyncrm_customerjourney_marketingformsubmission](msdyncrm_marketingformsubmission.md#BKMK_msdyncrm_customerjourney_marketingformsubmission)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyncrm_marketingformsubmission`|
|ReferencingAttribute|`msdyncrm_customerjourneyid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_customerjourney_marketingformsubmission`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_customerjourney_msdyn_bookingalerts"></a> msdyncrm_customerjourney_msdyn_bookingalerts

Many-To-One Relationship: [msdyn_bookingalert msdyncrm_customerjourney_msdyn_bookingalerts](msdyn_bookingalert.md#BKMK_msdyncrm_customerjourney_msdyn_bookingalerts)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_bookingalert`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_customerjourney_msdyn_bookingalerts`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_customerjourney_msdyn_copilottranscripts"></a> msdyncrm_customerjourney_msdyn_copilottranscripts

Many-To-One Relationship: [msdyn_copilottranscript msdyncrm_customerjourney_msdyn_copilottranscripts](msdyn_copilottranscript.md#BKMK_msdyncrm_customerjourney_msdyn_copilottranscripts)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_copilottranscript`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_customerjourney_msdyn_copilottranscripts`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_customerjourney_msdyn_ocliveworkitems"></a> msdyncrm_customerjourney_msdyn_ocliveworkitems

Many-To-One Relationship: [msdyn_ocliveworkitem msdyncrm_customerjourney_msdyn_ocliveworkitems](msdyn_ocliveworkitem.md#BKMK_msdyncrm_customerjourney_msdyn_ocliveworkitems)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocliveworkitem`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_customerjourney_msdyn_ocliveworkitems`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_customerjourney_msdyn_ocoutboundmessages"></a> msdyncrm_customerjourney_msdyn_ocoutboundmessages

Many-To-One Relationship: [msdyn_ocoutboundmessage msdyncrm_customerjourney_msdyn_ocoutboundmessages](msdyn_ocoutboundmessage.md#BKMK_msdyncrm_customerjourney_msdyn_ocoutboundmessages)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocoutboundmessage`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_customerjourney_msdyn_ocoutboundmessages`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_customerjourney_msdyn_ocsessions"></a> msdyncrm_customerjourney_msdyn_ocsessions

Many-To-One Relationship: [msdyn_ocsession msdyncrm_customerjourney_msdyn_ocsessions](msdyn_ocsession.md#BKMK_msdyncrm_customerjourney_msdyn_ocsessions)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocsession`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_customerjourney_msdyn_ocsessions`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_customerjourney_msdyn_ocvoicemails"></a> msdyncrm_customerjourney_msdyn_ocvoicemails

Many-To-One Relationship: [msdyn_ocvoicemail msdyncrm_customerjourney_msdyn_ocvoicemails](msdyn_ocvoicemail.md#BKMK_msdyncrm_customerjourney_msdyn_ocvoicemails)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocvoicemail`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_customerjourney_msdyn_ocvoicemails`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_customerjourney_msfp_alerts"></a> msdyncrm_customerjourney_msfp_alerts

Many-To-One Relationship: [msfp_alert msdyncrm_customerjourney_msfp_alerts](msfp_alert.md#BKMK_msdyncrm_customerjourney_msfp_alerts)

|Property|Value|
|---|---|
|ReferencingEntity|`msfp_alert`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_customerjourney_msfp_alerts`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_customerjourney_msfp_surveyinvites"></a> msdyncrm_customerjourney_msfp_surveyinvites

Many-To-One Relationship: [msfp_surveyinvite msdyncrm_customerjourney_msfp_surveyinvites](msfp_surveyinvite.md#BKMK_msdyncrm_customerjourney_msfp_surveyinvites)

|Property|Value|
|---|---|
|ReferencingEntity|`msfp_surveyinvite`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_customerjourney_msfp_surveyinvites`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_customerjourney_msfp_surveyresponses"></a> msdyncrm_customerjourney_msfp_surveyresponses

Many-To-One Relationship: [msfp_surveyresponse msdyncrm_customerjourney_msfp_surveyresponses](msfp_surveyresponse.md#BKMK_msdyncrm_customerjourney_msfp_surveyresponses)

|Property|Value|
|---|---|
|ReferencingEntity|`msfp_surveyresponse`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_customerjourney_msfp_surveyresponses`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_customerjourney_PhoneCalls"></a> msdyncrm_customerjourney_PhoneCalls

Many-To-One Relationship: [phonecall msdyncrm_customerjourney_PhoneCalls](phonecall.md#BKMK_msdyncrm_customerjourney_PhoneCalls)

|Property|Value|
|---|---|
|ReferencingEntity|`phonecall`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_customerjourney_PhoneCalls`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_customerjourney_PrincipalObjectAttributeAccesses"></a> msdyncrm_customerjourney_PrincipalObjectAttributeAccesses

Many-To-One Relationship: [principalobjectattributeaccess msdyncrm_customerjourney_PrincipalObjectAttributeAccesses](principalobjectattributeaccess.md#BKMK_msdyncrm_customerjourney_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencingEntity|`principalobjectattributeaccess`|
|ReferencingAttribute|`objectid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_customerjourney_PrincipalObjectAttributeAccesses`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_customerjourney_ProcessSession"></a> msdyncrm_customerjourney_ProcessSession

Many-To-One Relationship: [processsession msdyncrm_customerjourney_ProcessSession](processsession.md#BKMK_msdyncrm_customerjourney_ProcessSession)

|Property|Value|
|---|---|
|ReferencingEntity|`processsession`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_customerjourney_ProcessSession`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_customerjourney_RecurringAppointmentMasters"></a> msdyncrm_customerjourney_RecurringAppointmentMasters

Many-To-One Relationship: [recurringappointmentmaster msdyncrm_customerjourney_RecurringAppointmentMasters](recurringappointmentmaster.md#BKMK_msdyncrm_customerjourney_RecurringAppointmentMasters)

|Property|Value|
|---|---|
|ReferencingEntity|`recurringappointmentmaster`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_customerjourney_RecurringAppointmentMasters`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_customerjourney_ServiceAppointments"></a> msdyncrm_customerjourney_ServiceAppointments

Many-To-One Relationship: [serviceappointment msdyncrm_customerjourney_ServiceAppointments](serviceappointment.md#BKMK_msdyncrm_customerjourney_ServiceAppointments)

|Property|Value|
|---|---|
|ReferencingEntity|`serviceappointment`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_customerjourney_ServiceAppointments`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_customerjourney_SocialActivities"></a> msdyncrm_customerjourney_SocialActivities

Many-To-One Relationship: [socialactivity msdyncrm_customerjourney_SocialActivities](socialactivity.md#BKMK_msdyncrm_customerjourney_SocialActivities)

|Property|Value|
|---|---|
|ReferencingEntity|`socialactivity`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_customerjourney_SocialActivities`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_customerjourney_SyncErrors"></a> msdyncrm_customerjourney_SyncErrors

Many-To-One Relationship: [syncerror msdyncrm_customerjourney_SyncErrors](syncerror.md#BKMK_msdyncrm_customerjourney_SyncErrors)

|Property|Value|
|---|---|
|ReferencingEntity|`syncerror`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_customerjourney_SyncErrors`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_customerjourney_Tasks"></a> msdyncrm_customerjourney_Tasks

Many-To-One Relationship: [task msdyncrm_customerjourney_Tasks](task.md#BKMK_msdyncrm_customerjourney_Tasks)

|Property|Value|
|---|---|
|ReferencingEntity|`task`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_customerjourney_Tasks`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_msdyncrm_customerjourney_contact_customerjourneyid"></a> msdyncrm_msdyncrm_customerjourney_contact_customerjourneyid

Many-To-One Relationship: [contact msdyncrm_msdyncrm_customerjourney_contact_customerjourneyid](contact.md#BKMK_msdyncrm_msdyncrm_customerjourney_contact_customerjourneyid)

|Property|Value|
|---|---|
|ReferencingEntity|`contact`|
|ReferencingAttribute|`msdyncrm_customerjourneyid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_msdyncrm_customerjourney_contact_customerjourneyid`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_msdyncrm_customerjourney_lead_customerjourneyid"></a> msdyncrm_msdyncrm_customerjourney_lead_customerjourneyid

Many-To-One Relationship: [lead msdyncrm_msdyncrm_customerjourney_lead_customerjourneyid](lead.md#BKMK_msdyncrm_msdyncrm_customerjourney_lead_customerjourneyid)

|Property|Value|
|---|---|
|ReferencingEntity|`lead`|
|ReferencingAttribute|`msdyncrm_customerjourneyid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_msdyncrm_customerjourney_lead_customerjourneyid`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_msdyncrm_customerjourney_msdyncrm_custome"></a> msdyncrm_msdyncrm_customerjourney_msdyncrm_custome

Many-To-One Relationship: [msdyncrm_customerjourneyruntimestate msdyncrm_msdyncrm_customerjourney_msdyncrm_custome](msdyncrm_customerjourneyruntimestate.md#BKMK_msdyncrm_msdyncrm_customerjourney_msdyncrm_custome)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyncrm_customerjourneyruntimestate`|
|ReferencingAttribute|`msdyncrm_customerjourneyid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_msdyncrm_customerjourney_msdyncrm_custome`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_msdyncrm_customerjourney_msdyncrm_customerjourneycustomchannelactivity_customerjourney"></a> msdyncrm_msdyncrm_customerjourney_msdyncrm_customerjourneycustomchannelactivity_customerjourney

Many-To-One Relationship: [msdyncrm_customerjourneycustomchannelactivity msdyncrm_msdyncrm_customerjourney_msdyncrm_customerjourneycustomchannelactivity_customerjourney](msdyncrm_customerjourneycustomchannelactivity.md#BKMK_msdyncrm_msdyncrm_customerjourney_msdyncrm_customerjourneycustomchannelactivity_customerjourney)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyncrm_customerjourneycustomchannelactivity`|
|ReferencingAttribute|`msdyncrm_customerjourney`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_msdyncrm_customerjourney_msdyncrm_customerjourneycustomchannelactivity_customerjourney`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_msdyncrm_customerjourney_msdyncrm_customerjourneyiteration_customerjourneyid"></a> msdyncrm_msdyncrm_customerjourney_msdyncrm_customerjourneyiteration_customerjourneyid

Many-To-One Relationship: [msdyncrm_customerjourneyiteration msdyncrm_msdyncrm_customerjourney_msdyncrm_customerjourneyiteration_customerjourneyid](msdyncrm_customerjourneyiteration.md#BKMK_msdyncrm_msdyncrm_customerjourney_msdyncrm_customerjourneyiteration_customerjourneyid)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyncrm_customerjourneyiteration`|
|ReferencingAttribute|`msdyncrm_customerjourneyid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_msdyncrm_customerjourney_msdyncrm_customerjourneyiteration_customerjourneyid`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_msdyncrm_customerjourney_msdyncrm_customerjourneytemplate_Origin"></a> msdyncrm_msdyncrm_customerjourney_msdyncrm_customerjourneytemplate_Origin

Many-To-One Relationship: [msdyncrm_customerjourneytemplate msdyncrm_msdyncrm_customerjourney_msdyncrm_customerjourneytemplate_Origin](msdyncrm_customerjourneytemplate.md#BKMK_msdyncrm_msdyncrm_customerjourney_msdyncrm_customerjourneytemplate_Origin)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyncrm_customerjourneytemplate`|
|ReferencingAttribute|`msdyncrm_origin`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_msdyncrm_customerjourney_msdyncrm_customerjourneytemplate_Origin`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_msdyncrm_customerjourney_msdyncrm_geopin_customerJourney"></a> msdyncrm_msdyncrm_customerjourney_msdyncrm_geopin_customerJourney

Many-To-One Relationship: [msdyncrm_geopin msdyncrm_msdyncrm_customerjourney_msdyncrm_geopin_customerJourney](msdyncrm_geopin.md#BKMK_msdyncrm_msdyncrm_customerjourney_msdyncrm_geopin_customerJourney)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyncrm_geopin`|
|ReferencingAttribute|`msdyncrm_customerjourney`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_msdyncrm_customerjourney_msdyncrm_geopin_customerJourney`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|


## Many-to-Many relationships

These relationships are many-to-many. Listed by **SchemaName**.

- [msdyncrm_customerjourney_msdyncrm_marketingemail](#BKMK_msdyncrm_customerjourney_msdyncrm_marketingemail)
- [msdyncrm_customerjourney_msdyncrm_marketingpage](#BKMK_msdyncrm_customerjourney_msdyncrm_marketingpage)
- [msdyncrm_msdyncrm_marketingpage_msdyncrm_customerj](#BKMK_msdyncrm_msdyncrm_marketingpage_msdyncrm_customerj)

### <a name="BKMK_msdyncrm_customerjourney_msdyncrm_marketingemail"></a> msdyncrm_customerjourney_msdyncrm_marketingemail

See [msdyncrm_marketingemail msdyncrm_customerjourney_msdyncrm_marketingemail Many-To-Many Relationship](msdyncrm_marketingemail.md#BKMK_msdyncrm_customerjourney_msdyncrm_marketingemail)

|Property|Value|
|---|---|
|IntersectEntityName|`msdyncrm_customerjourney_msdyncrm_marketingemail`|
|IsCustomizable|True|
|SchemaName|`msdyncrm_customerjourney_msdyncrm_marketingemail`|
|IntersectAttribute|`msdyncrm_customerjourneyid`|
|NavigationPropertyName|`msdyncrm_customerjourney_msdyncrm_marketingemail`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_customerjourney_msdyncrm_marketingpage"></a> msdyncrm_customerjourney_msdyncrm_marketingpage

See [msdyncrm_marketingpage msdyncrm_customerjourney_msdyncrm_marketingpage Many-To-Many Relationship](msdyncrm_marketingpage.md#BKMK_msdyncrm_customerjourney_msdyncrm_marketingpage)

|Property|Value|
|---|---|
|IntersectEntityName|`msdyncrm_customerjourney_msdyncrm_marketingpage`|
|IsCustomizable|True|
|SchemaName|`msdyncrm_customerjourney_msdyncrm_marketingpage`|
|IntersectAttribute|`msdyncrm_customerjourneyid`|
|NavigationPropertyName|`msdyncrm_customerjourney_msdyncrm_marketingpage`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_msdyncrm_marketingpage_msdyncrm_customerj"></a> msdyncrm_msdyncrm_marketingpage_msdyncrm_customerj

See [msdyncrm_marketingpage msdyncrm_msdyncrm_marketingpage_msdyncrm_customerj Many-To-Many Relationship](msdyncrm_marketingpage.md#BKMK_msdyncrm_msdyncrm_marketingpage_msdyncrm_customerj)

|Property|Value|
|---|---|
|IntersectEntityName|`msdyncrm_msdyncrm_marketingpage_msdyncrm_custome`|
|IsCustomizable|True|
|SchemaName|`msdyncrm_msdyncrm_marketingpage_msdyncrm_customerj`|
|IntersectAttribute|`msdyncrm_customerjourneyid`|
|NavigationPropertyName|`msdyncrm_msdyncrm_marketingpage_msdyncrm_customerj`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|



### See also

[Dataverse table/entity reference](../about-entity-reference.md)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   

