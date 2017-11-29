---
title: "CampaignActivity Entity Reference (Developer Guide for Dynamics 365 Customer Engagement)| MicrosoftDocs"
description: "Includes schema information and supported messages for the CampaignActivity entity."
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
# CampaignActivity Entity Reference

[!INCLUDE[](../../includes/cc_applies_to_update_9_0_0.md)]

Task performed, or to be performed, by a user for planning or running a campaign.

**Added by**: Marketing Solution<br />

## Messages

|Message|Web API Operation|SDK Assembly|
|-|-|-|
|AddItemCampaign|<xref href="Microsoft.Dynamics.CRM.AddItemCampaign?text=AddItemCampaign Action" />|<xref:Microsoft.Crm.Sdk.Messages.AddItemCampaignRequest>|
|AddItemCampaignActivity|<xref href="Microsoft.Dynamics.CRM.AddItemCampaignActivity?text=AddItemCampaignActivity Action" />|<xref:Microsoft.Crm.Sdk.Messages.AddItemCampaignActivityRequest>|
|Assign|PATCH [*org URI*]/api/data/v9.0/campaignactivities(*activityid*)<br />[Update](../webapi/update-delete-entities-using-web-api.md#basic-update) `ownerid` property.|<xref:Microsoft.Crm.Sdk.Messages.AssignRequest>|
|Create|POST [*org URI*]/api/data/v9.0/campaignactivities<br />See [Create](../webapi/create-entity-web-api.md)|<xref:Microsoft.Xrm.Sdk.Messages.CreateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Create*>|
|Delete|DELETE [*org URI*]/api/data/v9.0/campaignactivities(*activityid*)<br />See [Delete](../webapi/update-delete-entities-using-web-api.md#basic-delete)|<xref:Microsoft.Xrm.Sdk.Messages.DeleteRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Delete*>|
|DistributeCampaignActivity|<xref href="Microsoft.Dynamics.CRM.DistributeCampaignActivity?text=DistributeCampaignActivity Action" />|<xref:Microsoft.Crm.Sdk.Messages.DistributeCampaignActivityRequest>|
|GrantAccess|<xref href="Microsoft.Dynamics.CRM.GrantAccess?text=GrantAccess Action" />|<xref:Microsoft.Crm.Sdk.Messages.GrantAccessRequest>|
|ModifyAccess|<xref href="Microsoft.Dynamics.CRM.ModifyAccess?text=ModifyAccess Action" />|<xref:Microsoft.Crm.Sdk.Messages.ModifyAccessRequest>|
|RemoveItemCampaign|<xref href="Microsoft.Dynamics.CRM.RemoveItemCampaign?text=RemoveItemCampaign Action" />|<xref:Microsoft.Crm.Sdk.Messages.RemoveItemCampaignRequest>|
|RemoveItemCampaignActivity|<xref href="Microsoft.Dynamics.CRM.RemoveItemCampaignActivity?text=RemoveItemCampaignActivity Action" />|<xref:Microsoft.Crm.Sdk.Messages.RemoveItemCampaignActivityRequest>|
|Retrieve|GET [*org URI*]/api/data/v9.0/campaignactivities(*activityid*)<br />See [Retrieve](../webapi/retrieve-entity-using-web-api.md)|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Retrieve*>|
|RetrieveMultiple|GET [*org URI*]/api/data/v9.0/campaignactivities<br />See [Query Data](../webapi/query-data-web-api.md)|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveMultipleRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.RetrieveMultiple*>|
|RetrievePrincipalAccess|<xref href="Microsoft.Dynamics.CRM.RetrievePrincipalAccess?text=RetrievePrincipalAccess Function" />|<xref:Microsoft.Crm.Sdk.Messages.RetrievePrincipalAccessRequest>|
|RetrieveSharedPrincipalsAndAccess|<xref href="Microsoft.Dynamics.CRM.RetrieveSharedPrincipalsAndAccess?text=RetrieveSharedPrincipalsAndAccess Function" />|<xref:Microsoft.Crm.Sdk.Messages.RetrieveSharedPrincipalsAndAccessRequest>|
|RevokeAccess|<xref href="Microsoft.Dynamics.CRM.RevokeAccess?text=RevokeAccess Action" />|<xref:Microsoft.Crm.Sdk.Messages.RevokeAccessRequest>|
|SetState|PATCH [*org URI*]/api/data/v9.0/campaignactivities(*activityid*)<br />[Update](../webapi/update-delete-entities-using-web-api.md#basic-update) `statecode` and `statuscode` properties.|<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|
|Update|PATCH [*org URI*]/api/data/v9.0/campaignactivities(*activityid*)<br />See [Update](../webapi/update-delete-entities-using-web-api.md#basic-update)|<xref:Microsoft.Xrm.Sdk.Messages.UpdateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Update*>|

## Entity Properties

**DisplayName**: Campaign Activity<br />
**DisplayCollectionName**: Campaign Activities<br />
**SchemaName**: CampaignActivity<br />
**CollectionSchemaName**: CampaignActivities<br />
**LogicalName**: campaignactivity<br />
**LogicalCollectionName**: campaignactivities<br />
**EntitySetName**: campaignactivities<br />
**PrimaryIdAttribute**: activityid<br />
**PrimaryNameAttribute**: subject<br />
**OwnershipType**: UserOwned<br />
**IsBPFEntity**: False<br />
<a name="writable-attributes"></a>

## Writable attributes

These attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

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

**Description**: Additional information provided by the external application as JSON. For internal use only.<br />
**DisplayName**: Activity Additional Parameters<br />
**LogicalName**: activityadditionalparams<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Memo<br />
**Format**: TextArea<br />
**IsLocalizable**: False<br />
**MaxLength**: 8192


### <a name="BKMK_ActivityId"></a> ActivityId

**Description**: Unique identifier of the campaign activity.<br />
**DisplayName**: Campaign Activity<br />
**LogicalName**: activityid<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: SystemRequired<br />
**IsValidForUpdate**: False<br />
**Type**: Uniqueidentifier<br />


### <a name="BKMK_ActualCost"></a> ActualCost

**Description**: Type the actual cost of the campaign activity. The value entered is rolled up to the related campaign in the total cost calculations.<br />
**DisplayName**: Actual Cost<br />
**LogicalName**: actualcost<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Money<br />
**MaxValue**: 1000000000000<br />
**MinValue**: 0<br />
**Precision**: 2<br />
**PrecisionSource**: 2


### <a name="BKMK_ActualDurationMinutes"></a> ActualDurationMinutes

**Description**: Shows the value selected in the Duration field on the campaign activity. The duration is used to report the time spent on the activity.<br />
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

**Description**: Enter the date when the campaign activity was actually  completed.<br />
**DisplayName**: Actual End<br />
**LogicalName**: actualend<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: DateTime<br />
**DateTimeBehavior**: UserLocal<br />
**Format**: DateOnly


### <a name="BKMK_ActualStart"></a> ActualStart

**Description**: Enter the actual start date and time for the campaign activity to determine if the campaign activity started on the scheduled time.<br />
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


### <a name="BKMK_BudgetedCost"></a> BudgetedCost

**Description**: Type the allocated budget of the campaign activity for estimated versus actual cost reporting.<br />
**DisplayName**: Budget Allocated<br />
**LogicalName**: budgetedcost<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Money<br />
**MaxValue**: 1000000000000<br />
**MinValue**: 0<br />
**Precision**: 2<br />
**PrecisionSource**: 2


### <a name="BKMK_Category"></a> Category

**Description**: Type a category to identify the campaign activity type, such as new business development or customer retention, to tie the campaign activity to a business group or function.<br />
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

**Description**: Select how communications for this activity will be sent, such as phone, letter, fax, or email.<br />
**DisplayName**: Channel<br />
**LogicalName**: channeltypecode<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Picklist<br />
**Options**:

- **Value**: 1 **Label**: Phone
- **Value**: 2 **Label**: Appointment
- **Value**: 3 **Label**: Letter
- **Value**: 4 **Label**: Letter via Mail Merge
- **Value**: 5 **Label**: Fax
- **Value**: 6 **Label**: Fax via Mail Merge
- **Value**: 7 **Label**: Email
- **Value**: 8 **Label**: Email via Mail Merge
- **Value**: 9 **Label**: Other



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

**Description**: Type additional information to describe the campaign activity, such as key talking points, objectives, or details about the target audience.<br />
**DisplayName**: Description<br />
**LogicalName**: description<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Memo<br />
**Format**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 2000


### <a name="BKMK_DoNotSendOnOptOut"></a> DoNotSendOnOptOut

**Description**: Select whether to override the opt-out settings on leads, contacts, and accounts for the members of the target marketing lists of the campaign activity. If No is selected, marketing materials will be sent to members who have opted out.<br />
**DisplayName**: Exclude Members Who Opt Out<br />
**LogicalName**: donotsendonoptout<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Boolean<br />
**Options**:

- **TrueOption Value**: 1 **Label**: Yes
- **FalseOption Value**: 0 **Label**: No

**DefaultValue**: True


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


### <a name="BKMK_ExcludeIfContactedInXDays"></a> ExcludeIfContactedInXDays

**Description**: Type the minimum number of days that must be passed before a marketing list member can be contacted in a campaign again. The campaign activity will not be applied to members contacted within the specified time period.<br />
**DisplayName**: No. of Days<br />
**LogicalName**: excludeifcontactedinxdays<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Integer<br />
**Format**: None<br />
**MaxValue**: 9999<br />
**MinValue**: 0


### <a name="BKMK_from"></a> from

**Description**: For system use only.<br />
**DisplayName**: From<br />
**LogicalName**: from<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: PartyList<br />
**Targets**: account,contact,queue,systemuser


### <a name="BKMK_IgnoreInactiveListMembers"></a> IgnoreInactiveListMembers

**Description**: Select whether inactive marketing list members will be excluded from the campaign activity distribution.<br />
**DisplayName**: Ignore Inactive Marketing List Members<br />
**LogicalName**: ignoreinactivelistmembers<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Boolean<br />
**Options**:

- **TrueOption Value**: 1 **Label**: Yes
- **FalseOption Value**: 0 **Label**: No

**DefaultValue**: True


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

**Description**: Information regarding whether the campaign activity was billed as part of resolving a case.<br />
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

**Description**: Information about whether the campaign activity is created by a workflow rule.<br />
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


### <a name="BKMK_RegardingObjectId"></a> RegardingObjectId

**Description**: Choose the parent campaign so that the campaign activity costs reflect in the correct campaign for reporting.<br />
**DisplayName**: Parent Campaign<br />
**LogicalName**: regardingobjectid<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: ApplicationRequired<br />
**IsValidForUpdate**: False<br />
**Type**: Lookup<br />
**Targets**: campaign


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


### <a name="BKMK_ScheduledEnd"></a> ScheduledEnd

**Description**: Enter the expected due date and time for the activity to be completed to provide details about the timing of the campaign activity.<br />
**DisplayName**: Scheduled End<br />
**LogicalName**: scheduledend<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: DateTime<br />
**DateTimeBehavior**: UserLocal<br />
**Format**: DateOnly


### <a name="BKMK_ScheduledStart"></a> ScheduledStart

**Description**: Enter the expected start date and time for the activity to provide details about timing of the campaign activity.<br />
**DisplayName**: Scheduled Start<br />
**LogicalName**: scheduledstart<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: DateTime<br />
**DateTimeBehavior**: UserLocal<br />
**Format**: DateOnly


### <a name="BKMK_ServiceId"></a> ServiceId

**Description**: Unique identifier of the associated service.<br />
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

**Description**: Shows whether the campaign activity is open, completed, or canceled. Completed and canceled campaign activities are read-only and can't be edited.<br />
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

**Description**: Select the campaign activity's status.<br />
**DisplayName**: Status Reason<br />
**LogicalName**: statuscode<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Status<br />
**Options**:

- **Value**: 0 **Label**: In Progress **State**: 0
- **Value**: 1 **Label**: Proposed **State**: 0
- **Value**: 2 **Label**: Closed **State**: 1
- **Value**: 3 **Label**: Canceled **State**: 2
- **Value**: 4 **Label**: Pending **State**: 0
- **Value**: 5 **Label**: System Aborted **State**: 0
- **Value**: 6 **Label**: Completed **State**: 0



### <a name="BKMK_Subcategory"></a> Subcategory

**Description**: Type a subcategory to identify the campaign activity type and relate the activity to a specific product, sales region, business group, or other function.<br />
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

**Description**: Type a short description about the objective or primary topic of the campaign activity.<br />
**DisplayName**: Subject<br />
**LogicalName**: subject<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: ApplicationRequired<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 200


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


### <a name="BKMK_TypeCode"></a> TypeCode

**Description**: Select the type of campaign activity to indicate the purpose of the activity.<br />
**DisplayName**: Type<br />
**LogicalName**: typecode<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Picklist<br />
**Options**:

- **Value**: 1 **Label**: Research
- **Value**: 2 **Label**: Content Preparation
- **Value**: 3 **Label**: Target Marketing List Creation
- **Value**: 4 **Label**: Lead Qualification
- **Value**: 5 **Label**: Content Distribution
- **Value**: 6 **Label**: Direct Initial Contact
- **Value**: 7 **Label**: Direct Follow-Up Contact
- **Value**: 8 **Label**: Reminder Distribution



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

<a name="read-only-attributes"></a>
## Read-only attributes
These attributes return false for both **IsValidForCreate** or **IsValidForUpdate**. Listed by **SchemaName**.

- [ActivityTypeCode](#BKMK_ActivityTypeCode)
- [ActualCost_Base](#BKMK_ActualCost_Base)
- [BudgetedCost_Base](#BKMK_BudgetedCost_Base)
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
- [TransactionCurrencyId](#BKMK_TransactionCurrencyId)
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


### <a name="BKMK_ActualCost_Base"></a> ActualCost_Base

**Description**: Value of the Actual Cost in base currency.<br />
**DisplayName**: Actual Cost (Base)<br />
**LogicalName**: actualcost_base<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Money<br />
**MaxValue**: 922337203685477<br />
**MinValue**: -922337203685477<br />
**Precision**: 4<br />
**PrecisionSource**: 2


### <a name="BKMK_BudgetedCost_Base"></a> BudgetedCost_Base

**Description**: Value of the Budget Allocated in base currency.<br />
**DisplayName**: Budget Allocated (Base)<br />
**LogicalName**: budgetedcost_base<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Money<br />
**MaxValue**: 922337203685477<br />
**MinValue**: -922337203685477<br />
**Precision**: 4<br />
**PrecisionSource**: 2


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

**Description**: Name of the user who created the campaign activity.<br />
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

**Description**: Name of the user who last modified the campaign activity.<br />
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

**Description**: Scheduled duration, specified in minutes, of the campaign activity.<br />
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


### <a name="BKMK_TransactionCurrencyId"></a> TransactionCurrencyId

**Description**: Choose the local currency for the record to make sure budgets are reported in the correct currency.<br />
**DisplayName**: Currency<br />
**LogicalName**: transactioncurrencyid<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: transactioncurrency


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

- [campaignactivity_activity_parties](#BKMK_campaignactivity_activity_parties)
- [CampaignActivity_ActivityPointers](#BKMK_CampaignActivity_ActivityPointers)
- [CampaignActivity_SyncErrors](#BKMK_CampaignActivity_SyncErrors)
- [campaignactivity_activityparties](#BKMK_campaignactivity_activityparties)
- [CampaignActivity_AsyncOperations](#BKMK_CampaignActivity_AsyncOperations)
- [CampaignActivity_MailboxTrackingFolder](#BKMK_CampaignActivity_MailboxTrackingFolder)
- [userentityinstancedata_campaignactivity](#BKMK_userentityinstancedata_campaignactivity)
- [CampaignActivity_ProcessSessions](#BKMK_CampaignActivity_ProcessSessions)
- [CampaignActivity_BulkDeleteFailures](#BKMK_CampaignActivity_BulkDeleteFailures)
- [campaignactivity_principalobjectattributeaccess](#BKMK_campaignactivity_principalobjectattributeaccess)
- [CampaignActivity_Appointments](#BKMK_CampaignActivity_Appointments)
- [CampaignActivity_Emails](#BKMK_CampaignActivity_Emails)
- [CampaignActivity_Faxes](#BKMK_CampaignActivity_Faxes)
- [CampaignActivity_Letters](#BKMK_CampaignActivity_Letters)
- [CampaignActivity_Phonecalls](#BKMK_CampaignActivity_Phonecalls)
- [CampaignActivity_Tasks](#BKMK_CampaignActivity_Tasks)
- [CampaignActivity_RecurringAppointmentMasters](#BKMK_CampaignActivity_RecurringAppointmentMasters)
- [campaignactivity_SocialActivities](#BKMK_campaignactivity_SocialActivities)
- [campaignactivity_connections1](#BKMK_campaignactivity_connections1)
- [campaignactivity_connections2](#BKMK_campaignactivity_connections2)
- [CampaignActivity_QueueItem](#BKMK_CampaignActivity_QueueItem)
- [CampaignActivity_Annotation](#BKMK_CampaignActivity_Annotation)
- [campaignactivity_CampaignResponses](#BKMK_campaignactivity_CampaignResponses)
- [CampaignActivity_BulkOperations](#BKMK_CampaignActivity_BulkOperations)
- [campaignactivity_IncidentResolutions](#BKMK_campaignactivity_IncidentResolutions)
- [campaignactivity_ServiceAppointments](#BKMK_campaignactivity_ServiceAppointments)
- [campaignactivity_OpportunityCloses](#BKMK_campaignactivity_OpportunityCloses)
- [campaignactivity_OrderCloses](#BKMK_campaignactivity_OrderCloses)
- [campaignactivity_QuoteCloses](#BKMK_campaignactivity_QuoteCloses)
- [campaignactivity_msdyn_bookingalerts](#BKMK_campaignactivity_msdyn_bookingalerts)
- [campaignactivity_msdyn_approvals](#BKMK_campaignactivity_msdyn_approvals)


### <a name="BKMK_campaignactivity_activity_parties"></a> campaignactivity_activity_parties

Same as activityparty entity [campaignactivity_activity_parties](activityparty.md#BKMK_campaignactivity_activity_parties) Many-To-One relationship.

**ReferencingEntity**: activityparty<br />
**ReferencingAttribute**: activityid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: False<br />
**ReferencedEntityNavigationPropertyName**: campaignactivity_activity_parties<br />
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


### <a name="BKMK_CampaignActivity_ActivityPointers"></a> CampaignActivity_ActivityPointers

Same as activitypointer entity [CampaignActivity_ActivityPointers](activitypointer.md#BKMK_CampaignActivity_ActivityPointers) Many-To-One relationship.

**ReferencingEntity**: activitypointer<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: False<br />
**ReferencedEntityNavigationPropertyName**: CampaignActivity_ActivityPointers<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: RemoveLink
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_CampaignActivity_SyncErrors"></a> CampaignActivity_SyncErrors

Same as syncerror entity [CampaignActivity_SyncErrors](syncerror.md#BKMK_CampaignActivity_SyncErrors) Many-To-One relationship.

**ReferencingEntity**: syncerror<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: CampaignActivity_SyncErrors<br />
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


### <a name="BKMK_campaignactivity_activityparties"></a> campaignactivity_activityparties

Same as activityparty entity [campaignactivity_activityparties](activityparty.md#BKMK_campaignactivity_activityparties) Many-To-One relationship.

**ReferencingEntity**: activityparty<br />
**ReferencingAttribute**: partyid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: False<br />
**ReferencedEntityNavigationPropertyName**: campaignactivity_activityparties<br />
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


### <a name="BKMK_CampaignActivity_AsyncOperations"></a> CampaignActivity_AsyncOperations

Same as asyncoperation entity [CampaignActivity_AsyncOperations](asyncoperation.md#BKMK_CampaignActivity_AsyncOperations) Many-To-One relationship.

**ReferencingEntity**: asyncoperation<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: False<br />
**ReferencedEntityNavigationPropertyName**: CampaignActivity_AsyncOperations<br />
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


### <a name="BKMK_CampaignActivity_MailboxTrackingFolder"></a> CampaignActivity_MailboxTrackingFolder

Same as mailboxtrackingfolder entity [CampaignActivity_MailboxTrackingFolder](mailboxtrackingfolder.md#BKMK_CampaignActivity_MailboxTrackingFolder) Many-To-One relationship.

**ReferencingEntity**: mailboxtrackingfolder<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: CampaignActivity_MailboxTrackingFolder<br />
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


### <a name="BKMK_userentityinstancedata_campaignactivity"></a> userentityinstancedata_campaignactivity

Same as userentityinstancedata entity [userentityinstancedata_campaignactivity](userentityinstancedata.md#BKMK_userentityinstancedata_campaignactivity) Many-To-One relationship.

**ReferencingEntity**: userentityinstancedata<br />
**ReferencingAttribute**: objectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: False<br />
**ReferencedEntityNavigationPropertyName**: userentityinstancedata_campaignactivity<br />
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


### <a name="BKMK_CampaignActivity_ProcessSessions"></a> CampaignActivity_ProcessSessions

Same as processsession entity [CampaignActivity_ProcessSessions](processsession.md#BKMK_CampaignActivity_ProcessSessions) Many-To-One relationship.

**ReferencingEntity**: processsession<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: False<br />
**ReferencedEntityNavigationPropertyName**: CampaignActivity_ProcessSessions<br />
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


### <a name="BKMK_CampaignActivity_BulkDeleteFailures"></a> CampaignActivity_BulkDeleteFailures

Same as bulkdeletefailure entity [CampaignActivity_BulkDeleteFailures](bulkdeletefailure.md#BKMK_CampaignActivity_BulkDeleteFailures) Many-To-One relationship.

**ReferencingEntity**: bulkdeletefailure<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: False<br />
**ReferencedEntityNavigationPropertyName**: CampaignActivity_BulkDeleteFailures<br />
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


### <a name="BKMK_campaignactivity_principalobjectattributeaccess"></a> campaignactivity_principalobjectattributeaccess

Same as principalobjectattributeaccess entity [campaignactivity_principalobjectattributeaccess](principalobjectattributeaccess.md#BKMK_campaignactivity_principalobjectattributeaccess) Many-To-One relationship.

**ReferencingEntity**: principalobjectattributeaccess<br />
**ReferencingAttribute**: objectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: False<br />
**ReferencedEntityNavigationPropertyName**: campaignactivity_principalobjectattributeaccess<br />
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


### <a name="BKMK_CampaignActivity_Appointments"></a> CampaignActivity_Appointments

Same as appointment entity [CampaignActivity_Appointments](appointment.md#BKMK_CampaignActivity_Appointments) Many-To-One relationship.

**ReferencingEntity**: appointment<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: CampaignActivity_Appointments<br />
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


### <a name="BKMK_CampaignActivity_Emails"></a> CampaignActivity_Emails

Same as email entity [CampaignActivity_Emails](email.md#BKMK_CampaignActivity_Emails) Many-To-One relationship.

**ReferencingEntity**: email<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: CampaignActivity_Emails<br />
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


### <a name="BKMK_CampaignActivity_Faxes"></a> CampaignActivity_Faxes

Same as fax entity [CampaignActivity_Faxes](fax.md#BKMK_CampaignActivity_Faxes) Many-To-One relationship.

**ReferencingEntity**: fax<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: CampaignActivity_Faxes<br />
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


### <a name="BKMK_CampaignActivity_Letters"></a> CampaignActivity_Letters

Same as letter entity [CampaignActivity_Letters](letter.md#BKMK_CampaignActivity_Letters) Many-To-One relationship.

**ReferencingEntity**: letter<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: CampaignActivity_Letters<br />
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


### <a name="BKMK_CampaignActivity_Phonecalls"></a> CampaignActivity_Phonecalls

Same as phonecall entity [CampaignActivity_Phonecalls](phonecall.md#BKMK_CampaignActivity_Phonecalls) Many-To-One relationship.

**ReferencingEntity**: phonecall<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: CampaignActivity_Phonecalls<br />
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


### <a name="BKMK_CampaignActivity_Tasks"></a> CampaignActivity_Tasks

Same as task entity [CampaignActivity_Tasks](task.md#BKMK_CampaignActivity_Tasks) Many-To-One relationship.

**ReferencingEntity**: task<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: CampaignActivity_Tasks<br />
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


### <a name="BKMK_CampaignActivity_RecurringAppointmentMasters"></a> CampaignActivity_RecurringAppointmentMasters

Same as recurringappointmentmaster entity [CampaignActivity_RecurringAppointmentMasters](recurringappointmentmaster.md#BKMK_CampaignActivity_RecurringAppointmentMasters) Many-To-One relationship.

**ReferencingEntity**: recurringappointmentmaster<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: CampaignActivity_RecurringAppointmentMasters<br />
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


### <a name="BKMK_campaignactivity_SocialActivities"></a> campaignactivity_SocialActivities

Same as socialactivity entity [campaignactivity_SocialActivities](socialactivity.md#BKMK_campaignactivity_SocialActivities) Many-To-One relationship.

**ReferencingEntity**: socialactivity<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: campaignactivity_SocialActivities<br />
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


### <a name="BKMK_campaignactivity_connections1"></a> campaignactivity_connections1

Same as connection entity [campaignactivity_connections1](connection.md#BKMK_campaignactivity_connections1) Many-To-One relationship.

**ReferencingEntity**: connection<br />
**ReferencingAttribute**: record1id<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: campaignactivity_connections1<br />
**AssociatedMenuConfiguration**:

- **Behavior**: UseCollectionName
- **Group**: Details
- **Label**: 
- **Order**: 100

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: Cascade
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_campaignactivity_connections2"></a> campaignactivity_connections2

Same as connection entity [campaignactivity_connections2](connection.md#BKMK_campaignactivity_connections2) Many-To-One relationship.

**ReferencingEntity**: connection<br />
**ReferencingAttribute**: record2id<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: campaignactivity_connections2<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 100

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: Cascade
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_CampaignActivity_QueueItem"></a> CampaignActivity_QueueItem

Same as queueitem entity [CampaignActivity_QueueItem](queueitem.md#BKMK_CampaignActivity_QueueItem) Many-To-One relationship.

**ReferencingEntity**: queueitem<br />
**ReferencingAttribute**: objectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: CampaignActivity_QueueItem<br />
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


### <a name="BKMK_CampaignActivity_Annotation"></a> CampaignActivity_Annotation

Same as annotation entity [CampaignActivity_Annotation](annotation.md#BKMK_CampaignActivity_Annotation) Many-To-One relationship.

**ReferencingEntity**: annotation<br />
**ReferencingAttribute**: objectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: CampaignActivity_Annotation<br />
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


### <a name="BKMK_campaignactivity_CampaignResponses"></a> campaignactivity_CampaignResponses

Same as campaignresponse entity [campaignactivity_CampaignResponses](campaignresponse.md#BKMK_campaignactivity_CampaignResponses) Many-To-One relationship.

**ReferencingEntity**: campaignresponse<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: campaignactivity_CampaignResponses<br />
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


### <a name="BKMK_CampaignActivity_BulkOperations"></a> CampaignActivity_BulkOperations

Same as bulkoperation entity [CampaignActivity_BulkOperations](bulkoperation.md#BKMK_CampaignActivity_BulkOperations) Many-To-One relationship.

**ReferencingEntity**: bulkoperation<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: False<br />
**ReferencedEntityNavigationPropertyName**: CampaignActivity_BulkOperations<br />
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


### <a name="BKMK_campaignactivity_IncidentResolutions"></a> campaignactivity_IncidentResolutions

Same as incidentresolution entity [campaignactivity_IncidentResolutions](incidentresolution.md#BKMK_campaignactivity_IncidentResolutions) Many-To-One relationship.

**ReferencingEntity**: incidentresolution<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: campaignactivity_IncidentResolutions<br />
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


### <a name="BKMK_campaignactivity_ServiceAppointments"></a> campaignactivity_ServiceAppointments

Same as serviceappointment entity [campaignactivity_ServiceAppointments](serviceappointment.md#BKMK_campaignactivity_ServiceAppointments) Many-To-One relationship.

**ReferencingEntity**: serviceappointment<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: campaignactivity_ServiceAppointments<br />
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


### <a name="BKMK_campaignactivity_OpportunityCloses"></a> campaignactivity_OpportunityCloses

Same as opportunityclose entity [campaignactivity_OpportunityCloses](opportunityclose.md#BKMK_campaignactivity_OpportunityCloses) Many-To-One relationship.

**ReferencingEntity**: opportunityclose<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: campaignactivity_OpportunityCloses<br />
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


### <a name="BKMK_campaignactivity_OrderCloses"></a> campaignactivity_OrderCloses

Same as orderclose entity [campaignactivity_OrderCloses](orderclose.md#BKMK_campaignactivity_OrderCloses) Many-To-One relationship.

**ReferencingEntity**: orderclose<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: campaignactivity_OrderCloses<br />
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


### <a name="BKMK_campaignactivity_QuoteCloses"></a> campaignactivity_QuoteCloses

Same as quoteclose entity [campaignactivity_QuoteCloses](quoteclose.md#BKMK_campaignactivity_QuoteCloses) Many-To-One relationship.

**ReferencingEntity**: quoteclose<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: campaignactivity_QuoteCloses<br />
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


### <a name="BKMK_campaignactivity_msdyn_bookingalerts"></a> campaignactivity_msdyn_bookingalerts

Same as msdyn_bookingalert entity [campaignactivity_msdyn_bookingalerts](msdyn_bookingalert.md#BKMK_campaignactivity_msdyn_bookingalerts) Many-To-One relationship.

**ReferencingEntity**: msdyn_bookingalert<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: campaignactivity_msdyn_bookingalerts<br />
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


### <a name="BKMK_campaignactivity_msdyn_approvals"></a> campaignactivity_msdyn_approvals

Same as msdyn_approval entity [campaignactivity_msdyn_approvals](msdyn_approval.md#BKMK_campaignactivity_msdyn_approvals) Many-To-One relationship.

**ReferencingEntity**: msdyn_approval<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: campaignactivity_msdyn_approvals<br />
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

<a name="manytoone"></a>

## Many-To-One Relationships

Each Many-To-One relationship is defined by a corresponding One-To-Many relationship with the related entity. Listed by **SchemaName**.

- [lead_CampaignActivities](#BKMK_lead_CampaignActivities)
- [bookableresourcebooking_CampaignActivities](#BKMK_bookableresourcebooking_CampaignActivities)
- [bookableresourcebookingheader_CampaignActivities](#BKMK_bookableresourcebookingheader_CampaignActivities)
- [bulkoperation_CampaignActivities](#BKMK_bulkoperation_CampaignActivities)
- [Campaign_CampaignActivities](#BKMK_Campaign_CampaignActivities)
- [interactionforemail_CampaignActivities](#BKMK_interactionforemail_CampaignActivities)
- [knowledgebaserecord_CampaignActivities](#BKMK_knowledgebaserecord_CampaignActivities)
- [account_CampaignActivities](#BKMK_account_CampaignActivities)
- [lk_campaignactivity_createdby](#BKMK_lk_campaignactivity_createdby)
- [campaignactivity_mailbox_sendermailboxid](#BKMK_campaignactivity_mailbox_sendermailboxid)
- [transactioncurrency_campaignactivity](#BKMK_transactioncurrency_campaignactivity)
- [user_campaignactivity](#BKMK_user_campaignactivity)
- [campaignactivity_sla_slaid](#BKMK_campaignactivity_sla_slaid)
- [business_unit_campaignactivity_activities](#BKMK_business_unit_campaignactivity_activities)
- [knowledgearticle_CampaignActivities](#BKMK_knowledgearticle_CampaignActivities)
- [lk_campaignactivity_modifiedonbehalfby](#BKMK_lk_campaignactivity_modifiedonbehalfby)
- [lk_campaignactivity_createdonbehalfby](#BKMK_lk_campaignactivity_createdonbehalfby)
- [lk_campaignactivity_modifiedby](#BKMK_lk_campaignactivity_modifiedby)
- [team_campaignactivity](#BKMK_team_campaignactivity)
- [campaignactivity_sla_slainvokedid](#BKMK_campaignactivity_sla_slainvokedid)
- [activity_pointer_campaignactivity](#BKMK_activity_pointer_campaignactivity)
- [processstage_campaignactivities](#BKMK_processstage_campaignactivities)


### <a name="BKMK_lead_CampaignActivities"></a> lead_CampaignActivities

See lead Entity [lead_CampaignActivities](lead.md#BKMK_lead_CampaignActivities) One-To-Many relationship.

### <a name="BKMK_bookableresourcebooking_CampaignActivities"></a> bookableresourcebooking_CampaignActivities

See bookableresourcebooking Entity [bookableresourcebooking_CampaignActivities](bookableresourcebooking.md#BKMK_bookableresourcebooking_CampaignActivities) One-To-Many relationship.

### <a name="BKMK_bookableresourcebookingheader_CampaignActivities"></a> bookableresourcebookingheader_CampaignActivities

See bookableresourcebookingheader Entity [bookableresourcebookingheader_CampaignActivities](bookableresourcebookingheader.md#BKMK_bookableresourcebookingheader_CampaignActivities) One-To-Many relationship.

### <a name="BKMK_bulkoperation_CampaignActivities"></a> bulkoperation_CampaignActivities

See bulkoperation Entity [bulkoperation_CampaignActivities](bulkoperation.md#BKMK_bulkoperation_CampaignActivities) One-To-Many relationship.

### <a name="BKMK_Campaign_CampaignActivities"></a> Campaign_CampaignActivities

See campaign Entity [Campaign_CampaignActivities](campaign.md#BKMK_Campaign_CampaignActivities) One-To-Many relationship.

### <a name="BKMK_interactionforemail_CampaignActivities"></a> interactionforemail_CampaignActivities

See interactionforemail Entity [interactionforemail_CampaignActivities](interactionforemail.md#BKMK_interactionforemail_CampaignActivities) One-To-Many relationship.

### <a name="BKMK_knowledgebaserecord_CampaignActivities"></a> knowledgebaserecord_CampaignActivities

See knowledgebaserecord Entity [knowledgebaserecord_CampaignActivities](knowledgebaserecord.md#BKMK_knowledgebaserecord_CampaignActivities) One-To-Many relationship.

### <a name="BKMK_account_CampaignActivities"></a> account_CampaignActivities

See account Entity [account_CampaignActivities](account.md#BKMK_account_CampaignActivities) One-To-Many relationship.

### <a name="BKMK_lk_campaignactivity_createdby"></a> lk_campaignactivity_createdby

See systemuser Entity [lk_campaignactivity_createdby](systemuser.md#BKMK_lk_campaignactivity_createdby) One-To-Many relationship.

### <a name="BKMK_campaignactivity_mailbox_sendermailboxid"></a> campaignactivity_mailbox_sendermailboxid

See mailbox Entity [campaignactivity_mailbox_sendermailboxid](mailbox.md#BKMK_campaignactivity_mailbox_sendermailboxid) One-To-Many relationship.

### <a name="BKMK_transactioncurrency_campaignactivity"></a> transactioncurrency_campaignactivity

See transactioncurrency Entity [transactioncurrency_campaignactivity](transactioncurrency.md#BKMK_transactioncurrency_campaignactivity) One-To-Many relationship.

### <a name="BKMK_user_campaignactivity"></a> user_campaignactivity

See systemuser Entity [user_campaignactivity](systemuser.md#BKMK_user_campaignactivity) One-To-Many relationship.

### <a name="BKMK_campaignactivity_sla_slaid"></a> campaignactivity_sla_slaid

See sla Entity [campaignactivity_sla_slaid](sla.md#BKMK_campaignactivity_sla_slaid) One-To-Many relationship.

### <a name="BKMK_business_unit_campaignactivity_activities"></a> business_unit_campaignactivity_activities

See businessunit Entity [business_unit_campaignactivity_activities](businessunit.md#BKMK_business_unit_campaignactivity_activities) One-To-Many relationship.

### <a name="BKMK_knowledgearticle_CampaignActivities"></a> knowledgearticle_CampaignActivities

See knowledgearticle Entity [knowledgearticle_CampaignActivities](knowledgearticle.md#BKMK_knowledgearticle_CampaignActivities) One-To-Many relationship.

### <a name="BKMK_lk_campaignactivity_modifiedonbehalfby"></a> lk_campaignactivity_modifiedonbehalfby

See systemuser Entity [lk_campaignactivity_modifiedonbehalfby](systemuser.md#BKMK_lk_campaignactivity_modifiedonbehalfby) One-To-Many relationship.

### <a name="BKMK_lk_campaignactivity_createdonbehalfby"></a> lk_campaignactivity_createdonbehalfby

See systemuser Entity [lk_campaignactivity_createdonbehalfby](systemuser.md#BKMK_lk_campaignactivity_createdonbehalfby) One-To-Many relationship.

### <a name="BKMK_lk_campaignactivity_modifiedby"></a> lk_campaignactivity_modifiedby

See systemuser Entity [lk_campaignactivity_modifiedby](systemuser.md#BKMK_lk_campaignactivity_modifiedby) One-To-Many relationship.

### <a name="BKMK_team_campaignactivity"></a> team_campaignactivity

See team Entity [team_campaignactivity](team.md#BKMK_team_campaignactivity) One-To-Many relationship.

### <a name="BKMK_campaignactivity_sla_slainvokedid"></a> campaignactivity_sla_slainvokedid

See sla Entity [campaignactivity_sla_slainvokedid](sla.md#BKMK_campaignactivity_sla_slainvokedid) One-To-Many relationship.

### <a name="BKMK_activity_pointer_campaignactivity"></a> activity_pointer_campaignactivity

See activitypointer Entity [activity_pointer_campaignactivity](activitypointer.md#BKMK_activity_pointer_campaignactivity) One-To-Many relationship.

### <a name="BKMK_processstage_campaignactivities"></a> processstage_campaignactivities

See processstage Entity [processstage_campaignactivities](processstage.md#BKMK_processstage_campaignactivities) One-To-Many relationship.
<a name="manytomany"></a>

## Many-To-Many Relationships

Relationship details provided where the CampaignActivity entity is the first entity in the relationship. Listed by **SchemaName**.

- [campaignactivitylist_association](#BKMK_campaignactivitylist_association)
- [campaignactivitysalesliterature_association](#BKMK_campaignactivitysalesliterature_association)


### <a name="BKMK_campaignactivitylist_association"></a> campaignactivitylist_association

**IntersectEntityName**: campaignactivityitem<br />
**Entity1LogicalName**: campaignactivity<br />

- **Entity1IntersectAttribute**: campaignactivityid
- **Entity1NavigationPropertyName**: campaignactivitylist_association
- **Entity1AssociatedMenuConfiguration**:

  - **Behavior**: DoNotDisplay
  - **Group**: Details
  - **Label**: 
  - **Order**: 

**Entity2LogicalName**: [list](list.md)<br />

- **Entity2IntersectAttribute**: itemid
- **Entity2NavigationPropertyName**: campaignactivitylist_association
- **Entity2AssociatedMenuConfiguration**:

  - **Behavior**: DoNotDisplay
  - **Group**: Details
  - **Label**: 
  - **Order**: 

**IsCustomizable**: False<br />

### <a name="BKMK_campaignactivitysalesliterature_association"></a> campaignactivitysalesliterature_association

**IntersectEntityName**: campaignactivityitem<br />
**Entity1LogicalName**: campaignactivity<br />

- **Entity1IntersectAttribute**: campaignactivityid
- **Entity1NavigationPropertyName**: campaignactivitysalesliterature_association
- **Entity1AssociatedMenuConfiguration**:

  - **Behavior**: DoNotDisplay
  - **Group**: Details
  - **Label**: 
  - **Order**: 

**Entity2LogicalName**: [salesliterature](salesliterature.md)<br />

- **Entity2IntersectAttribute**: itemid
- **Entity2NavigationPropertyName**: campaignactivitysalesliterature_association
- **Entity2AssociatedMenuConfiguration**:

  - **Behavior**: DoNotDisplay
  - **Group**: Details
  - **Label**: 
  - **Order**: 

**IsCustomizable**: False<br />

## See also

[About the Entity Reference](../about-entity-reference.md)<br />
[Programming reference for Dynamics 365 Customer Engagement](../programming-reference.md)<br />
[Web API Reference](/dynamics365/customer-engagement/web-api/about)<br />
<xref href="Microsoft.Dynamics.CRM.campaignactivity?text=campaignactivity EntityType" />