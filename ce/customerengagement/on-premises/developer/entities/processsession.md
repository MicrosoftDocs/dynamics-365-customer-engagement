---
title: "ProcessSession Entity Reference (Dynamics 365 Customer Engagement)| MicrosoftDocs"
description: "Includes schema information and supported messages for the ProcessSession entity."
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
# ProcessSession Entity Reference

Information that is generated when a dialog is run. Every time that you run a dialog, a dialog session is created.


## Messages

|Message|Web API Operation|SDK Assembly|
|-|-|-|
|Assign|PATCH [*org URI*]/api/data/v9.0/processsessions(*processsessionid*)<br />[Update](/powerapps/developer/common-data-service/webapi/update-delete-entities-using-web-api#basic-update) `ownerid` property.|<xref:Microsoft.Crm.Sdk.Messages.AssignRequest>|
|Create|POST [*org URI*]/api/data/v9.0/processsessions<br />See [Create](/powerapps/developer/common-data-service/webapi/create-entity-web-api)|<xref:Microsoft.Xrm.Sdk.Messages.CreateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Create*>|
|Delete|DELETE [*org URI*]/api/data/v9.0/processsessions(*processsessionid*)<br />See [Delete](/powerapps/developer/common-data-service/webapi/update-delete-entities-using-web-api#basic-delete)|<xref:Microsoft.Xrm.Sdk.Messages.DeleteRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Delete*>|
|GrantAccess|<xref href="Microsoft.Dynamics.CRM.GrantAccess?text=GrantAccess Action" />|<xref:Microsoft.Crm.Sdk.Messages.GrantAccessRequest>|
|ModifyAccess|<xref href="Microsoft.Dynamics.CRM.ModifyAccess?text=ModifyAccess Action" />|<xref:Microsoft.Crm.Sdk.Messages.ModifyAccessRequest>|
|Retrieve|GET [*org URI*]/api/data/v9.0/processsessions(*processsessionid*)<br />See [Retrieve](/powerapps/developer/common-data-service/webapi/retrieve-entity-using-web-api)|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Retrieve*>|
|RetrieveMultiple|GET [*org URI*]/api/data/v9.0/processsessions<br />See [Query Data](/powerapps/developer/common-data-service/webapi/query-data-web-api)|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveMultipleRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.RetrieveMultiple*>|
|RetrievePrincipalAccess|<xref href="Microsoft.Dynamics.CRM.RetrievePrincipalAccess?text=RetrievePrincipalAccess Function" />|<xref:Microsoft.Crm.Sdk.Messages.RetrievePrincipalAccessRequest>|
|RetrieveSharedPrincipalsAndAccess|<xref href="Microsoft.Dynamics.CRM.RetrieveSharedPrincipalsAndAccess?text=RetrieveSharedPrincipalsAndAccess Function" />|<xref:Microsoft.Crm.Sdk.Messages.RetrieveSharedPrincipalsAndAccessRequest>|
|RevokeAccess|<xref href="Microsoft.Dynamics.CRM.RevokeAccess?text=RevokeAccess Action" />|<xref:Microsoft.Crm.Sdk.Messages.RevokeAccessRequest>|
|SetState|PATCH [*org URI*]/api/data/v9.0/processsessions(*processsessionid*)<br />[Update](/powerapps/developer/common-data-service/webapi/update-delete-entities-using-web-api#basic-update) `statecode` and `statuscode` properties.|<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|
|Update|PATCH [*org URI*]/api/data/v9.0/processsessions(*processsessionid*)<br />See [Update](/powerapps/developer/common-data-service/webapi/update-delete-entities-using-web-api#basic-update)|<xref:Microsoft.Xrm.Sdk.Messages.UpdateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Update*>|

## Entity Properties

|Property|Value|
|--------|-----|
|CollectionSchemaName|ProcessSession|
|DisplayCollectionName|Process Sessions|
|DisplayName|Process Session|
|EntitySetName|processsessions|
|IsBPFEntity|False|
|LogicalCollectionName|processsessions|
|LogicalName|processsession|
|OwnershipType|UserOwned|
|PrimaryIdAttribute|processsessionid|
|PrimaryNameAttribute|name|
|SchemaName|ProcessSession|

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

|Property|Value|
|--------|-----|
|Description|Name of the activity that is being executed.|
|DisplayName|Activity Name|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|activityname|
|MaxLength|256|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_CanceledOn"></a> CanceledOn

|Property|Value|
|--------|-----|
|DateTimeBehavior|UserLocal|
|Description|Date and time when the dialog session was canceled.|
|DisplayName|Canceled On|
|Format|DateAndTime|
|IsValidForCreate|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|canceledon|
|RequiredLevel|None|
|Type|DateTime|


### <a name="BKMK_Comments"></a> Comments

|Property|Value|
|--------|-----|
|Description|User comments.|
|DisplayName|Comments|
|Format|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|comments|
|MaxLength|2000|
|RequiredLevel|None|
|Type|Memo|


### <a name="BKMK_CompletedOn"></a> CompletedOn

|Property|Value|
|--------|-----|
|DateTimeBehavior|UserLocal|
|Description|Date and time when the dialog session was completed.|
|DisplayName|Completed On|
|Format|DateAndTime|
|IsValidForCreate|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|completedon|
|RequiredLevel|None|
|Type|DateTime|


### <a name="BKMK_ErrorCode"></a> ErrorCode

|Property|Value|
|--------|-----|
|Description|Error code related to the dialog session.|
|DisplayName|Error Code|
|Format|None|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|errorcode|
|MaxValue|2147483647|
|MinValue|-2147483648|
|RequiredLevel|None|
|Type|Integer|


### <a name="BKMK_ExecutedBy"></a> ExecutedBy

|Property|Value|
|--------|-----|
|Description|Unique identifier of the user who ran the dialog process.|
|DisplayName|Executed By|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|executedby|
|RequiredLevel|None|
|Targets|systemuser|
|Type|Lookup|


### <a name="BKMK_InputArguments"></a> InputArguments

|Property|Value|
|--------|-----|
|Description|Input arguments for the child dialog process.|
|DisplayName|Input Arguments|
|Format|TextArea|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|IsValidForUpdate|False|
|LogicalName|inputarguments|
|MaxLength|1073741823|
|RequiredLevel|None|
|Type|Memo|


### <a name="BKMK_Name"></a> Name

|Property|Value|
|--------|-----|
|Description|Name of the dialog session.|
|DisplayName|Name|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|name|
|MaxLength|256|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_NextLinkedSessionId"></a> NextLinkedSessionId

|Property|Value|
|--------|-----|
|Description|Unique identifier of the succeeding linked dialog session.|
|DisplayName|Next Linked Session|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|nextlinkedsessionid|
|RequiredLevel|None|
|Targets|processsession|
|Type|Lookup|


### <a name="BKMK_OriginatingSessionId"></a> OriginatingSessionId

|Property|Value|
|--------|-----|
|Description|Unique identifier of the originating dialog session.|
|DisplayName|Originating Session|
|IsValidForForm|True|
|IsValidForRead|True|
|IsValidForUpdate|False|
|LogicalName|originatingsessionid|
|RequiredLevel|None|
|Targets|processsession|
|Type|Lookup|


### <a name="BKMK_OwnerId"></a> OwnerId

|Property|Value|
|--------|-----|
|Description|Unique identifier of the user or team who owns the dialog session.|
|DisplayName|Owner|
|IsValidForForm|False|
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


### <a name="BKMK_PreviousLinkedSessionId"></a> PreviousLinkedSessionId

|Property|Value|
|--------|-----|
|Description|Unique identifier of the preceding linked dialog session.|
|DisplayName|Previous Linked Session|
|IsValidForForm|True|
|IsValidForRead|True|
|IsValidForUpdate|False|
|LogicalName|previouslinkedsessionid|
|RequiredLevel|None|
|Targets|processsession|
|Type|Lookup|


### <a name="BKMK_ProcessId"></a> ProcessId

|Property|Value|
|--------|-----|
|Description|Select the process activation record that is related to the dialog session.|
|DisplayName|Process|
|IsValidForForm|False|
|IsValidForRead|True|
|IsValidForUpdate|False|
|LogicalName|processid|
|RequiredLevel|None|
|Targets|workflow|
|Type|Lookup|


### <a name="BKMK_ProcessSessionId"></a> ProcessSessionId

|Property|Value|
|--------|-----|
|Description|Unique identifier of the dialog session.|
|DisplayName|Dialog Session|
|IsValidForForm|False|
|IsValidForRead|True|
|IsValidForUpdate|False|
|LogicalName|processsessionid|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|


### <a name="BKMK_ProcessStageName"></a> ProcessStageName

|Property|Value|
|--------|-----|
|Description|Name of the dialog stage.|
|DisplayName|Dialog Stage|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|processstagename|
|MaxLength|256|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_ProcessState"></a> ProcessState

|Property|Value|
|--------|-----|
|Description|State of the dialog process.|
|DisplayName|Process State|
|FormatName|TextArea|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|processstate|
|MaxLength|1073741823|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_RegardingObjectId"></a> RegardingObjectId

|Property|Value|
|--------|-----|
|Description|Unique identifier of the object with which the dialog session is associated.|
|DisplayName|Regarding|
|IsValidForForm|False|
|IsValidForRead|True|
|IsValidForUpdate|False|
|LogicalName|regardingobjectid|
|RequiredLevel|None|
|Targets|account,adminsettingsentity,annotation,appointment,bookableresource,bookableresourcebooking,bookableresourcebookingheader,bookableresourcecategory,bookableresourcecategoryassn,bookableresourcecharacteristic,bookableresourcegroup,bookingstatus,businessunit,businessunitnewsarticle,campaign,campaignactivity,campaignresponse,channelaccessprofile,channelaccessprofilerule,characteristic,competitor,connection,connectionrole,constraintbasedgroup,contact,contract,contractdetail,contracttemplate,convertrule,customeraddress,customeropportunityrole,customerrelationship,discount,discounttype,email,entitlement,entitlementchannel,entitlemententityallocationtypemapping,entitlementtemplate,equipment,expiredprocess,externalparty,externalpartyitem,fax,goal,goalrollupquery,holidaywrapper,incident,invoice,invoicedetail,kbarticle,kbarticlecomment,kbarticletemplate,knowledgearticle,knowledgearticleincident,knowledgebaserecord,lead,leadtoopportunitysalesprocess,letter,list,mailbox,mailmergetemplate,metric,msdyn_3dmodel,msdyn_accountpricelist,msdyn_actual,msdyn_agreement,msdyn_agreementbookingdate,msdyn_agreementbookingincident,msdyn_agreementbookingproduct,msdyn_agreementbookingservice,msdyn_agreementbookingservicetask,msdyn_agreementbookingsetup,msdyn_agreementinvoicedate,msdyn_agreementinvoiceproduct,msdyn_agreementinvoicesetup,msdyn_agreementsubstatus,msdyn_analysiscomponent,msdyn_analysisjob,msdyn_analysisresult,msdyn_analysisresultdetail,msdyn_approval,msdyn_batchjob,msdyn_bookableresourceassociation,msdyn_bookingalert,msdyn_bookingalertstatus,msdyn_bookingchange,msdyn_bookingjournal,msdyn_bookingrule,msdyn_bookingsetupmetadata,msdyn_bookingtimestamp,msdyn_bpf_2c5fe86acc8b414b8322ae571000c799,msdyn_bpf_477c16f59170487b8b4dc895c5dcd09b,msdyn_bpf_665e73aa18c247d886bfc50499c73b82,msdyn_bpf_989e9b1857e24af18787d5143b67523b,msdyn_bpf_baa0a411a239410cb8bded8b5fdd88e3,msdyn_bpf_d3d97bac8c294105840e99e37a9d1c39,msdyn_bpf_d8f9dc7f099f44db9d641dd81fbd470d,msdyn_businessclosure,msdyn_callablecontext,msdyn_characteristicreqforteammember,msdyn_clientextension,msdyn_configuration,msdyn_connector,msdyn_contactpricelist,msdyn_contractlineinvoiceschedule,msdyn_contractlinescheduleofvalue,msdyn_customerasset,msdyn_customerassetcategory,msdyn_databaseversion,msdyn_dataexport,msdyn_delegation,msdyn_dimension,msdyn_dimensionfieldname,msdyn_entitlementapplication,msdyn_entityconfiguration,msdyn_estimate,msdyn_estimateline,msdyn_expense,msdyn_expensecategory,msdyn_expensereceipt,msdyn_fact,msdyn_fieldcomputation,msdyn_fieldservicepricelistitem,msdyn_fieldservicesetting,msdyn_fieldserviceslaconfiguration,msdyn_fieldservicesystemjob,msdyn_findworkevent,msdyn_forecastdefinition,msdyn_forecastinstance,msdyn_forecastrecurrence,msdyn_geofence,msdyn_geofenceevent,msdyn_geofencingsettings,msdyn_icebreakersconfig,msdyn_incidenttype,msdyn_incidenttypecharacteristic,msdyn_incidenttypeproduct,msdyn_incidenttypeservice,msdyn_incidenttypeservicetask,msdyn_incidenttypessetup,msdyn_incidenttype_requirementgroup,msdyn_integrationjob,msdyn_integrationjobdetail,msdyn_inventoryadjustment,msdyn_inventoryadjustmentproduct,msdyn_inventoryjournal,msdyn_inventorytransfer,msdyn_invoicefrequency,msdyn_invoicefrequencydetail,msdyn_invoicelinetransaction,msdyn_iotalert,msdyn_iotdevice,msdyn_iotdevicecategory,msdyn_iotdevicecommand,msdyn_iotdevicecommanddefinition,msdyn_iotdevicedatahistory,msdyn_iotdeviceproperty,msdyn_iotdeviceregistrationhistory,msdyn_iotpropertydefinition,msdyn_iotsettings,msdyn_journal,msdyn_journalline,msdyn_mlresultcache,msdyn_notesanalysisconfig,msdyn_opportunitylineresourcecategory,msdyn_opportunitylinetransaction,msdyn_opportunitylinetransactioncategory,msdyn_opportunitylinetransactionclassificatio,msdyn_opportunitypricelist,msdyn_orderinvoicingdate,msdyn_orderinvoicingproduct,msdyn_orderinvoicingsetup,msdyn_orderinvoicingsetupdate,msdyn_orderlineresourcecategory,msdyn_orderlinetransaction,msdyn_orderlinetransactioncategory,msdyn_orderlinetransactionclassification,msdyn_orderpricelist,msdyn_organizationalunit,msdyn_payment,msdyn_paymentdetail,msdyn_paymentmethod,msdyn_paymentterm,msdyn_playbookactivity,msdyn_playbookactivityattribute,msdyn_playbookcategory,msdyn_playbookinstance,msdyn_playbooktemplate,msdyn_postalbum,msdyn_postalcode,msdyn_postconfig,msdyn_postruleconfig,msdyn_priority,msdyn_processnotes,msdyn_productinventory,msdyn_project,msdyn_projectapproval,msdyn_projectparameter,msdyn_projectparameterpricelist,msdyn_projectpricelist,msdyn_projecttask,msdyn_projecttaskdependency,msdyn_projecttaskstatususer,msdyn_projectteam,msdyn_projectteammembersignup,msdyn_projecttransactioncategory,msdyn_purchaseorder,msdyn_purchaseorderbill,msdyn_purchaseorderproduct,msdyn_purchaseorderreceipt,msdyn_purchaseorderreceiptproduct,msdyn_purchaseordersubstatus,msdyn_quotebookingincident,msdyn_quotebookingproduct,msdyn_quotebookingservice,msdyn_quotebookingservicetask,msdyn_quotebookingsetup,msdyn_quoteinvoicingproduct,msdyn_quoteinvoicingsetup,msdyn_quotelineanalyticsbreakdown,msdyn_quotelineinvoiceschedule,msdyn_quotelineresourcecategory,msdyn_quotelinescheduleofvalue,msdyn_quotelinetransaction,msdyn_quotelinetransactioncategory,msdyn_quotelinetransactionclassification,msdyn_quotepricelist,msdyn_relationshipinsightsunifiedconfig,msdyn_requirementcharacteristic,msdyn_requirementgroup,msdyn_requirementorganizationunit,msdyn_requirementrelationship,msdyn_requirementresourcecategory,msdyn_requirementresourcepreference,msdyn_requirementstatus,msdyn_resourceassignment,msdyn_resourceassignmentdetail,msdyn_resourcecategorymarkuppricelevel,msdyn_resourcecategorypricelevel,msdyn_resourcepaytype,msdyn_resourcerequest,msdyn_resourcerequirement,msdyn_resourcerequirementdetail,msdyn_resourceterritory,msdyn_rma,msdyn_rmaproduct,msdyn_rmareceipt,msdyn_rmareceiptproduct,msdyn_rmasubstatus,msdyn_rolecompetencyrequirement,msdyn_roleutilization,msdyn_rtv,msdyn_rtvproduct,msdyn_rtvsubstatus,msdyn_scheduleboardsetting,msdyn_schedulingparameter,msdyn_servicetasktype,msdyn_shipvia,msdyn_siconfig,msdyn_solutionhealthrule,msdyn_solutionhealthruleargument,msdyn_solutionhealthruleset,msdyn_systemuserschedulersetting,msdyn_taxcode,msdyn_taxcodedetail,msdyn_teamscollaboration,msdyn_timeentry,msdyn_timegroup,msdyn_timegroupdetail,msdyn_timeoffcalendar,msdyn_timeoffrequest,msdyn_transactioncategory,msdyn_transactioncategoryclassification,msdyn_transactioncategoryhierarchyelement,msdyn_transactioncategorypricelevel,msdyn_transactionconnection,msdyn_transactionorigin,msdyn_transactiontype,msdyn_uniquenumber,msdyn_untrackedappointment,msdyn_upgraderun,msdyn_upgradestep,msdyn_upgradeversion,msdyn_userworkhistory,msdyn_wallsavedquery,msdyn_wallsavedqueryusersettings,msdyn_warehouse,msdyn_workhourtemplate,msdyn_workorder,msdyn_workordercharacteristic,msdyn_workorderdetailsgenerationqueue,msdyn_workorderincident,msdyn_workorderproduct,msdyn_workorderresourcerestriction,msdyn_workorderservice,msdyn_workorderservicetask,msdyn_workordersubstatus,msdyn_workordertype,msfp_emailtemplate,msfp_question,msfp_questionresponse,msfp_survey,msfp_surveyinvite,msfp_surveyresponse,msfp_unsubscribedrecipient,newprocess,opportunity,opportunityproduct,opportunitysalesprocess,phonecall,phonetocaseprocess,position,pricelevel,product,productassociation,productpricelevel,productsubstitute,queue,queueitem,quote,quotedetail,ratingmodel,ratingvalue,recurringappointmentmaster,relationshiprole,report,rollupfield,routingrule,routingruleitem,salesliterature,salesliteratureitem,salesorder,salesorderdetail,service,serviceappointment,sharepointdocumentlocation,sharepointsite,site,sla,socialactivity,socialprofile,subject,systemuser,task,team,template,territory,theme,transactioncurrency,translationprocess,usermapping|
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
|MaxLength|400|
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
|MaxLength|400|
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


### <a name="BKMK_StartedOn"></a> StartedOn

|Property|Value|
|--------|-----|
|DateTimeBehavior|UserLocal|
|Description|Date and time when the dialog session was started.|
|DisplayName|Started On|
|Format|DateAndTime|
|IsValidForForm|True|
|IsValidForRead|True|
|IsValidForUpdate|False|
|LogicalName|startedon|
|RequiredLevel|None|
|Type|DateTime|


### <a name="BKMK_StateCode"></a> StateCode

|Property|Value|
|--------|-----|
|Description|Status of the dialog session.|
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
|0|Incomplete|1|Incomplete|
|1|Complete|2|Complete|



### <a name="BKMK_StatusCode"></a> StatusCode

|Property|Value|
|--------|-----|
|Description|Reason for the status of the dialog session.|
|DisplayName|Status Reason|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|statuscode|
|RequiredLevel|None|
|Type|Status|

#### StatusCode Options

|Value|Label|State|
|-----|-----|-----|
|1|Not Started|0|
|2|In Progress|0|
|3|Paused|0|
|4|Completed|1|
|5|Canceled|1|
|6|Failed|1|



### <a name="BKMK_StepName"></a> StepName

|Property|Value|
|--------|-----|
|Description|Name of the dialog step.|
|DisplayName|Step Name|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|stepname|
|MaxLength|256|
|RequiredLevel|None|
|Type|String|

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

|Property|Value|
|--------|-----|
|Description|Unique identifier of the user who canceled the dialog session.|
|DisplayName|Canceled By|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|canceledby|
|RequiredLevel|None|
|Targets|systemuser|
|Type|Lookup|


### <a name="BKMK_CanceledByName"></a> CanceledByName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|canceledbyname|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_CanceledByYomiName"></a> CanceledByYomiName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|canceledbyyominame|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_CompletedBy"></a> CompletedBy

|Property|Value|
|--------|-----|
|Description|Unique identifier of the user who completed the dialog session.|
|DisplayName|Completed By|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|completedby|
|RequiredLevel|None|
|Targets|systemuser|
|Type|Lookup|


### <a name="BKMK_CompletedByName"></a> CompletedByName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|completedbyname|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_CompletedByYomiName"></a> CompletedByYomiName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|completedbyyominame|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_CreatedBy"></a> CreatedBy

|Property|Value|
|--------|-----|
|Description|Unique identifier of the user who started the dialog session.|
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
|Description|Date and time when the dialog session was created.|
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
|Description|Unique identifier of the delegate user who created the dialog session.|
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


### <a name="BKMK_ExecutedByName"></a> ExecutedByName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|executedbyname|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_ExecutedByYomiName"></a> ExecutedByYomiName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|executedbyyominame|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_ExecutedOn"></a> ExecutedOn

|Property|Value|
|--------|-----|
|DateTimeBehavior|UserLocal|
|Description|Date and time when the dialog process was run.|
|DisplayName|Executed On|
|Format|DateAndTime|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|executedon|
|RequiredLevel|None|
|Type|DateTime|


### <a name="BKMK_ModifiedBy"></a> ModifiedBy

|Property|Value|
|--------|-----|
|Description|Unique identifier of the user who last modified the dialog session.|
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
|Description|Date and time when the dialog session was last modified.|
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
|Description|Unique identifier of the delegate user who modified the dialog session.|
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


### <a name="BKMK_NextLinkedSessionIdName"></a> NextLinkedSessionIdName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|nextlinkedsessionidname|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_OriginatingSessionIdName"></a> OriginatingSessionIdName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|originatingsessionidname|
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
|Description|Unique identifier of the business unit that owns the dialog session.|
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
|Description|Unique identifier of the team who owns the dialog session.|
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
|Description|Unique identifier of the user who owns the dialog session.|
|DisplayName|Owning User|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|owninguser|
|RequiredLevel|None|
|Targets|systemuser|
|Type|Lookup|


### <a name="BKMK_PreviousLinkedSessionIdName"></a> PreviousLinkedSessionIdName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|previouslinkedsessionidname|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_ProcessIdName"></a> ProcessIdName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|processidname|
|MaxLength|160|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_ProtectionKey"></a> ProtectionKey

|Property|Value|
|--------|-----|
|Description|For internal use only.|
|DisplayName|Protection Key|
|FormatName|TextArea|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|False|
|LogicalName|protectionkey|
|MaxLength|256|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_StartedBy"></a> StartedBy

|Property|Value|
|--------|-----|
|Description|Unique identifier of the user who started the dialog session.|
|DisplayName|Started By|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|startedby|
|RequiredLevel|None|
|Targets|systemuser|
|Type|Lookup|


### <a name="BKMK_StartedByName"></a> StartedByName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|startedbyname|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_StartedByYomiName"></a> StartedByYomiName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|startedbyyominame|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|

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


### <a name="BKMK_lk_workflowlog_processsession"></a> lk_workflowlog_processsession

Same as workflowlog entity [lk_workflowlog_processsession](workflowlog.md#BKMK_lk_workflowlog_processsession) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|workflowlog|
|ReferencingAttribute|asyncoperationid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|lk_workflowlog_processsession|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: Cascade<br />Reparent: Cascade<br />Share: Cascade<br />Unshare: Cascade|


### <a name="BKMK_lk_workflowlog_processsession_childworkflow"></a> lk_workflowlog_processsession_childworkflow

Same as workflowlog entity [lk_workflowlog_processsession_childworkflow](workflowlog.md#BKMK_lk_workflowlog_processsession_childworkflow) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|workflowlog|
|ReferencingAttribute|childworkflowinstanceid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|lk_workflowlog_processsession_childworkflow|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_lk_processsession_previouslinkedsessionid"></a> lk_processsession_previouslinkedsessionid

Same as processsession entity [lk_processsession_previouslinkedsessionid](processsession.md#BKMK_lk_processsession_previouslinkedsessionid) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|processsession|
|ReferencingAttribute|previouslinkedsessionid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|lk_processsession_previouslinkedsessionid|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: RemoveLink<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_lk_processsession_nextlinkedsessionid"></a> lk_processsession_nextlinkedsessionid

Same as processsession entity [lk_processsession_nextlinkedsessionid](processsession.md#BKMK_lk_processsession_nextlinkedsessionid) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|processsession|
|ReferencingAttribute|nextlinkedsessionid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|lk_processsession_nextlinkedsessionid|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: RemoveLink<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_lk_processsession_originatingsessionid"></a> lk_processsession_originatingsessionid

Same as processsession entity [lk_processsession_originatingsessionid](processsession.md#BKMK_lk_processsession_originatingsessionid) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|processsession|
|ReferencingAttribute|originatingsessionid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|lk_processsession_originatingsessionid|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: RemoveLink<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_processsession_connections2"></a> processsession_connections2

Same as connection entity [processsession_connections2](connection.md#BKMK_processsession_connections2) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|connection|
|ReferencingAttribute|record2id|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|processsession_connections2|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: 100|
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_ProcessSession_SyncErrors"></a> ProcessSession_SyncErrors

Same as syncerror entity [ProcessSession_SyncErrors](syncerror.md#BKMK_ProcessSession_SyncErrors) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|syncerror|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|ProcessSession_SyncErrors|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: Cascade<br />Reparent: Cascade<br />Share: Cascade<br />Unshare: Cascade|


### <a name="BKMK_processsession_connections1"></a> processsession_connections1

Same as connection entity [processsession_connections1](connection.md#BKMK_processsession_connections1) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|connection|
|ReferencingAttribute|record1id|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|processsession_connections1|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Details<br />Label: <br />Order: 100|
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_processsession_PostFollows"></a> processsession_PostFollows

Same as postfollow entity [processsession_PostFollows](postfollow.md#BKMK_processsession_PostFollows) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|postfollow|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|processsession_PostFollows|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|

<a name="manytoone"></a>

## Many-To-One Relationships

Each Many-To-One relationship is defined by a corresponding One-To-Many relationship with the related entity. Listed by **SchemaName**.

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
- [msdyn_databaseversion_ProcessSession](#BKMK_msdyn_databaseversion_ProcessSession)
- [msdyn_upgraderun_ProcessSession](#BKMK_msdyn_upgraderun_ProcessSession)
- [msdyn_upgradestep_ProcessSession](#BKMK_msdyn_upgradestep_ProcessSession)
- [msdyn_upgradeversion_ProcessSession](#BKMK_msdyn_upgradeversion_ProcessSession)
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
- [entitlemententityallocationtypemapping_ProcessSession](#BKMK_entitlemententityallocationtypemapping_ProcessSession)
- [msdyn_callablecontext_ProcessSession](#BKMK_msdyn_callablecontext_ProcessSession)
- [msdyn_playbookactivity_ProcessSession](#BKMK_msdyn_playbookactivity_ProcessSession)
- [msdyn_playbookactivityattribute_ProcessSession](#BKMK_msdyn_playbookactivityattribute_ProcessSession)
- [msdyn_playbookcategory_ProcessSession](#BKMK_msdyn_playbookcategory_ProcessSession)
- [msdyn_playbookinstance_ProcessSession](#BKMK_msdyn_playbookinstance_ProcessSession)
- [msdyn_playbooktemplate_ProcessSession](#BKMK_msdyn_playbooktemplate_ProcessSession)
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
- [adminsettingsentity_ProcessSession](#BKMK_adminsettingsentity_ProcessSession)
- [msdyn_forecastdefinition_ProcessSession](#BKMK_msdyn_forecastdefinition_ProcessSession)
- [msdyn_forecastinstance_ProcessSession](#BKMK_msdyn_forecastinstance_ProcessSession)
- [msdyn_forecastrecurrence_ProcessSession](#BKMK_msdyn_forecastrecurrence_ProcessSession)
- [msdyn_relationshipinsightsunifiedconfig_ProcessSession](#BKMK_msdyn_relationshipinsightsunifiedconfig_ProcessSession)
- [msdyn_siconfig_ProcessSession](#BKMK_msdyn_siconfig_ProcessSession)
- [msdyn_untrackedappointment_ProcessSession](#BKMK_msdyn_untrackedappointment_ProcessSession)
- [msdyn_notesanalysisconfig_ProcessSession](#BKMK_msdyn_notesanalysisconfig_ProcessSession)
- [msdyn_icebreakersconfig_ProcessSession](#BKMK_msdyn_icebreakersconfig_ProcessSession)
- [msdyn_postalbum_ProcessSession](#BKMK_msdyn_postalbum_ProcessSession)
- [msdyn_postconfig_ProcessSession](#BKMK_msdyn_postconfig_ProcessSession)
- [msdyn_postruleconfig_ProcessSession](#BKMK_msdyn_postruleconfig_ProcessSession)
- [msdyn_wallsavedquery_ProcessSession](#BKMK_msdyn_wallsavedquery_ProcessSession)
- [msdyn_wallsavedqueryusersettings_ProcessSession](#BKMK_msdyn_wallsavedqueryusersettings_ProcessSession)
- [msdyn_teamscollaboration_ProcessSession](#BKMK_msdyn_teamscollaboration_ProcessSession)
- [msdyn_actual_ProcessSession](#BKMK_msdyn_actual_ProcessSession)
- [msdyn_bookableresourceassociation_ProcessSession](#BKMK_msdyn_bookableresourceassociation_ProcessSession)
- [msdyn_bookingalert_ProcessSession](#BKMK_msdyn_bookingalert_ProcessSession)
- [msdyn_bookingalertstatus_ProcessSession](#BKMK_msdyn_bookingalertstatus_ProcessSession)
- [msdyn_bookingchange_ProcessSession](#BKMK_msdyn_bookingchange_ProcessSession)
- [msdyn_bookingrule_ProcessSession](#BKMK_msdyn_bookingrule_ProcessSession)
- [msdyn_bookingsetupmetadata_ProcessSession](#BKMK_msdyn_bookingsetupmetadata_ProcessSession)
- [msdyn_businessclosure_ProcessSession](#BKMK_msdyn_businessclosure_ProcessSession)
- [msdyn_clientextension_ProcessSession](#BKMK_msdyn_clientextension_ProcessSession)
- [msdyn_configuration_ProcessSession](#BKMK_msdyn_configuration_ProcessSession)
- [msdyn_organizationalunit_ProcessSession](#BKMK_msdyn_organizationalunit_ProcessSession)
- [msdyn_priority_ProcessSession](#BKMK_msdyn_priority_ProcessSession)
- [msdyn_requirementcharacteristic_ProcessSession](#BKMK_msdyn_requirementcharacteristic_ProcessSession)
- [msdyn_requirementgroup_ProcessSession](#BKMK_msdyn_requirementgroup_ProcessSession)
- [msdyn_requirementorganizationunit_ProcessSession](#BKMK_msdyn_requirementorganizationunit_ProcessSession)
- [msdyn_requirementrelationship_ProcessSession](#BKMK_msdyn_requirementrelationship_ProcessSession)
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
- [msdyn_dimension_ProcessSession](#BKMK_msdyn_dimension_ProcessSession)
- [msdyn_dimensionfieldname_ProcessSession](#BKMK_msdyn_dimensionfieldname_ProcessSession)
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
- [msdyn_resourcecategorymarkuppricelevel_ProcessSession](#BKMK_msdyn_resourcecategorymarkuppricelevel_ProcessSession)
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
- [msdyn_customerassetcategory_ProcessSession](#BKMK_msdyn_customerassetcategory_ProcessSession)
- [msdyn_entitlementapplication_ProcessSession](#BKMK_msdyn_entitlementapplication_ProcessSession)
- [msdyn_fieldservicepricelistitem_ProcessSession](#BKMK_msdyn_fieldservicepricelistitem_ProcessSession)
- [msdyn_fieldservicesetting_ProcessSession](#BKMK_msdyn_fieldservicesetting_ProcessSession)
- [msdyn_fieldserviceslaconfiguration_ProcessSession](#BKMK_msdyn_fieldserviceslaconfiguration_ProcessSession)
- [msdyn_fieldservicesystemjob_ProcessSession](#BKMK_msdyn_fieldservicesystemjob_ProcessSession)
- [msdyn_incidenttype_ProcessSession](#BKMK_msdyn_incidenttype_ProcessSession)
- [msdyn_incidenttypecharacteristic_ProcessSession](#BKMK_msdyn_incidenttypecharacteristic_ProcessSession)
- [msdyn_incidenttypeproduct_ProcessSession](#BKMK_msdyn_incidenttypeproduct_ProcessSession)
- [msdyn_incidenttypeservice_ProcessSession](#BKMK_msdyn_incidenttypeservice_ProcessSession)
- [msdyn_incidenttypeservicetask_ProcessSession](#BKMK_msdyn_incidenttypeservicetask_ProcessSession)
- [msdyn_incidenttypessetup_ProcessSession](#BKMK_msdyn_incidenttypessetup_ProcessSession)
- [msdyn_incidenttype_requirementgroup_ProcessSession](#BKMK_msdyn_incidenttype_requirementgroup_ProcessSession)
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
- [msdyn_iotalert_ProcessSession](#BKMK_msdyn_iotalert_ProcessSession)
- [msdyn_iotdevice_ProcessSession](#BKMK_msdyn_iotdevice_ProcessSession)
- [msdyn_iotdevicecategory_ProcessSession](#BKMK_msdyn_iotdevicecategory_ProcessSession)
- [msdyn_iotdevicecommand_ProcessSession](#BKMK_msdyn_iotdevicecommand_ProcessSession)
- [msdyn_iotdevicecommanddefinition_ProcessSession](#BKMK_msdyn_iotdevicecommanddefinition_ProcessSession)
- [msdyn_iotdevicedatahistory_ProcessSession](#BKMK_msdyn_iotdevicedatahistory_ProcessSession)
- [msdyn_iotdeviceproperty_ProcessSession](#BKMK_msdyn_iotdeviceproperty_ProcessSession)
- [msdyn_iotdeviceregistrationhistory_ProcessSession](#BKMK_msdyn_iotdeviceregistrationhistory_ProcessSession)
- [msdyn_iotpropertydefinition_ProcessSession](#BKMK_msdyn_iotpropertydefinition_ProcessSession)
- [msdyn_iotsettings_ProcessSession](#BKMK_msdyn_iotsettings_ProcessSession)
- [msdyn_bpf_477c16f59170487b8b4dc895c5dcd09b_ProcessSession](#BKMK_msdyn_bpf_477c16f59170487b8b4dc895c5dcd09b_ProcessSession)
- [msdyn_entityconfiguration_ProcessSession](#BKMK_msdyn_entityconfiguration_ProcessSession)
- [msdyn_geofence_ProcessSession](#BKMK_msdyn_geofence_ProcessSession)
- [msdyn_geofenceevent_ProcessSession](#BKMK_msdyn_geofenceevent_ProcessSession)
- [msdyn_geofencingsettings_ProcessSession](#BKMK_msdyn_geofencingsettings_ProcessSession)
- [msdyn_connector_ProcessSession](#BKMK_msdyn_connector_ProcessSession)
- [theme_ProcessSession](#BKMK_theme_ProcessSession)
- [usermapping_ProcessSession](#BKMK_usermapping_ProcessSession)
- [knowledgearticle_ProcessSession](#BKMK_knowledgearticle_ProcessSession)
- [position_ProcessSession](#BKMK_position_ProcessSession)
- [KnowledgeBaseRecord_ProcessSession](#BKMK_KnowledgeBaseRecord_ProcessSession)
- [SharePointSite_ProcessSessions](#BKMK_SharePointSite_ProcessSessions)
- [MailMergeTemplate_ProcessSessions](#BKMK_MailMergeTemplate_ProcessSessions)
- [Annotation_ProcessSessions](#BKMK_Annotation_ProcessSessions)
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
- [SharePointDocumentLocation_ProcessSessions](#BKMK_SharePointDocumentLocation_ProcessSessions)
- [lk_processsession_startedby](#BKMK_lk_processsession_startedby)
- [Account_ProcessSessions](#BKMK_Account_ProcessSessions)
- [PhoneCall_ProcessSessions](#BKMK_PhoneCall_ProcessSessions)
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
- [RecurringAppointmentMaster_ProcessSessions](#BKMK_RecurringAppointmentMaster_ProcessSessions)
- [Email_ProcessSessions](#BKMK_Email_ProcessSessions)
- [lk_processsession_completedby](#BKMK_lk_processsession_completedby)
- [Contact_ProcessSessions](#BKMK_Contact_ProcessSessions)
- [Queue_ProcessSessions](#BKMK_Queue_ProcessSessions)
- [lk_processsessionbase_createdonbehalfby](#BKMK_lk_processsessionbase_createdonbehalfby)
- [Subject_ProcessSessions](#BKMK_Subject_ProcessSessions)
- [SocialProfile_ProcessSessions](#BKMK_SocialProfile_ProcessSessions)


### <a name="BKMK_Territory_ProcessSessions"></a> Territory_ProcessSessions

**Added by**: Application Common Solution

See territory Entity [Territory_ProcessSessions](territory.md#BKMK_Territory_ProcessSessions) One-To-Many relationship.

### <a name="BKMK_Lead_ProcessSessions"></a> Lead_ProcessSessions

**Added by**: Lead Management Solution

See lead Entity [Lead_ProcessSessions](lead.md#BKMK_Lead_ProcessSessions) One-To-Many relationship.

### <a name="BKMK_PriceLevel_ProcessSessions"></a> PriceLevel_ProcessSessions

**Added by**: Product Management Solution

See pricelevel Entity [PriceLevel_ProcessSessions](pricelevel.md#BKMK_PriceLevel_ProcessSessions) One-To-Many relationship.

### <a name="BKMK_Product_ProcessSessions"></a> Product_ProcessSessions

**Added by**: Product Management Solution

See product Entity [Product_ProcessSessions](product.md#BKMK_Product_ProcessSessions) One-To-Many relationship.

### <a name="BKMK_ProductAssociation_ProcessSessions"></a> ProductAssociation_ProcessSessions

**Added by**: Product Management Solution

See productassociation Entity [ProductAssociation_ProcessSessions](productassociation.md#BKMK_ProductAssociation_ProcessSessions) One-To-Many relationship.

### <a name="BKMK_ProductPriceLevel_ProcessSessions"></a> ProductPriceLevel_ProcessSessions

**Added by**: Product Management Solution

See productpricelevel Entity [ProductPriceLevel_ProcessSessions](productpricelevel.md#BKMK_ProductPriceLevel_ProcessSessions) One-To-Many relationship.

### <a name="BKMK_ProductSubstitute_ProcessSession"></a> ProductSubstitute_ProcessSession

**Added by**: Product Management Solution

See productsubstitute Entity [ProductSubstitute_ProcessSession](productsubstitute.md#BKMK_ProductSubstitute_ProcessSession) One-To-Many relationship.

### <a name="BKMK_bookableresource_ProcessSession"></a> bookableresource_ProcessSession

**Added by**: Scheduling Solution

See bookableresource Entity [bookableresource_ProcessSession](bookableresource.md#BKMK_bookableresource_ProcessSession) One-To-Many relationship.

### <a name="BKMK_bookableresourcebooking_ProcessSession"></a> bookableresourcebooking_ProcessSession

**Added by**: Scheduling Solution

See bookableresourcebooking Entity [bookableresourcebooking_ProcessSession](bookableresourcebooking.md#BKMK_bookableresourcebooking_ProcessSession) One-To-Many relationship.

### <a name="BKMK_bookableresourcebookingheader_ProcessSession"></a> bookableresourcebookingheader_ProcessSession

**Added by**: Scheduling Solution

See bookableresourcebookingheader Entity [bookableresourcebookingheader_ProcessSession](bookableresourcebookingheader.md#BKMK_bookableresourcebookingheader_ProcessSession) One-To-Many relationship.

### <a name="BKMK_bookableresourcecategory_ProcessSession"></a> bookableresourcecategory_ProcessSession

**Added by**: Scheduling Solution

See bookableresourcecategory Entity [bookableresourcecategory_ProcessSession](bookableresourcecategory.md#BKMK_bookableresourcecategory_ProcessSession) One-To-Many relationship.

### <a name="BKMK_bookableresourcecategoryassn_ProcessSession"></a> bookableresourcecategoryassn_ProcessSession

**Added by**: Scheduling Solution

See bookableresourcecategoryassn Entity [bookableresourcecategoryassn_ProcessSession](bookableresourcecategoryassn.md#BKMK_bookableresourcecategoryassn_ProcessSession) One-To-Many relationship.

### <a name="BKMK_bookableresourcecharacteristic_ProcessSession"></a> bookableresourcecharacteristic_ProcessSession

**Added by**: Scheduling Solution

See bookableresourcecharacteristic Entity [bookableresourcecharacteristic_ProcessSession](bookableresourcecharacteristic.md#BKMK_bookableresourcecharacteristic_ProcessSession) One-To-Many relationship.

### <a name="BKMK_bookableresourcegroup_ProcessSession"></a> bookableresourcegroup_ProcessSession

**Added by**: Scheduling Solution

See bookableresourcegroup Entity [bookableresourcegroup_ProcessSession](bookableresourcegroup.md#BKMK_bookableresourcegroup_ProcessSession) One-To-Many relationship.

### <a name="BKMK_bookingstatus_ProcessSession"></a> bookingstatus_ProcessSession

**Added by**: Scheduling Solution

See bookingstatus Entity [bookingstatus_ProcessSession](bookingstatus.md#BKMK_bookingstatus_ProcessSession) One-To-Many relationship.

### <a name="BKMK_characteristic_ProcessSession"></a> characteristic_ProcessSession

**Added by**: Scheduling Solution

See characteristic Entity [characteristic_ProcessSession](characteristic.md#BKMK_characteristic_ProcessSession) One-To-Many relationship.

### <a name="BKMK_ratingmodel_ProcessSession"></a> ratingmodel_ProcessSession

**Added by**: Scheduling Solution

See ratingmodel Entity [ratingmodel_ProcessSession](ratingmodel.md#BKMK_ratingmodel_ProcessSession) One-To-Many relationship.

### <a name="BKMK_ratingvalue_ProcessSession"></a> ratingvalue_ProcessSession

**Added by**: Scheduling Solution

See ratingvalue Entity [ratingvalue_ProcessSession](ratingvalue.md#BKMK_ratingvalue_ProcessSession) One-To-Many relationship.

### <a name="BKMK_Campaign_ProcessSessions"></a> Campaign_ProcessSessions

**Added by**: Marketing Solution

See campaign Entity [Campaign_ProcessSessions](campaign.md#BKMK_Campaign_ProcessSessions) One-To-Many relationship.

### <a name="BKMK_CampaignActivity_ProcessSessions"></a> CampaignActivity_ProcessSessions

**Added by**: Marketing Solution

See campaignactivity Entity [CampaignActivity_ProcessSessions](campaignactivity.md#BKMK_CampaignActivity_ProcessSessions) One-To-Many relationship.

### <a name="BKMK_CampaignResponse_ProcessSessions"></a> CampaignResponse_ProcessSessions

**Added by**: Marketing Solution

See campaignresponse Entity [CampaignResponse_ProcessSessions](campaignresponse.md#BKMK_CampaignResponse_ProcessSessions) One-To-Many relationship.

### <a name="BKMK_List_ProcessSessions"></a> List_ProcessSessions

**Added by**: Marketing Solution

See list Entity [List_ProcessSessions](list.md#BKMK_List_ProcessSessions) One-To-Many relationship.

### <a name="BKMK_msdyn_databaseversion_ProcessSession"></a> msdyn_databaseversion_ProcessSession

**Added by**: Solution Upgrade Infrastructure Solution

See msdyn_databaseversion Entity [msdyn_databaseversion_ProcessSession](msdyn_databaseversion.md#BKMK_msdyn_databaseversion_ProcessSession) One-To-Many relationship.

### <a name="BKMK_msdyn_upgraderun_ProcessSession"></a> msdyn_upgraderun_ProcessSession

**Added by**: Solution Upgrade Infrastructure Solution

See msdyn_upgraderun Entity [msdyn_upgraderun_ProcessSession](msdyn_upgraderun.md#BKMK_msdyn_upgraderun_ProcessSession) One-To-Many relationship.

### <a name="BKMK_msdyn_upgradestep_ProcessSession"></a> msdyn_upgradestep_ProcessSession

**Added by**: Solution Upgrade Infrastructure Solution

See msdyn_upgradestep Entity [msdyn_upgradestep_ProcessSession](msdyn_upgradestep.md#BKMK_msdyn_upgradestep_ProcessSession) One-To-Many relationship.

### <a name="BKMK_msdyn_upgradeversion_ProcessSession"></a> msdyn_upgradeversion_ProcessSession

**Added by**: Solution Upgrade Infrastructure Solution

See msdyn_upgradeversion Entity [msdyn_upgradeversion_ProcessSession](msdyn_upgradeversion.md#BKMK_msdyn_upgradeversion_ProcessSession) One-To-Many relationship.

### <a name="BKMK_ConstraintBasedGroup_ProcessSessions"></a> ConstraintBasedGroup_ProcessSessions

**Added by**: Service Solution

See constraintbasedgroup Entity [ConstraintBasedGroup_ProcessSessions](constraintbasedgroup.md#BKMK_ConstraintBasedGroup_ProcessSessions) One-To-Many relationship.

### <a name="BKMK_Contract_ProcessSessions"></a> Contract_ProcessSessions

**Added by**: Service Solution

See contract Entity [Contract_ProcessSessions](contract.md#BKMK_Contract_ProcessSessions) One-To-Many relationship.

### <a name="BKMK_ContractDetail_ProcessSessions"></a> ContractDetail_ProcessSessions

**Added by**: Service Solution

See contractdetail Entity [ContractDetail_ProcessSessions](contractdetail.md#BKMK_ContractDetail_ProcessSessions) One-To-Many relationship.

### <a name="BKMK_ContractTemplate_ProcessSessions"></a> ContractTemplate_ProcessSessions

**Added by**: Service Solution

See contracttemplate Entity [ContractTemplate_ProcessSessions](contracttemplate.md#BKMK_ContractTemplate_ProcessSessions) One-To-Many relationship.

### <a name="BKMK_entitlement_ProcessSession"></a> entitlement_ProcessSession

**Added by**: Service Solution

See entitlement Entity [entitlement_ProcessSession](entitlement.md#BKMK_entitlement_ProcessSession) One-To-Many relationship.

### <a name="BKMK_entitlementtemplate_ProcessSession"></a> entitlementtemplate_ProcessSession

**Added by**: Service Solution

See entitlementtemplate Entity [entitlementtemplate_ProcessSession](entitlementtemplate.md#BKMK_entitlementtemplate_ProcessSession) One-To-Many relationship.

### <a name="BKMK_Equipment_ProcessSessions"></a> Equipment_ProcessSessions

**Added by**: Service Solution

See equipment Entity [Equipment_ProcessSessions](equipment.md#BKMK_Equipment_ProcessSessions) One-To-Many relationship.

### <a name="BKMK_Incident_ProcessSessions"></a> Incident_ProcessSessions

**Added by**: Service Solution

See incident Entity [Incident_ProcessSessions](incident.md#BKMK_Incident_ProcessSessions) One-To-Many relationship.

### <a name="BKMK_knowledgearticleincident_ProcessSession"></a> knowledgearticleincident_ProcessSession

**Added by**: Service Solution

See knowledgearticleincident Entity [knowledgearticleincident_ProcessSession](knowledgearticleincident.md#BKMK_knowledgearticleincident_ProcessSession) One-To-Many relationship.

### <a name="BKMK_phonetocaseprocess_ProcessSession"></a> phonetocaseprocess_ProcessSession

**Added by**: Service Solution

See phonetocaseprocess Entity [phonetocaseprocess_ProcessSession](phonetocaseprocess.md#BKMK_phonetocaseprocess_ProcessSession) One-To-Many relationship.

### <a name="BKMK_Service_ProcessSessions"></a> Service_ProcessSessions

**Added by**: Service Solution

See service Entity [Service_ProcessSessions](service.md#BKMK_Service_ProcessSessions) One-To-Many relationship.

### <a name="BKMK_ServiceAppointment_ProcessSessions"></a> ServiceAppointment_ProcessSessions

**Added by**: Service Solution

See serviceappointment Entity [ServiceAppointment_ProcessSessions](serviceappointment.md#BKMK_ServiceAppointment_ProcessSessions) One-To-Many relationship.

### <a name="BKMK_Site_ProcessSessions"></a> Site_ProcessSessions

**Added by**: Service Solution

See site Entity [Site_ProcessSessions](site.md#BKMK_Site_ProcessSessions) One-To-Many relationship.

### <a name="BKMK_entitlementchannel_ProcessSession"></a> entitlementchannel_ProcessSession

**Added by**: Service Solution

See entitlementchannel Entity [entitlementchannel_ProcessSession](entitlementchannel.md#BKMK_entitlementchannel_ProcessSession) One-To-Many relationship.

### <a name="BKMK_entitlemententityallocationtypemapping_ProcessSession"></a> entitlemententityallocationtypemapping_ProcessSession

**Added by**: Service Patch Solution

See entitlemententityallocationtypemapping Entity [entitlemententityallocationtypemapping_ProcessSession](entitlemententityallocationtypemapping.md#BKMK_entitlemententityallocationtypemapping_ProcessSession) One-To-Many relationship.

### <a name="BKMK_msdyn_callablecontext_ProcessSession"></a> msdyn_callablecontext_ProcessSession

**Added by**: Playbook Solution

See msdyn_callablecontext Entity [msdyn_callablecontext_ProcessSession](msdyn_callablecontext.md#BKMK_msdyn_callablecontext_ProcessSession) One-To-Many relationship.

### <a name="BKMK_msdyn_playbookactivity_ProcessSession"></a> msdyn_playbookactivity_ProcessSession

**Added by**: Playbook Solution

See msdyn_playbookactivity Entity [msdyn_playbookactivity_ProcessSession](msdyn_playbookactivity.md#BKMK_msdyn_playbookactivity_ProcessSession) One-To-Many relationship.

### <a name="BKMK_msdyn_playbookactivityattribute_ProcessSession"></a> msdyn_playbookactivityattribute_ProcessSession

**Added by**: Playbook Solution

See msdyn_playbookactivityattribute Entity [msdyn_playbookactivityattribute_ProcessSession](msdyn_playbookactivityattribute.md#BKMK_msdyn_playbookactivityattribute_ProcessSession) One-To-Many relationship.

### <a name="BKMK_msdyn_playbookcategory_ProcessSession"></a> msdyn_playbookcategory_ProcessSession

**Added by**: Playbook Solution

See msdyn_playbookcategory Entity [msdyn_playbookcategory_ProcessSession](msdyn_playbookcategory.md#BKMK_msdyn_playbookcategory_ProcessSession) One-To-Many relationship.

### <a name="BKMK_msdyn_playbookinstance_ProcessSession"></a> msdyn_playbookinstance_ProcessSession

**Added by**: Playbook Solution

See msdyn_playbookinstance Entity [msdyn_playbookinstance_ProcessSession](msdyn_playbookinstance.md#BKMK_msdyn_playbookinstance_ProcessSession) One-To-Many relationship.

### <a name="BKMK_msdyn_playbooktemplate_ProcessSession"></a> msdyn_playbooktemplate_ProcessSession

**Added by**: Playbook Solution

See msdyn_playbooktemplate Entity [msdyn_playbooktemplate_ProcessSession](msdyn_playbooktemplate.md#BKMK_msdyn_playbooktemplate_ProcessSession) One-To-Many relationship.

### <a name="BKMK_Discount_ProcessSessions"></a> Discount_ProcessSessions

**Added by**: Sales Solution

See discount Entity [Discount_ProcessSessions](discount.md#BKMK_Discount_ProcessSessions) One-To-Many relationship.

### <a name="BKMK_DiscountType_ProcessSessions"></a> DiscountType_ProcessSessions

**Added by**: Sales Solution

See discounttype Entity [DiscountType_ProcessSessions](discounttype.md#BKMK_DiscountType_ProcessSessions) One-To-Many relationship.

### <a name="BKMK_Invoice_ProcessSessions"></a> Invoice_ProcessSessions

**Added by**: Sales Solution

See invoice Entity [Invoice_ProcessSessions](invoice.md#BKMK_Invoice_ProcessSessions) One-To-Many relationship.

### <a name="BKMK_InvoiceDetail_ProcessSessions"></a> InvoiceDetail_ProcessSessions

**Added by**: Sales Solution

See invoicedetail Entity [InvoiceDetail_ProcessSessions](invoicedetail.md#BKMK_InvoiceDetail_ProcessSessions) One-To-Many relationship.

### <a name="BKMK_leadtoopportunitysalesprocess_ProcessSession"></a> leadtoopportunitysalesprocess_ProcessSession

**Added by**: Sales Solution

See leadtoopportunitysalesprocess Entity [leadtoopportunitysalesprocess_ProcessSession](leadtoopportunitysalesprocess.md#BKMK_leadtoopportunitysalesprocess_ProcessSession) One-To-Many relationship.

### <a name="BKMK_Opportunity_ProcessSessions"></a> Opportunity_ProcessSessions

**Added by**: Sales Solution

See opportunity Entity [Opportunity_ProcessSessions](opportunity.md#BKMK_Opportunity_ProcessSessions) One-To-Many relationship.

### <a name="BKMK_OpportunityProduct_ProcessSessions"></a> OpportunityProduct_ProcessSessions

**Added by**: Sales Solution

See opportunityproduct Entity [OpportunityProduct_ProcessSessions](opportunityproduct.md#BKMK_OpportunityProduct_ProcessSessions) One-To-Many relationship.

### <a name="BKMK_opportunitysalesprocess_ProcessSession"></a> opportunitysalesprocess_ProcessSession

**Added by**: Sales Solution

See opportunitysalesprocess Entity [opportunitysalesprocess_ProcessSession](opportunitysalesprocess.md#BKMK_opportunitysalesprocess_ProcessSession) One-To-Many relationship.

### <a name="BKMK_Quote_ProcessSessions"></a> Quote_ProcessSessions

**Added by**: Sales Solution

See quote Entity [Quote_ProcessSessions](quote.md#BKMK_Quote_ProcessSessions) One-To-Many relationship.

### <a name="BKMK_QuoteDetail_ProcessSessions"></a> QuoteDetail_ProcessSessions

**Added by**: Sales Solution

See quotedetail Entity [QuoteDetail_ProcessSessions](quotedetail.md#BKMK_QuoteDetail_ProcessSessions) One-To-Many relationship.

### <a name="BKMK_SalesLiterature_ProcessSessions"></a> SalesLiterature_ProcessSessions

**Added by**: Sales Solution

See salesliterature Entity [SalesLiterature_ProcessSessions](salesliterature.md#BKMK_SalesLiterature_ProcessSessions) One-To-Many relationship.

### <a name="BKMK_SalesLiteratureItem_ProcessSessions"></a> SalesLiteratureItem_ProcessSessions

**Added by**: Sales Solution

See salesliteratureitem Entity [SalesLiteratureItem_ProcessSessions](salesliteratureitem.md#BKMK_SalesLiteratureItem_ProcessSessions) One-To-Many relationship.

### <a name="BKMK_SalesOrder_ProcessSessions"></a> SalesOrder_ProcessSessions

**Added by**: Sales Solution

See salesorder Entity [SalesOrder_ProcessSessions](salesorder.md#BKMK_SalesOrder_ProcessSessions) One-To-Many relationship.

### <a name="BKMK_SalesOrderDetail_ProcessSessions"></a> SalesOrderDetail_ProcessSessions

**Added by**: Sales Solution

See salesorderdetail Entity [SalesOrderDetail_ProcessSessions](salesorderdetail.md#BKMK_SalesOrderDetail_ProcessSessions) One-To-Many relationship.

### <a name="BKMK_Competitor_ProcessSessions"></a> Competitor_ProcessSessions

**Added by**: Sales Solution

See competitor Entity [Competitor_ProcessSessions](competitor.md#BKMK_Competitor_ProcessSessions) One-To-Many relationship.

### <a name="BKMK_adminsettingsentity_ProcessSession"></a> adminsettingsentity_ProcessSession

**Added by**: Sales Patch Solution

See adminsettingsentity Entity [adminsettingsentity_ProcessSession](adminsettingsentity.md#BKMK_adminsettingsentity_ProcessSession) One-To-Many relationship.

### <a name="BKMK_msdyn_forecastdefinition_ProcessSession"></a> msdyn_forecastdefinition_ProcessSession

**Added by**: Forecasting Solution

See msdyn_forecastdefinition Entity [msdyn_forecastdefinition_ProcessSession](msdyn_forecastdefinition.md#BKMK_msdyn_forecastdefinition_ProcessSession) One-To-Many relationship.

### <a name="BKMK_msdyn_forecastinstance_ProcessSession"></a> msdyn_forecastinstance_ProcessSession

**Added by**: Forecasting Solution

See msdyn_forecastinstance Entity [msdyn_forecastinstance_ProcessSession](msdyn_forecastinstance.md#BKMK_msdyn_forecastinstance_ProcessSession) One-To-Many relationship.

### <a name="BKMK_msdyn_forecastrecurrence_ProcessSession"></a> msdyn_forecastrecurrence_ProcessSession

**Added by**: Forecasting Solution

See msdyn_forecastrecurrence Entity [msdyn_forecastrecurrence_ProcessSession](msdyn_forecastrecurrence.md#BKMK_msdyn_forecastrecurrence_ProcessSession) One-To-Many relationship.

### <a name="BKMK_msdyn_relationshipinsightsunifiedconfig_ProcessSession"></a> msdyn_relationshipinsightsunifiedconfig_ProcessSession

**Added by**: SI Common Solution

See msdyn_relationshipinsightsunifiedconfig Entity [msdyn_relationshipinsightsunifiedconfig_ProcessSession](msdyn_relationshipinsightsunifiedconfig.md#BKMK_msdyn_relationshipinsightsunifiedconfig_ProcessSession) One-To-Many relationship.

### <a name="BKMK_msdyn_siconfig_ProcessSession"></a> msdyn_siconfig_ProcessSession

**Added by**: SI Common Solution

See msdyn_siconfig Entity [msdyn_siconfig_ProcessSession](msdyn_siconfig.md#BKMK_msdyn_siconfig_ProcessSession) One-To-Many relationship.

### <a name="BKMK_msdyn_untrackedappointment_ProcessSession"></a> msdyn_untrackedappointment_ProcessSession

**Added by**: AutoDataCapture Solution

See msdyn_untrackedappointment Entity [msdyn_untrackedappointment_ProcessSession](msdyn_untrackedappointment.md#BKMK_msdyn_untrackedappointment_ProcessSession) One-To-Many relationship.

### <a name="BKMK_msdyn_notesanalysisconfig_ProcessSession"></a> msdyn_notesanalysisconfig_ProcessSession

**Added by**: Notesanalysis Solution

See msdyn_notesanalysisconfig Entity [msdyn_notesanalysisconfig_ProcessSession](msdyn_notesanalysisconfig.md#BKMK_msdyn_notesanalysisconfig_ProcessSession) One-To-Many relationship.

### <a name="BKMK_msdyn_icebreakersconfig_ProcessSession"></a> msdyn_icebreakersconfig_ProcessSession

**Added by**: Talking points Solution

See msdyn_icebreakersconfig Entity [msdyn_icebreakersconfig_ProcessSession](msdyn_icebreakersconfig.md#BKMK_msdyn_icebreakersconfig_ProcessSession) One-To-Many relationship.

### <a name="BKMK_msdyn_postalbum_ProcessSession"></a> msdyn_postalbum_ProcessSession

**Added by**: Activity Feeds Solution

See msdyn_postalbum Entity [msdyn_postalbum_ProcessSession](msdyn_postalbum.md#BKMK_msdyn_postalbum_ProcessSession) One-To-Many relationship.

### <a name="BKMK_msdyn_postconfig_ProcessSession"></a> msdyn_postconfig_ProcessSession

**Added by**: Activity Feeds Solution

See msdyn_postconfig Entity [msdyn_postconfig_ProcessSession](msdyn_postconfig.md#BKMK_msdyn_postconfig_ProcessSession) One-To-Many relationship.

### <a name="BKMK_msdyn_postruleconfig_ProcessSession"></a> msdyn_postruleconfig_ProcessSession

**Added by**: Activity Feeds Solution

See msdyn_postruleconfig Entity [msdyn_postruleconfig_ProcessSession](msdyn_postruleconfig.md#BKMK_msdyn_postruleconfig_ProcessSession) One-To-Many relationship.

### <a name="BKMK_msdyn_wallsavedquery_ProcessSession"></a> msdyn_wallsavedquery_ProcessSession

**Added by**: Activity Feeds Solution

See msdyn_wallsavedquery Entity [msdyn_wallsavedquery_ProcessSession](msdyn_wallsavedquery.md#BKMK_msdyn_wallsavedquery_ProcessSession) One-To-Many relationship.

### <a name="BKMK_msdyn_wallsavedqueryusersettings_ProcessSession"></a> msdyn_wallsavedqueryusersettings_ProcessSession

**Added by**: Activity Feeds Solution

See msdyn_wallsavedqueryusersettings Entity [msdyn_wallsavedqueryusersettings_ProcessSession](msdyn_wallsavedqueryusersettings.md#BKMK_msdyn_wallsavedqueryusersettings_ProcessSession) One-To-Many relationship.

### <a name="BKMK_msdyn_teamscollaboration_ProcessSession"></a> msdyn_teamscollaboration_ProcessSession

**Added by**: This solution contains Office Productivity implementation Solution

See msdyn_teamscollaboration Entity [msdyn_teamscollaboration_ProcessSession](msdyn_teamscollaboration.md#BKMK_msdyn_teamscollaboration_ProcessSession) One-To-Many relationship.

### <a name="BKMK_msdyn_actual_ProcessSession"></a> msdyn_actual_ProcessSession

**Added by**: Universal Resource Scheduling Solution

See msdyn_actual Entity [msdyn_actual_ProcessSession](msdyn_actual.md#BKMK_msdyn_actual_ProcessSession) One-To-Many relationship.

### <a name="BKMK_msdyn_bookableresourceassociation_ProcessSession"></a> msdyn_bookableresourceassociation_ProcessSession

**Added by**: Universal Resource Scheduling Solution

See msdyn_bookableresourceassociation Entity [msdyn_bookableresourceassociation_ProcessSession](msdyn_bookableresourceassociation.md#BKMK_msdyn_bookableresourceassociation_ProcessSession) One-To-Many relationship.

### <a name="BKMK_msdyn_bookingalert_ProcessSession"></a> msdyn_bookingalert_ProcessSession

**Added by**: Active Solution Solution

See msdyn_bookingalert Entity [msdyn_bookingalert_ProcessSession](msdyn_bookingalert.md#BKMK_msdyn_bookingalert_ProcessSession) One-To-Many relationship.

### <a name="BKMK_msdyn_bookingalertstatus_ProcessSession"></a> msdyn_bookingalertstatus_ProcessSession

**Added by**: Universal Resource Scheduling Solution

See msdyn_bookingalertstatus Entity [msdyn_bookingalertstatus_ProcessSession](msdyn_bookingalertstatus.md#BKMK_msdyn_bookingalertstatus_ProcessSession) One-To-Many relationship.

### <a name="BKMK_msdyn_bookingchange_ProcessSession"></a> msdyn_bookingchange_ProcessSession

**Added by**: Universal Resource Scheduling Solution

See msdyn_bookingchange Entity [msdyn_bookingchange_ProcessSession](msdyn_bookingchange.md#BKMK_msdyn_bookingchange_ProcessSession) One-To-Many relationship.

### <a name="BKMK_msdyn_bookingrule_ProcessSession"></a> msdyn_bookingrule_ProcessSession

**Added by**: Universal Resource Scheduling Solution

See msdyn_bookingrule Entity [msdyn_bookingrule_ProcessSession](msdyn_bookingrule.md#BKMK_msdyn_bookingrule_ProcessSession) One-To-Many relationship.

### <a name="BKMK_msdyn_bookingsetupmetadata_ProcessSession"></a> msdyn_bookingsetupmetadata_ProcessSession

**Added by**: Universal Resource Scheduling Solution

See msdyn_bookingsetupmetadata Entity [msdyn_bookingsetupmetadata_ProcessSession](msdyn_bookingsetupmetadata.md#BKMK_msdyn_bookingsetupmetadata_ProcessSession) One-To-Many relationship.

### <a name="BKMK_msdyn_businessclosure_ProcessSession"></a> msdyn_businessclosure_ProcessSession

**Added by**: Universal Resource Scheduling Solution

See msdyn_businessclosure Entity [msdyn_businessclosure_ProcessSession](msdyn_businessclosure.md#BKMK_msdyn_businessclosure_ProcessSession) One-To-Many relationship.

### <a name="BKMK_msdyn_clientextension_ProcessSession"></a> msdyn_clientextension_ProcessSession

**Added by**: Universal Resource Scheduling Solution

See msdyn_clientextension Entity [msdyn_clientextension_ProcessSession](msdyn_clientextension.md#BKMK_msdyn_clientextension_ProcessSession) One-To-Many relationship.

### <a name="BKMK_msdyn_configuration_ProcessSession"></a> msdyn_configuration_ProcessSession

**Added by**: Universal Resource Scheduling Solution

See msdyn_configuration Entity [msdyn_configuration_ProcessSession](msdyn_configuration.md#BKMK_msdyn_configuration_ProcessSession) One-To-Many relationship.

### <a name="BKMK_msdyn_organizationalunit_ProcessSession"></a> msdyn_organizationalunit_ProcessSession

**Added by**: Universal Resource Scheduling Solution

See msdyn_organizationalunit Entity [msdyn_organizationalunit_ProcessSession](msdyn_organizationalunit.md#BKMK_msdyn_organizationalunit_ProcessSession) One-To-Many relationship.

### <a name="BKMK_msdyn_priority_ProcessSession"></a> msdyn_priority_ProcessSession

**Added by**: Universal Resource Scheduling Solution

See msdyn_priority Entity [msdyn_priority_ProcessSession](msdyn_priority.md#BKMK_msdyn_priority_ProcessSession) One-To-Many relationship.

### <a name="BKMK_msdyn_requirementcharacteristic_ProcessSession"></a> msdyn_requirementcharacteristic_ProcessSession

**Added by**: Universal Resource Scheduling Solution

See msdyn_requirementcharacteristic Entity [msdyn_requirementcharacteristic_ProcessSession](msdyn_requirementcharacteristic.md#BKMK_msdyn_requirementcharacteristic_ProcessSession) One-To-Many relationship.

### <a name="BKMK_msdyn_requirementgroup_ProcessSession"></a> msdyn_requirementgroup_ProcessSession

**Added by**: Universal Resource Scheduling Solution

See msdyn_requirementgroup Entity [msdyn_requirementgroup_ProcessSession](msdyn_requirementgroup.md#BKMK_msdyn_requirementgroup_ProcessSession) One-To-Many relationship.

### <a name="BKMK_msdyn_requirementorganizationunit_ProcessSession"></a> msdyn_requirementorganizationunit_ProcessSession

**Added by**: Universal Resource Scheduling Solution

See msdyn_requirementorganizationunit Entity [msdyn_requirementorganizationunit_ProcessSession](msdyn_requirementorganizationunit.md#BKMK_msdyn_requirementorganizationunit_ProcessSession) One-To-Many relationship.

### <a name="BKMK_msdyn_requirementrelationship_ProcessSession"></a> msdyn_requirementrelationship_ProcessSession

**Added by**: Universal Resource Scheduling Solution

See msdyn_requirementrelationship Entity [msdyn_requirementrelationship_ProcessSession](msdyn_requirementrelationship.md#BKMK_msdyn_requirementrelationship_ProcessSession) One-To-Many relationship.

### <a name="BKMK_msdyn_requirementresourcecategory_ProcessSession"></a> msdyn_requirementresourcecategory_ProcessSession

**Added by**: Universal Resource Scheduling Solution

See msdyn_requirementresourcecategory Entity [msdyn_requirementresourcecategory_ProcessSession](msdyn_requirementresourcecategory.md#BKMK_msdyn_requirementresourcecategory_ProcessSession) One-To-Many relationship.

### <a name="BKMK_msdyn_requirementresourcepreference_ProcessSession"></a> msdyn_requirementresourcepreference_ProcessSession

**Added by**: Universal Resource Scheduling Solution

See msdyn_requirementresourcepreference Entity [msdyn_requirementresourcepreference_ProcessSession](msdyn_requirementresourcepreference.md#BKMK_msdyn_requirementresourcepreference_ProcessSession) One-To-Many relationship.

### <a name="BKMK_msdyn_requirementstatus_ProcessSession"></a> msdyn_requirementstatus_ProcessSession

**Added by**: Universal Resource Scheduling Solution

See msdyn_requirementstatus Entity [msdyn_requirementstatus_ProcessSession](msdyn_requirementstatus.md#BKMK_msdyn_requirementstatus_ProcessSession) One-To-Many relationship.

### <a name="BKMK_msdyn_resourcerequirement_ProcessSession"></a> msdyn_resourcerequirement_ProcessSession

**Added by**: Universal Resource Scheduling Solution

See msdyn_resourcerequirement Entity [msdyn_resourcerequirement_ProcessSession](msdyn_resourcerequirement.md#BKMK_msdyn_resourcerequirement_ProcessSession) One-To-Many relationship.

### <a name="BKMK_msdyn_resourcerequirementdetail_ProcessSession"></a> msdyn_resourcerequirementdetail_ProcessSession

**Added by**: Universal Resource Scheduling Solution

See msdyn_resourcerequirementdetail Entity [msdyn_resourcerequirementdetail_ProcessSession](msdyn_resourcerequirementdetail.md#BKMK_msdyn_resourcerequirementdetail_ProcessSession) One-To-Many relationship.

### <a name="BKMK_msdyn_resourceterritory_ProcessSession"></a> msdyn_resourceterritory_ProcessSession

**Added by**: Universal Resource Scheduling Solution

See msdyn_resourceterritory Entity [msdyn_resourceterritory_ProcessSession](msdyn_resourceterritory.md#BKMK_msdyn_resourceterritory_ProcessSession) One-To-Many relationship.

### <a name="BKMK_msdyn_scheduleboardsetting_ProcessSession"></a> msdyn_scheduleboardsetting_ProcessSession

**Added by**: Universal Resource Scheduling Solution

See msdyn_scheduleboardsetting Entity [msdyn_scheduleboardsetting_ProcessSession](msdyn_scheduleboardsetting.md#BKMK_msdyn_scheduleboardsetting_ProcessSession) One-To-Many relationship.

### <a name="BKMK_msdyn_schedulingparameter_ProcessSession"></a> msdyn_schedulingparameter_ProcessSession

**Added by**: Universal Resource Scheduling Solution

See msdyn_schedulingparameter Entity [msdyn_schedulingparameter_ProcessSession](msdyn_schedulingparameter.md#BKMK_msdyn_schedulingparameter_ProcessSession) One-To-Many relationship.

### <a name="BKMK_msdyn_systemuserschedulersetting_ProcessSession"></a> msdyn_systemuserschedulersetting_ProcessSession

**Added by**: Universal Resource Scheduling Solution

See msdyn_systemuserschedulersetting Entity [msdyn_systemuserschedulersetting_ProcessSession](msdyn_systemuserschedulersetting.md#BKMK_msdyn_systemuserschedulersetting_ProcessSession) One-To-Many relationship.

### <a name="BKMK_msdyn_timegroup_ProcessSession"></a> msdyn_timegroup_ProcessSession

**Added by**: Universal Resource Scheduling Solution

See msdyn_timegroup Entity [msdyn_timegroup_ProcessSession](msdyn_timegroup.md#BKMK_msdyn_timegroup_ProcessSession) One-To-Many relationship.

### <a name="BKMK_msdyn_timegroupdetail_ProcessSession"></a> msdyn_timegroupdetail_ProcessSession

**Added by**: Universal Resource Scheduling Solution

See msdyn_timegroupdetail Entity [msdyn_timegroupdetail_ProcessSession](msdyn_timegroupdetail.md#BKMK_msdyn_timegroupdetail_ProcessSession) One-To-Many relationship.

### <a name="BKMK_msdyn_transactionorigin_ProcessSession"></a> msdyn_transactionorigin_ProcessSession

**Added by**: Universal Resource Scheduling Solution

See msdyn_transactionorigin Entity [msdyn_transactionorigin_ProcessSession](msdyn_transactionorigin.md#BKMK_msdyn_transactionorigin_ProcessSession) One-To-Many relationship.

### <a name="BKMK_msdyn_workhourtemplate_ProcessSession"></a> msdyn_workhourtemplate_ProcessSession

**Added by**: Universal Resource Scheduling Solution

See msdyn_workhourtemplate Entity [msdyn_workhourtemplate_ProcessSession](msdyn_workhourtemplate.md#BKMK_msdyn_workhourtemplate_ProcessSession) One-To-Many relationship.

### <a name="BKMK_msdyn_accountpricelist_ProcessSession"></a> msdyn_accountpricelist_ProcessSession

**Added by**: Project Service Automation Solution

See msdyn_accountpricelist Entity [msdyn_accountpricelist_ProcessSession](msdyn_accountpricelist.md#BKMK_msdyn_accountpricelist_ProcessSession) One-To-Many relationship.

### <a name="BKMK_msdyn_approval_ProcessSession"></a> msdyn_approval_ProcessSession

**Added by**: Active Solution Solution

See msdyn_approval Entity [msdyn_approval_ProcessSession](msdyn_approval.md#BKMK_msdyn_approval_ProcessSession) One-To-Many relationship.

### <a name="BKMK_msdyn_batchjob_ProcessSession"></a> msdyn_batchjob_ProcessSession

**Added by**: Project Service Automation Solution

See msdyn_batchjob Entity [msdyn_batchjob_ProcessSession](msdyn_batchjob.md#BKMK_msdyn_batchjob_ProcessSession) One-To-Many relationship.

### <a name="BKMK_msdyn_bpf_665e73aa18c247d886bfc50499c73b82_ProcessSession"></a> msdyn_bpf_665e73aa18c247d886bfc50499c73b82_ProcessSession

**Added by**: Project Service Automation Solution

See msdyn_bpf_665e73aa18c247d886bfc50499c73b82 Entity [msdyn_bpf_665e73aa18c247d886bfc50499c73b82_ProcessSession](msdyn_bpf_665e73aa18c247d886bfc50499c73b82.md#BKMK_msdyn_bpf_665e73aa18c247d886bfc50499c73b82_ProcessSession) One-To-Many relationship.

### <a name="BKMK_msdyn_bpf_d8f9dc7f099f44db9d641dd81fbd470d_ProcessSession"></a> msdyn_bpf_d8f9dc7f099f44db9d641dd81fbd470d_ProcessSession

**Added by**: Project Service Automation Solution

See msdyn_bpf_d8f9dc7f099f44db9d641dd81fbd470d Entity [msdyn_bpf_d8f9dc7f099f44db9d641dd81fbd470d_ProcessSession](msdyn_bpf_d8f9dc7f099f44db9d641dd81fbd470d.md#BKMK_msdyn_bpf_d8f9dc7f099f44db9d641dd81fbd470d_ProcessSession) One-To-Many relationship.

### <a name="BKMK_msdyn_characteristicreqforteammember_ProcessSession"></a> msdyn_characteristicreqforteammember_ProcessSession

**Added by**: Project Service Automation Solution

See msdyn_characteristicreqforteammember Entity [msdyn_characteristicreqforteammember_ProcessSession](msdyn_characteristicreqforteammember.md#BKMK_msdyn_characteristicreqforteammember_ProcessSession) One-To-Many relationship.

### <a name="BKMK_msdyn_contactpricelist_ProcessSession"></a> msdyn_contactpricelist_ProcessSession

**Added by**: Project Service Automation Solution

See msdyn_contactpricelist Entity [msdyn_contactpricelist_ProcessSession](msdyn_contactpricelist.md#BKMK_msdyn_contactpricelist_ProcessSession) One-To-Many relationship.

### <a name="BKMK_msdyn_contractlineinvoiceschedule_ProcessSession"></a> msdyn_contractlineinvoiceschedule_ProcessSession

**Added by**: Project Service Automation Solution

See msdyn_contractlineinvoiceschedule Entity [msdyn_contractlineinvoiceschedule_ProcessSession](msdyn_contractlineinvoiceschedule.md#BKMK_msdyn_contractlineinvoiceschedule_ProcessSession) One-To-Many relationship.

### <a name="BKMK_msdyn_contractlinescheduleofvalue_ProcessSession"></a> msdyn_contractlinescheduleofvalue_ProcessSession

**Added by**: Project Service Automation Solution

See msdyn_contractlinescheduleofvalue Entity [msdyn_contractlinescheduleofvalue_ProcessSession](msdyn_contractlinescheduleofvalue.md#BKMK_msdyn_contractlinescheduleofvalue_ProcessSession) One-To-Many relationship.

### <a name="BKMK_msdyn_dataexport_ProcessSession"></a> msdyn_dataexport_ProcessSession

**Added by**: Project Service Automation Solution

See msdyn_dataexport Entity [msdyn_dataexport_ProcessSession](msdyn_dataexport.md#BKMK_msdyn_dataexport_ProcessSession) One-To-Many relationship.

### <a name="BKMK_msdyn_delegation_ProcessSession"></a> msdyn_delegation_ProcessSession

**Added by**: Project Service Automation Solution

See msdyn_delegation Entity [msdyn_delegation_ProcessSession](msdyn_delegation.md#BKMK_msdyn_delegation_ProcessSession) One-To-Many relationship.

### <a name="BKMK_msdyn_dimension_ProcessSession"></a> msdyn_dimension_ProcessSession

**Added by**: Project Service Automation Solution

See msdyn_dimension Entity [msdyn_dimension_ProcessSession](msdyn_dimension.md#BKMK_msdyn_dimension_ProcessSession) One-To-Many relationship.

### <a name="BKMK_msdyn_dimensionfieldname_ProcessSession"></a> msdyn_dimensionfieldname_ProcessSession

**Added by**: Project Service Automation Solution

See msdyn_dimensionfieldname Entity [msdyn_dimensionfieldname_ProcessSession](msdyn_dimensionfieldname.md#BKMK_msdyn_dimensionfieldname_ProcessSession) One-To-Many relationship.

### <a name="BKMK_msdyn_estimate_ProcessSession"></a> msdyn_estimate_ProcessSession

**Added by**: Project Service Automation Solution

See msdyn_estimate Entity [msdyn_estimate_ProcessSession](msdyn_estimate.md#BKMK_msdyn_estimate_ProcessSession) One-To-Many relationship.

### <a name="BKMK_msdyn_estimateline_ProcessSession"></a> msdyn_estimateline_ProcessSession

**Added by**: Project Service Automation Solution

See msdyn_estimateline Entity [msdyn_estimateline_ProcessSession](msdyn_estimateline.md#BKMK_msdyn_estimateline_ProcessSession) One-To-Many relationship.

### <a name="BKMK_msdyn_expense_ProcessSession"></a> msdyn_expense_ProcessSession

**Added by**: Project Service Automation Solution

See msdyn_expense Entity [msdyn_expense_ProcessSession](msdyn_expense.md#BKMK_msdyn_expense_ProcessSession) One-To-Many relationship.

### <a name="BKMK_msdyn_expensecategory_ProcessSession"></a> msdyn_expensecategory_ProcessSession

**Added by**: Project Service Automation Solution

See msdyn_expensecategory Entity [msdyn_expensecategory_ProcessSession](msdyn_expensecategory.md#BKMK_msdyn_expensecategory_ProcessSession) One-To-Many relationship.

### <a name="BKMK_msdyn_expensereceipt_ProcessSession"></a> msdyn_expensereceipt_ProcessSession

**Added by**: Project Service Automation Solution

See msdyn_expensereceipt Entity [msdyn_expensereceipt_ProcessSession](msdyn_expensereceipt.md#BKMK_msdyn_expensereceipt_ProcessSession) One-To-Many relationship.

### <a name="BKMK_msdyn_fact_ProcessSession"></a> msdyn_fact_ProcessSession

**Added by**: Project Service Automation Solution

See msdyn_fact Entity [msdyn_fact_ProcessSession](msdyn_fact.md#BKMK_msdyn_fact_ProcessSession) One-To-Many relationship.

### <a name="BKMK_msdyn_fieldcomputation_ProcessSession"></a> msdyn_fieldcomputation_ProcessSession

**Added by**: Project Service Automation Solution

See msdyn_fieldcomputation Entity [msdyn_fieldcomputation_ProcessSession](msdyn_fieldcomputation.md#BKMK_msdyn_fieldcomputation_ProcessSession) One-To-Many relationship.

### <a name="BKMK_msdyn_findworkevent_ProcessSession"></a> msdyn_findworkevent_ProcessSession

**Added by**: Project Service Automation Solution

See msdyn_findworkevent Entity [msdyn_findworkevent_ProcessSession](msdyn_findworkevent.md#BKMK_msdyn_findworkevent_ProcessSession) One-To-Many relationship.

### <a name="BKMK_msdyn_integrationjob_ProcessSession"></a> msdyn_integrationjob_ProcessSession

**Added by**: Project Service Automation Solution

See msdyn_integrationjob Entity [msdyn_integrationjob_ProcessSession](msdyn_integrationjob.md#BKMK_msdyn_integrationjob_ProcessSession) One-To-Many relationship.

### <a name="BKMK_msdyn_integrationjobdetail_ProcessSession"></a> msdyn_integrationjobdetail_ProcessSession

**Added by**: Project Service Automation Solution

See msdyn_integrationjobdetail Entity [msdyn_integrationjobdetail_ProcessSession](msdyn_integrationjobdetail.md#BKMK_msdyn_integrationjobdetail_ProcessSession) One-To-Many relationship.

### <a name="BKMK_msdyn_invoicefrequency_ProcessSession"></a> msdyn_invoicefrequency_ProcessSession

**Added by**: Project Service Automation Solution

See msdyn_invoicefrequency Entity [msdyn_invoicefrequency_ProcessSession](msdyn_invoicefrequency.md#BKMK_msdyn_invoicefrequency_ProcessSession) One-To-Many relationship.

### <a name="BKMK_msdyn_invoicefrequencydetail_ProcessSession"></a> msdyn_invoicefrequencydetail_ProcessSession

**Added by**: Project Service Automation Solution

See msdyn_invoicefrequencydetail Entity [msdyn_invoicefrequencydetail_ProcessSession](msdyn_invoicefrequencydetail.md#BKMK_msdyn_invoicefrequencydetail_ProcessSession) One-To-Many relationship.

### <a name="BKMK_msdyn_invoicelinetransaction_ProcessSession"></a> msdyn_invoicelinetransaction_ProcessSession

**Added by**: Project Service Automation Solution

See msdyn_invoicelinetransaction Entity [msdyn_invoicelinetransaction_ProcessSession](msdyn_invoicelinetransaction.md#BKMK_msdyn_invoicelinetransaction_ProcessSession) One-To-Many relationship.

### <a name="BKMK_msdyn_journal_ProcessSession"></a> msdyn_journal_ProcessSession

**Added by**: Project Service Automation Solution

See msdyn_journal Entity [msdyn_journal_ProcessSession](msdyn_journal.md#BKMK_msdyn_journal_ProcessSession) One-To-Many relationship.

### <a name="BKMK_msdyn_journalline_ProcessSession"></a> msdyn_journalline_ProcessSession

**Added by**: Project Service Automation Solution

See msdyn_journalline Entity [msdyn_journalline_ProcessSession](msdyn_journalline.md#BKMK_msdyn_journalline_ProcessSession) One-To-Many relationship.

### <a name="BKMK_msdyn_mlresultcache_ProcessSession"></a> msdyn_mlresultcache_ProcessSession

**Added by**: Project Service Automation Solution

See msdyn_mlresultcache Entity [msdyn_mlresultcache_ProcessSession](msdyn_mlresultcache.md#BKMK_msdyn_mlresultcache_ProcessSession) One-To-Many relationship.

### <a name="BKMK_msdyn_opportunitylineresourcecategory_ProcessSession"></a> msdyn_opportunitylineresourcecategory_ProcessSession

**Added by**: Project Service Automation Solution

See msdyn_opportunitylineresourcecategory Entity [msdyn_opportunitylineresourcecategory_ProcessSession](msdyn_opportunitylineresourcecategory.md#BKMK_msdyn_opportunitylineresourcecategory_ProcessSession) One-To-Many relationship.

### <a name="BKMK_msdyn_opportunitylinetransaction_ProcessSession"></a> msdyn_opportunitylinetransaction_ProcessSession

**Added by**: Project Service Automation Solution

See msdyn_opportunitylinetransaction Entity [msdyn_opportunitylinetransaction_ProcessSession](msdyn_opportunitylinetransaction.md#BKMK_msdyn_opportunitylinetransaction_ProcessSession) One-To-Many relationship.

### <a name="BKMK_msdyn_opportunitylinetransactioncategory_ProcessSession"></a> msdyn_opportunitylinetransactioncategory_ProcessSession

**Added by**: Project Service Automation Solution

See msdyn_opportunitylinetransactioncategory Entity [msdyn_opportunitylinetransactioncategory_ProcessSession](msdyn_opportunitylinetransactioncategory.md#BKMK_msdyn_opportunitylinetransactioncategory_ProcessSession) One-To-Many relationship.

### <a name="BKMK_msdyn_opportunitylinetransactionclassificatio_ProcessSession"></a> msdyn_opportunitylinetransactionclassificatio_ProcessSession

**Added by**: Project Service Automation Solution

See msdyn_opportunitylinetransactionclassificatio Entity [msdyn_opportunitylinetransactionclassificatio_ProcessSession](msdyn_opportunitylinetransactionclassificatio.md#BKMK_msdyn_opportunitylinetransactionclassificatio_ProcessSession) One-To-Many relationship.

### <a name="BKMK_msdyn_opportunitypricelist_ProcessSession"></a> msdyn_opportunitypricelist_ProcessSession

**Added by**: Project Service Automation Solution

See msdyn_opportunitypricelist Entity [msdyn_opportunitypricelist_ProcessSession](msdyn_opportunitypricelist.md#BKMK_msdyn_opportunitypricelist_ProcessSession) One-To-Many relationship.

### <a name="BKMK_msdyn_orderlineresourcecategory_ProcessSession"></a> msdyn_orderlineresourcecategory_ProcessSession

**Added by**: Project Service Automation Solution

See msdyn_orderlineresourcecategory Entity [msdyn_orderlineresourcecategory_ProcessSession](msdyn_orderlineresourcecategory.md#BKMK_msdyn_orderlineresourcecategory_ProcessSession) One-To-Many relationship.

### <a name="BKMK_msdyn_orderlinetransaction_ProcessSession"></a> msdyn_orderlinetransaction_ProcessSession

**Added by**: Project Service Automation Solution

See msdyn_orderlinetransaction Entity [msdyn_orderlinetransaction_ProcessSession](msdyn_orderlinetransaction.md#BKMK_msdyn_orderlinetransaction_ProcessSession) One-To-Many relationship.

### <a name="BKMK_msdyn_orderlinetransactioncategory_ProcessSession"></a> msdyn_orderlinetransactioncategory_ProcessSession

**Added by**: Project Service Automation Solution

See msdyn_orderlinetransactioncategory Entity [msdyn_orderlinetransactioncategory_ProcessSession](msdyn_orderlinetransactioncategory.md#BKMK_msdyn_orderlinetransactioncategory_ProcessSession) One-To-Many relationship.

### <a name="BKMK_msdyn_orderlinetransactionclassification_ProcessSession"></a> msdyn_orderlinetransactionclassification_ProcessSession

**Added by**: Project Service Automation Solution

See msdyn_orderlinetransactionclassification Entity [msdyn_orderlinetransactionclassification_ProcessSession](msdyn_orderlinetransactionclassification.md#BKMK_msdyn_orderlinetransactionclassification_ProcessSession) One-To-Many relationship.

### <a name="BKMK_msdyn_orderpricelist_ProcessSession"></a> msdyn_orderpricelist_ProcessSession

**Added by**: Project Service Automation Solution

See msdyn_orderpricelist Entity [msdyn_orderpricelist_ProcessSession](msdyn_orderpricelist.md#BKMK_msdyn_orderpricelist_ProcessSession) One-To-Many relationship.

### <a name="BKMK_msdyn_processnotes_ProcessSession"></a> msdyn_processnotes_ProcessSession

**Added by**: Project Service Automation Solution

See msdyn_processnotes Entity [msdyn_processnotes_ProcessSession](msdyn_processnotes.md#BKMK_msdyn_processnotes_ProcessSession) One-To-Many relationship.

### <a name="BKMK_msdyn_project_ProcessSession"></a> msdyn_project_ProcessSession

**Added by**: Project Service Automation Solution

See msdyn_project Entity [msdyn_project_ProcessSession](msdyn_project.md#BKMK_msdyn_project_ProcessSession) One-To-Many relationship.

### <a name="BKMK_msdyn_projectapproval_ProcessSession"></a> msdyn_projectapproval_ProcessSession

**Added by**: Project Service Automation Solution

See msdyn_projectapproval Entity [msdyn_projectapproval_ProcessSession](msdyn_projectapproval.md#BKMK_msdyn_projectapproval_ProcessSession) One-To-Many relationship.

### <a name="BKMK_msdyn_projectparameter_ProcessSession"></a> msdyn_projectparameter_ProcessSession

**Added by**: Project Service Automation Solution

See msdyn_projectparameter Entity [msdyn_projectparameter_ProcessSession](msdyn_projectparameter.md#BKMK_msdyn_projectparameter_ProcessSession) One-To-Many relationship.

### <a name="BKMK_msdyn_projectparameterpricelist_ProcessSession"></a> msdyn_projectparameterpricelist_ProcessSession

**Added by**: Project Service Automation Solution

See msdyn_projectparameterpricelist Entity [msdyn_projectparameterpricelist_ProcessSession](msdyn_projectparameterpricelist.md#BKMK_msdyn_projectparameterpricelist_ProcessSession) One-To-Many relationship.

### <a name="BKMK_msdyn_projectpricelist_ProcessSession"></a> msdyn_projectpricelist_ProcessSession

**Added by**: Project Service Automation Solution

See msdyn_projectpricelist Entity [msdyn_projectpricelist_ProcessSession](msdyn_projectpricelist.md#BKMK_msdyn_projectpricelist_ProcessSession) One-To-Many relationship.

### <a name="BKMK_msdyn_projecttask_ProcessSession"></a> msdyn_projecttask_ProcessSession

**Added by**: Project Service Automation Solution

See msdyn_projecttask Entity [msdyn_projecttask_ProcessSession](msdyn_projecttask.md#BKMK_msdyn_projecttask_ProcessSession) One-To-Many relationship.

### <a name="BKMK_msdyn_projecttaskdependency_ProcessSession"></a> msdyn_projecttaskdependency_ProcessSession

**Added by**: Project Service Automation Solution

See msdyn_projecttaskdependency Entity [msdyn_projecttaskdependency_ProcessSession](msdyn_projecttaskdependency.md#BKMK_msdyn_projecttaskdependency_ProcessSession) One-To-Many relationship.

### <a name="BKMK_msdyn_projecttaskstatususer_ProcessSession"></a> msdyn_projecttaskstatususer_ProcessSession

**Added by**: Project Service Automation Solution

See msdyn_projecttaskstatususer Entity [msdyn_projecttaskstatususer_ProcessSession](msdyn_projecttaskstatususer.md#BKMK_msdyn_projecttaskstatususer_ProcessSession) One-To-Many relationship.

### <a name="BKMK_msdyn_projectteam_ProcessSession"></a> msdyn_projectteam_ProcessSession

**Added by**: Project Service Automation Solution

See msdyn_projectteam Entity [msdyn_projectteam_ProcessSession](msdyn_projectteam.md#BKMK_msdyn_projectteam_ProcessSession) One-To-Many relationship.

### <a name="BKMK_msdyn_projectteammembersignup_ProcessSession"></a> msdyn_projectteammembersignup_ProcessSession

**Added by**: Project Service Automation Solution

See msdyn_projectteammembersignup Entity [msdyn_projectteammembersignup_ProcessSession](msdyn_projectteammembersignup.md#BKMK_msdyn_projectteammembersignup_ProcessSession) One-To-Many relationship.

### <a name="BKMK_msdyn_projecttransactioncategory_ProcessSession"></a> msdyn_projecttransactioncategory_ProcessSession

**Added by**: Project Service Automation Solution

See msdyn_projecttransactioncategory Entity [msdyn_projecttransactioncategory_ProcessSession](msdyn_projecttransactioncategory.md#BKMK_msdyn_projecttransactioncategory_ProcessSession) One-To-Many relationship.

### <a name="BKMK_msdyn_quotelineanalyticsbreakdown_ProcessSession"></a> msdyn_quotelineanalyticsbreakdown_ProcessSession

**Added by**: Project Service Automation Solution

See msdyn_quotelineanalyticsbreakdown Entity [msdyn_quotelineanalyticsbreakdown_ProcessSession](msdyn_quotelineanalyticsbreakdown.md#BKMK_msdyn_quotelineanalyticsbreakdown_ProcessSession) One-To-Many relationship.

### <a name="BKMK_msdyn_quotelineinvoiceschedule_ProcessSession"></a> msdyn_quotelineinvoiceschedule_ProcessSession

**Added by**: Project Service Automation Solution

See msdyn_quotelineinvoiceschedule Entity [msdyn_quotelineinvoiceschedule_ProcessSession](msdyn_quotelineinvoiceschedule.md#BKMK_msdyn_quotelineinvoiceschedule_ProcessSession) One-To-Many relationship.

### <a name="BKMK_msdyn_quotelineresourcecategory_ProcessSession"></a> msdyn_quotelineresourcecategory_ProcessSession

**Added by**: Project Service Automation Solution

See msdyn_quotelineresourcecategory Entity [msdyn_quotelineresourcecategory_ProcessSession](msdyn_quotelineresourcecategory.md#BKMK_msdyn_quotelineresourcecategory_ProcessSession) One-To-Many relationship.

### <a name="BKMK_msdyn_quotelinescheduleofvalue_ProcessSession"></a> msdyn_quotelinescheduleofvalue_ProcessSession

**Added by**: Project Service Automation Solution

See msdyn_quotelinescheduleofvalue Entity [msdyn_quotelinescheduleofvalue_ProcessSession](msdyn_quotelinescheduleofvalue.md#BKMK_msdyn_quotelinescheduleofvalue_ProcessSession) One-To-Many relationship.

### <a name="BKMK_msdyn_quotelinetransaction_ProcessSession"></a> msdyn_quotelinetransaction_ProcessSession

**Added by**: Project Service Automation Solution

See msdyn_quotelinetransaction Entity [msdyn_quotelinetransaction_ProcessSession](msdyn_quotelinetransaction.md#BKMK_msdyn_quotelinetransaction_ProcessSession) One-To-Many relationship.

### <a name="BKMK_msdyn_quotelinetransactioncategory_ProcessSession"></a> msdyn_quotelinetransactioncategory_ProcessSession

**Added by**: Project Service Automation Solution

See msdyn_quotelinetransactioncategory Entity [msdyn_quotelinetransactioncategory_ProcessSession](msdyn_quotelinetransactioncategory.md#BKMK_msdyn_quotelinetransactioncategory_ProcessSession) One-To-Many relationship.

### <a name="BKMK_msdyn_quotelinetransactionclassification_ProcessSession"></a> msdyn_quotelinetransactionclassification_ProcessSession

**Added by**: Project Service Automation Solution

See msdyn_quotelinetransactionclassification Entity [msdyn_quotelinetransactionclassification_ProcessSession](msdyn_quotelinetransactionclassification.md#BKMK_msdyn_quotelinetransactionclassification_ProcessSession) One-To-Many relationship.

### <a name="BKMK_msdyn_quotepricelist_ProcessSession"></a> msdyn_quotepricelist_ProcessSession

**Added by**: Project Service Automation Solution

See msdyn_quotepricelist Entity [msdyn_quotepricelist_ProcessSession](msdyn_quotepricelist.md#BKMK_msdyn_quotepricelist_ProcessSession) One-To-Many relationship.

### <a name="BKMK_msdyn_resourceassignment_ProcessSession"></a> msdyn_resourceassignment_ProcessSession

**Added by**: Project Service Automation Solution

See msdyn_resourceassignment Entity [msdyn_resourceassignment_ProcessSession](msdyn_resourceassignment.md#BKMK_msdyn_resourceassignment_ProcessSession) One-To-Many relationship.

### <a name="BKMK_msdyn_resourceassignmentdetail_ProcessSession"></a> msdyn_resourceassignmentdetail_ProcessSession

**Added by**: Project Service Automation Solution

See msdyn_resourceassignmentdetail Entity [msdyn_resourceassignmentdetail_ProcessSession](msdyn_resourceassignmentdetail.md#BKMK_msdyn_resourceassignmentdetail_ProcessSession) One-To-Many relationship.

### <a name="BKMK_msdyn_resourcecategorymarkuppricelevel_ProcessSession"></a> msdyn_resourcecategorymarkuppricelevel_ProcessSession

**Added by**: Project Service Automation Solution

See msdyn_resourcecategorymarkuppricelevel Entity [msdyn_resourcecategorymarkuppricelevel_ProcessSession](msdyn_resourcecategorymarkuppricelevel.md#BKMK_msdyn_resourcecategorymarkuppricelevel_ProcessSession) One-To-Many relationship.

### <a name="BKMK_msdyn_resourcecategorypricelevel_ProcessSession"></a> msdyn_resourcecategorypricelevel_ProcessSession

**Added by**: Project Service Automation Solution

See msdyn_resourcecategorypricelevel Entity [msdyn_resourcecategorypricelevel_ProcessSession](msdyn_resourcecategorypricelevel.md#BKMK_msdyn_resourcecategorypricelevel_ProcessSession) One-To-Many relationship.

### <a name="BKMK_msdyn_resourcerequest_ProcessSession"></a> msdyn_resourcerequest_ProcessSession

**Added by**: Project Service Automation Solution

See msdyn_resourcerequest Entity [msdyn_resourcerequest_ProcessSession](msdyn_resourcerequest.md#BKMK_msdyn_resourcerequest_ProcessSession) One-To-Many relationship.

### <a name="BKMK_msdyn_rolecompetencyrequirement_ProcessSession"></a> msdyn_rolecompetencyrequirement_ProcessSession

**Added by**: Project Service Automation Solution

See msdyn_rolecompetencyrequirement Entity [msdyn_rolecompetencyrequirement_ProcessSession](msdyn_rolecompetencyrequirement.md#BKMK_msdyn_rolecompetencyrequirement_ProcessSession) One-To-Many relationship.

### <a name="BKMK_msdyn_roleutilization_ProcessSession"></a> msdyn_roleutilization_ProcessSession

**Added by**: Project Service Automation Solution

See msdyn_roleutilization Entity [msdyn_roleutilization_ProcessSession](msdyn_roleutilization.md#BKMK_msdyn_roleutilization_ProcessSession) One-To-Many relationship.

### <a name="BKMK_msdyn_timeentry_ProcessSession"></a> msdyn_timeentry_ProcessSession

**Added by**: Project Service Automation Solution

See msdyn_timeentry Entity [msdyn_timeentry_ProcessSession](msdyn_timeentry.md#BKMK_msdyn_timeentry_ProcessSession) One-To-Many relationship.

### <a name="BKMK_msdyn_timeoffcalendar_ProcessSession"></a> msdyn_timeoffcalendar_ProcessSession

**Added by**: Project Service Automation Solution

See msdyn_timeoffcalendar Entity [msdyn_timeoffcalendar_ProcessSession](msdyn_timeoffcalendar.md#BKMK_msdyn_timeoffcalendar_ProcessSession) One-To-Many relationship.

### <a name="BKMK_msdyn_transactioncategory_ProcessSession"></a> msdyn_transactioncategory_ProcessSession

**Added by**: Project Service Automation Solution

See msdyn_transactioncategory Entity [msdyn_transactioncategory_ProcessSession](msdyn_transactioncategory.md#BKMK_msdyn_transactioncategory_ProcessSession) One-To-Many relationship.

### <a name="BKMK_msdyn_transactioncategoryclassification_ProcessSession"></a> msdyn_transactioncategoryclassification_ProcessSession

**Added by**: Project Service Automation Solution

See msdyn_transactioncategoryclassification Entity [msdyn_transactioncategoryclassification_ProcessSession](msdyn_transactioncategoryclassification.md#BKMK_msdyn_transactioncategoryclassification_ProcessSession) One-To-Many relationship.

### <a name="BKMK_msdyn_transactioncategoryhierarchyelement_ProcessSession"></a> msdyn_transactioncategoryhierarchyelement_ProcessSession

**Added by**: Project Service Automation Solution

See msdyn_transactioncategoryhierarchyelement Entity [msdyn_transactioncategoryhierarchyelement_ProcessSession](msdyn_transactioncategoryhierarchyelement.md#BKMK_msdyn_transactioncategoryhierarchyelement_ProcessSession) One-To-Many relationship.

### <a name="BKMK_msdyn_transactioncategorypricelevel_ProcessSession"></a> msdyn_transactioncategorypricelevel_ProcessSession

**Added by**: Project Service Automation Solution

See msdyn_transactioncategorypricelevel Entity [msdyn_transactioncategorypricelevel_ProcessSession](msdyn_transactioncategorypricelevel.md#BKMK_msdyn_transactioncategorypricelevel_ProcessSession) One-To-Many relationship.

### <a name="BKMK_msdyn_transactionconnection_ProcessSession"></a> msdyn_transactionconnection_ProcessSession

**Added by**: Project Service Automation Solution

See msdyn_transactionconnection Entity [msdyn_transactionconnection_ProcessSession](msdyn_transactionconnection.md#BKMK_msdyn_transactionconnection_ProcessSession) One-To-Many relationship.

### <a name="BKMK_msdyn_transactiontype_ProcessSession"></a> msdyn_transactiontype_ProcessSession

**Added by**: Project Service Automation Solution

See msdyn_transactiontype Entity [msdyn_transactiontype_ProcessSession](msdyn_transactiontype.md#BKMK_msdyn_transactiontype_ProcessSession) One-To-Many relationship.

### <a name="BKMK_msdyn_userworkhistory_ProcessSession"></a> msdyn_userworkhistory_ProcessSession

**Added by**: Project Service Automation Solution

See msdyn_userworkhistory Entity [msdyn_userworkhistory_ProcessSession](msdyn_userworkhistory.md#BKMK_msdyn_userworkhistory_ProcessSession) One-To-Many relationship.

### <a name="BKMK_msdyn_agreement_ProcessSession"></a> msdyn_agreement_ProcessSession

**Added by**: Field Service Solution

See msdyn_agreement Entity [msdyn_agreement_ProcessSession](msdyn_agreement.md#BKMK_msdyn_agreement_ProcessSession) One-To-Many relationship.

### <a name="BKMK_msdyn_agreementbookingdate_ProcessSession"></a> msdyn_agreementbookingdate_ProcessSession

**Added by**: Field Service Solution

See msdyn_agreementbookingdate Entity [msdyn_agreementbookingdate_ProcessSession](msdyn_agreementbookingdate.md#BKMK_msdyn_agreementbookingdate_ProcessSession) One-To-Many relationship.

### <a name="BKMK_msdyn_agreementbookingincident_ProcessSession"></a> msdyn_agreementbookingincident_ProcessSession

**Added by**: Field Service Solution

See msdyn_agreementbookingincident Entity [msdyn_agreementbookingincident_ProcessSession](msdyn_agreementbookingincident.md#BKMK_msdyn_agreementbookingincident_ProcessSession) One-To-Many relationship.

### <a name="BKMK_msdyn_agreementbookingproduct_ProcessSession"></a> msdyn_agreementbookingproduct_ProcessSession

**Added by**: Field Service Solution

See msdyn_agreementbookingproduct Entity [msdyn_agreementbookingproduct_ProcessSession](msdyn_agreementbookingproduct.md#BKMK_msdyn_agreementbookingproduct_ProcessSession) One-To-Many relationship.

### <a name="BKMK_msdyn_agreementbookingservice_ProcessSession"></a> msdyn_agreementbookingservice_ProcessSession

**Added by**: Field Service Solution

See msdyn_agreementbookingservice Entity [msdyn_agreementbookingservice_ProcessSession](msdyn_agreementbookingservice.md#BKMK_msdyn_agreementbookingservice_ProcessSession) One-To-Many relationship.

### <a name="BKMK_msdyn_agreementbookingservicetask_ProcessSession"></a> msdyn_agreementbookingservicetask_ProcessSession

**Added by**: Field Service Solution

See msdyn_agreementbookingservicetask Entity [msdyn_agreementbookingservicetask_ProcessSession](msdyn_agreementbookingservicetask.md#BKMK_msdyn_agreementbookingservicetask_ProcessSession) One-To-Many relationship.

### <a name="BKMK_msdyn_agreementbookingsetup_ProcessSession"></a> msdyn_agreementbookingsetup_ProcessSession

**Added by**: Field Service Solution

See msdyn_agreementbookingsetup Entity [msdyn_agreementbookingsetup_ProcessSession](msdyn_agreementbookingsetup.md#BKMK_msdyn_agreementbookingsetup_ProcessSession) One-To-Many relationship.

### <a name="BKMK_msdyn_agreementinvoicedate_ProcessSession"></a> msdyn_agreementinvoicedate_ProcessSession

**Added by**: Field Service Solution

See msdyn_agreementinvoicedate Entity [msdyn_agreementinvoicedate_ProcessSession](msdyn_agreementinvoicedate.md#BKMK_msdyn_agreementinvoicedate_ProcessSession) One-To-Many relationship.

### <a name="BKMK_msdyn_agreementinvoiceproduct_ProcessSession"></a> msdyn_agreementinvoiceproduct_ProcessSession

**Added by**: Field Service Solution

See msdyn_agreementinvoiceproduct Entity [msdyn_agreementinvoiceproduct_ProcessSession](msdyn_agreementinvoiceproduct.md#BKMK_msdyn_agreementinvoiceproduct_ProcessSession) One-To-Many relationship.

### <a name="BKMK_msdyn_agreementinvoicesetup_ProcessSession"></a> msdyn_agreementinvoicesetup_ProcessSession

**Added by**: Field Service Solution

See msdyn_agreementinvoicesetup Entity [msdyn_agreementinvoicesetup_ProcessSession](msdyn_agreementinvoicesetup.md#BKMK_msdyn_agreementinvoicesetup_ProcessSession) One-To-Many relationship.

### <a name="BKMK_msdyn_agreementsubstatus_ProcessSession"></a> msdyn_agreementsubstatus_ProcessSession

**Added by**: Field Service Solution

See msdyn_agreementsubstatus Entity [msdyn_agreementsubstatus_ProcessSession](msdyn_agreementsubstatus.md#BKMK_msdyn_agreementsubstatus_ProcessSession) One-To-Many relationship.

### <a name="BKMK_msdyn_bookingjournal_ProcessSession"></a> msdyn_bookingjournal_ProcessSession

**Added by**: Field Service Solution

See msdyn_bookingjournal Entity [msdyn_bookingjournal_ProcessSession](msdyn_bookingjournal.md#BKMK_msdyn_bookingjournal_ProcessSession) One-To-Many relationship.

### <a name="BKMK_msdyn_bookingtimestamp_ProcessSession"></a> msdyn_bookingtimestamp_ProcessSession

**Added by**: Field Service Solution

See msdyn_bookingtimestamp Entity [msdyn_bookingtimestamp_ProcessSession](msdyn_bookingtimestamp.md#BKMK_msdyn_bookingtimestamp_ProcessSession) One-To-Many relationship.

### <a name="BKMK_msdyn_bpf_2c5fe86acc8b414b8322ae571000c799_ProcessSession"></a> msdyn_bpf_2c5fe86acc8b414b8322ae571000c799_ProcessSession

**Added by**: Field Service Solution

See msdyn_bpf_2c5fe86acc8b414b8322ae571000c799 Entity [msdyn_bpf_2c5fe86acc8b414b8322ae571000c799_ProcessSession](msdyn_bpf_2c5fe86acc8b414b8322ae571000c799.md#BKMK_msdyn_bpf_2c5fe86acc8b414b8322ae571000c799_ProcessSession) One-To-Many relationship.

### <a name="BKMK_msdyn_bpf_989e9b1857e24af18787d5143b67523b_ProcessSession"></a> msdyn_bpf_989e9b1857e24af18787d5143b67523b_ProcessSession

**Added by**: Field Service Solution

See msdyn_bpf_989e9b1857e24af18787d5143b67523b Entity [msdyn_bpf_989e9b1857e24af18787d5143b67523b_ProcessSession](msdyn_bpf_989e9b1857e24af18787d5143b67523b.md#BKMK_msdyn_bpf_989e9b1857e24af18787d5143b67523b_ProcessSession) One-To-Many relationship.

### <a name="BKMK_msdyn_bpf_baa0a411a239410cb8bded8b5fdd88e3_ProcessSession"></a> msdyn_bpf_baa0a411a239410cb8bded8b5fdd88e3_ProcessSession

**Added by**: Field Service Solution

See msdyn_bpf_baa0a411a239410cb8bded8b5fdd88e3 Entity [msdyn_bpf_baa0a411a239410cb8bded8b5fdd88e3_ProcessSession](msdyn_bpf_baa0a411a239410cb8bded8b5fdd88e3.md#BKMK_msdyn_bpf_baa0a411a239410cb8bded8b5fdd88e3_ProcessSession) One-To-Many relationship.

### <a name="BKMK_msdyn_bpf_d3d97bac8c294105840e99e37a9d1c39_ProcessSession"></a> msdyn_bpf_d3d97bac8c294105840e99e37a9d1c39_ProcessSession

**Added by**: Field Service Solution

See msdyn_bpf_d3d97bac8c294105840e99e37a9d1c39 Entity [msdyn_bpf_d3d97bac8c294105840e99e37a9d1c39_ProcessSession](msdyn_bpf_d3d97bac8c294105840e99e37a9d1c39.md#BKMK_msdyn_bpf_d3d97bac8c294105840e99e37a9d1c39_ProcessSession) One-To-Many relationship.

### <a name="BKMK_msdyn_customerasset_ProcessSession"></a> msdyn_customerasset_ProcessSession

**Added by**: Field Service Solution

See msdyn_customerasset Entity [msdyn_customerasset_ProcessSession](msdyn_customerasset.md#BKMK_msdyn_customerasset_ProcessSession) One-To-Many relationship.

### <a name="BKMK_msdyn_customerassetcategory_ProcessSession"></a> msdyn_customerassetcategory_ProcessSession

**Added by**: Field Service Solution

See msdyn_customerassetcategory Entity [msdyn_customerassetcategory_ProcessSession](msdyn_customerassetcategory.md#BKMK_msdyn_customerassetcategory_ProcessSession) One-To-Many relationship.

### <a name="BKMK_msdyn_entitlementapplication_ProcessSession"></a> msdyn_entitlementapplication_ProcessSession

**Added by**: Field Service Solution

See msdyn_entitlementapplication Entity [msdyn_entitlementapplication_ProcessSession](msdyn_entitlementapplication.md#BKMK_msdyn_entitlementapplication_ProcessSession) One-To-Many relationship.

### <a name="BKMK_msdyn_fieldservicepricelistitem_ProcessSession"></a> msdyn_fieldservicepricelistitem_ProcessSession

**Added by**: Field Service Solution

See msdyn_fieldservicepricelistitem Entity [msdyn_fieldservicepricelistitem_ProcessSession](msdyn_fieldservicepricelistitem.md#BKMK_msdyn_fieldservicepricelistitem_ProcessSession) One-To-Many relationship.

### <a name="BKMK_msdyn_fieldservicesetting_ProcessSession"></a> msdyn_fieldservicesetting_ProcessSession

**Added by**: Field Service Solution

See msdyn_fieldservicesetting Entity [msdyn_fieldservicesetting_ProcessSession](msdyn_fieldservicesetting.md#BKMK_msdyn_fieldservicesetting_ProcessSession) One-To-Many relationship.

### <a name="BKMK_msdyn_fieldserviceslaconfiguration_ProcessSession"></a> msdyn_fieldserviceslaconfiguration_ProcessSession

**Added by**: Field Service Solution

See msdyn_fieldserviceslaconfiguration Entity [msdyn_fieldserviceslaconfiguration_ProcessSession](msdyn_fieldserviceslaconfiguration.md#BKMK_msdyn_fieldserviceslaconfiguration_ProcessSession) One-To-Many relationship.

### <a name="BKMK_msdyn_fieldservicesystemjob_ProcessSession"></a> msdyn_fieldservicesystemjob_ProcessSession

**Added by**: Field Service Solution

See msdyn_fieldservicesystemjob Entity [msdyn_fieldservicesystemjob_ProcessSession](msdyn_fieldservicesystemjob.md#BKMK_msdyn_fieldservicesystemjob_ProcessSession) One-To-Many relationship.

### <a name="BKMK_msdyn_incidenttype_ProcessSession"></a> msdyn_incidenttype_ProcessSession

**Added by**: Field Service Solution

See msdyn_incidenttype Entity [msdyn_incidenttype_ProcessSession](msdyn_incidenttype.md#BKMK_msdyn_incidenttype_ProcessSession) One-To-Many relationship.

### <a name="BKMK_msdyn_incidenttypecharacteristic_ProcessSession"></a> msdyn_incidenttypecharacteristic_ProcessSession

**Added by**: Field Service Solution

See msdyn_incidenttypecharacteristic Entity [msdyn_incidenttypecharacteristic_ProcessSession](msdyn_incidenttypecharacteristic.md#BKMK_msdyn_incidenttypecharacteristic_ProcessSession) One-To-Many relationship.

### <a name="BKMK_msdyn_incidenttypeproduct_ProcessSession"></a> msdyn_incidenttypeproduct_ProcessSession

**Added by**: Field Service Solution

See msdyn_incidenttypeproduct Entity [msdyn_incidenttypeproduct_ProcessSession](msdyn_incidenttypeproduct.md#BKMK_msdyn_incidenttypeproduct_ProcessSession) One-To-Many relationship.

### <a name="BKMK_msdyn_incidenttypeservice_ProcessSession"></a> msdyn_incidenttypeservice_ProcessSession

**Added by**: Field Service Solution

See msdyn_incidenttypeservice Entity [msdyn_incidenttypeservice_ProcessSession](msdyn_incidenttypeservice.md#BKMK_msdyn_incidenttypeservice_ProcessSession) One-To-Many relationship.

### <a name="BKMK_msdyn_incidenttypeservicetask_ProcessSession"></a> msdyn_incidenttypeservicetask_ProcessSession

**Added by**: Field Service Solution

See msdyn_incidenttypeservicetask Entity [msdyn_incidenttypeservicetask_ProcessSession](msdyn_incidenttypeservicetask.md#BKMK_msdyn_incidenttypeservicetask_ProcessSession) One-To-Many relationship.

### <a name="BKMK_msdyn_incidenttypessetup_ProcessSession"></a> msdyn_incidenttypessetup_ProcessSession

**Added by**: Field Service Solution

See msdyn_incidenttypessetup Entity [msdyn_incidenttypessetup_ProcessSession](msdyn_incidenttypessetup.md#BKMK_msdyn_incidenttypessetup_ProcessSession) One-To-Many relationship.

### <a name="BKMK_msdyn_incidenttype_requirementgroup_ProcessSession"></a> msdyn_incidenttype_requirementgroup_ProcessSession

**Added by**: Field Service Solution

See msdyn_incidenttype_requirementgroup Entity [msdyn_incidenttype_requirementgroup_ProcessSession](msdyn_incidenttype_requirementgroup.md#BKMK_msdyn_incidenttype_requirementgroup_ProcessSession) One-To-Many relationship.

### <a name="BKMK_msdyn_inventoryadjustment_ProcessSession"></a> msdyn_inventoryadjustment_ProcessSession

**Added by**: Field Service Solution

See msdyn_inventoryadjustment Entity [msdyn_inventoryadjustment_ProcessSession](msdyn_inventoryadjustment.md#BKMK_msdyn_inventoryadjustment_ProcessSession) One-To-Many relationship.

### <a name="BKMK_msdyn_inventoryadjustmentproduct_ProcessSession"></a> msdyn_inventoryadjustmentproduct_ProcessSession

**Added by**: Field Service Solution

See msdyn_inventoryadjustmentproduct Entity [msdyn_inventoryadjustmentproduct_ProcessSession](msdyn_inventoryadjustmentproduct.md#BKMK_msdyn_inventoryadjustmentproduct_ProcessSession) One-To-Many relationship.

### <a name="BKMK_msdyn_inventoryjournal_ProcessSession"></a> msdyn_inventoryjournal_ProcessSession

**Added by**: Field Service Solution

See msdyn_inventoryjournal Entity [msdyn_inventoryjournal_ProcessSession](msdyn_inventoryjournal.md#BKMK_msdyn_inventoryjournal_ProcessSession) One-To-Many relationship.

### <a name="BKMK_msdyn_inventorytransfer_ProcessSession"></a> msdyn_inventorytransfer_ProcessSession

**Added by**: Field Service Solution

See msdyn_inventorytransfer Entity [msdyn_inventorytransfer_ProcessSession](msdyn_inventorytransfer.md#BKMK_msdyn_inventorytransfer_ProcessSession) One-To-Many relationship.

### <a name="BKMK_msdyn_orderinvoicingdate_ProcessSession"></a> msdyn_orderinvoicingdate_ProcessSession

**Added by**: Field Service Solution

See msdyn_orderinvoicingdate Entity [msdyn_orderinvoicingdate_ProcessSession](msdyn_orderinvoicingdate.md#BKMK_msdyn_orderinvoicingdate_ProcessSession) One-To-Many relationship.

### <a name="BKMK_msdyn_orderinvoicingproduct_ProcessSession"></a> msdyn_orderinvoicingproduct_ProcessSession

**Added by**: Field Service Solution

See msdyn_orderinvoicingproduct Entity [msdyn_orderinvoicingproduct_ProcessSession](msdyn_orderinvoicingproduct.md#BKMK_msdyn_orderinvoicingproduct_ProcessSession) One-To-Many relationship.

### <a name="BKMK_msdyn_orderinvoicingsetup_ProcessSession"></a> msdyn_orderinvoicingsetup_ProcessSession

**Added by**: Field Service Solution

See msdyn_orderinvoicingsetup Entity [msdyn_orderinvoicingsetup_ProcessSession](msdyn_orderinvoicingsetup.md#BKMK_msdyn_orderinvoicingsetup_ProcessSession) One-To-Many relationship.

### <a name="BKMK_msdyn_orderinvoicingsetupdate_ProcessSession"></a> msdyn_orderinvoicingsetupdate_ProcessSession

**Added by**: Field Service Solution

See msdyn_orderinvoicingsetupdate Entity [msdyn_orderinvoicingsetupdate_ProcessSession](msdyn_orderinvoicingsetupdate.md#BKMK_msdyn_orderinvoicingsetupdate_ProcessSession) One-To-Many relationship.

### <a name="BKMK_msdyn_payment_ProcessSession"></a> msdyn_payment_ProcessSession

**Added by**: Field Service Solution

See msdyn_payment Entity [msdyn_payment_ProcessSession](msdyn_payment.md#BKMK_msdyn_payment_ProcessSession) One-To-Many relationship.

### <a name="BKMK_msdyn_paymentdetail_ProcessSession"></a> msdyn_paymentdetail_ProcessSession

**Added by**: Field Service Solution

See msdyn_paymentdetail Entity [msdyn_paymentdetail_ProcessSession](msdyn_paymentdetail.md#BKMK_msdyn_paymentdetail_ProcessSession) One-To-Many relationship.

### <a name="BKMK_msdyn_paymentmethod_ProcessSession"></a> msdyn_paymentmethod_ProcessSession

**Added by**: Field Service Solution

See msdyn_paymentmethod Entity [msdyn_paymentmethod_ProcessSession](msdyn_paymentmethod.md#BKMK_msdyn_paymentmethod_ProcessSession) One-To-Many relationship.

### <a name="BKMK_msdyn_paymentterm_ProcessSession"></a> msdyn_paymentterm_ProcessSession

**Added by**: Field Service Solution

See msdyn_paymentterm Entity [msdyn_paymentterm_ProcessSession](msdyn_paymentterm.md#BKMK_msdyn_paymentterm_ProcessSession) One-To-Many relationship.

### <a name="BKMK_msdyn_postalcode_ProcessSession"></a> msdyn_postalcode_ProcessSession

**Added by**: Field Service Solution

See msdyn_postalcode Entity [msdyn_postalcode_ProcessSession](msdyn_postalcode.md#BKMK_msdyn_postalcode_ProcessSession) One-To-Many relationship.

### <a name="BKMK_msdyn_productinventory_ProcessSession"></a> msdyn_productinventory_ProcessSession

**Added by**: Field Service Solution

See msdyn_productinventory Entity [msdyn_productinventory_ProcessSession](msdyn_productinventory.md#BKMK_msdyn_productinventory_ProcessSession) One-To-Many relationship.

### <a name="BKMK_msdyn_purchaseorder_ProcessSession"></a> msdyn_purchaseorder_ProcessSession

**Added by**: Field Service Solution

See msdyn_purchaseorder Entity [msdyn_purchaseorder_ProcessSession](msdyn_purchaseorder.md#BKMK_msdyn_purchaseorder_ProcessSession) One-To-Many relationship.

### <a name="BKMK_msdyn_purchaseorderbill_ProcessSession"></a> msdyn_purchaseorderbill_ProcessSession

**Added by**: Field Service Solution

See msdyn_purchaseorderbill Entity [msdyn_purchaseorderbill_ProcessSession](msdyn_purchaseorderbill.md#BKMK_msdyn_purchaseorderbill_ProcessSession) One-To-Many relationship.

### <a name="BKMK_msdyn_purchaseorderproduct_ProcessSession"></a> msdyn_purchaseorderproduct_ProcessSession

**Added by**: Field Service Solution

See msdyn_purchaseorderproduct Entity [msdyn_purchaseorderproduct_ProcessSession](msdyn_purchaseorderproduct.md#BKMK_msdyn_purchaseorderproduct_ProcessSession) One-To-Many relationship.

### <a name="BKMK_msdyn_purchaseorderreceipt_ProcessSession"></a> msdyn_purchaseorderreceipt_ProcessSession

**Added by**: Field Service Solution

See msdyn_purchaseorderreceipt Entity [msdyn_purchaseorderreceipt_ProcessSession](msdyn_purchaseorderreceipt.md#BKMK_msdyn_purchaseorderreceipt_ProcessSession) One-To-Many relationship.

### <a name="BKMK_msdyn_purchaseorderreceiptproduct_ProcessSession"></a> msdyn_purchaseorderreceiptproduct_ProcessSession

**Added by**: Field Service Solution

See msdyn_purchaseorderreceiptproduct Entity [msdyn_purchaseorderreceiptproduct_ProcessSession](msdyn_purchaseorderreceiptproduct.md#BKMK_msdyn_purchaseorderreceiptproduct_ProcessSession) One-To-Many relationship.

### <a name="BKMK_msdyn_purchaseordersubstatus_ProcessSession"></a> msdyn_purchaseordersubstatus_ProcessSession

**Added by**: Field Service Solution

See msdyn_purchaseordersubstatus Entity [msdyn_purchaseordersubstatus_ProcessSession](msdyn_purchaseordersubstatus.md#BKMK_msdyn_purchaseordersubstatus_ProcessSession) One-To-Many relationship.

### <a name="BKMK_msdyn_quotebookingincident_ProcessSession"></a> msdyn_quotebookingincident_ProcessSession

**Added by**: Field Service Solution

See msdyn_quotebookingincident Entity [msdyn_quotebookingincident_ProcessSession](msdyn_quotebookingincident.md#BKMK_msdyn_quotebookingincident_ProcessSession) One-To-Many relationship.

### <a name="BKMK_msdyn_quotebookingproduct_ProcessSession"></a> msdyn_quotebookingproduct_ProcessSession

**Added by**: Field Service Solution

See msdyn_quotebookingproduct Entity [msdyn_quotebookingproduct_ProcessSession](msdyn_quotebookingproduct.md#BKMK_msdyn_quotebookingproduct_ProcessSession) One-To-Many relationship.

### <a name="BKMK_msdyn_quotebookingservice_ProcessSession"></a> msdyn_quotebookingservice_ProcessSession

**Added by**: Field Service Solution

See msdyn_quotebookingservice Entity [msdyn_quotebookingservice_ProcessSession](msdyn_quotebookingservice.md#BKMK_msdyn_quotebookingservice_ProcessSession) One-To-Many relationship.

### <a name="BKMK_msdyn_quotebookingservicetask_ProcessSession"></a> msdyn_quotebookingservicetask_ProcessSession

**Added by**: Field Service Solution

See msdyn_quotebookingservicetask Entity [msdyn_quotebookingservicetask_ProcessSession](msdyn_quotebookingservicetask.md#BKMK_msdyn_quotebookingservicetask_ProcessSession) One-To-Many relationship.

### <a name="BKMK_msdyn_quotebookingsetup_ProcessSession"></a> msdyn_quotebookingsetup_ProcessSession

**Added by**: Field Service Solution

See msdyn_quotebookingsetup Entity [msdyn_quotebookingsetup_ProcessSession](msdyn_quotebookingsetup.md#BKMK_msdyn_quotebookingsetup_ProcessSession) One-To-Many relationship.

### <a name="BKMK_msdyn_quoteinvoicingproduct_ProcessSession"></a> msdyn_quoteinvoicingproduct_ProcessSession

**Added by**: Field Service Solution

See msdyn_quoteinvoicingproduct Entity [msdyn_quoteinvoicingproduct_ProcessSession](msdyn_quoteinvoicingproduct.md#BKMK_msdyn_quoteinvoicingproduct_ProcessSession) One-To-Many relationship.

### <a name="BKMK_msdyn_quoteinvoicingsetup_ProcessSession"></a> msdyn_quoteinvoicingsetup_ProcessSession

**Added by**: Field Service Solution

See msdyn_quoteinvoicingsetup Entity [msdyn_quoteinvoicingsetup_ProcessSession](msdyn_quoteinvoicingsetup.md#BKMK_msdyn_quoteinvoicingsetup_ProcessSession) One-To-Many relationship.

### <a name="BKMK_msdyn_resourcepaytype_ProcessSession"></a> msdyn_resourcepaytype_ProcessSession

**Added by**: Field Service Solution

See msdyn_resourcepaytype Entity [msdyn_resourcepaytype_ProcessSession](msdyn_resourcepaytype.md#BKMK_msdyn_resourcepaytype_ProcessSession) One-To-Many relationship.

### <a name="BKMK_msdyn_rma_ProcessSession"></a> msdyn_rma_ProcessSession

**Added by**: Field Service Solution

See msdyn_rma Entity [msdyn_rma_ProcessSession](msdyn_rma.md#BKMK_msdyn_rma_ProcessSession) One-To-Many relationship.

### <a name="BKMK_msdyn_rmaproduct_ProcessSession"></a> msdyn_rmaproduct_ProcessSession

**Added by**: Field Service Solution

See msdyn_rmaproduct Entity [msdyn_rmaproduct_ProcessSession](msdyn_rmaproduct.md#BKMK_msdyn_rmaproduct_ProcessSession) One-To-Many relationship.

### <a name="BKMK_msdyn_rmareceipt_ProcessSession"></a> msdyn_rmareceipt_ProcessSession

**Added by**: Field Service Solution

See msdyn_rmareceipt Entity [msdyn_rmareceipt_ProcessSession](msdyn_rmareceipt.md#BKMK_msdyn_rmareceipt_ProcessSession) One-To-Many relationship.

### <a name="BKMK_msdyn_rmareceiptproduct_ProcessSession"></a> msdyn_rmareceiptproduct_ProcessSession

**Added by**: Field Service Solution

See msdyn_rmareceiptproduct Entity [msdyn_rmareceiptproduct_ProcessSession](msdyn_rmareceiptproduct.md#BKMK_msdyn_rmareceiptproduct_ProcessSession) One-To-Many relationship.

### <a name="BKMK_msdyn_rmasubstatus_ProcessSession"></a> msdyn_rmasubstatus_ProcessSession

**Added by**: Field Service Solution

See msdyn_rmasubstatus Entity [msdyn_rmasubstatus_ProcessSession](msdyn_rmasubstatus.md#BKMK_msdyn_rmasubstatus_ProcessSession) One-To-Many relationship.

### <a name="BKMK_msdyn_rtv_ProcessSession"></a> msdyn_rtv_ProcessSession

**Added by**: Field Service Solution

See msdyn_rtv Entity [msdyn_rtv_ProcessSession](msdyn_rtv.md#BKMK_msdyn_rtv_ProcessSession) One-To-Many relationship.

### <a name="BKMK_msdyn_rtvproduct_ProcessSession"></a> msdyn_rtvproduct_ProcessSession

**Added by**: Field Service Solution

See msdyn_rtvproduct Entity [msdyn_rtvproduct_ProcessSession](msdyn_rtvproduct.md#BKMK_msdyn_rtvproduct_ProcessSession) One-To-Many relationship.

### <a name="BKMK_msdyn_rtvsubstatus_ProcessSession"></a> msdyn_rtvsubstatus_ProcessSession

**Added by**: Field Service Solution

See msdyn_rtvsubstatus Entity [msdyn_rtvsubstatus_ProcessSession](msdyn_rtvsubstatus.md#BKMK_msdyn_rtvsubstatus_ProcessSession) One-To-Many relationship.

### <a name="BKMK_msdyn_servicetasktype_ProcessSession"></a> msdyn_servicetasktype_ProcessSession

**Added by**: Field Service Solution

See msdyn_servicetasktype Entity [msdyn_servicetasktype_ProcessSession](msdyn_servicetasktype.md#BKMK_msdyn_servicetasktype_ProcessSession) One-To-Many relationship.

### <a name="BKMK_msdyn_shipvia_ProcessSession"></a> msdyn_shipvia_ProcessSession

**Added by**: Field Service Solution

See msdyn_shipvia Entity [msdyn_shipvia_ProcessSession](msdyn_shipvia.md#BKMK_msdyn_shipvia_ProcessSession) One-To-Many relationship.

### <a name="BKMK_msdyn_taxcode_ProcessSession"></a> msdyn_taxcode_ProcessSession

**Added by**: Field Service Solution

See msdyn_taxcode Entity [msdyn_taxcode_ProcessSession](msdyn_taxcode.md#BKMK_msdyn_taxcode_ProcessSession) One-To-Many relationship.

### <a name="BKMK_msdyn_taxcodedetail_ProcessSession"></a> msdyn_taxcodedetail_ProcessSession

**Added by**: Field Service Solution

See msdyn_taxcodedetail Entity [msdyn_taxcodedetail_ProcessSession](msdyn_taxcodedetail.md#BKMK_msdyn_taxcodedetail_ProcessSession) One-To-Many relationship.

### <a name="BKMK_msdyn_timeoffrequest_ProcessSession"></a> msdyn_timeoffrequest_ProcessSession

**Added by**: Field Service Solution

See msdyn_timeoffrequest Entity [msdyn_timeoffrequest_ProcessSession](msdyn_timeoffrequest.md#BKMK_msdyn_timeoffrequest_ProcessSession) One-To-Many relationship.

### <a name="BKMK_msdyn_uniquenumber_ProcessSession"></a> msdyn_uniquenumber_ProcessSession

**Added by**: Field Service Solution

See msdyn_uniquenumber Entity [msdyn_uniquenumber_ProcessSession](msdyn_uniquenumber.md#BKMK_msdyn_uniquenumber_ProcessSession) One-To-Many relationship.

### <a name="BKMK_msdyn_warehouse_ProcessSession"></a> msdyn_warehouse_ProcessSession

**Added by**: Field Service Solution

See msdyn_warehouse Entity [msdyn_warehouse_ProcessSession](msdyn_warehouse.md#BKMK_msdyn_warehouse_ProcessSession) One-To-Many relationship.

### <a name="BKMK_msdyn_workorder_ProcessSession"></a> msdyn_workorder_ProcessSession

**Added by**: Field Service Solution

See msdyn_workorder Entity [msdyn_workorder_ProcessSession](msdyn_workorder.md#BKMK_msdyn_workorder_ProcessSession) One-To-Many relationship.

### <a name="BKMK_msdyn_workordercharacteristic_ProcessSession"></a> msdyn_workordercharacteristic_ProcessSession

**Added by**: Field Service Solution

See msdyn_workordercharacteristic Entity [msdyn_workordercharacteristic_ProcessSession](msdyn_workordercharacteristic.md#BKMK_msdyn_workordercharacteristic_ProcessSession) One-To-Many relationship.

### <a name="BKMK_msdyn_workorderdetailsgenerationqueue_ProcessSession"></a> msdyn_workorderdetailsgenerationqueue_ProcessSession

**Added by**: Field Service Solution

See msdyn_workorderdetailsgenerationqueue Entity [msdyn_workorderdetailsgenerationqueue_ProcessSession](msdyn_workorderdetailsgenerationqueue.md#BKMK_msdyn_workorderdetailsgenerationqueue_ProcessSession) One-To-Many relationship.

### <a name="BKMK_msdyn_workorderincident_ProcessSession"></a> msdyn_workorderincident_ProcessSession

**Added by**: Field Service Solution

See msdyn_workorderincident Entity [msdyn_workorderincident_ProcessSession](msdyn_workorderincident.md#BKMK_msdyn_workorderincident_ProcessSession) One-To-Many relationship.

### <a name="BKMK_msdyn_workorderproduct_ProcessSession"></a> msdyn_workorderproduct_ProcessSession

**Added by**: Field Service Solution

See msdyn_workorderproduct Entity [msdyn_workorderproduct_ProcessSession](msdyn_workorderproduct.md#BKMK_msdyn_workorderproduct_ProcessSession) One-To-Many relationship.

### <a name="BKMK_msdyn_workorderresourcerestriction_ProcessSession"></a> msdyn_workorderresourcerestriction_ProcessSession

**Added by**: Field Service Solution

See msdyn_workorderresourcerestriction Entity [msdyn_workorderresourcerestriction_ProcessSession](msdyn_workorderresourcerestriction.md#BKMK_msdyn_workorderresourcerestriction_ProcessSession) One-To-Many relationship.

### <a name="BKMK_msdyn_workorderservice_ProcessSession"></a> msdyn_workorderservice_ProcessSession

**Added by**: Field Service Solution

See msdyn_workorderservice Entity [msdyn_workorderservice_ProcessSession](msdyn_workorderservice.md#BKMK_msdyn_workorderservice_ProcessSession) One-To-Many relationship.

### <a name="BKMK_msdyn_workorderservicetask_ProcessSession"></a> msdyn_workorderservicetask_ProcessSession

**Added by**: Field Service Solution

See msdyn_workorderservicetask Entity [msdyn_workorderservicetask_ProcessSession](msdyn_workorderservicetask.md#BKMK_msdyn_workorderservicetask_ProcessSession) One-To-Many relationship.

### <a name="BKMK_msdyn_workordersubstatus_ProcessSession"></a> msdyn_workordersubstatus_ProcessSession

**Added by**: Field Service Solution

See msdyn_workordersubstatus Entity [msdyn_workordersubstatus_ProcessSession](msdyn_workordersubstatus.md#BKMK_msdyn_workordersubstatus_ProcessSession) One-To-Many relationship.

### <a name="BKMK_msdyn_workordertype_ProcessSession"></a> msdyn_workordertype_ProcessSession

**Added by**: Field Service Solution

See msdyn_workordertype Entity [msdyn_workordertype_ProcessSession](msdyn_workordertype.md#BKMK_msdyn_workordertype_ProcessSession) One-To-Many relationship.

### <a name="BKMK_msdyn_iotalert_ProcessSession"></a> msdyn_iotalert_ProcessSession

**Added by**: IoT Connector for Microsoft Dynamics 365 Solution

See msdyn_iotalert Entity [msdyn_iotalert_ProcessSession](msdyn_iotalert.md#BKMK_msdyn_iotalert_ProcessSession) One-To-Many relationship.

### <a name="BKMK_msdyn_iotdevice_ProcessSession"></a> msdyn_iotdevice_ProcessSession

**Added by**: IoT Connector for Microsoft Dynamics 365 Solution

See msdyn_iotdevice Entity [msdyn_iotdevice_ProcessSession](msdyn_iotdevice.md#BKMK_msdyn_iotdevice_ProcessSession) One-To-Many relationship.

### <a name="BKMK_msdyn_iotdevicecategory_ProcessSession"></a> msdyn_iotdevicecategory_ProcessSession

**Added by**: IoT Connector for Microsoft Dynamics 365 Solution

See msdyn_iotdevicecategory Entity [msdyn_iotdevicecategory_ProcessSession](msdyn_iotdevicecategory.md#BKMK_msdyn_iotdevicecategory_ProcessSession) One-To-Many relationship.

### <a name="BKMK_msdyn_iotdevicecommand_ProcessSession"></a> msdyn_iotdevicecommand_ProcessSession

**Added by**: IoT Connector for Microsoft Dynamics 365 Solution

See msdyn_iotdevicecommand Entity [msdyn_iotdevicecommand_ProcessSession](msdyn_iotdevicecommand.md#BKMK_msdyn_iotdevicecommand_ProcessSession) One-To-Many relationship.

### <a name="BKMK_msdyn_iotdevicecommanddefinition_ProcessSession"></a> msdyn_iotdevicecommanddefinition_ProcessSession

**Added by**: IoT Connector for Microsoft Dynamics 365 Solution

See msdyn_iotdevicecommanddefinition Entity [msdyn_iotdevicecommanddefinition_ProcessSession](msdyn_iotdevicecommanddefinition.md#BKMK_msdyn_iotdevicecommanddefinition_ProcessSession) One-To-Many relationship.

### <a name="BKMK_msdyn_iotdevicedatahistory_ProcessSession"></a> msdyn_iotdevicedatahistory_ProcessSession

**Added by**: IoT Connector for Microsoft Dynamics 365 Solution

See msdyn_iotdevicedatahistory Entity [msdyn_iotdevicedatahistory_ProcessSession](msdyn_iotdevicedatahistory.md#BKMK_msdyn_iotdevicedatahistory_ProcessSession) One-To-Many relationship.

### <a name="BKMK_msdyn_iotdeviceproperty_ProcessSession"></a> msdyn_iotdeviceproperty_ProcessSession

**Added by**: IoT Connector for Microsoft Dynamics 365 Solution

See msdyn_iotdeviceproperty Entity [msdyn_iotdeviceproperty_ProcessSession](msdyn_iotdeviceproperty.md#BKMK_msdyn_iotdeviceproperty_ProcessSession) One-To-Many relationship.

### <a name="BKMK_msdyn_iotdeviceregistrationhistory_ProcessSession"></a> msdyn_iotdeviceregistrationhistory_ProcessSession

**Added by**: IoT Connector for Microsoft Dynamics 365 Solution

See msdyn_iotdeviceregistrationhistory Entity [msdyn_iotdeviceregistrationhistory_ProcessSession](msdyn_iotdeviceregistrationhistory.md#BKMK_msdyn_iotdeviceregistrationhistory_ProcessSession) One-To-Many relationship.

### <a name="BKMK_msdyn_iotpropertydefinition_ProcessSession"></a> msdyn_iotpropertydefinition_ProcessSession

**Added by**: IoT Connector for Microsoft Dynamics 365 Solution

See msdyn_iotpropertydefinition Entity [msdyn_iotpropertydefinition_ProcessSession](msdyn_iotpropertydefinition.md#BKMK_msdyn_iotpropertydefinition_ProcessSession) One-To-Many relationship.

### <a name="BKMK_msdyn_iotsettings_ProcessSession"></a> msdyn_iotsettings_ProcessSession

**Added by**: IoT Connector for Microsoft Dynamics 365 Solution

See msdyn_iotsettings Entity [msdyn_iotsettings_ProcessSession](msdyn_iotsettings.md#BKMK_msdyn_iotsettings_ProcessSession) One-To-Many relationship.

### <a name="BKMK_msdyn_bpf_477c16f59170487b8b4dc895c5dcd09b_ProcessSession"></a> msdyn_bpf_477c16f59170487b8b4dc895c5dcd09b_ProcessSession

**Added by**: Connected Field Service for Microsoft Dynamics 365 Solution

See msdyn_bpf_477c16f59170487b8b4dc895c5dcd09b Entity [msdyn_bpf_477c16f59170487b8b4dc895c5dcd09b_ProcessSession](msdyn_bpf_477c16f59170487b8b4dc895c5dcd09b.md#BKMK_msdyn_bpf_477c16f59170487b8b4dc895c5dcd09b_ProcessSession) One-To-Many relationship.

### <a name="BKMK_msdyn_entityconfiguration_ProcessSession"></a> msdyn_entityconfiguration_ProcessSession

**Added by**: Geofence Management Solution

See msdyn_entityconfiguration Entity [msdyn_entityconfiguration_ProcessSession](msdyn_entityconfiguration.md#BKMK_msdyn_entityconfiguration_ProcessSession) One-To-Many relationship.

### <a name="BKMK_msdyn_geofence_ProcessSession"></a> msdyn_geofence_ProcessSession

**Added by**: Geofence Management Solution

See msdyn_geofence Entity [msdyn_geofence_ProcessSession](msdyn_geofence.md#BKMK_msdyn_geofence_ProcessSession) One-To-Many relationship.

### <a name="BKMK_msdyn_geofenceevent_ProcessSession"></a> msdyn_geofenceevent_ProcessSession

**Added by**: Geofence Management Solution

See msdyn_geofenceevent Entity [msdyn_geofenceevent_ProcessSession](msdyn_geofenceevent.md#BKMK_msdyn_geofenceevent_ProcessSession) One-To-Many relationship.

### <a name="BKMK_msdyn_geofencingsettings_ProcessSession"></a> msdyn_geofencingsettings_ProcessSession

**Added by**: Geofence Management Solution

See msdyn_geofencingsettings Entity [msdyn_geofencingsettings_ProcessSession](msdyn_geofencingsettings.md#BKMK_msdyn_geofencingsettings_ProcessSession) One-To-Many relationship.

### <a name="BKMK_msdyn_connector_ProcessSession"></a> msdyn_connector_ProcessSession

**Added by**: Power Connector Solution Solution

See msdyn_connector Entity [msdyn_connector_ProcessSession](msdyn_connector.md#BKMK_msdyn_connector_ProcessSession) One-To-Many relationship.

### <a name="BKMK_theme_ProcessSession"></a> theme_ProcessSession

See theme Entity [theme_ProcessSession](theme.md#BKMK_theme_ProcessSession) One-To-Many relationship.

### <a name="BKMK_usermapping_ProcessSession"></a> usermapping_ProcessSession

See usermapping Entity [usermapping_ProcessSession](usermapping.md#BKMK_usermapping_ProcessSession) One-To-Many relationship.

### <a name="BKMK_knowledgearticle_ProcessSession"></a> knowledgearticle_ProcessSession

See knowledgearticle Entity [knowledgearticle_ProcessSession](knowledgearticle.md#BKMK_knowledgearticle_ProcessSession) One-To-Many relationship.

### <a name="BKMK_position_ProcessSession"></a> position_ProcessSession

See position Entity [position_ProcessSession](position.md#BKMK_position_ProcessSession) One-To-Many relationship.

### <a name="BKMK_KnowledgeBaseRecord_ProcessSession"></a> KnowledgeBaseRecord_ProcessSession

See knowledgebaserecord Entity [KnowledgeBaseRecord_ProcessSession](knowledgebaserecord.md#BKMK_KnowledgeBaseRecord_ProcessSession) One-To-Many relationship.

### <a name="BKMK_SharePointSite_ProcessSessions"></a> SharePointSite_ProcessSessions

See sharepointsite Entity [SharePointSite_ProcessSessions](sharepointsite.md#BKMK_SharePointSite_ProcessSessions) One-To-Many relationship.

### <a name="BKMK_MailMergeTemplate_ProcessSessions"></a> MailMergeTemplate_ProcessSessions

See mailmergetemplate Entity [MailMergeTemplate_ProcessSessions](mailmergetemplate.md#BKMK_MailMergeTemplate_ProcessSessions) One-To-Many relationship.

### <a name="BKMK_Annotation_ProcessSessions"></a> Annotation_ProcessSessions

See annotation Entity [Annotation_ProcessSessions](annotation.md#BKMK_Annotation_ProcessSessions) One-To-Many relationship.

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

### <a name="BKMK_SharePointDocumentLocation_ProcessSessions"></a> SharePointDocumentLocation_ProcessSessions

See sharepointdocumentlocation Entity [SharePointDocumentLocation_ProcessSessions](sharepointdocumentlocation.md#BKMK_SharePointDocumentLocation_ProcessSessions) One-To-Many relationship.

### <a name="BKMK_lk_processsession_startedby"></a> lk_processsession_startedby

See systemuser Entity [lk_processsession_startedby](systemuser.md#BKMK_lk_processsession_startedby) One-To-Many relationship.

### <a name="BKMK_Account_ProcessSessions"></a> Account_ProcessSessions

See account Entity [Account_ProcessSessions](account.md#BKMK_Account_ProcessSessions) One-To-Many relationship.

### <a name="BKMK_PhoneCall_ProcessSessions"></a> PhoneCall_ProcessSessions

See phonecall Entity [PhoneCall_ProcessSessions](phonecall.md#BKMK_PhoneCall_ProcessSessions) One-To-Many relationship.

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

### <a name="BKMK_Subject_ProcessSessions"></a> Subject_ProcessSessions

See subject Entity [Subject_ProcessSessions](subject.md#BKMK_Subject_ProcessSessions) One-To-Many relationship.

### <a name="BKMK_SocialProfile_ProcessSessions"></a> SocialProfile_ProcessSessions

See socialprofile Entity [SocialProfile_ProcessSessions](socialprofile.md#BKMK_SocialProfile_ProcessSessions) One-To-Many relationship.

### See also

[About the Entity Reference](../about-entity-reference.md)<br />
[Programming reference for Dynamics 365 Customer Engagement](../programming-reference.md)<br />
[Web API Reference](/dynamics365/customer-engagement/web-api/about)<br />
<xref href="Microsoft.Dynamics.CRM.processsession?text=processsession EntityType" />

[!INCLUDE[footer-include](../../../../includes/footer-banner.md)]