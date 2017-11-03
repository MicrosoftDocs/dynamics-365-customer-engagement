---
title: "AsyncOperation Entity Reference (Developer Guide for Dynamics 365 Customer Engagement)| MicrosoftDocs"
description: "Includes schema information and supported messages for the AsyncOperation entity."
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
# AsyncOperation Entity Reference

[!INCLUDE[](../../includes/cc_applies_to_update_9_0_0.md)]

Process whose execution can proceed independently or in the background.


## Messages

|Message|Web API Operation|SDK Assembly|
|-|-|-|
|Create|POST [*org URI*]/api/data/v9.0/asyncoperations<br />See [Create](../webapi/create-entity-web-api.md)|<xref:Microsoft.Xrm.Sdk.Messages.CreateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Create*>|
|Delete|DELETE [*org URI*]/api/data/v9.0/asyncoperations(*asyncoperationid*)<br />See [Delete](../webapi/update-delete-entities-using-web-api.md#basic-delete)|<xref:Microsoft.Xrm.Sdk.Messages.DeleteRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Delete*>|
|Retrieve|GET [*org URI*]/api/data/v9.0/asyncoperations(*asyncoperationid*)<br />See [Retrieve](../webapi/retrieve-entity-using-web-api.md)|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Retrieve*>|
|RetrieveMultiple|GET [*org URI*]/api/data/v9.0/asyncoperations<br />See [Query Data](../webapi/query-data-web-api.md)|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveMultipleRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.RetrieveMultiple*>|
|RetrievePrincipalAccess|<xref href="Microsoft.Dynamics.CRM.RetrievePrincipalAccess?text=RetrievePrincipalAccess Function" />|<xref:Microsoft.Crm.Sdk.Messages.RetrievePrincipalAccessRequest>|
|Update|PATCH [*org URI*]/api/data/v9.0/asyncoperations(*asyncoperationid*)<br />See [Update](../webapi/update-delete-entities-using-web-api.md#basic-update)|<xref:Microsoft.Xrm.Sdk.Messages.UpdateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Update*>|

## Properties

**DisplayName**: System Job<br />
**DisplayCollectionName**: System Jobs<br />
**SchemaName**: AsyncOperation<br />
**CollectionSchemaName**: AsyncOperations<br />
**LogicalName**: asyncoperation<br />
**LogicalCollectionName**: asyncoperations<br />
**EntitySetName**: asyncoperations<br />
**PrimaryIdAttribute**: asyncoperationid<br />
**PrimaryNameAttribute**: name<br />
**OwnershipType**: UserOwned<br />
**IsBPFEntity**: False<br />
<a name="writable-attributes"></a>

## Writable attributes

These attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [AsyncOperationId](#BKMK_AsyncOperationId)
- [CorrelationId](#BKMK_CorrelationId)
- [CorrelationUpdatedTime](#BKMK_CorrelationUpdatedTime)
- [Data](#BKMK_Data)
- [DependencyToken](#BKMK_DependencyToken)
- [Depth](#BKMK_Depth)
- [FriendlyMessage](#BKMK_FriendlyMessage)
- [HostId](#BKMK_HostId)
- [MessageName](#BKMK_MessageName)
- [Name](#BKMK_Name)
- [OperationType](#BKMK_OperationType)
- [OwnerId](#BKMK_OwnerId)
- [OwnerIdType](#BKMK_OwnerIdType)
- [OwningExtensionId](#BKMK_OwningExtensionId)
- [OwningExtensionIdName](#BKMK_OwningExtensionIdName)
- [OwningExtensionTypeCode](#BKMK_OwningExtensionTypeCode)
- [ParentPluginExecutionId](#BKMK_ParentPluginExecutionId)
- [PostponeUntil](#BKMK_PostponeUntil)
- [PrimaryEntityType](#BKMK_PrimaryEntityType)
- [RecurrencePattern](#BKMK_RecurrencePattern)
- [RecurrenceStartTime](#BKMK_RecurrenceStartTime)
- [RegardingObjectId](#BKMK_RegardingObjectId)
- [RegardingObjectIdName](#BKMK_RegardingObjectIdName)
- [RegardingObjectIdYomiName](#BKMK_RegardingObjectIdYomiName)
- [RegardingObjectTypeCode](#BKMK_RegardingObjectTypeCode)
- [RequestId](#BKMK_RequestId)
- [StateCode](#BKMK_StateCode)
- [StatusCode](#BKMK_StatusCode)
- [TimeZoneRuleVersionNumber](#BKMK_TimeZoneRuleVersionNumber)
- [UTCConversionTimeZoneCode](#BKMK_UTCConversionTimeZoneCode)
- [WorkflowActivationId](#BKMK_WorkflowActivationId)


### <a name="BKMK_AsyncOperationId"></a> AsyncOperationId

**Description**: Unique identifier of the system job.<br />
**DisplayName**: System Job<br />
**LogicalName**: asyncoperationid<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: SystemRequired<br />
**IsValidForUpdate**: False<br />
**Type**: Uniqueidentifier<br />


### <a name="BKMK_CorrelationId"></a> CorrelationId

**Description**: Unique identifier used to correlate between multiple SDK requests and system jobs.<br />
**DisplayName**: Correlation Id<br />
**LogicalName**: correlationid<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: SystemRequired<br />
**IsValidForUpdate**: False<br />
**Type**: Uniqueidentifier<br />


### <a name="BKMK_CorrelationUpdatedTime"></a> CorrelationUpdatedTime

**Description**: Last time the correlation depth was updated.<br />
**DisplayName**: Correlation Updated Time<br />
**LogicalName**: correlationupdatedtime<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: SystemRequired<br />
**IsValidForUpdate**: False<br />
**Type**: DateTime<br />
**DateTimeBehavior**: UserLocal<br />
**Format**: DateAndTime


### <a name="BKMK_Data"></a> Data

**Description**: Unstructured data associated with the system job.<br />
**DisplayName**: Data<br />
**LogicalName**: data<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**IsValidForUpdate**: False<br />
**Type**: Memo<br />
**Format**: TextArea<br />
**IsLocalizable**: False<br />
**MaxLength**: 1073741823


### <a name="BKMK_DependencyToken"></a> DependencyToken

**Description**: Execution of all operations with the same dependency token is serialized.<br />
**DisplayName**: Dependency Token<br />
**LogicalName**: dependencytoken<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**IsValidForUpdate**: False<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 256


### <a name="BKMK_Depth"></a> Depth

**Description**: Number of SDK calls made since the first call.<br />
**DisplayName**: Depth<br />
**LogicalName**: depth<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: SystemRequired<br />
**IsValidForUpdate**: False<br />
**Type**: Integer<br />
**Format**: None<br />
**MaxValue**: 2147483647<br />
**MinValue**: 0


### <a name="BKMK_FriendlyMessage"></a> FriendlyMessage

**Description**: Message provided by the system job.<br />
**DisplayName**: Friendly message<br />
**LogicalName**: friendlymessage<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**IsValidForCreate**: False<br />
**Type**: Memo<br />
**Format**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100000


### <a name="BKMK_HostId"></a> HostId

**Description**: Unique identifier of the host that owns this system job.<br />
**DisplayName**: Host<br />
**LogicalName**: hostid<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**IsValidForUpdate**: False<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 256


### <a name="BKMK_MessageName"></a> MessageName

**Description**: Name of the message that started this system job.<br />
**DisplayName**: Message Name<br />
**LogicalName**: messagename<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**IsValidForUpdate**: False<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 160


### <a name="BKMK_Name"></a> Name

**Description**: Name of the system job.<br />
**DisplayName**: System Job Name<br />
**LogicalName**: name<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**IsValidForUpdate**: False<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 256


### <a name="BKMK_OperationType"></a> OperationType

**Description**: Type of the system job.<br />
**DisplayName**: System Job Type<br />
**LogicalName**: operationtype<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**IsValidForUpdate**: False<br />
**Type**: Picklist<br />
**Options**:

- **Value**: 1 **Label**: System Event
- **Value**: 2 **Label**: Bulk Email
- **Value**: 3 **Label**: Import File Parse
- **Value**: 4 **Label**: Transform Parse Data
- **Value**: 5 **Label**: Import
- **Value**: 6 **Label**: Activity Propagation
- **Value**: 7 **Label**: Duplicate Detection Rule Publish
- **Value**: 8 **Label**: Bulk Duplicate Detection
- **Value**: 9 **Label**: SQM Data Collection
- **Value**: 10 **Label**: Workflow
- **Value**: 11 **Label**: Quick Campaign
- **Value**: 12 **Label**: Matchcode Update
- **Value**: 13 **Label**: Bulk Delete
- **Value**: 14 **Label**: Deletion Service
- **Value**: 15 **Label**: Index Management
- **Value**: 16 **Label**: Collect Organization Statistics
- **Value**: 17 **Label**: Import Subprocess
- **Value**: 18 **Label**: Calculate Organization Storage Size
- **Value**: 19 **Label**: Collect Organization Database Statistics
- **Value**: 20 **Label**: Collection Organization Size Statistics
- **Value**: 21 **Label**: Database Tuning
- **Value**: 22 **Label**: Calculate Organization Maximum Storage Size
- **Value**: 23 **Label**: Bulk Delete Subprocess
- **Value**: 24 **Label**: Update Statistic Intervals
- **Value**: 25 **Label**: Organization Full Text Catalog Index
- **Value**: 26 **Label**: Database log backup
- **Value**: 27 **Label**: Update Contract States
- **Value**: 28 **Label**: DBCC SHRINKDATABASE maintenance job
- **Value**: 29 **Label**: DBCC SHRINKFILE maintenance job
- **Value**: 30 **Label**: Reindex all indices maintenance job
- **Value**: 31 **Label**: Storage Limit Notification
- **Value**: 32 **Label**: Cleanup inactive workflow assemblies
- **Value**: 35 **Label**: Recurring Series Expansion
- **Value**: 38 **Label**: Import Sample Data
- **Value**: 40 **Label**: Goal Roll Up
- **Value**: 41 **Label**: Audit Partition Creation
- **Value**: 42 **Label**: Check For Language Pack Updates
- **Value**: 43 **Label**: Provision Language Pack
- **Value**: 44 **Label**: Update Organization Database
- **Value**: 45 **Label**: Update Solution
- **Value**: 46 **Label**: Regenerate Entity Row Count Snapshot Data
- **Value**: 47 **Label**: Regenerate Read Share Snapshot Data
- **Value**: 49 **Label**: Post to Yammer
- **Value**: 50 **Label**: Outgoing Activity
- **Value**: 51 **Label**: Incoming Email Processing
- **Value**: 52 **Label**: Mailbox Test Access
- **Value**: 53 **Label**: Encryption Health Check
- **Value**: 54 **Label**: Execute Async Request
- **Value**: 56 **Label**: Update Entitlement States
- **Value**: 57 **Label**: Calculate Rollup Field
- **Value**: 58 **Label**: Mass Calculate Rollup Field
- **Value**: 59 **Label**: Import Translation
- **Value**: 62 **Label**: Convert Date And Time Behavior
- **Value**: 63 **Label**: EntityKey Index Creation
- **Value**: 65 **Label**: Update Knowledge Article States
- **Value**: 68 **Label**: Resource Booking Sync
- **Value**: 69 **Label**: Relationship Assistant Cards
- **Value**: 71 **Label**: Cleanup Solution Components
- **Value**: 72 **Label**: App Module Metadata Operation



### <a name="BKMK_OwnerId"></a> OwnerId

**Description**: Unique identifier of the user or team who owns the system job.<br />
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
**Type**: EntityName<br />


### <a name="BKMK_OwningExtensionId"></a> OwningExtensionId

**Description**: Unique identifier of the owning extension with which the system job is associated.<br />
**DisplayName**: Owning Extension<br />
**LogicalName**: owningextensionid<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**IsValidForUpdate**: False<br />
**Type**: Lookup<br />
**Targets**: sdkmessageprocessingstep


### <a name="BKMK_OwningExtensionIdName"></a> OwningExtensionIdName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: owningextensionidname<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**IsValidForUpdate**: False<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 256


### <a name="BKMK_OwningExtensionTypeCode"></a> OwningExtensionTypeCode

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: owningextensiontypecode<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**IsValidForUpdate**: False<br />
**Type**: EntityName<br />


### <a name="BKMK_ParentPluginExecutionId"></a> ParentPluginExecutionId

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: parentpluginexecutionid<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**IsValidForUpdate**: False<br />
**Type**: Uniqueidentifier<br />


### <a name="BKMK_PostponeUntil"></a> PostponeUntil

**Description**: Indicates whether the system job should run only after the specified date and time.<br />
**DisplayName**: Postpone Until<br />
**LogicalName**: postponeuntil<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: DateTime<br />
**DateTimeBehavior**: UserLocal<br />
**Format**: DateAndTime


### <a name="BKMK_PrimaryEntityType"></a> PrimaryEntityType

**Description**: Type of entity with which the system job is primarily associated.<br />
**DisplayName**: Primary Entity Type<br />
**LogicalName**: primaryentitytype<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**IsValidForUpdate**: False<br />
**Type**: EntityName<br />


### <a name="BKMK_RecurrencePattern"></a> RecurrencePattern

**Description**: Pattern of the system job's recurrence.<br />
**DisplayName**: Recurrence Pattern<br />
**LogicalName**: recurrencepattern<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 256


### <a name="BKMK_RecurrenceStartTime"></a> RecurrenceStartTime

**Description**: Starting time in UTC for the recurrence pattern.<br />
**DisplayName**: Recurrence Start<br />
**LogicalName**: recurrencestarttime<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: DateTime<br />
**DateTimeBehavior**: UserLocal<br />
**Format**: DateOnly


### <a name="BKMK_RegardingObjectId"></a> RegardingObjectId

**Description**: Unique identifier of the object with which the system job is associated.<br />
**DisplayName**: Regarding<br />
**LogicalName**: regardingobjectid<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**IsValidForUpdate**: False<br />
**Type**: Lookup<br />
**Targets**: account,accountleads,activitymimeattachment,activitypointer,annotation,annualfiscalcalendar,appointment,attributemap,bookableresource,bookableresourcebooking,bookableresourcebookingexchangesyncidmapping,bookableresourcebookingheader,bookableresourcecategory,bookableresourcecategoryassn,bookableresourcecharacteristic,bookableresourcegroup,bookingstatus,bulkoperation,bulkoperationlog,businessunit,businessunitnewsarticle,calendar,campaign,campaignactivity,campaignactivityitem,campaignitem,campaignresponse,channelaccessprofile,channelaccessprofilerule,characteristic,childincidentcount,commitment,competitor,competitoraddress,competitorproduct,competitorsalesliterature,connection,connectionrole,constraintbasedgroup,contact,contactinvoices,contactleads,contactorders,contactquotes,contract,contractdetail,contracttemplate,convertrule,customeraddress,customeropportunityrole,customerrelationship,discount,discounttype,displaystring,dynamicproperty,dynamicpropertyassociation,dynamicpropertyinstance,dynamicpropertyoptionsetitem,email,emailserverprofile,entitlement,entitlementchannel,entitlementcontacts,entitlementproducts,entitlementtemplate,entitlementtemplatechannel,entitlementtemplateproducts,entitymap,equipment,externalparty,externalpartyitem,fax,fixedmonthlyfiscalcalendar,goal,goalrollupquery,import,importdata,importfile,importlog,importmap,incident,incidentknowledgebaserecord,incidentresolution,interactionforemail,invoice,invoicedetail,isvconfig,kbarticle,kbarticlecomment,kbarticletemplate,knowledgearticle,knowledgearticleincident,knowledgebaserecord,lead,leadaddress,leadcompetitors,leadproduct,leadtoopportunitysalesprocess,letter,list,listmember,mailbox,mailmergetemplate,metric,monthlyfiscalcalendar,msdyn_accountpricelist,msdyn_actual,msdyn_agreement,msdyn_agreementbookingdate,msdyn_agreementbookingincident,msdyn_agreementbookingproduct,msdyn_agreementbookingservice,msdyn_agreementbookingservicetask,msdyn_agreementbookingsetup,msdyn_agreementinvoicedate,msdyn_agreementinvoiceproduct,msdyn_agreementinvoicesetup,msdyn_agreementsubstatus,msdyn_approval,msdyn_batchjob,msdyn_bookingalert,msdyn_bookingalertstatus,msdyn_bookingchange,msdyn_bookingjournal,msdyn_bookingrule,msdyn_bookingsetupmetadata,msdyn_bookingtimestamp,msdyn_bpf_2c5fe86acc8b414b8322ae571000c799,msdyn_bpf_477c16f59170487b8b4dc895c5dcd09b,msdyn_bpf_665e73aa18c247d886bfc50499c73b82,msdyn_bpf_989e9b1857e24af18787d5143b67523b,msdyn_bpf_baa0a411a239410cb8bded8b5fdd88e3,msdyn_bpf_d3d97bac8c294105840e99e37a9d1c39,msdyn_bpf_d8f9dc7f099f44db9d641dd81fbd470d,msdyn_characteristicreqforteammember,msdyn_clientextension,msdyn_configuration,msdyn_contactpricelist,msdyn_contractlineinvoiceschedule,msdyn_contractlinescheduleofvalue,msdyn_customerasset,msdyn_dataexport,msdyn_delegation,msdyn_estimate,msdyn_estimateline,msdyn_expense,msdyn_expensecategory,msdyn_expensereceipt,msdyn_fact,msdyn_fieldcomputation,msdyn_fieldservicepricelistitem,msdyn_fieldservicesetting,msdyn_fieldservicesystemjob,msdyn_findworkevent,msdyn_incidenttype,msdyn_incidenttypecharacteristic,msdyn_incidenttypeproduct,msdyn_incidenttypeservice,msdyn_incidenttypeservicetask,msdyn_integrationjob,msdyn_integrationjobdetail,msdyn_inventoryadjustment,msdyn_inventoryadjustmentproduct,msdyn_inventoryjournal,msdyn_inventorytransfer,msdyn_invoicefrequency,msdyn_invoicefrequencydetail,msdyn_invoicelinetransaction,msdyn_iotalert,msdyn_iotdevice,msdyn_iotdevicecategory,msdyn_iotdevicecommand,msdyn_iotdeviceregistrationhistory,msdyn_journal,msdyn_journalline,msdyn_mlresultcache,msdyn_opportunitylineresourcecategory,msdyn_opportunitylinetransaction,msdyn_opportunitylinetransactioncategory,msdyn_opportunitylinetransactionclassificatio,msdyn_opportunitypricelist,msdyn_orderinvoicingdate,msdyn_orderinvoicingproduct,msdyn_orderinvoicingsetup,msdyn_orderinvoicingsetupdate,msdyn_orderlineresourcecategory,msdyn_orderlinetransaction,msdyn_orderlinetransactioncategory,msdyn_orderlinetransactionclassification,msdyn_orderpricelist,msdyn_organizationalunit,msdyn_payment,msdyn_paymentdetail,msdyn_paymentmethod,msdyn_paymentterm,msdyn_postalbum,msdyn_postalcode,msdyn_postconfig,msdyn_postruleconfig,msdyn_priority,msdyn_processnotes,msdyn_productinventory,msdyn_project,msdyn_projectapproval,msdyn_projectparameter,msdyn_projectparameterpricelist,msdyn_projectpricelist,msdyn_projecttask,msdyn_projecttaskdependency,msdyn_projecttaskstatususer,msdyn_projectteam,msdyn_projectteammembersignup,msdyn_projecttransactioncategory,msdyn_purchaseorder,msdyn_purchaseorderbill,msdyn_purchaseorderproduct,msdyn_purchaseorderreceipt,msdyn_purchaseorderreceiptproduct,msdyn_purchaseordersubstatus,msdyn_quotebookingincident,msdyn_quotebookingproduct,msdyn_quotebookingservice,msdyn_quotebookingservicetask,msdyn_quotebookingsetup,msdyn_quoteinvoicingproduct,msdyn_quoteinvoicingsetup,msdyn_quotelineanalyticsbreakdown,msdyn_quotelineinvoiceschedule,msdyn_quotelineresourcecategory,msdyn_quotelinescheduleofvalue,msdyn_quotelinetransaction,msdyn_quotelinetransactioncategory,msdyn_quotelinetransactionclassification,msdyn_quotepricelist,msdyn_requirementcharacteristic,msdyn_requirementorganizationunit,msdyn_requirementresourcecategory,msdyn_requirementresourcepreference,msdyn_requirementstatus,msdyn_resourceassignment,msdyn_resourceassignmentdetail,msdyn_resourcecategorypricelevel,msdyn_resourcepaytype,msdyn_resourcerequest,msdyn_resourcerequirement,msdyn_resourcerequirementdetail,msdyn_resourceterritory,msdyn_rma,msdyn_rmaproduct,msdyn_rmareceipt,msdyn_rmareceiptproduct,msdyn_rmasubstatus,msdyn_rolecompetencyrequirement,msdyn_roleutilization,msdyn_rtv,msdyn_rtvproduct,msdyn_rtvsubstatus,msdyn_scheduleboardsetting,msdyn_schedulingparameter,msdyn_servicetasktype,msdyn_shipvia,msdyn_systemuserschedulersetting,msdyn_taxcode,msdyn_taxcodedetail,msdyn_timeentry,msdyn_timegroup,msdyn_timegroupdetail,msdyn_timeoffcalendar,msdyn_timeoffrequest,msdyn_transactioncategory,msdyn_transactioncategoryclassification,msdyn_transactioncategoryhierarchyelement,msdyn_transactioncategorypricelevel,msdyn_transactionconnection,msdyn_transactionorigin,msdyn_transactiontype,msdyn_uniquenumber,msdyn_userworkhistory,msdyn_wallsavedquery,msdyn_wallsavedqueryusersettings,msdyn_warehouse,msdyn_workhourtemplate,msdyn_workorder,msdyn_workordercharacteristic,msdyn_workorderdetailsgenerationqueue,msdyn_workorderincident,msdyn_workorderproduct,msdyn_workorderresourcerestriction,msdyn_workorderservice,msdyn_workorderservicetask,msdyn_workordersubstatus,msdyn_workordertype,opportunity,opportunityclose,opportunitycompetitors,opportunityproduct,opportunitysalesprocess,orderclose,organization,phonecall,phonetocaseprocess,position,post,postfollow,pricelevel,privilege,product,productassociation,productpricelevel,productsalesliterature,productsubstitute,quarterlyfiscalcalendar,queue,queueitem,quote,quoteclose,quotedetail,ratingmodel,ratingvalue,recurringappointmentmaster,relationshiprole,relationshiprolemap,report,resource,resourcegroup,resourcegroupexpansion,resourcespec,role,rollupfield,routingrule,routingruleitem,salesliterature,salesliteratureitem,salesorder,salesorderdetail,salesprocessinstance,savedquery,semiannualfiscalcalendar,service,serviceappointment,servicecontractcontacts,sharepointdocumentlocation,sharepointsite,similarityrule,site,sla,socialactivity,socialprofile,subject,systemform,systemuser,task,team,template,territory,theme,topic,topichistory,topicmodel,topicmodelconfiguration,topicmodelexecutionhistory,transactioncurrency,uom,uomschedule,userform,usermapping,userquery


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
**MaxLength**: 256


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
**MaxLength**: 160


### <a name="BKMK_RegardingObjectTypeCode"></a> RegardingObjectTypeCode

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: regardingobjecttypecode<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**IsValidForUpdate**: False<br />
**Type**: EntityName<br />


### <a name="BKMK_RequestId"></a> RequestId

**Description**: Unique identifier of the request that generated the system job.<br />
**DisplayName**: Request<br />
**LogicalName**: requestid<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**IsValidForUpdate**: False<br />
**Type**: Uniqueidentifier<br />


### <a name="BKMK_StateCode"></a> StateCode

**Description**: Status of the system job.<br />
**DisplayName**: Status<br />
**LogicalName**: statecode<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: SystemRequired<br />
**IsValidForCreate**: False<br />
**Type**: State<br />
**Options**:

- **Value**: 0 **Label**: Ready **DefaultStatus**: 0 **InvariantName**: Ready
- **Value**: 1 **Label**: Suspended **DefaultStatus**: 10 **InvariantName**: Suspended
- **Value**: 2 **Label**: Locked **DefaultStatus**: 20 **InvariantName**: Locked
- **Value**: 3 **Label**: Completed **DefaultStatus**: 30 **InvariantName**: Completed



### <a name="BKMK_StatusCode"></a> StatusCode

**Description**: Reason for the status of the system job.<br />
**DisplayName**: Status Reason<br />
**LogicalName**: statuscode<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**IsValidForCreate**: False<br />
**Type**: Status<br />
**Options**:

- **Value**: 0 **Label**: Waiting For Resources **State**: 0
- **Value**: 10 **Label**: Waiting **State**: 1
- **Value**: 20 **Label**: In Progress **State**: 2
- **Value**: 21 **Label**: Pausing **State**: 2
- **Value**: 22 **Label**: Canceling **State**: 2
- **Value**: 30 **Label**: Succeeded **State**: 3
- **Value**: 31 **Label**: Failed **State**: 3
- **Value**: 32 **Label**: Canceled **State**: 3



### <a name="BKMK_TimeZoneRuleVersionNumber"></a> TimeZoneRuleVersionNumber

**Description**: For internal use only.<br />
**DisplayName**: <br />
**LogicalName**: timezoneruleversionnumber<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**IsValidForUpdate**: False<br />
**Type**: Integer<br />
**Format**: None<br />
**MaxValue**: 2147483647<br />
**MinValue**: -1


### <a name="BKMK_UTCConversionTimeZoneCode"></a> UTCConversionTimeZoneCode

**Description**: Time zone code that was in use when the record was created.<br />
**DisplayName**: <br />
**LogicalName**: utcconversiontimezonecode<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**IsValidForUpdate**: False<br />
**Type**: Integer<br />
**Format**: None<br />
**MaxValue**: 2147483647<br />
**MinValue**: -1


### <a name="BKMK_WorkflowActivationId"></a> WorkflowActivationId

**Description**: Unique identifier of the workflow activation related to the system job.<br />
**DisplayName**: Workflow Activation Id<br />
**LogicalName**: workflowactivationid<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**IsValidForUpdate**: False<br />
**Type**: Lookup<br />
**Targets**: workflow

<a name="read-only-attributes"></a>
## Read-only attributes
These attributes return false for both **IsValidForCreate** or **IsValidForUpdate**. Listed by **SchemaName**.

- [CompletedOn](#BKMK_CompletedOn)
- [CreatedBy](#BKMK_CreatedBy)
- [CreatedByName](#BKMK_CreatedByName)
- [CreatedByYomiName](#BKMK_CreatedByYomiName)
- [CreatedOn](#BKMK_CreatedOn)
- [CreatedOnBehalfBy](#BKMK_CreatedOnBehalfBy)
- [CreatedOnBehalfByName](#BKMK_CreatedOnBehalfByName)
- [CreatedOnBehalfByYomiName](#BKMK_CreatedOnBehalfByYomiName)
- [ErrorCode](#BKMK_ErrorCode)
- [ExecutionTimeSpan](#BKMK_ExecutionTimeSpan)
- [IsWaitingForEvent](#BKMK_IsWaitingForEvent)
- [Message](#BKMK_Message)
- [ModifiedBy](#BKMK_ModifiedBy)
- [ModifiedByName](#BKMK_ModifiedByName)
- [ModifiedByYomiName](#BKMK_ModifiedByYomiName)
- [ModifiedOn](#BKMK_ModifiedOn)
- [ModifiedOnBehalfBy](#BKMK_ModifiedOnBehalfBy)
- [ModifiedOnBehalfByName](#BKMK_ModifiedOnBehalfByName)
- [ModifiedOnBehalfByYomiName](#BKMK_ModifiedOnBehalfByYomiName)
- [OwnerIdName](#BKMK_OwnerIdName)
- [OwnerIdYomiName](#BKMK_OwnerIdYomiName)
- [OwningBusinessUnit](#BKMK_OwningBusinessUnit)
- [OwningTeam](#BKMK_OwningTeam)
- [OwningUser](#BKMK_OwningUser)
- [RetryCount](#BKMK_RetryCount)
- [Sequence](#BKMK_Sequence)
- [StartedOn](#BKMK_StartedOn)
- [Subtype](#BKMK_Subtype)
- [WorkflowActivationIdName](#BKMK_WorkflowActivationIdName)
- [WorkflowIsBlocked](#BKMK_WorkflowIsBlocked)
- [WorkflowStageName](#BKMK_WorkflowStageName)
- [WorkflowState](#BKMK_WorkflowState)


### <a name="BKMK_CompletedOn"></a> CompletedOn

**Description**: Date and time when the system job was completed.<br />
**DisplayName**: Completed On<br />
**LogicalName**: completedon<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: DateTime<br />
**DateTimeBehavior**: UserLocal<br />
**Format**: DateAndTime


### <a name="BKMK_CreatedBy"></a> CreatedBy

**Description**: Unique identifier of the user who created the system job.<br />
**DisplayName**: Created By<br />
**LogicalName**: createdby<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: SystemRequired<br />
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
**MaxLength**: 160


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
**MaxLength**: 160


### <a name="BKMK_CreatedOn"></a> CreatedOn

**Description**: Date and time when the system job was created.<br />
**DisplayName**: Created On<br />
**LogicalName**: createdon<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: DateTime<br />
**DateTimeBehavior**: UserLocal<br />
**Format**: DateAndTime


### <a name="BKMK_CreatedOnBehalfBy"></a> CreatedOnBehalfBy

**Description**: Unique identifier of the delegate user who created the asyncoperation.<br />
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


### <a name="BKMK_ErrorCode"></a> ErrorCode

**Description**: Error code returned from a canceled system job.<br />
**DisplayName**: Error Code<br />
**LogicalName**: errorcode<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Integer<br />
**Format**: None<br />
**MaxValue**: 2147483647<br />
**MinValue**: -2147483648


### <a name="BKMK_ExecutionTimeSpan"></a> ExecutionTimeSpan

**Description**: Time that the system job has taken to execute.<br />
**DisplayName**: ExecutionTimeSpan<br />
**LogicalName**: executiontimespan<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: SystemRequired<br />
**Type**: Double<br />
**MaxValue**: 1000000000<br />
**MinValue**: 0<br />
**Precision**: 2


### <a name="BKMK_IsWaitingForEvent"></a> IsWaitingForEvent

**Description**: Indicates that the system job is waiting for an event.<br />
**DisplayName**: Waiting for Event<br />
**LogicalName**: iswaitingforevent<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Boolean<br />
**Options**:

- **TrueOption Value**: 1 **Label**: Yes
- **FalseOption Value**: 0 **Label**: No

**DefaultValue**: False


### <a name="BKMK_Message"></a> Message

**Description**: Message related to the system job.<br />
**DisplayName**: Message<br />
**LogicalName**: message<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Memo<br />
**Format**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100000


### <a name="BKMK_ModifiedBy"></a> ModifiedBy

**Description**: Unique identifier of the user who last modified the system job.<br />
**DisplayName**: Modified By<br />
**LogicalName**: modifiedby<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: SystemRequired<br />
**Type**: Lookup<br />
**Targets**: systemuser


### <a name="BKMK_ModifiedByName"></a> ModifiedByName

**Description**: Name of the user who last modified the record.<br />
**DisplayName**: <br />
**LogicalName**: modifiedbyname<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 160


### <a name="BKMK_ModifiedByYomiName"></a> ModifiedByYomiName

**Description**: YomiName of the user who last modified the record.<br />
**DisplayName**: <br />
**LogicalName**: modifiedbyyominame<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 160


### <a name="BKMK_ModifiedOn"></a> ModifiedOn

**Description**: Date and time when the system job was last modified.<br />
**DisplayName**: Modified On<br />
**LogicalName**: modifiedon<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: DateTime<br />
**DateTimeBehavior**: UserLocal<br />
**Format**: DateAndTime


### <a name="BKMK_ModifiedOnBehalfBy"></a> ModifiedOnBehalfBy

**Description**: Unique identifier of the delegate user who last modified the asyncoperation.<br />
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
**MaxLength**: 160


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
**MaxLength**: 160


### <a name="BKMK_OwningBusinessUnit"></a> OwningBusinessUnit

**Description**: Unique identifier of the business unit that owns the system job.<br />
**DisplayName**: Owning Business Unit<br />
**LogicalName**: owningbusinessunit<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: SystemRequired<br />
**Type**: Lookup<br />
**Targets**: businessunit


### <a name="BKMK_OwningTeam"></a> OwningTeam

**Description**: Unique identifier of the team who owns the record.<br />
**DisplayName**: Owning Team<br />
**LogicalName**: owningteam<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: team


### <a name="BKMK_OwningUser"></a> OwningUser

**Description**: Unique identifier of the user who owns the record.<br />
**DisplayName**: Owning User<br />
**LogicalName**: owninguser<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: systemuser


### <a name="BKMK_RetryCount"></a> RetryCount

**Description**: Number of times to retry the system job.<br />
**DisplayName**: Retry Count<br />
**LogicalName**: retrycount<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Integer<br />
**Format**: None<br />
**MaxValue**: 2147483647<br />
**MinValue**: 0


### <a name="BKMK_Sequence"></a> Sequence

**Description**: Order in which operations were submitted.<br />
**DisplayName**: Sequence<br />
**LogicalName**: sequence<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: SystemRequired<br />
**Type**: BigInt<br />
**MaxValue**: 9223372036854775807<br />
**MinValue**: -9223372036854775808<br />


### <a name="BKMK_StartedOn"></a> StartedOn

**Description**: Date and time when the system job was started.<br />
**DisplayName**: Started On<br />
**LogicalName**: startedon<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: DateTime<br />
**DateTimeBehavior**: UserLocal<br />
**Format**: DateAndTime


### <a name="BKMK_Subtype"></a> Subtype

**Description**: The Subtype of the Async Job<br />
**DisplayName**: Subtype<br />
**LogicalName**: subtype<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Integer<br />
**Format**: None<br />
**MaxValue**: 255<br />
**MinValue**: 0


### <a name="BKMK_WorkflowActivationIdName"></a> WorkflowActivationIdName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: workflowactivationidname<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 160


### <a name="BKMK_WorkflowIsBlocked"></a> WorkflowIsBlocked

**Description**: Indicates whether the workflow instance was blocked when it was persisted.<br />
**DisplayName**: Workflow Is Blocked<br />
**LogicalName**: workflowisblocked<br />
**IsValidForForm**: False<br />
**IsValidForRead**: False<br />
**RequiredLevel**: None<br />
**Type**: Boolean<br />
**Options**:

- **TrueOption Value**: 1 **Label**: Yes
- **FalseOption Value**: 0 **Label**: No

**DefaultValue**: False


### <a name="BKMK_WorkflowStageName"></a> WorkflowStageName

**Description**: Name of a workflow stage.<br />
**DisplayName**: Workflow Stage<br />
**LogicalName**: workflowstagename<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 256


### <a name="BKMK_WorkflowState"></a> WorkflowState

**Description**: State of the workflow job.<br />
**DisplayName**: Workflow State<br />
**LogicalName**: workflowstate<br />
**IsValidForForm**: False<br />
**IsValidForRead**: False<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: TextArea<br />
**IsLocalizable**: False<br />
**MaxLength**: 1073741823

<a name="onetomany"></a>

## One-To-Many Relationships

Listed by **SchemaName**.

- [AsyncOperation_MailboxTrackingFolder](#BKMK_AsyncOperation_MailboxTrackingFolder)
- [AsyncOperation_BulkDeleteOperation](#BKMK_AsyncOperation_BulkDeleteOperation)
- [lk_workflowlog_asyncoperation_childworkflow](#BKMK_lk_workflowlog_asyncoperation_childworkflow)
- [AsyncOperation_Emails](#BKMK_AsyncOperation_Emails)
- [AsyncOperation_DuplicateBaseRecord](#BKMK_AsyncOperation_DuplicateBaseRecord)
- [lk_workflowlog_asyncoperations](#BKMK_lk_workflowlog_asyncoperations)
- [AsyncOperation_SocialActivities](#BKMK_AsyncOperation_SocialActivities)
- [userentityinstancedata_asyncoperation](#BKMK_userentityinstancedata_asyncoperation)


### <a name="BKMK_AsyncOperation_MailboxTrackingFolder"></a> AsyncOperation_MailboxTrackingFolder

Same as mailboxtrackingfolder entity [AsyncOperation_MailboxTrackingFolder](mailboxtrackingfolder.md#BKMK_AsyncOperation_MailboxTrackingFolder) Many-To-One relationship.

**ReferencingEntity**: mailboxtrackingfolder<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: False<br />
**ReferencedEntityNavigationPropertyName**: AsyncOperation_MailboxTrackingFolder<br />
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


### <a name="BKMK_AsyncOperation_BulkDeleteOperation"></a> AsyncOperation_BulkDeleteOperation

Same as bulkdeleteoperation entity [AsyncOperation_BulkDeleteOperation](bulkdeleteoperation.md#BKMK_AsyncOperation_BulkDeleteOperation) Many-To-One relationship.

**ReferencingEntity**: bulkdeleteoperation<br />
**ReferencingAttribute**: asyncoperationid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: False<br />
**ReferencedEntityNavigationPropertyName**: AsyncOperation_BulkDeleteOperation<br />
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


### <a name="BKMK_lk_workflowlog_asyncoperation_childworkflow"></a> lk_workflowlog_asyncoperation_childworkflow

Same as workflowlog entity [lk_workflowlog_asyncoperation_childworkflow](workflowlog.md#BKMK_lk_workflowlog_asyncoperation_childworkflow) Many-To-One relationship.

**ReferencingEntity**: workflowlog<br />
**ReferencingAttribute**: childworkflowinstanceid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: False<br />
**ReferencedEntityNavigationPropertyName**: lk_workflowlog_asyncoperation_childworkflow<br />
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


### <a name="BKMK_AsyncOperation_Emails"></a> AsyncOperation_Emails

Same as email entity [AsyncOperation_Emails](email.md#BKMK_AsyncOperation_Emails) Many-To-One relationship.

**ReferencingEntity**: email<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: False<br />
**ReferencedEntityNavigationPropertyName**: AsyncOperation_Emails<br />
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


### <a name="BKMK_AsyncOperation_DuplicateBaseRecord"></a> AsyncOperation_DuplicateBaseRecord

Same as duplicaterecord entity [AsyncOperation_DuplicateBaseRecord](duplicaterecord.md#BKMK_AsyncOperation_DuplicateBaseRecord) Many-To-One relationship.

**ReferencingEntity**: duplicaterecord<br />
**ReferencingAttribute**: asyncoperationid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: False<br />
**ReferencedEntityNavigationPropertyName**: AsyncOperation_DuplicateBaseRecord<br />
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


### <a name="BKMK_lk_workflowlog_asyncoperations"></a> lk_workflowlog_asyncoperations

Same as workflowlog entity [lk_workflowlog_asyncoperations](workflowlog.md#BKMK_lk_workflowlog_asyncoperations) Many-To-One relationship.

**ReferencingEntity**: workflowlog<br />
**ReferencingAttribute**: asyncoperationid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: False<br />
**ReferencedEntityNavigationPropertyName**: lk_workflowlog_asyncoperations<br />
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


### <a name="BKMK_AsyncOperation_SocialActivities"></a> AsyncOperation_SocialActivities

Same as socialactivity entity [AsyncOperation_SocialActivities](socialactivity.md#BKMK_AsyncOperation_SocialActivities) Many-To-One relationship.

**ReferencingEntity**: socialactivity<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: False<br />
**ReferencedEntityNavigationPropertyName**: AsyncOperation_SocialActivities<br />
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


### <a name="BKMK_userentityinstancedata_asyncoperation"></a> userentityinstancedata_asyncoperation

Same as userentityinstancedata entity [userentityinstancedata_asyncoperation](userentityinstancedata.md#BKMK_userentityinstancedata_asyncoperation) Many-To-One relationship.

**ReferencingEntity**: userentityinstancedata<br />
**ReferencingAttribute**: objectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: False<br />
**ReferencedEntityNavigationPropertyName**: userentityinstancedata_asyncoperation<br />
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

- [msdyn_iotalert_AsyncOperations](#BKMK_msdyn_iotalert_AsyncOperations)
- [msdyn_iotdevice_AsyncOperations](#BKMK_msdyn_iotdevice_AsyncOperations)
- [msdyn_iotdevicecategory_AsyncOperations](#BKMK_msdyn_iotdevicecategory_AsyncOperations)
- [msdyn_iotdevicecommand_AsyncOperations](#BKMK_msdyn_iotdevicecommand_AsyncOperations)
- [msdyn_iotdeviceregistrationhistory_AsyncOperations](#BKMK_msdyn_iotdeviceregistrationhistory_AsyncOperations)
- [msdyn_bpf_477c16f59170487b8b4dc895c5dcd09b_AsyncOperations](#BKMK_msdyn_bpf_477c16f59170487b8b4dc895c5dcd09b_AsyncOperations)
- [Territory_AsyncOperations](#BKMK_Territory_AsyncOperations)
- [accountleads_AsyncOperations](#BKMK_accountleads_AsyncOperations)
- [contactleads_AsyncOperations](#BKMK_contactleads_AsyncOperations)
- [leadaddress_AsyncOperations](#BKMK_leadaddress_AsyncOperations)
- [Lead_AsyncOperations](#BKMK_Lead_AsyncOperations)
- [dynamicproperty_AsyncOperations](#BKMK_dynamicproperty_AsyncOperations)
- [dynamicpropertyassociation_AsyncOperations](#BKMK_dynamicpropertyassociation_AsyncOperations)
- [dynamicpropertyinstance_AsyncOperations](#BKMK_dynamicpropertyinstance_AsyncOperations)
- [dynamicpropertyoptionsetitem_AsyncOperations](#BKMK_dynamicpropertyoptionsetitem_AsyncOperations)
- [PriceLevel_AsyncOperations](#BKMK_PriceLevel_AsyncOperations)
- [Product_AsyncOperations](#BKMK_Product_AsyncOperations)
- [ProductAssociation_AsyncOperations](#BKMK_ProductAssociation_AsyncOperations)
- [ProductPriceLevel_AsyncOperations](#BKMK_ProductPriceLevel_AsyncOperations)
- [ProductSubstitute_AsyncOperations](#BKMK_ProductSubstitute_AsyncOperations)
- [UoM_AsyncOperations](#BKMK_UoM_AsyncOperations)
- [UoMSchedule_AsyncOperations](#BKMK_UoMSchedule_AsyncOperations)
- [bookableresource_AsyncOperations](#BKMK_bookableresource_AsyncOperations)
- [bookableresourcebooking_AsyncOperations](#BKMK_bookableresourcebooking_AsyncOperations)
- [bookableresourcebookingexchangesyncidmapping_AsyncOperations](#BKMK_bookableresourcebookingexchangesyncidmapping_AsyncOperations)
- [bookableresourcebookingheader_AsyncOperations](#BKMK_bookableresourcebookingheader_AsyncOperations)
- [bookableresourcecategory_AsyncOperations](#BKMK_bookableresourcecategory_AsyncOperations)
- [bookableresourcecategoryassn_AsyncOperations](#BKMK_bookableresourcecategoryassn_AsyncOperations)
- [bookableresourcecharacteristic_AsyncOperations](#BKMK_bookableresourcecharacteristic_AsyncOperations)
- [bookableresourcegroup_AsyncOperations](#BKMK_bookableresourcegroup_AsyncOperations)
- [bookingstatus_AsyncOperations](#BKMK_bookingstatus_AsyncOperations)
- [characteristic_AsyncOperations](#BKMK_characteristic_AsyncOperations)
- [ratingmodel_AsyncOperations](#BKMK_ratingmodel_AsyncOperations)
- [ratingvalue_AsyncOperations](#BKMK_ratingvalue_AsyncOperations)
- [BulkOperation_AsyncOperations](#BKMK_BulkOperation_AsyncOperations)
- [BulkOperationLog_AsyncOperations](#BKMK_BulkOperationLog_AsyncOperations)
- [Campaign_AsyncOperations](#BKMK_Campaign_AsyncOperations)
- [CampaignActivity_AsyncOperations](#BKMK_CampaignActivity_AsyncOperations)
- [campaignactivityitem_AsyncOperations](#BKMK_campaignactivityitem_AsyncOperations)
- [campaignitem_AsyncOperations](#BKMK_campaignitem_AsyncOperations)
- [CampaignResponse_AsyncOperations](#BKMK_CampaignResponse_AsyncOperations)
- [List_AsyncOperations](#BKMK_List_AsyncOperations)
- [listmember_AsyncOperations](#BKMK_listmember_AsyncOperations)
- [commitment_AsyncOperations](#BKMK_commitment_AsyncOperations)
- [ConstraintBasedGroup_AsyncOperations](#BKMK_ConstraintBasedGroup_AsyncOperations)
- [Contract_AsyncOperations](#BKMK_Contract_AsyncOperations)
- [ContractDetail_AsyncOperations](#BKMK_ContractDetail_AsyncOperations)
- [ContractTemplate_AsyncOperations](#BKMK_ContractTemplate_AsyncOperations)
- [entitlement_AsyncOperations](#BKMK_entitlement_AsyncOperations)
- [entitlementchannel_AsyncOperations](#BKMK_entitlementchannel_AsyncOperations)
- [entitlementcontacts_AsyncOperations](#BKMK_entitlementcontacts_AsyncOperations)
- [entitlementproducts_AsyncOperations](#BKMK_entitlementproducts_AsyncOperations)
- [entitlementtemplate_AsyncOperations](#BKMK_entitlementtemplate_AsyncOperations)
- [entitlementtemplatechannel_AsyncOperations](#BKMK_entitlementtemplatechannel_AsyncOperations)
- [entitlementtemplateproducts_AsyncOperations](#BKMK_entitlementtemplateproducts_AsyncOperations)
- [Equipment_AsyncOperations](#BKMK_Equipment_AsyncOperations)
- [Incident_AsyncOperations](#BKMK_Incident_AsyncOperations)
- [incidentknowledgebaserecord_AsyncOperations](#BKMK_incidentknowledgebaserecord_AsyncOperations)
- [IncidentResolution_AsyncOperations](#BKMK_IncidentResolution_AsyncOperations)
- [knowledgearticleincident_AsyncOperations](#BKMK_knowledgearticleincident_AsyncOperations)
- [phonetocaseprocess_AsyncOperations](#BKMK_phonetocaseprocess_AsyncOperations)
- [Resource_AsyncOperations](#BKMK_Resource_AsyncOperations)
- [ResourceGroup_AsyncOperations](#BKMK_ResourceGroup_AsyncOperations)
- [ResourceSpec_AsyncOperations](#BKMK_ResourceSpec_AsyncOperations)
- [Service_AsyncOperations](#BKMK_Service_AsyncOperations)
- [ServiceAppointment_AsyncOperations](#BKMK_ServiceAppointment_AsyncOperations)
- [servicecontractcontacts_AsyncOperations](#BKMK_servicecontractcontacts_AsyncOperations)
- [topic_AsyncOperations](#BKMK_topic_AsyncOperations)
- [topichistory_AsyncOperations](#BKMK_topichistory_AsyncOperations)
- [topicmodel_AsyncOperations](#BKMK_topicmodel_AsyncOperations)
- [topicmodelconfiguration_AsyncOperations](#BKMK_topicmodelconfiguration_AsyncOperations)
- [topicmodelexecutionhistory_AsyncOperations](#BKMK_topicmodelexecutionhistory_AsyncOperations)
- [Site_AsyncOperations](#BKMK_Site_AsyncOperations)
- [competitorproduct_AsyncOperations](#BKMK_competitorproduct_AsyncOperations)
- [competitorsalesliterature_AsyncOperations](#BKMK_competitorsalesliterature_AsyncOperations)
- [contactinvoices_AsyncOperations](#BKMK_contactinvoices_AsyncOperations)
- [contactorders_AsyncOperations](#BKMK_contactorders_AsyncOperations)
- [contactquotes_AsyncOperations](#BKMK_contactquotes_AsyncOperations)
- [CustomerOpportunityRole_AsyncOperations](#BKMK_CustomerOpportunityRole_AsyncOperations)
- [Discount_AsyncOperations](#BKMK_Discount_AsyncOperations)
- [DiscountType_AsyncOperations](#BKMK_DiscountType_AsyncOperations)
- [Invoice_AsyncOperations](#BKMK_Invoice_AsyncOperations)
- [InvoiceDetail_AsyncOperations](#BKMK_InvoiceDetail_AsyncOperations)
- [leadcompetitors_AsyncOperations](#BKMK_leadcompetitors_AsyncOperations)
- [leadproduct_AsyncOperations](#BKMK_leadproduct_AsyncOperations)
- [leadtoopportunitysalesprocess_AsyncOperations](#BKMK_leadtoopportunitysalesprocess_AsyncOperations)
- [Opportunity_AsyncOperations](#BKMK_Opportunity_AsyncOperations)
- [OpportunityClose_AsyncOperations](#BKMK_OpportunityClose_AsyncOperations)
- [opportunitycompetitors_AsyncOperations](#BKMK_opportunitycompetitors_AsyncOperations)
- [OpportunityProduct_AsyncOperations](#BKMK_OpportunityProduct_AsyncOperations)
- [opportunitysalesprocess_AsyncOperations](#BKMK_opportunitysalesprocess_AsyncOperations)
- [OrderClose_AsyncOperations](#BKMK_OrderClose_AsyncOperations)
- [productsalesliterature_AsyncOperations](#BKMK_productsalesliterature_AsyncOperations)
- [Quote_AsyncOperations](#BKMK_Quote_AsyncOperations)
- [QuoteClose_AsyncOperations](#BKMK_QuoteClose_AsyncOperations)
- [QuoteDetail_AsyncOperations](#BKMK_QuoteDetail_AsyncOperations)
- [SalesLiterature_AsyncOperations](#BKMK_SalesLiterature_AsyncOperations)
- [SalesLiteratureItem_AsyncOperations](#BKMK_SalesLiteratureItem_AsyncOperations)
- [SalesOrder_AsyncOperations](#BKMK_SalesOrder_AsyncOperations)
- [SalesOrderDetail_AsyncOperations](#BKMK_SalesOrderDetail_AsyncOperations)
- [Competitor_AsyncOperations](#BKMK_Competitor_AsyncOperations)
- [msdyn_postalbum_AsyncOperations](#BKMK_msdyn_postalbum_AsyncOperations)
- [msdyn_postconfig_AsyncOperations](#BKMK_msdyn_postconfig_AsyncOperations)
- [msdyn_postruleconfig_AsyncOperations](#BKMK_msdyn_postruleconfig_AsyncOperations)
- [msdyn_wallsavedquery_AsyncOperations](#BKMK_msdyn_wallsavedquery_AsyncOperations)
- [msdyn_wallsavedqueryusersettings_AsyncOperations](#BKMK_msdyn_wallsavedqueryusersettings_AsyncOperations)
- [msdyn_actual_AsyncOperations](#BKMK_msdyn_actual_AsyncOperations)
- [msdyn_bookingalert_AsyncOperations](#BKMK_msdyn_bookingalert_AsyncOperations)
- [msdyn_bookingalertstatus_AsyncOperations](#BKMK_msdyn_bookingalertstatus_AsyncOperations)
- [msdyn_bookingchange_AsyncOperations](#BKMK_msdyn_bookingchange_AsyncOperations)
- [msdyn_bookingrule_AsyncOperations](#BKMK_msdyn_bookingrule_AsyncOperations)
- [msdyn_bookingsetupmetadata_AsyncOperations](#BKMK_msdyn_bookingsetupmetadata_AsyncOperations)
- [msdyn_clientextension_AsyncOperations](#BKMK_msdyn_clientextension_AsyncOperations)
- [msdyn_configuration_AsyncOperations](#BKMK_msdyn_configuration_AsyncOperations)
- [msdyn_organizationalunit_AsyncOperations](#BKMK_msdyn_organizationalunit_AsyncOperations)
- [msdyn_priority_AsyncOperations](#BKMK_msdyn_priority_AsyncOperations)
- [msdyn_requirementcharacteristic_AsyncOperations](#BKMK_msdyn_requirementcharacteristic_AsyncOperations)
- [msdyn_requirementorganizationunit_AsyncOperations](#BKMK_msdyn_requirementorganizationunit_AsyncOperations)
- [msdyn_requirementresourcecategory_AsyncOperations](#BKMK_msdyn_requirementresourcecategory_AsyncOperations)
- [msdyn_requirementresourcepreference_AsyncOperations](#BKMK_msdyn_requirementresourcepreference_AsyncOperations)
- [msdyn_requirementstatus_AsyncOperations](#BKMK_msdyn_requirementstatus_AsyncOperations)
- [msdyn_resourcerequirement_AsyncOperations](#BKMK_msdyn_resourcerequirement_AsyncOperations)
- [msdyn_resourcerequirementdetail_AsyncOperations](#BKMK_msdyn_resourcerequirementdetail_AsyncOperations)
- [msdyn_resourceterritory_AsyncOperations](#BKMK_msdyn_resourceterritory_AsyncOperations)
- [msdyn_scheduleboardsetting_AsyncOperations](#BKMK_msdyn_scheduleboardsetting_AsyncOperations)
- [msdyn_schedulingparameter_AsyncOperations](#BKMK_msdyn_schedulingparameter_AsyncOperations)
- [msdyn_systemuserschedulersetting_AsyncOperations](#BKMK_msdyn_systemuserschedulersetting_AsyncOperations)
- [msdyn_timegroup_AsyncOperations](#BKMK_msdyn_timegroup_AsyncOperations)
- [msdyn_timegroupdetail_AsyncOperations](#BKMK_msdyn_timegroupdetail_AsyncOperations)
- [msdyn_transactionorigin_AsyncOperations](#BKMK_msdyn_transactionorigin_AsyncOperations)
- [msdyn_workhourtemplate_AsyncOperations](#BKMK_msdyn_workhourtemplate_AsyncOperations)
- [msdyn_accountpricelist_AsyncOperations](#BKMK_msdyn_accountpricelist_AsyncOperations)
- [msdyn_approval_AsyncOperations](#BKMK_msdyn_approval_AsyncOperations)
- [msdyn_batchjob_AsyncOperations](#BKMK_msdyn_batchjob_AsyncOperations)
- [msdyn_bpf_665e73aa18c247d886bfc50499c73b82_AsyncOperations](#BKMK_msdyn_bpf_665e73aa18c247d886bfc50499c73b82_AsyncOperations)
- [msdyn_bpf_d8f9dc7f099f44db9d641dd81fbd470d_AsyncOperations](#BKMK_msdyn_bpf_d8f9dc7f099f44db9d641dd81fbd470d_AsyncOperations)
- [msdyn_characteristicreqforteammember_AsyncOperations](#BKMK_msdyn_characteristicreqforteammember_AsyncOperations)
- [msdyn_contactpricelist_AsyncOperations](#BKMK_msdyn_contactpricelist_AsyncOperations)
- [msdyn_contractlineinvoiceschedule_AsyncOperations](#BKMK_msdyn_contractlineinvoiceschedule_AsyncOperations)
- [msdyn_contractlinescheduleofvalue_AsyncOperations](#BKMK_msdyn_contractlinescheduleofvalue_AsyncOperations)
- [msdyn_dataexport_AsyncOperations](#BKMK_msdyn_dataexport_AsyncOperations)
- [msdyn_delegation_AsyncOperations](#BKMK_msdyn_delegation_AsyncOperations)
- [msdyn_estimate_AsyncOperations](#BKMK_msdyn_estimate_AsyncOperations)
- [msdyn_estimateline_AsyncOperations](#BKMK_msdyn_estimateline_AsyncOperations)
- [msdyn_expense_AsyncOperations](#BKMK_msdyn_expense_AsyncOperations)
- [msdyn_expensecategory_AsyncOperations](#BKMK_msdyn_expensecategory_AsyncOperations)
- [msdyn_expensereceipt_AsyncOperations](#BKMK_msdyn_expensereceipt_AsyncOperations)
- [msdyn_fact_AsyncOperations](#BKMK_msdyn_fact_AsyncOperations)
- [msdyn_fieldcomputation_AsyncOperations](#BKMK_msdyn_fieldcomputation_AsyncOperations)
- [msdyn_findworkevent_AsyncOperations](#BKMK_msdyn_findworkevent_AsyncOperations)
- [msdyn_integrationjob_AsyncOperations](#BKMK_msdyn_integrationjob_AsyncOperations)
- [msdyn_integrationjobdetail_AsyncOperations](#BKMK_msdyn_integrationjobdetail_AsyncOperations)
- [msdyn_invoicefrequency_AsyncOperations](#BKMK_msdyn_invoicefrequency_AsyncOperations)
- [msdyn_invoicefrequencydetail_AsyncOperations](#BKMK_msdyn_invoicefrequencydetail_AsyncOperations)
- [msdyn_invoicelinetransaction_AsyncOperations](#BKMK_msdyn_invoicelinetransaction_AsyncOperations)
- [msdyn_journal_AsyncOperations](#BKMK_msdyn_journal_AsyncOperations)
- [msdyn_journalline_AsyncOperations](#BKMK_msdyn_journalline_AsyncOperations)
- [msdyn_mlresultcache_AsyncOperations](#BKMK_msdyn_mlresultcache_AsyncOperations)
- [msdyn_opportunitylineresourcecategory_AsyncOperations](#BKMK_msdyn_opportunitylineresourcecategory_AsyncOperations)
- [msdyn_opportunitylinetransaction_AsyncOperations](#BKMK_msdyn_opportunitylinetransaction_AsyncOperations)
- [msdyn_opportunitylinetransactioncategory_AsyncOperations](#BKMK_msdyn_opportunitylinetransactioncategory_AsyncOperations)
- [msdyn_opportunitylinetransactionclassificatio_AsyncOperations](#BKMK_msdyn_opportunitylinetransactionclassificatio_AsyncOperations)
- [msdyn_opportunitypricelist_AsyncOperations](#BKMK_msdyn_opportunitypricelist_AsyncOperations)
- [msdyn_orderlineresourcecategory_AsyncOperations](#BKMK_msdyn_orderlineresourcecategory_AsyncOperations)
- [msdyn_orderlinetransaction_AsyncOperations](#BKMK_msdyn_orderlinetransaction_AsyncOperations)
- [msdyn_orderlinetransactioncategory_AsyncOperations](#BKMK_msdyn_orderlinetransactioncategory_AsyncOperations)
- [msdyn_orderlinetransactionclassification_AsyncOperations](#BKMK_msdyn_orderlinetransactionclassification_AsyncOperations)
- [msdyn_orderpricelist_AsyncOperations](#BKMK_msdyn_orderpricelist_AsyncOperations)
- [msdyn_processnotes_AsyncOperations](#BKMK_msdyn_processnotes_AsyncOperations)
- [msdyn_project_AsyncOperations](#BKMK_msdyn_project_AsyncOperations)
- [msdyn_projectapproval_AsyncOperations](#BKMK_msdyn_projectapproval_AsyncOperations)
- [msdyn_projectparameter_AsyncOperations](#BKMK_msdyn_projectparameter_AsyncOperations)
- [msdyn_projectparameterpricelist_AsyncOperations](#BKMK_msdyn_projectparameterpricelist_AsyncOperations)
- [msdyn_projectpricelist_AsyncOperations](#BKMK_msdyn_projectpricelist_AsyncOperations)
- [msdyn_projecttask_AsyncOperations](#BKMK_msdyn_projecttask_AsyncOperations)
- [msdyn_projecttaskdependency_AsyncOperations](#BKMK_msdyn_projecttaskdependency_AsyncOperations)
- [msdyn_projecttaskstatususer_AsyncOperations](#BKMK_msdyn_projecttaskstatususer_AsyncOperations)
- [msdyn_projectteam_AsyncOperations](#BKMK_msdyn_projectteam_AsyncOperations)
- [msdyn_projectteammembersignup_AsyncOperations](#BKMK_msdyn_projectteammembersignup_AsyncOperations)
- [msdyn_projecttransactioncategory_AsyncOperations](#BKMK_msdyn_projecttransactioncategory_AsyncOperations)
- [msdyn_quotelineanalyticsbreakdown_AsyncOperations](#BKMK_msdyn_quotelineanalyticsbreakdown_AsyncOperations)
- [msdyn_quotelineinvoiceschedule_AsyncOperations](#BKMK_msdyn_quotelineinvoiceschedule_AsyncOperations)
- [msdyn_quotelineresourcecategory_AsyncOperations](#BKMK_msdyn_quotelineresourcecategory_AsyncOperations)
- [msdyn_quotelinescheduleofvalue_AsyncOperations](#BKMK_msdyn_quotelinescheduleofvalue_AsyncOperations)
- [msdyn_quotelinetransaction_AsyncOperations](#BKMK_msdyn_quotelinetransaction_AsyncOperations)
- [msdyn_quotelinetransactioncategory_AsyncOperations](#BKMK_msdyn_quotelinetransactioncategory_AsyncOperations)
- [msdyn_quotelinetransactionclassification_AsyncOperations](#BKMK_msdyn_quotelinetransactionclassification_AsyncOperations)
- [msdyn_quotepricelist_AsyncOperations](#BKMK_msdyn_quotepricelist_AsyncOperations)
- [msdyn_resourceassignment_AsyncOperations](#BKMK_msdyn_resourceassignment_AsyncOperations)
- [msdyn_resourceassignmentdetail_AsyncOperations](#BKMK_msdyn_resourceassignmentdetail_AsyncOperations)
- [msdyn_resourcecategorypricelevel_AsyncOperations](#BKMK_msdyn_resourcecategorypricelevel_AsyncOperations)
- [msdyn_resourcerequest_AsyncOperations](#BKMK_msdyn_resourcerequest_AsyncOperations)
- [msdyn_rolecompetencyrequirement_AsyncOperations](#BKMK_msdyn_rolecompetencyrequirement_AsyncOperations)
- [msdyn_roleutilization_AsyncOperations](#BKMK_msdyn_roleutilization_AsyncOperations)
- [msdyn_timeentry_AsyncOperations](#BKMK_msdyn_timeentry_AsyncOperations)
- [msdyn_timeoffcalendar_AsyncOperations](#BKMK_msdyn_timeoffcalendar_AsyncOperations)
- [msdyn_transactioncategory_AsyncOperations](#BKMK_msdyn_transactioncategory_AsyncOperations)
- [msdyn_transactioncategoryclassification_AsyncOperations](#BKMK_msdyn_transactioncategoryclassification_AsyncOperations)
- [msdyn_transactioncategoryhierarchyelement_AsyncOperations](#BKMK_msdyn_transactioncategoryhierarchyelement_AsyncOperations)
- [msdyn_transactioncategorypricelevel_AsyncOperations](#BKMK_msdyn_transactioncategorypricelevel_AsyncOperations)
- [msdyn_transactionconnection_AsyncOperations](#BKMK_msdyn_transactionconnection_AsyncOperations)
- [msdyn_transactiontype_AsyncOperations](#BKMK_msdyn_transactiontype_AsyncOperations)
- [msdyn_userworkhistory_AsyncOperations](#BKMK_msdyn_userworkhistory_AsyncOperations)
- [msdyn_agreement_AsyncOperations](#BKMK_msdyn_agreement_AsyncOperations)
- [msdyn_agreementbookingdate_AsyncOperations](#BKMK_msdyn_agreementbookingdate_AsyncOperations)
- [msdyn_agreementbookingincident_AsyncOperations](#BKMK_msdyn_agreementbookingincident_AsyncOperations)
- [msdyn_agreementbookingproduct_AsyncOperations](#BKMK_msdyn_agreementbookingproduct_AsyncOperations)
- [msdyn_agreementbookingservice_AsyncOperations](#BKMK_msdyn_agreementbookingservice_AsyncOperations)
- [msdyn_agreementbookingservicetask_AsyncOperations](#BKMK_msdyn_agreementbookingservicetask_AsyncOperations)
- [msdyn_agreementbookingsetup_AsyncOperations](#BKMK_msdyn_agreementbookingsetup_AsyncOperations)
- [msdyn_agreementinvoicedate_AsyncOperations](#BKMK_msdyn_agreementinvoicedate_AsyncOperations)
- [msdyn_agreementinvoiceproduct_AsyncOperations](#BKMK_msdyn_agreementinvoiceproduct_AsyncOperations)
- [msdyn_agreementinvoicesetup_AsyncOperations](#BKMK_msdyn_agreementinvoicesetup_AsyncOperations)
- [msdyn_agreementsubstatus_AsyncOperations](#BKMK_msdyn_agreementsubstatus_AsyncOperations)
- [msdyn_bookingjournal_AsyncOperations](#BKMK_msdyn_bookingjournal_AsyncOperations)
- [msdyn_bookingtimestamp_AsyncOperations](#BKMK_msdyn_bookingtimestamp_AsyncOperations)
- [msdyn_bpf_2c5fe86acc8b414b8322ae571000c799_AsyncOperations](#BKMK_msdyn_bpf_2c5fe86acc8b414b8322ae571000c799_AsyncOperations)
- [msdyn_bpf_989e9b1857e24af18787d5143b67523b_AsyncOperations](#BKMK_msdyn_bpf_989e9b1857e24af18787d5143b67523b_AsyncOperations)
- [msdyn_bpf_baa0a411a239410cb8bded8b5fdd88e3_AsyncOperations](#BKMK_msdyn_bpf_baa0a411a239410cb8bded8b5fdd88e3_AsyncOperations)
- [msdyn_bpf_d3d97bac8c294105840e99e37a9d1c39_AsyncOperations](#BKMK_msdyn_bpf_d3d97bac8c294105840e99e37a9d1c39_AsyncOperations)
- [msdyn_customerasset_AsyncOperations](#BKMK_msdyn_customerasset_AsyncOperations)
- [msdyn_fieldservicepricelistitem_AsyncOperations](#BKMK_msdyn_fieldservicepricelistitem_AsyncOperations)
- [msdyn_fieldservicesetting_AsyncOperations](#BKMK_msdyn_fieldservicesetting_AsyncOperations)
- [msdyn_fieldservicesystemjob_AsyncOperations](#BKMK_msdyn_fieldservicesystemjob_AsyncOperations)
- [msdyn_incidenttype_AsyncOperations](#BKMK_msdyn_incidenttype_AsyncOperations)
- [msdyn_incidenttypecharacteristic_AsyncOperations](#BKMK_msdyn_incidenttypecharacteristic_AsyncOperations)
- [msdyn_incidenttypeproduct_AsyncOperations](#BKMK_msdyn_incidenttypeproduct_AsyncOperations)
- [msdyn_incidenttypeservice_AsyncOperations](#BKMK_msdyn_incidenttypeservice_AsyncOperations)
- [msdyn_incidenttypeservicetask_AsyncOperations](#BKMK_msdyn_incidenttypeservicetask_AsyncOperations)
- [msdyn_inventoryadjustment_AsyncOperations](#BKMK_msdyn_inventoryadjustment_AsyncOperations)
- [msdyn_inventoryadjustmentproduct_AsyncOperations](#BKMK_msdyn_inventoryadjustmentproduct_AsyncOperations)
- [msdyn_inventoryjournal_AsyncOperations](#BKMK_msdyn_inventoryjournal_AsyncOperations)
- [msdyn_inventorytransfer_AsyncOperations](#BKMK_msdyn_inventorytransfer_AsyncOperations)
- [msdyn_orderinvoicingdate_AsyncOperations](#BKMK_msdyn_orderinvoicingdate_AsyncOperations)
- [msdyn_orderinvoicingproduct_AsyncOperations](#BKMK_msdyn_orderinvoicingproduct_AsyncOperations)
- [msdyn_orderinvoicingsetup_AsyncOperations](#BKMK_msdyn_orderinvoicingsetup_AsyncOperations)
- [msdyn_orderinvoicingsetupdate_AsyncOperations](#BKMK_msdyn_orderinvoicingsetupdate_AsyncOperations)
- [msdyn_payment_AsyncOperations](#BKMK_msdyn_payment_AsyncOperations)
- [msdyn_paymentdetail_AsyncOperations](#BKMK_msdyn_paymentdetail_AsyncOperations)
- [msdyn_paymentmethod_AsyncOperations](#BKMK_msdyn_paymentmethod_AsyncOperations)
- [msdyn_paymentterm_AsyncOperations](#BKMK_msdyn_paymentterm_AsyncOperations)
- [msdyn_postalcode_AsyncOperations](#BKMK_msdyn_postalcode_AsyncOperations)
- [msdyn_productinventory_AsyncOperations](#BKMK_msdyn_productinventory_AsyncOperations)
- [msdyn_purchaseorder_AsyncOperations](#BKMK_msdyn_purchaseorder_AsyncOperations)
- [msdyn_purchaseorderbill_AsyncOperations](#BKMK_msdyn_purchaseorderbill_AsyncOperations)
- [msdyn_purchaseorderproduct_AsyncOperations](#BKMK_msdyn_purchaseorderproduct_AsyncOperations)
- [msdyn_purchaseorderreceipt_AsyncOperations](#BKMK_msdyn_purchaseorderreceipt_AsyncOperations)
- [msdyn_purchaseorderreceiptproduct_AsyncOperations](#BKMK_msdyn_purchaseorderreceiptproduct_AsyncOperations)
- [msdyn_purchaseordersubstatus_AsyncOperations](#BKMK_msdyn_purchaseordersubstatus_AsyncOperations)
- [msdyn_quotebookingincident_AsyncOperations](#BKMK_msdyn_quotebookingincident_AsyncOperations)
- [msdyn_quotebookingproduct_AsyncOperations](#BKMK_msdyn_quotebookingproduct_AsyncOperations)
- [msdyn_quotebookingservice_AsyncOperations](#BKMK_msdyn_quotebookingservice_AsyncOperations)
- [msdyn_quotebookingservicetask_AsyncOperations](#BKMK_msdyn_quotebookingservicetask_AsyncOperations)
- [msdyn_quotebookingsetup_AsyncOperations](#BKMK_msdyn_quotebookingsetup_AsyncOperations)
- [msdyn_quoteinvoicingproduct_AsyncOperations](#BKMK_msdyn_quoteinvoicingproduct_AsyncOperations)
- [msdyn_quoteinvoicingsetup_AsyncOperations](#BKMK_msdyn_quoteinvoicingsetup_AsyncOperations)
- [msdyn_resourcepaytype_AsyncOperations](#BKMK_msdyn_resourcepaytype_AsyncOperations)
- [msdyn_rma_AsyncOperations](#BKMK_msdyn_rma_AsyncOperations)
- [msdyn_rmaproduct_AsyncOperations](#BKMK_msdyn_rmaproduct_AsyncOperations)
- [msdyn_rmareceipt_AsyncOperations](#BKMK_msdyn_rmareceipt_AsyncOperations)
- [msdyn_rmareceiptproduct_AsyncOperations](#BKMK_msdyn_rmareceiptproduct_AsyncOperations)
- [msdyn_rmasubstatus_AsyncOperations](#BKMK_msdyn_rmasubstatus_AsyncOperations)
- [msdyn_rtv_AsyncOperations](#BKMK_msdyn_rtv_AsyncOperations)
- [msdyn_rtvproduct_AsyncOperations](#BKMK_msdyn_rtvproduct_AsyncOperations)
- [msdyn_rtvsubstatus_AsyncOperations](#BKMK_msdyn_rtvsubstatus_AsyncOperations)
- [msdyn_servicetasktype_AsyncOperations](#BKMK_msdyn_servicetasktype_AsyncOperations)
- [msdyn_shipvia_AsyncOperations](#BKMK_msdyn_shipvia_AsyncOperations)
- [msdyn_taxcode_AsyncOperations](#BKMK_msdyn_taxcode_AsyncOperations)
- [msdyn_taxcodedetail_AsyncOperations](#BKMK_msdyn_taxcodedetail_AsyncOperations)
- [msdyn_timeoffrequest_AsyncOperations](#BKMK_msdyn_timeoffrequest_AsyncOperations)
- [msdyn_uniquenumber_AsyncOperations](#BKMK_msdyn_uniquenumber_AsyncOperations)
- [msdyn_warehouse_AsyncOperations](#BKMK_msdyn_warehouse_AsyncOperations)
- [msdyn_workorder_AsyncOperations](#BKMK_msdyn_workorder_AsyncOperations)
- [msdyn_workordercharacteristic_AsyncOperations](#BKMK_msdyn_workordercharacteristic_AsyncOperations)
- [msdyn_workorderdetailsgenerationqueue_AsyncOperations](#BKMK_msdyn_workorderdetailsgenerationqueue_AsyncOperations)
- [msdyn_workorderincident_AsyncOperations](#BKMK_msdyn_workorderincident_AsyncOperations)
- [msdyn_workorderproduct_AsyncOperations](#BKMK_msdyn_workorderproduct_AsyncOperations)
- [msdyn_workorderresourcerestriction_AsyncOperations](#BKMK_msdyn_workorderresourcerestriction_AsyncOperations)
- [msdyn_workorderservice_AsyncOperations](#BKMK_msdyn_workorderservice_AsyncOperations)
- [msdyn_workorderservicetask_AsyncOperations](#BKMK_msdyn_workorderservicetask_AsyncOperations)
- [msdyn_workordersubstatus_AsyncOperations](#BKMK_msdyn_workordersubstatus_AsyncOperations)
- [msdyn_workordertype_AsyncOperations](#BKMK_msdyn_workordertype_AsyncOperations)
- [theme_AsyncOperations](#BKMK_theme_AsyncOperations)
- [usermapping_AsyncOperations](#BKMK_usermapping_AsyncOperations)
- [interactionforemail_AsyncOperations](#BKMK_interactionforemail_AsyncOperations)
- [knowledgearticle_AsyncOperations](#BKMK_knowledgearticle_AsyncOperations)
- [post_AsyncOperations](#BKMK_post_AsyncOperations)
- [position_AsyncOperations](#BKMK_position_AsyncOperations)
- [channelaccessprofile_AsyncOperations](#BKMK_channelaccessprofile_AsyncOperations)
- [externalparty_AsyncOperations](#BKMK_externalparty_AsyncOperations)
- [profilerule_AsyncOperations](#BKMK_profilerule_AsyncOperations)
- [KnowledgeBaseRecord_AsyncOperations](#BKMK_KnowledgeBaseRecord_AsyncOperations)
- [lk_asyncoperation_createdby](#BKMK_lk_asyncoperation_createdby)
- [MonthlyFiscalCalendar_AsyncOperations](#BKMK_MonthlyFiscalCalendar_AsyncOperations)
- [lk_asyncoperation_workflowactivationid](#BKMK_lk_asyncoperation_workflowactivationid)
- [Report_AsyncOperations](#BKMK_Report_AsyncOperations)
- [SocialActivity_AsyncOperations](#BKMK_SocialActivity_AsyncOperations)
- [Connection_Role_AsyncOperations](#BKMK_Connection_Role_AsyncOperations)
- [routingruleitem_AsyncOperations](#BKMK_routingruleitem_AsyncOperations)
- [Team_AsyncOperations](#BKMK_Team_AsyncOperations)
- [AnnualFiscalCalendar_AsyncOperations](#BKMK_AnnualFiscalCalendar_AsyncOperations)
- [SharePointDocumentLocation_AsyncOperations](#BKMK_SharePointDocumentLocation_AsyncOperations)
- [PhoneCall_AsyncOperations](#BKMK_PhoneCall_AsyncOperations)
- [Convertrule_AsyncOperations](#BKMK_Convertrule_AsyncOperations)
- [mailbox_asyncoperations](#BKMK_mailbox_asyncoperations)
- [PostFollow_AsyncOperations](#BKMK_PostFollow_AsyncOperations)
- [Appointment_AsyncOperations](#BKMK_Appointment_AsyncOperations)
- [slabase_AsyncOperations](#BKMK_slabase_AsyncOperations)
- [SavedQuery_AsyncOperations](#BKMK_SavedQuery_AsyncOperations)
- [DisplayString_AsyncOperations](#BKMK_DisplayString_AsyncOperations)
- [KbArticleComment_AsyncOperations](#BKMK_KbArticleComment_AsyncOperations)
- [ActivityPointer_AsyncOperations](#BKMK_ActivityPointer_AsyncOperations)
- [Subject_AsyncOperations](#BKMK_Subject_AsyncOperations)
- [goalrollupquery_AsyncOperations](#BKMK_goalrollupquery_AsyncOperations)
- [routingrule_AsyncOperations](#BKMK_routingrule_AsyncOperations)
- [Role_AsyncOperations](#BKMK_Role_AsyncOperations)
- [SystemForm_AsyncOperations](#BKMK_SystemForm_AsyncOperations)
- [Annotation_AsyncOperations](#BKMK_Annotation_AsyncOperations)
- [Privilege_AsyncOperations](#BKMK_Privilege_AsyncOperations)
- [ActivityMimeAttachment_AsyncOperations](#BKMK_ActivityMimeAttachment_AsyncOperations)
- [Goal_AsyncOperations](#BKMK_Goal_AsyncOperations)
- [Fax_AsyncOperations](#BKMK_Fax_AsyncOperations)
- [QuarterlyFiscalCalendar_AsyncOperations](#BKMK_QuarterlyFiscalCalendar_AsyncOperations)
- [SharePointSite_AsyncOperations](#BKMK_SharePointSite_AsyncOperations)
- [UserQuery_AsyncOperations](#BKMK_UserQuery_AsyncOperations)
- [ImportMap_AsyncOperations](#BKMK_ImportMap_AsyncOperations)
- [BusinessUnit_AsyncOperations](#BKMK_BusinessUnit_AsyncOperations)
- [Queue_AsyncOperations](#BKMK_Queue_AsyncOperations)
- [QueueItem_AsyncOperations](#BKMK_QueueItem_AsyncOperations)
- [RelationshipRoleMap_AsyncOperations](#BKMK_RelationshipRoleMap_AsyncOperations)
- [team_asyncoperation](#BKMK_team_asyncoperation)
- [lk_asyncoperation_modifiedby](#BKMK_lk_asyncoperation_modifiedby)
- [CustomerRelationship_AsyncOperations](#BKMK_CustomerRelationship_AsyncOperations)
- [UserForm_AsyncOperations](#BKMK_UserForm_AsyncOperations)
- [RelationshipRole_AsyncOperations](#BKMK_RelationshipRole_AsyncOperations)
- [TransactionCurrency_AsyncOperations](#BKMK_TransactionCurrency_AsyncOperations)
- [rollupfield_AsyncOperations](#BKMK_rollupfield_AsyncOperations)
- [Letter_AsyncOperations](#BKMK_Letter_AsyncOperations)
- [KbArticle_AsyncOperations](#BKMK_KbArticle_AsyncOperations)
- [EntityMap_AsyncOperations](#BKMK_EntityMap_AsyncOperations)
- [RecurringAppointmentMaster_AsyncOperations](#BKMK_RecurringAppointmentMaster_AsyncOperations)
- [IsvConfig_AsyncOperations](#BKMK_IsvConfig_AsyncOperations)
- [Task_AsyncOperations](#BKMK_Task_AsyncOperations)
- [BusinessUnitNewsArticle_AsyncOperations](#BKMK_BusinessUnitNewsArticle_AsyncOperations)
- [AttributeMap_AsyncOperations](#BKMK_AttributeMap_AsyncOperations)
- [Connection_AsyncOperations](#BKMK_Connection_AsyncOperations)
- [SystemUser_AsyncOperations](#BKMK_SystemUser_AsyncOperations)
- [KbArticleTemplate_AsyncOperations](#BKMK_KbArticleTemplate_AsyncOperations)
- [SdkMessageProcessingStep_AsyncOperations](#BKMK_SdkMessageProcessingStep_AsyncOperations)
- [externalpartyitem_AsyncOperations](#BKMK_externalpartyitem_AsyncOperations)
- [Template_AsyncOperations](#BKMK_Template_AsyncOperations)
- [CustomerAddress_AsyncOperations](#BKMK_CustomerAddress_AsyncOperations)
- [Contact_AsyncOperations](#BKMK_Contact_AsyncOperations)
- [emailserverprofile_asyncoperations](#BKMK_emailserverprofile_asyncoperations)
- [lk_asyncoperation_createdonbehalfby](#BKMK_lk_asyncoperation_createdonbehalfby)
- [Import_AsyncOperations](#BKMK_Import_AsyncOperations)
- [system_user_asyncoperation](#BKMK_system_user_asyncoperation)
- [business_unit_asyncoperation](#BKMK_business_unit_asyncoperation)
- [ImportLog_AsyncOperations](#BKMK_ImportLog_AsyncOperations)
- [metric_AsyncOperations](#BKMK_metric_AsyncOperations)
- [SocialProfile_AsyncOperations](#BKMK_SocialProfile_AsyncOperations)
- [lk_asyncoperation_modifiedonbehalfby](#BKMK_lk_asyncoperation_modifiedonbehalfby)
- [Account_AsyncOperations](#BKMK_Account_AsyncOperations)
- [Email_AsyncOperations](#BKMK_Email_AsyncOperations)
- [FixedMonthlyFiscalCalendar_AsyncOperations](#BKMK_FixedMonthlyFiscalCalendar_AsyncOperations)
- [SemiAnnualFiscalCalendar_AsyncOperations](#BKMK_SemiAnnualFiscalCalendar_AsyncOperations)
- [MailMergeTemplate_AsyncOperations](#BKMK_MailMergeTemplate_AsyncOperations)
- [Organization_AsyncOperations](#BKMK_Organization_AsyncOperations)
- [Calendar_AsyncOperations](#BKMK_Calendar_AsyncOperations)
- [ImportFile_AsyncOperations](#BKMK_ImportFile_AsyncOperations)


### <a name="BKMK_msdyn_iotalert_AsyncOperations"></a> msdyn_iotalert_AsyncOperations

See msdyn_iotalert Entity [msdyn_iotalert_AsyncOperations](msdyn_iotalert.md#BKMK_msdyn_iotalert_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_msdyn_iotdevice_AsyncOperations"></a> msdyn_iotdevice_AsyncOperations

See msdyn_iotdevice Entity [msdyn_iotdevice_AsyncOperations](msdyn_iotdevice.md#BKMK_msdyn_iotdevice_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_msdyn_iotdevicecategory_AsyncOperations"></a> msdyn_iotdevicecategory_AsyncOperations

See msdyn_iotdevicecategory Entity [msdyn_iotdevicecategory_AsyncOperations](msdyn_iotdevicecategory.md#BKMK_msdyn_iotdevicecategory_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_msdyn_iotdevicecommand_AsyncOperations"></a> msdyn_iotdevicecommand_AsyncOperations

See msdyn_iotdevicecommand Entity [msdyn_iotdevicecommand_AsyncOperations](msdyn_iotdevicecommand.md#BKMK_msdyn_iotdevicecommand_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_msdyn_iotdeviceregistrationhistory_AsyncOperations"></a> msdyn_iotdeviceregistrationhistory_AsyncOperations

See msdyn_iotdeviceregistrationhistory Entity [msdyn_iotdeviceregistrationhistory_AsyncOperations](msdyn_iotdeviceregistrationhistory.md#BKMK_msdyn_iotdeviceregistrationhistory_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_msdyn_bpf_477c16f59170487b8b4dc895c5dcd09b_AsyncOperations"></a> msdyn_bpf_477c16f59170487b8b4dc895c5dcd09b_AsyncOperations

See msdyn_bpf_477c16f59170487b8b4dc895c5dcd09b Entity [msdyn_bpf_477c16f59170487b8b4dc895c5dcd09b_AsyncOperations](msdyn_bpf_477c16f59170487b8b4dc895c5dcd09b.md#BKMK_msdyn_bpf_477c16f59170487b8b4dc895c5dcd09b_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_Territory_AsyncOperations"></a> Territory_AsyncOperations

See territory Entity [Territory_AsyncOperations](territory.md#BKMK_Territory_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_accountleads_AsyncOperations"></a> accountleads_AsyncOperations

See accountleads Entity [accountleads_AsyncOperations](accountleads.md#BKMK_accountleads_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_contactleads_AsyncOperations"></a> contactleads_AsyncOperations

See contactleads Entity [contactleads_AsyncOperations](contactleads.md#BKMK_contactleads_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_leadaddress_AsyncOperations"></a> leadaddress_AsyncOperations

See leadaddress Entity [leadaddress_AsyncOperations](leadaddress.md#BKMK_leadaddress_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_Lead_AsyncOperations"></a> Lead_AsyncOperations

See lead Entity [Lead_AsyncOperations](lead.md#BKMK_Lead_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_dynamicproperty_AsyncOperations"></a> dynamicproperty_AsyncOperations

See dynamicproperty Entity [dynamicproperty_AsyncOperations](dynamicproperty.md#BKMK_dynamicproperty_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_dynamicpropertyassociation_AsyncOperations"></a> dynamicpropertyassociation_AsyncOperations

See dynamicpropertyassociation Entity [dynamicpropertyassociation_AsyncOperations](dynamicpropertyassociation.md#BKMK_dynamicpropertyassociation_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_dynamicpropertyinstance_AsyncOperations"></a> dynamicpropertyinstance_AsyncOperations

See dynamicpropertyinstance Entity [dynamicpropertyinstance_AsyncOperations](dynamicpropertyinstance.md#BKMK_dynamicpropertyinstance_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_dynamicpropertyoptionsetitem_AsyncOperations"></a> dynamicpropertyoptionsetitem_AsyncOperations

See dynamicpropertyoptionsetitem Entity [dynamicpropertyoptionsetitem_AsyncOperations](dynamicpropertyoptionsetitem.md#BKMK_dynamicpropertyoptionsetitem_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_PriceLevel_AsyncOperations"></a> PriceLevel_AsyncOperations

See pricelevel Entity [PriceLevel_AsyncOperations](pricelevel.md#BKMK_PriceLevel_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_Product_AsyncOperations"></a> Product_AsyncOperations

See product Entity [Product_AsyncOperations](product.md#BKMK_Product_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_ProductAssociation_AsyncOperations"></a> ProductAssociation_AsyncOperations

See productassociation Entity [ProductAssociation_AsyncOperations](productassociation.md#BKMK_ProductAssociation_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_ProductPriceLevel_AsyncOperations"></a> ProductPriceLevel_AsyncOperations

See productpricelevel Entity [ProductPriceLevel_AsyncOperations](productpricelevel.md#BKMK_ProductPriceLevel_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_ProductSubstitute_AsyncOperations"></a> ProductSubstitute_AsyncOperations

See productsubstitute Entity [ProductSubstitute_AsyncOperations](productsubstitute.md#BKMK_ProductSubstitute_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_UoM_AsyncOperations"></a> UoM_AsyncOperations

See uom Entity [UoM_AsyncOperations](uom.md#BKMK_UoM_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_UoMSchedule_AsyncOperations"></a> UoMSchedule_AsyncOperations

See uomschedule Entity [UoMSchedule_AsyncOperations](uomschedule.md#BKMK_UoMSchedule_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_bookableresource_AsyncOperations"></a> bookableresource_AsyncOperations

See bookableresource Entity [bookableresource_AsyncOperations](bookableresource.md#BKMK_bookableresource_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_bookableresourcebooking_AsyncOperations"></a> bookableresourcebooking_AsyncOperations

See bookableresourcebooking Entity [bookableresourcebooking_AsyncOperations](bookableresourcebooking.md#BKMK_bookableresourcebooking_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_bookableresourcebookingexchangesyncidmapping_AsyncOperations"></a> bookableresourcebookingexchangesyncidmapping_AsyncOperations

See bookableresourcebookingexchangesyncidmapping Entity [bookableresourcebookingexchangesyncidmapping_AsyncOperations](bookableresourcebookingexchangesyncidmapping.md#BKMK_bookableresourcebookingexchangesyncidmapping_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_bookableresourcebookingheader_AsyncOperations"></a> bookableresourcebookingheader_AsyncOperations

See bookableresourcebookingheader Entity [bookableresourcebookingheader_AsyncOperations](bookableresourcebookingheader.md#BKMK_bookableresourcebookingheader_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_bookableresourcecategory_AsyncOperations"></a> bookableresourcecategory_AsyncOperations

See bookableresourcecategory Entity [bookableresourcecategory_AsyncOperations](bookableresourcecategory.md#BKMK_bookableresourcecategory_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_bookableresourcecategoryassn_AsyncOperations"></a> bookableresourcecategoryassn_AsyncOperations

See bookableresourcecategoryassn Entity [bookableresourcecategoryassn_AsyncOperations](bookableresourcecategoryassn.md#BKMK_bookableresourcecategoryassn_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_bookableresourcecharacteristic_AsyncOperations"></a> bookableresourcecharacteristic_AsyncOperations

See bookableresourcecharacteristic Entity [bookableresourcecharacteristic_AsyncOperations](bookableresourcecharacteristic.md#BKMK_bookableresourcecharacteristic_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_bookableresourcegroup_AsyncOperations"></a> bookableresourcegroup_AsyncOperations

See bookableresourcegroup Entity [bookableresourcegroup_AsyncOperations](bookableresourcegroup.md#BKMK_bookableresourcegroup_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_bookingstatus_AsyncOperations"></a> bookingstatus_AsyncOperations

See bookingstatus Entity [bookingstatus_AsyncOperations](bookingstatus.md#BKMK_bookingstatus_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_characteristic_AsyncOperations"></a> characteristic_AsyncOperations

See characteristic Entity [characteristic_AsyncOperations](characteristic.md#BKMK_characteristic_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_ratingmodel_AsyncOperations"></a> ratingmodel_AsyncOperations

See ratingmodel Entity [ratingmodel_AsyncOperations](ratingmodel.md#BKMK_ratingmodel_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_ratingvalue_AsyncOperations"></a> ratingvalue_AsyncOperations

See ratingvalue Entity [ratingvalue_AsyncOperations](ratingvalue.md#BKMK_ratingvalue_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_BulkOperation_AsyncOperations"></a> BulkOperation_AsyncOperations

See bulkoperation Entity [BulkOperation_AsyncOperations](bulkoperation.md#BKMK_BulkOperation_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_BulkOperationLog_AsyncOperations"></a> BulkOperationLog_AsyncOperations

See bulkoperationlog Entity [BulkOperationLog_AsyncOperations](bulkoperationlog.md#BKMK_BulkOperationLog_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_Campaign_AsyncOperations"></a> Campaign_AsyncOperations

See campaign Entity [Campaign_AsyncOperations](campaign.md#BKMK_Campaign_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_CampaignActivity_AsyncOperations"></a> CampaignActivity_AsyncOperations

See campaignactivity Entity [CampaignActivity_AsyncOperations](campaignactivity.md#BKMK_CampaignActivity_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_campaignactivityitem_AsyncOperations"></a> campaignactivityitem_AsyncOperations

See campaignactivityitem Entity [campaignactivityitem_AsyncOperations](campaignactivityitem.md#BKMK_campaignactivityitem_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_campaignitem_AsyncOperations"></a> campaignitem_AsyncOperations

See campaignitem Entity [campaignitem_AsyncOperations](campaignitem.md#BKMK_campaignitem_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_CampaignResponse_AsyncOperations"></a> CampaignResponse_AsyncOperations

See campaignresponse Entity [CampaignResponse_AsyncOperations](campaignresponse.md#BKMK_CampaignResponse_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_List_AsyncOperations"></a> List_AsyncOperations

See list Entity [List_AsyncOperations](list.md#BKMK_List_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_listmember_AsyncOperations"></a> listmember_AsyncOperations

See listmember Entity [listmember_AsyncOperations](listmember.md#BKMK_listmember_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_commitment_AsyncOperations"></a> commitment_AsyncOperations

See commitment Entity [commitment_AsyncOperations](commitment.md#BKMK_commitment_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_ConstraintBasedGroup_AsyncOperations"></a> ConstraintBasedGroup_AsyncOperations

See constraintbasedgroup Entity [ConstraintBasedGroup_AsyncOperations](constraintbasedgroup.md#BKMK_ConstraintBasedGroup_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_Contract_AsyncOperations"></a> Contract_AsyncOperations

See contract Entity [Contract_AsyncOperations](contract.md#BKMK_Contract_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_ContractDetail_AsyncOperations"></a> ContractDetail_AsyncOperations

See contractdetail Entity [ContractDetail_AsyncOperations](contractdetail.md#BKMK_ContractDetail_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_ContractTemplate_AsyncOperations"></a> ContractTemplate_AsyncOperations

See contracttemplate Entity [ContractTemplate_AsyncOperations](contracttemplate.md#BKMK_ContractTemplate_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_entitlement_AsyncOperations"></a> entitlement_AsyncOperations

See entitlement Entity [entitlement_AsyncOperations](entitlement.md#BKMK_entitlement_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_entitlementchannel_AsyncOperations"></a> entitlementchannel_AsyncOperations

See entitlementchannel Entity [entitlementchannel_AsyncOperations](entitlementchannel.md#BKMK_entitlementchannel_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_entitlementcontacts_AsyncOperations"></a> entitlementcontacts_AsyncOperations

See entitlementcontacts Entity [entitlementcontacts_AsyncOperations](entitlementcontacts.md#BKMK_entitlementcontacts_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_entitlementproducts_AsyncOperations"></a> entitlementproducts_AsyncOperations

See entitlementproducts Entity [entitlementproducts_AsyncOperations](entitlementproducts.md#BKMK_entitlementproducts_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_entitlementtemplate_AsyncOperations"></a> entitlementtemplate_AsyncOperations

See entitlementtemplate Entity [entitlementtemplate_AsyncOperations](entitlementtemplate.md#BKMK_entitlementtemplate_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_entitlementtemplatechannel_AsyncOperations"></a> entitlementtemplatechannel_AsyncOperations

See entitlementtemplatechannel Entity [entitlementtemplatechannel_AsyncOperations](entitlementtemplatechannel.md#BKMK_entitlementtemplatechannel_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_entitlementtemplateproducts_AsyncOperations"></a> entitlementtemplateproducts_AsyncOperations

See entitlementtemplateproducts Entity [entitlementtemplateproducts_AsyncOperations](entitlementtemplateproducts.md#BKMK_entitlementtemplateproducts_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_Equipment_AsyncOperations"></a> Equipment_AsyncOperations

See equipment Entity [Equipment_AsyncOperations](equipment.md#BKMK_Equipment_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_Incident_AsyncOperations"></a> Incident_AsyncOperations

See incident Entity [Incident_AsyncOperations](incident.md#BKMK_Incident_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_incidentknowledgebaserecord_AsyncOperations"></a> incidentknowledgebaserecord_AsyncOperations

See incidentknowledgebaserecord Entity [incidentknowledgebaserecord_AsyncOperations](incidentknowledgebaserecord.md#BKMK_incidentknowledgebaserecord_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_IncidentResolution_AsyncOperations"></a> IncidentResolution_AsyncOperations

See incidentresolution Entity [IncidentResolution_AsyncOperations](incidentresolution.md#BKMK_IncidentResolution_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_knowledgearticleincident_AsyncOperations"></a> knowledgearticleincident_AsyncOperations

See knowledgearticleincident Entity [knowledgearticleincident_AsyncOperations](knowledgearticleincident.md#BKMK_knowledgearticleincident_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_phonetocaseprocess_AsyncOperations"></a> phonetocaseprocess_AsyncOperations

See phonetocaseprocess Entity [phonetocaseprocess_AsyncOperations](phonetocaseprocess.md#BKMK_phonetocaseprocess_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_Resource_AsyncOperations"></a> Resource_AsyncOperations

See resource Entity [Resource_AsyncOperations](resource.md#BKMK_Resource_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_ResourceGroup_AsyncOperations"></a> ResourceGroup_AsyncOperations

See resourcegroup Entity [ResourceGroup_AsyncOperations](resourcegroup.md#BKMK_ResourceGroup_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_ResourceSpec_AsyncOperations"></a> ResourceSpec_AsyncOperations

See resourcespec Entity [ResourceSpec_AsyncOperations](resourcespec.md#BKMK_ResourceSpec_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_Service_AsyncOperations"></a> Service_AsyncOperations

See service Entity [Service_AsyncOperations](service.md#BKMK_Service_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_ServiceAppointment_AsyncOperations"></a> ServiceAppointment_AsyncOperations

See serviceappointment Entity [ServiceAppointment_AsyncOperations](serviceappointment.md#BKMK_ServiceAppointment_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_servicecontractcontacts_AsyncOperations"></a> servicecontractcontacts_AsyncOperations

See servicecontractcontacts Entity [servicecontractcontacts_AsyncOperations](servicecontractcontacts.md#BKMK_servicecontractcontacts_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_topic_AsyncOperations"></a> topic_AsyncOperations

See topic Entity [topic_AsyncOperations](topic.md#BKMK_topic_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_topichistory_AsyncOperations"></a> topichistory_AsyncOperations

See topichistory Entity [topichistory_AsyncOperations](topichistory.md#BKMK_topichistory_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_topicmodel_AsyncOperations"></a> topicmodel_AsyncOperations

See topicmodel Entity [topicmodel_AsyncOperations](topicmodel.md#BKMK_topicmodel_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_topicmodelconfiguration_AsyncOperations"></a> topicmodelconfiguration_AsyncOperations

See topicmodelconfiguration Entity [topicmodelconfiguration_AsyncOperations](topicmodelconfiguration.md#BKMK_topicmodelconfiguration_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_topicmodelexecutionhistory_AsyncOperations"></a> topicmodelexecutionhistory_AsyncOperations

See topicmodelexecutionhistory Entity [topicmodelexecutionhistory_AsyncOperations](topicmodelexecutionhistory.md#BKMK_topicmodelexecutionhistory_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_Site_AsyncOperations"></a> Site_AsyncOperations

See site Entity [Site_AsyncOperations](site.md#BKMK_Site_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_competitorproduct_AsyncOperations"></a> competitorproduct_AsyncOperations

See competitorproduct Entity [competitorproduct_AsyncOperations](competitorproduct.md#BKMK_competitorproduct_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_competitorsalesliterature_AsyncOperations"></a> competitorsalesliterature_AsyncOperations

See competitorsalesliterature Entity [competitorsalesliterature_AsyncOperations](competitorsalesliterature.md#BKMK_competitorsalesliterature_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_contactinvoices_AsyncOperations"></a> contactinvoices_AsyncOperations

See contactinvoices Entity [contactinvoices_AsyncOperations](contactinvoices.md#BKMK_contactinvoices_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_contactorders_AsyncOperations"></a> contactorders_AsyncOperations

See contactorders Entity [contactorders_AsyncOperations](contactorders.md#BKMK_contactorders_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_contactquotes_AsyncOperations"></a> contactquotes_AsyncOperations

See contactquotes Entity [contactquotes_AsyncOperations](contactquotes.md#BKMK_contactquotes_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_CustomerOpportunityRole_AsyncOperations"></a> CustomerOpportunityRole_AsyncOperations

See customeropportunityrole Entity [CustomerOpportunityRole_AsyncOperations](customeropportunityrole.md#BKMK_CustomerOpportunityRole_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_Discount_AsyncOperations"></a> Discount_AsyncOperations

See discount Entity [Discount_AsyncOperations](discount.md#BKMK_Discount_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_DiscountType_AsyncOperations"></a> DiscountType_AsyncOperations

See discounttype Entity [DiscountType_AsyncOperations](discounttype.md#BKMK_DiscountType_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_Invoice_AsyncOperations"></a> Invoice_AsyncOperations

See invoice Entity [Invoice_AsyncOperations](invoice.md#BKMK_Invoice_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_InvoiceDetail_AsyncOperations"></a> InvoiceDetail_AsyncOperations

See invoicedetail Entity [InvoiceDetail_AsyncOperations](invoicedetail.md#BKMK_InvoiceDetail_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_leadcompetitors_AsyncOperations"></a> leadcompetitors_AsyncOperations

See leadcompetitors Entity [leadcompetitors_AsyncOperations](leadcompetitors.md#BKMK_leadcompetitors_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_leadproduct_AsyncOperations"></a> leadproduct_AsyncOperations

See leadproduct Entity [leadproduct_AsyncOperations](leadproduct.md#BKMK_leadproduct_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_leadtoopportunitysalesprocess_AsyncOperations"></a> leadtoopportunitysalesprocess_AsyncOperations

See leadtoopportunitysalesprocess Entity [leadtoopportunitysalesprocess_AsyncOperations](leadtoopportunitysalesprocess.md#BKMK_leadtoopportunitysalesprocess_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_Opportunity_AsyncOperations"></a> Opportunity_AsyncOperations

See opportunity Entity [Opportunity_AsyncOperations](opportunity.md#BKMK_Opportunity_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_OpportunityClose_AsyncOperations"></a> OpportunityClose_AsyncOperations

See opportunityclose Entity [OpportunityClose_AsyncOperations](opportunityclose.md#BKMK_OpportunityClose_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_opportunitycompetitors_AsyncOperations"></a> opportunitycompetitors_AsyncOperations

See opportunitycompetitors Entity [opportunitycompetitors_AsyncOperations](opportunitycompetitors.md#BKMK_opportunitycompetitors_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_OpportunityProduct_AsyncOperations"></a> OpportunityProduct_AsyncOperations

See opportunityproduct Entity [OpportunityProduct_AsyncOperations](opportunityproduct.md#BKMK_OpportunityProduct_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_opportunitysalesprocess_AsyncOperations"></a> opportunitysalesprocess_AsyncOperations

See opportunitysalesprocess Entity [opportunitysalesprocess_AsyncOperations](opportunitysalesprocess.md#BKMK_opportunitysalesprocess_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_OrderClose_AsyncOperations"></a> OrderClose_AsyncOperations

See orderclose Entity [OrderClose_AsyncOperations](orderclose.md#BKMK_OrderClose_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_productsalesliterature_AsyncOperations"></a> productsalesliterature_AsyncOperations

See productsalesliterature Entity [productsalesliterature_AsyncOperations](productsalesliterature.md#BKMK_productsalesliterature_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_Quote_AsyncOperations"></a> Quote_AsyncOperations

See quote Entity [Quote_AsyncOperations](quote.md#BKMK_Quote_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_QuoteClose_AsyncOperations"></a> QuoteClose_AsyncOperations

See quoteclose Entity [QuoteClose_AsyncOperations](quoteclose.md#BKMK_QuoteClose_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_QuoteDetail_AsyncOperations"></a> QuoteDetail_AsyncOperations

See quotedetail Entity [QuoteDetail_AsyncOperations](quotedetail.md#BKMK_QuoteDetail_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_SalesLiterature_AsyncOperations"></a> SalesLiterature_AsyncOperations

See salesliterature Entity [SalesLiterature_AsyncOperations](salesliterature.md#BKMK_SalesLiterature_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_SalesLiteratureItem_AsyncOperations"></a> SalesLiteratureItem_AsyncOperations

See salesliteratureitem Entity [SalesLiteratureItem_AsyncOperations](salesliteratureitem.md#BKMK_SalesLiteratureItem_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_SalesOrder_AsyncOperations"></a> SalesOrder_AsyncOperations

See salesorder Entity [SalesOrder_AsyncOperations](salesorder.md#BKMK_SalesOrder_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_SalesOrderDetail_AsyncOperations"></a> SalesOrderDetail_AsyncOperations

See salesorderdetail Entity [SalesOrderDetail_AsyncOperations](salesorderdetail.md#BKMK_SalesOrderDetail_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_Competitor_AsyncOperations"></a> Competitor_AsyncOperations

See competitor Entity [Competitor_AsyncOperations](competitor.md#BKMK_Competitor_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_msdyn_postalbum_AsyncOperations"></a> msdyn_postalbum_AsyncOperations

See msdyn_postalbum Entity [msdyn_postalbum_AsyncOperations](msdyn_postalbum.md#BKMK_msdyn_postalbum_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_msdyn_postconfig_AsyncOperations"></a> msdyn_postconfig_AsyncOperations

See msdyn_postconfig Entity [msdyn_postconfig_AsyncOperations](msdyn_postconfig.md#BKMK_msdyn_postconfig_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_msdyn_postruleconfig_AsyncOperations"></a> msdyn_postruleconfig_AsyncOperations

See msdyn_postruleconfig Entity [msdyn_postruleconfig_AsyncOperations](msdyn_postruleconfig.md#BKMK_msdyn_postruleconfig_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_msdyn_wallsavedquery_AsyncOperations"></a> msdyn_wallsavedquery_AsyncOperations

See msdyn_wallsavedquery Entity [msdyn_wallsavedquery_AsyncOperations](msdyn_wallsavedquery.md#BKMK_msdyn_wallsavedquery_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_msdyn_wallsavedqueryusersettings_AsyncOperations"></a> msdyn_wallsavedqueryusersettings_AsyncOperations

See msdyn_wallsavedqueryusersettings Entity [msdyn_wallsavedqueryusersettings_AsyncOperations](msdyn_wallsavedqueryusersettings.md#BKMK_msdyn_wallsavedqueryusersettings_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_msdyn_actual_AsyncOperations"></a> msdyn_actual_AsyncOperations

See msdyn_actual Entity [msdyn_actual_AsyncOperations](msdyn_actual.md#BKMK_msdyn_actual_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_msdyn_bookingalert_AsyncOperations"></a> msdyn_bookingalert_AsyncOperations

See msdyn_bookingalert Entity [msdyn_bookingalert_AsyncOperations](msdyn_bookingalert.md#BKMK_msdyn_bookingalert_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_msdyn_bookingalertstatus_AsyncOperations"></a> msdyn_bookingalertstatus_AsyncOperations

See msdyn_bookingalertstatus Entity [msdyn_bookingalertstatus_AsyncOperations](msdyn_bookingalertstatus.md#BKMK_msdyn_bookingalertstatus_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_msdyn_bookingchange_AsyncOperations"></a> msdyn_bookingchange_AsyncOperations

See msdyn_bookingchange Entity [msdyn_bookingchange_AsyncOperations](msdyn_bookingchange.md#BKMK_msdyn_bookingchange_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_msdyn_bookingrule_AsyncOperations"></a> msdyn_bookingrule_AsyncOperations

See msdyn_bookingrule Entity [msdyn_bookingrule_AsyncOperations](msdyn_bookingrule.md#BKMK_msdyn_bookingrule_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_msdyn_bookingsetupmetadata_AsyncOperations"></a> msdyn_bookingsetupmetadata_AsyncOperations

See msdyn_bookingsetupmetadata Entity [msdyn_bookingsetupmetadata_AsyncOperations](msdyn_bookingsetupmetadata.md#BKMK_msdyn_bookingsetupmetadata_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_msdyn_clientextension_AsyncOperations"></a> msdyn_clientextension_AsyncOperations

See msdyn_clientextension Entity [msdyn_clientextension_AsyncOperations](msdyn_clientextension.md#BKMK_msdyn_clientextension_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_msdyn_configuration_AsyncOperations"></a> msdyn_configuration_AsyncOperations

See msdyn_configuration Entity [msdyn_configuration_AsyncOperations](msdyn_configuration.md#BKMK_msdyn_configuration_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_msdyn_organizationalunit_AsyncOperations"></a> msdyn_organizationalunit_AsyncOperations

See msdyn_organizationalunit Entity [msdyn_organizationalunit_AsyncOperations](msdyn_organizationalunit.md#BKMK_msdyn_organizationalunit_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_msdyn_priority_AsyncOperations"></a> msdyn_priority_AsyncOperations

See msdyn_priority Entity [msdyn_priority_AsyncOperations](msdyn_priority.md#BKMK_msdyn_priority_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_msdyn_requirementcharacteristic_AsyncOperations"></a> msdyn_requirementcharacteristic_AsyncOperations

See msdyn_requirementcharacteristic Entity [msdyn_requirementcharacteristic_AsyncOperations](msdyn_requirementcharacteristic.md#BKMK_msdyn_requirementcharacteristic_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_msdyn_requirementorganizationunit_AsyncOperations"></a> msdyn_requirementorganizationunit_AsyncOperations

See msdyn_requirementorganizationunit Entity [msdyn_requirementorganizationunit_AsyncOperations](msdyn_requirementorganizationunit.md#BKMK_msdyn_requirementorganizationunit_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_msdyn_requirementresourcecategory_AsyncOperations"></a> msdyn_requirementresourcecategory_AsyncOperations

See msdyn_requirementresourcecategory Entity [msdyn_requirementresourcecategory_AsyncOperations](msdyn_requirementresourcecategory.md#BKMK_msdyn_requirementresourcecategory_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_msdyn_requirementresourcepreference_AsyncOperations"></a> msdyn_requirementresourcepreference_AsyncOperations

See msdyn_requirementresourcepreference Entity [msdyn_requirementresourcepreference_AsyncOperations](msdyn_requirementresourcepreference.md#BKMK_msdyn_requirementresourcepreference_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_msdyn_requirementstatus_AsyncOperations"></a> msdyn_requirementstatus_AsyncOperations

See msdyn_requirementstatus Entity [msdyn_requirementstatus_AsyncOperations](msdyn_requirementstatus.md#BKMK_msdyn_requirementstatus_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_msdyn_resourcerequirement_AsyncOperations"></a> msdyn_resourcerequirement_AsyncOperations

See msdyn_resourcerequirement Entity [msdyn_resourcerequirement_AsyncOperations](msdyn_resourcerequirement.md#BKMK_msdyn_resourcerequirement_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_msdyn_resourcerequirementdetail_AsyncOperations"></a> msdyn_resourcerequirementdetail_AsyncOperations

See msdyn_resourcerequirementdetail Entity [msdyn_resourcerequirementdetail_AsyncOperations](msdyn_resourcerequirementdetail.md#BKMK_msdyn_resourcerequirementdetail_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_msdyn_resourceterritory_AsyncOperations"></a> msdyn_resourceterritory_AsyncOperations

See msdyn_resourceterritory Entity [msdyn_resourceterritory_AsyncOperations](msdyn_resourceterritory.md#BKMK_msdyn_resourceterritory_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_msdyn_scheduleboardsetting_AsyncOperations"></a> msdyn_scheduleboardsetting_AsyncOperations

See msdyn_scheduleboardsetting Entity [msdyn_scheduleboardsetting_AsyncOperations](msdyn_scheduleboardsetting.md#BKMK_msdyn_scheduleboardsetting_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_msdyn_schedulingparameter_AsyncOperations"></a> msdyn_schedulingparameter_AsyncOperations

See msdyn_schedulingparameter Entity [msdyn_schedulingparameter_AsyncOperations](msdyn_schedulingparameter.md#BKMK_msdyn_schedulingparameter_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_msdyn_systemuserschedulersetting_AsyncOperations"></a> msdyn_systemuserschedulersetting_AsyncOperations

See msdyn_systemuserschedulersetting Entity [msdyn_systemuserschedulersetting_AsyncOperations](msdyn_systemuserschedulersetting.md#BKMK_msdyn_systemuserschedulersetting_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_msdyn_timegroup_AsyncOperations"></a> msdyn_timegroup_AsyncOperations

See msdyn_timegroup Entity [msdyn_timegroup_AsyncOperations](msdyn_timegroup.md#BKMK_msdyn_timegroup_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_msdyn_timegroupdetail_AsyncOperations"></a> msdyn_timegroupdetail_AsyncOperations

See msdyn_timegroupdetail Entity [msdyn_timegroupdetail_AsyncOperations](msdyn_timegroupdetail.md#BKMK_msdyn_timegroupdetail_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_msdyn_transactionorigin_AsyncOperations"></a> msdyn_transactionorigin_AsyncOperations

See msdyn_transactionorigin Entity [msdyn_transactionorigin_AsyncOperations](msdyn_transactionorigin.md#BKMK_msdyn_transactionorigin_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_msdyn_workhourtemplate_AsyncOperations"></a> msdyn_workhourtemplate_AsyncOperations

See msdyn_workhourtemplate Entity [msdyn_workhourtemplate_AsyncOperations](msdyn_workhourtemplate.md#BKMK_msdyn_workhourtemplate_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_msdyn_accountpricelist_AsyncOperations"></a> msdyn_accountpricelist_AsyncOperations

See msdyn_accountpricelist Entity [msdyn_accountpricelist_AsyncOperations](msdyn_accountpricelist.md#BKMK_msdyn_accountpricelist_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_msdyn_approval_AsyncOperations"></a> msdyn_approval_AsyncOperations

See msdyn_approval Entity [msdyn_approval_AsyncOperations](msdyn_approval.md#BKMK_msdyn_approval_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_msdyn_batchjob_AsyncOperations"></a> msdyn_batchjob_AsyncOperations

See msdyn_batchjob Entity [msdyn_batchjob_AsyncOperations](msdyn_batchjob.md#BKMK_msdyn_batchjob_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_msdyn_bpf_665e73aa18c247d886bfc50499c73b82_AsyncOperations"></a> msdyn_bpf_665e73aa18c247d886bfc50499c73b82_AsyncOperations

See msdyn_bpf_665e73aa18c247d886bfc50499c73b82 Entity [msdyn_bpf_665e73aa18c247d886bfc50499c73b82_AsyncOperations](msdyn_bpf_665e73aa18c247d886bfc50499c73b82.md#BKMK_msdyn_bpf_665e73aa18c247d886bfc50499c73b82_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_msdyn_bpf_d8f9dc7f099f44db9d641dd81fbd470d_AsyncOperations"></a> msdyn_bpf_d8f9dc7f099f44db9d641dd81fbd470d_AsyncOperations

See msdyn_bpf_d8f9dc7f099f44db9d641dd81fbd470d Entity [msdyn_bpf_d8f9dc7f099f44db9d641dd81fbd470d_AsyncOperations](msdyn_bpf_d8f9dc7f099f44db9d641dd81fbd470d.md#BKMK_msdyn_bpf_d8f9dc7f099f44db9d641dd81fbd470d_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_msdyn_characteristicreqforteammember_AsyncOperations"></a> msdyn_characteristicreqforteammember_AsyncOperations

See msdyn_characteristicreqforteammember Entity [msdyn_characteristicreqforteammember_AsyncOperations](msdyn_characteristicreqforteammember.md#BKMK_msdyn_characteristicreqforteammember_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_msdyn_contactpricelist_AsyncOperations"></a> msdyn_contactpricelist_AsyncOperations

See msdyn_contactpricelist Entity [msdyn_contactpricelist_AsyncOperations](msdyn_contactpricelist.md#BKMK_msdyn_contactpricelist_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_msdyn_contractlineinvoiceschedule_AsyncOperations"></a> msdyn_contractlineinvoiceschedule_AsyncOperations

See msdyn_contractlineinvoiceschedule Entity [msdyn_contractlineinvoiceschedule_AsyncOperations](msdyn_contractlineinvoiceschedule.md#BKMK_msdyn_contractlineinvoiceschedule_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_msdyn_contractlinescheduleofvalue_AsyncOperations"></a> msdyn_contractlinescheduleofvalue_AsyncOperations

See msdyn_contractlinescheduleofvalue Entity [msdyn_contractlinescheduleofvalue_AsyncOperations](msdyn_contractlinescheduleofvalue.md#BKMK_msdyn_contractlinescheduleofvalue_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_msdyn_dataexport_AsyncOperations"></a> msdyn_dataexport_AsyncOperations

See msdyn_dataexport Entity [msdyn_dataexport_AsyncOperations](msdyn_dataexport.md#BKMK_msdyn_dataexport_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_msdyn_delegation_AsyncOperations"></a> msdyn_delegation_AsyncOperations

See msdyn_delegation Entity [msdyn_delegation_AsyncOperations](msdyn_delegation.md#BKMK_msdyn_delegation_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_msdyn_estimate_AsyncOperations"></a> msdyn_estimate_AsyncOperations

See msdyn_estimate Entity [msdyn_estimate_AsyncOperations](msdyn_estimate.md#BKMK_msdyn_estimate_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_msdyn_estimateline_AsyncOperations"></a> msdyn_estimateline_AsyncOperations

See msdyn_estimateline Entity [msdyn_estimateline_AsyncOperations](msdyn_estimateline.md#BKMK_msdyn_estimateline_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_msdyn_expense_AsyncOperations"></a> msdyn_expense_AsyncOperations

See msdyn_expense Entity [msdyn_expense_AsyncOperations](msdyn_expense.md#BKMK_msdyn_expense_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_msdyn_expensecategory_AsyncOperations"></a> msdyn_expensecategory_AsyncOperations

See msdyn_expensecategory Entity [msdyn_expensecategory_AsyncOperations](msdyn_expensecategory.md#BKMK_msdyn_expensecategory_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_msdyn_expensereceipt_AsyncOperations"></a> msdyn_expensereceipt_AsyncOperations

See msdyn_expensereceipt Entity [msdyn_expensereceipt_AsyncOperations](msdyn_expensereceipt.md#BKMK_msdyn_expensereceipt_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_msdyn_fact_AsyncOperations"></a> msdyn_fact_AsyncOperations

See msdyn_fact Entity [msdyn_fact_AsyncOperations](msdyn_fact.md#BKMK_msdyn_fact_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_msdyn_fieldcomputation_AsyncOperations"></a> msdyn_fieldcomputation_AsyncOperations

See msdyn_fieldcomputation Entity [msdyn_fieldcomputation_AsyncOperations](msdyn_fieldcomputation.md#BKMK_msdyn_fieldcomputation_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_msdyn_findworkevent_AsyncOperations"></a> msdyn_findworkevent_AsyncOperations

See msdyn_findworkevent Entity [msdyn_findworkevent_AsyncOperations](msdyn_findworkevent.md#BKMK_msdyn_findworkevent_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_msdyn_integrationjob_AsyncOperations"></a> msdyn_integrationjob_AsyncOperations

See msdyn_integrationjob Entity [msdyn_integrationjob_AsyncOperations](msdyn_integrationjob.md#BKMK_msdyn_integrationjob_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_msdyn_integrationjobdetail_AsyncOperations"></a> msdyn_integrationjobdetail_AsyncOperations

See msdyn_integrationjobdetail Entity [msdyn_integrationjobdetail_AsyncOperations](msdyn_integrationjobdetail.md#BKMK_msdyn_integrationjobdetail_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_msdyn_invoicefrequency_AsyncOperations"></a> msdyn_invoicefrequency_AsyncOperations

See msdyn_invoicefrequency Entity [msdyn_invoicefrequency_AsyncOperations](msdyn_invoicefrequency.md#BKMK_msdyn_invoicefrequency_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_msdyn_invoicefrequencydetail_AsyncOperations"></a> msdyn_invoicefrequencydetail_AsyncOperations

See msdyn_invoicefrequencydetail Entity [msdyn_invoicefrequencydetail_AsyncOperations](msdyn_invoicefrequencydetail.md#BKMK_msdyn_invoicefrequencydetail_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_msdyn_invoicelinetransaction_AsyncOperations"></a> msdyn_invoicelinetransaction_AsyncOperations

See msdyn_invoicelinetransaction Entity [msdyn_invoicelinetransaction_AsyncOperations](msdyn_invoicelinetransaction.md#BKMK_msdyn_invoicelinetransaction_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_msdyn_journal_AsyncOperations"></a> msdyn_journal_AsyncOperations

See msdyn_journal Entity [msdyn_journal_AsyncOperations](msdyn_journal.md#BKMK_msdyn_journal_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_msdyn_journalline_AsyncOperations"></a> msdyn_journalline_AsyncOperations

See msdyn_journalline Entity [msdyn_journalline_AsyncOperations](msdyn_journalline.md#BKMK_msdyn_journalline_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_msdyn_mlresultcache_AsyncOperations"></a> msdyn_mlresultcache_AsyncOperations

See msdyn_mlresultcache Entity [msdyn_mlresultcache_AsyncOperations](msdyn_mlresultcache.md#BKMK_msdyn_mlresultcache_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_msdyn_opportunitylineresourcecategory_AsyncOperations"></a> msdyn_opportunitylineresourcecategory_AsyncOperations

See msdyn_opportunitylineresourcecategory Entity [msdyn_opportunitylineresourcecategory_AsyncOperations](msdyn_opportunitylineresourcecategory.md#BKMK_msdyn_opportunitylineresourcecategory_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_msdyn_opportunitylinetransaction_AsyncOperations"></a> msdyn_opportunitylinetransaction_AsyncOperations

See msdyn_opportunitylinetransaction Entity [msdyn_opportunitylinetransaction_AsyncOperations](msdyn_opportunitylinetransaction.md#BKMK_msdyn_opportunitylinetransaction_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_msdyn_opportunitylinetransactioncategory_AsyncOperations"></a> msdyn_opportunitylinetransactioncategory_AsyncOperations

See msdyn_opportunitylinetransactioncategory Entity [msdyn_opportunitylinetransactioncategory_AsyncOperations](msdyn_opportunitylinetransactioncategory.md#BKMK_msdyn_opportunitylinetransactioncategory_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_msdyn_opportunitylinetransactionclassificatio_AsyncOperations"></a> msdyn_opportunitylinetransactionclassificatio_AsyncOperations

See msdyn_opportunitylinetransactionclassificatio Entity [msdyn_opportunitylinetransactionclassificatio_AsyncOperations](msdyn_opportunitylinetransactionclassificatio.md#BKMK_msdyn_opportunitylinetransactionclassificatio_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_msdyn_opportunitypricelist_AsyncOperations"></a> msdyn_opportunitypricelist_AsyncOperations

See msdyn_opportunitypricelist Entity [msdyn_opportunitypricelist_AsyncOperations](msdyn_opportunitypricelist.md#BKMK_msdyn_opportunitypricelist_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_msdyn_orderlineresourcecategory_AsyncOperations"></a> msdyn_orderlineresourcecategory_AsyncOperations

See msdyn_orderlineresourcecategory Entity [msdyn_orderlineresourcecategory_AsyncOperations](msdyn_orderlineresourcecategory.md#BKMK_msdyn_orderlineresourcecategory_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_msdyn_orderlinetransaction_AsyncOperations"></a> msdyn_orderlinetransaction_AsyncOperations

See msdyn_orderlinetransaction Entity [msdyn_orderlinetransaction_AsyncOperations](msdyn_orderlinetransaction.md#BKMK_msdyn_orderlinetransaction_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_msdyn_orderlinetransactioncategory_AsyncOperations"></a> msdyn_orderlinetransactioncategory_AsyncOperations

See msdyn_orderlinetransactioncategory Entity [msdyn_orderlinetransactioncategory_AsyncOperations](msdyn_orderlinetransactioncategory.md#BKMK_msdyn_orderlinetransactioncategory_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_msdyn_orderlinetransactionclassification_AsyncOperations"></a> msdyn_orderlinetransactionclassification_AsyncOperations

See msdyn_orderlinetransactionclassification Entity [msdyn_orderlinetransactionclassification_AsyncOperations](msdyn_orderlinetransactionclassification.md#BKMK_msdyn_orderlinetransactionclassification_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_msdyn_orderpricelist_AsyncOperations"></a> msdyn_orderpricelist_AsyncOperations

See msdyn_orderpricelist Entity [msdyn_orderpricelist_AsyncOperations](msdyn_orderpricelist.md#BKMK_msdyn_orderpricelist_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_msdyn_processnotes_AsyncOperations"></a> msdyn_processnotes_AsyncOperations

See msdyn_processnotes Entity [msdyn_processnotes_AsyncOperations](msdyn_processnotes.md#BKMK_msdyn_processnotes_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_msdyn_project_AsyncOperations"></a> msdyn_project_AsyncOperations

See msdyn_project Entity [msdyn_project_AsyncOperations](msdyn_project.md#BKMK_msdyn_project_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_msdyn_projectapproval_AsyncOperations"></a> msdyn_projectapproval_AsyncOperations

See msdyn_projectapproval Entity [msdyn_projectapproval_AsyncOperations](msdyn_projectapproval.md#BKMK_msdyn_projectapproval_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_msdyn_projectparameter_AsyncOperations"></a> msdyn_projectparameter_AsyncOperations

See msdyn_projectparameter Entity [msdyn_projectparameter_AsyncOperations](msdyn_projectparameter.md#BKMK_msdyn_projectparameter_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_msdyn_projectparameterpricelist_AsyncOperations"></a> msdyn_projectparameterpricelist_AsyncOperations

See msdyn_projectparameterpricelist Entity [msdyn_projectparameterpricelist_AsyncOperations](msdyn_projectparameterpricelist.md#BKMK_msdyn_projectparameterpricelist_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_msdyn_projectpricelist_AsyncOperations"></a> msdyn_projectpricelist_AsyncOperations

See msdyn_projectpricelist Entity [msdyn_projectpricelist_AsyncOperations](msdyn_projectpricelist.md#BKMK_msdyn_projectpricelist_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_msdyn_projecttask_AsyncOperations"></a> msdyn_projecttask_AsyncOperations

See msdyn_projecttask Entity [msdyn_projecttask_AsyncOperations](msdyn_projecttask.md#BKMK_msdyn_projecttask_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_msdyn_projecttaskdependency_AsyncOperations"></a> msdyn_projecttaskdependency_AsyncOperations

See msdyn_projecttaskdependency Entity [msdyn_projecttaskdependency_AsyncOperations](msdyn_projecttaskdependency.md#BKMK_msdyn_projecttaskdependency_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_msdyn_projecttaskstatususer_AsyncOperations"></a> msdyn_projecttaskstatususer_AsyncOperations

See msdyn_projecttaskstatususer Entity [msdyn_projecttaskstatususer_AsyncOperations](msdyn_projecttaskstatususer.md#BKMK_msdyn_projecttaskstatususer_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_msdyn_projectteam_AsyncOperations"></a> msdyn_projectteam_AsyncOperations

See msdyn_projectteam Entity [msdyn_projectteam_AsyncOperations](msdyn_projectteam.md#BKMK_msdyn_projectteam_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_msdyn_projectteammembersignup_AsyncOperations"></a> msdyn_projectteammembersignup_AsyncOperations

See msdyn_projectteammembersignup Entity [msdyn_projectteammembersignup_AsyncOperations](msdyn_projectteammembersignup.md#BKMK_msdyn_projectteammembersignup_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_msdyn_projecttransactioncategory_AsyncOperations"></a> msdyn_projecttransactioncategory_AsyncOperations

See msdyn_projecttransactioncategory Entity [msdyn_projecttransactioncategory_AsyncOperations](msdyn_projecttransactioncategory.md#BKMK_msdyn_projecttransactioncategory_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_msdyn_quotelineanalyticsbreakdown_AsyncOperations"></a> msdyn_quotelineanalyticsbreakdown_AsyncOperations

See msdyn_quotelineanalyticsbreakdown Entity [msdyn_quotelineanalyticsbreakdown_AsyncOperations](msdyn_quotelineanalyticsbreakdown.md#BKMK_msdyn_quotelineanalyticsbreakdown_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_msdyn_quotelineinvoiceschedule_AsyncOperations"></a> msdyn_quotelineinvoiceschedule_AsyncOperations

See msdyn_quotelineinvoiceschedule Entity [msdyn_quotelineinvoiceschedule_AsyncOperations](msdyn_quotelineinvoiceschedule.md#BKMK_msdyn_quotelineinvoiceschedule_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_msdyn_quotelineresourcecategory_AsyncOperations"></a> msdyn_quotelineresourcecategory_AsyncOperations

See msdyn_quotelineresourcecategory Entity [msdyn_quotelineresourcecategory_AsyncOperations](msdyn_quotelineresourcecategory.md#BKMK_msdyn_quotelineresourcecategory_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_msdyn_quotelinescheduleofvalue_AsyncOperations"></a> msdyn_quotelinescheduleofvalue_AsyncOperations

See msdyn_quotelinescheduleofvalue Entity [msdyn_quotelinescheduleofvalue_AsyncOperations](msdyn_quotelinescheduleofvalue.md#BKMK_msdyn_quotelinescheduleofvalue_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_msdyn_quotelinetransaction_AsyncOperations"></a> msdyn_quotelinetransaction_AsyncOperations

See msdyn_quotelinetransaction Entity [msdyn_quotelinetransaction_AsyncOperations](msdyn_quotelinetransaction.md#BKMK_msdyn_quotelinetransaction_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_msdyn_quotelinetransactioncategory_AsyncOperations"></a> msdyn_quotelinetransactioncategory_AsyncOperations

See msdyn_quotelinetransactioncategory Entity [msdyn_quotelinetransactioncategory_AsyncOperations](msdyn_quotelinetransactioncategory.md#BKMK_msdyn_quotelinetransactioncategory_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_msdyn_quotelinetransactionclassification_AsyncOperations"></a> msdyn_quotelinetransactionclassification_AsyncOperations

See msdyn_quotelinetransactionclassification Entity [msdyn_quotelinetransactionclassification_AsyncOperations](msdyn_quotelinetransactionclassification.md#BKMK_msdyn_quotelinetransactionclassification_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_msdyn_quotepricelist_AsyncOperations"></a> msdyn_quotepricelist_AsyncOperations

See msdyn_quotepricelist Entity [msdyn_quotepricelist_AsyncOperations](msdyn_quotepricelist.md#BKMK_msdyn_quotepricelist_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_msdyn_resourceassignment_AsyncOperations"></a> msdyn_resourceassignment_AsyncOperations

See msdyn_resourceassignment Entity [msdyn_resourceassignment_AsyncOperations](msdyn_resourceassignment.md#BKMK_msdyn_resourceassignment_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_msdyn_resourceassignmentdetail_AsyncOperations"></a> msdyn_resourceassignmentdetail_AsyncOperations

See msdyn_resourceassignmentdetail Entity [msdyn_resourceassignmentdetail_AsyncOperations](msdyn_resourceassignmentdetail.md#BKMK_msdyn_resourceassignmentdetail_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_msdyn_resourcecategorypricelevel_AsyncOperations"></a> msdyn_resourcecategorypricelevel_AsyncOperations

See msdyn_resourcecategorypricelevel Entity [msdyn_resourcecategorypricelevel_AsyncOperations](msdyn_resourcecategorypricelevel.md#BKMK_msdyn_resourcecategorypricelevel_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_msdyn_resourcerequest_AsyncOperations"></a> msdyn_resourcerequest_AsyncOperations

See msdyn_resourcerequest Entity [msdyn_resourcerequest_AsyncOperations](msdyn_resourcerequest.md#BKMK_msdyn_resourcerequest_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_msdyn_rolecompetencyrequirement_AsyncOperations"></a> msdyn_rolecompetencyrequirement_AsyncOperations

See msdyn_rolecompetencyrequirement Entity [msdyn_rolecompetencyrequirement_AsyncOperations](msdyn_rolecompetencyrequirement.md#BKMK_msdyn_rolecompetencyrequirement_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_msdyn_roleutilization_AsyncOperations"></a> msdyn_roleutilization_AsyncOperations

See msdyn_roleutilization Entity [msdyn_roleutilization_AsyncOperations](msdyn_roleutilization.md#BKMK_msdyn_roleutilization_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_msdyn_timeentry_AsyncOperations"></a> msdyn_timeentry_AsyncOperations

See msdyn_timeentry Entity [msdyn_timeentry_AsyncOperations](msdyn_timeentry.md#BKMK_msdyn_timeentry_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_msdyn_timeoffcalendar_AsyncOperations"></a> msdyn_timeoffcalendar_AsyncOperations

See msdyn_timeoffcalendar Entity [msdyn_timeoffcalendar_AsyncOperations](msdyn_timeoffcalendar.md#BKMK_msdyn_timeoffcalendar_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_msdyn_transactioncategory_AsyncOperations"></a> msdyn_transactioncategory_AsyncOperations

See msdyn_transactioncategory Entity [msdyn_transactioncategory_AsyncOperations](msdyn_transactioncategory.md#BKMK_msdyn_transactioncategory_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_msdyn_transactioncategoryclassification_AsyncOperations"></a> msdyn_transactioncategoryclassification_AsyncOperations

See msdyn_transactioncategoryclassification Entity [msdyn_transactioncategoryclassification_AsyncOperations](msdyn_transactioncategoryclassification.md#BKMK_msdyn_transactioncategoryclassification_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_msdyn_transactioncategoryhierarchyelement_AsyncOperations"></a> msdyn_transactioncategoryhierarchyelement_AsyncOperations

See msdyn_transactioncategoryhierarchyelement Entity [msdyn_transactioncategoryhierarchyelement_AsyncOperations](msdyn_transactioncategoryhierarchyelement.md#BKMK_msdyn_transactioncategoryhierarchyelement_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_msdyn_transactioncategorypricelevel_AsyncOperations"></a> msdyn_transactioncategorypricelevel_AsyncOperations

See msdyn_transactioncategorypricelevel Entity [msdyn_transactioncategorypricelevel_AsyncOperations](msdyn_transactioncategorypricelevel.md#BKMK_msdyn_transactioncategorypricelevel_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_msdyn_transactionconnection_AsyncOperations"></a> msdyn_transactionconnection_AsyncOperations

See msdyn_transactionconnection Entity [msdyn_transactionconnection_AsyncOperations](msdyn_transactionconnection.md#BKMK_msdyn_transactionconnection_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_msdyn_transactiontype_AsyncOperations"></a> msdyn_transactiontype_AsyncOperations

See msdyn_transactiontype Entity [msdyn_transactiontype_AsyncOperations](msdyn_transactiontype.md#BKMK_msdyn_transactiontype_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_msdyn_userworkhistory_AsyncOperations"></a> msdyn_userworkhistory_AsyncOperations

See msdyn_userworkhistory Entity [msdyn_userworkhistory_AsyncOperations](msdyn_userworkhistory.md#BKMK_msdyn_userworkhistory_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_msdyn_agreement_AsyncOperations"></a> msdyn_agreement_AsyncOperations

See msdyn_agreement Entity [msdyn_agreement_AsyncOperations](msdyn_agreement.md#BKMK_msdyn_agreement_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_msdyn_agreementbookingdate_AsyncOperations"></a> msdyn_agreementbookingdate_AsyncOperations

See msdyn_agreementbookingdate Entity [msdyn_agreementbookingdate_AsyncOperations](msdyn_agreementbookingdate.md#BKMK_msdyn_agreementbookingdate_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_msdyn_agreementbookingincident_AsyncOperations"></a> msdyn_agreementbookingincident_AsyncOperations

See msdyn_agreementbookingincident Entity [msdyn_agreementbookingincident_AsyncOperations](msdyn_agreementbookingincident.md#BKMK_msdyn_agreementbookingincident_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_msdyn_agreementbookingproduct_AsyncOperations"></a> msdyn_agreementbookingproduct_AsyncOperations

See msdyn_agreementbookingproduct Entity [msdyn_agreementbookingproduct_AsyncOperations](msdyn_agreementbookingproduct.md#BKMK_msdyn_agreementbookingproduct_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_msdyn_agreementbookingservice_AsyncOperations"></a> msdyn_agreementbookingservice_AsyncOperations

See msdyn_agreementbookingservice Entity [msdyn_agreementbookingservice_AsyncOperations](msdyn_agreementbookingservice.md#BKMK_msdyn_agreementbookingservice_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_msdyn_agreementbookingservicetask_AsyncOperations"></a> msdyn_agreementbookingservicetask_AsyncOperations

See msdyn_agreementbookingservicetask Entity [msdyn_agreementbookingservicetask_AsyncOperations](msdyn_agreementbookingservicetask.md#BKMK_msdyn_agreementbookingservicetask_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_msdyn_agreementbookingsetup_AsyncOperations"></a> msdyn_agreementbookingsetup_AsyncOperations

See msdyn_agreementbookingsetup Entity [msdyn_agreementbookingsetup_AsyncOperations](msdyn_agreementbookingsetup.md#BKMK_msdyn_agreementbookingsetup_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_msdyn_agreementinvoicedate_AsyncOperations"></a> msdyn_agreementinvoicedate_AsyncOperations

See msdyn_agreementinvoicedate Entity [msdyn_agreementinvoicedate_AsyncOperations](msdyn_agreementinvoicedate.md#BKMK_msdyn_agreementinvoicedate_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_msdyn_agreementinvoiceproduct_AsyncOperations"></a> msdyn_agreementinvoiceproduct_AsyncOperations

See msdyn_agreementinvoiceproduct Entity [msdyn_agreementinvoiceproduct_AsyncOperations](msdyn_agreementinvoiceproduct.md#BKMK_msdyn_agreementinvoiceproduct_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_msdyn_agreementinvoicesetup_AsyncOperations"></a> msdyn_agreementinvoicesetup_AsyncOperations

See msdyn_agreementinvoicesetup Entity [msdyn_agreementinvoicesetup_AsyncOperations](msdyn_agreementinvoicesetup.md#BKMK_msdyn_agreementinvoicesetup_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_msdyn_agreementsubstatus_AsyncOperations"></a> msdyn_agreementsubstatus_AsyncOperations

See msdyn_agreementsubstatus Entity [msdyn_agreementsubstatus_AsyncOperations](msdyn_agreementsubstatus.md#BKMK_msdyn_agreementsubstatus_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_msdyn_bookingjournal_AsyncOperations"></a> msdyn_bookingjournal_AsyncOperations

See msdyn_bookingjournal Entity [msdyn_bookingjournal_AsyncOperations](msdyn_bookingjournal.md#BKMK_msdyn_bookingjournal_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_msdyn_bookingtimestamp_AsyncOperations"></a> msdyn_bookingtimestamp_AsyncOperations

See msdyn_bookingtimestamp Entity [msdyn_bookingtimestamp_AsyncOperations](msdyn_bookingtimestamp.md#BKMK_msdyn_bookingtimestamp_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_msdyn_bpf_2c5fe86acc8b414b8322ae571000c799_AsyncOperations"></a> msdyn_bpf_2c5fe86acc8b414b8322ae571000c799_AsyncOperations

See msdyn_bpf_2c5fe86acc8b414b8322ae571000c799 Entity [msdyn_bpf_2c5fe86acc8b414b8322ae571000c799_AsyncOperations](msdyn_bpf_2c5fe86acc8b414b8322ae571000c799.md#BKMK_msdyn_bpf_2c5fe86acc8b414b8322ae571000c799_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_msdyn_bpf_989e9b1857e24af18787d5143b67523b_AsyncOperations"></a> msdyn_bpf_989e9b1857e24af18787d5143b67523b_AsyncOperations

See msdyn_bpf_989e9b1857e24af18787d5143b67523b Entity [msdyn_bpf_989e9b1857e24af18787d5143b67523b_AsyncOperations](msdyn_bpf_989e9b1857e24af18787d5143b67523b.md#BKMK_msdyn_bpf_989e9b1857e24af18787d5143b67523b_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_msdyn_bpf_baa0a411a239410cb8bded8b5fdd88e3_AsyncOperations"></a> msdyn_bpf_baa0a411a239410cb8bded8b5fdd88e3_AsyncOperations

See msdyn_bpf_baa0a411a239410cb8bded8b5fdd88e3 Entity [msdyn_bpf_baa0a411a239410cb8bded8b5fdd88e3_AsyncOperations](msdyn_bpf_baa0a411a239410cb8bded8b5fdd88e3.md#BKMK_msdyn_bpf_baa0a411a239410cb8bded8b5fdd88e3_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_msdyn_bpf_d3d97bac8c294105840e99e37a9d1c39_AsyncOperations"></a> msdyn_bpf_d3d97bac8c294105840e99e37a9d1c39_AsyncOperations

See msdyn_bpf_d3d97bac8c294105840e99e37a9d1c39 Entity [msdyn_bpf_d3d97bac8c294105840e99e37a9d1c39_AsyncOperations](msdyn_bpf_d3d97bac8c294105840e99e37a9d1c39.md#BKMK_msdyn_bpf_d3d97bac8c294105840e99e37a9d1c39_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_msdyn_customerasset_AsyncOperations"></a> msdyn_customerasset_AsyncOperations

See msdyn_customerasset Entity [msdyn_customerasset_AsyncOperations](msdyn_customerasset.md#BKMK_msdyn_customerasset_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_msdyn_fieldservicepricelistitem_AsyncOperations"></a> msdyn_fieldservicepricelistitem_AsyncOperations

See msdyn_fieldservicepricelistitem Entity [msdyn_fieldservicepricelistitem_AsyncOperations](msdyn_fieldservicepricelistitem.md#BKMK_msdyn_fieldservicepricelistitem_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_msdyn_fieldservicesetting_AsyncOperations"></a> msdyn_fieldservicesetting_AsyncOperations

See msdyn_fieldservicesetting Entity [msdyn_fieldservicesetting_AsyncOperations](msdyn_fieldservicesetting.md#BKMK_msdyn_fieldservicesetting_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_msdyn_fieldservicesystemjob_AsyncOperations"></a> msdyn_fieldservicesystemjob_AsyncOperations

See msdyn_fieldservicesystemjob Entity [msdyn_fieldservicesystemjob_AsyncOperations](msdyn_fieldservicesystemjob.md#BKMK_msdyn_fieldservicesystemjob_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_msdyn_incidenttype_AsyncOperations"></a> msdyn_incidenttype_AsyncOperations

See msdyn_incidenttype Entity [msdyn_incidenttype_AsyncOperations](msdyn_incidenttype.md#BKMK_msdyn_incidenttype_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_msdyn_incidenttypecharacteristic_AsyncOperations"></a> msdyn_incidenttypecharacteristic_AsyncOperations

See msdyn_incidenttypecharacteristic Entity [msdyn_incidenttypecharacteristic_AsyncOperations](msdyn_incidenttypecharacteristic.md#BKMK_msdyn_incidenttypecharacteristic_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_msdyn_incidenttypeproduct_AsyncOperations"></a> msdyn_incidenttypeproduct_AsyncOperations

See msdyn_incidenttypeproduct Entity [msdyn_incidenttypeproduct_AsyncOperations](msdyn_incidenttypeproduct.md#BKMK_msdyn_incidenttypeproduct_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_msdyn_incidenttypeservice_AsyncOperations"></a> msdyn_incidenttypeservice_AsyncOperations

See msdyn_incidenttypeservice Entity [msdyn_incidenttypeservice_AsyncOperations](msdyn_incidenttypeservice.md#BKMK_msdyn_incidenttypeservice_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_msdyn_incidenttypeservicetask_AsyncOperations"></a> msdyn_incidenttypeservicetask_AsyncOperations

See msdyn_incidenttypeservicetask Entity [msdyn_incidenttypeservicetask_AsyncOperations](msdyn_incidenttypeservicetask.md#BKMK_msdyn_incidenttypeservicetask_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_msdyn_inventoryadjustment_AsyncOperations"></a> msdyn_inventoryadjustment_AsyncOperations

See msdyn_inventoryadjustment Entity [msdyn_inventoryadjustment_AsyncOperations](msdyn_inventoryadjustment.md#BKMK_msdyn_inventoryadjustment_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_msdyn_inventoryadjustmentproduct_AsyncOperations"></a> msdyn_inventoryadjustmentproduct_AsyncOperations

See msdyn_inventoryadjustmentproduct Entity [msdyn_inventoryadjustmentproduct_AsyncOperations](msdyn_inventoryadjustmentproduct.md#BKMK_msdyn_inventoryadjustmentproduct_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_msdyn_inventoryjournal_AsyncOperations"></a> msdyn_inventoryjournal_AsyncOperations

See msdyn_inventoryjournal Entity [msdyn_inventoryjournal_AsyncOperations](msdyn_inventoryjournal.md#BKMK_msdyn_inventoryjournal_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_msdyn_inventorytransfer_AsyncOperations"></a> msdyn_inventorytransfer_AsyncOperations

See msdyn_inventorytransfer Entity [msdyn_inventorytransfer_AsyncOperations](msdyn_inventorytransfer.md#BKMK_msdyn_inventorytransfer_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_msdyn_orderinvoicingdate_AsyncOperations"></a> msdyn_orderinvoicingdate_AsyncOperations

See msdyn_orderinvoicingdate Entity [msdyn_orderinvoicingdate_AsyncOperations](msdyn_orderinvoicingdate.md#BKMK_msdyn_orderinvoicingdate_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_msdyn_orderinvoicingproduct_AsyncOperations"></a> msdyn_orderinvoicingproduct_AsyncOperations

See msdyn_orderinvoicingproduct Entity [msdyn_orderinvoicingproduct_AsyncOperations](msdyn_orderinvoicingproduct.md#BKMK_msdyn_orderinvoicingproduct_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_msdyn_orderinvoicingsetup_AsyncOperations"></a> msdyn_orderinvoicingsetup_AsyncOperations

See msdyn_orderinvoicingsetup Entity [msdyn_orderinvoicingsetup_AsyncOperations](msdyn_orderinvoicingsetup.md#BKMK_msdyn_orderinvoicingsetup_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_msdyn_orderinvoicingsetupdate_AsyncOperations"></a> msdyn_orderinvoicingsetupdate_AsyncOperations

See msdyn_orderinvoicingsetupdate Entity [msdyn_orderinvoicingsetupdate_AsyncOperations](msdyn_orderinvoicingsetupdate.md#BKMK_msdyn_orderinvoicingsetupdate_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_msdyn_payment_AsyncOperations"></a> msdyn_payment_AsyncOperations

See msdyn_payment Entity [msdyn_payment_AsyncOperations](msdyn_payment.md#BKMK_msdyn_payment_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_msdyn_paymentdetail_AsyncOperations"></a> msdyn_paymentdetail_AsyncOperations

See msdyn_paymentdetail Entity [msdyn_paymentdetail_AsyncOperations](msdyn_paymentdetail.md#BKMK_msdyn_paymentdetail_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_msdyn_paymentmethod_AsyncOperations"></a> msdyn_paymentmethod_AsyncOperations

See msdyn_paymentmethod Entity [msdyn_paymentmethod_AsyncOperations](msdyn_paymentmethod.md#BKMK_msdyn_paymentmethod_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_msdyn_paymentterm_AsyncOperations"></a> msdyn_paymentterm_AsyncOperations

See msdyn_paymentterm Entity [msdyn_paymentterm_AsyncOperations](msdyn_paymentterm.md#BKMK_msdyn_paymentterm_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_msdyn_postalcode_AsyncOperations"></a> msdyn_postalcode_AsyncOperations

See msdyn_postalcode Entity [msdyn_postalcode_AsyncOperations](msdyn_postalcode.md#BKMK_msdyn_postalcode_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_msdyn_productinventory_AsyncOperations"></a> msdyn_productinventory_AsyncOperations

See msdyn_productinventory Entity [msdyn_productinventory_AsyncOperations](msdyn_productinventory.md#BKMK_msdyn_productinventory_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_msdyn_purchaseorder_AsyncOperations"></a> msdyn_purchaseorder_AsyncOperations

See msdyn_purchaseorder Entity [msdyn_purchaseorder_AsyncOperations](msdyn_purchaseorder.md#BKMK_msdyn_purchaseorder_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_msdyn_purchaseorderbill_AsyncOperations"></a> msdyn_purchaseorderbill_AsyncOperations

See msdyn_purchaseorderbill Entity [msdyn_purchaseorderbill_AsyncOperations](msdyn_purchaseorderbill.md#BKMK_msdyn_purchaseorderbill_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_msdyn_purchaseorderproduct_AsyncOperations"></a> msdyn_purchaseorderproduct_AsyncOperations

See msdyn_purchaseorderproduct Entity [msdyn_purchaseorderproduct_AsyncOperations](msdyn_purchaseorderproduct.md#BKMK_msdyn_purchaseorderproduct_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_msdyn_purchaseorderreceipt_AsyncOperations"></a> msdyn_purchaseorderreceipt_AsyncOperations

See msdyn_purchaseorderreceipt Entity [msdyn_purchaseorderreceipt_AsyncOperations](msdyn_purchaseorderreceipt.md#BKMK_msdyn_purchaseorderreceipt_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_msdyn_purchaseorderreceiptproduct_AsyncOperations"></a> msdyn_purchaseorderreceiptproduct_AsyncOperations

See msdyn_purchaseorderreceiptproduct Entity [msdyn_purchaseorderreceiptproduct_AsyncOperations](msdyn_purchaseorderreceiptproduct.md#BKMK_msdyn_purchaseorderreceiptproduct_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_msdyn_purchaseordersubstatus_AsyncOperations"></a> msdyn_purchaseordersubstatus_AsyncOperations

See msdyn_purchaseordersubstatus Entity [msdyn_purchaseordersubstatus_AsyncOperations](msdyn_purchaseordersubstatus.md#BKMK_msdyn_purchaseordersubstatus_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_msdyn_quotebookingincident_AsyncOperations"></a> msdyn_quotebookingincident_AsyncOperations

See msdyn_quotebookingincident Entity [msdyn_quotebookingincident_AsyncOperations](msdyn_quotebookingincident.md#BKMK_msdyn_quotebookingincident_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_msdyn_quotebookingproduct_AsyncOperations"></a> msdyn_quotebookingproduct_AsyncOperations

See msdyn_quotebookingproduct Entity [msdyn_quotebookingproduct_AsyncOperations](msdyn_quotebookingproduct.md#BKMK_msdyn_quotebookingproduct_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_msdyn_quotebookingservice_AsyncOperations"></a> msdyn_quotebookingservice_AsyncOperations

See msdyn_quotebookingservice Entity [msdyn_quotebookingservice_AsyncOperations](msdyn_quotebookingservice.md#BKMK_msdyn_quotebookingservice_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_msdyn_quotebookingservicetask_AsyncOperations"></a> msdyn_quotebookingservicetask_AsyncOperations

See msdyn_quotebookingservicetask Entity [msdyn_quotebookingservicetask_AsyncOperations](msdyn_quotebookingservicetask.md#BKMK_msdyn_quotebookingservicetask_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_msdyn_quotebookingsetup_AsyncOperations"></a> msdyn_quotebookingsetup_AsyncOperations

See msdyn_quotebookingsetup Entity [msdyn_quotebookingsetup_AsyncOperations](msdyn_quotebookingsetup.md#BKMK_msdyn_quotebookingsetup_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_msdyn_quoteinvoicingproduct_AsyncOperations"></a> msdyn_quoteinvoicingproduct_AsyncOperations

See msdyn_quoteinvoicingproduct Entity [msdyn_quoteinvoicingproduct_AsyncOperations](msdyn_quoteinvoicingproduct.md#BKMK_msdyn_quoteinvoicingproduct_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_msdyn_quoteinvoicingsetup_AsyncOperations"></a> msdyn_quoteinvoicingsetup_AsyncOperations

See msdyn_quoteinvoicingsetup Entity [msdyn_quoteinvoicingsetup_AsyncOperations](msdyn_quoteinvoicingsetup.md#BKMK_msdyn_quoteinvoicingsetup_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_msdyn_resourcepaytype_AsyncOperations"></a> msdyn_resourcepaytype_AsyncOperations

See msdyn_resourcepaytype Entity [msdyn_resourcepaytype_AsyncOperations](msdyn_resourcepaytype.md#BKMK_msdyn_resourcepaytype_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_msdyn_rma_AsyncOperations"></a> msdyn_rma_AsyncOperations

See msdyn_rma Entity [msdyn_rma_AsyncOperations](msdyn_rma.md#BKMK_msdyn_rma_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_msdyn_rmaproduct_AsyncOperations"></a> msdyn_rmaproduct_AsyncOperations

See msdyn_rmaproduct Entity [msdyn_rmaproduct_AsyncOperations](msdyn_rmaproduct.md#BKMK_msdyn_rmaproduct_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_msdyn_rmareceipt_AsyncOperations"></a> msdyn_rmareceipt_AsyncOperations

See msdyn_rmareceipt Entity [msdyn_rmareceipt_AsyncOperations](msdyn_rmareceipt.md#BKMK_msdyn_rmareceipt_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_msdyn_rmareceiptproduct_AsyncOperations"></a> msdyn_rmareceiptproduct_AsyncOperations

See msdyn_rmareceiptproduct Entity [msdyn_rmareceiptproduct_AsyncOperations](msdyn_rmareceiptproduct.md#BKMK_msdyn_rmareceiptproduct_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_msdyn_rmasubstatus_AsyncOperations"></a> msdyn_rmasubstatus_AsyncOperations

See msdyn_rmasubstatus Entity [msdyn_rmasubstatus_AsyncOperations](msdyn_rmasubstatus.md#BKMK_msdyn_rmasubstatus_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_msdyn_rtv_AsyncOperations"></a> msdyn_rtv_AsyncOperations

See msdyn_rtv Entity [msdyn_rtv_AsyncOperations](msdyn_rtv.md#BKMK_msdyn_rtv_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_msdyn_rtvproduct_AsyncOperations"></a> msdyn_rtvproduct_AsyncOperations

See msdyn_rtvproduct Entity [msdyn_rtvproduct_AsyncOperations](msdyn_rtvproduct.md#BKMK_msdyn_rtvproduct_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_msdyn_rtvsubstatus_AsyncOperations"></a> msdyn_rtvsubstatus_AsyncOperations

See msdyn_rtvsubstatus Entity [msdyn_rtvsubstatus_AsyncOperations](msdyn_rtvsubstatus.md#BKMK_msdyn_rtvsubstatus_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_msdyn_servicetasktype_AsyncOperations"></a> msdyn_servicetasktype_AsyncOperations

See msdyn_servicetasktype Entity [msdyn_servicetasktype_AsyncOperations](msdyn_servicetasktype.md#BKMK_msdyn_servicetasktype_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_msdyn_shipvia_AsyncOperations"></a> msdyn_shipvia_AsyncOperations

See msdyn_shipvia Entity [msdyn_shipvia_AsyncOperations](msdyn_shipvia.md#BKMK_msdyn_shipvia_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_msdyn_taxcode_AsyncOperations"></a> msdyn_taxcode_AsyncOperations

See msdyn_taxcode Entity [msdyn_taxcode_AsyncOperations](msdyn_taxcode.md#BKMK_msdyn_taxcode_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_msdyn_taxcodedetail_AsyncOperations"></a> msdyn_taxcodedetail_AsyncOperations

See msdyn_taxcodedetail Entity [msdyn_taxcodedetail_AsyncOperations](msdyn_taxcodedetail.md#BKMK_msdyn_taxcodedetail_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_msdyn_timeoffrequest_AsyncOperations"></a> msdyn_timeoffrequest_AsyncOperations

See msdyn_timeoffrequest Entity [msdyn_timeoffrequest_AsyncOperations](msdyn_timeoffrequest.md#BKMK_msdyn_timeoffrequest_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_msdyn_uniquenumber_AsyncOperations"></a> msdyn_uniquenumber_AsyncOperations

See msdyn_uniquenumber Entity [msdyn_uniquenumber_AsyncOperations](msdyn_uniquenumber.md#BKMK_msdyn_uniquenumber_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_msdyn_warehouse_AsyncOperations"></a> msdyn_warehouse_AsyncOperations

See msdyn_warehouse Entity [msdyn_warehouse_AsyncOperations](msdyn_warehouse.md#BKMK_msdyn_warehouse_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_msdyn_workorder_AsyncOperations"></a> msdyn_workorder_AsyncOperations

See msdyn_workorder Entity [msdyn_workorder_AsyncOperations](msdyn_workorder.md#BKMK_msdyn_workorder_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_msdyn_workordercharacteristic_AsyncOperations"></a> msdyn_workordercharacteristic_AsyncOperations

See msdyn_workordercharacteristic Entity [msdyn_workordercharacteristic_AsyncOperations](msdyn_workordercharacteristic.md#BKMK_msdyn_workordercharacteristic_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_msdyn_workorderdetailsgenerationqueue_AsyncOperations"></a> msdyn_workorderdetailsgenerationqueue_AsyncOperations

See msdyn_workorderdetailsgenerationqueue Entity [msdyn_workorderdetailsgenerationqueue_AsyncOperations](msdyn_workorderdetailsgenerationqueue.md#BKMK_msdyn_workorderdetailsgenerationqueue_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_msdyn_workorderincident_AsyncOperations"></a> msdyn_workorderincident_AsyncOperations

See msdyn_workorderincident Entity [msdyn_workorderincident_AsyncOperations](msdyn_workorderincident.md#BKMK_msdyn_workorderincident_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_msdyn_workorderproduct_AsyncOperations"></a> msdyn_workorderproduct_AsyncOperations

See msdyn_workorderproduct Entity [msdyn_workorderproduct_AsyncOperations](msdyn_workorderproduct.md#BKMK_msdyn_workorderproduct_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_msdyn_workorderresourcerestriction_AsyncOperations"></a> msdyn_workorderresourcerestriction_AsyncOperations

See msdyn_workorderresourcerestriction Entity [msdyn_workorderresourcerestriction_AsyncOperations](msdyn_workorderresourcerestriction.md#BKMK_msdyn_workorderresourcerestriction_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_msdyn_workorderservice_AsyncOperations"></a> msdyn_workorderservice_AsyncOperations

See msdyn_workorderservice Entity [msdyn_workorderservice_AsyncOperations](msdyn_workorderservice.md#BKMK_msdyn_workorderservice_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_msdyn_workorderservicetask_AsyncOperations"></a> msdyn_workorderservicetask_AsyncOperations

See msdyn_workorderservicetask Entity [msdyn_workorderservicetask_AsyncOperations](msdyn_workorderservicetask.md#BKMK_msdyn_workorderservicetask_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_msdyn_workordersubstatus_AsyncOperations"></a> msdyn_workordersubstatus_AsyncOperations

See msdyn_workordersubstatus Entity [msdyn_workordersubstatus_AsyncOperations](msdyn_workordersubstatus.md#BKMK_msdyn_workordersubstatus_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_msdyn_workordertype_AsyncOperations"></a> msdyn_workordertype_AsyncOperations

See msdyn_workordertype Entity [msdyn_workordertype_AsyncOperations](msdyn_workordertype.md#BKMK_msdyn_workordertype_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_theme_AsyncOperations"></a> theme_AsyncOperations

See theme Entity [theme_AsyncOperations](theme.md#BKMK_theme_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_usermapping_AsyncOperations"></a> usermapping_AsyncOperations

See usermapping Entity [usermapping_AsyncOperations](usermapping.md#BKMK_usermapping_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_interactionforemail_AsyncOperations"></a> interactionforemail_AsyncOperations

See interactionforemail Entity [interactionforemail_AsyncOperations](interactionforemail.md#BKMK_interactionforemail_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_knowledgearticle_AsyncOperations"></a> knowledgearticle_AsyncOperations

See knowledgearticle Entity [knowledgearticle_AsyncOperations](knowledgearticle.md#BKMK_knowledgearticle_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_post_AsyncOperations"></a> post_AsyncOperations

See post Entity [post_AsyncOperations](post.md#BKMK_post_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_position_AsyncOperations"></a> position_AsyncOperations

See position Entity [position_AsyncOperations](position.md#BKMK_position_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_channelaccessprofile_AsyncOperations"></a> channelaccessprofile_AsyncOperations

See channelaccessprofile Entity [channelaccessprofile_AsyncOperations](channelaccessprofile.md#BKMK_channelaccessprofile_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_externalparty_AsyncOperations"></a> externalparty_AsyncOperations

See externalparty Entity [externalparty_AsyncOperations](externalparty.md#BKMK_externalparty_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_profilerule_AsyncOperations"></a> profilerule_AsyncOperations

See channelaccessprofilerule Entity [profilerule_AsyncOperations](channelaccessprofilerule.md#BKMK_profilerule_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_KnowledgeBaseRecord_AsyncOperations"></a> KnowledgeBaseRecord_AsyncOperations

See knowledgebaserecord Entity [KnowledgeBaseRecord_AsyncOperations](knowledgebaserecord.md#BKMK_KnowledgeBaseRecord_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_lk_asyncoperation_createdby"></a> lk_asyncoperation_createdby

See systemuser Entity [lk_asyncoperation_createdby](systemuser.md#BKMK_lk_asyncoperation_createdby) One-To-Many relationship.

### <a name="BKMK_MonthlyFiscalCalendar_AsyncOperations"></a> MonthlyFiscalCalendar_AsyncOperations

See monthlyfiscalcalendar Entity [MonthlyFiscalCalendar_AsyncOperations](monthlyfiscalcalendar.md#BKMK_MonthlyFiscalCalendar_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_lk_asyncoperation_workflowactivationid"></a> lk_asyncoperation_workflowactivationid

See workflow Entity [lk_asyncoperation_workflowactivationid](workflow.md#BKMK_lk_asyncoperation_workflowactivationid) One-To-Many relationship.

### <a name="BKMK_Report_AsyncOperations"></a> Report_AsyncOperations

See report Entity [Report_AsyncOperations](report.md#BKMK_Report_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_SocialActivity_AsyncOperations"></a> SocialActivity_AsyncOperations

See socialactivity Entity [SocialActivity_AsyncOperations](socialactivity.md#BKMK_SocialActivity_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_Connection_Role_AsyncOperations"></a> Connection_Role_AsyncOperations

See connectionrole Entity [Connection_Role_AsyncOperations](connectionrole.md#BKMK_Connection_Role_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_routingruleitem_AsyncOperations"></a> routingruleitem_AsyncOperations

See routingruleitem Entity [routingruleitem_AsyncOperations](routingruleitem.md#BKMK_routingruleitem_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_Team_AsyncOperations"></a> Team_AsyncOperations

See team Entity [Team_AsyncOperations](team.md#BKMK_Team_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_AnnualFiscalCalendar_AsyncOperations"></a> AnnualFiscalCalendar_AsyncOperations

See annualfiscalcalendar Entity [AnnualFiscalCalendar_AsyncOperations](annualfiscalcalendar.md#BKMK_AnnualFiscalCalendar_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_SharePointDocumentLocation_AsyncOperations"></a> SharePointDocumentLocation_AsyncOperations

See sharepointdocumentlocation Entity [SharePointDocumentLocation_AsyncOperations](sharepointdocumentlocation.md#BKMK_SharePointDocumentLocation_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_PhoneCall_AsyncOperations"></a> PhoneCall_AsyncOperations

See phonecall Entity [PhoneCall_AsyncOperations](phonecall.md#BKMK_PhoneCall_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_Convertrule_AsyncOperations"></a> Convertrule_AsyncOperations

See convertrule Entity [Convertrule_AsyncOperations](convertrule.md#BKMK_Convertrule_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_mailbox_asyncoperations"></a> mailbox_asyncoperations

See mailbox Entity [mailbox_asyncoperations](mailbox.md#BKMK_mailbox_asyncoperations) One-To-Many relationship.

### <a name="BKMK_PostFollow_AsyncOperations"></a> PostFollow_AsyncOperations

See postfollow Entity [PostFollow_AsyncOperations](postfollow.md#BKMK_PostFollow_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_Appointment_AsyncOperations"></a> Appointment_AsyncOperations

See appointment Entity [Appointment_AsyncOperations](appointment.md#BKMK_Appointment_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_slabase_AsyncOperations"></a> slabase_AsyncOperations

See sla Entity [slabase_AsyncOperations](sla.md#BKMK_slabase_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_SavedQuery_AsyncOperations"></a> SavedQuery_AsyncOperations

See savedquery Entity [SavedQuery_AsyncOperations](savedquery.md#BKMK_SavedQuery_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_DisplayString_AsyncOperations"></a> DisplayString_AsyncOperations

See displaystring Entity [DisplayString_AsyncOperations](displaystring.md#BKMK_DisplayString_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_KbArticleComment_AsyncOperations"></a> KbArticleComment_AsyncOperations

See kbarticlecomment Entity [KbArticleComment_AsyncOperations](kbarticlecomment.md#BKMK_KbArticleComment_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_ActivityPointer_AsyncOperations"></a> ActivityPointer_AsyncOperations

See activitypointer Entity [ActivityPointer_AsyncOperations](activitypointer.md#BKMK_ActivityPointer_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_Subject_AsyncOperations"></a> Subject_AsyncOperations

See subject Entity [Subject_AsyncOperations](subject.md#BKMK_Subject_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_goalrollupquery_AsyncOperations"></a> goalrollupquery_AsyncOperations

See goalrollupquery Entity [goalrollupquery_AsyncOperations](goalrollupquery.md#BKMK_goalrollupquery_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_routingrule_AsyncOperations"></a> routingrule_AsyncOperations

See routingrule Entity [routingrule_AsyncOperations](routingrule.md#BKMK_routingrule_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_Role_AsyncOperations"></a> Role_AsyncOperations

See role Entity [Role_AsyncOperations](role.md#BKMK_Role_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_SystemForm_AsyncOperations"></a> SystemForm_AsyncOperations

See systemform Entity [SystemForm_AsyncOperations](systemform.md#BKMK_SystemForm_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_Annotation_AsyncOperations"></a> Annotation_AsyncOperations

See annotation Entity [Annotation_AsyncOperations](annotation.md#BKMK_Annotation_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_Privilege_AsyncOperations"></a> Privilege_AsyncOperations

See privilege Entity [Privilege_AsyncOperations](privilege.md#BKMK_Privilege_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_ActivityMimeAttachment_AsyncOperations"></a> ActivityMimeAttachment_AsyncOperations

See activitymimeattachment Entity [ActivityMimeAttachment_AsyncOperations](activitymimeattachment.md#BKMK_ActivityMimeAttachment_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_Goal_AsyncOperations"></a> Goal_AsyncOperations

See goal Entity [Goal_AsyncOperations](goal.md#BKMK_Goal_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_Fax_AsyncOperations"></a> Fax_AsyncOperations

See fax Entity [Fax_AsyncOperations](fax.md#BKMK_Fax_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_QuarterlyFiscalCalendar_AsyncOperations"></a> QuarterlyFiscalCalendar_AsyncOperations

See quarterlyfiscalcalendar Entity [QuarterlyFiscalCalendar_AsyncOperations](quarterlyfiscalcalendar.md#BKMK_QuarterlyFiscalCalendar_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_SharePointSite_AsyncOperations"></a> SharePointSite_AsyncOperations

See sharepointsite Entity [SharePointSite_AsyncOperations](sharepointsite.md#BKMK_SharePointSite_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_UserQuery_AsyncOperations"></a> UserQuery_AsyncOperations

See userquery Entity [UserQuery_AsyncOperations](userquery.md#BKMK_UserQuery_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_ImportMap_AsyncOperations"></a> ImportMap_AsyncOperations

See importmap Entity [ImportMap_AsyncOperations](importmap.md#BKMK_ImportMap_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_BusinessUnit_AsyncOperations"></a> BusinessUnit_AsyncOperations

See businessunit Entity [BusinessUnit_AsyncOperations](businessunit.md#BKMK_BusinessUnit_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_Queue_AsyncOperations"></a> Queue_AsyncOperations

See queue Entity [Queue_AsyncOperations](queue.md#BKMK_Queue_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_QueueItem_AsyncOperations"></a> QueueItem_AsyncOperations

See queueitem Entity [QueueItem_AsyncOperations](queueitem.md#BKMK_QueueItem_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_RelationshipRoleMap_AsyncOperations"></a> RelationshipRoleMap_AsyncOperations

See relationshiprolemap Entity [RelationshipRoleMap_AsyncOperations](relationshiprolemap.md#BKMK_RelationshipRoleMap_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_team_asyncoperation"></a> team_asyncoperation

See team Entity [team_asyncoperation](team.md#BKMK_team_asyncoperation) One-To-Many relationship.

### <a name="BKMK_lk_asyncoperation_modifiedby"></a> lk_asyncoperation_modifiedby

See systemuser Entity [lk_asyncoperation_modifiedby](systemuser.md#BKMK_lk_asyncoperation_modifiedby) One-To-Many relationship.

### <a name="BKMK_CustomerRelationship_AsyncOperations"></a> CustomerRelationship_AsyncOperations

See customerrelationship Entity [CustomerRelationship_AsyncOperations](customerrelationship.md#BKMK_CustomerRelationship_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_UserForm_AsyncOperations"></a> UserForm_AsyncOperations

See userform Entity [UserForm_AsyncOperations](userform.md#BKMK_UserForm_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_RelationshipRole_AsyncOperations"></a> RelationshipRole_AsyncOperations

See relationshiprole Entity [RelationshipRole_AsyncOperations](relationshiprole.md#BKMK_RelationshipRole_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_TransactionCurrency_AsyncOperations"></a> TransactionCurrency_AsyncOperations

See transactioncurrency Entity [TransactionCurrency_AsyncOperations](transactioncurrency.md#BKMK_TransactionCurrency_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_rollupfield_AsyncOperations"></a> rollupfield_AsyncOperations

See rollupfield Entity [rollupfield_AsyncOperations](rollupfield.md#BKMK_rollupfield_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_Letter_AsyncOperations"></a> Letter_AsyncOperations

See letter Entity [Letter_AsyncOperations](letter.md#BKMK_Letter_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_KbArticle_AsyncOperations"></a> KbArticle_AsyncOperations

See kbarticle Entity [KbArticle_AsyncOperations](kbarticle.md#BKMK_KbArticle_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_EntityMap_AsyncOperations"></a> EntityMap_AsyncOperations

See entitymap Entity [EntityMap_AsyncOperations](entitymap.md#BKMK_EntityMap_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_RecurringAppointmentMaster_AsyncOperations"></a> RecurringAppointmentMaster_AsyncOperations

See recurringappointmentmaster Entity [RecurringAppointmentMaster_AsyncOperations](recurringappointmentmaster.md#BKMK_RecurringAppointmentMaster_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_IsvConfig_AsyncOperations"></a> IsvConfig_AsyncOperations

See isvconfig Entity [IsvConfig_AsyncOperations](isvconfig.md#BKMK_IsvConfig_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_Task_AsyncOperations"></a> Task_AsyncOperations

See task Entity [Task_AsyncOperations](task.md#BKMK_Task_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_BusinessUnitNewsArticle_AsyncOperations"></a> BusinessUnitNewsArticle_AsyncOperations

See businessunitnewsarticle Entity [BusinessUnitNewsArticle_AsyncOperations](businessunitnewsarticle.md#BKMK_BusinessUnitNewsArticle_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_AttributeMap_AsyncOperations"></a> AttributeMap_AsyncOperations

See attributemap Entity [AttributeMap_AsyncOperations](attributemap.md#BKMK_AttributeMap_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_Connection_AsyncOperations"></a> Connection_AsyncOperations

See connection Entity [Connection_AsyncOperations](connection.md#BKMK_Connection_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_SystemUser_AsyncOperations"></a> SystemUser_AsyncOperations

See systemuser Entity [SystemUser_AsyncOperations](systemuser.md#BKMK_SystemUser_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_KbArticleTemplate_AsyncOperations"></a> KbArticleTemplate_AsyncOperations

See kbarticletemplate Entity [KbArticleTemplate_AsyncOperations](kbarticletemplate.md#BKMK_KbArticleTemplate_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_SdkMessageProcessingStep_AsyncOperations"></a> SdkMessageProcessingStep_AsyncOperations

See sdkmessageprocessingstep Entity [SdkMessageProcessingStep_AsyncOperations](sdkmessageprocessingstep.md#BKMK_SdkMessageProcessingStep_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_externalpartyitem_AsyncOperations"></a> externalpartyitem_AsyncOperations

See externalpartyitem Entity [externalpartyitem_AsyncOperations](externalpartyitem.md#BKMK_externalpartyitem_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_Template_AsyncOperations"></a> Template_AsyncOperations

See template Entity [Template_AsyncOperations](template.md#BKMK_Template_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_CustomerAddress_AsyncOperations"></a> CustomerAddress_AsyncOperations

See customeraddress Entity [CustomerAddress_AsyncOperations](customeraddress.md#BKMK_CustomerAddress_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_Contact_AsyncOperations"></a> Contact_AsyncOperations

See contact Entity [Contact_AsyncOperations](contact.md#BKMK_Contact_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_emailserverprofile_asyncoperations"></a> emailserverprofile_asyncoperations

See emailserverprofile Entity [emailserverprofile_asyncoperations](emailserverprofile.md#BKMK_emailserverprofile_asyncoperations) One-To-Many relationship.

### <a name="BKMK_lk_asyncoperation_createdonbehalfby"></a> lk_asyncoperation_createdonbehalfby

See systemuser Entity [lk_asyncoperation_createdonbehalfby](systemuser.md#BKMK_lk_asyncoperation_createdonbehalfby) One-To-Many relationship.

### <a name="BKMK_Import_AsyncOperations"></a> Import_AsyncOperations

See import Entity [Import_AsyncOperations](import.md#BKMK_Import_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_system_user_asyncoperation"></a> system_user_asyncoperation

See systemuser Entity [system_user_asyncoperation](systemuser.md#BKMK_system_user_asyncoperation) One-To-Many relationship.

### <a name="BKMK_business_unit_asyncoperation"></a> business_unit_asyncoperation

See businessunit Entity [business_unit_asyncoperation](businessunit.md#BKMK_business_unit_asyncoperation) One-To-Many relationship.

### <a name="BKMK_ImportLog_AsyncOperations"></a> ImportLog_AsyncOperations

See importlog Entity [ImportLog_AsyncOperations](importlog.md#BKMK_ImportLog_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_metric_AsyncOperations"></a> metric_AsyncOperations

See metric Entity [metric_AsyncOperations](metric.md#BKMK_metric_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_SocialProfile_AsyncOperations"></a> SocialProfile_AsyncOperations

See socialprofile Entity [SocialProfile_AsyncOperations](socialprofile.md#BKMK_SocialProfile_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_lk_asyncoperation_modifiedonbehalfby"></a> lk_asyncoperation_modifiedonbehalfby

See systemuser Entity [lk_asyncoperation_modifiedonbehalfby](systemuser.md#BKMK_lk_asyncoperation_modifiedonbehalfby) One-To-Many relationship.

### <a name="BKMK_Account_AsyncOperations"></a> Account_AsyncOperations

See account Entity [Account_AsyncOperations](account.md#BKMK_Account_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_Email_AsyncOperations"></a> Email_AsyncOperations

See email Entity [Email_AsyncOperations](email.md#BKMK_Email_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_FixedMonthlyFiscalCalendar_AsyncOperations"></a> FixedMonthlyFiscalCalendar_AsyncOperations

See fixedmonthlyfiscalcalendar Entity [FixedMonthlyFiscalCalendar_AsyncOperations](fixedmonthlyfiscalcalendar.md#BKMK_FixedMonthlyFiscalCalendar_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_SemiAnnualFiscalCalendar_AsyncOperations"></a> SemiAnnualFiscalCalendar_AsyncOperations

See semiannualfiscalcalendar Entity [SemiAnnualFiscalCalendar_AsyncOperations](semiannualfiscalcalendar.md#BKMK_SemiAnnualFiscalCalendar_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_MailMergeTemplate_AsyncOperations"></a> MailMergeTemplate_AsyncOperations

See mailmergetemplate Entity [MailMergeTemplate_AsyncOperations](mailmergetemplate.md#BKMK_MailMergeTemplate_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_Organization_AsyncOperations"></a> Organization_AsyncOperations

See organization Entity [Organization_AsyncOperations](organization.md#BKMK_Organization_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_Calendar_AsyncOperations"></a> Calendar_AsyncOperations

See calendar Entity [Calendar_AsyncOperations](calendar.md#BKMK_Calendar_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_ImportFile_AsyncOperations"></a> ImportFile_AsyncOperations

See importfile Entity [ImportFile_AsyncOperations](importfile.md#BKMK_ImportFile_AsyncOperations) One-To-Many relationship.

## See also

[About the Entity Reference](../about-entity-reference.md)<br />
[Programming reference for Dynamics 365 Customer Engagement](../programming-reference.md)<br />
[Web API Reference](/dynamics365/customer-engagement/web-api/about)<br />
<xref href="Microsoft.Dynamics.CRM.asyncoperation?text=asyncoperation EntityType" />