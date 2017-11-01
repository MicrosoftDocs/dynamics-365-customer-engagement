---
title: "SocialActivity Entity Reference (Developer Guide for Dynamics 365 Customer Engagement)| MicrosoftDocs"
description: "Includes schema information and supported messages for the SocialActivity entity."
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
# SocialActivity Entity Reference

[!INCLUDE[](../../includes/cc_applies_to_update_9_0_0.md)]

For internal use only.


## Messages

|Message|Web API Operation|SDK Assembly|
|-|-|-|
|Assign|PATCH [*org URI*]/api/data/v9.0/socialactivities(*activityid*)<br />[Update](../webapi/update-delete-entities-using-web-api.md#basic-update) `ownerid` property.|<xref:Microsoft.Crm.Sdk.Messages.AssignRequest>|
|Create|POST [*org URI*]/api/data/v9.0/socialactivities<br />See [Create](../webapi/create-entity-web-api.md)|<xref:Microsoft.Xrm.Sdk.Messages.CreateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Create*>|
|Delete|DELETE [*org URI*]/api/data/v9.0/socialactivities(*activityid*)<br />See [Delete](../webapi/update-delete-entities-using-web-api.md#basic-delete)|<xref:Microsoft.Xrm.Sdk.Messages.DeleteRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Delete*>|
|GrantAccess|<xref href="Microsoft.Dynamics.CRM.GrantAccess?text=GrantAccess Action" />|<xref:Microsoft.Crm.Sdk.Messages.GrantAccessRequest>|
|ModifyAccess|<xref href="Microsoft.Dynamics.CRM.ModifyAccess?text=ModifyAccess Action" />|<xref:Microsoft.Crm.Sdk.Messages.ModifyAccessRequest>|
|Retrieve|GET [*org URI*]/api/data/v9.0/socialactivities(*activityid*)<br />See [Retrieve](../webapi/retrieve-entity-using-web-api.md)|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Retrieve*>|
|RetrieveMultiple|GET [*org URI*]/api/data/v9.0/socialactivities<br />See [Query Data](../webapi/query-data-web-api.md)|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveMultipleRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.RetrieveMultiple*>|
|RetrievePrincipalAccess|<xref href="Microsoft.Dynamics.CRM.RetrievePrincipalAccess?text=RetrievePrincipalAccess Function" />|<xref:Microsoft.Crm.Sdk.Messages.RetrievePrincipalAccessRequest>|
|RetrieveSharedPrincipalsAndAccess|<xref href="Microsoft.Dynamics.CRM.RetrieveSharedPrincipalsAndAccess?text=RetrieveSharedPrincipalsAndAccess Function" />|<xref:Microsoft.Crm.Sdk.Messages.RetrieveSharedPrincipalsAndAccessRequest>|
|RevokeAccess|<xref href="Microsoft.Dynamics.CRM.RevokeAccess?text=RevokeAccess Action" />|<xref:Microsoft.Crm.Sdk.Messages.RevokeAccessRequest>|
|SetState|PATCH [*org URI*]/api/data/v9.0/socialactivities(*activityid*)<br />[Update](../webapi/update-delete-entities-using-web-api.md#basic-update) `statecode` and `statuscode` properties.|<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|
|Update|PATCH [*org URI*]/api/data/v9.0/socialactivities(*activityid*)<br />See [Update](../webapi/update-delete-entities-using-web-api.md#basic-update)|<xref:Microsoft.Xrm.Sdk.Messages.UpdateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Update*>|

## Properties

**DisplayName**: Social Activity<br />
**DisplayCollectionName**: Social Activities<br />
**SchemaName**: SocialActivity<br />
**CollectionSchemaName**: SocialActivities<br />
**LogicalName**: socialactivity<br />
**LogicalCollectionName**: socialactivities<br />
**EntitySetName**: socialactivities<br />
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
- [Community](#BKMK_Community)
- [Description](#BKMK_Description)
- [DirectionCode](#BKMK_DirectionCode)
- [From](#BKMK_From)
- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [InResponseTo](#BKMK_InResponseTo)
- [IsBilled](#BKMK_IsBilled)
- [IsWorkflowCreated](#BKMK_IsWorkflowCreated)
- [LastOnHoldTime](#BKMK_LastOnHoldTime)
- [OverriddenCreatedOn](#BKMK_OverriddenCreatedOn)
- [OwnerId](#BKMK_OwnerId)
- [OwnerIdType](#BKMK_OwnerIdType)
- [PostAuthor](#BKMK_PostAuthor)
- [PostAuthorAccount](#BKMK_PostAuthorAccount)
- [PostAuthorAccountType](#BKMK_PostAuthorAccountType)
- [PostAuthorType](#BKMK_PostAuthorType)
- [PostedOn](#BKMK_PostedOn)
- [PostFromProfileId](#BKMK_PostFromProfileId)
- [PostId](#BKMK_PostId)
- [PostMessageType](#BKMK_PostMessageType)
- [PostToProfileId](#BKMK_PostToProfileId)
- [PostURL](#BKMK_PostURL)
- [PriorityCode](#BKMK_PriorityCode)
- [ProcessId](#BKMK_ProcessId)
- [RegardingObjectId](#BKMK_RegardingObjectId)
- [RegardingObjectIdName](#BKMK_RegardingObjectIdName)
- [RegardingObjectIdYomiName](#BKMK_RegardingObjectIdYomiName)
- [RegardingObjectTypeCode](#BKMK_RegardingObjectTypeCode)
- [Resources](#BKMK_Resources)
- [ScheduledDurationMinutes](#BKMK_ScheduledDurationMinutes)
- [ScheduledEnd](#BKMK_ScheduledEnd)
- [ScheduledStart](#BKMK_ScheduledStart)
- [SentimentValue](#BKMK_SentimentValue)
- [ServiceId](#BKMK_ServiceId)
- [SLAId](#BKMK_SLAId)
- [SocialAdditionalParams](#BKMK_SocialAdditionalParams)
- [SortDate](#BKMK_SortDate)
- [StageId](#BKMK_StageId)
- [StateCode](#BKMK_StateCode)
- [StatusCode](#BKMK_StatusCode)
- [Subject](#BKMK_Subject)
- [ThreadId](#BKMK_ThreadId)
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



### <a name="BKMK_Description"></a> Description

**Description**: Shows information about the social post content. This field is read-only.<br />
**DisplayName**: Post Description<br />
**LogicalName**: description<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Memo<br />
**Format**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 2000


### <a name="BKMK_DirectionCode"></a> DirectionCode

**Description**: Select the direction of the post as incoming or outbound.<br />
**DisplayName**: Direction<br />
**LogicalName**: directioncode<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Boolean<br />
**Options**:

- **TrueOption Value**: 1 **Label**: Outgoing
- **FalseOption Value**: 0 **Label**: Incoming

**DefaultValue**: False


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


### <a name="BKMK_InResponseTo"></a> InResponseTo

**Description**: Unique identifier for the responses to a post. For internal use only.<br />
**DisplayName**: In Response To<br />
**LogicalName**: inresponseto<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 160


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


### <a name="BKMK_PostAuthor"></a> PostAuthor

**Description**: Shows the contact or account that authored the post.<br />
**DisplayName**: Post Author<br />
**LogicalName**: postauthor<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Customer<br />
**Targets**: account,contact


### <a name="BKMK_PostAuthorAccount"></a> PostAuthorAccount

**Description**: Shows the parent account of the author of the post.<br />
**DisplayName**: Post Author Account<br />
**LogicalName**: postauthoraccount<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: ApplicationRequired<br />
**Type**: Customer<br />
**Targets**: account,contact


### <a name="BKMK_PostAuthorAccountType"></a> PostAuthorAccountType

**Description**: Select the parent account or parent contact for the post author<br />
**DisplayName**: Post author parent<br />
**LogicalName**: postauthoraccounttype<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: EntityName<br />


### <a name="BKMK_PostAuthorType"></a> PostAuthorType

**Description**: Select the parent account or parent contact for the social profile of the social activity<br />
**DisplayName**: Post Author Type<br />
**LogicalName**: postauthortype<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: EntityName<br />


### <a name="BKMK_PostedOn"></a> PostedOn

**Description**: For internal use only.<br />
**DisplayName**: Created On<br />
**LogicalName**: postedon<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: DateTime<br />
**DateTimeBehavior**: UserLocal<br />
**Format**: DateAndTime


### <a name="BKMK_PostFromProfileId"></a> PostFromProfileId

**Description**: Shows the author of the post on the corresponding social channel.<br />
**DisplayName**: Posted By<br />
**LogicalName**: postfromprofileid<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: socialprofile


### <a name="BKMK_PostId"></a> PostId

**Description**: Unique identifier of the post. For internal use only.<br />
**DisplayName**: Post ID<br />
**LogicalName**: postid<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 160


### <a name="BKMK_PostMessageType"></a> PostMessageType

**Description**: Shows if the social post originated as a private or public message.<br />
**DisplayName**: Received As<br />
**LogicalName**: postmessagetype<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Picklist<br />
**Options**:

- **Value**: 0 **Label**: Public Message
- **Value**: 1 **Label**: Private Message



### <a name="BKMK_PostToProfileId"></a> PostToProfileId

**Description**: Shows the recipients of the social post.<br />
**DisplayName**: Posted To<br />
**LogicalName**: posttoprofileid<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 200


### <a name="BKMK_PostURL"></a> PostURL

**Description**: Shows the URL of the post.<br />
**DisplayName**: Post URL<br />
**LogicalName**: posturl<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Url<br />
**IsLocalizable**: False<br />
**MaxLength**: 200


### <a name="BKMK_PriorityCode"></a> PriorityCode

**Description**: Shows the priority so that preferred customers or critical issues are handled quickly.<br />
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

**Description**: Shows the record that the social activity relates to.<br />
**DisplayName**: Regarding<br />
**LogicalName**: regardingobjectid<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: account,asyncoperation,bookableresourcebooking,bookableresourcebookingheader,bulkoperation,campaign,campaignactivity,contact,contract,entitlement,entitlementtemplate,incident,invoice,knowledgearticle,knowledgebaserecord,lead,msdyn_agreement,msdyn_agreementbookingdate,msdyn_agreementbookingincident,msdyn_agreementbookingproduct,msdyn_agreementbookingservice,msdyn_agreementbookingservicetask,msdyn_agreementbookingsetup,msdyn_agreementinvoicedate,msdyn_agreementinvoiceproduct,msdyn_agreementinvoicesetup,msdyn_bookingalertstatus,msdyn_bookingrule,msdyn_bookingtimestamp,msdyn_customerasset,msdyn_fieldservicesetting,msdyn_incidenttypecharacteristic,msdyn_incidenttypeproduct,msdyn_incidenttypeservice,msdyn_inventoryadjustment,msdyn_inventoryadjustmentproduct,msdyn_inventoryjournal,msdyn_inventorytransfer,msdyn_payment,msdyn_paymentdetail,msdyn_paymentmethod,msdyn_paymentterm,msdyn_postalbum,msdyn_postalcode,msdyn_processnotes,msdyn_productinventory,msdyn_projectteam,msdyn_purchaseorder,msdyn_purchaseorderbill,msdyn_purchaseorderproduct,msdyn_purchaseorderreceipt,msdyn_purchaseorderreceiptproduct,msdyn_purchaseordersubstatus,msdyn_quotebookingincident,msdyn_quotebookingproduct,msdyn_quotebookingservice,msdyn_quotebookingservicetask,msdyn_resourceterritory,msdyn_rma,msdyn_rmaproduct,msdyn_rmareceipt,msdyn_rmareceiptproduct,msdyn_rmasubstatus,msdyn_rtv,msdyn_rtvproduct,msdyn_rtvsubstatus,msdyn_shipvia,msdyn_systemuserschedulersetting,msdyn_timegroup,msdyn_timegroupdetail,msdyn_timeoffrequest,msdyn_warehouse,msdyn_workorder,msdyn_workordercharacteristic,msdyn_workorderincident,msdyn_workorderproduct,msdyn_workorderresourcerestriction,msdyn_workorderservice,msdyn_workorderservicetask,opportunity,quote,salesorder,site


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


### <a name="BKMK_SentimentValue"></a> SentimentValue

**Description**: Value derived after assessing words commonly associated with a negative, neutral, or positive sentiment that occurs in a social post. Sentiment information can also be reported as numeric values.<br />
**DisplayName**: Sentiment Value<br />
**LogicalName**: sentimentvalue<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**IsValidForUpdate**: False<br />
**Type**: Double<br />
**MaxValue**: 100000000000<br />
**MinValue**: -100000000000<br />
**Precision**: 2


### <a name="BKMK_ServiceId"></a> ServiceId

**Description**: Unique identifier for the associated service.<br />
**DisplayName**: Service<br />
**LogicalName**: serviceid<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: service


### <a name="BKMK_SLAId"></a> SLAId

**Description**: Choose the service level agreement (SLA) that you want to apply to the Social Activity record.<br />
**DisplayName**: SLA<br />
**LogicalName**: slaid<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: sla


### <a name="BKMK_SocialAdditionalParams"></a> SocialAdditionalParams

**Description**: For internal use only.<br />
**DisplayName**: Social Additional Parameters<br />
**LogicalName**: socialadditionalparams<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**IsValidForUpdate**: False<br />
**Type**: Memo<br />
**Format**: TextArea<br />
**IsLocalizable**: False<br />
**MaxLength**: 8192


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

**Description**: Shows whether the social activity completed. This field is read-only.<br />
**DisplayName**: Status<br />
**LogicalName**: statecode<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: SystemRequired<br />
**IsValidForCreate**: False<br />
**Type**: State<br />
**Options**:

- **Value**: 0 **Label**: Open **DefaultStatus**: 4 **InvariantName**: Open
- **Value**: 1 **Label**: Completed **DefaultStatus**: 3 **InvariantName**: Completed
- **Value**: 2 **Label**: Canceled **DefaultStatus**: 5 **InvariantName**: Canceled



### <a name="BKMK_StatusCode"></a> StatusCode

**Description**: Shows whether the social activity is completed, failed, or processing. This field is read-only.<br />
**DisplayName**: Status Reason<br />
**LogicalName**: statuscode<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Status<br />
**Options**:

- **Value**: 1 **Label**: Completed **State**: 1
- **Value**: 2 **Label**: Failed **State**: 1
- **Value**: 3 **Label**: Processing **State**: 1
- **Value**: 4 **Label**: Open **State**: 0
- **Value**: 5 **Label**: Canceled **State**: 2



### <a name="BKMK_Subject"></a> Subject

**Description**: Subject associated with the activity.<br />
**DisplayName**: Subject<br />
**LogicalName**: subject<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 200


### <a name="BKMK_ThreadId"></a> ThreadId

**Description**: Unique identifier of the social conversation. For internal use only.<br />
**DisplayName**: Thread ID<br />
**LogicalName**: threadid<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 160


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
**MinValue**: -1

<a name="read-only-attributes"></a>
## Read-only attributes
These attributes return false for both **IsValidForCreate** or **IsValidForUpdate**. Listed by **SchemaName**.

- [ActivityTypeCode](#BKMK_ActivityTypeCode)
- [CreatedBy](#BKMK_CreatedBy)
- [CreatedOn](#BKMK_CreatedOn)
- [CreatedOnBehalfBy](#BKMK_CreatedOnBehalfBy)
- [CreatedOnBehalfByName](#BKMK_CreatedOnBehalfByName)
- [CreatedOnBehalfByYomiName](#BKMK_CreatedOnBehalfByYomiName)
- [ExchangeRate](#BKMK_ExchangeRate)
- [IsRegularActivity](#BKMK_IsRegularActivity)
- [ModifiedBy](#BKMK_ModifiedBy)
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
- [PostAuthorAccountName](#BKMK_PostAuthorAccountName)
- [PostAuthorAccountYomiName](#BKMK_PostAuthorAccountYomiName)
- [PostAuthorName](#BKMK_PostAuthorName)
- [PostAuthorYomiName](#BKMK_PostAuthorYomiName)
- [PostFromProfileIdName](#BKMK_PostFromProfileIdName)
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


### <a name="BKMK_CreatedOn"></a> CreatedOn

**Description**: Date and time when the activity was created.<br />
**DisplayName**: Created Date<br />
**LogicalName**: createdon<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: DateTime<br />
**DateTimeBehavior**: UserLocal<br />
**Format**: DateAndTime


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

**Description**: For internal use only.<br />
**DisplayName**: Modified By<br />
**LogicalName**: modifiedby<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: systemuser


### <a name="BKMK_ModifiedOn"></a> ModifiedOn

**Description**: Shows the date and time when the record was last updated. The date and time are displayed in the time zone selected in Microsoft Dynamics 365 options.<br />
**DisplayName**: Last Updated<br />
**LogicalName**: modifiedon<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: DateTime<br />
**DateTimeBehavior**: UserLocal<br />
**Format**: DateAndTime


### <a name="BKMK_ModifiedOnBehalfBy"></a> ModifiedOnBehalfBy

**Description**: For internal use only.<br />
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

**Description**: Unique identifier of the user who owns the Activity.<br />
**DisplayName**: Owning User<br />
**LogicalName**: owninguser<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: systemuser


### <a name="BKMK_PostAuthorAccountName"></a> PostAuthorAccountName

**Description**: Select the parent account or parent contact for post author.<br />
**DisplayName**: Post author parent<br />
**LogicalName**: postauthoraccountname<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: ApplicationRequired<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 160


### <a name="BKMK_PostAuthorAccountYomiName"></a> PostAuthorAccountYomiName

**Description**: Select the parent account or parent contact for the post author<br />
**DisplayName**: Post author parent<br />
**LogicalName**: postauthoraccountyominame<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: ApplicationRequired<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 450


### <a name="BKMK_PostAuthorName"></a> PostAuthorName

**Description**: Account or contact associated with the social profile or author of the post.<br />
**DisplayName**: Post Author Name<br />
**LogicalName**: postauthorname<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: ApplicationRequired<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 160


### <a name="BKMK_PostAuthorYomiName"></a> PostAuthorYomiName

**Description**: Parent account or parent contact for the social profile of the social activity<br />
**DisplayName**: Post Author Yomi Name<br />
**LogicalName**: postauthoryominame<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: ApplicationRequired<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 450


### <a name="BKMK_PostFromProfileIdName"></a> PostFromProfileIdName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: postedbyname<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: ApplicationRequired<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


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

**Description**: Last SLA that was applied to this Social Activity. This field is for internal use only.<br />
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

**Description**: Version number of the social activity.<br />
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

- [socialactivity_principalobjectattributeaccess](#BKMK_socialactivity_principalobjectattributeaccess)
- [socialactivity_activity_parties](#BKMK_socialactivity_activity_parties)
- [SocialActivity_BulkDeleteFailures](#BKMK_SocialActivity_BulkDeleteFailures)
- [SocialActivity_QueueItem](#BKMK_SocialActivity_QueueItem)
- [SocialActivity_SyncErrors](#BKMK_SocialActivity_SyncErrors)
- [slakpiinstance_socialactivity](#BKMK_slakpiinstance_socialactivity)
- [SocialActivity_DuplicateBaseRecord](#BKMK_SocialActivity_DuplicateBaseRecord)
- [SocialActivity_AsyncOperations](#BKMK_SocialActivity_AsyncOperations)
- [SocialActivity_ProcessSessions](#BKMK_SocialActivity_ProcessSessions)
- [SocialActivity_DuplicateMatchingRecord](#BKMK_SocialActivity_DuplicateMatchingRecord)
- [userentityinstancedata_socialactivity](#BKMK_userentityinstancedata_socialactivity)
- [socialactivity_connections1](#BKMK_socialactivity_connections1)
- [SocialActivity_Annotation](#BKMK_SocialActivity_Annotation)
- [socialactivity_connections2](#BKMK_socialactivity_connections2)


### <a name="BKMK_socialactivity_principalobjectattributeaccess"></a> socialactivity_principalobjectattributeaccess

Same as principalobjectattributeaccess entity [socialactivity_principalobjectattributeaccess](principalobjectattributeaccess.md#BKMK_socialactivity_principalobjectattributeaccess) Many-To-One relationship.

**ReferencingEntity**: principalobjectattributeaccess<br />
**ReferencingAttribute**: objectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: False<br />
**ReferencedEntityNavigationPropertyName**: socialactivity_principalobjectattributeaccess<br />
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


### <a name="BKMK_socialactivity_activity_parties"></a> socialactivity_activity_parties

Same as activityparty entity [socialactivity_activity_parties](activityparty.md#BKMK_socialactivity_activity_parties) Many-To-One relationship.

**ReferencingEntity**: activityparty<br />
**ReferencingAttribute**: activityid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: False<br />
**ReferencedEntityNavigationPropertyName**: socialactivity_activity_parties<br />
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


### <a name="BKMK_SocialActivity_BulkDeleteFailures"></a> SocialActivity_BulkDeleteFailures

Same as bulkdeletefailure entity [SocialActivity_BulkDeleteFailures](bulkdeletefailure.md#BKMK_SocialActivity_BulkDeleteFailures) Many-To-One relationship.

**ReferencingEntity**: bulkdeletefailure<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: False<br />
**ReferencedEntityNavigationPropertyName**: SocialActivity_BulkDeleteFailures<br />
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


### <a name="BKMK_SocialActivity_QueueItem"></a> SocialActivity_QueueItem

Same as queueitem entity [SocialActivity_QueueItem](queueitem.md#BKMK_SocialActivity_QueueItem) Many-To-One relationship.

**ReferencingEntity**: queueitem<br />
**ReferencingAttribute**: objectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: SocialActivity_QueueItem<br />
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


### <a name="BKMK_SocialActivity_SyncErrors"></a> SocialActivity_SyncErrors

Same as syncerror entity [SocialActivity_SyncErrors](syncerror.md#BKMK_SocialActivity_SyncErrors) Many-To-One relationship.

**ReferencingEntity**: syncerror<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: SocialActivity_SyncErrors<br />
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


### <a name="BKMK_slakpiinstance_socialactivity"></a> slakpiinstance_socialactivity

Same as slakpiinstance entity [slakpiinstance_socialactivity](slakpiinstance.md#BKMK_slakpiinstance_socialactivity) Many-To-One relationship.

**ReferencingEntity**: slakpiinstance<br />
**ReferencingAttribute**: regarding<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: slakpiinstance_socialactivity<br />
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


### <a name="BKMK_SocialActivity_DuplicateBaseRecord"></a> SocialActivity_DuplicateBaseRecord

Same as duplicaterecord entity [SocialActivity_DuplicateBaseRecord](duplicaterecord.md#BKMK_SocialActivity_DuplicateBaseRecord) Many-To-One relationship.

**ReferencingEntity**: duplicaterecord<br />
**ReferencingAttribute**: baserecordid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: False<br />
**ReferencedEntityNavigationPropertyName**: SocialActivity_DuplicateBaseRecord<br />
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


### <a name="BKMK_SocialActivity_AsyncOperations"></a> SocialActivity_AsyncOperations

Same as asyncoperation entity [SocialActivity_AsyncOperations](asyncoperation.md#BKMK_SocialActivity_AsyncOperations) Many-To-One relationship.

**ReferencingEntity**: asyncoperation<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: False<br />
**ReferencedEntityNavigationPropertyName**: SocialActivity_AsyncOperations<br />
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


### <a name="BKMK_SocialActivity_ProcessSessions"></a> SocialActivity_ProcessSessions

Same as processsession entity [SocialActivity_ProcessSessions](processsession.md#BKMK_SocialActivity_ProcessSessions) Many-To-One relationship.

**ReferencingEntity**: processsession<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: False<br />
**ReferencedEntityNavigationPropertyName**: SocialActivity_ProcessSessions<br />
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


### <a name="BKMK_SocialActivity_DuplicateMatchingRecord"></a> SocialActivity_DuplicateMatchingRecord

Same as duplicaterecord entity [SocialActivity_DuplicateMatchingRecord](duplicaterecord.md#BKMK_SocialActivity_DuplicateMatchingRecord) Many-To-One relationship.

**ReferencingEntity**: duplicaterecord<br />
**ReferencingAttribute**: duplicaterecordid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: False<br />
**ReferencedEntityNavigationPropertyName**: SocialActivity_DuplicateMatchingRecord<br />
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


### <a name="BKMK_userentityinstancedata_socialactivity"></a> userentityinstancedata_socialactivity

Same as userentityinstancedata entity [userentityinstancedata_socialactivity](userentityinstancedata.md#BKMK_userentityinstancedata_socialactivity) Many-To-One relationship.

**ReferencingEntity**: userentityinstancedata<br />
**ReferencingAttribute**: objectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: False<br />
**ReferencedEntityNavigationPropertyName**: userentityinstancedata_socialactivity<br />
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


### <a name="BKMK_socialactivity_connections1"></a> socialactivity_connections1

Same as connection entity [socialactivity_connections1](connection.md#BKMK_socialactivity_connections1) Many-To-One relationship.

**ReferencingEntity**: connection<br />
**ReferencingAttribute**: record1id<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: socialactivity_connections1<br />
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


### <a name="BKMK_SocialActivity_Annotation"></a> SocialActivity_Annotation

Same as annotation entity [SocialActivity_Annotation](annotation.md#BKMK_SocialActivity_Annotation) Many-To-One relationship.

**ReferencingEntity**: annotation<br />
**ReferencingAttribute**: objectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: SocialActivity_Annotation<br />
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


### <a name="BKMK_socialactivity_connections2"></a> socialactivity_connections2

Same as connection entity [socialactivity_connections2](connection.md#BKMK_socialactivity_connections2) Many-To-One relationship.

**ReferencingEntity**: connection<br />
**ReferencingAttribute**: record2id<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: socialactivity_connections2<br />
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

<a name="manytoone"></a>

## Many-To-One Relationships

Each Many-To-One relationship is defined by a corresponding One-To-Many relationship with the related entity. Listed by **SchemaName**.

- [Lead_SocialActivities](#BKMK_Lead_SocialActivities)
- [bookableresourcebooking_SocialActivities](#BKMK_bookableresourcebooking_SocialActivities)
- [bookableresourcebookingheader_SocialActivities](#BKMK_bookableresourcebookingheader_SocialActivities)
- [BulkOperation_SocialActivity](#BKMK_BulkOperation_SocialActivity)
- [campaign_SocialActivities](#BKMK_campaign_SocialActivities)
- [campaignactivity_SocialActivities](#BKMK_campaignactivity_SocialActivities)
- [Contract_SocialActivities](#BKMK_Contract_SocialActivities)
- [entitlement_SocialActivities](#BKMK_entitlement_SocialActivities)
- [entitlementtemplate_SocialActivities](#BKMK_entitlementtemplate_SocialActivities)
- [Incident_SocialActivities](#BKMK_Incident_SocialActivities)
- [site_SocialActivities](#BKMK_site_SocialActivities)
- [service_socialactivities](#BKMK_service_socialactivities)
- [Invoice_SocialActivities](#BKMK_Invoice_SocialActivities)
- [Opportunity_SocialActivities](#BKMK_Opportunity_SocialActivities)
- [Quote_SocialActivities](#BKMK_Quote_SocialActivities)
- [SalesOrder_SocialActivities](#BKMK_SalesOrder_SocialActivities)
- [msdyn_postalbum_SocialActivities](#BKMK_msdyn_postalbum_SocialActivities)
- [msdyn_bookingalertstatus_SocialActivities](#BKMK_msdyn_bookingalertstatus_SocialActivities)
- [msdyn_bookingrule_SocialActivities](#BKMK_msdyn_bookingrule_SocialActivities)
- [msdyn_resourceterritory_SocialActivities](#BKMK_msdyn_resourceterritory_SocialActivities)
- [msdyn_systemuserschedulersetting_SocialActivities](#BKMK_msdyn_systemuserschedulersetting_SocialActivities)
- [msdyn_timegroup_SocialActivities](#BKMK_msdyn_timegroup_SocialActivities)
- [msdyn_timegroupdetail_SocialActivities](#BKMK_msdyn_timegroupdetail_SocialActivities)
- [msdyn_processnotes_SocialActivities](#BKMK_msdyn_processnotes_SocialActivities)
- [msdyn_projectteam_SocialActivities](#BKMK_msdyn_projectteam_SocialActivities)
- [msdyn_agreement_SocialActivities](#BKMK_msdyn_agreement_SocialActivities)
- [msdyn_agreementbookingdate_SocialActivities](#BKMK_msdyn_agreementbookingdate_SocialActivities)
- [msdyn_agreementbookingincident_SocialActivities](#BKMK_msdyn_agreementbookingincident_SocialActivities)
- [msdyn_agreementbookingproduct_SocialActivities](#BKMK_msdyn_agreementbookingproduct_SocialActivities)
- [msdyn_agreementbookingservice_SocialActivities](#BKMK_msdyn_agreementbookingservice_SocialActivities)
- [msdyn_agreementbookingservicetask_SocialActivities](#BKMK_msdyn_agreementbookingservicetask_SocialActivities)
- [msdyn_agreementbookingsetup_SocialActivities](#BKMK_msdyn_agreementbookingsetup_SocialActivities)
- [msdyn_agreementinvoicedate_SocialActivities](#BKMK_msdyn_agreementinvoicedate_SocialActivities)
- [msdyn_agreementinvoiceproduct_SocialActivities](#BKMK_msdyn_agreementinvoiceproduct_SocialActivities)
- [msdyn_agreementinvoicesetup_SocialActivities](#BKMK_msdyn_agreementinvoicesetup_SocialActivities)
- [msdyn_bookingtimestamp_SocialActivities](#BKMK_msdyn_bookingtimestamp_SocialActivities)
- [msdyn_customerasset_SocialActivities](#BKMK_msdyn_customerasset_SocialActivities)
- [msdyn_fieldservicesetting_SocialActivities](#BKMK_msdyn_fieldservicesetting_SocialActivities)
- [msdyn_incidenttypecharacteristic_SocialActivities](#BKMK_msdyn_incidenttypecharacteristic_SocialActivities)
- [msdyn_incidenttypeproduct_SocialActivities](#BKMK_msdyn_incidenttypeproduct_SocialActivities)
- [msdyn_incidenttypeservice_SocialActivities](#BKMK_msdyn_incidenttypeservice_SocialActivities)
- [msdyn_inventoryadjustment_SocialActivities](#BKMK_msdyn_inventoryadjustment_SocialActivities)
- [msdyn_inventoryadjustmentproduct_SocialActivities](#BKMK_msdyn_inventoryadjustmentproduct_SocialActivities)
- [msdyn_inventoryjournal_SocialActivities](#BKMK_msdyn_inventoryjournal_SocialActivities)
- [msdyn_inventorytransfer_SocialActivities](#BKMK_msdyn_inventorytransfer_SocialActivities)
- [msdyn_payment_SocialActivities](#BKMK_msdyn_payment_SocialActivities)
- [msdyn_paymentdetail_SocialActivities](#BKMK_msdyn_paymentdetail_SocialActivities)
- [msdyn_paymentmethod_SocialActivities](#BKMK_msdyn_paymentmethod_SocialActivities)
- [msdyn_paymentterm_SocialActivities](#BKMK_msdyn_paymentterm_SocialActivities)
- [msdyn_postalcode_SocialActivities](#BKMK_msdyn_postalcode_SocialActivities)
- [msdyn_productinventory_SocialActivities](#BKMK_msdyn_productinventory_SocialActivities)
- [msdyn_purchaseorder_SocialActivities](#BKMK_msdyn_purchaseorder_SocialActivities)
- [msdyn_purchaseorderbill_SocialActivities](#BKMK_msdyn_purchaseorderbill_SocialActivities)
- [msdyn_purchaseorderproduct_SocialActivities](#BKMK_msdyn_purchaseorderproduct_SocialActivities)
- [msdyn_purchaseorderreceipt_SocialActivities](#BKMK_msdyn_purchaseorderreceipt_SocialActivities)
- [msdyn_purchaseorderreceiptproduct_SocialActivities](#BKMK_msdyn_purchaseorderreceiptproduct_SocialActivities)
- [msdyn_purchaseordersubstatus_SocialActivities](#BKMK_msdyn_purchaseordersubstatus_SocialActivities)
- [msdyn_quotebookingincident_SocialActivities](#BKMK_msdyn_quotebookingincident_SocialActivities)
- [msdyn_quotebookingproduct_SocialActivities](#BKMK_msdyn_quotebookingproduct_SocialActivities)
- [msdyn_quotebookingservice_SocialActivities](#BKMK_msdyn_quotebookingservice_SocialActivities)
- [msdyn_quotebookingservicetask_SocialActivities](#BKMK_msdyn_quotebookingservicetask_SocialActivities)
- [msdyn_rma_SocialActivities](#BKMK_msdyn_rma_SocialActivities)
- [msdyn_rmaproduct_SocialActivities](#BKMK_msdyn_rmaproduct_SocialActivities)
- [msdyn_rmareceipt_SocialActivities](#BKMK_msdyn_rmareceipt_SocialActivities)
- [msdyn_rmareceiptproduct_SocialActivities](#BKMK_msdyn_rmareceiptproduct_SocialActivities)
- [msdyn_rmasubstatus_SocialActivities](#BKMK_msdyn_rmasubstatus_SocialActivities)
- [msdyn_rtv_SocialActivities](#BKMK_msdyn_rtv_SocialActivities)
- [msdyn_rtvproduct_SocialActivities](#BKMK_msdyn_rtvproduct_SocialActivities)
- [msdyn_rtvsubstatus_SocialActivities](#BKMK_msdyn_rtvsubstatus_SocialActivities)
- [msdyn_shipvia_SocialActivities](#BKMK_msdyn_shipvia_SocialActivities)
- [msdyn_timeoffrequest_SocialActivities](#BKMK_msdyn_timeoffrequest_SocialActivities)
- [msdyn_warehouse_SocialActivities](#BKMK_msdyn_warehouse_SocialActivities)
- [msdyn_workorder_SocialActivities](#BKMK_msdyn_workorder_SocialActivities)
- [msdyn_workordercharacteristic_SocialActivities](#BKMK_msdyn_workordercharacteristic_SocialActivities)
- [msdyn_workorderincident_SocialActivities](#BKMK_msdyn_workorderincident_SocialActivities)
- [msdyn_workorderproduct_SocialActivities](#BKMK_msdyn_workorderproduct_SocialActivities)
- [msdyn_workorderresourcerestriction_SocialActivities](#BKMK_msdyn_workorderresourcerestriction_SocialActivities)
- [msdyn_workorderservice_SocialActivities](#BKMK_msdyn_workorderservice_SocialActivities)
- [msdyn_workorderservicetask_SocialActivities](#BKMK_msdyn_workorderservicetask_SocialActivities)
- [KnowledgeBaseRecord_SocialActivities](#BKMK_KnowledgeBaseRecord_SocialActivities)
- [socialactivity_postauthoraccount_contacts](#BKMK_socialactivity_postauthoraccount_contacts)
- [KnowledgeArticle_SocialActivities](#BKMK_KnowledgeArticle_SocialActivities)
- [activity_pointer_socialactivity](#BKMK_activity_pointer_socialactivity)
- [SocialActivity_PostAuthorAccount_accounts](#BKMK_SocialActivity_PostAuthorAccount_accounts)
- [lk_socialactivity_createdby](#BKMK_lk_socialactivity_createdby)
- [Account_SocialActivities](#BKMK_Account_SocialActivities)
- [transactioncurrency_socialactivity](#BKMK_transactioncurrency_socialactivity)
- [sla_socialactivity](#BKMK_sla_socialactivity)
- [user_socialactivity](#BKMK_user_socialactivity)
- [business_unit_socialactivity](#BKMK_business_unit_socialactivity)
- [socialactivity_postauthor_contacts](#BKMK_socialactivity_postauthor_contacts)
- [team_socialactivity](#BKMK_team_socialactivity)
- [manualsla_socialactivity](#BKMK_manualsla_socialactivity)
- [SocialActivity_PostAuthor_accounts](#BKMK_SocialActivity_PostAuthor_accounts)
- [Socialprofile_SocialActivities](#BKMK_Socialprofile_SocialActivities)
- [AsyncOperation_SocialActivities](#BKMK_AsyncOperation_SocialActivities)
- [lk_socialactivity_modifiedby](#BKMK_lk_socialactivity_modifiedby)
- [lk_socialactivitybase_createdonbehalfby](#BKMK_lk_socialactivitybase_createdonbehalfby)
- [lk_socialactivitybase_modifiedonbehalfby](#BKMK_lk_socialactivitybase_modifiedonbehalfby)
- [Contact_SocialActivities](#BKMK_Contact_SocialActivities)


### <a name="BKMK_Lead_SocialActivities"></a> Lead_SocialActivities

See lead Entity [Lead_SocialActivities](lead.md#BKMK_Lead_SocialActivities) One-To-Many relationship.

### <a name="BKMK_bookableresourcebooking_SocialActivities"></a> bookableresourcebooking_SocialActivities

See bookableresourcebooking Entity [bookableresourcebooking_SocialActivities](bookableresourcebooking.md#BKMK_bookableresourcebooking_SocialActivities) One-To-Many relationship.

### <a name="BKMK_bookableresourcebookingheader_SocialActivities"></a> bookableresourcebookingheader_SocialActivities

See bookableresourcebookingheader Entity [bookableresourcebookingheader_SocialActivities](bookableresourcebookingheader.md#BKMK_bookableresourcebookingheader_SocialActivities) One-To-Many relationship.

### <a name="BKMK_BulkOperation_SocialActivity"></a> BulkOperation_SocialActivity

See bulkoperation Entity [BulkOperation_SocialActivity](bulkoperation.md#BKMK_BulkOperation_SocialActivity) One-To-Many relationship.

### <a name="BKMK_campaign_SocialActivities"></a> campaign_SocialActivities

See campaign Entity [campaign_SocialActivities](campaign.md#BKMK_campaign_SocialActivities) One-To-Many relationship.

### <a name="BKMK_campaignactivity_SocialActivities"></a> campaignactivity_SocialActivities

See campaignactivity Entity [campaignactivity_SocialActivities](campaignactivity.md#BKMK_campaignactivity_SocialActivities) One-To-Many relationship.

### <a name="BKMK_Contract_SocialActivities"></a> Contract_SocialActivities

See contract Entity [Contract_SocialActivities](contract.md#BKMK_Contract_SocialActivities) One-To-Many relationship.

### <a name="BKMK_entitlement_SocialActivities"></a> entitlement_SocialActivities

See entitlement Entity [entitlement_SocialActivities](entitlement.md#BKMK_entitlement_SocialActivities) One-To-Many relationship.

### <a name="BKMK_entitlementtemplate_SocialActivities"></a> entitlementtemplate_SocialActivities

See entitlementtemplate Entity [entitlementtemplate_SocialActivities](entitlementtemplate.md#BKMK_entitlementtemplate_SocialActivities) One-To-Many relationship.

### <a name="BKMK_Incident_SocialActivities"></a> Incident_SocialActivities

See incident Entity [Incident_SocialActivities](incident.md#BKMK_Incident_SocialActivities) One-To-Many relationship.

### <a name="BKMK_site_SocialActivities"></a> site_SocialActivities

See site Entity [site_SocialActivities](site.md#BKMK_site_SocialActivities) One-To-Many relationship.

### <a name="BKMK_service_socialactivities"></a> service_socialactivities

See service Entity [service_socialactivities](service.md#BKMK_service_socialactivities) One-To-Many relationship.

### <a name="BKMK_Invoice_SocialActivities"></a> Invoice_SocialActivities

See invoice Entity [Invoice_SocialActivities](invoice.md#BKMK_Invoice_SocialActivities) One-To-Many relationship.

### <a name="BKMK_Opportunity_SocialActivities"></a> Opportunity_SocialActivities

See opportunity Entity [Opportunity_SocialActivities](opportunity.md#BKMK_Opportunity_SocialActivities) One-To-Many relationship.

### <a name="BKMK_Quote_SocialActivities"></a> Quote_SocialActivities

See quote Entity [Quote_SocialActivities](quote.md#BKMK_Quote_SocialActivities) One-To-Many relationship.

### <a name="BKMK_SalesOrder_SocialActivities"></a> SalesOrder_SocialActivities

See salesorder Entity [SalesOrder_SocialActivities](salesorder.md#BKMK_SalesOrder_SocialActivities) One-To-Many relationship.

### <a name="BKMK_msdyn_postalbum_SocialActivities"></a> msdyn_postalbum_SocialActivities

See msdyn_postalbum Entity [msdyn_postalbum_SocialActivities](msdyn_postalbum.md#BKMK_msdyn_postalbum_SocialActivities) One-To-Many relationship.

### <a name="BKMK_msdyn_bookingalertstatus_SocialActivities"></a> msdyn_bookingalertstatus_SocialActivities

See msdyn_bookingalertstatus Entity [msdyn_bookingalertstatus_SocialActivities](msdyn_bookingalertstatus.md#BKMK_msdyn_bookingalertstatus_SocialActivities) One-To-Many relationship.

### <a name="BKMK_msdyn_bookingrule_SocialActivities"></a> msdyn_bookingrule_SocialActivities

See msdyn_bookingrule Entity [msdyn_bookingrule_SocialActivities](msdyn_bookingrule.md#BKMK_msdyn_bookingrule_SocialActivities) One-To-Many relationship.

### <a name="BKMK_msdyn_resourceterritory_SocialActivities"></a> msdyn_resourceterritory_SocialActivities

See msdyn_resourceterritory Entity [msdyn_resourceterritory_SocialActivities](msdyn_resourceterritory.md#BKMK_msdyn_resourceterritory_SocialActivities) One-To-Many relationship.

### <a name="BKMK_msdyn_systemuserschedulersetting_SocialActivities"></a> msdyn_systemuserschedulersetting_SocialActivities

See msdyn_systemuserschedulersetting Entity [msdyn_systemuserschedulersetting_SocialActivities](msdyn_systemuserschedulersetting.md#BKMK_msdyn_systemuserschedulersetting_SocialActivities) One-To-Many relationship.

### <a name="BKMK_msdyn_timegroup_SocialActivities"></a> msdyn_timegroup_SocialActivities

See msdyn_timegroup Entity [msdyn_timegroup_SocialActivities](msdyn_timegroup.md#BKMK_msdyn_timegroup_SocialActivities) One-To-Many relationship.

### <a name="BKMK_msdyn_timegroupdetail_SocialActivities"></a> msdyn_timegroupdetail_SocialActivities

See msdyn_timegroupdetail Entity [msdyn_timegroupdetail_SocialActivities](msdyn_timegroupdetail.md#BKMK_msdyn_timegroupdetail_SocialActivities) One-To-Many relationship.

### <a name="BKMK_msdyn_processnotes_SocialActivities"></a> msdyn_processnotes_SocialActivities

See msdyn_processnotes Entity [msdyn_processnotes_SocialActivities](msdyn_processnotes.md#BKMK_msdyn_processnotes_SocialActivities) One-To-Many relationship.

### <a name="BKMK_msdyn_projectteam_SocialActivities"></a> msdyn_projectteam_SocialActivities

See msdyn_projectteam Entity [msdyn_projectteam_SocialActivities](msdyn_projectteam.md#BKMK_msdyn_projectteam_SocialActivities) One-To-Many relationship.

### <a name="BKMK_msdyn_agreement_SocialActivities"></a> msdyn_agreement_SocialActivities

See msdyn_agreement Entity [msdyn_agreement_SocialActivities](msdyn_agreement.md#BKMK_msdyn_agreement_SocialActivities) One-To-Many relationship.

### <a name="BKMK_msdyn_agreementbookingdate_SocialActivities"></a> msdyn_agreementbookingdate_SocialActivities

See msdyn_agreementbookingdate Entity [msdyn_agreementbookingdate_SocialActivities](msdyn_agreementbookingdate.md#BKMK_msdyn_agreementbookingdate_SocialActivities) One-To-Many relationship.

### <a name="BKMK_msdyn_agreementbookingincident_SocialActivities"></a> msdyn_agreementbookingincident_SocialActivities

See msdyn_agreementbookingincident Entity [msdyn_agreementbookingincident_SocialActivities](msdyn_agreementbookingincident.md#BKMK_msdyn_agreementbookingincident_SocialActivities) One-To-Many relationship.

### <a name="BKMK_msdyn_agreementbookingproduct_SocialActivities"></a> msdyn_agreementbookingproduct_SocialActivities

See msdyn_agreementbookingproduct Entity [msdyn_agreementbookingproduct_SocialActivities](msdyn_agreementbookingproduct.md#BKMK_msdyn_agreementbookingproduct_SocialActivities) One-To-Many relationship.

### <a name="BKMK_msdyn_agreementbookingservice_SocialActivities"></a> msdyn_agreementbookingservice_SocialActivities

See msdyn_agreementbookingservice Entity [msdyn_agreementbookingservice_SocialActivities](msdyn_agreementbookingservice.md#BKMK_msdyn_agreementbookingservice_SocialActivities) One-To-Many relationship.

### <a name="BKMK_msdyn_agreementbookingservicetask_SocialActivities"></a> msdyn_agreementbookingservicetask_SocialActivities

See msdyn_agreementbookingservicetask Entity [msdyn_agreementbookingservicetask_SocialActivities](msdyn_agreementbookingservicetask.md#BKMK_msdyn_agreementbookingservicetask_SocialActivities) One-To-Many relationship.

### <a name="BKMK_msdyn_agreementbookingsetup_SocialActivities"></a> msdyn_agreementbookingsetup_SocialActivities

See msdyn_agreementbookingsetup Entity [msdyn_agreementbookingsetup_SocialActivities](msdyn_agreementbookingsetup.md#BKMK_msdyn_agreementbookingsetup_SocialActivities) One-To-Many relationship.

### <a name="BKMK_msdyn_agreementinvoicedate_SocialActivities"></a> msdyn_agreementinvoicedate_SocialActivities

See msdyn_agreementinvoicedate Entity [msdyn_agreementinvoicedate_SocialActivities](msdyn_agreementinvoicedate.md#BKMK_msdyn_agreementinvoicedate_SocialActivities) One-To-Many relationship.

### <a name="BKMK_msdyn_agreementinvoiceproduct_SocialActivities"></a> msdyn_agreementinvoiceproduct_SocialActivities

See msdyn_agreementinvoiceproduct Entity [msdyn_agreementinvoiceproduct_SocialActivities](msdyn_agreementinvoiceproduct.md#BKMK_msdyn_agreementinvoiceproduct_SocialActivities) One-To-Many relationship.

### <a name="BKMK_msdyn_agreementinvoicesetup_SocialActivities"></a> msdyn_agreementinvoicesetup_SocialActivities

See msdyn_agreementinvoicesetup Entity [msdyn_agreementinvoicesetup_SocialActivities](msdyn_agreementinvoicesetup.md#BKMK_msdyn_agreementinvoicesetup_SocialActivities) One-To-Many relationship.

### <a name="BKMK_msdyn_bookingtimestamp_SocialActivities"></a> msdyn_bookingtimestamp_SocialActivities

See msdyn_bookingtimestamp Entity [msdyn_bookingtimestamp_SocialActivities](msdyn_bookingtimestamp.md#BKMK_msdyn_bookingtimestamp_SocialActivities) One-To-Many relationship.

### <a name="BKMK_msdyn_customerasset_SocialActivities"></a> msdyn_customerasset_SocialActivities

See msdyn_customerasset Entity [msdyn_customerasset_SocialActivities](msdyn_customerasset.md#BKMK_msdyn_customerasset_SocialActivities) One-To-Many relationship.

### <a name="BKMK_msdyn_fieldservicesetting_SocialActivities"></a> msdyn_fieldservicesetting_SocialActivities

See msdyn_fieldservicesetting Entity [msdyn_fieldservicesetting_SocialActivities](msdyn_fieldservicesetting.md#BKMK_msdyn_fieldservicesetting_SocialActivities) One-To-Many relationship.

### <a name="BKMK_msdyn_incidenttypecharacteristic_SocialActivities"></a> msdyn_incidenttypecharacteristic_SocialActivities

See msdyn_incidenttypecharacteristic Entity [msdyn_incidenttypecharacteristic_SocialActivities](msdyn_incidenttypecharacteristic.md#BKMK_msdyn_incidenttypecharacteristic_SocialActivities) One-To-Many relationship.

### <a name="BKMK_msdyn_incidenttypeproduct_SocialActivities"></a> msdyn_incidenttypeproduct_SocialActivities

See msdyn_incidenttypeproduct Entity [msdyn_incidenttypeproduct_SocialActivities](msdyn_incidenttypeproduct.md#BKMK_msdyn_incidenttypeproduct_SocialActivities) One-To-Many relationship.

### <a name="BKMK_msdyn_incidenttypeservice_SocialActivities"></a> msdyn_incidenttypeservice_SocialActivities

See msdyn_incidenttypeservice Entity [msdyn_incidenttypeservice_SocialActivities](msdyn_incidenttypeservice.md#BKMK_msdyn_incidenttypeservice_SocialActivities) One-To-Many relationship.

### <a name="BKMK_msdyn_inventoryadjustment_SocialActivities"></a> msdyn_inventoryadjustment_SocialActivities

See msdyn_inventoryadjustment Entity [msdyn_inventoryadjustment_SocialActivities](msdyn_inventoryadjustment.md#BKMK_msdyn_inventoryadjustment_SocialActivities) One-To-Many relationship.

### <a name="BKMK_msdyn_inventoryadjustmentproduct_SocialActivities"></a> msdyn_inventoryadjustmentproduct_SocialActivities

See msdyn_inventoryadjustmentproduct Entity [msdyn_inventoryadjustmentproduct_SocialActivities](msdyn_inventoryadjustmentproduct.md#BKMK_msdyn_inventoryadjustmentproduct_SocialActivities) One-To-Many relationship.

### <a name="BKMK_msdyn_inventoryjournal_SocialActivities"></a> msdyn_inventoryjournal_SocialActivities

See msdyn_inventoryjournal Entity [msdyn_inventoryjournal_SocialActivities](msdyn_inventoryjournal.md#BKMK_msdyn_inventoryjournal_SocialActivities) One-To-Many relationship.

### <a name="BKMK_msdyn_inventorytransfer_SocialActivities"></a> msdyn_inventorytransfer_SocialActivities

See msdyn_inventorytransfer Entity [msdyn_inventorytransfer_SocialActivities](msdyn_inventorytransfer.md#BKMK_msdyn_inventorytransfer_SocialActivities) One-To-Many relationship.

### <a name="BKMK_msdyn_payment_SocialActivities"></a> msdyn_payment_SocialActivities

See msdyn_payment Entity [msdyn_payment_SocialActivities](msdyn_payment.md#BKMK_msdyn_payment_SocialActivities) One-To-Many relationship.

### <a name="BKMK_msdyn_paymentdetail_SocialActivities"></a> msdyn_paymentdetail_SocialActivities

See msdyn_paymentdetail Entity [msdyn_paymentdetail_SocialActivities](msdyn_paymentdetail.md#BKMK_msdyn_paymentdetail_SocialActivities) One-To-Many relationship.

### <a name="BKMK_msdyn_paymentmethod_SocialActivities"></a> msdyn_paymentmethod_SocialActivities

See msdyn_paymentmethod Entity [msdyn_paymentmethod_SocialActivities](msdyn_paymentmethod.md#BKMK_msdyn_paymentmethod_SocialActivities) One-To-Many relationship.

### <a name="BKMK_msdyn_paymentterm_SocialActivities"></a> msdyn_paymentterm_SocialActivities

See msdyn_paymentterm Entity [msdyn_paymentterm_SocialActivities](msdyn_paymentterm.md#BKMK_msdyn_paymentterm_SocialActivities) One-To-Many relationship.

### <a name="BKMK_msdyn_postalcode_SocialActivities"></a> msdyn_postalcode_SocialActivities

See msdyn_postalcode Entity [msdyn_postalcode_SocialActivities](msdyn_postalcode.md#BKMK_msdyn_postalcode_SocialActivities) One-To-Many relationship.

### <a name="BKMK_msdyn_productinventory_SocialActivities"></a> msdyn_productinventory_SocialActivities

See msdyn_productinventory Entity [msdyn_productinventory_SocialActivities](msdyn_productinventory.md#BKMK_msdyn_productinventory_SocialActivities) One-To-Many relationship.

### <a name="BKMK_msdyn_purchaseorder_SocialActivities"></a> msdyn_purchaseorder_SocialActivities

See msdyn_purchaseorder Entity [msdyn_purchaseorder_SocialActivities](msdyn_purchaseorder.md#BKMK_msdyn_purchaseorder_SocialActivities) One-To-Many relationship.

### <a name="BKMK_msdyn_purchaseorderbill_SocialActivities"></a> msdyn_purchaseorderbill_SocialActivities

See msdyn_purchaseorderbill Entity [msdyn_purchaseorderbill_SocialActivities](msdyn_purchaseorderbill.md#BKMK_msdyn_purchaseorderbill_SocialActivities) One-To-Many relationship.

### <a name="BKMK_msdyn_purchaseorderproduct_SocialActivities"></a> msdyn_purchaseorderproduct_SocialActivities

See msdyn_purchaseorderproduct Entity [msdyn_purchaseorderproduct_SocialActivities](msdyn_purchaseorderproduct.md#BKMK_msdyn_purchaseorderproduct_SocialActivities) One-To-Many relationship.

### <a name="BKMK_msdyn_purchaseorderreceipt_SocialActivities"></a> msdyn_purchaseorderreceipt_SocialActivities

See msdyn_purchaseorderreceipt Entity [msdyn_purchaseorderreceipt_SocialActivities](msdyn_purchaseorderreceipt.md#BKMK_msdyn_purchaseorderreceipt_SocialActivities) One-To-Many relationship.

### <a name="BKMK_msdyn_purchaseorderreceiptproduct_SocialActivities"></a> msdyn_purchaseorderreceiptproduct_SocialActivities

See msdyn_purchaseorderreceiptproduct Entity [msdyn_purchaseorderreceiptproduct_SocialActivities](msdyn_purchaseorderreceiptproduct.md#BKMK_msdyn_purchaseorderreceiptproduct_SocialActivities) One-To-Many relationship.

### <a name="BKMK_msdyn_purchaseordersubstatus_SocialActivities"></a> msdyn_purchaseordersubstatus_SocialActivities

See msdyn_purchaseordersubstatus Entity [msdyn_purchaseordersubstatus_SocialActivities](msdyn_purchaseordersubstatus.md#BKMK_msdyn_purchaseordersubstatus_SocialActivities) One-To-Many relationship.

### <a name="BKMK_msdyn_quotebookingincident_SocialActivities"></a> msdyn_quotebookingincident_SocialActivities

See msdyn_quotebookingincident Entity [msdyn_quotebookingincident_SocialActivities](msdyn_quotebookingincident.md#BKMK_msdyn_quotebookingincident_SocialActivities) One-To-Many relationship.

### <a name="BKMK_msdyn_quotebookingproduct_SocialActivities"></a> msdyn_quotebookingproduct_SocialActivities

See msdyn_quotebookingproduct Entity [msdyn_quotebookingproduct_SocialActivities](msdyn_quotebookingproduct.md#BKMK_msdyn_quotebookingproduct_SocialActivities) One-To-Many relationship.

### <a name="BKMK_msdyn_quotebookingservice_SocialActivities"></a> msdyn_quotebookingservice_SocialActivities

See msdyn_quotebookingservice Entity [msdyn_quotebookingservice_SocialActivities](msdyn_quotebookingservice.md#BKMK_msdyn_quotebookingservice_SocialActivities) One-To-Many relationship.

### <a name="BKMK_msdyn_quotebookingservicetask_SocialActivities"></a> msdyn_quotebookingservicetask_SocialActivities

See msdyn_quotebookingservicetask Entity [msdyn_quotebookingservicetask_SocialActivities](msdyn_quotebookingservicetask.md#BKMK_msdyn_quotebookingservicetask_SocialActivities) One-To-Many relationship.

### <a name="BKMK_msdyn_rma_SocialActivities"></a> msdyn_rma_SocialActivities

See msdyn_rma Entity [msdyn_rma_SocialActivities](msdyn_rma.md#BKMK_msdyn_rma_SocialActivities) One-To-Many relationship.

### <a name="BKMK_msdyn_rmaproduct_SocialActivities"></a> msdyn_rmaproduct_SocialActivities

See msdyn_rmaproduct Entity [msdyn_rmaproduct_SocialActivities](msdyn_rmaproduct.md#BKMK_msdyn_rmaproduct_SocialActivities) One-To-Many relationship.

### <a name="BKMK_msdyn_rmareceipt_SocialActivities"></a> msdyn_rmareceipt_SocialActivities

See msdyn_rmareceipt Entity [msdyn_rmareceipt_SocialActivities](msdyn_rmareceipt.md#BKMK_msdyn_rmareceipt_SocialActivities) One-To-Many relationship.

### <a name="BKMK_msdyn_rmareceiptproduct_SocialActivities"></a> msdyn_rmareceiptproduct_SocialActivities

See msdyn_rmareceiptproduct Entity [msdyn_rmareceiptproduct_SocialActivities](msdyn_rmareceiptproduct.md#BKMK_msdyn_rmareceiptproduct_SocialActivities) One-To-Many relationship.

### <a name="BKMK_msdyn_rmasubstatus_SocialActivities"></a> msdyn_rmasubstatus_SocialActivities

See msdyn_rmasubstatus Entity [msdyn_rmasubstatus_SocialActivities](msdyn_rmasubstatus.md#BKMK_msdyn_rmasubstatus_SocialActivities) One-To-Many relationship.

### <a name="BKMK_msdyn_rtv_SocialActivities"></a> msdyn_rtv_SocialActivities

See msdyn_rtv Entity [msdyn_rtv_SocialActivities](msdyn_rtv.md#BKMK_msdyn_rtv_SocialActivities) One-To-Many relationship.

### <a name="BKMK_msdyn_rtvproduct_SocialActivities"></a> msdyn_rtvproduct_SocialActivities

See msdyn_rtvproduct Entity [msdyn_rtvproduct_SocialActivities](msdyn_rtvproduct.md#BKMK_msdyn_rtvproduct_SocialActivities) One-To-Many relationship.

### <a name="BKMK_msdyn_rtvsubstatus_SocialActivities"></a> msdyn_rtvsubstatus_SocialActivities

See msdyn_rtvsubstatus Entity [msdyn_rtvsubstatus_SocialActivities](msdyn_rtvsubstatus.md#BKMK_msdyn_rtvsubstatus_SocialActivities) One-To-Many relationship.

### <a name="BKMK_msdyn_shipvia_SocialActivities"></a> msdyn_shipvia_SocialActivities

See msdyn_shipvia Entity [msdyn_shipvia_SocialActivities](msdyn_shipvia.md#BKMK_msdyn_shipvia_SocialActivities) One-To-Many relationship.

### <a name="BKMK_msdyn_timeoffrequest_SocialActivities"></a> msdyn_timeoffrequest_SocialActivities

See msdyn_timeoffrequest Entity [msdyn_timeoffrequest_SocialActivities](msdyn_timeoffrequest.md#BKMK_msdyn_timeoffrequest_SocialActivities) One-To-Many relationship.

### <a name="BKMK_msdyn_warehouse_SocialActivities"></a> msdyn_warehouse_SocialActivities

See msdyn_warehouse Entity [msdyn_warehouse_SocialActivities](msdyn_warehouse.md#BKMK_msdyn_warehouse_SocialActivities) One-To-Many relationship.

### <a name="BKMK_msdyn_workorder_SocialActivities"></a> msdyn_workorder_SocialActivities

See msdyn_workorder Entity [msdyn_workorder_SocialActivities](msdyn_workorder.md#BKMK_msdyn_workorder_SocialActivities) One-To-Many relationship.

### <a name="BKMK_msdyn_workordercharacteristic_SocialActivities"></a> msdyn_workordercharacteristic_SocialActivities

See msdyn_workordercharacteristic Entity [msdyn_workordercharacteristic_SocialActivities](msdyn_workordercharacteristic.md#BKMK_msdyn_workordercharacteristic_SocialActivities) One-To-Many relationship.

### <a name="BKMK_msdyn_workorderincident_SocialActivities"></a> msdyn_workorderincident_SocialActivities

See msdyn_workorderincident Entity [msdyn_workorderincident_SocialActivities](msdyn_workorderincident.md#BKMK_msdyn_workorderincident_SocialActivities) One-To-Many relationship.

### <a name="BKMK_msdyn_workorderproduct_SocialActivities"></a> msdyn_workorderproduct_SocialActivities

See msdyn_workorderproduct Entity [msdyn_workorderproduct_SocialActivities](msdyn_workorderproduct.md#BKMK_msdyn_workorderproduct_SocialActivities) One-To-Many relationship.

### <a name="BKMK_msdyn_workorderresourcerestriction_SocialActivities"></a> msdyn_workorderresourcerestriction_SocialActivities

See msdyn_workorderresourcerestriction Entity [msdyn_workorderresourcerestriction_SocialActivities](msdyn_workorderresourcerestriction.md#BKMK_msdyn_workorderresourcerestriction_SocialActivities) One-To-Many relationship.

### <a name="BKMK_msdyn_workorderservice_SocialActivities"></a> msdyn_workorderservice_SocialActivities

See msdyn_workorderservice Entity [msdyn_workorderservice_SocialActivities](msdyn_workorderservice.md#BKMK_msdyn_workorderservice_SocialActivities) One-To-Many relationship.

### <a name="BKMK_msdyn_workorderservicetask_SocialActivities"></a> msdyn_workorderservicetask_SocialActivities

See msdyn_workorderservicetask Entity [msdyn_workorderservicetask_SocialActivities](msdyn_workorderservicetask.md#BKMK_msdyn_workorderservicetask_SocialActivities) One-To-Many relationship.

### <a name="BKMK_KnowledgeBaseRecord_SocialActivities"></a> KnowledgeBaseRecord_SocialActivities

See knowledgebaserecord Entity [KnowledgeBaseRecord_SocialActivities](knowledgebaserecord.md#BKMK_KnowledgeBaseRecord_SocialActivities) One-To-Many relationship.

### <a name="BKMK_socialactivity_postauthoraccount_contacts"></a> socialactivity_postauthoraccount_contacts

See contact Entity [socialactivity_postauthoraccount_contacts](contact.md#BKMK_socialactivity_postauthoraccount_contacts) One-To-Many relationship.

### <a name="BKMK_KnowledgeArticle_SocialActivities"></a> KnowledgeArticle_SocialActivities

See knowledgearticle Entity [KnowledgeArticle_SocialActivities](knowledgearticle.md#BKMK_KnowledgeArticle_SocialActivities) One-To-Many relationship.

### <a name="BKMK_activity_pointer_socialactivity"></a> activity_pointer_socialactivity

See activitypointer Entity [activity_pointer_socialactivity](activitypointer.md#BKMK_activity_pointer_socialactivity) One-To-Many relationship.

### <a name="BKMK_SocialActivity_PostAuthorAccount_accounts"></a> SocialActivity_PostAuthorAccount_accounts

See account Entity [SocialActivity_PostAuthorAccount_accounts](account.md#BKMK_SocialActivity_PostAuthorAccount_accounts) One-To-Many relationship.

### <a name="BKMK_lk_socialactivity_createdby"></a> lk_socialactivity_createdby

See systemuser Entity [lk_socialactivity_createdby](systemuser.md#BKMK_lk_socialactivity_createdby) One-To-Many relationship.

### <a name="BKMK_Account_SocialActivities"></a> Account_SocialActivities

See account Entity [Account_SocialActivities](account.md#BKMK_Account_SocialActivities) One-To-Many relationship.

### <a name="BKMK_transactioncurrency_socialactivity"></a> transactioncurrency_socialactivity

See transactioncurrency Entity [transactioncurrency_socialactivity](transactioncurrency.md#BKMK_transactioncurrency_socialactivity) One-To-Many relationship.

### <a name="BKMK_sla_socialactivity"></a> sla_socialactivity

See sla Entity [sla_socialactivity](sla.md#BKMK_sla_socialactivity) One-To-Many relationship.

### <a name="BKMK_user_socialactivity"></a> user_socialactivity

See systemuser Entity [user_socialactivity](systemuser.md#BKMK_user_socialactivity) One-To-Many relationship.

### <a name="BKMK_business_unit_socialactivity"></a> business_unit_socialactivity

See businessunit Entity [business_unit_socialactivity](businessunit.md#BKMK_business_unit_socialactivity) One-To-Many relationship.

### <a name="BKMK_socialactivity_postauthor_contacts"></a> socialactivity_postauthor_contacts

See contact Entity [socialactivity_postauthor_contacts](contact.md#BKMK_socialactivity_postauthor_contacts) One-To-Many relationship.

### <a name="BKMK_team_socialactivity"></a> team_socialactivity

See team Entity [team_socialactivity](team.md#BKMK_team_socialactivity) One-To-Many relationship.

### <a name="BKMK_manualsla_socialactivity"></a> manualsla_socialactivity

See sla Entity [manualsla_socialactivity](sla.md#BKMK_manualsla_socialactivity) One-To-Many relationship.

### <a name="BKMK_SocialActivity_PostAuthor_accounts"></a> SocialActivity_PostAuthor_accounts

See account Entity [SocialActivity_PostAuthor_accounts](account.md#BKMK_SocialActivity_PostAuthor_accounts) One-To-Many relationship.

### <a name="BKMK_Socialprofile_SocialActivities"></a> Socialprofile_SocialActivities

See socialprofile Entity [Socialprofile_SocialActivities](socialprofile.md#BKMK_Socialprofile_SocialActivities) One-To-Many relationship.

### <a name="BKMK_AsyncOperation_SocialActivities"></a> AsyncOperation_SocialActivities

See asyncoperation Entity [AsyncOperation_SocialActivities](asyncoperation.md#BKMK_AsyncOperation_SocialActivities) One-To-Many relationship.

### <a name="BKMK_lk_socialactivity_modifiedby"></a> lk_socialactivity_modifiedby

See systemuser Entity [lk_socialactivity_modifiedby](systemuser.md#BKMK_lk_socialactivity_modifiedby) One-To-Many relationship.

### <a name="BKMK_lk_socialactivitybase_createdonbehalfby"></a> lk_socialactivitybase_createdonbehalfby

See systemuser Entity [lk_socialactivitybase_createdonbehalfby](systemuser.md#BKMK_lk_socialactivitybase_createdonbehalfby) One-To-Many relationship.

### <a name="BKMK_lk_socialactivitybase_modifiedonbehalfby"></a> lk_socialactivitybase_modifiedonbehalfby

See systemuser Entity [lk_socialactivitybase_modifiedonbehalfby](systemuser.md#BKMK_lk_socialactivitybase_modifiedonbehalfby) One-To-Many relationship.

### <a name="BKMK_Contact_SocialActivities"></a> Contact_SocialActivities

See contact Entity [Contact_SocialActivities](contact.md#BKMK_Contact_SocialActivities) One-To-Many relationship.

## See also

[About the Entity Reference](../about-entity-reference.md)<br />
[Programming reference for Dynamics 365 Customer Engagement](../programming-reference.md)<br />
[Web API Reference](/dynamics365/customer-engagement/web-api/about)<br />
<xref href="Microsoft.Dynamics.CRM.socialactivity?text=socialactivity EntityType" />