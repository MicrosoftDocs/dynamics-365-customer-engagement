---
title: "Appointment Entity Reference (Developer Guide for Dynamics 365 Customer Engagement)| MicrosoftDocs"
description: "Includes schema information and supported messages for the Appointment entity."
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
# Appointment Entity Reference

[!INCLUDE[](../../includes/cc_applies_to_update_9_0_0.md)]

Commitment representing a time interval with start/end times and duration.


## Messages

|Message|Web API Operation|SDK Assembly|
|-|-|-|
|Assign|PATCH [*org URI*]/api/data/v9.0/appointments(*activityid*)<br />[Update](../webapi/update-delete-entities-using-web-api.md#basic-update) `ownerid` property.|<xref:Microsoft.Crm.Sdk.Messages.AssignRequest>|
|Book|<xref href="Microsoft.Dynamics.CRM.Book?text=Book Action" />|<xref:Microsoft.Crm.Sdk.Messages.BookRequest>|
|Create|POST [*org URI*]/api/data/v9.0/appointments<br />See [Create](../webapi/create-entity-web-api.md)|<xref:Microsoft.Xrm.Sdk.Messages.CreateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Create*>|
|CreateException|<xref href="Microsoft.Dynamics.CRM.CreateException?text=CreateException Action" />|<xref:Microsoft.Crm.Sdk.Messages.CreateExceptionRequest>|
|Delete|DELETE [*org URI*]/api/data/v9.0/appointments(*activityid*)<br />See [Delete](../webapi/update-delete-entities-using-web-api.md#basic-delete)|<xref:Microsoft.Xrm.Sdk.Messages.DeleteRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Delete*>|
|GrantAccess|<xref href="Microsoft.Dynamics.CRM.GrantAccess?text=GrantAccess Action" />|<xref:Microsoft.Crm.Sdk.Messages.GrantAccessRequest>|
|ModifyAccess|<xref href="Microsoft.Dynamics.CRM.ModifyAccess?text=ModifyAccess Action" />|<xref:Microsoft.Crm.Sdk.Messages.ModifyAccessRequest>|
|Reschedule|<xref href="Microsoft.Dynamics.CRM.Reschedule?text=Reschedule Action" />|<xref:Microsoft.Crm.Sdk.Messages.RescheduleRequest>|
|Retrieve|GET [*org URI*]/api/data/v9.0/appointments(*activityid*)<br />See [Retrieve](../webapi/retrieve-entity-using-web-api.md)|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Retrieve*>|
|RetrieveMultiple|GET [*org URI*]/api/data/v9.0/appointments<br />See [Query Data](../webapi/query-data-web-api.md)|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveMultipleRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.RetrieveMultiple*>|
|RetrievePrincipalAccess|<xref href="Microsoft.Dynamics.CRM.RetrievePrincipalAccess?text=RetrievePrincipalAccess Function" />|<xref:Microsoft.Crm.Sdk.Messages.RetrievePrincipalAccessRequest>|
|RetrieveSharedPrincipalsAndAccess|<xref href="Microsoft.Dynamics.CRM.RetrieveSharedPrincipalsAndAccess?text=RetrieveSharedPrincipalsAndAccess Function" />|<xref:Microsoft.Crm.Sdk.Messages.RetrieveSharedPrincipalsAndAccessRequest>|
|RevokeAccess|<xref href="Microsoft.Dynamics.CRM.RevokeAccess?text=RevokeAccess Action" />|<xref:Microsoft.Crm.Sdk.Messages.RevokeAccessRequest>|
|SetState|PATCH [*org URI*]/api/data/v9.0/appointments(*activityid*)<br />[Update](../webapi/update-delete-entities-using-web-api.md#basic-update) `statecode` and `statuscode` properties.|<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|
|Update|PATCH [*org URI*]/api/data/v9.0/appointments(*activityid*)<br />See [Update](../webapi/update-delete-entities-using-web-api.md#basic-update)|<xref:Microsoft.Xrm.Sdk.Messages.UpdateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Update*>|
|Validate|<xref href="Microsoft.Dynamics.CRM.Validate?text=Validate Action" />|<xref:Microsoft.Crm.Sdk.Messages.ValidateRequest>|
|ValidateSavedQuery|<xref href="Microsoft.Dynamics.CRM.ValidateSavedQuery?text=ValidateSavedQuery Action" />|<xref:Microsoft.Crm.Sdk.Messages.ValidateSavedQueryRequest>|

## Entity Properties

**DisplayName**: Appointment<br />
**DisplayCollectionName**: Appointments<br />
**SchemaName**: Appointment<br />
**CollectionSchemaName**: Appointments<br />
**LogicalName**: appointment<br />
**LogicalCollectionName**: appointments<br />
**EntitySetName**: appointments<br />
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
- [AttachmentErrors](#BKMK_AttachmentErrors)
- [Category](#BKMK_Category)
- [Description](#BKMK_Description)
- [GlobalObjectId](#BKMK_GlobalObjectId)
- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [IsAllDayEvent](#BKMK_IsAllDayEvent)
- [IsBilled](#BKMK_IsBilled)
- [IsMapiPrivate](#BKMK_IsMapiPrivate)
- [IsWorkflowCreated](#BKMK_IsWorkflowCreated)
- [LastOnHoldTime](#BKMK_LastOnHoldTime)
- [Location](#BKMK_Location)
- [OptionalAttendees](#BKMK_OptionalAttendees)
- [Organizer](#BKMK_Organizer)
- [OutlookOwnerApptId](#BKMK_OutlookOwnerApptId)
- [OverriddenCreatedOn](#BKMK_OverriddenCreatedOn)
- [OwnerId](#BKMK_OwnerId)
- [OwnerIdType](#BKMK_OwnerIdType)
- [PriorityCode](#BKMK_PriorityCode)
- [ProcessId](#BKMK_ProcessId)
- [RegardingObjectId](#BKMK_RegardingObjectId)
- [RegardingObjectTypeCode](#BKMK_RegardingObjectTypeCode)
- [requiredattendees](#BKMK_requiredattendees)
- [ScheduledDurationMinutes](#BKMK_ScheduledDurationMinutes)
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
- [SubscriptionId](#BKMK_SubscriptionId)
- [TimeZoneRuleVersionNumber](#BKMK_TimeZoneRuleVersionNumber)
- [TransactionCurrencyId](#BKMK_TransactionCurrencyId)
- [TraversedPath](#BKMK_TraversedPath)
- [UTCConversionTimeZoneCode](#BKMK_UTCConversionTimeZoneCode)


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

**Description**: Unique identifier of the appointment.<br />
**DisplayName**: Appointment<br />
**LogicalName**: activityid<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: SystemRequired<br />
**IsValidForUpdate**: False<br />
**Type**: Uniqueidentifier<br />


### <a name="BKMK_ActualDurationMinutes"></a> ActualDurationMinutes

**Description**: Shows the value selected in the Duration field on the appointment at the time that the appointment is closed as completed. The duration is used to report the time spent on the activity.<br />
**DisplayName**: Actual Duration<br />
**LogicalName**: actualdurationminutes<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Integer<br />
**Format**: Duration<br />
**MaxValue**: 2147483647<br />
**MinValue**: 0


### <a name="BKMK_ActualEnd"></a> ActualEnd

**Description**: Enter the actual end date and time of the appointment. By default, it displays the date and time when the activity was completed or canceled, but can be edited to capture the actual duration of the appointment.<br />
**DisplayName**: Actual End<br />
**LogicalName**: actualend<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: DateTime<br />
**DateTimeBehavior**: UserLocal<br />
**Format**: DateAndTime


### <a name="BKMK_ActualStart"></a> ActualStart

**Description**: Enter the actual start date and time for the appointment. By default, it displays the date and time when the activity was created, but can be edited to capture the actual duration of the appointment.<br />
**DisplayName**: Actual Start<br />
**LogicalName**: actualstart<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: DateTime<br />
**DateTimeBehavior**: UserLocal<br />
**Format**: DateAndTime


### <a name="BKMK_AttachmentErrors"></a> AttachmentErrors

**Description**: Select the error code to identify issues with the outlook item recipients or attachments, such as blocked attachments.<br />
**DisplayName**: AttachmentErrors<br />
**LogicalName**: attachmenterrors<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Picklist<br />
**Options**:

- **Value**: 0 **Label**: None
- **Value**: 1 **Label**: The appointment was saved as a Microsoft Dynamics 365 appointment record, but not all the attachments could be saved with it. An attachment cannot be saved if it is blocked or if its file type is invalid.



### <a name="BKMK_Category"></a> Category

**Description**: Type a category to identify the appointment type, such as sales demo, prospect call, or service call, to tie the appointment to a business group or function.<br />
**DisplayName**: Category<br />
**LogicalName**: category<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 250


### <a name="BKMK_Description"></a> Description

**Description**: Type additional information to describe the purpose of the appointment.<br />
**DisplayName**: Description<br />
**LogicalName**: description<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Memo<br />
**Format**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 2000


### <a name="BKMK_GlobalObjectId"></a> GlobalObjectId

**Description**: Shows the ID of the appointment in Microsoft Office Outlook. The ID is used to synchronize the appointment between Microsoft Dynamics 365 and the correct Exchange account.<br />
**DisplayName**: Outlook Appointment<br />
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


### <a name="BKMK_IsAllDayEvent"></a> IsAllDayEvent

**Description**: Select whether the appointment is an all-day event to make sure that the required resources are scheduled for the full day.<br />
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

**Description**: Information regarding whether the appointment was billed as part of resolving a case.<br />
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

**Description**: Information regarding whether the appointment was created from a workflow rule.<br />
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


### <a name="BKMK_Location"></a> Location

**Description**: Type the location where the appointment will take place, such as a conference room or customer office.<br />
**DisplayName**: Location<br />
**LogicalName**: location<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 200


### <a name="BKMK_OptionalAttendees"></a> OptionalAttendees

**Description**: Enter the account, contact, lead, user, or other equipment resources that are not needed at the appointment, but can optionally attend.<br />
**DisplayName**: Optional Attendees<br />
**LogicalName**: optionalattendees<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: PartyList<br />
**Targets**: account,contact,equipment,lead,systemuser


### <a name="BKMK_Organizer"></a> Organizer

**Description**: Enter the user who is in charge of coordinating or leading the appointment to make sure the appointment is displayed in the user's My Activities view.<br />
**DisplayName**: Organizer<br />
**LogicalName**: organizer<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: PartyList<br />
**Targets**: systemuser


### <a name="BKMK_OutlookOwnerApptId"></a> OutlookOwnerApptId

**Description**: Unique identifier of the Microsoft Office Outlook appointment owner that correlates to the PR_OWNER_APPT_ID MAPI property.<br />
**DisplayName**: Outlook Appointment Owner<br />
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


### <a name="BKMK_RegardingObjectId"></a> RegardingObjectId

**Description**: Choose the record that the appointment relates to.<br />
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


### <a name="BKMK_requiredattendees"></a> requiredattendees

**Description**: Enter the account, contact, lead, user, or other equipment resources that are required to attend the appointment.<br />
**DisplayName**: Required Attendees<br />
**LogicalName**: requiredattendees<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: PartyList<br />
**Targets**: account,contact,equipment,lead,systemuser


### <a name="BKMK_ScheduledDurationMinutes"></a> ScheduledDurationMinutes

**Description**: Shows the expected duration of the appointment, in minutes.<br />
**DisplayName**: Duration<br />
**LogicalName**: scheduleddurationminutes<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Integer<br />
**Format**: Duration<br />
**MaxValue**: 2147483647<br />
**MinValue**: 0


### <a name="BKMK_ScheduledEnd"></a> ScheduledEnd

**Description**: Enter the expected due date and time for the activity to be completed to provide details about the timing of the appointment.<br />
**DisplayName**: End Time<br />
**LogicalName**: scheduledend<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: ApplicationRequired<br />
**Type**: DateTime<br />
**DateTimeBehavior**: UserLocal<br />
**Format**: DateAndTime


### <a name="BKMK_ScheduledStart"></a> ScheduledStart

**Description**: Enter the expected start date and time for the activity to provide details about the timing of the appointment.<br />
**DisplayName**: Start Time<br />
**LogicalName**: scheduledstart<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: ApplicationRequired<br />
**Type**: DateTime<br />
**DateTimeBehavior**: UserLocal<br />
**Format**: DateAndTime


### <a name="BKMK_ServiceId"></a> ServiceId

**Description**: Unique identifier for an associated service.<br />
**DisplayName**: Service<br />
**LogicalName**: serviceid<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: service


### <a name="BKMK_SLAId"></a> SLAId

**Description**: Choose the service level agreement (SLA) that you want to apply to the appointment record.<br />
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

**Description**: Shows the ID of the stage.<br />
**DisplayName**: Process Stage<br />
**LogicalName**: stageid<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Uniqueidentifier<br />


### <a name="BKMK_StateCode"></a> StateCode

**Description**: Shows whether the appointment is open, completed, or canceled. Completed and canceled appointments are read-only and can't be edited.<br />
**DisplayName**: Status<br />
**LogicalName**: statecode<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: SystemRequired<br />
**IsValidForCreate**: False<br />
**Type**: State<br />
**Options**:

- **Value**: 0 **Label**: Open **DefaultStatus**: 1 **InvariantName**: Open
- **Value**: 1 **Label**: Completed **DefaultStatus**: 3 **InvariantName**: Completed
- **Value**: 2 **Label**: Canceled **DefaultStatus**: 4 **InvariantName**: Canceled
- **Value**: 3 **Label**: Scheduled **DefaultStatus**: 5 **InvariantName**: Scheduled



### <a name="BKMK_StatusCode"></a> StatusCode

**Added by**: Activities Solution<br />
**Description**: Select the appointment's status.<br />
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

**Description**: Type a subcategory to identify the appointment type and relate the activity to a specific product, sales region, business group, or other function.<br />
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

**Description**: Type a short description about the objective or primary topic of the appointment.<br />
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
**DisplayName**: Subscription<br />
**LogicalName**: subscriptionid<br />
**IsValidForForm**: False<br />
**IsValidForRead**: False<br />
**RequiredLevel**: None<br />
**IsValidForUpdate**: False<br />
**Type**: Uniqueidentifier<br />


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
- [AttachmentCount](#BKMK_AttachmentCount)
- [CreatedBy](#BKMK_CreatedBy)
- [CreatedByName](#BKMK_CreatedByName)
- [CreatedByYomiName](#BKMK_CreatedByYomiName)
- [CreatedOn](#BKMK_CreatedOn)
- [CreatedOnBehalfBy](#BKMK_CreatedOnBehalfBy)
- [CreatedOnBehalfByName](#BKMK_CreatedOnBehalfByName)
- [CreatedOnBehalfByYomiName](#BKMK_CreatedOnBehalfByYomiName)
- [ExchangeRate](#BKMK_ExchangeRate)
- [InstanceTypeCode](#BKMK_InstanceTypeCode)
- [IsRegularActivity](#BKMK_IsRegularActivity)
- [ModifiedBy](#BKMK_ModifiedBy)
- [ModifiedByName](#BKMK_ModifiedByName)
- [ModifiedByYomiName](#BKMK_ModifiedByYomiName)
- [ModifiedFieldsMask](#BKMK_ModifiedFieldsMask)
- [ModifiedOn](#BKMK_ModifiedOn)
- [ModifiedOnBehalfBy](#BKMK_ModifiedOnBehalfBy)
- [ModifiedOnBehalfByName](#BKMK_ModifiedOnBehalfByName)
- [ModifiedOnBehalfByYomiName](#BKMK_ModifiedOnBehalfByYomiName)
- [OnHoldTime](#BKMK_OnHoldTime)
- [OriginalStartDate](#BKMK_OriginalStartDate)
- [OwnerIdName](#BKMK_OwnerIdName)
- [OwnerIdYomiName](#BKMK_OwnerIdYomiName)
- [OwningBusinessUnit](#BKMK_OwningBusinessUnit)
- [OwningTeam](#BKMK_OwningTeam)
- [OwningUser](#BKMK_OwningUser)
- [RegardingObjectIdName](#BKMK_RegardingObjectIdName)
- [RegardingObjectIdYomiName](#BKMK_RegardingObjectIdYomiName)
- [SeriesId](#BKMK_SeriesId)
- [ServiceIdName](#BKMK_ServiceIdName)
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


### <a name="BKMK_AttachmentCount"></a> AttachmentCount

**Description**: Shows the number of attachments on the appointment.<br />
**DisplayName**: Attachment Count<br />
**LogicalName**: attachmentcount<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: SystemRequired<br />
**Type**: Integer<br />
**Format**: None<br />
**MaxValue**: 2147483647<br />
**MinValue**: 0


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


### <a name="BKMK_ModifiedFieldsMask"></a> ModifiedFieldsMask

**Description**: For internal use only. <br />
**DisplayName**: Modified Fields Mask<br />
**LogicalName**: modifiedfieldsmask<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Memo<br />
**Format**: TextArea<br />
**IsLocalizable**: False<br />
**MaxLength**: 1073741823


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

**Description**: Shows who created the record on behalf of another user.<br />
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


### <a name="BKMK_OriginalStartDate"></a> OriginalStartDate

**Description**: The original start date of the appointment.<br />
**DisplayName**: Original Start Date<br />
**LogicalName**: originalstartdate<br />
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

**Description**: Shows the business unit that the record owner belongs to.<br />
**DisplayName**: Owning Business Unit<br />
**LogicalName**: owningbusinessunit<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: businessunit


### <a name="BKMK_OwningTeam"></a> OwningTeam

**Description**: Unique identifier of the team that owns the appointment.<br />
**DisplayName**: Owning Team<br />
**LogicalName**: owningteam<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: team


### <a name="BKMK_OwningUser"></a> OwningUser

**Description**: Unique identifier of the user that owns the appointment.<br />
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


### <a name="BKMK_SeriesId"></a> SeriesId

**Description**: Shows the ID of the recurring series of an instance.<br />
**DisplayName**: Series Id<br />
**LogicalName**: seriesid<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Uniqueidentifier<br />


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


### <a name="BKMK_SLAInvokedId"></a> SLAInvokedId

**Description**: Last SLA that was applied to this appointment. This field is for internal use only.<br />
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

**Description**: Version number of the appointment.<br />
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

- [appointment_campaignresponse](#BKMK_appointment_campaignresponse)
- [appointment_PostFollows](#BKMK_appointment_PostFollows)
- [Appointment_DuplicateMatchingRecord](#BKMK_Appointment_DuplicateMatchingRecord)
- [Appointment_ProcessSessions](#BKMK_Appointment_ProcessSessions)
- [appointment_connections1](#BKMK_appointment_connections1)
- [appointment_activity_parties](#BKMK_appointment_activity_parties)
- [userentityinstancedata_appointment](#BKMK_userentityinstancedata_appointment)
- [Appointment_Annotation](#BKMK_Appointment_Annotation)
- [appointment_connections2](#BKMK_appointment_connections2)
- [Appointment_DuplicateBaseRecord](#BKMK_Appointment_DuplicateBaseRecord)
- [slakpiinstance_appointment](#BKMK_slakpiinstance_appointment)
- [Appointment_SyncErrors](#BKMK_Appointment_SyncErrors)
- [Appointment_AsyncOperations](#BKMK_Appointment_AsyncOperations)
- [appointment_actioncard](#BKMK_appointment_actioncard)
- [appointment_principalobjectattributeaccess](#BKMK_appointment_principalobjectattributeaccess)
- [appointment_activity_mime_attachment](#BKMK_appointment_activity_mime_attachment)
- [Appointment_QueueItem](#BKMK_Appointment_QueueItem)
- [Appointment_BulkDeleteFailures](#BKMK_Appointment_BulkDeleteFailures)


### <a name="BKMK_appointment_campaignresponse"></a> appointment_campaignresponse

Same as campaignresponse entity [appointment_campaignresponse](campaignresponse.md#BKMK_appointment_campaignresponse) Many-To-One relationship.

**ReferencingEntity**: campaignresponse<br />
**ReferencingAttribute**: originatingactivityid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: appointment_campaignresponse<br />
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


### <a name="BKMK_appointment_PostFollows"></a> appointment_PostFollows

Same as postfollow entity [appointment_PostFollows](postfollow.md#BKMK_appointment_PostFollows) Many-To-One relationship.

**ReferencingEntity**: postfollow<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: False<br />
**ReferencedEntityNavigationPropertyName**: appointment_PostFollows<br />
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


### <a name="BKMK_Appointment_DuplicateMatchingRecord"></a> Appointment_DuplicateMatchingRecord

Same as duplicaterecord entity [Appointment_DuplicateMatchingRecord](duplicaterecord.md#BKMK_Appointment_DuplicateMatchingRecord) Many-To-One relationship.

**ReferencingEntity**: duplicaterecord<br />
**ReferencingAttribute**: duplicaterecordid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: False<br />
**ReferencedEntityNavigationPropertyName**: Appointment_DuplicateMatchingRecord<br />
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


### <a name="BKMK_Appointment_ProcessSessions"></a> Appointment_ProcessSessions

Same as processsession entity [Appointment_ProcessSessions](processsession.md#BKMK_Appointment_ProcessSessions) Many-To-One relationship.

**ReferencingEntity**: processsession<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: False<br />
**ReferencedEntityNavigationPropertyName**: Appointment_ProcessSessions<br />
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


### <a name="BKMK_appointment_connections1"></a> appointment_connections1

Same as connection entity [appointment_connections1](connection.md#BKMK_appointment_connections1) Many-To-One relationship.

**ReferencingEntity**: connection<br />
**ReferencingAttribute**: record1id<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: appointment_connections1<br />
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


### <a name="BKMK_appointment_activity_parties"></a> appointment_activity_parties

Same as activityparty entity [appointment_activity_parties](activityparty.md#BKMK_appointment_activity_parties) Many-To-One relationship.

**ReferencingEntity**: activityparty<br />
**ReferencingAttribute**: activityid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: False<br />
**ReferencedEntityNavigationPropertyName**: appointment_activity_parties<br />
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


### <a name="BKMK_userentityinstancedata_appointment"></a> userentityinstancedata_appointment

Same as userentityinstancedata entity [userentityinstancedata_appointment](userentityinstancedata.md#BKMK_userentityinstancedata_appointment) Many-To-One relationship.

**ReferencingEntity**: userentityinstancedata<br />
**ReferencingAttribute**: objectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: False<br />
**ReferencedEntityNavigationPropertyName**: userentityinstancedata_appointment<br />
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


### <a name="BKMK_Appointment_Annotation"></a> Appointment_Annotation

Same as annotation entity [Appointment_Annotation](annotation.md#BKMK_Appointment_Annotation) Many-To-One relationship.

**ReferencingEntity**: annotation<br />
**ReferencingAttribute**: objectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: Appointment_Annotation<br />
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


### <a name="BKMK_appointment_connections2"></a> appointment_connections2

Same as connection entity [appointment_connections2](connection.md#BKMK_appointment_connections2) Many-To-One relationship.

**ReferencingEntity**: connection<br />
**ReferencingAttribute**: record2id<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: appointment_connections2<br />
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


### <a name="BKMK_Appointment_DuplicateBaseRecord"></a> Appointment_DuplicateBaseRecord

Same as duplicaterecord entity [Appointment_DuplicateBaseRecord](duplicaterecord.md#BKMK_Appointment_DuplicateBaseRecord) Many-To-One relationship.

**ReferencingEntity**: duplicaterecord<br />
**ReferencingAttribute**: baserecordid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: False<br />
**ReferencedEntityNavigationPropertyName**: Appointment_DuplicateBaseRecord<br />
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


### <a name="BKMK_slakpiinstance_appointment"></a> slakpiinstance_appointment

Same as slakpiinstance entity [slakpiinstance_appointment](slakpiinstance.md#BKMK_slakpiinstance_appointment) Many-To-One relationship.

**ReferencingEntity**: slakpiinstance<br />
**ReferencingAttribute**: regarding<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: slakpiinstance_appointment<br />
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


### <a name="BKMK_Appointment_SyncErrors"></a> Appointment_SyncErrors

Same as syncerror entity [Appointment_SyncErrors](syncerror.md#BKMK_Appointment_SyncErrors) Many-To-One relationship.

**ReferencingEntity**: syncerror<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: Appointment_SyncErrors<br />
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


### <a name="BKMK_Appointment_AsyncOperations"></a> Appointment_AsyncOperations

Same as asyncoperation entity [Appointment_AsyncOperations](asyncoperation.md#BKMK_Appointment_AsyncOperations) Many-To-One relationship.

**ReferencingEntity**: asyncoperation<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: False<br />
**ReferencedEntityNavigationPropertyName**: Appointment_AsyncOperations<br />
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


### <a name="BKMK_appointment_actioncard"></a> appointment_actioncard

Same as actioncard entity [appointment_actioncard](actioncard.md#BKMK_appointment_actioncard) Many-To-One relationship.

**ReferencingEntity**: actioncard<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: appointment_actioncard<br />
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


### <a name="BKMK_appointment_principalobjectattributeaccess"></a> appointment_principalobjectattributeaccess

Same as principalobjectattributeaccess entity [appointment_principalobjectattributeaccess](principalobjectattributeaccess.md#BKMK_appointment_principalobjectattributeaccess) Many-To-One relationship.

**ReferencingEntity**: principalobjectattributeaccess<br />
**ReferencingAttribute**: objectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: False<br />
**ReferencedEntityNavigationPropertyName**: appointment_principalobjectattributeaccess<br />
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


### <a name="BKMK_appointment_activity_mime_attachment"></a> appointment_activity_mime_attachment

Same as activitymimeattachment entity [appointment_activity_mime_attachment](activitymimeattachment.md#BKMK_appointment_activity_mime_attachment) Many-To-One relationship.

**ReferencingEntity**: activitymimeattachment<br />
**ReferencingAttribute**: objectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: False<br />
**ReferencedEntityNavigationPropertyName**: appointment_activity_mime_attachment<br />
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


### <a name="BKMK_Appointment_QueueItem"></a> Appointment_QueueItem

Same as queueitem entity [Appointment_QueueItem](queueitem.md#BKMK_Appointment_QueueItem) Many-To-One relationship.

**ReferencingEntity**: queueitem<br />
**ReferencingAttribute**: objectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: Appointment_QueueItem<br />
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


### <a name="BKMK_Appointment_BulkDeleteFailures"></a> Appointment_BulkDeleteFailures

Same as bulkdeletefailure entity [Appointment_BulkDeleteFailures](bulkdeletefailure.md#BKMK_Appointment_BulkDeleteFailures) Many-To-One relationship.

**ReferencingEntity**: bulkdeletefailure<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: False<br />
**ReferencedEntityNavigationPropertyName**: Appointment_BulkDeleteFailures<br />
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

- [Lead_Appointments](#BKMK_Lead_Appointments)
- [bookableresourcebooking_Appointments](#BKMK_bookableresourcebooking_Appointments)
- [bookableresourcebookingheader_Appointments](#BKMK_bookableresourcebookingheader_Appointments)
- [BulkOperation_Appointment](#BKMK_BulkOperation_Appointment)
- [Campaign_Appointments](#BKMK_Campaign_Appointments)
- [CampaignActivity_Appointments](#BKMK_CampaignActivity_Appointments)
- [Contract_Appointments](#BKMK_Contract_Appointments)
- [entitlement_Appointments](#BKMK_entitlement_Appointments)
- [entitlementtemplate_Appointments](#BKMK_entitlementtemplate_Appointments)
- [Incident_Appointments](#BKMK_Incident_Appointments)
- [site_Appointments](#BKMK_site_Appointments)
- [service_appointments](#BKMK_service_appointments)
- [Invoice_Appointments](#BKMK_Invoice_Appointments)
- [Opportunity_Appointments](#BKMK_Opportunity_Appointments)
- [Quote_Appointments](#BKMK_Quote_Appointments)
- [SalesOrder_Appointments](#BKMK_SalesOrder_Appointments)
- [msdyn_postalbum_Appointments](#BKMK_msdyn_postalbum_Appointments)
- [msdyn_bookingalertstatus_Appointments](#BKMK_msdyn_bookingalertstatus_Appointments)
- [msdyn_bookingrule_Appointments](#BKMK_msdyn_bookingrule_Appointments)
- [msdyn_resourceterritory_Appointments](#BKMK_msdyn_resourceterritory_Appointments)
- [msdyn_systemuserschedulersetting_Appointments](#BKMK_msdyn_systemuserschedulersetting_Appointments)
- [msdyn_timegroup_Appointments](#BKMK_msdyn_timegroup_Appointments)
- [msdyn_timegroupdetail_Appointments](#BKMK_msdyn_timegroupdetail_Appointments)
- [msdyn_processnotes_Appointments](#BKMK_msdyn_processnotes_Appointments)
- [msdyn_projectteam_Appointments](#BKMK_msdyn_projectteam_Appointments)
- [msdyn_agreement_Appointments](#BKMK_msdyn_agreement_Appointments)
- [msdyn_agreementbookingdate_Appointments](#BKMK_msdyn_agreementbookingdate_Appointments)
- [msdyn_agreementbookingincident_Appointments](#BKMK_msdyn_agreementbookingincident_Appointments)
- [msdyn_agreementbookingproduct_Appointments](#BKMK_msdyn_agreementbookingproduct_Appointments)
- [msdyn_agreementbookingservice_Appointments](#BKMK_msdyn_agreementbookingservice_Appointments)
- [msdyn_agreementbookingservicetask_Appointments](#BKMK_msdyn_agreementbookingservicetask_Appointments)
- [msdyn_agreementbookingsetup_Appointments](#BKMK_msdyn_agreementbookingsetup_Appointments)
- [msdyn_agreementinvoicedate_Appointments](#BKMK_msdyn_agreementinvoicedate_Appointments)
- [msdyn_agreementinvoiceproduct_Appointments](#BKMK_msdyn_agreementinvoiceproduct_Appointments)
- [msdyn_agreementinvoicesetup_Appointments](#BKMK_msdyn_agreementinvoicesetup_Appointments)
- [msdyn_bookingtimestamp_Appointments](#BKMK_msdyn_bookingtimestamp_Appointments)
- [msdyn_customerasset_Appointments](#BKMK_msdyn_customerasset_Appointments)
- [msdyn_fieldservicesetting_Appointments](#BKMK_msdyn_fieldservicesetting_Appointments)
- [msdyn_incidenttypecharacteristic_Appointments](#BKMK_msdyn_incidenttypecharacteristic_Appointments)
- [msdyn_incidenttypeproduct_Appointments](#BKMK_msdyn_incidenttypeproduct_Appointments)
- [msdyn_incidenttypeservice_Appointments](#BKMK_msdyn_incidenttypeservice_Appointments)
- [msdyn_inventoryadjustment_Appointments](#BKMK_msdyn_inventoryadjustment_Appointments)
- [msdyn_inventoryadjustmentproduct_Appointments](#BKMK_msdyn_inventoryadjustmentproduct_Appointments)
- [msdyn_inventoryjournal_Appointments](#BKMK_msdyn_inventoryjournal_Appointments)
- [msdyn_inventorytransfer_Appointments](#BKMK_msdyn_inventorytransfer_Appointments)
- [msdyn_payment_Appointments](#BKMK_msdyn_payment_Appointments)
- [msdyn_paymentdetail_Appointments](#BKMK_msdyn_paymentdetail_Appointments)
- [msdyn_paymentmethod_Appointments](#BKMK_msdyn_paymentmethod_Appointments)
- [msdyn_paymentterm_Appointments](#BKMK_msdyn_paymentterm_Appointments)
- [msdyn_postalcode_Appointments](#BKMK_msdyn_postalcode_Appointments)
- [msdyn_productinventory_Appointments](#BKMK_msdyn_productinventory_Appointments)
- [msdyn_purchaseorder_Appointments](#BKMK_msdyn_purchaseorder_Appointments)
- [msdyn_purchaseorderbill_Appointments](#BKMK_msdyn_purchaseorderbill_Appointments)
- [msdyn_purchaseorderproduct_Appointments](#BKMK_msdyn_purchaseorderproduct_Appointments)
- [msdyn_purchaseorderreceipt_Appointments](#BKMK_msdyn_purchaseorderreceipt_Appointments)
- [msdyn_purchaseorderreceiptproduct_Appointments](#BKMK_msdyn_purchaseorderreceiptproduct_Appointments)
- [msdyn_purchaseordersubstatus_Appointments](#BKMK_msdyn_purchaseordersubstatus_Appointments)
- [msdyn_quotebookingincident_Appointments](#BKMK_msdyn_quotebookingincident_Appointments)
- [msdyn_quotebookingproduct_Appointments](#BKMK_msdyn_quotebookingproduct_Appointments)
- [msdyn_quotebookingservice_Appointments](#BKMK_msdyn_quotebookingservice_Appointments)
- [msdyn_quotebookingservicetask_Appointments](#BKMK_msdyn_quotebookingservicetask_Appointments)
- [msdyn_rma_Appointments](#BKMK_msdyn_rma_Appointments)
- [msdyn_rmaproduct_Appointments](#BKMK_msdyn_rmaproduct_Appointments)
- [msdyn_rmareceipt_Appointments](#BKMK_msdyn_rmareceipt_Appointments)
- [msdyn_rmareceiptproduct_Appointments](#BKMK_msdyn_rmareceiptproduct_Appointments)
- [msdyn_rmasubstatus_Appointments](#BKMK_msdyn_rmasubstatus_Appointments)
- [msdyn_rtv_Appointments](#BKMK_msdyn_rtv_Appointments)
- [msdyn_rtvproduct_Appointments](#BKMK_msdyn_rtvproduct_Appointments)
- [msdyn_rtvsubstatus_Appointments](#BKMK_msdyn_rtvsubstatus_Appointments)
- [msdyn_shipvia_Appointments](#BKMK_msdyn_shipvia_Appointments)
- [msdyn_timeoffrequest_Appointments](#BKMK_msdyn_timeoffrequest_Appointments)
- [msdyn_warehouse_Appointments](#BKMK_msdyn_warehouse_Appointments)
- [msdyn_workorder_Appointments](#BKMK_msdyn_workorder_Appointments)
- [msdyn_workordercharacteristic_Appointments](#BKMK_msdyn_workordercharacteristic_Appointments)
- [msdyn_workorderincident_Appointments](#BKMK_msdyn_workorderincident_Appointments)
- [msdyn_workorderproduct_Appointments](#BKMK_msdyn_workorderproduct_Appointments)
- [msdyn_workorderresourcerestriction_Appointments](#BKMK_msdyn_workorderresourcerestriction_Appointments)
- [msdyn_workorderservice_Appointments](#BKMK_msdyn_workorderservice_Appointments)
- [msdyn_workorderservicetask_Appointments](#BKMK_msdyn_workorderservicetask_Appointments)
- [KnowledgeBaseRecord_Appointments](#BKMK_KnowledgeBaseRecord_Appointments)
- [business_unit_appointment_activities](#BKMK_business_unit_appointment_activities)
- [lk_appointment_modifiedby](#BKMK_lk_appointment_modifiedby)
- [TransactionCurrency_Appointment](#BKMK_TransactionCurrency_Appointment)
- [lk_appointment_modifiedonbehalfby](#BKMK_lk_appointment_modifiedonbehalfby)
- [lk_appointment_createdby](#BKMK_lk_appointment_createdby)
- [sla_appointment](#BKMK_sla_appointment)
- [Contact_Appointments](#BKMK_Contact_Appointments)
- [lk_appointment_createdonbehalfby](#BKMK_lk_appointment_createdonbehalfby)
- [KnowledgeArticle_Appointments](#BKMK_KnowledgeArticle_Appointments)
- [Account_Appointments](#BKMK_Account_Appointments)
- [manualsla_appointment](#BKMK_manualsla_appointment)
- [team_appointment](#BKMK_team_appointment)
- [user_appointment](#BKMK_user_appointment)
- [recurringappointmentmaster_appointment](#BKMK_recurringappointmentmaster_appointment)
- [processstage_appointments](#BKMK_processstage_appointments)
- [activity_pointer_appointment](#BKMK_activity_pointer_appointment)


### <a name="BKMK_Lead_Appointments"></a> Lead_Appointments

See lead Entity [Lead_Appointments](lead.md#BKMK_Lead_Appointments) One-To-Many relationship.

### <a name="BKMK_bookableresourcebooking_Appointments"></a> bookableresourcebooking_Appointments

See bookableresourcebooking Entity [bookableresourcebooking_Appointments](bookableresourcebooking.md#BKMK_bookableresourcebooking_Appointments) One-To-Many relationship.

### <a name="BKMK_bookableresourcebookingheader_Appointments"></a> bookableresourcebookingheader_Appointments

See bookableresourcebookingheader Entity [bookableresourcebookingheader_Appointments](bookableresourcebookingheader.md#BKMK_bookableresourcebookingheader_Appointments) One-To-Many relationship.

### <a name="BKMK_BulkOperation_Appointment"></a> BulkOperation_Appointment

See bulkoperation Entity [BulkOperation_Appointment](bulkoperation.md#BKMK_BulkOperation_Appointment) One-To-Many relationship.

### <a name="BKMK_Campaign_Appointments"></a> Campaign_Appointments

See campaign Entity [Campaign_Appointments](campaign.md#BKMK_Campaign_Appointments) One-To-Many relationship.

### <a name="BKMK_CampaignActivity_Appointments"></a> CampaignActivity_Appointments

See campaignactivity Entity [CampaignActivity_Appointments](campaignactivity.md#BKMK_CampaignActivity_Appointments) One-To-Many relationship.

### <a name="BKMK_Contract_Appointments"></a> Contract_Appointments

See contract Entity [Contract_Appointments](contract.md#BKMK_Contract_Appointments) One-To-Many relationship.

### <a name="BKMK_entitlement_Appointments"></a> entitlement_Appointments

See entitlement Entity [entitlement_Appointments](entitlement.md#BKMK_entitlement_Appointments) One-To-Many relationship.

### <a name="BKMK_entitlementtemplate_Appointments"></a> entitlementtemplate_Appointments

See entitlementtemplate Entity [entitlementtemplate_Appointments](entitlementtemplate.md#BKMK_entitlementtemplate_Appointments) One-To-Many relationship.

### <a name="BKMK_Incident_Appointments"></a> Incident_Appointments

See incident Entity [Incident_Appointments](incident.md#BKMK_Incident_Appointments) One-To-Many relationship.

### <a name="BKMK_site_Appointments"></a> site_Appointments

See site Entity [site_Appointments](site.md#BKMK_site_Appointments) One-To-Many relationship.

### <a name="BKMK_service_appointments"></a> service_appointments

See service Entity [service_appointments](service.md#BKMK_service_appointments) One-To-Many relationship.

### <a name="BKMK_Invoice_Appointments"></a> Invoice_Appointments

See invoice Entity [Invoice_Appointments](invoice.md#BKMK_Invoice_Appointments) One-To-Many relationship.

### <a name="BKMK_Opportunity_Appointments"></a> Opportunity_Appointments

See opportunity Entity [Opportunity_Appointments](opportunity.md#BKMK_Opportunity_Appointments) One-To-Many relationship.

### <a name="BKMK_Quote_Appointments"></a> Quote_Appointments

See quote Entity [Quote_Appointments](quote.md#BKMK_Quote_Appointments) One-To-Many relationship.

### <a name="BKMK_SalesOrder_Appointments"></a> SalesOrder_Appointments

See salesorder Entity [SalesOrder_Appointments](salesorder.md#BKMK_SalesOrder_Appointments) One-To-Many relationship.

### <a name="BKMK_msdyn_postalbum_Appointments"></a> msdyn_postalbum_Appointments

See msdyn_postalbum Entity [msdyn_postalbum_Appointments](msdyn_postalbum.md#BKMK_msdyn_postalbum_Appointments) One-To-Many relationship.

### <a name="BKMK_msdyn_bookingalertstatus_Appointments"></a> msdyn_bookingalertstatus_Appointments

See msdyn_bookingalertstatus Entity [msdyn_bookingalertstatus_Appointments](msdyn_bookingalertstatus.md#BKMK_msdyn_bookingalertstatus_Appointments) One-To-Many relationship.

### <a name="BKMK_msdyn_bookingrule_Appointments"></a> msdyn_bookingrule_Appointments

See msdyn_bookingrule Entity [msdyn_bookingrule_Appointments](msdyn_bookingrule.md#BKMK_msdyn_bookingrule_Appointments) One-To-Many relationship.

### <a name="BKMK_msdyn_resourceterritory_Appointments"></a> msdyn_resourceterritory_Appointments

See msdyn_resourceterritory Entity [msdyn_resourceterritory_Appointments](msdyn_resourceterritory.md#BKMK_msdyn_resourceterritory_Appointments) One-To-Many relationship.

### <a name="BKMK_msdyn_systemuserschedulersetting_Appointments"></a> msdyn_systemuserschedulersetting_Appointments

See msdyn_systemuserschedulersetting Entity [msdyn_systemuserschedulersetting_Appointments](msdyn_systemuserschedulersetting.md#BKMK_msdyn_systemuserschedulersetting_Appointments) One-To-Many relationship.

### <a name="BKMK_msdyn_timegroup_Appointments"></a> msdyn_timegroup_Appointments

See msdyn_timegroup Entity [msdyn_timegroup_Appointments](msdyn_timegroup.md#BKMK_msdyn_timegroup_Appointments) One-To-Many relationship.

### <a name="BKMK_msdyn_timegroupdetail_Appointments"></a> msdyn_timegroupdetail_Appointments

See msdyn_timegroupdetail Entity [msdyn_timegroupdetail_Appointments](msdyn_timegroupdetail.md#BKMK_msdyn_timegroupdetail_Appointments) One-To-Many relationship.

### <a name="BKMK_msdyn_processnotes_Appointments"></a> msdyn_processnotes_Appointments

See msdyn_processnotes Entity [msdyn_processnotes_Appointments](msdyn_processnotes.md#BKMK_msdyn_processnotes_Appointments) One-To-Many relationship.

### <a name="BKMK_msdyn_projectteam_Appointments"></a> msdyn_projectteam_Appointments

See msdyn_projectteam Entity [msdyn_projectteam_Appointments](msdyn_projectteam.md#BKMK_msdyn_projectteam_Appointments) One-To-Many relationship.

### <a name="BKMK_msdyn_agreement_Appointments"></a> msdyn_agreement_Appointments

See msdyn_agreement Entity [msdyn_agreement_Appointments](msdyn_agreement.md#BKMK_msdyn_agreement_Appointments) One-To-Many relationship.

### <a name="BKMK_msdyn_agreementbookingdate_Appointments"></a> msdyn_agreementbookingdate_Appointments

See msdyn_agreementbookingdate Entity [msdyn_agreementbookingdate_Appointments](msdyn_agreementbookingdate.md#BKMK_msdyn_agreementbookingdate_Appointments) One-To-Many relationship.

### <a name="BKMK_msdyn_agreementbookingincident_Appointments"></a> msdyn_agreementbookingincident_Appointments

See msdyn_agreementbookingincident Entity [msdyn_agreementbookingincident_Appointments](msdyn_agreementbookingincident.md#BKMK_msdyn_agreementbookingincident_Appointments) One-To-Many relationship.

### <a name="BKMK_msdyn_agreementbookingproduct_Appointments"></a> msdyn_agreementbookingproduct_Appointments

See msdyn_agreementbookingproduct Entity [msdyn_agreementbookingproduct_Appointments](msdyn_agreementbookingproduct.md#BKMK_msdyn_agreementbookingproduct_Appointments) One-To-Many relationship.

### <a name="BKMK_msdyn_agreementbookingservice_Appointments"></a> msdyn_agreementbookingservice_Appointments

See msdyn_agreementbookingservice Entity [msdyn_agreementbookingservice_Appointments](msdyn_agreementbookingservice.md#BKMK_msdyn_agreementbookingservice_Appointments) One-To-Many relationship.

### <a name="BKMK_msdyn_agreementbookingservicetask_Appointments"></a> msdyn_agreementbookingservicetask_Appointments

See msdyn_agreementbookingservicetask Entity [msdyn_agreementbookingservicetask_Appointments](msdyn_agreementbookingservicetask.md#BKMK_msdyn_agreementbookingservicetask_Appointments) One-To-Many relationship.

### <a name="BKMK_msdyn_agreementbookingsetup_Appointments"></a> msdyn_agreementbookingsetup_Appointments

See msdyn_agreementbookingsetup Entity [msdyn_agreementbookingsetup_Appointments](msdyn_agreementbookingsetup.md#BKMK_msdyn_agreementbookingsetup_Appointments) One-To-Many relationship.

### <a name="BKMK_msdyn_agreementinvoicedate_Appointments"></a> msdyn_agreementinvoicedate_Appointments

See msdyn_agreementinvoicedate Entity [msdyn_agreementinvoicedate_Appointments](msdyn_agreementinvoicedate.md#BKMK_msdyn_agreementinvoicedate_Appointments) One-To-Many relationship.

### <a name="BKMK_msdyn_agreementinvoiceproduct_Appointments"></a> msdyn_agreementinvoiceproduct_Appointments

See msdyn_agreementinvoiceproduct Entity [msdyn_agreementinvoiceproduct_Appointments](msdyn_agreementinvoiceproduct.md#BKMK_msdyn_agreementinvoiceproduct_Appointments) One-To-Many relationship.

### <a name="BKMK_msdyn_agreementinvoicesetup_Appointments"></a> msdyn_agreementinvoicesetup_Appointments

See msdyn_agreementinvoicesetup Entity [msdyn_agreementinvoicesetup_Appointments](msdyn_agreementinvoicesetup.md#BKMK_msdyn_agreementinvoicesetup_Appointments) One-To-Many relationship.

### <a name="BKMK_msdyn_bookingtimestamp_Appointments"></a> msdyn_bookingtimestamp_Appointments

See msdyn_bookingtimestamp Entity [msdyn_bookingtimestamp_Appointments](msdyn_bookingtimestamp.md#BKMK_msdyn_bookingtimestamp_Appointments) One-To-Many relationship.

### <a name="BKMK_msdyn_customerasset_Appointments"></a> msdyn_customerasset_Appointments

See msdyn_customerasset Entity [msdyn_customerasset_Appointments](msdyn_customerasset.md#BKMK_msdyn_customerasset_Appointments) One-To-Many relationship.

### <a name="BKMK_msdyn_fieldservicesetting_Appointments"></a> msdyn_fieldservicesetting_Appointments

See msdyn_fieldservicesetting Entity [msdyn_fieldservicesetting_Appointments](msdyn_fieldservicesetting.md#BKMK_msdyn_fieldservicesetting_Appointments) One-To-Many relationship.

### <a name="BKMK_msdyn_incidenttypecharacteristic_Appointments"></a> msdyn_incidenttypecharacteristic_Appointments

See msdyn_incidenttypecharacteristic Entity [msdyn_incidenttypecharacteristic_Appointments](msdyn_incidenttypecharacteristic.md#BKMK_msdyn_incidenttypecharacteristic_Appointments) One-To-Many relationship.

### <a name="BKMK_msdyn_incidenttypeproduct_Appointments"></a> msdyn_incidenttypeproduct_Appointments

See msdyn_incidenttypeproduct Entity [msdyn_incidenttypeproduct_Appointments](msdyn_incidenttypeproduct.md#BKMK_msdyn_incidenttypeproduct_Appointments) One-To-Many relationship.

### <a name="BKMK_msdyn_incidenttypeservice_Appointments"></a> msdyn_incidenttypeservice_Appointments

See msdyn_incidenttypeservice Entity [msdyn_incidenttypeservice_Appointments](msdyn_incidenttypeservice.md#BKMK_msdyn_incidenttypeservice_Appointments) One-To-Many relationship.

### <a name="BKMK_msdyn_inventoryadjustment_Appointments"></a> msdyn_inventoryadjustment_Appointments

See msdyn_inventoryadjustment Entity [msdyn_inventoryadjustment_Appointments](msdyn_inventoryadjustment.md#BKMK_msdyn_inventoryadjustment_Appointments) One-To-Many relationship.

### <a name="BKMK_msdyn_inventoryadjustmentproduct_Appointments"></a> msdyn_inventoryadjustmentproduct_Appointments

See msdyn_inventoryadjustmentproduct Entity [msdyn_inventoryadjustmentproduct_Appointments](msdyn_inventoryadjustmentproduct.md#BKMK_msdyn_inventoryadjustmentproduct_Appointments) One-To-Many relationship.

### <a name="BKMK_msdyn_inventoryjournal_Appointments"></a> msdyn_inventoryjournal_Appointments

See msdyn_inventoryjournal Entity [msdyn_inventoryjournal_Appointments](msdyn_inventoryjournal.md#BKMK_msdyn_inventoryjournal_Appointments) One-To-Many relationship.

### <a name="BKMK_msdyn_inventorytransfer_Appointments"></a> msdyn_inventorytransfer_Appointments

See msdyn_inventorytransfer Entity [msdyn_inventorytransfer_Appointments](msdyn_inventorytransfer.md#BKMK_msdyn_inventorytransfer_Appointments) One-To-Many relationship.

### <a name="BKMK_msdyn_payment_Appointments"></a> msdyn_payment_Appointments

See msdyn_payment Entity [msdyn_payment_Appointments](msdyn_payment.md#BKMK_msdyn_payment_Appointments) One-To-Many relationship.

### <a name="BKMK_msdyn_paymentdetail_Appointments"></a> msdyn_paymentdetail_Appointments

See msdyn_paymentdetail Entity [msdyn_paymentdetail_Appointments](msdyn_paymentdetail.md#BKMK_msdyn_paymentdetail_Appointments) One-To-Many relationship.

### <a name="BKMK_msdyn_paymentmethod_Appointments"></a> msdyn_paymentmethod_Appointments

See msdyn_paymentmethod Entity [msdyn_paymentmethod_Appointments](msdyn_paymentmethod.md#BKMK_msdyn_paymentmethod_Appointments) One-To-Many relationship.

### <a name="BKMK_msdyn_paymentterm_Appointments"></a> msdyn_paymentterm_Appointments

See msdyn_paymentterm Entity [msdyn_paymentterm_Appointments](msdyn_paymentterm.md#BKMK_msdyn_paymentterm_Appointments) One-To-Many relationship.

### <a name="BKMK_msdyn_postalcode_Appointments"></a> msdyn_postalcode_Appointments

See msdyn_postalcode Entity [msdyn_postalcode_Appointments](msdyn_postalcode.md#BKMK_msdyn_postalcode_Appointments) One-To-Many relationship.

### <a name="BKMK_msdyn_productinventory_Appointments"></a> msdyn_productinventory_Appointments

See msdyn_productinventory Entity [msdyn_productinventory_Appointments](msdyn_productinventory.md#BKMK_msdyn_productinventory_Appointments) One-To-Many relationship.

### <a name="BKMK_msdyn_purchaseorder_Appointments"></a> msdyn_purchaseorder_Appointments

See msdyn_purchaseorder Entity [msdyn_purchaseorder_Appointments](msdyn_purchaseorder.md#BKMK_msdyn_purchaseorder_Appointments) One-To-Many relationship.

### <a name="BKMK_msdyn_purchaseorderbill_Appointments"></a> msdyn_purchaseorderbill_Appointments

See msdyn_purchaseorderbill Entity [msdyn_purchaseorderbill_Appointments](msdyn_purchaseorderbill.md#BKMK_msdyn_purchaseorderbill_Appointments) One-To-Many relationship.

### <a name="BKMK_msdyn_purchaseorderproduct_Appointments"></a> msdyn_purchaseorderproduct_Appointments

See msdyn_purchaseorderproduct Entity [msdyn_purchaseorderproduct_Appointments](msdyn_purchaseorderproduct.md#BKMK_msdyn_purchaseorderproduct_Appointments) One-To-Many relationship.

### <a name="BKMK_msdyn_purchaseorderreceipt_Appointments"></a> msdyn_purchaseorderreceipt_Appointments

See msdyn_purchaseorderreceipt Entity [msdyn_purchaseorderreceipt_Appointments](msdyn_purchaseorderreceipt.md#BKMK_msdyn_purchaseorderreceipt_Appointments) One-To-Many relationship.

### <a name="BKMK_msdyn_purchaseorderreceiptproduct_Appointments"></a> msdyn_purchaseorderreceiptproduct_Appointments

See msdyn_purchaseorderreceiptproduct Entity [msdyn_purchaseorderreceiptproduct_Appointments](msdyn_purchaseorderreceiptproduct.md#BKMK_msdyn_purchaseorderreceiptproduct_Appointments) One-To-Many relationship.

### <a name="BKMK_msdyn_purchaseordersubstatus_Appointments"></a> msdyn_purchaseordersubstatus_Appointments

See msdyn_purchaseordersubstatus Entity [msdyn_purchaseordersubstatus_Appointments](msdyn_purchaseordersubstatus.md#BKMK_msdyn_purchaseordersubstatus_Appointments) One-To-Many relationship.

### <a name="BKMK_msdyn_quotebookingincident_Appointments"></a> msdyn_quotebookingincident_Appointments

See msdyn_quotebookingincident Entity [msdyn_quotebookingincident_Appointments](msdyn_quotebookingincident.md#BKMK_msdyn_quotebookingincident_Appointments) One-To-Many relationship.

### <a name="BKMK_msdyn_quotebookingproduct_Appointments"></a> msdyn_quotebookingproduct_Appointments

See msdyn_quotebookingproduct Entity [msdyn_quotebookingproduct_Appointments](msdyn_quotebookingproduct.md#BKMK_msdyn_quotebookingproduct_Appointments) One-To-Many relationship.

### <a name="BKMK_msdyn_quotebookingservice_Appointments"></a> msdyn_quotebookingservice_Appointments

See msdyn_quotebookingservice Entity [msdyn_quotebookingservice_Appointments](msdyn_quotebookingservice.md#BKMK_msdyn_quotebookingservice_Appointments) One-To-Many relationship.

### <a name="BKMK_msdyn_quotebookingservicetask_Appointments"></a> msdyn_quotebookingservicetask_Appointments

See msdyn_quotebookingservicetask Entity [msdyn_quotebookingservicetask_Appointments](msdyn_quotebookingservicetask.md#BKMK_msdyn_quotebookingservicetask_Appointments) One-To-Many relationship.

### <a name="BKMK_msdyn_rma_Appointments"></a> msdyn_rma_Appointments

See msdyn_rma Entity [msdyn_rma_Appointments](msdyn_rma.md#BKMK_msdyn_rma_Appointments) One-To-Many relationship.

### <a name="BKMK_msdyn_rmaproduct_Appointments"></a> msdyn_rmaproduct_Appointments

See msdyn_rmaproduct Entity [msdyn_rmaproduct_Appointments](msdyn_rmaproduct.md#BKMK_msdyn_rmaproduct_Appointments) One-To-Many relationship.

### <a name="BKMK_msdyn_rmareceipt_Appointments"></a> msdyn_rmareceipt_Appointments

See msdyn_rmareceipt Entity [msdyn_rmareceipt_Appointments](msdyn_rmareceipt.md#BKMK_msdyn_rmareceipt_Appointments) One-To-Many relationship.

### <a name="BKMK_msdyn_rmareceiptproduct_Appointments"></a> msdyn_rmareceiptproduct_Appointments

See msdyn_rmareceiptproduct Entity [msdyn_rmareceiptproduct_Appointments](msdyn_rmareceiptproduct.md#BKMK_msdyn_rmareceiptproduct_Appointments) One-To-Many relationship.

### <a name="BKMK_msdyn_rmasubstatus_Appointments"></a> msdyn_rmasubstatus_Appointments

See msdyn_rmasubstatus Entity [msdyn_rmasubstatus_Appointments](msdyn_rmasubstatus.md#BKMK_msdyn_rmasubstatus_Appointments) One-To-Many relationship.

### <a name="BKMK_msdyn_rtv_Appointments"></a> msdyn_rtv_Appointments

See msdyn_rtv Entity [msdyn_rtv_Appointments](msdyn_rtv.md#BKMK_msdyn_rtv_Appointments) One-To-Many relationship.

### <a name="BKMK_msdyn_rtvproduct_Appointments"></a> msdyn_rtvproduct_Appointments

See msdyn_rtvproduct Entity [msdyn_rtvproduct_Appointments](msdyn_rtvproduct.md#BKMK_msdyn_rtvproduct_Appointments) One-To-Many relationship.

### <a name="BKMK_msdyn_rtvsubstatus_Appointments"></a> msdyn_rtvsubstatus_Appointments

See msdyn_rtvsubstatus Entity [msdyn_rtvsubstatus_Appointments](msdyn_rtvsubstatus.md#BKMK_msdyn_rtvsubstatus_Appointments) One-To-Many relationship.

### <a name="BKMK_msdyn_shipvia_Appointments"></a> msdyn_shipvia_Appointments

See msdyn_shipvia Entity [msdyn_shipvia_Appointments](msdyn_shipvia.md#BKMK_msdyn_shipvia_Appointments) One-To-Many relationship.

### <a name="BKMK_msdyn_timeoffrequest_Appointments"></a> msdyn_timeoffrequest_Appointments

See msdyn_timeoffrequest Entity [msdyn_timeoffrequest_Appointments](msdyn_timeoffrequest.md#BKMK_msdyn_timeoffrequest_Appointments) One-To-Many relationship.

### <a name="BKMK_msdyn_warehouse_Appointments"></a> msdyn_warehouse_Appointments

See msdyn_warehouse Entity [msdyn_warehouse_Appointments](msdyn_warehouse.md#BKMK_msdyn_warehouse_Appointments) One-To-Many relationship.

### <a name="BKMK_msdyn_workorder_Appointments"></a> msdyn_workorder_Appointments

See msdyn_workorder Entity [msdyn_workorder_Appointments](msdyn_workorder.md#BKMK_msdyn_workorder_Appointments) One-To-Many relationship.

### <a name="BKMK_msdyn_workordercharacteristic_Appointments"></a> msdyn_workordercharacteristic_Appointments

See msdyn_workordercharacteristic Entity [msdyn_workordercharacteristic_Appointments](msdyn_workordercharacteristic.md#BKMK_msdyn_workordercharacteristic_Appointments) One-To-Many relationship.

### <a name="BKMK_msdyn_workorderincident_Appointments"></a> msdyn_workorderincident_Appointments

See msdyn_workorderincident Entity [msdyn_workorderincident_Appointments](msdyn_workorderincident.md#BKMK_msdyn_workorderincident_Appointments) One-To-Many relationship.

### <a name="BKMK_msdyn_workorderproduct_Appointments"></a> msdyn_workorderproduct_Appointments

See msdyn_workorderproduct Entity [msdyn_workorderproduct_Appointments](msdyn_workorderproduct.md#BKMK_msdyn_workorderproduct_Appointments) One-To-Many relationship.

### <a name="BKMK_msdyn_workorderresourcerestriction_Appointments"></a> msdyn_workorderresourcerestriction_Appointments

See msdyn_workorderresourcerestriction Entity [msdyn_workorderresourcerestriction_Appointments](msdyn_workorderresourcerestriction.md#BKMK_msdyn_workorderresourcerestriction_Appointments) One-To-Many relationship.

### <a name="BKMK_msdyn_workorderservice_Appointments"></a> msdyn_workorderservice_Appointments

See msdyn_workorderservice Entity [msdyn_workorderservice_Appointments](msdyn_workorderservice.md#BKMK_msdyn_workorderservice_Appointments) One-To-Many relationship.

### <a name="BKMK_msdyn_workorderservicetask_Appointments"></a> msdyn_workorderservicetask_Appointments

See msdyn_workorderservicetask Entity [msdyn_workorderservicetask_Appointments](msdyn_workorderservicetask.md#BKMK_msdyn_workorderservicetask_Appointments) One-To-Many relationship.

### <a name="BKMK_KnowledgeBaseRecord_Appointments"></a> KnowledgeBaseRecord_Appointments

See knowledgebaserecord Entity [KnowledgeBaseRecord_Appointments](knowledgebaserecord.md#BKMK_KnowledgeBaseRecord_Appointments) One-To-Many relationship.

### <a name="BKMK_business_unit_appointment_activities"></a> business_unit_appointment_activities

See businessunit Entity [business_unit_appointment_activities](businessunit.md#BKMK_business_unit_appointment_activities) One-To-Many relationship.

### <a name="BKMK_lk_appointment_modifiedby"></a> lk_appointment_modifiedby

See systemuser Entity [lk_appointment_modifiedby](systemuser.md#BKMK_lk_appointment_modifiedby) One-To-Many relationship.

### <a name="BKMK_TransactionCurrency_Appointment"></a> TransactionCurrency_Appointment

See transactioncurrency Entity [TransactionCurrency_Appointment](transactioncurrency.md#BKMK_TransactionCurrency_Appointment) One-To-Many relationship.

### <a name="BKMK_lk_appointment_modifiedonbehalfby"></a> lk_appointment_modifiedonbehalfby

See systemuser Entity [lk_appointment_modifiedonbehalfby](systemuser.md#BKMK_lk_appointment_modifiedonbehalfby) One-To-Many relationship.

### <a name="BKMK_lk_appointment_createdby"></a> lk_appointment_createdby

See systemuser Entity [lk_appointment_createdby](systemuser.md#BKMK_lk_appointment_createdby) One-To-Many relationship.

### <a name="BKMK_sla_appointment"></a> sla_appointment

See sla Entity [sla_appointment](sla.md#BKMK_sla_appointment) One-To-Many relationship.

### <a name="BKMK_Contact_Appointments"></a> Contact_Appointments

See contact Entity [Contact_Appointments](contact.md#BKMK_Contact_Appointments) One-To-Many relationship.

### <a name="BKMK_lk_appointment_createdonbehalfby"></a> lk_appointment_createdonbehalfby

See systemuser Entity [lk_appointment_createdonbehalfby](systemuser.md#BKMK_lk_appointment_createdonbehalfby) One-To-Many relationship.

### <a name="BKMK_KnowledgeArticle_Appointments"></a> KnowledgeArticle_Appointments

See knowledgearticle Entity [KnowledgeArticle_Appointments](knowledgearticle.md#BKMK_KnowledgeArticle_Appointments) One-To-Many relationship.

### <a name="BKMK_Account_Appointments"></a> Account_Appointments

See account Entity [Account_Appointments](account.md#BKMK_Account_Appointments) One-To-Many relationship.

### <a name="BKMK_manualsla_appointment"></a> manualsla_appointment

See sla Entity [manualsla_appointment](sla.md#BKMK_manualsla_appointment) One-To-Many relationship.

### <a name="BKMK_team_appointment"></a> team_appointment

See team Entity [team_appointment](team.md#BKMK_team_appointment) One-To-Many relationship.

### <a name="BKMK_user_appointment"></a> user_appointment

See systemuser Entity [user_appointment](systemuser.md#BKMK_user_appointment) One-To-Many relationship.

### <a name="BKMK_recurringappointmentmaster_appointment"></a> recurringappointmentmaster_appointment

See recurringappointmentmaster Entity [recurringappointmentmaster_appointment](recurringappointmentmaster.md#BKMK_recurringappointmentmaster_appointment) One-To-Many relationship.

### <a name="BKMK_processstage_appointments"></a> processstage_appointments

See processstage Entity [processstage_appointments](processstage.md#BKMK_processstage_appointments) One-To-Many relationship.

### <a name="BKMK_activity_pointer_appointment"></a> activity_pointer_appointment

See activitypointer Entity [activity_pointer_appointment](activitypointer.md#BKMK_activity_pointer_appointment) One-To-Many relationship.

## See also

[About the Entity Reference](../about-entity-reference.md)<br />
[Programming reference for Dynamics 365 Customer Engagement](../programming-reference.md)<br />
[Web API Reference](/dynamics365/customer-engagement/web-api/about)<br />
<xref href="Microsoft.Dynamics.CRM.appointment?text=appointment EntityType" />