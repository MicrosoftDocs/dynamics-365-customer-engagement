---
title: "AsyncOperation Entity Reference (Dynamics 365 Customer Engagement)| MicrosoftDocs"
description: "Includes schema information and supported messages for the AsyncOperation entity."
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
# AsyncOperation Entity Reference

Process whose execution can proceed independently or in the background.


## Messages

|Message|Web API Operation|SDK Assembly|
|-|-|-|
|Create|POST [*org URI*]/api/data/v9.0/asyncoperations<br />See [Create](/powerapps/developer/common-data-service/webapi/create-entity-web-api)|<xref:Microsoft.Xrm.Sdk.Messages.CreateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Create*>|
|Delete|DELETE [*org URI*]/api/data/v9.0/asyncoperations(*asyncoperationid*)<br />See [Delete](/powerapps/developer/common-data-service/webapi/update-delete-entities-using-web-api#basic-delete)|<xref:Microsoft.Xrm.Sdk.Messages.DeleteRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Delete*>|
|Retrieve|GET [*org URI*]/api/data/v9.0/asyncoperations(*asyncoperationid*)<br />See [Retrieve](/powerapps/developer/common-data-service/webapi/retrieve-entity-using-web-api)|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Retrieve*>|
|RetrieveMultiple|GET [*org URI*]/api/data/v9.0/asyncoperations<br />See [Query Data](/powerapps/developer/common-data-service/webapi/query-data-web-api)|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveMultipleRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.RetrieveMultiple*>|
|RetrievePrincipalAccess|<xref href="Microsoft.Dynamics.CRM.RetrievePrincipalAccess?text=RetrievePrincipalAccess Function" />|<xref:Microsoft.Crm.Sdk.Messages.RetrievePrincipalAccessRequest>|
|Update|PATCH [*org URI*]/api/data/v9.0/asyncoperations(*asyncoperationid*)<br />See [Update](/powerapps/developer/common-data-service/webapi/update-delete-entities-using-web-api#basic-update)|<xref:Microsoft.Xrm.Sdk.Messages.UpdateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Update*>|

## Entity Properties

|Property|Value|
|--------|-----|
|CollectionSchemaName|AsyncOperations|
|DisplayCollectionName|System Jobs|
|DisplayName|System Job|
|EntitySetName|asyncoperations|
|IsBPFEntity|False|
|LogicalCollectionName|asyncoperations|
|LogicalName|asyncoperation|
|OwnershipType|UserOwned|
|PrimaryIdAttribute|asyncoperationid|
|PrimaryNameAttribute|name|
|SchemaName|AsyncOperation|

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
- [RootExecutionContext](#BKMK_RootExecutionContext)
- [StateCode](#BKMK_StateCode)
- [StatusCode](#BKMK_StatusCode)
- [TimeZoneRuleVersionNumber](#BKMK_TimeZoneRuleVersionNumber)
- [UTCConversionTimeZoneCode](#BKMK_UTCConversionTimeZoneCode)
- [WorkflowActivationId](#BKMK_WorkflowActivationId)


### <a name="BKMK_AsyncOperationId"></a> AsyncOperationId

|Property|Value|
|--------|-----|
|Description|Unique identifier of the system job.|
|DisplayName|System Job|
|IsValidForForm|False|
|IsValidForRead|True|
|IsValidForUpdate|False|
|LogicalName|asyncoperationid|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|


### <a name="BKMK_CorrelationId"></a> CorrelationId

|Property|Value|
|--------|-----|
|Description|Unique identifier used to correlate between multiple SDK requests and system jobs.|
|DisplayName|Correlation Id|
|IsValidForForm|False|
|IsValidForRead|True|
|IsValidForUpdate|False|
|LogicalName|correlationid|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|


### <a name="BKMK_CorrelationUpdatedTime"></a> CorrelationUpdatedTime

|Property|Value|
|--------|-----|
|DateTimeBehavior|UserLocal|
|Description|Last time the correlation depth was updated.|
|DisplayName|Correlation Updated Time|
|Format|DateAndTime|
|IsValidForForm|False|
|IsValidForRead|True|
|IsValidForUpdate|False|
|LogicalName|correlationupdatedtime|
|RequiredLevel|SystemRequired|
|Type|DateTime|


### <a name="BKMK_Data"></a> Data

|Property|Value|
|--------|-----|
|Description|Unstructured data associated with the system job.|
|DisplayName|Data|
|Format|TextArea|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|data|
|MaxLength|1073741823|
|RequiredLevel|None|
|Type|Memo|


### <a name="BKMK_DependencyToken"></a> DependencyToken

|Property|Value|
|--------|-----|
|Description|Execution of all operations with the same dependency token is serialized.|
|DisplayName|Dependency Token|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|IsValidForUpdate|False|
|LogicalName|dependencytoken|
|MaxLength|256|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_Depth"></a> Depth

|Property|Value|
|--------|-----|
|Description|Number of SDK calls made since the first call.|
|DisplayName|Depth|
|Format|None|
|IsValidForForm|False|
|IsValidForRead|True|
|IsValidForUpdate|False|
|LogicalName|depth|
|MaxValue|2147483647|
|MinValue|0|
|RequiredLevel|SystemRequired|
|Type|Integer|


### <a name="BKMK_FriendlyMessage"></a> FriendlyMessage

|Property|Value|
|--------|-----|
|Description|Message provided by the system job.|
|DisplayName|Friendly message|
|Format|Text|
|IsLocalizable|False|
|IsValidForCreate|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|friendlymessage|
|MaxLength|100000|
|RequiredLevel|None|
|Type|Memo|


### <a name="BKMK_HostId"></a> HostId

|Property|Value|
|--------|-----|
|Description|Unique identifier of the host that owns this system job.|
|DisplayName|Host|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|IsValidForUpdate|False|
|LogicalName|hostid|
|MaxLength|256|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_MessageName"></a> MessageName

|Property|Value|
|--------|-----|
|Description|Name of the message that started this system job.|
|DisplayName|Message Name|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|IsValidForUpdate|False|
|LogicalName|messagename|
|MaxLength|160|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_Name"></a> Name

|Property|Value|
|--------|-----|
|Description|Name of the system job.|
|DisplayName|System Job Name|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|IsValidForUpdate|False|
|LogicalName|name|
|MaxLength|256|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_OperationType"></a> OperationType

|Property|Value|
|--------|-----|
|Description|Type of the system job.|
|DisplayName|System Job Type|
|IsValidForForm|True|
|IsValidForRead|True|
|IsValidForUpdate|False|
|LogicalName|operationtype|
|RequiredLevel|None|
|Type|Picklist|

#### OperationType Options

|Value|Label|
|-----|-----|
|1|System Event|
|2|Bulk Email|
|3|Import File Parse|
|4|Transform Parse Data|
|5|Import|
|6|Activity Propagation|
|7|Duplicate Detection Rule Publish|
|8|Bulk Duplicate Detection|
|9|SQM Data Collection|
|10|Workflow|
|11|Quick Campaign|
|12|Matchcode Update|
|13|Bulk Delete|
|14|Deletion Service|
|15|Index Management|
|16|Collect Organization Statistics|
|17|Import Subprocess|
|18|Calculate Organization Storage Size|
|19|Collect Organization Database Statistics|
|20|Collection Organization Size Statistics|
|21|Database Tuning|
|22|Calculate Organization Maximum Storage Size|
|23|Bulk Delete Subprocess|
|24|Update Statistic Intervals|
|25|Organization Full Text Catalog Index|
|26|Database log backup|
|27|Update Contract States|
|28|DBCC SHRINKDATABASE maintenance job|
|29|DBCC SHRINKFILE maintenance job|
|30|Reindex all indices maintenance job|
|31|Storage Limit Notification|
|32|Cleanup inactive workflow assemblies|
|35|Recurring Series Expansion|
|38|Import Sample Data|
|40|Goal Roll Up|
|41|Audit Partition Creation|
|42|Check For Language Pack Updates|
|43|Provision Language Pack|
|44|Update Organization Database|
|45|Update Solution|
|46|Regenerate Entity Row Count Snapshot Data|
|47|Regenerate Read Share Snapshot Data|
|49|Post to Yammer|
|50|Outgoing Activity|
|51|Incoming Email Processing|
|52|Mailbox Test Access|
|53|Encryption Health Check|
|54|Execute Async Request|
|56|Update Entitlement States|
|57|Calculate Rollup Field|
|58|Mass Calculate Rollup Field|
|59|Import Translation|
|62|Convert Date And Time Behavior|
|63|EntityKey Index Creation|
|65|Update Knowledge Article States|
|68|Resource Booking Sync|
|69|Relationship Assistant Cards|
|71|Cleanup Solution Components|
|72|App Module Metadata Operation|
|73|ALM Anomaly Detection Operation|
|75|Flow Notification|
|76|Ribbon Client Metadata Operation|
|79|CallbackRegistration Expander Operation|
|90|CascadeAssign|
|91|CascadeDelete|
|92|Event Expander Operation|



### <a name="BKMK_OwnerId"></a> OwnerId

|Property|Value|
|--------|-----|
|Description|Unique identifier of the user or team who owns the system job.|
|DisplayName|Owner|
|IsValidForForm|True|
|IsValidForRead|True|
|IsValidForUpdate|False|
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


### <a name="BKMK_OwningExtensionId"></a> OwningExtensionId

|Property|Value|
|--------|-----|
|Description|Unique identifier of the owning extension with which the system job is associated.|
|DisplayName|Owning Extension|
|IsValidForForm|True|
|IsValidForRead|True|
|IsValidForUpdate|False|
|LogicalName|owningextensionid|
|RequiredLevel|None|
|Targets|sdkmessageprocessingstep|
|Type|Lookup|


### <a name="BKMK_OwningExtensionIdName"></a> OwningExtensionIdName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|IsValidForUpdate|False|
|LogicalName|owningextensionidname|
|MaxLength|256|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_OwningExtensionTypeCode"></a> OwningExtensionTypeCode

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|IsValidForForm|False|
|IsValidForRead|True|
|IsValidForUpdate|False|
|LogicalName|owningextensiontypecode|
|RequiredLevel|None|
|Type|EntityName|


### <a name="BKMK_ParentPluginExecutionId"></a> ParentPluginExecutionId

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|IsValidForForm|False|
|IsValidForRead|True|
|IsValidForUpdate|False|
|LogicalName|parentpluginexecutionid|
|RequiredLevel|None|
|Type|Uniqueidentifier|


### <a name="BKMK_PostponeUntil"></a> PostponeUntil

|Property|Value|
|--------|-----|
|DateTimeBehavior|UserLocal|
|Description|Indicates whether the system job should run only after the specified date and time.|
|DisplayName|Postpone Until|
|Format|DateAndTime|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|postponeuntil|
|RequiredLevel|None|
|Type|DateTime|


### <a name="BKMK_PrimaryEntityType"></a> PrimaryEntityType

|Property|Value|
|--------|-----|
|Description|Type of entity with which the system job is primarily associated.|
|DisplayName|Primary Entity Type|
|IsValidForForm|False|
|IsValidForRead|True|
|IsValidForUpdate|False|
|LogicalName|primaryentitytype|
|RequiredLevel|None|
|Type|EntityName|


### <a name="BKMK_RecurrencePattern"></a> RecurrencePattern

|Property|Value|
|--------|-----|
|Description|Pattern of the system job's recurrence.|
|DisplayName|Recurrence Pattern|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|recurrencepattern|
|MaxLength|256|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_RecurrenceStartTime"></a> RecurrenceStartTime

|Property|Value|
|--------|-----|
|DateTimeBehavior|UserLocal|
|Description|Starting time in UTC for the recurrence pattern.|
|DisplayName|Recurrence Start|
|Format|DateOnly|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|recurrencestarttime|
|RequiredLevel|None|
|Type|DateTime|


### <a name="BKMK_RegardingObjectId"></a> RegardingObjectId

|Property|Value|
|--------|-----|
|Description|Unique identifier of the object with which the system job is associated.|
|DisplayName|Regarding|
|IsValidForForm|True|
|IsValidForRead|True|
|IsValidForUpdate|False|
|LogicalName|regardingobjectid|
|RequiredLevel|None|
|Targets|account,accountleads,activitymimeattachment,activitypointer,adminsettingsentity,annotation,annualfiscalcalendar,appointment,attributemap,bookableresource,bookableresourcebooking,bookableresourcebookingexchangesyncidmapping,bookableresourcebookingheader,bookableresourcecategory,bookableresourcecategoryassn,bookableresourcecharacteristic,bookableresourcegroup,bookingstatus,bulkoperation,bulkoperationlog,businessunit,businessunitnewsarticle,calendar,campaign,campaignactivity,campaignactivityitem,campaignitem,campaignresponse,channelaccessprofile,channelaccessprofilerule,characteristic,childincidentcount,commitment,competitor,competitoraddress,competitorproduct,competitorsalesliterature,connection,connectionrole,constraintbasedgroup,contact,contactinvoices,contactleads,contactorders,contactquotes,contract,contractdetail,contracttemplate,convertrule,customeraddress,customeropportunityrole,customerrelationship,discount,discounttype,displaystring,dynamicproperty,dynamicpropertyassociation,dynamicpropertyinstance,dynamicpropertyoptionsetitem,email,emailserverprofile,entitlement,entitlementchannel,entitlementcontacts,entitlemententityallocationtypemapping,entitlementproducts,entitlementtemplate,entitlementtemplatechannel,entitlementtemplateproducts,entitymap,equipment,externalparty,externalpartyitem,fax,fixedmonthlyfiscalcalendar,goal,goalrollupquery,holidaywrapper,import,importdata,importfile,importlog,importmap,incident,incidentknowledgebaserecord,incidentresolution,interactionforemail,invoice,invoicedetail,isvconfig,kbarticle,kbarticlecomment,kbarticletemplate,knowledgearticle,knowledgearticleincident,knowledgebaserecord,lead,leadaddress,leadcompetitors,leadproduct,leadtoopportunitysalesprocess,letter,list,listmember,mailbox,mailmergetemplate,metric,monthlyfiscalcalendar,msdyn_3dmodel,msdyn_accountpricelist,msdyn_actual,msdyn_agreement,msdyn_agreementbookingdate,msdyn_agreementbookingincident,msdyn_agreementbookingproduct,msdyn_agreementbookingservice,msdyn_agreementbookingservicetask,msdyn_agreementbookingsetup,msdyn_agreementinvoicedate,msdyn_agreementinvoiceproduct,msdyn_agreementinvoicesetup,msdyn_agreementsubstatus,msdyn_analysiscomponent,msdyn_analysisjob,msdyn_analysisresult,msdyn_analysisresultdetail,msdyn_approval,msdyn_batchjob,msdyn_bookableresourceassociation,msdyn_bookingalert,msdyn_bookingalertstatus,msdyn_bookingchange,msdyn_bookingjournal,msdyn_bookingrule,msdyn_bookingsetupmetadata,msdyn_bookingtimestamp,msdyn_bpf_2c5fe86acc8b414b8322ae571000c799,msdyn_bpf_477c16f59170487b8b4dc895c5dcd09b,msdyn_bpf_665e73aa18c247d886bfc50499c73b82,msdyn_bpf_989e9b1857e24af18787d5143b67523b,msdyn_bpf_baa0a411a239410cb8bded8b5fdd88e3,msdyn_bpf_d3d97bac8c294105840e99e37a9d1c39,msdyn_bpf_d8f9dc7f099f44db9d641dd81fbd470d,msdyn_businessclosure,msdyn_callablecontext,msdyn_characteristicreqforteammember,msdyn_clientextension,msdyn_configuration,msdyn_connector,msdyn_contactpricelist,msdyn_contractlineinvoiceschedule,msdyn_contractlinescheduleofvalue,msdyn_customerasset,msdyn_customerassetcategory,msdyn_databaseversion,msdyn_dataexport,msdyn_delegation,msdyn_dimension,msdyn_dimensionfieldname,msdyn_entitlementapplication,msdyn_entityconfiguration,msdyn_estimate,msdyn_estimateline,msdyn_expense,msdyn_expensecategory,msdyn_expensereceipt,msdyn_fact,msdyn_fieldcomputation,msdyn_fieldservicepricelistitem,msdyn_fieldservicesetting,msdyn_fieldserviceslaconfiguration,msdyn_fieldservicesystemjob,msdyn_findworkevent,msdyn_forecastdefinition,msdyn_forecastinstance,msdyn_forecastrecurrence,msdyn_geofence,msdyn_geofenceevent,msdyn_geofencingsettings,msdyn_icebreakersconfig,msdyn_incidenttype,msdyn_incidenttypecharacteristic,msdyn_incidenttypeproduct,msdyn_incidenttypeservice,msdyn_incidenttypeservicetask,msdyn_incidenttypessetup,msdyn_incidenttype_requirementgroup,msdyn_integrationjob,msdyn_integrationjobdetail,msdyn_inventoryadjustment,msdyn_inventoryadjustmentproduct,msdyn_inventoryjournal,msdyn_inventorytransfer,msdyn_invoicefrequency,msdyn_invoicefrequencydetail,msdyn_invoicelinetransaction,msdyn_iotalert,msdyn_iotdevice,msdyn_iotdevicecategory,msdyn_iotdevicecommand,msdyn_iotdevicecommanddefinition,msdyn_iotdevicedatahistory,msdyn_iotdeviceproperty,msdyn_iotdeviceregistrationhistory,msdyn_iotpropertydefinition,msdyn_iotsettings,msdyn_journal,msdyn_journalline,msdyn_mlresultcache,msdyn_notesanalysisconfig,msdyn_opportunitylineresourcecategory,msdyn_opportunitylinetransaction,msdyn_opportunitylinetransactioncategory,msdyn_opportunitylinetransactionclassificatio,msdyn_opportunitypricelist,msdyn_orderinvoicingdate,msdyn_orderinvoicingproduct,msdyn_orderinvoicingsetup,msdyn_orderinvoicingsetupdate,msdyn_orderlineresourcecategory,msdyn_orderlinetransaction,msdyn_orderlinetransactioncategory,msdyn_orderlinetransactionclassification,msdyn_orderpricelist,msdyn_organizationalunit,msdyn_payment,msdyn_paymentdetail,msdyn_paymentmethod,msdyn_paymentterm,msdyn_playbookactivity,msdyn_playbookactivityattribute,msdyn_playbookcategory,msdyn_playbookinstance,msdyn_playbooktemplate,msdyn_postalbum,msdyn_postalcode,msdyn_postconfig,msdyn_postruleconfig,msdyn_priority,msdyn_processnotes,msdyn_productinventory,msdyn_project,msdyn_projectapproval,msdyn_projectparameter,msdyn_projectparameterpricelist,msdyn_projectpricelist,msdyn_projecttask,msdyn_projecttaskdependency,msdyn_projecttaskstatususer,msdyn_projectteam,msdyn_projectteammembersignup,msdyn_projecttransactioncategory,msdyn_purchaseorder,msdyn_purchaseorderbill,msdyn_purchaseorderproduct,msdyn_purchaseorderreceipt,msdyn_purchaseorderreceiptproduct,msdyn_purchaseordersubstatus,msdyn_quotebookingincident,msdyn_quotebookingproduct,msdyn_quotebookingservice,msdyn_quotebookingservicetask,msdyn_quotebookingsetup,msdyn_quoteinvoicingproduct,msdyn_quoteinvoicingsetup,msdyn_quotelineanalyticsbreakdown,msdyn_quotelineinvoiceschedule,msdyn_quotelineresourcecategory,msdyn_quotelinescheduleofvalue,msdyn_quotelinetransaction,msdyn_quotelinetransactioncategory,msdyn_quotelinetransactionclassification,msdyn_quotepricelist,msdyn_relationshipinsightsunifiedconfig,msdyn_requirementcharacteristic,msdyn_requirementgroup,msdyn_requirementorganizationunit,msdyn_requirementrelationship,msdyn_requirementresourcecategory,msdyn_requirementresourcepreference,msdyn_requirementstatus,msdyn_resourceassignment,msdyn_resourceassignmentdetail,msdyn_resourcecategorymarkuppricelevel,msdyn_resourcecategorypricelevel,msdyn_resourcepaytype,msdyn_resourcerequest,msdyn_resourcerequirement,msdyn_resourcerequirementdetail,msdyn_resourceterritory,msdyn_rma,msdyn_rmaproduct,msdyn_rmareceipt,msdyn_rmareceiptproduct,msdyn_rmasubstatus,msdyn_rolecompetencyrequirement,msdyn_roleutilization,msdyn_rtv,msdyn_rtvproduct,msdyn_rtvsubstatus,msdyn_scheduleboardsetting,msdyn_schedulingparameter,msdyn_servicetasktype,msdyn_shipvia,msdyn_siconfig,msdyn_solutionhealthrule,msdyn_solutionhealthruleargument,msdyn_solutionhealthruleset,msdyn_systemuserschedulersetting,msdyn_taxcode,msdyn_taxcodedetail,msdyn_teamscollaboration,msdyn_timeentry,msdyn_timegroup,msdyn_timegroupdetail,msdyn_timeoffcalendar,msdyn_timeoffrequest,msdyn_transactioncategory,msdyn_transactioncategoryclassification,msdyn_transactioncategoryhierarchyelement,msdyn_transactioncategorypricelevel,msdyn_transactionconnection,msdyn_transactionorigin,msdyn_transactiontype,msdyn_uniquenumber,msdyn_untrackedappointment,msdyn_upgraderun,msdyn_upgradestep,msdyn_upgradeversion,msdyn_userworkhistory,msdyn_wallsavedquery,msdyn_wallsavedqueryusersettings,msdyn_warehouse,msdyn_workhourtemplate,msdyn_workorder,msdyn_workordercharacteristic,msdyn_workorderdetailsgenerationqueue,msdyn_workorderincident,msdyn_workorderproduct,msdyn_workorderresourcerestriction,msdyn_workorderservice,msdyn_workorderservicetask,msdyn_workordersubstatus,msdyn_workordertype,msfp_emailtemplate,msfp_question,msfp_questionresponse,msfp_survey,msfp_surveyinvite,msfp_surveyresponse,msfp_unsubscribedrecipient,opportunity,opportunityclose,opportunitycompetitors,opportunityproduct,opportunitysalesprocess,orderclose,organization,phonecall,phonetocaseprocess,position,post,postfollow,pricelevel,privilege,product,productassociation,productpricelevel,productsalesliterature,productsubstitute,quarterlyfiscalcalendar,queue,queueitem,quote,quoteclose,quotedetail,ratingmodel,ratingvalue,recurringappointmentmaster,relationshiprole,relationshiprolemap,report,resource,resourcegroup,resourcegroupexpansion,resourcespec,role,rollupfield,routingrule,routingruleitem,salesliterature,salesliteratureitem,salesorder,salesorderdetail,salesprocessinstance,savedquery,semiannualfiscalcalendar,service,serviceappointment,servicecontractcontacts,sharepointdocumentlocation,sharepointsite,similarityrule,site,sla,socialactivity,socialprofile,subject,systemform,systemuser,task,team,template,territory,theme,topic,topichistory,topicmodel,topicmodelconfiguration,topicmodelexecutionhistory,transactioncurrency,uom,uomschedule,userform,usermapping,userquery|
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
|IsValidForUpdate|False|
|LogicalName|regardingobjectidname|
|MaxLength|256|
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
|IsValidForUpdate|False|
|LogicalName|regardingobjectidyominame|
|MaxLength|160|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_RegardingObjectTypeCode"></a> RegardingObjectTypeCode

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|IsValidForForm|False|
|IsValidForRead|True|
|IsValidForUpdate|False|
|LogicalName|regardingobjecttypecode|
|RequiredLevel|None|
|Type|EntityName|


### <a name="BKMK_RequestId"></a> RequestId

|Property|Value|
|--------|-----|
|Description|Unique identifier of the request that generated the system job.|
|DisplayName|Request|
|IsValidForForm|False|
|IsValidForRead|True|
|IsValidForUpdate|False|
|LogicalName|requestid|
|RequiredLevel|None|
|Type|Uniqueidentifier|


### <a name="BKMK_RootExecutionContext"></a> RootExecutionContext

|Property|Value|
|--------|-----|
|Description|Root execution context of the job that triggered async job.|
|DisplayName|RootExecutionContext|
|Format|TextArea|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|rootexecutioncontext|
|MaxLength|1073741823|
|RequiredLevel|None|
|Type|Memo|


### <a name="BKMK_StateCode"></a> StateCode

|Property|Value|
|--------|-----|
|Description|Status of the system job.|
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
|0|Ready|0|Ready|
|1|Suspended|10|Suspended|
|2|Locked|20|Locked|
|3|Completed|30|Completed|



### <a name="BKMK_StatusCode"></a> StatusCode

|Property|Value|
|--------|-----|
|Description|Reason for the status of the system job.|
|DisplayName|Status Reason|
|IsValidForCreate|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|statuscode|
|RequiredLevel|None|
|Type|Status|

#### StatusCode Options

|Value|Label|State|
|-----|-----|-----|
|0|Waiting For Resources|0|
|10|Waiting|1|
|20|In Progress|2|
|21|Pausing|2|
|22|Canceling|2|
|30|Succeeded|3|
|31|Failed|3|
|32|Canceled|3|



### <a name="BKMK_TimeZoneRuleVersionNumber"></a> TimeZoneRuleVersionNumber

|Property|Value|
|--------|-----|
|Description|For internal use only.|
|DisplayName||
|Format|None|
|IsValidForForm|False|
|IsValidForRead|True|
|IsValidForUpdate|False|
|LogicalName|timezoneruleversionnumber|
|MaxValue|2147483647|
|MinValue|-1|
|RequiredLevel|None|
|Type|Integer|


### <a name="BKMK_UTCConversionTimeZoneCode"></a> UTCConversionTimeZoneCode

|Property|Value|
|--------|-----|
|Description|Time zone code that was in use when the record was created.|
|DisplayName||
|Format|None|
|IsValidForForm|False|
|IsValidForRead|True|
|IsValidForUpdate|False|
|LogicalName|utcconversiontimezonecode|
|MaxValue|2147483647|
|MinValue|-1|
|RequiredLevel|None|
|Type|Integer|


### <a name="BKMK_WorkflowActivationId"></a> WorkflowActivationId

|Property|Value|
|--------|-----|
|Description|Unique identifier of the workflow activation related to the system job.|
|DisplayName|Workflow Activation Id|
|IsValidForForm|False|
|IsValidForRead|True|
|IsValidForUpdate|False|
|LogicalName|workflowactivationid|
|RequiredLevel|None|
|Targets|workflow|
|Type|Lookup|

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

|Property|Value|
|--------|-----|
|DateTimeBehavior|UserLocal|
|Description|Date and time when the system job was completed.|
|DisplayName|Completed On|
|Format|DateAndTime|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|completedon|
|RequiredLevel|None|
|Type|DateTime|


### <a name="BKMK_CreatedBy"></a> CreatedBy

|Property|Value|
|--------|-----|
|Description|Unique identifier of the user who created the system job.|
|DisplayName|Created By|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|createdby|
|RequiredLevel|SystemRequired|
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
|MaxLength|160|
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
|MaxLength|160|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_CreatedOn"></a> CreatedOn

|Property|Value|
|--------|-----|
|DateTimeBehavior|UserLocal|
|Description|Date and time when the system job was created.|
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
|Description|Unique identifier of the delegate user who created the asyncoperation.|
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


### <a name="BKMK_ErrorCode"></a> ErrorCode

|Property|Value|
|--------|-----|
|Description|Error code returned from a canceled system job.|
|DisplayName|Error Code|
|Format|None|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|errorcode|
|MaxValue|2147483647|
|MinValue|-2147483648|
|RequiredLevel|None|
|Type|Integer|


### <a name="BKMK_ExecutionTimeSpan"></a> ExecutionTimeSpan

|Property|Value|
|--------|-----|
|Description|Time that the system job has taken to execute.|
|DisplayName|ExecutionTimeSpan|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|executiontimespan|
|MaxValue|1000000000|
|MinValue|0|
|Precision|2|
|RequiredLevel|SystemRequired|
|Type|Double|


### <a name="BKMK_IsWaitingForEvent"></a> IsWaitingForEvent

|Property|Value|
|--------|-----|
|Description|Indicates that the system job is waiting for an event.|
|DisplayName|Waiting for Event|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|iswaitingforevent|
|RequiredLevel|None|
|Type|Boolean|

#### IsWaitingForEvent Options

|Value|Label|
|-----|-----|
|1|Yes|
|0|No|

**DefaultValue**: False



### <a name="BKMK_Message"></a> Message

|Property|Value|
|--------|-----|
|Description|Message related to the system job.|
|DisplayName|Message|
|Format|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|message|
|MaxLength|100000|
|RequiredLevel|None|
|Type|Memo|


### <a name="BKMK_ModifiedBy"></a> ModifiedBy

|Property|Value|
|--------|-----|
|Description|Unique identifier of the user who last modified the system job.|
|DisplayName|Modified By|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|modifiedby|
|RequiredLevel|SystemRequired|
|Targets|systemuser|
|Type|Lookup|


### <a name="BKMK_ModifiedByName"></a> ModifiedByName

|Property|Value|
|--------|-----|
|Description|Name of the user who last modified the record.|
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|modifiedbyname|
|MaxLength|160|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_ModifiedByYomiName"></a> ModifiedByYomiName

|Property|Value|
|--------|-----|
|Description|YomiName of the user who last modified the record.|
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|modifiedbyyominame|
|MaxLength|160|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_ModifiedOn"></a> ModifiedOn

|Property|Value|
|--------|-----|
|DateTimeBehavior|UserLocal|
|Description|Date and time when the system job was last modified.|
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
|Description|Unique identifier of the delegate user who last modified the asyncoperation.|
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
|MaxLength|160|
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
|MaxLength|160|
|RequiredLevel|SystemRequired|
|Type|String|


### <a name="BKMK_OwningBusinessUnit"></a> OwningBusinessUnit

|Property|Value|
|--------|-----|
|Description|Unique identifier of the business unit that owns the system job.|
|DisplayName|Owning Business Unit|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|owningbusinessunit|
|RequiredLevel|SystemRequired|
|Targets|businessunit|
|Type|Lookup|


### <a name="BKMK_OwningTeam"></a> OwningTeam

|Property|Value|
|--------|-----|
|Description|Unique identifier of the team who owns the record.|
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
|Description|Unique identifier of the user who owns the record.|
|DisplayName|Owning User|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|owninguser|
|RequiredLevel|None|
|Targets|systemuser|
|Type|Lookup|


### <a name="BKMK_RetryCount"></a> RetryCount

|Property|Value|
|--------|-----|
|Description|Number of times to retry the system job.|
|DisplayName|Retry Count|
|Format|None|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|retrycount|
|MaxValue|2147483647|
|MinValue|0|
|RequiredLevel|None|
|Type|Integer|


### <a name="BKMK_Sequence"></a> Sequence

|Property|Value|
|--------|-----|
|Description|Order in which operations were submitted.|
|DisplayName|Sequence|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|sequence|
|MaxValue|9223372036854775807|
|MinValue|-9223372036854775808|
|RequiredLevel|SystemRequired|
|Type|BigInt|


### <a name="BKMK_StartedOn"></a> StartedOn

|Property|Value|
|--------|-----|
|DateTimeBehavior|UserLocal|
|Description|Date and time when the system job was started.|
|DisplayName|Started On|
|Format|DateAndTime|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|startedon|
|RequiredLevel|None|
|Type|DateTime|


### <a name="BKMK_Subtype"></a> Subtype

|Property|Value|
|--------|-----|
|Description|The Subtype of the Async Job|
|DisplayName|Subtype|
|Format|None|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|subtype|
|MaxValue|255|
|MinValue|0|
|RequiredLevel|None|
|Type|Integer|


### <a name="BKMK_WorkflowActivationIdName"></a> WorkflowActivationIdName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|workflowactivationidname|
|MaxLength|160|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_WorkflowIsBlocked"></a> WorkflowIsBlocked

|Property|Value|
|--------|-----|
|Description|Indicates whether the workflow instance was blocked when it was persisted.|
|DisplayName|Workflow Is Blocked|
|IsValidForForm|False|
|IsValidForRead|False|
|LogicalName|workflowisblocked|
|RequiredLevel|None|
|Type|Boolean|

#### WorkflowIsBlocked Options

|Value|Label|
|-----|-----|
|1|Yes|
|0|No|

**DefaultValue**: False



### <a name="BKMK_WorkflowStageName"></a> WorkflowStageName

|Property|Value|
|--------|-----|
|Description|Name of a workflow stage.|
|DisplayName|Workflow Stage|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|workflowstagename|
|MaxLength|256|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_WorkflowState"></a> WorkflowState

|Property|Value|
|--------|-----|
|Description|State of the workflow job.|
|DisplayName|Workflow State|
|FormatName|TextArea|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|False|
|LogicalName|workflowstate|
|MaxLength|1073741823|
|RequiredLevel|None|
|Type|String|

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


### <a name="BKMK_AsyncOperation_MailboxTrackingFolder"></a> AsyncOperation_MailboxTrackingFolder

Same as mailboxtrackingfolder entity [AsyncOperation_MailboxTrackingFolder](mailboxtrackingfolder.md#BKMK_AsyncOperation_MailboxTrackingFolder) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|mailboxtrackingfolder|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|AsyncOperation_MailboxTrackingFolder|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: Cascade<br />Reparent: Cascade<br />Share: Cascade<br />Unshare: Cascade|


### <a name="BKMK_AsyncOperation_BulkDeleteOperation"></a> AsyncOperation_BulkDeleteOperation

Same as bulkdeleteoperation entity [AsyncOperation_BulkDeleteOperation](bulkdeleteoperation.md#BKMK_AsyncOperation_BulkDeleteOperation) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|bulkdeleteoperation|
|ReferencingAttribute|asyncoperationid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|AsyncOperation_BulkDeleteOperation|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_lk_workflowlog_asyncoperation_childworkflow"></a> lk_workflowlog_asyncoperation_childworkflow

Same as workflowlog entity [lk_workflowlog_asyncoperation_childworkflow](workflowlog.md#BKMK_lk_workflowlog_asyncoperation_childworkflow) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|workflowlog|
|ReferencingAttribute|childworkflowinstanceid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|lk_workflowlog_asyncoperation_childworkflow|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_AsyncOperation_Emails"></a> AsyncOperation_Emails

Same as email entity [AsyncOperation_Emails](email.md#BKMK_AsyncOperation_Emails) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|email|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|AsyncOperation_Emails|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: Cascade<br />Reparent: Cascade<br />Share: Cascade<br />Unshare: Cascade|


### <a name="BKMK_AsyncOperation_DuplicateBaseRecord"></a> AsyncOperation_DuplicateBaseRecord

Same as duplicaterecord entity [AsyncOperation_DuplicateBaseRecord](duplicaterecord.md#BKMK_AsyncOperation_DuplicateBaseRecord) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|duplicaterecord|
|ReferencingAttribute|asyncoperationid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|AsyncOperation_DuplicateBaseRecord|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_lk_workflowlog_asyncoperations"></a> lk_workflowlog_asyncoperations

Same as workflowlog entity [lk_workflowlog_asyncoperations](workflowlog.md#BKMK_lk_workflowlog_asyncoperations) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|workflowlog|
|ReferencingAttribute|asyncoperationid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|lk_workflowlog_asyncoperations|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: Cascade<br />Reparent: Cascade<br />Share: Cascade<br />Unshare: Cascade|


### <a name="BKMK_AsyncOperation_SocialActivities"></a> AsyncOperation_SocialActivities

Same as socialactivity entity [AsyncOperation_SocialActivities](socialactivity.md#BKMK_AsyncOperation_SocialActivities) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|socialactivity|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|AsyncOperation_SocialActivities|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: Cascade<br />Reparent: Cascade<br />Share: Cascade<br />Unshare: Cascade|

<a name="manytoone"></a>

## Many-To-One Relationships

Each Many-To-One relationship is defined by a corresponding One-To-Many relationship with the related entity. Listed by **SchemaName**.

- [Territory_AsyncOperations](#BKMK_Territory_AsyncOperations)
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
- [CampaignResponse_AsyncOperations](#BKMK_CampaignResponse_AsyncOperations)
- [List_AsyncOperations](#BKMK_List_AsyncOperations)
- [msdyn_databaseversion_AsyncOperations](#BKMK_msdyn_databaseversion_AsyncOperations)
- [msdyn_upgraderun_AsyncOperations](#BKMK_msdyn_upgraderun_AsyncOperations)
- [msdyn_upgradestep_AsyncOperations](#BKMK_msdyn_upgradestep_AsyncOperations)
- [msdyn_upgradeversion_AsyncOperations](#BKMK_msdyn_upgradeversion_AsyncOperations)
- [ConstraintBasedGroup_AsyncOperations](#BKMK_ConstraintBasedGroup_AsyncOperations)
- [Contract_AsyncOperations](#BKMK_Contract_AsyncOperations)
- [ContractDetail_AsyncOperations](#BKMK_ContractDetail_AsyncOperations)
- [ContractTemplate_AsyncOperations](#BKMK_ContractTemplate_AsyncOperations)
- [entitlement_AsyncOperations](#BKMK_entitlement_AsyncOperations)
- [entitlementchannel_AsyncOperations](#BKMK_entitlementchannel_AsyncOperations)
- [entitlementtemplate_AsyncOperations](#BKMK_entitlementtemplate_AsyncOperations)
- [entitlementtemplatechannel_AsyncOperations](#BKMK_entitlementtemplatechannel_AsyncOperations)
- [Equipment_AsyncOperations](#BKMK_Equipment_AsyncOperations)
- [Incident_AsyncOperations](#BKMK_Incident_AsyncOperations)
- [IncidentResolution_AsyncOperations](#BKMK_IncidentResolution_AsyncOperations)
- [knowledgearticleincident_AsyncOperations](#BKMK_knowledgearticleincident_AsyncOperations)
- [phonetocaseprocess_AsyncOperations](#BKMK_phonetocaseprocess_AsyncOperations)
- [Resource_AsyncOperations](#BKMK_Resource_AsyncOperations)
- [ResourceGroup_AsyncOperations](#BKMK_ResourceGroup_AsyncOperations)
- [ResourceSpec_AsyncOperations](#BKMK_ResourceSpec_AsyncOperations)
- [Service_AsyncOperations](#BKMK_Service_AsyncOperations)
- [ServiceAppointment_AsyncOperations](#BKMK_ServiceAppointment_AsyncOperations)
- [Site_AsyncOperations](#BKMK_Site_AsyncOperations)
- [entitlemententityallocationtypemapping_AsyncOperations](#BKMK_entitlemententityallocationtypemapping_AsyncOperations)
- [msdyn_callablecontext_AsyncOperations](#BKMK_msdyn_callablecontext_AsyncOperations)
- [msdyn_playbookactivity_AsyncOperations](#BKMK_msdyn_playbookactivity_AsyncOperations)
- [msdyn_playbookactivityattribute_AsyncOperations](#BKMK_msdyn_playbookactivityattribute_AsyncOperations)
- [msdyn_playbookcategory_AsyncOperations](#BKMK_msdyn_playbookcategory_AsyncOperations)
- [msdyn_playbookinstance_AsyncOperations](#BKMK_msdyn_playbookinstance_AsyncOperations)
- [msdyn_playbooktemplate_AsyncOperations](#BKMK_msdyn_playbooktemplate_AsyncOperations)
- [Discount_AsyncOperations](#BKMK_Discount_AsyncOperations)
- [DiscountType_AsyncOperations](#BKMK_DiscountType_AsyncOperations)
- [Invoice_AsyncOperations](#BKMK_Invoice_AsyncOperations)
- [InvoiceDetail_AsyncOperations](#BKMK_InvoiceDetail_AsyncOperations)
- [leadtoopportunitysalesprocess_AsyncOperations](#BKMK_leadtoopportunitysalesprocess_AsyncOperations)
- [Opportunity_AsyncOperations](#BKMK_Opportunity_AsyncOperations)
- [OpportunityClose_AsyncOperations](#BKMK_OpportunityClose_AsyncOperations)
- [OpportunityProduct_AsyncOperations](#BKMK_OpportunityProduct_AsyncOperations)
- [opportunitysalesprocess_AsyncOperations](#BKMK_opportunitysalesprocess_AsyncOperations)
- [OrderClose_AsyncOperations](#BKMK_OrderClose_AsyncOperations)
- [Quote_AsyncOperations](#BKMK_Quote_AsyncOperations)
- [QuoteClose_AsyncOperations](#BKMK_QuoteClose_AsyncOperations)
- [QuoteDetail_AsyncOperations](#BKMK_QuoteDetail_AsyncOperations)
- [SalesLiterature_AsyncOperations](#BKMK_SalesLiterature_AsyncOperations)
- [SalesLiteratureItem_AsyncOperations](#BKMK_SalesLiteratureItem_AsyncOperations)
- [SalesOrder_AsyncOperations](#BKMK_SalesOrder_AsyncOperations)
- [SalesOrderDetail_AsyncOperations](#BKMK_SalesOrderDetail_AsyncOperations)
- [Competitor_AsyncOperations](#BKMK_Competitor_AsyncOperations)
- [adminsettingsentity_AsyncOperations](#BKMK_adminsettingsentity_AsyncOperations)
- [msdyn_forecastdefinition_AsyncOperations](#BKMK_msdyn_forecastdefinition_AsyncOperations)
- [msdyn_forecastinstance_AsyncOperations](#BKMK_msdyn_forecastinstance_AsyncOperations)
- [msdyn_forecastrecurrence_AsyncOperations](#BKMK_msdyn_forecastrecurrence_AsyncOperations)
- [msdyn_relationshipinsightsunifiedconfig_AsyncOperations](#BKMK_msdyn_relationshipinsightsunifiedconfig_AsyncOperations)
- [msdyn_siconfig_AsyncOperations](#BKMK_msdyn_siconfig_AsyncOperations)
- [msdyn_untrackedappointment_AsyncOperations](#BKMK_msdyn_untrackedappointment_AsyncOperations)
- [msdyn_notesanalysisconfig_AsyncOperations](#BKMK_msdyn_notesanalysisconfig_AsyncOperations)
- [msdyn_icebreakersconfig_AsyncOperations](#BKMK_msdyn_icebreakersconfig_AsyncOperations)
- [msdyn_postalbum_AsyncOperations](#BKMK_msdyn_postalbum_AsyncOperations)
- [msdyn_postconfig_AsyncOperations](#BKMK_msdyn_postconfig_AsyncOperations)
- [msdyn_postruleconfig_AsyncOperations](#BKMK_msdyn_postruleconfig_AsyncOperations)
- [msdyn_wallsavedquery_AsyncOperations](#BKMK_msdyn_wallsavedquery_AsyncOperations)
- [msdyn_wallsavedqueryusersettings_AsyncOperations](#BKMK_msdyn_wallsavedqueryusersettings_AsyncOperations)
- [msdyn_teamscollaboration_AsyncOperations](#BKMK_msdyn_teamscollaboration_AsyncOperations)
- [msdyn_actual_AsyncOperations](#BKMK_msdyn_actual_AsyncOperations)
- [msdyn_bookableresourceassociation_AsyncOperations](#BKMK_msdyn_bookableresourceassociation_AsyncOperations)
- [msdyn_bookingalert_AsyncOperations](#BKMK_msdyn_bookingalert_AsyncOperations)
- [msdyn_bookingalertstatus_AsyncOperations](#BKMK_msdyn_bookingalertstatus_AsyncOperations)
- [msdyn_bookingchange_AsyncOperations](#BKMK_msdyn_bookingchange_AsyncOperations)
- [msdyn_bookingrule_AsyncOperations](#BKMK_msdyn_bookingrule_AsyncOperations)
- [msdyn_bookingsetupmetadata_AsyncOperations](#BKMK_msdyn_bookingsetupmetadata_AsyncOperations)
- [msdyn_businessclosure_AsyncOperations](#BKMK_msdyn_businessclosure_AsyncOperations)
- [msdyn_clientextension_AsyncOperations](#BKMK_msdyn_clientextension_AsyncOperations)
- [msdyn_configuration_AsyncOperations](#BKMK_msdyn_configuration_AsyncOperations)
- [msdyn_organizationalunit_AsyncOperations](#BKMK_msdyn_organizationalunit_AsyncOperations)
- [msdyn_priority_AsyncOperations](#BKMK_msdyn_priority_AsyncOperations)
- [msdyn_requirementcharacteristic_AsyncOperations](#BKMK_msdyn_requirementcharacteristic_AsyncOperations)
- [msdyn_requirementgroup_AsyncOperations](#BKMK_msdyn_requirementgroup_AsyncOperations)
- [msdyn_requirementorganizationunit_AsyncOperations](#BKMK_msdyn_requirementorganizationunit_AsyncOperations)
- [msdyn_requirementrelationship_AsyncOperations](#BKMK_msdyn_requirementrelationship_AsyncOperations)
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
- [msdyn_dimension_AsyncOperations](#BKMK_msdyn_dimension_AsyncOperations)
- [msdyn_dimensionfieldname_AsyncOperations](#BKMK_msdyn_dimensionfieldname_AsyncOperations)
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
- [msdyn_resourcecategorymarkuppricelevel_AsyncOperations](#BKMK_msdyn_resourcecategorymarkuppricelevel_AsyncOperations)
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
- [msdyn_customerassetcategory_AsyncOperations](#BKMK_msdyn_customerassetcategory_AsyncOperations)
- [msdyn_entitlementapplication_AsyncOperations](#BKMK_msdyn_entitlementapplication_AsyncOperations)
- [msdyn_fieldservicepricelistitem_AsyncOperations](#BKMK_msdyn_fieldservicepricelistitem_AsyncOperations)
- [msdyn_fieldservicesetting_AsyncOperations](#BKMK_msdyn_fieldservicesetting_AsyncOperations)
- [msdyn_fieldserviceslaconfiguration_AsyncOperations](#BKMK_msdyn_fieldserviceslaconfiguration_AsyncOperations)
- [msdyn_fieldservicesystemjob_AsyncOperations](#BKMK_msdyn_fieldservicesystemjob_AsyncOperations)
- [msdyn_incidenttype_AsyncOperations](#BKMK_msdyn_incidenttype_AsyncOperations)
- [msdyn_incidenttypecharacteristic_AsyncOperations](#BKMK_msdyn_incidenttypecharacteristic_AsyncOperations)
- [msdyn_incidenttypeproduct_AsyncOperations](#BKMK_msdyn_incidenttypeproduct_AsyncOperations)
- [msdyn_incidenttypeservice_AsyncOperations](#BKMK_msdyn_incidenttypeservice_AsyncOperations)
- [msdyn_incidenttypeservicetask_AsyncOperations](#BKMK_msdyn_incidenttypeservicetask_AsyncOperations)
- [msdyn_incidenttypessetup_AsyncOperations](#BKMK_msdyn_incidenttypessetup_AsyncOperations)
- [msdyn_incidenttype_requirementgroup_AsyncOperations](#BKMK_msdyn_incidenttype_requirementgroup_AsyncOperations)
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
- [msdyn_iotalert_AsyncOperations](#BKMK_msdyn_iotalert_AsyncOperations)
- [msdyn_iotdevice_AsyncOperations](#BKMK_msdyn_iotdevice_AsyncOperations)
- [msdyn_iotdevicecategory_AsyncOperations](#BKMK_msdyn_iotdevicecategory_AsyncOperations)
- [msdyn_iotdevicecommand_AsyncOperations](#BKMK_msdyn_iotdevicecommand_AsyncOperations)
- [msdyn_iotdevicecommanddefinition_AsyncOperations](#BKMK_msdyn_iotdevicecommanddefinition_AsyncOperations)
- [msdyn_iotdevicedatahistory_AsyncOperations](#BKMK_msdyn_iotdevicedatahistory_AsyncOperations)
- [msdyn_iotdeviceproperty_AsyncOperations](#BKMK_msdyn_iotdeviceproperty_AsyncOperations)
- [msdyn_iotdeviceregistrationhistory_AsyncOperations](#BKMK_msdyn_iotdeviceregistrationhistory_AsyncOperations)
- [msdyn_iotpropertydefinition_AsyncOperations](#BKMK_msdyn_iotpropertydefinition_AsyncOperations)
- [msdyn_iotsettings_AsyncOperations](#BKMK_msdyn_iotsettings_AsyncOperations)
- [msdyn_bpf_477c16f59170487b8b4dc895c5dcd09b_AsyncOperations](#BKMK_msdyn_bpf_477c16f59170487b8b4dc895c5dcd09b_AsyncOperations)
- [msdyn_entityconfiguration_AsyncOperations](#BKMK_msdyn_entityconfiguration_AsyncOperations)
- [msdyn_geofence_AsyncOperations](#BKMK_msdyn_geofence_AsyncOperations)
- [msdyn_geofenceevent_AsyncOperations](#BKMK_msdyn_geofenceevent_AsyncOperations)
- [msdyn_geofencingsettings_AsyncOperations](#BKMK_msdyn_geofencingsettings_AsyncOperations)
- [msdyn_connector_AsyncOperations](#BKMK_msdyn_connector_AsyncOperations)
- [theme_AsyncOperations](#BKMK_theme_AsyncOperations)
- [usermapping_AsyncOperations](#BKMK_usermapping_AsyncOperations)
- [interactionforemail_AsyncOperations](#BKMK_interactionforemail_AsyncOperations)
- [knowledgearticle_AsyncOperations](#BKMK_knowledgearticle_AsyncOperations)
- [post_AsyncOperations](#BKMK_post_AsyncOperations)
- [position_AsyncOperations](#BKMK_position_AsyncOperations)
- [KnowledgeBaseRecord_AsyncOperations](#BKMK_KnowledgeBaseRecord_AsyncOperations)
- [lk_asyncoperation_createdby](#BKMK_lk_asyncoperation_createdby)
- [MonthlyFiscalCalendar_AsyncOperations](#BKMK_MonthlyFiscalCalendar_AsyncOperations)
- [lk_asyncoperation_workflowactivationid](#BKMK_lk_asyncoperation_workflowactivationid)
- [Report_AsyncOperations](#BKMK_Report_AsyncOperations)
- [SocialActivity_AsyncOperations](#BKMK_SocialActivity_AsyncOperations)
- [Connection_Role_AsyncOperations](#BKMK_Connection_Role_AsyncOperations)
- [Team_AsyncOperations](#BKMK_Team_AsyncOperations)
- [AnnualFiscalCalendar_AsyncOperations](#BKMK_AnnualFiscalCalendar_AsyncOperations)
- [SharePointDocumentLocation_AsyncOperations](#BKMK_SharePointDocumentLocation_AsyncOperations)
- [PhoneCall_AsyncOperations](#BKMK_PhoneCall_AsyncOperations)
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
- [team_asyncoperation](#BKMK_team_asyncoperation)
- [lk_asyncoperation_modifiedby](#BKMK_lk_asyncoperation_modifiedby)
- [UserForm_AsyncOperations](#BKMK_UserForm_AsyncOperations)
- [TransactionCurrency_AsyncOperations](#BKMK_TransactionCurrency_AsyncOperations)
- [rollupfield_AsyncOperations](#BKMK_rollupfield_AsyncOperations)
- [Letter_AsyncOperations](#BKMK_Letter_AsyncOperations)
- [KbArticle_AsyncOperations](#BKMK_KbArticle_AsyncOperations)
- [RecurringAppointmentMaster_AsyncOperations](#BKMK_RecurringAppointmentMaster_AsyncOperations)
- [Task_AsyncOperations](#BKMK_Task_AsyncOperations)
- [BusinessUnitNewsArticle_AsyncOperations](#BKMK_BusinessUnitNewsArticle_AsyncOperations)
- [Connection_AsyncOperations](#BKMK_Connection_AsyncOperations)
- [SystemUser_AsyncOperations](#BKMK_SystemUser_AsyncOperations)
- [KbArticleTemplate_AsyncOperations](#BKMK_KbArticleTemplate_AsyncOperations)
- [SdkMessageProcessingStep_AsyncOperations](#BKMK_SdkMessageProcessingStep_AsyncOperations)
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


### <a name="BKMK_Territory_AsyncOperations"></a> Territory_AsyncOperations

**Added by**: Application Common Solution

See territory Entity [Territory_AsyncOperations](territory.md#BKMK_Territory_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_leadaddress_AsyncOperations"></a> leadaddress_AsyncOperations

**Added by**: Lead Management Solution

See leadaddress Entity [leadaddress_AsyncOperations](leadaddress.md#BKMK_leadaddress_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_Lead_AsyncOperations"></a> Lead_AsyncOperations

**Added by**: Lead Management Solution

See lead Entity [Lead_AsyncOperations](lead.md#BKMK_Lead_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_dynamicproperty_AsyncOperations"></a> dynamicproperty_AsyncOperations

**Added by**: Product Management Solution

See dynamicproperty Entity [dynamicproperty_AsyncOperations](dynamicproperty.md#BKMK_dynamicproperty_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_dynamicpropertyassociation_AsyncOperations"></a> dynamicpropertyassociation_AsyncOperations

**Added by**: Product Management Solution

See dynamicpropertyassociation Entity [dynamicpropertyassociation_AsyncOperations](dynamicpropertyassociation.md#BKMK_dynamicpropertyassociation_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_dynamicpropertyinstance_AsyncOperations"></a> dynamicpropertyinstance_AsyncOperations

**Added by**: Product Management Solution

See dynamicpropertyinstance Entity [dynamicpropertyinstance_AsyncOperations](dynamicpropertyinstance.md#BKMK_dynamicpropertyinstance_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_dynamicpropertyoptionsetitem_AsyncOperations"></a> dynamicpropertyoptionsetitem_AsyncOperations

**Added by**: Product Management Solution

See dynamicpropertyoptionsetitem Entity [dynamicpropertyoptionsetitem_AsyncOperations](dynamicpropertyoptionsetitem.md#BKMK_dynamicpropertyoptionsetitem_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_PriceLevel_AsyncOperations"></a> PriceLevel_AsyncOperations

**Added by**: Product Management Solution

See pricelevel Entity [PriceLevel_AsyncOperations](pricelevel.md#BKMK_PriceLevel_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_Product_AsyncOperations"></a> Product_AsyncOperations

**Added by**: Product Management Solution

See product Entity [Product_AsyncOperations](product.md#BKMK_Product_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_ProductAssociation_AsyncOperations"></a> ProductAssociation_AsyncOperations

**Added by**: Product Management Solution

See productassociation Entity [ProductAssociation_AsyncOperations](productassociation.md#BKMK_ProductAssociation_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_ProductPriceLevel_AsyncOperations"></a> ProductPriceLevel_AsyncOperations

**Added by**: Product Management Solution

See productpricelevel Entity [ProductPriceLevel_AsyncOperations](productpricelevel.md#BKMK_ProductPriceLevel_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_ProductSubstitute_AsyncOperations"></a> ProductSubstitute_AsyncOperations

**Added by**: Product Management Solution

See productsubstitute Entity [ProductSubstitute_AsyncOperations](productsubstitute.md#BKMK_ProductSubstitute_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_UoM_AsyncOperations"></a> UoM_AsyncOperations

**Added by**: Product Management Solution

See uom Entity [UoM_AsyncOperations](uom.md#BKMK_UoM_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_UoMSchedule_AsyncOperations"></a> UoMSchedule_AsyncOperations

**Added by**: Product Management Solution

See uomschedule Entity [UoMSchedule_AsyncOperations](uomschedule.md#BKMK_UoMSchedule_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_bookableresource_AsyncOperations"></a> bookableresource_AsyncOperations

**Added by**: Scheduling Solution

See bookableresource Entity [bookableresource_AsyncOperations](bookableresource.md#BKMK_bookableresource_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_bookableresourcebooking_AsyncOperations"></a> bookableresourcebooking_AsyncOperations

**Added by**: Scheduling Solution

See bookableresourcebooking Entity [bookableresourcebooking_AsyncOperations](bookableresourcebooking.md#BKMK_bookableresourcebooking_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_bookableresourcebookingheader_AsyncOperations"></a> bookableresourcebookingheader_AsyncOperations

**Added by**: Scheduling Solution

See bookableresourcebookingheader Entity [bookableresourcebookingheader_AsyncOperations](bookableresourcebookingheader.md#BKMK_bookableresourcebookingheader_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_bookableresourcecategory_AsyncOperations"></a> bookableresourcecategory_AsyncOperations

**Added by**: Scheduling Solution

See bookableresourcecategory Entity [bookableresourcecategory_AsyncOperations](bookableresourcecategory.md#BKMK_bookableresourcecategory_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_bookableresourcecategoryassn_AsyncOperations"></a> bookableresourcecategoryassn_AsyncOperations

**Added by**: Scheduling Solution

See bookableresourcecategoryassn Entity [bookableresourcecategoryassn_AsyncOperations](bookableresourcecategoryassn.md#BKMK_bookableresourcecategoryassn_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_bookableresourcecharacteristic_AsyncOperations"></a> bookableresourcecharacteristic_AsyncOperations

**Added by**: Scheduling Solution

See bookableresourcecharacteristic Entity [bookableresourcecharacteristic_AsyncOperations](bookableresourcecharacteristic.md#BKMK_bookableresourcecharacteristic_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_bookableresourcegroup_AsyncOperations"></a> bookableresourcegroup_AsyncOperations

**Added by**: Scheduling Solution

See bookableresourcegroup Entity [bookableresourcegroup_AsyncOperations](bookableresourcegroup.md#BKMK_bookableresourcegroup_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_bookingstatus_AsyncOperations"></a> bookingstatus_AsyncOperations

**Added by**: Scheduling Solution

See bookingstatus Entity [bookingstatus_AsyncOperations](bookingstatus.md#BKMK_bookingstatus_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_characteristic_AsyncOperations"></a> characteristic_AsyncOperations

**Added by**: Scheduling Solution

See characteristic Entity [characteristic_AsyncOperations](characteristic.md#BKMK_characteristic_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_ratingmodel_AsyncOperations"></a> ratingmodel_AsyncOperations

**Added by**: Scheduling Solution

See ratingmodel Entity [ratingmodel_AsyncOperations](ratingmodel.md#BKMK_ratingmodel_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_ratingvalue_AsyncOperations"></a> ratingvalue_AsyncOperations

**Added by**: Scheduling Solution

See ratingvalue Entity [ratingvalue_AsyncOperations](ratingvalue.md#BKMK_ratingvalue_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_BulkOperation_AsyncOperations"></a> BulkOperation_AsyncOperations

**Added by**: Marketing Solution

See bulkoperation Entity [BulkOperation_AsyncOperations](bulkoperation.md#BKMK_BulkOperation_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_BulkOperationLog_AsyncOperations"></a> BulkOperationLog_AsyncOperations

**Added by**: Marketing Solution

See bulkoperationlog Entity [BulkOperationLog_AsyncOperations](bulkoperationlog.md#BKMK_BulkOperationLog_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_Campaign_AsyncOperations"></a> Campaign_AsyncOperations

**Added by**: Marketing Solution

See campaign Entity [Campaign_AsyncOperations](campaign.md#BKMK_Campaign_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_CampaignActivity_AsyncOperations"></a> CampaignActivity_AsyncOperations

**Added by**: Marketing Solution

See campaignactivity Entity [CampaignActivity_AsyncOperations](campaignactivity.md#BKMK_CampaignActivity_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_CampaignResponse_AsyncOperations"></a> CampaignResponse_AsyncOperations

**Added by**: Marketing Solution

See campaignresponse Entity [CampaignResponse_AsyncOperations](campaignresponse.md#BKMK_CampaignResponse_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_List_AsyncOperations"></a> List_AsyncOperations

**Added by**: Marketing Solution

See list Entity [List_AsyncOperations](list.md#BKMK_List_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_msdyn_databaseversion_AsyncOperations"></a> msdyn_databaseversion_AsyncOperations

**Added by**: Solution Upgrade Infrastructure Solution

See msdyn_databaseversion Entity [msdyn_databaseversion_AsyncOperations](msdyn_databaseversion.md#BKMK_msdyn_databaseversion_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_msdyn_upgraderun_AsyncOperations"></a> msdyn_upgraderun_AsyncOperations

**Added by**: Solution Upgrade Infrastructure Solution

See msdyn_upgraderun Entity [msdyn_upgraderun_AsyncOperations](msdyn_upgraderun.md#BKMK_msdyn_upgraderun_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_msdyn_upgradestep_AsyncOperations"></a> msdyn_upgradestep_AsyncOperations

**Added by**: Solution Upgrade Infrastructure Solution

See msdyn_upgradestep Entity [msdyn_upgradestep_AsyncOperations](msdyn_upgradestep.md#BKMK_msdyn_upgradestep_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_msdyn_upgradeversion_AsyncOperations"></a> msdyn_upgradeversion_AsyncOperations

**Added by**: Solution Upgrade Infrastructure Solution

See msdyn_upgradeversion Entity [msdyn_upgradeversion_AsyncOperations](msdyn_upgradeversion.md#BKMK_msdyn_upgradeversion_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_ConstraintBasedGroup_AsyncOperations"></a> ConstraintBasedGroup_AsyncOperations

**Added by**: Service Solution

See constraintbasedgroup Entity [ConstraintBasedGroup_AsyncOperations](constraintbasedgroup.md#BKMK_ConstraintBasedGroup_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_Contract_AsyncOperations"></a> Contract_AsyncOperations

**Added by**: Service Solution

See contract Entity [Contract_AsyncOperations](contract.md#BKMK_Contract_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_ContractDetail_AsyncOperations"></a> ContractDetail_AsyncOperations

**Added by**: Service Solution

See contractdetail Entity [ContractDetail_AsyncOperations](contractdetail.md#BKMK_ContractDetail_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_ContractTemplate_AsyncOperations"></a> ContractTemplate_AsyncOperations

**Added by**: Service Solution

See contracttemplate Entity [ContractTemplate_AsyncOperations](contracttemplate.md#BKMK_ContractTemplate_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_entitlement_AsyncOperations"></a> entitlement_AsyncOperations

**Added by**: Service Solution

See entitlement Entity [entitlement_AsyncOperations](entitlement.md#BKMK_entitlement_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_entitlementchannel_AsyncOperations"></a> entitlementchannel_AsyncOperations

**Added by**: Service Solution

See entitlementchannel Entity [entitlementchannel_AsyncOperations](entitlementchannel.md#BKMK_entitlementchannel_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_entitlementtemplate_AsyncOperations"></a> entitlementtemplate_AsyncOperations

**Added by**: Service Solution

See entitlementtemplate Entity [entitlementtemplate_AsyncOperations](entitlementtemplate.md#BKMK_entitlementtemplate_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_entitlementtemplatechannel_AsyncOperations"></a> entitlementtemplatechannel_AsyncOperations

**Added by**: Service Solution

See entitlementtemplatechannel Entity [entitlementtemplatechannel_AsyncOperations](entitlementtemplatechannel.md#BKMK_entitlementtemplatechannel_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_Equipment_AsyncOperations"></a> Equipment_AsyncOperations

**Added by**: Service Solution

See equipment Entity [Equipment_AsyncOperations](equipment.md#BKMK_Equipment_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_Incident_AsyncOperations"></a> Incident_AsyncOperations

**Added by**: Service Solution

See incident Entity [Incident_AsyncOperations](incident.md#BKMK_Incident_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_IncidentResolution_AsyncOperations"></a> IncidentResolution_AsyncOperations

**Added by**: Service Solution

See incidentresolution Entity [IncidentResolution_AsyncOperations](incidentresolution.md#BKMK_IncidentResolution_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_knowledgearticleincident_AsyncOperations"></a> knowledgearticleincident_AsyncOperations

**Added by**: Service Solution

See knowledgearticleincident Entity [knowledgearticleincident_AsyncOperations](knowledgearticleincident.md#BKMK_knowledgearticleincident_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_phonetocaseprocess_AsyncOperations"></a> phonetocaseprocess_AsyncOperations

**Added by**: Service Solution

See phonetocaseprocess Entity [phonetocaseprocess_AsyncOperations](phonetocaseprocess.md#BKMK_phonetocaseprocess_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_Resource_AsyncOperations"></a> Resource_AsyncOperations

**Added by**: Service Solution

See resource Entity [Resource_AsyncOperations](resource.md#BKMK_Resource_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_ResourceGroup_AsyncOperations"></a> ResourceGroup_AsyncOperations

**Added by**: Service Solution

See resourcegroup Entity [ResourceGroup_AsyncOperations](resourcegroup.md#BKMK_ResourceGroup_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_ResourceSpec_AsyncOperations"></a> ResourceSpec_AsyncOperations

**Added by**: Service Solution

See resourcespec Entity [ResourceSpec_AsyncOperations](resourcespec.md#BKMK_ResourceSpec_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_Service_AsyncOperations"></a> Service_AsyncOperations

**Added by**: Service Solution

See service Entity [Service_AsyncOperations](service.md#BKMK_Service_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_ServiceAppointment_AsyncOperations"></a> ServiceAppointment_AsyncOperations

**Added by**: Service Solution

See serviceappointment Entity [ServiceAppointment_AsyncOperations](serviceappointment.md#BKMK_ServiceAppointment_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_Site_AsyncOperations"></a> Site_AsyncOperations

**Added by**: Service Solution

See site Entity [Site_AsyncOperations](site.md#BKMK_Site_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_entitlemententityallocationtypemapping_AsyncOperations"></a> entitlemententityallocationtypemapping_AsyncOperations

**Added by**: Service Patch Solution

See entitlemententityallocationtypemapping Entity [entitlemententityallocationtypemapping_AsyncOperations](entitlemententityallocationtypemapping.md#BKMK_entitlemententityallocationtypemapping_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_msdyn_callablecontext_AsyncOperations"></a> msdyn_callablecontext_AsyncOperations

**Added by**: Playbook Solution

See msdyn_callablecontext Entity [msdyn_callablecontext_AsyncOperations](msdyn_callablecontext.md#BKMK_msdyn_callablecontext_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_msdyn_playbookactivity_AsyncOperations"></a> msdyn_playbookactivity_AsyncOperations

**Added by**: Playbook Solution

See msdyn_playbookactivity Entity [msdyn_playbookactivity_AsyncOperations](msdyn_playbookactivity.md#BKMK_msdyn_playbookactivity_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_msdyn_playbookactivityattribute_AsyncOperations"></a> msdyn_playbookactivityattribute_AsyncOperations

**Added by**: Playbook Solution

See msdyn_playbookactivityattribute Entity [msdyn_playbookactivityattribute_AsyncOperations](msdyn_playbookactivityattribute.md#BKMK_msdyn_playbookactivityattribute_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_msdyn_playbookcategory_AsyncOperations"></a> msdyn_playbookcategory_AsyncOperations

**Added by**: Playbook Solution

See msdyn_playbookcategory Entity [msdyn_playbookcategory_AsyncOperations](msdyn_playbookcategory.md#BKMK_msdyn_playbookcategory_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_msdyn_playbookinstance_AsyncOperations"></a> msdyn_playbookinstance_AsyncOperations

**Added by**: Playbook Solution

See msdyn_playbookinstance Entity [msdyn_playbookinstance_AsyncOperations](msdyn_playbookinstance.md#BKMK_msdyn_playbookinstance_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_msdyn_playbooktemplate_AsyncOperations"></a> msdyn_playbooktemplate_AsyncOperations

**Added by**: Playbook Solution

See msdyn_playbooktemplate Entity [msdyn_playbooktemplate_AsyncOperations](msdyn_playbooktemplate.md#BKMK_msdyn_playbooktemplate_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_Discount_AsyncOperations"></a> Discount_AsyncOperations

**Added by**: Sales Solution

See discount Entity [Discount_AsyncOperations](discount.md#BKMK_Discount_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_DiscountType_AsyncOperations"></a> DiscountType_AsyncOperations

**Added by**: Sales Solution

See discounttype Entity [DiscountType_AsyncOperations](discounttype.md#BKMK_DiscountType_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_Invoice_AsyncOperations"></a> Invoice_AsyncOperations

**Added by**: Sales Solution

See invoice Entity [Invoice_AsyncOperations](invoice.md#BKMK_Invoice_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_InvoiceDetail_AsyncOperations"></a> InvoiceDetail_AsyncOperations

**Added by**: Sales Solution

See invoicedetail Entity [InvoiceDetail_AsyncOperations](invoicedetail.md#BKMK_InvoiceDetail_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_leadtoopportunitysalesprocess_AsyncOperations"></a> leadtoopportunitysalesprocess_AsyncOperations

**Added by**: Sales Solution

See leadtoopportunitysalesprocess Entity [leadtoopportunitysalesprocess_AsyncOperations](leadtoopportunitysalesprocess.md#BKMK_leadtoopportunitysalesprocess_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_Opportunity_AsyncOperations"></a> Opportunity_AsyncOperations

**Added by**: Sales Solution

See opportunity Entity [Opportunity_AsyncOperations](opportunity.md#BKMK_Opportunity_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_OpportunityClose_AsyncOperations"></a> OpportunityClose_AsyncOperations

**Added by**: Sales Solution

See opportunityclose Entity [OpportunityClose_AsyncOperations](opportunityclose.md#BKMK_OpportunityClose_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_OpportunityProduct_AsyncOperations"></a> OpportunityProduct_AsyncOperations

**Added by**: Sales Solution

See opportunityproduct Entity [OpportunityProduct_AsyncOperations](opportunityproduct.md#BKMK_OpportunityProduct_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_opportunitysalesprocess_AsyncOperations"></a> opportunitysalesprocess_AsyncOperations

**Added by**: Sales Solution

See opportunitysalesprocess Entity [opportunitysalesprocess_AsyncOperations](opportunitysalesprocess.md#BKMK_opportunitysalesprocess_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_OrderClose_AsyncOperations"></a> OrderClose_AsyncOperations

**Added by**: Sales Solution

See orderclose Entity [OrderClose_AsyncOperations](orderclose.md#BKMK_OrderClose_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_Quote_AsyncOperations"></a> Quote_AsyncOperations

**Added by**: Sales Solution

See quote Entity [Quote_AsyncOperations](quote.md#BKMK_Quote_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_QuoteClose_AsyncOperations"></a> QuoteClose_AsyncOperations

**Added by**: Sales Solution

See quoteclose Entity [QuoteClose_AsyncOperations](quoteclose.md#BKMK_QuoteClose_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_QuoteDetail_AsyncOperations"></a> QuoteDetail_AsyncOperations

**Added by**: Sales Solution

See quotedetail Entity [QuoteDetail_AsyncOperations](quotedetail.md#BKMK_QuoteDetail_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_SalesLiterature_AsyncOperations"></a> SalesLiterature_AsyncOperations

**Added by**: Sales Solution

See salesliterature Entity [SalesLiterature_AsyncOperations](salesliterature.md#BKMK_SalesLiterature_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_SalesLiteratureItem_AsyncOperations"></a> SalesLiteratureItem_AsyncOperations

**Added by**: Sales Solution

See salesliteratureitem Entity [SalesLiteratureItem_AsyncOperations](salesliteratureitem.md#BKMK_SalesLiteratureItem_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_SalesOrder_AsyncOperations"></a> SalesOrder_AsyncOperations

**Added by**: Sales Solution

See salesorder Entity [SalesOrder_AsyncOperations](salesorder.md#BKMK_SalesOrder_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_SalesOrderDetail_AsyncOperations"></a> SalesOrderDetail_AsyncOperations

**Added by**: Sales Solution

See salesorderdetail Entity [SalesOrderDetail_AsyncOperations](salesorderdetail.md#BKMK_SalesOrderDetail_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_Competitor_AsyncOperations"></a> Competitor_AsyncOperations

**Added by**: Sales Solution

See competitor Entity [Competitor_AsyncOperations](competitor.md#BKMK_Competitor_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_adminsettingsentity_AsyncOperations"></a> adminsettingsentity_AsyncOperations

**Added by**: Sales Patch Solution

See adminsettingsentity Entity [adminsettingsentity_AsyncOperations](adminsettingsentity.md#BKMK_adminsettingsentity_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_msdyn_forecastdefinition_AsyncOperations"></a> msdyn_forecastdefinition_AsyncOperations

**Added by**: Forecasting Solution

See msdyn_forecastdefinition Entity [msdyn_forecastdefinition_AsyncOperations](msdyn_forecastdefinition.md#BKMK_msdyn_forecastdefinition_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_msdyn_forecastinstance_AsyncOperations"></a> msdyn_forecastinstance_AsyncOperations

**Added by**: Forecasting Solution

See msdyn_forecastinstance Entity [msdyn_forecastinstance_AsyncOperations](msdyn_forecastinstance.md#BKMK_msdyn_forecastinstance_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_msdyn_forecastrecurrence_AsyncOperations"></a> msdyn_forecastrecurrence_AsyncOperations

**Added by**: Forecasting Solution

See msdyn_forecastrecurrence Entity [msdyn_forecastrecurrence_AsyncOperations](msdyn_forecastrecurrence.md#BKMK_msdyn_forecastrecurrence_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_msdyn_relationshipinsightsunifiedconfig_AsyncOperations"></a> msdyn_relationshipinsightsunifiedconfig_AsyncOperations

**Added by**: SI Common Solution

See msdyn_relationshipinsightsunifiedconfig Entity [msdyn_relationshipinsightsunifiedconfig_AsyncOperations](msdyn_relationshipinsightsunifiedconfig.md#BKMK_msdyn_relationshipinsightsunifiedconfig_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_msdyn_siconfig_AsyncOperations"></a> msdyn_siconfig_AsyncOperations

**Added by**: SI Common Solution

See msdyn_siconfig Entity [msdyn_siconfig_AsyncOperations](msdyn_siconfig.md#BKMK_msdyn_siconfig_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_msdyn_untrackedappointment_AsyncOperations"></a> msdyn_untrackedappointment_AsyncOperations

**Added by**: AutoDataCapture Solution

See msdyn_untrackedappointment Entity [msdyn_untrackedappointment_AsyncOperations](msdyn_untrackedappointment.md#BKMK_msdyn_untrackedappointment_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_msdyn_notesanalysisconfig_AsyncOperations"></a> msdyn_notesanalysisconfig_AsyncOperations

**Added by**: Notesanalysis Solution

See msdyn_notesanalysisconfig Entity [msdyn_notesanalysisconfig_AsyncOperations](msdyn_notesanalysisconfig.md#BKMK_msdyn_notesanalysisconfig_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_msdyn_icebreakersconfig_AsyncOperations"></a> msdyn_icebreakersconfig_AsyncOperations

**Added by**: Talking points Solution

See msdyn_icebreakersconfig Entity [msdyn_icebreakersconfig_AsyncOperations](msdyn_icebreakersconfig.md#BKMK_msdyn_icebreakersconfig_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_msdyn_postalbum_AsyncOperations"></a> msdyn_postalbum_AsyncOperations

**Added by**: Activity Feeds Solution

See msdyn_postalbum Entity [msdyn_postalbum_AsyncOperations](msdyn_postalbum.md#BKMK_msdyn_postalbum_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_msdyn_postconfig_AsyncOperations"></a> msdyn_postconfig_AsyncOperations

**Added by**: Activity Feeds Solution

See msdyn_postconfig Entity [msdyn_postconfig_AsyncOperations](msdyn_postconfig.md#BKMK_msdyn_postconfig_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_msdyn_postruleconfig_AsyncOperations"></a> msdyn_postruleconfig_AsyncOperations

**Added by**: Activity Feeds Solution

See msdyn_postruleconfig Entity [msdyn_postruleconfig_AsyncOperations](msdyn_postruleconfig.md#BKMK_msdyn_postruleconfig_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_msdyn_wallsavedquery_AsyncOperations"></a> msdyn_wallsavedquery_AsyncOperations

**Added by**: Activity Feeds Solution

See msdyn_wallsavedquery Entity [msdyn_wallsavedquery_AsyncOperations](msdyn_wallsavedquery.md#BKMK_msdyn_wallsavedquery_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_msdyn_wallsavedqueryusersettings_AsyncOperations"></a> msdyn_wallsavedqueryusersettings_AsyncOperations

**Added by**: Activity Feeds Solution

See msdyn_wallsavedqueryusersettings Entity [msdyn_wallsavedqueryusersettings_AsyncOperations](msdyn_wallsavedqueryusersettings.md#BKMK_msdyn_wallsavedqueryusersettings_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_msdyn_teamscollaboration_AsyncOperations"></a> msdyn_teamscollaboration_AsyncOperations

**Added by**: This solution contains Office Productivity implementation Solution

See msdyn_teamscollaboration Entity [msdyn_teamscollaboration_AsyncOperations](msdyn_teamscollaboration.md#BKMK_msdyn_teamscollaboration_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_msdyn_actual_AsyncOperations"></a> msdyn_actual_AsyncOperations

**Added by**: Universal Resource Scheduling Solution

See msdyn_actual Entity [msdyn_actual_AsyncOperations](msdyn_actual.md#BKMK_msdyn_actual_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_msdyn_bookableresourceassociation_AsyncOperations"></a> msdyn_bookableresourceassociation_AsyncOperations

**Added by**: Universal Resource Scheduling Solution

See msdyn_bookableresourceassociation Entity [msdyn_bookableresourceassociation_AsyncOperations](msdyn_bookableresourceassociation.md#BKMK_msdyn_bookableresourceassociation_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_msdyn_bookingalert_AsyncOperations"></a> msdyn_bookingalert_AsyncOperations

**Added by**: Active Solution Solution

See msdyn_bookingalert Entity [msdyn_bookingalert_AsyncOperations](msdyn_bookingalert.md#BKMK_msdyn_bookingalert_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_msdyn_bookingalertstatus_AsyncOperations"></a> msdyn_bookingalertstatus_AsyncOperations

**Added by**: Universal Resource Scheduling Solution

See msdyn_bookingalertstatus Entity [msdyn_bookingalertstatus_AsyncOperations](msdyn_bookingalertstatus.md#BKMK_msdyn_bookingalertstatus_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_msdyn_bookingchange_AsyncOperations"></a> msdyn_bookingchange_AsyncOperations

**Added by**: Universal Resource Scheduling Solution

See msdyn_bookingchange Entity [msdyn_bookingchange_AsyncOperations](msdyn_bookingchange.md#BKMK_msdyn_bookingchange_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_msdyn_bookingrule_AsyncOperations"></a> msdyn_bookingrule_AsyncOperations

**Added by**: Universal Resource Scheduling Solution

See msdyn_bookingrule Entity [msdyn_bookingrule_AsyncOperations](msdyn_bookingrule.md#BKMK_msdyn_bookingrule_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_msdyn_bookingsetupmetadata_AsyncOperations"></a> msdyn_bookingsetupmetadata_AsyncOperations

**Added by**: Universal Resource Scheduling Solution

See msdyn_bookingsetupmetadata Entity [msdyn_bookingsetupmetadata_AsyncOperations](msdyn_bookingsetupmetadata.md#BKMK_msdyn_bookingsetupmetadata_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_msdyn_businessclosure_AsyncOperations"></a> msdyn_businessclosure_AsyncOperations

**Added by**: Universal Resource Scheduling Solution

See msdyn_businessclosure Entity [msdyn_businessclosure_AsyncOperations](msdyn_businessclosure.md#BKMK_msdyn_businessclosure_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_msdyn_clientextension_AsyncOperations"></a> msdyn_clientextension_AsyncOperations

**Added by**: Universal Resource Scheduling Solution

See msdyn_clientextension Entity [msdyn_clientextension_AsyncOperations](msdyn_clientextension.md#BKMK_msdyn_clientextension_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_msdyn_configuration_AsyncOperations"></a> msdyn_configuration_AsyncOperations

**Added by**: Universal Resource Scheduling Solution

See msdyn_configuration Entity [msdyn_configuration_AsyncOperations](msdyn_configuration.md#BKMK_msdyn_configuration_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_msdyn_organizationalunit_AsyncOperations"></a> msdyn_organizationalunit_AsyncOperations

**Added by**: Universal Resource Scheduling Solution

See msdyn_organizationalunit Entity [msdyn_organizationalunit_AsyncOperations](msdyn_organizationalunit.md#BKMK_msdyn_organizationalunit_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_msdyn_priority_AsyncOperations"></a> msdyn_priority_AsyncOperations

**Added by**: Universal Resource Scheduling Solution

See msdyn_priority Entity [msdyn_priority_AsyncOperations](msdyn_priority.md#BKMK_msdyn_priority_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_msdyn_requirementcharacteristic_AsyncOperations"></a> msdyn_requirementcharacteristic_AsyncOperations

**Added by**: Universal Resource Scheduling Solution

See msdyn_requirementcharacteristic Entity [msdyn_requirementcharacteristic_AsyncOperations](msdyn_requirementcharacteristic.md#BKMK_msdyn_requirementcharacteristic_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_msdyn_requirementgroup_AsyncOperations"></a> msdyn_requirementgroup_AsyncOperations

**Added by**: Universal Resource Scheduling Solution

See msdyn_requirementgroup Entity [msdyn_requirementgroup_AsyncOperations](msdyn_requirementgroup.md#BKMK_msdyn_requirementgroup_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_msdyn_requirementorganizationunit_AsyncOperations"></a> msdyn_requirementorganizationunit_AsyncOperations

**Added by**: Universal Resource Scheduling Solution

See msdyn_requirementorganizationunit Entity [msdyn_requirementorganizationunit_AsyncOperations](msdyn_requirementorganizationunit.md#BKMK_msdyn_requirementorganizationunit_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_msdyn_requirementrelationship_AsyncOperations"></a> msdyn_requirementrelationship_AsyncOperations

**Added by**: Universal Resource Scheduling Solution

See msdyn_requirementrelationship Entity [msdyn_requirementrelationship_AsyncOperations](msdyn_requirementrelationship.md#BKMK_msdyn_requirementrelationship_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_msdyn_requirementresourcecategory_AsyncOperations"></a> msdyn_requirementresourcecategory_AsyncOperations

**Added by**: Universal Resource Scheduling Solution

See msdyn_requirementresourcecategory Entity [msdyn_requirementresourcecategory_AsyncOperations](msdyn_requirementresourcecategory.md#BKMK_msdyn_requirementresourcecategory_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_msdyn_requirementresourcepreference_AsyncOperations"></a> msdyn_requirementresourcepreference_AsyncOperations

**Added by**: Universal Resource Scheduling Solution

See msdyn_requirementresourcepreference Entity [msdyn_requirementresourcepreference_AsyncOperations](msdyn_requirementresourcepreference.md#BKMK_msdyn_requirementresourcepreference_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_msdyn_requirementstatus_AsyncOperations"></a> msdyn_requirementstatus_AsyncOperations

**Added by**: Universal Resource Scheduling Solution

See msdyn_requirementstatus Entity [msdyn_requirementstatus_AsyncOperations](msdyn_requirementstatus.md#BKMK_msdyn_requirementstatus_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_msdyn_resourcerequirement_AsyncOperations"></a> msdyn_resourcerequirement_AsyncOperations

**Added by**: Universal Resource Scheduling Solution

See msdyn_resourcerequirement Entity [msdyn_resourcerequirement_AsyncOperations](msdyn_resourcerequirement.md#BKMK_msdyn_resourcerequirement_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_msdyn_resourcerequirementdetail_AsyncOperations"></a> msdyn_resourcerequirementdetail_AsyncOperations

**Added by**: Universal Resource Scheduling Solution

See msdyn_resourcerequirementdetail Entity [msdyn_resourcerequirementdetail_AsyncOperations](msdyn_resourcerequirementdetail.md#BKMK_msdyn_resourcerequirementdetail_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_msdyn_resourceterritory_AsyncOperations"></a> msdyn_resourceterritory_AsyncOperations

**Added by**: Universal Resource Scheduling Solution

See msdyn_resourceterritory Entity [msdyn_resourceterritory_AsyncOperations](msdyn_resourceterritory.md#BKMK_msdyn_resourceterritory_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_msdyn_scheduleboardsetting_AsyncOperations"></a> msdyn_scheduleboardsetting_AsyncOperations

**Added by**: Universal Resource Scheduling Solution

See msdyn_scheduleboardsetting Entity [msdyn_scheduleboardsetting_AsyncOperations](msdyn_scheduleboardsetting.md#BKMK_msdyn_scheduleboardsetting_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_msdyn_schedulingparameter_AsyncOperations"></a> msdyn_schedulingparameter_AsyncOperations

**Added by**: Universal Resource Scheduling Solution

See msdyn_schedulingparameter Entity [msdyn_schedulingparameter_AsyncOperations](msdyn_schedulingparameter.md#BKMK_msdyn_schedulingparameter_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_msdyn_systemuserschedulersetting_AsyncOperations"></a> msdyn_systemuserschedulersetting_AsyncOperations

**Added by**: Universal Resource Scheduling Solution

See msdyn_systemuserschedulersetting Entity [msdyn_systemuserschedulersetting_AsyncOperations](msdyn_systemuserschedulersetting.md#BKMK_msdyn_systemuserschedulersetting_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_msdyn_timegroup_AsyncOperations"></a> msdyn_timegroup_AsyncOperations

**Added by**: Universal Resource Scheduling Solution

See msdyn_timegroup Entity [msdyn_timegroup_AsyncOperations](msdyn_timegroup.md#BKMK_msdyn_timegroup_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_msdyn_timegroupdetail_AsyncOperations"></a> msdyn_timegroupdetail_AsyncOperations

**Added by**: Universal Resource Scheduling Solution

See msdyn_timegroupdetail Entity [msdyn_timegroupdetail_AsyncOperations](msdyn_timegroupdetail.md#BKMK_msdyn_timegroupdetail_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_msdyn_transactionorigin_AsyncOperations"></a> msdyn_transactionorigin_AsyncOperations

**Added by**: Universal Resource Scheduling Solution

See msdyn_transactionorigin Entity [msdyn_transactionorigin_AsyncOperations](msdyn_transactionorigin.md#BKMK_msdyn_transactionorigin_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_msdyn_workhourtemplate_AsyncOperations"></a> msdyn_workhourtemplate_AsyncOperations

**Added by**: Universal Resource Scheduling Solution

See msdyn_workhourtemplate Entity [msdyn_workhourtemplate_AsyncOperations](msdyn_workhourtemplate.md#BKMK_msdyn_workhourtemplate_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_msdyn_accountpricelist_AsyncOperations"></a> msdyn_accountpricelist_AsyncOperations

**Added by**: Project Service Automation Solution

See msdyn_accountpricelist Entity [msdyn_accountpricelist_AsyncOperations](msdyn_accountpricelist.md#BKMK_msdyn_accountpricelist_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_msdyn_approval_AsyncOperations"></a> msdyn_approval_AsyncOperations

**Added by**: Active Solution Solution

See msdyn_approval Entity [msdyn_approval_AsyncOperations](msdyn_approval.md#BKMK_msdyn_approval_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_msdyn_batchjob_AsyncOperations"></a> msdyn_batchjob_AsyncOperations

**Added by**: Project Service Automation Solution

See msdyn_batchjob Entity [msdyn_batchjob_AsyncOperations](msdyn_batchjob.md#BKMK_msdyn_batchjob_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_msdyn_bpf_665e73aa18c247d886bfc50499c73b82_AsyncOperations"></a> msdyn_bpf_665e73aa18c247d886bfc50499c73b82_AsyncOperations

**Added by**: Project Service Automation Solution

See msdyn_bpf_665e73aa18c247d886bfc50499c73b82 Entity [msdyn_bpf_665e73aa18c247d886bfc50499c73b82_AsyncOperations](msdyn_bpf_665e73aa18c247d886bfc50499c73b82.md#BKMK_msdyn_bpf_665e73aa18c247d886bfc50499c73b82_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_msdyn_bpf_d8f9dc7f099f44db9d641dd81fbd470d_AsyncOperations"></a> msdyn_bpf_d8f9dc7f099f44db9d641dd81fbd470d_AsyncOperations

**Added by**: Project Service Automation Solution

See msdyn_bpf_d8f9dc7f099f44db9d641dd81fbd470d Entity [msdyn_bpf_d8f9dc7f099f44db9d641dd81fbd470d_AsyncOperations](msdyn_bpf_d8f9dc7f099f44db9d641dd81fbd470d.md#BKMK_msdyn_bpf_d8f9dc7f099f44db9d641dd81fbd470d_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_msdyn_characteristicreqforteammember_AsyncOperations"></a> msdyn_characteristicreqforteammember_AsyncOperations

**Added by**: Project Service Automation Solution

See msdyn_characteristicreqforteammember Entity [msdyn_characteristicreqforteammember_AsyncOperations](msdyn_characteristicreqforteammember.md#BKMK_msdyn_characteristicreqforteammember_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_msdyn_contactpricelist_AsyncOperations"></a> msdyn_contactpricelist_AsyncOperations

**Added by**: Project Service Automation Solution

See msdyn_contactpricelist Entity [msdyn_contactpricelist_AsyncOperations](msdyn_contactpricelist.md#BKMK_msdyn_contactpricelist_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_msdyn_contractlineinvoiceschedule_AsyncOperations"></a> msdyn_contractlineinvoiceschedule_AsyncOperations

**Added by**: Project Service Automation Solution

See msdyn_contractlineinvoiceschedule Entity [msdyn_contractlineinvoiceschedule_AsyncOperations](msdyn_contractlineinvoiceschedule.md#BKMK_msdyn_contractlineinvoiceschedule_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_msdyn_contractlinescheduleofvalue_AsyncOperations"></a> msdyn_contractlinescheduleofvalue_AsyncOperations

**Added by**: Project Service Automation Solution

See msdyn_contractlinescheduleofvalue Entity [msdyn_contractlinescheduleofvalue_AsyncOperations](msdyn_contractlinescheduleofvalue.md#BKMK_msdyn_contractlinescheduleofvalue_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_msdyn_dataexport_AsyncOperations"></a> msdyn_dataexport_AsyncOperations

**Added by**: Project Service Automation Solution

See msdyn_dataexport Entity [msdyn_dataexport_AsyncOperations](msdyn_dataexport.md#BKMK_msdyn_dataexport_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_msdyn_delegation_AsyncOperations"></a> msdyn_delegation_AsyncOperations

**Added by**: Project Service Automation Solution

See msdyn_delegation Entity [msdyn_delegation_AsyncOperations](msdyn_delegation.md#BKMK_msdyn_delegation_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_msdyn_dimension_AsyncOperations"></a> msdyn_dimension_AsyncOperations

**Added by**: Project Service Automation Solution

See msdyn_dimension Entity [msdyn_dimension_AsyncOperations](msdyn_dimension.md#BKMK_msdyn_dimension_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_msdyn_dimensionfieldname_AsyncOperations"></a> msdyn_dimensionfieldname_AsyncOperations

**Added by**: Project Service Automation Solution

See msdyn_dimensionfieldname Entity [msdyn_dimensionfieldname_AsyncOperations](msdyn_dimensionfieldname.md#BKMK_msdyn_dimensionfieldname_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_msdyn_estimate_AsyncOperations"></a> msdyn_estimate_AsyncOperations

**Added by**: Project Service Automation Solution

See msdyn_estimate Entity [msdyn_estimate_AsyncOperations](msdyn_estimate.md#BKMK_msdyn_estimate_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_msdyn_estimateline_AsyncOperations"></a> msdyn_estimateline_AsyncOperations

**Added by**: Project Service Automation Solution

See msdyn_estimateline Entity [msdyn_estimateline_AsyncOperations](msdyn_estimateline.md#BKMK_msdyn_estimateline_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_msdyn_expense_AsyncOperations"></a> msdyn_expense_AsyncOperations

**Added by**: Project Service Automation Solution

See msdyn_expense Entity [msdyn_expense_AsyncOperations](msdyn_expense.md#BKMK_msdyn_expense_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_msdyn_expensecategory_AsyncOperations"></a> msdyn_expensecategory_AsyncOperations

**Added by**: Project Service Automation Solution

See msdyn_expensecategory Entity [msdyn_expensecategory_AsyncOperations](msdyn_expensecategory.md#BKMK_msdyn_expensecategory_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_msdyn_expensereceipt_AsyncOperations"></a> msdyn_expensereceipt_AsyncOperations

**Added by**: Project Service Automation Solution

See msdyn_expensereceipt Entity [msdyn_expensereceipt_AsyncOperations](msdyn_expensereceipt.md#BKMK_msdyn_expensereceipt_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_msdyn_fact_AsyncOperations"></a> msdyn_fact_AsyncOperations

**Added by**: Project Service Automation Solution

See msdyn_fact Entity [msdyn_fact_AsyncOperations](msdyn_fact.md#BKMK_msdyn_fact_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_msdyn_fieldcomputation_AsyncOperations"></a> msdyn_fieldcomputation_AsyncOperations

**Added by**: Project Service Automation Solution

See msdyn_fieldcomputation Entity [msdyn_fieldcomputation_AsyncOperations](msdyn_fieldcomputation.md#BKMK_msdyn_fieldcomputation_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_msdyn_findworkevent_AsyncOperations"></a> msdyn_findworkevent_AsyncOperations

**Added by**: Project Service Automation Solution

See msdyn_findworkevent Entity [msdyn_findworkevent_AsyncOperations](msdyn_findworkevent.md#BKMK_msdyn_findworkevent_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_msdyn_integrationjob_AsyncOperations"></a> msdyn_integrationjob_AsyncOperations

**Added by**: Project Service Automation Solution

See msdyn_integrationjob Entity [msdyn_integrationjob_AsyncOperations](msdyn_integrationjob.md#BKMK_msdyn_integrationjob_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_msdyn_integrationjobdetail_AsyncOperations"></a> msdyn_integrationjobdetail_AsyncOperations

**Added by**: Project Service Automation Solution

See msdyn_integrationjobdetail Entity [msdyn_integrationjobdetail_AsyncOperations](msdyn_integrationjobdetail.md#BKMK_msdyn_integrationjobdetail_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_msdyn_invoicefrequency_AsyncOperations"></a> msdyn_invoicefrequency_AsyncOperations

**Added by**: Project Service Automation Solution

See msdyn_invoicefrequency Entity [msdyn_invoicefrequency_AsyncOperations](msdyn_invoicefrequency.md#BKMK_msdyn_invoicefrequency_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_msdyn_invoicefrequencydetail_AsyncOperations"></a> msdyn_invoicefrequencydetail_AsyncOperations

**Added by**: Project Service Automation Solution

See msdyn_invoicefrequencydetail Entity [msdyn_invoicefrequencydetail_AsyncOperations](msdyn_invoicefrequencydetail.md#BKMK_msdyn_invoicefrequencydetail_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_msdyn_invoicelinetransaction_AsyncOperations"></a> msdyn_invoicelinetransaction_AsyncOperations

**Added by**: Project Service Automation Solution

See msdyn_invoicelinetransaction Entity [msdyn_invoicelinetransaction_AsyncOperations](msdyn_invoicelinetransaction.md#BKMK_msdyn_invoicelinetransaction_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_msdyn_journal_AsyncOperations"></a> msdyn_journal_AsyncOperations

**Added by**: Project Service Automation Solution

See msdyn_journal Entity [msdyn_journal_AsyncOperations](msdyn_journal.md#BKMK_msdyn_journal_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_msdyn_journalline_AsyncOperations"></a> msdyn_journalline_AsyncOperations

**Added by**: Project Service Automation Solution

See msdyn_journalline Entity [msdyn_journalline_AsyncOperations](msdyn_journalline.md#BKMK_msdyn_journalline_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_msdyn_mlresultcache_AsyncOperations"></a> msdyn_mlresultcache_AsyncOperations

**Added by**: Project Service Automation Solution

See msdyn_mlresultcache Entity [msdyn_mlresultcache_AsyncOperations](msdyn_mlresultcache.md#BKMK_msdyn_mlresultcache_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_msdyn_opportunitylineresourcecategory_AsyncOperations"></a> msdyn_opportunitylineresourcecategory_AsyncOperations

**Added by**: Project Service Automation Solution

See msdyn_opportunitylineresourcecategory Entity [msdyn_opportunitylineresourcecategory_AsyncOperations](msdyn_opportunitylineresourcecategory.md#BKMK_msdyn_opportunitylineresourcecategory_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_msdyn_opportunitylinetransaction_AsyncOperations"></a> msdyn_opportunitylinetransaction_AsyncOperations

**Added by**: Project Service Automation Solution

See msdyn_opportunitylinetransaction Entity [msdyn_opportunitylinetransaction_AsyncOperations](msdyn_opportunitylinetransaction.md#BKMK_msdyn_opportunitylinetransaction_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_msdyn_opportunitylinetransactioncategory_AsyncOperations"></a> msdyn_opportunitylinetransactioncategory_AsyncOperations

**Added by**: Project Service Automation Solution

See msdyn_opportunitylinetransactioncategory Entity [msdyn_opportunitylinetransactioncategory_AsyncOperations](msdyn_opportunitylinetransactioncategory.md#BKMK_msdyn_opportunitylinetransactioncategory_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_msdyn_opportunitylinetransactionclassificatio_AsyncOperations"></a> msdyn_opportunitylinetransactionclassificatio_AsyncOperations

**Added by**: Project Service Automation Solution

See msdyn_opportunitylinetransactionclassificatio Entity [msdyn_opportunitylinetransactionclassificatio_AsyncOperations](msdyn_opportunitylinetransactionclassificatio.md#BKMK_msdyn_opportunitylinetransactionclassificatio_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_msdyn_opportunitypricelist_AsyncOperations"></a> msdyn_opportunitypricelist_AsyncOperations

**Added by**: Project Service Automation Solution

See msdyn_opportunitypricelist Entity [msdyn_opportunitypricelist_AsyncOperations](msdyn_opportunitypricelist.md#BKMK_msdyn_opportunitypricelist_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_msdyn_orderlineresourcecategory_AsyncOperations"></a> msdyn_orderlineresourcecategory_AsyncOperations

**Added by**: Project Service Automation Solution

See msdyn_orderlineresourcecategory Entity [msdyn_orderlineresourcecategory_AsyncOperations](msdyn_orderlineresourcecategory.md#BKMK_msdyn_orderlineresourcecategory_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_msdyn_orderlinetransaction_AsyncOperations"></a> msdyn_orderlinetransaction_AsyncOperations

**Added by**: Project Service Automation Solution

See msdyn_orderlinetransaction Entity [msdyn_orderlinetransaction_AsyncOperations](msdyn_orderlinetransaction.md#BKMK_msdyn_orderlinetransaction_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_msdyn_orderlinetransactioncategory_AsyncOperations"></a> msdyn_orderlinetransactioncategory_AsyncOperations

**Added by**: Project Service Automation Solution

See msdyn_orderlinetransactioncategory Entity [msdyn_orderlinetransactioncategory_AsyncOperations](msdyn_orderlinetransactioncategory.md#BKMK_msdyn_orderlinetransactioncategory_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_msdyn_orderlinetransactionclassification_AsyncOperations"></a> msdyn_orderlinetransactionclassification_AsyncOperations

**Added by**: Project Service Automation Solution

See msdyn_orderlinetransactionclassification Entity [msdyn_orderlinetransactionclassification_AsyncOperations](msdyn_orderlinetransactionclassification.md#BKMK_msdyn_orderlinetransactionclassification_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_msdyn_orderpricelist_AsyncOperations"></a> msdyn_orderpricelist_AsyncOperations

**Added by**: Project Service Automation Solution

See msdyn_orderpricelist Entity [msdyn_orderpricelist_AsyncOperations](msdyn_orderpricelist.md#BKMK_msdyn_orderpricelist_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_msdyn_processnotes_AsyncOperations"></a> msdyn_processnotes_AsyncOperations

**Added by**: Project Service Automation Solution

See msdyn_processnotes Entity [msdyn_processnotes_AsyncOperations](msdyn_processnotes.md#BKMK_msdyn_processnotes_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_msdyn_project_AsyncOperations"></a> msdyn_project_AsyncOperations

**Added by**: Project Service Automation Solution

See msdyn_project Entity [msdyn_project_AsyncOperations](msdyn_project.md#BKMK_msdyn_project_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_msdyn_projectapproval_AsyncOperations"></a> msdyn_projectapproval_AsyncOperations

**Added by**: Project Service Automation Solution

See msdyn_projectapproval Entity [msdyn_projectapproval_AsyncOperations](msdyn_projectapproval.md#BKMK_msdyn_projectapproval_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_msdyn_projectparameter_AsyncOperations"></a> msdyn_projectparameter_AsyncOperations

**Added by**: Project Service Automation Solution

See msdyn_projectparameter Entity [msdyn_projectparameter_AsyncOperations](msdyn_projectparameter.md#BKMK_msdyn_projectparameter_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_msdyn_projectparameterpricelist_AsyncOperations"></a> msdyn_projectparameterpricelist_AsyncOperations

**Added by**: Project Service Automation Solution

See msdyn_projectparameterpricelist Entity [msdyn_projectparameterpricelist_AsyncOperations](msdyn_projectparameterpricelist.md#BKMK_msdyn_projectparameterpricelist_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_msdyn_projectpricelist_AsyncOperations"></a> msdyn_projectpricelist_AsyncOperations

**Added by**: Project Service Automation Solution

See msdyn_projectpricelist Entity [msdyn_projectpricelist_AsyncOperations](msdyn_projectpricelist.md#BKMK_msdyn_projectpricelist_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_msdyn_projecttask_AsyncOperations"></a> msdyn_projecttask_AsyncOperations

**Added by**: Project Service Automation Solution

See msdyn_projecttask Entity [msdyn_projecttask_AsyncOperations](msdyn_projecttask.md#BKMK_msdyn_projecttask_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_msdyn_projecttaskdependency_AsyncOperations"></a> msdyn_projecttaskdependency_AsyncOperations

**Added by**: Project Service Automation Solution

See msdyn_projecttaskdependency Entity [msdyn_projecttaskdependency_AsyncOperations](msdyn_projecttaskdependency.md#BKMK_msdyn_projecttaskdependency_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_msdyn_projecttaskstatususer_AsyncOperations"></a> msdyn_projecttaskstatususer_AsyncOperations

**Added by**: Project Service Automation Solution

See msdyn_projecttaskstatususer Entity [msdyn_projecttaskstatususer_AsyncOperations](msdyn_projecttaskstatususer.md#BKMK_msdyn_projecttaskstatususer_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_msdyn_projectteam_AsyncOperations"></a> msdyn_projectteam_AsyncOperations

**Added by**: Project Service Automation Solution

See msdyn_projectteam Entity [msdyn_projectteam_AsyncOperations](msdyn_projectteam.md#BKMK_msdyn_projectteam_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_msdyn_projectteammembersignup_AsyncOperations"></a> msdyn_projectteammembersignup_AsyncOperations

**Added by**: Project Service Automation Solution

See msdyn_projectteammembersignup Entity [msdyn_projectteammembersignup_AsyncOperations](msdyn_projectteammembersignup.md#BKMK_msdyn_projectteammembersignup_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_msdyn_projecttransactioncategory_AsyncOperations"></a> msdyn_projecttransactioncategory_AsyncOperations

**Added by**: Project Service Automation Solution

See msdyn_projecttransactioncategory Entity [msdyn_projecttransactioncategory_AsyncOperations](msdyn_projecttransactioncategory.md#BKMK_msdyn_projecttransactioncategory_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_msdyn_quotelineanalyticsbreakdown_AsyncOperations"></a> msdyn_quotelineanalyticsbreakdown_AsyncOperations

**Added by**: Project Service Automation Solution

See msdyn_quotelineanalyticsbreakdown Entity [msdyn_quotelineanalyticsbreakdown_AsyncOperations](msdyn_quotelineanalyticsbreakdown.md#BKMK_msdyn_quotelineanalyticsbreakdown_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_msdyn_quotelineinvoiceschedule_AsyncOperations"></a> msdyn_quotelineinvoiceschedule_AsyncOperations

**Added by**: Project Service Automation Solution

See msdyn_quotelineinvoiceschedule Entity [msdyn_quotelineinvoiceschedule_AsyncOperations](msdyn_quotelineinvoiceschedule.md#BKMK_msdyn_quotelineinvoiceschedule_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_msdyn_quotelineresourcecategory_AsyncOperations"></a> msdyn_quotelineresourcecategory_AsyncOperations

**Added by**: Project Service Automation Solution

See msdyn_quotelineresourcecategory Entity [msdyn_quotelineresourcecategory_AsyncOperations](msdyn_quotelineresourcecategory.md#BKMK_msdyn_quotelineresourcecategory_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_msdyn_quotelinescheduleofvalue_AsyncOperations"></a> msdyn_quotelinescheduleofvalue_AsyncOperations

**Added by**: Project Service Automation Solution

See msdyn_quotelinescheduleofvalue Entity [msdyn_quotelinescheduleofvalue_AsyncOperations](msdyn_quotelinescheduleofvalue.md#BKMK_msdyn_quotelinescheduleofvalue_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_msdyn_quotelinetransaction_AsyncOperations"></a> msdyn_quotelinetransaction_AsyncOperations

**Added by**: Project Service Automation Solution

See msdyn_quotelinetransaction Entity [msdyn_quotelinetransaction_AsyncOperations](msdyn_quotelinetransaction.md#BKMK_msdyn_quotelinetransaction_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_msdyn_quotelinetransactioncategory_AsyncOperations"></a> msdyn_quotelinetransactioncategory_AsyncOperations

**Added by**: Project Service Automation Solution

See msdyn_quotelinetransactioncategory Entity [msdyn_quotelinetransactioncategory_AsyncOperations](msdyn_quotelinetransactioncategory.md#BKMK_msdyn_quotelinetransactioncategory_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_msdyn_quotelinetransactionclassification_AsyncOperations"></a> msdyn_quotelinetransactionclassification_AsyncOperations

**Added by**: Project Service Automation Solution

See msdyn_quotelinetransactionclassification Entity [msdyn_quotelinetransactionclassification_AsyncOperations](msdyn_quotelinetransactionclassification.md#BKMK_msdyn_quotelinetransactionclassification_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_msdyn_quotepricelist_AsyncOperations"></a> msdyn_quotepricelist_AsyncOperations

**Added by**: Project Service Automation Solution

See msdyn_quotepricelist Entity [msdyn_quotepricelist_AsyncOperations](msdyn_quotepricelist.md#BKMK_msdyn_quotepricelist_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_msdyn_resourceassignment_AsyncOperations"></a> msdyn_resourceassignment_AsyncOperations

**Added by**: Project Service Automation Solution

See msdyn_resourceassignment Entity [msdyn_resourceassignment_AsyncOperations](msdyn_resourceassignment.md#BKMK_msdyn_resourceassignment_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_msdyn_resourceassignmentdetail_AsyncOperations"></a> msdyn_resourceassignmentdetail_AsyncOperations

**Added by**: Project Service Automation Solution

See msdyn_resourceassignmentdetail Entity [msdyn_resourceassignmentdetail_AsyncOperations](msdyn_resourceassignmentdetail.md#BKMK_msdyn_resourceassignmentdetail_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_msdyn_resourcecategorymarkuppricelevel_AsyncOperations"></a> msdyn_resourcecategorymarkuppricelevel_AsyncOperations

**Added by**: Project Service Automation Solution

See msdyn_resourcecategorymarkuppricelevel Entity [msdyn_resourcecategorymarkuppricelevel_AsyncOperations](msdyn_resourcecategorymarkuppricelevel.md#BKMK_msdyn_resourcecategorymarkuppricelevel_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_msdyn_resourcecategorypricelevel_AsyncOperations"></a> msdyn_resourcecategorypricelevel_AsyncOperations

**Added by**: Project Service Automation Solution

See msdyn_resourcecategorypricelevel Entity [msdyn_resourcecategorypricelevel_AsyncOperations](msdyn_resourcecategorypricelevel.md#BKMK_msdyn_resourcecategorypricelevel_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_msdyn_resourcerequest_AsyncOperations"></a> msdyn_resourcerequest_AsyncOperations

**Added by**: Project Service Automation Solution

See msdyn_resourcerequest Entity [msdyn_resourcerequest_AsyncOperations](msdyn_resourcerequest.md#BKMK_msdyn_resourcerequest_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_msdyn_rolecompetencyrequirement_AsyncOperations"></a> msdyn_rolecompetencyrequirement_AsyncOperations

**Added by**: Project Service Automation Solution

See msdyn_rolecompetencyrequirement Entity [msdyn_rolecompetencyrequirement_AsyncOperations](msdyn_rolecompetencyrequirement.md#BKMK_msdyn_rolecompetencyrequirement_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_msdyn_roleutilization_AsyncOperations"></a> msdyn_roleutilization_AsyncOperations

**Added by**: Project Service Automation Solution

See msdyn_roleutilization Entity [msdyn_roleutilization_AsyncOperations](msdyn_roleutilization.md#BKMK_msdyn_roleutilization_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_msdyn_timeentry_AsyncOperations"></a> msdyn_timeentry_AsyncOperations

**Added by**: Project Service Automation Solution

See msdyn_timeentry Entity [msdyn_timeentry_AsyncOperations](msdyn_timeentry.md#BKMK_msdyn_timeentry_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_msdyn_timeoffcalendar_AsyncOperations"></a> msdyn_timeoffcalendar_AsyncOperations

**Added by**: Project Service Automation Solution

See msdyn_timeoffcalendar Entity [msdyn_timeoffcalendar_AsyncOperations](msdyn_timeoffcalendar.md#BKMK_msdyn_timeoffcalendar_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_msdyn_transactioncategory_AsyncOperations"></a> msdyn_transactioncategory_AsyncOperations

**Added by**: Project Service Automation Solution

See msdyn_transactioncategory Entity [msdyn_transactioncategory_AsyncOperations](msdyn_transactioncategory.md#BKMK_msdyn_transactioncategory_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_msdyn_transactioncategoryclassification_AsyncOperations"></a> msdyn_transactioncategoryclassification_AsyncOperations

**Added by**: Project Service Automation Solution

See msdyn_transactioncategoryclassification Entity [msdyn_transactioncategoryclassification_AsyncOperations](msdyn_transactioncategoryclassification.md#BKMK_msdyn_transactioncategoryclassification_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_msdyn_transactioncategoryhierarchyelement_AsyncOperations"></a> msdyn_transactioncategoryhierarchyelement_AsyncOperations

**Added by**: Project Service Automation Solution

See msdyn_transactioncategoryhierarchyelement Entity [msdyn_transactioncategoryhierarchyelement_AsyncOperations](msdyn_transactioncategoryhierarchyelement.md#BKMK_msdyn_transactioncategoryhierarchyelement_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_msdyn_transactioncategorypricelevel_AsyncOperations"></a> msdyn_transactioncategorypricelevel_AsyncOperations

**Added by**: Project Service Automation Solution

See msdyn_transactioncategorypricelevel Entity [msdyn_transactioncategorypricelevel_AsyncOperations](msdyn_transactioncategorypricelevel.md#BKMK_msdyn_transactioncategorypricelevel_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_msdyn_transactionconnection_AsyncOperations"></a> msdyn_transactionconnection_AsyncOperations

**Added by**: Project Service Automation Solution

See msdyn_transactionconnection Entity [msdyn_transactionconnection_AsyncOperations](msdyn_transactionconnection.md#BKMK_msdyn_transactionconnection_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_msdyn_transactiontype_AsyncOperations"></a> msdyn_transactiontype_AsyncOperations

**Added by**: Project Service Automation Solution

See msdyn_transactiontype Entity [msdyn_transactiontype_AsyncOperations](msdyn_transactiontype.md#BKMK_msdyn_transactiontype_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_msdyn_userworkhistory_AsyncOperations"></a> msdyn_userworkhistory_AsyncOperations

**Added by**: Project Service Automation Solution

See msdyn_userworkhistory Entity [msdyn_userworkhistory_AsyncOperations](msdyn_userworkhistory.md#BKMK_msdyn_userworkhistory_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_msdyn_agreement_AsyncOperations"></a> msdyn_agreement_AsyncOperations

**Added by**: Field Service Solution

See msdyn_agreement Entity [msdyn_agreement_AsyncOperations](msdyn_agreement.md#BKMK_msdyn_agreement_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_msdyn_agreementbookingdate_AsyncOperations"></a> msdyn_agreementbookingdate_AsyncOperations

**Added by**: Field Service Solution

See msdyn_agreementbookingdate Entity [msdyn_agreementbookingdate_AsyncOperations](msdyn_agreementbookingdate.md#BKMK_msdyn_agreementbookingdate_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_msdyn_agreementbookingincident_AsyncOperations"></a> msdyn_agreementbookingincident_AsyncOperations

**Added by**: Field Service Solution

See msdyn_agreementbookingincident Entity [msdyn_agreementbookingincident_AsyncOperations](msdyn_agreementbookingincident.md#BKMK_msdyn_agreementbookingincident_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_msdyn_agreementbookingproduct_AsyncOperations"></a> msdyn_agreementbookingproduct_AsyncOperations

**Added by**: Field Service Solution

See msdyn_agreementbookingproduct Entity [msdyn_agreementbookingproduct_AsyncOperations](msdyn_agreementbookingproduct.md#BKMK_msdyn_agreementbookingproduct_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_msdyn_agreementbookingservice_AsyncOperations"></a> msdyn_agreementbookingservice_AsyncOperations

**Added by**: Field Service Solution

See msdyn_agreementbookingservice Entity [msdyn_agreementbookingservice_AsyncOperations](msdyn_agreementbookingservice.md#BKMK_msdyn_agreementbookingservice_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_msdyn_agreementbookingservicetask_AsyncOperations"></a> msdyn_agreementbookingservicetask_AsyncOperations

**Added by**: Field Service Solution

See msdyn_agreementbookingservicetask Entity [msdyn_agreementbookingservicetask_AsyncOperations](msdyn_agreementbookingservicetask.md#BKMK_msdyn_agreementbookingservicetask_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_msdyn_agreementbookingsetup_AsyncOperations"></a> msdyn_agreementbookingsetup_AsyncOperations

**Added by**: Field Service Solution

See msdyn_agreementbookingsetup Entity [msdyn_agreementbookingsetup_AsyncOperations](msdyn_agreementbookingsetup.md#BKMK_msdyn_agreementbookingsetup_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_msdyn_agreementinvoicedate_AsyncOperations"></a> msdyn_agreementinvoicedate_AsyncOperations

**Added by**: Field Service Solution

See msdyn_agreementinvoicedate Entity [msdyn_agreementinvoicedate_AsyncOperations](msdyn_agreementinvoicedate.md#BKMK_msdyn_agreementinvoicedate_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_msdyn_agreementinvoiceproduct_AsyncOperations"></a> msdyn_agreementinvoiceproduct_AsyncOperations

**Added by**: Field Service Solution

See msdyn_agreementinvoiceproduct Entity [msdyn_agreementinvoiceproduct_AsyncOperations](msdyn_agreementinvoiceproduct.md#BKMK_msdyn_agreementinvoiceproduct_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_msdyn_agreementinvoicesetup_AsyncOperations"></a> msdyn_agreementinvoicesetup_AsyncOperations

**Added by**: Field Service Solution

See msdyn_agreementinvoicesetup Entity [msdyn_agreementinvoicesetup_AsyncOperations](msdyn_agreementinvoicesetup.md#BKMK_msdyn_agreementinvoicesetup_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_msdyn_agreementsubstatus_AsyncOperations"></a> msdyn_agreementsubstatus_AsyncOperations

**Added by**: Field Service Solution

See msdyn_agreementsubstatus Entity [msdyn_agreementsubstatus_AsyncOperations](msdyn_agreementsubstatus.md#BKMK_msdyn_agreementsubstatus_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_msdyn_bookingjournal_AsyncOperations"></a> msdyn_bookingjournal_AsyncOperations

**Added by**: Field Service Solution

See msdyn_bookingjournal Entity [msdyn_bookingjournal_AsyncOperations](msdyn_bookingjournal.md#BKMK_msdyn_bookingjournal_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_msdyn_bookingtimestamp_AsyncOperations"></a> msdyn_bookingtimestamp_AsyncOperations

**Added by**: Field Service Solution

See msdyn_bookingtimestamp Entity [msdyn_bookingtimestamp_AsyncOperations](msdyn_bookingtimestamp.md#BKMK_msdyn_bookingtimestamp_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_msdyn_bpf_2c5fe86acc8b414b8322ae571000c799_AsyncOperations"></a> msdyn_bpf_2c5fe86acc8b414b8322ae571000c799_AsyncOperations

**Added by**: Field Service Solution

See msdyn_bpf_2c5fe86acc8b414b8322ae571000c799 Entity [msdyn_bpf_2c5fe86acc8b414b8322ae571000c799_AsyncOperations](msdyn_bpf_2c5fe86acc8b414b8322ae571000c799.md#BKMK_msdyn_bpf_2c5fe86acc8b414b8322ae571000c799_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_msdyn_bpf_989e9b1857e24af18787d5143b67523b_AsyncOperations"></a> msdyn_bpf_989e9b1857e24af18787d5143b67523b_AsyncOperations

**Added by**: Field Service Solution

See msdyn_bpf_989e9b1857e24af18787d5143b67523b Entity [msdyn_bpf_989e9b1857e24af18787d5143b67523b_AsyncOperations](msdyn_bpf_989e9b1857e24af18787d5143b67523b.md#BKMK_msdyn_bpf_989e9b1857e24af18787d5143b67523b_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_msdyn_bpf_baa0a411a239410cb8bded8b5fdd88e3_AsyncOperations"></a> msdyn_bpf_baa0a411a239410cb8bded8b5fdd88e3_AsyncOperations

**Added by**: Field Service Solution

See msdyn_bpf_baa0a411a239410cb8bded8b5fdd88e3 Entity [msdyn_bpf_baa0a411a239410cb8bded8b5fdd88e3_AsyncOperations](msdyn_bpf_baa0a411a239410cb8bded8b5fdd88e3.md#BKMK_msdyn_bpf_baa0a411a239410cb8bded8b5fdd88e3_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_msdyn_bpf_d3d97bac8c294105840e99e37a9d1c39_AsyncOperations"></a> msdyn_bpf_d3d97bac8c294105840e99e37a9d1c39_AsyncOperations

**Added by**: Field Service Solution

See msdyn_bpf_d3d97bac8c294105840e99e37a9d1c39 Entity [msdyn_bpf_d3d97bac8c294105840e99e37a9d1c39_AsyncOperations](msdyn_bpf_d3d97bac8c294105840e99e37a9d1c39.md#BKMK_msdyn_bpf_d3d97bac8c294105840e99e37a9d1c39_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_msdyn_customerasset_AsyncOperations"></a> msdyn_customerasset_AsyncOperations

**Added by**: Field Service Solution

See msdyn_customerasset Entity [msdyn_customerasset_AsyncOperations](msdyn_customerasset.md#BKMK_msdyn_customerasset_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_msdyn_customerassetcategory_AsyncOperations"></a> msdyn_customerassetcategory_AsyncOperations

**Added by**: Field Service Solution

See msdyn_customerassetcategory Entity [msdyn_customerassetcategory_AsyncOperations](msdyn_customerassetcategory.md#BKMK_msdyn_customerassetcategory_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_msdyn_entitlementapplication_AsyncOperations"></a> msdyn_entitlementapplication_AsyncOperations

**Added by**: Field Service Solution

See msdyn_entitlementapplication Entity [msdyn_entitlementapplication_AsyncOperations](msdyn_entitlementapplication.md#BKMK_msdyn_entitlementapplication_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_msdyn_fieldservicepricelistitem_AsyncOperations"></a> msdyn_fieldservicepricelistitem_AsyncOperations

**Added by**: Field Service Solution

See msdyn_fieldservicepricelistitem Entity [msdyn_fieldservicepricelistitem_AsyncOperations](msdyn_fieldservicepricelistitem.md#BKMK_msdyn_fieldservicepricelistitem_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_msdyn_fieldservicesetting_AsyncOperations"></a> msdyn_fieldservicesetting_AsyncOperations

**Added by**: Field Service Solution

See msdyn_fieldservicesetting Entity [msdyn_fieldservicesetting_AsyncOperations](msdyn_fieldservicesetting.md#BKMK_msdyn_fieldservicesetting_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_msdyn_fieldserviceslaconfiguration_AsyncOperations"></a> msdyn_fieldserviceslaconfiguration_AsyncOperations

**Added by**: Field Service Solution

See msdyn_fieldserviceslaconfiguration Entity [msdyn_fieldserviceslaconfiguration_AsyncOperations](msdyn_fieldserviceslaconfiguration.md#BKMK_msdyn_fieldserviceslaconfiguration_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_msdyn_fieldservicesystemjob_AsyncOperations"></a> msdyn_fieldservicesystemjob_AsyncOperations

**Added by**: Field Service Solution

See msdyn_fieldservicesystemjob Entity [msdyn_fieldservicesystemjob_AsyncOperations](msdyn_fieldservicesystemjob.md#BKMK_msdyn_fieldservicesystemjob_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_msdyn_incidenttype_AsyncOperations"></a> msdyn_incidenttype_AsyncOperations

**Added by**: Field Service Solution

See msdyn_incidenttype Entity [msdyn_incidenttype_AsyncOperations](msdyn_incidenttype.md#BKMK_msdyn_incidenttype_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_msdyn_incidenttypecharacteristic_AsyncOperations"></a> msdyn_incidenttypecharacteristic_AsyncOperations

**Added by**: Field Service Solution

See msdyn_incidenttypecharacteristic Entity [msdyn_incidenttypecharacteristic_AsyncOperations](msdyn_incidenttypecharacteristic.md#BKMK_msdyn_incidenttypecharacteristic_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_msdyn_incidenttypeproduct_AsyncOperations"></a> msdyn_incidenttypeproduct_AsyncOperations

**Added by**: Field Service Solution

See msdyn_incidenttypeproduct Entity [msdyn_incidenttypeproduct_AsyncOperations](msdyn_incidenttypeproduct.md#BKMK_msdyn_incidenttypeproduct_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_msdyn_incidenttypeservice_AsyncOperations"></a> msdyn_incidenttypeservice_AsyncOperations

**Added by**: Field Service Solution

See msdyn_incidenttypeservice Entity [msdyn_incidenttypeservice_AsyncOperations](msdyn_incidenttypeservice.md#BKMK_msdyn_incidenttypeservice_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_msdyn_incidenttypeservicetask_AsyncOperations"></a> msdyn_incidenttypeservicetask_AsyncOperations

**Added by**: Field Service Solution

See msdyn_incidenttypeservicetask Entity [msdyn_incidenttypeservicetask_AsyncOperations](msdyn_incidenttypeservicetask.md#BKMK_msdyn_incidenttypeservicetask_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_msdyn_incidenttypessetup_AsyncOperations"></a> msdyn_incidenttypessetup_AsyncOperations

**Added by**: Field Service Solution

See msdyn_incidenttypessetup Entity [msdyn_incidenttypessetup_AsyncOperations](msdyn_incidenttypessetup.md#BKMK_msdyn_incidenttypessetup_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_msdyn_incidenttype_requirementgroup_AsyncOperations"></a> msdyn_incidenttype_requirementgroup_AsyncOperations

**Added by**: Field Service Solution

See msdyn_incidenttype_requirementgroup Entity [msdyn_incidenttype_requirementgroup_AsyncOperations](msdyn_incidenttype_requirementgroup.md#BKMK_msdyn_incidenttype_requirementgroup_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_msdyn_inventoryadjustment_AsyncOperations"></a> msdyn_inventoryadjustment_AsyncOperations

**Added by**: Field Service Solution

See msdyn_inventoryadjustment Entity [msdyn_inventoryadjustment_AsyncOperations](msdyn_inventoryadjustment.md#BKMK_msdyn_inventoryadjustment_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_msdyn_inventoryadjustmentproduct_AsyncOperations"></a> msdyn_inventoryadjustmentproduct_AsyncOperations

**Added by**: Field Service Solution

See msdyn_inventoryadjustmentproduct Entity [msdyn_inventoryadjustmentproduct_AsyncOperations](msdyn_inventoryadjustmentproduct.md#BKMK_msdyn_inventoryadjustmentproduct_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_msdyn_inventoryjournal_AsyncOperations"></a> msdyn_inventoryjournal_AsyncOperations

**Added by**: Field Service Solution

See msdyn_inventoryjournal Entity [msdyn_inventoryjournal_AsyncOperations](msdyn_inventoryjournal.md#BKMK_msdyn_inventoryjournal_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_msdyn_inventorytransfer_AsyncOperations"></a> msdyn_inventorytransfer_AsyncOperations

**Added by**: Field Service Solution

See msdyn_inventorytransfer Entity [msdyn_inventorytransfer_AsyncOperations](msdyn_inventorytransfer.md#BKMK_msdyn_inventorytransfer_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_msdyn_orderinvoicingdate_AsyncOperations"></a> msdyn_orderinvoicingdate_AsyncOperations

**Added by**: Field Service Solution

See msdyn_orderinvoicingdate Entity [msdyn_orderinvoicingdate_AsyncOperations](msdyn_orderinvoicingdate.md#BKMK_msdyn_orderinvoicingdate_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_msdyn_orderinvoicingproduct_AsyncOperations"></a> msdyn_orderinvoicingproduct_AsyncOperations

**Added by**: Field Service Solution

See msdyn_orderinvoicingproduct Entity [msdyn_orderinvoicingproduct_AsyncOperations](msdyn_orderinvoicingproduct.md#BKMK_msdyn_orderinvoicingproduct_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_msdyn_orderinvoicingsetup_AsyncOperations"></a> msdyn_orderinvoicingsetup_AsyncOperations

**Added by**: Field Service Solution

See msdyn_orderinvoicingsetup Entity [msdyn_orderinvoicingsetup_AsyncOperations](msdyn_orderinvoicingsetup.md#BKMK_msdyn_orderinvoicingsetup_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_msdyn_orderinvoicingsetupdate_AsyncOperations"></a> msdyn_orderinvoicingsetupdate_AsyncOperations

**Added by**: Field Service Solution

See msdyn_orderinvoicingsetupdate Entity [msdyn_orderinvoicingsetupdate_AsyncOperations](msdyn_orderinvoicingsetupdate.md#BKMK_msdyn_orderinvoicingsetupdate_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_msdyn_payment_AsyncOperations"></a> msdyn_payment_AsyncOperations

**Added by**: Field Service Solution

See msdyn_payment Entity [msdyn_payment_AsyncOperations](msdyn_payment.md#BKMK_msdyn_payment_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_msdyn_paymentdetail_AsyncOperations"></a> msdyn_paymentdetail_AsyncOperations

**Added by**: Field Service Solution

See msdyn_paymentdetail Entity [msdyn_paymentdetail_AsyncOperations](msdyn_paymentdetail.md#BKMK_msdyn_paymentdetail_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_msdyn_paymentmethod_AsyncOperations"></a> msdyn_paymentmethod_AsyncOperations

**Added by**: Field Service Solution

See msdyn_paymentmethod Entity [msdyn_paymentmethod_AsyncOperations](msdyn_paymentmethod.md#BKMK_msdyn_paymentmethod_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_msdyn_paymentterm_AsyncOperations"></a> msdyn_paymentterm_AsyncOperations

**Added by**: Field Service Solution

See msdyn_paymentterm Entity [msdyn_paymentterm_AsyncOperations](msdyn_paymentterm.md#BKMK_msdyn_paymentterm_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_msdyn_postalcode_AsyncOperations"></a> msdyn_postalcode_AsyncOperations

**Added by**: Field Service Solution

See msdyn_postalcode Entity [msdyn_postalcode_AsyncOperations](msdyn_postalcode.md#BKMK_msdyn_postalcode_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_msdyn_productinventory_AsyncOperations"></a> msdyn_productinventory_AsyncOperations

**Added by**: Field Service Solution

See msdyn_productinventory Entity [msdyn_productinventory_AsyncOperations](msdyn_productinventory.md#BKMK_msdyn_productinventory_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_msdyn_purchaseorder_AsyncOperations"></a> msdyn_purchaseorder_AsyncOperations

**Added by**: Field Service Solution

See msdyn_purchaseorder Entity [msdyn_purchaseorder_AsyncOperations](msdyn_purchaseorder.md#BKMK_msdyn_purchaseorder_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_msdyn_purchaseorderbill_AsyncOperations"></a> msdyn_purchaseorderbill_AsyncOperations

**Added by**: Field Service Solution

See msdyn_purchaseorderbill Entity [msdyn_purchaseorderbill_AsyncOperations](msdyn_purchaseorderbill.md#BKMK_msdyn_purchaseorderbill_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_msdyn_purchaseorderproduct_AsyncOperations"></a> msdyn_purchaseorderproduct_AsyncOperations

**Added by**: Field Service Solution

See msdyn_purchaseorderproduct Entity [msdyn_purchaseorderproduct_AsyncOperations](msdyn_purchaseorderproduct.md#BKMK_msdyn_purchaseorderproduct_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_msdyn_purchaseorderreceipt_AsyncOperations"></a> msdyn_purchaseorderreceipt_AsyncOperations

**Added by**: Field Service Solution

See msdyn_purchaseorderreceipt Entity [msdyn_purchaseorderreceipt_AsyncOperations](msdyn_purchaseorderreceipt.md#BKMK_msdyn_purchaseorderreceipt_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_msdyn_purchaseorderreceiptproduct_AsyncOperations"></a> msdyn_purchaseorderreceiptproduct_AsyncOperations

**Added by**: Field Service Solution

See msdyn_purchaseorderreceiptproduct Entity [msdyn_purchaseorderreceiptproduct_AsyncOperations](msdyn_purchaseorderreceiptproduct.md#BKMK_msdyn_purchaseorderreceiptproduct_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_msdyn_purchaseordersubstatus_AsyncOperations"></a> msdyn_purchaseordersubstatus_AsyncOperations

**Added by**: Field Service Solution

See msdyn_purchaseordersubstatus Entity [msdyn_purchaseordersubstatus_AsyncOperations](msdyn_purchaseordersubstatus.md#BKMK_msdyn_purchaseordersubstatus_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_msdyn_quotebookingincident_AsyncOperations"></a> msdyn_quotebookingincident_AsyncOperations

**Added by**: Field Service Solution

See msdyn_quotebookingincident Entity [msdyn_quotebookingincident_AsyncOperations](msdyn_quotebookingincident.md#BKMK_msdyn_quotebookingincident_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_msdyn_quotebookingproduct_AsyncOperations"></a> msdyn_quotebookingproduct_AsyncOperations

**Added by**: Field Service Solution

See msdyn_quotebookingproduct Entity [msdyn_quotebookingproduct_AsyncOperations](msdyn_quotebookingproduct.md#BKMK_msdyn_quotebookingproduct_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_msdyn_quotebookingservice_AsyncOperations"></a> msdyn_quotebookingservice_AsyncOperations

**Added by**: Field Service Solution

See msdyn_quotebookingservice Entity [msdyn_quotebookingservice_AsyncOperations](msdyn_quotebookingservice.md#BKMK_msdyn_quotebookingservice_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_msdyn_quotebookingservicetask_AsyncOperations"></a> msdyn_quotebookingservicetask_AsyncOperations

**Added by**: Field Service Solution

See msdyn_quotebookingservicetask Entity [msdyn_quotebookingservicetask_AsyncOperations](msdyn_quotebookingservicetask.md#BKMK_msdyn_quotebookingservicetask_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_msdyn_quotebookingsetup_AsyncOperations"></a> msdyn_quotebookingsetup_AsyncOperations

**Added by**: Field Service Solution

See msdyn_quotebookingsetup Entity [msdyn_quotebookingsetup_AsyncOperations](msdyn_quotebookingsetup.md#BKMK_msdyn_quotebookingsetup_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_msdyn_quoteinvoicingproduct_AsyncOperations"></a> msdyn_quoteinvoicingproduct_AsyncOperations

**Added by**: Field Service Solution

See msdyn_quoteinvoicingproduct Entity [msdyn_quoteinvoicingproduct_AsyncOperations](msdyn_quoteinvoicingproduct.md#BKMK_msdyn_quoteinvoicingproduct_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_msdyn_quoteinvoicingsetup_AsyncOperations"></a> msdyn_quoteinvoicingsetup_AsyncOperations

**Added by**: Field Service Solution

See msdyn_quoteinvoicingsetup Entity [msdyn_quoteinvoicingsetup_AsyncOperations](msdyn_quoteinvoicingsetup.md#BKMK_msdyn_quoteinvoicingsetup_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_msdyn_resourcepaytype_AsyncOperations"></a> msdyn_resourcepaytype_AsyncOperations

**Added by**: Field Service Solution

See msdyn_resourcepaytype Entity [msdyn_resourcepaytype_AsyncOperations](msdyn_resourcepaytype.md#BKMK_msdyn_resourcepaytype_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_msdyn_rma_AsyncOperations"></a> msdyn_rma_AsyncOperations

**Added by**: Field Service Solution

See msdyn_rma Entity [msdyn_rma_AsyncOperations](msdyn_rma.md#BKMK_msdyn_rma_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_msdyn_rmaproduct_AsyncOperations"></a> msdyn_rmaproduct_AsyncOperations

**Added by**: Field Service Solution

See msdyn_rmaproduct Entity [msdyn_rmaproduct_AsyncOperations](msdyn_rmaproduct.md#BKMK_msdyn_rmaproduct_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_msdyn_rmareceipt_AsyncOperations"></a> msdyn_rmareceipt_AsyncOperations

**Added by**: Field Service Solution

See msdyn_rmareceipt Entity [msdyn_rmareceipt_AsyncOperations](msdyn_rmareceipt.md#BKMK_msdyn_rmareceipt_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_msdyn_rmareceiptproduct_AsyncOperations"></a> msdyn_rmareceiptproduct_AsyncOperations

**Added by**: Field Service Solution

See msdyn_rmareceiptproduct Entity [msdyn_rmareceiptproduct_AsyncOperations](msdyn_rmareceiptproduct.md#BKMK_msdyn_rmareceiptproduct_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_msdyn_rmasubstatus_AsyncOperations"></a> msdyn_rmasubstatus_AsyncOperations

**Added by**: Field Service Solution

See msdyn_rmasubstatus Entity [msdyn_rmasubstatus_AsyncOperations](msdyn_rmasubstatus.md#BKMK_msdyn_rmasubstatus_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_msdyn_rtv_AsyncOperations"></a> msdyn_rtv_AsyncOperations

**Added by**: Field Service Solution

See msdyn_rtv Entity [msdyn_rtv_AsyncOperations](msdyn_rtv.md#BKMK_msdyn_rtv_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_msdyn_rtvproduct_AsyncOperations"></a> msdyn_rtvproduct_AsyncOperations

**Added by**: Field Service Solution

See msdyn_rtvproduct Entity [msdyn_rtvproduct_AsyncOperations](msdyn_rtvproduct.md#BKMK_msdyn_rtvproduct_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_msdyn_rtvsubstatus_AsyncOperations"></a> msdyn_rtvsubstatus_AsyncOperations

**Added by**: Field Service Solution

See msdyn_rtvsubstatus Entity [msdyn_rtvsubstatus_AsyncOperations](msdyn_rtvsubstatus.md#BKMK_msdyn_rtvsubstatus_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_msdyn_servicetasktype_AsyncOperations"></a> msdyn_servicetasktype_AsyncOperations

**Added by**: Field Service Solution

See msdyn_servicetasktype Entity [msdyn_servicetasktype_AsyncOperations](msdyn_servicetasktype.md#BKMK_msdyn_servicetasktype_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_msdyn_shipvia_AsyncOperations"></a> msdyn_shipvia_AsyncOperations

**Added by**: Field Service Solution

See msdyn_shipvia Entity [msdyn_shipvia_AsyncOperations](msdyn_shipvia.md#BKMK_msdyn_shipvia_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_msdyn_taxcode_AsyncOperations"></a> msdyn_taxcode_AsyncOperations

**Added by**: Field Service Solution

See msdyn_taxcode Entity [msdyn_taxcode_AsyncOperations](msdyn_taxcode.md#BKMK_msdyn_taxcode_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_msdyn_taxcodedetail_AsyncOperations"></a> msdyn_taxcodedetail_AsyncOperations

**Added by**: Field Service Solution

See msdyn_taxcodedetail Entity [msdyn_taxcodedetail_AsyncOperations](msdyn_taxcodedetail.md#BKMK_msdyn_taxcodedetail_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_msdyn_timeoffrequest_AsyncOperations"></a> msdyn_timeoffrequest_AsyncOperations

**Added by**: Field Service Solution

See msdyn_timeoffrequest Entity [msdyn_timeoffrequest_AsyncOperations](msdyn_timeoffrequest.md#BKMK_msdyn_timeoffrequest_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_msdyn_uniquenumber_AsyncOperations"></a> msdyn_uniquenumber_AsyncOperations

**Added by**: Field Service Solution

See msdyn_uniquenumber Entity [msdyn_uniquenumber_AsyncOperations](msdyn_uniquenumber.md#BKMK_msdyn_uniquenumber_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_msdyn_warehouse_AsyncOperations"></a> msdyn_warehouse_AsyncOperations

**Added by**: Field Service Solution

See msdyn_warehouse Entity [msdyn_warehouse_AsyncOperations](msdyn_warehouse.md#BKMK_msdyn_warehouse_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_msdyn_workorder_AsyncOperations"></a> msdyn_workorder_AsyncOperations

**Added by**: Field Service Solution

See msdyn_workorder Entity [msdyn_workorder_AsyncOperations](msdyn_workorder.md#BKMK_msdyn_workorder_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_msdyn_workordercharacteristic_AsyncOperations"></a> msdyn_workordercharacteristic_AsyncOperations

**Added by**: Field Service Solution

See msdyn_workordercharacteristic Entity [msdyn_workordercharacteristic_AsyncOperations](msdyn_workordercharacteristic.md#BKMK_msdyn_workordercharacteristic_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_msdyn_workorderdetailsgenerationqueue_AsyncOperations"></a> msdyn_workorderdetailsgenerationqueue_AsyncOperations

**Added by**: Field Service Solution

See msdyn_workorderdetailsgenerationqueue Entity [msdyn_workorderdetailsgenerationqueue_AsyncOperations](msdyn_workorderdetailsgenerationqueue.md#BKMK_msdyn_workorderdetailsgenerationqueue_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_msdyn_workorderincident_AsyncOperations"></a> msdyn_workorderincident_AsyncOperations

**Added by**: Field Service Solution

See msdyn_workorderincident Entity [msdyn_workorderincident_AsyncOperations](msdyn_workorderincident.md#BKMK_msdyn_workorderincident_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_msdyn_workorderproduct_AsyncOperations"></a> msdyn_workorderproduct_AsyncOperations

**Added by**: Field Service Solution

See msdyn_workorderproduct Entity [msdyn_workorderproduct_AsyncOperations](msdyn_workorderproduct.md#BKMK_msdyn_workorderproduct_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_msdyn_workorderresourcerestriction_AsyncOperations"></a> msdyn_workorderresourcerestriction_AsyncOperations

**Added by**: Field Service Solution

See msdyn_workorderresourcerestriction Entity [msdyn_workorderresourcerestriction_AsyncOperations](msdyn_workorderresourcerestriction.md#BKMK_msdyn_workorderresourcerestriction_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_msdyn_workorderservice_AsyncOperations"></a> msdyn_workorderservice_AsyncOperations

**Added by**: Field Service Solution

See msdyn_workorderservice Entity [msdyn_workorderservice_AsyncOperations](msdyn_workorderservice.md#BKMK_msdyn_workorderservice_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_msdyn_workorderservicetask_AsyncOperations"></a> msdyn_workorderservicetask_AsyncOperations

**Added by**: Field Service Solution

See msdyn_workorderservicetask Entity [msdyn_workorderservicetask_AsyncOperations](msdyn_workorderservicetask.md#BKMK_msdyn_workorderservicetask_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_msdyn_workordersubstatus_AsyncOperations"></a> msdyn_workordersubstatus_AsyncOperations

**Added by**: Field Service Solution

See msdyn_workordersubstatus Entity [msdyn_workordersubstatus_AsyncOperations](msdyn_workordersubstatus.md#BKMK_msdyn_workordersubstatus_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_msdyn_workordertype_AsyncOperations"></a> msdyn_workordertype_AsyncOperations

**Added by**: Field Service Solution

See msdyn_workordertype Entity [msdyn_workordertype_AsyncOperations](msdyn_workordertype.md#BKMK_msdyn_workordertype_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_msdyn_iotalert_AsyncOperations"></a> msdyn_iotalert_AsyncOperations

**Added by**: IoT Connector for Microsoft Dynamics 365 Solution

See msdyn_iotalert Entity [msdyn_iotalert_AsyncOperations](msdyn_iotalert.md#BKMK_msdyn_iotalert_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_msdyn_iotdevice_AsyncOperations"></a> msdyn_iotdevice_AsyncOperations

**Added by**: IoT Connector for Microsoft Dynamics 365 Solution

See msdyn_iotdevice Entity [msdyn_iotdevice_AsyncOperations](msdyn_iotdevice.md#BKMK_msdyn_iotdevice_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_msdyn_iotdevicecategory_AsyncOperations"></a> msdyn_iotdevicecategory_AsyncOperations

**Added by**: IoT Connector for Microsoft Dynamics 365 Solution

See msdyn_iotdevicecategory Entity [msdyn_iotdevicecategory_AsyncOperations](msdyn_iotdevicecategory.md#BKMK_msdyn_iotdevicecategory_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_msdyn_iotdevicecommand_AsyncOperations"></a> msdyn_iotdevicecommand_AsyncOperations

**Added by**: IoT Connector for Microsoft Dynamics 365 Solution

See msdyn_iotdevicecommand Entity [msdyn_iotdevicecommand_AsyncOperations](msdyn_iotdevicecommand.md#BKMK_msdyn_iotdevicecommand_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_msdyn_iotdevicecommanddefinition_AsyncOperations"></a> msdyn_iotdevicecommanddefinition_AsyncOperations

**Added by**: IoT Connector for Microsoft Dynamics 365 Solution

See msdyn_iotdevicecommanddefinition Entity [msdyn_iotdevicecommanddefinition_AsyncOperations](msdyn_iotdevicecommanddefinition.md#BKMK_msdyn_iotdevicecommanddefinition_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_msdyn_iotdevicedatahistory_AsyncOperations"></a> msdyn_iotdevicedatahistory_AsyncOperations

**Added by**: IoT Connector for Microsoft Dynamics 365 Solution

See msdyn_iotdevicedatahistory Entity [msdyn_iotdevicedatahistory_AsyncOperations](msdyn_iotdevicedatahistory.md#BKMK_msdyn_iotdevicedatahistory_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_msdyn_iotdeviceproperty_AsyncOperations"></a> msdyn_iotdeviceproperty_AsyncOperations

**Added by**: IoT Connector for Microsoft Dynamics 365 Solution

See msdyn_iotdeviceproperty Entity [msdyn_iotdeviceproperty_AsyncOperations](msdyn_iotdeviceproperty.md#BKMK_msdyn_iotdeviceproperty_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_msdyn_iotdeviceregistrationhistory_AsyncOperations"></a> msdyn_iotdeviceregistrationhistory_AsyncOperations

**Added by**: IoT Connector for Microsoft Dynamics 365 Solution

See msdyn_iotdeviceregistrationhistory Entity [msdyn_iotdeviceregistrationhistory_AsyncOperations](msdyn_iotdeviceregistrationhistory.md#BKMK_msdyn_iotdeviceregistrationhistory_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_msdyn_iotpropertydefinition_AsyncOperations"></a> msdyn_iotpropertydefinition_AsyncOperations

**Added by**: IoT Connector for Microsoft Dynamics 365 Solution

See msdyn_iotpropertydefinition Entity [msdyn_iotpropertydefinition_AsyncOperations](msdyn_iotpropertydefinition.md#BKMK_msdyn_iotpropertydefinition_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_msdyn_iotsettings_AsyncOperations"></a> msdyn_iotsettings_AsyncOperations

**Added by**: IoT Connector for Microsoft Dynamics 365 Solution

See msdyn_iotsettings Entity [msdyn_iotsettings_AsyncOperations](msdyn_iotsettings.md#BKMK_msdyn_iotsettings_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_msdyn_bpf_477c16f59170487b8b4dc895c5dcd09b_AsyncOperations"></a> msdyn_bpf_477c16f59170487b8b4dc895c5dcd09b_AsyncOperations

**Added by**: Connected Field Service for Microsoft Dynamics 365 Solution

See msdyn_bpf_477c16f59170487b8b4dc895c5dcd09b Entity [msdyn_bpf_477c16f59170487b8b4dc895c5dcd09b_AsyncOperations](msdyn_bpf_477c16f59170487b8b4dc895c5dcd09b.md#BKMK_msdyn_bpf_477c16f59170487b8b4dc895c5dcd09b_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_msdyn_entityconfiguration_AsyncOperations"></a> msdyn_entityconfiguration_AsyncOperations

**Added by**: Geofence Management Solution

See msdyn_entityconfiguration Entity [msdyn_entityconfiguration_AsyncOperations](msdyn_entityconfiguration.md#BKMK_msdyn_entityconfiguration_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_msdyn_geofence_AsyncOperations"></a> msdyn_geofence_AsyncOperations

**Added by**: Geofence Management Solution

See msdyn_geofence Entity [msdyn_geofence_AsyncOperations](msdyn_geofence.md#BKMK_msdyn_geofence_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_msdyn_geofenceevent_AsyncOperations"></a> msdyn_geofenceevent_AsyncOperations

**Added by**: Geofence Management Solution

See msdyn_geofenceevent Entity [msdyn_geofenceevent_AsyncOperations](msdyn_geofenceevent.md#BKMK_msdyn_geofenceevent_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_msdyn_geofencingsettings_AsyncOperations"></a> msdyn_geofencingsettings_AsyncOperations

**Added by**: Geofence Management Solution

See msdyn_geofencingsettings Entity [msdyn_geofencingsettings_AsyncOperations](msdyn_geofencingsettings.md#BKMK_msdyn_geofencingsettings_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_msdyn_connector_AsyncOperations"></a> msdyn_connector_AsyncOperations

**Added by**: Power Connector Solution Solution

See msdyn_connector Entity [msdyn_connector_AsyncOperations](msdyn_connector.md#BKMK_msdyn_connector_AsyncOperations) One-To-Many relationship.

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

### <a name="BKMK_Team_AsyncOperations"></a> Team_AsyncOperations

See team Entity [Team_AsyncOperations](team.md#BKMK_Team_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_AnnualFiscalCalendar_AsyncOperations"></a> AnnualFiscalCalendar_AsyncOperations

See annualfiscalcalendar Entity [AnnualFiscalCalendar_AsyncOperations](annualfiscalcalendar.md#BKMK_AnnualFiscalCalendar_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_SharePointDocumentLocation_AsyncOperations"></a> SharePointDocumentLocation_AsyncOperations

See sharepointdocumentlocation Entity [SharePointDocumentLocation_AsyncOperations](sharepointdocumentlocation.md#BKMK_SharePointDocumentLocation_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_PhoneCall_AsyncOperations"></a> PhoneCall_AsyncOperations

See phonecall Entity [PhoneCall_AsyncOperations](phonecall.md#BKMK_PhoneCall_AsyncOperations) One-To-Many relationship.

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

### <a name="BKMK_team_asyncoperation"></a> team_asyncoperation

See team Entity [team_asyncoperation](team.md#BKMK_team_asyncoperation) One-To-Many relationship.

### <a name="BKMK_lk_asyncoperation_modifiedby"></a> lk_asyncoperation_modifiedby

See systemuser Entity [lk_asyncoperation_modifiedby](systemuser.md#BKMK_lk_asyncoperation_modifiedby) One-To-Many relationship.

### <a name="BKMK_UserForm_AsyncOperations"></a> UserForm_AsyncOperations

See userform Entity [UserForm_AsyncOperations](userform.md#BKMK_UserForm_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_TransactionCurrency_AsyncOperations"></a> TransactionCurrency_AsyncOperations

See transactioncurrency Entity [TransactionCurrency_AsyncOperations](transactioncurrency.md#BKMK_TransactionCurrency_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_rollupfield_AsyncOperations"></a> rollupfield_AsyncOperations

See rollupfield Entity [rollupfield_AsyncOperations](rollupfield.md#BKMK_rollupfield_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_Letter_AsyncOperations"></a> Letter_AsyncOperations

See letter Entity [Letter_AsyncOperations](letter.md#BKMK_Letter_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_KbArticle_AsyncOperations"></a> KbArticle_AsyncOperations

See kbarticle Entity [KbArticle_AsyncOperations](kbarticle.md#BKMK_KbArticle_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_RecurringAppointmentMaster_AsyncOperations"></a> RecurringAppointmentMaster_AsyncOperations

See recurringappointmentmaster Entity [RecurringAppointmentMaster_AsyncOperations](recurringappointmentmaster.md#BKMK_RecurringAppointmentMaster_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_Task_AsyncOperations"></a> Task_AsyncOperations

See task Entity [Task_AsyncOperations](task.md#BKMK_Task_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_BusinessUnitNewsArticle_AsyncOperations"></a> BusinessUnitNewsArticle_AsyncOperations

See businessunitnewsarticle Entity [BusinessUnitNewsArticle_AsyncOperations](businessunitnewsarticle.md#BKMK_BusinessUnitNewsArticle_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_Connection_AsyncOperations"></a> Connection_AsyncOperations

See connection Entity [Connection_AsyncOperations](connection.md#BKMK_Connection_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_SystemUser_AsyncOperations"></a> SystemUser_AsyncOperations

See systemuser Entity [SystemUser_AsyncOperations](systemuser.md#BKMK_SystemUser_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_KbArticleTemplate_AsyncOperations"></a> KbArticleTemplate_AsyncOperations

See kbarticletemplate Entity [KbArticleTemplate_AsyncOperations](kbarticletemplate.md#BKMK_KbArticleTemplate_AsyncOperations) One-To-Many relationship.

### <a name="BKMK_SdkMessageProcessingStep_AsyncOperations"></a> SdkMessageProcessingStep_AsyncOperations

See sdkmessageprocessingstep Entity [SdkMessageProcessingStep_AsyncOperations](sdkmessageprocessingstep.md#BKMK_SdkMessageProcessingStep_AsyncOperations) One-To-Many relationship.

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

### See also

[About the Entity Reference](../about-entity-reference.md)<br />
[Programming reference for Dynamics 365 Customer Engagement](../programming-reference.md)<br />
[Web API Reference](/dynamics365/customer-engagement/web-api/about)<br />
<xref href="Microsoft.Dynamics.CRM.asyncoperation?text=asyncoperation EntityType" />


[!INCLUDE[footer-include](../../../../includes/footer-banner.md)]