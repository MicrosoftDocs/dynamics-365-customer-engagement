---
title: "msdyn_bookingalert Entity Reference (Dynamics 365 Customer Engagement)| MicrosoftDocs"
description: "Includes schema information and supported messages for the msdyn_bookingalert entity."
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
# msdyn_bookingalert Entity Reference

Alerts that notify schedule board users of booking issues or information.

**Added by**: Universal Resource Scheduling Solution


## Messages

|Message|Web API Operation|SDK Assembly|
|-|-|-|
|Assign|PATCH [*org URI*]/api/data/v9.0/msdyn_bookingalerts(*activityid*)<br />[Update](/powerapps/developer/common-data-service/webapi/update-delete-entities-using-web-api#basic-update) `ownerid` property.|<xref:Microsoft.Crm.Sdk.Messages.AssignRequest>|
|Create|POST [*org URI*]/api/data/v9.0/msdyn_bookingalerts<br />See [Create](/powerapps/developer/common-data-service/webapi/create-entity-web-api)|<xref:Microsoft.Xrm.Sdk.Messages.CreateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Create*>|
|Delete|DELETE [*org URI*]/api/data/v9.0/msdyn_bookingalerts(*activityid*)<br />See [Delete](/powerapps/developer/common-data-service/webapi/update-delete-entities-using-web-api#basic-delete)|<xref:Microsoft.Xrm.Sdk.Messages.DeleteRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Delete*>|
|GrantAccess|<xref href="Microsoft.Dynamics.CRM.GrantAccess?text=GrantAccess Action" />|<xref:Microsoft.Crm.Sdk.Messages.GrantAccessRequest>|
|IsValidStateTransition|<xref href="Microsoft.Dynamics.CRM.IsValidStateTransition?text=IsValidStateTransition Function" />|<xref:Microsoft.Crm.Sdk.Messages.IsValidStateTransitionRequest>|
|ModifyAccess|<xref href="Microsoft.Dynamics.CRM.ModifyAccess?text=ModifyAccess Action" />|<xref:Microsoft.Crm.Sdk.Messages.ModifyAccessRequest>|
|Retrieve|GET [*org URI*]/api/data/v9.0/msdyn_bookingalerts(*activityid*)<br />See [Retrieve](/powerapps/developer/common-data-service/webapi/retrieve-entity-using-web-api)|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Retrieve*>|
|RetrieveMultiple|GET [*org URI*]/api/data/v9.0/msdyn_bookingalerts<br />See [Query Data](/powerapps/developer/common-data-service/webapi/query-data-web-api)|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveMultipleRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.RetrieveMultiple*>|
|RetrievePrincipalAccess|<xref href="Microsoft.Dynamics.CRM.RetrievePrincipalAccess?text=RetrievePrincipalAccess Function" />|<xref:Microsoft.Crm.Sdk.Messages.RetrievePrincipalAccessRequest>|
|RetrieveSharedPrincipalsAndAccess|<xref href="Microsoft.Dynamics.CRM.RetrieveSharedPrincipalsAndAccess?text=RetrieveSharedPrincipalsAndAccess Function" />|<xref:Microsoft.Crm.Sdk.Messages.RetrieveSharedPrincipalsAndAccessRequest>|
|RevokeAccess|<xref href="Microsoft.Dynamics.CRM.RevokeAccess?text=RevokeAccess Action" />|<xref:Microsoft.Crm.Sdk.Messages.RevokeAccessRequest>|
|SetState|PATCH [*org URI*]/api/data/v9.0/msdyn_bookingalerts(*activityid*)<br />[Update](/powerapps/developer/common-data-service/webapi/update-delete-entities-using-web-api#basic-update) `statecode` and `statuscode` properties.|<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|
|Update|PATCH [*org URI*]/api/data/v9.0/msdyn_bookingalerts(*activityid*)<br />See [Update](/powerapps/developer/common-data-service/webapi/update-delete-entities-using-web-api#basic-update)|<xref:Microsoft.Xrm.Sdk.Messages.UpdateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Update*>|

## Entity Properties

|Property|Value|
|--------|-----|
|CollectionSchemaName|msdyn_bookingalerts|
|DisplayCollectionName|Booking Alerts|
|DisplayName|Booking Alert|
|EntitySetName|msdyn_bookingalerts|
|IsBPFEntity|False|
|LogicalCollectionName|msdyn_bookingalerts|
|LogicalName|msdyn_bookingalert|
|OwnershipType|UserOwned|
|PrimaryIdAttribute|activityid|
|PrimaryNameAttribute|subject|
|SchemaName|msdyn_bookingalert|

<a name="writable-attributes"></a>

## Writable attributes

These attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [ActivityAdditionalParams](#BKMK_ActivityAdditionalParams)
- [ActivityId](#BKMK_ActivityId)
- [ActualDurationMinutes](#BKMK_ActualDurationMinutes)
- [ActualEnd](#BKMK_ActualEnd)
- [ActualStart](#BKMK_ActualStart)
- [BCC](#BKMK_BCC)
- [CC](#BKMK_CC)
- [Community](#BKMK_Community)
- [Customers](#BKMK_Customers)
- [DeliveryPriorityCode](#BKMK_DeliveryPriorityCode)
- [Description](#BKMK_Description)
- [ExchangeItemId](#BKMK_ExchangeItemId)
- [ExchangeWebLink](#BKMK_ExchangeWebLink)
- [From](#BKMK_From)
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
- [RegardingObjectIdName](#BKMK_RegardingObjectIdName)
- [RegardingObjectIdYomiName](#BKMK_RegardingObjectIdYomiName)
- [RegardingObjectTypeCode](#BKMK_RegardingObjectTypeCode)
- [RequiredAttendees](#BKMK_RequiredAttendees)
- [Resources](#BKMK_Resources)
- [ScheduledDurationMinutes](#BKMK_ScheduledDurationMinutes)
- [ScheduledEnd](#BKMK_ScheduledEnd)
- [ScheduledStart](#BKMK_ScheduledStart)
- [ServiceId](#BKMK_ServiceId)
- [SLAId](#BKMK_SLAId)
- [SortDate](#BKMK_SortDate)
- [StageId](#BKMK_StageId)
- [StateCode](#BKMK_StateCode)
- [StatusCode](#BKMK_StatusCode)
- [Subject](#BKMK_Subject)
- [TimeZoneRuleVersionNumber](#BKMK_TimeZoneRuleVersionNumber)
- [To](#BKMK_To)
- [TransactionCurrencyId](#BKMK_TransactionCurrencyId)
- [TraversedPath](#BKMK_TraversedPath)
- [UTCConversionTimeZoneCode](#BKMK_UTCConversionTimeZoneCode)


### <a name="BKMK_ActivityAdditionalParams"></a> ActivityAdditionalParams

|Property|Value|
|--------|-----|
|Description|Shows additional information provided by the external application as JSON. For internal use only.|
|DisplayName|Activity Additional Parameters|
|Format|TextArea|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|activityadditionalparams|
|MaxLength|8192|
|RequiredLevel|None|
|Type|Memo|


### <a name="BKMK_ActivityId"></a> ActivityId

**Added by**: Active Solution Solution

|Property|Value|
|--------|-----|
|Description|Unique identifier of the activity.|
|DisplayName|Activity|
|IsValidForForm|False|
|IsValidForRead|True|
|IsValidForUpdate|False|
|LogicalName|activityid|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|


### <a name="BKMK_ActualDurationMinutes"></a> ActualDurationMinutes

|Property|Value|
|--------|-----|
|Description|Shows the actual duration of the activity in minutes.|
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
|Description|Shows the actual end time of the activity.|
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
|Description|Shows the actual start time of the activity.|
|DisplayName|Actual Start|
|Format|DateAndTime|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|actualstart|
|RequiredLevel|None|
|Type|DateTime|


### <a name="BKMK_BCC"></a> BCC

**Added by**: Active Solution Solution

|Property|Value|
|--------|-----|
|Description|Enter the blind carbon-copy (bcc) recipients of the activity.|
|DisplayName|BCC|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|bcc|
|RequiredLevel|None|
|Targets|account,contact,lead,systemuser|
|Type|PartyList|


### <a name="BKMK_CC"></a> CC

**Added by**: Active Solution Solution

|Property|Value|
|--------|-----|
|Description|Enter the carbon-copy (cc) recipients of the activity.|
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
|Description|For internal use only.|
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

**Added by**: Active Solution Solution

|Property|Value|
|--------|-----|
|Description|Enter the customer that the activity is associated with.|
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
|Description|Enter the priority of delivery of the activity to the email server.|
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
|Description|Type a description of the activity.|
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

**Added by**: Active Solution Solution

|Property|Value|
|--------|-----|
|Description|Shows the person who the activity is from.|
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
|Description|Shows the sequence number of the import that created this record.|
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
|Description|Information regarding whether the activity was billed as part of resolving a case.|
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
|Description|Information regarding whether the activity was created from a workflow rule.|
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

**Added by**: Active Solution Solution

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
|Description|Shows whether a voice mail was left.|
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



### <a name="BKMK_OptionalAttendees"></a> OptionalAttendees

**Added by**: Active Solution Solution

|Property|Value|
|--------|-----|
|Description|Shows the list of optional attendees for the activity.|
|DisplayName|Optional Attendees|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|optionalattendees|
|RequiredLevel|None|
|Targets|account,contact,entitlement,equipment,knowledgearticle,lead,queue,systemuser,unresolvedaddress|
|Type|PartyList|


### <a name="BKMK_Organizer"></a> Organizer

**Added by**: Active Solution Solution

|Property|Value|
|--------|-----|
|Description|Shows the person who organized the activity.|
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
|Description|Shows the date and time that the record was migrated.|
|DisplayName|Record Created On|
|Format|DateOnly|
|IsValidForForm|False|
|IsValidForRead|True|
|IsValidForUpdate|False|
|LogicalName|overriddencreatedon|
|RequiredLevel|None|
|Type|DateTime|


### <a name="BKMK_OwnerId"></a> OwnerId

**Added by**: Active Solution Solution

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

**Added by**: Active Solution Solution

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

**Added by**: Active Solution Solution

|Property|Value|
|--------|-----|
|Description|Shows the outsource vendor that the activity is associated with.|
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
|Description|Priority of the activity.|
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

**Added by**: Active Solution Solution

|Property|Value|
|--------|-----|
|Description|Shows the process.|
|DisplayName|Process|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|processid|
|RequiredLevel|None|
|Type|Uniqueidentifier|


### <a name="BKMK_RegardingObjectId"></a> RegardingObjectId

**Added by**: Active Solution Solution

|Property|Value|
|--------|-----|
|Description|Unique identifier of the object with which the activity is associated.|
|DisplayName|Regarding|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|regardingobjectid|
|RequiredLevel|None|
|Targets|account,bookableresourcebooking,bookableresourcebookingheader,bulkoperation,campaign,campaignactivity,contact,contract,entitlement,entitlementtemplate,incident,interactionforemail,invoice,knowledgearticle,knowledgebaserecord,lead,msdyn_agreement,msdyn_agreementbookingdate,msdyn_agreementbookingincident,msdyn_agreementbookingproduct,msdyn_agreementbookingservice,msdyn_agreementbookingservicetask,msdyn_agreementbookingsetup,msdyn_agreementinvoicedate,msdyn_agreementinvoiceproduct,msdyn_agreementinvoicesetup,msdyn_bookingalertstatus,msdyn_bookingrule,msdyn_bookingtimestamp,msdyn_customerasset,msdyn_fieldservicesetting,msdyn_incidenttypecharacteristic,msdyn_incidenttypeproduct,msdyn_incidenttypeservice,msdyn_inventoryadjustment,msdyn_inventoryadjustmentproduct,msdyn_inventoryjournal,msdyn_inventorytransfer,msdyn_payment,msdyn_paymentdetail,msdyn_paymentmethod,msdyn_paymentterm,msdyn_playbookinstance,msdyn_postalbum,msdyn_postalcode,msdyn_processnotes,msdyn_productinventory,msdyn_projectteam,msdyn_purchaseorder,msdyn_purchaseorderbill,msdyn_purchaseorderproduct,msdyn_purchaseorderreceipt,msdyn_purchaseorderreceiptproduct,msdyn_purchaseordersubstatus,msdyn_quotebookingincident,msdyn_quotebookingproduct,msdyn_quotebookingservice,msdyn_quotebookingservicetask,msdyn_resourceterritory,msdyn_rma,msdyn_rmaproduct,msdyn_rmareceipt,msdyn_rmareceiptproduct,msdyn_rmasubstatus,msdyn_rtv,msdyn_rtvproduct,msdyn_rtvsubstatus,msdyn_shipvia,msdyn_systemuserschedulersetting,msdyn_timegroup,msdyn_timegroupdetail,msdyn_timeoffrequest,msdyn_warehouse,msdyn_workorder,msdyn_workordercharacteristic,msdyn_workorderincident,msdyn_workorderproduct,msdyn_workorderresourcerestriction,msdyn_workorderservice,msdyn_workorderservicetask,opportunity,quote,salesorder,site|
|Type|Lookup|


### <a name="BKMK_RegardingObjectIdName"></a> RegardingObjectIdName

**Added by**: Active Solution Solution

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|regardingobjectidname|
|MaxLength|400|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_RegardingObjectIdYomiName"></a> RegardingObjectIdYomiName

**Added by**: Active Solution Solution

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|regardingobjectidyominame|
|MaxLength|400|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_RegardingObjectTypeCode"></a> RegardingObjectTypeCode

**Added by**: Active Solution Solution

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

**Added by**: Active Solution Solution

|Property|Value|
|--------|-----|
|Description|Shows the list of assignees to be notified by alert.|
|DisplayName|Assignees|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|requiredattendees|
|RequiredLevel|ApplicationRequired|
|Targets|account,contact,entitlement,equipment,knowledgearticle,lead,queue,systemuser,unresolvedaddress|
|Type|PartyList|


### <a name="BKMK_Resources"></a> Resources

**Added by**: Active Solution Solution

|Property|Value|
|--------|-----|
|Description|Shows the users or facility/equipment that are required for the activity.|
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
|Description|Enter the scheduled duration of the activity, in minutes.|
|DisplayName|Estimated Duration|
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
|Description|Enter the scheduled end time of the activity.|
|DisplayName|Due Date|
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
|Description|Enter the scheduled start time of the activity.|
|DisplayName|Start Date|
|Format|DateAndTime|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|scheduledstart|
|RequiredLevel|None|
|Type|DateTime|


### <a name="BKMK_ServiceId"></a> ServiceId

**Added by**: Active Solution Solution

|Property|Value|
|--------|-----|
|Description|Unique identifier of an associated service.|
|DisplayName|Service|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|serviceid|
|RequiredLevel|None|
|Targets|service|
|Type|Lookup|


### <a name="BKMK_SLAId"></a> SLAId

**Added by**: Active Solution Solution

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

**Added by**: Active Solution Solution

|Property|Value|
|--------|-----|
|Description|Shows the stage.|
|DisplayName|Process Stage|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|stageid|
|RequiredLevel|None|
|Type|Uniqueidentifier|


### <a name="BKMK_StateCode"></a> StateCode

|Property|Value|
|--------|-----|
|Description|Status of the activity.|
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
|2|Canceled|3|Canceled|
|3|Scheduled|4|Scheduled|



### <a name="BKMK_StatusCode"></a> StatusCode

|Property|Value|
|--------|-----|
|Description|Reason for the status of the activity.|
|DisplayName|Status Reason|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|statuscode|
|RequiredLevel|None|
|Type|Status|

#### StatusCode Options

|Value|Label|State|
|-----|-----|-----|
|1|Open|0|
|2|Completed|1|
|3|Canceled|2|
|4|Scheduled|3|



### <a name="BKMK_Subject"></a> Subject

|Property|Value|
|--------|-----|
|Description|Enter the subject associated with the activity.|
|DisplayName|Subject|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|subject|
|MaxLength|200|
|RequiredLevel|ApplicationRequired|
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

**Added by**: Active Solution Solution

|Property|Value|
|--------|-----|
|Description|Shows the person who is the receiver of the activity.|
|DisplayName|To|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|to|
|RequiredLevel|None|
|Targets|account,contact,lead,systemuser|
|Type|PartyList|


### <a name="BKMK_TransactionCurrencyId"></a> TransactionCurrencyId

**Added by**: Active Solution Solution

|Property|Value|
|--------|-----|
|Description|Unique identifier of the currency associated with the activitypointer.|
|DisplayName|Currency|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|transactioncurrencyid|
|RequiredLevel|None|
|Targets|transactioncurrency|
|Type|Lookup|


### <a name="BKMK_TraversedPath"></a> TraversedPath

**Added by**: Active Solution Solution

|Property|Value|
|--------|-----|
|Description|For internal use only.|
|DisplayName|Traversed Path|
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
|Description|Shows the time zone code that was in use when the record was created.|
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
- [SenderMailboxId](#BKMK_SenderMailboxId)
- [SenderMailboxIdName](#BKMK_SenderMailboxIdName)
- [SentOn](#BKMK_SentOn)
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


### <a name="BKMK_CreatedBy"></a> CreatedBy

**Added by**: Active Solution Solution

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

**Added by**: Active Solution Solution

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

**Added by**: Active Solution Solution

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
|Description|Shows the date and time when the activity was created. The date and time are displayed in the time zone selected in Microsoft Dynamics CRM options.|
|DisplayName|Date Created|
|Format|DateAndTime|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|createdon|
|RequiredLevel|None|
|Type|DateTime|


### <a name="BKMK_CreatedOnBehalfBy"></a> CreatedOnBehalfBy

**Added by**: Active Solution Solution

|Property|Value|
|--------|-----|
|Description|Shows who created the activity pointer on behalf of another user.|
|DisplayName|Created By (Delegate)|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|createdonbehalfby|
|RequiredLevel|None|
|Targets|systemuser|
|Type|Lookup|


### <a name="BKMK_CreatedOnBehalfByName"></a> CreatedOnBehalfByName

**Added by**: Active Solution Solution

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

**Added by**: Active Solution Solution

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
|Description|Enter the date and time when the delivery of the activity was last attempted.|
|DisplayName|Date Delivery Last Attempted|
|Format|DateAndTime|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|deliverylastattemptedon|
|RequiredLevel|None|
|Type|DateTime|


### <a name="BKMK_ExchangeRate"></a> ExchangeRate

**Added by**: Active Solution Solution

|Property|Value|
|--------|-----|
|Description|Exchange rate for the currency associated with the activitypointer with respect to the base currency.|
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
|Description|Shows whether the activity is a regular activity type or event type.|
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

**DefaultValue**: True



### <a name="BKMK_ModifiedBy"></a> ModifiedBy

**Added by**: Active Solution Solution

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

**Added by**: Active Solution Solution

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

**Added by**: Active Solution Solution

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
|Description|Shows the date and time when the activity was last updated. The date and time are displayed in the time zone selected in Microsoft Dynamics CRM options.|
|DisplayName|Last Updated|
|Format|DateAndTime|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|modifiedon|
|RequiredLevel|None|
|Type|DateTime|


### <a name="BKMK_ModifiedOnBehalfBy"></a> ModifiedOnBehalfBy

**Added by**: Active Solution Solution

|Property|Value|
|--------|-----|
|Description|Shows who last updated the activity pointer on behalf of another user.|
|DisplayName|Modified By (Delegate)|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|modifiedonbehalfby|
|RequiredLevel|None|
|Targets|systemuser|
|Type|Lookup|


### <a name="BKMK_ModifiedOnBehalfByName"></a> ModifiedOnBehalfByName

**Added by**: Active Solution Solution

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

**Added by**: Active Solution Solution

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

**Added by**: Active Solution Solution

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

**Added by**: Active Solution Solution

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

**Added by**: Active Solution Solution

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

**Added by**: Active Solution Solution

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

**Added by**: Active Solution Solution

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

**Added by**: Active Solution Solution

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


### <a name="BKMK_SenderMailboxId"></a> SenderMailboxId

**Added by**: Active Solution Solution

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

**Added by**: Active Solution Solution

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
|Description|Enter the date and time when the activity was sent.|
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
|Description|Shows the ID of the recurring series of an instance.|
|DisplayName|Series Id|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|seriesid|
|RequiredLevel|None|
|Type|Uniqueidentifier|


### <a name="BKMK_ServiceIdName"></a> ServiceIdName

**Added by**: Active Solution Solution

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


### <a name="BKMK_SLAInvokedId"></a> SLAInvokedId

**Added by**: Active Solution Solution

|Property|Value|
|--------|-----|
|Description|Shows the last service level agreement (SLA) that was applied to this case. This field is for internal use only.|
|DisplayName|Last SLA applied|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|slainvokedid|
|RequiredLevel|None|
|Targets|sla|
|Type|Lookup|


### <a name="BKMK_SLAInvokedIdName"></a> SLAInvokedIdName

**Added by**: Active Solution Solution

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

**Added by**: Active Solution Solution

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

**Added by**: Active Solution Solution

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

**Added by**: Active Solution Solution

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

- [msdyn_bookingalert_activity_parties](#BKMK_msdyn_bookingalert_activity_parties)
- [CampaignResponse_msdyn_bookingalerts](#BKMK_CampaignResponse_msdyn_bookingalerts)
- [msdyn_bookingalert_ActionCards](#BKMK_msdyn_bookingalert_ActionCards)
- [msdyn_bookingalert_SyncErrors](#BKMK_msdyn_bookingalert_SyncErrors)
- [msdyn_bookingalert_DuplicateMatchingRecord](#BKMK_msdyn_bookingalert_DuplicateMatchingRecord)
- [msdyn_bookingalert_DuplicateBaseRecord](#BKMK_msdyn_bookingalert_DuplicateBaseRecord)
- [msdyn_bookingalert_AsyncOperations](#BKMK_msdyn_bookingalert_AsyncOperations)
- [msdyn_bookingalert_MailboxTrackingFolders](#BKMK_msdyn_bookingalert_MailboxTrackingFolders)
- [msdyn_bookingalert_ProcessSession](#BKMK_msdyn_bookingalert_ProcessSession)
- [msdyn_bookingalert_BulkDeleteFailures](#BKMK_msdyn_bookingalert_BulkDeleteFailures)
- [msdyn_bookingalert_PrincipalObjectAttributeAccesses](#BKMK_msdyn_bookingalert_PrincipalObjectAttributeAccesses)
- [msdyn_bookingalert_connections1](#BKMK_msdyn_bookingalert_connections1)
- [msdyn_bookingalert_connections2](#BKMK_msdyn_bookingalert_connections2)
- [msdyn_bookingalert_QueueItems](#BKMK_msdyn_bookingalert_QueueItems)
- [msdyn_bookingalert_Annotations](#BKMK_msdyn_bookingalert_Annotations)
- [msdyn_msdyn_bookingalert_msdyn_bookingalertstatus_BookingAlert](#BKMK_msdyn_msdyn_bookingalert_msdyn_bookingalertstatus_BookingAlert)


### <a name="BKMK_msdyn_bookingalert_activity_parties"></a> msdyn_bookingalert_activity_parties

**Added by**: System Solution Solution

Same as activityparty entity [msdyn_bookingalert_activity_parties](activityparty.md#BKMK_msdyn_bookingalert_activity_parties) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|activityparty|
|ReferencingAttribute|activityid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_bookingalert_activity_parties|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_CampaignResponse_msdyn_bookingalerts"></a> CampaignResponse_msdyn_bookingalerts

**Added by**: Marketing Solution

Same as campaignresponse entity [CampaignResponse_msdyn_bookingalerts](campaignresponse.md#BKMK_CampaignResponse_msdyn_bookingalerts) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|campaignresponse|
|ReferencingAttribute|originatingactivityid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|CampaignResponse_msdyn_bookingalerts|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_bookingalert_ActionCards"></a> msdyn_bookingalert_ActionCards

**Added by**: System Solution Solution

Same as actioncard entity [msdyn_bookingalert_ActionCards](actioncard.md#BKMK_msdyn_bookingalert_ActionCards) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|actioncard|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_bookingalert_ActionCards|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_bookingalert_SyncErrors"></a> msdyn_bookingalert_SyncErrors

**Added by**: System Solution Solution

Same as syncerror entity [msdyn_bookingalert_SyncErrors](syncerror.md#BKMK_msdyn_bookingalert_SyncErrors) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|syncerror|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_bookingalert_SyncErrors|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_bookingalert_DuplicateMatchingRecord"></a> msdyn_bookingalert_DuplicateMatchingRecord

**Added by**: System Solution Solution

Same as duplicaterecord entity [msdyn_bookingalert_DuplicateMatchingRecord](duplicaterecord.md#BKMK_msdyn_bookingalert_DuplicateMatchingRecord) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|duplicaterecord|
|ReferencingAttribute|duplicaterecordid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_bookingalert_DuplicateMatchingRecord|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_bookingalert_DuplicateBaseRecord"></a> msdyn_bookingalert_DuplicateBaseRecord

**Added by**: System Solution Solution

Same as duplicaterecord entity [msdyn_bookingalert_DuplicateBaseRecord](duplicaterecord.md#BKMK_msdyn_bookingalert_DuplicateBaseRecord) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|duplicaterecord|
|ReferencingAttribute|baserecordid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_bookingalert_DuplicateBaseRecord|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_bookingalert_AsyncOperations"></a> msdyn_bookingalert_AsyncOperations

**Added by**: System Solution Solution

Same as asyncoperation entity [msdyn_bookingalert_AsyncOperations](asyncoperation.md#BKMK_msdyn_bookingalert_AsyncOperations) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|asyncoperation|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_bookingalert_AsyncOperations|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_bookingalert_MailboxTrackingFolders"></a> msdyn_bookingalert_MailboxTrackingFolders

**Added by**: System Solution Solution

Same as mailboxtrackingfolder entity [msdyn_bookingalert_MailboxTrackingFolders](mailboxtrackingfolder.md#BKMK_msdyn_bookingalert_MailboxTrackingFolders) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|mailboxtrackingfolder|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_bookingalert_MailboxTrackingFolders|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_bookingalert_ProcessSession"></a> msdyn_bookingalert_ProcessSession

**Added by**: System Solution Solution

Same as processsession entity [msdyn_bookingalert_ProcessSession](processsession.md#BKMK_msdyn_bookingalert_ProcessSession) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|processsession|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_bookingalert_ProcessSession|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_bookingalert_BulkDeleteFailures"></a> msdyn_bookingalert_BulkDeleteFailures

**Added by**: System Solution Solution

Same as bulkdeletefailure entity [msdyn_bookingalert_BulkDeleteFailures](bulkdeletefailure.md#BKMK_msdyn_bookingalert_BulkDeleteFailures) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|bulkdeletefailure|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_bookingalert_BulkDeleteFailures|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_bookingalert_PrincipalObjectAttributeAccesses"></a> msdyn_bookingalert_PrincipalObjectAttributeAccesses

**Added by**: System Solution Solution

Same as principalobjectattributeaccess entity [msdyn_bookingalert_PrincipalObjectAttributeAccesses](principalobjectattributeaccess.md#BKMK_msdyn_bookingalert_PrincipalObjectAttributeAccesses) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|principalobjectattributeaccess|
|ReferencingAttribute|objectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_bookingalert_PrincipalObjectAttributeAccesses|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_bookingalert_connections1"></a> msdyn_bookingalert_connections1

**Added by**: System Solution Solution

Same as connection entity [msdyn_bookingalert_connections1](connection.md#BKMK_msdyn_bookingalert_connections1) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|connection|
|ReferencingAttribute|record1id|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_bookingalert_connections1|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Details<br />Label: <br />Order: 100|
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_bookingalert_connections2"></a> msdyn_bookingalert_connections2

**Added by**: System Solution Solution

Same as connection entity [msdyn_bookingalert_connections2](connection.md#BKMK_msdyn_bookingalert_connections2) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|connection|
|ReferencingAttribute|record2id|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_bookingalert_connections2|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_bookingalert_QueueItems"></a> msdyn_bookingalert_QueueItems

**Added by**: System Solution Solution

Same as queueitem entity [msdyn_bookingalert_QueueItems](queueitem.md#BKMK_msdyn_bookingalert_QueueItems) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|queueitem|
|ReferencingAttribute|objectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_bookingalert_QueueItems|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_bookingalert_Annotations"></a> msdyn_bookingalert_Annotations

**Added by**: System Solution Solution

Same as annotation entity [msdyn_bookingalert_Annotations](annotation.md#BKMK_msdyn_bookingalert_Annotations) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|annotation|
|ReferencingAttribute|objectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_bookingalert_Annotations|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: Cascade<br />Share: Cascade<br />Unshare: Cascade|


### <a name="BKMK_msdyn_msdyn_bookingalert_msdyn_bookingalertstatus_BookingAlert"></a> msdyn_msdyn_bookingalert_msdyn_bookingalertstatus_BookingAlert

Same as msdyn_bookingalertstatus entity [msdyn_msdyn_bookingalert_msdyn_bookingalertstatus_BookingAlert](msdyn_bookingalertstatus.md#BKMK_msdyn_msdyn_bookingalert_msdyn_bookingalertstatus_BookingAlert) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_bookingalertstatus|
|ReferencingAttribute|msdyn_bookingalert|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_msdyn_bookingalert_msdyn_bookingalertstatus_BookingAlert|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Details<br />Label: <br />Order: 10000|
|CascadeConfiguration|Assign: NoCascade<br />Delete: Restrict<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|

<a name="manytoone"></a>

## Many-To-One Relationships

Each Many-To-One relationship is defined by a corresponding One-To-Many relationship with the related entity. Listed by **SchemaName**.

- [lead_msdyn_bookingalerts](#BKMK_lead_msdyn_bookingalerts)
- [bookableresourcebooking_msdyn_bookingalerts](#BKMK_bookableresourcebooking_msdyn_bookingalerts)
- [bookableresourcebookingheader_msdyn_bookingalerts](#BKMK_bookableresourcebookingheader_msdyn_bookingalerts)
- [bulkoperation_msdyn_bookingalerts](#BKMK_bulkoperation_msdyn_bookingalerts)
- [campaign_msdyn_bookingalerts](#BKMK_campaign_msdyn_bookingalerts)
- [campaignactivity_msdyn_bookingalerts](#BKMK_campaignactivity_msdyn_bookingalerts)
- [contract_msdyn_bookingalerts](#BKMK_contract_msdyn_bookingalerts)
- [entitlement_msdyn_bookingalerts](#BKMK_entitlement_msdyn_bookingalerts)
- [entitlementtemplate_msdyn_bookingalerts](#BKMK_entitlementtemplate_msdyn_bookingalerts)
- [incident_msdyn_bookingalerts](#BKMK_incident_msdyn_bookingalerts)
- [site_msdyn_bookingalerts](#BKMK_site_msdyn_bookingalerts)
- [msdyn_bookingalert_service_serviceid](#BKMK_msdyn_bookingalert_service_serviceid)
- [msdyn_playbookinstance_msdyn_bookingalerts](#BKMK_msdyn_playbookinstance_msdyn_bookingalerts)
- [invoice_msdyn_bookingalerts](#BKMK_invoice_msdyn_bookingalerts)
- [opportunity_msdyn_bookingalerts](#BKMK_opportunity_msdyn_bookingalerts)
- [quote_msdyn_bookingalerts](#BKMK_quote_msdyn_bookingalerts)
- [salesorder_msdyn_bookingalerts](#BKMK_salesorder_msdyn_bookingalerts)
- [msdyn_postalbum_msdyn_bookingalerts](#BKMK_msdyn_postalbum_msdyn_bookingalerts)
- [interactionforemail_msdyn_bookingalerts](#BKMK_interactionforemail_msdyn_bookingalerts)
- [knowledgebaserecord_msdyn_bookingalerts](#BKMK_knowledgebaserecord_msdyn_bookingalerts)
- [account_msdyn_bookingalerts](#BKMK_account_msdyn_bookingalerts)
- [msdyn_bookingalert_systemuser_createdby](#BKMK_msdyn_bookingalert_systemuser_createdby)
- [contact_msdyn_bookingalerts](#BKMK_contact_msdyn_bookingalerts)
- [msdyn_bookingalert_mailbox_sendermailboxid](#BKMK_msdyn_bookingalert_mailbox_sendermailboxid)
- [msdyn_bookingalert_transactioncurrency_transactioncurrencyid](#BKMK_msdyn_bookingalert_transactioncurrency_transactioncurrencyid)
- [msdyn_bookingalert_systemuser_owninguser](#BKMK_msdyn_bookingalert_systemuser_owninguser)
- [msdyn_bookingalert_sla_slaid](#BKMK_msdyn_bookingalert_sla_slaid)
- [msdyn_bookingalert_businessunit_owningbusinessunit](#BKMK_msdyn_bookingalert_businessunit_owningbusinessunit)
- [knowledgearticle_msdyn_bookingalerts](#BKMK_knowledgearticle_msdyn_bookingalerts)
- [msdyn_bookingalert_systemuser_modifiedonbehalfby](#BKMK_msdyn_bookingalert_systemuser_modifiedonbehalfby)
- [msdyn_bookingalert_systemuser_createdonbehalfby](#BKMK_msdyn_bookingalert_systemuser_createdonbehalfby)
- [msdyn_bookingalert_systemuser_modifiedby](#BKMK_msdyn_bookingalert_systemuser_modifiedby)
- [msdyn_bookingalert_team_owningteam](#BKMK_msdyn_bookingalert_team_owningteam)
- [msdyn_bookingalert_sla_slainvokedid](#BKMK_msdyn_bookingalert_sla_slainvokedid)
- [activity_pointer_msdyn_bookingalert](#BKMK_activity_pointer_msdyn_bookingalert)
- [msdyn_bookingalertstatus_msdyn_bookingalerts](#BKMK_msdyn_bookingalertstatus_msdyn_bookingalerts)
- [msdyn_bookingrule_msdyn_bookingalerts](#BKMK_msdyn_bookingrule_msdyn_bookingalerts)
- [msdyn_resourceterritory_msdyn_bookingalerts](#BKMK_msdyn_resourceterritory_msdyn_bookingalerts)
- [msdyn_systemuserschedulersetting_msdyn_bookingalerts](#BKMK_msdyn_systemuserschedulersetting_msdyn_bookingalerts)
- [msdyn_timegroup_msdyn_bookingalerts](#BKMK_msdyn_timegroup_msdyn_bookingalerts)
- [msdyn_timegroupdetail_msdyn_bookingalerts](#BKMK_msdyn_timegroupdetail_msdyn_bookingalerts)
- [msdyn_processnotes_msdyn_bookingalerts](#BKMK_msdyn_processnotes_msdyn_bookingalerts)
- [msdyn_projectteam_msdyn_bookingalerts](#BKMK_msdyn_projectteam_msdyn_bookingalerts)
- [msdyn_agreement_msdyn_bookingalerts](#BKMK_msdyn_agreement_msdyn_bookingalerts)
- [msdyn_agreementbookingdate_msdyn_bookingalerts](#BKMK_msdyn_agreementbookingdate_msdyn_bookingalerts)
- [msdyn_agreementbookingincident_msdyn_bookingalerts](#BKMK_msdyn_agreementbookingincident_msdyn_bookingalerts)
- [msdyn_agreementbookingproduct_msdyn_bookingalerts](#BKMK_msdyn_agreementbookingproduct_msdyn_bookingalerts)
- [msdyn_agreementbookingservice_msdyn_bookingalerts](#BKMK_msdyn_agreementbookingservice_msdyn_bookingalerts)
- [msdyn_agreementbookingservicetask_msdyn_bookingalerts](#BKMK_msdyn_agreementbookingservicetask_msdyn_bookingalerts)
- [msdyn_agreementbookingsetup_msdyn_bookingalerts](#BKMK_msdyn_agreementbookingsetup_msdyn_bookingalerts)
- [msdyn_agreementinvoicedate_msdyn_bookingalerts](#BKMK_msdyn_agreementinvoicedate_msdyn_bookingalerts)
- [msdyn_agreementinvoiceproduct_msdyn_bookingalerts](#BKMK_msdyn_agreementinvoiceproduct_msdyn_bookingalerts)
- [msdyn_agreementinvoicesetup_msdyn_bookingalerts](#BKMK_msdyn_agreementinvoicesetup_msdyn_bookingalerts)
- [msdyn_bookingtimestamp_msdyn_bookingalerts](#BKMK_msdyn_bookingtimestamp_msdyn_bookingalerts)
- [msdyn_customerasset_msdyn_bookingalerts](#BKMK_msdyn_customerasset_msdyn_bookingalerts)
- [msdyn_fieldservicesetting_msdyn_bookingalerts](#BKMK_msdyn_fieldservicesetting_msdyn_bookingalerts)
- [msdyn_incidenttypecharacteristic_msdyn_bookingalerts](#BKMK_msdyn_incidenttypecharacteristic_msdyn_bookingalerts)
- [msdyn_incidenttypeproduct_msdyn_bookingalerts](#BKMK_msdyn_incidenttypeproduct_msdyn_bookingalerts)
- [msdyn_incidenttypeservice_msdyn_bookingalerts](#BKMK_msdyn_incidenttypeservice_msdyn_bookingalerts)
- [msdyn_inventoryadjustment_msdyn_bookingalerts](#BKMK_msdyn_inventoryadjustment_msdyn_bookingalerts)
- [msdyn_inventoryadjustmentproduct_msdyn_bookingalerts](#BKMK_msdyn_inventoryadjustmentproduct_msdyn_bookingalerts)
- [msdyn_inventoryjournal_msdyn_bookingalerts](#BKMK_msdyn_inventoryjournal_msdyn_bookingalerts)
- [msdyn_inventorytransfer_msdyn_bookingalerts](#BKMK_msdyn_inventorytransfer_msdyn_bookingalerts)
- [msdyn_payment_msdyn_bookingalerts](#BKMK_msdyn_payment_msdyn_bookingalerts)
- [msdyn_paymentdetail_msdyn_bookingalerts](#BKMK_msdyn_paymentdetail_msdyn_bookingalerts)
- [msdyn_paymentmethod_msdyn_bookingalerts](#BKMK_msdyn_paymentmethod_msdyn_bookingalerts)
- [msdyn_paymentterm_msdyn_bookingalerts](#BKMK_msdyn_paymentterm_msdyn_bookingalerts)
- [msdyn_postalcode_msdyn_bookingalerts](#BKMK_msdyn_postalcode_msdyn_bookingalerts)
- [msdyn_productinventory_msdyn_bookingalerts](#BKMK_msdyn_productinventory_msdyn_bookingalerts)
- [msdyn_purchaseorder_msdyn_bookingalerts](#BKMK_msdyn_purchaseorder_msdyn_bookingalerts)
- [msdyn_purchaseorderbill_msdyn_bookingalerts](#BKMK_msdyn_purchaseorderbill_msdyn_bookingalerts)
- [msdyn_purchaseorderproduct_msdyn_bookingalerts](#BKMK_msdyn_purchaseorderproduct_msdyn_bookingalerts)
- [msdyn_purchaseorderreceipt_msdyn_bookingalerts](#BKMK_msdyn_purchaseorderreceipt_msdyn_bookingalerts)
- [msdyn_purchaseorderreceiptproduct_msdyn_bookingalerts](#BKMK_msdyn_purchaseorderreceiptproduct_msdyn_bookingalerts)
- [msdyn_purchaseordersubstatus_msdyn_bookingalerts](#BKMK_msdyn_purchaseordersubstatus_msdyn_bookingalerts)
- [msdyn_quotebookingincident_msdyn_bookingalerts](#BKMK_msdyn_quotebookingincident_msdyn_bookingalerts)
- [msdyn_quotebookingproduct_msdyn_bookingalerts](#BKMK_msdyn_quotebookingproduct_msdyn_bookingalerts)
- [msdyn_quotebookingservice_msdyn_bookingalerts](#BKMK_msdyn_quotebookingservice_msdyn_bookingalerts)
- [msdyn_quotebookingservicetask_msdyn_bookingalerts](#BKMK_msdyn_quotebookingservicetask_msdyn_bookingalerts)
- [msdyn_rma_msdyn_bookingalerts](#BKMK_msdyn_rma_msdyn_bookingalerts)
- [msdyn_rmaproduct_msdyn_bookingalerts](#BKMK_msdyn_rmaproduct_msdyn_bookingalerts)
- [msdyn_rmareceipt_msdyn_bookingalerts](#BKMK_msdyn_rmareceipt_msdyn_bookingalerts)
- [msdyn_rmareceiptproduct_msdyn_bookingalerts](#BKMK_msdyn_rmareceiptproduct_msdyn_bookingalerts)
- [msdyn_rmasubstatus_msdyn_bookingalerts](#BKMK_msdyn_rmasubstatus_msdyn_bookingalerts)
- [msdyn_rtv_msdyn_bookingalerts](#BKMK_msdyn_rtv_msdyn_bookingalerts)
- [msdyn_rtvproduct_msdyn_bookingalerts](#BKMK_msdyn_rtvproduct_msdyn_bookingalerts)
- [msdyn_rtvsubstatus_msdyn_bookingalerts](#BKMK_msdyn_rtvsubstatus_msdyn_bookingalerts)
- [msdyn_shipvia_msdyn_bookingalerts](#BKMK_msdyn_shipvia_msdyn_bookingalerts)
- [msdyn_timeoffrequest_msdyn_bookingalerts](#BKMK_msdyn_timeoffrequest_msdyn_bookingalerts)
- [msdyn_warehouse_msdyn_bookingalerts](#BKMK_msdyn_warehouse_msdyn_bookingalerts)
- [msdyn_workorder_msdyn_bookingalerts](#BKMK_msdyn_workorder_msdyn_bookingalerts)
- [msdyn_workordercharacteristic_msdyn_bookingalerts](#BKMK_msdyn_workordercharacteristic_msdyn_bookingalerts)
- [msdyn_workorderincident_msdyn_bookingalerts](#BKMK_msdyn_workorderincident_msdyn_bookingalerts)
- [msdyn_workorderproduct_msdyn_bookingalerts](#BKMK_msdyn_workorderproduct_msdyn_bookingalerts)
- [msdyn_workorderresourcerestriction_msdyn_bookingalerts](#BKMK_msdyn_workorderresourcerestriction_msdyn_bookingalerts)
- [msdyn_workorderservice_msdyn_bookingalerts](#BKMK_msdyn_workorderservice_msdyn_bookingalerts)
- [msdyn_workorderservicetask_msdyn_bookingalerts](#BKMK_msdyn_workorderservicetask_msdyn_bookingalerts)


### <a name="BKMK_lead_msdyn_bookingalerts"></a> lead_msdyn_bookingalerts

**Added by**: Lead Management Solution

See lead Entity [lead_msdyn_bookingalerts](lead.md#BKMK_lead_msdyn_bookingalerts) One-To-Many relationship.

### <a name="BKMK_bookableresourcebooking_msdyn_bookingalerts"></a> bookableresourcebooking_msdyn_bookingalerts

**Added by**: Scheduling Solution

See bookableresourcebooking Entity [bookableresourcebooking_msdyn_bookingalerts](bookableresourcebooking.md#BKMK_bookableresourcebooking_msdyn_bookingalerts) One-To-Many relationship.

### <a name="BKMK_bookableresourcebookingheader_msdyn_bookingalerts"></a> bookableresourcebookingheader_msdyn_bookingalerts

**Added by**: Scheduling Solution

See bookableresourcebookingheader Entity [bookableresourcebookingheader_msdyn_bookingalerts](bookableresourcebookingheader.md#BKMK_bookableresourcebookingheader_msdyn_bookingalerts) One-To-Many relationship.

### <a name="BKMK_bulkoperation_msdyn_bookingalerts"></a> bulkoperation_msdyn_bookingalerts

**Added by**: Marketing Solution

See bulkoperation Entity [bulkoperation_msdyn_bookingalerts](bulkoperation.md#BKMK_bulkoperation_msdyn_bookingalerts) One-To-Many relationship.

### <a name="BKMK_campaign_msdyn_bookingalerts"></a> campaign_msdyn_bookingalerts

**Added by**: Marketing Solution

See campaign Entity [campaign_msdyn_bookingalerts](campaign.md#BKMK_campaign_msdyn_bookingalerts) One-To-Many relationship.

### <a name="BKMK_campaignactivity_msdyn_bookingalerts"></a> campaignactivity_msdyn_bookingalerts

**Added by**: Marketing Solution

See campaignactivity Entity [campaignactivity_msdyn_bookingalerts](campaignactivity.md#BKMK_campaignactivity_msdyn_bookingalerts) One-To-Many relationship.

### <a name="BKMK_contract_msdyn_bookingalerts"></a> contract_msdyn_bookingalerts

**Added by**: Service Solution

See contract Entity [contract_msdyn_bookingalerts](contract.md#BKMK_contract_msdyn_bookingalerts) One-To-Many relationship.

### <a name="BKMK_entitlement_msdyn_bookingalerts"></a> entitlement_msdyn_bookingalerts

**Added by**: Service Solution

See entitlement Entity [entitlement_msdyn_bookingalerts](entitlement.md#BKMK_entitlement_msdyn_bookingalerts) One-To-Many relationship.

### <a name="BKMK_entitlementtemplate_msdyn_bookingalerts"></a> entitlementtemplate_msdyn_bookingalerts

**Added by**: Service Solution

See entitlementtemplate Entity [entitlementtemplate_msdyn_bookingalerts](entitlementtemplate.md#BKMK_entitlementtemplate_msdyn_bookingalerts) One-To-Many relationship.

### <a name="BKMK_incident_msdyn_bookingalerts"></a> incident_msdyn_bookingalerts

**Added by**: Service Solution

See incident Entity [incident_msdyn_bookingalerts](incident.md#BKMK_incident_msdyn_bookingalerts) One-To-Many relationship.

### <a name="BKMK_site_msdyn_bookingalerts"></a> site_msdyn_bookingalerts

**Added by**: Service Solution

See site Entity [site_msdyn_bookingalerts](site.md#BKMK_site_msdyn_bookingalerts) One-To-Many relationship.

### <a name="BKMK_msdyn_bookingalert_service_serviceid"></a> msdyn_bookingalert_service_serviceid

**Added by**: Service Solution

See service Entity [msdyn_bookingalert_service_serviceid](service.md#BKMK_msdyn_bookingalert_service_serviceid) One-To-Many relationship.

### <a name="BKMK_msdyn_playbookinstance_msdyn_bookingalerts"></a> msdyn_playbookinstance_msdyn_bookingalerts

**Added by**: Playbook Solution

See msdyn_playbookinstance Entity [msdyn_playbookinstance_msdyn_bookingalerts](msdyn_playbookinstance.md#BKMK_msdyn_playbookinstance_msdyn_bookingalerts) One-To-Many relationship.

### <a name="BKMK_invoice_msdyn_bookingalerts"></a> invoice_msdyn_bookingalerts

**Added by**: Sales Solution

See invoice Entity [invoice_msdyn_bookingalerts](invoice.md#BKMK_invoice_msdyn_bookingalerts) One-To-Many relationship.

### <a name="BKMK_opportunity_msdyn_bookingalerts"></a> opportunity_msdyn_bookingalerts

**Added by**: Sales Solution

See opportunity Entity [opportunity_msdyn_bookingalerts](opportunity.md#BKMK_opportunity_msdyn_bookingalerts) One-To-Many relationship.

### <a name="BKMK_quote_msdyn_bookingalerts"></a> quote_msdyn_bookingalerts

**Added by**: Sales Solution

See quote Entity [quote_msdyn_bookingalerts](quote.md#BKMK_quote_msdyn_bookingalerts) One-To-Many relationship.

### <a name="BKMK_salesorder_msdyn_bookingalerts"></a> salesorder_msdyn_bookingalerts

**Added by**: Sales Solution

See salesorder Entity [salesorder_msdyn_bookingalerts](salesorder.md#BKMK_salesorder_msdyn_bookingalerts) One-To-Many relationship.

### <a name="BKMK_msdyn_postalbum_msdyn_bookingalerts"></a> msdyn_postalbum_msdyn_bookingalerts

**Added by**: Activity Feeds Solution

See msdyn_postalbum Entity [msdyn_postalbum_msdyn_bookingalerts](msdyn_postalbum.md#BKMK_msdyn_postalbum_msdyn_bookingalerts) One-To-Many relationship.

### <a name="BKMK_interactionforemail_msdyn_bookingalerts"></a> interactionforemail_msdyn_bookingalerts

**Added by**: System Solution Solution

See interactionforemail Entity [interactionforemail_msdyn_bookingalerts](interactionforemail.md#BKMK_interactionforemail_msdyn_bookingalerts) One-To-Many relationship.

### <a name="BKMK_knowledgebaserecord_msdyn_bookingalerts"></a> knowledgebaserecord_msdyn_bookingalerts

**Added by**: System Solution Solution

See knowledgebaserecord Entity [knowledgebaserecord_msdyn_bookingalerts](knowledgebaserecord.md#BKMK_knowledgebaserecord_msdyn_bookingalerts) One-To-Many relationship.

### <a name="BKMK_account_msdyn_bookingalerts"></a> account_msdyn_bookingalerts

**Added by**: System Solution Solution

See account Entity [account_msdyn_bookingalerts](account.md#BKMK_account_msdyn_bookingalerts) One-To-Many relationship.

### <a name="BKMK_msdyn_bookingalert_systemuser_createdby"></a> msdyn_bookingalert_systemuser_createdby

**Added by**: System Solution Solution

See systemuser Entity [msdyn_bookingalert_systemuser_createdby](systemuser.md#BKMK_msdyn_bookingalert_systemuser_createdby) One-To-Many relationship.

### <a name="BKMK_contact_msdyn_bookingalerts"></a> contact_msdyn_bookingalerts

**Added by**: System Solution Solution

See contact Entity [contact_msdyn_bookingalerts](contact.md#BKMK_contact_msdyn_bookingalerts) One-To-Many relationship.

### <a name="BKMK_msdyn_bookingalert_mailbox_sendermailboxid"></a> msdyn_bookingalert_mailbox_sendermailboxid

**Added by**: System Solution Solution

See mailbox Entity [msdyn_bookingalert_mailbox_sendermailboxid](mailbox.md#BKMK_msdyn_bookingalert_mailbox_sendermailboxid) One-To-Many relationship.

### <a name="BKMK_msdyn_bookingalert_transactioncurrency_transactioncurrencyid"></a> msdyn_bookingalert_transactioncurrency_transactioncurrencyid

**Added by**: System Solution Solution

See transactioncurrency Entity [msdyn_bookingalert_transactioncurrency_transactioncurrencyid](transactioncurrency.md#BKMK_msdyn_bookingalert_transactioncurrency_transactioncurrencyid) One-To-Many relationship.

### <a name="BKMK_msdyn_bookingalert_systemuser_owninguser"></a> msdyn_bookingalert_systemuser_owninguser

**Added by**: System Solution Solution

See systemuser Entity [msdyn_bookingalert_systemuser_owninguser](systemuser.md#BKMK_msdyn_bookingalert_systemuser_owninguser) One-To-Many relationship.

### <a name="BKMK_msdyn_bookingalert_sla_slaid"></a> msdyn_bookingalert_sla_slaid

**Added by**: System Solution Solution

See sla Entity [msdyn_bookingalert_sla_slaid](sla.md#BKMK_msdyn_bookingalert_sla_slaid) One-To-Many relationship.

### <a name="BKMK_msdyn_bookingalert_businessunit_owningbusinessunit"></a> msdyn_bookingalert_businessunit_owningbusinessunit

**Added by**: System Solution Solution

See businessunit Entity [msdyn_bookingalert_businessunit_owningbusinessunit](businessunit.md#BKMK_msdyn_bookingalert_businessunit_owningbusinessunit) One-To-Many relationship.

### <a name="BKMK_knowledgearticle_msdyn_bookingalerts"></a> knowledgearticle_msdyn_bookingalerts

**Added by**: System Solution Solution

See knowledgearticle Entity [knowledgearticle_msdyn_bookingalerts](knowledgearticle.md#BKMK_knowledgearticle_msdyn_bookingalerts) One-To-Many relationship.

### <a name="BKMK_msdyn_bookingalert_systemuser_modifiedonbehalfby"></a> msdyn_bookingalert_systemuser_modifiedonbehalfby

**Added by**: System Solution Solution

See systemuser Entity [msdyn_bookingalert_systemuser_modifiedonbehalfby](systemuser.md#BKMK_msdyn_bookingalert_systemuser_modifiedonbehalfby) One-To-Many relationship.

### <a name="BKMK_msdyn_bookingalert_systemuser_createdonbehalfby"></a> msdyn_bookingalert_systemuser_createdonbehalfby

**Added by**: System Solution Solution

See systemuser Entity [msdyn_bookingalert_systemuser_createdonbehalfby](systemuser.md#BKMK_msdyn_bookingalert_systemuser_createdonbehalfby) One-To-Many relationship.

### <a name="BKMK_msdyn_bookingalert_systemuser_modifiedby"></a> msdyn_bookingalert_systemuser_modifiedby

**Added by**: System Solution Solution

See systemuser Entity [msdyn_bookingalert_systemuser_modifiedby](systemuser.md#BKMK_msdyn_bookingalert_systemuser_modifiedby) One-To-Many relationship.

### <a name="BKMK_msdyn_bookingalert_team_owningteam"></a> msdyn_bookingalert_team_owningteam

**Added by**: System Solution Solution

See team Entity [msdyn_bookingalert_team_owningteam](team.md#BKMK_msdyn_bookingalert_team_owningteam) One-To-Many relationship.

### <a name="BKMK_msdyn_bookingalert_sla_slainvokedid"></a> msdyn_bookingalert_sla_slainvokedid

**Added by**: System Solution Solution

See sla Entity [msdyn_bookingalert_sla_slainvokedid](sla.md#BKMK_msdyn_bookingalert_sla_slainvokedid) One-To-Many relationship.

### <a name="BKMK_activity_pointer_msdyn_bookingalert"></a> activity_pointer_msdyn_bookingalert

**Added by**: System Solution Solution

See activitypointer Entity [activity_pointer_msdyn_bookingalert](activitypointer.md#BKMK_activity_pointer_msdyn_bookingalert) One-To-Many relationship.

### <a name="BKMK_msdyn_bookingalertstatus_msdyn_bookingalerts"></a> msdyn_bookingalertstatus_msdyn_bookingalerts

See msdyn_bookingalertstatus Entity [msdyn_bookingalertstatus_msdyn_bookingalerts](msdyn_bookingalertstatus.md#BKMK_msdyn_bookingalertstatus_msdyn_bookingalerts) One-To-Many relationship.

### <a name="BKMK_msdyn_bookingrule_msdyn_bookingalerts"></a> msdyn_bookingrule_msdyn_bookingalerts

See msdyn_bookingrule Entity [msdyn_bookingrule_msdyn_bookingalerts](msdyn_bookingrule.md#BKMK_msdyn_bookingrule_msdyn_bookingalerts) One-To-Many relationship.

### <a name="BKMK_msdyn_resourceterritory_msdyn_bookingalerts"></a> msdyn_resourceterritory_msdyn_bookingalerts

See msdyn_resourceterritory Entity [msdyn_resourceterritory_msdyn_bookingalerts](msdyn_resourceterritory.md#BKMK_msdyn_resourceterritory_msdyn_bookingalerts) One-To-Many relationship.

### <a name="BKMK_msdyn_systemuserschedulersetting_msdyn_bookingalerts"></a> msdyn_systemuserschedulersetting_msdyn_bookingalerts

See msdyn_systemuserschedulersetting Entity [msdyn_systemuserschedulersetting_msdyn_bookingalerts](msdyn_systemuserschedulersetting.md#BKMK_msdyn_systemuserschedulersetting_msdyn_bookingalerts) One-To-Many relationship.

### <a name="BKMK_msdyn_timegroup_msdyn_bookingalerts"></a> msdyn_timegroup_msdyn_bookingalerts

See msdyn_timegroup Entity [msdyn_timegroup_msdyn_bookingalerts](msdyn_timegroup.md#BKMK_msdyn_timegroup_msdyn_bookingalerts) One-To-Many relationship.

### <a name="BKMK_msdyn_timegroupdetail_msdyn_bookingalerts"></a> msdyn_timegroupdetail_msdyn_bookingalerts

See msdyn_timegroupdetail Entity [msdyn_timegroupdetail_msdyn_bookingalerts](msdyn_timegroupdetail.md#BKMK_msdyn_timegroupdetail_msdyn_bookingalerts) One-To-Many relationship.

### <a name="BKMK_msdyn_processnotes_msdyn_bookingalerts"></a> msdyn_processnotes_msdyn_bookingalerts

**Added by**: Project Service Automation Solution

See msdyn_processnotes Entity [msdyn_processnotes_msdyn_bookingalerts](msdyn_processnotes.md#BKMK_msdyn_processnotes_msdyn_bookingalerts) One-To-Many relationship.

### <a name="BKMK_msdyn_projectteam_msdyn_bookingalerts"></a> msdyn_projectteam_msdyn_bookingalerts

**Added by**: Project Service Automation Solution

See msdyn_projectteam Entity [msdyn_projectteam_msdyn_bookingalerts](msdyn_projectteam.md#BKMK_msdyn_projectteam_msdyn_bookingalerts) One-To-Many relationship.

### <a name="BKMK_msdyn_agreement_msdyn_bookingalerts"></a> msdyn_agreement_msdyn_bookingalerts

**Added by**: Field Service Solution

See msdyn_agreement Entity [msdyn_agreement_msdyn_bookingalerts](msdyn_agreement.md#BKMK_msdyn_agreement_msdyn_bookingalerts) One-To-Many relationship.

### <a name="BKMK_msdyn_agreementbookingdate_msdyn_bookingalerts"></a> msdyn_agreementbookingdate_msdyn_bookingalerts

**Added by**: Field Service Solution

See msdyn_agreementbookingdate Entity [msdyn_agreementbookingdate_msdyn_bookingalerts](msdyn_agreementbookingdate.md#BKMK_msdyn_agreementbookingdate_msdyn_bookingalerts) One-To-Many relationship.

### <a name="BKMK_msdyn_agreementbookingincident_msdyn_bookingalerts"></a> msdyn_agreementbookingincident_msdyn_bookingalerts

**Added by**: Field Service Solution

See msdyn_agreementbookingincident Entity [msdyn_agreementbookingincident_msdyn_bookingalerts](msdyn_agreementbookingincident.md#BKMK_msdyn_agreementbookingincident_msdyn_bookingalerts) One-To-Many relationship.

### <a name="BKMK_msdyn_agreementbookingproduct_msdyn_bookingalerts"></a> msdyn_agreementbookingproduct_msdyn_bookingalerts

**Added by**: Field Service Solution

See msdyn_agreementbookingproduct Entity [msdyn_agreementbookingproduct_msdyn_bookingalerts](msdyn_agreementbookingproduct.md#BKMK_msdyn_agreementbookingproduct_msdyn_bookingalerts) One-To-Many relationship.

### <a name="BKMK_msdyn_agreementbookingservice_msdyn_bookingalerts"></a> msdyn_agreementbookingservice_msdyn_bookingalerts

**Added by**: Field Service Solution

See msdyn_agreementbookingservice Entity [msdyn_agreementbookingservice_msdyn_bookingalerts](msdyn_agreementbookingservice.md#BKMK_msdyn_agreementbookingservice_msdyn_bookingalerts) One-To-Many relationship.

### <a name="BKMK_msdyn_agreementbookingservicetask_msdyn_bookingalerts"></a> msdyn_agreementbookingservicetask_msdyn_bookingalerts

**Added by**: Field Service Solution

See msdyn_agreementbookingservicetask Entity [msdyn_agreementbookingservicetask_msdyn_bookingalerts](msdyn_agreementbookingservicetask.md#BKMK_msdyn_agreementbookingservicetask_msdyn_bookingalerts) One-To-Many relationship.

### <a name="BKMK_msdyn_agreementbookingsetup_msdyn_bookingalerts"></a> msdyn_agreementbookingsetup_msdyn_bookingalerts

**Added by**: Field Service Solution

See msdyn_agreementbookingsetup Entity [msdyn_agreementbookingsetup_msdyn_bookingalerts](msdyn_agreementbookingsetup.md#BKMK_msdyn_agreementbookingsetup_msdyn_bookingalerts) One-To-Many relationship.

### <a name="BKMK_msdyn_agreementinvoicedate_msdyn_bookingalerts"></a> msdyn_agreementinvoicedate_msdyn_bookingalerts

**Added by**: Field Service Solution

See msdyn_agreementinvoicedate Entity [msdyn_agreementinvoicedate_msdyn_bookingalerts](msdyn_agreementinvoicedate.md#BKMK_msdyn_agreementinvoicedate_msdyn_bookingalerts) One-To-Many relationship.

### <a name="BKMK_msdyn_agreementinvoiceproduct_msdyn_bookingalerts"></a> msdyn_agreementinvoiceproduct_msdyn_bookingalerts

**Added by**: Field Service Solution

See msdyn_agreementinvoiceproduct Entity [msdyn_agreementinvoiceproduct_msdyn_bookingalerts](msdyn_agreementinvoiceproduct.md#BKMK_msdyn_agreementinvoiceproduct_msdyn_bookingalerts) One-To-Many relationship.

### <a name="BKMK_msdyn_agreementinvoicesetup_msdyn_bookingalerts"></a> msdyn_agreementinvoicesetup_msdyn_bookingalerts

**Added by**: Field Service Solution

See msdyn_agreementinvoicesetup Entity [msdyn_agreementinvoicesetup_msdyn_bookingalerts](msdyn_agreementinvoicesetup.md#BKMK_msdyn_agreementinvoicesetup_msdyn_bookingalerts) One-To-Many relationship.

### <a name="BKMK_msdyn_bookingtimestamp_msdyn_bookingalerts"></a> msdyn_bookingtimestamp_msdyn_bookingalerts

**Added by**: Field Service Solution

See msdyn_bookingtimestamp Entity [msdyn_bookingtimestamp_msdyn_bookingalerts](msdyn_bookingtimestamp.md#BKMK_msdyn_bookingtimestamp_msdyn_bookingalerts) One-To-Many relationship.

### <a name="BKMK_msdyn_customerasset_msdyn_bookingalerts"></a> msdyn_customerasset_msdyn_bookingalerts

**Added by**: Field Service Solution

See msdyn_customerasset Entity [msdyn_customerasset_msdyn_bookingalerts](msdyn_customerasset.md#BKMK_msdyn_customerasset_msdyn_bookingalerts) One-To-Many relationship.

### <a name="BKMK_msdyn_fieldservicesetting_msdyn_bookingalerts"></a> msdyn_fieldservicesetting_msdyn_bookingalerts

**Added by**: Field Service Solution

See msdyn_fieldservicesetting Entity [msdyn_fieldservicesetting_msdyn_bookingalerts](msdyn_fieldservicesetting.md#BKMK_msdyn_fieldservicesetting_msdyn_bookingalerts) One-To-Many relationship.

### <a name="BKMK_msdyn_incidenttypecharacteristic_msdyn_bookingalerts"></a> msdyn_incidenttypecharacteristic_msdyn_bookingalerts

**Added by**: Field Service Solution

See msdyn_incidenttypecharacteristic Entity [msdyn_incidenttypecharacteristic_msdyn_bookingalerts](msdyn_incidenttypecharacteristic.md#BKMK_msdyn_incidenttypecharacteristic_msdyn_bookingalerts) One-To-Many relationship.

### <a name="BKMK_msdyn_incidenttypeproduct_msdyn_bookingalerts"></a> msdyn_incidenttypeproduct_msdyn_bookingalerts

**Added by**: Field Service Solution

See msdyn_incidenttypeproduct Entity [msdyn_incidenttypeproduct_msdyn_bookingalerts](msdyn_incidenttypeproduct.md#BKMK_msdyn_incidenttypeproduct_msdyn_bookingalerts) One-To-Many relationship.

### <a name="BKMK_msdyn_incidenttypeservice_msdyn_bookingalerts"></a> msdyn_incidenttypeservice_msdyn_bookingalerts

**Added by**: Field Service Solution

See msdyn_incidenttypeservice Entity [msdyn_incidenttypeservice_msdyn_bookingalerts](msdyn_incidenttypeservice.md#BKMK_msdyn_incidenttypeservice_msdyn_bookingalerts) One-To-Many relationship.

### <a name="BKMK_msdyn_inventoryadjustment_msdyn_bookingalerts"></a> msdyn_inventoryadjustment_msdyn_bookingalerts

**Added by**: Field Service Solution

See msdyn_inventoryadjustment Entity [msdyn_inventoryadjustment_msdyn_bookingalerts](msdyn_inventoryadjustment.md#BKMK_msdyn_inventoryadjustment_msdyn_bookingalerts) One-To-Many relationship.

### <a name="BKMK_msdyn_inventoryadjustmentproduct_msdyn_bookingalerts"></a> msdyn_inventoryadjustmentproduct_msdyn_bookingalerts

**Added by**: Field Service Solution

See msdyn_inventoryadjustmentproduct Entity [msdyn_inventoryadjustmentproduct_msdyn_bookingalerts](msdyn_inventoryadjustmentproduct.md#BKMK_msdyn_inventoryadjustmentproduct_msdyn_bookingalerts) One-To-Many relationship.

### <a name="BKMK_msdyn_inventoryjournal_msdyn_bookingalerts"></a> msdyn_inventoryjournal_msdyn_bookingalerts

**Added by**: Field Service Solution

See msdyn_inventoryjournal Entity [msdyn_inventoryjournal_msdyn_bookingalerts](msdyn_inventoryjournal.md#BKMK_msdyn_inventoryjournal_msdyn_bookingalerts) One-To-Many relationship.

### <a name="BKMK_msdyn_inventorytransfer_msdyn_bookingalerts"></a> msdyn_inventorytransfer_msdyn_bookingalerts

**Added by**: Field Service Solution

See msdyn_inventorytransfer Entity [msdyn_inventorytransfer_msdyn_bookingalerts](msdyn_inventorytransfer.md#BKMK_msdyn_inventorytransfer_msdyn_bookingalerts) One-To-Many relationship.

### <a name="BKMK_msdyn_payment_msdyn_bookingalerts"></a> msdyn_payment_msdyn_bookingalerts

**Added by**: Field Service Solution

See msdyn_payment Entity [msdyn_payment_msdyn_bookingalerts](msdyn_payment.md#BKMK_msdyn_payment_msdyn_bookingalerts) One-To-Many relationship.

### <a name="BKMK_msdyn_paymentdetail_msdyn_bookingalerts"></a> msdyn_paymentdetail_msdyn_bookingalerts

**Added by**: Field Service Solution

See msdyn_paymentdetail Entity [msdyn_paymentdetail_msdyn_bookingalerts](msdyn_paymentdetail.md#BKMK_msdyn_paymentdetail_msdyn_bookingalerts) One-To-Many relationship.

### <a name="BKMK_msdyn_paymentmethod_msdyn_bookingalerts"></a> msdyn_paymentmethod_msdyn_bookingalerts

**Added by**: Field Service Solution

See msdyn_paymentmethod Entity [msdyn_paymentmethod_msdyn_bookingalerts](msdyn_paymentmethod.md#BKMK_msdyn_paymentmethod_msdyn_bookingalerts) One-To-Many relationship.

### <a name="BKMK_msdyn_paymentterm_msdyn_bookingalerts"></a> msdyn_paymentterm_msdyn_bookingalerts

**Added by**: Field Service Solution

See msdyn_paymentterm Entity [msdyn_paymentterm_msdyn_bookingalerts](msdyn_paymentterm.md#BKMK_msdyn_paymentterm_msdyn_bookingalerts) One-To-Many relationship.

### <a name="BKMK_msdyn_postalcode_msdyn_bookingalerts"></a> msdyn_postalcode_msdyn_bookingalerts

**Added by**: Field Service Solution

See msdyn_postalcode Entity [msdyn_postalcode_msdyn_bookingalerts](msdyn_postalcode.md#BKMK_msdyn_postalcode_msdyn_bookingalerts) One-To-Many relationship.

### <a name="BKMK_msdyn_productinventory_msdyn_bookingalerts"></a> msdyn_productinventory_msdyn_bookingalerts

**Added by**: Field Service Solution

See msdyn_productinventory Entity [msdyn_productinventory_msdyn_bookingalerts](msdyn_productinventory.md#BKMK_msdyn_productinventory_msdyn_bookingalerts) One-To-Many relationship.

### <a name="BKMK_msdyn_purchaseorder_msdyn_bookingalerts"></a> msdyn_purchaseorder_msdyn_bookingalerts

**Added by**: Field Service Solution

See msdyn_purchaseorder Entity [msdyn_purchaseorder_msdyn_bookingalerts](msdyn_purchaseorder.md#BKMK_msdyn_purchaseorder_msdyn_bookingalerts) One-To-Many relationship.

### <a name="BKMK_msdyn_purchaseorderbill_msdyn_bookingalerts"></a> msdyn_purchaseorderbill_msdyn_bookingalerts

**Added by**: Field Service Solution

See msdyn_purchaseorderbill Entity [msdyn_purchaseorderbill_msdyn_bookingalerts](msdyn_purchaseorderbill.md#BKMK_msdyn_purchaseorderbill_msdyn_bookingalerts) One-To-Many relationship.

### <a name="BKMK_msdyn_purchaseorderproduct_msdyn_bookingalerts"></a> msdyn_purchaseorderproduct_msdyn_bookingalerts

**Added by**: Field Service Solution

See msdyn_purchaseorderproduct Entity [msdyn_purchaseorderproduct_msdyn_bookingalerts](msdyn_purchaseorderproduct.md#BKMK_msdyn_purchaseorderproduct_msdyn_bookingalerts) One-To-Many relationship.

### <a name="BKMK_msdyn_purchaseorderreceipt_msdyn_bookingalerts"></a> msdyn_purchaseorderreceipt_msdyn_bookingalerts

**Added by**: Field Service Solution

See msdyn_purchaseorderreceipt Entity [msdyn_purchaseorderreceipt_msdyn_bookingalerts](msdyn_purchaseorderreceipt.md#BKMK_msdyn_purchaseorderreceipt_msdyn_bookingalerts) One-To-Many relationship.

### <a name="BKMK_msdyn_purchaseorderreceiptproduct_msdyn_bookingalerts"></a> msdyn_purchaseorderreceiptproduct_msdyn_bookingalerts

**Added by**: Field Service Solution

See msdyn_purchaseorderreceiptproduct Entity [msdyn_purchaseorderreceiptproduct_msdyn_bookingalerts](msdyn_purchaseorderreceiptproduct.md#BKMK_msdyn_purchaseorderreceiptproduct_msdyn_bookingalerts) One-To-Many relationship.

### <a name="BKMK_msdyn_purchaseordersubstatus_msdyn_bookingalerts"></a> msdyn_purchaseordersubstatus_msdyn_bookingalerts

**Added by**: Field Service Solution

See msdyn_purchaseordersubstatus Entity [msdyn_purchaseordersubstatus_msdyn_bookingalerts](msdyn_purchaseordersubstatus.md#BKMK_msdyn_purchaseordersubstatus_msdyn_bookingalerts) One-To-Many relationship.

### <a name="BKMK_msdyn_quotebookingincident_msdyn_bookingalerts"></a> msdyn_quotebookingincident_msdyn_bookingalerts

**Added by**: Field Service Solution

See msdyn_quotebookingincident Entity [msdyn_quotebookingincident_msdyn_bookingalerts](msdyn_quotebookingincident.md#BKMK_msdyn_quotebookingincident_msdyn_bookingalerts) One-To-Many relationship.

### <a name="BKMK_msdyn_quotebookingproduct_msdyn_bookingalerts"></a> msdyn_quotebookingproduct_msdyn_bookingalerts

**Added by**: Field Service Solution

See msdyn_quotebookingproduct Entity [msdyn_quotebookingproduct_msdyn_bookingalerts](msdyn_quotebookingproduct.md#BKMK_msdyn_quotebookingproduct_msdyn_bookingalerts) One-To-Many relationship.

### <a name="BKMK_msdyn_quotebookingservice_msdyn_bookingalerts"></a> msdyn_quotebookingservice_msdyn_bookingalerts

**Added by**: Field Service Solution

See msdyn_quotebookingservice Entity [msdyn_quotebookingservice_msdyn_bookingalerts](msdyn_quotebookingservice.md#BKMK_msdyn_quotebookingservice_msdyn_bookingalerts) One-To-Many relationship.

### <a name="BKMK_msdyn_quotebookingservicetask_msdyn_bookingalerts"></a> msdyn_quotebookingservicetask_msdyn_bookingalerts

**Added by**: Field Service Solution

See msdyn_quotebookingservicetask Entity [msdyn_quotebookingservicetask_msdyn_bookingalerts](msdyn_quotebookingservicetask.md#BKMK_msdyn_quotebookingservicetask_msdyn_bookingalerts) One-To-Many relationship.

### <a name="BKMK_msdyn_rma_msdyn_bookingalerts"></a> msdyn_rma_msdyn_bookingalerts

**Added by**: Field Service Solution

See msdyn_rma Entity [msdyn_rma_msdyn_bookingalerts](msdyn_rma.md#BKMK_msdyn_rma_msdyn_bookingalerts) One-To-Many relationship.

### <a name="BKMK_msdyn_rmaproduct_msdyn_bookingalerts"></a> msdyn_rmaproduct_msdyn_bookingalerts

**Added by**: Field Service Solution

See msdyn_rmaproduct Entity [msdyn_rmaproduct_msdyn_bookingalerts](msdyn_rmaproduct.md#BKMK_msdyn_rmaproduct_msdyn_bookingalerts) One-To-Many relationship.

### <a name="BKMK_msdyn_rmareceipt_msdyn_bookingalerts"></a> msdyn_rmareceipt_msdyn_bookingalerts

**Added by**: Field Service Solution

See msdyn_rmareceipt Entity [msdyn_rmareceipt_msdyn_bookingalerts](msdyn_rmareceipt.md#BKMK_msdyn_rmareceipt_msdyn_bookingalerts) One-To-Many relationship.

### <a name="BKMK_msdyn_rmareceiptproduct_msdyn_bookingalerts"></a> msdyn_rmareceiptproduct_msdyn_bookingalerts

**Added by**: Field Service Solution

See msdyn_rmareceiptproduct Entity [msdyn_rmareceiptproduct_msdyn_bookingalerts](msdyn_rmareceiptproduct.md#BKMK_msdyn_rmareceiptproduct_msdyn_bookingalerts) One-To-Many relationship.

### <a name="BKMK_msdyn_rmasubstatus_msdyn_bookingalerts"></a> msdyn_rmasubstatus_msdyn_bookingalerts

**Added by**: Field Service Solution

See msdyn_rmasubstatus Entity [msdyn_rmasubstatus_msdyn_bookingalerts](msdyn_rmasubstatus.md#BKMK_msdyn_rmasubstatus_msdyn_bookingalerts) One-To-Many relationship.

### <a name="BKMK_msdyn_rtv_msdyn_bookingalerts"></a> msdyn_rtv_msdyn_bookingalerts

**Added by**: Field Service Solution

See msdyn_rtv Entity [msdyn_rtv_msdyn_bookingalerts](msdyn_rtv.md#BKMK_msdyn_rtv_msdyn_bookingalerts) One-To-Many relationship.

### <a name="BKMK_msdyn_rtvproduct_msdyn_bookingalerts"></a> msdyn_rtvproduct_msdyn_bookingalerts

**Added by**: Field Service Solution

See msdyn_rtvproduct Entity [msdyn_rtvproduct_msdyn_bookingalerts](msdyn_rtvproduct.md#BKMK_msdyn_rtvproduct_msdyn_bookingalerts) One-To-Many relationship.

### <a name="BKMK_msdyn_rtvsubstatus_msdyn_bookingalerts"></a> msdyn_rtvsubstatus_msdyn_bookingalerts

**Added by**: Field Service Solution

See msdyn_rtvsubstatus Entity [msdyn_rtvsubstatus_msdyn_bookingalerts](msdyn_rtvsubstatus.md#BKMK_msdyn_rtvsubstatus_msdyn_bookingalerts) One-To-Many relationship.

### <a name="BKMK_msdyn_shipvia_msdyn_bookingalerts"></a> msdyn_shipvia_msdyn_bookingalerts

**Added by**: Field Service Solution

See msdyn_shipvia Entity [msdyn_shipvia_msdyn_bookingalerts](msdyn_shipvia.md#BKMK_msdyn_shipvia_msdyn_bookingalerts) One-To-Many relationship.

### <a name="BKMK_msdyn_timeoffrequest_msdyn_bookingalerts"></a> msdyn_timeoffrequest_msdyn_bookingalerts

**Added by**: Field Service Solution

See msdyn_timeoffrequest Entity [msdyn_timeoffrequest_msdyn_bookingalerts](msdyn_timeoffrequest.md#BKMK_msdyn_timeoffrequest_msdyn_bookingalerts) One-To-Many relationship.

### <a name="BKMK_msdyn_warehouse_msdyn_bookingalerts"></a> msdyn_warehouse_msdyn_bookingalerts

**Added by**: Field Service Solution

See msdyn_warehouse Entity [msdyn_warehouse_msdyn_bookingalerts](msdyn_warehouse.md#BKMK_msdyn_warehouse_msdyn_bookingalerts) One-To-Many relationship.

### <a name="BKMK_msdyn_workorder_msdyn_bookingalerts"></a> msdyn_workorder_msdyn_bookingalerts

**Added by**: Field Service Solution

See msdyn_workorder Entity [msdyn_workorder_msdyn_bookingalerts](msdyn_workorder.md#BKMK_msdyn_workorder_msdyn_bookingalerts) One-To-Many relationship.

### <a name="BKMK_msdyn_workordercharacteristic_msdyn_bookingalerts"></a> msdyn_workordercharacteristic_msdyn_bookingalerts

**Added by**: Field Service Solution

See msdyn_workordercharacteristic Entity [msdyn_workordercharacteristic_msdyn_bookingalerts](msdyn_workordercharacteristic.md#BKMK_msdyn_workordercharacteristic_msdyn_bookingalerts) One-To-Many relationship.

### <a name="BKMK_msdyn_workorderincident_msdyn_bookingalerts"></a> msdyn_workorderincident_msdyn_bookingalerts

**Added by**: Field Service Solution

See msdyn_workorderincident Entity [msdyn_workorderincident_msdyn_bookingalerts](msdyn_workorderincident.md#BKMK_msdyn_workorderincident_msdyn_bookingalerts) One-To-Many relationship.

### <a name="BKMK_msdyn_workorderproduct_msdyn_bookingalerts"></a> msdyn_workorderproduct_msdyn_bookingalerts

**Added by**: Field Service Solution

See msdyn_workorderproduct Entity [msdyn_workorderproduct_msdyn_bookingalerts](msdyn_workorderproduct.md#BKMK_msdyn_workorderproduct_msdyn_bookingalerts) One-To-Many relationship.

### <a name="BKMK_msdyn_workorderresourcerestriction_msdyn_bookingalerts"></a> msdyn_workorderresourcerestriction_msdyn_bookingalerts

**Added by**: Field Service Solution

See msdyn_workorderresourcerestriction Entity [msdyn_workorderresourcerestriction_msdyn_bookingalerts](msdyn_workorderresourcerestriction.md#BKMK_msdyn_workorderresourcerestriction_msdyn_bookingalerts) One-To-Many relationship.

### <a name="BKMK_msdyn_workorderservice_msdyn_bookingalerts"></a> msdyn_workorderservice_msdyn_bookingalerts

**Added by**: Field Service Solution

See msdyn_workorderservice Entity [msdyn_workorderservice_msdyn_bookingalerts](msdyn_workorderservice.md#BKMK_msdyn_workorderservice_msdyn_bookingalerts) One-To-Many relationship.

### <a name="BKMK_msdyn_workorderservicetask_msdyn_bookingalerts"></a> msdyn_workorderservicetask_msdyn_bookingalerts

**Added by**: Field Service Solution

See msdyn_workorderservicetask Entity [msdyn_workorderservicetask_msdyn_bookingalerts](msdyn_workorderservicetask.md#BKMK_msdyn_workorderservicetask_msdyn_bookingalerts) One-To-Many relationship.

### See also

[About the Entity Reference](../about-entity-reference.md)<br />
[Programming reference for Dynamics 365 Customer Engagement](../programming-reference.md)<br />
[Web API Reference](/dynamics365/customer-engagement/web-api/about)<br />
<xref href="Microsoft.Dynamics.CRM.msdyn_bookingalert?text=msdyn_bookingalert EntityType" />

[!INCLUDE[footer-include](../../../../includes/footer-banner.md)]