---
title: "Appointment Entity Reference (Dynamics 365 Customer Engagement)| MicrosoftDocs"
description: "Includes schema information and supported messages for the Appointment entity."
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
# Appointment Entity Reference

Commitment representing a time interval with start/end times and duration.


## Messages

|Message|Web API Operation|SDK Assembly|
|-|-|-|
|Assign|PATCH [*org URI*]/api/data/v9.0/appointments(*activityid*)<br />[Update](/powerapps/developer/common-data-service/webapi/update-delete-entities-using-web-api#basic-update) `ownerid` property.|<xref:Microsoft.Crm.Sdk.Messages.AssignRequest>|
|Book|<xref href="Microsoft.Dynamics.CRM.Book?text=Book Action" />|<xref:Microsoft.Crm.Sdk.Messages.BookRequest>|
|Create|POST [*org URI*]/api/data/v9.0/appointments<br />See [Create](/powerapps/developer/common-data-service/webapi/create-entity-web-api)|<xref:Microsoft.Xrm.Sdk.Messages.CreateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Create*>|
|CreateException|<xref href="Microsoft.Dynamics.CRM.CreateException?text=CreateException Action" />|<xref:Microsoft.Crm.Sdk.Messages.CreateExceptionRequest>|
|Delete|DELETE [*org URI*]/api/data/v9.0/appointments(*activityid*)<br />See [Delete](/powerapps/developer/common-data-service/webapi/update-delete-entities-using-web-api#basic-delete)|<xref:Microsoft.Xrm.Sdk.Messages.DeleteRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Delete*>|
|GrantAccess|<xref href="Microsoft.Dynamics.CRM.GrantAccess?text=GrantAccess Action" />|<xref:Microsoft.Crm.Sdk.Messages.GrantAccessRequest>|
|ModifyAccess|<xref href="Microsoft.Dynamics.CRM.ModifyAccess?text=ModifyAccess Action" />|<xref:Microsoft.Crm.Sdk.Messages.ModifyAccessRequest>|
|Reschedule|<xref href="Microsoft.Dynamics.CRM.Reschedule?text=Reschedule Action" />|<xref:Microsoft.Crm.Sdk.Messages.RescheduleRequest>|
|Retrieve|GET [*org URI*]/api/data/v9.0/appointments(*activityid*)<br />See [Retrieve](/powerapps/developer/common-data-service/webapi/retrieve-entity-using-web-api)|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Retrieve*>|
|RetrieveMultiple|GET [*org URI*]/api/data/v9.0/appointments<br />See [Query Data](/powerapps/developer/common-data-service/webapi/query-data-web-api)|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveMultipleRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.RetrieveMultiple*>|
|RetrievePrincipalAccess|<xref href="Microsoft.Dynamics.CRM.RetrievePrincipalAccess?text=RetrievePrincipalAccess Function" />|<xref:Microsoft.Crm.Sdk.Messages.RetrievePrincipalAccessRequest>|
|RetrieveSharedPrincipalsAndAccess|<xref href="Microsoft.Dynamics.CRM.RetrieveSharedPrincipalsAndAccess?text=RetrieveSharedPrincipalsAndAccess Function" />|<xref:Microsoft.Crm.Sdk.Messages.RetrieveSharedPrincipalsAndAccessRequest>|
|RevokeAccess|<xref href="Microsoft.Dynamics.CRM.RevokeAccess?text=RevokeAccess Action" />|<xref:Microsoft.Crm.Sdk.Messages.RevokeAccessRequest>|
|SetState|PATCH [*org URI*]/api/data/v9.0/appointments(*activityid*)<br />[Update](/powerapps/developer/common-data-service/webapi/update-delete-entities-using-web-api#basic-update) `statecode` and `statuscode` properties.|<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|
|Update|PATCH [*org URI*]/api/data/v9.0/appointments(*activityid*)<br />See [Update](/powerapps/developer/common-data-service/webapi/update-delete-entities-using-web-api#basic-update)|<xref:Microsoft.Xrm.Sdk.Messages.UpdateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Update*>|
|Validate|<xref href="Microsoft.Dynamics.CRM.Validate?text=Validate Action" />|<xref:Microsoft.Crm.Sdk.Messages.ValidateRequest>|
|ValidateSavedQuery|<xref href="Microsoft.Dynamics.CRM.ValidateSavedQuery?text=ValidateSavedQuery Action" />|<xref:Microsoft.Crm.Sdk.Messages.ValidateSavedQueryRequest>|

## Entity Properties

|Property|Value|
|--------|-----|
|CollectionSchemaName|Appointments|
|DisplayCollectionName|Appointments|
|DisplayName|Appointment|
|EntitySetName|appointments|
|IsBPFEntity|False|
|LogicalCollectionName|appointments|
|LogicalName|appointment|
|OwnershipType|UserOwned|
|PrimaryIdAttribute|activityid|
|PrimaryNameAttribute|subject|
|SchemaName|Appointment|

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
- [IsDraft](#BKMK_IsDraft)
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
|Description|Unique identifier of the appointment.|
|DisplayName|Appointment|
|IsValidForForm|False|
|IsValidForRead|True|
|IsValidForUpdate|False|
|LogicalName|activityid|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|


### <a name="BKMK_ActualDurationMinutes"></a> ActualDurationMinutes

|Property|Value|
|--------|-----|
|Description|Shows the value selected in the Duration field on the appointment at the time that the appointment is closed as completed. The duration is used to report the time spent on the activity.|
|DisplayName|Actual Duration|
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
|Description|Enter the actual end date and time of the appointment. By default, it displays the date and time when the activity was completed or canceled, but can be edited to capture the actual duration of the appointment.|
|DisplayName|Actual End|
|Format|DateAndTime|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|actualend|
|RequiredLevel|None|
|Type|DateTime|


### <a name="BKMK_ActualStart"></a> ActualStart

|Property|Value|
|--------|-----|
|DateTimeBehavior|UserLocal|
|Description|Enter the actual start date and time for the appointment. By default, it displays the date and time when the activity was created, but can be edited to capture the actual duration of the appointment.|
|DisplayName|Actual Start|
|Format|DateAndTime|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|actualstart|
|RequiredLevel|None|
|Type|DateTime|


### <a name="BKMK_AttachmentErrors"></a> AttachmentErrors

|Property|Value|
|--------|-----|
|Description|Select the error code to identify issues with the outlook item recipients or attachments, such as blocked attachments.|
|DisplayName|AttachmentErrors|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|attachmenterrors|
|RequiredLevel|None|
|Type|Picklist|

#### AttachmentErrors Options

|Value|Label|
|-----|-----|
|0|None|
|1|The appointment was saved as a Microsoft Dynamics 365 appointment record, but not all the attachments could be saved with it. An attachment cannot be saved if it is blocked or if its file type is invalid.|



### <a name="BKMK_Category"></a> Category

|Property|Value|
|--------|-----|
|Description|Type a category to identify the appointment type, such as sales demo, prospect call, or service call, to tie the appointment to a business group or function.|
|DisplayName|Category|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|category|
|MaxLength|250|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_Description"></a> Description

|Property|Value|
|--------|-----|
|Description|Type additional information to describe the purpose of the appointment.|
|DisplayName|Description|
|Format|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|description|
|MaxLength|1048576|
|RequiredLevel|None|
|Type|Memo|


### <a name="BKMK_GlobalObjectId"></a> GlobalObjectId

|Property|Value|
|--------|-----|
|Description|Shows the ID of the appointment in Microsoft Office Outlook. The ID is used to synchronize the appointment between Microsoft Dynamics 365 and the correct Exchange account.|
|DisplayName|Outlook Appointment|
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


### <a name="BKMK_IsAllDayEvent"></a> IsAllDayEvent

|Property|Value|
|--------|-----|
|Description|Select whether the appointment is an all-day event to make sure that the required resources are scheduled for the full day.|
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
|Description|Information regarding whether the appointment was billed as part of resolving a case.|
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



### <a name="BKMK_IsDraft"></a> IsDraft

|Property|Value|
|--------|-----|
|Description|Information regarding whether the appointment is a draft.|
|DisplayName|IsDraft|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|isdraft|
|RequiredLevel|SystemRequired|
|Type|Boolean|

#### IsDraft Options

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



### <a name="BKMK_IsWorkflowCreated"></a> IsWorkflowCreated

|Property|Value|
|--------|-----|
|Description|Information regarding whether the appointment was created from a workflow rule.|
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


### <a name="BKMK_Location"></a> Location

|Property|Value|
|--------|-----|
|Description|Type the location where the appointment will take place, such as a conference room or customer office.|
|DisplayName|Location|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|location|
|MaxLength|200|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_OptionalAttendees"></a> OptionalAttendees

|Property|Value|
|--------|-----|
|Description|Enter the account, contact, lead, user, or other equipment resources that are not needed at the appointment, but can optionally attend.|
|DisplayName|Optional Attendees|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|optionalattendees|
|RequiredLevel|None|
|Targets|account,contact,entitlement,equipment,knowledgearticle,lead,queue,systemuser,unresolvedaddress|
|Type|PartyList|


### <a name="BKMK_Organizer"></a> Organizer

|Property|Value|
|--------|-----|
|Description|Enter the user who is in charge of coordinating or leading the appointment to make sure the appointment is displayed in the user's My Activities view.|
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
|Description|Unique identifier of the Microsoft Office Outlook appointment owner that correlates to the PR_OWNER_APPT_ID MAPI property.|
|DisplayName|Outlook Appointment Owner|
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


### <a name="BKMK_RegardingObjectId"></a> RegardingObjectId

|Property|Value|
|--------|-----|
|Description|Choose the record that the appointment relates to.|
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


### <a name="BKMK_requiredattendees"></a> requiredattendees

|Property|Value|
|--------|-----|
|Description|Enter the account, contact, lead, user, or other equipment resources that are required to attend the appointment.|
|DisplayName|Required Attendees|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|requiredattendees|
|RequiredLevel|None|
|Targets|account,contact,entitlement,equipment,knowledgearticle,lead,queue,systemuser,unresolvedaddress|
|Type|PartyList|


### <a name="BKMK_ScheduledDurationMinutes"></a> ScheduledDurationMinutes

|Property|Value|
|--------|-----|
|Description|Shows the expected duration of the appointment, in minutes.|
|DisplayName|Duration|
|Format|Duration|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|scheduleddurationminutes|
|MaxValue|2147483647|
|MinValue|0|
|RequiredLevel|None|
|Type|Integer|


### <a name="BKMK_ScheduledEnd"></a> ScheduledEnd

|Property|Value|
|--------|-----|
|DateTimeBehavior|UserLocal|
|Description|Enter the expected due date and time for the activity to be completed to provide details about the timing of the appointment.|
|DisplayName|End Time|
|Format|DateAndTime|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|scheduledend|
|RequiredLevel|ApplicationRequired|
|Type|DateTime|


### <a name="BKMK_ScheduledStart"></a> ScheduledStart

|Property|Value|
|--------|-----|
|DateTimeBehavior|UserLocal|
|Description|Enter the expected start date and time for the activity to provide details about the timing of the appointment.|
|DisplayName|Start Time|
|Format|DateAndTime|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|scheduledstart|
|RequiredLevel|ApplicationRequired|
|Type|DateTime|


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


### <a name="BKMK_SLAId"></a> SLAId

|Property|Value|
|--------|-----|
|Description|Choose the service level agreement (SLA) that you want to apply to the appointment record.|
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
|Description|Shows whether the appointment is open, completed, or canceled. Completed and canceled appointments are read-only and can't be edited.|
|DisplayName|Status|
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
|1|Completed|3|Completed|
|2|Canceled|4|Canceled|
|3|Scheduled|5|Scheduled|



### <a name="BKMK_StatusCode"></a> StatusCode

|Property|Value|
|--------|-----|
|Description|Select the appointment's status.|
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
|Description|Type a subcategory to identify the appointment type and relate the activity to a specific product, sales region, business group, or other function.|
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
|Description|Type a short description about the objective or primary topic of the appointment.|
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
|DisplayName|Subscription|
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
|DisplayName|Time Zone Rule Version Number|
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
- [IsUnsafe](#BKMK_IsUnsafe)
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
- [SafeDescription](#BKMK_SafeDescription)
- [SeriesId](#BKMK_SeriesId)
- [ServiceIdName](#BKMK_ServiceIdName)
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


### <a name="BKMK_AttachmentCount"></a> AttachmentCount

|Property|Value|
|--------|-----|
|Description|Shows the number of attachments on the appointment.|
|DisplayName|Attachment Count|
|Format|None|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|attachmentcount|
|MaxValue|2147483647|
|MinValue|0|
|RequiredLevel|SystemRequired|
|Type|Integer|


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


### <a name="BKMK_InstanceTypeCode"></a> InstanceTypeCode

|Property|Value|
|--------|-----|
|Description|Type of instance of a recurring series.|
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


### <a name="BKMK_ModifiedFieldsMask"></a> ModifiedFieldsMask

|Property|Value|
|--------|-----|
|Description|For internal use only. |
|DisplayName|Modified Fields Mask|
|Format|TextArea|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|modifiedfieldsmask|
|MaxLength|1073741823|
|RequiredLevel|None|
|Type|Memo|


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
|Description|Shows who created the record on behalf of another user.|
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


### <a name="BKMK_OriginalStartDate"></a> OriginalStartDate

|Property|Value|
|--------|-----|
|DateTimeBehavior|UserLocal|
|Description|The original start date of the appointment.|
|DisplayName|Original Start Date|
|Format|DateAndTime|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|originalstartdate|
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
|Description|Shows the business unit that the record owner belongs to.|
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
|Description|Unique identifier of the team that owns the appointment.|
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
|Description|Unique identifier of the user that owns the appointment.|
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


### <a name="BKMK_SafeDescription"></a> SafeDescription

|Property|Value|
|--------|-----|
|Description|Safe body text of the appointment.|
|DisplayName|Safe Description|
|Format|Email|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|safedescription|
|MaxLength|1073741823|
|RequiredLevel|None|
|Type|Memo|


### <a name="BKMK_SeriesId"></a> SeriesId

|Property|Value|
|--------|-----|
|Description|Shows the ID of the recurring series of an instance.|
|DisplayName|Series Id|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|seriesid|
|RequiredLevel|None|
|Type|Uniqueidentifier|


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
|Description|Last SLA that was applied to this appointment. This field is for internal use only.|
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
|Description|Version number of the appointment.|
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

- [appointment_campaignresponse](#BKMK_appointment_campaignresponse)
- [msdyn_appointment_bookableresourcebooking](#BKMK_msdyn_appointment_bookableresourcebooking)
- [msdyn_appointment_msdyn_resourcerequirement](#BKMK_msdyn_appointment_msdyn_resourcerequirement)
- [appointment_PostFollows](#BKMK_appointment_PostFollows)
- [Appointment_DuplicateMatchingRecord](#BKMK_Appointment_DuplicateMatchingRecord)
- [Appointment_ProcessSessions](#BKMK_Appointment_ProcessSessions)
- [appointment_connections1](#BKMK_appointment_connections1)
- [appointment_activity_parties](#BKMK_appointment_activity_parties)
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

**Added by**: Marketing Solution

Same as campaignresponse entity [appointment_campaignresponse](campaignresponse.md#BKMK_appointment_campaignresponse) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|campaignresponse|
|ReferencingAttribute|originatingactivityid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|appointment_campaignresponse|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_appointment_bookableresourcebooking"></a> msdyn_appointment_bookableresourcebooking

**Added by**: Universal Resource Scheduling Solution

Same as bookableresourcebooking entity [msdyn_appointment_bookableresourcebooking](bookableresourcebooking.md#BKMK_msdyn_appointment_bookableresourcebooking) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|bookableresourcebooking|
|ReferencingAttribute|msdyn_appointmentbookingid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_appointment_bookableresourcebooking|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Details<br />Label: <br />Order: 10000|
|CascadeConfiguration|Assign: NoCascade<br />Delete: RemoveLink<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_appointment_msdyn_resourcerequirement"></a> msdyn_appointment_msdyn_resourcerequirement

**Added by**: Universal Resource Scheduling Solution

Same as msdyn_resourcerequirement entity [msdyn_appointment_msdyn_resourcerequirement](msdyn_resourcerequirement.md#BKMK_msdyn_appointment_msdyn_resourcerequirement) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_resourcerequirement|
|ReferencingAttribute|msdyn_appointmentrequirementid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_appointment_msdyn_resourcerequirement|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Details<br />Label: <br />Order: 10000|
|CascadeConfiguration|Assign: NoCascade<br />Delete: RemoveLink<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_appointment_PostFollows"></a> appointment_PostFollows

Same as postfollow entity [appointment_PostFollows](postfollow.md#BKMK_appointment_PostFollows) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|postfollow|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|appointment_PostFollows|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_Appointment_DuplicateMatchingRecord"></a> Appointment_DuplicateMatchingRecord

Same as duplicaterecord entity [Appointment_DuplicateMatchingRecord](duplicaterecord.md#BKMK_Appointment_DuplicateMatchingRecord) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|duplicaterecord|
|ReferencingAttribute|duplicaterecordid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|Appointment_DuplicateMatchingRecord|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_Appointment_ProcessSessions"></a> Appointment_ProcessSessions

Same as processsession entity [Appointment_ProcessSessions](processsession.md#BKMK_Appointment_ProcessSessions) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|processsession|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|Appointment_ProcessSessions|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Details<br />Label: <br />Order: 110|
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_appointment_connections1"></a> appointment_connections1

Same as connection entity [appointment_connections1](connection.md#BKMK_appointment_connections1) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|connection|
|ReferencingAttribute|record1id|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|appointment_connections1|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Details<br />Label: <br />Order: 100|
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_appointment_activity_parties"></a> appointment_activity_parties

Same as activityparty entity [appointment_activity_parties](activityparty.md#BKMK_appointment_activity_parties) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|activityparty|
|ReferencingAttribute|activityid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|appointment_activity_parties|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_Appointment_Annotation"></a> Appointment_Annotation

Same as annotation entity [Appointment_Annotation](annotation.md#BKMK_Appointment_Annotation) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|annotation|
|ReferencingAttribute|objectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|Appointment_Annotation|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: Cascade<br />Share: Cascade<br />Unshare: Cascade|


### <a name="BKMK_appointment_connections2"></a> appointment_connections2

Same as connection entity [appointment_connections2](connection.md#BKMK_appointment_connections2) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|connection|
|ReferencingAttribute|record2id|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|appointment_connections2|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: 100|
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_Appointment_DuplicateBaseRecord"></a> Appointment_DuplicateBaseRecord

Same as duplicaterecord entity [Appointment_DuplicateBaseRecord](duplicaterecord.md#BKMK_Appointment_DuplicateBaseRecord) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|duplicaterecord|
|ReferencingAttribute|baserecordid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|Appointment_DuplicateBaseRecord|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_slakpiinstance_appointment"></a> slakpiinstance_appointment

Same as slakpiinstance entity [slakpiinstance_appointment](slakpiinstance.md#BKMK_slakpiinstance_appointment) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|slakpiinstance|
|ReferencingAttribute|regarding|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|slakpiinstance_appointment|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_Appointment_SyncErrors"></a> Appointment_SyncErrors

Same as syncerror entity [Appointment_SyncErrors](syncerror.md#BKMK_Appointment_SyncErrors) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|syncerror|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|Appointment_SyncErrors|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: Cascade<br />Reparent: Cascade<br />Share: Cascade<br />Unshare: Cascade|


### <a name="BKMK_Appointment_AsyncOperations"></a> Appointment_AsyncOperations

Same as asyncoperation entity [Appointment_AsyncOperations](asyncoperation.md#BKMK_Appointment_AsyncOperations) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|asyncoperation|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|Appointment_AsyncOperations|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_appointment_actioncard"></a> appointment_actioncard

Same as actioncard entity [appointment_actioncard](actioncard.md#BKMK_appointment_actioncard) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|actioncard|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|appointment_actioncard|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_appointment_principalobjectattributeaccess"></a> appointment_principalobjectattributeaccess

Same as principalobjectattributeaccess entity [appointment_principalobjectattributeaccess](principalobjectattributeaccess.md#BKMK_appointment_principalobjectattributeaccess) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|principalobjectattributeaccess|
|ReferencingAttribute|objectid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|appointment_principalobjectattributeaccess|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_appointment_activity_mime_attachment"></a> appointment_activity_mime_attachment

Same as activitymimeattachment entity [appointment_activity_mime_attachment](activitymimeattachment.md#BKMK_appointment_activity_mime_attachment) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|activitymimeattachment|
|ReferencingAttribute|objectid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|appointment_activity_mime_attachment|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_Appointment_QueueItem"></a> Appointment_QueueItem

Same as queueitem entity [Appointment_QueueItem](queueitem.md#BKMK_Appointment_QueueItem) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|queueitem|
|ReferencingAttribute|objectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|Appointment_QueueItem|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_Appointment_BulkDeleteFailures"></a> Appointment_BulkDeleteFailures

Same as bulkdeletefailure entity [Appointment_BulkDeleteFailures](bulkdeletefailure.md#BKMK_Appointment_BulkDeleteFailures) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|bulkdeletefailure|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|Appointment_BulkDeleteFailures|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|

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
- [msdyn_playbookinstance_Appointments](#BKMK_msdyn_playbookinstance_Appointments)
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

**Added by**: Lead Management Solution

See lead Entity [Lead_Appointments](lead.md#BKMK_Lead_Appointments) One-To-Many relationship.

### <a name="BKMK_bookableresourcebooking_Appointments"></a> bookableresourcebooking_Appointments

**Added by**: Scheduling Solution

See bookableresourcebooking Entity [bookableresourcebooking_Appointments](bookableresourcebooking.md#BKMK_bookableresourcebooking_Appointments) One-To-Many relationship.

### <a name="BKMK_bookableresourcebookingheader_Appointments"></a> bookableresourcebookingheader_Appointments

**Added by**: Scheduling Solution

See bookableresourcebookingheader Entity [bookableresourcebookingheader_Appointments](bookableresourcebookingheader.md#BKMK_bookableresourcebookingheader_Appointments) One-To-Many relationship.

### <a name="BKMK_BulkOperation_Appointment"></a> BulkOperation_Appointment

**Added by**: Marketing Solution

See bulkoperation Entity [BulkOperation_Appointment](bulkoperation.md#BKMK_BulkOperation_Appointment) One-To-Many relationship.

### <a name="BKMK_Campaign_Appointments"></a> Campaign_Appointments

**Added by**: Marketing Solution

See campaign Entity [Campaign_Appointments](campaign.md#BKMK_Campaign_Appointments) One-To-Many relationship.

### <a name="BKMK_CampaignActivity_Appointments"></a> CampaignActivity_Appointments

**Added by**: Marketing Solution

See campaignactivity Entity [CampaignActivity_Appointments](campaignactivity.md#BKMK_CampaignActivity_Appointments) One-To-Many relationship.

### <a name="BKMK_Contract_Appointments"></a> Contract_Appointments

**Added by**: Service Solution

See contract Entity [Contract_Appointments](contract.md#BKMK_Contract_Appointments) One-To-Many relationship.

### <a name="BKMK_entitlement_Appointments"></a> entitlement_Appointments

**Added by**: Service Solution

See entitlement Entity [entitlement_Appointments](entitlement.md#BKMK_entitlement_Appointments) One-To-Many relationship.

### <a name="BKMK_entitlementtemplate_Appointments"></a> entitlementtemplate_Appointments

**Added by**: Service Solution

See entitlementtemplate Entity [entitlementtemplate_Appointments](entitlementtemplate.md#BKMK_entitlementtemplate_Appointments) One-To-Many relationship.

### <a name="BKMK_Incident_Appointments"></a> Incident_Appointments

**Added by**: Service Solution

See incident Entity [Incident_Appointments](incident.md#BKMK_Incident_Appointments) One-To-Many relationship.

### <a name="BKMK_site_Appointments"></a> site_Appointments

**Added by**: Service Solution

See site Entity [site_Appointments](site.md#BKMK_site_Appointments) One-To-Many relationship.

### <a name="BKMK_service_appointments"></a> service_appointments

**Added by**: Service Solution

See service Entity [service_appointments](service.md#BKMK_service_appointments) One-To-Many relationship.

### <a name="BKMK_msdyn_playbookinstance_Appointments"></a> msdyn_playbookinstance_Appointments

**Added by**: Playbook Solution

See msdyn_playbookinstance Entity [msdyn_playbookinstance_Appointments](msdyn_playbookinstance.md#BKMK_msdyn_playbookinstance_Appointments) One-To-Many relationship.

### <a name="BKMK_Invoice_Appointments"></a> Invoice_Appointments

**Added by**: Sales Solution

See invoice Entity [Invoice_Appointments](invoice.md#BKMK_Invoice_Appointments) One-To-Many relationship.

### <a name="BKMK_Opportunity_Appointments"></a> Opportunity_Appointments

**Added by**: Sales Solution

See opportunity Entity [Opportunity_Appointments](opportunity.md#BKMK_Opportunity_Appointments) One-To-Many relationship.

### <a name="BKMK_Quote_Appointments"></a> Quote_Appointments

**Added by**: Sales Solution

See quote Entity [Quote_Appointments](quote.md#BKMK_Quote_Appointments) One-To-Many relationship.

### <a name="BKMK_SalesOrder_Appointments"></a> SalesOrder_Appointments

**Added by**: Sales Solution

See salesorder Entity [SalesOrder_Appointments](salesorder.md#BKMK_SalesOrder_Appointments) One-To-Many relationship.

### <a name="BKMK_msdyn_postalbum_Appointments"></a> msdyn_postalbum_Appointments

**Added by**: Activity Feeds Solution

See msdyn_postalbum Entity [msdyn_postalbum_Appointments](msdyn_postalbum.md#BKMK_msdyn_postalbum_Appointments) One-To-Many relationship.

### <a name="BKMK_msdyn_bookingalertstatus_Appointments"></a> msdyn_bookingalertstatus_Appointments

**Added by**: Universal Resource Scheduling Solution

See msdyn_bookingalertstatus Entity [msdyn_bookingalertstatus_Appointments](msdyn_bookingalertstatus.md#BKMK_msdyn_bookingalertstatus_Appointments) One-To-Many relationship.

### <a name="BKMK_msdyn_bookingrule_Appointments"></a> msdyn_bookingrule_Appointments

**Added by**: Universal Resource Scheduling Solution

See msdyn_bookingrule Entity [msdyn_bookingrule_Appointments](msdyn_bookingrule.md#BKMK_msdyn_bookingrule_Appointments) One-To-Many relationship.

### <a name="BKMK_msdyn_resourceterritory_Appointments"></a> msdyn_resourceterritory_Appointments

**Added by**: Universal Resource Scheduling Solution

See msdyn_resourceterritory Entity [msdyn_resourceterritory_Appointments](msdyn_resourceterritory.md#BKMK_msdyn_resourceterritory_Appointments) One-To-Many relationship.

### <a name="BKMK_msdyn_systemuserschedulersetting_Appointments"></a> msdyn_systemuserschedulersetting_Appointments

**Added by**: Universal Resource Scheduling Solution

See msdyn_systemuserschedulersetting Entity [msdyn_systemuserschedulersetting_Appointments](msdyn_systemuserschedulersetting.md#BKMK_msdyn_systemuserschedulersetting_Appointments) One-To-Many relationship.

### <a name="BKMK_msdyn_timegroup_Appointments"></a> msdyn_timegroup_Appointments

**Added by**: Universal Resource Scheduling Solution

See msdyn_timegroup Entity [msdyn_timegroup_Appointments](msdyn_timegroup.md#BKMK_msdyn_timegroup_Appointments) One-To-Many relationship.

### <a name="BKMK_msdyn_timegroupdetail_Appointments"></a> msdyn_timegroupdetail_Appointments

**Added by**: Universal Resource Scheduling Solution

See msdyn_timegroupdetail Entity [msdyn_timegroupdetail_Appointments](msdyn_timegroupdetail.md#BKMK_msdyn_timegroupdetail_Appointments) One-To-Many relationship.

### <a name="BKMK_msdyn_processnotes_Appointments"></a> msdyn_processnotes_Appointments

**Added by**: Project Service Automation Solution

See msdyn_processnotes Entity [msdyn_processnotes_Appointments](msdyn_processnotes.md#BKMK_msdyn_processnotes_Appointments) One-To-Many relationship.

### <a name="BKMK_msdyn_projectteam_Appointments"></a> msdyn_projectteam_Appointments

**Added by**: Project Service Automation Solution

See msdyn_projectteam Entity [msdyn_projectteam_Appointments](msdyn_projectteam.md#BKMK_msdyn_projectteam_Appointments) One-To-Many relationship.

### <a name="BKMK_msdyn_agreement_Appointments"></a> msdyn_agreement_Appointments

**Added by**: Field Service Solution

See msdyn_agreement Entity [msdyn_agreement_Appointments](msdyn_agreement.md#BKMK_msdyn_agreement_Appointments) One-To-Many relationship.

### <a name="BKMK_msdyn_agreementbookingdate_Appointments"></a> msdyn_agreementbookingdate_Appointments

**Added by**: Field Service Solution

See msdyn_agreementbookingdate Entity [msdyn_agreementbookingdate_Appointments](msdyn_agreementbookingdate.md#BKMK_msdyn_agreementbookingdate_Appointments) One-To-Many relationship.

### <a name="BKMK_msdyn_agreementbookingincident_Appointments"></a> msdyn_agreementbookingincident_Appointments

**Added by**: Field Service Solution

See msdyn_agreementbookingincident Entity [msdyn_agreementbookingincident_Appointments](msdyn_agreementbookingincident.md#BKMK_msdyn_agreementbookingincident_Appointments) One-To-Many relationship.

### <a name="BKMK_msdyn_agreementbookingproduct_Appointments"></a> msdyn_agreementbookingproduct_Appointments

**Added by**: Field Service Solution

See msdyn_agreementbookingproduct Entity [msdyn_agreementbookingproduct_Appointments](msdyn_agreementbookingproduct.md#BKMK_msdyn_agreementbookingproduct_Appointments) One-To-Many relationship.

### <a name="BKMK_msdyn_agreementbookingservice_Appointments"></a> msdyn_agreementbookingservice_Appointments

**Added by**: Field Service Solution

See msdyn_agreementbookingservice Entity [msdyn_agreementbookingservice_Appointments](msdyn_agreementbookingservice.md#BKMK_msdyn_agreementbookingservice_Appointments) One-To-Many relationship.

### <a name="BKMK_msdyn_agreementbookingservicetask_Appointments"></a> msdyn_agreementbookingservicetask_Appointments

**Added by**: Field Service Solution

See msdyn_agreementbookingservicetask Entity [msdyn_agreementbookingservicetask_Appointments](msdyn_agreementbookingservicetask.md#BKMK_msdyn_agreementbookingservicetask_Appointments) One-To-Many relationship.

### <a name="BKMK_msdyn_agreementbookingsetup_Appointments"></a> msdyn_agreementbookingsetup_Appointments

**Added by**: Field Service Solution

See msdyn_agreementbookingsetup Entity [msdyn_agreementbookingsetup_Appointments](msdyn_agreementbookingsetup.md#BKMK_msdyn_agreementbookingsetup_Appointments) One-To-Many relationship.

### <a name="BKMK_msdyn_agreementinvoicedate_Appointments"></a> msdyn_agreementinvoicedate_Appointments

**Added by**: Field Service Solution

See msdyn_agreementinvoicedate Entity [msdyn_agreementinvoicedate_Appointments](msdyn_agreementinvoicedate.md#BKMK_msdyn_agreementinvoicedate_Appointments) One-To-Many relationship.

### <a name="BKMK_msdyn_agreementinvoiceproduct_Appointments"></a> msdyn_agreementinvoiceproduct_Appointments

**Added by**: Field Service Solution

See msdyn_agreementinvoiceproduct Entity [msdyn_agreementinvoiceproduct_Appointments](msdyn_agreementinvoiceproduct.md#BKMK_msdyn_agreementinvoiceproduct_Appointments) One-To-Many relationship.

### <a name="BKMK_msdyn_agreementinvoicesetup_Appointments"></a> msdyn_agreementinvoicesetup_Appointments

**Added by**: Field Service Solution

See msdyn_agreementinvoicesetup Entity [msdyn_agreementinvoicesetup_Appointments](msdyn_agreementinvoicesetup.md#BKMK_msdyn_agreementinvoicesetup_Appointments) One-To-Many relationship.

### <a name="BKMK_msdyn_bookingtimestamp_Appointments"></a> msdyn_bookingtimestamp_Appointments

**Added by**: Field Service Solution

See msdyn_bookingtimestamp Entity [msdyn_bookingtimestamp_Appointments](msdyn_bookingtimestamp.md#BKMK_msdyn_bookingtimestamp_Appointments) One-To-Many relationship.

### <a name="BKMK_msdyn_customerasset_Appointments"></a> msdyn_customerasset_Appointments

**Added by**: Field Service Solution

See msdyn_customerasset Entity [msdyn_customerasset_Appointments](msdyn_customerasset.md#BKMK_msdyn_customerasset_Appointments) One-To-Many relationship.

### <a name="BKMK_msdyn_fieldservicesetting_Appointments"></a> msdyn_fieldservicesetting_Appointments

**Added by**: Field Service Solution

See msdyn_fieldservicesetting Entity [msdyn_fieldservicesetting_Appointments](msdyn_fieldservicesetting.md#BKMK_msdyn_fieldservicesetting_Appointments) One-To-Many relationship.

### <a name="BKMK_msdyn_incidenttypecharacteristic_Appointments"></a> msdyn_incidenttypecharacteristic_Appointments

**Added by**: Field Service Solution

See msdyn_incidenttypecharacteristic Entity [msdyn_incidenttypecharacteristic_Appointments](msdyn_incidenttypecharacteristic.md#BKMK_msdyn_incidenttypecharacteristic_Appointments) One-To-Many relationship.

### <a name="BKMK_msdyn_incidenttypeproduct_Appointments"></a> msdyn_incidenttypeproduct_Appointments

**Added by**: Field Service Solution

See msdyn_incidenttypeproduct Entity [msdyn_incidenttypeproduct_Appointments](msdyn_incidenttypeproduct.md#BKMK_msdyn_incidenttypeproduct_Appointments) One-To-Many relationship.

### <a name="BKMK_msdyn_incidenttypeservice_Appointments"></a> msdyn_incidenttypeservice_Appointments

**Added by**: Field Service Solution

See msdyn_incidenttypeservice Entity [msdyn_incidenttypeservice_Appointments](msdyn_incidenttypeservice.md#BKMK_msdyn_incidenttypeservice_Appointments) One-To-Many relationship.

### <a name="BKMK_msdyn_inventoryadjustment_Appointments"></a> msdyn_inventoryadjustment_Appointments

**Added by**: Field Service Solution

See msdyn_inventoryadjustment Entity [msdyn_inventoryadjustment_Appointments](msdyn_inventoryadjustment.md#BKMK_msdyn_inventoryadjustment_Appointments) One-To-Many relationship.

### <a name="BKMK_msdyn_inventoryadjustmentproduct_Appointments"></a> msdyn_inventoryadjustmentproduct_Appointments

**Added by**: Field Service Solution

See msdyn_inventoryadjustmentproduct Entity [msdyn_inventoryadjustmentproduct_Appointments](msdyn_inventoryadjustmentproduct.md#BKMK_msdyn_inventoryadjustmentproduct_Appointments) One-To-Many relationship.

### <a name="BKMK_msdyn_inventoryjournal_Appointments"></a> msdyn_inventoryjournal_Appointments

**Added by**: Field Service Solution

See msdyn_inventoryjournal Entity [msdyn_inventoryjournal_Appointments](msdyn_inventoryjournal.md#BKMK_msdyn_inventoryjournal_Appointments) One-To-Many relationship.

### <a name="BKMK_msdyn_inventorytransfer_Appointments"></a> msdyn_inventorytransfer_Appointments

**Added by**: Field Service Solution

See msdyn_inventorytransfer Entity [msdyn_inventorytransfer_Appointments](msdyn_inventorytransfer.md#BKMK_msdyn_inventorytransfer_Appointments) One-To-Many relationship.

### <a name="BKMK_msdyn_payment_Appointments"></a> msdyn_payment_Appointments

**Added by**: Field Service Solution

See msdyn_payment Entity [msdyn_payment_Appointments](msdyn_payment.md#BKMK_msdyn_payment_Appointments) One-To-Many relationship.

### <a name="BKMK_msdyn_paymentdetail_Appointments"></a> msdyn_paymentdetail_Appointments

**Added by**: Field Service Solution

See msdyn_paymentdetail Entity [msdyn_paymentdetail_Appointments](msdyn_paymentdetail.md#BKMK_msdyn_paymentdetail_Appointments) One-To-Many relationship.

### <a name="BKMK_msdyn_paymentmethod_Appointments"></a> msdyn_paymentmethod_Appointments

**Added by**: Field Service Solution

See msdyn_paymentmethod Entity [msdyn_paymentmethod_Appointments](msdyn_paymentmethod.md#BKMK_msdyn_paymentmethod_Appointments) One-To-Many relationship.

### <a name="BKMK_msdyn_paymentterm_Appointments"></a> msdyn_paymentterm_Appointments

**Added by**: Field Service Solution

See msdyn_paymentterm Entity [msdyn_paymentterm_Appointments](msdyn_paymentterm.md#BKMK_msdyn_paymentterm_Appointments) One-To-Many relationship.

### <a name="BKMK_msdyn_postalcode_Appointments"></a> msdyn_postalcode_Appointments

**Added by**: Field Service Solution

See msdyn_postalcode Entity [msdyn_postalcode_Appointments](msdyn_postalcode.md#BKMK_msdyn_postalcode_Appointments) One-To-Many relationship.

### <a name="BKMK_msdyn_productinventory_Appointments"></a> msdyn_productinventory_Appointments

**Added by**: Field Service Solution

See msdyn_productinventory Entity [msdyn_productinventory_Appointments](msdyn_productinventory.md#BKMK_msdyn_productinventory_Appointments) One-To-Many relationship.

### <a name="BKMK_msdyn_purchaseorder_Appointments"></a> msdyn_purchaseorder_Appointments

**Added by**: Field Service Solution

See msdyn_purchaseorder Entity [msdyn_purchaseorder_Appointments](msdyn_purchaseorder.md#BKMK_msdyn_purchaseorder_Appointments) One-To-Many relationship.

### <a name="BKMK_msdyn_purchaseorderbill_Appointments"></a> msdyn_purchaseorderbill_Appointments

**Added by**: Field Service Solution

See msdyn_purchaseorderbill Entity [msdyn_purchaseorderbill_Appointments](msdyn_purchaseorderbill.md#BKMK_msdyn_purchaseorderbill_Appointments) One-To-Many relationship.

### <a name="BKMK_msdyn_purchaseorderproduct_Appointments"></a> msdyn_purchaseorderproduct_Appointments

**Added by**: Field Service Solution

See msdyn_purchaseorderproduct Entity [msdyn_purchaseorderproduct_Appointments](msdyn_purchaseorderproduct.md#BKMK_msdyn_purchaseorderproduct_Appointments) One-To-Many relationship.

### <a name="BKMK_msdyn_purchaseorderreceipt_Appointments"></a> msdyn_purchaseorderreceipt_Appointments

**Added by**: Field Service Solution

See msdyn_purchaseorderreceipt Entity [msdyn_purchaseorderreceipt_Appointments](msdyn_purchaseorderreceipt.md#BKMK_msdyn_purchaseorderreceipt_Appointments) One-To-Many relationship.

### <a name="BKMK_msdyn_purchaseorderreceiptproduct_Appointments"></a> msdyn_purchaseorderreceiptproduct_Appointments

**Added by**: Field Service Solution

See msdyn_purchaseorderreceiptproduct Entity [msdyn_purchaseorderreceiptproduct_Appointments](msdyn_purchaseorderreceiptproduct.md#BKMK_msdyn_purchaseorderreceiptproduct_Appointments) One-To-Many relationship.

### <a name="BKMK_msdyn_purchaseordersubstatus_Appointments"></a> msdyn_purchaseordersubstatus_Appointments

**Added by**: Field Service Solution

See msdyn_purchaseordersubstatus Entity [msdyn_purchaseordersubstatus_Appointments](msdyn_purchaseordersubstatus.md#BKMK_msdyn_purchaseordersubstatus_Appointments) One-To-Many relationship.

### <a name="BKMK_msdyn_quotebookingincident_Appointments"></a> msdyn_quotebookingincident_Appointments

**Added by**: Field Service Solution

See msdyn_quotebookingincident Entity [msdyn_quotebookingincident_Appointments](msdyn_quotebookingincident.md#BKMK_msdyn_quotebookingincident_Appointments) One-To-Many relationship.

### <a name="BKMK_msdyn_quotebookingproduct_Appointments"></a> msdyn_quotebookingproduct_Appointments

**Added by**: Field Service Solution

See msdyn_quotebookingproduct Entity [msdyn_quotebookingproduct_Appointments](msdyn_quotebookingproduct.md#BKMK_msdyn_quotebookingproduct_Appointments) One-To-Many relationship.

### <a name="BKMK_msdyn_quotebookingservice_Appointments"></a> msdyn_quotebookingservice_Appointments

**Added by**: Field Service Solution

See msdyn_quotebookingservice Entity [msdyn_quotebookingservice_Appointments](msdyn_quotebookingservice.md#BKMK_msdyn_quotebookingservice_Appointments) One-To-Many relationship.

### <a name="BKMK_msdyn_quotebookingservicetask_Appointments"></a> msdyn_quotebookingservicetask_Appointments

**Added by**: Field Service Solution

See msdyn_quotebookingservicetask Entity [msdyn_quotebookingservicetask_Appointments](msdyn_quotebookingservicetask.md#BKMK_msdyn_quotebookingservicetask_Appointments) One-To-Many relationship.

### <a name="BKMK_msdyn_rma_Appointments"></a> msdyn_rma_Appointments

**Added by**: Field Service Solution

See msdyn_rma Entity [msdyn_rma_Appointments](msdyn_rma.md#BKMK_msdyn_rma_Appointments) One-To-Many relationship.

### <a name="BKMK_msdyn_rmaproduct_Appointments"></a> msdyn_rmaproduct_Appointments

**Added by**: Field Service Solution

See msdyn_rmaproduct Entity [msdyn_rmaproduct_Appointments](msdyn_rmaproduct.md#BKMK_msdyn_rmaproduct_Appointments) One-To-Many relationship.

### <a name="BKMK_msdyn_rmareceipt_Appointments"></a> msdyn_rmareceipt_Appointments

**Added by**: Field Service Solution

See msdyn_rmareceipt Entity [msdyn_rmareceipt_Appointments](msdyn_rmareceipt.md#BKMK_msdyn_rmareceipt_Appointments) One-To-Many relationship.

### <a name="BKMK_msdyn_rmareceiptproduct_Appointments"></a> msdyn_rmareceiptproduct_Appointments

**Added by**: Field Service Solution

See msdyn_rmareceiptproduct Entity [msdyn_rmareceiptproduct_Appointments](msdyn_rmareceiptproduct.md#BKMK_msdyn_rmareceiptproduct_Appointments) One-To-Many relationship.

### <a name="BKMK_msdyn_rmasubstatus_Appointments"></a> msdyn_rmasubstatus_Appointments

**Added by**: Field Service Solution

See msdyn_rmasubstatus Entity [msdyn_rmasubstatus_Appointments](msdyn_rmasubstatus.md#BKMK_msdyn_rmasubstatus_Appointments) One-To-Many relationship.

### <a name="BKMK_msdyn_rtv_Appointments"></a> msdyn_rtv_Appointments

**Added by**: Field Service Solution

See msdyn_rtv Entity [msdyn_rtv_Appointments](msdyn_rtv.md#BKMK_msdyn_rtv_Appointments) One-To-Many relationship.

### <a name="BKMK_msdyn_rtvproduct_Appointments"></a> msdyn_rtvproduct_Appointments

**Added by**: Field Service Solution

See msdyn_rtvproduct Entity [msdyn_rtvproduct_Appointments](msdyn_rtvproduct.md#BKMK_msdyn_rtvproduct_Appointments) One-To-Many relationship.

### <a name="BKMK_msdyn_rtvsubstatus_Appointments"></a> msdyn_rtvsubstatus_Appointments

**Added by**: Field Service Solution

See msdyn_rtvsubstatus Entity [msdyn_rtvsubstatus_Appointments](msdyn_rtvsubstatus.md#BKMK_msdyn_rtvsubstatus_Appointments) One-To-Many relationship.

### <a name="BKMK_msdyn_shipvia_Appointments"></a> msdyn_shipvia_Appointments

**Added by**: Field Service Solution

See msdyn_shipvia Entity [msdyn_shipvia_Appointments](msdyn_shipvia.md#BKMK_msdyn_shipvia_Appointments) One-To-Many relationship.

### <a name="BKMK_msdyn_timeoffrequest_Appointments"></a> msdyn_timeoffrequest_Appointments

**Added by**: Field Service Solution

See msdyn_timeoffrequest Entity [msdyn_timeoffrequest_Appointments](msdyn_timeoffrequest.md#BKMK_msdyn_timeoffrequest_Appointments) One-To-Many relationship.

### <a name="BKMK_msdyn_warehouse_Appointments"></a> msdyn_warehouse_Appointments

**Added by**: Field Service Solution

See msdyn_warehouse Entity [msdyn_warehouse_Appointments](msdyn_warehouse.md#BKMK_msdyn_warehouse_Appointments) One-To-Many relationship.

### <a name="BKMK_msdyn_workorder_Appointments"></a> msdyn_workorder_Appointments

**Added by**: Field Service Solution

See msdyn_workorder Entity [msdyn_workorder_Appointments](msdyn_workorder.md#BKMK_msdyn_workorder_Appointments) One-To-Many relationship.

### <a name="BKMK_msdyn_workordercharacteristic_Appointments"></a> msdyn_workordercharacteristic_Appointments

**Added by**: Field Service Solution

See msdyn_workordercharacteristic Entity [msdyn_workordercharacteristic_Appointments](msdyn_workordercharacteristic.md#BKMK_msdyn_workordercharacteristic_Appointments) One-To-Many relationship.

### <a name="BKMK_msdyn_workorderincident_Appointments"></a> msdyn_workorderincident_Appointments

**Added by**: Field Service Solution

See msdyn_workorderincident Entity [msdyn_workorderincident_Appointments](msdyn_workorderincident.md#BKMK_msdyn_workorderincident_Appointments) One-To-Many relationship.

### <a name="BKMK_msdyn_workorderproduct_Appointments"></a> msdyn_workorderproduct_Appointments

**Added by**: Field Service Solution

See msdyn_workorderproduct Entity [msdyn_workorderproduct_Appointments](msdyn_workorderproduct.md#BKMK_msdyn_workorderproduct_Appointments) One-To-Many relationship.

### <a name="BKMK_msdyn_workorderresourcerestriction_Appointments"></a> msdyn_workorderresourcerestriction_Appointments

**Added by**: Field Service Solution

See msdyn_workorderresourcerestriction Entity [msdyn_workorderresourcerestriction_Appointments](msdyn_workorderresourcerestriction.md#BKMK_msdyn_workorderresourcerestriction_Appointments) One-To-Many relationship.

### <a name="BKMK_msdyn_workorderservice_Appointments"></a> msdyn_workorderservice_Appointments

**Added by**: Field Service Solution

See msdyn_workorderservice Entity [msdyn_workorderservice_Appointments](msdyn_workorderservice.md#BKMK_msdyn_workorderservice_Appointments) One-To-Many relationship.

### <a name="BKMK_msdyn_workorderservicetask_Appointments"></a> msdyn_workorderservicetask_Appointments

**Added by**: Field Service Solution

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

### See also

[About the Entity Reference](../about-entity-reference.md)<br />
[Programming reference for Dynamics 365 Customer Engagement](../programming-reference.md)<br />
[Web API Reference](/dynamics365/customer-engagement/web-api/about)<br />
<xref href="Microsoft.Dynamics.CRM.appointment?text=appointment EntityType" />

[!INCLUDE[footer-include](../../../../includes/footer-banner.md)]