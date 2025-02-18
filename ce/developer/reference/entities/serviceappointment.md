---
title: "Service Activity (ServiceAppointment) table/entity reference (Microsoft Dynamics 365)"
description: "Includes schema information and supported messages for the Service Activity (ServiceAppointment) table/entity with Microsoft Dynamics 365."
ms.topic: generated-reference
author: JimDaly
ms.author: jdaly
search.audienceType: 
  - developer
---

# Service Activity (ServiceAppointment) table/entity reference (Microsoft Dynamics 365)

Activity offered by the organization to satisfy its customer's needs. Each service activity includes date, time, duration, and required resources.

## Messages

The following table lists the messages for the Service Activity (ServiceAppointment) table.
Messages represent operations that can be performed on the table. They may also be events.

| Name <br />Is Event? |Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `Assign`<br />Event: True |`PATCH` /serviceappointments(*activityid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `ownerid` property. |<xref:Microsoft.Crm.Sdk.Messages.AssignRequest>|
| `Associate`<br />Event: True |[Associate records](/power-apps/developer/data-platform/webapi/associate-disassociate-entities-using-web-api) |[Associate records](/power-apps/developer/data-platform/org-service/entity-operations-associate-disassociate#use-the-associate-method-or-associaterequest)|
| `Book`<br />Event: True |<xref:Microsoft.Dynamics.CRM.Book?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.BookRequest>|
| `Create`<br />Event: True |`POST` /serviceappointments<br />See [Create](/powerapps/developer/data-platform/webapi/create-entity-web-api) |[Create records](/power-apps/developer/data-platform/org-service/entity-operations-create#basic-create)|
| `CreateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.CreateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.CreateMultipleRequest>|
| `Delete`<br />Event: True |`DELETE` /serviceappointments(*activityid*)<br />See [Delete](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-delete) |[Delete records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-delete)|
| `Disassociate`<br />Event: True |[Disassociate records](/power-apps/developer/data-platform/webapi/associate-disassociate-entities-using-web-api) |[Disassociate records](/power-apps/developer/data-platform/org-service/entity-operations-associate-disassociate#use-the-disassociate-method-or-disassociaterequest)|
| `GrantAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.GrantAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.GrantAccessRequest>|
| `ModifyAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.ModifyAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.ModifyAccessRequest>|
| `Reschedule`<br />Event: True |<xref:Microsoft.Dynamics.CRM.Reschedule?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RescheduleRequest>|
| `Retrieve`<br />Event: True |`GET` /serviceappointments(*activityid*)<br />See [Retrieve](/powerapps/developer/data-platform/webapi/retrieve-entity-using-web-api) |[Retrieve records](/power-apps/developer/data-platform/org-service/entity-operations-retrieve)|
| `RetrieveMultiple`<br />Event: True |`GET` /serviceappointments<br />See [Query data](/power-apps/developer/data-platform/webapi/query-data-web-api) |[Query data](/power-apps/developer/data-platform/org-service/entity-operations-query-data)|
| `RetrievePrincipalAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RetrievePrincipalAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RetrievePrincipalAccessRequest>|
| `RetrieveSharedPrincipalsAndAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RetrieveSharedPrincipalsAndAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RetrieveSharedPrincipalsAndAccessRequest>|
| `RevokeAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RevokeAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RevokeAccessRequest>|
| `SetState`<br />Event: True |`PATCH` /serviceappointments(*activityid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `statecode` and `statuscode` properties. |<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|
| `Update`<br />Event: True |`PATCH` /serviceappointments(*activityid*)<br />See [Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) |[Update records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-update)|
| `UpdateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.UpdateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpdateMultipleRequest>|
| `Upsert`<br />Event: False |`PATCH` /serviceappointments(*activityid*)<br />See [Upsert a table row](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#upsert-a-table-row) |<xref:Microsoft.Xrm.Sdk.Messages.UpsertRequest>|
| `UpsertMultiple`<br />Event: False |<xref:Microsoft.Dynamics.CRM.UpsertMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpsertMultipleRequest>|
| `Validate`<br />Event: False |<xref:Microsoft.Dynamics.CRM.Validate?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.ValidateRequest>|
| `ValidateSavedQuery`<br />Event: False |<xref:Microsoft.Dynamics.CRM.ValidateSavedQuery?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.ValidateSavedQueryRequest>|
| `ValidateUnpublished`<br />Event: False |<xref:Microsoft.Dynamics.CRM.ValidateUnpublished?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.ValidateUnpublishedRequest>|

## Properties

The following table lists selected properties for the Service Activity (ServiceAppointment) table.

|Property|Value|
| --- | --- |
| **DisplayName** | **Service Activity** |
| **DisplayCollectionName** | **Service Activities** |
| **SchemaName** | `ServiceAppointment` |
| **CollectionSchemaName** | `ServiceAppointments` |
| **EntitySetName** | `serviceappointments`|
| **LogicalName** | `serviceappointment` |
| **LogicalCollectionName** | `serviceappointments` |
| **PrimaryIdAttribute** | `activityid` |
| **PrimaryNameAttribute** |`subject` |
| **TableType** | `Standard` |
| **OwnershipType** | `UserOwned` |

## Writable columns/attributes

These columns/attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [ActivityAdditionalParams](#BKMK_ActivityAdditionalParams)
- [ActivityId](#BKMK_ActivityId)
- [ActualDurationMinutes](#BKMK_ActualDurationMinutes)
- [ActualEnd](#BKMK_ActualEnd)
- [ActualStart](#BKMK_ActualStart)
- [BCC](#BKMK_BCC)
- [Category](#BKMK_Category)
- [CC](#BKMK_CC)
- [Community](#BKMK_Community)
- [Customers](#BKMK_Customers)
- [DeliveryPriorityCode](#BKMK_DeliveryPriorityCode)
- [Description](#BKMK_Description)
- [ExchangeItemId](#BKMK_ExchangeItemId)
- [ExchangeWebLink](#BKMK_ExchangeWebLink)
- [From](#BKMK_From)
- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [IsAllDayEvent](#BKMK_IsAllDayEvent)
- [IsBilled](#BKMK_IsBilled)
- [IsMapiPrivate](#BKMK_IsMapiPrivate)
- [IsWorkflowCreated](#BKMK_IsWorkflowCreated)
- [LastOnHoldTime](#BKMK_LastOnHoldTime)
- [LeftVoiceMail](#BKMK_LeftVoiceMail)
- [Location](#BKMK_Location)
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
- [ScheduledDurationMinutes](#BKMK_ScheduledDurationMinutes)
- [ScheduledEnd](#BKMK_ScheduledEnd)
- [ScheduledStart](#BKMK_ScheduledStart)
- [ServiceId](#BKMK_ServiceId)
- [SiteId](#BKMK_SiteId)
- [SLAId](#BKMK_SLAId)
- [SortDate](#BKMK_SortDate)
- [StageId](#BKMK_StageId)
- [StateCode](#BKMK_StateCode)
- [StatusCode](#BKMK_StatusCode)
- [Subcategory](#BKMK_Subcategory)
- [Subject](#BKMK_Subject)
- [SubscriptionId](#BKMK_SubscriptionId)
- [TimeZoneRuleVersionNumber](#BKMK_TimeZoneRuleVersionNumber)
- [To](#BKMK_To)
- [TransactionCurrencyId](#BKMK_TransactionCurrencyId)
- [TraversedPath](#BKMK_TraversedPath)
- [UTCConversionTimeZoneCode](#BKMK_UTCConversionTimeZoneCode)

### <a name="BKMK_ActivityAdditionalParams"></a> ActivityAdditionalParams

|Property|Value|
|---|---|
|Description|**For internal use only.**|
|DisplayName|**Additional Parameters**|
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
|Description|**Unique identifier of the service activity.**|
|DisplayName|**Service Activity**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`activityid`|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|

### <a name="BKMK_ActualDurationMinutes"></a> ActualDurationMinutes

|Property|Value|
|---|---|
|Description|**Shows the value selected in the Duration field on the service activity at the time the service activity is closed as completed. The duration is used to report the time spent on the activity.**|
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
|Description|**Enter the actual end date and time of the service activity. By default, it displays when the activity was closed or canceled.**|
|DisplayName|**Actual End**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`actualend`|
|RequiredLevel|None|
|Type|DateTime|
|CanChangeDateTimeBehavior|False|
|DateTimeBehavior|UserLocal|
|Format|DateAndTime|
|ImeMode|Inactive|
|SourceTypeMask|0|

### <a name="BKMK_ActualStart"></a> ActualStart

|Property|Value|
|---|---|
|Description|**Enter the actual start date and time for the service activity. By default, it displays when the activity was created.**|
|DisplayName|**Actual Start**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`actualstart`|
|RequiredLevel|None|
|Type|DateTime|
|CanChangeDateTimeBehavior|False|
|DateTimeBehavior|UserLocal|
|Format|DateAndTime|
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
|Targets|account, contact, lead, systemuser|

### <a name="BKMK_Category"></a> Category

|Property|Value|
|---|---|
|Description|**Type a category to identify the service activity type, such as routine maintenance or service call, to tie the service activity to a business group or function.**|
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
|Targets|account, contact, lead, systemuser|

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
|Description|**Enter the accounts and contacts for whom the service activity is being performed.**|
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
|Description|**Type additional information to describe the service activity, such as key talking points or objectives.**|
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

### <a name="BKMK_From"></a> From

|Property|Value|
|---|---|
|Description|**Person who the activity is from.**|
|DisplayName|**From**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`from`|
|RequiredLevel|None|
|Type|PartyList|
|Targets|account, contact, lead, systemuser|

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

### <a name="BKMK_IsAllDayEvent"></a> IsAllDayEvent

|Property|Value|
|---|---|
|Description|**Select whether the service activity is an all-day event to make sure the required resources are scheduled for the full day.**|
|DisplayName|**All Day Event**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`isalldayevent`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`serviceappointment_isalldayevent`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_IsBilled"></a> IsBilled

|Property|Value|
|---|---|
|Description|**Information which specifies whether the service activity was billed as part of resolving a case.**|
|DisplayName|**Is Billed**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`isbilled`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`serviceappointment_isbilled`|
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
|GlobalChoiceName|`serviceappointment_ismapiprivate`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_IsWorkflowCreated"></a> IsWorkflowCreated

|Property|Value|
|---|---|
|Description|**Information which specifies if the service activity was created from a workflow rule.**|
|DisplayName|**Is Workflow Created**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`isworkflowcreated`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`serviceappointment_isworkflowcreated`|
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
|GlobalChoiceName|`_serviceappointment_leftvoicemail`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_Location"></a> Location

|Property|Value|
|---|---|
|Description|**Type the location where the service activity will take place, such as a conference room, customer office, or other venue.**|
|DisplayName|**Delivery Location**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`location`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|500|

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
|Targets|account, contact, lead, systemuser|

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
|GlobalChoiceName|`serviceappointment_prioritycode`|

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
|Description|**Choose the record that the service activity relates to.**|
|DisplayName|**Regarding**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`regardingobjectid`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|account, adx_invitation, bookableresourcebooking, bookableresourcebookingheader, bulkoperation, campaign, campaignactivity, contact, contract, entitlement, entitlementtemplate, incident, interactionforemail, invoice, knowledgearticle, knowledgebaserecord, lead, msdyn_customerasset, msdyn_playbookinstance, msdyn_postalbum, msdyn_salessuggestion, msdyn_swarm, mspp_adplacement, mspp_pollplacement, mspp_publishingstatetransitionrule, mspp_redirect, mspp_shortcut, mspp_website, opportunity, quote, salesorder, site|

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
|Targets|account, contact, lead, systemuser|

### <a name="BKMK_Resources"></a> Resources

|Property|Value|
|---|---|
|Description|**Enter the user, facility, or equipment required to complete the service activity.**|
|DisplayName|**Resources**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`resources`|
|RequiredLevel|None|
|Type|PartyList|
|Targets|equipment, systemuser|

### <a name="BKMK_ScheduledDurationMinutes"></a> ScheduledDurationMinutes

|Property|Value|
|---|---|
|Description|**Shows the expected duration of the service activity, in minutes.**|
|DisplayName|**Scheduled Duration**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`scheduleddurationminutes`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|0|

### <a name="BKMK_ScheduledEnd"></a> ScheduledEnd

|Property|Value|
|---|---|
|Description|**Enter the expected due date and time.**|
|DisplayName|**Scheduled End**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`scheduledend`|
|RequiredLevel|ApplicationRequired|
|Type|DateTime|
|CanChangeDateTimeBehavior|False|
|DateTimeBehavior|UserLocal|
|Format|DateAndTime|
|ImeMode|Inactive|
|SourceTypeMask|0|

### <a name="BKMK_ScheduledStart"></a> ScheduledStart

|Property|Value|
|---|---|
|Description|**Enter the expected due date and time.**|
|DisplayName|**Scheduled Start**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`scheduledstart`|
|RequiredLevel|ApplicationRequired|
|Type|DateTime|
|CanChangeDateTimeBehavior|False|
|DateTimeBehavior|UserLocal|
|Format|DateAndTime|
|ImeMode|Inactive|
|SourceTypeMask|0|

### <a name="BKMK_ServiceId"></a> ServiceId

|Property|Value|
|---|---|
|Description|**Choose the service scheduled to be performed during the service activity.**|
|DisplayName|**Service**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`serviceid`|
|RequiredLevel|ApplicationRequired|
|Type|Lookup|
|Targets|service|

### <a name="BKMK_SiteId"></a> SiteId

|Property|Value|
|---|---|
|Description|**Choose the site or location where the service activity will be performed.**|
|DisplayName|**Site**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`siteid`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|site|

### <a name="BKMK_SLAId"></a> SLAId

|Property|Value|
|---|---|
|Description|**Choose the service level agreement (SLA) that you want to apply to the service appointment record.**|
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
|Description|**Shows whether the service activity is open, completed, or canceled. Completed and canceled service activities are read-only and can't be edited.**|
|DisplayName|**Status**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statecode`|
|RequiredLevel|SystemRequired|
|Type|State|
|DefaultFormValue|0|
|GlobalChoiceName|`serviceappointment_statecode`|

#### StateCode Choices/Options

|Value|Details|
|---|---|
|0|Label: **Open**<br />DefaultStatus: 1<br />InvariantName: `Open`|
|1|Label: **Closed**<br />DefaultStatus: 8<br />InvariantName: `Closed`|
|2|Label: **Canceled**<br />DefaultStatus: 9<br />InvariantName: `Canceled`|
|3|Label: **Scheduled**<br />DefaultStatus: 3<br />InvariantName: `Scheduled`|

### <a name="BKMK_StatusCode"></a> StatusCode

|Property|Value|
|---|---|
|Description|**Select the service activity's status.**|
|DisplayName|**Status Reason**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statuscode`|
|RequiredLevel|None|
|Type|Status|
|DefaultFormValue|-1|
|GlobalChoiceName|`serviceappointment_statuscode`|

#### StatusCode Choices/Options

|Value|Details|
|---|---|
|1|Label: **Requested**<br />State:0<br />TransitionData: None|
|2|Label: **Tentative**<br />State:0<br />TransitionData: None|
|3|Label: **Pending**<br />State:3<br />TransitionData: None|
|4|Label: **Reserved**<br />State:3<br />TransitionData: None|
|6|Label: **In Progress**<br />State:3<br />TransitionData: None|
|7|Label: **Arrived**<br />State:3<br />TransitionData: None|
|8|Label: **Completed**<br />State:1<br />TransitionData: None|
|9|Label: **Canceled**<br />State:2<br />TransitionData: None|
|10|Label: **No Show**<br />State:2<br />TransitionData: None|

### <a name="BKMK_Subcategory"></a> Subcategory

|Property|Value|
|---|---|
|Description|**Type a subcategory to identify the service activity type and relate the activity to a specific product, service region, business group, or other function.**|
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
|Description|**Type a short description about the objective or primary topic of the service activity.**|
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

### <a name="BKMK_SubscriptionId"></a> SubscriptionId

|Property|Value|
|---|---|
|Description|**For internal use only.**|
|DisplayName|**Subscription**|
|IsValidForForm|False|
|IsValidForRead|False|
|LogicalName|`subscriptionid`|
|RequiredLevel|None|
|Type|Uniqueidentifier|

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
|Targets|account, contact, lead, systemuser|

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
- [SenderMailboxId](#BKMK_SenderMailboxId)
- [SentOn](#BKMK_SentOn)
- [SeriesId](#BKMK_SeriesId)
- [SLAInvokedId](#BKMK_SLAInvokedId)
- [VersionNumber](#BKMK_VersionNumber)

### <a name="BKMK_ActivityTypeCode"></a> ActivityTypeCode

|Property|Value|
|---|---|
|Description|**Shows the type of activity.**|
|DisplayName|**Activity Type**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`activitytypecode`|
|RequiredLevel|SystemRequired|
|Type|EntityName|

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
|GlobalChoiceName|`_serviceappointment_instancetypecode`|

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
|Description|**Last SLA that was applied to this email. This field is for internal use only.**|
|DisplayName|**Last SLA applied**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`slainvokedid`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|sla|

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

- [Account_ServiceAppointments](#BKMK_Account_ServiceAppointments)
- [activity_pointer_service_appointment](#BKMK_activity_pointer_service_appointment)
- [adx_invitation_ServiceAppointments](#BKMK_adx_invitation_ServiceAppointments)
- [bookableresourcebooking_ServiceAppointments](#BKMK_bookableresourcebooking_ServiceAppointments)
- [bookableresourcebookingheader_ServiceAppointments](#BKMK_bookableresourcebookingheader_ServiceAppointments)
- [bulkoperation_ServiceAppointments](#BKMK_bulkoperation_ServiceAppointments)
- [business_unit_service_appointments](#BKMK_business_unit_service_appointments)
- [Campaign_ServiceAppointments](#BKMK_Campaign_ServiceAppointments)
- [campaignactivity_ServiceAppointments](#BKMK_campaignactivity_ServiceAppointments)
- [Contact_ServiceAppointments](#BKMK_Contact_ServiceAppointments)
- [Contract_ServiceAppointments](#BKMK_Contract_ServiceAppointments)
- [entitlement_ServiceAppointments](#BKMK_entitlement_ServiceAppointments)
- [entitlementtemplate_ServiceAppointments](#BKMK_entitlementtemplate_ServiceAppointments)
- [Incident_ServiceAppointments](#BKMK_Incident_ServiceAppointments)
- [interactionforemail_ServiceAppointments](#BKMK_interactionforemail_ServiceAppointments)
- [Invoice_ServiceAppointments](#BKMK_Invoice_ServiceAppointments)
- [KnowledgeArticle_ServiceAppointments](#BKMK_KnowledgeArticle_ServiceAppointments)
- [KnowledgeBaseRecord_ServiceAppointments](#BKMK_KnowledgeBaseRecord_ServiceAppointments)
- [Lead_ServiceAppointments](#BKMK_Lead_ServiceAppointments)
- [lk_serviceappointment_createdby](#BKMK_lk_serviceappointment_createdby)
- [lk_serviceappointment_createdonbehalfby](#BKMK_lk_serviceappointment_createdonbehalfby)
- [lk_serviceappointment_modifiedby](#BKMK_lk_serviceappointment_modifiedby)
- [lk_serviceappointment_modifiedonbehalfby](#BKMK_lk_serviceappointment_modifiedonbehalfby)
- [manualsla_serviceappointment](#BKMK_manualsla_serviceappointment)
- [msdyn_customerasset_ServiceAppointments](#BKMK_msdyn_customerasset_ServiceAppointments)
- [msdyn_postalbum_ServiceAppointments](#BKMK_msdyn_postalbum_ServiceAppointments)
- [msdyn_salessuggestion_ServiceAppointments](#BKMK_msdyn_salessuggestion_ServiceAppointments)
- [msdyn_swarm_ServiceAppointments](#BKMK_msdyn_swarm_ServiceAppointments)
- [mspp_adplacement_ServiceAppointments](#BKMK_mspp_adplacement_ServiceAppointments)
- [mspp_pollplacement_ServiceAppointments](#BKMK_mspp_pollplacement_ServiceAppointments)
- [mspp_publishingstatetransitionrule_ServiceAppointments](#BKMK_mspp_publishingstatetransitionrule_ServiceAppointments)
- [mspp_redirect_ServiceAppointments](#BKMK_mspp_redirect_ServiceAppointments)
- [mspp_shortcut_ServiceAppointments](#BKMK_mspp_shortcut_ServiceAppointments)
- [mspp_website_ServiceAppointments](#BKMK_mspp_website_ServiceAppointments)
- [Opportunity_ServiceAppointments](#BKMK_Opportunity_ServiceAppointments)
- [Quote_ServiceAppointments](#BKMK_Quote_ServiceAppointments)
- [SalesOrder_ServiceAppointments](#BKMK_SalesOrder_ServiceAppointments)
- [service_service_appointments](#BKMK_service_service_appointments)
- [serviceappointment_mailbox_sendermailboxid](#BKMK_serviceappointment_mailbox_sendermailboxid)
- [serviceappointment_owner_ownerid](#BKMK_serviceappointment_owner_ownerid)
- [site_service_appointments](#BKMK_site_service_appointments)
- [site_ServiceAppointments](#BKMK_site_ServiceAppointments)
- [sla_serviceappointment](#BKMK_sla_serviceappointment)
- [system_user_service_appointments](#BKMK_system_user_service_appointments)
- [team_service_appointments](#BKMK_team_service_appointments)
- [TransactionCurrency_ServiceAppointment](#BKMK_TransactionCurrency_ServiceAppointment)

### <a name="BKMK_Account_ServiceAppointments"></a> Account_ServiceAppointments

One-To-Many Relationship: [account Account_ServiceAppointments](account.md#BKMK_Account_ServiceAppointments)

|Property|Value|
|---|---|
|ReferencedEntity|`account`|
|ReferencedAttribute|`accountid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_account_serviceappointment`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `RemoveLink`<br />Merge: `Cascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_activity_pointer_service_appointment"></a> activity_pointer_service_appointment

One-To-Many Relationship: [activitypointer activity_pointer_service_appointment](activitypointer.md#BKMK_activity_pointer_service_appointment)

|Property|Value|
|---|---|
|ReferencedEntity|`activitypointer`|
|ReferencedAttribute|`activityid`|
|ReferencingAttribute|`activityid`|
|ReferencingEntityNavigationPropertyName|`activityid_activitypointer`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_adx_invitation_ServiceAppointments"></a> adx_invitation_ServiceAppointments

One-To-Many Relationship: [adx_invitation adx_invitation_ServiceAppointments](adx_invitation.md#BKMK_adx_invitation_ServiceAppointments)

|Property|Value|
|---|---|
|ReferencedEntity|`adx_invitation`|
|ReferencedAttribute|`adx_invitationid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_adx_invitation_serviceappointment`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_bookableresourcebooking_ServiceAppointments"></a> bookableresourcebooking_ServiceAppointments

One-To-Many Relationship: [bookableresourcebooking bookableresourcebooking_ServiceAppointments](bookableresourcebooking.md#BKMK_bookableresourcebooking_ServiceAppointments)

|Property|Value|
|---|---|
|ReferencedEntity|`bookableresourcebooking`|
|ReferencedAttribute|`bookableresourcebookingid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_bookableresourcebooking_serviceappointment`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_bookableresourcebookingheader_ServiceAppointments"></a> bookableresourcebookingheader_ServiceAppointments

One-To-Many Relationship: [bookableresourcebookingheader bookableresourcebookingheader_ServiceAppointments](bookableresourcebookingheader.md#BKMK_bookableresourcebookingheader_ServiceAppointments)

|Property|Value|
|---|---|
|ReferencedEntity|`bookableresourcebookingheader`|
|ReferencedAttribute|`bookableresourcebookingheaderid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_bookableresourcebookingheader_serviceappointment`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_bulkoperation_ServiceAppointments"></a> bulkoperation_ServiceAppointments

One-To-Many Relationship: [bulkoperation bulkoperation_ServiceAppointments](bulkoperation.md#BKMK_bulkoperation_ServiceAppointments)

|Property|Value|
|---|---|
|ReferencedEntity|`bulkoperation`|
|ReferencedAttribute|`activityid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_bulkoperation_serviceappointment`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_business_unit_service_appointments"></a> business_unit_service_appointments

One-To-Many Relationship: [businessunit business_unit_service_appointments](businessunit.md#BKMK_business_unit_service_appointments)

|Property|Value|
|---|---|
|ReferencedEntity|`businessunit`|
|ReferencedAttribute|`businessunitid`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencingEntityNavigationPropertyName|`owningbusinessunit_serviceappointment`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_Campaign_ServiceAppointments"></a> Campaign_ServiceAppointments

One-To-Many Relationship: [campaign Campaign_ServiceAppointments](campaign.md#BKMK_Campaign_ServiceAppointments)

|Property|Value|
|---|---|
|ReferencedEntity|`campaign`|
|ReferencedAttribute|`campaignid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_campaign_serviceappointment`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `RemoveLink`<br />Merge: `Cascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_campaignactivity_ServiceAppointments"></a> campaignactivity_ServiceAppointments

One-To-Many Relationship: [campaignactivity campaignactivity_ServiceAppointments](campaignactivity.md#BKMK_campaignactivity_ServiceAppointments)

|Property|Value|
|---|---|
|ReferencedEntity|`campaignactivity`|
|ReferencedAttribute|`activityid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_campaignactivity_serviceappointment`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_Contact_ServiceAppointments"></a> Contact_ServiceAppointments

One-To-Many Relationship: [contact Contact_ServiceAppointments](contact.md#BKMK_Contact_ServiceAppointments)

|Property|Value|
|---|---|
|ReferencedEntity|`contact`|
|ReferencedAttribute|`contactid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_contact_serviceappointment`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `RemoveLink`<br />Merge: `Cascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_Contract_ServiceAppointments"></a> Contract_ServiceAppointments

One-To-Many Relationship: [contract Contract_ServiceAppointments](contract.md#BKMK_Contract_ServiceAppointments)

|Property|Value|
|---|---|
|ReferencedEntity|`contract`|
|ReferencedAttribute|`contractid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_contract_serviceappointment`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_entitlement_ServiceAppointments"></a> entitlement_ServiceAppointments

One-To-Many Relationship: [entitlement entitlement_ServiceAppointments](entitlement.md#BKMK_entitlement_ServiceAppointments)

|Property|Value|
|---|---|
|ReferencedEntity|`entitlement`|
|ReferencedAttribute|`entitlementid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_entitlement_serviceappointment`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_entitlementtemplate_ServiceAppointments"></a> entitlementtemplate_ServiceAppointments

One-To-Many Relationship: [entitlementtemplate entitlementtemplate_ServiceAppointments](entitlementtemplate.md#BKMK_entitlementtemplate_ServiceAppointments)

|Property|Value|
|---|---|
|ReferencedEntity|`entitlementtemplate`|
|ReferencedAttribute|`entitlementtemplateid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_entitlementtemplate_serviceappointment`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_Incident_ServiceAppointments"></a> Incident_ServiceAppointments

One-To-Many Relationship: [incident Incident_ServiceAppointments](incident.md#BKMK_Incident_ServiceAppointments)

|Property|Value|
|---|---|
|ReferencedEntity|`incident`|
|ReferencedAttribute|`incidentid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_incident_serviceappointment`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `RemoveLink`<br />Merge: `Cascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_interactionforemail_ServiceAppointments"></a> interactionforemail_ServiceAppointments

One-To-Many Relationship: [interactionforemail interactionforemail_ServiceAppointments](interactionforemail.md#BKMK_interactionforemail_ServiceAppointments)

|Property|Value|
|---|---|
|ReferencedEntity|`interactionforemail`|
|ReferencedAttribute|`interactionforemailid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_new_interactionforemail_serviceappointment`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_Invoice_ServiceAppointments"></a> Invoice_ServiceAppointments

One-To-Many Relationship: [invoice Invoice_ServiceAppointments](invoice.md#BKMK_Invoice_ServiceAppointments)

|Property|Value|
|---|---|
|ReferencedEntity|`invoice`|
|ReferencedAttribute|`invoiceid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_invoice_serviceappointment`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_KnowledgeArticle_ServiceAppointments"></a> KnowledgeArticle_ServiceAppointments

One-To-Many Relationship: [knowledgearticle KnowledgeArticle_ServiceAppointments](knowledgearticle.md#BKMK_KnowledgeArticle_ServiceAppointments)

|Property|Value|
|---|---|
|ReferencedEntity|`knowledgearticle`|
|ReferencedAttribute|`knowledgearticleid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_knowledgearticle_serviceappointment`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `RemoveLink`<br />Merge: `Cascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_KnowledgeBaseRecord_ServiceAppointments"></a> KnowledgeBaseRecord_ServiceAppointments

One-To-Many Relationship: [knowledgebaserecord KnowledgeBaseRecord_ServiceAppointments](knowledgebaserecord.md#BKMK_KnowledgeBaseRecord_ServiceAppointments)

|Property|Value|
|---|---|
|ReferencedEntity|`knowledgebaserecord`|
|ReferencedAttribute|`knowledgebaserecordid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_knowledgebaserecord_serviceappointment`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_Lead_ServiceAppointments"></a> Lead_ServiceAppointments

One-To-Many Relationship: [lead Lead_ServiceAppointments](lead.md#BKMK_Lead_ServiceAppointments)

|Property|Value|
|---|---|
|ReferencedEntity|`lead`|
|ReferencedAttribute|`leadid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_lead_serviceappointment`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `RemoveLink`<br />Merge: `Cascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_lk_serviceappointment_createdby"></a> lk_serviceappointment_createdby

One-To-Many Relationship: [systemuser lk_serviceappointment_createdby](systemuser.md#BKMK_lk_serviceappointment_createdby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdby`|
|ReferencingEntityNavigationPropertyName|`createdby_serviceappointment`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_serviceappointment_createdonbehalfby"></a> lk_serviceappointment_createdonbehalfby

One-To-Many Relationship: [systemuser lk_serviceappointment_createdonbehalfby](systemuser.md#BKMK_lk_serviceappointment_createdonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdonbehalfby`|
|ReferencingEntityNavigationPropertyName|`createdonbehalfby_serviceappointment`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_serviceappointment_modifiedby"></a> lk_serviceappointment_modifiedby

One-To-Many Relationship: [systemuser lk_serviceappointment_modifiedby](systemuser.md#BKMK_lk_serviceappointment_modifiedby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedby`|
|ReferencingEntityNavigationPropertyName|`modifiedby_serviceappointment`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_serviceappointment_modifiedonbehalfby"></a> lk_serviceappointment_modifiedonbehalfby

One-To-Many Relationship: [systemuser lk_serviceappointment_modifiedonbehalfby](systemuser.md#BKMK_lk_serviceappointment_modifiedonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedonbehalfby`|
|ReferencingEntityNavigationPropertyName|`modifiedonbehalfby_serviceappointment`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_manualsla_serviceappointment"></a> manualsla_serviceappointment

One-To-Many Relationship: [sla manualsla_serviceappointment](sla.md#BKMK_manualsla_serviceappointment)

|Property|Value|
|---|---|
|ReferencedEntity|`sla`|
|ReferencedAttribute|`slaid`|
|ReferencingAttribute|`slaid`|
|ReferencingEntityNavigationPropertyName|`SLAId`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_customerasset_ServiceAppointments"></a> msdyn_customerasset_ServiceAppointments

One-To-Many Relationship: [msdyn_customerasset msdyn_customerasset_ServiceAppointments](msdyn_customerasset.md#BKMK_msdyn_customerasset_ServiceAppointments)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_customerasset`|
|ReferencedAttribute|`msdyn_customerassetid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_customerasset_serviceappointment`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_postalbum_ServiceAppointments"></a> msdyn_postalbum_ServiceAppointments

One-To-Many Relationship: [msdyn_postalbum msdyn_postalbum_ServiceAppointments](msdyn_postalbum.md#BKMK_msdyn_postalbum_ServiceAppointments)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_postalbum`|
|ReferencedAttribute|`msdyn_postalbumid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_postalbum_serviceappointment`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_salessuggestion_ServiceAppointments"></a> msdyn_salessuggestion_ServiceAppointments

One-To-Many Relationship: [msdyn_salessuggestion msdyn_salessuggestion_ServiceAppointments](msdyn_salessuggestion.md#BKMK_msdyn_salessuggestion_ServiceAppointments)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_salessuggestion`|
|ReferencedAttribute|`msdyn_salessuggestionid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_salessuggestion_serviceappointment`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_swarm_ServiceAppointments"></a> msdyn_swarm_ServiceAppointments

One-To-Many Relationship: [msdyn_swarm msdyn_swarm_ServiceAppointments](msdyn_swarm.md#BKMK_msdyn_swarm_ServiceAppointments)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_swarm`|
|ReferencedAttribute|`msdyn_swarmid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_swarm_serviceappointment`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_mspp_adplacement_ServiceAppointments"></a> mspp_adplacement_ServiceAppointments

One-To-Many Relationship: [mspp_adplacement mspp_adplacement_ServiceAppointments](mspp_adplacement.md#BKMK_mspp_adplacement_ServiceAppointments)

|Property|Value|
|---|---|
|ReferencedEntity|`mspp_adplacement`|
|ReferencedAttribute|`mspp_adplacementid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_mspp_adplacement_serviceappointment`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_mspp_pollplacement_ServiceAppointments"></a> mspp_pollplacement_ServiceAppointments

One-To-Many Relationship: [mspp_pollplacement mspp_pollplacement_ServiceAppointments](mspp_pollplacement.md#BKMK_mspp_pollplacement_ServiceAppointments)

|Property|Value|
|---|---|
|ReferencedEntity|`mspp_pollplacement`|
|ReferencedAttribute|`mspp_pollplacementid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_mspp_pollplacement_serviceappointment`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_mspp_publishingstatetransitionrule_ServiceAppointments"></a> mspp_publishingstatetransitionrule_ServiceAppointments

One-To-Many Relationship: [mspp_publishingstatetransitionrule mspp_publishingstatetransitionrule_ServiceAppointments](mspp_publishingstatetransitionrule.md#BKMK_mspp_publishingstatetransitionrule_ServiceAppointments)

|Property|Value|
|---|---|
|ReferencedEntity|`mspp_publishingstatetransitionrule`|
|ReferencedAttribute|`mspp_publishingstatetransitionruleid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_mspp_publishingstatetransitionrule_serviceappointment`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_mspp_redirect_ServiceAppointments"></a> mspp_redirect_ServiceAppointments

One-To-Many Relationship: [mspp_redirect mspp_redirect_ServiceAppointments](mspp_redirect.md#BKMK_mspp_redirect_ServiceAppointments)

|Property|Value|
|---|---|
|ReferencedEntity|`mspp_redirect`|
|ReferencedAttribute|`mspp_redirectid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_mspp_redirect_serviceappointment`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_mspp_shortcut_ServiceAppointments"></a> mspp_shortcut_ServiceAppointments

One-To-Many Relationship: [mspp_shortcut mspp_shortcut_ServiceAppointments](mspp_shortcut.md#BKMK_mspp_shortcut_ServiceAppointments)

|Property|Value|
|---|---|
|ReferencedEntity|`mspp_shortcut`|
|ReferencedAttribute|`mspp_shortcutid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_mspp_shortcut_serviceappointment`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_mspp_website_ServiceAppointments"></a> mspp_website_ServiceAppointments

One-To-Many Relationship: [mspp_website mspp_website_ServiceAppointments](mspp_website.md#BKMK_mspp_website_ServiceAppointments)

|Property|Value|
|---|---|
|ReferencedEntity|`mspp_website`|
|ReferencedAttribute|`mspp_websiteid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_mspp_website_serviceappointment`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_Opportunity_ServiceAppointments"></a> Opportunity_ServiceAppointments

One-To-Many Relationship: [opportunity Opportunity_ServiceAppointments](opportunity.md#BKMK_Opportunity_ServiceAppointments)

|Property|Value|
|---|---|
|ReferencedEntity|`opportunity`|
|ReferencedAttribute|`opportunityid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_opportunity_serviceappointment`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_Quote_ServiceAppointments"></a> Quote_ServiceAppointments

One-To-Many Relationship: [quote Quote_ServiceAppointments](quote.md#BKMK_Quote_ServiceAppointments)

|Property|Value|
|---|---|
|ReferencedEntity|`quote`|
|ReferencedAttribute|`quoteid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_quote_serviceappointment`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_SalesOrder_ServiceAppointments"></a> SalesOrder_ServiceAppointments

One-To-Many Relationship: [salesorder SalesOrder_ServiceAppointments](salesorder.md#BKMK_SalesOrder_ServiceAppointments)

|Property|Value|
|---|---|
|ReferencedEntity|`salesorder`|
|ReferencedAttribute|`salesorderid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_salesorder_serviceappointment`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_service_service_appointments"></a> service_service_appointments

One-To-Many Relationship: [service service_service_appointments](service.md#BKMK_service_service_appointments)

|Property|Value|
|---|---|
|ReferencedEntity|`service`|
|ReferencedAttribute|`serviceid`|
|ReferencingAttribute|`serviceid`|
|ReferencingEntityNavigationPropertyName|`serviceid_serviceappointment`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Restrict`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_serviceappointment_mailbox_sendermailboxid"></a> serviceappointment_mailbox_sendermailboxid

One-To-Many Relationship: [mailbox serviceappointment_mailbox_sendermailboxid](mailbox.md#BKMK_serviceappointment_mailbox_sendermailboxid)

|Property|Value|
|---|---|
|ReferencedEntity|`mailbox`|
|ReferencedAttribute|`mailboxid`|
|ReferencingAttribute|`sendermailboxid`|
|ReferencingEntityNavigationPropertyName|`sendermailboxid_serviceappointment`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_serviceappointment_owner_ownerid"></a> serviceappointment_owner_ownerid

One-To-Many Relationship: [owner serviceappointment_owner_ownerid](owner.md#BKMK_serviceappointment_owner_ownerid)

|Property|Value|
|---|---|
|ReferencedEntity|`owner`|
|ReferencedAttribute|`ownerid`|
|ReferencingAttribute|`ownerid`|
|ReferencingEntityNavigationPropertyName|`ownerid_serviceappointment`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_site_service_appointments"></a> site_service_appointments

One-To-Many Relationship: [site site_service_appointments](site.md#BKMK_site_service_appointments)

|Property|Value|
|---|---|
|ReferencedEntity|`site`|
|ReferencedAttribute|`siteid`|
|ReferencingAttribute|`siteid`|
|ReferencingEntityNavigationPropertyName|`siteid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Restrict`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_site_ServiceAppointments"></a> site_ServiceAppointments

One-To-Many Relationship: [site site_ServiceAppointments](site.md#BKMK_site_ServiceAppointments)

|Property|Value|
|---|---|
|ReferencedEntity|`site`|
|ReferencedAttribute|`siteid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_site_serviceappointment`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_sla_serviceappointment"></a> sla_serviceappointment

One-To-Many Relationship: [sla sla_serviceappointment](sla.md#BKMK_sla_serviceappointment)

|Property|Value|
|---|---|
|ReferencedEntity|`sla`|
|ReferencedAttribute|`slaid`|
|ReferencingAttribute|`slainvokedid`|
|ReferencingEntityNavigationPropertyName|`slainvokedid_serviceappointment_sla`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_system_user_service_appointments"></a> system_user_service_appointments

One-To-Many Relationship: [systemuser system_user_service_appointments](systemuser.md#BKMK_system_user_service_appointments)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`owninguser`|
|ReferencingEntityNavigationPropertyName|`owninguser_serviceappointment`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_team_service_appointments"></a> team_service_appointments

One-To-Many Relationship: [team team_service_appointments](team.md#BKMK_team_service_appointments)

|Property|Value|
|---|---|
|ReferencedEntity|`team`|
|ReferencedAttribute|`teamid`|
|ReferencingAttribute|`owningteam`|
|ReferencingEntityNavigationPropertyName|`owningteam_serviceappointment`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_TransactionCurrency_ServiceAppointment"></a> TransactionCurrency_ServiceAppointment

One-To-Many Relationship: [transactioncurrency TransactionCurrency_ServiceAppointment](transactioncurrency.md#BKMK_TransactionCurrency_ServiceAppointment)

|Property|Value|
|---|---|
|ReferencedEntity|`transactioncurrency`|
|ReferencedAttribute|`transactioncurrencyid`|
|ReferencingAttribute|`transactioncurrencyid`|
|ReferencingEntityNavigationPropertyName|`transactioncurrencyid_serviceappointment`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Restrict`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|


## One-to-Many relationships

These relationships are one-to-many. Listed by **SchemaName**.

- [CampaignResponse_ServiceAppointments](#BKMK_CampaignResponse_ServiceAppointments)
- [serviceappointment_actioncard](#BKMK_serviceappointment_actioncard)
- [serviceappointment_activity_parties](#BKMK_serviceappointment_activity_parties)
- [ServiceAppointment_Annotation](#BKMK_ServiceAppointment_Annotation)
- [ServiceAppointment_AsyncOperations](#BKMK_ServiceAppointment_AsyncOperations)
- [ServiceAppointment_BulkDeleteFailures](#BKMK_ServiceAppointment_BulkDeleteFailures)
- [serviceappointment_connections1](#BKMK_serviceappointment_connections1)
- [serviceappointment_connections2](#BKMK_serviceappointment_connections2)
- [serviceappointment_MailboxTrackingFolders](#BKMK_serviceappointment_MailboxTrackingFolders)
- [serviceappointment_principalobjectattributeaccess](#BKMK_serviceappointment_principalobjectattributeaccess)
- [ServiceAppointment_ProcessSessions](#BKMK_ServiceAppointment_ProcessSessions)
- [ServiceAppointment_QueueItem](#BKMK_ServiceAppointment_QueueItem)
- [ServiceAppointment_SyncErrors](#BKMK_ServiceAppointment_SyncErrors)
- [slakpiinstance_serviceappointment](#BKMK_slakpiinstance_serviceappointment)

### <a name="BKMK_CampaignResponse_ServiceAppointments"></a> CampaignResponse_ServiceAppointments

Many-To-One Relationship: [campaignresponse CampaignResponse_ServiceAppointments](campaignresponse.md#BKMK_CampaignResponse_ServiceAppointments)

|Property|Value|
|---|---|
|ReferencingEntity|`campaignresponse`|
|ReferencingAttribute|`originatingactivityid`|
|ReferencedEntityNavigationPropertyName|`CampaignResponse_ServiceAppointments`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_serviceappointment_actioncard"></a> serviceappointment_actioncard

Many-To-One Relationship: [actioncard serviceappointment_actioncard](actioncard.md#BKMK_serviceappointment_actioncard)

|Property|Value|
|---|---|
|ReferencingEntity|`actioncard`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`serviceappointment_actioncard`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_serviceappointment_activity_parties"></a> serviceappointment_activity_parties

Many-To-One Relationship: [activityparty serviceappointment_activity_parties](activityparty.md#BKMK_serviceappointment_activity_parties)

|Property|Value|
|---|---|
|ReferencingEntity|`activityparty`|
|ReferencingAttribute|`activityid`|
|ReferencedEntityNavigationPropertyName|`serviceappointment_activity_parties`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_ServiceAppointment_Annotation"></a> ServiceAppointment_Annotation

Many-To-One Relationship: [annotation ServiceAppointment_Annotation](annotation.md#BKMK_ServiceAppointment_Annotation)

|Property|Value|
|---|---|
|ReferencingEntity|`annotation`|
|ReferencingAttribute|`objectid`|
|ReferencedEntityNavigationPropertyName|`ServiceAppointment_Annotation`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_ServiceAppointment_AsyncOperations"></a> ServiceAppointment_AsyncOperations

Many-To-One Relationship: [asyncoperation ServiceAppointment_AsyncOperations](asyncoperation.md#BKMK_ServiceAppointment_AsyncOperations)

|Property|Value|
|---|---|
|ReferencingEntity|`asyncoperation`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`ServiceAppointment_AsyncOperations`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_ServiceAppointment_BulkDeleteFailures"></a> ServiceAppointment_BulkDeleteFailures

Many-To-One Relationship: [bulkdeletefailure ServiceAppointment_BulkDeleteFailures](bulkdeletefailure.md#BKMK_ServiceAppointment_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencingEntity|`bulkdeletefailure`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`ServiceAppointment_BulkDeleteFailures`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_serviceappointment_connections1"></a> serviceappointment_connections1

Many-To-One Relationship: [connection serviceappointment_connections1](connection.md#BKMK_serviceappointment_connections1)

|Property|Value|
|---|---|
|ReferencingEntity|`connection`|
|ReferencingAttribute|`record1id`|
|ReferencedEntityNavigationPropertyName|`serviceappointment_connections1`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 100<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_serviceappointment_connections2"></a> serviceappointment_connections2

Many-To-One Relationship: [connection serviceappointment_connections2](connection.md#BKMK_serviceappointment_connections2)

|Property|Value|
|---|---|
|ReferencingEntity|`connection`|
|ReferencingAttribute|`record2id`|
|ReferencedEntityNavigationPropertyName|`serviceappointment_connections2`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 100<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_serviceappointment_MailboxTrackingFolders"></a> serviceappointment_MailboxTrackingFolders

Many-To-One Relationship: [mailboxtrackingfolder serviceappointment_MailboxTrackingFolders](mailboxtrackingfolder.md#BKMK_serviceappointment_MailboxTrackingFolders)

|Property|Value|
|---|---|
|ReferencingEntity|`mailboxtrackingfolder`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`serviceappointment_MailboxTrackingFolders`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_serviceappointment_principalobjectattributeaccess"></a> serviceappointment_principalobjectattributeaccess

Many-To-One Relationship: [principalobjectattributeaccess serviceappointment_principalobjectattributeaccess](principalobjectattributeaccess.md#BKMK_serviceappointment_principalobjectattributeaccess)

|Property|Value|
|---|---|
|ReferencingEntity|`principalobjectattributeaccess`|
|ReferencingAttribute|`objectid`|
|ReferencedEntityNavigationPropertyName|`serviceappointment_principalobjectattributeaccess`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_ServiceAppointment_ProcessSessions"></a> ServiceAppointment_ProcessSessions

Many-To-One Relationship: [processsession ServiceAppointment_ProcessSessions](processsession.md#BKMK_ServiceAppointment_ProcessSessions)

|Property|Value|
|---|---|
|ReferencingEntity|`processsession`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`ServiceAppointment_ProcessSessions`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 110<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_ServiceAppointment_QueueItem"></a> ServiceAppointment_QueueItem

Many-To-One Relationship: [queueitem ServiceAppointment_QueueItem](queueitem.md#BKMK_ServiceAppointment_QueueItem)

|Property|Value|
|---|---|
|ReferencingEntity|`queueitem`|
|ReferencingAttribute|`objectid`|
|ReferencedEntityNavigationPropertyName|`ServiceAppointment_QueueItem`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_ServiceAppointment_SyncErrors"></a> ServiceAppointment_SyncErrors

Many-To-One Relationship: [syncerror ServiceAppointment_SyncErrors](syncerror.md#BKMK_ServiceAppointment_SyncErrors)

|Property|Value|
|---|---|
|ReferencingEntity|`syncerror`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`ServiceAppointment_SyncErrors`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_slakpiinstance_serviceappointment"></a> slakpiinstance_serviceappointment

Many-To-One Relationship: [slakpiinstance slakpiinstance_serviceappointment](slakpiinstance.md#BKMK_slakpiinstance_serviceappointment)

|Property|Value|
|---|---|
|ReferencingEntity|`slakpiinstance`|
|ReferencingAttribute|`regarding`|
|ReferencedEntityNavigationPropertyName|`slakpiinstance_serviceappointment`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|



### See also

[Dataverse table/entity reference](/power-apps/developer/data-platform/reference/about-entity-reference)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   

