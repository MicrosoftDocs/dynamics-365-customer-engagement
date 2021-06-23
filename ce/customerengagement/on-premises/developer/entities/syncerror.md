---
title: "SyncError Entity Reference (Dynamics 365 Customer Engagement)| MicrosoftDocs"
description: "Includes schema information and supported messages for the SyncError entity."
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
# SyncError Entity Reference

Failure reason and other detailed information for a record that failed to sync.


## Messages

|Message|Web API Operation|SDK Assembly|
|-|-|-|
|Assign|PATCH [*org URI*]/api/data/v9.0/syncerrors(*syncerrorid*)<br />[Update](/powerapps/developer/common-data-service/webapi/update-delete-entities-using-web-api#basic-update) `ownerid` property.|<xref:Microsoft.Crm.Sdk.Messages.AssignRequest>|
|Create|POST [*org URI*]/api/data/v9.0/syncerrors<br />See [Create](/powerapps/developer/common-data-service/webapi/create-entity-web-api)|<xref:Microsoft.Xrm.Sdk.Messages.CreateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Create*>|
|Delete|DELETE [*org URI*]/api/data/v9.0/syncerrors(*syncerrorid*)<br />See [Delete](/powerapps/developer/common-data-service/webapi/update-delete-entities-using-web-api#basic-delete)|<xref:Microsoft.Xrm.Sdk.Messages.DeleteRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Delete*>|
|Retrieve|GET [*org URI*]/api/data/v9.0/syncerrors(*syncerrorid*)<br />See [Retrieve](/powerapps/developer/common-data-service/webapi/retrieve-entity-using-web-api)|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Retrieve*>|
|RetrieveMultiple|GET [*org URI*]/api/data/v9.0/syncerrors<br />See [Query Data](/powerapps/developer/common-data-service/webapi/query-data-web-api)|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveMultipleRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.RetrieveMultiple*>|
|RetrievePrincipalAccess|<xref href="Microsoft.Dynamics.CRM.RetrievePrincipalAccess?text=RetrievePrincipalAccess Function" />|<xref:Microsoft.Crm.Sdk.Messages.RetrievePrincipalAccessRequest>|
|SetState|PATCH [*org URI*]/api/data/v9.0/syncerrors(*syncerrorid*)<br />[Update](/powerapps/developer/common-data-service/webapi/update-delete-entities-using-web-api#basic-update) `statecode` and `statuscode` properties.|<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|
|Update|PATCH [*org URI*]/api/data/v9.0/syncerrors(*syncerrorid*)<br />See [Update](/powerapps/developer/common-data-service/webapi/update-delete-entities-using-web-api#basic-update)|<xref:Microsoft.Xrm.Sdk.Messages.UpdateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Update*>|

## Entity Properties

|Property|Value|
|--------|-----|
|CollectionSchemaName|SyncErrors|
|DisplayCollectionName|Sync Errors|
|DisplayName|Sync Error|
|EntitySetName|syncerrors|
|IsBPFEntity|False|
|LogicalCollectionName|syncerrors|
|LogicalName|syncerror|
|OwnershipType|UserOwned|
|PrimaryIdAttribute|syncerrorid|
|PrimaryNameAttribute|name|
|SchemaName|SyncError|

<a name="writable-attributes"></a>

## Writable attributes

These attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [Action](#BKMK_Action)
- [ActionData](#BKMK_ActionData)
- [Description](#BKMK_Description)
- [ErrorCode](#BKMK_ErrorCode)
- [ErrorDetail](#BKMK_ErrorDetail)
- [ErrorMessage](#BKMK_ErrorMessage)
- [ErrorTime](#BKMK_ErrorTime)
- [ErrorType](#BKMK_ErrorType)
- [Name](#BKMK_Name)
- [OwnerId](#BKMK_OwnerId)
- [OwnerIdType](#BKMK_OwnerIdType)
- [RegardingObjectId](#BKMK_RegardingObjectId)
- [RegardingObjectIdName](#BKMK_RegardingObjectIdName)
- [RegardingObjectTypeCode](#BKMK_RegardingObjectTypeCode)
- [RequestData](#BKMK_RequestData)
- [StateCode](#BKMK_StateCode)
- [StatusCode](#BKMK_StatusCode)
- [SyncErrorId](#BKMK_SyncErrorId)


### <a name="BKMK_Action"></a> Action

|Property|Value|
|--------|-----|
|Description|Action Name for which sync error has occurred|
|DisplayName|Action|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|IsValidForUpdate|False|
|LogicalName|action|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_ActionData"></a> ActionData

|Property|Value|
|--------|-----|
|Description|Show the action data|
|DisplayName|Action Data|
|FormatName|TextArea|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|IsValidForUpdate|False|
|LogicalName|actiondata|
|MaxLength|10000|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_Description"></a> Description

|Property|Value|
|--------|-----|
|Description|Enter a short description of the sync error.|
|DisplayName|Description|
|Format|TextArea|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|description|
|MaxLength|4000|
|RequiredLevel|None|
|Type|Memo|


### <a name="BKMK_ErrorCode"></a> ErrorCode

|Property|Value|
|--------|-----|
|Description|Displays the error code.|
|DisplayName|Error Code|
|Format|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|IsValidForUpdate|False|
|LogicalName|errorcode|
|MaxLength|100|
|RequiredLevel|None|
|Type|Memo|


### <a name="BKMK_ErrorDetail"></a> ErrorDetail

|Property|Value|
|--------|-----|
|Description|Error description from the exception|
|DisplayName|Error Detail|
|Format|TextArea|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|IsValidForUpdate|False|
|LogicalName|errordetail|
|MaxLength|1073741823|
|RequiredLevel|None|
|Type|Memo|


### <a name="BKMK_ErrorMessage"></a> ErrorMessage

|Property|Value|
|--------|-----|
|Description|Error Message of the exception|
|DisplayName|Error Message|
|FormatName|TextArea|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|IsValidForUpdate|False|
|LogicalName|errormessage|
|MaxLength|1000|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_ErrorTime"></a> ErrorTime

|Property|Value|
|--------|-----|
|DateTimeBehavior|UserLocal|
|Description|Date and time when the upsync request was executed on CRM server|
|DisplayName|Error Time|
|Format|DateAndTime|
|IsValidForForm|True|
|IsValidForRead|True|
|IsValidForUpdate|False|
|LogicalName|errortime|
|RequiredLevel|SystemRequired|
|Type|DateTime|


### <a name="BKMK_ErrorType"></a> ErrorType

|Property|Value|
|--------|-----|
|Description|Select the preferred error type.|
|DisplayName|Error Type|
|IsValidForForm|True|
|IsValidForRead|True|
|IsValidForUpdate|False|
|LogicalName|errortype|
|RequiredLevel|None|
|Type|Picklist|

#### ErrorType Options

|Value|Label|
|-----|-----|
|0|Conflict|
|1|Record not found|
|2|Record already exists|
|3|Others|



### <a name="BKMK_Name"></a> Name

|Property|Value|
|--------|-----|
|Description|Entity name of the record for which sync error has occurred|
|DisplayName|Entity|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|IsValidForUpdate|False|
|LogicalName|name|
|MaxLength|100|
|RequiredLevel|ApplicationRequired|
|Type|String|


### <a name="BKMK_OwnerId"></a> OwnerId

|Property|Value|
|--------|-----|
|Description|Unique identifier of the user or team who owns the sync error.|
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


### <a name="BKMK_RegardingObjectId"></a> RegardingObjectId

|Property|Value|
|--------|-----|
|Description|Choose the record that the sync error relates to.|
|DisplayName|Record|
|IsValidForForm|True|
|IsValidForRead|True|
|IsValidForUpdate|False|
|LogicalName|regardingobjectid|
|RequiredLevel|None|
|Targets|account,activitymimeattachment,activityparty,adminsettingsentity,annotation,appointment,attachment,bookableresource,bookableresourcebooking,bookableresourcebookingexchangesyncidmapping,bookableresourcebookingheader,bookableresourcecategory,bookableresourcecategoryassn,bookableresourcecharacteristic,bookableresourcegroup,bookingstatus,bulkoperation,bulkoperationlog,businessdatalocalizedlabel,businessunit,campaign,campaignactivity,campaignresponse,category,channelaccessprofile,channelaccessprofilerule,channelaccessprofileruleitem,characteristic,childincidentcount,commitment,competitor,competitoraddress,connection,connectionrole,constraintbasedgroup,contact,contract,contractdetail,contracttemplate,customeraddress,customeropportunityrole,discount,discounttype,duplicaterule,duplicaterulecondition,dynamicproperty,dynamicpropertyassociation,dynamicpropertyinstance,dynamicpropertyoptionsetitem,email,emailserverprofile,entitlement,entitlementchannel,entitlemententityallocationtypemapping,entitlementtemplate,entitlementtemplatechannel,equipment,expiredprocess,externalparty,externalpartyitem,fax,feedback,fieldpermission,fieldsecurityprofile,fileattachment,goal,goalrollupquery,holidaywrapper,importmap,incident,incidentresolution,internaladdress,invoice,invoicedetail,kbarticle,kbarticletemplate,knowledgearticle,knowledgearticleincident,knowledgearticleviews,knowledgebaserecord,lead,leadaddress,leadtoopportunitysalesprocess,letter,list,mailbox,mailmergetemplate,metric,msdyn_3dmodel,msdyn_accountpricelist,msdyn_actual,msdyn_agreement,msdyn_agreementbookingdate,msdyn_agreementbookingincident,msdyn_agreementbookingproduct,msdyn_agreementbookingservice,msdyn_agreementbookingservicetask,msdyn_agreementbookingsetup,msdyn_agreementinvoicedate,msdyn_agreementinvoiceproduct,msdyn_agreementinvoicesetup,msdyn_agreementsubstatus,msdyn_analysiscomponent,msdyn_analysisjob,msdyn_analysisresult,msdyn_analysisresultdetail,msdyn_approval,msdyn_batchjob,msdyn_bookableresourceassociation,msdyn_bookingalert,msdyn_bookingalertstatus,msdyn_bookingchange,msdyn_bookingjournal,msdyn_bookingrule,msdyn_bookingsetupmetadata,msdyn_bookingtimestamp,msdyn_bpf_2c5fe86acc8b414b8322ae571000c799,msdyn_bpf_477c16f59170487b8b4dc895c5dcd09b,msdyn_bpf_665e73aa18c247d886bfc50499c73b82,msdyn_bpf_989e9b1857e24af18787d5143b67523b,msdyn_bpf_baa0a411a239410cb8bded8b5fdd88e3,msdyn_bpf_d3d97bac8c294105840e99e37a9d1c39,msdyn_bpf_d8f9dc7f099f44db9d641dd81fbd470d,msdyn_businessclosure,msdyn_callablecontext,msdyn_characteristicreqforteammember,msdyn_clientextension,msdyn_configuration,msdyn_connector,msdyn_contactpricelist,msdyn_contractlineinvoiceschedule,msdyn_contractlinescheduleofvalue,msdyn_customerasset,msdyn_customerassetcategory,msdyn_databaseversion,msdyn_dataexport,msdyn_delegation,msdyn_dimension,msdyn_dimensionfieldname,msdyn_entitlementapplication,msdyn_entityconfiguration,msdyn_estimate,msdyn_estimateline,msdyn_expense,msdyn_expensecategory,msdyn_expensereceipt,msdyn_fact,msdyn_fieldcomputation,msdyn_fieldservicepricelistitem,msdyn_fieldservicesetting,msdyn_fieldserviceslaconfiguration,msdyn_fieldservicesystemjob,msdyn_findworkevent,msdyn_forecastdefinition,msdyn_forecastinstance,msdyn_forecastrecurrence,msdyn_geofence,msdyn_geofenceevent,msdyn_geofencingsettings,msdyn_icebreakersconfig,msdyn_incidenttype,msdyn_incidenttypecharacteristic,msdyn_incidenttypeproduct,msdyn_incidenttypeservice,msdyn_incidenttypeservicetask,msdyn_incidenttypessetup,msdyn_incidenttype_requirementgroup,msdyn_integrationjob,msdyn_integrationjobdetail,msdyn_inventoryadjustment,msdyn_inventoryadjustmentproduct,msdyn_inventoryjournal,msdyn_inventorytransfer,msdyn_invoicefrequency,msdyn_invoicefrequencydetail,msdyn_invoicelinetransaction,msdyn_iotalert,msdyn_iotdevice,msdyn_iotdevicecategory,msdyn_iotdevicecommand,msdyn_iotdevicecommanddefinition,msdyn_iotdevicedatahistory,msdyn_iotdeviceproperty,msdyn_iotdeviceregistrationhistory,msdyn_iotpropertydefinition,msdyn_iotsettings,msdyn_journal,msdyn_journalline,msdyn_mlresultcache,msdyn_notesanalysisconfig,msdyn_opportunitylineresourcecategory,msdyn_opportunitylinetransaction,msdyn_opportunitylinetransactioncategory,msdyn_opportunitylinetransactionclassificatio,msdyn_opportunitypricelist,msdyn_orderinvoicingdate,msdyn_orderinvoicingproduct,msdyn_orderinvoicingsetup,msdyn_orderinvoicingsetupdate,msdyn_orderlineresourcecategory,msdyn_orderlinetransaction,msdyn_orderlinetransactioncategory,msdyn_orderlinetransactionclassification,msdyn_orderpricelist,msdyn_organizationalunit,msdyn_payment,msdyn_paymentdetail,msdyn_paymentmethod,msdyn_paymentterm,msdyn_playbookactivity,msdyn_playbookactivityattribute,msdyn_playbookcategory,msdyn_playbookinstance,msdyn_playbooktemplate,msdyn_postalbum,msdyn_postalcode,msdyn_postconfig,msdyn_postruleconfig,msdyn_priority,msdyn_processnotes,msdyn_productinventory,msdyn_project,msdyn_projectapproval,msdyn_projectparameter,msdyn_projectparameterpricelist,msdyn_projectpricelist,msdyn_projecttask,msdyn_projecttaskdependency,msdyn_projecttaskstatususer,msdyn_projectteam,msdyn_projectteammembersignup,msdyn_projecttransactioncategory,msdyn_purchaseorder,msdyn_purchaseorderbill,msdyn_purchaseorderproduct,msdyn_purchaseorderreceipt,msdyn_purchaseorderreceiptproduct,msdyn_purchaseordersubstatus,msdyn_quotebookingincident,msdyn_quotebookingproduct,msdyn_quotebookingservice,msdyn_quotebookingservicetask,msdyn_quotebookingsetup,msdyn_quoteinvoicingproduct,msdyn_quoteinvoicingsetup,msdyn_quotelineanalyticsbreakdown,msdyn_quotelineinvoiceschedule,msdyn_quotelineresourcecategory,msdyn_quotelinescheduleofvalue,msdyn_quotelinetransaction,msdyn_quotelinetransactioncategory,msdyn_quotelinetransactionclassification,msdyn_quotepricelist,msdyn_relationshipinsightsunifiedconfig,msdyn_requirementcharacteristic,msdyn_requirementgroup,msdyn_requirementorganizationunit,msdyn_requirementrelationship,msdyn_requirementresourcecategory,msdyn_requirementresourcepreference,msdyn_requirementstatus,msdyn_resourceassignment,msdyn_resourceassignmentdetail,msdyn_resourcecategorymarkuppricelevel,msdyn_resourcecategorypricelevel,msdyn_resourcepaytype,msdyn_resourcerequest,msdyn_resourcerequirement,msdyn_resourcerequirementdetail,msdyn_resourceterritory,msdyn_rma,msdyn_rmaproduct,msdyn_rmareceipt,msdyn_rmareceiptproduct,msdyn_rmasubstatus,msdyn_rolecompetencyrequirement,msdyn_roleutilization,msdyn_rtv,msdyn_rtvproduct,msdyn_rtvsubstatus,msdyn_scheduleboardsetting,msdyn_schedulingparameter,msdyn_servicetasktype,msdyn_shipvia,msdyn_siconfig,msdyn_solutionhealthrule,msdyn_solutionhealthruleargument,msdyn_solutionhealthruleset,msdyn_systemuserschedulersetting,msdyn_taxcode,msdyn_taxcodedetail,msdyn_teamscollaboration,msdyn_timeentry,msdyn_timegroup,msdyn_timegroupdetail,msdyn_timeoffcalendar,msdyn_timeoffrequest,msdyn_transactioncategory,msdyn_transactioncategoryclassification,msdyn_transactioncategoryhierarchyelement,msdyn_transactioncategorypricelevel,msdyn_transactionconnection,msdyn_transactionorigin,msdyn_transactiontype,msdyn_uniquenumber,msdyn_untrackedappointment,msdyn_upgraderun,msdyn_upgradestep,msdyn_upgradeversion,msdyn_userworkhistory,msdyn_wallsavedquery,msdyn_wallsavedqueryusersettings,msdyn_warehouse,msdyn_workhourtemplate,msdyn_workorder,msdyn_workordercharacteristic,msdyn_workorderdetailsgenerationqueue,msdyn_workorderincident,msdyn_workorderproduct,msdyn_workorderresourcerestriction,msdyn_workorderservice,msdyn_workorderservicetask,msdyn_workordersubstatus,msdyn_workordertype,msfp_emailtemplate,msfp_question,msfp_questionresponse,msfp_survey,msfp_surveyinvite,msfp_surveyresponse,msfp_unsubscribedrecipient,newprocess,offlinecommanddefinition,opportunity,opportunityclose,opportunityproduct,opportunitysalesprocess,orderclose,organization,phonecall,phonetocaseprocess,position,postfollow,pricelevel,processsession,processstage,processtrigger,product,productassociation,productpricelevel,productsubstitute,publisher,queue,queueitem,quote,quoteclose,quotedetail,ratingmodel,ratingvalue,recurringappointmentmaster,report,reportcategory,resource,resourcegroup,resourcegroupexpansion,resourcespec,role,rollupfield,salesliterature,salesliteratureitem,salesorder,salesorderdetail,salesprocessinstance,savedquery,savedqueryvisualization,service,serviceappointment,sharepointdocumentlocation,sharepointsite,site,sla,slaitem,slakpiinstance,socialactivity,socialprofile,solution,subject,syncerror,systemuser,task,team,teamtemplate,template,territory,topic,topichistory,topicmodel,topicmodelconfiguration,topicmodelexecutionhistory,transactioncurrency,translationprocess,uom,uomschedule,userquery,userqueryvisualization,workflow|
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
|MaxLength|4000|
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


### <a name="BKMK_RequestData"></a> RequestData

|Property|Value|
|--------|-----|
|Description|Request data for the entity that had the sync error.|
|DisplayName|Request Data|
|Format|TextArea|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|requestdata|
|MaxLength|1073741823|
|RequiredLevel|None|
|Type|Memo|


### <a name="BKMK_StateCode"></a> StateCode

|Property|Value|
|--------|-----|
|Description|Shows whether the sync error is active or resolved.|
|DisplayName|State|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|statecode|
|RequiredLevel|SystemRequired|
|Type|State|

#### StateCode Options

|Value|Label|DefaultStatus|InvariantName|
|-----|-----|-------------|-------------|
|0|Active|0|Active|
|1|Resolved|1|Resolved|



### <a name="BKMK_StatusCode"></a> StatusCode

|Property|Value|
|--------|-----|
|Description|Select the sync error status.|
|DisplayName|Status Reason|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|statuscode|
|RequiredLevel|None|
|Type|Status|

#### StatusCode Options

|Value|Label|State|
|-----|-----|-----|
|0|Active|0|
|1|Fixed|1|



### <a name="BKMK_SyncErrorId"></a> SyncErrorId

|Property|Value|
|--------|-----|
|Description|Unique identifier of the sync error.|
|DisplayName|Sync Error Id|
|IsValidForForm|True|
|IsValidForRead|True|
|IsValidForUpdate|False|
|LogicalName|syncerrorid|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|

<a name="read-only-attributes"></a>

## Read-only attributes

These attributes return false for both **IsValidForCreate** or **IsValidForUpdate**. Listed by **SchemaName**.

- [CreatedBy](#BKMK_CreatedBy)
- [CreatedByName](#BKMK_CreatedByName)
- [CreatedByYomiName](#BKMK_CreatedByYomiName)
- [CreatedOn](#BKMK_CreatedOn)
- [CreatedOnBehalfBy](#BKMK_CreatedOnBehalfBy)
- [CreatedOnBehalfByName](#BKMK_CreatedOnBehalfByName)
- [CreatedOnBehalfByYomiName](#BKMK_CreatedOnBehalfByYomiName)
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
- [RegardingObjectIdYomiName](#BKMK_RegardingObjectIdYomiName)
- [VersionNumber](#BKMK_VersionNumber)


### <a name="BKMK_CreatedBy"></a> CreatedBy

|Property|Value|
|--------|-----|
|Description|Unique identifier of the user who created the sync error.|
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
|Description|Date and time when the sync Error was created.|
|DisplayName|Created On|
|Format|DateAndTime|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|createdon|
|RequiredLevel|SystemRequired|
|Type|DateTime|


### <a name="BKMK_CreatedOnBehalfBy"></a> CreatedOnBehalfBy

|Property|Value|
|--------|-----|
|Description|Unique identifier of the delegate user who created the sync error.|
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


### <a name="BKMK_ModifiedBy"></a> ModifiedBy

|Property|Value|
|--------|-----|
|Description|Unique identifier of the user who last modified the sync error.|
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
|Description|Date and time when the sync error was last modified.|
|DisplayName|Modified On|
|Format|DateAndTime|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|modifiedon|
|RequiredLevel|SystemRequired|
|Type|DateTime|


### <a name="BKMK_ModifiedOnBehalfBy"></a> ModifiedOnBehalfBy

|Property|Value|
|--------|-----|
|Description|Unique identifier of the delegate user who last modified the sync error.|
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
|Description|Business unit that owns the sync error.|
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
|Description|Unique identifier of the team who owns the sync error.|
|DisplayName|Owning Team|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|owningteam|
|RequiredLevel|None|
|Targets|team|
|Type|Lookup|


### <a name="BKMK_OwningUser"></a> OwningUser

|Property|Value|
|--------|-----|
|Description|Unique identifier of the user who owns the sync error.|
|DisplayName|Owning User|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|owninguser|
|RequiredLevel|None|
|Targets|systemuser|
|Type|Lookup|


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
|MaxLength|4000|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_VersionNumber"></a> VersionNumber

|Property|Value|
|--------|-----|
|Description|Shows the version number of the sync error.|
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


### <a name="BKMK_SyncError_SyncErrors"></a> SyncError_SyncErrors

Same as syncerror entity [SyncError_SyncErrors](syncerror.md#BKMK_SyncError_SyncErrors) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|syncerror|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|SyncError_SyncErrors|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: Cascade<br />Reparent: Cascade<br />Share: Cascade<br />Unshare: Cascade|

<a name="manytoone"></a>

## Many-To-One Relationships

Each Many-To-One relationship is defined by a corresponding One-To-Many relationship with the related entity. Listed by **SchemaName**.

- [Territory_SyncErrors](#BKMK_Territory_SyncErrors)
- [LeadAddress_SyncErrors](#BKMK_LeadAddress_SyncErrors)
- [Lead_SyncErrors](#BKMK_Lead_SyncErrors)
- [dynamicproperty_SyncErrors](#BKMK_dynamicproperty_SyncErrors)
- [dynamicpropertyassociation_SyncErrors](#BKMK_dynamicpropertyassociation_SyncErrors)
- [dynamicpropertyinstance_SyncErrors](#BKMK_dynamicpropertyinstance_SyncErrors)
- [dynamicpropertyoptionsetitem_SyncErrors](#BKMK_dynamicpropertyoptionsetitem_SyncErrors)
- [PriceLevel_SyncErrors](#BKMK_PriceLevel_SyncErrors)
- [Product_SyncErrors](#BKMK_Product_SyncErrors)
- [ProductAssociation_SyncErrors](#BKMK_ProductAssociation_SyncErrors)
- [ProductPriceLevel_SyncErrors](#BKMK_ProductPriceLevel_SyncErrors)
- [ProductSubstitute_SyncErrors](#BKMK_ProductSubstitute_SyncErrors)
- [UoM_SyncErrors](#BKMK_UoM_SyncErrors)
- [UoMSchedule_SyncErrors](#BKMK_UoMSchedule_SyncErrors)
- [BookableResource_SyncErrors](#BKMK_BookableResource_SyncErrors)
- [BookableResourceBooking_SyncErrors](#BKMK_BookableResourceBooking_SyncErrors)
- [BookableResourceBookingHeader_SyncErrors](#BKMK_BookableResourceBookingHeader_SyncErrors)
- [BookableResourceCategory_SyncErrors](#BKMK_BookableResourceCategory_SyncErrors)
- [BookableResourceCategoryAssn_SyncErrors](#BKMK_BookableResourceCategoryAssn_SyncErrors)
- [BookableResourceCharacteristic_SyncErrors](#BKMK_BookableResourceCharacteristic_SyncErrors)
- [BookableResourceGroup_SyncErrors](#BKMK_BookableResourceGroup_SyncErrors)
- [BookingStatus_SyncErrors](#BKMK_BookingStatus_SyncErrors)
- [Characteristic_SyncErrors](#BKMK_Characteristic_SyncErrors)
- [RatingModel_SyncErrors](#BKMK_RatingModel_SyncErrors)
- [RatingValue_SyncErrors](#BKMK_RatingValue_SyncErrors)
- [BulkOperation_SyncErrors](#BKMK_BulkOperation_SyncErrors)
- [bulkoperationlog_SyncErrors](#BKMK_bulkoperationlog_SyncErrors)
- [Campaign_SyncErrors](#BKMK_Campaign_SyncErrors)
- [CampaignActivity_SyncErrors](#BKMK_CampaignActivity_SyncErrors)
- [CampaignResponse_SyncErrors](#BKMK_CampaignResponse_SyncErrors)
- [List_SyncErrors](#BKMK_List_SyncErrors)
- [msdyn_databaseversion_SyncErrors](#BKMK_msdyn_databaseversion_SyncErrors)
- [msdyn_upgraderun_SyncErrors](#BKMK_msdyn_upgraderun_SyncErrors)
- [msdyn_upgradestep_SyncErrors](#BKMK_msdyn_upgradestep_SyncErrors)
- [msdyn_upgradeversion_SyncErrors](#BKMK_msdyn_upgradeversion_SyncErrors)
- [constraintbasedgroup_SyncErrors](#BKMK_constraintbasedgroup_SyncErrors)
- [Contract_SyncErrors](#BKMK_Contract_SyncErrors)
- [ContractDetail_SyncErrors](#BKMK_ContractDetail_SyncErrors)
- [ContractTemplate_SyncErrors](#BKMK_ContractTemplate_SyncErrors)
- [Entitlement_SyncErrors](#BKMK_Entitlement_SyncErrors)
- [entitlementchannel_SyncErrors](#BKMK_entitlementchannel_SyncErrors)
- [EntitlementTemplate_SyncErrors](#BKMK_EntitlementTemplate_SyncErrors)
- [entitlementtemplatechannel_SyncErrors](#BKMK_entitlementtemplatechannel_SyncErrors)
- [Equipment_SyncErrors](#BKMK_Equipment_SyncErrors)
- [Incident_SyncErrors](#BKMK_Incident_SyncErrors)
- [IncidentResolution_SyncErrors](#BKMK_IncidentResolution_SyncErrors)
- [KnowledgeArticleIncident_SyncErrors](#BKMK_KnowledgeArticleIncident_SyncErrors)
- [PhoneToCaseProcess_SyncErrors](#BKMK_PhoneToCaseProcess_SyncErrors)
- [Resource_SyncErrors](#BKMK_Resource_SyncErrors)
- [ResourceGroup_SyncErrors](#BKMK_ResourceGroup_SyncErrors)
- [resourcespec_SyncErrors](#BKMK_resourcespec_SyncErrors)
- [Service_SyncErrors](#BKMK_Service_SyncErrors)
- [ServiceAppointment_SyncErrors](#BKMK_ServiceAppointment_SyncErrors)
- [Site_SyncErrors](#BKMK_Site_SyncErrors)
- [entitlemententityallocationtypemapping_SyncErrors](#BKMK_entitlemententityallocationtypemapping_SyncErrors)
- [msdyn_callablecontext_SyncErrors](#BKMK_msdyn_callablecontext_SyncErrors)
- [msdyn_playbookactivity_SyncErrors](#BKMK_msdyn_playbookactivity_SyncErrors)
- [msdyn_playbookactivityattribute_SyncErrors](#BKMK_msdyn_playbookactivityattribute_SyncErrors)
- [msdyn_playbookcategory_SyncErrors](#BKMK_msdyn_playbookcategory_SyncErrors)
- [msdyn_playbookinstance_SyncErrors](#BKMK_msdyn_playbookinstance_SyncErrors)
- [msdyn_playbooktemplate_SyncErrors](#BKMK_msdyn_playbooktemplate_SyncErrors)
- [Discount_SyncErrors](#BKMK_Discount_SyncErrors)
- [DiscountType_SyncErrors](#BKMK_DiscountType_SyncErrors)
- [Invoice_SyncErrors](#BKMK_Invoice_SyncErrors)
- [InvoiceDetail_SyncErrors](#BKMK_InvoiceDetail_SyncErrors)
- [LeadToOpportunitySalesProcess_SyncErrors](#BKMK_LeadToOpportunitySalesProcess_SyncErrors)
- [Opportunity_SyncErrors](#BKMK_Opportunity_SyncErrors)
- [OpportunityClose_SyncErrors](#BKMK_OpportunityClose_SyncErrors)
- [OpportunityProduct_SyncErrors](#BKMK_OpportunityProduct_SyncErrors)
- [OpportunitySalesProcess_SyncErrors](#BKMK_OpportunitySalesProcess_SyncErrors)
- [OrderClose_SyncErrors](#BKMK_OrderClose_SyncErrors)
- [Quote_SyncErrors](#BKMK_Quote_SyncErrors)
- [QuoteClose_SyncErrors](#BKMK_QuoteClose_SyncErrors)
- [QuoteDetail_SyncErrors](#BKMK_QuoteDetail_SyncErrors)
- [SalesLiterature_SyncErrors](#BKMK_SalesLiterature_SyncErrors)
- [salesliteratureitem_SyncErrors](#BKMK_salesliteratureitem_SyncErrors)
- [SalesOrder_SyncErrors](#BKMK_SalesOrder_SyncErrors)
- [SalesOrderDetail_SyncErrors](#BKMK_SalesOrderDetail_SyncErrors)
- [Competitor_SyncErrors](#BKMK_Competitor_SyncErrors)
- [adminsettingsentity_SyncErrors](#BKMK_adminsettingsentity_SyncErrors)
- [msdyn_forecastdefinition_SyncErrors](#BKMK_msdyn_forecastdefinition_SyncErrors)
- [msdyn_forecastinstance_SyncErrors](#BKMK_msdyn_forecastinstance_SyncErrors)
- [msdyn_forecastrecurrence_SyncErrors](#BKMK_msdyn_forecastrecurrence_SyncErrors)
- [msdyn_relationshipinsightsunifiedconfig_SyncErrors](#BKMK_msdyn_relationshipinsightsunifiedconfig_SyncErrors)
- [msdyn_siconfig_SyncErrors](#BKMK_msdyn_siconfig_SyncErrors)
- [msdyn_untrackedappointment_SyncErrors](#BKMK_msdyn_untrackedappointment_SyncErrors)
- [msdyn_notesanalysisconfig_SyncErrors](#BKMK_msdyn_notesanalysisconfig_SyncErrors)
- [msdyn_icebreakersconfig_SyncErrors](#BKMK_msdyn_icebreakersconfig_SyncErrors)
- [msdyn_postalbum_SyncErrors](#BKMK_msdyn_postalbum_SyncErrors)
- [msdyn_postconfig_SyncErrors](#BKMK_msdyn_postconfig_SyncErrors)
- [msdyn_postruleconfig_SyncErrors](#BKMK_msdyn_postruleconfig_SyncErrors)
- [msdyn_wallsavedquery_SyncErrors](#BKMK_msdyn_wallsavedquery_SyncErrors)
- [msdyn_wallsavedqueryusersettings_SyncErrors](#BKMK_msdyn_wallsavedqueryusersettings_SyncErrors)
- [msdyn_teamscollaboration_SyncErrors](#BKMK_msdyn_teamscollaboration_SyncErrors)
- [msdyn_actual_SyncErrors](#BKMK_msdyn_actual_SyncErrors)
- [msdyn_bookableresourceassociation_SyncErrors](#BKMK_msdyn_bookableresourceassociation_SyncErrors)
- [msdyn_bookingalert_SyncErrors](#BKMK_msdyn_bookingalert_SyncErrors)
- [msdyn_bookingalertstatus_SyncErrors](#BKMK_msdyn_bookingalertstatus_SyncErrors)
- [msdyn_bookingchange_SyncErrors](#BKMK_msdyn_bookingchange_SyncErrors)
- [msdyn_bookingrule_SyncErrors](#BKMK_msdyn_bookingrule_SyncErrors)
- [msdyn_bookingsetupmetadata_SyncErrors](#BKMK_msdyn_bookingsetupmetadata_SyncErrors)
- [msdyn_businessclosure_SyncErrors](#BKMK_msdyn_businessclosure_SyncErrors)
- [msdyn_clientextension_SyncErrors](#BKMK_msdyn_clientextension_SyncErrors)
- [msdyn_configuration_SyncErrors](#BKMK_msdyn_configuration_SyncErrors)
- [msdyn_organizationalunit_SyncErrors](#BKMK_msdyn_organizationalunit_SyncErrors)
- [msdyn_priority_SyncErrors](#BKMK_msdyn_priority_SyncErrors)
- [msdyn_requirementcharacteristic_SyncErrors](#BKMK_msdyn_requirementcharacteristic_SyncErrors)
- [msdyn_requirementgroup_SyncErrors](#BKMK_msdyn_requirementgroup_SyncErrors)
- [msdyn_requirementorganizationunit_SyncErrors](#BKMK_msdyn_requirementorganizationunit_SyncErrors)
- [msdyn_requirementrelationship_SyncErrors](#BKMK_msdyn_requirementrelationship_SyncErrors)
- [msdyn_requirementresourcecategory_SyncErrors](#BKMK_msdyn_requirementresourcecategory_SyncErrors)
- [msdyn_requirementresourcepreference_SyncErrors](#BKMK_msdyn_requirementresourcepreference_SyncErrors)
- [msdyn_requirementstatus_SyncErrors](#BKMK_msdyn_requirementstatus_SyncErrors)
- [msdyn_resourcerequirement_SyncErrors](#BKMK_msdyn_resourcerequirement_SyncErrors)
- [msdyn_resourcerequirementdetail_SyncErrors](#BKMK_msdyn_resourcerequirementdetail_SyncErrors)
- [msdyn_resourceterritory_SyncErrors](#BKMK_msdyn_resourceterritory_SyncErrors)
- [msdyn_scheduleboardsetting_SyncErrors](#BKMK_msdyn_scheduleboardsetting_SyncErrors)
- [msdyn_schedulingparameter_SyncErrors](#BKMK_msdyn_schedulingparameter_SyncErrors)
- [msdyn_systemuserschedulersetting_SyncErrors](#BKMK_msdyn_systemuserschedulersetting_SyncErrors)
- [msdyn_timegroup_SyncErrors](#BKMK_msdyn_timegroup_SyncErrors)
- [msdyn_timegroupdetail_SyncErrors](#BKMK_msdyn_timegroupdetail_SyncErrors)
- [msdyn_transactionorigin_SyncErrors](#BKMK_msdyn_transactionorigin_SyncErrors)
- [msdyn_workhourtemplate_SyncErrors](#BKMK_msdyn_workhourtemplate_SyncErrors)
- [msdyn_accountpricelist_SyncErrors](#BKMK_msdyn_accountpricelist_SyncErrors)
- [msdyn_approval_SyncErrors](#BKMK_msdyn_approval_SyncErrors)
- [msdyn_batchjob_SyncErrors](#BKMK_msdyn_batchjob_SyncErrors)
- [msdyn_bpf_665e73aa18c247d886bfc50499c73b82_SyncErrors](#BKMK_msdyn_bpf_665e73aa18c247d886bfc50499c73b82_SyncErrors)
- [msdyn_bpf_d8f9dc7f099f44db9d641dd81fbd470d_SyncErrors](#BKMK_msdyn_bpf_d8f9dc7f099f44db9d641dd81fbd470d_SyncErrors)
- [msdyn_characteristicreqforteammember_SyncErrors](#BKMK_msdyn_characteristicreqforteammember_SyncErrors)
- [msdyn_contactpricelist_SyncErrors](#BKMK_msdyn_contactpricelist_SyncErrors)
- [msdyn_contractlineinvoiceschedule_SyncErrors](#BKMK_msdyn_contractlineinvoiceschedule_SyncErrors)
- [msdyn_contractlinescheduleofvalue_SyncErrors](#BKMK_msdyn_contractlinescheduleofvalue_SyncErrors)
- [msdyn_dataexport_SyncErrors](#BKMK_msdyn_dataexport_SyncErrors)
- [msdyn_delegation_SyncErrors](#BKMK_msdyn_delegation_SyncErrors)
- [msdyn_dimension_SyncErrors](#BKMK_msdyn_dimension_SyncErrors)
- [msdyn_dimensionfieldname_SyncErrors](#BKMK_msdyn_dimensionfieldname_SyncErrors)
- [msdyn_estimate_SyncErrors](#BKMK_msdyn_estimate_SyncErrors)
- [msdyn_estimateline_SyncErrors](#BKMK_msdyn_estimateline_SyncErrors)
- [msdyn_expense_SyncErrors](#BKMK_msdyn_expense_SyncErrors)
- [msdyn_expensecategory_SyncErrors](#BKMK_msdyn_expensecategory_SyncErrors)
- [msdyn_expensereceipt_SyncErrors](#BKMK_msdyn_expensereceipt_SyncErrors)
- [msdyn_fact_SyncErrors](#BKMK_msdyn_fact_SyncErrors)
- [msdyn_fieldcomputation_SyncErrors](#BKMK_msdyn_fieldcomputation_SyncErrors)
- [msdyn_findworkevent_SyncErrors](#BKMK_msdyn_findworkevent_SyncErrors)
- [msdyn_integrationjob_SyncErrors](#BKMK_msdyn_integrationjob_SyncErrors)
- [msdyn_integrationjobdetail_SyncErrors](#BKMK_msdyn_integrationjobdetail_SyncErrors)
- [msdyn_invoicefrequency_SyncErrors](#BKMK_msdyn_invoicefrequency_SyncErrors)
- [msdyn_invoicefrequencydetail_SyncErrors](#BKMK_msdyn_invoicefrequencydetail_SyncErrors)
- [msdyn_invoicelinetransaction_SyncErrors](#BKMK_msdyn_invoicelinetransaction_SyncErrors)
- [msdyn_journal_SyncErrors](#BKMK_msdyn_journal_SyncErrors)
- [msdyn_journalline_SyncErrors](#BKMK_msdyn_journalline_SyncErrors)
- [msdyn_mlresultcache_SyncErrors](#BKMK_msdyn_mlresultcache_SyncErrors)
- [msdyn_opportunitylineresourcecategory_SyncErrors](#BKMK_msdyn_opportunitylineresourcecategory_SyncErrors)
- [msdyn_opportunitylinetransaction_SyncErrors](#BKMK_msdyn_opportunitylinetransaction_SyncErrors)
- [msdyn_opportunitylinetransactioncategory_SyncErrors](#BKMK_msdyn_opportunitylinetransactioncategory_SyncErrors)
- [msdyn_opportunitylinetransactionclassificatio_SyncErrors](#BKMK_msdyn_opportunitylinetransactionclassificatio_SyncErrors)
- [msdyn_opportunitypricelist_SyncErrors](#BKMK_msdyn_opportunitypricelist_SyncErrors)
- [msdyn_orderlineresourcecategory_SyncErrors](#BKMK_msdyn_orderlineresourcecategory_SyncErrors)
- [msdyn_orderlinetransaction_SyncErrors](#BKMK_msdyn_orderlinetransaction_SyncErrors)
- [msdyn_orderlinetransactioncategory_SyncErrors](#BKMK_msdyn_orderlinetransactioncategory_SyncErrors)
- [msdyn_orderlinetransactionclassification_SyncErrors](#BKMK_msdyn_orderlinetransactionclassification_SyncErrors)
- [msdyn_orderpricelist_SyncErrors](#BKMK_msdyn_orderpricelist_SyncErrors)
- [msdyn_processnotes_SyncErrors](#BKMK_msdyn_processnotes_SyncErrors)
- [msdyn_project_SyncErrors](#BKMK_msdyn_project_SyncErrors)
- [msdyn_projectapproval_SyncErrors](#BKMK_msdyn_projectapproval_SyncErrors)
- [msdyn_projectparameter_SyncErrors](#BKMK_msdyn_projectparameter_SyncErrors)
- [msdyn_projectparameterpricelist_SyncErrors](#BKMK_msdyn_projectparameterpricelist_SyncErrors)
- [msdyn_projectpricelist_SyncErrors](#BKMK_msdyn_projectpricelist_SyncErrors)
- [msdyn_projecttask_SyncErrors](#BKMK_msdyn_projecttask_SyncErrors)
- [msdyn_projecttaskdependency_SyncErrors](#BKMK_msdyn_projecttaskdependency_SyncErrors)
- [msdyn_projecttaskstatususer_SyncErrors](#BKMK_msdyn_projecttaskstatususer_SyncErrors)
- [msdyn_projectteam_SyncErrors](#BKMK_msdyn_projectteam_SyncErrors)
- [msdyn_projectteammembersignup_SyncErrors](#BKMK_msdyn_projectteammembersignup_SyncErrors)
- [msdyn_projecttransactioncategory_SyncErrors](#BKMK_msdyn_projecttransactioncategory_SyncErrors)
- [msdyn_quotelineanalyticsbreakdown_SyncErrors](#BKMK_msdyn_quotelineanalyticsbreakdown_SyncErrors)
- [msdyn_quotelineinvoiceschedule_SyncErrors](#BKMK_msdyn_quotelineinvoiceschedule_SyncErrors)
- [msdyn_quotelineresourcecategory_SyncErrors](#BKMK_msdyn_quotelineresourcecategory_SyncErrors)
- [msdyn_quotelinescheduleofvalue_SyncErrors](#BKMK_msdyn_quotelinescheduleofvalue_SyncErrors)
- [msdyn_quotelinetransaction_SyncErrors](#BKMK_msdyn_quotelinetransaction_SyncErrors)
- [msdyn_quotelinetransactioncategory_SyncErrors](#BKMK_msdyn_quotelinetransactioncategory_SyncErrors)
- [msdyn_quotelinetransactionclassification_SyncErrors](#BKMK_msdyn_quotelinetransactionclassification_SyncErrors)
- [msdyn_quotepricelist_SyncErrors](#BKMK_msdyn_quotepricelist_SyncErrors)
- [msdyn_resourceassignment_SyncErrors](#BKMK_msdyn_resourceassignment_SyncErrors)
- [msdyn_resourceassignmentdetail_SyncErrors](#BKMK_msdyn_resourceassignmentdetail_SyncErrors)
- [msdyn_resourcecategorymarkuppricelevel_SyncErrors](#BKMK_msdyn_resourcecategorymarkuppricelevel_SyncErrors)
- [msdyn_resourcecategorypricelevel_SyncErrors](#BKMK_msdyn_resourcecategorypricelevel_SyncErrors)
- [msdyn_resourcerequest_SyncErrors](#BKMK_msdyn_resourcerequest_SyncErrors)
- [msdyn_rolecompetencyrequirement_SyncErrors](#BKMK_msdyn_rolecompetencyrequirement_SyncErrors)
- [msdyn_roleutilization_SyncErrors](#BKMK_msdyn_roleutilization_SyncErrors)
- [msdyn_timeentry_SyncErrors](#BKMK_msdyn_timeentry_SyncErrors)
- [msdyn_timeoffcalendar_SyncErrors](#BKMK_msdyn_timeoffcalendar_SyncErrors)
- [msdyn_transactioncategory_SyncErrors](#BKMK_msdyn_transactioncategory_SyncErrors)
- [msdyn_transactioncategoryclassification_SyncErrors](#BKMK_msdyn_transactioncategoryclassification_SyncErrors)
- [msdyn_transactioncategoryhierarchyelement_SyncErrors](#BKMK_msdyn_transactioncategoryhierarchyelement_SyncErrors)
- [msdyn_transactioncategorypricelevel_SyncErrors](#BKMK_msdyn_transactioncategorypricelevel_SyncErrors)
- [msdyn_transactionconnection_SyncErrors](#BKMK_msdyn_transactionconnection_SyncErrors)
- [msdyn_transactiontype_SyncErrors](#BKMK_msdyn_transactiontype_SyncErrors)
- [msdyn_userworkhistory_SyncErrors](#BKMK_msdyn_userworkhistory_SyncErrors)
- [msdyn_agreement_SyncErrors](#BKMK_msdyn_agreement_SyncErrors)
- [msdyn_agreementbookingdate_SyncErrors](#BKMK_msdyn_agreementbookingdate_SyncErrors)
- [msdyn_agreementbookingincident_SyncErrors](#BKMK_msdyn_agreementbookingincident_SyncErrors)
- [msdyn_agreementbookingproduct_SyncErrors](#BKMK_msdyn_agreementbookingproduct_SyncErrors)
- [msdyn_agreementbookingservice_SyncErrors](#BKMK_msdyn_agreementbookingservice_SyncErrors)
- [msdyn_agreementbookingservicetask_SyncErrors](#BKMK_msdyn_agreementbookingservicetask_SyncErrors)
- [msdyn_agreementbookingsetup_SyncErrors](#BKMK_msdyn_agreementbookingsetup_SyncErrors)
- [msdyn_agreementinvoicedate_SyncErrors](#BKMK_msdyn_agreementinvoicedate_SyncErrors)
- [msdyn_agreementinvoiceproduct_SyncErrors](#BKMK_msdyn_agreementinvoiceproduct_SyncErrors)
- [msdyn_agreementinvoicesetup_SyncErrors](#BKMK_msdyn_agreementinvoicesetup_SyncErrors)
- [msdyn_agreementsubstatus_SyncErrors](#BKMK_msdyn_agreementsubstatus_SyncErrors)
- [msdyn_bookingjournal_SyncErrors](#BKMK_msdyn_bookingjournal_SyncErrors)
- [msdyn_bookingtimestamp_SyncErrors](#BKMK_msdyn_bookingtimestamp_SyncErrors)
- [msdyn_bpf_2c5fe86acc8b414b8322ae571000c799_SyncErrors](#BKMK_msdyn_bpf_2c5fe86acc8b414b8322ae571000c799_SyncErrors)
- [msdyn_bpf_989e9b1857e24af18787d5143b67523b_SyncErrors](#BKMK_msdyn_bpf_989e9b1857e24af18787d5143b67523b_SyncErrors)
- [msdyn_bpf_baa0a411a239410cb8bded8b5fdd88e3_SyncErrors](#BKMK_msdyn_bpf_baa0a411a239410cb8bded8b5fdd88e3_SyncErrors)
- [msdyn_bpf_d3d97bac8c294105840e99e37a9d1c39_SyncErrors](#BKMK_msdyn_bpf_d3d97bac8c294105840e99e37a9d1c39_SyncErrors)
- [msdyn_customerasset_SyncErrors](#BKMK_msdyn_customerasset_SyncErrors)
- [msdyn_customerassetcategory_SyncErrors](#BKMK_msdyn_customerassetcategory_SyncErrors)
- [msdyn_entitlementapplication_SyncErrors](#BKMK_msdyn_entitlementapplication_SyncErrors)
- [msdyn_fieldservicepricelistitem_SyncErrors](#BKMK_msdyn_fieldservicepricelistitem_SyncErrors)
- [msdyn_fieldservicesetting_SyncErrors](#BKMK_msdyn_fieldservicesetting_SyncErrors)
- [msdyn_fieldserviceslaconfiguration_SyncErrors](#BKMK_msdyn_fieldserviceslaconfiguration_SyncErrors)
- [msdyn_fieldservicesystemjob_SyncErrors](#BKMK_msdyn_fieldservicesystemjob_SyncErrors)
- [msdyn_incidenttype_SyncErrors](#BKMK_msdyn_incidenttype_SyncErrors)
- [msdyn_incidenttypecharacteristic_SyncErrors](#BKMK_msdyn_incidenttypecharacteristic_SyncErrors)
- [msdyn_incidenttypeproduct_SyncErrors](#BKMK_msdyn_incidenttypeproduct_SyncErrors)
- [msdyn_incidenttypeservice_SyncErrors](#BKMK_msdyn_incidenttypeservice_SyncErrors)
- [msdyn_incidenttypeservicetask_SyncErrors](#BKMK_msdyn_incidenttypeservicetask_SyncErrors)
- [msdyn_incidenttypessetup_SyncErrors](#BKMK_msdyn_incidenttypessetup_SyncErrors)
- [msdyn_incidenttype_requirementgroup_SyncErrors](#BKMK_msdyn_incidenttype_requirementgroup_SyncErrors)
- [msdyn_inventoryadjustment_SyncErrors](#BKMK_msdyn_inventoryadjustment_SyncErrors)
- [msdyn_inventoryadjustmentproduct_SyncErrors](#BKMK_msdyn_inventoryadjustmentproduct_SyncErrors)
- [msdyn_inventoryjournal_SyncErrors](#BKMK_msdyn_inventoryjournal_SyncErrors)
- [msdyn_inventorytransfer_SyncErrors](#BKMK_msdyn_inventorytransfer_SyncErrors)
- [msdyn_orderinvoicingdate_SyncErrors](#BKMK_msdyn_orderinvoicingdate_SyncErrors)
- [msdyn_orderinvoicingproduct_SyncErrors](#BKMK_msdyn_orderinvoicingproduct_SyncErrors)
- [msdyn_orderinvoicingsetup_SyncErrors](#BKMK_msdyn_orderinvoicingsetup_SyncErrors)
- [msdyn_orderinvoicingsetupdate_SyncErrors](#BKMK_msdyn_orderinvoicingsetupdate_SyncErrors)
- [msdyn_payment_SyncErrors](#BKMK_msdyn_payment_SyncErrors)
- [msdyn_paymentdetail_SyncErrors](#BKMK_msdyn_paymentdetail_SyncErrors)
- [msdyn_paymentmethod_SyncErrors](#BKMK_msdyn_paymentmethod_SyncErrors)
- [msdyn_paymentterm_SyncErrors](#BKMK_msdyn_paymentterm_SyncErrors)
- [msdyn_postalcode_SyncErrors](#BKMK_msdyn_postalcode_SyncErrors)
- [msdyn_productinventory_SyncErrors](#BKMK_msdyn_productinventory_SyncErrors)
- [msdyn_purchaseorder_SyncErrors](#BKMK_msdyn_purchaseorder_SyncErrors)
- [msdyn_purchaseorderbill_SyncErrors](#BKMK_msdyn_purchaseorderbill_SyncErrors)
- [msdyn_purchaseorderproduct_SyncErrors](#BKMK_msdyn_purchaseorderproduct_SyncErrors)
- [msdyn_purchaseorderreceipt_SyncErrors](#BKMK_msdyn_purchaseorderreceipt_SyncErrors)
- [msdyn_purchaseorderreceiptproduct_SyncErrors](#BKMK_msdyn_purchaseorderreceiptproduct_SyncErrors)
- [msdyn_purchaseordersubstatus_SyncErrors](#BKMK_msdyn_purchaseordersubstatus_SyncErrors)
- [msdyn_quotebookingincident_SyncErrors](#BKMK_msdyn_quotebookingincident_SyncErrors)
- [msdyn_quotebookingproduct_SyncErrors](#BKMK_msdyn_quotebookingproduct_SyncErrors)
- [msdyn_quotebookingservice_SyncErrors](#BKMK_msdyn_quotebookingservice_SyncErrors)
- [msdyn_quotebookingservicetask_SyncErrors](#BKMK_msdyn_quotebookingservicetask_SyncErrors)
- [msdyn_quotebookingsetup_SyncErrors](#BKMK_msdyn_quotebookingsetup_SyncErrors)
- [msdyn_quoteinvoicingproduct_SyncErrors](#BKMK_msdyn_quoteinvoicingproduct_SyncErrors)
- [msdyn_quoteinvoicingsetup_SyncErrors](#BKMK_msdyn_quoteinvoicingsetup_SyncErrors)
- [msdyn_resourcepaytype_SyncErrors](#BKMK_msdyn_resourcepaytype_SyncErrors)
- [msdyn_rma_SyncErrors](#BKMK_msdyn_rma_SyncErrors)
- [msdyn_rmaproduct_SyncErrors](#BKMK_msdyn_rmaproduct_SyncErrors)
- [msdyn_rmareceipt_SyncErrors](#BKMK_msdyn_rmareceipt_SyncErrors)
- [msdyn_rmareceiptproduct_SyncErrors](#BKMK_msdyn_rmareceiptproduct_SyncErrors)
- [msdyn_rmasubstatus_SyncErrors](#BKMK_msdyn_rmasubstatus_SyncErrors)
- [msdyn_rtv_SyncErrors](#BKMK_msdyn_rtv_SyncErrors)
- [msdyn_rtvproduct_SyncErrors](#BKMK_msdyn_rtvproduct_SyncErrors)
- [msdyn_rtvsubstatus_SyncErrors](#BKMK_msdyn_rtvsubstatus_SyncErrors)
- [msdyn_servicetasktype_SyncErrors](#BKMK_msdyn_servicetasktype_SyncErrors)
- [msdyn_shipvia_SyncErrors](#BKMK_msdyn_shipvia_SyncErrors)
- [msdyn_taxcode_SyncErrors](#BKMK_msdyn_taxcode_SyncErrors)
- [msdyn_taxcodedetail_SyncErrors](#BKMK_msdyn_taxcodedetail_SyncErrors)
- [msdyn_timeoffrequest_SyncErrors](#BKMK_msdyn_timeoffrequest_SyncErrors)
- [msdyn_uniquenumber_SyncErrors](#BKMK_msdyn_uniquenumber_SyncErrors)
- [msdyn_warehouse_SyncErrors](#BKMK_msdyn_warehouse_SyncErrors)
- [msdyn_workorder_SyncErrors](#BKMK_msdyn_workorder_SyncErrors)
- [msdyn_workordercharacteristic_SyncErrors](#BKMK_msdyn_workordercharacteristic_SyncErrors)
- [msdyn_workorderdetailsgenerationqueue_SyncErrors](#BKMK_msdyn_workorderdetailsgenerationqueue_SyncErrors)
- [msdyn_workorderincident_SyncErrors](#BKMK_msdyn_workorderincident_SyncErrors)
- [msdyn_workorderproduct_SyncErrors](#BKMK_msdyn_workorderproduct_SyncErrors)
- [msdyn_workorderresourcerestriction_SyncErrors](#BKMK_msdyn_workorderresourcerestriction_SyncErrors)
- [msdyn_workorderservice_SyncErrors](#BKMK_msdyn_workorderservice_SyncErrors)
- [msdyn_workorderservicetask_SyncErrors](#BKMK_msdyn_workorderservicetask_SyncErrors)
- [msdyn_workordersubstatus_SyncErrors](#BKMK_msdyn_workordersubstatus_SyncErrors)
- [msdyn_workordertype_SyncErrors](#BKMK_msdyn_workordertype_SyncErrors)
- [msdyn_iotalert_SyncErrors](#BKMK_msdyn_iotalert_SyncErrors)
- [msdyn_iotdevice_SyncErrors](#BKMK_msdyn_iotdevice_SyncErrors)
- [msdyn_iotdevicecategory_SyncErrors](#BKMK_msdyn_iotdevicecategory_SyncErrors)
- [msdyn_iotdevicecommand_SyncErrors](#BKMK_msdyn_iotdevicecommand_SyncErrors)
- [msdyn_iotdevicecommanddefinition_SyncErrors](#BKMK_msdyn_iotdevicecommanddefinition_SyncErrors)
- [msdyn_iotdevicedatahistory_SyncErrors](#BKMK_msdyn_iotdevicedatahistory_SyncErrors)
- [msdyn_iotdeviceproperty_SyncErrors](#BKMK_msdyn_iotdeviceproperty_SyncErrors)
- [msdyn_iotdeviceregistrationhistory_SyncErrors](#BKMK_msdyn_iotdeviceregistrationhistory_SyncErrors)
- [msdyn_iotpropertydefinition_SyncErrors](#BKMK_msdyn_iotpropertydefinition_SyncErrors)
- [msdyn_iotsettings_SyncErrors](#BKMK_msdyn_iotsettings_SyncErrors)
- [msdyn_bpf_477c16f59170487b8b4dc895c5dcd09b_SyncErrors](#BKMK_msdyn_bpf_477c16f59170487b8b4dc895c5dcd09b_SyncErrors)
- [msdyn_entityconfiguration_SyncErrors](#BKMK_msdyn_entityconfiguration_SyncErrors)
- [msdyn_geofence_SyncErrors](#BKMK_msdyn_geofence_SyncErrors)
- [msdyn_geofenceevent_SyncErrors](#BKMK_msdyn_geofenceevent_SyncErrors)
- [msdyn_geofencingsettings_SyncErrors](#BKMK_msdyn_geofencingsettings_SyncErrors)
- [msdyn_connector_SyncErrors](#BKMK_msdyn_connector_SyncErrors)
- [KnowledgeBaseRecord_SyncErrors](#BKMK_KnowledgeBaseRecord_SyncErrors)
- [SocialProfile_SyncErrors](#BKMK_SocialProfile_SyncErrors)
- [QueueItem_SyncErrors](#BKMK_QueueItem_SyncErrors)
- [PostFollow_SyncErrors](#BKMK_PostFollow_SyncErrors)
- [SharePointSite_SyncErrors](#BKMK_SharePointSite_SyncErrors)
- [Goal_SyncErrors](#BKMK_Goal_SyncErrors)
- [lk_syncerrorbase_createdby](#BKMK_lk_syncerrorbase_createdby)
- [TranslationProcess_SyncErrors](#BKMK_TranslationProcess_SyncErrors)
- [PhoneCall_SyncErrors](#BKMK_PhoneCall_SyncErrors)
- [RecurringAppointmentMaster_SyncErrors](#BKMK_RecurringAppointmentMaster_SyncErrors)
- [Publisher_SyncErrors](#BKMK_Publisher_SyncErrors)
- [DuplicateRule_SyncErrors](#BKMK_DuplicateRule_SyncErrors)
- [Subject_SyncErrors](#BKMK_Subject_SyncErrors)
- [UserQuery_SyncErrors](#BKMK_UserQuery_SyncErrors)
- [MailMergeTemplate_SyncErrors](#BKMK_MailMergeTemplate_SyncErrors)
- [SyncError_SyncErrors](#BKMK_SyncError_SyncErrors)
- [SavedQuery_SyncErrors](#BKMK_SavedQuery_SyncErrors)
- [lk_syncerrorbase_modifiedby](#BKMK_lk_syncerrorbase_modifiedby)
- [lk_syncerrorbase_modifiedonbehalfby](#BKMK_lk_syncerrorbase_modifiedonbehalfby)
- [TransactionCurrency_SyncErrors](#BKMK_TransactionCurrency_SyncErrors)
- [SocialActivity_SyncErrors](#BKMK_SocialActivity_SyncErrors)
- [CustomerAddress_SyncErrors](#BKMK_CustomerAddress_SyncErrors)
- [Solution_SyncErrors](#BKMK_Solution_SyncErrors)
- [team_SyncError](#BKMK_team_SyncError)
- [TeamTemplate_SyncErrors](#BKMK_TeamTemplate_SyncErrors)
- [ReportCategory_SyncErrors](#BKMK_ReportCategory_SyncErrors)
- [lk_syncerrorbase_createdonbehalfby](#BKMK_lk_syncerrorbase_createdonbehalfby)
- [KbArticle_SyncErrors](#BKMK_KbArticle_SyncErrors)
- [RollupField_SyncErrors](#BKMK_RollupField_SyncErrors)
- [KbArticleTemplate_SyncErrors](#BKMK_KbArticleTemplate_SyncErrors)
- [Account_SyncErrors](#BKMK_Account_SyncErrors)
- [FieldSecurityProfile_SyncErrors](#BKMK_FieldSecurityProfile_SyncErrors)
- [UserQueryVisualization_SyncErrors](#BKMK_UserQueryVisualization_SyncErrors)
- [FieldPermission_SyncErrors](#BKMK_FieldPermission_SyncErrors)
- [DuplicateRuleCondition_SyncErrors](#BKMK_DuplicateRuleCondition_SyncErrors)
- [Team_SyncErrors](#BKMK_Team_SyncErrors)
- [SLAItem_SyncErrors](#BKMK_SLAItem_SyncErrors)
- [KnowledgeArticleViews_SyncErrors](#BKMK_KnowledgeArticleViews_SyncErrors)
- [Appointment_SyncErrors](#BKMK_Appointment_SyncErrors)
- [SystemUser_SyncError](#BKMK_SystemUser_SyncError)
- [Contact_SyncErrors](#BKMK_Contact_SyncErrors)
- [ExpiredProcess_SyncErrors](#BKMK_ExpiredProcess_SyncErrors)
- [Workflow_SyncErrors](#BKMK_Workflow_SyncErrors)
- [NewProcess_SyncErrors](#BKMK_NewProcess_SyncErrors)
- [Feedback_SyncErrors](#BKMK_Feedback_SyncErrors)
- [ActivityParty_SyncErrors](#BKMK_ActivityParty_SyncErrors)
- [Annotation_SyncErrors](#BKMK_Annotation_SyncErrors)
- [Email_SyncErrors](#BKMK_Email_SyncErrors)
- [Organization_SyncErrors](#BKMK_Organization_SyncErrors)
- [ActivityMimeAttachment_SyncErrors](#BKMK_ActivityMimeAttachment_SyncErrors)
- [Task_SyncErrors](#BKMK_Task_SyncErrors)
- [Letter_SyncErrors](#BKMK_Letter_SyncErrors)
- [Template_SyncErrors](#BKMK_Template_SyncErrors)
- [ProcessStage_SyncErrors](#BKMK_ProcessStage_SyncErrors)
- [KnowledgeArticle_SyncErrors](#BKMK_KnowledgeArticle_SyncErrors)
- [Position_SyncErrors](#BKMK_Position_SyncErrors)
- [SharePointDocumentLocation_SyncErrors](#BKMK_SharePointDocumentLocation_SyncErrors)
- [Report_SyncErrors](#BKMK_Report_SyncErrors)
- [Connection_SyncErrors](#BKMK_Connection_SyncErrors)
- [ProcessSession_SyncErrors](#BKMK_ProcessSession_SyncErrors)
- [Category_SyncErrors](#BKMK_Category_SyncErrors)
- [ConnectionRole_SyncErrors](#BKMK_ConnectionRole_SyncErrors)
- [ProcessTrigger_SyncErrors](#BKMK_ProcessTrigger_SyncErrors)
- [Fax_SyncErrors](#BKMK_Fax_SyncErrors)
- [Mailbox_SyncErrors](#BKMK_Mailbox_SyncErrors)
- [BusinessUnit_SyncErrors](#BKMK_BusinessUnit_SyncErrors)
- [Queue_SyncErrors](#BKMK_Queue_SyncErrors)
- [Role_SyncErrors](#BKMK_Role_SyncErrors)
- [BusinessUnit_SyncError](#BKMK_BusinessUnit_SyncError)
- [SystemUser_SyncErrors](#BKMK_SystemUser_SyncErrors)
- [SLAKPIInstance_SyncErrors](#BKMK_SLAKPIInstance_SyncErrors)
- [SLA_SyncErrors](#BKMK_SLA_SyncErrors)
- [SavedQueryVisualization_SyncErrors](#BKMK_SavedQueryVisualization_SyncErrors)
- [GoalRollupQuery_SyncErrors](#BKMK_GoalRollupQuery_SyncErrors)
- [Metric_SyncErrors](#BKMK_Metric_SyncErrors)
- [ImportMap_SyncErrors](#BKMK_ImportMap_SyncErrors)
- [EmailServerProfile_SyncErrors](#BKMK_EmailServerProfile_SyncErrors)


### <a name="BKMK_Territory_SyncErrors"></a> Territory_SyncErrors

**Added by**: Application Common Solution

See territory Entity [Territory_SyncErrors](territory.md#BKMK_Territory_SyncErrors) One-To-Many relationship.

### <a name="BKMK_LeadAddress_SyncErrors"></a> LeadAddress_SyncErrors

**Added by**: Lead Management Solution

See leadaddress Entity [LeadAddress_SyncErrors](leadaddress.md#BKMK_LeadAddress_SyncErrors) One-To-Many relationship.

### <a name="BKMK_Lead_SyncErrors"></a> Lead_SyncErrors

**Added by**: Lead Management Solution

See lead Entity [Lead_SyncErrors](lead.md#BKMK_Lead_SyncErrors) One-To-Many relationship.

### <a name="BKMK_dynamicproperty_SyncErrors"></a> dynamicproperty_SyncErrors

**Added by**: Product Management Solution

See dynamicproperty Entity [dynamicproperty_SyncErrors](dynamicproperty.md#BKMK_dynamicproperty_SyncErrors) One-To-Many relationship.

### <a name="BKMK_dynamicpropertyassociation_SyncErrors"></a> dynamicpropertyassociation_SyncErrors

**Added by**: Product Management Solution

See dynamicpropertyassociation Entity [dynamicpropertyassociation_SyncErrors](dynamicpropertyassociation.md#BKMK_dynamicpropertyassociation_SyncErrors) One-To-Many relationship.

### <a name="BKMK_dynamicpropertyinstance_SyncErrors"></a> dynamicpropertyinstance_SyncErrors

**Added by**: Product Management Solution

See dynamicpropertyinstance Entity [dynamicpropertyinstance_SyncErrors](dynamicpropertyinstance.md#BKMK_dynamicpropertyinstance_SyncErrors) One-To-Many relationship.

### <a name="BKMK_dynamicpropertyoptionsetitem_SyncErrors"></a> dynamicpropertyoptionsetitem_SyncErrors

**Added by**: Product Management Solution

See dynamicpropertyoptionsetitem Entity [dynamicpropertyoptionsetitem_SyncErrors](dynamicpropertyoptionsetitem.md#BKMK_dynamicpropertyoptionsetitem_SyncErrors) One-To-Many relationship.

### <a name="BKMK_PriceLevel_SyncErrors"></a> PriceLevel_SyncErrors

**Added by**: Product Management Solution

See pricelevel Entity [PriceLevel_SyncErrors](pricelevel.md#BKMK_PriceLevel_SyncErrors) One-To-Many relationship.

### <a name="BKMK_Product_SyncErrors"></a> Product_SyncErrors

**Added by**: Product Management Solution

See product Entity [Product_SyncErrors](product.md#BKMK_Product_SyncErrors) One-To-Many relationship.

### <a name="BKMK_ProductAssociation_SyncErrors"></a> ProductAssociation_SyncErrors

**Added by**: Product Management Solution

See productassociation Entity [ProductAssociation_SyncErrors](productassociation.md#BKMK_ProductAssociation_SyncErrors) One-To-Many relationship.

### <a name="BKMK_ProductPriceLevel_SyncErrors"></a> ProductPriceLevel_SyncErrors

**Added by**: Product Management Solution

See productpricelevel Entity [ProductPriceLevel_SyncErrors](productpricelevel.md#BKMK_ProductPriceLevel_SyncErrors) One-To-Many relationship.

### <a name="BKMK_ProductSubstitute_SyncErrors"></a> ProductSubstitute_SyncErrors

**Added by**: Product Management Solution

See productsubstitute Entity [ProductSubstitute_SyncErrors](productsubstitute.md#BKMK_ProductSubstitute_SyncErrors) One-To-Many relationship.

### <a name="BKMK_UoM_SyncErrors"></a> UoM_SyncErrors

**Added by**: Product Management Solution

See uom Entity [UoM_SyncErrors](uom.md#BKMK_UoM_SyncErrors) One-To-Many relationship.

### <a name="BKMK_UoMSchedule_SyncErrors"></a> UoMSchedule_SyncErrors

**Added by**: Product Management Solution

See uomschedule Entity [UoMSchedule_SyncErrors](uomschedule.md#BKMK_UoMSchedule_SyncErrors) One-To-Many relationship.

### <a name="BKMK_BookableResource_SyncErrors"></a> BookableResource_SyncErrors

**Added by**: Scheduling Solution

See bookableresource Entity [BookableResource_SyncErrors](bookableresource.md#BKMK_BookableResource_SyncErrors) One-To-Many relationship.

### <a name="BKMK_BookableResourceBooking_SyncErrors"></a> BookableResourceBooking_SyncErrors

**Added by**: Scheduling Solution

See bookableresourcebooking Entity [BookableResourceBooking_SyncErrors](bookableresourcebooking.md#BKMK_BookableResourceBooking_SyncErrors) One-To-Many relationship.

### <a name="BKMK_BookableResourceBookingHeader_SyncErrors"></a> BookableResourceBookingHeader_SyncErrors

**Added by**: Scheduling Solution

See bookableresourcebookingheader Entity [BookableResourceBookingHeader_SyncErrors](bookableresourcebookingheader.md#BKMK_BookableResourceBookingHeader_SyncErrors) One-To-Many relationship.

### <a name="BKMK_BookableResourceCategory_SyncErrors"></a> BookableResourceCategory_SyncErrors

**Added by**: Scheduling Solution

See bookableresourcecategory Entity [BookableResourceCategory_SyncErrors](bookableresourcecategory.md#BKMK_BookableResourceCategory_SyncErrors) One-To-Many relationship.

### <a name="BKMK_BookableResourceCategoryAssn_SyncErrors"></a> BookableResourceCategoryAssn_SyncErrors

**Added by**: Scheduling Solution

See bookableresourcecategoryassn Entity [BookableResourceCategoryAssn_SyncErrors](bookableresourcecategoryassn.md#BKMK_BookableResourceCategoryAssn_SyncErrors) One-To-Many relationship.

### <a name="BKMK_BookableResourceCharacteristic_SyncErrors"></a> BookableResourceCharacteristic_SyncErrors

**Added by**: Scheduling Solution

See bookableresourcecharacteristic Entity [BookableResourceCharacteristic_SyncErrors](bookableresourcecharacteristic.md#BKMK_BookableResourceCharacteristic_SyncErrors) One-To-Many relationship.

### <a name="BKMK_BookableResourceGroup_SyncErrors"></a> BookableResourceGroup_SyncErrors

**Added by**: Scheduling Solution

See bookableresourcegroup Entity [BookableResourceGroup_SyncErrors](bookableresourcegroup.md#BKMK_BookableResourceGroup_SyncErrors) One-To-Many relationship.

### <a name="BKMK_BookingStatus_SyncErrors"></a> BookingStatus_SyncErrors

**Added by**: Scheduling Solution

See bookingstatus Entity [BookingStatus_SyncErrors](bookingstatus.md#BKMK_BookingStatus_SyncErrors) One-To-Many relationship.

### <a name="BKMK_Characteristic_SyncErrors"></a> Characteristic_SyncErrors

**Added by**: Scheduling Solution

See characteristic Entity [Characteristic_SyncErrors](characteristic.md#BKMK_Characteristic_SyncErrors) One-To-Many relationship.

### <a name="BKMK_RatingModel_SyncErrors"></a> RatingModel_SyncErrors

**Added by**: Scheduling Solution

See ratingmodel Entity [RatingModel_SyncErrors](ratingmodel.md#BKMK_RatingModel_SyncErrors) One-To-Many relationship.

### <a name="BKMK_RatingValue_SyncErrors"></a> RatingValue_SyncErrors

**Added by**: Scheduling Solution

See ratingvalue Entity [RatingValue_SyncErrors](ratingvalue.md#BKMK_RatingValue_SyncErrors) One-To-Many relationship.

### <a name="BKMK_BulkOperation_SyncErrors"></a> BulkOperation_SyncErrors

**Added by**: Marketing Solution

See bulkoperation Entity [BulkOperation_SyncErrors](bulkoperation.md#BKMK_BulkOperation_SyncErrors) One-To-Many relationship.

### <a name="BKMK_bulkoperationlog_SyncErrors"></a> bulkoperationlog_SyncErrors

**Added by**: Marketing Solution

See bulkoperationlog Entity [bulkoperationlog_SyncErrors](bulkoperationlog.md#BKMK_bulkoperationlog_SyncErrors) One-To-Many relationship.

### <a name="BKMK_Campaign_SyncErrors"></a> Campaign_SyncErrors

**Added by**: Marketing Solution

See campaign Entity [Campaign_SyncErrors](campaign.md#BKMK_Campaign_SyncErrors) One-To-Many relationship.

### <a name="BKMK_CampaignActivity_SyncErrors"></a> CampaignActivity_SyncErrors

**Added by**: Marketing Solution

See campaignactivity Entity [CampaignActivity_SyncErrors](campaignactivity.md#BKMK_CampaignActivity_SyncErrors) One-To-Many relationship.

### <a name="BKMK_CampaignResponse_SyncErrors"></a> CampaignResponse_SyncErrors

**Added by**: Marketing Solution

See campaignresponse Entity [CampaignResponse_SyncErrors](campaignresponse.md#BKMK_CampaignResponse_SyncErrors) One-To-Many relationship.

### <a name="BKMK_List_SyncErrors"></a> List_SyncErrors

**Added by**: Marketing Solution

See list Entity [List_SyncErrors](list.md#BKMK_List_SyncErrors) One-To-Many relationship.

### <a name="BKMK_msdyn_databaseversion_SyncErrors"></a> msdyn_databaseversion_SyncErrors

**Added by**: Solution Upgrade Infrastructure Solution

See msdyn_databaseversion Entity [msdyn_databaseversion_SyncErrors](msdyn_databaseversion.md#BKMK_msdyn_databaseversion_SyncErrors) One-To-Many relationship.

### <a name="BKMK_msdyn_upgraderun_SyncErrors"></a> msdyn_upgraderun_SyncErrors

**Added by**: Solution Upgrade Infrastructure Solution

See msdyn_upgraderun Entity [msdyn_upgraderun_SyncErrors](msdyn_upgraderun.md#BKMK_msdyn_upgraderun_SyncErrors) One-To-Many relationship.

### <a name="BKMK_msdyn_upgradestep_SyncErrors"></a> msdyn_upgradestep_SyncErrors

**Added by**: Solution Upgrade Infrastructure Solution

See msdyn_upgradestep Entity [msdyn_upgradestep_SyncErrors](msdyn_upgradestep.md#BKMK_msdyn_upgradestep_SyncErrors) One-To-Many relationship.

### <a name="BKMK_msdyn_upgradeversion_SyncErrors"></a> msdyn_upgradeversion_SyncErrors

**Added by**: Solution Upgrade Infrastructure Solution

See msdyn_upgradeversion Entity [msdyn_upgradeversion_SyncErrors](msdyn_upgradeversion.md#BKMK_msdyn_upgradeversion_SyncErrors) One-To-Many relationship.

### <a name="BKMK_constraintbasedgroup_SyncErrors"></a> constraintbasedgroup_SyncErrors

**Added by**: Service Solution

See constraintbasedgroup Entity [constraintbasedgroup_SyncErrors](constraintbasedgroup.md#BKMK_constraintbasedgroup_SyncErrors) One-To-Many relationship.

### <a name="BKMK_Contract_SyncErrors"></a> Contract_SyncErrors

**Added by**: Service Solution

See contract Entity [Contract_SyncErrors](contract.md#BKMK_Contract_SyncErrors) One-To-Many relationship.

### <a name="BKMK_ContractDetail_SyncErrors"></a> ContractDetail_SyncErrors

**Added by**: Service Solution

See contractdetail Entity [ContractDetail_SyncErrors](contractdetail.md#BKMK_ContractDetail_SyncErrors) One-To-Many relationship.

### <a name="BKMK_ContractTemplate_SyncErrors"></a> ContractTemplate_SyncErrors

**Added by**: Service Solution

See contracttemplate Entity [ContractTemplate_SyncErrors](contracttemplate.md#BKMK_ContractTemplate_SyncErrors) One-To-Many relationship.

### <a name="BKMK_Entitlement_SyncErrors"></a> Entitlement_SyncErrors

**Added by**: Service Solution

See entitlement Entity [Entitlement_SyncErrors](entitlement.md#BKMK_Entitlement_SyncErrors) One-To-Many relationship.

### <a name="BKMK_entitlementchannel_SyncErrors"></a> entitlementchannel_SyncErrors

**Added by**: Service Solution

See entitlementchannel Entity [entitlementchannel_SyncErrors](entitlementchannel.md#BKMK_entitlementchannel_SyncErrors) One-To-Many relationship.

### <a name="BKMK_EntitlementTemplate_SyncErrors"></a> EntitlementTemplate_SyncErrors

**Added by**: Service Solution

See entitlementtemplate Entity [EntitlementTemplate_SyncErrors](entitlementtemplate.md#BKMK_EntitlementTemplate_SyncErrors) One-To-Many relationship.

### <a name="BKMK_entitlementtemplatechannel_SyncErrors"></a> entitlementtemplatechannel_SyncErrors

**Added by**: Service Solution

See entitlementtemplatechannel Entity [entitlementtemplatechannel_SyncErrors](entitlementtemplatechannel.md#BKMK_entitlementtemplatechannel_SyncErrors) One-To-Many relationship.

### <a name="BKMK_Equipment_SyncErrors"></a> Equipment_SyncErrors

**Added by**: Service Solution

See equipment Entity [Equipment_SyncErrors](equipment.md#BKMK_Equipment_SyncErrors) One-To-Many relationship.

### <a name="BKMK_Incident_SyncErrors"></a> Incident_SyncErrors

**Added by**: Service Solution

See incident Entity [Incident_SyncErrors](incident.md#BKMK_Incident_SyncErrors) One-To-Many relationship.

### <a name="BKMK_IncidentResolution_SyncErrors"></a> IncidentResolution_SyncErrors

**Added by**: Service Solution

See incidentresolution Entity [IncidentResolution_SyncErrors](incidentresolution.md#BKMK_IncidentResolution_SyncErrors) One-To-Many relationship.

### <a name="BKMK_KnowledgeArticleIncident_SyncErrors"></a> KnowledgeArticleIncident_SyncErrors

**Added by**: Service Solution

See knowledgearticleincident Entity [KnowledgeArticleIncident_SyncErrors](knowledgearticleincident.md#BKMK_KnowledgeArticleIncident_SyncErrors) One-To-Many relationship.

### <a name="BKMK_PhoneToCaseProcess_SyncErrors"></a> PhoneToCaseProcess_SyncErrors

**Added by**: Service Solution

See phonetocaseprocess Entity [PhoneToCaseProcess_SyncErrors](phonetocaseprocess.md#BKMK_PhoneToCaseProcess_SyncErrors) One-To-Many relationship.

### <a name="BKMK_Resource_SyncErrors"></a> Resource_SyncErrors

**Added by**: Service Solution

See resource Entity [Resource_SyncErrors](resource.md#BKMK_Resource_SyncErrors) One-To-Many relationship.

### <a name="BKMK_ResourceGroup_SyncErrors"></a> ResourceGroup_SyncErrors

**Added by**: Service Solution

See resourcegroup Entity [ResourceGroup_SyncErrors](resourcegroup.md#BKMK_ResourceGroup_SyncErrors) One-To-Many relationship.

### <a name="BKMK_resourcespec_SyncErrors"></a> resourcespec_SyncErrors

**Added by**: Service Solution

See resourcespec Entity [resourcespec_SyncErrors](resourcespec.md#BKMK_resourcespec_SyncErrors) One-To-Many relationship.

### <a name="BKMK_Service_SyncErrors"></a> Service_SyncErrors

**Added by**: Service Solution

See service Entity [Service_SyncErrors](service.md#BKMK_Service_SyncErrors) One-To-Many relationship.

### <a name="BKMK_ServiceAppointment_SyncErrors"></a> ServiceAppointment_SyncErrors

**Added by**: Service Solution

See serviceappointment Entity [ServiceAppointment_SyncErrors](serviceappointment.md#BKMK_ServiceAppointment_SyncErrors) One-To-Many relationship.

### <a name="BKMK_Site_SyncErrors"></a> Site_SyncErrors

**Added by**: Service Solution

See site Entity [Site_SyncErrors](site.md#BKMK_Site_SyncErrors) One-To-Many relationship.

### <a name="BKMK_entitlemententityallocationtypemapping_SyncErrors"></a> entitlemententityallocationtypemapping_SyncErrors

**Added by**: Service Patch Solution

See entitlemententityallocationtypemapping Entity [entitlemententityallocationtypemapping_SyncErrors](entitlemententityallocationtypemapping.md#BKMK_entitlemententityallocationtypemapping_SyncErrors) One-To-Many relationship.

### <a name="BKMK_msdyn_callablecontext_SyncErrors"></a> msdyn_callablecontext_SyncErrors

**Added by**: Playbook Solution

See msdyn_callablecontext Entity [msdyn_callablecontext_SyncErrors](msdyn_callablecontext.md#BKMK_msdyn_callablecontext_SyncErrors) One-To-Many relationship.

### <a name="BKMK_msdyn_playbookactivity_SyncErrors"></a> msdyn_playbookactivity_SyncErrors

**Added by**: Playbook Solution

See msdyn_playbookactivity Entity [msdyn_playbookactivity_SyncErrors](msdyn_playbookactivity.md#BKMK_msdyn_playbookactivity_SyncErrors) One-To-Many relationship.

### <a name="BKMK_msdyn_playbookactivityattribute_SyncErrors"></a> msdyn_playbookactivityattribute_SyncErrors

**Added by**: Playbook Solution

See msdyn_playbookactivityattribute Entity [msdyn_playbookactivityattribute_SyncErrors](msdyn_playbookactivityattribute.md#BKMK_msdyn_playbookactivityattribute_SyncErrors) One-To-Many relationship.

### <a name="BKMK_msdyn_playbookcategory_SyncErrors"></a> msdyn_playbookcategory_SyncErrors

**Added by**: Playbook Solution

See msdyn_playbookcategory Entity [msdyn_playbookcategory_SyncErrors](msdyn_playbookcategory.md#BKMK_msdyn_playbookcategory_SyncErrors) One-To-Many relationship.

### <a name="BKMK_msdyn_playbookinstance_SyncErrors"></a> msdyn_playbookinstance_SyncErrors

**Added by**: Playbook Solution

See msdyn_playbookinstance Entity [msdyn_playbookinstance_SyncErrors](msdyn_playbookinstance.md#BKMK_msdyn_playbookinstance_SyncErrors) One-To-Many relationship.

### <a name="BKMK_msdyn_playbooktemplate_SyncErrors"></a> msdyn_playbooktemplate_SyncErrors

**Added by**: Playbook Solution

See msdyn_playbooktemplate Entity [msdyn_playbooktemplate_SyncErrors](msdyn_playbooktemplate.md#BKMK_msdyn_playbooktemplate_SyncErrors) One-To-Many relationship.

### <a name="BKMK_Discount_SyncErrors"></a> Discount_SyncErrors

**Added by**: Sales Solution

See discount Entity [Discount_SyncErrors](discount.md#BKMK_Discount_SyncErrors) One-To-Many relationship.

### <a name="BKMK_DiscountType_SyncErrors"></a> DiscountType_SyncErrors

**Added by**: Sales Solution

See discounttype Entity [DiscountType_SyncErrors](discounttype.md#BKMK_DiscountType_SyncErrors) One-To-Many relationship.

### <a name="BKMK_Invoice_SyncErrors"></a> Invoice_SyncErrors

**Added by**: Sales Solution

See invoice Entity [Invoice_SyncErrors](invoice.md#BKMK_Invoice_SyncErrors) One-To-Many relationship.

### <a name="BKMK_InvoiceDetail_SyncErrors"></a> InvoiceDetail_SyncErrors

**Added by**: Sales Solution

See invoicedetail Entity [InvoiceDetail_SyncErrors](invoicedetail.md#BKMK_InvoiceDetail_SyncErrors) One-To-Many relationship.

### <a name="BKMK_LeadToOpportunitySalesProcess_SyncErrors"></a> LeadToOpportunitySalesProcess_SyncErrors

**Added by**: Sales Solution

See leadtoopportunitysalesprocess Entity [LeadToOpportunitySalesProcess_SyncErrors](leadtoopportunitysalesprocess.md#BKMK_LeadToOpportunitySalesProcess_SyncErrors) One-To-Many relationship.

### <a name="BKMK_Opportunity_SyncErrors"></a> Opportunity_SyncErrors

**Added by**: Sales Solution

See opportunity Entity [Opportunity_SyncErrors](opportunity.md#BKMK_Opportunity_SyncErrors) One-To-Many relationship.

### <a name="BKMK_OpportunityClose_SyncErrors"></a> OpportunityClose_SyncErrors

**Added by**: Sales Solution

See opportunityclose Entity [OpportunityClose_SyncErrors](opportunityclose.md#BKMK_OpportunityClose_SyncErrors) One-To-Many relationship.

### <a name="BKMK_OpportunityProduct_SyncErrors"></a> OpportunityProduct_SyncErrors

**Added by**: Sales Solution

See opportunityproduct Entity [OpportunityProduct_SyncErrors](opportunityproduct.md#BKMK_OpportunityProduct_SyncErrors) One-To-Many relationship.

### <a name="BKMK_OpportunitySalesProcess_SyncErrors"></a> OpportunitySalesProcess_SyncErrors

**Added by**: Sales Solution

See opportunitysalesprocess Entity [OpportunitySalesProcess_SyncErrors](opportunitysalesprocess.md#BKMK_OpportunitySalesProcess_SyncErrors) One-To-Many relationship.

### <a name="BKMK_OrderClose_SyncErrors"></a> OrderClose_SyncErrors

**Added by**: Sales Solution

See orderclose Entity [OrderClose_SyncErrors](orderclose.md#BKMK_OrderClose_SyncErrors) One-To-Many relationship.

### <a name="BKMK_Quote_SyncErrors"></a> Quote_SyncErrors

**Added by**: Sales Solution

See quote Entity [Quote_SyncErrors](quote.md#BKMK_Quote_SyncErrors) One-To-Many relationship.

### <a name="BKMK_QuoteClose_SyncErrors"></a> QuoteClose_SyncErrors

**Added by**: Sales Solution

See quoteclose Entity [QuoteClose_SyncErrors](quoteclose.md#BKMK_QuoteClose_SyncErrors) One-To-Many relationship.

### <a name="BKMK_QuoteDetail_SyncErrors"></a> QuoteDetail_SyncErrors

**Added by**: Sales Solution

See quotedetail Entity [QuoteDetail_SyncErrors](quotedetail.md#BKMK_QuoteDetail_SyncErrors) One-To-Many relationship.

### <a name="BKMK_SalesLiterature_SyncErrors"></a> SalesLiterature_SyncErrors

**Added by**: Sales Solution

See salesliterature Entity [SalesLiterature_SyncErrors](salesliterature.md#BKMK_SalesLiterature_SyncErrors) One-To-Many relationship.

### <a name="BKMK_salesliteratureitem_SyncErrors"></a> salesliteratureitem_SyncErrors

**Added by**: Sales Solution

See salesliteratureitem Entity [salesliteratureitem_SyncErrors](salesliteratureitem.md#BKMK_salesliteratureitem_SyncErrors) One-To-Many relationship.

### <a name="BKMK_SalesOrder_SyncErrors"></a> SalesOrder_SyncErrors

**Added by**: Sales Solution

See salesorder Entity [SalesOrder_SyncErrors](salesorder.md#BKMK_SalesOrder_SyncErrors) One-To-Many relationship.

### <a name="BKMK_SalesOrderDetail_SyncErrors"></a> SalesOrderDetail_SyncErrors

**Added by**: Sales Solution

See salesorderdetail Entity [SalesOrderDetail_SyncErrors](salesorderdetail.md#BKMK_SalesOrderDetail_SyncErrors) One-To-Many relationship.

### <a name="BKMK_Competitor_SyncErrors"></a> Competitor_SyncErrors

**Added by**: Sales Solution

See competitor Entity [Competitor_SyncErrors](competitor.md#BKMK_Competitor_SyncErrors) One-To-Many relationship.

### <a name="BKMK_adminsettingsentity_SyncErrors"></a> adminsettingsentity_SyncErrors

**Added by**: Sales Patch Solution

See adminsettingsentity Entity [adminsettingsentity_SyncErrors](adminsettingsentity.md#BKMK_adminsettingsentity_SyncErrors) One-To-Many relationship.

### <a name="BKMK_msdyn_forecastdefinition_SyncErrors"></a> msdyn_forecastdefinition_SyncErrors

**Added by**: Forecasting Solution

See msdyn_forecastdefinition Entity [msdyn_forecastdefinition_SyncErrors](msdyn_forecastdefinition.md#BKMK_msdyn_forecastdefinition_SyncErrors) One-To-Many relationship.

### <a name="BKMK_msdyn_forecastinstance_SyncErrors"></a> msdyn_forecastinstance_SyncErrors

**Added by**: Forecasting Solution

See msdyn_forecastinstance Entity [msdyn_forecastinstance_SyncErrors](msdyn_forecastinstance.md#BKMK_msdyn_forecastinstance_SyncErrors) One-To-Many relationship.

### <a name="BKMK_msdyn_forecastrecurrence_SyncErrors"></a> msdyn_forecastrecurrence_SyncErrors

**Added by**: Forecasting Solution

See msdyn_forecastrecurrence Entity [msdyn_forecastrecurrence_SyncErrors](msdyn_forecastrecurrence.md#BKMK_msdyn_forecastrecurrence_SyncErrors) One-To-Many relationship.

### <a name="BKMK_msdyn_relationshipinsightsunifiedconfig_SyncErrors"></a> msdyn_relationshipinsightsunifiedconfig_SyncErrors

**Added by**: SI Common Solution

See msdyn_relationshipinsightsunifiedconfig Entity [msdyn_relationshipinsightsunifiedconfig_SyncErrors](msdyn_relationshipinsightsunifiedconfig.md#BKMK_msdyn_relationshipinsightsunifiedconfig_SyncErrors) One-To-Many relationship.

### <a name="BKMK_msdyn_siconfig_SyncErrors"></a> msdyn_siconfig_SyncErrors

**Added by**: SI Common Solution

See msdyn_siconfig Entity [msdyn_siconfig_SyncErrors](msdyn_siconfig.md#BKMK_msdyn_siconfig_SyncErrors) One-To-Many relationship.

### <a name="BKMK_msdyn_untrackedappointment_SyncErrors"></a> msdyn_untrackedappointment_SyncErrors

**Added by**: AutoDataCapture Solution

See msdyn_untrackedappointment Entity [msdyn_untrackedappointment_SyncErrors](msdyn_untrackedappointment.md#BKMK_msdyn_untrackedappointment_SyncErrors) One-To-Many relationship.

### <a name="BKMK_msdyn_notesanalysisconfig_SyncErrors"></a> msdyn_notesanalysisconfig_SyncErrors

**Added by**: Notesanalysis Solution

See msdyn_notesanalysisconfig Entity [msdyn_notesanalysisconfig_SyncErrors](msdyn_notesanalysisconfig.md#BKMK_msdyn_notesanalysisconfig_SyncErrors) One-To-Many relationship.

### <a name="BKMK_msdyn_icebreakersconfig_SyncErrors"></a> msdyn_icebreakersconfig_SyncErrors

**Added by**: Talking points Solution

See msdyn_icebreakersconfig Entity [msdyn_icebreakersconfig_SyncErrors](msdyn_icebreakersconfig.md#BKMK_msdyn_icebreakersconfig_SyncErrors) One-To-Many relationship.

### <a name="BKMK_msdyn_postalbum_SyncErrors"></a> msdyn_postalbum_SyncErrors

**Added by**: Activity Feeds Solution

See msdyn_postalbum Entity [msdyn_postalbum_SyncErrors](msdyn_postalbum.md#BKMK_msdyn_postalbum_SyncErrors) One-To-Many relationship.

### <a name="BKMK_msdyn_postconfig_SyncErrors"></a> msdyn_postconfig_SyncErrors

**Added by**: Activity Feeds Solution

See msdyn_postconfig Entity [msdyn_postconfig_SyncErrors](msdyn_postconfig.md#BKMK_msdyn_postconfig_SyncErrors) One-To-Many relationship.

### <a name="BKMK_msdyn_postruleconfig_SyncErrors"></a> msdyn_postruleconfig_SyncErrors

**Added by**: Activity Feeds Solution

See msdyn_postruleconfig Entity [msdyn_postruleconfig_SyncErrors](msdyn_postruleconfig.md#BKMK_msdyn_postruleconfig_SyncErrors) One-To-Many relationship.

### <a name="BKMK_msdyn_wallsavedquery_SyncErrors"></a> msdyn_wallsavedquery_SyncErrors

**Added by**: Activity Feeds Solution

See msdyn_wallsavedquery Entity [msdyn_wallsavedquery_SyncErrors](msdyn_wallsavedquery.md#BKMK_msdyn_wallsavedquery_SyncErrors) One-To-Many relationship.

### <a name="BKMK_msdyn_wallsavedqueryusersettings_SyncErrors"></a> msdyn_wallsavedqueryusersettings_SyncErrors

**Added by**: Activity Feeds Solution

See msdyn_wallsavedqueryusersettings Entity [msdyn_wallsavedqueryusersettings_SyncErrors](msdyn_wallsavedqueryusersettings.md#BKMK_msdyn_wallsavedqueryusersettings_SyncErrors) One-To-Many relationship.

### <a name="BKMK_msdyn_teamscollaboration_SyncErrors"></a> msdyn_teamscollaboration_SyncErrors

**Added by**: This solution contains Office Productivity implementation Solution

See msdyn_teamscollaboration Entity [msdyn_teamscollaboration_SyncErrors](msdyn_teamscollaboration.md#BKMK_msdyn_teamscollaboration_SyncErrors) One-To-Many relationship.

### <a name="BKMK_msdyn_actual_SyncErrors"></a> msdyn_actual_SyncErrors

**Added by**: Universal Resource Scheduling Solution

See msdyn_actual Entity [msdyn_actual_SyncErrors](msdyn_actual.md#BKMK_msdyn_actual_SyncErrors) One-To-Many relationship.

### <a name="BKMK_msdyn_bookableresourceassociation_SyncErrors"></a> msdyn_bookableresourceassociation_SyncErrors

**Added by**: Universal Resource Scheduling Solution

See msdyn_bookableresourceassociation Entity [msdyn_bookableresourceassociation_SyncErrors](msdyn_bookableresourceassociation.md#BKMK_msdyn_bookableresourceassociation_SyncErrors) One-To-Many relationship.

### <a name="BKMK_msdyn_bookingalert_SyncErrors"></a> msdyn_bookingalert_SyncErrors

**Added by**: Active Solution Solution

See msdyn_bookingalert Entity [msdyn_bookingalert_SyncErrors](msdyn_bookingalert.md#BKMK_msdyn_bookingalert_SyncErrors) One-To-Many relationship.

### <a name="BKMK_msdyn_bookingalertstatus_SyncErrors"></a> msdyn_bookingalertstatus_SyncErrors

**Added by**: Universal Resource Scheduling Solution

See msdyn_bookingalertstatus Entity [msdyn_bookingalertstatus_SyncErrors](msdyn_bookingalertstatus.md#BKMK_msdyn_bookingalertstatus_SyncErrors) One-To-Many relationship.

### <a name="BKMK_msdyn_bookingchange_SyncErrors"></a> msdyn_bookingchange_SyncErrors

**Added by**: Universal Resource Scheduling Solution

See msdyn_bookingchange Entity [msdyn_bookingchange_SyncErrors](msdyn_bookingchange.md#BKMK_msdyn_bookingchange_SyncErrors) One-To-Many relationship.

### <a name="BKMK_msdyn_bookingrule_SyncErrors"></a> msdyn_bookingrule_SyncErrors

**Added by**: Universal Resource Scheduling Solution

See msdyn_bookingrule Entity [msdyn_bookingrule_SyncErrors](msdyn_bookingrule.md#BKMK_msdyn_bookingrule_SyncErrors) One-To-Many relationship.

### <a name="BKMK_msdyn_bookingsetupmetadata_SyncErrors"></a> msdyn_bookingsetupmetadata_SyncErrors

**Added by**: Universal Resource Scheduling Solution

See msdyn_bookingsetupmetadata Entity [msdyn_bookingsetupmetadata_SyncErrors](msdyn_bookingsetupmetadata.md#BKMK_msdyn_bookingsetupmetadata_SyncErrors) One-To-Many relationship.

### <a name="BKMK_msdyn_businessclosure_SyncErrors"></a> msdyn_businessclosure_SyncErrors

**Added by**: Universal Resource Scheduling Solution

See msdyn_businessclosure Entity [msdyn_businessclosure_SyncErrors](msdyn_businessclosure.md#BKMK_msdyn_businessclosure_SyncErrors) One-To-Many relationship.

### <a name="BKMK_msdyn_clientextension_SyncErrors"></a> msdyn_clientextension_SyncErrors

**Added by**: Universal Resource Scheduling Solution

See msdyn_clientextension Entity [msdyn_clientextension_SyncErrors](msdyn_clientextension.md#BKMK_msdyn_clientextension_SyncErrors) One-To-Many relationship.

### <a name="BKMK_msdyn_configuration_SyncErrors"></a> msdyn_configuration_SyncErrors

**Added by**: Universal Resource Scheduling Solution

See msdyn_configuration Entity [msdyn_configuration_SyncErrors](msdyn_configuration.md#BKMK_msdyn_configuration_SyncErrors) One-To-Many relationship.

### <a name="BKMK_msdyn_organizationalunit_SyncErrors"></a> msdyn_organizationalunit_SyncErrors

**Added by**: Universal Resource Scheduling Solution

See msdyn_organizationalunit Entity [msdyn_organizationalunit_SyncErrors](msdyn_organizationalunit.md#BKMK_msdyn_organizationalunit_SyncErrors) One-To-Many relationship.

### <a name="BKMK_msdyn_priority_SyncErrors"></a> msdyn_priority_SyncErrors

**Added by**: Universal Resource Scheduling Solution

See msdyn_priority Entity [msdyn_priority_SyncErrors](msdyn_priority.md#BKMK_msdyn_priority_SyncErrors) One-To-Many relationship.

### <a name="BKMK_msdyn_requirementcharacteristic_SyncErrors"></a> msdyn_requirementcharacteristic_SyncErrors

**Added by**: Universal Resource Scheduling Solution

See msdyn_requirementcharacteristic Entity [msdyn_requirementcharacteristic_SyncErrors](msdyn_requirementcharacteristic.md#BKMK_msdyn_requirementcharacteristic_SyncErrors) One-To-Many relationship.

### <a name="BKMK_msdyn_requirementgroup_SyncErrors"></a> msdyn_requirementgroup_SyncErrors

**Added by**: Universal Resource Scheduling Solution

See msdyn_requirementgroup Entity [msdyn_requirementgroup_SyncErrors](msdyn_requirementgroup.md#BKMK_msdyn_requirementgroup_SyncErrors) One-To-Many relationship.

### <a name="BKMK_msdyn_requirementorganizationunit_SyncErrors"></a> msdyn_requirementorganizationunit_SyncErrors

**Added by**: Universal Resource Scheduling Solution

See msdyn_requirementorganizationunit Entity [msdyn_requirementorganizationunit_SyncErrors](msdyn_requirementorganizationunit.md#BKMK_msdyn_requirementorganizationunit_SyncErrors) One-To-Many relationship.

### <a name="BKMK_msdyn_requirementrelationship_SyncErrors"></a> msdyn_requirementrelationship_SyncErrors

**Added by**: Universal Resource Scheduling Solution

See msdyn_requirementrelationship Entity [msdyn_requirementrelationship_SyncErrors](msdyn_requirementrelationship.md#BKMK_msdyn_requirementrelationship_SyncErrors) One-To-Many relationship.

### <a name="BKMK_msdyn_requirementresourcecategory_SyncErrors"></a> msdyn_requirementresourcecategory_SyncErrors

**Added by**: Universal Resource Scheduling Solution

See msdyn_requirementresourcecategory Entity [msdyn_requirementresourcecategory_SyncErrors](msdyn_requirementresourcecategory.md#BKMK_msdyn_requirementresourcecategory_SyncErrors) One-To-Many relationship.

### <a name="BKMK_msdyn_requirementresourcepreference_SyncErrors"></a> msdyn_requirementresourcepreference_SyncErrors

**Added by**: Universal Resource Scheduling Solution

See msdyn_requirementresourcepreference Entity [msdyn_requirementresourcepreference_SyncErrors](msdyn_requirementresourcepreference.md#BKMK_msdyn_requirementresourcepreference_SyncErrors) One-To-Many relationship.

### <a name="BKMK_msdyn_requirementstatus_SyncErrors"></a> msdyn_requirementstatus_SyncErrors

**Added by**: Universal Resource Scheduling Solution

See msdyn_requirementstatus Entity [msdyn_requirementstatus_SyncErrors](msdyn_requirementstatus.md#BKMK_msdyn_requirementstatus_SyncErrors) One-To-Many relationship.

### <a name="BKMK_msdyn_resourcerequirement_SyncErrors"></a> msdyn_resourcerequirement_SyncErrors

**Added by**: Universal Resource Scheduling Solution

See msdyn_resourcerequirement Entity [msdyn_resourcerequirement_SyncErrors](msdyn_resourcerequirement.md#BKMK_msdyn_resourcerequirement_SyncErrors) One-To-Many relationship.

### <a name="BKMK_msdyn_resourcerequirementdetail_SyncErrors"></a> msdyn_resourcerequirementdetail_SyncErrors

**Added by**: Universal Resource Scheduling Solution

See msdyn_resourcerequirementdetail Entity [msdyn_resourcerequirementdetail_SyncErrors](msdyn_resourcerequirementdetail.md#BKMK_msdyn_resourcerequirementdetail_SyncErrors) One-To-Many relationship.

### <a name="BKMK_msdyn_resourceterritory_SyncErrors"></a> msdyn_resourceterritory_SyncErrors

**Added by**: Universal Resource Scheduling Solution

See msdyn_resourceterritory Entity [msdyn_resourceterritory_SyncErrors](msdyn_resourceterritory.md#BKMK_msdyn_resourceterritory_SyncErrors) One-To-Many relationship.

### <a name="BKMK_msdyn_scheduleboardsetting_SyncErrors"></a> msdyn_scheduleboardsetting_SyncErrors

**Added by**: Universal Resource Scheduling Solution

See msdyn_scheduleboardsetting Entity [msdyn_scheduleboardsetting_SyncErrors](msdyn_scheduleboardsetting.md#BKMK_msdyn_scheduleboardsetting_SyncErrors) One-To-Many relationship.

### <a name="BKMK_msdyn_schedulingparameter_SyncErrors"></a> msdyn_schedulingparameter_SyncErrors

**Added by**: Universal Resource Scheduling Solution

See msdyn_schedulingparameter Entity [msdyn_schedulingparameter_SyncErrors](msdyn_schedulingparameter.md#BKMK_msdyn_schedulingparameter_SyncErrors) One-To-Many relationship.

### <a name="BKMK_msdyn_systemuserschedulersetting_SyncErrors"></a> msdyn_systemuserschedulersetting_SyncErrors

**Added by**: Universal Resource Scheduling Solution

See msdyn_systemuserschedulersetting Entity [msdyn_systemuserschedulersetting_SyncErrors](msdyn_systemuserschedulersetting.md#BKMK_msdyn_systemuserschedulersetting_SyncErrors) One-To-Many relationship.

### <a name="BKMK_msdyn_timegroup_SyncErrors"></a> msdyn_timegroup_SyncErrors

**Added by**: Universal Resource Scheduling Solution

See msdyn_timegroup Entity [msdyn_timegroup_SyncErrors](msdyn_timegroup.md#BKMK_msdyn_timegroup_SyncErrors) One-To-Many relationship.

### <a name="BKMK_msdyn_timegroupdetail_SyncErrors"></a> msdyn_timegroupdetail_SyncErrors

**Added by**: Universal Resource Scheduling Solution

See msdyn_timegroupdetail Entity [msdyn_timegroupdetail_SyncErrors](msdyn_timegroupdetail.md#BKMK_msdyn_timegroupdetail_SyncErrors) One-To-Many relationship.

### <a name="BKMK_msdyn_transactionorigin_SyncErrors"></a> msdyn_transactionorigin_SyncErrors

**Added by**: Universal Resource Scheduling Solution

See msdyn_transactionorigin Entity [msdyn_transactionorigin_SyncErrors](msdyn_transactionorigin.md#BKMK_msdyn_transactionorigin_SyncErrors) One-To-Many relationship.

### <a name="BKMK_msdyn_workhourtemplate_SyncErrors"></a> msdyn_workhourtemplate_SyncErrors

**Added by**: Universal Resource Scheduling Solution

See msdyn_workhourtemplate Entity [msdyn_workhourtemplate_SyncErrors](msdyn_workhourtemplate.md#BKMK_msdyn_workhourtemplate_SyncErrors) One-To-Many relationship.

### <a name="BKMK_msdyn_accountpricelist_SyncErrors"></a> msdyn_accountpricelist_SyncErrors

**Added by**: Project Service Automation Solution

See msdyn_accountpricelist Entity [msdyn_accountpricelist_SyncErrors](msdyn_accountpricelist.md#BKMK_msdyn_accountpricelist_SyncErrors) One-To-Many relationship.

### <a name="BKMK_msdyn_approval_SyncErrors"></a> msdyn_approval_SyncErrors

**Added by**: Active Solution Solution

See msdyn_approval Entity [msdyn_approval_SyncErrors](msdyn_approval.md#BKMK_msdyn_approval_SyncErrors) One-To-Many relationship.

### <a name="BKMK_msdyn_batchjob_SyncErrors"></a> msdyn_batchjob_SyncErrors

**Added by**: Project Service Automation Solution

See msdyn_batchjob Entity [msdyn_batchjob_SyncErrors](msdyn_batchjob.md#BKMK_msdyn_batchjob_SyncErrors) One-To-Many relationship.

### <a name="BKMK_msdyn_bpf_665e73aa18c247d886bfc50499c73b82_SyncErrors"></a> msdyn_bpf_665e73aa18c247d886bfc50499c73b82_SyncErrors

**Added by**: Project Service Automation Solution

See msdyn_bpf_665e73aa18c247d886bfc50499c73b82 Entity [msdyn_bpf_665e73aa18c247d886bfc50499c73b82_SyncErrors](msdyn_bpf_665e73aa18c247d886bfc50499c73b82.md#BKMK_msdyn_bpf_665e73aa18c247d886bfc50499c73b82_SyncErrors) One-To-Many relationship.

### <a name="BKMK_msdyn_bpf_d8f9dc7f099f44db9d641dd81fbd470d_SyncErrors"></a> msdyn_bpf_d8f9dc7f099f44db9d641dd81fbd470d_SyncErrors

**Added by**: Project Service Automation Solution

See msdyn_bpf_d8f9dc7f099f44db9d641dd81fbd470d Entity [msdyn_bpf_d8f9dc7f099f44db9d641dd81fbd470d_SyncErrors](msdyn_bpf_d8f9dc7f099f44db9d641dd81fbd470d.md#BKMK_msdyn_bpf_d8f9dc7f099f44db9d641dd81fbd470d_SyncErrors) One-To-Many relationship.

### <a name="BKMK_msdyn_characteristicreqforteammember_SyncErrors"></a> msdyn_characteristicreqforteammember_SyncErrors

**Added by**: Project Service Automation Solution

See msdyn_characteristicreqforteammember Entity [msdyn_characteristicreqforteammember_SyncErrors](msdyn_characteristicreqforteammember.md#BKMK_msdyn_characteristicreqforteammember_SyncErrors) One-To-Many relationship.

### <a name="BKMK_msdyn_contactpricelist_SyncErrors"></a> msdyn_contactpricelist_SyncErrors

**Added by**: Project Service Automation Solution

See msdyn_contactpricelist Entity [msdyn_contactpricelist_SyncErrors](msdyn_contactpricelist.md#BKMK_msdyn_contactpricelist_SyncErrors) One-To-Many relationship.

### <a name="BKMK_msdyn_contractlineinvoiceschedule_SyncErrors"></a> msdyn_contractlineinvoiceschedule_SyncErrors

**Added by**: Project Service Automation Solution

See msdyn_contractlineinvoiceschedule Entity [msdyn_contractlineinvoiceschedule_SyncErrors](msdyn_contractlineinvoiceschedule.md#BKMK_msdyn_contractlineinvoiceschedule_SyncErrors) One-To-Many relationship.

### <a name="BKMK_msdyn_contractlinescheduleofvalue_SyncErrors"></a> msdyn_contractlinescheduleofvalue_SyncErrors

**Added by**: Project Service Automation Solution

See msdyn_contractlinescheduleofvalue Entity [msdyn_contractlinescheduleofvalue_SyncErrors](msdyn_contractlinescheduleofvalue.md#BKMK_msdyn_contractlinescheduleofvalue_SyncErrors) One-To-Many relationship.

### <a name="BKMK_msdyn_dataexport_SyncErrors"></a> msdyn_dataexport_SyncErrors

**Added by**: Project Service Automation Solution

See msdyn_dataexport Entity [msdyn_dataexport_SyncErrors](msdyn_dataexport.md#BKMK_msdyn_dataexport_SyncErrors) One-To-Many relationship.

### <a name="BKMK_msdyn_delegation_SyncErrors"></a> msdyn_delegation_SyncErrors

**Added by**: Project Service Automation Solution

See msdyn_delegation Entity [msdyn_delegation_SyncErrors](msdyn_delegation.md#BKMK_msdyn_delegation_SyncErrors) One-To-Many relationship.

### <a name="BKMK_msdyn_dimension_SyncErrors"></a> msdyn_dimension_SyncErrors

**Added by**: Project Service Automation Solution

See msdyn_dimension Entity [msdyn_dimension_SyncErrors](msdyn_dimension.md#BKMK_msdyn_dimension_SyncErrors) One-To-Many relationship.

### <a name="BKMK_msdyn_dimensionfieldname_SyncErrors"></a> msdyn_dimensionfieldname_SyncErrors

**Added by**: Project Service Automation Solution

See msdyn_dimensionfieldname Entity [msdyn_dimensionfieldname_SyncErrors](msdyn_dimensionfieldname.md#BKMK_msdyn_dimensionfieldname_SyncErrors) One-To-Many relationship.

### <a name="BKMK_msdyn_estimate_SyncErrors"></a> msdyn_estimate_SyncErrors

**Added by**: Project Service Automation Solution

See msdyn_estimate Entity [msdyn_estimate_SyncErrors](msdyn_estimate.md#BKMK_msdyn_estimate_SyncErrors) One-To-Many relationship.

### <a name="BKMK_msdyn_estimateline_SyncErrors"></a> msdyn_estimateline_SyncErrors

**Added by**: Project Service Automation Solution

See msdyn_estimateline Entity [msdyn_estimateline_SyncErrors](msdyn_estimateline.md#BKMK_msdyn_estimateline_SyncErrors) One-To-Many relationship.

### <a name="BKMK_msdyn_expense_SyncErrors"></a> msdyn_expense_SyncErrors

**Added by**: Project Service Automation Solution

See msdyn_expense Entity [msdyn_expense_SyncErrors](msdyn_expense.md#BKMK_msdyn_expense_SyncErrors) One-To-Many relationship.

### <a name="BKMK_msdyn_expensecategory_SyncErrors"></a> msdyn_expensecategory_SyncErrors

**Added by**: Project Service Automation Solution

See msdyn_expensecategory Entity [msdyn_expensecategory_SyncErrors](msdyn_expensecategory.md#BKMK_msdyn_expensecategory_SyncErrors) One-To-Many relationship.

### <a name="BKMK_msdyn_expensereceipt_SyncErrors"></a> msdyn_expensereceipt_SyncErrors

**Added by**: Project Service Automation Solution

See msdyn_expensereceipt Entity [msdyn_expensereceipt_SyncErrors](msdyn_expensereceipt.md#BKMK_msdyn_expensereceipt_SyncErrors) One-To-Many relationship.

### <a name="BKMK_msdyn_fact_SyncErrors"></a> msdyn_fact_SyncErrors

**Added by**: Project Service Automation Solution

See msdyn_fact Entity [msdyn_fact_SyncErrors](msdyn_fact.md#BKMK_msdyn_fact_SyncErrors) One-To-Many relationship.

### <a name="BKMK_msdyn_fieldcomputation_SyncErrors"></a> msdyn_fieldcomputation_SyncErrors

**Added by**: Project Service Automation Solution

See msdyn_fieldcomputation Entity [msdyn_fieldcomputation_SyncErrors](msdyn_fieldcomputation.md#BKMK_msdyn_fieldcomputation_SyncErrors) One-To-Many relationship.

### <a name="BKMK_msdyn_findworkevent_SyncErrors"></a> msdyn_findworkevent_SyncErrors

**Added by**: Project Service Automation Solution

See msdyn_findworkevent Entity [msdyn_findworkevent_SyncErrors](msdyn_findworkevent.md#BKMK_msdyn_findworkevent_SyncErrors) One-To-Many relationship.

### <a name="BKMK_msdyn_integrationjob_SyncErrors"></a> msdyn_integrationjob_SyncErrors

**Added by**: Project Service Automation Solution

See msdyn_integrationjob Entity [msdyn_integrationjob_SyncErrors](msdyn_integrationjob.md#BKMK_msdyn_integrationjob_SyncErrors) One-To-Many relationship.

### <a name="BKMK_msdyn_integrationjobdetail_SyncErrors"></a> msdyn_integrationjobdetail_SyncErrors

**Added by**: Project Service Automation Solution

See msdyn_integrationjobdetail Entity [msdyn_integrationjobdetail_SyncErrors](msdyn_integrationjobdetail.md#BKMK_msdyn_integrationjobdetail_SyncErrors) One-To-Many relationship.

### <a name="BKMK_msdyn_invoicefrequency_SyncErrors"></a> msdyn_invoicefrequency_SyncErrors

**Added by**: Project Service Automation Solution

See msdyn_invoicefrequency Entity [msdyn_invoicefrequency_SyncErrors](msdyn_invoicefrequency.md#BKMK_msdyn_invoicefrequency_SyncErrors) One-To-Many relationship.

### <a name="BKMK_msdyn_invoicefrequencydetail_SyncErrors"></a> msdyn_invoicefrequencydetail_SyncErrors

**Added by**: Project Service Automation Solution

See msdyn_invoicefrequencydetail Entity [msdyn_invoicefrequencydetail_SyncErrors](msdyn_invoicefrequencydetail.md#BKMK_msdyn_invoicefrequencydetail_SyncErrors) One-To-Many relationship.

### <a name="BKMK_msdyn_invoicelinetransaction_SyncErrors"></a> msdyn_invoicelinetransaction_SyncErrors

**Added by**: Project Service Automation Solution

See msdyn_invoicelinetransaction Entity [msdyn_invoicelinetransaction_SyncErrors](msdyn_invoicelinetransaction.md#BKMK_msdyn_invoicelinetransaction_SyncErrors) One-To-Many relationship.

### <a name="BKMK_msdyn_journal_SyncErrors"></a> msdyn_journal_SyncErrors

**Added by**: Project Service Automation Solution

See msdyn_journal Entity [msdyn_journal_SyncErrors](msdyn_journal.md#BKMK_msdyn_journal_SyncErrors) One-To-Many relationship.

### <a name="BKMK_msdyn_journalline_SyncErrors"></a> msdyn_journalline_SyncErrors

**Added by**: Project Service Automation Solution

See msdyn_journalline Entity [msdyn_journalline_SyncErrors](msdyn_journalline.md#BKMK_msdyn_journalline_SyncErrors) One-To-Many relationship.

### <a name="BKMK_msdyn_mlresultcache_SyncErrors"></a> msdyn_mlresultcache_SyncErrors

**Added by**: Project Service Automation Solution

See msdyn_mlresultcache Entity [msdyn_mlresultcache_SyncErrors](msdyn_mlresultcache.md#BKMK_msdyn_mlresultcache_SyncErrors) One-To-Many relationship.

### <a name="BKMK_msdyn_opportunitylineresourcecategory_SyncErrors"></a> msdyn_opportunitylineresourcecategory_SyncErrors

**Added by**: Project Service Automation Solution

See msdyn_opportunitylineresourcecategory Entity [msdyn_opportunitylineresourcecategory_SyncErrors](msdyn_opportunitylineresourcecategory.md#BKMK_msdyn_opportunitylineresourcecategory_SyncErrors) One-To-Many relationship.

### <a name="BKMK_msdyn_opportunitylinetransaction_SyncErrors"></a> msdyn_opportunitylinetransaction_SyncErrors

**Added by**: Project Service Automation Solution

See msdyn_opportunitylinetransaction Entity [msdyn_opportunitylinetransaction_SyncErrors](msdyn_opportunitylinetransaction.md#BKMK_msdyn_opportunitylinetransaction_SyncErrors) One-To-Many relationship.

### <a name="BKMK_msdyn_opportunitylinetransactioncategory_SyncErrors"></a> msdyn_opportunitylinetransactioncategory_SyncErrors

**Added by**: Project Service Automation Solution

See msdyn_opportunitylinetransactioncategory Entity [msdyn_opportunitylinetransactioncategory_SyncErrors](msdyn_opportunitylinetransactioncategory.md#BKMK_msdyn_opportunitylinetransactioncategory_SyncErrors) One-To-Many relationship.

### <a name="BKMK_msdyn_opportunitylinetransactionclassificatio_SyncErrors"></a> msdyn_opportunitylinetransactionclassificatio_SyncErrors

**Added by**: Project Service Automation Solution

See msdyn_opportunitylinetransactionclassificatio Entity [msdyn_opportunitylinetransactionclassificatio_SyncErrors](msdyn_opportunitylinetransactionclassificatio.md#BKMK_msdyn_opportunitylinetransactionclassificatio_SyncErrors) One-To-Many relationship.

### <a name="BKMK_msdyn_opportunitypricelist_SyncErrors"></a> msdyn_opportunitypricelist_SyncErrors

**Added by**: Project Service Automation Solution

See msdyn_opportunitypricelist Entity [msdyn_opportunitypricelist_SyncErrors](msdyn_opportunitypricelist.md#BKMK_msdyn_opportunitypricelist_SyncErrors) One-To-Many relationship.

### <a name="BKMK_msdyn_orderlineresourcecategory_SyncErrors"></a> msdyn_orderlineresourcecategory_SyncErrors

**Added by**: Project Service Automation Solution

See msdyn_orderlineresourcecategory Entity [msdyn_orderlineresourcecategory_SyncErrors](msdyn_orderlineresourcecategory.md#BKMK_msdyn_orderlineresourcecategory_SyncErrors) One-To-Many relationship.

### <a name="BKMK_msdyn_orderlinetransaction_SyncErrors"></a> msdyn_orderlinetransaction_SyncErrors

**Added by**: Project Service Automation Solution

See msdyn_orderlinetransaction Entity [msdyn_orderlinetransaction_SyncErrors](msdyn_orderlinetransaction.md#BKMK_msdyn_orderlinetransaction_SyncErrors) One-To-Many relationship.

### <a name="BKMK_msdyn_orderlinetransactioncategory_SyncErrors"></a> msdyn_orderlinetransactioncategory_SyncErrors

**Added by**: Project Service Automation Solution

See msdyn_orderlinetransactioncategory Entity [msdyn_orderlinetransactioncategory_SyncErrors](msdyn_orderlinetransactioncategory.md#BKMK_msdyn_orderlinetransactioncategory_SyncErrors) One-To-Many relationship.

### <a name="BKMK_msdyn_orderlinetransactionclassification_SyncErrors"></a> msdyn_orderlinetransactionclassification_SyncErrors

**Added by**: Project Service Automation Solution

See msdyn_orderlinetransactionclassification Entity [msdyn_orderlinetransactionclassification_SyncErrors](msdyn_orderlinetransactionclassification.md#BKMK_msdyn_orderlinetransactionclassification_SyncErrors) One-To-Many relationship.

### <a name="BKMK_msdyn_orderpricelist_SyncErrors"></a> msdyn_orderpricelist_SyncErrors

**Added by**: Project Service Automation Solution

See msdyn_orderpricelist Entity [msdyn_orderpricelist_SyncErrors](msdyn_orderpricelist.md#BKMK_msdyn_orderpricelist_SyncErrors) One-To-Many relationship.

### <a name="BKMK_msdyn_processnotes_SyncErrors"></a> msdyn_processnotes_SyncErrors

**Added by**: Project Service Automation Solution

See msdyn_processnotes Entity [msdyn_processnotes_SyncErrors](msdyn_processnotes.md#BKMK_msdyn_processnotes_SyncErrors) One-To-Many relationship.

### <a name="BKMK_msdyn_project_SyncErrors"></a> msdyn_project_SyncErrors

**Added by**: Project Service Automation Solution

See msdyn_project Entity [msdyn_project_SyncErrors](msdyn_project.md#BKMK_msdyn_project_SyncErrors) One-To-Many relationship.

### <a name="BKMK_msdyn_projectapproval_SyncErrors"></a> msdyn_projectapproval_SyncErrors

**Added by**: Project Service Automation Solution

See msdyn_projectapproval Entity [msdyn_projectapproval_SyncErrors](msdyn_projectapproval.md#BKMK_msdyn_projectapproval_SyncErrors) One-To-Many relationship.

### <a name="BKMK_msdyn_projectparameter_SyncErrors"></a> msdyn_projectparameter_SyncErrors

**Added by**: Project Service Automation Solution

See msdyn_projectparameter Entity [msdyn_projectparameter_SyncErrors](msdyn_projectparameter.md#BKMK_msdyn_projectparameter_SyncErrors) One-To-Many relationship.

### <a name="BKMK_msdyn_projectparameterpricelist_SyncErrors"></a> msdyn_projectparameterpricelist_SyncErrors

**Added by**: Project Service Automation Solution

See msdyn_projectparameterpricelist Entity [msdyn_projectparameterpricelist_SyncErrors](msdyn_projectparameterpricelist.md#BKMK_msdyn_projectparameterpricelist_SyncErrors) One-To-Many relationship.

### <a name="BKMK_msdyn_projectpricelist_SyncErrors"></a> msdyn_projectpricelist_SyncErrors

**Added by**: Project Service Automation Solution

See msdyn_projectpricelist Entity [msdyn_projectpricelist_SyncErrors](msdyn_projectpricelist.md#BKMK_msdyn_projectpricelist_SyncErrors) One-To-Many relationship.

### <a name="BKMK_msdyn_projecttask_SyncErrors"></a> msdyn_projecttask_SyncErrors

**Added by**: Project Service Automation Solution

See msdyn_projecttask Entity [msdyn_projecttask_SyncErrors](msdyn_projecttask.md#BKMK_msdyn_projecttask_SyncErrors) One-To-Many relationship.

### <a name="BKMK_msdyn_projecttaskdependency_SyncErrors"></a> msdyn_projecttaskdependency_SyncErrors

**Added by**: Project Service Automation Solution

See msdyn_projecttaskdependency Entity [msdyn_projecttaskdependency_SyncErrors](msdyn_projecttaskdependency.md#BKMK_msdyn_projecttaskdependency_SyncErrors) One-To-Many relationship.

### <a name="BKMK_msdyn_projecttaskstatususer_SyncErrors"></a> msdyn_projecttaskstatususer_SyncErrors

**Added by**: Project Service Automation Solution

See msdyn_projecttaskstatususer Entity [msdyn_projecttaskstatususer_SyncErrors](msdyn_projecttaskstatususer.md#BKMK_msdyn_projecttaskstatususer_SyncErrors) One-To-Many relationship.

### <a name="BKMK_msdyn_projectteam_SyncErrors"></a> msdyn_projectteam_SyncErrors

**Added by**: Project Service Automation Solution

See msdyn_projectteam Entity [msdyn_projectteam_SyncErrors](msdyn_projectteam.md#BKMK_msdyn_projectteam_SyncErrors) One-To-Many relationship.

### <a name="BKMK_msdyn_projectteammembersignup_SyncErrors"></a> msdyn_projectteammembersignup_SyncErrors

**Added by**: Project Service Automation Solution

See msdyn_projectteammembersignup Entity [msdyn_projectteammembersignup_SyncErrors](msdyn_projectteammembersignup.md#BKMK_msdyn_projectteammembersignup_SyncErrors) One-To-Many relationship.

### <a name="BKMK_msdyn_projecttransactioncategory_SyncErrors"></a> msdyn_projecttransactioncategory_SyncErrors

**Added by**: Project Service Automation Solution

See msdyn_projecttransactioncategory Entity [msdyn_projecttransactioncategory_SyncErrors](msdyn_projecttransactioncategory.md#BKMK_msdyn_projecttransactioncategory_SyncErrors) One-To-Many relationship.

### <a name="BKMK_msdyn_quotelineanalyticsbreakdown_SyncErrors"></a> msdyn_quotelineanalyticsbreakdown_SyncErrors

**Added by**: Project Service Automation Solution

See msdyn_quotelineanalyticsbreakdown Entity [msdyn_quotelineanalyticsbreakdown_SyncErrors](msdyn_quotelineanalyticsbreakdown.md#BKMK_msdyn_quotelineanalyticsbreakdown_SyncErrors) One-To-Many relationship.

### <a name="BKMK_msdyn_quotelineinvoiceschedule_SyncErrors"></a> msdyn_quotelineinvoiceschedule_SyncErrors

**Added by**: Project Service Automation Solution

See msdyn_quotelineinvoiceschedule Entity [msdyn_quotelineinvoiceschedule_SyncErrors](msdyn_quotelineinvoiceschedule.md#BKMK_msdyn_quotelineinvoiceschedule_SyncErrors) One-To-Many relationship.

### <a name="BKMK_msdyn_quotelineresourcecategory_SyncErrors"></a> msdyn_quotelineresourcecategory_SyncErrors

**Added by**: Project Service Automation Solution

See msdyn_quotelineresourcecategory Entity [msdyn_quotelineresourcecategory_SyncErrors](msdyn_quotelineresourcecategory.md#BKMK_msdyn_quotelineresourcecategory_SyncErrors) One-To-Many relationship.

### <a name="BKMK_msdyn_quotelinescheduleofvalue_SyncErrors"></a> msdyn_quotelinescheduleofvalue_SyncErrors

**Added by**: Project Service Automation Solution

See msdyn_quotelinescheduleofvalue Entity [msdyn_quotelinescheduleofvalue_SyncErrors](msdyn_quotelinescheduleofvalue.md#BKMK_msdyn_quotelinescheduleofvalue_SyncErrors) One-To-Many relationship.

### <a name="BKMK_msdyn_quotelinetransaction_SyncErrors"></a> msdyn_quotelinetransaction_SyncErrors

**Added by**: Project Service Automation Solution

See msdyn_quotelinetransaction Entity [msdyn_quotelinetransaction_SyncErrors](msdyn_quotelinetransaction.md#BKMK_msdyn_quotelinetransaction_SyncErrors) One-To-Many relationship.

### <a name="BKMK_msdyn_quotelinetransactioncategory_SyncErrors"></a> msdyn_quotelinetransactioncategory_SyncErrors

**Added by**: Project Service Automation Solution

See msdyn_quotelinetransactioncategory Entity [msdyn_quotelinetransactioncategory_SyncErrors](msdyn_quotelinetransactioncategory.md#BKMK_msdyn_quotelinetransactioncategory_SyncErrors) One-To-Many relationship.

### <a name="BKMK_msdyn_quotelinetransactionclassification_SyncErrors"></a> msdyn_quotelinetransactionclassification_SyncErrors

**Added by**: Project Service Automation Solution

See msdyn_quotelinetransactionclassification Entity [msdyn_quotelinetransactionclassification_SyncErrors](msdyn_quotelinetransactionclassification.md#BKMK_msdyn_quotelinetransactionclassification_SyncErrors) One-To-Many relationship.

### <a name="BKMK_msdyn_quotepricelist_SyncErrors"></a> msdyn_quotepricelist_SyncErrors

**Added by**: Project Service Automation Solution

See msdyn_quotepricelist Entity [msdyn_quotepricelist_SyncErrors](msdyn_quotepricelist.md#BKMK_msdyn_quotepricelist_SyncErrors) One-To-Many relationship.

### <a name="BKMK_msdyn_resourceassignment_SyncErrors"></a> msdyn_resourceassignment_SyncErrors

**Added by**: Project Service Automation Solution

See msdyn_resourceassignment Entity [msdyn_resourceassignment_SyncErrors](msdyn_resourceassignment.md#BKMK_msdyn_resourceassignment_SyncErrors) One-To-Many relationship.

### <a name="BKMK_msdyn_resourceassignmentdetail_SyncErrors"></a> msdyn_resourceassignmentdetail_SyncErrors

**Added by**: Project Service Automation Solution

See msdyn_resourceassignmentdetail Entity [msdyn_resourceassignmentdetail_SyncErrors](msdyn_resourceassignmentdetail.md#BKMK_msdyn_resourceassignmentdetail_SyncErrors) One-To-Many relationship.

### <a name="BKMK_msdyn_resourcecategorymarkuppricelevel_SyncErrors"></a> msdyn_resourcecategorymarkuppricelevel_SyncErrors

**Added by**: Project Service Automation Solution

See msdyn_resourcecategorymarkuppricelevel Entity [msdyn_resourcecategorymarkuppricelevel_SyncErrors](msdyn_resourcecategorymarkuppricelevel.md#BKMK_msdyn_resourcecategorymarkuppricelevel_SyncErrors) One-To-Many relationship.

### <a name="BKMK_msdyn_resourcecategorypricelevel_SyncErrors"></a> msdyn_resourcecategorypricelevel_SyncErrors

**Added by**: Project Service Automation Solution

See msdyn_resourcecategorypricelevel Entity [msdyn_resourcecategorypricelevel_SyncErrors](msdyn_resourcecategorypricelevel.md#BKMK_msdyn_resourcecategorypricelevel_SyncErrors) One-To-Many relationship.

### <a name="BKMK_msdyn_resourcerequest_SyncErrors"></a> msdyn_resourcerequest_SyncErrors

**Added by**: Project Service Automation Solution

See msdyn_resourcerequest Entity [msdyn_resourcerequest_SyncErrors](msdyn_resourcerequest.md#BKMK_msdyn_resourcerequest_SyncErrors) One-To-Many relationship.

### <a name="BKMK_msdyn_rolecompetencyrequirement_SyncErrors"></a> msdyn_rolecompetencyrequirement_SyncErrors

**Added by**: Project Service Automation Solution

See msdyn_rolecompetencyrequirement Entity [msdyn_rolecompetencyrequirement_SyncErrors](msdyn_rolecompetencyrequirement.md#BKMK_msdyn_rolecompetencyrequirement_SyncErrors) One-To-Many relationship.

### <a name="BKMK_msdyn_roleutilization_SyncErrors"></a> msdyn_roleutilization_SyncErrors

**Added by**: Project Service Automation Solution

See msdyn_roleutilization Entity [msdyn_roleutilization_SyncErrors](msdyn_roleutilization.md#BKMK_msdyn_roleutilization_SyncErrors) One-To-Many relationship.

### <a name="BKMK_msdyn_timeentry_SyncErrors"></a> msdyn_timeentry_SyncErrors

**Added by**: Project Service Automation Solution

See msdyn_timeentry Entity [msdyn_timeentry_SyncErrors](msdyn_timeentry.md#BKMK_msdyn_timeentry_SyncErrors) One-To-Many relationship.

### <a name="BKMK_msdyn_timeoffcalendar_SyncErrors"></a> msdyn_timeoffcalendar_SyncErrors

**Added by**: Project Service Automation Solution

See msdyn_timeoffcalendar Entity [msdyn_timeoffcalendar_SyncErrors](msdyn_timeoffcalendar.md#BKMK_msdyn_timeoffcalendar_SyncErrors) One-To-Many relationship.

### <a name="BKMK_msdyn_transactioncategory_SyncErrors"></a> msdyn_transactioncategory_SyncErrors

**Added by**: Project Service Automation Solution

See msdyn_transactioncategory Entity [msdyn_transactioncategory_SyncErrors](msdyn_transactioncategory.md#BKMK_msdyn_transactioncategory_SyncErrors) One-To-Many relationship.

### <a name="BKMK_msdyn_transactioncategoryclassification_SyncErrors"></a> msdyn_transactioncategoryclassification_SyncErrors

**Added by**: Project Service Automation Solution

See msdyn_transactioncategoryclassification Entity [msdyn_transactioncategoryclassification_SyncErrors](msdyn_transactioncategoryclassification.md#BKMK_msdyn_transactioncategoryclassification_SyncErrors) One-To-Many relationship.

### <a name="BKMK_msdyn_transactioncategoryhierarchyelement_SyncErrors"></a> msdyn_transactioncategoryhierarchyelement_SyncErrors

**Added by**: Project Service Automation Solution

See msdyn_transactioncategoryhierarchyelement Entity [msdyn_transactioncategoryhierarchyelement_SyncErrors](msdyn_transactioncategoryhierarchyelement.md#BKMK_msdyn_transactioncategoryhierarchyelement_SyncErrors) One-To-Many relationship.

### <a name="BKMK_msdyn_transactioncategorypricelevel_SyncErrors"></a> msdyn_transactioncategorypricelevel_SyncErrors

**Added by**: Project Service Automation Solution

See msdyn_transactioncategorypricelevel Entity [msdyn_transactioncategorypricelevel_SyncErrors](msdyn_transactioncategorypricelevel.md#BKMK_msdyn_transactioncategorypricelevel_SyncErrors) One-To-Many relationship.

### <a name="BKMK_msdyn_transactionconnection_SyncErrors"></a> msdyn_transactionconnection_SyncErrors

**Added by**: Project Service Automation Solution

See msdyn_transactionconnection Entity [msdyn_transactionconnection_SyncErrors](msdyn_transactionconnection.md#BKMK_msdyn_transactionconnection_SyncErrors) One-To-Many relationship.

### <a name="BKMK_msdyn_transactiontype_SyncErrors"></a> msdyn_transactiontype_SyncErrors

**Added by**: Project Service Automation Solution

See msdyn_transactiontype Entity [msdyn_transactiontype_SyncErrors](msdyn_transactiontype.md#BKMK_msdyn_transactiontype_SyncErrors) One-To-Many relationship.

### <a name="BKMK_msdyn_userworkhistory_SyncErrors"></a> msdyn_userworkhistory_SyncErrors

**Added by**: Project Service Automation Solution

See msdyn_userworkhistory Entity [msdyn_userworkhistory_SyncErrors](msdyn_userworkhistory.md#BKMK_msdyn_userworkhistory_SyncErrors) One-To-Many relationship.

### <a name="BKMK_msdyn_agreement_SyncErrors"></a> msdyn_agreement_SyncErrors

**Added by**: Field Service Solution

See msdyn_agreement Entity [msdyn_agreement_SyncErrors](msdyn_agreement.md#BKMK_msdyn_agreement_SyncErrors) One-To-Many relationship.

### <a name="BKMK_msdyn_agreementbookingdate_SyncErrors"></a> msdyn_agreementbookingdate_SyncErrors

**Added by**: Field Service Solution

See msdyn_agreementbookingdate Entity [msdyn_agreementbookingdate_SyncErrors](msdyn_agreementbookingdate.md#BKMK_msdyn_agreementbookingdate_SyncErrors) One-To-Many relationship.

### <a name="BKMK_msdyn_agreementbookingincident_SyncErrors"></a> msdyn_agreementbookingincident_SyncErrors

**Added by**: Field Service Solution

See msdyn_agreementbookingincident Entity [msdyn_agreementbookingincident_SyncErrors](msdyn_agreementbookingincident.md#BKMK_msdyn_agreementbookingincident_SyncErrors) One-To-Many relationship.

### <a name="BKMK_msdyn_agreementbookingproduct_SyncErrors"></a> msdyn_agreementbookingproduct_SyncErrors

**Added by**: Field Service Solution

See msdyn_agreementbookingproduct Entity [msdyn_agreementbookingproduct_SyncErrors](msdyn_agreementbookingproduct.md#BKMK_msdyn_agreementbookingproduct_SyncErrors) One-To-Many relationship.

### <a name="BKMK_msdyn_agreementbookingservice_SyncErrors"></a> msdyn_agreementbookingservice_SyncErrors

**Added by**: Field Service Solution

See msdyn_agreementbookingservice Entity [msdyn_agreementbookingservice_SyncErrors](msdyn_agreementbookingservice.md#BKMK_msdyn_agreementbookingservice_SyncErrors) One-To-Many relationship.

### <a name="BKMK_msdyn_agreementbookingservicetask_SyncErrors"></a> msdyn_agreementbookingservicetask_SyncErrors

**Added by**: Field Service Solution

See msdyn_agreementbookingservicetask Entity [msdyn_agreementbookingservicetask_SyncErrors](msdyn_agreementbookingservicetask.md#BKMK_msdyn_agreementbookingservicetask_SyncErrors) One-To-Many relationship.

### <a name="BKMK_msdyn_agreementbookingsetup_SyncErrors"></a> msdyn_agreementbookingsetup_SyncErrors

**Added by**: Field Service Solution

See msdyn_agreementbookingsetup Entity [msdyn_agreementbookingsetup_SyncErrors](msdyn_agreementbookingsetup.md#BKMK_msdyn_agreementbookingsetup_SyncErrors) One-To-Many relationship.

### <a name="BKMK_msdyn_agreementinvoicedate_SyncErrors"></a> msdyn_agreementinvoicedate_SyncErrors

**Added by**: Field Service Solution

See msdyn_agreementinvoicedate Entity [msdyn_agreementinvoicedate_SyncErrors](msdyn_agreementinvoicedate.md#BKMK_msdyn_agreementinvoicedate_SyncErrors) One-To-Many relationship.

### <a name="BKMK_msdyn_agreementinvoiceproduct_SyncErrors"></a> msdyn_agreementinvoiceproduct_SyncErrors

**Added by**: Field Service Solution

See msdyn_agreementinvoiceproduct Entity [msdyn_agreementinvoiceproduct_SyncErrors](msdyn_agreementinvoiceproduct.md#BKMK_msdyn_agreementinvoiceproduct_SyncErrors) One-To-Many relationship.

### <a name="BKMK_msdyn_agreementinvoicesetup_SyncErrors"></a> msdyn_agreementinvoicesetup_SyncErrors

**Added by**: Field Service Solution

See msdyn_agreementinvoicesetup Entity [msdyn_agreementinvoicesetup_SyncErrors](msdyn_agreementinvoicesetup.md#BKMK_msdyn_agreementinvoicesetup_SyncErrors) One-To-Many relationship.

### <a name="BKMK_msdyn_agreementsubstatus_SyncErrors"></a> msdyn_agreementsubstatus_SyncErrors

**Added by**: Field Service Solution

See msdyn_agreementsubstatus Entity [msdyn_agreementsubstatus_SyncErrors](msdyn_agreementsubstatus.md#BKMK_msdyn_agreementsubstatus_SyncErrors) One-To-Many relationship.

### <a name="BKMK_msdyn_bookingjournal_SyncErrors"></a> msdyn_bookingjournal_SyncErrors

**Added by**: Field Service Solution

See msdyn_bookingjournal Entity [msdyn_bookingjournal_SyncErrors](msdyn_bookingjournal.md#BKMK_msdyn_bookingjournal_SyncErrors) One-To-Many relationship.

### <a name="BKMK_msdyn_bookingtimestamp_SyncErrors"></a> msdyn_bookingtimestamp_SyncErrors

**Added by**: Field Service Solution

See msdyn_bookingtimestamp Entity [msdyn_bookingtimestamp_SyncErrors](msdyn_bookingtimestamp.md#BKMK_msdyn_bookingtimestamp_SyncErrors) One-To-Many relationship.

### <a name="BKMK_msdyn_bpf_2c5fe86acc8b414b8322ae571000c799_SyncErrors"></a> msdyn_bpf_2c5fe86acc8b414b8322ae571000c799_SyncErrors

**Added by**: Field Service Solution

See msdyn_bpf_2c5fe86acc8b414b8322ae571000c799 Entity [msdyn_bpf_2c5fe86acc8b414b8322ae571000c799_SyncErrors](msdyn_bpf_2c5fe86acc8b414b8322ae571000c799.md#BKMK_msdyn_bpf_2c5fe86acc8b414b8322ae571000c799_SyncErrors) One-To-Many relationship.

### <a name="BKMK_msdyn_bpf_989e9b1857e24af18787d5143b67523b_SyncErrors"></a> msdyn_bpf_989e9b1857e24af18787d5143b67523b_SyncErrors

**Added by**: Field Service Solution

See msdyn_bpf_989e9b1857e24af18787d5143b67523b Entity [msdyn_bpf_989e9b1857e24af18787d5143b67523b_SyncErrors](msdyn_bpf_989e9b1857e24af18787d5143b67523b.md#BKMK_msdyn_bpf_989e9b1857e24af18787d5143b67523b_SyncErrors) One-To-Many relationship.

### <a name="BKMK_msdyn_bpf_baa0a411a239410cb8bded8b5fdd88e3_SyncErrors"></a> msdyn_bpf_baa0a411a239410cb8bded8b5fdd88e3_SyncErrors

**Added by**: Field Service Solution

See msdyn_bpf_baa0a411a239410cb8bded8b5fdd88e3 Entity [msdyn_bpf_baa0a411a239410cb8bded8b5fdd88e3_SyncErrors](msdyn_bpf_baa0a411a239410cb8bded8b5fdd88e3.md#BKMK_msdyn_bpf_baa0a411a239410cb8bded8b5fdd88e3_SyncErrors) One-To-Many relationship.

### <a name="BKMK_msdyn_bpf_d3d97bac8c294105840e99e37a9d1c39_SyncErrors"></a> msdyn_bpf_d3d97bac8c294105840e99e37a9d1c39_SyncErrors

**Added by**: Field Service Solution

See msdyn_bpf_d3d97bac8c294105840e99e37a9d1c39 Entity [msdyn_bpf_d3d97bac8c294105840e99e37a9d1c39_SyncErrors](msdyn_bpf_d3d97bac8c294105840e99e37a9d1c39.md#BKMK_msdyn_bpf_d3d97bac8c294105840e99e37a9d1c39_SyncErrors) One-To-Many relationship.

### <a name="BKMK_msdyn_customerasset_SyncErrors"></a> msdyn_customerasset_SyncErrors

**Added by**: Field Service Solution

See msdyn_customerasset Entity [msdyn_customerasset_SyncErrors](msdyn_customerasset.md#BKMK_msdyn_customerasset_SyncErrors) One-To-Many relationship.

### <a name="BKMK_msdyn_customerassetcategory_SyncErrors"></a> msdyn_customerassetcategory_SyncErrors

**Added by**: Field Service Solution

See msdyn_customerassetcategory Entity [msdyn_customerassetcategory_SyncErrors](msdyn_customerassetcategory.md#BKMK_msdyn_customerassetcategory_SyncErrors) One-To-Many relationship.

### <a name="BKMK_msdyn_entitlementapplication_SyncErrors"></a> msdyn_entitlementapplication_SyncErrors

**Added by**: Field Service Solution

See msdyn_entitlementapplication Entity [msdyn_entitlementapplication_SyncErrors](msdyn_entitlementapplication.md#BKMK_msdyn_entitlementapplication_SyncErrors) One-To-Many relationship.

### <a name="BKMK_msdyn_fieldservicepricelistitem_SyncErrors"></a> msdyn_fieldservicepricelistitem_SyncErrors

**Added by**: Field Service Solution

See msdyn_fieldservicepricelistitem Entity [msdyn_fieldservicepricelistitem_SyncErrors](msdyn_fieldservicepricelistitem.md#BKMK_msdyn_fieldservicepricelistitem_SyncErrors) One-To-Many relationship.

### <a name="BKMK_msdyn_fieldservicesetting_SyncErrors"></a> msdyn_fieldservicesetting_SyncErrors

**Added by**: Field Service Solution

See msdyn_fieldservicesetting Entity [msdyn_fieldservicesetting_SyncErrors](msdyn_fieldservicesetting.md#BKMK_msdyn_fieldservicesetting_SyncErrors) One-To-Many relationship.

### <a name="BKMK_msdyn_fieldserviceslaconfiguration_SyncErrors"></a> msdyn_fieldserviceslaconfiguration_SyncErrors

**Added by**: Field Service Solution

See msdyn_fieldserviceslaconfiguration Entity [msdyn_fieldserviceslaconfiguration_SyncErrors](msdyn_fieldserviceslaconfiguration.md#BKMK_msdyn_fieldserviceslaconfiguration_SyncErrors) One-To-Many relationship.

### <a name="BKMK_msdyn_fieldservicesystemjob_SyncErrors"></a> msdyn_fieldservicesystemjob_SyncErrors

**Added by**: Field Service Solution

See msdyn_fieldservicesystemjob Entity [msdyn_fieldservicesystemjob_SyncErrors](msdyn_fieldservicesystemjob.md#BKMK_msdyn_fieldservicesystemjob_SyncErrors) One-To-Many relationship.

### <a name="BKMK_msdyn_incidenttype_SyncErrors"></a> msdyn_incidenttype_SyncErrors

**Added by**: Field Service Solution

See msdyn_incidenttype Entity [msdyn_incidenttype_SyncErrors](msdyn_incidenttype.md#BKMK_msdyn_incidenttype_SyncErrors) One-To-Many relationship.

### <a name="BKMK_msdyn_incidenttypecharacteristic_SyncErrors"></a> msdyn_incidenttypecharacteristic_SyncErrors

**Added by**: Field Service Solution

See msdyn_incidenttypecharacteristic Entity [msdyn_incidenttypecharacteristic_SyncErrors](msdyn_incidenttypecharacteristic.md#BKMK_msdyn_incidenttypecharacteristic_SyncErrors) One-To-Many relationship.

### <a name="BKMK_msdyn_incidenttypeproduct_SyncErrors"></a> msdyn_incidenttypeproduct_SyncErrors

**Added by**: Field Service Solution

See msdyn_incidenttypeproduct Entity [msdyn_incidenttypeproduct_SyncErrors](msdyn_incidenttypeproduct.md#BKMK_msdyn_incidenttypeproduct_SyncErrors) One-To-Many relationship.

### <a name="BKMK_msdyn_incidenttypeservice_SyncErrors"></a> msdyn_incidenttypeservice_SyncErrors

**Added by**: Field Service Solution

See msdyn_incidenttypeservice Entity [msdyn_incidenttypeservice_SyncErrors](msdyn_incidenttypeservice.md#BKMK_msdyn_incidenttypeservice_SyncErrors) One-To-Many relationship.

### <a name="BKMK_msdyn_incidenttypeservicetask_SyncErrors"></a> msdyn_incidenttypeservicetask_SyncErrors

**Added by**: Field Service Solution

See msdyn_incidenttypeservicetask Entity [msdyn_incidenttypeservicetask_SyncErrors](msdyn_incidenttypeservicetask.md#BKMK_msdyn_incidenttypeservicetask_SyncErrors) One-To-Many relationship.

### <a name="BKMK_msdyn_incidenttypessetup_SyncErrors"></a> msdyn_incidenttypessetup_SyncErrors

**Added by**: Field Service Solution

See msdyn_incidenttypessetup Entity [msdyn_incidenttypessetup_SyncErrors](msdyn_incidenttypessetup.md#BKMK_msdyn_incidenttypessetup_SyncErrors) One-To-Many relationship.

### <a name="BKMK_msdyn_incidenttype_requirementgroup_SyncErrors"></a> msdyn_incidenttype_requirementgroup_SyncErrors

**Added by**: Field Service Solution

See msdyn_incidenttype_requirementgroup Entity [msdyn_incidenttype_requirementgroup_SyncErrors](msdyn_incidenttype_requirementgroup.md#BKMK_msdyn_incidenttype_requirementgroup_SyncErrors) One-To-Many relationship.

### <a name="BKMK_msdyn_inventoryadjustment_SyncErrors"></a> msdyn_inventoryadjustment_SyncErrors

**Added by**: Field Service Solution

See msdyn_inventoryadjustment Entity [msdyn_inventoryadjustment_SyncErrors](msdyn_inventoryadjustment.md#BKMK_msdyn_inventoryadjustment_SyncErrors) One-To-Many relationship.

### <a name="BKMK_msdyn_inventoryadjustmentproduct_SyncErrors"></a> msdyn_inventoryadjustmentproduct_SyncErrors

**Added by**: Field Service Solution

See msdyn_inventoryadjustmentproduct Entity [msdyn_inventoryadjustmentproduct_SyncErrors](msdyn_inventoryadjustmentproduct.md#BKMK_msdyn_inventoryadjustmentproduct_SyncErrors) One-To-Many relationship.

### <a name="BKMK_msdyn_inventoryjournal_SyncErrors"></a> msdyn_inventoryjournal_SyncErrors

**Added by**: Field Service Solution

See msdyn_inventoryjournal Entity [msdyn_inventoryjournal_SyncErrors](msdyn_inventoryjournal.md#BKMK_msdyn_inventoryjournal_SyncErrors) One-To-Many relationship.

### <a name="BKMK_msdyn_inventorytransfer_SyncErrors"></a> msdyn_inventorytransfer_SyncErrors

**Added by**: Field Service Solution

See msdyn_inventorytransfer Entity [msdyn_inventorytransfer_SyncErrors](msdyn_inventorytransfer.md#BKMK_msdyn_inventorytransfer_SyncErrors) One-To-Many relationship.

### <a name="BKMK_msdyn_orderinvoicingdate_SyncErrors"></a> msdyn_orderinvoicingdate_SyncErrors

**Added by**: Field Service Solution

See msdyn_orderinvoicingdate Entity [msdyn_orderinvoicingdate_SyncErrors](msdyn_orderinvoicingdate.md#BKMK_msdyn_orderinvoicingdate_SyncErrors) One-To-Many relationship.

### <a name="BKMK_msdyn_orderinvoicingproduct_SyncErrors"></a> msdyn_orderinvoicingproduct_SyncErrors

**Added by**: Field Service Solution

See msdyn_orderinvoicingproduct Entity [msdyn_orderinvoicingproduct_SyncErrors](msdyn_orderinvoicingproduct.md#BKMK_msdyn_orderinvoicingproduct_SyncErrors) One-To-Many relationship.

### <a name="BKMK_msdyn_orderinvoicingsetup_SyncErrors"></a> msdyn_orderinvoicingsetup_SyncErrors

**Added by**: Field Service Solution

See msdyn_orderinvoicingsetup Entity [msdyn_orderinvoicingsetup_SyncErrors](msdyn_orderinvoicingsetup.md#BKMK_msdyn_orderinvoicingsetup_SyncErrors) One-To-Many relationship.

### <a name="BKMK_msdyn_orderinvoicingsetupdate_SyncErrors"></a> msdyn_orderinvoicingsetupdate_SyncErrors

**Added by**: Field Service Solution

See msdyn_orderinvoicingsetupdate Entity [msdyn_orderinvoicingsetupdate_SyncErrors](msdyn_orderinvoicingsetupdate.md#BKMK_msdyn_orderinvoicingsetupdate_SyncErrors) One-To-Many relationship.

### <a name="BKMK_msdyn_payment_SyncErrors"></a> msdyn_payment_SyncErrors

**Added by**: Field Service Solution

See msdyn_payment Entity [msdyn_payment_SyncErrors](msdyn_payment.md#BKMK_msdyn_payment_SyncErrors) One-To-Many relationship.

### <a name="BKMK_msdyn_paymentdetail_SyncErrors"></a> msdyn_paymentdetail_SyncErrors

**Added by**: Field Service Solution

See msdyn_paymentdetail Entity [msdyn_paymentdetail_SyncErrors](msdyn_paymentdetail.md#BKMK_msdyn_paymentdetail_SyncErrors) One-To-Many relationship.

### <a name="BKMK_msdyn_paymentmethod_SyncErrors"></a> msdyn_paymentmethod_SyncErrors

**Added by**: Field Service Solution

See msdyn_paymentmethod Entity [msdyn_paymentmethod_SyncErrors](msdyn_paymentmethod.md#BKMK_msdyn_paymentmethod_SyncErrors) One-To-Many relationship.

### <a name="BKMK_msdyn_paymentterm_SyncErrors"></a> msdyn_paymentterm_SyncErrors

**Added by**: Field Service Solution

See msdyn_paymentterm Entity [msdyn_paymentterm_SyncErrors](msdyn_paymentterm.md#BKMK_msdyn_paymentterm_SyncErrors) One-To-Many relationship.

### <a name="BKMK_msdyn_postalcode_SyncErrors"></a> msdyn_postalcode_SyncErrors

**Added by**: Field Service Solution

See msdyn_postalcode Entity [msdyn_postalcode_SyncErrors](msdyn_postalcode.md#BKMK_msdyn_postalcode_SyncErrors) One-To-Many relationship.

### <a name="BKMK_msdyn_productinventory_SyncErrors"></a> msdyn_productinventory_SyncErrors

**Added by**: Field Service Solution

See msdyn_productinventory Entity [msdyn_productinventory_SyncErrors](msdyn_productinventory.md#BKMK_msdyn_productinventory_SyncErrors) One-To-Many relationship.

### <a name="BKMK_msdyn_purchaseorder_SyncErrors"></a> msdyn_purchaseorder_SyncErrors

**Added by**: Field Service Solution

See msdyn_purchaseorder Entity [msdyn_purchaseorder_SyncErrors](msdyn_purchaseorder.md#BKMK_msdyn_purchaseorder_SyncErrors) One-To-Many relationship.

### <a name="BKMK_msdyn_purchaseorderbill_SyncErrors"></a> msdyn_purchaseorderbill_SyncErrors

**Added by**: Field Service Solution

See msdyn_purchaseorderbill Entity [msdyn_purchaseorderbill_SyncErrors](msdyn_purchaseorderbill.md#BKMK_msdyn_purchaseorderbill_SyncErrors) One-To-Many relationship.

### <a name="BKMK_msdyn_purchaseorderproduct_SyncErrors"></a> msdyn_purchaseorderproduct_SyncErrors

**Added by**: Field Service Solution

See msdyn_purchaseorderproduct Entity [msdyn_purchaseorderproduct_SyncErrors](msdyn_purchaseorderproduct.md#BKMK_msdyn_purchaseorderproduct_SyncErrors) One-To-Many relationship.

### <a name="BKMK_msdyn_purchaseorderreceipt_SyncErrors"></a> msdyn_purchaseorderreceipt_SyncErrors

**Added by**: Field Service Solution

See msdyn_purchaseorderreceipt Entity [msdyn_purchaseorderreceipt_SyncErrors](msdyn_purchaseorderreceipt.md#BKMK_msdyn_purchaseorderreceipt_SyncErrors) One-To-Many relationship.

### <a name="BKMK_msdyn_purchaseorderreceiptproduct_SyncErrors"></a> msdyn_purchaseorderreceiptproduct_SyncErrors

**Added by**: Field Service Solution

See msdyn_purchaseorderreceiptproduct Entity [msdyn_purchaseorderreceiptproduct_SyncErrors](msdyn_purchaseorderreceiptproduct.md#BKMK_msdyn_purchaseorderreceiptproduct_SyncErrors) One-To-Many relationship.

### <a name="BKMK_msdyn_purchaseordersubstatus_SyncErrors"></a> msdyn_purchaseordersubstatus_SyncErrors

**Added by**: Field Service Solution

See msdyn_purchaseordersubstatus Entity [msdyn_purchaseordersubstatus_SyncErrors](msdyn_purchaseordersubstatus.md#BKMK_msdyn_purchaseordersubstatus_SyncErrors) One-To-Many relationship.

### <a name="BKMK_msdyn_quotebookingincident_SyncErrors"></a> msdyn_quotebookingincident_SyncErrors

**Added by**: Field Service Solution

See msdyn_quotebookingincident Entity [msdyn_quotebookingincident_SyncErrors](msdyn_quotebookingincident.md#BKMK_msdyn_quotebookingincident_SyncErrors) One-To-Many relationship.

### <a name="BKMK_msdyn_quotebookingproduct_SyncErrors"></a> msdyn_quotebookingproduct_SyncErrors

**Added by**: Field Service Solution

See msdyn_quotebookingproduct Entity [msdyn_quotebookingproduct_SyncErrors](msdyn_quotebookingproduct.md#BKMK_msdyn_quotebookingproduct_SyncErrors) One-To-Many relationship.

### <a name="BKMK_msdyn_quotebookingservice_SyncErrors"></a> msdyn_quotebookingservice_SyncErrors

**Added by**: Field Service Solution

See msdyn_quotebookingservice Entity [msdyn_quotebookingservice_SyncErrors](msdyn_quotebookingservice.md#BKMK_msdyn_quotebookingservice_SyncErrors) One-To-Many relationship.

### <a name="BKMK_msdyn_quotebookingservicetask_SyncErrors"></a> msdyn_quotebookingservicetask_SyncErrors

**Added by**: Field Service Solution

See msdyn_quotebookingservicetask Entity [msdyn_quotebookingservicetask_SyncErrors](msdyn_quotebookingservicetask.md#BKMK_msdyn_quotebookingservicetask_SyncErrors) One-To-Many relationship.

### <a name="BKMK_msdyn_quotebookingsetup_SyncErrors"></a> msdyn_quotebookingsetup_SyncErrors

**Added by**: Field Service Solution

See msdyn_quotebookingsetup Entity [msdyn_quotebookingsetup_SyncErrors](msdyn_quotebookingsetup.md#BKMK_msdyn_quotebookingsetup_SyncErrors) One-To-Many relationship.

### <a name="BKMK_msdyn_quoteinvoicingproduct_SyncErrors"></a> msdyn_quoteinvoicingproduct_SyncErrors

**Added by**: Field Service Solution

See msdyn_quoteinvoicingproduct Entity [msdyn_quoteinvoicingproduct_SyncErrors](msdyn_quoteinvoicingproduct.md#BKMK_msdyn_quoteinvoicingproduct_SyncErrors) One-To-Many relationship.

### <a name="BKMK_msdyn_quoteinvoicingsetup_SyncErrors"></a> msdyn_quoteinvoicingsetup_SyncErrors

**Added by**: Field Service Solution

See msdyn_quoteinvoicingsetup Entity [msdyn_quoteinvoicingsetup_SyncErrors](msdyn_quoteinvoicingsetup.md#BKMK_msdyn_quoteinvoicingsetup_SyncErrors) One-To-Many relationship.

### <a name="BKMK_msdyn_resourcepaytype_SyncErrors"></a> msdyn_resourcepaytype_SyncErrors

**Added by**: Field Service Solution

See msdyn_resourcepaytype Entity [msdyn_resourcepaytype_SyncErrors](msdyn_resourcepaytype.md#BKMK_msdyn_resourcepaytype_SyncErrors) One-To-Many relationship.

### <a name="BKMK_msdyn_rma_SyncErrors"></a> msdyn_rma_SyncErrors

**Added by**: Field Service Solution

See msdyn_rma Entity [msdyn_rma_SyncErrors](msdyn_rma.md#BKMK_msdyn_rma_SyncErrors) One-To-Many relationship.

### <a name="BKMK_msdyn_rmaproduct_SyncErrors"></a> msdyn_rmaproduct_SyncErrors

**Added by**: Field Service Solution

See msdyn_rmaproduct Entity [msdyn_rmaproduct_SyncErrors](msdyn_rmaproduct.md#BKMK_msdyn_rmaproduct_SyncErrors) One-To-Many relationship.

### <a name="BKMK_msdyn_rmareceipt_SyncErrors"></a> msdyn_rmareceipt_SyncErrors

**Added by**: Field Service Solution

See msdyn_rmareceipt Entity [msdyn_rmareceipt_SyncErrors](msdyn_rmareceipt.md#BKMK_msdyn_rmareceipt_SyncErrors) One-To-Many relationship.

### <a name="BKMK_msdyn_rmareceiptproduct_SyncErrors"></a> msdyn_rmareceiptproduct_SyncErrors

**Added by**: Field Service Solution

See msdyn_rmareceiptproduct Entity [msdyn_rmareceiptproduct_SyncErrors](msdyn_rmareceiptproduct.md#BKMK_msdyn_rmareceiptproduct_SyncErrors) One-To-Many relationship.

### <a name="BKMK_msdyn_rmasubstatus_SyncErrors"></a> msdyn_rmasubstatus_SyncErrors

**Added by**: Field Service Solution

See msdyn_rmasubstatus Entity [msdyn_rmasubstatus_SyncErrors](msdyn_rmasubstatus.md#BKMK_msdyn_rmasubstatus_SyncErrors) One-To-Many relationship.

### <a name="BKMK_msdyn_rtv_SyncErrors"></a> msdyn_rtv_SyncErrors

**Added by**: Field Service Solution

See msdyn_rtv Entity [msdyn_rtv_SyncErrors](msdyn_rtv.md#BKMK_msdyn_rtv_SyncErrors) One-To-Many relationship.

### <a name="BKMK_msdyn_rtvproduct_SyncErrors"></a> msdyn_rtvproduct_SyncErrors

**Added by**: Field Service Solution

See msdyn_rtvproduct Entity [msdyn_rtvproduct_SyncErrors](msdyn_rtvproduct.md#BKMK_msdyn_rtvproduct_SyncErrors) One-To-Many relationship.

### <a name="BKMK_msdyn_rtvsubstatus_SyncErrors"></a> msdyn_rtvsubstatus_SyncErrors

**Added by**: Field Service Solution

See msdyn_rtvsubstatus Entity [msdyn_rtvsubstatus_SyncErrors](msdyn_rtvsubstatus.md#BKMK_msdyn_rtvsubstatus_SyncErrors) One-To-Many relationship.

### <a name="BKMK_msdyn_servicetasktype_SyncErrors"></a> msdyn_servicetasktype_SyncErrors

**Added by**: Field Service Solution

See msdyn_servicetasktype Entity [msdyn_servicetasktype_SyncErrors](msdyn_servicetasktype.md#BKMK_msdyn_servicetasktype_SyncErrors) One-To-Many relationship.

### <a name="BKMK_msdyn_shipvia_SyncErrors"></a> msdyn_shipvia_SyncErrors

**Added by**: Field Service Solution

See msdyn_shipvia Entity [msdyn_shipvia_SyncErrors](msdyn_shipvia.md#BKMK_msdyn_shipvia_SyncErrors) One-To-Many relationship.

### <a name="BKMK_msdyn_taxcode_SyncErrors"></a> msdyn_taxcode_SyncErrors

**Added by**: Field Service Solution

See msdyn_taxcode Entity [msdyn_taxcode_SyncErrors](msdyn_taxcode.md#BKMK_msdyn_taxcode_SyncErrors) One-To-Many relationship.

### <a name="BKMK_msdyn_taxcodedetail_SyncErrors"></a> msdyn_taxcodedetail_SyncErrors

**Added by**: Field Service Solution

See msdyn_taxcodedetail Entity [msdyn_taxcodedetail_SyncErrors](msdyn_taxcodedetail.md#BKMK_msdyn_taxcodedetail_SyncErrors) One-To-Many relationship.

### <a name="BKMK_msdyn_timeoffrequest_SyncErrors"></a> msdyn_timeoffrequest_SyncErrors

**Added by**: Field Service Solution

See msdyn_timeoffrequest Entity [msdyn_timeoffrequest_SyncErrors](msdyn_timeoffrequest.md#BKMK_msdyn_timeoffrequest_SyncErrors) One-To-Many relationship.

### <a name="BKMK_msdyn_uniquenumber_SyncErrors"></a> msdyn_uniquenumber_SyncErrors

**Added by**: Field Service Solution

See msdyn_uniquenumber Entity [msdyn_uniquenumber_SyncErrors](msdyn_uniquenumber.md#BKMK_msdyn_uniquenumber_SyncErrors) One-To-Many relationship.

### <a name="BKMK_msdyn_warehouse_SyncErrors"></a> msdyn_warehouse_SyncErrors

**Added by**: Field Service Solution

See msdyn_warehouse Entity [msdyn_warehouse_SyncErrors](msdyn_warehouse.md#BKMK_msdyn_warehouse_SyncErrors) One-To-Many relationship.

### <a name="BKMK_msdyn_workorder_SyncErrors"></a> msdyn_workorder_SyncErrors

**Added by**: Field Service Solution

See msdyn_workorder Entity [msdyn_workorder_SyncErrors](msdyn_workorder.md#BKMK_msdyn_workorder_SyncErrors) One-To-Many relationship.

### <a name="BKMK_msdyn_workordercharacteristic_SyncErrors"></a> msdyn_workordercharacteristic_SyncErrors

**Added by**: Field Service Solution

See msdyn_workordercharacteristic Entity [msdyn_workordercharacteristic_SyncErrors](msdyn_workordercharacteristic.md#BKMK_msdyn_workordercharacteristic_SyncErrors) One-To-Many relationship.

### <a name="BKMK_msdyn_workorderdetailsgenerationqueue_SyncErrors"></a> msdyn_workorderdetailsgenerationqueue_SyncErrors

**Added by**: Field Service Solution

See msdyn_workorderdetailsgenerationqueue Entity [msdyn_workorderdetailsgenerationqueue_SyncErrors](msdyn_workorderdetailsgenerationqueue.md#BKMK_msdyn_workorderdetailsgenerationqueue_SyncErrors) One-To-Many relationship.

### <a name="BKMK_msdyn_workorderincident_SyncErrors"></a> msdyn_workorderincident_SyncErrors

**Added by**: Field Service Solution

See msdyn_workorderincident Entity [msdyn_workorderincident_SyncErrors](msdyn_workorderincident.md#BKMK_msdyn_workorderincident_SyncErrors) One-To-Many relationship.

### <a name="BKMK_msdyn_workorderproduct_SyncErrors"></a> msdyn_workorderproduct_SyncErrors

**Added by**: Field Service Solution

See msdyn_workorderproduct Entity [msdyn_workorderproduct_SyncErrors](msdyn_workorderproduct.md#BKMK_msdyn_workorderproduct_SyncErrors) One-To-Many relationship.

### <a name="BKMK_msdyn_workorderresourcerestriction_SyncErrors"></a> msdyn_workorderresourcerestriction_SyncErrors

**Added by**: Field Service Solution

See msdyn_workorderresourcerestriction Entity [msdyn_workorderresourcerestriction_SyncErrors](msdyn_workorderresourcerestriction.md#BKMK_msdyn_workorderresourcerestriction_SyncErrors) One-To-Many relationship.

### <a name="BKMK_msdyn_workorderservice_SyncErrors"></a> msdyn_workorderservice_SyncErrors

**Added by**: Field Service Solution

See msdyn_workorderservice Entity [msdyn_workorderservice_SyncErrors](msdyn_workorderservice.md#BKMK_msdyn_workorderservice_SyncErrors) One-To-Many relationship.

### <a name="BKMK_msdyn_workorderservicetask_SyncErrors"></a> msdyn_workorderservicetask_SyncErrors

**Added by**: Field Service Solution

See msdyn_workorderservicetask Entity [msdyn_workorderservicetask_SyncErrors](msdyn_workorderservicetask.md#BKMK_msdyn_workorderservicetask_SyncErrors) One-To-Many relationship.

### <a name="BKMK_msdyn_workordersubstatus_SyncErrors"></a> msdyn_workordersubstatus_SyncErrors

**Added by**: Field Service Solution

See msdyn_workordersubstatus Entity [msdyn_workordersubstatus_SyncErrors](msdyn_workordersubstatus.md#BKMK_msdyn_workordersubstatus_SyncErrors) One-To-Many relationship.

### <a name="BKMK_msdyn_workordertype_SyncErrors"></a> msdyn_workordertype_SyncErrors

**Added by**: Field Service Solution

See msdyn_workordertype Entity [msdyn_workordertype_SyncErrors](msdyn_workordertype.md#BKMK_msdyn_workordertype_SyncErrors) One-To-Many relationship.

### <a name="BKMK_msdyn_iotalert_SyncErrors"></a> msdyn_iotalert_SyncErrors

**Added by**: IoT Connector for Microsoft Dynamics 365 Solution

See msdyn_iotalert Entity [msdyn_iotalert_SyncErrors](msdyn_iotalert.md#BKMK_msdyn_iotalert_SyncErrors) One-To-Many relationship.

### <a name="BKMK_msdyn_iotdevice_SyncErrors"></a> msdyn_iotdevice_SyncErrors

**Added by**: IoT Connector for Microsoft Dynamics 365 Solution

See msdyn_iotdevice Entity [msdyn_iotdevice_SyncErrors](msdyn_iotdevice.md#BKMK_msdyn_iotdevice_SyncErrors) One-To-Many relationship.

### <a name="BKMK_msdyn_iotdevicecategory_SyncErrors"></a> msdyn_iotdevicecategory_SyncErrors

**Added by**: IoT Connector for Microsoft Dynamics 365 Solution

See msdyn_iotdevicecategory Entity [msdyn_iotdevicecategory_SyncErrors](msdyn_iotdevicecategory.md#BKMK_msdyn_iotdevicecategory_SyncErrors) One-To-Many relationship.

### <a name="BKMK_msdyn_iotdevicecommand_SyncErrors"></a> msdyn_iotdevicecommand_SyncErrors

**Added by**: IoT Connector for Microsoft Dynamics 365 Solution

See msdyn_iotdevicecommand Entity [msdyn_iotdevicecommand_SyncErrors](msdyn_iotdevicecommand.md#BKMK_msdyn_iotdevicecommand_SyncErrors) One-To-Many relationship.

### <a name="BKMK_msdyn_iotdevicecommanddefinition_SyncErrors"></a> msdyn_iotdevicecommanddefinition_SyncErrors

**Added by**: IoT Connector for Microsoft Dynamics 365 Solution

See msdyn_iotdevicecommanddefinition Entity [msdyn_iotdevicecommanddefinition_SyncErrors](msdyn_iotdevicecommanddefinition.md#BKMK_msdyn_iotdevicecommanddefinition_SyncErrors) One-To-Many relationship.

### <a name="BKMK_msdyn_iotdevicedatahistory_SyncErrors"></a> msdyn_iotdevicedatahistory_SyncErrors

**Added by**: IoT Connector for Microsoft Dynamics 365 Solution

See msdyn_iotdevicedatahistory Entity [msdyn_iotdevicedatahistory_SyncErrors](msdyn_iotdevicedatahistory.md#BKMK_msdyn_iotdevicedatahistory_SyncErrors) One-To-Many relationship.

### <a name="BKMK_msdyn_iotdeviceproperty_SyncErrors"></a> msdyn_iotdeviceproperty_SyncErrors

**Added by**: IoT Connector for Microsoft Dynamics 365 Solution

See msdyn_iotdeviceproperty Entity [msdyn_iotdeviceproperty_SyncErrors](msdyn_iotdeviceproperty.md#BKMK_msdyn_iotdeviceproperty_SyncErrors) One-To-Many relationship.

### <a name="BKMK_msdyn_iotdeviceregistrationhistory_SyncErrors"></a> msdyn_iotdeviceregistrationhistory_SyncErrors

**Added by**: IoT Connector for Microsoft Dynamics 365 Solution

See msdyn_iotdeviceregistrationhistory Entity [msdyn_iotdeviceregistrationhistory_SyncErrors](msdyn_iotdeviceregistrationhistory.md#BKMK_msdyn_iotdeviceregistrationhistory_SyncErrors) One-To-Many relationship.

### <a name="BKMK_msdyn_iotpropertydefinition_SyncErrors"></a> msdyn_iotpropertydefinition_SyncErrors

**Added by**: IoT Connector for Microsoft Dynamics 365 Solution

See msdyn_iotpropertydefinition Entity [msdyn_iotpropertydefinition_SyncErrors](msdyn_iotpropertydefinition.md#BKMK_msdyn_iotpropertydefinition_SyncErrors) One-To-Many relationship.

### <a name="BKMK_msdyn_iotsettings_SyncErrors"></a> msdyn_iotsettings_SyncErrors

**Added by**: IoT Connector for Microsoft Dynamics 365 Solution

See msdyn_iotsettings Entity [msdyn_iotsettings_SyncErrors](msdyn_iotsettings.md#BKMK_msdyn_iotsettings_SyncErrors) One-To-Many relationship.

### <a name="BKMK_msdyn_bpf_477c16f59170487b8b4dc895c5dcd09b_SyncErrors"></a> msdyn_bpf_477c16f59170487b8b4dc895c5dcd09b_SyncErrors

**Added by**: Connected Field Service for Microsoft Dynamics 365 Solution

See msdyn_bpf_477c16f59170487b8b4dc895c5dcd09b Entity [msdyn_bpf_477c16f59170487b8b4dc895c5dcd09b_SyncErrors](msdyn_bpf_477c16f59170487b8b4dc895c5dcd09b.md#BKMK_msdyn_bpf_477c16f59170487b8b4dc895c5dcd09b_SyncErrors) One-To-Many relationship.

### <a name="BKMK_msdyn_entityconfiguration_SyncErrors"></a> msdyn_entityconfiguration_SyncErrors

**Added by**: Geofence Management Solution

See msdyn_entityconfiguration Entity [msdyn_entityconfiguration_SyncErrors](msdyn_entityconfiguration.md#BKMK_msdyn_entityconfiguration_SyncErrors) One-To-Many relationship.

### <a name="BKMK_msdyn_geofence_SyncErrors"></a> msdyn_geofence_SyncErrors

**Added by**: Geofence Management Solution

See msdyn_geofence Entity [msdyn_geofence_SyncErrors](msdyn_geofence.md#BKMK_msdyn_geofence_SyncErrors) One-To-Many relationship.

### <a name="BKMK_msdyn_geofenceevent_SyncErrors"></a> msdyn_geofenceevent_SyncErrors

**Added by**: Geofence Management Solution

See msdyn_geofenceevent Entity [msdyn_geofenceevent_SyncErrors](msdyn_geofenceevent.md#BKMK_msdyn_geofenceevent_SyncErrors) One-To-Many relationship.

### <a name="BKMK_msdyn_geofencingsettings_SyncErrors"></a> msdyn_geofencingsettings_SyncErrors

**Added by**: Geofence Management Solution

See msdyn_geofencingsettings Entity [msdyn_geofencingsettings_SyncErrors](msdyn_geofencingsettings.md#BKMK_msdyn_geofencingsettings_SyncErrors) One-To-Many relationship.

### <a name="BKMK_msdyn_connector_SyncErrors"></a> msdyn_connector_SyncErrors

**Added by**: Power Connector Solution Solution

See msdyn_connector Entity [msdyn_connector_SyncErrors](msdyn_connector.md#BKMK_msdyn_connector_SyncErrors) One-To-Many relationship.

### <a name="BKMK_KnowledgeBaseRecord_SyncErrors"></a> KnowledgeBaseRecord_SyncErrors

See knowledgebaserecord Entity [KnowledgeBaseRecord_SyncErrors](knowledgebaserecord.md#BKMK_KnowledgeBaseRecord_SyncErrors) One-To-Many relationship.

### <a name="BKMK_SocialProfile_SyncErrors"></a> SocialProfile_SyncErrors

See socialprofile Entity [SocialProfile_SyncErrors](socialprofile.md#BKMK_SocialProfile_SyncErrors) One-To-Many relationship.

### <a name="BKMK_QueueItem_SyncErrors"></a> QueueItem_SyncErrors

See queueitem Entity [QueueItem_SyncErrors](queueitem.md#BKMK_QueueItem_SyncErrors) One-To-Many relationship.

### <a name="BKMK_PostFollow_SyncErrors"></a> PostFollow_SyncErrors

See postfollow Entity [PostFollow_SyncErrors](postfollow.md#BKMK_PostFollow_SyncErrors) One-To-Many relationship.

### <a name="BKMK_SharePointSite_SyncErrors"></a> SharePointSite_SyncErrors

See sharepointsite Entity [SharePointSite_SyncErrors](sharepointsite.md#BKMK_SharePointSite_SyncErrors) One-To-Many relationship.

### <a name="BKMK_Goal_SyncErrors"></a> Goal_SyncErrors

See goal Entity [Goal_SyncErrors](goal.md#BKMK_Goal_SyncErrors) One-To-Many relationship.

### <a name="BKMK_lk_syncerrorbase_createdby"></a> lk_syncerrorbase_createdby

See systemuser Entity [lk_syncerrorbase_createdby](systemuser.md#BKMK_lk_syncerrorbase_createdby) One-To-Many relationship.

### <a name="BKMK_TranslationProcess_SyncErrors"></a> TranslationProcess_SyncErrors

See translationprocess Entity [TranslationProcess_SyncErrors](translationprocess.md#BKMK_TranslationProcess_SyncErrors) One-To-Many relationship.

### <a name="BKMK_PhoneCall_SyncErrors"></a> PhoneCall_SyncErrors

See phonecall Entity [PhoneCall_SyncErrors](phonecall.md#BKMK_PhoneCall_SyncErrors) One-To-Many relationship.

### <a name="BKMK_RecurringAppointmentMaster_SyncErrors"></a> RecurringAppointmentMaster_SyncErrors

See recurringappointmentmaster Entity [RecurringAppointmentMaster_SyncErrors](recurringappointmentmaster.md#BKMK_RecurringAppointmentMaster_SyncErrors) One-To-Many relationship.

### <a name="BKMK_Publisher_SyncErrors"></a> Publisher_SyncErrors

See publisher Entity [Publisher_SyncErrors](publisher.md#BKMK_Publisher_SyncErrors) One-To-Many relationship.

### <a name="BKMK_DuplicateRule_SyncErrors"></a> DuplicateRule_SyncErrors

See duplicaterule Entity [DuplicateRule_SyncErrors](duplicaterule.md#BKMK_DuplicateRule_SyncErrors) One-To-Many relationship.

### <a name="BKMK_Subject_SyncErrors"></a> Subject_SyncErrors

See subject Entity [Subject_SyncErrors](subject.md#BKMK_Subject_SyncErrors) One-To-Many relationship.

### <a name="BKMK_UserQuery_SyncErrors"></a> UserQuery_SyncErrors

See userquery Entity [UserQuery_SyncErrors](userquery.md#BKMK_UserQuery_SyncErrors) One-To-Many relationship.

### <a name="BKMK_MailMergeTemplate_SyncErrors"></a> MailMergeTemplate_SyncErrors

See mailmergetemplate Entity [MailMergeTemplate_SyncErrors](mailmergetemplate.md#BKMK_MailMergeTemplate_SyncErrors) One-To-Many relationship.

### <a name="BKMK_SyncError_SyncErrors"></a> SyncError_SyncErrors

See syncerror Entity [SyncError_SyncErrors](syncerror.md#BKMK_SyncError_SyncErrors) One-To-Many relationship.

### <a name="BKMK_SavedQuery_SyncErrors"></a> SavedQuery_SyncErrors

See savedquery Entity [SavedQuery_SyncErrors](savedquery.md#BKMK_SavedQuery_SyncErrors) One-To-Many relationship.

### <a name="BKMK_lk_syncerrorbase_modifiedby"></a> lk_syncerrorbase_modifiedby

See systemuser Entity [lk_syncerrorbase_modifiedby](systemuser.md#BKMK_lk_syncerrorbase_modifiedby) One-To-Many relationship.

### <a name="BKMK_lk_syncerrorbase_modifiedonbehalfby"></a> lk_syncerrorbase_modifiedonbehalfby

See systemuser Entity [lk_syncerrorbase_modifiedonbehalfby](systemuser.md#BKMK_lk_syncerrorbase_modifiedonbehalfby) One-To-Many relationship.

### <a name="BKMK_TransactionCurrency_SyncErrors"></a> TransactionCurrency_SyncErrors

See transactioncurrency Entity [TransactionCurrency_SyncErrors](transactioncurrency.md#BKMK_TransactionCurrency_SyncErrors) One-To-Many relationship.

### <a name="BKMK_SocialActivity_SyncErrors"></a> SocialActivity_SyncErrors

See socialactivity Entity [SocialActivity_SyncErrors](socialactivity.md#BKMK_SocialActivity_SyncErrors) One-To-Many relationship.

### <a name="BKMK_CustomerAddress_SyncErrors"></a> CustomerAddress_SyncErrors

See customeraddress Entity [CustomerAddress_SyncErrors](customeraddress.md#BKMK_CustomerAddress_SyncErrors) One-To-Many relationship.

### <a name="BKMK_Solution_SyncErrors"></a> Solution_SyncErrors

See solution Entity [Solution_SyncErrors](solution.md#BKMK_Solution_SyncErrors) One-To-Many relationship.

### <a name="BKMK_team_SyncError"></a> team_SyncError

See team Entity [team_SyncError](team.md#BKMK_team_SyncError) One-To-Many relationship.

### <a name="BKMK_TeamTemplate_SyncErrors"></a> TeamTemplate_SyncErrors

See teamtemplate Entity [TeamTemplate_SyncErrors](teamtemplate.md#BKMK_TeamTemplate_SyncErrors) One-To-Many relationship.

### <a name="BKMK_ReportCategory_SyncErrors"></a> ReportCategory_SyncErrors

See reportcategory Entity [ReportCategory_SyncErrors](reportcategory.md#BKMK_ReportCategory_SyncErrors) One-To-Many relationship.

### <a name="BKMK_lk_syncerrorbase_createdonbehalfby"></a> lk_syncerrorbase_createdonbehalfby

See systemuser Entity [lk_syncerrorbase_createdonbehalfby](systemuser.md#BKMK_lk_syncerrorbase_createdonbehalfby) One-To-Many relationship.

### <a name="BKMK_KbArticle_SyncErrors"></a> KbArticle_SyncErrors

See kbarticle Entity [KbArticle_SyncErrors](kbarticle.md#BKMK_KbArticle_SyncErrors) One-To-Many relationship.

### <a name="BKMK_RollupField_SyncErrors"></a> RollupField_SyncErrors

See rollupfield Entity [RollupField_SyncErrors](rollupfield.md#BKMK_RollupField_SyncErrors) One-To-Many relationship.

### <a name="BKMK_KbArticleTemplate_SyncErrors"></a> KbArticleTemplate_SyncErrors

See kbarticletemplate Entity [KbArticleTemplate_SyncErrors](kbarticletemplate.md#BKMK_KbArticleTemplate_SyncErrors) One-To-Many relationship.

### <a name="BKMK_Account_SyncErrors"></a> Account_SyncErrors

See account Entity [Account_SyncErrors](account.md#BKMK_Account_SyncErrors) One-To-Many relationship.

### <a name="BKMK_FieldSecurityProfile_SyncErrors"></a> FieldSecurityProfile_SyncErrors

See fieldsecurityprofile Entity [FieldSecurityProfile_SyncErrors](fieldsecurityprofile.md#BKMK_FieldSecurityProfile_SyncErrors) One-To-Many relationship.

### <a name="BKMK_UserQueryVisualization_SyncErrors"></a> UserQueryVisualization_SyncErrors

See userqueryvisualization Entity [UserQueryVisualization_SyncErrors](userqueryvisualization.md#BKMK_UserQueryVisualization_SyncErrors) One-To-Many relationship.

### <a name="BKMK_FieldPermission_SyncErrors"></a> FieldPermission_SyncErrors

See fieldpermission Entity [FieldPermission_SyncErrors](fieldpermission.md#BKMK_FieldPermission_SyncErrors) One-To-Many relationship.

### <a name="BKMK_DuplicateRuleCondition_SyncErrors"></a> DuplicateRuleCondition_SyncErrors

See duplicaterulecondition Entity [DuplicateRuleCondition_SyncErrors](duplicaterulecondition.md#BKMK_DuplicateRuleCondition_SyncErrors) One-To-Many relationship.

### <a name="BKMK_Team_SyncErrors"></a> Team_SyncErrors

See team Entity [Team_SyncErrors](team.md#BKMK_Team_SyncErrors) One-To-Many relationship.

### <a name="BKMK_SLAItem_SyncErrors"></a> SLAItem_SyncErrors

See slaitem Entity [SLAItem_SyncErrors](slaitem.md#BKMK_SLAItem_SyncErrors) One-To-Many relationship.

### <a name="BKMK_KnowledgeArticleViews_SyncErrors"></a> KnowledgeArticleViews_SyncErrors

See knowledgearticleviews Entity [KnowledgeArticleViews_SyncErrors](knowledgearticleviews.md#BKMK_KnowledgeArticleViews_SyncErrors) One-To-Many relationship.

### <a name="BKMK_Appointment_SyncErrors"></a> Appointment_SyncErrors

See appointment Entity [Appointment_SyncErrors](appointment.md#BKMK_Appointment_SyncErrors) One-To-Many relationship.

### <a name="BKMK_SystemUser_SyncError"></a> SystemUser_SyncError

See systemuser Entity [SystemUser_SyncError](systemuser.md#BKMK_SystemUser_SyncError) One-To-Many relationship.

### <a name="BKMK_Contact_SyncErrors"></a> Contact_SyncErrors

See contact Entity [Contact_SyncErrors](contact.md#BKMK_Contact_SyncErrors) One-To-Many relationship.

### <a name="BKMK_ExpiredProcess_SyncErrors"></a> ExpiredProcess_SyncErrors

See expiredprocess Entity [ExpiredProcess_SyncErrors](expiredprocess.md#BKMK_ExpiredProcess_SyncErrors) One-To-Many relationship.

### <a name="BKMK_Workflow_SyncErrors"></a> Workflow_SyncErrors

See workflow Entity [Workflow_SyncErrors](workflow.md#BKMK_Workflow_SyncErrors) One-To-Many relationship.

### <a name="BKMK_NewProcess_SyncErrors"></a> NewProcess_SyncErrors

See newprocess Entity [NewProcess_SyncErrors](newprocess.md#BKMK_NewProcess_SyncErrors) One-To-Many relationship.

### <a name="BKMK_Feedback_SyncErrors"></a> Feedback_SyncErrors

See feedback Entity [Feedback_SyncErrors](feedback.md#BKMK_Feedback_SyncErrors) One-To-Many relationship.

### <a name="BKMK_ActivityParty_SyncErrors"></a> ActivityParty_SyncErrors

See activityparty Entity [ActivityParty_SyncErrors](activityparty.md#BKMK_ActivityParty_SyncErrors) One-To-Many relationship.

### <a name="BKMK_Annotation_SyncErrors"></a> Annotation_SyncErrors

See annotation Entity [Annotation_SyncErrors](annotation.md#BKMK_Annotation_SyncErrors) One-To-Many relationship.

### <a name="BKMK_Email_SyncErrors"></a> Email_SyncErrors

See email Entity [Email_SyncErrors](email.md#BKMK_Email_SyncErrors) One-To-Many relationship.

### <a name="BKMK_Organization_SyncErrors"></a> Organization_SyncErrors

See organization Entity [Organization_SyncErrors](organization.md#BKMK_Organization_SyncErrors) One-To-Many relationship.

### <a name="BKMK_ActivityMimeAttachment_SyncErrors"></a> ActivityMimeAttachment_SyncErrors

See activitymimeattachment Entity [ActivityMimeAttachment_SyncErrors](activitymimeattachment.md#BKMK_ActivityMimeAttachment_SyncErrors) One-To-Many relationship.

### <a name="BKMK_Task_SyncErrors"></a> Task_SyncErrors

See task Entity [Task_SyncErrors](task.md#BKMK_Task_SyncErrors) One-To-Many relationship.

### <a name="BKMK_Letter_SyncErrors"></a> Letter_SyncErrors

See letter Entity [Letter_SyncErrors](letter.md#BKMK_Letter_SyncErrors) One-To-Many relationship.

### <a name="BKMK_Template_SyncErrors"></a> Template_SyncErrors

See template Entity [Template_SyncErrors](template.md#BKMK_Template_SyncErrors) One-To-Many relationship.

### <a name="BKMK_ProcessStage_SyncErrors"></a> ProcessStage_SyncErrors

See processstage Entity [ProcessStage_SyncErrors](processstage.md#BKMK_ProcessStage_SyncErrors) One-To-Many relationship.

### <a name="BKMK_KnowledgeArticle_SyncErrors"></a> KnowledgeArticle_SyncErrors

See knowledgearticle Entity [KnowledgeArticle_SyncErrors](knowledgearticle.md#BKMK_KnowledgeArticle_SyncErrors) One-To-Many relationship.

### <a name="BKMK_Position_SyncErrors"></a> Position_SyncErrors

See position Entity [Position_SyncErrors](position.md#BKMK_Position_SyncErrors) One-To-Many relationship.

### <a name="BKMK_SharePointDocumentLocation_SyncErrors"></a> SharePointDocumentLocation_SyncErrors

See sharepointdocumentlocation Entity [SharePointDocumentLocation_SyncErrors](sharepointdocumentlocation.md#BKMK_SharePointDocumentLocation_SyncErrors) One-To-Many relationship.

### <a name="BKMK_Report_SyncErrors"></a> Report_SyncErrors

See report Entity [Report_SyncErrors](report.md#BKMK_Report_SyncErrors) One-To-Many relationship.

### <a name="BKMK_Connection_SyncErrors"></a> Connection_SyncErrors

See connection Entity [Connection_SyncErrors](connection.md#BKMK_Connection_SyncErrors) One-To-Many relationship.

### <a name="BKMK_ProcessSession_SyncErrors"></a> ProcessSession_SyncErrors

See processsession Entity [ProcessSession_SyncErrors](processsession.md#BKMK_ProcessSession_SyncErrors) One-To-Many relationship.

### <a name="BKMK_Category_SyncErrors"></a> Category_SyncErrors

See category Entity [Category_SyncErrors](category.md#BKMK_Category_SyncErrors) One-To-Many relationship.

### <a name="BKMK_ConnectionRole_SyncErrors"></a> ConnectionRole_SyncErrors

See connectionrole Entity [ConnectionRole_SyncErrors](connectionrole.md#BKMK_ConnectionRole_SyncErrors) One-To-Many relationship.

### <a name="BKMK_ProcessTrigger_SyncErrors"></a> ProcessTrigger_SyncErrors

See processtrigger Entity [ProcessTrigger_SyncErrors](processtrigger.md#BKMK_ProcessTrigger_SyncErrors) One-To-Many relationship.

### <a name="BKMK_Fax_SyncErrors"></a> Fax_SyncErrors

See fax Entity [Fax_SyncErrors](fax.md#BKMK_Fax_SyncErrors) One-To-Many relationship.

### <a name="BKMK_Mailbox_SyncErrors"></a> Mailbox_SyncErrors

See mailbox Entity [Mailbox_SyncErrors](mailbox.md#BKMK_Mailbox_SyncErrors) One-To-Many relationship.

### <a name="BKMK_BusinessUnit_SyncErrors"></a> BusinessUnit_SyncErrors

See businessunit Entity [BusinessUnit_SyncErrors](businessunit.md#BKMK_BusinessUnit_SyncErrors) One-To-Many relationship.

### <a name="BKMK_Queue_SyncErrors"></a> Queue_SyncErrors

See queue Entity [Queue_SyncErrors](queue.md#BKMK_Queue_SyncErrors) One-To-Many relationship.

### <a name="BKMK_Role_SyncErrors"></a> Role_SyncErrors

See role Entity [Role_SyncErrors](role.md#BKMK_Role_SyncErrors) One-To-Many relationship.

### <a name="BKMK_BusinessUnit_SyncError"></a> BusinessUnit_SyncError

See businessunit Entity [BusinessUnit_SyncError](businessunit.md#BKMK_BusinessUnit_SyncError) One-To-Many relationship.

### <a name="BKMK_SystemUser_SyncErrors"></a> SystemUser_SyncErrors

See systemuser Entity [SystemUser_SyncErrors](systemuser.md#BKMK_SystemUser_SyncErrors) One-To-Many relationship.

### <a name="BKMK_SLAKPIInstance_SyncErrors"></a> SLAKPIInstance_SyncErrors

See slakpiinstance Entity [SLAKPIInstance_SyncErrors](slakpiinstance.md#BKMK_SLAKPIInstance_SyncErrors) One-To-Many relationship.

### <a name="BKMK_SLA_SyncErrors"></a> SLA_SyncErrors

See sla Entity [SLA_SyncErrors](sla.md#BKMK_SLA_SyncErrors) One-To-Many relationship.

### <a name="BKMK_SavedQueryVisualization_SyncErrors"></a> SavedQueryVisualization_SyncErrors

See savedqueryvisualization Entity [SavedQueryVisualization_SyncErrors](savedqueryvisualization.md#BKMK_SavedQueryVisualization_SyncErrors) One-To-Many relationship.

### <a name="BKMK_GoalRollupQuery_SyncErrors"></a> GoalRollupQuery_SyncErrors

See goalrollupquery Entity [GoalRollupQuery_SyncErrors](goalrollupquery.md#BKMK_GoalRollupQuery_SyncErrors) One-To-Many relationship.

### <a name="BKMK_Metric_SyncErrors"></a> Metric_SyncErrors

See metric Entity [Metric_SyncErrors](metric.md#BKMK_Metric_SyncErrors) One-To-Many relationship.

### <a name="BKMK_ImportMap_SyncErrors"></a> ImportMap_SyncErrors

See importmap Entity [ImportMap_SyncErrors](importmap.md#BKMK_ImportMap_SyncErrors) One-To-Many relationship.

### <a name="BKMK_EmailServerProfile_SyncErrors"></a> EmailServerProfile_SyncErrors

See emailserverprofile Entity [EmailServerProfile_SyncErrors](emailserverprofile.md#BKMK_EmailServerProfile_SyncErrors) One-To-Many relationship.

### See also

[About the Entity Reference](../about-entity-reference.md)<br />
[Programming reference for Dynamics 365 Customer Engagement](../programming-reference.md)<br />
[Web API Reference](/dynamics365/customer-engagement/web-api/about)<br />
<xref href="Microsoft.Dynamics.CRM.syncerror?text=syncerror EntityType" />

[!INCLUDE[footer-include](../../../../includes/footer-banner.md)]