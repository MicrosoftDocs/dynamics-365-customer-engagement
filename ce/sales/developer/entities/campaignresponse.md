---
title: "CampaignResponse table/entity reference (Dynamics 365 Sales) | Microsoft Docs"
description: "Includes schema information and supported messages for the CampaignResponse table/entity."
ms.date: 02/17/2023
ms.service: dynamics-365-sales
ms.topic: "reference"
ms.assetid: 3948cc48-07c8-7f60-0608-71c37158ad7c
author: "udaykirang"
ms.author: "udag"
search.audienceType: 
  - developer
---

# CampaignResponse table/entity reference

> [!NOTE]
> Unsure about table vs. entity? See [Developers: Understand terminology in Microsoft Dataverse](/powerapps/developer/data-platform/understand-terminology).

Response from an existing or a potential new customer for a campaign.

**Added by**: Marketing Solution


## Messages

|Message|SDK Assembly|
|-|-|
|Assign|<xref:Microsoft.Crm.Sdk.Messages.AssignRequest>|
|CopyCampaignResponse|<xref:Microsoft.Crm.Sdk.Messages.CopyCampaignResponseRequest>|
|Create|<xref:Microsoft.Xrm.Sdk.Messages.CreateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Create*>|
|Delete|<xref:Microsoft.Xrm.Sdk.Messages.DeleteRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Delete*>|
|GrantAccess|<xref:Microsoft.Crm.Sdk.Messages.GrantAccessRequest>|
|ModifyAccess|<xref:Microsoft.Crm.Sdk.Messages.ModifyAccessRequest>|
|Retrieve|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Retrieve*>|
|RetrieveMultiple|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveMultipleRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.RetrieveMultiple*>|
|RetrievePrincipalAccess|<xref:Microsoft.Crm.Sdk.Messages.RetrievePrincipalAccessRequest>|
|RetrieveSharedPrincipalsAndAccess|<xref:Microsoft.Crm.Sdk.Messages.RetrieveSharedPrincipalsAndAccessRequest>|
|RevokeAccess|<xref:Microsoft.Crm.Sdk.Messages.RevokeAccessRequest>|
|SetState|<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|
|Update|<xref:Microsoft.Xrm.Sdk.Messages.UpdateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Update*>|

## Properties

|Property|Value|
|--------|-----|
|CollectionSchemaName|CampaignResponses|
|DisplayCollectionName|Campaign Responses|
|DisplayName|Campaign Response|
|EntitySetName|campaignresponses|
|IsBPFEntity|False|
|LogicalCollectionName|campaignresponses|
|LogicalName|campaignresponse|
|OwnershipType|UserOwned|
|PrimaryIdAttribute|activityid|
|PrimaryNameAttribute|subject|
|SchemaName|CampaignResponse|

<a name="writable-attributes"></a>

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
|--------|-----|
|Description|For internal use only.|
|DisplayName|Additional Parameters|
|Format|TextArea|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|activityadditionalparams|
|MaxLength|8192|
|RequiredLevel|None|
|Type|Memo|


### <a name="BKMK_ActivityId"></a> ActivityId

|Property|Value|
|--------|-----|
|Description|Unique identifier of the campaign response.|
|DisplayName|Campaign Response|
|IsValidForForm|False|
|IsValidForRead|True|
|IsValidForUpdate|False|
|LogicalName|activityid|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|


### <a name="BKMK_ActualDurationMinutes"></a> ActualDurationMinutes

|Property|Value|
|--------|-----|
|Description|Type the number of minutes spent on this activity. The duration is used in reporting.|
|DisplayName|Actual Duration |
|Format|None|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|actualdurationminutes|
|MaxValue|2147483647|
|MinValue|0|
|RequiredLevel|None|
|Type|Integer|


### <a name="BKMK_ActualEnd"></a> ActualEnd

|Property|Value|
|--------|-----|
|DateTimeBehavior|UserLocal|
|Description|Enter the date when the campaign response was actually completed.|
|DisplayName|Actual End|
|Format|DateOnly|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|actualend|
|RequiredLevel|None|
|Type|DateTime|


### <a name="BKMK_ActualStart"></a> ActualStart

|Property|Value|
|--------|-----|
|DateTimeBehavior|UserLocal|
|Description|Enter the actual start date and time for the campaign response.|
|DisplayName|Actual Start|
|Format|DateOnly|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|actualstart|
|RequiredLevel|None|
|Type|DateTime|


### <a name="BKMK_BCC"></a> BCC

|Property|Value|
|--------|-----|
|Description|Blind Carbon-copy (bcc) recipients of the activity.|
|DisplayName|BCC|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|bcc|
|RequiredLevel|None|
|Targets|account,contact,systemuser|
|Type|PartyList|


### <a name="BKMK_Category"></a> Category

|Property|Value|
|--------|-----|
|Description|Type a category to identify the campaign response type, such as new business development or customer retention, to tie the campaign response to a business group or function.|
|DisplayName|Category|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|category|
|MaxLength|250|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_CC"></a> CC

|Property|Value|
|--------|-----|
|Description|Carbon-copy (cc) recipients of the activity.|
|DisplayName|CC|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|cc|
|RequiredLevel|None|
|Targets|account,contact,systemuser|
|Type|PartyList|


### <a name="BKMK_ChannelTypeCode"></a> ChannelTypeCode

|Property|Value|
|--------|-----|
|Description|Select how the response was received, such as phone, letter, fax, or email.|
|DisplayName|Channel|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|channeltypecode|
|RequiredLevel|None|
|Type|Picklist|

#### ChannelTypeCode Choices/Options

|Value|Label|Description|
|-----|-----|--------|
|1|Email||
|2|Phone||
|3|Fax||
|4|Letter||
|5|Appointment||
|6|Others||



### <a name="BKMK_Community"></a> Community

|Property|Value|
|--------|-----|
|Description|Shows how contact about the social activity originated, such as from Twitter or Facebook. This field is read-only.|
|DisplayName|Social Channel|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|community|
|RequiredLevel|None|
|Type|Picklist|

#### Community Choices/Options

|Value|Label|Description|
|-----|-----|--------|
|0|Other|Other default|
|1|Facebook|Facebook item.|
|2|Twitter|Twitter.|
|3|Line||
|4|Wechat||
|5|Cortana||
|6|Direct Line||
|7|Microsoft Teams||
|8|Direct Line Speech||
|9|Email||
|10|GroupMe||
|11|Kik||
|12|Telegram||
|13|Skype||
|14|Slack||
|15|WhatsApp||
|16|Apple Messages For Business||
|17|Google's Business Messages||



### <a name="BKMK_CompanyName"></a> CompanyName

|Property|Value|
|--------|-----|
|Description|Type the name of the company if the campaign response was received from a new prospect or customer.|
|DisplayName|Company Name|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|companyname|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_Customer"></a> Customer

|Property|Value|
|--------|-----|
|Description|Enter the account, contact, or lead that submitted the campaign response, if it was received from an existing prospect or customer.|
|DisplayName|Customer|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|customer|
|RequiredLevel|None|
|Targets|account,contact,lead|
|Type|PartyList|


### <a name="BKMK_Customers"></a> Customers

|Property|Value|
|--------|-----|
|Description|Customer with which the activity is associated.|
|DisplayName|Customers|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|customers|
|RequiredLevel|None|
|Targets|account,contact|
|Type|PartyList|


### <a name="BKMK_DeliveryPriorityCode"></a> DeliveryPriorityCode

|Property|Value|
|--------|-----|
|Description|Priority of delivery of the activity to the email server.|
|DisplayName|Delivery Priority|
|IsValidForForm|True|
|IsValidForRead|True|
|IsValidForUpdate|False|
|LogicalName|deliveryprioritycode|
|RequiredLevel|None|
|Type|Picklist|

#### DeliveryPriorityCode Choices/Options

|Value|Label|Description|
|-----|-----|--------|
|0|Low||
|1|Normal||
|2|High||



### <a name="BKMK_Description"></a> Description

|Property|Value|
|--------|-----|
|Description|Type additional information to describe the campaign response, such as key discussion points or objectives.|
|DisplayName|Description|
|Format|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|description|
|MaxLength|2000|
|RequiredLevel|None|
|Type|Memo|


### <a name="BKMK_EMailAddress"></a> EMailAddress

|Property|Value|
|--------|-----|
|Description|Type the responder's email address.|
|DisplayName|Email|
|FormatName|Email|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|emailaddress|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_ExchangeItemId"></a> ExchangeItemId

|Property|Value|
|--------|-----|
|Description|The message id of activity which is returned from Exchange Server.|
|DisplayName|Exchange Item ID|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|exchangeitemid|
|MaxLength|200|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_ExchangeWebLink"></a> ExchangeWebLink

|Property|Value|
|--------|-----|
|Description|Shows the web link of Activity of type email.|
|DisplayName|Exchange WebLink|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|exchangeweblink|
|MaxLength|1250|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_Fax"></a> Fax

|Property|Value|
|--------|-----|
|Description|Type the responder's fax number.|
|DisplayName|Fax|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|fax|
|MaxLength|50|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_FirstName"></a> FirstName

|Property|Value|
|--------|-----|
|Description|Type the responder's first name if the campaign response was received from a new prospect or customer.|
|DisplayName|First Name|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|firstname|
|MaxLength|50|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_from"></a> from

|Property|Value|
|--------|-----|
|Description|For system use only.|
|DisplayName|From|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|from|
|RequiredLevel|None|
|Targets|account,contact,systemuser|
|Type|PartyList|


### <a name="BKMK_ImportSequenceNumber"></a> ImportSequenceNumber

|Property|Value|
|--------|-----|
|Description|Sequence number of the import that created this record.|
|DisplayName|Import Sequence Number|
|Format|None|
|IsValidForForm|False|
|IsValidForRead|True|
|IsValidForUpdate|False|
|LogicalName|importsequencenumber|
|MaxValue|2147483647|
|MinValue|-2147483648|
|RequiredLevel|None|
|Type|Integer|


### <a name="BKMK_IsBilled"></a> IsBilled

|Property|Value|
|--------|-----|
|Description|Specifies whether the campaign response was billed as part of resolving a case.|
|DisplayName|Is Billed|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|isbilled|
|RequiredLevel|None|
|Type|Boolean|

#### IsBilled Choices/Options

|Value|Label|Description|
|-----|-----|--------|
|1|Yes||
|0|No||

**DefaultValue**: 0



### <a name="BKMK_IsMapiPrivate"></a> IsMapiPrivate

|Property|Value|
|--------|-----|
|Description|For internal use only.|
|DisplayName|Is Private|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|ismapiprivate|
|RequiredLevel|None|
|Type|Boolean|

#### IsMapiPrivate Choices/Options

|Value|Label|Description|
|-----|-----|--------|
|1|Yes||
|0|No||

**DefaultValue**: 0



### <a name="BKMK_IsWorkflowCreated"></a> IsWorkflowCreated

|Property|Value|
|--------|-----|
|Description|Specifies whether the campaign response is created by a workflow rule.|
|DisplayName|Is Workflow Created|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|isworkflowcreated|
|RequiredLevel|None|
|Type|Boolean|

#### IsWorkflowCreated Choices/Options

|Value|Label|Description|
|-----|-----|--------|
|1|Yes||
|0|No||

**DefaultValue**: 0



### <a name="BKMK_LastName"></a> LastName

|Property|Value|
|--------|-----|
|Description|Type the responder's last name if the campaign response was received from a new prospect or customer.|
|DisplayName|Last Name|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|lastname|
|MaxLength|50|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_LastOnHoldTime"></a> LastOnHoldTime

|Property|Value|
|--------|-----|
|DateTimeBehavior|UserLocal|
|Description|Contains the date and time stamp of the last on hold time.|
|DisplayName|Last On Hold Time|
|Format|DateAndTime|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|lastonholdtime|
|RequiredLevel|None|
|Type|DateTime|


### <a name="BKMK_LeftVoiceMail"></a> LeftVoiceMail

|Property|Value|
|--------|-----|
|Description|Left the voice mail|
|DisplayName|Left Voice Mail|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|leftvoicemail|
|RequiredLevel|None|
|Type|Boolean|

#### LeftVoiceMail Choices/Options

|Value|Label|Description|
|-----|-----|--------|
|1|Yes||
|0|No||

**DefaultValue**: 0



### <a name="BKMK_OptionalAttendees"></a> OptionalAttendees

|Property|Value|
|--------|-----|
|Description|List of optional attendees for the activity.|
|DisplayName|Optional Attendees|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|optionalattendees|
|RequiredLevel|None|
|Targets|account,contact,systemuser|
|Type|PartyList|


### <a name="BKMK_Organizer"></a> Organizer

|Property|Value|
|--------|-----|
|Description|Person who organized the activity.|
|DisplayName|Organizer|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|organizer|
|RequiredLevel|None|
|Targets|systemuser|
|Type|PartyList|


### <a name="BKMK_OriginatingActivityId"></a> OriginatingActivityId

|Property|Value|
|--------|-----|
|Description|Choose the phone call, email, fax, letter, or appointment activity that led the prospect or customer to respond to the campaign.|
|DisplayName|Originating Activity|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|originatingactivityid|
|RequiredLevel|None|
|Targets|appointment,email,fax,letter,phonecall|
|Type|Lookup|


### <a name="BKMK_OriginatingActivityIdTypeCode"></a> OriginatingActivityIdTypeCode

**Added by**: Active Solution Solution

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|originatingactivityidtypecode|
|RequiredLevel|None|
|Type|EntityName|


### <a name="BKMK_OverriddenCreatedOn"></a> OverriddenCreatedOn

|Property|Value|
|--------|-----|
|DateTimeBehavior|UserLocal|
|Description|Date and time that the record was migrated.|
|DisplayName|Record Created On|
|Format|DateOnly|
|IsValidForForm|False|
|IsValidForRead|True|
|IsValidForUpdate|False|
|LogicalName|overriddencreatedon|
|RequiredLevel|None|
|Type|DateTime|


### <a name="BKMK_OwnerId"></a> OwnerId

|Property|Value|
|--------|-----|
|Description|Unique identifier of the user or team who owns the activity.|
|DisplayName|Owner|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|ownerid|
|RequiredLevel|SystemRequired|
|Targets|systemuser,team|
|Type|Owner|


### <a name="BKMK_OwnerIdType"></a> OwnerIdType

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|owneridtype|
|RequiredLevel|SystemRequired|
|Type|EntityName|


### <a name="BKMK_Partner"></a> Partner

|Property|Value|
|--------|-----|
|Description|Enter the vendor account or contact to capture any third-party used to obtain the campaign response.|
|DisplayName|Outsource Vendor|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|partner|
|RequiredLevel|None|
|Targets|account,contact|
|Type|PartyList|


### <a name="BKMK_Partners"></a> Partners

|Property|Value|
|--------|-----|
|Description|Outsource vendor with which activity is associated.|
|DisplayName|Outsource Vendors|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|partners|
|RequiredLevel|None|
|Targets|account,contact|
|Type|PartyList|


### <a name="BKMK_PriorityCode"></a> PriorityCode

|Property|Value|
|--------|-----|
|Description|Select the priority so that preferred customers or critical issues are handled quickly.|
|DisplayName|Priority|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|prioritycode|
|RequiredLevel|None|
|Type|Picklist|

#### PriorityCode Choices/Options

|Value|Label|Description|
|-----|-----|--------|
|0|Low||
|1|Normal||
|2|High||



### <a name="BKMK_ProcessId"></a> ProcessId

|Property|Value|
|--------|-----|
|Description|Unique identifier of the Process.|
|DisplayName|Process|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|processid|
|RequiredLevel|None|
|Type|Uniqueidentifier|


### <a name="BKMK_PromotionCodeName"></a> PromotionCodeName

|Property|Value|
|--------|-----|
|Description|Type a promotional code to track sales related to the campaign response or to allow the responder to redeem a discount offer.|
|DisplayName|Promotion Code|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|promotioncodename|
|MaxLength|250|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_ReceivedOn"></a> ReceivedOn

|Property|Value|
|--------|-----|
|DateTimeBehavior|UserLocal|
|Description|Enter the date when the campaign response was received.|
|DisplayName|Received On|
|Format|DateOnly|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|receivedon|
|RequiredLevel|None|
|Type|DateTime|


### <a name="BKMK_RegardingObjectId"></a> RegardingObjectId

|Property|Value|
|--------|-----|
|Description|Choose the parent campaign so that the campaign's response rate is tracked correctly.|
|DisplayName|Parent Campaign|
|IsValidForForm|True|
|IsValidForRead|True|
|IsValidForUpdate|False|
|LogicalName|regardingobjectid|
|RequiredLevel|ApplicationRequired|
|Targets|bulkoperation,campaign|
|Type|Lookup|


### <a name="BKMK_RegardingObjectTypeCode"></a> RegardingObjectTypeCode

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|IsValidForForm|False|
|IsValidForRead|True|
|IsValidForUpdate|False|
|LogicalName|regardingobjecttypecode|
|RequiredLevel|None|
|Type|EntityName|


### <a name="BKMK_RequiredAttendees"></a> RequiredAttendees

|Property|Value|
|--------|-----|
|Description|List of required attendees for the activity.|
|DisplayName|Required Attendees|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|requiredattendees|
|RequiredLevel|None|
|Targets|account,contact,systemuser|
|Type|PartyList|


### <a name="BKMK_Resources"></a> Resources

|Property|Value|
|--------|-----|
|Description|Users or facility/equipment that are required for the activity.|
|DisplayName|Resources|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|resources|
|RequiredLevel|None|
|Targets|systemuser|
|Type|PartyList|


### <a name="BKMK_ResponseCode"></a> ResponseCode

|Property|Value|
|--------|-----|
|Description|Select the type of response from the prospect or customer to indicate their interest in the campaign.|
|DisplayName|Response Code|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|responsecode|
|RequiredLevel|None|
|Type|Picklist|

#### ResponseCode Choices/Options

|Value|Label|Description|
|-----|-----|--------|
|1|Interested||
|2|Not Interested||
|3|Do Not Send Marketing Materials||
|4|Error||



### <a name="BKMK_ScheduledEnd"></a> ScheduledEnd

|Property|Value|
|--------|-----|
|DateTimeBehavior|UserLocal|
|Description|Enter the expected due date and time for the activity to be completed to provide details about the timing of the campaign response.|
|DisplayName|Close By|
|Format|DateOnly|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|scheduledend|
|RequiredLevel|None|
|Type|DateTime|


### <a name="BKMK_ScheduledStart"></a> ScheduledStart

|Property|Value|
|--------|-----|
|DateTimeBehavior|UserLocal|
|Description|Enter the expected start date and time for the activity to provide details about the timing of the campaign response.|
|DisplayName|Scheduled Start|
|Format|DateOnly|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|scheduledstart|
|RequiredLevel|None|
|Type|DateTime|


### <a name="BKMK_ServiceId"></a> ServiceId

**Added by**: Marketing Service Solution

|Property|Value|
|--------|-----|
|Description|Unique identifier for the associated service.|
|DisplayName|Service|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|serviceid|
|RequiredLevel|None|
|Targets|service|
|Type|Lookup|


### <a name="BKMK_SLAId"></a> SLAId

|Property|Value|
|--------|-----|
|Description|Choose the service level agreement (SLA) that you want to apply to the case record.|
|DisplayName|SLA|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|slaid|
|RequiredLevel|None|
|Targets|sla|
|Type|Lookup|


### <a name="BKMK_SortDate"></a> SortDate

|Property|Value|
|--------|-----|
|DateTimeBehavior|UserLocal|
|Description|Shows the date and time by which the activities are sorted.|
|DisplayName|Sort Date|
|Format|DateAndTime|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|sortdate|
|RequiredLevel|None|
|Type|DateTime|


### <a name="BKMK_StageId"></a> StageId

|Property|Value|
|--------|-----|
|Description|Unique identifier of the Stage.|
|DisplayName|(Deprecated) Process Stage|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|stageid|
|RequiredLevel|None|
|Type|Uniqueidentifier|


### <a name="BKMK_StateCode"></a> StateCode

|Property|Value|
|--------|-----|
|Description|Shows whether the campaign response is open, closed, or canceled. Closed and canceled campaign responses are read-only and can't be edited.|
|DisplayName|Status|
|IsValidForCreate|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|statecode|
|RequiredLevel|SystemRequired|
|Type|State|

#### StateCode Choices/Options

|Value|Label|DefaultStatus|InvariantName|
|-----|-----|-------------|-------------|
|0|Open|1|Open|
|1|Closed|2|Closed|
|2|Canceled|3|Canceled|



### <a name="BKMK_StatusCode"></a> StatusCode

|Property|Value|
|--------|-----|
|Description|Select the campaign response's status.|
|DisplayName|Status Reason|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|statuscode|
|RequiredLevel|None|
|Type|Status|

#### StatusCode Choices/Options

|Value|Label|State|
|-----|-----|-----|
|1|Open|0|
|2|Closed|1|
|3|Canceled|2|



### <a name="BKMK_Subcategory"></a> Subcategory

|Property|Value|
|--------|-----|
|Description|Type a subcategory to identify the campaign response type and relate the activity to a specific product, sales region, business group, or other function.|
|DisplayName|Sub-Category|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|subcategory|
|MaxLength|250|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_Subject"></a> Subject

|Property|Value|
|--------|-----|
|Description|Type a short description about the objective or primary topic of the campaign response.|
|DisplayName|Subject|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|subject|
|MaxLength|200|
|RequiredLevel|ApplicationRequired|
|Type|String|


### <a name="BKMK_Telephone"></a> Telephone

|Property|Value|
|--------|-----|
|Description|Type the responder's primary phone number.|
|DisplayName|Phone|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|telephone|
|MaxLength|50|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_TimeZoneRuleVersionNumber"></a> TimeZoneRuleVersionNumber

|Property|Value|
|--------|-----|
|Description|For internal use only.|
|DisplayName|Time Zone Rule Version Number|
|Format|None|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|timezoneruleversionnumber|
|MaxValue|2147483647|
|MinValue|-1|
|RequiredLevel|None|
|Type|Integer|


### <a name="BKMK_To"></a> To

|Property|Value|
|--------|-----|
|Description|Person who is the receiver of the activity.|
|DisplayName|To|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|to|
|RequiredLevel|None|
|Targets|account,contact,systemuser|
|Type|PartyList|


### <a name="BKMK_TransactionCurrencyId"></a> TransactionCurrencyId

|Property|Value|
|--------|-----|
|Description|Choose the local currency for the record to make sure budgets are reported in the correct currency.|
|DisplayName|Currency|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|transactioncurrencyid|
|RequiredLevel|None|
|Targets|transactioncurrency|
|Type|Lookup|


### <a name="BKMK_TraversedPath"></a> TraversedPath

|Property|Value|
|--------|-----|
|Description|For internal use only.|
|DisplayName|(Deprecated) Traversed Path|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|traversedpath|
|MaxLength|1250|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_UTCConversionTimeZoneCode"></a> UTCConversionTimeZoneCode

|Property|Value|
|--------|-----|
|Description|Time zone code that was in use when the record was created.|
|DisplayName|UTC Conversion Time Zone Code|
|Format|None|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|utcconversiontimezonecode|
|MaxValue|2147483647|
|MinValue|-1|
|RequiredLevel|None|
|Type|Integer|


### <a name="BKMK_YomiCompanyName"></a> YomiCompanyName

|Property|Value|
|--------|-----|
|Description|Type the phonetic spelling of the company name, if specified in Japanese, to make sure the name is pronounced correctly in phone calls and other communications.|
|DisplayName|Yomi Company Name|
|FormatName|PhoneticGuide|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|yomicompanyname|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_YomiFirstName"></a> YomiFirstName

|Property|Value|
|--------|-----|
|Description|Type the phonetic spelling of the campaign responder's first name, if specified in Japanese, to make sure the name is pronounced correctly in phone calls and other communications.|
|DisplayName|Yomi First Name|
|FormatName|PhoneticGuide|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|yomifirstname|
|MaxLength|150|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_YomiLastName"></a> YomiLastName

|Property|Value|
|--------|-----|
|Description|Type the phonetic spelling of the campaign responder's last name, if specified in Japanese, to make sure the name is pronounced correctly in phone calls and other communications.|
|DisplayName|Yomi Last Name|
|FormatName|PhoneticGuide|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|yomilastname|
|MaxLength|150|
|RequiredLevel|None|
|Type|String|

<a name="read-only-attributes"></a>

## Read-only columns/attributes

These columns/attributes return false for both **IsValidForCreate** or **IsValidForUpdate**. Listed by **SchemaName**.

- [ActivityTypeCode](#BKMK_ActivityTypeCode)
- [CreatedBy](#BKMK_CreatedBy)
- [CreatedByName](#BKMK_CreatedByName)
- [CreatedByYomiName](#BKMK_CreatedByYomiName)
- [CreatedOn](#BKMK_CreatedOn)
- [CreatedOnBehalfBy](#BKMK_CreatedOnBehalfBy)
- [CreatedOnBehalfByName](#BKMK_CreatedOnBehalfByName)
- [CreatedOnBehalfByYomiName](#BKMK_CreatedOnBehalfByYomiName)
- [DeliveryLastAttemptedOn](#BKMK_DeliveryLastAttemptedOn)
- [ExchangeRate](#BKMK_ExchangeRate)
- [InstanceTypeCode](#BKMK_InstanceTypeCode)
- [IsRegularActivity](#BKMK_IsRegularActivity)
- [ModifiedBy](#BKMK_ModifiedBy)
- [ModifiedByName](#BKMK_ModifiedByName)
- [ModifiedByYomiName](#BKMK_ModifiedByYomiName)
- [ModifiedOn](#BKMK_ModifiedOn)
- [ModifiedOnBehalfBy](#BKMK_ModifiedOnBehalfBy)
- [ModifiedOnBehalfByName](#BKMK_ModifiedOnBehalfByName)
- [ModifiedOnBehalfByYomiName](#BKMK_ModifiedOnBehalfByYomiName)
- [OnHoldTime](#BKMK_OnHoldTime)
- [OriginatingActivityIdYomiName](#BKMK_OriginatingActivityIdYomiName)
- [OriginatingActivityName](#BKMK_OriginatingActivityName)
- [OwnerIdName](#BKMK_OwnerIdName)
- [OwnerIdYomiName](#BKMK_OwnerIdYomiName)
- [OwningBusinessUnit](#BKMK_OwningBusinessUnit)
- [OwningBusinessUnitName](#BKMK_OwningBusinessUnitName)
- [OwningTeam](#BKMK_OwningTeam)
- [OwningUser](#BKMK_OwningUser)
- [PostponeActivityProcessingUntil](#BKMK_PostponeActivityProcessingUntil)
- [RegardingObjectIdName](#BKMK_RegardingObjectIdName)
- [RegardingObjectIdYomiName](#BKMK_RegardingObjectIdYomiName)
- [ScheduledDurationMinutes](#BKMK_ScheduledDurationMinutes)
- [SenderMailboxId](#BKMK_SenderMailboxId)
- [SenderMailboxIdName](#BKMK_SenderMailboxIdName)
- [SentOn](#BKMK_SentOn)
- [SeriesId](#BKMK_SeriesId)
- [SLAInvokedId](#BKMK_SLAInvokedId)
- [SLAInvokedIdName](#BKMK_SLAInvokedIdName)
- [SLAName](#BKMK_SLAName)
- [TransactionCurrencyIdName](#BKMK_TransactionCurrencyIdName)
- [VersionNumber](#BKMK_VersionNumber)


### <a name="BKMK_ActivityTypeCode"></a> ActivityTypeCode

|Property|Value|
|--------|-----|
|Description|Type of activity.|
|DisplayName|Activity Type|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|activitytypecode|
|RequiredLevel|SystemRequired|
|Type|EntityName|


### <a name="BKMK_CreatedBy"></a> CreatedBy

|Property|Value|
|--------|-----|
|Description|Unique identifier of the user who created the activity.|
|DisplayName|Created By|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|createdby|
|RequiredLevel|None|
|Targets|systemuser|
|Type|Lookup|


### <a name="BKMK_CreatedByName"></a> CreatedByName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|createdbyname|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_CreatedByYomiName"></a> CreatedByYomiName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|createdbyyominame|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_CreatedOn"></a> CreatedOn

|Property|Value|
|--------|-----|
|DateTimeBehavior|UserLocal|
|Description|Date and time when the activity was created.|
|DisplayName|Date Created|
|Format|DateAndTime|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|createdon|
|RequiredLevel|None|
|Type|DateTime|


### <a name="BKMK_CreatedOnBehalfBy"></a> CreatedOnBehalfBy

|Property|Value|
|--------|-----|
|Description|Unique identifier of the delegate user who created the activitypointer.|
|DisplayName|Created By (Delegate)|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|createdonbehalfby|
|RequiredLevel|None|
|Targets|systemuser|
|Type|Lookup|


### <a name="BKMK_CreatedOnBehalfByName"></a> CreatedOnBehalfByName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|createdonbehalfbyname|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_CreatedOnBehalfByYomiName"></a> CreatedOnBehalfByYomiName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|createdonbehalfbyyominame|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_DeliveryLastAttemptedOn"></a> DeliveryLastAttemptedOn

|Property|Value|
|--------|-----|
|DateTimeBehavior|UserLocal|
|Description|Date and time when the delivery of the activity was last attempted.|
|DisplayName|Date Delivery Last Attempted|
|Format|DateAndTime|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|deliverylastattemptedon|
|RequiredLevel|None|
|Type|DateTime|


### <a name="BKMK_ExchangeRate"></a> ExchangeRate

|Property|Value|
|--------|-----|
|Description|Shows the conversion rate of the record's currency. The exchange rate is used to convert all money fields in the record from the local currency to the system's default currency.|
|DisplayName|Exchange Rate|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|exchangerate|
|MaxValue|100000000000|
|MinValue|0.000000000001|
|Precision|12|
|RequiredLevel|None|
|Type|Decimal|


### <a name="BKMK_InstanceTypeCode"></a> InstanceTypeCode

|Property|Value|
|--------|-----|
|Description|Type of instance of a recurring series.|
|DisplayName|Recurring Instance Type|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|instancetypecode|
|RequiredLevel|SystemRequired|
|Type|Picklist|

#### InstanceTypeCode Choices/Options

|Value|Label|Description|
|-----|-----|--------|
|0|Not Recurring||
|1|Recurring Master||
|2|Recurring Instance||
|3|Recurring Exception||
|4|Recurring Future Exception||



### <a name="BKMK_IsRegularActivity"></a> IsRegularActivity

|Property|Value|
|--------|-----|
|Description|Information regarding whether the activity is a regular activity type or event type.|
|DisplayName|Is Regular Activity|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|isregularactivity|
|RequiredLevel|SystemRequired|
|Type|Boolean|

#### IsRegularActivity Choices/Options

|Value|Label|Description|
|-----|-----|--------|
|1|Yes||
|0|No||

**DefaultValue**: 0



### <a name="BKMK_ModifiedBy"></a> ModifiedBy

|Property|Value|
|--------|-----|
|Description|Unique identifier of user who last modified the activity.|
|DisplayName|Modified By|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|modifiedby|
|RequiredLevel|None|
|Targets|systemuser|
|Type|Lookup|


### <a name="BKMK_ModifiedByName"></a> ModifiedByName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|modifiedbyname|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_ModifiedByYomiName"></a> ModifiedByYomiName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|modifiedbyyominame|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_ModifiedOn"></a> ModifiedOn

|Property|Value|
|--------|-----|
|DateTimeBehavior|UserLocal|
|Description|Date and time when activity was last modified.|
|DisplayName|Last Updated|
|Format|DateAndTime|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|modifiedon|
|RequiredLevel|None|
|Type|DateTime|


### <a name="BKMK_ModifiedOnBehalfBy"></a> ModifiedOnBehalfBy

|Property|Value|
|--------|-----|
|Description|Unique identifier of the delegate user who last modified the activitypointer.|
|DisplayName|Modified By (Delegate)|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|modifiedonbehalfby|
|RequiredLevel|None|
|Targets|systemuser|
|Type|Lookup|


### <a name="BKMK_ModifiedOnBehalfByName"></a> ModifiedOnBehalfByName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|modifiedonbehalfbyname|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_ModifiedOnBehalfByYomiName"></a> ModifiedOnBehalfByYomiName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|modifiedonbehalfbyyominame|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_OnHoldTime"></a> OnHoldTime

|Property|Value|
|--------|-----|
|Description|Shows how long, in minutes, that the record was on hold.|
|DisplayName|On Hold Time (Minutes)|
|Format|None|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|onholdtime|
|MaxValue|2147483647|
|MinValue|-2147483648|
|RequiredLevel|None|
|Type|Integer|


### <a name="BKMK_OriginatingActivityIdYomiName"></a> OriginatingActivityIdYomiName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|originatingactivityidyominame|
|MaxLength|4000|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_OriginatingActivityName"></a> OriginatingActivityName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|originatingactivityname|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_OwnerIdName"></a> OwnerIdName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|owneridname|
|MaxLength|100|
|RequiredLevel|SystemRequired|
|Type|String|


### <a name="BKMK_OwnerIdYomiName"></a> OwnerIdYomiName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|owneridyominame|
|MaxLength|100|
|RequiredLevel|SystemRequired|
|Type|String|


### <a name="BKMK_OwningBusinessUnit"></a> OwningBusinessUnit

|Property|Value|
|--------|-----|
|Description|Unique identifier of the business unit that owns the activity.|
|DisplayName|Owning Business Unit|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|owningbusinessunit|
|RequiredLevel|None|
|Targets|businessunit|
|Type|Lookup|


### <a name="BKMK_OwningBusinessUnitName"></a> OwningBusinessUnitName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|owningbusinessunitname|
|MaxLength|160|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_OwningTeam"></a> OwningTeam

|Property|Value|
|--------|-----|
|Description|Unique identifier of the team that owns the activity.|
|DisplayName|Owning Team|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|owningteam|
|RequiredLevel|None|
|Targets|team|
|Type|Lookup|


### <a name="BKMK_OwningUser"></a> OwningUser

|Property|Value|
|--------|-----|
|Description|Unique identifier of the user that owns the activity.|
|DisplayName|Owning User|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|owninguser|
|RequiredLevel|None|
|Targets|systemuser|
|Type|Lookup|


### <a name="BKMK_PostponeActivityProcessingUntil"></a> PostponeActivityProcessingUntil

|Property|Value|
|--------|-----|
|DateTimeBehavior|UserLocal|
|Description|For internal use only.|
|DisplayName|Delay activity processing until|
|Format|DateAndTime|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|postponeactivityprocessinguntil|
|RequiredLevel|None|
|Type|DateTime|


### <a name="BKMK_RegardingObjectIdName"></a> RegardingObjectIdName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|regardingobjectidname|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_RegardingObjectIdYomiName"></a> RegardingObjectIdYomiName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|regardingobjectidyominame|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_ScheduledDurationMinutes"></a> ScheduledDurationMinutes

|Property|Value|
|--------|-----|
|Description|Scheduled duration of the campaign response in minutes.|
|DisplayName|Scheduled Duration|
|Format|None|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|scheduleddurationminutes|
|MaxValue|2147483647|
|MinValue|0|
|RequiredLevel|None|
|Type|Integer|


### <a name="BKMK_SenderMailboxId"></a> SenderMailboxId

|Property|Value|
|--------|-----|
|Description|Unique identifier of the mailbox associated with the sender of the email message.|
|DisplayName|Sender's Mailbox|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|sendermailboxid|
|RequiredLevel|None|
|Targets|mailbox|
|Type|Lookup|


### <a name="BKMK_SenderMailboxIdName"></a> SenderMailboxIdName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|sendermailboxidname|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_SentOn"></a> SentOn

|Property|Value|
|--------|-----|
|DateTimeBehavior|UserLocal|
|Description|Date and time when the activity was sent.|
|DisplayName|Date Sent|
|Format|DateAndTime|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|senton|
|RequiredLevel|None|
|Type|DateTime|


### <a name="BKMK_SeriesId"></a> SeriesId

|Property|Value|
|--------|-----|
|Description|Uniqueidentifier specifying the id of recurring series of an instance.|
|DisplayName|Series Id|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|seriesid|
|RequiredLevel|None|
|Type|Uniqueidentifier|


### <a name="BKMK_SLAInvokedId"></a> SLAInvokedId

|Property|Value|
|--------|-----|
|Description|Last SLA that was applied to this case. This field is for internal use only.|
|DisplayName|Last SLA applied|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|slainvokedid|
|RequiredLevel|None|
|Targets|sla|
|Type|Lookup|


### <a name="BKMK_SLAInvokedIdName"></a> SLAInvokedIdName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|slainvokedidname|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_SLAName"></a> SLAName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|slaname|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_TransactionCurrencyIdName"></a> TransactionCurrencyIdName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|transactioncurrencyidname|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_VersionNumber"></a> VersionNumber

|Property|Value|
|--------|-----|
|Description|Version number of the activity.|
|DisplayName|Version Number|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|versionnumber|
|MaxValue|9223372036854775807|
|MinValue|-9223372036854775808|
|RequiredLevel|None|
|Type|BigInt|

<a name="onetomany"></a>

## One-To-Many Relationships

Listed by **SchemaName**.


### <a name="BKMK_CampaignResponse_Lead"></a> CampaignResponse_Lead

Same as the [CampaignResponse_Lead](lead.md#BKMK_CampaignResponse_Lead) many-to-one relationship for the [lead](lead.md) table/entity.

|Property|Value|
|--------|-----|
|ReferencingEntity|lead|
|ReferencingAttribute|relatedobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|CampaignResponse_Lead|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: RemoveLink<br />Merge: Cascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|

<a name="manytoone"></a>

## Many-To-One Relationships

Each Many-To-One relationship is defined by a corresponding One-To-Many relationship with the related table. Listed by **SchemaName**.

- [lead_CampaignResponses](#BKMK_lead_CampaignResponses)
- [Campaign_CampaignResponses](#BKMK_Campaign_CampaignResponses)
- [campaignactivity_CampaignResponses](#BKMK_campaignactivity_CampaignResponses)
- [account_CampaignResponses](#BKMK_account_CampaignResponses)
- [contact_CampaignResponses](#BKMK_contact_CampaignResponses)
- [BulkOperation_CampaignResponse](#BKMK_BulkOperation_CampaignResponse)
- [CampaignResponse_OpportunityCloses](#BKMK_CampaignResponse_OpportunityCloses)
- [CampaignResponse_OrderCloses](#BKMK_CampaignResponse_OrderCloses)
- [CampaignResponse_QuoteCloses](#BKMK_CampaignResponse_QuoteCloses)


### <a name="BKMK_lead_CampaignResponses"></a> lead_CampaignResponses

**Added by**: Lead Management Solution

See the [lead_CampaignResponses](lead.md#BKMK_lead_CampaignResponses) one-to-many relationship for the [lead](lead.md) table/entity.

### <a name="BKMK_Campaign_CampaignResponses"></a> Campaign_CampaignResponses

See the [Campaign_CampaignResponses](campaign.md#BKMK_Campaign_CampaignResponses) one-to-many relationship for the [campaign](campaign.md) table/entity.

### <a name="BKMK_campaignactivity_CampaignResponses"></a> campaignactivity_CampaignResponses

See the [campaignactivity_CampaignResponses](campaignactivity.md#BKMK_campaignactivity_CampaignResponses) one-to-many relationship for the [campaignactivity](campaignactivity.md) table/entity.

### <a name="BKMK_account_CampaignResponses"></a> account_CampaignResponses

**Added by**: System Solution Solution

See the [account_CampaignResponses](account.md#BKMK_account_CampaignResponses) one-to-many relationship for the [account](account.md) table/entity.

### <a name="BKMK_contact_CampaignResponses"></a> contact_CampaignResponses

**Added by**: System Solution Solution

See the [contact_CampaignResponses](contact.md#BKMK_contact_CampaignResponses) one-to-many relationship for the [contact](contact.md) table/entity.

### <a name="BKMK_BulkOperation_CampaignResponse"></a> BulkOperation_CampaignResponse

See the [BulkOperation_CampaignResponse](bulkoperation.md#BKMK_BulkOperation_CampaignResponse) one-to-many relationship for the [bulkoperation](bulkoperation.md) table/entity.

### <a name="BKMK_CampaignResponse_OpportunityCloses"></a> CampaignResponse_OpportunityCloses

**Added by**: Sales Solution

See the [CampaignResponse_OpportunityCloses](opportunityclose.md#BKMK_CampaignResponse_OpportunityCloses) one-to-many relationship for the [opportunityclose](opportunityclose.md) table/entity.

### <a name="BKMK_CampaignResponse_OrderCloses"></a> CampaignResponse_OrderCloses

**Added by**: Sales Solution

See the [CampaignResponse_OrderCloses](orderclose.md#BKMK_CampaignResponse_OrderCloses) one-to-many relationship for the [orderclose](orderclose.md) table/entity.

### <a name="BKMK_CampaignResponse_QuoteCloses"></a> CampaignResponse_QuoteCloses

**Added by**: Sales Solution

See the [CampaignResponse_QuoteCloses](quoteclose.md#BKMK_CampaignResponse_QuoteCloses) one-to-many relationship for the [quoteclose](quoteclose.md) table/entity.

### See also

[About the table reference](../about-entity-reference.md)<br />
[Web API Reference](/power-apps/developer/data-platform/webapi/reference/entitytypes)<br />
