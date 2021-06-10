---
title: "Fax Entity Reference (Dynamics 365 Customer Engagement)| MicrosoftDocs"
description: "Includes schema information and supported messages for the Fax entity."
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
# Fax Entity Reference

Activity that tracks call outcome and number of pages for a fax and optionally stores an electronic copy of the document.


## Messages

|Message|Web API Operation|SDK Assembly|
|-|-|-|
|Assign|PATCH [*org URI*]/api/data/v9.0/faxes(*activityid*)<br />[Update](/powerapps/developer/common-data-service/webapi/update-delete-entities-using-web-api#basic-update) `ownerid` property.|<xref:Microsoft.Crm.Sdk.Messages.AssignRequest>|
|Create|POST [*org URI*]/api/data/v9.0/faxes<br />See [Create](/powerapps/developer/common-data-service/webapi/create-entity-web-api)|<xref:Microsoft.Xrm.Sdk.Messages.CreateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Create*>|
|Delete|DELETE [*org URI*]/api/data/v9.0/faxes(*activityid*)<br />See [Delete](/powerapps/developer/common-data-service/webapi/update-delete-entities-using-web-api#basic-delete)|<xref:Microsoft.Xrm.Sdk.Messages.DeleteRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Delete*>|
|GrantAccess|<xref href="Microsoft.Dynamics.CRM.GrantAccess?text=GrantAccess Action" />|<xref:Microsoft.Crm.Sdk.Messages.GrantAccessRequest>|
|ModifyAccess|<xref href="Microsoft.Dynamics.CRM.ModifyAccess?text=ModifyAccess Action" />|<xref:Microsoft.Crm.Sdk.Messages.ModifyAccessRequest>|
|Retrieve|GET [*org URI*]/api/data/v9.0/faxes(*activityid*)<br />See [Retrieve](/powerapps/developer/common-data-service/webapi/retrieve-entity-using-web-api)|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Retrieve*>|
|RetrieveMultiple|GET [*org URI*]/api/data/v9.0/faxes<br />See [Query Data](/powerapps/developer/common-data-service/webapi/query-data-web-api)|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveMultipleRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.RetrieveMultiple*>|
|RetrievePrincipalAccess|<xref href="Microsoft.Dynamics.CRM.RetrievePrincipalAccess?text=RetrievePrincipalAccess Function" />|<xref:Microsoft.Crm.Sdk.Messages.RetrievePrincipalAccessRequest>|
|RetrieveSharedPrincipalsAndAccess|<xref href="Microsoft.Dynamics.CRM.RetrieveSharedPrincipalsAndAccess?text=RetrieveSharedPrincipalsAndAccess Function" />|<xref:Microsoft.Crm.Sdk.Messages.RetrieveSharedPrincipalsAndAccessRequest>|
|RevokeAccess|<xref href="Microsoft.Dynamics.CRM.RevokeAccess?text=RevokeAccess Action" />|<xref:Microsoft.Crm.Sdk.Messages.RevokeAccessRequest>|
|SendEmail|<xref href="Microsoft.Dynamics.CRM.SendEmail?text=SendEmail Action" />|<xref:Microsoft.Crm.Sdk.Messages.SendEmailRequest>|
|SendFax|<xref href="Microsoft.Dynamics.CRM.SendFax?text=SendFax Action" />|<xref:Microsoft.Crm.Sdk.Messages.SendFaxRequest>|
|SendTemplate|<xref href="Microsoft.Dynamics.CRM.SendTemplate?text=SendTemplate Action" />|<xref:Microsoft.Crm.Sdk.Messages.SendTemplateRequest>|
|SetState|PATCH [*org URI*]/api/data/v9.0/faxes(*activityid*)<br />[Update](/powerapps/developer/common-data-service/webapi/update-delete-entities-using-web-api#basic-update) `statecode` and `statuscode` properties.|<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|
|Update|PATCH [*org URI*]/api/data/v9.0/faxes(*activityid*)<br />See [Update](/powerapps/developer/common-data-service/webapi/update-delete-entities-using-web-api#basic-update)|<xref:Microsoft.Xrm.Sdk.Messages.UpdateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Update*>|

## Entity Properties

|Property|Value|
|--------|-----|
|CollectionSchemaName|Faxes|
|DisplayCollectionName|Faxes|
|DisplayName|Fax|
|EntitySetName|faxes|
|IsBPFEntity|False|
|LogicalCollectionName|faxes|
|LogicalName|fax|
|OwnershipType|UserOwned|
|PrimaryIdAttribute|activityid|
|PrimaryNameAttribute|subject|
|SchemaName|Fax|

<a name="writable-attributes"></a>

## Writable attributes

These attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [ActivityId](#BKMK_ActivityId)
- [ActualDurationMinutes](#BKMK_ActualDurationMinutes)
- [ActualEnd](#BKMK_ActualEnd)
- [ActualStart](#BKMK_ActualStart)
- [BillingCode](#BKMK_BillingCode)
- [Category](#BKMK_Category)
- [CoverPageName](#BKMK_CoverPageName)
- [Description](#BKMK_Description)
- [DirectionCode](#BKMK_DirectionCode)
- [FaxNumber](#BKMK_FaxNumber)
- [from](#BKMK_from)
- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [IsBilled](#BKMK_IsBilled)
- [IsWorkflowCreated](#BKMK_IsWorkflowCreated)
- [LastOnHoldTime](#BKMK_LastOnHoldTime)
- [NumberOfPages](#BKMK_NumberOfPages)
- [OverriddenCreatedOn](#BKMK_OverriddenCreatedOn)
- [OwnerId](#BKMK_OwnerId)
- [OwnerIdType](#BKMK_OwnerIdType)
- [PriorityCode](#BKMK_PriorityCode)
- [ProcessId](#BKMK_ProcessId)
- [RegardingObjectId](#BKMK_RegardingObjectId)
- [RegardingObjectTypeCode](#BKMK_RegardingObjectTypeCode)
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
- [to](#BKMK_to)
- [TransactionCurrencyId](#BKMK_TransactionCurrencyId)
- [TraversedPath](#BKMK_TraversedPath)
- [Tsid](#BKMK_Tsid)
- [UTCConversionTimeZoneCode](#BKMK_UTCConversionTimeZoneCode)


### <a name="BKMK_ActivityId"></a> ActivityId

|Property|Value|
|--------|-----|
|Description|Unique identifier of the fax activity.|
|DisplayName|Fax|
|IsValidForForm|False|
|IsValidForRead|True|
|IsValidForUpdate|False|
|LogicalName|activityid|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|


### <a name="BKMK_ActualDurationMinutes"></a> ActualDurationMinutes

|Property|Value|
|--------|-----|
|Description|Type the number of minutes spent creating and sending the fax. The duration is used in reporting.|
|DisplayName|Duration|
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
|Description|Enter the actual end date and time of the fax. By default, it displays the date and time when the activity was completed or canceled, but can be edited to capture the actual time to create and send the fax.|
|DisplayName|Actual End|
|Format|DateOnly|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|actualend|
|RequiredLevel|None|
|Type|DateTime|


### <a name="BKMK_ActualStart"></a> ActualStart

|Property|Value|
|--------|-----|
|DateTimeBehavior|UserLocal|
|Description|Enter the actual start date and time for the fax. By default, it displays the date and time when the activity was created, but can be edited to capture the actual time to create and send the fax.|
|DisplayName|Actual Start|
|Format|DateOnly|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|actualstart|
|RequiredLevel|None|
|Type|DateTime|


### <a name="BKMK_BillingCode"></a> BillingCode

|Property|Value|
|--------|-----|
|Description|Type the billing code for the fax to make sure the fax is charged to the correct sender or customer account.|
|DisplayName|Billing Code|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|billingcode|
|MaxLength|50|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_Category"></a> Category

|Property|Value|
|--------|-----|
|Description|Type a category to identify the fax type, such as sales offer or press release, to tie the fax to a business group or function.|
|DisplayName|Category|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|category|
|MaxLength|250|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_CoverPageName"></a> CoverPageName

|Property|Value|
|--------|-----|
|Description|Type the name of the cover page to use when sending the fax.|
|DisplayName|Cover Page Name|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|coverpagename|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_Description"></a> Description

|Property|Value|
|--------|-----|
|Description|Type additional information to describe the fax, such as the primary message or the products and services featured.|
|DisplayName|Description|
|Format|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|description|
|MaxLength|2000|
|RequiredLevel|None|
|Type|Memo|


### <a name="BKMK_DirectionCode"></a> DirectionCode

|Property|Value|
|--------|-----|
|Description|Select the direction of the fax as incoming or outbound.|
|DisplayName|Direction|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|directioncode|
|RequiredLevel|None|
|Type|Boolean|

#### DirectionCode Options

|Value|Label|
|-----|-----|
|1|Outgoing|
|0|Incoming|

**DefaultValue**: True



### <a name="BKMK_FaxNumber"></a> FaxNumber

|Property|Value|
|--------|-----|
|Description|Type the recipient's fax number.|
|DisplayName|Fax Number|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|faxnumber|
|MaxLength|200|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_from"></a> from

|Property|Value|
|--------|-----|
|Description|Enter the account, contact, lead, queue, or user who sent the fax.|
|DisplayName|From|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|from|
|RequiredLevel|None|
|Targets|account,contact,lead,queue,systemuser|
|Type|PartyList|


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


### <a name="BKMK_IsBilled"></a> IsBilled

|Property|Value|
|--------|-----|
|Description|Information regarding whether the fax activity was billed as part of resolving a case.|
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



### <a name="BKMK_IsWorkflowCreated"></a> IsWorkflowCreated

|Property|Value|
|--------|-----|
|Description|Indication of whether the fax activity was created by a workflow rule.|
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


### <a name="BKMK_NumberOfPages"></a> NumberOfPages

|Property|Value|
|--------|-----|
|Description|Type the number of pages included in the fax.|
|DisplayName|Number of Pages|
|Format|None|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|numberofpages|
|MaxValue|1000000000|
|MinValue|0|
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
|Description|Choose the record that the fax relates to.|
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


### <a name="BKMK_ScheduledEnd"></a> ScheduledEnd

|Property|Value|
|--------|-----|
|DateTimeBehavior|UserLocal|
|Description|Enter the expected due date and time.|
|DisplayName|Due Date|
|Format|DateAndTime|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|scheduledend|
|RequiredLevel|None|
|Type|DateTime|


### <a name="BKMK_ScheduledStart"></a> ScheduledStart

|Property|Value|
|--------|-----|
|DateTimeBehavior|UserLocal|
|Description|Enter the expected due date and time.|
|DisplayName|Start Date|
|Format|DateAndTime|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|scheduledstart|
|RequiredLevel|None|
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
|Description|Choose the service level agreement (SLA) that you want to apply to the fax record.|
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
|Description|Shows whether the fax activity is open, completed, or canceled. Completed and canceled fax activities are read-only and can't be edited.|
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
|2|Canceled|5|Canceled|



### <a name="BKMK_StatusCode"></a> StatusCode

|Property|Value|
|--------|-----|
|Description|Select the fax's status.|
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
|3|Sent|1|
|4|Received|1|
|5|Canceled|2|



### <a name="BKMK_Subcategory"></a> Subcategory

|Property|Value|
|--------|-----|
|Description|Type a subcategory to identify the fax type to relate the activity to a specific product, sales region, business group, or other function.|
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
|Description|Type a short description about the objective or primary topic of the fax.|
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


### <a name="BKMK_to"></a> to

|Property|Value|
|--------|-----|
|Description|Enter the account, contact, lead, queue, or user recipients for the fax.|
|DisplayName|To|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|to|
|RequiredLevel|None|
|Targets|account,contact,lead,queue,systemuser|
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


### <a name="BKMK_Tsid"></a> Tsid

|Property|Value|
|--------|-----|
|Description|Type the Transmitting Subscriber ID (TSID) associated with a send action. This is typically a combination of the recipient's fax or phone number and company name.|
|DisplayName|Transmit. Station Id|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|tsid|
|MaxLength|20|
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
- [ExchangeRate](#BKMK_ExchangeRate)
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
- [RegardingObjectIdName](#BKMK_RegardingObjectIdName)
- [RegardingObjectIdYomiName](#BKMK_RegardingObjectIdYomiName)
- [ScheduledDurationMinutes](#BKMK_ScheduledDurationMinutes)
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
|Description|Unique identifier of the business unit that owns the fax activity.|
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
|Description|Unique identifier of the team that owns the fax activity.|
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
|Description|Unique identifier of the user that owns the fax activity.|
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


### <a name="BKMK_ScheduledDurationMinutes"></a> ScheduledDurationMinutes

|Property|Value|
|--------|-----|
|Description|Shows the expected duration of the fax activity, in minutes.|
|DisplayName|Scheduled Duration|
|Format|Duration|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|scheduleddurationminutes|
|MaxValue|2147483647|
|MinValue|0|
|RequiredLevel|None|
|Type|Integer|


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
|Description|Last SLA that was applied to this fax. This field is for internal use only.|
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
|Description|Version number of the fax.|
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

- [fax_campaignresponse](#BKMK_fax_campaignresponse)
- [fax_principalobjectattributeaccess](#BKMK_fax_principalobjectattributeaccess)
- [Fax_AsyncOperations](#BKMK_Fax_AsyncOperations)
- [slakpiinstance_fax](#BKMK_slakpiinstance_fax)
- [Fax_DuplicateBaseRecord](#BKMK_Fax_DuplicateBaseRecord)
- [Fax_BulkDeleteFailures](#BKMK_Fax_BulkDeleteFailures)
- [fax_activity_parties](#BKMK_fax_activity_parties)
- [fax_connections2](#BKMK_fax_connections2)
- [Fax_SyncErrors](#BKMK_Fax_SyncErrors)
- [Fax_DuplicateMatchingRecord](#BKMK_Fax_DuplicateMatchingRecord)
- [Fax_Annotation](#BKMK_Fax_Annotation)
- [Fax_ProcessSessions](#BKMK_Fax_ProcessSessions)
- [fax_connections1](#BKMK_fax_connections1)
- [Fax_QueueItem](#BKMK_Fax_QueueItem)
- [fax_actioncard](#BKMK_fax_actioncard)


### <a name="BKMK_fax_campaignresponse"></a> fax_campaignresponse

**Added by**: Marketing Solution

Same as campaignresponse entity [fax_campaignresponse](campaignresponse.md#BKMK_fax_campaignresponse) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|campaignresponse|
|ReferencingAttribute|originatingactivityid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|fax_campaignresponse|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_fax_principalobjectattributeaccess"></a> fax_principalobjectattributeaccess

Same as principalobjectattributeaccess entity [fax_principalobjectattributeaccess](principalobjectattributeaccess.md#BKMK_fax_principalobjectattributeaccess) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|principalobjectattributeaccess|
|ReferencingAttribute|objectid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|fax_principalobjectattributeaccess|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_Fax_AsyncOperations"></a> Fax_AsyncOperations

Same as asyncoperation entity [Fax_AsyncOperations](asyncoperation.md#BKMK_Fax_AsyncOperations) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|asyncoperation|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|Fax_AsyncOperations|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_slakpiinstance_fax"></a> slakpiinstance_fax

Same as slakpiinstance entity [slakpiinstance_fax](slakpiinstance.md#BKMK_slakpiinstance_fax) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|slakpiinstance|
|ReferencingAttribute|regarding|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|slakpiinstance_fax|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_Fax_DuplicateBaseRecord"></a> Fax_DuplicateBaseRecord

Same as duplicaterecord entity [Fax_DuplicateBaseRecord](duplicaterecord.md#BKMK_Fax_DuplicateBaseRecord) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|duplicaterecord|
|ReferencingAttribute|baserecordid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|Fax_DuplicateBaseRecord|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_Fax_BulkDeleteFailures"></a> Fax_BulkDeleteFailures

Same as bulkdeletefailure entity [Fax_BulkDeleteFailures](bulkdeletefailure.md#BKMK_Fax_BulkDeleteFailures) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|bulkdeletefailure|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|Fax_BulkDeleteFailures|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_fax_activity_parties"></a> fax_activity_parties

Same as activityparty entity [fax_activity_parties](activityparty.md#BKMK_fax_activity_parties) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|activityparty|
|ReferencingAttribute|activityid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|fax_activity_parties|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_fax_connections2"></a> fax_connections2

Same as connection entity [fax_connections2](connection.md#BKMK_fax_connections2) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|connection|
|ReferencingAttribute|record2id|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|fax_connections2|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: 100|
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_Fax_SyncErrors"></a> Fax_SyncErrors

Same as syncerror entity [Fax_SyncErrors](syncerror.md#BKMK_Fax_SyncErrors) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|syncerror|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|Fax_SyncErrors|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: Cascade<br />Reparent: Cascade<br />Share: Cascade<br />Unshare: Cascade|


### <a name="BKMK_Fax_DuplicateMatchingRecord"></a> Fax_DuplicateMatchingRecord

Same as duplicaterecord entity [Fax_DuplicateMatchingRecord](duplicaterecord.md#BKMK_Fax_DuplicateMatchingRecord) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|duplicaterecord|
|ReferencingAttribute|duplicaterecordid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|Fax_DuplicateMatchingRecord|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_Fax_Annotation"></a> Fax_Annotation

Same as annotation entity [Fax_Annotation](annotation.md#BKMK_Fax_Annotation) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|annotation|
|ReferencingAttribute|objectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|Fax_Annotation|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: Cascade<br />Share: Cascade<br />Unshare: Cascade|


### <a name="BKMK_Fax_ProcessSessions"></a> Fax_ProcessSessions

Same as processsession entity [Fax_ProcessSessions](processsession.md#BKMK_Fax_ProcessSessions) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|processsession|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|Fax_ProcessSessions|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Details<br />Label: <br />Order: 110|
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_fax_connections1"></a> fax_connections1

Same as connection entity [fax_connections1](connection.md#BKMK_fax_connections1) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|connection|
|ReferencingAttribute|record1id|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|fax_connections1|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Details<br />Label: <br />Order: 100|
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_Fax_QueueItem"></a> Fax_QueueItem

Same as queueitem entity [Fax_QueueItem](queueitem.md#BKMK_Fax_QueueItem) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|queueitem|
|ReferencingAttribute|objectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|Fax_QueueItem|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_fax_actioncard"></a> fax_actioncard

Same as actioncard entity [fax_actioncard](actioncard.md#BKMK_fax_actioncard) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|actioncard|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|fax_actioncard|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|

<a name="manytoone"></a>

## Many-To-One Relationships

Each Many-To-One relationship is defined by a corresponding One-To-Many relationship with the related entity. Listed by **SchemaName**.

- [business_unit_fax_activities](#BKMK_business_unit_fax_activities)
- [Lead_Faxes](#BKMK_Lead_Faxes)
- [bookableresourcebooking_Faxes](#BKMK_bookableresourcebooking_Faxes)
- [bookableresourcebookingheader_Faxes](#BKMK_bookableresourcebookingheader_Faxes)
- [BulkOperation_Faxes](#BKMK_BulkOperation_Faxes)
- [Campaign_Faxes](#BKMK_Campaign_Faxes)
- [CampaignActivity_Faxes](#BKMK_CampaignActivity_Faxes)
- [Contract_Faxes](#BKMK_Contract_Faxes)
- [entitlement_Faxes](#BKMK_entitlement_Faxes)
- [entitlementtemplate_Faxes](#BKMK_entitlementtemplate_Faxes)
- [Incident_Faxes](#BKMK_Incident_Faxes)
- [site_Faxes](#BKMK_site_Faxes)
- [service_faxes](#BKMK_service_faxes)
- [msdyn_playbookinstance_Faxes](#BKMK_msdyn_playbookinstance_Faxes)
- [Invoice_Faxes](#BKMK_Invoice_Faxes)
- [Opportunity_Faxes](#BKMK_Opportunity_Faxes)
- [Quote_Faxes](#BKMK_Quote_Faxes)
- [SalesOrder_Faxes](#BKMK_SalesOrder_Faxes)
- [msdyn_postalbum_Faxes](#BKMK_msdyn_postalbum_Faxes)
- [msdyn_bookingalertstatus_Faxes](#BKMK_msdyn_bookingalertstatus_Faxes)
- [msdyn_bookingrule_Faxes](#BKMK_msdyn_bookingrule_Faxes)
- [msdyn_resourceterritory_Faxes](#BKMK_msdyn_resourceterritory_Faxes)
- [msdyn_systemuserschedulersetting_Faxes](#BKMK_msdyn_systemuserschedulersetting_Faxes)
- [msdyn_timegroup_Faxes](#BKMK_msdyn_timegroup_Faxes)
- [msdyn_timegroupdetail_Faxes](#BKMK_msdyn_timegroupdetail_Faxes)
- [msdyn_processnotes_Faxes](#BKMK_msdyn_processnotes_Faxes)
- [msdyn_projectteam_Faxes](#BKMK_msdyn_projectteam_Faxes)
- [msdyn_agreement_Faxes](#BKMK_msdyn_agreement_Faxes)
- [msdyn_agreementbookingdate_Faxes](#BKMK_msdyn_agreementbookingdate_Faxes)
- [msdyn_agreementbookingincident_Faxes](#BKMK_msdyn_agreementbookingincident_Faxes)
- [msdyn_agreementbookingproduct_Faxes](#BKMK_msdyn_agreementbookingproduct_Faxes)
- [msdyn_agreementbookingservice_Faxes](#BKMK_msdyn_agreementbookingservice_Faxes)
- [msdyn_agreementbookingservicetask_Faxes](#BKMK_msdyn_agreementbookingservicetask_Faxes)
- [msdyn_agreementbookingsetup_Faxes](#BKMK_msdyn_agreementbookingsetup_Faxes)
- [msdyn_agreementinvoicedate_Faxes](#BKMK_msdyn_agreementinvoicedate_Faxes)
- [msdyn_agreementinvoiceproduct_Faxes](#BKMK_msdyn_agreementinvoiceproduct_Faxes)
- [msdyn_agreementinvoicesetup_Faxes](#BKMK_msdyn_agreementinvoicesetup_Faxes)
- [msdyn_bookingtimestamp_Faxes](#BKMK_msdyn_bookingtimestamp_Faxes)
- [msdyn_customerasset_Faxes](#BKMK_msdyn_customerasset_Faxes)
- [msdyn_fieldservicesetting_Faxes](#BKMK_msdyn_fieldservicesetting_Faxes)
- [msdyn_incidenttypecharacteristic_Faxes](#BKMK_msdyn_incidenttypecharacteristic_Faxes)
- [msdyn_incidenttypeproduct_Faxes](#BKMK_msdyn_incidenttypeproduct_Faxes)
- [msdyn_incidenttypeservice_Faxes](#BKMK_msdyn_incidenttypeservice_Faxes)
- [msdyn_inventoryadjustment_Faxes](#BKMK_msdyn_inventoryadjustment_Faxes)
- [msdyn_inventoryadjustmentproduct_Faxes](#BKMK_msdyn_inventoryadjustmentproduct_Faxes)
- [msdyn_inventoryjournal_Faxes](#BKMK_msdyn_inventoryjournal_Faxes)
- [msdyn_inventorytransfer_Faxes](#BKMK_msdyn_inventorytransfer_Faxes)
- [msdyn_payment_Faxes](#BKMK_msdyn_payment_Faxes)
- [msdyn_paymentdetail_Faxes](#BKMK_msdyn_paymentdetail_Faxes)
- [msdyn_paymentmethod_Faxes](#BKMK_msdyn_paymentmethod_Faxes)
- [msdyn_paymentterm_Faxes](#BKMK_msdyn_paymentterm_Faxes)
- [msdyn_postalcode_Faxes](#BKMK_msdyn_postalcode_Faxes)
- [msdyn_productinventory_Faxes](#BKMK_msdyn_productinventory_Faxes)
- [msdyn_purchaseorder_Faxes](#BKMK_msdyn_purchaseorder_Faxes)
- [msdyn_purchaseorderbill_Faxes](#BKMK_msdyn_purchaseorderbill_Faxes)
- [msdyn_purchaseorderproduct_Faxes](#BKMK_msdyn_purchaseorderproduct_Faxes)
- [msdyn_purchaseorderreceipt_Faxes](#BKMK_msdyn_purchaseorderreceipt_Faxes)
- [msdyn_purchaseorderreceiptproduct_Faxes](#BKMK_msdyn_purchaseorderreceiptproduct_Faxes)
- [msdyn_purchaseordersubstatus_Faxes](#BKMK_msdyn_purchaseordersubstatus_Faxes)
- [msdyn_quotebookingincident_Faxes](#BKMK_msdyn_quotebookingincident_Faxes)
- [msdyn_quotebookingproduct_Faxes](#BKMK_msdyn_quotebookingproduct_Faxes)
- [msdyn_quotebookingservice_Faxes](#BKMK_msdyn_quotebookingservice_Faxes)
- [msdyn_quotebookingservicetask_Faxes](#BKMK_msdyn_quotebookingservicetask_Faxes)
- [msdyn_rma_Faxes](#BKMK_msdyn_rma_Faxes)
- [msdyn_rmaproduct_Faxes](#BKMK_msdyn_rmaproduct_Faxes)
- [msdyn_rmareceipt_Faxes](#BKMK_msdyn_rmareceipt_Faxes)
- [msdyn_rmareceiptproduct_Faxes](#BKMK_msdyn_rmareceiptproduct_Faxes)
- [msdyn_rmasubstatus_Faxes](#BKMK_msdyn_rmasubstatus_Faxes)
- [msdyn_rtv_Faxes](#BKMK_msdyn_rtv_Faxes)
- [msdyn_rtvproduct_Faxes](#BKMK_msdyn_rtvproduct_Faxes)
- [msdyn_rtvsubstatus_Faxes](#BKMK_msdyn_rtvsubstatus_Faxes)
- [msdyn_shipvia_Faxes](#BKMK_msdyn_shipvia_Faxes)
- [msdyn_timeoffrequest_Faxes](#BKMK_msdyn_timeoffrequest_Faxes)
- [msdyn_warehouse_Faxes](#BKMK_msdyn_warehouse_Faxes)
- [msdyn_workorder_Faxes](#BKMK_msdyn_workorder_Faxes)
- [msdyn_workordercharacteristic_Faxes](#BKMK_msdyn_workordercharacteristic_Faxes)
- [msdyn_workorderincident_Faxes](#BKMK_msdyn_workorderincident_Faxes)
- [msdyn_workorderproduct_Faxes](#BKMK_msdyn_workorderproduct_Faxes)
- [msdyn_workorderresourcerestriction_Faxes](#BKMK_msdyn_workorderresourcerestriction_Faxes)
- [msdyn_workorderservice_Faxes](#BKMK_msdyn_workorderservice_Faxes)
- [msdyn_workorderservicetask_Faxes](#BKMK_msdyn_workorderservicetask_Faxes)
- [KnowledgeBaseRecord_Faxes](#BKMK_KnowledgeBaseRecord_Faxes)
- [KnowledgeArticle_Faxes](#BKMK_KnowledgeArticle_Faxes)
- [manualsla_fax](#BKMK_manualsla_fax)
- [sla_fax](#BKMK_sla_fax)
- [activity_pointer_fax](#BKMK_activity_pointer_fax)
- [processstage_faxes](#BKMK_processstage_faxes)
- [user_fax](#BKMK_user_fax)
- [Account_Faxes](#BKMK_Account_Faxes)
- [lk_fax_createdonbehalfby](#BKMK_lk_fax_createdonbehalfby)
- [team_fax](#BKMK_team_fax)
- [lk_fax_createdby](#BKMK_lk_fax_createdby)
- [TransactionCurrency_Fax](#BKMK_TransactionCurrency_Fax)
- [lk_fax_modifiedby](#BKMK_lk_fax_modifiedby)
- [Contact_Faxes](#BKMK_Contact_Faxes)
- [lk_fax_modifiedonbehalfby](#BKMK_lk_fax_modifiedonbehalfby)


### <a name="BKMK_business_unit_fax_activities"></a> business_unit_fax_activities

See businessunit Entity [business_unit_fax_activities](businessunit.md#BKMK_business_unit_fax_activities) One-To-Many relationship.

### <a name="BKMK_Lead_Faxes"></a> Lead_Faxes

**Added by**: Lead Management Solution

See lead Entity [Lead_Faxes](lead.md#BKMK_Lead_Faxes) One-To-Many relationship.

### <a name="BKMK_bookableresourcebooking_Faxes"></a> bookableresourcebooking_Faxes

**Added by**: Scheduling Solution

See bookableresourcebooking Entity [bookableresourcebooking_Faxes](bookableresourcebooking.md#BKMK_bookableresourcebooking_Faxes) One-To-Many relationship.

### <a name="BKMK_bookableresourcebookingheader_Faxes"></a> bookableresourcebookingheader_Faxes

**Added by**: Scheduling Solution

See bookableresourcebookingheader Entity [bookableresourcebookingheader_Faxes](bookableresourcebookingheader.md#BKMK_bookableresourcebookingheader_Faxes) One-To-Many relationship.

### <a name="BKMK_BulkOperation_Faxes"></a> BulkOperation_Faxes

**Added by**: Marketing Solution

See bulkoperation Entity [BulkOperation_Faxes](bulkoperation.md#BKMK_BulkOperation_Faxes) One-To-Many relationship.

### <a name="BKMK_Campaign_Faxes"></a> Campaign_Faxes

**Added by**: Marketing Solution

See campaign Entity [Campaign_Faxes](campaign.md#BKMK_Campaign_Faxes) One-To-Many relationship.

### <a name="BKMK_CampaignActivity_Faxes"></a> CampaignActivity_Faxes

**Added by**: Marketing Solution

See campaignactivity Entity [CampaignActivity_Faxes](campaignactivity.md#BKMK_CampaignActivity_Faxes) One-To-Many relationship.

### <a name="BKMK_Contract_Faxes"></a> Contract_Faxes

**Added by**: Service Solution

See contract Entity [Contract_Faxes](contract.md#BKMK_Contract_Faxes) One-To-Many relationship.

### <a name="BKMK_entitlement_Faxes"></a> entitlement_Faxes

**Added by**: Service Solution

See entitlement Entity [entitlement_Faxes](entitlement.md#BKMK_entitlement_Faxes) One-To-Many relationship.

### <a name="BKMK_entitlementtemplate_Faxes"></a> entitlementtemplate_Faxes

**Added by**: Service Solution

See entitlementtemplate Entity [entitlementtemplate_Faxes](entitlementtemplate.md#BKMK_entitlementtemplate_Faxes) One-To-Many relationship.

### <a name="BKMK_Incident_Faxes"></a> Incident_Faxes

**Added by**: Service Solution

See incident Entity [Incident_Faxes](incident.md#BKMK_Incident_Faxes) One-To-Many relationship.

### <a name="BKMK_site_Faxes"></a> site_Faxes

**Added by**: Service Solution

See site Entity [site_Faxes](site.md#BKMK_site_Faxes) One-To-Many relationship.

### <a name="BKMK_service_faxes"></a> service_faxes

**Added by**: Service Solution

See service Entity [service_faxes](service.md#BKMK_service_faxes) One-To-Many relationship.

### <a name="BKMK_msdyn_playbookinstance_Faxes"></a> msdyn_playbookinstance_Faxes

**Added by**: Playbook Solution

See msdyn_playbookinstance Entity [msdyn_playbookinstance_Faxes](msdyn_playbookinstance.md#BKMK_msdyn_playbookinstance_Faxes) One-To-Many relationship.

### <a name="BKMK_Invoice_Faxes"></a> Invoice_Faxes

**Added by**: Sales Solution

See invoice Entity [Invoice_Faxes](invoice.md#BKMK_Invoice_Faxes) One-To-Many relationship.

### <a name="BKMK_Opportunity_Faxes"></a> Opportunity_Faxes

**Added by**: Sales Solution

See opportunity Entity [Opportunity_Faxes](opportunity.md#BKMK_Opportunity_Faxes) One-To-Many relationship.

### <a name="BKMK_Quote_Faxes"></a> Quote_Faxes

**Added by**: Sales Solution

See quote Entity [Quote_Faxes](quote.md#BKMK_Quote_Faxes) One-To-Many relationship.

### <a name="BKMK_SalesOrder_Faxes"></a> SalesOrder_Faxes

**Added by**: Sales Solution

See salesorder Entity [SalesOrder_Faxes](salesorder.md#BKMK_SalesOrder_Faxes) One-To-Many relationship.

### <a name="BKMK_msdyn_postalbum_Faxes"></a> msdyn_postalbum_Faxes

**Added by**: Activity Feeds Solution

See msdyn_postalbum Entity [msdyn_postalbum_Faxes](msdyn_postalbum.md#BKMK_msdyn_postalbum_Faxes) One-To-Many relationship.

### <a name="BKMK_msdyn_bookingalertstatus_Faxes"></a> msdyn_bookingalertstatus_Faxes

**Added by**: Universal Resource Scheduling Solution

See msdyn_bookingalertstatus Entity [msdyn_bookingalertstatus_Faxes](msdyn_bookingalertstatus.md#BKMK_msdyn_bookingalertstatus_Faxes) One-To-Many relationship.

### <a name="BKMK_msdyn_bookingrule_Faxes"></a> msdyn_bookingrule_Faxes

**Added by**: Universal Resource Scheduling Solution

See msdyn_bookingrule Entity [msdyn_bookingrule_Faxes](msdyn_bookingrule.md#BKMK_msdyn_bookingrule_Faxes) One-To-Many relationship.

### <a name="BKMK_msdyn_resourceterritory_Faxes"></a> msdyn_resourceterritory_Faxes

**Added by**: Universal Resource Scheduling Solution

See msdyn_resourceterritory Entity [msdyn_resourceterritory_Faxes](msdyn_resourceterritory.md#BKMK_msdyn_resourceterritory_Faxes) One-To-Many relationship.

### <a name="BKMK_msdyn_systemuserschedulersetting_Faxes"></a> msdyn_systemuserschedulersetting_Faxes

**Added by**: Universal Resource Scheduling Solution

See msdyn_systemuserschedulersetting Entity [msdyn_systemuserschedulersetting_Faxes](msdyn_systemuserschedulersetting.md#BKMK_msdyn_systemuserschedulersetting_Faxes) One-To-Many relationship.

### <a name="BKMK_msdyn_timegroup_Faxes"></a> msdyn_timegroup_Faxes

**Added by**: Universal Resource Scheduling Solution

See msdyn_timegroup Entity [msdyn_timegroup_Faxes](msdyn_timegroup.md#BKMK_msdyn_timegroup_Faxes) One-To-Many relationship.

### <a name="BKMK_msdyn_timegroupdetail_Faxes"></a> msdyn_timegroupdetail_Faxes

**Added by**: Universal Resource Scheduling Solution

See msdyn_timegroupdetail Entity [msdyn_timegroupdetail_Faxes](msdyn_timegroupdetail.md#BKMK_msdyn_timegroupdetail_Faxes) One-To-Many relationship.

### <a name="BKMK_msdyn_processnotes_Faxes"></a> msdyn_processnotes_Faxes

**Added by**: Project Service Automation Solution

See msdyn_processnotes Entity [msdyn_processnotes_Faxes](msdyn_processnotes.md#BKMK_msdyn_processnotes_Faxes) One-To-Many relationship.

### <a name="BKMK_msdyn_projectteam_Faxes"></a> msdyn_projectteam_Faxes

**Added by**: Project Service Automation Solution

See msdyn_projectteam Entity [msdyn_projectteam_Faxes](msdyn_projectteam.md#BKMK_msdyn_projectteam_Faxes) One-To-Many relationship.

### <a name="BKMK_msdyn_agreement_Faxes"></a> msdyn_agreement_Faxes

**Added by**: Field Service Solution

See msdyn_agreement Entity [msdyn_agreement_Faxes](msdyn_agreement.md#BKMK_msdyn_agreement_Faxes) One-To-Many relationship.

### <a name="BKMK_msdyn_agreementbookingdate_Faxes"></a> msdyn_agreementbookingdate_Faxes

**Added by**: Field Service Solution

See msdyn_agreementbookingdate Entity [msdyn_agreementbookingdate_Faxes](msdyn_agreementbookingdate.md#BKMK_msdyn_agreementbookingdate_Faxes) One-To-Many relationship.

### <a name="BKMK_msdyn_agreementbookingincident_Faxes"></a> msdyn_agreementbookingincident_Faxes

**Added by**: Field Service Solution

See msdyn_agreementbookingincident Entity [msdyn_agreementbookingincident_Faxes](msdyn_agreementbookingincident.md#BKMK_msdyn_agreementbookingincident_Faxes) One-To-Many relationship.

### <a name="BKMK_msdyn_agreementbookingproduct_Faxes"></a> msdyn_agreementbookingproduct_Faxes

**Added by**: Field Service Solution

See msdyn_agreementbookingproduct Entity [msdyn_agreementbookingproduct_Faxes](msdyn_agreementbookingproduct.md#BKMK_msdyn_agreementbookingproduct_Faxes) One-To-Many relationship.

### <a name="BKMK_msdyn_agreementbookingservice_Faxes"></a> msdyn_agreementbookingservice_Faxes

**Added by**: Field Service Solution

See msdyn_agreementbookingservice Entity [msdyn_agreementbookingservice_Faxes](msdyn_agreementbookingservice.md#BKMK_msdyn_agreementbookingservice_Faxes) One-To-Many relationship.

### <a name="BKMK_msdyn_agreementbookingservicetask_Faxes"></a> msdyn_agreementbookingservicetask_Faxes

**Added by**: Field Service Solution

See msdyn_agreementbookingservicetask Entity [msdyn_agreementbookingservicetask_Faxes](msdyn_agreementbookingservicetask.md#BKMK_msdyn_agreementbookingservicetask_Faxes) One-To-Many relationship.

### <a name="BKMK_msdyn_agreementbookingsetup_Faxes"></a> msdyn_agreementbookingsetup_Faxes

**Added by**: Field Service Solution

See msdyn_agreementbookingsetup Entity [msdyn_agreementbookingsetup_Faxes](msdyn_agreementbookingsetup.md#BKMK_msdyn_agreementbookingsetup_Faxes) One-To-Many relationship.

### <a name="BKMK_msdyn_agreementinvoicedate_Faxes"></a> msdyn_agreementinvoicedate_Faxes

**Added by**: Field Service Solution

See msdyn_agreementinvoicedate Entity [msdyn_agreementinvoicedate_Faxes](msdyn_agreementinvoicedate.md#BKMK_msdyn_agreementinvoicedate_Faxes) One-To-Many relationship.

### <a name="BKMK_msdyn_agreementinvoiceproduct_Faxes"></a> msdyn_agreementinvoiceproduct_Faxes

**Added by**: Field Service Solution

See msdyn_agreementinvoiceproduct Entity [msdyn_agreementinvoiceproduct_Faxes](msdyn_agreementinvoiceproduct.md#BKMK_msdyn_agreementinvoiceproduct_Faxes) One-To-Many relationship.

### <a name="BKMK_msdyn_agreementinvoicesetup_Faxes"></a> msdyn_agreementinvoicesetup_Faxes

**Added by**: Field Service Solution

See msdyn_agreementinvoicesetup Entity [msdyn_agreementinvoicesetup_Faxes](msdyn_agreementinvoicesetup.md#BKMK_msdyn_agreementinvoicesetup_Faxes) One-To-Many relationship.

### <a name="BKMK_msdyn_bookingtimestamp_Faxes"></a> msdyn_bookingtimestamp_Faxes

**Added by**: Field Service Solution

See msdyn_bookingtimestamp Entity [msdyn_bookingtimestamp_Faxes](msdyn_bookingtimestamp.md#BKMK_msdyn_bookingtimestamp_Faxes) One-To-Many relationship.

### <a name="BKMK_msdyn_customerasset_Faxes"></a> msdyn_customerasset_Faxes

**Added by**: Field Service Solution

See msdyn_customerasset Entity [msdyn_customerasset_Faxes](msdyn_customerasset.md#BKMK_msdyn_customerasset_Faxes) One-To-Many relationship.

### <a name="BKMK_msdyn_fieldservicesetting_Faxes"></a> msdyn_fieldservicesetting_Faxes

**Added by**: Field Service Solution

See msdyn_fieldservicesetting Entity [msdyn_fieldservicesetting_Faxes](msdyn_fieldservicesetting.md#BKMK_msdyn_fieldservicesetting_Faxes) One-To-Many relationship.

### <a name="BKMK_msdyn_incidenttypecharacteristic_Faxes"></a> msdyn_incidenttypecharacteristic_Faxes

**Added by**: Field Service Solution

See msdyn_incidenttypecharacteristic Entity [msdyn_incidenttypecharacteristic_Faxes](msdyn_incidenttypecharacteristic.md#BKMK_msdyn_incidenttypecharacteristic_Faxes) One-To-Many relationship.

### <a name="BKMK_msdyn_incidenttypeproduct_Faxes"></a> msdyn_incidenttypeproduct_Faxes

**Added by**: Field Service Solution

See msdyn_incidenttypeproduct Entity [msdyn_incidenttypeproduct_Faxes](msdyn_incidenttypeproduct.md#BKMK_msdyn_incidenttypeproduct_Faxes) One-To-Many relationship.

### <a name="BKMK_msdyn_incidenttypeservice_Faxes"></a> msdyn_incidenttypeservice_Faxes

**Added by**: Field Service Solution

See msdyn_incidenttypeservice Entity [msdyn_incidenttypeservice_Faxes](msdyn_incidenttypeservice.md#BKMK_msdyn_incidenttypeservice_Faxes) One-To-Many relationship.

### <a name="BKMK_msdyn_inventoryadjustment_Faxes"></a> msdyn_inventoryadjustment_Faxes

**Added by**: Field Service Solution

See msdyn_inventoryadjustment Entity [msdyn_inventoryadjustment_Faxes](msdyn_inventoryadjustment.md#BKMK_msdyn_inventoryadjustment_Faxes) One-To-Many relationship.

### <a name="BKMK_msdyn_inventoryadjustmentproduct_Faxes"></a> msdyn_inventoryadjustmentproduct_Faxes

**Added by**: Field Service Solution

See msdyn_inventoryadjustmentproduct Entity [msdyn_inventoryadjustmentproduct_Faxes](msdyn_inventoryadjustmentproduct.md#BKMK_msdyn_inventoryadjustmentproduct_Faxes) One-To-Many relationship.

### <a name="BKMK_msdyn_inventoryjournal_Faxes"></a> msdyn_inventoryjournal_Faxes

**Added by**: Field Service Solution

See msdyn_inventoryjournal Entity [msdyn_inventoryjournal_Faxes](msdyn_inventoryjournal.md#BKMK_msdyn_inventoryjournal_Faxes) One-To-Many relationship.

### <a name="BKMK_msdyn_inventorytransfer_Faxes"></a> msdyn_inventorytransfer_Faxes

**Added by**: Field Service Solution

See msdyn_inventorytransfer Entity [msdyn_inventorytransfer_Faxes](msdyn_inventorytransfer.md#BKMK_msdyn_inventorytransfer_Faxes) One-To-Many relationship.

### <a name="BKMK_msdyn_payment_Faxes"></a> msdyn_payment_Faxes

**Added by**: Field Service Solution

See msdyn_payment Entity [msdyn_payment_Faxes](msdyn_payment.md#BKMK_msdyn_payment_Faxes) One-To-Many relationship.

### <a name="BKMK_msdyn_paymentdetail_Faxes"></a> msdyn_paymentdetail_Faxes

**Added by**: Field Service Solution

See msdyn_paymentdetail Entity [msdyn_paymentdetail_Faxes](msdyn_paymentdetail.md#BKMK_msdyn_paymentdetail_Faxes) One-To-Many relationship.

### <a name="BKMK_msdyn_paymentmethod_Faxes"></a> msdyn_paymentmethod_Faxes

**Added by**: Field Service Solution

See msdyn_paymentmethod Entity [msdyn_paymentmethod_Faxes](msdyn_paymentmethod.md#BKMK_msdyn_paymentmethod_Faxes) One-To-Many relationship.

### <a name="BKMK_msdyn_paymentterm_Faxes"></a> msdyn_paymentterm_Faxes

**Added by**: Field Service Solution

See msdyn_paymentterm Entity [msdyn_paymentterm_Faxes](msdyn_paymentterm.md#BKMK_msdyn_paymentterm_Faxes) One-To-Many relationship.

### <a name="BKMK_msdyn_postalcode_Faxes"></a> msdyn_postalcode_Faxes

**Added by**: Field Service Solution

See msdyn_postalcode Entity [msdyn_postalcode_Faxes](msdyn_postalcode.md#BKMK_msdyn_postalcode_Faxes) One-To-Many relationship.

### <a name="BKMK_msdyn_productinventory_Faxes"></a> msdyn_productinventory_Faxes

**Added by**: Field Service Solution

See msdyn_productinventory Entity [msdyn_productinventory_Faxes](msdyn_productinventory.md#BKMK_msdyn_productinventory_Faxes) One-To-Many relationship.

### <a name="BKMK_msdyn_purchaseorder_Faxes"></a> msdyn_purchaseorder_Faxes

**Added by**: Field Service Solution

See msdyn_purchaseorder Entity [msdyn_purchaseorder_Faxes](msdyn_purchaseorder.md#BKMK_msdyn_purchaseorder_Faxes) One-To-Many relationship.

### <a name="BKMK_msdyn_purchaseorderbill_Faxes"></a> msdyn_purchaseorderbill_Faxes

**Added by**: Field Service Solution

See msdyn_purchaseorderbill Entity [msdyn_purchaseorderbill_Faxes](msdyn_purchaseorderbill.md#BKMK_msdyn_purchaseorderbill_Faxes) One-To-Many relationship.

### <a name="BKMK_msdyn_purchaseorderproduct_Faxes"></a> msdyn_purchaseorderproduct_Faxes

**Added by**: Field Service Solution

See msdyn_purchaseorderproduct Entity [msdyn_purchaseorderproduct_Faxes](msdyn_purchaseorderproduct.md#BKMK_msdyn_purchaseorderproduct_Faxes) One-To-Many relationship.

### <a name="BKMK_msdyn_purchaseorderreceipt_Faxes"></a> msdyn_purchaseorderreceipt_Faxes

**Added by**: Field Service Solution

See msdyn_purchaseorderreceipt Entity [msdyn_purchaseorderreceipt_Faxes](msdyn_purchaseorderreceipt.md#BKMK_msdyn_purchaseorderreceipt_Faxes) One-To-Many relationship.

### <a name="BKMK_msdyn_purchaseorderreceiptproduct_Faxes"></a> msdyn_purchaseorderreceiptproduct_Faxes

**Added by**: Field Service Solution

See msdyn_purchaseorderreceiptproduct Entity [msdyn_purchaseorderreceiptproduct_Faxes](msdyn_purchaseorderreceiptproduct.md#BKMK_msdyn_purchaseorderreceiptproduct_Faxes) One-To-Many relationship.

### <a name="BKMK_msdyn_purchaseordersubstatus_Faxes"></a> msdyn_purchaseordersubstatus_Faxes

**Added by**: Field Service Solution

See msdyn_purchaseordersubstatus Entity [msdyn_purchaseordersubstatus_Faxes](msdyn_purchaseordersubstatus.md#BKMK_msdyn_purchaseordersubstatus_Faxes) One-To-Many relationship.

### <a name="BKMK_msdyn_quotebookingincident_Faxes"></a> msdyn_quotebookingincident_Faxes

**Added by**: Field Service Solution

See msdyn_quotebookingincident Entity [msdyn_quotebookingincident_Faxes](msdyn_quotebookingincident.md#BKMK_msdyn_quotebookingincident_Faxes) One-To-Many relationship.

### <a name="BKMK_msdyn_quotebookingproduct_Faxes"></a> msdyn_quotebookingproduct_Faxes

**Added by**: Field Service Solution

See msdyn_quotebookingproduct Entity [msdyn_quotebookingproduct_Faxes](msdyn_quotebookingproduct.md#BKMK_msdyn_quotebookingproduct_Faxes) One-To-Many relationship.

### <a name="BKMK_msdyn_quotebookingservice_Faxes"></a> msdyn_quotebookingservice_Faxes

**Added by**: Field Service Solution

See msdyn_quotebookingservice Entity [msdyn_quotebookingservice_Faxes](msdyn_quotebookingservice.md#BKMK_msdyn_quotebookingservice_Faxes) One-To-Many relationship.

### <a name="BKMK_msdyn_quotebookingservicetask_Faxes"></a> msdyn_quotebookingservicetask_Faxes

**Added by**: Field Service Solution

See msdyn_quotebookingservicetask Entity [msdyn_quotebookingservicetask_Faxes](msdyn_quotebookingservicetask.md#BKMK_msdyn_quotebookingservicetask_Faxes) One-To-Many relationship.

### <a name="BKMK_msdyn_rma_Faxes"></a> msdyn_rma_Faxes

**Added by**: Field Service Solution

See msdyn_rma Entity [msdyn_rma_Faxes](msdyn_rma.md#BKMK_msdyn_rma_Faxes) One-To-Many relationship.

### <a name="BKMK_msdyn_rmaproduct_Faxes"></a> msdyn_rmaproduct_Faxes

**Added by**: Field Service Solution

See msdyn_rmaproduct Entity [msdyn_rmaproduct_Faxes](msdyn_rmaproduct.md#BKMK_msdyn_rmaproduct_Faxes) One-To-Many relationship.

### <a name="BKMK_msdyn_rmareceipt_Faxes"></a> msdyn_rmareceipt_Faxes

**Added by**: Field Service Solution

See msdyn_rmareceipt Entity [msdyn_rmareceipt_Faxes](msdyn_rmareceipt.md#BKMK_msdyn_rmareceipt_Faxes) One-To-Many relationship.

### <a name="BKMK_msdyn_rmareceiptproduct_Faxes"></a> msdyn_rmareceiptproduct_Faxes

**Added by**: Field Service Solution

See msdyn_rmareceiptproduct Entity [msdyn_rmareceiptproduct_Faxes](msdyn_rmareceiptproduct.md#BKMK_msdyn_rmareceiptproduct_Faxes) One-To-Many relationship.

### <a name="BKMK_msdyn_rmasubstatus_Faxes"></a> msdyn_rmasubstatus_Faxes

**Added by**: Field Service Solution

See msdyn_rmasubstatus Entity [msdyn_rmasubstatus_Faxes](msdyn_rmasubstatus.md#BKMK_msdyn_rmasubstatus_Faxes) One-To-Many relationship.

### <a name="BKMK_msdyn_rtv_Faxes"></a> msdyn_rtv_Faxes

**Added by**: Field Service Solution

See msdyn_rtv Entity [msdyn_rtv_Faxes](msdyn_rtv.md#BKMK_msdyn_rtv_Faxes) One-To-Many relationship.

### <a name="BKMK_msdyn_rtvproduct_Faxes"></a> msdyn_rtvproduct_Faxes

**Added by**: Field Service Solution

See msdyn_rtvproduct Entity [msdyn_rtvproduct_Faxes](msdyn_rtvproduct.md#BKMK_msdyn_rtvproduct_Faxes) One-To-Many relationship.

### <a name="BKMK_msdyn_rtvsubstatus_Faxes"></a> msdyn_rtvsubstatus_Faxes

**Added by**: Field Service Solution

See msdyn_rtvsubstatus Entity [msdyn_rtvsubstatus_Faxes](msdyn_rtvsubstatus.md#BKMK_msdyn_rtvsubstatus_Faxes) One-To-Many relationship.

### <a name="BKMK_msdyn_shipvia_Faxes"></a> msdyn_shipvia_Faxes

**Added by**: Field Service Solution

See msdyn_shipvia Entity [msdyn_shipvia_Faxes](msdyn_shipvia.md#BKMK_msdyn_shipvia_Faxes) One-To-Many relationship.

### <a name="BKMK_msdyn_timeoffrequest_Faxes"></a> msdyn_timeoffrequest_Faxes

**Added by**: Field Service Solution

See msdyn_timeoffrequest Entity [msdyn_timeoffrequest_Faxes](msdyn_timeoffrequest.md#BKMK_msdyn_timeoffrequest_Faxes) One-To-Many relationship.

### <a name="BKMK_msdyn_warehouse_Faxes"></a> msdyn_warehouse_Faxes

**Added by**: Field Service Solution

See msdyn_warehouse Entity [msdyn_warehouse_Faxes](msdyn_warehouse.md#BKMK_msdyn_warehouse_Faxes) One-To-Many relationship.

### <a name="BKMK_msdyn_workorder_Faxes"></a> msdyn_workorder_Faxes

**Added by**: Field Service Solution

See msdyn_workorder Entity [msdyn_workorder_Faxes](msdyn_workorder.md#BKMK_msdyn_workorder_Faxes) One-To-Many relationship.

### <a name="BKMK_msdyn_workordercharacteristic_Faxes"></a> msdyn_workordercharacteristic_Faxes

**Added by**: Field Service Solution

See msdyn_workordercharacteristic Entity [msdyn_workordercharacteristic_Faxes](msdyn_workordercharacteristic.md#BKMK_msdyn_workordercharacteristic_Faxes) One-To-Many relationship.

### <a name="BKMK_msdyn_workorderincident_Faxes"></a> msdyn_workorderincident_Faxes

**Added by**: Field Service Solution

See msdyn_workorderincident Entity [msdyn_workorderincident_Faxes](msdyn_workorderincident.md#BKMK_msdyn_workorderincident_Faxes) One-To-Many relationship.

### <a name="BKMK_msdyn_workorderproduct_Faxes"></a> msdyn_workorderproduct_Faxes

**Added by**: Field Service Solution

See msdyn_workorderproduct Entity [msdyn_workorderproduct_Faxes](msdyn_workorderproduct.md#BKMK_msdyn_workorderproduct_Faxes) One-To-Many relationship.

### <a name="BKMK_msdyn_workorderresourcerestriction_Faxes"></a> msdyn_workorderresourcerestriction_Faxes

**Added by**: Field Service Solution

See msdyn_workorderresourcerestriction Entity [msdyn_workorderresourcerestriction_Faxes](msdyn_workorderresourcerestriction.md#BKMK_msdyn_workorderresourcerestriction_Faxes) One-To-Many relationship.

### <a name="BKMK_msdyn_workorderservice_Faxes"></a> msdyn_workorderservice_Faxes

**Added by**: Field Service Solution

See msdyn_workorderservice Entity [msdyn_workorderservice_Faxes](msdyn_workorderservice.md#BKMK_msdyn_workorderservice_Faxes) One-To-Many relationship.

### <a name="BKMK_msdyn_workorderservicetask_Faxes"></a> msdyn_workorderservicetask_Faxes

**Added by**: Field Service Solution

See msdyn_workorderservicetask Entity [msdyn_workorderservicetask_Faxes](msdyn_workorderservicetask.md#BKMK_msdyn_workorderservicetask_Faxes) One-To-Many relationship.

### <a name="BKMK_KnowledgeBaseRecord_Faxes"></a> KnowledgeBaseRecord_Faxes

See knowledgebaserecord Entity [KnowledgeBaseRecord_Faxes](knowledgebaserecord.md#BKMK_KnowledgeBaseRecord_Faxes) One-To-Many relationship.

### <a name="BKMK_KnowledgeArticle_Faxes"></a> KnowledgeArticle_Faxes

See knowledgearticle Entity [KnowledgeArticle_Faxes](knowledgearticle.md#BKMK_KnowledgeArticle_Faxes) One-To-Many relationship.

### <a name="BKMK_manualsla_fax"></a> manualsla_fax

See sla Entity [manualsla_fax](sla.md#BKMK_manualsla_fax) One-To-Many relationship.

### <a name="BKMK_sla_fax"></a> sla_fax

See sla Entity [sla_fax](sla.md#BKMK_sla_fax) One-To-Many relationship.

### <a name="BKMK_activity_pointer_fax"></a> activity_pointer_fax

See activitypointer Entity [activity_pointer_fax](activitypointer.md#BKMK_activity_pointer_fax) One-To-Many relationship.

### <a name="BKMK_processstage_faxes"></a> processstage_faxes

See processstage Entity [processstage_faxes](processstage.md#BKMK_processstage_faxes) One-To-Many relationship.

### <a name="BKMK_user_fax"></a> user_fax

See systemuser Entity [user_fax](systemuser.md#BKMK_user_fax) One-To-Many relationship.

### <a name="BKMK_Account_Faxes"></a> Account_Faxes

See account Entity [Account_Faxes](account.md#BKMK_Account_Faxes) One-To-Many relationship.

### <a name="BKMK_lk_fax_createdonbehalfby"></a> lk_fax_createdonbehalfby

See systemuser Entity [lk_fax_createdonbehalfby](systemuser.md#BKMK_lk_fax_createdonbehalfby) One-To-Many relationship.

### <a name="BKMK_team_fax"></a> team_fax

See team Entity [team_fax](team.md#BKMK_team_fax) One-To-Many relationship.

### <a name="BKMK_lk_fax_createdby"></a> lk_fax_createdby

See systemuser Entity [lk_fax_createdby](systemuser.md#BKMK_lk_fax_createdby) One-To-Many relationship.

### <a name="BKMK_TransactionCurrency_Fax"></a> TransactionCurrency_Fax

See transactioncurrency Entity [TransactionCurrency_Fax](transactioncurrency.md#BKMK_TransactionCurrency_Fax) One-To-Many relationship.

### <a name="BKMK_lk_fax_modifiedby"></a> lk_fax_modifiedby

See systemuser Entity [lk_fax_modifiedby](systemuser.md#BKMK_lk_fax_modifiedby) One-To-Many relationship.

### <a name="BKMK_Contact_Faxes"></a> Contact_Faxes

See contact Entity [Contact_Faxes](contact.md#BKMK_Contact_Faxes) One-To-Many relationship.

### <a name="BKMK_lk_fax_modifiedonbehalfby"></a> lk_fax_modifiedonbehalfby

See systemuser Entity [lk_fax_modifiedonbehalfby](systemuser.md#BKMK_lk_fax_modifiedonbehalfby) One-To-Many relationship.

### See also

[About the Entity Reference](../about-entity-reference.md)<br />
[Programming reference for Dynamics 365 Customer Engagement](../programming-reference.md)<br />
[Web API Reference](/dynamics365/customer-engagement/web-api/about)<br />
<xref href="Microsoft.Dynamics.CRM.fax?text=fax EntityType" />

[!INCLUDE[footer-include](../../../../includes/footer-banner.md)]