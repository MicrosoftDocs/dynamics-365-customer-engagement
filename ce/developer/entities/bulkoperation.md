---
title: "BulkOperation Entity Reference (Developer Guide for Dynamics 365 Customer Engagement)| MicrosoftDocs"
description: "Includes schema information and supported messages for the BulkOperation entity."
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
# BulkOperation Entity Reference

System operation used to perform lengthy and asynchronous operations on large data sets, such as distributing a campaign activity or quick campaign.

**Added by**: Marketing Solution<br />

## Messages

|Message|Web API Operation|SDK Assembly|
|-|-|-|
|Create|POST [*org URI*]/api/data/v9.0/bulkoperations<br />See [Create](../webapi/create-entity-web-api.md)|<xref:Microsoft.Xrm.Sdk.Messages.CreateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Create*>|
|Delete|DELETE [*org URI*]/api/data/v9.0/bulkoperations(*activityid*)<br />See [Delete](../webapi/update-delete-entities-using-web-api.md#basic-delete)|<xref:Microsoft.Xrm.Sdk.Messages.DeleteRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Delete*>|
|Retrieve|GET [*org URI*]/api/data/v9.0/bulkoperations(*activityid*)<br />See [Retrieve](../webapi/retrieve-entity-using-web-api.md)|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Retrieve*>|
|RetrieveMembersBulkOperation|<xref href="Microsoft.Dynamics.CRM.RetrieveMembersBulkOperation?text=RetrieveMembersBulkOperation Function" />|<xref:Microsoft.Crm.Sdk.Messages.RetrieveMembersBulkOperationRequest>|
|RetrieveMultiple|GET [*org URI*]/api/data/v9.0/bulkoperations<br />See [Query Data](../webapi/query-data-web-api.md)|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveMultipleRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.RetrieveMultiple*>|
|RetrievePrincipalAccess|<xref href="Microsoft.Dynamics.CRM.RetrievePrincipalAccess?text=RetrievePrincipalAccess Function" />|<xref:Microsoft.Crm.Sdk.Messages.RetrievePrincipalAccessRequest>|
|SetState|PATCH [*org URI*]/api/data/v9.0/bulkoperations(*activityid*)<br />[Update](../webapi/update-delete-entities-using-web-api.md#basic-update) `statecode` and `statuscode` properties.|<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|
|Update|PATCH [*org URI*]/api/data/v9.0/bulkoperations(*activityid*)<br />See [Update](../webapi/update-delete-entities-using-web-api.md#basic-update)|<xref:Microsoft.Xrm.Sdk.Messages.UpdateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Update*>|

## Properties

**DisplayName**: Quick Campaign<br />
**DisplayCollectionName**: Quick Campaigns<br />
**SchemaName**: BulkOperation<br />
**CollectionSchemaName**: BulkOperations<br />
**LogicalName**: bulkoperation<br />
**LogicalCollectionName**: bulkoperations<br />
**EntitySetName**: bulkoperations<br />
**PrimaryIdAttribute**: activityid<br />
**PrimaryNameAttribute**: subject<br />
**OwnershipType**: UserOwned<br />
**IsBPFEntity**: False<br />
<a name="writable-attributes"></a>

## Writable attributes

These attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [ActivityAdditionalParams](#BKMK_ActivityAdditionalParams)
- [ActivityId](#BKMK_ActivityId)
- [ActualEnd](#BKMK_ActualEnd)
- [BCC](#BKMK_BCC)
- [CC](#BKMK_CC)
- [Community](#BKMK_Community)
- [CreatedRecordTypeCode](#BKMK_CreatedRecordTypeCode)
- [Customers](#BKMK_Customers)
- [DeliveryPriorityCode](#BKMK_DeliveryPriorityCode)
- [ErrorNumber](#BKMK_ErrorNumber)
- [ExchangeItemId](#BKMK_ExchangeItemId)
- [ExchangeWebLink](#BKMK_ExchangeWebLink)
- [FailureCount](#BKMK_FailureCount)
- [from](#BKMK_from)
- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [IsMapiPrivate](#BKMK_IsMapiPrivate)
- [LastOnHoldTime](#BKMK_LastOnHoldTime)
- [LeftVoiceMail](#BKMK_LeftVoiceMail)
- [OperationTypeCode](#BKMK_OperationTypeCode)
- [OptionalAttendees](#BKMK_OptionalAttendees)
- [Organizer](#BKMK_Organizer)
- [OverriddenCreatedOn](#BKMK_OverriddenCreatedOn)
- [OwnerId](#BKMK_OwnerId)
- [OwnerIdType](#BKMK_OwnerIdType)
- [Parameters](#BKMK_Parameters)
- [Partners](#BKMK_Partners)
- [PriorityCode](#BKMK_PriorityCode)
- [ProcessId](#BKMK_ProcessId)
- [RegardingObjectId](#BKMK_RegardingObjectId)
- [RegardingObjectTypeCode](#BKMK_RegardingObjectTypeCode)
- [RequiredAttendees](#BKMK_RequiredAttendees)
- [Resources](#BKMK_Resources)
- [ServiceId](#BKMK_ServiceId)
- [SLAId](#BKMK_SLAId)
- [SortDate](#BKMK_SortDate)
- [StageId](#BKMK_StageId)
- [StatusCode](#BKMK_StatusCode)
- [Subject](#BKMK_Subject)
- [SuccessCount](#BKMK_SuccessCount)
- [TargetedRecordTypeCode](#BKMK_TargetedRecordTypeCode)
- [TargetMembersCount](#BKMK_TargetMembersCount)
- [TimeZoneRuleVersionNumber](#BKMK_TimeZoneRuleVersionNumber)
- [To](#BKMK_To)
- [TransactionCurrencyId](#BKMK_TransactionCurrencyId)
- [TraversedPath](#BKMK_TraversedPath)
- [UTCConversionTimeZoneCode](#BKMK_UTCConversionTimeZoneCode)
- [WorkflowInfo](#BKMK_WorkflowInfo)


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

**Description**: Unique identifier of the bulk operation.<br />
**DisplayName**: Activity<br />
**LogicalName**: activityid<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: SystemRequired<br />
**IsValidForUpdate**: False<br />
**Type**: Uniqueidentifier<br />


### <a name="BKMK_ActualEnd"></a> ActualEnd

**Description**: Shows the date and time when the quick campaign was completed or canceled.<br />
**DisplayName**: Actual End<br />
**LogicalName**: actualend<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**IsValidForCreate**: False<br />
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
**Targets**: account,contact,systemuser


### <a name="BKMK_CC"></a> CC

**Description**: Carbon-copy (cc) recipients of the activity.<br />
**DisplayName**: CC<br />
**LogicalName**: cc<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: PartyList<br />
**Targets**: account,contact,systemuser


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



### <a name="BKMK_CreatedRecordTypeCode"></a> CreatedRecordTypeCode

**Description**: Choose the activity to create that determines how target prospects or customers in this quick campaign are contacted.<br />
**DisplayName**: Activity Type<br />
**LogicalName**: createdrecordtypecode<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**IsValidForUpdate**: False<br />
**Type**: Picklist<br />
**Options**:

- **Value**: 1 **Label**: Phone Call
- **Value**: 2 **Label**: Fax
- **Value**: 3 **Label**: Letter
- **Value**: 4 **Label**: Email
- **Value**: 5 **Label**: Appointment
- **Value**: 6 **Label**: Send Direct Email



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



### <a name="BKMK_ErrorNumber"></a> ErrorNumber

**Description**: Shows the error code that is used to troubleshoot issues in the quick campaign.<br />
**DisplayName**: Error Number<br />
**LogicalName**: errornumber<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**IsValidForCreate**: False<br />
**Type**: Integer<br />
**Format**: None<br />
**MaxValue**: 2147483647<br />
**MinValue**: -2147483648


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


### <a name="BKMK_FailureCount"></a> FailureCount

**Description**: Number of records which failed in the bulk operation.<br />
**DisplayName**: No. of Failures<br />
**LogicalName**: failurecount<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**IsValidForCreate**: False<br />
**Type**: Integer<br />
**Format**: None<br />
**MaxValue**: 1000000000<br />
**MinValue**: 0


### <a name="BKMK_from"></a> from

**Description**: Person who the activity is from.<br />
**DisplayName**: From<br />
**LogicalName**: from<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: PartyList<br />
**Targets**: account,contact,systemuser


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


### <a name="BKMK_OperationTypeCode"></a> OperationTypeCode

**Description**: Select the type of bulk operation process, such as quick campaign or campaign activity distribution.<br />
**DisplayName**: Operation<br />
**LogicalName**: operationtypecode<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**IsValidForUpdate**: False<br />
**Type**: Picklist<br />
**Options**:

- **Value**: 1 **Label**: Create Opportunities
- **Value**: 2 **Label**: Create Activities
- **Value**: 3 **Label**: Send Direct Mail
- **Value**: 4 **Label**: Distribute
- **Value**: 5 **Label**: Execute
- **Value**: 7 **Label**: Quick Campaign



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
**IsValidForUpdate**: False<br />
**Type**: Owner<br />
**Targets**: systemuser,team


### <a name="BKMK_OwnerIdType"></a> OwnerIdType

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: owneridtype<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: SystemRequired<br />
**IsValidForUpdate**: False<br />
**Type**: EntityName<br />


### <a name="BKMK_Parameters"></a> Parameters

**Description**: XML string that contains the parameters to the bulk operation.<br />
**DisplayName**: Parameters<br />
**LogicalName**: parameters<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**IsValidForUpdate**: False<br />
**Type**: Memo<br />
**Format**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100000


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

**Description**: Choose the campaign from which the campaign activities were bulk-distributed.<br />
**DisplayName**: Import File Name<br />
**LogicalName**: regardingobjectid<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**IsValidForUpdate**: False<br />
**Type**: Lookup<br />
**Targets**: campaignactivity,list


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


### <a name="BKMK_ServiceId"></a> ServiceId

**Description**: Unique identifier for an associated service.<br />
**DisplayName**: Service<br />
**LogicalName**: serviceid<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: 


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


### <a name="BKMK_StatusCode"></a> StatusCode

**Description**: Select the quick campaign's status.<br />
**DisplayName**: Status Reason<br />
**LogicalName**: statuscode<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**IsValidForUpdate**: False<br />
**Type**: Status<br />
**Options**:

- **Value**: 1 **Label**: Pending **State**: 0
- **Value**: 2 **Label**: In Progress **State**: 0
- **Value**: 3 **Label**: Aborted **State**: 1
- **Value**: 4 **Label**: Completed **State**: 1
- **Value**: 5 **Label**: Canceled **State**: 2



### <a name="BKMK_Subject"></a> Subject

**Description**: Type a short description about the objective or primary topic of the quick campaign.<br />
**DisplayName**: Subject<br />
**LogicalName**: subject<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: ApplicationRequired<br />
**IsValidForUpdate**: False<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 200


### <a name="BKMK_SuccessCount"></a> SuccessCount

**Description**: Number of records which succeeded in the bulk operation.<br />
**DisplayName**: No. of Successes<br />
**LogicalName**: successcount<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**IsValidForCreate**: False<br />
**Type**: Integer<br />
**Format**: None<br />
**MaxValue**: 1000000000<br />
**MinValue**: 0


### <a name="BKMK_TargetedRecordTypeCode"></a> TargetedRecordTypeCode

**Description**: Select the type of records targeted in the quick campaign to identify the target audience.<br />
**DisplayName**: Members Type<br />
**LogicalName**: targetedrecordtypecode<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**IsValidForUpdate**: False<br />
**Type**: Picklist<br />
**Options**:

- **Value**: 1 **Label**: Account
- **Value**: 2 **Label**: Contact
- **Value**: 4 **Label**: Lead



### <a name="BKMK_TargetMembersCount"></a> TargetMembersCount

**Description**: Number of members to target.<br />
**DisplayName**: Total Members<br />
**LogicalName**: targetmemberscount<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Integer<br />
**Format**: None<br />
**MaxValue**: 1000000000<br />
**MinValue**: 0


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
**MinValue**: -2147483648


### <a name="BKMK_WorkflowInfo"></a> WorkflowInfo

**Description**: Information for bulk operation workflow.<br />
**DisplayName**: Workflow information<br />
**LogicalName**: workflowinfo<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**IsValidForCreate**: False<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100000

<a name="read-only-attributes"></a>
## Read-only attributes
These attributes return false for both **IsValidForCreate** or **IsValidForUpdate**. Listed by **SchemaName**.

- [ActivityTypeCode](#BKMK_ActivityTypeCode)
- [ActualDurationMinutes](#BKMK_ActualDurationMinutes)
- [ActualStart](#BKMK_ActualStart)
- [BulkOperationNumber](#BKMK_BulkOperationNumber)
- [CreatedBy](#BKMK_CreatedBy)
- [CreatedByName](#BKMK_CreatedByName)
- [CreatedByYomiName](#BKMK_CreatedByYomiName)
- [CreatedOn](#BKMK_CreatedOn)
- [CreatedOnBehalfBy](#BKMK_CreatedOnBehalfBy)
- [CreatedOnBehalfByName](#BKMK_CreatedOnBehalfByName)
- [CreatedOnBehalfByYomiName](#BKMK_CreatedOnBehalfByYomiName)
- [DeliveryLastAttemptedOn](#BKMK_DeliveryLastAttemptedOn)
- [Description](#BKMK_Description)
- [ExchangeRate](#BKMK_ExchangeRate)
- [InstanceTypeCode](#BKMK_InstanceTypeCode)
- [IsBilled](#BKMK_IsBilled)
- [IsRegularActivity](#BKMK_IsRegularActivity)
- [IsWorkflowCreated](#BKMK_IsWorkflowCreated)
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
- [ScheduledEnd](#BKMK_ScheduledEnd)
- [ScheduledStart](#BKMK_ScheduledStart)
- [SenderMailboxId](#BKMK_SenderMailboxId)
- [SenderMailboxIdName](#BKMK_SenderMailboxIdName)
- [SentOn](#BKMK_SentOn)
- [SeriesId](#BKMK_SeriesId)
- [SLAInvokedId](#BKMK_SLAInvokedId)
- [SLAInvokedIdName](#BKMK_SLAInvokedIdName)
- [SLAName](#BKMK_SLAName)
- [StateCode](#BKMK_StateCode)
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


### <a name="BKMK_ActualDurationMinutes"></a> ActualDurationMinutes

**Description**: Actual duration of the bulk operation in minutes.<br />
**DisplayName**: Actual Duration<br />
**LogicalName**: actualdurationminutes<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Integer<br />
**Format**: None<br />
**MaxValue**: 2147483647<br />
**MinValue**: 0


### <a name="BKMK_ActualStart"></a> ActualStart

**Description**: Shows the date and time when the activity was started or created.<br />
**DisplayName**: Actual Start<br />
**LogicalName**: actualstart<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: DateTime<br />
**DateTimeBehavior**: UserLocal<br />
**Format**: DateAndTime


### <a name="BKMK_BulkOperationNumber"></a> BulkOperationNumber

**Description**: Shows the number for the quick campaign record, used to identify the quick campaign.<br />
**DisplayName**: Bulk Operation Number<br />
**LogicalName**: bulkoperationnumber<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 32


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

**Description**: Name of the user who created the bulk operation.<br />
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

**Description**: Unique identifier of the delegate user who created the bulk operation.<br />
**DisplayName**: Created By (Delegate)<br />
**LogicalName**: createdonbehalfby<br />
**IsValidForForm**: False<br />
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


### <a name="BKMK_Description"></a> Description

**Description**: Type additional information to describe the quick campaign, such as the products or services offered.<br />
**DisplayName**: Description<br />
**LogicalName**: description<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Memo<br />
**Format**: TextArea<br />
**IsLocalizable**: False<br />
**MaxLength**: 2000


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



### <a name="BKMK_IsBilled"></a> IsBilled

**Description**: For internal use only.<br />
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


### <a name="BKMK_IsWorkflowCreated"></a> IsWorkflowCreated

**Description**: Specifies if the bulk operation was created from a workflow rule.<br />
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

**Description**: Name of the user who modified the bulk operation.<br />
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

**Description**: Date and time when the bulk operation was last modified.<br />
**DisplayName**: Modified On<br />
**LogicalName**: modifiedon<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: DateTime<br />
**DateTimeBehavior**: UserLocal<br />
**Format**: DateAndTime


### <a name="BKMK_ModifiedOnBehalfBy"></a> ModifiedOnBehalfBy

**Description**: Unique identifier of the delegate user who last modified the bulk operation.<br />
**DisplayName**: Modified By (Delegate)<br />
**LogicalName**: modifiedonbehalfby<br />
**IsValidForForm**: False<br />
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

**Description**: Scheduled duration of the bulk operation, specified in minutes.<br />
**DisplayName**: Scheduled Duration<br />
**LogicalName**: scheduleddurationminutes<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Integer<br />
**Format**: None<br />
**MaxValue**: 2147483647<br />
**MinValue**: 0


### <a name="BKMK_ScheduledEnd"></a> ScheduledEnd

**Description**: Scheduled end date and time of the bulk operation.<br />
**DisplayName**: Due Date<br />
**LogicalName**: scheduledend<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: DateTime<br />
**DateTimeBehavior**: UserLocal<br />
**Format**: DateOnly


### <a name="BKMK_ScheduledStart"></a> ScheduledStart

**Description**: Scheduled start date and time of the bulk operation.<br />
**DisplayName**: Start Date<br />
**LogicalName**: scheduledstart<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: DateTime<br />
**DateTimeBehavior**: UserLocal<br />
**Format**: DateOnly


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


### <a name="BKMK_StateCode"></a> StateCode

**Description**: Shows whether the quick campaign is open, closed, or canceled.  Closed or canceled quick campaigns are read-only and can't be edited.<br />
**DisplayName**: Status<br />
**LogicalName**: statecode<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: SystemRequired<br />
**Type**: State<br />
**Options**:

- **Value**: 0 **Label**: Open **DefaultStatus**: 1 **InvariantName**: Open
- **Value**: 1 **Label**: Closed **DefaultStatus**: 4 **InvariantName**: Closed
- **Value**: 2 **Label**: Canceled **DefaultStatus**: 5 **InvariantName**: Canceled



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

- [BulkOperation_ActivityPointers](#BKMK_BulkOperation_ActivityPointers)
- [BulkOperation_SyncErrors](#BKMK_BulkOperation_SyncErrors)
- [bulkoperation_activity_parties](#BKMK_bulkoperation_activity_parties)
- [BulkOperation_AsyncOperations](#BKMK_BulkOperation_AsyncOperations)
- [BulkOperation_MailboxTrackingFolder](#BKMK_BulkOperation_MailboxTrackingFolder)
- [userentityinstancedata_bulkoperation](#BKMK_userentityinstancedata_bulkoperation)
- [BulkOperation_BulkDeleteFailures](#BKMK_BulkOperation_BulkDeleteFailures)
- [bulkoperation_PrincipalObjectAttributeAccesses](#BKMK_bulkoperation_PrincipalObjectAttributeAccesses)
- [BulkOperation_Appointment](#BKMK_BulkOperation_Appointment)
- [BulkOperation_Email](#BKMK_BulkOperation_Email)
- [BulkOperation_Faxes](#BKMK_BulkOperation_Faxes)
- [BulkOperation_Letter](#BKMK_BulkOperation_Letter)
- [BulkOperation_Phonecall](#BKMK_BulkOperation_Phonecall)
- [bulkoperation_Tasks](#BKMK_bulkoperation_Tasks)
- [BulkOperation_RecurringAppointmentMaster](#BKMK_BulkOperation_RecurringAppointmentMaster)
- [BulkOperation_SocialActivity](#BKMK_BulkOperation_SocialActivity)
- [bulkoperation_Annotations](#BKMK_bulkoperation_Annotations)
- [bulkoperation_CampaignActivities](#BKMK_bulkoperation_CampaignActivities)
- [bulkoperation_CampaignResponses](#BKMK_bulkoperation_CampaignResponses)
- [BulkOperation_CampaignResponse](#BKMK_BulkOperation_CampaignResponse)
- [BulkOperation_logs](#BKMK_BulkOperation_logs)
- [BulkOperation_QueueItem](#BKMK_BulkOperation_QueueItem)
- [bulkoperation_IncidentResolutions](#BKMK_bulkoperation_IncidentResolutions)
- [bulkoperation_ServiceAppointments](#BKMK_bulkoperation_ServiceAppointments)
- [bulkoperation_OpportunityCloses](#BKMK_bulkoperation_OpportunityCloses)
- [bulkoperation_OrderCloses](#BKMK_bulkoperation_OrderCloses)
- [bulkoperation_QuoteCloses](#BKMK_bulkoperation_QuoteCloses)
- [bulkoperation_msdyn_bookingalerts](#BKMK_bulkoperation_msdyn_bookingalerts)
- [bulkoperation_msdyn_approvals](#BKMK_bulkoperation_msdyn_approvals)


### <a name="BKMK_BulkOperation_ActivityPointers"></a> BulkOperation_ActivityPointers

Same as activitypointer entity [BulkOperation_ActivityPointers](activitypointer.md#BKMK_BulkOperation_ActivityPointers) Many-To-One relationship.

**ReferencingEntity**: activitypointer<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: False<br />
**ReferencedEntityNavigationPropertyName**: BulkOperation_ActivityPointers<br />
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


### <a name="BKMK_BulkOperation_SyncErrors"></a> BulkOperation_SyncErrors

Same as syncerror entity [BulkOperation_SyncErrors](syncerror.md#BKMK_BulkOperation_SyncErrors) Many-To-One relationship.

**ReferencingEntity**: syncerror<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: BulkOperation_SyncErrors<br />
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


### <a name="BKMK_bulkoperation_activity_parties"></a> bulkoperation_activity_parties

Same as activityparty entity [bulkoperation_activity_parties](activityparty.md#BKMK_bulkoperation_activity_parties) Many-To-One relationship.

**ReferencingEntity**: activityparty<br />
**ReferencingAttribute**: partyid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: False<br />
**ReferencedEntityNavigationPropertyName**: bulkoperation_activity_parties<br />
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


### <a name="BKMK_BulkOperation_AsyncOperations"></a> BulkOperation_AsyncOperations

Same as asyncoperation entity [BulkOperation_AsyncOperations](asyncoperation.md#BKMK_BulkOperation_AsyncOperations) Many-To-One relationship.

**ReferencingEntity**: asyncoperation<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: False<br />
**ReferencedEntityNavigationPropertyName**: BulkOperation_AsyncOperations<br />
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


### <a name="BKMK_BulkOperation_MailboxTrackingFolder"></a> BulkOperation_MailboxTrackingFolder

Same as mailboxtrackingfolder entity [BulkOperation_MailboxTrackingFolder](mailboxtrackingfolder.md#BKMK_BulkOperation_MailboxTrackingFolder) Many-To-One relationship.

**ReferencingEntity**: mailboxtrackingfolder<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: BulkOperation_MailboxTrackingFolder<br />
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


### <a name="BKMK_userentityinstancedata_bulkoperation"></a> userentityinstancedata_bulkoperation

Same as userentityinstancedata entity [userentityinstancedata_bulkoperation](userentityinstancedata.md#BKMK_userentityinstancedata_bulkoperation) Many-To-One relationship.

**ReferencingEntity**: userentityinstancedata<br />
**ReferencingAttribute**: objectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: False<br />
**ReferencedEntityNavigationPropertyName**: userentityinstancedata_bulkoperation<br />
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


### <a name="BKMK_BulkOperation_BulkDeleteFailures"></a> BulkOperation_BulkDeleteFailures

Same as bulkdeletefailure entity [BulkOperation_BulkDeleteFailures](bulkdeletefailure.md#BKMK_BulkOperation_BulkDeleteFailures) Many-To-One relationship.

**ReferencingEntity**: bulkdeletefailure<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: False<br />
**ReferencedEntityNavigationPropertyName**: BulkOperation_BulkDeleteFailures<br />
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


### <a name="BKMK_bulkoperation_PrincipalObjectAttributeAccesses"></a> bulkoperation_PrincipalObjectAttributeAccesses

Same as principalobjectattributeaccess entity [bulkoperation_PrincipalObjectAttributeAccesses](principalobjectattributeaccess.md#BKMK_bulkoperation_PrincipalObjectAttributeAccesses) Many-To-One relationship.

**ReferencingEntity**: principalobjectattributeaccess<br />
**ReferencingAttribute**: objectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: bulkoperation_PrincipalObjectAttributeAccesses<br />
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


### <a name="BKMK_BulkOperation_Appointment"></a> BulkOperation_Appointment

Same as appointment entity [BulkOperation_Appointment](appointment.md#BKMK_BulkOperation_Appointment) Many-To-One relationship.

**ReferencingEntity**: appointment<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: BulkOperation_Appointment<br />
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


### <a name="BKMK_BulkOperation_Email"></a> BulkOperation_Email

Same as email entity [BulkOperation_Email](email.md#BKMK_BulkOperation_Email) Many-To-One relationship.

**ReferencingEntity**: email<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: BulkOperation_Email<br />
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


### <a name="BKMK_BulkOperation_Faxes"></a> BulkOperation_Faxes

Same as fax entity [BulkOperation_Faxes](fax.md#BKMK_BulkOperation_Faxes) Many-To-One relationship.

**ReferencingEntity**: fax<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: BulkOperation_Faxes<br />
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


### <a name="BKMK_BulkOperation_Letter"></a> BulkOperation_Letter

Same as letter entity [BulkOperation_Letter](letter.md#BKMK_BulkOperation_Letter) Many-To-One relationship.

**ReferencingEntity**: letter<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: BulkOperation_Letter<br />
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


### <a name="BKMK_BulkOperation_Phonecall"></a> BulkOperation_Phonecall

Same as phonecall entity [BulkOperation_Phonecall](phonecall.md#BKMK_BulkOperation_Phonecall) Many-To-One relationship.

**ReferencingEntity**: phonecall<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: BulkOperation_Phonecall<br />
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


### <a name="BKMK_bulkoperation_Tasks"></a> bulkoperation_Tasks

Same as task entity [bulkoperation_Tasks](task.md#BKMK_bulkoperation_Tasks) Many-To-One relationship.

**ReferencingEntity**: task<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: bulkoperation_Tasks<br />
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


### <a name="BKMK_BulkOperation_RecurringAppointmentMaster"></a> BulkOperation_RecurringAppointmentMaster

Same as recurringappointmentmaster entity [BulkOperation_RecurringAppointmentMaster](recurringappointmentmaster.md#BKMK_BulkOperation_RecurringAppointmentMaster) Many-To-One relationship.

**ReferencingEntity**: recurringappointmentmaster<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: False<br />
**ReferencedEntityNavigationPropertyName**: BulkOperation_RecurringAppointmentMaster<br />
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


### <a name="BKMK_BulkOperation_SocialActivity"></a> BulkOperation_SocialActivity

Same as socialactivity entity [BulkOperation_SocialActivity](socialactivity.md#BKMK_BulkOperation_SocialActivity) Many-To-One relationship.

**ReferencingEntity**: socialactivity<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: BulkOperation_SocialActivity<br />
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


### <a name="BKMK_bulkoperation_Annotations"></a> bulkoperation_Annotations

Same as annotation entity [bulkoperation_Annotations](annotation.md#BKMK_bulkoperation_Annotations) Many-To-One relationship.

**ReferencingEntity**: annotation<br />
**ReferencingAttribute**: objectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: bulkoperation_Annotations<br />
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


### <a name="BKMK_bulkoperation_CampaignActivities"></a> bulkoperation_CampaignActivities

Same as campaignactivity entity [bulkoperation_CampaignActivities](campaignactivity.md#BKMK_bulkoperation_CampaignActivities) Many-To-One relationship.

**ReferencingEntity**: campaignactivity<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: bulkoperation_CampaignActivities<br />
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


### <a name="BKMK_bulkoperation_CampaignResponses"></a> bulkoperation_CampaignResponses

Same as campaignresponse entity [bulkoperation_CampaignResponses](campaignresponse.md#BKMK_bulkoperation_CampaignResponses) Many-To-One relationship.

**ReferencingEntity**: campaignresponse<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: bulkoperation_CampaignResponses<br />
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


### <a name="BKMK_BulkOperation_CampaignResponse"></a> BulkOperation_CampaignResponse

Same as campaignresponse entity [BulkOperation_CampaignResponse](campaignresponse.md#BKMK_BulkOperation_CampaignResponse) Many-To-One relationship.

**ReferencingEntity**: campaignresponse<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: BulkOperation_CampaignResponse<br />
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


### <a name="BKMK_BulkOperation_logs"></a> BulkOperation_logs

Same as bulkoperationlog entity [BulkOperation_logs](bulkoperationlog.md#BKMK_BulkOperation_logs) Many-To-One relationship.

**ReferencingEntity**: bulkoperationlog<br />
**ReferencingAttribute**: bulkoperationid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: False<br />
**ReferencedEntityNavigationPropertyName**: BulkOperation_logs<br />
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


### <a name="BKMK_BulkOperation_QueueItem"></a> BulkOperation_QueueItem

Same as queueitem entity [BulkOperation_QueueItem](queueitem.md#BKMK_BulkOperation_QueueItem) Many-To-One relationship.

**ReferencingEntity**: queueitem<br />
**ReferencingAttribute**: objectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: BulkOperation_QueueItem<br />
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


### <a name="BKMK_bulkoperation_IncidentResolutions"></a> bulkoperation_IncidentResolutions

Same as incidentresolution entity [bulkoperation_IncidentResolutions](incidentresolution.md#BKMK_bulkoperation_IncidentResolutions) Many-To-One relationship.

**ReferencingEntity**: incidentresolution<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: bulkoperation_IncidentResolutions<br />
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


### <a name="BKMK_bulkoperation_ServiceAppointments"></a> bulkoperation_ServiceAppointments

Same as serviceappointment entity [bulkoperation_ServiceAppointments](serviceappointment.md#BKMK_bulkoperation_ServiceAppointments) Many-To-One relationship.

**ReferencingEntity**: serviceappointment<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: bulkoperation_ServiceAppointments<br />
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


### <a name="BKMK_bulkoperation_OpportunityCloses"></a> bulkoperation_OpportunityCloses

Same as opportunityclose entity [bulkoperation_OpportunityCloses](opportunityclose.md#BKMK_bulkoperation_OpportunityCloses) Many-To-One relationship.

**ReferencingEntity**: opportunityclose<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: bulkoperation_OpportunityCloses<br />
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


### <a name="BKMK_bulkoperation_OrderCloses"></a> bulkoperation_OrderCloses

Same as orderclose entity [bulkoperation_OrderCloses](orderclose.md#BKMK_bulkoperation_OrderCloses) Many-To-One relationship.

**ReferencingEntity**: orderclose<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: bulkoperation_OrderCloses<br />
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


### <a name="BKMK_bulkoperation_QuoteCloses"></a> bulkoperation_QuoteCloses

Same as quoteclose entity [bulkoperation_QuoteCloses](quoteclose.md#BKMK_bulkoperation_QuoteCloses) Many-To-One relationship.

**ReferencingEntity**: quoteclose<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: bulkoperation_QuoteCloses<br />
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


### <a name="BKMK_bulkoperation_msdyn_bookingalerts"></a> bulkoperation_msdyn_bookingalerts

Same as msdyn_bookingalert entity [bulkoperation_msdyn_bookingalerts](msdyn_bookingalert.md#BKMK_bulkoperation_msdyn_bookingalerts) Many-To-One relationship.

**ReferencingEntity**: msdyn_bookingalert<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: bulkoperation_msdyn_bookingalerts<br />
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


### <a name="BKMK_bulkoperation_msdyn_approvals"></a> bulkoperation_msdyn_approvals

Same as msdyn_approval entity [bulkoperation_msdyn_approvals](msdyn_approval.md#BKMK_bulkoperation_msdyn_approvals) Many-To-One relationship.

**ReferencingEntity**: msdyn_approval<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: bulkoperation_msdyn_approvals<br />
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

- [lead_BulkOperations](#BKMK_lead_BulkOperations)
- [bookableresourcebooking_BulkOperations](#BKMK_bookableresourcebooking_BulkOperations)
- [bookableresourcebookingheader_BulkOperations](#BKMK_bookableresourcebookingheader_BulkOperations)
- [interactionforemail_BulkOperations](#BKMK_interactionforemail_BulkOperations)
- [knowledgebaserecord_BulkOperations](#BKMK_knowledgebaserecord_BulkOperations)
- [account_BulkOperations](#BKMK_account_BulkOperations)
- [lk_BulkOperation_createdby](#BKMK_lk_BulkOperation_createdby)
- [contact_BulkOperations](#BKMK_contact_BulkOperations)
- [bulkoperation_mailbox_sendermailboxid](#BKMK_bulkoperation_mailbox_sendermailboxid)
- [bulkoperation_transactioncurrency_transactioncurrencyid](#BKMK_bulkoperation_transactioncurrency_transactioncurrencyid)
- [user_BulkOperation](#BKMK_user_BulkOperation)
- [bulkoperation_sla_slaid](#BKMK_bulkoperation_sla_slaid)
- [business_unit_BulkOperation_activities](#BKMK_business_unit_BulkOperation_activities)
- [knowledgearticle_BulkOperations](#BKMK_knowledgearticle_BulkOperations)
- [lk_BulkOperation_modifiedonbehalfby](#BKMK_lk_BulkOperation_modifiedonbehalfby)
- [lk_BulkOperation_createdonbehalfby](#BKMK_lk_BulkOperation_createdonbehalfby)
- [lk_BulkOperation_modifiedby](#BKMK_lk_BulkOperation_modifiedby)
- [team_BulkOperation](#BKMK_team_BulkOperation)
- [bulkoperation_sla_slainvokedid](#BKMK_bulkoperation_sla_slainvokedid)
- [activity_pointer_BulkOperation](#BKMK_activity_pointer_BulkOperation)
- [CampaignActivity_BulkOperations](#BKMK_CampaignActivity_BulkOperations)
- [List_BulkOperations](#BKMK_List_BulkOperations)


### <a name="BKMK_lead_BulkOperations"></a> lead_BulkOperations

See lead Entity [lead_BulkOperations](lead.md#BKMK_lead_BulkOperations) One-To-Many relationship.

### <a name="BKMK_bookableresourcebooking_BulkOperations"></a> bookableresourcebooking_BulkOperations

See bookableresourcebooking Entity [bookableresourcebooking_BulkOperations](bookableresourcebooking.md#BKMK_bookableresourcebooking_BulkOperations) One-To-Many relationship.

### <a name="BKMK_bookableresourcebookingheader_BulkOperations"></a> bookableresourcebookingheader_BulkOperations

See bookableresourcebookingheader Entity [bookableresourcebookingheader_BulkOperations](bookableresourcebookingheader.md#BKMK_bookableresourcebookingheader_BulkOperations) One-To-Many relationship.

### <a name="BKMK_interactionforemail_BulkOperations"></a> interactionforemail_BulkOperations

See interactionforemail Entity [interactionforemail_BulkOperations](interactionforemail.md#BKMK_interactionforemail_BulkOperations) One-To-Many relationship.

### <a name="BKMK_knowledgebaserecord_BulkOperations"></a> knowledgebaserecord_BulkOperations

See knowledgebaserecord Entity [knowledgebaserecord_BulkOperations](knowledgebaserecord.md#BKMK_knowledgebaserecord_BulkOperations) One-To-Many relationship.

### <a name="BKMK_account_BulkOperations"></a> account_BulkOperations

See account Entity [account_BulkOperations](account.md#BKMK_account_BulkOperations) One-To-Many relationship.

### <a name="BKMK_lk_BulkOperation_createdby"></a> lk_BulkOperation_createdby

See systemuser Entity [lk_BulkOperation_createdby](systemuser.md#BKMK_lk_BulkOperation_createdby) One-To-Many relationship.

### <a name="BKMK_contact_BulkOperations"></a> contact_BulkOperations

See contact Entity [contact_BulkOperations](contact.md#BKMK_contact_BulkOperations) One-To-Many relationship.

### <a name="BKMK_bulkoperation_mailbox_sendermailboxid"></a> bulkoperation_mailbox_sendermailboxid

See mailbox Entity [bulkoperation_mailbox_sendermailboxid](mailbox.md#BKMK_bulkoperation_mailbox_sendermailboxid) One-To-Many relationship.

### <a name="BKMK_bulkoperation_transactioncurrency_transactioncurrencyid"></a> bulkoperation_transactioncurrency_transactioncurrencyid

See transactioncurrency Entity [bulkoperation_transactioncurrency_transactioncurrencyid](transactioncurrency.md#BKMK_bulkoperation_transactioncurrency_transactioncurrencyid) One-To-Many relationship.

### <a name="BKMK_user_BulkOperation"></a> user_BulkOperation

See systemuser Entity [user_BulkOperation](systemuser.md#BKMK_user_BulkOperation) One-To-Many relationship.

### <a name="BKMK_bulkoperation_sla_slaid"></a> bulkoperation_sla_slaid

See sla Entity [bulkoperation_sla_slaid](sla.md#BKMK_bulkoperation_sla_slaid) One-To-Many relationship.

### <a name="BKMK_business_unit_BulkOperation_activities"></a> business_unit_BulkOperation_activities

See businessunit Entity [business_unit_BulkOperation_activities](businessunit.md#BKMK_business_unit_BulkOperation_activities) One-To-Many relationship.

### <a name="BKMK_knowledgearticle_BulkOperations"></a> knowledgearticle_BulkOperations

See knowledgearticle Entity [knowledgearticle_BulkOperations](knowledgearticle.md#BKMK_knowledgearticle_BulkOperations) One-To-Many relationship.

### <a name="BKMK_lk_BulkOperation_modifiedonbehalfby"></a> lk_BulkOperation_modifiedonbehalfby

See systemuser Entity [lk_BulkOperation_modifiedonbehalfby](systemuser.md#BKMK_lk_BulkOperation_modifiedonbehalfby) One-To-Many relationship.

### <a name="BKMK_lk_BulkOperation_createdonbehalfby"></a> lk_BulkOperation_createdonbehalfby

See systemuser Entity [lk_BulkOperation_createdonbehalfby](systemuser.md#BKMK_lk_BulkOperation_createdonbehalfby) One-To-Many relationship.

### <a name="BKMK_lk_BulkOperation_modifiedby"></a> lk_BulkOperation_modifiedby

See systemuser Entity [lk_BulkOperation_modifiedby](systemuser.md#BKMK_lk_BulkOperation_modifiedby) One-To-Many relationship.

### <a name="BKMK_team_BulkOperation"></a> team_BulkOperation

See team Entity [team_BulkOperation](team.md#BKMK_team_BulkOperation) One-To-Many relationship.

### <a name="BKMK_bulkoperation_sla_slainvokedid"></a> bulkoperation_sla_slainvokedid

See sla Entity [bulkoperation_sla_slainvokedid](sla.md#BKMK_bulkoperation_sla_slainvokedid) One-To-Many relationship.

### <a name="BKMK_activity_pointer_BulkOperation"></a> activity_pointer_BulkOperation

See activitypointer Entity [activity_pointer_BulkOperation](activitypointer.md#BKMK_activity_pointer_BulkOperation) One-To-Many relationship.

### <a name="BKMK_CampaignActivity_BulkOperations"></a> CampaignActivity_BulkOperations

See campaignactivity Entity [CampaignActivity_BulkOperations](campaignactivity.md#BKMK_CampaignActivity_BulkOperations) One-To-Many relationship.

### <a name="BKMK_List_BulkOperations"></a> List_BulkOperations

See list Entity [List_BulkOperations](list.md#BKMK_List_BulkOperations) One-To-Many relationship.

## See also

[About the Entity Reference](../about-entity-reference.md)<br />
[Programming reference for Dynamics 365 Customer Engagement](../programming-reference.md)<br />
[Web API Reference](/dynamics365/customer-engagement/web-api/about)<br />
<xref href="Microsoft.Dynamics.CRM.bulkoperation?text=bulkoperation EntityType" />