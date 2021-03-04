---
title: "ServiceAppointment Entity Reference (Dynamics 365 Customer Engagement)| MicrosoftDocs"
description: "Includes schema information and supported messages for the ServiceAppointment entity."
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
# ServiceAppointment Entity Reference

Activity offered by the organization to satisfy its customer's needs. Each service activity includes date, time, duration, and required resources.

**Added by**: Service Solution


## Messages

|Message|Web API Operation|SDK Assembly|
|-|-|-|
|Assign|PATCH [*org URI*]/api/data/v9.0/serviceappointments(*activityid*)<br />[Update](/powerapps/developer/common-data-service/webapi/update-delete-entities-using-web-api#basic-update) `ownerid` property.|<xref:Microsoft.Crm.Sdk.Messages.AssignRequest>|
|Book|<xref href="Microsoft.Dynamics.CRM.Book?text=Book Action" />|<xref:Microsoft.Crm.Sdk.Messages.BookRequest>|
|Create|POST [*org URI*]/api/data/v9.0/serviceappointments<br />See [Create](/powerapps/developer/common-data-service/webapi/create-entity-web-api)|<xref:Microsoft.Xrm.Sdk.Messages.CreateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Create*>|
|Delete|DELETE [*org URI*]/api/data/v9.0/serviceappointments(*activityid*)<br />See [Delete](/powerapps/developer/common-data-service/webapi/update-delete-entities-using-web-api#basic-delete)|<xref:Microsoft.Xrm.Sdk.Messages.DeleteRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Delete*>|
|GrantAccess|<xref href="Microsoft.Dynamics.CRM.GrantAccess?text=GrantAccess Action" />|<xref:Microsoft.Crm.Sdk.Messages.GrantAccessRequest>|
|ModifyAccess|<xref href="Microsoft.Dynamics.CRM.ModifyAccess?text=ModifyAccess Action" />|<xref:Microsoft.Crm.Sdk.Messages.ModifyAccessRequest>|
|Reschedule|<xref href="Microsoft.Dynamics.CRM.Reschedule?text=Reschedule Action" />|<xref:Microsoft.Crm.Sdk.Messages.RescheduleRequest>|
|Retrieve|GET [*org URI*]/api/data/v9.0/serviceappointments(*activityid*)<br />See [Retrieve](/powerapps/developer/common-data-service/webapi/retrieve-entity-using-web-api)|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Retrieve*>|
|RetrieveMultiple|GET [*org URI*]/api/data/v9.0/serviceappointments<br />See [Query Data](/powerapps/developer/common-data-service/webapi/query-data-web-api)|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveMultipleRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.RetrieveMultiple*>|
|RetrievePrincipalAccess|<xref href="Microsoft.Dynamics.CRM.RetrievePrincipalAccess?text=RetrievePrincipalAccess Function" />|<xref:Microsoft.Crm.Sdk.Messages.RetrievePrincipalAccessRequest>|
|RetrieveSharedPrincipalsAndAccess|<xref href="Microsoft.Dynamics.CRM.RetrieveSharedPrincipalsAndAccess?text=RetrieveSharedPrincipalsAndAccess Function" />|<xref:Microsoft.Crm.Sdk.Messages.RetrieveSharedPrincipalsAndAccessRequest>|
|RevokeAccess|<xref href="Microsoft.Dynamics.CRM.RevokeAccess?text=RevokeAccess Action" />|<xref:Microsoft.Crm.Sdk.Messages.RevokeAccessRequest>|
|SetState|PATCH [*org URI*]/api/data/v9.0/serviceappointments(*activityid*)<br />[Update](/powerapps/developer/common-data-service/webapi/update-delete-entities-using-web-api#basic-update) `statecode` and `statuscode` properties.|<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|
|Update|PATCH [*org URI*]/api/data/v9.0/serviceappointments(*activityid*)<br />See [Update](/powerapps/developer/common-data-service/webapi/update-delete-entities-using-web-api#basic-update)|<xref:Microsoft.Xrm.Sdk.Messages.UpdateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Update*>|
|Validate|<xref href="Microsoft.Dynamics.CRM.Validate?text=Validate Action" />|<xref:Microsoft.Crm.Sdk.Messages.ValidateRequest>|
|ValidateSavedQuery|<xref href="Microsoft.Dynamics.CRM.ValidateSavedQuery?text=ValidateSavedQuery Action" />|<xref:Microsoft.Crm.Sdk.Messages.ValidateSavedQueryRequest>|

## Entity Properties

|Property|Value|
|--------|-----|
|CollectionSchemaName|ServiceAppointments|
|DisplayCollectionName|Service Activities|
|DisplayName|Service Activity|
|EntitySetName|serviceappointments|
|IsBPFEntity|False|
|LogicalCollectionName|serviceappointments|
|LogicalName|serviceappointment|
|OwnershipType|UserOwned|
|PrimaryIdAttribute|activityid|
|PrimaryNameAttribute|subject|
|SchemaName|ServiceAppointment|

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
|Description|Unique identifier of the service activity.|
|DisplayName|Service Activity|
|IsValidForForm|False|
|IsValidForRead|True|
|IsValidForUpdate|False|
|LogicalName|activityid|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|


### <a name="BKMK_ActualDurationMinutes"></a> ActualDurationMinutes

|Property|Value|
|--------|-----|
|Description|Shows the value selected in the Duration field on the service activity at the time the service activity is closed as completed. The duration is used to report the time spent on the activity.|
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
|Description|Enter the actual end date and time of the service activity. By default, it displays when the activity was closed or canceled.|
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
|Description|Enter the actual start date and time for the service activity. By default, it displays when the activity was created.|
|DisplayName|Actual Start|
|Format|DateAndTime|
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
|Targets|account,contact,lead,systemuser|
|Type|PartyList|


### <a name="BKMK_Category"></a> Category

|Property|Value|
|--------|-----|
|Description|Type a category to identify the service activity type, such as routine maintenance or service call, to tie the service activity to a business group or function.|
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
|Targets|account,contact,lead,systemuser|
|Type|PartyList|


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

#### Community Options

|Value|Label|
|-----|-----|
|0|Other|
|1|Facebook|
|2|Twitter|



### <a name="BKMK_Customers"></a> Customers

|Property|Value|
|--------|-----|
|Description|Enter the accounts and contacts for whom the service activity is being performed.|
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

#### DeliveryPriorityCode Options

|Value|Label|
|-----|-----|
|0|Low|
|1|Normal|
|2|High|



### <a name="BKMK_Description"></a> Description

|Property|Value|
|--------|-----|
|Description|Type additional information to describe the service activity, such as key talking points or objectives.|
|DisplayName|Description|
|Format|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|description|
|MaxLength|2000|
|RequiredLevel|None|
|Type|Memo|


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


### <a name="BKMK_From"></a> From

|Property|Value|
|--------|-----|
|Description|Person who the activity is from.|
|DisplayName|From|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|from|
|RequiredLevel|None|
|Targets|account,contact,lead,systemuser|
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


### <a name="BKMK_IsAllDayEvent"></a> IsAllDayEvent

|Property|Value|
|--------|-----|
|Description|Select whether the service activity is an all-day event to make sure the required resources are scheduled for the full day.|
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
|Description|Information which specifies whether the service activity was billed as part of resolving a case.|
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



### <a name="BKMK_IsWorkflowCreated"></a> IsWorkflowCreated

|Property|Value|
|--------|-----|
|Description|Information which specifies if the service activity was created from a workflow rule.|
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

#### LeftVoiceMail Options

|Value|Label|
|-----|-----|
|1|Yes|
|0|No|

**DefaultValue**: False



### <a name="BKMK_Location"></a> Location

|Property|Value|
|--------|-----|
|Description|Type the location where the service activity will take place, such as a conference room, customer office, or other venue.|
|DisplayName|Delivery Location|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|location|
|MaxLength|500|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_OptionalAttendees"></a> OptionalAttendees

|Property|Value|
|--------|-----|
|Description|List of optional attendees for the activity.|
|DisplayName|Optional Attendees|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|optionalattendees|
|RequiredLevel|None|
|Targets|account,contact,lead,systemuser|
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

#### PriorityCode Options

|Value|Label|
|-----|-----|
|0|Low|
|1|Normal|
|2|High|



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


### <a name="BKMK_RegardingObjectId"></a> RegardingObjectId

|Property|Value|
|--------|-----|
|Description|Choose the record that the service activity relates to.|
|DisplayName|Regarding|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|regardingobjectid|
|RequiredLevel|None|
|Targets|account,bookableresourcebooking,bookableresourcebookingheader,bulkoperation,campaign,campaignactivity,contact,contract,entitlement,entitlementtemplate,incident,interactionforemail,invoice,knowledgearticle,knowledgebaserecord,lead,msdyn_agreement,msdyn_agreementbookingdate,msdyn_agreementbookingincident,msdyn_agreementbookingproduct,msdyn_agreementbookingservice,msdyn_agreementbookingservicetask,msdyn_agreementbookingsetup,msdyn_agreementinvoicedate,msdyn_agreementinvoiceproduct,msdyn_agreementinvoicesetup,msdyn_bookingalertstatus,msdyn_bookingrule,msdyn_bookingtimestamp,msdyn_customerasset,msdyn_fieldservicesetting,msdyn_incidenttypecharacteristic,msdyn_incidenttypeproduct,msdyn_incidenttypeservice,msdyn_inventoryadjustment,msdyn_inventoryadjustmentproduct,msdyn_inventoryjournal,msdyn_inventorytransfer,msdyn_payment,msdyn_paymentdetail,msdyn_paymentmethod,msdyn_paymentterm,msdyn_playbookinstance,msdyn_postalbum,msdyn_postalcode,msdyn_processnotes,msdyn_productinventory,msdyn_projectteam,msdyn_purchaseorder,msdyn_purchaseorderbill,msdyn_purchaseorderproduct,msdyn_purchaseorderreceipt,msdyn_purchaseorderreceiptproduct,msdyn_purchaseordersubstatus,msdyn_quotebookingincident,msdyn_quotebookingproduct,msdyn_quotebookingservice,msdyn_quotebookingservicetask,msdyn_resourceterritory,msdyn_rma,msdyn_rmaproduct,msdyn_rmareceipt,msdyn_rmareceiptproduct,msdyn_rmasubstatus,msdyn_rtv,msdyn_rtvproduct,msdyn_rtvsubstatus,msdyn_shipvia,msdyn_systemuserschedulersetting,msdyn_timegroup,msdyn_timegroupdetail,msdyn_timeoffrequest,msdyn_warehouse,msdyn_workorder,msdyn_workordercharacteristic,msdyn_workorderincident,msdyn_workorderproduct,msdyn_workorderresourcerestriction,msdyn_workorderservice,msdyn_workorderservicetask,opportunity,quote,salesorder,site|
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
|Description|List of required attendees for the activity.|
|DisplayName|Required Attendees|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|requiredattendees|
|RequiredLevel|None|
|Targets|account,contact,lead,systemuser|
|Type|PartyList|


### <a name="BKMK_Resources"></a> Resources

|Property|Value|
|--------|-----|
|Description|Enter the user, facility, or equipment required to complete the service activity.|
|DisplayName|Resources|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|resources|
|RequiredLevel|None|
|Targets|equipment,systemuser|
|Type|PartyList|


### <a name="BKMK_ScheduledDurationMinutes"></a> ScheduledDurationMinutes

|Property|Value|
|--------|-----|
|Description|Shows the expected duration of the service activity, in minutes.|
|DisplayName|Scheduled Duration|
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
|Description|Enter the expected due date and time.|
|DisplayName|Scheduled End|
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
|Description|Enter the expected due date and time.|
|DisplayName|Scheduled Start|
|Format|DateAndTime|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|scheduledstart|
|RequiredLevel|ApplicationRequired|
|Type|DateTime|


### <a name="BKMK_ServiceId"></a> ServiceId

|Property|Value|
|--------|-----|
|Description|Choose the service scheduled to be performed during the service activity.|
|DisplayName|Service|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|serviceid|
|RequiredLevel|ApplicationRequired|
|Targets|service|
|Type|Lookup|


### <a name="BKMK_SiteId"></a> SiteId

|Property|Value|
|--------|-----|
|Description|Choose the site or location where the service activity will be performed.|
|DisplayName|Site|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|siteid|
|RequiredLevel|None|
|Targets|site|
|Type|Lookup|


### <a name="BKMK_SLAId"></a> SLAId

|Property|Value|
|--------|-----|
|Description|Choose the service level agreement (SLA) that you want to apply to the service appointment record.|
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
|Description|Shows whether the service activity is open, completed, or canceled. Completed and canceled service activities are read-only and can't be edited.|
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
|1|Closed|8|Closed|
|2|Canceled|9|Canceled|
|3|Scheduled|3|Scheduled|



### <a name="BKMK_StatusCode"></a> StatusCode

|Property|Value|
|--------|-----|
|Description|Select the service activity's status.|
|DisplayName|Status Reason|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|statuscode|
|RequiredLevel|None|
|Type|Status|

#### StatusCode Options

|Value|Label|State|
|-----|-----|-----|
|1|Requested|0|
|2|Tentative|0|
|3|Pending|3|
|4|Reserved|3|
|6|In Progress|3|
|7|Arrived|3|
|8|Completed|1|
|9|Canceled|2|
|10|No Show|2|



### <a name="BKMK_Subcategory"></a> Subcategory

|Property|Value|
|--------|-----|
|Description|Type a subcategory to identify the service activity type and relate the activity to a specific product, service region, business group, or other function.|
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
|Description|Type a short description about the objective or primary topic of the service activity.|
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


### <a name="BKMK_To"></a> To

|Property|Value|
|--------|-----|
|Description|Person who is the receiver of the activity.|
|DisplayName|To|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|to|
|RequiredLevel|None|
|Targets|account,contact,lead,systemuser|
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

|Property|Value|
|--------|-----|
|Description|Shows the type of activity.|
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
|MinValue|0.0000000001|
|Precision|10|
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
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|owningbusinessunit|
|RequiredLevel|None|
|Targets|businessunit|
|Type|Lookup|


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


### <a name="BKMK_ServiceIdName"></a> ServiceIdName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|serviceidname|
|MaxLength|100|
|RequiredLevel|SystemRequired|
|Type|String|


### <a name="BKMK_SiteIdName"></a> SiteIdName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|siteidname|
|MaxLength|100|
|RequiredLevel|SystemRequired|
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

- [serviceappointment_activity_parties](#BKMK_serviceappointment_activity_parties)
- [CampaignResponse_ServiceAppointments](#BKMK_CampaignResponse_ServiceAppointments)
- [ServiceAppointment_SyncErrors](#BKMK_ServiceAppointment_SyncErrors)
- [ServiceAppointment_AsyncOperations](#BKMK_ServiceAppointment_AsyncOperations)
- [serviceappointment_MailboxTrackingFolders](#BKMK_serviceappointment_MailboxTrackingFolders)
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

**Added by**: System Solution Solution

Same as activityparty entity [serviceappointment_activity_parties](activityparty.md#BKMK_serviceappointment_activity_parties) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|activityparty|
|ReferencingAttribute|activityid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|serviceappointment_activity_parties|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_CampaignResponse_ServiceAppointments"></a> CampaignResponse_ServiceAppointments

**Added by**: Marketing Solution

Same as campaignresponse entity [CampaignResponse_ServiceAppointments](campaignresponse.md#BKMK_CampaignResponse_ServiceAppointments) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|campaignresponse|
|ReferencingAttribute|originatingactivityid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|CampaignResponse_ServiceAppointments|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_ServiceAppointment_SyncErrors"></a> ServiceAppointment_SyncErrors

**Added by**: System Solution Solution

Same as syncerror entity [ServiceAppointment_SyncErrors](syncerror.md#BKMK_ServiceAppointment_SyncErrors) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|syncerror|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|ServiceAppointment_SyncErrors|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: Cascade<br />Reparent: Cascade<br />Share: Cascade<br />Unshare: Cascade|


### <a name="BKMK_ServiceAppointment_AsyncOperations"></a> ServiceAppointment_AsyncOperations

**Added by**: System Solution Solution

Same as asyncoperation entity [ServiceAppointment_AsyncOperations](asyncoperation.md#BKMK_ServiceAppointment_AsyncOperations) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|asyncoperation|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|ServiceAppointment_AsyncOperations|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_serviceappointment_MailboxTrackingFolders"></a> serviceappointment_MailboxTrackingFolders

**Added by**: System Solution Solution

Same as mailboxtrackingfolder entity [serviceappointment_MailboxTrackingFolders](mailboxtrackingfolder.md#BKMK_serviceappointment_MailboxTrackingFolders) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|mailboxtrackingfolder|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|serviceappointment_MailboxTrackingFolders|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_ServiceAppointment_ProcessSessions"></a> ServiceAppointment_ProcessSessions

**Added by**: System Solution Solution

Same as processsession entity [ServiceAppointment_ProcessSessions](processsession.md#BKMK_ServiceAppointment_ProcessSessions) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|processsession|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|ServiceAppointment_ProcessSessions|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Details<br />Label: <br />Order: 110|
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_ServiceAppointment_BulkDeleteFailures"></a> ServiceAppointment_BulkDeleteFailures

**Added by**: System Solution Solution

Same as bulkdeletefailure entity [ServiceAppointment_BulkDeleteFailures](bulkdeletefailure.md#BKMK_ServiceAppointment_BulkDeleteFailures) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|bulkdeletefailure|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|ServiceAppointment_BulkDeleteFailures|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_serviceappointment_principalobjectattributeaccess"></a> serviceappointment_principalobjectattributeaccess

**Added by**: System Solution Solution

Same as principalobjectattributeaccess entity [serviceappointment_principalobjectattributeaccess](principalobjectattributeaccess.md#BKMK_serviceappointment_principalobjectattributeaccess) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|principalobjectattributeaccess|
|ReferencingAttribute|objectid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|serviceappointment_principalobjectattributeaccess|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_serviceappointment_connections1"></a> serviceappointment_connections1

**Added by**: System Solution Solution

Same as connection entity [serviceappointment_connections1](connection.md#BKMK_serviceappointment_connections1) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|connection|
|ReferencingAttribute|record1id|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|serviceappointment_connections1|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Details<br />Label: <br />Order: 100|
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_serviceappointment_connections2"></a> serviceappointment_connections2

**Added by**: System Solution Solution

Same as connection entity [serviceappointment_connections2](connection.md#BKMK_serviceappointment_connections2) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|connection|
|ReferencingAttribute|record2id|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|serviceappointment_connections2|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: 100|
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_ServiceAppointment_QueueItem"></a> ServiceAppointment_QueueItem

**Added by**: System Solution Solution

Same as queueitem entity [ServiceAppointment_QueueItem](queueitem.md#BKMK_ServiceAppointment_QueueItem) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|queueitem|
|ReferencingAttribute|objectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|ServiceAppointment_QueueItem|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_ServiceAppointment_Annotation"></a> ServiceAppointment_Annotation

**Added by**: System Solution Solution

Same as annotation entity [ServiceAppointment_Annotation](annotation.md#BKMK_ServiceAppointment_Annotation) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|annotation|
|ReferencingAttribute|objectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|ServiceAppointment_Annotation|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: Cascade<br />Share: Cascade<br />Unshare: Cascade|


### <a name="BKMK_serviceappointment_actioncard"></a> serviceappointment_actioncard

**Added by**: System Solution Solution

Same as actioncard entity [serviceappointment_actioncard](actioncard.md#BKMK_serviceappointment_actioncard) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|actioncard|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|serviceappointment_actioncard|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_slakpiinstance_serviceappointment"></a> slakpiinstance_serviceappointment

**Added by**: System Solution Solution

Same as slakpiinstance entity [slakpiinstance_serviceappointment](slakpiinstance.md#BKMK_slakpiinstance_serviceappointment) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|slakpiinstance|
|ReferencingAttribute|regarding|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|slakpiinstance_serviceappointment|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|

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
- [msdyn_playbookinstance_ServiceAppointments](#BKMK_msdyn_playbookinstance_ServiceAppointments)
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

**Added by**: Lead Management Solution

See lead Entity [Lead_ServiceAppointments](lead.md#BKMK_Lead_ServiceAppointments) One-To-Many relationship.

### <a name="BKMK_bookableresourcebooking_ServiceAppointments"></a> bookableresourcebooking_ServiceAppointments

**Added by**: Scheduling Solution

See bookableresourcebooking Entity [bookableresourcebooking_ServiceAppointments](bookableresourcebooking.md#BKMK_bookableresourcebooking_ServiceAppointments) One-To-Many relationship.

### <a name="BKMK_bookableresourcebookingheader_ServiceAppointments"></a> bookableresourcebookingheader_ServiceAppointments

**Added by**: Scheduling Solution

See bookableresourcebookingheader Entity [bookableresourcebookingheader_ServiceAppointments](bookableresourcebookingheader.md#BKMK_bookableresourcebookingheader_ServiceAppointments) One-To-Many relationship.

### <a name="BKMK_bulkoperation_ServiceAppointments"></a> bulkoperation_ServiceAppointments

**Added by**: Marketing Solution

See bulkoperation Entity [bulkoperation_ServiceAppointments](bulkoperation.md#BKMK_bulkoperation_ServiceAppointments) One-To-Many relationship.

### <a name="BKMK_Campaign_ServiceAppointments"></a> Campaign_ServiceAppointments

**Added by**: Marketing Solution

See campaign Entity [Campaign_ServiceAppointments](campaign.md#BKMK_Campaign_ServiceAppointments) One-To-Many relationship.

### <a name="BKMK_campaignactivity_ServiceAppointments"></a> campaignactivity_ServiceAppointments

**Added by**: Marketing Solution

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

**Added by**: System Solution Solution

See interactionforemail Entity [interactionforemail_ServiceAppointments](interactionforemail.md#BKMK_interactionforemail_ServiceAppointments) One-To-Many relationship.

### <a name="BKMK_KnowledgeBaseRecord_ServiceAppointments"></a> KnowledgeBaseRecord_ServiceAppointments

**Added by**: System Solution Solution

See knowledgebaserecord Entity [KnowledgeBaseRecord_ServiceAppointments](knowledgebaserecord.md#BKMK_KnowledgeBaseRecord_ServiceAppointments) One-To-Many relationship.

### <a name="BKMK_Account_ServiceAppointments"></a> Account_ServiceAppointments

**Added by**: System Solution Solution

See account Entity [Account_ServiceAppointments](account.md#BKMK_Account_ServiceAppointments) One-To-Many relationship.

### <a name="BKMK_lk_serviceappointment_createdby"></a> lk_serviceappointment_createdby

**Added by**: System Solution Solution

See systemuser Entity [lk_serviceappointment_createdby](systemuser.md#BKMK_lk_serviceappointment_createdby) One-To-Many relationship.

### <a name="BKMK_Contact_ServiceAppointments"></a> Contact_ServiceAppointments

**Added by**: System Solution Solution

See contact Entity [Contact_ServiceAppointments](contact.md#BKMK_Contact_ServiceAppointments) One-To-Many relationship.

### <a name="BKMK_serviceappointment_mailbox_sendermailboxid"></a> serviceappointment_mailbox_sendermailboxid

**Added by**: System Solution Solution

See mailbox Entity [serviceappointment_mailbox_sendermailboxid](mailbox.md#BKMK_serviceappointment_mailbox_sendermailboxid) One-To-Many relationship.

### <a name="BKMK_TransactionCurrency_ServiceAppointment"></a> TransactionCurrency_ServiceAppointment

**Added by**: System Solution Solution

See transactioncurrency Entity [TransactionCurrency_ServiceAppointment](transactioncurrency.md#BKMK_TransactionCurrency_ServiceAppointment) One-To-Many relationship.

### <a name="BKMK_system_user_service_appointments"></a> system_user_service_appointments

**Added by**: System Solution Solution

See systemuser Entity [system_user_service_appointments](systemuser.md#BKMK_system_user_service_appointments) One-To-Many relationship.

### <a name="BKMK_manualsla_serviceappointment"></a> manualsla_serviceappointment

**Added by**: System Solution Solution

See sla Entity [manualsla_serviceappointment](sla.md#BKMK_manualsla_serviceappointment) One-To-Many relationship.

### <a name="BKMK_business_unit_service_appointments"></a> business_unit_service_appointments

**Added by**: System Solution Solution

See businessunit Entity [business_unit_service_appointments](businessunit.md#BKMK_business_unit_service_appointments) One-To-Many relationship.

### <a name="BKMK_KnowledgeArticle_ServiceAppointments"></a> KnowledgeArticle_ServiceAppointments

**Added by**: System Solution Solution

See knowledgearticle Entity [KnowledgeArticle_ServiceAppointments](knowledgearticle.md#BKMK_KnowledgeArticle_ServiceAppointments) One-To-Many relationship.

### <a name="BKMK_lk_serviceappointment_modifiedonbehalfby"></a> lk_serviceappointment_modifiedonbehalfby

**Added by**: System Solution Solution

See systemuser Entity [lk_serviceappointment_modifiedonbehalfby](systemuser.md#BKMK_lk_serviceappointment_modifiedonbehalfby) One-To-Many relationship.

### <a name="BKMK_lk_serviceappointment_createdonbehalfby"></a> lk_serviceappointment_createdonbehalfby

**Added by**: System Solution Solution

See systemuser Entity [lk_serviceappointment_createdonbehalfby](systemuser.md#BKMK_lk_serviceappointment_createdonbehalfby) One-To-Many relationship.

### <a name="BKMK_lk_serviceappointment_modifiedby"></a> lk_serviceappointment_modifiedby

**Added by**: System Solution Solution

See systemuser Entity [lk_serviceappointment_modifiedby](systemuser.md#BKMK_lk_serviceappointment_modifiedby) One-To-Many relationship.

### <a name="BKMK_team_service_appointments"></a> team_service_appointments

**Added by**: System Solution Solution

See team Entity [team_service_appointments](team.md#BKMK_team_service_appointments) One-To-Many relationship.

### <a name="BKMK_sla_serviceappointment"></a> sla_serviceappointment

**Added by**: System Solution Solution

See sla Entity [sla_serviceappointment](sla.md#BKMK_sla_serviceappointment) One-To-Many relationship.

### <a name="BKMK_activity_pointer_service_appointment"></a> activity_pointer_service_appointment

**Added by**: System Solution Solution

See activitypointer Entity [activity_pointer_service_appointment](activitypointer.md#BKMK_activity_pointer_service_appointment) One-To-Many relationship.

### <a name="BKMK_site_ServiceAppointments"></a> site_ServiceAppointments

See site Entity [site_ServiceAppointments](site.md#BKMK_site_ServiceAppointments) One-To-Many relationship.

### <a name="BKMK_service_service_appointments"></a> service_service_appointments

See service Entity [service_service_appointments](service.md#BKMK_service_service_appointments) One-To-Many relationship.

### <a name="BKMK_site_service_appointments"></a> site_service_appointments

See site Entity [site_service_appointments](site.md#BKMK_site_service_appointments) One-To-Many relationship.

### <a name="BKMK_msdyn_playbookinstance_ServiceAppointments"></a> msdyn_playbookinstance_ServiceAppointments

**Added by**: Playbook Solution

See msdyn_playbookinstance Entity [msdyn_playbookinstance_ServiceAppointments](msdyn_playbookinstance.md#BKMK_msdyn_playbookinstance_ServiceAppointments) One-To-Many relationship.

### <a name="BKMK_Invoice_ServiceAppointments"></a> Invoice_ServiceAppointments

**Added by**: Sales Solution

See invoice Entity [Invoice_ServiceAppointments](invoice.md#BKMK_Invoice_ServiceAppointments) One-To-Many relationship.

### <a name="BKMK_Opportunity_ServiceAppointments"></a> Opportunity_ServiceAppointments

**Added by**: Sales Solution

See opportunity Entity [Opportunity_ServiceAppointments](opportunity.md#BKMK_Opportunity_ServiceAppointments) One-To-Many relationship.

### <a name="BKMK_Quote_ServiceAppointments"></a> Quote_ServiceAppointments

**Added by**: Sales Solution

See quote Entity [Quote_ServiceAppointments](quote.md#BKMK_Quote_ServiceAppointments) One-To-Many relationship.

### <a name="BKMK_SalesOrder_ServiceAppointments"></a> SalesOrder_ServiceAppointments

**Added by**: Sales Solution

See salesorder Entity [SalesOrder_ServiceAppointments](salesorder.md#BKMK_SalesOrder_ServiceAppointments) One-To-Many relationship.

### <a name="BKMK_msdyn_postalbum_ServiceAppointments"></a> msdyn_postalbum_ServiceAppointments

**Added by**: Activity Feeds Solution

See msdyn_postalbum Entity [msdyn_postalbum_ServiceAppointments](msdyn_postalbum.md#BKMK_msdyn_postalbum_ServiceAppointments) One-To-Many relationship.

### <a name="BKMK_msdyn_bookingalertstatus_ServiceAppointments"></a> msdyn_bookingalertstatus_ServiceAppointments

**Added by**: Universal Resource Scheduling Solution

See msdyn_bookingalertstatus Entity [msdyn_bookingalertstatus_ServiceAppointments](msdyn_bookingalertstatus.md#BKMK_msdyn_bookingalertstatus_ServiceAppointments) One-To-Many relationship.

### <a name="BKMK_msdyn_bookingrule_ServiceAppointments"></a> msdyn_bookingrule_ServiceAppointments

**Added by**: Universal Resource Scheduling Solution

See msdyn_bookingrule Entity [msdyn_bookingrule_ServiceAppointments](msdyn_bookingrule.md#BKMK_msdyn_bookingrule_ServiceAppointments) One-To-Many relationship.

### <a name="BKMK_msdyn_resourceterritory_ServiceAppointments"></a> msdyn_resourceterritory_ServiceAppointments

**Added by**: Universal Resource Scheduling Solution

See msdyn_resourceterritory Entity [msdyn_resourceterritory_ServiceAppointments](msdyn_resourceterritory.md#BKMK_msdyn_resourceterritory_ServiceAppointments) One-To-Many relationship.

### <a name="BKMK_msdyn_systemuserschedulersetting_ServiceAppointments"></a> msdyn_systemuserschedulersetting_ServiceAppointments

**Added by**: Universal Resource Scheduling Solution

See msdyn_systemuserschedulersetting Entity [msdyn_systemuserschedulersetting_ServiceAppointments](msdyn_systemuserschedulersetting.md#BKMK_msdyn_systemuserschedulersetting_ServiceAppointments) One-To-Many relationship.

### <a name="BKMK_msdyn_timegroup_ServiceAppointments"></a> msdyn_timegroup_ServiceAppointments

**Added by**: Universal Resource Scheduling Solution

See msdyn_timegroup Entity [msdyn_timegroup_ServiceAppointments](msdyn_timegroup.md#BKMK_msdyn_timegroup_ServiceAppointments) One-To-Many relationship.

### <a name="BKMK_msdyn_timegroupdetail_ServiceAppointments"></a> msdyn_timegroupdetail_ServiceAppointments

**Added by**: Universal Resource Scheduling Solution

See msdyn_timegroupdetail Entity [msdyn_timegroupdetail_ServiceAppointments](msdyn_timegroupdetail.md#BKMK_msdyn_timegroupdetail_ServiceAppointments) One-To-Many relationship.

### <a name="BKMK_msdyn_processnotes_ServiceAppointments"></a> msdyn_processnotes_ServiceAppointments

**Added by**: Project Service Automation Solution

See msdyn_processnotes Entity [msdyn_processnotes_ServiceAppointments](msdyn_processnotes.md#BKMK_msdyn_processnotes_ServiceAppointments) One-To-Many relationship.

### <a name="BKMK_msdyn_projectteam_ServiceAppointments"></a> msdyn_projectteam_ServiceAppointments

**Added by**: Project Service Automation Solution

See msdyn_projectteam Entity [msdyn_projectteam_ServiceAppointments](msdyn_projectteam.md#BKMK_msdyn_projectteam_ServiceAppointments) One-To-Many relationship.

### <a name="BKMK_msdyn_agreement_ServiceAppointments"></a> msdyn_agreement_ServiceAppointments

**Added by**: Field Service Solution

See msdyn_agreement Entity [msdyn_agreement_ServiceAppointments](msdyn_agreement.md#BKMK_msdyn_agreement_ServiceAppointments) One-To-Many relationship.

### <a name="BKMK_msdyn_agreementbookingdate_ServiceAppointments"></a> msdyn_agreementbookingdate_ServiceAppointments

**Added by**: Field Service Solution

See msdyn_agreementbookingdate Entity [msdyn_agreementbookingdate_ServiceAppointments](msdyn_agreementbookingdate.md#BKMK_msdyn_agreementbookingdate_ServiceAppointments) One-To-Many relationship.

### <a name="BKMK_msdyn_agreementbookingincident_ServiceAppointments"></a> msdyn_agreementbookingincident_ServiceAppointments

**Added by**: Field Service Solution

See msdyn_agreementbookingincident Entity [msdyn_agreementbookingincident_ServiceAppointments](msdyn_agreementbookingincident.md#BKMK_msdyn_agreementbookingincident_ServiceAppointments) One-To-Many relationship.

### <a name="BKMK_msdyn_agreementbookingproduct_ServiceAppointments"></a> msdyn_agreementbookingproduct_ServiceAppointments

**Added by**: Field Service Solution

See msdyn_agreementbookingproduct Entity [msdyn_agreementbookingproduct_ServiceAppointments](msdyn_agreementbookingproduct.md#BKMK_msdyn_agreementbookingproduct_ServiceAppointments) One-To-Many relationship.

### <a name="BKMK_msdyn_agreementbookingservice_ServiceAppointments"></a> msdyn_agreementbookingservice_ServiceAppointments

**Added by**: Field Service Solution

See msdyn_agreementbookingservice Entity [msdyn_agreementbookingservice_ServiceAppointments](msdyn_agreementbookingservice.md#BKMK_msdyn_agreementbookingservice_ServiceAppointments) One-To-Many relationship.

### <a name="BKMK_msdyn_agreementbookingservicetask_ServiceAppointments"></a> msdyn_agreementbookingservicetask_ServiceAppointments

**Added by**: Field Service Solution

See msdyn_agreementbookingservicetask Entity [msdyn_agreementbookingservicetask_ServiceAppointments](msdyn_agreementbookingservicetask.md#BKMK_msdyn_agreementbookingservicetask_ServiceAppointments) One-To-Many relationship.

### <a name="BKMK_msdyn_agreementbookingsetup_ServiceAppointments"></a> msdyn_agreementbookingsetup_ServiceAppointments

**Added by**: Field Service Solution

See msdyn_agreementbookingsetup Entity [msdyn_agreementbookingsetup_ServiceAppointments](msdyn_agreementbookingsetup.md#BKMK_msdyn_agreementbookingsetup_ServiceAppointments) One-To-Many relationship.

### <a name="BKMK_msdyn_agreementinvoicedate_ServiceAppointments"></a> msdyn_agreementinvoicedate_ServiceAppointments

**Added by**: Field Service Solution

See msdyn_agreementinvoicedate Entity [msdyn_agreementinvoicedate_ServiceAppointments](msdyn_agreementinvoicedate.md#BKMK_msdyn_agreementinvoicedate_ServiceAppointments) One-To-Many relationship.

### <a name="BKMK_msdyn_agreementinvoiceproduct_ServiceAppointments"></a> msdyn_agreementinvoiceproduct_ServiceAppointments

**Added by**: Field Service Solution

See msdyn_agreementinvoiceproduct Entity [msdyn_agreementinvoiceproduct_ServiceAppointments](msdyn_agreementinvoiceproduct.md#BKMK_msdyn_agreementinvoiceproduct_ServiceAppointments) One-To-Many relationship.

### <a name="BKMK_msdyn_agreementinvoicesetup_ServiceAppointments"></a> msdyn_agreementinvoicesetup_ServiceAppointments

**Added by**: Field Service Solution

See msdyn_agreementinvoicesetup Entity [msdyn_agreementinvoicesetup_ServiceAppointments](msdyn_agreementinvoicesetup.md#BKMK_msdyn_agreementinvoicesetup_ServiceAppointments) One-To-Many relationship.

### <a name="BKMK_msdyn_bookingtimestamp_ServiceAppointments"></a> msdyn_bookingtimestamp_ServiceAppointments

**Added by**: Field Service Solution

See msdyn_bookingtimestamp Entity [msdyn_bookingtimestamp_ServiceAppointments](msdyn_bookingtimestamp.md#BKMK_msdyn_bookingtimestamp_ServiceAppointments) One-To-Many relationship.

### <a name="BKMK_msdyn_customerasset_ServiceAppointments"></a> msdyn_customerasset_ServiceAppointments

**Added by**: Field Service Solution

See msdyn_customerasset Entity [msdyn_customerasset_ServiceAppointments](msdyn_customerasset.md#BKMK_msdyn_customerasset_ServiceAppointments) One-To-Many relationship.

### <a name="BKMK_msdyn_fieldservicesetting_ServiceAppointments"></a> msdyn_fieldservicesetting_ServiceAppointments

**Added by**: Field Service Solution

See msdyn_fieldservicesetting Entity [msdyn_fieldservicesetting_ServiceAppointments](msdyn_fieldservicesetting.md#BKMK_msdyn_fieldservicesetting_ServiceAppointments) One-To-Many relationship.

### <a name="BKMK_msdyn_incidenttypecharacteristic_ServiceAppointments"></a> msdyn_incidenttypecharacteristic_ServiceAppointments

**Added by**: Field Service Solution

See msdyn_incidenttypecharacteristic Entity [msdyn_incidenttypecharacteristic_ServiceAppointments](msdyn_incidenttypecharacteristic.md#BKMK_msdyn_incidenttypecharacteristic_ServiceAppointments) One-To-Many relationship.

### <a name="BKMK_msdyn_incidenttypeproduct_ServiceAppointments"></a> msdyn_incidenttypeproduct_ServiceAppointments

**Added by**: Field Service Solution

See msdyn_incidenttypeproduct Entity [msdyn_incidenttypeproduct_ServiceAppointments](msdyn_incidenttypeproduct.md#BKMK_msdyn_incidenttypeproduct_ServiceAppointments) One-To-Many relationship.

### <a name="BKMK_msdyn_incidenttypeservice_ServiceAppointments"></a> msdyn_incidenttypeservice_ServiceAppointments

**Added by**: Field Service Solution

See msdyn_incidenttypeservice Entity [msdyn_incidenttypeservice_ServiceAppointments](msdyn_incidenttypeservice.md#BKMK_msdyn_incidenttypeservice_ServiceAppointments) One-To-Many relationship.

### <a name="BKMK_msdyn_inventoryadjustment_ServiceAppointments"></a> msdyn_inventoryadjustment_ServiceAppointments

**Added by**: Field Service Solution

See msdyn_inventoryadjustment Entity [msdyn_inventoryadjustment_ServiceAppointments](msdyn_inventoryadjustment.md#BKMK_msdyn_inventoryadjustment_ServiceAppointments) One-To-Many relationship.

### <a name="BKMK_msdyn_inventoryadjustmentproduct_ServiceAppointments"></a> msdyn_inventoryadjustmentproduct_ServiceAppointments

**Added by**: Field Service Solution

See msdyn_inventoryadjustmentproduct Entity [msdyn_inventoryadjustmentproduct_ServiceAppointments](msdyn_inventoryadjustmentproduct.md#BKMK_msdyn_inventoryadjustmentproduct_ServiceAppointments) One-To-Many relationship.

### <a name="BKMK_msdyn_inventoryjournal_ServiceAppointments"></a> msdyn_inventoryjournal_ServiceAppointments

**Added by**: Field Service Solution

See msdyn_inventoryjournal Entity [msdyn_inventoryjournal_ServiceAppointments](msdyn_inventoryjournal.md#BKMK_msdyn_inventoryjournal_ServiceAppointments) One-To-Many relationship.

### <a name="BKMK_msdyn_inventorytransfer_ServiceAppointments"></a> msdyn_inventorytransfer_ServiceAppointments

**Added by**: Field Service Solution

See msdyn_inventorytransfer Entity [msdyn_inventorytransfer_ServiceAppointments](msdyn_inventorytransfer.md#BKMK_msdyn_inventorytransfer_ServiceAppointments) One-To-Many relationship.

### <a name="BKMK_msdyn_payment_ServiceAppointments"></a> msdyn_payment_ServiceAppointments

**Added by**: Field Service Solution

See msdyn_payment Entity [msdyn_payment_ServiceAppointments](msdyn_payment.md#BKMK_msdyn_payment_ServiceAppointments) One-To-Many relationship.

### <a name="BKMK_msdyn_paymentdetail_ServiceAppointments"></a> msdyn_paymentdetail_ServiceAppointments

**Added by**: Field Service Solution

See msdyn_paymentdetail Entity [msdyn_paymentdetail_ServiceAppointments](msdyn_paymentdetail.md#BKMK_msdyn_paymentdetail_ServiceAppointments) One-To-Many relationship.

### <a name="BKMK_msdyn_paymentmethod_ServiceAppointments"></a> msdyn_paymentmethod_ServiceAppointments

**Added by**: Field Service Solution

See msdyn_paymentmethod Entity [msdyn_paymentmethod_ServiceAppointments](msdyn_paymentmethod.md#BKMK_msdyn_paymentmethod_ServiceAppointments) One-To-Many relationship.

### <a name="BKMK_msdyn_paymentterm_ServiceAppointments"></a> msdyn_paymentterm_ServiceAppointments

**Added by**: Field Service Solution

See msdyn_paymentterm Entity [msdyn_paymentterm_ServiceAppointments](msdyn_paymentterm.md#BKMK_msdyn_paymentterm_ServiceAppointments) One-To-Many relationship.

### <a name="BKMK_msdyn_postalcode_ServiceAppointments"></a> msdyn_postalcode_ServiceAppointments

**Added by**: Field Service Solution

See msdyn_postalcode Entity [msdyn_postalcode_ServiceAppointments](msdyn_postalcode.md#BKMK_msdyn_postalcode_ServiceAppointments) One-To-Many relationship.

### <a name="BKMK_msdyn_productinventory_ServiceAppointments"></a> msdyn_productinventory_ServiceAppointments

**Added by**: Field Service Solution

See msdyn_productinventory Entity [msdyn_productinventory_ServiceAppointments](msdyn_productinventory.md#BKMK_msdyn_productinventory_ServiceAppointments) One-To-Many relationship.

### <a name="BKMK_msdyn_purchaseorder_ServiceAppointments"></a> msdyn_purchaseorder_ServiceAppointments

**Added by**: Field Service Solution

See msdyn_purchaseorder Entity [msdyn_purchaseorder_ServiceAppointments](msdyn_purchaseorder.md#BKMK_msdyn_purchaseorder_ServiceAppointments) One-To-Many relationship.

### <a name="BKMK_msdyn_purchaseorderbill_ServiceAppointments"></a> msdyn_purchaseorderbill_ServiceAppointments

**Added by**: Field Service Solution

See msdyn_purchaseorderbill Entity [msdyn_purchaseorderbill_ServiceAppointments](msdyn_purchaseorderbill.md#BKMK_msdyn_purchaseorderbill_ServiceAppointments) One-To-Many relationship.

### <a name="BKMK_msdyn_purchaseorderproduct_ServiceAppointments"></a> msdyn_purchaseorderproduct_ServiceAppointments

**Added by**: Field Service Solution

See msdyn_purchaseorderproduct Entity [msdyn_purchaseorderproduct_ServiceAppointments](msdyn_purchaseorderproduct.md#BKMK_msdyn_purchaseorderproduct_ServiceAppointments) One-To-Many relationship.

### <a name="BKMK_msdyn_purchaseorderreceipt_ServiceAppointments"></a> msdyn_purchaseorderreceipt_ServiceAppointments

**Added by**: Field Service Solution

See msdyn_purchaseorderreceipt Entity [msdyn_purchaseorderreceipt_ServiceAppointments](msdyn_purchaseorderreceipt.md#BKMK_msdyn_purchaseorderreceipt_ServiceAppointments) One-To-Many relationship.

### <a name="BKMK_msdyn_purchaseorderreceiptproduct_ServiceAppointments"></a> msdyn_purchaseorderreceiptproduct_ServiceAppointments

**Added by**: Field Service Solution

See msdyn_purchaseorderreceiptproduct Entity [msdyn_purchaseorderreceiptproduct_ServiceAppointments](msdyn_purchaseorderreceiptproduct.md#BKMK_msdyn_purchaseorderreceiptproduct_ServiceAppointments) One-To-Many relationship.

### <a name="BKMK_msdyn_purchaseordersubstatus_ServiceAppointments"></a> msdyn_purchaseordersubstatus_ServiceAppointments

**Added by**: Field Service Solution

See msdyn_purchaseordersubstatus Entity [msdyn_purchaseordersubstatus_ServiceAppointments](msdyn_purchaseordersubstatus.md#BKMK_msdyn_purchaseordersubstatus_ServiceAppointments) One-To-Many relationship.

### <a name="BKMK_msdyn_quotebookingincident_ServiceAppointments"></a> msdyn_quotebookingincident_ServiceAppointments

**Added by**: Field Service Solution

See msdyn_quotebookingincident Entity [msdyn_quotebookingincident_ServiceAppointments](msdyn_quotebookingincident.md#BKMK_msdyn_quotebookingincident_ServiceAppointments) One-To-Many relationship.

### <a name="BKMK_msdyn_quotebookingproduct_ServiceAppointments"></a> msdyn_quotebookingproduct_ServiceAppointments

**Added by**: Field Service Solution

See msdyn_quotebookingproduct Entity [msdyn_quotebookingproduct_ServiceAppointments](msdyn_quotebookingproduct.md#BKMK_msdyn_quotebookingproduct_ServiceAppointments) One-To-Many relationship.

### <a name="BKMK_msdyn_quotebookingservice_ServiceAppointments"></a> msdyn_quotebookingservice_ServiceAppointments

**Added by**: Field Service Solution

See msdyn_quotebookingservice Entity [msdyn_quotebookingservice_ServiceAppointments](msdyn_quotebookingservice.md#BKMK_msdyn_quotebookingservice_ServiceAppointments) One-To-Many relationship.

### <a name="BKMK_msdyn_quotebookingservicetask_ServiceAppointments"></a> msdyn_quotebookingservicetask_ServiceAppointments

**Added by**: Field Service Solution

See msdyn_quotebookingservicetask Entity [msdyn_quotebookingservicetask_ServiceAppointments](msdyn_quotebookingservicetask.md#BKMK_msdyn_quotebookingservicetask_ServiceAppointments) One-To-Many relationship.

### <a name="BKMK_msdyn_rma_ServiceAppointments"></a> msdyn_rma_ServiceAppointments

**Added by**: Field Service Solution

See msdyn_rma Entity [msdyn_rma_ServiceAppointments](msdyn_rma.md#BKMK_msdyn_rma_ServiceAppointments) One-To-Many relationship.

### <a name="BKMK_msdyn_rmaproduct_ServiceAppointments"></a> msdyn_rmaproduct_ServiceAppointments

**Added by**: Field Service Solution

See msdyn_rmaproduct Entity [msdyn_rmaproduct_ServiceAppointments](msdyn_rmaproduct.md#BKMK_msdyn_rmaproduct_ServiceAppointments) One-To-Many relationship.

### <a name="BKMK_msdyn_rmareceipt_ServiceAppointments"></a> msdyn_rmareceipt_ServiceAppointments

**Added by**: Field Service Solution

See msdyn_rmareceipt Entity [msdyn_rmareceipt_ServiceAppointments](msdyn_rmareceipt.md#BKMK_msdyn_rmareceipt_ServiceAppointments) One-To-Many relationship.

### <a name="BKMK_msdyn_rmareceiptproduct_ServiceAppointments"></a> msdyn_rmareceiptproduct_ServiceAppointments

**Added by**: Field Service Solution

See msdyn_rmareceiptproduct Entity [msdyn_rmareceiptproduct_ServiceAppointments](msdyn_rmareceiptproduct.md#BKMK_msdyn_rmareceiptproduct_ServiceAppointments) One-To-Many relationship.

### <a name="BKMK_msdyn_rmasubstatus_ServiceAppointments"></a> msdyn_rmasubstatus_ServiceAppointments

**Added by**: Field Service Solution

See msdyn_rmasubstatus Entity [msdyn_rmasubstatus_ServiceAppointments](msdyn_rmasubstatus.md#BKMK_msdyn_rmasubstatus_ServiceAppointments) One-To-Many relationship.

### <a name="BKMK_msdyn_rtv_ServiceAppointments"></a> msdyn_rtv_ServiceAppointments

**Added by**: Field Service Solution

See msdyn_rtv Entity [msdyn_rtv_ServiceAppointments](msdyn_rtv.md#BKMK_msdyn_rtv_ServiceAppointments) One-To-Many relationship.

### <a name="BKMK_msdyn_rtvproduct_ServiceAppointments"></a> msdyn_rtvproduct_ServiceAppointments

**Added by**: Field Service Solution

See msdyn_rtvproduct Entity [msdyn_rtvproduct_ServiceAppointments](msdyn_rtvproduct.md#BKMK_msdyn_rtvproduct_ServiceAppointments) One-To-Many relationship.

### <a name="BKMK_msdyn_rtvsubstatus_ServiceAppointments"></a> msdyn_rtvsubstatus_ServiceAppointments

**Added by**: Field Service Solution

See msdyn_rtvsubstatus Entity [msdyn_rtvsubstatus_ServiceAppointments](msdyn_rtvsubstatus.md#BKMK_msdyn_rtvsubstatus_ServiceAppointments) One-To-Many relationship.

### <a name="BKMK_msdyn_shipvia_ServiceAppointments"></a> msdyn_shipvia_ServiceAppointments

**Added by**: Field Service Solution

See msdyn_shipvia Entity [msdyn_shipvia_ServiceAppointments](msdyn_shipvia.md#BKMK_msdyn_shipvia_ServiceAppointments) One-To-Many relationship.

### <a name="BKMK_msdyn_timeoffrequest_ServiceAppointments"></a> msdyn_timeoffrequest_ServiceAppointments

**Added by**: Field Service Solution

See msdyn_timeoffrequest Entity [msdyn_timeoffrequest_ServiceAppointments](msdyn_timeoffrequest.md#BKMK_msdyn_timeoffrequest_ServiceAppointments) One-To-Many relationship.

### <a name="BKMK_msdyn_warehouse_ServiceAppointments"></a> msdyn_warehouse_ServiceAppointments

**Added by**: Field Service Solution

See msdyn_warehouse Entity [msdyn_warehouse_ServiceAppointments](msdyn_warehouse.md#BKMK_msdyn_warehouse_ServiceAppointments) One-To-Many relationship.

### <a name="BKMK_msdyn_workorder_ServiceAppointments"></a> msdyn_workorder_ServiceAppointments

**Added by**: Field Service Solution

See msdyn_workorder Entity [msdyn_workorder_ServiceAppointments](msdyn_workorder.md#BKMK_msdyn_workorder_ServiceAppointments) One-To-Many relationship.

### <a name="BKMK_msdyn_workordercharacteristic_ServiceAppointments"></a> msdyn_workordercharacteristic_ServiceAppointments

**Added by**: Field Service Solution

See msdyn_workordercharacteristic Entity [msdyn_workordercharacteristic_ServiceAppointments](msdyn_workordercharacteristic.md#BKMK_msdyn_workordercharacteristic_ServiceAppointments) One-To-Many relationship.

### <a name="BKMK_msdyn_workorderincident_ServiceAppointments"></a> msdyn_workorderincident_ServiceAppointments

**Added by**: Field Service Solution

See msdyn_workorderincident Entity [msdyn_workorderincident_ServiceAppointments](msdyn_workorderincident.md#BKMK_msdyn_workorderincident_ServiceAppointments) One-To-Many relationship.

### <a name="BKMK_msdyn_workorderproduct_ServiceAppointments"></a> msdyn_workorderproduct_ServiceAppointments

**Added by**: Field Service Solution

See msdyn_workorderproduct Entity [msdyn_workorderproduct_ServiceAppointments](msdyn_workorderproduct.md#BKMK_msdyn_workorderproduct_ServiceAppointments) One-To-Many relationship.

### <a name="BKMK_msdyn_workorderresourcerestriction_ServiceAppointments"></a> msdyn_workorderresourcerestriction_ServiceAppointments

**Added by**: Field Service Solution

See msdyn_workorderresourcerestriction Entity [msdyn_workorderresourcerestriction_ServiceAppointments](msdyn_workorderresourcerestriction.md#BKMK_msdyn_workorderresourcerestriction_ServiceAppointments) One-To-Many relationship.

### <a name="BKMK_msdyn_workorderservice_ServiceAppointments"></a> msdyn_workorderservice_ServiceAppointments

**Added by**: Field Service Solution

See msdyn_workorderservice Entity [msdyn_workorderservice_ServiceAppointments](msdyn_workorderservice.md#BKMK_msdyn_workorderservice_ServiceAppointments) One-To-Many relationship.

### <a name="BKMK_msdyn_workorderservicetask_ServiceAppointments"></a> msdyn_workorderservicetask_ServiceAppointments

**Added by**: Field Service Solution

See msdyn_workorderservicetask Entity [msdyn_workorderservicetask_ServiceAppointments](msdyn_workorderservicetask.md#BKMK_msdyn_workorderservicetask_ServiceAppointments) One-To-Many relationship.

### See also

[About the Entity Reference](../about-entity-reference.md)<br />
[Programming reference for Dynamics 365 Customer Engagement](../programming-reference.md)<br />
[Web API Reference](/dynamics365/customer-engagement/web-api/about)<br />
<xref href="Microsoft.Dynamics.CRM.serviceappointment?text=serviceappointment EntityType" />

[!INCLUDE[footer-include](../../../../includes/footer-banner.md)]