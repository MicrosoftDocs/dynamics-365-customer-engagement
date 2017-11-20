---
title: "ServiceAppointment Entity Reference (Developer Guide for Dynamics 365 Customer Engagement)| MicrosoftDocs"
description: "Includes schema information and supported messages for the ServiceAppointment entity."
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
# ServiceAppointment Entity Reference

[!INCLUDE[](../../includes/cc_applies_to_update_9_0_0.md)]

Activity offered by the organization to satisfy its customer's needs. Each service activity includes date, time, duration, and required resources.

**Added by**: Service Solution<br />

## Messages

|Message|Web API Operation|SDK Assembly|
|-|-|-|
|Assign|PATCH [*org URI*]/api/data/v9.0/serviceappointments(*activityid*)<br />[Update](../webapi/update-delete-entities-using-web-api.md#basic-update) `ownerid` property.|<xref:Microsoft.Crm.Sdk.Messages.AssignRequest>|
|Book|<xref href="Microsoft.Dynamics.CRM.Book?text=Book Action" />|<xref:Microsoft.Crm.Sdk.Messages.BookRequest>|
|Create|POST [*org URI*]/api/data/v9.0/serviceappointments<br />See [Create](../webapi/create-entity-web-api.md)|<xref:Microsoft.Xrm.Sdk.Messages.CreateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Create*>|
|Delete|DELETE [*org URI*]/api/data/v9.0/serviceappointments(*activityid*)<br />See [Delete](../webapi/update-delete-entities-using-web-api.md#basic-delete)|<xref:Microsoft.Xrm.Sdk.Messages.DeleteRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Delete*>|
|GrantAccess|<xref href="Microsoft.Dynamics.CRM.GrantAccess?text=GrantAccess Action" />|<xref:Microsoft.Crm.Sdk.Messages.GrantAccessRequest>|
|ModifyAccess|<xref href="Microsoft.Dynamics.CRM.ModifyAccess?text=ModifyAccess Action" />|<xref:Microsoft.Crm.Sdk.Messages.ModifyAccessRequest>|
|Reschedule|<xref href="Microsoft.Dynamics.CRM.Reschedule?text=Reschedule Action" />|<xref:Microsoft.Crm.Sdk.Messages.RescheduleRequest>|
|Retrieve|GET [*org URI*]/api/data/v9.0/serviceappointments(*activityid*)<br />See [Retrieve](../webapi/retrieve-entity-using-web-api.md)|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Retrieve*>|
|RetrieveMultiple|GET [*org URI*]/api/data/v9.0/serviceappointments<br />See [Query Data](../webapi/query-data-web-api.md)|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveMultipleRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.RetrieveMultiple*>|
|RetrievePrincipalAccess|<xref href="Microsoft.Dynamics.CRM.RetrievePrincipalAccess?text=RetrievePrincipalAccess Function" />|<xref:Microsoft.Crm.Sdk.Messages.RetrievePrincipalAccessRequest>|
|RetrieveSharedPrincipalsAndAccess|<xref href="Microsoft.Dynamics.CRM.RetrieveSharedPrincipalsAndAccess?text=RetrieveSharedPrincipalsAndAccess Function" />|<xref:Microsoft.Crm.Sdk.Messages.RetrieveSharedPrincipalsAndAccessRequest>|
|RevokeAccess|<xref href="Microsoft.Dynamics.CRM.RevokeAccess?text=RevokeAccess Action" />|<xref:Microsoft.Crm.Sdk.Messages.RevokeAccessRequest>|
|SetState|PATCH [*org URI*]/api/data/v9.0/serviceappointments(*activityid*)<br />[Update](../webapi/update-delete-entities-using-web-api.md#basic-update) `statecode` and `statuscode` properties.|<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|
|Update|PATCH [*org URI*]/api/data/v9.0/serviceappointments(*activityid*)<br />See [Update](../webapi/update-delete-entities-using-web-api.md#basic-update)|<xref:Microsoft.Xrm.Sdk.Messages.UpdateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Update*>|
|Validate|<xref href="Microsoft.Dynamics.CRM.Validate?text=Validate Action" />|<xref:Microsoft.Crm.Sdk.Messages.ValidateRequest>|
|ValidateSavedQuery|<xref href="Microsoft.Dynamics.CRM.ValidateSavedQuery?text=ValidateSavedQuery Action" />|<xref:Microsoft.Crm.Sdk.Messages.ValidateSavedQueryRequest>|

## Entity Properties

**DisplayName**: Service Activity<br />
**DisplayCollectionName**: Service Activities<br />
**SchemaName**: ServiceAppointment<br />
**CollectionSchemaName**: ServiceAppointments<br />
**LogicalName**: serviceappointment<br />
**LogicalCollectionName**: serviceappointments<br />
**EntitySetName**: serviceappointments<br />
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
- [Community](#BKMK_Community)
- [Customers](#BKMK_Customers)
- [DeliveryPriorityCode](#BKMK_DeliveryPriorityCode)
- [Description](#BKMK_Description)
- [ExchangeItemId](#BKMK_ExchangeItemId)
- [ExchangeWebLink](#BKMK_ExchangeWebLink)
- [From](#BKMK_From)
- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [IsAllDayEvent](#BKMK_IsAllDayEvent)
- [IsBilled](#BKMK_IsBilled)
- [IsMapiPrivate](#BKMK_IsMapiPrivate)
- [IsWorkflowCreated](#BKMK_IsWorkflowCreated)
- [LastOnHoldTime](#BKMK_LastOnHoldTime)
- [LeftVoiceMail](#BKMK_LeftVoiceMail)
- [Location](#BKMK_Location)
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
- [SiteId](#BKMK_SiteId)
- [SLAId](#BKMK_SLAId)
- [SortDate](#BKMK_SortDate)
- [StageId](#BKMK_StageId)
- [StateCode](#BKMK_StateCode)
- [StatusCode](#BKMK_StatusCode)
- [Subcategory](#BKMK_Subcategory)
- [Subject](#BKMK_Subject)
- [SubscriptionId](#BKMK_SubscriptionId)
- [TimeZoneRuleVersionNumber](#BKMK_TimeZoneRuleVersionNumber)
- [To](#BKMK_To)
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

**Description**: Unique identifier of the service activity.<br />
**DisplayName**: Service Activity<br />
**LogicalName**: activityid<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: SystemRequired<br />
**IsValidForUpdate**: False<br />
**Type**: Uniqueidentifier<br />


### <a name="BKMK_ActualDurationMinutes"></a> ActualDurationMinutes

**Description**: Shows the value selected in the Duration field on the service activity at the time the service activity is closed as completed. The duration is used to report the time spent on the activity.<br />
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

**Description**: Enter the actual end date and time of the service activity. By default, it displays when the activity was closed or canceled.<br />
**DisplayName**: Actual End<br />
**LogicalName**: actualend<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: DateTime<br />
**DateTimeBehavior**: UserLocal<br />
**Format**: DateAndTime


### <a name="BKMK_ActualStart"></a> ActualStart

**Description**: Enter the actual start date and time for the service activity. By default, it displays when the activity was created.<br />
**DisplayName**: Actual Start<br />
**LogicalName**: actualstart<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: DateTime<br />
**DateTimeBehavior**: UserLocal<br />
**Format**: DateAndTime


### <a name="BKMK_BCC"></a> BCC

**Description**: Blind Carbon-copy (bcc) recipients of the activity.<br />
**DisplayName**: BCC<br />
**LogicalName**: bcc<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: PartyList<br />
**Targets**: account,contact,lead,systemuser


### <a name="BKMK_Category"></a> Category

**Description**: Type a category to identify the service activity type, such as routine maintenance or service call, to tie the service activity to a business group or function.<br />
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
**Targets**: account,contact,lead,systemuser


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

**Description**: Enter the accounts and contacts for whom the service activity is being performed.<br />
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

**Description**: Type additional information to describe the service activity, such as key talking points or objectives.<br />
**DisplayName**: Description<br />
**LogicalName**: description<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Memo<br />
**Format**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 2000


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


### <a name="BKMK_From"></a> From

**Description**: Person who the activity is from.<br />
**DisplayName**: From<br />
**LogicalName**: from<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: PartyList<br />
**Targets**: account,contact,lead,systemuser


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


### <a name="BKMK_IsAllDayEvent"></a> IsAllDayEvent

**Description**: Select whether the service activity is an all-day event to make sure the required resources are scheduled for the full day.<br />
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

**Description**: Information which specifies whether the service activity was billed as part of resolving a case.<br />
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

**Description**: Information which specifies if the service activity was created from a workflow rule.<br />
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


### <a name="BKMK_Location"></a> Location

**Description**: Type the location where the service activity will take place, such as a conference room, customer office, or other venue.<br />
**DisplayName**: Delivery Location<br />
**LogicalName**: location<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 500


### <a name="BKMK_OptionalAttendees"></a> OptionalAttendees

**Description**: List of optional attendees for the activity.<br />
**DisplayName**: Optional Attendees<br />
**LogicalName**: optionalattendees<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: PartyList<br />
**Targets**: account,contact,lead,systemuser


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

**Description**: Choose the record that the service activity relates to.<br />
**DisplayName**: Regarding<br />
**LogicalName**: regardingobjectid<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: account,bookableresourcebooking,bookableresourcebookingheader,bulkoperation,campaign,campaignactivity,contact,contract,entitlement,entitlementtemplate,incident,interactionforemail,invoice,knowledgearticle,knowledgebaserecord,lead,msdyn_agreement,msdyn_agreementbookingdate,msdyn_agreementbookingincident,msdyn_agreementbookingproduct,msdyn_agreementbookingservice,msdyn_agreementbookingservicetask,msdyn_agreementbookingsetup,msdyn_agreementinvoicedate,msdyn_agreementinvoiceproduct,msdyn_agreementinvoicesetup,msdyn_bookingalertstatus,msdyn_bookingrule,msdyn_bookingtimestamp,msdyn_customerasset,msdyn_fieldservicesetting,msdyn_incidenttypecharacteristic,msdyn_incidenttypeproduct,msdyn_incidenttypeservice,msdyn_inventoryadjustment,msdyn_inventoryadjustmentproduct,msdyn_inventoryjournal,msdyn_inventorytransfer,msdyn_payment,msdyn_paymentdetail,msdyn_paymentmethod,msdyn_paymentterm,msdyn_postalbum,msdyn_postalcode,msdyn_processnotes,msdyn_productinventory,msdyn_projectteam,msdyn_purchaseorder,msdyn_purchaseorderbill,msdyn_purchaseorderproduct,msdyn_purchaseorderreceipt,msdyn_purchaseorderreceiptproduct,msdyn_purchaseordersubstatus,msdyn_quotebookingincident,msdyn_quotebookingproduct,msdyn_quotebookingservice,msdyn_quotebookingservicetask,msdyn_resourceterritory,msdyn_rma,msdyn_rmaproduct,msdyn_rmareceipt,msdyn_rmareceiptproduct,msdyn_rmasubstatus,msdyn_rtv,msdyn_rtvproduct,msdyn_rtvsubstatus,msdyn_shipvia,msdyn_systemuserschedulersetting,msdyn_timegroup,msdyn_timegroupdetail,msdyn_timeoffrequest,msdyn_warehouse,msdyn_workorder,msdyn_workordercharacteristic,msdyn_workorderincident,msdyn_workorderproduct,msdyn_workorderresourcerestriction,msdyn_workorderservice,msdyn_workorderservicetask,opportunity,quote,salesorder,site


### <a name="BKMK_RegardingObjectTypeCode"></a> RegardingObjectTypeCode

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: regardingobjecttypecode<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: EntityName<br />


### <a name="BKMK_RequiredAttendees"></a> RequiredAttendees

**Description**: List of required attendees for the activity.<br />
**DisplayName**: Required Attendees<br />
**LogicalName**: requiredattendees<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: PartyList<br />
**Targets**: account,contact,lead,systemuser


### <a name="BKMK_Resources"></a> Resources

**Description**: Enter the user, facility, or equipment required to complete the service activity.<br />
**DisplayName**: Resources<br />
**LogicalName**: resources<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: PartyList<br />
**Targets**: equipment,systemuser


### <a name="BKMK_ScheduledDurationMinutes"></a> ScheduledDurationMinutes

**Description**: Shows the expected duration of the service activity, in minutes.<br />
**DisplayName**: Scheduled Duration<br />
**LogicalName**: scheduleddurationminutes<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Integer<br />
**Format**: Duration<br />
**MaxValue**: 2147483647<br />
**MinValue**: 0


### <a name="BKMK_ScheduledEnd"></a> ScheduledEnd

**Description**: Enter the expected due date and time.<br />
**DisplayName**: Scheduled End<br />
**LogicalName**: scheduledend<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: ApplicationRequired<br />
**Type**: DateTime<br />
**DateTimeBehavior**: UserLocal<br />
**Format**: DateAndTime


### <a name="BKMK_ScheduledStart"></a> ScheduledStart

**Description**: Enter the expected due date and time.<br />
**DisplayName**: Scheduled Start<br />
**LogicalName**: scheduledstart<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: ApplicationRequired<br />
**Type**: DateTime<br />
**DateTimeBehavior**: UserLocal<br />
**Format**: DateAndTime


### <a name="BKMK_ServiceId"></a> ServiceId

**Description**: Choose the service scheduled to be performed during the service activity.<br />
**DisplayName**: Service<br />
**LogicalName**: serviceid<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: ApplicationRequired<br />
**Type**: Lookup<br />
**Targets**: service


### <a name="BKMK_SiteId"></a> SiteId

**Description**: Choose the site or location where the service activity will be performed.<br />
**DisplayName**: Site<br />
**LogicalName**: siteid<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: site


### <a name="BKMK_SLAId"></a> SLAId

**Description**: Choose the service level agreement (SLA) that you want to apply to the service appointment record.<br />
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

**Description**: Shows whether the service activity is open, completed, or canceled. Completed and canceled service activities are read-only and can't be edited.<br />
**DisplayName**: Status<br />
**LogicalName**: statecode<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: SystemRequired<br />
**IsValidForCreate**: False<br />
**Type**: State<br />
**Options**:

- **Value**: 0 **Label**: Open **DefaultStatus**: 1 **InvariantName**: Open
- **Value**: 1 **Label**: Closed **DefaultStatus**: 8 **InvariantName**: Closed
- **Value**: 2 **Label**: Canceled **DefaultStatus**: 9 **InvariantName**: Canceled
- **Value**: 3 **Label**: Scheduled **DefaultStatus**: 3 **InvariantName**: Scheduled



### <a name="BKMK_StatusCode"></a> StatusCode

**Description**: Select the service activity's status.<br />
**DisplayName**: Status Reason<br />
**LogicalName**: statuscode<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Status<br />
**Options**:

- **Value**: 1 **Label**: Requested **State**: 0
- **Value**: 2 **Label**: Tentative **State**: 0
- **Value**: 3 **Label**: Pending **State**: 3
- **Value**: 4 **Label**: Reserved **State**: 3
- **Value**: 6 **Label**: In Progress **State**: 3
- **Value**: 7 **Label**: Arrived **State**: 3
- **Value**: 8 **Label**: Completed **State**: 1
- **Value**: 9 **Label**: Canceled **State**: 2
- **Value**: 10 **Label**: No Show **State**: 2



### <a name="BKMK_Subcategory"></a> Subcategory

**Description**: Type a subcategory to identify the service activity type and relate the activity to a specific product, service region, business group, or other function.<br />
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

**Description**: Type a short description about the objective or primary topic of the service activity.<br />
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
**MinValue**: -2147483648


### <a name="BKMK_To"></a> To

**Description**: Person who is the receiver of the activity.<br />
**DisplayName**: To<br />
**LogicalName**: to<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: PartyList<br />
**Targets**: account,contact,lead,systemuser


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
- [OwnerIdName](#BKMK_OwnerIdName)
- [OwnerIdYomiName](#BKMK_OwnerIdYomiName)
- [OwningBusinessUnit](#BKMK_OwningBusinessUnit)
- [OwningTeam](#BKMK_OwningTeam)
- [OwningUser](#BKMK_OwningUser)
- [PostponeActivityProcessingUntil](#BKMK_PostponeActivityProcessingUntil)
- [RegardingObjectIdName](#BKMK_RegardingObjectIdName)
- [RegardingObjectIdYomiName](#BKMK_RegardingObjectIdYomiName)
- [SenderMailboxId](#BKMK_SenderMailboxId)
- [SenderMailboxIdName](#BKMK_SenderMailboxIdName)
- [SentOn](#BKMK_SentOn)
- [SeriesId](#BKMK_SeriesId)
- [ServiceIdName](#BKMK_ServiceIdName)
- [SiteIdName](#BKMK_SiteIdName)
- [SLAInvokedId](#BKMK_SLAInvokedId)
- [SLAInvokedIdName](#BKMK_SLAInvokedIdName)
- [SLAName](#BKMK_SLAName)
- [TransactionCurrencyIdName](#BKMK_TransactionCurrencyIdName)
- [VersionNumber](#BKMK_VersionNumber)


### <a name="BKMK_ActivityTypeCode"></a> ActivityTypeCode

**Description**: Shows the type of activity.<br />
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


### <a name="BKMK_ServiceIdName"></a> ServiceIdName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: serviceidname<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: SystemRequired<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_SiteIdName"></a> SiteIdName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: siteidname<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: SystemRequired<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_SLAInvokedId"></a> SLAInvokedId

**Description**: Last SLA that was applied to this email. This field is for internal use only.<br />
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

- [serviceappointment_activity_parties](#BKMK_serviceappointment_activity_parties)
- [CampaignResponse_ServiceAppointments](#BKMK_CampaignResponse_ServiceAppointments)
- [ServiceAppointment_SyncErrors](#BKMK_ServiceAppointment_SyncErrors)
- [ServiceAppointment_AsyncOperations](#BKMK_ServiceAppointment_AsyncOperations)
- [serviceappointment_MailboxTrackingFolders](#BKMK_serviceappointment_MailboxTrackingFolders)
- [userentityinstancedata_serviceappointment](#BKMK_userentityinstancedata_serviceappointment)
- [ServiceAppointment_ProcessSessions](#BKMK_ServiceAppointment_ProcessSessions)
- [ServiceAppointment_BulkDeleteFailures](#BKMK_ServiceAppointment_BulkDeleteFailures)
- [serviceappointment_principalobjectattributeaccess](#BKMK_serviceappointment_principalobjectattributeaccess)
- [serviceappointment_connections1](#BKMK_serviceappointment_connections1)
- [serviceappointment_connections2](#BKMK_serviceappointment_connections2)
- [ServiceAppointment_QueueItem](#BKMK_ServiceAppointment_QueueItem)
- [ServiceAppointment_Annotation](#BKMK_ServiceAppointment_Annotation)
- [serviceappointment_actioncard](#BKMK_serviceappointment_actioncard)
- [slakpiinstance_serviceappointment](#BKMK_slakpiinstance_serviceappointment)


### <a name="BKMK_serviceappointment_activity_parties"></a> serviceappointment_activity_parties

Same as activityparty entity [serviceappointment_activity_parties](activityparty.md#BKMK_serviceappointment_activity_parties) Many-To-One relationship.

**ReferencingEntity**: activityparty<br />
**ReferencingAttribute**: activityid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: False<br />
**ReferencedEntityNavigationPropertyName**: serviceappointment_activity_parties<br />
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


### <a name="BKMK_CampaignResponse_ServiceAppointments"></a> CampaignResponse_ServiceAppointments

Same as campaignresponse entity [CampaignResponse_ServiceAppointments](campaignresponse.md#BKMK_CampaignResponse_ServiceAppointments) Many-To-One relationship.

**ReferencingEntity**: campaignresponse<br />
**ReferencingAttribute**: originatingactivityid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: CampaignResponse_ServiceAppointments<br />
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


### <a name="BKMK_ServiceAppointment_SyncErrors"></a> ServiceAppointment_SyncErrors

Same as syncerror entity [ServiceAppointment_SyncErrors](syncerror.md#BKMK_ServiceAppointment_SyncErrors) Many-To-One relationship.

**ReferencingEntity**: syncerror<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: ServiceAppointment_SyncErrors<br />
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


### <a name="BKMK_ServiceAppointment_AsyncOperations"></a> ServiceAppointment_AsyncOperations

Same as asyncoperation entity [ServiceAppointment_AsyncOperations](asyncoperation.md#BKMK_ServiceAppointment_AsyncOperations) Many-To-One relationship.

**ReferencingEntity**: asyncoperation<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: False<br />
**ReferencedEntityNavigationPropertyName**: ServiceAppointment_AsyncOperations<br />
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


### <a name="BKMK_serviceappointment_MailboxTrackingFolders"></a> serviceappointment_MailboxTrackingFolders

Same as mailboxtrackingfolder entity [serviceappointment_MailboxTrackingFolders](mailboxtrackingfolder.md#BKMK_serviceappointment_MailboxTrackingFolders) Many-To-One relationship.

**ReferencingEntity**: mailboxtrackingfolder<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: serviceappointment_MailboxTrackingFolders<br />
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


### <a name="BKMK_userentityinstancedata_serviceappointment"></a> userentityinstancedata_serviceappointment

Same as userentityinstancedata entity [userentityinstancedata_serviceappointment](userentityinstancedata.md#BKMK_userentityinstancedata_serviceappointment) Many-To-One relationship.

**ReferencingEntity**: userentityinstancedata<br />
**ReferencingAttribute**: objectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: False<br />
**ReferencedEntityNavigationPropertyName**: userentityinstancedata_serviceappointment<br />
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


### <a name="BKMK_ServiceAppointment_ProcessSessions"></a> ServiceAppointment_ProcessSessions

Same as processsession entity [ServiceAppointment_ProcessSessions](processsession.md#BKMK_ServiceAppointment_ProcessSessions) Many-To-One relationship.

**ReferencingEntity**: processsession<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: False<br />
**ReferencedEntityNavigationPropertyName**: ServiceAppointment_ProcessSessions<br />
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


### <a name="BKMK_ServiceAppointment_BulkDeleteFailures"></a> ServiceAppointment_BulkDeleteFailures

Same as bulkdeletefailure entity [ServiceAppointment_BulkDeleteFailures](bulkdeletefailure.md#BKMK_ServiceAppointment_BulkDeleteFailures) Many-To-One relationship.

**ReferencingEntity**: bulkdeletefailure<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: False<br />
**ReferencedEntityNavigationPropertyName**: ServiceAppointment_BulkDeleteFailures<br />
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


### <a name="BKMK_serviceappointment_principalobjectattributeaccess"></a> serviceappointment_principalobjectattributeaccess

Same as principalobjectattributeaccess entity [serviceappointment_principalobjectattributeaccess](principalobjectattributeaccess.md#BKMK_serviceappointment_principalobjectattributeaccess) Many-To-One relationship.

**ReferencingEntity**: principalobjectattributeaccess<br />
**ReferencingAttribute**: objectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: False<br />
**ReferencedEntityNavigationPropertyName**: serviceappointment_principalobjectattributeaccess<br />
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


### <a name="BKMK_serviceappointment_connections1"></a> serviceappointment_connections1

Same as connection entity [serviceappointment_connections1](connection.md#BKMK_serviceappointment_connections1) Many-To-One relationship.

**ReferencingEntity**: connection<br />
**ReferencingAttribute**: record1id<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: serviceappointment_connections1<br />
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


### <a name="BKMK_serviceappointment_connections2"></a> serviceappointment_connections2

Same as connection entity [serviceappointment_connections2](connection.md#BKMK_serviceappointment_connections2) Many-To-One relationship.

**ReferencingEntity**: connection<br />
**ReferencingAttribute**: record2id<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: serviceappointment_connections2<br />
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


### <a name="BKMK_ServiceAppointment_QueueItem"></a> ServiceAppointment_QueueItem

Same as queueitem entity [ServiceAppointment_QueueItem](queueitem.md#BKMK_ServiceAppointment_QueueItem) Many-To-One relationship.

**ReferencingEntity**: queueitem<br />
**ReferencingAttribute**: objectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: ServiceAppointment_QueueItem<br />
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


### <a name="BKMK_ServiceAppointment_Annotation"></a> ServiceAppointment_Annotation

Same as annotation entity [ServiceAppointment_Annotation](annotation.md#BKMK_ServiceAppointment_Annotation) Many-To-One relationship.

**ReferencingEntity**: annotation<br />
**ReferencingAttribute**: objectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: ServiceAppointment_Annotation<br />
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


### <a name="BKMK_serviceappointment_actioncard"></a> serviceappointment_actioncard

Same as actioncard entity [serviceappointment_actioncard](actioncard.md#BKMK_serviceappointment_actioncard) Many-To-One relationship.

**ReferencingEntity**: actioncard<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: serviceappointment_actioncard<br />
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


### <a name="BKMK_slakpiinstance_serviceappointment"></a> slakpiinstance_serviceappointment

Same as slakpiinstance entity [slakpiinstance_serviceappointment](slakpiinstance.md#BKMK_slakpiinstance_serviceappointment) Many-To-One relationship.

**ReferencingEntity**: slakpiinstance<br />
**ReferencingAttribute**: regarding<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: slakpiinstance_serviceappointment<br />
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

- [Lead_ServiceAppointments](#BKMK_Lead_ServiceAppointments)
- [bookableresourcebooking_ServiceAppointments](#BKMK_bookableresourcebooking_ServiceAppointments)
- [bookableresourcebookingheader_ServiceAppointments](#BKMK_bookableresourcebookingheader_ServiceAppointments)
- [bulkoperation_ServiceAppointments](#BKMK_bulkoperation_ServiceAppointments)
- [Campaign_ServiceAppointments](#BKMK_Campaign_ServiceAppointments)
- [campaignactivity_ServiceAppointments](#BKMK_campaignactivity_ServiceAppointments)
- [Contract_ServiceAppointments](#BKMK_Contract_ServiceAppointments)
- [entitlement_ServiceAppointments](#BKMK_entitlement_ServiceAppointments)
- [entitlementtemplate_ServiceAppointments](#BKMK_entitlementtemplate_ServiceAppointments)
- [Incident_ServiceAppointments](#BKMK_Incident_ServiceAppointments)
- [interactionforemail_ServiceAppointments](#BKMK_interactionforemail_ServiceAppointments)
- [KnowledgeBaseRecord_ServiceAppointments](#BKMK_KnowledgeBaseRecord_ServiceAppointments)
- [Account_ServiceAppointments](#BKMK_Account_ServiceAppointments)
- [lk_serviceappointment_createdby](#BKMK_lk_serviceappointment_createdby)
- [Contact_ServiceAppointments](#BKMK_Contact_ServiceAppointments)
- [serviceappointment_mailbox_sendermailboxid](#BKMK_serviceappointment_mailbox_sendermailboxid)
- [TransactionCurrency_ServiceAppointment](#BKMK_TransactionCurrency_ServiceAppointment)
- [system_user_service_appointments](#BKMK_system_user_service_appointments)
- [manualsla_serviceappointment](#BKMK_manualsla_serviceappointment)
- [business_unit_service_appointments](#BKMK_business_unit_service_appointments)
- [KnowledgeArticle_ServiceAppointments](#BKMK_KnowledgeArticle_ServiceAppointments)
- [lk_serviceappointment_modifiedonbehalfby](#BKMK_lk_serviceappointment_modifiedonbehalfby)
- [lk_serviceappointment_createdonbehalfby](#BKMK_lk_serviceappointment_createdonbehalfby)
- [lk_serviceappointment_modifiedby](#BKMK_lk_serviceappointment_modifiedby)
- [team_service_appointments](#BKMK_team_service_appointments)
- [sla_serviceappointment](#BKMK_sla_serviceappointment)
- [activity_pointer_service_appointment](#BKMK_activity_pointer_service_appointment)
- [site_ServiceAppointments](#BKMK_site_ServiceAppointments)
- [service_service_appointments](#BKMK_service_service_appointments)
- [site_service_appointments](#BKMK_site_service_appointments)
- [Invoice_ServiceAppointments](#BKMK_Invoice_ServiceAppointments)
- [Opportunity_ServiceAppointments](#BKMK_Opportunity_ServiceAppointments)
- [Quote_ServiceAppointments](#BKMK_Quote_ServiceAppointments)
- [SalesOrder_ServiceAppointments](#BKMK_SalesOrder_ServiceAppointments)
- [msdyn_postalbum_ServiceAppointments](#BKMK_msdyn_postalbum_ServiceAppointments)
- [msdyn_bookingalertstatus_ServiceAppointments](#BKMK_msdyn_bookingalertstatus_ServiceAppointments)
- [msdyn_bookingrule_ServiceAppointments](#BKMK_msdyn_bookingrule_ServiceAppointments)
- [msdyn_resourceterritory_ServiceAppointments](#BKMK_msdyn_resourceterritory_ServiceAppointments)
- [msdyn_systemuserschedulersetting_ServiceAppointments](#BKMK_msdyn_systemuserschedulersetting_ServiceAppointments)
- [msdyn_timegroup_ServiceAppointments](#BKMK_msdyn_timegroup_ServiceAppointments)
- [msdyn_timegroupdetail_ServiceAppointments](#BKMK_msdyn_timegroupdetail_ServiceAppointments)
- [msdyn_processnotes_ServiceAppointments](#BKMK_msdyn_processnotes_ServiceAppointments)
- [msdyn_projectteam_ServiceAppointments](#BKMK_msdyn_projectteam_ServiceAppointments)
- [msdyn_agreement_ServiceAppointments](#BKMK_msdyn_agreement_ServiceAppointments)
- [msdyn_agreementbookingdate_ServiceAppointments](#BKMK_msdyn_agreementbookingdate_ServiceAppointments)
- [msdyn_agreementbookingincident_ServiceAppointments](#BKMK_msdyn_agreementbookingincident_ServiceAppointments)
- [msdyn_agreementbookingproduct_ServiceAppointments](#BKMK_msdyn_agreementbookingproduct_ServiceAppointments)
- [msdyn_agreementbookingservice_ServiceAppointments](#BKMK_msdyn_agreementbookingservice_ServiceAppointments)
- [msdyn_agreementbookingservicetask_ServiceAppointments](#BKMK_msdyn_agreementbookingservicetask_ServiceAppointments)
- [msdyn_agreementbookingsetup_ServiceAppointments](#BKMK_msdyn_agreementbookingsetup_ServiceAppointments)
- [msdyn_agreementinvoicedate_ServiceAppointments](#BKMK_msdyn_agreementinvoicedate_ServiceAppointments)
- [msdyn_agreementinvoiceproduct_ServiceAppointments](#BKMK_msdyn_agreementinvoiceproduct_ServiceAppointments)
- [msdyn_agreementinvoicesetup_ServiceAppointments](#BKMK_msdyn_agreementinvoicesetup_ServiceAppointments)
- [msdyn_bookingtimestamp_ServiceAppointments](#BKMK_msdyn_bookingtimestamp_ServiceAppointments)
- [msdyn_customerasset_ServiceAppointments](#BKMK_msdyn_customerasset_ServiceAppointments)
- [msdyn_fieldservicesetting_ServiceAppointments](#BKMK_msdyn_fieldservicesetting_ServiceAppointments)
- [msdyn_incidenttypecharacteristic_ServiceAppointments](#BKMK_msdyn_incidenttypecharacteristic_ServiceAppointments)
- [msdyn_incidenttypeproduct_ServiceAppointments](#BKMK_msdyn_incidenttypeproduct_ServiceAppointments)
- [msdyn_incidenttypeservice_ServiceAppointments](#BKMK_msdyn_incidenttypeservice_ServiceAppointments)
- [msdyn_inventoryadjustment_ServiceAppointments](#BKMK_msdyn_inventoryadjustment_ServiceAppointments)
- [msdyn_inventoryadjustmentproduct_ServiceAppointments](#BKMK_msdyn_inventoryadjustmentproduct_ServiceAppointments)
- [msdyn_inventoryjournal_ServiceAppointments](#BKMK_msdyn_inventoryjournal_ServiceAppointments)
- [msdyn_inventorytransfer_ServiceAppointments](#BKMK_msdyn_inventorytransfer_ServiceAppointments)
- [msdyn_payment_ServiceAppointments](#BKMK_msdyn_payment_ServiceAppointments)
- [msdyn_paymentdetail_ServiceAppointments](#BKMK_msdyn_paymentdetail_ServiceAppointments)
- [msdyn_paymentmethod_ServiceAppointments](#BKMK_msdyn_paymentmethod_ServiceAppointments)
- [msdyn_paymentterm_ServiceAppointments](#BKMK_msdyn_paymentterm_ServiceAppointments)
- [msdyn_postalcode_ServiceAppointments](#BKMK_msdyn_postalcode_ServiceAppointments)
- [msdyn_productinventory_ServiceAppointments](#BKMK_msdyn_productinventory_ServiceAppointments)
- [msdyn_purchaseorder_ServiceAppointments](#BKMK_msdyn_purchaseorder_ServiceAppointments)
- [msdyn_purchaseorderbill_ServiceAppointments](#BKMK_msdyn_purchaseorderbill_ServiceAppointments)
- [msdyn_purchaseorderproduct_ServiceAppointments](#BKMK_msdyn_purchaseorderproduct_ServiceAppointments)
- [msdyn_purchaseorderreceipt_ServiceAppointments](#BKMK_msdyn_purchaseorderreceipt_ServiceAppointments)
- [msdyn_purchaseorderreceiptproduct_ServiceAppointments](#BKMK_msdyn_purchaseorderreceiptproduct_ServiceAppointments)
- [msdyn_purchaseordersubstatus_ServiceAppointments](#BKMK_msdyn_purchaseordersubstatus_ServiceAppointments)
- [msdyn_quotebookingincident_ServiceAppointments](#BKMK_msdyn_quotebookingincident_ServiceAppointments)
- [msdyn_quotebookingproduct_ServiceAppointments](#BKMK_msdyn_quotebookingproduct_ServiceAppointments)
- [msdyn_quotebookingservice_ServiceAppointments](#BKMK_msdyn_quotebookingservice_ServiceAppointments)
- [msdyn_quotebookingservicetask_ServiceAppointments](#BKMK_msdyn_quotebookingservicetask_ServiceAppointments)
- [msdyn_rma_ServiceAppointments](#BKMK_msdyn_rma_ServiceAppointments)
- [msdyn_rmaproduct_ServiceAppointments](#BKMK_msdyn_rmaproduct_ServiceAppointments)
- [msdyn_rmareceipt_ServiceAppointments](#BKMK_msdyn_rmareceipt_ServiceAppointments)
- [msdyn_rmareceiptproduct_ServiceAppointments](#BKMK_msdyn_rmareceiptproduct_ServiceAppointments)
- [msdyn_rmasubstatus_ServiceAppointments](#BKMK_msdyn_rmasubstatus_ServiceAppointments)
- [msdyn_rtv_ServiceAppointments](#BKMK_msdyn_rtv_ServiceAppointments)
- [msdyn_rtvproduct_ServiceAppointments](#BKMK_msdyn_rtvproduct_ServiceAppointments)
- [msdyn_rtvsubstatus_ServiceAppointments](#BKMK_msdyn_rtvsubstatus_ServiceAppointments)
- [msdyn_shipvia_ServiceAppointments](#BKMK_msdyn_shipvia_ServiceAppointments)
- [msdyn_timeoffrequest_ServiceAppointments](#BKMK_msdyn_timeoffrequest_ServiceAppointments)
- [msdyn_warehouse_ServiceAppointments](#BKMK_msdyn_warehouse_ServiceAppointments)
- [msdyn_workorder_ServiceAppointments](#BKMK_msdyn_workorder_ServiceAppointments)
- [msdyn_workordercharacteristic_ServiceAppointments](#BKMK_msdyn_workordercharacteristic_ServiceAppointments)
- [msdyn_workorderincident_ServiceAppointments](#BKMK_msdyn_workorderincident_ServiceAppointments)
- [msdyn_workorderproduct_ServiceAppointments](#BKMK_msdyn_workorderproduct_ServiceAppointments)
- [msdyn_workorderresourcerestriction_ServiceAppointments](#BKMK_msdyn_workorderresourcerestriction_ServiceAppointments)
- [msdyn_workorderservice_ServiceAppointments](#BKMK_msdyn_workorderservice_ServiceAppointments)
- [msdyn_workorderservicetask_ServiceAppointments](#BKMK_msdyn_workorderservicetask_ServiceAppointments)


### <a name="BKMK_Lead_ServiceAppointments"></a> Lead_ServiceAppointments

See lead Entity [Lead_ServiceAppointments](lead.md#BKMK_Lead_ServiceAppointments) One-To-Many relationship.

### <a name="BKMK_bookableresourcebooking_ServiceAppointments"></a> bookableresourcebooking_ServiceAppointments

See bookableresourcebooking Entity [bookableresourcebooking_ServiceAppointments](bookableresourcebooking.md#BKMK_bookableresourcebooking_ServiceAppointments) One-To-Many relationship.

### <a name="BKMK_bookableresourcebookingheader_ServiceAppointments"></a> bookableresourcebookingheader_ServiceAppointments

See bookableresourcebookingheader Entity [bookableresourcebookingheader_ServiceAppointments](bookableresourcebookingheader.md#BKMK_bookableresourcebookingheader_ServiceAppointments) One-To-Many relationship.

### <a name="BKMK_bulkoperation_ServiceAppointments"></a> bulkoperation_ServiceAppointments

See bulkoperation Entity [bulkoperation_ServiceAppointments](bulkoperation.md#BKMK_bulkoperation_ServiceAppointments) One-To-Many relationship.

### <a name="BKMK_Campaign_ServiceAppointments"></a> Campaign_ServiceAppointments

See campaign Entity [Campaign_ServiceAppointments](campaign.md#BKMK_Campaign_ServiceAppointments) One-To-Many relationship.

### <a name="BKMK_campaignactivity_ServiceAppointments"></a> campaignactivity_ServiceAppointments

See campaignactivity Entity [campaignactivity_ServiceAppointments](campaignactivity.md#BKMK_campaignactivity_ServiceAppointments) One-To-Many relationship.

### <a name="BKMK_Contract_ServiceAppointments"></a> Contract_ServiceAppointments

See contract Entity [Contract_ServiceAppointments](contract.md#BKMK_Contract_ServiceAppointments) One-To-Many relationship.

### <a name="BKMK_entitlement_ServiceAppointments"></a> entitlement_ServiceAppointments

See entitlement Entity [entitlement_ServiceAppointments](entitlement.md#BKMK_entitlement_ServiceAppointments) One-To-Many relationship.

### <a name="BKMK_entitlementtemplate_ServiceAppointments"></a> entitlementtemplate_ServiceAppointments

See entitlementtemplate Entity [entitlementtemplate_ServiceAppointments](entitlementtemplate.md#BKMK_entitlementtemplate_ServiceAppointments) One-To-Many relationship.

### <a name="BKMK_Incident_ServiceAppointments"></a> Incident_ServiceAppointments

See incident Entity [Incident_ServiceAppointments](incident.md#BKMK_Incident_ServiceAppointments) One-To-Many relationship.

### <a name="BKMK_interactionforemail_ServiceAppointments"></a> interactionforemail_ServiceAppointments

See interactionforemail Entity [interactionforemail_ServiceAppointments](interactionforemail.md#BKMK_interactionforemail_ServiceAppointments) One-To-Many relationship.

### <a name="BKMK_KnowledgeBaseRecord_ServiceAppointments"></a> KnowledgeBaseRecord_ServiceAppointments

See knowledgebaserecord Entity [KnowledgeBaseRecord_ServiceAppointments](knowledgebaserecord.md#BKMK_KnowledgeBaseRecord_ServiceAppointments) One-To-Many relationship.

### <a name="BKMK_Account_ServiceAppointments"></a> Account_ServiceAppointments

See account Entity [Account_ServiceAppointments](account.md#BKMK_Account_ServiceAppointments) One-To-Many relationship.

### <a name="BKMK_lk_serviceappointment_createdby"></a> lk_serviceappointment_createdby

See systemuser Entity [lk_serviceappointment_createdby](systemuser.md#BKMK_lk_serviceappointment_createdby) One-To-Many relationship.

### <a name="BKMK_Contact_ServiceAppointments"></a> Contact_ServiceAppointments

See contact Entity [Contact_ServiceAppointments](contact.md#BKMK_Contact_ServiceAppointments) One-To-Many relationship.

### <a name="BKMK_serviceappointment_mailbox_sendermailboxid"></a> serviceappointment_mailbox_sendermailboxid

See mailbox Entity [serviceappointment_mailbox_sendermailboxid](mailbox.md#BKMK_serviceappointment_mailbox_sendermailboxid) One-To-Many relationship.

### <a name="BKMK_TransactionCurrency_ServiceAppointment"></a> TransactionCurrency_ServiceAppointment

See transactioncurrency Entity [TransactionCurrency_ServiceAppointment](transactioncurrency.md#BKMK_TransactionCurrency_ServiceAppointment) One-To-Many relationship.

### <a name="BKMK_system_user_service_appointments"></a> system_user_service_appointments

See systemuser Entity [system_user_service_appointments](systemuser.md#BKMK_system_user_service_appointments) One-To-Many relationship.

### <a name="BKMK_manualsla_serviceappointment"></a> manualsla_serviceappointment

See sla Entity [manualsla_serviceappointment](sla.md#BKMK_manualsla_serviceappointment) One-To-Many relationship.

### <a name="BKMK_business_unit_service_appointments"></a> business_unit_service_appointments

See businessunit Entity [business_unit_service_appointments](businessunit.md#BKMK_business_unit_service_appointments) One-To-Many relationship.

### <a name="BKMK_KnowledgeArticle_ServiceAppointments"></a> KnowledgeArticle_ServiceAppointments

See knowledgearticle Entity [KnowledgeArticle_ServiceAppointments](knowledgearticle.md#BKMK_KnowledgeArticle_ServiceAppointments) One-To-Many relationship.

### <a name="BKMK_lk_serviceappointment_modifiedonbehalfby"></a> lk_serviceappointment_modifiedonbehalfby

See systemuser Entity [lk_serviceappointment_modifiedonbehalfby](systemuser.md#BKMK_lk_serviceappointment_modifiedonbehalfby) One-To-Many relationship.

### <a name="BKMK_lk_serviceappointment_createdonbehalfby"></a> lk_serviceappointment_createdonbehalfby

See systemuser Entity [lk_serviceappointment_createdonbehalfby](systemuser.md#BKMK_lk_serviceappointment_createdonbehalfby) One-To-Many relationship.

### <a name="BKMK_lk_serviceappointment_modifiedby"></a> lk_serviceappointment_modifiedby

See systemuser Entity [lk_serviceappointment_modifiedby](systemuser.md#BKMK_lk_serviceappointment_modifiedby) One-To-Many relationship.

### <a name="BKMK_team_service_appointments"></a> team_service_appointments

See team Entity [team_service_appointments](team.md#BKMK_team_service_appointments) One-To-Many relationship.

### <a name="BKMK_sla_serviceappointment"></a> sla_serviceappointment

See sla Entity [sla_serviceappointment](sla.md#BKMK_sla_serviceappointment) One-To-Many relationship.

### <a name="BKMK_activity_pointer_service_appointment"></a> activity_pointer_service_appointment

See activitypointer Entity [activity_pointer_service_appointment](activitypointer.md#BKMK_activity_pointer_service_appointment) One-To-Many relationship.

### <a name="BKMK_site_ServiceAppointments"></a> site_ServiceAppointments

See site Entity [site_ServiceAppointments](site.md#BKMK_site_ServiceAppointments) One-To-Many relationship.

### <a name="BKMK_service_service_appointments"></a> service_service_appointments

See service Entity [service_service_appointments](service.md#BKMK_service_service_appointments) One-To-Many relationship.

### <a name="BKMK_site_service_appointments"></a> site_service_appointments

See site Entity [site_service_appointments](site.md#BKMK_site_service_appointments) One-To-Many relationship.

### <a name="BKMK_Invoice_ServiceAppointments"></a> Invoice_ServiceAppointments

See invoice Entity [Invoice_ServiceAppointments](invoice.md#BKMK_Invoice_ServiceAppointments) One-To-Many relationship.

### <a name="BKMK_Opportunity_ServiceAppointments"></a> Opportunity_ServiceAppointments

See opportunity Entity [Opportunity_ServiceAppointments](opportunity.md#BKMK_Opportunity_ServiceAppointments) One-To-Many relationship.

### <a name="BKMK_Quote_ServiceAppointments"></a> Quote_ServiceAppointments

See quote Entity [Quote_ServiceAppointments](quote.md#BKMK_Quote_ServiceAppointments) One-To-Many relationship.

### <a name="BKMK_SalesOrder_ServiceAppointments"></a> SalesOrder_ServiceAppointments

See salesorder Entity [SalesOrder_ServiceAppointments](salesorder.md#BKMK_SalesOrder_ServiceAppointments) One-To-Many relationship.

### <a name="BKMK_msdyn_postalbum_ServiceAppointments"></a> msdyn_postalbum_ServiceAppointments

See msdyn_postalbum Entity [msdyn_postalbum_ServiceAppointments](msdyn_postalbum.md#BKMK_msdyn_postalbum_ServiceAppointments) One-To-Many relationship.

### <a name="BKMK_msdyn_bookingalertstatus_ServiceAppointments"></a> msdyn_bookingalertstatus_ServiceAppointments

See msdyn_bookingalertstatus Entity [msdyn_bookingalertstatus_ServiceAppointments](msdyn_bookingalertstatus.md#BKMK_msdyn_bookingalertstatus_ServiceAppointments) One-To-Many relationship.

### <a name="BKMK_msdyn_bookingrule_ServiceAppointments"></a> msdyn_bookingrule_ServiceAppointments

See msdyn_bookingrule Entity [msdyn_bookingrule_ServiceAppointments](msdyn_bookingrule.md#BKMK_msdyn_bookingrule_ServiceAppointments) One-To-Many relationship.

### <a name="BKMK_msdyn_resourceterritory_ServiceAppointments"></a> msdyn_resourceterritory_ServiceAppointments

See msdyn_resourceterritory Entity [msdyn_resourceterritory_ServiceAppointments](msdyn_resourceterritory.md#BKMK_msdyn_resourceterritory_ServiceAppointments) One-To-Many relationship.

### <a name="BKMK_msdyn_systemuserschedulersetting_ServiceAppointments"></a> msdyn_systemuserschedulersetting_ServiceAppointments

See msdyn_systemuserschedulersetting Entity [msdyn_systemuserschedulersetting_ServiceAppointments](msdyn_systemuserschedulersetting.md#BKMK_msdyn_systemuserschedulersetting_ServiceAppointments) One-To-Many relationship.

### <a name="BKMK_msdyn_timegroup_ServiceAppointments"></a> msdyn_timegroup_ServiceAppointments

See msdyn_timegroup Entity [msdyn_timegroup_ServiceAppointments](msdyn_timegroup.md#BKMK_msdyn_timegroup_ServiceAppointments) One-To-Many relationship.

### <a name="BKMK_msdyn_timegroupdetail_ServiceAppointments"></a> msdyn_timegroupdetail_ServiceAppointments

See msdyn_timegroupdetail Entity [msdyn_timegroupdetail_ServiceAppointments](msdyn_timegroupdetail.md#BKMK_msdyn_timegroupdetail_ServiceAppointments) One-To-Many relationship.

### <a name="BKMK_msdyn_processnotes_ServiceAppointments"></a> msdyn_processnotes_ServiceAppointments

See msdyn_processnotes Entity [msdyn_processnotes_ServiceAppointments](msdyn_processnotes.md#BKMK_msdyn_processnotes_ServiceAppointments) One-To-Many relationship.

### <a name="BKMK_msdyn_projectteam_ServiceAppointments"></a> msdyn_projectteam_ServiceAppointments

See msdyn_projectteam Entity [msdyn_projectteam_ServiceAppointments](msdyn_projectteam.md#BKMK_msdyn_projectteam_ServiceAppointments) One-To-Many relationship.

### <a name="BKMK_msdyn_agreement_ServiceAppointments"></a> msdyn_agreement_ServiceAppointments

See msdyn_agreement Entity [msdyn_agreement_ServiceAppointments](msdyn_agreement.md#BKMK_msdyn_agreement_ServiceAppointments) One-To-Many relationship.

### <a name="BKMK_msdyn_agreementbookingdate_ServiceAppointments"></a> msdyn_agreementbookingdate_ServiceAppointments

See msdyn_agreementbookingdate Entity [msdyn_agreementbookingdate_ServiceAppointments](msdyn_agreementbookingdate.md#BKMK_msdyn_agreementbookingdate_ServiceAppointments) One-To-Many relationship.

### <a name="BKMK_msdyn_agreementbookingincident_ServiceAppointments"></a> msdyn_agreementbookingincident_ServiceAppointments

See msdyn_agreementbookingincident Entity [msdyn_agreementbookingincident_ServiceAppointments](msdyn_agreementbookingincident.md#BKMK_msdyn_agreementbookingincident_ServiceAppointments) One-To-Many relationship.

### <a name="BKMK_msdyn_agreementbookingproduct_ServiceAppointments"></a> msdyn_agreementbookingproduct_ServiceAppointments

See msdyn_agreementbookingproduct Entity [msdyn_agreementbookingproduct_ServiceAppointments](msdyn_agreementbookingproduct.md#BKMK_msdyn_agreementbookingproduct_ServiceAppointments) One-To-Many relationship.

### <a name="BKMK_msdyn_agreementbookingservice_ServiceAppointments"></a> msdyn_agreementbookingservice_ServiceAppointments

See msdyn_agreementbookingservice Entity [msdyn_agreementbookingservice_ServiceAppointments](msdyn_agreementbookingservice.md#BKMK_msdyn_agreementbookingservice_ServiceAppointments) One-To-Many relationship.

### <a name="BKMK_msdyn_agreementbookingservicetask_ServiceAppointments"></a> msdyn_agreementbookingservicetask_ServiceAppointments

See msdyn_agreementbookingservicetask Entity [msdyn_agreementbookingservicetask_ServiceAppointments](msdyn_agreementbookingservicetask.md#BKMK_msdyn_agreementbookingservicetask_ServiceAppointments) One-To-Many relationship.

### <a name="BKMK_msdyn_agreementbookingsetup_ServiceAppointments"></a> msdyn_agreementbookingsetup_ServiceAppointments

See msdyn_agreementbookingsetup Entity [msdyn_agreementbookingsetup_ServiceAppointments](msdyn_agreementbookingsetup.md#BKMK_msdyn_agreementbookingsetup_ServiceAppointments) One-To-Many relationship.

### <a name="BKMK_msdyn_agreementinvoicedate_ServiceAppointments"></a> msdyn_agreementinvoicedate_ServiceAppointments

See msdyn_agreementinvoicedate Entity [msdyn_agreementinvoicedate_ServiceAppointments](msdyn_agreementinvoicedate.md#BKMK_msdyn_agreementinvoicedate_ServiceAppointments) One-To-Many relationship.

### <a name="BKMK_msdyn_agreementinvoiceproduct_ServiceAppointments"></a> msdyn_agreementinvoiceproduct_ServiceAppointments

See msdyn_agreementinvoiceproduct Entity [msdyn_agreementinvoiceproduct_ServiceAppointments](msdyn_agreementinvoiceproduct.md#BKMK_msdyn_agreementinvoiceproduct_ServiceAppointments) One-To-Many relationship.

### <a name="BKMK_msdyn_agreementinvoicesetup_ServiceAppointments"></a> msdyn_agreementinvoicesetup_ServiceAppointments

See msdyn_agreementinvoicesetup Entity [msdyn_agreementinvoicesetup_ServiceAppointments](msdyn_agreementinvoicesetup.md#BKMK_msdyn_agreementinvoicesetup_ServiceAppointments) One-To-Many relationship.

### <a name="BKMK_msdyn_bookingtimestamp_ServiceAppointments"></a> msdyn_bookingtimestamp_ServiceAppointments

See msdyn_bookingtimestamp Entity [msdyn_bookingtimestamp_ServiceAppointments](msdyn_bookingtimestamp.md#BKMK_msdyn_bookingtimestamp_ServiceAppointments) One-To-Many relationship.

### <a name="BKMK_msdyn_customerasset_ServiceAppointments"></a> msdyn_customerasset_ServiceAppointments

See msdyn_customerasset Entity [msdyn_customerasset_ServiceAppointments](msdyn_customerasset.md#BKMK_msdyn_customerasset_ServiceAppointments) One-To-Many relationship.

### <a name="BKMK_msdyn_fieldservicesetting_ServiceAppointments"></a> msdyn_fieldservicesetting_ServiceAppointments

See msdyn_fieldservicesetting Entity [msdyn_fieldservicesetting_ServiceAppointments](msdyn_fieldservicesetting.md#BKMK_msdyn_fieldservicesetting_ServiceAppointments) One-To-Many relationship.

### <a name="BKMK_msdyn_incidenttypecharacteristic_ServiceAppointments"></a> msdyn_incidenttypecharacteristic_ServiceAppointments

See msdyn_incidenttypecharacteristic Entity [msdyn_incidenttypecharacteristic_ServiceAppointments](msdyn_incidenttypecharacteristic.md#BKMK_msdyn_incidenttypecharacteristic_ServiceAppointments) One-To-Many relationship.

### <a name="BKMK_msdyn_incidenttypeproduct_ServiceAppointments"></a> msdyn_incidenttypeproduct_ServiceAppointments

See msdyn_incidenttypeproduct Entity [msdyn_incidenttypeproduct_ServiceAppointments](msdyn_incidenttypeproduct.md#BKMK_msdyn_incidenttypeproduct_ServiceAppointments) One-To-Many relationship.

### <a name="BKMK_msdyn_incidenttypeservice_ServiceAppointments"></a> msdyn_incidenttypeservice_ServiceAppointments

See msdyn_incidenttypeservice Entity [msdyn_incidenttypeservice_ServiceAppointments](msdyn_incidenttypeservice.md#BKMK_msdyn_incidenttypeservice_ServiceAppointments) One-To-Many relationship.

### <a name="BKMK_msdyn_inventoryadjustment_ServiceAppointments"></a> msdyn_inventoryadjustment_ServiceAppointments

See msdyn_inventoryadjustment Entity [msdyn_inventoryadjustment_ServiceAppointments](msdyn_inventoryadjustment.md#BKMK_msdyn_inventoryadjustment_ServiceAppointments) One-To-Many relationship.

### <a name="BKMK_msdyn_inventoryadjustmentproduct_ServiceAppointments"></a> msdyn_inventoryadjustmentproduct_ServiceAppointments

See msdyn_inventoryadjustmentproduct Entity [msdyn_inventoryadjustmentproduct_ServiceAppointments](msdyn_inventoryadjustmentproduct.md#BKMK_msdyn_inventoryadjustmentproduct_ServiceAppointments) One-To-Many relationship.

### <a name="BKMK_msdyn_inventoryjournal_ServiceAppointments"></a> msdyn_inventoryjournal_ServiceAppointments

See msdyn_inventoryjournal Entity [msdyn_inventoryjournal_ServiceAppointments](msdyn_inventoryjournal.md#BKMK_msdyn_inventoryjournal_ServiceAppointments) One-To-Many relationship.

### <a name="BKMK_msdyn_inventorytransfer_ServiceAppointments"></a> msdyn_inventorytransfer_ServiceAppointments

See msdyn_inventorytransfer Entity [msdyn_inventorytransfer_ServiceAppointments](msdyn_inventorytransfer.md#BKMK_msdyn_inventorytransfer_ServiceAppointments) One-To-Many relationship.

### <a name="BKMK_msdyn_payment_ServiceAppointments"></a> msdyn_payment_ServiceAppointments

See msdyn_payment Entity [msdyn_payment_ServiceAppointments](msdyn_payment.md#BKMK_msdyn_payment_ServiceAppointments) One-To-Many relationship.

### <a name="BKMK_msdyn_paymentdetail_ServiceAppointments"></a> msdyn_paymentdetail_ServiceAppointments

See msdyn_paymentdetail Entity [msdyn_paymentdetail_ServiceAppointments](msdyn_paymentdetail.md#BKMK_msdyn_paymentdetail_ServiceAppointments) One-To-Many relationship.

### <a name="BKMK_msdyn_paymentmethod_ServiceAppointments"></a> msdyn_paymentmethod_ServiceAppointments

See msdyn_paymentmethod Entity [msdyn_paymentmethod_ServiceAppointments](msdyn_paymentmethod.md#BKMK_msdyn_paymentmethod_ServiceAppointments) One-To-Many relationship.

### <a name="BKMK_msdyn_paymentterm_ServiceAppointments"></a> msdyn_paymentterm_ServiceAppointments

See msdyn_paymentterm Entity [msdyn_paymentterm_ServiceAppointments](msdyn_paymentterm.md#BKMK_msdyn_paymentterm_ServiceAppointments) One-To-Many relationship.

### <a name="BKMK_msdyn_postalcode_ServiceAppointments"></a> msdyn_postalcode_ServiceAppointments

See msdyn_postalcode Entity [msdyn_postalcode_ServiceAppointments](msdyn_postalcode.md#BKMK_msdyn_postalcode_ServiceAppointments) One-To-Many relationship.

### <a name="BKMK_msdyn_productinventory_ServiceAppointments"></a> msdyn_productinventory_ServiceAppointments

See msdyn_productinventory Entity [msdyn_productinventory_ServiceAppointments](msdyn_productinventory.md#BKMK_msdyn_productinventory_ServiceAppointments) One-To-Many relationship.

### <a name="BKMK_msdyn_purchaseorder_ServiceAppointments"></a> msdyn_purchaseorder_ServiceAppointments

See msdyn_purchaseorder Entity [msdyn_purchaseorder_ServiceAppointments](msdyn_purchaseorder.md#BKMK_msdyn_purchaseorder_ServiceAppointments) One-To-Many relationship.

### <a name="BKMK_msdyn_purchaseorderbill_ServiceAppointments"></a> msdyn_purchaseorderbill_ServiceAppointments

See msdyn_purchaseorderbill Entity [msdyn_purchaseorderbill_ServiceAppointments](msdyn_purchaseorderbill.md#BKMK_msdyn_purchaseorderbill_ServiceAppointments) One-To-Many relationship.

### <a name="BKMK_msdyn_purchaseorderproduct_ServiceAppointments"></a> msdyn_purchaseorderproduct_ServiceAppointments

See msdyn_purchaseorderproduct Entity [msdyn_purchaseorderproduct_ServiceAppointments](msdyn_purchaseorderproduct.md#BKMK_msdyn_purchaseorderproduct_ServiceAppointments) One-To-Many relationship.

### <a name="BKMK_msdyn_purchaseorderreceipt_ServiceAppointments"></a> msdyn_purchaseorderreceipt_ServiceAppointments

See msdyn_purchaseorderreceipt Entity [msdyn_purchaseorderreceipt_ServiceAppointments](msdyn_purchaseorderreceipt.md#BKMK_msdyn_purchaseorderreceipt_ServiceAppointments) One-To-Many relationship.

### <a name="BKMK_msdyn_purchaseorderreceiptproduct_ServiceAppointments"></a> msdyn_purchaseorderreceiptproduct_ServiceAppointments

See msdyn_purchaseorderreceiptproduct Entity [msdyn_purchaseorderreceiptproduct_ServiceAppointments](msdyn_purchaseorderreceiptproduct.md#BKMK_msdyn_purchaseorderreceiptproduct_ServiceAppointments) One-To-Many relationship.

### <a name="BKMK_msdyn_purchaseordersubstatus_ServiceAppointments"></a> msdyn_purchaseordersubstatus_ServiceAppointments

See msdyn_purchaseordersubstatus Entity [msdyn_purchaseordersubstatus_ServiceAppointments](msdyn_purchaseordersubstatus.md#BKMK_msdyn_purchaseordersubstatus_ServiceAppointments) One-To-Many relationship.

### <a name="BKMK_msdyn_quotebookingincident_ServiceAppointments"></a> msdyn_quotebookingincident_ServiceAppointments

See msdyn_quotebookingincident Entity [msdyn_quotebookingincident_ServiceAppointments](msdyn_quotebookingincident.md#BKMK_msdyn_quotebookingincident_ServiceAppointments) One-To-Many relationship.

### <a name="BKMK_msdyn_quotebookingproduct_ServiceAppointments"></a> msdyn_quotebookingproduct_ServiceAppointments

See msdyn_quotebookingproduct Entity [msdyn_quotebookingproduct_ServiceAppointments](msdyn_quotebookingproduct.md#BKMK_msdyn_quotebookingproduct_ServiceAppointments) One-To-Many relationship.

### <a name="BKMK_msdyn_quotebookingservice_ServiceAppointments"></a> msdyn_quotebookingservice_ServiceAppointments

See msdyn_quotebookingservice Entity [msdyn_quotebookingservice_ServiceAppointments](msdyn_quotebookingservice.md#BKMK_msdyn_quotebookingservice_ServiceAppointments) One-To-Many relationship.

### <a name="BKMK_msdyn_quotebookingservicetask_ServiceAppointments"></a> msdyn_quotebookingservicetask_ServiceAppointments

See msdyn_quotebookingservicetask Entity [msdyn_quotebookingservicetask_ServiceAppointments](msdyn_quotebookingservicetask.md#BKMK_msdyn_quotebookingservicetask_ServiceAppointments) One-To-Many relationship.

### <a name="BKMK_msdyn_rma_ServiceAppointments"></a> msdyn_rma_ServiceAppointments

See msdyn_rma Entity [msdyn_rma_ServiceAppointments](msdyn_rma.md#BKMK_msdyn_rma_ServiceAppointments) One-To-Many relationship.

### <a name="BKMK_msdyn_rmaproduct_ServiceAppointments"></a> msdyn_rmaproduct_ServiceAppointments

See msdyn_rmaproduct Entity [msdyn_rmaproduct_ServiceAppointments](msdyn_rmaproduct.md#BKMK_msdyn_rmaproduct_ServiceAppointments) One-To-Many relationship.

### <a name="BKMK_msdyn_rmareceipt_ServiceAppointments"></a> msdyn_rmareceipt_ServiceAppointments

See msdyn_rmareceipt Entity [msdyn_rmareceipt_ServiceAppointments](msdyn_rmareceipt.md#BKMK_msdyn_rmareceipt_ServiceAppointments) One-To-Many relationship.

### <a name="BKMK_msdyn_rmareceiptproduct_ServiceAppointments"></a> msdyn_rmareceiptproduct_ServiceAppointments

See msdyn_rmareceiptproduct Entity [msdyn_rmareceiptproduct_ServiceAppointments](msdyn_rmareceiptproduct.md#BKMK_msdyn_rmareceiptproduct_ServiceAppointments) One-To-Many relationship.

### <a name="BKMK_msdyn_rmasubstatus_ServiceAppointments"></a> msdyn_rmasubstatus_ServiceAppointments

See msdyn_rmasubstatus Entity [msdyn_rmasubstatus_ServiceAppointments](msdyn_rmasubstatus.md#BKMK_msdyn_rmasubstatus_ServiceAppointments) One-To-Many relationship.

### <a name="BKMK_msdyn_rtv_ServiceAppointments"></a> msdyn_rtv_ServiceAppointments

See msdyn_rtv Entity [msdyn_rtv_ServiceAppointments](msdyn_rtv.md#BKMK_msdyn_rtv_ServiceAppointments) One-To-Many relationship.

### <a name="BKMK_msdyn_rtvproduct_ServiceAppointments"></a> msdyn_rtvproduct_ServiceAppointments

See msdyn_rtvproduct Entity [msdyn_rtvproduct_ServiceAppointments](msdyn_rtvproduct.md#BKMK_msdyn_rtvproduct_ServiceAppointments) One-To-Many relationship.

### <a name="BKMK_msdyn_rtvsubstatus_ServiceAppointments"></a> msdyn_rtvsubstatus_ServiceAppointments

See msdyn_rtvsubstatus Entity [msdyn_rtvsubstatus_ServiceAppointments](msdyn_rtvsubstatus.md#BKMK_msdyn_rtvsubstatus_ServiceAppointments) One-To-Many relationship.

### <a name="BKMK_msdyn_shipvia_ServiceAppointments"></a> msdyn_shipvia_ServiceAppointments

See msdyn_shipvia Entity [msdyn_shipvia_ServiceAppointments](msdyn_shipvia.md#BKMK_msdyn_shipvia_ServiceAppointments) One-To-Many relationship.

### <a name="BKMK_msdyn_timeoffrequest_ServiceAppointments"></a> msdyn_timeoffrequest_ServiceAppointments

See msdyn_timeoffrequest Entity [msdyn_timeoffrequest_ServiceAppointments](msdyn_timeoffrequest.md#BKMK_msdyn_timeoffrequest_ServiceAppointments) One-To-Many relationship.

### <a name="BKMK_msdyn_warehouse_ServiceAppointments"></a> msdyn_warehouse_ServiceAppointments

See msdyn_warehouse Entity [msdyn_warehouse_ServiceAppointments](msdyn_warehouse.md#BKMK_msdyn_warehouse_ServiceAppointments) One-To-Many relationship.

### <a name="BKMK_msdyn_workorder_ServiceAppointments"></a> msdyn_workorder_ServiceAppointments

See msdyn_workorder Entity [msdyn_workorder_ServiceAppointments](msdyn_workorder.md#BKMK_msdyn_workorder_ServiceAppointments) One-To-Many relationship.

### <a name="BKMK_msdyn_workordercharacteristic_ServiceAppointments"></a> msdyn_workordercharacteristic_ServiceAppointments

See msdyn_workordercharacteristic Entity [msdyn_workordercharacteristic_ServiceAppointments](msdyn_workordercharacteristic.md#BKMK_msdyn_workordercharacteristic_ServiceAppointments) One-To-Many relationship.

### <a name="BKMK_msdyn_workorderincident_ServiceAppointments"></a> msdyn_workorderincident_ServiceAppointments

See msdyn_workorderincident Entity [msdyn_workorderincident_ServiceAppointments](msdyn_workorderincident.md#BKMK_msdyn_workorderincident_ServiceAppointments) One-To-Many relationship.

### <a name="BKMK_msdyn_workorderproduct_ServiceAppointments"></a> msdyn_workorderproduct_ServiceAppointments

See msdyn_workorderproduct Entity [msdyn_workorderproduct_ServiceAppointments](msdyn_workorderproduct.md#BKMK_msdyn_workorderproduct_ServiceAppointments) One-To-Many relationship.

### <a name="BKMK_msdyn_workorderresourcerestriction_ServiceAppointments"></a> msdyn_workorderresourcerestriction_ServiceAppointments

See msdyn_workorderresourcerestriction Entity [msdyn_workorderresourcerestriction_ServiceAppointments](msdyn_workorderresourcerestriction.md#BKMK_msdyn_workorderresourcerestriction_ServiceAppointments) One-To-Many relationship.

### <a name="BKMK_msdyn_workorderservice_ServiceAppointments"></a> msdyn_workorderservice_ServiceAppointments

See msdyn_workorderservice Entity [msdyn_workorderservice_ServiceAppointments](msdyn_workorderservice.md#BKMK_msdyn_workorderservice_ServiceAppointments) One-To-Many relationship.

### <a name="BKMK_msdyn_workorderservicetask_ServiceAppointments"></a> msdyn_workorderservicetask_ServiceAppointments

See msdyn_workorderservicetask Entity [msdyn_workorderservicetask_ServiceAppointments](msdyn_workorderservicetask.md#BKMK_msdyn_workorderservicetask_ServiceAppointments) One-To-Many relationship.

## See also

[About the Entity Reference](../about-entity-reference.md)<br />
[Programming reference for Dynamics 365 Customer Engagement](../programming-reference.md)<br />
[Web API Reference](/dynamics365/customer-engagement/web-api/about)<br />
<xref href="Microsoft.Dynamics.CRM.serviceappointment?text=serviceappointment EntityType" />