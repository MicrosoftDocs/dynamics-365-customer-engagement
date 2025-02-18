---
title: "Opportunity KPI Item (msdyn_opportunitykpiitem) table/entity reference (Microsoft Dynamics 365)"
description: "Includes schema information and supported messages for the Opportunity KPI Item (msdyn_opportunitykpiitem) table/entity with Microsoft Dynamics 365."
ms.topic: generated-reference
author: JimDaly
ms.author: jdaly
search.audienceType: 
  - developer
---

# Opportunity KPI Item (msdyn_opportunitykpiitem) table/entity reference (Microsoft Dynamics 365)



## Messages

The following table lists the messages for the Opportunity KPI Item (msdyn_opportunitykpiitem) table.
Messages represent operations that can be performed on the table. They may also be events.

| Name <br />Is Event? |Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `Associate`<br />Event: True |[Associate records](/power-apps/developer/data-platform/webapi/associate-disassociate-entities-using-web-api) |[Associate records](/power-apps/developer/data-platform/org-service/entity-operations-associate-disassociate#use-the-associate-method-or-associaterequest)|
| `BulkRetain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.BulkRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Create`<br />Event: True |`POST` /msdyn_opportunitykpiitems<br />See [Create](/powerapps/developer/data-platform/webapi/create-entity-web-api) |[Create records](/power-apps/developer/data-platform/org-service/entity-operations-create#basic-create)|
| `CreateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.CreateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.CreateMultipleRequest>|
| `Delete`<br />Event: True |`DELETE` /msdyn_opportunitykpiitems(*msdyn_opportunitykpiitemid*)<br />See [Delete](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-delete) |[Delete records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-delete)|
| `Disassociate`<br />Event: True |[Disassociate records](/power-apps/developer/data-platform/webapi/associate-disassociate-entities-using-web-api) |[Disassociate records](/power-apps/developer/data-platform/org-service/entity-operations-associate-disassociate#use-the-disassociate-method-or-disassociaterequest)|
| `IsValidStateTransition`<br />Event: False |<xref:Microsoft.Dynamics.CRM.IsValidStateTransition?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.IsValidStateTransitionRequest>|
| `PurgeRetainedContent`<br />Event: True |<xref:Microsoft.Dynamics.CRM.PurgeRetainedContent?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Restore`<br />Event: True |<xref:Microsoft.Dynamics.CRM.Restore?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.Retain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retrieve`<br />Event: True |`GET` /msdyn_opportunitykpiitems(*msdyn_opportunitykpiitemid*)<br />See [Retrieve](/powerapps/developer/data-platform/webapi/retrieve-entity-using-web-api) |[Retrieve records](/power-apps/developer/data-platform/org-service/entity-operations-retrieve)|
| `RetrieveMultiple`<br />Event: True |`GET` /msdyn_opportunitykpiitems<br />See [Query data](/power-apps/developer/data-platform/webapi/query-data-web-api) |[Query data](/power-apps/developer/data-platform/org-service/entity-operations-query-data)|
| `RollbackRetain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RollbackRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `SetState`<br />Event: True |`PATCH` /msdyn_opportunitykpiitems(*msdyn_opportunitykpiitemid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `statecode` and `statuscode` properties. |<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|
| `Update`<br />Event: True |`PATCH` /msdyn_opportunitykpiitems(*msdyn_opportunitykpiitemid*)<br />See [Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) |[Update records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-update)|
| `UpdateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.UpdateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpdateMultipleRequest>|
| `Upsert`<br />Event: False |`PATCH` /msdyn_opportunitykpiitems(*msdyn_opportunitykpiitemid*)<br />See [Upsert a table row](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#upsert-a-table-row) |<xref:Microsoft.Xrm.Sdk.Messages.UpsertRequest>|
| `UpsertMultiple`<br />Event: False |<xref:Microsoft.Dynamics.CRM.UpsertMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpsertMultipleRequest>|
| `ValidateRetentionConfig`<br />Event: True |<xref:Microsoft.Dynamics.CRM.ValidateRetentionConfig?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|

## Properties

The following table lists selected properties for the Opportunity KPI Item (msdyn_opportunitykpiitem) table.

|Property|Value|
| --- | --- |
| **DisplayName** | **Opportunity KPI Item** |
| **DisplayCollectionName** | **Opportunity KPI Items** |
| **SchemaName** | `msdyn_opportunitykpiitem` |
| **CollectionSchemaName** | `msdyn_opportunitykpiitems` |
| **EntitySetName** | `msdyn_opportunitykpiitems`|
| **LogicalName** | `msdyn_opportunitykpiitem` |
| **LogicalCollectionName** | `msdyn_opportunitykpiitems` |
| **PrimaryIdAttribute** | `msdyn_opportunitykpiitemid` |
| **PrimaryNameAttribute** |`msdyn_name` |
| **TableType** | `Standard` |
| **OwnershipType** | `OrganizationOwned` |

## Writable columns/attributes

These columns/attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
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
- [msdyn_lastactivitybyteam](#BKMK_msdyn_lastactivitybyteam)
- [msdyn_lastactivitydirection](#BKMK_msdyn_lastactivitydirection)
- [msdyn_lastactivityid](#BKMK_msdyn_lastactivityid)
- [msdyn_lastactivitytype](#BKMK_msdyn_lastactivitytype)
- [msdyn_liemailssent](#BKMK_msdyn_liemailssent)
- [msdyn_meetingsreceived](#BKMK_msdyn_meetingsreceived)
- [msdyn_meetingssent](#BKMK_msdyn_meetingssent)
- [msdyn_name](#BKMK_msdyn_name)
- [msdyn_nextactivitybyteam](#BKMK_msdyn_nextactivitybyteam)
- [msdyn_nextactivitydirection](#BKMK_msdyn_nextactivitydirection)
- [msdyn_nextactivityid](#BKMK_msdyn_nextactivityid)
- [msdyn_nextactivitytype](#BKMK_msdyn_nextactivitytype)
- [msdyn_openedemails](#BKMK_msdyn_openedemails)
- [msdyn_opportunityid](#BKMK_msdyn_opportunityid)
- [msdyn_opportunitykpiitemId](#BKMK_msdyn_opportunitykpiitemId)
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
|DisplayName|**Opening Attachments Rate**|
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
|Description|**Number of emails received.**|
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

### <a name="BKMK_msdyn_lastactivitybyteam"></a> msdyn_lastactivitybyteam

|Property|Value|
|---|---|
|Description|**Date of the last interaction.**|
|DisplayName|**Last Activity by Team**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_lastactivitybyteam`|
|RequiredLevel|None|
|Type|DateTime|
|CanChangeDateTimeBehavior|True|
|DateTimeBehavior|UserLocal|
|Format|DateAndTime|
|ImeMode|Auto|
|SourceTypeMask|0|

### <a name="BKMK_msdyn_lastactivitydirection"></a> msdyn_lastactivitydirection

|Property|Value|
|---|---|
|Description|**Last activity direction.**|
|DisplayName|**Last Activity Direction**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_lastactivitydirection`|
|RequiredLevel|None|
|Type|Picklist|
|DefaultFormValue|-1|
|GlobalChoiceName|`msdyn_msdyn_opportunitykpiitem_msdyn_lastactivitydirection`|

#### msdyn_lastactivitydirection Choices/Options

|Value|Label|
|---|---|
|0|**Incoming**|
|1|**Outgoing**|

### <a name="BKMK_msdyn_lastactivityid"></a> msdyn_lastactivityid

|Property|Value|
|---|---|
|Description|**ID of the last activity.**|
|DisplayName|**ID of Last activity**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_lastactivityid`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdyn_lastactivitytype"></a> msdyn_lastactivitytype

|Property|Value|
|---|---|
|Description|**Last activity type.**|
|DisplayName|**Last Activity Type**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_lastactivitytype`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|1250|

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
|Description|**The name of the custom entity.**|
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

### <a name="BKMK_msdyn_nextactivitybyteam"></a> msdyn_nextactivitybyteam

|Property|Value|
|---|---|
|Description|**Next activity due by internal contacts or next meeting that is linked to the record.**|
|DisplayName|**Next Activity by Team**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_nextactivitybyteam`|
|RequiredLevel|None|
|Type|DateTime|
|CanChangeDateTimeBehavior|True|
|DateTimeBehavior|UserLocal|
|Format|DateAndTime|
|ImeMode|Auto|
|SourceTypeMask|0|

### <a name="BKMK_msdyn_nextactivitydirection"></a> msdyn_nextactivitydirection

|Property|Value|
|---|---|
|Description|**Next activity direction.**|
|DisplayName|**Next Activity Direction**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_nextactivitydirection`|
|RequiredLevel|None|
|Type|Picklist|
|DefaultFormValue|-1|
|GlobalChoiceName|`msdyn_msdyn_opportunitykpiitem_msdyn_nextactivitydirection`|

#### msdyn_nextactivitydirection Choices/Options

|Value|Label|
|---|---|
|0|**Incoming**|
|1|**Outgoing**|

### <a name="BKMK_msdyn_nextactivityid"></a> msdyn_nextactivityid

|Property|Value|
|---|---|
|Description|**ID of the next activity.**|
|DisplayName|**ID of Next Activity**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_nextactivityid`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdyn_nextactivitytype"></a> msdyn_nextactivitytype

|Property|Value|
|---|---|
|Description|**Next activity type.**|
|DisplayName|**Next Activity Type**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_nextactivitytype`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|1250|

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

### <a name="BKMK_msdyn_opportunityid"></a> msdyn_opportunityid

|Property|Value|
|---|---|
|Description|**Parent Opportunity ID.**|
|DisplayName|**Parent Opportunity ID**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_opportunityid`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|opportunity|

### <a name="BKMK_msdyn_opportunitykpiitemId"></a> msdyn_opportunitykpiitemId

|Property|Value|
|---|---|
|Description|**Unique identifier for entity instances.**|
|DisplayName|**Unique Identifier for Entity Instances**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`msdyn_opportunitykpiitemid`|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|

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
|GlobalChoiceName|`msdyn_msdyn_opportunitykpiitem_msdyn_relationshiphealthscorestate`|

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
|Description|**Health score for the opportunity.**|
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
|GlobalChoiceName|`msdyn_msdyn_opportunitykpiitem_msdyn_relationshiphealthtrend`|

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
|Description|**Time spent by the team on activities.**|
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
|Description|**Time spent by the team on activities.**|
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
|Description|**Status of the Opportunity KPI.**|
|DisplayName|**Status**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statecode`|
|RequiredLevel|SystemRequired|
|Type|State|
|DefaultFormValue||
|GlobalChoiceName|`msdyn_opportunitykpiitem_statecode`|

#### statecode Choices/Options

|Value|Details|
|---|---|
|0|Label: **Active**<br />DefaultStatus: 1<br />InvariantName: `Active`|
|1|Label: **Inactive**<br />DefaultStatus: 2<br />InvariantName: `Inactive`|

### <a name="BKMK_statuscode"></a> statuscode

|Property|Value|
|---|---|
|Description|**Reason for the status of the Opportunity KPI Item**|
|DisplayName|**Status Reason**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statuscode`|
|RequiredLevel|None|
|Type|Status|
|DefaultFormValue||
|GlobalChoiceName|`msdyn_opportunitykpiitem_statuscode`|

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

- [lk_msdyn_opportunitykpiitem_createdby](#BKMK_lk_msdyn_opportunitykpiitem_createdby)
- [lk_msdyn_opportunitykpiitem_createdonbehalfby](#BKMK_lk_msdyn_opportunitykpiitem_createdonbehalfby)
- [lk_msdyn_opportunitykpiitem_modifiedby](#BKMK_lk_msdyn_opportunitykpiitem_modifiedby)
- [lk_msdyn_opportunitykpiitem_modifiedonbehalfby](#BKMK_lk_msdyn_opportunitykpiitem_modifiedonbehalfby)
- [msdyn_opportunity_msdyn_opportunitykpiitem_opportunityid](#BKMK_msdyn_opportunity_msdyn_opportunitykpiitem_opportunityid)
- [organization_msdyn_opportunitykpiitem](#BKMK_organization_msdyn_opportunitykpiitem)

### <a name="BKMK_lk_msdyn_opportunitykpiitem_createdby"></a> lk_msdyn_opportunitykpiitem_createdby

One-To-Many Relationship: [systemuser lk_msdyn_opportunitykpiitem_createdby](systemuser.md#BKMK_lk_msdyn_opportunitykpiitem_createdby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdby`|
|ReferencingEntityNavigationPropertyName|`createdby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_opportunitykpiitem_createdonbehalfby"></a> lk_msdyn_opportunitykpiitem_createdonbehalfby

One-To-Many Relationship: [systemuser lk_msdyn_opportunitykpiitem_createdonbehalfby](systemuser.md#BKMK_lk_msdyn_opportunitykpiitem_createdonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdonbehalfby`|
|ReferencingEntityNavigationPropertyName|`createdonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_opportunitykpiitem_modifiedby"></a> lk_msdyn_opportunitykpiitem_modifiedby

One-To-Many Relationship: [systemuser lk_msdyn_opportunitykpiitem_modifiedby](systemuser.md#BKMK_lk_msdyn_opportunitykpiitem_modifiedby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedby`|
|ReferencingEntityNavigationPropertyName|`modifiedby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_opportunitykpiitem_modifiedonbehalfby"></a> lk_msdyn_opportunitykpiitem_modifiedonbehalfby

One-To-Many Relationship: [systemuser lk_msdyn_opportunitykpiitem_modifiedonbehalfby](systemuser.md#BKMK_lk_msdyn_opportunitykpiitem_modifiedonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedonbehalfby`|
|ReferencingEntityNavigationPropertyName|`modifiedonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_opportunity_msdyn_opportunitykpiitem_opportunityid"></a> msdyn_opportunity_msdyn_opportunitykpiitem_opportunityid

One-To-Many Relationship: [opportunity msdyn_opportunity_msdyn_opportunitykpiitem_opportunityid](opportunity.md#BKMK_msdyn_opportunity_msdyn_opportunitykpiitem_opportunityid)

|Property|Value|
|---|---|
|ReferencedEntity|`opportunity`|
|ReferencedAttribute|`opportunityid`|
|ReferencingAttribute|`msdyn_opportunityid`|
|ReferencingEntityNavigationPropertyName|`msdyn_opportunityid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_organization_msdyn_opportunitykpiitem"></a> organization_msdyn_opportunitykpiitem

One-To-Many Relationship: [organization organization_msdyn_opportunitykpiitem](organization.md#BKMK_organization_msdyn_opportunitykpiitem)

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

- [msdyn_msdyn_opportunitykpiitem_opportunity_opportunitykpiid](#BKMK_msdyn_msdyn_opportunitykpiitem_opportunity_opportunitykpiid)
- [msdyn_opportunitykpiitem_AsyncOperations](#BKMK_msdyn_opportunitykpiitem_AsyncOperations)
- [msdyn_opportunitykpiitem_BulkDeleteFailures](#BKMK_msdyn_opportunitykpiitem_BulkDeleteFailures)
- [msdyn_opportunitykpiitem_MailboxTrackingFolders](#BKMK_msdyn_opportunitykpiitem_MailboxTrackingFolders)
- [msdyn_opportunitykpiitem_PrincipalObjectAttributeAccesses](#BKMK_msdyn_opportunitykpiitem_PrincipalObjectAttributeAccesses)
- [msdyn_opportunitykpiitem_ProcessSession](#BKMK_msdyn_opportunitykpiitem_ProcessSession)
- [msdyn_opportunitykpiitem_SyncErrors](#BKMK_msdyn_opportunitykpiitem_SyncErrors)

### <a name="BKMK_msdyn_msdyn_opportunitykpiitem_opportunity_opportunitykpiid"></a> msdyn_msdyn_opportunitykpiitem_opportunity_opportunitykpiid

Many-To-One Relationship: [opportunity msdyn_msdyn_opportunitykpiitem_opportunity_opportunitykpiid](opportunity.md#BKMK_msdyn_msdyn_opportunitykpiitem_opportunity_opportunitykpiid)

|Property|Value|
|---|---|
|ReferencingEntity|`opportunity`|
|ReferencingAttribute|`msdyn_opportunitykpiid`|
|ReferencedEntityNavigationPropertyName|`msdyn_msdyn_opportunitykpiitem_opportunity_opportunitykpiid`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_opportunitykpiitem_AsyncOperations"></a> msdyn_opportunitykpiitem_AsyncOperations

Many-To-One Relationship: [asyncoperation msdyn_opportunitykpiitem_AsyncOperations](asyncoperation.md#BKMK_msdyn_opportunitykpiitem_AsyncOperations)

|Property|Value|
|---|---|
|ReferencingEntity|`asyncoperation`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_opportunitykpiitem_AsyncOperations`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_opportunitykpiitem_BulkDeleteFailures"></a> msdyn_opportunitykpiitem_BulkDeleteFailures

Many-To-One Relationship: [bulkdeletefailure msdyn_opportunitykpiitem_BulkDeleteFailures](bulkdeletefailure.md#BKMK_msdyn_opportunitykpiitem_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencingEntity|`bulkdeletefailure`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_opportunitykpiitem_BulkDeleteFailures`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_opportunitykpiitem_MailboxTrackingFolders"></a> msdyn_opportunitykpiitem_MailboxTrackingFolders

Many-To-One Relationship: [mailboxtrackingfolder msdyn_opportunitykpiitem_MailboxTrackingFolders](mailboxtrackingfolder.md#BKMK_msdyn_opportunitykpiitem_MailboxTrackingFolders)

|Property|Value|
|---|---|
|ReferencingEntity|`mailboxtrackingfolder`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_opportunitykpiitem_MailboxTrackingFolders`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_opportunitykpiitem_PrincipalObjectAttributeAccesses"></a> msdyn_opportunitykpiitem_PrincipalObjectAttributeAccesses

Many-To-One Relationship: [principalobjectattributeaccess msdyn_opportunitykpiitem_PrincipalObjectAttributeAccesses](principalobjectattributeaccess.md#BKMK_msdyn_opportunitykpiitem_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencingEntity|`principalobjectattributeaccess`|
|ReferencingAttribute|`objectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_opportunitykpiitem_PrincipalObjectAttributeAccesses`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_opportunitykpiitem_ProcessSession"></a> msdyn_opportunitykpiitem_ProcessSession

Many-To-One Relationship: [processsession msdyn_opportunitykpiitem_ProcessSession](processsession.md#BKMK_msdyn_opportunitykpiitem_ProcessSession)

|Property|Value|
|---|---|
|ReferencingEntity|`processsession`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_opportunitykpiitem_ProcessSession`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_opportunitykpiitem_SyncErrors"></a> msdyn_opportunitykpiitem_SyncErrors

Many-To-One Relationship: [syncerror msdyn_opportunitykpiitem_SyncErrors](syncerror.md#BKMK_msdyn_opportunitykpiitem_SyncErrors)

|Property|Value|
|---|---|
|ReferencingEntity|`syncerror`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_opportunitykpiitem_SyncErrors`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|



### See also

[Dataverse table/entity reference](/power-apps/developer/data-platform/reference/about-entity-reference)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   

