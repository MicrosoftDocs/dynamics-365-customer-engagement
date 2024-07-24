---
title: "Smart Links Content Viewed (li_pointdrivepresentationviewed) table/entity reference (Microsoft Dynamics 365 Field Service)"
description: "Includes schema information and supported messages for the Smart Links Content Viewed (li_pointdrivepresentationviewed) table/entity with Microsoft Dynamics 365 Field Service."
ms.date: 07.24.2024
ms.service: powerapps
ms.topic: reference
author: m-hartmann
ms.author: mhart
search.audienceType: 
  - developer
---

# Smart Links Content Viewed (li_pointdrivepresentationviewed) table/entity reference

Custom Activity entity to store Smart Links Content Viewed records.

## Messages

The following table lists the messages for the Smart Links Content Viewed (li_pointdrivepresentationviewed) table.
Messages represent operations that can be performed on the table. They may also be events.

| Name <br />Is Event? |Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `Assign`<br />Event: True |`PATCH` /li_pointdrivepresentationvieweds(*activityid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `ownerid` property. |<xref:Microsoft.Crm.Sdk.Messages.AssignRequest>|
| `Create`<br />Event: True |`POST` /li_pointdrivepresentationvieweds<br />See [Create](/powerapps/developer/data-platform/webapi/create-entity-web-api) |[Create records](/power-apps/developer/data-platform/org-service/entity-operations-create#basic-create)|
| `CreateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.CreateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.CreateMultipleRequest>|
| `Delete`<br />Event: True |`DELETE` /li_pointdrivepresentationvieweds(*activityid*)<br />See [Delete](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-delete) |[Delete records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-delete)|
| `GrantAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.GrantAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.GrantAccessRequest>|
| `IsValidStateTransition`<br />Event: False |<xref:Microsoft.Dynamics.CRM.IsValidStateTransition?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.IsValidStateTransitionRequest>|
| `ModifyAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.ModifyAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.ModifyAccessRequest>|
| `Restore`<br />Event: True |<xref:Microsoft.Dynamics.CRM.Restore?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retrieve`<br />Event: True |`GET` /li_pointdrivepresentationvieweds(*activityid*)<br />See [Retrieve](/powerapps/developer/data-platform/webapi/retrieve-entity-using-web-api) |[Retrieve records](/power-apps/developer/data-platform/org-service/entity-operations-retrieve)|
| `RetrieveMultiple`<br />Event: True |`GET` /li_pointdrivepresentationvieweds<br />See [Query data](/power-apps/developer/data-platform/webapi/query-data-web-api) |[Query data](/power-apps/developer/data-platform/org-service/entity-operations-query-data)|
| `RetrievePrincipalAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RetrievePrincipalAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RetrievePrincipalAccessRequest>|
| `RetrieveSharedPrincipalsAndAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RetrieveSharedPrincipalsAndAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RetrieveSharedPrincipalsAndAccessRequest>|
| `RevokeAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RevokeAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RevokeAccessRequest>|
| `SetState`<br />Event: True |`PATCH` /li_pointdrivepresentationvieweds(*activityid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `statecode` and `statuscode` properties. |<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|
| `Update`<br />Event: True |`PATCH` /li_pointdrivepresentationvieweds(*activityid*)<br />See [Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) |[Update records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-update)|
| `UpdateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.UpdateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpdateMultipleRequest>|
| `Upsert`<br />Event: False |`PATCH` /li_pointdrivepresentationvieweds(*activityid*)<br />See [Upsert a table row](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#upsert-a-table-row) |<xref:Microsoft.Xrm.Sdk.Messages.UpsertRequest>|
| `UpsertMultiple`<br />Event: False |<xref:Microsoft.Dynamics.CRM.UpsertMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpsertMultipleRequest>|


## Events

The following table lists the events for the Smart Links Content Viewed (li_pointdrivepresentationviewed) table.
Events are messages that exist so that you can subscribe to them. Unless you added the event, you shouldn't invoke the message, only subscribe to it.

|Name|Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `BulkRetain`|<xref:Microsoft.Dynamics.CRM.BulkRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `PurgeRetainedContent`|<xref:Microsoft.Dynamics.CRM.PurgeRetainedContent?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retain`|<xref:Microsoft.Dynamics.CRM.Retain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `RollbackRetain`|<xref:Microsoft.Dynamics.CRM.RollbackRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `ValidateRetentionConfig`|<xref:Microsoft.Dynamics.CRM.ValidateRetentionConfig?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|

## Properties

The following table lists selected properties for the Smart Links Content Viewed (li_pointdrivepresentationviewed) table.

|Property|Value|
| --- | --- |
| **DisplayName** | **Smart Links Content Viewed** |
| **DisplayCollectionName** | **Smart Links Content Viewed** |
| **SchemaName** | `li_pointdrivepresentationviewed` |
| **CollectionSchemaName** | `li_pointdrivepresentationvieweds` |
| **EntitySetName** | `li_pointdrivepresentationvieweds`|
| **LogicalName** | `li_pointdrivepresentationviewed` |
| **LogicalCollectionName** | `li_pointdrivepresentationvieweds` |
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
- [CC](#BKMK_CC)
- [Community](#BKMK_Community)
- [Customers](#BKMK_Customers)
- [DeliveryPriorityCode](#BKMK_DeliveryPriorityCode)
- [Description](#BKMK_Description)
- [ExchangeItemId](#BKMK_ExchangeItemId)
- [ExchangeWebLink](#BKMK_ExchangeWebLink)
- [From](#BKMK_From)
- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [IsBilled](#BKMK_IsBilled)
- [IsMapiPrivate](#BKMK_IsMapiPrivate)
- [IsWorkflowCreated](#BKMK_IsWorkflowCreated)
- [LastOnHoldTime](#BKMK_LastOnHoldTime)
- [LeftVoiceMail](#BKMK_LeftVoiceMail)
- [li_URL](#BKMK_li_URL)
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
- [SLAId](#BKMK_SLAId)
- [SortDate](#BKMK_SortDate)
- [StageId](#BKMK_StageId)
- [StateCode](#BKMK_StateCode)
- [StatusCode](#BKMK_StatusCode)
- [Subject](#BKMK_Subject)
- [TimeZoneRuleVersionNumber](#BKMK_TimeZoneRuleVersionNumber)
- [To](#BKMK_To)
- [TransactionCurrencyId](#BKMK_TransactionCurrencyId)
- [TraversedPath](#BKMK_TraversedPath)
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
|Description|**Unique identifier of the activity.**|
|DisplayName|**Activity**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`activityid`|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|

### <a name="BKMK_ActualDurationMinutes"></a> ActualDurationMinutes

|Property|Value|
|---|---|
|Description|**Actual duration of the activity in minutes.**|
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
|Description|**Actual end time of the activity.**|
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
|Description|**Actual start time of the activity.**|
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
|Description|**Description of the activity.**|
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

### <a name="BKMK_IsBilled"></a> IsBilled

|Property|Value|
|---|---|
|Description|**Information regarding whether the activity was billed as part of resolving a case.**|
|DisplayName|**Is Billed**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`isbilled`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`li_pointdrivepresentationviewed_isbilled`|
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
|GlobalChoiceName|`li_pointdrivepresentationviewed_ismapiprivate`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_IsWorkflowCreated"></a> IsWorkflowCreated

|Property|Value|
|---|---|
|Description|**Information regarding whether the activity was created from a workflow rule.**|
|DisplayName|**Is Workflow Created**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`isworkflowcreated`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`li_pointdrivepresentationviewed_isworkflowcreated`|
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
|GlobalChoiceName|`li_pointdrivepresentationviewed_leftvoicemail`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_li_URL"></a> li_URL

|Property|Value|
|---|---|
|Description|**URL Link to the Smart Links Content**|
|DisplayName|**URL**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`li_url`|
|RequiredLevel|None|
|Type|String|
|Format|Url|
|FormatName|Url|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|200|

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
|Targets|account, contact, entitlement, equipment, knowledgearticle, lead, msdyn_salessuggestion, queue, systemuser, unresolvedaddress|

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
|Description|**Priority of the activity.**|
|DisplayName|**Priority**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`prioritycode`|
|RequiredLevel|None|
|Type|Picklist|
|DefaultFormValue|1|
|GlobalChoiceName|`li_pointdrivepresentationviewed_prioritycode`|

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
|Description|**Unique identifier of the object with which the activity is associated.**|
|DisplayName|**Regarding**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`regardingobjectid`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|account, adx_ad, adx_adplacement, adx_casedeflection, adx_communityforumaccesspermission, adx_communityforumalert, adx_contentaccesslevel, adx_invitation, adx_poll, adx_polloption, adx_pollplacement, adx_pollsubmission, adx_publishingstatetransitionrule, adx_redirect, adx_shortcut, adx_webpage, adx_website, bookableresourcebooking, bookableresourcebookingheader, bulkoperation, campaign, campaignactivity, contact, contract, entitlement, entitlementtemplate, incident, interactionforemail, invoice, knowledgearticle, knowledgebaserecord, lead, msdyncrm_contentsettings, msdyncrm_customerjourney, msdyncrm_leadscoremodel, msdyncrm_linkedinaccount, msdyncrm_linkedinactivity, msdyncrm_linkedinfieldmapping, msdyncrm_linkedinform, msdyncrm_linkedinformanswer, msdyncrm_linkedinformquestion, msdyncrm_linkedinformsubmission, msdyncrm_linkedinleadmatchingstrategy, msdyncrm_linkedinuserprofile, msdyncrm_marketingdynamiccontentmetadata, msdyncrm_marketingemaildynamiccontentmetadata, msdyncrm_marketingemailtestsend, msdyncrm_migration, msdyncrm_uicconfig, msdyn_agreement, msdyn_agreementbookingdate, msdyn_agreementbookingincident, msdyn_agreementbookingproduct, msdyn_agreementbookingservice, msdyn_agreementbookingservicetask, msdyn_agreementbookingsetup, msdyn_agreementinvoicedate, msdyn_agreementinvoiceproduct, msdyn_agreementinvoicesetup, msdyn_bookingalertstatus, msdyn_bookingrule, msdyn_bookingtimestamp, msdyn_customerasset, msdyn_fieldservicesetting, msdyn_incidenttypecharacteristic, msdyn_incidenttypeproduct, msdyn_incidenttypeservice, msdyn_inventoryadjustment, msdyn_inventoryadjustmentproduct, msdyn_inventoryjournal, msdyn_inventorytransfer, msdyn_payment, msdyn_paymentdetail, msdyn_paymentmethod, msdyn_paymentterm, msdyn_playbookinstance, msdyn_postalbum, msdyn_postalcode, msdyn_productinventory, msdyn_purchaseorder, msdyn_purchaseorderbill, msdyn_purchaseorderproduct, msdyn_purchaseorderreceipt, msdyn_purchaseorderreceiptproduct, msdyn_purchaseordersubstatus, msdyn_quotebookingincident, msdyn_quotebookingproduct, msdyn_quotebookingservice, msdyn_quotebookingservicetask, msdyn_resourceterritory, msdyn_rma, msdyn_rmaproduct, msdyn_rmareceipt, msdyn_rmareceiptproduct, msdyn_rmasubstatus, msdyn_rtv, msdyn_rtvproduct, msdyn_rtvsubstatus, msdyn_salessuggestion, msdyn_shipvia, msdyn_swarm, msdyn_systemuserschedulersetting, msdyn_timegroup, msdyn_timegroupdetail, msdyn_timeoffrequest, msdyn_warehouse, msdyn_workorder, msdyn_workordercharacteristic, msdyn_workorderincident, msdyn_workorderproduct, msdyn_workorderresourcerestriction, msdyn_workorderservice, msdyn_workorderservicetask, msevtmgt_checkin, msevtmgt_event, msevtmgt_eventpurchase, msevtmgt_eventpurchaseattendee, msevtmgt_eventpurchasepass, msevtmgt_eventregistration, msevtmgt_hotel, msevtmgt_hotelroomallocation, msevtmgt_hotelroomreservation, msevtmgt_layout, msevtmgt_room, msevtmgt_session, msevtmgt_sessionregistration, msevtmgt_sessiontrack, msevtmgt_speaker, msevtmgt_speakerengagement, msevtmgt_sponsorablearticle, msevtmgt_sponsorship, msevtmgt_venue, msevtmgt_webinarconfiguration, msevtmgt_webinarprovider, mspp_adplacement, mspp_pollplacement, mspp_publishingstatetransitionrule, mspp_redirect, mspp_shortcut, mspp_website, opportunity, quote, salesorder, site|

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
|Targets|account, contact, entitlement, equipment, knowledgearticle, lead, msdyn_salessuggestion, queue, systemuser, unresolvedaddress|

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
|Targets|equipment, systemuser|

### <a name="BKMK_ScheduledDurationMinutes"></a> ScheduledDurationMinutes

|Property|Value|
|---|---|
|Description|**Scheduled duration of the activity, specified in minutes.**|
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
|Description|**Scheduled end time of the activity.**|
|DisplayName|**Due Date**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`scheduledend`|
|RequiredLevel|None|
|Type|DateTime|
|CanChangeDateTimeBehavior|False|
|DateTimeBehavior|UserLocal|
|Format|DateAndTime|
|ImeMode|Inactive|
|SourceTypeMask|0|

### <a name="BKMK_ScheduledStart"></a> ScheduledStart

|Property|Value|
|---|---|
|Description|**Scheduled start time of the activity.**|
|DisplayName|**Start Date**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`scheduledstart`|
|RequiredLevel|None|
|Type|DateTime|
|CanChangeDateTimeBehavior|False|
|DateTimeBehavior|UserLocal|
|Format|DateAndTime|
|ImeMode|Inactive|
|SourceTypeMask|0|

### <a name="BKMK_ServiceId"></a> ServiceId

|Property|Value|
|---|---|
|Description|**Unique identifier of an associated service.**|
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
|DisplayName|**Process Stage**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`stageid`|
|RequiredLevel|None|
|Type|Uniqueidentifier|

### <a name="BKMK_StateCode"></a> StateCode

|Property|Value|
|---|---|
|Description|**Status of the activity.**|
|DisplayName|**Activity Status**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statecode`|
|RequiredLevel|SystemRequired|
|Type|State|
|DefaultFormValue|0|
|GlobalChoiceName|`li_pointdrivepresentationviewed_statecode`|

#### StateCode Choices/Options

|Value|Details|
|---|---|
|0|Label: **Open**<br />DefaultStatus: 1<br />InvariantName: `Open`|
|1|Label: **Completed**<br />DefaultStatus: 2<br />InvariantName: `Completed`|
|2|Label: **Canceled**<br />DefaultStatus: 3<br />InvariantName: `Canceled`|
|3|Label: **Scheduled**<br />DefaultStatus: 4<br />InvariantName: `Scheduled`|

### <a name="BKMK_StatusCode"></a> StatusCode

|Property|Value|
|---|---|
|Description|**Reason for the status of the activity.**|
|DisplayName|**Status Reason**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statuscode`|
|RequiredLevel|None|
|Type|Status|
|DefaultFormValue|-1|
|GlobalChoiceName|`li_pointdrivepresentationviewed_statuscode`|

#### StatusCode Choices/Options

|Value|Details|
|---|---|
|1|Label: **Open**<br />State:0<br />TransitionData: None|
|2|Label: **Completed**<br />State:1<br />TransitionData: None|
|3|Label: **Canceled**<br />State:2<br />TransitionData: None|
|4|Label: **Scheduled**<br />State:3<br />TransitionData: None|

### <a name="BKMK_Subject"></a> Subject

|Property|Value|
|---|---|
|Description|**Subject associated with the activity.**|
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
|Targets|account, contact, lead, systemuser|

### <a name="BKMK_TransactionCurrencyId"></a> TransactionCurrencyId

|Property|Value|
|---|---|
|Description|**Unique identifier of the currency associated with the activitypointer.**|
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
|DisplayName|**Traversed Path**|
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
|Description|**Type of activity.**|
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
|Description|**Exchange rate for the currency associated with the activitypointer with respect to the base currency.**|
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
|GlobalChoiceName|`li_pointdrivepresentationviewed_instancetypecode`|

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
|DefaultValue|True|
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
|Description|**Last SLA that was applied to this case. This field is for internal use only.**|
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

- [account_li_pointdrivepresentationvieweds](#BKMK_account_li_pointdrivepresentationvieweds)
- [activity_pointer_li_pointdrivepresentationviewed](#BKMK_activity_pointer_li_pointdrivepresentationviewed)
- [adx_ad_li_pointdrivepresentationvieweds](#BKMK_adx_ad_li_pointdrivepresentationvieweds)
- [adx_adplacement_li_pointdrivepresentationvieweds](#BKMK_adx_adplacement_li_pointdrivepresentationvieweds)
- [adx_casedeflection_li_pointdrivepresentationvieweds](#BKMK_adx_casedeflection_li_pointdrivepresentationvieweds)
- [adx_communityforumaccesspermission_li_pointdrivepresentationvieweds](#BKMK_adx_communityforumaccesspermission_li_pointdrivepresentationvieweds)
- [adx_communityforumalert_li_pointdrivepresentationvieweds](#BKMK_adx_communityforumalert_li_pointdrivepresentationvieweds)
- [adx_contentaccesslevel_li_pointdrivepresentationvieweds](#BKMK_adx_contentaccesslevel_li_pointdrivepresentationvieweds)
- [adx_invitation_li_pointdrivepresentationvieweds](#BKMK_adx_invitation_li_pointdrivepresentationvieweds)
- [adx_poll_li_pointdrivepresentationvieweds](#BKMK_adx_poll_li_pointdrivepresentationvieweds)
- [adx_polloption_li_pointdrivepresentationvieweds](#BKMK_adx_polloption_li_pointdrivepresentationvieweds)
- [adx_pollplacement_li_pointdrivepresentationvieweds](#BKMK_adx_pollplacement_li_pointdrivepresentationvieweds)
- [adx_pollsubmission_li_pointdrivepresentationvieweds](#BKMK_adx_pollsubmission_li_pointdrivepresentationvieweds)
- [adx_publishingstatetransitionrule_li_pointdrivepresentationvieweds](#BKMK_adx_publishingstatetransitionrule_li_pointdrivepresentationvieweds)
- [adx_redirect_li_pointdrivepresentationvieweds](#BKMK_adx_redirect_li_pointdrivepresentationvieweds)
- [adx_shortcut_li_pointdrivepresentationvieweds](#BKMK_adx_shortcut_li_pointdrivepresentationvieweds)
- [adx_webpage_li_pointdrivepresentationvieweds](#BKMK_adx_webpage_li_pointdrivepresentationvieweds)
- [adx_website_li_pointdrivepresentationvieweds](#BKMK_adx_website_li_pointdrivepresentationvieweds)
- [bookableresourcebooking_li_pointdrivepresentationvieweds](#BKMK_bookableresourcebooking_li_pointdrivepresentationvieweds)
- [bookableresourcebookingheader_li_pointdrivepresentationvieweds](#BKMK_bookableresourcebookingheader_li_pointdrivepresentationvieweds)
- [bulkoperation_li_pointdrivepresentationvieweds](#BKMK_bulkoperation_li_pointdrivepresentationvieweds)
- [campaign_li_pointdrivepresentationvieweds](#BKMK_campaign_li_pointdrivepresentationvieweds)
- [campaignactivity_li_pointdrivepresentationvieweds](#BKMK_campaignactivity_li_pointdrivepresentationvieweds)
- [contact_li_pointdrivepresentationvieweds](#BKMK_contact_li_pointdrivepresentationvieweds)
- [contract_li_pointdrivepresentationvieweds](#BKMK_contract_li_pointdrivepresentationvieweds)
- [entitlement_li_pointdrivepresentationvieweds](#BKMK_entitlement_li_pointdrivepresentationvieweds)
- [entitlementtemplate_li_pointdrivepresentationvieweds](#BKMK_entitlementtemplate_li_pointdrivepresentationvieweds)
- [incident_li_pointdrivepresentationvieweds](#BKMK_incident_li_pointdrivepresentationvieweds)
- [interactionforemail_li_pointdrivepresentationvieweds](#BKMK_interactionforemail_li_pointdrivepresentationvieweds)
- [invoice_li_pointdrivepresentationvieweds](#BKMK_invoice_li_pointdrivepresentationvieweds)
- [knowledgearticle_li_pointdrivepresentationvieweds](#BKMK_knowledgearticle_li_pointdrivepresentationvieweds)
- [knowledgebaserecord_li_pointdrivepresentationvieweds](#BKMK_knowledgebaserecord_li_pointdrivepresentationvieweds)
- [lead_li_pointdrivepresentationvieweds](#BKMK_lead_li_pointdrivepresentationvieweds)
- [li_pointdrivepresentationviewed_businessunit_owningbusinessunit](#BKMK_li_pointdrivepresentationviewed_businessunit_owningbusinessunit)
- [li_pointdrivepresentationviewed_mailbox_sendermailboxid](#BKMK_li_pointdrivepresentationviewed_mailbox_sendermailboxid)
- [li_pointdrivepresentationviewed_owner_ownerid](#BKMK_li_pointdrivepresentationviewed_owner_ownerid)
- [li_pointdrivepresentationviewed_service_serviceid](#BKMK_li_pointdrivepresentationviewed_service_serviceid)
- [li_pointdrivepresentationviewed_sla_slaid](#BKMK_li_pointdrivepresentationviewed_sla_slaid)
- [li_pointdrivepresentationviewed_sla_slainvokedid](#BKMK_li_pointdrivepresentationviewed_sla_slainvokedid)
- [li_pointdrivepresentationviewed_systemuser_createdby](#BKMK_li_pointdrivepresentationviewed_systemuser_createdby)
- [li_pointdrivepresentationviewed_systemuser_createdonbehalfby](#BKMK_li_pointdrivepresentationviewed_systemuser_createdonbehalfby)
- [li_pointdrivepresentationviewed_systemuser_modifiedby](#BKMK_li_pointdrivepresentationviewed_systemuser_modifiedby)
- [li_pointdrivepresentationviewed_systemuser_modifiedonbehalfby](#BKMK_li_pointdrivepresentationviewed_systemuser_modifiedonbehalfby)
- [li_pointdrivepresentationviewed_systemuser_owninguser](#BKMK_li_pointdrivepresentationviewed_systemuser_owninguser)
- [li_pointdrivepresentationviewed_team_owningteam](#BKMK_li_pointdrivepresentationviewed_team_owningteam)
- [li_pointdrivepresentationviewed_transactioncurrency_transactioncurrencyid](#BKMK_li_pointdrivepresentationviewed_transactioncurrency_transactioncurrencyid)
- [msdyn_agreement_li_pointdrivepresentationvieweds](#BKMK_msdyn_agreement_li_pointdrivepresentationvieweds)
- [msdyn_agreementbookingdate_li_pointdrivepresentationvieweds](#BKMK_msdyn_agreementbookingdate_li_pointdrivepresentationvieweds)
- [msdyn_agreementbookingincident_li_pointdrivepresentationvieweds](#BKMK_msdyn_agreementbookingincident_li_pointdrivepresentationvieweds)
- [msdyn_agreementbookingproduct_li_pointdrivepresentationvieweds](#BKMK_msdyn_agreementbookingproduct_li_pointdrivepresentationvieweds)
- [msdyn_agreementbookingservice_li_pointdrivepresentationvieweds](#BKMK_msdyn_agreementbookingservice_li_pointdrivepresentationvieweds)
- [msdyn_agreementbookingservicetask_li_pointdrivepresentationvieweds](#BKMK_msdyn_agreementbookingservicetask_li_pointdrivepresentationvieweds)
- [msdyn_agreementbookingsetup_li_pointdrivepresentationvieweds](#BKMK_msdyn_agreementbookingsetup_li_pointdrivepresentationvieweds)
- [msdyn_agreementinvoicedate_li_pointdrivepresentationvieweds](#BKMK_msdyn_agreementinvoicedate_li_pointdrivepresentationvieweds)
- [msdyn_agreementinvoiceproduct_li_pointdrivepresentationvieweds](#BKMK_msdyn_agreementinvoiceproduct_li_pointdrivepresentationvieweds)
- [msdyn_agreementinvoicesetup_li_pointdrivepresentationvieweds](#BKMK_msdyn_agreementinvoicesetup_li_pointdrivepresentationvieweds)
- [msdyn_bookingalertstatus_li_pointdrivepresentationvieweds](#BKMK_msdyn_bookingalertstatus_li_pointdrivepresentationvieweds)
- [msdyn_bookingrule_li_pointdrivepresentationvieweds](#BKMK_msdyn_bookingrule_li_pointdrivepresentationvieweds)
- [msdyn_bookingtimestamp_li_pointdrivepresentationvieweds](#BKMK_msdyn_bookingtimestamp_li_pointdrivepresentationvieweds)
- [msdyn_customerasset_li_pointdrivepresentationvieweds](#BKMK_msdyn_customerasset_li_pointdrivepresentationvieweds)
- [msdyn_fieldservicesetting_li_pointdrivepresentationvieweds](#BKMK_msdyn_fieldservicesetting_li_pointdrivepresentationvieweds)
- [msdyn_incidenttypecharacteristic_li_pointdrivepresentationvieweds](#BKMK_msdyn_incidenttypecharacteristic_li_pointdrivepresentationvieweds)
- [msdyn_incidenttypeproduct_li_pointdrivepresentationvieweds](#BKMK_msdyn_incidenttypeproduct_li_pointdrivepresentationvieweds)
- [msdyn_incidenttypeservice_li_pointdrivepresentationvieweds](#BKMK_msdyn_incidenttypeservice_li_pointdrivepresentationvieweds)
- [msdyn_inventoryadjustment_li_pointdrivepresentationvieweds](#BKMK_msdyn_inventoryadjustment_li_pointdrivepresentationvieweds)
- [msdyn_inventoryadjustmentproduct_li_pointdrivepresentationvieweds](#BKMK_msdyn_inventoryadjustmentproduct_li_pointdrivepresentationvieweds)
- [msdyn_inventoryjournal_li_pointdrivepresentationvieweds](#BKMK_msdyn_inventoryjournal_li_pointdrivepresentationvieweds)
- [msdyn_inventorytransfer_li_pointdrivepresentationvieweds](#BKMK_msdyn_inventorytransfer_li_pointdrivepresentationvieweds)
- [msdyn_payment_li_pointdrivepresentationvieweds](#BKMK_msdyn_payment_li_pointdrivepresentationvieweds)
- [msdyn_paymentdetail_li_pointdrivepresentationvieweds](#BKMK_msdyn_paymentdetail_li_pointdrivepresentationvieweds)
- [msdyn_paymentmethod_li_pointdrivepresentationvieweds](#BKMK_msdyn_paymentmethod_li_pointdrivepresentationvieweds)
- [msdyn_paymentterm_li_pointdrivepresentationvieweds](#BKMK_msdyn_paymentterm_li_pointdrivepresentationvieweds)
- [msdyn_playbookinstance_li_pointdrivepresentationvieweds](#BKMK_msdyn_playbookinstance_li_pointdrivepresentationvieweds)
- [msdyn_postalbum_li_pointdrivepresentationvieweds](#BKMK_msdyn_postalbum_li_pointdrivepresentationvieweds)
- [msdyn_postalcode_li_pointdrivepresentationvieweds](#BKMK_msdyn_postalcode_li_pointdrivepresentationvieweds)
- [msdyn_productinventory_li_pointdrivepresentationvieweds](#BKMK_msdyn_productinventory_li_pointdrivepresentationvieweds)
- [msdyn_purchaseorder_li_pointdrivepresentationvieweds](#BKMK_msdyn_purchaseorder_li_pointdrivepresentationvieweds)
- [msdyn_purchaseorderbill_li_pointdrivepresentationvieweds](#BKMK_msdyn_purchaseorderbill_li_pointdrivepresentationvieweds)
- [msdyn_purchaseorderproduct_li_pointdrivepresentationvieweds](#BKMK_msdyn_purchaseorderproduct_li_pointdrivepresentationvieweds)
- [msdyn_purchaseorderreceipt_li_pointdrivepresentationvieweds](#BKMK_msdyn_purchaseorderreceipt_li_pointdrivepresentationvieweds)
- [msdyn_purchaseorderreceiptproduct_li_pointdrivepresentationvieweds](#BKMK_msdyn_purchaseorderreceiptproduct_li_pointdrivepresentationvieweds)
- [msdyn_purchaseordersubstatus_li_pointdrivepresentationvieweds](#BKMK_msdyn_purchaseordersubstatus_li_pointdrivepresentationvieweds)
- [msdyn_quotebookingincident_li_pointdrivepresentationvieweds](#BKMK_msdyn_quotebookingincident_li_pointdrivepresentationvieweds)
- [msdyn_quotebookingproduct_li_pointdrivepresentationvieweds](#BKMK_msdyn_quotebookingproduct_li_pointdrivepresentationvieweds)
- [msdyn_quotebookingservice_li_pointdrivepresentationvieweds](#BKMK_msdyn_quotebookingservice_li_pointdrivepresentationvieweds)
- [msdyn_quotebookingservicetask_li_pointdrivepresentationvieweds](#BKMK_msdyn_quotebookingservicetask_li_pointdrivepresentationvieweds)
- [msdyn_resourceterritory_li_pointdrivepresentationvieweds](#BKMK_msdyn_resourceterritory_li_pointdrivepresentationvieweds)
- [msdyn_rma_li_pointdrivepresentationvieweds](#BKMK_msdyn_rma_li_pointdrivepresentationvieweds)
- [msdyn_rmaproduct_li_pointdrivepresentationvieweds](#BKMK_msdyn_rmaproduct_li_pointdrivepresentationvieweds)
- [msdyn_rmareceipt_li_pointdrivepresentationvieweds](#BKMK_msdyn_rmareceipt_li_pointdrivepresentationvieweds)
- [msdyn_rmareceiptproduct_li_pointdrivepresentationvieweds](#BKMK_msdyn_rmareceiptproduct_li_pointdrivepresentationvieweds)
- [msdyn_rmasubstatus_li_pointdrivepresentationvieweds](#BKMK_msdyn_rmasubstatus_li_pointdrivepresentationvieweds)
- [msdyn_rtv_li_pointdrivepresentationvieweds](#BKMK_msdyn_rtv_li_pointdrivepresentationvieweds)
- [msdyn_rtvproduct_li_pointdrivepresentationvieweds](#BKMK_msdyn_rtvproduct_li_pointdrivepresentationvieweds)
- [msdyn_rtvsubstatus_li_pointdrivepresentationvieweds](#BKMK_msdyn_rtvsubstatus_li_pointdrivepresentationvieweds)
- [msdyn_salessuggestion_li_pointdrivepresentationvieweds](#BKMK_msdyn_salessuggestion_li_pointdrivepresentationvieweds)
- [msdyn_shipvia_li_pointdrivepresentationvieweds](#BKMK_msdyn_shipvia_li_pointdrivepresentationvieweds)
- [msdyn_swarm_li_pointdrivepresentationvieweds](#BKMK_msdyn_swarm_li_pointdrivepresentationvieweds)
- [msdyn_systemuserschedulersetting_li_pointdrivepresentationvieweds](#BKMK_msdyn_systemuserschedulersetting_li_pointdrivepresentationvieweds)
- [msdyn_timegroup_li_pointdrivepresentationvieweds](#BKMK_msdyn_timegroup_li_pointdrivepresentationvieweds)
- [msdyn_timegroupdetail_li_pointdrivepresentationvieweds](#BKMK_msdyn_timegroupdetail_li_pointdrivepresentationvieweds)
- [msdyn_timeoffrequest_li_pointdrivepresentationvieweds](#BKMK_msdyn_timeoffrequest_li_pointdrivepresentationvieweds)
- [msdyn_warehouse_li_pointdrivepresentationvieweds](#BKMK_msdyn_warehouse_li_pointdrivepresentationvieweds)
- [msdyn_workorder_li_pointdrivepresentationvieweds](#BKMK_msdyn_workorder_li_pointdrivepresentationvieweds)
- [msdyn_workordercharacteristic_li_pointdrivepresentationvieweds](#BKMK_msdyn_workordercharacteristic_li_pointdrivepresentationvieweds)
- [msdyn_workorderincident_li_pointdrivepresentationvieweds](#BKMK_msdyn_workorderincident_li_pointdrivepresentationvieweds)
- [msdyn_workorderproduct_li_pointdrivepresentationvieweds](#BKMK_msdyn_workorderproduct_li_pointdrivepresentationvieweds)
- [msdyn_workorderresourcerestriction_li_pointdrivepresentationvieweds](#BKMK_msdyn_workorderresourcerestriction_li_pointdrivepresentationvieweds)
- [msdyn_workorderservice_li_pointdrivepresentationvieweds](#BKMK_msdyn_workorderservice_li_pointdrivepresentationvieweds)
- [msdyn_workorderservicetask_li_pointdrivepresentationvieweds](#BKMK_msdyn_workorderservicetask_li_pointdrivepresentationvieweds)
- [msdyncrm_contentsettings_li_pointdrivepresentationvieweds](#BKMK_msdyncrm_contentsettings_li_pointdrivepresentationvieweds)
- [msdyncrm_customerjourney_li_pointdrivepresentationvieweds](#BKMK_msdyncrm_customerjourney_li_pointdrivepresentationvieweds)
- [msdyncrm_leadscoremodel_li_pointdrivepresentationvieweds](#BKMK_msdyncrm_leadscoremodel_li_pointdrivepresentationvieweds)
- [msdyncrm_linkedinaccount_li_pointdrivepresentationvieweds](#BKMK_msdyncrm_linkedinaccount_li_pointdrivepresentationvieweds)
- [msdyncrm_linkedinactivity_li_pointdrivepresentationvieweds](#BKMK_msdyncrm_linkedinactivity_li_pointdrivepresentationvieweds)
- [msdyncrm_linkedinfieldmapping_li_pointdrivepresentationvieweds](#BKMK_msdyncrm_linkedinfieldmapping_li_pointdrivepresentationvieweds)
- [msdyncrm_linkedinform_li_pointdrivepresentationvieweds](#BKMK_msdyncrm_linkedinform_li_pointdrivepresentationvieweds)
- [msdyncrm_linkedinformanswer_li_pointdrivepresentationvieweds](#BKMK_msdyncrm_linkedinformanswer_li_pointdrivepresentationvieweds)
- [msdyncrm_linkedinformquestion_li_pointdrivepresentationvieweds](#BKMK_msdyncrm_linkedinformquestion_li_pointdrivepresentationvieweds)
- [msdyncrm_linkedinformsubmission_li_pointdrivepresentationvieweds](#BKMK_msdyncrm_linkedinformsubmission_li_pointdrivepresentationvieweds)
- [msdyncrm_linkedinleadmatchingstrategy_li_pointdrivepresentationvieweds](#BKMK_msdyncrm_linkedinleadmatchingstrategy_li_pointdrivepresentationvieweds)
- [msdyncrm_linkedinuserprofile_li_pointdrivepresentationvieweds](#BKMK_msdyncrm_linkedinuserprofile_li_pointdrivepresentationvieweds)
- [msdyncrm_marketingdynamiccontentmetadata_li_pointdrivepresentationvieweds](#BKMK_msdyncrm_marketingdynamiccontentmetadata_li_pointdrivepresentationvieweds)
- [msdyncrm_marketingemaildynamiccontentmetadata_li_pointdrivepresentationvieweds](#BKMK_msdyncrm_marketingemaildynamiccontentmetadata_li_pointdrivepresentationvieweds)
- [msdyncrm_marketingemailtestsend_li_pointdrivepresentationvieweds](#BKMK_msdyncrm_marketingemailtestsend_li_pointdrivepresentationvieweds)
- [msdyncrm_migration_li_pointdrivepresentationvieweds](#BKMK_msdyncrm_migration_li_pointdrivepresentationvieweds)
- [msdyncrm_uicconfig_li_pointdrivepresentationvieweds](#BKMK_msdyncrm_uicconfig_li_pointdrivepresentationvieweds)
- [msevtmgt_checkin_li_pointdrivepresentationvieweds](#BKMK_msevtmgt_checkin_li_pointdrivepresentationvieweds)
- [msevtmgt_event_li_pointdrivepresentationvieweds](#BKMK_msevtmgt_event_li_pointdrivepresentationvieweds)
- [msevtmgt_eventpurchase_li_pointdrivepresentationvieweds](#BKMK_msevtmgt_eventpurchase_li_pointdrivepresentationvieweds)
- [msevtmgt_eventpurchaseattendee_li_pointdrivepresentationvieweds](#BKMK_msevtmgt_eventpurchaseattendee_li_pointdrivepresentationvieweds)
- [msevtmgt_eventpurchasepass_li_pointdrivepresentationvieweds](#BKMK_msevtmgt_eventpurchasepass_li_pointdrivepresentationvieweds)
- [msevtmgt_eventregistration_li_pointdrivepresentationvieweds](#BKMK_msevtmgt_eventregistration_li_pointdrivepresentationvieweds)
- [msevtmgt_hotel_li_pointdrivepresentationvieweds](#BKMK_msevtmgt_hotel_li_pointdrivepresentationvieweds)
- [msevtmgt_hotelroomallocation_li_pointdrivepresentationvieweds](#BKMK_msevtmgt_hotelroomallocation_li_pointdrivepresentationvieweds)
- [msevtmgt_hotelroomreservation_li_pointdrivepresentationvieweds](#BKMK_msevtmgt_hotelroomreservation_li_pointdrivepresentationvieweds)
- [msevtmgt_layout_li_pointdrivepresentationvieweds](#BKMK_msevtmgt_layout_li_pointdrivepresentationvieweds)
- [msevtmgt_room_li_pointdrivepresentationvieweds](#BKMK_msevtmgt_room_li_pointdrivepresentationvieweds)
- [msevtmgt_session_li_pointdrivepresentationvieweds](#BKMK_msevtmgt_session_li_pointdrivepresentationvieweds)
- [msevtmgt_sessionregistration_li_pointdrivepresentationvieweds](#BKMK_msevtmgt_sessionregistration_li_pointdrivepresentationvieweds)
- [msevtmgt_sessiontrack_li_pointdrivepresentationvieweds](#BKMK_msevtmgt_sessiontrack_li_pointdrivepresentationvieweds)
- [msevtmgt_speaker_li_pointdrivepresentationvieweds](#BKMK_msevtmgt_speaker_li_pointdrivepresentationvieweds)
- [msevtmgt_speakerengagement_li_pointdrivepresentationvieweds](#BKMK_msevtmgt_speakerengagement_li_pointdrivepresentationvieweds)
- [msevtmgt_sponsorablearticle_li_pointdrivepresentationvieweds](#BKMK_msevtmgt_sponsorablearticle_li_pointdrivepresentationvieweds)
- [msevtmgt_sponsorship_li_pointdrivepresentationvieweds](#BKMK_msevtmgt_sponsorship_li_pointdrivepresentationvieweds)
- [msevtmgt_venue_li_pointdrivepresentationvieweds](#BKMK_msevtmgt_venue_li_pointdrivepresentationvieweds)
- [msevtmgt_webinarconfiguration_li_pointdrivepresentationvieweds](#BKMK_msevtmgt_webinarconfiguration_li_pointdrivepresentationvieweds)
- [msevtmgt_webinarprovider_li_pointdrivepresentationvieweds](#BKMK_msevtmgt_webinarprovider_li_pointdrivepresentationvieweds)
- [mspp_adplacement_li_pointdrivepresentationvieweds](#BKMK_mspp_adplacement_li_pointdrivepresentationvieweds)
- [mspp_pollplacement_li_pointdrivepresentationvieweds](#BKMK_mspp_pollplacement_li_pointdrivepresentationvieweds)
- [mspp_publishingstatetransitionrule_li_pointdrivepresentationvieweds](#BKMK_mspp_publishingstatetransitionrule_li_pointdrivepresentationvieweds)
- [mspp_redirect_li_pointdrivepresentationvieweds](#BKMK_mspp_redirect_li_pointdrivepresentationvieweds)
- [mspp_shortcut_li_pointdrivepresentationvieweds](#BKMK_mspp_shortcut_li_pointdrivepresentationvieweds)
- [mspp_website_li_pointdrivepresentationvieweds](#BKMK_mspp_website_li_pointdrivepresentationvieweds)
- [opportunity_li_pointdrivepresentationvieweds](#BKMK_opportunity_li_pointdrivepresentationvieweds)
- [quote_li_pointdrivepresentationvieweds](#BKMK_quote_li_pointdrivepresentationvieweds)
- [salesorder_li_pointdrivepresentationvieweds](#BKMK_salesorder_li_pointdrivepresentationvieweds)
- [site_li_pointdrivepresentationvieweds](#BKMK_site_li_pointdrivepresentationvieweds)

### <a name="BKMK_account_li_pointdrivepresentationvieweds"></a> account_li_pointdrivepresentationvieweds

One-To-Many Relationship: [account account_li_pointdrivepresentationvieweds](account.md#BKMK_account_li_pointdrivepresentationvieweds)

|Property|Value|
|---|---|
|ReferencedEntity|`account`|
|ReferencedAttribute|`accountid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_account_li_pointdrivepresentationviewed`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `Cascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_activity_pointer_li_pointdrivepresentationviewed"></a> activity_pointer_li_pointdrivepresentationviewed

One-To-Many Relationship: [activitypointer activity_pointer_li_pointdrivepresentationviewed](activitypointer.md#BKMK_activity_pointer_li_pointdrivepresentationviewed)

|Property|Value|
|---|---|
|ReferencedEntity|`activitypointer`|
|ReferencedAttribute|`activityid`|
|ReferencingAttribute|`activityid`|
|ReferencingEntityNavigationPropertyName|`activityid_li_pointdrivepresentationviewed`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_adx_ad_li_pointdrivepresentationvieweds"></a> adx_ad_li_pointdrivepresentationvieweds

One-To-Many Relationship: [adx_ad adx_ad_li_pointdrivepresentationvieweds](adx_ad.md#BKMK_adx_ad_li_pointdrivepresentationvieweds)

|Property|Value|
|---|---|
|ReferencedEntity|`adx_ad`|
|ReferencedAttribute|`adx_adid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_adx_ad_li_pointdrivepresentationviewed`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_adx_adplacement_li_pointdrivepresentationvieweds"></a> adx_adplacement_li_pointdrivepresentationvieweds

One-To-Many Relationship: [adx_adplacement adx_adplacement_li_pointdrivepresentationvieweds](adx_adplacement.md#BKMK_adx_adplacement_li_pointdrivepresentationvieweds)

|Property|Value|
|---|---|
|ReferencedEntity|`adx_adplacement`|
|ReferencedAttribute|`adx_adplacementid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_adx_adplacement_li_pointdrivepresentationviewed`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_adx_casedeflection_li_pointdrivepresentationvieweds"></a> adx_casedeflection_li_pointdrivepresentationvieweds

One-To-Many Relationship: [adx_casedeflection adx_casedeflection_li_pointdrivepresentationvieweds](adx_casedeflection.md#BKMK_adx_casedeflection_li_pointdrivepresentationvieweds)

|Property|Value|
|---|---|
|ReferencedEntity|`adx_casedeflection`|
|ReferencedAttribute|`adx_casedeflectionid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_adx_casedeflection_li_pointdrivepresentationviewed`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_adx_communityforumaccesspermission_li_pointdrivepresentationvieweds"></a> adx_communityforumaccesspermission_li_pointdrivepresentationvieweds

One-To-Many Relationship: [adx_communityforumaccesspermission adx_communityforumaccesspermission_li_pointdrivepresentationvieweds](adx_communityforumaccesspermission.md#BKMK_adx_communityforumaccesspermission_li_pointdrivepresentationvieweds)

|Property|Value|
|---|---|
|ReferencedEntity|`adx_communityforumaccesspermission`|
|ReferencedAttribute|`adx_communityforumaccesspermissionid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_adx_communityforumaccesspermission_li_pointdrivepresentationviewed`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_adx_communityforumalert_li_pointdrivepresentationvieweds"></a> adx_communityforumalert_li_pointdrivepresentationvieweds

One-To-Many Relationship: [adx_communityforumalert adx_communityforumalert_li_pointdrivepresentationvieweds](adx_communityforumalert.md#BKMK_adx_communityforumalert_li_pointdrivepresentationvieweds)

|Property|Value|
|---|---|
|ReferencedEntity|`adx_communityforumalert`|
|ReferencedAttribute|`adx_communityforumalertid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_adx_communityforumalert_li_pointdrivepresentationviewed`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_adx_contentaccesslevel_li_pointdrivepresentationvieweds"></a> adx_contentaccesslevel_li_pointdrivepresentationvieweds

One-To-Many Relationship: [adx_contentaccesslevel adx_contentaccesslevel_li_pointdrivepresentationvieweds](adx_contentaccesslevel.md#BKMK_adx_contentaccesslevel_li_pointdrivepresentationvieweds)

|Property|Value|
|---|---|
|ReferencedEntity|`adx_contentaccesslevel`|
|ReferencedAttribute|`adx_contentaccesslevelid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_adx_contentaccesslevel_li_pointdrivepresentationviewed`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_adx_invitation_li_pointdrivepresentationvieweds"></a> adx_invitation_li_pointdrivepresentationvieweds

One-To-Many Relationship: [adx_invitation adx_invitation_li_pointdrivepresentationvieweds](adx_invitation.md#BKMK_adx_invitation_li_pointdrivepresentationvieweds)

|Property|Value|
|---|---|
|ReferencedEntity|`adx_invitation`|
|ReferencedAttribute|`adx_invitationid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_adx_invitation_li_pointdrivepresentationviewed`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_adx_poll_li_pointdrivepresentationvieweds"></a> adx_poll_li_pointdrivepresentationvieweds

One-To-Many Relationship: [adx_poll adx_poll_li_pointdrivepresentationvieweds](adx_poll.md#BKMK_adx_poll_li_pointdrivepresentationvieweds)

|Property|Value|
|---|---|
|ReferencedEntity|`adx_poll`|
|ReferencedAttribute|`adx_pollid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_adx_poll_li_pointdrivepresentationviewed`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_adx_polloption_li_pointdrivepresentationvieweds"></a> adx_polloption_li_pointdrivepresentationvieweds

One-To-Many Relationship: [adx_polloption adx_polloption_li_pointdrivepresentationvieweds](adx_polloption.md#BKMK_adx_polloption_li_pointdrivepresentationvieweds)

|Property|Value|
|---|---|
|ReferencedEntity|`adx_polloption`|
|ReferencedAttribute|`adx_polloptionid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_adx_polloption_li_pointdrivepresentationviewed`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_adx_pollplacement_li_pointdrivepresentationvieweds"></a> adx_pollplacement_li_pointdrivepresentationvieweds

One-To-Many Relationship: [adx_pollplacement adx_pollplacement_li_pointdrivepresentationvieweds](adx_pollplacement.md#BKMK_adx_pollplacement_li_pointdrivepresentationvieweds)

|Property|Value|
|---|---|
|ReferencedEntity|`adx_pollplacement`|
|ReferencedAttribute|`adx_pollplacementid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_adx_pollplacement_li_pointdrivepresentationviewed`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_adx_pollsubmission_li_pointdrivepresentationvieweds"></a> adx_pollsubmission_li_pointdrivepresentationvieweds

One-To-Many Relationship: [adx_pollsubmission adx_pollsubmission_li_pointdrivepresentationvieweds](adx_pollsubmission.md#BKMK_adx_pollsubmission_li_pointdrivepresentationvieweds)

|Property|Value|
|---|---|
|ReferencedEntity|`adx_pollsubmission`|
|ReferencedAttribute|`adx_pollsubmissionid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_adx_pollsubmission_li_pointdrivepresentationviewed`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_adx_publishingstatetransitionrule_li_pointdrivepresentationvieweds"></a> adx_publishingstatetransitionrule_li_pointdrivepresentationvieweds

One-To-Many Relationship: [adx_publishingstatetransitionrule adx_publishingstatetransitionrule_li_pointdrivepresentationvieweds](adx_publishingstatetransitionrule.md#BKMK_adx_publishingstatetransitionrule_li_pointdrivepresentationvieweds)

|Property|Value|
|---|---|
|ReferencedEntity|`adx_publishingstatetransitionrule`|
|ReferencedAttribute|`adx_publishingstatetransitionruleid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_adx_publishingstatetransitionrule_li_pointdrivepresentationviewed`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_adx_redirect_li_pointdrivepresentationvieweds"></a> adx_redirect_li_pointdrivepresentationvieweds

One-To-Many Relationship: [adx_redirect adx_redirect_li_pointdrivepresentationvieweds](adx_redirect.md#BKMK_adx_redirect_li_pointdrivepresentationvieweds)

|Property|Value|
|---|---|
|ReferencedEntity|`adx_redirect`|
|ReferencedAttribute|`adx_redirectid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_adx_redirect_li_pointdrivepresentationviewed`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_adx_shortcut_li_pointdrivepresentationvieweds"></a> adx_shortcut_li_pointdrivepresentationvieweds

One-To-Many Relationship: [adx_shortcut adx_shortcut_li_pointdrivepresentationvieweds](adx_shortcut.md#BKMK_adx_shortcut_li_pointdrivepresentationvieweds)

|Property|Value|
|---|---|
|ReferencedEntity|`adx_shortcut`|
|ReferencedAttribute|`adx_shortcutid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_adx_shortcut_li_pointdrivepresentationviewed`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_adx_webpage_li_pointdrivepresentationvieweds"></a> adx_webpage_li_pointdrivepresentationvieweds

One-To-Many Relationship: [adx_webpage adx_webpage_li_pointdrivepresentationvieweds](adx_webpage.md#BKMK_adx_webpage_li_pointdrivepresentationvieweds)

|Property|Value|
|---|---|
|ReferencedEntity|`adx_webpage`|
|ReferencedAttribute|`adx_webpageid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_adx_webpage_li_pointdrivepresentationviewed`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_adx_website_li_pointdrivepresentationvieweds"></a> adx_website_li_pointdrivepresentationvieweds

One-To-Many Relationship: [adx_website adx_website_li_pointdrivepresentationvieweds](adx_website.md#BKMK_adx_website_li_pointdrivepresentationvieweds)

|Property|Value|
|---|---|
|ReferencedEntity|`adx_website`|
|ReferencedAttribute|`adx_websiteid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_adx_website_li_pointdrivepresentationviewed`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_bookableresourcebooking_li_pointdrivepresentationvieweds"></a> bookableresourcebooking_li_pointdrivepresentationvieweds

One-To-Many Relationship: [bookableresourcebooking bookableresourcebooking_li_pointdrivepresentationvieweds](bookableresourcebooking.md#BKMK_bookableresourcebooking_li_pointdrivepresentationvieweds)

|Property|Value|
|---|---|
|ReferencedEntity|`bookableresourcebooking`|
|ReferencedAttribute|`bookableresourcebookingid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_bookableresourcebooking_li_pointdrivepresentationviewed`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_bookableresourcebookingheader_li_pointdrivepresentationvieweds"></a> bookableresourcebookingheader_li_pointdrivepresentationvieweds

One-To-Many Relationship: [bookableresourcebookingheader bookableresourcebookingheader_li_pointdrivepresentationvieweds](bookableresourcebookingheader.md#BKMK_bookableresourcebookingheader_li_pointdrivepresentationvieweds)

|Property|Value|
|---|---|
|ReferencedEntity|`bookableresourcebookingheader`|
|ReferencedAttribute|`bookableresourcebookingheaderid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_bookableresourcebookingheader_li_pointdrivepresentationviewed`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_bulkoperation_li_pointdrivepresentationvieweds"></a> bulkoperation_li_pointdrivepresentationvieweds

One-To-Many Relationship: [bulkoperation bulkoperation_li_pointdrivepresentationvieweds](bulkoperation.md#BKMK_bulkoperation_li_pointdrivepresentationvieweds)

|Property|Value|
|---|---|
|ReferencedEntity|`bulkoperation`|
|ReferencedAttribute|`activityid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_bulkoperation_li_pointdrivepresentationviewed`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_campaign_li_pointdrivepresentationvieweds"></a> campaign_li_pointdrivepresentationvieweds

One-To-Many Relationship: [campaign campaign_li_pointdrivepresentationvieweds](campaign.md#BKMK_campaign_li_pointdrivepresentationvieweds)

|Property|Value|
|---|---|
|ReferencedEntity|`campaign`|
|ReferencedAttribute|`campaignid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_campaign_li_pointdrivepresentationviewed`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_campaignactivity_li_pointdrivepresentationvieweds"></a> campaignactivity_li_pointdrivepresentationvieweds

One-To-Many Relationship: [campaignactivity campaignactivity_li_pointdrivepresentationvieweds](campaignactivity.md#BKMK_campaignactivity_li_pointdrivepresentationvieweds)

|Property|Value|
|---|---|
|ReferencedEntity|`campaignactivity`|
|ReferencedAttribute|`activityid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_campaignactivity_li_pointdrivepresentationviewed`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_contact_li_pointdrivepresentationvieweds"></a> contact_li_pointdrivepresentationvieweds

One-To-Many Relationship: [contact contact_li_pointdrivepresentationvieweds](contact.md#BKMK_contact_li_pointdrivepresentationvieweds)

|Property|Value|
|---|---|
|ReferencedEntity|`contact`|
|ReferencedAttribute|`contactid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_contact_li_pointdrivepresentationviewed`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `Cascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_contract_li_pointdrivepresentationvieweds"></a> contract_li_pointdrivepresentationvieweds

One-To-Many Relationship: [contract contract_li_pointdrivepresentationvieweds](contract.md#BKMK_contract_li_pointdrivepresentationvieweds)

|Property|Value|
|---|---|
|ReferencedEntity|`contract`|
|ReferencedAttribute|`contractid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_contract_li_pointdrivepresentationviewed`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_entitlement_li_pointdrivepresentationvieweds"></a> entitlement_li_pointdrivepresentationvieweds

One-To-Many Relationship: [entitlement entitlement_li_pointdrivepresentationvieweds](entitlement.md#BKMK_entitlement_li_pointdrivepresentationvieweds)

|Property|Value|
|---|---|
|ReferencedEntity|`entitlement`|
|ReferencedAttribute|`entitlementid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_entitlement_li_pointdrivepresentationviewed`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_entitlementtemplate_li_pointdrivepresentationvieweds"></a> entitlementtemplate_li_pointdrivepresentationvieweds

One-To-Many Relationship: [entitlementtemplate entitlementtemplate_li_pointdrivepresentationvieweds](entitlementtemplate.md#BKMK_entitlementtemplate_li_pointdrivepresentationvieweds)

|Property|Value|
|---|---|
|ReferencedEntity|`entitlementtemplate`|
|ReferencedAttribute|`entitlementtemplateid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_entitlementtemplate_li_pointdrivepresentationviewed`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_incident_li_pointdrivepresentationvieweds"></a> incident_li_pointdrivepresentationvieweds

One-To-Many Relationship: [incident incident_li_pointdrivepresentationvieweds](incident.md#BKMK_incident_li_pointdrivepresentationvieweds)

|Property|Value|
|---|---|
|ReferencedEntity|`incident`|
|ReferencedAttribute|`incidentid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_incident_li_pointdrivepresentationviewed`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `Cascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_interactionforemail_li_pointdrivepresentationvieweds"></a> interactionforemail_li_pointdrivepresentationvieweds

One-To-Many Relationship: [interactionforemail interactionforemail_li_pointdrivepresentationvieweds](interactionforemail.md#BKMK_interactionforemail_li_pointdrivepresentationvieweds)

|Property|Value|
|---|---|
|ReferencedEntity|`interactionforemail`|
|ReferencedAttribute|`interactionforemailid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_new_interactionforemail_li_pointdrivepresentationviewed`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_invoice_li_pointdrivepresentationvieweds"></a> invoice_li_pointdrivepresentationvieweds

One-To-Many Relationship: [invoice invoice_li_pointdrivepresentationvieweds](invoice.md#BKMK_invoice_li_pointdrivepresentationvieweds)

|Property|Value|
|---|---|
|ReferencedEntity|`invoice`|
|ReferencedAttribute|`invoiceid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_invoice_li_pointdrivepresentationviewed`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_knowledgearticle_li_pointdrivepresentationvieweds"></a> knowledgearticle_li_pointdrivepresentationvieweds

One-To-Many Relationship: [knowledgearticle knowledgearticle_li_pointdrivepresentationvieweds](knowledgearticle.md#BKMK_knowledgearticle_li_pointdrivepresentationvieweds)

|Property|Value|
|---|---|
|ReferencedEntity|`knowledgearticle`|
|ReferencedAttribute|`knowledgearticleid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_knowledgearticle_li_pointdrivepresentationviewed`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_knowledgebaserecord_li_pointdrivepresentationvieweds"></a> knowledgebaserecord_li_pointdrivepresentationvieweds

One-To-Many Relationship: [knowledgebaserecord knowledgebaserecord_li_pointdrivepresentationvieweds](knowledgebaserecord.md#BKMK_knowledgebaserecord_li_pointdrivepresentationvieweds)

|Property|Value|
|---|---|
|ReferencedEntity|`knowledgebaserecord`|
|ReferencedAttribute|`knowledgebaserecordid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_knowledgebaserecord_li_pointdrivepresentationviewed`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lead_li_pointdrivepresentationvieweds"></a> lead_li_pointdrivepresentationvieweds

One-To-Many Relationship: [lead lead_li_pointdrivepresentationvieweds](lead.md#BKMK_lead_li_pointdrivepresentationvieweds)

|Property|Value|
|---|---|
|ReferencedEntity|`lead`|
|ReferencedAttribute|`leadid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_lead_li_pointdrivepresentationviewed`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `Cascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_li_pointdrivepresentationviewed_businessunit_owningbusinessunit"></a> li_pointdrivepresentationviewed_businessunit_owningbusinessunit

One-To-Many Relationship: [businessunit li_pointdrivepresentationviewed_businessunit_owningbusinessunit](businessunit.md#BKMK_li_pointdrivepresentationviewed_businessunit_owningbusinessunit)

|Property|Value|
|---|---|
|ReferencedEntity|`businessunit`|
|ReferencedAttribute|`businessunitid`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencingEntityNavigationPropertyName|`owningbusinessunit_li_pointdrivepresentationviewed`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_li_pointdrivepresentationviewed_mailbox_sendermailboxid"></a> li_pointdrivepresentationviewed_mailbox_sendermailboxid

One-To-Many Relationship: [mailbox li_pointdrivepresentationviewed_mailbox_sendermailboxid](mailbox.md#BKMK_li_pointdrivepresentationviewed_mailbox_sendermailboxid)

|Property|Value|
|---|---|
|ReferencedEntity|`mailbox`|
|ReferencedAttribute|`mailboxid`|
|ReferencingAttribute|`sendermailboxid`|
|ReferencingEntityNavigationPropertyName|`sendermailboxid_li_pointdrivepresentationviewed`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_li_pointdrivepresentationviewed_owner_ownerid"></a> li_pointdrivepresentationviewed_owner_ownerid

One-To-Many Relationship: [owner li_pointdrivepresentationviewed_owner_ownerid](owner.md#BKMK_li_pointdrivepresentationviewed_owner_ownerid)

|Property|Value|
|---|---|
|ReferencedEntity|`owner`|
|ReferencedAttribute|`ownerid`|
|ReferencingAttribute|`ownerid`|
|ReferencingEntityNavigationPropertyName|`ownerid_li_pointdrivepresentationviewed`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_li_pointdrivepresentationviewed_service_serviceid"></a> li_pointdrivepresentationviewed_service_serviceid

One-To-Many Relationship: [service li_pointdrivepresentationviewed_service_serviceid](service.md#BKMK_li_pointdrivepresentationviewed_service_serviceid)

|Property|Value|
|---|---|
|ReferencedEntity|`service`|
|ReferencedAttribute|`serviceid`|
|ReferencingAttribute|`serviceid`|
|ReferencingEntityNavigationPropertyName|`serviceid_li_pointdrivepresentationviewed`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Restrict`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_li_pointdrivepresentationviewed_sla_slaid"></a> li_pointdrivepresentationviewed_sla_slaid

One-To-Many Relationship: [sla li_pointdrivepresentationviewed_sla_slaid](sla.md#BKMK_li_pointdrivepresentationviewed_sla_slaid)

|Property|Value|
|---|---|
|ReferencedEntity|`sla`|
|ReferencedAttribute|`slaid`|
|ReferencingAttribute|`slaid`|
|ReferencingEntityNavigationPropertyName|`sla_activitypointer_sla_li_pointdrivepresentationviewed`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_li_pointdrivepresentationviewed_sla_slainvokedid"></a> li_pointdrivepresentationviewed_sla_slainvokedid

One-To-Many Relationship: [sla li_pointdrivepresentationviewed_sla_slainvokedid](sla.md#BKMK_li_pointdrivepresentationviewed_sla_slainvokedid)

|Property|Value|
|---|---|
|ReferencedEntity|`sla`|
|ReferencedAttribute|`slaid`|
|ReferencingAttribute|`slainvokedid`|
|ReferencingEntityNavigationPropertyName|`slainvokedid_activitypointer_sla_li_pointdrivepresentationviewed`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_li_pointdrivepresentationviewed_systemuser_createdby"></a> li_pointdrivepresentationviewed_systemuser_createdby

One-To-Many Relationship: [systemuser li_pointdrivepresentationviewed_systemuser_createdby](systemuser.md#BKMK_li_pointdrivepresentationviewed_systemuser_createdby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdby`|
|ReferencingEntityNavigationPropertyName|`createdby_li_pointdrivepresentationviewed`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_li_pointdrivepresentationviewed_systemuser_createdonbehalfby"></a> li_pointdrivepresentationviewed_systemuser_createdonbehalfby

One-To-Many Relationship: [systemuser li_pointdrivepresentationviewed_systemuser_createdonbehalfby](systemuser.md#BKMK_li_pointdrivepresentationviewed_systemuser_createdonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdonbehalfby`|
|ReferencingEntityNavigationPropertyName|`createdonbehalfby_li_pointdrivepresentationviewed`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_li_pointdrivepresentationviewed_systemuser_modifiedby"></a> li_pointdrivepresentationviewed_systemuser_modifiedby

One-To-Many Relationship: [systemuser li_pointdrivepresentationviewed_systemuser_modifiedby](systemuser.md#BKMK_li_pointdrivepresentationviewed_systemuser_modifiedby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedby`|
|ReferencingEntityNavigationPropertyName|`modifiedby_li_pointdrivepresentationviewed`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_li_pointdrivepresentationviewed_systemuser_modifiedonbehalfby"></a> li_pointdrivepresentationviewed_systemuser_modifiedonbehalfby

One-To-Many Relationship: [systemuser li_pointdrivepresentationviewed_systemuser_modifiedonbehalfby](systemuser.md#BKMK_li_pointdrivepresentationviewed_systemuser_modifiedonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedonbehalfby`|
|ReferencingEntityNavigationPropertyName|`modifiedonbehalfby_li_pointdrivepresentationviewed`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_li_pointdrivepresentationviewed_systemuser_owninguser"></a> li_pointdrivepresentationviewed_systemuser_owninguser

One-To-Many Relationship: [systemuser li_pointdrivepresentationviewed_systemuser_owninguser](systemuser.md#BKMK_li_pointdrivepresentationviewed_systemuser_owninguser)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`owninguser`|
|ReferencingEntityNavigationPropertyName|`owninguser_li_pointdrivepresentationviewed`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_li_pointdrivepresentationviewed_team_owningteam"></a> li_pointdrivepresentationviewed_team_owningteam

One-To-Many Relationship: [team li_pointdrivepresentationviewed_team_owningteam](team.md#BKMK_li_pointdrivepresentationviewed_team_owningteam)

|Property|Value|
|---|---|
|ReferencedEntity|`team`|
|ReferencedAttribute|`teamid`|
|ReferencingAttribute|`owningteam`|
|ReferencingEntityNavigationPropertyName|`owningteam_li_pointdrivepresentationviewed`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_li_pointdrivepresentationviewed_transactioncurrency_transactioncurrencyid"></a> li_pointdrivepresentationviewed_transactioncurrency_transactioncurrencyid

One-To-Many Relationship: [transactioncurrency li_pointdrivepresentationviewed_transactioncurrency_transactioncurrencyid](transactioncurrency.md#BKMK_li_pointdrivepresentationviewed_transactioncurrency_transactioncurrencyid)

|Property|Value|
|---|---|
|ReferencedEntity|`transactioncurrency`|
|ReferencedAttribute|`transactioncurrencyid`|
|ReferencingAttribute|`transactioncurrencyid`|
|ReferencingEntityNavigationPropertyName|`transactioncurrencyid_li_pointdrivepresentationviewed`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Restrict`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_agreement_li_pointdrivepresentationvieweds"></a> msdyn_agreement_li_pointdrivepresentationvieweds

One-To-Many Relationship: [msdyn_agreement msdyn_agreement_li_pointdrivepresentationvieweds](msdyn_agreement.md#BKMK_msdyn_agreement_li_pointdrivepresentationvieweds)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_agreement`|
|ReferencedAttribute|`msdyn_agreementid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_agreement_li_pointdrivepresentationviewed`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_agreementbookingdate_li_pointdrivepresentationvieweds"></a> msdyn_agreementbookingdate_li_pointdrivepresentationvieweds

One-To-Many Relationship: [msdyn_agreementbookingdate msdyn_agreementbookingdate_li_pointdrivepresentationvieweds](msdyn_agreementbookingdate.md#BKMK_msdyn_agreementbookingdate_li_pointdrivepresentationvieweds)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_agreementbookingdate`|
|ReferencedAttribute|`msdyn_agreementbookingdateid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_agreementbookingdate_li_pointdrivepresentationviewed`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_agreementbookingincident_li_pointdrivepresentationvieweds"></a> msdyn_agreementbookingincident_li_pointdrivepresentationvieweds

One-To-Many Relationship: [msdyn_agreementbookingincident msdyn_agreementbookingincident_li_pointdrivepresentationvieweds](msdyn_agreementbookingincident.md#BKMK_msdyn_agreementbookingincident_li_pointdrivepresentationvieweds)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_agreementbookingincident`|
|ReferencedAttribute|`msdyn_agreementbookingincidentid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_agreementbookingincident_li_pointdrivepresentationviewed`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_agreementbookingproduct_li_pointdrivepresentationvieweds"></a> msdyn_agreementbookingproduct_li_pointdrivepresentationvieweds

One-To-Many Relationship: [msdyn_agreementbookingproduct msdyn_agreementbookingproduct_li_pointdrivepresentationvieweds](msdyn_agreementbookingproduct.md#BKMK_msdyn_agreementbookingproduct_li_pointdrivepresentationvieweds)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_agreementbookingproduct`|
|ReferencedAttribute|`msdyn_agreementbookingproductid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_agreementbookingproduct_li_pointdrivepresentationviewed`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_agreementbookingservice_li_pointdrivepresentationvieweds"></a> msdyn_agreementbookingservice_li_pointdrivepresentationvieweds

One-To-Many Relationship: [msdyn_agreementbookingservice msdyn_agreementbookingservice_li_pointdrivepresentationvieweds](msdyn_agreementbookingservice.md#BKMK_msdyn_agreementbookingservice_li_pointdrivepresentationvieweds)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_agreementbookingservice`|
|ReferencedAttribute|`msdyn_agreementbookingserviceid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_agreementbookingservice_li_pointdrivepresentationviewed`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_agreementbookingservicetask_li_pointdrivepresentationvieweds"></a> msdyn_agreementbookingservicetask_li_pointdrivepresentationvieweds

One-To-Many Relationship: [msdyn_agreementbookingservicetask msdyn_agreementbookingservicetask_li_pointdrivepresentationvieweds](msdyn_agreementbookingservicetask.md#BKMK_msdyn_agreementbookingservicetask_li_pointdrivepresentationvieweds)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_agreementbookingservicetask`|
|ReferencedAttribute|`msdyn_agreementbookingservicetaskid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_agreementbookingservicetask_li_pointdrivepresentationviewed`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_agreementbookingsetup_li_pointdrivepresentationvieweds"></a> msdyn_agreementbookingsetup_li_pointdrivepresentationvieweds

One-To-Many Relationship: [msdyn_agreementbookingsetup msdyn_agreementbookingsetup_li_pointdrivepresentationvieweds](msdyn_agreementbookingsetup.md#BKMK_msdyn_agreementbookingsetup_li_pointdrivepresentationvieweds)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_agreementbookingsetup`|
|ReferencedAttribute|`msdyn_agreementbookingsetupid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_agreementbookingsetup_li_pointdrivepresentationviewed`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_agreementinvoicedate_li_pointdrivepresentationvieweds"></a> msdyn_agreementinvoicedate_li_pointdrivepresentationvieweds

One-To-Many Relationship: [msdyn_agreementinvoicedate msdyn_agreementinvoicedate_li_pointdrivepresentationvieweds](msdyn_agreementinvoicedate.md#BKMK_msdyn_agreementinvoicedate_li_pointdrivepresentationvieweds)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_agreementinvoicedate`|
|ReferencedAttribute|`msdyn_agreementinvoicedateid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_agreementinvoicedate_li_pointdrivepresentationviewed`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_agreementinvoiceproduct_li_pointdrivepresentationvieweds"></a> msdyn_agreementinvoiceproduct_li_pointdrivepresentationvieweds

One-To-Many Relationship: [msdyn_agreementinvoiceproduct msdyn_agreementinvoiceproduct_li_pointdrivepresentationvieweds](msdyn_agreementinvoiceproduct.md#BKMK_msdyn_agreementinvoiceproduct_li_pointdrivepresentationvieweds)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_agreementinvoiceproduct`|
|ReferencedAttribute|`msdyn_agreementinvoiceproductid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_agreementinvoiceproduct_li_pointdrivepresentationviewed`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_agreementinvoicesetup_li_pointdrivepresentationvieweds"></a> msdyn_agreementinvoicesetup_li_pointdrivepresentationvieweds

One-To-Many Relationship: [msdyn_agreementinvoicesetup msdyn_agreementinvoicesetup_li_pointdrivepresentationvieweds](msdyn_agreementinvoicesetup.md#BKMK_msdyn_agreementinvoicesetup_li_pointdrivepresentationvieweds)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_agreementinvoicesetup`|
|ReferencedAttribute|`msdyn_agreementinvoicesetupid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_agreementinvoicesetup_li_pointdrivepresentationviewed`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_bookingalertstatus_li_pointdrivepresentationvieweds"></a> msdyn_bookingalertstatus_li_pointdrivepresentationvieweds

One-To-Many Relationship: [msdyn_bookingalertstatus msdyn_bookingalertstatus_li_pointdrivepresentationvieweds](msdyn_bookingalertstatus.md#BKMK_msdyn_bookingalertstatus_li_pointdrivepresentationvieweds)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_bookingalertstatus`|
|ReferencedAttribute|`msdyn_bookingalertstatusid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_bookingalertstatus_li_pointdrivepresentationviewed`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_bookingrule_li_pointdrivepresentationvieweds"></a> msdyn_bookingrule_li_pointdrivepresentationvieweds

One-To-Many Relationship: [msdyn_bookingrule msdyn_bookingrule_li_pointdrivepresentationvieweds](msdyn_bookingrule.md#BKMK_msdyn_bookingrule_li_pointdrivepresentationvieweds)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_bookingrule`|
|ReferencedAttribute|`msdyn_bookingruleid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_bookingrule_li_pointdrivepresentationviewed`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_bookingtimestamp_li_pointdrivepresentationvieweds"></a> msdyn_bookingtimestamp_li_pointdrivepresentationvieweds

One-To-Many Relationship: [msdyn_bookingtimestamp msdyn_bookingtimestamp_li_pointdrivepresentationvieweds](msdyn_bookingtimestamp.md#BKMK_msdyn_bookingtimestamp_li_pointdrivepresentationvieweds)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_bookingtimestamp`|
|ReferencedAttribute|`msdyn_bookingtimestampid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_bookingtimestamp_li_pointdrivepresentationviewed`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_customerasset_li_pointdrivepresentationvieweds"></a> msdyn_customerasset_li_pointdrivepresentationvieweds

One-To-Many Relationship: [msdyn_customerasset msdyn_customerasset_li_pointdrivepresentationvieweds](msdyn_customerasset.md#BKMK_msdyn_customerasset_li_pointdrivepresentationvieweds)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_customerasset`|
|ReferencedAttribute|`msdyn_customerassetid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_customerasset_li_pointdrivepresentationviewed`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_fieldservicesetting_li_pointdrivepresentationvieweds"></a> msdyn_fieldservicesetting_li_pointdrivepresentationvieweds

One-To-Many Relationship: [msdyn_fieldservicesetting msdyn_fieldservicesetting_li_pointdrivepresentationvieweds](msdyn_fieldservicesetting.md#BKMK_msdyn_fieldservicesetting_li_pointdrivepresentationvieweds)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_fieldservicesetting`|
|ReferencedAttribute|`msdyn_fieldservicesettingid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_fieldservicesetting_li_pointdrivepresentationviewed`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_incidenttypecharacteristic_li_pointdrivepresentationvieweds"></a> msdyn_incidenttypecharacteristic_li_pointdrivepresentationvieweds

One-To-Many Relationship: [msdyn_incidenttypecharacteristic msdyn_incidenttypecharacteristic_li_pointdrivepresentationvieweds](msdyn_incidenttypecharacteristic.md#BKMK_msdyn_incidenttypecharacteristic_li_pointdrivepresentationvieweds)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_incidenttypecharacteristic`|
|ReferencedAttribute|`msdyn_incidenttypecharacteristicid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_incidenttypecharacteristic_li_pointdrivepresentationviewed`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_incidenttypeproduct_li_pointdrivepresentationvieweds"></a> msdyn_incidenttypeproduct_li_pointdrivepresentationvieweds

One-To-Many Relationship: [msdyn_incidenttypeproduct msdyn_incidenttypeproduct_li_pointdrivepresentationvieweds](msdyn_incidenttypeproduct.md#BKMK_msdyn_incidenttypeproduct_li_pointdrivepresentationvieweds)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_incidenttypeproduct`|
|ReferencedAttribute|`msdyn_incidenttypeproductid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_incidenttypeproduct_li_pointdrivepresentationviewed`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_incidenttypeservice_li_pointdrivepresentationvieweds"></a> msdyn_incidenttypeservice_li_pointdrivepresentationvieweds

One-To-Many Relationship: [msdyn_incidenttypeservice msdyn_incidenttypeservice_li_pointdrivepresentationvieweds](msdyn_incidenttypeservice.md#BKMK_msdyn_incidenttypeservice_li_pointdrivepresentationvieweds)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_incidenttypeservice`|
|ReferencedAttribute|`msdyn_incidenttypeserviceid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_incidenttypeservice_li_pointdrivepresentationviewed`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_inventoryadjustment_li_pointdrivepresentationvieweds"></a> msdyn_inventoryadjustment_li_pointdrivepresentationvieweds

One-To-Many Relationship: [msdyn_inventoryadjustment msdyn_inventoryadjustment_li_pointdrivepresentationvieweds](msdyn_inventoryadjustment.md#BKMK_msdyn_inventoryadjustment_li_pointdrivepresentationvieweds)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_inventoryadjustment`|
|ReferencedAttribute|`msdyn_inventoryadjustmentid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_inventoryadjustment_li_pointdrivepresentationviewed`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_inventoryadjustmentproduct_li_pointdrivepresentationvieweds"></a> msdyn_inventoryadjustmentproduct_li_pointdrivepresentationvieweds

One-To-Many Relationship: [msdyn_inventoryadjustmentproduct msdyn_inventoryadjustmentproduct_li_pointdrivepresentationvieweds](msdyn_inventoryadjustmentproduct.md#BKMK_msdyn_inventoryadjustmentproduct_li_pointdrivepresentationvieweds)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_inventoryadjustmentproduct`|
|ReferencedAttribute|`msdyn_inventoryadjustmentproductid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_inventoryadjustmentproduct_li_pointdrivepresentationviewed`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_inventoryjournal_li_pointdrivepresentationvieweds"></a> msdyn_inventoryjournal_li_pointdrivepresentationvieweds

One-To-Many Relationship: [msdyn_inventoryjournal msdyn_inventoryjournal_li_pointdrivepresentationvieweds](msdyn_inventoryjournal.md#BKMK_msdyn_inventoryjournal_li_pointdrivepresentationvieweds)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_inventoryjournal`|
|ReferencedAttribute|`msdyn_inventoryjournalid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_inventoryjournal_li_pointdrivepresentationviewed`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_inventorytransfer_li_pointdrivepresentationvieweds"></a> msdyn_inventorytransfer_li_pointdrivepresentationvieweds

One-To-Many Relationship: [msdyn_inventorytransfer msdyn_inventorytransfer_li_pointdrivepresentationvieweds](msdyn_inventorytransfer.md#BKMK_msdyn_inventorytransfer_li_pointdrivepresentationvieweds)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_inventorytransfer`|
|ReferencedAttribute|`msdyn_inventorytransferid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_inventorytransfer_li_pointdrivepresentationviewed`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_payment_li_pointdrivepresentationvieweds"></a> msdyn_payment_li_pointdrivepresentationvieweds

One-To-Many Relationship: [msdyn_payment msdyn_payment_li_pointdrivepresentationvieweds](msdyn_payment.md#BKMK_msdyn_payment_li_pointdrivepresentationvieweds)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_payment`|
|ReferencedAttribute|`msdyn_paymentid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_payment_li_pointdrivepresentationviewed`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_paymentdetail_li_pointdrivepresentationvieweds"></a> msdyn_paymentdetail_li_pointdrivepresentationvieweds

One-To-Many Relationship: [msdyn_paymentdetail msdyn_paymentdetail_li_pointdrivepresentationvieweds](msdyn_paymentdetail.md#BKMK_msdyn_paymentdetail_li_pointdrivepresentationvieweds)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_paymentdetail`|
|ReferencedAttribute|`msdyn_paymentdetailid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_paymentdetail_li_pointdrivepresentationviewed`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_paymentmethod_li_pointdrivepresentationvieweds"></a> msdyn_paymentmethod_li_pointdrivepresentationvieweds

One-To-Many Relationship: [msdyn_paymentmethod msdyn_paymentmethod_li_pointdrivepresentationvieweds](msdyn_paymentmethod.md#BKMK_msdyn_paymentmethod_li_pointdrivepresentationvieweds)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_paymentmethod`|
|ReferencedAttribute|`msdyn_paymentmethodid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_paymentmethod_li_pointdrivepresentationviewed`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_paymentterm_li_pointdrivepresentationvieweds"></a> msdyn_paymentterm_li_pointdrivepresentationvieweds

One-To-Many Relationship: [msdyn_paymentterm msdyn_paymentterm_li_pointdrivepresentationvieweds](msdyn_paymentterm.md#BKMK_msdyn_paymentterm_li_pointdrivepresentationvieweds)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_paymentterm`|
|ReferencedAttribute|`msdyn_paymenttermid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_paymentterm_li_pointdrivepresentationviewed`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_playbookinstance_li_pointdrivepresentationvieweds"></a> msdyn_playbookinstance_li_pointdrivepresentationvieweds

One-To-Many Relationship: [msdyn_playbookinstance msdyn_playbookinstance_li_pointdrivepresentationvieweds](msdyn_playbookinstance.md#BKMK_msdyn_playbookinstance_li_pointdrivepresentationvieweds)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_playbookinstance`|
|ReferencedAttribute|`msdyn_playbookinstanceid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_playbookinstance_li_pointdrivepresentationviewed`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_postalbum_li_pointdrivepresentationvieweds"></a> msdyn_postalbum_li_pointdrivepresentationvieweds

One-To-Many Relationship: [msdyn_postalbum msdyn_postalbum_li_pointdrivepresentationvieweds](msdyn_postalbum.md#BKMK_msdyn_postalbum_li_pointdrivepresentationvieweds)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_postalbum`|
|ReferencedAttribute|`msdyn_postalbumid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_postalbum_li_pointdrivepresentationviewed`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_postalcode_li_pointdrivepresentationvieweds"></a> msdyn_postalcode_li_pointdrivepresentationvieweds

One-To-Many Relationship: [msdyn_postalcode msdyn_postalcode_li_pointdrivepresentationvieweds](msdyn_postalcode.md#BKMK_msdyn_postalcode_li_pointdrivepresentationvieweds)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_postalcode`|
|ReferencedAttribute|`msdyn_postalcodeid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_postalcode_li_pointdrivepresentationviewed`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_productinventory_li_pointdrivepresentationvieweds"></a> msdyn_productinventory_li_pointdrivepresentationvieweds

One-To-Many Relationship: [msdyn_productinventory msdyn_productinventory_li_pointdrivepresentationvieweds](msdyn_productinventory.md#BKMK_msdyn_productinventory_li_pointdrivepresentationvieweds)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_productinventory`|
|ReferencedAttribute|`msdyn_productinventoryid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_productinventory_li_pointdrivepresentationviewed`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_purchaseorder_li_pointdrivepresentationvieweds"></a> msdyn_purchaseorder_li_pointdrivepresentationvieweds

One-To-Many Relationship: [msdyn_purchaseorder msdyn_purchaseorder_li_pointdrivepresentationvieweds](msdyn_purchaseorder.md#BKMK_msdyn_purchaseorder_li_pointdrivepresentationvieweds)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_purchaseorder`|
|ReferencedAttribute|`msdyn_purchaseorderid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_purchaseorder_li_pointdrivepresentationviewed`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_purchaseorderbill_li_pointdrivepresentationvieweds"></a> msdyn_purchaseorderbill_li_pointdrivepresentationvieweds

One-To-Many Relationship: [msdyn_purchaseorderbill msdyn_purchaseorderbill_li_pointdrivepresentationvieweds](msdyn_purchaseorderbill.md#BKMK_msdyn_purchaseorderbill_li_pointdrivepresentationvieweds)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_purchaseorderbill`|
|ReferencedAttribute|`msdyn_purchaseorderbillid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_purchaseorderbill_li_pointdrivepresentationviewed`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_purchaseorderproduct_li_pointdrivepresentationvieweds"></a> msdyn_purchaseorderproduct_li_pointdrivepresentationvieweds

One-To-Many Relationship: [msdyn_purchaseorderproduct msdyn_purchaseorderproduct_li_pointdrivepresentationvieweds](msdyn_purchaseorderproduct.md#BKMK_msdyn_purchaseorderproduct_li_pointdrivepresentationvieweds)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_purchaseorderproduct`|
|ReferencedAttribute|`msdyn_purchaseorderproductid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_purchaseorderproduct_li_pointdrivepresentationviewed`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_purchaseorderreceipt_li_pointdrivepresentationvieweds"></a> msdyn_purchaseorderreceipt_li_pointdrivepresentationvieweds

One-To-Many Relationship: [msdyn_purchaseorderreceipt msdyn_purchaseorderreceipt_li_pointdrivepresentationvieweds](msdyn_purchaseorderreceipt.md#BKMK_msdyn_purchaseorderreceipt_li_pointdrivepresentationvieweds)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_purchaseorderreceipt`|
|ReferencedAttribute|`msdyn_purchaseorderreceiptid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_purchaseorderreceipt_li_pointdrivepresentationviewed`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_purchaseorderreceiptproduct_li_pointdrivepresentationvieweds"></a> msdyn_purchaseorderreceiptproduct_li_pointdrivepresentationvieweds

One-To-Many Relationship: [msdyn_purchaseorderreceiptproduct msdyn_purchaseorderreceiptproduct_li_pointdrivepresentationvieweds](msdyn_purchaseorderreceiptproduct.md#BKMK_msdyn_purchaseorderreceiptproduct_li_pointdrivepresentationvieweds)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_purchaseorderreceiptproduct`|
|ReferencedAttribute|`msdyn_purchaseorderreceiptproductid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_purchaseorderreceiptproduct_li_pointdrivepresentationviewed`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_purchaseordersubstatus_li_pointdrivepresentationvieweds"></a> msdyn_purchaseordersubstatus_li_pointdrivepresentationvieweds

One-To-Many Relationship: [msdyn_purchaseordersubstatus msdyn_purchaseordersubstatus_li_pointdrivepresentationvieweds](msdyn_purchaseordersubstatus.md#BKMK_msdyn_purchaseordersubstatus_li_pointdrivepresentationvieweds)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_purchaseordersubstatus`|
|ReferencedAttribute|`msdyn_purchaseordersubstatusid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_purchaseordersubstatus_li_pointdrivepresentationviewed`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_quotebookingincident_li_pointdrivepresentationvieweds"></a> msdyn_quotebookingincident_li_pointdrivepresentationvieweds

One-To-Many Relationship: [msdyn_quotebookingincident msdyn_quotebookingincident_li_pointdrivepresentationvieweds](msdyn_quotebookingincident.md#BKMK_msdyn_quotebookingincident_li_pointdrivepresentationvieweds)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_quotebookingincident`|
|ReferencedAttribute|`msdyn_quotebookingincidentid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_quotebookingincident_li_pointdrivepresentationviewed`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_quotebookingproduct_li_pointdrivepresentationvieweds"></a> msdyn_quotebookingproduct_li_pointdrivepresentationvieweds

One-To-Many Relationship: [msdyn_quotebookingproduct msdyn_quotebookingproduct_li_pointdrivepresentationvieweds](msdyn_quotebookingproduct.md#BKMK_msdyn_quotebookingproduct_li_pointdrivepresentationvieweds)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_quotebookingproduct`|
|ReferencedAttribute|`msdyn_quotebookingproductid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_quotebookingproduct_li_pointdrivepresentationviewed`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_quotebookingservice_li_pointdrivepresentationvieweds"></a> msdyn_quotebookingservice_li_pointdrivepresentationvieweds

One-To-Many Relationship: [msdyn_quotebookingservice msdyn_quotebookingservice_li_pointdrivepresentationvieweds](msdyn_quotebookingservice.md#BKMK_msdyn_quotebookingservice_li_pointdrivepresentationvieweds)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_quotebookingservice`|
|ReferencedAttribute|`msdyn_quotebookingserviceid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_quotebookingservice_li_pointdrivepresentationviewed`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_quotebookingservicetask_li_pointdrivepresentationvieweds"></a> msdyn_quotebookingservicetask_li_pointdrivepresentationvieweds

One-To-Many Relationship: [msdyn_quotebookingservicetask msdyn_quotebookingservicetask_li_pointdrivepresentationvieweds](msdyn_quotebookingservicetask.md#BKMK_msdyn_quotebookingservicetask_li_pointdrivepresentationvieweds)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_quotebookingservicetask`|
|ReferencedAttribute|`msdyn_quotebookingservicetaskid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_quotebookingservicetask_li_pointdrivepresentationviewed`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_resourceterritory_li_pointdrivepresentationvieweds"></a> msdyn_resourceterritory_li_pointdrivepresentationvieweds

One-To-Many Relationship: [msdyn_resourceterritory msdyn_resourceterritory_li_pointdrivepresentationvieweds](msdyn_resourceterritory.md#BKMK_msdyn_resourceterritory_li_pointdrivepresentationvieweds)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_resourceterritory`|
|ReferencedAttribute|`msdyn_resourceterritoryid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_resourceterritory_li_pointdrivepresentationviewed`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_rma_li_pointdrivepresentationvieweds"></a> msdyn_rma_li_pointdrivepresentationvieweds

One-To-Many Relationship: [msdyn_rma msdyn_rma_li_pointdrivepresentationvieweds](msdyn_rma.md#BKMK_msdyn_rma_li_pointdrivepresentationvieweds)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_rma`|
|ReferencedAttribute|`msdyn_rmaid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_rma_li_pointdrivepresentationviewed`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_rmaproduct_li_pointdrivepresentationvieweds"></a> msdyn_rmaproduct_li_pointdrivepresentationvieweds

One-To-Many Relationship: [msdyn_rmaproduct msdyn_rmaproduct_li_pointdrivepresentationvieweds](msdyn_rmaproduct.md#BKMK_msdyn_rmaproduct_li_pointdrivepresentationvieweds)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_rmaproduct`|
|ReferencedAttribute|`msdyn_rmaproductid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_rmaproduct_li_pointdrivepresentationviewed`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_rmareceipt_li_pointdrivepresentationvieweds"></a> msdyn_rmareceipt_li_pointdrivepresentationvieweds

One-To-Many Relationship: [msdyn_rmareceipt msdyn_rmareceipt_li_pointdrivepresentationvieweds](msdyn_rmareceipt.md#BKMK_msdyn_rmareceipt_li_pointdrivepresentationvieweds)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_rmareceipt`|
|ReferencedAttribute|`msdyn_rmareceiptid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_rmareceipt_li_pointdrivepresentationviewed`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_rmareceiptproduct_li_pointdrivepresentationvieweds"></a> msdyn_rmareceiptproduct_li_pointdrivepresentationvieweds

One-To-Many Relationship: [msdyn_rmareceiptproduct msdyn_rmareceiptproduct_li_pointdrivepresentationvieweds](msdyn_rmareceiptproduct.md#BKMK_msdyn_rmareceiptproduct_li_pointdrivepresentationvieweds)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_rmareceiptproduct`|
|ReferencedAttribute|`msdyn_rmareceiptproductid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_rmareceiptproduct_li_pointdrivepresentationviewed`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_rmasubstatus_li_pointdrivepresentationvieweds"></a> msdyn_rmasubstatus_li_pointdrivepresentationvieweds

One-To-Many Relationship: [msdyn_rmasubstatus msdyn_rmasubstatus_li_pointdrivepresentationvieweds](msdyn_rmasubstatus.md#BKMK_msdyn_rmasubstatus_li_pointdrivepresentationvieweds)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_rmasubstatus`|
|ReferencedAttribute|`msdyn_rmasubstatusid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_rmasubstatus_li_pointdrivepresentationviewed`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_rtv_li_pointdrivepresentationvieweds"></a> msdyn_rtv_li_pointdrivepresentationvieweds

One-To-Many Relationship: [msdyn_rtv msdyn_rtv_li_pointdrivepresentationvieweds](msdyn_rtv.md#BKMK_msdyn_rtv_li_pointdrivepresentationvieweds)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_rtv`|
|ReferencedAttribute|`msdyn_rtvid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_rtv_li_pointdrivepresentationviewed`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_rtvproduct_li_pointdrivepresentationvieweds"></a> msdyn_rtvproduct_li_pointdrivepresentationvieweds

One-To-Many Relationship: [msdyn_rtvproduct msdyn_rtvproduct_li_pointdrivepresentationvieweds](msdyn_rtvproduct.md#BKMK_msdyn_rtvproduct_li_pointdrivepresentationvieweds)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_rtvproduct`|
|ReferencedAttribute|`msdyn_rtvproductid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_rtvproduct_li_pointdrivepresentationviewed`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_rtvsubstatus_li_pointdrivepresentationvieweds"></a> msdyn_rtvsubstatus_li_pointdrivepresentationvieweds

One-To-Many Relationship: [msdyn_rtvsubstatus msdyn_rtvsubstatus_li_pointdrivepresentationvieweds](msdyn_rtvsubstatus.md#BKMK_msdyn_rtvsubstatus_li_pointdrivepresentationvieweds)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_rtvsubstatus`|
|ReferencedAttribute|`msdyn_rtvsubstatusid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_rtvsubstatus_li_pointdrivepresentationviewed`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_salessuggestion_li_pointdrivepresentationvieweds"></a> msdyn_salessuggestion_li_pointdrivepresentationvieweds

One-To-Many Relationship: [msdyn_salessuggestion msdyn_salessuggestion_li_pointdrivepresentationvieweds](msdyn_salessuggestion.md#BKMK_msdyn_salessuggestion_li_pointdrivepresentationvieweds)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_salessuggestion`|
|ReferencedAttribute|`msdyn_salessuggestionid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_salessuggestion_li_pointdrivepresentationviewed`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_shipvia_li_pointdrivepresentationvieweds"></a> msdyn_shipvia_li_pointdrivepresentationvieweds

One-To-Many Relationship: [msdyn_shipvia msdyn_shipvia_li_pointdrivepresentationvieweds](msdyn_shipvia.md#BKMK_msdyn_shipvia_li_pointdrivepresentationvieweds)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_shipvia`|
|ReferencedAttribute|`msdyn_shipviaid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_shipvia_li_pointdrivepresentationviewed`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_swarm_li_pointdrivepresentationvieweds"></a> msdyn_swarm_li_pointdrivepresentationvieweds

One-To-Many Relationship: [msdyn_swarm msdyn_swarm_li_pointdrivepresentationvieweds](msdyn_swarm.md#BKMK_msdyn_swarm_li_pointdrivepresentationvieweds)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_swarm`|
|ReferencedAttribute|`msdyn_swarmid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_swarm_li_pointdrivepresentationviewed`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_systemuserschedulersetting_li_pointdrivepresentationvieweds"></a> msdyn_systemuserschedulersetting_li_pointdrivepresentationvieweds

One-To-Many Relationship: [msdyn_systemuserschedulersetting msdyn_systemuserschedulersetting_li_pointdrivepresentationvieweds](msdyn_systemuserschedulersetting.md#BKMK_msdyn_systemuserschedulersetting_li_pointdrivepresentationvieweds)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_systemuserschedulersetting`|
|ReferencedAttribute|`msdyn_systemuserschedulersettingid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_systemuserschedulersetting_li_pointdrivepresentationviewed`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_timegroup_li_pointdrivepresentationvieweds"></a> msdyn_timegroup_li_pointdrivepresentationvieweds

One-To-Many Relationship: [msdyn_timegroup msdyn_timegroup_li_pointdrivepresentationvieweds](msdyn_timegroup.md#BKMK_msdyn_timegroup_li_pointdrivepresentationvieweds)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_timegroup`|
|ReferencedAttribute|`msdyn_timegroupid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_timegroup_li_pointdrivepresentationviewed`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_timegroupdetail_li_pointdrivepresentationvieweds"></a> msdyn_timegroupdetail_li_pointdrivepresentationvieweds

One-To-Many Relationship: [msdyn_timegroupdetail msdyn_timegroupdetail_li_pointdrivepresentationvieweds](msdyn_timegroupdetail.md#BKMK_msdyn_timegroupdetail_li_pointdrivepresentationvieweds)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_timegroupdetail`|
|ReferencedAttribute|`msdyn_timegroupdetailid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_timegroupdetail_li_pointdrivepresentationviewed`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_timeoffrequest_li_pointdrivepresentationvieweds"></a> msdyn_timeoffrequest_li_pointdrivepresentationvieweds

One-To-Many Relationship: [msdyn_timeoffrequest msdyn_timeoffrequest_li_pointdrivepresentationvieweds](msdyn_timeoffrequest.md#BKMK_msdyn_timeoffrequest_li_pointdrivepresentationvieweds)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_timeoffrequest`|
|ReferencedAttribute|`msdyn_timeoffrequestid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_timeoffrequest_li_pointdrivepresentationviewed`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_warehouse_li_pointdrivepresentationvieweds"></a> msdyn_warehouse_li_pointdrivepresentationvieweds

One-To-Many Relationship: [msdyn_warehouse msdyn_warehouse_li_pointdrivepresentationvieweds](msdyn_warehouse.md#BKMK_msdyn_warehouse_li_pointdrivepresentationvieweds)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_warehouse`|
|ReferencedAttribute|`msdyn_warehouseid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_warehouse_li_pointdrivepresentationviewed`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_workorder_li_pointdrivepresentationvieweds"></a> msdyn_workorder_li_pointdrivepresentationvieweds

One-To-Many Relationship: [msdyn_workorder msdyn_workorder_li_pointdrivepresentationvieweds](msdyn_workorder.md#BKMK_msdyn_workorder_li_pointdrivepresentationvieweds)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_workorder`|
|ReferencedAttribute|`msdyn_workorderid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_workorder_li_pointdrivepresentationviewed`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_workordercharacteristic_li_pointdrivepresentationvieweds"></a> msdyn_workordercharacteristic_li_pointdrivepresentationvieweds

One-To-Many Relationship: [msdyn_workordercharacteristic msdyn_workordercharacteristic_li_pointdrivepresentationvieweds](msdyn_workordercharacteristic.md#BKMK_msdyn_workordercharacteristic_li_pointdrivepresentationvieweds)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_workordercharacteristic`|
|ReferencedAttribute|`msdyn_workordercharacteristicid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_workordercharacteristic_li_pointdrivepresentationviewed`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_workorderincident_li_pointdrivepresentationvieweds"></a> msdyn_workorderincident_li_pointdrivepresentationvieweds

One-To-Many Relationship: [msdyn_workorderincident msdyn_workorderincident_li_pointdrivepresentationvieweds](msdyn_workorderincident.md#BKMK_msdyn_workorderincident_li_pointdrivepresentationvieweds)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_workorderincident`|
|ReferencedAttribute|`msdyn_workorderincidentid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_workorderincident_li_pointdrivepresentationviewed`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_workorderproduct_li_pointdrivepresentationvieweds"></a> msdyn_workorderproduct_li_pointdrivepresentationvieweds

One-To-Many Relationship: [msdyn_workorderproduct msdyn_workorderproduct_li_pointdrivepresentationvieweds](msdyn_workorderproduct.md#BKMK_msdyn_workorderproduct_li_pointdrivepresentationvieweds)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_workorderproduct`|
|ReferencedAttribute|`msdyn_workorderproductid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_workorderproduct_li_pointdrivepresentationviewed`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_workorderresourcerestriction_li_pointdrivepresentationvieweds"></a> msdyn_workorderresourcerestriction_li_pointdrivepresentationvieweds

One-To-Many Relationship: [msdyn_workorderresourcerestriction msdyn_workorderresourcerestriction_li_pointdrivepresentationvieweds](msdyn_workorderresourcerestriction.md#BKMK_msdyn_workorderresourcerestriction_li_pointdrivepresentationvieweds)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_workorderresourcerestriction`|
|ReferencedAttribute|`msdyn_workorderresourcerestrictionid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_workorderresourcerestriction_li_pointdrivepresentationviewed`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_workorderservice_li_pointdrivepresentationvieweds"></a> msdyn_workorderservice_li_pointdrivepresentationvieweds

One-To-Many Relationship: [msdyn_workorderservice msdyn_workorderservice_li_pointdrivepresentationvieweds](msdyn_workorderservice.md#BKMK_msdyn_workorderservice_li_pointdrivepresentationvieweds)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_workorderservice`|
|ReferencedAttribute|`msdyn_workorderserviceid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_workorderservice_li_pointdrivepresentationviewed`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_workorderservicetask_li_pointdrivepresentationvieweds"></a> msdyn_workorderservicetask_li_pointdrivepresentationvieweds

One-To-Many Relationship: [msdyn_workorderservicetask msdyn_workorderservicetask_li_pointdrivepresentationvieweds](msdyn_workorderservicetask.md#BKMK_msdyn_workorderservicetask_li_pointdrivepresentationvieweds)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_workorderservicetask`|
|ReferencedAttribute|`msdyn_workorderservicetaskid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_workorderservicetask_li_pointdrivepresentationviewed`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyncrm_contentsettings_li_pointdrivepresentationvieweds"></a> msdyncrm_contentsettings_li_pointdrivepresentationvieweds

One-To-Many Relationship: [msdyncrm_contentsettings msdyncrm_contentsettings_li_pointdrivepresentationvieweds](msdyncrm_contentsettings.md#BKMK_msdyncrm_contentsettings_li_pointdrivepresentationvieweds)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyncrm_contentsettings`|
|ReferencedAttribute|`msdyncrm_contentsettingsid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyncrm_contentsettings_li_pointdrivepresentationviewed`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyncrm_customerjourney_li_pointdrivepresentationvieweds"></a> msdyncrm_customerjourney_li_pointdrivepresentationvieweds

One-To-Many Relationship: [msdyncrm_customerjourney msdyncrm_customerjourney_li_pointdrivepresentationvieweds](msdyncrm_customerjourney.md#BKMK_msdyncrm_customerjourney_li_pointdrivepresentationvieweds)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyncrm_customerjourney`|
|ReferencedAttribute|`msdyncrm_customerjourneyid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyncrm_customerjourney_li_pointdrivepresentationviewed`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyncrm_leadscoremodel_li_pointdrivepresentationvieweds"></a> msdyncrm_leadscoremodel_li_pointdrivepresentationvieweds

One-To-Many Relationship: [msdyncrm_leadscoremodel msdyncrm_leadscoremodel_li_pointdrivepresentationvieweds](msdyncrm_leadscoremodel.md#BKMK_msdyncrm_leadscoremodel_li_pointdrivepresentationvieweds)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyncrm_leadscoremodel`|
|ReferencedAttribute|`msdyncrm_leadscoremodelid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyncrm_leadscoremodel_li_pointdrivepresentationviewed`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyncrm_linkedinaccount_li_pointdrivepresentationvieweds"></a> msdyncrm_linkedinaccount_li_pointdrivepresentationvieweds

One-To-Many Relationship: [msdyncrm_linkedinaccount msdyncrm_linkedinaccount_li_pointdrivepresentationvieweds](msdyncrm_linkedinaccount.md#BKMK_msdyncrm_linkedinaccount_li_pointdrivepresentationvieweds)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyncrm_linkedinaccount`|
|ReferencedAttribute|`msdyncrm_linkedinaccountid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyncrm_linkedinaccount_li_pointdrivepresentationviewed`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyncrm_linkedinactivity_li_pointdrivepresentationvieweds"></a> msdyncrm_linkedinactivity_li_pointdrivepresentationvieweds

One-To-Many Relationship: [msdyncrm_linkedinactivity msdyncrm_linkedinactivity_li_pointdrivepresentationvieweds](msdyncrm_linkedinactivity.md#BKMK_msdyncrm_linkedinactivity_li_pointdrivepresentationvieweds)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyncrm_linkedinactivity`|
|ReferencedAttribute|`msdyncrm_linkedinactivityid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyncrm_linkedinactivity_li_pointdrivepresentationviewed`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyncrm_linkedinfieldmapping_li_pointdrivepresentationvieweds"></a> msdyncrm_linkedinfieldmapping_li_pointdrivepresentationvieweds

One-To-Many Relationship: [msdyncrm_linkedinfieldmapping msdyncrm_linkedinfieldmapping_li_pointdrivepresentationvieweds](msdyncrm_linkedinfieldmapping.md#BKMK_msdyncrm_linkedinfieldmapping_li_pointdrivepresentationvieweds)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyncrm_linkedinfieldmapping`|
|ReferencedAttribute|`msdyncrm_linkedinfieldmappingid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyncrm_linkedinfieldmapping_li_pointdrivepresentationviewed`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyncrm_linkedinform_li_pointdrivepresentationvieweds"></a> msdyncrm_linkedinform_li_pointdrivepresentationvieweds

One-To-Many Relationship: [msdyncrm_linkedinform msdyncrm_linkedinform_li_pointdrivepresentationvieweds](msdyncrm_linkedinform.md#BKMK_msdyncrm_linkedinform_li_pointdrivepresentationvieweds)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyncrm_linkedinform`|
|ReferencedAttribute|`msdyncrm_linkedinformid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyncrm_linkedinform_li_pointdrivepresentationviewed`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyncrm_linkedinformanswer_li_pointdrivepresentationvieweds"></a> msdyncrm_linkedinformanswer_li_pointdrivepresentationvieweds

One-To-Many Relationship: [msdyncrm_linkedinformanswer msdyncrm_linkedinformanswer_li_pointdrivepresentationvieweds](msdyncrm_linkedinformanswer.md#BKMK_msdyncrm_linkedinformanswer_li_pointdrivepresentationvieweds)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyncrm_linkedinformanswer`|
|ReferencedAttribute|`msdyncrm_linkedinformanswerid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyncrm_linkedinformanswer_li_pointdrivepresentationviewed`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyncrm_linkedinformquestion_li_pointdrivepresentationvieweds"></a> msdyncrm_linkedinformquestion_li_pointdrivepresentationvieweds

One-To-Many Relationship: [msdyncrm_linkedinformquestion msdyncrm_linkedinformquestion_li_pointdrivepresentationvieweds](msdyncrm_linkedinformquestion.md#BKMK_msdyncrm_linkedinformquestion_li_pointdrivepresentationvieweds)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyncrm_linkedinformquestion`|
|ReferencedAttribute|`msdyncrm_linkedinformquestionid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyncrm_linkedinformquestion_li_pointdrivepresentationviewed`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyncrm_linkedinformsubmission_li_pointdrivepresentationvieweds"></a> msdyncrm_linkedinformsubmission_li_pointdrivepresentationvieweds

One-To-Many Relationship: [msdyncrm_linkedinformsubmission msdyncrm_linkedinformsubmission_li_pointdrivepresentationvieweds](msdyncrm_linkedinformsubmission.md#BKMK_msdyncrm_linkedinformsubmission_li_pointdrivepresentationvieweds)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyncrm_linkedinformsubmission`|
|ReferencedAttribute|`msdyncrm_linkedinformsubmissionid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyncrm_linkedinformsubmission_li_pointdrivepresentationviewed`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyncrm_linkedinleadmatchingstrategy_li_pointdrivepresentationvieweds"></a> msdyncrm_linkedinleadmatchingstrategy_li_pointdrivepresentationvieweds

One-To-Many Relationship: [msdyncrm_linkedinleadmatchingstrategy msdyncrm_linkedinleadmatchingstrategy_li_pointdrivepresentationvieweds](msdyncrm_linkedinleadmatchingstrategy.md#BKMK_msdyncrm_linkedinleadmatchingstrategy_li_pointdrivepresentationvieweds)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyncrm_linkedinleadmatchingstrategy`|
|ReferencedAttribute|`msdyncrm_linkedinleadmatchingstrategyid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyncrm_linkedinleadmatchingstrategy_li_pointdrivepresentationviewed`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyncrm_linkedinuserprofile_li_pointdrivepresentationvieweds"></a> msdyncrm_linkedinuserprofile_li_pointdrivepresentationvieweds

One-To-Many Relationship: [msdyncrm_linkedinuserprofile msdyncrm_linkedinuserprofile_li_pointdrivepresentationvieweds](msdyncrm_linkedinuserprofile.md#BKMK_msdyncrm_linkedinuserprofile_li_pointdrivepresentationvieweds)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyncrm_linkedinuserprofile`|
|ReferencedAttribute|`msdyncrm_linkedinuserprofileid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyncrm_linkedinuserprofile_li_pointdrivepresentationviewed`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyncrm_marketingdynamiccontentmetadata_li_pointdrivepresentationvieweds"></a> msdyncrm_marketingdynamiccontentmetadata_li_pointdrivepresentationvieweds

One-To-Many Relationship: [msdyncrm_marketingdynamiccontentmetadata msdyncrm_marketingdynamiccontentmetadata_li_pointdrivepresentationvieweds](msdyncrm_marketingdynamiccontentmetadata.md#BKMK_msdyncrm_marketingdynamiccontentmetadata_li_pointdrivepresentationvieweds)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyncrm_marketingdynamiccontentmetadata`|
|ReferencedAttribute|`msdyncrm_marketingdynamiccontentmetadataid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyncrm_marketingdynamiccontentmetadata_li_pointdrivepresentationviewed`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyncrm_marketingemaildynamiccontentmetadata_li_pointdrivepresentationvieweds"></a> msdyncrm_marketingemaildynamiccontentmetadata_li_pointdrivepresentationvieweds

One-To-Many Relationship: [msdyncrm_marketingemaildynamiccontentmetadata msdyncrm_marketingemaildynamiccontentmetadata_li_pointdrivepresentationvieweds](msdyncrm_marketingemaildynamiccontentmetadata.md#BKMK_msdyncrm_marketingemaildynamiccontentmetadata_li_pointdrivepresentationvieweds)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyncrm_marketingemaildynamiccontentmetadata`|
|ReferencedAttribute|`msdyncrm_marketingemaildynamiccontentmetadataid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyncrm_marketingemaildynamiccontentmetadata_li_pointdrivepresentationviewed`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyncrm_marketingemailtestsend_li_pointdrivepresentationvieweds"></a> msdyncrm_marketingemailtestsend_li_pointdrivepresentationvieweds

One-To-Many Relationship: [msdyncrm_marketingemailtestsend msdyncrm_marketingemailtestsend_li_pointdrivepresentationvieweds](msdyncrm_marketingemailtestsend.md#BKMK_msdyncrm_marketingemailtestsend_li_pointdrivepresentationvieweds)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyncrm_marketingemailtestsend`|
|ReferencedAttribute|`msdyncrm_marketingemailtestsendid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyncrm_marketingemailtestsend_li_pointdrivepresentationviewed`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyncrm_migration_li_pointdrivepresentationvieweds"></a> msdyncrm_migration_li_pointdrivepresentationvieweds

One-To-Many Relationship: [msdyncrm_migration msdyncrm_migration_li_pointdrivepresentationvieweds](msdyncrm_migration.md#BKMK_msdyncrm_migration_li_pointdrivepresentationvieweds)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyncrm_migration`|
|ReferencedAttribute|`msdyncrm_migrationid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyncrm_migration_li_pointdrivepresentationviewed`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyncrm_uicconfig_li_pointdrivepresentationvieweds"></a> msdyncrm_uicconfig_li_pointdrivepresentationvieweds

One-To-Many Relationship: [msdyncrm_uicconfig msdyncrm_uicconfig_li_pointdrivepresentationvieweds](msdyncrm_uicconfig.md#BKMK_msdyncrm_uicconfig_li_pointdrivepresentationvieweds)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyncrm_uicconfig`|
|ReferencedAttribute|`msdyncrm_uicconfigid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyncrm_uicconfig_li_pointdrivepresentationviewed`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msevtmgt_checkin_li_pointdrivepresentationvieweds"></a> msevtmgt_checkin_li_pointdrivepresentationvieweds

One-To-Many Relationship: [msevtmgt_checkin msevtmgt_checkin_li_pointdrivepresentationvieweds](msevtmgt_checkin.md#BKMK_msevtmgt_checkin_li_pointdrivepresentationvieweds)

|Property|Value|
|---|---|
|ReferencedEntity|`msevtmgt_checkin`|
|ReferencedAttribute|`msevtmgt_checkinid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msevtmgt_checkin_li_pointdrivepresentationviewed`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msevtmgt_event_li_pointdrivepresentationvieweds"></a> msevtmgt_event_li_pointdrivepresentationvieweds

One-To-Many Relationship: [msevtmgt_event msevtmgt_event_li_pointdrivepresentationvieweds](msevtmgt_event.md#BKMK_msevtmgt_event_li_pointdrivepresentationvieweds)

|Property|Value|
|---|---|
|ReferencedEntity|`msevtmgt_event`|
|ReferencedAttribute|`msevtmgt_eventid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msevtmgt_event_li_pointdrivepresentationviewed`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msevtmgt_eventpurchase_li_pointdrivepresentationvieweds"></a> msevtmgt_eventpurchase_li_pointdrivepresentationvieweds

One-To-Many Relationship: [msevtmgt_eventpurchase msevtmgt_eventpurchase_li_pointdrivepresentationvieweds](msevtmgt_eventpurchase.md#BKMK_msevtmgt_eventpurchase_li_pointdrivepresentationvieweds)

|Property|Value|
|---|---|
|ReferencedEntity|`msevtmgt_eventpurchase`|
|ReferencedAttribute|`msevtmgt_eventpurchaseid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msevtmgt_eventpurchase_li_pointdrivepresentationviewed`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msevtmgt_eventpurchaseattendee_li_pointdrivepresentationvieweds"></a> msevtmgt_eventpurchaseattendee_li_pointdrivepresentationvieweds

One-To-Many Relationship: [msevtmgt_eventpurchaseattendee msevtmgt_eventpurchaseattendee_li_pointdrivepresentationvieweds](msevtmgt_eventpurchaseattendee.md#BKMK_msevtmgt_eventpurchaseattendee_li_pointdrivepresentationvieweds)

|Property|Value|
|---|---|
|ReferencedEntity|`msevtmgt_eventpurchaseattendee`|
|ReferencedAttribute|`msevtmgt_eventpurchaseattendeeid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msevtmgt_eventpurchaseattendee_li_pointdrivepresentationviewed`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msevtmgt_eventpurchasepass_li_pointdrivepresentationvieweds"></a> msevtmgt_eventpurchasepass_li_pointdrivepresentationvieweds

One-To-Many Relationship: [msevtmgt_eventpurchasepass msevtmgt_eventpurchasepass_li_pointdrivepresentationvieweds](msevtmgt_eventpurchasepass.md#BKMK_msevtmgt_eventpurchasepass_li_pointdrivepresentationvieweds)

|Property|Value|
|---|---|
|ReferencedEntity|`msevtmgt_eventpurchasepass`|
|ReferencedAttribute|`msevtmgt_eventpurchasepassid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msevtmgt_eventpurchasepass_li_pointdrivepresentationviewed`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msevtmgt_eventregistration_li_pointdrivepresentationvieweds"></a> msevtmgt_eventregistration_li_pointdrivepresentationvieweds

One-To-Many Relationship: [msevtmgt_eventregistration msevtmgt_eventregistration_li_pointdrivepresentationvieweds](msevtmgt_eventregistration.md#BKMK_msevtmgt_eventregistration_li_pointdrivepresentationvieweds)

|Property|Value|
|---|---|
|ReferencedEntity|`msevtmgt_eventregistration`|
|ReferencedAttribute|`msevtmgt_eventregistrationid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msevtmgt_eventregistration_li_pointdrivepresentationviewed`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msevtmgt_hotel_li_pointdrivepresentationvieweds"></a> msevtmgt_hotel_li_pointdrivepresentationvieweds

One-To-Many Relationship: [msevtmgt_hotel msevtmgt_hotel_li_pointdrivepresentationvieweds](msevtmgt_hotel.md#BKMK_msevtmgt_hotel_li_pointdrivepresentationvieweds)

|Property|Value|
|---|---|
|ReferencedEntity|`msevtmgt_hotel`|
|ReferencedAttribute|`msevtmgt_hotelid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msevtmgt_hotel_li_pointdrivepresentationviewed`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msevtmgt_hotelroomallocation_li_pointdrivepresentationvieweds"></a> msevtmgt_hotelroomallocation_li_pointdrivepresentationvieweds

One-To-Many Relationship: [msevtmgt_hotelroomallocation msevtmgt_hotelroomallocation_li_pointdrivepresentationvieweds](msevtmgt_hotelroomallocation.md#BKMK_msevtmgt_hotelroomallocation_li_pointdrivepresentationvieweds)

|Property|Value|
|---|---|
|ReferencedEntity|`msevtmgt_hotelroomallocation`|
|ReferencedAttribute|`msevtmgt_hotelroomallocationid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msevtmgt_hotelroomallocation_li_pointdrivepresentationviewed`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msevtmgt_hotelroomreservation_li_pointdrivepresentationvieweds"></a> msevtmgt_hotelroomreservation_li_pointdrivepresentationvieweds

One-To-Many Relationship: [msevtmgt_hotelroomreservation msevtmgt_hotelroomreservation_li_pointdrivepresentationvieweds](msevtmgt_hotelroomreservation.md#BKMK_msevtmgt_hotelroomreservation_li_pointdrivepresentationvieweds)

|Property|Value|
|---|---|
|ReferencedEntity|`msevtmgt_hotelroomreservation`|
|ReferencedAttribute|`msevtmgt_hotelroomreservationid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msevtmgt_hotelroomreservation_li_pointdrivepresentationviewed`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msevtmgt_layout_li_pointdrivepresentationvieweds"></a> msevtmgt_layout_li_pointdrivepresentationvieweds

One-To-Many Relationship: [msevtmgt_layout msevtmgt_layout_li_pointdrivepresentationvieweds](msevtmgt_layout.md#BKMK_msevtmgt_layout_li_pointdrivepresentationvieweds)

|Property|Value|
|---|---|
|ReferencedEntity|`msevtmgt_layout`|
|ReferencedAttribute|`msevtmgt_layoutid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msevtmgt_layout_li_pointdrivepresentationviewed`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msevtmgt_room_li_pointdrivepresentationvieweds"></a> msevtmgt_room_li_pointdrivepresentationvieweds

One-To-Many Relationship: [msevtmgt_room msevtmgt_room_li_pointdrivepresentationvieweds](msevtmgt_room.md#BKMK_msevtmgt_room_li_pointdrivepresentationvieweds)

|Property|Value|
|---|---|
|ReferencedEntity|`msevtmgt_room`|
|ReferencedAttribute|`msevtmgt_roomid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msevtmgt_room_li_pointdrivepresentationviewed`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msevtmgt_session_li_pointdrivepresentationvieweds"></a> msevtmgt_session_li_pointdrivepresentationvieweds

One-To-Many Relationship: [msevtmgt_session msevtmgt_session_li_pointdrivepresentationvieweds](msevtmgt_session.md#BKMK_msevtmgt_session_li_pointdrivepresentationvieweds)

|Property|Value|
|---|---|
|ReferencedEntity|`msevtmgt_session`|
|ReferencedAttribute|`msevtmgt_sessionid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msevtmgt_session_li_pointdrivepresentationviewed`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msevtmgt_sessionregistration_li_pointdrivepresentationvieweds"></a> msevtmgt_sessionregistration_li_pointdrivepresentationvieweds

One-To-Many Relationship: [msevtmgt_sessionregistration msevtmgt_sessionregistration_li_pointdrivepresentationvieweds](msevtmgt_sessionregistration.md#BKMK_msevtmgt_sessionregistration_li_pointdrivepresentationvieweds)

|Property|Value|
|---|---|
|ReferencedEntity|`msevtmgt_sessionregistration`|
|ReferencedAttribute|`msevtmgt_sessionregistrationid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msevtmgt_sessionregistration_li_pointdrivepresentationviewed`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msevtmgt_sessiontrack_li_pointdrivepresentationvieweds"></a> msevtmgt_sessiontrack_li_pointdrivepresentationvieweds

One-To-Many Relationship: [msevtmgt_sessiontrack msevtmgt_sessiontrack_li_pointdrivepresentationvieweds](msevtmgt_sessiontrack.md#BKMK_msevtmgt_sessiontrack_li_pointdrivepresentationvieweds)

|Property|Value|
|---|---|
|ReferencedEntity|`msevtmgt_sessiontrack`|
|ReferencedAttribute|`msevtmgt_sessiontrackid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msevtmgt_sessiontrack_li_pointdrivepresentationviewed`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msevtmgt_speaker_li_pointdrivepresentationvieweds"></a> msevtmgt_speaker_li_pointdrivepresentationvieweds

One-To-Many Relationship: [msevtmgt_speaker msevtmgt_speaker_li_pointdrivepresentationvieweds](msevtmgt_speaker.md#BKMK_msevtmgt_speaker_li_pointdrivepresentationvieweds)

|Property|Value|
|---|---|
|ReferencedEntity|`msevtmgt_speaker`|
|ReferencedAttribute|`msevtmgt_speakerid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msevtmgt_speaker_li_pointdrivepresentationviewed`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msevtmgt_speakerengagement_li_pointdrivepresentationvieweds"></a> msevtmgt_speakerengagement_li_pointdrivepresentationvieweds

One-To-Many Relationship: [msevtmgt_speakerengagement msevtmgt_speakerengagement_li_pointdrivepresentationvieweds](msevtmgt_speakerengagement.md#BKMK_msevtmgt_speakerengagement_li_pointdrivepresentationvieweds)

|Property|Value|
|---|---|
|ReferencedEntity|`msevtmgt_speakerengagement`|
|ReferencedAttribute|`msevtmgt_speakerengagementid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msevtmgt_speakerengagement_li_pointdrivepresentationviewed`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msevtmgt_sponsorablearticle_li_pointdrivepresentationvieweds"></a> msevtmgt_sponsorablearticle_li_pointdrivepresentationvieweds

One-To-Many Relationship: [msevtmgt_sponsorablearticle msevtmgt_sponsorablearticle_li_pointdrivepresentationvieweds](msevtmgt_sponsorablearticle.md#BKMK_msevtmgt_sponsorablearticle_li_pointdrivepresentationvieweds)

|Property|Value|
|---|---|
|ReferencedEntity|`msevtmgt_sponsorablearticle`|
|ReferencedAttribute|`msevtmgt_sponsorablearticleid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msevtmgt_sponsorablearticle_li_pointdrivepresentationviewed`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msevtmgt_sponsorship_li_pointdrivepresentationvieweds"></a> msevtmgt_sponsorship_li_pointdrivepresentationvieweds

One-To-Many Relationship: [msevtmgt_sponsorship msevtmgt_sponsorship_li_pointdrivepresentationvieweds](msevtmgt_sponsorship.md#BKMK_msevtmgt_sponsorship_li_pointdrivepresentationvieweds)

|Property|Value|
|---|---|
|ReferencedEntity|`msevtmgt_sponsorship`|
|ReferencedAttribute|`msevtmgt_sponsorshipid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msevtmgt_sponsorship_li_pointdrivepresentationviewed`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msevtmgt_venue_li_pointdrivepresentationvieweds"></a> msevtmgt_venue_li_pointdrivepresentationvieweds

One-To-Many Relationship: [msevtmgt_venue msevtmgt_venue_li_pointdrivepresentationvieweds](msevtmgt_venue.md#BKMK_msevtmgt_venue_li_pointdrivepresentationvieweds)

|Property|Value|
|---|---|
|ReferencedEntity|`msevtmgt_venue`|
|ReferencedAttribute|`msevtmgt_venueid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msevtmgt_venue_li_pointdrivepresentationviewed`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msevtmgt_webinarconfiguration_li_pointdrivepresentationvieweds"></a> msevtmgt_webinarconfiguration_li_pointdrivepresentationvieweds

One-To-Many Relationship: [msevtmgt_webinarconfiguration msevtmgt_webinarconfiguration_li_pointdrivepresentationvieweds](msevtmgt_webinarconfiguration.md#BKMK_msevtmgt_webinarconfiguration_li_pointdrivepresentationvieweds)

|Property|Value|
|---|---|
|ReferencedEntity|`msevtmgt_webinarconfiguration`|
|ReferencedAttribute|`msevtmgt_webinarconfigurationid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msevtmgt_webinarconfiguration_li_pointdrivepresentationviewed`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msevtmgt_webinarprovider_li_pointdrivepresentationvieweds"></a> msevtmgt_webinarprovider_li_pointdrivepresentationvieweds

One-To-Many Relationship: [msevtmgt_webinarprovider msevtmgt_webinarprovider_li_pointdrivepresentationvieweds](msevtmgt_webinarprovider.md#BKMK_msevtmgt_webinarprovider_li_pointdrivepresentationvieweds)

|Property|Value|
|---|---|
|ReferencedEntity|`msevtmgt_webinarprovider`|
|ReferencedAttribute|`msevtmgt_webinarproviderid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msevtmgt_webinarprovider_li_pointdrivepresentationviewed`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_mspp_adplacement_li_pointdrivepresentationvieweds"></a> mspp_adplacement_li_pointdrivepresentationvieweds

One-To-Many Relationship: [mspp_adplacement mspp_adplacement_li_pointdrivepresentationvieweds](mspp_adplacement.md#BKMK_mspp_adplacement_li_pointdrivepresentationvieweds)

|Property|Value|
|---|---|
|ReferencedEntity|`mspp_adplacement`|
|ReferencedAttribute|`mspp_adplacementid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_mspp_adplacement_li_pointdrivepresentationviewed`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_mspp_pollplacement_li_pointdrivepresentationvieweds"></a> mspp_pollplacement_li_pointdrivepresentationvieweds

One-To-Many Relationship: [mspp_pollplacement mspp_pollplacement_li_pointdrivepresentationvieweds](mspp_pollplacement.md#BKMK_mspp_pollplacement_li_pointdrivepresentationvieweds)

|Property|Value|
|---|---|
|ReferencedEntity|`mspp_pollplacement`|
|ReferencedAttribute|`mspp_pollplacementid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_mspp_pollplacement_li_pointdrivepresentationviewed`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_mspp_publishingstatetransitionrule_li_pointdrivepresentationvieweds"></a> mspp_publishingstatetransitionrule_li_pointdrivepresentationvieweds

One-To-Many Relationship: [mspp_publishingstatetransitionrule mspp_publishingstatetransitionrule_li_pointdrivepresentationvieweds](mspp_publishingstatetransitionrule.md#BKMK_mspp_publishingstatetransitionrule_li_pointdrivepresentationvieweds)

|Property|Value|
|---|---|
|ReferencedEntity|`mspp_publishingstatetransitionrule`|
|ReferencedAttribute|`mspp_publishingstatetransitionruleid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_mspp_publishingstatetransitionrule_li_pointdrivepresentationviewed`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_mspp_redirect_li_pointdrivepresentationvieweds"></a> mspp_redirect_li_pointdrivepresentationvieweds

One-To-Many Relationship: [mspp_redirect mspp_redirect_li_pointdrivepresentationvieweds](mspp_redirect.md#BKMK_mspp_redirect_li_pointdrivepresentationvieweds)

|Property|Value|
|---|---|
|ReferencedEntity|`mspp_redirect`|
|ReferencedAttribute|`mspp_redirectid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_mspp_redirect_li_pointdrivepresentationviewed`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_mspp_shortcut_li_pointdrivepresentationvieweds"></a> mspp_shortcut_li_pointdrivepresentationvieweds

One-To-Many Relationship: [mspp_shortcut mspp_shortcut_li_pointdrivepresentationvieweds](mspp_shortcut.md#BKMK_mspp_shortcut_li_pointdrivepresentationvieweds)

|Property|Value|
|---|---|
|ReferencedEntity|`mspp_shortcut`|
|ReferencedAttribute|`mspp_shortcutid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_mspp_shortcut_li_pointdrivepresentationviewed`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_mspp_website_li_pointdrivepresentationvieweds"></a> mspp_website_li_pointdrivepresentationvieweds

One-To-Many Relationship: [mspp_website mspp_website_li_pointdrivepresentationvieweds](mspp_website.md#BKMK_mspp_website_li_pointdrivepresentationvieweds)

|Property|Value|
|---|---|
|ReferencedEntity|`mspp_website`|
|ReferencedAttribute|`mspp_websiteid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_mspp_website_li_pointdrivepresentationviewed`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_opportunity_li_pointdrivepresentationvieweds"></a> opportunity_li_pointdrivepresentationvieweds

One-To-Many Relationship: [opportunity opportunity_li_pointdrivepresentationvieweds](opportunity.md#BKMK_opportunity_li_pointdrivepresentationvieweds)

|Property|Value|
|---|---|
|ReferencedEntity|`opportunity`|
|ReferencedAttribute|`opportunityid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_opportunity_li_pointdrivepresentationviewed`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_quote_li_pointdrivepresentationvieweds"></a> quote_li_pointdrivepresentationvieweds

One-To-Many Relationship: [quote quote_li_pointdrivepresentationvieweds](quote.md#BKMK_quote_li_pointdrivepresentationvieweds)

|Property|Value|
|---|---|
|ReferencedEntity|`quote`|
|ReferencedAttribute|`quoteid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_quote_li_pointdrivepresentationviewed`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_salesorder_li_pointdrivepresentationvieweds"></a> salesorder_li_pointdrivepresentationvieweds

One-To-Many Relationship: [salesorder salesorder_li_pointdrivepresentationvieweds](salesorder.md#BKMK_salesorder_li_pointdrivepresentationvieweds)

|Property|Value|
|---|---|
|ReferencedEntity|`salesorder`|
|ReferencedAttribute|`salesorderid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_salesorder_li_pointdrivepresentationviewed`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_site_li_pointdrivepresentationvieweds"></a> site_li_pointdrivepresentationvieweds

One-To-Many Relationship: [site site_li_pointdrivepresentationvieweds](site.md#BKMK_site_li_pointdrivepresentationvieweds)

|Property|Value|
|---|---|
|ReferencedEntity|`site`|
|ReferencedAttribute|`siteid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_site_li_pointdrivepresentationviewed`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|


## One-to-Many relationships

These relationships are one-to-many. Listed by **SchemaName**.

- [CampaignResponse_li_pointdrivepresentationvieweds](#BKMK_CampaignResponse_li_pointdrivepresentationvieweds)
- [li_pointdrivepresentationviewed_ActionCards](#BKMK_li_pointdrivepresentationviewed_ActionCards)
- [li_pointdrivepresentationviewed_activity_parties](#BKMK_li_pointdrivepresentationviewed_activity_parties)
- [li_pointdrivepresentationviewed_Annotations](#BKMK_li_pointdrivepresentationviewed_Annotations)
- [li_pointdrivepresentationviewed_AsyncOperations](#BKMK_li_pointdrivepresentationviewed_AsyncOperations)
- [li_pointdrivepresentationviewed_BulkDeleteFailures](#BKMK_li_pointdrivepresentationviewed_BulkDeleteFailures)
- [li_pointdrivepresentationviewed_connections1](#BKMK_li_pointdrivepresentationviewed_connections1)
- [li_pointdrivepresentationviewed_connections2](#BKMK_li_pointdrivepresentationviewed_connections2)
- [li_pointdrivepresentationviewed_MailboxTrackingFolders](#BKMK_li_pointdrivepresentationviewed_MailboxTrackingFolders)
- [li_pointdrivepresentationviewed_PrincipalObjectAttributeAccesses](#BKMK_li_pointdrivepresentationviewed_PrincipalObjectAttributeAccesses)
- [li_pointdrivepresentationviewed_ProcessSession](#BKMK_li_pointdrivepresentationviewed_ProcessSession)
- [li_pointdrivepresentationviewed_QueueItems](#BKMK_li_pointdrivepresentationviewed_QueueItems)
- [li_pointdrivepresentationviewed_SyncErrors](#BKMK_li_pointdrivepresentationviewed_SyncErrors)

### <a name="BKMK_CampaignResponse_li_pointdrivepresentationvieweds"></a> CampaignResponse_li_pointdrivepresentationvieweds

Many-To-One Relationship: [campaignresponse CampaignResponse_li_pointdrivepresentationvieweds](campaignresponse.md#BKMK_CampaignResponse_li_pointdrivepresentationvieweds)

|Property|Value|
|---|---|
|ReferencingEntity|`campaignresponse`|
|ReferencingAttribute|`originatingactivityid`|
|ReferencedEntityNavigationPropertyName|`CampaignResponse_li_pointdrivepresentationvieweds`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_li_pointdrivepresentationviewed_ActionCards"></a> li_pointdrivepresentationviewed_ActionCards

Many-To-One Relationship: [actioncard li_pointdrivepresentationviewed_ActionCards](actioncard.md#BKMK_li_pointdrivepresentationviewed_ActionCards)

|Property|Value|
|---|---|
|ReferencingEntity|`actioncard`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`li_pointdrivepresentationviewed_ActionCards`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_li_pointdrivepresentationviewed_activity_parties"></a> li_pointdrivepresentationviewed_activity_parties

Many-To-One Relationship: [activityparty li_pointdrivepresentationviewed_activity_parties](activityparty.md#BKMK_li_pointdrivepresentationviewed_activity_parties)

|Property|Value|
|---|---|
|ReferencingEntity|`activityparty`|
|ReferencingAttribute|`activityid`|
|ReferencedEntityNavigationPropertyName|`li_pointdrivepresentationviewed_activity_parties`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_li_pointdrivepresentationviewed_Annotations"></a> li_pointdrivepresentationviewed_Annotations

Many-To-One Relationship: [annotation li_pointdrivepresentationviewed_Annotations](annotation.md#BKMK_li_pointdrivepresentationviewed_Annotations)

|Property|Value|
|---|---|
|ReferencingEntity|`annotation`|
|ReferencingAttribute|`objectid`|
|ReferencedEntityNavigationPropertyName|`li_pointdrivepresentationviewed_Annotations`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_li_pointdrivepresentationviewed_AsyncOperations"></a> li_pointdrivepresentationviewed_AsyncOperations

Many-To-One Relationship: [asyncoperation li_pointdrivepresentationviewed_AsyncOperations](asyncoperation.md#BKMK_li_pointdrivepresentationviewed_AsyncOperations)

|Property|Value|
|---|---|
|ReferencingEntity|`asyncoperation`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`li_pointdrivepresentationviewed_AsyncOperations`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_li_pointdrivepresentationviewed_BulkDeleteFailures"></a> li_pointdrivepresentationviewed_BulkDeleteFailures

Many-To-One Relationship: [bulkdeletefailure li_pointdrivepresentationviewed_BulkDeleteFailures](bulkdeletefailure.md#BKMK_li_pointdrivepresentationviewed_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencingEntity|`bulkdeletefailure`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`li_pointdrivepresentationviewed_BulkDeleteFailures`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_li_pointdrivepresentationviewed_connections1"></a> li_pointdrivepresentationviewed_connections1

Many-To-One Relationship: [connection li_pointdrivepresentationviewed_connections1](connection.md#BKMK_li_pointdrivepresentationviewed_connections1)

|Property|Value|
|---|---|
|ReferencingEntity|`connection`|
|ReferencingAttribute|`record1id`|
|ReferencedEntityNavigationPropertyName|`li_pointdrivepresentationviewed_connections1`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 100<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_li_pointdrivepresentationviewed_connections2"></a> li_pointdrivepresentationviewed_connections2

Many-To-One Relationship: [connection li_pointdrivepresentationviewed_connections2](connection.md#BKMK_li_pointdrivepresentationviewed_connections2)

|Property|Value|
|---|---|
|ReferencingEntity|`connection`|
|ReferencingAttribute|`record2id`|
|ReferencedEntityNavigationPropertyName|`li_pointdrivepresentationviewed_connections2`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_li_pointdrivepresentationviewed_MailboxTrackingFolders"></a> li_pointdrivepresentationviewed_MailboxTrackingFolders

Many-To-One Relationship: [mailboxtrackingfolder li_pointdrivepresentationviewed_MailboxTrackingFolders](mailboxtrackingfolder.md#BKMK_li_pointdrivepresentationviewed_MailboxTrackingFolders)

|Property|Value|
|---|---|
|ReferencingEntity|`mailboxtrackingfolder`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`li_pointdrivepresentationviewed_MailboxTrackingFolders`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_li_pointdrivepresentationviewed_PrincipalObjectAttributeAccesses"></a> li_pointdrivepresentationviewed_PrincipalObjectAttributeAccesses

Many-To-One Relationship: [principalobjectattributeaccess li_pointdrivepresentationviewed_PrincipalObjectAttributeAccesses](principalobjectattributeaccess.md#BKMK_li_pointdrivepresentationviewed_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencingEntity|`principalobjectattributeaccess`|
|ReferencingAttribute|`objectid`|
|ReferencedEntityNavigationPropertyName|`li_pointdrivepresentationviewed_PrincipalObjectAttributeAccesses`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_li_pointdrivepresentationviewed_ProcessSession"></a> li_pointdrivepresentationviewed_ProcessSession

Many-To-One Relationship: [processsession li_pointdrivepresentationviewed_ProcessSession](processsession.md#BKMK_li_pointdrivepresentationviewed_ProcessSession)

|Property|Value|
|---|---|
|ReferencingEntity|`processsession`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`li_pointdrivepresentationviewed_ProcessSession`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_li_pointdrivepresentationviewed_QueueItems"></a> li_pointdrivepresentationviewed_QueueItems

Many-To-One Relationship: [queueitem li_pointdrivepresentationviewed_QueueItems](queueitem.md#BKMK_li_pointdrivepresentationviewed_QueueItems)

|Property|Value|
|---|---|
|ReferencingEntity|`queueitem`|
|ReferencingAttribute|`objectid`|
|ReferencedEntityNavigationPropertyName|`li_pointdrivepresentationviewed_QueueItems`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_li_pointdrivepresentationviewed_SyncErrors"></a> li_pointdrivepresentationviewed_SyncErrors

Many-To-One Relationship: [syncerror li_pointdrivepresentationviewed_SyncErrors](syncerror.md#BKMK_li_pointdrivepresentationviewed_SyncErrors)

|Property|Value|
|---|---|
|ReferencingEntity|`syncerror`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`li_pointdrivepresentationviewed_SyncErrors`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|



### See also

[Dataverse table/entity reference](../about-entity-reference.md)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   

