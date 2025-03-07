---
title: "Campaign Activity (CampaignActivity) table/entity reference (Microsoft Dynamics 365)"
description: "Includes schema information and supported messages for the Campaign Activity (CampaignActivity) table/entity with Microsoft Dynamics 365."
ms.topic: generated-reference
author: JimDaly
ms.author: jdaly
search.audienceType: 
  - developer
---

# Campaign Activity (CampaignActivity) table/entity reference (Microsoft Dynamics 365)

Task performed, or to be performed, by a user for planning or running a campaign.

## Messages

The following table lists the messages for the Campaign Activity (CampaignActivity) table.
Messages represent operations that can be performed on the table. They may also be events.

| Name <br />Is Event? |Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `AddItemCampaign`<br />Event: True |**AddItemCampaign action** |<xref:Microsoft.Crm.Sdk.Messages.AddItemCampaignRequest>|
| `AddItemCampaignActivity`<br />Event: True |**AddItemCampaignActivity action** |<xref:Microsoft.Crm.Sdk.Messages.AddItemCampaignActivityRequest>|
| `Assign`<br />Event: True |`PATCH` /campaignactivities(*activityid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `ownerid` property. |<xref:Microsoft.Crm.Sdk.Messages.AssignRequest>|
| `Associate`<br />Event: True |[Associate records](/power-apps/developer/data-platform/webapi/associate-disassociate-entities-using-web-api) |[Associate records](/power-apps/developer/data-platform/org-service/entity-operations-associate-disassociate#use-the-associate-method-or-associaterequest)|
| `Create`<br />Event: True |`POST` /campaignactivities<br />See [Create](/powerapps/developer/data-platform/webapi/create-entity-web-api) |[Create records](/power-apps/developer/data-platform/org-service/entity-operations-create#basic-create)|
| `CreateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.CreateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.CreateMultipleRequest>|
| `Delete`<br />Event: True |`DELETE` /campaignactivities(*activityid*)<br />See [Delete](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-delete) |[Delete records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-delete)|
| `Disassociate`<br />Event: True |[Disassociate records](/power-apps/developer/data-platform/webapi/associate-disassociate-entities-using-web-api) |[Disassociate records](/power-apps/developer/data-platform/org-service/entity-operations-associate-disassociate#use-the-disassociate-method-or-disassociaterequest)|
| `DistributeCampaignActivity`<br />Event: False |**DistributeCampaignActivity action** |<xref:Microsoft.Crm.Sdk.Messages.DistributeCampaignActivityRequest>|
| `GrantAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.GrantAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.GrantAccessRequest>|
| `ModifyAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.ModifyAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.ModifyAccessRequest>|
| `RemoveItemCampaign`<br />Event: True |**RemoveItemCampaign action** |<xref:Microsoft.Crm.Sdk.Messages.RemoveItemCampaignRequest>|
| `RemoveItemCampaignActivity`<br />Event: True |**RemoveItemCampaignActivity action** |<xref:Microsoft.Crm.Sdk.Messages.RemoveItemCampaignActivityRequest>|
| `Retrieve`<br />Event: True |`GET` /campaignactivities(*activityid*)<br />See [Retrieve](/powerapps/developer/data-platform/webapi/retrieve-entity-using-web-api) |[Retrieve records](/power-apps/developer/data-platform/org-service/entity-operations-retrieve)|
| `RetrieveMultiple`<br />Event: True |`GET` /campaignactivities<br />See [Query data](/power-apps/developer/data-platform/webapi/query-data-web-api) |[Query data](/power-apps/developer/data-platform/org-service/entity-operations-query-data)|
| `RetrievePrincipalAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RetrievePrincipalAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RetrievePrincipalAccessRequest>|
| `RetrieveSharedPrincipalsAndAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RetrieveSharedPrincipalsAndAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RetrieveSharedPrincipalsAndAccessRequest>|
| `RevokeAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RevokeAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RevokeAccessRequest>|
| `SetState`<br />Event: True |`PATCH` /campaignactivities(*activityid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `statecode` and `statuscode` properties. |<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|
| `Update`<br />Event: True |`PATCH` /campaignactivities(*activityid*)<br />See [Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) |[Update records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-update)|
| `UpdateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.UpdateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpdateMultipleRequest>|
| `Upsert`<br />Event: False |`PATCH` /campaignactivities(*activityid*)<br />See [Upsert a table row](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#upsert-a-table-row) |<xref:Microsoft.Xrm.Sdk.Messages.UpsertRequest>|
| `UpsertMultiple`<br />Event: False |<xref:Microsoft.Dynamics.CRM.UpsertMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpsertMultipleRequest>|

## Properties

The following table lists selected properties for the Campaign Activity (CampaignActivity) table.

|Property|Value|
| --- | --- |
| **DisplayName** | **Campaign Activity** |
| **DisplayCollectionName** | **Campaign Activities** |
| **SchemaName** | `CampaignActivity` |
| **CollectionSchemaName** | `CampaignActivities` |
| **EntitySetName** | `campaignactivities`|
| **LogicalName** | `campaignactivity` |
| **LogicalCollectionName** | `campaignactivities` |
| **PrimaryIdAttribute** | `activityid` |
| **PrimaryNameAttribute** |`subject` |
| **TableType** | `Standard` |
| **OwnershipType** | `UserOwned` |

## Writable columns/attributes

These columns/attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [ActivityAdditionalParams](#BKMK_ActivityAdditionalParams)
- [ActivityId](#BKMK_ActivityId)
- [ActualCost](#BKMK_ActualCost)
- [ActualDurationMinutes](#BKMK_ActualDurationMinutes)
- [ActualEnd](#BKMK_ActualEnd)
- [ActualStart](#BKMK_ActualStart)
- [BCC](#BKMK_BCC)
- [BudgetedCost](#BKMK_BudgetedCost)
- [Category](#BKMK_Category)
- [CC](#BKMK_CC)
- [ChannelTypeCode](#BKMK_ChannelTypeCode)
- [Community](#BKMK_Community)
- [Customers](#BKMK_Customers)
- [DeliveryPriorityCode](#BKMK_DeliveryPriorityCode)
- [Description](#BKMK_Description)
- [DoNotSendOnOptOut](#BKMK_DoNotSendOnOptOut)
- [ExchangeItemId](#BKMK_ExchangeItemId)
- [ExchangeWebLink](#BKMK_ExchangeWebLink)
- [ExcludeIfContactedInXDays](#BKMK_ExcludeIfContactedInXDays)
- [from](#BKMK_from)
- [IgnoreInactiveListMembers](#BKMK_IgnoreInactiveListMembers)
- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [IsBilled](#BKMK_IsBilled)
- [IsMapiPrivate](#BKMK_IsMapiPrivate)
- [IsWorkflowCreated](#BKMK_IsWorkflowCreated)
- [LastOnHoldTime](#BKMK_LastOnHoldTime)
- [LeftVoiceMail](#BKMK_LeftVoiceMail)
- [OptionalAttendees](#BKMK_OptionalAttendees)
- [Organizer](#BKMK_Organizer)
- [OverriddenCreatedOn](#BKMK_OverriddenCreatedOn)
- [OwnerId](#BKMK_OwnerId)
- [OwnerIdType](#BKMK_OwnerIdType)
- [Partners](#BKMK_Partners)
- [PriorityCode](#BKMK_PriorityCode)
- [ProcessId](#BKMK_ProcessId)
- [RegardingObjectId](#BKMK_RegardingObjectId)
- [RegardingObjectTypeCode](#BKMK_RegardingObjectTypeCode)
- [RequiredAttendees](#BKMK_RequiredAttendees)
- [Resources](#BKMK_Resources)
- [ScheduledEnd](#BKMK_ScheduledEnd)
- [ScheduledStart](#BKMK_ScheduledStart)
- [ServiceId](#BKMK_ServiceId)
- [SLAId](#BKMK_SLAId)
- [SortDate](#BKMK_SortDate)
- [StageId](#BKMK_StageId)
- [StateCode](#BKMK_StateCode)
- [StatusCode](#BKMK_StatusCode)
- [Subcategory](#BKMK_Subcategory)
- [Subject](#BKMK_Subject)
- [TimeZoneRuleVersionNumber](#BKMK_TimeZoneRuleVersionNumber)
- [To](#BKMK_To)
- [TraversedPath](#BKMK_TraversedPath)
- [TypeCode](#BKMK_TypeCode)
- [UTCConversionTimeZoneCode](#BKMK_UTCConversionTimeZoneCode)

### <a name="BKMK_ActivityAdditionalParams"></a> ActivityAdditionalParams

|Property|Value|
|---|---|
|Description|**Additional information provided by the external application as JSON. For internal use only.**|
|DisplayName|**Activity Additional Parameters**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`activityadditionalparams`|
|RequiredLevel|None|
|Type|Memo|
|Format|TextArea|
|FormatName|TextArea|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|8192|

### <a name="BKMK_ActivityId"></a> ActivityId

|Property|Value|
|---|---|
|Description|**Unique identifier of the campaign activity.**|
|DisplayName|**Campaign Activity**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`activityid`|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|

### <a name="BKMK_ActualCost"></a> ActualCost

|Property|Value|
|---|---|
|Description|**Type the actual cost of the campaign activity. The value entered is rolled up to the related campaign in the total cost calculations.**|
|DisplayName|**Actual Cost**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`actualcost`|
|RequiredLevel|None|
|Type|Money|
|ImeMode|Disabled|
|IsBaseCurrency|False|
|MaxValue|1000000000000|
|MinValue|0|
|Precision|2|
|PrecisionSource|2 (TransactionCurrency.CurrencyPrecision)|

### <a name="BKMK_ActualDurationMinutes"></a> ActualDurationMinutes

|Property|Value|
|---|---|
|Description|**Shows the value selected in the Duration field on the campaign activity. The duration is used to report the time spent on the activity.**|
|DisplayName|**Actual Duration**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`actualdurationminutes`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|0|

### <a name="BKMK_ActualEnd"></a> ActualEnd

|Property|Value|
|---|---|
|Description|**Enter the date when the campaign activity was actually  completed.**|
|DisplayName|**Actual End**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`actualend`|
|RequiredLevel|None|
|Type|DateTime|
|CanChangeDateTimeBehavior|False|
|DateTimeBehavior|UserLocal|
|Format|DateOnly|
|ImeMode|Inactive|
|SourceTypeMask|0|

### <a name="BKMK_ActualStart"></a> ActualStart

|Property|Value|
|---|---|
|Description|**Enter the actual start date and time for the campaign activity to determine if the campaign activity started on the scheduled time.**|
|DisplayName|**Actual Start**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`actualstart`|
|RequiredLevel|None|
|Type|DateTime|
|CanChangeDateTimeBehavior|False|
|DateTimeBehavior|UserLocal|
|Format|DateOnly|
|ImeMode|Inactive|
|SourceTypeMask|0|

### <a name="BKMK_BCC"></a> BCC

|Property|Value|
|---|---|
|Description|**Blind Carbon-copy (bcc) recipients of the activity.**|
|DisplayName|**BCC**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`bcc`|
|RequiredLevel|None|
|Type|PartyList|
|Targets|account, contact, systemuser|

### <a name="BKMK_BudgetedCost"></a> BudgetedCost

|Property|Value|
|---|---|
|Description|**Type the allocated budget of the campaign activity for estimated versus actual cost reporting.**|
|DisplayName|**Budget Allocated**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`budgetedcost`|
|RequiredLevel|None|
|Type|Money|
|ImeMode|Disabled|
|IsBaseCurrency|False|
|MaxValue|1000000000000|
|MinValue|0|
|Precision|2|
|PrecisionSource|2 (TransactionCurrency.CurrencyPrecision)|

### <a name="BKMK_Category"></a> Category

|Property|Value|
|---|---|
|Description|**Type a category to identify the campaign activity type, such as new business development or customer retention, to tie the campaign activity to a business group or function.**|
|DisplayName|**Category**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`category`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|250|

### <a name="BKMK_CC"></a> CC

|Property|Value|
|---|---|
|Description|**Carbon-copy (cc) recipients of the activity.**|
|DisplayName|**CC**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`cc`|
|RequiredLevel|None|
|Type|PartyList|
|Targets|account, contact, systemuser|

### <a name="BKMK_ChannelTypeCode"></a> ChannelTypeCode

|Property|Value|
|---|---|
|Description|**Select how communications for this activity will be sent, such as phone, letter, fax, or email.**|
|DisplayName|**Channel**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`channeltypecode`|
|RequiredLevel|None|
|Type|Picklist|
|DefaultFormValue|-1|
|GlobalChoiceName|`campaignactivity_channeltypecode`|

#### ChannelTypeCode Choices/Options

|Value|Label|
|---|---|
|1|**Phone**|
|2|**Appointment**|
|3|**Letter**|
|4|**Letter via Mail Merge(deprecated)**|
|5|**Fax**|
|6|**Fax via Mail Merge(deprecated)**|
|7|**Email**|
|8|**Email via Mail Merge(deprecated)**|
|9|**Other**|

### <a name="BKMK_Community"></a> Community

|Property|Value|
|---|---|
|Description|**Shows how contact about the social activity originated, such as from Twitter or Facebook. This field is read-only.**|
|DisplayName|**Social Channel**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`community`|
|RequiredLevel|None|
|Type|Picklist|
|DefaultFormValue|-1|
|GlobalChoiceName|`socialprofile_community`|

#### Community Choices/Options

|Value|Label|
|---|---|
|0|**Other**|
|1|**Facebook**|
|2|**Twitter**|
|3|**Line**|
|4|**Wechat**|
|5|**Cortana**|
|6|**Direct Line**|
|7|**Microsoft Teams**|
|8|**Direct Line Speech**|
|9|**Email**|
|10|**GroupMe**|
|11|**Kik**|
|12|**Telegram**|
|13|**Skype**|
|14|**Slack**|
|15|**WhatsApp**|
|16|**Apple Messages For Business**|
|17|**Google's Business Messages**|

### <a name="BKMK_Customers"></a> Customers

|Property|Value|
|---|---|
|Description|**Customer with which the activity is associated.**|
|DisplayName|**Customers**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`customers`|
|RequiredLevel|None|
|Type|PartyList|
|Targets|account, contact|

### <a name="BKMK_DeliveryPriorityCode"></a> DeliveryPriorityCode

|Property|Value|
|---|---|
|Description|**Priority of delivery of the activity to the email server.**|
|DisplayName|**Delivery Priority**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`deliveryprioritycode`|
|RequiredLevel|None|
|Type|Picklist|
|DefaultFormValue|1|
|GlobalChoiceName|`activitypointer_deliveryprioritycode`|

#### DeliveryPriorityCode Choices/Options

|Value|Label|
|---|---|
|0|**Low**|
|1|**Normal**|
|2|**High**|

### <a name="BKMK_Description"></a> Description

|Property|Value|
|---|---|
|Description|**Type additional information to describe the campaign activity, such as key talking points, objectives, or details about the target audience.**|
|DisplayName|**Description**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`description`|
|RequiredLevel|None|
|Type|Memo|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|2000|

### <a name="BKMK_DoNotSendOnOptOut"></a> DoNotSendOnOptOut

|Property|Value|
|---|---|
|Description|**Select whether to override the opt-out settings on leads, contacts, and accounts for the members of the target marketing lists of the campaign activity. If No is selected, marketing materials will be sent to members who have opted out.**|
|DisplayName|**Exclude Members Who Opt Out**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`donotsendonoptout`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`campaignactivity_donotsendonoptout`|
|DefaultValue|True|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_ExchangeItemId"></a> ExchangeItemId

|Property|Value|
|---|---|
|Description|**The message id of activity which is returned from Exchange Server.**|
|DisplayName|**Exchange Item ID**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`exchangeitemid`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|200|

### <a name="BKMK_ExchangeWebLink"></a> ExchangeWebLink

|Property|Value|
|---|---|
|Description|**Shows the web link of Activity of type email.**|
|DisplayName|**Exchange WebLink**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`exchangeweblink`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|1250|

### <a name="BKMK_ExcludeIfContactedInXDays"></a> ExcludeIfContactedInXDays

|Property|Value|
|---|---|
|Description|**Limits the frequency (in days) of marketing activities directed at any contact. Contacts that have been contacted more recently than this will be excluded from new campaign activity distributions. Enter a value of zero to disable the limit.**|
|DisplayName|**No. of Days**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`excludeifcontactedinxdays`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|9999|
|MinValue|0|

### <a name="BKMK_from"></a> from

|Property|Value|
|---|---|
|Description|**For system use only.**|
|DisplayName|**From**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`from`|
|RequiredLevel|None|
|Type|PartyList|
|Targets|account, contact, systemuser|

### <a name="BKMK_IgnoreInactiveListMembers"></a> IgnoreInactiveListMembers

|Property|Value|
|---|---|
|Description|**Select whether inactive marketing list members will be excluded from the campaign activity distribution.**|
|DisplayName|**Ignore Inactive Marketing List Members**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`ignoreinactivelistmembers`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`campaignactivity_ignoreinactivelistmembers`|
|DefaultValue|True|
|True Label|Yes|
|False Label|No|

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

### <a name="BKMK_IsBilled"></a> IsBilled

|Property|Value|
|---|---|
|Description|**Information regarding whether the campaign activity was billed as part of resolving a case.**|
|DisplayName|**Is Billed**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`isbilled`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`campaignactivity_isbilled`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_IsMapiPrivate"></a> IsMapiPrivate

|Property|Value|
|---|---|
|Description|**For internal use only.**|
|DisplayName|**Is Private**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`ismapiprivate`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`_campaignactivity_ismapiprivate`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_IsWorkflowCreated"></a> IsWorkflowCreated

|Property|Value|
|---|---|
|Description|**Information about whether the campaign activity is created by a workflow rule.**|
|DisplayName|**Is Workflow Created**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`isworkflowcreated`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`campaignactivity_isworkflowcreated`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_LastOnHoldTime"></a> LastOnHoldTime

|Property|Value|
|---|---|
|Description|**Contains the date and time stamp of the last on hold time.**|
|DisplayName|**Last On Hold Time**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`lastonholdtime`|
|RequiredLevel|None|
|Type|DateTime|
|CanChangeDateTimeBehavior|False|
|DateTimeBehavior|UserLocal|
|Format|DateAndTime|
|ImeMode|Inactive|
|SourceTypeMask|0|

### <a name="BKMK_LeftVoiceMail"></a> LeftVoiceMail

|Property|Value|
|---|---|
|Description|**Left the voice mail**|
|DisplayName|**Left Voice Mail**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`leftvoicemail`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`_campaignactivity_leftvoicemail`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_OptionalAttendees"></a> OptionalAttendees

|Property|Value|
|---|---|
|Description|**List of optional attendees for the activity.**|
|DisplayName|**Optional Attendees**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`optionalattendees`|
|RequiredLevel|None|
|Type|PartyList|
|Targets|account, contact, systemuser|

### <a name="BKMK_Organizer"></a> Organizer

|Property|Value|
|---|---|
|Description|**Person who organized the activity.**|
|DisplayName|**Organizer**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`organizer`|
|RequiredLevel|None|
|Type|PartyList|
|Targets|systemuser|

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
|Description|**Unique identifier of the user or team who owns the activity.**|
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
|Description||
|DisplayName||
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`owneridtype`|
|RequiredLevel|SystemRequired|
|Type|EntityName|

### <a name="BKMK_Partners"></a> Partners

|Property|Value|
|---|---|
|Description|**Outsource vendor with which activity is associated.**|
|DisplayName|**Outsource Vendors**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`partners`|
|RequiredLevel|None|
|Type|PartyList|
|Targets|account, contact|

### <a name="BKMK_PriorityCode"></a> PriorityCode

|Property|Value|
|---|---|
|Description|**Select the priority so that preferred customers or critical issues are handled quickly.**|
|DisplayName|**Priority**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`prioritycode`|
|RequiredLevel|None|
|Type|Picklist|
|DefaultFormValue|1|
|GlobalChoiceName|`campaignactivity_prioritycode`|

#### PriorityCode Choices/Options

|Value|Label|
|---|---|
|0|**Low**|
|1|**Normal**|
|2|**High**|

### <a name="BKMK_ProcessId"></a> ProcessId

|Property|Value|
|---|---|
|Description|**Unique identifier of the Process.**|
|DisplayName|**Process**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`processid`|
|RequiredLevel|None|
|Type|Uniqueidentifier|

### <a name="BKMK_RegardingObjectId"></a> RegardingObjectId

|Property|Value|
|---|---|
|Description|**Choose the parent campaign so that the campaign activity costs reflect in the correct campaign for reporting.**|
|DisplayName|**Parent Campaign**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`regardingobjectid`|
|RequiredLevel|ApplicationRequired|
|Type|Lookup|
|Targets|campaign|

### <a name="BKMK_RegardingObjectTypeCode"></a> RegardingObjectTypeCode

|Property|Value|
|---|---|
|Description||
|DisplayName||
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`regardingobjecttypecode`|
|RequiredLevel|None|
|Type|EntityName|

### <a name="BKMK_RequiredAttendees"></a> RequiredAttendees

|Property|Value|
|---|---|
|Description|**List of required attendees for the activity.**|
|DisplayName|**Required Attendees**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`requiredattendees`|
|RequiredLevel|None|
|Type|PartyList|
|Targets|account, contact, systemuser|

### <a name="BKMK_Resources"></a> Resources

|Property|Value|
|---|---|
|Description|**Users or facility/equipment that are required for the activity.**|
|DisplayName|**Resources**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`resources`|
|RequiredLevel|None|
|Type|PartyList|
|Targets|systemuser|

### <a name="BKMK_ScheduledEnd"></a> ScheduledEnd

|Property|Value|
|---|---|
|Description|**Enter the expected due date and time for the activity to be completed to provide details about the timing of the campaign activity.**|
|DisplayName|**Scheduled End**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`scheduledend`|
|RequiredLevel|None|
|Type|DateTime|
|CanChangeDateTimeBehavior|False|
|DateTimeBehavior|UserLocal|
|Format|DateOnly|
|ImeMode|Inactive|
|SourceTypeMask|0|

### <a name="BKMK_ScheduledStart"></a> ScheduledStart

|Property|Value|
|---|---|
|Description|**Enter the expected start date and time for the activity to provide details about timing of the campaign activity.**|
|DisplayName|**Scheduled Start**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`scheduledstart`|
|RequiredLevel|None|
|Type|DateTime|
|CanChangeDateTimeBehavior|False|
|DateTimeBehavior|UserLocal|
|Format|DateOnly|
|ImeMode|Inactive|
|SourceTypeMask|0|

### <a name="BKMK_ServiceId"></a> ServiceId

|Property|Value|
|---|---|
|Description|**Unique identifier of the associated service.**|
|DisplayName|**Service**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`serviceid`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|service|

### <a name="BKMK_SLAId"></a> SLAId

|Property|Value|
|---|---|
|Description|**Choose the service level agreement (SLA) that you want to apply to the case record.**|
|DisplayName|**SLA**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`slaid`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|sla|

### <a name="BKMK_SortDate"></a> SortDate

|Property|Value|
|---|---|
|Description|**Shows the date and time by which the activities are sorted.**|
|DisplayName|**Sort Date**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`sortdate`|
|RequiredLevel|None|
|Type|DateTime|
|CanChangeDateTimeBehavior|False|
|DateTimeBehavior|UserLocal|
|Format|DateAndTime|
|ImeMode|Inactive|
|SourceTypeMask|0|

### <a name="BKMK_StageId"></a> StageId

|Property|Value|
|---|---|
|Description|**Unique identifier of the Stage.**|
|DisplayName|**(Deprecated) Process Stage**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`stageid`|
|RequiredLevel|None|
|Type|Uniqueidentifier|

### <a name="BKMK_StateCode"></a> StateCode

|Property|Value|
|---|---|
|Description|**Shows whether the campaign activity is open, completed, or canceled. Completed and canceled campaign activities are read-only and can't be edited.**|
|DisplayName|**Status**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statecode`|
|RequiredLevel|SystemRequired|
|Type|State|
|DefaultFormValue|0|
|GlobalChoiceName|`campaignactivity_statecode`|

#### StateCode Choices/Options

|Value|Details|
|---|---|
|0|Label: **Open**<br />DefaultStatus: 1<br />InvariantName: `Open`|
|1|Label: **Closed**<br />DefaultStatus: 2<br />InvariantName: `Closed`|
|2|Label: **Canceled**<br />DefaultStatus: 3<br />InvariantName: `Canceled`|

### <a name="BKMK_StatusCode"></a> StatusCode

|Property|Value|
|---|---|
|Description|**Select the campaign activity's status.**|
|DisplayName|**Status Reason**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statuscode`|
|RequiredLevel|None|
|Type|Status|
|DefaultFormValue|-1|
|GlobalChoiceName|`campaignactivity_statuscode`|

#### StatusCode Choices/Options

|Value|Details|
|---|---|
|0|Label: **In Progress**<br />State:0<br />TransitionData: None|
|1|Label: **Proposed**<br />State:0<br />TransitionData: None|
|2|Label: **Closed**<br />State:1<br />TransitionData: None|
|3|Label: **Canceled**<br />State:2<br />TransitionData: None|
|4|Label: **Pending**<br />State:0<br />TransitionData: None|
|5|Label: **System Aborted**<br />State:0<br />TransitionData: None|
|6|Label: **Completed**<br />State:0<br />TransitionData: None|

### <a name="BKMK_Subcategory"></a> Subcategory

|Property|Value|
|---|---|
|Description|**Type a subcategory to identify the campaign activity type and relate the activity to a specific product, sales region, business group, or other function.**|
|DisplayName|**Sub-Category**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`subcategory`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|250|

### <a name="BKMK_Subject"></a> Subject

|Property|Value|
|---|---|
|Description|**Type a short description about the objective or primary topic of the campaign activity.**|
|DisplayName|**Subject**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`subject`|
|RequiredLevel|ApplicationRequired|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|200|

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

### <a name="BKMK_To"></a> To

|Property|Value|
|---|---|
|Description|**Person who is the receiver of the activity.**|
|DisplayName|**To**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`to`|
|RequiredLevel|None|
|Type|PartyList|
|Targets|account, contact, systemuser|

### <a name="BKMK_TraversedPath"></a> TraversedPath

|Property|Value|
|---|---|
|Description|**For internal use only.**|
|DisplayName|**(Deprecated) Traversed Path**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`traversedpath`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|1250|

### <a name="BKMK_TypeCode"></a> TypeCode

|Property|Value|
|---|---|
|Description|**Select the type of campaign activity to indicate the purpose of the activity.**|
|DisplayName|**Type**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`typecode`|
|RequiredLevel|None|
|Type|Picklist|
|DefaultFormValue|1|
|GlobalChoiceName|`campaignactivity_typecode`|

#### TypeCode Choices/Options

|Value|Label|
|---|---|
|1|**Research**|
|2|**Content Preparation**|
|3|**Target Marketing List Creation**|
|4|**Lead Qualification**|
|5|**Content Distribution**|
|6|**Direct Initial Contact**|
|7|**Direct Follow-Up Contact**|
|8|**Reminder Distribution**|

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

- [ActivityTypeCode](#BKMK_ActivityTypeCode)
- [ActualCost_Base](#BKMK_ActualCost_Base)
- [BudgetedCost_Base](#BKMK_BudgetedCost_Base)
- [CreatedBy](#BKMK_CreatedBy)
- [CreatedOn](#BKMK_CreatedOn)
- [CreatedOnBehalfBy](#BKMK_CreatedOnBehalfBy)
- [DeliveryLastAttemptedOn](#BKMK_DeliveryLastAttemptedOn)
- [ExchangeRate](#BKMK_ExchangeRate)
- [InstanceTypeCode](#BKMK_InstanceTypeCode)
- [IsRegularActivity](#BKMK_IsRegularActivity)
- [ModifiedBy](#BKMK_ModifiedBy)
- [ModifiedOn](#BKMK_ModifiedOn)
- [ModifiedOnBehalfBy](#BKMK_ModifiedOnBehalfBy)
- [OnHoldTime](#BKMK_OnHoldTime)
- [OwnerIdName](#BKMK_OwnerIdName)
- [OwnerIdYomiName](#BKMK_OwnerIdYomiName)
- [OwningBusinessUnit](#BKMK_OwningBusinessUnit)
- [OwningTeam](#BKMK_OwningTeam)
- [OwningUser](#BKMK_OwningUser)
- [PostponeActivityProcessingUntil](#BKMK_PostponeActivityProcessingUntil)
- [ScheduledDurationMinutes](#BKMK_ScheduledDurationMinutes)
- [SenderMailboxId](#BKMK_SenderMailboxId)
- [SentOn](#BKMK_SentOn)
- [SeriesId](#BKMK_SeriesId)
- [SLAInvokedId](#BKMK_SLAInvokedId)
- [TransactionCurrencyId](#BKMK_TransactionCurrencyId)
- [VersionNumber](#BKMK_VersionNumber)

### <a name="BKMK_ActivityTypeCode"></a> ActivityTypeCode

|Property|Value|
|---|---|
|Description|**Type of activity.**|
|DisplayName|**Activity Type**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`activitytypecode`|
|RequiredLevel|SystemRequired|
|Type|EntityName|

### <a name="BKMK_ActualCost_Base"></a> ActualCost_Base

|Property|Value|
|---|---|
|Description|**Value of the Actual Cost in base currency.**|
|DisplayName|**Actual Cost (Base)**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`actualcost_base`|
|RequiredLevel|None|
|Type|Money|
|ImeMode|Disabled|
|IsBaseCurrency|True|
|MaxValue|922337203685477|
|MinValue|-922337203685477|
|Precision|4|
|PrecisionSource|2 (TransactionCurrency.CurrencyPrecision)|

### <a name="BKMK_BudgetedCost_Base"></a> BudgetedCost_Base

|Property|Value|
|---|---|
|Description|**Value of the Budget Allocated in base currency.**|
|DisplayName|**Budget Allocated (Base)**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`budgetedcost_base`|
|RequiredLevel|None|
|Type|Money|
|ImeMode|Disabled|
|IsBaseCurrency|True|
|MaxValue|922337203685477|
|MinValue|-922337203685477|
|Precision|4|
|PrecisionSource|2 (TransactionCurrency.CurrencyPrecision)|

### <a name="BKMK_CreatedBy"></a> CreatedBy

|Property|Value|
|---|---|
|Description|**Unique identifier of the user who created the activity.**|
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
|Description|**Date and time when the activity was created.**|
|DisplayName|**Date Created**|
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
|Description|**Unique identifier of the delegate user who created the activitypointer.**|
|DisplayName|**Created By (Delegate)**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`createdonbehalfby`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|systemuser|

### <a name="BKMK_DeliveryLastAttemptedOn"></a> DeliveryLastAttemptedOn

|Property|Value|
|---|---|
|Description|**Date and time when the delivery of the activity was last attempted.**|
|DisplayName|**Date Delivery Last Attempted**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`deliverylastattemptedon`|
|RequiredLevel|None|
|Type|DateTime|
|CanChangeDateTimeBehavior|False|
|DateTimeBehavior|UserLocal|
|Format|DateAndTime|
|ImeMode|Inactive|
|SourceTypeMask|0|

### <a name="BKMK_ExchangeRate"></a> ExchangeRate

|Property|Value|
|---|---|
|Description|**Shows the conversion rate of the record's currency. The exchange rate is used to convert all money fields in the record from the local currency to the system's default currency.**|
|DisplayName|**Exchange Rate**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`exchangerate`|
|RequiredLevel|None|
|Type|Decimal|
|ImeMode|Disabled|
|MaxValue|100000000000|
|MinValue|1E-12|
|Precision|12|
|SourceTypeMask|0|

### <a name="BKMK_InstanceTypeCode"></a> InstanceTypeCode

|Property|Value|
|---|---|
|Description|**Type of instance of a recurring series.**|
|DisplayName|**Recurring Instance Type**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`instancetypecode`|
|RequiredLevel|SystemRequired|
|Type|Picklist|
|DefaultFormValue|0|
|GlobalChoiceName|`_campaignactivity_instancetypecode`|

#### InstanceTypeCode Choices/Options

|Value|Label|
|---|---|
|0|**Not Recurring**|
|1|**Recurring Master**|
|2|**Recurring Instance**|
|3|**Recurring Exception**|
|4|**Recurring Future Exception**|

### <a name="BKMK_IsRegularActivity"></a> IsRegularActivity

|Property|Value|
|---|---|
|Description|**Information regarding whether the activity is a regular activity type or event type.**|
|DisplayName|**Is Regular Activity**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`isregularactivity`|
|RequiredLevel|SystemRequired|
|Type|Boolean|
|GlobalChoiceName|`activitypointer_isregularactivity`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_ModifiedBy"></a> ModifiedBy

|Property|Value|
|---|---|
|Description|**Unique identifier of user who last modified the activity.**|
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
|Description|**Date and time when activity was last modified.**|
|DisplayName|**Last Updated**|
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
|Description|**Unique identifier of the delegate user who last modified the activitypointer.**|
|DisplayName|**Modified By (Delegate)**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`modifiedonbehalfby`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|systemuser|

### <a name="BKMK_OnHoldTime"></a> OnHoldTime

|Property|Value|
|---|---|
|Description|**Shows how long, in minutes, that the record was on hold.**|
|DisplayName|**On Hold Time (Minutes)**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`onholdtime`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|-2147483648|

### <a name="BKMK_OwnerIdName"></a> OwnerIdName

|Property|Value|
|---|---|
|Description||
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
|Description||
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
|Description|**Unique identifier of the business unit that owns the activity.**|
|DisplayName|**Owning Business Unit**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`owningbusinessunit`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|businessunit|

### <a name="BKMK_OwningTeam"></a> OwningTeam

|Property|Value|
|---|---|
|Description|**Unique identifier of the team that owns the activity.**|
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
|Description|**Unique identifier of the user that owns the activity.**|
|DisplayName|**Owning User**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`owninguser`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|systemuser|

### <a name="BKMK_PostponeActivityProcessingUntil"></a> PostponeActivityProcessingUntil

|Property|Value|
|---|---|
|Description|**For internal use only.**|
|DisplayName|**Delay activity processing until**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`postponeactivityprocessinguntil`|
|RequiredLevel|None|
|Type|DateTime|
|CanChangeDateTimeBehavior|False|
|DateTimeBehavior|UserLocal|
|Format|DateAndTime|
|ImeMode|Inactive|
|SourceTypeMask|0|

### <a name="BKMK_ScheduledDurationMinutes"></a> ScheduledDurationMinutes

|Property|Value|
|---|---|
|Description|**Scheduled duration, specified in minutes, of the campaign activity.**|
|DisplayName|**Scheduled Duration**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`scheduleddurationminutes`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|0|

### <a name="BKMK_SenderMailboxId"></a> SenderMailboxId

|Property|Value|
|---|---|
|Description|**Unique identifier of the mailbox associated with the sender of the email message.**|
|DisplayName|**Sender's Mailbox**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`sendermailboxid`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|mailbox|

### <a name="BKMK_SentOn"></a> SentOn

|Property|Value|
|---|---|
|Description|**Date and time when the activity was sent.**|
|DisplayName|**Date Sent**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`senton`|
|RequiredLevel|None|
|Type|DateTime|
|CanChangeDateTimeBehavior|False|
|DateTimeBehavior|UserLocal|
|Format|DateAndTime|
|ImeMode|Inactive|
|SourceTypeMask|0|

### <a name="BKMK_SeriesId"></a> SeriesId

|Property|Value|
|---|---|
|Description|**Uniqueidentifier specifying the id of recurring series of an instance.**|
|DisplayName|**Series Id**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`seriesid`|
|RequiredLevel|None|
|Type|Uniqueidentifier|

### <a name="BKMK_SLAInvokedId"></a> SLAInvokedId

|Property|Value|
|---|---|
|Description|**Last SLA that was applied to this case. This field is for internal use only.**|
|DisplayName|**Last SLA applied**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`slainvokedid`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|sla|

### <a name="BKMK_TransactionCurrencyId"></a> TransactionCurrencyId

|Property|Value|
|---|---|
|Description|**Choose the local currency for the record to make sure budgets are reported in the correct currency.**|
|DisplayName|**Currency**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`transactioncurrencyid`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|transactioncurrency|

### <a name="BKMK_VersionNumber"></a> VersionNumber

|Property|Value|
|---|---|
|Description|**Version number of the activity.**|
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

- [activity_pointer_campaignactivity](#BKMK_activity_pointer_campaignactivity)
- [adx_invitation_CampaignActivities](#BKMK_adx_invitation_CampaignActivities)
- [bookableresourcebooking_CampaignActivities](#BKMK_bookableresourcebooking_CampaignActivities)
- [bookableresourcebookingheader_CampaignActivities](#BKMK_bookableresourcebookingheader_CampaignActivities)
- [business_unit_campaignactivity_activities](#BKMK_business_unit_campaignactivity_activities)
- [Campaign_CampaignActivities](#BKMK_Campaign_CampaignActivities)
- [campaignactivity_mailbox_sendermailboxid](#BKMK_campaignactivity_mailbox_sendermailboxid)
- [campaignactivity_owner_ownerid](#BKMK_campaignactivity_owner_ownerid)
- [campaignactivity_sla_slaid](#BKMK_campaignactivity_sla_slaid)
- [campaignactivity_sla_slainvokedid](#BKMK_campaignactivity_sla_slainvokedid)
- [lk_campaignactivity_createdby](#BKMK_lk_campaignactivity_createdby)
- [lk_campaignactivity_createdonbehalfby](#BKMK_lk_campaignactivity_createdonbehalfby)
- [lk_campaignactivity_modifiedby](#BKMK_lk_campaignactivity_modifiedby)
- [lk_campaignactivity_modifiedonbehalfby](#BKMK_lk_campaignactivity_modifiedonbehalfby)
- [mspp_adplacement_CampaignActivities](#BKMK_mspp_adplacement_CampaignActivities)
- [mspp_pollplacement_CampaignActivities](#BKMK_mspp_pollplacement_CampaignActivities)
- [mspp_publishingstatetransitionrule_CampaignActivities](#BKMK_mspp_publishingstatetransitionrule_CampaignActivities)
- [mspp_redirect_CampaignActivities](#BKMK_mspp_redirect_CampaignActivities)
- [mspp_shortcut_CampaignActivities](#BKMK_mspp_shortcut_CampaignActivities)
- [mspp_website_CampaignActivities](#BKMK_mspp_website_CampaignActivities)
- [processstage_campaignactivities](#BKMK_processstage_campaignactivities)
- [team_campaignactivity](#BKMK_team_campaignactivity)
- [transactioncurrency_campaignactivity](#BKMK_transactioncurrency_campaignactivity)
- [user_campaignactivity](#BKMK_user_campaignactivity)

### <a name="BKMK_activity_pointer_campaignactivity"></a> activity_pointer_campaignactivity

One-To-Many Relationship: [activitypointer activity_pointer_campaignactivity](activitypointer.md#BKMK_activity_pointer_campaignactivity)

|Property|Value|
|---|---|
|ReferencedEntity|`activitypointer`|
|ReferencedAttribute|`activityid`|
|ReferencingAttribute|`activityid`|
|ReferencingEntityNavigationPropertyName|`activityid_activitypointer`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_adx_invitation_CampaignActivities"></a> adx_invitation_CampaignActivities

One-To-Many Relationship: [adx_invitation adx_invitation_CampaignActivities](adx_invitation.md#BKMK_adx_invitation_CampaignActivities)

|Property|Value|
|---|---|
|ReferencedEntity|`adx_invitation`|
|ReferencedAttribute|`adx_invitationid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_adx_invitation_campaignactivity`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_bookableresourcebooking_CampaignActivities"></a> bookableresourcebooking_CampaignActivities

One-To-Many Relationship: [bookableresourcebooking bookableresourcebooking_CampaignActivities](bookableresourcebooking.md#BKMK_bookableresourcebooking_CampaignActivities)

|Property|Value|
|---|---|
|ReferencedEntity|`bookableresourcebooking`|
|ReferencedAttribute|`bookableresourcebookingid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_bookableresourcebooking_campaignactivity`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_bookableresourcebookingheader_CampaignActivities"></a> bookableresourcebookingheader_CampaignActivities

One-To-Many Relationship: [bookableresourcebookingheader bookableresourcebookingheader_CampaignActivities](bookableresourcebookingheader.md#BKMK_bookableresourcebookingheader_CampaignActivities)

|Property|Value|
|---|---|
|ReferencedEntity|`bookableresourcebookingheader`|
|ReferencedAttribute|`bookableresourcebookingheaderid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_bookableresourcebookingheader_campaignactivity`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_business_unit_campaignactivity_activities"></a> business_unit_campaignactivity_activities

One-To-Many Relationship: [businessunit business_unit_campaignactivity_activities](businessunit.md#BKMK_business_unit_campaignactivity_activities)

|Property|Value|
|---|---|
|ReferencedEntity|`businessunit`|
|ReferencedAttribute|`businessunitid`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencingEntityNavigationPropertyName|`owningbusinessunit_campaignactivity`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_Campaign_CampaignActivities"></a> Campaign_CampaignActivities

One-To-Many Relationship: [campaign Campaign_CampaignActivities](campaign.md#BKMK_Campaign_CampaignActivities)

|Property|Value|
|---|---|
|ReferencedEntity|`campaign`|
|ReferencedAttribute|`campaignid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_campaign_campaignactivity`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_campaignactivity_mailbox_sendermailboxid"></a> campaignactivity_mailbox_sendermailboxid

One-To-Many Relationship: [mailbox campaignactivity_mailbox_sendermailboxid](mailbox.md#BKMK_campaignactivity_mailbox_sendermailboxid)

|Property|Value|
|---|---|
|ReferencedEntity|`mailbox`|
|ReferencedAttribute|`mailboxid`|
|ReferencingAttribute|`sendermailboxid`|
|ReferencingEntityNavigationPropertyName|`sendermailboxid_campaignactivity`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_campaignactivity_owner_ownerid"></a> campaignactivity_owner_ownerid

One-To-Many Relationship: [owner campaignactivity_owner_ownerid](owner.md#BKMK_campaignactivity_owner_ownerid)

|Property|Value|
|---|---|
|ReferencedEntity|`owner`|
|ReferencedAttribute|`ownerid`|
|ReferencingAttribute|`ownerid`|
|ReferencingEntityNavigationPropertyName|`ownerid_campaignactivity`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_campaignactivity_sla_slaid"></a> campaignactivity_sla_slaid

One-To-Many Relationship: [sla campaignactivity_sla_slaid](sla.md#BKMK_campaignactivity_sla_slaid)

|Property|Value|
|---|---|
|ReferencedEntity|`sla`|
|ReferencedAttribute|`slaid`|
|ReferencingAttribute|`slaid`|
|ReferencingEntityNavigationPropertyName|`sla_activitypointer_sla_campaignactivity`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_campaignactivity_sla_slainvokedid"></a> campaignactivity_sla_slainvokedid

One-To-Many Relationship: [sla campaignactivity_sla_slainvokedid](sla.md#BKMK_campaignactivity_sla_slainvokedid)

|Property|Value|
|---|---|
|ReferencedEntity|`sla`|
|ReferencedAttribute|`slaid`|
|ReferencingAttribute|`slainvokedid`|
|ReferencingEntityNavigationPropertyName|`slainvokedid_activitypointer_sla_campaignactivity`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_campaignactivity_createdby"></a> lk_campaignactivity_createdby

One-To-Many Relationship: [systemuser lk_campaignactivity_createdby](systemuser.md#BKMK_lk_campaignactivity_createdby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdby`|
|ReferencingEntityNavigationPropertyName|`createdby_campaignactivity`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_campaignactivity_createdonbehalfby"></a> lk_campaignactivity_createdonbehalfby

One-To-Many Relationship: [systemuser lk_campaignactivity_createdonbehalfby](systemuser.md#BKMK_lk_campaignactivity_createdonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdonbehalfby`|
|ReferencingEntityNavigationPropertyName|`createdonbehalfby_campaignactivity`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_campaignactivity_modifiedby"></a> lk_campaignactivity_modifiedby

One-To-Many Relationship: [systemuser lk_campaignactivity_modifiedby](systemuser.md#BKMK_lk_campaignactivity_modifiedby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedby`|
|ReferencingEntityNavigationPropertyName|`modifiedby_campaignactivity`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_campaignactivity_modifiedonbehalfby"></a> lk_campaignactivity_modifiedonbehalfby

One-To-Many Relationship: [systemuser lk_campaignactivity_modifiedonbehalfby](systemuser.md#BKMK_lk_campaignactivity_modifiedonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedonbehalfby`|
|ReferencingEntityNavigationPropertyName|`modifiedonbehalfby_campaignactivity`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_mspp_adplacement_CampaignActivities"></a> mspp_adplacement_CampaignActivities

One-To-Many Relationship: [mspp_adplacement mspp_adplacement_CampaignActivities](mspp_adplacement.md#BKMK_mspp_adplacement_CampaignActivities)

|Property|Value|
|---|---|
|ReferencedEntity|`mspp_adplacement`|
|ReferencedAttribute|`mspp_adplacementid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_mspp_adplacement_campaignactivity`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_mspp_pollplacement_CampaignActivities"></a> mspp_pollplacement_CampaignActivities

One-To-Many Relationship: [mspp_pollplacement mspp_pollplacement_CampaignActivities](mspp_pollplacement.md#BKMK_mspp_pollplacement_CampaignActivities)

|Property|Value|
|---|---|
|ReferencedEntity|`mspp_pollplacement`|
|ReferencedAttribute|`mspp_pollplacementid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_mspp_pollplacement_campaignactivity`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_mspp_publishingstatetransitionrule_CampaignActivities"></a> mspp_publishingstatetransitionrule_CampaignActivities

One-To-Many Relationship: [mspp_publishingstatetransitionrule mspp_publishingstatetransitionrule_CampaignActivities](mspp_publishingstatetransitionrule.md#BKMK_mspp_publishingstatetransitionrule_CampaignActivities)

|Property|Value|
|---|---|
|ReferencedEntity|`mspp_publishingstatetransitionrule`|
|ReferencedAttribute|`mspp_publishingstatetransitionruleid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_mspp_publishingstatetransitionrule_campaignactivity`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_mspp_redirect_CampaignActivities"></a> mspp_redirect_CampaignActivities

One-To-Many Relationship: [mspp_redirect mspp_redirect_CampaignActivities](mspp_redirect.md#BKMK_mspp_redirect_CampaignActivities)

|Property|Value|
|---|---|
|ReferencedEntity|`mspp_redirect`|
|ReferencedAttribute|`mspp_redirectid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_mspp_redirect_campaignactivity`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_mspp_shortcut_CampaignActivities"></a> mspp_shortcut_CampaignActivities

One-To-Many Relationship: [mspp_shortcut mspp_shortcut_CampaignActivities](mspp_shortcut.md#BKMK_mspp_shortcut_CampaignActivities)

|Property|Value|
|---|---|
|ReferencedEntity|`mspp_shortcut`|
|ReferencedAttribute|`mspp_shortcutid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_mspp_shortcut_campaignactivity`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_mspp_website_CampaignActivities"></a> mspp_website_CampaignActivities

One-To-Many Relationship: [mspp_website mspp_website_CampaignActivities](mspp_website.md#BKMK_mspp_website_CampaignActivities)

|Property|Value|
|---|---|
|ReferencedEntity|`mspp_website`|
|ReferencedAttribute|`mspp_websiteid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_mspp_website_campaignactivity`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_processstage_campaignactivities"></a> processstage_campaignactivities

One-To-Many Relationship: [processstage processstage_campaignactivities](processstage.md#BKMK_processstage_campaignactivities)

|Property|Value|
|---|---|
|ReferencedEntity|`processstage`|
|ReferencedAttribute|`processstageid`|
|ReferencingAttribute|`stageid`|
|ReferencingEntityNavigationPropertyName|`stageid_processstage`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_team_campaignactivity"></a> team_campaignactivity

One-To-Many Relationship: [team team_campaignactivity](team.md#BKMK_team_campaignactivity)

|Property|Value|
|---|---|
|ReferencedEntity|`team`|
|ReferencedAttribute|`teamid`|
|ReferencingAttribute|`owningteam`|
|ReferencingEntityNavigationPropertyName|`owningteam_campaignactivity`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_transactioncurrency_campaignactivity"></a> transactioncurrency_campaignactivity

One-To-Many Relationship: [transactioncurrency transactioncurrency_campaignactivity](transactioncurrency.md#BKMK_transactioncurrency_campaignactivity)

|Property|Value|
|---|---|
|ReferencedEntity|`transactioncurrency`|
|ReferencedAttribute|`transactioncurrencyid`|
|ReferencingAttribute|`transactioncurrencyid`|
|ReferencingEntityNavigationPropertyName|`transactioncurrencyid_campaignactivity`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Restrict`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_user_campaignactivity"></a> user_campaignactivity

One-To-Many Relationship: [systemuser user_campaignactivity](systemuser.md#BKMK_user_campaignactivity)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`owninguser`|
|ReferencingEntityNavigationPropertyName|`owninguser_campaignactivity`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|


## One-to-Many relationships

These relationships are one-to-many. Listed by **SchemaName**.

- [campaignactivity_activity_parties](#BKMK_campaignactivity_activity_parties)
- [campaignactivity_activityparties](#BKMK_campaignactivity_activityparties)
- [CampaignActivity_ActivityPointers](#BKMK_CampaignActivity_ActivityPointers)
- [campaignactivity_adx_inviteredemptions](#BKMK_campaignactivity_adx_inviteredemptions)
- [campaignactivity_adx_portalcomments](#BKMK_campaignactivity_adx_portalcomments)
- [CampaignActivity_Annotation](#BKMK_CampaignActivity_Annotation)
- [CampaignActivity_Appointments](#BKMK_CampaignActivity_Appointments)
- [CampaignActivity_AsyncOperations](#BKMK_CampaignActivity_AsyncOperations)
- [CampaignActivity_BulkDeleteFailures](#BKMK_CampaignActivity_BulkDeleteFailures)
- [CampaignActivity_BulkOperations](#BKMK_CampaignActivity_BulkOperations)
- [campaignactivity_CampaignResponses](#BKMK_campaignactivity_CampaignResponses)
- [campaignactivity_chats](#BKMK_campaignactivity_chats)
- [campaignactivity_connections1](#BKMK_campaignactivity_connections1)
- [campaignactivity_connections2](#BKMK_campaignactivity_connections2)
- [CampaignActivity_Emails](#BKMK_CampaignActivity_Emails)
- [CampaignActivity_Faxes](#BKMK_CampaignActivity_Faxes)
- [campaignactivity_IncidentResolutions](#BKMK_campaignactivity_IncidentResolutions)
- [CampaignActivity_Letters](#BKMK_CampaignActivity_Letters)
- [CampaignActivity_logs](#BKMK_CampaignActivity_logs)
- [CampaignActivity_MailboxTrackingFolder](#BKMK_CampaignActivity_MailboxTrackingFolder)
- [campaignactivity_msdyn_copilottranscripts](#BKMK_campaignactivity_msdyn_copilottranscripts)
- [campaignactivity_msdyn_ocliveworkitems](#BKMK_campaignactivity_msdyn_ocliveworkitems)
- [campaignactivity_msdyn_ocsessions](#BKMK_campaignactivity_msdyn_ocsessions)
- [campaignactivity_msfp_alerts](#BKMK_campaignactivity_msfp_alerts)
- [campaignactivity_msfp_surveyinvites](#BKMK_campaignactivity_msfp_surveyinvites)
- [campaignactivity_msfp_surveyresponses](#BKMK_campaignactivity_msfp_surveyresponses)
- [campaignactivity_OpportunityCloses](#BKMK_campaignactivity_OpportunityCloses)
- [campaignactivity_OrderCloses](#BKMK_campaignactivity_OrderCloses)
- [CampaignActivity_Phonecalls](#BKMK_CampaignActivity_Phonecalls)
- [campaignactivity_principalobjectattributeaccess](#BKMK_campaignactivity_principalobjectattributeaccess)
- [CampaignActivity_ProcessSessions](#BKMK_CampaignActivity_ProcessSessions)
- [CampaignActivity_QueueItem](#BKMK_CampaignActivity_QueueItem)
- [campaignactivity_QuoteCloses](#BKMK_campaignactivity_QuoteCloses)
- [CampaignActivity_RecurringAppointmentMasters](#BKMK_CampaignActivity_RecurringAppointmentMasters)
- [campaignactivity_ServiceAppointments](#BKMK_campaignactivity_ServiceAppointments)
- [campaignactivity_SocialActivities](#BKMK_campaignactivity_SocialActivities)
- [CampaignActivity_SyncErrors](#BKMK_CampaignActivity_SyncErrors)
- [CampaignActivity_Tasks](#BKMK_CampaignActivity_Tasks)

### <a name="BKMK_campaignactivity_activity_parties"></a> campaignactivity_activity_parties

Many-To-One Relationship: [activityparty campaignactivity_activity_parties](activityparty.md#BKMK_campaignactivity_activity_parties)

|Property|Value|
|---|---|
|ReferencingEntity|`activityparty`|
|ReferencingAttribute|`activityid`|
|ReferencedEntityNavigationPropertyName|`campaignactivity_activity_parties`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_campaignactivity_activityparties"></a> campaignactivity_activityparties

Many-To-One Relationship: [activityparty campaignactivity_activityparties](activityparty.md#BKMK_campaignactivity_activityparties)

|Property|Value|
|---|---|
|ReferencingEntity|`activityparty`|
|ReferencingAttribute|`partyid`|
|ReferencedEntityNavigationPropertyName|`campaignactivity_activityparties`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_CampaignActivity_ActivityPointers"></a> CampaignActivity_ActivityPointers

Many-To-One Relationship: [activitypointer CampaignActivity_ActivityPointers](activitypointer.md#BKMK_CampaignActivity_ActivityPointers)

|Property|Value|
|---|---|
|ReferencingEntity|`activitypointer`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`CampaignActivity_ActivityPointers`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `7f15e2bb-305a-468f-9af7-be865755a984`|

### <a name="BKMK_campaignactivity_adx_inviteredemptions"></a> campaignactivity_adx_inviteredemptions

Many-To-One Relationship: [adx_inviteredemption campaignactivity_adx_inviteredemptions](adx_inviteredemption.md#BKMK_campaignactivity_adx_inviteredemptions)

|Property|Value|
|---|---|
|ReferencingEntity|`adx_inviteredemption`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`campaignactivity_adx_inviteredemptions`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_campaignactivity_adx_portalcomments"></a> campaignactivity_adx_portalcomments

Many-To-One Relationship: [adx_portalcomment campaignactivity_adx_portalcomments](adx_portalcomment.md#BKMK_campaignactivity_adx_portalcomments)

|Property|Value|
|---|---|
|ReferencingEntity|`adx_portalcomment`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`campaignactivity_adx_portalcomments`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_CampaignActivity_Annotation"></a> CampaignActivity_Annotation

Many-To-One Relationship: [annotation CampaignActivity_Annotation](annotation.md#BKMK_CampaignActivity_Annotation)

|Property|Value|
|---|---|
|ReferencingEntity|`annotation`|
|ReferencingAttribute|`objectid`|
|ReferencedEntityNavigationPropertyName|`CampaignActivity_Annotation`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_CampaignActivity_Appointments"></a> CampaignActivity_Appointments

Many-To-One Relationship: [appointment CampaignActivity_Appointments](appointment.md#BKMK_CampaignActivity_Appointments)

|Property|Value|
|---|---|
|ReferencingEntity|`appointment`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`CampaignActivity_Appointments`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_CampaignActivity_AsyncOperations"></a> CampaignActivity_AsyncOperations

Many-To-One Relationship: [asyncoperation CampaignActivity_AsyncOperations](asyncoperation.md#BKMK_CampaignActivity_AsyncOperations)

|Property|Value|
|---|---|
|ReferencingEntity|`asyncoperation`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`CampaignActivity_AsyncOperations`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_CampaignActivity_BulkDeleteFailures"></a> CampaignActivity_BulkDeleteFailures

Many-To-One Relationship: [bulkdeletefailure CampaignActivity_BulkDeleteFailures](bulkdeletefailure.md#BKMK_CampaignActivity_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencingEntity|`bulkdeletefailure`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`CampaignActivity_BulkDeleteFailures`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_CampaignActivity_BulkOperations"></a> CampaignActivity_BulkOperations

Many-To-One Relationship: [bulkoperation CampaignActivity_BulkOperations](bulkoperation.md#BKMK_CampaignActivity_BulkOperations)

|Property|Value|
|---|---|
|ReferencingEntity|`bulkoperation`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`CampaignActivity_BulkOperations`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_campaignactivity_CampaignResponses"></a> campaignactivity_CampaignResponses

Many-To-One Relationship: [campaignresponse campaignactivity_CampaignResponses](campaignresponse.md#BKMK_campaignactivity_CampaignResponses)

|Property|Value|
|---|---|
|ReferencingEntity|`campaignresponse`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`campaignactivity_CampaignResponses`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_campaignactivity_chats"></a> campaignactivity_chats

Many-To-One Relationship: [chat campaignactivity_chats](chat.md#BKMK_campaignactivity_chats)

|Property|Value|
|---|---|
|ReferencingEntity|`chat`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`campaignactivity_chats`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_campaignactivity_connections1"></a> campaignactivity_connections1

Many-To-One Relationship: [connection campaignactivity_connections1](connection.md#BKMK_campaignactivity_connections1)

|Property|Value|
|---|---|
|ReferencingEntity|`connection`|
|ReferencingAttribute|`record1id`|
|ReferencedEntityNavigationPropertyName|`campaignactivity_connections1`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 100<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_campaignactivity_connections2"></a> campaignactivity_connections2

Many-To-One Relationship: [connection campaignactivity_connections2](connection.md#BKMK_campaignactivity_connections2)

|Property|Value|
|---|---|
|ReferencingEntity|`connection`|
|ReferencingAttribute|`record2id`|
|ReferencedEntityNavigationPropertyName|`campaignactivity_connections2`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 100<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_CampaignActivity_Emails"></a> CampaignActivity_Emails

Many-To-One Relationship: [email CampaignActivity_Emails](email.md#BKMK_CampaignActivity_Emails)

|Property|Value|
|---|---|
|ReferencingEntity|`email`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`CampaignActivity_Emails`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_CampaignActivity_Faxes"></a> CampaignActivity_Faxes

Many-To-One Relationship: [fax CampaignActivity_Faxes](fax.md#BKMK_CampaignActivity_Faxes)

|Property|Value|
|---|---|
|ReferencingEntity|`fax`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`CampaignActivity_Faxes`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_campaignactivity_IncidentResolutions"></a> campaignactivity_IncidentResolutions

Many-To-One Relationship: [incidentresolution campaignactivity_IncidentResolutions](incidentresolution.md#BKMK_campaignactivity_IncidentResolutions)

|Property|Value|
|---|---|
|ReferencingEntity|`incidentresolution`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`campaignactivity_IncidentResolutions`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `7f15e2bb-305a-468f-9af7-be865755a984`|

### <a name="BKMK_CampaignActivity_Letters"></a> CampaignActivity_Letters

Many-To-One Relationship: [letter CampaignActivity_Letters](letter.md#BKMK_CampaignActivity_Letters)

|Property|Value|
|---|---|
|ReferencingEntity|`letter`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`CampaignActivity_Letters`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_CampaignActivity_logs"></a> CampaignActivity_logs

Many-To-One Relationship: [bulkoperationlog CampaignActivity_logs](bulkoperationlog.md#BKMK_CampaignActivity_logs)

|Property|Value|
|---|---|
|ReferencingEntity|`bulkoperationlog`|
|ReferencingAttribute|`campaignactivityid`|
|ReferencedEntityNavigationPropertyName|`CampaignActivity_logs`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_CampaignActivity_MailboxTrackingFolder"></a> CampaignActivity_MailboxTrackingFolder

Many-To-One Relationship: [mailboxtrackingfolder CampaignActivity_MailboxTrackingFolder](mailboxtrackingfolder.md#BKMK_CampaignActivity_MailboxTrackingFolder)

|Property|Value|
|---|---|
|ReferencingEntity|`mailboxtrackingfolder`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`CampaignActivity_MailboxTrackingFolder`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_campaignactivity_msdyn_copilottranscripts"></a> campaignactivity_msdyn_copilottranscripts

Many-To-One Relationship: [msdyn_copilottranscript campaignactivity_msdyn_copilottranscripts](msdyn_copilottranscript.md#BKMK_campaignactivity_msdyn_copilottranscripts)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_copilottranscript`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`campaignactivity_msdyn_copilottranscripts`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `7f15e2bb-305a-468f-9af7-be865755a984`|

### <a name="BKMK_campaignactivity_msdyn_ocliveworkitems"></a> campaignactivity_msdyn_ocliveworkitems

Many-To-One Relationship: [msdyn_ocliveworkitem campaignactivity_msdyn_ocliveworkitems](msdyn_ocliveworkitem.md#BKMK_campaignactivity_msdyn_ocliveworkitems)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocliveworkitem`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`campaignactivity_msdyn_ocliveworkitems`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `7f15e2bb-305a-468f-9af7-be865755a984`|

### <a name="BKMK_campaignactivity_msdyn_ocsessions"></a> campaignactivity_msdyn_ocsessions

Many-To-One Relationship: [msdyn_ocsession campaignactivity_msdyn_ocsessions](msdyn_ocsession.md#BKMK_campaignactivity_msdyn_ocsessions)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocsession`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`campaignactivity_msdyn_ocsessions`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `7f15e2bb-305a-468f-9af7-be865755a984`|

### <a name="BKMK_campaignactivity_msfp_alerts"></a> campaignactivity_msfp_alerts

Many-To-One Relationship: [msfp_alert campaignactivity_msfp_alerts](msfp_alert.md#BKMK_campaignactivity_msfp_alerts)

|Property|Value|
|---|---|
|ReferencingEntity|`msfp_alert`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`campaignactivity_msfp_alerts`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `7f15e2bb-305a-468f-9af7-be865755a984`|

### <a name="BKMK_campaignactivity_msfp_surveyinvites"></a> campaignactivity_msfp_surveyinvites

Many-To-One Relationship: [msfp_surveyinvite campaignactivity_msfp_surveyinvites](msfp_surveyinvite.md#BKMK_campaignactivity_msfp_surveyinvites)

|Property|Value|
|---|---|
|ReferencingEntity|`msfp_surveyinvite`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`campaignactivity_msfp_surveyinvites`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `7f15e2bb-305a-468f-9af7-be865755a984`|

### <a name="BKMK_campaignactivity_msfp_surveyresponses"></a> campaignactivity_msfp_surveyresponses

Many-To-One Relationship: [msfp_surveyresponse campaignactivity_msfp_surveyresponses](msfp_surveyresponse.md#BKMK_campaignactivity_msfp_surveyresponses)

|Property|Value|
|---|---|
|ReferencingEntity|`msfp_surveyresponse`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`campaignactivity_msfp_surveyresponses`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `7f15e2bb-305a-468f-9af7-be865755a984`|

### <a name="BKMK_campaignactivity_OpportunityCloses"></a> campaignactivity_OpportunityCloses

Many-To-One Relationship: [opportunityclose campaignactivity_OpportunityCloses](opportunityclose.md#BKMK_campaignactivity_OpportunityCloses)

|Property|Value|
|---|---|
|ReferencingEntity|`opportunityclose`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`campaignactivity_OpportunityCloses`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `7f15e2bb-305a-468f-9af7-be865755a984`|

### <a name="BKMK_campaignactivity_OrderCloses"></a> campaignactivity_OrderCloses

Many-To-One Relationship: [orderclose campaignactivity_OrderCloses](orderclose.md#BKMK_campaignactivity_OrderCloses)

|Property|Value|
|---|---|
|ReferencingEntity|`orderclose`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`campaignactivity_OrderCloses`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `7f15e2bb-305a-468f-9af7-be865755a984`|

### <a name="BKMK_CampaignActivity_Phonecalls"></a> CampaignActivity_Phonecalls

Many-To-One Relationship: [phonecall CampaignActivity_Phonecalls](phonecall.md#BKMK_CampaignActivity_Phonecalls)

|Property|Value|
|---|---|
|ReferencingEntity|`phonecall`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`CampaignActivity_Phonecalls`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_campaignactivity_principalobjectattributeaccess"></a> campaignactivity_principalobjectattributeaccess

Many-To-One Relationship: [principalobjectattributeaccess campaignactivity_principalobjectattributeaccess](principalobjectattributeaccess.md#BKMK_campaignactivity_principalobjectattributeaccess)

|Property|Value|
|---|---|
|ReferencingEntity|`principalobjectattributeaccess`|
|ReferencingAttribute|`objectid`|
|ReferencedEntityNavigationPropertyName|`campaignactivity_principalobjectattributeaccess`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_CampaignActivity_ProcessSessions"></a> CampaignActivity_ProcessSessions

Many-To-One Relationship: [processsession CampaignActivity_ProcessSessions](processsession.md#BKMK_CampaignActivity_ProcessSessions)

|Property|Value|
|---|---|
|ReferencingEntity|`processsession`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`CampaignActivity_ProcessSessions`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 110<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_CampaignActivity_QueueItem"></a> CampaignActivity_QueueItem

Many-To-One Relationship: [queueitem CampaignActivity_QueueItem](queueitem.md#BKMK_CampaignActivity_QueueItem)

|Property|Value|
|---|---|
|ReferencingEntity|`queueitem`|
|ReferencingAttribute|`objectid`|
|ReferencedEntityNavigationPropertyName|`CampaignActivity_QueueItem`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_campaignactivity_QuoteCloses"></a> campaignactivity_QuoteCloses

Many-To-One Relationship: [quoteclose campaignactivity_QuoteCloses](quoteclose.md#BKMK_campaignactivity_QuoteCloses)

|Property|Value|
|---|---|
|ReferencingEntity|`quoteclose`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`campaignactivity_QuoteCloses`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `7f15e2bb-305a-468f-9af7-be865755a984`|

### <a name="BKMK_CampaignActivity_RecurringAppointmentMasters"></a> CampaignActivity_RecurringAppointmentMasters

Many-To-One Relationship: [recurringappointmentmaster CampaignActivity_RecurringAppointmentMasters](recurringappointmentmaster.md#BKMK_CampaignActivity_RecurringAppointmentMasters)

|Property|Value|
|---|---|
|ReferencingEntity|`recurringappointmentmaster`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`CampaignActivity_RecurringAppointmentMasters`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_campaignactivity_ServiceAppointments"></a> campaignactivity_ServiceAppointments

Many-To-One Relationship: [serviceappointment campaignactivity_ServiceAppointments](serviceappointment.md#BKMK_campaignactivity_ServiceAppointments)

|Property|Value|
|---|---|
|ReferencingEntity|`serviceappointment`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`campaignactivity_ServiceAppointments`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `7f15e2bb-305a-468f-9af7-be865755a984`|

### <a name="BKMK_campaignactivity_SocialActivities"></a> campaignactivity_SocialActivities

Many-To-One Relationship: [socialactivity campaignactivity_SocialActivities](socialactivity.md#BKMK_campaignactivity_SocialActivities)

|Property|Value|
|---|---|
|ReferencingEntity|`socialactivity`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`campaignactivity_SocialActivities`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_CampaignActivity_SyncErrors"></a> CampaignActivity_SyncErrors

Many-To-One Relationship: [syncerror CampaignActivity_SyncErrors](syncerror.md#BKMK_CampaignActivity_SyncErrors)

|Property|Value|
|---|---|
|ReferencingEntity|`syncerror`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`CampaignActivity_SyncErrors`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_CampaignActivity_Tasks"></a> CampaignActivity_Tasks

Many-To-One Relationship: [task CampaignActivity_Tasks](task.md#BKMK_CampaignActivity_Tasks)

|Property|Value|
|---|---|
|ReferencingEntity|`task`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`CampaignActivity_Tasks`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|


## Many-to-Many relationships

These relationships are many-to-many. Listed by **SchemaName**.

- [CampaignActivity_Accounts](#BKMK_CampaignActivity_Accounts)
- [CampaignActivity_Contacts](#BKMK_CampaignActivity_Contacts)
- [CampaignActivity_Leads](#BKMK_CampaignActivity_Leads)
- [campaignactivitylist_association](#BKMK_campaignactivitylist_association)
- [campaignactivitysalesliterature_association](#BKMK_campaignactivitysalesliterature_association)

### <a name="BKMK_CampaignActivity_Accounts"></a> CampaignActivity_Accounts

See [account CampaignActivity_Accounts Many-To-Many Relationship](account.md#BKMK_CampaignActivity_Accounts)

|Property|Value|
|---|---|
|IntersectEntityName|`bulkoperationlog`|
|IsCustomizable|False|
|SchemaName|`CampaignActivity_Accounts`|
|IntersectAttribute|`campaignactivityid`|
|NavigationPropertyName|`CampaignActivity_Accounts`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_CampaignActivity_Contacts"></a> CampaignActivity_Contacts

See [contact CampaignActivity_Contacts Many-To-Many Relationship](contact.md#BKMK_CampaignActivity_Contacts)

|Property|Value|
|---|---|
|IntersectEntityName|`bulkoperationlog`|
|IsCustomizable|False|
|SchemaName|`CampaignActivity_Contacts`|
|IntersectAttribute|`campaignactivityid`|
|NavigationPropertyName|`CampaignActivity_Contacts`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_CampaignActivity_Leads"></a> CampaignActivity_Leads

See [lead CampaignActivity_Leads Many-To-Many Relationship](lead.md#BKMK_CampaignActivity_Leads)

|Property|Value|
|---|---|
|IntersectEntityName|`bulkoperationlog`|
|IsCustomizable|False|
|SchemaName|`CampaignActivity_Leads`|
|IntersectAttribute|`campaignactivityid`|
|NavigationPropertyName|`CampaignActivity_Leads`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_campaignactivitylist_association"></a> campaignactivitylist_association

See [list campaignactivitylist_association Many-To-Many Relationship](list.md#BKMK_campaignactivitylist_association)

|Property|Value|
|---|---|
|IntersectEntityName|`campaignactivityitem`|
|IsCustomizable|False|
|SchemaName|`campaignactivitylist_association`|
|IntersectAttribute|`campaignactivityid`|
|NavigationPropertyName|`campaignactivitylist_association`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_campaignactivitysalesliterature_association"></a> campaignactivitysalesliterature_association

See [salesliterature campaignactivitysalesliterature_association Many-To-Many Relationship](salesliterature.md#BKMK_campaignactivitysalesliterature_association)

|Property|Value|
|---|---|
|IntersectEntityName|`campaignactivityitem`|
|IsCustomizable|False|
|SchemaName|`campaignactivitysalesliterature_association`|
|IntersectAttribute|`campaignactivityid`|
|NavigationPropertyName|`campaignactivitysalesliterature_association`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|



### See also

[Dataverse table/entity reference](/power-apps/developer/data-platform/reference/about-entity-reference)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   

