---
title: "Account KPI Item (msdyn_accountkpiitem) table/entity reference (Microsoft Dynamics 365)"
description: "Includes schema information and supported messages for the Account KPI Item (msdyn_accountkpiitem) table/entity with Microsoft Dynamics 365."
ms.topic: generated-reference
author: JimDaly
ms.author: jdaly
search.audienceType: 
  - developer
---

# Account KPI Item (msdyn_accountkpiitem) table/entity reference (Microsoft Dynamics 365)



## Messages

The following table lists the messages for the Account KPI Item (msdyn_accountkpiitem) table.
Messages represent operations that can be performed on the table. They may also be events.

| Name <br />Is Event? |Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `Associate`<br />Event: True |[Associate records](/power-apps/developer/data-platform/webapi/associate-disassociate-entities-using-web-api) |[Associate records](/power-apps/developer/data-platform/org-service/entity-operations-associate-disassociate#use-the-associate-method-or-associaterequest)|
| `BulkRetain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.BulkRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Create`<br />Event: True |`POST` /msdyn_accountkpiitems<br />See [Create](/powerapps/developer/data-platform/webapi/create-entity-web-api) |[Create records](/power-apps/developer/data-platform/org-service/entity-operations-create#basic-create)|
| `CreateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.CreateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.CreateMultipleRequest>|
| `Delete`<br />Event: True |`DELETE` /msdyn_accountkpiitems(*msdyn_accountkpiitemid*)<br />See [Delete](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-delete) |[Delete records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-delete)|
| `Disassociate`<br />Event: True |[Disassociate records](/power-apps/developer/data-platform/webapi/associate-disassociate-entities-using-web-api) |[Disassociate records](/power-apps/developer/data-platform/org-service/entity-operations-associate-disassociate#use-the-disassociate-method-or-disassociaterequest)|
| `IsValidStateTransition`<br />Event: False |<xref:Microsoft.Dynamics.CRM.IsValidStateTransition?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.IsValidStateTransitionRequest>|
| `PurgeRetainedContent`<br />Event: True |<xref:Microsoft.Dynamics.CRM.PurgeRetainedContent?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Restore`<br />Event: True |<xref:Microsoft.Dynamics.CRM.Restore?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.Retain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retrieve`<br />Event: True |`GET` /msdyn_accountkpiitems(*msdyn_accountkpiitemid*)<br />See [Retrieve](/powerapps/developer/data-platform/webapi/retrieve-entity-using-web-api) |[Retrieve records](/power-apps/developer/data-platform/org-service/entity-operations-retrieve)|
| `RetrieveMultiple`<br />Event: True |`GET` /msdyn_accountkpiitems<br />See [Query data](/power-apps/developer/data-platform/webapi/query-data-web-api) |[Query data](/power-apps/developer/data-platform/org-service/entity-operations-query-data)|
| `RollbackRetain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RollbackRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `SetState`<br />Event: True |`PATCH` /msdyn_accountkpiitems(*msdyn_accountkpiitemid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `statecode` and `statuscode` properties. |<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|
| `Update`<br />Event: True |`PATCH` /msdyn_accountkpiitems(*msdyn_accountkpiitemid*)<br />See [Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) |[Update records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-update)|
| `UpdateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.UpdateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpdateMultipleRequest>|
| `Upsert`<br />Event: False |`PATCH` /msdyn_accountkpiitems(*msdyn_accountkpiitemid*)<br />See [Upsert a table row](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#upsert-a-table-row) |<xref:Microsoft.Xrm.Sdk.Messages.UpsertRequest>|
| `UpsertMultiple`<br />Event: False |<xref:Microsoft.Dynamics.CRM.UpsertMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpsertMultipleRequest>|
| `ValidateRetentionConfig`<br />Event: True |<xref:Microsoft.Dynamics.CRM.ValidateRetentionConfig?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|

## Properties

The following table lists selected properties for the Account KPI Item (msdyn_accountkpiitem) table.

|Property|Value|
| --- | --- |
| **DisplayName** | **Account KPI Item** |
| **DisplayCollectionName** | **Account KPI Items** |
| **SchemaName** | `msdyn_accountkpiitem` |
| **CollectionSchemaName** | `msdyn_accountkpiitems` |
| **EntitySetName** | `msdyn_accountkpiitems`|
| **LogicalName** | `msdyn_accountkpiitem` |
| **LogicalCollectionName** | `msdyn_accountkpiitems` |
| **PrimaryIdAttribute** | `msdyn_accountkpiitemid` |
| **PrimaryNameAttribute** |`msdyn_name` |
| **TableType** | `Standard` |
| **OwnershipType** | `OrganizationOwned` |

## Writable columns/attributes

These columns/attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [msdyn_accountid](#BKMK_msdyn_accountid)
- [msdyn_accountkpiitemId](#BKMK_msdyn_accountkpiitemId)
- [msdyn_acilastupdatetimestamp](#BKMK_msdyn_acilastupdatetimestamp)
- [msdyn_averagefirstresponsetimebytheminhrs](#BKMK_msdyn_averagefirstresponsetimebytheminhrs)
- [msdyn_averagefirstresponsetimebyusinhrs](#BKMK_msdyn_averagefirstresponsetimebyusinhrs)
- [msdyn_computationaccuracy](#BKMK_msdyn_computationaccuracy)
- [msdyn_date](#BKMK_msdyn_date)
- [msdyn_emailattachmentopens](#BKMK_msdyn_emailattachmentopens)
- [msdyn_emaillinksclicked](#BKMK_msdyn_emaillinksclicked)
- [msdyn_emailsreceived](#BKMK_msdyn_emailsreceived)
- [msdyn_emailssent](#BKMK_msdyn_emailssent)
- [msdyn_facetimewithcustomer](#BKMK_msdyn_facetimewithcustomer)
- [msdyn_liemailssent](#BKMK_msdyn_liemailssent)
- [msdyn_meetingsreceived](#BKMK_msdyn_meetingsreceived)
- [msdyn_meetingssent](#BKMK_msdyn_meetingssent)
- [msdyn_name](#BKMK_msdyn_name)
- [msdyn_openedemails](#BKMK_msdyn_openedemails)
- [msdyn_phonecallsmade](#BKMK_msdyn_phonecallsmade)
- [msdyn_phonecallsreceived](#BKMK_msdyn_phonecallsreceived)
- [msdyn_relationshiphealthscorestate](#BKMK_msdyn_relationshiphealthscorestate)
- [msdyn_relationshiphealthscorevalue](#BKMK_msdyn_relationshiphealthscorevalue)
- [msdyn_relationshiphealthtrend](#BKMK_msdyn_relationshiphealthtrend)
- [msdyn_responseratebythem](#BKMK_msdyn_responseratebythem)
- [msdyn_responseratebyus](#BKMK_msdyn_responseratebyus)
- [msdyn_timespentbycustomer](#BKMK_msdyn_timespentbycustomer)
- [msdyn_timespentbycustomer_calculated](#BKMK_msdyn_timespentbycustomer_calculated)
- [msdyn_timespentbyteam](#BKMK_msdyn_timespentbyteam)
- [msdyn_timespentbyteam_calculated](#BKMK_msdyn_timespentbyteam_calculated)
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

### <a name="BKMK_msdyn_accountid"></a> msdyn_accountid

|Property|Value|
|---|---|
|Description||
|DisplayName|**AccountID**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_accountid`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|account|

### <a name="BKMK_msdyn_accountkpiitemId"></a> msdyn_accountkpiitemId

|Property|Value|
|---|---|
|Description|**Unique identifier for entity instances.**|
|DisplayName|**Unique Identifier for Entity Instances**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`msdyn_accountkpiitemid`|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|

### <a name="BKMK_msdyn_acilastupdatetimestamp"></a> msdyn_acilastupdatetimestamp

|Property|Value|
|---|---|
|Description|**TimeStamp value when the KPI are retrieved from ACI**|
|DisplayName|**Last Updated**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_acilastupdatetimestamp`|
|RequiredLevel|None|
|Type|DateTime|
|CanChangeDateTimeBehavior|False|
|DateTimeBehavior|UserLocal|
|Format|DateAndTime|
|ImeMode|Auto|
|SourceTypeMask|0|

### <a name="BKMK_msdyn_averagefirstresponsetimebytheminhrs"></a> msdyn_averagefirstresponsetimebytheminhrs

|Property|Value|
|---|---|
|Description|**Average time taken by the customer(in hrs) to respond.**|
|DisplayName|**Average customer response time**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_averagefirstresponsetimebytheminhrs`|
|RequiredLevel|None|
|Type|Decimal|
|ImeMode|Auto|
|MaxValue|100000000000|
|MinValue|0|
|Precision|2|
|SourceTypeMask|0|

### <a name="BKMK_msdyn_averagefirstresponsetimebyusinhrs"></a> msdyn_averagefirstresponsetimebyusinhrs

|Property|Value|
|---|---|
|Description|**Average time taken by the seller(in hrs) to respond.**|
|DisplayName|**Average seller response time**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_averagefirstresponsetimebyusinhrs`|
|RequiredLevel|None|
|Type|Decimal|
|ImeMode|Auto|
|MaxValue|100000000000|
|MinValue|0|
|Precision|2|
|SourceTypeMask|0|

### <a name="BKMK_msdyn_computationaccuracy"></a> msdyn_computationaccuracy

|Property|Value|
|---|---|
|Description||
|DisplayName|**Computation Accuracy**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_computationaccuracy`|
|RequiredLevel|None|
|Type|Picklist|
|DefaultFormValue|100000000|
|GlobalChoiceName|`msdyn_kpicomputationaccuracy`|

#### msdyn_computationaccuracy Choices/Options

|Value|Label|
|---|---|
|100000000|**Complete**|
|100000001|**Partial**|

### <a name="BKMK_msdyn_date"></a> msdyn_date

|Property|Value|
|---|---|
|Description||
|DisplayName|**Date**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_date`|
|RequiredLevel|None|
|Type|DateTime|
|CanChangeDateTimeBehavior|True|
|DateTimeBehavior|UserLocal|
|Format|DateAndTime|
|ImeMode|Auto|
|SourceTypeMask|0|

### <a name="BKMK_msdyn_emailattachmentopens"></a> msdyn_emailattachmentopens

|Property|Value|
|---|---|
|Description|**Shows the rate of opening attachments on followed emails.**|
|DisplayName|**Opening Attachment Rate**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_emailattachmentopens`|
|RequiredLevel|None|
|Type|Decimal|
|ImeMode|Auto|
|MaxValue|100000000000|
|MinValue|0|
|Precision|2|
|SourceTypeMask|0|

### <a name="BKMK_msdyn_emaillinksclicked"></a> msdyn_emaillinksclicked

|Property|Value|
|---|---|
|Description|**Shows the rate of links clicked on in followed emails.**|
|DisplayName|**Clicked Links Rate**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_emaillinksclicked`|
|RequiredLevel|None|
|Type|Decimal|
|ImeMode|Auto|
|MaxValue|100000000000|
|MinValue|0|
|Precision|2|
|SourceTypeMask|0|

### <a name="BKMK_msdyn_emailsreceived"></a> msdyn_emailsreceived

|Property|Value|
|---|---|
|Description|**Total number of email received.**|
|DisplayName|**Received Emails**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_emailsreceived`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|0|

### <a name="BKMK_msdyn_emailssent"></a> msdyn_emailssent

|Property|Value|
|---|---|
|Description|**Number of emails sent by internal contacts to external contacts.**|
|DisplayName|**Sent Emails**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_emailssent`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|0|

### <a name="BKMK_msdyn_facetimewithcustomer"></a> msdyn_facetimewithcustomer

|Property|Value|
|---|---|
|Description||
|DisplayName|**Facetime with customer**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_facetimewithcustomer`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|0|

### <a name="BKMK_msdyn_liemailssent"></a> msdyn_liemailssent

|Property|Value|
|---|---|
|Description||
|DisplayName|**LI Emails Sent**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_liemailssent`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|0|

### <a name="BKMK_msdyn_meetingsreceived"></a> msdyn_meetingsreceived

|Property|Value|
|---|---|
|Description|**Number of meetings sent by the customer.**|
|DisplayName|**Received Meetings**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_meetingsreceived`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|0|

### <a name="BKMK_msdyn_meetingssent"></a> msdyn_meetingssent

|Property|Value|
|---|---|
|Description|**Number of meetings sent to the customer.**|
|DisplayName|**Sent Meetings**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_meetingssent`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|0|

### <a name="BKMK_msdyn_name"></a> msdyn_name

|Property|Value|
|---|---|
|Description|**Name of the custom entity.**|
|DisplayName|**Custom Entity Name**|
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

### <a name="BKMK_msdyn_openedemails"></a> msdyn_openedemails

|Property|Value|
|---|---|
|Description|**Shows the rate of opening followed emails.**|
|DisplayName|**Opening Emails Rate**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_openedemails`|
|RequiredLevel|None|
|Type|Decimal|
|ImeMode|Auto|
|MaxValue|100000000000|
|MinValue|0|
|Precision|2|
|SourceTypeMask|0|

### <a name="BKMK_msdyn_phonecallsmade"></a> msdyn_phonecallsmade

|Property|Value|
|---|---|
|Description|**Shows the number of phone calls made.**|
|DisplayName|**Phone Calls Made**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_phonecallsmade`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|0|

### <a name="BKMK_msdyn_phonecallsreceived"></a> msdyn_phonecallsreceived

|Property|Value|
|---|---|
|Description|**Shows the number of phone calls received.**|
|DisplayName|**Phone Calls Received**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_phonecallsreceived`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|0|

### <a name="BKMK_msdyn_relationshiphealthscorestate"></a> msdyn_relationshiphealthscorestate

|Property|Value|
|---|---|
|Description|**KPI health score.**|
|DisplayName|**Relationship Health State**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_relationshiphealthscorestate`|
|RequiredLevel|None|
|Type|Picklist|
|DefaultFormValue|-1|
|GlobalChoiceName|`msdyn_msdyn_accountkpiitem_msdyn_relationshiphealthscorestate`|

#### msdyn_relationshiphealthscorestate Choices/Options

|Value|Label|
|---|---|
|0|**Good**|
|1|**Fair**|
|2|**Poor**|
|3|**Not enough info**|
|4|**No Closed Activities**|
|5|**Health Computation In Progress**|
|6|**Something went wrong**|
|7|**Entity older than 2 years**|

### <a name="BKMK_msdyn_relationshiphealthscorevalue"></a> msdyn_relationshiphealthscorevalue

|Property|Value|
|---|---|
|Description|**Health score for the account.**|
|DisplayName|**Relationship Health**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_relationshiphealthscorevalue`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|100|
|MinValue|0|

### <a name="BKMK_msdyn_relationshiphealthtrend"></a> msdyn_relationshiphealthtrend

|Property|Value|
|---|---|
|Description|**Direction the relationship health is moving.**|
|DisplayName|**Relationship Health Trend**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_relationshiphealthtrend`|
|RequiredLevel|None|
|Type|Picklist|
|DefaultFormValue|-1|
|GlobalChoiceName|`msdyn_msdyn_accountkpiitem_msdyn_relationshiphealthtrend`|

#### msdyn_relationshiphealthtrend Choices/Options

|Value|Label|
|---|---|
|0|**Improving**|
|1|**Steady**|
|2|**Declining**|
|3|**Not enough info**|
|4|**Something went wrong**|
|5|**Health not applicable**|

### <a name="BKMK_msdyn_responseratebythem"></a> msdyn_responseratebythem

|Property|Value|
|---|---|
|Description|**Rate of response of the customer.**|
|DisplayName|**Rate of response of the customer**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_responseratebythem`|
|RequiredLevel|None|
|Type|Decimal|
|ImeMode|Auto|
|MaxValue|100000000000|
|MinValue|0|
|Precision|2|
|SourceTypeMask|0|

### <a name="BKMK_msdyn_responseratebyus"></a> msdyn_responseratebyus

|Property|Value|
|---|---|
|Description|**Rate of response by the seller.**|
|DisplayName|**Rate of response by the seller**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_responseratebyus`|
|RequiredLevel|None|
|Type|Decimal|
|ImeMode|Auto|
|MaxValue|100000000000|
|MinValue|0|
|Precision|2|
|SourceTypeMask|0|

### <a name="BKMK_msdyn_timespentbycustomer"></a> msdyn_timespentbycustomer

|Property|Value|
|---|---|
|Description|**Time spent by external contacts on activities.**|
|DisplayName|**Time Engaged with Customer**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_timespentbycustomer`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|0|

### <a name="BKMK_msdyn_timespentbycustomer_calculated"></a> msdyn_timespentbycustomer_calculated

|Property|Value|
|---|---|
|Description|**Time spent by external contacts on activities.**|
|DisplayName|**Time Engaged with Customer in Hours**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_timespentbycustomer_calculated`|
|RequiredLevel|None|
|Type|Decimal|
|ImeMode|Auto|
|MaxValue|100000000000|
|MinValue|-100000000000|
|Precision|1|
|SourceTypeMask|1|

### <a name="BKMK_msdyn_timespentbyteam"></a> msdyn_timespentbyteam

|Property|Value|
|---|---|
|Description|**Time spent for emails and meetings by internal contacts in relation to the record.**|
|DisplayName|**Time Spent by Team**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_timespentbyteam`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|0|

### <a name="BKMK_msdyn_timespentbyteam_calculated"></a> msdyn_timespentbyteam_calculated

|Property|Value|
|---|---|
|Description|**Time spent for emails and meetings by internal contacts in relation to the record.**|
|DisplayName|**Time Spent by Team in Hours**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_timespentbyteam_calculated`|
|RequiredLevel|None|
|Type|Decimal|
|ImeMode|Auto|
|MaxValue|100000000000|
|MinValue|-100000000000|
|Precision|1|
|SourceTypeMask|1|

### <a name="BKMK_OverriddenCreatedOn"></a> OverriddenCreatedOn

|Property|Value|
|---|---|
|Description|**Date and time when the record was migrated.**|
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
|Description|**Status of the Account KPI.**|
|DisplayName|**Status**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statecode`|
|RequiredLevel|SystemRequired|
|Type|State|
|DefaultFormValue||
|GlobalChoiceName|`msdyn_accountkpiitem_statecode`|

#### statecode Choices/Options

|Value|Details|
|---|---|
|0|Label: **Active**<br />DefaultStatus: 1<br />InvariantName: `Active`|
|1|Label: **Inactive**<br />DefaultStatus: 2<br />InvariantName: `Inactive`|

### <a name="BKMK_statuscode"></a> statuscode

|Property|Value|
|---|---|
|Description|**Reason for the status of the Account KPI.**|
|DisplayName|**Status Reason**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statuscode`|
|RequiredLevel|None|
|Type|Status|
|DefaultFormValue||
|GlobalChoiceName|`msdyn_accountkpiitem_statuscode`|

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

- [lk_msdyn_accountkpiitem_createdby](#BKMK_lk_msdyn_accountkpiitem_createdby)
- [lk_msdyn_accountkpiitem_createdonbehalfby](#BKMK_lk_msdyn_accountkpiitem_createdonbehalfby)
- [lk_msdyn_accountkpiitem_modifiedby](#BKMK_lk_msdyn_accountkpiitem_modifiedby)
- [lk_msdyn_accountkpiitem_modifiedonbehalfby](#BKMK_lk_msdyn_accountkpiitem_modifiedonbehalfby)
- [msdyn_account_msdyn_accountkpiitem_accountid](#BKMK_msdyn_account_msdyn_accountkpiitem_accountid)
- [organization_msdyn_accountkpiitem](#BKMK_organization_msdyn_accountkpiitem)

### <a name="BKMK_lk_msdyn_accountkpiitem_createdby"></a> lk_msdyn_accountkpiitem_createdby

One-To-Many Relationship: [systemuser lk_msdyn_accountkpiitem_createdby](systemuser.md#BKMK_lk_msdyn_accountkpiitem_createdby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdby`|
|ReferencingEntityNavigationPropertyName|`createdby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_accountkpiitem_createdonbehalfby"></a> lk_msdyn_accountkpiitem_createdonbehalfby

One-To-Many Relationship: [systemuser lk_msdyn_accountkpiitem_createdonbehalfby](systemuser.md#BKMK_lk_msdyn_accountkpiitem_createdonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdonbehalfby`|
|ReferencingEntityNavigationPropertyName|`createdonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_accountkpiitem_modifiedby"></a> lk_msdyn_accountkpiitem_modifiedby

One-To-Many Relationship: [systemuser lk_msdyn_accountkpiitem_modifiedby](systemuser.md#BKMK_lk_msdyn_accountkpiitem_modifiedby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedby`|
|ReferencingEntityNavigationPropertyName|`modifiedby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_accountkpiitem_modifiedonbehalfby"></a> lk_msdyn_accountkpiitem_modifiedonbehalfby

One-To-Many Relationship: [systemuser lk_msdyn_accountkpiitem_modifiedonbehalfby](systemuser.md#BKMK_lk_msdyn_accountkpiitem_modifiedonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedonbehalfby`|
|ReferencingEntityNavigationPropertyName|`modifiedonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_account_msdyn_accountkpiitem_accountid"></a> msdyn_account_msdyn_accountkpiitem_accountid

One-To-Many Relationship: [account msdyn_account_msdyn_accountkpiitem_accountid](account.md#BKMK_msdyn_account_msdyn_accountkpiitem_accountid)

|Property|Value|
|---|---|
|ReferencedEntity|`account`|
|ReferencedAttribute|`accountid`|
|ReferencingAttribute|`msdyn_accountid`|
|ReferencingEntityNavigationPropertyName|`msdyn_accountid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `Cascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_organization_msdyn_accountkpiitem"></a> organization_msdyn_accountkpiitem

One-To-Many Relationship: [organization organization_msdyn_accountkpiitem](organization.md#BKMK_organization_msdyn_accountkpiitem)

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

- [msdyn_accountkpiitem_AsyncOperations](#BKMK_msdyn_accountkpiitem_AsyncOperations)
- [msdyn_accountkpiitem_BulkDeleteFailures](#BKMK_msdyn_accountkpiitem_BulkDeleteFailures)
- [msdyn_accountkpiitem_MailboxTrackingFolders](#BKMK_msdyn_accountkpiitem_MailboxTrackingFolders)
- [msdyn_accountkpiitem_PrincipalObjectAttributeAccesses](#BKMK_msdyn_accountkpiitem_PrincipalObjectAttributeAccesses)
- [msdyn_accountkpiitem_ProcessSession](#BKMK_msdyn_accountkpiitem_ProcessSession)
- [msdyn_accountkpiitem_SyncErrors](#BKMK_msdyn_accountkpiitem_SyncErrors)
- [msdyn_msdyn_accountkpiitem_account_accountkpiid](#BKMK_msdyn_msdyn_accountkpiitem_account_accountkpiid)

### <a name="BKMK_msdyn_accountkpiitem_AsyncOperations"></a> msdyn_accountkpiitem_AsyncOperations

Many-To-One Relationship: [asyncoperation msdyn_accountkpiitem_AsyncOperations](asyncoperation.md#BKMK_msdyn_accountkpiitem_AsyncOperations)

|Property|Value|
|---|---|
|ReferencingEntity|`asyncoperation`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_accountkpiitem_AsyncOperations`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_accountkpiitem_BulkDeleteFailures"></a> msdyn_accountkpiitem_BulkDeleteFailures

Many-To-One Relationship: [bulkdeletefailure msdyn_accountkpiitem_BulkDeleteFailures](bulkdeletefailure.md#BKMK_msdyn_accountkpiitem_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencingEntity|`bulkdeletefailure`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_accountkpiitem_BulkDeleteFailures`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_accountkpiitem_MailboxTrackingFolders"></a> msdyn_accountkpiitem_MailboxTrackingFolders

Many-To-One Relationship: [mailboxtrackingfolder msdyn_accountkpiitem_MailboxTrackingFolders](mailboxtrackingfolder.md#BKMK_msdyn_accountkpiitem_MailboxTrackingFolders)

|Property|Value|
|---|---|
|ReferencingEntity|`mailboxtrackingfolder`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_accountkpiitem_MailboxTrackingFolders`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_accountkpiitem_PrincipalObjectAttributeAccesses"></a> msdyn_accountkpiitem_PrincipalObjectAttributeAccesses

Many-To-One Relationship: [principalobjectattributeaccess msdyn_accountkpiitem_PrincipalObjectAttributeAccesses](principalobjectattributeaccess.md#BKMK_msdyn_accountkpiitem_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencingEntity|`principalobjectattributeaccess`|
|ReferencingAttribute|`objectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_accountkpiitem_PrincipalObjectAttributeAccesses`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_accountkpiitem_ProcessSession"></a> msdyn_accountkpiitem_ProcessSession

Many-To-One Relationship: [processsession msdyn_accountkpiitem_ProcessSession](processsession.md#BKMK_msdyn_accountkpiitem_ProcessSession)

|Property|Value|
|---|---|
|ReferencingEntity|`processsession`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_accountkpiitem_ProcessSession`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_accountkpiitem_SyncErrors"></a> msdyn_accountkpiitem_SyncErrors

Many-To-One Relationship: [syncerror msdyn_accountkpiitem_SyncErrors](syncerror.md#BKMK_msdyn_accountkpiitem_SyncErrors)

|Property|Value|
|---|---|
|ReferencingEntity|`syncerror`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_accountkpiitem_SyncErrors`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_msdyn_accountkpiitem_account_accountkpiid"></a> msdyn_msdyn_accountkpiitem_account_accountkpiid

Many-To-One Relationship: [account msdyn_msdyn_accountkpiitem_account_accountkpiid](account.md#BKMK_msdyn_msdyn_accountkpiitem_account_accountkpiid)

|Property|Value|
|---|---|
|ReferencingEntity|`account`|
|ReferencingAttribute|`msdyn_accountkpiid`|
|ReferencedEntityNavigationPropertyName|`msdyn_msdyn_accountkpiitem_account_accountkpiid`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|



### See also

[Dataverse table/entity reference](/power-apps/developer/data-platform/reference/about-entity-reference)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   

