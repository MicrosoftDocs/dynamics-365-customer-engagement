---
title: "CampaignResponse Entity Reference (Developer Guide for Dynamics 365 Customer Engagement)| MicrosoftDocs"
description: "Includes schema information and supported messages for the CampaignResponse entity."
ms.date: 10/31/2017
ms.service: "crm-online"
ms.topic: "reference"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: 3948cc48-07c8-7f60-0608-71c37158ad7c
author: "JimDaly"
ms.author: "jdaly"
manager: "jdaly"
---
# CampaignResponse Entity Reference

Response from an existing or a potential new customer for a campaign.

**Added by**: Marketing Solution<br />

## Messages

|Message|Web API Operation|SDK Assembly|
|-|-|-|
|Assign|PATCH [*org URI*]/api/data/v9.0/campaignresponses(*activityid*)<br />[Update](../webapi/update-delete-entities-using-web-api.md#basic-update) `ownerid` property.|<xref:Microsoft.Crm.Sdk.Messages.AssignRequest>|
|CopyCampaignResponse|<xref href="Microsoft.Dynamics.CRM.CopyCampaignResponse?text=CopyCampaignResponse Action" />|<xref:Microsoft.Crm.Sdk.Messages.CopyCampaignResponseRequest>|
|Create|POST [*org URI*]/api/data/v9.0/campaignresponses<br />See [Create](../webapi/create-entity-web-api.md)|<xref:Microsoft.Xrm.Sdk.Messages.CreateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Create*>|
|Delete|DELETE [*org URI*]/api/data/v9.0/campaignresponses(*activityid*)<br />See [Delete](../webapi/update-delete-entities-using-web-api.md#basic-delete)|<xref:Microsoft.Xrm.Sdk.Messages.DeleteRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Delete*>|
|GrantAccess|<xref href="Microsoft.Dynamics.CRM.GrantAccess?text=GrantAccess Action" />|<xref:Microsoft.Crm.Sdk.Messages.GrantAccessRequest>|
|ModifyAccess|<xref href="Microsoft.Dynamics.CRM.ModifyAccess?text=ModifyAccess Action" />|<xref:Microsoft.Crm.Sdk.Messages.ModifyAccessRequest>|
|Retrieve|GET [*org URI*]/api/data/v9.0/campaignresponses(*activityid*)<br />See [Retrieve](../webapi/retrieve-entity-using-web-api.md)|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Retrieve*>|
|RetrieveMultiple|GET [*org URI*]/api/data/v9.0/campaignresponses<br />See [Query Data](../webapi/query-data-web-api.md)|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveMultipleRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.RetrieveMultiple*>|
|RetrievePrincipalAccess|<xref href="Microsoft.Dynamics.CRM.RetrievePrincipalAccess?text=RetrievePrincipalAccess Function" />|<xref:Microsoft.Crm.Sdk.Messages.RetrievePrincipalAccessRequest>|
|RetrieveSharedPrincipalsAndAccess|<xref href="Microsoft.Dynamics.CRM.RetrieveSharedPrincipalsAndAccess?text=RetrieveSharedPrincipalsAndAccess Function" />|<xref:Microsoft.Crm.Sdk.Messages.RetrieveSharedPrincipalsAndAccessRequest>|
|RevokeAccess|<xref href="Microsoft.Dynamics.CRM.RevokeAccess?text=RevokeAccess Action" />|<xref:Microsoft.Crm.Sdk.Messages.RevokeAccessRequest>|
|SetState|PATCH [*org URI*]/api/data/v9.0/campaignresponses(*activityid*)<br />[Update](../webapi/update-delete-entities-using-web-api.md#basic-update) `statecode` and `statuscode` properties.|<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|
|Update|PATCH [*org URI*]/api/data/v9.0/campaignresponses(*activityid*)<br />See [Update](../webapi/update-delete-entities-using-web-api.md#basic-update)|<xref:Microsoft.Xrm.Sdk.Messages.UpdateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Update*>|

## Properties

**DisplayName**: Campaign Response<br />
**DisplayCollectionName**: Campaign Responses<br />
**SchemaName**: CampaignResponse<br />
**CollectionSchemaName**: CampaignResponses<br />
**LogicalName**: campaignresponse<br />
**LogicalCollectionName**: campaignresponses<br />
**EntitySetName**: campaignresponses<br />
**PrimaryIdAttribute**: activityid<br />
**PrimaryNameAttribute**: subject<br />
**OwnershipType**: UserOwned<br />
**IsBPFEntity**: False<br />
<a name="writable-attributes"></a>

## Writable attributes

These attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

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

**Description**: For internal use only.<br />
**DisplayName**: Additional Parameters<br />
**LogicalName**: activityadditionalparams<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Memo<br />
**Format**: TextArea<br />
**IsLocalizable**: False<br />
**MaxLength**: 8192


### <a name="BKMK_ActivityId"></a> ActivityId

**Description**: Unique identifier of the campaign response.<br />
**DisplayName**: Campaign Response<br />
**LogicalName**: activityid<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: SystemRequired<br />
**IsValidForUpdate**: False<br />
**Type**: Uniqueidentifier<br />


### <a name="BKMK_ActualDurationMinutes"></a> ActualDurationMinutes

**Description**: Type the number of minutes spent on this activity. The duration is used in reporting.<br />
**DisplayName**: Actual Duration <br />
**LogicalName**: actualdurationminutes<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Integer<br />
**Format**: None<br />
**MaxValue**: 2147483647<br />
**MinValue**: 0


### <a name="BKMK_ActualEnd"></a> ActualEnd

**Description**: Enter the date when the campaign response was actually completed.<br />
**DisplayName**: Actual End<br />
**LogicalName**: actualend<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: DateTime<br />
**DateTimeBehavior**: UserLocal<br />
**Format**: DateOnly


### <a name="BKMK_ActualStart"></a> ActualStart

**Description**: Enter the actual start date and time for the campaign response.<br />
**DisplayName**: Actual Start<br />
**LogicalName**: actualstart<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: DateTime<br />
**DateTimeBehavior**: UserLocal<br />
**Format**: DateOnly


### <a name="BKMK_BCC"></a> BCC

**Description**: Blind Carbon-copy (bcc) recipients of the activity.<br />
**DisplayName**: BCC<br />
**LogicalName**: bcc<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: PartyList<br />
**Targets**: account,contact,systemuser


### <a name="BKMK_Category"></a> Category

**Description**: Type a category to identify the campaign response type, such as new business development or customer retention, to tie the campaign response to a business group or function.<br />
**DisplayName**: Category<br />
**LogicalName**: category<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 250


### <a name="BKMK_CC"></a> CC

**Description**: Carbon-copy (cc) recipients of the activity.<br />
**DisplayName**: CC<br />
**LogicalName**: cc<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: PartyList<br />
**Targets**: account,contact,systemuser


### <a name="BKMK_ChannelTypeCode"></a> ChannelTypeCode

**Description**: Select how the response was received, such as phone, letter, fax, or email.<br />
**DisplayName**: Channel<br />
**LogicalName**: channeltypecode<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Picklist<br />
**Options**:

- **Value**: 1 **Label**: Email
- **Value**: 2 **Label**: Phone
- **Value**: 3 **Label**: Fax
- **Value**: 4 **Label**: Letter
- **Value**: 5 **Label**: Appointment
- **Value**: 6 **Label**: Others



### <a name="BKMK_Community"></a> Community

**Description**: Shows how contact about the social activity originated, such as from Twitter or Facebook. This field is read-only.<br />
**DisplayName**: Social Channel<br />
**LogicalName**: community<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Picklist<br />
**Options**:

- **Value**: 0 **Label**: Other
- **Value**: 1 **Label**: Facebook
- **Value**: 2 **Label**: Twitter



### <a name="BKMK_CompanyName"></a> CompanyName

**Description**: Type the name of the company if the campaign response was received from a new prospect or customer.<br />
**DisplayName**: Company Name<br />
**LogicalName**: companyname<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_Customer"></a> Customer

**Description**: Enter the account, contact, or lead that submitted the campaign response, if it was received from an existing prospect or customer.<br />
**DisplayName**: Customer<br />
**LogicalName**: customer<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: PartyList<br />
**Targets**: account,contact,lead


### <a name="BKMK_Customers"></a> Customers

**Description**: Customer with which the activity is associated.<br />
**DisplayName**: Customers<br />
**LogicalName**: customers<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: PartyList<br />
**Targets**: account,contact


### <a name="BKMK_DeliveryPriorityCode"></a> DeliveryPriorityCode

**Description**: Priority of delivery of the activity to the email server.<br />
**DisplayName**: Delivery Priority<br />
**LogicalName**: deliveryprioritycode<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**IsValidForUpdate**: False<br />
**Type**: Picklist<br />
**Options**:

- **Value**: 0 **Label**: Low
- **Value**: 1 **Label**: Normal
- **Value**: 2 **Label**: High



### <a name="BKMK_Description"></a> Description

**Description**: Type additional information to describe the campaign response, such as key discussion points or objectives.<br />
**DisplayName**: Description<br />
**LogicalName**: description<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Memo<br />
**Format**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 2000


### <a name="BKMK_EMailAddress"></a> EMailAddress

**Description**: Type the responder's email address.<br />
**DisplayName**: Email<br />
**LogicalName**: emailaddress<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Email<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_ExchangeItemId"></a> ExchangeItemId

**Description**: The message id of activity which is returned from Exchange Server.<br />
**DisplayName**: Exchange Item ID<br />
**LogicalName**: exchangeitemid<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 200


### <a name="BKMK_ExchangeWebLink"></a> ExchangeWebLink

**Description**: Shows the web link of Activity of type email.<br />
**DisplayName**: Exchange WebLink<br />
**LogicalName**: exchangeweblink<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 1250


### <a name="BKMK_Fax"></a> Fax

**Description**: Type the responder's fax number.<br />
**DisplayName**: Fax<br />
**LogicalName**: fax<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 50


### <a name="BKMK_FirstName"></a> FirstName

**Description**: Type the responder's first name if the campaign response was received from a new prospect or customer.<br />
**DisplayName**: First Name<br />
**LogicalName**: firstname<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 50


### <a name="BKMK_from"></a> from

**Description**: For system use only.<br />
**DisplayName**: From<br />
**LogicalName**: from<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: PartyList<br />
**Targets**: account,contact,queue,systemuser


### <a name="BKMK_ImportSequenceNumber"></a> ImportSequenceNumber

**Description**: Sequence number of the import that created this record.<br />
**DisplayName**: Import Sequence Number<br />
**LogicalName**: importsequencenumber<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**IsValidForUpdate**: False<br />
**Type**: Integer<br />
**Format**: None<br />
**MaxValue**: 2147483647<br />
**MinValue**: -2147483648


### <a name="BKMK_IsBilled"></a> IsBilled

**Description**: Specifies whether the campaign response was billed as part of resolving a case.<br />
**DisplayName**: Is Billed<br />
**LogicalName**: isbilled<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Boolean<br />
**Options**:

- **TrueOption Value**: 1 **Label**: Yes
- **FalseOption Value**: 0 **Label**: No

**DefaultValue**: False


### <a name="BKMK_IsMapiPrivate"></a> IsMapiPrivate

**Description**: For internal use only.<br />
**DisplayName**: Is Private<br />
**LogicalName**: ismapiprivate<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Boolean<br />
**Options**:

- **TrueOption Value**: 1 **Label**: Yes
- **FalseOption Value**: 0 **Label**: No

**DefaultValue**: False


### <a name="BKMK_IsWorkflowCreated"></a> IsWorkflowCreated

**Description**: Specifies whether the campaign response is created by a workflow rule.<br />
**DisplayName**: Is Workflow Created<br />
**LogicalName**: isworkflowcreated<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Boolean<br />
**Options**:

- **TrueOption Value**: 1 **Label**: Yes
- **FalseOption Value**: 0 **Label**: No

**DefaultValue**: False


### <a name="BKMK_LastName"></a> LastName

**Description**: Type the responder's last name if the campaign response was received from a new prospect or customer.<br />
**DisplayName**: Last Name<br />
**LogicalName**: lastname<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 50


### <a name="BKMK_LastOnHoldTime"></a> LastOnHoldTime

**Description**: Contains the date and time stamp of the last on hold time.<br />
**DisplayName**: Last On Hold Time<br />
**LogicalName**: lastonholdtime<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: DateTime<br />
**DateTimeBehavior**: UserLocal<br />
**Format**: DateAndTime


### <a name="BKMK_LeftVoiceMail"></a> LeftVoiceMail

**Description**: Left the voice mail<br />
**DisplayName**: Left Voice Mail<br />
**LogicalName**: leftvoicemail<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Boolean<br />
**Options**:

- **TrueOption Value**: 1 **Label**: Yes
- **FalseOption Value**: 0 **Label**: No

**DefaultValue**: False


### <a name="BKMK_OptionalAttendees"></a> OptionalAttendees

**Description**: List of optional attendees for the activity.<br />
**DisplayName**: Optional Attendees<br />
**LogicalName**: optionalattendees<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: PartyList<br />
**Targets**: account,contact,systemuser


### <a name="BKMK_Organizer"></a> Organizer

**Description**: Person who organized the activity.<br />
**DisplayName**: Organizer<br />
**LogicalName**: organizer<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: PartyList<br />
**Targets**: systemuser


### <a name="BKMK_OriginatingActivityId"></a> OriginatingActivityId

**Description**: Choose the phone call, email, fax, letter, or appointment activity that led the prospect or customer to respond to the campaign.<br />
**DisplayName**: Originating Activity<br />
**LogicalName**: originatingactivityid<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: appointment,email,fax,letter,phonecall


### <a name="BKMK_OriginatingActivityIdTypeCode"></a> OriginatingActivityIdTypeCode

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: originatingactivityidtypecode<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: EntityName<br />


### <a name="BKMK_OverriddenCreatedOn"></a> OverriddenCreatedOn

**Description**: Date and time that the record was migrated.<br />
**DisplayName**: Record Created On<br />
**LogicalName**: overriddencreatedon<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**IsValidForUpdate**: False<br />
**Type**: DateTime<br />
**DateTimeBehavior**: UserLocal<br />
**Format**: DateOnly


### <a name="BKMK_OwnerId"></a> OwnerId

**Description**: Unique identifier of the user or team who owns the activity.<br />
**DisplayName**: Owner<br />
**LogicalName**: ownerid<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: SystemRequired<br />
**Type**: Owner<br />
**Targets**: systemuser,team


### <a name="BKMK_OwnerIdType"></a> OwnerIdType

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: owneridtype<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: SystemRequired<br />
**Type**: EntityName<br />


### <a name="BKMK_Partner"></a> Partner

**Description**: Enter the vendor account or contact to capture any third-party used to obtain the campaign response.<br />
**DisplayName**: Outsource Vendor<br />
**LogicalName**: partner<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: PartyList<br />
**Targets**: account,contact


### <a name="BKMK_Partners"></a> Partners

**Description**: Outsource vendor with which activity is associated.<br />
**DisplayName**: Outsource Vendors<br />
**LogicalName**: partners<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: PartyList<br />
**Targets**: account,contact


### <a name="BKMK_PriorityCode"></a> PriorityCode

**Description**: Select the priority so that preferred customers or critical issues are handled quickly.<br />
**DisplayName**: Priority<br />
**LogicalName**: prioritycode<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Picklist<br />
**Options**:

- **Value**: 0 **Label**: Low
- **Value**: 1 **Label**: Normal
- **Value**: 2 **Label**: High



### <a name="BKMK_ProcessId"></a> ProcessId

**Description**: Unique identifier of the Process.<br />
**DisplayName**: Process<br />
**LogicalName**: processid<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Uniqueidentifier<br />


### <a name="BKMK_PromotionCodeName"></a> PromotionCodeName

**Description**: Type a promotional code to track sales related to the campaign response or to allow the responder to redeem a discount offer.<br />
**DisplayName**: Promotion Code<br />
**LogicalName**: promotioncodename<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 250


### <a name="BKMK_ReceivedOn"></a> ReceivedOn

**Description**: Enter the date when the campaign response was received.<br />
**DisplayName**: Received On<br />
**LogicalName**: receivedon<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: DateTime<br />
**DateTimeBehavior**: UserLocal<br />
**Format**: DateOnly


### <a name="BKMK_RegardingObjectId"></a> RegardingObjectId

**Description**: Choose the parent campaign so that the campaign's response rate is tracked correctly.<br />
**DisplayName**: Parent Campaign<br />
**LogicalName**: regardingobjectid<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: ApplicationRequired<br />
**IsValidForUpdate**: False<br />
**Type**: Lookup<br />
**Targets**: bulkoperation,campaign


### <a name="BKMK_RegardingObjectTypeCode"></a> RegardingObjectTypeCode

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: regardingobjecttypecode<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**IsValidForUpdate**: False<br />
**Type**: EntityName<br />


### <a name="BKMK_RequiredAttendees"></a> RequiredAttendees

**Description**: List of required attendees for the activity.<br />
**DisplayName**: Required Attendees<br />
**LogicalName**: requiredattendees<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: PartyList<br />
**Targets**: account,contact,systemuser


### <a name="BKMK_Resources"></a> Resources

**Description**: Users or facility/equipment that are required for the activity.<br />
**DisplayName**: Resources<br />
**LogicalName**: resources<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: PartyList<br />
**Targets**: systemuser


### <a name="BKMK_ResponseCode"></a> ResponseCode

**Description**: Select the type of response from the prospect or customer to indicate their interest in the campaign.<br />
**DisplayName**: Response Code<br />
**LogicalName**: responsecode<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Picklist<br />
**Options**:

- **Value**: 1 **Label**: Interested
- **Value**: 2 **Label**: Not Interested
- **Value**: 3 **Label**: Do Not Send Marketing Materials
- **Value**: 4 **Label**: Error



### <a name="BKMK_ScheduledEnd"></a> ScheduledEnd

**Description**: Enter the expected due date and time for the activity to be completed to provide details about the timing of the campaign response.<br />
**DisplayName**: Close By<br />
**LogicalName**: scheduledend<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: DateTime<br />
**DateTimeBehavior**: UserLocal<br />
**Format**: DateOnly


### <a name="BKMK_ScheduledStart"></a> ScheduledStart

**Description**: Enter the expected start date and time for the activity to provide details about the timing of the campaign response.<br />
**DisplayName**: Scheduled Start<br />
**LogicalName**: scheduledstart<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: DateTime<br />
**DateTimeBehavior**: UserLocal<br />
**Format**: DateOnly


### <a name="BKMK_ServiceId"></a> ServiceId

**Description**: Unique identifier for the associated service.<br />
**DisplayName**: Service<br />
**LogicalName**: serviceid<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: service


### <a name="BKMK_SLAId"></a> SLAId

**Description**: Choose the service level agreement (SLA) that you want to apply to the case record.<br />
**DisplayName**: SLA<br />
**LogicalName**: slaid<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: sla


### <a name="BKMK_SortDate"></a> SortDate

**Description**: Shows the date and time by which the activities are sorted.<br />
**DisplayName**: Sort Date<br />
**LogicalName**: sortdate<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: DateTime<br />
**DateTimeBehavior**: UserLocal<br />
**Format**: DateAndTime


### <a name="BKMK_StageId"></a> StageId

**Description**: Unique identifier of the Stage.<br />
**DisplayName**: Process Stage<br />
**LogicalName**: stageid<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Uniqueidentifier<br />


### <a name="BKMK_StateCode"></a> StateCode

**Description**: Shows whether the campaign response is open, closed, or canceled. Closed and canceled campaign responses are read-only and can't be edited.<br />
**DisplayName**: Status<br />
**LogicalName**: statecode<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: SystemRequired<br />
**IsValidForCreate**: False<br />
**Type**: State<br />
**Options**:

- **Value**: 0 **Label**: Open **DefaultStatus**: 1 **InvariantName**: Open
- **Value**: 1 **Label**: Closed **DefaultStatus**: 2 **InvariantName**: Closed
- **Value**: 2 **Label**: Canceled **DefaultStatus**: 3 **InvariantName**: Canceled



### <a name="BKMK_StatusCode"></a> StatusCode

**Description**: Select the campaign response's status.<br />
**DisplayName**: Status Reason<br />
**LogicalName**: statuscode<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Status<br />
**Options**:

- **Value**: 1 **Label**: Open **State**: 0
- **Value**: 2 **Label**: Closed **State**: 1
- **Value**: 3 **Label**: Canceled **State**: 2



### <a name="BKMK_Subcategory"></a> Subcategory

**Description**: Type a subcategory to identify the campaign response type and relate the activity to a specific product, sales region, business group, or other function.<br />
**DisplayName**: Sub-Category<br />
**LogicalName**: subcategory<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 250


### <a name="BKMK_Subject"></a> Subject

**Description**: Type a short description about the objective or primary topic of the campaign response.<br />
**DisplayName**: Subject<br />
**LogicalName**: subject<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: ApplicationRequired<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 200


### <a name="BKMK_Telephone"></a> Telephone

**Description**: Type the responder's primary phone number.<br />
**DisplayName**: Phone<br />
**LogicalName**: telephone<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 50


### <a name="BKMK_TimeZoneRuleVersionNumber"></a> TimeZoneRuleVersionNumber

**Description**: For internal use only.<br />
**DisplayName**: Time Zone Rule Version Number<br />
**LogicalName**: timezoneruleversionnumber<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Integer<br />
**Format**: None<br />
**MaxValue**: 2147483647<br />
**MinValue**: -2147483648


### <a name="BKMK_To"></a> To

**Description**: Person who is the receiver of the activity.<br />
**DisplayName**: To<br />
**LogicalName**: to<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: PartyList<br />
**Targets**: account,contact,systemuser


### <a name="BKMK_TransactionCurrencyId"></a> TransactionCurrencyId

**Description**: Choose the local currency for the record to make sure budgets are reported in the correct currency.<br />
**DisplayName**: Currency<br />
**LogicalName**: transactioncurrencyid<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: transactioncurrency


### <a name="BKMK_TraversedPath"></a> TraversedPath

**Description**: For internal use only.<br />
**DisplayName**: Traversed Path<br />
**LogicalName**: traversedpath<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 1250


### <a name="BKMK_UTCConversionTimeZoneCode"></a> UTCConversionTimeZoneCode

**Description**: Time zone code that was in use when the record was created.<br />
**DisplayName**: UTC Conversion Time Zone Code<br />
**LogicalName**: utcconversiontimezonecode<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Integer<br />
**Format**: None<br />
**MaxValue**: 2147483647<br />
**MinValue**: -2147483648


### <a name="BKMK_YomiCompanyName"></a> YomiCompanyName

**Description**: Type the phonetic spelling of the company name, if specified in Japanese, to make sure the name is pronounced correctly in phone calls and other communications.<br />
**DisplayName**: Yomi Company Name<br />
**LogicalName**: yomicompanyname<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: PhoneticGuide<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_YomiFirstName"></a> YomiFirstName

**Description**: Type the phonetic spelling of the campaign responder's first name, if specified in Japanese, to make sure the name is pronounced correctly in phone calls and other communications.<br />
**DisplayName**: Yomi First Name<br />
**LogicalName**: yomifirstname<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: PhoneticGuide<br />
**IsLocalizable**: False<br />
**MaxLength**: 150


### <a name="BKMK_YomiLastName"></a> YomiLastName

**Description**: Type the phonetic spelling of the campaign responder's last name, if specified in Japanese, to make sure the name is pronounced correctly in phone calls and other communications.<br />
**DisplayName**: Yomi Last Name<br />
**LogicalName**: yomilastname<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: PhoneticGuide<br />
**IsLocalizable**: False<br />
**MaxLength**: 150

<a name="read-only-attributes"></a>
## Read-only attributes
These attributes return false for both **IsValidForCreate** or **IsValidForUpdate**. Listed by **SchemaName**.

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

**Description**: Type of activity.<br />
**DisplayName**: Activity Type<br />
**LogicalName**: activitytypecode<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: SystemRequired<br />
**Type**: EntityName<br />


### <a name="BKMK_CreatedBy"></a> CreatedBy

**Description**: Unique identifier of the user who created the activity.<br />
**DisplayName**: Created By<br />
**LogicalName**: createdby<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: systemuser


### <a name="BKMK_CreatedByName"></a> CreatedByName

**Description**: Name of the user who created the campaign response.<br />
**DisplayName**: <br />
**LogicalName**: createdbyname<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_CreatedByYomiName"></a> CreatedByYomiName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: createdbyyominame<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_CreatedOn"></a> CreatedOn

**Description**: Date and time when the activity was created.<br />
**DisplayName**: Date Created<br />
**LogicalName**: createdon<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: DateTime<br />
**DateTimeBehavior**: UserLocal<br />
**Format**: DateOnly


### <a name="BKMK_CreatedOnBehalfBy"></a> CreatedOnBehalfBy

**Description**: Unique identifier of the delegate user who created the activitypointer.<br />
**DisplayName**: Created By (Delegate)<br />
**LogicalName**: createdonbehalfby<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: systemuser


### <a name="BKMK_CreatedOnBehalfByName"></a> CreatedOnBehalfByName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: createdonbehalfbyname<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_CreatedOnBehalfByYomiName"></a> CreatedOnBehalfByYomiName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: createdonbehalfbyyominame<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_DeliveryLastAttemptedOn"></a> DeliveryLastAttemptedOn

**Description**: Date and time when the delivery of the activity was last attempted.<br />
**DisplayName**: Date Delivery Last Attempted<br />
**LogicalName**: deliverylastattemptedon<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: DateTime<br />
**DateTimeBehavior**: UserLocal<br />
**Format**: DateAndTime


### <a name="BKMK_ExchangeRate"></a> ExchangeRate

**Description**: Shows the conversion rate of the record's currency. The exchange rate is used to convert all money fields in the record from the local currency to the system's default currency.<br />
**DisplayName**: Exchange Rate<br />
**LogicalName**: exchangerate<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Decimal<br />
**MaxValue**: 100000000000<br />
**MinValue**: 0.0000000001<br />
**Precision**: 10


### <a name="BKMK_InstanceTypeCode"></a> InstanceTypeCode

**Description**: Type of instance of a recurring series.<br />
**DisplayName**: Recurring Instance Type<br />
**LogicalName**: instancetypecode<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: SystemRequired<br />
**Type**: Picklist<br />
**Options**:

- **Value**: 0 **Label**: Not Recurring
- **Value**: 1 **Label**: Recurring Master
- **Value**: 2 **Label**: Recurring Instance
- **Value**: 3 **Label**: Recurring Exception
- **Value**: 4 **Label**: Recurring Future Exception



### <a name="BKMK_IsRegularActivity"></a> IsRegularActivity

**Description**: Information regarding whether the activity is a regular activity type or event type.<br />
**DisplayName**: Is Regular Activity<br />
**LogicalName**: isregularactivity<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: SystemRequired<br />
**Type**: Boolean<br />
**Options**:

- **TrueOption Value**: 1 **Label**: Yes
- **FalseOption Value**: 0 **Label**: No

**DefaultValue**: False


### <a name="BKMK_ModifiedBy"></a> ModifiedBy

**Description**: Unique identifier of user who last modified the activity.<br />
**DisplayName**: Modified By<br />
**LogicalName**: modifiedby<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: systemuser


### <a name="BKMK_ModifiedByName"></a> ModifiedByName

**Description**: Name of the user who last modified the campaign response.<br />
**DisplayName**: <br />
**LogicalName**: modifiedbyname<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_ModifiedByYomiName"></a> ModifiedByYomiName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: modifiedbyyominame<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_ModifiedOn"></a> ModifiedOn

**Description**: Date and time when activity was last modified.<br />
**DisplayName**: Last Updated<br />
**LogicalName**: modifiedon<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: DateTime<br />
**DateTimeBehavior**: UserLocal<br />
**Format**: DateOnly


### <a name="BKMK_ModifiedOnBehalfBy"></a> ModifiedOnBehalfBy

**Description**: Unique identifier of the delegate user who last modified the activitypointer.<br />
**DisplayName**: Modified By (Delegate)<br />
**LogicalName**: modifiedonbehalfby<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: systemuser


### <a name="BKMK_ModifiedOnBehalfByName"></a> ModifiedOnBehalfByName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: modifiedonbehalfbyname<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_ModifiedOnBehalfByYomiName"></a> ModifiedOnBehalfByYomiName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: modifiedonbehalfbyyominame<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_OnHoldTime"></a> OnHoldTime

**Description**: Shows how long, in minutes, that the record was on hold.<br />
**DisplayName**: On Hold Time (Minutes)<br />
**LogicalName**: onholdtime<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Integer<br />
**Format**: None<br />
**MaxValue**: 2147483647<br />
**MinValue**: -2147483648


### <a name="BKMK_OriginatingActivityIdYomiName"></a> OriginatingActivityIdYomiName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: originatingactivityidyominame<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 4000


### <a name="BKMK_OriginatingActivityName"></a> OriginatingActivityName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: originatingactivityname<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_OwnerIdName"></a> OwnerIdName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: owneridname<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: SystemRequired<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_OwnerIdYomiName"></a> OwnerIdYomiName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: owneridyominame<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: SystemRequired<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_OwningBusinessUnit"></a> OwningBusinessUnit

**Description**: Unique identifier of the business unit that owns the activity.<br />
**DisplayName**: Owning Business Unit<br />
**LogicalName**: owningbusinessunit<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: businessunit


### <a name="BKMK_OwningTeam"></a> OwningTeam

**Description**: Unique identifier of the team that owns the activity.<br />
**DisplayName**: Owning Team<br />
**LogicalName**: owningteam<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: team


### <a name="BKMK_OwningUser"></a> OwningUser

**Description**: Unique identifier of the user that owns the activity.<br />
**DisplayName**: Owning User<br />
**LogicalName**: owninguser<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: systemuser


### <a name="BKMK_PostponeActivityProcessingUntil"></a> PostponeActivityProcessingUntil

**Description**: For internal use only.<br />
**DisplayName**: Delay activity processing until<br />
**LogicalName**: postponeactivityprocessinguntil<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: DateTime<br />
**DateTimeBehavior**: UserLocal<br />
**Format**: DateAndTime


### <a name="BKMK_RegardingObjectIdName"></a> RegardingObjectIdName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: regardingobjectidname<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_RegardingObjectIdYomiName"></a> RegardingObjectIdYomiName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: regardingobjectidyominame<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_ScheduledDurationMinutes"></a> ScheduledDurationMinutes

**Description**: Scheduled duration of the campaign response in minutes.<br />
**DisplayName**: Scheduled Duration<br />
**LogicalName**: scheduleddurationminutes<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Integer<br />
**Format**: None<br />
**MaxValue**: 2147483647<br />
**MinValue**: 0


### <a name="BKMK_SenderMailboxId"></a> SenderMailboxId

**Description**: Unique identifier of the mailbox associated with the sender of the email message.<br />
**DisplayName**: Sender's Mailbox<br />
**LogicalName**: sendermailboxid<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: mailbox


### <a name="BKMK_SenderMailboxIdName"></a> SenderMailboxIdName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: sendermailboxidname<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_SentOn"></a> SentOn

**Description**: Date and time when the activity was sent.<br />
**DisplayName**: Date Sent<br />
**LogicalName**: senton<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: DateTime<br />
**DateTimeBehavior**: UserLocal<br />
**Format**: DateAndTime


### <a name="BKMK_SeriesId"></a> SeriesId

**Description**: Uniqueidentifier specifying the id of recurring series of an instance.<br />
**DisplayName**: Series Id<br />
**LogicalName**: seriesid<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Uniqueidentifier<br />


### <a name="BKMK_SLAInvokedId"></a> SLAInvokedId

**Description**: Last SLA that was applied to this case. This field is for internal use only.<br />
**DisplayName**: Last SLA applied<br />
**LogicalName**: slainvokedid<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: sla


### <a name="BKMK_SLAInvokedIdName"></a> SLAInvokedIdName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: slainvokedidname<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_SLAName"></a> SLAName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: slaname<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_TransactionCurrencyIdName"></a> TransactionCurrencyIdName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: transactioncurrencyidname<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_VersionNumber"></a> VersionNumber

**Description**: Version number of the activity.<br />
**DisplayName**: Version Number<br />
**LogicalName**: versionnumber<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: BigInt<br />
**MaxValue**: 9223372036854775807<br />
**MinValue**: -9223372036854775808<br />

<a name="onetomany"></a>

## One-To-Many Relationships

Listed by **SchemaName**.

- [campaignresponse_activity_parties](#BKMK_campaignresponse_activity_parties)
- [CampaignResponse_SyncErrors](#BKMK_CampaignResponse_SyncErrors)
- [CampaignResponse_DuplicateMatchingRecord](#BKMK_CampaignResponse_DuplicateMatchingRecord)
- [CampaignResponse_DuplicateBaseRecord](#BKMK_CampaignResponse_DuplicateBaseRecord)
- [CampaignResponse_AsyncOperations](#BKMK_CampaignResponse_AsyncOperations)
- [campaignresponse_MailboxTrackingFolders](#BKMK_campaignresponse_MailboxTrackingFolders)
- [userentityinstancedata_campaignresponse](#BKMK_userentityinstancedata_campaignresponse)
- [CampaignResponse_ProcessSessions](#BKMK_CampaignResponse_ProcessSessions)
- [CampaignResponse_BulkDeleteFailures](#BKMK_CampaignResponse_BulkDeleteFailures)
- [campaignresponse_principalobjectattributeaccess](#BKMK_campaignresponse_principalobjectattributeaccess)
- [CampaignResponse_QueueItem](#BKMK_CampaignResponse_QueueItem)
- [CampaignResponse_Annotation](#BKMK_CampaignResponse_Annotation)
- [CampaignResponse_Lead](#BKMK_CampaignResponse_Lead)


### <a name="BKMK_campaignresponse_activity_parties"></a> campaignresponse_activity_parties

Same as activityparty entity [campaignresponse_activity_parties](activityparty.md#BKMK_campaignresponse_activity_parties) Many-To-One relationship.

**ReferencingEntity**: activityparty<br />
**ReferencingAttribute**: activityid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: False<br />
**ReferencedEntityNavigationPropertyName**: campaignresponse_activity_parties<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: NoCascade
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_CampaignResponse_SyncErrors"></a> CampaignResponse_SyncErrors

Same as syncerror entity [CampaignResponse_SyncErrors](syncerror.md#BKMK_CampaignResponse_SyncErrors) Many-To-One relationship.

**ReferencingEntity**: syncerror<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: CampaignResponse_SyncErrors<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: Cascade
- **Delete**: Cascade
- **Merge**: Cascade
- **Reparent**: Cascade
- **Share**: Cascade
- **Unshare**: Cascade


### <a name="BKMK_CampaignResponse_DuplicateMatchingRecord"></a> CampaignResponse_DuplicateMatchingRecord

Same as duplicaterecord entity [CampaignResponse_DuplicateMatchingRecord](duplicaterecord.md#BKMK_CampaignResponse_DuplicateMatchingRecord) Many-To-One relationship.

**ReferencingEntity**: duplicaterecord<br />
**ReferencingAttribute**: duplicaterecordid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: False<br />
**ReferencedEntityNavigationPropertyName**: CampaignResponse_DuplicateMatchingRecord<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: Cascade
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_CampaignResponse_DuplicateBaseRecord"></a> CampaignResponse_DuplicateBaseRecord

Same as duplicaterecord entity [CampaignResponse_DuplicateBaseRecord](duplicaterecord.md#BKMK_CampaignResponse_DuplicateBaseRecord) Many-To-One relationship.

**ReferencingEntity**: duplicaterecord<br />
**ReferencingAttribute**: baserecordid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: False<br />
**ReferencedEntityNavigationPropertyName**: CampaignResponse_DuplicateBaseRecord<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: Cascade
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_CampaignResponse_AsyncOperations"></a> CampaignResponse_AsyncOperations

Same as asyncoperation entity [CampaignResponse_AsyncOperations](asyncoperation.md#BKMK_CampaignResponse_AsyncOperations) Many-To-One relationship.

**ReferencingEntity**: asyncoperation<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: False<br />
**ReferencedEntityNavigationPropertyName**: CampaignResponse_AsyncOperations<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: NoCascade
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_campaignresponse_MailboxTrackingFolders"></a> campaignresponse_MailboxTrackingFolders

Same as mailboxtrackingfolder entity [campaignresponse_MailboxTrackingFolders](mailboxtrackingfolder.md#BKMK_campaignresponse_MailboxTrackingFolders) Many-To-One relationship.

**ReferencingEntity**: mailboxtrackingfolder<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: campaignresponse_MailboxTrackingFolders<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: Cascade
- **Delete**: Cascade
- **Merge**: NoCascade
- **Reparent**: Cascade
- **Share**: Cascade
- **Unshare**: Cascade


### <a name="BKMK_userentityinstancedata_campaignresponse"></a> userentityinstancedata_campaignresponse

Same as userentityinstancedata entity [userentityinstancedata_campaignresponse](userentityinstancedata.md#BKMK_userentityinstancedata_campaignresponse) Many-To-One relationship.

**ReferencingEntity**: userentityinstancedata<br />
**ReferencingAttribute**: objectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: False<br />
**ReferencedEntityNavigationPropertyName**: userentityinstancedata_campaignresponse<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: Cascade
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_CampaignResponse_ProcessSessions"></a> CampaignResponse_ProcessSessions

Same as processsession entity [CampaignResponse_ProcessSessions](processsession.md#BKMK_CampaignResponse_ProcessSessions) Many-To-One relationship.

**ReferencingEntity**: processsession<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: False<br />
**ReferencedEntityNavigationPropertyName**: CampaignResponse_ProcessSessions<br />
**AssociatedMenuConfiguration**:

- **Behavior**: UseCollectionName
- **Group**: Details
- **Label**: 
- **Order**: 110

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: NoCascade
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_CampaignResponse_BulkDeleteFailures"></a> CampaignResponse_BulkDeleteFailures

Same as bulkdeletefailure entity [CampaignResponse_BulkDeleteFailures](bulkdeletefailure.md#BKMK_CampaignResponse_BulkDeleteFailures) Many-To-One relationship.

**ReferencingEntity**: bulkdeletefailure<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: False<br />
**ReferencedEntityNavigationPropertyName**: CampaignResponse_BulkDeleteFailures<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: Cascade
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_campaignresponse_principalobjectattributeaccess"></a> campaignresponse_principalobjectattributeaccess

Same as principalobjectattributeaccess entity [campaignresponse_principalobjectattributeaccess](principalobjectattributeaccess.md#BKMK_campaignresponse_principalobjectattributeaccess) Many-To-One relationship.

**ReferencingEntity**: principalobjectattributeaccess<br />
**ReferencingAttribute**: objectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: False<br />
**ReferencedEntityNavigationPropertyName**: campaignresponse_principalobjectattributeaccess<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: Cascade
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_CampaignResponse_QueueItem"></a> CampaignResponse_QueueItem

Same as queueitem entity [CampaignResponse_QueueItem](queueitem.md#BKMK_CampaignResponse_QueueItem) Many-To-One relationship.

**ReferencingEntity**: queueitem<br />
**ReferencingAttribute**: objectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: CampaignResponse_QueueItem<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: Cascade
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_CampaignResponse_Annotation"></a> CampaignResponse_Annotation

Same as annotation entity [CampaignResponse_Annotation](annotation.md#BKMK_CampaignResponse_Annotation) Many-To-One relationship.

**ReferencingEntity**: annotation<br />
**ReferencingAttribute**: objectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: CampaignResponse_Annotation<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: Cascade
- **Delete**: Cascade
- **Merge**: NoCascade
- **Reparent**: Cascade
- **Share**: Cascade
- **Unshare**: Cascade


### <a name="BKMK_CampaignResponse_Lead"></a> CampaignResponse_Lead

Same as lead entity [CampaignResponse_Lead](lead.md#BKMK_CampaignResponse_Lead) Many-To-One relationship.

**ReferencingEntity**: lead<br />
**ReferencingAttribute**: relatedobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: CampaignResponse_Lead<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: RemoveLink
- **Merge**: Cascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade

<a name="manytoone"></a>

## Many-To-One Relationships

Each Many-To-One relationship is defined by a corresponding One-To-Many relationship with the related entity. Listed by **SchemaName**.

- [lead_CampaignResponses](#BKMK_lead_CampaignResponses)
- [bookableresourcebooking_CampaignResponses](#BKMK_bookableresourcebooking_CampaignResponses)
- [bookableresourcebookingheader_CampaignResponses](#BKMK_bookableresourcebookingheader_CampaignResponses)
- [bulkoperation_CampaignResponses](#BKMK_bulkoperation_CampaignResponses)
- [Campaign_CampaignResponses](#BKMK_Campaign_CampaignResponses)
- [campaignactivity_CampaignResponses](#BKMK_campaignactivity_CampaignResponses)
- [interactionforemail_CampaignResponses](#BKMK_interactionforemail_CampaignResponses)
- [knowledgebaserecord_CampaignResponses](#BKMK_knowledgebaserecord_CampaignResponses)
- [account_CampaignResponses](#BKMK_account_CampaignResponses)
- [lk_campaignresponse_createdby](#BKMK_lk_campaignresponse_createdby)
- [contact_CampaignResponses](#BKMK_contact_CampaignResponses)
- [campaignresponse_mailbox_sendermailboxid](#BKMK_campaignresponse_mailbox_sendermailboxid)
- [TransactionCurrency_CampaignResponse](#BKMK_TransactionCurrency_CampaignResponse)
- [user_campaignresponse](#BKMK_user_campaignresponse)
- [campaignresponse_sla_slaid](#BKMK_campaignresponse_sla_slaid)
- [business_unit_campaignresponse_activities](#BKMK_business_unit_campaignresponse_activities)
- [knowledgearticle_CampaignResponses](#BKMK_knowledgearticle_CampaignResponses)
- [lk_campaignresponse_modifiedonbehalfby](#BKMK_lk_campaignresponse_modifiedonbehalfby)
- [lk_campaignresponse_createdonbehalfby](#BKMK_lk_campaignresponse_createdonbehalfby)
- [lk_campaignresponse_modifiedby](#BKMK_lk_campaignresponse_modifiedby)
- [team_campaignresponse](#BKMK_team_campaignresponse)
- [campaignresponse_sla_slainvokedid](#BKMK_campaignresponse_sla_slainvokedid)
- [activity_pointer_campaignresponse](#BKMK_activity_pointer_campaignresponse)
- [processstage_campaignresponses](#BKMK_processstage_campaignresponses)
- [activity_campaignresponse](#BKMK_activity_campaignresponse)
- [appointment_campaignresponse](#BKMK_appointment_campaignresponse)
- [BulkOperation_CampaignResponse](#BKMK_BulkOperation_CampaignResponse)
- [email_campaignresponse](#BKMK_email_campaignresponse)
- [fax_campaignresponse](#BKMK_fax_campaignresponse)
- [letter_campaignresponse](#BKMK_letter_campaignresponse)
- [phonecall_campaignresponse](#BKMK_phonecall_campaignresponse)
- [recurringappointmentmaster_campaignresponse](#BKMK_recurringappointmentmaster_campaignresponse)
- [CampaignResponse_IncidentResolutions](#BKMK_CampaignResponse_IncidentResolutions)
- [CampaignResponse_ServiceAppointments](#BKMK_CampaignResponse_ServiceAppointments)
- [CampaignResponse_OpportunityCloses](#BKMK_CampaignResponse_OpportunityCloses)
- [CampaignResponse_OrderCloses](#BKMK_CampaignResponse_OrderCloses)
- [CampaignResponse_QuoteCloses](#BKMK_CampaignResponse_QuoteCloses)
- [CampaignResponse_msdyn_bookingalerts](#BKMK_CampaignResponse_msdyn_bookingalerts)
- [CampaignResponse_msdyn_approvals](#BKMK_CampaignResponse_msdyn_approvals)


### <a name="BKMK_lead_CampaignResponses"></a> lead_CampaignResponses

See lead Entity [lead_CampaignResponses](lead.md#BKMK_lead_CampaignResponses) One-To-Many relationship.

### <a name="BKMK_bookableresourcebooking_CampaignResponses"></a> bookableresourcebooking_CampaignResponses

See bookableresourcebooking Entity [bookableresourcebooking_CampaignResponses](bookableresourcebooking.md#BKMK_bookableresourcebooking_CampaignResponses) One-To-Many relationship.

### <a name="BKMK_bookableresourcebookingheader_CampaignResponses"></a> bookableresourcebookingheader_CampaignResponses

See bookableresourcebookingheader Entity [bookableresourcebookingheader_CampaignResponses](bookableresourcebookingheader.md#BKMK_bookableresourcebookingheader_CampaignResponses) One-To-Many relationship.

### <a name="BKMK_bulkoperation_CampaignResponses"></a> bulkoperation_CampaignResponses

See bulkoperation Entity [bulkoperation_CampaignResponses](bulkoperation.md#BKMK_bulkoperation_CampaignResponses) One-To-Many relationship.

### <a name="BKMK_Campaign_CampaignResponses"></a> Campaign_CampaignResponses

See campaign Entity [Campaign_CampaignResponses](campaign.md#BKMK_Campaign_CampaignResponses) One-To-Many relationship.

### <a name="BKMK_campaignactivity_CampaignResponses"></a> campaignactivity_CampaignResponses

See campaignactivity Entity [campaignactivity_CampaignResponses](campaignactivity.md#BKMK_campaignactivity_CampaignResponses) One-To-Many relationship.

### <a name="BKMK_interactionforemail_CampaignResponses"></a> interactionforemail_CampaignResponses

See interactionforemail Entity [interactionforemail_CampaignResponses](interactionforemail.md#BKMK_interactionforemail_CampaignResponses) One-To-Many relationship.

### <a name="BKMK_knowledgebaserecord_CampaignResponses"></a> knowledgebaserecord_CampaignResponses

See knowledgebaserecord Entity [knowledgebaserecord_CampaignResponses](knowledgebaserecord.md#BKMK_knowledgebaserecord_CampaignResponses) One-To-Many relationship.

### <a name="BKMK_account_CampaignResponses"></a> account_CampaignResponses

See account Entity [account_CampaignResponses](account.md#BKMK_account_CampaignResponses) One-To-Many relationship.

### <a name="BKMK_lk_campaignresponse_createdby"></a> lk_campaignresponse_createdby

See systemuser Entity [lk_campaignresponse_createdby](systemuser.md#BKMK_lk_campaignresponse_createdby) One-To-Many relationship.

### <a name="BKMK_contact_CampaignResponses"></a> contact_CampaignResponses

See contact Entity [contact_CampaignResponses](contact.md#BKMK_contact_CampaignResponses) One-To-Many relationship.

### <a name="BKMK_campaignresponse_mailbox_sendermailboxid"></a> campaignresponse_mailbox_sendermailboxid

See mailbox Entity [campaignresponse_mailbox_sendermailboxid](mailbox.md#BKMK_campaignresponse_mailbox_sendermailboxid) One-To-Many relationship.

### <a name="BKMK_TransactionCurrency_CampaignResponse"></a> TransactionCurrency_CampaignResponse

See transactioncurrency Entity [TransactionCurrency_CampaignResponse](transactioncurrency.md#BKMK_TransactionCurrency_CampaignResponse) One-To-Many relationship.

### <a name="BKMK_user_campaignresponse"></a> user_campaignresponse

See systemuser Entity [user_campaignresponse](systemuser.md#BKMK_user_campaignresponse) One-To-Many relationship.

### <a name="BKMK_campaignresponse_sla_slaid"></a> campaignresponse_sla_slaid

See sla Entity [campaignresponse_sla_slaid](sla.md#BKMK_campaignresponse_sla_slaid) One-To-Many relationship.

### <a name="BKMK_business_unit_campaignresponse_activities"></a> business_unit_campaignresponse_activities

See businessunit Entity [business_unit_campaignresponse_activities](businessunit.md#BKMK_business_unit_campaignresponse_activities) One-To-Many relationship.

### <a name="BKMK_knowledgearticle_CampaignResponses"></a> knowledgearticle_CampaignResponses

See knowledgearticle Entity [knowledgearticle_CampaignResponses](knowledgearticle.md#BKMK_knowledgearticle_CampaignResponses) One-To-Many relationship.

### <a name="BKMK_lk_campaignresponse_modifiedonbehalfby"></a> lk_campaignresponse_modifiedonbehalfby

See systemuser Entity [lk_campaignresponse_modifiedonbehalfby](systemuser.md#BKMK_lk_campaignresponse_modifiedonbehalfby) One-To-Many relationship.

### <a name="BKMK_lk_campaignresponse_createdonbehalfby"></a> lk_campaignresponse_createdonbehalfby

See systemuser Entity [lk_campaignresponse_createdonbehalfby](systemuser.md#BKMK_lk_campaignresponse_createdonbehalfby) One-To-Many relationship.

### <a name="BKMK_lk_campaignresponse_modifiedby"></a> lk_campaignresponse_modifiedby

See systemuser Entity [lk_campaignresponse_modifiedby](systemuser.md#BKMK_lk_campaignresponse_modifiedby) One-To-Many relationship.

### <a name="BKMK_team_campaignresponse"></a> team_campaignresponse

See team Entity [team_campaignresponse](team.md#BKMK_team_campaignresponse) One-To-Many relationship.

### <a name="BKMK_campaignresponse_sla_slainvokedid"></a> campaignresponse_sla_slainvokedid

See sla Entity [campaignresponse_sla_slainvokedid](sla.md#BKMK_campaignresponse_sla_slainvokedid) One-To-Many relationship.

### <a name="BKMK_activity_pointer_campaignresponse"></a> activity_pointer_campaignresponse

See activitypointer Entity [activity_pointer_campaignresponse](activitypointer.md#BKMK_activity_pointer_campaignresponse) One-To-Many relationship.

### <a name="BKMK_processstage_campaignresponses"></a> processstage_campaignresponses

See processstage Entity [processstage_campaignresponses](processstage.md#BKMK_processstage_campaignresponses) One-To-Many relationship.

### <a name="BKMK_activity_campaignresponse"></a> activity_campaignresponse

See activitypointer Entity [activity_campaignresponse](activitypointer.md#BKMK_activity_campaignresponse) One-To-Many relationship.

### <a name="BKMK_appointment_campaignresponse"></a> appointment_campaignresponse

See appointment Entity [appointment_campaignresponse](appointment.md#BKMK_appointment_campaignresponse) One-To-Many relationship.

### <a name="BKMK_BulkOperation_CampaignResponse"></a> BulkOperation_CampaignResponse

See bulkoperation Entity [BulkOperation_CampaignResponse](bulkoperation.md#BKMK_BulkOperation_CampaignResponse) One-To-Many relationship.

### <a name="BKMK_email_campaignresponse"></a> email_campaignresponse

See email Entity [email_campaignresponse](email.md#BKMK_email_campaignresponse) One-To-Many relationship.

### <a name="BKMK_fax_campaignresponse"></a> fax_campaignresponse

See fax Entity [fax_campaignresponse](fax.md#BKMK_fax_campaignresponse) One-To-Many relationship.

### <a name="BKMK_letter_campaignresponse"></a> letter_campaignresponse

See letter Entity [letter_campaignresponse](letter.md#BKMK_letter_campaignresponse) One-To-Many relationship.

### <a name="BKMK_phonecall_campaignresponse"></a> phonecall_campaignresponse

See phonecall Entity [phonecall_campaignresponse](phonecall.md#BKMK_phonecall_campaignresponse) One-To-Many relationship.

### <a name="BKMK_recurringappointmentmaster_campaignresponse"></a> recurringappointmentmaster_campaignresponse

See recurringappointmentmaster Entity [recurringappointmentmaster_campaignresponse](recurringappointmentmaster.md#BKMK_recurringappointmentmaster_campaignresponse) One-To-Many relationship.

### <a name="BKMK_CampaignResponse_IncidentResolutions"></a> CampaignResponse_IncidentResolutions

See incidentresolution Entity [CampaignResponse_IncidentResolutions](incidentresolution.md#BKMK_CampaignResponse_IncidentResolutions) One-To-Many relationship.

### <a name="BKMK_CampaignResponse_ServiceAppointments"></a> CampaignResponse_ServiceAppointments

See serviceappointment Entity [CampaignResponse_ServiceAppointments](serviceappointment.md#BKMK_CampaignResponse_ServiceAppointments) One-To-Many relationship.

### <a name="BKMK_CampaignResponse_OpportunityCloses"></a> CampaignResponse_OpportunityCloses

See opportunityclose Entity [CampaignResponse_OpportunityCloses](opportunityclose.md#BKMK_CampaignResponse_OpportunityCloses) One-To-Many relationship.

### <a name="BKMK_CampaignResponse_OrderCloses"></a> CampaignResponse_OrderCloses

See orderclose Entity [CampaignResponse_OrderCloses](orderclose.md#BKMK_CampaignResponse_OrderCloses) One-To-Many relationship.

### <a name="BKMK_CampaignResponse_QuoteCloses"></a> CampaignResponse_QuoteCloses

See quoteclose Entity [CampaignResponse_QuoteCloses](quoteclose.md#BKMK_CampaignResponse_QuoteCloses) One-To-Many relationship.

### <a name="BKMK_CampaignResponse_msdyn_bookingalerts"></a> CampaignResponse_msdyn_bookingalerts

See msdyn_bookingalert Entity [CampaignResponse_msdyn_bookingalerts](msdyn_bookingalert.md#BKMK_CampaignResponse_msdyn_bookingalerts) One-To-Many relationship.

### <a name="BKMK_CampaignResponse_msdyn_approvals"></a> CampaignResponse_msdyn_approvals

See msdyn_approval Entity [CampaignResponse_msdyn_approvals](msdyn_approval.md#BKMK_CampaignResponse_msdyn_approvals) One-To-Many relationship.

## See also

[About the Entity Reference](../about-entity-reference.md)<br />
[Programming reference for Dynamics 365 Customer Engagement](../programming-reference.md)<br />
[Web API Reference](/dynamics365/customer-engagement/web-api/about)<br />
<xref href="Microsoft.Dynamics.CRM.campaignresponse?text=campaignresponse EntityType" />