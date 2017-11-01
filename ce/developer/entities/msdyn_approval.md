---
title: "msdyn_approval Entity Reference (Developer Guide for Dynamics 365 Customer Engagement)| MicrosoftDocs"
description: "Includes schema information and supported messages for the msdyn_approval entity."
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
# msdyn_approval Entity Reference

[!INCLUDE[](../../includes/cc_applies_to_update_9_0_0.md)]

Container for approvals.

**Added by**: Project Service Automation Solution<br />

## Messages

|Message|Web API Operation|SDK Assembly|
|-|-|-|
|Assign|PATCH [*org URI*]/api/data/v9.0/msdyn_approvals(*activityid*)<br />[Update](../webapi/update-delete-entities-using-web-api.md#basic-update) `ownerid` property.|<xref:Microsoft.Crm.Sdk.Messages.AssignRequest>|
|Create|POST [*org URI*]/api/data/v9.0/msdyn_approvals<br />See [Create](../webapi/create-entity-web-api.md)|<xref:Microsoft.Xrm.Sdk.Messages.CreateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Create*>|
|Delete|DELETE [*org URI*]/api/data/v9.0/msdyn_approvals(*activityid*)<br />See [Delete](../webapi/update-delete-entities-using-web-api.md#basic-delete)|<xref:Microsoft.Xrm.Sdk.Messages.DeleteRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Delete*>|
|GrantAccess|<xref href="Microsoft.Dynamics.CRM.GrantAccess?text=GrantAccess Action" />|<xref:Microsoft.Crm.Sdk.Messages.GrantAccessRequest>|
|IsValidStateTransition|<xref href="Microsoft.Dynamics.CRM.IsValidStateTransition?text=IsValidStateTransition Function" />|<xref:Microsoft.Crm.Sdk.Messages.IsValidStateTransitionRequest>|
|ModifyAccess|<xref href="Microsoft.Dynamics.CRM.ModifyAccess?text=ModifyAccess Action" />|<xref:Microsoft.Crm.Sdk.Messages.ModifyAccessRequest>|
|Retrieve|GET [*org URI*]/api/data/v9.0/msdyn_approvals(*activityid*)<br />See [Retrieve](../webapi/retrieve-entity-using-web-api.md)|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Retrieve*>|
|RetrieveMultiple|GET [*org URI*]/api/data/v9.0/msdyn_approvals<br />See [Query Data](../webapi/query-data-web-api.md)|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveMultipleRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.RetrieveMultiple*>|
|RetrievePrincipalAccess|<xref href="Microsoft.Dynamics.CRM.RetrievePrincipalAccess?text=RetrievePrincipalAccess Function" />|<xref:Microsoft.Crm.Sdk.Messages.RetrievePrincipalAccessRequest>|
|RetrieveSharedPrincipalsAndAccess|<xref href="Microsoft.Dynamics.CRM.RetrieveSharedPrincipalsAndAccess?text=RetrieveSharedPrincipalsAndAccess Function" />|<xref:Microsoft.Crm.Sdk.Messages.RetrieveSharedPrincipalsAndAccessRequest>|
|RevokeAccess|<xref href="Microsoft.Dynamics.CRM.RevokeAccess?text=RevokeAccess Action" />|<xref:Microsoft.Crm.Sdk.Messages.RevokeAccessRequest>|
|SetState|PATCH [*org URI*]/api/data/v9.0/msdyn_approvals(*activityid*)<br />[Update](../webapi/update-delete-entities-using-web-api.md#basic-update) `statecode` and `statuscode` properties.|<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|
|Update|PATCH [*org URI*]/api/data/v9.0/msdyn_approvals(*activityid*)<br />See [Update](../webapi/update-delete-entities-using-web-api.md#basic-update)|<xref:Microsoft.Xrm.Sdk.Messages.UpdateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Update*>|

## Properties

**DisplayName**: Approval<br />
**DisplayCollectionName**: Approvals<br />
**SchemaName**: msdyn_approval<br />
**CollectionSchemaName**: msdyn_approvals<br />
**LogicalName**: msdyn_approval<br />
**LogicalCollectionName**: msdyn_approvals<br />
**EntitySetName**: msdyn_approvals<br />
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
- [msdyn_approvalstatus](#BKMK_msdyn_approvalstatus)
- [msdyn_Characteristic](#BKMK_msdyn_Characteristic)
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

**Description**: Unique identifier of the activity.<br />
**DisplayName**: Activity<br />
**LogicalName**: activityid<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: SystemRequired<br />
**IsValidForUpdate**: False<br />
**Type**: Uniqueidentifier<br />


### <a name="BKMK_ActualDurationMinutes"></a> ActualDurationMinutes

**Description**: Actual duration of the activity in minutes.<br />
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

**Description**: Actual end time of the activity.<br />
**DisplayName**: Actual End<br />
**LogicalName**: actualend<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: DateTime<br />
**DateTimeBehavior**: UserLocal<br />
**Format**: DateAndTime


### <a name="BKMK_ActualStart"></a> ActualStart

**Description**: Actual start time of the activity.<br />
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

**Description**: Description of the activity.<br />
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


### <a name="BKMK_IsBilled"></a> IsBilled

**Description**: Information regarding whether the activity was billed as part of resolving a case.<br />
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

**Description**: Information regarding whether the activity was created from a workflow rule.<br />
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


### <a name="BKMK_msdyn_approvalstatus"></a> msdyn_approvalstatus

**Description**: Shows the status of the approval.<br />
**DisplayName**: Approval Status<br />
**LogicalName**: msdyn_approvalstatus<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Picklist<br />
**Options**:

- **Value**: 192350000 **Label**: Saved
- **Value**: 192350001 **Label**: Pending Approval
- **Value**: 192350002 **Label**: Rejected
- **Value**: 192350003 **Label**: Approved
- **Value**: 192350004 **Label**: Recalled



### <a name="BKMK_msdyn_Characteristic"></a> msdyn_Characteristic

**Description**: Skill for approval<br />
**DisplayName**: Characteristic<br />
**LogicalName**: msdyn_characteristic<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: bookableresourcecharacteristic


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

**Description**: Priority of the activity.<br />
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

**Description**: Unique identifier of the object with which the activity is associated.<br />
**DisplayName**: Regarding<br />
**LogicalName**: regardingobjectid<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: account,bookableresourcebooking,bookableresourcebookingheader,bulkoperation,campaign,campaignactivity,contact,contract,entitlement,entitlementtemplate,incident,interactionforemail,invoice,knowledgearticle,knowledgebaserecord,lead,msdyn_agreement,msdyn_agreementbookingdate,msdyn_agreementbookingincident,msdyn_agreementbookingproduct,msdyn_agreementbookingservice,msdyn_agreementbookingservicetask,msdyn_agreementbookingsetup,msdyn_agreementinvoicedate,msdyn_agreementinvoiceproduct,msdyn_agreementinvoicesetup,msdyn_bookingalertstatus,msdyn_bookingrule,msdyn_bookingtimestamp,msdyn_customerasset,msdyn_fieldservicesetting,msdyn_incidenttypecharacteristic,msdyn_incidenttypeproduct,msdyn_incidenttypeservice,msdyn_inventoryadjustment,msdyn_inventoryadjustmentproduct,msdyn_inventoryjournal,msdyn_inventorytransfer,msdyn_payment,msdyn_paymentdetail,msdyn_paymentmethod,msdyn_paymentterm,msdyn_postalbum,msdyn_postalcode,msdyn_processnotes,msdyn_productinventory,msdyn_projectteam,msdyn_purchaseorder,msdyn_purchaseorderbill,msdyn_purchaseorderproduct,msdyn_purchaseorderreceipt,msdyn_purchaseorderreceiptproduct,msdyn_purchaseordersubstatus,msdyn_quotebookingincident,msdyn_quotebookingproduct,msdyn_quotebookingservice,msdyn_quotebookingservicetask,msdyn_resourceterritory,msdyn_rma,msdyn_rmaproduct,msdyn_rmareceipt,msdyn_rmareceiptproduct,msdyn_rmasubstatus,msdyn_rtv,msdyn_rtvproduct,msdyn_rtvsubstatus,msdyn_shipvia,msdyn_systemuserschedulersetting,msdyn_timegroup,msdyn_timegroupdetail,msdyn_timeoffrequest,msdyn_warehouse,msdyn_workorder,msdyn_workordercharacteristic,msdyn_workorderincident,msdyn_workorderproduct,msdyn_workorderresourcerestriction,msdyn_workorderservice,msdyn_workorderservicetask,opportunity,quote,salesorder,site


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
**MaxLength**: 400


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
**MaxLength**: 400


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

**Description**: Users or facility/equipment that are required for the activity.<br />
**DisplayName**: Resources<br />
**LogicalName**: resources<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: PartyList<br />
**Targets**: equipment,systemuser


### <a name="BKMK_ScheduledDurationMinutes"></a> ScheduledDurationMinutes

**Description**: Scheduled duration of the activity, specified in minutes.<br />
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

**Description**: Scheduled end time of the activity.<br />
**DisplayName**: Due Date<br />
**LogicalName**: scheduledend<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: DateTime<br />
**DateTimeBehavior**: UserLocal<br />
**Format**: DateAndTime


### <a name="BKMK_ScheduledStart"></a> ScheduledStart

**Description**: Scheduled start time of the activity.<br />
**DisplayName**: Start Date<br />
**LogicalName**: scheduledstart<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: DateTime<br />
**DateTimeBehavior**: UserLocal<br />
**Format**: DateAndTime


### <a name="BKMK_ServiceId"></a> ServiceId

**Description**: Unique identifier of an associated service.<br />
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

**Description**: Status of the activity.<br />
**DisplayName**: Activity Status<br />
**LogicalName**: statecode<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: SystemRequired<br />
**IsValidForCreate**: False<br />
**Type**: State<br />
**Options**:

- **Value**: 0 **Label**: Open **DefaultStatus**: 1 **InvariantName**: Open
- **Value**: 1 **Label**: Completed **DefaultStatus**: 2 **InvariantName**: Completed
- **Value**: 2 **Label**: Canceled **DefaultStatus**: 3 **InvariantName**: Canceled
- **Value**: 3 **Label**: Scheduled **DefaultStatus**: 4 **InvariantName**: Scheduled



### <a name="BKMK_StatusCode"></a> StatusCode

**Description**: Reason for the status of the activity.<br />
**DisplayName**: Status Reason<br />
**LogicalName**: statuscode<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Status<br />
**Options**:

- **Value**: 1 **Label**: Open **State**: 0
- **Value**: 2 **Label**: Completed **State**: 1
- **Value**: 3 **Label**: Canceled **State**: 2
- **Value**: 4 **Label**: Scheduled **State**: 3



### <a name="BKMK_Subject"></a> Subject

**Description**: Subject associated with the activity.<br />
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
**MinValue**: -1


### <a name="BKMK_To"></a> To

**Description**: Person who is the receiver of the activity.<br />
**DisplayName**: Approvers<br />
**LogicalName**: to<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: PartyList<br />
**Targets**: account,contact,lead,systemuser


### <a name="BKMK_TransactionCurrencyId"></a> TransactionCurrencyId

**Description**: Unique identifier of the currency associated with the activitypointer.<br />
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
- [msdyn_CharacteristicName](#BKMK_msdyn_CharacteristicName)
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
**Format**: DateAndTime


### <a name="BKMK_CreatedOnBehalfBy"></a> CreatedOnBehalfBy

**Description**: Shows the delegate user who created the activity.<br />
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

**Description**: Exchange rate for the currency associated with the activitypointer with respect to the base currency.<br />
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

**DefaultValue**: True


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
**Format**: DateAndTime


### <a name="BKMK_ModifiedOnBehalfBy"></a> ModifiedOnBehalfBy

**Description**: Shows the delegate user who last modified the activity.<br />
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


### <a name="BKMK_msdyn_CharacteristicName"></a> msdyn_CharacteristicName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: msdyn_characteristicname<br />
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
**RequiredLevel**: SystemRequired<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


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

- [msdyn_approval_activity_parties](#BKMK_msdyn_approval_activity_parties)
- [CampaignResponse_msdyn_approvals](#BKMK_CampaignResponse_msdyn_approvals)
- [msdyn_approval_ActionCards](#BKMK_msdyn_approval_ActionCards)
- [msdyn_approval_SyncErrors](#BKMK_msdyn_approval_SyncErrors)
- [msdyn_approval_DuplicateMatchingRecord](#BKMK_msdyn_approval_DuplicateMatchingRecord)
- [msdyn_approval_DuplicateBaseRecord](#BKMK_msdyn_approval_DuplicateBaseRecord)
- [msdyn_approval_AsyncOperations](#BKMK_msdyn_approval_AsyncOperations)
- [msdyn_approval_MailboxTrackingFolders](#BKMK_msdyn_approval_MailboxTrackingFolders)
- [msdyn_approval_UserEntityInstanceDatas](#BKMK_msdyn_approval_UserEntityInstanceDatas)
- [msdyn_approval_ProcessSession](#BKMK_msdyn_approval_ProcessSession)
- [msdyn_approval_BulkDeleteFailures](#BKMK_msdyn_approval_BulkDeleteFailures)
- [msdyn_approval_PrincipalObjectAttributeAccesses](#BKMK_msdyn_approval_PrincipalObjectAttributeAccesses)
- [msdyn_approval_connections1](#BKMK_msdyn_approval_connections1)
- [msdyn_approval_connections2](#BKMK_msdyn_approval_connections2)
- [msdyn_approval_QueueItems](#BKMK_msdyn_approval_QueueItems)
- [msdyn_approval_Annotations](#BKMK_msdyn_approval_Annotations)


### <a name="BKMK_msdyn_approval_activity_parties"></a> msdyn_approval_activity_parties

Same as activityparty entity [msdyn_approval_activity_parties](activityparty.md#BKMK_msdyn_approval_activity_parties) Many-To-One relationship.

**ReferencingEntity**: activityparty<br />
**ReferencingAttribute**: activityid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_approval_activity_parties<br />
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


### <a name="BKMK_CampaignResponse_msdyn_approvals"></a> CampaignResponse_msdyn_approvals

Same as campaignresponse entity [CampaignResponse_msdyn_approvals](campaignresponse.md#BKMK_CampaignResponse_msdyn_approvals) Many-To-One relationship.

**ReferencingEntity**: campaignresponse<br />
**ReferencingAttribute**: originatingactivityid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: CampaignResponse_msdyn_approvals<br />
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


### <a name="BKMK_msdyn_approval_ActionCards"></a> msdyn_approval_ActionCards

Same as actioncard entity [msdyn_approval_ActionCards](actioncard.md#BKMK_msdyn_approval_ActionCards) Many-To-One relationship.

**ReferencingEntity**: actioncard<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_approval_ActionCards<br />
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


### <a name="BKMK_msdyn_approval_SyncErrors"></a> msdyn_approval_SyncErrors

Same as syncerror entity [msdyn_approval_SyncErrors](syncerror.md#BKMK_msdyn_approval_SyncErrors) Many-To-One relationship.

**ReferencingEntity**: syncerror<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_approval_SyncErrors<br />
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


### <a name="BKMK_msdyn_approval_DuplicateMatchingRecord"></a> msdyn_approval_DuplicateMatchingRecord

Same as duplicaterecord entity [msdyn_approval_DuplicateMatchingRecord](duplicaterecord.md#BKMK_msdyn_approval_DuplicateMatchingRecord) Many-To-One relationship.

**ReferencingEntity**: duplicaterecord<br />
**ReferencingAttribute**: duplicaterecordid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_approval_DuplicateMatchingRecord<br />
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


### <a name="BKMK_msdyn_approval_DuplicateBaseRecord"></a> msdyn_approval_DuplicateBaseRecord

Same as duplicaterecord entity [msdyn_approval_DuplicateBaseRecord](duplicaterecord.md#BKMK_msdyn_approval_DuplicateBaseRecord) Many-To-One relationship.

**ReferencingEntity**: duplicaterecord<br />
**ReferencingAttribute**: baserecordid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_approval_DuplicateBaseRecord<br />
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


### <a name="BKMK_msdyn_approval_AsyncOperations"></a> msdyn_approval_AsyncOperations

Same as asyncoperation entity [msdyn_approval_AsyncOperations](asyncoperation.md#BKMK_msdyn_approval_AsyncOperations) Many-To-One relationship.

**ReferencingEntity**: asyncoperation<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_approval_AsyncOperations<br />
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


### <a name="BKMK_msdyn_approval_MailboxTrackingFolders"></a> msdyn_approval_MailboxTrackingFolders

Same as mailboxtrackingfolder entity [msdyn_approval_MailboxTrackingFolders](mailboxtrackingfolder.md#BKMK_msdyn_approval_MailboxTrackingFolders) Many-To-One relationship.

**ReferencingEntity**: mailboxtrackingfolder<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_approval_MailboxTrackingFolders<br />
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


### <a name="BKMK_msdyn_approval_UserEntityInstanceDatas"></a> msdyn_approval_UserEntityInstanceDatas

Same as userentityinstancedata entity [msdyn_approval_UserEntityInstanceDatas](userentityinstancedata.md#BKMK_msdyn_approval_UserEntityInstanceDatas) Many-To-One relationship.

**ReferencingEntity**: userentityinstancedata<br />
**ReferencingAttribute**: objectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_approval_UserEntityInstanceDatas<br />
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


### <a name="BKMK_msdyn_approval_ProcessSession"></a> msdyn_approval_ProcessSession

Same as processsession entity [msdyn_approval_ProcessSession](processsession.md#BKMK_msdyn_approval_ProcessSession) Many-To-One relationship.

**ReferencingEntity**: processsession<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_approval_ProcessSession<br />
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


### <a name="BKMK_msdyn_approval_BulkDeleteFailures"></a> msdyn_approval_BulkDeleteFailures

Same as bulkdeletefailure entity [msdyn_approval_BulkDeleteFailures](bulkdeletefailure.md#BKMK_msdyn_approval_BulkDeleteFailures) Many-To-One relationship.

**ReferencingEntity**: bulkdeletefailure<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_approval_BulkDeleteFailures<br />
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


### <a name="BKMK_msdyn_approval_PrincipalObjectAttributeAccesses"></a> msdyn_approval_PrincipalObjectAttributeAccesses

Same as principalobjectattributeaccess entity [msdyn_approval_PrincipalObjectAttributeAccesses](principalobjectattributeaccess.md#BKMK_msdyn_approval_PrincipalObjectAttributeAccesses) Many-To-One relationship.

**ReferencingEntity**: principalobjectattributeaccess<br />
**ReferencingAttribute**: objectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_approval_PrincipalObjectAttributeAccesses<br />
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


### <a name="BKMK_msdyn_approval_connections1"></a> msdyn_approval_connections1

Same as connection entity [msdyn_approval_connections1](connection.md#BKMK_msdyn_approval_connections1) Many-To-One relationship.

**ReferencingEntity**: connection<br />
**ReferencingAttribute**: record1id<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_approval_connections1<br />
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


### <a name="BKMK_msdyn_approval_connections2"></a> msdyn_approval_connections2

Same as connection entity [msdyn_approval_connections2](connection.md#BKMK_msdyn_approval_connections2) Many-To-One relationship.

**ReferencingEntity**: connection<br />
**ReferencingAttribute**: record2id<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_approval_connections2<br />
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


### <a name="BKMK_msdyn_approval_QueueItems"></a> msdyn_approval_QueueItems

Same as queueitem entity [msdyn_approval_QueueItems](queueitem.md#BKMK_msdyn_approval_QueueItems) Many-To-One relationship.

**ReferencingEntity**: queueitem<br />
**ReferencingAttribute**: objectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_approval_QueueItems<br />
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


### <a name="BKMK_msdyn_approval_Annotations"></a> msdyn_approval_Annotations

Same as annotation entity [msdyn_approval_Annotations](annotation.md#BKMK_msdyn_approval_Annotations) Many-To-One relationship.

**ReferencingEntity**: annotation<br />
**ReferencingAttribute**: objectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_approval_Annotations<br />
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

- [lead_msdyn_approvals](#BKMK_lead_msdyn_approvals)
- [bookableresourcebooking_msdyn_approvals](#BKMK_bookableresourcebooking_msdyn_approvals)
- [bookableresourcebookingheader_msdyn_approvals](#BKMK_bookableresourcebookingheader_msdyn_approvals)
- [bulkoperation_msdyn_approvals](#BKMK_bulkoperation_msdyn_approvals)
- [campaign_msdyn_approvals](#BKMK_campaign_msdyn_approvals)
- [campaignactivity_msdyn_approvals](#BKMK_campaignactivity_msdyn_approvals)
- [contract_msdyn_approvals](#BKMK_contract_msdyn_approvals)
- [entitlement_msdyn_approvals](#BKMK_entitlement_msdyn_approvals)
- [entitlementtemplate_msdyn_approvals](#BKMK_entitlementtemplate_msdyn_approvals)
- [incident_msdyn_approvals](#BKMK_incident_msdyn_approvals)
- [site_msdyn_approvals](#BKMK_site_msdyn_approvals)
- [msdyn_approval_service_serviceid](#BKMK_msdyn_approval_service_serviceid)
- [invoice_msdyn_approvals](#BKMK_invoice_msdyn_approvals)
- [opportunity_msdyn_approvals](#BKMK_opportunity_msdyn_approvals)
- [quote_msdyn_approvals](#BKMK_quote_msdyn_approvals)
- [salesorder_msdyn_approvals](#BKMK_salesorder_msdyn_approvals)
- [msdyn_postalbum_msdyn_approvals](#BKMK_msdyn_postalbum_msdyn_approvals)
- [msdyn_bookingalertstatus_msdyn_approvals](#BKMK_msdyn_bookingalertstatus_msdyn_approvals)
- [msdyn_bookingrule_msdyn_approvals](#BKMK_msdyn_bookingrule_msdyn_approvals)
- [msdyn_resourceterritory_msdyn_approvals](#BKMK_msdyn_resourceterritory_msdyn_approvals)
- [msdyn_systemuserschedulersetting_msdyn_approvals](#BKMK_msdyn_systemuserschedulersetting_msdyn_approvals)
- [msdyn_timegroup_msdyn_approvals](#BKMK_msdyn_timegroup_msdyn_approvals)
- [msdyn_timegroupdetail_msdyn_approvals](#BKMK_msdyn_timegroupdetail_msdyn_approvals)
- [interactionforemail_msdyn_approvals](#BKMK_interactionforemail_msdyn_approvals)
- [knowledgebaserecord_msdyn_approvals](#BKMK_knowledgebaserecord_msdyn_approvals)
- [account_msdyn_approvals](#BKMK_account_msdyn_approvals)
- [msdyn_approval_systemuser_createdby](#BKMK_msdyn_approval_systemuser_createdby)
- [contact_msdyn_approvals](#BKMK_contact_msdyn_approvals)
- [msdyn_approval_mailbox_sendermailboxid](#BKMK_msdyn_approval_mailbox_sendermailboxid)
- [msdyn_approval_transactioncurrency_transactioncurrencyid](#BKMK_msdyn_approval_transactioncurrency_transactioncurrencyid)
- [msdyn_approval_systemuser_owninguser](#BKMK_msdyn_approval_systemuser_owninguser)
- [msdyn_approval_sla_slaid](#BKMK_msdyn_approval_sla_slaid)
- [msdyn_approval_businessunit_owningbusinessunit](#BKMK_msdyn_approval_businessunit_owningbusinessunit)
- [knowledgearticle_msdyn_approvals](#BKMK_knowledgearticle_msdyn_approvals)
- [msdyn_approval_systemuser_modifiedonbehalfby](#BKMK_msdyn_approval_systemuser_modifiedonbehalfby)
- [msdyn_approval_systemuser_createdonbehalfby](#BKMK_msdyn_approval_systemuser_createdonbehalfby)
- [msdyn_approval_systemuser_modifiedby](#BKMK_msdyn_approval_systemuser_modifiedby)
- [msdyn_approval_team_owningteam](#BKMK_msdyn_approval_team_owningteam)
- [msdyn_approval_sla_slainvokedid](#BKMK_msdyn_approval_sla_slainvokedid)
- [activity_pointer_msdyn_approval](#BKMK_activity_pointer_msdyn_approval)
- [msdyn_processnotes_msdyn_approvals](#BKMK_msdyn_processnotes_msdyn_approvals)
- [msdyn_projectteam_msdyn_approvals](#BKMK_msdyn_projectteam_msdyn_approvals)
- [msdyn_bookableresourcecharacteristic_msdyn_approval_Characteristic](#BKMK_msdyn_bookableresourcecharacteristic_msdyn_approval_Characteristic)
- [msdyn_agreement_msdyn_approvals](#BKMK_msdyn_agreement_msdyn_approvals)
- [msdyn_agreementbookingdate_msdyn_approvals](#BKMK_msdyn_agreementbookingdate_msdyn_approvals)
- [msdyn_agreementbookingincident_msdyn_approvals](#BKMK_msdyn_agreementbookingincident_msdyn_approvals)
- [msdyn_agreementbookingproduct_msdyn_approvals](#BKMK_msdyn_agreementbookingproduct_msdyn_approvals)
- [msdyn_agreementbookingservice_msdyn_approvals](#BKMK_msdyn_agreementbookingservice_msdyn_approvals)
- [msdyn_agreementbookingservicetask_msdyn_approvals](#BKMK_msdyn_agreementbookingservicetask_msdyn_approvals)
- [msdyn_agreementbookingsetup_msdyn_approvals](#BKMK_msdyn_agreementbookingsetup_msdyn_approvals)
- [msdyn_agreementinvoicedate_msdyn_approvals](#BKMK_msdyn_agreementinvoicedate_msdyn_approvals)
- [msdyn_agreementinvoiceproduct_msdyn_approvals](#BKMK_msdyn_agreementinvoiceproduct_msdyn_approvals)
- [msdyn_agreementinvoicesetup_msdyn_approvals](#BKMK_msdyn_agreementinvoicesetup_msdyn_approvals)
- [msdyn_bookingtimestamp_msdyn_approvals](#BKMK_msdyn_bookingtimestamp_msdyn_approvals)
- [msdyn_customerasset_msdyn_approvals](#BKMK_msdyn_customerasset_msdyn_approvals)
- [msdyn_fieldservicesetting_msdyn_approvals](#BKMK_msdyn_fieldservicesetting_msdyn_approvals)
- [msdyn_incidenttypecharacteristic_msdyn_approvals](#BKMK_msdyn_incidenttypecharacteristic_msdyn_approvals)
- [msdyn_incidenttypeproduct_msdyn_approvals](#BKMK_msdyn_incidenttypeproduct_msdyn_approvals)
- [msdyn_incidenttypeservice_msdyn_approvals](#BKMK_msdyn_incidenttypeservice_msdyn_approvals)
- [msdyn_inventoryadjustment_msdyn_approvals](#BKMK_msdyn_inventoryadjustment_msdyn_approvals)
- [msdyn_inventoryadjustmentproduct_msdyn_approvals](#BKMK_msdyn_inventoryadjustmentproduct_msdyn_approvals)
- [msdyn_inventoryjournal_msdyn_approvals](#BKMK_msdyn_inventoryjournal_msdyn_approvals)
- [msdyn_inventorytransfer_msdyn_approvals](#BKMK_msdyn_inventorytransfer_msdyn_approvals)
- [msdyn_payment_msdyn_approvals](#BKMK_msdyn_payment_msdyn_approvals)
- [msdyn_paymentdetail_msdyn_approvals](#BKMK_msdyn_paymentdetail_msdyn_approvals)
- [msdyn_paymentmethod_msdyn_approvals](#BKMK_msdyn_paymentmethod_msdyn_approvals)
- [msdyn_paymentterm_msdyn_approvals](#BKMK_msdyn_paymentterm_msdyn_approvals)
- [msdyn_postalcode_msdyn_approvals](#BKMK_msdyn_postalcode_msdyn_approvals)
- [msdyn_productinventory_msdyn_approvals](#BKMK_msdyn_productinventory_msdyn_approvals)
- [msdyn_purchaseorder_msdyn_approvals](#BKMK_msdyn_purchaseorder_msdyn_approvals)
- [msdyn_purchaseorderbill_msdyn_approvals](#BKMK_msdyn_purchaseorderbill_msdyn_approvals)
- [msdyn_purchaseorderproduct_msdyn_approvals](#BKMK_msdyn_purchaseorderproduct_msdyn_approvals)
- [msdyn_purchaseorderreceipt_msdyn_approvals](#BKMK_msdyn_purchaseorderreceipt_msdyn_approvals)
- [msdyn_purchaseorderreceiptproduct_msdyn_approvals](#BKMK_msdyn_purchaseorderreceiptproduct_msdyn_approvals)
- [msdyn_purchaseordersubstatus_msdyn_approvals](#BKMK_msdyn_purchaseordersubstatus_msdyn_approvals)
- [msdyn_quotebookingincident_msdyn_approvals](#BKMK_msdyn_quotebookingincident_msdyn_approvals)
- [msdyn_quotebookingproduct_msdyn_approvals](#BKMK_msdyn_quotebookingproduct_msdyn_approvals)
- [msdyn_quotebookingservice_msdyn_approvals](#BKMK_msdyn_quotebookingservice_msdyn_approvals)
- [msdyn_quotebookingservicetask_msdyn_approvals](#BKMK_msdyn_quotebookingservicetask_msdyn_approvals)
- [msdyn_rma_msdyn_approvals](#BKMK_msdyn_rma_msdyn_approvals)
- [msdyn_rmaproduct_msdyn_approvals](#BKMK_msdyn_rmaproduct_msdyn_approvals)
- [msdyn_rmareceipt_msdyn_approvals](#BKMK_msdyn_rmareceipt_msdyn_approvals)
- [msdyn_rmareceiptproduct_msdyn_approvals](#BKMK_msdyn_rmareceiptproduct_msdyn_approvals)
- [msdyn_rmasubstatus_msdyn_approvals](#BKMK_msdyn_rmasubstatus_msdyn_approvals)
- [msdyn_rtv_msdyn_approvals](#BKMK_msdyn_rtv_msdyn_approvals)
- [msdyn_rtvproduct_msdyn_approvals](#BKMK_msdyn_rtvproduct_msdyn_approvals)
- [msdyn_rtvsubstatus_msdyn_approvals](#BKMK_msdyn_rtvsubstatus_msdyn_approvals)
- [msdyn_shipvia_msdyn_approvals](#BKMK_msdyn_shipvia_msdyn_approvals)
- [msdyn_timeoffrequest_msdyn_approvals](#BKMK_msdyn_timeoffrequest_msdyn_approvals)
- [msdyn_warehouse_msdyn_approvals](#BKMK_msdyn_warehouse_msdyn_approvals)
- [msdyn_workorder_msdyn_approvals](#BKMK_msdyn_workorder_msdyn_approvals)
- [msdyn_workordercharacteristic_msdyn_approvals](#BKMK_msdyn_workordercharacteristic_msdyn_approvals)
- [msdyn_workorderincident_msdyn_approvals](#BKMK_msdyn_workorderincident_msdyn_approvals)
- [msdyn_workorderproduct_msdyn_approvals](#BKMK_msdyn_workorderproduct_msdyn_approvals)
- [msdyn_workorderresourcerestriction_msdyn_approvals](#BKMK_msdyn_workorderresourcerestriction_msdyn_approvals)
- [msdyn_workorderservice_msdyn_approvals](#BKMK_msdyn_workorderservice_msdyn_approvals)
- [msdyn_workorderservicetask_msdyn_approvals](#BKMK_msdyn_workorderservicetask_msdyn_approvals)


### <a name="BKMK_lead_msdyn_approvals"></a> lead_msdyn_approvals

See lead Entity [lead_msdyn_approvals](lead.md#BKMK_lead_msdyn_approvals) One-To-Many relationship.

### <a name="BKMK_bookableresourcebooking_msdyn_approvals"></a> bookableresourcebooking_msdyn_approvals

See bookableresourcebooking Entity [bookableresourcebooking_msdyn_approvals](bookableresourcebooking.md#BKMK_bookableresourcebooking_msdyn_approvals) One-To-Many relationship.

### <a name="BKMK_bookableresourcebookingheader_msdyn_approvals"></a> bookableresourcebookingheader_msdyn_approvals

See bookableresourcebookingheader Entity [bookableresourcebookingheader_msdyn_approvals](bookableresourcebookingheader.md#BKMK_bookableresourcebookingheader_msdyn_approvals) One-To-Many relationship.

### <a name="BKMK_bulkoperation_msdyn_approvals"></a> bulkoperation_msdyn_approvals

See bulkoperation Entity [bulkoperation_msdyn_approvals](bulkoperation.md#BKMK_bulkoperation_msdyn_approvals) One-To-Many relationship.

### <a name="BKMK_campaign_msdyn_approvals"></a> campaign_msdyn_approvals

See campaign Entity [campaign_msdyn_approvals](campaign.md#BKMK_campaign_msdyn_approvals) One-To-Many relationship.

### <a name="BKMK_campaignactivity_msdyn_approvals"></a> campaignactivity_msdyn_approvals

See campaignactivity Entity [campaignactivity_msdyn_approvals](campaignactivity.md#BKMK_campaignactivity_msdyn_approvals) One-To-Many relationship.

### <a name="BKMK_contract_msdyn_approvals"></a> contract_msdyn_approvals

See contract Entity [contract_msdyn_approvals](contract.md#BKMK_contract_msdyn_approvals) One-To-Many relationship.

### <a name="BKMK_entitlement_msdyn_approvals"></a> entitlement_msdyn_approvals

See entitlement Entity [entitlement_msdyn_approvals](entitlement.md#BKMK_entitlement_msdyn_approvals) One-To-Many relationship.

### <a name="BKMK_entitlementtemplate_msdyn_approvals"></a> entitlementtemplate_msdyn_approvals

See entitlementtemplate Entity [entitlementtemplate_msdyn_approvals](entitlementtemplate.md#BKMK_entitlementtemplate_msdyn_approvals) One-To-Many relationship.

### <a name="BKMK_incident_msdyn_approvals"></a> incident_msdyn_approvals

See incident Entity [incident_msdyn_approvals](incident.md#BKMK_incident_msdyn_approvals) One-To-Many relationship.

### <a name="BKMK_site_msdyn_approvals"></a> site_msdyn_approvals

See site Entity [site_msdyn_approvals](site.md#BKMK_site_msdyn_approvals) One-To-Many relationship.

### <a name="BKMK_msdyn_approval_service_serviceid"></a> msdyn_approval_service_serviceid

See service Entity [msdyn_approval_service_serviceid](service.md#BKMK_msdyn_approval_service_serviceid) One-To-Many relationship.

### <a name="BKMK_invoice_msdyn_approvals"></a> invoice_msdyn_approvals

See invoice Entity [invoice_msdyn_approvals](invoice.md#BKMK_invoice_msdyn_approvals) One-To-Many relationship.

### <a name="BKMK_opportunity_msdyn_approvals"></a> opportunity_msdyn_approvals

See opportunity Entity [opportunity_msdyn_approvals](opportunity.md#BKMK_opportunity_msdyn_approvals) One-To-Many relationship.

### <a name="BKMK_quote_msdyn_approvals"></a> quote_msdyn_approvals

See quote Entity [quote_msdyn_approvals](quote.md#BKMK_quote_msdyn_approvals) One-To-Many relationship.

### <a name="BKMK_salesorder_msdyn_approvals"></a> salesorder_msdyn_approvals

See salesorder Entity [salesorder_msdyn_approvals](salesorder.md#BKMK_salesorder_msdyn_approvals) One-To-Many relationship.

### <a name="BKMK_msdyn_postalbum_msdyn_approvals"></a> msdyn_postalbum_msdyn_approvals

See msdyn_postalbum Entity [msdyn_postalbum_msdyn_approvals](msdyn_postalbum.md#BKMK_msdyn_postalbum_msdyn_approvals) One-To-Many relationship.

### <a name="BKMK_msdyn_bookingalertstatus_msdyn_approvals"></a> msdyn_bookingalertstatus_msdyn_approvals

See msdyn_bookingalertstatus Entity [msdyn_bookingalertstatus_msdyn_approvals](msdyn_bookingalertstatus.md#BKMK_msdyn_bookingalertstatus_msdyn_approvals) One-To-Many relationship.

### <a name="BKMK_msdyn_bookingrule_msdyn_approvals"></a> msdyn_bookingrule_msdyn_approvals

See msdyn_bookingrule Entity [msdyn_bookingrule_msdyn_approvals](msdyn_bookingrule.md#BKMK_msdyn_bookingrule_msdyn_approvals) One-To-Many relationship.

### <a name="BKMK_msdyn_resourceterritory_msdyn_approvals"></a> msdyn_resourceterritory_msdyn_approvals

See msdyn_resourceterritory Entity [msdyn_resourceterritory_msdyn_approvals](msdyn_resourceterritory.md#BKMK_msdyn_resourceterritory_msdyn_approvals) One-To-Many relationship.

### <a name="BKMK_msdyn_systemuserschedulersetting_msdyn_approvals"></a> msdyn_systemuserschedulersetting_msdyn_approvals

See msdyn_systemuserschedulersetting Entity [msdyn_systemuserschedulersetting_msdyn_approvals](msdyn_systemuserschedulersetting.md#BKMK_msdyn_systemuserschedulersetting_msdyn_approvals) One-To-Many relationship.

### <a name="BKMK_msdyn_timegroup_msdyn_approvals"></a> msdyn_timegroup_msdyn_approvals

See msdyn_timegroup Entity [msdyn_timegroup_msdyn_approvals](msdyn_timegroup.md#BKMK_msdyn_timegroup_msdyn_approvals) One-To-Many relationship.

### <a name="BKMK_msdyn_timegroupdetail_msdyn_approvals"></a> msdyn_timegroupdetail_msdyn_approvals

See msdyn_timegroupdetail Entity [msdyn_timegroupdetail_msdyn_approvals](msdyn_timegroupdetail.md#BKMK_msdyn_timegroupdetail_msdyn_approvals) One-To-Many relationship.

### <a name="BKMK_interactionforemail_msdyn_approvals"></a> interactionforemail_msdyn_approvals

See interactionforemail Entity [interactionforemail_msdyn_approvals](interactionforemail.md#BKMK_interactionforemail_msdyn_approvals) One-To-Many relationship.

### <a name="BKMK_knowledgebaserecord_msdyn_approvals"></a> knowledgebaserecord_msdyn_approvals

See knowledgebaserecord Entity [knowledgebaserecord_msdyn_approvals](knowledgebaserecord.md#BKMK_knowledgebaserecord_msdyn_approvals) One-To-Many relationship.

### <a name="BKMK_account_msdyn_approvals"></a> account_msdyn_approvals

See account Entity [account_msdyn_approvals](account.md#BKMK_account_msdyn_approvals) One-To-Many relationship.

### <a name="BKMK_msdyn_approval_systemuser_createdby"></a> msdyn_approval_systemuser_createdby

See systemuser Entity [msdyn_approval_systemuser_createdby](systemuser.md#BKMK_msdyn_approval_systemuser_createdby) One-To-Many relationship.

### <a name="BKMK_contact_msdyn_approvals"></a> contact_msdyn_approvals

See contact Entity [contact_msdyn_approvals](contact.md#BKMK_contact_msdyn_approvals) One-To-Many relationship.

### <a name="BKMK_msdyn_approval_mailbox_sendermailboxid"></a> msdyn_approval_mailbox_sendermailboxid

See mailbox Entity [msdyn_approval_mailbox_sendermailboxid](mailbox.md#BKMK_msdyn_approval_mailbox_sendermailboxid) One-To-Many relationship.

### <a name="BKMK_msdyn_approval_transactioncurrency_transactioncurrencyid"></a> msdyn_approval_transactioncurrency_transactioncurrencyid

See transactioncurrency Entity [msdyn_approval_transactioncurrency_transactioncurrencyid](transactioncurrency.md#BKMK_msdyn_approval_transactioncurrency_transactioncurrencyid) One-To-Many relationship.

### <a name="BKMK_msdyn_approval_systemuser_owninguser"></a> msdyn_approval_systemuser_owninguser

See systemuser Entity [msdyn_approval_systemuser_owninguser](systemuser.md#BKMK_msdyn_approval_systemuser_owninguser) One-To-Many relationship.

### <a name="BKMK_msdyn_approval_sla_slaid"></a> msdyn_approval_sla_slaid

See sla Entity [msdyn_approval_sla_slaid](sla.md#BKMK_msdyn_approval_sla_slaid) One-To-Many relationship.

### <a name="BKMK_msdyn_approval_businessunit_owningbusinessunit"></a> msdyn_approval_businessunit_owningbusinessunit

See businessunit Entity [msdyn_approval_businessunit_owningbusinessunit](businessunit.md#BKMK_msdyn_approval_businessunit_owningbusinessunit) One-To-Many relationship.

### <a name="BKMK_knowledgearticle_msdyn_approvals"></a> knowledgearticle_msdyn_approvals

See knowledgearticle Entity [knowledgearticle_msdyn_approvals](knowledgearticle.md#BKMK_knowledgearticle_msdyn_approvals) One-To-Many relationship.

### <a name="BKMK_msdyn_approval_systemuser_modifiedonbehalfby"></a> msdyn_approval_systemuser_modifiedonbehalfby

See systemuser Entity [msdyn_approval_systemuser_modifiedonbehalfby](systemuser.md#BKMK_msdyn_approval_systemuser_modifiedonbehalfby) One-To-Many relationship.

### <a name="BKMK_msdyn_approval_systemuser_createdonbehalfby"></a> msdyn_approval_systemuser_createdonbehalfby

See systemuser Entity [msdyn_approval_systemuser_createdonbehalfby](systemuser.md#BKMK_msdyn_approval_systemuser_createdonbehalfby) One-To-Many relationship.

### <a name="BKMK_msdyn_approval_systemuser_modifiedby"></a> msdyn_approval_systemuser_modifiedby

See systemuser Entity [msdyn_approval_systemuser_modifiedby](systemuser.md#BKMK_msdyn_approval_systemuser_modifiedby) One-To-Many relationship.

### <a name="BKMK_msdyn_approval_team_owningteam"></a> msdyn_approval_team_owningteam

See team Entity [msdyn_approval_team_owningteam](team.md#BKMK_msdyn_approval_team_owningteam) One-To-Many relationship.

### <a name="BKMK_msdyn_approval_sla_slainvokedid"></a> msdyn_approval_sla_slainvokedid

See sla Entity [msdyn_approval_sla_slainvokedid](sla.md#BKMK_msdyn_approval_sla_slainvokedid) One-To-Many relationship.

### <a name="BKMK_activity_pointer_msdyn_approval"></a> activity_pointer_msdyn_approval

See activitypointer Entity [activity_pointer_msdyn_approval](activitypointer.md#BKMK_activity_pointer_msdyn_approval) One-To-Many relationship.

### <a name="BKMK_msdyn_processnotes_msdyn_approvals"></a> msdyn_processnotes_msdyn_approvals

See msdyn_processnotes Entity [msdyn_processnotes_msdyn_approvals](msdyn_processnotes.md#BKMK_msdyn_processnotes_msdyn_approvals) One-To-Many relationship.

### <a name="BKMK_msdyn_projectteam_msdyn_approvals"></a> msdyn_projectteam_msdyn_approvals

See msdyn_projectteam Entity [msdyn_projectteam_msdyn_approvals](msdyn_projectteam.md#BKMK_msdyn_projectteam_msdyn_approvals) One-To-Many relationship.

### <a name="BKMK_msdyn_bookableresourcecharacteristic_msdyn_approval_Characteristic"></a> msdyn_bookableresourcecharacteristic_msdyn_approval_Characteristic

See bookableresourcecharacteristic Entity [msdyn_bookableresourcecharacteristic_msdyn_approval_Characteristic](bookableresourcecharacteristic.md#BKMK_msdyn_bookableresourcecharacteristic_msdyn_approval_Characteristic) One-To-Many relationship.

### <a name="BKMK_msdyn_agreement_msdyn_approvals"></a> msdyn_agreement_msdyn_approvals

See msdyn_agreement Entity [msdyn_agreement_msdyn_approvals](msdyn_agreement.md#BKMK_msdyn_agreement_msdyn_approvals) One-To-Many relationship.

### <a name="BKMK_msdyn_agreementbookingdate_msdyn_approvals"></a> msdyn_agreementbookingdate_msdyn_approvals

See msdyn_agreementbookingdate Entity [msdyn_agreementbookingdate_msdyn_approvals](msdyn_agreementbookingdate.md#BKMK_msdyn_agreementbookingdate_msdyn_approvals) One-To-Many relationship.

### <a name="BKMK_msdyn_agreementbookingincident_msdyn_approvals"></a> msdyn_agreementbookingincident_msdyn_approvals

See msdyn_agreementbookingincident Entity [msdyn_agreementbookingincident_msdyn_approvals](msdyn_agreementbookingincident.md#BKMK_msdyn_agreementbookingincident_msdyn_approvals) One-To-Many relationship.

### <a name="BKMK_msdyn_agreementbookingproduct_msdyn_approvals"></a> msdyn_agreementbookingproduct_msdyn_approvals

See msdyn_agreementbookingproduct Entity [msdyn_agreementbookingproduct_msdyn_approvals](msdyn_agreementbookingproduct.md#BKMK_msdyn_agreementbookingproduct_msdyn_approvals) One-To-Many relationship.

### <a name="BKMK_msdyn_agreementbookingservice_msdyn_approvals"></a> msdyn_agreementbookingservice_msdyn_approvals

See msdyn_agreementbookingservice Entity [msdyn_agreementbookingservice_msdyn_approvals](msdyn_agreementbookingservice.md#BKMK_msdyn_agreementbookingservice_msdyn_approvals) One-To-Many relationship.

### <a name="BKMK_msdyn_agreementbookingservicetask_msdyn_approvals"></a> msdyn_agreementbookingservicetask_msdyn_approvals

See msdyn_agreementbookingservicetask Entity [msdyn_agreementbookingservicetask_msdyn_approvals](msdyn_agreementbookingservicetask.md#BKMK_msdyn_agreementbookingservicetask_msdyn_approvals) One-To-Many relationship.

### <a name="BKMK_msdyn_agreementbookingsetup_msdyn_approvals"></a> msdyn_agreementbookingsetup_msdyn_approvals

See msdyn_agreementbookingsetup Entity [msdyn_agreementbookingsetup_msdyn_approvals](msdyn_agreementbookingsetup.md#BKMK_msdyn_agreementbookingsetup_msdyn_approvals) One-To-Many relationship.

### <a name="BKMK_msdyn_agreementinvoicedate_msdyn_approvals"></a> msdyn_agreementinvoicedate_msdyn_approvals

See msdyn_agreementinvoicedate Entity [msdyn_agreementinvoicedate_msdyn_approvals](msdyn_agreementinvoicedate.md#BKMK_msdyn_agreementinvoicedate_msdyn_approvals) One-To-Many relationship.

### <a name="BKMK_msdyn_agreementinvoiceproduct_msdyn_approvals"></a> msdyn_agreementinvoiceproduct_msdyn_approvals

See msdyn_agreementinvoiceproduct Entity [msdyn_agreementinvoiceproduct_msdyn_approvals](msdyn_agreementinvoiceproduct.md#BKMK_msdyn_agreementinvoiceproduct_msdyn_approvals) One-To-Many relationship.

### <a name="BKMK_msdyn_agreementinvoicesetup_msdyn_approvals"></a> msdyn_agreementinvoicesetup_msdyn_approvals

See msdyn_agreementinvoicesetup Entity [msdyn_agreementinvoicesetup_msdyn_approvals](msdyn_agreementinvoicesetup.md#BKMK_msdyn_agreementinvoicesetup_msdyn_approvals) One-To-Many relationship.

### <a name="BKMK_msdyn_bookingtimestamp_msdyn_approvals"></a> msdyn_bookingtimestamp_msdyn_approvals

See msdyn_bookingtimestamp Entity [msdyn_bookingtimestamp_msdyn_approvals](msdyn_bookingtimestamp.md#BKMK_msdyn_bookingtimestamp_msdyn_approvals) One-To-Many relationship.

### <a name="BKMK_msdyn_customerasset_msdyn_approvals"></a> msdyn_customerasset_msdyn_approvals

See msdyn_customerasset Entity [msdyn_customerasset_msdyn_approvals](msdyn_customerasset.md#BKMK_msdyn_customerasset_msdyn_approvals) One-To-Many relationship.

### <a name="BKMK_msdyn_fieldservicesetting_msdyn_approvals"></a> msdyn_fieldservicesetting_msdyn_approvals

See msdyn_fieldservicesetting Entity [msdyn_fieldservicesetting_msdyn_approvals](msdyn_fieldservicesetting.md#BKMK_msdyn_fieldservicesetting_msdyn_approvals) One-To-Many relationship.

### <a name="BKMK_msdyn_incidenttypecharacteristic_msdyn_approvals"></a> msdyn_incidenttypecharacteristic_msdyn_approvals

See msdyn_incidenttypecharacteristic Entity [msdyn_incidenttypecharacteristic_msdyn_approvals](msdyn_incidenttypecharacteristic.md#BKMK_msdyn_incidenttypecharacteristic_msdyn_approvals) One-To-Many relationship.

### <a name="BKMK_msdyn_incidenttypeproduct_msdyn_approvals"></a> msdyn_incidenttypeproduct_msdyn_approvals

See msdyn_incidenttypeproduct Entity [msdyn_incidenttypeproduct_msdyn_approvals](msdyn_incidenttypeproduct.md#BKMK_msdyn_incidenttypeproduct_msdyn_approvals) One-To-Many relationship.

### <a name="BKMK_msdyn_incidenttypeservice_msdyn_approvals"></a> msdyn_incidenttypeservice_msdyn_approvals

See msdyn_incidenttypeservice Entity [msdyn_incidenttypeservice_msdyn_approvals](msdyn_incidenttypeservice.md#BKMK_msdyn_incidenttypeservice_msdyn_approvals) One-To-Many relationship.

### <a name="BKMK_msdyn_inventoryadjustment_msdyn_approvals"></a> msdyn_inventoryadjustment_msdyn_approvals

See msdyn_inventoryadjustment Entity [msdyn_inventoryadjustment_msdyn_approvals](msdyn_inventoryadjustment.md#BKMK_msdyn_inventoryadjustment_msdyn_approvals) One-To-Many relationship.

### <a name="BKMK_msdyn_inventoryadjustmentproduct_msdyn_approvals"></a> msdyn_inventoryadjustmentproduct_msdyn_approvals

See msdyn_inventoryadjustmentproduct Entity [msdyn_inventoryadjustmentproduct_msdyn_approvals](msdyn_inventoryadjustmentproduct.md#BKMK_msdyn_inventoryadjustmentproduct_msdyn_approvals) One-To-Many relationship.

### <a name="BKMK_msdyn_inventoryjournal_msdyn_approvals"></a> msdyn_inventoryjournal_msdyn_approvals

See msdyn_inventoryjournal Entity [msdyn_inventoryjournal_msdyn_approvals](msdyn_inventoryjournal.md#BKMK_msdyn_inventoryjournal_msdyn_approvals) One-To-Many relationship.

### <a name="BKMK_msdyn_inventorytransfer_msdyn_approvals"></a> msdyn_inventorytransfer_msdyn_approvals

See msdyn_inventorytransfer Entity [msdyn_inventorytransfer_msdyn_approvals](msdyn_inventorytransfer.md#BKMK_msdyn_inventorytransfer_msdyn_approvals) One-To-Many relationship.

### <a name="BKMK_msdyn_payment_msdyn_approvals"></a> msdyn_payment_msdyn_approvals

See msdyn_payment Entity [msdyn_payment_msdyn_approvals](msdyn_payment.md#BKMK_msdyn_payment_msdyn_approvals) One-To-Many relationship.

### <a name="BKMK_msdyn_paymentdetail_msdyn_approvals"></a> msdyn_paymentdetail_msdyn_approvals

See msdyn_paymentdetail Entity [msdyn_paymentdetail_msdyn_approvals](msdyn_paymentdetail.md#BKMK_msdyn_paymentdetail_msdyn_approvals) One-To-Many relationship.

### <a name="BKMK_msdyn_paymentmethod_msdyn_approvals"></a> msdyn_paymentmethod_msdyn_approvals

See msdyn_paymentmethod Entity [msdyn_paymentmethod_msdyn_approvals](msdyn_paymentmethod.md#BKMK_msdyn_paymentmethod_msdyn_approvals) One-To-Many relationship.

### <a name="BKMK_msdyn_paymentterm_msdyn_approvals"></a> msdyn_paymentterm_msdyn_approvals

See msdyn_paymentterm Entity [msdyn_paymentterm_msdyn_approvals](msdyn_paymentterm.md#BKMK_msdyn_paymentterm_msdyn_approvals) One-To-Many relationship.

### <a name="BKMK_msdyn_postalcode_msdyn_approvals"></a> msdyn_postalcode_msdyn_approvals

See msdyn_postalcode Entity [msdyn_postalcode_msdyn_approvals](msdyn_postalcode.md#BKMK_msdyn_postalcode_msdyn_approvals) One-To-Many relationship.

### <a name="BKMK_msdyn_productinventory_msdyn_approvals"></a> msdyn_productinventory_msdyn_approvals

See msdyn_productinventory Entity [msdyn_productinventory_msdyn_approvals](msdyn_productinventory.md#BKMK_msdyn_productinventory_msdyn_approvals) One-To-Many relationship.

### <a name="BKMK_msdyn_purchaseorder_msdyn_approvals"></a> msdyn_purchaseorder_msdyn_approvals

See msdyn_purchaseorder Entity [msdyn_purchaseorder_msdyn_approvals](msdyn_purchaseorder.md#BKMK_msdyn_purchaseorder_msdyn_approvals) One-To-Many relationship.

### <a name="BKMK_msdyn_purchaseorderbill_msdyn_approvals"></a> msdyn_purchaseorderbill_msdyn_approvals

See msdyn_purchaseorderbill Entity [msdyn_purchaseorderbill_msdyn_approvals](msdyn_purchaseorderbill.md#BKMK_msdyn_purchaseorderbill_msdyn_approvals) One-To-Many relationship.

### <a name="BKMK_msdyn_purchaseorderproduct_msdyn_approvals"></a> msdyn_purchaseorderproduct_msdyn_approvals

See msdyn_purchaseorderproduct Entity [msdyn_purchaseorderproduct_msdyn_approvals](msdyn_purchaseorderproduct.md#BKMK_msdyn_purchaseorderproduct_msdyn_approvals) One-To-Many relationship.

### <a name="BKMK_msdyn_purchaseorderreceipt_msdyn_approvals"></a> msdyn_purchaseorderreceipt_msdyn_approvals

See msdyn_purchaseorderreceipt Entity [msdyn_purchaseorderreceipt_msdyn_approvals](msdyn_purchaseorderreceipt.md#BKMK_msdyn_purchaseorderreceipt_msdyn_approvals) One-To-Many relationship.

### <a name="BKMK_msdyn_purchaseorderreceiptproduct_msdyn_approvals"></a> msdyn_purchaseorderreceiptproduct_msdyn_approvals

See msdyn_purchaseorderreceiptproduct Entity [msdyn_purchaseorderreceiptproduct_msdyn_approvals](msdyn_purchaseorderreceiptproduct.md#BKMK_msdyn_purchaseorderreceiptproduct_msdyn_approvals) One-To-Many relationship.

### <a name="BKMK_msdyn_purchaseordersubstatus_msdyn_approvals"></a> msdyn_purchaseordersubstatus_msdyn_approvals

See msdyn_purchaseordersubstatus Entity [msdyn_purchaseordersubstatus_msdyn_approvals](msdyn_purchaseordersubstatus.md#BKMK_msdyn_purchaseordersubstatus_msdyn_approvals) One-To-Many relationship.

### <a name="BKMK_msdyn_quotebookingincident_msdyn_approvals"></a> msdyn_quotebookingincident_msdyn_approvals

See msdyn_quotebookingincident Entity [msdyn_quotebookingincident_msdyn_approvals](msdyn_quotebookingincident.md#BKMK_msdyn_quotebookingincident_msdyn_approvals) One-To-Many relationship.

### <a name="BKMK_msdyn_quotebookingproduct_msdyn_approvals"></a> msdyn_quotebookingproduct_msdyn_approvals

See msdyn_quotebookingproduct Entity [msdyn_quotebookingproduct_msdyn_approvals](msdyn_quotebookingproduct.md#BKMK_msdyn_quotebookingproduct_msdyn_approvals) One-To-Many relationship.

### <a name="BKMK_msdyn_quotebookingservice_msdyn_approvals"></a> msdyn_quotebookingservice_msdyn_approvals

See msdyn_quotebookingservice Entity [msdyn_quotebookingservice_msdyn_approvals](msdyn_quotebookingservice.md#BKMK_msdyn_quotebookingservice_msdyn_approvals) One-To-Many relationship.

### <a name="BKMK_msdyn_quotebookingservicetask_msdyn_approvals"></a> msdyn_quotebookingservicetask_msdyn_approvals

See msdyn_quotebookingservicetask Entity [msdyn_quotebookingservicetask_msdyn_approvals](msdyn_quotebookingservicetask.md#BKMK_msdyn_quotebookingservicetask_msdyn_approvals) One-To-Many relationship.

### <a name="BKMK_msdyn_rma_msdyn_approvals"></a> msdyn_rma_msdyn_approvals

See msdyn_rma Entity [msdyn_rma_msdyn_approvals](msdyn_rma.md#BKMK_msdyn_rma_msdyn_approvals) One-To-Many relationship.

### <a name="BKMK_msdyn_rmaproduct_msdyn_approvals"></a> msdyn_rmaproduct_msdyn_approvals

See msdyn_rmaproduct Entity [msdyn_rmaproduct_msdyn_approvals](msdyn_rmaproduct.md#BKMK_msdyn_rmaproduct_msdyn_approvals) One-To-Many relationship.

### <a name="BKMK_msdyn_rmareceipt_msdyn_approvals"></a> msdyn_rmareceipt_msdyn_approvals

See msdyn_rmareceipt Entity [msdyn_rmareceipt_msdyn_approvals](msdyn_rmareceipt.md#BKMK_msdyn_rmareceipt_msdyn_approvals) One-To-Many relationship.

### <a name="BKMK_msdyn_rmareceiptproduct_msdyn_approvals"></a> msdyn_rmareceiptproduct_msdyn_approvals

See msdyn_rmareceiptproduct Entity [msdyn_rmareceiptproduct_msdyn_approvals](msdyn_rmareceiptproduct.md#BKMK_msdyn_rmareceiptproduct_msdyn_approvals) One-To-Many relationship.

### <a name="BKMK_msdyn_rmasubstatus_msdyn_approvals"></a> msdyn_rmasubstatus_msdyn_approvals

See msdyn_rmasubstatus Entity [msdyn_rmasubstatus_msdyn_approvals](msdyn_rmasubstatus.md#BKMK_msdyn_rmasubstatus_msdyn_approvals) One-To-Many relationship.

### <a name="BKMK_msdyn_rtv_msdyn_approvals"></a> msdyn_rtv_msdyn_approvals

See msdyn_rtv Entity [msdyn_rtv_msdyn_approvals](msdyn_rtv.md#BKMK_msdyn_rtv_msdyn_approvals) One-To-Many relationship.

### <a name="BKMK_msdyn_rtvproduct_msdyn_approvals"></a> msdyn_rtvproduct_msdyn_approvals

See msdyn_rtvproduct Entity [msdyn_rtvproduct_msdyn_approvals](msdyn_rtvproduct.md#BKMK_msdyn_rtvproduct_msdyn_approvals) One-To-Many relationship.

### <a name="BKMK_msdyn_rtvsubstatus_msdyn_approvals"></a> msdyn_rtvsubstatus_msdyn_approvals

See msdyn_rtvsubstatus Entity [msdyn_rtvsubstatus_msdyn_approvals](msdyn_rtvsubstatus.md#BKMK_msdyn_rtvsubstatus_msdyn_approvals) One-To-Many relationship.

### <a name="BKMK_msdyn_shipvia_msdyn_approvals"></a> msdyn_shipvia_msdyn_approvals

See msdyn_shipvia Entity [msdyn_shipvia_msdyn_approvals](msdyn_shipvia.md#BKMK_msdyn_shipvia_msdyn_approvals) One-To-Many relationship.

### <a name="BKMK_msdyn_timeoffrequest_msdyn_approvals"></a> msdyn_timeoffrequest_msdyn_approvals

See msdyn_timeoffrequest Entity [msdyn_timeoffrequest_msdyn_approvals](msdyn_timeoffrequest.md#BKMK_msdyn_timeoffrequest_msdyn_approvals) One-To-Many relationship.

### <a name="BKMK_msdyn_warehouse_msdyn_approvals"></a> msdyn_warehouse_msdyn_approvals

See msdyn_warehouse Entity [msdyn_warehouse_msdyn_approvals](msdyn_warehouse.md#BKMK_msdyn_warehouse_msdyn_approvals) One-To-Many relationship.

### <a name="BKMK_msdyn_workorder_msdyn_approvals"></a> msdyn_workorder_msdyn_approvals

See msdyn_workorder Entity [msdyn_workorder_msdyn_approvals](msdyn_workorder.md#BKMK_msdyn_workorder_msdyn_approvals) One-To-Many relationship.

### <a name="BKMK_msdyn_workordercharacteristic_msdyn_approvals"></a> msdyn_workordercharacteristic_msdyn_approvals

See msdyn_workordercharacteristic Entity [msdyn_workordercharacteristic_msdyn_approvals](msdyn_workordercharacteristic.md#BKMK_msdyn_workordercharacteristic_msdyn_approvals) One-To-Many relationship.

### <a name="BKMK_msdyn_workorderincident_msdyn_approvals"></a> msdyn_workorderincident_msdyn_approvals

See msdyn_workorderincident Entity [msdyn_workorderincident_msdyn_approvals](msdyn_workorderincident.md#BKMK_msdyn_workorderincident_msdyn_approvals) One-To-Many relationship.

### <a name="BKMK_msdyn_workorderproduct_msdyn_approvals"></a> msdyn_workorderproduct_msdyn_approvals

See msdyn_workorderproduct Entity [msdyn_workorderproduct_msdyn_approvals](msdyn_workorderproduct.md#BKMK_msdyn_workorderproduct_msdyn_approvals) One-To-Many relationship.

### <a name="BKMK_msdyn_workorderresourcerestriction_msdyn_approvals"></a> msdyn_workorderresourcerestriction_msdyn_approvals

See msdyn_workorderresourcerestriction Entity [msdyn_workorderresourcerestriction_msdyn_approvals](msdyn_workorderresourcerestriction.md#BKMK_msdyn_workorderresourcerestriction_msdyn_approvals) One-To-Many relationship.

### <a name="BKMK_msdyn_workorderservice_msdyn_approvals"></a> msdyn_workorderservice_msdyn_approvals

See msdyn_workorderservice Entity [msdyn_workorderservice_msdyn_approvals](msdyn_workorderservice.md#BKMK_msdyn_workorderservice_msdyn_approvals) One-To-Many relationship.

### <a name="BKMK_msdyn_workorderservicetask_msdyn_approvals"></a> msdyn_workorderservicetask_msdyn_approvals

See msdyn_workorderservicetask Entity [msdyn_workorderservicetask_msdyn_approvals](msdyn_workorderservicetask.md#BKMK_msdyn_workorderservicetask_msdyn_approvals) One-To-Many relationship.

## See also

[About the Entity Reference](../about-entity-reference.md)<br />
[Programming reference for Dynamics 365 Customer Engagement](../programming-reference.md)<br />
[Web API Reference](/dynamics365/customer-engagement/web-api/about)<br />
<xref href="Microsoft.Dynamics.CRM.msdyn_approval?text=msdyn_approval EntityType" />