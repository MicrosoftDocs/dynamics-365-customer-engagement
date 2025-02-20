---
title: "Campaign Response (CampaignResponse) table/entity reference (Microsoft Dynamics 365)"
description: "Includes schema information and supported messages for the Campaign Response (CampaignResponse) table/entity with Microsoft Dynamics 365."
ms.topic: generated-reference
author: JimDaly
ms.author: jdaly
search.audienceType: 
  - developer
---

# Campaign Response (CampaignResponse) table/entity reference (Microsoft Dynamics 365)

Response from an existing or a potential new customer for a campaign.

## Messages

The following table lists the messages for the Campaign Response (CampaignResponse) table.
Messages represent operations that can be performed on the table. They may also be events.

| Name <br />Is Event? |Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `Assign`<br />Event: True |`PATCH` /campaignresponses(*activityid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `ownerid` property. |<xref:Microsoft.Crm.Sdk.Messages.AssignRequest>|
| `Associate`<br />Event: True |[Associate records](/power-apps/developer/data-platform/webapi/associate-disassociate-entities-using-web-api) |[Associate records](/power-apps/developer/data-platform/org-service/entity-operations-associate-disassociate#use-the-associate-method-or-associaterequest)|
| `CopyCampaignResponse`<br />Event: False |**CopyCampaignResponse action** |<xref:Microsoft.Crm.Sdk.Messages.CopyCampaignResponseRequest>|
| `Create`<br />Event: True |`POST` /campaignresponses<br />See [Create](/powerapps/developer/data-platform/webapi/create-entity-web-api) |[Create records](/power-apps/developer/data-platform/org-service/entity-operations-create#basic-create)|
| `CreateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.CreateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.CreateMultipleRequest>|
| `Delete`<br />Event: True |`DELETE` /campaignresponses(*activityid*)<br />See [Delete](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-delete) |[Delete records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-delete)|
| `Disassociate`<br />Event: True |[Disassociate records](/power-apps/developer/data-platform/webapi/associate-disassociate-entities-using-web-api) |[Disassociate records](/power-apps/developer/data-platform/org-service/entity-operations-associate-disassociate#use-the-disassociate-method-or-disassociaterequest)|
| `GrantAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.GrantAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.GrantAccessRequest>|
| `ModifyAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.ModifyAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.ModifyAccessRequest>|
| `Retrieve`<br />Event: True |`GET` /campaignresponses(*activityid*)<br />See [Retrieve](/powerapps/developer/data-platform/webapi/retrieve-entity-using-web-api) |[Retrieve records](/power-apps/developer/data-platform/org-service/entity-operations-retrieve)|
| `RetrieveMultiple`<br />Event: True |`GET` /campaignresponses<br />See [Query data](/power-apps/developer/data-platform/webapi/query-data-web-api) |[Query data](/power-apps/developer/data-platform/org-service/entity-operations-query-data)|
| `RetrievePrincipalAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RetrievePrincipalAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RetrievePrincipalAccessRequest>|
| `RetrieveSharedPrincipalsAndAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RetrieveSharedPrincipalsAndAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RetrieveSharedPrincipalsAndAccessRequest>|
| `RevokeAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RevokeAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RevokeAccessRequest>|
| `SetState`<br />Event: True |`PATCH` /campaignresponses(*activityid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `statecode` and `statuscode` properties. |<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|
| `Update`<br />Event: True |`PATCH` /campaignresponses(*activityid*)<br />See [Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) |[Update records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-update)|
| `UpdateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.UpdateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpdateMultipleRequest>|
| `Upsert`<br />Event: False |`PATCH` /campaignresponses(*activityid*)<br />See [Upsert a table row](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#upsert-a-table-row) |<xref:Microsoft.Xrm.Sdk.Messages.UpsertRequest>|
| `UpsertMultiple`<br />Event: False |<xref:Microsoft.Dynamics.CRM.UpsertMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpsertMultipleRequest>|

## Properties

The following table lists selected properties for the Campaign Response (CampaignResponse) table.

|Property|Value|
| --- | --- |
| **DisplayName** | **Campaign Response** |
| **DisplayCollectionName** | **Campaign Responses** |
| **SchemaName** | `CampaignResponse` |
| **CollectionSchemaName** | `CampaignResponses` |
| **EntitySetName** | `campaignresponses`|
| **LogicalName** | `campaignresponse` |
| **LogicalCollectionName** | `campaignresponses` |
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
- [ChannelTypeCode](#BKMK_ChannelTypeCode)
- [Community](#BKMK_Community)
- [CompanyName](#BKMK_CompanyName)
- [Customer](#BKMK_Customer)
- [Customers](#BKMK_Customers)
- [DeliveryPriorityCode](#BKMK_DeliveryPriorityCode)
- [Description](#BKMK_Description)
- [EMailAddress](#BKMK_EMailAddress)
- [ExchangeItemId](#BKMK_ExchangeItemId)
- [ExchangeWebLink](#BKMK_ExchangeWebLink)
- [Fax](#BKMK_Fax)
- [FirstName](#BKMK_FirstName)
- [from](#BKMK_from)
- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [IsBilled](#BKMK_IsBilled)
- [IsMapiPrivate](#BKMK_IsMapiPrivate)
- [IsWorkflowCreated](#BKMK_IsWorkflowCreated)
- [LastName](#BKMK_LastName)
- [LastOnHoldTime](#BKMK_LastOnHoldTime)
- [LeftVoiceMail](#BKMK_LeftVoiceMail)
- [OptionalAttendees](#BKMK_OptionalAttendees)
- [Organizer](#BKMK_Organizer)
- [OriginatingActivityId](#BKMK_OriginatingActivityId)
- [OriginatingActivityIdTypeCode](#BKMK_OriginatingActivityIdTypeCode)
- [OverriddenCreatedOn](#BKMK_OverriddenCreatedOn)
- [OwnerId](#BKMK_OwnerId)
- [OwnerIdType](#BKMK_OwnerIdType)
- [Partner](#BKMK_Partner)
- [Partners](#BKMK_Partners)
- [PriorityCode](#BKMK_PriorityCode)
- [ProcessId](#BKMK_ProcessId)
- [PromotionCodeName](#BKMK_PromotionCodeName)
- [ReceivedOn](#BKMK_ReceivedOn)
- [RegardingObjectId](#BKMK_RegardingObjectId)
- [RegardingObjectTypeCode](#BKMK_RegardingObjectTypeCode)
- [RequiredAttendees](#BKMK_RequiredAttendees)
- [Resources](#BKMK_Resources)
- [ResponseCode](#BKMK_ResponseCode)
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
- [Telephone](#BKMK_Telephone)
- [TimeZoneRuleVersionNumber](#BKMK_TimeZoneRuleVersionNumber)
- [To](#BKMK_To)
- [TransactionCurrencyId](#BKMK_TransactionCurrencyId)
- [TraversedPath](#BKMK_TraversedPath)
- [UTCConversionTimeZoneCode](#BKMK_UTCConversionTimeZoneCode)
- [YomiCompanyName](#BKMK_YomiCompanyName)
- [YomiFirstName](#BKMK_YomiFirstName)
- [YomiLastName](#BKMK_YomiLastName)

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
|Description|**Unique identifier of the campaign response.**|
|DisplayName|**Campaign Response**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`activityid`|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|

### <a name="BKMK_ActualDurationMinutes"></a> ActualDurationMinutes

|Property|Value|
|---|---|
|Description|**Type the number of minutes spent on this activity. The duration is used in reporting.**|
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
|Description|**Enter the date when the campaign response was actually completed.**|
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
|Description|**Enter the actual start date and time for the campaign response.**|
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

### <a name="BKMK_Category"></a> Category

|Property|Value|
|---|---|
|Description|**Type a category to identify the campaign response type, such as new business development or customer retention, to tie the campaign response to a business group or function.**|
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
|Description|**Select how the response was received, such as phone, letter, fax, or email.**|
|DisplayName|**Channel**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`channeltypecode`|
|RequiredLevel|None|
|Type|Picklist|
|DefaultFormValue|-1|
|GlobalChoiceName|`campaignresponse_channeltypecode`|

#### ChannelTypeCode Choices/Options

|Value|Label|
|---|---|
|1|**Email**|
|2|**Phone**|
|3|**Fax**|
|4|**Letter**|
|5|**Appointment**|
|6|**Others**|

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

### <a name="BKMK_CompanyName"></a> CompanyName

|Property|Value|
|---|---|
|Description|**Type the name of the company if the campaign response was received from a new prospect or customer.**|
|DisplayName|**Company Name**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`companyname`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Active|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_Customer"></a> Customer

|Property|Value|
|---|---|
|Description|**Enter the account, contact, or lead that submitted the campaign response, if it was received from an existing prospect or customer.**|
|DisplayName|**Customer**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`customer`|
|RequiredLevel|None|
|Type|PartyList|
|Targets|account, contact, lead|

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
|Description|**Type additional information to describe the campaign response, such as key discussion points or objectives.**|
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

### <a name="BKMK_EMailAddress"></a> EMailAddress

|Property|Value|
|---|---|
|Description|**Type the responder's email address.**|
|DisplayName|**Email**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`emailaddress`|
|RequiredLevel|None|
|Type|String|
|Format|Email|
|FormatName|Email|
|ImeMode|Inactive|
|IsLocalizable|False|
|MaxLength|100|

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

### <a name="BKMK_Fax"></a> Fax

|Property|Value|
|---|---|
|Description|**Type the responder's fax number.**|
|DisplayName|**Fax**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`fax`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Inactive|
|IsLocalizable|False|
|MaxLength|50|

### <a name="BKMK_FirstName"></a> FirstName

|Property|Value|
|---|---|
|Description|**Type the responder's first name if the campaign response was received from a new prospect or customer.**|
|DisplayName|**First Name**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`firstname`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Active|
|IsLocalizable|False|
|MaxLength|50|

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
|Description|**Specifies whether the campaign response was billed as part of resolving a case.**|
|DisplayName|**Is Billed**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`isbilled`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`campaignresponse_isbilled`|
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
|GlobalChoiceName|`_campaignresponse_ismapiprivate`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_IsWorkflowCreated"></a> IsWorkflowCreated

|Property|Value|
|---|---|
|Description|**Specifies whether the campaign response is created by a workflow rule.**|
|DisplayName|**Is Workflow Created**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`isworkflowcreated`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`campaignresponse_isworkflowcreated`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_LastName"></a> LastName

|Property|Value|
|---|---|
|Description|**Type the responder's last name if the campaign response was received from a new prospect or customer.**|
|DisplayName|**Last Name**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`lastname`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Active|
|IsLocalizable|False|
|MaxLength|50|

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
|GlobalChoiceName|`_campaignresponse_leftvoicemail`|
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

### <a name="BKMK_OriginatingActivityId"></a> OriginatingActivityId

|Property|Value|
|---|---|
|Description|**Choose the phone call, email, fax, letter, or appointment activity that led the prospect or customer to respond to the campaign.**|
|DisplayName|**Originating Activity**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`originatingactivityid`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|appointment, email, fax, letter, phonecall|

### <a name="BKMK_OriginatingActivityIdTypeCode"></a> OriginatingActivityIdTypeCode

|Property|Value|
|---|---|
|Description||
|DisplayName||
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`originatingactivityidtypecode`|
|RequiredLevel|None|
|Type|EntityName|

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

### <a name="BKMK_Partner"></a> Partner

|Property|Value|
|---|---|
|Description|**Enter the vendor account or contact to capture any third-party used to obtain the campaign response.**|
|DisplayName|**Outsource Vendor**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`partner`|
|RequiredLevel|None|
|Type|PartyList|
|Targets|account, contact|

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
|GlobalChoiceName|`campaignresponse_prioritycode`|

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

### <a name="BKMK_PromotionCodeName"></a> PromotionCodeName

|Property|Value|
|---|---|
|Description|**Type a promotional code to track sales related to the campaign response or to allow the responder to redeem a discount offer.**|
|DisplayName|**Promotion Code**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`promotioncodename`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|250|

### <a name="BKMK_ReceivedOn"></a> ReceivedOn

|Property|Value|
|---|---|
|Description|**Enter the date when the campaign response was received.**|
|DisplayName|**Received On**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`receivedon`|
|RequiredLevel|None|
|Type|DateTime|
|CanChangeDateTimeBehavior|False|
|DateTimeBehavior|UserLocal|
|Format|DateOnly|
|ImeMode|Inactive|
|SourceTypeMask|0|

### <a name="BKMK_RegardingObjectId"></a> RegardingObjectId

|Property|Value|
|---|---|
|Description|**Choose the parent campaign so that the campaign's response rate is tracked correctly.**|
|DisplayName|**Parent Campaign**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`regardingobjectid`|
|RequiredLevel|ApplicationRequired|
|Type|Lookup|
|Targets|bulkoperation, campaign|

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

### <a name="BKMK_ResponseCode"></a> ResponseCode

|Property|Value|
|---|---|
|Description|**Select the type of response from the prospect or customer to indicate their interest in the campaign.**|
|DisplayName|**Response Code**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`responsecode`|
|RequiredLevel|None|
|Type|Picklist|
|DefaultFormValue|1|
|GlobalChoiceName|`campaignresponse_responsecode`|

#### ResponseCode Choices/Options

|Value|Label|
|---|---|
|1|**Interested**|
|2|**Not Interested**|
|3|**Do Not Send Marketing Materials**|
|4|**Error**|

### <a name="BKMK_ScheduledEnd"></a> ScheduledEnd

|Property|Value|
|---|---|
|Description|**Enter the expected due date and time for the activity to be completed to provide details about the timing of the campaign response.**|
|DisplayName|**Close By**|
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
|Description|**Enter the expected start date and time for the activity to provide details about the timing of the campaign response.**|
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
|Description|**Unique identifier for the associated service.**|
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
|Description|**Shows whether the campaign response is open, closed, or canceled. Closed and canceled campaign responses are read-only and can't be edited.**|
|DisplayName|**Status**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statecode`|
|RequiredLevel|SystemRequired|
|Type|State|
|DefaultFormValue|0|
|GlobalChoiceName|`campaignresponse_statecode`|

#### StateCode Choices/Options

|Value|Details|
|---|---|
|0|Label: **Open**<br />DefaultStatus: 1<br />InvariantName: `Open`|
|1|Label: **Closed**<br />DefaultStatus: 2<br />InvariantName: `Closed`|
|2|Label: **Canceled**<br />DefaultStatus: 3<br />InvariantName: `Canceled`|

### <a name="BKMK_StatusCode"></a> StatusCode

|Property|Value|
|---|---|
|Description|**Select the campaign response's status.**|
|DisplayName|**Status Reason**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statuscode`|
|RequiredLevel|None|
|Type|Status|
|DefaultFormValue|-1|
|GlobalChoiceName|`campaignresponse_statuscode`|

#### StatusCode Choices/Options

|Value|Details|
|---|---|
|1|Label: **Open**<br />State:0<br />TransitionData: None|
|2|Label: **Closed**<br />State:1<br />TransitionData: None|
|3|Label: **Canceled**<br />State:2<br />TransitionData: None|

### <a name="BKMK_Subcategory"></a> Subcategory

|Property|Value|
|---|---|
|Description|**Type a subcategory to identify the campaign response type and relate the activity to a specific product, sales region, business group, or other function.**|
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
|Description|**Type a short description about the objective or primary topic of the campaign response.**|
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

### <a name="BKMK_Telephone"></a> Telephone

|Property|Value|
|---|---|
|Description|**Type the responder's primary phone number.**|
|DisplayName|**Phone**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`telephone`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Inactive|
|IsLocalizable|False|
|MaxLength|50|

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

### <a name="BKMK_YomiCompanyName"></a> YomiCompanyName

|Property|Value|
|---|---|
|Description|**Type the phonetic spelling of the company name, if specified in Japanese, to make sure the name is pronounced correctly in phone calls and other communications.**|
|DisplayName|**Yomi Company Name**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`yomicompanyname`|
|RequiredLevel|None|
|Type|String|
|Format|PhoneticGuide|
|FormatName|PhoneticGuide|
|ImeMode|Active|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_YomiFirstName"></a> YomiFirstName

|Property|Value|
|---|---|
|Description|**Type the phonetic spelling of the campaign responder's first name, if specified in Japanese, to make sure the name is pronounced correctly in phone calls and other communications.**|
|DisplayName|**Yomi First Name**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`yomifirstname`|
|RequiredLevel|None|
|Type|String|
|Format|PhoneticGuide|
|FormatName|PhoneticGuide|
|ImeMode|Active|
|IsLocalizable|False|
|MaxLength|150|

### <a name="BKMK_YomiLastName"></a> YomiLastName

|Property|Value|
|---|---|
|Description|**Type the phonetic spelling of the campaign responder's last name, if specified in Japanese, to make sure the name is pronounced correctly in phone calls and other communications.**|
|DisplayName|**Yomi Last Name**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`yomilastname`|
|RequiredLevel|None|
|Type|String|
|Format|PhoneticGuide|
|FormatName|PhoneticGuide|
|ImeMode|Active|
|IsLocalizable|False|
|MaxLength|150|


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
- [ScheduledDurationMinutes](#BKMK_ScheduledDurationMinutes)
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
|GlobalChoiceName|`_campaignresponse_instancetypecode`|

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
|Description|**Scheduled duration of the campaign response in minutes.**|
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

- [account_CampaignResponses](#BKMK_account_CampaignResponses)
- [activity_campaignresponse](#BKMK_activity_campaignresponse)
- [activity_pointer_campaignresponse](#BKMK_activity_pointer_campaignresponse)
- [adx_invitation_CampaignResponses](#BKMK_adx_invitation_CampaignResponses)
- [appointment_campaignresponse](#BKMK_appointment_campaignresponse)
- [bookableresourcebooking_CampaignResponses](#BKMK_bookableresourcebooking_CampaignResponses)
- [bookableresourcebookingheader_CampaignResponses](#BKMK_bookableresourcebookingheader_CampaignResponses)
- [BulkOperation_CampaignResponse](#BKMK_BulkOperation_CampaignResponse)
- [business_unit_campaignresponse_activities](#BKMK_business_unit_campaignresponse_activities)
- [Campaign_CampaignResponses](#BKMK_Campaign_CampaignResponses)
- [campaignactivity_CampaignResponses](#BKMK_campaignactivity_CampaignResponses)
- [CampaignResponse_adx_inviteredemptions](#BKMK_CampaignResponse_adx_inviteredemptions)
- [CampaignResponse_adx_portalcomments](#BKMK_CampaignResponse_adx_portalcomments)
- [CampaignResponse_IncidentResolutions](#BKMK_CampaignResponse_IncidentResolutions)
- [campaignresponse_mailbox_sendermailboxid](#BKMK_campaignresponse_mailbox_sendermailboxid)
- [CampaignResponse_msdyn_copilottranscripts](#BKMK_CampaignResponse_msdyn_copilottranscripts)
- [CampaignResponse_msdyn_ocliveworkitems](#BKMK_CampaignResponse_msdyn_ocliveworkitems)
- [CampaignResponse_msdyn_ocsessions](#BKMK_CampaignResponse_msdyn_ocsessions)
- [CampaignResponse_msfp_alerts](#BKMK_CampaignResponse_msfp_alerts)
- [CampaignResponse_msfp_surveyinvites](#BKMK_CampaignResponse_msfp_surveyinvites)
- [CampaignResponse_msfp_surveyresponses](#BKMK_CampaignResponse_msfp_surveyresponses)
- [CampaignResponse_OpportunityCloses](#BKMK_CampaignResponse_OpportunityCloses)
- [CampaignResponse_OrderCloses](#BKMK_CampaignResponse_OrderCloses)
- [campaignresponse_owner_ownerid](#BKMK_campaignresponse_owner_ownerid)
- [CampaignResponse_QuoteCloses](#BKMK_CampaignResponse_QuoteCloses)
- [CampaignResponse_ServiceAppointments](#BKMK_CampaignResponse_ServiceAppointments)
- [campaignresponse_sla_slaid](#BKMK_campaignresponse_sla_slaid)
- [campaignresponse_sla_slainvokedid](#BKMK_campaignresponse_sla_slainvokedid)
- [contact_CampaignResponses](#BKMK_contact_CampaignResponses)
- [email_campaignresponse](#BKMK_email_campaignresponse)
- [fax_campaignresponse](#BKMK_fax_campaignresponse)
- [interactionforemail_CampaignResponses](#BKMK_interactionforemail_CampaignResponses)
- [knowledgearticle_CampaignResponses](#BKMK_knowledgearticle_CampaignResponses)
- [knowledgebaserecord_CampaignResponses](#BKMK_knowledgebaserecord_CampaignResponses)
- [lead_CampaignResponses](#BKMK_lead_CampaignResponses)
- [letter_campaignresponse](#BKMK_letter_campaignresponse)
- [lk_campaignresponse_createdby](#BKMK_lk_campaignresponse_createdby)
- [lk_campaignresponse_createdonbehalfby](#BKMK_lk_campaignresponse_createdonbehalfby)
- [lk_campaignresponse_modifiedby](#BKMK_lk_campaignresponse_modifiedby)
- [lk_campaignresponse_modifiedonbehalfby](#BKMK_lk_campaignresponse_modifiedonbehalfby)
- [mspp_adplacement_CampaignResponses](#BKMK_mspp_adplacement_CampaignResponses)
- [mspp_pollplacement_CampaignResponses](#BKMK_mspp_pollplacement_CampaignResponses)
- [mspp_publishingstatetransitionrule_CampaignResponses](#BKMK_mspp_publishingstatetransitionrule_CampaignResponses)
- [mspp_redirect_CampaignResponses](#BKMK_mspp_redirect_CampaignResponses)
- [mspp_shortcut_CampaignResponses](#BKMK_mspp_shortcut_CampaignResponses)
- [mspp_website_CampaignResponses](#BKMK_mspp_website_CampaignResponses)
- [phonecall_campaignresponse](#BKMK_phonecall_campaignresponse)
- [processstage_campaignresponses](#BKMK_processstage_campaignresponses)
- [recurringappointmentmaster_campaignresponse](#BKMK_recurringappointmentmaster_campaignresponse)
- [team_campaignresponse](#BKMK_team_campaignresponse)
- [TransactionCurrency_CampaignResponse](#BKMK_TransactionCurrency_CampaignResponse)
- [user_campaignresponse](#BKMK_user_campaignresponse)

### <a name="BKMK_account_CampaignResponses"></a> account_CampaignResponses

One-To-Many Relationship: [account account_CampaignResponses](account.md#BKMK_account_CampaignResponses)

|Property|Value|
|---|---|
|ReferencedEntity|`account`|
|ReferencedAttribute|`accountid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_account_campaignresponse`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `Cascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_activity_campaignresponse"></a> activity_campaignresponse

One-To-Many Relationship: [activitypointer activity_campaignresponse](activitypointer.md#BKMK_activity_campaignresponse)

|Property|Value|
|---|---|
|ReferencedEntity|`activitypointer`|
|ReferencedAttribute|`activityid`|
|ReferencingAttribute|`originatingactivityid`|
|ReferencingEntityNavigationPropertyName|`originatingactivityid_activitypointer`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_activity_pointer_campaignresponse"></a> activity_pointer_campaignresponse

One-To-Many Relationship: [activitypointer activity_pointer_campaignresponse](activitypointer.md#BKMK_activity_pointer_campaignresponse)

|Property|Value|
|---|---|
|ReferencedEntity|`activitypointer`|
|ReferencedAttribute|`activityid`|
|ReferencingAttribute|`activityid`|
|ReferencingEntityNavigationPropertyName|`activityid_activitypointer`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_adx_invitation_CampaignResponses"></a> adx_invitation_CampaignResponses

One-To-Many Relationship: [adx_invitation adx_invitation_CampaignResponses](adx_invitation.md#BKMK_adx_invitation_CampaignResponses)

|Property|Value|
|---|---|
|ReferencedEntity|`adx_invitation`|
|ReferencedAttribute|`adx_invitationid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_adx_invitation_campaignresponse`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_appointment_campaignresponse"></a> appointment_campaignresponse

One-To-Many Relationship: [appointment appointment_campaignresponse](appointment.md#BKMK_appointment_campaignresponse)

|Property|Value|
|---|---|
|ReferencedEntity|`appointment`|
|ReferencedAttribute|`activityid`|
|ReferencingAttribute|`originatingactivityid`|
|ReferencingEntityNavigationPropertyName|`originatingactivityid_appointment`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_bookableresourcebooking_CampaignResponses"></a> bookableresourcebooking_CampaignResponses

One-To-Many Relationship: [bookableresourcebooking bookableresourcebooking_CampaignResponses](bookableresourcebooking.md#BKMK_bookableresourcebooking_CampaignResponses)

|Property|Value|
|---|---|
|ReferencedEntity|`bookableresourcebooking`|
|ReferencedAttribute|`bookableresourcebookingid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_bookableresourcebooking_campaignresponse`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_bookableresourcebookingheader_CampaignResponses"></a> bookableresourcebookingheader_CampaignResponses

One-To-Many Relationship: [bookableresourcebookingheader bookableresourcebookingheader_CampaignResponses](bookableresourcebookingheader.md#BKMK_bookableresourcebookingheader_CampaignResponses)

|Property|Value|
|---|---|
|ReferencedEntity|`bookableresourcebookingheader`|
|ReferencedAttribute|`bookableresourcebookingheaderid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_bookableresourcebookingheader_campaignresponse`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_BulkOperation_CampaignResponse"></a> BulkOperation_CampaignResponse

One-To-Many Relationship: [bulkoperation BulkOperation_CampaignResponse](bulkoperation.md#BKMK_BulkOperation_CampaignResponse)

|Property|Value|
|---|---|
|ReferencedEntity|`bulkoperation`|
|ReferencedAttribute|`activityid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_bulkoperation_campaignresponse`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_business_unit_campaignresponse_activities"></a> business_unit_campaignresponse_activities

One-To-Many Relationship: [businessunit business_unit_campaignresponse_activities](businessunit.md#BKMK_business_unit_campaignresponse_activities)

|Property|Value|
|---|---|
|ReferencedEntity|`businessunit`|
|ReferencedAttribute|`businessunitid`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencingEntityNavigationPropertyName|`owningbusinessunit_campaignresponse`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_Campaign_CampaignResponses"></a> Campaign_CampaignResponses

One-To-Many Relationship: [campaign Campaign_CampaignResponses](campaign.md#BKMK_Campaign_CampaignResponses)

|Property|Value|
|---|---|
|ReferencedEntity|`campaign`|
|ReferencedAttribute|`campaignid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_campaign_campaignresponse`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_campaignactivity_CampaignResponses"></a> campaignactivity_CampaignResponses

One-To-Many Relationship: [campaignactivity campaignactivity_CampaignResponses](campaignactivity.md#BKMK_campaignactivity_CampaignResponses)

|Property|Value|
|---|---|
|ReferencedEntity|`campaignactivity`|
|ReferencedAttribute|`activityid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_campaignactivity_campaignresponse`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_CampaignResponse_adx_inviteredemptions"></a> CampaignResponse_adx_inviteredemptions

One-To-Many Relationship: [adx_inviteredemption CampaignResponse_adx_inviteredemptions](adx_inviteredemption.md#BKMK_CampaignResponse_adx_inviteredemptions)

|Property|Value|
|---|---|
|ReferencedEntity|`adx_inviteredemption`|
|ReferencedAttribute|`activityid`|
|ReferencingAttribute|`originatingactivityid`|
|ReferencingEntityNavigationPropertyName|`originatingactivityid_adx_inviteredemption_campaignresponse`|
|IsHierarchical||
|CascadeConfiguration|Archive: `Cascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_CampaignResponse_adx_portalcomments"></a> CampaignResponse_adx_portalcomments

One-To-Many Relationship: [adx_portalcomment CampaignResponse_adx_portalcomments](adx_portalcomment.md#BKMK_CampaignResponse_adx_portalcomments)

|Property|Value|
|---|---|
|ReferencedEntity|`adx_portalcomment`|
|ReferencedAttribute|`activityid`|
|ReferencingAttribute|`originatingactivityid`|
|ReferencingEntityNavigationPropertyName|`originatingactivityid_adx_portalcomment_campaignresponse`|
|IsHierarchical||
|CascadeConfiguration|Archive: `Cascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_CampaignResponse_IncidentResolutions"></a> CampaignResponse_IncidentResolutions

One-To-Many Relationship: [incidentresolution CampaignResponse_IncidentResolutions](incidentresolution.md#BKMK_CampaignResponse_IncidentResolutions)

|Property|Value|
|---|---|
|ReferencedEntity|`incidentresolution`|
|ReferencedAttribute|`activityid`|
|ReferencingAttribute|`originatingactivityid`|
|ReferencingEntityNavigationPropertyName|`originatingactivityid_incidentresolution_campaignresponse`|
|IsHierarchical||
|CascadeConfiguration|Archive: `Cascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_campaignresponse_mailbox_sendermailboxid"></a> campaignresponse_mailbox_sendermailboxid

One-To-Many Relationship: [mailbox campaignresponse_mailbox_sendermailboxid](mailbox.md#BKMK_campaignresponse_mailbox_sendermailboxid)

|Property|Value|
|---|---|
|ReferencedEntity|`mailbox`|
|ReferencedAttribute|`mailboxid`|
|ReferencingAttribute|`sendermailboxid`|
|ReferencingEntityNavigationPropertyName|`sendermailboxid_campaignresponse`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_CampaignResponse_msdyn_copilottranscripts"></a> CampaignResponse_msdyn_copilottranscripts

One-To-Many Relationship: [msdyn_copilottranscript CampaignResponse_msdyn_copilottranscripts](msdyn_copilottranscript.md#BKMK_CampaignResponse_msdyn_copilottranscripts)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_copilottranscript`|
|ReferencedAttribute|`activityid`|
|ReferencingAttribute|`originatingactivityid`|
|ReferencingEntityNavigationPropertyName|`originatingactivityid_msdyn_copilottranscript_campaignresponse`|
|IsHierarchical||
|CascadeConfiguration|Archive: `Cascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_CampaignResponse_msdyn_ocliveworkitems"></a> CampaignResponse_msdyn_ocliveworkitems

One-To-Many Relationship: [msdyn_ocliveworkitem CampaignResponse_msdyn_ocliveworkitems](msdyn_ocliveworkitem.md#BKMK_CampaignResponse_msdyn_ocliveworkitems)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_ocliveworkitem`|
|ReferencedAttribute|`activityid`|
|ReferencingAttribute|`originatingactivityid`|
|ReferencingEntityNavigationPropertyName|`originatingactivityid_msdyn_ocliveworkitem_campaignresponse`|
|IsHierarchical||
|CascadeConfiguration|Archive: `Cascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_CampaignResponse_msdyn_ocsessions"></a> CampaignResponse_msdyn_ocsessions

One-To-Many Relationship: [msdyn_ocsession CampaignResponse_msdyn_ocsessions](msdyn_ocsession.md#BKMK_CampaignResponse_msdyn_ocsessions)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_ocsession`|
|ReferencedAttribute|`activityid`|
|ReferencingAttribute|`originatingactivityid`|
|ReferencingEntityNavigationPropertyName|`originatingactivityid_msdyn_ocsession_campaignresponse`|
|IsHierarchical||
|CascadeConfiguration|Archive: `Cascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_CampaignResponse_msfp_alerts"></a> CampaignResponse_msfp_alerts

One-To-Many Relationship: [msfp_alert CampaignResponse_msfp_alerts](msfp_alert.md#BKMK_CampaignResponse_msfp_alerts)

|Property|Value|
|---|---|
|ReferencedEntity|`msfp_alert`|
|ReferencedAttribute|`activityid`|
|ReferencingAttribute|`originatingactivityid`|
|ReferencingEntityNavigationPropertyName|`originatingactivityid_msfp_alert_campaignresponse`|
|IsHierarchical||
|CascadeConfiguration|Archive: `Cascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_CampaignResponse_msfp_surveyinvites"></a> CampaignResponse_msfp_surveyinvites

One-To-Many Relationship: [msfp_surveyinvite CampaignResponse_msfp_surveyinvites](msfp_surveyinvite.md#BKMK_CampaignResponse_msfp_surveyinvites)

|Property|Value|
|---|---|
|ReferencedEntity|`msfp_surveyinvite`|
|ReferencedAttribute|`activityid`|
|ReferencingAttribute|`originatingactivityid`|
|ReferencingEntityNavigationPropertyName|`originatingactivityid_msfp_surveyinvite_campaignresponse`|
|IsHierarchical||
|CascadeConfiguration|Archive: `Cascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_CampaignResponse_msfp_surveyresponses"></a> CampaignResponse_msfp_surveyresponses

One-To-Many Relationship: [msfp_surveyresponse CampaignResponse_msfp_surveyresponses](msfp_surveyresponse.md#BKMK_CampaignResponse_msfp_surveyresponses)

|Property|Value|
|---|---|
|ReferencedEntity|`msfp_surveyresponse`|
|ReferencedAttribute|`activityid`|
|ReferencingAttribute|`originatingactivityid`|
|ReferencingEntityNavigationPropertyName|`originatingactivityid_msfp_surveyresponse_campaignresponse`|
|IsHierarchical||
|CascadeConfiguration|Archive: `Cascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_CampaignResponse_OpportunityCloses"></a> CampaignResponse_OpportunityCloses

One-To-Many Relationship: [opportunityclose CampaignResponse_OpportunityCloses](opportunityclose.md#BKMK_CampaignResponse_OpportunityCloses)

|Property|Value|
|---|---|
|ReferencedEntity|`opportunityclose`|
|ReferencedAttribute|`activityid`|
|ReferencingAttribute|`originatingactivityid`|
|ReferencingEntityNavigationPropertyName|`originatingactivityid_opportunityclose_campaignresponse`|
|IsHierarchical||
|CascadeConfiguration|Archive: `Cascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_CampaignResponse_OrderCloses"></a> CampaignResponse_OrderCloses

One-To-Many Relationship: [orderclose CampaignResponse_OrderCloses](orderclose.md#BKMK_CampaignResponse_OrderCloses)

|Property|Value|
|---|---|
|ReferencedEntity|`orderclose`|
|ReferencedAttribute|`activityid`|
|ReferencingAttribute|`originatingactivityid`|
|ReferencingEntityNavigationPropertyName|`originatingactivityid_orderclose_campaignresponse`|
|IsHierarchical||
|CascadeConfiguration|Archive: `Cascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_campaignresponse_owner_ownerid"></a> campaignresponse_owner_ownerid

One-To-Many Relationship: [owner campaignresponse_owner_ownerid](owner.md#BKMK_campaignresponse_owner_ownerid)

|Property|Value|
|---|---|
|ReferencedEntity|`owner`|
|ReferencedAttribute|`ownerid`|
|ReferencingAttribute|`ownerid`|
|ReferencingEntityNavigationPropertyName|`ownerid_campaignresponse`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_CampaignResponse_QuoteCloses"></a> CampaignResponse_QuoteCloses

One-To-Many Relationship: [quoteclose CampaignResponse_QuoteCloses](quoteclose.md#BKMK_CampaignResponse_QuoteCloses)

|Property|Value|
|---|---|
|ReferencedEntity|`quoteclose`|
|ReferencedAttribute|`activityid`|
|ReferencingAttribute|`originatingactivityid`|
|ReferencingEntityNavigationPropertyName|`originatingactivityid_quoteclose_campaignresponse`|
|IsHierarchical||
|CascadeConfiguration|Archive: `Cascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_CampaignResponse_ServiceAppointments"></a> CampaignResponse_ServiceAppointments

One-To-Many Relationship: [serviceappointment CampaignResponse_ServiceAppointments](serviceappointment.md#BKMK_CampaignResponse_ServiceAppointments)

|Property|Value|
|---|---|
|ReferencedEntity|`serviceappointment`|
|ReferencedAttribute|`activityid`|
|ReferencingAttribute|`originatingactivityid`|
|ReferencingEntityNavigationPropertyName|`originatingactivityid_serviceappointment_campaignresponse`|
|IsHierarchical||
|CascadeConfiguration|Archive: `Cascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_campaignresponse_sla_slaid"></a> campaignresponse_sla_slaid

One-To-Many Relationship: [sla campaignresponse_sla_slaid](sla.md#BKMK_campaignresponse_sla_slaid)

|Property|Value|
|---|---|
|ReferencedEntity|`sla`|
|ReferencedAttribute|`slaid`|
|ReferencingAttribute|`slaid`|
|ReferencingEntityNavigationPropertyName|`sla_activitypointer_sla_campaignresponse`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_campaignresponse_sla_slainvokedid"></a> campaignresponse_sla_slainvokedid

One-To-Many Relationship: [sla campaignresponse_sla_slainvokedid](sla.md#BKMK_campaignresponse_sla_slainvokedid)

|Property|Value|
|---|---|
|ReferencedEntity|`sla`|
|ReferencedAttribute|`slaid`|
|ReferencingAttribute|`slainvokedid`|
|ReferencingEntityNavigationPropertyName|`slainvokedid_activitypointer_sla_campaignresponse`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_contact_CampaignResponses"></a> contact_CampaignResponses

One-To-Many Relationship: [contact contact_CampaignResponses](contact.md#BKMK_contact_CampaignResponses)

|Property|Value|
|---|---|
|ReferencedEntity|`contact`|
|ReferencedAttribute|`contactid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_contact_campaignresponse`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `Cascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_email_campaignresponse"></a> email_campaignresponse

One-To-Many Relationship: [email email_campaignresponse](email.md#BKMK_email_campaignresponse)

|Property|Value|
|---|---|
|ReferencedEntity|`email`|
|ReferencedAttribute|`activityid`|
|ReferencingAttribute|`originatingactivityid`|
|ReferencingEntityNavigationPropertyName|`originatingactivityid_email`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_fax_campaignresponse"></a> fax_campaignresponse

One-To-Many Relationship: [fax fax_campaignresponse](fax.md#BKMK_fax_campaignresponse)

|Property|Value|
|---|---|
|ReferencedEntity|`fax`|
|ReferencedAttribute|`activityid`|
|ReferencingAttribute|`originatingactivityid`|
|ReferencingEntityNavigationPropertyName|`originatingactivityid_fax`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_interactionforemail_CampaignResponses"></a> interactionforemail_CampaignResponses

One-To-Many Relationship: [interactionforemail interactionforemail_CampaignResponses](interactionforemail.md#BKMK_interactionforemail_CampaignResponses)

|Property|Value|
|---|---|
|ReferencedEntity|`interactionforemail`|
|ReferencedAttribute|`interactionforemailid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_new_interactionforemail_campaignresponse`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_knowledgearticle_CampaignResponses"></a> knowledgearticle_CampaignResponses

One-To-Many Relationship: [knowledgearticle knowledgearticle_CampaignResponses](knowledgearticle.md#BKMK_knowledgearticle_CampaignResponses)

|Property|Value|
|---|---|
|ReferencedEntity|`knowledgearticle`|
|ReferencedAttribute|`knowledgearticleid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_knowledgearticle_campaignresponse`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_knowledgebaserecord_CampaignResponses"></a> knowledgebaserecord_CampaignResponses

One-To-Many Relationship: [knowledgebaserecord knowledgebaserecord_CampaignResponses](knowledgebaserecord.md#BKMK_knowledgebaserecord_CampaignResponses)

|Property|Value|
|---|---|
|ReferencedEntity|`knowledgebaserecord`|
|ReferencedAttribute|`knowledgebaserecordid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_knowledgebaserecord_campaignresponse`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lead_CampaignResponses"></a> lead_CampaignResponses

One-To-Many Relationship: [lead lead_CampaignResponses](lead.md#BKMK_lead_CampaignResponses)

|Property|Value|
|---|---|
|ReferencedEntity|`lead`|
|ReferencedAttribute|`leadid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_lead_campaignresponse`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `Cascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_letter_campaignresponse"></a> letter_campaignresponse

One-To-Many Relationship: [letter letter_campaignresponse](letter.md#BKMK_letter_campaignresponse)

|Property|Value|
|---|---|
|ReferencedEntity|`letter`|
|ReferencedAttribute|`activityid`|
|ReferencingAttribute|`originatingactivityid`|
|ReferencingEntityNavigationPropertyName|`originatingactivityid_letter`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_campaignresponse_createdby"></a> lk_campaignresponse_createdby

One-To-Many Relationship: [systemuser lk_campaignresponse_createdby](systemuser.md#BKMK_lk_campaignresponse_createdby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdby`|
|ReferencingEntityNavigationPropertyName|`createdby_campaignresponse`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_campaignresponse_createdonbehalfby"></a> lk_campaignresponse_createdonbehalfby

One-To-Many Relationship: [systemuser lk_campaignresponse_createdonbehalfby](systemuser.md#BKMK_lk_campaignresponse_createdonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdonbehalfby`|
|ReferencingEntityNavigationPropertyName|`createdonbehalfby_campaignresponse`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_campaignresponse_modifiedby"></a> lk_campaignresponse_modifiedby

One-To-Many Relationship: [systemuser lk_campaignresponse_modifiedby](systemuser.md#BKMK_lk_campaignresponse_modifiedby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedby`|
|ReferencingEntityNavigationPropertyName|`modifiedby_campaignresponse`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_campaignresponse_modifiedonbehalfby"></a> lk_campaignresponse_modifiedonbehalfby

One-To-Many Relationship: [systemuser lk_campaignresponse_modifiedonbehalfby](systemuser.md#BKMK_lk_campaignresponse_modifiedonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedonbehalfby`|
|ReferencingEntityNavigationPropertyName|`modifiedonbehalfby_campaignresponse`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_mspp_adplacement_CampaignResponses"></a> mspp_adplacement_CampaignResponses

One-To-Many Relationship: [mspp_adplacement mspp_adplacement_CampaignResponses](mspp_adplacement.md#BKMK_mspp_adplacement_CampaignResponses)

|Property|Value|
|---|---|
|ReferencedEntity|`mspp_adplacement`|
|ReferencedAttribute|`mspp_adplacementid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_mspp_adplacement_campaignresponse`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_mspp_pollplacement_CampaignResponses"></a> mspp_pollplacement_CampaignResponses

One-To-Many Relationship: [mspp_pollplacement mspp_pollplacement_CampaignResponses](mspp_pollplacement.md#BKMK_mspp_pollplacement_CampaignResponses)

|Property|Value|
|---|---|
|ReferencedEntity|`mspp_pollplacement`|
|ReferencedAttribute|`mspp_pollplacementid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_mspp_pollplacement_campaignresponse`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_mspp_publishingstatetransitionrule_CampaignResponses"></a> mspp_publishingstatetransitionrule_CampaignResponses

One-To-Many Relationship: [mspp_publishingstatetransitionrule mspp_publishingstatetransitionrule_CampaignResponses](mspp_publishingstatetransitionrule.md#BKMK_mspp_publishingstatetransitionrule_CampaignResponses)

|Property|Value|
|---|---|
|ReferencedEntity|`mspp_publishingstatetransitionrule`|
|ReferencedAttribute|`mspp_publishingstatetransitionruleid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_mspp_publishingstatetransitionrule_campaignresponse`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_mspp_redirect_CampaignResponses"></a> mspp_redirect_CampaignResponses

One-To-Many Relationship: [mspp_redirect mspp_redirect_CampaignResponses](mspp_redirect.md#BKMK_mspp_redirect_CampaignResponses)

|Property|Value|
|---|---|
|ReferencedEntity|`mspp_redirect`|
|ReferencedAttribute|`mspp_redirectid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_mspp_redirect_campaignresponse`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_mspp_shortcut_CampaignResponses"></a> mspp_shortcut_CampaignResponses

One-To-Many Relationship: [mspp_shortcut mspp_shortcut_CampaignResponses](mspp_shortcut.md#BKMK_mspp_shortcut_CampaignResponses)

|Property|Value|
|---|---|
|ReferencedEntity|`mspp_shortcut`|
|ReferencedAttribute|`mspp_shortcutid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_mspp_shortcut_campaignresponse`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_mspp_website_CampaignResponses"></a> mspp_website_CampaignResponses

One-To-Many Relationship: [mspp_website mspp_website_CampaignResponses](mspp_website.md#BKMK_mspp_website_CampaignResponses)

|Property|Value|
|---|---|
|ReferencedEntity|`mspp_website`|
|ReferencedAttribute|`mspp_websiteid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_mspp_website_campaignresponse`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_phonecall_campaignresponse"></a> phonecall_campaignresponse

One-To-Many Relationship: [phonecall phonecall_campaignresponse](phonecall.md#BKMK_phonecall_campaignresponse)

|Property|Value|
|---|---|
|ReferencedEntity|`phonecall`|
|ReferencedAttribute|`activityid`|
|ReferencingAttribute|`originatingactivityid`|
|ReferencingEntityNavigationPropertyName|`originatingactivityid_phonecall`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_processstage_campaignresponses"></a> processstage_campaignresponses

One-To-Many Relationship: [processstage processstage_campaignresponses](processstage.md#BKMK_processstage_campaignresponses)

|Property|Value|
|---|---|
|ReferencedEntity|`processstage`|
|ReferencedAttribute|`processstageid`|
|ReferencingAttribute|`stageid`|
|ReferencingEntityNavigationPropertyName|`stageid_processstage`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_recurringappointmentmaster_campaignresponse"></a> recurringappointmentmaster_campaignresponse

One-To-Many Relationship: [recurringappointmentmaster recurringappointmentmaster_campaignresponse](recurringappointmentmaster.md#BKMK_recurringappointmentmaster_campaignresponse)

|Property|Value|
|---|---|
|ReferencedEntity|`recurringappointmentmaster`|
|ReferencedAttribute|`activityid`|
|ReferencingAttribute|`originatingactivityid`|
|ReferencingEntityNavigationPropertyName|`originatingactivityid_recurringappointmentmaster`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_team_campaignresponse"></a> team_campaignresponse

One-To-Many Relationship: [team team_campaignresponse](team.md#BKMK_team_campaignresponse)

|Property|Value|
|---|---|
|ReferencedEntity|`team`|
|ReferencedAttribute|`teamid`|
|ReferencingAttribute|`owningteam`|
|ReferencingEntityNavigationPropertyName|`owningteam_campaignresponse`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_TransactionCurrency_CampaignResponse"></a> TransactionCurrency_CampaignResponse

One-To-Many Relationship: [transactioncurrency TransactionCurrency_CampaignResponse](transactioncurrency.md#BKMK_TransactionCurrency_CampaignResponse)

|Property|Value|
|---|---|
|ReferencedEntity|`transactioncurrency`|
|ReferencedAttribute|`transactioncurrencyid`|
|ReferencingAttribute|`transactioncurrencyid`|
|ReferencingEntityNavigationPropertyName|`transactioncurrencyid_campaignresponse`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Restrict`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_user_campaignresponse"></a> user_campaignresponse

One-To-Many Relationship: [systemuser user_campaignresponse](systemuser.md#BKMK_user_campaignresponse)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`owninguser`|
|ReferencingEntityNavigationPropertyName|`owninguser_campaignresponse`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|


## One-to-Many relationships

These relationships are one-to-many. Listed by **SchemaName**.

- [campaignresponse_activity_parties](#BKMK_campaignresponse_activity_parties)
- [CampaignResponse_Annotation](#BKMK_CampaignResponse_Annotation)
- [CampaignResponse_AsyncOperations](#BKMK_CampaignResponse_AsyncOperations)
- [CampaignResponse_BulkDeleteFailures](#BKMK_CampaignResponse_BulkDeleteFailures)
- [CampaignResponse_DuplicateBaseRecord](#BKMK_CampaignResponse_DuplicateBaseRecord)
- [CampaignResponse_DuplicateMatchingRecord](#BKMK_CampaignResponse_DuplicateMatchingRecord)
- [CampaignResponse_Lead](#BKMK_CampaignResponse_Lead)
- [campaignresponse_MailboxTrackingFolders](#BKMK_campaignresponse_MailboxTrackingFolders)
- [campaignresponse_principalobjectattributeaccess](#BKMK_campaignresponse_principalobjectattributeaccess)
- [CampaignResponse_ProcessSessions](#BKMK_CampaignResponse_ProcessSessions)
- [CampaignResponse_QueueItem](#BKMK_CampaignResponse_QueueItem)
- [CampaignResponse_SyncErrors](#BKMK_CampaignResponse_SyncErrors)

### <a name="BKMK_campaignresponse_activity_parties"></a> campaignresponse_activity_parties

Many-To-One Relationship: [activityparty campaignresponse_activity_parties](activityparty.md#BKMK_campaignresponse_activity_parties)

|Property|Value|
|---|---|
|ReferencingEntity|`activityparty`|
|ReferencingAttribute|`activityid`|
|ReferencedEntityNavigationPropertyName|`campaignresponse_activity_parties`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_CampaignResponse_Annotation"></a> CampaignResponse_Annotation

Many-To-One Relationship: [annotation CampaignResponse_Annotation](annotation.md#BKMK_CampaignResponse_Annotation)

|Property|Value|
|---|---|
|ReferencingEntity|`annotation`|
|ReferencingAttribute|`objectid`|
|ReferencedEntityNavigationPropertyName|`CampaignResponse_Annotation`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_CampaignResponse_AsyncOperations"></a> CampaignResponse_AsyncOperations

Many-To-One Relationship: [asyncoperation CampaignResponse_AsyncOperations](asyncoperation.md#BKMK_CampaignResponse_AsyncOperations)

|Property|Value|
|---|---|
|ReferencingEntity|`asyncoperation`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`CampaignResponse_AsyncOperations`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_CampaignResponse_BulkDeleteFailures"></a> CampaignResponse_BulkDeleteFailures

Many-To-One Relationship: [bulkdeletefailure CampaignResponse_BulkDeleteFailures](bulkdeletefailure.md#BKMK_CampaignResponse_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencingEntity|`bulkdeletefailure`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`CampaignResponse_BulkDeleteFailures`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_CampaignResponse_DuplicateBaseRecord"></a> CampaignResponse_DuplicateBaseRecord

Many-To-One Relationship: [duplicaterecord CampaignResponse_DuplicateBaseRecord](duplicaterecord.md#BKMK_CampaignResponse_DuplicateBaseRecord)

|Property|Value|
|---|---|
|ReferencingEntity|`duplicaterecord`|
|ReferencingAttribute|`baserecordid`|
|ReferencedEntityNavigationPropertyName|`CampaignResponse_DuplicateBaseRecord`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_CampaignResponse_DuplicateMatchingRecord"></a> CampaignResponse_DuplicateMatchingRecord

Many-To-One Relationship: [duplicaterecord CampaignResponse_DuplicateMatchingRecord](duplicaterecord.md#BKMK_CampaignResponse_DuplicateMatchingRecord)

|Property|Value|
|---|---|
|ReferencingEntity|`duplicaterecord`|
|ReferencingAttribute|`duplicaterecordid`|
|ReferencedEntityNavigationPropertyName|`CampaignResponse_DuplicateMatchingRecord`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_CampaignResponse_Lead"></a> CampaignResponse_Lead

Many-To-One Relationship: [lead CampaignResponse_Lead](lead.md#BKMK_CampaignResponse_Lead)

|Property|Value|
|---|---|
|ReferencingEntity|`lead`|
|ReferencingAttribute|`relatedobjectid`|
|ReferencedEntityNavigationPropertyName|`CampaignResponse_Lead`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_campaignresponse_MailboxTrackingFolders"></a> campaignresponse_MailboxTrackingFolders

Many-To-One Relationship: [mailboxtrackingfolder campaignresponse_MailboxTrackingFolders](mailboxtrackingfolder.md#BKMK_campaignresponse_MailboxTrackingFolders)

|Property|Value|
|---|---|
|ReferencingEntity|`mailboxtrackingfolder`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`campaignresponse_MailboxTrackingFolders`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_campaignresponse_principalobjectattributeaccess"></a> campaignresponse_principalobjectattributeaccess

Many-To-One Relationship: [principalobjectattributeaccess campaignresponse_principalobjectattributeaccess](principalobjectattributeaccess.md#BKMK_campaignresponse_principalobjectattributeaccess)

|Property|Value|
|---|---|
|ReferencingEntity|`principalobjectattributeaccess`|
|ReferencingAttribute|`objectid`|
|ReferencedEntityNavigationPropertyName|`campaignresponse_principalobjectattributeaccess`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_CampaignResponse_ProcessSessions"></a> CampaignResponse_ProcessSessions

Many-To-One Relationship: [processsession CampaignResponse_ProcessSessions](processsession.md#BKMK_CampaignResponse_ProcessSessions)

|Property|Value|
|---|---|
|ReferencingEntity|`processsession`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`CampaignResponse_ProcessSessions`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 110<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_CampaignResponse_QueueItem"></a> CampaignResponse_QueueItem

Many-To-One Relationship: [queueitem CampaignResponse_QueueItem](queueitem.md#BKMK_CampaignResponse_QueueItem)

|Property|Value|
|---|---|
|ReferencingEntity|`queueitem`|
|ReferencingAttribute|`objectid`|
|ReferencedEntityNavigationPropertyName|`CampaignResponse_QueueItem`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_CampaignResponse_SyncErrors"></a> CampaignResponse_SyncErrors

Many-To-One Relationship: [syncerror CampaignResponse_SyncErrors](syncerror.md#BKMK_CampaignResponse_SyncErrors)

|Property|Value|
|---|---|
|ReferencingEntity|`syncerror`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`CampaignResponse_SyncErrors`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|



### See also

[Dataverse table/entity reference](/power-apps/developer/data-platform/reference/about-entity-reference)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   

