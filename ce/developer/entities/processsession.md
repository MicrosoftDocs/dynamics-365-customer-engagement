---
title: "ProcessSession Entity Reference (Developer Guide for Dynamics 365 Customer Engagement)| MicrosoftDocs"
description: "Includes schema information and supported messages for the ProcessSession entity."
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
# ProcessSession Entity Reference

[!INCLUDE[](../../includes/cc_applies_to_update_9_0_0.md)]

Information that is generated when a dialog is run. Every time that you run a dialog, a dialog session is created.


## Messages

|Message|Web API Operation|SDK Assembly|
|-|-|-|
|Assign|PATCH [*org URI*]/api/data/v9.0/processsessions(*processsessionid*)<br />[Update](../webapi/update-delete-entities-using-web-api.md#basic-update) `ownerid` property.|<xref:Microsoft.Crm.Sdk.Messages.AssignRequest>|
|Create|POST [*org URI*]/api/data/v9.0/processsessions<br />See [Create](../webapi/create-entity-web-api.md)|<xref:Microsoft.Xrm.Sdk.Messages.CreateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Create*>|
|Delete|DELETE [*org URI*]/api/data/v9.0/processsessions(*processsessionid*)<br />See [Delete](../webapi/update-delete-entities-using-web-api.md#basic-delete)|<xref:Microsoft.Xrm.Sdk.Messages.DeleteRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Delete*>|
|GrantAccess|<xref href="Microsoft.Dynamics.CRM.GrantAccess?text=GrantAccess Action" />|<xref:Microsoft.Crm.Sdk.Messages.GrantAccessRequest>|
|ModifyAccess|<xref href="Microsoft.Dynamics.CRM.ModifyAccess?text=ModifyAccess Action" />|<xref:Microsoft.Crm.Sdk.Messages.ModifyAccessRequest>|
|Retrieve|GET [*org URI*]/api/data/v9.0/processsessions(*processsessionid*)<br />See [Retrieve](../webapi/retrieve-entity-using-web-api.md)|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Retrieve*>|
|RetrieveMultiple|GET [*org URI*]/api/data/v9.0/processsessions<br />See [Query Data](../webapi/query-data-web-api.md)|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveMultipleRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.RetrieveMultiple*>|
|RetrievePrincipalAccess|<xref href="Microsoft.Dynamics.CRM.RetrievePrincipalAccess?text=RetrievePrincipalAccess Function" />|<xref:Microsoft.Crm.Sdk.Messages.RetrievePrincipalAccessRequest>|
|RetrieveSharedPrincipalsAndAccess|<xref href="Microsoft.Dynamics.CRM.RetrieveSharedPrincipalsAndAccess?text=RetrieveSharedPrincipalsAndAccess Function" />|<xref:Microsoft.Crm.Sdk.Messages.RetrieveSharedPrincipalsAndAccessRequest>|
|RevokeAccess|<xref href="Microsoft.Dynamics.CRM.RevokeAccess?text=RevokeAccess Action" />|<xref:Microsoft.Crm.Sdk.Messages.RevokeAccessRequest>|
|SetState|PATCH [*org URI*]/api/data/v9.0/processsessions(*processsessionid*)<br />[Update](../webapi/update-delete-entities-using-web-api.md#basic-update) `statecode` and `statuscode` properties.|<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|
|Update|PATCH [*org URI*]/api/data/v9.0/processsessions(*processsessionid*)<br />See [Update](../webapi/update-delete-entities-using-web-api.md#basic-update)|<xref:Microsoft.Xrm.Sdk.Messages.UpdateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Update*>|

## Entity Properties

**DisplayName**: Process Session<br />
**DisplayCollectionName**: Process Sessions<br />
**SchemaName**: ProcessSession<br />
**CollectionSchemaName**: ProcessSession<br />
**LogicalName**: processsession<br />
**LogicalCollectionName**: processsessions<br />
**EntitySetName**: processsessions<br />
**PrimaryIdAttribute**: processsessionid<br />
**PrimaryNameAttribute**: name<br />
**OwnershipType**: UserOwned<br />
**IsBPFEntity**: False<br />
<a name="writable-attributes"></a>

## Writable attributes

These attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [ActivityName](#BKMK_ActivityName)
- [CanceledOn](#BKMK_CanceledOn)
- [Comments](#BKMK_Comments)
- [CompletedOn](#BKMK_CompletedOn)
- [ErrorCode](#BKMK_ErrorCode)
- [ExecutedBy](#BKMK_ExecutedBy)
- [InputArguments](#BKMK_InputArguments)
- [Name](#BKMK_Name)
- [NextLinkedSessionId](#BKMK_NextLinkedSessionId)
- [OriginatingSessionId](#BKMK_OriginatingSessionId)
- [OwnerId](#BKMK_OwnerId)
- [OwnerIdType](#BKMK_OwnerIdType)
- [PreviousLinkedSessionId](#BKMK_PreviousLinkedSessionId)
- [ProcessId](#BKMK_ProcessId)
- [ProcessSessionId](#BKMK_ProcessSessionId)
- [ProcessStageName](#BKMK_ProcessStageName)
- [ProcessState](#BKMK_ProcessState)
- [RegardingObjectId](#BKMK_RegardingObjectId)
- [RegardingObjectIdName](#BKMK_RegardingObjectIdName)
- [RegardingObjectIdYomiName](#BKMK_RegardingObjectIdYomiName)
- [RegardingObjectTypeCode](#BKMK_RegardingObjectTypeCode)
- [StartedOn](#BKMK_StartedOn)
- [StateCode](#BKMK_StateCode)
- [StatusCode](#BKMK_StatusCode)
- [StepName](#BKMK_StepName)


### <a name="BKMK_ActivityName"></a> ActivityName

**Description**: Name of the activity that is being executed.<br />
**DisplayName**: Activity Name<br />
**LogicalName**: activityname<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 256


### <a name="BKMK_CanceledOn"></a> CanceledOn

**Description**: Date and time when the dialog session was canceled.<br />
**DisplayName**: Canceled On<br />
**LogicalName**: canceledon<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**IsValidForCreate**: False<br />
**Type**: DateTime<br />
**DateTimeBehavior**: UserLocal<br />
**Format**: DateAndTime


### <a name="BKMK_Comments"></a> Comments

**Description**: User comments.<br />
**DisplayName**: Comments<br />
**LogicalName**: comments<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Memo<br />
**Format**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 2000


### <a name="BKMK_CompletedOn"></a> CompletedOn

**Description**: Date and time when the dialog session was completed.<br />
**DisplayName**: Completed On<br />
**LogicalName**: completedon<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**IsValidForCreate**: False<br />
**Type**: DateTime<br />
**DateTimeBehavior**: UserLocal<br />
**Format**: DateAndTime


### <a name="BKMK_ErrorCode"></a> ErrorCode

**Description**: Error code related to the dialog session.<br />
**DisplayName**: Error Code<br />
**LogicalName**: errorcode<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Integer<br />
**Format**: None<br />
**MaxValue**: 2147483647<br />
**MinValue**: -2147483648


### <a name="BKMK_ExecutedBy"></a> ExecutedBy

**Description**: Unique identifier of the user who ran the dialog process.<br />
**DisplayName**: Executed By<br />
**LogicalName**: executedby<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: systemuser


### <a name="BKMK_InputArguments"></a> InputArguments

**Description**: Input arguments for the child dialog process.<br />
**DisplayName**: Input Arguments<br />
**LogicalName**: inputarguments<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**IsValidForUpdate**: False<br />
**Type**: Memo<br />
**Format**: TextArea<br />
**IsLocalizable**: False<br />
**MaxLength**: 1073741823


### <a name="BKMK_Name"></a> Name

**Description**: Name of the dialog session.<br />
**DisplayName**: Name<br />
**LogicalName**: name<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 256


### <a name="BKMK_NextLinkedSessionId"></a> NextLinkedSessionId

**Description**: Unique identifier of the succeeding linked dialog session.<br />
**DisplayName**: Next Linked Session<br />
**LogicalName**: nextlinkedsessionid<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: processsession


### <a name="BKMK_OriginatingSessionId"></a> OriginatingSessionId

**Description**: Unique identifier of the originating dialog session.<br />
**DisplayName**: Originating Session<br />
**LogicalName**: originatingsessionid<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**IsValidForUpdate**: False<br />
**Type**: Lookup<br />
**Targets**: processsession


### <a name="BKMK_OwnerId"></a> OwnerId

**Description**: Unique identifier of the user or team who owns the dialog session.<br />
**DisplayName**: Owner<br />
**LogicalName**: ownerid<br />
**IsValidForForm**: False<br />
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


### <a name="BKMK_PreviousLinkedSessionId"></a> PreviousLinkedSessionId

**Description**: Unique identifier of the preceding linked dialog session.<br />
**DisplayName**: Previous Linked Session<br />
**LogicalName**: previouslinkedsessionid<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**IsValidForUpdate**: False<br />
**Type**: Lookup<br />
**Targets**: processsession


### <a name="BKMK_ProcessId"></a> ProcessId

**Description**: Select the process activation record that is related to the dialog session.<br />
**DisplayName**: Process<br />
**LogicalName**: processid<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**IsValidForUpdate**: False<br />
**Type**: Lookup<br />
**Targets**: workflow


### <a name="BKMK_ProcessSessionId"></a> ProcessSessionId

**Description**: Unique identifier of the dialog session.<br />
**DisplayName**: Dialog Session<br />
**LogicalName**: processsessionid<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: SystemRequired<br />
**IsValidForUpdate**: False<br />
**Type**: Uniqueidentifier<br />


### <a name="BKMK_ProcessStageName"></a> ProcessStageName

**Description**: Name of the dialog stage.<br />
**DisplayName**: Dialog Stage<br />
**LogicalName**: processstagename<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 256


### <a name="BKMK_ProcessState"></a> ProcessState

**Description**: State of the dialog process.<br />
**DisplayName**: Process State<br />
**LogicalName**: processstate<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: TextArea<br />
**IsLocalizable**: False<br />
**MaxLength**: 1073741823


### <a name="BKMK_RegardingObjectId"></a> RegardingObjectId

**Description**: Unique identifier of the object with which the dialog session is associated.<br />
**DisplayName**: Regarding<br />
**LogicalName**: regardingobjectid<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**IsValidForUpdate**: False<br />
**Type**: Lookup<br />
**Targets**: account,annotation,appointment,bookableresource,bookableresourcebooking,bookableresourcebookingheader,bookableresourcecategory,bookableresourcecategoryassn,bookableresourcecharacteristic,bookableresourcegroup,bookingstatus,businessunit,businessunitnewsarticle,campaign,campaignactivity,campaignresponse,channelaccessprofile,channelaccessprofilerule,characteristic,competitor,connection,connectionrole,constraintbasedgroup,contact,contract,contractdetail,contracttemplate,convertrule,customeraddress,customeropportunityrole,customerrelationship,discount,discounttype,email,entitlement,entitlementchannel,entitlementtemplate,equipment,expiredprocess,externalparty,externalpartyitem,fax,goal,goalrollupquery,incident,invoice,invoicedetail,kbarticle,kbarticlecomment,kbarticletemplate,knowledgearticle,knowledgearticleincident,knowledgebaserecord,lead,leadtoopportunitysalesprocess,letter,list,mailbox,mailmergetemplate,metric,msdyn_accountpricelist,msdyn_actual,msdyn_agreement,msdyn_agreementbookingdate,msdyn_agreementbookingincident,msdyn_agreementbookingproduct,msdyn_agreementbookingservice,msdyn_agreementbookingservicetask,msdyn_agreementbookingsetup,msdyn_agreementinvoicedate,msdyn_agreementinvoiceproduct,msdyn_agreementinvoicesetup,msdyn_agreementsubstatus,msdyn_approval,msdyn_batchjob,msdyn_bookingalert,msdyn_bookingalertstatus,msdyn_bookingchange,msdyn_bookingjournal,msdyn_bookingrule,msdyn_bookingsetupmetadata,msdyn_bookingtimestamp,msdyn_bpf_2c5fe86acc8b414b8322ae571000c799,msdyn_bpf_477c16f59170487b8b4dc895c5dcd09b,msdyn_bpf_665e73aa18c247d886bfc50499c73b82,msdyn_bpf_989e9b1857e24af18787d5143b67523b,msdyn_bpf_baa0a411a239410cb8bded8b5fdd88e3,msdyn_bpf_d3d97bac8c294105840e99e37a9d1c39,msdyn_bpf_d8f9dc7f099f44db9d641dd81fbd470d,msdyn_characteristicreqforteammember,msdyn_clientextension,msdyn_configuration,msdyn_contactpricelist,msdyn_contractlineinvoiceschedule,msdyn_contractlinescheduleofvalue,msdyn_customerasset,msdyn_dataexport,msdyn_delegation,msdyn_estimate,msdyn_estimateline,msdyn_expense,msdyn_expensecategory,msdyn_expensereceipt,msdyn_fact,msdyn_fieldcomputation,msdyn_fieldservicepricelistitem,msdyn_fieldservicesetting,msdyn_fieldservicesystemjob,msdyn_findworkevent,msdyn_incidenttype,msdyn_incidenttypecharacteristic,msdyn_incidenttypeproduct,msdyn_incidenttypeservice,msdyn_incidenttypeservicetask,msdyn_integrationjob,msdyn_integrationjobdetail,msdyn_inventoryadjustment,msdyn_inventoryadjustmentproduct,msdyn_inventoryjournal,msdyn_inventorytransfer,msdyn_invoicefrequency,msdyn_invoicefrequencydetail,msdyn_invoicelinetransaction,msdyn_iotalert,msdyn_iotdevice,msdyn_iotdevicecategory,msdyn_iotdevicecommand,msdyn_iotdeviceregistrationhistory,msdyn_journal,msdyn_journalline,msdyn_mlresultcache,msdyn_opportunitylineresourcecategory,msdyn_opportunitylinetransaction,msdyn_opportunitylinetransactioncategory,msdyn_opportunitylinetransactionclassificatio,msdyn_opportunitypricelist,msdyn_orderinvoicingdate,msdyn_orderinvoicingproduct,msdyn_orderinvoicingsetup,msdyn_orderinvoicingsetupdate,msdyn_orderlineresourcecategory,msdyn_orderlinetransaction,msdyn_orderlinetransactioncategory,msdyn_orderlinetransactionclassification,msdyn_orderpricelist,msdyn_organizationalunit,msdyn_payment,msdyn_paymentdetail,msdyn_paymentmethod,msdyn_paymentterm,msdyn_postalbum,msdyn_postalcode,msdyn_postconfig,msdyn_postruleconfig,msdyn_priority,msdyn_processnotes,msdyn_productinventory,msdyn_project,msdyn_projectapproval,msdyn_projectparameter,msdyn_projectparameterpricelist,msdyn_projectpricelist,msdyn_projecttask,msdyn_projecttaskdependency,msdyn_projecttaskstatususer,msdyn_projectteam,msdyn_projectteammembersignup,msdyn_projecttransactioncategory,msdyn_purchaseorder,msdyn_purchaseorderbill,msdyn_purchaseorderproduct,msdyn_purchaseorderreceipt,msdyn_purchaseorderreceiptproduct,msdyn_purchaseordersubstatus,msdyn_quotebookingincident,msdyn_quotebookingproduct,msdyn_quotebookingservice,msdyn_quotebookingservicetask,msdyn_quotebookingsetup,msdyn_quoteinvoicingproduct,msdyn_quoteinvoicingsetup,msdyn_quotelineanalyticsbreakdown,msdyn_quotelineinvoiceschedule,msdyn_quotelineresourcecategory,msdyn_quotelinescheduleofvalue,msdyn_quotelinetransaction,msdyn_quotelinetransactioncategory,msdyn_quotelinetransactionclassification,msdyn_quotepricelist,msdyn_requirementcharacteristic,msdyn_requirementorganizationunit,msdyn_requirementresourcecategory,msdyn_requirementresourcepreference,msdyn_requirementstatus,msdyn_resourceassignment,msdyn_resourceassignmentdetail,msdyn_resourcecategorypricelevel,msdyn_resourcepaytype,msdyn_resourcerequest,msdyn_resourcerequirement,msdyn_resourcerequirementdetail,msdyn_resourceterritory,msdyn_rma,msdyn_rmaproduct,msdyn_rmareceipt,msdyn_rmareceiptproduct,msdyn_rmasubstatus,msdyn_rolecompetencyrequirement,msdyn_roleutilization,msdyn_rtv,msdyn_rtvproduct,msdyn_rtvsubstatus,msdyn_scheduleboardsetting,msdyn_schedulingparameter,msdyn_servicetasktype,msdyn_shipvia,msdyn_systemuserschedulersetting,msdyn_taxcode,msdyn_taxcodedetail,msdyn_timeentry,msdyn_timegroup,msdyn_timegroupdetail,msdyn_timeoffcalendar,msdyn_timeoffrequest,msdyn_transactioncategory,msdyn_transactioncategoryclassification,msdyn_transactioncategoryhierarchyelement,msdyn_transactioncategorypricelevel,msdyn_transactionconnection,msdyn_transactionorigin,msdyn_transactiontype,msdyn_uniquenumber,msdyn_userworkhistory,msdyn_wallsavedquery,msdyn_wallsavedqueryusersettings,msdyn_warehouse,msdyn_workhourtemplate,msdyn_workorder,msdyn_workordercharacteristic,msdyn_workorderdetailsgenerationqueue,msdyn_workorderincident,msdyn_workorderproduct,msdyn_workorderresourcerestriction,msdyn_workorderservice,msdyn_workorderservicetask,msdyn_workordersubstatus,msdyn_workordertype,newprocess,opportunity,opportunityproduct,opportunitysalesprocess,phonecall,phonetocaseprocess,position,pricelevel,product,productassociation,productpricelevel,productsubstitute,queue,queueitem,quote,quotedetail,ratingmodel,ratingvalue,recurringappointmentmaster,relationshiprole,report,rollupfield,routingrule,routingruleitem,salesliterature,salesliteratureitem,salesorder,salesorderdetail,service,serviceappointment,sharepointdocumentlocation,sharepointsite,site,sla,socialactivity,socialprofile,subject,systemuser,task,team,template,territory,theme,transactioncurrency,translationprocess,usermapping


### <a name="BKMK_RegardingObjectIdName"></a> RegardingObjectIdName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: regardingobjectidname<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**IsValidForUpdate**: False<br />
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
**IsValidForUpdate**: False<br />
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
**IsValidForUpdate**: False<br />
**Type**: EntityName<br />


### <a name="BKMK_StartedOn"></a> StartedOn

**Description**: Date and time when the dialog session was started.<br />
**DisplayName**: Started On<br />
**LogicalName**: startedon<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**IsValidForUpdate**: False<br />
**Type**: DateTime<br />
**DateTimeBehavior**: UserLocal<br />
**Format**: DateAndTime


### <a name="BKMK_StateCode"></a> StateCode

**Description**: Status of the dialog session.<br />
**DisplayName**: Status<br />
**LogicalName**: statecode<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: SystemRequired<br />
**IsValidForCreate**: False<br />
**Type**: State<br />
**Options**:

- **Value**: 0 **Label**: Incomplete **DefaultStatus**: 1 **InvariantName**: Incomplete
- **Value**: 1 **Label**: Complete **DefaultStatus**: 2 **InvariantName**: Complete



### <a name="BKMK_StatusCode"></a> StatusCode

**Description**: Reason for the status of the dialog session.<br />
**DisplayName**: Status Reason<br />
**LogicalName**: statuscode<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Status<br />
**Options**:

- **Value**: 1 **Label**: Not Started **State**: 0
- **Value**: 2 **Label**: In Progress **State**: 0
- **Value**: 3 **Label**: Paused **State**: 0
- **Value**: 4 **Label**: Completed **State**: 1
- **Value**: 5 **Label**: Canceled **State**: 1
- **Value**: 6 **Label**: Failed **State**: 1



### <a name="BKMK_StepName"></a> StepName

**Description**: Name of the dialog step.<br />
**DisplayName**: Step Name<br />
**LogicalName**: stepname<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 256

<a name="read-only-attributes"></a>
## Read-only attributes
These attributes return false for both **IsValidForCreate** or **IsValidForUpdate**. Listed by **SchemaName**.

- [CanceledBy](#BKMK_CanceledBy)
- [CanceledByName](#BKMK_CanceledByName)
- [CanceledByYomiName](#BKMK_CanceledByYomiName)
- [CompletedBy](#BKMK_CompletedBy)
- [CompletedByName](#BKMK_CompletedByName)
- [CompletedByYomiName](#BKMK_CompletedByYomiName)
- [CreatedBy](#BKMK_CreatedBy)
- [CreatedByName](#BKMK_CreatedByName)
- [CreatedByYomiName](#BKMK_CreatedByYomiName)
- [CreatedOn](#BKMK_CreatedOn)
- [CreatedOnBehalfBy](#BKMK_CreatedOnBehalfBy)
- [CreatedOnBehalfByName](#BKMK_CreatedOnBehalfByName)
- [CreatedOnBehalfByYomiName](#BKMK_CreatedOnBehalfByYomiName)
- [ExecutedByName](#BKMK_ExecutedByName)
- [ExecutedByYomiName](#BKMK_ExecutedByYomiName)
- [ExecutedOn](#BKMK_ExecutedOn)
- [ModifiedBy](#BKMK_ModifiedBy)
- [ModifiedByName](#BKMK_ModifiedByName)
- [ModifiedByYomiName](#BKMK_ModifiedByYomiName)
- [ModifiedOn](#BKMK_ModifiedOn)
- [ModifiedOnBehalfBy](#BKMK_ModifiedOnBehalfBy)
- [ModifiedOnBehalfByName](#BKMK_ModifiedOnBehalfByName)
- [ModifiedOnBehalfByYomiName](#BKMK_ModifiedOnBehalfByYomiName)
- [NextLinkedSessionIdName](#BKMK_NextLinkedSessionIdName)
- [OriginatingSessionIdName](#BKMK_OriginatingSessionIdName)
- [OwnerIdName](#BKMK_OwnerIdName)
- [OwnerIdYomiName](#BKMK_OwnerIdYomiName)
- [OwningBusinessUnit](#BKMK_OwningBusinessUnit)
- [OwningTeam](#BKMK_OwningTeam)
- [OwningUser](#BKMK_OwningUser)
- [PreviousLinkedSessionIdName](#BKMK_PreviousLinkedSessionIdName)
- [ProcessIdName](#BKMK_ProcessIdName)
- [ProtectionKey](#BKMK_ProtectionKey)
- [StartedBy](#BKMK_StartedBy)
- [StartedByName](#BKMK_StartedByName)
- [StartedByYomiName](#BKMK_StartedByYomiName)


### <a name="BKMK_CanceledBy"></a> CanceledBy

**Description**: Unique identifier of the user who canceled the dialog session.<br />
**DisplayName**: Canceled By<br />
**LogicalName**: canceledby<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: systemuser


### <a name="BKMK_CanceledByName"></a> CanceledByName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: canceledbyname<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_CanceledByYomiName"></a> CanceledByYomiName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: canceledbyyominame<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_CompletedBy"></a> CompletedBy

**Description**: Unique identifier of the user who completed the dialog session.<br />
**DisplayName**: Completed By<br />
**LogicalName**: completedby<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: systemuser


### <a name="BKMK_CompletedByName"></a> CompletedByName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: completedbyname<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_CompletedByYomiName"></a> CompletedByYomiName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: completedbyyominame<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_CreatedBy"></a> CreatedBy

**Description**: Unique identifier of the user who started the dialog session.<br />
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

**Description**: Date and time when the dialog session was created.<br />
**DisplayName**: Created On<br />
**LogicalName**: createdon<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: DateTime<br />
**DateTimeBehavior**: UserLocal<br />
**Format**: DateAndTime


### <a name="BKMK_CreatedOnBehalfBy"></a> CreatedOnBehalfBy

**Description**: Unique identifier of the delegate user who created the dialog session.<br />
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


### <a name="BKMK_ExecutedByName"></a> ExecutedByName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: executedbyname<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_ExecutedByYomiName"></a> ExecutedByYomiName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: executedbyyominame<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_ExecutedOn"></a> ExecutedOn

**Description**: Date and time when the dialog process was run.<br />
**DisplayName**: Executed On<br />
**LogicalName**: executedon<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: DateTime<br />
**DateTimeBehavior**: UserLocal<br />
**Format**: DateAndTime


### <a name="BKMK_ModifiedBy"></a> ModifiedBy

**Description**: Unique identifier of the user who last modified the dialog session.<br />
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

**Description**: Date and time when the dialog session was last modified.<br />
**DisplayName**: Modified On<br />
**LogicalName**: modifiedon<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: DateTime<br />
**DateTimeBehavior**: UserLocal<br />
**Format**: DateAndTime


### <a name="BKMK_ModifiedOnBehalfBy"></a> ModifiedOnBehalfBy

**Description**: Unique identifier of the delegate user who modified the dialog session.<br />
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


### <a name="BKMK_NextLinkedSessionIdName"></a> NextLinkedSessionIdName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: nextlinkedsessionidname<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_OriginatingSessionIdName"></a> OriginatingSessionIdName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: originatingsessionidname<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


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

**Description**: Unique identifier of the business unit that owns the dialog session.<br />
**DisplayName**: Owning Business Unit<br />
**LogicalName**: owningbusinessunit<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: businessunit


### <a name="BKMK_OwningTeam"></a> OwningTeam

**Description**: Unique identifier of the team who owns the dialog session.<br />
**DisplayName**: Owning Team<br />
**LogicalName**: owningteam<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: team


### <a name="BKMK_OwningUser"></a> OwningUser

**Description**: Unique identifier of the user who owns the dialog session.<br />
**DisplayName**: Owning User<br />
**LogicalName**: owninguser<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: systemuser


### <a name="BKMK_PreviousLinkedSessionIdName"></a> PreviousLinkedSessionIdName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: previouslinkedsessionidname<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_ProcessIdName"></a> ProcessIdName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: processidname<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 160


### <a name="BKMK_ProtectionKey"></a> ProtectionKey

**Description**: For internal use only.<br />
**DisplayName**: Protection Key<br />
**LogicalName**: protectionkey<br />
**IsValidForForm**: False<br />
**IsValidForRead**: False<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: TextArea<br />
**IsLocalizable**: False<br />
**MaxLength**: 256


### <a name="BKMK_StartedBy"></a> StartedBy

**Description**: Unique identifier of the user who started the dialog session.<br />
**DisplayName**: Started By<br />
**LogicalName**: startedby<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: systemuser


### <a name="BKMK_StartedByName"></a> StartedByName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: startedbyname<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_StartedByYomiName"></a> StartedByYomiName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: startedbyyominame<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100

<a name="onetomany"></a>

## One-To-Many Relationships

Listed by **SchemaName**.

- [lk_workflowlog_processsession](#BKMK_lk_workflowlog_processsession)
- [lk_workflowlog_processsession_childworkflow](#BKMK_lk_workflowlog_processsession_childworkflow)
- [lk_processsession_previouslinkedsessionid](#BKMK_lk_processsession_previouslinkedsessionid)
- [lk_processsession_nextlinkedsessionid](#BKMK_lk_processsession_nextlinkedsessionid)
- [lk_processsession_originatingsessionid](#BKMK_lk_processsession_originatingsessionid)
- [processsession_connections2](#BKMK_processsession_connections2)
- [ProcessSession_SyncErrors](#BKMK_ProcessSession_SyncErrors)
- [processsession_connections1](#BKMK_processsession_connections1)
- [processsession_PostFollows](#BKMK_processsession_PostFollows)
- [userentityinstancedata_processsession](#BKMK_userentityinstancedata_processsession)


### <a name="BKMK_lk_workflowlog_processsession"></a> lk_workflowlog_processsession

Same as workflowlog entity [lk_workflowlog_processsession](workflowlog.md#BKMK_lk_workflowlog_processsession) Many-To-One relationship.

**ReferencingEntity**: workflowlog<br />
**ReferencingAttribute**: asyncoperationid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: False<br />
**ReferencedEntityNavigationPropertyName**: lk_workflowlog_processsession<br />
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


### <a name="BKMK_lk_workflowlog_processsession_childworkflow"></a> lk_workflowlog_processsession_childworkflow

Same as workflowlog entity [lk_workflowlog_processsession_childworkflow](workflowlog.md#BKMK_lk_workflowlog_processsession_childworkflow) Many-To-One relationship.

**ReferencingEntity**: workflowlog<br />
**ReferencingAttribute**: childworkflowinstanceid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: False<br />
**ReferencedEntityNavigationPropertyName**: lk_workflowlog_processsession_childworkflow<br />
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


### <a name="BKMK_lk_processsession_previouslinkedsessionid"></a> lk_processsession_previouslinkedsessionid

Same as processsession entity [lk_processsession_previouslinkedsessionid](processsession.md#BKMK_lk_processsession_previouslinkedsessionid) Many-To-One relationship.

**ReferencingEntity**: processsession<br />
**ReferencingAttribute**: previouslinkedsessionid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: False<br />
**ReferencedEntityNavigationPropertyName**: lk_processsession_previouslinkedsessionid<br />
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


### <a name="BKMK_lk_processsession_nextlinkedsessionid"></a> lk_processsession_nextlinkedsessionid

Same as processsession entity [lk_processsession_nextlinkedsessionid](processsession.md#BKMK_lk_processsession_nextlinkedsessionid) Many-To-One relationship.

**ReferencingEntity**: processsession<br />
**ReferencingAttribute**: nextlinkedsessionid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: False<br />
**ReferencedEntityNavigationPropertyName**: lk_processsession_nextlinkedsessionid<br />
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


### <a name="BKMK_lk_processsession_originatingsessionid"></a> lk_processsession_originatingsessionid

Same as processsession entity [lk_processsession_originatingsessionid](processsession.md#BKMK_lk_processsession_originatingsessionid) Many-To-One relationship.

**ReferencingEntity**: processsession<br />
**ReferencingAttribute**: originatingsessionid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: False<br />
**ReferencedEntityNavigationPropertyName**: lk_processsession_originatingsessionid<br />
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


### <a name="BKMK_processsession_connections2"></a> processsession_connections2

Same as connection entity [processsession_connections2](connection.md#BKMK_processsession_connections2) Many-To-One relationship.

**ReferencingEntity**: connection<br />
**ReferencingAttribute**: record2id<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: processsession_connections2<br />
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


### <a name="BKMK_ProcessSession_SyncErrors"></a> ProcessSession_SyncErrors

Same as syncerror entity [ProcessSession_SyncErrors](syncerror.md#BKMK_ProcessSession_SyncErrors) Many-To-One relationship.

**ReferencingEntity**: syncerror<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: ProcessSession_SyncErrors<br />
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


### <a name="BKMK_processsession_connections1"></a> processsession_connections1

Same as connection entity [processsession_connections1](connection.md#BKMK_processsession_connections1) Many-To-One relationship.

**ReferencingEntity**: connection<br />
**ReferencingAttribute**: record1id<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: processsession_connections1<br />
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


### <a name="BKMK_processsession_PostFollows"></a> processsession_PostFollows

Same as postfollow entity [processsession_PostFollows](postfollow.md#BKMK_processsession_PostFollows) Many-To-One relationship.

**ReferencingEntity**: postfollow<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: False<br />
**ReferencedEntityNavigationPropertyName**: processsession_PostFollows<br />
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


### <a name="BKMK_userentityinstancedata_processsession"></a> userentityinstancedata_processsession

Same as userentityinstancedata entity [userentityinstancedata_processsession](userentityinstancedata.md#BKMK_userentityinstancedata_processsession) Many-To-One relationship.

**ReferencingEntity**: userentityinstancedata<br />
**ReferencingAttribute**: objectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: False<br />
**ReferencedEntityNavigationPropertyName**: userentityinstancedata_processsession<br />
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

- [msdyn_iotalert_ProcessSession](#BKMK_msdyn_iotalert_ProcessSession)
- [msdyn_iotdevice_ProcessSession](#BKMK_msdyn_iotdevice_ProcessSession)
- [msdyn_iotdevicecategory_ProcessSession](#BKMK_msdyn_iotdevicecategory_ProcessSession)
- [msdyn_iotdevicecommand_ProcessSession](#BKMK_msdyn_iotdevicecommand_ProcessSession)
- [msdyn_iotdeviceregistrationhistory_ProcessSession](#BKMK_msdyn_iotdeviceregistrationhistory_ProcessSession)
- [msdyn_bpf_477c16f59170487b8b4dc895c5dcd09b_ProcessSession](#BKMK_msdyn_bpf_477c16f59170487b8b4dc895c5dcd09b_ProcessSession)
- [Territory_ProcessSessions](#BKMK_Territory_ProcessSessions)
- [Lead_ProcessSessions](#BKMK_Lead_ProcessSessions)
- [PriceLevel_ProcessSessions](#BKMK_PriceLevel_ProcessSessions)
- [Product_ProcessSessions](#BKMK_Product_ProcessSessions)
- [ProductAssociation_ProcessSessions](#BKMK_ProductAssociation_ProcessSessions)
- [ProductPriceLevel_ProcessSessions](#BKMK_ProductPriceLevel_ProcessSessions)
- [ProductSubstitute_ProcessSession](#BKMK_ProductSubstitute_ProcessSession)
- [bookableresource_ProcessSession](#BKMK_bookableresource_ProcessSession)
- [bookableresourcebooking_ProcessSession](#BKMK_bookableresourcebooking_ProcessSession)
- [bookableresourcebookingheader_ProcessSession](#BKMK_bookableresourcebookingheader_ProcessSession)
- [bookableresourcecategory_ProcessSession](#BKMK_bookableresourcecategory_ProcessSession)
- [bookableresourcecategoryassn_ProcessSession](#BKMK_bookableresourcecategoryassn_ProcessSession)
- [bookableresourcecharacteristic_ProcessSession](#BKMK_bookableresourcecharacteristic_ProcessSession)
- [bookableresourcegroup_ProcessSession](#BKMK_bookableresourcegroup_ProcessSession)
- [bookingstatus_ProcessSession](#BKMK_bookingstatus_ProcessSession)
- [characteristic_ProcessSession](#BKMK_characteristic_ProcessSession)
- [ratingmodel_ProcessSession](#BKMK_ratingmodel_ProcessSession)
- [ratingvalue_ProcessSession](#BKMK_ratingvalue_ProcessSession)
- [Campaign_ProcessSessions](#BKMK_Campaign_ProcessSessions)
- [CampaignActivity_ProcessSessions](#BKMK_CampaignActivity_ProcessSessions)
- [CampaignResponse_ProcessSessions](#BKMK_CampaignResponse_ProcessSessions)
- [List_ProcessSessions](#BKMK_List_ProcessSessions)
- [ConstraintBasedGroup_ProcessSessions](#BKMK_ConstraintBasedGroup_ProcessSessions)
- [Contract_ProcessSessions](#BKMK_Contract_ProcessSessions)
- [ContractDetail_ProcessSessions](#BKMK_ContractDetail_ProcessSessions)
- [ContractTemplate_ProcessSessions](#BKMK_ContractTemplate_ProcessSessions)
- [entitlement_ProcessSession](#BKMK_entitlement_ProcessSession)
- [entitlementtemplate_ProcessSession](#BKMK_entitlementtemplate_ProcessSession)
- [Equipment_ProcessSessions](#BKMK_Equipment_ProcessSessions)
- [Incident_ProcessSessions](#BKMK_Incident_ProcessSessions)
- [knowledgearticleincident_ProcessSession](#BKMK_knowledgearticleincident_ProcessSession)
- [phonetocaseprocess_ProcessSession](#BKMK_phonetocaseprocess_ProcessSession)
- [Service_ProcessSessions](#BKMK_Service_ProcessSessions)
- [ServiceAppointment_ProcessSessions](#BKMK_ServiceAppointment_ProcessSessions)
- [Site_ProcessSessions](#BKMK_Site_ProcessSessions)
- [entitlementchannel_ProcessSession](#BKMK_entitlementchannel_ProcessSession)
- [CustomerOpportunityRole_ProcessSessions](#BKMK_CustomerOpportunityRole_ProcessSessions)
- [Discount_ProcessSessions](#BKMK_Discount_ProcessSessions)
- [DiscountType_ProcessSessions](#BKMK_DiscountType_ProcessSessions)
- [Invoice_ProcessSessions](#BKMK_Invoice_ProcessSessions)
- [InvoiceDetail_ProcessSessions](#BKMK_InvoiceDetail_ProcessSessions)
- [leadtoopportunitysalesprocess_ProcessSession](#BKMK_leadtoopportunitysalesprocess_ProcessSession)
- [Opportunity_ProcessSessions](#BKMK_Opportunity_ProcessSessions)
- [OpportunityProduct_ProcessSessions](#BKMK_OpportunityProduct_ProcessSessions)
- [opportunitysalesprocess_ProcessSession](#BKMK_opportunitysalesprocess_ProcessSession)
- [Quote_ProcessSessions](#BKMK_Quote_ProcessSessions)
- [QuoteDetail_ProcessSessions](#BKMK_QuoteDetail_ProcessSessions)
- [SalesLiterature_ProcessSessions](#BKMK_SalesLiterature_ProcessSessions)
- [SalesLiteratureItem_ProcessSessions](#BKMK_SalesLiteratureItem_ProcessSessions)
- [SalesOrder_ProcessSessions](#BKMK_SalesOrder_ProcessSessions)
- [SalesOrderDetail_ProcessSessions](#BKMK_SalesOrderDetail_ProcessSessions)
- [Competitor_ProcessSessions](#BKMK_Competitor_ProcessSessions)
- [msdyn_postalbum_ProcessSession](#BKMK_msdyn_postalbum_ProcessSession)
- [msdyn_postconfig_ProcessSession](#BKMK_msdyn_postconfig_ProcessSession)
- [msdyn_postruleconfig_ProcessSession](#BKMK_msdyn_postruleconfig_ProcessSession)
- [msdyn_wallsavedquery_ProcessSession](#BKMK_msdyn_wallsavedquery_ProcessSession)
- [msdyn_wallsavedqueryusersettings_ProcessSession](#BKMK_msdyn_wallsavedqueryusersettings_ProcessSession)
- [msdyn_actual_ProcessSession](#BKMK_msdyn_actual_ProcessSession)
- [msdyn_bookingalert_ProcessSession](#BKMK_msdyn_bookingalert_ProcessSession)
- [msdyn_bookingalertstatus_ProcessSession](#BKMK_msdyn_bookingalertstatus_ProcessSession)
- [msdyn_bookingchange_ProcessSession](#BKMK_msdyn_bookingchange_ProcessSession)
- [msdyn_bookingrule_ProcessSession](#BKMK_msdyn_bookingrule_ProcessSession)
- [msdyn_bookingsetupmetadata_ProcessSession](#BKMK_msdyn_bookingsetupmetadata_ProcessSession)
- [msdyn_clientextension_ProcessSession](#BKMK_msdyn_clientextension_ProcessSession)
- [msdyn_configuration_ProcessSession](#BKMK_msdyn_configuration_ProcessSession)
- [msdyn_organizationalunit_ProcessSession](#BKMK_msdyn_organizationalunit_ProcessSession)
- [msdyn_priority_ProcessSession](#BKMK_msdyn_priority_ProcessSession)
- [msdyn_requirementcharacteristic_ProcessSession](#BKMK_msdyn_requirementcharacteristic_ProcessSession)
- [msdyn_requirementorganizationunit_ProcessSession](#BKMK_msdyn_requirementorganizationunit_ProcessSession)
- [msdyn_requirementresourcecategory_ProcessSession](#BKMK_msdyn_requirementresourcecategory_ProcessSession)
- [msdyn_requirementresourcepreference_ProcessSession](#BKMK_msdyn_requirementresourcepreference_ProcessSession)
- [msdyn_requirementstatus_ProcessSession](#BKMK_msdyn_requirementstatus_ProcessSession)
- [msdyn_resourcerequirement_ProcessSession](#BKMK_msdyn_resourcerequirement_ProcessSession)
- [msdyn_resourcerequirementdetail_ProcessSession](#BKMK_msdyn_resourcerequirementdetail_ProcessSession)
- [msdyn_resourceterritory_ProcessSession](#BKMK_msdyn_resourceterritory_ProcessSession)
- [msdyn_scheduleboardsetting_ProcessSession](#BKMK_msdyn_scheduleboardsetting_ProcessSession)
- [msdyn_schedulingparameter_ProcessSession](#BKMK_msdyn_schedulingparameter_ProcessSession)
- [msdyn_systemuserschedulersetting_ProcessSession](#BKMK_msdyn_systemuserschedulersetting_ProcessSession)
- [msdyn_timegroup_ProcessSession](#BKMK_msdyn_timegroup_ProcessSession)
- [msdyn_timegroupdetail_ProcessSession](#BKMK_msdyn_timegroupdetail_ProcessSession)
- [msdyn_transactionorigin_ProcessSession](#BKMK_msdyn_transactionorigin_ProcessSession)
- [msdyn_workhourtemplate_ProcessSession](#BKMK_msdyn_workhourtemplate_ProcessSession)
- [msdyn_accountpricelist_ProcessSession](#BKMK_msdyn_accountpricelist_ProcessSession)
- [msdyn_approval_ProcessSession](#BKMK_msdyn_approval_ProcessSession)
- [msdyn_batchjob_ProcessSession](#BKMK_msdyn_batchjob_ProcessSession)
- [msdyn_bpf_665e73aa18c247d886bfc50499c73b82_ProcessSession](#BKMK_msdyn_bpf_665e73aa18c247d886bfc50499c73b82_ProcessSession)
- [msdyn_bpf_d8f9dc7f099f44db9d641dd81fbd470d_ProcessSession](#BKMK_msdyn_bpf_d8f9dc7f099f44db9d641dd81fbd470d_ProcessSession)
- [msdyn_characteristicreqforteammember_ProcessSession](#BKMK_msdyn_characteristicreqforteammember_ProcessSession)
- [msdyn_contactpricelist_ProcessSession](#BKMK_msdyn_contactpricelist_ProcessSession)
- [msdyn_contractlineinvoiceschedule_ProcessSession](#BKMK_msdyn_contractlineinvoiceschedule_ProcessSession)
- [msdyn_contractlinescheduleofvalue_ProcessSession](#BKMK_msdyn_contractlinescheduleofvalue_ProcessSession)
- [msdyn_dataexport_ProcessSession](#BKMK_msdyn_dataexport_ProcessSession)
- [msdyn_delegation_ProcessSession](#BKMK_msdyn_delegation_ProcessSession)
- [msdyn_estimate_ProcessSession](#BKMK_msdyn_estimate_ProcessSession)
- [msdyn_estimateline_ProcessSession](#BKMK_msdyn_estimateline_ProcessSession)
- [msdyn_expense_ProcessSession](#BKMK_msdyn_expense_ProcessSession)
- [msdyn_expensecategory_ProcessSession](#BKMK_msdyn_expensecategory_ProcessSession)
- [msdyn_expensereceipt_ProcessSession](#BKMK_msdyn_expensereceipt_ProcessSession)
- [msdyn_fact_ProcessSession](#BKMK_msdyn_fact_ProcessSession)
- [msdyn_fieldcomputation_ProcessSession](#BKMK_msdyn_fieldcomputation_ProcessSession)
- [msdyn_findworkevent_ProcessSession](#BKMK_msdyn_findworkevent_ProcessSession)
- [msdyn_integrationjob_ProcessSession](#BKMK_msdyn_integrationjob_ProcessSession)
- [msdyn_integrationjobdetail_ProcessSession](#BKMK_msdyn_integrationjobdetail_ProcessSession)
- [msdyn_invoicefrequency_ProcessSession](#BKMK_msdyn_invoicefrequency_ProcessSession)
- [msdyn_invoicefrequencydetail_ProcessSession](#BKMK_msdyn_invoicefrequencydetail_ProcessSession)
- [msdyn_invoicelinetransaction_ProcessSession](#BKMK_msdyn_invoicelinetransaction_ProcessSession)
- [msdyn_journal_ProcessSession](#BKMK_msdyn_journal_ProcessSession)
- [msdyn_journalline_ProcessSession](#BKMK_msdyn_journalline_ProcessSession)
- [msdyn_mlresultcache_ProcessSession](#BKMK_msdyn_mlresultcache_ProcessSession)
- [msdyn_opportunitylineresourcecategory_ProcessSession](#BKMK_msdyn_opportunitylineresourcecategory_ProcessSession)
- [msdyn_opportunitylinetransaction_ProcessSession](#BKMK_msdyn_opportunitylinetransaction_ProcessSession)
- [msdyn_opportunitylinetransactioncategory_ProcessSession](#BKMK_msdyn_opportunitylinetransactioncategory_ProcessSession)
- [msdyn_opportunitylinetransactionclassificatio_ProcessSession](#BKMK_msdyn_opportunitylinetransactionclassificatio_ProcessSession)
- [msdyn_opportunitypricelist_ProcessSession](#BKMK_msdyn_opportunitypricelist_ProcessSession)
- [msdyn_orderlineresourcecategory_ProcessSession](#BKMK_msdyn_orderlineresourcecategory_ProcessSession)
- [msdyn_orderlinetransaction_ProcessSession](#BKMK_msdyn_orderlinetransaction_ProcessSession)
- [msdyn_orderlinetransactioncategory_ProcessSession](#BKMK_msdyn_orderlinetransactioncategory_ProcessSession)
- [msdyn_orderlinetransactionclassification_ProcessSession](#BKMK_msdyn_orderlinetransactionclassification_ProcessSession)
- [msdyn_orderpricelist_ProcessSession](#BKMK_msdyn_orderpricelist_ProcessSession)
- [msdyn_processnotes_ProcessSession](#BKMK_msdyn_processnotes_ProcessSession)
- [msdyn_project_ProcessSession](#BKMK_msdyn_project_ProcessSession)
- [msdyn_projectapproval_ProcessSession](#BKMK_msdyn_projectapproval_ProcessSession)
- [msdyn_projectparameter_ProcessSession](#BKMK_msdyn_projectparameter_ProcessSession)
- [msdyn_projectparameterpricelist_ProcessSession](#BKMK_msdyn_projectparameterpricelist_ProcessSession)
- [msdyn_projectpricelist_ProcessSession](#BKMK_msdyn_projectpricelist_ProcessSession)
- [msdyn_projecttask_ProcessSession](#BKMK_msdyn_projecttask_ProcessSession)
- [msdyn_projecttaskdependency_ProcessSession](#BKMK_msdyn_projecttaskdependency_ProcessSession)
- [msdyn_projecttaskstatususer_ProcessSession](#BKMK_msdyn_projecttaskstatususer_ProcessSession)
- [msdyn_projectteam_ProcessSession](#BKMK_msdyn_projectteam_ProcessSession)
- [msdyn_projectteammembersignup_ProcessSession](#BKMK_msdyn_projectteammembersignup_ProcessSession)
- [msdyn_projecttransactioncategory_ProcessSession](#BKMK_msdyn_projecttransactioncategory_ProcessSession)
- [msdyn_quotelineanalyticsbreakdown_ProcessSession](#BKMK_msdyn_quotelineanalyticsbreakdown_ProcessSession)
- [msdyn_quotelineinvoiceschedule_ProcessSession](#BKMK_msdyn_quotelineinvoiceschedule_ProcessSession)
- [msdyn_quotelineresourcecategory_ProcessSession](#BKMK_msdyn_quotelineresourcecategory_ProcessSession)
- [msdyn_quotelinescheduleofvalue_ProcessSession](#BKMK_msdyn_quotelinescheduleofvalue_ProcessSession)
- [msdyn_quotelinetransaction_ProcessSession](#BKMK_msdyn_quotelinetransaction_ProcessSession)
- [msdyn_quotelinetransactioncategory_ProcessSession](#BKMK_msdyn_quotelinetransactioncategory_ProcessSession)
- [msdyn_quotelinetransactionclassification_ProcessSession](#BKMK_msdyn_quotelinetransactionclassification_ProcessSession)
- [msdyn_quotepricelist_ProcessSession](#BKMK_msdyn_quotepricelist_ProcessSession)
- [msdyn_resourceassignment_ProcessSession](#BKMK_msdyn_resourceassignment_ProcessSession)
- [msdyn_resourceassignmentdetail_ProcessSession](#BKMK_msdyn_resourceassignmentdetail_ProcessSession)
- [msdyn_resourcecategorypricelevel_ProcessSession](#BKMK_msdyn_resourcecategorypricelevel_ProcessSession)
- [msdyn_resourcerequest_ProcessSession](#BKMK_msdyn_resourcerequest_ProcessSession)
- [msdyn_rolecompetencyrequirement_ProcessSession](#BKMK_msdyn_rolecompetencyrequirement_ProcessSession)
- [msdyn_roleutilization_ProcessSession](#BKMK_msdyn_roleutilization_ProcessSession)
- [msdyn_timeentry_ProcessSession](#BKMK_msdyn_timeentry_ProcessSession)
- [msdyn_timeoffcalendar_ProcessSession](#BKMK_msdyn_timeoffcalendar_ProcessSession)
- [msdyn_transactioncategory_ProcessSession](#BKMK_msdyn_transactioncategory_ProcessSession)
- [msdyn_transactioncategoryclassification_ProcessSession](#BKMK_msdyn_transactioncategoryclassification_ProcessSession)
- [msdyn_transactioncategoryhierarchyelement_ProcessSession](#BKMK_msdyn_transactioncategoryhierarchyelement_ProcessSession)
- [msdyn_transactioncategorypricelevel_ProcessSession](#BKMK_msdyn_transactioncategorypricelevel_ProcessSession)
- [msdyn_transactionconnection_ProcessSession](#BKMK_msdyn_transactionconnection_ProcessSession)
- [msdyn_transactiontype_ProcessSession](#BKMK_msdyn_transactiontype_ProcessSession)
- [msdyn_userworkhistory_ProcessSession](#BKMK_msdyn_userworkhistory_ProcessSession)
- [msdyn_agreement_ProcessSession](#BKMK_msdyn_agreement_ProcessSession)
- [msdyn_agreementbookingdate_ProcessSession](#BKMK_msdyn_agreementbookingdate_ProcessSession)
- [msdyn_agreementbookingincident_ProcessSession](#BKMK_msdyn_agreementbookingincident_ProcessSession)
- [msdyn_agreementbookingproduct_ProcessSession](#BKMK_msdyn_agreementbookingproduct_ProcessSession)
- [msdyn_agreementbookingservice_ProcessSession](#BKMK_msdyn_agreementbookingservice_ProcessSession)
- [msdyn_agreementbookingservicetask_ProcessSession](#BKMK_msdyn_agreementbookingservicetask_ProcessSession)
- [msdyn_agreementbookingsetup_ProcessSession](#BKMK_msdyn_agreementbookingsetup_ProcessSession)
- [msdyn_agreementinvoicedate_ProcessSession](#BKMK_msdyn_agreementinvoicedate_ProcessSession)
- [msdyn_agreementinvoiceproduct_ProcessSession](#BKMK_msdyn_agreementinvoiceproduct_ProcessSession)
- [msdyn_agreementinvoicesetup_ProcessSession](#BKMK_msdyn_agreementinvoicesetup_ProcessSession)
- [msdyn_agreementsubstatus_ProcessSession](#BKMK_msdyn_agreementsubstatus_ProcessSession)
- [msdyn_bookingjournal_ProcessSession](#BKMK_msdyn_bookingjournal_ProcessSession)
- [msdyn_bookingtimestamp_ProcessSession](#BKMK_msdyn_bookingtimestamp_ProcessSession)
- [msdyn_bpf_2c5fe86acc8b414b8322ae571000c799_ProcessSession](#BKMK_msdyn_bpf_2c5fe86acc8b414b8322ae571000c799_ProcessSession)
- [msdyn_bpf_989e9b1857e24af18787d5143b67523b_ProcessSession](#BKMK_msdyn_bpf_989e9b1857e24af18787d5143b67523b_ProcessSession)
- [msdyn_bpf_baa0a411a239410cb8bded8b5fdd88e3_ProcessSession](#BKMK_msdyn_bpf_baa0a411a239410cb8bded8b5fdd88e3_ProcessSession)
- [msdyn_bpf_d3d97bac8c294105840e99e37a9d1c39_ProcessSession](#BKMK_msdyn_bpf_d3d97bac8c294105840e99e37a9d1c39_ProcessSession)
- [msdyn_customerasset_ProcessSession](#BKMK_msdyn_customerasset_ProcessSession)
- [msdyn_fieldservicepricelistitem_ProcessSession](#BKMK_msdyn_fieldservicepricelistitem_ProcessSession)
- [msdyn_fieldservicesetting_ProcessSession](#BKMK_msdyn_fieldservicesetting_ProcessSession)
- [msdyn_fieldservicesystemjob_ProcessSession](#BKMK_msdyn_fieldservicesystemjob_ProcessSession)
- [msdyn_incidenttype_ProcessSession](#BKMK_msdyn_incidenttype_ProcessSession)
- [msdyn_incidenttypecharacteristic_ProcessSession](#BKMK_msdyn_incidenttypecharacteristic_ProcessSession)
- [msdyn_incidenttypeproduct_ProcessSession](#BKMK_msdyn_incidenttypeproduct_ProcessSession)
- [msdyn_incidenttypeservice_ProcessSession](#BKMK_msdyn_incidenttypeservice_ProcessSession)
- [msdyn_incidenttypeservicetask_ProcessSession](#BKMK_msdyn_incidenttypeservicetask_ProcessSession)
- [msdyn_inventoryadjustment_ProcessSession](#BKMK_msdyn_inventoryadjustment_ProcessSession)
- [msdyn_inventoryadjustmentproduct_ProcessSession](#BKMK_msdyn_inventoryadjustmentproduct_ProcessSession)
- [msdyn_inventoryjournal_ProcessSession](#BKMK_msdyn_inventoryjournal_ProcessSession)
- [msdyn_inventorytransfer_ProcessSession](#BKMK_msdyn_inventorytransfer_ProcessSession)
- [msdyn_orderinvoicingdate_ProcessSession](#BKMK_msdyn_orderinvoicingdate_ProcessSession)
- [msdyn_orderinvoicingproduct_ProcessSession](#BKMK_msdyn_orderinvoicingproduct_ProcessSession)
- [msdyn_orderinvoicingsetup_ProcessSession](#BKMK_msdyn_orderinvoicingsetup_ProcessSession)
- [msdyn_orderinvoicingsetupdate_ProcessSession](#BKMK_msdyn_orderinvoicingsetupdate_ProcessSession)
- [msdyn_payment_ProcessSession](#BKMK_msdyn_payment_ProcessSession)
- [msdyn_paymentdetail_ProcessSession](#BKMK_msdyn_paymentdetail_ProcessSession)
- [msdyn_paymentmethod_ProcessSession](#BKMK_msdyn_paymentmethod_ProcessSession)
- [msdyn_paymentterm_ProcessSession](#BKMK_msdyn_paymentterm_ProcessSession)
- [msdyn_postalcode_ProcessSession](#BKMK_msdyn_postalcode_ProcessSession)
- [msdyn_productinventory_ProcessSession](#BKMK_msdyn_productinventory_ProcessSession)
- [msdyn_purchaseorder_ProcessSession](#BKMK_msdyn_purchaseorder_ProcessSession)
- [msdyn_purchaseorderbill_ProcessSession](#BKMK_msdyn_purchaseorderbill_ProcessSession)
- [msdyn_purchaseorderproduct_ProcessSession](#BKMK_msdyn_purchaseorderproduct_ProcessSession)
- [msdyn_purchaseorderreceipt_ProcessSession](#BKMK_msdyn_purchaseorderreceipt_ProcessSession)
- [msdyn_purchaseorderreceiptproduct_ProcessSession](#BKMK_msdyn_purchaseorderreceiptproduct_ProcessSession)
- [msdyn_purchaseordersubstatus_ProcessSession](#BKMK_msdyn_purchaseordersubstatus_ProcessSession)
- [msdyn_quotebookingincident_ProcessSession](#BKMK_msdyn_quotebookingincident_ProcessSession)
- [msdyn_quotebookingproduct_ProcessSession](#BKMK_msdyn_quotebookingproduct_ProcessSession)
- [msdyn_quotebookingservice_ProcessSession](#BKMK_msdyn_quotebookingservice_ProcessSession)
- [msdyn_quotebookingservicetask_ProcessSession](#BKMK_msdyn_quotebookingservicetask_ProcessSession)
- [msdyn_quotebookingsetup_ProcessSession](#BKMK_msdyn_quotebookingsetup_ProcessSession)
- [msdyn_quoteinvoicingproduct_ProcessSession](#BKMK_msdyn_quoteinvoicingproduct_ProcessSession)
- [msdyn_quoteinvoicingsetup_ProcessSession](#BKMK_msdyn_quoteinvoicingsetup_ProcessSession)
- [msdyn_resourcepaytype_ProcessSession](#BKMK_msdyn_resourcepaytype_ProcessSession)
- [msdyn_rma_ProcessSession](#BKMK_msdyn_rma_ProcessSession)
- [msdyn_rmaproduct_ProcessSession](#BKMK_msdyn_rmaproduct_ProcessSession)
- [msdyn_rmareceipt_ProcessSession](#BKMK_msdyn_rmareceipt_ProcessSession)
- [msdyn_rmareceiptproduct_ProcessSession](#BKMK_msdyn_rmareceiptproduct_ProcessSession)
- [msdyn_rmasubstatus_ProcessSession](#BKMK_msdyn_rmasubstatus_ProcessSession)
- [msdyn_rtv_ProcessSession](#BKMK_msdyn_rtv_ProcessSession)
- [msdyn_rtvproduct_ProcessSession](#BKMK_msdyn_rtvproduct_ProcessSession)
- [msdyn_rtvsubstatus_ProcessSession](#BKMK_msdyn_rtvsubstatus_ProcessSession)
- [msdyn_servicetasktype_ProcessSession](#BKMK_msdyn_servicetasktype_ProcessSession)
- [msdyn_shipvia_ProcessSession](#BKMK_msdyn_shipvia_ProcessSession)
- [msdyn_taxcode_ProcessSession](#BKMK_msdyn_taxcode_ProcessSession)
- [msdyn_taxcodedetail_ProcessSession](#BKMK_msdyn_taxcodedetail_ProcessSession)
- [msdyn_timeoffrequest_ProcessSession](#BKMK_msdyn_timeoffrequest_ProcessSession)
- [msdyn_uniquenumber_ProcessSession](#BKMK_msdyn_uniquenumber_ProcessSession)
- [msdyn_warehouse_ProcessSession](#BKMK_msdyn_warehouse_ProcessSession)
- [msdyn_workorder_ProcessSession](#BKMK_msdyn_workorder_ProcessSession)
- [msdyn_workordercharacteristic_ProcessSession](#BKMK_msdyn_workordercharacteristic_ProcessSession)
- [msdyn_workorderdetailsgenerationqueue_ProcessSession](#BKMK_msdyn_workorderdetailsgenerationqueue_ProcessSession)
- [msdyn_workorderincident_ProcessSession](#BKMK_msdyn_workorderincident_ProcessSession)
- [msdyn_workorderproduct_ProcessSession](#BKMK_msdyn_workorderproduct_ProcessSession)
- [msdyn_workorderresourcerestriction_ProcessSession](#BKMK_msdyn_workorderresourcerestriction_ProcessSession)
- [msdyn_workorderservice_ProcessSession](#BKMK_msdyn_workorderservice_ProcessSession)
- [msdyn_workorderservicetask_ProcessSession](#BKMK_msdyn_workorderservicetask_ProcessSession)
- [msdyn_workordersubstatus_ProcessSession](#BKMK_msdyn_workordersubstatus_ProcessSession)
- [msdyn_workordertype_ProcessSession](#BKMK_msdyn_workordertype_ProcessSession)
- [theme_ProcessSession](#BKMK_theme_ProcessSession)
- [usermapping_ProcessSession](#BKMK_usermapping_ProcessSession)
- [knowledgearticle_ProcessSession](#BKMK_knowledgearticle_ProcessSession)
- [position_ProcessSession](#BKMK_position_ProcessSession)
- [channelaccessprofile_ProcessSession](#BKMK_channelaccessprofile_ProcessSession)
- [externalparty_ProcessSession](#BKMK_externalparty_ProcessSession)
- [profilerule_ProcessSession](#BKMK_profilerule_ProcessSession)
- [KnowledgeBaseRecord_ProcessSession](#BKMK_KnowledgeBaseRecord_ProcessSession)
- [SharePointSite_ProcessSessions](#BKMK_SharePointSite_ProcessSessions)
- [MailMergeTemplate_ProcessSessions](#BKMK_MailMergeTemplate_ProcessSessions)
- [Annotation_ProcessSessions](#BKMK_Annotation_ProcessSessions)
- [routingrule_ProcessSessions](#BKMK_routingrule_ProcessSessions)
- [BusinessUnitNewsArticle_ProcessSessions](#BKMK_BusinessUnitNewsArticle_ProcessSessions)
- [Appointment_ProcessSessions](#BKMK_Appointment_ProcessSessions)
- [QueueItem_ProcessSessions](#BKMK_QueueItem_ProcessSessions)
- [lk_processsession_previouslinkedsessionid](#BKMK_lk_processsession_previouslinkedsessionid)
- [lk_processsession_nextlinkedsessionid](#BKMK_lk_processsession_nextlinkedsessionid)
- [lk_processsession_originatingsessionid](#BKMK_lk_processsession_originatingsessionid)
- [Team_ProcessSessions](#BKMK_Team_ProcessSessions)
- [Goal_ProcessSessions](#BKMK_Goal_ProcessSessions)
- [mailbox_processsessions](#BKMK_mailbox_processsessions)
- [TranslationProcess_ProcessSessions](#BKMK_TranslationProcess_ProcessSessions)
- [SystemUser_ProcessSessions](#BKMK_SystemUser_ProcessSessions)
- [BusinessUnit_ProcessSessions](#BKMK_BusinessUnit_ProcessSessions)
- [KbArticleComment_ProcessSessions](#BKMK_KbArticleComment_ProcessSessions)
- [lk_processsession_canceledby](#BKMK_lk_processsession_canceledby)
- [goalrollupquery_ProcessSessions](#BKMK_goalrollupquery_ProcessSessions)
- [rollupfield_ProcessSessions](#BKMK_rollupfield_ProcessSessions)
- [ConvertRule_ProcessSessions](#BKMK_ConvertRule_ProcessSessions)
- [SharePointDocumentLocation_ProcessSessions](#BKMK_SharePointDocumentLocation_ProcessSessions)
- [lk_processsession_startedby](#BKMK_lk_processsession_startedby)
- [Account_ProcessSessions](#BKMK_Account_ProcessSessions)
- [PhoneCall_ProcessSessions](#BKMK_PhoneCall_ProcessSessions)
- [externalpartyitem_ProcessSession](#BKMK_externalpartyitem_ProcessSession)
- [slabase_ProcessSessions](#BKMK_slabase_ProcessSessions)
- [lk_processsession_createdby](#BKMK_lk_processsession_createdby)
- [lk_processsessionbase_modifiedonbehalfby](#BKMK_lk_processsessionbase_modifiedonbehalfby)
- [Template_ProcessSessions](#BKMK_Template_ProcessSessions)
- [NewProcess_ProcessSessions](#BKMK_NewProcess_ProcessSessions)
- [Report_ProcessSessions](#BKMK_Report_ProcessSessions)
- [Owning_businessunit_processsessions](#BKMK_Owning_businessunit_processsessions)
- [CustomerAddress_ProcessSessions](#BKMK_CustomerAddress_ProcessSessions)
- [Connection_ProcessSessions](#BKMK_Connection_ProcessSessions)
- [lk_processsession_executedby](#BKMK_lk_processsession_executedby)
- [team_processsession](#BKMK_team_processsession)
- [metric_ProcessSessions](#BKMK_metric_ProcessSessions)
- [ExpiredProcess_ProcessSessions](#BKMK_ExpiredProcess_ProcessSessions)
- [KbArticle_ProcessSessions](#BKMK_KbArticle_ProcessSessions)
- [SocialActivity_ProcessSessions](#BKMK_SocialActivity_ProcessSessions)
- [Task_ProcessSessions](#BKMK_Task_ProcessSessions)
- [lk_processsession_processid](#BKMK_lk_processsession_processid)
- [lk_processsession_modifiedby](#BKMK_lk_processsession_modifiedby)
- [ConnectionRole_ProcessSessions](#BKMK_ConnectionRole_ProcessSessions)
- [TransactionCurrency_ProcessSessions](#BKMK_TransactionCurrency_ProcessSessions)
- [Fax_ProcessSessions](#BKMK_Fax_ProcessSessions)
- [KbArticleTemplate_ProcessSessions](#BKMK_KbArticleTemplate_ProcessSessions)
- [Letter_ProcessSessions](#BKMK_Letter_ProcessSessions)
- [RelationshipRole_ProcessSessions](#BKMK_RelationshipRole_ProcessSessions)
- [CustomerRelationship_ProcessSessions](#BKMK_CustomerRelationship_ProcessSessions)
- [RecurringAppointmentMaster_ProcessSessions](#BKMK_RecurringAppointmentMaster_ProcessSessions)
- [Email_ProcessSessions](#BKMK_Email_ProcessSessions)
- [lk_processsession_completedby](#BKMK_lk_processsession_completedby)
- [Contact_ProcessSessions](#BKMK_Contact_ProcessSessions)
- [Queue_ProcessSessions](#BKMK_Queue_ProcessSessions)
- [lk_processsessionbase_createdonbehalfby](#BKMK_lk_processsessionbase_createdonbehalfby)
- [routingruleitem_ProcessSessions](#BKMK_routingruleitem_ProcessSessions)
- [Subject_ProcessSessions](#BKMK_Subject_ProcessSessions)
- [SocialProfile_ProcessSessions](#BKMK_SocialProfile_ProcessSessions)


### <a name="BKMK_msdyn_iotalert_ProcessSession"></a> msdyn_iotalert_ProcessSession

See msdyn_iotalert Entity [msdyn_iotalert_ProcessSession](msdyn_iotalert.md#BKMK_msdyn_iotalert_ProcessSession) One-To-Many relationship.

### <a name="BKMK_msdyn_iotdevice_ProcessSession"></a> msdyn_iotdevice_ProcessSession

See msdyn_iotdevice Entity [msdyn_iotdevice_ProcessSession](msdyn_iotdevice.md#BKMK_msdyn_iotdevice_ProcessSession) One-To-Many relationship.

### <a name="BKMK_msdyn_iotdevicecategory_ProcessSession"></a> msdyn_iotdevicecategory_ProcessSession

See msdyn_iotdevicecategory Entity [msdyn_iotdevicecategory_ProcessSession](msdyn_iotdevicecategory.md#BKMK_msdyn_iotdevicecategory_ProcessSession) One-To-Many relationship.

### <a name="BKMK_msdyn_iotdevicecommand_ProcessSession"></a> msdyn_iotdevicecommand_ProcessSession

See msdyn_iotdevicecommand Entity [msdyn_iotdevicecommand_ProcessSession](msdyn_iotdevicecommand.md#BKMK_msdyn_iotdevicecommand_ProcessSession) One-To-Many relationship.

### <a name="BKMK_msdyn_iotdeviceregistrationhistory_ProcessSession"></a> msdyn_iotdeviceregistrationhistory_ProcessSession

See msdyn_iotdeviceregistrationhistory Entity [msdyn_iotdeviceregistrationhistory_ProcessSession](msdyn_iotdeviceregistrationhistory.md#BKMK_msdyn_iotdeviceregistrationhistory_ProcessSession) One-To-Many relationship.

### <a name="BKMK_msdyn_bpf_477c16f59170487b8b4dc895c5dcd09b_ProcessSession"></a> msdyn_bpf_477c16f59170487b8b4dc895c5dcd09b_ProcessSession

See msdyn_bpf_477c16f59170487b8b4dc895c5dcd09b Entity [msdyn_bpf_477c16f59170487b8b4dc895c5dcd09b_ProcessSession](msdyn_bpf_477c16f59170487b8b4dc895c5dcd09b.md#BKMK_msdyn_bpf_477c16f59170487b8b4dc895c5dcd09b_ProcessSession) One-To-Many relationship.

### <a name="BKMK_Territory_ProcessSessions"></a> Territory_ProcessSessions

See territory Entity [Territory_ProcessSessions](territory.md#BKMK_Territory_ProcessSessions) One-To-Many relationship.

### <a name="BKMK_Lead_ProcessSessions"></a> Lead_ProcessSessions

See lead Entity [Lead_ProcessSessions](lead.md#BKMK_Lead_ProcessSessions) One-To-Many relationship.

### <a name="BKMK_PriceLevel_ProcessSessions"></a> PriceLevel_ProcessSessions

See pricelevel Entity [PriceLevel_ProcessSessions](pricelevel.md#BKMK_PriceLevel_ProcessSessions) One-To-Many relationship.

### <a name="BKMK_Product_ProcessSessions"></a> Product_ProcessSessions

See product Entity [Product_ProcessSessions](product.md#BKMK_Product_ProcessSessions) One-To-Many relationship.

### <a name="BKMK_ProductAssociation_ProcessSessions"></a> ProductAssociation_ProcessSessions

See productassociation Entity [ProductAssociation_ProcessSessions](productassociation.md#BKMK_ProductAssociation_ProcessSessions) One-To-Many relationship.

### <a name="BKMK_ProductPriceLevel_ProcessSessions"></a> ProductPriceLevel_ProcessSessions

See productpricelevel Entity [ProductPriceLevel_ProcessSessions](productpricelevel.md#BKMK_ProductPriceLevel_ProcessSessions) One-To-Many relationship.

### <a name="BKMK_ProductSubstitute_ProcessSession"></a> ProductSubstitute_ProcessSession

See productsubstitute Entity [ProductSubstitute_ProcessSession](productsubstitute.md#BKMK_ProductSubstitute_ProcessSession) One-To-Many relationship.

### <a name="BKMK_bookableresource_ProcessSession"></a> bookableresource_ProcessSession

See bookableresource Entity [bookableresource_ProcessSession](bookableresource.md#BKMK_bookableresource_ProcessSession) One-To-Many relationship.

### <a name="BKMK_bookableresourcebooking_ProcessSession"></a> bookableresourcebooking_ProcessSession

See bookableresourcebooking Entity [bookableresourcebooking_ProcessSession](bookableresourcebooking.md#BKMK_bookableresourcebooking_ProcessSession) One-To-Many relationship.

### <a name="BKMK_bookableresourcebookingheader_ProcessSession"></a> bookableresourcebookingheader_ProcessSession

See bookableresourcebookingheader Entity [bookableresourcebookingheader_ProcessSession](bookableresourcebookingheader.md#BKMK_bookableresourcebookingheader_ProcessSession) One-To-Many relationship.

### <a name="BKMK_bookableresourcecategory_ProcessSession"></a> bookableresourcecategory_ProcessSession

See bookableresourcecategory Entity [bookableresourcecategory_ProcessSession](bookableresourcecategory.md#BKMK_bookableresourcecategory_ProcessSession) One-To-Many relationship.

### <a name="BKMK_bookableresourcecategoryassn_ProcessSession"></a> bookableresourcecategoryassn_ProcessSession

See bookableresourcecategoryassn Entity [bookableresourcecategoryassn_ProcessSession](bookableresourcecategoryassn.md#BKMK_bookableresourcecategoryassn_ProcessSession) One-To-Many relationship.

### <a name="BKMK_bookableresourcecharacteristic_ProcessSession"></a> bookableresourcecharacteristic_ProcessSession

See bookableresourcecharacteristic Entity [bookableresourcecharacteristic_ProcessSession](bookableresourcecharacteristic.md#BKMK_bookableresourcecharacteristic_ProcessSession) One-To-Many relationship.

### <a name="BKMK_bookableresourcegroup_ProcessSession"></a> bookableresourcegroup_ProcessSession

See bookableresourcegroup Entity [bookableresourcegroup_ProcessSession](bookableresourcegroup.md#BKMK_bookableresourcegroup_ProcessSession) One-To-Many relationship.

### <a name="BKMK_bookingstatus_ProcessSession"></a> bookingstatus_ProcessSession

See bookingstatus Entity [bookingstatus_ProcessSession](bookingstatus.md#BKMK_bookingstatus_ProcessSession) One-To-Many relationship.

### <a name="BKMK_characteristic_ProcessSession"></a> characteristic_ProcessSession

See characteristic Entity [characteristic_ProcessSession](characteristic.md#BKMK_characteristic_ProcessSession) One-To-Many relationship.

### <a name="BKMK_ratingmodel_ProcessSession"></a> ratingmodel_ProcessSession

See ratingmodel Entity [ratingmodel_ProcessSession](ratingmodel.md#BKMK_ratingmodel_ProcessSession) One-To-Many relationship.

### <a name="BKMK_ratingvalue_ProcessSession"></a> ratingvalue_ProcessSession

See ratingvalue Entity [ratingvalue_ProcessSession](ratingvalue.md#BKMK_ratingvalue_ProcessSession) One-To-Many relationship.

### <a name="BKMK_Campaign_ProcessSessions"></a> Campaign_ProcessSessions

See campaign Entity [Campaign_ProcessSessions](campaign.md#BKMK_Campaign_ProcessSessions) One-To-Many relationship.

### <a name="BKMK_CampaignActivity_ProcessSessions"></a> CampaignActivity_ProcessSessions

See campaignactivity Entity [CampaignActivity_ProcessSessions](campaignactivity.md#BKMK_CampaignActivity_ProcessSessions) One-To-Many relationship.

### <a name="BKMK_CampaignResponse_ProcessSessions"></a> CampaignResponse_ProcessSessions

See campaignresponse Entity [CampaignResponse_ProcessSessions](campaignresponse.md#BKMK_CampaignResponse_ProcessSessions) One-To-Many relationship.

### <a name="BKMK_List_ProcessSessions"></a> List_ProcessSessions

See list Entity [List_ProcessSessions](list.md#BKMK_List_ProcessSessions) One-To-Many relationship.

### <a name="BKMK_ConstraintBasedGroup_ProcessSessions"></a> ConstraintBasedGroup_ProcessSessions

See constraintbasedgroup Entity [ConstraintBasedGroup_ProcessSessions](constraintbasedgroup.md#BKMK_ConstraintBasedGroup_ProcessSessions) One-To-Many relationship.

### <a name="BKMK_Contract_ProcessSessions"></a> Contract_ProcessSessions

See contract Entity [Contract_ProcessSessions](contract.md#BKMK_Contract_ProcessSessions) One-To-Many relationship.

### <a name="BKMK_ContractDetail_ProcessSessions"></a> ContractDetail_ProcessSessions

See contractdetail Entity [ContractDetail_ProcessSessions](contractdetail.md#BKMK_ContractDetail_ProcessSessions) One-To-Many relationship.

### <a name="BKMK_ContractTemplate_ProcessSessions"></a> ContractTemplate_ProcessSessions

See contracttemplate Entity [ContractTemplate_ProcessSessions](contracttemplate.md#BKMK_ContractTemplate_ProcessSessions) One-To-Many relationship.

### <a name="BKMK_entitlement_ProcessSession"></a> entitlement_ProcessSession

See entitlement Entity [entitlement_ProcessSession](entitlement.md#BKMK_entitlement_ProcessSession) One-To-Many relationship.

### <a name="BKMK_entitlementtemplate_ProcessSession"></a> entitlementtemplate_ProcessSession

See entitlementtemplate Entity [entitlementtemplate_ProcessSession](entitlementtemplate.md#BKMK_entitlementtemplate_ProcessSession) One-To-Many relationship.

### <a name="BKMK_Equipment_ProcessSessions"></a> Equipment_ProcessSessions

See equipment Entity [Equipment_ProcessSessions](equipment.md#BKMK_Equipment_ProcessSessions) One-To-Many relationship.

### <a name="BKMK_Incident_ProcessSessions"></a> Incident_ProcessSessions

See incident Entity [Incident_ProcessSessions](incident.md#BKMK_Incident_ProcessSessions) One-To-Many relationship.

### <a name="BKMK_knowledgearticleincident_ProcessSession"></a> knowledgearticleincident_ProcessSession

See knowledgearticleincident Entity [knowledgearticleincident_ProcessSession](knowledgearticleincident.md#BKMK_knowledgearticleincident_ProcessSession) One-To-Many relationship.

### <a name="BKMK_phonetocaseprocess_ProcessSession"></a> phonetocaseprocess_ProcessSession

See phonetocaseprocess Entity [phonetocaseprocess_ProcessSession](phonetocaseprocess.md#BKMK_phonetocaseprocess_ProcessSession) One-To-Many relationship.

### <a name="BKMK_Service_ProcessSessions"></a> Service_ProcessSessions

See service Entity [Service_ProcessSessions](service.md#BKMK_Service_ProcessSessions) One-To-Many relationship.

### <a name="BKMK_ServiceAppointment_ProcessSessions"></a> ServiceAppointment_ProcessSessions

See serviceappointment Entity [ServiceAppointment_ProcessSessions](serviceappointment.md#BKMK_ServiceAppointment_ProcessSessions) One-To-Many relationship.

### <a name="BKMK_Site_ProcessSessions"></a> Site_ProcessSessions

See site Entity [Site_ProcessSessions](site.md#BKMK_Site_ProcessSessions) One-To-Many relationship.

### <a name="BKMK_entitlementchannel_ProcessSession"></a> entitlementchannel_ProcessSession

See entitlementchannel Entity [entitlementchannel_ProcessSession](entitlementchannel.md#BKMK_entitlementchannel_ProcessSession) One-To-Many relationship.

### <a name="BKMK_CustomerOpportunityRole_ProcessSessions"></a> CustomerOpportunityRole_ProcessSessions

See customeropportunityrole Entity [CustomerOpportunityRole_ProcessSessions](customeropportunityrole.md#BKMK_CustomerOpportunityRole_ProcessSessions) One-To-Many relationship.

### <a name="BKMK_Discount_ProcessSessions"></a> Discount_ProcessSessions

See discount Entity [Discount_ProcessSessions](discount.md#BKMK_Discount_ProcessSessions) One-To-Many relationship.

### <a name="BKMK_DiscountType_ProcessSessions"></a> DiscountType_ProcessSessions

See discounttype Entity [DiscountType_ProcessSessions](discounttype.md#BKMK_DiscountType_ProcessSessions) One-To-Many relationship.

### <a name="BKMK_Invoice_ProcessSessions"></a> Invoice_ProcessSessions

See invoice Entity [Invoice_ProcessSessions](invoice.md#BKMK_Invoice_ProcessSessions) One-To-Many relationship.

### <a name="BKMK_InvoiceDetail_ProcessSessions"></a> InvoiceDetail_ProcessSessions

See invoicedetail Entity [InvoiceDetail_ProcessSessions](invoicedetail.md#BKMK_InvoiceDetail_ProcessSessions) One-To-Many relationship.

### <a name="BKMK_leadtoopportunitysalesprocess_ProcessSession"></a> leadtoopportunitysalesprocess_ProcessSession

See leadtoopportunitysalesprocess Entity [leadtoopportunitysalesprocess_ProcessSession](leadtoopportunitysalesprocess.md#BKMK_leadtoopportunitysalesprocess_ProcessSession) One-To-Many relationship.

### <a name="BKMK_Opportunity_ProcessSessions"></a> Opportunity_ProcessSessions

See opportunity Entity [Opportunity_ProcessSessions](opportunity.md#BKMK_Opportunity_ProcessSessions) One-To-Many relationship.

### <a name="BKMK_OpportunityProduct_ProcessSessions"></a> OpportunityProduct_ProcessSessions

See opportunityproduct Entity [OpportunityProduct_ProcessSessions](opportunityproduct.md#BKMK_OpportunityProduct_ProcessSessions) One-To-Many relationship.

### <a name="BKMK_opportunitysalesprocess_ProcessSession"></a> opportunitysalesprocess_ProcessSession

See opportunitysalesprocess Entity [opportunitysalesprocess_ProcessSession](opportunitysalesprocess.md#BKMK_opportunitysalesprocess_ProcessSession) One-To-Many relationship.

### <a name="BKMK_Quote_ProcessSessions"></a> Quote_ProcessSessions

See quote Entity [Quote_ProcessSessions](quote.md#BKMK_Quote_ProcessSessions) One-To-Many relationship.

### <a name="BKMK_QuoteDetail_ProcessSessions"></a> QuoteDetail_ProcessSessions

See quotedetail Entity [QuoteDetail_ProcessSessions](quotedetail.md#BKMK_QuoteDetail_ProcessSessions) One-To-Many relationship.

### <a name="BKMK_SalesLiterature_ProcessSessions"></a> SalesLiterature_ProcessSessions

See salesliterature Entity [SalesLiterature_ProcessSessions](salesliterature.md#BKMK_SalesLiterature_ProcessSessions) One-To-Many relationship.

### <a name="BKMK_SalesLiteratureItem_ProcessSessions"></a> SalesLiteratureItem_ProcessSessions

See salesliteratureitem Entity [SalesLiteratureItem_ProcessSessions](salesliteratureitem.md#BKMK_SalesLiteratureItem_ProcessSessions) One-To-Many relationship.

### <a name="BKMK_SalesOrder_ProcessSessions"></a> SalesOrder_ProcessSessions

See salesorder Entity [SalesOrder_ProcessSessions](salesorder.md#BKMK_SalesOrder_ProcessSessions) One-To-Many relationship.

### <a name="BKMK_SalesOrderDetail_ProcessSessions"></a> SalesOrderDetail_ProcessSessions

See salesorderdetail Entity [SalesOrderDetail_ProcessSessions](salesorderdetail.md#BKMK_SalesOrderDetail_ProcessSessions) One-To-Many relationship.

### <a name="BKMK_Competitor_ProcessSessions"></a> Competitor_ProcessSessions

See competitor Entity [Competitor_ProcessSessions](competitor.md#BKMK_Competitor_ProcessSessions) One-To-Many relationship.

### <a name="BKMK_msdyn_postalbum_ProcessSession"></a> msdyn_postalbum_ProcessSession

See msdyn_postalbum Entity [msdyn_postalbum_ProcessSession](msdyn_postalbum.md#BKMK_msdyn_postalbum_ProcessSession) One-To-Many relationship.

### <a name="BKMK_msdyn_postconfig_ProcessSession"></a> msdyn_postconfig_ProcessSession

See msdyn_postconfig Entity [msdyn_postconfig_ProcessSession](msdyn_postconfig.md#BKMK_msdyn_postconfig_ProcessSession) One-To-Many relationship.

### <a name="BKMK_msdyn_postruleconfig_ProcessSession"></a> msdyn_postruleconfig_ProcessSession

See msdyn_postruleconfig Entity [msdyn_postruleconfig_ProcessSession](msdyn_postruleconfig.md#BKMK_msdyn_postruleconfig_ProcessSession) One-To-Many relationship.

### <a name="BKMK_msdyn_wallsavedquery_ProcessSession"></a> msdyn_wallsavedquery_ProcessSession

See msdyn_wallsavedquery Entity [msdyn_wallsavedquery_ProcessSession](msdyn_wallsavedquery.md#BKMK_msdyn_wallsavedquery_ProcessSession) One-To-Many relationship.

### <a name="BKMK_msdyn_wallsavedqueryusersettings_ProcessSession"></a> msdyn_wallsavedqueryusersettings_ProcessSession

See msdyn_wallsavedqueryusersettings Entity [msdyn_wallsavedqueryusersettings_ProcessSession](msdyn_wallsavedqueryusersettings.md#BKMK_msdyn_wallsavedqueryusersettings_ProcessSession) One-To-Many relationship.

### <a name="BKMK_msdyn_actual_ProcessSession"></a> msdyn_actual_ProcessSession

See msdyn_actual Entity [msdyn_actual_ProcessSession](msdyn_actual.md#BKMK_msdyn_actual_ProcessSession) One-To-Many relationship.

### <a name="BKMK_msdyn_bookingalert_ProcessSession"></a> msdyn_bookingalert_ProcessSession

See msdyn_bookingalert Entity [msdyn_bookingalert_ProcessSession](msdyn_bookingalert.md#BKMK_msdyn_bookingalert_ProcessSession) One-To-Many relationship.

### <a name="BKMK_msdyn_bookingalertstatus_ProcessSession"></a> msdyn_bookingalertstatus_ProcessSession

See msdyn_bookingalertstatus Entity [msdyn_bookingalertstatus_ProcessSession](msdyn_bookingalertstatus.md#BKMK_msdyn_bookingalertstatus_ProcessSession) One-To-Many relationship.

### <a name="BKMK_msdyn_bookingchange_ProcessSession"></a> msdyn_bookingchange_ProcessSession

See msdyn_bookingchange Entity [msdyn_bookingchange_ProcessSession](msdyn_bookingchange.md#BKMK_msdyn_bookingchange_ProcessSession) One-To-Many relationship.

### <a name="BKMK_msdyn_bookingrule_ProcessSession"></a> msdyn_bookingrule_ProcessSession

See msdyn_bookingrule Entity [msdyn_bookingrule_ProcessSession](msdyn_bookingrule.md#BKMK_msdyn_bookingrule_ProcessSession) One-To-Many relationship.

### <a name="BKMK_msdyn_bookingsetupmetadata_ProcessSession"></a> msdyn_bookingsetupmetadata_ProcessSession

See msdyn_bookingsetupmetadata Entity [msdyn_bookingsetupmetadata_ProcessSession](msdyn_bookingsetupmetadata.md#BKMK_msdyn_bookingsetupmetadata_ProcessSession) One-To-Many relationship.

### <a name="BKMK_msdyn_clientextension_ProcessSession"></a> msdyn_clientextension_ProcessSession

See msdyn_clientextension Entity [msdyn_clientextension_ProcessSession](msdyn_clientextension.md#BKMK_msdyn_clientextension_ProcessSession) One-To-Many relationship.

### <a name="BKMK_msdyn_configuration_ProcessSession"></a> msdyn_configuration_ProcessSession

See msdyn_configuration Entity [msdyn_configuration_ProcessSession](msdyn_configuration.md#BKMK_msdyn_configuration_ProcessSession) One-To-Many relationship.

### <a name="BKMK_msdyn_organizationalunit_ProcessSession"></a> msdyn_organizationalunit_ProcessSession

See msdyn_organizationalunit Entity [msdyn_organizationalunit_ProcessSession](msdyn_organizationalunit.md#BKMK_msdyn_organizationalunit_ProcessSession) One-To-Many relationship.

### <a name="BKMK_msdyn_priority_ProcessSession"></a> msdyn_priority_ProcessSession

See msdyn_priority Entity [msdyn_priority_ProcessSession](msdyn_priority.md#BKMK_msdyn_priority_ProcessSession) One-To-Many relationship.

### <a name="BKMK_msdyn_requirementcharacteristic_ProcessSession"></a> msdyn_requirementcharacteristic_ProcessSession

See msdyn_requirementcharacteristic Entity [msdyn_requirementcharacteristic_ProcessSession](msdyn_requirementcharacteristic.md#BKMK_msdyn_requirementcharacteristic_ProcessSession) One-To-Many relationship.

### <a name="BKMK_msdyn_requirementorganizationunit_ProcessSession"></a> msdyn_requirementorganizationunit_ProcessSession

See msdyn_requirementorganizationunit Entity [msdyn_requirementorganizationunit_ProcessSession](msdyn_requirementorganizationunit.md#BKMK_msdyn_requirementorganizationunit_ProcessSession) One-To-Many relationship.

### <a name="BKMK_msdyn_requirementresourcecategory_ProcessSession"></a> msdyn_requirementresourcecategory_ProcessSession

See msdyn_requirementresourcecategory Entity [msdyn_requirementresourcecategory_ProcessSession](msdyn_requirementresourcecategory.md#BKMK_msdyn_requirementresourcecategory_ProcessSession) One-To-Many relationship.

### <a name="BKMK_msdyn_requirementresourcepreference_ProcessSession"></a> msdyn_requirementresourcepreference_ProcessSession

See msdyn_requirementresourcepreference Entity [msdyn_requirementresourcepreference_ProcessSession](msdyn_requirementresourcepreference.md#BKMK_msdyn_requirementresourcepreference_ProcessSession) One-To-Many relationship.

### <a name="BKMK_msdyn_requirementstatus_ProcessSession"></a> msdyn_requirementstatus_ProcessSession

See msdyn_requirementstatus Entity [msdyn_requirementstatus_ProcessSession](msdyn_requirementstatus.md#BKMK_msdyn_requirementstatus_ProcessSession) One-To-Many relationship.

### <a name="BKMK_msdyn_resourcerequirement_ProcessSession"></a> msdyn_resourcerequirement_ProcessSession

See msdyn_resourcerequirement Entity [msdyn_resourcerequirement_ProcessSession](msdyn_resourcerequirement.md#BKMK_msdyn_resourcerequirement_ProcessSession) One-To-Many relationship.

### <a name="BKMK_msdyn_resourcerequirementdetail_ProcessSession"></a> msdyn_resourcerequirementdetail_ProcessSession

See msdyn_resourcerequirementdetail Entity [msdyn_resourcerequirementdetail_ProcessSession](msdyn_resourcerequirementdetail.md#BKMK_msdyn_resourcerequirementdetail_ProcessSession) One-To-Many relationship.

### <a name="BKMK_msdyn_resourceterritory_ProcessSession"></a> msdyn_resourceterritory_ProcessSession

See msdyn_resourceterritory Entity [msdyn_resourceterritory_ProcessSession](msdyn_resourceterritory.md#BKMK_msdyn_resourceterritory_ProcessSession) One-To-Many relationship.

### <a name="BKMK_msdyn_scheduleboardsetting_ProcessSession"></a> msdyn_scheduleboardsetting_ProcessSession

See msdyn_scheduleboardsetting Entity [msdyn_scheduleboardsetting_ProcessSession](msdyn_scheduleboardsetting.md#BKMK_msdyn_scheduleboardsetting_ProcessSession) One-To-Many relationship.

### <a name="BKMK_msdyn_schedulingparameter_ProcessSession"></a> msdyn_schedulingparameter_ProcessSession

See msdyn_schedulingparameter Entity [msdyn_schedulingparameter_ProcessSession](msdyn_schedulingparameter.md#BKMK_msdyn_schedulingparameter_ProcessSession) One-To-Many relationship.

### <a name="BKMK_msdyn_systemuserschedulersetting_ProcessSession"></a> msdyn_systemuserschedulersetting_ProcessSession

See msdyn_systemuserschedulersetting Entity [msdyn_systemuserschedulersetting_ProcessSession](msdyn_systemuserschedulersetting.md#BKMK_msdyn_systemuserschedulersetting_ProcessSession) One-To-Many relationship.

### <a name="BKMK_msdyn_timegroup_ProcessSession"></a> msdyn_timegroup_ProcessSession

See msdyn_timegroup Entity [msdyn_timegroup_ProcessSession](msdyn_timegroup.md#BKMK_msdyn_timegroup_ProcessSession) One-To-Many relationship.

### <a name="BKMK_msdyn_timegroupdetail_ProcessSession"></a> msdyn_timegroupdetail_ProcessSession

See msdyn_timegroupdetail Entity [msdyn_timegroupdetail_ProcessSession](msdyn_timegroupdetail.md#BKMK_msdyn_timegroupdetail_ProcessSession) One-To-Many relationship.

### <a name="BKMK_msdyn_transactionorigin_ProcessSession"></a> msdyn_transactionorigin_ProcessSession

See msdyn_transactionorigin Entity [msdyn_transactionorigin_ProcessSession](msdyn_transactionorigin.md#BKMK_msdyn_transactionorigin_ProcessSession) One-To-Many relationship.

### <a name="BKMK_msdyn_workhourtemplate_ProcessSession"></a> msdyn_workhourtemplate_ProcessSession

See msdyn_workhourtemplate Entity [msdyn_workhourtemplate_ProcessSession](msdyn_workhourtemplate.md#BKMK_msdyn_workhourtemplate_ProcessSession) One-To-Many relationship.

### <a name="BKMK_msdyn_accountpricelist_ProcessSession"></a> msdyn_accountpricelist_ProcessSession

See msdyn_accountpricelist Entity [msdyn_accountpricelist_ProcessSession](msdyn_accountpricelist.md#BKMK_msdyn_accountpricelist_ProcessSession) One-To-Many relationship.

### <a name="BKMK_msdyn_approval_ProcessSession"></a> msdyn_approval_ProcessSession

See msdyn_approval Entity [msdyn_approval_ProcessSession](msdyn_approval.md#BKMK_msdyn_approval_ProcessSession) One-To-Many relationship.

### <a name="BKMK_msdyn_batchjob_ProcessSession"></a> msdyn_batchjob_ProcessSession

See msdyn_batchjob Entity [msdyn_batchjob_ProcessSession](msdyn_batchjob.md#BKMK_msdyn_batchjob_ProcessSession) One-To-Many relationship.

### <a name="BKMK_msdyn_bpf_665e73aa18c247d886bfc50499c73b82_ProcessSession"></a> msdyn_bpf_665e73aa18c247d886bfc50499c73b82_ProcessSession

See msdyn_bpf_665e73aa18c247d886bfc50499c73b82 Entity [msdyn_bpf_665e73aa18c247d886bfc50499c73b82_ProcessSession](msdyn_bpf_665e73aa18c247d886bfc50499c73b82.md#BKMK_msdyn_bpf_665e73aa18c247d886bfc50499c73b82_ProcessSession) One-To-Many relationship.

### <a name="BKMK_msdyn_bpf_d8f9dc7f099f44db9d641dd81fbd470d_ProcessSession"></a> msdyn_bpf_d8f9dc7f099f44db9d641dd81fbd470d_ProcessSession

See msdyn_bpf_d8f9dc7f099f44db9d641dd81fbd470d Entity [msdyn_bpf_d8f9dc7f099f44db9d641dd81fbd470d_ProcessSession](msdyn_bpf_d8f9dc7f099f44db9d641dd81fbd470d.md#BKMK_msdyn_bpf_d8f9dc7f099f44db9d641dd81fbd470d_ProcessSession) One-To-Many relationship.

### <a name="BKMK_msdyn_characteristicreqforteammember_ProcessSession"></a> msdyn_characteristicreqforteammember_ProcessSession

See msdyn_characteristicreqforteammember Entity [msdyn_characteristicreqforteammember_ProcessSession](msdyn_characteristicreqforteammember.md#BKMK_msdyn_characteristicreqforteammember_ProcessSession) One-To-Many relationship.

### <a name="BKMK_msdyn_contactpricelist_ProcessSession"></a> msdyn_contactpricelist_ProcessSession

See msdyn_contactpricelist Entity [msdyn_contactpricelist_ProcessSession](msdyn_contactpricelist.md#BKMK_msdyn_contactpricelist_ProcessSession) One-To-Many relationship.

### <a name="BKMK_msdyn_contractlineinvoiceschedule_ProcessSession"></a> msdyn_contractlineinvoiceschedule_ProcessSession

See msdyn_contractlineinvoiceschedule Entity [msdyn_contractlineinvoiceschedule_ProcessSession](msdyn_contractlineinvoiceschedule.md#BKMK_msdyn_contractlineinvoiceschedule_ProcessSession) One-To-Many relationship.

### <a name="BKMK_msdyn_contractlinescheduleofvalue_ProcessSession"></a> msdyn_contractlinescheduleofvalue_ProcessSession

See msdyn_contractlinescheduleofvalue Entity [msdyn_contractlinescheduleofvalue_ProcessSession](msdyn_contractlinescheduleofvalue.md#BKMK_msdyn_contractlinescheduleofvalue_ProcessSession) One-To-Many relationship.

### <a name="BKMK_msdyn_dataexport_ProcessSession"></a> msdyn_dataexport_ProcessSession

See msdyn_dataexport Entity [msdyn_dataexport_ProcessSession](msdyn_dataexport.md#BKMK_msdyn_dataexport_ProcessSession) One-To-Many relationship.

### <a name="BKMK_msdyn_delegation_ProcessSession"></a> msdyn_delegation_ProcessSession

See msdyn_delegation Entity [msdyn_delegation_ProcessSession](msdyn_delegation.md#BKMK_msdyn_delegation_ProcessSession) One-To-Many relationship.

### <a name="BKMK_msdyn_estimate_ProcessSession"></a> msdyn_estimate_ProcessSession

See msdyn_estimate Entity [msdyn_estimate_ProcessSession](msdyn_estimate.md#BKMK_msdyn_estimate_ProcessSession) One-To-Many relationship.

### <a name="BKMK_msdyn_estimateline_ProcessSession"></a> msdyn_estimateline_ProcessSession

See msdyn_estimateline Entity [msdyn_estimateline_ProcessSession](msdyn_estimateline.md#BKMK_msdyn_estimateline_ProcessSession) One-To-Many relationship.

### <a name="BKMK_msdyn_expense_ProcessSession"></a> msdyn_expense_ProcessSession

See msdyn_expense Entity [msdyn_expense_ProcessSession](msdyn_expense.md#BKMK_msdyn_expense_ProcessSession) One-To-Many relationship.

### <a name="BKMK_msdyn_expensecategory_ProcessSession"></a> msdyn_expensecategory_ProcessSession

See msdyn_expensecategory Entity [msdyn_expensecategory_ProcessSession](msdyn_expensecategory.md#BKMK_msdyn_expensecategory_ProcessSession) One-To-Many relationship.

### <a name="BKMK_msdyn_expensereceipt_ProcessSession"></a> msdyn_expensereceipt_ProcessSession

See msdyn_expensereceipt Entity [msdyn_expensereceipt_ProcessSession](msdyn_expensereceipt.md#BKMK_msdyn_expensereceipt_ProcessSession) One-To-Many relationship.

### <a name="BKMK_msdyn_fact_ProcessSession"></a> msdyn_fact_ProcessSession

See msdyn_fact Entity [msdyn_fact_ProcessSession](msdyn_fact.md#BKMK_msdyn_fact_ProcessSession) One-To-Many relationship.

### <a name="BKMK_msdyn_fieldcomputation_ProcessSession"></a> msdyn_fieldcomputation_ProcessSession

See msdyn_fieldcomputation Entity [msdyn_fieldcomputation_ProcessSession](msdyn_fieldcomputation.md#BKMK_msdyn_fieldcomputation_ProcessSession) One-To-Many relationship.

### <a name="BKMK_msdyn_findworkevent_ProcessSession"></a> msdyn_findworkevent_ProcessSession

See msdyn_findworkevent Entity [msdyn_findworkevent_ProcessSession](msdyn_findworkevent.md#BKMK_msdyn_findworkevent_ProcessSession) One-To-Many relationship.

### <a name="BKMK_msdyn_integrationjob_ProcessSession"></a> msdyn_integrationjob_ProcessSession

See msdyn_integrationjob Entity [msdyn_integrationjob_ProcessSession](msdyn_integrationjob.md#BKMK_msdyn_integrationjob_ProcessSession) One-To-Many relationship.

### <a name="BKMK_msdyn_integrationjobdetail_ProcessSession"></a> msdyn_integrationjobdetail_ProcessSession

See msdyn_integrationjobdetail Entity [msdyn_integrationjobdetail_ProcessSession](msdyn_integrationjobdetail.md#BKMK_msdyn_integrationjobdetail_ProcessSession) One-To-Many relationship.

### <a name="BKMK_msdyn_invoicefrequency_ProcessSession"></a> msdyn_invoicefrequency_ProcessSession

See msdyn_invoicefrequency Entity [msdyn_invoicefrequency_ProcessSession](msdyn_invoicefrequency.md#BKMK_msdyn_invoicefrequency_ProcessSession) One-To-Many relationship.

### <a name="BKMK_msdyn_invoicefrequencydetail_ProcessSession"></a> msdyn_invoicefrequencydetail_ProcessSession

See msdyn_invoicefrequencydetail Entity [msdyn_invoicefrequencydetail_ProcessSession](msdyn_invoicefrequencydetail.md#BKMK_msdyn_invoicefrequencydetail_ProcessSession) One-To-Many relationship.

### <a name="BKMK_msdyn_invoicelinetransaction_ProcessSession"></a> msdyn_invoicelinetransaction_ProcessSession

See msdyn_invoicelinetransaction Entity [msdyn_invoicelinetransaction_ProcessSession](msdyn_invoicelinetransaction.md#BKMK_msdyn_invoicelinetransaction_ProcessSession) One-To-Many relationship.

### <a name="BKMK_msdyn_journal_ProcessSession"></a> msdyn_journal_ProcessSession

See msdyn_journal Entity [msdyn_journal_ProcessSession](msdyn_journal.md#BKMK_msdyn_journal_ProcessSession) One-To-Many relationship.

### <a name="BKMK_msdyn_journalline_ProcessSession"></a> msdyn_journalline_ProcessSession

See msdyn_journalline Entity [msdyn_journalline_ProcessSession](msdyn_journalline.md#BKMK_msdyn_journalline_ProcessSession) One-To-Many relationship.

### <a name="BKMK_msdyn_mlresultcache_ProcessSession"></a> msdyn_mlresultcache_ProcessSession

See msdyn_mlresultcache Entity [msdyn_mlresultcache_ProcessSession](msdyn_mlresultcache.md#BKMK_msdyn_mlresultcache_ProcessSession) One-To-Many relationship.

### <a name="BKMK_msdyn_opportunitylineresourcecategory_ProcessSession"></a> msdyn_opportunitylineresourcecategory_ProcessSession

See msdyn_opportunitylineresourcecategory Entity [msdyn_opportunitylineresourcecategory_ProcessSession](msdyn_opportunitylineresourcecategory.md#BKMK_msdyn_opportunitylineresourcecategory_ProcessSession) One-To-Many relationship.

### <a name="BKMK_msdyn_opportunitylinetransaction_ProcessSession"></a> msdyn_opportunitylinetransaction_ProcessSession

See msdyn_opportunitylinetransaction Entity [msdyn_opportunitylinetransaction_ProcessSession](msdyn_opportunitylinetransaction.md#BKMK_msdyn_opportunitylinetransaction_ProcessSession) One-To-Many relationship.

### <a name="BKMK_msdyn_opportunitylinetransactioncategory_ProcessSession"></a> msdyn_opportunitylinetransactioncategory_ProcessSession

See msdyn_opportunitylinetransactioncategory Entity [msdyn_opportunitylinetransactioncategory_ProcessSession](msdyn_opportunitylinetransactioncategory.md#BKMK_msdyn_opportunitylinetransactioncategory_ProcessSession) One-To-Many relationship.

### <a name="BKMK_msdyn_opportunitylinetransactionclassificatio_ProcessSession"></a> msdyn_opportunitylinetransactionclassificatio_ProcessSession

See msdyn_opportunitylinetransactionclassificatio Entity [msdyn_opportunitylinetransactionclassificatio_ProcessSession](msdyn_opportunitylinetransactionclassificatio.md#BKMK_msdyn_opportunitylinetransactionclassificatio_ProcessSession) One-To-Many relationship.

### <a name="BKMK_msdyn_opportunitypricelist_ProcessSession"></a> msdyn_opportunitypricelist_ProcessSession

See msdyn_opportunitypricelist Entity [msdyn_opportunitypricelist_ProcessSession](msdyn_opportunitypricelist.md#BKMK_msdyn_opportunitypricelist_ProcessSession) One-To-Many relationship.

### <a name="BKMK_msdyn_orderlineresourcecategory_ProcessSession"></a> msdyn_orderlineresourcecategory_ProcessSession

See msdyn_orderlineresourcecategory Entity [msdyn_orderlineresourcecategory_ProcessSession](msdyn_orderlineresourcecategory.md#BKMK_msdyn_orderlineresourcecategory_ProcessSession) One-To-Many relationship.

### <a name="BKMK_msdyn_orderlinetransaction_ProcessSession"></a> msdyn_orderlinetransaction_ProcessSession

See msdyn_orderlinetransaction Entity [msdyn_orderlinetransaction_ProcessSession](msdyn_orderlinetransaction.md#BKMK_msdyn_orderlinetransaction_ProcessSession) One-To-Many relationship.

### <a name="BKMK_msdyn_orderlinetransactioncategory_ProcessSession"></a> msdyn_orderlinetransactioncategory_ProcessSession

See msdyn_orderlinetransactioncategory Entity [msdyn_orderlinetransactioncategory_ProcessSession](msdyn_orderlinetransactioncategory.md#BKMK_msdyn_orderlinetransactioncategory_ProcessSession) One-To-Many relationship.

### <a name="BKMK_msdyn_orderlinetransactionclassification_ProcessSession"></a> msdyn_orderlinetransactionclassification_ProcessSession

See msdyn_orderlinetransactionclassification Entity [msdyn_orderlinetransactionclassification_ProcessSession](msdyn_orderlinetransactionclassification.md#BKMK_msdyn_orderlinetransactionclassification_ProcessSession) One-To-Many relationship.

### <a name="BKMK_msdyn_orderpricelist_ProcessSession"></a> msdyn_orderpricelist_ProcessSession

See msdyn_orderpricelist Entity [msdyn_orderpricelist_ProcessSession](msdyn_orderpricelist.md#BKMK_msdyn_orderpricelist_ProcessSession) One-To-Many relationship.

### <a name="BKMK_msdyn_processnotes_ProcessSession"></a> msdyn_processnotes_ProcessSession

See msdyn_processnotes Entity [msdyn_processnotes_ProcessSession](msdyn_processnotes.md#BKMK_msdyn_processnotes_ProcessSession) One-To-Many relationship.

### <a name="BKMK_msdyn_project_ProcessSession"></a> msdyn_project_ProcessSession

See msdyn_project Entity [msdyn_project_ProcessSession](msdyn_project.md#BKMK_msdyn_project_ProcessSession) One-To-Many relationship.

### <a name="BKMK_msdyn_projectapproval_ProcessSession"></a> msdyn_projectapproval_ProcessSession

See msdyn_projectapproval Entity [msdyn_projectapproval_ProcessSession](msdyn_projectapproval.md#BKMK_msdyn_projectapproval_ProcessSession) One-To-Many relationship.

### <a name="BKMK_msdyn_projectparameter_ProcessSession"></a> msdyn_projectparameter_ProcessSession

See msdyn_projectparameter Entity [msdyn_projectparameter_ProcessSession](msdyn_projectparameter.md#BKMK_msdyn_projectparameter_ProcessSession) One-To-Many relationship.

### <a name="BKMK_msdyn_projectparameterpricelist_ProcessSession"></a> msdyn_projectparameterpricelist_ProcessSession

See msdyn_projectparameterpricelist Entity [msdyn_projectparameterpricelist_ProcessSession](msdyn_projectparameterpricelist.md#BKMK_msdyn_projectparameterpricelist_ProcessSession) One-To-Many relationship.

### <a name="BKMK_msdyn_projectpricelist_ProcessSession"></a> msdyn_projectpricelist_ProcessSession

See msdyn_projectpricelist Entity [msdyn_projectpricelist_ProcessSession](msdyn_projectpricelist.md#BKMK_msdyn_projectpricelist_ProcessSession) One-To-Many relationship.

### <a name="BKMK_msdyn_projecttask_ProcessSession"></a> msdyn_projecttask_ProcessSession

See msdyn_projecttask Entity [msdyn_projecttask_ProcessSession](msdyn_projecttask.md#BKMK_msdyn_projecttask_ProcessSession) One-To-Many relationship.

### <a name="BKMK_msdyn_projecttaskdependency_ProcessSession"></a> msdyn_projecttaskdependency_ProcessSession

See msdyn_projecttaskdependency Entity [msdyn_projecttaskdependency_ProcessSession](msdyn_projecttaskdependency.md#BKMK_msdyn_projecttaskdependency_ProcessSession) One-To-Many relationship.

### <a name="BKMK_msdyn_projecttaskstatususer_ProcessSession"></a> msdyn_projecttaskstatususer_ProcessSession

See msdyn_projecttaskstatususer Entity [msdyn_projecttaskstatususer_ProcessSession](msdyn_projecttaskstatususer.md#BKMK_msdyn_projecttaskstatususer_ProcessSession) One-To-Many relationship.

### <a name="BKMK_msdyn_projectteam_ProcessSession"></a> msdyn_projectteam_ProcessSession

See msdyn_projectteam Entity [msdyn_projectteam_ProcessSession](msdyn_projectteam.md#BKMK_msdyn_projectteam_ProcessSession) One-To-Many relationship.

### <a name="BKMK_msdyn_projectteammembersignup_ProcessSession"></a> msdyn_projectteammembersignup_ProcessSession

See msdyn_projectteammembersignup Entity [msdyn_projectteammembersignup_ProcessSession](msdyn_projectteammembersignup.md#BKMK_msdyn_projectteammembersignup_ProcessSession) One-To-Many relationship.

### <a name="BKMK_msdyn_projecttransactioncategory_ProcessSession"></a> msdyn_projecttransactioncategory_ProcessSession

See msdyn_projecttransactioncategory Entity [msdyn_projecttransactioncategory_ProcessSession](msdyn_projecttransactioncategory.md#BKMK_msdyn_projecttransactioncategory_ProcessSession) One-To-Many relationship.

### <a name="BKMK_msdyn_quotelineanalyticsbreakdown_ProcessSession"></a> msdyn_quotelineanalyticsbreakdown_ProcessSession

See msdyn_quotelineanalyticsbreakdown Entity [msdyn_quotelineanalyticsbreakdown_ProcessSession](msdyn_quotelineanalyticsbreakdown.md#BKMK_msdyn_quotelineanalyticsbreakdown_ProcessSession) One-To-Many relationship.

### <a name="BKMK_msdyn_quotelineinvoiceschedule_ProcessSession"></a> msdyn_quotelineinvoiceschedule_ProcessSession

See msdyn_quotelineinvoiceschedule Entity [msdyn_quotelineinvoiceschedule_ProcessSession](msdyn_quotelineinvoiceschedule.md#BKMK_msdyn_quotelineinvoiceschedule_ProcessSession) One-To-Many relationship.

### <a name="BKMK_msdyn_quotelineresourcecategory_ProcessSession"></a> msdyn_quotelineresourcecategory_ProcessSession

See msdyn_quotelineresourcecategory Entity [msdyn_quotelineresourcecategory_ProcessSession](msdyn_quotelineresourcecategory.md#BKMK_msdyn_quotelineresourcecategory_ProcessSession) One-To-Many relationship.

### <a name="BKMK_msdyn_quotelinescheduleofvalue_ProcessSession"></a> msdyn_quotelinescheduleofvalue_ProcessSession

See msdyn_quotelinescheduleofvalue Entity [msdyn_quotelinescheduleofvalue_ProcessSession](msdyn_quotelinescheduleofvalue.md#BKMK_msdyn_quotelinescheduleofvalue_ProcessSession) One-To-Many relationship.

### <a name="BKMK_msdyn_quotelinetransaction_ProcessSession"></a> msdyn_quotelinetransaction_ProcessSession

See msdyn_quotelinetransaction Entity [msdyn_quotelinetransaction_ProcessSession](msdyn_quotelinetransaction.md#BKMK_msdyn_quotelinetransaction_ProcessSession) One-To-Many relationship.

### <a name="BKMK_msdyn_quotelinetransactioncategory_ProcessSession"></a> msdyn_quotelinetransactioncategory_ProcessSession

See msdyn_quotelinetransactioncategory Entity [msdyn_quotelinetransactioncategory_ProcessSession](msdyn_quotelinetransactioncategory.md#BKMK_msdyn_quotelinetransactioncategory_ProcessSession) One-To-Many relationship.

### <a name="BKMK_msdyn_quotelinetransactionclassification_ProcessSession"></a> msdyn_quotelinetransactionclassification_ProcessSession

See msdyn_quotelinetransactionclassification Entity [msdyn_quotelinetransactionclassification_ProcessSession](msdyn_quotelinetransactionclassification.md#BKMK_msdyn_quotelinetransactionclassification_ProcessSession) One-To-Many relationship.

### <a name="BKMK_msdyn_quotepricelist_ProcessSession"></a> msdyn_quotepricelist_ProcessSession

See msdyn_quotepricelist Entity [msdyn_quotepricelist_ProcessSession](msdyn_quotepricelist.md#BKMK_msdyn_quotepricelist_ProcessSession) One-To-Many relationship.

### <a name="BKMK_msdyn_resourceassignment_ProcessSession"></a> msdyn_resourceassignment_ProcessSession

See msdyn_resourceassignment Entity [msdyn_resourceassignment_ProcessSession](msdyn_resourceassignment.md#BKMK_msdyn_resourceassignment_ProcessSession) One-To-Many relationship.

### <a name="BKMK_msdyn_resourceassignmentdetail_ProcessSession"></a> msdyn_resourceassignmentdetail_ProcessSession

See msdyn_resourceassignmentdetail Entity [msdyn_resourceassignmentdetail_ProcessSession](msdyn_resourceassignmentdetail.md#BKMK_msdyn_resourceassignmentdetail_ProcessSession) One-To-Many relationship.

### <a name="BKMK_msdyn_resourcecategorypricelevel_ProcessSession"></a> msdyn_resourcecategorypricelevel_ProcessSession

See msdyn_resourcecategorypricelevel Entity [msdyn_resourcecategorypricelevel_ProcessSession](msdyn_resourcecategorypricelevel.md#BKMK_msdyn_resourcecategorypricelevel_ProcessSession) One-To-Many relationship.

### <a name="BKMK_msdyn_resourcerequest_ProcessSession"></a> msdyn_resourcerequest_ProcessSession

See msdyn_resourcerequest Entity [msdyn_resourcerequest_ProcessSession](msdyn_resourcerequest.md#BKMK_msdyn_resourcerequest_ProcessSession) One-To-Many relationship.

### <a name="BKMK_msdyn_rolecompetencyrequirement_ProcessSession"></a> msdyn_rolecompetencyrequirement_ProcessSession

See msdyn_rolecompetencyrequirement Entity [msdyn_rolecompetencyrequirement_ProcessSession](msdyn_rolecompetencyrequirement.md#BKMK_msdyn_rolecompetencyrequirement_ProcessSession) One-To-Many relationship.

### <a name="BKMK_msdyn_roleutilization_ProcessSession"></a> msdyn_roleutilization_ProcessSession

See msdyn_roleutilization Entity [msdyn_roleutilization_ProcessSession](msdyn_roleutilization.md#BKMK_msdyn_roleutilization_ProcessSession) One-To-Many relationship.

### <a name="BKMK_msdyn_timeentry_ProcessSession"></a> msdyn_timeentry_ProcessSession

See msdyn_timeentry Entity [msdyn_timeentry_ProcessSession](msdyn_timeentry.md#BKMK_msdyn_timeentry_ProcessSession) One-To-Many relationship.

### <a name="BKMK_msdyn_timeoffcalendar_ProcessSession"></a> msdyn_timeoffcalendar_ProcessSession

See msdyn_timeoffcalendar Entity [msdyn_timeoffcalendar_ProcessSession](msdyn_timeoffcalendar.md#BKMK_msdyn_timeoffcalendar_ProcessSession) One-To-Many relationship.

### <a name="BKMK_msdyn_transactioncategory_ProcessSession"></a> msdyn_transactioncategory_ProcessSession

See msdyn_transactioncategory Entity [msdyn_transactioncategory_ProcessSession](msdyn_transactioncategory.md#BKMK_msdyn_transactioncategory_ProcessSession) One-To-Many relationship.

### <a name="BKMK_msdyn_transactioncategoryclassification_ProcessSession"></a> msdyn_transactioncategoryclassification_ProcessSession

See msdyn_transactioncategoryclassification Entity [msdyn_transactioncategoryclassification_ProcessSession](msdyn_transactioncategoryclassification.md#BKMK_msdyn_transactioncategoryclassification_ProcessSession) One-To-Many relationship.

### <a name="BKMK_msdyn_transactioncategoryhierarchyelement_ProcessSession"></a> msdyn_transactioncategoryhierarchyelement_ProcessSession

See msdyn_transactioncategoryhierarchyelement Entity [msdyn_transactioncategoryhierarchyelement_ProcessSession](msdyn_transactioncategoryhierarchyelement.md#BKMK_msdyn_transactioncategoryhierarchyelement_ProcessSession) One-To-Many relationship.

### <a name="BKMK_msdyn_transactioncategorypricelevel_ProcessSession"></a> msdyn_transactioncategorypricelevel_ProcessSession

See msdyn_transactioncategorypricelevel Entity [msdyn_transactioncategorypricelevel_ProcessSession](msdyn_transactioncategorypricelevel.md#BKMK_msdyn_transactioncategorypricelevel_ProcessSession) One-To-Many relationship.

### <a name="BKMK_msdyn_transactionconnection_ProcessSession"></a> msdyn_transactionconnection_ProcessSession

See msdyn_transactionconnection Entity [msdyn_transactionconnection_ProcessSession](msdyn_transactionconnection.md#BKMK_msdyn_transactionconnection_ProcessSession) One-To-Many relationship.

### <a name="BKMK_msdyn_transactiontype_ProcessSession"></a> msdyn_transactiontype_ProcessSession

See msdyn_transactiontype Entity [msdyn_transactiontype_ProcessSession](msdyn_transactiontype.md#BKMK_msdyn_transactiontype_ProcessSession) One-To-Many relationship.

### <a name="BKMK_msdyn_userworkhistory_ProcessSession"></a> msdyn_userworkhistory_ProcessSession

See msdyn_userworkhistory Entity [msdyn_userworkhistory_ProcessSession](msdyn_userworkhistory.md#BKMK_msdyn_userworkhistory_ProcessSession) One-To-Many relationship.

### <a name="BKMK_msdyn_agreement_ProcessSession"></a> msdyn_agreement_ProcessSession

See msdyn_agreement Entity [msdyn_agreement_ProcessSession](msdyn_agreement.md#BKMK_msdyn_agreement_ProcessSession) One-To-Many relationship.

### <a name="BKMK_msdyn_agreementbookingdate_ProcessSession"></a> msdyn_agreementbookingdate_ProcessSession

See msdyn_agreementbookingdate Entity [msdyn_agreementbookingdate_ProcessSession](msdyn_agreementbookingdate.md#BKMK_msdyn_agreementbookingdate_ProcessSession) One-To-Many relationship.

### <a name="BKMK_msdyn_agreementbookingincident_ProcessSession"></a> msdyn_agreementbookingincident_ProcessSession

See msdyn_agreementbookingincident Entity [msdyn_agreementbookingincident_ProcessSession](msdyn_agreementbookingincident.md#BKMK_msdyn_agreementbookingincident_ProcessSession) One-To-Many relationship.

### <a name="BKMK_msdyn_agreementbookingproduct_ProcessSession"></a> msdyn_agreementbookingproduct_ProcessSession

See msdyn_agreementbookingproduct Entity [msdyn_agreementbookingproduct_ProcessSession](msdyn_agreementbookingproduct.md#BKMK_msdyn_agreementbookingproduct_ProcessSession) One-To-Many relationship.

### <a name="BKMK_msdyn_agreementbookingservice_ProcessSession"></a> msdyn_agreementbookingservice_ProcessSession

See msdyn_agreementbookingservice Entity [msdyn_agreementbookingservice_ProcessSession](msdyn_agreementbookingservice.md#BKMK_msdyn_agreementbookingservice_ProcessSession) One-To-Many relationship.

### <a name="BKMK_msdyn_agreementbookingservicetask_ProcessSession"></a> msdyn_agreementbookingservicetask_ProcessSession

See msdyn_agreementbookingservicetask Entity [msdyn_agreementbookingservicetask_ProcessSession](msdyn_agreementbookingservicetask.md#BKMK_msdyn_agreementbookingservicetask_ProcessSession) One-To-Many relationship.

### <a name="BKMK_msdyn_agreementbookingsetup_ProcessSession"></a> msdyn_agreementbookingsetup_ProcessSession

See msdyn_agreementbookingsetup Entity [msdyn_agreementbookingsetup_ProcessSession](msdyn_agreementbookingsetup.md#BKMK_msdyn_agreementbookingsetup_ProcessSession) One-To-Many relationship.

### <a name="BKMK_msdyn_agreementinvoicedate_ProcessSession"></a> msdyn_agreementinvoicedate_ProcessSession

See msdyn_agreementinvoicedate Entity [msdyn_agreementinvoicedate_ProcessSession](msdyn_agreementinvoicedate.md#BKMK_msdyn_agreementinvoicedate_ProcessSession) One-To-Many relationship.

### <a name="BKMK_msdyn_agreementinvoiceproduct_ProcessSession"></a> msdyn_agreementinvoiceproduct_ProcessSession

See msdyn_agreementinvoiceproduct Entity [msdyn_agreementinvoiceproduct_ProcessSession](msdyn_agreementinvoiceproduct.md#BKMK_msdyn_agreementinvoiceproduct_ProcessSession) One-To-Many relationship.

### <a name="BKMK_msdyn_agreementinvoicesetup_ProcessSession"></a> msdyn_agreementinvoicesetup_ProcessSession

See msdyn_agreementinvoicesetup Entity [msdyn_agreementinvoicesetup_ProcessSession](msdyn_agreementinvoicesetup.md#BKMK_msdyn_agreementinvoicesetup_ProcessSession) One-To-Many relationship.

### <a name="BKMK_msdyn_agreementsubstatus_ProcessSession"></a> msdyn_agreementsubstatus_ProcessSession

See msdyn_agreementsubstatus Entity [msdyn_agreementsubstatus_ProcessSession](msdyn_agreementsubstatus.md#BKMK_msdyn_agreementsubstatus_ProcessSession) One-To-Many relationship.

### <a name="BKMK_msdyn_bookingjournal_ProcessSession"></a> msdyn_bookingjournal_ProcessSession

See msdyn_bookingjournal Entity [msdyn_bookingjournal_ProcessSession](msdyn_bookingjournal.md#BKMK_msdyn_bookingjournal_ProcessSession) One-To-Many relationship.

### <a name="BKMK_msdyn_bookingtimestamp_ProcessSession"></a> msdyn_bookingtimestamp_ProcessSession

See msdyn_bookingtimestamp Entity [msdyn_bookingtimestamp_ProcessSession](msdyn_bookingtimestamp.md#BKMK_msdyn_bookingtimestamp_ProcessSession) One-To-Many relationship.

### <a name="BKMK_msdyn_bpf_2c5fe86acc8b414b8322ae571000c799_ProcessSession"></a> msdyn_bpf_2c5fe86acc8b414b8322ae571000c799_ProcessSession

See msdyn_bpf_2c5fe86acc8b414b8322ae571000c799 Entity [msdyn_bpf_2c5fe86acc8b414b8322ae571000c799_ProcessSession](msdyn_bpf_2c5fe86acc8b414b8322ae571000c799.md#BKMK_msdyn_bpf_2c5fe86acc8b414b8322ae571000c799_ProcessSession) One-To-Many relationship.

### <a name="BKMK_msdyn_bpf_989e9b1857e24af18787d5143b67523b_ProcessSession"></a> msdyn_bpf_989e9b1857e24af18787d5143b67523b_ProcessSession

See msdyn_bpf_989e9b1857e24af18787d5143b67523b Entity [msdyn_bpf_989e9b1857e24af18787d5143b67523b_ProcessSession](msdyn_bpf_989e9b1857e24af18787d5143b67523b.md#BKMK_msdyn_bpf_989e9b1857e24af18787d5143b67523b_ProcessSession) One-To-Many relationship.

### <a name="BKMK_msdyn_bpf_baa0a411a239410cb8bded8b5fdd88e3_ProcessSession"></a> msdyn_bpf_baa0a411a239410cb8bded8b5fdd88e3_ProcessSession

See msdyn_bpf_baa0a411a239410cb8bded8b5fdd88e3 Entity [msdyn_bpf_baa0a411a239410cb8bded8b5fdd88e3_ProcessSession](msdyn_bpf_baa0a411a239410cb8bded8b5fdd88e3.md#BKMK_msdyn_bpf_baa0a411a239410cb8bded8b5fdd88e3_ProcessSession) One-To-Many relationship.

### <a name="BKMK_msdyn_bpf_d3d97bac8c294105840e99e37a9d1c39_ProcessSession"></a> msdyn_bpf_d3d97bac8c294105840e99e37a9d1c39_ProcessSession

See msdyn_bpf_d3d97bac8c294105840e99e37a9d1c39 Entity [msdyn_bpf_d3d97bac8c294105840e99e37a9d1c39_ProcessSession](msdyn_bpf_d3d97bac8c294105840e99e37a9d1c39.md#BKMK_msdyn_bpf_d3d97bac8c294105840e99e37a9d1c39_ProcessSession) One-To-Many relationship.

### <a name="BKMK_msdyn_customerasset_ProcessSession"></a> msdyn_customerasset_ProcessSession

See msdyn_customerasset Entity [msdyn_customerasset_ProcessSession](msdyn_customerasset.md#BKMK_msdyn_customerasset_ProcessSession) One-To-Many relationship.

### <a name="BKMK_msdyn_fieldservicepricelistitem_ProcessSession"></a> msdyn_fieldservicepricelistitem_ProcessSession

See msdyn_fieldservicepricelistitem Entity [msdyn_fieldservicepricelistitem_ProcessSession](msdyn_fieldservicepricelistitem.md#BKMK_msdyn_fieldservicepricelistitem_ProcessSession) One-To-Many relationship.

### <a name="BKMK_msdyn_fieldservicesetting_ProcessSession"></a> msdyn_fieldservicesetting_ProcessSession

See msdyn_fieldservicesetting Entity [msdyn_fieldservicesetting_ProcessSession](msdyn_fieldservicesetting.md#BKMK_msdyn_fieldservicesetting_ProcessSession) One-To-Many relationship.

### <a name="BKMK_msdyn_fieldservicesystemjob_ProcessSession"></a> msdyn_fieldservicesystemjob_ProcessSession

See msdyn_fieldservicesystemjob Entity [msdyn_fieldservicesystemjob_ProcessSession](msdyn_fieldservicesystemjob.md#BKMK_msdyn_fieldservicesystemjob_ProcessSession) One-To-Many relationship.

### <a name="BKMK_msdyn_incidenttype_ProcessSession"></a> msdyn_incidenttype_ProcessSession

See msdyn_incidenttype Entity [msdyn_incidenttype_ProcessSession](msdyn_incidenttype.md#BKMK_msdyn_incidenttype_ProcessSession) One-To-Many relationship.

### <a name="BKMK_msdyn_incidenttypecharacteristic_ProcessSession"></a> msdyn_incidenttypecharacteristic_ProcessSession

See msdyn_incidenttypecharacteristic Entity [msdyn_incidenttypecharacteristic_ProcessSession](msdyn_incidenttypecharacteristic.md#BKMK_msdyn_incidenttypecharacteristic_ProcessSession) One-To-Many relationship.

### <a name="BKMK_msdyn_incidenttypeproduct_ProcessSession"></a> msdyn_incidenttypeproduct_ProcessSession

See msdyn_incidenttypeproduct Entity [msdyn_incidenttypeproduct_ProcessSession](msdyn_incidenttypeproduct.md#BKMK_msdyn_incidenttypeproduct_ProcessSession) One-To-Many relationship.

### <a name="BKMK_msdyn_incidenttypeservice_ProcessSession"></a> msdyn_incidenttypeservice_ProcessSession

See msdyn_incidenttypeservice Entity [msdyn_incidenttypeservice_ProcessSession](msdyn_incidenttypeservice.md#BKMK_msdyn_incidenttypeservice_ProcessSession) One-To-Many relationship.

### <a name="BKMK_msdyn_incidenttypeservicetask_ProcessSession"></a> msdyn_incidenttypeservicetask_ProcessSession

See msdyn_incidenttypeservicetask Entity [msdyn_incidenttypeservicetask_ProcessSession](msdyn_incidenttypeservicetask.md#BKMK_msdyn_incidenttypeservicetask_ProcessSession) One-To-Many relationship.

### <a name="BKMK_msdyn_inventoryadjustment_ProcessSession"></a> msdyn_inventoryadjustment_ProcessSession

See msdyn_inventoryadjustment Entity [msdyn_inventoryadjustment_ProcessSession](msdyn_inventoryadjustment.md#BKMK_msdyn_inventoryadjustment_ProcessSession) One-To-Many relationship.

### <a name="BKMK_msdyn_inventoryadjustmentproduct_ProcessSession"></a> msdyn_inventoryadjustmentproduct_ProcessSession

See msdyn_inventoryadjustmentproduct Entity [msdyn_inventoryadjustmentproduct_ProcessSession](msdyn_inventoryadjustmentproduct.md#BKMK_msdyn_inventoryadjustmentproduct_ProcessSession) One-To-Many relationship.

### <a name="BKMK_msdyn_inventoryjournal_ProcessSession"></a> msdyn_inventoryjournal_ProcessSession

See msdyn_inventoryjournal Entity [msdyn_inventoryjournal_ProcessSession](msdyn_inventoryjournal.md#BKMK_msdyn_inventoryjournal_ProcessSession) One-To-Many relationship.

### <a name="BKMK_msdyn_inventorytransfer_ProcessSession"></a> msdyn_inventorytransfer_ProcessSession

See msdyn_inventorytransfer Entity [msdyn_inventorytransfer_ProcessSession](msdyn_inventorytransfer.md#BKMK_msdyn_inventorytransfer_ProcessSession) One-To-Many relationship.

### <a name="BKMK_msdyn_orderinvoicingdate_ProcessSession"></a> msdyn_orderinvoicingdate_ProcessSession

See msdyn_orderinvoicingdate Entity [msdyn_orderinvoicingdate_ProcessSession](msdyn_orderinvoicingdate.md#BKMK_msdyn_orderinvoicingdate_ProcessSession) One-To-Many relationship.

### <a name="BKMK_msdyn_orderinvoicingproduct_ProcessSession"></a> msdyn_orderinvoicingproduct_ProcessSession

See msdyn_orderinvoicingproduct Entity [msdyn_orderinvoicingproduct_ProcessSession](msdyn_orderinvoicingproduct.md#BKMK_msdyn_orderinvoicingproduct_ProcessSession) One-To-Many relationship.

### <a name="BKMK_msdyn_orderinvoicingsetup_ProcessSession"></a> msdyn_orderinvoicingsetup_ProcessSession

See msdyn_orderinvoicingsetup Entity [msdyn_orderinvoicingsetup_ProcessSession](msdyn_orderinvoicingsetup.md#BKMK_msdyn_orderinvoicingsetup_ProcessSession) One-To-Many relationship.

### <a name="BKMK_msdyn_orderinvoicingsetupdate_ProcessSession"></a> msdyn_orderinvoicingsetupdate_ProcessSession

See msdyn_orderinvoicingsetupdate Entity [msdyn_orderinvoicingsetupdate_ProcessSession](msdyn_orderinvoicingsetupdate.md#BKMK_msdyn_orderinvoicingsetupdate_ProcessSession) One-To-Many relationship.

### <a name="BKMK_msdyn_payment_ProcessSession"></a> msdyn_payment_ProcessSession

See msdyn_payment Entity [msdyn_payment_ProcessSession](msdyn_payment.md#BKMK_msdyn_payment_ProcessSession) One-To-Many relationship.

### <a name="BKMK_msdyn_paymentdetail_ProcessSession"></a> msdyn_paymentdetail_ProcessSession

See msdyn_paymentdetail Entity [msdyn_paymentdetail_ProcessSession](msdyn_paymentdetail.md#BKMK_msdyn_paymentdetail_ProcessSession) One-To-Many relationship.

### <a name="BKMK_msdyn_paymentmethod_ProcessSession"></a> msdyn_paymentmethod_ProcessSession

See msdyn_paymentmethod Entity [msdyn_paymentmethod_ProcessSession](msdyn_paymentmethod.md#BKMK_msdyn_paymentmethod_ProcessSession) One-To-Many relationship.

### <a name="BKMK_msdyn_paymentterm_ProcessSession"></a> msdyn_paymentterm_ProcessSession

See msdyn_paymentterm Entity [msdyn_paymentterm_ProcessSession](msdyn_paymentterm.md#BKMK_msdyn_paymentterm_ProcessSession) One-To-Many relationship.

### <a name="BKMK_msdyn_postalcode_ProcessSession"></a> msdyn_postalcode_ProcessSession

See msdyn_postalcode Entity [msdyn_postalcode_ProcessSession](msdyn_postalcode.md#BKMK_msdyn_postalcode_ProcessSession) One-To-Many relationship.

### <a name="BKMK_msdyn_productinventory_ProcessSession"></a> msdyn_productinventory_ProcessSession

See msdyn_productinventory Entity [msdyn_productinventory_ProcessSession](msdyn_productinventory.md#BKMK_msdyn_productinventory_ProcessSession) One-To-Many relationship.

### <a name="BKMK_msdyn_purchaseorder_ProcessSession"></a> msdyn_purchaseorder_ProcessSession

See msdyn_purchaseorder Entity [msdyn_purchaseorder_ProcessSession](msdyn_purchaseorder.md#BKMK_msdyn_purchaseorder_ProcessSession) One-To-Many relationship.

### <a name="BKMK_msdyn_purchaseorderbill_ProcessSession"></a> msdyn_purchaseorderbill_ProcessSession

See msdyn_purchaseorderbill Entity [msdyn_purchaseorderbill_ProcessSession](msdyn_purchaseorderbill.md#BKMK_msdyn_purchaseorderbill_ProcessSession) One-To-Many relationship.

### <a name="BKMK_msdyn_purchaseorderproduct_ProcessSession"></a> msdyn_purchaseorderproduct_ProcessSession

See msdyn_purchaseorderproduct Entity [msdyn_purchaseorderproduct_ProcessSession](msdyn_purchaseorderproduct.md#BKMK_msdyn_purchaseorderproduct_ProcessSession) One-To-Many relationship.

### <a name="BKMK_msdyn_purchaseorderreceipt_ProcessSession"></a> msdyn_purchaseorderreceipt_ProcessSession

See msdyn_purchaseorderreceipt Entity [msdyn_purchaseorderreceipt_ProcessSession](msdyn_purchaseorderreceipt.md#BKMK_msdyn_purchaseorderreceipt_ProcessSession) One-To-Many relationship.

### <a name="BKMK_msdyn_purchaseorderreceiptproduct_ProcessSession"></a> msdyn_purchaseorderreceiptproduct_ProcessSession

See msdyn_purchaseorderreceiptproduct Entity [msdyn_purchaseorderreceiptproduct_ProcessSession](msdyn_purchaseorderreceiptproduct.md#BKMK_msdyn_purchaseorderreceiptproduct_ProcessSession) One-To-Many relationship.

### <a name="BKMK_msdyn_purchaseordersubstatus_ProcessSession"></a> msdyn_purchaseordersubstatus_ProcessSession

See msdyn_purchaseordersubstatus Entity [msdyn_purchaseordersubstatus_ProcessSession](msdyn_purchaseordersubstatus.md#BKMK_msdyn_purchaseordersubstatus_ProcessSession) One-To-Many relationship.

### <a name="BKMK_msdyn_quotebookingincident_ProcessSession"></a> msdyn_quotebookingincident_ProcessSession

See msdyn_quotebookingincident Entity [msdyn_quotebookingincident_ProcessSession](msdyn_quotebookingincident.md#BKMK_msdyn_quotebookingincident_ProcessSession) One-To-Many relationship.

### <a name="BKMK_msdyn_quotebookingproduct_ProcessSession"></a> msdyn_quotebookingproduct_ProcessSession

See msdyn_quotebookingproduct Entity [msdyn_quotebookingproduct_ProcessSession](msdyn_quotebookingproduct.md#BKMK_msdyn_quotebookingproduct_ProcessSession) One-To-Many relationship.

### <a name="BKMK_msdyn_quotebookingservice_ProcessSession"></a> msdyn_quotebookingservice_ProcessSession

See msdyn_quotebookingservice Entity [msdyn_quotebookingservice_ProcessSession](msdyn_quotebookingservice.md#BKMK_msdyn_quotebookingservice_ProcessSession) One-To-Many relationship.

### <a name="BKMK_msdyn_quotebookingservicetask_ProcessSession"></a> msdyn_quotebookingservicetask_ProcessSession

See msdyn_quotebookingservicetask Entity [msdyn_quotebookingservicetask_ProcessSession](msdyn_quotebookingservicetask.md#BKMK_msdyn_quotebookingservicetask_ProcessSession) One-To-Many relationship.

### <a name="BKMK_msdyn_quotebookingsetup_ProcessSession"></a> msdyn_quotebookingsetup_ProcessSession

See msdyn_quotebookingsetup Entity [msdyn_quotebookingsetup_ProcessSession](msdyn_quotebookingsetup.md#BKMK_msdyn_quotebookingsetup_ProcessSession) One-To-Many relationship.

### <a name="BKMK_msdyn_quoteinvoicingproduct_ProcessSession"></a> msdyn_quoteinvoicingproduct_ProcessSession

See msdyn_quoteinvoicingproduct Entity [msdyn_quoteinvoicingproduct_ProcessSession](msdyn_quoteinvoicingproduct.md#BKMK_msdyn_quoteinvoicingproduct_ProcessSession) One-To-Many relationship.

### <a name="BKMK_msdyn_quoteinvoicingsetup_ProcessSession"></a> msdyn_quoteinvoicingsetup_ProcessSession

See msdyn_quoteinvoicingsetup Entity [msdyn_quoteinvoicingsetup_ProcessSession](msdyn_quoteinvoicingsetup.md#BKMK_msdyn_quoteinvoicingsetup_ProcessSession) One-To-Many relationship.

### <a name="BKMK_msdyn_resourcepaytype_ProcessSession"></a> msdyn_resourcepaytype_ProcessSession

See msdyn_resourcepaytype Entity [msdyn_resourcepaytype_ProcessSession](msdyn_resourcepaytype.md#BKMK_msdyn_resourcepaytype_ProcessSession) One-To-Many relationship.

### <a name="BKMK_msdyn_rma_ProcessSession"></a> msdyn_rma_ProcessSession

See msdyn_rma Entity [msdyn_rma_ProcessSession](msdyn_rma.md#BKMK_msdyn_rma_ProcessSession) One-To-Many relationship.

### <a name="BKMK_msdyn_rmaproduct_ProcessSession"></a> msdyn_rmaproduct_ProcessSession

See msdyn_rmaproduct Entity [msdyn_rmaproduct_ProcessSession](msdyn_rmaproduct.md#BKMK_msdyn_rmaproduct_ProcessSession) One-To-Many relationship.

### <a name="BKMK_msdyn_rmareceipt_ProcessSession"></a> msdyn_rmareceipt_ProcessSession

See msdyn_rmareceipt Entity [msdyn_rmareceipt_ProcessSession](msdyn_rmareceipt.md#BKMK_msdyn_rmareceipt_ProcessSession) One-To-Many relationship.

### <a name="BKMK_msdyn_rmareceiptproduct_ProcessSession"></a> msdyn_rmareceiptproduct_ProcessSession

See msdyn_rmareceiptproduct Entity [msdyn_rmareceiptproduct_ProcessSession](msdyn_rmareceiptproduct.md#BKMK_msdyn_rmareceiptproduct_ProcessSession) One-To-Many relationship.

### <a name="BKMK_msdyn_rmasubstatus_ProcessSession"></a> msdyn_rmasubstatus_ProcessSession

See msdyn_rmasubstatus Entity [msdyn_rmasubstatus_ProcessSession](msdyn_rmasubstatus.md#BKMK_msdyn_rmasubstatus_ProcessSession) One-To-Many relationship.

### <a name="BKMK_msdyn_rtv_ProcessSession"></a> msdyn_rtv_ProcessSession

See msdyn_rtv Entity [msdyn_rtv_ProcessSession](msdyn_rtv.md#BKMK_msdyn_rtv_ProcessSession) One-To-Many relationship.

### <a name="BKMK_msdyn_rtvproduct_ProcessSession"></a> msdyn_rtvproduct_ProcessSession

See msdyn_rtvproduct Entity [msdyn_rtvproduct_ProcessSession](msdyn_rtvproduct.md#BKMK_msdyn_rtvproduct_ProcessSession) One-To-Many relationship.

### <a name="BKMK_msdyn_rtvsubstatus_ProcessSession"></a> msdyn_rtvsubstatus_ProcessSession

See msdyn_rtvsubstatus Entity [msdyn_rtvsubstatus_ProcessSession](msdyn_rtvsubstatus.md#BKMK_msdyn_rtvsubstatus_ProcessSession) One-To-Many relationship.

### <a name="BKMK_msdyn_servicetasktype_ProcessSession"></a> msdyn_servicetasktype_ProcessSession

See msdyn_servicetasktype Entity [msdyn_servicetasktype_ProcessSession](msdyn_servicetasktype.md#BKMK_msdyn_servicetasktype_ProcessSession) One-To-Many relationship.

### <a name="BKMK_msdyn_shipvia_ProcessSession"></a> msdyn_shipvia_ProcessSession

See msdyn_shipvia Entity [msdyn_shipvia_ProcessSession](msdyn_shipvia.md#BKMK_msdyn_shipvia_ProcessSession) One-To-Many relationship.

### <a name="BKMK_msdyn_taxcode_ProcessSession"></a> msdyn_taxcode_ProcessSession

See msdyn_taxcode Entity [msdyn_taxcode_ProcessSession](msdyn_taxcode.md#BKMK_msdyn_taxcode_ProcessSession) One-To-Many relationship.

### <a name="BKMK_msdyn_taxcodedetail_ProcessSession"></a> msdyn_taxcodedetail_ProcessSession

See msdyn_taxcodedetail Entity [msdyn_taxcodedetail_ProcessSession](msdyn_taxcodedetail.md#BKMK_msdyn_taxcodedetail_ProcessSession) One-To-Many relationship.

### <a name="BKMK_msdyn_timeoffrequest_ProcessSession"></a> msdyn_timeoffrequest_ProcessSession

See msdyn_timeoffrequest Entity [msdyn_timeoffrequest_ProcessSession](msdyn_timeoffrequest.md#BKMK_msdyn_timeoffrequest_ProcessSession) One-To-Many relationship.

### <a name="BKMK_msdyn_uniquenumber_ProcessSession"></a> msdyn_uniquenumber_ProcessSession

See msdyn_uniquenumber Entity [msdyn_uniquenumber_ProcessSession](msdyn_uniquenumber.md#BKMK_msdyn_uniquenumber_ProcessSession) One-To-Many relationship.

### <a name="BKMK_msdyn_warehouse_ProcessSession"></a> msdyn_warehouse_ProcessSession

See msdyn_warehouse Entity [msdyn_warehouse_ProcessSession](msdyn_warehouse.md#BKMK_msdyn_warehouse_ProcessSession) One-To-Many relationship.

### <a name="BKMK_msdyn_workorder_ProcessSession"></a> msdyn_workorder_ProcessSession

See msdyn_workorder Entity [msdyn_workorder_ProcessSession](msdyn_workorder.md#BKMK_msdyn_workorder_ProcessSession) One-To-Many relationship.

### <a name="BKMK_msdyn_workordercharacteristic_ProcessSession"></a> msdyn_workordercharacteristic_ProcessSession

See msdyn_workordercharacteristic Entity [msdyn_workordercharacteristic_ProcessSession](msdyn_workordercharacteristic.md#BKMK_msdyn_workordercharacteristic_ProcessSession) One-To-Many relationship.

### <a name="BKMK_msdyn_workorderdetailsgenerationqueue_ProcessSession"></a> msdyn_workorderdetailsgenerationqueue_ProcessSession

See msdyn_workorderdetailsgenerationqueue Entity [msdyn_workorderdetailsgenerationqueue_ProcessSession](msdyn_workorderdetailsgenerationqueue.md#BKMK_msdyn_workorderdetailsgenerationqueue_ProcessSession) One-To-Many relationship.

### <a name="BKMK_msdyn_workorderincident_ProcessSession"></a> msdyn_workorderincident_ProcessSession

See msdyn_workorderincident Entity [msdyn_workorderincident_ProcessSession](msdyn_workorderincident.md#BKMK_msdyn_workorderincident_ProcessSession) One-To-Many relationship.

### <a name="BKMK_msdyn_workorderproduct_ProcessSession"></a> msdyn_workorderproduct_ProcessSession

See msdyn_workorderproduct Entity [msdyn_workorderproduct_ProcessSession](msdyn_workorderproduct.md#BKMK_msdyn_workorderproduct_ProcessSession) One-To-Many relationship.

### <a name="BKMK_msdyn_workorderresourcerestriction_ProcessSession"></a> msdyn_workorderresourcerestriction_ProcessSession

See msdyn_workorderresourcerestriction Entity [msdyn_workorderresourcerestriction_ProcessSession](msdyn_workorderresourcerestriction.md#BKMK_msdyn_workorderresourcerestriction_ProcessSession) One-To-Many relationship.

### <a name="BKMK_msdyn_workorderservice_ProcessSession"></a> msdyn_workorderservice_ProcessSession

See msdyn_workorderservice Entity [msdyn_workorderservice_ProcessSession](msdyn_workorderservice.md#BKMK_msdyn_workorderservice_ProcessSession) One-To-Many relationship.

### <a name="BKMK_msdyn_workorderservicetask_ProcessSession"></a> msdyn_workorderservicetask_ProcessSession

See msdyn_workorderservicetask Entity [msdyn_workorderservicetask_ProcessSession](msdyn_workorderservicetask.md#BKMK_msdyn_workorderservicetask_ProcessSession) One-To-Many relationship.

### <a name="BKMK_msdyn_workordersubstatus_ProcessSession"></a> msdyn_workordersubstatus_ProcessSession

See msdyn_workordersubstatus Entity [msdyn_workordersubstatus_ProcessSession](msdyn_workordersubstatus.md#BKMK_msdyn_workordersubstatus_ProcessSession) One-To-Many relationship.

### <a name="BKMK_msdyn_workordertype_ProcessSession"></a> msdyn_workordertype_ProcessSession

See msdyn_workordertype Entity [msdyn_workordertype_ProcessSession](msdyn_workordertype.md#BKMK_msdyn_workordertype_ProcessSession) One-To-Many relationship.

### <a name="BKMK_theme_ProcessSession"></a> theme_ProcessSession

See theme Entity [theme_ProcessSession](theme.md#BKMK_theme_ProcessSession) One-To-Many relationship.

### <a name="BKMK_usermapping_ProcessSession"></a> usermapping_ProcessSession

See usermapping Entity [usermapping_ProcessSession](usermapping.md#BKMK_usermapping_ProcessSession) One-To-Many relationship.

### <a name="BKMK_knowledgearticle_ProcessSession"></a> knowledgearticle_ProcessSession

See knowledgearticle Entity [knowledgearticle_ProcessSession](knowledgearticle.md#BKMK_knowledgearticle_ProcessSession) One-To-Many relationship.

### <a name="BKMK_position_ProcessSession"></a> position_ProcessSession

See position Entity [position_ProcessSession](position.md#BKMK_position_ProcessSession) One-To-Many relationship.

### <a name="BKMK_channelaccessprofile_ProcessSession"></a> channelaccessprofile_ProcessSession

See channelaccessprofile Entity [channelaccessprofile_ProcessSession](channelaccessprofile.md#BKMK_channelaccessprofile_ProcessSession) One-To-Many relationship.

### <a name="BKMK_externalparty_ProcessSession"></a> externalparty_ProcessSession

See externalparty Entity [externalparty_ProcessSession](externalparty.md#BKMK_externalparty_ProcessSession) One-To-Many relationship.

### <a name="BKMK_profilerule_ProcessSession"></a> profilerule_ProcessSession

See channelaccessprofilerule Entity [profilerule_ProcessSession](channelaccessprofilerule.md#BKMK_profilerule_ProcessSession) One-To-Many relationship.

### <a name="BKMK_KnowledgeBaseRecord_ProcessSession"></a> KnowledgeBaseRecord_ProcessSession

See knowledgebaserecord Entity [KnowledgeBaseRecord_ProcessSession](knowledgebaserecord.md#BKMK_KnowledgeBaseRecord_ProcessSession) One-To-Many relationship.

### <a name="BKMK_SharePointSite_ProcessSessions"></a> SharePointSite_ProcessSessions

See sharepointsite Entity [SharePointSite_ProcessSessions](sharepointsite.md#BKMK_SharePointSite_ProcessSessions) One-To-Many relationship.

### <a name="BKMK_MailMergeTemplate_ProcessSessions"></a> MailMergeTemplate_ProcessSessions

See mailmergetemplate Entity [MailMergeTemplate_ProcessSessions](mailmergetemplate.md#BKMK_MailMergeTemplate_ProcessSessions) One-To-Many relationship.

### <a name="BKMK_Annotation_ProcessSessions"></a> Annotation_ProcessSessions

See annotation Entity [Annotation_ProcessSessions](annotation.md#BKMK_Annotation_ProcessSessions) One-To-Many relationship.

### <a name="BKMK_routingrule_ProcessSessions"></a> routingrule_ProcessSessions

See routingrule Entity [routingrule_ProcessSessions](routingrule.md#BKMK_routingrule_ProcessSessions) One-To-Many relationship.

### <a name="BKMK_BusinessUnitNewsArticle_ProcessSessions"></a> BusinessUnitNewsArticle_ProcessSessions

See businessunitnewsarticle Entity [BusinessUnitNewsArticle_ProcessSessions](businessunitnewsarticle.md#BKMK_BusinessUnitNewsArticle_ProcessSessions) One-To-Many relationship.

### <a name="BKMK_Appointment_ProcessSessions"></a> Appointment_ProcessSessions

See appointment Entity [Appointment_ProcessSessions](appointment.md#BKMK_Appointment_ProcessSessions) One-To-Many relationship.

### <a name="BKMK_QueueItem_ProcessSessions"></a> QueueItem_ProcessSessions

See queueitem Entity [QueueItem_ProcessSessions](queueitem.md#BKMK_QueueItem_ProcessSessions) One-To-Many relationship.

### <a name="BKMK_lk_processsession_previouslinkedsessionid"></a> lk_processsession_previouslinkedsessionid

See processsession Entity [lk_processsession_previouslinkedsessionid](processsession.md#BKMK_lk_processsession_previouslinkedsessionid) One-To-Many relationship.

### <a name="BKMK_lk_processsession_nextlinkedsessionid"></a> lk_processsession_nextlinkedsessionid

See processsession Entity [lk_processsession_nextlinkedsessionid](processsession.md#BKMK_lk_processsession_nextlinkedsessionid) One-To-Many relationship.

### <a name="BKMK_lk_processsession_originatingsessionid"></a> lk_processsession_originatingsessionid

See processsession Entity [lk_processsession_originatingsessionid](processsession.md#BKMK_lk_processsession_originatingsessionid) One-To-Many relationship.

### <a name="BKMK_Team_ProcessSessions"></a> Team_ProcessSessions

See team Entity [Team_ProcessSessions](team.md#BKMK_Team_ProcessSessions) One-To-Many relationship.

### <a name="BKMK_Goal_ProcessSessions"></a> Goal_ProcessSessions

See goal Entity [Goal_ProcessSessions](goal.md#BKMK_Goal_ProcessSessions) One-To-Many relationship.

### <a name="BKMK_mailbox_processsessions"></a> mailbox_processsessions

See mailbox Entity [mailbox_processsessions](mailbox.md#BKMK_mailbox_processsessions) One-To-Many relationship.

### <a name="BKMK_TranslationProcess_ProcessSessions"></a> TranslationProcess_ProcessSessions

See translationprocess Entity [TranslationProcess_ProcessSessions](translationprocess.md#BKMK_TranslationProcess_ProcessSessions) One-To-Many relationship.

### <a name="BKMK_SystemUser_ProcessSessions"></a> SystemUser_ProcessSessions

See systemuser Entity [SystemUser_ProcessSessions](systemuser.md#BKMK_SystemUser_ProcessSessions) One-To-Many relationship.

### <a name="BKMK_BusinessUnit_ProcessSessions"></a> BusinessUnit_ProcessSessions

See businessunit Entity [BusinessUnit_ProcessSessions](businessunit.md#BKMK_BusinessUnit_ProcessSessions) One-To-Many relationship.

### <a name="BKMK_KbArticleComment_ProcessSessions"></a> KbArticleComment_ProcessSessions

See kbarticlecomment Entity [KbArticleComment_ProcessSessions](kbarticlecomment.md#BKMK_KbArticleComment_ProcessSessions) One-To-Many relationship.

### <a name="BKMK_lk_processsession_canceledby"></a> lk_processsession_canceledby

See systemuser Entity [lk_processsession_canceledby](systemuser.md#BKMK_lk_processsession_canceledby) One-To-Many relationship.

### <a name="BKMK_goalrollupquery_ProcessSessions"></a> goalrollupquery_ProcessSessions

See goalrollupquery Entity [goalrollupquery_ProcessSessions](goalrollupquery.md#BKMK_goalrollupquery_ProcessSessions) One-To-Many relationship.

### <a name="BKMK_rollupfield_ProcessSessions"></a> rollupfield_ProcessSessions

See rollupfield Entity [rollupfield_ProcessSessions](rollupfield.md#BKMK_rollupfield_ProcessSessions) One-To-Many relationship.

### <a name="BKMK_ConvertRule_ProcessSessions"></a> ConvertRule_ProcessSessions

See convertrule Entity [ConvertRule_ProcessSessions](convertrule.md#BKMK_ConvertRule_ProcessSessions) One-To-Many relationship.

### <a name="BKMK_SharePointDocumentLocation_ProcessSessions"></a> SharePointDocumentLocation_ProcessSessions

See sharepointdocumentlocation Entity [SharePointDocumentLocation_ProcessSessions](sharepointdocumentlocation.md#BKMK_SharePointDocumentLocation_ProcessSessions) One-To-Many relationship.

### <a name="BKMK_lk_processsession_startedby"></a> lk_processsession_startedby

See systemuser Entity [lk_processsession_startedby](systemuser.md#BKMK_lk_processsession_startedby) One-To-Many relationship.

### <a name="BKMK_Account_ProcessSessions"></a> Account_ProcessSessions

See account Entity [Account_ProcessSessions](account.md#BKMK_Account_ProcessSessions) One-To-Many relationship.

### <a name="BKMK_PhoneCall_ProcessSessions"></a> PhoneCall_ProcessSessions

See phonecall Entity [PhoneCall_ProcessSessions](phonecall.md#BKMK_PhoneCall_ProcessSessions) One-To-Many relationship.

### <a name="BKMK_externalpartyitem_ProcessSession"></a> externalpartyitem_ProcessSession

See externalpartyitem Entity [externalpartyitem_ProcessSession](externalpartyitem.md#BKMK_externalpartyitem_ProcessSession) One-To-Many relationship.

### <a name="BKMK_slabase_ProcessSessions"></a> slabase_ProcessSessions

See sla Entity [slabase_ProcessSessions](sla.md#BKMK_slabase_ProcessSessions) One-To-Many relationship.

### <a name="BKMK_lk_processsession_createdby"></a> lk_processsession_createdby

See systemuser Entity [lk_processsession_createdby](systemuser.md#BKMK_lk_processsession_createdby) One-To-Many relationship.

### <a name="BKMK_lk_processsessionbase_modifiedonbehalfby"></a> lk_processsessionbase_modifiedonbehalfby

See systemuser Entity [lk_processsessionbase_modifiedonbehalfby](systemuser.md#BKMK_lk_processsessionbase_modifiedonbehalfby) One-To-Many relationship.

### <a name="BKMK_Template_ProcessSessions"></a> Template_ProcessSessions

See template Entity [Template_ProcessSessions](template.md#BKMK_Template_ProcessSessions) One-To-Many relationship.

### <a name="BKMK_NewProcess_ProcessSessions"></a> NewProcess_ProcessSessions

See newprocess Entity [NewProcess_ProcessSessions](newprocess.md#BKMK_NewProcess_ProcessSessions) One-To-Many relationship.

### <a name="BKMK_Report_ProcessSessions"></a> Report_ProcessSessions

See report Entity [Report_ProcessSessions](report.md#BKMK_Report_ProcessSessions) One-To-Many relationship.

### <a name="BKMK_Owning_businessunit_processsessions"></a> Owning_businessunit_processsessions

See businessunit Entity [Owning_businessunit_processsessions](businessunit.md#BKMK_Owning_businessunit_processsessions) One-To-Many relationship.

### <a name="BKMK_CustomerAddress_ProcessSessions"></a> CustomerAddress_ProcessSessions

See customeraddress Entity [CustomerAddress_ProcessSessions](customeraddress.md#BKMK_CustomerAddress_ProcessSessions) One-To-Many relationship.

### <a name="BKMK_Connection_ProcessSessions"></a> Connection_ProcessSessions

See connection Entity [Connection_ProcessSessions](connection.md#BKMK_Connection_ProcessSessions) One-To-Many relationship.

### <a name="BKMK_lk_processsession_executedby"></a> lk_processsession_executedby

See systemuser Entity [lk_processsession_executedby](systemuser.md#BKMK_lk_processsession_executedby) One-To-Many relationship.

### <a name="BKMK_team_processsession"></a> team_processsession

See team Entity [team_processsession](team.md#BKMK_team_processsession) One-To-Many relationship.

### <a name="BKMK_metric_ProcessSessions"></a> metric_ProcessSessions

See metric Entity [metric_ProcessSessions](metric.md#BKMK_metric_ProcessSessions) One-To-Many relationship.

### <a name="BKMK_ExpiredProcess_ProcessSessions"></a> ExpiredProcess_ProcessSessions

See expiredprocess Entity [ExpiredProcess_ProcessSessions](expiredprocess.md#BKMK_ExpiredProcess_ProcessSessions) One-To-Many relationship.

### <a name="BKMK_KbArticle_ProcessSessions"></a> KbArticle_ProcessSessions

See kbarticle Entity [KbArticle_ProcessSessions](kbarticle.md#BKMK_KbArticle_ProcessSessions) One-To-Many relationship.

### <a name="BKMK_SocialActivity_ProcessSessions"></a> SocialActivity_ProcessSessions

See socialactivity Entity [SocialActivity_ProcessSessions](socialactivity.md#BKMK_SocialActivity_ProcessSessions) One-To-Many relationship.

### <a name="BKMK_Task_ProcessSessions"></a> Task_ProcessSessions

See task Entity [Task_ProcessSessions](task.md#BKMK_Task_ProcessSessions) One-To-Many relationship.

### <a name="BKMK_lk_processsession_processid"></a> lk_processsession_processid

See workflow Entity [lk_processsession_processid](workflow.md#BKMK_lk_processsession_processid) One-To-Many relationship.

### <a name="BKMK_lk_processsession_modifiedby"></a> lk_processsession_modifiedby

See systemuser Entity [lk_processsession_modifiedby](systemuser.md#BKMK_lk_processsession_modifiedby) One-To-Many relationship.

### <a name="BKMK_ConnectionRole_ProcessSessions"></a> ConnectionRole_ProcessSessions

See connectionrole Entity [ConnectionRole_ProcessSessions](connectionrole.md#BKMK_ConnectionRole_ProcessSessions) One-To-Many relationship.

### <a name="BKMK_TransactionCurrency_ProcessSessions"></a> TransactionCurrency_ProcessSessions

See transactioncurrency Entity [TransactionCurrency_ProcessSessions](transactioncurrency.md#BKMK_TransactionCurrency_ProcessSessions) One-To-Many relationship.

### <a name="BKMK_Fax_ProcessSessions"></a> Fax_ProcessSessions

See fax Entity [Fax_ProcessSessions](fax.md#BKMK_Fax_ProcessSessions) One-To-Many relationship.

### <a name="BKMK_KbArticleTemplate_ProcessSessions"></a> KbArticleTemplate_ProcessSessions

See kbarticletemplate Entity [KbArticleTemplate_ProcessSessions](kbarticletemplate.md#BKMK_KbArticleTemplate_ProcessSessions) One-To-Many relationship.

### <a name="BKMK_Letter_ProcessSessions"></a> Letter_ProcessSessions

See letter Entity [Letter_ProcessSessions](letter.md#BKMK_Letter_ProcessSessions) One-To-Many relationship.

### <a name="BKMK_RelationshipRole_ProcessSessions"></a> RelationshipRole_ProcessSessions

See relationshiprole Entity [RelationshipRole_ProcessSessions](relationshiprole.md#BKMK_RelationshipRole_ProcessSessions) One-To-Many relationship.

### <a name="BKMK_CustomerRelationship_ProcessSessions"></a> CustomerRelationship_ProcessSessions

See customerrelationship Entity [CustomerRelationship_ProcessSessions](customerrelationship.md#BKMK_CustomerRelationship_ProcessSessions) One-To-Many relationship.

### <a name="BKMK_RecurringAppointmentMaster_ProcessSessions"></a> RecurringAppointmentMaster_ProcessSessions

See recurringappointmentmaster Entity [RecurringAppointmentMaster_ProcessSessions](recurringappointmentmaster.md#BKMK_RecurringAppointmentMaster_ProcessSessions) One-To-Many relationship.

### <a name="BKMK_Email_ProcessSessions"></a> Email_ProcessSessions

See email Entity [Email_ProcessSessions](email.md#BKMK_Email_ProcessSessions) One-To-Many relationship.

### <a name="BKMK_lk_processsession_completedby"></a> lk_processsession_completedby

See systemuser Entity [lk_processsession_completedby](systemuser.md#BKMK_lk_processsession_completedby) One-To-Many relationship.

### <a name="BKMK_Contact_ProcessSessions"></a> Contact_ProcessSessions

See contact Entity [Contact_ProcessSessions](contact.md#BKMK_Contact_ProcessSessions) One-To-Many relationship.

### <a name="BKMK_Queue_ProcessSessions"></a> Queue_ProcessSessions

See queue Entity [Queue_ProcessSessions](queue.md#BKMK_Queue_ProcessSessions) One-To-Many relationship.

### <a name="BKMK_lk_processsessionbase_createdonbehalfby"></a> lk_processsessionbase_createdonbehalfby

See systemuser Entity [lk_processsessionbase_createdonbehalfby](systemuser.md#BKMK_lk_processsessionbase_createdonbehalfby) One-To-Many relationship.

### <a name="BKMK_routingruleitem_ProcessSessions"></a> routingruleitem_ProcessSessions

See routingruleitem Entity [routingruleitem_ProcessSessions](routingruleitem.md#BKMK_routingruleitem_ProcessSessions) One-To-Many relationship.

### <a name="BKMK_Subject_ProcessSessions"></a> Subject_ProcessSessions

See subject Entity [Subject_ProcessSessions](subject.md#BKMK_Subject_ProcessSessions) One-To-Many relationship.

### <a name="BKMK_SocialProfile_ProcessSessions"></a> SocialProfile_ProcessSessions

See socialprofile Entity [SocialProfile_ProcessSessions](socialprofile.md#BKMK_SocialProfile_ProcessSessions) One-To-Many relationship.

## See also

[About the Entity Reference](../about-entity-reference.md)<br />
[Programming reference for Dynamics 365 Customer Engagement](../programming-reference.md)<br />
[Web API Reference](/dynamics365/customer-engagement/web-api/about)<br />
<xref href="Microsoft.Dynamics.CRM.processsession?text=processsession EntityType" />