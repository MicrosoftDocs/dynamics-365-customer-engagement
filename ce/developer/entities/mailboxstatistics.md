---
title: "MailboxStatistics Entity Reference (Developer Guide for Dynamics 365 Customer Engagement)| MicrosoftDocs"
description: "Includes schema information and supported messages for the MailboxStatistics entity."
ms.date: 12/05/2017
ms.service: "crm-online"
ms.topic: "reference"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: 3948cc48-07c8-7f60-0608-71c37158ad7c
author: "JimDaly"
ms.author: "jdaly"
manager: "jdaly"
---
# MailboxStatistics Entity Reference

Stores data regarding Mailbox processing cycles


## Messages

|Message|Web API Operation|SDK Assembly|
|-|-|-|
|Retrieve|GET [*org URI*]/api/data/v9.0/mailboxstatistics(*mailboxstatisticsid*)<br />See [Retrieve](../webapi/retrieve-entity-using-web-api.md)|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Retrieve*>|
|RetrieveMultiple|GET [*org URI*]/api/data/v9.0/mailboxstatistics<br />See [Query Data](../webapi/query-data-web-api.md)|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveMultipleRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.RetrieveMultiple*>|

## Entity Properties

|Property|Value|
|--------|-----|
|CollectionSchemaName|MailboxStatistics|
|DisplayCollectionName|Mailbox Statistics|
|DisplayName|Mailbox Statistics|
|EntitySetName|mailboxstatistics|
|IsBPFEntity|False|
|LogicalCollectionName|mailboxstatistics|
|LogicalName|mailboxstatistics|
|OwnershipType|None|
|PrimaryIdAttribute|mailboxstatisticsid|
|PrimaryNameAttribute||
|SchemaName|MailboxStatistics|

<a name="read-only-attributes"></a>
## Read-only attributes
These attributes return false for both **IsValidForCreate** or **IsValidForUpdate**. Listed by **SchemaName**.

- [AsyncEventId](#BKMK_AsyncEventId)
- [CrmItemsBacklog](#BKMK_CrmItemsBacklog)
- [IndividualStepDurations](#BKMK_IndividualStepDurations)
- [ItemsFailed](#BKMK_ItemsFailed)
- [ItemsProcessed](#BKMK_ItemsProcessed)
- [MachineName](#BKMK_MachineName)
- [MailboxId](#BKMK_MailboxId)
- [MailboxProcessCompletedOn](#BKMK_MailboxProcessCompletedOn)
- [MailboxProcessScheduledOn](#BKMK_MailboxProcessScheduledOn)
- [MailboxProcessStartedOn](#BKMK_MailboxProcessStartedOn)
- [MailboxStatisticsId](#BKMK_MailboxStatisticsId)
- [OperationTypeId](#BKMK_OperationTypeId)
- [OrganizationId](#BKMK_OrganizationId)
- [ProcessResult](#BKMK_ProcessResult)
- [ProcessTimeIntervalInMinutes](#BKMK_ProcessTimeIntervalInMinutes)
- [ScheduledTimeIntervalInMinutes](#BKMK_ScheduledTimeIntervalInMinutes)


### <a name="BKMK_AsyncEventId"></a> AsyncEventId

|Property|Value|
|--------|-----|
|Description|For internal use only.|
|DisplayName|Async Event Id|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|asynceventid|
|RequiredLevel|None|
|Type|Uniqueidentifier|


### <a name="BKMK_CrmItemsBacklog"></a> CrmItemsBacklog

|Property|Value|
|--------|-----|
|Description|Items remaining in CRM to process after this synchronization cycle.|
|DisplayName|Items in CRM Left to Process|
|Format|None|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|crmitemsbacklog|
|MaxValue|2147483647|
|MinValue|-1|
|RequiredLevel|None|
|Type|Integer|


### <a name="BKMK_IndividualStepDurations"></a> IndividualStepDurations

|Property|Value|
|--------|-----|
|Description|Time each exchange sync step is taking|
|DisplayName|Individual Step Durations|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|individualstepdurations|
|MaxLength|160|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_ItemsFailed"></a> ItemsFailed

|Property|Value|
|--------|-----|
|Description|Number of items processed unsuccessfully.|
|DisplayName|Items Failed|
|Format|None|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|itemsfailed|
|MaxValue|2147483647|
|MinValue|-1|
|RequiredLevel|None|
|Type|Integer|


### <a name="BKMK_ItemsProcessed"></a> ItemsProcessed

|Property|Value|
|--------|-----|
|Description|Number of items processed.|
|DisplayName|Items Processed|
|Format|None|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|itemsprocessed|
|MaxValue|2147483647|
|MinValue|-1|
|RequiredLevel|None|
|Type|Integer|


### <a name="BKMK_MachineName"></a> MachineName

|Property|Value|
|--------|-----|
|Description|Name of Machine on which mailbox was processed|
|DisplayName|Machine Name|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|machinename|
|MaxLength|160|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_MailboxId"></a> MailboxId

|Property|Value|
|--------|-----|
|Description|Regarding Mailbox.|
|DisplayName|Regarding Mailbox|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|mailboxid|
|RequiredLevel|SystemRequired|
|Targets|mailbox|
|Type|Lookup|


### <a name="BKMK_MailboxProcessCompletedOn"></a> MailboxProcessCompletedOn

|Property|Value|
|--------|-----|
|DateTimeBehavior|UserLocal|
|Description|Completion time of the synchronization cycle.|
|DisplayName|End Time for Processing|
|Format|DateAndTime|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|mailboxprocesscompletedon|
|RequiredLevel|None|
|Type|DateTime|


### <a name="BKMK_MailboxProcessScheduledOn"></a> MailboxProcessScheduledOn

|Property|Value|
|--------|-----|
|DateTimeBehavior|UserLocal|
|Description|Scheduled time of the synchronization cycle.|
|DisplayName|Scheduled Time for Processing|
|Format|DateAndTime|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|mailboxprocessscheduledon|
|RequiredLevel|None|
|Type|DateTime|


### <a name="BKMK_MailboxProcessStartedOn"></a> MailboxProcessStartedOn

|Property|Value|
|--------|-----|
|DateTimeBehavior|UserLocal|
|Description|Start time of the synchronization cycle.|
|DisplayName|Start Time for Processing|
|Format|DateAndTime|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|mailboxprocessstartedon|
|RequiredLevel|None|
|Type|DateTime|


### <a name="BKMK_MailboxStatisticsId"></a> MailboxStatisticsId

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|mailboxstatisticsid|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|


### <a name="BKMK_OperationTypeId"></a> OperationTypeId

|Property|Value|
|--------|-----|
|Description|Type of the mailbox operation|
|DisplayName|Mailbox Operation Type|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|operationtypeid|
|RequiredLevel|None|
|Type|Picklist|

#### OperationTypeId Options

|Value|Label|
|-----|-----|
|0|Incoming Email|
|1|Outgoing Email|
|2|ACT|



### <a name="BKMK_OrganizationId"></a> OrganizationId

|Property|Value|
|--------|-----|
|Description|Unique identifier of the organization associated with the record.|
|DisplayName|Organization|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|organizationid|
|RequiredLevel|SystemRequired|
|Targets|organization|
|Type|Lookup|


### <a name="BKMK_ProcessResult"></a> ProcessResult

|Property|Value|
|--------|-----|
|Description|Result of Mailbox processing cycle|
|DisplayName|Process Result|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|processresult|
|RequiredLevel|None|
|Type|Boolean|

#### ProcessResult Options

|Value|Label|
|-----|-----|
|1|Success|
|0|Failure|

**DefaultValue**: False



### <a name="BKMK_ProcessTimeIntervalInMinutes"></a> ProcessTimeIntervalInMinutes

|Property|Value|
|--------|-----|
|Description|Time it took to process the mailbox.|
|DisplayName|Process Duration|
|Format|None|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|processtimeintervalinminutes|
|MaxValue|2147483647|
|MinValue|-1|
|RequiredLevel|None|
|Type|Integer|


### <a name="BKMK_ScheduledTimeIntervalInMinutes"></a> ScheduledTimeIntervalInMinutes

|Property|Value|
|--------|-----|
|Description|Time it took from the scheduled time to the actual start time to process the mailbox.|
|DisplayName|Queue Duration|
|Format|None|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|scheduledtimeintervalinminutes|
|MaxValue|2147483647|
|MinValue|-1|
|RequiredLevel|None|
|Type|Integer|

<a name="manytoone"></a>

## Many-To-One Relationships

Each Many-To-One relationship is defined by a corresponding One-To-Many relationship with the related entity. Listed by **SchemaName**.

- [organization_mailboxstatistics](#BKMK_organization_mailboxstatistics)
- [mailbox_mailboxstatistics](#BKMK_mailbox_mailboxstatistics)


### <a name="BKMK_organization_mailboxstatistics"></a> organization_mailboxstatistics

See organization Entity [organization_mailboxstatistics](organization.md#BKMK_organization_mailboxstatistics) One-To-Many relationship.

### <a name="BKMK_mailbox_mailboxstatistics"></a> mailbox_mailboxstatistics

See mailbox Entity [mailbox_mailboxstatistics](mailbox.md#BKMK_mailbox_mailboxstatistics) One-To-Many relationship.

### See also

[About the Entity Reference](../about-entity-reference.md)<br />
[Programming reference for Dynamics 365 Customer Engagement](../programming-reference.md)<br />
[Web API Reference](/dynamics365/customer-engagement/web-api/about)<br />
<xref href="Microsoft.Dynamics.CRM.mailboxstatistics?text=mailboxstatistics EntityType" />