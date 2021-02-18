---
title: "Email Entity Reference (Dynamics 365 Customer Engagement)| MicrosoftDocs"
description: "Includes schema information and supported messages for the Email entity."
ms.date: 04/02/2019
ms.service: "crm-online"
ms.topic: "reference"
ms.assetid: 3948cc48-07c8-7f60-0608-71c37158ad7c
author: "KumarVivek"
ms.author: "kvivek"
manager: "annbe"
search.audienceType: 
  - developer

---
# Email Entity Reference

Activity that is delivered using email protocols.


## Messages

|Message|Web API Operation|SDK Assembly|
|-|-|-|
|Assign|PATCH [*org URI*]/api/data/v9.0/emails(*activityid*)<br />[Update](/powerapps/developer/common-data-service/webapi/update-delete-entities-using-web-api#basic-update) `ownerid` property.|<xref:Microsoft.Crm.Sdk.Messages.AssignRequest>|
|BackgroundSendEmail|<xref href="Microsoft.Dynamics.CRM.BackgroundSendEmail?text=BackgroundSendEmail Action" />|<xref:Microsoft.Crm.Sdk.Messages.BackgroundSendEmailRequest>|
|CheckIncomingEmail|<xref href="Microsoft.Dynamics.CRM.CheckIncomingEmail?text=CheckIncomingEmail Function" />|<xref:Microsoft.Crm.Sdk.Messages.CheckIncomingEmailRequest>|
|CheckPromoteEmail|<xref href="Microsoft.Dynamics.CRM.CheckPromoteEmail?text=CheckPromoteEmail Function" />|<xref:Microsoft.Crm.Sdk.Messages.CheckPromoteEmailRequest>|
|Create|POST [*org URI*]/api/data/v9.0/emails<br />See [Create](/powerapps/developer/common-data-service/webapi/create-entity-web-api)|<xref:Microsoft.Xrm.Sdk.Messages.CreateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Create*>|
|Delete|DELETE [*org URI*]/api/data/v9.0/emails(*activityid*)<br />See [Delete](/powerapps/developer/common-data-service/webapi/update-delete-entities-using-web-api#basic-delete)|<xref:Microsoft.Xrm.Sdk.Messages.DeleteRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Delete*>|
|DeliverIncomingEmail|<xref href="Microsoft.Dynamics.CRM.DeliverIncomingEmail?text=DeliverIncomingEmail Action" />|<xref:Microsoft.Crm.Sdk.Messages.DeliverIncomingEmailRequest>|
|DeliverPromoteEmail|<xref href="Microsoft.Dynamics.CRM.DeliverPromoteEmail?text=DeliverPromoteEmail Action" />|<xref:Microsoft.Crm.Sdk.Messages.DeliverPromoteEmailRequest>|
|GetTrackingTokenEmail|<xref href="Microsoft.Dynamics.CRM.GetTrackingTokenEmail?text=GetTrackingTokenEmail Action" />|<xref:Microsoft.Crm.Sdk.Messages.GetTrackingTokenEmailRequest>|
|GrantAccess|<xref href="Microsoft.Dynamics.CRM.GrantAccess?text=GrantAccess Action" />|<xref:Microsoft.Crm.Sdk.Messages.GrantAccessRequest>|
|ModifyAccess|<xref href="Microsoft.Dynamics.CRM.ModifyAccess?text=ModifyAccess Action" />|<xref:Microsoft.Crm.Sdk.Messages.ModifyAccessRequest>|
|ProcessInboundEmail|<xref href="Microsoft.Dynamics.CRM.ProcessInboundEmail?text=ProcessInboundEmail Action" />|<xref:Microsoft.Crm.Sdk.Messages.ProcessInboundEmailRequest>|
|PropagateByExpression|<xref href="Microsoft.Dynamics.CRM.PropagateByExpression?text=PropagateByExpression Action" />|<xref:Microsoft.Crm.Sdk.Messages.PropagateByExpressionRequest>|
|Retrieve|GET [*org URI*]/api/data/v9.0/emails(*activityid*)<br />See [Retrieve](/powerapps/developer/common-data-service/webapi/retrieve-entity-using-web-api)|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Retrieve*>|
|RetrieveMultiple|GET [*org URI*]/api/data/v9.0/emails<br />See [Query Data](/powerapps/developer/common-data-service/webapi/query-data-web-api)|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveMultipleRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.RetrieveMultiple*>|
|RetrievePrincipalAccess|<xref href="Microsoft.Dynamics.CRM.RetrievePrincipalAccess?text=RetrievePrincipalAccess Function" />|<xref:Microsoft.Crm.Sdk.Messages.RetrievePrincipalAccessRequest>|
|RetrieveSharedPrincipalsAndAccess|<xref href="Microsoft.Dynamics.CRM.RetrieveSharedPrincipalsAndAccess?text=RetrieveSharedPrincipalsAndAccess Function" />|<xref:Microsoft.Crm.Sdk.Messages.RetrieveSharedPrincipalsAndAccessRequest>|
|RevokeAccess|<xref href="Microsoft.Dynamics.CRM.RevokeAccess?text=RevokeAccess Action" />|<xref:Microsoft.Crm.Sdk.Messages.RevokeAccessRequest>|
|SendEmail|<xref href="Microsoft.Dynamics.CRM.SendEmail?text=SendEmail Action" />|<xref:Microsoft.Crm.Sdk.Messages.SendEmailRequest>|
|SendEmailFromTemplate|<xref href="Microsoft.Dynamics.CRM.SendEmailFromTemplate?text=SendEmailFromTemplate Action" />|<xref:Microsoft.Crm.Sdk.Messages.SendEmailFromTemplateRequest>|
|SendFax|<xref href="Microsoft.Dynamics.CRM.SendFax?text=SendFax Action" />|<xref:Microsoft.Crm.Sdk.Messages.SendFaxRequest>|
|SendTemplate|<xref href="Microsoft.Dynamics.CRM.SendTemplate?text=SendTemplate Action" />|<xref:Microsoft.Crm.Sdk.Messages.SendTemplateRequest>|
|SetState|PATCH [*org URI*]/api/data/v9.0/emails(*activityid*)<br />[Update](/powerapps/developer/common-data-service/webapi/update-delete-entities-using-web-api#basic-update) `statecode` and `statuscode` properties.|<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|
|Update|PATCH [*org URI*]/api/data/v9.0/emails(*activityid*)<br />See [Update](/powerapps/developer/common-data-service/webapi/update-delete-entities-using-web-api#basic-update)|<xref:Microsoft.Xrm.Sdk.Messages.UpdateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Update*>|

## Entity Properties

|Property|Value|
|--------|-----|
|CollectionSchemaName|Emails|
|DisplayCollectionName|Email Messages|
|DisplayName|Email|
|EntitySetName|emails|
|IsBPFEntity|False|
|LogicalCollectionName|emails|
|LogicalName|email|
|OwnershipType|UserOwned|
|PrimaryIdAttribute|activityid|
|PrimaryNameAttribute|subject|
|SchemaName|Email|

<a name="writable-attributes"></a>

## Writable attributes

These attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [ActivityAdditionalParams](#BKMK_ActivityAdditionalParams)
- [ActivityId](#BKMK_ActivityId)
- [ActualDurationMinutes](#BKMK_ActualDurationMinutes)
- [ActualEnd](#BKMK_ActualEnd)
- [ActualStart](#BKMK_ActualStart)
- [AttachmentOpenCount](#BKMK_AttachmentOpenCount)
- [BaseConversationIndexHash](#BKMK_BaseConversationIndexHash)
- [bcc](#BKMK_bcc)
- [Category](#BKMK_Category)
- [cc](#BKMK_cc)
- [ConversationTrackingId](#BKMK_ConversationTrackingId)
- [DelayedEmailSendTime](#BKMK_DelayedEmailSendTime)
- [DeliveryAttempts](#BKMK_DeliveryAttempts)
- [DeliveryPriorityCode](#BKMK_DeliveryPriorityCode)
- [DeliveryReceiptRequested](#BKMK_DeliveryReceiptRequested)
- [Description](#BKMK_Description)
- [DirectionCode](#BKMK_DirectionCode)
- [EmailReminderExpiryTime](#BKMK_EmailReminderExpiryTime)
- [EmailReminderText](#BKMK_EmailReminderText)
- [EmailReminderType](#BKMK_EmailReminderType)
- [EmailSenderName](#BKMK_EmailSenderName)
- [EmailTrackingId](#BKMK_EmailTrackingId)
- [FollowEmailUserPreference](#BKMK_FollowEmailUserPreference)
- [from](#BKMK_from)
- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [IsBilled](#BKMK_IsBilled)
- [IsWorkflowCreated](#BKMK_IsWorkflowCreated)
- [LastOnHoldTime](#BKMK_LastOnHoldTime)
- [LastOpenedTime](#BKMK_LastOpenedTime)
- [LinksClickedCount](#BKMK_LinksClickedCount)
- [MessageId](#BKMK_MessageId)
- [MessageIdDupCheck](#BKMK_MessageIdDupCheck)
- [MimeType](#BKMK_MimeType)
- [Notifications](#BKMK_Notifications)
- [OpenCount](#BKMK_OpenCount)
- [OverriddenCreatedOn](#BKMK_OverriddenCreatedOn)
- [OwnerId](#BKMK_OwnerId)
- [OwnerIdType](#BKMK_OwnerIdType)
- [ParentActivityId](#BKMK_ParentActivityId)
- [PriorityCode](#BKMK_PriorityCode)
- [ProcessId](#BKMK_ProcessId)
- [ReadReceiptRequested](#BKMK_ReadReceiptRequested)
- [RegardingObjectId](#BKMK_RegardingObjectId)
- [RegardingObjectTypeCode](#BKMK_RegardingObjectTypeCode)
- [ReminderActionCardId](#BKMK_ReminderActionCardId)
- [ScheduledEnd](#BKMK_ScheduledEnd)
- [ScheduledStart](#BKMK_ScheduledStart)
- [Sender](#BKMK_Sender)
- [SendersAccountName](#BKMK_SendersAccountName)
- [ServiceId](#BKMK_ServiceId)
- [SLAId](#BKMK_SLAId)
- [SortDate](#BKMK_SortDate)
- [StageId](#BKMK_StageId)
- [StateCode](#BKMK_StateCode)
- [StatusCode](#BKMK_StatusCode)
- [Subcategory](#BKMK_Subcategory)
- [Subject](#BKMK_Subject)
- [SubmittedBy](#BKMK_SubmittedBy)
- [TemplateId](#BKMK_TemplateId)
- [TimeZoneRuleVersionNumber](#BKMK_TimeZoneRuleVersionNumber)
- [to](#BKMK_to)
- [ToRecipients](#BKMK_ToRecipients)
- [TrackingToken](#BKMK_TrackingToken)
- [TransactionCurrencyId](#BKMK_TransactionCurrencyId)
- [TraversedPath](#BKMK_TraversedPath)
- [UTCConversionTimeZoneCode](#BKMK_UTCConversionTimeZoneCode)


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
|Description|Unique identifier of the email activity.|
|DisplayName|Email Message|
|IsValidForForm|False|
|IsValidForRead|True|
|IsValidForUpdate|False|
|LogicalName|activityid|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|


### <a name="BKMK_ActualDurationMinutes"></a> ActualDurationMinutes

|Property|Value|
|--------|-----|
|Description|Type the number of minutes spent creating and sending the email. The duration is used in reporting.|
|DisplayName|Duration|
|Format|Duration|
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
|Description|Enter the actual end date and time of the email. By default, it displays the date and time when the activity was completed or canceled, but can be edited to capture the actual time to create and send the email.|
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
|Description|Enter the actual start date and time for the email. By default, it displays the date and time when the activity was created, but can be edited to capture the actual time to create and send the email.|
|DisplayName|Actual Start|
|Format|DateOnly|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|actualstart|
|RequiredLevel|None|
|Type|DateTime|


### <a name="BKMK_AttachmentOpenCount"></a> AttachmentOpenCount

|Property|Value|
|--------|-----|
|Description|Shows the number of times an email attachment has been viewed.|
|DisplayName|Attachment Open Count|
|Format|None|
|IsValidForCreate|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|attachmentopencount|
|MaxValue|2147483647|
|MinValue|0|
|RequiredLevel|None|
|Type|Integer|


### <a name="BKMK_BaseConversationIndexHash"></a> BaseConversationIndexHash

|Property|Value|
|--------|-----|
|Description|Hash of base of conversation index.|
|DisplayName|Conversation Index (Hash)|
|Format|None|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|baseconversationindexhash|
|MaxValue|2147483647|
|MinValue|-2147483648|
|RequiredLevel|None|
|Type|Integer|


### <a name="BKMK_bcc"></a> bcc

|Property|Value|
|--------|-----|
|Description|Enter the recipients that are included on the email distribution, but are not displayed to other recipients.|
|DisplayName|Bcc|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|bcc|
|RequiredLevel|None|
|Targets|account,contact,entitlement,equipment,knowledgearticle,lead,queue,systemuser,unresolvedaddress|
|Type|PartyList|


### <a name="BKMK_Category"></a> Category

|Property|Value|
|--------|-----|
|Description|Type a category to identify the email type, such as lead outreach, customer follow-up, or service alert, to tie the email to a business group or function.|
|DisplayName|Category|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|category|
|MaxLength|250|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_cc"></a> cc

|Property|Value|
|--------|-----|
|Description|Enter the recipients that should be copied on the email.|
|DisplayName|Cc|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|cc|
|RequiredLevel|None|
|Targets|account,contact,entitlement,equipment,knowledgearticle,lead,queue,systemuser,unresolvedaddress|
|Type|PartyList|


### <a name="BKMK_ConversationTrackingId"></a> ConversationTrackingId

|Property|Value|
|--------|-----|
|Description|Conversation Tracking Id.|
|DisplayName|Conversation Tracking Id|
|IsValidForForm|False|
|IsValidForRead|True|
|IsValidForUpdate|False|
|LogicalName|conversationtrackingid|
|RequiredLevel|None|
|Type|Uniqueidentifier|


### <a name="BKMK_DelayedEmailSendTime"></a> DelayedEmailSendTime

|Property|Value|
|--------|-----|
|DateTimeBehavior|UserLocal|
|Description|Enter the expected date and time when email will be sent.|
|DisplayName|Send Later|
|Format|DateAndTime|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|delayedemailsendtime|
|RequiredLevel|None|
|Type|DateTime|


### <a name="BKMK_DeliveryAttempts"></a> DeliveryAttempts

|Property|Value|
|--------|-----|
|Description|Shows the count of the number of attempts made to send the email. The count is used as an indicator of email routing issues.|
|DisplayName|No. of Delivery Attempts|
|Format|None|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|deliveryattempts|
|MaxValue|1000000000|
|MinValue|0|
|RequiredLevel|None|
|Type|Integer|


### <a name="BKMK_DeliveryPriorityCode"></a> DeliveryPriorityCode

|Property|Value|
|--------|-----|
|Description|Select the priority of delivery of the email to the email server.|
|DisplayName|Delivery Priority|
|IsValidForForm|True|
|IsValidForRead|True|
|IsValidForUpdate|False|
|LogicalName|deliveryprioritycode|
|RequiredLevel|None|
|Type|Picklist|

#### DeliveryPriorityCode Options

|Value|Label|
|-----|-----|
|0|Low|
|1|Normal|
|2|High|



### <a name="BKMK_DeliveryReceiptRequested"></a> DeliveryReceiptRequested

|Property|Value|
|--------|-----|
|Description|Select whether the sender should receive confirmation that the email was delivered.|
|DisplayName|Delivery Receipt Requested|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|deliveryreceiptrequested|
|RequiredLevel|None|
|Type|Boolean|

#### DeliveryReceiptRequested Options

|Value|Label|
|-----|-----|
|1|Yes|
|0|No|

**DefaultValue**: False



### <a name="BKMK_Description"></a> Description

|Property|Value|
|--------|-----|
|Description|Type the greeting and message text of the email.|
|DisplayName|Description|
|Format|Email|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|description|
|MaxLength|1073741823|
|RequiredLevel|None|
|Type|Memo|


### <a name="BKMK_DirectionCode"></a> DirectionCode

|Property|Value|
|--------|-----|
|Description|Select the direction of the email as incoming or outbound.|
|DisplayName|Direction|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|directioncode|
|RequiredLevel|None|
|Type|Boolean|

#### DirectionCode Options

|Value|Label|
|-----|-----|
|1|Outgoing|
|0|Incoming|

**DefaultValue**: True



### <a name="BKMK_EmailReminderExpiryTime"></a> EmailReminderExpiryTime

|Property|Value|
|--------|-----|
|DateTimeBehavior|UserLocal|
|Description|Shows the date and time when an email reminder expires.|
|DisplayName|Email Reminder Expiry Time|
|Format|DateAndTime|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|emailreminderexpirytime|
|RequiredLevel|None|
|Type|DateTime|


### <a name="BKMK_EmailReminderText"></a> EmailReminderText

|Property|Value|
|--------|-----|
|Description|For internal use only.|
|DisplayName|Email Reminder Text|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|emailremindertext|
|MaxLength|1250|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_EmailReminderType"></a> EmailReminderType

|Property|Value|
|--------|-----|
|Description|Shows the type of the email reminder.|
|DisplayName|Email Reminder Type|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|emailremindertype|
|RequiredLevel|None|
|Type|Picklist|

#### EmailReminderType Options

|Value|Label|
|-----|-----|
|0|If I do not receive a reply by|
|1|If the email is not opened by|
|2|Remind me anyways at|



### <a name="BKMK_EmailSenderName"></a> EmailSenderName

|Property|Value|
|--------|-----|
|Description|Shows the name of the sender of the email.|
|DisplayName|Email Sender Name|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|IsValidForUpdate|False|
|LogicalName|emailsendername|
|MaxLength|400|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_EmailTrackingId"></a> EmailTrackingId

|Property|Value|
|--------|-----|
|Description|Email Tracking Id.|
|DisplayName|Email Tracking Id|
|IsValidForForm|False|
|IsValidForRead|True|
|IsValidForUpdate|False|
|LogicalName|emailtrackingid|
|RequiredLevel|None|
|Type|Uniqueidentifier|


### <a name="BKMK_FollowEmailUserPreference"></a> FollowEmailUserPreference

|Property|Value|
|--------|-----|
|Description|Select whether the email allows following recipient activities sent from Microsoft Dynamics 365.This is user preference state which can be overridden by system evaluated state.|
|DisplayName|Following|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|followemailuserpreference|
|RequiredLevel|None|
|Type|Boolean|

#### FollowEmailUserPreference Options

|Value|Label|
|-----|-----|
|1|True|
|0|False|

**DefaultValue**: False



### <a name="BKMK_from"></a> from

|Property|Value|
|--------|-----|
|Description|Enter the sender of the email.|
|DisplayName|From|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|from|
|RequiredLevel|None|
|Targets|queue,systemuser|
|Type|PartyList|


### <a name="BKMK_ImportSequenceNumber"></a> ImportSequenceNumber

|Property|Value|
|--------|-----|
|Description|Unique identifier of the data import or data migration that created this record.|
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
|Description|Information regarding whether the email activity was billed as part of resolving a case.|
|DisplayName|Is Billed|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|isbilled|
|RequiredLevel|None|
|Type|Boolean|

#### IsBilled Options

|Value|Label|
|-----|-----|
|1|Yes|
|0|No|

**DefaultValue**: False



### <a name="BKMK_IsWorkflowCreated"></a> IsWorkflowCreated

|Property|Value|
|--------|-----|
|Description|Indication if the email was created by a workflow rule.|
|DisplayName|Is Workflow Created|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|isworkflowcreated|
|RequiredLevel|None|
|Type|Boolean|

#### IsWorkflowCreated Options

|Value|Label|
|-----|-----|
|1|Yes|
|0|No|

**DefaultValue**: False



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


### <a name="BKMK_LastOpenedTime"></a> LastOpenedTime

|Property|Value|
|--------|-----|
|DateTimeBehavior|UserLocal|
|Description|Shows the latest date and time when email was opened.|
|DisplayName|Last Opened Time|
|Format|DateAndTime|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|lastopenedtime|
|RequiredLevel|None|
|Type|DateTime|


### <a name="BKMK_LinksClickedCount"></a> LinksClickedCount

|Property|Value|
|--------|-----|
|Description|Shows the number of times a link in an email has been clicked.|
|DisplayName|Links Clicked Count|
|Format|None|
|IsValidForCreate|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|linksclickedcount|
|MaxValue|2147483647|
|MinValue|0|
|RequiredLevel|None|
|Type|Integer|


### <a name="BKMK_MessageId"></a> MessageId

|Property|Value|
|--------|-----|
|Description|Unique identifier of the email message. Used only for email that is received.|
|DisplayName|Message ID|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|messageid|
|MaxLength|320|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_MessageIdDupCheck"></a> MessageIdDupCheck

|Property|Value|
|--------|-----|
|Description|For internal use only.|
|DisplayName|Message ID Dup Check|
|IsValidForForm|False|
|IsValidForRead|False|
|LogicalName|messageiddupcheck|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|


### <a name="BKMK_MimeType"></a> MimeType

|Property|Value|
|--------|-----|
|Description|MIME type of the email message data.|
|DisplayName|Mime Type|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|mimetype|
|MaxLength|256|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_Notifications"></a> Notifications

|Property|Value|
|--------|-----|
|Description|Select the notification code to identify issues with the email recipients or attachments, such as blocked attachments.|
|DisplayName|Notifications|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|notifications|
|RequiredLevel|None|
|Type|Picklist|

#### Notifications Options

|Value|Label|
|-----|-----|
|0|None|
|1|The message was saved as a Microsoft Dynamics 365 email record, but not all the attachments could be saved with it. An attachment cannot be saved if it is blocked or if its file type is invalid.|
|2|Truncated body.|



### <a name="BKMK_OpenCount"></a> OpenCount

|Property|Value|
|--------|-----|
|Description|Shows the number of times an email has been opened.|
|DisplayName|Open Count|
|Format|None|
|IsValidForCreate|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|opencount|
|MaxValue|2147483647|
|MinValue|0|
|RequiredLevel|None|
|Type|Integer|


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
|Description|Enter the user or team who is assigned to manage the record. This field is updated every time the record is assigned to a different user.|
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


### <a name="BKMK_ParentActivityId"></a> ParentActivityId

|Property|Value|
|--------|-----|
|Description|Select the activity that the email is associated with.|
|DisplayName|Parent Activity Id|
|IsValidForForm|True|
|IsValidForRead|True|
|IsValidForUpdate|False|
|LogicalName|parentactivityid|
|RequiredLevel|None|
|Targets|email|
|Type|Lookup|


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

#### PriorityCode Options

|Value|Label|
|-----|-----|
|0|Low|
|1|Normal|
|2|High|



### <a name="BKMK_ProcessId"></a> ProcessId

|Property|Value|
|--------|-----|
|Description|Shows the ID of the process.|
|DisplayName|Process|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|processid|
|RequiredLevel|None|
|Type|Uniqueidentifier|


### <a name="BKMK_ReadReceiptRequested"></a> ReadReceiptRequested

|Property|Value|
|--------|-----|
|Description|Indicates that a read receipt is requested.|
|DisplayName|Read Receipt Requested|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|readreceiptrequested|
|RequiredLevel|None|
|Type|Boolean|

#### ReadReceiptRequested Options

|Value|Label|
|-----|-----|
|1|Yes|
|0|No|

**DefaultValue**: False



### <a name="BKMK_RegardingObjectId"></a> RegardingObjectId

|Property|Value|
|--------|-----|
|Description|Choose the record that the email relates to.|
|DisplayName|Regarding|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|regardingobjectid|
|RequiredLevel|None|
|Targets|account,asyncoperation,bookableresourcebooking,bookableresourcebookingheader,bulkoperation,campaign,campaignactivity,contact,contract,entitlement,entitlementtemplate,incident,invoice,knowledgearticle,knowledgebaserecord,lead,msdyn_agreement,msdyn_agreementbookingdate,msdyn_agreementbookingincident,msdyn_agreementbookingproduct,msdyn_agreementbookingservice,msdyn_agreementbookingservicetask,msdyn_agreementbookingsetup,msdyn_agreementinvoicedate,msdyn_agreementinvoiceproduct,msdyn_agreementinvoicesetup,msdyn_bookingalertstatus,msdyn_bookingrule,msdyn_bookingtimestamp,msdyn_customerasset,msdyn_fieldservicesetting,msdyn_incidenttypecharacteristic,msdyn_incidenttypeproduct,msdyn_incidenttypeservice,msdyn_inventoryadjustment,msdyn_inventoryadjustmentproduct,msdyn_inventoryjournal,msdyn_inventorytransfer,msdyn_payment,msdyn_paymentdetail,msdyn_paymentmethod,msdyn_paymentterm,msdyn_playbookinstance,msdyn_postalbum,msdyn_postalcode,msdyn_processnotes,msdyn_productinventory,msdyn_projectteam,msdyn_purchaseorder,msdyn_purchaseorderbill,msdyn_purchaseorderproduct,msdyn_purchaseorderreceipt,msdyn_purchaseorderreceiptproduct,msdyn_purchaseordersubstatus,msdyn_quotebookingincident,msdyn_quotebookingproduct,msdyn_quotebookingservice,msdyn_quotebookingservicetask,msdyn_resourceterritory,msdyn_rma,msdyn_rmaproduct,msdyn_rmareceipt,msdyn_rmareceiptproduct,msdyn_rmasubstatus,msdyn_rtv,msdyn_rtvproduct,msdyn_rtvsubstatus,msdyn_shipvia,msdyn_systemuserschedulersetting,msdyn_timegroup,msdyn_timegroupdetail,msdyn_timeoffrequest,msdyn_warehouse,msdyn_workorder,msdyn_workordercharacteristic,msdyn_workorderincident,msdyn_workorderproduct,msdyn_workorderresourcerestriction,msdyn_workorderservice,msdyn_workorderservicetask,opportunity,quote,salesorder,site|
|Type|Lookup|


### <a name="BKMK_RegardingObjectTypeCode"></a> RegardingObjectTypeCode

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|regardingobjecttypecode|
|RequiredLevel|None|
|Type|EntityName|


### <a name="BKMK_ReminderActionCardId"></a> ReminderActionCardId

|Property|Value|
|--------|-----|
|Description|Reminder Action Card Id.|
|DisplayName|Reminder Action Card Id.|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|reminderactioncardid|
|RequiredLevel|None|
|Type|Uniqueidentifier|


### <a name="BKMK_ScheduledEnd"></a> ScheduledEnd

|Property|Value|
|--------|-----|
|DateTimeBehavior|UserLocal|
|Description|Enter the expected due date and time for the activity to be completed to provide details about when the email will be sent.|
|DisplayName|Due Date|
|Format|DateAndTime|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|scheduledend|
|RequiredLevel|None|
|Type|DateTime|


### <a name="BKMK_ScheduledStart"></a> ScheduledStart

|Property|Value|
|--------|-----|
|DateTimeBehavior|UserLocal|
|Description|Enter the expected start date and time for the activity to provide details about the tentative time when the email activity must be initiated.|
|DisplayName|Start Date|
|Format|DateAndTime|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|scheduledstart|
|RequiredLevel|None|
|Type|DateTime|


### <a name="BKMK_Sender"></a> Sender

|Property|Value|
|--------|-----|
|Description|Sender of the email.|
|DisplayName|From|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|sender|
|MaxLength|250|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_SendersAccountName"></a> SendersAccountName

|Property|Value|
|--------|-----|
|Description|Shows the name of the sender account of the email.|
|DisplayName|Email Sender Account Name|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|IsValidForUpdate|False|
|LogicalName|sendersaccountname|
|MaxLength|400|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_ServiceId"></a> ServiceId

**Added by**: Service Solution

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
|Description|Choose the service level agreement (SLA) that you want to apply to the email record.|
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
|Description|Shows the ID of the stage.|
|DisplayName|(Deprecated) Process Stage|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|stageid|
|RequiredLevel|None|
|Type|Uniqueidentifier|


### <a name="BKMK_StateCode"></a> StateCode

|Property|Value|
|--------|-----|
|Description|Shows whether the email is open, completed, or canceled. Completed and canceled email is read-only and can't be edited.|
|DisplayName|Activity Status|
|IsValidForCreate|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|statecode|
|RequiredLevel|SystemRequired|
|Type|State|

#### StateCode Options

|Value|Label|DefaultStatus|InvariantName|
|-----|-----|-------------|-------------|
|0|Open|1|Open|
|1|Completed|2|Completed|
|2|Canceled|5|Canceled|



### <a name="BKMK_StatusCode"></a> StatusCode

|Property|Value|
|--------|-----|
|Description|Select the email's status.|
|DisplayName|Status Reason|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|statuscode|
|RequiredLevel|None|
|Type|Status|

#### StatusCode Options

|Value|Label|State|
|-----|-----|-----|
|1|Draft|0|
|2|Completed|1|
|3|Sent|1|
|4|Received|1|
|5|Canceled|2|
|6|Pending Send|1|
|7|Sending|1|
|8|Failed|0|



### <a name="BKMK_Subcategory"></a> Subcategory

|Property|Value|
|--------|-----|
|Description|Type a subcategory to identify the email type and relate the activity to a specific product, sales region, business group, or other function.|
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
|Description|Type a short description about the objective or primary topic of the email.|
|DisplayName|Subject|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|subject|
|MaxLength|400|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_SubmittedBy"></a> SubmittedBy

|Property|Value|
|--------|-----|
|Description|Shows the Microsoft Office Outlook account for the user who submitted the email to Microsoft Dynamics 365.|
|DisplayName|Submitted By|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|submittedby|
|MaxLength|250|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_TemplateId"></a> TemplateId

|Property|Value|
|--------|-----|
|Description|For internal use only. ID for template used in email.|
|DisplayName|ID for template used.|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|templateid|
|RequiredLevel|None|
|Targets|template|
|Type|Lookup|


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


### <a name="BKMK_to"></a> to

|Property|Value|
|--------|-----|
|Description|Enter the account, contact, lead, queue, or user recipients for the email.|
|DisplayName|To|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|to|
|RequiredLevel|None|
|Targets|account,contact,entitlement,equipment,knowledgearticle,lead,queue,systemuser,unresolvedaddress|
|Type|PartyList|


### <a name="BKMK_ToRecipients"></a> ToRecipients

|Property|Value|
|--------|-----|
|Description|Shows the email addresses corresponding to the recipients.|
|DisplayName|To Recipients|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|torecipients|
|MaxLength|500|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_TrackingToken"></a> TrackingToken

|Property|Value|
|--------|-----|
|Description|Shows the tracking token assigned to the email to make sure responses are automatically tracked in Microsoft Dynamics 365.|
|DisplayName|Tracking Token|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|trackingtoken|
|MaxLength|50|
|RequiredLevel|None|
|Type|String|


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

<a name="read-only-attributes"></a>

## Read-only attributes

These attributes return false for both **IsValidForCreate** or **IsValidForUpdate**. Listed by **SchemaName**.

- [ActivityTypeCode](#BKMK_ActivityTypeCode)
- [AttachmentCount](#BKMK_AttachmentCount)
- [Compressed](#BKMK_Compressed)
- [ConversationIndex](#BKMK_ConversationIndex)
- [CorrelationMethod](#BKMK_CorrelationMethod)
- [CreatedBy](#BKMK_CreatedBy)
- [CreatedByName](#BKMK_CreatedByName)
- [CreatedByYomiName](#BKMK_CreatedByYomiName)
- [CreatedOn](#BKMK_CreatedOn)
- [CreatedOnBehalfBy](#BKMK_CreatedOnBehalfBy)
- [CreatedOnBehalfByName](#BKMK_CreatedOnBehalfByName)
- [CreatedOnBehalfByYomiName](#BKMK_CreatedOnBehalfByYomiName)
- [EmailReminderStatus](#BKMK_EmailReminderStatus)
- [EmailSender](#BKMK_EmailSender)
- [EmailSenderObjectTypeCode](#BKMK_EmailSenderObjectTypeCode)
- [EmailSenderYomiName](#BKMK_EmailSenderYomiName)
- [ExchangeRate](#BKMK_ExchangeRate)
- [InReplyTo](#BKMK_InReplyTo)
- [IsEmailFollowed](#BKMK_IsEmailFollowed)
- [IsEmailReminderSet](#BKMK_IsEmailReminderSet)
- [IsRegularActivity](#BKMK_IsRegularActivity)
- [IsUnsafe](#BKMK_IsUnsafe)
- [ModifiedBy](#BKMK_ModifiedBy)
- [ModifiedByName](#BKMK_ModifiedByName)
- [ModifiedByYomiName](#BKMK_ModifiedByYomiName)
- [ModifiedOn](#BKMK_ModifiedOn)
- [ModifiedOnBehalfBy](#BKMK_ModifiedOnBehalfBy)
- [ModifiedOnBehalfByName](#BKMK_ModifiedOnBehalfByName)
- [ModifiedOnBehalfByYomiName](#BKMK_ModifiedOnBehalfByYomiName)
- [OnHoldTime](#BKMK_OnHoldTime)
- [OwnerIdName](#BKMK_OwnerIdName)
- [OwnerIdYomiName](#BKMK_OwnerIdYomiName)
- [OwningBusinessUnit](#BKMK_OwningBusinessUnit)
- [OwningTeam](#BKMK_OwningTeam)
- [OwningUser](#BKMK_OwningUser)
- [ParentActivityIdName](#BKMK_ParentActivityIdName)
- [PostponeEmailProcessingUntil](#BKMK_PostponeEmailProcessingUntil)
- [RegardingObjectIdName](#BKMK_RegardingObjectIdName)
- [RegardingObjectIdYomiName](#BKMK_RegardingObjectIdYomiName)
- [ReplyCount](#BKMK_ReplyCount)
- [SafeDescription](#BKMK_SafeDescription)
- [ScheduledDurationMinutes](#BKMK_ScheduledDurationMinutes)
- [SenderMailboxId](#BKMK_SenderMailboxId)
- [SenderMailboxIdName](#BKMK_SenderMailboxIdName)
- [SendersAccount](#BKMK_SendersAccount)
- [SendersAccountObjectTypeCode](#BKMK_SendersAccountObjectTypeCode)
- [SendersAccountYomiName](#BKMK_SendersAccountYomiName)
- [SentOn](#BKMK_SentOn)
- [ServiceIdName](#BKMK_ServiceIdName)
- [SLAInvokedId](#BKMK_SLAInvokedId)
- [SLAInvokedIdName](#BKMK_SLAInvokedIdName)
- [SLAName](#BKMK_SLAName)
- [TemplateIdName](#BKMK_TemplateIdName)
- [TransactionCurrencyIdName](#BKMK_TransactionCurrencyIdName)
- [VersionNumber](#BKMK_VersionNumber)


### <a name="BKMK_ActivityTypeCode"></a> ActivityTypeCode

|Property|Value|
|--------|-----|
|Description|Shows the type of activity.|
|DisplayName|Activity Type|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|activitytypecode|
|RequiredLevel|SystemRequired|
|Type|EntityName|


### <a name="BKMK_AttachmentCount"></a> AttachmentCount

|Property|Value|
|--------|-----|
|Description|Shows the umber of attachments of the email message.|
|DisplayName|Attachment Count|
|Format|None|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|attachmentcount|
|MaxValue|2147483647|
|MinValue|0|
|RequiredLevel|SystemRequired|
|Type|Integer|


### <a name="BKMK_Compressed"></a> Compressed

|Property|Value|
|--------|-----|
|Description|Indicates if the body is compressed.|
|DisplayName|Compression|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|compressed|
|RequiredLevel|SystemRequired|
|Type|Boolean|

#### Compressed Options

|Value|Label|
|-----|-----|
|1|Compressed|
|0|Not compressed|

**DefaultValue**: False



### <a name="BKMK_ConversationIndex"></a> ConversationIndex

|Property|Value|
|--------|-----|
|Description|Identifier for all the email responses for this conversation.|
|DisplayName|Conversation Index|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|conversationindex|
|MaxLength|2048|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_CorrelationMethod"></a> CorrelationMethod

|Property|Value|
|--------|-----|
|Description|Shows how an email is matched to an existing email in Microsoft Dynamics 365. For system use only.|
|DisplayName|Correlation Method|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|correlationmethod|
|RequiredLevel|None|
|Type|Picklist|

#### CorrelationMethod Options

|Value|Label|
|-----|-----|
|0|None|
|1|Skipped|
|2|XHeader|
|3|InReplyTo|
|4|TrackingToken|
|5|ConversationIndex|
|6|SmartMatching|
|7|CustomCorrelation|



### <a name="BKMK_CreatedBy"></a> CreatedBy

|Property|Value|
|--------|-----|
|Description|Shows who created the record.|
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
|Description|Shows the date and time when the record was created. The date and time are displayed in the time zone selected in Microsoft Dynamics 365 options.|
|DisplayName|Created On|
|Format|DateAndTime|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|createdon|
|RequiredLevel|None|
|Type|DateTime|


### <a name="BKMK_CreatedOnBehalfBy"></a> CreatedOnBehalfBy

|Property|Value|
|--------|-----|
|Description|Shows who created the record on behalf of another user.|
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


### <a name="BKMK_EmailReminderStatus"></a> EmailReminderStatus

|Property|Value|
|--------|-----|
|Description|Shows the status of the email reminder.|
|DisplayName|Email Reminder Status|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|emailreminderstatus|
|RequiredLevel|SystemRequired|
|Type|Picklist|

#### EmailReminderStatus Options

|Value|Label|
|-----|-----|
|0|NotSet|
|1|ReminderSet|
|2|ReminderExpired|
|3|ReminderInvalid|



### <a name="BKMK_EmailSender"></a> EmailSender

|Property|Value|
|--------|-----|
|Description|Shows the sender of the email.|
|DisplayName|Sender|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|emailsender|
|RequiredLevel|None|
|Targets|account,contact,equipment,lead,queue,systemuser|
|Type|Lookup|


### <a name="BKMK_EmailSenderObjectTypeCode"></a> EmailSenderObjectTypeCode

|Property|Value|
|--------|-----|
|Description|Shows the object type of sender of the email.|
|DisplayName|Email Sender Type|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|emailsenderobjecttypecode|
|RequiredLevel|None|
|Type|EntityName|


### <a name="BKMK_EmailSenderYomiName"></a> EmailSenderYomiName

|Property|Value|
|--------|-----|
|Description|Shows the yomi name of the email sender|
|DisplayName|Email Sender yomi Name|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|emailsenderyominame|
|MaxLength|400|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_ExchangeRate"></a> ExchangeRate

|Property|Value|
|--------|-----|
|Description|Shows the conversion rate of the record's currency. The exchange rate is used to convert all money fields in the record from the local currency to the system's default currency.|
|DisplayName|Exchange Rate|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|exchangerate|
|MaxValue|100000000000|
|MinValue|0.0000000001|
|Precision|10|
|RequiredLevel|None|
|Type|Decimal|


### <a name="BKMK_InReplyTo"></a> InReplyTo

|Property|Value|
|--------|-----|
|Description|Type the ID of the email message that this email activity is a response to.|
|DisplayName|In Reply To Message|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|inreplyto|
|MaxLength|320|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_IsEmailFollowed"></a> IsEmailFollowed

|Property|Value|
|--------|-----|
|Description|For internal use only. Shows whether this email is followed. This is evaluated state which overrides user selection of follow email.|
|DisplayName|Followed|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|isemailfollowed|
|RequiredLevel|None|
|Type|Boolean|

#### IsEmailFollowed Options

|Value|Label|
|-----|-----|
|1|Yes|
|0|No|

**DefaultValue**: False



### <a name="BKMK_IsEmailReminderSet"></a> IsEmailReminderSet

|Property|Value|
|--------|-----|
|Description|For internal use only. Shows whether this email Reminder is Set.|
|DisplayName|Reminder Set|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|isemailreminderset|
|RequiredLevel|None|
|Type|Boolean|

#### IsEmailReminderSet Options

|Value|Label|
|-----|-----|
|1|Yes|
|0|No|

**DefaultValue**: False



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

#### IsRegularActivity Options

|Value|Label|
|-----|-----|
|1|Yes|
|0|No|

**DefaultValue**: False



### <a name="BKMK_IsUnsafe"></a> IsUnsafe

|Property|Value|
|--------|-----|
|Description|For internal use only.|
|DisplayName|IsUnsafe|
|Format|None|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|isunsafe|
|MaxValue|2147483647|
|MinValue|0|
|RequiredLevel|None|
|Type|Integer|


### <a name="BKMK_ModifiedBy"></a> ModifiedBy

|Property|Value|
|--------|-----|
|Description|Shows who last updated the record.|
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
|Description|Shows the date and time when the record was last updated. The date and time are displayed in the time zone selected in Microsoft Dynamics 365 options.|
|DisplayName|Modified On|
|Format|DateAndTime|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|modifiedon|
|RequiredLevel|None|
|Type|DateTime|


### <a name="BKMK_ModifiedOnBehalfBy"></a> ModifiedOnBehalfBy

|Property|Value|
|--------|-----|
|Description|Shows who last updated the record on behalf of another user.|
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
|Description|Unique identifier of the business unit that owns the email activity.|
|DisplayName|Owning Business Unit|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|owningbusinessunit|
|RequiredLevel|None|
|Targets|businessunit|
|Type|Lookup|


### <a name="BKMK_OwningTeam"></a> OwningTeam

|Property|Value|
|--------|-----|
|Description|Unique identifier of the team who owns the email activity.|
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
|Description|Unique identifier of the user who owns the email activity.|
|DisplayName|Owning User|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|owninguser|
|RequiredLevel|None|
|Targets|systemuser|
|Type|Lookup|


### <a name="BKMK_ParentActivityIdName"></a> ParentActivityIdName

|Property|Value|
|--------|-----|
|Description|Parent Activity Name|
|DisplayName|Parent Activity Name|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|parentactivityidname|
|MaxLength|400|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_PostponeEmailProcessingUntil"></a> PostponeEmailProcessingUntil

|Property|Value|
|--------|-----|
|DateTimeBehavior|UserLocal|
|Description|For internal use only.|
|DisplayName|Delay email processing until|
|Format|DateAndTime|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|postponeemailprocessinguntil|
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


### <a name="BKMK_ReplyCount"></a> ReplyCount

|Property|Value|
|--------|-----|
|Description|Shows the number of replies received for an email.|
|DisplayName|Reply Count|
|Format|None|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|replycount|
|MaxValue|2147483647|
|MinValue|0|
|RequiredLevel|None|
|Type|Integer|


### <a name="BKMK_SafeDescription"></a> SafeDescription

|Property|Value|
|--------|-----|
|Description|Safe body text of the e-mail.|
|DisplayName|Safe Description|
|Format|Email|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|safedescription|
|MaxLength|1073741823|
|RequiredLevel|None|
|Type|Memo|


### <a name="BKMK_ScheduledDurationMinutes"></a> ScheduledDurationMinutes

|Property|Value|
|--------|-----|
|Description|Scheduled duration of the email activity, specified in minutes.|
|DisplayName|Scheduled Duration|
|Format|Duration|
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
|Description|Select the mailbox associated with the sender of the email message.|
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


### <a name="BKMK_SendersAccount"></a> SendersAccount

|Property|Value|
|--------|-----|
|Description|Shows the parent account of the sender of the email.|
|DisplayName|Senders Account|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|sendersaccount|
|RequiredLevel|None|
|Targets|account|
|Type|Lookup|


### <a name="BKMK_SendersAccountObjectTypeCode"></a> SendersAccountObjectTypeCode

|Property|Value|
|--------|-----|
|Description|Shows the parent account type code of the sender of the email.|
|DisplayName| SendersAccount Type|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|sendersaccountobjecttypecode|
|RequiredLevel|None|
|Type|EntityName|


### <a name="BKMK_SendersAccountYomiName"></a> SendersAccountYomiName

|Property|Value|
|--------|-----|
|Description|Shows the name of the sender account yomi name |
|DisplayName|Email Sender Account yomi Name|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|sendersaccountyominame|
|MaxLength|400|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_SentOn"></a> SentOn

|Property|Value|
|--------|-----|
|DateTimeBehavior|UserLocal|
|Description|Shows the date and time that the email was sent.|
|DisplayName|Date Sent|
|Format|DateAndTime|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|senton|
|RequiredLevel|None|
|Type|DateTime|


### <a name="BKMK_ServiceIdName"></a> ServiceIdName

**Added by**: Service Solution

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|serviceidname|
|MaxLength|160|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_SLAInvokedId"></a> SLAInvokedId

|Property|Value|
|--------|-----|
|Description|Last SLA that was applied to this email. This field is for internal use only.|
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


### <a name="BKMK_TemplateIdName"></a> TemplateIdName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|templateidname|
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
|Description|Version number of the email message.|
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

- [email_campaignresponse](#BKMK_email_campaignresponse)
- [email_actioncard](#BKMK_email_actioncard)
- [email_activity_parties](#BKMK_email_activity_parties)
- [Email_DuplicateMatchingRecord](#BKMK_Email_DuplicateMatchingRecord)
- [Email_SyncErrors](#BKMK_Email_SyncErrors)
- [Email_DuplicateBaseRecord](#BKMK_Email_DuplicateBaseRecord)
- [Email_AsyncOperations](#BKMK_Email_AsyncOperations)
- [Email_ProcessSessions](#BKMK_Email_ProcessSessions)
- [slakpiinstance_email](#BKMK_slakpiinstance_email)
- [Email_Annotation](#BKMK_Email_Annotation)
- [email_activity_mime_attachment](#BKMK_email_activity_mime_attachment)
- [email_email_parentactivityid](#BKMK_email_email_parentactivityid)
- [email_principalobjectattributeaccess](#BKMK_email_principalobjectattributeaccess)
- [Email_BulkDeleteFailures](#BKMK_Email_BulkDeleteFailures)
- [email_connections1](#BKMK_email_connections1)
- [email_connections2](#BKMK_email_connections2)
- [Email_QueueItem](#BKMK_Email_QueueItem)


### <a name="BKMK_email_campaignresponse"></a> email_campaignresponse

**Added by**: Marketing Solution

Same as campaignresponse entity [email_campaignresponse](campaignresponse.md#BKMK_email_campaignresponse) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|campaignresponse|
|ReferencingAttribute|originatingactivityid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|email_campaignresponse|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_email_actioncard"></a> email_actioncard

Same as actioncard entity [email_actioncard](actioncard.md#BKMK_email_actioncard) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|actioncard|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|email_actioncard|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_email_activity_parties"></a> email_activity_parties

Same as activityparty entity [email_activity_parties](activityparty.md#BKMK_email_activity_parties) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|activityparty|
|ReferencingAttribute|activityid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|email_activity_parties|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_Email_DuplicateMatchingRecord"></a> Email_DuplicateMatchingRecord

Same as duplicaterecord entity [Email_DuplicateMatchingRecord](duplicaterecord.md#BKMK_Email_DuplicateMatchingRecord) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|duplicaterecord|
|ReferencingAttribute|duplicaterecordid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|Email_DuplicateMatchingRecord|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_Email_SyncErrors"></a> Email_SyncErrors

Same as syncerror entity [Email_SyncErrors](syncerror.md#BKMK_Email_SyncErrors) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|syncerror|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|Email_SyncErrors|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: Cascade<br />Reparent: Cascade<br />Share: Cascade<br />Unshare: Cascade|


### <a name="BKMK_Email_DuplicateBaseRecord"></a> Email_DuplicateBaseRecord

Same as duplicaterecord entity [Email_DuplicateBaseRecord](duplicaterecord.md#BKMK_Email_DuplicateBaseRecord) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|duplicaterecord|
|ReferencingAttribute|baserecordid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|Email_DuplicateBaseRecord|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_Email_AsyncOperations"></a> Email_AsyncOperations

Same as asyncoperation entity [Email_AsyncOperations](asyncoperation.md#BKMK_Email_AsyncOperations) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|asyncoperation|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|Email_AsyncOperations|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_Email_ProcessSessions"></a> Email_ProcessSessions

Same as processsession entity [Email_ProcessSessions](processsession.md#BKMK_Email_ProcessSessions) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|processsession|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|Email_ProcessSessions|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Details<br />Label: <br />Order: 110|
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_slakpiinstance_email"></a> slakpiinstance_email

Same as slakpiinstance entity [slakpiinstance_email](slakpiinstance.md#BKMK_slakpiinstance_email) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|slakpiinstance|
|ReferencingAttribute|regarding|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|slakpiinstance_email|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_Email_Annotation"></a> Email_Annotation

Same as annotation entity [Email_Annotation](annotation.md#BKMK_Email_Annotation) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|annotation|
|ReferencingAttribute|objectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|Email_Annotation|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: Cascade<br />Share: Cascade<br />Unshare: Cascade|


### <a name="BKMK_email_activity_mime_attachment"></a> email_activity_mime_attachment

Same as activitymimeattachment entity [email_activity_mime_attachment](activitymimeattachment.md#BKMK_email_activity_mime_attachment) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|activitymimeattachment|
|ReferencingAttribute|objectid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|email_activity_mime_attachment|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_email_email_parentactivityid"></a> email_email_parentactivityid

Same as email entity [email_email_parentactivityid](email.md#BKMK_email_email_parentactivityid) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|email|
|ReferencingAttribute|parentactivityid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|email_email_parentactivityid|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: RemoveLink<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_email_principalobjectattributeaccess"></a> email_principalobjectattributeaccess

Same as principalobjectattributeaccess entity [email_principalobjectattributeaccess](principalobjectattributeaccess.md#BKMK_email_principalobjectattributeaccess) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|principalobjectattributeaccess|
|ReferencingAttribute|objectid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|email_principalobjectattributeaccess|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_Email_BulkDeleteFailures"></a> Email_BulkDeleteFailures

Same as bulkdeletefailure entity [Email_BulkDeleteFailures](bulkdeletefailure.md#BKMK_Email_BulkDeleteFailures) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|bulkdeletefailure|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|Email_BulkDeleteFailures|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_email_connections1"></a> email_connections1

Same as connection entity [email_connections1](connection.md#BKMK_email_connections1) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|connection|
|ReferencingAttribute|record1id|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|email_connections1|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Details<br />Label: <br />Order: 100|
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_email_connections2"></a> email_connections2

Same as connection entity [email_connections2](connection.md#BKMK_email_connections2) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|connection|
|ReferencingAttribute|record2id|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|email_connections2|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: 100|
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_Email_QueueItem"></a> Email_QueueItem

Same as queueitem entity [Email_QueueItem](queueitem.md#BKMK_Email_QueueItem) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|queueitem|
|ReferencingAttribute|objectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|Email_QueueItem|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|

<a name="manytoone"></a>

## Many-To-One Relationships

Each Many-To-One relationship is defined by a corresponding One-To-Many relationship with the related entity. Listed by **SchemaName**.

- [Lead_Emails](#BKMK_Lead_Emails)
- [Lead_Email_EmailSender](#BKMK_Lead_Email_EmailSender)
- [bookableresourcebooking_Emails](#BKMK_bookableresourcebooking_Emails)
- [bookableresourcebookingheader_Emails](#BKMK_bookableresourcebookingheader_Emails)
- [BulkOperation_Email](#BKMK_BulkOperation_Email)
- [Campaign_Emails](#BKMK_Campaign_Emails)
- [CampaignActivity_Emails](#BKMK_CampaignActivity_Emails)
- [Contract_Emails](#BKMK_Contract_Emails)
- [entitlement_Emails](#BKMK_entitlement_Emails)
- [entitlementtemplate_Emails](#BKMK_entitlementtemplate_Emails)
- [Incident_Emails](#BKMK_Incident_Emails)
- [site_Emails](#BKMK_site_Emails)
- [Equipment_Email_EmailSender](#BKMK_Equipment_Email_EmailSender)
- [service_emails](#BKMK_service_emails)
- [msdyn_playbookinstance_Emails](#BKMK_msdyn_playbookinstance_Emails)
- [Invoice_Emails](#BKMK_Invoice_Emails)
- [Opportunity_Emails](#BKMK_Opportunity_Emails)
- [Quote_Emails](#BKMK_Quote_Emails)
- [SalesOrder_Emails](#BKMK_SalesOrder_Emails)
- [msdyn_postalbum_Emails](#BKMK_msdyn_postalbum_Emails)
- [msdyn_bookingalertstatus_Emails](#BKMK_msdyn_bookingalertstatus_Emails)
- [msdyn_bookingrule_Emails](#BKMK_msdyn_bookingrule_Emails)
- [msdyn_resourceterritory_Emails](#BKMK_msdyn_resourceterritory_Emails)
- [msdyn_systemuserschedulersetting_Emails](#BKMK_msdyn_systemuserschedulersetting_Emails)
- [msdyn_timegroup_Emails](#BKMK_msdyn_timegroup_Emails)
- [msdyn_timegroupdetail_Emails](#BKMK_msdyn_timegroupdetail_Emails)
- [msdyn_processnotes_Emails](#BKMK_msdyn_processnotes_Emails)
- [msdyn_projectteam_Emails](#BKMK_msdyn_projectteam_Emails)
- [msdyn_agreement_Emails](#BKMK_msdyn_agreement_Emails)
- [msdyn_agreementbookingdate_Emails](#BKMK_msdyn_agreementbookingdate_Emails)
- [msdyn_agreementbookingincident_Emails](#BKMK_msdyn_agreementbookingincident_Emails)
- [msdyn_agreementbookingproduct_Emails](#BKMK_msdyn_agreementbookingproduct_Emails)
- [msdyn_agreementbookingservice_Emails](#BKMK_msdyn_agreementbookingservice_Emails)
- [msdyn_agreementbookingservicetask_Emails](#BKMK_msdyn_agreementbookingservicetask_Emails)
- [msdyn_agreementbookingsetup_Emails](#BKMK_msdyn_agreementbookingsetup_Emails)
- [msdyn_agreementinvoicedate_Emails](#BKMK_msdyn_agreementinvoicedate_Emails)
- [msdyn_agreementinvoiceproduct_Emails](#BKMK_msdyn_agreementinvoiceproduct_Emails)
- [msdyn_agreementinvoicesetup_Emails](#BKMK_msdyn_agreementinvoicesetup_Emails)
- [msdyn_bookingtimestamp_Emails](#BKMK_msdyn_bookingtimestamp_Emails)
- [msdyn_customerasset_Emails](#BKMK_msdyn_customerasset_Emails)
- [msdyn_fieldservicesetting_Emails](#BKMK_msdyn_fieldservicesetting_Emails)
- [msdyn_incidenttypecharacteristic_Emails](#BKMK_msdyn_incidenttypecharacteristic_Emails)
- [msdyn_incidenttypeproduct_Emails](#BKMK_msdyn_incidenttypeproduct_Emails)
- [msdyn_incidenttypeservice_Emails](#BKMK_msdyn_incidenttypeservice_Emails)
- [msdyn_inventoryadjustment_Emails](#BKMK_msdyn_inventoryadjustment_Emails)
- [msdyn_inventoryadjustmentproduct_Emails](#BKMK_msdyn_inventoryadjustmentproduct_Emails)
- [msdyn_inventoryjournal_Emails](#BKMK_msdyn_inventoryjournal_Emails)
- [msdyn_inventorytransfer_Emails](#BKMK_msdyn_inventorytransfer_Emails)
- [msdyn_payment_Emails](#BKMK_msdyn_payment_Emails)
- [msdyn_paymentdetail_Emails](#BKMK_msdyn_paymentdetail_Emails)
- [msdyn_paymentmethod_Emails](#BKMK_msdyn_paymentmethod_Emails)
- [msdyn_paymentterm_Emails](#BKMK_msdyn_paymentterm_Emails)
- [msdyn_postalcode_Emails](#BKMK_msdyn_postalcode_Emails)
- [msdyn_productinventory_Emails](#BKMK_msdyn_productinventory_Emails)
- [msdyn_purchaseorder_Emails](#BKMK_msdyn_purchaseorder_Emails)
- [msdyn_purchaseorderbill_Emails](#BKMK_msdyn_purchaseorderbill_Emails)
- [msdyn_purchaseorderproduct_Emails](#BKMK_msdyn_purchaseorderproduct_Emails)
- [msdyn_purchaseorderreceipt_Emails](#BKMK_msdyn_purchaseorderreceipt_Emails)
- [msdyn_purchaseorderreceiptproduct_Emails](#BKMK_msdyn_purchaseorderreceiptproduct_Emails)
- [msdyn_purchaseordersubstatus_Emails](#BKMK_msdyn_purchaseordersubstatus_Emails)
- [msdyn_quotebookingincident_Emails](#BKMK_msdyn_quotebookingincident_Emails)
- [msdyn_quotebookingproduct_Emails](#BKMK_msdyn_quotebookingproduct_Emails)
- [msdyn_quotebookingservice_Emails](#BKMK_msdyn_quotebookingservice_Emails)
- [msdyn_quotebookingservicetask_Emails](#BKMK_msdyn_quotebookingservicetask_Emails)
- [msdyn_rma_Emails](#BKMK_msdyn_rma_Emails)
- [msdyn_rmaproduct_Emails](#BKMK_msdyn_rmaproduct_Emails)
- [msdyn_rmareceipt_Emails](#BKMK_msdyn_rmareceipt_Emails)
- [msdyn_rmareceiptproduct_Emails](#BKMK_msdyn_rmareceiptproduct_Emails)
- [msdyn_rmasubstatus_Emails](#BKMK_msdyn_rmasubstatus_Emails)
- [msdyn_rtv_Emails](#BKMK_msdyn_rtv_Emails)
- [msdyn_rtvproduct_Emails](#BKMK_msdyn_rtvproduct_Emails)
- [msdyn_rtvsubstatus_Emails](#BKMK_msdyn_rtvsubstatus_Emails)
- [msdyn_shipvia_Emails](#BKMK_msdyn_shipvia_Emails)
- [msdyn_timeoffrequest_Emails](#BKMK_msdyn_timeoffrequest_Emails)
- [msdyn_warehouse_Emails](#BKMK_msdyn_warehouse_Emails)
- [msdyn_workorder_Emails](#BKMK_msdyn_workorder_Emails)
- [msdyn_workordercharacteristic_Emails](#BKMK_msdyn_workordercharacteristic_Emails)
- [msdyn_workorderincident_Emails](#BKMK_msdyn_workorderincident_Emails)
- [msdyn_workorderproduct_Emails](#BKMK_msdyn_workorderproduct_Emails)
- [msdyn_workorderresourcerestriction_Emails](#BKMK_msdyn_workorderresourcerestriction_Emails)
- [msdyn_workorderservice_Emails](#BKMK_msdyn_workorderservice_Emails)
- [msdyn_workorderservicetask_Emails](#BKMK_msdyn_workorderservicetask_Emails)
- [KnowledgeBaseRecord_Emails](#BKMK_KnowledgeBaseRecord_Emails)
- [lk_email_modifiedby](#BKMK_lk_email_modifiedby)
- [Account_Email_SendersAccount](#BKMK_Account_Email_SendersAccount)
- [Email_EmailTemplate](#BKMK_Email_EmailTemplate)
- [Queue_Email_EmailSender](#BKMK_Queue_Email_EmailSender)
- [Contact_Email_EmailSender](#BKMK_Contact_Email_EmailSender)
- [Account_Email_EmailSender](#BKMK_Account_Email_EmailSender)
- [TransactionCurrency_Email](#BKMK_TransactionCurrency_Email)
- [Contact_Emails](#BKMK_Contact_Emails)
- [user_email](#BKMK_user_email)
- [SystemUser_Email_EmailSender](#BKMK_SystemUser_Email_EmailSender)
- [AsyncOperation_Emails](#BKMK_AsyncOperation_Emails)
- [lk_email_createdonbehalfby](#BKMK_lk_email_createdonbehalfby)
- [KnowledgeArticle_Emails](#BKMK_KnowledgeArticle_Emails)
- [email_sendermailboxid_mailbox](#BKMK_email_sendermailboxid_mailbox)
- [activity_pointer_email](#BKMK_activity_pointer_email)
- [lk_email_modifiedonbehalfby](#BKMK_lk_email_modifiedonbehalfby)
- [team_email](#BKMK_team_email)
- [manualsla_email](#BKMK_manualsla_email)
- [business_unit_email_activities](#BKMK_business_unit_email_activities)
- [Account_Emails](#BKMK_Account_Emails)
- [email_email_parentactivityid](#BKMK_email_email_parentactivityid)
- [processstage_emails](#BKMK_processstage_emails)
- [sla_email](#BKMK_sla_email)
- [lk_email_createdby](#BKMK_lk_email_createdby)


### <a name="BKMK_Lead_Emails"></a> Lead_Emails

**Added by**: Lead Management Solution

See lead Entity [Lead_Emails](lead.md#BKMK_Lead_Emails) One-To-Many relationship.

### <a name="BKMK_Lead_Email_EmailSender"></a> Lead_Email_EmailSender

**Added by**: Lead Management Solution

See lead Entity [Lead_Email_EmailSender](lead.md#BKMK_Lead_Email_EmailSender) One-To-Many relationship.

### <a name="BKMK_bookableresourcebooking_Emails"></a> bookableresourcebooking_Emails

**Added by**: Scheduling Solution

See bookableresourcebooking Entity [bookableresourcebooking_Emails](bookableresourcebooking.md#BKMK_bookableresourcebooking_Emails) One-To-Many relationship.

### <a name="BKMK_bookableresourcebookingheader_Emails"></a> bookableresourcebookingheader_Emails

**Added by**: Scheduling Solution

See bookableresourcebookingheader Entity [bookableresourcebookingheader_Emails](bookableresourcebookingheader.md#BKMK_bookableresourcebookingheader_Emails) One-To-Many relationship.

### <a name="BKMK_BulkOperation_Email"></a> BulkOperation_Email

**Added by**: Marketing Solution

See bulkoperation Entity [BulkOperation_Email](bulkoperation.md#BKMK_BulkOperation_Email) One-To-Many relationship.

### <a name="BKMK_Campaign_Emails"></a> Campaign_Emails

**Added by**: Marketing Solution

See campaign Entity [Campaign_Emails](campaign.md#BKMK_Campaign_Emails) One-To-Many relationship.

### <a name="BKMK_CampaignActivity_Emails"></a> CampaignActivity_Emails

**Added by**: Marketing Solution

See campaignactivity Entity [CampaignActivity_Emails](campaignactivity.md#BKMK_CampaignActivity_Emails) One-To-Many relationship.

### <a name="BKMK_Contract_Emails"></a> Contract_Emails

**Added by**: Service Solution

See contract Entity [Contract_Emails](contract.md#BKMK_Contract_Emails) One-To-Many relationship.

### <a name="BKMK_entitlement_Emails"></a> entitlement_Emails

**Added by**: Service Solution

See entitlement Entity [entitlement_Emails](entitlement.md#BKMK_entitlement_Emails) One-To-Many relationship.

### <a name="BKMK_entitlementtemplate_Emails"></a> entitlementtemplate_Emails

**Added by**: Service Solution

See entitlementtemplate Entity [entitlementtemplate_Emails](entitlementtemplate.md#BKMK_entitlementtemplate_Emails) One-To-Many relationship.

### <a name="BKMK_Incident_Emails"></a> Incident_Emails

**Added by**: Service Solution

See incident Entity [Incident_Emails](incident.md#BKMK_Incident_Emails) One-To-Many relationship.

### <a name="BKMK_site_Emails"></a> site_Emails

**Added by**: Service Solution

See site Entity [site_Emails](site.md#BKMK_site_Emails) One-To-Many relationship.

### <a name="BKMK_Equipment_Email_EmailSender"></a> Equipment_Email_EmailSender

**Added by**: Service Solution

See equipment Entity [Equipment_Email_EmailSender](equipment.md#BKMK_Equipment_Email_EmailSender) One-To-Many relationship.

### <a name="BKMK_service_emails"></a> service_emails

**Added by**: Service Solution

See service Entity [service_emails](service.md#BKMK_service_emails) One-To-Many relationship.

### <a name="BKMK_msdyn_playbookinstance_Emails"></a> msdyn_playbookinstance_Emails

**Added by**: Playbook Solution

See msdyn_playbookinstance Entity [msdyn_playbookinstance_Emails](msdyn_playbookinstance.md#BKMK_msdyn_playbookinstance_Emails) One-To-Many relationship.

### <a name="BKMK_Invoice_Emails"></a> Invoice_Emails

**Added by**: Sales Solution

See invoice Entity [Invoice_Emails](invoice.md#BKMK_Invoice_Emails) One-To-Many relationship.

### <a name="BKMK_Opportunity_Emails"></a> Opportunity_Emails

**Added by**: Sales Solution

See opportunity Entity [Opportunity_Emails](opportunity.md#BKMK_Opportunity_Emails) One-To-Many relationship.

### <a name="BKMK_Quote_Emails"></a> Quote_Emails

**Added by**: Sales Solution

See quote Entity [Quote_Emails](quote.md#BKMK_Quote_Emails) One-To-Many relationship.

### <a name="BKMK_SalesOrder_Emails"></a> SalesOrder_Emails

**Added by**: Sales Solution

See salesorder Entity [SalesOrder_Emails](salesorder.md#BKMK_SalesOrder_Emails) One-To-Many relationship.

### <a name="BKMK_msdyn_postalbum_Emails"></a> msdyn_postalbum_Emails

**Added by**: Activity Feeds Solution

See msdyn_postalbum Entity [msdyn_postalbum_Emails](msdyn_postalbum.md#BKMK_msdyn_postalbum_Emails) One-To-Many relationship.

### <a name="BKMK_msdyn_bookingalertstatus_Emails"></a> msdyn_bookingalertstatus_Emails

**Added by**: Universal Resource Scheduling Solution

See msdyn_bookingalertstatus Entity [msdyn_bookingalertstatus_Emails](msdyn_bookingalertstatus.md#BKMK_msdyn_bookingalertstatus_Emails) One-To-Many relationship.

### <a name="BKMK_msdyn_bookingrule_Emails"></a> msdyn_bookingrule_Emails

**Added by**: Universal Resource Scheduling Solution

See msdyn_bookingrule Entity [msdyn_bookingrule_Emails](msdyn_bookingrule.md#BKMK_msdyn_bookingrule_Emails) One-To-Many relationship.

### <a name="BKMK_msdyn_resourceterritory_Emails"></a> msdyn_resourceterritory_Emails

**Added by**: Universal Resource Scheduling Solution

See msdyn_resourceterritory Entity [msdyn_resourceterritory_Emails](msdyn_resourceterritory.md#BKMK_msdyn_resourceterritory_Emails) One-To-Many relationship.

### <a name="BKMK_msdyn_systemuserschedulersetting_Emails"></a> msdyn_systemuserschedulersetting_Emails

**Added by**: Universal Resource Scheduling Solution

See msdyn_systemuserschedulersetting Entity [msdyn_systemuserschedulersetting_Emails](msdyn_systemuserschedulersetting.md#BKMK_msdyn_systemuserschedulersetting_Emails) One-To-Many relationship.

### <a name="BKMK_msdyn_timegroup_Emails"></a> msdyn_timegroup_Emails

**Added by**: Universal Resource Scheduling Solution

See msdyn_timegroup Entity [msdyn_timegroup_Emails](msdyn_timegroup.md#BKMK_msdyn_timegroup_Emails) One-To-Many relationship.

### <a name="BKMK_msdyn_timegroupdetail_Emails"></a> msdyn_timegroupdetail_Emails

**Added by**: Universal Resource Scheduling Solution

See msdyn_timegroupdetail Entity [msdyn_timegroupdetail_Emails](msdyn_timegroupdetail.md#BKMK_msdyn_timegroupdetail_Emails) One-To-Many relationship.

### <a name="BKMK_msdyn_processnotes_Emails"></a> msdyn_processnotes_Emails

**Added by**: Project Service Automation Solution

See msdyn_processnotes Entity [msdyn_processnotes_Emails](msdyn_processnotes.md#BKMK_msdyn_processnotes_Emails) One-To-Many relationship.

### <a name="BKMK_msdyn_projectteam_Emails"></a> msdyn_projectteam_Emails

**Added by**: Project Service Automation Solution

See msdyn_projectteam Entity [msdyn_projectteam_Emails](msdyn_projectteam.md#BKMK_msdyn_projectteam_Emails) One-To-Many relationship.

### <a name="BKMK_msdyn_agreement_Emails"></a> msdyn_agreement_Emails

**Added by**: Field Service Solution

See msdyn_agreement Entity [msdyn_agreement_Emails](msdyn_agreement.md#BKMK_msdyn_agreement_Emails) One-To-Many relationship.

### <a name="BKMK_msdyn_agreementbookingdate_Emails"></a> msdyn_agreementbookingdate_Emails

**Added by**: Field Service Solution

See msdyn_agreementbookingdate Entity [msdyn_agreementbookingdate_Emails](msdyn_agreementbookingdate.md#BKMK_msdyn_agreementbookingdate_Emails) One-To-Many relationship.

### <a name="BKMK_msdyn_agreementbookingincident_Emails"></a> msdyn_agreementbookingincident_Emails

**Added by**: Field Service Solution

See msdyn_agreementbookingincident Entity [msdyn_agreementbookingincident_Emails](msdyn_agreementbookingincident.md#BKMK_msdyn_agreementbookingincident_Emails) One-To-Many relationship.

### <a name="BKMK_msdyn_agreementbookingproduct_Emails"></a> msdyn_agreementbookingproduct_Emails

**Added by**: Field Service Solution

See msdyn_agreementbookingproduct Entity [msdyn_agreementbookingproduct_Emails](msdyn_agreementbookingproduct.md#BKMK_msdyn_agreementbookingproduct_Emails) One-To-Many relationship.

### <a name="BKMK_msdyn_agreementbookingservice_Emails"></a> msdyn_agreementbookingservice_Emails

**Added by**: Field Service Solution

See msdyn_agreementbookingservice Entity [msdyn_agreementbookingservice_Emails](msdyn_agreementbookingservice.md#BKMK_msdyn_agreementbookingservice_Emails) One-To-Many relationship.

### <a name="BKMK_msdyn_agreementbookingservicetask_Emails"></a> msdyn_agreementbookingservicetask_Emails

**Added by**: Field Service Solution

See msdyn_agreementbookingservicetask Entity [msdyn_agreementbookingservicetask_Emails](msdyn_agreementbookingservicetask.md#BKMK_msdyn_agreementbookingservicetask_Emails) One-To-Many relationship.

### <a name="BKMK_msdyn_agreementbookingsetup_Emails"></a> msdyn_agreementbookingsetup_Emails

**Added by**: Field Service Solution

See msdyn_agreementbookingsetup Entity [msdyn_agreementbookingsetup_Emails](msdyn_agreementbookingsetup.md#BKMK_msdyn_agreementbookingsetup_Emails) One-To-Many relationship.

### <a name="BKMK_msdyn_agreementinvoicedate_Emails"></a> msdyn_agreementinvoicedate_Emails

**Added by**: Field Service Solution

See msdyn_agreementinvoicedate Entity [msdyn_agreementinvoicedate_Emails](msdyn_agreementinvoicedate.md#BKMK_msdyn_agreementinvoicedate_Emails) One-To-Many relationship.

### <a name="BKMK_msdyn_agreementinvoiceproduct_Emails"></a> msdyn_agreementinvoiceproduct_Emails

**Added by**: Field Service Solution

See msdyn_agreementinvoiceproduct Entity [msdyn_agreementinvoiceproduct_Emails](msdyn_agreementinvoiceproduct.md#BKMK_msdyn_agreementinvoiceproduct_Emails) One-To-Many relationship.

### <a name="BKMK_msdyn_agreementinvoicesetup_Emails"></a> msdyn_agreementinvoicesetup_Emails

**Added by**: Field Service Solution

See msdyn_agreementinvoicesetup Entity [msdyn_agreementinvoicesetup_Emails](msdyn_agreementinvoicesetup.md#BKMK_msdyn_agreementinvoicesetup_Emails) One-To-Many relationship.

### <a name="BKMK_msdyn_bookingtimestamp_Emails"></a> msdyn_bookingtimestamp_Emails

**Added by**: Field Service Solution

See msdyn_bookingtimestamp Entity [msdyn_bookingtimestamp_Emails](msdyn_bookingtimestamp.md#BKMK_msdyn_bookingtimestamp_Emails) One-To-Many relationship.

### <a name="BKMK_msdyn_customerasset_Emails"></a> msdyn_customerasset_Emails

**Added by**: Field Service Solution

See msdyn_customerasset Entity [msdyn_customerasset_Emails](msdyn_customerasset.md#BKMK_msdyn_customerasset_Emails) One-To-Many relationship.

### <a name="BKMK_msdyn_fieldservicesetting_Emails"></a> msdyn_fieldservicesetting_Emails

**Added by**: Field Service Solution

See msdyn_fieldservicesetting Entity [msdyn_fieldservicesetting_Emails](msdyn_fieldservicesetting.md#BKMK_msdyn_fieldservicesetting_Emails) One-To-Many relationship.

### <a name="BKMK_msdyn_incidenttypecharacteristic_Emails"></a> msdyn_incidenttypecharacteristic_Emails

**Added by**: Field Service Solution

See msdyn_incidenttypecharacteristic Entity [msdyn_incidenttypecharacteristic_Emails](msdyn_incidenttypecharacteristic.md#BKMK_msdyn_incidenttypecharacteristic_Emails) One-To-Many relationship.

### <a name="BKMK_msdyn_incidenttypeproduct_Emails"></a> msdyn_incidenttypeproduct_Emails

**Added by**: Field Service Solution

See msdyn_incidenttypeproduct Entity [msdyn_incidenttypeproduct_Emails](msdyn_incidenttypeproduct.md#BKMK_msdyn_incidenttypeproduct_Emails) One-To-Many relationship.

### <a name="BKMK_msdyn_incidenttypeservice_Emails"></a> msdyn_incidenttypeservice_Emails

**Added by**: Field Service Solution

See msdyn_incidenttypeservice Entity [msdyn_incidenttypeservice_Emails](msdyn_incidenttypeservice.md#BKMK_msdyn_incidenttypeservice_Emails) One-To-Many relationship.

### <a name="BKMK_msdyn_inventoryadjustment_Emails"></a> msdyn_inventoryadjustment_Emails

**Added by**: Field Service Solution

See msdyn_inventoryadjustment Entity [msdyn_inventoryadjustment_Emails](msdyn_inventoryadjustment.md#BKMK_msdyn_inventoryadjustment_Emails) One-To-Many relationship.

### <a name="BKMK_msdyn_inventoryadjustmentproduct_Emails"></a> msdyn_inventoryadjustmentproduct_Emails

**Added by**: Field Service Solution

See msdyn_inventoryadjustmentproduct Entity [msdyn_inventoryadjustmentproduct_Emails](msdyn_inventoryadjustmentproduct.md#BKMK_msdyn_inventoryadjustmentproduct_Emails) One-To-Many relationship.

### <a name="BKMK_msdyn_inventoryjournal_Emails"></a> msdyn_inventoryjournal_Emails

**Added by**: Field Service Solution

See msdyn_inventoryjournal Entity [msdyn_inventoryjournal_Emails](msdyn_inventoryjournal.md#BKMK_msdyn_inventoryjournal_Emails) One-To-Many relationship.

### <a name="BKMK_msdyn_inventorytransfer_Emails"></a> msdyn_inventorytransfer_Emails

**Added by**: Field Service Solution

See msdyn_inventorytransfer Entity [msdyn_inventorytransfer_Emails](msdyn_inventorytransfer.md#BKMK_msdyn_inventorytransfer_Emails) One-To-Many relationship.

### <a name="BKMK_msdyn_payment_Emails"></a> msdyn_payment_Emails

**Added by**: Field Service Solution

See msdyn_payment Entity [msdyn_payment_Emails](msdyn_payment.md#BKMK_msdyn_payment_Emails) One-To-Many relationship.

### <a name="BKMK_msdyn_paymentdetail_Emails"></a> msdyn_paymentdetail_Emails

**Added by**: Field Service Solution

See msdyn_paymentdetail Entity [msdyn_paymentdetail_Emails](msdyn_paymentdetail.md#BKMK_msdyn_paymentdetail_Emails) One-To-Many relationship.

### <a name="BKMK_msdyn_paymentmethod_Emails"></a> msdyn_paymentmethod_Emails

**Added by**: Field Service Solution

See msdyn_paymentmethod Entity [msdyn_paymentmethod_Emails](msdyn_paymentmethod.md#BKMK_msdyn_paymentmethod_Emails) One-To-Many relationship.

### <a name="BKMK_msdyn_paymentterm_Emails"></a> msdyn_paymentterm_Emails

**Added by**: Field Service Solution

See msdyn_paymentterm Entity [msdyn_paymentterm_Emails](msdyn_paymentterm.md#BKMK_msdyn_paymentterm_Emails) One-To-Many relationship.

### <a name="BKMK_msdyn_postalcode_Emails"></a> msdyn_postalcode_Emails

**Added by**: Field Service Solution

See msdyn_postalcode Entity [msdyn_postalcode_Emails](msdyn_postalcode.md#BKMK_msdyn_postalcode_Emails) One-To-Many relationship.

### <a name="BKMK_msdyn_productinventory_Emails"></a> msdyn_productinventory_Emails

**Added by**: Field Service Solution

See msdyn_productinventory Entity [msdyn_productinventory_Emails](msdyn_productinventory.md#BKMK_msdyn_productinventory_Emails) One-To-Many relationship.

### <a name="BKMK_msdyn_purchaseorder_Emails"></a> msdyn_purchaseorder_Emails

**Added by**: Field Service Solution

See msdyn_purchaseorder Entity [msdyn_purchaseorder_Emails](msdyn_purchaseorder.md#BKMK_msdyn_purchaseorder_Emails) One-To-Many relationship.

### <a name="BKMK_msdyn_purchaseorderbill_Emails"></a> msdyn_purchaseorderbill_Emails

**Added by**: Field Service Solution

See msdyn_purchaseorderbill Entity [msdyn_purchaseorderbill_Emails](msdyn_purchaseorderbill.md#BKMK_msdyn_purchaseorderbill_Emails) One-To-Many relationship.

### <a name="BKMK_msdyn_purchaseorderproduct_Emails"></a> msdyn_purchaseorderproduct_Emails

**Added by**: Field Service Solution

See msdyn_purchaseorderproduct Entity [msdyn_purchaseorderproduct_Emails](msdyn_purchaseorderproduct.md#BKMK_msdyn_purchaseorderproduct_Emails) One-To-Many relationship.

### <a name="BKMK_msdyn_purchaseorderreceipt_Emails"></a> msdyn_purchaseorderreceipt_Emails

**Added by**: Field Service Solution

See msdyn_purchaseorderreceipt Entity [msdyn_purchaseorderreceipt_Emails](msdyn_purchaseorderreceipt.md#BKMK_msdyn_purchaseorderreceipt_Emails) One-To-Many relationship.

### <a name="BKMK_msdyn_purchaseorderreceiptproduct_Emails"></a> msdyn_purchaseorderreceiptproduct_Emails

**Added by**: Field Service Solution

See msdyn_purchaseorderreceiptproduct Entity [msdyn_purchaseorderreceiptproduct_Emails](msdyn_purchaseorderreceiptproduct.md#BKMK_msdyn_purchaseorderreceiptproduct_Emails) One-To-Many relationship.

### <a name="BKMK_msdyn_purchaseordersubstatus_Emails"></a> msdyn_purchaseordersubstatus_Emails

**Added by**: Field Service Solution

See msdyn_purchaseordersubstatus Entity [msdyn_purchaseordersubstatus_Emails](msdyn_purchaseordersubstatus.md#BKMK_msdyn_purchaseordersubstatus_Emails) One-To-Many relationship.

### <a name="BKMK_msdyn_quotebookingincident_Emails"></a> msdyn_quotebookingincident_Emails

**Added by**: Field Service Solution

See msdyn_quotebookingincident Entity [msdyn_quotebookingincident_Emails](msdyn_quotebookingincident.md#BKMK_msdyn_quotebookingincident_Emails) One-To-Many relationship.

### <a name="BKMK_msdyn_quotebookingproduct_Emails"></a> msdyn_quotebookingproduct_Emails

**Added by**: Field Service Solution

See msdyn_quotebookingproduct Entity [msdyn_quotebookingproduct_Emails](msdyn_quotebookingproduct.md#BKMK_msdyn_quotebookingproduct_Emails) One-To-Many relationship.

### <a name="BKMK_msdyn_quotebookingservice_Emails"></a> msdyn_quotebookingservice_Emails

**Added by**: Field Service Solution

See msdyn_quotebookingservice Entity [msdyn_quotebookingservice_Emails](msdyn_quotebookingservice.md#BKMK_msdyn_quotebookingservice_Emails) One-To-Many relationship.

### <a name="BKMK_msdyn_quotebookingservicetask_Emails"></a> msdyn_quotebookingservicetask_Emails

**Added by**: Field Service Solution

See msdyn_quotebookingservicetask Entity [msdyn_quotebookingservicetask_Emails](msdyn_quotebookingservicetask.md#BKMK_msdyn_quotebookingservicetask_Emails) One-To-Many relationship.

### <a name="BKMK_msdyn_rma_Emails"></a> msdyn_rma_Emails

**Added by**: Field Service Solution

See msdyn_rma Entity [msdyn_rma_Emails](msdyn_rma.md#BKMK_msdyn_rma_Emails) One-To-Many relationship.

### <a name="BKMK_msdyn_rmaproduct_Emails"></a> msdyn_rmaproduct_Emails

**Added by**: Field Service Solution

See msdyn_rmaproduct Entity [msdyn_rmaproduct_Emails](msdyn_rmaproduct.md#BKMK_msdyn_rmaproduct_Emails) One-To-Many relationship.

### <a name="BKMK_msdyn_rmareceipt_Emails"></a> msdyn_rmareceipt_Emails

**Added by**: Field Service Solution

See msdyn_rmareceipt Entity [msdyn_rmareceipt_Emails](msdyn_rmareceipt.md#BKMK_msdyn_rmareceipt_Emails) One-To-Many relationship.

### <a name="BKMK_msdyn_rmareceiptproduct_Emails"></a> msdyn_rmareceiptproduct_Emails

**Added by**: Field Service Solution

See msdyn_rmareceiptproduct Entity [msdyn_rmareceiptproduct_Emails](msdyn_rmareceiptproduct.md#BKMK_msdyn_rmareceiptproduct_Emails) One-To-Many relationship.

### <a name="BKMK_msdyn_rmasubstatus_Emails"></a> msdyn_rmasubstatus_Emails

**Added by**: Field Service Solution

See msdyn_rmasubstatus Entity [msdyn_rmasubstatus_Emails](msdyn_rmasubstatus.md#BKMK_msdyn_rmasubstatus_Emails) One-To-Many relationship.

### <a name="BKMK_msdyn_rtv_Emails"></a> msdyn_rtv_Emails

**Added by**: Field Service Solution

See msdyn_rtv Entity [msdyn_rtv_Emails](msdyn_rtv.md#BKMK_msdyn_rtv_Emails) One-To-Many relationship.

### <a name="BKMK_msdyn_rtvproduct_Emails"></a> msdyn_rtvproduct_Emails

**Added by**: Field Service Solution

See msdyn_rtvproduct Entity [msdyn_rtvproduct_Emails](msdyn_rtvproduct.md#BKMK_msdyn_rtvproduct_Emails) One-To-Many relationship.

### <a name="BKMK_msdyn_rtvsubstatus_Emails"></a> msdyn_rtvsubstatus_Emails

**Added by**: Field Service Solution

See msdyn_rtvsubstatus Entity [msdyn_rtvsubstatus_Emails](msdyn_rtvsubstatus.md#BKMK_msdyn_rtvsubstatus_Emails) One-To-Many relationship.

### <a name="BKMK_msdyn_shipvia_Emails"></a> msdyn_shipvia_Emails

**Added by**: Field Service Solution

See msdyn_shipvia Entity [msdyn_shipvia_Emails](msdyn_shipvia.md#BKMK_msdyn_shipvia_Emails) One-To-Many relationship.

### <a name="BKMK_msdyn_timeoffrequest_Emails"></a> msdyn_timeoffrequest_Emails

**Added by**: Field Service Solution

See msdyn_timeoffrequest Entity [msdyn_timeoffrequest_Emails](msdyn_timeoffrequest.md#BKMK_msdyn_timeoffrequest_Emails) One-To-Many relationship.

### <a name="BKMK_msdyn_warehouse_Emails"></a> msdyn_warehouse_Emails

**Added by**: Field Service Solution

See msdyn_warehouse Entity [msdyn_warehouse_Emails](msdyn_warehouse.md#BKMK_msdyn_warehouse_Emails) One-To-Many relationship.

### <a name="BKMK_msdyn_workorder_Emails"></a> msdyn_workorder_Emails

**Added by**: Field Service Solution

See msdyn_workorder Entity [msdyn_workorder_Emails](msdyn_workorder.md#BKMK_msdyn_workorder_Emails) One-To-Many relationship.

### <a name="BKMK_msdyn_workordercharacteristic_Emails"></a> msdyn_workordercharacteristic_Emails

**Added by**: Field Service Solution

See msdyn_workordercharacteristic Entity [msdyn_workordercharacteristic_Emails](msdyn_workordercharacteristic.md#BKMK_msdyn_workordercharacteristic_Emails) One-To-Many relationship.

### <a name="BKMK_msdyn_workorderincident_Emails"></a> msdyn_workorderincident_Emails

**Added by**: Field Service Solution

See msdyn_workorderincident Entity [msdyn_workorderincident_Emails](msdyn_workorderincident.md#BKMK_msdyn_workorderincident_Emails) One-To-Many relationship.

### <a name="BKMK_msdyn_workorderproduct_Emails"></a> msdyn_workorderproduct_Emails

**Added by**: Field Service Solution

See msdyn_workorderproduct Entity [msdyn_workorderproduct_Emails](msdyn_workorderproduct.md#BKMK_msdyn_workorderproduct_Emails) One-To-Many relationship.

### <a name="BKMK_msdyn_workorderresourcerestriction_Emails"></a> msdyn_workorderresourcerestriction_Emails

**Added by**: Field Service Solution

See msdyn_workorderresourcerestriction Entity [msdyn_workorderresourcerestriction_Emails](msdyn_workorderresourcerestriction.md#BKMK_msdyn_workorderresourcerestriction_Emails) One-To-Many relationship.

### <a name="BKMK_msdyn_workorderservice_Emails"></a> msdyn_workorderservice_Emails

**Added by**: Field Service Solution

See msdyn_workorderservice Entity [msdyn_workorderservice_Emails](msdyn_workorderservice.md#BKMK_msdyn_workorderservice_Emails) One-To-Many relationship.

### <a name="BKMK_msdyn_workorderservicetask_Emails"></a> msdyn_workorderservicetask_Emails

**Added by**: Field Service Solution

See msdyn_workorderservicetask Entity [msdyn_workorderservicetask_Emails](msdyn_workorderservicetask.md#BKMK_msdyn_workorderservicetask_Emails) One-To-Many relationship.

### <a name="BKMK_KnowledgeBaseRecord_Emails"></a> KnowledgeBaseRecord_Emails

See knowledgebaserecord Entity [KnowledgeBaseRecord_Emails](knowledgebaserecord.md#BKMK_KnowledgeBaseRecord_Emails) One-To-Many relationship.

### <a name="BKMK_lk_email_modifiedby"></a> lk_email_modifiedby

See systemuser Entity [lk_email_modifiedby](systemuser.md#BKMK_lk_email_modifiedby) One-To-Many relationship.

### <a name="BKMK_Account_Email_SendersAccount"></a> Account_Email_SendersAccount

See account Entity [Account_Email_SendersAccount](account.md#BKMK_Account_Email_SendersAccount) One-To-Many relationship.

### <a name="BKMK_Email_EmailTemplate"></a> Email_EmailTemplate

See template Entity [Email_EmailTemplate](template.md#BKMK_Email_EmailTemplate) One-To-Many relationship.

### <a name="BKMK_Queue_Email_EmailSender"></a> Queue_Email_EmailSender

See queue Entity [Queue_Email_EmailSender](queue.md#BKMK_Queue_Email_EmailSender) One-To-Many relationship.

### <a name="BKMK_Contact_Email_EmailSender"></a> Contact_Email_EmailSender

See contact Entity [Contact_Email_EmailSender](contact.md#BKMK_Contact_Email_EmailSender) One-To-Many relationship.

### <a name="BKMK_Account_Email_EmailSender"></a> Account_Email_EmailSender

See account Entity [Account_Email_EmailSender](account.md#BKMK_Account_Email_EmailSender) One-To-Many relationship.

### <a name="BKMK_TransactionCurrency_Email"></a> TransactionCurrency_Email

See transactioncurrency Entity [TransactionCurrency_Email](transactioncurrency.md#BKMK_TransactionCurrency_Email) One-To-Many relationship.

### <a name="BKMK_Contact_Emails"></a> Contact_Emails

See contact Entity [Contact_Emails](contact.md#BKMK_Contact_Emails) One-To-Many relationship.

### <a name="BKMK_user_email"></a> user_email

See systemuser Entity [user_email](systemuser.md#BKMK_user_email) One-To-Many relationship.

### <a name="BKMK_SystemUser_Email_EmailSender"></a> SystemUser_Email_EmailSender

See systemuser Entity [SystemUser_Email_EmailSender](systemuser.md#BKMK_SystemUser_Email_EmailSender) One-To-Many relationship.

### <a name="BKMK_AsyncOperation_Emails"></a> AsyncOperation_Emails

See asyncoperation Entity [AsyncOperation_Emails](asyncoperation.md#BKMK_AsyncOperation_Emails) One-To-Many relationship.

### <a name="BKMK_lk_email_createdonbehalfby"></a> lk_email_createdonbehalfby

See systemuser Entity [lk_email_createdonbehalfby](systemuser.md#BKMK_lk_email_createdonbehalfby) One-To-Many relationship.

### <a name="BKMK_KnowledgeArticle_Emails"></a> KnowledgeArticle_Emails

See knowledgearticle Entity [KnowledgeArticle_Emails](knowledgearticle.md#BKMK_KnowledgeArticle_Emails) One-To-Many relationship.

### <a name="BKMK_email_sendermailboxid_mailbox"></a> email_sendermailboxid_mailbox

See mailbox Entity [email_sendermailboxid_mailbox](mailbox.md#BKMK_email_sendermailboxid_mailbox) One-To-Many relationship.

### <a name="BKMK_activity_pointer_email"></a> activity_pointer_email

See activitypointer Entity [activity_pointer_email](activitypointer.md#BKMK_activity_pointer_email) One-To-Many relationship.

### <a name="BKMK_lk_email_modifiedonbehalfby"></a> lk_email_modifiedonbehalfby

See systemuser Entity [lk_email_modifiedonbehalfby](systemuser.md#BKMK_lk_email_modifiedonbehalfby) One-To-Many relationship.

### <a name="BKMK_team_email"></a> team_email

See team Entity [team_email](team.md#BKMK_team_email) One-To-Many relationship.

### <a name="BKMK_manualsla_email"></a> manualsla_email

See sla Entity [manualsla_email](sla.md#BKMK_manualsla_email) One-To-Many relationship.

### <a name="BKMK_business_unit_email_activities"></a> business_unit_email_activities

See businessunit Entity [business_unit_email_activities](businessunit.md#BKMK_business_unit_email_activities) One-To-Many relationship.

### <a name="BKMK_Account_Emails"></a> Account_Emails

See account Entity [Account_Emails](account.md#BKMK_Account_Emails) One-To-Many relationship.

### <a name="BKMK_email_email_parentactivityid"></a> email_email_parentactivityid

See email Entity [email_email_parentactivityid](email.md#BKMK_email_email_parentactivityid) One-To-Many relationship.

### <a name="BKMK_processstage_emails"></a> processstage_emails

See processstage Entity [processstage_emails](processstage.md#BKMK_processstage_emails) One-To-Many relationship.

### <a name="BKMK_sla_email"></a> sla_email

See sla Entity [sla_email](sla.md#BKMK_sla_email) One-To-Many relationship.

### <a name="BKMK_lk_email_createdby"></a> lk_email_createdby

See systemuser Entity [lk_email_createdby](systemuser.md#BKMK_lk_email_createdby) One-To-Many relationship.

### See also

[About the Entity Reference](../about-entity-reference.md)<br />
[Programming reference for Dynamics 365 Customer Engagement](../programming-reference.md)<br />
[Web API Reference](/dynamics365/customer-engagement/web-api/about)<br />
<xref href="Microsoft.Dynamics.CRM.email?text=email EntityType" />

[!INCLUDE[footer-include](../../../../includes/footer-banner.md)]