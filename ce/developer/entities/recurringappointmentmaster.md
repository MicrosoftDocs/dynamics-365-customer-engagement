---
title: "RecurringAppointmentMaster Entity Reference (Developer Guide for Dynamics 365 Customer Engagement)| MicrosoftDocs"
description: "Includes schema information and supported messages for the RecurringAppointmentMaster entity."
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
# RecurringAppointmentMaster Entity Reference

The Master appointment of a recurring appointment series.


## Messages

|Message|Web API Operation|SDK Assembly|
|-|-|-|
|AddRecurrence|<xref href="Microsoft.Dynamics.CRM.AddRecurrence?text=AddRecurrence Action" />|<xref:Microsoft.Crm.Sdk.Messages.AddRecurrenceRequest>|
|Assign|PATCH [*org URI*]/api/data/v9.0/recurringappointmentmasters(*activityid*)<br />[Update](../webapi/update-delete-entities-using-web-api.md#basic-update) `ownerid` property.|<xref:Microsoft.Crm.Sdk.Messages.AssignRequest>|
|Book|<xref href="Microsoft.Dynamics.CRM.Book?text=Book Action" />|<xref:Microsoft.Crm.Sdk.Messages.BookRequest>|
|Create|POST [*org URI*]/api/data/v9.0/recurringappointmentmasters<br />See [Create](../webapi/create-entity-web-api.md)|<xref:Microsoft.Xrm.Sdk.Messages.CreateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Create*>|
|CreateInstance|<xref href="Microsoft.Dynamics.CRM.CreateInstance?text=CreateInstance Action" />|<xref:Microsoft.Crm.Sdk.Messages.CreateInstanceRequest>|
|Delete|DELETE [*org URI*]/api/data/v9.0/recurringappointmentmasters(*activityid*)<br />See [Delete](../webapi/update-delete-entities-using-web-api.md#basic-delete)|<xref:Microsoft.Xrm.Sdk.Messages.DeleteRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Delete*>|
|DeleteOpenInstances|<xref href="Microsoft.Dynamics.CRM.DeleteOpenInstances?text=DeleteOpenInstances Action" />|<xref:Microsoft.Crm.Sdk.Messages.DeleteOpenInstancesRequest>|
|GrantAccess|<xref href="Microsoft.Dynamics.CRM.GrantAccess?text=GrantAccess Action" />|<xref:Microsoft.Crm.Sdk.Messages.GrantAccessRequest>|
|ModifyAccess|<xref href="Microsoft.Dynamics.CRM.ModifyAccess?text=ModifyAccess Action" />|<xref:Microsoft.Crm.Sdk.Messages.ModifyAccessRequest>|
|Reschedule|<xref href="Microsoft.Dynamics.CRM.Reschedule?text=Reschedule Action" />|<xref:Microsoft.Crm.Sdk.Messages.RescheduleRequest>|
|Retrieve|GET [*org URI*]/api/data/v9.0/recurringappointmentmasters(*activityid*)<br />See [Retrieve](../webapi/retrieve-entity-using-web-api.md)|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Retrieve*>|
|RetrieveMultiple|GET [*org URI*]/api/data/v9.0/recurringappointmentmasters<br />See [Query Data](../webapi/query-data-web-api.md)|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveMultipleRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.RetrieveMultiple*>|
|RetrievePrincipalAccess|<xref href="Microsoft.Dynamics.CRM.RetrievePrincipalAccess?text=RetrievePrincipalAccess Function" />|<xref:Microsoft.Crm.Sdk.Messages.RetrievePrincipalAccessRequest>|
|RetrieveSharedPrincipalsAndAccess|<xref href="Microsoft.Dynamics.CRM.RetrieveSharedPrincipalsAndAccess?text=RetrieveSharedPrincipalsAndAccess Function" />|<xref:Microsoft.Crm.Sdk.Messages.RetrieveSharedPrincipalsAndAccessRequest>|
|RevokeAccess|<xref href="Microsoft.Dynamics.CRM.RevokeAccess?text=RevokeAccess Action" />|<xref:Microsoft.Crm.Sdk.Messages.RevokeAccessRequest>|
|SetState|PATCH [*org URI*]/api/data/v9.0/recurringappointmentmasters(*activityid*)<br />[Update](../webapi/update-delete-entities-using-web-api.md#basic-update) `statecode` and `statuscode` properties.|<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|
|Update|PATCH [*org URI*]/api/data/v9.0/recurringappointmentmasters(*activityid*)<br />See [Update](../webapi/update-delete-entities-using-web-api.md#basic-update)|<xref:Microsoft.Xrm.Sdk.Messages.UpdateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Update*>|

## Properties

**DisplayName**: Recurring Appointment<br />
**DisplayCollectionName**: Recurring Appointments<br />
**SchemaName**: RecurringAppointmentMaster<br />
**CollectionSchemaName**: RecurringAppointmentMasters<br />
**LogicalName**: recurringappointmentmaster<br />
**LogicalCollectionName**: recurringappointmentmasters<br />
**EntitySetName**: recurringappointmentmasters<br />
**PrimaryIdAttribute**: activityid<br />
**PrimaryNameAttribute**: subject<br />
**OwnershipType**: UserOwned<br />
**IsBPFEntity**: False<br />
<a name="writable-attributes"></a>

## Writable attributes

These attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [ActivityId](#BKMK_ActivityId)
- [Category](#BKMK_Category)
- [DayOfMonth](#BKMK_DayOfMonth)
- [DaysOfWeekMask](#BKMK_DaysOfWeekMask)
- [Description](#BKMK_Description)
- [Duration](#BKMK_Duration)
- [EffectiveEndDate](#BKMK_EffectiveEndDate)
- [EffectiveStartDate](#BKMK_EffectiveStartDate)
- [EndTime](#BKMK_EndTime)
- [FirstDayOfWeek](#BKMK_FirstDayOfWeek)
- [GlobalObjectId](#BKMK_GlobalObjectId)
- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [Instance](#BKMK_Instance)
- [Interval](#BKMK_Interval)
- [IsAllDayEvent](#BKMK_IsAllDayEvent)
- [IsBilled](#BKMK_IsBilled)
- [IsMapiPrivate](#BKMK_IsMapiPrivate)
- [IsNthMonthly](#BKMK_IsNthMonthly)
- [IsNthYearly](#BKMK_IsNthYearly)
- [IsRegenerate](#BKMK_IsRegenerate)
- [IsWeekDayPattern](#BKMK_IsWeekDayPattern)
- [IsWorkflowCreated](#BKMK_IsWorkflowCreated)
- [Location](#BKMK_Location)
- [MonthOfYear](#BKMK_MonthOfYear)
- [Occurrences](#BKMK_Occurrences)
- [OptionalAttendees](#BKMK_OptionalAttendees)
- [Organizer](#BKMK_Organizer)
- [OutlookOwnerApptId](#BKMK_OutlookOwnerApptId)
- [OverriddenCreatedOn](#BKMK_OverriddenCreatedOn)
- [OwnerId](#BKMK_OwnerId)
- [OwnerIdType](#BKMK_OwnerIdType)
- [PatternEndDate](#BKMK_PatternEndDate)
- [PatternEndType](#BKMK_PatternEndType)
- [PatternStartDate](#BKMK_PatternStartDate)
- [PriorityCode](#BKMK_PriorityCode)
- [ProcessId](#BKMK_ProcessId)
- [RecurrencePatternType](#BKMK_RecurrencePatternType)
- [RegardingObjectId](#BKMK_RegardingObjectId)
- [RegardingObjectTypeCode](#BKMK_RegardingObjectTypeCode)
- [RequiredAttendees](#BKMK_RequiredAttendees)
- [SeriesStatus](#BKMK_SeriesStatus)
- [ServiceId](#BKMK_ServiceId)
- [SortDate](#BKMK_SortDate)
- [StageId](#BKMK_StageId)
- [StartTime](#BKMK_StartTime)
- [StateCode](#BKMK_StateCode)
- [StatusCode](#BKMK_StatusCode)
- [Subcategory](#BKMK_Subcategory)
- [Subject](#BKMK_Subject)
- [SubscriptionId](#BKMK_SubscriptionId)
- [TimeZoneRuleVersionNumber](#BKMK_TimeZoneRuleVersionNumber)
- [TransactionCurrencyId](#BKMK_TransactionCurrencyId)
- [TraversedPath](#BKMK_TraversedPath)
- [UTCConversionTimeZoneCode](#BKMK_UTCConversionTimeZoneCode)


### <a name="BKMK_ActivityId"></a> ActivityId

**Description**: Unique identifier of the recurring appointment series.<br />
**DisplayName**: Recurring Appointment<br />
**LogicalName**: activityid<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: SystemRequired<br />
**IsValidForUpdate**: False<br />
**Type**: Uniqueidentifier<br />


### <a name="BKMK_Category"></a> Category

**Description**: Type a category to identify the recurring appointment type, such as status meeting or service call, to tie the appointment to a business group or function.<br />
**DisplayName**: Category<br />
**LogicalName**: category<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 250


### <a name="BKMK_DayOfMonth"></a> DayOfMonth

**Description**: The day of the month on which the recurring appointment occurs.<br />
**DisplayName**: Day Of Month<br />
**LogicalName**: dayofmonth<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Integer<br />
**Format**: None<br />
**MaxValue**: 31<br />
**MinValue**: 1


### <a name="BKMK_DaysOfWeekMask"></a> DaysOfWeekMask

**Description**: Bitmask that represents the days of the week on which the recurring appointment occurs.<br />
**DisplayName**: Days Of Week Mask<br />
**LogicalName**: daysofweekmask<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Integer<br />
**Format**: None<br />
**MaxValue**: 127<br />
**MinValue**: 1


### <a name="BKMK_Description"></a> Description

**Description**: Type additional information to describe the recurring appointment, such as key talking points or objectives.<br />
**DisplayName**: Description<br />
**LogicalName**: description<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Memo<br />
**Format**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 2000


### <a name="BKMK_Duration"></a> Duration

**Description**: Duration of the recurring appointment series in minutes.<br />
**DisplayName**: Duration<br />
**LogicalName**: duration<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Integer<br />
**Format**: Duration<br />
**MaxValue**: 2147483647<br />
**MinValue**: 0


### <a name="BKMK_EffectiveEndDate"></a> EffectiveEndDate

**Description**: Actual end date of the recurring appointment series based on the specified end date and recurrence pattern.<br />
**DisplayName**: Effective End Date<br />
**LogicalName**: effectiveenddate<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: DateTime<br />
**DateTimeBehavior**: UserLocal<br />
**Format**: DateAndTime


### <a name="BKMK_EffectiveStartDate"></a> EffectiveStartDate

**Description**: Actual start date of the recurring appointment series based on the specified start date and recurrence pattern.<br />
**DisplayName**: Effective Start Date<br />
**LogicalName**: effectivestartdate<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: DateTime<br />
**DateTimeBehavior**: UserLocal<br />
**Format**: DateOnly


### <a name="BKMK_EndTime"></a> EndTime

**Description**: End time of the associated activity.<br />
**DisplayName**: Pattern End Time<br />
**LogicalName**: endtime<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: DateTime<br />
**DateTimeBehavior**: UserLocal<br />
**Format**: DateAndTime


### <a name="BKMK_FirstDayOfWeek"></a> FirstDayOfWeek

**Description**: First day of week for the recurrence pattern.<br />
**DisplayName**: First Day Of Week<br />
**LogicalName**: firstdayofweek<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**IsValidForUpdate**: False<br />
**Type**: Integer<br />
**Format**: None<br />
**MaxValue**: 6<br />
**MinValue**: 0


### <a name="BKMK_GlobalObjectId"></a> GlobalObjectId

**Description**: Unique Outlook identifier to correlate recurring appointment series across Exchange mailboxes.<br />
**DisplayName**: Outlook Recurring Appointment Master<br />
**LogicalName**: globalobjectid<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 300


### <a name="BKMK_ImportSequenceNumber"></a> ImportSequenceNumber

**Description**: Unique identifier of the data import or data migration that created this record.<br />
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


### <a name="BKMK_Instance"></a> Instance

**Description**: Specifies the recurring appointment series to occur on every Nth day of a month. Valid for monthly and yearly recurrence patterns only.<br />
**DisplayName**: Instance<br />
**LogicalName**: instance<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Picklist<br />
**Options**:

- **Value**: 1 **Label**: First
- **Value**: 2 **Label**: Second
- **Value**: 3 **Label**: Third
- **Value**: 4 **Label**: Fourth
- **Value**: 5 **Label**: Last



### <a name="BKMK_Interval"></a> Interval

**Description**: Number of units of a given recurrence type between occurrences.<br />
**DisplayName**: Interval<br />
**LogicalName**: interval<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Integer<br />
**Format**: None<br />
**MaxValue**: 1000<br />
**MinValue**: 1


### <a name="BKMK_IsAllDayEvent"></a> IsAllDayEvent

**Description**: Select whether the recurring appointment is an all-day event to make sure that the required resources are scheduled for the full day.<br />
**DisplayName**: All Day Event<br />
**LogicalName**: isalldayevent<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Boolean<br />
**Options**:

- **TrueOption Value**: 1 **Label**: Yes
- **FalseOption Value**: 0 **Label**: No

**DefaultValue**: False


### <a name="BKMK_IsBilled"></a> IsBilled

**Description**: Indicates whether the recurring appointment series was billed as part of resolving a case.<br />
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


### <a name="BKMK_IsNthMonthly"></a> IsNthMonthly

**Description**: Indicates whether the recurring appointment series should occur after every N months. Valid for monthly recurrence pattern only.<br />
**DisplayName**: Nth Monthly<br />
**LogicalName**: isnthmonthly<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: SystemRequired<br />
**Type**: Boolean<br />
**Options**:

- **TrueOption Value**: 1 **Label**: Yes
- **FalseOption Value**: 0 **Label**: No

**DefaultValue**: False


### <a name="BKMK_IsNthYearly"></a> IsNthYearly

**Description**: Indicates whether the recurring appointment series should occur after every N years. Valid for yearly recurrence pattern only.<br />
**DisplayName**: Nth Yearly<br />
**LogicalName**: isnthyearly<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: SystemRequired<br />
**Type**: Boolean<br />
**Options**:

- **TrueOption Value**: 1 **Label**: Yes
- **FalseOption Value**: 0 **Label**: No

**DefaultValue**: False


### <a name="BKMK_IsRegenerate"></a> IsRegenerate

**Description**: For internal use only.<br />
**DisplayName**: Regenerate<br />
**LogicalName**: isregenerate<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: SystemRequired<br />
**Type**: Boolean<br />
**Options**:

- **TrueOption Value**: 1 **Label**: Yes
- **FalseOption Value**: 0 **Label**: No

**DefaultValue**: False


### <a name="BKMK_IsWeekDayPattern"></a> IsWeekDayPattern

**Description**: Indicates whether the weekly recurrence pattern is a daily weekday pattern. Valid for weekly recurrence pattern only.<br />
**DisplayName**: Every Weekday<br />
**LogicalName**: isweekdaypattern<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: SystemRequired<br />
**Type**: Boolean<br />
**Options**:

- **TrueOption Value**: 1 **Label**: Yes
- **FalseOption Value**: 0 **Label**: No

**DefaultValue**: False


### <a name="BKMK_IsWorkflowCreated"></a> IsWorkflowCreated

**Description**: Indicates whether the recurring appointment series was created from a workflow rule.<br />
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


### <a name="BKMK_Location"></a> Location

**Description**: Type the location where the recurring appointment will take place, such as a conference room or customer office.<br />
**DisplayName**: Location<br />
**LogicalName**: location<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 200


### <a name="BKMK_MonthOfYear"></a> MonthOfYear

**Description**: Indicates the month of the year for the recurrence pattern.<br />
**DisplayName**: Month Of Year<br />
**LogicalName**: monthofyear<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Picklist<br />
**Options**:

- **Value**: 0 **Label**: Invalid Month Of Year
- **Value**: 1 **Label**: January
- **Value**: 2 **Label**: February
- **Value**: 3 **Label**: March
- **Value**: 4 **Label**: April
- **Value**: 5 **Label**: May
- **Value**: 6 **Label**: June
- **Value**: 7 **Label**: July
- **Value**: 8 **Label**: August
- **Value**: 9 **Label**: September
- **Value**: 10 **Label**: October
- **Value**: 11 **Label**: November
- **Value**: 12 **Label**: December



### <a name="BKMK_Occurrences"></a> Occurrences

**Description**: Number of appointment occurrences in a recurring appointment series.<br />
**DisplayName**: Occurrences<br />
**LogicalName**: occurrences<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Integer<br />
**Format**: None<br />
**MaxValue**: 999<br />
**MinValue**: 1


### <a name="BKMK_OptionalAttendees"></a> OptionalAttendees

**Description**: Enter the account, contact, lead, user, or other equipment resources that are not needed at the recurring appointment, but can optionally attend.<br />
**DisplayName**: Optional Attendees<br />
**LogicalName**: optionalattendees<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: PartyList<br />
**Targets**: account,contact,equipment,lead,systemuser


### <a name="BKMK_Organizer"></a> Organizer

**Description**: Enter the user who is in charge of coordinating or leading the recurring appointment to make sure the appointment is displayed in the user's My Activities view.<br />
**DisplayName**: Organizer<br />
**LogicalName**: organizer<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: PartyList<br />
**Targets**: systemuser


### <a name="BKMK_OutlookOwnerApptId"></a> OutlookOwnerApptId

**Description**: Unique identifier of the Microsoft Office Outlook recurring appointment series owner that correlates to the PR_OWNER_APPT_ID MAPI property.<br />
**DisplayName**: Outlook Recurring Appointment Master Owner<br />
**LogicalName**: outlookownerapptid<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Integer<br />
**Format**: None<br />
**MaxValue**: 2147483647<br />
**MinValue**: -2147483648


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

**Description**: Enter the user or team who is assigned to manage the record. This field is updated every time the record is assigned to a different user.<br />
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


### <a name="BKMK_PatternEndDate"></a> PatternEndDate

**Description**: End date of the recurrence range.<br />
**DisplayName**: Recurrence Range End<br />
**LogicalName**: patternenddate<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: DateTime<br />
**DateTimeBehavior**: UserLocal<br />
**Format**: DateOnly


### <a name="BKMK_PatternEndType"></a> PatternEndType

**Description**: Select the type of end date for the recurring appointment, such as no end date or the number of occurrences.<br />
**DisplayName**: Pattern End Type<br />
**LogicalName**: patternendtype<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: SystemRequired<br />
**Type**: Picklist<br />
**Options**:

- **Value**: 1 **Label**: No End Date
- **Value**: 2 **Label**: Occurrences
- **Value**: 3 **Label**: Pattern End Date



### <a name="BKMK_PatternStartDate"></a> PatternStartDate

**Description**: Start date of the recurrence range.<br />
**DisplayName**: Recurrence Range Start<br />
**LogicalName**: patternstartdate<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: ApplicationRequired<br />
**Type**: DateTime<br />
**DateTimeBehavior**: UserLocal<br />
**Format**: DateOnly


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

**Description**: Shows the ID of the process.<br />
**DisplayName**: Process<br />
**LogicalName**: processid<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Uniqueidentifier<br />


### <a name="BKMK_RecurrencePatternType"></a> RecurrencePatternType

**Description**: Select the pattern type for the recurring appointment to indicate whether the appointment occurs daily, weekly, monthly, or yearly.<br />
**DisplayName**: Recurrence Frequency<br />
**LogicalName**: recurrencepatterntype<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: SystemRequired<br />
**Type**: Picklist<br />
**Options**:

- **Value**: 0 **Label**: Daily
- **Value**: 1 **Label**: Weekly
- **Value**: 2 **Label**: Monthly
- **Value**: 3 **Label**: Yearly



### <a name="BKMK_RegardingObjectId"></a> RegardingObjectId

**Description**: Choose the record that the recurring appointment series relates to.<br />
**DisplayName**: Regarding<br />
**LogicalName**: regardingobjectid<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: account,bookableresourcebooking,bookableresourcebookingheader,bulkoperation,campaign,campaignactivity,contact,contract,entitlement,entitlementtemplate,incident,invoice,knowledgearticle,knowledgebaserecord,lead,msdyn_agreement,msdyn_agreementbookingdate,msdyn_agreementbookingincident,msdyn_agreementbookingproduct,msdyn_agreementbookingservice,msdyn_agreementbookingservicetask,msdyn_agreementbookingsetup,msdyn_agreementinvoicedate,msdyn_agreementinvoiceproduct,msdyn_agreementinvoicesetup,msdyn_bookingalertstatus,msdyn_bookingrule,msdyn_bookingtimestamp,msdyn_customerasset,msdyn_fieldservicesetting,msdyn_incidenttypecharacteristic,msdyn_incidenttypeproduct,msdyn_incidenttypeservice,msdyn_inventoryadjustment,msdyn_inventoryadjustmentproduct,msdyn_inventoryjournal,msdyn_inventorytransfer,msdyn_payment,msdyn_paymentdetail,msdyn_paymentmethod,msdyn_paymentterm,msdyn_postalbum,msdyn_postalcode,msdyn_processnotes,msdyn_productinventory,msdyn_projectteam,msdyn_purchaseorder,msdyn_purchaseorderbill,msdyn_purchaseorderproduct,msdyn_purchaseorderreceipt,msdyn_purchaseorderreceiptproduct,msdyn_purchaseordersubstatus,msdyn_quotebookingincident,msdyn_quotebookingproduct,msdyn_quotebookingservice,msdyn_quotebookingservicetask,msdyn_resourceterritory,msdyn_rma,msdyn_rmaproduct,msdyn_rmareceipt,msdyn_rmareceiptproduct,msdyn_rmasubstatus,msdyn_rtv,msdyn_rtvproduct,msdyn_rtvsubstatus,msdyn_shipvia,msdyn_systemuserschedulersetting,msdyn_timegroup,msdyn_timegroupdetail,msdyn_timeoffrequest,msdyn_warehouse,msdyn_workorder,msdyn_workordercharacteristic,msdyn_workorderincident,msdyn_workorderproduct,msdyn_workorderresourcerestriction,msdyn_workorderservice,msdyn_workorderservicetask,opportunity,quote,salesorder,site


### <a name="BKMK_RegardingObjectTypeCode"></a> RegardingObjectTypeCode

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: regardingobjecttypecode<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: EntityName<br />


### <a name="BKMK_RequiredAttendees"></a> RequiredAttendees

**Description**: Enter the account, contact, lead, user, or other equipment resources that are required to attend the recurring appointment.<br />
**DisplayName**: Required Attendees<br />
**LogicalName**: requiredattendees<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: PartyList<br />
**Targets**: account,contact,equipment,lead,systemuser


### <a name="BKMK_SeriesStatus"></a> SeriesStatus

**Description**: Indicates whether the recurring appointment series is active or inactive.<br />
**DisplayName**: Series Status<br />
**LogicalName**: seriesstatus<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Boolean<br />
**Options**:

- **TrueOption Value**: 1 **Label**: Active
- **FalseOption Value**: 0 **Label**: Inactive

**DefaultValue**: True


### <a name="BKMK_ServiceId"></a> ServiceId

**Description**: Unique identifier for an associated service.<br />
**DisplayName**: Service<br />
**LogicalName**: serviceid<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: service


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

**Description**: Shows the ID of the stage.<br />
**DisplayName**: Process Stage<br />
**LogicalName**: stageid<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Uniqueidentifier<br />


### <a name="BKMK_StartTime"></a> StartTime

**Description**: Start time of the recurring appointment series.<br />
**DisplayName**: Pattern Start Time<br />
**LogicalName**: starttime<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: DateTime<br />
**DateTimeBehavior**: UserLocal<br />
**Format**: DateAndTime


### <a name="BKMK_StateCode"></a> StateCode

**Description**: Shows whether the recurring appointment is open, scheduled, completed, or canceled. Completed and canceled appointments are read-only and can't be edited.<br />
**DisplayName**: Status<br />
**LogicalName**: statecode<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: SystemRequired<br />
**Type**: State<br />
**Options**:

- **Value**: 0 **Label**: Open **DefaultStatus**: 1 **InvariantName**: Open
- **Value**: 1 **Label**: Completed **DefaultStatus**: 3 **InvariantName**: Completed
- **Value**: 2 **Label**: Canceled **DefaultStatus**: 4 **InvariantName**: Canceled
- **Value**: 3 **Label**: Scheduled **DefaultStatus**: 5 **InvariantName**: Scheduled



### <a name="BKMK_StatusCode"></a> StatusCode

**Description**: Select the recurring appointment's status.<br />
**DisplayName**: Status Reason<br />
**LogicalName**: statuscode<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Status<br />
**Options**:

- **Value**: 1 **Label**: Free **State**: 0
- **Value**: 2 **Label**: Tentative **State**: 0
- **Value**: 3 **Label**: Completed **State**: 1
- **Value**: 4 **Label**: Canceled **State**: 2
- **Value**: 5 **Label**: Busy **State**: 3
- **Value**: 6 **Label**: Out of Office **State**: 3



### <a name="BKMK_Subcategory"></a> Subcategory

**Description**: Type a subcategory to identify the recurring appointment type and relate the activity to a specific product, sales region, business group, or other function.<br />
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

**Description**: Type a short description about the objective or primary topic of the recurring appointment.<br />
**DisplayName**: Subject<br />
**LogicalName**: subject<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: ApplicationRequired<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 200


### <a name="BKMK_SubscriptionId"></a> SubscriptionId

**Description**: For internal use only.<br />
**DisplayName**: <br />
**LogicalName**: subscriptionid<br />
**IsValidForForm**: False<br />
**IsValidForRead**: False<br />
**RequiredLevel**: None<br />
**IsValidForUpdate**: False<br />
**Type**: Uniqueidentifier<br />


### <a name="BKMK_TimeZoneRuleVersionNumber"></a> TimeZoneRuleVersionNumber

**Description**: For internal use only.<br />
**DisplayName**: <br />
**LogicalName**: timezoneruleversionnumber<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Integer<br />
**Format**: None<br />
**MaxValue**: 2147483647<br />
**MinValue**: -1


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
**MinValue**: -1

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
- [DeletedExceptionsList](#BKMK_DeletedExceptionsList)
- [ExchangeRate](#BKMK_ExchangeRate)
- [ExpansionStateCode](#BKMK_ExpansionStateCode)
- [GroupId](#BKMK_GroupId)
- [InstanceTypeCode](#BKMK_InstanceTypeCode)
- [IsRegularActivity](#BKMK_IsRegularActivity)
- [LastExpandedInstanceDate](#BKMK_LastExpandedInstanceDate)
- [ModifiedBy](#BKMK_ModifiedBy)
- [ModifiedByName](#BKMK_ModifiedByName)
- [ModifiedByYomiName](#BKMK_ModifiedByYomiName)
- [ModifiedOn](#BKMK_ModifiedOn)
- [ModifiedOnBehalfBy](#BKMK_ModifiedOnBehalfBy)
- [ModifiedOnBehalfByName](#BKMK_ModifiedOnBehalfByName)
- [ModifiedOnBehalfByYomiName](#BKMK_ModifiedOnBehalfByYomiName)
- [NextExpansionInstanceDate](#BKMK_NextExpansionInstanceDate)
- [OwnerIdName](#BKMK_OwnerIdName)
- [OwnerIdYomiName](#BKMK_OwnerIdYomiName)
- [OwningBusinessUnit](#BKMK_OwningBusinessUnit)
- [OwningTeam](#BKMK_OwningTeam)
- [OwningUser](#BKMK_OwningUser)
- [RegardingObjectIdName](#BKMK_RegardingObjectIdName)
- [RegardingObjectIdYomiName](#BKMK_RegardingObjectIdYomiName)
- [RuleId](#BKMK_RuleId)
- [ScheduledEnd](#BKMK_ScheduledEnd)
- [ScheduledStart](#BKMK_ScheduledStart)
- [ServiceIdName](#BKMK_ServiceIdName)
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

**Description**: Shows who created the record.<br />
**DisplayName**: Created By<br />
**LogicalName**: createdby<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: systemuser


### <a name="BKMK_CreatedByName"></a> CreatedByName

**Description**: <br />
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

**Description**: Shows the date and time when the record was created. The date and time are displayed in the time zone selected in Microsoft Dynamics 365 options.<br />
**DisplayName**: Created On<br />
**LogicalName**: createdon<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: DateTime<br />
**DateTimeBehavior**: UserLocal<br />
**Format**: DateAndTime


### <a name="BKMK_CreatedOnBehalfBy"></a> CreatedOnBehalfBy

**Description**: Shows who created the record on behalf of another user.<br />
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


### <a name="BKMK_DeletedExceptionsList"></a> DeletedExceptionsList

**Description**: List of deleted instances of the recurring appointment series.<br />
**DisplayName**: Deleted Appointments<br />
**LogicalName**: deletedexceptionslist<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Memo<br />
**Format**: TextArea<br />
**IsLocalizable**: False<br />
**MaxLength**: 1073741823


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


### <a name="BKMK_ExpansionStateCode"></a> ExpansionStateCode

**Description**: State code to indicate whether the recurring appointment series is expanded fully or partially.<br />
**DisplayName**: Expansion State Code<br />
**LogicalName**: expansionstatecode<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: SystemRequired<br />
**Type**: Picklist<br />
**Options**:

- **Value**: 0 **Label**: Unexpanded
- **Value**: 1 **Label**: Partial
- **Value**: 2 **Label**: Full



### <a name="BKMK_GroupId"></a> GroupId

**Description**: Unique identifier of the recurring appointment series for which the recurrence information was updated. <br />
**DisplayName**: Group Id<br />
**LogicalName**: groupid<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: SystemRequired<br />
**Type**: Lookup<br />
**Targets**: recurringappointmentmaster


### <a name="BKMK_InstanceTypeCode"></a> InstanceTypeCode

**Description**: Type of instance of a recurring appointment series.<br />
**DisplayName**: Appointment Type<br />
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

**Description**: Indicates whether the activity is a regular activity type or event type.<br />
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


### <a name="BKMK_LastExpandedInstanceDate"></a> LastExpandedInstanceDate

**Description**: Date of last expanded instance of a recurring appointment series.<br />
**DisplayName**: Last Expanded Instance Date<br />
**LogicalName**: lastexpandedinstancedate<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: DateTime<br />
**DateTimeBehavior**: UserLocal<br />
**Format**: DateAndTime


### <a name="BKMK_ModifiedBy"></a> ModifiedBy

**Description**: Shows who last updated the record.<br />
**DisplayName**: Modified By<br />
**LogicalName**: modifiedby<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: systemuser


### <a name="BKMK_ModifiedByName"></a> ModifiedByName

**Description**: <br />
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

**Description**: Shows the date and time when the record was last updated. The date and time are displayed in the time zone selected in Microsoft Dynamics 365 options.<br />
**DisplayName**: Modified On<br />
**LogicalName**: modifiedon<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: DateTime<br />
**DateTimeBehavior**: UserLocal<br />
**Format**: DateAndTime


### <a name="BKMK_ModifiedOnBehalfBy"></a> ModifiedOnBehalfBy

**Description**: Shows who last updated the record on behalf of another user.<br />
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


### <a name="BKMK_NextExpansionInstanceDate"></a> NextExpansionInstanceDate

**Description**: Date of the next expanded instance of a recurring appointment series.<br />
**DisplayName**: Next Expanded Instance Date<br />
**LogicalName**: nextexpansioninstancedate<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: DateTime<br />
**DateTimeBehavior**: UserLocal<br />
**Format**: DateAndTime


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

**Description**: Unique identifier of the business unit that owns the recurring appointment series.<br />
**DisplayName**: Owning Business Unit<br />
**LogicalName**: owningbusinessunit<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: businessunit


### <a name="BKMK_OwningTeam"></a> OwningTeam

**Description**: Unique identifier of the team who owns the recurring appointment series.<br />
**DisplayName**: Owning Team<br />
**LogicalName**: owningteam<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: team


### <a name="BKMK_OwningUser"></a> OwningUser

**Description**: Unique identifier of the user who owns the recurring appointment series.<br />
**DisplayName**: Owning User<br />
**LogicalName**: owninguser<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: systemuser


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


### <a name="BKMK_RuleId"></a> RuleId

**Description**: Unique identifier of the recurrence rule that is associated with the recurring appointment series.<br />
**DisplayName**: Recurrence Rule<br />
**LogicalName**: ruleid<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: recurrencerule


### <a name="BKMK_ScheduledEnd"></a> ScheduledEnd

**Description**: Scheduled end time of the recurring appointment series.<br />
**DisplayName**: End Time<br />
**LogicalName**: scheduledend<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: DateTime<br />
**DateTimeBehavior**: UserLocal<br />
**Format**: DateAndTime


### <a name="BKMK_ScheduledStart"></a> ScheduledStart

**Description**: Scheduled start time of the recurring appointment series.<br />
**DisplayName**: Start Time<br />
**LogicalName**: scheduledstart<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: DateTime<br />
**DateTimeBehavior**: UserLocal<br />
**Format**: DateAndTime


### <a name="BKMK_ServiceIdName"></a> ServiceIdName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: serviceidname<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 160


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

**Description**: <br />
**DisplayName**: <br />
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

- [recurringappointmentmaster_campaignresponse](#BKMK_recurringappointmentmaster_campaignresponse)
- [recurringappointmentmaster_PostFollows](#BKMK_recurringappointmentmaster_PostFollows)
- [RecurringAppointmentMaster_SyncErrors](#BKMK_RecurringAppointmentMaster_SyncErrors)
- [RecurringAppointmentMaster_DuplicateBaseRecord](#BKMK_RecurringAppointmentMaster_DuplicateBaseRecord)
- [recurringappointmentmaster_actioncard](#BKMK_recurringappointmentmaster_actioncard)
- [RecurringAppointmentMaster_BulkDeleteFailures](#BKMK_RecurringAppointmentMaster_BulkDeleteFailures)
- [RecurringAppointmentMaster_QueueItem](#BKMK_RecurringAppointmentMaster_QueueItem)
- [RecurringAppointmentMaster_AsyncOperations](#BKMK_RecurringAppointmentMaster_AsyncOperations)
- [userentityinstancedata_recurringappointmentmaster](#BKMK_userentityinstancedata_recurringappointmentmaster)
- [recurringappointmentmaster_activity_parties](#BKMK_recurringappointmentmaster_activity_parties)
- [recurringappointmentmaster_connections2](#BKMK_recurringappointmentmaster_connections2)
- [recurringappointmentmaster_connections1](#BKMK_recurringappointmentmaster_connections1)
- [recurringappointmentmaster_principalobjectattributeaccess](#BKMK_recurringappointmentmaster_principalobjectattributeaccess)
- [recurringappointmentmaster_appointment](#BKMK_recurringappointmentmaster_appointment)
- [RecurringAppointmentMaster_ProcessSessions](#BKMK_RecurringAppointmentMaster_ProcessSessions)
- [RecurringAppointmentMaster_Annotation](#BKMK_RecurringAppointmentMaster_Annotation)
- [RecurringAppointmentMaster_DuplicateMatchingRecord](#BKMK_RecurringAppointmentMaster_DuplicateMatchingRecord)


### <a name="BKMK_recurringappointmentmaster_campaignresponse"></a> recurringappointmentmaster_campaignresponse

Same as campaignresponse entity [recurringappointmentmaster_campaignresponse](campaignresponse.md#BKMK_recurringappointmentmaster_campaignresponse) Many-To-One relationship.

**ReferencingEntity**: campaignresponse<br />
**ReferencingAttribute**: originatingactivityid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: recurringappointmentmaster_campaignresponse<br />
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


### <a name="BKMK_recurringappointmentmaster_PostFollows"></a> recurringappointmentmaster_PostFollows

Same as postfollow entity [recurringappointmentmaster_PostFollows](postfollow.md#BKMK_recurringappointmentmaster_PostFollows) Many-To-One relationship.

**ReferencingEntity**: postfollow<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: False<br />
**ReferencedEntityNavigationPropertyName**: recurringappointmentmaster_PostFollows<br />
**AssociatedMenuConfiguration**:

- **Behavior**: UseCollectionName
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


### <a name="BKMK_RecurringAppointmentMaster_SyncErrors"></a> RecurringAppointmentMaster_SyncErrors

Same as syncerror entity [RecurringAppointmentMaster_SyncErrors](syncerror.md#BKMK_RecurringAppointmentMaster_SyncErrors) Many-To-One relationship.

**ReferencingEntity**: syncerror<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: RecurringAppointmentMaster_SyncErrors<br />
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


### <a name="BKMK_RecurringAppointmentMaster_DuplicateBaseRecord"></a> RecurringAppointmentMaster_DuplicateBaseRecord

Same as duplicaterecord entity [RecurringAppointmentMaster_DuplicateBaseRecord](duplicaterecord.md#BKMK_RecurringAppointmentMaster_DuplicateBaseRecord) Many-To-One relationship.

**ReferencingEntity**: duplicaterecord<br />
**ReferencingAttribute**: baserecordid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: False<br />
**ReferencedEntityNavigationPropertyName**: RecurringAppointmentMaster_DuplicateBaseRecord<br />
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


### <a name="BKMK_recurringappointmentmaster_actioncard"></a> recurringappointmentmaster_actioncard

Same as actioncard entity [recurringappointmentmaster_actioncard](actioncard.md#BKMK_recurringappointmentmaster_actioncard) Many-To-One relationship.

**ReferencingEntity**: actioncard<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: recurringappointmentmaster_actioncard<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: Cascade
- **Delete**: Cascade
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_RecurringAppointmentMaster_BulkDeleteFailures"></a> RecurringAppointmentMaster_BulkDeleteFailures

Same as bulkdeletefailure entity [RecurringAppointmentMaster_BulkDeleteFailures](bulkdeletefailure.md#BKMK_RecurringAppointmentMaster_BulkDeleteFailures) Many-To-One relationship.

**ReferencingEntity**: bulkdeletefailure<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: False<br />
**ReferencedEntityNavigationPropertyName**: RecurringAppointmentMaster_BulkDeleteFailures<br />
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


### <a name="BKMK_RecurringAppointmentMaster_QueueItem"></a> RecurringAppointmentMaster_QueueItem

Same as queueitem entity [RecurringAppointmentMaster_QueueItem](queueitem.md#BKMK_RecurringAppointmentMaster_QueueItem) Many-To-One relationship.

**ReferencingEntity**: queueitem<br />
**ReferencingAttribute**: objectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: RecurringAppointmentMaster_QueueItem<br />
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


### <a name="BKMK_RecurringAppointmentMaster_AsyncOperations"></a> RecurringAppointmentMaster_AsyncOperations

Same as asyncoperation entity [RecurringAppointmentMaster_AsyncOperations](asyncoperation.md#BKMK_RecurringAppointmentMaster_AsyncOperations) Many-To-One relationship.

**ReferencingEntity**: asyncoperation<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: False<br />
**ReferencedEntityNavigationPropertyName**: RecurringAppointmentMaster_AsyncOperations<br />
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


### <a name="BKMK_userentityinstancedata_recurringappointmentmaster"></a> userentityinstancedata_recurringappointmentmaster

Same as userentityinstancedata entity [userentityinstancedata_recurringappointmentmaster](userentityinstancedata.md#BKMK_userentityinstancedata_recurringappointmentmaster) Many-To-One relationship.

**ReferencingEntity**: userentityinstancedata<br />
**ReferencingAttribute**: objectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: False<br />
**ReferencedEntityNavigationPropertyName**: userentityinstancedata_recurringappointmentmaster<br />
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


### <a name="BKMK_recurringappointmentmaster_activity_parties"></a> recurringappointmentmaster_activity_parties

Same as activityparty entity [recurringappointmentmaster_activity_parties](activityparty.md#BKMK_recurringappointmentmaster_activity_parties) Many-To-One relationship.

**ReferencingEntity**: activityparty<br />
**ReferencingAttribute**: activityid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: False<br />
**ReferencedEntityNavigationPropertyName**: recurringappointmentmaster_activity_parties<br />
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


### <a name="BKMK_recurringappointmentmaster_connections2"></a> recurringappointmentmaster_connections2

Same as connection entity [recurringappointmentmaster_connections2](connection.md#BKMK_recurringappointmentmaster_connections2) Many-To-One relationship.

**ReferencingEntity**: connection<br />
**ReferencingAttribute**: record2id<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: recurringappointmentmaster_connections2<br />
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


### <a name="BKMK_recurringappointmentmaster_connections1"></a> recurringappointmentmaster_connections1

Same as connection entity [recurringappointmentmaster_connections1](connection.md#BKMK_recurringappointmentmaster_connections1) Many-To-One relationship.

**ReferencingEntity**: connection<br />
**ReferencingAttribute**: record1id<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: recurringappointmentmaster_connections1<br />
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


### <a name="BKMK_recurringappointmentmaster_principalobjectattributeaccess"></a> recurringappointmentmaster_principalobjectattributeaccess

Same as principalobjectattributeaccess entity [recurringappointmentmaster_principalobjectattributeaccess](principalobjectattributeaccess.md#BKMK_recurringappointmentmaster_principalobjectattributeaccess) Many-To-One relationship.

**ReferencingEntity**: principalobjectattributeaccess<br />
**ReferencingAttribute**: objectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: False<br />
**ReferencedEntityNavigationPropertyName**: recurringappointmentmaster_principalobjectattributeaccess<br />
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


### <a name="BKMK_recurringappointmentmaster_appointment"></a> recurringappointmentmaster_appointment

Same as appointment entity [recurringappointmentmaster_appointment](appointment.md#BKMK_recurringappointmentmaster_appointment) Many-To-One relationship.

**ReferencingEntity**: appointment<br />
**ReferencingAttribute**: seriesid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: recurringappointmentmaster_appointment<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: Cascade
- **Delete**: Cascade
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_RecurringAppointmentMaster_ProcessSessions"></a> RecurringAppointmentMaster_ProcessSessions

Same as processsession entity [RecurringAppointmentMaster_ProcessSessions](processsession.md#BKMK_RecurringAppointmentMaster_ProcessSessions) Many-To-One relationship.

**ReferencingEntity**: processsession<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: False<br />
**ReferencedEntityNavigationPropertyName**: RecurringAppointmentMaster_ProcessSessions<br />
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


### <a name="BKMK_RecurringAppointmentMaster_Annotation"></a> RecurringAppointmentMaster_Annotation

Same as annotation entity [RecurringAppointmentMaster_Annotation](annotation.md#BKMK_RecurringAppointmentMaster_Annotation) Many-To-One relationship.

**ReferencingEntity**: annotation<br />
**ReferencingAttribute**: objectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: False<br />
**ReferencedEntityNavigationPropertyName**: RecurringAppointmentMaster_Annotation<br />
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


### <a name="BKMK_RecurringAppointmentMaster_DuplicateMatchingRecord"></a> RecurringAppointmentMaster_DuplicateMatchingRecord

Same as duplicaterecord entity [RecurringAppointmentMaster_DuplicateMatchingRecord](duplicaterecord.md#BKMK_RecurringAppointmentMaster_DuplicateMatchingRecord) Many-To-One relationship.

**ReferencingEntity**: duplicaterecord<br />
**ReferencingAttribute**: duplicaterecordid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: False<br />
**ReferencedEntityNavigationPropertyName**: RecurringAppointmentMaster_DuplicateMatchingRecord<br />
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

<a name="manytoone"></a>

## Many-To-One Relationships

Each Many-To-One relationship is defined by a corresponding One-To-Many relationship with the related entity. Listed by **SchemaName**.

- [Lead_RecurringAppointmentMasters](#BKMK_Lead_RecurringAppointmentMasters)
- [bookableresourcebooking_RecurringAppointmentMasters](#BKMK_bookableresourcebooking_RecurringAppointmentMasters)
- [bookableresourcebookingheader_RecurringAppointmentMasters](#BKMK_bookableresourcebookingheader_RecurringAppointmentMasters)
- [BulkOperation_RecurringAppointmentMaster](#BKMK_BulkOperation_RecurringAppointmentMaster)
- [Campaign_RecurringAppointmentMasters](#BKMK_Campaign_RecurringAppointmentMasters)
- [CampaignActivity_RecurringAppointmentMasters](#BKMK_CampaignActivity_RecurringAppointmentMasters)
- [Contract_RecurringAppointmentMasters](#BKMK_Contract_RecurringAppointmentMasters)
- [entitlement_RecurringAppointmentMasters](#BKMK_entitlement_RecurringAppointmentMasters)
- [entitlementtemplate_RecurringAppointmentMasters](#BKMK_entitlementtemplate_RecurringAppointmentMasters)
- [Incident_RecurringAppointmentMasters](#BKMK_Incident_RecurringAppointmentMasters)
- [site_RecurringAppointmentMasters](#BKMK_site_RecurringAppointmentMasters)
- [service_recurringappointmentmasters](#BKMK_service_recurringappointmentmasters)
- [Invoice_RecurringAppointmentMasters](#BKMK_Invoice_RecurringAppointmentMasters)
- [Opportunity_RecurringAppointmentMasters](#BKMK_Opportunity_RecurringAppointmentMasters)
- [Quote_RecurringAppointmentMasters](#BKMK_Quote_RecurringAppointmentMasters)
- [SalesOrder_RecurringAppointmentMasters](#BKMK_SalesOrder_RecurringAppointmentMasters)
- [msdyn_postalbum_RecurringAppointmentMasters](#BKMK_msdyn_postalbum_RecurringAppointmentMasters)
- [msdyn_bookingalertstatus_RecurringAppointmentMasters](#BKMK_msdyn_bookingalertstatus_RecurringAppointmentMasters)
- [msdyn_bookingrule_RecurringAppointmentMasters](#BKMK_msdyn_bookingrule_RecurringAppointmentMasters)
- [msdyn_resourceterritory_RecurringAppointmentMasters](#BKMK_msdyn_resourceterritory_RecurringAppointmentMasters)
- [msdyn_systemuserschedulersetting_RecurringAppointmentMasters](#BKMK_msdyn_systemuserschedulersetting_RecurringAppointmentMasters)
- [msdyn_timegroup_RecurringAppointmentMasters](#BKMK_msdyn_timegroup_RecurringAppointmentMasters)
- [msdyn_timegroupdetail_RecurringAppointmentMasters](#BKMK_msdyn_timegroupdetail_RecurringAppointmentMasters)
- [msdyn_processnotes_RecurringAppointmentMasters](#BKMK_msdyn_processnotes_RecurringAppointmentMasters)
- [msdyn_projectteam_RecurringAppointmentMasters](#BKMK_msdyn_projectteam_RecurringAppointmentMasters)
- [msdyn_agreement_RecurringAppointmentMasters](#BKMK_msdyn_agreement_RecurringAppointmentMasters)
- [msdyn_agreementbookingdate_RecurringAppointmentMasters](#BKMK_msdyn_agreementbookingdate_RecurringAppointmentMasters)
- [msdyn_agreementbookingincident_RecurringAppointmentMasters](#BKMK_msdyn_agreementbookingincident_RecurringAppointmentMasters)
- [msdyn_agreementbookingproduct_RecurringAppointmentMasters](#BKMK_msdyn_agreementbookingproduct_RecurringAppointmentMasters)
- [msdyn_agreementbookingservice_RecurringAppointmentMasters](#BKMK_msdyn_agreementbookingservice_RecurringAppointmentMasters)
- [msdyn_agreementbookingservicetask_RecurringAppointmentMasters](#BKMK_msdyn_agreementbookingservicetask_RecurringAppointmentMasters)
- [msdyn_agreementbookingsetup_RecurringAppointmentMasters](#BKMK_msdyn_agreementbookingsetup_RecurringAppointmentMasters)
- [msdyn_agreementinvoicedate_RecurringAppointmentMasters](#BKMK_msdyn_agreementinvoicedate_RecurringAppointmentMasters)
- [msdyn_agreementinvoiceproduct_RecurringAppointmentMasters](#BKMK_msdyn_agreementinvoiceproduct_RecurringAppointmentMasters)
- [msdyn_agreementinvoicesetup_RecurringAppointmentMasters](#BKMK_msdyn_agreementinvoicesetup_RecurringAppointmentMasters)
- [msdyn_bookingtimestamp_RecurringAppointmentMasters](#BKMK_msdyn_bookingtimestamp_RecurringAppointmentMasters)
- [msdyn_customerasset_RecurringAppointmentMasters](#BKMK_msdyn_customerasset_RecurringAppointmentMasters)
- [msdyn_fieldservicesetting_RecurringAppointmentMasters](#BKMK_msdyn_fieldservicesetting_RecurringAppointmentMasters)
- [msdyn_incidenttypecharacteristic_RecurringAppointmentMasters](#BKMK_msdyn_incidenttypecharacteristic_RecurringAppointmentMasters)
- [msdyn_incidenttypeproduct_RecurringAppointmentMasters](#BKMK_msdyn_incidenttypeproduct_RecurringAppointmentMasters)
- [msdyn_incidenttypeservice_RecurringAppointmentMasters](#BKMK_msdyn_incidenttypeservice_RecurringAppointmentMasters)
- [msdyn_inventoryadjustment_RecurringAppointmentMasters](#BKMK_msdyn_inventoryadjustment_RecurringAppointmentMasters)
- [msdyn_inventoryadjustmentproduct_RecurringAppointmentMasters](#BKMK_msdyn_inventoryadjustmentproduct_RecurringAppointmentMasters)
- [msdyn_inventoryjournal_RecurringAppointmentMasters](#BKMK_msdyn_inventoryjournal_RecurringAppointmentMasters)
- [msdyn_inventorytransfer_RecurringAppointmentMasters](#BKMK_msdyn_inventorytransfer_RecurringAppointmentMasters)
- [msdyn_payment_RecurringAppointmentMasters](#BKMK_msdyn_payment_RecurringAppointmentMasters)
- [msdyn_paymentdetail_RecurringAppointmentMasters](#BKMK_msdyn_paymentdetail_RecurringAppointmentMasters)
- [msdyn_paymentmethod_RecurringAppointmentMasters](#BKMK_msdyn_paymentmethod_RecurringAppointmentMasters)
- [msdyn_paymentterm_RecurringAppointmentMasters](#BKMK_msdyn_paymentterm_RecurringAppointmentMasters)
- [msdyn_postalcode_RecurringAppointmentMasters](#BKMK_msdyn_postalcode_RecurringAppointmentMasters)
- [msdyn_productinventory_RecurringAppointmentMasters](#BKMK_msdyn_productinventory_RecurringAppointmentMasters)
- [msdyn_purchaseorder_RecurringAppointmentMasters](#BKMK_msdyn_purchaseorder_RecurringAppointmentMasters)
- [msdyn_purchaseorderbill_RecurringAppointmentMasters](#BKMK_msdyn_purchaseorderbill_RecurringAppointmentMasters)
- [msdyn_purchaseorderproduct_RecurringAppointmentMasters](#BKMK_msdyn_purchaseorderproduct_RecurringAppointmentMasters)
- [msdyn_purchaseorderreceipt_RecurringAppointmentMasters](#BKMK_msdyn_purchaseorderreceipt_RecurringAppointmentMasters)
- [msdyn_purchaseorderreceiptproduct_RecurringAppointmentMasters](#BKMK_msdyn_purchaseorderreceiptproduct_RecurringAppointmentMasters)
- [msdyn_purchaseordersubstatus_RecurringAppointmentMasters](#BKMK_msdyn_purchaseordersubstatus_RecurringAppointmentMasters)
- [msdyn_quotebookingincident_RecurringAppointmentMasters](#BKMK_msdyn_quotebookingincident_RecurringAppointmentMasters)
- [msdyn_quotebookingproduct_RecurringAppointmentMasters](#BKMK_msdyn_quotebookingproduct_RecurringAppointmentMasters)
- [msdyn_quotebookingservice_RecurringAppointmentMasters](#BKMK_msdyn_quotebookingservice_RecurringAppointmentMasters)
- [msdyn_quotebookingservicetask_RecurringAppointmentMasters](#BKMK_msdyn_quotebookingservicetask_RecurringAppointmentMasters)
- [msdyn_rma_RecurringAppointmentMasters](#BKMK_msdyn_rma_RecurringAppointmentMasters)
- [msdyn_rmaproduct_RecurringAppointmentMasters](#BKMK_msdyn_rmaproduct_RecurringAppointmentMasters)
- [msdyn_rmareceipt_RecurringAppointmentMasters](#BKMK_msdyn_rmareceipt_RecurringAppointmentMasters)
- [msdyn_rmareceiptproduct_RecurringAppointmentMasters](#BKMK_msdyn_rmareceiptproduct_RecurringAppointmentMasters)
- [msdyn_rmasubstatus_RecurringAppointmentMasters](#BKMK_msdyn_rmasubstatus_RecurringAppointmentMasters)
- [msdyn_rtv_RecurringAppointmentMasters](#BKMK_msdyn_rtv_RecurringAppointmentMasters)
- [msdyn_rtvproduct_RecurringAppointmentMasters](#BKMK_msdyn_rtvproduct_RecurringAppointmentMasters)
- [msdyn_rtvsubstatus_RecurringAppointmentMasters](#BKMK_msdyn_rtvsubstatus_RecurringAppointmentMasters)
- [msdyn_shipvia_RecurringAppointmentMasters](#BKMK_msdyn_shipvia_RecurringAppointmentMasters)
- [msdyn_timeoffrequest_RecurringAppointmentMasters](#BKMK_msdyn_timeoffrequest_RecurringAppointmentMasters)
- [msdyn_warehouse_RecurringAppointmentMasters](#BKMK_msdyn_warehouse_RecurringAppointmentMasters)
- [msdyn_workorder_RecurringAppointmentMasters](#BKMK_msdyn_workorder_RecurringAppointmentMasters)
- [msdyn_workordercharacteristic_RecurringAppointmentMasters](#BKMK_msdyn_workordercharacteristic_RecurringAppointmentMasters)
- [msdyn_workorderincident_RecurringAppointmentMasters](#BKMK_msdyn_workorderincident_RecurringAppointmentMasters)
- [msdyn_workorderproduct_RecurringAppointmentMasters](#BKMK_msdyn_workorderproduct_RecurringAppointmentMasters)
- [msdyn_workorderresourcerestriction_RecurringAppointmentMasters](#BKMK_msdyn_workorderresourcerestriction_RecurringAppointmentMasters)
- [msdyn_workorderservice_RecurringAppointmentMasters](#BKMK_msdyn_workorderservice_RecurringAppointmentMasters)
- [msdyn_workorderservicetask_RecurringAppointmentMasters](#BKMK_msdyn_workorderservicetask_RecurringAppointmentMasters)
- [KnowledgeBaseRecord_RecurringAppointmentMasters](#BKMK_KnowledgeBaseRecord_RecurringAppointmentMasters)
- [TransactionCurrency_RecurringAppointmentMaster](#BKMK_TransactionCurrency_RecurringAppointmentMaster)
- [lk_recurringappointmentmaster_modifiedby](#BKMK_lk_recurringappointmentmaster_modifiedby)
- [activity_pointer_recurringappointmentmaster](#BKMK_activity_pointer_recurringappointmentmaster)
- [recurrencerule_recurringappointmentmaster](#BKMK_recurrencerule_recurringappointmentmaster)
- [team_recurringappointmentmaster](#BKMK_team_recurringappointmentmaster)
- [Contact_RecurringAppointmentMasters](#BKMK_Contact_RecurringAppointmentMasters)
- [processstage_recurringappointmentmasters](#BKMK_processstage_recurringappointmentmasters)
- [business_unit_recurringappointmentmaster_activities](#BKMK_business_unit_recurringappointmentmaster_activities)
- [lk_recurringappointmentmaster_createdonbehalfby](#BKMK_lk_recurringappointmentmaster_createdonbehalfby)
- [lk_recurringappointmentmaster_createdby](#BKMK_lk_recurringappointmentmaster_createdby)
- [Account_RecurringAppointmentMasters](#BKMK_Account_RecurringAppointmentMasters)
- [lk_recurringappointmentmaster_modifiedonbehalfby](#BKMK_lk_recurringappointmentmaster_modifiedonbehalfby)
- [user_recurringappointmentmaster](#BKMK_user_recurringappointmentmaster)
- [KnowledgeArticle_RecurringAppointmentMasters](#BKMK_KnowledgeArticle_RecurringAppointmentMasters)


### <a name="BKMK_Lead_RecurringAppointmentMasters"></a> Lead_RecurringAppointmentMasters

See lead Entity [Lead_RecurringAppointmentMasters](lead.md#BKMK_Lead_RecurringAppointmentMasters) One-To-Many relationship.

### <a name="BKMK_bookableresourcebooking_RecurringAppointmentMasters"></a> bookableresourcebooking_RecurringAppointmentMasters

See bookableresourcebooking Entity [bookableresourcebooking_RecurringAppointmentMasters](bookableresourcebooking.md#BKMK_bookableresourcebooking_RecurringAppointmentMasters) One-To-Many relationship.

### <a name="BKMK_bookableresourcebookingheader_RecurringAppointmentMasters"></a> bookableresourcebookingheader_RecurringAppointmentMasters

See bookableresourcebookingheader Entity [bookableresourcebookingheader_RecurringAppointmentMasters](bookableresourcebookingheader.md#BKMK_bookableresourcebookingheader_RecurringAppointmentMasters) One-To-Many relationship.

### <a name="BKMK_BulkOperation_RecurringAppointmentMaster"></a> BulkOperation_RecurringAppointmentMaster

See bulkoperation Entity [BulkOperation_RecurringAppointmentMaster](bulkoperation.md#BKMK_BulkOperation_RecurringAppointmentMaster) One-To-Many relationship.

### <a name="BKMK_Campaign_RecurringAppointmentMasters"></a> Campaign_RecurringAppointmentMasters

See campaign Entity [Campaign_RecurringAppointmentMasters](campaign.md#BKMK_Campaign_RecurringAppointmentMasters) One-To-Many relationship.

### <a name="BKMK_CampaignActivity_RecurringAppointmentMasters"></a> CampaignActivity_RecurringAppointmentMasters

See campaignactivity Entity [CampaignActivity_RecurringAppointmentMasters](campaignactivity.md#BKMK_CampaignActivity_RecurringAppointmentMasters) One-To-Many relationship.

### <a name="BKMK_Contract_RecurringAppointmentMasters"></a> Contract_RecurringAppointmentMasters

See contract Entity [Contract_RecurringAppointmentMasters](contract.md#BKMK_Contract_RecurringAppointmentMasters) One-To-Many relationship.

### <a name="BKMK_entitlement_RecurringAppointmentMasters"></a> entitlement_RecurringAppointmentMasters

See entitlement Entity [entitlement_RecurringAppointmentMasters](entitlement.md#BKMK_entitlement_RecurringAppointmentMasters) One-To-Many relationship.

### <a name="BKMK_entitlementtemplate_RecurringAppointmentMasters"></a> entitlementtemplate_RecurringAppointmentMasters

See entitlementtemplate Entity [entitlementtemplate_RecurringAppointmentMasters](entitlementtemplate.md#BKMK_entitlementtemplate_RecurringAppointmentMasters) One-To-Many relationship.

### <a name="BKMK_Incident_RecurringAppointmentMasters"></a> Incident_RecurringAppointmentMasters

See incident Entity [Incident_RecurringAppointmentMasters](incident.md#BKMK_Incident_RecurringAppointmentMasters) One-To-Many relationship.

### <a name="BKMK_site_RecurringAppointmentMasters"></a> site_RecurringAppointmentMasters

See site Entity [site_RecurringAppointmentMasters](site.md#BKMK_site_RecurringAppointmentMasters) One-To-Many relationship.

### <a name="BKMK_service_recurringappointmentmasters"></a> service_recurringappointmentmasters

See service Entity [service_recurringappointmentmasters](service.md#BKMK_service_recurringappointmentmasters) One-To-Many relationship.

### <a name="BKMK_Invoice_RecurringAppointmentMasters"></a> Invoice_RecurringAppointmentMasters

See invoice Entity [Invoice_RecurringAppointmentMasters](invoice.md#BKMK_Invoice_RecurringAppointmentMasters) One-To-Many relationship.

### <a name="BKMK_Opportunity_RecurringAppointmentMasters"></a> Opportunity_RecurringAppointmentMasters

See opportunity Entity [Opportunity_RecurringAppointmentMasters](opportunity.md#BKMK_Opportunity_RecurringAppointmentMasters) One-To-Many relationship.

### <a name="BKMK_Quote_RecurringAppointmentMasters"></a> Quote_RecurringAppointmentMasters

See quote Entity [Quote_RecurringAppointmentMasters](quote.md#BKMK_Quote_RecurringAppointmentMasters) One-To-Many relationship.

### <a name="BKMK_SalesOrder_RecurringAppointmentMasters"></a> SalesOrder_RecurringAppointmentMasters

See salesorder Entity [SalesOrder_RecurringAppointmentMasters](salesorder.md#BKMK_SalesOrder_RecurringAppointmentMasters) One-To-Many relationship.

### <a name="BKMK_msdyn_postalbum_RecurringAppointmentMasters"></a> msdyn_postalbum_RecurringAppointmentMasters

See msdyn_postalbum Entity [msdyn_postalbum_RecurringAppointmentMasters](msdyn_postalbum.md#BKMK_msdyn_postalbum_RecurringAppointmentMasters) One-To-Many relationship.

### <a name="BKMK_msdyn_bookingalertstatus_RecurringAppointmentMasters"></a> msdyn_bookingalertstatus_RecurringAppointmentMasters

See msdyn_bookingalertstatus Entity [msdyn_bookingalertstatus_RecurringAppointmentMasters](msdyn_bookingalertstatus.md#BKMK_msdyn_bookingalertstatus_RecurringAppointmentMasters) One-To-Many relationship.

### <a name="BKMK_msdyn_bookingrule_RecurringAppointmentMasters"></a> msdyn_bookingrule_RecurringAppointmentMasters

See msdyn_bookingrule Entity [msdyn_bookingrule_RecurringAppointmentMasters](msdyn_bookingrule.md#BKMK_msdyn_bookingrule_RecurringAppointmentMasters) One-To-Many relationship.

### <a name="BKMK_msdyn_resourceterritory_RecurringAppointmentMasters"></a> msdyn_resourceterritory_RecurringAppointmentMasters

See msdyn_resourceterritory Entity [msdyn_resourceterritory_RecurringAppointmentMasters](msdyn_resourceterritory.md#BKMK_msdyn_resourceterritory_RecurringAppointmentMasters) One-To-Many relationship.

### <a name="BKMK_msdyn_systemuserschedulersetting_RecurringAppointmentMasters"></a> msdyn_systemuserschedulersetting_RecurringAppointmentMasters

See msdyn_systemuserschedulersetting Entity [msdyn_systemuserschedulersetting_RecurringAppointmentMasters](msdyn_systemuserschedulersetting.md#BKMK_msdyn_systemuserschedulersetting_RecurringAppointmentMasters) One-To-Many relationship.

### <a name="BKMK_msdyn_timegroup_RecurringAppointmentMasters"></a> msdyn_timegroup_RecurringAppointmentMasters

See msdyn_timegroup Entity [msdyn_timegroup_RecurringAppointmentMasters](msdyn_timegroup.md#BKMK_msdyn_timegroup_RecurringAppointmentMasters) One-To-Many relationship.

### <a name="BKMK_msdyn_timegroupdetail_RecurringAppointmentMasters"></a> msdyn_timegroupdetail_RecurringAppointmentMasters

See msdyn_timegroupdetail Entity [msdyn_timegroupdetail_RecurringAppointmentMasters](msdyn_timegroupdetail.md#BKMK_msdyn_timegroupdetail_RecurringAppointmentMasters) One-To-Many relationship.

### <a name="BKMK_msdyn_processnotes_RecurringAppointmentMasters"></a> msdyn_processnotes_RecurringAppointmentMasters

See msdyn_processnotes Entity [msdyn_processnotes_RecurringAppointmentMasters](msdyn_processnotes.md#BKMK_msdyn_processnotes_RecurringAppointmentMasters) One-To-Many relationship.

### <a name="BKMK_msdyn_projectteam_RecurringAppointmentMasters"></a> msdyn_projectteam_RecurringAppointmentMasters

See msdyn_projectteam Entity [msdyn_projectteam_RecurringAppointmentMasters](msdyn_projectteam.md#BKMK_msdyn_projectteam_RecurringAppointmentMasters) One-To-Many relationship.

### <a name="BKMK_msdyn_agreement_RecurringAppointmentMasters"></a> msdyn_agreement_RecurringAppointmentMasters

See msdyn_agreement Entity [msdyn_agreement_RecurringAppointmentMasters](msdyn_agreement.md#BKMK_msdyn_agreement_RecurringAppointmentMasters) One-To-Many relationship.

### <a name="BKMK_msdyn_agreementbookingdate_RecurringAppointmentMasters"></a> msdyn_agreementbookingdate_RecurringAppointmentMasters

See msdyn_agreementbookingdate Entity [msdyn_agreementbookingdate_RecurringAppointmentMasters](msdyn_agreementbookingdate.md#BKMK_msdyn_agreementbookingdate_RecurringAppointmentMasters) One-To-Many relationship.

### <a name="BKMK_msdyn_agreementbookingincident_RecurringAppointmentMasters"></a> msdyn_agreementbookingincident_RecurringAppointmentMasters

See msdyn_agreementbookingincident Entity [msdyn_agreementbookingincident_RecurringAppointmentMasters](msdyn_agreementbookingincident.md#BKMK_msdyn_agreementbookingincident_RecurringAppointmentMasters) One-To-Many relationship.

### <a name="BKMK_msdyn_agreementbookingproduct_RecurringAppointmentMasters"></a> msdyn_agreementbookingproduct_RecurringAppointmentMasters

See msdyn_agreementbookingproduct Entity [msdyn_agreementbookingproduct_RecurringAppointmentMasters](msdyn_agreementbookingproduct.md#BKMK_msdyn_agreementbookingproduct_RecurringAppointmentMasters) One-To-Many relationship.

### <a name="BKMK_msdyn_agreementbookingservice_RecurringAppointmentMasters"></a> msdyn_agreementbookingservice_RecurringAppointmentMasters

See msdyn_agreementbookingservice Entity [msdyn_agreementbookingservice_RecurringAppointmentMasters](msdyn_agreementbookingservice.md#BKMK_msdyn_agreementbookingservice_RecurringAppointmentMasters) One-To-Many relationship.

### <a name="BKMK_msdyn_agreementbookingservicetask_RecurringAppointmentMasters"></a> msdyn_agreementbookingservicetask_RecurringAppointmentMasters

See msdyn_agreementbookingservicetask Entity [msdyn_agreementbookingservicetask_RecurringAppointmentMasters](msdyn_agreementbookingservicetask.md#BKMK_msdyn_agreementbookingservicetask_RecurringAppointmentMasters) One-To-Many relationship.

### <a name="BKMK_msdyn_agreementbookingsetup_RecurringAppointmentMasters"></a> msdyn_agreementbookingsetup_RecurringAppointmentMasters

See msdyn_agreementbookingsetup Entity [msdyn_agreementbookingsetup_RecurringAppointmentMasters](msdyn_agreementbookingsetup.md#BKMK_msdyn_agreementbookingsetup_RecurringAppointmentMasters) One-To-Many relationship.

### <a name="BKMK_msdyn_agreementinvoicedate_RecurringAppointmentMasters"></a> msdyn_agreementinvoicedate_RecurringAppointmentMasters

See msdyn_agreementinvoicedate Entity [msdyn_agreementinvoicedate_RecurringAppointmentMasters](msdyn_agreementinvoicedate.md#BKMK_msdyn_agreementinvoicedate_RecurringAppointmentMasters) One-To-Many relationship.

### <a name="BKMK_msdyn_agreementinvoiceproduct_RecurringAppointmentMasters"></a> msdyn_agreementinvoiceproduct_RecurringAppointmentMasters

See msdyn_agreementinvoiceproduct Entity [msdyn_agreementinvoiceproduct_RecurringAppointmentMasters](msdyn_agreementinvoiceproduct.md#BKMK_msdyn_agreementinvoiceproduct_RecurringAppointmentMasters) One-To-Many relationship.

### <a name="BKMK_msdyn_agreementinvoicesetup_RecurringAppointmentMasters"></a> msdyn_agreementinvoicesetup_RecurringAppointmentMasters

See msdyn_agreementinvoicesetup Entity [msdyn_agreementinvoicesetup_RecurringAppointmentMasters](msdyn_agreementinvoicesetup.md#BKMK_msdyn_agreementinvoicesetup_RecurringAppointmentMasters) One-To-Many relationship.

### <a name="BKMK_msdyn_bookingtimestamp_RecurringAppointmentMasters"></a> msdyn_bookingtimestamp_RecurringAppointmentMasters

See msdyn_bookingtimestamp Entity [msdyn_bookingtimestamp_RecurringAppointmentMasters](msdyn_bookingtimestamp.md#BKMK_msdyn_bookingtimestamp_RecurringAppointmentMasters) One-To-Many relationship.

### <a name="BKMK_msdyn_customerasset_RecurringAppointmentMasters"></a> msdyn_customerasset_RecurringAppointmentMasters

See msdyn_customerasset Entity [msdyn_customerasset_RecurringAppointmentMasters](msdyn_customerasset.md#BKMK_msdyn_customerasset_RecurringAppointmentMasters) One-To-Many relationship.

### <a name="BKMK_msdyn_fieldservicesetting_RecurringAppointmentMasters"></a> msdyn_fieldservicesetting_RecurringAppointmentMasters

See msdyn_fieldservicesetting Entity [msdyn_fieldservicesetting_RecurringAppointmentMasters](msdyn_fieldservicesetting.md#BKMK_msdyn_fieldservicesetting_RecurringAppointmentMasters) One-To-Many relationship.

### <a name="BKMK_msdyn_incidenttypecharacteristic_RecurringAppointmentMasters"></a> msdyn_incidenttypecharacteristic_RecurringAppointmentMasters

See msdyn_incidenttypecharacteristic Entity [msdyn_incidenttypecharacteristic_RecurringAppointmentMasters](msdyn_incidenttypecharacteristic.md#BKMK_msdyn_incidenttypecharacteristic_RecurringAppointmentMasters) One-To-Many relationship.

### <a name="BKMK_msdyn_incidenttypeproduct_RecurringAppointmentMasters"></a> msdyn_incidenttypeproduct_RecurringAppointmentMasters

See msdyn_incidenttypeproduct Entity [msdyn_incidenttypeproduct_RecurringAppointmentMasters](msdyn_incidenttypeproduct.md#BKMK_msdyn_incidenttypeproduct_RecurringAppointmentMasters) One-To-Many relationship.

### <a name="BKMK_msdyn_incidenttypeservice_RecurringAppointmentMasters"></a> msdyn_incidenttypeservice_RecurringAppointmentMasters

See msdyn_incidenttypeservice Entity [msdyn_incidenttypeservice_RecurringAppointmentMasters](msdyn_incidenttypeservice.md#BKMK_msdyn_incidenttypeservice_RecurringAppointmentMasters) One-To-Many relationship.

### <a name="BKMK_msdyn_inventoryadjustment_RecurringAppointmentMasters"></a> msdyn_inventoryadjustment_RecurringAppointmentMasters

See msdyn_inventoryadjustment Entity [msdyn_inventoryadjustment_RecurringAppointmentMasters](msdyn_inventoryadjustment.md#BKMK_msdyn_inventoryadjustment_RecurringAppointmentMasters) One-To-Many relationship.

### <a name="BKMK_msdyn_inventoryadjustmentproduct_RecurringAppointmentMasters"></a> msdyn_inventoryadjustmentproduct_RecurringAppointmentMasters

See msdyn_inventoryadjustmentproduct Entity [msdyn_inventoryadjustmentproduct_RecurringAppointmentMasters](msdyn_inventoryadjustmentproduct.md#BKMK_msdyn_inventoryadjustmentproduct_RecurringAppointmentMasters) One-To-Many relationship.

### <a name="BKMK_msdyn_inventoryjournal_RecurringAppointmentMasters"></a> msdyn_inventoryjournal_RecurringAppointmentMasters

See msdyn_inventoryjournal Entity [msdyn_inventoryjournal_RecurringAppointmentMasters](msdyn_inventoryjournal.md#BKMK_msdyn_inventoryjournal_RecurringAppointmentMasters) One-To-Many relationship.

### <a name="BKMK_msdyn_inventorytransfer_RecurringAppointmentMasters"></a> msdyn_inventorytransfer_RecurringAppointmentMasters

See msdyn_inventorytransfer Entity [msdyn_inventorytransfer_RecurringAppointmentMasters](msdyn_inventorytransfer.md#BKMK_msdyn_inventorytransfer_RecurringAppointmentMasters) One-To-Many relationship.

### <a name="BKMK_msdyn_payment_RecurringAppointmentMasters"></a> msdyn_payment_RecurringAppointmentMasters

See msdyn_payment Entity [msdyn_payment_RecurringAppointmentMasters](msdyn_payment.md#BKMK_msdyn_payment_RecurringAppointmentMasters) One-To-Many relationship.

### <a name="BKMK_msdyn_paymentdetail_RecurringAppointmentMasters"></a> msdyn_paymentdetail_RecurringAppointmentMasters

See msdyn_paymentdetail Entity [msdyn_paymentdetail_RecurringAppointmentMasters](msdyn_paymentdetail.md#BKMK_msdyn_paymentdetail_RecurringAppointmentMasters) One-To-Many relationship.

### <a name="BKMK_msdyn_paymentmethod_RecurringAppointmentMasters"></a> msdyn_paymentmethod_RecurringAppointmentMasters

See msdyn_paymentmethod Entity [msdyn_paymentmethod_RecurringAppointmentMasters](msdyn_paymentmethod.md#BKMK_msdyn_paymentmethod_RecurringAppointmentMasters) One-To-Many relationship.

### <a name="BKMK_msdyn_paymentterm_RecurringAppointmentMasters"></a> msdyn_paymentterm_RecurringAppointmentMasters

See msdyn_paymentterm Entity [msdyn_paymentterm_RecurringAppointmentMasters](msdyn_paymentterm.md#BKMK_msdyn_paymentterm_RecurringAppointmentMasters) One-To-Many relationship.

### <a name="BKMK_msdyn_postalcode_RecurringAppointmentMasters"></a> msdyn_postalcode_RecurringAppointmentMasters

See msdyn_postalcode Entity [msdyn_postalcode_RecurringAppointmentMasters](msdyn_postalcode.md#BKMK_msdyn_postalcode_RecurringAppointmentMasters) One-To-Many relationship.

### <a name="BKMK_msdyn_productinventory_RecurringAppointmentMasters"></a> msdyn_productinventory_RecurringAppointmentMasters

See msdyn_productinventory Entity [msdyn_productinventory_RecurringAppointmentMasters](msdyn_productinventory.md#BKMK_msdyn_productinventory_RecurringAppointmentMasters) One-To-Many relationship.

### <a name="BKMK_msdyn_purchaseorder_RecurringAppointmentMasters"></a> msdyn_purchaseorder_RecurringAppointmentMasters

See msdyn_purchaseorder Entity [msdyn_purchaseorder_RecurringAppointmentMasters](msdyn_purchaseorder.md#BKMK_msdyn_purchaseorder_RecurringAppointmentMasters) One-To-Many relationship.

### <a name="BKMK_msdyn_purchaseorderbill_RecurringAppointmentMasters"></a> msdyn_purchaseorderbill_RecurringAppointmentMasters

See msdyn_purchaseorderbill Entity [msdyn_purchaseorderbill_RecurringAppointmentMasters](msdyn_purchaseorderbill.md#BKMK_msdyn_purchaseorderbill_RecurringAppointmentMasters) One-To-Many relationship.

### <a name="BKMK_msdyn_purchaseorderproduct_RecurringAppointmentMasters"></a> msdyn_purchaseorderproduct_RecurringAppointmentMasters

See msdyn_purchaseorderproduct Entity [msdyn_purchaseorderproduct_RecurringAppointmentMasters](msdyn_purchaseorderproduct.md#BKMK_msdyn_purchaseorderproduct_RecurringAppointmentMasters) One-To-Many relationship.

### <a name="BKMK_msdyn_purchaseorderreceipt_RecurringAppointmentMasters"></a> msdyn_purchaseorderreceipt_RecurringAppointmentMasters

See msdyn_purchaseorderreceipt Entity [msdyn_purchaseorderreceipt_RecurringAppointmentMasters](msdyn_purchaseorderreceipt.md#BKMK_msdyn_purchaseorderreceipt_RecurringAppointmentMasters) One-To-Many relationship.

### <a name="BKMK_msdyn_purchaseorderreceiptproduct_RecurringAppointmentMasters"></a> msdyn_purchaseorderreceiptproduct_RecurringAppointmentMasters

See msdyn_purchaseorderreceiptproduct Entity [msdyn_purchaseorderreceiptproduct_RecurringAppointmentMasters](msdyn_purchaseorderreceiptproduct.md#BKMK_msdyn_purchaseorderreceiptproduct_RecurringAppointmentMasters) One-To-Many relationship.

### <a name="BKMK_msdyn_purchaseordersubstatus_RecurringAppointmentMasters"></a> msdyn_purchaseordersubstatus_RecurringAppointmentMasters

See msdyn_purchaseordersubstatus Entity [msdyn_purchaseordersubstatus_RecurringAppointmentMasters](msdyn_purchaseordersubstatus.md#BKMK_msdyn_purchaseordersubstatus_RecurringAppointmentMasters) One-To-Many relationship.

### <a name="BKMK_msdyn_quotebookingincident_RecurringAppointmentMasters"></a> msdyn_quotebookingincident_RecurringAppointmentMasters

See msdyn_quotebookingincident Entity [msdyn_quotebookingincident_RecurringAppointmentMasters](msdyn_quotebookingincident.md#BKMK_msdyn_quotebookingincident_RecurringAppointmentMasters) One-To-Many relationship.

### <a name="BKMK_msdyn_quotebookingproduct_RecurringAppointmentMasters"></a> msdyn_quotebookingproduct_RecurringAppointmentMasters

See msdyn_quotebookingproduct Entity [msdyn_quotebookingproduct_RecurringAppointmentMasters](msdyn_quotebookingproduct.md#BKMK_msdyn_quotebookingproduct_RecurringAppointmentMasters) One-To-Many relationship.

### <a name="BKMK_msdyn_quotebookingservice_RecurringAppointmentMasters"></a> msdyn_quotebookingservice_RecurringAppointmentMasters

See msdyn_quotebookingservice Entity [msdyn_quotebookingservice_RecurringAppointmentMasters](msdyn_quotebookingservice.md#BKMK_msdyn_quotebookingservice_RecurringAppointmentMasters) One-To-Many relationship.

### <a name="BKMK_msdyn_quotebookingservicetask_RecurringAppointmentMasters"></a> msdyn_quotebookingservicetask_RecurringAppointmentMasters

See msdyn_quotebookingservicetask Entity [msdyn_quotebookingservicetask_RecurringAppointmentMasters](msdyn_quotebookingservicetask.md#BKMK_msdyn_quotebookingservicetask_RecurringAppointmentMasters) One-To-Many relationship.

### <a name="BKMK_msdyn_rma_RecurringAppointmentMasters"></a> msdyn_rma_RecurringAppointmentMasters

See msdyn_rma Entity [msdyn_rma_RecurringAppointmentMasters](msdyn_rma.md#BKMK_msdyn_rma_RecurringAppointmentMasters) One-To-Many relationship.

### <a name="BKMK_msdyn_rmaproduct_RecurringAppointmentMasters"></a> msdyn_rmaproduct_RecurringAppointmentMasters

See msdyn_rmaproduct Entity [msdyn_rmaproduct_RecurringAppointmentMasters](msdyn_rmaproduct.md#BKMK_msdyn_rmaproduct_RecurringAppointmentMasters) One-To-Many relationship.

### <a name="BKMK_msdyn_rmareceipt_RecurringAppointmentMasters"></a> msdyn_rmareceipt_RecurringAppointmentMasters

See msdyn_rmareceipt Entity [msdyn_rmareceipt_RecurringAppointmentMasters](msdyn_rmareceipt.md#BKMK_msdyn_rmareceipt_RecurringAppointmentMasters) One-To-Many relationship.

### <a name="BKMK_msdyn_rmareceiptproduct_RecurringAppointmentMasters"></a> msdyn_rmareceiptproduct_RecurringAppointmentMasters

See msdyn_rmareceiptproduct Entity [msdyn_rmareceiptproduct_RecurringAppointmentMasters](msdyn_rmareceiptproduct.md#BKMK_msdyn_rmareceiptproduct_RecurringAppointmentMasters) One-To-Many relationship.

### <a name="BKMK_msdyn_rmasubstatus_RecurringAppointmentMasters"></a> msdyn_rmasubstatus_RecurringAppointmentMasters

See msdyn_rmasubstatus Entity [msdyn_rmasubstatus_RecurringAppointmentMasters](msdyn_rmasubstatus.md#BKMK_msdyn_rmasubstatus_RecurringAppointmentMasters) One-To-Many relationship.

### <a name="BKMK_msdyn_rtv_RecurringAppointmentMasters"></a> msdyn_rtv_RecurringAppointmentMasters

See msdyn_rtv Entity [msdyn_rtv_RecurringAppointmentMasters](msdyn_rtv.md#BKMK_msdyn_rtv_RecurringAppointmentMasters) One-To-Many relationship.

### <a name="BKMK_msdyn_rtvproduct_RecurringAppointmentMasters"></a> msdyn_rtvproduct_RecurringAppointmentMasters

See msdyn_rtvproduct Entity [msdyn_rtvproduct_RecurringAppointmentMasters](msdyn_rtvproduct.md#BKMK_msdyn_rtvproduct_RecurringAppointmentMasters) One-To-Many relationship.

### <a name="BKMK_msdyn_rtvsubstatus_RecurringAppointmentMasters"></a> msdyn_rtvsubstatus_RecurringAppointmentMasters

See msdyn_rtvsubstatus Entity [msdyn_rtvsubstatus_RecurringAppointmentMasters](msdyn_rtvsubstatus.md#BKMK_msdyn_rtvsubstatus_RecurringAppointmentMasters) One-To-Many relationship.

### <a name="BKMK_msdyn_shipvia_RecurringAppointmentMasters"></a> msdyn_shipvia_RecurringAppointmentMasters

See msdyn_shipvia Entity [msdyn_shipvia_RecurringAppointmentMasters](msdyn_shipvia.md#BKMK_msdyn_shipvia_RecurringAppointmentMasters) One-To-Many relationship.

### <a name="BKMK_msdyn_timeoffrequest_RecurringAppointmentMasters"></a> msdyn_timeoffrequest_RecurringAppointmentMasters

See msdyn_timeoffrequest Entity [msdyn_timeoffrequest_RecurringAppointmentMasters](msdyn_timeoffrequest.md#BKMK_msdyn_timeoffrequest_RecurringAppointmentMasters) One-To-Many relationship.

### <a name="BKMK_msdyn_warehouse_RecurringAppointmentMasters"></a> msdyn_warehouse_RecurringAppointmentMasters

See msdyn_warehouse Entity [msdyn_warehouse_RecurringAppointmentMasters](msdyn_warehouse.md#BKMK_msdyn_warehouse_RecurringAppointmentMasters) One-To-Many relationship.

### <a name="BKMK_msdyn_workorder_RecurringAppointmentMasters"></a> msdyn_workorder_RecurringAppointmentMasters

See msdyn_workorder Entity [msdyn_workorder_RecurringAppointmentMasters](msdyn_workorder.md#BKMK_msdyn_workorder_RecurringAppointmentMasters) One-To-Many relationship.

### <a name="BKMK_msdyn_workordercharacteristic_RecurringAppointmentMasters"></a> msdyn_workordercharacteristic_RecurringAppointmentMasters

See msdyn_workordercharacteristic Entity [msdyn_workordercharacteristic_RecurringAppointmentMasters](msdyn_workordercharacteristic.md#BKMK_msdyn_workordercharacteristic_RecurringAppointmentMasters) One-To-Many relationship.

### <a name="BKMK_msdyn_workorderincident_RecurringAppointmentMasters"></a> msdyn_workorderincident_RecurringAppointmentMasters

See msdyn_workorderincident Entity [msdyn_workorderincident_RecurringAppointmentMasters](msdyn_workorderincident.md#BKMK_msdyn_workorderincident_RecurringAppointmentMasters) One-To-Many relationship.

### <a name="BKMK_msdyn_workorderproduct_RecurringAppointmentMasters"></a> msdyn_workorderproduct_RecurringAppointmentMasters

See msdyn_workorderproduct Entity [msdyn_workorderproduct_RecurringAppointmentMasters](msdyn_workorderproduct.md#BKMK_msdyn_workorderproduct_RecurringAppointmentMasters) One-To-Many relationship.

### <a name="BKMK_msdyn_workorderresourcerestriction_RecurringAppointmentMasters"></a> msdyn_workorderresourcerestriction_RecurringAppointmentMasters

See msdyn_workorderresourcerestriction Entity [msdyn_workorderresourcerestriction_RecurringAppointmentMasters](msdyn_workorderresourcerestriction.md#BKMK_msdyn_workorderresourcerestriction_RecurringAppointmentMasters) One-To-Many relationship.

### <a name="BKMK_msdyn_workorderservice_RecurringAppointmentMasters"></a> msdyn_workorderservice_RecurringAppointmentMasters

See msdyn_workorderservice Entity [msdyn_workorderservice_RecurringAppointmentMasters](msdyn_workorderservice.md#BKMK_msdyn_workorderservice_RecurringAppointmentMasters) One-To-Many relationship.

### <a name="BKMK_msdyn_workorderservicetask_RecurringAppointmentMasters"></a> msdyn_workorderservicetask_RecurringAppointmentMasters

See msdyn_workorderservicetask Entity [msdyn_workorderservicetask_RecurringAppointmentMasters](msdyn_workorderservicetask.md#BKMK_msdyn_workorderservicetask_RecurringAppointmentMasters) One-To-Many relationship.

### <a name="BKMK_KnowledgeBaseRecord_RecurringAppointmentMasters"></a> KnowledgeBaseRecord_RecurringAppointmentMasters

See knowledgebaserecord Entity [KnowledgeBaseRecord_RecurringAppointmentMasters](knowledgebaserecord.md#BKMK_KnowledgeBaseRecord_RecurringAppointmentMasters) One-To-Many relationship.

### <a name="BKMK_TransactionCurrency_RecurringAppointmentMaster"></a> TransactionCurrency_RecurringAppointmentMaster

See transactioncurrency Entity [TransactionCurrency_RecurringAppointmentMaster](transactioncurrency.md#BKMK_TransactionCurrency_RecurringAppointmentMaster) One-To-Many relationship.

### <a name="BKMK_lk_recurringappointmentmaster_modifiedby"></a> lk_recurringappointmentmaster_modifiedby

See systemuser Entity [lk_recurringappointmentmaster_modifiedby](systemuser.md#BKMK_lk_recurringappointmentmaster_modifiedby) One-To-Many relationship.

### <a name="BKMK_activity_pointer_recurringappointmentmaster"></a> activity_pointer_recurringappointmentmaster

See activitypointer Entity [activity_pointer_recurringappointmentmaster](activitypointer.md#BKMK_activity_pointer_recurringappointmentmaster) One-To-Many relationship.

### <a name="BKMK_recurrencerule_recurringappointmentmaster"></a> recurrencerule_recurringappointmentmaster

See recurrencerule Entity [recurrencerule_recurringappointmentmaster](recurrencerule.md#BKMK_recurrencerule_recurringappointmentmaster) One-To-Many relationship.

### <a name="BKMK_team_recurringappointmentmaster"></a> team_recurringappointmentmaster

See team Entity [team_recurringappointmentmaster](team.md#BKMK_team_recurringappointmentmaster) One-To-Many relationship.

### <a name="BKMK_Contact_RecurringAppointmentMasters"></a> Contact_RecurringAppointmentMasters

See contact Entity [Contact_RecurringAppointmentMasters](contact.md#BKMK_Contact_RecurringAppointmentMasters) One-To-Many relationship.

### <a name="BKMK_processstage_recurringappointmentmasters"></a> processstage_recurringappointmentmasters

See processstage Entity [processstage_recurringappointmentmasters](processstage.md#BKMK_processstage_recurringappointmentmasters) One-To-Many relationship.

### <a name="BKMK_business_unit_recurringappointmentmaster_activities"></a> business_unit_recurringappointmentmaster_activities

See businessunit Entity [business_unit_recurringappointmentmaster_activities](businessunit.md#BKMK_business_unit_recurringappointmentmaster_activities) One-To-Many relationship.

### <a name="BKMK_lk_recurringappointmentmaster_createdonbehalfby"></a> lk_recurringappointmentmaster_createdonbehalfby

See systemuser Entity [lk_recurringappointmentmaster_createdonbehalfby](systemuser.md#BKMK_lk_recurringappointmentmaster_createdonbehalfby) One-To-Many relationship.

### <a name="BKMK_lk_recurringappointmentmaster_createdby"></a> lk_recurringappointmentmaster_createdby

See systemuser Entity [lk_recurringappointmentmaster_createdby](systemuser.md#BKMK_lk_recurringappointmentmaster_createdby) One-To-Many relationship.

### <a name="BKMK_Account_RecurringAppointmentMasters"></a> Account_RecurringAppointmentMasters

See account Entity [Account_RecurringAppointmentMasters](account.md#BKMK_Account_RecurringAppointmentMasters) One-To-Many relationship.

### <a name="BKMK_lk_recurringappointmentmaster_modifiedonbehalfby"></a> lk_recurringappointmentmaster_modifiedonbehalfby

See systemuser Entity [lk_recurringappointmentmaster_modifiedonbehalfby](systemuser.md#BKMK_lk_recurringappointmentmaster_modifiedonbehalfby) One-To-Many relationship.

### <a name="BKMK_user_recurringappointmentmaster"></a> user_recurringappointmentmaster

See systemuser Entity [user_recurringappointmentmaster](systemuser.md#BKMK_user_recurringappointmentmaster) One-To-Many relationship.

### <a name="BKMK_KnowledgeArticle_RecurringAppointmentMasters"></a> KnowledgeArticle_RecurringAppointmentMasters

See knowledgearticle Entity [KnowledgeArticle_RecurringAppointmentMasters](knowledgearticle.md#BKMK_KnowledgeArticle_RecurringAppointmentMasters) One-To-Many relationship.

## See also

[About the Entity Reference](../about-entity-reference.md)<br />
[Programming reference for Dynamics 365 Customer Engagement](../programming-reference.md)<br />
[Web API Reference](/dynamics365/customer-engagement/web-api/about)<br />
<xref href="Microsoft.Dynamics.CRM.recurringappointmentmaster?text=recurringappointmentmaster EntityType" />