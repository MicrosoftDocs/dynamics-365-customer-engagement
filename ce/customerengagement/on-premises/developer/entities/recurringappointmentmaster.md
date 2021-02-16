---
title: "RecurringAppointmentMaster Entity Reference (Dynamics 365 Customer Engagement)| MicrosoftDocs"
description: "Includes schema information and supported messages for the RecurringAppointmentMaster entity."
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
# RecurringAppointmentMaster Entity Reference

The Master appointment of a recurring appointment series.


## Messages

|Message|Web API Operation|SDK Assembly|
|-|-|-|
|AddRecurrence|<xref href="Microsoft.Dynamics.CRM.AddRecurrence?text=AddRecurrence Action" />|<xref:Microsoft.Crm.Sdk.Messages.AddRecurrenceRequest>|
|Assign|PATCH [*org URI*]/api/data/v9.0/recurringappointmentmasters(*activityid*)<br />[Update](/powerapps/developer/common-data-service/webapi/update-delete-entities-using-web-api#basic-update) `ownerid` property.|<xref:Microsoft.Crm.Sdk.Messages.AssignRequest>|
|Book|<xref href="Microsoft.Dynamics.CRM.Book?text=Book Action" />|<xref:Microsoft.Crm.Sdk.Messages.BookRequest>|
|Create|POST [*org URI*]/api/data/v9.0/recurringappointmentmasters<br />See [Create](/powerapps/developer/common-data-service/webapi/create-entity-web-api)|<xref:Microsoft.Xrm.Sdk.Messages.CreateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Create*>|
|CreateInstance|<xref href="Microsoft.Dynamics.CRM.CreateInstance?text=CreateInstance Action" />|<xref:Microsoft.Crm.Sdk.Messages.CreateInstanceRequest>|
|Delete|DELETE [*org URI*]/api/data/v9.0/recurringappointmentmasters(*activityid*)<br />See [Delete](/powerapps/developer/common-data-service/webapi/update-delete-entities-using-web-api#basic-delete)|<xref:Microsoft.Xrm.Sdk.Messages.DeleteRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Delete*>|
|DeleteOpenInstances|<xref href="Microsoft.Dynamics.CRM.DeleteOpenInstances?text=DeleteOpenInstances Action" />|<xref:Microsoft.Crm.Sdk.Messages.DeleteOpenInstancesRequest>|
|GrantAccess|<xref href="Microsoft.Dynamics.CRM.GrantAccess?text=GrantAccess Action" />|<xref:Microsoft.Crm.Sdk.Messages.GrantAccessRequest>|
|ModifyAccess|<xref href="Microsoft.Dynamics.CRM.ModifyAccess?text=ModifyAccess Action" />|<xref:Microsoft.Crm.Sdk.Messages.ModifyAccessRequest>|
|Reschedule|<xref href="Microsoft.Dynamics.CRM.Reschedule?text=Reschedule Action" />|<xref:Microsoft.Crm.Sdk.Messages.RescheduleRequest>|
|Retrieve|GET [*org URI*]/api/data/v9.0/recurringappointmentmasters(*activityid*)<br />See [Retrieve](/powerapps/developer/common-data-service/webapi/retrieve-entity-using-web-api)|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Retrieve*>|
|RetrieveMultiple|GET [*org URI*]/api/data/v9.0/recurringappointmentmasters<br />See [Query Data](/powerapps/developer/common-data-service/webapi/query-data-web-api)|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveMultipleRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.RetrieveMultiple*>|
|RetrievePrincipalAccess|<xref href="Microsoft.Dynamics.CRM.RetrievePrincipalAccess?text=RetrievePrincipalAccess Function" />|<xref:Microsoft.Crm.Sdk.Messages.RetrievePrincipalAccessRequest>|
|RetrieveSharedPrincipalsAndAccess|<xref href="Microsoft.Dynamics.CRM.RetrieveSharedPrincipalsAndAccess?text=RetrieveSharedPrincipalsAndAccess Function" />|<xref:Microsoft.Crm.Sdk.Messages.RetrieveSharedPrincipalsAndAccessRequest>|
|RevokeAccess|<xref href="Microsoft.Dynamics.CRM.RevokeAccess?text=RevokeAccess Action" />|<xref:Microsoft.Crm.Sdk.Messages.RevokeAccessRequest>|
|SetState|PATCH [*org URI*]/api/data/v9.0/recurringappointmentmasters(*activityid*)<br />[Update](/powerapps/developer/common-data-service/webapi/update-delete-entities-using-web-api#basic-update) `statecode` and `statuscode` properties.|<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|
|Update|PATCH [*org URI*]/api/data/v9.0/recurringappointmentmasters(*activityid*)<br />See [Update](/powerapps/developer/common-data-service/webapi/update-delete-entities-using-web-api#basic-update)|<xref:Microsoft.Xrm.Sdk.Messages.UpdateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Update*>|

## Entity Properties

|Property|Value|
|--------|-----|
|CollectionSchemaName|RecurringAppointmentMasters|
|DisplayCollectionName|Recurring Appointments|
|DisplayName|Recurring Appointment|
|EntitySetName|recurringappointmentmasters|
|IsBPFEntity|False|
|LogicalCollectionName|recurringappointmentmasters|
|LogicalName|recurringappointmentmaster|
|OwnershipType|UserOwned|
|PrimaryIdAttribute|activityid|
|PrimaryNameAttribute|subject|
|SchemaName|RecurringAppointmentMaster|

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

|Property|Value|
|--------|-----|
|Description|Unique identifier of the recurring appointment series.|
|DisplayName|Recurring Appointment|
|IsValidForForm|False|
|IsValidForRead|True|
|IsValidForUpdate|False|
|LogicalName|activityid|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|


### <a name="BKMK_Category"></a> Category

|Property|Value|
|--------|-----|
|Description|Type a category to identify the recurring appointment type, such as status meeting or service call, to tie the appointment to a business group or function.|
|DisplayName|Category|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|category|
|MaxLength|250|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_DayOfMonth"></a> DayOfMonth

|Property|Value|
|--------|-----|
|Description|The day of the month on which the recurring appointment occurs.|
|DisplayName|Day Of Month|
|Format|None|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|dayofmonth|
|MaxValue|31|
|MinValue|1|
|RequiredLevel|None|
|Type|Integer|


### <a name="BKMK_DaysOfWeekMask"></a> DaysOfWeekMask

|Property|Value|
|--------|-----|
|Description|Bitmask that represents the days of the week on which the recurring appointment occurs.|
|DisplayName|Days Of Week Mask|
|Format|None|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|daysofweekmask|
|MaxValue|127|
|MinValue|1|
|RequiredLevel|None|
|Type|Integer|


### <a name="BKMK_Description"></a> Description

|Property|Value|
|--------|-----|
|Description|Type additional information to describe the recurring appointment, such as key talking points or objectives.|
|DisplayName|Description|
|Format|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|description|
|MaxLength|1048576|
|RequiredLevel|None|
|Type|Memo|


### <a name="BKMK_Duration"></a> Duration

|Property|Value|
|--------|-----|
|Description|Duration of the recurring appointment series in minutes.|
|DisplayName|Duration|
|Format|Duration|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|duration|
|MaxValue|2147483647|
|MinValue|0|
|RequiredLevel|None|
|Type|Integer|


### <a name="BKMK_EffectiveEndDate"></a> EffectiveEndDate

|Property|Value|
|--------|-----|
|DateTimeBehavior|UserLocal|
|Description|Actual end date of the recurring appointment series based on the specified end date and recurrence pattern.|
|DisplayName|Effective End Date|
|Format|DateAndTime|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|effectiveenddate|
|RequiredLevel|None|
|Type|DateTime|


### <a name="BKMK_EffectiveStartDate"></a> EffectiveStartDate

|Property|Value|
|--------|-----|
|DateTimeBehavior|UserLocal|
|Description|Actual start date of the recurring appointment series based on the specified start date and recurrence pattern.|
|DisplayName|Effective Start Date|
|Format|DateOnly|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|effectivestartdate|
|RequiredLevel|None|
|Type|DateTime|


### <a name="BKMK_EndTime"></a> EndTime

|Property|Value|
|--------|-----|
|DateTimeBehavior|UserLocal|
|Description|End time of the associated activity.|
|DisplayName|Pattern End Time|
|Format|DateAndTime|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|endtime|
|RequiredLevel|None|
|Type|DateTime|


### <a name="BKMK_FirstDayOfWeek"></a> FirstDayOfWeek

|Property|Value|
|--------|-----|
|Description|First day of week for the recurrence pattern.|
|DisplayName|First Day Of Week|
|Format|None|
|IsValidForForm|False|
|IsValidForRead|True|
|IsValidForUpdate|False|
|LogicalName|firstdayofweek|
|MaxValue|6|
|MinValue|0|
|RequiredLevel|None|
|Type|Integer|


### <a name="BKMK_GlobalObjectId"></a> GlobalObjectId

|Property|Value|
|--------|-----|
|Description|Unique Outlook identifier to correlate recurring appointment series across Exchange mailboxes.|
|DisplayName|Outlook Recurring Appointment Master|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|globalobjectid|
|MaxLength|300|
|RequiredLevel|None|
|Type|String|


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


### <a name="BKMK_Instance"></a> Instance

|Property|Value|
|--------|-----|
|Description|Specifies the recurring appointment series to occur on every Nth day of a month. Valid for monthly and yearly recurrence patterns only.|
|DisplayName|Instance|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|instance|
|RequiredLevel|None|
|Type|Picklist|

#### Instance Options

|Value|Label|
|-----|-----|
|1|First|
|2|Second|
|3|Third|
|4|Fourth|
|5|Last|



### <a name="BKMK_Interval"></a> Interval

|Property|Value|
|--------|-----|
|Description|Number of units of a given recurrence type between occurrences.|
|DisplayName|Interval|
|Format|None|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|interval|
|MaxValue|1000|
|MinValue|1|
|RequiredLevel|None|
|Type|Integer|


### <a name="BKMK_IsAllDayEvent"></a> IsAllDayEvent

|Property|Value|
|--------|-----|
|Description|Select whether the recurring appointment is an all-day event to make sure that the required resources are scheduled for the full day.|
|DisplayName|All Day Event|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|isalldayevent|
|RequiredLevel|None|
|Type|Boolean|

#### IsAllDayEvent Options

|Value|Label|
|-----|-----|
|1|Yes|
|0|No|

**DefaultValue**: False



### <a name="BKMK_IsBilled"></a> IsBilled

|Property|Value|
|--------|-----|
|Description|Indicates whether the recurring appointment series was billed as part of resolving a case.|
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

#### IsMapiPrivate Options

|Value|Label|
|-----|-----|
|1|Yes|
|0|No|

**DefaultValue**: False



### <a name="BKMK_IsNthMonthly"></a> IsNthMonthly

|Property|Value|
|--------|-----|
|Description|Indicates whether the recurring appointment series should occur after every N months. Valid for monthly recurrence pattern only.|
|DisplayName|Nth Monthly|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|isnthmonthly|
|RequiredLevel|SystemRequired|
|Type|Boolean|

#### IsNthMonthly Options

|Value|Label|
|-----|-----|
|1|Yes|
|0|No|

**DefaultValue**: False



### <a name="BKMK_IsNthYearly"></a> IsNthYearly

|Property|Value|
|--------|-----|
|Description|Indicates whether the recurring appointment series should occur after every N years. Valid for yearly recurrence pattern only.|
|DisplayName|Nth Yearly|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|isnthyearly|
|RequiredLevel|SystemRequired|
|Type|Boolean|

#### IsNthYearly Options

|Value|Label|
|-----|-----|
|1|Yes|
|0|No|

**DefaultValue**: False



### <a name="BKMK_IsRegenerate"></a> IsRegenerate

|Property|Value|
|--------|-----|
|Description|For internal use only.|
|DisplayName|Regenerate|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|isregenerate|
|RequiredLevel|SystemRequired|
|Type|Boolean|

#### IsRegenerate Options

|Value|Label|
|-----|-----|
|1|Yes|
|0|No|

**DefaultValue**: False



### <a name="BKMK_IsWeekDayPattern"></a> IsWeekDayPattern

|Property|Value|
|--------|-----|
|Description|Indicates whether the weekly recurrence pattern is a daily weekday pattern. Valid for weekly recurrence pattern only.|
|DisplayName|Every Weekday|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|isweekdaypattern|
|RequiredLevel|SystemRequired|
|Type|Boolean|

#### IsWeekDayPattern Options

|Value|Label|
|-----|-----|
|1|Yes|
|0|No|

**DefaultValue**: False



### <a name="BKMK_IsWorkflowCreated"></a> IsWorkflowCreated

|Property|Value|
|--------|-----|
|Description|Indicates whether the recurring appointment series was created from a workflow rule.|
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



### <a name="BKMK_Location"></a> Location

|Property|Value|
|--------|-----|
|Description|Type the location where the recurring appointment will take place, such as a conference room or customer office.|
|DisplayName|Location|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|location|
|MaxLength|200|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_MonthOfYear"></a> MonthOfYear

|Property|Value|
|--------|-----|
|Description|Indicates the month of the year for the recurrence pattern.|
|DisplayName|Month Of Year|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|monthofyear|
|RequiredLevel|None|
|Type|Picklist|

#### MonthOfYear Options

|Value|Label|
|-----|-----|
|0|Invalid Month Of Year|
|1|January|
|2|February|
|3|March|
|4|April|
|5|May|
|6|June|
|7|July|
|8|August|
|9|September|
|10|October|
|11|November|
|12|December|



### <a name="BKMK_Occurrences"></a> Occurrences

|Property|Value|
|--------|-----|
|Description|Number of appointment occurrences in a recurring appointment series.|
|DisplayName|Occurrences|
|Format|None|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|occurrences|
|MaxValue|999|
|MinValue|1|
|RequiredLevel|None|
|Type|Integer|


### <a name="BKMK_OptionalAttendees"></a> OptionalAttendees

|Property|Value|
|--------|-----|
|Description|Enter the account, contact, lead, user, or other equipment resources that are not needed at the recurring appointment, but can optionally attend.|
|DisplayName|Optional Attendees|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|optionalattendees|
|RequiredLevel|None|
|Targets|account,contact,equipment,lead,systemuser|
|Type|PartyList|


### <a name="BKMK_Organizer"></a> Organizer

|Property|Value|
|--------|-----|
|Description|Enter the user who is in charge of coordinating or leading the recurring appointment to make sure the appointment is displayed in the user's My Activities view.|
|DisplayName|Organizer|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|organizer|
|RequiredLevel|None|
|Targets|systemuser|
|Type|PartyList|


### <a name="BKMK_OutlookOwnerApptId"></a> OutlookOwnerApptId

|Property|Value|
|--------|-----|
|Description|Unique identifier of the Microsoft Office Outlook recurring appointment series owner that correlates to the PR_OWNER_APPT_ID MAPI property.|
|DisplayName|Outlook Recurring Appointment Master Owner|
|Format|None|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|outlookownerapptid|
|MaxValue|2147483647|
|MinValue|-2147483648|
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


### <a name="BKMK_PatternEndDate"></a> PatternEndDate

|Property|Value|
|--------|-----|
|DateTimeBehavior|UserLocal|
|Description|End date of the recurrence range.|
|DisplayName|Recurrence Range End|
|Format|DateOnly|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|patternenddate|
|RequiredLevel|None|
|Type|DateTime|


### <a name="BKMK_PatternEndType"></a> PatternEndType

|Property|Value|
|--------|-----|
|Description|Select the type of end date for the recurring appointment, such as no end date or the number of occurrences.|
|DisplayName|Pattern End Type|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|patternendtype|
|RequiredLevel|SystemRequired|
|Type|Picklist|

#### PatternEndType Options

|Value|Label|
|-----|-----|
|1|No End Date|
|2|Occurrences|
|3|Pattern End Date|



### <a name="BKMK_PatternStartDate"></a> PatternStartDate

|Property|Value|
|--------|-----|
|DateTimeBehavior|UserLocal|
|Description|Start date of the recurrence range.|
|DisplayName|Recurrence Range Start|
|Format|DateOnly|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|patternstartdate|
|RequiredLevel|ApplicationRequired|
|Type|DateTime|


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


### <a name="BKMK_RecurrencePatternType"></a> RecurrencePatternType

|Property|Value|
|--------|-----|
|Description|Select the pattern type for the recurring appointment to indicate whether the appointment occurs daily, weekly, monthly, or yearly.|
|DisplayName|Recurrence Frequency|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|recurrencepatterntype|
|RequiredLevel|SystemRequired|
|Type|Picklist|

#### RecurrencePatternType Options

|Value|Label|
|-----|-----|
|0|Daily|
|1|Weekly|
|2|Monthly|
|3|Yearly|



### <a name="BKMK_RegardingObjectId"></a> RegardingObjectId

|Property|Value|
|--------|-----|
|Description|Choose the record that the recurring appointment series relates to.|
|DisplayName|Regarding|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|regardingobjectid|
|RequiredLevel|None|
|Targets|account,bookableresourcebooking,bookableresourcebookingheader,bulkoperation,campaign,campaignactivity,contact,contract,entitlement,entitlementtemplate,incident,invoice,knowledgearticle,knowledgebaserecord,lead,msdyn_agreement,msdyn_agreementbookingdate,msdyn_agreementbookingincident,msdyn_agreementbookingproduct,msdyn_agreementbookingservice,msdyn_agreementbookingservicetask,msdyn_agreementbookingsetup,msdyn_agreementinvoicedate,msdyn_agreementinvoiceproduct,msdyn_agreementinvoicesetup,msdyn_bookingalertstatus,msdyn_bookingrule,msdyn_bookingtimestamp,msdyn_customerasset,msdyn_fieldservicesetting,msdyn_incidenttypecharacteristic,msdyn_incidenttypeproduct,msdyn_incidenttypeservice,msdyn_inventoryadjustment,msdyn_inventoryadjustmentproduct,msdyn_inventoryjournal,msdyn_inventorytransfer,msdyn_payment,msdyn_paymentdetail,msdyn_paymentmethod,msdyn_paymentterm,msdyn_playbookinstance,msdyn_postalbum,msdyn_postalcode,msdyn_processnotes,msdyn_productinventory,msdyn_projectteam,msdyn_purchaseorder,msdyn_purchaseorderbill,msdyn_purchaseorderproduct,msdyn_purchaseorderreceipt,msdyn_purchaseorderreceiptproduct,msdyn_purchaseordersubstatus,msdyn_quotebookingincident,msdyn_quotebookingproduct,msdyn_quotebookingservice,msdyn_quotebookingservicetask,msdyn_resourceterritory,msdyn_rma,msdyn_rmaproduct,msdyn_rmareceipt,msdyn_rmareceiptproduct,msdyn_rmasubstatus,msdyn_rtv,msdyn_rtvproduct,msdyn_rtvsubstatus,msdyn_shipvia,msdyn_systemuserschedulersetting,msdyn_timegroup,msdyn_timegroupdetail,msdyn_timeoffrequest,msdyn_warehouse,msdyn_workorder,msdyn_workordercharacteristic,msdyn_workorderincident,msdyn_workorderproduct,msdyn_workorderresourcerestriction,msdyn_workorderservice,msdyn_workorderservicetask,opportunity,quote,salesorder,site|
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


### <a name="BKMK_RequiredAttendees"></a> RequiredAttendees

|Property|Value|
|--------|-----|
|Description|Enter the account, contact, lead, user, or other equipment resources that are required to attend the recurring appointment.|
|DisplayName|Required Attendees|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|requiredattendees|
|RequiredLevel|None|
|Targets|account,contact,equipment,lead,systemuser|
|Type|PartyList|


### <a name="BKMK_SeriesStatus"></a> SeriesStatus

|Property|Value|
|--------|-----|
|Description|Indicates whether the recurring appointment series is active or inactive.|
|DisplayName|Series Status|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|seriesstatus|
|RequiredLevel|None|
|Type|Boolean|

#### SeriesStatus Options

|Value|Label|
|-----|-----|
|1|Active|
|0|Inactive|

**DefaultValue**: True



### <a name="BKMK_ServiceId"></a> ServiceId

**Added by**: Service Solution

|Property|Value|
|--------|-----|
|Description|Unique identifier for an associated service.|
|DisplayName|Service|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|serviceid|
|RequiredLevel|None|
|Targets|service|
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


### <a name="BKMK_StartTime"></a> StartTime

|Property|Value|
|--------|-----|
|DateTimeBehavior|UserLocal|
|Description|Start time of the recurring appointment series.|
|DisplayName|Pattern Start Time|
|Format|DateAndTime|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|starttime|
|RequiredLevel|None|
|Type|DateTime|


### <a name="BKMK_StateCode"></a> StateCode

|Property|Value|
|--------|-----|
|Description|Shows whether the recurring appointment is open, scheduled, completed, or canceled. Completed and canceled appointments are read-only and can't be edited.|
|DisplayName|Status|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|statecode|
|RequiredLevel|SystemRequired|
|Type|State|

#### StateCode Options

|Value|Label|DefaultStatus|InvariantName|
|-----|-----|-------------|-------------|
|0|Open|1|Open|
|1|Completed|3|Completed|
|2|Canceled|4|Canceled|
|3|Scheduled|5|Scheduled|



### <a name="BKMK_StatusCode"></a> StatusCode

|Property|Value|
|--------|-----|
|Description|Select the recurring appointment's status.|
|DisplayName|Status Reason|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|statuscode|
|RequiredLevel|None|
|Type|Status|

#### StatusCode Options

|Value|Label|State|
|-----|-----|-----|
|1|Free|0|
|2|Tentative|0|
|3|Completed|1|
|4|Canceled|2|
|5|Busy|3|
|6|Out of Office|3|



### <a name="BKMK_Subcategory"></a> Subcategory

|Property|Value|
|--------|-----|
|Description|Type a subcategory to identify the recurring appointment type and relate the activity to a specific product, sales region, business group, or other function.|
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
|Description|Type a short description about the objective or primary topic of the recurring appointment.|
|DisplayName|Subject|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|subject|
|MaxLength|200|
|RequiredLevel|ApplicationRequired|
|Type|String|


### <a name="BKMK_SubscriptionId"></a> SubscriptionId

|Property|Value|
|--------|-----|
|Description|For internal use only.|
|DisplayName||
|IsValidForForm|False|
|IsValidForRead|False|
|IsValidForUpdate|False|
|LogicalName|subscriptionid|
|RequiredLevel|None|
|Type|Uniqueidentifier|


### <a name="BKMK_TimeZoneRuleVersionNumber"></a> TimeZoneRuleVersionNumber

|Property|Value|
|--------|-----|
|Description|For internal use only.|
|DisplayName||
|Format|None|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|timezoneruleversionnumber|
|MaxValue|2147483647|
|MinValue|-1|
|RequiredLevel|None|
|Type|Integer|


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
- [IsUnsafe](#BKMK_IsUnsafe)
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
- [SafeDescription](#BKMK_SafeDescription)
- [ScheduledEnd](#BKMK_ScheduledEnd)
- [ScheduledStart](#BKMK_ScheduledStart)
- [ServiceIdName](#BKMK_ServiceIdName)
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


### <a name="BKMK_DeletedExceptionsList"></a> DeletedExceptionsList

|Property|Value|
|--------|-----|
|Description|List of deleted instances of the recurring appointment series.|
|DisplayName|Deleted Appointments|
|Format|TextArea|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|deletedexceptionslist|
|MaxLength|1073741823|
|RequiredLevel|None|
|Type|Memo|


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


### <a name="BKMK_ExpansionStateCode"></a> ExpansionStateCode

|Property|Value|
|--------|-----|
|Description|State code to indicate whether the recurring appointment series is expanded fully or partially.|
|DisplayName|Expansion State Code|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|expansionstatecode|
|RequiredLevel|SystemRequired|
|Type|Picklist|

#### ExpansionStateCode Options

|Value|Label|
|-----|-----|
|0|Unexpanded|
|1|Partial|
|2|Full|



### <a name="BKMK_GroupId"></a> GroupId

|Property|Value|
|--------|-----|
|Description|Unique identifier of the recurring appointment series for which the recurrence information was updated. |
|DisplayName|Group Id|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|groupid|
|RequiredLevel|SystemRequired|
|Targets|recurringappointmentmaster|
|Type|Lookup|


### <a name="BKMK_InstanceTypeCode"></a> InstanceTypeCode

|Property|Value|
|--------|-----|
|Description|Type of instance of a recurring appointment series.|
|DisplayName|Appointment Type|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|instancetypecode|
|RequiredLevel|SystemRequired|
|Type|Picklist|

#### InstanceTypeCode Options

|Value|Label|
|-----|-----|
|0|Not Recurring|
|1|Recurring Master|
|2|Recurring Instance|
|3|Recurring Exception|
|4|Recurring Future Exception|



### <a name="BKMK_IsRegularActivity"></a> IsRegularActivity

|Property|Value|
|--------|-----|
|Description|Indicates whether the activity is a regular activity type or event type.|
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


### <a name="BKMK_LastExpandedInstanceDate"></a> LastExpandedInstanceDate

|Property|Value|
|--------|-----|
|DateTimeBehavior|UserLocal|
|Description|Date of last expanded instance of a recurring appointment series.|
|DisplayName|Last Expanded Instance Date|
|Format|DateAndTime|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|lastexpandedinstancedate|
|RequiredLevel|None|
|Type|DateTime|


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


### <a name="BKMK_NextExpansionInstanceDate"></a> NextExpansionInstanceDate

|Property|Value|
|--------|-----|
|DateTimeBehavior|UserLocal|
|Description|Date of the next expanded instance of a recurring appointment series.|
|DisplayName|Next Expanded Instance Date|
|Format|DateAndTime|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|nextexpansioninstancedate|
|RequiredLevel|None|
|Type|DateTime|


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
|Description|Unique identifier of the business unit that owns the recurring appointment series.|
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
|Description|Unique identifier of the team who owns the recurring appointment series.|
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
|Description|Unique identifier of the user who owns the recurring appointment series.|
|DisplayName|Owning User|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|owninguser|
|RequiredLevel|None|
|Targets|systemuser|
|Type|Lookup|


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


### <a name="BKMK_RuleId"></a> RuleId

|Property|Value|
|--------|-----|
|Description|Unique identifier of the recurrence rule that is associated with the recurring appointment series.|
|DisplayName|Recurrence Rule|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|ruleid|
|RequiredLevel|None|
|Targets|recurrencerule|
|Type|Lookup|


### <a name="BKMK_SafeDescription"></a> SafeDescription

|Property|Value|
|--------|-----|
|Description|Safe body text of the recurring appointment.|
|DisplayName|Safe Description|
|Format|Email|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|safedescription|
|MaxLength|1073741823|
|RequiredLevel|None|
|Type|Memo|


### <a name="BKMK_ScheduledEnd"></a> ScheduledEnd

|Property|Value|
|--------|-----|
|DateTimeBehavior|UserLocal|
|Description|Scheduled end time of the recurring appointment series.|
|DisplayName|End Time|
|Format|DateAndTime|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|scheduledend|
|RequiredLevel|None|
|Type|DateTime|


### <a name="BKMK_ScheduledStart"></a> ScheduledStart

|Property|Value|
|--------|-----|
|DateTimeBehavior|UserLocal|
|Description|Scheduled start time of the recurring appointment series.|
|DisplayName|Start Time|
|Format|DateAndTime|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|scheduledstart|
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
|Description||
|DisplayName||
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

- [recurringappointmentmaster_campaignresponse](#BKMK_recurringappointmentmaster_campaignresponse)
- [recurringappointmentmaster_PostFollows](#BKMK_recurringappointmentmaster_PostFollows)
- [RecurringAppointmentMaster_SyncErrors](#BKMK_RecurringAppointmentMaster_SyncErrors)
- [RecurringAppointmentMaster_DuplicateBaseRecord](#BKMK_RecurringAppointmentMaster_DuplicateBaseRecord)
- [recurringappointmentmaster_actioncard](#BKMK_recurringappointmentmaster_actioncard)
- [RecurringAppointmentMaster_BulkDeleteFailures](#BKMK_RecurringAppointmentMaster_BulkDeleteFailures)
- [RecurringAppointmentMaster_QueueItem](#BKMK_RecurringAppointmentMaster_QueueItem)
- [RecurringAppointmentMaster_AsyncOperations](#BKMK_RecurringAppointmentMaster_AsyncOperations)
- [recurringappointmentmaster_activity_parties](#BKMK_recurringappointmentmaster_activity_parties)
- [recurringappointmentmaster_connections2](#BKMK_recurringappointmentmaster_connections2)
- [recurringappointmentmaster_connections1](#BKMK_recurringappointmentmaster_connections1)
- [recurringappointmentmaster_principalobjectattributeaccess](#BKMK_recurringappointmentmaster_principalobjectattributeaccess)
- [recurringappointmentmaster_appointment](#BKMK_recurringappointmentmaster_appointment)
- [RecurringAppointmentMaster_ProcessSessions](#BKMK_RecurringAppointmentMaster_ProcessSessions)
- [RecurringAppointmentMaster_Annotation](#BKMK_RecurringAppointmentMaster_Annotation)
- [RecurringAppointmentMaster_DuplicateMatchingRecord](#BKMK_RecurringAppointmentMaster_DuplicateMatchingRecord)


### <a name="BKMK_recurringappointmentmaster_campaignresponse"></a> recurringappointmentmaster_campaignresponse

**Added by**: Marketing Solution

Same as campaignresponse entity [recurringappointmentmaster_campaignresponse](campaignresponse.md#BKMK_recurringappointmentmaster_campaignresponse) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|campaignresponse|
|ReferencingAttribute|originatingactivityid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|recurringappointmentmaster_campaignresponse|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_recurringappointmentmaster_PostFollows"></a> recurringappointmentmaster_PostFollows

Same as postfollow entity [recurringappointmentmaster_PostFollows](postfollow.md#BKMK_recurringappointmentmaster_PostFollows) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|postfollow|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|recurringappointmentmaster_PostFollows|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_RecurringAppointmentMaster_SyncErrors"></a> RecurringAppointmentMaster_SyncErrors

Same as syncerror entity [RecurringAppointmentMaster_SyncErrors](syncerror.md#BKMK_RecurringAppointmentMaster_SyncErrors) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|syncerror|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|RecurringAppointmentMaster_SyncErrors|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: Cascade<br />Reparent: Cascade<br />Share: Cascade<br />Unshare: Cascade|


### <a name="BKMK_RecurringAppointmentMaster_DuplicateBaseRecord"></a> RecurringAppointmentMaster_DuplicateBaseRecord

Same as duplicaterecord entity [RecurringAppointmentMaster_DuplicateBaseRecord](duplicaterecord.md#BKMK_RecurringAppointmentMaster_DuplicateBaseRecord) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|duplicaterecord|
|ReferencingAttribute|baserecordid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|RecurringAppointmentMaster_DuplicateBaseRecord|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_recurringappointmentmaster_actioncard"></a> recurringappointmentmaster_actioncard

Same as actioncard entity [recurringappointmentmaster_actioncard](actioncard.md#BKMK_recurringappointmentmaster_actioncard) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|actioncard|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|recurringappointmentmaster_actioncard|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_RecurringAppointmentMaster_BulkDeleteFailures"></a> RecurringAppointmentMaster_BulkDeleteFailures

Same as bulkdeletefailure entity [RecurringAppointmentMaster_BulkDeleteFailures](bulkdeletefailure.md#BKMK_RecurringAppointmentMaster_BulkDeleteFailures) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|bulkdeletefailure|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|RecurringAppointmentMaster_BulkDeleteFailures|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_RecurringAppointmentMaster_QueueItem"></a> RecurringAppointmentMaster_QueueItem

Same as queueitem entity [RecurringAppointmentMaster_QueueItem](queueitem.md#BKMK_RecurringAppointmentMaster_QueueItem) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|queueitem|
|ReferencingAttribute|objectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|RecurringAppointmentMaster_QueueItem|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_RecurringAppointmentMaster_AsyncOperations"></a> RecurringAppointmentMaster_AsyncOperations

Same as asyncoperation entity [RecurringAppointmentMaster_AsyncOperations](asyncoperation.md#BKMK_RecurringAppointmentMaster_AsyncOperations) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|asyncoperation|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|RecurringAppointmentMaster_AsyncOperations|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_recurringappointmentmaster_activity_parties"></a> recurringappointmentmaster_activity_parties

Same as activityparty entity [recurringappointmentmaster_activity_parties](activityparty.md#BKMK_recurringappointmentmaster_activity_parties) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|activityparty|
|ReferencingAttribute|activityid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|recurringappointmentmaster_activity_parties|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_recurringappointmentmaster_connections2"></a> recurringappointmentmaster_connections2

Same as connection entity [recurringappointmentmaster_connections2](connection.md#BKMK_recurringappointmentmaster_connections2) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|connection|
|ReferencingAttribute|record2id|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|recurringappointmentmaster_connections2|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: 100|
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_recurringappointmentmaster_connections1"></a> recurringappointmentmaster_connections1

Same as connection entity [recurringappointmentmaster_connections1](connection.md#BKMK_recurringappointmentmaster_connections1) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|connection|
|ReferencingAttribute|record1id|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|recurringappointmentmaster_connections1|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Details<br />Label: <br />Order: 100|
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_recurringappointmentmaster_principalobjectattributeaccess"></a> recurringappointmentmaster_principalobjectattributeaccess

Same as principalobjectattributeaccess entity [recurringappointmentmaster_principalobjectattributeaccess](principalobjectattributeaccess.md#BKMK_recurringappointmentmaster_principalobjectattributeaccess) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|principalobjectattributeaccess|
|ReferencingAttribute|objectid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|recurringappointmentmaster_principalobjectattributeaccess|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_recurringappointmentmaster_appointment"></a> recurringappointmentmaster_appointment

Same as appointment entity [recurringappointmentmaster_appointment](appointment.md#BKMK_recurringappointmentmaster_appointment) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|appointment|
|ReferencingAttribute|seriesid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|recurringappointmentmaster_appointment|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_RecurringAppointmentMaster_ProcessSessions"></a> RecurringAppointmentMaster_ProcessSessions

Same as processsession entity [RecurringAppointmentMaster_ProcessSessions](processsession.md#BKMK_RecurringAppointmentMaster_ProcessSessions) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|processsession|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|RecurringAppointmentMaster_ProcessSessions|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Details<br />Label: <br />Order: 110|
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_RecurringAppointmentMaster_Annotation"></a> RecurringAppointmentMaster_Annotation

Same as annotation entity [RecurringAppointmentMaster_Annotation](annotation.md#BKMK_RecurringAppointmentMaster_Annotation) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|annotation|
|ReferencingAttribute|objectid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|RecurringAppointmentMaster_Annotation|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: Cascade<br />Share: Cascade<br />Unshare: Cascade|


### <a name="BKMK_RecurringAppointmentMaster_DuplicateMatchingRecord"></a> RecurringAppointmentMaster_DuplicateMatchingRecord

Same as duplicaterecord entity [RecurringAppointmentMaster_DuplicateMatchingRecord](duplicaterecord.md#BKMK_RecurringAppointmentMaster_DuplicateMatchingRecord) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|duplicaterecord|
|ReferencingAttribute|duplicaterecordid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|RecurringAppointmentMaster_DuplicateMatchingRecord|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|

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
- [msdyn_playbookinstance_RecurringAppointmentMasters](#BKMK_msdyn_playbookinstance_RecurringAppointmentMasters)
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

**Added by**: Lead Management Solution

See lead Entity [Lead_RecurringAppointmentMasters](lead.md#BKMK_Lead_RecurringAppointmentMasters) One-To-Many relationship.

### <a name="BKMK_bookableresourcebooking_RecurringAppointmentMasters"></a> bookableresourcebooking_RecurringAppointmentMasters

**Added by**: Scheduling Solution

See bookableresourcebooking Entity [bookableresourcebooking_RecurringAppointmentMasters](bookableresourcebooking.md#BKMK_bookableresourcebooking_RecurringAppointmentMasters) One-To-Many relationship.

### <a name="BKMK_bookableresourcebookingheader_RecurringAppointmentMasters"></a> bookableresourcebookingheader_RecurringAppointmentMasters

**Added by**: Scheduling Solution

See bookableresourcebookingheader Entity [bookableresourcebookingheader_RecurringAppointmentMasters](bookableresourcebookingheader.md#BKMK_bookableresourcebookingheader_RecurringAppointmentMasters) One-To-Many relationship.

### <a name="BKMK_BulkOperation_RecurringAppointmentMaster"></a> BulkOperation_RecurringAppointmentMaster

**Added by**: Marketing Solution

See bulkoperation Entity [BulkOperation_RecurringAppointmentMaster](bulkoperation.md#BKMK_BulkOperation_RecurringAppointmentMaster) One-To-Many relationship.

### <a name="BKMK_Campaign_RecurringAppointmentMasters"></a> Campaign_RecurringAppointmentMasters

**Added by**: Marketing Solution

See campaign Entity [Campaign_RecurringAppointmentMasters](campaign.md#BKMK_Campaign_RecurringAppointmentMasters) One-To-Many relationship.

### <a name="BKMK_CampaignActivity_RecurringAppointmentMasters"></a> CampaignActivity_RecurringAppointmentMasters

**Added by**: Marketing Solution

See campaignactivity Entity [CampaignActivity_RecurringAppointmentMasters](campaignactivity.md#BKMK_CampaignActivity_RecurringAppointmentMasters) One-To-Many relationship.

### <a name="BKMK_Contract_RecurringAppointmentMasters"></a> Contract_RecurringAppointmentMasters

**Added by**: Service Solution

See contract Entity [Contract_RecurringAppointmentMasters](contract.md#BKMK_Contract_RecurringAppointmentMasters) One-To-Many relationship.

### <a name="BKMK_entitlement_RecurringAppointmentMasters"></a> entitlement_RecurringAppointmentMasters

**Added by**: Service Solution

See entitlement Entity [entitlement_RecurringAppointmentMasters](entitlement.md#BKMK_entitlement_RecurringAppointmentMasters) One-To-Many relationship.

### <a name="BKMK_entitlementtemplate_RecurringAppointmentMasters"></a> entitlementtemplate_RecurringAppointmentMasters

**Added by**: Service Solution

See entitlementtemplate Entity [entitlementtemplate_RecurringAppointmentMasters](entitlementtemplate.md#BKMK_entitlementtemplate_RecurringAppointmentMasters) One-To-Many relationship.

### <a name="BKMK_Incident_RecurringAppointmentMasters"></a> Incident_RecurringAppointmentMasters

**Added by**: Service Solution

See incident Entity [Incident_RecurringAppointmentMasters](incident.md#BKMK_Incident_RecurringAppointmentMasters) One-To-Many relationship.

### <a name="BKMK_site_RecurringAppointmentMasters"></a> site_RecurringAppointmentMasters

**Added by**: Service Solution

See site Entity [site_RecurringAppointmentMasters](site.md#BKMK_site_RecurringAppointmentMasters) One-To-Many relationship.

### <a name="BKMK_service_recurringappointmentmasters"></a> service_recurringappointmentmasters

**Added by**: Service Solution

See service Entity [service_recurringappointmentmasters](service.md#BKMK_service_recurringappointmentmasters) One-To-Many relationship.

### <a name="BKMK_msdyn_playbookinstance_RecurringAppointmentMasters"></a> msdyn_playbookinstance_RecurringAppointmentMasters

**Added by**: Playbook Solution

See msdyn_playbookinstance Entity [msdyn_playbookinstance_RecurringAppointmentMasters](msdyn_playbookinstance.md#BKMK_msdyn_playbookinstance_RecurringAppointmentMasters) One-To-Many relationship.

### <a name="BKMK_Invoice_RecurringAppointmentMasters"></a> Invoice_RecurringAppointmentMasters

**Added by**: Sales Solution

See invoice Entity [Invoice_RecurringAppointmentMasters](invoice.md#BKMK_Invoice_RecurringAppointmentMasters) One-To-Many relationship.

### <a name="BKMK_Opportunity_RecurringAppointmentMasters"></a> Opportunity_RecurringAppointmentMasters

**Added by**: Sales Solution

See opportunity Entity [Opportunity_RecurringAppointmentMasters](opportunity.md#BKMK_Opportunity_RecurringAppointmentMasters) One-To-Many relationship.

### <a name="BKMK_Quote_RecurringAppointmentMasters"></a> Quote_RecurringAppointmentMasters

**Added by**: Sales Solution

See quote Entity [Quote_RecurringAppointmentMasters](quote.md#BKMK_Quote_RecurringAppointmentMasters) One-To-Many relationship.

### <a name="BKMK_SalesOrder_RecurringAppointmentMasters"></a> SalesOrder_RecurringAppointmentMasters

**Added by**: Sales Solution

See salesorder Entity [SalesOrder_RecurringAppointmentMasters](salesorder.md#BKMK_SalesOrder_RecurringAppointmentMasters) One-To-Many relationship.

### <a name="BKMK_msdyn_postalbum_RecurringAppointmentMasters"></a> msdyn_postalbum_RecurringAppointmentMasters

**Added by**: Activity Feeds Solution

See msdyn_postalbum Entity [msdyn_postalbum_RecurringAppointmentMasters](msdyn_postalbum.md#BKMK_msdyn_postalbum_RecurringAppointmentMasters) One-To-Many relationship.

### <a name="BKMK_msdyn_bookingalertstatus_RecurringAppointmentMasters"></a> msdyn_bookingalertstatus_RecurringAppointmentMasters

**Added by**: Universal Resource Scheduling Solution

See msdyn_bookingalertstatus Entity [msdyn_bookingalertstatus_RecurringAppointmentMasters](msdyn_bookingalertstatus.md#BKMK_msdyn_bookingalertstatus_RecurringAppointmentMasters) One-To-Many relationship.

### <a name="BKMK_msdyn_bookingrule_RecurringAppointmentMasters"></a> msdyn_bookingrule_RecurringAppointmentMasters

**Added by**: Universal Resource Scheduling Solution

See msdyn_bookingrule Entity [msdyn_bookingrule_RecurringAppointmentMasters](msdyn_bookingrule.md#BKMK_msdyn_bookingrule_RecurringAppointmentMasters) One-To-Many relationship.

### <a name="BKMK_msdyn_resourceterritory_RecurringAppointmentMasters"></a> msdyn_resourceterritory_RecurringAppointmentMasters

**Added by**: Universal Resource Scheduling Solution

See msdyn_resourceterritory Entity [msdyn_resourceterritory_RecurringAppointmentMasters](msdyn_resourceterritory.md#BKMK_msdyn_resourceterritory_RecurringAppointmentMasters) One-To-Many relationship.

### <a name="BKMK_msdyn_systemuserschedulersetting_RecurringAppointmentMasters"></a> msdyn_systemuserschedulersetting_RecurringAppointmentMasters

**Added by**: Universal Resource Scheduling Solution

See msdyn_systemuserschedulersetting Entity [msdyn_systemuserschedulersetting_RecurringAppointmentMasters](msdyn_systemuserschedulersetting.md#BKMK_msdyn_systemuserschedulersetting_RecurringAppointmentMasters) One-To-Many relationship.

### <a name="BKMK_msdyn_timegroup_RecurringAppointmentMasters"></a> msdyn_timegroup_RecurringAppointmentMasters

**Added by**: Universal Resource Scheduling Solution

See msdyn_timegroup Entity [msdyn_timegroup_RecurringAppointmentMasters](msdyn_timegroup.md#BKMK_msdyn_timegroup_RecurringAppointmentMasters) One-To-Many relationship.

### <a name="BKMK_msdyn_timegroupdetail_RecurringAppointmentMasters"></a> msdyn_timegroupdetail_RecurringAppointmentMasters

**Added by**: Universal Resource Scheduling Solution

See msdyn_timegroupdetail Entity [msdyn_timegroupdetail_RecurringAppointmentMasters](msdyn_timegroupdetail.md#BKMK_msdyn_timegroupdetail_RecurringAppointmentMasters) One-To-Many relationship.

### <a name="BKMK_msdyn_processnotes_RecurringAppointmentMasters"></a> msdyn_processnotes_RecurringAppointmentMasters

**Added by**: Project Service Automation Solution

See msdyn_processnotes Entity [msdyn_processnotes_RecurringAppointmentMasters](msdyn_processnotes.md#BKMK_msdyn_processnotes_RecurringAppointmentMasters) One-To-Many relationship.

### <a name="BKMK_msdyn_projectteam_RecurringAppointmentMasters"></a> msdyn_projectteam_RecurringAppointmentMasters

**Added by**: Project Service Automation Solution

See msdyn_projectteam Entity [msdyn_projectteam_RecurringAppointmentMasters](msdyn_projectteam.md#BKMK_msdyn_projectteam_RecurringAppointmentMasters) One-To-Many relationship.

### <a name="BKMK_msdyn_agreement_RecurringAppointmentMasters"></a> msdyn_agreement_RecurringAppointmentMasters

**Added by**: Field Service Solution

See msdyn_agreement Entity [msdyn_agreement_RecurringAppointmentMasters](msdyn_agreement.md#BKMK_msdyn_agreement_RecurringAppointmentMasters) One-To-Many relationship.

### <a name="BKMK_msdyn_agreementbookingdate_RecurringAppointmentMasters"></a> msdyn_agreementbookingdate_RecurringAppointmentMasters

**Added by**: Field Service Solution

See msdyn_agreementbookingdate Entity [msdyn_agreementbookingdate_RecurringAppointmentMasters](msdyn_agreementbookingdate.md#BKMK_msdyn_agreementbookingdate_RecurringAppointmentMasters) One-To-Many relationship.

### <a name="BKMK_msdyn_agreementbookingincident_RecurringAppointmentMasters"></a> msdyn_agreementbookingincident_RecurringAppointmentMasters

**Added by**: Field Service Solution

See msdyn_agreementbookingincident Entity [msdyn_agreementbookingincident_RecurringAppointmentMasters](msdyn_agreementbookingincident.md#BKMK_msdyn_agreementbookingincident_RecurringAppointmentMasters) One-To-Many relationship.

### <a name="BKMK_msdyn_agreementbookingproduct_RecurringAppointmentMasters"></a> msdyn_agreementbookingproduct_RecurringAppointmentMasters

**Added by**: Field Service Solution

See msdyn_agreementbookingproduct Entity [msdyn_agreementbookingproduct_RecurringAppointmentMasters](msdyn_agreementbookingproduct.md#BKMK_msdyn_agreementbookingproduct_RecurringAppointmentMasters) One-To-Many relationship.

### <a name="BKMK_msdyn_agreementbookingservice_RecurringAppointmentMasters"></a> msdyn_agreementbookingservice_RecurringAppointmentMasters

**Added by**: Field Service Solution

See msdyn_agreementbookingservice Entity [msdyn_agreementbookingservice_RecurringAppointmentMasters](msdyn_agreementbookingservice.md#BKMK_msdyn_agreementbookingservice_RecurringAppointmentMasters) One-To-Many relationship.

### <a name="BKMK_msdyn_agreementbookingservicetask_RecurringAppointmentMasters"></a> msdyn_agreementbookingservicetask_RecurringAppointmentMasters

**Added by**: Field Service Solution

See msdyn_agreementbookingservicetask Entity [msdyn_agreementbookingservicetask_RecurringAppointmentMasters](msdyn_agreementbookingservicetask.md#BKMK_msdyn_agreementbookingservicetask_RecurringAppointmentMasters) One-To-Many relationship.

### <a name="BKMK_msdyn_agreementbookingsetup_RecurringAppointmentMasters"></a> msdyn_agreementbookingsetup_RecurringAppointmentMasters

**Added by**: Field Service Solution

See msdyn_agreementbookingsetup Entity [msdyn_agreementbookingsetup_RecurringAppointmentMasters](msdyn_agreementbookingsetup.md#BKMK_msdyn_agreementbookingsetup_RecurringAppointmentMasters) One-To-Many relationship.

### <a name="BKMK_msdyn_agreementinvoicedate_RecurringAppointmentMasters"></a> msdyn_agreementinvoicedate_RecurringAppointmentMasters

**Added by**: Field Service Solution

See msdyn_agreementinvoicedate Entity [msdyn_agreementinvoicedate_RecurringAppointmentMasters](msdyn_agreementinvoicedate.md#BKMK_msdyn_agreementinvoicedate_RecurringAppointmentMasters) One-To-Many relationship.

### <a name="BKMK_msdyn_agreementinvoiceproduct_RecurringAppointmentMasters"></a> msdyn_agreementinvoiceproduct_RecurringAppointmentMasters

**Added by**: Field Service Solution

See msdyn_agreementinvoiceproduct Entity [msdyn_agreementinvoiceproduct_RecurringAppointmentMasters](msdyn_agreementinvoiceproduct.md#BKMK_msdyn_agreementinvoiceproduct_RecurringAppointmentMasters) One-To-Many relationship.

### <a name="BKMK_msdyn_agreementinvoicesetup_RecurringAppointmentMasters"></a> msdyn_agreementinvoicesetup_RecurringAppointmentMasters

**Added by**: Field Service Solution

See msdyn_agreementinvoicesetup Entity [msdyn_agreementinvoicesetup_RecurringAppointmentMasters](msdyn_agreementinvoicesetup.md#BKMK_msdyn_agreementinvoicesetup_RecurringAppointmentMasters) One-To-Many relationship.

### <a name="BKMK_msdyn_bookingtimestamp_RecurringAppointmentMasters"></a> msdyn_bookingtimestamp_RecurringAppointmentMasters

**Added by**: Field Service Solution

See msdyn_bookingtimestamp Entity [msdyn_bookingtimestamp_RecurringAppointmentMasters](msdyn_bookingtimestamp.md#BKMK_msdyn_bookingtimestamp_RecurringAppointmentMasters) One-To-Many relationship.

### <a name="BKMK_msdyn_customerasset_RecurringAppointmentMasters"></a> msdyn_customerasset_RecurringAppointmentMasters

**Added by**: Field Service Solution

See msdyn_customerasset Entity [msdyn_customerasset_RecurringAppointmentMasters](msdyn_customerasset.md#BKMK_msdyn_customerasset_RecurringAppointmentMasters) One-To-Many relationship.

### <a name="BKMK_msdyn_fieldservicesetting_RecurringAppointmentMasters"></a> msdyn_fieldservicesetting_RecurringAppointmentMasters

**Added by**: Field Service Solution

See msdyn_fieldservicesetting Entity [msdyn_fieldservicesetting_RecurringAppointmentMasters](msdyn_fieldservicesetting.md#BKMK_msdyn_fieldservicesetting_RecurringAppointmentMasters) One-To-Many relationship.

### <a name="BKMK_msdyn_incidenttypecharacteristic_RecurringAppointmentMasters"></a> msdyn_incidenttypecharacteristic_RecurringAppointmentMasters

**Added by**: Field Service Solution

See msdyn_incidenttypecharacteristic Entity [msdyn_incidenttypecharacteristic_RecurringAppointmentMasters](msdyn_incidenttypecharacteristic.md#BKMK_msdyn_incidenttypecharacteristic_RecurringAppointmentMasters) One-To-Many relationship.

### <a name="BKMK_msdyn_incidenttypeproduct_RecurringAppointmentMasters"></a> msdyn_incidenttypeproduct_RecurringAppointmentMasters

**Added by**: Field Service Solution

See msdyn_incidenttypeproduct Entity [msdyn_incidenttypeproduct_RecurringAppointmentMasters](msdyn_incidenttypeproduct.md#BKMK_msdyn_incidenttypeproduct_RecurringAppointmentMasters) One-To-Many relationship.

### <a name="BKMK_msdyn_incidenttypeservice_RecurringAppointmentMasters"></a> msdyn_incidenttypeservice_RecurringAppointmentMasters

**Added by**: Field Service Solution

See msdyn_incidenttypeservice Entity [msdyn_incidenttypeservice_RecurringAppointmentMasters](msdyn_incidenttypeservice.md#BKMK_msdyn_incidenttypeservice_RecurringAppointmentMasters) One-To-Many relationship.

### <a name="BKMK_msdyn_inventoryadjustment_RecurringAppointmentMasters"></a> msdyn_inventoryadjustment_RecurringAppointmentMasters

**Added by**: Field Service Solution

See msdyn_inventoryadjustment Entity [msdyn_inventoryadjustment_RecurringAppointmentMasters](msdyn_inventoryadjustment.md#BKMK_msdyn_inventoryadjustment_RecurringAppointmentMasters) One-To-Many relationship.

### <a name="BKMK_msdyn_inventoryadjustmentproduct_RecurringAppointmentMasters"></a> msdyn_inventoryadjustmentproduct_RecurringAppointmentMasters

**Added by**: Field Service Solution

See msdyn_inventoryadjustmentproduct Entity [msdyn_inventoryadjustmentproduct_RecurringAppointmentMasters](msdyn_inventoryadjustmentproduct.md#BKMK_msdyn_inventoryadjustmentproduct_RecurringAppointmentMasters) One-To-Many relationship.

### <a name="BKMK_msdyn_inventoryjournal_RecurringAppointmentMasters"></a> msdyn_inventoryjournal_RecurringAppointmentMasters

**Added by**: Field Service Solution

See msdyn_inventoryjournal Entity [msdyn_inventoryjournal_RecurringAppointmentMasters](msdyn_inventoryjournal.md#BKMK_msdyn_inventoryjournal_RecurringAppointmentMasters) One-To-Many relationship.

### <a name="BKMK_msdyn_inventorytransfer_RecurringAppointmentMasters"></a> msdyn_inventorytransfer_RecurringAppointmentMasters

**Added by**: Field Service Solution

See msdyn_inventorytransfer Entity [msdyn_inventorytransfer_RecurringAppointmentMasters](msdyn_inventorytransfer.md#BKMK_msdyn_inventorytransfer_RecurringAppointmentMasters) One-To-Many relationship.

### <a name="BKMK_msdyn_payment_RecurringAppointmentMasters"></a> msdyn_payment_RecurringAppointmentMasters

**Added by**: Field Service Solution

See msdyn_payment Entity [msdyn_payment_RecurringAppointmentMasters](msdyn_payment.md#BKMK_msdyn_payment_RecurringAppointmentMasters) One-To-Many relationship.

### <a name="BKMK_msdyn_paymentdetail_RecurringAppointmentMasters"></a> msdyn_paymentdetail_RecurringAppointmentMasters

**Added by**: Field Service Solution

See msdyn_paymentdetail Entity [msdyn_paymentdetail_RecurringAppointmentMasters](msdyn_paymentdetail.md#BKMK_msdyn_paymentdetail_RecurringAppointmentMasters) One-To-Many relationship.

### <a name="BKMK_msdyn_paymentmethod_RecurringAppointmentMasters"></a> msdyn_paymentmethod_RecurringAppointmentMasters

**Added by**: Field Service Solution

See msdyn_paymentmethod Entity [msdyn_paymentmethod_RecurringAppointmentMasters](msdyn_paymentmethod.md#BKMK_msdyn_paymentmethod_RecurringAppointmentMasters) One-To-Many relationship.

### <a name="BKMK_msdyn_paymentterm_RecurringAppointmentMasters"></a> msdyn_paymentterm_RecurringAppointmentMasters

**Added by**: Field Service Solution

See msdyn_paymentterm Entity [msdyn_paymentterm_RecurringAppointmentMasters](msdyn_paymentterm.md#BKMK_msdyn_paymentterm_RecurringAppointmentMasters) One-To-Many relationship.

### <a name="BKMK_msdyn_postalcode_RecurringAppointmentMasters"></a> msdyn_postalcode_RecurringAppointmentMasters

**Added by**: Field Service Solution

See msdyn_postalcode Entity [msdyn_postalcode_RecurringAppointmentMasters](msdyn_postalcode.md#BKMK_msdyn_postalcode_RecurringAppointmentMasters) One-To-Many relationship.

### <a name="BKMK_msdyn_productinventory_RecurringAppointmentMasters"></a> msdyn_productinventory_RecurringAppointmentMasters

**Added by**: Field Service Solution

See msdyn_productinventory Entity [msdyn_productinventory_RecurringAppointmentMasters](msdyn_productinventory.md#BKMK_msdyn_productinventory_RecurringAppointmentMasters) One-To-Many relationship.

### <a name="BKMK_msdyn_purchaseorder_RecurringAppointmentMasters"></a> msdyn_purchaseorder_RecurringAppointmentMasters

**Added by**: Field Service Solution

See msdyn_purchaseorder Entity [msdyn_purchaseorder_RecurringAppointmentMasters](msdyn_purchaseorder.md#BKMK_msdyn_purchaseorder_RecurringAppointmentMasters) One-To-Many relationship.

### <a name="BKMK_msdyn_purchaseorderbill_RecurringAppointmentMasters"></a> msdyn_purchaseorderbill_RecurringAppointmentMasters

**Added by**: Field Service Solution

See msdyn_purchaseorderbill Entity [msdyn_purchaseorderbill_RecurringAppointmentMasters](msdyn_purchaseorderbill.md#BKMK_msdyn_purchaseorderbill_RecurringAppointmentMasters) One-To-Many relationship.

### <a name="BKMK_msdyn_purchaseorderproduct_RecurringAppointmentMasters"></a> msdyn_purchaseorderproduct_RecurringAppointmentMasters

**Added by**: Field Service Solution

See msdyn_purchaseorderproduct Entity [msdyn_purchaseorderproduct_RecurringAppointmentMasters](msdyn_purchaseorderproduct.md#BKMK_msdyn_purchaseorderproduct_RecurringAppointmentMasters) One-To-Many relationship.

### <a name="BKMK_msdyn_purchaseorderreceipt_RecurringAppointmentMasters"></a> msdyn_purchaseorderreceipt_RecurringAppointmentMasters

**Added by**: Field Service Solution

See msdyn_purchaseorderreceipt Entity [msdyn_purchaseorderreceipt_RecurringAppointmentMasters](msdyn_purchaseorderreceipt.md#BKMK_msdyn_purchaseorderreceipt_RecurringAppointmentMasters) One-To-Many relationship.

### <a name="BKMK_msdyn_purchaseorderreceiptproduct_RecurringAppointmentMasters"></a> msdyn_purchaseorderreceiptproduct_RecurringAppointmentMasters

**Added by**: Field Service Solution

See msdyn_purchaseorderreceiptproduct Entity [msdyn_purchaseorderreceiptproduct_RecurringAppointmentMasters](msdyn_purchaseorderreceiptproduct.md#BKMK_msdyn_purchaseorderreceiptproduct_RecurringAppointmentMasters) One-To-Many relationship.

### <a name="BKMK_msdyn_purchaseordersubstatus_RecurringAppointmentMasters"></a> msdyn_purchaseordersubstatus_RecurringAppointmentMasters

**Added by**: Field Service Solution

See msdyn_purchaseordersubstatus Entity [msdyn_purchaseordersubstatus_RecurringAppointmentMasters](msdyn_purchaseordersubstatus.md#BKMK_msdyn_purchaseordersubstatus_RecurringAppointmentMasters) One-To-Many relationship.

### <a name="BKMK_msdyn_quotebookingincident_RecurringAppointmentMasters"></a> msdyn_quotebookingincident_RecurringAppointmentMasters

**Added by**: Field Service Solution

See msdyn_quotebookingincident Entity [msdyn_quotebookingincident_RecurringAppointmentMasters](msdyn_quotebookingincident.md#BKMK_msdyn_quotebookingincident_RecurringAppointmentMasters) One-To-Many relationship.

### <a name="BKMK_msdyn_quotebookingproduct_RecurringAppointmentMasters"></a> msdyn_quotebookingproduct_RecurringAppointmentMasters

**Added by**: Field Service Solution

See msdyn_quotebookingproduct Entity [msdyn_quotebookingproduct_RecurringAppointmentMasters](msdyn_quotebookingproduct.md#BKMK_msdyn_quotebookingproduct_RecurringAppointmentMasters) One-To-Many relationship.

### <a name="BKMK_msdyn_quotebookingservice_RecurringAppointmentMasters"></a> msdyn_quotebookingservice_RecurringAppointmentMasters

**Added by**: Field Service Solution

See msdyn_quotebookingservice Entity [msdyn_quotebookingservice_RecurringAppointmentMasters](msdyn_quotebookingservice.md#BKMK_msdyn_quotebookingservice_RecurringAppointmentMasters) One-To-Many relationship.

### <a name="BKMK_msdyn_quotebookingservicetask_RecurringAppointmentMasters"></a> msdyn_quotebookingservicetask_RecurringAppointmentMasters

**Added by**: Field Service Solution

See msdyn_quotebookingservicetask Entity [msdyn_quotebookingservicetask_RecurringAppointmentMasters](msdyn_quotebookingservicetask.md#BKMK_msdyn_quotebookingservicetask_RecurringAppointmentMasters) One-To-Many relationship.

### <a name="BKMK_msdyn_rma_RecurringAppointmentMasters"></a> msdyn_rma_RecurringAppointmentMasters

**Added by**: Field Service Solution

See msdyn_rma Entity [msdyn_rma_RecurringAppointmentMasters](msdyn_rma.md#BKMK_msdyn_rma_RecurringAppointmentMasters) One-To-Many relationship.

### <a name="BKMK_msdyn_rmaproduct_RecurringAppointmentMasters"></a> msdyn_rmaproduct_RecurringAppointmentMasters

**Added by**: Field Service Solution

See msdyn_rmaproduct Entity [msdyn_rmaproduct_RecurringAppointmentMasters](msdyn_rmaproduct.md#BKMK_msdyn_rmaproduct_RecurringAppointmentMasters) One-To-Many relationship.

### <a name="BKMK_msdyn_rmareceipt_RecurringAppointmentMasters"></a> msdyn_rmareceipt_RecurringAppointmentMasters

**Added by**: Field Service Solution

See msdyn_rmareceipt Entity [msdyn_rmareceipt_RecurringAppointmentMasters](msdyn_rmareceipt.md#BKMK_msdyn_rmareceipt_RecurringAppointmentMasters) One-To-Many relationship.

### <a name="BKMK_msdyn_rmareceiptproduct_RecurringAppointmentMasters"></a> msdyn_rmareceiptproduct_RecurringAppointmentMasters

**Added by**: Field Service Solution

See msdyn_rmareceiptproduct Entity [msdyn_rmareceiptproduct_RecurringAppointmentMasters](msdyn_rmareceiptproduct.md#BKMK_msdyn_rmareceiptproduct_RecurringAppointmentMasters) One-To-Many relationship.

### <a name="BKMK_msdyn_rmasubstatus_RecurringAppointmentMasters"></a> msdyn_rmasubstatus_RecurringAppointmentMasters

**Added by**: Field Service Solution

See msdyn_rmasubstatus Entity [msdyn_rmasubstatus_RecurringAppointmentMasters](msdyn_rmasubstatus.md#BKMK_msdyn_rmasubstatus_RecurringAppointmentMasters) One-To-Many relationship.

### <a name="BKMK_msdyn_rtv_RecurringAppointmentMasters"></a> msdyn_rtv_RecurringAppointmentMasters

**Added by**: Field Service Solution

See msdyn_rtv Entity [msdyn_rtv_RecurringAppointmentMasters](msdyn_rtv.md#BKMK_msdyn_rtv_RecurringAppointmentMasters) One-To-Many relationship.

### <a name="BKMK_msdyn_rtvproduct_RecurringAppointmentMasters"></a> msdyn_rtvproduct_RecurringAppointmentMasters

**Added by**: Field Service Solution

See msdyn_rtvproduct Entity [msdyn_rtvproduct_RecurringAppointmentMasters](msdyn_rtvproduct.md#BKMK_msdyn_rtvproduct_RecurringAppointmentMasters) One-To-Many relationship.

### <a name="BKMK_msdyn_rtvsubstatus_RecurringAppointmentMasters"></a> msdyn_rtvsubstatus_RecurringAppointmentMasters

**Added by**: Field Service Solution

See msdyn_rtvsubstatus Entity [msdyn_rtvsubstatus_RecurringAppointmentMasters](msdyn_rtvsubstatus.md#BKMK_msdyn_rtvsubstatus_RecurringAppointmentMasters) One-To-Many relationship.

### <a name="BKMK_msdyn_shipvia_RecurringAppointmentMasters"></a> msdyn_shipvia_RecurringAppointmentMasters

**Added by**: Field Service Solution

See msdyn_shipvia Entity [msdyn_shipvia_RecurringAppointmentMasters](msdyn_shipvia.md#BKMK_msdyn_shipvia_RecurringAppointmentMasters) One-To-Many relationship.

### <a name="BKMK_msdyn_timeoffrequest_RecurringAppointmentMasters"></a> msdyn_timeoffrequest_RecurringAppointmentMasters

**Added by**: Field Service Solution

See msdyn_timeoffrequest Entity [msdyn_timeoffrequest_RecurringAppointmentMasters](msdyn_timeoffrequest.md#BKMK_msdyn_timeoffrequest_RecurringAppointmentMasters) One-To-Many relationship.

### <a name="BKMK_msdyn_warehouse_RecurringAppointmentMasters"></a> msdyn_warehouse_RecurringAppointmentMasters

**Added by**: Field Service Solution

See msdyn_warehouse Entity [msdyn_warehouse_RecurringAppointmentMasters](msdyn_warehouse.md#BKMK_msdyn_warehouse_RecurringAppointmentMasters) One-To-Many relationship.

### <a name="BKMK_msdyn_workorder_RecurringAppointmentMasters"></a> msdyn_workorder_RecurringAppointmentMasters

**Added by**: Field Service Solution

See msdyn_workorder Entity [msdyn_workorder_RecurringAppointmentMasters](msdyn_workorder.md#BKMK_msdyn_workorder_RecurringAppointmentMasters) One-To-Many relationship.

### <a name="BKMK_msdyn_workordercharacteristic_RecurringAppointmentMasters"></a> msdyn_workordercharacteristic_RecurringAppointmentMasters

**Added by**: Field Service Solution

See msdyn_workordercharacteristic Entity [msdyn_workordercharacteristic_RecurringAppointmentMasters](msdyn_workordercharacteristic.md#BKMK_msdyn_workordercharacteristic_RecurringAppointmentMasters) One-To-Many relationship.

### <a name="BKMK_msdyn_workorderincident_RecurringAppointmentMasters"></a> msdyn_workorderincident_RecurringAppointmentMasters

**Added by**: Field Service Solution

See msdyn_workorderincident Entity [msdyn_workorderincident_RecurringAppointmentMasters](msdyn_workorderincident.md#BKMK_msdyn_workorderincident_RecurringAppointmentMasters) One-To-Many relationship.

### <a name="BKMK_msdyn_workorderproduct_RecurringAppointmentMasters"></a> msdyn_workorderproduct_RecurringAppointmentMasters

**Added by**: Field Service Solution

See msdyn_workorderproduct Entity [msdyn_workorderproduct_RecurringAppointmentMasters](msdyn_workorderproduct.md#BKMK_msdyn_workorderproduct_RecurringAppointmentMasters) One-To-Many relationship.

### <a name="BKMK_msdyn_workorderresourcerestriction_RecurringAppointmentMasters"></a> msdyn_workorderresourcerestriction_RecurringAppointmentMasters

**Added by**: Field Service Solution

See msdyn_workorderresourcerestriction Entity [msdyn_workorderresourcerestriction_RecurringAppointmentMasters](msdyn_workorderresourcerestriction.md#BKMK_msdyn_workorderresourcerestriction_RecurringAppointmentMasters) One-To-Many relationship.

### <a name="BKMK_msdyn_workorderservice_RecurringAppointmentMasters"></a> msdyn_workorderservice_RecurringAppointmentMasters

**Added by**: Field Service Solution

See msdyn_workorderservice Entity [msdyn_workorderservice_RecurringAppointmentMasters](msdyn_workorderservice.md#BKMK_msdyn_workorderservice_RecurringAppointmentMasters) One-To-Many relationship.

### <a name="BKMK_msdyn_workorderservicetask_RecurringAppointmentMasters"></a> msdyn_workorderservicetask_RecurringAppointmentMasters

**Added by**: Field Service Solution

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

### See also

[About the Entity Reference](../about-entity-reference.md)<br />
[Programming reference for Dynamics 365 Customer Engagement](../programming-reference.md)<br />
[Web API Reference](/dynamics365/customer-engagement/web-api/about)<br />
<xref href="Microsoft.Dynamics.CRM.recurringappointmentmaster?text=recurringappointmentmaster EntityType" />

[!INCLUDE[footer-include](../../../../includes/footer-banner.md)]